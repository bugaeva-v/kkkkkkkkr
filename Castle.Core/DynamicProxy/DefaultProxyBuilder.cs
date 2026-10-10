using System;
using System.Collections.Generic;
using System.Reflection;
using Castle.Core.Internal;
using Castle.Core.Logging;
using Castle.DynamicProxy.Generators;

namespace Castle.DynamicProxy
{
	// Token: 0x02000007 RID: 7
	public class DefaultProxyBuilder : IProxyBuilder
	{
		// Token: 0x06000039 RID: 57 RVA: 0x00002B71 File Offset: 0x00000D71
		public DefaultProxyBuilder() : this(new ModuleScope())
		{
		}

		// Token: 0x0600003A RID: 58 RVA: 0x00002B7E File Offset: 0x00000D7E
		public DefaultProxyBuilder(ModuleScope scope)
		{
			this.scope = scope;
		}

		// Token: 0x1700000E RID: 14
		// (get) Token: 0x0600003B RID: 59 RVA: 0x00002B98 File Offset: 0x00000D98
		// (set) Token: 0x0600003C RID: 60 RVA: 0x00002BA0 File Offset: 0x00000DA0
		public ILogger Logger
		{
			get
			{
				return this.logger;
			}
			set
			{
				this.logger = value;
			}
		}

		// Token: 0x1700000F RID: 15
		// (get) Token: 0x0600003D RID: 61 RVA: 0x00002BA9 File Offset: 0x00000DA9
		public ModuleScope ModuleScope
		{
			get
			{
				return this.scope;
			}
		}

		// Token: 0x0600003E RID: 62 RVA: 0x00002BB1 File Offset: 0x00000DB1
		public Type CreateClassProxyType(Type classToProxy, Type[] additionalInterfacesToProxy, ProxyGenerationOptions options)
		{
			this.AssertValidType(classToProxy);
			this.AssertValidTypes(additionalInterfacesToProxy);
			return new ClassProxyGenerator(this.scope, classToProxy)
			{
				Logger = this.logger
			}.GenerateCode(additionalInterfacesToProxy, options);
		}

		// Token: 0x0600003F RID: 63 RVA: 0x00002BE0 File Offset: 0x00000DE0
		public Type CreateClassProxyTypeWithTarget(Type classToProxy, Type[] additionalInterfacesToProxy, ProxyGenerationOptions options)
		{
			this.AssertValidType(classToProxy);
			this.AssertValidTypes(additionalInterfacesToProxy);
			return new ClassProxyWithTargetGenerator(this.scope, classToProxy, additionalInterfacesToProxy, options)
			{
				Logger = this.logger
			}.GetGeneratedType();
		}

		// Token: 0x06000040 RID: 64 RVA: 0x00002C0F File Offset: 0x00000E0F
		public Type CreateInterfaceProxyTypeWithTarget(Type interfaceToProxy, Type[] additionalInterfacesToProxy, Type targetType, ProxyGenerationOptions options)
		{
			this.AssertValidType(interfaceToProxy);
			this.AssertValidTypes(additionalInterfacesToProxy);
			return new InterfaceProxyWithTargetGenerator(this.scope, interfaceToProxy)
			{
				Logger = this.logger
			}.GenerateCode(targetType, additionalInterfacesToProxy, options);
		}

		// Token: 0x06000041 RID: 65 RVA: 0x00002C40 File Offset: 0x00000E40
		public Type CreateInterfaceProxyTypeWithTargetInterface(Type interfaceToProxy, Type[] additionalInterfacesToProxy, ProxyGenerationOptions options)
		{
			this.AssertValidType(interfaceToProxy);
			this.AssertValidTypes(additionalInterfacesToProxy);
			return new InterfaceProxyWithTargetInterfaceGenerator(this.scope, interfaceToProxy)
			{
				Logger = this.logger
			}.GenerateCode(interfaceToProxy, additionalInterfacesToProxy, options);
		}

		// Token: 0x06000042 RID: 66 RVA: 0x00002C70 File Offset: 0x00000E70
		public Type CreateInterfaceProxyTypeWithoutTarget(Type interfaceToProxy, Type[] additionalInterfacesToProxy, ProxyGenerationOptions options)
		{
			this.AssertValidType(interfaceToProxy);
			this.AssertValidTypes(additionalInterfacesToProxy);
			return new InterfaceProxyWithoutTargetGenerator(this.scope, interfaceToProxy)
			{
				Logger = this.logger
			}.GenerateCode(typeof(object), additionalInterfacesToProxy, options);
		}

		// Token: 0x06000043 RID: 67 RVA: 0x00002CA9 File Offset: 0x00000EA9
		private void AssertValidType(Type target)
		{
			this.AssertValidTypeForTarget(target, target);
		}

		// Token: 0x06000044 RID: 68 RVA: 0x00002CB4 File Offset: 0x00000EB4
		private void AssertValidTypeForTarget(Type type, Type target)
		{
			if (type.GetTypeInfo().IsGenericTypeDefinition)
			{
				throw new GeneratorException(string.Format("Can not create proxy for type {0} because type {1} is an open generic type.", target.GetBestName(), type.GetBestName()));
			}
			if (!ProxyUtil.IsAccessibleType(type))
			{
				throw new GeneratorException(ExceptionMessageBuilder.CreateMessageForInaccessibleType(type, target));
			}
			foreach (Type type2 in type.GetGenericArguments())
			{
				this.AssertValidTypeForTarget(type2, target);
			}
		}

		// Token: 0x06000045 RID: 69 RVA: 0x00002D20 File Offset: 0x00000F20
		private void AssertValidTypes(IEnumerable<Type> targetTypes)
		{
			if (targetTypes != null)
			{
				foreach (Type target in targetTypes)
				{
					this.AssertValidType(target);
				}
			}
		}

		// Token: 0x04000016 RID: 22
		private readonly ModuleScope scope;

		// Token: 0x04000017 RID: 23
		private ILogger logger = NullLogger.Instance;
	}
}
