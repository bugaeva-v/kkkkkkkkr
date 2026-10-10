using System;
using System.Reflection;
using System.Runtime.Serialization;

namespace Castle.DynamicProxy.Tokens
{
	// Token: 0x02000021 RID: 33
	public static class SerializationInfoMethods
	{
		// Token: 0x0400004A RID: 74
		public static readonly MethodInfo AddValue_Bool = typeof(SerializationInfo).GetMethod("AddValue", new Type[]
		{
			typeof(string),
			typeof(bool)
		});

		// Token: 0x0400004B RID: 75
		public static readonly MethodInfo AddValue_Int32 = typeof(SerializationInfo).GetMethod("AddValue", new Type[]
		{
			typeof(string),
			typeof(int)
		});

		// Token: 0x0400004C RID: 76
		public static readonly MethodInfo AddValue_Object = typeof(SerializationInfo).GetMethod("AddValue", new Type[]
		{
			typeof(string),
			typeof(object)
		});

		// Token: 0x0400004D RID: 77
		public static readonly MethodInfo GetValue = typeof(SerializationInfo).GetMethod("GetValue", new Type[]
		{
			typeof(string),
			typeof(Type)
		});

		// Token: 0x0400004E RID: 78
		public static readonly MethodInfo SetType = typeof(SerializationInfo).GetMethod("SetType");
	}
}
