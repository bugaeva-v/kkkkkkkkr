using System;
using System.Runtime.CompilerServices;

namespace UnityEngine.Purchasing
{
	// Token: 0x020000DB RID: 219
	[NullableContext(1)]
	[Nullable(0)]
	public class PurchaseFailureDescription
	{
		// Token: 0x0600044D RID: 1101 RVA: 0x0000A0D3 File Offset: 0x000082D3
		public PurchaseFailureDescription(CartItem item, PurchaseFailureReason reason, string message)
		{
			this.item = item;
			this.reason = reason;
			this.message = message;
		}

		// Token: 0x170000A1 RID: 161
		// (get) Token: 0x0600044E RID: 1102 RVA: 0x0000A0F0 File Offset: 0x000082F0
		// (set) Token: 0x0600044F RID: 1103 RVA: 0x0000A0F8 File Offset: 0x000082F8
		public CartItem item { get; private set; }

		// Token: 0x170000A2 RID: 162
		// (get) Token: 0x06000450 RID: 1104 RVA: 0x0000A101 File Offset: 0x00008301
		[Obsolete("Use item.Product instead")]
		public Product product
		{
			get
			{
				return this.item.Product;
			}
		}

		// Token: 0x170000A3 RID: 163
		// (get) Token: 0x06000451 RID: 1105 RVA: 0x0000A10E File Offset: 0x0000830E
		// (set) Token: 0x06000452 RID: 1106 RVA: 0x0000A116 File Offset: 0x00008316
		public PurchaseFailureReason reason { get; private set; }

		// Token: 0x170000A4 RID: 164
		// (get) Token: 0x06000453 RID: 1107 RVA: 0x0000A11F File Offset: 0x0000831F
		// (set) Token: 0x06000454 RID: 1108 RVA: 0x0000A127 File Offset: 0x00008327
		public string message { get; private set; }

		// Token: 0x06000455 RID: 1109 RVA: 0x0000A130 File Offset: 0x00008330
		internal FailedOrder ConvertToFailedOrder([Nullable(2)] string transactionId = "")
		{
			ICart cart = new Cart(this.item);
			OrderInfo info = new OrderInfo(string.Empty, transactionId, string.Empty);
			return new FailedOrder(new PendingOrder(cart, info), this.reason, this.message);
		}
	}
}
