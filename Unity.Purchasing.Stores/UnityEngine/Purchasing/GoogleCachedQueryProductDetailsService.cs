using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using UnityEngine.Scripting;

namespace UnityEngine.Purchasing
{
	// Token: 0x02000010 RID: 16
	[Preserve]
	internal class GoogleCachedQueryProductDetailsService : IGoogleCachedQueryProductDetailsService
	{
		// Token: 0x06000027 RID: 39 RVA: 0x00002764 File Offset: 0x00000964
		protected override void Finalize()
		{
			try
			{
				foreach (KeyValuePair<string, AndroidJavaObject> keyValuePair in this.m_CachedQueriedProductDetails)
				{
					AndroidJavaObject value = keyValuePair.Value;
					if (value != null)
					{
						value.Dispose();
					}
				}
			}
			finally
			{
				base.Finalize();
			}
		}

		// Token: 0x06000028 RID: 40 RVA: 0x000027D0 File Offset: 0x000009D0
		public IEnumerable<AndroidJavaObject> GetCachedQueriedProducts()
		{
			return this.m_CachedQueriedProductDetails.Values;
		}

		// Token: 0x06000029 RID: 41 RVA: 0x000027DD File Offset: 0x000009DD
		private AndroidJavaObject GetCachedQueriedProductDetails(string productId)
		{
			return this.m_CachedQueriedProductDetails[productId];
		}

		// Token: 0x0600002A RID: 42 RVA: 0x000027EB File Offset: 0x000009EB
		private IEnumerable<AndroidJavaObject> GetCachedQueriedProductDetails(IEnumerable<string> productIds)
		{
			return productIds.Select(new Func<string, AndroidJavaObject>(this.GetCachedQueriedProductDetails));
		}

		// Token: 0x0600002B RID: 43 RVA: 0x000027FF File Offset: 0x000009FF
		public IEnumerable<AndroidJavaObject> GetCachedQueriedProductDetails(IEnumerable<ProductDefinition> products)
		{
			return this.GetCachedQueriedProductDetails((from product in products
			select product.storeSpecificId).ToList<string>());
		}

		// Token: 0x0600002C RID: 44 RVA: 0x00002831 File Offset: 0x00000A31
		private bool Contains(string productId)
		{
			return this.m_CachedQueriedProductDetails.ContainsKey(productId);
		}

		// Token: 0x0600002D RID: 45 RVA: 0x0000283F File Offset: 0x00000A3F
		public bool Contains(ProductDefinition products)
		{
			return this.Contains(products.storeSpecificId);
		}

		// Token: 0x0600002E RID: 46 RVA: 0x00002850 File Offset: 0x00000A50
		public void AddCachedQueriedProductDetails(IEnumerable<AndroidJavaObject> queriedProducts)
		{
			foreach (AndroidJavaObject androidJavaObject in queriedProducts)
			{
				string key = androidJavaObject.Call<string>("getProductId", Array.Empty<object>());
				this.m_CachedQueriedProductDetails[key] = androidJavaObject.CloneReference();
			}
		}

		// Token: 0x04000013 RID: 19
		private readonly ConcurrentDictionary<string, AndroidJavaObject> m_CachedQueriedProductDetails = new ConcurrentDictionary<string, AndroidJavaObject>();
	}
}
