using System;
using UnityEngine;

namespace Unity.Services.Analytics
{
	// Token: 0x02000014 RID: 20
	public class TransactionFailedEvent : TransactionEvent
	{
		// Token: 0x06000085 RID: 133 RVA: 0x00003AED File Offset: 0x00001CED
		public TransactionFailedEvent() : base("transactionFailed")
		{
		}

		// Token: 0x1700003A RID: 58
		// (set) Token: 0x06000086 RID: 134 RVA: 0x00003AFA File Offset: 0x00001CFA
		public string FailureReason
		{
			set
			{
				base.SetParameter("failureReason", value);
			}
		}

		// Token: 0x06000087 RID: 135 RVA: 0x00003B08 File Offset: 0x00001D08
		public override void Validate()
		{
			base.Validate();
			if (!base.ParameterHasBeenSet("failureReason"))
			{
				Debug.LogWarning("A value for the FailureReason parameter is required for a TransactionFailed event.");
			}
		}
	}
}
