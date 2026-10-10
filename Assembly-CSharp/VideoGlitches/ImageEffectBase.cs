using System;
using UnityEngine;

namespace VideoGlitches
{
	// Token: 0x020000E4 RID: 228
	public abstract class ImageEffectBase : MonoBehaviour
	{
		// Token: 0x060021B8 RID: 8632 RVA: 0x000EC15D File Offset: 0x000EA35D
		protected virtual bool FOBNDGDDMBN()
		{
			if (!SystemInfo.supportsImageEffects)
			{
				Debug.LogWarning(string.Format("Hardware not support Image Effects. '{0}' disabled.", base.GetType().ToString()));
				return false;
			}
			return true;
		}

		// Token: 0x17000070 RID: 112
		// (get) Token: 0x060021B9 RID: 8633 RVA: 0x000EC183 File Offset: 0x000EA383
		// (set) Token: 0x060021C0 RID: 8640 RVA: 0x000EC342 File Offset: 0x000EA542
		public float LFBIBCKCLDM
		{
			get
			{
				return this.amount;
			}
			set
			{
				this.amount = value;
			}
		}

		// Token: 0x17000073 RID: 115
		// (get) Token: 0x060021BA RID: 8634
		protected abstract string AAALPPMCHPA { get; }

		// Token: 0x17000071 RID: 113
		// (get) Token: 0x060021C2 RID: 8642 RVA: 0x000EC377 File Offset: 0x000EA577
		// (set) Token: 0x060021BB RID: 8635 RVA: 0x000EC18B File Offset: 0x000EA38B
		public Shader JKKILKDCIFM
		{
			get
			{
				return this.NGKPCCCJJCP;
			}
			set
			{
				if (this.NGKPCCCJJCP != value)
				{
					this.NGKPCCCJJCP = value;
					this.KFPOHAACMJE();
				}
			}
		}

		// Token: 0x060021BC RID: 8636 RVA: 0x000EC1A8 File Offset: 0x000EA3A8
		public virtual void ResetDefaultValues()
		{
			this.amount = 1f;
			this.brightness = 0f;
			this.contrast = 0f;
			this.gamma = 1f;
			this.saturation = 1f;
		}

		// Token: 0x060021BD RID: 8637 RVA: 0x000EC1E4 File Offset: 0x000EA3E4
		protected virtual void OFLNJNCBAHK()
		{
			this.IAFHOKDBDLF.SetFloat("_Amount", this.amount);
			this.IAFHOKDBDLF.SetFloat("_Brightness", this.brightness);
			this.IAFHOKDBDLF.SetFloat("_Contrast", this.contrast + 1f);
			this.IAFHOKDBDLF.SetFloat("_Gamma", 1f / this.gamma);
			this.IAFHOKDBDLF.SetFloat("_Saturation", this.saturation);
		}

		// Token: 0x060021BE RID: 8638 RVA: 0x000EC26C File Offset: 0x000EA46C
		private void Start()
		{
			if (this.FOBNDGDDMBN())
			{
				this.NGKPCCCJJCP = Resources.Load<Shader>(this.AAALPPMCHPA);
				if (!(this.NGKPCCCJJCP != null))
				{
					Debug.LogError(string.Format("'{0}' shader not found.", this.AAALPPMCHPA));
					base.enabled = false;
					return;
				}
				if (!this.NGKPCCCJJCP.isSupported)
				{
					Debug.LogWarning(string.Format("'{0}' shader not supported.", base.GetType().ToString()));
					base.enabled = false;
					return;
				}
				this.KFPOHAACMJE();
				if (this.IAFHOKDBDLF == null)
				{
					Debug.LogWarning(string.Format("'{0}' material null.", base.name));
					base.enabled = false;
					return;
				}
			}
			else
			{
				base.enabled = false;
			}
		}

		// Token: 0x060021BF RID: 8639 RVA: 0x000EC327 File Offset: 0x000EA527
		protected virtual void OnDestroy()
		{
			if (this.IAFHOKDBDLF != null)
			{
				UnityEngine.Object.DestroyImmediate(this.IAFHOKDBDLF);
			}
		}

		// Token: 0x060021C1 RID: 8641 RVA: 0x000EC34B File Offset: 0x000EA54B
		protected virtual void KFPOHAACMJE()
		{
			if (this.IAFHOKDBDLF != null)
			{
				UnityEngine.Object.DestroyImmediate(this.IAFHOKDBDLF);
			}
			this.IAFHOKDBDLF = new Material(this.NGKPCCCJJCP);
		}

		// Token: 0x060021C4 RID: 8644 RVA: 0x000EC3A8 File Offset: 0x000EA5A8
		private void OnRenderImage(RenderTexture AFNODOLBBKG, RenderTexture FAEOBMIDDPN)
		{
			if (this.IAFHOKDBDLF != null)
			{
				this.OFLNJNCBAHK();
				Graphics.Blit(AFNODOLBBKG, FAEOBMIDDPN, this.IAFHOKDBDLF, (QualitySettings.activeColorSpace == ColorSpace.Linear) ? 1 : 0);
			}
		}

		// Token: 0x17000072 RID: 114
		// (get) Token: 0x060021C5 RID: 8645 RVA: 0x000EC3D7 File Offset: 0x000EA5D7
		public Material AGBEEEFAAHO
		{
			get
			{
				if (this.IAFHOKDBDLF == null && this.NGKPCCCJJCP != null)
				{
					this.KFPOHAACMJE();
				}
				return this.IAFHOKDBDLF;
			}
		}

		// Token: 0x04000990 RID: 2448
		public float amount = 1f;

		// Token: 0x04000991 RID: 2449
		public float brightness;

		// Token: 0x04000992 RID: 2450
		public float contrast;

		// Token: 0x04000993 RID: 2451
		public float saturation = 1f;

		// Token: 0x04000994 RID: 2452
		public float gamma = 1f;

		// Token: 0x04000995 RID: 2453
		private Shader NGKPCCCJJCP;

		// Token: 0x04000996 RID: 2454
		private Material IAFHOKDBDLF;

		// Token: 0x04000997 RID: 2455
		private const string KMFHKGHHCHF = "_Amount";

		// Token: 0x04000998 RID: 2456
		private const string JHELCJKJAMI = "_Brightness";

		// Token: 0x04000999 RID: 2457
		private const string DGOGMGCGGML = "_Contrast";

		// Token: 0x0400099A RID: 2458
		private const string BEOPDPNIPDJ = "_Gamma";

		// Token: 0x0400099B RID: 2459
		private const string KMLMPOCBDEM = "_Saturation";
	}
}
