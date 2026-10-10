using System;
using UnityEngine;

namespace VideoGlitches
{
	// Token: 0x020000E1 RID: 225
	[RequireComponent(typeof(Camera))]
	[ExecuteInEditMode]
	[AddComponentMenu("Image Effects/Video Glitches/Video Glitch Old VHS")]
	public sealed class VideoGlitchOldVHS : ImageEffectBase
	{
		// Token: 0x060021AF RID: 8623 RVA: 0x000EBF64 File Offset: 0x000EA164
		protected override void OFLNJNCBAHK()
		{
			base.AGBEEEFAAHO.SetFloat("_Waving", this.waving);
			base.AGBEEEFAAHO.SetFloat("_Noise", this.noise);
			base.AGBEEEFAAHO.SetFloat("_StripeCount", Mathf.Floor(this.stripeCount) * 6f);
			base.AGBEEEFAAHO.SetFloat("_StripeVelocity", this.stripeVelocity);
			base.AGBEEEFAAHO.SetFloat("_StripeStrength", this.stripeStrength * 10f);
			base.AGBEEEFAAHO.SetFloat("_StripeNoise", this.stripeNoise * 500f);
			base.AGBEEEFAAHO.SetFloat("_SwitchingNoise", this.switchingNoise);
			base.AGBEEEFAAHO.SetFloat("_ACBeatWidth", this.acBeatWidth);
			base.AGBEEEFAAHO.SetFloat("_ACBeatVelocity", this.acBeatVelocity);
			base.AGBEEEFAAHO.SetFloat("_BloomPasses", this.bloomPasses);
			base.OFLNJNCBAHK();
		}

		// Token: 0x060021B0 RID: 8624 RVA: 0x000EC06C File Offset: 0x000EA26C
		public override void ResetDefaultValues()
		{
			this.waving = 0.5f;
			this.noise = 0.25f;
			this.stripeCount = 2f;
			this.stripeVelocity = 1.2f;
			this.stripeStrength = 1f;
			this.stripeNoise = 0.5f;
			this.switchingNoise = 0.5f;
			this.acBeatWidth = 0.6f;
			this.acBeatVelocity = 0.2f;
			this.bloomPasses = 5f;
			base.ResetDefaultValues();
		}

		// Token: 0x1700006F RID: 111
		// (get) Token: 0x060021B1 RID: 8625 RVA: 0x000EC0ED File Offset: 0x000EA2ED
		protected override string AAALPPMCHPA
		{
			get
			{
				return "Shaders/VideoGlitchOldVHS";
			}
		}

		// Token: 0x04000977 RID: 2423
		public float waving = 0.5f;

		// Token: 0x04000978 RID: 2424
		public float noise = 0.25f;

		// Token: 0x04000979 RID: 2425
		public float stripeCount = 8f;

		// Token: 0x0400097A RID: 2426
		public float stripeVelocity = 1.2f;

		// Token: 0x0400097B RID: 2427
		public float stripeStrength = 1f;

		// Token: 0x0400097C RID: 2428
		public float stripeNoise = 0.5f;

		// Token: 0x0400097D RID: 2429
		public float switchingNoise = 0.5f;

		// Token: 0x0400097E RID: 2430
		public float acBeatWidth = 0.6f;

		// Token: 0x0400097F RID: 2431
		public float acBeatVelocity = 0.2f;

		// Token: 0x04000980 RID: 2432
		public float bloomPasses = 5f;

		// Token: 0x04000981 RID: 2433
		private const string MLNEBKBFFHF = "_Waving";

		// Token: 0x04000982 RID: 2434
		private const string HNIDNCGAJLH = "_Noise";

		// Token: 0x04000983 RID: 2435
		private const string AHHCNBHNGHD = "_StripeCount";

		// Token: 0x04000984 RID: 2436
		private const string HKFPNGHOHEG = "_StripeVelocity";

		// Token: 0x04000985 RID: 2437
		private const string OOPEJKFGICE = "_StripeStrength";

		// Token: 0x04000986 RID: 2438
		private const string HNNHLDDLCHD = "_StripeNoise";

		// Token: 0x04000987 RID: 2439
		private const string AAJIPIAMOEI = "_SwitchingNoise";

		// Token: 0x04000988 RID: 2440
		private const string JAAJGKODLPF = "_ACBeatWidth";

		// Token: 0x04000989 RID: 2441
		private const string BGODCGCLIKE = "_ACBeatVelocity";

		// Token: 0x0400098A RID: 2442
		private const string HKPJHBCDAMD = "_BloomPasses";
	}
}
