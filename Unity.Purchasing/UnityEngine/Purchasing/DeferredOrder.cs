using System;
using System.Runtime.CompilerServices;

namespace UnityEngine.Purchasing
{
	// Token: 0x0200004D RID: 77
	public class DeferredOrder : Order
	{
		// Token: 0x06000144 RID: 324 RVA: 0x00003AC1 File Offset: 0x00001CC1
		[NullableContext(1)]
		public DeferredOrder(ICart cart, IOrderInfo info) : base(cart, info)
		{
		}
	}
}
