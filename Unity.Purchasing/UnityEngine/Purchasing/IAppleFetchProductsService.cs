using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using UnityEngine.Purchasing.Extension;

namespace UnityEngine.Purchasing
{
	// Token: 0x020000F3 RID: 243
	[NullableContext(1)]
	internal interface IAppleFetchProductsService
	{
		// Token: 0x06000489 RID: 1161
		void SetNativeStore(INativeAppleStore nativeStore);

		// Token: 0x0600048A RID: 1162
		Task<List<ProductDescription>> FetchProducts(IReadOnlyCollection<ProductDefinition> products);

		// Token: 0x0600048B RID: 1163
		void OnProductsFetched(string json);

		// Token: 0x0600048C RID: 1164
		void OnProductDetailsRetrieveFailed(string errorMessage);

		// Token: 0x170000AE RID: 174
		// (get) Token: 0x0600048D RID: 1165
		[Nullable(2)]
		string LastRequestProductsJson { [NullableContext(2)] get; }
	}
}
