using System;

namespace com.shephertz.app42.paas.sdk.csharp.storage
{
	// Token: 0x02000086 RID: 134
	public sealed class Operator
	{
		// Token: 0x06000586 RID: 1414 RVA: 0x0001F257 File Offset: 0x0001D457
		private Operator(string value)
		{
			this.value = value;
		}

		// Token: 0x06000587 RID: 1415 RVA: 0x0001F266 File Offset: 0x0001D466
		public string GetValue()
		{
			return this.value;
		}

		// Token: 0x0400024A RID: 586
		public static readonly string EQUALS = "$eq";

		// Token: 0x0400024B RID: 587
		public static readonly string NOT_EQUALS = "$ne";

		// Token: 0x0400024C RID: 588
		public static readonly string GREATER_THAN = "$gt";

		// Token: 0x0400024D RID: 589
		public static readonly string LESS_THAN = "$lt";

		// Token: 0x0400024E RID: 590
		public static readonly string GREATER_THAN_EQUALTO = "$gte";

		// Token: 0x0400024F RID: 591
		public static readonly string LESS_THAN_EQUALTO = "$lte";

		// Token: 0x04000250 RID: 592
		public static readonly string LIKE = "$lk";

		// Token: 0x04000251 RID: 593
		public static readonly string AND = "$and";

		// Token: 0x04000252 RID: 594
		public static readonly string OR = "$or";

		// Token: 0x04000253 RID: 595
		public static readonly string INLIST = "$in";

		// Token: 0x04000254 RID: 596
		private string value;
	}
}
