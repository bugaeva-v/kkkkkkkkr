using System;
using System.Collections.Generic;
using UnityEngine.Purchasing.Extension;

namespace UnityEngine.Purchasing
{
	// Token: 0x020000BC RID: 188
	[Obsolete("This API is deprecated. Please upgrade to the new APIs introduced in IAP v5. For more information, visit the IAP manual: https://docs.unity.com/ugs/en-us/manual/iap/manual/upgrade-to-iap-v5", false)]
	public class ConfigurationBuilder
	{
		// Token: 0x06000365 RID: 869 RVA: 0x0000853A File Offset: 0x0000673A
		public static ConfigurationBuilder Instance(object ignored)
		{
			if (ConfigurationBuilder.instance == null)
			{
				ConfigurationBuilder.instance = new ConfigurationBuilder();
			}
			return ConfigurationBuilder.instance;
		}

		// Token: 0x06000366 RID: 870 RVA: 0x00008552 File Offset: 0x00006752
		public void AddProduct(string id, ProductType type)
		{
			this.AddProduct(id, type, null);
		}

		// Token: 0x06000367 RID: 871 RVA: 0x0000855D File Offset: 0x0000675D
		public void AddProduct(string id, ProductType type, StoreSpecificIds storeIDs)
		{
			this.AddProduct(id, type, storeIDs, null);
		}

		// Token: 0x06000368 RID: 872 RVA: 0x00008569 File Offset: 0x00006769
		public void AddProduct(string id, ProductType type, StoreSpecificIds storeIDs, PayoutDefinition payout)
		{
			this.AddProduct(id, type, storeIDs, new List<PayoutDefinition>
			{
				payout
			});
		}

		// Token: 0x06000369 RID: 873 RVA: 0x00008581 File Offset: 0x00006781
		public void AddProduct(string id, ProductType type, StoreSpecificIds storeIDs, IEnumerable<PayoutDefinition> payouts)
		{
			this.m_CatalogProvider.AddProduct(id, type, storeIDs, payouts);
		}

		// Token: 0x0600036A RID: 874 RVA: 0x00008593 File Offset: 0x00006793
		public T Configure<T>() where T : IStoreConfiguration
		{
			return this.m_ConfigurationProvider.GetConfiguration<T>();
		}

		// Token: 0x0400016C RID: 364
		private static ConfigurationBuilder instance;

		// Token: 0x0400016D RID: 365
		internal CatalogProvider m_CatalogProvider = new CatalogProvider();

		// Token: 0x0400016E RID: 366
		internal ConfigurationProvider m_ConfigurationProvider = new ConfigurationProvider();
	}
}
