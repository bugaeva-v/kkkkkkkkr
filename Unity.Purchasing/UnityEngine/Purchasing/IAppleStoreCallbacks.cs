using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace UnityEngine.Purchasing
{
	// Token: 0x020000F4 RID: 244
	[NullableContext(1)]
	internal interface IAppleStoreCallbacks
	{
		// Token: 0x0600048E RID: 1166
		void SetFetchStorePromotionOrderCallbacks(Action<List<Product>> successCallback, Action<string> errorCallback);

		// Token: 0x0600048F RID: 1167
		void SetFetchStorePromotionVisibilityCallbacks(Action<string, AppleStorePromotionVisibility> successCallback, Action<string> errorCallback);

		// Token: 0x06000490 RID: 1168
		[NullableContext(2)]
		void SetRestoreTransactionsCallback(Action<bool, string> successCallback);

		// Token: 0x06000491 RID: 1169
		void ClearTransactionLog();

		// Token: 0x170000AF RID: 175
		// (get) Token: 0x06000492 RID: 1170
		// (set) Token: 0x06000493 RID: 1171
		bool simulateAskToBuy { get; set; }

		// Token: 0x06000494 RID: 1172
		void SetAppAccountToken(Guid token);

		// Token: 0x1400003B RID: 59
		// (add) Token: 0x06000495 RID: 1173
		// (remove) Token: 0x06000496 RID: 1174
		[Nullable(new byte[]
		{
			2,
			1
		})]
		event Action<Product> OnPromotionalPurchaseIntercepted;

		// Token: 0x06000497 RID: 1175
		void SetRefreshAppReceiptCallbacks(Action<string> successCallback, Action<string> errorCallback);

		// Token: 0x06000498 RID: 1176
		void SetRefreshAppReceipt(bool refreshAppReceipt);
	}
}
