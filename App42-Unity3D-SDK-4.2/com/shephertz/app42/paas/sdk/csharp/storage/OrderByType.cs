using System;

namespace com.shephertz.app42.paas.sdk.csharp.storage
{
	// Token: 0x020000B8 RID: 184
	public sealed class OrderByType
	{
		// Token: 0x060007CF RID: 1999 RVA: 0x0002C5CE File Offset: 0x0002A7CE
		public static bool isValidType(string type)
		{
			return OrderByType.ASCENDING.Equals(type) || OrderByType.DESCENDING.Equals(type);
		}

		// Token: 0x040002DD RID: 733
		public static readonly string ASCENDING = "ASCENDING";

		// Token: 0x040002DE RID: 734
		public static readonly string DESCENDING = "DESCENDING";
	}
}
