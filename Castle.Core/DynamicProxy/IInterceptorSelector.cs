using System;
using System.Reflection;

namespace Castle.DynamicProxy
{
	// Token: 0x0200000B RID: 11
	public interface IInterceptorSelector
	{
		// Token: 0x0600004C RID: 76
		IInterceptor[] SelectInterceptors(Type type, MethodInfo method, IInterceptor[] interceptors);
	}
}
