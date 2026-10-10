using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.CompilerServices;
using UnityEngine.Purchasing.Extension;

namespace UnityEngine.Purchasing
{
	// Token: 0x02000018 RID: 24
	[NullableContext(1)]
	[Nullable(0)]
	internal class ProductService : IProductService
	{
		// Token: 0x14000005 RID: 5
		// (add) Token: 0x06000054 RID: 84 RVA: 0x000025F0 File Offset: 0x000007F0
		// (remove) Token: 0x06000055 RID: 85 RVA: 0x00002628 File Offset: 0x00000828
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		public event Action<List<Product>> OnProductsFetched;

		// Token: 0x14000006 RID: 6
		// (add) Token: 0x06000056 RID: 86 RVA: 0x00002660 File Offset: 0x00000860
		// (remove) Token: 0x06000057 RID: 87 RVA: 0x00002698 File Offset: 0x00000898
		[Nullable(new byte[]
		{
			2,
			1
		})]
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public event Action<ProductFetchFailed> OnProductsFetchFailed;

		// Token: 0x06000058 RID: 88 RVA: 0x000026CD File Offset: 0x000008CD
		internal ProductService(IFetchProductsUseCase fetchProductsUseCase, IStoreWrapper storeWrapper)
		{
			this.m_FetchProductsUseCase = fetchProductsUseCase;
			this.m_StoreWrapper = storeWrapper;
			this.m_ProductCache = storeWrapper.instance.ProductCache;
		}

		// Token: 0x1700000B RID: 11
		// (get) Token: 0x06000059 RID: 89 RVA: 0x000026F4 File Offset: 0x000008F4
		[Nullable(2)]
		public IAppleStoreExtendedProductService Apple
		{
			[NullableContext(2)]
			get
			{
				return this as IAppleStoreExtendedProductService;
			}
		}

		// Token: 0x0600005A RID: 90 RVA: 0x000026FC File Offset: 0x000008FC
		public void FetchProductsWithNoRetries(List<ProductDefinition> productDefinitions)
		{
			this.FetchProducts(productDefinitions, null);
		}

		// Token: 0x0600005B RID: 91 RVA: 0x00002708 File Offset: 0x00000908
		public void FetchProducts(List<ProductDefinition> productDefinitions, [Nullable(2)] IRetryPolicy retryPolicy)
		{
			try
			{
				this.CheckStoreConnectionState();
				this.m_FetchProductsUseCase.FetchProducts(productDefinitions, new Action<List<Product>>(this.HandleProductsFetched), new Action<List<ProductDefinition>, string>(this.HandleProductsFetchFailed), retryPolicy ?? ProductService.k_DefaultRetryPolicy);
			}
			catch (Exception ex)
			{
				this.HandleProductsFetchFailed(productDefinitions, ex.Message);
			}
		}

		// Token: 0x0600005C RID: 92 RVA: 0x0000276C File Offset: 0x0000096C
		public ReadOnlyObservableCollection<Product> GetProducts()
		{
			return this.m_ProductCache.GetProducts();
		}

		// Token: 0x0600005D RID: 93 RVA: 0x00002779 File Offset: 0x00000979
		[return: Nullable(2)]
		public Product GetProductById(string productId)
		{
			return this.m_ProductCache.Find(productId);
		}

		// Token: 0x0600005E RID: 94 RVA: 0x00002787 File Offset: 0x00000987
		private void HandleProductsFetched([Nullable(new byte[]
		{
			2,
			1
		})] List<Product> fetchedProducts)
		{
			if (fetchedProducts == null)
			{
				fetchedProducts = new List<Product>();
			}
			this.m_ProductCache.Add(fetchedProducts);
			Action<List<Product>> onProductsFetched = this.OnProductsFetched;
			if (onProductsFetched == null)
			{
				return;
			}
			onProductsFetched(fetchedProducts);
		}

		// Token: 0x0600005F RID: 95 RVA: 0x000027B0 File Offset: 0x000009B0
		private void HandleProductsFetchFailed([Nullable(new byte[]
		{
			2,
			1
		})] List<ProductDefinition> fetchedProducts, string reason)
		{
			ProductFetchFailed obj = new ProductFetchFailed(fetchedProducts ?? new List<ProductDefinition>(), reason);
			Action<ProductFetchFailed> onProductsFetchFailed = this.OnProductsFetchFailed;
			if (onProductsFetchFailed == null)
			{
				return;
			}
			onProductsFetchFailed(obj);
		}

		// Token: 0x06000060 RID: 96 RVA: 0x000027E0 File Offset: 0x000009E0
		private void CheckStoreConnectionState()
		{
			if (this.m_StoreWrapper.GetStoreConnectionState() != ConnectionState.Connected)
			{
				throw new Exception("Product Service couldn't execute its task, store connection state: " + this.m_StoreWrapper.GetStoreConnectionState().ToString());
			}
		}

		// Token: 0x04000014 RID: 20
		private static readonly IRetryPolicy k_DefaultRetryPolicy = new ExponentialBackOffRetryPolicy(1000, 30000, 2f);

		// Token: 0x04000015 RID: 21
		private readonly IFetchProductsUseCase m_FetchProductsUseCase;

		// Token: 0x04000016 RID: 22
		private readonly IStoreWrapper m_StoreWrapper;

		// Token: 0x04000017 RID: 23
		private readonly IProductCache m_ProductCache;
	}
}
