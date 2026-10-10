using System;
using System.Reflection;

namespace Castle.DynamicProxy.Tokens
{
	// Token: 0x02000020 RID: 32
	public static class MethodBaseMethods
	{
		// Token: 0x04000049 RID: 73
		public static readonly MethodInfo GetMethodFromHandle = typeof(MethodBase).GetMethod("GetMethodFromHandle", new Type[]
		{
			typeof(RuntimeMethodHandle),
			typeof(RuntimeTypeHandle)
		});
	}
}
