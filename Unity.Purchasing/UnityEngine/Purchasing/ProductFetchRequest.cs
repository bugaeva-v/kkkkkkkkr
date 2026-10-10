using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.CompilerServices;

namespace UnityEngine.Purchasing
{
	// Token: 0x02000017 RID: 23
	[NullableContext(1)]
	[Nullable(0)]
	internal class ProductFetchRequest
	{
		// Token: 0x17000008 RID: 8
		// (get) Token: 0x06000050 RID: 80 RVA: 0x000025B8 File Offset: 0x000007B8
		internal ReadOnlyCollection<ProductDefinition> RequestedProducts { get; }

		// Token: 0x17000009 RID: 9
		// (get) Token: 0x06000051 RID: 81 RVA: 0x000025C0 File Offset: 0x000007C0
		internal Action<List<Product>> SuccessAction { get; }

		// Token: 0x1700000A RID: 10
		// (get) Token: 0x06000052 RID: 82 RVA: 0x000025C8 File Offset: 0x000007C8
		internal Action<List<ProductDefinition>, string> FailureAction { get; }

		// Token: 0x06000053 RID: 83 RVA: 0x000025D0 File Offset: 0x000007D0
		internal ProductFetchRequest(ReadOnlyCollection<ProductDefinition> products, Action<List<Product>> fetchSuccessAction, Action<List<ProductDefinition>, string> fetchFailureAction)
		{
			this.RequestedProducts = products;
			this.SuccessAction = fetchSuccessAction;
			this.FailureAction = fetchFailureAction;
		}
	}
}
