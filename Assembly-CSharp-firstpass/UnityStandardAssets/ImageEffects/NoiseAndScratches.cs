using System;
using UnityEngine;
using UnityEngine.Rendering;

namespace UnityStandardAssets.ImageEffects
{
	// Token: 0x02000012 RID: 18
	[ExecuteInEditMode]
	[RequireComponent(typeof(Camera))]
	[AddComponentMenu("Image Effects/Noise/Noise and Scratches")]
	public class NoiseAndScratches : MonoBehaviour
	{
		// Token: 0x0600005D RID: 93 RVA: 0x00005DD8 File Offset: 0x00003FD8
		protected void Start()
		{
			if (SystemInfo.graphicsShaderLevel < 30 || SystemInfo.graphicsDeviceType == GraphicsDeviceType.OpenGLES2)
			{
				base.enabled = false;
				return;
			}
			if (this.shaderRGB == null || this.shaderYUV == null)
			{
				Debug.Log("Noise shaders are not set up! Disabling noise effect.");
				base.enabled = false;
				return;
			}
			if (!this.shaderRGB.isSupported)
			{
				base.enabled = false;
				return;
			}
			if (!this.shaderYUV.isSupported)
			{
				this.rgbFallback = true;
			}
		}

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x0600005E RID: 94 RVA: 0x00005E58 File Offset: 0x00004058
		protected Material material
		{
			get
			{
				if (this.m_MaterialRGB == null)
				{
					this.m_MaterialRGB = new Material(this.shaderRGB);
					this.m_MaterialRGB.hideFlags = HideFlags.HideAndDontSave;
				}
				if (this.m_MaterialYUV == null && !this.rgbFallback)
				{
					this.m_MaterialYUV = new Material(this.shaderYUV);
					this.m_MaterialYUV.hideFlags = HideFlags.HideAndDontSave;
				}
				if (this.rgbFallback || this.monochrome)
				{
					return this.m_MaterialRGB;
				}
				return this.m_MaterialYUV;
			}
		}

		// Token: 0x0600005F RID: 95 RVA: 0x00005EE2 File Offset: 0x000040E2
		protected void OnDisable()
		{
			if (this.m_MaterialRGB)
			{
				UnityEngine.Object.DestroyImmediate(this.m_MaterialRGB);
			}
			if (this.m_MaterialYUV)
			{
				UnityEngine.Object.DestroyImmediate(this.m_MaterialYUV);
			}
		}

		// Token: 0x06000060 RID: 96 RVA: 0x00005F14 File Offset: 0x00004114
		private void SanitizeParameters()
		{
			this.grainIntensityMin = Mathf.Clamp(this.grainIntensityMin, 0f, 5f);
			this.grainIntensityMax = Mathf.Clamp(this.grainIntensityMax, 0f, 5f);
			this.scratchIntensityMin = Mathf.Clamp(this.scratchIntensityMin, 0f, 5f);
			this.scratchIntensityMax = Mathf.Clamp(this.scratchIntensityMax, 0f, 5f);
			this.scratchFPS = Mathf.Clamp(this.scratchFPS, 1f, 30f);
			this.scratchJitter = Mathf.Clamp(this.scratchJitter, 0f, 1f);
			this.grainSize = Mathf.Clamp(this.grainSize, 0.1f, 50f);
		}

		// Token: 0x06000061 RID: 97 RVA: 0x00005FE0 File Offset: 0x000041E0
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
			this.SanitizeParameters();
			if (this.scratchTimeLeft <= 0f)
			{
				this.scratchTimeLeft = UnityEngine.Random.value * 2f / this.scratchFPS;
				this.scratchX = UnityEngine.Random.value;
				this.scratchY = UnityEngine.Random.value;
			}
			this.scratchTimeLeft -= Time.deltaTime;
			Material material = this.material;
			material.SetTexture("_GrainTex", this.grainTexture);
			material.SetTexture("_ScratchTex", this.scratchTexture);
			float num = 1f / this.grainSize;
			material.SetVector("_GrainOffsetScale", new Vector4(UnityEngine.Random.value, UnityEngine.Random.value, (float)Screen.width / (float)this.grainTexture.width * num, (float)Screen.height / (float)this.grainTexture.height * num));
			material.SetVector("_ScratchOffsetScale", new Vector4(this.scratchX + UnityEngine.Random.value * this.scratchJitter, this.scratchY + UnityEngine.Random.value * this.scratchJitter, (float)Screen.width / (float)this.scratchTexture.width, (float)Screen.height / (float)this.scratchTexture.height));
			material.SetVector("_Intensity", new Vector4(UnityEngine.Random.Range(this.grainIntensityMin, this.grainIntensityMax), UnityEngine.Random.Range(this.scratchIntensityMin, this.scratchIntensityMax), 0f, 0f));
			Graphics.Blit(source, destination, material);
		}

		// Token: 0x040000AE RID: 174
		public bool monochrome = true;

		// Token: 0x040000AF RID: 175
		private bool rgbFallback;

		// Token: 0x040000B0 RID: 176
		[Range(0f, 5f)]
		public float grainIntensityMin = 0.1f;

		// Token: 0x040000B1 RID: 177
		[Range(0f, 5f)]
		public float grainIntensityMax = 0.2f;

		// Token: 0x040000B2 RID: 178
		[Range(0.1f, 50f)]
		public float grainSize = 2f;

		// Token: 0x040000B3 RID: 179
		[Range(0f, 5f)]
		public float scratchIntensityMin = 0.05f;

		// Token: 0x040000B4 RID: 180
		[Range(0f, 5f)]
		public float scratchIntensityMax = 0.25f;

		// Token: 0x040000B5 RID: 181
		[Range(1f, 30f)]
		public float scratchFPS = 10f;

		// Token: 0x040000B6 RID: 182
		[Range(0f, 1f)]
		public float scratchJitter = 0.01f;

		// Token: 0x040000B7 RID: 183
		public Texture grainTexture;

		// Token: 0x040000B8 RID: 184
		public Texture scratchTexture;

		// Token: 0x040000B9 RID: 185
		public Shader shaderRGB;

		// Token: 0x040000BA RID: 186
		public Shader shaderYUV;

		// Token: 0x040000BB RID: 187
		private Material m_MaterialRGB;

		// Token: 0x040000BC RID: 188
		private Material m_MaterialYUV;

		// Token: 0x040000BD RID: 189
		private float scratchTimeLeft;

		// Token: 0x040000BE RID: 190
		private float scratchX;

		// Token: 0x040000BF RID: 191
		private float scratchY;
	}
}
