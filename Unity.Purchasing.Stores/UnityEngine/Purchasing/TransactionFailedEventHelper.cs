using System;

namespace UnityEngine.Purchasing
{
	// Token: 0x0200000E RID: 14
	internal class TransactionFailedEventHelper
	{
		// Token: 0x06000023 RID: 35 RVA: 0x00002628 File Offset: 0x00000828
		internal static string BuildFailureReason(PurchaseFailureDescription failureDescription)
		{
			string text = "Failure reason: " + failureDescription.reason.ToString();
			if (!string.IsNullOrEmpty(failureDescription.message))
			{
				text = text + " Failure message: " + failureDescription.message;
			}
			return text;
		}
	}
}
