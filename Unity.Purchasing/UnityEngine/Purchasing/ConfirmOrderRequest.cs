using System;

namespace UnityEngine.Purchasing
{
	// Token: 0x0200004C RID: 76
	internal class ConfirmOrderRequest
	{
		// Token: 0x1700001F RID: 31
		// (get) Token: 0x06000141 RID: 321 RVA: 0x00003A9B File Offset: 0x00001C9B
		internal PendingOrder OrderToConfirm { get; }

		// Token: 0x17000020 RID: 32
		// (get) Token: 0x06000142 RID: 322 RVA: 0x00003AA3 File Offset: 0x00001CA3
		internal Action<PendingOrder, Order> Action { get; }

		// Token: 0x06000143 RID: 323 RVA: 0x00003AAB File Offset: 0x00001CAB
		internal ConfirmOrderRequest(PendingOrder order, Action<PendingOrder, Order> purchaseSuccessAction)
		{
			this.OrderToConfirm = order;
			this.Action = purchaseSuccessAction;
		}
	}
}
