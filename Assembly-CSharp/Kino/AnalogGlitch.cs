using System;
using UnityEngine;

namespace Kino
{
	// Token: 0x0200042F RID: 1071
	[AddComponentMenu("Kino Image Effects/Analog Glitch")]
	[ExecuteInEditMode]
	[RequireComponent(typeof(Camera))]
	public class AnalogGlitch : MonoBehaviour
	{
		// Token: 0x06008060 RID: 32864 RVA: 0x0038CEC7 File Offset: 0x0038B0C7
		public float HHIDLGDDABK()
		{
			return this._colorDrift;
		}

		// Token: 0x06008061 RID: 32865 RVA: 0x0038CECF File Offset: 0x0038B0CF
		public void EEEKPACJIFO(float AJLPALFJHCC)
		{
			this._verticalJump = AJLPALFJHCC;
		}

		// Token: 0x06008062 RID: 32866 RVA: 0x0038CED8 File Offset: 0x0038B0D8
		public float JBJBHFKNNFL()
		{
			return this._verticalJump;
		}

		// Token: 0x06008063 RID: 32867 RVA: 0x0038CEE0 File Offset: 0x0038B0E0
		public float GEDHEFEMFGE()
		{
			return this._scanLineJitter;
		}

		// Token: 0x06008064 RID: 32868 RVA: 0x0038CEE8 File Offset: 0x0038B0E8
		public void JAHMOIJGGED(float AJLPALFJHCC)
		{
			this._scanLineJitter = AJLPALFJHCC;
		}

		// Token: 0x17000264 RID: 612
		// (get) Token: 0x06008065 RID: 32869 RVA: 0x0038CEE0 File Offset: 0x0038B0E0
		// (set) Token: 0x060080C6 RID: 32966 RVA: 0x0038CEE8 File Offset: 0x0038B0E8
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

		// Token: 0x06008066 RID: 32870 RVA: 0x0038CEE0 File Offset: 0x0038B0E0
		public float IFPCACLHHIO()
		{
			return this._scanLineJitter;
		}

		// Token: 0x06008067 RID: 32871 RVA: 0x0038CEF1 File Offset: 0x0038B0F1
		public float DIOOEMKCOND()
		{
			return this._horizontalShake;
		}

		// Token: 0x17000267 RID: 615
		// (get) Token: 0x060080AE RID: 32942 RVA: 0x0038CEC7 File Offset: 0x0038B0C7
		// (set) Token: 0x06008068 RID: 32872 RVA: 0x0038CEF9 File Offset: 0x0038B0F9
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

		// Token: 0x06008069 RID: 32873 RVA: 0x0038CECF File Offset: 0x0038B0CF
		public void CIKKAMKFAMI(float AJLPALFJHCC)
		{
			this._verticalJump = AJLPALFJHCC;
		}

		// Token: 0x0600806A RID: 32874 RVA: 0x0038CEC7 File Offset: 0x0038B0C7
		public float JNOECFIHJGB()
		{
			return this._colorDrift;
		}

		// Token: 0x0600806B RID: 32875 RVA: 0x0038CEE8 File Offset: 0x0038B0E8
		public void JCDINOMOOKD(float AJLPALFJHCC)
		{
			this._scanLineJitter = AJLPALFJHCC;
		}

		// Token: 0x0600806C RID: 32876 RVA: 0x0038CF04 File Offset: 0x0038B104
		private void BINBADGHMCM(RenderTexture AFNODOLBBKG, RenderTexture FAEOBMIDDPN)
		{
			if (this.ICDKGPONKKA == null)
			{
				this.ICDKGPONKKA = new Material(this._shader);
				this.ICDKGPONKKA.hideFlags = (HideFlags)(-1);
			}
			this.FFNCJMNNJPK += Time.deltaTime * this._verticalJump * 1682f;
			float y = Mathf.Clamp01(1082f - this._scanLineJitter * 1049f);
			float x = 230f + Mathf.Pow(this._scanLineJitter, 605f) * 812f;
			this.ICDKGPONKKA.SetVector("", new Vector2(x, y));
			Vector2 v = new Vector2(this._verticalJump, this.FFNCJMNNJPK);
			this.ICDKGPONKKA.SetVector("spld", v);
			this.ICDKGPONKKA.SetFloat("exception while starting: ", this._horizontalShake * 1578f);
			Vector2 v2 = new Vector2(this._colorDrift * 1124f, Time.time * 1842f);
			this.ICDKGPONKKA.SetVector("importanttitle", v2);
			Graphics.Blit(AFNODOLBBKG, FAEOBMIDDPN, this.ICDKGPONKKA);
		}

		// Token: 0x0600806D RID: 32877 RVA: 0x0038CEF9 File Offset: 0x0038B0F9
		public void DLOKPHHCBFI(float AJLPALFJHCC)
		{
			this._colorDrift = AJLPALFJHCC;
		}

		// Token: 0x0600806E RID: 32878 RVA: 0x0038CED8 File Offset: 0x0038B0D8
		public float KMCCPMLHHNM()
		{
			return this._verticalJump;
		}

		// Token: 0x0600806F RID: 32879 RVA: 0x0038CEE8 File Offset: 0x0038B0E8
		public void IDGMFPBEHDP(float AJLPALFJHCC)
		{
			this._scanLineJitter = AJLPALFJHCC;
		}

		// Token: 0x06008070 RID: 32880 RVA: 0x0038CEF1 File Offset: 0x0038B0F1
		public float FHAPPDOFICB()
		{
			return this._horizontalShake;
		}

		// Token: 0x06008071 RID: 32881 RVA: 0x0038CECF File Offset: 0x0038B0CF
		public void ICNEJGKIJJE(float AJLPALFJHCC)
		{
			this._verticalJump = AJLPALFJHCC;
		}

		// Token: 0x06008073 RID: 32883 RVA: 0x0038D033 File Offset: 0x0038B233
		public void DLPNINAKMCE(float AJLPALFJHCC)
		{
			this._horizontalShake = AJLPALFJHCC;
		}

		// Token: 0x06008074 RID: 32884 RVA: 0x0038CEF9 File Offset: 0x0038B0F9
		public void HLIHCBEMLNB(float AJLPALFJHCC)
		{
			this._colorDrift = AJLPALFJHCC;
		}

		// Token: 0x06008075 RID: 32885 RVA: 0x0038CEE8 File Offset: 0x0038B0E8
		public void IFNGEGJEBOI(float AJLPALFJHCC)
		{
			this._scanLineJitter = AJLPALFJHCC;
		}

		// Token: 0x06008076 RID: 32886 RVA: 0x0038CEF1 File Offset: 0x0038B0F1
		public float MJGHDCINMMH()
		{
			return this._horizontalShake;
		}

		// Token: 0x06008077 RID: 32887 RVA: 0x0038D033 File Offset: 0x0038B233
		public void DPICAPJOPEA(float AJLPALFJHCC)
		{
			this._horizontalShake = AJLPALFJHCC;
		}

		// Token: 0x06008078 RID: 32888 RVA: 0x0038CEE8 File Offset: 0x0038B0E8
		public void LFGEGEAIKJL(float AJLPALFJHCC)
		{
			this._scanLineJitter = AJLPALFJHCC;
		}

		// Token: 0x17000265 RID: 613
		// (get) Token: 0x06008079 RID: 32889 RVA: 0x0038CED8 File Offset: 0x0038B0D8
		// (set) Token: 0x060080CD RID: 32973 RVA: 0x0038CECF File Offset: 0x0038B0CF
		public float LEGKOMIDJBB
		{
			get
			{
				return this._verticalJump;
			}
			set
			{
				this._verticalJump = value;
			}
		}

		// Token: 0x0600807A RID: 32890 RVA: 0x0038CED8 File Offset: 0x0038B0D8
		public float MPOPNJHBMKF()
		{
			return this._verticalJump;
		}

		// Token: 0x0600807B RID: 32891 RVA: 0x0038CED8 File Offset: 0x0038B0D8
		public float EABCDICNCME()
		{
			return this._verticalJump;
		}

		// Token: 0x17000266 RID: 614
		// (get) Token: 0x0600809E RID: 32926 RVA: 0x0038CEF1 File Offset: 0x0038B0F1
		// (set) Token: 0x0600807C RID: 32892 RVA: 0x0038D033 File Offset: 0x0038B233
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

		// Token: 0x0600807D RID: 32893 RVA: 0x0038CED8 File Offset: 0x0038B0D8
		public float FNNJFIDADOJ()
		{
			return this._verticalJump;
		}

		// Token: 0x0600807E RID: 32894 RVA: 0x0038CEE8 File Offset: 0x0038B0E8
		public void LJBAKCIBOND(float AJLPALFJHCC)
		{
			this._scanLineJitter = AJLPALFJHCC;
		}

		// Token: 0x0600807F RID: 32895 RVA: 0x0038CEF1 File Offset: 0x0038B0F1
		public float DGBELMODNHM()
		{
			return this._horizontalShake;
		}

		// Token: 0x06008080 RID: 32896 RVA: 0x0038D03C File Offset: 0x0038B23C
		private void OFEKLIEHMDL(RenderTexture AFNODOLBBKG, RenderTexture FAEOBMIDDPN)
		{
			if (this.ICDKGPONKKA == null)
			{
				this.ICDKGPONKKA = new Material(this._shader);
				this.ICDKGPONKKA.hideFlags = (HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontSaveInBuild);
			}
			this.FFNCJMNNJPK += Time.deltaTime * this._verticalJump * 815f;
			float y = Mathf.Clamp01(17f - this._scanLineJitter * 643f);
			float x = 1584f + Mathf.Pow(this._scanLineJitter, 1354f) * 1263f;
			this.ICDKGPONKKA.SetVector("", new Vector2(x, y));
			Vector2 v = new Vector2(this._verticalJump, this.FFNCJMNNJPK);
			this.ICDKGPONKKA.SetVector("BackendOperationsManager.ProcessApp42Success() - exception when processing the web purchases history:", v);
			this.ICDKGPONKKA.SetFloat("tmo", this._horizontalShake * 735f);
			Vector2 v2 = new Vector2(this._colorDrift * 1698f, Time.time * 575f);
			this.ICDKGPONKKA.SetVector("", v2);
			Graphics.Blit(AFNODOLBBKG, FAEOBMIDDPN, this.ICDKGPONKKA);
		}

		// Token: 0x06008081 RID: 32897 RVA: 0x0038CECF File Offset: 0x0038B0CF
		public void EPLBPIAIBFE(float AJLPALFJHCC)
		{
			this._verticalJump = AJLPALFJHCC;
		}

		// Token: 0x06008082 RID: 32898 RVA: 0x0038D16C File Offset: 0x0038B36C
		private void OPHCOGIPEHE(RenderTexture AFNODOLBBKG, RenderTexture FAEOBMIDDPN)
		{
			if (this.ICDKGPONKKA == null)
			{
				this.ICDKGPONKKA = new Material(this._shader);
				this.ICDKGPONKKA.hideFlags = (HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.NotEditable | HideFlags.DontUnloadUnusedAsset);
			}
			this.FFNCJMNNJPK += Time.deltaTime * this._verticalJump * 1503f;
			float y = Mathf.Clamp01(527f - this._scanLineJitter * 289f);
			float x = 460f + Mathf.Pow(this._scanLineJitter, 915f) * 225f;
			this.ICDKGPONKKA.SetVector("rr", new Vector2(x, y));
			Vector2 v = new Vector2(this._verticalJump, this.FFNCJMNNJPK);
			this.ICDKGPONKKA.SetVector("LoveInterestLoungeMapping - unknown shopcur '", v);
			this.ICDKGPONKKA.SetFloat("200", this._horizontalShake * 320f);
			Vector2 v2 = new Vector2(this._colorDrift * 436f, Time.time * 567f);
			this.ICDKGPONKKA.SetVector("black", v2);
			Graphics.Blit(AFNODOLBBKG, FAEOBMIDDPN, this.ICDKGPONKKA);
		}

		// Token: 0x06008083 RID: 32899 RVA: 0x0038D033 File Offset: 0x0038B233
		public void NLKPPEPAAOM(float AJLPALFJHCC)
		{
			this._horizontalShake = AJLPALFJHCC;
		}

		// Token: 0x06008084 RID: 32900 RVA: 0x0038CECF File Offset: 0x0038B0CF
		public void BJKODEEICOJ(float AJLPALFJHCC)
		{
			this._verticalJump = AJLPALFJHCC;
		}

		// Token: 0x06008085 RID: 32901 RVA: 0x0038CEF1 File Offset: 0x0038B0F1
		public float INLKJHGEPJH()
		{
			return this._horizontalShake;
		}

		// Token: 0x06008086 RID: 32902 RVA: 0x0038CEF9 File Offset: 0x0038B0F9
		public void IHLNBNHJOLE(float AJLPALFJHCC)
		{
			this._colorDrift = AJLPALFJHCC;
		}

		// Token: 0x06008087 RID: 32903 RVA: 0x0038CECF File Offset: 0x0038B0CF
		public void EBAPCFGNOHI(float AJLPALFJHCC)
		{
			this._verticalJump = AJLPALFJHCC;
		}

		// Token: 0x06008088 RID: 32904 RVA: 0x0038CEF9 File Offset: 0x0038B0F9
		public void LGGEJIEDKME(float AJLPALFJHCC)
		{
			this._colorDrift = AJLPALFJHCC;
		}

		// Token: 0x06008089 RID: 32905 RVA: 0x0038CEE0 File Offset: 0x0038B0E0
		public float JBLDCMMBIFG()
		{
			return this._scanLineJitter;
		}

		// Token: 0x0600808A RID: 32906 RVA: 0x0038CED8 File Offset: 0x0038B0D8
		public float PPOODKCFPHM()
		{
			return this._verticalJump;
		}

		// Token: 0x0600808B RID: 32907 RVA: 0x0038D033 File Offset: 0x0038B233
		public void KJHDPBBMJPL(float AJLPALFJHCC)
		{
			this._horizontalShake = AJLPALFJHCC;
		}

		// Token: 0x0600808C RID: 32908 RVA: 0x0038D033 File Offset: 0x0038B233
		public void LCDFOGFCHNN(float AJLPALFJHCC)
		{
			this._horizontalShake = AJLPALFJHCC;
		}

		// Token: 0x0600808D RID: 32909 RVA: 0x0038D29C File Offset: 0x0038B49C
		private void PMGNLLBIMOG(RenderTexture AFNODOLBBKG, RenderTexture FAEOBMIDDPN)
		{
			if (this.ICDKGPONKKA == null)
			{
				this.ICDKGPONKKA = new Material(this._shader);
				this.ICDKGPONKKA.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.DontUnloadUnusedAsset);
			}
			this.FFNCJMNNJPK += Time.deltaTime * this._verticalJump * 1795f;
			float y = Mathf.Clamp01(699f - this._scanLineJitter * 1740f);
			float x = 397f + Mathf.Pow(this._scanLineJitter, 1211f) * 691f;
			this.ICDKGPONKKA.SetVector("noiseanalog_1", new Vector2(x, y));
			Vector2 v = new Vector2(this._verticalJump, this.FFNCJMNNJPK);
			this.ICDKGPONKKA.SetVector("no", v);
			this.ICDKGPONKKA.SetFloat("", this._horizontalShake * 922f);
			Vector2 v2 = new Vector2(this._colorDrift * 936f, Time.time * 1919f);
			this.ICDKGPONKKA.SetVector("sprite", v2);
			Graphics.Blit(AFNODOLBBKG, FAEOBMIDDPN, this.ICDKGPONKKA);
		}

		// Token: 0x0600808E RID: 32910 RVA: 0x0038CED8 File Offset: 0x0038B0D8
		public float EJBIKHBPFLD()
		{
			return this._verticalJump;
		}

		// Token: 0x0600808F RID: 32911 RVA: 0x0038CEF9 File Offset: 0x0038B0F9
		public void OEIAJNHDBPN(float AJLPALFJHCC)
		{
			this._colorDrift = AJLPALFJHCC;
		}

		// Token: 0x06008090 RID: 32912 RVA: 0x0038CEC7 File Offset: 0x0038B0C7
		public float MGCAAAPNGNI()
		{
			return this._colorDrift;
		}

		// Token: 0x06008091 RID: 32913 RVA: 0x0038D033 File Offset: 0x0038B233
		public void NGFIHMIPGKD(float AJLPALFJHCC)
		{
			this._horizontalShake = AJLPALFJHCC;
		}

		// Token: 0x06008092 RID: 32914 RVA: 0x0038D3CC File Offset: 0x0038B5CC
		private void FPAKHKDIPGK(RenderTexture AFNODOLBBKG, RenderTexture FAEOBMIDDPN)
		{
			if (this.ICDKGPONKKA == null)
			{
				this.ICDKGPONKKA = new Material(this._shader);
				this.ICDKGPONKKA.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.NotEditable);
			}
			this.FFNCJMNNJPK += Time.deltaTime * this._verticalJump * 201f;
			float y = Mathf.Clamp01(1881f - this._scanLineJitter * 1533f);
			float x = 110f + Mathf.Pow(this._scanLineJitter, 939f) * 1662f;
			this.ICDKGPONKKA.SetVector("wph", new Vector2(x, y));
			Vector2 v = new Vector2(this._verticalJump, this.FFNCJMNNJPK);
			this.ICDKGPONKKA.SetVector("specialcurrencyblocktitle", v);
			this.ICDKGPONKKA.SetFloat("pid", this._horizontalShake * 1359f);
			Vector2 v2 = new Vector2(this._colorDrift * 86f, Time.time * 1048f);
			this.ICDKGPONKKA.SetVector("abskt", v2);
			Graphics.Blit(AFNODOLBBKG, FAEOBMIDDPN, this.ICDKGPONKKA);
		}

		// Token: 0x06008093 RID: 32915 RVA: 0x0038D4FC File Offset: 0x0038B6FC
		private void CKEJCFFDIBE(RenderTexture AFNODOLBBKG, RenderTexture FAEOBMIDDPN)
		{
			if (this.ICDKGPONKKA == null)
			{
				this.ICDKGPONKKA = new Material(this._shader);
				this.ICDKGPONKKA.hideFlags = (HideFlags.HideInHierarchy | HideFlags.DontSaveInEditor | HideFlags.NotEditable);
			}
			this.FFNCJMNNJPK += Time.deltaTime * this._verticalJump * 70f;
			float y = Mathf.Clamp01(342f - this._scanLineJitter * 1464f);
			float x = 1418f + Mathf.Pow(this._scanLineJitter, 206f) * 613f;
			this.ICDKGPONKKA.SetVector("", new Vector2(x, y));
			Vector2 v = new Vector2(this._verticalJump, this.FFNCJMNNJPK);
			this.ICDKGPONKKA.SetVector("XXX", v);
			this.ICDKGPONKKA.SetFloat("dor", this._horizontalShake * 1671f);
			Vector2 v2 = new Vector2(this._colorDrift * 367f, Time.time * 551f);
			this.ICDKGPONKKA.SetVector("cardschar", v2);
			Graphics.Blit(AFNODOLBBKG, FAEOBMIDDPN, this.ICDKGPONKKA);
		}

		// Token: 0x06008094 RID: 32916 RVA: 0x0038CECF File Offset: 0x0038B0CF
		public void PPJJEEJEBNL(float AJLPALFJHCC)
		{
			this._verticalJump = AJLPALFJHCC;
		}

		// Token: 0x06008095 RID: 32917 RVA: 0x0038CEF9 File Offset: 0x0038B0F9
		public void HMGNIPBBOGB(float AJLPALFJHCC)
		{
			this._colorDrift = AJLPALFJHCC;
		}

		// Token: 0x06008096 RID: 32918 RVA: 0x0038D033 File Offset: 0x0038B233
		public void FMPMDAEIKJE(float AJLPALFJHCC)
		{
			this._horizontalShake = AJLPALFJHCC;
		}

		// Token: 0x06008097 RID: 32919 RVA: 0x0038CED8 File Offset: 0x0038B0D8
		public float IIKCCKLHAGP()
		{
			return this._verticalJump;
		}

		// Token: 0x06008098 RID: 32920 RVA: 0x0038CEC7 File Offset: 0x0038B0C7
		public float KGDHLMAADML()
		{
			return this._colorDrift;
		}

		// Token: 0x06008099 RID: 32921 RVA: 0x0038CEC7 File Offset: 0x0038B0C7
		public float GDFHPEHFFHN()
		{
			return this._colorDrift;
		}

		// Token: 0x0600809A RID: 32922 RVA: 0x0038CED8 File Offset: 0x0038B0D8
		public float HLJJKBCMDPM()
		{
			return this._verticalJump;
		}

		// Token: 0x0600809B RID: 32923 RVA: 0x0038CED8 File Offset: 0x0038B0D8
		public float HNLPGLPDACJ()
		{
			return this._verticalJump;
		}

		// Token: 0x0600809C RID: 32924 RVA: 0x0038CEC7 File Offset: 0x0038B0C7
		public float MBBBBEPBKFM()
		{
			return this._colorDrift;
		}

		// Token: 0x0600809D RID: 32925 RVA: 0x0038D62C File Offset: 0x0038B82C
		private void OnRenderImage(RenderTexture AFNODOLBBKG, RenderTexture FAEOBMIDDPN)
		{
			if (this.ICDKGPONKKA == null)
			{
				this.ICDKGPONKKA = new Material(this._shader);
				this.ICDKGPONKKA.hideFlags = HideFlags.DontSave;
			}
			this.FFNCJMNNJPK += Time.deltaTime * this._verticalJump * 11.3f;
			float y = Mathf.Clamp01(1f - this._scanLineJitter * 1.2f);
			float x = 0.002f + Mathf.Pow(this._scanLineJitter, 3f) * 0.05f;
			this.ICDKGPONKKA.SetVector("_ScanLineJitter", new Vector2(x, y));
			Vector2 v = new Vector2(this._verticalJump, this.FFNCJMNNJPK);
			this.ICDKGPONKKA.SetVector("_VerticalJump", v);
			this.ICDKGPONKKA.SetFloat("_HorizontalShake", this._horizontalShake * 0.2f);
			Vector2 v2 = new Vector2(this._colorDrift * 0.04f, Time.time * 606.11f);
			this.ICDKGPONKKA.SetVector("_ColorDrift", v2);
			Graphics.Blit(AFNODOLBBKG, FAEOBMIDDPN, this.ICDKGPONKKA);
		}

		// Token: 0x0600809F RID: 32927 RVA: 0x0038CED8 File Offset: 0x0038B0D8
		public float HFEBNFMOPGN()
		{
			return this._verticalJump;
		}

		// Token: 0x060080A0 RID: 32928 RVA: 0x0038D033 File Offset: 0x0038B233
		public void PLJEKGCBOIF(float AJLPALFJHCC)
		{
			this._horizontalShake = AJLPALFJHCC;
		}

		// Token: 0x060080A1 RID: 32929 RVA: 0x0038CEC7 File Offset: 0x0038B0C7
		public float AHDLDLKDNJF()
		{
			return this._colorDrift;
		}

		// Token: 0x060080A2 RID: 32930 RVA: 0x0038CEF9 File Offset: 0x0038B0F9
		public void FIGPOGKLIHB(float AJLPALFJHCC)
		{
			this._colorDrift = AJLPALFJHCC;
		}

		// Token: 0x060080A3 RID: 32931 RVA: 0x0038CEE0 File Offset: 0x0038B0E0
		public float LHBLIPNAODO()
		{
			return this._scanLineJitter;
		}

		// Token: 0x060080A4 RID: 32932 RVA: 0x0038D75C File Offset: 0x0038B95C
		private void PJCHMHHEOIP(RenderTexture AFNODOLBBKG, RenderTexture FAEOBMIDDPN)
		{
			if (this.ICDKGPONKKA == null)
			{
				this.ICDKGPONKKA = new Material(this._shader);
				this.ICDKGPONKKA.hideFlags = ~(HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.DontUnloadUnusedAsset);
			}
			this.FFNCJMNNJPK += Time.deltaTime * this._verticalJump * 1180f;
			float y = Mathf.Clamp01(1779f - this._scanLineJitter * 248f);
			float x = 531f + Mathf.Pow(this._scanLineJitter, 1505f) * 524f;
			this.ICDKGPONKKA.SetVector("avatarcollectionssubrequiredtitle", new Vector2(x, y));
			Vector2 v = new Vector2(this._verticalJump, this.FFNCJMNNJPK);
			this.ICDKGPONKKA.SetVector("skinshopunlocknow", v);
			this.ICDKGPONKKA.SetFloat("", this._horizontalShake * 1047f);
			Vector2 v2 = new Vector2(this._colorDrift * 1712f, Time.time * 452f);
			this.ICDKGPONKKA.SetVector("OnPopupStoryRestartManagerRestartStory2", v2);
			Graphics.Blit(AFNODOLBBKG, FAEOBMIDDPN, this.ICDKGPONKKA);
		}

		// Token: 0x060080A5 RID: 32933 RVA: 0x0038D88C File Offset: 0x0038BA8C
		private void ANIABEJPMND(RenderTexture AFNODOLBBKG, RenderTexture FAEOBMIDDPN)
		{
			if (this.ICDKGPONKKA == null)
			{
				this.ICDKGPONKKA = new Material(this._shader);
				this.ICDKGPONKKA.hideFlags = ~(HideFlags.DontSaveInEditor | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
			}
			this.FFNCJMNNJPK += Time.deltaTime * this._verticalJump * 282f;
			float y = Mathf.Clamp01(1361f - this._scanLineJitter * 387f);
			float x = 1399f + Mathf.Pow(this._scanLineJitter, 542f) * 1849f;
			this.ICDKGPONKKA.SetVector("cdnerror", new Vector2(x, y));
			Vector2 v = new Vector2(this._verticalJump, this.FFNCJMNNJPK);
			this.ICDKGPONKKA.SetVector("", v);
			this.ICDKGPONKKA.SetFloat("Z", this._horizontalShake * 700f);
			Vector2 v2 = new Vector2(this._colorDrift * 245f, Time.time * 1111f);
			this.ICDKGPONKKA.SetVector("", v2);
			Graphics.Blit(AFNODOLBBKG, FAEOBMIDDPN, this.ICDKGPONKKA);
		}

		// Token: 0x060080A6 RID: 32934 RVA: 0x0038CEF1 File Offset: 0x0038B0F1
		public float IIKOHPNGDDP()
		{
			return this._horizontalShake;
		}

		// Token: 0x060080A7 RID: 32935 RVA: 0x0038CED8 File Offset: 0x0038B0D8
		public float BFPCBDNGGME()
		{
			return this._verticalJump;
		}

		// Token: 0x060080A8 RID: 32936 RVA: 0x0038D033 File Offset: 0x0038B233
		public void MLCODPHMHHM(float AJLPALFJHCC)
		{
			this._horizontalShake = AJLPALFJHCC;
		}

		// Token: 0x060080A9 RID: 32937 RVA: 0x0038CED8 File Offset: 0x0038B0D8
		public float JPBCFPAMLNB()
		{
			return this._verticalJump;
		}

		// Token: 0x060080AA RID: 32938 RVA: 0x0038CECF File Offset: 0x0038B0CF
		public void JDPIEBCHLFE(float AJLPALFJHCC)
		{
			this._verticalJump = AJLPALFJHCC;
		}

		// Token: 0x060080AB RID: 32939 RVA: 0x0038CEE8 File Offset: 0x0038B0E8
		public void NBJPFBOKLPM(float AJLPALFJHCC)
		{
			this._scanLineJitter = AJLPALFJHCC;
		}

		// Token: 0x060080AC RID: 32940 RVA: 0x0038D033 File Offset: 0x0038B233
		public void KEOPFFFJDJH(float AJLPALFJHCC)
		{
			this._horizontalShake = AJLPALFJHCC;
		}

		// Token: 0x060080AD RID: 32941 RVA: 0x0038D9BC File Offset: 0x0038BBBC
		private void PIAKBHKKCPD(RenderTexture AFNODOLBBKG, RenderTexture FAEOBMIDDPN)
		{
			if (this.ICDKGPONKKA == null)
			{
				this.ICDKGPONKKA = new Material(this._shader);
				this.ICDKGPONKKA.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.NotEditable | HideFlags.DontUnloadUnusedAsset);
			}
			this.FFNCJMNNJPK += Time.deltaTime * this._verticalJump * 1266f;
			float y = Mathf.Clamp01(843f - this._scanLineJitter * 1904f);
			float x = 1494f + Mathf.Pow(this._scanLineJitter, 1826f) * 1445f;
			this.ICDKGPONKKA.SetVector("avatarcollectionssubrequiredtitle", new Vector2(x, y));
			Vector2 v = new Vector2(this._verticalJump, this.FFNCJMNNJPK);
			this.ICDKGPONKKA.SetVector("favchrstr", v);
			this.ICDKGPONKKA.SetFloat(" ", this._horizontalShake * 303f);
			Vector2 v2 = new Vector2(this._colorDrift * 1816f, Time.time * 303f);
			this.ICDKGPONKKA.SetVector("c", v2);
			Graphics.Blit(AFNODOLBBKG, FAEOBMIDDPN, this.ICDKGPONKKA);
		}

		// Token: 0x060080AF RID: 32943 RVA: 0x0038CED8 File Offset: 0x0038B0D8
		public float CHJMEDLOKGD()
		{
			return this._verticalJump;
		}

		// Token: 0x060080B0 RID: 32944 RVA: 0x0038CEF9 File Offset: 0x0038B0F9
		public void IHNINNOIKIC(float AJLPALFJHCC)
		{
			this._colorDrift = AJLPALFJHCC;
		}

		// Token: 0x060080B1 RID: 32945 RVA: 0x0038CECF File Offset: 0x0038B0CF
		public void CAPKLMMGCKF(float AJLPALFJHCC)
		{
			this._verticalJump = AJLPALFJHCC;
		}

		// Token: 0x060080B2 RID: 32946 RVA: 0x0038CEE0 File Offset: 0x0038B0E0
		public float FKLMACALDOE()
		{
			return this._scanLineJitter;
		}

		// Token: 0x060080B3 RID: 32947 RVA: 0x0038CEE8 File Offset: 0x0038B0E8
		public void DPELLDCJGAP(float AJLPALFJHCC)
		{
			this._scanLineJitter = AJLPALFJHCC;
		}

		// Token: 0x060080B4 RID: 32948 RVA: 0x0038D033 File Offset: 0x0038B233
		public void GJCKDIEEBBK(float AJLPALFJHCC)
		{
			this._horizontalShake = AJLPALFJHCC;
		}

		// Token: 0x060080B5 RID: 32949 RVA: 0x0038CEE0 File Offset: 0x0038B0E0
		public float PIPPLCOOFLN()
		{
			return this._scanLineJitter;
		}

		// Token: 0x060080B6 RID: 32950 RVA: 0x0038DAEC File Offset: 0x0038BCEC
		private void FLLHFAKDCCF(RenderTexture AFNODOLBBKG, RenderTexture FAEOBMIDDPN)
		{
			if (this.ICDKGPONKKA == null)
			{
				this.ICDKGPONKKA = new Material(this._shader);
				this.ICDKGPONKKA.hideFlags = (HideFlags.HideInHierarchy | HideFlags.NotEditable);
			}
			this.FFNCJMNNJPK += Time.deltaTime * this._verticalJump * 965f;
			float y = Mathf.Clamp01(757f - this._scanLineJitter * 1097f);
			float x = 1098f + Mathf.Pow(this._scanLineJitter, 765f) * 1987f;
			this.ICDKGPONKKA.SetVector("StoryItemManager.Initialize() - _item is null.", new Vector2(x, y));
			Vector2 v = new Vector2(this._verticalJump, this.FFNCJMNNJPK);
			this.ICDKGPONKKA.SetVector("black", v);
			this.ICDKGPONKKA.SetFloat("", this._horizontalShake * 819f);
			Vector2 v2 = new Vector2(this._colorDrift * 1205f, Time.time * 1540f);
			this.ICDKGPONKKA.SetVector("", v2);
			Graphics.Blit(AFNODOLBBKG, FAEOBMIDDPN, this.ICDKGPONKKA);
		}

		// Token: 0x060080B7 RID: 32951 RVA: 0x0038DC1C File Offset: 0x0038BE1C
		private void KLMLPONDJPC(RenderTexture AFNODOLBBKG, RenderTexture FAEOBMIDDPN)
		{
			if (this.ICDKGPONKKA == null)
			{
				this.ICDKGPONKKA = new Material(this._shader);
				this.ICDKGPONKKA.hideFlags = ~HideFlags.NotEditable;
			}
			this.FFNCJMNNJPK += Time.deltaTime * this._verticalJump * 816f;
			float y = Mathf.Clamp01(328f - this._scanLineJitter * 1536f);
			float x = 1287f + Mathf.Pow(this._scanLineJitter, 202f) * 1707f;
			this.ICDKGPONKKA.SetVector("lck", new Vector2(x, y));
			Vector2 v = new Vector2(this._verticalJump, this.FFNCJMNNJPK);
			this.ICDKGPONKKA.SetVector("", v);
			this.ICDKGPONKKA.SetFloat("Vol", this._horizontalShake * 1655f);
			Vector2 v2 = new Vector2(this._colorDrift * 1313f, Time.time * 152f);
			this.ICDKGPONKKA.SetVector("OnUserpassLoginFailed", v2);
			Graphics.Blit(AFNODOLBBKG, FAEOBMIDDPN, this.ICDKGPONKKA);
		}

		// Token: 0x060080B8 RID: 32952 RVA: 0x0038CED8 File Offset: 0x0038B0D8
		public float AKJIGCJGFMP()
		{
			return this._verticalJump;
		}

		// Token: 0x060080B9 RID: 32953 RVA: 0x0038DD4C File Offset: 0x0038BF4C
		private void EMAHKNFJLJP(RenderTexture AFNODOLBBKG, RenderTexture FAEOBMIDDPN)
		{
			if (this.ICDKGPONKKA == null)
			{
				this.ICDKGPONKKA = new Material(this._shader);
				this.ICDKGPONKKA.hideFlags = (HideFlags)121;
			}
			this.FFNCJMNNJPK += Time.deltaTime * this._verticalJump * 1615f;
			float y = Mathf.Clamp01(858f - this._scanLineJitter * 1503f);
			float x = 450f + Mathf.Pow(this._scanLineJitter, 300f) * 1501f;
			this.ICDKGPONKKA.SetVector("abs", new Vector2(x, y));
			Vector2 v = new Vector2(this._verticalJump, this.FFNCJMNNJPK);
			this.ICDKGPONKKA.SetVector("yes", v);
			this.ICDKGPONKKA.SetFloat("uid", this._horizontalShake * 1823f);
			Vector2 v2 = new Vector2(this._colorDrift * 239f, Time.time * 800f);
			this.ICDKGPONKKA.SetVector("CustomCodeCallback - lastCallbackObj not confirmed. Killing response execution.", v2);
			Graphics.Blit(AFNODOLBBKG, FAEOBMIDDPN, this.ICDKGPONKKA);
		}

		// Token: 0x060080BA RID: 32954 RVA: 0x0038CEE0 File Offset: 0x0038B0E0
		public float AADJBKIFICC()
		{
			return this._scanLineJitter;
		}

		// Token: 0x060080BB RID: 32955 RVA: 0x0038CEC7 File Offset: 0x0038B0C7
		public float MPLHGIMIHOC()
		{
			return this._colorDrift;
		}

		// Token: 0x060080BC RID: 32956 RVA: 0x0038CEE0 File Offset: 0x0038B0E0
		public float AJLDIPOKLAO()
		{
			return this._scanLineJitter;
		}

		// Token: 0x060080BD RID: 32957 RVA: 0x0038D033 File Offset: 0x0038B233
		public void CAPJDHLECLL(float AJLPALFJHCC)
		{
			this._horizontalShake = AJLPALFJHCC;
		}

		// Token: 0x060080BE RID: 32958 RVA: 0x0038CEF1 File Offset: 0x0038B0F1
		public float FENKIPMLGLM()
		{
			return this._horizontalShake;
		}

		// Token: 0x060080BF RID: 32959 RVA: 0x0038D033 File Offset: 0x0038B233
		public void KDPFILNEODL(float AJLPALFJHCC)
		{
			this._horizontalShake = AJLPALFJHCC;
		}

		// Token: 0x060080C0 RID: 32960 RVA: 0x0038DE7C File Offset: 0x0038C07C
		private void EGDADKFJMIF(RenderTexture AFNODOLBBKG, RenderTexture FAEOBMIDDPN)
		{
			if (this.ICDKGPONKKA == null)
			{
				this.ICDKGPONKKA = new Material(this._shader);
				this.ICDKGPONKKA.hideFlags = HideFlags.NotEditable;
			}
			this.FFNCJMNNJPK += Time.deltaTime * this._verticalJump * 166f;
			float y = Mathf.Clamp01(1291f - this._scanLineJitter * 228f);
			float x = 416f + Mathf.Pow(this._scanLineJitter, 1676f) * 1270f;
			this.ICDKGPONKKA.SetVector("OnLoungeScreenAssetsDownloadFailed", new Vector2(x, y));
			Vector2 v = new Vector2(this._verticalJump, this.FFNCJMNNJPK);
			this.ICDKGPONKKA.SetVector("PurchaseManagerUnity.OnProductsFetchedFailed(): ", v);
			this.ICDKGPONKKA.SetFloat(" ", this._horizontalShake * 1779f);
			Vector2 v2 = new Vector2(this._colorDrift * 1128f, Time.time * 1595f);
			this.ICDKGPONKKA.SetVector(") shopsku(", v2);
			Graphics.Blit(AFNODOLBBKG, FAEOBMIDDPN, this.ICDKGPONKKA);
		}

		// Token: 0x060080C1 RID: 32961 RVA: 0x0038CEF1 File Offset: 0x0038B0F1
		public float OGLAJMCKIAB()
		{
			return this._horizontalShake;
		}

		// Token: 0x060080C2 RID: 32962 RVA: 0x0038CEE8 File Offset: 0x0038B0E8
		public void AONGBEMPAAE(float AJLPALFJHCC)
		{
			this._scanLineJitter = AJLPALFJHCC;
		}

		// Token: 0x060080C3 RID: 32963 RVA: 0x0038CEF1 File Offset: 0x0038B0F1
		public float BPPFLOJMBBI()
		{
			return this._horizontalShake;
		}

		// Token: 0x060080C4 RID: 32964 RVA: 0x0038CEE8 File Offset: 0x0038B0E8
		public void LIEIKOBOAME(float AJLPALFJHCC)
		{
			this._scanLineJitter = AJLPALFJHCC;
		}

		// Token: 0x060080C5 RID: 32965 RVA: 0x0038CEE0 File Offset: 0x0038B0E0
		public float DIAPKJIELHL()
		{
			return this._scanLineJitter;
		}

		// Token: 0x060080C7 RID: 32967 RVA: 0x0038CEF1 File Offset: 0x0038B0F1
		public float HBAGHGBPBFL()
		{
			return this._horizontalShake;
		}

		// Token: 0x060080C8 RID: 32968 RVA: 0x0038D033 File Offset: 0x0038B233
		public void KNAHKOFPBIN(float AJLPALFJHCC)
		{
			this._horizontalShake = AJLPALFJHCC;
		}

		// Token: 0x060080C9 RID: 32969 RVA: 0x0038CEC7 File Offset: 0x0038B0C7
		public float POAIMMKFKJN()
		{
			return this._colorDrift;
		}

		// Token: 0x060080CA RID: 32970 RVA: 0x0038CEE8 File Offset: 0x0038B0E8
		public void GBEJAHOJKHA(float AJLPALFJHCC)
		{
			this._scanLineJitter = AJLPALFJHCC;
		}

		// Token: 0x060080CB RID: 32971 RVA: 0x0038CEE8 File Offset: 0x0038B0E8
		public void IINCOPCFEAJ(float AJLPALFJHCC)
		{
			this._scanLineJitter = AJLPALFJHCC;
		}

		// Token: 0x060080CC RID: 32972 RVA: 0x0038DFAC File Offset: 0x0038C1AC
		private void LMFCOOFEHOA(RenderTexture AFNODOLBBKG, RenderTexture FAEOBMIDDPN)
		{
			if (this.ICDKGPONKKA == null)
			{
				this.ICDKGPONKKA = new Material(this._shader);
				this.ICDKGPONKKA.hideFlags = (HideFlags)(-65);
			}
			this.FFNCJMNNJPK += Time.deltaTime * this._verticalJump * 1823f;
			float y = Mathf.Clamp01(1322f - this._scanLineJitter * 1539f);
			float x = 350f + Mathf.Pow(this._scanLineJitter, 1314f) * 549f;
			this.ICDKGPONKKA.SetVector("’", new Vector2(x, y));
			Vector2 v = new Vector2(this._verticalJump, this.FFNCJMNNJPK);
			this.ICDKGPONKKA.SetVector("Asset bundle assets destroyed:", v);
			this.ICDKGPONKKA.SetFloat("ok", this._horizontalShake * 676f);
			Vector2 v2 = new Vector2(this._colorDrift * 315f, Time.time * 77f);
			this.ICDKGPONKKA.SetVector("congratstitle", v2);
			Graphics.Blit(AFNODOLBBKG, FAEOBMIDDPN, this.ICDKGPONKKA);
		}

		// Token: 0x060080CE RID: 32974 RVA: 0x0038CECF File Offset: 0x0038B0CF
		public void BCJLMFECNLN(float AJLPALFJHCC)
		{
			this._verticalJump = AJLPALFJHCC;
		}

		// Token: 0x060080CF RID: 32975 RVA: 0x0038CEC7 File Offset: 0x0038B0C7
		public float BCPHLKCAOKN()
		{
			return this._colorDrift;
		}

		// Token: 0x060080D0 RID: 32976 RVA: 0x0038CEF9 File Offset: 0x0038B0F9
		public void MPJNPEGOPLH(float AJLPALFJHCC)
		{
			this._colorDrift = AJLPALFJHCC;
		}

		// Token: 0x060080D1 RID: 32977 RVA: 0x0038CEC7 File Offset: 0x0038B0C7
		public float KLBAAFIPFLP()
		{
			return this._colorDrift;
		}

		// Token: 0x060080D2 RID: 32978 RVA: 0x0038CEE8 File Offset: 0x0038B0E8
		public void JBFGDJHFJLG(float AJLPALFJHCC)
		{
			this._scanLineJitter = AJLPALFJHCC;
		}

		// Token: 0x060080D3 RID: 32979 RVA: 0x0038CEE8 File Offset: 0x0038B0E8
		public void DNAGIKIMMJJ(float AJLPALFJHCC)
		{
			this._scanLineJitter = AJLPALFJHCC;
		}

		// Token: 0x060080D4 RID: 32980 RVA: 0x0038D033 File Offset: 0x0038B233
		public void LDBANLJMJDI(float AJLPALFJHCC)
		{
			this._horizontalShake = AJLPALFJHCC;
		}

		// Token: 0x060080D5 RID: 32981 RVA: 0x0038CEF9 File Offset: 0x0038B0F9
		public void PHCJCOAEGKO(float AJLPALFJHCC)
		{
			this._colorDrift = AJLPALFJHCC;
		}

		// Token: 0x060080D6 RID: 32982 RVA: 0x0038CEF9 File Offset: 0x0038B0F9
		public void NMEILIGJBJK(float AJLPALFJHCC)
		{
			this._colorDrift = AJLPALFJHCC;
		}

		// Token: 0x060080D7 RID: 32983 RVA: 0x0038CEC7 File Offset: 0x0038B0C7
		public float MIOKGJLCAOH()
		{
			return this._colorDrift;
		}

		// Token: 0x060080D8 RID: 32984 RVA: 0x0038CECF File Offset: 0x0038B0CF
		public void MNJHMIJJFEK(float AJLPALFJHCC)
		{
			this._verticalJump = AJLPALFJHCC;
		}

		// Token: 0x060080D9 RID: 32985 RVA: 0x0038CEC7 File Offset: 0x0038B0C7
		public float LACIJIJADNE()
		{
			return this._colorDrift;
		}

		// Token: 0x060080DA RID: 32986 RVA: 0x0038CEC7 File Offset: 0x0038B0C7
		public float OMCIMLCGOHJ()
		{
			return this._colorDrift;
		}

		// Token: 0x060080DB RID: 32987 RVA: 0x0038CECF File Offset: 0x0038B0CF
		public void PBAECJAEBKD(float AJLPALFJHCC)
		{
			this._verticalJump = AJLPALFJHCC;
		}

		// Token: 0x060080DC RID: 32988 RVA: 0x0038CED8 File Offset: 0x0038B0D8
		public float GNIPAEBGDCC()
		{
			return this._verticalJump;
		}

		// Token: 0x060080DD RID: 32989 RVA: 0x0038CECF File Offset: 0x0038B0CF
		public void MGOPGINICLH(float AJLPALFJHCC)
		{
			this._verticalJump = AJLPALFJHCC;
		}

		// Token: 0x060080DE RID: 32990 RVA: 0x0038E0DC File Offset: 0x0038C2DC
		private void BIPPKDNDLGB(RenderTexture AFNODOLBBKG, RenderTexture FAEOBMIDDPN)
		{
			if (this.ICDKGPONKKA == null)
			{
				this.ICDKGPONKKA = new Material(this._shader);
				this.ICDKGPONKKA.hideFlags = (HideFlags)(-84);
			}
			this.FFNCJMNNJPK += Time.deltaTime * this._verticalJump * 357f;
			float y = Mathf.Clamp01(563f - this._scanLineJitter * 356f);
			float x = 654f + Mathf.Pow(this._scanLineJitter, 1192f) * 839f;
			this.ICDKGPONKKA.SetVector(" <i>", new Vector2(x, y));
			Vector2 v = new Vector2(this._verticalJump, this.FFNCJMNNJPK);
			this.ICDKGPONKKA.SetVector("_not_found", v);
			this.ICDKGPONKKA.SetFloat("id", this._horizontalShake * 134f);
			Vector2 v2 = new Vector2(this._colorDrift * 950f, Time.time * 573f);
			this.ICDKGPONKKA.SetVector("+", v2);
			Graphics.Blit(AFNODOLBBKG, FAEOBMIDDPN, this.ICDKGPONKKA);
		}

		// Token: 0x060080DF RID: 32991 RVA: 0x0038CEF9 File Offset: 0x0038B0F9
		public void IPDILOGKOCC(float AJLPALFJHCC)
		{
			this._colorDrift = AJLPALFJHCC;
		}

		// Token: 0x060080E0 RID: 32992 RVA: 0x0038CEC7 File Offset: 0x0038B0C7
		public float BCFJHFLDHHP()
		{
			return this._colorDrift;
		}

		// Token: 0x060080E1 RID: 32993 RVA: 0x0038E20C File Offset: 0x0038C40C
		private void BCOMFLDOOCF(RenderTexture AFNODOLBBKG, RenderTexture FAEOBMIDDPN)
		{
			if (this.ICDKGPONKKA == null)
			{
				this.ICDKGPONKKA = new Material(this._shader);
				this.ICDKGPONKKA.hideFlags = (HideFlags)(-72);
			}
			this.FFNCJMNNJPK += Time.deltaTime * this._verticalJump * 379f;
			float y = Mathf.Clamp01(29f - this._scanLineJitter * 1732f);
			float x = 1872f + Mathf.Pow(this._scanLineJitter, 29f) * 1295f;
			this.ICDKGPONKKA.SetVector("CLIENT.SCREEN.AVATAR.", new Vector2(x, y));
			Vector2 v = new Vector2(this._verticalJump, this.FFNCJMNNJPK);
			this.ICDKGPONKKA.SetVector("PurchaseManagerUnity.OnPurchaseConfirmationFailed(): Could not find product in failed confirmation.", v);
			this.ICDKGPONKKA.SetFloat("storyAssetPackManager[i].storyItemsAssets[j] is null!", this._horizontalShake * 462f);
			Vector2 v2 = new Vector2(this._colorDrift * 747f, Time.time * 522f);
			this.ICDKGPONKKA.SetVector("fvrt", v2);
			Graphics.Blit(AFNODOLBBKG, FAEOBMIDDPN, this.ICDKGPONKKA);
		}

		// Token: 0x060080E2 RID: 32994 RVA: 0x0038CEE0 File Offset: 0x0038B0E0
		public float HIAPJGGJICF()
		{
			return this._scanLineJitter;
		}

		// Token: 0x060080E3 RID: 32995 RVA: 0x0038CED8 File Offset: 0x0038B0D8
		public float AMCLJKBDFDO()
		{
			return this._verticalJump;
		}

		// Token: 0x060080E4 RID: 32996 RVA: 0x0038CEF9 File Offset: 0x0038B0F9
		public void ICCJHNCPPLA(float AJLPALFJHCC)
		{
			this._colorDrift = AJLPALFJHCC;
		}

		// Token: 0x060080E5 RID: 32997 RVA: 0x0038CEF9 File Offset: 0x0038B0F9
		public void APLOJCALBDF(float AJLPALFJHCC)
		{
			this._colorDrift = AJLPALFJHCC;
		}

		// Token: 0x060080E6 RID: 32998 RVA: 0x0038CEF1 File Offset: 0x0038B0F1
		public float PGJPHIFIIOP()
		{
			return this._horizontalShake;
		}

		// Token: 0x060080E7 RID: 32999 RVA: 0x0038CECF File Offset: 0x0038B0CF
		public void BNAIDHCFDKJ(float AJLPALFJHCC)
		{
			this._verticalJump = AJLPALFJHCC;
		}

		// Token: 0x060080E8 RID: 33000 RVA: 0x0038CEF9 File Offset: 0x0038B0F9
		public void GEMNKGBKDMO(float AJLPALFJHCC)
		{
			this._colorDrift = AJLPALFJHCC;
		}

		// Token: 0x060080E9 RID: 33001 RVA: 0x0038CEC7 File Offset: 0x0038B0C7
		public float PGOIJJKAJPD()
		{
			return this._colorDrift;
		}

		// Token: 0x060080EA RID: 33002 RVA: 0x0038CEE8 File Offset: 0x0038B0E8
		public void EJCIHHGKMDO(float AJLPALFJHCC)
		{
			this._scanLineJitter = AJLPALFJHCC;
		}

		// Token: 0x060080EB RID: 33003 RVA: 0x0038CEE8 File Offset: 0x0038B0E8
		public void IJDKBKJGMGB(float AJLPALFJHCC)
		{
			this._scanLineJitter = AJLPALFJHCC;
		}

		// Token: 0x060080EC RID: 33004 RVA: 0x0038CEF1 File Offset: 0x0038B0F1
		public float FCLJPFIOOIF()
		{
			return this._horizontalShake;
		}

		// Token: 0x060080ED RID: 33005 RVA: 0x0038CEF1 File Offset: 0x0038B0F1
		public float FEALNOHBDGL()
		{
			return this._horizontalShake;
		}

		// Token: 0x060080EE RID: 33006 RVA: 0x0038CECF File Offset: 0x0038B0CF
		public void IODOJOJHGDK(float AJLPALFJHCC)
		{
			this._verticalJump = AJLPALFJHCC;
		}

		// Token: 0x060080EF RID: 33007 RVA: 0x0038E33C File Offset: 0x0038C53C
		private void DIDMBBIIFEG(RenderTexture AFNODOLBBKG, RenderTexture FAEOBMIDDPN)
		{
			if (this.ICDKGPONKKA == null)
			{
				this.ICDKGPONKKA = new Material(this._shader);
				this.ICDKGPONKKA.hideFlags = (HideFlags)113;
			}
			this.FFNCJMNNJPK += Time.deltaTime * this._verticalJump * 973f;
			float y = Mathf.Clamp01(293f - this._scanLineJitter * 361f);
			float x = 114f + Mathf.Pow(this._scanLineJitter, 645f) * 656f;
			this.ICDKGPONKKA.SetVector("aind", new Vector2(x, y));
			Vector2 v = new Vector2(this._verticalJump, this.FFNCJMNNJPK);
			this.ICDKGPONKKA.SetVector("wind", v);
			this.ICDKGPONKKA.SetFloat("،", this._horizontalShake * 1731f);
			Vector2 v2 = new Vector2(this._colorDrift * 1864f, Time.time * 125f);
			this.ICDKGPONKKA.SetVector("oldvhsovr", v2);
			Graphics.Blit(AFNODOLBBKG, FAEOBMIDDPN, this.ICDKGPONKKA);
		}

		// Token: 0x060080F0 RID: 33008 RVA: 0x0038CEF9 File Offset: 0x0038B0F9
		public void NIDGPGBKEOD(float AJLPALFJHCC)
		{
			this._colorDrift = AJLPALFJHCC;
		}

		// Token: 0x040024DD RID: 9437
		[Range(0f, 1f)]
		[SerializeField]
		public float _scanLineJitter;

		// Token: 0x040024DE RID: 9438
		[Range(0f, 1f)]
		[SerializeField]
		public float _verticalJump;

		// Token: 0x040024DF RID: 9439
		[Range(0f, 1f)]
		[SerializeField]
		public float _horizontalShake;

		// Token: 0x040024E0 RID: 9440
		[Range(0f, 1f)]
		[SerializeField]
		public float _colorDrift;

		// Token: 0x040024E1 RID: 9441
		[SerializeField]
		private Shader _shader;

		// Token: 0x040024E2 RID: 9442
		private Material ICDKGPONKKA;

		// Token: 0x040024E3 RID: 9443
		private float FFNCJMNNJPK;
	}
}
