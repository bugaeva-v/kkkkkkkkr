using System;
using System.Runtime.CompilerServices;

namespace UnityEngine.Purchasing
{
	// Token: 0x02000051 RID: 81
	[NullableContext(1)]
	[Nullable(0)]
	public class FailedOrder : Order
	{
		// Token: 0x17000027 RID: 39
		// (get) Token: 0x0600014E RID: 334 RVA: 0x00003B3F File Offset: 0x00001D3F
		public PurchaseFailureReason FailureReason
		{
			get
			{
				return this.m_FailureReason;
			}
		}

		// Token: 0x17000028 RID: 40
		// (get) Token: 0x0600014F RID: 335 RVA: 0x00003B47 File Offset: 0x00001D47
		public string Details
		{
			get
			{
				return this.m_Details;
			}
		}

		// Token: 0x06000150 RID: 336 RVA: 0x00003B4F File Offset: 0x00001D4F
		public FailedOrder(ICart cart, PurchaseFailureReason reason, string details) : base(cart, new OrderInfo(string.Empty, string.Empty, string.Empty))
		{
			this.m_FailureReason = reason;
			this.m_Details = details;
		}

		// Token: 0x06000151 RID: 337 RVA: 0x00003B7A File Offset: 0x00001D7A
		public FailedOrder(Order order, PurchaseFailureReason reason, string details) : base(order.CartOrdered, order.Info)
		{
			this.m_FailureReason = reason;
			this.m_Details = details;
		}

		// Token: 0x0400004D RID: 77
		private PurchaseFailureReason m_FailureReason;

		// Token: 0x0400004E RID: 78
		private string m_Details;
	}
}
