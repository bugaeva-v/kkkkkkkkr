using System;
using UnityEngine;

namespace UnityStandardAssets.ImageEffects
{
	// Token: 0x0200001C RID: 28
	[ExecuteInEditMode]
	[RequireComponent(typeof(Camera))]
	[AddComponentMenu("Image Effects/Camera/Vignette and Chromatic Aberration")]
	public class VignetteAndChromaticAberration : PostEffectsBase
	{
		// Token: 0x06000094 RID: 148 RVA: 0x00007EA0 File Offset: 0x000060A0
		public void OnEnable()
		{
			this.megaPixels = (float)Screen.width * (float)Screen.height / 1048576f;
		}

		// Token: 0x06000095 RID: 149 RVA: 0x00007EBC File Offset: 0x000060BC
		private float AdjustChromaticAberrationBasedOnScreenMegapixels()
		{
			if (this.megaPixels > 5f)
			{
				return this.chromaticAberration + 6f;
			}
			if (this.megaPixels > 4f)
			{
				return this.chromaticAberration + 5f;
			}
			if (this.megaPixels > 3f)
			{
				return this.chromaticAberration + 3f;
			}
			if (this.megaPixels > 2f)
			{
				return this.chromaticAberration + 2f;
			}
			if (this.megaPixels > 1f)
			{
				return this.chromaticAberration + 1f;
			}
			return this.chromaticAberration;
		}

		// Token: 0x06000096 RID: 150 RVA: 0x00007F54 File Offset: 0x00006154
		public override bool CheckResources()
		{
			base.CheckSupport(false);
			this.m_VignetteMaterial = base.CheckShaderAndCreateMaterial(this.vignetteShader, this.m_VignetteMaterial);
			this.m_SeparableBlurMaterial = base.CheckShaderAndCreateMaterial(this.separableBlurShader, this.m_SeparableBlurMaterial);
			this.m_ChromAberrationMaterial = base.CheckShaderAndCreateMaterial(this.chromAberrationShader, this.m_ChromAberrationMaterial);
			if (!this.isSupported)
			{
				base.ReportAutoDisable();
			}
			return this.isSupported;
		}

		// Token: 0x06000097 RID: 151 RVA: 0x00007FC8 File Offset: 0x000061C8
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
			if (!this.CheckResources())
			{
				Graphics.Blit(source, destination);
				return;
			}
			int width = source.width;
			int height = source.height;
			bool flag = Mathf.Abs(this.blur) > 0f || Mathf.Abs(this.intensity) > 0f;
			float num = 1f * (float)width / (1f * (float)height);
			RenderTexture renderTexture = null;
			RenderTexture renderTexture2 = null;
			if (flag)
			{
				renderTexture = RenderTexture.GetTemporary(width, height, 0, source.format);
				if (Mathf.Abs(this.blur) > 0f)
				{
					renderTexture2 = RenderTexture.GetTemporary(width / 2, height / 2, 0, source.format);
					Graphics.Blit(source, renderTexture2, this.m_ChromAberrationMaterial, 0);
					for (int i = 0; i < 1; i++)
					{
						this.m_SeparableBlurMaterial.SetVector("offsets", new Vector4(0f, this.blurSpread * 0.001953125f, 0f, 0f));
						RenderTexture temporary = RenderTexture.GetTemporary(width / 2, height / 2, 0, source.format);
						Graphics.Blit(renderTexture2, temporary, this.m_SeparableBlurMaterial);
						RenderTexture.ReleaseTemporary(renderTexture2);
						this.m_SeparableBlurMaterial.SetVector("offsets", new Vector4(this.blurSpread * 0.001953125f / num, 0f, 0f, 0f));
						renderTexture2 = RenderTexture.GetTemporary(width / 2, height / 2, 0, source.format);
						Graphics.Blit(temporary, renderTexture2, this.m_SeparableBlurMaterial);
						RenderTexture.ReleaseTemporary(temporary);
					}
				}
				this.m_VignetteMaterial.SetFloat("_Intensity", 1f / (1f - this.intensity) - 1f);
				this.m_VignetteMaterial.SetFloat("_Blur", 1f / (1f - this.blur) - 1f);
				this.m_VignetteMaterial.SetTexture("_VignetteTex", renderTexture2);
				Graphics.Blit(source, renderTexture, this.m_VignetteMaterial, 0);
			}
			this.m_ChromAberrationMaterial.SetFloat("_ChromaticAberration", this.AdjustChromaticAberrationBasedOnScreenMegapixels());
			this.m_ChromAberrationMaterial.SetFloat("_AxialAberration", this.axialAberration);
			this.m_ChromAberrationMaterial.SetVector("_BlurDistance", new Vector2(-this.blurDistance, this.blurDistance));
			this.m_ChromAberrationMaterial.SetFloat("_Luminance", 1f / Mathf.Max(Mathf.Epsilon, this.luminanceDependency));
			if (flag)
			{
				renderTexture.wrapMode = TextureWrapMode.Clamp;
			}
			else
			{
				source.wrapMode = TextureWrapMode.Clamp;
			}
			Graphics.Blit(flag ? renderTexture : source, destination, this.m_ChromAberrationMaterial, (this.mode == VignetteAndChromaticAberration.AberrationMode.Advanced) ? 2 : 1);
			RenderTexture.ReleaseTemporary(renderTexture);
			RenderTexture.ReleaseTemporary(renderTexture2);
		}

		// Token: 0x040000EC RID: 236
		private float megaPixels;

		// Token: 0x040000ED RID: 237
		public VignetteAndChromaticAberration.AberrationMode mode;

		// Token: 0x040000EE RID: 238
		public float intensity = 0.036f;

		// Token: 0x040000EF RID: 239
		public float chromaticAberration = 0.2f;

		// Token: 0x040000F0 RID: 240
		public float axialAberration = 0.5f;

		// Token: 0x040000F1 RID: 241
		public float blur;

		// Token: 0x040000F2 RID: 242
		public float blurSpread = 0.75f;

		// Token: 0x040000F3 RID: 243
		public float luminanceDependency = 0.25f;

		// Token: 0x040000F4 RID: 244
		public float blurDistance = 2.5f;

		// Token: 0x040000F5 RID: 245
		public Shader vignetteShader;

		// Token: 0x040000F6 RID: 246
		public Shader separableBlurShader;

		// Token: 0x040000F7 RID: 247
		public Shader chromAberrationShader;

		// Token: 0x040000F8 RID: 248
		private Material m_VignetteMaterial;

		// Token: 0x040000F9 RID: 249
		private Material m_SeparableBlurMaterial;

		// Token: 0x040000FA RID: 250
		private Material m_ChromAberrationMaterial;

		// Token: 0x02000060 RID: 96
		public enum AberrationMode
		{
			// Token: 0x040001FE RID: 510
			Simple,
			// Token: 0x040001FF RID: 511
			Advanced
		}
	}
}
