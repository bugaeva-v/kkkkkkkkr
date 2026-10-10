using System;
using UnityEngine;

namespace UnityStandardAssets.ImageEffects
{
	// Token: 0x02000011 RID: 17
	[ExecuteInEditMode]
	[RequireComponent(typeof(Camera))]
	[AddComponentMenu("Image Effects/Noise/Noise And Grain")]
	public class NoiseAndGrain : PostEffectsBase
	{
		// Token: 0x06000056 RID: 86 RVA: 0x00005650 File Offset: 0x00003850
		public override bool CheckResources()
		{
			base.CheckSupport(false);
			this.noiseMaterial = base.CheckShaderAndCreateMaterial(this.noiseShader, this.noiseMaterial);
			if (this.dx11Grain && this.supportDX11)
			{
				this.dx11NoiseMaterial = base.CheckShaderAndCreateMaterial(this.dx11NoiseShader, this.dx11NoiseMaterial);
			}
			if (!this.isSupported)
			{
				base.ReportAutoDisable();
			}
			return this.isSupported;
		}

		// Token: 0x06000057 RID: 87 RVA: 0x000056B9 File Offset: 0x000038B9
		public void OnEnable()
		{
			this.megaPixels = (float)Screen.width * (float)Screen.height / 1048576f;
		}

		// Token: 0x06000058 RID: 88 RVA: 0x000056D4 File Offset: 0x000038D4
		private Vector3 AdjustTilingBasedOnScreenMegapixels()
		{
			if (this.megaPixels > 5f)
			{
				return this.tiling5;
			}
			if (this.megaPixels > 4f)
			{
				return this.tiling4;
			}
			if (this.megaPixels > 3f)
			{
				return this.tiling3;
			}
			if (this.megaPixels > 2f)
			{
				return this.tiling2;
			}
			if (this.megaPixels > 1f)
			{
				return this.tiling0;
			}
			return this.tiling;
		}

		// Token: 0x06000059 RID: 89 RVA: 0x0000574C File Offset: 0x0000394C
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
			if (!this.CheckResources() || null == this.noiseTexture)
			{
				Graphics.Blit(source, destination);
				if (null == this.noiseTexture)
				{
					Debug.LogWarning("Noise & Grain effect failing as noise texture is not assigned. please assign.", base.transform);
				}
				return;
			}
			this.softness = Mathf.Clamp(this.softness, 0f, 0.99f);
			if (this.dx11Grain && this.supportDX11)
			{
				this.dx11NoiseMaterial.SetFloat("_DX11NoiseTime", (float)Time.frameCount);
				this.dx11NoiseMaterial.SetTexture("_NoiseTex", this.noiseTexture);
				this.dx11NoiseMaterial.SetVector("_NoisePerChannel", this.monochrome ? Vector3.one : this.intensities);
				this.dx11NoiseMaterial.SetVector("_MidGrey", new Vector3(this.midGrey, 1f / (1f - this.midGrey), -1f / this.midGrey));
				this.dx11NoiseMaterial.SetVector("_NoiseAmount", new Vector3(this.generalIntensity, this.blackIntensity, this.whiteIntensity) * this.intensityMultiplier);
				if (this.softness > Mathf.Epsilon)
				{
					RenderTexture temporary = RenderTexture.GetTemporary((int)((float)source.width * (1f - this.softness)), (int)((float)source.height * (1f - this.softness)));
					NoiseAndGrain.DrawNoiseQuadGrid(source, temporary, this.dx11NoiseMaterial, this.noiseTexture, this.monochrome ? 3 : 2);
					this.dx11NoiseMaterial.SetTexture("_NoiseTex", temporary);
					Graphics.Blit(source, destination, this.dx11NoiseMaterial, 4);
					RenderTexture.ReleaseTemporary(temporary);
					return;
				}
				NoiseAndGrain.DrawNoiseQuadGrid(source, destination, this.dx11NoiseMaterial, this.noiseTexture, this.monochrome ? 1 : 0);
				return;
			}
			else
			{
				if (this.noiseTexture)
				{
					this.noiseTexture.wrapMode = TextureWrapMode.Repeat;
					this.noiseTexture.filterMode = this.filterMode;
				}
				this.noiseMaterial.SetTexture("_NoiseTex", this.noiseTexture);
				this.noiseMaterial.SetVector("_NoisePerChannel", this.monochrome ? Vector3.one : this.intensities);
				this.noiseMaterial.SetVector("_NoiseTilingPerChannel", this.monochrome ? (Vector3.one * this.monochromeTiling) : this.AdjustTilingBasedOnScreenMegapixels());
				this.noiseMaterial.SetVector("_MidGrey", new Vector3(this.midGrey, 1f / (1f - this.midGrey), -1f / this.midGrey));
				this.noiseMaterial.SetVector("_NoiseAmount", new Vector3(this.generalIntensity, this.blackIntensity, this.whiteIntensity) * this.intensityMultiplier);
				if (this.softness > Mathf.Epsilon)
				{
					RenderTexture temporary2 = RenderTexture.GetTemporary((int)((float)source.width * (1f - this.softness)), (int)((float)source.height * (1f - this.softness)));
					NoiseAndGrain.DrawNoiseQuadGrid(source, temporary2, this.noiseMaterial, this.noiseTexture, 2);
					this.noiseMaterial.SetTexture("_NoiseTex", temporary2);
					Graphics.Blit(source, destination, this.noiseMaterial, 1);
					RenderTexture.ReleaseTemporary(temporary2);
					return;
				}
				NoiseAndGrain.DrawNoiseQuadGrid(source, destination, this.noiseMaterial, this.noiseTexture, 0);
				return;
			}
		}

		// Token: 0x0600005A RID: 90 RVA: 0x00005AD4 File Offset: 0x00003CD4
		private static void DrawNoiseQuadGrid(RenderTexture source, RenderTexture dest, Material fxMaterial, Texture2D noise, int passNr)
		{
			RenderTexture.active = dest;
			float num = (float)noise.width * 1f;
			float num2 = 1f * (float)source.width / NoiseAndGrain.TILE_AMOUNT;
			fxMaterial.SetTexture("_MainTex", source);
			GL.PushMatrix();
			GL.LoadOrtho();
			float num3 = 1f * (float)source.width / (1f * (float)source.height);
			float num4 = 1f / num2;
			float num5 = num4 * num3;
			float num6 = num / ((float)noise.width * 1f);
			fxMaterial.SetPass(passNr);
			GL.Begin(7);
			for (float num7 = 0f; num7 < 1f; num7 += num4)
			{
				for (float num8 = 0f; num8 < 1f; num8 += num5)
				{
					float num9 = UnityEngine.Random.Range(0f, 1f);
					float num10 = UnityEngine.Random.Range(0f, 1f);
					num9 = Mathf.Floor(num9 * num) / num;
					num10 = Mathf.Floor(num10 * num) / num;
					float num11 = 1f / num;
					GL.MultiTexCoord2(0, num9, num10);
					GL.MultiTexCoord2(1, 0f, 0f);
					GL.Vertex3(num7, num8, 0.1f);
					GL.MultiTexCoord2(0, num9 + num6 * num11, num10);
					GL.MultiTexCoord2(1, 1f, 0f);
					GL.Vertex3(num7 + num4, num8, 0.1f);
					GL.MultiTexCoord2(0, num9 + num6 * num11, num10 + num6 * num11);
					GL.MultiTexCoord2(1, 1f, 1f);
					GL.Vertex3(num7 + num4, num8 + num5, 0.1f);
					GL.MultiTexCoord2(0, num9, num10 + num6 * num11);
					GL.MultiTexCoord2(1, 0f, 1f);
					GL.Vertex3(num7, num8 + num5, 0.1f);
				}
			}
			GL.End();
			GL.PopMatrix();
		}

		// Token: 0x04000096 RID: 150
		private float megaPixels;

		// Token: 0x04000097 RID: 151
		public float intensityMultiplier = 0.25f;

		// Token: 0x04000098 RID: 152
		public float generalIntensity = 0.5f;

		// Token: 0x04000099 RID: 153
		public float blackIntensity = 1f;

		// Token: 0x0400009A RID: 154
		public float whiteIntensity = 1f;

		// Token: 0x0400009B RID: 155
		public float midGrey = 0.2f;

		// Token: 0x0400009C RID: 156
		public bool dx11Grain;

		// Token: 0x0400009D RID: 157
		public float softness;

		// Token: 0x0400009E RID: 158
		public bool monochrome;

		// Token: 0x0400009F RID: 159
		public Vector3 intensities = new Vector3(1f, 1f, 1f);

		// Token: 0x040000A0 RID: 160
		public Vector3 tiling = new Vector3(64f, 64f, 64f);

		// Token: 0x040000A1 RID: 161
		public Vector3 tiling0 = new Vector3(56f, 56f, 56f);

		// Token: 0x040000A2 RID: 162
		public Vector3 tiling2 = new Vector3(50f, 50f, 50f);

		// Token: 0x040000A3 RID: 163
		public Vector3 tiling3 = new Vector3(42f, 42f, 42f);

		// Token: 0x040000A4 RID: 164
		public Vector3 tiling4 = new Vector3(34f, 34f, 34f);

		// Token: 0x040000A5 RID: 165
		public Vector3 tiling5 = new Vector3(30f, 30f, 30f);

		// Token: 0x040000A6 RID: 166
		public float monochromeTiling = 64f;

		// Token: 0x040000A7 RID: 167
		public FilterMode filterMode = FilterMode.Bilinear;

		// Token: 0x040000A8 RID: 168
		public Texture2D noiseTexture;

		// Token: 0x040000A9 RID: 169
		public Shader noiseShader;

		// Token: 0x040000AA RID: 170
		private Material noiseMaterial;

		// Token: 0x040000AB RID: 171
		public Shader dx11NoiseShader;

		// Token: 0x040000AC RID: 172
		private Material dx11NoiseMaterial;

		// Token: 0x040000AD RID: 173
		private static float TILE_AMOUNT = 64f;
	}
}
