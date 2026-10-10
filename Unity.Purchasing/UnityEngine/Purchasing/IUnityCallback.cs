using System;

namespace UnityEngine.Purchasing
{
	// Token: 0x020000ED RID: 237
	internal interface IUnityCallback
	{
		// Token: 0x0600047A RID: 1146
		void OnStoreConnectionSucceeded();

		// Token: 0x0600047B RID: 1147
		void OnStoreConnectionFailed(string jsonFailureDescription);

		// Token: 0x0600047C RID: 1148
		void OnProductsFetched(string json);

		// Token: 0x0600047D RID: 1149
		void OnProductsFetchFailed(string jsonFailureDescription);

		// Token: 0x0600047E RID: 1150
		void OnPurchasesRetrievalFailed(string jsonFailureDescription);

		// Token: 0x0600047F RID: 1151
		void OnPurchasesFetched(string json);

		// Token: 0x06000480 RID: 1152
		void OnPurchaseSucceeded(string id, string receipt, string transactionID);

		// Token: 0x06000481 RID: 1153
		void OnPurchaseFailed(string json);

		// Token: 0x06000482 RID: 1154
		void OnPurchaseDeferred(string json);
	}
}
