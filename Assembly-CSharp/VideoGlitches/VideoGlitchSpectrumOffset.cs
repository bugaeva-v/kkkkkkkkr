using System;
using UnityEngine;

namespace VideoGlitches
{
	// Token: 0x02000127 RID: 295
	[AddComponentMenu("Image Effects/Video Glitches/Video Glitch Spectrum Offset")]
	[RequireComponent(typeof(Camera))]
	[ExecuteInEditMode]
	public sealed class VideoGlitchSpectrumOffset : ImageEffectBase
	{
		// Token: 0x060026A9 RID: 9897 RVA: 0x0011CB2C File Offset: 0x0011AD2C
		public override void ResetDefaultValues()
		{
			this.strength = 0.1f;
			this.steps = 5;
			base.ResetDefaultValues();
		}

		// Token: 0x060026AA RID: 9898 RVA: 0x0011CB46 File Offset: 0x0011AD46
		protected override void OFLNJNCBAHK()
		{
			base.AGBEEEFAAHO.SetFloat("_Strength", this.strength);
			base.AGBEEEFAAHO.SetInt("_Steps", this.steps);
			base.OFLNJNCBAHK();
		}

		// Token: 0x170000CC RID: 204
		// (get) Token: 0x060026AB RID: 9899 RVA: 0x0011CB7A File Offset: 0x0011AD7A
		protected override string AAALPPMCHPA
		{
			get
			{
				return this.shaderPath;
			}
		}

		// Token: 0x04000C3D RID: 3133
		public float strength = 0.1f;

		// Token: 0x04000C3E RID: 3134
		public int steps = 5;

		// Token: 0x04000C3F RID: 3135
		private const string OFNECEHMEKN = "_Strength";

		// Token: 0x04000C40 RID: 3136
		private const string JCKGGHEMDLA = "_Steps";

		// Token: 0x04000C41 RID: 3137
		public string shaderPath = "Shaders/VideoGlitchSpectrumOffset";
	}
}
