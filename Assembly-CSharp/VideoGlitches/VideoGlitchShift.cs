using System;
using UnityEngine;

namespace VideoGlitches
{
	// Token: 0x02000503 RID: 1283
	[ExecuteInEditMode]
	[RequireComponent(typeof(Camera))]
	[AddComponentMenu("Image Effects/Video Glitches/Video Glitch Shift")]
	public sealed class VideoGlitchShift : ImageEffectBase
	{
		// Token: 0x06009AD1 RID: 39633 RVA: 0x0042C0E8 File Offset: 0x0042A2E8
		protected override void OFLNJNCBAHK()
		{
			base.AGBEEEFAAHO.SetFloat("_Amplitude", this.amplitude);
			base.AGBEEEFAAHO.SetFloat("_Speed", this.speed);
			base.AGBEEEFAAHO.SetTexture("_NoiseTex", this.HBFCDCBFKEM);
			base.OFLNJNCBAHK();
		}

		// Token: 0x06009AD2 RID: 39634 RVA: 0x0042C13D File Offset: 0x0042A33D
		protected override void KFPOHAACMJE()
		{
			this.HBFCDCBFKEM = GLOGAPILDIE.CEKHELIGCOM("Textures/Noise256");
			base.KFPOHAACMJE();
		}

		// Token: 0x170002DA RID: 730
		// (get) Token: 0x06009AD3 RID: 39635 RVA: 0x0042C155 File Offset: 0x0042A355
		protected override string AAALPPMCHPA
		{
			get
			{
				return "Shaders/VideoGlitchShift";
			}
		}

		// Token: 0x06009AD4 RID: 39636 RVA: 0x0042C15C File Offset: 0x0042A35C
		public override void ResetDefaultValues()
		{
			this.amplitude = 0.1f;
			this.speed = 0.02f;
			base.ResetDefaultValues();
		}

		// Token: 0x04002AC0 RID: 10944
		public float amplitude = 0.1f;

		// Token: 0x04002AC1 RID: 10945
		public float speed = 0.02f;

		// Token: 0x04002AC2 RID: 10946
		private Texture HBFCDCBFKEM;

		// Token: 0x04002AC3 RID: 10947
		private const string HNIDNCGAJLH = "_NoiseTex";

		// Token: 0x04002AC4 RID: 10948
		private const string BHMJNNFDEFA = "_Amplitude";

		// Token: 0x04002AC5 RID: 10949
		private const string MJJBFMAJODH = "_Speed";
	}
}
