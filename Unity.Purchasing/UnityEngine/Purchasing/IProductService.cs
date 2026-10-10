using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.CompilerServices;

namespace UnityEngine.Purchasing
{
	// Token: 0x0200000F RID: 15
	[NullableContext(1)]
	public interface IProductService
	{
		// Token: 0x17000002 RID: 2
		// (get) Token: 0x0600003B RID: 59
		[Nullable(2)]
		IAppleStoreExtendedProductService Apple { [NullableContext(2)] get; }

		// Token: 0x0600003C RID: 60
		void FetchProductsWithNoRetries(List<ProductDefinition> productDefinitions);

		// Token: 0x0600003D RID: 61
		void FetchProducts(List<ProductDefinition> productDefinitions, [Nullable(2)] IRetryPolicy retryPolicy = null);

		// Token: 0x0600003E RID: 62
		ReadOnlyObservableCollection<Product> GetProducts();

		// Token: 0x0600003F RID: 63
		[return: Nullable(2)]
		Product GetProductById(string productId);

		// Token: 0x14000003 RID: 3
		// (add) Token: 0x06000040 RID: 64
		// (remove) Token: 0x06000041 RID: 65
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		event Action<List<Product>> OnProductsFetched;

		// Token: 0x14000004 RID: 4
		// (add) Token: 0x06000042 RID: 66
		// (remove) Token: 0x06000043 RID: 67
		[Nullable(new byte[]
		{
			2,
			1
		})]
		event Action<ProductFetchFailed> OnProductsFetchFailed;
	}
}
