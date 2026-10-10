using System;
using System.Collections.Generic;
using UnityEngine.Purchasing.Extension;

namespace UnityEngine.Purchasing
{
	// Token: 0x020000DD RID: 221
	[Obsolete("This API is deprecated. Please upgrade to the new APIs introduced in IAP v5. For more information, visit the IAP manual: https://docs.unity.com/ugs/en-us/manual/iap/manual/upgrade-to-iap-v5", false)]
	internal class PurchasingFactory
	{
		// Token: 0x170000A5 RID: 165
		// (get) Token: 0x06000456 RID: 1110 RVA: 0x0000A170 File Offset: 0x00008370
		// (set) Token: 0x06000457 RID: 1111 RVA: 0x0000A178 File Offset: 0x00008378
		public string storeName { get; private set; }

		// Token: 0x170000A6 RID: 166
		// (get) Token: 0x06000458 RID: 1112 RVA: 0x0000A181 File Offset: 0x00008381
		// (set) Token: 0x06000459 RID: 1113 RVA: 0x0000A19C File Offset: 0x0000839C
		public IStore service
		{
			get
			{
				if (this.m_Store != null)
				{
					return this.m_Store;
				}
				throw new InvalidOperationException("No impl available!");
			}
			set
			{
				this.m_Store = value;
			}
		}

		// Token: 0x0600045A RID: 1114 RVA: 0x0000A1A5 File Offset: 0x000083A5
		public void RegisterStore(string name, Store s)
		{
			if (this.m_Store == null && s != null)
			{
				this.storeName = name;
				this.service = s;
			}
		}

		// Token: 0x0600045B RID: 1115 RVA: 0x0000A1C0 File Offset: 0x000083C0
		public void SetCatalogProvider(IBaseCatalogProvider provider)
		{
			this.m_CatalogProvider = provider;
		}

		// Token: 0x0600045C RID: 1116 RVA: 0x0000A1C9 File Offset: 0x000083C9
		public void SetCatalogProviderFunction(Action<Action<List<ProductDefinition>>> func)
		{
			this.m_CatalogProvider = new SimpleCatalogProvider(func);
		}

		// Token: 0x0600045D RID: 1117 RVA: 0x0000A1D7 File Offset: 0x000083D7
		internal IBaseCatalogProvider GetCatalogProvider()
		{
			return this.m_CatalogProvider;
		}

		// Token: 0x040001BC RID: 444
		private IStore m_Store;

		// Token: 0x040001BD RID: 445
		private IBaseCatalogProvider m_CatalogProvider;
	}
}
