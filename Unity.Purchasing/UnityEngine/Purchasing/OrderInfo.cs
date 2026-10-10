using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace UnityEngine.Purchasing
{
	// Token: 0x02000058 RID: 88
	[NullableContext(1)]
	[Nullable(0)]
	internal class OrderInfo : IOrderInfo
	{
		// Token: 0x1700003C RID: 60
		// (get) Token: 0x06000172 RID: 370 RVA: 0x00003C08 File Offset: 0x00001E08
		[Nullable(2)]
		public IAppleOrderInfo Apple
		{
			[NullableContext(2)]
			get
			{
				return this as IAppleOrderInfo;
			}
		}

		// Token: 0x1700003D RID: 61
		// (get) Token: 0x06000173 RID: 371 RVA: 0x00003C10 File Offset: 0x00001E10
		[Nullable(2)]
		public IGoogleOrderInfo Google
		{
			[NullableContext(2)]
			get
			{
				return this as IGoogleOrderInfo;
			}
		}

		// Token: 0x1700003E RID: 62
		// (get) Token: 0x06000174 RID: 372 RVA: 0x00003C18 File Offset: 0x00001E18
		// (set) Token: 0x06000175 RID: 373 RVA: 0x00003C20 File Offset: 0x00001E20
		public List<IPurchasedProductInfo> PurchasedProductInfo { get; set; }

		// Token: 0x1700003F RID: 63
		// (get) Token: 0x06000176 RID: 374 RVA: 0x00003C29 File Offset: 0x00001E29
		public string TransactionID { get; }

		// Token: 0x17000040 RID: 64
		// (get) Token: 0x06000177 RID: 375 RVA: 0x00003C31 File Offset: 0x00001E31
		// (set) Token: 0x06000178 RID: 376 RVA: 0x00003C39 File Offset: 0x00001E39
		public string Receipt
		{
			get
			{
				return this.GetReceipt();
			}
			private set
			{
				this.SetReceipt(value);
			}
		}

		// Token: 0x06000179 RID: 377 RVA: 0x00003C42 File Offset: 0x00001E42
		private string GetReceipt()
		{
			if (this.Apple != null)
			{
				return OrderInfo.CreateUnifiedReceipt(this.Apple.AppReceipt ?? "", this.TransactionID, this.Apple.StoreName);
			}
			return this.m_Receipt;
		}

		// Token: 0x0600017A RID: 378 RVA: 0x00003C7D File Offset: 0x00001E7D
		private void SetReceipt(string receipt)
		{
			if (this.Apple == null)
			{
				this.m_Receipt = receipt;
			}
		}

		// Token: 0x0600017B RID: 379 RVA: 0x00003C90 File Offset: 0x00001E90
		public OrderInfo(string receipt, [Nullable(2)] string transactionID, string storeName)
		{
			this.Receipt = OrderInfo.CreateUnifiedReceipt(receipt, transactionID ?? "", storeName);
			this.TransactionID = (transactionID ?? "");
			this.PurchasedProductInfo = new List<IPurchasedProductInfo>();
		}

		// Token: 0x0600017C RID: 380 RVA: 0x00003CE0 File Offset: 0x00001EE0
		private static string CreateUnifiedReceipt(string rawReceipt, string transactionId, string storeName)
		{
			return UnifiedReceiptFormatter.FormatUnifiedReceipt(rawReceipt, transactionId, storeName);
		}

		// Token: 0x04000055 RID: 85
		private string m_Receipt = "";
	}
}
