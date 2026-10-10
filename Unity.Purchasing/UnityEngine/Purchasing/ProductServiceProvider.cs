using System;
using System.Runtime.CompilerServices;

namespace UnityEngine.Purchasing
{
	// Token: 0x0200001C RID: 28
	[NullableContext(1)]
	[Nullable(0)]
	internal static class ProductServiceProvider
	{
		// Token: 0x0600006C RID: 108 RVA: 0x0000291C File Offset: 0x00000B1C
		public static IProductService GetDefaultProductService()
		{
			return ProductServiceProvider.GetProductServiceInternal(StoreManager.Instance().GetDefaultStore());
		}

		// Token: 0x0600006D RID: 109 RVA: 0x0000292D File Offset: 0x00000B2D
		public static IProductService GetProductService(string storeName)
		{
			return ProductServiceProvider.GetProductServiceInternal(StoreManager.Instance().GetStore(storeName));
		}

		// Token: 0x0600006E RID: 110 RVA: 0x0000293F File Offset: 0x00000B3F
		private static IProductService GetProductServiceInternal(IStoreWrapper storeWrapper)
		{
			return ProductServiceProvider.LocateExistingService(storeWrapper) ?? ProductServiceProvider.CreateNewService(storeWrapper);
		}

		// Token: 0x0600006F RID: 111 RVA: 0x00002951 File Offset: 0x00000B51
		[return: Nullable(2)]
		private static IProductService LocateExistingService(IStoreWrapper wrapper)
		{
			return ProductServiceContainer.Instance().FindService(wrapper.name ?? string.Empty);
		}

		// Token: 0x06000070 RID: 112 RVA: 0x0000296C File Offset: 0x00000B6C
		private static IProductService CreateNewService(IStoreWrapper wrapper)
		{
			IProductService productService = new ProductServiceDependencyInjector(wrapper).CreateProductService();
			try
			{
				ProductServiceContainer.Instance().SetService(wrapper.name ?? string.Empty, productService);
			}
			catch (ServiceCreationException exception)
			{
				Debug.unityLogger.LogIAPException(exception);
			}
			return productService;
		}
	}
}
