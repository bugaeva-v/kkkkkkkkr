using System;

namespace UnityEngine.Purchasing
{
	// Token: 0x020000B5 RID: 181
	[Serializable]
	public class ProductCatalogPayout
	{
		// Token: 0x17000069 RID: 105
		// (get) Token: 0x06000334 RID: 820 RVA: 0x00007E28 File Offset: 0x00006028
		// (set) Token: 0x06000335 RID: 821 RVA: 0x00007E6A File Offset: 0x0000606A
		public ProductCatalogPayout.ProductCatalogPayoutType type
		{
			get
			{
				ProductCatalogPayout.ProductCatalogPayoutType result = ProductCatalogPayout.ProductCatalogPayoutType.Other;
				if (Enum.IsDefined(typeof(ProductCatalogPayout.ProductCatalogPayoutType), this.t))
				{
					result = (ProductCatalogPayout.ProductCatalogPayoutType)Enum.Parse(typeof(ProductCatalogPayout.ProductCatalogPayoutType), this.t);
				}
				return result;
			}
			set
			{
				this.t = value.ToString();
			}
		}

		// Token: 0x1700006A RID: 106
		// (get) Token: 0x06000336 RID: 822 RVA: 0x00007E7F File Offset: 0x0000607F
		public string typeString
		{
			get
			{
				return this.t;
			}
		}

		// Token: 0x1700006B RID: 107
		// (get) Token: 0x06000337 RID: 823 RVA: 0x00007E87 File Offset: 0x00006087
		// (set) Token: 0x06000338 RID: 824 RVA: 0x00007E8F File Offset: 0x0000608F
		public string subtype
		{
			get
			{
				return this.st;
			}
			set
			{
				if (value.Length > 64)
				{
					throw new ArgumentException(string.Format("subtype should be no longer than {0} characters", 64));
				}
				this.st = value;
			}
		}

		// Token: 0x1700006C RID: 108
		// (get) Token: 0x06000339 RID: 825 RVA: 0x00007EB9 File Offset: 0x000060B9
		// (set) Token: 0x0600033A RID: 826 RVA: 0x00007EC1 File Offset: 0x000060C1
		public double quantity
		{
			get
			{
				return this.q;
			}
			set
			{
				this.q = value;
			}
		}

		// Token: 0x1700006D RID: 109
		// (get) Token: 0x0600033B RID: 827 RVA: 0x00007ECA File Offset: 0x000060CA
		// (set) Token: 0x0600033C RID: 828 RVA: 0x00007ED2 File Offset: 0x000060D2
		public string data
		{
			get
			{
				return this.d;
			}
			set
			{
				if (value.Length > 1024)
				{
					throw new ArgumentException(string.Format("data should be no longer than {0} characters", 1024));
				}
				this.d = value;
			}
		}

		// Token: 0x04000152 RID: 338
		[SerializeField]
		private string t = ProductCatalogPayout.ProductCatalogPayoutType.Other.ToString();

		// Token: 0x04000153 RID: 339
		public const int MaxSubtypeLength = 64;

		// Token: 0x04000154 RID: 340
		[SerializeField]
		private string st = string.Empty;

		// Token: 0x04000155 RID: 341
		[SerializeField]
		private double q;

		// Token: 0x04000156 RID: 342
		public const int MaxDataLength = 1024;

		// Token: 0x04000157 RID: 343
		[SerializeField]
		private string d = string.Empty;

		// Token: 0x0200017A RID: 378
		public enum ProductCatalogPayoutType
		{
			// Token: 0x04000304 RID: 772
			Other,
			// Token: 0x04000305 RID: 773
			Currency,
			// Token: 0x04000306 RID: 774
			Item,
			// Token: 0x04000307 RID: 775
			Resource
		}
	}
}
