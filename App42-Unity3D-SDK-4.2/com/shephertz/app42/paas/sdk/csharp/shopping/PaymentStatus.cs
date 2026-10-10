using System;

namespace com.shephertz.app42.paas.sdk.csharp.shopping
{
	// Token: 0x02000033 RID: 51
	public sealed class PaymentStatus
	{
		// Token: 0x06000202 RID: 514 RVA: 0x0000AE3A File Offset: 0x0000903A
		private PaymentStatus(string value)
		{
			this.value = value;
		}

		// Token: 0x06000203 RID: 515 RVA: 0x0000AE49 File Offset: 0x00009049
		public string GetValue()
		{
			return this.value;
		}

		// Token: 0x040000B0 RID: 176
		public static readonly string DECLINED = "DECLINED";

		// Token: 0x040000B1 RID: 177
		public static readonly string AUTHORIZED = "AUTHORIZED";

		// Token: 0x040000B2 RID: 178
		public static readonly string PENDING = "PENDING";

		// Token: 0x040000B3 RID: 179
		private string value;
	}
}
