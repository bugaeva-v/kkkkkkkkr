using System;
using UnityEngine;

namespace VideoGlitches
{
	// Token: 0x020000E0 RID: 224
	[ExecuteInEditMode]
	[RequireComponent(typeof(Camera))]
	[AddComponentMenu("Image Effects/Video Glitches/Video Glitch Noise Analog")]
	public sealed class VideoGlitchNoiseAnalog : ImageEffectBase
	{
		// Token: 0x1700006E RID: 110
		// (get) Token: 0x060021AB RID: 8619 RVA: 0x000EBEA7 File Offset: 0x000EA0A7
		protected override string AAALPPMCHPA
		{
			get
			{
				return "Shaders/VideoGlitchNoiseAnalog";
			}
		}

		// Token: 0x060021AC RID: 8620 RVA: 0x000EBEAE File Offset: 0x000EA0AE
		protected override void OFLNJNCBAHK()
		{
			base.AGBEEEFAAHO.SetFloat("_Threshold", this.threshold);
			base.OFLNJNCBAHK();
		}

		// Token: 0x060021AD RID: 8621 RVA: 0x000EBECC File Offset: 0x000EA0CC
		public override void ResetDefaultValues()
		{
			this.threshold = 0.1f;
			base.ResetDefaultValues();
		}

		// Token: 0x04000975 RID: 2421
		public float threshold = 0.1f;

		// Token: 0x04000976 RID: 2422
		private const string LEOPHFFEFFA = "_Threshold";
	}
}
