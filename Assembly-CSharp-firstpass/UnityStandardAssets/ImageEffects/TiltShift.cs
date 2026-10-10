using System;
using UnityEngine;

namespace UnityStandardAssets.ImageEffects
{
	// Token: 0x02000019 RID: 25
	[RequireComponent(typeof(Camera))]
	[AddComponentMenu("Image Effects/Camera/Tilt Shift (Lens Blur)")]
	public class TiltShift : PostEffectsBase
	{
		// Token: 0x06000086 RID: 134 RVA: 0x00007471 File Offset: 0x00005671
		public override bool CheckResources()
		{
			base.CheckSupport(false);
			this.tiltShiftMaterial = base.CheckShaderAndCreateMaterial(this.tiltShiftShader, this.tiltShiftMaterial);
			if (!this.isSupported)
			{
				base.ReportAutoDisable();
			}
			return this.isSupported;
		}

		// Token: 0x06000087 RID: 135 RVA: 0x000074A8 File Offset: 0x000056A8
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
			if (!this.CheckResources())
			{
				Graphics.Blit(source, destination);
				return;
			}
			this.tiltShiftMaterial.SetFloat("_BlurSize", (this.maxBlurSize < 0f) ? 0f : this.maxBlurSize);
			this.tiltShiftMaterial.SetFloat("_BlurArea", this.blurArea);
			source.filterMode = FilterMode.Bilinear;
			RenderTexture renderTexture = destination;
			if ((float)this.downsample > 0f)
			{
				renderTexture = RenderTexture.GetTemporary(source.width >> this.downsample, source.height >> this.downsample, 0, source.format);
				renderTexture.filterMode = FilterMode.Bilinear;
			}
			int num = (int)this.quality;
			num *= 2;
			Graphics.Blit(source, renderTexture, this.tiltShiftMaterial, (this.mode == TiltShift.TiltShiftMode.TiltShiftMode) ? num : (num + 1));
			if (this.downsample > 0)
			{
				this.tiltShiftMaterial.SetTexture("_Blurred", renderTexture);
				Graphics.Blit(source, destination, this.tiltShiftMaterial, 8);
			}
			if (renderTexture != destination)
			{
				RenderTexture.ReleaseTemporary(renderTexture);
			}
		}

		// Token: 0x040000D6 RID: 214
		public TiltShift.TiltShiftMode mode;

		// Token: 0x040000D7 RID: 215
		public TiltShift.TiltShiftQuality quality = TiltShift.TiltShiftQuality.Normal;

		// Token: 0x040000D8 RID: 216
		[Range(0f, 15f)]
		public float blurArea = 1f;

		// Token: 0x040000D9 RID: 217
		[Range(0f, 25f)]
		public float maxBlurSize = 5f;

		// Token: 0x040000DA RID: 218
		[Range(0f, 1f)]
		public int downsample;

		// Token: 0x040000DB RID: 219
		public Shader tiltShiftShader;

		// Token: 0x040000DC RID: 220
		private Material tiltShiftMaterial;

		// Token: 0x0200005C RID: 92
		public enum TiltShiftMode
		{
			// Token: 0x040001E6 RID: 486
			TiltShiftMode,
			// Token: 0x040001E7 RID: 487
			IrisMode
		}

		// Token: 0x0200005D RID: 93
		public enum TiltShiftQuality
		{
			// Token: 0x040001E9 RID: 489
			Preview,
			// Token: 0x040001EA RID: 490
			Low,
			// Token: 0x040001EB RID: 491
			Normal,
			// Token: 0x040001EC RID: 492
			High
		}
	}
}
