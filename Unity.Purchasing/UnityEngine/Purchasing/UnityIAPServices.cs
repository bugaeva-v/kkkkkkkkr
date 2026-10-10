using System;
using System.Runtime.CompilerServices;

namespace UnityEngine.Purchasing
{
	// Token: 0x020000A6 RID: 166
	[NullableContext(1)]
	[Nullable(0)]
	public static class UnityIAPServices
	{
		// Token: 0x060002EC RID: 748 RVA: 0x00007179 File Offset: 0x00005379
		public static IStoreService DefaultStore()
		{
			return StoreServiceProvider.GetDefaultStoreService();
		}

		// Token: 0x060002ED RID: 749 RVA: 0x00007180 File Offset: 0x00005380
		public static IStoreService Store(string storeName)
		{
			return StoreServiceProvider.GetStoreService(storeName);
		}

		// Token: 0x060002EE RID: 750 RVA: 0x00007188 File Offset: 0x00005388
		public static IPurchaseService DefaultPurchase()
		{
			return PurchaseServiceProvider.GetDefaultPurchaseService();
		}

		// Token: 0x060002EF RID: 751 RVA: 0x0000718F File Offset: 0x0000538F
		public static IPurchaseService Purchase(string storeName)
		{
			return PurchaseServiceProvider.GetPurchaseService(storeName);
		}

		// Token: 0x060002F0 RID: 752 RVA: 0x00007197 File Offset: 0x00005397
		public static IProductService DefaultProduct()
		{
			return ProductServiceProvider.GetDefaultProductService();
		}

		// Token: 0x060002F1 RID: 753 RVA: 0x0000719E File Offset: 0x0000539E
		public static IProductService Product(string storeName)
		{
			return ProductServiceProvider.GetProductService(storeName);
		}

		// Token: 0x060002F2 RID: 754 RVA: 0x000071A6 File Offset: 0x000053A6
		public static StoreController StoreController([Nullable(2)] string storeName = null)
		{
			return new StoreController(storeName);
		}

		// Token: 0x060002F3 RID: 755 RVA: 0x000071AE File Offset: 0x000053AE
		public static void SetStoreAsDefault(string storeName)
		{
			DefaultStoreHelper.OverrideDefaultStoreName(storeName);
		}

		// Token: 0x060002F4 RID: 756 RVA: 0x000071B6 File Offset: 0x000053B6
		public static void AddNewCustomStore(IStoreWrapper customStoreWrapper)
		{
			StoreManager.Instance().AddNewCustomStore(customStoreWrapper);
		}

		// Token: 0x060002F5 RID: 757 RVA: 0x000071C3 File Offset: 0x000053C3
		public static void AddNewStoreService(string storeName, Func<IStoreService> createStoreService)
		{
			StoreServiceFactoryManager.Instance().GetServiceFactory().RegisterNewService(storeName, createStoreService);
		}

		// Token: 0x060002F6 RID: 758 RVA: 0x000071D6 File Offset: 0x000053D6
		public static void AddNewExtendedStoreService(string storeName, Func<IStoreService, ExtensibleStoreService> createStoreService)
		{
			StoreServiceFactoryManager.Instance().GetServiceFactory().RegisterNewExtendedService(storeName, createStoreService);
		}

		// Token: 0x060002F7 RID: 759 RVA: 0x000071E9 File Offset: 0x000053E9
		public static void AddNewProductService(string storeName, Func<IProductService> createProductService)
		{
			ProductServiceFactoryManager.Instance().GetServiceFactory().RegisterNewService(storeName, createProductService);
		}

		// Token: 0x060002F8 RID: 760 RVA: 0x000071FC File Offset: 0x000053FC
		public static void AddNewExtendedProductService(string storeName, Func<IProductService, ExtensibleProductService> createProductService)
		{
			ProductServiceFactoryManager.Instance().GetServiceFactory().RegisterNewExtendedService(storeName, createProductService);
		}

		// Token: 0x060002F9 RID: 761 RVA: 0x0000720F File Offset: 0x0000540F
		public static void AddNewPurchaseService(string storeName, Func<IPurchaseService> createPurchaseService)
		{
			PurchaseServiceFactoryManager.Instance().GetServiceFactory().RegisterNewService(storeName, createPurchaseService);
		}

		// Token: 0x060002FA RID: 762 RVA: 0x00007222 File Offset: 0x00005422
		public static void AddNewExtendedPurchaseService(string storeName, Func<IPurchaseService, ExtensiblePurchaseService> createPurchaseService)
		{
			PurchaseServiceFactoryManager.Instance().GetServiceFactory().RegisterNewExtendedService(storeName, createPurchaseService);
		}
	}
}
