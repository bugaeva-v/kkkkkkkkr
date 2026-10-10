using System;

namespace UnityEngine.Purchasing
{
	// Token: 0x020000D9 RID: 217
	public class ProductMetadata
	{
		// Token: 0x0600043F RID: 1087 RVA: 0x00009FAB File Offset: 0x000081AB
		public ProductMetadata(string priceString, string title, string description, string currencyCode, decimal localizedPrice)
		{
			this.localizedPriceString = priceString;
			this.localizedTitle = title;
			this.localizedDescription = description;
			this.isoCurrencyCode = currencyCode;
			this.localizedPrice = localizedPrice;
		}

		// Token: 0x06000440 RID: 1088 RVA: 0x00009FD8 File Offset: 0x000081D8
		public ProductMetadata(ProductMetadata productMetadata)
		{
			this.localizedPriceString = productMetadata.localizedPriceString;
			this.localizedTitle = productMetadata.localizedTitle;
			this.localizedDescription = productMetadata.localizedDescription;
			this.isoCurrencyCode = productMetadata.isoCurrencyCode;
			this.localizedPrice = productMetadata.localizedPrice;
		}

		// Token: 0x06000441 RID: 1089 RVA: 0x0000A027 File Offset: 0x00008227
		public ProductMetadata()
		{
		}

		// Token: 0x1700009C RID: 156
		// (get) Token: 0x06000442 RID: 1090 RVA: 0x0000A02F File Offset: 0x0000822F
		// (set) Token: 0x06000443 RID: 1091 RVA: 0x0000A037 File Offset: 0x00008237
		public string localizedPriceString { get; internal set; }

		// Token: 0x1700009D RID: 157
		// (get) Token: 0x06000444 RID: 1092 RVA: 0x0000A040 File Offset: 0x00008240
		// (set) Token: 0x06000445 RID: 1093 RVA: 0x0000A048 File Offset: 0x00008248
		public string localizedTitle { get; internal set; }

		// Token: 0x1700009E RID: 158
		// (get) Token: 0x06000446 RID: 1094 RVA: 0x0000A051 File Offset: 0x00008251
		// (set) Token: 0x06000447 RID: 1095 RVA: 0x0000A059 File Offset: 0x00008259
		public string localizedDescription { get; internal set; }

		// Token: 0x1700009F RID: 159
		// (get) Token: 0x06000448 RID: 1096 RVA: 0x0000A062 File Offset: 0x00008262
		// (set) Token: 0x06000449 RID: 1097 RVA: 0x0000A06A File Offset: 0x0000826A
		public string isoCurrencyCode { get; internal set; }

		// Token: 0x170000A0 RID: 160
		// (get) Token: 0x0600044A RID: 1098 RVA: 0x0000A073 File Offset: 0x00008273
		// (set) Token: 0x0600044B RID: 1099 RVA: 0x0000A07B File Offset: 0x0000827B
		public decimal localizedPrice { get; internal set; }

		// Token: 0x0600044C RID: 1100 RVA: 0x0000A084 File Offset: 0x00008284
		public override string ToString()
		{
			return string.Format("ProductMetaData: {0}, {1}, {2}, {3}, {4}", new object[]
			{
				this.localizedPriceString,
				this.localizedTitle,
				this.localizedDescription,
				this.isoCurrencyCode,
				this.localizedPrice
			});
		}
	}
}
