using System;

namespace UnityEngine.Purchasing
{
	// Token: 0x020000F9 RID: 249
	public interface INativeStore
	{
		// Token: 0x060004A8 RID: 1192
		void Connect();

		// Token: 0x060004A9 RID: 1193
		void FetchProducts(string json);

		// Token: 0x060004AA RID: 1194
		void FetchExistingPurchases();

		// Token: 0x060004AB RID: 1195
		void Purchase(string productJson, string optionsJson);

		// Token: 0x060004AC RID: 1196
		void FinishTransaction(string productJSON, string transactionID);

		// Token: 0x060004AD RID: 1197
		bool CheckEntitlement(string productJSON);
	}
}
