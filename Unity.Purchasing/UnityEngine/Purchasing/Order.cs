using System;
using System.Runtime.CompilerServices;

namespace UnityEngine.Purchasing
{
	// Token: 0x02000057 RID: 87
	[NullableContext(1)]
	[Nullable(0)]
	public abstract class Order
	{
		// Token: 0x1700003A RID: 58
		// (get) Token: 0x0600016E RID: 366 RVA: 0x00003BD9 File Offset: 0x00001DD9
		// (set) Token: 0x0600016F RID: 367 RVA: 0x00003BE1 File Offset: 0x00001DE1
		public ICart CartOrdered { get; internal set; }

		// Token: 0x1700003B RID: 59
		// (get) Token: 0x06000170 RID: 368 RVA: 0x00003BEA File Offset: 0x00001DEA
		public IOrderInfo Info { get; }

		// Token: 0x06000171 RID: 369 RVA: 0x00003BF2 File Offset: 0x00001DF2
		protected Order(ICart cart, IOrderInfo info)
		{
			this.CartOrdered = cart;
			this.Info = info;
		}
	}
}
