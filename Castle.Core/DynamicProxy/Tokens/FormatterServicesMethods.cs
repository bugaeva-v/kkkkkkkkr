using System;
using System.Reflection;
using System.Runtime.Serialization;

namespace Castle.DynamicProxy.Tokens
{
	// Token: 0x0200001D RID: 29
	public static class FormatterServicesMethods
	{
		// Token: 0x04000036 RID: 54
		public static readonly MethodInfo GetObjectData = typeof(FormatterServices).GetMethod("GetObjectData", new Type[]
		{
			typeof(object),
			typeof(MemberInfo[])
		});

		// Token: 0x04000037 RID: 55
		public static readonly MethodInfo GetSerializableMembers = typeof(FormatterServices).GetMethod("GetSerializableMembers", new Type[]
		{
			typeof(Type)
		});
	}
}
