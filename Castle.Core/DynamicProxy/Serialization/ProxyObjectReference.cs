using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.Serialization;
using System.Security;
using Castle.DynamicProxy.Generators;
using Castle.DynamicProxy.Internal;

namespace Castle.DynamicProxy.Serialization
{
	// Token: 0x02000025 RID: 37
	[Serializable]
	public class ProxyObjectReference : IObjectReference, ISerializable, IDeserializationCallback
	{
		// Token: 0x06000133 RID: 307 RVA: 0x0000505D File Offset: 0x0000325D
		public static void ResetScope()
		{
			ProxyObjectReference.SetScope(new ModuleScope());
		}

		// Token: 0x06000134 RID: 308 RVA: 0x00005069 File Offset: 0x00003269
		public static void SetScope(ModuleScope scope)
		{
			if (scope == null)
			{
				throw new ArgumentNullException("scope");
			}
			ProxyObjectReference.scope = scope;
		}

		// Token: 0x17000032 RID: 50
		// (get) Token: 0x06000135 RID: 309 RVA: 0x0000507F File Offset: 0x0000327F
		public static ModuleScope ModuleScope
		{
			get
			{
				return ProxyObjectReference.scope;
			}
		}

		// Token: 0x06000136 RID: 310 RVA: 0x00005088 File Offset: 0x00003288
		[SecurityCritical]
		protected ProxyObjectReference(SerializationInfo info, StreamingContext context)
		{
			this.info = info;
			this.context = context;
			this.baseType = this.DeserializeTypeFromString("__baseType");
			string[] array = (string[])info.GetValue("__interfaces", typeof(string[]));
			this.interfaces = new Type[array.Length];
			for (int i = 0; i < array.Length; i++)
			{
				this.interfaces[i] = Type.GetType(array[i]);
			}
			this.proxyGenerationOptions = (ProxyGenerationOptions)info.GetValue("__proxyGenerationOptions", typeof(ProxyGenerationOptions));
			this.proxy = this.RecreateProxy();
			this.DeserializeProxyState();
		}

		// Token: 0x06000137 RID: 311 RVA: 0x00005133 File Offset: 0x00003333
		private Type DeserializeTypeFromString(string key)
		{
			return Type.GetType(this.info.GetString(key), true, false);
		}

		// Token: 0x06000138 RID: 312 RVA: 0x00005148 File Offset: 0x00003348
		[SecurityCritical]
		protected virtual object RecreateProxy()
		{
			string value = this.GetValue<string>("__proxyTypeId");
			if (value.Equals(ProxyTypeConstants.Class))
			{
				this.isInterfaceProxy = false;
				return this.RecreateClassProxy();
			}
			if (value.Equals(ProxyTypeConstants.ClassWithTarget))
			{
				this.isInterfaceProxy = false;
				return this.RecreateClassProxyWithTarget();
			}
			this.isInterfaceProxy = true;
			return this.RecreateInterfaceProxy(value);
		}

		// Token: 0x06000139 RID: 313 RVA: 0x000051A8 File Offset: 0x000033A8
		[SecurityCritical]
		private object RecreateClassProxyWithTarget()
		{
			Type generatedType = new ClassProxyWithTargetGenerator(ProxyObjectReference.scope, this.baseType, this.interfaces, this.proxyGenerationOptions).GetGeneratedType();
			return this.InstantiateClassProxy(generatedType);
		}

		// Token: 0x0600013A RID: 314 RVA: 0x000051E0 File Offset: 0x000033E0
		[SecurityCritical]
		public object RecreateInterfaceProxy(string generatorType)
		{
			Type @interface = this.DeserializeTypeFromString("__theInterface");
			Type proxyTargetType = this.DeserializeTypeFromString("__targetFieldType");
			InterfaceProxyWithTargetGenerator interfaceProxyWithTargetGenerator;
			if (generatorType == ProxyTypeConstants.InterfaceWithTarget)
			{
				interfaceProxyWithTargetGenerator = new InterfaceProxyWithTargetGenerator(ProxyObjectReference.scope, @interface);
			}
			else if (generatorType == ProxyTypeConstants.InterfaceWithoutTarget)
			{
				interfaceProxyWithTargetGenerator = new InterfaceProxyWithoutTargetGenerator(ProxyObjectReference.scope, @interface);
			}
			else
			{
				if (!(generatorType == ProxyTypeConstants.InterfaceWithTargetInterface))
				{
					throw new InvalidOperationException(string.Format("Got value {0} for the interface generator type, which is not known for the purpose of serialization.", generatorType));
				}
				interfaceProxyWithTargetGenerator = new InterfaceProxyWithTargetInterfaceGenerator(ProxyObjectReference.scope, @interface);
			}
			return FormatterServices.GetSafeUninitializedObject(interfaceProxyWithTargetGenerator.GenerateCode(proxyTargetType, this.interfaces, this.proxyGenerationOptions));
		}

		// Token: 0x0600013B RID: 315 RVA: 0x00005280 File Offset: 0x00003480
		[SecurityCritical]
		public object RecreateClassProxy()
		{
			Type proxy_type = new ClassProxyGenerator(ProxyObjectReference.scope, this.baseType).GenerateCode(this.interfaces, this.proxyGenerationOptions);
			return this.InstantiateClassProxy(proxy_type);
		}

		// Token: 0x0600013C RID: 316 RVA: 0x000052B8 File Offset: 0x000034B8
		[SecurityCritical]
		private object InstantiateClassProxy(Type proxy_type)
		{
			this.delegateToBase = this.GetValue<bool>("__delegateToBase");
			if (this.delegateToBase)
			{
				return Activator.CreateInstance(proxy_type, new object[]
				{
					this.info,
					this.context
				});
			}
			return FormatterServices.GetSafeUninitializedObject(proxy_type);
		}

		// Token: 0x0600013D RID: 317 RVA: 0x00005308 File Offset: 0x00003508
		protected void InvokeCallback(object target)
		{
			if (target is IDeserializationCallback)
			{
				(target as IDeserializationCallback).OnDeserialization(this);
			}
		}

		// Token: 0x0600013E RID: 318 RVA: 0x0000531E File Offset: 0x0000351E
		[SecurityCritical]
		public object GetRealObject(StreamingContext context)
		{
			return this.proxy;
		}

		// Token: 0x0600013F RID: 319 RVA: 0x00005326 File Offset: 0x00003526
		[SecurityCritical]
		public void GetObjectData(SerializationInfo info, StreamingContext context)
		{
		}

		// Token: 0x06000140 RID: 320 RVA: 0x00005328 File Offset: 0x00003528
		[SecuritySafeCritical]
		public void OnDeserialization(object sender)
		{
			IInterceptor[] value = this.GetValue<IInterceptor[]>("__interceptors");
			this.SetInterceptors(value);
			this.DeserializeProxyMembers();
			this.DeserializeProxyState();
			this.InvokeCallback(this.proxy);
		}

		// Token: 0x06000141 RID: 321 RVA: 0x00005360 File Offset: 0x00003560
		[SecurityCritical]
		private void DeserializeProxyMembers()
		{
			Type type = this.proxy.GetType();
			MemberInfo[] serializableMembers = FormatterServices.GetSerializableMembers(type);
			List<MemberInfo> list = new List<MemberInfo>();
			List<object> list2 = new List<object>();
			for (int i = 0; i < serializableMembers.Length; i++)
			{
				FieldInfo fieldInfo = serializableMembers[i] as FieldInfo;
				if (!(fieldInfo.DeclaringType != type))
				{
					object value = this.info.GetValue(fieldInfo.Name, fieldInfo.FieldType);
					list.Add(fieldInfo);
					list2.Add(value);
				}
			}
			FormatterServices.PopulateObjectMembers(this.proxy, list.ToArray(), list2.ToArray());
		}

		// Token: 0x06000142 RID: 322 RVA: 0x000053FC File Offset: 0x000035FC
		[SecurityCritical]
		private void DeserializeProxyState()
		{
			if (this.isInterfaceProxy)
			{
				object value = this.GetValue<object>("__target");
				this.SetTarget(value);
				return;
			}
			if (!this.delegateToBase)
			{
				object[] value2 = this.GetValue<object[]>("__data");
				MemberInfo[] members = FormatterServices.GetSerializableMembers(this.baseType);
				members = TypeUtil.Sort(members);
				FormatterServices.PopulateObjectMembers(this.proxy, members, value2);
			}
		}

		// Token: 0x06000143 RID: 323 RVA: 0x0000545A File Offset: 0x0000365A
		private void SetTarget(object target)
		{
			FieldInfo field = this.proxy.GetType().GetField("__target", BindingFlags.Instance | BindingFlags.NonPublic);
			if (field == null)
			{
				throw new SerializationException("The SerializationInfo specifies an invalid interface proxy type, which has no __target field.");
			}
			field.SetValue(this.proxy, target);
		}

		// Token: 0x06000144 RID: 324 RVA: 0x00005493 File Offset: 0x00003693
		private void SetInterceptors(IInterceptor[] interceptors)
		{
			FieldInfo field = this.proxy.GetType().GetField("__interceptors", BindingFlags.Instance | BindingFlags.NonPublic);
			if (field == null)
			{
				throw new SerializationException("The SerializationInfo specifies an invalid proxy type, which has no __interceptors field.");
			}
			field.SetValue(this.proxy, interceptors);
		}

		// Token: 0x06000145 RID: 325 RVA: 0x000054CC File Offset: 0x000036CC
		private T GetValue<T>(string name)
		{
			return (T)((object)this.info.GetValue(name, typeof(T)));
		}

		// Token: 0x04000055 RID: 85
		private static ModuleScope scope = new ModuleScope();

		// Token: 0x04000056 RID: 86
		private readonly SerializationInfo info;

		// Token: 0x04000057 RID: 87
		private readonly StreamingContext context;

		// Token: 0x04000058 RID: 88
		private readonly Type baseType;

		// Token: 0x04000059 RID: 89
		private readonly Type[] interfaces;

		// Token: 0x0400005A RID: 90
		private readonly object proxy;

		// Token: 0x0400005B RID: 91
		private readonly ProxyGenerationOptions proxyGenerationOptions;

		// Token: 0x0400005C RID: 92
		private bool isInterfaceProxy;

		// Token: 0x0400005D RID: 93
		private bool delegateToBase;
	}
}
