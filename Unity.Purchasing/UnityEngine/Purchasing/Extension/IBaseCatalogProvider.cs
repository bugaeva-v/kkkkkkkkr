using System;
using System.Collections.Generic;

namespace UnityEngine.Purchasing.Extension
{
	// Token: 0x02000129 RID: 297
	public interface IBaseCatalogProvider
	{
		// Token: 0x06000541 RID: 1345
		void FetchProducts(Action<List<ProductDefinition>> callback);
	}
}
