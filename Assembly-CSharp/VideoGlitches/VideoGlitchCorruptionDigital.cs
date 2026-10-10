using System;
using UnityEngine;

namespace VideoGlitches
{
	// Token: 0x0200045B RID: 1115
	[ExecuteInEditMode]
	[AddComponentMenu("Image Effects/Video Glitches/Video Glitch Corruption Digital")]
	[RequireComponent(typeof(Camera))]
	public sealed class VideoGlitchCorruptionDigital : ImageEffectBase
	{
		// Token: 0x17000286 RID: 646
		// (get) Token: 0x060087EF RID: 34799 RVA: 0x003CD3B6 File Offset: 0x003CB5B6
		protected override string AAALPPMCHPA
		{
			get
			{
				return "Shaders/VideoGlitchCorruptionDigital";
			}
		}

		// Token: 0x060087F0 RID: 34800 RVA: 0x003CD3BD File Offset: 0x003CB5BD
		public override void ResetDefaultValues()
		{
			this.strength = 0.5f;
			this.speed = 1f;
			this.tileSize = 64;
			base.ResetDefaultValues();
		}

		// Token: 0x060087F1 RID: 34801 RVA: 0x003CD3E4 File Offset: 0x003CB5E4
		protected override void OFLNJNCBAHK()
		{
			base.AGBEEEFAAHO.SetFloat("_Strength", this.strength);
			base.AGBEEEFAAHO.SetFloat("_Speed", this.speed);
			base.AGBEEEFAAHO.SetFloat("_TileSize", (float)this.tileSize);
			base.OFLNJNCBAHK();
		}

		// Token: 0x040025FF RID: 9727
		public float strength = 0.5f;

		// Token: 0x04002600 RID: 9728
		public float speed = 1f;

		// Token: 0x04002601 RID: 9729
		public int tileSize = 64;

		// Token: 0x04002602 RID: 9730
		private const string OFNECEHMEKN = "_Strength";

		// Token: 0x04002603 RID: 9731
		private const string MJJBFMAJODH = "_Speed";

		// Token: 0x04002604 RID: 9732
		private const string IOLCPLCMKGH = "_TileSize";
	}
}
