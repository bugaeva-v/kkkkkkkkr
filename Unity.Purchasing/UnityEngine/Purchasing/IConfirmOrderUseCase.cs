using System;

namespace UnityEngine.Purchasing
{
	// Token: 0x02000043 RID: 67
	internal interface IConfirmOrderUseCase
	{
		// Token: 0x06000118 RID: 280
		void ConfirmOrder(PendingOrder order, Action<PendingOrder, Order> action);
	}
}
