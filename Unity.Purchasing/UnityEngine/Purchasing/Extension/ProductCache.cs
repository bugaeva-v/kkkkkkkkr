using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.CompilerServices;

namespace UnityEngine.Purchasing.Extension
{
	// Token: 0x0200012E RID: 302
	[NullableContext(1)]
	[Nullable(0)]
	internal class ProductCache : IProductCache
	{
		// Token: 0x170000C4 RID: 196
		// (get) Token: 0x0600055F RID: 1375 RVA: 0x0000BC74 File Offset: 0x00009E74
		public Dictionary<string, Product> productsById { get; } = new Dictionary<string, Product>();

		// Token: 0x170000C5 RID: 197
		// (get) Token: 0x06000560 RID: 1376 RVA: 0x0000BC7C File Offset: 0x00009E7C
		private Dictionary<string, Product> productsByStoreSpecificId { get; } = new Dictionary<string, Product>();

		// Token: 0x170000C6 RID: 198
		// (get) Token: 0x06000561 RID: 1377 RVA: 0x0000BC84 File Offset: 0x00009E84
		private Dictionary<string, string> storeSpecificProductIds { get; } = new Dictionary<string, string>();

		// Token: 0x06000562 RID: 1378 RVA: 0x0000BC8C File Offset: 0x00009E8C
		internal ProductCache()
		{
			this.m_ProductsReadOnly = new ReadOnlyObservableCollection<Product>(this.m_Products);
		}

		// Token: 0x06000563 RID: 1379 RVA: 0x0000BCDC File Offset: 0x00009EDC
		public void Add(List<Product> products)
		{
			foreach (Product product in products)
			{
				this.Add(product);
			}
		}

		// Token: 0x06000564 RID: 1380 RVA: 0x0000BD2C File Offset: 0x00009F2C
		public void Add(Product product)
		{
			if (this.Find(product.definition.id) != null || this.Find(product.definition.storeSpecificId) != null)
			{
				return;
			}
			this.productsById[product.definition.id] = product;
			this.productsByStoreSpecificId[product.definition.storeSpecificId] = product;
			this.m_Products.Add(product);
		}

		// Token: 0x06000565 RID: 1381 RVA: 0x0000BD9A File Offset: 0x00009F9A
		public ReadOnlyObservableCollection<Product> GetProducts()
		{
			return this.m_ProductsReadOnly;
		}

		// Token: 0x06000566 RID: 1382 RVA: 0x0000BDA2 File Offset: 0x00009FA2
		public void Remove(Product product)
		{
			this.productsById.Remove(product.definition.id);
			this.productsByStoreSpecificId.Remove(product.definition.storeSpecificId);
			this.m_Products.Remove(product);
		}

		// Token: 0x06000567 RID: 1383 RVA: 0x0000BDDF File Offset: 0x00009FDF
		public Product FindOrDefault([Nullable(2)] string productId)
		{
			return this.Find(productId) ?? Product.CreateUnknownProduct(productId);
		}

		// Token: 0x06000568 RID: 1384 RVA: 0x0000BDF2 File Offset: 0x00009FF2
		[NullableContext(2)]
		public Product Find(string productId)
		{
			if (this.HasId(productId))
			{
				return this.productsById[productId];
			}
			if (!this.HasStoreSpecificId(productId))
			{
				return null;
			}
			return this.productsByStoreSpecificId[productId];
		}

		// Token: 0x06000569 RID: 1385 RVA: 0x0000BE21 File Offset: 0x0000A021
		[NullableContext(2)]
		private bool HasId(string productId)
		{
			return productId != null && this.productsById.ContainsKey(productId);
		}

		// Token: 0x0600056A RID: 1386 RVA: 0x0000BE34 File Offset: 0x0000A034
		[NullableContext(2)]
		private bool HasStoreSpecificId(string productId)
		{
			return productId != null && this.productsByStoreSpecificId.ContainsKey(productId);
		}

		// Token: 0x04000273 RID: 627
		private ObservableCollection<Product> m_Products = new ObservableCollection<Product>();

		// Token: 0x04000274 RID: 628
		private readonly ReadOnlyObservableCollection<Product> m_ProductsReadOnly;
	}
}
