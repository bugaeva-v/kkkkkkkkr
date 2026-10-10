using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using UnityEngine.Purchasing.Extension;
using UnityEngine.Purchasing.Interfaces;
using UnityEngine.Purchasing.Models;
using UnityEngine.Scripting;

namespace UnityEngine.Purchasing
{
	// Token: 0x02000021 RID: 33
	[NullableContext(1)]
	[Nullable(0)]
	internal class QueryProductDetailsService : IQueryProductDetailsService
	{
		// Token: 0x06000094 RID: 148 RVA: 0x00003E57 File Offset: 0x00002057
		[Preserve]
		internal QueryProductDetailsService(IGoogleBillingClient billingClient, IGoogleCachedQueryProductDetailsService googleCachedQueryProductDetailsService, IProductDetailsConverter productDetailsConverter)
		{
			this.m_BillingClient = billingClient;
			this.m_GoogleCachedQueryProductDetailsService = googleCachedQueryProductDetailsService;
			this.m_ProductDetailsConverter = productDetailsConverter;
		}

		// Token: 0x06000095 RID: 149 RVA: 0x00003E74 File Offset: 0x00002074
		public Task<List<AndroidJavaObject>> QueryProductDetails(ProductDefinition product)
		{
			return this.QueryProductDetails(new List<ProductDefinition>
			{
				product
			}.AsReadOnly());
		}

		// Token: 0x06000096 RID: 150 RVA: 0x00003E90 File Offset: 0x00002090
		public Task<List<ProductDescription>> QueryProductDescriptions(IReadOnlyCollection<ProductDefinition> products)
		{
			QueryProductDetailsService.<QueryProductDescriptions>d__5 <QueryProductDescriptions>d__;
			<QueryProductDescriptions>d__.<>t__builder = AsyncTaskMethodBuilder<List<ProductDescription>>.Create();
			<QueryProductDescriptions>d__.<>4__this = this;
			<QueryProductDescriptions>d__.products = products;
			<QueryProductDescriptions>d__.<>1__state = -1;
			<QueryProductDescriptions>d__.<>t__builder.Start<QueryProductDetailsService.<QueryProductDescriptions>d__5>(ref <QueryProductDescriptions>d__);
			return <QueryProductDescriptions>d__.<>t__builder.Task;
		}

		// Token: 0x06000097 RID: 151 RVA: 0x00003EDC File Offset: 0x000020DC
		public virtual Task<List<AndroidJavaObject>> QueryProductDetails(IReadOnlyCollection<ProductDefinition> products)
		{
			QueryProductDetailsService.<QueryProductDetails>d__6 <QueryProductDetails>d__;
			<QueryProductDetails>d__.<>t__builder = AsyncTaskMethodBuilder<List<AndroidJavaObject>>.Create();
			<QueryProductDetails>d__.<>4__this = this;
			<QueryProductDetails>d__.products = products;
			<QueryProductDetails>d__.<>1__state = -1;
			<QueryProductDetails>d__.<>t__builder.Start<QueryProductDetailsService.<QueryProductDetails>d__6>(ref <QueryProductDetails>d__);
			return <QueryProductDetails>d__.<>t__builder.Task;
		}

		// Token: 0x06000098 RID: 152 RVA: 0x00003F28 File Offset: 0x00002128
		private Task<ProductDetailsQueryResponse> QueryInAppsAndSubsProductDetails(IReadOnlyCollection<ProductDefinition> products)
		{
			QueryProductDetailsService.<QueryInAppsAndSubsProductDetails>d__7 <QueryInAppsAndSubsProductDetails>d__;
			<QueryInAppsAndSubsProductDetails>d__.<>t__builder = AsyncTaskMethodBuilder<ProductDetailsQueryResponse>.Create();
			<QueryInAppsAndSubsProductDetails>d__.<>4__this = this;
			<QueryInAppsAndSubsProductDetails>d__.products = products;
			<QueryInAppsAndSubsProductDetails>d__.<>1__state = -1;
			<QueryInAppsAndSubsProductDetails>d__.<>t__builder.Start<QueryProductDetailsService.<QueryInAppsAndSubsProductDetails>d__7>(ref <QueryInAppsAndSubsProductDetails>d__);
			return <QueryInAppsAndSubsProductDetails>d__.<>t__builder.Task;
		}

		// Token: 0x06000099 RID: 153 RVA: 0x00003F73 File Offset: 0x00002173
		private bool ShouldRetryQuery(IEnumerable<ProductDefinition> requestedProducts, IProductDetailsQueryResponse queryResponse)
		{
			return !this.AreAllProductDetailsCached(requestedProducts) && queryResponse.IsRecoverable();
		}

		// Token: 0x0600009A RID: 154 RVA: 0x00003F86 File Offset: 0x00002186
		private bool AreAllProductDetailsCached(IEnumerable<ProductDefinition> products)
		{
			return products.Select(new Func<ProductDefinition, bool>(this.m_GoogleCachedQueryProductDetailsService.Contains)).All((bool isCached) => isCached);
		}

		// Token: 0x0600009B RID: 155 RVA: 0x00003FC4 File Offset: 0x000021C4
		private IEnumerable<AndroidJavaObject> GetCachedProductDetails(IEnumerable<ProductDefinition> products)
		{
			List<ProductDefinition> products2 = products.Where(new Func<ProductDefinition, bool>(this.m_GoogleCachedQueryProductDetailsService.Contains)).ToList<ProductDefinition>();
			return this.m_GoogleCachedQueryProductDetailsService.GetCachedQueriedProductDetails(products2);
		}

		// Token: 0x0600009C RID: 156 RVA: 0x00003FFC File Offset: 0x000021FC
		[return: Nullable(new byte[]
		{
			1,
			0,
			1,
			1,
			1
		})]
		private Task<ValueTuple<IGoogleBillingResult, IEnumerable<AndroidJavaObject>>> QueryInAppsAsync(IEnumerable<ProductDefinition> products)
		{
			List<string> productList = (from product in products
			where product.type != ProductType.Subscription
			select product.storeSpecificId).ToList<string>();
			return this.QueryProductDetails(productList, GoogleProductTypeEnum.InApp());
		}

		// Token: 0x0600009D RID: 157 RVA: 0x00004064 File Offset: 0x00002264
		[return: Nullable(new byte[]
		{
			1,
			0,
			1,
			1,
			1
		})]
		private Task<ValueTuple<IGoogleBillingResult, IEnumerable<AndroidJavaObject>>> QuerySubsAsync(IEnumerable<ProductDefinition> products)
		{
			List<string> productList = (from product in products
			where product.type == ProductType.Subscription
			select product.storeSpecificId).ToList<string>();
			return this.QueryProductDetails(productList, GoogleProductTypeEnum.Sub());
		}

		// Token: 0x0600009E RID: 158 RVA: 0x000040CC File Offset: 0x000022CC
		[return: Nullable(new byte[]
		{
			1,
			0,
			1,
			1,
			1
		})]
		private Task<ValueTuple<IGoogleBillingResult, IEnumerable<AndroidJavaObject>>> QueryProductDetails(List<string> productList, string type)
		{
			TaskCompletionSource<ValueTuple<IGoogleBillingResult, IEnumerable<AndroidJavaObject>>> taskCompletionSource = new TaskCompletionSource<ValueTuple<IGoogleBillingResult, IEnumerable<AndroidJavaObject>>>();
			if (productList.Count == 0)
			{
				taskCompletionSource.SetResult(new ValueTuple<IGoogleBillingResult, IEnumerable<AndroidJavaObject>>(new GoogleBillingResult(null), new List<AndroidJavaObject>()));
			}
			else
			{
				this.m_BillingClient.QueryProductDetailsAsync(productList, type, delegate(IGoogleBillingResult billingResult, List<AndroidJavaObject> productDetails)
				{
					taskCompletionSource.SetResult(new ValueTuple<IGoogleBillingResult, IEnumerable<AndroidJavaObject>>(billingResult, productDetails));
				});
			}
			return taskCompletionSource.Task;
		}

		// Token: 0x04000046 RID: 70
		private readonly IGoogleBillingClient m_BillingClient;

		// Token: 0x04000047 RID: 71
		private readonly IGoogleCachedQueryProductDetailsService m_GoogleCachedQueryProductDetailsService;

		// Token: 0x04000048 RID: 72
		private readonly IProductDetailsConverter m_ProductDetailsConverter;
	}
}
