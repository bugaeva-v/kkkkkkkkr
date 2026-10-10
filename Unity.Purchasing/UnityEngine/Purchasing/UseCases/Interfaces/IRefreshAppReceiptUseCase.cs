using System;

namespace UnityEngine.Purchasing.UseCases.Interfaces
{
	// Token: 0x0200014A RID: 330
	internal interface IRefreshAppReceiptUseCase
	{
		// Token: 0x060005AF RID: 1455
		void RefreshAppReceipt(Action<string> successCallback, Action<string> errorCallback);

		// Token: 0x060005B0 RID: 1456
		void SetRefreshAppReceipt(bool refreshAppReceipt);
	}
}
