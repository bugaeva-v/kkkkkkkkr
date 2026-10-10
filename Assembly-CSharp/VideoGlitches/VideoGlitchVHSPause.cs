using System;
using UnityEngine;

namespace VideoGlitches
{
	// Token: 0x020002F5 RID: 757
	[ExecuteInEditMode]
	[RequireComponent(typeof(Camera))]
	[AddComponentMenu("Image Effects/Video Glitches/Video Glitch VHS Pause")]
	public sealed class VideoGlitchVHSPause : ImageEffectBase
	{
		// Token: 0x170001C8 RID: 456
		// (get) Token: 0x06005CDC RID: 23772 RVA: 0x002A4498 File Offset: 0x002A2698
		protected override string AAALPPMCHPA
		{
			get
			{
				return "Shaders/VideoGlitchVHSPause";
			}
		}

		// Token: 0x06005CDD RID: 23773 RVA: 0x002A44A0 File Offset: 0x002A26A0
		protected override void OFLNJNCBAHK()
		{
			base.AGBEEEFAAHO.SetFloat("_Strength", this.strength);
			base.AGBEEEFAAHO.SetFloat("_ColorNoise", this.colorNoise);
			base.AGBEEEFAAHO.SetColor("_NoiseColor", this.noiseColor);
			base.OFLNJNCBAHK();
		}

		// Token: 0x06005CDE RID: 23774 RVA: 0x002A44F5 File Offset: 0x002A26F5
		public override void ResetDefaultValues()
		{
			this.strength = 1f;
			this.colorNoise = 0.1f;
			this.noiseColor = Color.white;
			base.ResetDefaultValues();
		}

		// Token: 0x04001A91 RID: 6801
		public float strength = 1f;

		// Token: 0x04001A92 RID: 6802
		public float colorNoise = 0.1f;

		// Token: 0x04001A93 RID: 6803
		public Color noiseColor = Color.white;

		// Token: 0x04001A94 RID: 6804
		private const string OFNECEHMEKN = "_Strength";

		// Token: 0x04001A95 RID: 6805
		private const string NPKLGNFCAGB = "_ColorNoise";

		// Token: 0x04001A96 RID: 6806
		private const string PHEGOIAFCIP = "_NoiseColor";
	}
}
