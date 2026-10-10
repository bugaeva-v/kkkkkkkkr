using System;
using UnityEngine;

namespace UnityStandardAssets.ImageEffects
{
	// Token: 0x02000005 RID: 5
	[ExecuteInEditMode]
	[RequireComponent(typeof(Camera))]
	[AddComponentMenu("Image Effects/Blur/Blur (Optimized)")]
	public class BlurOptimized : PostEffectsBase
	{
		// Token: 0x06000016 RID: 22 RVA: 0x00002F88 File Offset: 0x00001188
		public override bool CheckResources()
		{
			base.CheckSupport(false);
			this.blurMaterial = base.CheckShaderAndCreateMaterial(this.blurShader, this.blurMaterial);
			if (null != this.blurShaderMorph)
			{
				this.blurMaterialMorph = base.CheckShaderAndCreateMaterial(this.blurShaderMorph, this.blurMaterialMorph);
			}
			if (!this.isSupported)
			{
				base.ReportAutoDisable();
			}
			return this.isSupported;
		}

		// Token: 0x06000017 RID: 23 RVA: 0x00002FEF File Offset: 0x000011EF
		public void OnEnable()
		{
			this.lerp = 0f;
		}

		// Token: 0x06000018 RID: 24 RVA: 0x00002FFC File Offset: 0x000011FC
		public void OnDisable()
		{
			if (this.blurMaterial)
			{
				UnityEngine.Object.DestroyImmediate(this.blurMaterial);
			}
			if (this.blurMaterialMorph)
			{
				UnityEngine.Object.DestroyImmediate(this.blurMaterialMorph);
			}
		}

		// Token: 0x06000019 RID: 25 RVA: 0x0000302E File Offset: 0x0000122E
		private float AdjustBlurSizeBasedOnScreenHeight()
		{
			return this.blurSize * ((float)Screen.height / 1920f);
		}

		// Token: 0x0600001A RID: 26 RVA: 0x00003044 File Offset: 0x00001244
		public void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
			if (!this.CheckResources())
			{
				Graphics.Blit(source, destination);
				return;
			}
			float num = 1f / (1f * (float)(1 << this.downsample));
			float num2 = this.AdjustBlurSizeBasedOnScreenHeight();
			this.blurMaterial.SetVector("_Parameter", new Vector4(num2 * num, -num2 * num, 0f, 0f));
			source.filterMode = FilterMode.Bilinear;
			int width = source.width >> this.downsample;
			int height = source.height >> this.downsample;
			RenderTexture renderTexture = RenderTexture.GetTemporary(width, height, 0, source.format);
			renderTexture.filterMode = FilterMode.Bilinear;
			Graphics.Blit(source, renderTexture, this.blurMaterial, 0);
			int num3 = (this.blurType == BlurOptimized.BlurType.StandardGauss) ? 0 : 2;
			for (int i = 0; i < this.blurIterations; i++)
			{
				float num4 = (float)i * 1f;
				this.blurMaterial.SetVector("_Parameter", new Vector4(num2 * num + num4, -num2 * num - num4, 0f, 0f));
				RenderTexture temporary = RenderTexture.GetTemporary(width, height, 0, source.format);
				temporary.filterMode = FilterMode.Bilinear;
				Graphics.Blit(renderTexture, temporary, this.blurMaterial, 1 + num3);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary;
				temporary = RenderTexture.GetTemporary(width, height, 0, source.format);
				temporary.filterMode = FilterMode.Bilinear;
				Graphics.Blit(renderTexture, temporary, this.blurMaterial, 2 + num3);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary;
			}
			if (null != this.blurMaterialMorph && (this.alwaysMorph || (!this.alwaysMorph && this.lerp < 1f)))
			{
				this.blurMaterialMorph.SetFloat("_Lerp", this.lerp);
				this.blurMaterialMorph.SetFloat("_VerticalOffset", BlurOptimized.verticalOffsetForRenderTargetMorphGradient);
				this.blurMaterialMorph.SetTexture("_SecondTex", source);
				Graphics.Blit(renderTexture, destination, this.blurMaterialMorph);
			}
			else
			{
				Graphics.Blit(renderTexture, destination);
			}
			RenderTexture.ReleaseTemporary(renderTexture);
		}

		// Token: 0x0600001B RID: 27 RVA: 0x0000324C File Offset: 0x0000144C
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

		// Token: 0x0400002C RID: 44
		private const float referenceScreenHeight = 1920f;

		// Token: 0x0400002D RID: 45
		[Range(0f, 2f)]
		public int downsample = 1;

		// Token: 0x0400002E RID: 46
		[Range(0f, 10f)]
		public float blurSize = 3f;

		// Token: 0x0400002F RID: 47
		[Range(1f, 4f)]
		public int blurIterations = 2;

		// Token: 0x04000030 RID: 48
		public BlurOptimized.BlurType blurType;

		// Token: 0x04000031 RID: 49
		public Shader blurShader;

		// Token: 0x04000032 RID: 50
		public Shader blurShaderMorph;

		// Token: 0x04000033 RID: 51
		private Material blurMaterial;

		// Token: 0x04000034 RID: 52
		private Material blurMaterialMorph;

		// Token: 0x04000035 RID: 53
		public float effectFadeTime = 1f;

		// Token: 0x04000036 RID: 54
		public bool alwaysMorph;

		// Token: 0x04000037 RID: 55
		private float lerp;

		// Token: 0x04000038 RID: 56
		public static float verticalOffsetForRenderTargetMorphGradient;

		// Token: 0x02000056 RID: 86
		public enum BlurType
		{
			// Token: 0x040001D2 RID: 466
			StandardGauss,
			// Token: 0x040001D3 RID: 467
			SgxGauss
		}
	}
}
