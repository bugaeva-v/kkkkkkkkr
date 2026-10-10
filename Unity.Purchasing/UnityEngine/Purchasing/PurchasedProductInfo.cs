using System;
using System.Runtime.CompilerServices;

namespace UnityEngine.Purchasing
{
	// Token: 0x0200005C RID: 92
	[NullableContext(1)]
	[Nullable(0)]
	internal class PurchasedProductInfo : IPurchasedProductInfo
	{
		// Token: 0x06000183 RID: 387 RVA: 0x00003DCC File Offset: 0x00001FCC
		public PurchasedProductInfo(string productId, string receipt, ProductType productType)
		{
			this.productId = productId;
			if (productType == ProductType.Subscription)
			{
				SubscriptionInfoHelper subscriptionInfoHelper = new SubscriptionInfoHelper(receipt, productId, null);
				this.TryInitSubscriptionInfo(subscriptionInfoHelper);
			}
		}

		// Token: 0x06000184 RID: 388 RVA: 0x00003DFC File Offset: 0x00001FFC
		private void TryInitSubscriptionInfo(SubscriptionInfoHelper subscriptionInfoHelper)
		{
			try
			{
				this.subscriptionInfo = subscriptionInfoHelper.GetSubscriptionInfo();
			}
			catch (Exception)
			{
			}
		}

		// Token: 0x17000044 RID: 68
		// (get) Token: 0x06000185 RID: 389 RVA: 0x00003E2C File Offset: 0x0000202C
		public string productId { get; }

		// Token: 0x17000045 RID: 69
		// (get) Token: 0x06000186 RID: 390 RVA: 0x00003E34 File Offset: 0x00002034
		// (set) Token: 0x06000187 RID: 391 RVA: 0x00003E3C File Offset: 0x0000203C
		[Nullable(2)]
		public SubscriptionInfo subscriptionInfo { [NullableContext(2)] get; [NullableContext(2)] private set; }
	}
}
