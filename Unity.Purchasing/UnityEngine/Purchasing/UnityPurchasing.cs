using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace UnityEngine.Purchasing
{
	// Token: 0x020000D3 RID: 211
	[Obsolete("This API is deprecated. Please upgrade to the new APIs introduced in IAP v5. For more information, visit the IAP manual: https://docs.unity.com/ugs/en-us/manual/iap/manual/upgrade-to-iap-v5", false)]
	public class UnityPurchasing
	{
		// Token: 0x060003F7 RID: 1015 RVA: 0x0000991F File Offset: 0x00007B1F
		public static void Initialize(IStoreListener storeListener, ConfigurationBuilder configurationBuilder)
		{
			UnityPurchasing.m_StoreListener = storeListener;
			UnityPurchasing.m_ConfigurationBuilder = configurationBuilder;
			UnityPurchasing.ConnectToStoreAndFetchProducts();
		}

		// Token: 0x060003F8 RID: 1016 RVA: 0x00009934 File Offset: 0x00007B34
		private static void FetchProducts(IStoreListener storeListener, ConfigurationBuilder configurationBuilder)
		{
			IProductService defaultProductService = ProductServiceProvider.GetDefaultProductService();
			UnityPurchasing.AddProductServiceListeners(storeListener, defaultProductService);
			defaultProductService.FetchProducts(configurationBuilder.m_CatalogProvider.GetProducts(null), new MaximumNumberOfAttemptsRetryPolicy(5));
		}

		// Token: 0x060003F9 RID: 1017 RVA: 0x00009968 File Offset: 0x00007B68
		private static void AddProductServiceListeners(IStoreListener storeListener, IProductService productService)
		{
			productService.OnProductsFetched += delegate(List<Product> _)
			{
				if (!UnityPurchasing.isInitialized)
				{
					PurchaseServiceProvider.GetDefaultPurchaseService().FetchPurchases();
					storeListener.OnInitialized(UnityPurchasing.m_PurchasingManager, new ExtensionProvider());
					UnityPurchasing.isInitialized = true;
				}
			};
			productService.OnProductsFetchFailed += delegate(ProductFetchFailed failed)
			{
				if (!UnityPurchasing.isInitialized && failed.FailureReason == "Retrieve Products failed, and could not retrieve any products.")
				{
					storeListener.OnInitializeFailed(InitializationFailureReason.PurchasingUnavailable, failed.FailureReason);
				}
			};
		}

		// Token: 0x060003FA RID: 1018 RVA: 0x000099A8 File Offset: 0x00007BA8
		private static void ConnectToStoreAndFetchProducts()
		{
			UnityPurchasing.<ConnectToStoreAndFetchProducts>d__8 <ConnectToStoreAndFetchProducts>d__;
			<ConnectToStoreAndFetchProducts>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<ConnectToStoreAndFetchProducts>d__.<>1__state = -1;
			<ConnectToStoreAndFetchProducts>d__.<>t__builder.Start<UnityPurchasing.<ConnectToStoreAndFetchProducts>d__8>(ref <ConnectToStoreAndFetchProducts>d__);
		}

		// Token: 0x04000185 RID: 389
		internal static ConfigurationBuilder m_ConfigurationBuilder;

		// Token: 0x04000186 RID: 390
		internal static IStoreListener m_StoreListener;

		// Token: 0x04000187 RID: 391
		internal static bool shouldFetchProductsAtInit = true;

		// Token: 0x04000188 RID: 392
		private static bool isInitialized = false;

		// Token: 0x04000189 RID: 393
		internal static PurchasingManager m_PurchasingManager = new PurchasingManager();
	}
}
