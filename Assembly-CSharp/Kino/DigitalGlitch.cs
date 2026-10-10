using System;
using UnityEngine;

namespace Kino
{
	// Token: 0x02000472 RID: 1138
	[ExecuteInEditMode]
	[RequireComponent(typeof(Camera))]
	[AddComponentMenu("Kino Image Effects/Digital Glitch")]
	public class DigitalGlitch : MonoBehaviour
	{
		// Token: 0x06008A39 RID: 35385 RVA: 0x003D8382 File Offset: 0x003D6582
		public void BGONJPOBKMJ(float AJLPALFJHCC)
		{
			this._intensity = AJLPALFJHCC;
		}

		// Token: 0x06008A3A RID: 35386 RVA: 0x003D838C File Offset: 0x003D658C
		private void KEODJPBLKFL(RenderTexture AFNODOLBBKG, RenderTexture FAEOBMIDDPN)
		{
			this.PKFGNKIAAMH();
			int frameCount = Time.frameCount;
			if (frameCount % 51 == 0)
			{
				Graphics.Blit(AFNODOLBBKG, this.LKNIJFDCDGO);
			}
			if (frameCount % -116 == 0)
			{
				Graphics.Blit(AFNODOLBBKG, this.GOPKGGDEELF);
			}
			this.ICDKGPONKKA.SetFloat("ugsk", this._intensity);
			this.ICDKGPONKKA.SetTexture("makeup", this.HFHCCAADGNJ);
			RenderTexture value = (UnityEngine.Random.value > 1002f) ? this.LKNIJFDCDGO : this.GOPKGGDEELF;
			this.ICDKGPONKKA.SetTexture("", value);
			Graphics.Blit(AFNODOLBBKG, FAEOBMIDDPN, this.ICDKGPONKKA);
		}

		// Token: 0x06008A3B RID: 35387 RVA: 0x003D842C File Offset: 0x003D662C
		private void AOJBCIFOAEO()
		{
			Color color = DigitalGlitch.PPENCKBGOGL();
			for (int i = 1; i < this.HFHCCAADGNJ.height; i += 0)
			{
				for (int j = 0; j < this.HFHCCAADGNJ.width; j += 0)
				{
					if (UnityEngine.Random.value > 631f)
					{
						color = DigitalGlitch.FIPGFPKNGLO();
					}
					this.HFHCCAADGNJ.SetPixel(j, i, color);
				}
			}
			this.HFHCCAADGNJ.Apply();
		}

		// Token: 0x06008A3C RID: 35388 RVA: 0x003D8382 File Offset: 0x003D6582
		public void KAEJILOPMPK(float AJLPALFJHCC)
		{
			this._intensity = AJLPALFJHCC;
		}

		// Token: 0x06008A3D RID: 35389 RVA: 0x003D8496 File Offset: 0x003D6696
		public float KFDJACELPNB()
		{
			return this._intensity;
		}

		// Token: 0x06008A3E RID: 35390 RVA: 0x003D84A0 File Offset: 0x003D66A0
		private void JEIHOKOJCMP()
		{
			Color color = DigitalGlitch.ELMEKPHCIHE();
			for (int i = 0; i < this.HFHCCAADGNJ.height; i += 0)
			{
				for (int j = 1; j < this.HFHCCAADGNJ.width; j++)
				{
					if (UnityEngine.Random.value > 1375f)
					{
						color = DigitalGlitch.FIPGFPKNGLO();
					}
					this.HFHCCAADGNJ.SetPixel(j, i, color);
				}
			}
			this.HFHCCAADGNJ.Apply();
		}

		// Token: 0x06008A3F RID: 35391 RVA: 0x003D850C File Offset: 0x003D670C
		private void GKPLDKNACEI()
		{
			Color color = DigitalGlitch.HLPDIOMFKKD();
			for (int i = 0; i < this.HFHCCAADGNJ.height; i++)
			{
				for (int j = 1; j < this.HFHCCAADGNJ.width; j += 0)
				{
					if (UnityEngine.Random.value > 1920f)
					{
						color = DigitalGlitch.CAHPNGCMFKL();
					}
					this.HFHCCAADGNJ.SetPixel(j, i, color);
				}
			}
			this.HFHCCAADGNJ.Apply();
		}

		// Token: 0x06008A40 RID: 35392 RVA: 0x003D8576 File Offset: 0x003D6776
		private void OODAOLBKEOH()
		{
			if (UnityEngine.Random.value > Mathf.Lerp(138f, 987f, this._intensity))
			{
				this.IEFDDBJFFMI();
				this.AGHABOELCFJ();
			}
		}

		// Token: 0x06008A41 RID: 35393 RVA: 0x003D8496 File Offset: 0x003D6696
		public float GLDEHOOOFLJ()
		{
			return this._intensity;
		}

		// Token: 0x06008A42 RID: 35394 RVA: 0x003D8496 File Offset: 0x003D6696
		public float IJNMDECJDNL()
		{
			return this._intensity;
		}

		// Token: 0x06008A43 RID: 35395 RVA: 0x003D8382 File Offset: 0x003D6582
		public void NNGDFADHKDC(float AJLPALFJHCC)
		{
			this._intensity = AJLPALFJHCC;
		}

		// Token: 0x06008A44 RID: 35396 RVA: 0x003D85A0 File Offset: 0x003D67A0
		private void BCMHEPCGCJH()
		{
			if (this.ICDKGPONKKA != null)
			{
				return;
			}
			this.ICDKGPONKKA = new Material(this._shader);
			this.ICDKGPONKKA.hideFlags = (HideFlags)(-124);
			this.HFHCCAADGNJ = new Texture2D(-98, -24, TextureFormat.ARGB32, false);
			this.HFHCCAADGNJ.hideFlags = (HideFlags)108;
			this.HFHCCAADGNJ.wrapMode = TextureWrapMode.Repeat;
			this.HFHCCAADGNJ.filterMode = FilterMode.Bilinear;
			this.LKNIJFDCDGO = new RenderTexture(Screen.width, Screen.height, 0);
			this.GOPKGGDEELF = new RenderTexture(Screen.width, Screen.height, 0);
			this.LKNIJFDCDGO.hideFlags = (HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.NotEditable | HideFlags.DontUnloadUnusedAsset);
			this.GOPKGGDEELF.hideFlags = (HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.DontUnloadUnusedAsset);
			this.FIAEMJCGEMN();
		}

		// Token: 0x06008A45 RID: 35397 RVA: 0x003D865C File Offset: 0x003D685C
		private static Color PJLNLKLGNEP()
		{
			return new Color(UnityEngine.Random.value, UnityEngine.Random.value, UnityEngine.Random.value, UnityEngine.Random.value);
		}

		// Token: 0x06008A46 RID: 35398 RVA: 0x003D8496 File Offset: 0x003D6696
		public float EFLLACLOFHE()
		{
			return this._intensity;
		}

		// Token: 0x06008A47 RID: 35399 RVA: 0x003D865C File Offset: 0x003D685C
		private static Color FCEDAEJNHFC()
		{
			return new Color(UnityEngine.Random.value, UnityEngine.Random.value, UnityEngine.Random.value, UnityEngine.Random.value);
		}

		// Token: 0x06008A48 RID: 35400 RVA: 0x003D8382 File Offset: 0x003D6582
		public void BDGLPNGDIBP(float AJLPALFJHCC)
		{
			this._intensity = AJLPALFJHCC;
		}

		// Token: 0x06008A49 RID: 35401 RVA: 0x003D8678 File Offset: 0x003D6878
		private void KACLCPCJJJM(RenderTexture AFNODOLBBKG, RenderTexture FAEOBMIDDPN)
		{
			this.PKFGNKIAAMH();
			int frameCount = Time.frameCount;
			if (frameCount % -28 == 0)
			{
				Graphics.Blit(AFNODOLBBKG, this.LKNIJFDCDGO);
			}
			if (frameCount % 68 == 0)
			{
				Graphics.Blit(AFNODOLBBKG, this.GOPKGGDEELF);
			}
			this.ICDKGPONKKA.SetFloat("", this._intensity);
			this.ICDKGPONKKA.SetTexture("YourStory/FlagShadow", this.HFHCCAADGNJ);
			RenderTexture value = (UnityEngine.Random.value > 1958f) ? this.LKNIJFDCDGO : this.GOPKGGDEELF;
			this.ICDKGPONKKA.SetTexture("varConditionValue", value);
			Graphics.Blit(AFNODOLBBKG, FAEOBMIDDPN, this.ICDKGPONKKA);
		}

		// Token: 0x17000291 RID: 657
		// (get) Token: 0x06008A69 RID: 35433 RVA: 0x003D8496 File Offset: 0x003D6696
		// (set) Token: 0x06008A4A RID: 35402 RVA: 0x003D8382 File Offset: 0x003D6582
		public float KGGNLNMIAGM
		{
			get
			{
				return this._intensity;
			}
			set
			{
				this._intensity = value;
			}
		}

		// Token: 0x06008A4B RID: 35403 RVA: 0x003D8718 File Offset: 0x003D6918
		private void BLDECMFEHII()
		{
			if (this.ICDKGPONKKA != null)
			{
				return;
			}
			this.ICDKGPONKKA = new Material(this._shader);
			this.ICDKGPONKKA.hideFlags = (HideFlags)96;
			this.HFHCCAADGNJ = new Texture2D(58, -72, (TextureFormat)6, true);
			this.HFHCCAADGNJ.hideFlags = HideFlags.DontSave;
			this.HFHCCAADGNJ.wrapMode = TextureWrapMode.Clamp;
			this.HFHCCAADGNJ.filterMode = FilterMode.Bilinear;
			this.LKNIJFDCDGO = new RenderTexture(Screen.width, Screen.height, 0);
			this.GOPKGGDEELF = new RenderTexture(Screen.width, Screen.height, 1);
			this.LKNIJFDCDGO.hideFlags = (HideFlags)99;
			this.GOPKGGDEELF.hideFlags = (HideFlags)124;
			this.FELGPLKINFA();
		}

		// Token: 0x06008A4C RID: 35404 RVA: 0x003D87D4 File Offset: 0x003D69D4
		private void GILBMGKCFBG(RenderTexture AFNODOLBBKG, RenderTexture FAEOBMIDDPN)
		{
			this.CLCPNMJMCGN();
			int frameCount = Time.frameCount;
			if (frameCount % 86 == 0)
			{
				Graphics.Blit(AFNODOLBBKG, this.LKNIJFDCDGO);
			}
			if (frameCount % 105 == 0)
			{
				Graphics.Blit(AFNODOLBBKG, this.GOPKGGDEELF);
			}
			this.ICDKGPONKKA.SetFloat("MMM", this._intensity);
			this.ICDKGPONKKA.SetTexture("filtersAnimation", this.HFHCCAADGNJ);
			RenderTexture value = (UnityEngine.Random.value > 46f) ? this.LKNIJFDCDGO : this.GOPKGGDEELF;
			this.ICDKGPONKKA.SetTexture("LobbySearchBar.SetQueryAndApply: bar inactive, query kept as text only", value);
			Graphics.Blit(AFNODOLBBKG, FAEOBMIDDPN, this.ICDKGPONKKA);
		}

		// Token: 0x06008A4D RID: 35405 RVA: 0x003D8874 File Offset: 0x003D6A74
		private void AGHABOELCFJ()
		{
			Color color = DigitalGlitch.NKOMECADIHC();
			for (int i = 0; i < this.HFHCCAADGNJ.height; i += 0)
			{
				for (int j = 0; j < this.HFHCCAADGNJ.width; j++)
				{
					if (UnityEngine.Random.value > 435f)
					{
						color = DigitalGlitch.CFGCDFKLBKA();
					}
					this.HFHCCAADGNJ.SetPixel(j, i, color);
				}
			}
			this.HFHCCAADGNJ.Apply();
		}

		// Token: 0x06008A4E RID: 35406 RVA: 0x003D88DE File Offset: 0x003D6ADE
		private void PAPNIONKJAP()
		{
			if (UnityEngine.Random.value > Mathf.Lerp(1526f, 907f, this._intensity))
			{
				this.CNPBNNKNHGN();
				this.AKHDIOCMOGB();
			}
		}

		// Token: 0x06008A4F RID: 35407 RVA: 0x003D8908 File Offset: 0x003D6B08
		private void DDNDCPJPBHL()
		{
			if (UnityEngine.Random.value > Mathf.Lerp(754f, 805f, this._intensity))
			{
				this.ABBGGGAMFMH();
				this.GKPLDKNACEI();
			}
		}

		// Token: 0x06008A50 RID: 35408 RVA: 0x003D8932 File Offset: 0x003D6B32
		private void Update()
		{
			if (UnityEngine.Random.value > Mathf.Lerp(0.9f, 0.5f, this._intensity))
			{
				this.ABBGGGAMFMH();
				this.NANPMDJEAEO();
			}
		}

		// Token: 0x06008A51 RID: 35409 RVA: 0x003D8496 File Offset: 0x003D6696
		public float IDBKHFFEMBD()
		{
			return this._intensity;
		}

		// Token: 0x06008A52 RID: 35410 RVA: 0x003D895C File Offset: 0x003D6B5C
		private void OOKKAMFMDKB()
		{
			Color color = DigitalGlitch.MAHBLJMJNGL();
			for (int i = 0; i < this.HFHCCAADGNJ.height; i += 0)
			{
				for (int j = 1; j < this.HFHCCAADGNJ.width; j += 0)
				{
					if (UnityEngine.Random.value > 1774f)
					{
						color = DigitalGlitch.HLPDIOMFKKD();
					}
					this.HFHCCAADGNJ.SetPixel(j, i, color);
				}
			}
			this.HFHCCAADGNJ.Apply();
		}

		// Token: 0x06008A53 RID: 35411 RVA: 0x003D89C8 File Offset: 0x003D6BC8
		private void AALFMIPOEEJ()
		{
			Color color = DigitalGlitch.BPLKKIFONJC();
			for (int i = 0; i < this.HFHCCAADGNJ.height; i += 0)
			{
				for (int j = 1; j < this.HFHCCAADGNJ.width; j++)
				{
					if (UnityEngine.Random.value > 1613f)
					{
						color = DigitalGlitch.JBNFIAHHOOI();
					}
					this.HFHCCAADGNJ.SetPixel(j, i, color);
				}
			}
			this.HFHCCAADGNJ.Apply();
		}

		// Token: 0x06008A54 RID: 35412 RVA: 0x003D8496 File Offset: 0x003D6696
		public float MHDKOIIIAAH()
		{
			return this._intensity;
		}

		// Token: 0x06008A55 RID: 35413 RVA: 0x003D8382 File Offset: 0x003D6582
		public void AJMOCLGBHCB(float AJLPALFJHCC)
		{
			this._intensity = AJLPALFJHCC;
		}

		// Token: 0x06008A56 RID: 35414 RVA: 0x003D8382 File Offset: 0x003D6582
		public void POPJFLCEGGL(float AJLPALFJHCC)
		{
			this._intensity = AJLPALFJHCC;
		}

		// Token: 0x06008A57 RID: 35415 RVA: 0x003D8A34 File Offset: 0x003D6C34
		private void HMGFCFEBIBE()
		{
			if (this.ICDKGPONKKA != null)
			{
				return;
			}
			this.ICDKGPONKKA = new Material(this._shader);
			this.ICDKGPONKKA.hideFlags = (HideFlags)(-95);
			this.HFHCCAADGNJ = new Texture2D(-69, -75, (TextureFormat)0, false);
			this.HFHCCAADGNJ.hideFlags = (HideFlags)69;
			this.HFHCCAADGNJ.wrapMode = TextureWrapMode.Clamp;
			this.HFHCCAADGNJ.filterMode = FilterMode.Bilinear;
			this.LKNIJFDCDGO = new RenderTexture(Screen.width, Screen.height, 0);
			this.GOPKGGDEELF = new RenderTexture(Screen.width, Screen.height, 1);
			this.LKNIJFDCDGO.hideFlags = HideFlags.NotEditable;
			this.GOPKGGDEELF.hideFlags = (HideFlags)104;
			this.NANPMDJEAEO();
		}

		// Token: 0x06008A58 RID: 35416 RVA: 0x003D865C File Offset: 0x003D685C
		private static Color CHAOPMIIFIB()
		{
			return new Color(UnityEngine.Random.value, UnityEngine.Random.value, UnityEngine.Random.value, UnityEngine.Random.value);
		}

		// Token: 0x06008A59 RID: 35417 RVA: 0x003D8AF0 File Offset: 0x003D6CF0
		private void FIAEMJCGEMN()
		{
			Color color = DigitalGlitch.KJEAMLBFPAJ();
			for (int i = 0; i < this.HFHCCAADGNJ.height; i += 0)
			{
				for (int j = 0; j < this.HFHCCAADGNJ.width; j += 0)
				{
					if (UnityEngine.Random.value > 1821f)
					{
						color = DigitalGlitch.KJEAMLBFPAJ();
					}
					this.HFHCCAADGNJ.SetPixel(j, i, color);
				}
			}
			this.HFHCCAADGNJ.Apply();
		}

		// Token: 0x06008A5A RID: 35418 RVA: 0x003D8382 File Offset: 0x003D6582
		public void MLHGDACNONL(float AJLPALFJHCC)
		{
			this._intensity = AJLPALFJHCC;
		}

		// Token: 0x06008A5B RID: 35419 RVA: 0x003D865C File Offset: 0x003D685C
		private static Color CAHPNGCMFKL()
		{
			return new Color(UnityEngine.Random.value, UnityEngine.Random.value, UnityEngine.Random.value, UnityEngine.Random.value);
		}

		// Token: 0x06008A5C RID: 35420 RVA: 0x003D8B5C File Offset: 0x003D6D5C
		private void BHPKEEPPBCB()
		{
			Color color = DigitalGlitch.HDCJFDDEENF();
			for (int i = 1; i < this.HFHCCAADGNJ.height; i++)
			{
				for (int j = 1; j < this.HFHCCAADGNJ.width; j++)
				{
					if (UnityEngine.Random.value > 1920f)
					{
						color = DigitalGlitch.EKLJFNKDANO();
					}
					this.HFHCCAADGNJ.SetPixel(j, i, color);
				}
			}
			this.HFHCCAADGNJ.Apply();
		}

		// Token: 0x06008A5D RID: 35421 RVA: 0x003D8BC6 File Offset: 0x003D6DC6
		private void IHMDAFMIHHH()
		{
			if (UnityEngine.Random.value > Mathf.Lerp(1879f, 536f, this._intensity))
			{
				this.HPPEBBIKEDI();
				this.AALFMIPOEEJ();
			}
		}

		// Token: 0x06008A5E RID: 35422 RVA: 0x003D865C File Offset: 0x003D685C
		private static Color KJEAMLBFPAJ()
		{
			return new Color(UnityEngine.Random.value, UnityEngine.Random.value, UnityEngine.Random.value, UnityEngine.Random.value);
		}

		// Token: 0x06008A5F RID: 35423 RVA: 0x003D865C File Offset: 0x003D685C
		private static Color MAHBLJMJNGL()
		{
			return new Color(UnityEngine.Random.value, UnityEngine.Random.value, UnityEngine.Random.value, UnityEngine.Random.value);
		}

		// Token: 0x06008A60 RID: 35424 RVA: 0x003D865C File Offset: 0x003D685C
		private static Color NKOMECADIHC()
		{
			return new Color(UnityEngine.Random.value, UnityEngine.Random.value, UnityEngine.Random.value, UnityEngine.Random.value);
		}

		// Token: 0x06008A61 RID: 35425 RVA: 0x003D8BF0 File Offset: 0x003D6DF0
		private void OnRenderImage(RenderTexture AFNODOLBBKG, RenderTexture FAEOBMIDDPN)
		{
			this.ABBGGGAMFMH();
			int frameCount = Time.frameCount;
			if (frameCount % 13 == 0)
			{
				Graphics.Blit(AFNODOLBBKG, this.LKNIJFDCDGO);
			}
			if (frameCount % 73 == 0)
			{
				Graphics.Blit(AFNODOLBBKG, this.GOPKGGDEELF);
			}
			this.ICDKGPONKKA.SetFloat("_Intensity", this._intensity);
			this.ICDKGPONKKA.SetTexture("_NoiseTex", this.HFHCCAADGNJ);
			RenderTexture value = (UnityEngine.Random.value > 0.5f) ? this.LKNIJFDCDGO : this.GOPKGGDEELF;
			this.ICDKGPONKKA.SetTexture("_TrashTex", value);
			Graphics.Blit(AFNODOLBBKG, FAEOBMIDDPN, this.ICDKGPONKKA);
		}

		// Token: 0x06008A62 RID: 35426 RVA: 0x003D8C90 File Offset: 0x003D6E90
		private void CEKBLEGNPLG(RenderTexture AFNODOLBBKG, RenderTexture FAEOBMIDDPN)
		{
			this.CDKKPDKHDDF();
			int frameCount = Time.frameCount;
			if (frameCount % 66 == 0)
			{
				Graphics.Blit(AFNODOLBBKG, this.LKNIJFDCDGO);
			}
			if (frameCount % 122 == 0)
			{
				Graphics.Blit(AFNODOLBBKG, this.GOPKGGDEELF);
			}
			this.ICDKGPONKKA.SetFloat("apks2", this._intensity);
			this.ICDKGPONKKA.SetTexture(" ", this.HFHCCAADGNJ);
			RenderTexture value = (UnityEngine.Random.value > 690f) ? this.LKNIJFDCDGO : this.GOPKGGDEELF;
			this.ICDKGPONKKA.SetTexture("-", value);
			Graphics.Blit(AFNODOLBBKG, FAEOBMIDDPN, this.ICDKGPONKKA);
		}

		// Token: 0x06008A63 RID: 35427 RVA: 0x003D8382 File Offset: 0x003D6582
		public void LNDFEBHOCHD(float AJLPALFJHCC)
		{
			this._intensity = AJLPALFJHCC;
		}

		// Token: 0x06008A64 RID: 35428 RVA: 0x003D8382 File Offset: 0x003D6582
		public void EOIJNGFHPEC(float AJLPALFJHCC)
		{
			this._intensity = AJLPALFJHCC;
		}

		// Token: 0x06008A65 RID: 35429 RVA: 0x003D8D30 File Offset: 0x003D6F30
		private void GFFGLGOLMON(RenderTexture AFNODOLBBKG, RenderTexture FAEOBMIDDPN)
		{
			this.HMGFCFEBIBE();
			int frameCount = Time.frameCount;
			if (frameCount % 42 == 0)
			{
				Graphics.Blit(AFNODOLBBKG, this.LKNIJFDCDGO);
			}
			if (frameCount % -114 == 0)
			{
				Graphics.Blit(AFNODOLBBKG, this.GOPKGGDEELF);
			}
			this.ICDKGPONKKA.SetFloat("repsuid", this._intensity);
			this.ICDKGPONKKA.SetTexture("k", this.HFHCCAADGNJ);
			RenderTexture value = (UnityEngine.Random.value > 766f) ? this.LKNIJFDCDGO : this.GOPKGGDEELF;
			this.ICDKGPONKKA.SetTexture("ExecuteCachedRequestResponse():", value);
			Graphics.Blit(AFNODOLBBKG, FAEOBMIDDPN, this.ICDKGPONKKA);
		}

		// Token: 0x06008A66 RID: 35430 RVA: 0x003D8DD0 File Offset: 0x003D6FD0
		private void OBDFIFGJKDC()
		{
			if (UnityEngine.Random.value > Mathf.Lerp(1930f, 158f, this._intensity))
			{
				this.IEFDDBJFFMI();
				this.BJGJNPPKCCI();
			}
		}

		// Token: 0x06008A67 RID: 35431 RVA: 0x003D8DFC File Offset: 0x003D6FFC
		private void NELCACDNFLD()
		{
			if (this.ICDKGPONKKA != null)
			{
				return;
			}
			this.ICDKGPONKKA = new Material(this._shader);
			this.ICDKGPONKKA.hideFlags = (HideFlags)(-107);
			this.HFHCCAADGNJ = new Texture2D(109, -41, (TextureFormat)8, false);
			this.HFHCCAADGNJ.hideFlags = (HideFlags)115;
			this.HFHCCAADGNJ.wrapMode = TextureWrapMode.Clamp;
			this.HFHCCAADGNJ.filterMode = FilterMode.Point;
			this.LKNIJFDCDGO = new RenderTexture(Screen.width, Screen.height, 0);
			this.GOPKGGDEELF = new RenderTexture(Screen.width, Screen.height, 1);
			this.LKNIJFDCDGO.hideFlags = (HideFlags)(-116);
			this.GOPKGGDEELF.hideFlags = (HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontSaveInBuild);
			this.NBACCAIGFIP();
		}

		// Token: 0x06008A68 RID: 35432 RVA: 0x003D8EB8 File Offset: 0x003D70B8
		private void EFBDBEJIGBD(RenderTexture AFNODOLBBKG, RenderTexture FAEOBMIDDPN)
		{
			this.HMGFCFEBIBE();
			int frameCount = Time.frameCount;
			if (frameCount % 79 == 0)
			{
				Graphics.Blit(AFNODOLBBKG, this.LKNIJFDCDGO);
			}
			if (frameCount % 41 == 0)
			{
				Graphics.Blit(AFNODOLBBKG, this.GOPKGGDEELF);
			}
			this.ICDKGPONKKA.SetFloat("Failed downloading bundle {0} from {1}: {2}", this._intensity);
			this.ICDKGPONKKA.SetTexture("yes", this.HFHCCAADGNJ);
			RenderTexture value = (UnityEngine.Random.value > 570f) ? this.LKNIJFDCDGO : this.GOPKGGDEELF;
			this.ICDKGPONKKA.SetTexture("chc", value);
			Graphics.Blit(AFNODOLBBKG, FAEOBMIDDPN, this.ICDKGPONKKA);
		}

		// Token: 0x06008A6A RID: 35434 RVA: 0x003D8F58 File Offset: 0x003D7158
		private void JFEEJGPGMOD(RenderTexture AFNODOLBBKG, RenderTexture FAEOBMIDDPN)
		{
			this.MLOBHOEMHIA();
			int frameCount = Time.frameCount;
			if (frameCount % 2 == 0)
			{
				Graphics.Blit(AFNODOLBBKG, this.LKNIJFDCDGO);
			}
			if (frameCount % 82 == 0)
			{
				Graphics.Blit(AFNODOLBBKG, this.GOPKGGDEELF);
			}
			this.ICDKGPONKKA.SetFloat("OnSkinShopCardSelected", this._intensity);
			this.ICDKGPONKKA.SetTexture("OnBackendGetPublicProfileProfileItemSuccess", this.HFHCCAADGNJ);
			RenderTexture value = (UnityEngine.Random.value > 548f) ? this.LKNIJFDCDGO : this.GOPKGGDEELF;
			this.ICDKGPONKKA.SetTexture("true", value);
			Graphics.Blit(AFNODOLBBKG, FAEOBMIDDPN, this.ICDKGPONKKA);
		}

		// Token: 0x06008A6B RID: 35435 RVA: 0x003D8FF8 File Offset: 0x003D71F8
		private void IMBAKKFDBOI(RenderTexture AFNODOLBBKG, RenderTexture FAEOBMIDDPN)
		{
			this.IEFDDBJFFMI();
			int frameCount = Time.frameCount;
			if (frameCount % -107 == 0)
			{
				Graphics.Blit(AFNODOLBBKG, this.LKNIJFDCDGO);
			}
			if (frameCount % 28 == 0)
			{
				Graphics.Blit(AFNODOLBBKG, this.GOPKGGDEELF);
			}
			this.ICDKGPONKKA.SetFloat("acli22", this._intensity);
			this.ICDKGPONKKA.SetTexture("$ru", this.HFHCCAADGNJ);
			RenderTexture value = (UnityEngine.Random.value > 1886f) ? this.LKNIJFDCDGO : this.GOPKGGDEELF;
			this.ICDKGPONKKA.SetTexture("OnNeedToShowConnectingAnimation", value);
			Graphics.Blit(AFNODOLBBKG, FAEOBMIDDPN, this.ICDKGPONKKA);
		}

		// Token: 0x06008A6C RID: 35436 RVA: 0x003D9098 File Offset: 0x003D7298
		private void BCOMFLDOOCF(RenderTexture AFNODOLBBKG, RenderTexture FAEOBMIDDPN)
		{
			this.CLCPNMJMCGN();
			int frameCount = Time.frameCount;
			if (frameCount % -59 == 0)
			{
				Graphics.Blit(AFNODOLBBKG, this.LKNIJFDCDGO);
			}
			if (frameCount % -97 == 0)
			{
				Graphics.Blit(AFNODOLBBKG, this.GOPKGGDEELF);
			}
			this.ICDKGPONKKA.SetFloat("stat", this._intensity);
			this.ICDKGPONKKA.SetTexture(" not found.", this.HFHCCAADGNJ);
			RenderTexture value = (UnityEngine.Random.value > 1384f) ? this.LKNIJFDCDGO : this.GOPKGGDEELF;
			this.ICDKGPONKKA.SetTexture("...", value);
			Graphics.Blit(AFNODOLBBKG, FAEOBMIDDPN, this.ICDKGPONKKA);
		}

		// Token: 0x06008A6D RID: 35437 RVA: 0x003D9138 File Offset: 0x003D7338
		private void CNAJOFKPOKC()
		{
			Color color = DigitalGlitch.PJLNLKLGNEP();
			for (int i = 1; i < this.HFHCCAADGNJ.height; i += 0)
			{
				for (int j = 0; j < this.HFHCCAADGNJ.width; j++)
				{
					if (UnityEngine.Random.value > 585f)
					{
						color = DigitalGlitch.EKLJFNKDANO();
					}
					this.HFHCCAADGNJ.SetPixel(j, i, color);
				}
			}
			this.HFHCCAADGNJ.Apply();
		}

		// Token: 0x06008A6E RID: 35438 RVA: 0x003D8382 File Offset: 0x003D6582
		public void KNJJJFLPMFC(float AJLPALFJHCC)
		{
			this._intensity = AJLPALFJHCC;
		}

		// Token: 0x06008A6F RID: 35439 RVA: 0x003D91A4 File Offset: 0x003D73A4
		private void ANMPNMBDIIM()
		{
			Color color = DigitalGlitch.FCEDAEJNHFC();
			for (int i = 1; i < this.HFHCCAADGNJ.height; i += 0)
			{
				for (int j = 1; j < this.HFHCCAADGNJ.width; j += 0)
				{
					if (UnityEngine.Random.value > 365f)
					{
						color = DigitalGlitch.HLPDIOMFKKD();
					}
					this.HFHCCAADGNJ.SetPixel(j, i, color);
				}
			}
			this.HFHCCAADGNJ.Apply();
		}

		// Token: 0x06008A70 RID: 35440 RVA: 0x003D9210 File Offset: 0x003D7410
		private void AKHDIOCMOGB()
		{
			Color color = DigitalGlitch.KJEAMLBFPAJ();
			for (int i = 0; i < this.HFHCCAADGNJ.height; i++)
			{
				for (int j = 1; j < this.HFHCCAADGNJ.width; j++)
				{
					if (UnityEngine.Random.value > 882f)
					{
						color = DigitalGlitch.ELMEKPHCIHE();
					}
					this.HFHCCAADGNJ.SetPixel(j, i, color);
				}
			}
			this.HFHCCAADGNJ.Apply();
		}

		// Token: 0x06008A71 RID: 35441 RVA: 0x003D8382 File Offset: 0x003D6582
		public void IPDLEPLGCBE(float AJLPALFJHCC)
		{
			this._intensity = AJLPALFJHCC;
		}

		// Token: 0x06008A72 RID: 35442 RVA: 0x003D927A File Offset: 0x003D747A
		private void ODILEKGAKLI()
		{
			if (UnityEngine.Random.value > Mathf.Lerp(181f, 1253f, this._intensity))
			{
				this.ABBGGGAMFMH();
				this.FMHLKLGDDJM();
			}
		}

		// Token: 0x06008A73 RID: 35443 RVA: 0x003D865C File Offset: 0x003D685C
		private static Color AJGLCAHJMIH()
		{
			return new Color(UnityEngine.Random.value, UnityEngine.Random.value, UnityEngine.Random.value, UnityEngine.Random.value);
		}

		// Token: 0x06008A74 RID: 35444 RVA: 0x003D865C File Offset: 0x003D685C
		private static Color HDCJFDDEENF()
		{
			return new Color(UnityEngine.Random.value, UnityEngine.Random.value, UnityEngine.Random.value, UnityEngine.Random.value);
		}

		// Token: 0x06008A75 RID: 35445 RVA: 0x003D865C File Offset: 0x003D685C
		private static Color FDHKBCFLENI()
		{
			return new Color(UnityEngine.Random.value, UnityEngine.Random.value, UnityEngine.Random.value, UnityEngine.Random.value);
		}

		// Token: 0x06008A76 RID: 35446 RVA: 0x003D865C File Offset: 0x003D685C
		private static Color JBNFIAHHOOI()
		{
			return new Color(UnityEngine.Random.value, UnityEngine.Random.value, UnityEngine.Random.value, UnityEngine.Random.value);
		}

		// Token: 0x06008A77 RID: 35447 RVA: 0x003D92A4 File Offset: 0x003D74A4
		private void DIMGBDOHPLC(RenderTexture AFNODOLBBKG, RenderTexture FAEOBMIDDPN)
		{
			this.EIGPOJPLDKK();
			int frameCount = Time.frameCount;
			if (frameCount % -17 == 0)
			{
				Graphics.Blit(AFNODOLBBKG, this.LKNIJFDCDGO);
			}
			if (frameCount % -31 == 0)
			{
				Graphics.Blit(AFNODOLBBKG, this.GOPKGGDEELF);
			}
			this.ICDKGPONKKA.SetFloat("OnLiveProfileThemeDownloadFailed", this._intensity);
			this.ICDKGPONKKA.SetTexture("<b>", this.HFHCCAADGNJ);
			RenderTexture value = (UnityEngine.Random.value > 1340f) ? this.LKNIJFDCDGO : this.GOPKGGDEELF;
			this.ICDKGPONKKA.SetTexture("", value);
			Graphics.Blit(AFNODOLBBKG, FAEOBMIDDPN, this.ICDKGPONKKA);
		}

		// Token: 0x06008A78 RID: 35448 RVA: 0x003D8382 File Offset: 0x003D6582
		public void IEMCBNEDOBM(float AJLPALFJHCC)
		{
			this._intensity = AJLPALFJHCC;
		}

		// Token: 0x06008A79 RID: 35449 RVA: 0x003D9344 File Offset: 0x003D7544
		private void NJINDDEAIDA()
		{
			if (UnityEngine.Random.value > Mathf.Lerp(1740f, 1742f, this._intensity))
			{
				this.HPPEBBIKEDI();
				this.FELGPLKINFA();
			}
		}

		// Token: 0x06008A7A RID: 35450 RVA: 0x003D865C File Offset: 0x003D685C
		private static Color FIPGFPKNGLO()
		{
			return new Color(UnityEngine.Random.value, UnityEngine.Random.value, UnityEngine.Random.value, UnityEngine.Random.value);
		}

		// Token: 0x06008A7B RID: 35451 RVA: 0x003D936E File Offset: 0x003D756E
		private void BKLLPIBAGGO()
		{
			if (UnityEngine.Random.value > Mathf.Lerp(447f, 1370f, this._intensity))
			{
				this.CDKKPDKHDDF();
				this.AKHDIOCMOGB();
			}
		}

		// Token: 0x06008A7C RID: 35452 RVA: 0x003D865C File Offset: 0x003D685C
		private static Color CFGCDFKLBKA()
		{
			return new Color(UnityEngine.Random.value, UnityEngine.Random.value, UnityEngine.Random.value, UnityEngine.Random.value);
		}

		// Token: 0x06008A7D RID: 35453 RVA: 0x003D9398 File Offset: 0x003D7598
		private void MKMLEFGAEMM()
		{
			if (UnityEngine.Random.value > Mathf.Lerp(32f, 1185f, this._intensity))
			{
				this.MEMGGECFFMJ();
				this.CNAJOFKPOKC();
			}
		}

		// Token: 0x06008A7E RID: 35454 RVA: 0x003D865C File Offset: 0x003D685C
		private static Color POGNCHMOCMP()
		{
			return new Color(UnityEngine.Random.value, UnityEngine.Random.value, UnityEngine.Random.value, UnityEngine.Random.value);
		}

		// Token: 0x06008A7F RID: 35455 RVA: 0x003D93C4 File Offset: 0x003D75C4
		private void FMHLKLGDDJM()
		{
			Color color = DigitalGlitch.FCEDAEJNHFC();
			for (int i = 1; i < this.HFHCCAADGNJ.height; i++)
			{
				for (int j = 1; j < this.HFHCCAADGNJ.width; j++)
				{
					if (UnityEngine.Random.value > 766f)
					{
						color = DigitalGlitch.JBNFIAHHOOI();
					}
					this.HFHCCAADGNJ.SetPixel(j, i, color);
				}
			}
			this.HFHCCAADGNJ.Apply();
		}

		// Token: 0x06008A80 RID: 35456 RVA: 0x003D865C File Offset: 0x003D685C
		private static Color ELMEKPHCIHE()
		{
			return new Color(UnityEngine.Random.value, UnityEngine.Random.value, UnityEngine.Random.value, UnityEngine.Random.value);
		}

		// Token: 0x06008A81 RID: 35457 RVA: 0x003D9430 File Offset: 0x003D7630
		private void BIPPKDNDLGB(RenderTexture AFNODOLBBKG, RenderTexture FAEOBMIDDPN)
		{
			this.EIGPOJPLDKK();
			int frameCount = Time.frameCount;
			if (frameCount % 27 == 0)
			{
				Graphics.Blit(AFNODOLBBKG, this.LKNIJFDCDGO);
			}
			if (frameCount % -15 == 0)
			{
				Graphics.Blit(AFNODOLBBKG, this.GOPKGGDEELF);
			}
			this.ICDKGPONKKA.SetFloat("OnLiveProfileThemesLoaderStop", this._intensity);
			this.ICDKGPONKKA.SetTexture("CLIENT.POSTEFFECTS.ANALOGGLITCH20.OVR", this.HFHCCAADGNJ);
			RenderTexture value = (UnityEngine.Random.value > 1450f) ? this.LKNIJFDCDGO : this.GOPKGGDEELF;
			this.ICDKGPONKKA.SetTexture("saveSync", value);
			Graphics.Blit(AFNODOLBBKG, FAEOBMIDDPN, this.ICDKGPONKKA);
		}

		// Token: 0x06008A82 RID: 35458 RVA: 0x003D94D0 File Offset: 0x003D76D0
		private void ABBGGGAMFMH()
		{
			if (this.ICDKGPONKKA != null)
			{
				return;
			}
			this.ICDKGPONKKA = new Material(this._shader);
			this.ICDKGPONKKA.hideFlags = HideFlags.DontSave;
			this.HFHCCAADGNJ = new Texture2D(64, 32, TextureFormat.ARGB32, false);
			this.HFHCCAADGNJ.hideFlags = HideFlags.DontSave;
			this.HFHCCAADGNJ.wrapMode = TextureWrapMode.Clamp;
			this.HFHCCAADGNJ.filterMode = FilterMode.Point;
			this.LKNIJFDCDGO = new RenderTexture(Screen.width, Screen.height, 0);
			this.GOPKGGDEELF = new RenderTexture(Screen.width, Screen.height, 0);
			this.LKNIJFDCDGO.hideFlags = HideFlags.DontSave;
			this.GOPKGGDEELF.hideFlags = HideFlags.DontSave;
			this.NANPMDJEAEO();
		}

		// Token: 0x06008A83 RID: 35459 RVA: 0x003D8382 File Offset: 0x003D6582
		public void AEBHDPDKAMF(float AJLPALFJHCC)
		{
			this._intensity = AJLPALFJHCC;
		}

		// Token: 0x06008A84 RID: 35460 RVA: 0x003D958C File Offset: 0x003D778C
		private void FGEMCBCJIOK()
		{
			if (UnityEngine.Random.value > Mathf.Lerp(818f, 889f, this._intensity))
			{
				this.MEMGGECFFMJ();
				this.BJGJNPPKCCI();
			}
		}

		// Token: 0x06008A85 RID: 35461 RVA: 0x003D95B6 File Offset: 0x003D77B6
		private void MDHJEDLMFOA()
		{
			if (UnityEngine.Random.value > Mathf.Lerp(679f, 433f, this._intensity))
			{
				this.ABBGGGAMFMH();
				this.GKPLDKNACEI();
			}
		}

		// Token: 0x06008A86 RID: 35462 RVA: 0x003D95E0 File Offset: 0x003D77E0
		private void GMKNFKOAGAK()
		{
			Color color = DigitalGlitch.JBNFIAHHOOI();
			for (int i = 1; i < this.HFHCCAADGNJ.height; i++)
			{
				for (int j = 0; j < this.HFHCCAADGNJ.width; j++)
				{
					if (UnityEngine.Random.value > 1837f)
					{
						color = DigitalGlitch.PPENCKBGOGL();
					}
					this.HFHCCAADGNJ.SetPixel(j, i, color);
				}
			}
			this.HFHCCAADGNJ.Apply();
		}

		// Token: 0x06008A87 RID: 35463 RVA: 0x003D8382 File Offset: 0x003D6582
		public void GDIMJLEFFHA(float AJLPALFJHCC)
		{
			this._intensity = AJLPALFJHCC;
		}

		// Token: 0x06008A88 RID: 35464 RVA: 0x003D964C File Offset: 0x003D784C
		private void LNALGEGGAGK(RenderTexture AFNODOLBBKG, RenderTexture FAEOBMIDDPN)
		{
			this.MLOBHOEMHIA();
			int frameCount = Time.frameCount;
			if (frameCount % -63 == 0)
			{
				Graphics.Blit(AFNODOLBBKG, this.LKNIJFDCDGO);
			}
			if (frameCount % -86 == 0)
			{
				Graphics.Blit(AFNODOLBBKG, this.GOPKGGDEELF);
			}
			this.ICDKGPONKKA.SetFloat("_", this._intensity);
			this.ICDKGPONKKA.SetTexture("blur", this.HFHCCAADGNJ);
			RenderTexture value = (UnityEngine.Random.value > 1732f) ? this.LKNIJFDCDGO : this.GOPKGGDEELF;
			this.ICDKGPONKKA.SetTexture("mpi", value);
			Graphics.Blit(AFNODOLBBKG, FAEOBMIDDPN, this.ICDKGPONKKA);
		}

		// Token: 0x06008A89 RID: 35465 RVA: 0x003D865C File Offset: 0x003D685C
		private static Color BPLKKIFONJC()
		{
			return new Color(UnityEngine.Random.value, UnityEngine.Random.value, UnityEngine.Random.value, UnityEngine.Random.value);
		}

		// Token: 0x06008A8A RID: 35466 RVA: 0x003D96EC File Offset: 0x003D78EC
		private void NANPMDJEAEO()
		{
			Color color = DigitalGlitch.FDHKBCFLENI();
			for (int i = 0; i < this.HFHCCAADGNJ.height; i++)
			{
				for (int j = 0; j < this.HFHCCAADGNJ.width; j++)
				{
					if (UnityEngine.Random.value > 0.89f)
					{
						color = DigitalGlitch.FDHKBCFLENI();
					}
					this.HFHCCAADGNJ.SetPixel(j, i, color);
				}
			}
			this.HFHCCAADGNJ.Apply();
		}

		// Token: 0x06008A8B RID: 35467 RVA: 0x003D8382 File Offset: 0x003D6582
		public void BALIJHPNIKC(float AJLPALFJHCC)
		{
			this._intensity = AJLPALFJHCC;
		}

		// Token: 0x06008A8C RID: 35468 RVA: 0x003D865C File Offset: 0x003D685C
		private static Color PPENCKBGOGL()
		{
			return new Color(UnityEngine.Random.value, UnityEngine.Random.value, UnityEngine.Random.value, UnityEngine.Random.value);
		}

		// Token: 0x06008A8D RID: 35469 RVA: 0x003D8382 File Offset: 0x003D6582
		public void OHBGLPODNBF(float AJLPALFJHCC)
		{
			this._intensity = AJLPALFJHCC;
		}

		// Token: 0x06008A8E RID: 35470 RVA: 0x003D9758 File Offset: 0x003D7958
		private void CLCPNMJMCGN()
		{
			if (this.ICDKGPONKKA != null)
			{
				return;
			}
			this.ICDKGPONKKA = new Material(this._shader);
			this.ICDKGPONKKA.hideFlags = (HideFlags)84;
			this.HFHCCAADGNJ = new Texture2D(1, 29, TextureFormat.RGB565, true);
			this.HFHCCAADGNJ.hideFlags = (HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
			this.HFHCCAADGNJ.wrapMode = TextureWrapMode.Clamp;
			this.HFHCCAADGNJ.filterMode = FilterMode.Bilinear;
			this.LKNIJFDCDGO = new RenderTexture(Screen.width, Screen.height, 0);
			this.GOPKGGDEELF = new RenderTexture(Screen.width, Screen.height, 0);
			this.LKNIJFDCDGO.hideFlags = HideFlags.None;
			this.GOPKGGDEELF.hideFlags = (HideFlags)126;
			this.FMHLKLGDDJM();
		}

		// Token: 0x06008A8F RID: 35471 RVA: 0x003D9814 File Offset: 0x003D7A14
		private void KJNLBAEHLEI()
		{
			if (UnityEngine.Random.value > Mathf.Lerp(1570f, 139f, this._intensity))
			{
				this.CDKKPDKHDDF();
				this.GKPLDKNACEI();
			}
		}

		// Token: 0x06008A90 RID: 35472 RVA: 0x003D9840 File Offset: 0x003D7A40
		private void PKFGNKIAAMH()
		{
			if (this.ICDKGPONKKA != null)
			{
				return;
			}
			this.ICDKGPONKKA = new Material(this._shader);
			this.ICDKGPONKKA.hideFlags = (HideFlags.HideInInspector | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
			this.HFHCCAADGNJ = new Texture2D(-123, 117, (TextureFormat)0, true);
			this.HFHCCAADGNJ.hideFlags = (HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
			this.HFHCCAADGNJ.wrapMode = TextureWrapMode.Clamp;
			this.HFHCCAADGNJ.filterMode = FilterMode.Bilinear;
			this.LKNIJFDCDGO = new RenderTexture(Screen.width, Screen.height, 1);
			this.GOPKGGDEELF = new RenderTexture(Screen.width, Screen.height, 0);
			this.LKNIJFDCDGO.hideFlags = HideFlags.DontSave;
			this.GOPKGGDEELF.hideFlags = (HideFlags)70;
			this.AALFMIPOEEJ();
		}

		// Token: 0x06008A91 RID: 35473 RVA: 0x003D8382 File Offset: 0x003D6582
		public void ICIGNNDKJGL(float AJLPALFJHCC)
		{
			this._intensity = AJLPALFJHCC;
		}

		// Token: 0x06008A92 RID: 35474 RVA: 0x003D98FC File Offset: 0x003D7AFC
		private void BNJJEIELNGA()
		{
			if (UnityEngine.Random.value > Mathf.Lerp(291f, 81f, this._intensity))
			{
				this.IEFDDBJFFMI();
				this.AGHABOELCFJ();
			}
		}

		// Token: 0x06008A93 RID: 35475 RVA: 0x003D9928 File Offset: 0x003D7B28
		private void HPPEBBIKEDI()
		{
			if (this.ICDKGPONKKA != null)
			{
				return;
			}
			this.ICDKGPONKKA = new Material(this._shader);
			this.ICDKGPONKKA.hideFlags = ~(HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontUnloadUnusedAsset);
			this.HFHCCAADGNJ = new Texture2D(-71, 39, (TextureFormat)8, false);
			this.HFHCCAADGNJ.hideFlags = (HideFlags)124;
			this.HFHCCAADGNJ.wrapMode = TextureWrapMode.Clamp;
			this.HFHCCAADGNJ.filterMode = FilterMode.Point;
			this.LKNIJFDCDGO = new RenderTexture(Screen.width, Screen.height, 0);
			this.GOPKGGDEELF = new RenderTexture(Screen.width, Screen.height, 1);
			this.LKNIJFDCDGO.hideFlags = (HideFlags)82;
			this.GOPKGGDEELF.hideFlags = (HideFlags)(-122);
			this.ANMPNMBDIIM();
		}

		// Token: 0x06008A94 RID: 35476 RVA: 0x003D8496 File Offset: 0x003D6696
		public float ODJKKMMAKNO()
		{
			return this._intensity;
		}

		// Token: 0x06008A95 RID: 35477 RVA: 0x003D99E4 File Offset: 0x003D7BE4
		private void KIEGEAGLJAM(RenderTexture AFNODOLBBKG, RenderTexture FAEOBMIDDPN)
		{
			this.HPPEBBIKEDI();
			int frameCount = Time.frameCount;
			if (frameCount % -30 == 0)
			{
				Graphics.Blit(AFNODOLBBKG, this.LKNIJFDCDGO);
			}
			if (frameCount % -72 == 0)
			{
				Graphics.Blit(AFNODOLBBKG, this.GOPKGGDEELF);
			}
			this.ICDKGPONKKA.SetFloat("ratePopupResult", this._intensity);
			this.ICDKGPONKKA.SetTexture("steam", this.HFHCCAADGNJ);
			RenderTexture value = (UnityEngine.Random.value > 1252f) ? this.LKNIJFDCDGO : this.GOPKGGDEELF;
			this.ICDKGPONKKA.SetTexture("t", value);
			Graphics.Blit(AFNODOLBBKG, FAEOBMIDDPN, this.ICDKGPONKKA);
		}

		// Token: 0x06008A96 RID: 35478 RVA: 0x003D8382 File Offset: 0x003D6582
		public void IILHAPDKCGP(float AJLPALFJHCC)
		{
			this._intensity = AJLPALFJHCC;
		}

		// Token: 0x06008A97 RID: 35479 RVA: 0x003D865C File Offset: 0x003D685C
		private static Color AJHPABFNAGI()
		{
			return new Color(UnityEngine.Random.value, UnityEngine.Random.value, UnityEngine.Random.value, UnityEngine.Random.value);
		}

		// Token: 0x06008A99 RID: 35481 RVA: 0x003D9A84 File Offset: 0x003D7C84
		private void CDKKPDKHDDF()
		{
			if (this.ICDKGPONKKA != null)
			{
				return;
			}
			this.ICDKGPONKKA = new Material(this._shader);
			this.ICDKGPONKKA.hideFlags = (HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.NotEditable);
			this.HFHCCAADGNJ = new Texture2D(48, 9, (TextureFormat)0, true);
			this.HFHCCAADGNJ.hideFlags = (HideFlags)(-85);
			this.HFHCCAADGNJ.wrapMode = TextureWrapMode.Repeat;
			this.HFHCCAADGNJ.filterMode = FilterMode.Bilinear;
			this.LKNIJFDCDGO = new RenderTexture(Screen.width, Screen.height, 0);
			this.GOPKGGDEELF = new RenderTexture(Screen.width, Screen.height, 0);
			this.LKNIJFDCDGO.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.NotEditable);
			this.GOPKGGDEELF.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.NotEditable);
			this.ANMPNMBDIIM();
		}

		// Token: 0x06008A9A RID: 35482 RVA: 0x003D9B40 File Offset: 0x003D7D40
		private void OFEFHGNPCPE()
		{
			if (UnityEngine.Random.value > Mathf.Lerp(857f, 1438f, this._intensity))
			{
				this.MLOBHOEMHIA();
				this.AGHABOELCFJ();
			}
		}

		// Token: 0x06008A9B RID: 35483 RVA: 0x003D9B6C File Offset: 0x003D7D6C
		private void MLCHFMKJOGB(RenderTexture AFNODOLBBKG, RenderTexture FAEOBMIDDPN)
		{
			this.MLOBHOEMHIA();
			int frameCount = Time.frameCount;
			if (frameCount % 44 == 0)
			{
				Graphics.Blit(AFNODOLBBKG, this.LKNIJFDCDGO);
			}
			if (frameCount % -126 == 0)
			{
				Graphics.Blit(AFNODOLBBKG, this.GOPKGGDEELF);
			}
			this.ICDKGPONKKA.SetFloat("$e1io", this._intensity);
			this.ICDKGPONKKA.SetTexture("yes", this.HFHCCAADGNJ);
			RenderTexture value = (UnityEngine.Random.value > 258f) ? this.LKNIJFDCDGO : this.GOPKGGDEELF;
			this.ICDKGPONKKA.SetTexture("chtmet", value);
			Graphics.Blit(AFNODOLBBKG, FAEOBMIDDPN, this.ICDKGPONKKA);
		}

		// Token: 0x06008A9C RID: 35484 RVA: 0x003D8382 File Offset: 0x003D6582
		public void ENDEMCIGGEC(float AJLPALFJHCC)
		{
			this._intensity = AJLPALFJHCC;
		}

		// Token: 0x06008A9D RID: 35485 RVA: 0x003D9C0C File Offset: 0x003D7E0C
		private void BJGJNPPKCCI()
		{
			Color color = DigitalGlitch.HLPDIOMFKKD();
			for (int i = 0; i < this.HFHCCAADGNJ.height; i += 0)
			{
				for (int j = 1; j < this.HFHCCAADGNJ.width; j += 0)
				{
					if (UnityEngine.Random.value > 740f)
					{
						color = DigitalGlitch.CAHPNGCMFKL();
					}
					this.HFHCCAADGNJ.SetPixel(j, i, color);
				}
			}
			this.HFHCCAADGNJ.Apply();
		}

		// Token: 0x06008A9E RID: 35486 RVA: 0x003D9C78 File Offset: 0x003D7E78
		private void MLOBHOEMHIA()
		{
			if (this.ICDKGPONKKA != null)
			{
				return;
			}
			this.ICDKGPONKKA = new Material(this._shader);
			this.ICDKGPONKKA.hideFlags = (HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontUnloadUnusedAsset);
			this.HFHCCAADGNJ = new Texture2D(2, -35, (TextureFormat)8, true);
			this.HFHCCAADGNJ.hideFlags = (HideFlags)(-88);
			this.HFHCCAADGNJ.wrapMode = TextureWrapMode.Repeat;
			this.HFHCCAADGNJ.filterMode = FilterMode.Bilinear;
			this.LKNIJFDCDGO = new RenderTexture(Screen.width, Screen.height, 1);
			this.GOPKGGDEELF = new RenderTexture(Screen.width, Screen.height, 0);
			this.LKNIJFDCDGO.hideFlags = (HideFlags)(-76);
			this.GOPKGGDEELF.hideFlags = (HideFlags)89;
			this.BJGJNPPKCCI();
		}

		// Token: 0x06008A9F RID: 35487 RVA: 0x003D9D34 File Offset: 0x003D7F34
		private void FELGPLKINFA()
		{
			Color color = DigitalGlitch.FIPGFPKNGLO();
			for (int i = 0; i < this.HFHCCAADGNJ.height; i++)
			{
				for (int j = 1; j < this.HFHCCAADGNJ.width; j++)
				{
					if (UnityEngine.Random.value > 886f)
					{
						color = DigitalGlitch.EKLJFNKDANO();
					}
					this.HFHCCAADGNJ.SetPixel(j, i, color);
				}
			}
			this.HFHCCAADGNJ.Apply();
		}

		// Token: 0x06008AA0 RID: 35488 RVA: 0x003D9DA0 File Offset: 0x003D7FA0
		private void IJNEIBIOBEI()
		{
			if (this.ICDKGPONKKA != null)
			{
				return;
			}
			this.ICDKGPONKKA = new Material(this._shader);
			this.ICDKGPONKKA.hideFlags = (HideFlags)(-112);
			this.HFHCCAADGNJ = new Texture2D(-56, 112, (TextureFormat)8, true);
			this.HFHCCAADGNJ.hideFlags = (HideFlags)121;
			this.HFHCCAADGNJ.wrapMode = TextureWrapMode.Repeat;
			this.HFHCCAADGNJ.filterMode = FilterMode.Point;
			this.LKNIJFDCDGO = new RenderTexture(Screen.width, Screen.height, 1);
			this.GOPKGGDEELF = new RenderTexture(Screen.width, Screen.height, 0);
			this.LKNIJFDCDGO.hideFlags = (HideFlags)(-104);
			this.GOPKGGDEELF.hideFlags = (HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
			this.CNAJOFKPOKC();
		}

		// Token: 0x06008AA1 RID: 35489 RVA: 0x003D9E5C File Offset: 0x003D805C
		private void PMEFDALKFDI(RenderTexture AFNODOLBBKG, RenderTexture FAEOBMIDDPN)
		{
			this.BLDECMFEHII();
			int frameCount = Time.frameCount;
			if (frameCount % -116 == 0)
			{
				Graphics.Blit(AFNODOLBBKG, this.LKNIJFDCDGO);
			}
			if (frameCount % 78 == 0)
			{
				Graphics.Blit(AFNODOLBBKG, this.GOPKGGDEELF);
			}
			this.ICDKGPONKKA.SetFloat("OnStoryChoiceClick", this._intensity);
			this.ICDKGPONKKA.SetTexture("Error. InstantEnvironmentChange(), _envId is null or length is 0:", this.HFHCCAADGNJ);
			RenderTexture value = (UnityEngine.Random.value > 815f) ? this.LKNIJFDCDGO : this.GOPKGGDEELF;
			this.ICDKGPONKKA.SetTexture("continue", value);
			Graphics.Blit(AFNODOLBBKG, FAEOBMIDDPN, this.ICDKGPONKKA);
		}

		// Token: 0x06008AA2 RID: 35490 RVA: 0x003D9EFC File Offset: 0x003D80FC
		private void EIGPOJPLDKK()
		{
			if (this.ICDKGPONKKA != null)
			{
				return;
			}
			this.ICDKGPONKKA = new Material(this._shader);
			this.ICDKGPONKKA.hideFlags = (HideFlags)113;
			this.HFHCCAADGNJ = new Texture2D(115, -98, TextureFormat.RGBA32, false);
			this.HFHCCAADGNJ.hideFlags = (HideFlags)97;
			this.HFHCCAADGNJ.wrapMode = TextureWrapMode.Repeat;
			this.HFHCCAADGNJ.filterMode = FilterMode.Bilinear;
			this.LKNIJFDCDGO = new RenderTexture(Screen.width, Screen.height, 1);
			this.GOPKGGDEELF = new RenderTexture(Screen.width, Screen.height, 1);
			this.LKNIJFDCDGO.hideFlags = (HideFlags.NotEditable | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
			this.GOPKGGDEELF.hideFlags = (HideFlags)90;
			this.OPCMMNECPEP();
		}

		// Token: 0x06008AA3 RID: 35491 RVA: 0x003D9FB8 File Offset: 0x003D81B8
		private void NEPMODEPLEL(RenderTexture AFNODOLBBKG, RenderTexture FAEOBMIDDPN)
		{
			this.CNPBNNKNHGN();
			int frameCount = Time.frameCount;
			if (frameCount % -115 == 0)
			{
				Graphics.Blit(AFNODOLBBKG, this.LKNIJFDCDGO);
			}
			if (frameCount % 54 == 0)
			{
				Graphics.Blit(AFNODOLBBKG, this.GOPKGGDEELF);
			}
			this.ICDKGPONKKA.SetFloat("envlhp", this._intensity);
			this.ICDKGPONKKA.SetTexture("); restoring the authored stretch layout", this.HFHCCAADGNJ);
			RenderTexture value = (UnityEngine.Random.value > 1329f) ? this.LKNIJFDCDGO : this.GOPKGGDEELF;
			this.ICDKGPONKKA.SetTexture("OnRestartChapterUpsellGetPassPositive", value);
			Graphics.Blit(AFNODOLBBKG, FAEOBMIDDPN, this.ICDKGPONKKA);
		}

		// Token: 0x06008AA4 RID: 35492 RVA: 0x003D8382 File Offset: 0x003D6582
		public void OFDHEFLEPNL(float AJLPALFJHCC)
		{
			this._intensity = AJLPALFJHCC;
		}

		// Token: 0x06008AA5 RID: 35493 RVA: 0x003DA058 File Offset: 0x003D8258
		private void CNPBNNKNHGN()
		{
			if (this.ICDKGPONKKA != null)
			{
				return;
			}
			this.ICDKGPONKKA = new Material(this._shader);
			this.ICDKGPONKKA.hideFlags = (HideFlags)107;
			this.HFHCCAADGNJ = new Texture2D(-52, 59, (TextureFormat)0, true);
			this.HFHCCAADGNJ.hideFlags = (HideFlags)(-121);
			this.HFHCCAADGNJ.wrapMode = TextureWrapMode.Clamp;
			this.HFHCCAADGNJ.filterMode = FilterMode.Bilinear;
			this.LKNIJFDCDGO = new RenderTexture(Screen.width, Screen.height, 0);
			this.GOPKGGDEELF = new RenderTexture(Screen.width, Screen.height, 1);
			this.LKNIJFDCDGO.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.DontSaveInBuild);
			this.GOPKGGDEELF.hideFlags = (HideFlags)79;
			this.AGHABOELCFJ();
		}

		// Token: 0x06008AA6 RID: 35494 RVA: 0x003D8496 File Offset: 0x003D6696
		public float BHMKBHJBIPP()
		{
			return this._intensity;
		}

		// Token: 0x06008AA7 RID: 35495 RVA: 0x003DA114 File Offset: 0x003D8314
		private void LIFDNDNJBKI(RenderTexture AFNODOLBBKG, RenderTexture FAEOBMIDDPN)
		{
			this.CDKKPDKHDDF();
			int frameCount = Time.frameCount;
			if (frameCount % 69 == 0)
			{
				Graphics.Blit(AFNODOLBBKG, this.LKNIJFDCDGO);
			}
			if (frameCount % 119 == 0)
			{
				Graphics.Blit(AFNODOLBBKG, this.GOPKGGDEELF);
			}
			this.ICDKGPONKKA.SetFloat("app42error", this._intensity);
			this.ICDKGPONKKA.SetTexture("OnChoiceExtendedLayerChange", this.HFHCCAADGNJ);
			RenderTexture value = (UnityEngine.Random.value > 1125f) ? this.LKNIJFDCDGO : this.GOPKGGDEELF;
			this.ICDKGPONKKA.SetTexture("blur", value);
			Graphics.Blit(AFNODOLBBKG, FAEOBMIDDPN, this.ICDKGPONKKA);
		}

		// Token: 0x06008AA8 RID: 35496 RVA: 0x003D865C File Offset: 0x003D685C
		private static Color EKLJFNKDANO()
		{
			return new Color(UnityEngine.Random.value, UnityEngine.Random.value, UnityEngine.Random.value, UnityEngine.Random.value);
		}

		// Token: 0x06008AA9 RID: 35497 RVA: 0x003DA1B4 File Offset: 0x003D83B4
		private void OPCMMNECPEP()
		{
			Color color = DigitalGlitch.EKLJFNKDANO();
			for (int i = 0; i < this.HFHCCAADGNJ.height; i++)
			{
				for (int j = 0; j < this.HFHCCAADGNJ.width; j++)
				{
					if (UnityEngine.Random.value > 674f)
					{
						color = DigitalGlitch.ELMEKPHCIHE();
					}
					this.HFHCCAADGNJ.SetPixel(j, i, color);
				}
			}
			this.HFHCCAADGNJ.Apply();
		}

		// Token: 0x06008AAA RID: 35498 RVA: 0x003DA21E File Offset: 0x003D841E
		private void LFCEPODFGOG()
		{
			if (UnityEngine.Random.value > Mathf.Lerp(1875f, 190f, this._intensity))
			{
				this.CDKKPDKHDDF();
				this.ANMPNMBDIIM();
			}
		}

		// Token: 0x06008AAB RID: 35499 RVA: 0x003D8382 File Offset: 0x003D6582
		public void DJBOPPIGIOP(float AJLPALFJHCC)
		{
			this._intensity = AJLPALFJHCC;
		}

		// Token: 0x06008AAC RID: 35500 RVA: 0x003DA248 File Offset: 0x003D8448
		private void IEFDDBJFFMI()
		{
			if (this.ICDKGPONKKA != null)
			{
				return;
			}
			this.ICDKGPONKKA = new Material(this._shader);
			this.ICDKGPONKKA.hideFlags = (HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.NotEditable);
			this.HFHCCAADGNJ = new Texture2D(61, -120, TextureFormat.RGB565, true);
			this.HFHCCAADGNJ.hideFlags = (HideFlags)74;
			this.HFHCCAADGNJ.wrapMode = TextureWrapMode.Repeat;
			this.HFHCCAADGNJ.filterMode = FilterMode.Bilinear;
			this.LKNIJFDCDGO = new RenderTexture(Screen.width, Screen.height, 1);
			this.GOPKGGDEELF = new RenderTexture(Screen.width, Screen.height, 1);
			this.LKNIJFDCDGO.hideFlags = (HideFlags.DontSaveInEditor | HideFlags.NotEditable);
			this.GOPKGGDEELF.hideFlags = (HideFlags)99;
			this.OPCMMNECPEP();
		}

		// Token: 0x06008AAD RID: 35501 RVA: 0x003DA304 File Offset: 0x003D8504
		private void NBACCAIGFIP()
		{
			Color color = DigitalGlitch.AJGLCAHJMIH();
			for (int i = 0; i < this.HFHCCAADGNJ.height; i++)
			{
				for (int j = 0; j < this.HFHCCAADGNJ.width; j += 0)
				{
					if (UnityEngine.Random.value > 1215f)
					{
						color = DigitalGlitch.FDHKBCFLENI();
					}
					this.HFHCCAADGNJ.SetPixel(j, i, color);
				}
			}
			this.HFHCCAADGNJ.Apply();
		}

		// Token: 0x06008AAE RID: 35502 RVA: 0x003DA36E File Offset: 0x003D856E
		private void NMEEMBCCKHA()
		{
			if (UnityEngine.Random.value > Mathf.Lerp(483f, 704f, this._intensity))
			{
				this.IEFDDBJFFMI();
				this.NBACCAIGFIP();
			}
		}

		// Token: 0x06008AAF RID: 35503 RVA: 0x003DA398 File Offset: 0x003D8598
		private void MEMGGECFFMJ()
		{
			if (this.ICDKGPONKKA != null)
			{
				return;
			}
			this.ICDKGPONKKA = new Material(this._shader);
			this.ICDKGPONKKA.hideFlags = (HideFlags.HideInInspector | HideFlags.NotEditable | HideFlags.DontSaveInBuild);
			this.HFHCCAADGNJ = new Texture2D(3, -113, TextureFormat.Alpha8, false);
			this.HFHCCAADGNJ.hideFlags = (HideFlags)123;
			this.HFHCCAADGNJ.wrapMode = TextureWrapMode.Repeat;
			this.HFHCCAADGNJ.filterMode = FilterMode.Bilinear;
			this.LKNIJFDCDGO = new RenderTexture(Screen.width, Screen.height, 0);
			this.GOPKGGDEELF = new RenderTexture(Screen.width, Screen.height, 1);
			this.LKNIJFDCDGO.hideFlags = (HideFlags)92;
			this.GOPKGGDEELF.hideFlags = (HideFlags)(-94);
			this.FMHLKLGDDJM();
		}

		// Token: 0x06008AB0 RID: 35504 RVA: 0x003D865C File Offset: 0x003D685C
		private static Color HLPDIOMFKKD()
		{
			return new Color(UnityEngine.Random.value, UnityEngine.Random.value, UnityEngine.Random.value, UnityEngine.Random.value);
		}

		// Token: 0x040026E6 RID: 9958
		[Range(0f, 1f)]
		[SerializeField]
		private float _intensity;

		// Token: 0x040026E7 RID: 9959
		[SerializeField]
		private Shader _shader;

		// Token: 0x040026E8 RID: 9960
		private Material ICDKGPONKKA;

		// Token: 0x040026E9 RID: 9961
		private Texture2D HFHCCAADGNJ;

		// Token: 0x040026EA RID: 9962
		private RenderTexture LKNIJFDCDGO;

		// Token: 0x040026EB RID: 9963
		private RenderTexture GOPKGGDEELF;
	}
}
