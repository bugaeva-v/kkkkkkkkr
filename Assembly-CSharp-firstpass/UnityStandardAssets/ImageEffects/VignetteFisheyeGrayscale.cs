using System;
using UnityEngine;

namespace UnityStandardAssets.ImageEffects
{
	// Token: 0x0200001D RID: 29
	[ExecuteInEditMode]
	[RequireComponent(typeof(Camera))]
	[AddComponentMenu("Image Effects/Camera/VignetteFisheyeGrayscale")]
	public class VignetteFisheyeGrayscale : PostEffectsBase
	{
		// Token: 0x06000099 RID: 153 RVA: 0x000082D1 File Offset: 0x000064D1
		private void OnEnable()
		{
			this.lerp = 0f;
			this.lerpDirection = 0;
		}

		// Token: 0x0600009A RID: 154 RVA: 0x000082E8 File Offset: 0x000064E8
		public override bool CheckResources()
		{
			base.CheckSupport(false);
			this.m_VignetteFisheyeGrayscaleMaterial = base.CheckShaderAndCreateMaterial(this.vignetteFisheyeGrayscaleShader, this.m_VignetteFisheyeGrayscaleMaterial);
			this.m_SeparableBlurMaterial = base.CheckShaderAndCreateMaterial(this.separableBlurShader, this.m_SeparableBlurMaterial);
			if (!this.isSupported)
			{
				base.ReportAutoDisable();
			}
			return this.isSupported;
		}

		// Token: 0x0600009B RID: 155 RVA: 0x00008344 File Offset: 0x00006544
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
				if (Mathf.Abs(this.blur) > 0f)
				{
					for (int i = 0; i < 1; i++)
					{
						this.m_SeparableBlurMaterial.SetVector("offsets", new Vector4(0f, this.blurSpread * 0.001953125f, 0f, 0f));
						renderTexture2 = RenderTexture.GetTemporary(width / 2, height / 2, 0, source.format);
						Graphics.Blit(source, renderTexture2, this.m_SeparableBlurMaterial);
						this.m_SeparableBlurMaterial.SetVector("offsets", new Vector4(this.blurSpread * 0.001953125f / num, 0f, 0f, 0f));
						renderTexture = RenderTexture.GetTemporary(width / 2, height / 2, 0, source.format);
						Graphics.Blit(renderTexture2, renderTexture, this.m_SeparableBlurMaterial);
						RenderTexture.ReleaseTemporary(renderTexture2);
					}
				}
				this.m_VignetteFisheyeGrayscaleMaterial.SetFloat("_Intensity", 1f / (1f - this.intensity) - 1f);
				this.m_VignetteFisheyeGrayscaleMaterial.SetFloat("_Blur", 1f / (1f - this.blur) - 1f);
				this.m_VignetteFisheyeGrayscaleMaterial.SetTexture("_VignetteTex", renderTexture);
				float num2 = 0.15625f;
				float num3 = (float)source.width * 1f / ((float)source.height * 1f);
				this.m_VignetteFisheyeGrayscaleMaterial.SetVector("_IntensityFishEye", new Vector4(this.strengthFishEyeX * num3 * num2, this.strengthFishEyeY * num2, this.strengthFishEyeX * num3 * num2, this.strengthFishEyeY * num2));
				this.m_VignetteFisheyeGrayscaleMaterial.SetFloat("_Lerp", this.lerp);
				Graphics.Blit(source, destination, this.m_VignetteFisheyeGrayscaleMaterial, 0);
			}
			RenderTexture.ReleaseTemporary(renderTexture2);
			RenderTexture.ReleaseTemporary(renderTexture);
		}

		// Token: 0x0600009C RID: 156 RVA: 0x0000857E File Offset: 0x0000677E
		public int GetLerpDirection()
		{
			return this.lerpDirection;
		}

		// Token: 0x0600009D RID: 157 RVA: 0x00008586 File Offset: 0x00006786
		public void ResetLerp(int _direction)
		{
			this.lerpDirection = _direction;
			if (this.lerpDirection == 0)
			{
				this.lerp = 0f;
				return;
			}
			this.lerp = 1f;
		}

		// Token: 0x0600009E RID: 158 RVA: 0x000085B0 File Offset: 0x000067B0
		private void Update()
		{
			if (this.lerpDirection == 0)
			{
				if (this.lerp >= 1f || this.effectFadeInTime <= 0f)
				{
					this.lerp = 1f;
					return;
				}
				this.lerp += Time.deltaTime * (1f / this.effectFadeInTime);
				if (this.lerp > 1f)
				{
					this.lerp = 1f;
					return;
				}
			}
			else if (this.lerp >= 0f && this.effectFadeOutTime > 0f)
			{
				this.lerp -= Time.deltaTime * (1f / this.effectFadeOutTime);
				if (this.lerp < 0f)
				{
					this.lerp = 0f;
					return;
				}
			}
			else
			{
				this.lerp = 0f;
			}
		}

		// Token: 0x040000FB RID: 251
		public float strengthFishEyeX = 0.5f;

		// Token: 0x040000FC RID: 252
		public float strengthFishEyeY = 0.5f;

		// Token: 0x040000FD RID: 253
		public float intensity = 0.036f;

		// Token: 0x040000FE RID: 254
		public float blur;

		// Token: 0x040000FF RID: 255
		public float blurSpread = 0.75f;

		// Token: 0x04000100 RID: 256
		public Shader vignetteFisheyeGrayscaleShader;

		// Token: 0x04000101 RID: 257
		public Shader separableBlurShader;

		// Token: 0x04000102 RID: 258
		private float effectFadeInTime = 0.4f;

		// Token: 0x04000103 RID: 259
		private float effectFadeOutTime = 0.6f;

		// Token: 0x04000104 RID: 260
		private Material m_VignetteFisheyeGrayscaleMaterial;

		// Token: 0x04000105 RID: 261
		private Material m_SeparableBlurMaterial;

		// Token: 0x04000106 RID: 262
		private float lerp;

		// Token: 0x04000107 RID: 263
		private int lerpDirection;
	}
}
