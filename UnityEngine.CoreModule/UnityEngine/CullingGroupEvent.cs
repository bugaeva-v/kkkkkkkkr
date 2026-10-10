using System;

namespace UnityEngine
{
	// Token: 0x02000102 RID: 258
	public struct CullingGroupEvent
	{
		// Token: 0x17000132 RID: 306
		// (get) Token: 0x060005AF RID: 1455 RVA: 0x00008010 File Offset: 0x00006210
		public int index
		{
			get
			{
				return this.m_Index;
			}
		}

		// Token: 0x17000133 RID: 307
		// (get) Token: 0x060005B0 RID: 1456 RVA: 0x00008028 File Offset: 0x00006228
		public bool isVisible
		{
			get
			{
				return (this.m_ThisState & 128) > 0;
			}
		}

		// Token: 0x17000134 RID: 308
		// (get) Token: 0x060005B1 RID: 1457 RVA: 0x0000804C File Offset: 0x0000624C
		public bool wasVisible
		{
			get
			{
				return (this.m_PrevState & 128) > 0;
			}
		}

		// Token: 0x17000135 RID: 309
		// (get) Token: 0x060005B2 RID: 1458 RVA: 0x00008070 File Offset: 0x00006270
		public bool hasBecomeVisible
		{
			get
			{
				return this.isVisible && !this.wasVisible;
			}
		}

		// Token: 0x17000136 RID: 310
		// (get) Token: 0x060005B3 RID: 1459 RVA: 0x00008098 File Offset: 0x00006298
		public bool hasBecomeInvisible
		{
			get
			{
				return !this.isVisible && this.wasVisible;
			}
		}

		// Token: 0x17000137 RID: 311
		// (get) Token: 0x060005B4 RID: 1460 RVA: 0x000080BC File Offset: 0x000062BC
		public int currentDistance
		{
			get
			{
				return (int)(this.m_ThisState & 127);
			}
		}

		// Token: 0x17000138 RID: 312
		// (get) Token: 0x060005B5 RID: 1461 RVA: 0x000080D8 File Offset: 0x000062D8
		public int previousDistance
		{
			get
			{
				return (int)(this.m_PrevState & 127);
			}
		}

		// Token: 0x0400036D RID: 877
		private int m_Index;

		// Token: 0x0400036E RID: 878
		private byte m_PrevState;

		// Token: 0x0400036F RID: 879
		private byte m_ThisState;

		// Token: 0x04000370 RID: 880
		private const byte kIsVisibleMask = 128;

		// Token: 0x04000371 RID: 881
		private const byte kDistanceMask = 127;
	}
}
