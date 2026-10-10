using System;
using UnityEngine;

namespace Kino
{
	// Token: 0x02000270 RID: 624
	[AddComponentMenu("Kino Image Effects/Analog Glitch 20")]
	[RequireComponent(typeof(Camera))]
	[ExecuteInEditMode]
	public class AnalogGlitch20 : MonoBehaviour
	{
		// Token: 0x06004BF7 RID: 19447 RVA: 0x0021E618 File Offset: 0x0021C818
		private void PEAMNCOFAEK(RenderTexture AFNODOLBBKG, RenderTexture FAEOBMIDDPN)
		{
			if (this.ICDKGPONKKA == null)
			{
				this.ICDKGPONKKA = new Material(this._shader);
				this.ICDKGPONKKA.hideFlags = ~(HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.DontSaveInBuild);
			}
			this.ICDKGPONKKA.SetTexture("ontitle", this._noiseMap);
			float y = Mathf.Clamp01(1179f - this._scanLineJitter * 816f);
			float x = 1637f + Mathf.Pow(this._scanLineJitter, 219f) * 949f;
			this.ICDKGPONKKA.SetVector("NEWSAVE: Retrieving additional ", new Vector2(x, y));
			this.ICDKGPONKKA.SetFloat("OnPopupAvatarCollectionsInputCancel", this._horizontalShake * 636f);
			Vector2 v = new Vector2(this._colorDrift * 1100f, Time.time * 972f);
			this.ICDKGPONKKA.SetVector("", v);
			Graphics.Blit(AFNODOLBBKG, FAEOBMIDDPN, this.ICDKGPONKKA);
		}

		// Token: 0x06004BF8 RID: 19448 RVA: 0x0021E715 File Offset: 0x0021C915
		public void OOGADMNEJCL(float AJLPALFJHCC)
		{
			this._colorDrift = AJLPALFJHCC;
		}

		// Token: 0x06004BF9 RID: 19449 RVA: 0x0021E71E File Offset: 0x0021C91E
		public float DIGKIIHPOJD()
		{
			return this._scanLineJitter;
		}

		// Token: 0x06004BFA RID: 19450 RVA: 0x0021E726 File Offset: 0x0021C926
		public void IAGOPDEMPMD(float AJLPALFJHCC)
		{
			this._scanLineJitter = AJLPALFJHCC;
		}

		// Token: 0x06004BFB RID: 19451 RVA: 0x0021E730 File Offset: 0x0021C930
		private void BHEGLJNBAMP(RenderTexture AFNODOLBBKG, RenderTexture FAEOBMIDDPN)
		{
			if (this.ICDKGPONKKA == null)
			{
				this.ICDKGPONKKA = new Material(this._shader);
				this.ICDKGPONKKA.hideFlags = (HideFlags)(-101);
			}
			this.ICDKGPONKKA.SetTexture("((?<=\\p{Ll})\\p{Lu})|((?!\\A)\\p{Lu}(?>\\p{Ll}))", this._noiseMap);
			float y = Mathf.Clamp01(167f - this._scanLineJitter * 190f);
			float x = 1063f + Mathf.Pow(this._scanLineJitter, 1398f) * 1849f;
			this.ICDKGPONKKA.SetVector("", new Vector2(x, y));
			this.ICDKGPONKKA.SetFloat("-", this._horizontalShake * 1134f);
			Vector2 v = new Vector2(this._colorDrift * 1629f, Time.time * 281f);
			this.ICDKGPONKKA.SetVector("Opened from Gley Notification", v);
			Graphics.Blit(AFNODOLBBKG, FAEOBMIDDPN, this.ICDKGPONKKA);
		}

		// Token: 0x06004BFC RID: 19452 RVA: 0x0021E82D File Offset: 0x0021CA2D
		public float EECGMBFJOLF()
		{
			return this._colorDrift;
		}

		// Token: 0x06004BFD RID: 19453 RVA: 0x0021E715 File Offset: 0x0021C915
		public void PHCJCOAEGKO(float AJLPALFJHCC)
		{
			this._colorDrift = AJLPALFJHCC;
		}

		// Token: 0x06004BFE RID: 19454 RVA: 0x0021E715 File Offset: 0x0021C915
		public void NLCGFCOJHGE(float AJLPALFJHCC)
		{
			this._colorDrift = AJLPALFJHCC;
		}

		// Token: 0x06004BFF RID: 19455 RVA: 0x0021E715 File Offset: 0x0021C915
		public void IPDILOGKOCC(float AJLPALFJHCC)
		{
			this._colorDrift = AJLPALFJHCC;
		}

		// Token: 0x06004C00 RID: 19456 RVA: 0x0021E726 File Offset: 0x0021C926
		public void IDDOGLCKDMP(float AJLPALFJHCC)
		{
			this._scanLineJitter = AJLPALFJHCC;
		}

		// Token: 0x06004C01 RID: 19457 RVA: 0x0021E71E File Offset: 0x0021C91E
		public float JLFHAJJKKNJ()
		{
			return this._scanLineJitter;
		}

		// Token: 0x06004C02 RID: 19458 RVA: 0x0021E835 File Offset: 0x0021CA35
		public void FAKKLOJOICO(float AJLPALFJHCC)
		{
			this._horizontalShake = AJLPALFJHCC;
		}

		// Token: 0x06004C03 RID: 19459 RVA: 0x0021E840 File Offset: 0x0021CA40
		private void NDFDPJIMGEO(RenderTexture AFNODOLBBKG, RenderTexture FAEOBMIDDPN)
		{
			if (this.ICDKGPONKKA == null)
			{
				this.ICDKGPONKKA = new Material(this._shader);
				this.ICDKGPONKKA.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.NotEditable);
			}
			this.ICDKGPONKKA.SetTexture("p", this._noiseMap);
			float y = Mathf.Clamp01(230f - this._scanLineJitter * 190f);
			float x = 42f + Mathf.Pow(this._scanLineJitter, 921f) * 727f;
			this.ICDKGPONKKA.SetVector("uid", new Vector2(x, y));
			this.ICDKGPONKKA.SetFloat("true", this._horizontalShake * 1708f);
			Vector2 v = new Vector2(this._colorDrift * 1962f, Time.time * 646f);
			this.ICDKGPONKKA.SetVector("<size=28px>", v);
			Graphics.Blit(AFNODOLBBKG, FAEOBMIDDPN, this.ICDKGPONKKA);
		}

		// Token: 0x17000180 RID: 384
		// (get) Token: 0x06004C04 RID: 19460 RVA: 0x0021E93D File Offset: 0x0021CB3D
		// (set) Token: 0x06004C15 RID: 19477 RVA: 0x0021E835 File Offset: 0x0021CA35
		public float LEKDPHLGHMJ
		{
			get
			{
				return this._horizontalShake;
			}
			set
			{
				this._horizontalShake = value;
			}
		}

		// Token: 0x1700017F RID: 383
		// (get) Token: 0x06004C05 RID: 19461 RVA: 0x0021E71E File Offset: 0x0021C91E
		// (set) Token: 0x06004C1B RID: 19483 RVA: 0x0021E726 File Offset: 0x0021C926
		public float KIBGIIIJEKK
		{
			get
			{
				return this._scanLineJitter;
			}
			set
			{
				this._scanLineJitter = value;
			}
		}

		// Token: 0x06004C06 RID: 19462 RVA: 0x0021E71E File Offset: 0x0021C91E
		public float JAIFPMCIMLM()
		{
			return this._scanLineJitter;
		}

		// Token: 0x06004C07 RID: 19463 RVA: 0x0021E948 File Offset: 0x0021CB48
		private void OMCPEPKHOLD(RenderTexture AFNODOLBBKG, RenderTexture FAEOBMIDDPN)
		{
			if (this.ICDKGPONKKA == null)
			{
				this.ICDKGPONKKA = new Material(this._shader);
				this.ICDKGPONKKA.hideFlags = (HideFlags)(-80);
			}
			this.ICDKGPONKKA.SetTexture("PurchaseManagerUnity.OnPurchasesFetched(): ", this._noiseMap);
			float y = Mathf.Clamp01(1010f - this._scanLineJitter * 783f);
			float x = 323f + Mathf.Pow(this._scanLineJitter, 1116f) * 1905f;
			this.ICDKGPONKKA.SetVector("large", new Vector2(x, y));
			this.ICDKGPONKKA.SetFloat("sfxitemused", this._horizontalShake * 24f);
			Vector2 v = new Vector2(this._colorDrift * 459f, Time.time * 725f);
			this.ICDKGPONKKA.SetVector("profilenametitleshort", v);
			Graphics.Blit(AFNODOLBBKG, FAEOBMIDDPN, this.ICDKGPONKKA);
		}

		// Token: 0x06004C08 RID: 19464 RVA: 0x0021E726 File Offset: 0x0021C926
		public void DPDINMKDDID(float AJLPALFJHCC)
		{
			this._scanLineJitter = AJLPALFJHCC;
		}

		// Token: 0x06004C09 RID: 19465 RVA: 0x0021E93D File Offset: 0x0021CB3D
		public float DAHKNIKIJDL()
		{
			return this._horizontalShake;
		}

		// Token: 0x06004C0A RID: 19466 RVA: 0x0021E82D File Offset: 0x0021CA2D
		public float KMBBEJIHHBJ()
		{
			return this._colorDrift;
		}

		// Token: 0x06004C0B RID: 19467 RVA: 0x0021E726 File Offset: 0x0021C926
		public void JELMFPJIJMC(float AJLPALFJHCC)
		{
			this._scanLineJitter = AJLPALFJHCC;
		}

		// Token: 0x06004C0C RID: 19468 RVA: 0x0021E71E File Offset: 0x0021C91E
		public float PBBBNEGNKLP()
		{
			return this._scanLineJitter;
		}

		// Token: 0x06004C0D RID: 19469 RVA: 0x0021E726 File Offset: 0x0021C926
		public void FDADJBFFAAL(float AJLPALFJHCC)
		{
			this._scanLineJitter = AJLPALFJHCC;
		}

		// Token: 0x06004C0E RID: 19470 RVA: 0x0021E715 File Offset: 0x0021C915
		public void DLCAPFKEOPN(float AJLPALFJHCC)
		{
			this._colorDrift = AJLPALFJHCC;
		}

		// Token: 0x06004C0F RID: 19471 RVA: 0x0021E715 File Offset: 0x0021C915
		public void EMAODFLHHIC(float AJLPALFJHCC)
		{
			this._colorDrift = AJLPALFJHCC;
		}

		// Token: 0x06004C10 RID: 19472 RVA: 0x0021E835 File Offset: 0x0021CA35
		public void IGNKBGNABLD(float AJLPALFJHCC)
		{
			this._horizontalShake = AJLPALFJHCC;
		}

		// Token: 0x17000181 RID: 385
		// (get) Token: 0x06004C11 RID: 19473 RVA: 0x0021E82D File Offset: 0x0021CA2D
		// (set) Token: 0x06004C25 RID: 19493 RVA: 0x0021E715 File Offset: 0x0021C915
		public float BOIOJOIALFE
		{
			get
			{
				return this._colorDrift;
			}
			set
			{
				this._colorDrift = value;
			}
		}

		// Token: 0x06004C12 RID: 19474 RVA: 0x0021E82D File Offset: 0x0021CA2D
		public float IEEMALKPOIO()
		{
			return this._colorDrift;
		}

		// Token: 0x06004C13 RID: 19475 RVA: 0x0021E715 File Offset: 0x0021C915
		public void BENCHDGKKJD(float AJLPALFJHCC)
		{
			this._colorDrift = AJLPALFJHCC;
		}

		// Token: 0x06004C14 RID: 19476 RVA: 0x0021E82D File Offset: 0x0021CA2D
		public float MGCAAAPNGNI()
		{
			return this._colorDrift;
		}

		// Token: 0x06004C16 RID: 19478 RVA: 0x0021E71E File Offset: 0x0021C91E
		public float GHKLANLBLDC()
		{
			return this._scanLineJitter;
		}

		// Token: 0x06004C17 RID: 19479 RVA: 0x0021E82D File Offset: 0x0021CA2D
		public float OOIMEDLMFNE()
		{
			return this._colorDrift;
		}

		// Token: 0x06004C18 RID: 19480 RVA: 0x0021E726 File Offset: 0x0021C926
		public void HEJAJDGKGHH(float AJLPALFJHCC)
		{
			this._scanLineJitter = AJLPALFJHCC;
		}

		// Token: 0x06004C19 RID: 19481 RVA: 0x0021E835 File Offset: 0x0021CA35
		public void OOBOABCIECJ(float AJLPALFJHCC)
		{
			this._horizontalShake = AJLPALFJHCC;
		}

		// Token: 0x06004C1A RID: 19482 RVA: 0x0021E835 File Offset: 0x0021CA35
		public void BKMKLKKLPEI(float AJLPALFJHCC)
		{
			this._horizontalShake = AJLPALFJHCC;
		}

		// Token: 0x06004C1C RID: 19484 RVA: 0x0021E715 File Offset: 0x0021C915
		public void OBFIDEAJFGH(float AJLPALFJHCC)
		{
			this._colorDrift = AJLPALFJHCC;
		}

		// Token: 0x06004C1D RID: 19485 RVA: 0x0021E835 File Offset: 0x0021CA35
		public void DPIIJBPFHGF(float AJLPALFJHCC)
		{
			this._horizontalShake = AJLPALFJHCC;
		}

		// Token: 0x06004C1E RID: 19486 RVA: 0x0021E835 File Offset: 0x0021CA35
		public void OMEOGBBEMIK(float AJLPALFJHCC)
		{
			this._horizontalShake = AJLPALFJHCC;
		}

		// Token: 0x06004C1F RID: 19487 RVA: 0x0021EA48 File Offset: 0x0021CC48
		private void CLKOFKFCFIE(RenderTexture AFNODOLBBKG, RenderTexture FAEOBMIDDPN)
		{
			if (this.ICDKGPONKKA == null)
			{
				this.ICDKGPONKKA = new Material(this._shader);
				this.ICDKGPONKKA.hideFlags = ~(HideFlags.HideInInspector | HideFlags.DontSaveInEditor);
			}
			this.ICDKGPONKKA.SetTexture("OnValidatePendingProcessed", this._noiseMap);
			float y = Mathf.Clamp01(1152f - this._scanLineJitter * 960f);
			float x = 141f + Mathf.Pow(this._scanLineJitter, 1196f) * 1385f;
			this.ICDKGPONKKA.SetVector("stored theme selected", new Vector2(x, y));
			this.ICDKGPONKKA.SetFloat("ind", this._horizontalShake * 449f);
			Vector2 v = new Vector2(this._colorDrift * 109f, Time.time * 1815f);
			this.ICDKGPONKKA.SetVector("right", v);
			Graphics.Blit(AFNODOLBBKG, FAEOBMIDDPN, this.ICDKGPONKKA);
		}

		// Token: 0x06004C20 RID: 19488 RVA: 0x0021E835 File Offset: 0x0021CA35
		public void LMKLEAHPFME(float AJLPALFJHCC)
		{
			this._horizontalShake = AJLPALFJHCC;
		}

		// Token: 0x06004C21 RID: 19489 RVA: 0x0021E715 File Offset: 0x0021C915
		public void HLIHCBEMLNB(float AJLPALFJHCC)
		{
			this._colorDrift = AJLPALFJHCC;
		}

		// Token: 0x06004C22 RID: 19490 RVA: 0x0021EB48 File Offset: 0x0021CD48
		private void EOAFOGPOBGJ(RenderTexture AFNODOLBBKG, RenderTexture FAEOBMIDDPN)
		{
			if (this.ICDKGPONKKA == null)
			{
				this.ICDKGPONKKA = new Material(this._shader);
				this.ICDKGPONKKA.hideFlags = (HideFlags)(-93);
			}
			this.ICDKGPONKKA.SetTexture("ok", this._noiseMap);
			float y = Mathf.Clamp01(209f - this._scanLineJitter * 686f);
			float x = 1544f + Mathf.Pow(this._scanLineJitter, 1484f) * 1126f;
			this.ICDKGPONKKA.SetVector("_not_found", new Vector2(x, y));
			this.ICDKGPONKKA.SetFloat("YYY", this._horizontalShake * 712f);
			Vector2 v = new Vector2(this._colorDrift * 1564f, Time.time * 1434f);
			this.ICDKGPONKKA.SetVector("abs", v);
			Graphics.Blit(AFNODOLBBKG, FAEOBMIDDPN, this.ICDKGPONKKA);
		}

		// Token: 0x06004C23 RID: 19491 RVA: 0x0021EC48 File Offset: 0x0021CE48
		private void OJOHLBBLEON(RenderTexture AFNODOLBBKG, RenderTexture FAEOBMIDDPN)
		{
			if (this.ICDKGPONKKA == null)
			{
				this.ICDKGPONKKA = new Material(this._shader);
				this.ICDKGPONKKA.hideFlags = (HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
			}
			this.ICDKGPONKKA.SetTexture("YYY", this._noiseMap);
			float y = Mathf.Clamp01(178f - this._scanLineJitter * 1134f);
			float x = 112f + Mathf.Pow(this._scanLineJitter, 1004f) * 1490f;
			this.ICDKGPONKKA.SetVector("OnBackendRequestFriendDeleteSuccess", new Vector2(x, y));
			this.ICDKGPONKKA.SetFloat("bdgsspr", this._horizontalShake * 988f);
			Vector2 v = new Vector2(this._colorDrift * 110f, Time.time * 16f);
			this.ICDKGPONKKA.SetVector("", v);
			Graphics.Blit(AFNODOLBBKG, FAEOBMIDDPN, this.ICDKGPONKKA);
		}

		// Token: 0x06004C24 RID: 19492 RVA: 0x0021ED48 File Offset: 0x0021CF48
		private void LCJCCHOIIIP(RenderTexture AFNODOLBBKG, RenderTexture FAEOBMIDDPN)
		{
			if (this.ICDKGPONKKA == null)
			{
				this.ICDKGPONKKA = new Material(this._shader);
				this.ICDKGPONKKA.hideFlags = (HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
			}
			this.ICDKGPONKKA.SetTexture("ok", this._noiseMap);
			float y = Mathf.Clamp01(1606f - this._scanLineJitter * 1585f);
			float x = 1732f + Mathf.Pow(this._scanLineJitter, 1912f) * 1193f;
			this.ICDKGPONKKA.SetVector("-", new Vector2(x, y));
			this.ICDKGPONKKA.SetFloat("Loaded asset bundle:", this._horizontalShake * 1972f);
			Vector2 v = new Vector2(this._colorDrift * 1006f, Time.time * 1395f);
			this.ICDKGPONKKA.SetVector("storyAssetPackManager[i].storyItemsAssets[j] is null!", v);
			Graphics.Blit(AFNODOLBBKG, FAEOBMIDDPN, this.ICDKGPONKKA);
		}

		// Token: 0x06004C26 RID: 19494 RVA: 0x0021E93D File Offset: 0x0021CB3D
		public float GONLPKNHPMO()
		{
			return this._horizontalShake;
		}

		// Token: 0x06004C28 RID: 19496 RVA: 0x0021EE48 File Offset: 0x0021D048
		private void GAJIFHKIBNL(RenderTexture AFNODOLBBKG, RenderTexture FAEOBMIDDPN)
		{
			if (this.ICDKGPONKKA == null)
			{
				this.ICDKGPONKKA = new Material(this._shader);
				this.ICDKGPONKKA.hideFlags = (HideFlags)(-128);
			}
			this.ICDKGPONKKA.SetTexture("lf1", this._noiseMap);
			float y = Mathf.Clamp01(575f - this._scanLineJitter * 1659f);
			float x = 1762f + Mathf.Pow(this._scanLineJitter, 1833f) * 1376f;
			this.ICDKGPONKKA.SetVector("avatarcollectionstutor8title", new Vector2(x, y));
			this.ICDKGPONKKA.SetFloat("", this._horizontalShake * 1033f);
			Vector2 v = new Vector2(this._colorDrift * 819f, Time.time * 1328f);
			this.ICDKGPONKKA.SetVector(">", v);
			Graphics.Blit(AFNODOLBBKG, FAEOBMIDDPN, this.ICDKGPONKKA);
		}

		// Token: 0x06004C29 RID: 19497 RVA: 0x0021E71E File Offset: 0x0021C91E
		public float PIPPLCOOFLN()
		{
			return this._scanLineJitter;
		}

		// Token: 0x06004C2A RID: 19498 RVA: 0x0021E82D File Offset: 0x0021CA2D
		public float ILLMDBIEIEB()
		{
			return this._colorDrift;
		}

		// Token: 0x06004C2B RID: 19499 RVA: 0x0021E82D File Offset: 0x0021CA2D
		public float PDGLGJNCHMC()
		{
			return this._colorDrift;
		}

		// Token: 0x06004C2C RID: 19500 RVA: 0x0021E835 File Offset: 0x0021CA35
		public void GAHKGFHOIKC(float AJLPALFJHCC)
		{
			this._horizontalShake = AJLPALFJHCC;
		}

		// Token: 0x06004C2D RID: 19501 RVA: 0x0021EF48 File Offset: 0x0021D148
		private void OnRenderImage(RenderTexture AFNODOLBBKG, RenderTexture FAEOBMIDDPN)
		{
			if (this.ICDKGPONKKA == null)
			{
				this.ICDKGPONKKA = new Material(this._shader);
				this.ICDKGPONKKA.hideFlags = HideFlags.DontSave;
			}
			this.ICDKGPONKKA.SetTexture("_NoiseTex", this._noiseMap);
			float y = Mathf.Clamp01(1f - this._scanLineJitter * 1.2f);
			float x = 0.002f + Mathf.Pow(this._scanLineJitter, 3f) * 0.05f;
			this.ICDKGPONKKA.SetVector("_ScanLineJitter", new Vector2(x, y));
			this.ICDKGPONKKA.SetFloat("_HorizontalShake", this._horizontalShake * 0.2f);
			Vector2 v = new Vector2(this._colorDrift * 0.04f, Time.time * 606.11f);
			this.ICDKGPONKKA.SetVector("_ColorDrift", v);
			Graphics.Blit(AFNODOLBBKG, FAEOBMIDDPN, this.ICDKGPONKKA);
		}

		// Token: 0x06004C2E RID: 19502 RVA: 0x0021E715 File Offset: 0x0021C915
		public void KONJJPJGHAG(float AJLPALFJHCC)
		{
			this._colorDrift = AJLPALFJHCC;
		}

		// Token: 0x06004C2F RID: 19503 RVA: 0x0021E93D File Offset: 0x0021CB3D
		public float OJAEJDPPNEA()
		{
			return this._horizontalShake;
		}

		// Token: 0x06004C30 RID: 19504 RVA: 0x0021E726 File Offset: 0x0021C926
		public void OMNFFDDCDHH(float AJLPALFJHCC)
		{
			this._scanLineJitter = AJLPALFJHCC;
		}

		// Token: 0x06004C31 RID: 19505 RVA: 0x0021E726 File Offset: 0x0021C926
		public void FOILKIJKBLL(float AJLPALFJHCC)
		{
			this._scanLineJitter = AJLPALFJHCC;
		}

		// Token: 0x06004C32 RID: 19506 RVA: 0x0021E835 File Offset: 0x0021CA35
		public void LCDFOGFCHNN(float AJLPALFJHCC)
		{
			this._horizontalShake = AJLPALFJHCC;
		}

		// Token: 0x06004C33 RID: 19507 RVA: 0x0021E93D File Offset: 0x0021CB3D
		public float MOLADEFBDPN()
		{
			return this._horizontalShake;
		}

		// Token: 0x040015F8 RID: 5624
		[SerializeField]
		public Texture2D _noiseMap;

		// Token: 0x040015F9 RID: 5625
		[SerializeField]
		[Range(0f, 1f)]
		public float _scanLineJitter;

		// Token: 0x040015FA RID: 5626
		[SerializeField]
		[Range(0f, 1f)]
		public float _horizontalShake;

		// Token: 0x040015FB RID: 5627
		[SerializeField]
		[Range(0f, 1f)]
		public float _colorDrift;

		// Token: 0x040015FC RID: 5628
		[SerializeField]
		private Shader _shader;

		// Token: 0x040015FD RID: 5629
		private Material ICDKGPONKKA;
	}
}
