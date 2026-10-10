using System;
using System.Collections.Generic;
using System.Linq;

namespace UnityEngine.Purchasing
{
	// Token: 0x020000D7 RID: 215
	[Obsolete("This API is deprecated. Please upgrade to the new APIs introduced in IAP v5. For more information, visit the IAP manual: https://docs.unity.com/ugs/en-us/manual/iap/manual/upgrade-to-iap-v5", false)]
	public class ProductCollection
	{
		// Token: 0x17000094 RID: 148
		// (get) Token: 0x06000425 RID: 1061 RVA: 0x00009D52 File Offset: 0x00007F52
		public HashSet<Product> set
		{
			get
			{
				return new HashSet<Product>(this.all);
			}
		}

		// Token: 0x17000095 RID: 149
		// (get) Token: 0x06000426 RID: 1062 RVA: 0x00009D5F File Offset: 0x00007F5F
		public Product[] all
		{
			get
			{
				return ProductServiceProvider.GetDefaultProductService().GetProducts().ToArray<Product>();
			}
		}

		// Token: 0x06000427 RID: 1063 RVA: 0x00009D70 File Offset: 0x00007F70
		public Product WithID(string id)
		{
			Product result;
			this.all.ToDictionary((Product x) => x.definition.id).TryGetValue(id, out result);
			return result;
		}

		// Token: 0x06000428 RID: 1064 RVA: 0x00009DB4 File Offset: 0x00007FB4
		public Product WithStoreSpecificID(string id)
		{
			Product result = null;
			if (id != null)
			{
				this.all.ToDictionary((Product x) => x.definition.storeSpecificId).TryGetValue(id, out result);
			}
			return result;
		}

		// Token: 0x0400019C RID: 412
		private Dictionary<string, Product> m_IdToProduct;

		// Token: 0x0400019D RID: 413
		private Dictionary<string, Product> m_StoreSpecificIdToProduct;
	}
}
