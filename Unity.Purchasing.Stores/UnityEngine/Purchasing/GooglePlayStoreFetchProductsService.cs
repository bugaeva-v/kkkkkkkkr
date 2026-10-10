using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine.Purchasing.Exceptions;
using UnityEngine.Purchasing.Extension;
using UnityEngine.Purchasing.Interfaces;
using UnityEngine.Scripting;

namespace UnityEngine.Purchasing
{
	// Token: 0x02000029 RID: 41
	[NullableContext(1)]
	[Nullable(0)]
	internal class GooglePlayStoreFetchProductsService : IGooglePlayStoreFetchProductsService
	{
		// Token: 0x060000D0 RID: 208 RVA: 0x00004698 File Offset: 0x00002898
		[Preserve]
		internal GooglePlayStoreFetchProductsService(IGooglePlayStoreService googlePlayStoreService)
		{
			this.m_GooglePlayStoreService = googlePlayStoreService;
		}

		// Token: 0x060000D1 RID: 209 RVA: 0x000046A7 File Offset: 0x000028A7
		public void FetchProducts(IReadOnlyCollection<ProductDefinition> products)
		{
			this.m_GooglePlayStoreService.FetchProducts(products, new Action<List<ProductDescription>>(this.OnProductsFetched), new Action<GoogleFetchProductException>(this.OnFetchProductsFailed));
		}

		// Token: 0x060000D2 RID: 210 RVA: 0x000046CD File Offset: 0x000028CD
		private void OnProductsFetched(List<ProductDescription> retrievedProducts)
		{
			IStoreProductsCallback productsCallback = this.m_ProductsCallback;
			if (productsCallback == null)
			{
				return;
			}
			productsCallback.OnProductsFetched(retrievedProducts);
		}

		// Token: 0x060000D3 RID: 211 RVA: 0x000046E0 File Offset: 0x000028E0
		private void OnFetchProductsFailed(GoogleFetchProductException exception)
		{
			IStoreProductsCallback productsCallback = this.m_ProductsCallback;
			if (productsCallback == null)
			{
				return;
			}
			productsCallback.OnProductsFetchFailed(exception.FailureDescription);
		}

		// Token: 0x060000D4 RID: 212 RVA: 0x000046F8 File Offset: 0x000028F8
		[Obsolete]
		private static List<ProductDescription> MakePurchasesIntoProducts(List<ProductDescription> retrievedProducts, IEnumerable<Product> purchaseProducts)
		{
			List<ProductDescription> list = new List<ProductDescription>(retrievedProducts);
			if (purchaseProducts != null)
			{
				using (IEnumerator<Product> enumerator = purchaseProducts.GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						Product purchaseProduct = enumerator.Current;
						int num = list.FindLastIndex((ProductDescription product) => product.storeSpecificId == purchaseProduct.definition.storeSpecificId);
						if (num != -1)
						{
							ProductDescription productDescription = list[num];
							list[num] = new ProductDescription(productDescription.storeSpecificId, productDescription.metadata, purchaseProduct.receipt, purchaseProduct.transactionID, productDescription.type);
						}
					}
				}
			}
			return list;
		}

		// Token: 0x060000D5 RID: 213 RVA: 0x000047AC File Offset: 0x000029AC
		public void SetProductsCallback(IStoreProductsCallback productsCallback)
		{
			this.m_ProductsCallback = productsCallback;
		}

		// Token: 0x0400005F RID: 95
		private readonly IGooglePlayStoreService m_GooglePlayStoreService;

		// Token: 0x04000060 RID: 96
		[Nullable(2)]
		private IStoreProductsCallback m_ProductsCallback;
	}
}
