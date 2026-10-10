using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.CompilerServices;

namespace UnityEngine.Purchasing.Extension
{
	// Token: 0x0200012C RID: 300
	[NullableContext(1)]
	internal interface IProductCache
	{
		// Token: 0x170000C3 RID: 195
		// (get) Token: 0x0600054B RID: 1355
		Dictionary<string, Product> productsById { get; }

		// Token: 0x0600054C RID: 1356
		void Add(Product product);

		// Token: 0x0600054D RID: 1357
		void Add(List<Product> product);

		// Token: 0x0600054E RID: 1358
		ReadOnlyObservableCollection<Product> GetProducts();

		// Token: 0x0600054F RID: 1359
		[NullableContext(2)]
		Product Find(string productId);

		// Token: 0x06000550 RID: 1360
		Product FindOrDefault([Nullable(2)] string productId);

		// Token: 0x06000551 RID: 1361
		void Remove(Product product);
	}
}
