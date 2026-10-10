using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace UnityEngine.Purchasing.Extension
{
	// Token: 0x0200012A RID: 298
	[NullableContext(1)]
	public interface ICatalogProvider : IBaseCatalogProvider
	{
		// Token: 0x06000542 RID: 1346
		List<ProductDefinition> GetProducts([Nullable(2)] string storeName = null);

		// Token: 0x06000543 RID: 1347
		void AddProduct(string id, ProductType type);

		// Token: 0x06000544 RID: 1348
		void AddProduct(string id, ProductType type, [Nullable(2)] StoreSpecificIds storeIDs);

		// Token: 0x06000545 RID: 1349
		void AddProduct(string id, ProductType type, [Nullable(2)] StoreSpecificIds storeIDs, PayoutDefinition payout);

		// Token: 0x06000546 RID: 1350
		void AddProduct(string id, ProductType type, [Nullable(2)] StoreSpecificIds storeIDs, IEnumerable<PayoutDefinition> payouts);

		// Token: 0x06000547 RID: 1351
		void AddProducts(IEnumerable<ProductDefinition> products, [Nullable(new byte[]
		{
			2,
			1,
			1
		})] Dictionary<string, StoreSpecificIds> storeIDsByProductId = null);

		// Token: 0x06000548 RID: 1352
		void FetchProducts(Action<List<ProductDefinition>> callback, string storeName);
	}
}
