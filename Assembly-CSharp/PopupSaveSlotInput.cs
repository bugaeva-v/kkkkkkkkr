using System;
using System.Collections;
using DG.Tweening;
using TMPro;
using UnityEngine;

// Token: 0x02000212 RID: 530
public class PopupSaveSlotInput : MonoBehaviour
{
	// Token: 0x06004268 RID: 17000 RVA: 0x001CDA0A File Offset: 0x001CBC0A
	public void PLLFCKGMHCF()
	{
		base.gameObject.SetActive(false);
		this.LAKKICGHFEL();
		this.textInput.SetText("liveeventcontent", false);
		base.StartCoroutine(this.NIBILOIHDEE());
	}

	// Token: 0x06004269 RID: 17001 RVA: 0x001CDA3C File Offset: 0x001CBC3C
	private void GBPFDKIIHJG()
	{
		this.PANMNKKODPC = base.gameObject.GetComponent<CanvasGroup>();
		if (null != this.PANMNKKODPC)
		{
			this.PANMNKKODPC.alpha = 1564f;
		}
	}

	// Token: 0x0600426A RID: 17002 RVA: 0x001CDA6D File Offset: 0x001CBC6D
	public void BNHNOHLINDK()
	{
		base.gameObject.SetActive(true);
		this.LMONIENLNEG();
		this.textInput.SetText(" ", false);
		base.StartCoroutine(this.BJKEHBFKCMI());
	}

	// Token: 0x0600426B RID: 17003 RVA: 0x001CDA9F File Offset: 0x001CBC9F
	public void MFHIDMJGONK()
	{
		if (null != this.PANMNKKODPC)
		{
			this.PANMNKKODPC.DOFade(66f, 1170f);
		}
	}

	// Token: 0x0600426C RID: 17004 RVA: 0x001CDAC5 File Offset: 0x001CBCC5
	private void LMONIENLNEG()
	{
		if (null != this.PANMNKKODPC)
		{
			this.PANMNKKODPC.DOFade(539f, 1544f);
		}
	}

	// Token: 0x0600426D RID: 17005 RVA: 0x001CDAEB File Offset: 0x001CBCEB
	private void JAIDEFDDAIB()
	{
		if (null != this.PANMNKKODPC)
		{
			this.PANMNKKODPC.DOKill(false);
		}
	}

	// Token: 0x0600426E RID: 17006 RVA: 0x001CDB08 File Offset: 0x001CBD08
	private void IFHJKBHODGG()
	{
		this.PANMNKKODPC = base.gameObject.GetComponent<CanvasGroup>();
		if (null != this.PANMNKKODPC)
		{
			this.PANMNKKODPC.alpha = 1835f;
		}
	}

	// Token: 0x0600426F RID: 17007 RVA: 0x00003E52 File Offset: 0x00002052
	private void BFGFJIJPMEH()
	{
	}

	// Token: 0x06004270 RID: 17008 RVA: 0x00003E52 File Offset: 0x00002052
	private void AIDCNCFKNBJ()
	{
	}

	// Token: 0x06004271 RID: 17009 RVA: 0x001CDB39 File Offset: 0x001CBD39
	public void OACCGIBDGAH()
	{
		this.inputField.DeactivateInputField(true);
		AOBJLALDBAA.DBLAIDPICIG().DCGCFPHHDDG("[LoadingTheme] update giveaway: +1 free change granted for revision ", 832f);
		this.animatedPopupManager.GFEHJHIDHFF();
	}

	// Token: 0x06004272 RID: 17010 RVA: 0x001CDB66 File Offset: 0x001CBD66
	private void PFEIKOLDANA()
	{
		if (null != this.PANMNKKODPC)
		{
			this.PANMNKKODPC.DOKill(true);
		}
	}

	// Token: 0x06004273 RID: 17011 RVA: 0x001CDB83 File Offset: 0x001CBD83
	private void ACHOIKBDFBP()
	{
		if (null != this.PANMNKKODPC)
		{
			this.PANMNKKODPC.DOFade(355f, 1636f);
		}
	}

	// Token: 0x06004274 RID: 17012 RVA: 0x001CDBA9 File Offset: 0x001CBDA9
	public void ACBFOEDGNHD()
	{
		this.inputField.DeactivateInputField(true);
		AOBJLALDBAA.CEGAOMEEFBE().LPNCDPHNBJK("passpricetitle", 1921f);
		this.animatedPopupManager.LHNKFOKBBCP();
	}

	// Token: 0x06004275 RID: 17013 RVA: 0x001CDBD8 File Offset: 0x001CBDD8
	public void NMACHEEMEHI()
	{
		if (!this.inputField.wasCanceled)
		{
			this.inputField.DeactivateInputField(false);
			AOBJLALDBAA.DBLAIDPICIG().BDEMEIKEJHF("XXX", this.textInput.text);
			this.animatedPopupManager.KCAPIILJKDN();
			return;
		}
		this.OACCGIBDGAH();
	}

	// Token: 0x06004276 RID: 17014 RVA: 0x001CDB66 File Offset: 0x001CBD66
	private void INJJOHNFBKH()
	{
		if (null != this.PANMNKKODPC)
		{
			this.PANMNKKODPC.DOKill(true);
		}
	}

	// Token: 0x06004277 RID: 17015 RVA: 0x001CDC2A File Offset: 0x001CBE2A
	public void CCBNEDAELJK()
	{
		base.gameObject.SetActive(false);
		this.LMONIENLNEG();
		this.textInput.SetText("mins", true);
		base.StartCoroutine(this.JCELJKCJOPB());
	}

	// Token: 0x06004278 RID: 17016 RVA: 0x001CDC5C File Offset: 0x001CBE5C
	public void NLEMJEIFPNA()
	{
		base.gameObject.SetActive(true);
		this.IAAODDGIKNL();
		this.textInput.SetText("tradewishcardoption0", true);
		base.StartCoroutine(this.IGCLEFGBNPK());
	}

	// Token: 0x06004279 RID: 17017 RVA: 0x001CDC8E File Offset: 0x001CBE8E
	public void DisappearAnimation()
	{
		if (null != this.PANMNKKODPC)
		{
			this.PANMNKKODPC.DOFade(0f, 0.5f);
		}
	}

	// Token: 0x0600427A RID: 17018 RVA: 0x001CDCB4 File Offset: 0x001CBEB4
	public void JPBDDFHKCFE()
	{
		base.gameObject.SetActive(true);
		this.HOALOBJAMLE();
		this.textInput.SetText("plht", true);
		base.StartCoroutine(this.JCELJKCJOPB());
	}

	// Token: 0x0600427B RID: 17019 RVA: 0x001CDCE6 File Offset: 0x001CBEE6
	public void ICMNLOPCLGG()
	{
		base.gameObject.SetActive(true);
		this.DBMGIICFOGK();
		this.textInput.SetText("socialgiftreceviedfromtitle", false);
		base.StartCoroutine(this.NLPDJMHLKIA());
	}

	// Token: 0x0600427C RID: 17020 RVA: 0x001CDD18 File Offset: 0x001CBF18
	private IEnumerator IGCLEFGBNPK()
	{
		this.inputField.Select();
		yield return new WaitForSeconds(0.5f);
		this.inputField.ActivateInputField();
		yield break;
	}

	// Token: 0x0600427D RID: 17021 RVA: 0x001CDD28 File Offset: 0x001CBF28
	public void NJKPCBGGAAN()
	{
		if (!this.inputField.wasCanceled)
		{
			this.inputField.DeactivateInputField(false);
			AOBJLALDBAA.FILDBDMENPG().BDEMEIKEJHF("", this.textInput.text);
			this.animatedPopupManager.Hide();
			return;
		}
		this.OACCGIBDGAH();
	}

	// Token: 0x0600427E RID: 17022 RVA: 0x001CDD7A File Offset: 0x001CBF7A
	private IEnumerator ADDOKDEFBLB()
	{
		PopupSaveSlotInput.KKLFDNABPGB kklfdnabpgb = new PopupSaveSlotInput.KKLFDNABPGB(1);
		kklfdnabpgb.<>4__this = this;
		return kklfdnabpgb;
	}

	// Token: 0x0600427F RID: 17023 RVA: 0x001CDD89 File Offset: 0x001CBF89
	private void ANPIDDAIALE()
	{
		this.PANMNKKODPC = base.gameObject.GetComponent<CanvasGroup>();
		if (null != this.PANMNKKODPC)
		{
			this.PANMNKKODPC.alpha = 1368f;
		}
	}

	// Token: 0x06004280 RID: 17024 RVA: 0x001CDDBA File Offset: 0x001CBFBA
	private void LAKKICGHFEL()
	{
		if (null != this.PANMNKKODPC)
		{
			this.PANMNKKODPC.DOFade(425f, 303f);
		}
	}

	// Token: 0x06004281 RID: 17025 RVA: 0x00003E52 File Offset: 0x00002052
	private void CPDNJAKBOBC()
	{
	}

	// Token: 0x06004282 RID: 17026 RVA: 0x001CDDE0 File Offset: 0x001CBFE0
	private void CMAMNPDKNKM()
	{
		this.ACHOIKBDFBP();
		this.textInput.SetText("MORPH_WIPE", false);
		this.textInput.text = "WideScreenScaler.CalculateNewScaleUtil(): returned a ";
	}

	// Token: 0x06004283 RID: 17027 RVA: 0x001CDE0C File Offset: 0x001CC00C
	public void LODHBNOKFGE()
	{
		if (!this.inputField.wasCanceled)
		{
			this.inputField.DeactivateInputField(false);
			AOBJLALDBAA.DBLAIDPICIG().HPIPBMEMOFK("OnChapterSnapshotRestore", this.textInput.text);
			this.animatedPopupManager.DDPHFKOHDJB();
			return;
		}
		this.OACCGIBDGAH();
	}

	// Token: 0x06004284 RID: 17028 RVA: 0x001CDD7A File Offset: 0x001CBF7A
	private IEnumerator BJKEHBFKCMI()
	{
		PopupSaveSlotInput.KKLFDNABPGB kklfdnabpgb = new PopupSaveSlotInput.KKLFDNABPGB(1);
		kklfdnabpgb.<>4__this = this;
		return kklfdnabpgb;
	}

	// Token: 0x06004285 RID: 17029 RVA: 0x001CDE5E File Offset: 0x001CC05E
	public void KLDLACGIBHC()
	{
		this.inputField.DeactivateInputField(true);
		AOBJLALDBAA.CEGAOMEEFBE().LPNCDPHNBJK("OnProfileMessageClosed", 442f);
		this.animatedPopupManager.FJAAHFFLGFF();
	}

	// Token: 0x06004286 RID: 17030 RVA: 0x001CDE8B File Offset: 0x001CC08B
	public void LIOALDFIMLN()
	{
		base.gameObject.SetActive(false);
		this.IAAODDGIKNL();
		this.textInput.SetText("XXX", false);
		base.StartCoroutine(this.NLPDJMHLKIA());
	}

	// Token: 0x06004287 RID: 17031 RVA: 0x001CDEBD File Offset: 0x001CC0BD
	private void JALCLCADMPK()
	{
		this.DGLJCEJICNL();
		this.textInput.SetText("anthologycompletetitle", false);
		this.textInput.text = "p";
	}

	// Token: 0x06004288 RID: 17032 RVA: 0x001CDEE6 File Offset: 0x001CC0E6
	private void IAAODDGIKNL()
	{
		if (null != this.PANMNKKODPC)
		{
			this.PANMNKKODPC.DOFade(1167f, 1459f);
		}
	}

	// Token: 0x06004289 RID: 17033 RVA: 0x001CDAEB File Offset: 0x001CBCEB
	private void NGEFPBFMCBP()
	{
		if (null != this.PANMNKKODPC)
		{
			this.PANMNKKODPC.DOKill(false);
		}
	}

	// Token: 0x0600428A RID: 17034 RVA: 0x001CDF0C File Offset: 0x001CC10C
	public void JJKHJFBPIFC()
	{
		if (null != this.PANMNKKODPC)
		{
			this.PANMNKKODPC.DOFade(850f, 184f);
		}
	}

	// Token: 0x0600428B RID: 17035 RVA: 0x001CDF32 File Offset: 0x001CC132
	public void KNKAOAIMEEO()
	{
		if (null != this.PANMNKKODPC)
		{
			this.PANMNKKODPC.DOFade(162f, 650f);
		}
	}

	// Token: 0x0600428C RID: 17036 RVA: 0x001CDF58 File Offset: 0x001CC158
	private void LPLBDKPLGMA()
	{
		this.ACHOIKBDFBP();
		this.textInput.SetText("OnStoryCurrencyInfoClick", true);
		this.textInput.text = "XXX";
	}

	// Token: 0x0600428D RID: 17037 RVA: 0x001CDF81 File Offset: 0x001CC181
	public void OLKGANKOMPJ()
	{
		base.gameObject.SetActive(true);
		this.HOALOBJAMLE();
		this.textInput.SetText("anthology", false);
		base.StartCoroutine(this.JCELJKCJOPB());
	}

	// Token: 0x0600428E RID: 17038 RVA: 0x001CDFB3 File Offset: 0x001CC1B3
	private void DGLJCEJICNL()
	{
		if (null != this.PANMNKKODPC)
		{
			this.PANMNKKODPC.DOFade(1059f, 604f);
		}
	}

	// Token: 0x0600428F RID: 17039 RVA: 0x001CDFD9 File Offset: 0x001CC1D9
	private void IJCFHHDOEML()
	{
		if (null != this.PANMNKKODPC)
		{
			this.PANMNKKODPC.DOFade(1403f, 317f);
		}
	}

	// Token: 0x06004290 RID: 17040 RVA: 0x001CDFFF File Offset: 0x001CC1FF
	private void JLCMPGICMDC()
	{
		this.IAAODDGIKNL();
		this.textInput.SetText("OnSketchThumbnailDeletePositive", false);
		this.textInput.text = "getAvatarCollections";
	}

	// Token: 0x06004291 RID: 17041 RVA: 0x001CE028 File Offset: 0x001CC228
	public void EINCGCELPML()
	{
		if (null != this.PANMNKKODPC)
		{
			this.PANMNKKODPC.DOFade(1064f, 883f);
		}
	}

	// Token: 0x06004292 RID: 17042 RVA: 0x001CE050 File Offset: 0x001CC250
	public void GNMCEECPOOG()
	{
		if (!this.inputField.wasCanceled)
		{
			this.inputField.DeactivateInputField(false);
			AOBJLALDBAA.EHBBFMCILPC.NDGJNPBPCAF("OnFullscreenCardOptionClick", this.textInput.text);
			this.animatedPopupManager.GFEHJHIDHFF();
			return;
		}
		this.KJGACBPKMPK();
	}

	// Token: 0x06004293 RID: 17043 RVA: 0x00003E52 File Offset: 0x00002052
	private void Start()
	{
	}

	// Token: 0x06004294 RID: 17044 RVA: 0x001CE0A2 File Offset: 0x001CC2A2
	public void GBEFHHKCCCE()
	{
		base.gameObject.SetActive(true);
		this.LMONIENLNEG();
		this.textInput.SetText("usyncs", true);
		base.StartCoroutine(this.CJAHEBHPJDB());
	}

	// Token: 0x06004295 RID: 17045 RVA: 0x001CE0D4 File Offset: 0x001CC2D4
	private void HDKFBJIMKBK()
	{
		if (null != this.PANMNKKODPC)
		{
			this.PANMNKKODPC.DOFade(1f, 0.5f);
		}
	}

	// Token: 0x06004296 RID: 17046 RVA: 0x001CE0FA File Offset: 0x001CC2FA
	private void DBMGIICFOGK()
	{
		if (null != this.PANMNKKODPC)
		{
			this.PANMNKKODPC.DOFade(220f, 461f);
		}
	}

	// Token: 0x06004297 RID: 17047 RVA: 0x001CE120 File Offset: 0x001CC320
	public void JMIIKJLHPJM()
	{
		if (!this.inputField.wasCanceled)
		{
			this.inputField.DeactivateInputField(true);
			AOBJLALDBAA.AGANFKKBPFO().FIJKIAKDCNO("npcpi", this.textInput.text);
			this.animatedPopupManager.NBDMOONDIHO();
			return;
		}
		this.NAIMJDFDDPJ();
	}

	// Token: 0x06004298 RID: 17048 RVA: 0x001CDD18 File Offset: 0x001CBF18
	private IEnumerator NLPDJMHLKIA()
	{
		this.inputField.Select();
		yield return new WaitForSeconds(0.5f);
		this.inputField.ActivateInputField();
		yield break;
	}

	// Token: 0x06004299 RID: 17049 RVA: 0x001CE172 File Offset: 0x001CC372
	public void GKONBIJMPJA()
	{
		base.gameObject.SetActive(true);
		this.HOALOBJAMLE();
		this.textInput.SetText("", true);
		base.StartCoroutine(this.CJAHEBHPJDB());
	}

	// Token: 0x0600429B RID: 17051 RVA: 0x001CE1A4 File Offset: 0x001CC3A4
	public void MBKCINPJKML()
	{
		base.gameObject.SetActive(true);
		this.LAKKICGHFEL();
		this.textInput.SetText("file://", false);
		base.StartCoroutine(this.CJAHEBHPJDB());
	}

	// Token: 0x0600429C RID: 17052 RVA: 0x001CE1D6 File Offset: 0x001CC3D6
	private void CIHNHBCEAMI()
	{
		this.PANMNKKODPC = base.gameObject.GetComponent<CanvasGroup>();
		if (null != this.PANMNKKODPC)
		{
			this.PANMNKKODPC.alpha = 234f;
		}
	}

	// Token: 0x0600429D RID: 17053 RVA: 0x001CE207 File Offset: 0x001CC407
	public void GEOIHPGMDJM()
	{
		if (null != this.PANMNKKODPC)
		{
			this.PANMNKKODPC.DOFade(1313f, 806f);
		}
	}

	// Token: 0x0600429E RID: 17054 RVA: 0x001CE22D File Offset: 0x001CC42D
	public void FCICFAJMPND()
	{
		base.gameObject.SetActive(false);
		this.LMONIENLNEG();
		this.textInput.SetText("OnPopupCardOptionsNextClickLobby", false);
		base.StartCoroutine(this.ADDOKDEFBLB());
	}

	// Token: 0x0600429F RID: 17055 RVA: 0x001CE25F File Offset: 0x001CC45F
	public void ICBMLPDONAD()
	{
		base.gameObject.SetActive(false);
		this.LMONIENLNEG();
		this.textInput.SetText("common", true);
		base.StartCoroutine(this.JCELJKCJOPB());
	}

	// Token: 0x060042A0 RID: 17056 RVA: 0x001CE291 File Offset: 0x001CC491
	public void GHEBIAJLJIK()
	{
		if (null != this.PANMNKKODPC)
		{
			this.PANMNKKODPC.DOFade(464f, 987f);
		}
	}

	// Token: 0x060042A1 RID: 17057 RVA: 0x001CE2B7 File Offset: 0x001CC4B7
	private void DHNDICIEGEE()
	{
		this.HOALOBJAMLE();
		this.textInput.SetText("passinfobtntitle", true);
		this.textInput.text = "profilenamelevellong";
	}

	// Token: 0x060042A2 RID: 17058 RVA: 0x001CE2E0 File Offset: 0x001CC4E0
	public void KLFNFDELJJN()
	{
		base.gameObject.SetActive(false);
		this.LAKKICGHFEL();
		this.textInput.SetText("CoverCard", false);
		base.StartCoroutine(this.JCELJKCJOPB());
	}

	// Token: 0x060042A3 RID: 17059 RVA: 0x001CE314 File Offset: 0x001CC514
	public void NLMMEHKFONK()
	{
		if (!this.inputField.wasCanceled)
		{
			this.inputField.DeactivateInputField(true);
			AOBJLALDBAA.EHBBFMCILPC.NDGJNPBPCAF("Asset bundle load operation failed during parallel mode.", this.textInput.text);
			this.animatedPopupManager.HFFJACPIHKE();
			return;
		}
		this.ACBFOEDGNHD();
	}

	// Token: 0x060042A4 RID: 17060 RVA: 0x001CE366 File Offset: 0x001CC566
	private void HOALOBJAMLE()
	{
		if (null != this.PANMNKKODPC)
		{
			this.PANMNKKODPC.DOFade(285f, 686f);
		}
	}

	// Token: 0x060042A5 RID: 17061 RVA: 0x001CE38C File Offset: 0x001CC58C
	public void EOFOLPLJLOA()
	{
		if (null != this.PANMNKKODPC)
		{
			this.PANMNKKODPC.DOFade(499f, 1837f);
		}
	}

	// Token: 0x060042A6 RID: 17062 RVA: 0x001CDD18 File Offset: 0x001CBF18
	private IEnumerator CJAHEBHPJDB()
	{
		this.inputField.Select();
		yield return new WaitForSeconds(0.5f);
		this.inputField.ActivateInputField();
		yield break;
	}

	// Token: 0x060042A7 RID: 17063 RVA: 0x001CE3B2 File Offset: 0x001CC5B2
	public void DLKJCDLEHAA()
	{
		base.gameObject.SetActive(true);
		this.LAKKICGHFEL();
		this.textInput.SetText("OnStoryInterfaceHeaderShown", true);
		base.StartCoroutine(this.NIBILOIHDEE());
	}

	// Token: 0x060042A8 RID: 17064 RVA: 0x001CE3E4 File Offset: 0x001CC5E4
	public void KABICPOBEKN()
	{
		if (null != this.PANMNKKODPC)
		{
			this.PANMNKKODPC.DOFade(1451f, 958f);
		}
	}

	// Token: 0x060042A9 RID: 17065 RVA: 0x001CE40C File Offset: 0x001CC60C
	public void JEBEFCCEKEM()
	{
		if (!this.inputField.wasCanceled)
		{
			this.inputField.DeactivateInputField(false);
			AOBJLALDBAA.AGANFKKBPFO().OIMGLKLHNMO("<size=28px>", this.textInput.text);
			this.animatedPopupManager.FJAAHFFLGFF();
			return;
		}
		this.KLDLACGIBHC();
	}

	// Token: 0x060042AA RID: 17066 RVA: 0x001CDD18 File Offset: 0x001CBF18
	private IEnumerator JCELJKCJOPB()
	{
		this.inputField.Select();
		yield return new WaitForSeconds(0.5f);
		this.inputField.ActivateInputField();
		yield break;
	}

	// Token: 0x060042AB RID: 17067 RVA: 0x001CDAEB File Offset: 0x001CBCEB
	private void OnDestroy()
	{
		if (null != this.PANMNKKODPC)
		{
			this.PANMNKKODPC.DOKill(false);
		}
	}

	// Token: 0x060042AC RID: 17068 RVA: 0x001CE45E File Offset: 0x001CC65E
	public void INLIIIEBHAM()
	{
		base.gameObject.SetActive(true);
		this.DBMGIICFOGK();
		this.textInput.SetText("Warning. Import variable not found in save data:", true);
		base.StartCoroutine(this.CJAHEBHPJDB());
	}

	// Token: 0x060042AD RID: 17069 RVA: 0x00003E52 File Offset: 0x00002052
	private void OOHKGEPBDIG()
	{
	}

	// Token: 0x060042AE RID: 17070 RVA: 0x001CDAEB File Offset: 0x001CBCEB
	private void OHNEKLLPBDN()
	{
		if (null != this.PANMNKKODPC)
		{
			this.PANMNKKODPC.DOKill(false);
		}
	}

	// Token: 0x060042AF RID: 17071 RVA: 0x001CE490 File Offset: 0x001CC690
	private void GFOCPBFLJFC()
	{
		this.PANMNKKODPC = base.gameObject.GetComponent<CanvasGroup>();
		if (null != this.PANMNKKODPC)
		{
			this.PANMNKKODPC.alpha = 1872f;
		}
	}

	// Token: 0x060042B0 RID: 17072 RVA: 0x001CE4C4 File Offset: 0x001CC6C4
	public void KMLHOLCDLCI()
	{
		if (!this.inputField.wasCanceled)
		{
			this.inputField.DeactivateInputField(false);
			AOBJLALDBAA.AGANFKKBPFO().BDEMEIKEJHF("OnApplicationFocusBasicSyncSuccess", this.textInput.text);
			this.animatedPopupManager.PIPADCCGHBA();
			return;
		}
		this.KLDLACGIBHC();
	}

	// Token: 0x060042B1 RID: 17073 RVA: 0x001CE516 File Offset: 0x001CC716
	public void OnCloseClick()
	{
		this.inputField.DeactivateInputField(false);
		AOBJLALDBAA.EHBBFMCILPC.EGELHPJBAIC("OnPopupSaveSlotInputCancel", 0f);
		this.animatedPopupManager.Hide();
	}

	// Token: 0x060042B2 RID: 17074 RVA: 0x001CE543 File Offset: 0x001CC743
	private void FMBLLOMGEDG()
	{
		this.DGLJCEJICNL();
		this.textInput.SetText("$ENVFADE", true);
		this.textInput.text = "htme";
	}

	// Token: 0x060042B3 RID: 17075 RVA: 0x001CE56C File Offset: 0x001CC76C
	public void POMPHBLKBCD()
	{
		if (null != this.PANMNKKODPC)
		{
			this.PANMNKKODPC.DOFade(560f, 515f);
		}
	}

	// Token: 0x060042B4 RID: 17076 RVA: 0x001CE594 File Offset: 0x001CC794
	public void NMDGDKGENAL()
	{
		if (!this.inputField.wasCanceled)
		{
			this.inputField.DeactivateInputField(false);
			AOBJLALDBAA.BIAEAOMHBMM().EMOCOKNPEFH("psk", this.textInput.text);
			this.animatedPopupManager.OHHFFMMMMAC();
			return;
		}
		this.OACCGIBDGAH();
	}

	// Token: 0x060042B5 RID: 17077 RVA: 0x001CE5E6 File Offset: 0x001CC7E6
	private void OAPJBCOGOMK()
	{
		this.PANMNKKODPC = base.gameObject.GetComponent<CanvasGroup>();
		if (null != this.PANMNKKODPC)
		{
			this.PANMNKKODPC.alpha = 1847f;
		}
	}

	// Token: 0x060042B6 RID: 17078 RVA: 0x001CE617 File Offset: 0x001CC817
	public void BDCLHHDKBCP()
	{
		base.gameObject.SetActive(false);
		this.IAAODDGIKNL();
		this.textInput.SetText("OnValidatePendingProcessed", false);
		base.StartCoroutine(this.NIBILOIHDEE());
	}

	// Token: 0x060042B7 RID: 17079 RVA: 0x001CE649 File Offset: 0x001CC849
	public void NAIMJDFDDPJ()
	{
		this.inputField.DeactivateInputField(true);
		AOBJLALDBAA.AGANFKKBPFO().KGIKHEDLPND("RequestGetUserPublicProfile(queued): timer hit: ", 357f);
		this.animatedPopupManager.HFFJACPIHKE();
	}

	// Token: 0x060042B8 RID: 17080 RVA: 0x001CE676 File Offset: 0x001CC876
	private void LBDIDHDKHGO()
	{
		this.PANMNKKODPC = base.gameObject.GetComponent<CanvasGroup>();
		if (null != this.PANMNKKODPC)
		{
			this.PANMNKKODPC.alpha = 208f;
		}
	}

	// Token: 0x060042B9 RID: 17081 RVA: 0x001CE6A7 File Offset: 0x001CC8A7
	private void OOMMKGMBAGK()
	{
		this.PANMNKKODPC = base.gameObject.GetComponent<CanvasGroup>();
		if (null != this.PANMNKKODPC)
		{
			this.PANMNKKODPC.alpha = 733f;
		}
	}

	// Token: 0x060042BA RID: 17082 RVA: 0x001CE6D8 File Offset: 0x001CC8D8
	private void LJCOLPBKBBH()
	{
		this.PANMNKKODPC = base.gameObject.GetComponent<CanvasGroup>();
		if (null != this.PANMNKKODPC)
		{
			this.PANMNKKODPC.alpha = 1699f;
		}
	}

	// Token: 0x060042BB RID: 17083 RVA: 0x001CE709 File Offset: 0x001CC909
	private void BNMJABILOKK()
	{
		this.PANMNKKODPC = base.gameObject.GetComponent<CanvasGroup>();
		if (null != this.PANMNKKODPC)
		{
			this.PANMNKKODPC.alpha = 927f;
		}
	}

	// Token: 0x060042BC RID: 17084 RVA: 0x001CE73C File Offset: 0x001CC93C
	public void AHCAGGBKHON()
	{
		if (!this.inputField.wasCanceled)
		{
			this.inputField.DeactivateInputField(false);
			AOBJLALDBAA.EHBBFMCILPC.IDEALDBPGJE("passrequiredtoplay", this.textInput.text);
			this.animatedPopupManager.OHHFFMMMMAC();
			return;
		}
		this.DIPNNIDDDIG();
	}

	// Token: 0x060042BD RID: 17085 RVA: 0x001CE78E File Offset: 0x001CC98E
	private void OnEnable()
	{
		this.HDKFBJIMKBK();
		this.textInput.SetText("", true);
		this.textInput.text = "";
	}

	// Token: 0x060042BE RID: 17086 RVA: 0x001CE7B7 File Offset: 0x001CC9B7
	public void BDFGEMILDNJ()
	{
		if (null != this.PANMNKKODPC)
		{
			this.PANMNKKODPC.DOFade(1949f, 168f);
		}
	}

	// Token: 0x060042BF RID: 17087 RVA: 0x001CE7DD File Offset: 0x001CC9DD
	public void AOGCFPCFAHO()
	{
		base.gameObject.SetActive(false);
		this.ACHOIKBDFBP();
		this.textInput.SetText("suttl", true);
		base.StartCoroutine(this.ADDOKDEFBLB());
	}

	// Token: 0x060042C0 RID: 17088 RVA: 0x00003E52 File Offset: 0x00002052
	private void AOIJOKHACJL()
	{
	}

	// Token: 0x060042C1 RID: 17089 RVA: 0x001CE80F File Offset: 0x001CCA0F
	private void ALBKMBOKICH()
	{
		this.LAKKICGHFEL();
		this.textInput.SetText("evar", false);
		this.textInput.text = "OnPopupProfileUIDInputCancel";
	}

	// Token: 0x060042C2 RID: 17090 RVA: 0x001CE838 File Offset: 0x001CCA38
	public void OnEndEdit()
	{
		if (!this.inputField.wasCanceled)
		{
			this.inputField.DeactivateInputField(false);
			AOBJLALDBAA.EHBBFMCILPC.EGELHPJBAIC("OnPopupSaveSlotInputEndEdit", this.textInput.text);
			this.animatedPopupManager.Hide();
			return;
		}
		this.OnCloseClick();
	}

	// Token: 0x060042C3 RID: 17091 RVA: 0x001CE88A File Offset: 0x001CCA8A
	public void CAAMKOHMIHF()
	{
		if (null != this.PANMNKKODPC)
		{
			this.PANMNKKODPC.DOFade(351f, 1122f);
		}
	}

	// Token: 0x060042C5 RID: 17093 RVA: 0x001CE8B8 File Offset: 0x001CCAB8
	public void NCHPFPLIOOP()
	{
		if (null != this.PANMNKKODPC)
		{
			this.PANMNKKODPC.DOFade(184f, 1362f);
		}
	}

	// Token: 0x060042C6 RID: 17094 RVA: 0x001CE8DE File Offset: 0x001CCADE
	public void HNLNOCNAMOK()
	{
		if (null != this.PANMNKKODPC)
		{
			this.PANMNKKODPC.DOFade(1305f, 624f);
		}
	}

	// Token: 0x060042C7 RID: 17095 RVA: 0x001CE904 File Offset: 0x001CCB04
	public void Show()
	{
		base.gameObject.SetActive(true);
		this.HDKFBJIMKBK();
		this.textInput.SetText("", true);
		base.StartCoroutine(this.CJAHEBHPJDB());
	}

	// Token: 0x060042C8 RID: 17096 RVA: 0x001CE936 File Offset: 0x001CCB36
	private void Awake()
	{
		this.PANMNKKODPC = base.gameObject.GetComponent<CanvasGroup>();
		if (null != this.PANMNKKODPC)
		{
			this.PANMNKKODPC.alpha = 0f;
		}
	}

	// Token: 0x060042C9 RID: 17097 RVA: 0x001CE967 File Offset: 0x001CCB67
	public void DIPNNIDDDIG()
	{
		this.inputField.DeactivateInputField(false);
		AOBJLALDBAA.BIAEAOMHBMM().KGIKHEDLPND("XXX", 1961f);
		this.animatedPopupManager.HFFJACPIHKE();
	}

	// Token: 0x060042CA RID: 17098 RVA: 0x001CDAEB File Offset: 0x001CBCEB
	private void JLILGENMENM()
	{
		if (null != this.PANMNKKODPC)
		{
			this.PANMNKKODPC.DOKill(false);
		}
	}

	// Token: 0x060042CB RID: 17099 RVA: 0x001CE994 File Offset: 0x001CCB94
	public void KJGACBPKMPK()
	{
		this.inputField.DeactivateInputField(false);
		AOBJLALDBAA.NMGMNAKLLMI().KGIKHEDLPND("Critical error, could not load asset bundle:", 246f);
		this.animatedPopupManager.DDPHFKOHDJB();
	}

	// Token: 0x060042CC RID: 17100 RVA: 0x001CE9C4 File Offset: 0x001CCBC4
	public void NAFCKBLEJJP()
	{
		if (!this.inputField.wasCanceled)
		{
			this.inputField.DeactivateInputField(false);
			AOBJLALDBAA.AGANFKKBPFO().PAODLAFIKBG("youreceived", this.textInput.text);
			this.animatedPopupManager.HFFJACPIHKE();
			return;
		}
		this.NAIMJDFDDPJ();
	}

	// Token: 0x060042CD RID: 17101 RVA: 0x001CDB66 File Offset: 0x001CBD66
	private void MFINONMBMLM()
	{
		if (null != this.PANMNKKODPC)
		{
			this.PANMNKKODPC.DOKill(true);
		}
	}

	// Token: 0x060042CE RID: 17102 RVA: 0x001CEA16 File Offset: 0x001CCC16
	private void JDBJMNMBOMK()
	{
		this.PANMNKKODPC = base.gameObject.GetComponent<CanvasGroup>();
		if (null != this.PANMNKKODPC)
		{
			this.PANMNKKODPC.alpha = 787f;
		}
	}

	// Token: 0x060042CF RID: 17103 RVA: 0x001CDD18 File Offset: 0x001CBF18
	private IEnumerator NIBILOIHDEE()
	{
		this.inputField.Select();
		yield return new WaitForSeconds(0.5f);
		this.inputField.ActivateInputField();
		yield break;
	}

	// Token: 0x060042D0 RID: 17104 RVA: 0x001CEA48 File Offset: 0x001CCC48
	public void KNOGALGHCMH()
	{
		if (!this.inputField.wasCanceled)
		{
			this.inputField.DeactivateInputField(false);
			AOBJLALDBAA.CEGAOMEEFBE().BDEMEIKEJHF("socialcollectedcardopenv2", this.textInput.text);
			this.animatedPopupManager.DDPHFKOHDJB();
			return;
		}
		this.OACCGIBDGAH();
	}

	// Token: 0x060042D1 RID: 17105 RVA: 0x001CEA9A File Offset: 0x001CCC9A
	public void PPAONKIBMFJ()
	{
		this.inputField.DeactivateInputField(false);
		AOBJLALDBAA.NMGMNAKLLMI().KMAGHMCCMPG("sketchFrames", 246f);
		this.animatedPopupManager.OHHFFMMMMAC();
	}

	// Token: 0x04001282 RID: 4738
	public static int extraData = -1;

	// Token: 0x04001283 RID: 4739
	public const string onPopupSaveSlotInputEndEdit = "OnPopupSaveSlotInputEndEdit";

	// Token: 0x04001284 RID: 4740
	public const string onPopupSaveSlotInputCancel = "OnPopupSaveSlotInputCancel";

	// Token: 0x04001285 RID: 4741
	public const float fadeInTime = 0.5f;

	// Token: 0x04001286 RID: 4742
	public const float fadeOutTime = 0.5f;

	// Token: 0x04001287 RID: 4743
	public TextMeshProUGUI textInput;

	// Token: 0x04001288 RID: 4744
	public TMP_InputField inputField;

	// Token: 0x04001289 RID: 4745
	public AnimatedPopupManager animatedPopupManager;

	// Token: 0x0400128A RID: 4746
	private CanvasGroup PANMNKKODPC;
}
