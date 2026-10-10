using System;
using Unity.Services.Analytics;

namespace UnityEngine.Purchasing
{
	// Token: 0x0200000A RID: 10
	internal class AnalyticsTransactionReceipt
	{
		// Token: 0x17000001 RID: 1
		// (get) Token: 0x06000016 RID: 22 RVA: 0x000024DD File Offset: 0x000006DD
		// (set) Token: 0x06000017 RID: 23 RVA: 0x000024E5 File Offset: 0x000006E5
		public string transactionReceipt { get; set; }

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x06000018 RID: 24 RVA: 0x000024EE File Offset: 0x000006EE
		// (set) Token: 0x06000019 RID: 25 RVA: 0x000024F6 File Offset: 0x000006F6
		public string transactionReceiptSignature { get; set; }

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x0600001A RID: 26 RVA: 0x000024FF File Offset: 0x000006FF
		// (set) Token: 0x0600001B RID: 27 RVA: 0x00002507 File Offset: 0x00000707
		public TransactionServer? transactionServer { get; set; }
	}
}
