using System;

namespace UnityEngine.Purchasing
{
	// Token: 0x020000CE RID: 206
	[Obsolete("This API is deprecated. Please upgrade to the new APIs introduced in IAP v5. For more information, visit the IAP manual: https://docs.unity.com/ugs/en-us/manual/iap/manual/upgrade-to-iap-v5", false)]
	public class PurchaseEventArgs
	{
		// Token: 0x060003D1 RID: 977 RVA: 0x00008FE0 File Offset: 0x000071E0
		internal PurchaseEventArgs(Product purchasedProduct)
		{
			this.purchasedProduct = purchasedProduct;
		}

		// Token: 0x1700007D RID: 125
		// (get) Token: 0x060003D2 RID: 978 RVA: 0x00008FEF File Offset: 0x000071EF
		// (set) Token: 0x060003D3 RID: 979 RVA: 0x00008FF7 File Offset: 0x000071F7
		public Product purchasedProduct { get; private set; }
	}
}
