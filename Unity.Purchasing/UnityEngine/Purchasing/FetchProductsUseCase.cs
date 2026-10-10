using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Runtime.CompilerServices;
using UnityEngine.Purchasing.Extension;
using UnityEngine.Scripting;

namespace UnityEngine.Purchasing
{
	// Token: 0x0200001D RID: 29
	[NullableContext(1)]
	[Nullable(0)]
	internal class FetchProductsUseCase : IFetchProductsUseCase, IStoreProductsCallback
	{
		// Token: 0x06000071 RID: 113 RVA: 0x000029C0 File Offset: 0x00000BC0
		[Preserve]
		internal FetchProductsUseCase(IStore storeResponsible, IRetryService retryService)
		{
			this.m_Store = storeResponsible;
			this.m_RetryService = retryService;
			this.m_Store.SetProductsCallback(this);
		}

		// Token: 0x06000072 RID: 114 RVA: 0x000029E4 File Offset: 0x00000BE4
		public void FetchProducts([Nullable(new byte[]
		{
			2,
			1
		})] List<ProductDefinition> productDefinitions, [Nullable(new byte[]
		{
			1,
			2,
			1
		})] Action<List<Product>> fetchSuccessAction, [Nullable(new byte[]
		{
			1,
			2,
			1,
			1
		})] Action<List<ProductDefinition>, string> fetchFailureAction, IRetryPolicy retryPolicy)
		{
			if (this.m_ActiveRequest != null)
			{
				fetchFailureAction(productDefinitions, "FetchProducts cannot be invoked if a fetch is already in progress. Please wait for the previous call to complete");
				return;
			}
			if (productDefinitions != null && productDefinitions.Count > 0)
			{
				ReadOnlyCollection<ProductDefinition> products = new ReadOnlyCollection<ProductDefinition>(productDefinitions);
				this.ProcessValidFetchRequest(new ProductFetchRequest(products, fetchSuccessAction, fetchFailureAction), retryPolicy);
				return;
			}
			fetchFailureAction(productDefinitions, "FetchProducts required a valid list of products");
		}

		// Token: 0x06000073 RID: 115 RVA: 0x00002A38 File Offset: 0x00000C38
		private void ProcessValidFetchRequest(ProductFetchRequest request, IRetryPolicy retryPolicy)
		{
			this.m_ActiveRequest = request;
			this.m_ActiveRetryRequest = this.m_RetryService.CreateRequest(delegate
			{
				this.m_Store.FetchProducts(request.RequestedProducts);
			}, retryPolicy);
			this.m_ActiveRetryRequest.Invoke();
		}

		// Token: 0x06000074 RID: 116 RVA: 0x00002A8F File Offset: 0x00000C8F
		public void OnProductsFetched(IReadOnlyList<ProductDescription> products)
		{
			if (this.m_ActiveRequest != null)
			{
				this.ProcessFetchedProductsAndInvokeCallbacks(this.m_ActiveRequest, products);
			}
		}

		// Token: 0x06000075 RID: 117 RVA: 0x00002AA8 File Offset: 0x00000CA8
		private void ProcessFetchedProductsAndInvokeCallbacks(ProductFetchRequest request, IReadOnlyList<ProductDescription> productsRetrieved)
		{
			List<ProductDefinition> list = new List<ProductDefinition>();
			List<Product> list2 = new List<Product>();
			foreach (ProductDescription description in productsRetrieved)
			{
				ProductDefinition matchingDefinition = this.GetMatchingDefinition(description);
				if (matchingDefinition != null)
				{
					list.Add(matchingDefinition);
					list2.Add(this.CreateMatchedProduct(matchingDefinition, description));
				}
			}
			ProductFetchRequest activeRequest = this.m_ActiveRequest;
			Action<List<Product>> successCallback = (activeRequest != null) ? activeRequest.SuccessAction : null;
			this.m_ActiveRequest = null;
			FetchProductsUseCase.InvokeSuccessIfFetchedProducts(list2, successCallback);
			FetchProductsUseCase.InvokeFailureIfIncomplete(request, list);
		}

		// Token: 0x06000076 RID: 118 RVA: 0x00002B44 File Offset: 0x00000D44
		[return: Nullable(2)]
		private ProductDefinition GetMatchingDefinition(ProductDescription description)
		{
			ProductFetchRequest activeRequest = this.m_ActiveRequest;
			if (activeRequest == null)
			{
				return null;
			}
			return activeRequest.RequestedProducts.FirstOrDefault((ProductDefinition definition) => definition.storeSpecificId == description.storeSpecificId);
		}

		// Token: 0x06000077 RID: 119 RVA: 0x00002B80 File Offset: 0x00000D80
		private Product CreateMatchedProduct(ProductDefinition definition, ProductDescription description)
		{
			return new Product(definition, description.metadata)
			{
				availableToPurchase = true
			};
		}

		// Token: 0x06000078 RID: 120 RVA: 0x00002B95 File Offset: 0x00000D95
		private static void InvokeSuccessIfFetchedProducts(List<Product> fetchedProducts, [Nullable(new byte[]
		{
			2,
			1,
			1
		})] Action<List<Product>> successCallback)
		{
			if (fetchedProducts.Count > 0 && successCallback != null)
			{
				successCallback(fetchedProducts);
			}
		}

		// Token: 0x06000079 RID: 121 RVA: 0x00002BAC File Offset: 0x00000DAC
		private static void InvokeFailureIfIncomplete(ProductFetchRequest request, List<ProductDefinition> matchedDefinitions)
		{
			List<ProductDefinition> list = (from def in request.RequestedProducts
			where !matchedDefinitions.Contains(def)
			select def).ToList<ProductDefinition>();
			if (list.Any<ProductDefinition>())
			{
				if (matchedDefinitions.Count > 0)
				{
					request.FailureAction(list, "Retrieve Products succeeded, but could not retrieve the attached subset.");
					return;
				}
				request.FailureAction(list, "Retrieve Products failed, and could not retrieve any products.");
			}
		}

		// Token: 0x0600007A RID: 122 RVA: 0x00002C1C File Offset: 0x00000E1C
		public void OnProductsFetchFailed(ProductFetchFailureDescription failureDescription)
		{
			FetchProductsUseCase.<OnProductsFetchFailed>d__13 <OnProductsFetchFailed>d__;
			<OnProductsFetchFailed>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<OnProductsFetchFailed>d__.<>4__this = this;
			<OnProductsFetchFailed>d__.failureDescription = failureDescription;
			<OnProductsFetchFailed>d__.<>1__state = -1;
			<OnProductsFetchFailed>d__.<>t__builder.Start<FetchProductsUseCase.<OnProductsFetchFailed>d__13>(ref <OnProductsFetchFailed>d__);
		}

		// Token: 0x0600007B RID: 123 RVA: 0x00002C5C File Offset: 0x00000E5C
		private void SendRequestFailureCallback(ProductFetchRequest productFetchRequest, ProductFetchFailureDescription failureDescription)
		{
			string text = failureDescription.Message;
			if (string.IsNullOrEmpty(text))
			{
				text = failureDescription.Reason.ToString();
			}
			this.m_ActiveRequest = null;
			productFetchRequest.FailureAction(productFetchRequest.RequestedProducts.ToList<ProductDefinition>(), text);
		}

		// Token: 0x04000020 RID: 32
		private readonly IStore m_Store;

		// Token: 0x04000021 RID: 33
		private readonly IRetryService m_RetryService;

		// Token: 0x04000022 RID: 34
		[Nullable(2)]
		private ProductFetchRequest m_ActiveRequest;

		// Token: 0x04000023 RID: 35
		[Nullable(2)]
		private IRetryRequest m_ActiveRetryRequest;
	}
}
