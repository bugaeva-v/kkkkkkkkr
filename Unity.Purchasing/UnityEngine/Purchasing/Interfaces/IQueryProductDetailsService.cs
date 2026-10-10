using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using UnityEngine.Purchasing.Extension;

namespace UnityEngine.Purchasing.Interfaces
{
	// Token: 0x02000127 RID: 295
	[NullableContext(1)]
	internal interface IQueryProductDetailsService
	{
		// Token: 0x0600053C RID: 1340
		Task<List<AndroidJavaObject>> QueryProductDetails(ProductDefinition product);

		// Token: 0x0600053D RID: 1341
		Task<List<ProductDescription>> QueryProductDescriptions(IReadOnlyCollection<ProductDefinition> products);

		// Token: 0x0600053E RID: 1342
		Task<List<AndroidJavaObject>> QueryProductDetails(IReadOnlyCollection<ProductDefinition> products);
	}
}
