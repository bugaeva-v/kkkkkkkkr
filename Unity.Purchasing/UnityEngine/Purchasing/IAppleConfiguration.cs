using System;
using System.Collections.Generic;
using UnityEngine.Purchasing.Extension;

namespace UnityEngine.Purchasing
{
	// Token: 0x020000C0 RID: 192
	[Obsolete("This API is deprecated. Please upgrade to the new APIs introduced in IAP v5. For more information, visit the IAP manual: https://docs.unity.com/ugs/en-us/manual/iap/manual/upgrade-to-iap-v5", false)]
	public interface IAppleConfiguration : IStoreConfiguration
	{
		// Token: 0x17000077 RID: 119
		// (get) Token: 0x0600037D RID: 893
		string appReceipt { get; }

		// Token: 0x17000078 RID: 120
		// (get) Token: 0x0600037E RID: 894
		bool canMakePayments { get; }

		// Token: 0x0600037F RID: 895
		void SetApplePromotionalPurchaseInterceptorCallback(Action<Product> callback);

		// Token: 0x06000380 RID: 896
		void SetEntitlementsRevokedListener(Action<List<Product>> callback);
	}
}
