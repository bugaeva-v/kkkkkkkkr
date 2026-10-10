using System;
using System.Reflection;

namespace Castle.DynamicProxy.Tokens
{
	// Token: 0x0200001E RID: 30
	public static class InterceptorSelectorMethods
	{
		// Token: 0x04000038 RID: 56
		public static readonly MethodInfo SelectInterceptors = typeof(IInterceptorSelector).GetMethod("SelectInterceptors", BindingFlags.Instance | BindingFlags.Public);
	}
}
