using System;

namespace UnityEngine.Purchasing
{
	// Token: 0x020000CF RID: 207
	[Obsolete("This API is deprecated. Please upgrade to the new APIs introduced in IAP v5. For more information, visit the IAP manual: https://docs.unity.com/ugs/en-us/manual/iap/manual/upgrade-to-iap-v5", false)]
	public class PurchaseFailedEventArgs
	{
		// Token: 0x060003D4 RID: 980 RVA: 0x00009000 File Offset: 0x00007200
		internal PurchaseFailedEventArgs(Product purchasedProduct, PurchaseFailureReason reason, string message)
		{
			this.purchasedProduct = purchasedProduct;
			this.reason = reason;
			this.message = message;
		}

		// Token: 0x1700007E RID: 126
		// (get) Token: 0x060003D5 RID: 981 RVA: 0x0000901D File Offset: 0x0000721D
		// (set) Token: 0x060003D6 RID: 982 RVA: 0x00009025 File Offset: 0x00007225
		public Product purchasedProduct { get; private set; }

		// Token: 0x1700007F RID: 127
		// (get) Token: 0x060003D7 RID: 983 RVA: 0x0000902E File Offset: 0x0000722E
		// (set) Token: 0x060003D8 RID: 984 RVA: 0x00009036 File Offset: 0x00007236
		public PurchaseFailureReason reason { get; private set; }

		// Token: 0x17000080 RID: 128
		// (get) Token: 0x060003D9 RID: 985 RVA: 0x0000903F File Offset: 0x0000723F
		// (set) Token: 0x060003DA RID: 986 RVA: 0x00009047 File Offset: 0x00007247
		public string message { get; private set; }
	}
}
