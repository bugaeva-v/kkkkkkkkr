using System;
using UnityEngine;

namespace VideoGlitches
{
	// Token: 0x020003CF RID: 975
	[ExecuteInEditMode]
	[AddComponentMenu("Image Effects/Video Glitches/Video Glitch Old TV")]
	[RequireComponent(typeof(Camera))]
	public sealed class VideoGlitchOldTV : ImageEffectBase
	{
		// Token: 0x06007125 RID: 28965 RVA: 0x00330954 File Offset: 0x0032EB54
		public override void ResetDefaultValues()
		{
			this.slowScan = 0.01f;
			this.scanLine = 0.6f;
			this.vignetteSoftness = 0.9f;
			this.vignetteScale = 0.14f;
			this.grainOpacity = 5f;
			this.grainSaturation = 0f;
			this.scanDistort = 0.03f;
			this.timer = 0.85f;
			this.speed = 2f;
			this.crtDistort = 1f;
			this.crtScale = 1.06f;
			this.stripesCount = 0.5f;
			this.stripesOpacity = 1f;
			this.barsCount = 5f;
			this.moireOpacity = 1f;
			this.moireScale = 0.15f;
			this.tvLines = 2.5f;
			this.tvLinesOpacity = 1f;
			this.vignetteTubeScale = 0.7f;
			this.tvDots = 1f;
			this.tvDotsBlend = 1f;
			base.ResetDefaultValues();
		}

		// Token: 0x17000243 RID: 579
		// (get) Token: 0x06007127 RID: 28967 RVA: 0x00330B3F File Offset: 0x0032ED3F
		protected override string AAALPPMCHPA
		{
			get
			{
				return "Shaders/VideoGlitchOldTV";
			}
		}

		// Token: 0x06007128 RID: 28968 RVA: 0x00330B48 File Offset: 0x0032ED48
		protected override void OFLNJNCBAHK()
		{
			base.AGBEEEFAAHO.SetFloat("_Scanline", this.scanLine);
			base.AGBEEEFAAHO.SetFloat("_Slowscan", this.slowScan);
			base.AGBEEEFAAHO.SetFloat("_VignetteSoftness", this.vignetteSoftness);
			base.AGBEEEFAAHO.SetFloat("_VignetteScale", this.vignetteScale);
			base.AGBEEEFAAHO.SetFloat("_GrainOpacity", this.grainOpacity);
			base.AGBEEEFAAHO.SetFloat("_SaturationTV", this.grainSaturation);
			base.AGBEEEFAAHO.SetFloat("_ScanDistort", this.scanDistort);
			base.AGBEEEFAAHO.SetFloat("_Timer", this.timer);
			base.AGBEEEFAAHO.SetFloat("_Speed", this.speed);
			base.AGBEEEFAAHO.SetFloat("_Distort", this.crtDistort);
			base.AGBEEEFAAHO.SetFloat("_Scale", this.crtScale);
			base.AGBEEEFAAHO.SetFloat("_StripesCount", this.stripesCount);
			base.AGBEEEFAAHO.SetFloat("_Opacity", this.stripesOpacity);
			base.AGBEEEFAAHO.SetFloat("_BarsCount", this.barsCount);
			base.AGBEEEFAAHO.SetFloat("_OpacityMoire", this.moireOpacity);
			base.AGBEEEFAAHO.SetFloat("_MoireScale", this.moireScale);
			base.AGBEEEFAAHO.SetFloat("_TVLines", this.tvLines);
			base.AGBEEEFAAHO.SetFloat("_TVLinesOpacity", this.tvLinesOpacity);
			base.AGBEEEFAAHO.SetFloat("_TVTubeVignetteScale", this.vignetteTubeScale);
			base.AGBEEEFAAHO.SetFloat("_TVDots", this.tvDots);
			base.AGBEEEFAAHO.SetFloat("_TVDotsBlend", this.tvDotsBlend);
			base.OFLNJNCBAHK();
		}

		// Token: 0x040021AC RID: 8620
		public float slowScan = 0.01f;

		// Token: 0x040021AD RID: 8621
		public float scanLine = 0.6f;

		// Token: 0x040021AE RID: 8622
		public float vignetteSoftness = 0.9f;

		// Token: 0x040021AF RID: 8623
		public float vignetteScale = 0.14f;

		// Token: 0x040021B0 RID: 8624
		public float vignetteTubeScale = 0.7f;

		// Token: 0x040021B1 RID: 8625
		public float grainOpacity = 5f;

		// Token: 0x040021B2 RID: 8626
		public float grainSaturation;

		// Token: 0x040021B3 RID: 8627
		public float scanDistort = 0.03f;

		// Token: 0x040021B4 RID: 8628
		public float timer = 0.85f;

		// Token: 0x040021B5 RID: 8629
		public float speed = 2f;

		// Token: 0x040021B6 RID: 8630
		public float crtDistort = 0.03f;

		// Token: 0x040021B7 RID: 8631
		public float crtScale = 1.06f;

		// Token: 0x040021B8 RID: 8632
		public float stripesCount = 0.5f;

		// Token: 0x040021B9 RID: 8633
		public float stripesOpacity = 1f;

		// Token: 0x040021BA RID: 8634
		public float barsCount = 5f;

		// Token: 0x040021BB RID: 8635
		public float moireOpacity = 1f;

		// Token: 0x040021BC RID: 8636
		public float moireScale = 0.15f;

		// Token: 0x040021BD RID: 8637
		public float tvLines = 2.5f;

		// Token: 0x040021BE RID: 8638
		public float tvLinesOpacity = 1f;

		// Token: 0x040021BF RID: 8639
		public float tvDots = 1f;

		// Token: 0x040021C0 RID: 8640
		public float tvDotsBlend = 1f;

		// Token: 0x040021C1 RID: 8641
		private const string ALIGLGPJEPL = "_Scanline";

		// Token: 0x040021C2 RID: 8642
		private const string NOACNAHJFGD = "_Slowscan";

		// Token: 0x040021C3 RID: 8643
		private const string EGCLHDDNCMC = "_VignetteSoftness";

		// Token: 0x040021C4 RID: 8644
		private const string KOKGADMLCNL = "_VignetteScale";

		// Token: 0x040021C5 RID: 8645
		private const string NDLLMAFBGBD = "_GrainOpacity";

		// Token: 0x040021C6 RID: 8646
		private const string KMLMPOCBDEM = "_SaturationTV";

		// Token: 0x040021C7 RID: 8647
		private const string HBMFNEINNNK = "_ScanDistort";

		// Token: 0x040021C8 RID: 8648
		private const string GDGPDHNFACD = "_Timer";

		// Token: 0x040021C9 RID: 8649
		private const string MJJBFMAJODH = "_Speed";

		// Token: 0x040021CA RID: 8650
		private const string IPJFOANHLFN = "_Distort";

		// Token: 0x040021CB RID: 8651
		private const string OOACBNOBAIO = "_Scale";

		// Token: 0x040021CC RID: 8652
		private const string CLCEPEJBKLB = "_StripesCount";

		// Token: 0x040021CD RID: 8653
		private const string HKIDPBEFMID = "_Opacity";

		// Token: 0x040021CE RID: 8654
		private const string JHMHJMABCFK = "_BarsCount";

		// Token: 0x040021CF RID: 8655
		private const string AEAHAKPODEJ = "_OpacityMoire";

		// Token: 0x040021D0 RID: 8656
		private const string FFKLCANMHEI = "_MoireScale";

		// Token: 0x040021D1 RID: 8657
		private const string NNOKHOIMDPK = "_TVLines";

		// Token: 0x040021D2 RID: 8658
		private const string OLAOIFINMKF = "_TVLinesOpacity";

		// Token: 0x040021D3 RID: 8659
		private const string BHMELEPKFOE = "_TVTubeVignetteScale";

		// Token: 0x040021D4 RID: 8660
		private const string JHKNKDKFBOP = "_TVDots";

		// Token: 0x040021D5 RID: 8661
		private const string CBHDDFMFIKK = "_TVDotsBlend";
	}
}
