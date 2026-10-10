using System;
using UnityEngine;

namespace VideoGlitches
{
	// Token: 0x0200004B RID: 75
	[ExecuteInEditMode]
	[RequireComponent(typeof(Camera))]
	[AddComponentMenu("Image Effects/Video Glitches/Video Glitch Old Tape")]
	public sealed class VideoGlitchOldTape : ImageEffectBase
	{
		// Token: 0x06000A5E RID: 2654 RVA: 0x0004D5B8 File Offset: 0x0004B7B8
		protected override void OFLNJNCBAHK()
		{
			base.AGBEEEFAAHO.SetFloat("_NoiseSpeed", this.noiseSpeed / 100000f);
			base.AGBEEEFAAHO.SetFloat("_NoiseAmplitude", (101f - this.noiseAmplitude) * 1000f);
			base.OFLNJNCBAHK();
		}

		// Token: 0x1700001D RID: 29
		// (get) Token: 0x06000A60 RID: 2656 RVA: 0x0004D627 File Offset: 0x0004B827
		protected override string AAALPPMCHPA
		{
			get
			{
				return "Shaders/VideoGlitchOldTape";
			}
		}

		// Token: 0x06000A61 RID: 2657 RVA: 0x0004D62E File Offset: 0x0004B82E
		public override void ResetDefaultValues()
		{
			this.noiseSpeed = 100f;
			this.noiseAmplitude = 1f;
			base.ResetDefaultValues();
		}

		// Token: 0x04000359 RID: 857
		public float noiseSpeed = 100f;

		// Token: 0x0400035A RID: 858
		public float noiseAmplitude = 1f;

		// Token: 0x0400035B RID: 859
		private const string HLMHPFDMHFA = "_NoiseSpeed";

		// Token: 0x0400035C RID: 860
		private const string IJCCCJJEBJH = "_NoiseAmplitude";
	}
}
