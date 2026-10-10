using System;
using Castle.Core.Logging;

namespace Castle.DynamicProxy
{
	// Token: 0x02000012 RID: 18
	[CLSCompliant(true)]
	public interface IProxyGenerator
	{
		// Token: 0x1700001C RID: 28
		// (get) Token: 0x06000070 RID: 112
		// (set) Token: 0x06000071 RID: 113
		ILogger Logger { get; set; }

		// Token: 0x1700001D RID: 29
		// (get) Token: 0x06000072 RID: 114
		IProxyBuilder ProxyBuilder { get; }

		// Token: 0x06000073 RID: 115
		TInterface CreateInterfaceProxyWithTarget<TInterface>(TInterface target, params IInterceptor[] interceptors) where TInterface : class;

		// Token: 0x06000074 RID: 116
		TInterface CreateInterfaceProxyWithTarget<TInterface>(TInterface target, ProxyGenerationOptions options, params IInterceptor[] interceptors) where TInterface : class;

		// Token: 0x06000075 RID: 117
		object CreateInterfaceProxyWithTarget(Type interfaceToProxy, object target, params IInterceptor[] interceptors);

		// Token: 0x06000076 RID: 118
		object CreateInterfaceProxyWithTarget(Type interfaceToProxy, object target, ProxyGenerationOptions options, params IInterceptor[] interceptors);

		// Token: 0x06000077 RID: 119
		object CreateInterfaceProxyWithTarget(Type interfaceToProxy, Type[] additionalInterfacesToProxy, object target, params IInterceptor[] interceptors);

		// Token: 0x06000078 RID: 120
		object CreateInterfaceProxyWithTarget(Type interfaceToProxy, Type[] additionalInterfacesToProxy, object target, ProxyGenerationOptions options, params IInterceptor[] interceptors);

		// Token: 0x06000079 RID: 121
		object CreateInterfaceProxyWithTargetInterface(Type interfaceToProxy, object target, params IInterceptor[] interceptors);

		// Token: 0x0600007A RID: 122
		TInterface CreateInterfaceProxyWithTargetInterface<TInterface>(TInterface target, params IInterceptor[] interceptors) where TInterface : class;

		// Token: 0x0600007B RID: 123
		TInterface CreateInterfaceProxyWithTargetInterface<TInterface>(TInterface target, ProxyGenerationOptions options, params IInterceptor[] interceptors) where TInterface : class;

		// Token: 0x0600007C RID: 124
		object CreateInterfaceProxyWithTargetInterface(Type interfaceToProxy, Type[] additionalInterfacesToProxy, object target, params IInterceptor[] interceptors);

		// Token: 0x0600007D RID: 125
		object CreateInterfaceProxyWithTargetInterface(Type interfaceToProxy, object target, ProxyGenerationOptions options, params IInterceptor[] interceptors);

		// Token: 0x0600007E RID: 126
		object CreateInterfaceProxyWithTargetInterface(Type interfaceToProxy, Type[] additionalInterfacesToProxy, object target, ProxyGenerationOptions options, params IInterceptor[] interceptors);

		// Token: 0x0600007F RID: 127
		TInterface CreateInterfaceProxyWithoutTarget<TInterface>(IInterceptor interceptor) where TInterface : class;

		// Token: 0x06000080 RID: 128
		TInterface CreateInterfaceProxyWithoutTarget<TInterface>(params IInterceptor[] interceptors) where TInterface : class;

		// Token: 0x06000081 RID: 129
		TInterface CreateInterfaceProxyWithoutTarget<TInterface>(ProxyGenerationOptions options, params IInterceptor[] interceptors) where TInterface : class;

		// Token: 0x06000082 RID: 130
		object CreateInterfaceProxyWithoutTarget(Type interfaceToProxy, IInterceptor interceptor);

		// Token: 0x06000083 RID: 131
		object CreateInterfaceProxyWithoutTarget(Type interfaceToProxy, params IInterceptor[] interceptors);

		// Token: 0x06000084 RID: 132
		object CreateInterfaceProxyWithoutTarget(Type interfaceToProxy, Type[] additionalInterfacesToProxy, params IInterceptor[] interceptors);

		// Token: 0x06000085 RID: 133
		object CreateInterfaceProxyWithoutTarget(Type interfaceToProxy, ProxyGenerationOptions options, params IInterceptor[] interceptors);

		// Token: 0x06000086 RID: 134
		object CreateInterfaceProxyWithoutTarget(Type interfaceToProxy, Type[] additionalInterfacesToProxy, ProxyGenerationOptions options, params IInterceptor[] interceptors);

		// Token: 0x06000087 RID: 135
		TClass CreateClassProxyWithTarget<TClass>(TClass target, params IInterceptor[] interceptors) where TClass : class;

		// Token: 0x06000088 RID: 136
		TClass CreateClassProxyWithTarget<TClass>(TClass target, ProxyGenerationOptions options, params IInterceptor[] interceptors) where TClass : class;

		// Token: 0x06000089 RID: 137
		object CreateClassProxyWithTarget(Type classToProxy, Type[] additionalInterfacesToProxy, object target, params IInterceptor[] interceptors);

		// Token: 0x0600008A RID: 138
		object CreateClassProxyWithTarget(Type classToProxy, object target, ProxyGenerationOptions options, object[] constructorArguments, params IInterceptor[] interceptors);

		// Token: 0x0600008B RID: 139
		object CreateClassProxyWithTarget(Type classToProxy, object target, object[] constructorArguments, params IInterceptor[] interceptors);

		// Token: 0x0600008C RID: 140
		object CreateClassProxyWithTarget(Type classToProxy, object target, params IInterceptor[] interceptors);

		// Token: 0x0600008D RID: 141
		object CreateClassProxyWithTarget(Type classToProxy, object target, ProxyGenerationOptions options, params IInterceptor[] interceptors);

		// Token: 0x0600008E RID: 142
		object CreateClassProxyWithTarget(Type classToProxy, Type[] additionalInterfacesToProxy, object target, ProxyGenerationOptions options, params IInterceptor[] interceptors);

		// Token: 0x0600008F RID: 143
		object CreateClassProxyWithTarget(Type classToProxy, Type[] additionalInterfacesToProxy, object target, ProxyGenerationOptions options, object[] constructorArguments, params IInterceptor[] interceptors);

		// Token: 0x06000090 RID: 144
		TClass CreateClassProxy<TClass>(params IInterceptor[] interceptors) where TClass : class;

		// Token: 0x06000091 RID: 145
		TClass CreateClassProxy<TClass>(ProxyGenerationOptions options, params IInterceptor[] interceptors) where TClass : class;

		// Token: 0x06000092 RID: 146
		object CreateClassProxy(Type classToProxy, Type[] additionalInterfacesToProxy, params IInterceptor[] interceptors);

		// Token: 0x06000093 RID: 147
		object CreateClassProxy(Type classToProxy, ProxyGenerationOptions options, object[] constructorArguments, params IInterceptor[] interceptors);

		// Token: 0x06000094 RID: 148
		object CreateClassProxy(Type classToProxy, object[] constructorArguments, params IInterceptor[] interceptors);

		// Token: 0x06000095 RID: 149
		object CreateClassProxy(Type classToProxy, params IInterceptor[] interceptors);

		// Token: 0x06000096 RID: 150
		object CreateClassProxy(Type classToProxy, ProxyGenerationOptions options, params IInterceptor[] interceptors);

		// Token: 0x06000097 RID: 151
		object CreateClassProxy(Type classToProxy, Type[] additionalInterfacesToProxy, ProxyGenerationOptions options, params IInterceptor[] interceptors);

		// Token: 0x06000098 RID: 152
		object CreateClassProxy(Type classToProxy, Type[] additionalInterfacesToProxy, ProxyGenerationOptions options, object[] constructorArguments, params IInterceptor[] interceptors);
	}
}
