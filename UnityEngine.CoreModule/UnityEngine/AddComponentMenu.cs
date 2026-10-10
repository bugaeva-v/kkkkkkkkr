using System;

namespace UnityEngine
{
	// Token: 0x020001F1 RID: 497
	public sealed class AddComponentMenu : Attribute
	{
		// Token: 0x0600165F RID: 5727 RVA: 0x00023ECA File Offset: 0x000220CA
		public AddComponentMenu(string menuName)
		{
			this.m_AddComponentMenu = menuName;
			this.m_Ordering = 0;
		}

		// Token: 0x06001660 RID: 5728 RVA: 0x00023EE2 File Offset: 0x000220E2
		public AddComponentMenu(string menuName, int order)
		{
			this.m_AddComponentMenu = menuName;
			this.m_Ordering = order;
		}

		// Token: 0x1700046A RID: 1130
		// (get) Token: 0x06001661 RID: 5729 RVA: 0x00023EFC File Offset: 0x000220FC
		public string componentMenu
		{
			get
			{
				return this.m_AddComponentMenu;
			}
		}

		// Token: 0x1700046B RID: 1131
		// (get) Token: 0x06001662 RID: 5730 RVA: 0x00023F14 File Offset: 0x00022114
		public int componentOrder
		{
			get
			{
				return this.m_Ordering;
			}
		}

		// Token: 0x040007D3 RID: 2003
		private string m_AddComponentMenu;

		// Token: 0x040007D4 RID: 2004
		private int m_Ordering;
	}
}
