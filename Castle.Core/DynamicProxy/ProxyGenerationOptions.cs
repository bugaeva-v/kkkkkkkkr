using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Security;
using Castle.Core.Internal;
using Castle.DynamicProxy.Internal;

namespace Castle.DynamicProxy
{
	// Token: 0x02000018 RID: 24
	[Serializable]
	public class ProxyGenerationOptions : ISerializable
	{
		// Token: 0x060000C4 RID: 196 RVA: 0x00003992 File Offset: 0x00001B92
		public ProxyGenerationOptions(IProxyGenerationHook hook)
		{
			this.BaseTypeForInterfaceProxy = typeof(object);
			this.Hook = hook;
		}

		// Token: 0x060000C5 RID: 197 RVA: 0x000039BC File Offset: 0x00001BBC
		public ProxyGenerationOptions() : this(new AllMethodsHook())
		{
		}

		// Token: 0x060000C6 RID: 198 RVA: 0x000039CC File Offset: 0x00001BCC
		private ProxyGenerationOptions(SerializationInfo info, StreamingContext context)
		{
			this.Hook = (IProxyGenerationHook)info.GetValue("hook", typeof(IProxyGenerationHook));
			this.Selector = (IInterceptorSelector)info.GetValue("selector", typeof(IInterceptorSelector));
			this.mixins = (List<object>)info.GetValue("mixins", typeof(List<object>));
			this.BaseTypeForInterfaceProxy = Type.GetType(info.GetString("baseTypeForInterfaceProxy.AssemblyQualifiedName"));
		}

		// Token: 0x060000C7 RID: 199 RVA: 0x00003A60 File Offset: 0x00001C60
		public void Initialize()
		{
			if (this.mixinData == null)
			{
				try
				{
					this.mixinData = new MixinData(this.mixins);
				}
				catch (ArgumentException ex)
				{
					throw new InvalidMixinConfigurationException("There is a problem with the mixins added to this ProxyGenerationOptions: " + ex.Message, ex);
				}
			}
		}

		// Token: 0x060000C8 RID: 200 RVA: 0x00003AB0 File Offset: 0x00001CB0
		[SecurityCritical]
		public void GetObjectData(SerializationInfo info, StreamingContext context)
		{
			info.AddValue("hook", this.Hook);
			info.AddValue("selector", this.Selector);
			info.AddValue("mixins", this.mixins);
			info.AddValue("baseTypeForInterfaceProxy.AssemblyQualifiedName", this.BaseTypeForInterfaceProxy.AssemblyQualifiedName);
		}

		// Token: 0x17000029 RID: 41
		// (get) Token: 0x060000C9 RID: 201 RVA: 0x00003B06 File Offset: 0x00001D06
		// (set) Token: 0x060000CA RID: 202 RVA: 0x00003B0E File Offset: 0x00001D0E
		public IProxyGenerationHook Hook { get; set; }

		// Token: 0x1700002A RID: 42
		// (get) Token: 0x060000CB RID: 203 RVA: 0x00003B17 File Offset: 0x00001D17
		// (set) Token: 0x060000CC RID: 204 RVA: 0x00003B1F File Offset: 0x00001D1F
		public IInterceptorSelector Selector { get; set; }

		// Token: 0x1700002B RID: 43
		// (get) Token: 0x060000CD RID: 205 RVA: 0x00003B28 File Offset: 0x00001D28
		// (set) Token: 0x060000CE RID: 206 RVA: 0x00003B30 File Offset: 0x00001D30
		public Type BaseTypeForInterfaceProxy { get; set; }

		// Token: 0x1700002C RID: 44
		// (get) Token: 0x060000CF RID: 207 RVA: 0x00003B39 File Offset: 0x00001D39
		public IList<CustomAttributeInfo> AdditionalAttributes
		{
			get
			{
				return this.additionalAttributes;
			}
		}

		// Token: 0x1700002D RID: 45
		// (get) Token: 0x060000D0 RID: 208 RVA: 0x00003B41 File Offset: 0x00001D41
		public MixinData MixinData
		{
			get
			{
				if (this.mixinData == null)
				{
					throw new InvalidOperationException("Call Initialize before accessing the MixinData property.");
				}
				return this.mixinData;
			}
		}

		// Token: 0x060000D1 RID: 209 RVA: 0x00003B5C File Offset: 0x00001D5C
		public void AddDelegateTypeMixin(Type delegateType)
		{
			if (delegateType == null)
			{
				throw new ArgumentNullException("delegateType");
			}
			if (!delegateType.IsDelegateType())
			{
				throw new ArgumentException("Type must be a delegate type.", "delegateType");
			}
			this.AddMixinImpl(delegateType);
		}

		// Token: 0x060000D2 RID: 210 RVA: 0x00003B91 File Offset: 0x00001D91
		public void AddDelegateMixin(Delegate @delegate)
		{
			if (@delegate == null)
			{
				throw new ArgumentNullException("delegate");
			}
			this.AddMixinImpl(@delegate);
		}

		// Token: 0x060000D3 RID: 211 RVA: 0x00003BA8 File Offset: 0x00001DA8
		public void AddMixinInstance(object instance)
		{
			if (instance == null)
			{
				throw new ArgumentNullException("instance");
			}
			if (instance is Type)
			{
				throw new ArgumentException("You may not mix in types using this method.", "instance");
			}
			this.AddMixinImpl(instance);
		}

		// Token: 0x060000D4 RID: 212 RVA: 0x00003BD7 File Offset: 0x00001DD7
		private void AddMixinImpl(object instanceOrType)
		{
			if (this.mixins == null)
			{
				this.mixins = new List<object>();
			}
			this.mixins.Add(instanceOrType);
			this.mixinData = null;
		}

		// Token: 0x060000D5 RID: 213 RVA: 0x00003BFF File Offset: 0x00001DFF
		public object[] MixinsAsArray()
		{
			if (this.mixins == null)
			{
				return new object[0];
			}
			return this.mixins.ToArray();
		}

		// Token: 0x1700002E RID: 46
		// (get) Token: 0x060000D6 RID: 214 RVA: 0x00003C1B File Offset: 0x00001E1B
		public bool HasMixins
		{
			get
			{
				return this.mixins != null && this.mixins.Count != 0;
			}
		}

		// Token: 0x060000D7 RID: 215 RVA: 0x00003C38 File Offset: 0x00001E38
		public override bool Equals(object obj)
		{
			if (this == obj)
			{
				return true;
			}
			ProxyGenerationOptions proxyGenerationOptions = obj as ProxyGenerationOptions;
			if (proxyGenerationOptions == null)
			{
				return false;
			}
			this.Initialize();
			proxyGenerationOptions.Initialize();
			return object.Equals(this.Hook, proxyGenerationOptions.Hook) && object.Equals(this.Selector == null, proxyGenerationOptions.Selector == null) && object.Equals(this.MixinData, proxyGenerationOptions.MixinData) && object.Equals(this.BaseTypeForInterfaceProxy, proxyGenerationOptions.BaseTypeForInterfaceProxy) && Castle.Core.Internal.CollectionExtensions.AreEquivalent<CustomAttributeInfo>(this.AdditionalAttributes, proxyGenerationOptions.AdditionalAttributes);
		}

		// Token: 0x060000D8 RID: 216 RVA: 0x00003CE0 File Offset: 0x00001EE0
		public override int GetHashCode()
		{
			this.Initialize();
			int num = (this.Hook != null) ? this.Hook.GetType().GetHashCode() : 0;
			num = 29 * num + ((this.Selector != null) ? 1 : 0);
			num = 29 * num + this.MixinData.GetHashCode();
			num = 29 * num + ((this.BaseTypeForInterfaceProxy != null) ? this.BaseTypeForInterfaceProxy.GetHashCode() : 0);
			return 29 * num + Castle.Core.Internal.CollectionExtensions.GetContentsHashCode<CustomAttributeInfo>(this.AdditionalAttributes);
		}

		// Token: 0x0400002B RID: 43
		public static readonly ProxyGenerationOptions Default = new ProxyGenerationOptions();

		// Token: 0x0400002C RID: 44
		private List<object> mixins;

		// Token: 0x0400002D RID: 45
		private readonly IList<CustomAttributeInfo> additionalAttributes = new List<CustomAttributeInfo>();

		// Token: 0x0400002E RID: 46
		[NonSerialized]
		private MixinData mixinData;
	}
}
