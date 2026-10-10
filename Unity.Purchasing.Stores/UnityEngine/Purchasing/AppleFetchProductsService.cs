using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using UnityEngine.Purchasing.Exceptions;
using UnityEngine.Purchasing.Extension;
using UnityEngine.Scripting;

namespace UnityEngine.Purchasing
{
	// Token: 0x02000033 RID: 51
	[NullableContext(1)]
	[Nullable(0)]
	[Preserve]
	internal class AppleFetchProductsService : IAppleFetchProductsService
	{
		// Token: 0x17000007 RID: 7
		// (get) Token: 0x06000100 RID: 256 RVA: 0x00004CB8 File Offset: 0x00002EB8
		// (set) Token: 0x06000101 RID: 257 RVA: 0x00004CC0 File Offset: 0x00002EC0
		[Nullable(2)]
		public string LastRequestProductsJson { [NullableContext(2)] get; [NullableContext(2)] private set; }

		// Token: 0x06000102 RID: 258 RVA: 0x00004CC9 File Offset: 0x00002EC9
		public void SetNativeStore(INativeAppleStore nativeStore)
		{
			this.m_NativeStore = nativeStore;
		}

		// Token: 0x06000103 RID: 259 RVA: 0x00004CD4 File Offset: 0x00002ED4
		public virtual Task<List<ProductDescription>> FetchProducts(IReadOnlyCollection<ProductDefinition> products)
		{
			this.ValidateThatRequestIsPossible();
			return this.queue.Enqueue<List<ProductDescription>>(() => this.ExecuteFetchProductsRequest(products));
		}

		// Token: 0x06000104 RID: 260 RVA: 0x00004D12 File Offset: 0x00002F12
		private void ValidateThatRequestIsPossible()
		{
			if (this.m_NativeStore == null)
			{
				throw new InvalidOperationException("Cannot retrieve products because the apple native store is null.");
			}
		}

		// Token: 0x06000105 RID: 261 RVA: 0x00004D28 File Offset: 0x00002F28
		private Task<List<ProductDescription>> ExecuteFetchProductsRequest(IReadOnlyCollection<ProductDefinition> products)
		{
			AppleFetchProductsService.<ExecuteFetchProductsRequest>d__10 <ExecuteFetchProductsRequest>d__;
			<ExecuteFetchProductsRequest>d__.<>t__builder = AsyncTaskMethodBuilder<List<ProductDescription>>.Create();
			<ExecuteFetchProductsRequest>d__.<>4__this = this;
			<ExecuteFetchProductsRequest>d__.products = products;
			<ExecuteFetchProductsRequest>d__.<>1__state = -1;
			<ExecuteFetchProductsRequest>d__.<>t__builder.Start<AppleFetchProductsService.<ExecuteFetchProductsRequest>d__10>(ref <ExecuteFetchProductsRequest>d__);
			return <ExecuteFetchProductsRequest>d__.<>t__builder.Task;
		}

		// Token: 0x06000106 RID: 262 RVA: 0x00004D74 File Offset: 0x00002F74
		public void OnProductsFetched(string json)
		{
			this.LastRequestProductsJson = json;
			List<ProductDescription> result = JSONSerializer.DeserializeProductDescriptionsFromFetchProductsSk2(json);
			TaskCompletionSource<List<ProductDescription>> currentRequestCompletionSource = this.m_CurrentRequestCompletionSource;
			if (currentRequestCompletionSource == null)
			{
				return;
			}
			currentRequestCompletionSource.SetResult(result);
		}

		// Token: 0x06000107 RID: 263 RVA: 0x00004DA0 File Offset: 0x00002FA0
		public void OnProductDetailsRetrieveFailed(string errorMessage)
		{
			ProductFetchFailureDescription failureDescription = new ProductFetchFailureDescription(ProductFetchFailureReason.Unknown, "Retrieve apple product details, failed with error message: " + errorMessage, true);
			TaskCompletionSource<List<ProductDescription>> currentRequestCompletionSource = this.m_CurrentRequestCompletionSource;
			if (currentRequestCompletionSource == null)
			{
				return;
			}
			currentRequestCompletionSource.SetException(new FetchProductsException(failureDescription));
		}

		// Token: 0x0400006D RID: 109
		[Nullable(2)]
		private INativeAppleStore m_NativeStore;

		// Token: 0x0400006F RID: 111
		private readonly TaskQueue queue = new TaskQueue();

		// Token: 0x04000070 RID: 112
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private TaskCompletionSource<List<ProductDescription>> m_CurrentRequestCompletionSource;
	}
}
