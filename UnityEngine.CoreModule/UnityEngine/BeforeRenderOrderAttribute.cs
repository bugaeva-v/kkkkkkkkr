using System;

namespace UnityEngine
{
	// Token: 0x0200011E RID: 286
	[AttributeUsage(AttributeTargets.Method)]
	public class BeforeRenderOrderAttribute : Attribute
	{
		// Token: 0x170001BF RID: 447
		// (get) Token: 0x060007D3 RID: 2003 RVA: 0x0000BB77 File Offset: 0x00009D77
		// (set) Token: 0x060007D4 RID: 2004 RVA: 0x0000BB7F File Offset: 0x00009D7F
		public int order { get; private set; }

		// Token: 0x060007D5 RID: 2005 RVA: 0x0000BB88 File Offset: 0x00009D88
		public BeforeRenderOrderAttribute(int order)
		{
			this.order = order;
		}
	}
}
