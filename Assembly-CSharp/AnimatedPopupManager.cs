using System;
using System.Runtime.CompilerServices;
using DG.Tweening;
using DG.Tweening.Core;
using DG.Tweening.Plugins.Options;
using UnityEngine;

// Token: 0x02000430 RID: 1072
public class AnimatedPopupManager : MonoBehaviour
{
	// Token: 0x060080F1 RID: 33009 RVA: 0x0038E46B File Offset: 0x0038C66B
	private float LBHDOMFILOJ()
	{
		return this.PANMNKKODPC.alpha;
	}

	// Token: 0x060080F2 RID: 33010 RVA: 0x0038E478 File Offset: 0x0038C678
	private void BNANAJBKJNJ(float OBNBCGOIMKE)
	{
		this.PANMNKKODPC.alpha = OBNBCGOIMKE;
	}

	// Token: 0x060080F3 RID: 33011 RVA: 0x0038E478 File Offset: 0x0038C678
	private void JPAEFKPBKLI(float OBNBCGOIMKE)
	{
		this.PANMNKKODPC.alpha = OBNBCGOIMKE;
	}

	// Token: 0x060080F4 RID: 33012 RVA: 0x0038E486 File Offset: 0x0038C686
	private void HOBFHALODDA()
	{
		if (this.KILEPJLBDDF.Length > 1)
		{
			AOBJLALDBAA.EHBBFMCILPC.FDKBIBKABCM(this.KILEPJLBDDF, this.PIDODLGKFEP);
			this.KILEPJLBDDF = "CLIENT.POSTEFFECTS.ANALOGGLITCH20.OVR";
		}
		base.gameObject.SetActive(false);
	}

	// Token: 0x060080F5 RID: 33013 RVA: 0x0038E478 File Offset: 0x0038C678
	private void ECFEGCLHKDA(float OBNBCGOIMKE)
	{
		this.PANMNKKODPC.alpha = OBNBCGOIMKE;
	}

	// Token: 0x060080F6 RID: 33014 RVA: 0x0038E46B File Offset: 0x0038C66B
	private float PPNDFHNCNGA()
	{
		return this.PANMNKKODPC.alpha;
	}

	// Token: 0x060080F7 RID: 33015 RVA: 0x0038E4C4 File Offset: 0x0038C6C4
	public void GFEHJHIDHFF()
	{
		this.IIPJFOKEMKJ.DOComplete(false);
		if (!this.MHPDBPJKCFF)
		{
			this.IIPJFOKEMKJ.anchoredPosition = this.NFLDDAOGIKG + this.BOCLEIKKEFF;
			this.IIPJFOKEMKJ.DOAnchorPos(this.IIPJFOKEMKJ.anchoredPosition + new Vector2(-this.hideAnimationOffsetX * (float)this.MBENFBDELJC, -this.hideAnimationOffsetY * (float)this.MBENFBDELJC), 1608f, false).SetEase(Ease.InCubic).OnComplete(new TweenCallback(this.KBOBMBPMJFC));
		}
		else
		{
			this.IIPJFOKEMKJ.anchoredPosition = this.NFLDDAOGIKG + this.BOCLEIKKEFF;
			this.IIPJFOKEMKJ.DOAnchorPos(this.IIPJFOKEMKJ.anchoredPosition + new Vector2(-this.hideAnimationOffsetY * (float)this.MBENFBDELJC, -this.hideAnimationOffsetX * (float)this.MBENFBDELJC), 318f, false).SetEase(Ease.OutSine).OnComplete(new TweenCallback(this.FPNLPAOGMDD));
		}
		this.PANMNKKODPC.DOComplete(true);
		this.PANMNKKODPC.alpha = 720f;
		DOTween.To(new DOGetter<float>(this.MEJEPCAGOPK), new DOSetter<float>(this.MCFKLINCKFA), 792f, 586f).SetEase(Ease.InSine);
	}

	// Token: 0x060080F8 RID: 33016 RVA: 0x0038E623 File Offset: 0x0038C823
	private void PBLDIMHDNNJ()
	{
		if (AppManager.isQuitting)
		{
			return;
		}
		this.IIPJFOKEMKJ.DOComplete(true);
		this.PANMNKKODPC.DOComplete(false);
	}

	// Token: 0x060080F9 RID: 33017 RVA: 0x0038E647 File Offset: 0x0038C847
	private void HHNCPEKBPLD()
	{
		if (this.KILEPJLBDDF.Length > 0)
		{
			AOBJLALDBAA.FILDBDMENPG().CIGLHCJDDPI(this.KILEPJLBDDF, this.PIDODLGKFEP);
			this.KILEPJLBDDF = "";
		}
		base.gameObject.SetActive(true);
	}

	// Token: 0x060080FA RID: 33018 RVA: 0x0038E684 File Offset: 0x0038C884
	private void OnDisable()
	{
		if (AppManager.isQuitting)
		{
			return;
		}
		this.IIPJFOKEMKJ.DOComplete(false);
		this.PANMNKKODPC.DOComplete(false);
	}

	// Token: 0x060080FB RID: 33019 RVA: 0x0038E6A8 File Offset: 0x0038C8A8
	public void HJEDGHNBMKG(float KOILDMNMMMI, float KFDNLKIGJJJ)
	{
		this.BOCLEIKKEFF = new Vector2(KOILDMNMMMI, KFDNLKIGJJJ);
	}

	// Token: 0x060080FC RID: 33020 RVA: 0x0038E6B7 File Offset: 0x0038C8B7
	private void GMPHANBKGBK()
	{
		this.PANMNKKODPC = base.GetComponent<CanvasGroup>();
		this.IIPJFOKEMKJ = base.GetComponent<RectTransform>();
		this.NFLDDAOGIKG = this.IIPJFOKEMKJ.anchoredPosition;
	}

	// Token: 0x060080FD RID: 33021 RVA: 0x0038E46B File Offset: 0x0038C66B
	private float BJFEPIIGOEF()
	{
		return this.PANMNKKODPC.alpha;
	}

	// Token: 0x060080FE RID: 33022 RVA: 0x0038E478 File Offset: 0x0038C678
	private void GBEFIFFCOCO(float OBNBCGOIMKE)
	{
		this.PANMNKKODPC.alpha = OBNBCGOIMKE;
	}

	// Token: 0x060080FF RID: 33023 RVA: 0x0038E46B File Offset: 0x0038C66B
	[CompilerGenerated]
	private float NBLJLEOMELI()
	{
		return this.PANMNKKODPC.alpha;
	}

	// Token: 0x06008100 RID: 33024 RVA: 0x0038E46B File Offset: 0x0038C66B
	private float BGMINCPAIKK()
	{
		return this.PANMNKKODPC.alpha;
	}

	// Token: 0x06008101 RID: 33025 RVA: 0x0038E6E2 File Offset: 0x0038C8E2
	public float GetHideAnimationTime()
	{
		return 0.35f;
	}

	// Token: 0x06008102 RID: 33026 RVA: 0x0038E46B File Offset: 0x0038C66B
	private float DNGNAHGLCLF()
	{
		return this.PANMNKKODPC.alpha;
	}

	// Token: 0x06008103 RID: 33027 RVA: 0x0038E6E9 File Offset: 0x0038C8E9
	private void AAGKOINJGOL()
	{
		this.LIKHHKBBFBG();
	}

	// Token: 0x06008104 RID: 33028 RVA: 0x0038E6A8 File Offset: 0x0038C8A8
	public void SetPositionOffset(float KOILDMNMMMI, float KFDNLKIGJJJ)
	{
		this.BOCLEIKKEFF = new Vector2(KOILDMNMMMI, KFDNLKIGJJJ);
	}

	// Token: 0x06008105 RID: 33029 RVA: 0x0038E6F1 File Offset: 0x0038C8F1
	private void JOOEKCDDOCH()
	{
		if (this.KILEPJLBDDF.Length > 0)
		{
			AOBJLALDBAA.BIAEAOMHBMM().LPNCDPHNBJK(this.KILEPJLBDDF, this.PIDODLGKFEP);
			this.KILEPJLBDDF = "ZZZ";
		}
		base.gameObject.SetActive(false);
	}

	// Token: 0x06008106 RID: 33030 RVA: 0x0038E72E File Offset: 0x0038C92E
	private void AKIFACAINPL()
	{
		this.ICMNLOPCLGG();
	}

	// Token: 0x06008107 RID: 33031 RVA: 0x0038E736 File Offset: 0x0038C936
	private void KBOBMBPMJFC()
	{
		if (this.KILEPJLBDDF.Length > 1)
		{
			AOBJLALDBAA.AGANFKKBPFO().EGELHPJBAIC(this.KILEPJLBDDF, this.PIDODLGKFEP);
			this.KILEPJLBDDF = "episode";
		}
		base.gameObject.SetActive(false);
	}

	// Token: 0x06008108 RID: 33032 RVA: 0x0038E478 File Offset: 0x0038C678
	private void CMKHNLJMICL(float OBNBCGOIMKE)
	{
		this.PANMNKKODPC.alpha = OBNBCGOIMKE;
	}

	// Token: 0x06008109 RID: 33033 RVA: 0x0038E773 File Offset: 0x0038C973
	public float JFMENGFHHBL()
	{
		return 182f;
	}

	// Token: 0x0600810A RID: 33034 RVA: 0x0038E77A File Offset: 0x0038C97A
	private void GGKNFOGJGME()
	{
		if (this.KILEPJLBDDF.Length > 0)
		{
			AOBJLALDBAA.NMGMNAKLLMI().FDKBIBKABCM(this.KILEPJLBDDF, this.PIDODLGKFEP);
			this.KILEPJLBDDF = "[LoadingEnv] skipped, feature disabled by balance";
		}
		base.gameObject.SetActive(false);
	}

	// Token: 0x0600810B RID: 33035 RVA: 0x0038E478 File Offset: 0x0038C678
	[CompilerGenerated]
	private void IMECGBPDFIG(float OBNBCGOIMKE)
	{
		this.PANMNKKODPC.alpha = OBNBCGOIMKE;
	}

	// Token: 0x0600810C RID: 33036 RVA: 0x0038E46B File Offset: 0x0038C66B
	private float IONLIBKKCJN()
	{
		return this.PANMNKKODPC.alpha;
	}

	// Token: 0x0600810D RID: 33037 RVA: 0x0038E7B7 File Offset: 0x0038C9B7
	public void BKHLDJPJLEH(int LABFAOCNAKK, int FEIJDMMMNJB, bool IEIPKEMNHFM)
	{
		this.EIEBJNLEGEB = LABFAOCNAKK;
		this.MBENFBDELJC = FEIJDMMMNJB;
		this.MHPDBPJKCFF = IEIPKEMNHFM;
	}

	// Token: 0x0600810E RID: 33038 RVA: 0x0038E7CE File Offset: 0x0038C9CE
	private void GHHJBCLEAOB()
	{
		if (this.KILEPJLBDDF.Length > 1)
		{
			AOBJLALDBAA.EHBBFMCILPC.LPNCDPHNBJK(this.KILEPJLBDDF, this.PIDODLGKFEP);
			this.KILEPJLBDDF = "app42error";
		}
		base.gameObject.SetActive(false);
	}

	// Token: 0x0600810F RID: 33039 RVA: 0x0038E6E9 File Offset: 0x0038C8E9
	private void JALCLCADMPK()
	{
		this.LIKHHKBBFBG();
	}

	// Token: 0x06008110 RID: 33040 RVA: 0x0038E80C File Offset: 0x0038CA0C
	public void PIPADCCGHBA()
	{
		this.IIPJFOKEMKJ.DOComplete(true);
		if (!this.MHPDBPJKCFF)
		{
			this.IIPJFOKEMKJ.anchoredPosition = this.NFLDDAOGIKG + this.BOCLEIKKEFF;
			this.IIPJFOKEMKJ.DOAnchorPos(this.IIPJFOKEMKJ.anchoredPosition + new Vector2(-this.hideAnimationOffsetX * (float)this.MBENFBDELJC, -this.hideAnimationOffsetY * (float)this.MBENFBDELJC), 1171f, false).SetEase(Ease.OutSine).OnComplete(new TweenCallback(this.JOOEKCDDOCH));
		}
		else
		{
			this.IIPJFOKEMKJ.anchoredPosition = this.NFLDDAOGIKG + this.BOCLEIKKEFF;
			this.IIPJFOKEMKJ.DOAnchorPos(this.IIPJFOKEMKJ.anchoredPosition + new Vector2(-this.hideAnimationOffsetY * (float)this.MBENFBDELJC, -this.hideAnimationOffsetX * (float)this.MBENFBDELJC), 602f, false).SetEase(Ease.InSine).OnComplete(new TweenCallback(this.OKOKKPBHLIF));
		}
		this.PANMNKKODPC.DOComplete(true);
		this.PANMNKKODPC.alpha = 737f;
		DOTween.To(new DOGetter<float>(this.KLMOMPLDFME), new DOSetter<float>(this.IMECGBPDFIG), 880f, 1955f).SetEase(Ease.InOutSine);
	}

	// Token: 0x06008111 RID: 33041 RVA: 0x0038E96C File Offset: 0x0038CB6C
	public void NBDMOONDIHO()
	{
		this.IIPJFOKEMKJ.DOComplete(true);
		if (!this.MHPDBPJKCFF)
		{
			this.IIPJFOKEMKJ.anchoredPosition = this.NFLDDAOGIKG + this.BOCLEIKKEFF;
			this.IIPJFOKEMKJ.DOAnchorPos(this.IIPJFOKEMKJ.anchoredPosition + new Vector2(-this.hideAnimationOffsetX * (float)this.MBENFBDELJC, -this.hideAnimationOffsetY * (float)this.MBENFBDELJC), 378f, false).SetEase(Ease.InSine).OnComplete(new TweenCallback(this.DHMPOGGGPFI));
		}
		else
		{
			this.IIPJFOKEMKJ.anchoredPosition = this.NFLDDAOGIKG + this.BOCLEIKKEFF;
			this.IIPJFOKEMKJ.DOAnchorPos(this.IIPJFOKEMKJ.anchoredPosition + new Vector2(-this.hideAnimationOffsetY * (float)this.MBENFBDELJC, -this.hideAnimationOffsetX * (float)this.MBENFBDELJC), 525f, true).SetEase(Ease.OutSine).OnComplete(new TweenCallback(this.DHMPOGGGPFI));
		}
		this.PANMNKKODPC.DOComplete(true);
		this.PANMNKKODPC.alpha = 1392f;
		DOTween.To(new DOGetter<float>(this.KLMOMPLDFME), new DOSetter<float>(this.ECFEGCLHKDA), 1276f, 1860f).SetEase(Ease.OutQuad);
	}

	// Token: 0x06008113 RID: 33043 RVA: 0x0038EB2F File Offset: 0x0038CD2F
	public void DKNNLAFOIBG(string NLFGBFMKIIL, float AEOIEDEIMNL = 0f)
	{
		this.KILEPJLBDDF = NLFGBFMKIIL;
		this.PIDODLGKFEP = AEOIEDEIMNL;
		this.GFEHJHIDHFF();
	}

	// Token: 0x06008114 RID: 33044 RVA: 0x0038E478 File Offset: 0x0038C678
	private void NCFCAKEMDKE(float OBNBCGOIMKE)
	{
		this.PANMNKKODPC.alpha = OBNBCGOIMKE;
	}

	// Token: 0x06008115 RID: 33045 RVA: 0x0038E6A8 File Offset: 0x0038C8A8
	public void KKNDDJFBOGH(float KOILDMNMMMI, float KFDNLKIGJJJ)
	{
		this.BOCLEIKKEFF = new Vector2(KOILDMNMMMI, KFDNLKIGJJJ);
	}

	// Token: 0x06008116 RID: 33046 RVA: 0x0038E46B File Offset: 0x0038C66B
	[CompilerGenerated]
	private float FADPGAELJJE()
	{
		return this.PANMNKKODPC.alpha;
	}

	// Token: 0x06008117 RID: 33047 RVA: 0x0038E478 File Offset: 0x0038C678
	private void GBLAGDPHEHD(float OBNBCGOIMKE)
	{
		this.PANMNKKODPC.alpha = OBNBCGOIMKE;
	}

	// Token: 0x06008118 RID: 33048 RVA: 0x0038EB48 File Offset: 0x0038CD48
	public void DDPHFKOHDJB()
	{
		this.IIPJFOKEMKJ.DOComplete(true);
		if (!this.MHPDBPJKCFF)
		{
			this.IIPJFOKEMKJ.anchoredPosition = this.NFLDDAOGIKG + this.BOCLEIKKEFF;
			this.IIPJFOKEMKJ.DOAnchorPos(this.IIPJFOKEMKJ.anchoredPosition + new Vector2(-this.hideAnimationOffsetX * (float)this.MBENFBDELJC, -this.hideAnimationOffsetY * (float)this.MBENFBDELJC), 1089f, false).SetEase(Ease.Unset).OnComplete(new TweenCallback(this.GGKNFOGJGME));
		}
		else
		{
			this.IIPJFOKEMKJ.anchoredPosition = this.NFLDDAOGIKG + this.BOCLEIKKEFF;
			this.IIPJFOKEMKJ.DOAnchorPos(this.IIPJFOKEMKJ.anchoredPosition + new Vector2(-this.hideAnimationOffsetY * (float)this.MBENFBDELJC, -this.hideAnimationOffsetX * (float)this.MBENFBDELJC), 1323f, false).SetEase(Ease.InOutQuad).OnComplete(new TweenCallback(this.FPNLPAOGMDD));
		}
		this.PANMNKKODPC.DOComplete(true);
		this.PANMNKKODPC.alpha = 624f;
		DOTween.To(new DOGetter<float>(this.FADPGAELJJE), new DOSetter<float>(this.NGJDBBHDOHA), 845f, 334f).SetEase(Ease.OutQuad);
	}

	// Token: 0x06008119 RID: 33049 RVA: 0x0038E478 File Offset: 0x0038C678
	private void JIDJOHDPPCJ(float OBNBCGOIMKE)
	{
		this.PANMNKKODPC.alpha = OBNBCGOIMKE;
	}

	// Token: 0x0600811A RID: 33050 RVA: 0x0038E6B7 File Offset: 0x0038C8B7
	private void OOMMKGMBAGK()
	{
		this.PANMNKKODPC = base.GetComponent<CanvasGroup>();
		this.IIPJFOKEMKJ = base.GetComponent<RectTransform>();
		this.NFLDDAOGIKG = this.IIPJFOKEMKJ.anchoredPosition;
	}

	// Token: 0x0600811B RID: 33051 RVA: 0x0038ECA7 File Offset: 0x0038CEA7
	public void EMKNEKFCMDI()
	{
		this.MBENFBDELJC *= -1;
	}

	// Token: 0x0600811C RID: 33052 RVA: 0x0038ECB8 File Offset: 0x0038CEB8
	private void MCHLOADLAJC()
	{
		if (!this.MHPDBPJKCFF)
		{
			this.IIPJFOKEMKJ.anchoredPosition = this.NFLDDAOGIKG + this.BOCLEIKKEFF + new Vector2(-this.showAnimationOffsetX * (float)this.EIEBJNLEGEB, -this.showAnimationOffsetY * (float)this.MBENFBDELJC);
			this.IIPJFOKEMKJ.DOAnchorPos(this.IIPJFOKEMKJ.anchoredPosition + new Vector2(this.showAnimationOffsetX * (float)this.EIEBJNLEGEB, this.showAnimationOffsetY * (float)this.MBENFBDELJC), 1110f, true).SetEase((Ease)98);
		}
		else
		{
			this.IIPJFOKEMKJ.anchoredPosition = this.NFLDDAOGIKG + this.BOCLEIKKEFF + new Vector2(-this.showAnimationOffsetY * (float)this.MBENFBDELJC, -this.showAnimationOffsetX * (float)this.EIEBJNLEGEB);
			this.IIPJFOKEMKJ.DOAnchorPos(this.IIPJFOKEMKJ.anchoredPosition + new Vector2(this.showAnimationOffsetY * (float)this.MBENFBDELJC, this.showAnimationOffsetX * (float)this.EIEBJNLEGEB), 1932f, true).SetEase((Ease)(-68));
		}
		this.PANMNKKODPC.alpha = 903f;
		DOTween.To(new DOGetter<float>(this.BJFEPIIGOEF), new DOSetter<float>(this.JGIEBOKOLOD), 1205f, 1993f).SetEase(Ease.OutExpo);
	}

	// Token: 0x0600811D RID: 33053 RVA: 0x0038E6A8 File Offset: 0x0038C8A8
	public void OJJPPIBPDHM(float KOILDMNMMMI, float KFDNLKIGJJJ)
	{
		this.BOCLEIKKEFF = new Vector2(KOILDMNMMMI, KFDNLKIGJJJ);
	}

	// Token: 0x0600811E RID: 33054 RVA: 0x0038E6B7 File Offset: 0x0038C8B7
	private void Awake()
	{
		this.PANMNKKODPC = base.GetComponent<CanvasGroup>();
		this.IIPJFOKEMKJ = base.GetComponent<RectTransform>();
		this.NFLDDAOGIKG = this.IIPJFOKEMKJ.anchoredPosition;
	}

	// Token: 0x0600811F RID: 33055 RVA: 0x0038E478 File Offset: 0x0038C678
	private void FDAKKLFKCHP(float OBNBCGOIMKE)
	{
		this.PANMNKKODPC.alpha = OBNBCGOIMKE;
	}

	// Token: 0x06008120 RID: 33056 RVA: 0x0038E7B7 File Offset: 0x0038C9B7
	public void NBLIPHEJOPH(int LABFAOCNAKK, int FEIJDMMMNJB, bool IEIPKEMNHFM)
	{
		this.EIEBJNLEGEB = LABFAOCNAKK;
		this.MBENFBDELJC = FEIJDMMMNJB;
		this.MHPDBPJKCFF = IEIPKEMNHFM;
	}

	// Token: 0x06008121 RID: 33057 RVA: 0x0038EE30 File Offset: 0x0038D030
	private void PELECOADPMJ()
	{
		if (this.KILEPJLBDDF.Length > 0)
		{
			AOBJLALDBAA.EHBBFMCILPC.EGELHPJBAIC(this.KILEPJLBDDF, this.PIDODLGKFEP);
			this.KILEPJLBDDF = "";
		}
		base.gameObject.SetActive(false);
	}

	// Token: 0x06008122 RID: 33058 RVA: 0x0038EE6D File Offset: 0x0038D06D
	public float NMCPFPDINPC()
	{
		return 1559f;
	}

	// Token: 0x06008123 RID: 33059 RVA: 0x0038E684 File Offset: 0x0038C884
	private void BOOIDAKDEHP()
	{
		if (AppManager.isQuitting)
		{
			return;
		}
		this.IIPJFOKEMKJ.DOComplete(false);
		this.PANMNKKODPC.DOComplete(false);
	}

	// Token: 0x06008124 RID: 33060 RVA: 0x0038EE74 File Offset: 0x0038D074
	public void FJMPJFFDAKM(string NLFGBFMKIIL, float AEOIEDEIMNL = 0f)
	{
		this.KILEPJLBDDF = NLFGBFMKIIL;
		this.PIDODLGKFEP = AEOIEDEIMNL;
		this.GLIAGHMNMMP();
	}

	// Token: 0x06008125 RID: 33061 RVA: 0x0038EE8C File Offset: 0x0038D08C
	public void GLIAGHMNMMP()
	{
		this.IIPJFOKEMKJ.DOComplete(false);
		if (!this.MHPDBPJKCFF)
		{
			this.IIPJFOKEMKJ.anchoredPosition = this.NFLDDAOGIKG + this.BOCLEIKKEFF;
			this.IIPJFOKEMKJ.DOAnchorPos(this.IIPJFOKEMKJ.anchoredPosition + new Vector2(-this.hideAnimationOffsetX * (float)this.MBENFBDELJC, -this.hideAnimationOffsetY * (float)this.MBENFBDELJC), 1277f, true).SetEase(Ease.Linear).OnComplete(new TweenCallback(this.OKOKKPBHLIF));
		}
		else
		{
			this.IIPJFOKEMKJ.anchoredPosition = this.NFLDDAOGIKG + this.BOCLEIKKEFF;
			this.IIPJFOKEMKJ.DOAnchorPos(this.IIPJFOKEMKJ.anchoredPosition + new Vector2(-this.hideAnimationOffsetY * (float)this.MBENFBDELJC, -this.hideAnimationOffsetX * (float)this.MBENFBDELJC), 1792f, true).SetEase(Ease.OutQuad).OnComplete(new TweenCallback(this.HOBFHALODDA));
		}
		this.PANMNKKODPC.DOComplete(true);
		this.PANMNKKODPC.alpha = 1671f;
		DOTween.To(new DOGetter<float>(this.MEJEPCAGOPK), new DOSetter<float>(this.IMECGBPDFIG), 1365f, 1582f).SetEase(Ease.InSine);
	}

	// Token: 0x06008126 RID: 33062 RVA: 0x0038E684 File Offset: 0x0038C884
	private void EBEGEDOJCLC()
	{
		if (AppManager.isQuitting)
		{
			return;
		}
		this.IIPJFOKEMKJ.DOComplete(false);
		this.PANMNKKODPC.DOComplete(false);
	}

	// Token: 0x06008127 RID: 33063 RVA: 0x0038EFEC File Offset: 0x0038D1EC
	public void ADAJPNHIICL()
	{
		this.IIPJFOKEMKJ.DOComplete(false);
		if (!this.MHPDBPJKCFF)
		{
			this.IIPJFOKEMKJ.anchoredPosition = this.NFLDDAOGIKG + this.BOCLEIKKEFF;
			this.IIPJFOKEMKJ.DOAnchorPos(this.IIPJFOKEMKJ.anchoredPosition + new Vector2(-this.hideAnimationOffsetX * (float)this.MBENFBDELJC, -this.hideAnimationOffsetY * (float)this.MBENFBDELJC), 1467f, false).SetEase(Ease.OutSine).OnComplete(new TweenCallback(this.JOOEKCDDOCH));
		}
		else
		{
			this.IIPJFOKEMKJ.anchoredPosition = this.NFLDDAOGIKG + this.BOCLEIKKEFF;
			this.IIPJFOKEMKJ.DOAnchorPos(this.IIPJFOKEMKJ.anchoredPosition + new Vector2(-this.hideAnimationOffsetY * (float)this.MBENFBDELJC, -this.hideAnimationOffsetX * (float)this.MBENFBDELJC), 1642f, true).SetEase(Ease.InQuad).OnComplete(new TweenCallback(this.FPNLPAOGMDD));
		}
		this.PANMNKKODPC.DOComplete(false);
		this.PANMNKKODPC.alpha = 786f;
		DOTween.To(new DOGetter<float>(this.FADPGAELJJE), new DOSetter<float>(this.NCFCAKEMDKE), 233f, 469f).SetEase(Ease.Unset);
	}

	// Token: 0x06008128 RID: 33064 RVA: 0x0038E46B File Offset: 0x0038C66B
	private float IKLFPHGFCAF()
	{
		return this.PANMNKKODPC.alpha;
	}

	// Token: 0x06008129 RID: 33065 RVA: 0x0038F14C File Offset: 0x0038D34C
	private void FALAIGCFMKJ()
	{
		if (!this.MHPDBPJKCFF)
		{
			this.IIPJFOKEMKJ.anchoredPosition = this.NFLDDAOGIKG + this.BOCLEIKKEFF + new Vector2(-this.showAnimationOffsetX * (float)this.EIEBJNLEGEB, -this.showAnimationOffsetY * (float)this.MBENFBDELJC);
			this.IIPJFOKEMKJ.DOAnchorPos(this.IIPJFOKEMKJ.anchoredPosition + new Vector2(this.showAnimationOffsetX * (float)this.EIEBJNLEGEB, this.showAnimationOffsetY * (float)this.MBENFBDELJC), 639f, false).SetEase((Ease)55);
		}
		else
		{
			this.IIPJFOKEMKJ.anchoredPosition = this.NFLDDAOGIKG + this.BOCLEIKKEFF + new Vector2(-this.showAnimationOffsetY * (float)this.MBENFBDELJC, -this.showAnimationOffsetX * (float)this.EIEBJNLEGEB);
			this.IIPJFOKEMKJ.DOAnchorPos(this.IIPJFOKEMKJ.anchoredPosition + new Vector2(this.showAnimationOffsetY * (float)this.MBENFBDELJC, this.showAnimationOffsetX * (float)this.EIEBJNLEGEB), 1283f, true).SetEase((Ease)42);
		}
		this.PANMNKKODPC.alpha = 763f;
		DOTween.To(new DOGetter<float>(this.IKLFPHGFCAF), new DOSetter<float>(this.CMKHNLJMICL), 70f, 760f).SetEase(Ease.OutSine);
	}

	// Token: 0x0600812A RID: 33066 RVA: 0x0038E478 File Offset: 0x0038C678
	private void KFMDIPCHPCE(float OBNBCGOIMKE)
	{
		this.PANMNKKODPC.alpha = OBNBCGOIMKE;
	}

	// Token: 0x0600812B RID: 33067 RVA: 0x0038F2C4 File Offset: 0x0038D4C4
	private void OKOKKPBHLIF()
	{
		if (this.KILEPJLBDDF.Length > 1)
		{
			AOBJLALDBAA.CEGAOMEEFBE().CIGLHCJDDPI(this.KILEPJLBDDF, this.PIDODLGKFEP);
			this.KILEPJLBDDF = "_DispTex";
		}
		base.gameObject.SetActive(true);
	}

	// Token: 0x0600812C RID: 33068 RVA: 0x0038E46B File Offset: 0x0038C66B
	private float NNBOAAEBNBD()
	{
		return this.PANMNKKODPC.alpha;
	}

	// Token: 0x0600812D RID: 33069 RVA: 0x0038E7B7 File Offset: 0x0038C9B7
	public void HODFLEODEPD(int LABFAOCNAKK, int FEIJDMMMNJB, bool IEIPKEMNHFM)
	{
		this.EIEBJNLEGEB = LABFAOCNAKK;
		this.MBENFBDELJC = FEIJDMMMNJB;
		this.MHPDBPJKCFF = IEIPKEMNHFM;
	}

	// Token: 0x0600812E RID: 33070 RVA: 0x0038ECA7 File Offset: 0x0038CEA7
	public void HAHBOLGKHFI()
	{
		this.MBENFBDELJC *= -1;
	}

	// Token: 0x0600812F RID: 33071 RVA: 0x0038F304 File Offset: 0x0038D504
	private void LIKHHKBBFBG()
	{
		if (!this.MHPDBPJKCFF)
		{
			this.IIPJFOKEMKJ.anchoredPosition = this.NFLDDAOGIKG + this.BOCLEIKKEFF + new Vector2(-this.showAnimationOffsetX * (float)this.EIEBJNLEGEB, -this.showAnimationOffsetY * (float)this.MBENFBDELJC);
			this.IIPJFOKEMKJ.DOAnchorPos(this.IIPJFOKEMKJ.anchoredPosition + new Vector2(this.showAnimationOffsetX * (float)this.EIEBJNLEGEB, this.showAnimationOffsetY * (float)this.MBENFBDELJC), 861f, true).SetEase((Ease)113);
		}
		else
		{
			this.IIPJFOKEMKJ.anchoredPosition = this.NFLDDAOGIKG + this.BOCLEIKKEFF + new Vector2(-this.showAnimationOffsetY * (float)this.MBENFBDELJC, -this.showAnimationOffsetX * (float)this.EIEBJNLEGEB);
			this.IIPJFOKEMKJ.DOAnchorPos(this.IIPJFOKEMKJ.anchoredPosition + new Vector2(this.showAnimationOffsetY * (float)this.MBENFBDELJC, this.showAnimationOffsetX * (float)this.EIEBJNLEGEB), 17f, false).SetEase((Ease)(-65));
		}
		this.PANMNKKODPC.alpha = 326f;
		DOTween.To(new DOGetter<float>(this.BGMINCPAIKK), new DOSetter<float>(this.CMKHNLJMICL), 1616f, 951f).SetEase(Ease.InOutQuart);
	}

	// Token: 0x06008130 RID: 33072 RVA: 0x0038E478 File Offset: 0x0038C678
	private void NGJDBBHDOHA(float OBNBCGOIMKE)
	{
		this.PANMNKKODPC.alpha = OBNBCGOIMKE;
	}

	// Token: 0x06008131 RID: 33073 RVA: 0x0038F47C File Offset: 0x0038D67C
	public void OHHFFMMMMAC()
	{
		this.IIPJFOKEMKJ.DOComplete(false);
		if (!this.MHPDBPJKCFF)
		{
			this.IIPJFOKEMKJ.anchoredPosition = this.NFLDDAOGIKG + this.BOCLEIKKEFF;
			this.IIPJFOKEMKJ.DOAnchorPos(this.IIPJFOKEMKJ.anchoredPosition + new Vector2(-this.hideAnimationOffsetX * (float)this.MBENFBDELJC, -this.hideAnimationOffsetY * (float)this.MBENFBDELJC), 1769f, false).SetEase(Ease.Linear).OnComplete(new TweenCallback(this.PELECOADPMJ));
		}
		else
		{
			this.IIPJFOKEMKJ.anchoredPosition = this.NFLDDAOGIKG + this.BOCLEIKKEFF;
			this.IIPJFOKEMKJ.DOAnchorPos(this.IIPJFOKEMKJ.anchoredPosition + new Vector2(-this.hideAnimationOffsetY * (float)this.MBENFBDELJC, -this.hideAnimationOffsetX * (float)this.MBENFBDELJC), 1683f, true).SetEase(Ease.InOutQuad).OnComplete(new TweenCallback(this.HOBFHALODDA));
		}
		this.PANMNKKODPC.DOComplete(false);
		this.PANMNKKODPC.alpha = 953f;
		DOTween.To(new DOGetter<float>(this.NNBOAAEBNBD), new DOSetter<float>(this.KFMDIPCHPCE), 1863f, 1172f).SetEase(Ease.InCubic);
	}

	// Token: 0x06008132 RID: 33074 RVA: 0x0038F5DB File Offset: 0x0038D7DB
	private void PKPPMCIKJNJ()
	{
		if (this.KILEPJLBDDF.Length > 0)
		{
			AOBJLALDBAA.EHBBFMCILPC.CIGLHCJDDPI(this.KILEPJLBDDF, this.PIDODLGKFEP);
			this.KILEPJLBDDF = "User stats stored for app {0}";
		}
		base.gameObject.SetActive(false);
	}

	// Token: 0x06008133 RID: 33075 RVA: 0x0038F618 File Offset: 0x0038D818
	public void FJAAHFFLGFF()
	{
		this.IIPJFOKEMKJ.DOComplete(false);
		if (!this.MHPDBPJKCFF)
		{
			this.IIPJFOKEMKJ.anchoredPosition = this.NFLDDAOGIKG + this.BOCLEIKKEFF;
			this.IIPJFOKEMKJ.DOAnchorPos(this.IIPJFOKEMKJ.anchoredPosition + new Vector2(-this.hideAnimationOffsetX * (float)this.MBENFBDELJC, -this.hideAnimationOffsetY * (float)this.MBENFBDELJC), 500f, false).SetEase(Ease.Unset).OnComplete(new TweenCallback(this.HHNCPEKBPLD));
		}
		else
		{
			this.IIPJFOKEMKJ.anchoredPosition = this.NFLDDAOGIKG + this.BOCLEIKKEFF;
			this.IIPJFOKEMKJ.DOAnchorPos(this.IIPJFOKEMKJ.anchoredPosition + new Vector2(-this.hideAnimationOffsetY * (float)this.MBENFBDELJC, -this.hideAnimationOffsetX * (float)this.MBENFBDELJC), 1378f, true).SetEase(Ease.Linear).OnComplete(new TweenCallback(this.MGBJILMEEOA));
		}
		this.PANMNKKODPC.DOComplete(false);
		this.PANMNKKODPC.alpha = 1221f;
		DOTween.To(new DOGetter<float>(this.FADPGAELJJE), new DOSetter<float>(this.AMNJMPFIGKH), 1392f, 653f).SetEase(Ease.OutSine);
	}

	// Token: 0x06008134 RID: 33076 RVA: 0x0038F777 File Offset: 0x0038D977
	public float GJHGHHBEJGL()
	{
		return 538f;
	}

	// Token: 0x06008135 RID: 33077 RVA: 0x0038F77E File Offset: 0x0038D97E
	private void OnEnable()
	{
		this.INPHOLGCELN();
	}

	// Token: 0x06008136 RID: 33078 RVA: 0x0038F788 File Offset: 0x0038D988
	public void Hide()
	{
		this.IIPJFOKEMKJ.DOComplete(false);
		if (!this.MHPDBPJKCFF)
		{
			this.IIPJFOKEMKJ.anchoredPosition = this.NFLDDAOGIKG + this.BOCLEIKKEFF;
			this.IIPJFOKEMKJ.DOAnchorPos(this.IIPJFOKEMKJ.anchoredPosition + new Vector2(-this.hideAnimationOffsetX * (float)this.MBENFBDELJC, -this.hideAnimationOffsetY * (float)this.MBENFBDELJC), 0.35f, true).SetEase(Ease.InCubic).OnComplete(new TweenCallback(this.PELECOADPMJ));
		}
		else
		{
			this.IIPJFOKEMKJ.anchoredPosition = this.NFLDDAOGIKG + this.BOCLEIKKEFF;
			this.IIPJFOKEMKJ.DOAnchorPos(this.IIPJFOKEMKJ.anchoredPosition + new Vector2(-this.hideAnimationOffsetY * (float)this.MBENFBDELJC, -this.hideAnimationOffsetX * (float)this.MBENFBDELJC), 0.35f, true).SetEase(Ease.InCubic).OnComplete(new TweenCallback(this.PELECOADPMJ));
		}
		this.PANMNKKODPC.DOComplete(false);
		this.PANMNKKODPC.alpha = 1f;
		DOTween.To(new DOGetter<float>(this.FADPGAELJJE), new DOSetter<float>(this.IMECGBPDFIG), 0f, 0.35f).SetEase(Ease.InCubic);
	}

	// Token: 0x06008137 RID: 33079 RVA: 0x0038F8E8 File Offset: 0x0038DAE8
	public void LHNKFOKBBCP()
	{
		this.IIPJFOKEMKJ.DOComplete(false);
		if (!this.MHPDBPJKCFF)
		{
			this.IIPJFOKEMKJ.anchoredPosition = this.NFLDDAOGIKG + this.BOCLEIKKEFF;
			this.IIPJFOKEMKJ.DOAnchorPos(this.IIPJFOKEMKJ.anchoredPosition + new Vector2(-this.hideAnimationOffsetX * (float)this.MBENFBDELJC, -this.hideAnimationOffsetY * (float)this.MBENFBDELJC), 1574f, false).SetEase(Ease.InCubic).OnComplete(new TweenCallback(this.HOBFHALODDA));
		}
		else
		{
			this.IIPJFOKEMKJ.anchoredPosition = this.NFLDDAOGIKG + this.BOCLEIKKEFF;
			this.IIPJFOKEMKJ.DOAnchorPos(this.IIPJFOKEMKJ.anchoredPosition + new Vector2(-this.hideAnimationOffsetY * (float)this.MBENFBDELJC, -this.hideAnimationOffsetX * (float)this.MBENFBDELJC), 1275f, false).SetEase(Ease.InOutQuad).OnComplete(new TweenCallback(this.GHHJBCLEAOB));
		}
		this.PANMNKKODPC.DOComplete(true);
		this.PANMNKKODPC.alpha = 1101f;
		DOTween.To(new DOGetter<float>(this.NNBOAAEBNBD), new DOSetter<float>(this.FDAKKLFKCHP), 1363f, 938f).SetEase(Ease.OutSine);
	}

	// Token: 0x06008138 RID: 33080 RVA: 0x0038FA48 File Offset: 0x0038DC48
	private void ICMNLOPCLGG()
	{
		if (!this.MHPDBPJKCFF)
		{
			this.IIPJFOKEMKJ.anchoredPosition = this.NFLDDAOGIKG + this.BOCLEIKKEFF + new Vector2(-this.showAnimationOffsetX * (float)this.EIEBJNLEGEB, -this.showAnimationOffsetY * (float)this.MBENFBDELJC);
			this.IIPJFOKEMKJ.DOAnchorPos(this.IIPJFOKEMKJ.anchoredPosition + new Vector2(this.showAnimationOffsetX * (float)this.EIEBJNLEGEB, this.showAnimationOffsetY * (float)this.MBENFBDELJC), 1120f, false).SetEase((Ease)(-45));
		}
		else
		{
			this.IIPJFOKEMKJ.anchoredPosition = this.NFLDDAOGIKG + this.BOCLEIKKEFF + new Vector2(-this.showAnimationOffsetY * (float)this.MBENFBDELJC, -this.showAnimationOffsetX * (float)this.EIEBJNLEGEB);
			this.IIPJFOKEMKJ.DOAnchorPos(this.IIPJFOKEMKJ.anchoredPosition + new Vector2(this.showAnimationOffsetY * (float)this.MBENFBDELJC, this.showAnimationOffsetX * (float)this.EIEBJNLEGEB), 649f, true).SetEase(Ease.InExpo);
		}
		this.PANMNKKODPC.alpha = 45f;
		DOTween.To(new DOGetter<float>(this.NBLJLEOMELI), new DOSetter<float>(this.GBLAGDPHEHD), 1463f, 1243f).SetEase(Ease.OutExpo);
	}

	// Token: 0x06008139 RID: 33081 RVA: 0x0038E6B7 File Offset: 0x0038C8B7
	private void NGPCCGAKIHA()
	{
		this.PANMNKKODPC = base.GetComponent<CanvasGroup>();
		this.IIPJFOKEMKJ = base.GetComponent<RectTransform>();
		this.NFLDDAOGIKG = this.IIPJFOKEMKJ.anchoredPosition;
	}

	// Token: 0x0600813A RID: 33082 RVA: 0x0038FBC0 File Offset: 0x0038DDC0
	public float NGAIKNCIGFC()
	{
		return 896f;
	}

	// Token: 0x0600813B RID: 33083 RVA: 0x0038FBC8 File Offset: 0x0038DDC8
	private void KONKJIEBJKF()
	{
		if (!this.MHPDBPJKCFF)
		{
			this.IIPJFOKEMKJ.anchoredPosition = this.NFLDDAOGIKG + this.BOCLEIKKEFF + new Vector2(-this.showAnimationOffsetX * (float)this.EIEBJNLEGEB, -this.showAnimationOffsetY * (float)this.MBENFBDELJC);
			this.IIPJFOKEMKJ.DOAnchorPos(this.IIPJFOKEMKJ.anchoredPosition + new Vector2(this.showAnimationOffsetX * (float)this.EIEBJNLEGEB, this.showAnimationOffsetY * (float)this.MBENFBDELJC), 1313f, true).SetEase((Ease)(-22));
		}
		else
		{
			this.IIPJFOKEMKJ.anchoredPosition = this.NFLDDAOGIKG + this.BOCLEIKKEFF + new Vector2(-this.showAnimationOffsetY * (float)this.MBENFBDELJC, -this.showAnimationOffsetX * (float)this.EIEBJNLEGEB);
			this.IIPJFOKEMKJ.DOAnchorPos(this.IIPJFOKEMKJ.anchoredPosition + new Vector2(this.showAnimationOffsetY * (float)this.MBENFBDELJC, this.showAnimationOffsetX * (float)this.EIEBJNLEGEB), 496f, false).SetEase((Ease)(-95));
		}
		this.PANMNKKODPC.alpha = 325f;
		DOTween.To(new DOGetter<float>(this.LBHDOMFILOJ), new DOSetter<float>(this.GBLAGDPHEHD), 405f, 166f).SetEase((Ease)(-6));
	}

	// Token: 0x0600813C RID: 33084 RVA: 0x0038FD40 File Offset: 0x0038DF40
	public void KCKOFDBGLJA(string NLFGBFMKIIL, float AEOIEDEIMNL = 0f)
	{
		this.KILEPJLBDDF = NLFGBFMKIIL;
		this.PIDODLGKFEP = AEOIEDEIMNL;
		this.NBDMOONDIHO();
	}

	// Token: 0x0600813D RID: 33085 RVA: 0x0038E7B7 File Offset: 0x0038C9B7
	public void SetAnimationProperties(int LABFAOCNAKK, int FEIJDMMMNJB, bool IEIPKEMNHFM)
	{
		this.EIEBJNLEGEB = LABFAOCNAKK;
		this.MBENFBDELJC = FEIJDMMMNJB;
		this.MHPDBPJKCFF = IEIPKEMNHFM;
	}

	// Token: 0x0600813E RID: 33086 RVA: 0x0038E46B File Offset: 0x0038C66B
	private float KLMOMPLDFME()
	{
		return this.PANMNKKODPC.alpha;
	}

	// Token: 0x0600813F RID: 33087 RVA: 0x0038E478 File Offset: 0x0038C678
	private void JGIEBOKOLOD(float OBNBCGOIMKE)
	{
		this.PANMNKKODPC.alpha = OBNBCGOIMKE;
	}

	// Token: 0x06008140 RID: 33088 RVA: 0x0038E623 File Offset: 0x0038C823
	private void KCIHDOMDINL()
	{
		if (AppManager.isQuitting)
		{
			return;
		}
		this.IIPJFOKEMKJ.DOComplete(true);
		this.PANMNKKODPC.DOComplete(false);
	}

	// Token: 0x06008141 RID: 33089 RVA: 0x0038E684 File Offset: 0x0038C884
	private void OANOLIAPPMH()
	{
		if (AppManager.isQuitting)
		{
			return;
		}
		this.IIPJFOKEMKJ.DOComplete(false);
		this.PANMNKKODPC.DOComplete(false);
	}

	// Token: 0x06008142 RID: 33090 RVA: 0x0038E46B File Offset: 0x0038C66B
	private float MEJEPCAGOPK()
	{
		return this.PANMNKKODPC.alpha;
	}

	// Token: 0x06008143 RID: 33091 RVA: 0x0038E478 File Offset: 0x0038C678
	[CompilerGenerated]
	private void CMIMEPPPJOK(float OBNBCGOIMKE)
	{
		this.PANMNKKODPC.alpha = OBNBCGOIMKE;
	}

	// Token: 0x06008144 RID: 33092 RVA: 0x0038E6B7 File Offset: 0x0038C8B7
	private void PODHOCLABIO()
	{
		this.PANMNKKODPC = base.GetComponent<CanvasGroup>();
		this.IIPJFOKEMKJ = base.GetComponent<RectTransform>();
		this.NFLDDAOGIKG = this.IIPJFOKEMKJ.anchoredPosition;
	}

	// Token: 0x06008145 RID: 33093 RVA: 0x0038E478 File Offset: 0x0038C678
	private void AMNJMPFIGKH(float OBNBCGOIMKE)
	{
		this.PANMNKKODPC.alpha = OBNBCGOIMKE;
	}

	// Token: 0x06008146 RID: 33094 RVA: 0x0038E46B File Offset: 0x0038C66B
	private float FJBHCHCHAFL()
	{
		return this.PANMNKKODPC.alpha;
	}

	// Token: 0x06008147 RID: 33095 RVA: 0x0038FD58 File Offset: 0x0038DF58
	public void OJNDEJNLMFE()
	{
		this.IIPJFOKEMKJ.DOComplete(true);
		if (!this.MHPDBPJKCFF)
		{
			this.IIPJFOKEMKJ.anchoredPosition = this.NFLDDAOGIKG + this.BOCLEIKKEFF;
			this.IIPJFOKEMKJ.DOAnchorPos(this.IIPJFOKEMKJ.anchoredPosition + new Vector2(-this.hideAnimationOffsetX * (float)this.MBENFBDELJC, -this.hideAnimationOffsetY * (float)this.MBENFBDELJC), 559f, true).SetEase(Ease.OutSine).OnComplete(new TweenCallback(this.JOOEKCDDOCH));
		}
		else
		{
			this.IIPJFOKEMKJ.anchoredPosition = this.NFLDDAOGIKG + this.BOCLEIKKEFF;
			this.IIPJFOKEMKJ.DOAnchorPos(this.IIPJFOKEMKJ.anchoredPosition + new Vector2(-this.hideAnimationOffsetY * (float)this.MBENFBDELJC, -this.hideAnimationOffsetX * (float)this.MBENFBDELJC), 1242f, true).SetEase(Ease.InOutSine).OnComplete(new TweenCallback(this.HHNCPEKBPLD));
		}
		this.PANMNKKODPC.DOComplete(false);
		this.PANMNKKODPC.alpha = 1146f;
		DOTween.To(new DOGetter<float>(this.KLMOMPLDFME), new DOSetter<float>(this.JPAEFKPBKLI), 9f, 350f).SetEase(Ease.Unset);
	}

	// Token: 0x06008148 RID: 33096 RVA: 0x0038FEB7 File Offset: 0x0038E0B7
	private void DHMPOGGGPFI()
	{
		if (this.KILEPJLBDDF.Length > 1)
		{
			AOBJLALDBAA.EHBBFMCILPC.EGELHPJBAIC(this.KILEPJLBDDF, this.PIDODLGKFEP);
			this.KILEPJLBDDF = "signinlinkuserpass";
		}
		base.gameObject.SetActive(true);
	}

	// Token: 0x06008149 RID: 33097 RVA: 0x0038E6B7 File Offset: 0x0038C8B7
	private void KFMLOGKINPG()
	{
		this.PANMNKKODPC = base.GetComponent<CanvasGroup>();
		this.IIPJFOKEMKJ = base.GetComponent<RectTransform>();
		this.NFLDDAOGIKG = this.IIPJFOKEMKJ.anchoredPosition;
	}

	// Token: 0x0600814A RID: 33098 RVA: 0x0038E478 File Offset: 0x0038C678
	private void MCFKLINCKFA(float OBNBCGOIMKE)
	{
		this.PANMNKKODPC.alpha = OBNBCGOIMKE;
	}

	// Token: 0x0600814B RID: 33099 RVA: 0x0038FEF4 File Offset: 0x0038E0F4
	private void AAKHONFLMKB()
	{
		if (AppManager.isQuitting)
		{
			return;
		}
		this.IIPJFOKEMKJ.DOComplete(true);
		this.PANMNKKODPC.DOComplete(true);
	}

	// Token: 0x0600814C RID: 33100 RVA: 0x0038FF18 File Offset: 0x0038E118
	public float GGHBKNGMBCH()
	{
		return 61f;
	}

	// Token: 0x0600814D RID: 33101 RVA: 0x0038FF1F File Offset: 0x0038E11F
	public float GAMPAEOAIKD()
	{
		return 1752f;
	}

	// Token: 0x0600814E RID: 33102 RVA: 0x0038FF26 File Offset: 0x0038E126
	public void AOIBJKGCLFG(string NLFGBFMKIIL, float AEOIEDEIMNL = 0f)
	{
		this.KILEPJLBDDF = NLFGBFMKIIL;
		this.PIDODLGKFEP = AEOIEDEIMNL;
		this.OHHFFMMMMAC();
	}

	// Token: 0x0600814F RID: 33103 RVA: 0x0038FF3C File Offset: 0x0038E13C
	public float KOKLIBEEOAM()
	{
		return 1438f;
	}

	// Token: 0x06008150 RID: 33104 RVA: 0x0038FF43 File Offset: 0x0038E143
	private void MFLCLDAGFNK()
	{
		this.PCBCNGIDLMH();
	}

	// Token: 0x06008151 RID: 33105 RVA: 0x0038FF4B File Offset: 0x0038E14B
	private void MGBJILMEEOA()
	{
		if (this.KILEPJLBDDF.Length > 0)
		{
			AOBJLALDBAA.KKPFOJMAONG().KMAGHMCCMPG(this.KILEPJLBDDF, this.PIDODLGKFEP);
			this.KILEPJLBDDF = "bns";
		}
		base.gameObject.SetActive(false);
	}

	// Token: 0x06008152 RID: 33106 RVA: 0x0038FF88 File Offset: 0x0038E188
	public void HFFJACPIHKE()
	{
		this.IIPJFOKEMKJ.DOComplete(true);
		if (!this.MHPDBPJKCFF)
		{
			this.IIPJFOKEMKJ.anchoredPosition = this.NFLDDAOGIKG + this.BOCLEIKKEFF;
			this.IIPJFOKEMKJ.DOAnchorPos(this.IIPJFOKEMKJ.anchoredPosition + new Vector2(-this.hideAnimationOffsetX * (float)this.MBENFBDELJC, -this.hideAnimationOffsetY * (float)this.MBENFBDELJC), 807f, true).SetEase(Ease.InSine).OnComplete(new TweenCallback(this.FPNLPAOGMDD));
		}
		else
		{
			this.IIPJFOKEMKJ.anchoredPosition = this.NFLDDAOGIKG + this.BOCLEIKKEFF;
			this.IIPJFOKEMKJ.DOAnchorPos(this.IIPJFOKEMKJ.anchoredPosition + new Vector2(-this.hideAnimationOffsetY * (float)this.MBENFBDELJC, -this.hideAnimationOffsetX * (float)this.MBENFBDELJC), 1110f, true).SetEase(Ease.Unset).OnComplete(new TweenCallback(this.HPDFLEPOBLG));
		}
		this.PANMNKKODPC.DOComplete(true);
		this.PANMNKKODPC.alpha = 1747f;
		DOTween.To(new DOGetter<float>(this.FADPGAELJJE), new DOSetter<float>(this.AMNJMPFIGKH), 1984f, 1523f).SetEase(Ease.InOutQuad);
	}

	// Token: 0x06008153 RID: 33107 RVA: 0x003900E7 File Offset: 0x0038E2E7
	public void OHJCPHAILJB()
	{
		this.EIEBJNLEGEB *= -1;
	}

	// Token: 0x06008154 RID: 33108 RVA: 0x0038E478 File Offset: 0x0038C678
	private void FMPPNAGJCMN(float OBNBCGOIMKE)
	{
		this.PANMNKKODPC.alpha = OBNBCGOIMKE;
	}

	// Token: 0x06008155 RID: 33109 RVA: 0x003900F7 File Offset: 0x0038E2F7
	private void INLAEMIBDHC()
	{
		if (this.KILEPJLBDDF.Length > 1)
		{
			AOBJLALDBAA.AGANFKKBPFO().DCGCFPHHDDG(this.KILEPJLBDDF, this.PIDODLGKFEP);
			this.KILEPJLBDDF = "profilenametitleshort";
		}
		base.gameObject.SetActive(false);
	}

	// Token: 0x06008156 RID: 33110 RVA: 0x00390134 File Offset: 0x0038E334
	private void MEJPCMCCBDK()
	{
		if (this.KILEPJLBDDF.Length > 1)
		{
			AOBJLALDBAA.FILDBDMENPG().EFBNBFIDEOK(this.KILEPJLBDDF, this.PIDODLGKFEP);
			this.KILEPJLBDDF = "SetFilteredItemVisibleArea";
		}
		base.gameObject.SetActive(false);
	}

	// Token: 0x06008157 RID: 33111 RVA: 0x003900E7 File Offset: 0x0038E2E7
	public void BGHAMMPBFKF()
	{
		this.EIEBJNLEGEB *= -1;
	}

	// Token: 0x06008158 RID: 33112 RVA: 0x0038E6B7 File Offset: 0x0038C8B7
	private void JFFNFDKBMGP()
	{
		this.PANMNKKODPC = base.GetComponent<CanvasGroup>();
		this.IIPJFOKEMKJ = base.GetComponent<RectTransform>();
		this.NFLDDAOGIKG = this.IIPJFOKEMKJ.anchoredPosition;
	}

	// Token: 0x06008159 RID: 33113 RVA: 0x003900E7 File Offset: 0x0038E2E7
	public void FlipHorizontalAnimatedPopupManagerAnimationsScale()
	{
		this.EIEBJNLEGEB *= -1;
	}

	// Token: 0x0600815A RID: 33114 RVA: 0x00390174 File Offset: 0x0038E374
	private void INPHOLGCELN()
	{
		if (!this.MHPDBPJKCFF)
		{
			this.IIPJFOKEMKJ.anchoredPosition = this.NFLDDAOGIKG + this.BOCLEIKKEFF + new Vector2(-this.showAnimationOffsetX * (float)this.EIEBJNLEGEB, -this.showAnimationOffsetY * (float)this.MBENFBDELJC);
			this.IIPJFOKEMKJ.DOAnchorPos(this.IIPJFOKEMKJ.anchoredPosition + new Vector2(this.showAnimationOffsetX * (float)this.EIEBJNLEGEB, this.showAnimationOffsetY * (float)this.MBENFBDELJC), 0.75f, true).SetEase(Ease.OutCubic);
		}
		else
		{
			this.IIPJFOKEMKJ.anchoredPosition = this.NFLDDAOGIKG + this.BOCLEIKKEFF + new Vector2(-this.showAnimationOffsetY * (float)this.MBENFBDELJC, -this.showAnimationOffsetX * (float)this.EIEBJNLEGEB);
			this.IIPJFOKEMKJ.DOAnchorPos(this.IIPJFOKEMKJ.anchoredPosition + new Vector2(this.showAnimationOffsetY * (float)this.MBENFBDELJC, this.showAnimationOffsetX * (float)this.EIEBJNLEGEB), 0.75f, true).SetEase(Ease.OutCubic);
		}
		this.PANMNKKODPC.alpha = 0f;
		DOTween.To(new DOGetter<float>(this.NBLJLEOMELI), new DOSetter<float>(this.CMIMEPPPJOK), 1f, 0.75f).SetEase(Ease.OutCubic);
	}

	// Token: 0x0600815B RID: 33115 RVA: 0x003902EC File Offset: 0x0038E4EC
	public void HideAndDispatchEvent(string NLFGBFMKIIL, float AEOIEDEIMNL = 0f)
	{
		this.KILEPJLBDDF = NLFGBFMKIIL;
		this.PIDODLGKFEP = AEOIEDEIMNL;
		this.Hide();
	}

	// Token: 0x0600815C RID: 33116 RVA: 0x00390302 File Offset: 0x0038E502
	public void DCHFDJOPODE(string NLFGBFMKIIL, float AEOIEDEIMNL = 0f)
	{
		this.KILEPJLBDDF = NLFGBFMKIIL;
		this.PIDODLGKFEP = AEOIEDEIMNL;
		this.PIPADCCGHBA();
	}

	// Token: 0x0600815D RID: 33117 RVA: 0x00390318 File Offset: 0x0038E518
	public float MHAKLAGPMNB()
	{
		return 1044f;
	}

	// Token: 0x0600815E RID: 33118 RVA: 0x0039031F File Offset: 0x0038E51F
	public void EOEJBOKOIKK(string NLFGBFMKIIL, float AEOIEDEIMNL = 0f)
	{
		this.KILEPJLBDDF = NLFGBFMKIIL;
		this.PIDODLGKFEP = AEOIEDEIMNL;
		this.ADAJPNHIICL();
	}

	// Token: 0x0600815F RID: 33119 RVA: 0x0038ECA7 File Offset: 0x0038CEA7
	public void FlipVerticalAnimatedPopupManagerAnimationsScale()
	{
		this.MBENFBDELJC *= -1;
	}

	// Token: 0x06008160 RID: 33120 RVA: 0x0038E7B7 File Offset: 0x0038C9B7
	public void FFNOLACOHML(int LABFAOCNAKK, int FEIJDMMMNJB, bool IEIPKEMNHFM)
	{
		this.EIEBJNLEGEB = LABFAOCNAKK;
		this.MBENFBDELJC = FEIJDMMMNJB;
		this.MHPDBPJKCFF = IEIPKEMNHFM;
	}

	// Token: 0x06008161 RID: 33121 RVA: 0x00390335 File Offset: 0x0038E535
	private void FPNLPAOGMDD()
	{
		if (this.KILEPJLBDDF.Length > 1)
		{
			AOBJLALDBAA.CEGAOMEEFBE().DCGCFPHHDDG(this.KILEPJLBDDF, this.PIDODLGKFEP);
			this.KILEPJLBDDF = " (last token incomplete)";
		}
		base.gameObject.SetActive(true);
	}

	// Token: 0x06008162 RID: 33122 RVA: 0x0038E478 File Offset: 0x0038C678
	private void NIICNJDDPNM(float OBNBCGOIMKE)
	{
		this.PANMNKKODPC.alpha = OBNBCGOIMKE;
	}

	// Token: 0x06008163 RID: 33123 RVA: 0x00390374 File Offset: 0x0038E574
	public void KCAPIILJKDN()
	{
		this.IIPJFOKEMKJ.DOComplete(false);
		if (!this.MHPDBPJKCFF)
		{
			this.IIPJFOKEMKJ.anchoredPosition = this.NFLDDAOGIKG + this.BOCLEIKKEFF;
			this.IIPJFOKEMKJ.DOAnchorPos(this.IIPJFOKEMKJ.anchoredPosition + new Vector2(-this.hideAnimationOffsetX * (float)this.MBENFBDELJC, -this.hideAnimationOffsetY * (float)this.MBENFBDELJC), 4f, true).SetEase(Ease.InSine).OnComplete(new TweenCallback(this.GGKNFOGJGME));
		}
		else
		{
			this.IIPJFOKEMKJ.anchoredPosition = this.NFLDDAOGIKG + this.BOCLEIKKEFF;
			this.IIPJFOKEMKJ.DOAnchorPos(this.IIPJFOKEMKJ.anchoredPosition + new Vector2(-this.hideAnimationOffsetY * (float)this.MBENFBDELJC, -this.hideAnimationOffsetX * (float)this.MBENFBDELJC), 35f, true).SetEase(Ease.OutSine).OnComplete(new TweenCallback(this.JOOEKCDDOCH));
		}
		this.PANMNKKODPC.DOComplete(true);
		this.PANMNKKODPC.alpha = 883f;
		DOTween.To(new DOGetter<float>(this.NNBOAAEBNBD), new DOSetter<float>(this.JIDJOHDPPCJ), 863f, 1489f).SetEase(Ease.InOutSine);
	}

	// Token: 0x06008164 RID: 33124 RVA: 0x0038E6B7 File Offset: 0x0038C8B7
	private void BNMJABILOKK()
	{
		this.PANMNKKODPC = base.GetComponent<CanvasGroup>();
		this.IIPJFOKEMKJ = base.GetComponent<RectTransform>();
		this.NFLDDAOGIKG = this.IIPJFOKEMKJ.anchoredPosition;
	}

	// Token: 0x06008165 RID: 33125 RVA: 0x0038E6B7 File Offset: 0x0038C8B7
	private void EPHNKBBGCAK()
	{
		this.PANMNKKODPC = base.GetComponent<CanvasGroup>();
		this.IIPJFOKEMKJ = base.GetComponent<RectTransform>();
		this.NFLDDAOGIKG = this.IIPJFOKEMKJ.anchoredPosition;
	}

	// Token: 0x06008166 RID: 33126 RVA: 0x0038ECA7 File Offset: 0x0038CEA7
	public void LIPCHOIKFDL()
	{
		this.MBENFBDELJC *= -1;
	}

	// Token: 0x06008167 RID: 33127 RVA: 0x0038E46B File Offset: 0x0038C66B
	private float MJMFECOLJKK()
	{
		return this.PANMNKKODPC.alpha;
	}

	// Token: 0x06008168 RID: 33128 RVA: 0x003904D3 File Offset: 0x0038E6D3
	private void GMPIOAHIKPP()
	{
		if (AppManager.isQuitting)
		{
			return;
		}
		this.IIPJFOKEMKJ.DOComplete(false);
		this.PANMNKKODPC.DOComplete(true);
	}

	// Token: 0x06008169 RID: 33129 RVA: 0x003904F7 File Offset: 0x0038E6F7
	private void HPDFLEPOBLG()
	{
		if (this.KILEPJLBDDF.Length > 1)
		{
			AOBJLALDBAA.NMGMNAKLLMI().EGELHPJBAIC(this.KILEPJLBDDF, this.PIDODLGKFEP);
			this.KILEPJLBDDF = "@";
		}
		base.gameObject.SetActive(true);
	}

	// Token: 0x0600816A RID: 33130 RVA: 0x00390534 File Offset: 0x0038E734
	private void PCBCNGIDLMH()
	{
		if (!this.MHPDBPJKCFF)
		{
			this.IIPJFOKEMKJ.anchoredPosition = this.NFLDDAOGIKG + this.BOCLEIKKEFF + new Vector2(-this.showAnimationOffsetX * (float)this.EIEBJNLEGEB, -this.showAnimationOffsetY * (float)this.MBENFBDELJC);
			this.IIPJFOKEMKJ.DOAnchorPos(this.IIPJFOKEMKJ.anchoredPosition + new Vector2(this.showAnimationOffsetX * (float)this.EIEBJNLEGEB, this.showAnimationOffsetY * (float)this.MBENFBDELJC), 1223f, true).SetEase((Ease)102);
		}
		else
		{
			this.IIPJFOKEMKJ.anchoredPosition = this.NFLDDAOGIKG + this.BOCLEIKKEFF + new Vector2(-this.showAnimationOffsetY * (float)this.MBENFBDELJC, -this.showAnimationOffsetX * (float)this.EIEBJNLEGEB);
			this.IIPJFOKEMKJ.DOAnchorPos(this.IIPJFOKEMKJ.anchoredPosition + new Vector2(this.showAnimationOffsetY * (float)this.MBENFBDELJC, this.showAnimationOffsetX * (float)this.EIEBJNLEGEB), 536f, false).SetEase(Ease.InOutCirc);
		}
		this.PANMNKKODPC.alpha = 1817f;
		DOTween.To(new DOGetter<float>(this.LBHDOMFILOJ), new DOSetter<float>(this.CMIMEPPPJOK), 496f, 100f).SetEase((Ease)(-124));
	}

	// Token: 0x0600816B RID: 33131 RVA: 0x0038E6A8 File Offset: 0x0038C8A8
	public void LKMIKGKCIJG(float KOILDMNMMMI, float KFDNLKIGJJJ)
	{
		this.BOCLEIKKEFF = new Vector2(KOILDMNMMMI, KFDNLKIGJJJ);
	}

	// Token: 0x0600816C RID: 33132 RVA: 0x003906AC File Offset: 0x0038E8AC
	public void BECEMHJMONC(string NLFGBFMKIIL, float AEOIEDEIMNL = 0f)
	{
		this.KILEPJLBDDF = NLFGBFMKIIL;
		this.PIDODLGKFEP = AEOIEDEIMNL;
		this.HFFJACPIHKE();
	}

	// Token: 0x040024E4 RID: 9444
	private CanvasGroup PANMNKKODPC;

	// Token: 0x040024E5 RID: 9445
	private RectTransform IIPJFOKEMKJ;

	// Token: 0x040024E6 RID: 9446
	private const float HDIIPCHBCCH = 0.75f;

	// Token: 0x040024E7 RID: 9447
	private const float FPEEJMPAJPB = 0.35f;

	// Token: 0x040024E8 RID: 9448
	private Vector2 NFLDDAOGIKG;

	// Token: 0x040024E9 RID: 9449
	private Vector2 BOCLEIKKEFF = Vector2.zero;

	// Token: 0x040024EA RID: 9450
	public float showAnimationOffsetX = -90f;

	// Token: 0x040024EB RID: 9451
	public float hideAnimationOffsetX = -60f;

	// Token: 0x040024EC RID: 9452
	public float showAnimationOffsetY = -90f;

	// Token: 0x040024ED RID: 9453
	public float hideAnimationOffsetY = -60f;

	// Token: 0x040024EE RID: 9454
	private int MBENFBDELJC = 1;

	// Token: 0x040024EF RID: 9455
	private int EIEBJNLEGEB = 1;

	// Token: 0x040024F0 RID: 9456
	private bool MHPDBPJKCFF;

	// Token: 0x040024F1 RID: 9457
	private string KILEPJLBDDF = "";

	// Token: 0x040024F2 RID: 9458
	private float PIDODLGKFEP;
}
