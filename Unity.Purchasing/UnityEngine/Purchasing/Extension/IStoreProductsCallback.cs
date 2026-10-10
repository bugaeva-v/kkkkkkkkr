using System;
using System.Collections.Generic;

namespace UnityEngine.Purchasing.Extension
{
	// Token: 0x02000128 RID: 296
	public interface IStoreProductsCallback
	{
		// Token: 0x0600053F RID: 1343
		void OnProductsFetched(IReadOnlyList<ProductDescription> products);

		// Token: 0x06000540 RID: 1344
		void OnProductsFetchFailed(ProductFetchFailureDescription failureDescription);
	}
}
