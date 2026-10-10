using System;

namespace UnityEngine.Purchasing
{
	// Token: 0x0200004A RID: 74
	internal class CheckEntitlementRequest
	{
		// Token: 0x1700001D RID: 29
		// (get) Token: 0x0600013C RID: 316 RVA: 0x000039CA File Offset: 0x00001BCA
		internal Product ProductToCheck { get; }

		// Token: 0x1700001E RID: 30
		// (get) Token: 0x0600013D RID: 317 RVA: 0x000039D2 File Offset: 0x00001BD2
		internal Action<Entitlement> OnChecked { get; }

		// Token: 0x0600013E RID: 318 RVA: 0x000039DA File Offset: 0x00001BDA
		internal CheckEntitlementRequest(Product product, Action<Entitlement> onChecked)
		{
			this.ProductToCheck = product;
			this.OnChecked = onChecked;
		}
	}
}
