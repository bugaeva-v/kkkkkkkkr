using System;
using System.Collections.Generic;

namespace UnityEngine.Purchasing
{
	// Token: 0x020000C3 RID: 195
	internal class AppleExtensions : IAppleExtensions, IStoreExtension
	{
		// Token: 0x0600038E RID: 910 RVA: 0x00008905 File Offset: 0x00006B05
		public void RefreshAppReceipt(Action<string> successCallback, Action<string> errorCallback)
		{
			IAppleStoreExtendedPurchaseService apple = UnityIAPServices.DefaultPurchase().Apple;
			if (apple == null)
			{
				return;
			}
			apple.RefreshAppReceipt(successCallback, errorCallback);
		}

		// Token: 0x0600038F RID: 911 RVA: 0x0000891D File Offset: 0x00006B1D
		public void RestoreTransactions(Action<bool, string> callback)
		{
			IPurchaseService purchaseService = UnityIAPServices.DefaultPurchase();
			if (purchaseService == null)
			{
				return;
			}
			purchaseService.RestoreTransactions(callback);
		}

		// Token: 0x06000390 RID: 912 RVA: 0x00008930 File Offset: 0x00006B30
		public void RegisterPurchaseDeferredListener(Action<Product> callback)
		{
			UnityIAPServices.DefaultPurchase().OnPurchaseDeferred += delegate(DeferredOrder deferredOrder)
			{
				foreach (CartItem cartItem in deferredOrder.CartOrdered.Items())
				{
					callback(cartItem.Product);
				}
			};
		}

		// Token: 0x1700007A RID: 122
		// (get) Token: 0x06000391 RID: 913 RVA: 0x00008960 File Offset: 0x00006B60
		// (set) Token: 0x06000392 RID: 914 RVA: 0x00008971 File Offset: 0x00006B71
		public bool simulateAskToBuy
		{
			get
			{
				return UnityIAPServices.DefaultPurchase().Apple.simulateAskToBuy;
			}
			set
			{
				UnityIAPServices.DefaultPurchase().Apple.simulateAskToBuy = value;
			}
		}

		// Token: 0x06000393 RID: 915 RVA: 0x00008983 File Offset: 0x00006B83
		public string GetTransactionReceiptForProduct(Product _)
		{
			IAppleStoreExtendedPurchaseService apple = UnityIAPServices.DefaultPurchase().Apple;
			if (apple == null)
			{
				return null;
			}
			return apple.appReceipt;
		}

		// Token: 0x06000394 RID: 916 RVA: 0x0000899C File Offset: 0x00006B9C
		public void SetApplicationUsername(string applicationUsername)
		{
			try
			{
				Guid appAccountToken = new Guid(applicationUsername);
				IAppleStoreExtendedService apple = UnityIAPServices.DefaultStore().Apple;
				if (apple != null)
				{
					apple.SetAppAccountToken(appAccountToken);
				}
			}
			catch (FormatException)
			{
				Debug.LogError("SetApplicationUsername failed: '" + applicationUsername + "' is not a valid GUID.");
			}
		}

		// Token: 0x06000395 RID: 917 RVA: 0x000089F4 File Offset: 0x00006BF4
		public Dictionary<string, string> GetIntroductoryPriceDictionary()
		{
			IAppleStoreExtendedProductService apple = UnityIAPServices.DefaultProduct().Apple;
			if (apple == null)
			{
				return null;
			}
			return apple.GetIntroductoryPriceDictionary();
		}

		// Token: 0x06000396 RID: 918 RVA: 0x00008A0B File Offset: 0x00006C0B
		public Dictionary<string, string> GetProductDetails()
		{
			IAppleStoreExtendedProductService apple = UnityIAPServices.DefaultProduct().Apple;
			if (apple == null)
			{
				return null;
			}
			return apple.GetProductDetails();
		}

		// Token: 0x06000397 RID: 919 RVA: 0x00008A22 File Offset: 0x00006C22
		public void ContinuePromotionalPurchases()
		{
			IAppleStoreExtendedPurchaseService apple = UnityIAPServices.DefaultPurchase().Apple;
			if (apple == null)
			{
				return;
			}
			apple.ContinuePromotionalPurchases();
		}

		// Token: 0x06000398 RID: 920 RVA: 0x00008A38 File Offset: 0x00006C38
		public void SetStorePromotionVisibility(Product product, AppleStorePromotionVisibility visible)
		{
			IAppleStoreExtendedProductService apple = UnityIAPServices.DefaultProduct().Apple;
			if (apple == null)
			{
				return;
			}
			apple.SetStorePromotionVisibility(product, visible);
		}

		// Token: 0x06000399 RID: 921 RVA: 0x00008A50 File Offset: 0x00006C50
		public void FetchStorePromotionVisibility(Product product, Action<string, AppleStorePromotionVisibility> successCallback, Action errorCallback)
		{
			AppleExtensions.<>c__DisplayClass12_0 CS$<>8__locals1 = new AppleExtensions.<>c__DisplayClass12_0();
			CS$<>8__locals1.errorCallback = errorCallback;
			IAppleStoreExtendedProductService apple = UnityIAPServices.DefaultProduct().Apple;
			if (apple == null)
			{
				return;
			}
			apple.FetchStorePromotionVisibility(product, successCallback, new Action<string>(CS$<>8__locals1.<FetchStorePromotionVisibility>g__ErrorCallbackWrapper|0));
		}

		// Token: 0x0600039A RID: 922 RVA: 0x00008A8C File Offset: 0x00006C8C
		public void SetStorePromotionOrder(List<Product> products)
		{
			IAppleStoreExtendedProductService apple = UnityIAPServices.DefaultProduct().Apple;
			if (apple == null)
			{
				return;
			}
			apple.SetStorePromotionOrder(products);
		}

		// Token: 0x0600039B RID: 923 RVA: 0x00008AA4 File Offset: 0x00006CA4
		public void FetchStorePromotionOrder(Action<List<Product>> successCallback, Action errorCallback)
		{
			AppleExtensions.<>c__DisplayClass14_0 CS$<>8__locals1 = new AppleExtensions.<>c__DisplayClass14_0();
			CS$<>8__locals1.errorCallback = errorCallback;
			IAppleStoreExtendedProductService apple = UnityIAPServices.DefaultProduct().Apple;
			if (apple == null)
			{
				return;
			}
			apple.FetchStorePromotionOrder(successCallback, new Action<string>(CS$<>8__locals1.<FetchStorePromotionOrder>g__ErrorCallbackWrapper|0));
		}

		// Token: 0x0600039C RID: 924 RVA: 0x00008ADF File Offset: 0x00006CDF
		public void PresentCodeRedemptionSheet()
		{
			IAppleStoreExtendedPurchaseService apple = UnityIAPServices.DefaultPurchase().Apple;
			if (apple == null)
			{
				return;
			}
			apple.PresentCodeRedemptionSheet();
		}
	}
}
