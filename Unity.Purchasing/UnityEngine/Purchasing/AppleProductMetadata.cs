using System;

namespace UnityEngine.Purchasing
{
	// Token: 0x020000EF RID: 239
	public class AppleProductMetadata : ProductMetadata
	{
		// Token: 0x170000AD RID: 173
		// (get) Token: 0x06000484 RID: 1156 RVA: 0x0000A337 File Offset: 0x00008537
		public bool isFamilyShareable { get; }

		// Token: 0x06000485 RID: 1157 RVA: 0x0000A33F File Offset: 0x0000853F
		internal AppleProductMetadata(ProductMetadata baseProductMetadata, bool isFamilyShareable) : base(baseProductMetadata)
		{
			this.isFamilyShareable = isFamilyShareable;
		}

		// Token: 0x06000486 RID: 1158 RVA: 0x0000A34F File Offset: 0x0000854F
		internal AppleProductMetadata(string priceString, string title, string description, string currencyCode, decimal localizedPrice, bool isFamilyShareable) : base(priceString, title, description, currencyCode, localizedPrice)
		{
			this.isFamilyShareable = isFamilyShareable;
		}
	}
}
