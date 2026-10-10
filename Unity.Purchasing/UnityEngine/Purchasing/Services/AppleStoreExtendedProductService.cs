using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine.Purchasing.UseCases.Interfaces;
using UnityEngine.Scripting;

namespace UnityEngine.Purchasing.Services
{
	// Token: 0x02000151 RID: 337
	[NullableContext(1)]
	[Nullable(0)]
	internal class AppleStoreExtendedProductService : ProductService, IAppleStoreExtendedProductService, IProductServiceExtension
	{
		// Token: 0x060005BA RID: 1466 RVA: 0x0000C28C File Offset: 0x0000A48C
		[Preserve]
		internal AppleStoreExtendedProductService(IFetchStorePromotionOrderUseCase fetchStorePromotionOrderUseCase, IFetchStorePromotionVisibilityUseCase fetchStorePromotionVisibilityUseCase, IGetIntroductoryPriceDictionaryUseCase getIntroductoryPriceDictionaryUseCase, IGetProductDetailsUseCase getProductDetailsUseCase, ISetStorePromotionOrderUseCase setStorePromotionOrderUseCase, ISetStorePromotionVisibilityUseCase setStorePromotionVisibilityUseCase, IFetchProductsUseCase fetchProductsUseCase, IStoreWrapper storeWrapper) : base(fetchProductsUseCase, storeWrapper)
		{
			this.m_FetchStorePromotionOrderUseCase = fetchStorePromotionOrderUseCase;
			this.m_FetchStorePromotionVisibilityUseCase = fetchStorePromotionVisibilityUseCase;
			this.m_GetIntroductoryPriceDictionaryUseCase = getIntroductoryPriceDictionaryUseCase;
			this.m_GetProductDetailsUseCase = getProductDetailsUseCase;
			this.m_SetStorePromotionOrderUseCase = setStorePromotionOrderUseCase;
			this.m_SetStorePromotionVisibilityUseCase = setStorePromotionVisibilityUseCase;
		}

		// Token: 0x060005BB RID: 1467 RVA: 0x0000C2C5 File Offset: 0x0000A4C5
		public void FetchStorePromotionOrder(Action<List<Product>> successCallback, Action<string> errorCallback)
		{
			this.m_FetchStorePromotionOrderUseCase.FetchStorePromotionOrder(successCallback, errorCallback);
		}

		// Token: 0x060005BC RID: 1468 RVA: 0x0000C2D4 File Offset: 0x0000A4D4
		public void FetchStorePromotionVisibility(Product product, Action<string, AppleStorePromotionVisibility> successCallback, Action<string> errorCallback)
		{
			this.m_FetchStorePromotionVisibilityUseCase.FetchStorePromotionVisibility(product, successCallback, errorCallback);
		}

		// Token: 0x060005BD RID: 1469 RVA: 0x0000C2E4 File Offset: 0x0000A4E4
		public Dictionary<string, string> GetIntroductoryPriceDictionary()
		{
			return this.m_GetIntroductoryPriceDictionaryUseCase.GetIntroductoryPriceDictionary();
		}

		// Token: 0x060005BE RID: 1470 RVA: 0x0000C2F1 File Offset: 0x0000A4F1
		public Dictionary<string, string> GetProductDetails()
		{
			return this.m_GetProductDetailsUseCase.GetProductDetails();
		}

		// Token: 0x060005BF RID: 1471 RVA: 0x0000C2FE File Offset: 0x0000A4FE
		public void SetStorePromotionOrder(List<Product> products)
		{
			this.m_SetStorePromotionOrderUseCase.SetStorePromotionOrder(products);
		}

		// Token: 0x060005C0 RID: 1472 RVA: 0x0000C30C File Offset: 0x0000A50C
		public void SetStorePromotionVisibility(Product product, AppleStorePromotionVisibility visible)
		{
			this.m_SetStorePromotionVisibilityUseCase.SetStorePromotionVisibility(product, visible);
		}

		// Token: 0x0400029A RID: 666
		private readonly IFetchStorePromotionOrderUseCase m_FetchStorePromotionOrderUseCase;

		// Token: 0x0400029B RID: 667
		private readonly IFetchStorePromotionVisibilityUseCase m_FetchStorePromotionVisibilityUseCase;

		// Token: 0x0400029C RID: 668
		private readonly IGetIntroductoryPriceDictionaryUseCase m_GetIntroductoryPriceDictionaryUseCase;

		// Token: 0x0400029D RID: 669
		private readonly IGetProductDetailsUseCase m_GetProductDetailsUseCase;

		// Token: 0x0400029E RID: 670
		private readonly ISetStorePromotionOrderUseCase m_SetStorePromotionOrderUseCase;

		// Token: 0x0400029F RID: 671
		private readonly ISetStorePromotionVisibilityUseCase m_SetStorePromotionVisibilityUseCase;
	}
}
