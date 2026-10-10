using System;
using System.Collections.Generic;

namespace UnityEngine.Purchasing
{
	// Token: 0x02000018 RID: 24
	internal interface IGoogleCachedQueryProductDetailsService
	{
		// Token: 0x0600006E RID: 110
		IEnumerable<AndroidJavaObject> GetCachedQueriedProducts();

		// Token: 0x0600006F RID: 111
		IEnumerable<AndroidJavaObject> GetCachedQueriedProductDetails(IEnumerable<ProductDefinition> products);

		// Token: 0x06000070 RID: 112
		bool Contains(ProductDefinition products);

		// Token: 0x06000071 RID: 113
		void AddCachedQueriedProductDetails(IEnumerable<AndroidJavaObject> queriedProducts);
	}
}
