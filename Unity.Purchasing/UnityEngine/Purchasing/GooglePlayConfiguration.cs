using System;
using System.Linq;
using UnityEngine.Purchasing.Extension;

namespace UnityEngine.Purchasing
{
	// Token: 0x020000BF RID: 191
	internal class GooglePlayConfiguration : IGooglePlayConfiguration, IStoreConfiguration
	{
		// Token: 0x06000374 RID: 884 RVA: 0x00008710 File Offset: 0x00006910
		public void SetServiceDisconnectAtInitializeListener(Action action)
		{
			UnityIAPServices.Store("GooglePlay").OnStoreDisconnected += delegate(StoreConnectionFailureDescription _)
			{
				Action action2 = action;
				if (action2 == null)
				{
					return;
				}
				action2();
			};
		}

		// Token: 0x06000375 RID: 885 RVA: 0x00008748 File Offset: 0x00006948
		public void SetQueryProductDetailsFailedListener(Action<int> action)
		{
			UnityIAPServices.Product("GooglePlay").OnProductsFetchFailed += delegate(ProductFetchFailed _)
			{
				action(0);
			};
		}

		// Token: 0x06000376 RID: 886 RVA: 0x00008780 File Offset: 0x00006980
		public void SetDeferredPurchaseListener(Action<Product> action)
		{
			UnityIAPServices.Purchase("GooglePlay").OnPurchaseDeferred += delegate(DeferredOrder order)
			{
				Action<Product> action2 = action;
				CartItem cartItem = order.CartOrdered.Items().FirstOrDefault<CartItem>();
				action2((cartItem != null) ? cartItem.Product : null);
			};
		}

		// Token: 0x06000377 RID: 887 RVA: 0x000087B8 File Offset: 0x000069B8
		public void SetDeferredProrationUpgradeDowngradeSubscriptionListener(Action<Product> action)
		{
			IGooglePlayStoreExtendedPurchaseService google = UnityIAPServices.Purchase("GooglePlay").Google;
			if (google != null)
			{
				google.OnDeferredPaymentUntilRenewalDate += delegate(DeferredPaymentUntilRenewalDateOrder order)
				{
					action(order.SubscriptionOrdered);
				};
			}
		}

		// Token: 0x06000378 RID: 888 RVA: 0x000087F7 File Offset: 0x000069F7
		public void SetObfuscatedAccountId(string accountId)
		{
			IGooglePlayStoreExtendedService google = UnityIAPServices.Store("GooglePlay").Google;
			if (google == null)
			{
				return;
			}
			google.SetObfuscatedAccountId(accountId);
		}

		// Token: 0x06000379 RID: 889 RVA: 0x00008813 File Offset: 0x00006A13
		public void SetObfuscatedProfileId(string profileId)
		{
			IGooglePlayStoreExtendedService google = UnityIAPServices.Store("GooglePlay").Google;
			if (google == null)
			{
				return;
			}
			google.SetObfuscatedProfileId(profileId);
		}

		// Token: 0x0600037A RID: 890 RVA: 0x0000882F File Offset: 0x00006A2F
		public void SetFetchPurchasesAtInitialize(bool enable)
		{
			UnityPurchasing.shouldFetchProductsAtInit = enable;
		}

		// Token: 0x0600037B RID: 891 RVA: 0x00008837 File Offset: 0x00006A37
		[Obsolete("This API is deprecated. Please upgrade to the new APIs introduced in IAP v5. For more information, visit the IAP manual: https://docs.unity.com/ugs/en-us/manual/iap/manual/upgrade-to-iap-v5", false)]
		public void SetFetchPurchasesExcludeDeferred(bool exclude)
		{
		}
	}
}
