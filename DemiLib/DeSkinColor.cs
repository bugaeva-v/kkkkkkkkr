using System;
using DG.DemiLib.Core;
using UnityEngine;

namespace DG.DemiLib
{
	// Token: 0x02000007 RID: 7
	[Serializable]
	public struct DeSkinColor
	{
		// Token: 0x0600000B RID: 11 RVA: 0x0000250C File Offset: 0x0000070C
		public DeSkinColor(Color free, Color pro)
		{
			this.free = free;
			this.pro = pro;
		}

		// Token: 0x0600000C RID: 12 RVA: 0x0000251C File Offset: 0x0000071C
		public DeSkinColor(float freeGradation, float proGradation)
		{
			this.free = new Color(freeGradation, freeGradation, freeGradation, 1f);
			this.pro = new Color(proGradation, proGradation, proGradation, 1f);
		}

		// Token: 0x0600000D RID: 13 RVA: 0x00002544 File Offset: 0x00000744
		public DeSkinColor(Color color)
		{
			this = default(DeSkinColor);
			this.free = color;
			this.pro = color;
		}

		// Token: 0x0600000E RID: 14 RVA: 0x0000255B File Offset: 0x0000075B
		public DeSkinColor(float gradation)
		{
			this = default(DeSkinColor);
			this.free = new Color(gradation, gradation, gradation, 1f);
			this.pro = this.free;
		}

		// Token: 0x0600000F RID: 15 RVA: 0x00002583 File Offset: 0x00000783
		public static implicit operator Color(DeSkinColor v)
		{
			if (!GUIUtils.isProSkin)
			{
				return v.free;
			}
			return v.pro;
		}

		// Token: 0x06000010 RID: 16 RVA: 0x00002599 File Offset: 0x00000799
		public static implicit operator DeSkinColor(Color v)
		{
			return new DeSkinColor(v);
		}

		// Token: 0x06000011 RID: 17 RVA: 0x000025A1 File Offset: 0x000007A1
		public override string ToString()
		{
			return string.Format("{0}, {1}", this.free, this.pro);
		}

		// Token: 0x04000016 RID: 22
		public Color free;

		// Token: 0x04000017 RID: 23
		public Color pro;
	}
}
