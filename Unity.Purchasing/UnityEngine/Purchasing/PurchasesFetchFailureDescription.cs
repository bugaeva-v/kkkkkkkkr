using System;
using System.Runtime.CompilerServices;

namespace UnityEngine.Purchasing
{
	// Token: 0x0200005D RID: 93
	[NullableContext(1)]
	[Nullable(0)]
	[Serializable]
	public class PurchasesFetchFailureDescription
	{
		// Token: 0x17000046 RID: 70
		// (get) Token: 0x06000188 RID: 392 RVA: 0x00003E45 File Offset: 0x00002045
		public PurchasesFetchFailureReason FailureReason
		{
			get
			{
				return this.failureReason;
			}
		}

		// Token: 0x17000047 RID: 71
		// (get) Token: 0x06000189 RID: 393 RVA: 0x00003E4D File Offset: 0x0000204D
		public string Message
		{
			get
			{
				return this.message;
			}
		}

		// Token: 0x0600018A RID: 394 RVA: 0x00003E55 File Offset: 0x00002055
		public PurchasesFetchFailureDescription(PurchasesFetchFailureReason reason, string message)
		{
			this.failureReason = reason;
			this.message = message;
		}

		// Token: 0x0400005F RID: 95
		public PurchasesFetchFailureReason failureReason;

		// Token: 0x04000060 RID: 96
		public string message;
	}
}
