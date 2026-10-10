using System;
using UnityEngine;

namespace UnityStandardAssets.ImageEffects
{
	// Token: 0x02000004 RID: 4
	[ExecuteInEditMode]
	[RequireComponent(typeof(Camera))]
	[AddComponentMenu("Image Effects/Bloom and Glow/Bloom (Optimized)")]
	public class BloomOptimized : PostEffectsBase
	{
		// Token: 0x06000012 RID: 18 RVA: 0x00002D63 File Offset: 0x00000F63
		public override bool CheckResources()
		{
			base.CheckSupport(false);
			this.fastBloomMaterial = base.CheckShaderAndCreateMaterial(this.fastBloomShader, this.fastBloomMaterial);
			if (!this.isSupported)
			{
				base.ReportAutoDisable();
			}
			return this.isSupported;
		}

		// Token: 0x06000013 RID: 19 RVA: 0x00002D99 File Offset: 0x00000F99
		private void OnDisable()
		{
			if (this.fastBloomMaterial)
			{
				UnityEngine.Object.DestroyImmediate(this.fastBloomMaterial);
			}
		}

		// Token: 0x06000014 RID: 20 RVA: 0x00002DB4 File Offset: 0x00000FB4
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
			if (!this.CheckResources())
			{
				Graphics.Blit(source, destination);
				return;
			}
			int num = (this.resolution == BloomOptimized.Resolution.Low) ? 4 : 2;
			float num2 = (this.resolution == BloomOptimized.Resolution.Low) ? 0.5f : 1f;
			this.fastBloomMaterial.SetVector("_Parameter", new Vector4(this.blurSize * num2, 0f, this.threshold, this.intensity));
			source.filterMode = FilterMode.Bilinear;
			int width = source.width / num;
			int height = source.height / num;
			RenderTexture renderTexture = RenderTexture.GetTemporary(width, height, 0, source.format);
			renderTexture.filterMode = FilterMode.Bilinear;
			Graphics.Blit(source, renderTexture, this.fastBloomMaterial, 1);
			int num3 = (this.blurType == BloomOptimized.BlurType.Standard) ? 0 : 2;
			for (int i = 0; i < this.blurIterations; i++)
			{
				this.fastBloomMaterial.SetVector("_Parameter", new Vector4(this.blurSize * num2 + (float)i * 1f, 0f, this.threshold, this.intensity));
				RenderTexture temporary = RenderTexture.GetTemporary(width, height, 0, source.format);
				temporary.filterMode = FilterMode.Bilinear;
				Graphics.Blit(renderTexture, temporary, this.fastBloomMaterial, 2 + num3);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary;
				temporary = RenderTexture.GetTemporary(width, height, 0, source.format);
				temporary.filterMode = FilterMode.Bilinear;
				Graphics.Blit(renderTexture, temporary, this.fastBloomMaterial, 3 + num3);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary;
			}
			this.fastBloomMaterial.SetTexture("_Bloom", renderTexture);
			Graphics.Blit(source, destination, this.fastBloomMaterial, 0);
			RenderTexture.ReleaseTemporary(renderTexture);
		}

		// Token: 0x04000024 RID: 36
		[Range(0f, 1.5f)]
		public float threshold = 0.25f;

		// Token: 0x04000025 RID: 37
		[Range(0f, 2.5f)]
		public float intensity = 0.75f;

		// Token: 0x04000026 RID: 38
		[Range(0.25f, 5.5f)]
		public float blurSize = 1f;

		// Token: 0x04000027 RID: 39
		private BloomOptimized.Resolution resolution;

		// Token: 0x04000028 RID: 40
		[Range(1f, 4f)]
		public int blurIterations = 1;

		// Token: 0x04000029 RID: 41
		public BloomOptimized.BlurType blurType;

		// Token: 0x0400002A RID: 42
		public Shader fastBloomShader;

		// Token: 0x0400002B RID: 43
		private Material fastBloomMaterial;

		// Token: 0x02000054 RID: 84
		public enum Resolution
		{
			// Token: 0x040001CC RID: 460
			Low,
			// Token: 0x040001CD RID: 461
			High
		}

		// Token: 0x02000055 RID: 85
		public enum BlurType
		{
			// Token: 0x040001CF RID: 463
			Standard,
			// Token: 0x040001D0 RID: 464
			Sgx
		}
	}
}
