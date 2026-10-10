using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace UnityEngine.Purchasing
{
	// Token: 0x0200001E RID: 30
	[NullableContext(1)]
	internal interface IFetchProductsUseCase
	{
		// Token: 0x0600007C RID: 124
		void FetchProducts([Nullable(new byte[]
		{
			2,
			1
		})] List<ProductDefinition> productDefinitions, [Nullable(new byte[]
		{
			1,
			2,
			1
		})] Action<List<Product>> fetchSuccessAction, [Nullable(new byte[]
		{
			1,
			2,
			1,
			1
		})] Action<List<ProductDefinition>, string> fetchFailureAction, IRetryPolicy retryPolicy);
	}
}
