using System;
using Unity.Services.Analytics;

namespace UnityEngine.Purchasing
{
	// Token: 0x0200000F RID: 15
	internal static class UnifiedReceiptAnalyticsExtensions
	{
		// Token: 0x06000025 RID: 37 RVA: 0x0000267C File Offset: 0x0000087C
		public static AnalyticsTransactionReceipt ToReceiptAndSignature(this UnifiedReceipt receipt)
		{
			AnalyticsTransactionReceipt analyticsTransactionReceipt = new AnalyticsTransactionReceipt
			{
				transactionServer = receipt.ToTransactionServer()
			};
			TransactionServer? transactionServer = analyticsTransactionReceipt.transactionServer;
			TransactionServer transactionServer2 = TransactionServer.GOOGLE;
			if (transactionServer.GetValueOrDefault() == transactionServer2 & transactionServer != null)
			{
				GoogleReceipt googleReceipt = JsonUtility.FromJson<GoogleReceipt>(receipt.Payload);
				analyticsTransactionReceipt.transactionReceipt = ((googleReceipt != null) ? googleReceipt.json : null);
				analyticsTransactionReceipt.transactionReceiptSignature = ((googleReceipt != null) ? googleReceipt.signature : null);
			}
			else
			{
				analyticsTransactionReceipt.transactionReceipt = receipt.Payload;
			}
			return analyticsTransactionReceipt;
		}

		// Token: 0x06000026 RID: 38 RVA: 0x000026F8 File Offset: 0x000008F8
		private static TransactionServer? ToTransactionServer(this UnifiedReceipt receipt)
		{
			if (receipt.Store == null)
			{
				return null;
			}
			string text = receipt.Store.ToLower();
			if (text.Contains("mac") || text.Contains("apple"))
			{
				return new TransactionServer?(TransactionServer.APPLE);
			}
			if (text.Contains("google"))
			{
				return new TransactionServer?(TransactionServer.GOOGLE);
			}
			return null;
		}
	}
}
