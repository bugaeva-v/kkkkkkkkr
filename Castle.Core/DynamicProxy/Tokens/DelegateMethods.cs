using System;
using System.Reflection;

namespace Castle.DynamicProxy.Tokens
{
	// Token: 0x0200001C RID: 28
	public static class DelegateMethods
	{
		// Token: 0x04000035 RID: 53
		public static readonly MethodInfo CreateDelegate = typeof(Delegate).GetMethod("CreateDelegate", new Type[]
		{
			typeof(Type),
			typeof(object),
			typeof(MethodInfo)
		});
	}
}
