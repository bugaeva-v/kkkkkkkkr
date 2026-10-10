using System;
using System.Runtime.CompilerServices;

namespace UnityEngine.Purchasing
{
	// Token: 0x02000015 RID: 21
	[NullableContext(1)]
	[Nullable(0)]
	[Serializable]
	public class ProductFetchFailureDescription : IRetryableRequestFailureDescription
	{
		// Token: 0x17000005 RID: 5
		// (get) Token: 0x0600004C RID: 76 RVA: 0x00002583 File Offset: 0x00000783
		public ProductFetchFailureReason Reason
		{
			get
			{
				return this.reason;
			}
		}

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x0600004D RID: 77 RVA: 0x0000258B File Offset: 0x0000078B
		public string Message
		{
			get
			{
				return this.message;
			}
		}

		// Token: 0x17000007 RID: 7
		// (get) Token: 0x0600004E RID: 78 RVA: 0x00002593 File Offset: 0x00000793
		public bool IsRetryable
		{
			get
			{
				return this.isRetryable;
			}
		}

		// Token: 0x0600004F RID: 79 RVA: 0x0000259B File Offset: 0x0000079B
		public ProductFetchFailureDescription(ProductFetchFailureReason reason, string message, bool isRetryable = false)
		{
			this.reason = reason;
			this.message = message;
			this.isRetryable = isRetryable;
		}

		// Token: 0x0400000A RID: 10
		public ProductFetchFailureReason reason;

		// Token: 0x0400000B RID: 11
		public string message;

		// Token: 0x0400000C RID: 12
		public bool isRetryable;
	}
}
