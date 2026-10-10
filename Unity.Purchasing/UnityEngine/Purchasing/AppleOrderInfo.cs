using System;
using System.Runtime.CompilerServices;

namespace UnityEngine.Purchasing
{
	// Token: 0x02000047 RID: 71
	[NullableContext(2)]
	[Nullable(0)]
	internal class AppleOrderInfo : OrderInfo, IAppleOrderInfo
	{
		// Token: 0x17000015 RID: 21
		// (get) Token: 0x06000123 RID: 291 RVA: 0x0000377D File Offset: 0x0000197D
		public string AppReceipt
		{
			get
			{
				return this.m_ReceiptViewer.AppReceipt();
			}
		}

		// Token: 0x17000016 RID: 22
		// (get) Token: 0x06000124 RID: 292 RVA: 0x0000378A File Offset: 0x0000198A
		// (set) Token: 0x06000125 RID: 293 RVA: 0x00003792 File Offset: 0x00001992
		public string OriginalTransactionID { get; set; }

		// Token: 0x17000017 RID: 23
		// (get) Token: 0x06000126 RID: 294 RVA: 0x0000379B File Offset: 0x0000199B
		// (set) Token: 0x06000127 RID: 295 RVA: 0x000037A3 File Offset: 0x000019A3
		public OwnershipType OwnershipType { get; set; }

		// Token: 0x17000018 RID: 24
		// (get) Token: 0x06000128 RID: 296 RVA: 0x000037AC File Offset: 0x000019AC
		// (set) Token: 0x06000129 RID: 297 RVA: 0x000037B4 File Offset: 0x000019B4
		[Nullable(1)]
		public string StoreName { [NullableContext(1)] get; [NullableContext(1)] set; }

		// Token: 0x17000019 RID: 25
		// (get) Token: 0x0600012A RID: 298 RVA: 0x000037BD File Offset: 0x000019BD
		// (set) Token: 0x0600012B RID: 299 RVA: 0x000037C5 File Offset: 0x000019C5
		public Guid? AppAccountToken { get; set; }

		// Token: 0x1700001A RID: 26
		// (get) Token: 0x0600012C RID: 300 RVA: 0x000037CE File Offset: 0x000019CE
		// (set) Token: 0x0600012D RID: 301 RVA: 0x000037D6 File Offset: 0x000019D6
		public string jwsRepresentation { get; set; }

		// Token: 0x0600012E RID: 302 RVA: 0x000037E0 File Offset: 0x000019E0
		[NullableContext(1)]
		public AppleOrderInfo(string transactionID, string storeName, IAppleAppReceiptViewer appReceiptViewer, [Nullable(2)] string originalTransactionID, OwnershipType ownershipType, Guid? appAccountToken, [Nullable(2)] string signatureJws) : base(string.Empty, transactionID, storeName)
		{
			this.m_ReceiptViewer = appReceiptViewer;
			this.OriginalTransactionID = originalTransactionID;
			this.StoreName = (storeName ?? string.Empty);
			this.OwnershipType = ownershipType;
			this.AppAccountToken = appAccountToken;
			this.jwsRepresentation = signatureJws;
		}

		// Token: 0x04000033 RID: 51
		[Nullable(1)]
		private IAppleAppReceiptViewer m_ReceiptViewer;
	}
}
