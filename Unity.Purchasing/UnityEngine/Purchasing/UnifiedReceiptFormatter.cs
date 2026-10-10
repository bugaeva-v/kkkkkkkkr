using System;

namespace UnityEngine.Purchasing
{
	// Token: 0x02000107 RID: 263
	internal static class UnifiedReceiptFormatter
	{
		// Token: 0x060004E1 RID: 1249 RVA: 0x0000B501 File Offset: 0x00009701
		internal static string FormatUnifiedReceipt(string platformReceipt, string transactionId, string storeName)
		{
			return JsonUtility.ToJson(new UnifiedReceipt
			{
				Store = storeName,
				TransactionID = transactionId,
				Payload = platformReceipt
			});
		}
	}
}
