using System;
using System.Runtime.CompilerServices;

namespace UnityEngine.Purchasing
{
	// Token: 0x0200009A RID: 154
	[NullableContext(1)]
	[Nullable(0)]
	[Serializable]
	public class StoreConnectionFailureDescription : IRetryableRequestFailureDescription
	{
		// Token: 0x17000057 RID: 87
		// (get) Token: 0x0600028B RID: 651 RVA: 0x00006872 File Offset: 0x00004A72
		public string Message
		{
			get
			{
				return this.message;
			}
		}

		// Token: 0x17000058 RID: 88
		// (get) Token: 0x0600028C RID: 652 RVA: 0x0000687A File Offset: 0x00004A7A
		public bool IsRetryable
		{
			get
			{
				return this.isRetryable;
			}
		}

		// Token: 0x0600028D RID: 653 RVA: 0x00006882 File Offset: 0x00004A82
		public StoreConnectionFailureDescription(string message, bool isRetryable = false)
		{
			this.message = message;
			this.isRetryable = isRetryable;
		}

		// Token: 0x040000CB RID: 203
		public string message;

		// Token: 0x040000CC RID: 204
		public bool isRetryable;
	}
}
