using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine.Purchasing.Extension;

namespace UnityEngine.Purchasing
{
	// Token: 0x020000AF RID: 175
	[NullableContext(1)]
	[Nullable(0)]
	public class CatalogProvider : ICatalogProvider, IBaseCatalogProvider
	{
		// Token: 0x06000319 RID: 793 RVA: 0x000075E3 File Offset: 0x000057E3
		public List<ProductDefinition> GetProducts([Nullable(2)] string storeName = null)
		{
			if (storeName != null)
			{
				this.UpdateStoreSpecificIDs(storeName);
			}
			return this.m_Products;
		}

		// Token: 0x0600031A RID: 794 RVA: 0x000075F5 File Offset: 0x000057F5
		public void AddProduct(string id, ProductType type)
		{
			this.AddProduct(id, type, null);
		}

		// Token: 0x0600031B RID: 795 RVA: 0x00007600 File Offset: 0x00005800
		public void AddProduct(string id, ProductType type, [Nullable(2)] StoreSpecificIds storeIDs)
		{
			this.AddProduct(id, type, storeIDs, null);
		}

		// Token: 0x0600031C RID: 796 RVA: 0x0000760C File Offset: 0x0000580C
		public void AddProduct(string id, ProductType type, [Nullable(2)] StoreSpecificIds storeIDs, PayoutDefinition payout)
		{
			this.AddProduct(id, type, storeIDs, new List<PayoutDefinition>
			{
				payout
			});
		}

		// Token: 0x0600031D RID: 797 RVA: 0x00007624 File Offset: 0x00005824
		public void AddProduct(string id, ProductType type, [Nullable(2)] StoreSpecificIds storeIDs, [Nullable(new byte[]
		{
			2,
			1
		})] IEnumerable<PayoutDefinition> payouts)
		{
			string storeSpecificId = this.AddStoreSpecificIds(id, storeIDs);
			ProductDefinition productDefinition = new ProductDefinition(id, storeSpecificId, type);
			if (payouts != null)
			{
				productDefinition.SetPayouts(payouts);
			}
			this.m_Products.Add(productDefinition);
		}

		// Token: 0x0600031E RID: 798 RVA: 0x0000765C File Offset: 0x0000585C
		private string AddStoreSpecificIds(string id, [Nullable(2)] StoreSpecificIds storeIDs)
		{
			if (storeIDs == null)
			{
				return id;
			}
			string text = id;
			string result;
			using (IEnumerator<KeyValuePair<string, string>> enumerator = storeIDs.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					KeyValuePair<string, string> keyValuePair = enumerator.Current;
					if (!this.m_StoreSpecificIds.ContainsKey(keyValuePair.Key))
					{
						this.m_StoreSpecificIds.Add(keyValuePair.Key, new Dictionary<string, string>());
					}
					this.m_StoreSpecificIds[keyValuePair.Key][id] = keyValuePair.Value;
					text = keyValuePair.Value;
				}
				result = text;
			}
			return result;
		}

		// Token: 0x0600031F RID: 799 RVA: 0x000076FC File Offset: 0x000058FC
		public void AddProducts(IEnumerable<ProductDefinition> productsDefinitions, [Nullable(new byte[]
		{
			2,
			1,
			1
		})] Dictionary<string, StoreSpecificIds> storeIDsByProductId)
		{
			foreach (ProductDefinition productDefinition in productsDefinitions)
			{
				this.m_Products.Add(productDefinition);
				StoreSpecificIds storeIDs;
				if (storeIDsByProductId != null && storeIDsByProductId.TryGetValue(productDefinition.id, out storeIDs))
				{
					this.AddStoreSpecificIds(productDefinition.id, storeIDs);
				}
			}
		}

		// Token: 0x06000320 RID: 800 RVA: 0x0000776C File Offset: 0x0000596C
		public void FetchProducts(Action<List<ProductDefinition>> callback)
		{
			this.FetchProducts(callback, DefaultStoreHelper.GetDefaultStoreName());
		}

		// Token: 0x06000321 RID: 801 RVA: 0x0000777C File Offset: 0x0000597C
		public void FetchProducts(Action<List<ProductDefinition>> callback, string storeName)
		{
			List<ProductDefinition> products = this.GetProducts(storeName);
			callback(products);
		}

		// Token: 0x06000322 RID: 802 RVA: 0x00007798 File Offset: 0x00005998
		private void UpdateStoreSpecificIDs(string storeName)
		{
			foreach (ProductDefinition productDefinition in this.m_Products)
			{
				Dictionary<string, string> dictionary;
				string storeSpecificId;
				if (this.m_StoreSpecificIds.TryGetValue(storeName, out dictionary) && dictionary.TryGetValue(productDefinition.id, out storeSpecificId))
				{
					productDefinition.storeSpecificId = storeSpecificId;
				}
			}
		}

		// Token: 0x040000EB RID: 235
		[Nullable(new byte[]
		{
			1,
			2,
			1,
			1,
			1
		})]
		private Dictionary<string, Dictionary<string, string>> m_StoreSpecificIds = new Dictionary<string, Dictionary<string, string>>();

		// Token: 0x040000EC RID: 236
		private List<ProductDefinition> m_Products = new List<ProductDefinition>();
	}
}
