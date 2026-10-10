using System;
using System.Collections.Generic;

namespace UnityEngine.Purchasing
{
	// Token: 0x02000059 RID: 89
	public class Orders
	{
		// Token: 0x0600017D RID: 381 RVA: 0x00003CEA File Offset: 0x00001EEA
		public Orders(IReadOnlyList<ConfirmedOrder> confirmedOrders, IReadOnlyList<PendingOrder> pendingOrders, IReadOnlyList<DeferredOrder> deferredOrders)
		{
			this.ConfirmedOrders = confirmedOrders;
			this.PendingOrders = pendingOrders;
			this.DeferredOrders = deferredOrders;
		}

		// Token: 0x17000041 RID: 65
		// (get) Token: 0x0600017E RID: 382 RVA: 0x00003D07 File Offset: 0x00001F07
		public IReadOnlyList<ConfirmedOrder> ConfirmedOrders { get; }

		// Token: 0x17000042 RID: 66
		// (get) Token: 0x0600017F RID: 383 RVA: 0x00003D0F File Offset: 0x00001F0F
		public IReadOnlyList<PendingOrder> PendingOrders { get; }

		// Token: 0x17000043 RID: 67
		// (get) Token: 0x06000180 RID: 384 RVA: 0x00003D17 File Offset: 0x00001F17
		public IReadOnlyList<DeferredOrder> DeferredOrders { get; }
	}
}
