using System;

namespace UnityEngine.Purchasing
{
	// Token: 0x0200002E RID: 46
	internal interface IGooglePlayStoreConnectionService
	{
		// Token: 0x060000F1 RID: 241
		void Connect();

		// Token: 0x060000F2 RID: 242
		bool IsReady();

		// Token: 0x060000F3 RID: 243
		GoogleBillingConnectionState CheckConnectionState();

		// Token: 0x060000F4 RID: 244
		void SetConnectionCallback(IStoreConnectCallback storeConnectCallback);
	}
}
