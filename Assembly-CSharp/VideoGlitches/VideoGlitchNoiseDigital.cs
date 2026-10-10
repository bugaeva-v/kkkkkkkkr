using System;
using UnityEngine;

namespace VideoGlitches
{
	// Token: 0x02000137 RID: 311
	[ExecuteInEditMode]
	[AddComponentMenu("Image Effects/Video Glitches/Video Glitch Noise Digital")]
	[RequireComponent(typeof(Camera))]
	public sealed class VideoGlitchNoiseDigital : ImageEffectBase
	{
		// Token: 0x06002925 RID: 10533 RVA: 0x001273ED File Offset: 0x001255ED
		public override void ResetDefaultValues()
		{
			this.threshold = 0.1f;
			this.maxOffset = 0.1f;
			this.thresholdYUV = 0.5f;
			base.ResetDefaultValues();
		}

		// Token: 0x170000CF RID: 207
		// (get) Token: 0x06002927 RID: 10535 RVA: 0x0012743F File Offset: 0x0012563F
		protected override string AAALPPMCHPA
		{
			get
			{
				return "Shaders/VideoGlitchNoiseDigital";
			}
		}

		// Token: 0x06002928 RID: 10536 RVA: 0x00127448 File Offset: 0x00125648
		protected override void OFLNJNCBAHK()
		{
			base.AGBEEEFAAHO.SetFloat("_Threshold", this.threshold);
			base.AGBEEEFAAHO.SetFloat("_MaxOffset", this.maxOffset);
			base.AGBEEEFAAHO.SetFloat("_ThresholdYUV", this.thresholdYUV);
			base.OFLNJNCBAHK();
		}

		// Token: 0x04000C96 RID: 3222
		public float threshold = 0.1f;

		// Token: 0x04000C97 RID: 3223
		public float maxOffset = 0.1f;

		// Token: 0x04000C98 RID: 3224
		public float thresholdYUV = 0.5f;

		// Token: 0x04000C99 RID: 3225
		private const string LEOPHFFEFFA = "_Threshold";

		// Token: 0x04000C9A RID: 3226
		private const string DGPHCBBKLMA = "_MaxOffset";

		// Token: 0x04000C9B RID: 3227
		private const string AILJDLCKJDN = "_ThresholdYUV";
	}
}
