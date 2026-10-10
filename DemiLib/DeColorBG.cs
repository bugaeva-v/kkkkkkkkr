using System;
using UnityEngine;

namespace DG.DemiLib
{
	// Token: 0x02000004 RID: 4
	[Serializable]
	public class DeColorBG
	{
		// Token: 0x0400000C RID: 12
		public DeSkinColor def = Color.white;

		// Token: 0x0400000D RID: 13
		public DeSkinColor critical = new DeSkinColor(new Color(0.9411765f, 0.2388736f, 0.006920422f, 1f), new Color(1f, 0.2482758f, 0f, 1f));

		// Token: 0x0400000E RID: 14
		public DeSkinColor divider = new DeSkinColor(0.6f, 0.3f);

		// Token: 0x0400000F RID: 15
		public DeSkinColor toggleOn = new DeSkinColor(new Color(0.3158468f, 0.875f, 0.1351103f, 1f), new Color(0.2183823f, 0.7279412f, 0.09099264f, 1f));

		// Token: 0x04000010 RID: 16
		public DeSkinColor toggleOff = new DeSkinColor(0.75f, 0.4f);
	}
}
