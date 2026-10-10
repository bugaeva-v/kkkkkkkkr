using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace UnityEngine.Purchasing
{
	// Token: 0x02000014 RID: 20
	[NullableContext(1)]
	[Nullable(0)]
	public class ProductFetchFailed
	{
		// Token: 0x17000003 RID: 3
		// (get) Token: 0x06000049 RID: 73 RVA: 0x0000255D File Offset: 0x0000075D
		public List<ProductDefinition> FailedFetchProducts { get; }

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x0600004A RID: 74 RVA: 0x00002565 File Offset: 0x00000765
		public string FailureReason { get; }

		// Token: 0x0600004B RID: 75 RVA: 0x0000256D File Offset: 0x0000076D
		internal ProductFetchFailed(List<ProductDefinition> products, string reason)
		{
			this.FailedFetchProducts = products;
			this.FailureReason = reason;
		}
	}
}
