using System;
using System.Collections.Generic;
using UnityEngine.Purchasing.Extension;

namespace UnityEngine.Purchasing
{
	// Token: 0x0200002F RID: 47
	internal interface IGooglePlayStoreFetchProductsService
	{
		// Token: 0x060000F5 RID: 245
		void FetchProducts(IReadOnlyCollection<ProductDefinition> products);

		// Token: 0x060000F6 RID: 246
		void SetProductsCallback(IStoreProductsCallback productsCallback);
	}
}
