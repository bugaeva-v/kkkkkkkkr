using System;
using System.Collections.Generic;

namespace UnityEngine.Purchasing
{
	// Token: 0x02000006 RID: 6
	public static class CodelessCatalogProvider
	{
		// Token: 0x06000005 RID: 5 RVA: 0x00002090 File Offset: 0x00000290
		public static CatalogProvider PopulateCatalogProvider(ProductCatalog catalog)
		{
			CatalogProvider catalogProvider = new CatalogProvider();
			foreach (ProductCatalogItem productCatalogItem in catalog.allProducts)
			{
				if (productCatalogItem != null)
				{
					StoreSpecificIds storeSpecificIds = new StoreSpecificIds();
					foreach (StoreID storeID in ((productCatalogItem != null) ? productCatalogItem.allStoreIDs : null))
					{
						storeSpecificIds.Add(storeID.id, new string[]
						{
							storeID.store
						});
					}
					List<PayoutDefinition> list = new List<PayoutDefinition>();
					foreach (ProductCatalogPayout productCatalogPayout in productCatalogItem.Payouts)
					{
						list.Add(new PayoutDefinition(productCatalogPayout.typeString, productCatalogPayout.subtype, productCatalogPayout.quantity, productCatalogPayout.data));
					}
					catalogProvider.AddProduct(productCatalogItem.id, productCatalogItem.type, storeSpecificIds, list);
				}
			}
			return catalogProvider;
		}
	}
}
