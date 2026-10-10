using System;
using UnityEngine;

namespace UnityStandardAssets.ImageEffects
{
	// Token: 0x02000018 RID: 24
	[ExecuteInEditMode]
	[AddComponentMenu("Image Effects/Color Adjustments/Teal Tone")]
	public class TealTone : ImageEffectBase
	{
		// Token: 0x06000082 RID: 130 RVA: 0x000073C2 File Offset: 0x000055C2
		private void OnEnable()
		{
			this.lerp = 0f;
		}

		// Token: 0x06000083 RID: 131 RVA: 0x000073CF File Offset: 0x000055CF
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
			base.material.SetFloat("_Lerp", this.lerp);
			Graphics.Blit(source, destination, base.material);
		}

		// Token: 0x06000084 RID: 132 RVA: 0x000073F4 File Offset: 0x000055F4
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

		// Token: 0x040000D4 RID: 212
		public float effectFadeTime = 1f;

		// Token: 0x040000D5 RID: 213
		private float lerp;
	}
}
