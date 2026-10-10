using System;
using UnityEngine;

namespace VideoGlitches
{
	// Token: 0x0200001E RID: 30
	[AddComponentMenu("Image Effects/Video Glitches/Video Glitch Broken Screen")]
	[RequireComponent(typeof(Camera))]
	[ExecuteInEditMode]
	public sealed class VideoGlitchBrokenScreen : ImageEffectBase
	{
		// Token: 0x1700000A RID: 10
		// (get) Token: 0x060004C7 RID: 1223 RVA: 0x0001FC67 File Offset: 0x0001DE67
		protected override string AAALPPMCHPA
		{
			get
			{
				return "Shaders/VideoGlitchBrokenScreen";
			}
		}

		// Token: 0x060004C8 RID: 1224 RVA: 0x0001FC70 File Offset: 0x0001DE70
		protected override void OFLNJNCBAHK()
		{
			base.AGBEEEFAAHO.SetVector("_Center", this.impact);
			base.AGBEEEFAAHO.SetInt("_Splits", this.splits);
			base.AGBEEEFAAHO.SetFloat("_SplitThreshold", this.splitThreshold);
			base.AGBEEEFAAHO.SetColor("_SplitColor", this.splitColor);
			base.AGBEEEFAAHO.SetFloat("_Distortion", this.distortion * 0.1f);
			base.OFLNJNCBAHK();
		}

		// Token: 0x060004C9 RID: 1225 RVA: 0x0001FCFC File Offset: 0x0001DEFC
		public override void ResetDefaultValues()
		{
			this.impact = Vector2.zero;
			this.splits = 25;
			this.splitThreshold = 0.5f;
			this.splitColor = Color.gray;
			this.distortion = 0.2f;
			base.ResetDefaultValues();
		}

		// Token: 0x04000126 RID: 294
		public Vector2 impact = Vector2.zero;

		// Token: 0x04000127 RID: 295
		public int splits = 25;

		// Token: 0x04000128 RID: 296
		public float splitThreshold = 0.5f;

		// Token: 0x04000129 RID: 297
		public Color splitColor = Color.gray;

		// Token: 0x0400012A RID: 298
		public float distortion = 0.2f;

		// Token: 0x0400012B RID: 299
		private const string PCJFPNIAIDB = "_Center";

		// Token: 0x0400012C RID: 300
		private const string DLAFKNJDGDC = "_Splits";

		// Token: 0x0400012D RID: 301
		private const string JLLBNMBOKOM = "_SplitThreshold";

		// Token: 0x0400012E RID: 302
		private const string HFDJBGNOCGB = "_SplitColor";

		// Token: 0x0400012F RID: 303
		private const string KAFDONCKBON = "_Distortion";
	}
}
