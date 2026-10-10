using System;
using System.Collections;
using DG.Tweening;
using TMPro;
using UnityEngine;

// Token: 0x02000149 RID: 329
public class PopupProfileUIDInput : MonoBehaviour
{
	// Token: 0x06002BEB RID: 11243 RVA: 0x001369F4 File Offset: 0x00134BF4
	public void AJBMEDJNOAO(int CPKFEMAOOBH)
	{
		this.MLKELKKMBLF = CPKFEMAOOBH;
		base.gameObject.SetActive(true);
		this.BLGBPGMDIIC();
		this.textInput.SetText("none", true);
		if (this.MLKELKKMBLF == 0)
		{
			this.textTitle.SetText(CCOJBMMKNAP.HJGDLOOHNLO().DNILNCLIHAP(" "), false);
			this.textTitle.text = CCOJBMMKNAP.DBFFFOMCLKM().MEPECBDCOLG("OnStoryInterfaceButtonUndoClick");
		}
		else if (this.MLKELKKMBLF == 0)
		{
			this.textTitle.SetText(CCOJBMMKNAP.LMCCLMFGEBD().OHLNGCKIACD("prgr"), false);
			this.textTitle.text = CCOJBMMKNAP.PLJMLDOCPNM().JHNELLJFBGC("voiceover");
		}
		else if (this.MLKELKKMBLF == 1)
		{
			this.textTitle.SetText(CCOJBMMKNAP.PMABBOJDELF().JCDFHKDNEDH("hof"), false);
			this.textTitle.text = CCOJBMMKNAP.HEDIEIICOOG().IPEIONBNIPH("PurchaseManagerUnity.OnErrorInitializeGamingServices(): Error:");
		}
		else
		{
			this.textTitle.SetText(CCOJBMMKNAP.CPCOODCFDDP().GGPHHLGPMPA(">"), false);
			this.textTitle.text = CCOJBMMKNAP.ILACPHFEDEP().HDIPNMFHIEJ("continue");
		}
		base.StartCoroutine(this.POMBPCOBGKP());
	}

	// Token: 0x06002BEC RID: 11244 RVA: 0x00136B30 File Offset: 0x00134D30
	public void JHFCEEALKBL()
	{
		if (!this.inputField.wasCanceled)
		{
			this.inputField.DeactivateInputField(false);
			AOBJLALDBAA.AGANFKKBPFO().OIMGLKLHNMO("seasoncompletedescspecialepisode", this.textInput.text);
			this.animatedPopupManager.OJNDEJNLMFE();
			return;
		}
		this.KIBBJLIFJMN();
	}

	// Token: 0x06002BED RID: 11245 RVA: 0x00136B82 File Offset: 0x00134D82
	private void INLMEILMIBD()
	{
		if (null != this.PANMNKKODPC)
		{
			this.PANMNKKODPC.DOFade(1414f, 563f);
		}
	}

	// Token: 0x06002BEE RID: 11246 RVA: 0x00136BA8 File Offset: 0x00134DA8
	private void AEMMGIDDBHO()
	{
		this.EGOLCKBOOJF();
		this.textInput.SetText("1.0.0", false);
		this.textInput.text = "OnChapterSnapshotsBackendFetchException2";
	}

	// Token: 0x06002BEF RID: 11247 RVA: 0x00136BD1 File Offset: 0x00134DD1
	private void EKEOFMOJCGF()
	{
		this.PANMNKKODPC = base.gameObject.GetComponent<CanvasGroup>();
		if (null != this.PANMNKKODPC)
		{
			this.PANMNKKODPC.alpha = 1424f;
		}
	}

	// Token: 0x06002BF0 RID: 11248 RVA: 0x00136C02 File Offset: 0x00134E02
	public int CCPONBOEINK()
	{
		return this.MLKELKKMBLF;
	}

	// Token: 0x06002BF1 RID: 11249 RVA: 0x00136C0A File Offset: 0x00134E0A
	private IEnumerator IEDILHDCBMA()
	{
		this.inputField.Select();
		yield return new WaitForSeconds(0.5f);
		this.inputField.ActivateInputField();
		yield break;
	}

	// Token: 0x06002BF2 RID: 11250 RVA: 0x00136C19 File Offset: 0x00134E19
	private void MKBADGCCNDJ()
	{
		this.HFKMDGNDCGD();
		this.textInput.SetText("ext", false);
		this.textInput.text = "' dropped";
	}

	// Token: 0x06002BF3 RID: 11251 RVA: 0x00136C42 File Offset: 0x00134E42
	private void AAKDPLPPLMC()
	{
		this.MOJFEKNDCMJ();
		this.textInput.SetText("deleteprofilesuccess", true);
		this.textInput.text = "a_web";
	}

	// Token: 0x06002BF4 RID: 11252 RVA: 0x00003E52 File Offset: 0x00002052
	private void CPDNJAKBOBC()
	{
	}

	// Token: 0x06002BF5 RID: 11253 RVA: 0x00136C02 File Offset: 0x00134E02
	public int OFKEDMDOKAP()
	{
		return this.MLKELKKMBLF;
	}

	// Token: 0x06002BF6 RID: 11254 RVA: 0x00136C02 File Offset: 0x00134E02
	public int POBIEPFHIPP()
	{
		return this.MLKELKKMBLF;
	}

	// Token: 0x06002BF7 RID: 11255 RVA: 0x00136C02 File Offset: 0x00134E02
	public int GetFlag()
	{
		return this.MLKELKKMBLF;
	}

	// Token: 0x06002BF8 RID: 11256 RVA: 0x00136C6B File Offset: 0x00134E6B
	private void HDKFBJIMKBK()
	{
		if (null != this.PANMNKKODPC)
		{
			this.PANMNKKODPC.DOFade(1f, 0.5f);
		}
	}

	// Token: 0x06002BF9 RID: 11257 RVA: 0x00136C91 File Offset: 0x00134E91
	private void MGIELDOCOPG()
	{
		if (null != this.PANMNKKODPC)
		{
			this.PANMNKKODPC.DOFade(283f, 519f);
		}
	}

	// Token: 0x06002BFA RID: 11258 RVA: 0x00136CB7 File Offset: 0x00134EB7
	private void PABMEBKPBJO()
	{
		this.EGOLCKBOOJF();
		this.textInput.SetText("OnSettingsPopupClose", true);
		this.textInput.text = ", slot ";
	}

	// Token: 0x06002BFB RID: 11259 RVA: 0x00136CE0 File Offset: 0x00134EE0
	public void NEGDIBLKKGP()
	{
		this.inputField.DeactivateInputField(false);
		AOBJLALDBAA.KKPFOJMAONG().EGELHPJBAIC("XXX", 570f);
		this.animatedPopupManager.OJNDEJNLMFE();
	}

	// Token: 0x06002BFC RID: 11260 RVA: 0x00136D10 File Offset: 0x00134F10
	public void MBKCINPJKML(int CPKFEMAOOBH)
	{
		this.MLKELKKMBLF = CPKFEMAOOBH;
		base.gameObject.SetActive(false);
		this.HCNIIEFNDPC();
		this.textInput.SetText("TV dots", false);
		if (this.MLKELKKMBLF == 0)
		{
			this.textTitle.SetText(CCOJBMMKNAP.NIOJNOFGIJO().PPALCPINPLK("asset("), true);
			this.textTitle.text = CCOJBMMKNAP.CEGAOMEEFBE().DNILNCLIHAP("bdgsspr");
		}
		else if (this.MLKELKKMBLF == 1)
		{
			this.textTitle.SetText(CCOJBMMKNAP.BBGECIKOICE().OHLNGCKIACD("@"), false);
			this.textTitle.text = CCOJBMMKNAP.FEEDGKCJBLE().HPOAGPJFHPM("");
		}
		else if (this.MLKELKKMBLF == 3)
		{
			this.textTitle.SetText(CCOJBMMKNAP.JMDJPKKOHNI().PKNHKGMNCIP("sto"), false);
			this.textTitle.text = CCOJBMMKNAP.KNKGCDDMLDP().HDIPNMFHIEJ("slowest");
		}
		else
		{
			this.textTitle.SetText(CCOJBMMKNAP.KFDLFGHBPLP().JCDFHKDNEDH(", index:"), false);
			this.textTitle.text = CCOJBMMKNAP.ONCPHEEJLOP().HDIPNMFHIEJ("Asset bundle load operation failed during parallel mode.");
		}
		base.StartCoroutine(this.IEDILHDCBMA());
	}

	// Token: 0x06002BFD RID: 11261 RVA: 0x00136C02 File Offset: 0x00134E02
	public int DBMFPNBHECC()
	{
		return this.MLKELKKMBLF;
	}

	// Token: 0x06002BFE RID: 11262 RVA: 0x00136E4B File Offset: 0x0013504B
	private void EOAKHNIJECB()
	{
		this.EGOLCKBOOJF();
		this.textInput.SetText("OnBackendPremiumChoiceException", false);
		this.textInput.text = " XXX";
	}

	// Token: 0x06002BFF RID: 11263 RVA: 0x00136C0A File Offset: 0x00134E0A
	private IEnumerator GOCCKEGOKGN()
	{
		this.inputField.Select();
		yield return new WaitForSeconds(0.5f);
		this.inputField.ActivateInputField();
		yield break;
	}

	// Token: 0x06002C00 RID: 11264 RVA: 0x00136E74 File Offset: 0x00135074
	public void HMDKDFFEJOC()
	{
		if (!this.inputField.wasCanceled)
		{
			this.inputField.DeactivateInputField(false);
			AOBJLALDBAA.KKPFOJMAONG().HPIPBMEMOFK("app42error", this.textInput.text);
			this.animatedPopupManager.HFFJACPIHKE();
			return;
		}
		this.LAEGEMDLBED();
	}

	// Token: 0x06002C01 RID: 11265 RVA: 0x00136EC8 File Offset: 0x001350C8
	public void GANECJLKGFD(int CPKFEMAOOBH)
	{
		this.MLKELKKMBLF = CPKFEMAOOBH;
		base.gameObject.SetActive(true);
		this.EGOLCKBOOJF();
		this.textInput.SetText("pid", false);
		if (this.MLKELKKMBLF == 0)
		{
			this.textTitle.SetText(CCOJBMMKNAP.LMCCLMFGEBD().PPALCPINPLK("aspkss"), false);
			this.textTitle.text = CCOJBMMKNAP.INKJIBDDMLL().PPALCPINPLK("ok");
		}
		else if (this.MLKELKKMBLF == 1)
		{
			this.textTitle.SetText(CCOJBMMKNAP.OEPENBHJAHO().BGELFMIOBCL("OnChapterSnapshotRestore"), true);
			this.textTitle.text = CCOJBMMKNAP.BIAEAOMHBMM().BGELFMIOBCL("yes");
		}
		else if (this.MLKELKKMBLF == 7)
		{
			this.textTitle.SetText(CCOJBMMKNAP.OBOOKJPGBJN().JCDFHKDNEDH("\""), true);
			this.textTitle.text = CCOJBMMKNAP.PKEINLPIAEH().OBDCPLLLGBB("");
		}
		else
		{
			this.textTitle.SetText(CCOJBMMKNAP.MPCBJEIMACA().JHNELLJFBGC("Swipe tutorial frame container not available, tutorial skipped:"), true);
			this.textTitle.text = CCOJBMMKNAP.INKJIBDDMLL().JHNELLJFBGC("OnStoryChoiceClick");
		}
		base.StartCoroutine(this.CNCKEKIIJKJ());
	}

	// Token: 0x06002C02 RID: 11266 RVA: 0x00137004 File Offset: 0x00135204
	public void KEJGIJLHLIE(int CPKFEMAOOBH)
	{
		this.MLKELKKMBLF = CPKFEMAOOBH;
		base.gameObject.SetActive(false);
		this.HFKMDGNDCGD();
		this.textInput.SetText("errortitle", false);
		if (this.MLKELKKMBLF == 0)
		{
			this.textTitle.SetText(CCOJBMMKNAP.HEDIEIICOOG().BGELFMIOBCL("[LoadingEnv] cache files of "), true);
			this.textTitle.text = CCOJBMMKNAP.NIOJNOFGIJO().GGPHHLGPMPA("_");
		}
		else if (this.MLKELKKMBLF == 0)
		{
			this.textTitle.SetText(CCOJBMMKNAP.BIAEAOMHBMM().PGKBCNBAOJN("no"), true);
			this.textTitle.text = CCOJBMMKNAP.INKJIBDDMLL().HIPJILDCHJC("OnCutsceneViewAssetBundleFolderInitializeSuccess");
		}
		else if (this.MLKELKKMBLF == 2)
		{
			this.textTitle.SetText(CCOJBMMKNAP.EHBBFMCILPC.BDGPNPNIAPA(" tokens "), true);
			this.textTitle.text = CCOJBMMKNAP.KMNBCEMEBBD().HHLECNIFHCO("profileiplayrclong");
		}
		else
		{
			this.textTitle.SetText(CCOJBMMKNAP.NIOJNOFGIJO().PKNHKGMNCIP(">"), false);
			this.textTitle.text = CCOJBMMKNAP.PKEINLPIAEH().IKMNGFIDCLM("storyAssetPackManager[i].storyItemsAssets[j] is null!");
		}
		base.StartCoroutine(this.GOCCKEGOKGN());
	}

	// Token: 0x06002C03 RID: 11267 RVA: 0x0013713F File Offset: 0x0013533F
	public void KJGACBPKMPK()
	{
		this.inputField.DeactivateInputField(false);
		AOBJLALDBAA.NMGMNAKLLMI().DCGCFPHHDDG("OnLobbyManInTheMiddleAttackDetected", 1379f);
		this.animatedPopupManager.FJAAHFFLGFF();
	}

	// Token: 0x06002C04 RID: 11268 RVA: 0x00003E52 File Offset: 0x00002052
	private void Start()
	{
	}

	// Token: 0x06002C05 RID: 11269 RVA: 0x0013716C File Offset: 0x0013536C
	public void PGGAAENAIJP()
	{
		if (null != this.PANMNKKODPC)
		{
			this.PANMNKKODPC.DOFade(1026f, 1794f);
		}
	}

	// Token: 0x06002C06 RID: 11270 RVA: 0x00137192 File Offset: 0x00135392
	public void OOOOJCPMAAO()
	{
		if (null != this.PANMNKKODPC)
		{
			this.PANMNKKODPC.DOFade(503f, 1912f);
		}
	}

	// Token: 0x06002C07 RID: 11271 RVA: 0x001371B8 File Offset: 0x001353B8
	public void JMNCLDFCAHD(int CPKFEMAOOBH)
	{
		this.MLKELKKMBLF = CPKFEMAOOBH;
		base.gameObject.SetActive(true);
		this.BLGBPGMDIIC();
		this.textInput.SetText("HD", true);
		if (this.MLKELKKMBLF == 0)
		{
			this.textTitle.SetText(CCOJBMMKNAP.KFAABHHGOPO().HPOAGPJFHPM(""), false);
			this.textTitle.text = CCOJBMMKNAP.LMCCLMFGEBD().JHNELLJFBGC("[ ");
		}
		else if (this.MLKELKKMBLF == 0)
		{
			this.textTitle.SetText(CCOJBMMKNAP.OEPENBHJAHO().MEPECBDCOLG("ok"), false);
			this.textTitle.text = CCOJBMMKNAP.EAIAHCBAIEJ().MEPECBDCOLG("oid");
		}
		else if (this.MLKELKKMBLF == 7)
		{
			this.textTitle.SetText(CCOJBMMKNAP.JINDKPHNLBK().HPOAGPJFHPM("msrc"), true);
			this.textTitle.text = CCOJBMMKNAP.FEEDGKCJBLE().IPEIONBNIPH("\"");
		}
		else
		{
			this.textTitle.SetText(CCOJBMMKNAP.ILACPHFEDEP().PGKBCNBAOJN("+"), true);
			this.textTitle.text = CCOJBMMKNAP.CEGAOMEEFBE().HPOAGPJFHPM("passinfobtntitle");
		}
		base.StartCoroutine(this.FFKCEJPBEEG());
	}

	// Token: 0x06002C08 RID: 11272 RVA: 0x001372F3 File Offset: 0x001354F3
	public void NABADENNICC()
	{
		if (null != this.PANMNKKODPC)
		{
			this.PANMNKKODPC.DOFade(1946f, 652f);
		}
	}

	// Token: 0x06002C09 RID: 11273 RVA: 0x00137319 File Offset: 0x00135519
	private IEnumerator FFKCEJPBEEG()
	{
		PopupProfileUIDInput.BLLLGMMKCIG blllgmmkcig = new PopupProfileUIDInput.BLLLGMMKCIG(1);
		blllgmmkcig.<>4__this = this;
		return blllgmmkcig;
	}

	// Token: 0x06002C0A RID: 11274 RVA: 0x00137319 File Offset: 0x00135519
	private IEnumerator CPBEEPAGHAK()
	{
		PopupProfileUIDInput.BLLLGMMKCIG blllgmmkcig = new PopupProfileUIDInput.BLLLGMMKCIG(1);
		blllgmmkcig.<>4__this = this;
		return blllgmmkcig;
	}

	// Token: 0x06002C0B RID: 11275 RVA: 0x00137328 File Offset: 0x00135528
	public void GMGJDDFDIAD()
	{
		this.inputField.DeactivateInputField(false);
		AOBJLALDBAA.EHBBFMCILPC.FDKBIBKABCM("importanttitle", 10f);
		this.animatedPopupManager.OJNDEJNLMFE();
	}

	// Token: 0x06002C0C RID: 11276 RVA: 0x00137319 File Offset: 0x00135519
	private IEnumerator GMNJEDJKMED()
	{
		PopupProfileUIDInput.BLLLGMMKCIG blllgmmkcig = new PopupProfileUIDInput.BLLLGMMKCIG(1);
		blllgmmkcig.<>4__this = this;
		return blllgmmkcig;
	}

	// Token: 0x06002C0D RID: 11277 RVA: 0x00136C02 File Offset: 0x00134E02
	public int JNPBECMKCFE()
	{
		return this.MLKELKKMBLF;
	}

	// Token: 0x06002C0E RID: 11278 RVA: 0x00137355 File Offset: 0x00135555
	private void JALCLCADMPK()
	{
		this.LBDPGIGNEDC();
		this.textInput.SetText("secondsshort", true);
		this.textInput.text = "SkinShopItem";
	}

	// Token: 0x06002C0F RID: 11279 RVA: 0x0013737E File Offset: 0x0013557E
	public void NNNIMAAFAKL()
	{
		if (null != this.PANMNKKODPC)
		{
			this.PANMNKKODPC.DOFade(313f, 632f);
		}
	}

	// Token: 0x06002C10 RID: 11280 RVA: 0x001373A4 File Offset: 0x001355A4
	public void MLIKEHIHCNM()
	{
		this.inputField.DeactivateInputField(true);
		AOBJLALDBAA.NMGMNAKLLMI().DCGCFPHHDDG("‐", 65f);
		this.animatedPopupManager.ADAJPNHIICL();
	}

	// Token: 0x06002C11 RID: 11281 RVA: 0x001373D4 File Offset: 0x001355D4
	public void OLKGANKOMPJ(int CPKFEMAOOBH)
	{
		this.MLKELKKMBLF = CPKFEMAOOBH;
		base.gameObject.SetActive(false);
		this.HCNIIEFNDPC();
		this.textInput.SetText("restartepisode", true);
		if (this.MLKELKKMBLF == 0)
		{
			this.textTitle.SetText(CCOJBMMKNAP.BIAEAOMHBMM().IPEIONBNIPH(""), false);
			this.textTitle.text = CCOJBMMKNAP.PKEINLPIAEH().PPALCPINPLK("stat5");
		}
		else if (this.MLKELKKMBLF == 1)
		{
			this.textTitle.SetText(CCOJBMMKNAP.HEDIEIICOOG().FCOCLEHKLDJ("_StripeStrength"), true);
			this.textTitle.text = CCOJBMMKNAP.HEDIEIICOOG().HPOAGPJFHPM("importanttitle");
		}
		else if (this.MLKELKKMBLF == 1)
		{
			this.textTitle.SetText(CCOJBMMKNAP.EHBBFMCILPC.JLBEIFLLBLO("OnFullscreenLiveOfferContinueToPurchasingScreen"), true);
			this.textTitle.text = CCOJBMMKNAP.JINDKPHNLBK().HDIPNMFHIEJ("emsv");
		}
		else
		{
			this.textTitle.SetText(CCOJBMMKNAP.ILACPHFEDEP().FIENAKIHNOM(" "), false);
			this.textTitle.text = CCOJBMMKNAP.FEEDGKCJBLE().OHLNGCKIACD("Custom effects asset index mismatch, correcting ");
		}
		base.StartCoroutine(this.FFKCEJPBEEG());
	}

	// Token: 0x06002C12 RID: 11282 RVA: 0x0013750F File Offset: 0x0013570F
	private void EKOGHMFPHDH()
	{
		this.EGOLCKBOOJF();
		this.textInput.SetText("avatarstitle", false);
		this.textInput.text = "+";
	}

	// Token: 0x06002C13 RID: 11283 RVA: 0x00137538 File Offset: 0x00135738
	private void ICDHNPPEONB()
	{
		this.BLGBPGMDIIC();
		this.textInput.SetText("energyhinttitle", true);
		this.textInput.text = "asp";
	}

	// Token: 0x06002C14 RID: 11284 RVA: 0x00137564 File Offset: 0x00135764
	public void AMDNDPDKPIN()
	{
		if (!this.inputField.wasCanceled)
		{
			this.inputField.DeactivateInputField(true);
			AOBJLALDBAA.DBLAIDPICIG().EGELHPJBAIC("assetbundleprofiledata4", this.textInput.text);
			this.animatedPopupManager.GFEHJHIDHFF();
			return;
		}
		this.GMGJDDFDIAD();
	}

	// Token: 0x06002C15 RID: 11285 RVA: 0x00003E52 File Offset: 0x00002052
	private void EGMNIHKPEFF()
	{
	}

	// Token: 0x06002C16 RID: 11286 RVA: 0x001375B6 File Offset: 0x001357B6
	private void LBDPGIGNEDC()
	{
		if (null != this.PANMNKKODPC)
		{
			this.PANMNKKODPC.DOFade(334f, 298f);
		}
	}

	// Token: 0x06002C17 RID: 11287 RVA: 0x00136C0A File Offset: 0x00134E0A
	private IEnumerator DINMPABIEFM()
	{
		this.inputField.Select();
		yield return new WaitForSeconds(0.5f);
		this.inputField.ActivateInputField();
		yield break;
	}

	// Token: 0x06002C18 RID: 11288 RVA: 0x00136C02 File Offset: 0x00134E02
	public int HNBNFMHIMGL()
	{
		return this.MLKELKKMBLF;
	}

	// Token: 0x06002C19 RID: 11289 RVA: 0x001375DC File Offset: 0x001357DC
	private void CMIIIEAKFDC()
	{
		this.LBDPGIGNEDC();
		this.textInput.SetText("notgenuine", false);
		this.textInput.text = "UpdateFpsOnOffState";
	}

	// Token: 0x06002C1A RID: 11290 RVA: 0x00137608 File Offset: 0x00135808
	public void NKMPLFNGPEO()
	{
		if (!this.inputField.wasCanceled)
		{
			this.inputField.DeactivateInputField(true);
			AOBJLALDBAA.CEGAOMEEFBE().HPIPBMEMOFK("layervideo", this.textInput.text);
			this.animatedPopupManager.Hide();
			return;
		}
		this.NEGDIBLKKGP();
	}

	// Token: 0x06002C1B RID: 11291 RVA: 0x0013765C File Offset: 0x0013585C
	public void PFONDDPHKLP(int CPKFEMAOOBH)
	{
		this.MLKELKKMBLF = CPKFEMAOOBH;
		base.gameObject.SetActive(false);
		this.BLGBPGMDIIC();
		this.textInput.SetText("gsec", false);
		if (this.MLKELKKMBLF == 0)
		{
			this.textTitle.SetText(CCOJBMMKNAP.BOFMCPPFAMO().HPOAGPJFHPM("SD"), true);
			this.textTitle.text = CCOJBMMKNAP.COKDLDOAACJ().HHLECNIFHCO("noisedigitalovr_1");
		}
		else if (this.MLKELKKMBLF == 0)
		{
			this.textTitle.SetText(CCOJBMMKNAP.ILACPHFEDEP().JCDFHKDNEDH("SocialStatsUserPublicProfile.modified = false, OnFriendsPopupManagerRejectClick()"), false);
			this.textTitle.text = CCOJBMMKNAP.BOFMCPPFAMO().PPALCPINPLK("fdlss");
		}
		else if (this.MLKELKKMBLF == 5)
		{
			this.textTitle.SetText(CCOJBMMKNAP.GIOAFDDKKHI().HDIPNMFHIEJ("YYY"), false);
			this.textTitle.text = CCOJBMMKNAP.NIOJNOFGIJO().FIENAKIHNOM("loungetreasuresyouhave");
		}
		else
		{
			this.textTitle.SetText(CCOJBMMKNAP.MLFAGAAJJEM().HPOAGPJFHPM("XXX"), false);
			this.textTitle.text = CCOJBMMKNAP.PLJMLDOCPNM().IPEIONBNIPH("default");
		}
		base.StartCoroutine(this.CNCKEKIIJKJ());
	}

	// Token: 0x06002C1C RID: 11292 RVA: 0x00136C02 File Offset: 0x00134E02
	public int BFDDONOKKAB()
	{
		return this.MLKELKKMBLF;
	}

	// Token: 0x06002C1D RID: 11293 RVA: 0x00136C0A File Offset: 0x00134E0A
	private IEnumerator POMBPCOBGKP()
	{
		this.inputField.Select();
		yield return new WaitForSeconds(0.5f);
		this.inputField.ActivateInputField();
		yield break;
	}

	// Token: 0x06002C1E RID: 11294 RVA: 0x00003E52 File Offset: 0x00002052
	private void HPGLEEHELDN()
	{
	}

	// Token: 0x06002C1F RID: 11295 RVA: 0x00137798 File Offset: 0x00135998
	public void KMLHOLCDLCI()
	{
		if (!this.inputField.wasCanceled)
		{
			this.inputField.DeactivateInputField(false);
			AOBJLALDBAA.NMGMNAKLLMI().AKILMNPJGGM(" (", this.textInput.text);
			this.animatedPopupManager.OJNDEJNLMFE();
			return;
		}
		this.KIBBJLIFJMN();
	}

	// Token: 0x06002C20 RID: 11296 RVA: 0x001377EA File Offset: 0x001359EA
	private void IKLNMKEIIED()
	{
		if (null != this.PANMNKKODPC)
		{
			this.PANMNKKODPC.DOKill(true);
		}
	}

	// Token: 0x06002C21 RID: 11297 RVA: 0x00137808 File Offset: 0x00135A08
	public void GOJJHALEGOD(int CPKFEMAOOBH)
	{
		this.MLKELKKMBLF = CPKFEMAOOBH;
		base.gameObject.SetActive(true);
		this.HCNIIEFNDPC();
		this.textInput.SetText("tmo", false);
		if (this.MLKELKKMBLF == 0)
		{
			this.textTitle.SetText(CCOJBMMKNAP.KLAKLFCOMJC().FIENAKIHNOM(""), true);
			this.textTitle.text = CCOJBMMKNAP.BFHKGNBFHCH().JLBEIFLLBLO("ias");
		}
		else if (this.MLKELKKMBLF == 0)
		{
			this.textTitle.SetText(CCOJBMMKNAP.NIOJNOFGIJO().JCDFHKDNEDH("themewelcomecustom"), false);
			this.textTitle.text = CCOJBMMKNAP.DLGLFACMHPG().PPALCPINPLK("yes");
		}
		else if (this.MLKELKKMBLF == 8)
		{
			this.textTitle.SetText(CCOJBMMKNAP.CEGAOMEEFBE().OHLNGCKIACD("0"), false);
			this.textTitle.text = CCOJBMMKNAP.DLGLFACMHPG().BGELFMIOBCL("importanttitle");
		}
		else
		{
			this.textTitle.SetText(CCOJBMMKNAP.PMABBOJDELF().HHLECNIFHCO("OnNeedToDeactivateFocusItemCloseButton"), false);
			this.textTitle.text = CCOJBMMKNAP.JMDJPKKOHNI().FIENAKIHNOM("StoryNotificationsManager.PostponeNotification(): ");
		}
		base.StartCoroutine(this.FKNBIFEDFJC());
	}

	// Token: 0x06002C22 RID: 11298 RVA: 0x00137943 File Offset: 0x00135B43
	private void FPGEBMIFOPK()
	{
		this.MGIELDOCOPG();
		this.textInput.SetText("+", false);
		this.textInput.text = "mypsuspendedbody";
	}

	// Token: 0x06002C23 RID: 11299 RVA: 0x0013796C File Offset: 0x00135B6C
	private void MAHJANFJIMG()
	{
		if (null != this.PANMNKKODPC)
		{
			this.PANMNKKODPC.DOKill(false);
		}
	}

	// Token: 0x06002C24 RID: 11300 RVA: 0x0013798C File Offset: 0x00135B8C
	public void IFEBHNOEPMM()
	{
		if (!this.inputField.wasCanceled)
		{
			this.inputField.DeactivateInputField(true);
			AOBJLALDBAA.BIAEAOMHBMM().HPIPBMEMOFK(" ", this.textInput.text);
			this.animatedPopupManager.NBDMOONDIHO();
			return;
		}
		this.NEGDIBLKKGP();
	}

	// Token: 0x06002C25 RID: 11301 RVA: 0x001379E0 File Offset: 0x00135BE0
	public void ODPHJGEDKAA()
	{
		if (!this.inputField.wasCanceled)
		{
			this.inputField.DeactivateInputField(false);
			AOBJLALDBAA.DBLAIDPICIG().BDEMEIKEJHF(") + is present, creating anthology save for anthology ", this.textInput.text);
			this.animatedPopupManager.KCAPIILJKDN();
			return;
		}
		this.MLIKEHIHCNM();
	}

	// Token: 0x06002C26 RID: 11302 RVA: 0x00137A32 File Offset: 0x00135C32
	public void DisappearAnimation()
	{
		if (null != this.PANMNKKODPC)
		{
			this.PANMNKKODPC.DOFade(0f, 0.5f);
		}
	}

	// Token: 0x06002C27 RID: 11303 RVA: 0x0013796C File Offset: 0x00135B6C
	private void LOCANABKJEE()
	{
		if (null != this.PANMNKKODPC)
		{
			this.PANMNKKODPC.DOKill(false);
		}
	}

	// Token: 0x06002C28 RID: 11304 RVA: 0x00003E52 File Offset: 0x00002052
	private void EIHOIEGKJLA()
	{
	}

	// Token: 0x06002C29 RID: 11305 RVA: 0x00137A58 File Offset: 0x00135C58
	private void JDMOENJPHOE()
	{
		this.PANMNKKODPC = base.gameObject.GetComponent<CanvasGroup>();
		if (null != this.PANMNKKODPC)
		{
			this.PANMNKKODPC.alpha = 563f;
		}
	}

	// Token: 0x06002C2A RID: 11306 RVA: 0x00137A8C File Offset: 0x00135C8C
	public void DFPLEDLEPKO(int CPKFEMAOOBH)
	{
		this.MLKELKKMBLF = CPKFEMAOOBH;
		base.gameObject.SetActive(true);
		this.INLMEILMIBD();
		this.textInput.SetText("sprite", false);
		if (this.MLKELKKMBLF == 0)
		{
			this.textTitle.SetText(CCOJBMMKNAP.PEBMGCKFNAO().BGELFMIOBCL(""), true);
			this.textTitle.text = CCOJBMMKNAP.HFAKOKBHCGH().HDIPNMFHIEJ("<b>");
		}
		else if (this.MLKELKKMBLF == 1)
		{
			this.textTitle.SetText(CCOJBMMKNAP.EHBBFMCILPC.OHLNGCKIACD("Asset pack has been LOADED according to on demand resources data:"), false);
			this.textTitle.text = CCOJBMMKNAP.PLJMLDOCPNM().HHLECNIFHCO("OnStoryAdsProviderAdSuccess");
		}
		else if (this.MLKELKKMBLF == 3)
		{
			this.textTitle.SetText(CCOJBMMKNAP.BIAEAOMHBMM().OBDCPLLLGBB("."), false);
			this.textTitle.text = CCOJBMMKNAP.JMDJPKKOHNI().FCOCLEHKLDJ("[LoadingEnv] ");
		}
		else
		{
			this.textTitle.SetText(CCOJBMMKNAP.ILACPHFEDEP().OBDCPLLLGBB("ablpt"), true);
			this.textTitle.text = CCOJBMMKNAP.PKEINLPIAEH().HDIPNMFHIEJ(";");
		}
		base.StartCoroutine(this.JJHEPHBLEGG());
	}

	// Token: 0x06002C2B RID: 11307 RVA: 0x00137BC7 File Offset: 0x00135DC7
	public void IKNFIKJFANA()
	{
		this.inputField.DeactivateInputField(true);
		AOBJLALDBAA.KKPFOJMAONG().FDKBIBKABCM("black", 933f);
		this.animatedPopupManager.HFFJACPIHKE();
	}

	// Token: 0x06002C2C RID: 11308 RVA: 0x00136C0A File Offset: 0x00134E0A
	private IEnumerator FKNBIFEDFJC()
	{
		this.inputField.Select();
		yield return new WaitForSeconds(0.5f);
		this.inputField.ActivateInputField();
		yield break;
	}

	// Token: 0x06002C2D RID: 11309 RVA: 0x00136C0A File Offset: 0x00134E0A
	private IEnumerator JJHEPHBLEGG()
	{
		this.inputField.Select();
		yield return new WaitForSeconds(0.5f);
		this.inputField.ActivateInputField();
		yield break;
	}

	// Token: 0x06002C2E RID: 11310 RVA: 0x00137BF4 File Offset: 0x00135DF4
	private void GFOCPBFLJFC()
	{
		this.PANMNKKODPC = base.gameObject.GetComponent<CanvasGroup>();
		if (null != this.PANMNKKODPC)
		{
			this.PANMNKKODPC.alpha = 1732f;
		}
	}

	// Token: 0x06002C2F RID: 11311 RVA: 0x00137C25 File Offset: 0x00135E25
	public void EHEINHBNACI()
	{
		this.inputField.DeactivateInputField(true);
		AOBJLALDBAA.CEGAOMEEFBE().EFBNBFIDEOK("acli21", 1865f);
		this.animatedPopupManager.DDPHFKOHDJB();
	}

	// Token: 0x06002C30 RID: 11312 RVA: 0x00136C02 File Offset: 0x00134E02
	public int DAABEGNCKOM()
	{
		return this.MLKELKKMBLF;
	}

	// Token: 0x06002C31 RID: 11313 RVA: 0x00137C54 File Offset: 0x00135E54
	public void JMIIKJLHPJM()
	{
		if (!this.inputField.wasCanceled)
		{
			this.inputField.DeactivateInputField(true);
			AOBJLALDBAA.EHBBFMCILPC.IDEALDBPGJE("OnAccountSignInRequestException", this.textInput.text);
			this.animatedPopupManager.NBDMOONDIHO();
			return;
		}
		this.OnCloseClick();
	}

	// Token: 0x06002C32 RID: 11314 RVA: 0x00137CA8 File Offset: 0x00135EA8
	public void JJKNIJCJKKF(int CPKFEMAOOBH)
	{
		this.MLKELKKMBLF = CPKFEMAOOBH;
		base.gameObject.SetActive(true);
		this.HCNIIEFNDPC();
		this.textInput.SetText("Asset bundle load operation failed during parallel mode.", false);
		if (this.MLKELKKMBLF == 0)
		{
			this.textTitle.SetText(CCOJBMMKNAP.ONCPHEEJLOP().GLEFEKBDHNK("errortitle"), false);
			this.textTitle.text = CCOJBMMKNAP.PMABBOJDELF().HHLECNIFHCO("Asset bundle assets destroyed:");
		}
		else if (this.MLKELKKMBLF == 1)
		{
			this.textTitle.SetText(CCOJBMMKNAP.OBOOKJPGBJN().DNILNCLIHAP("saveslotsdeletepos"), false);
			this.textTitle.text = CCOJBMMKNAP.KNKGCDDMLDP().JHNELLJFBGC("importanttitle");
		}
		else if (this.MLKELKKMBLF == 2)
		{
			this.textTitle.SetText(CCOJBMMKNAP.BIAEAOMHBMM().DNILNCLIHAP("*"), true);
			this.textTitle.text = CCOJBMMKNAP.INKJIBDDMLL().MEPECBDCOLG("errortitle");
		}
		else
		{
			this.textTitle.SetText(CCOJBMMKNAP.CEGAOMEEFBE().OHLNGCKIACD(" "), true);
			this.textTitle.text = CCOJBMMKNAP.BFHKGNBFHCH().JHNELLJFBGC("OnSettingsPopupCloseAndNeedToShowGameModeNotif");
		}
		base.StartCoroutine(this.IEDILHDCBMA());
	}

	// Token: 0x06002C33 RID: 11315 RVA: 0x00136C02 File Offset: 0x00134E02
	public int MJJGLGBKCJN()
	{
		return this.MLKELKKMBLF;
	}

	// Token: 0x06002C34 RID: 11316 RVA: 0x00137DE3 File Offset: 0x00135FE3
	private void OnEnable()
	{
		this.HDKFBJIMKBK();
		this.textInput.SetText("", true);
		this.textInput.text = "";
	}

	// Token: 0x06002C35 RID: 11317 RVA: 0x00003E52 File Offset: 0x00002052
	private void BDMGHFPMOAG()
	{
	}

	// Token: 0x06002C36 RID: 11318 RVA: 0x00136C0A File Offset: 0x00134E0A
	private IEnumerator CNCKEKIIJKJ()
	{
		this.inputField.Select();
		yield return new WaitForSeconds(0.5f);
		this.inputField.ActivateInputField();
		yield break;
	}

	// Token: 0x06002C37 RID: 11319 RVA: 0x00137E0C File Offset: 0x0013600C
	public void IEDNDIONFCM(int CPKFEMAOOBH)
	{
		this.MLKELKKMBLF = CPKFEMAOOBH;
		base.gameObject.SetActive(true);
		this.LBDPGIGNEDC();
		this.textInput.SetText("acomp", true);
		if (this.MLKELKKMBLF == 0)
		{
			this.textTitle.SetText(CCOJBMMKNAP.COKDLDOAACJ().HHLECNIFHCO("comingsoontitle3"), false);
			this.textTitle.text = CCOJBMMKNAP.OEPENBHJAHO().BDGPNPNIAPA("starterpattern");
		}
		else if (this.MLKELKKMBLF == 0)
		{
			this.textTitle.SetText(CCOJBMMKNAP.LMCCLMFGEBD().FCOCLEHKLDJ("flehv2"), false);
			this.textTitle.text = CCOJBMMKNAP.KNKGCDDMLDP().HPOAGPJFHPM("ok");
		}
		else if (this.MLKELKKMBLF == 3)
		{
			this.textTitle.SetText(CCOJBMMKNAP.AEELGGPEJCC().HDIPNMFHIEJ("abpd3"), true);
			this.textTitle.text = CCOJBMMKNAP.HJGDLOOHNLO().HDIPNMFHIEJ("0");
		}
		else
		{
			this.textTitle.SetText(CCOJBMMKNAP.PLJMLDOCPNM().JHNELLJFBGC("serversync"), true);
			this.textTitle.text = CCOJBMMKNAP.KMNBCEMEBBD().MEPECBDCOLG("(");
		}
		base.StartCoroutine(this.CHGPOACKOOB());
	}

	// Token: 0x06002C38 RID: 11320 RVA: 0x00137F47 File Offset: 0x00136147
	public void OnCloseClick()
	{
		this.inputField.DeactivateInputField(false);
		AOBJLALDBAA.EHBBFMCILPC.EGELHPJBAIC("OnPopupProfileUIDInputCancel", 0f);
		this.animatedPopupManager.Hide();
	}

	// Token: 0x06002C39 RID: 11321 RVA: 0x00137F74 File Offset: 0x00136174
	private void EGOLCKBOOJF()
	{
		if (null != this.PANMNKKODPC)
		{
			this.PANMNKKODPC.DOFade(326f, 217f);
		}
	}

	// Token: 0x06002C3A RID: 11322 RVA: 0x00136C02 File Offset: 0x00134E02
	public int NBNGMCHIBLK()
	{
		return this.MLKELKKMBLF;
	}

	// Token: 0x06002C3B RID: 11323 RVA: 0x00136C02 File Offset: 0x00134E02
	public int HKMOKBNLBOK()
	{
		return this.MLKELKKMBLF;
	}

	// Token: 0x06002C3C RID: 11324 RVA: 0x00137F9A File Offset: 0x0013619A
	private void HFKMDGNDCGD()
	{
		if (null != this.PANMNKKODPC)
		{
			this.PANMNKKODPC.DOFade(1862f, 815f);
		}
	}

	// Token: 0x06002C3D RID: 11325 RVA: 0x00137FC0 File Offset: 0x001361C0
	public void IJBPHHNOFFF()
	{
		if (!this.inputField.wasCanceled)
		{
			this.inputField.DeactivateInputField(true);
			AOBJLALDBAA.DBLAIDPICIG().PMDEKGAFCCL("a=ÀÁÂÃÄÅĀĂĄàáâãäåāăą;c=ÇĆĈĊČçćĉċč;d=ĎĐďđ;e=ÈÉÊËĒĔĖĘĚèéêëēĕėęě;g=ĜĞĠĢĝğġģ;h=ĤĦĥħ;i=ÌÍÎÏĨĪĬĮİìíîïĩīĭįı;j=Ĵĵ;k=Ķķ;l=ĹĻĽĿŁĺļľŀł;n=ÑŃŅŇñńņň;o=ÒÓÔÕÖØŌŎŐòóôõöøōŏő;r=ŔŖŘŕŗř;s=ŚŜŞŠȘśŝşšș;t=ŢŤŦȚţťŧț;u=ÙÚÛÜŨŪŬŮŰŲùúûüũūŭůűų;w=Ŵŵ;y=ÝŶŸýÿŷ;z=ŹŻŽźżž;ss=ß;ae=ÆæǢǣ;oe=Œœ;th=Þþ;ij=Ĳĳ;е=Ёё;и=ІіЇї;е=Єє;г=Ґґ;psi=Ψψ", this.textInput.text);
			this.animatedPopupManager.DDPHFKOHDJB();
			return;
		}
		this.GMGJDDFDIAD();
	}

	// Token: 0x06002C3E RID: 11326 RVA: 0x00138012 File Offset: 0x00136212
	public void FDFPCOIJFBC()
	{
		this.inputField.DeactivateInputField(false);
		AOBJLALDBAA.KKPFOJMAONG().CIGLHCJDDPI("PurchaseManagerXiaomi.OnBridgeInitialized(): failed code=", 491f);
		this.animatedPopupManager.HFFJACPIHKE();
	}

	// Token: 0x06002C3F RID: 11327 RVA: 0x00138040 File Offset: 0x00136240
	public void OnEndEdit()
	{
		if (!this.inputField.wasCanceled)
		{
			this.inputField.DeactivateInputField(false);
			AOBJLALDBAA.EHBBFMCILPC.EGELHPJBAIC("OnPopupProfileUIDInputEndEdit", this.textInput.text);
			this.animatedPopupManager.Hide();
			return;
		}
		this.OnCloseClick();
	}

	// Token: 0x06002C40 RID: 11328 RVA: 0x001377EA File Offset: 0x001359EA
	private void JOLAMLIFMMB()
	{
		if (null != this.PANMNKKODPC)
		{
			this.PANMNKKODPC.DOKill(true);
		}
	}

	// Token: 0x06002C41 RID: 11329 RVA: 0x00138094 File Offset: 0x00136294
	public void OOIAGHBAFIC(int CPKFEMAOOBH)
	{
		this.MLKELKKMBLF = CPKFEMAOOBH;
		base.gameObject.SetActive(false);
		this.LBDPGIGNEDC();
		this.textInput.SetText("anthology", false);
		if (this.MLKELKKMBLF == 0)
		{
			this.textTitle.SetText(CCOJBMMKNAP.PEBMGCKFNAO().FCOCLEHKLDJ("uid"), true);
			this.textTitle.text = CCOJBMMKNAP.OEPENBHJAHO().HPOAGPJFHPM("app42error");
		}
		else if (this.MLKELKKMBLF == 0)
		{
			this.textTitle.SetText(CCOJBMMKNAP.PMABBOJDELF().DNILNCLIHAP(")"), false);
			this.textTitle.text = CCOJBMMKNAP.BOFMCPPFAMO().JHNELLJFBGC("anthology");
		}
		else if (this.MLKELKKMBLF == 2)
		{
			this.textTitle.SetText(CCOJBMMKNAP.EAIAHCBAIEJ().BDGPNPNIAPA(""), false);
			this.textTitle.text = CCOJBMMKNAP.LMCCLMFGEBD().GLEFEKBDHNK("apks1");
		}
		else
		{
			this.textTitle.SetText(CCOJBMMKNAP.DLGLFACMHPG().HPOAGPJFHPM("́ ̀"), true);
			this.textTitle.text = CCOJBMMKNAP.JINDKPHNLBK().DNILNCLIHAP("tradewishcardoption0");
		}
		base.StartCoroutine(this.IEDILHDCBMA());
	}

	// Token: 0x06002C42 RID: 11330 RVA: 0x001381D0 File Offset: 0x001363D0
	public void JFLEHGOPNIA(int CPKFEMAOOBH)
	{
		this.MLKELKKMBLF = CPKFEMAOOBH;
		base.gameObject.SetActive(true);
		this.HCNIIEFNDPC();
		this.textInput.SetText("OnSpinsUnlockContinueToPurchasingScreen", true);
		if (this.MLKELKKMBLF == 0)
		{
			this.textTitle.SetText(CCOJBMMKNAP.APGODIBBPOD().DNILNCLIHAP(""), false);
			this.textTitle.text = CCOJBMMKNAP.NIOJNOFGIJO().JHNELLJFBGC("socialfriendmatchtitle");
		}
		else if (this.MLKELKKMBLF == 0)
		{
			this.textTitle.SetText(CCOJBMMKNAP.COKDLDOAACJ().IKMNGFIDCLM("$nl"), false);
			this.textTitle.text = CCOJBMMKNAP.INKJIBDDMLL().OGKGHLHHAAI("uid");
		}
		else if (this.MLKELKKMBLF == 4)
		{
			this.textTitle.SetText(CCOJBMMKNAP.JMDJPKKOHNI().MEPECBDCOLG("ERROR: GetAvatarComponentAssetGivenAlias(), could not find asset with alias:"), true);
			this.textTitle.text = CCOJBMMKNAP.INKJIBDDMLL().HHLECNIFHCO("newFilter");
		}
		else
		{
			this.textTitle.SetText(CCOJBMMKNAP.HEDIEIICOOG().PPALCPINPLK("storyAssetPackManager[i].environmentsFrontList[j] is null!"), false);
			this.textTitle.text = CCOJBMMKNAP.HEDIEIICOOG().JHNELLJFBGC("PurchaseManagerUnity.StartPurchase(): Start purchase ");
		}
		base.StartCoroutine(this.CJAHEBHPJDB());
	}

	// Token: 0x06002C43 RID: 11331 RVA: 0x0013830C File Offset: 0x0013650C
	public void Show(int CPKFEMAOOBH)
	{
		this.MLKELKKMBLF = CPKFEMAOOBH;
		base.gameObject.SetActive(true);
		this.HDKFBJIMKBK();
		this.textInput.SetText("", true);
		if (this.MLKELKKMBLF == 0)
		{
			this.textTitle.SetText(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("socialrequestsearchuid"), true);
			this.textTitle.text = CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("socialrequestsearchuid");
		}
		else if (this.MLKELKKMBLF == 1)
		{
			this.textTitle.SetText(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("sendcardbyuserid"), true);
			this.textTitle.text = CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("sendcardbyuserid");
		}
		else if (this.MLKELKKMBLF == 2)
		{
			this.textTitle.SetText(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("socialrequestsearchnick"), true);
			this.textTitle.text = CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("socialrequestsearchnick");
		}
		else
		{
			this.textTitle.SetText(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("sendcardbynick"), true);
			this.textTitle.text = CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("sendcardbynick");
		}
		base.StartCoroutine(this.CJAHEBHPJDB());
	}

	// Token: 0x06002C44 RID: 11332 RVA: 0x00003E52 File Offset: 0x00002052
	private void HPDHFIHPKGP()
	{
	}

	// Token: 0x06002C45 RID: 11333 RVA: 0x00137319 File Offset: 0x00135519
	private IEnumerator CHGPOACKOOB()
	{
		PopupProfileUIDInput.BLLLGMMKCIG blllgmmkcig = new PopupProfileUIDInput.BLLLGMMKCIG(1);
		blllgmmkcig.<>4__this = this;
		return blllgmmkcig;
	}

	// Token: 0x06002C46 RID: 11334 RVA: 0x00138447 File Offset: 0x00136647
	public void DFNONIBBCHK()
	{
		if (null != this.PANMNKKODPC)
		{
			this.PANMNKKODPC.DOFade(655f, 1175f);
		}
	}

	// Token: 0x06002C47 RID: 11335 RVA: 0x00137319 File Offset: 0x00135519
	private IEnumerator LHBIEODJFGP()
	{
		PopupProfileUIDInput.BLLLGMMKCIG blllgmmkcig = new PopupProfileUIDInput.BLLLGMMKCIG(1);
		blllgmmkcig.<>4__this = this;
		return blllgmmkcig;
	}

	// Token: 0x06002C48 RID: 11336 RVA: 0x0013846D File Offset: 0x0013666D
	public void JJKHJFBPIFC()
	{
		if (null != this.PANMNKKODPC)
		{
			this.PANMNKKODPC.DOFade(549f, 1592f);
		}
	}

	// Token: 0x06002C49 RID: 11337 RVA: 0x00138494 File Offset: 0x00136694
	public void JDFKIJIJCIG()
	{
		if (!this.inputField.wasCanceled)
		{
			this.inputField.DeactivateInputField(false);
			AOBJLALDBAA.DBLAIDPICIG().EGELHPJBAIC("large", this.textInput.text);
			this.animatedPopupManager.GFEHJHIDHFF();
			return;
		}
		this.LAEGEMDLBED();
	}

	// Token: 0x06002C4A RID: 11338 RVA: 0x001384E6 File Offset: 0x001366E6
	private void BOILGHBPIIN()
	{
		this.PANMNKKODPC = base.gameObject.GetComponent<CanvasGroup>();
		if (null != this.PANMNKKODPC)
		{
			this.PANMNKKODPC.alpha = 1449f;
		}
	}

	// Token: 0x06002C4B RID: 11339 RVA: 0x00136C02 File Offset: 0x00134E02
	public int MJMJIABBKGB()
	{
		return this.MLKELKKMBLF;
	}

	// Token: 0x06002C4C RID: 11340 RVA: 0x00138517 File Offset: 0x00136717
	public void KIBBJLIFJMN()
	{
		this.inputField.DeactivateInputField(false);
		AOBJLALDBAA.DBLAIDPICIG().KMAGHMCCMPG("_not_found", 760f);
		this.animatedPopupManager.GFEHJHIDHFF();
	}

	// Token: 0x06002C4D RID: 11341 RVA: 0x00136C02 File Offset: 0x00134E02
	public int OGFAELPEJLL()
	{
		return this.MLKELKKMBLF;
	}

	// Token: 0x06002C4E RID: 11342 RVA: 0x00138544 File Offset: 0x00136744
	private void Awake()
	{
		this.PANMNKKODPC = base.gameObject.GetComponent<CanvasGroup>();
		if (null != this.PANMNKKODPC)
		{
			this.PANMNKKODPC.alpha = 0f;
		}
	}

	// Token: 0x06002C4F RID: 11343 RVA: 0x00136C02 File Offset: 0x00134E02
	public int BAOIACGBAAJ()
	{
		return this.MLKELKKMBLF;
	}

	// Token: 0x06002C50 RID: 11344 RVA: 0x00138575 File Offset: 0x00136775
	private void GNHDCIGPFOH()
	{
		this.PANMNKKODPC = base.gameObject.GetComponent<CanvasGroup>();
		if (null != this.PANMNKKODPC)
		{
			this.PANMNKKODPC.alpha = 1328f;
		}
	}

	// Token: 0x06002C51 RID: 11345 RVA: 0x00136C0A File Offset: 0x00134E0A
	private IEnumerator FNGFPLLILNG()
	{
		this.inputField.Select();
		yield return new WaitForSeconds(0.5f);
		this.inputField.ActivateInputField();
		yield break;
	}

	// Token: 0x06002C52 RID: 11346 RVA: 0x00003E52 File Offset: 0x00002052
	private void KGMBFKBNDPJ()
	{
	}

	// Token: 0x06002C53 RID: 11347 RVA: 0x001385A6 File Offset: 0x001367A6
	public void NBKCEENLCON()
	{
		if (null != this.PANMNKKODPC)
		{
			this.PANMNKKODPC.DOFade(210f, 591f);
		}
	}

	// Token: 0x06002C54 RID: 11348 RVA: 0x0013796C File Offset: 0x00135B6C
	private void MGOMPPDOPOA()
	{
		if (null != this.PANMNKKODPC)
		{
			this.PANMNKKODPC.DOKill(false);
		}
	}

	// Token: 0x06002C55 RID: 11349 RVA: 0x00003E52 File Offset: 0x00002052
	private void ODOOIGEDLKB()
	{
	}

	// Token: 0x06002C56 RID: 11350 RVA: 0x001385CC File Offset: 0x001367CC
	public void HHDEHGIAJOK()
	{
		if (!this.inputField.wasCanceled)
		{
			this.inputField.DeactivateInputField(true);
			AOBJLALDBAA.DBLAIDPICIG().PMDEKGAFCCL("ach", this.textInput.text);
			this.animatedPopupManager.ADAJPNHIICL();
			return;
		}
		this.IKNFIKJFANA();
	}

	// Token: 0x06002C57 RID: 11351 RVA: 0x00003E52 File Offset: 0x00002052
	private void KGKHCNJOFKN()
	{
	}

	// Token: 0x06002C58 RID: 11352 RVA: 0x0013861E File Offset: 0x0013681E
	private void EHECBKECKPA()
	{
		this.PANMNKKODPC = base.gameObject.GetComponent<CanvasGroup>();
		if (null != this.PANMNKKODPC)
		{
			this.PANMNKKODPC.alpha = 1695f;
		}
	}

	// Token: 0x06002C59 RID: 11353 RVA: 0x00138650 File Offset: 0x00136850
	public void GKIHNIOMHON()
	{
		if (!this.inputField.wasCanceled)
		{
			this.inputField.DeactivateInputField(true);
			AOBJLALDBAA.FILDBDMENPG().PAODLAFIKBG("discount", this.textInput.text);
			this.animatedPopupManager.HFFJACPIHKE();
			return;
		}
		this.KJGACBPKMPK();
	}

	// Token: 0x06002C5A RID: 11354 RVA: 0x001386A2 File Offset: 0x001368A2
	public void LAEGEMDLBED()
	{
		this.inputField.DeactivateInputField(true);
		AOBJLALDBAA.AGANFKKBPFO().EGELHPJBAIC("' dropped", 394f);
		this.animatedPopupManager.DDPHFKOHDJB();
	}

	// Token: 0x06002C5B RID: 11355 RVA: 0x001386CF File Offset: 0x001368CF
	private void MOJFEKNDCMJ()
	{
		if (null != this.PANMNKKODPC)
		{
			this.PANMNKKODPC.DOFade(286f, 1937f);
		}
	}

	// Token: 0x06002C5C RID: 11356 RVA: 0x001386F5 File Offset: 0x001368F5
	private void KHPGMEMIJMB()
	{
		this.INLMEILMIBD();
		this.textInput.SetText("ias", true);
		this.textInput.text = "ok";
	}

	// Token: 0x06002C5D RID: 11357 RVA: 0x0013871E File Offset: 0x0013691E
	private void HCNIIEFNDPC()
	{
		if (null != this.PANMNKKODPC)
		{
			this.PANMNKKODPC.DOFade(1130f, 1863f);
		}
	}

	// Token: 0x06002C5E RID: 11358 RVA: 0x00136C0A File Offset: 0x00134E0A
	private IEnumerator EHLBNMAEAHC()
	{
		this.inputField.Select();
		yield return new WaitForSeconds(0.5f);
		this.inputField.ActivateInputField();
		yield break;
	}

	// Token: 0x06002C5F RID: 11359 RVA: 0x00003E52 File Offset: 0x00002052
	private void BIGNLMDFEFO()
	{
	}

	// Token: 0x06002C60 RID: 11360 RVA: 0x00138744 File Offset: 0x00136944
	private void AKIFACAINPL()
	{
		this.BLGBPGMDIIC();
		this.textInput.SetText("lititle", true);
		this.textInput.text = "</i>";
	}

	// Token: 0x06002C61 RID: 11361 RVA: 0x0013876D File Offset: 0x0013696D
	public void KPPCHKABMOM()
	{
		if (null != this.PANMNKKODPC)
		{
			this.PANMNKKODPC.DOFade(1370f, 1529f);
		}
	}

	// Token: 0x06002C62 RID: 11362 RVA: 0x00138794 File Offset: 0x00136994
	public void JJKJGBJHABC()
	{
		if (!this.inputField.wasCanceled)
		{
			this.inputField.DeactivateInputField(true);
			AOBJLALDBAA.KKPFOJMAONG().FIJKIAKDCNO("Opened from Gley Notification", this.textInput.text);
			this.animatedPopupManager.HFFJACPIHKE();
			return;
		}
		this.LAEGEMDLBED();
	}

	// Token: 0x06002C63 RID: 11363 RVA: 0x00137319 File Offset: 0x00135519
	private IEnumerator JDPGLHLLIHP()
	{
		PopupProfileUIDInput.BLLLGMMKCIG blllgmmkcig = new PopupProfileUIDInput.BLLLGMMKCIG(1);
		blllgmmkcig.<>4__this = this;
		return blllgmmkcig;
	}

	// Token: 0x06002C64 RID: 11364 RVA: 0x001387E8 File Offset: 0x001369E8
	public void AAFAFPLOKAD()
	{
		if (!this.inputField.wasCanceled)
		{
			this.inputField.DeactivateInputField(true);
			AOBJLALDBAA.NMGMNAKLLMI().PAODLAFIKBG("RequestGetUserPublicProfile(): timer hit: ", this.textInput.text);
			this.animatedPopupManager.Hide();
			return;
		}
		this.KJGACBPKMPK();
	}

	// Token: 0x06002C66 RID: 11366 RVA: 0x0013796C File Offset: 0x00135B6C
	private void OnDestroy()
	{
		if (null != this.PANMNKKODPC)
		{
			this.PANMNKKODPC.DOKill(false);
		}
	}

	// Token: 0x06002C67 RID: 11367 RVA: 0x0013883C File Offset: 0x00136A3C
	public void MLANIKPFIMA(int CPKFEMAOOBH)
	{
		this.MLKELKKMBLF = CPKFEMAOOBH;
		base.gameObject.SetActive(false);
		this.HCNIIEFNDPC();
		this.textInput.SetText("lsvn", true);
		if (this.MLKELKKMBLF == 0)
		{
			this.textTitle.SetText(CCOJBMMKNAP.KLAKLFCOMJC().BDGPNPNIAPA("ok"), true);
			this.textTitle.text = CCOJBMMKNAP.MPCBJEIMACA().HHLECNIFHCO("OnStoryChoiceClick");
		}
		else if (this.MLKELKKMBLF == 0)
		{
			this.textTitle.SetText(CCOJBMMKNAP.KLAKLFCOMJC().HHLECNIFHCO("OnStoryInterfaceFastForwardStop"), true);
			this.textTitle.text = CCOJBMMKNAP.HJGDLOOHNLO().PKNHKGMNCIP("featureCount");
		}
		else if (this.MLKELKKMBLF == 2)
		{
			this.textTitle.SetText(CCOJBMMKNAP.EAIAHCBAIEJ().MEPECBDCOLG("$SHOWLOGO"), true);
			this.textTitle.text = CCOJBMMKNAP.MLFAGAAJJEM().IPEIONBNIPH("app42error");
		}
		else
		{
			this.textTitle.SetText(CCOJBMMKNAP.JMDJPKKOHNI().IKMNGFIDCLM("<space=0.0625em>"), true);
			this.textTitle.text = CCOJBMMKNAP.INKJIBDDMLL().FCOCLEHKLDJ("");
		}
		base.StartCoroutine(this.GOCCKEGOKGN());
	}

	// Token: 0x06002C68 RID: 11368 RVA: 0x00136C02 File Offset: 0x00134E02
	public int OAJALFHFKBH()
	{
		return this.MLKELKKMBLF;
	}

	// Token: 0x06002C69 RID: 11369 RVA: 0x00138977 File Offset: 0x00136B77
	public void EOLOBEKDIDE()
	{
		if (null != this.PANMNKKODPC)
		{
			this.PANMNKKODPC.DOFade(545f, 1884f);
		}
	}

	// Token: 0x06002C6A RID: 11370 RVA: 0x00136C0A File Offset: 0x00134E0A
	private IEnumerator CJAHEBHPJDB()
	{
		this.inputField.Select();
		yield return new WaitForSeconds(0.5f);
		this.inputField.ActivateInputField();
		yield break;
	}

	// Token: 0x06002C6B RID: 11371 RVA: 0x001389A0 File Offset: 0x00136BA0
	public void NOLOJJALGCD(int CPKFEMAOOBH)
	{
		this.MLKELKKMBLF = CPKFEMAOOBH;
		base.gameObject.SetActive(false);
		this.MOJFEKNDCMJ();
		this.textInput.SetText("%", false);
		if (this.MLKELKKMBLF == 0)
		{
			this.textTitle.SetText(CCOJBMMKNAP.KFAABHHGOPO().DNILNCLIHAP("\\n"), false);
			this.textTitle.text = CCOJBMMKNAP.BIAEAOMHBMM().HIPJILDCHJC("bits");
		}
		else if (this.MLKELKKMBLF == 1)
		{
			this.textTitle.SetText(CCOJBMMKNAP.EAIAHCBAIEJ().HHLECNIFHCO("OnBackendRequestShareHardSuccess"), false);
			this.textTitle.text = CCOJBMMKNAP.DLGLFACMHPG().IPEIONBNIPH("oid");
		}
		else if (this.MLKELKKMBLF == 1)
		{
			this.textTitle.SetText(CCOJBMMKNAP.FEEDGKCJBLE().IPEIONBNIPH("aind"), true);
			this.textTitle.text = CCOJBMMKNAP.MLFAGAAJJEM().HHLECNIFHCO("errortitle");
		}
		else
		{
			this.textTitle.SetText(CCOJBMMKNAP.KLAKLFCOMJC().HDIPNMFHIEJ("sim"), false);
			this.textTitle.text = CCOJBMMKNAP.MPCBJEIMACA().JLBEIFLLBLO("errortitle");
		}
		base.StartCoroutine(this.JJHEPHBLEGG());
	}

	// Token: 0x06002C6C RID: 11372 RVA: 0x00003E52 File Offset: 0x00002052
	private void BLAIJHABAKI()
	{
	}

	// Token: 0x06002C6D RID: 11373 RVA: 0x00138ADB File Offset: 0x00136CDB
	private void BLGBPGMDIIC()
	{
		if (null != this.PANMNKKODPC)
		{
			this.PANMNKKODPC.DOFade(940f, 854f);
		}
	}

	// Token: 0x04000D10 RID: 3344
	public const string onPopupProfileUIDInputEndEdit = "OnPopupProfileUIDInputEndEdit";

	// Token: 0x04000D11 RID: 3345
	public const string onPopupProfileUIDInputCancel = "OnPopupProfileUIDInputCancel";

	// Token: 0x04000D12 RID: 3346
	public const float fadeInTime = 0.5f;

	// Token: 0x04000D13 RID: 3347
	public const float fadeOutTime = 0.5f;

	// Token: 0x04000D14 RID: 3348
	public TextMeshProUGUI textTitle;

	// Token: 0x04000D15 RID: 3349
	public TextMeshProUGUI textInput;

	// Token: 0x04000D16 RID: 3350
	public TMP_InputField inputField;

	// Token: 0x04000D17 RID: 3351
	public AnimatedPopupManager animatedPopupManager;

	// Token: 0x04000D18 RID: 3352
	private CanvasGroup PANMNKKODPC;

	// Token: 0x04000D19 RID: 3353
	private int MLKELKKMBLF;
}
