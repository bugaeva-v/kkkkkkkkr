using System;
using UnityEngine;

namespace UnityStandardAssets.ImageEffects
{
	// Token: 0x0200000E RID: 14
	[ExecuteInEditMode]
	[AddComponentMenu("Image Effects/Color Adjustments/Grayscale")]
	public class Grayscale : ImageEffectBase
	{
		// Token: 0x0600004A RID: 74 RVA: 0x00005427 File Offset: 0x00003627
		private void OnEnable()
		{
			this.lerp = 0f;
		}

		// Token: 0x0600004B RID: 75 RVA: 0x00005434 File Offset: 0x00003634
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
			base.material.SetTexture("_RampTex", this.textureRamp);
			base.material.SetFloat("_RampOffset", this.rampOffset);
			base.material.SetFloat("_Lerp", this.lerp);
			Graphics.Blit(source, destination, base.material);
		}

		// Token: 0x0600004C RID: 76 RVA: 0x00005490 File Offset: 0x00003690
		private void Update()
		{
			if (this.lerp < 1f && this.effectFadeTime > 0f)
			{
				this.lerp += Time.deltaTime * (1f / this.effectFadeTime);
				if (this.lerp > 1f)
				{
					this.lerp = 1f;
					return;
				}
			}
			else
			{
				this.lerp = 1f;
			}
		}

		// Token: 0x04000090 RID: 144
		public Texture textureRamp;

		// Token: 0x04000091 RID: 145
		[Range(-1f, 1f)]
		public float rampOffset;

		// Token: 0x04000092 RID: 146
		public float effectFadeTime = 1f;

		// Token: 0x04000093 RID: 147
		private float lerp;
	}
}
