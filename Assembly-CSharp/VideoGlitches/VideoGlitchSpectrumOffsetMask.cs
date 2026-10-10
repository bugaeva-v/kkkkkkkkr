using System;
using UnityEngine;

namespace VideoGlitches
{
	// Token: 0x0200020C RID: 524
	[ExecuteInEditMode]
	[RequireComponent(typeof(Camera))]
	[AddComponentMenu("Image Effects/Video Glitches/Video Glitch Spectrum Offset Mask")]
	public class VideoGlitchSpectrumOffsetMask : ImageEffectBase
	{
		// Token: 0x17000121 RID: 289
		// (get) Token: 0x0600419B RID: 16795 RVA: 0x001CAD2B File Offset: 0x001C8F2B
		protected override string AAALPPMCHPA
		{
			get
			{
				return this.shaderPath;
			}
		}

		// Token: 0x0600419C RID: 16796 RVA: 0x001CAD33 File Offset: 0x001C8F33
		public override void ResetDefaultValues()
		{
			this.strength = 0.1f;
			this.steps = 5;
			base.ResetDefaultValues();
		}

		// Token: 0x0600419D RID: 16797 RVA: 0x001CAD50 File Offset: 0x001C8F50
		protected override void OFLNJNCBAHK()
		{
			base.AGBEEEFAAHO.SetFloat("_Strength", this.strength);
			base.AGBEEEFAAHO.SetInt("_Steps", this.steps);
			base.AGBEEEFAAHO.SetTexture("_MaskTex", this.maskTexture);
			if (KHPGPLAMAIN.OHJPNPMCMBC())
			{
				base.AGBEEEFAAHO.SetFloat("_UVRemap", 1f);
			}
			else
			{
				base.AGBEEEFAAHO.SetFloat("_UVRemap", 0f);
			}
			base.OFLNJNCBAHK();
		}

		// Token: 0x0400125F RID: 4703
		public Texture2D maskTexture;

		// Token: 0x04001260 RID: 4704
		private const string FLOACGDAFCE = "_MaskTex";

		// Token: 0x04001261 RID: 4705
		public float strength = 0.1f;

		// Token: 0x04001262 RID: 4706
		public int steps = 5;

		// Token: 0x04001263 RID: 4707
		private const string OFNECEHMEKN = "_Strength";

		// Token: 0x04001264 RID: 4708
		private const string CBBKOOCLCIK = "_UVRemap";

		// Token: 0x04001265 RID: 4709
		private const string JCKGGHEMDLA = "_Steps";

		// Token: 0x04001266 RID: 4710
		public string shaderPath = "Shaders/VideoGlitchSpectrumOffsetMask";
	}
}
