using System;

namespace UnityEngine.Purchasing
{
	// Token: 0x020000EB RID: 235
	public class GoogleProductMetadata : ProductMetadata
	{
		// Token: 0x170000A7 RID: 167
		// (get) Token: 0x0600046C RID: 1132 RVA: 0x0000A2BA File Offset: 0x000084BA
		// (set) Token: 0x0600046D RID: 1133 RVA: 0x0000A2C2 File Offset: 0x000084C2
		public string originalJson { get; internal set; }

		// Token: 0x170000A8 RID: 168
		// (get) Token: 0x0600046E RID: 1134 RVA: 0x0000A2CB File Offset: 0x000084CB
		// (set) Token: 0x0600046F RID: 1135 RVA: 0x0000A2D3 File Offset: 0x000084D3
		public string subscriptionPeriod { get; internal set; }

		// Token: 0x170000A9 RID: 169
		// (get) Token: 0x06000470 RID: 1136 RVA: 0x0000A2DC File Offset: 0x000084DC
		// (set) Token: 0x06000471 RID: 1137 RVA: 0x0000A2E4 File Offset: 0x000084E4
		public string freeTrialPeriod { get; internal set; }

		// Token: 0x170000AA RID: 170
		// (get) Token: 0x06000472 RID: 1138 RVA: 0x0000A2ED File Offset: 0x000084ED
		// (set) Token: 0x06000473 RID: 1139 RVA: 0x0000A2F5 File Offset: 0x000084F5
		public string introductoryPrice { get; internal set; }

		// Token: 0x170000AB RID: 171
		// (get) Token: 0x06000474 RID: 1140 RVA: 0x0000A2FE File Offset: 0x000084FE
		// (set) Token: 0x06000475 RID: 1141 RVA: 0x0000A306 File Offset: 0x00008506
		public string introductoryPricePeriod { get; internal set; }

		// Token: 0x170000AC RID: 172
		// (get) Token: 0x06000476 RID: 1142 RVA: 0x0000A30F File Offset: 0x0000850F
		// (set) Token: 0x06000477 RID: 1143 RVA: 0x0000A317 File Offset: 0x00008517
		public int introductoryPriceCycles { get; internal set; }

		// Token: 0x06000478 RID: 1144 RVA: 0x0000A320 File Offset: 0x00008520
		internal GoogleProductMetadata(string priceString, string title, string description, string currencyCode, decimal localizedPrice) : base(priceString, title, description, currencyCode, localizedPrice)
		{
		}
	}
}
