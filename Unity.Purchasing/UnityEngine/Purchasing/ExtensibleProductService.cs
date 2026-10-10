using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.CompilerServices;

namespace UnityEngine.Purchasing
{
	// Token: 0x0200000E RID: 14
	[NullableContext(1)]
	[Nullable(0)]
	public abstract class ExtensibleProductService : IProductService
	{
		// Token: 0x06000031 RID: 49 RVA: 0x000024D1 File Offset: 0x000006D1
		protected ExtensibleProductService(IProductService baseProductService)
		{
			this.m_BaseInternalProductService = baseProductService;
		}

		// Token: 0x17000001 RID: 1
		// (get) Token: 0x06000032 RID: 50 RVA: 0x000024E0 File Offset: 0x000006E0
		[Nullable(2)]
		public virtual IAppleStoreExtendedProductService Apple
		{
			[NullableContext(2)]
			get
			{
				return this.m_BaseInternalProductService.Apple;
			}
		}

		// Token: 0x06000033 RID: 51 RVA: 0x000024ED File Offset: 0x000006ED
		public virtual void FetchProductsWithNoRetries(List<ProductDefinition> productDefinitions)
		{
			this.m_BaseInternalProductService.FetchProductsWithNoRetries(productDefinitions);
		}

		// Token: 0x06000034 RID: 52 RVA: 0x000024FB File Offset: 0x000006FB
		public virtual void FetchProducts(List<ProductDefinition> productDefinitions, [Nullable(2)] IRetryPolicy retryPolicy = null)
		{
			this.m_BaseInternalProductService.FetchProducts(productDefinitions, retryPolicy);
		}

		// Token: 0x06000035 RID: 53 RVA: 0x0000250A File Offset: 0x0000070A
		public virtual ReadOnlyObservableCollection<Product> GetProducts()
		{
			return this.m_BaseInternalProductService.GetProducts();
		}

		// Token: 0x06000036 RID: 54 RVA: 0x00002517 File Offset: 0x00000717
		[return: Nullable(2)]
		public virtual Product GetProductById(string productId)
		{
			return this.m_BaseInternalProductService.GetProductById(productId);
		}

		// Token: 0x14000001 RID: 1
		// (add) Token: 0x06000037 RID: 55 RVA: 0x00002525 File Offset: 0x00000725
		// (remove) Token: 0x06000038 RID: 56 RVA: 0x00002533 File Offset: 0x00000733
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		public event Action<List<Product>> OnProductsFetched
		{
			add
			{
				this.m_BaseInternalProductService.OnProductsFetched += value;
			}
			remove
			{
				this.m_BaseInternalProductService.OnProductsFetched -= value;
			}
		}

		// Token: 0x14000002 RID: 2
		// (add) Token: 0x06000039 RID: 57 RVA: 0x00002541 File Offset: 0x00000741
		// (remove) Token: 0x0600003A RID: 58 RVA: 0x0000254F File Offset: 0x0000074F
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public event Action<ProductFetchFailed> OnProductsFetchFailed
		{
			add
			{
				this.m_BaseInternalProductService.OnProductsFetchFailed += value;
			}
			remove
			{
				this.m_BaseInternalProductService.OnProductsFetchFailed -= value;
			}
		}

		// Token: 0x04000007 RID: 7
		private IProductService m_BaseInternalProductService;
	}
}
