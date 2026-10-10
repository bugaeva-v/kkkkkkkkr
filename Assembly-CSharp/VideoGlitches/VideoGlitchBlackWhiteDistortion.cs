using System;
using UnityEngine;

namespace VideoGlitches
{
	// Token: 0x0200008D RID: 141
	[AddComponentMenu("Image Effects/Video Glitches/Video Glitch Black and White Distortion")]
	[ExecuteInEditMode]
	[RequireComponent(typeof(Camera))]
	public sealed class VideoGlitchBlackWhiteDistortion : ImageEffectBase
	{
		// Token: 0x06001432 RID: 5170 RVA: 0x0009C944 File Offset: 0x0009AB44
		protected override void OFLNJNCBAHK()
		{
			base.AGBEEEFAAHO.SetFloat("_DistortionSteps", this.distortionSteps);
			if (this.MGGEDAABJMM > this.distortionAmountMaxLimit)
			{
				this.MGGEDAABJMM = this.distortionAmountMinLimit;
			}
			if (this.MGGEDAABJMM < this.distortionAmountMinLimit)
			{
				this.MGGEDAABJMM = this.distortionAmountMaxLimit;
			}
			if (this.distortionSpeed > 0f)
			{
				this.MGGEDAABJMM += Time.deltaTime * this.distortionSpeed;
			}
			base.AGBEEEFAAHO.SetFloat("_DistortionAmount", this.MGGEDAABJMM);
			base.OFLNJNCBAHK();
		}

		// Token: 0x17000047 RID: 71
		// (get) Token: 0x06001434 RID: 5172 RVA: 0x0009CA1C File Offset: 0x0009AC1C
		protected override string AAALPPMCHPA
		{
			get
			{
				return "Shaders/VideoGlitchBlackWhiteDistortion";
			}
		}

		// Token: 0x06001435 RID: 5173 RVA: 0x0009CA23 File Offset: 0x0009AC23
		public override void ResetDefaultValues()
		{
			this.distortionSteps = 2f;
			this.distortionAmountMinLimit = 340f;
			this.distortionAmountMaxLimit = 360f;
			this.distortionSpeed = 1f;
			this.MGGEDAABJMM = this.distortionAmountMinLimit;
			base.ResetDefaultValues();
		}

		// Token: 0x04000670 RID: 1648
		public float distortionSteps = 2f;

		// Token: 0x04000671 RID: 1649
		public float distortionAmountMinLimit = 340f;

		// Token: 0x04000672 RID: 1650
		public float distortionAmountMaxLimit = 360f;

		// Token: 0x04000673 RID: 1651
		public float distortionSpeed = 1f;

		// Token: 0x04000674 RID: 1652
		private float MGGEDAABJMM = 340f;

		// Token: 0x04000675 RID: 1653
		private const string JLKJDDFECNL = "_DistortionSteps";

		// Token: 0x04000676 RID: 1654
		private const string ALIFFANBMDN = "_DistortionAmount";
	}
}
