using System;
using Castle.Core.Logging;

namespace Castle.DynamicProxy
{
	// Token: 0x02000010 RID: 16
	public interface IProxyBuilder
	{
		// Token: 0x1700001A RID: 26
		// (get) Token: 0x06000065 RID: 101
		// (set) Token: 0x06000066 RID: 102
		ILogger Logger { get; set; }

		// Token: 0x1700001B RID: 27
		// (get) Token: 0x06000067 RID: 103
		ModuleScope ModuleScope { get; }

		// Token: 0x06000068 RID: 104
		Type CreateClassProxyType(Type classToProxy, Type[] additionalInterfacesToProxy, ProxyGenerationOptions options);

		// Token: 0x06000069 RID: 105
		Type CreateClassProxyTypeWithTarget(Type classToProxy, Type[] additionalInterfacesToProxy, ProxyGenerationOptions options);

		// Token: 0x0600006A RID: 106
		Type CreateInterfaceProxyTypeWithTarget(Type interfaceToProxy, Type[] additionalInterfacesToProxy, Type targetType, ProxyGenerationOptions options);

		// Token: 0x0600006B RID: 107
		Type CreateInterfaceProxyTypeWithTargetInterface(Type interfaceToProxy, Type[] additionalInterfacesToProxy, ProxyGenerationOptions options);

		// Token: 0x0600006C RID: 108
		Type CreateInterfaceProxyTypeWithoutTarget(Type interfaceToProxy, Type[] additionalInterfacesToProxy, ProxyGenerationOptions options);
	}
}
