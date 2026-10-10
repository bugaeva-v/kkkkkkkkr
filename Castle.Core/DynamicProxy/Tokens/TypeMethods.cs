using System;
using System.Reflection;

namespace Castle.DynamicProxy.Tokens
{
	// Token: 0x02000022 RID: 34
	public static class TypeMethods
	{
		// Token: 0x0400004F RID: 79
		public static readonly MethodInfo GetTypeFromHandle = typeof(Type).GetMethod("GetTypeFromHandle");

		// Token: 0x04000050 RID: 80
		public static readonly MethodInfo StaticGetType = typeof(Type).GetMethod("GetType", new Type[]
		{
			typeof(string),
			typeof(bool),
			typeof(bool)
		});
	}
}
