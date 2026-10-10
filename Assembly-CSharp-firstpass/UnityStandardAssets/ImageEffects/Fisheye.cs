using System;
using UnityEngine;

namespace UnityStandardAssets.ImageEffects
{
	// Token: 0x0200000D RID: 13
	[ExecuteInEditMode]
	[RequireComponent(typeof(Camera))]
	[AddComponentMenu("Image Effects/Displacement/Fisheye")]
	public class Fisheye : PostEffectsBase
	{
		// Token: 0x06000047 RID: 71 RVA: 0x0000534B File Offset: 0x0000354B
		public override bool CheckResources()
		{
			base.CheckSupport(false);
			this.fisheyeMaterial = base.CheckShaderAndCreateMaterial(this.fishEyeShader, this.fisheyeMaterial);
			if (!this.isSupported)
			{
				base.ReportAutoDisable();
			}
			return this.isSupported;
		}

		// Token: 0x06000048 RID: 72 RVA: 0x00005384 File Offset: 0x00003584
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
			if (!this.CheckResources())
			{
				Graphics.Blit(source, destination);
				return;
			}
			float num = 0.15625f;
			float num2 = (float)source.width * 1f / ((float)source.height * 1f);
			this.fisheyeMaterial.SetVector("intensity", new Vector4(this.strengthX * num2 * num, this.strengthY * num, this.strengthX * num2 * num, this.strengthY * num));
			Graphics.Blit(source, destination, this.fisheyeMaterial);
		}

		// Token: 0x0400008C RID: 140
		[Range(0f, 1.5f)]
		public float strengthX = 0.05f;

		// Token: 0x0400008D RID: 141
		[Range(0f, 1.5f)]
		public float strengthY = 0.05f;

		// Token: 0x0400008E RID: 142
		public Shader fishEyeShader;

		// Token: 0x0400008F RID: 143
		private Material fisheyeMaterial;
	}
}
