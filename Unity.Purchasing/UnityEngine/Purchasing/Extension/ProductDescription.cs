using System;

namespace UnityEngine.Purchasing.Extension
{
	// Token: 0x0200012F RID: 303
	public class ProductDescription
	{
		// Token: 0x0600056B RID: 1387 RVA: 0x0000BE47 File Offset: 0x0000A047
		public ProductDescription(string id, ProductMetadata metadata, string receipt, string transactionId)
		{
			this.storeSpecificId = id;
			this.metadata = metadata;
			this.receipt = receipt;
			this.transactionId = transactionId;
		}

		// Token: 0x0600056C RID: 1388 RVA: 0x0000BE6C File Offset: 0x0000A06C
		public ProductDescription(string id, ProductMetadata metadata, string receipt, string transactionId, ProductType type) : this(id, metadata, receipt, transactionId)
		{
			this.type = type;
		}

		// Token: 0x0600056D RID: 1389 RVA: 0x0000BE81 File Offset: 0x0000A081
		public ProductDescription(string id, ProductMetadata metadata) : this(id, metadata, null, null)
		{
		}

		// Token: 0x170000C7 RID: 199
		// (get) Token: 0x0600056E RID: 1390 RVA: 0x0000BE8D File Offset: 0x0000A08D
		// (set) Token: 0x0600056F RID: 1391 RVA: 0x0000BE95 File Offset: 0x0000A095
		public string storeSpecificId { get; private set; }

		// Token: 0x170000C8 RID: 200
		// (get) Token: 0x06000570 RID: 1392 RVA: 0x0000BE9E File Offset: 0x0000A09E
		// (set) Token: 0x06000571 RID: 1393 RVA: 0x0000BEA6 File Offset: 0x0000A0A6
		public ProductMetadata metadata { get; private set; }

		// Token: 0x170000C9 RID: 201
		// (get) Token: 0x06000572 RID: 1394 RVA: 0x0000BEAF File Offset: 0x0000A0AF
		// (set) Token: 0x06000573 RID: 1395 RVA: 0x0000BEB7 File Offset: 0x0000A0B7
		public string receipt { get; private set; }

		// Token: 0x170000CA RID: 202
		// (get) Token: 0x06000574 RID: 1396 RVA: 0x0000BEC0 File Offset: 0x0000A0C0
		// (set) Token: 0x06000575 RID: 1397 RVA: 0x0000BEC8 File Offset: 0x0000A0C8
		public string transactionId { get; set; }

		// Token: 0x06000576 RID: 1398 RVA: 0x0000BED4 File Offset: 0x0000A0D4
		public override string ToString()
		{
			return string.Format("ProductDescription: {0}, {1}, {2}, {3}, {4} \n --------------------------", new object[]
			{
				this.storeSpecificId,
				this.type,
				this.receipt,
				this.transactionId,
				this.metadata
			});
		}

		// Token: 0x04000279 RID: 633
		public ProductType type;
	}
}
