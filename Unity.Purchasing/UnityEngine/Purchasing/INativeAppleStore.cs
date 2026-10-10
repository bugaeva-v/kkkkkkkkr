using System;

namespace UnityEngine.Purchasing
{
	// Token: 0x020000F5 RID: 245
	internal interface INativeAppleStore : INativeStore
	{
		// Token: 0x06000499 RID: 1177
		void SetUnityPurchasingCallback(UnityPurchasingCallback asyncCallback);

		// Token: 0x0600049A RID: 1178
		void RestoreTransactions();

		// Token: 0x0600049B RID: 1179
		void AddTransactionObserver();

		// Token: 0x0600049C RID: 1180
		string AppReceipt();

		// Token: 0x170000B0 RID: 176
		// (get) Token: 0x0600049D RID: 1181
		bool canMakePayments { get; }

		// Token: 0x0600049E RID: 1182
		void FetchStorePromotionOrder();

		// Token: 0x0600049F RID: 1183
		void SetStorePromotionOrder(string json);

		// Token: 0x060004A0 RID: 1184
		void FetchStorePromotionVisibility(string productId);

		// Token: 0x060004A1 RID: 1185
		void SetStorePromotionVisibility(string productId, string visibility);

		// Token: 0x060004A2 RID: 1186
		void InterceptPromotionalPurchases();

		// Token: 0x060004A3 RID: 1187
		void ContinuePromotionalPurchases();

		// Token: 0x060004A4 RID: 1188
		void PresentCodeRedemptionSheet();

		// Token: 0x060004A5 RID: 1189
		void DeallocateMemory(IntPtr pointer);

		// Token: 0x060004A6 RID: 1190
		void RefreshAppReceipt();
	}
}
