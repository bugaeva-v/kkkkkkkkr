using System;
using UnityEngine.Scripting;

namespace UnityEngine
{
	// Token: 0x020001F9 RID: 505
	[AttributeUsage(AttributeTargets.Class)]
	[UsedByNativeCode]
	public class DefaultExecutionOrder : Attribute
	{
		// Token: 0x06001674 RID: 5748 RVA: 0x00023FED File Offset: 0x000221ED
		public DefaultExecutionOrder(int order)
		{
			this.m_Order = order;
		}

		// Token: 0x17000470 RID: 1136
		// (get) Token: 0x06001675 RID: 5749 RVA: 0x00024000 File Offset: 0x00022200
		public int order
		{
			get
			{
				return this.m_Order;
			}
		}

		// Token: 0x040007DE RID: 2014
		private int m_Order;
	}
}
