using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using UnityEngine.Purchasing.Exceptions;
using UnityEngine.Purchasing.Extension;
using UnityEngine.Purchasing.Models;

namespace UnityEngine.Purchasing.Interfaces
{
	// Token: 0x02000125 RID: 293
	[NullableContext(1)]
	internal interface IGooglePlayStoreService
	{
		// Token: 0x06000525 RID: 1317
		void FetchProducts(IReadOnlyCollection<ProductDefinition> products, Action<List<ProductDescription>> onProductsReceived, Action<GoogleFetchProductException> onFetchProductsFailed);

		// Token: 0x06000526 RID: 1318
		void Purchase(ProductDefinition product);

		// Token: 0x06000527 RID: 1319
		void Purchase(ProductDefinition product, [Nullable(2)] Order currentOrder, GooglePlayReplacementMode? desiredReplacementMode);

		// Token: 0x06000528 RID: 1320
		Task FinishTransaction([Nullable(2)] ProductDefinition product, [Nullable(2)] string purchaseToken, Action<IGoogleBillingResult, IGooglePurchase> onTransactionFinished);

		// Token: 0x06000529 RID: 1321
		void FetchPurchases(Action<List<IGooglePurchase>> onQueryPurchaseSucceed, [Nullable(new byte[]
		{
			1,
			2
		})] Action<string> onQueryPurchaseFailed);

		// Token: 0x0600052A RID: 1322
		void CheckEntitlement(ProductDefinition product, Action<ProductDefinition, EntitlementStatus> onEntitlementChecked);

		// Token: 0x0600052B RID: 1323
		void SetObfuscatedAccountId(string obfuscatedAccountId);

		// Token: 0x0600052C RID: 1324
		void SetObfuscatedProfileId(string obfuscatedProfileId);

		// Token: 0x0600052D RID: 1325
		bool IsConnectionReady();
	}
}
