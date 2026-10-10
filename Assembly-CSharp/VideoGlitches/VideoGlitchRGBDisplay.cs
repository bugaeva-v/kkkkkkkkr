using System;
using UnityEngine;

namespace VideoGlitches
{
	// Token: 0x020003D6 RID: 982
	[ExecuteInEditMode]
	[RequireComponent(typeof(Camera))]
	[AddComponentMenu("Image Effects/Video Glitches/Video Glitch RGB Display")]
	public sealed class VideoGlitchRGBDisplay : ImageEffectBase
	{
		// Token: 0x0600722F RID: 29231 RVA: 0x00334AC3 File Offset: 0x00332CC3
		public override void ResetDefaultValues()
		{
			this.cellSize = 2;
			base.ResetDefaultValues();
		}

		// Token: 0x06007230 RID: 29232 RVA: 0x00334AD2 File Offset: 0x00332CD2
		protected override void OFLNJNCBAHK()
		{
			base.AGBEEEFAAHO.SetInt("_CellSize", this.cellSize * 3);
			base.OFLNJNCBAHK();
		}

		// Token: 0x17000246 RID: 582
		// (get) Token: 0x06007232 RID: 29234 RVA: 0x00334B01 File Offset: 0x00332D01
		protected override string AAALPPMCHPA
		{
			get
			{
				return "Shaders/VideoGlitchRGBDisplay";
			}
		}

		// Token: 0x040021FA RID: 8698
		public int cellSize = 2;

		// Token: 0x040021FB RID: 8699
		private const string DCCGKJCGBGJ = "_CellSize";
	}
}
