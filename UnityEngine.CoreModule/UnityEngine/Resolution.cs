using System;
using UnityEngine.Scripting;

namespace UnityEngine
{
	// Token: 0x02000138 RID: 312
	[RequiredByNativeCode]
	public struct Resolution
	{
		// Token: 0x1700020F RID: 527
		// (get) Token: 0x060009E4 RID: 2532 RVA: 0x0000EDB4 File Offset: 0x0000CFB4
		// (set) Token: 0x060009E5 RID: 2533 RVA: 0x0000EDCC File Offset: 0x0000CFCC
		public int width
		{
			get
			{
				return this.m_Width;
			}
			set
			{
				this.m_Width = value;
			}
		}

		// Token: 0x17000210 RID: 528
		// (get) Token: 0x060009E6 RID: 2534 RVA: 0x0000EDD8 File Offset: 0x0000CFD8
		// (set) Token: 0x060009E7 RID: 2535 RVA: 0x0000EDF0 File Offset: 0x0000CFF0
		public int height
		{
			get
			{
				return this.m_Height;
			}
			set
			{
				this.m_Height = value;
			}
		}

		// Token: 0x17000211 RID: 529
		// (get) Token: 0x060009E8 RID: 2536 RVA: 0x0000EDFC File Offset: 0x0000CFFC
		// (set) Token: 0x060009E9 RID: 2537 RVA: 0x0000EE14 File Offset: 0x0000D014
		public int refreshRate
		{
			get
			{
				return this.m_RefreshRate;
			}
			set
			{
				this.m_RefreshRate = value;
			}
		}

		// Token: 0x060009EA RID: 2538 RVA: 0x0000EE20 File Offset: 0x0000D020
		public override string ToString()
		{
			return UnityString.Format("{0} x {1} @ {2}Hz", new object[]
			{
				this.m_Width,
				this.m_Height,
				this.m_RefreshRate
			});
		}

		// Token: 0x040003E5 RID: 997
		private int m_Width;

		// Token: 0x040003E6 RID: 998
		private int m_Height;

		// Token: 0x040003E7 RID: 999
		private int m_RefreshRate;
	}
}
