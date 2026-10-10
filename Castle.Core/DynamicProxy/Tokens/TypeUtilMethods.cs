using System;
using System.Reflection;
using Castle.DynamicProxy.Internal;

namespace Castle.DynamicProxy.Tokens
{
	// Token: 0x02000023 RID: 35
	public static class TypeUtilMethods
	{
		// Token: 0x04000051 RID: 81
		public static readonly MethodInfo Sort = typeof(TypeUtil).GetMethod("Sort", BindingFlags.Static | BindingFlags.Public);

		// Token: 0x04000052 RID: 82
		public static readonly MethodInfo GetTypeOrNull = typeof(TypeUtil).GetMethod("GetTypeOrNull", BindingFlags.Static | BindingFlags.Public);
	}
}
