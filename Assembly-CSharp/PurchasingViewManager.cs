using System;
using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Purchasing;
using UnityEngine.UI;

// Token: 0x020001D5 RID: 469
public class PurchasingViewManager : MonoBehaviour
{
	// Token: 0x06003ADC RID: 15068 RVA: 0x001861D2 File Offset: 0x001843D2
	public void OnSettingsClick()
	{
		if (FacebookManager.EHBBFMCILPC.IsFacebookManagerInitialized())
		{
			CommonUserInterface.EHBBFMCILPC.ShowSettings(true, false, true);
			return;
		}
		base.StartCoroutine(this.DEMIIEHPNIH());
	}

	// Token: 0x06003ADD RID: 15069 RVA: 0x001861FB File Offset: 0x001843FB
	private void JPDHKJCINAF()
	{
		this.NHBPLAFBNIG();
	}

	// Token: 0x06003ADE RID: 15070 RVA: 0x00186203 File Offset: 0x00184403
	private IEnumerator BFKDDGMMMFB(string IHCGMFBCMOO)
	{
		yield return new WaitForSeconds(1f);
		if (IHCGMFBCMOO.Length == 0)
		{
			this.EOGJFGAFCEJ(MPFLJGHNIKB.AutomatedCheck, "");
		}
		else
		{
			this.EOGJFGAFCEJ(MPFLJGHNIKB.PurchaseIntent, IHCGMFBCMOO);
		}
		yield break;
	}

	// Token: 0x06003ADF RID: 15071 RVA: 0x0018621C File Offset: 0x0018441C
	private void PCNOGJNDPDK()
	{
		CommonUserInterface.EHBBFMCILPC.MCJIGJMFBMI();
		CommonUserInterface.EHBBFMCILPC.ShowGenericPopup(CCOJBMMKNAP.FEEDGKCJBLE().JHNELLJFBGC(" "), CCOJBMMKNAP.JMDJPKKOHNI().GLEFEKBDHNK("SocialStatsUserPublicProfile.modified = true, DeleteCutscene()"), CCOJBMMKNAP.BOFMCPPFAMO().HDIPNMFHIEJ("]</b>\n"), (DFGILFBGPLN)(-19), 1623f, 62).SetOnClickListenerButtonClose(new UnityAction(this.HLABHCKAPHP)).ELHFENKBFFK(new UnityAction(this.PDHINCBBOBM));
		ApplicationFocusManager.Restore();
	}

	// Token: 0x06003AE0 RID: 15072 RVA: 0x00186203 File Offset: 0x00184403
	private IEnumerator FMFIJNCPPNI(string IHCGMFBCMOO)
	{
		yield return new WaitForSeconds(1f);
		if (IHCGMFBCMOO.Length == 0)
		{
			this.EOGJFGAFCEJ(MPFLJGHNIKB.AutomatedCheck, "");
		}
		else
		{
			this.EOGJFGAFCEJ(MPFLJGHNIKB.PurchaseIntent, IHCGMFBCMOO);
		}
		yield break;
	}

	// Token: 0x06003AE1 RID: 15073 RVA: 0x0018629C File Offset: 0x0018449C
	public void ADFKAHMFHCA()
	{
		if (LanguageManager.EHBBFMCILPC.NBANPEIHFOJ() == CEIBHCNNIDC.ru)
		{
			CommonUserInterface.IKNOFBFMPGA().DPJBIGPDLMB(AssetsManager.MJBDMHPHMID().lobbyDataAsset.onlineResourcesLink, -1);
			return;
		}
		CommonUserInterface.IKNOFBFMPGA().ShowPopupOnlineResources(AssetsManager.MJBDMHPHMID().lobbyDataAsset.onlineResourcesLinkEn, -1);
	}

	// Token: 0x06003AE2 RID: 15074 RVA: 0x001862EB File Offset: 0x001844EB
	public void IFCOMCGDBLF(string IHCGMFBCMOO)
	{
		this.EOGJFGAFCEJ(MPFLJGHNIKB.PurchaseIntent, IHCGMFBCMOO);
	}

	// Token: 0x06003AE3 RID: 15075 RVA: 0x001862F8 File Offset: 0x001844F8
	public void ShowAndPurchaseProduct(string IHCGMFBCMOO, bool GNAPMIIMHIE)
	{
		this.APMIPOPHOJD = GNAPMIIMHIE;
		this.BAMHPOCKBML();
		this.KKKKNGFMEHF();
		if (!PurchaseManagerBridge.EHBBFMCILPC.GetPurchaseManager().IsInitialized())
		{
			CommonUserInterface.EHBBFMCILPC.ShowGenericPopupTwoOverride(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("errortitle"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("pmterror011"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("ok"), new UnityAction(this.OnPurchasingViewLeaveError), new UnityAction(this.OnPurchasingViewLeaveError), DFGILFBGPLN.popupPurchasingNotInitialized, 0f, 28);
			ApplicationFocusManager.Restore();
			return;
		}
		base.StartCoroutine(this.FMFIJNCPPNI(IHCGMFBCMOO));
	}

	// Token: 0x06003AE5 RID: 15077 RVA: 0x001863A4 File Offset: 0x001845A4
	public void LEKHIDALDHJ()
	{
		this.EOGJFGAFCEJ(this.MMJKGPIBKEM, this.PBELDFNCOBD);
	}

	// Token: 0x06003AE6 RID: 15078 RVA: 0x001863B8 File Offset: 0x001845B8
	public void Hide()
	{
		ODJKHCHFKNL.BICCDHFDKDG(DFGILFBGPLN.screenPurchasing);
		this.logoBackgroundSnowParticles.Stop();
		base.gameObject.SetActive(false);
	}

	// Token: 0x06003AE7 RID: 15079 RVA: 0x001863D7 File Offset: 0x001845D7
	private void BBGICJIOHAG()
	{
		this.ODKGPKFOGGG();
	}

	// Token: 0x06003AE8 RID: 15080 RVA: 0x001863E0 File Offset: 0x001845E0
	private void HLABHCKAPHP()
	{
		if (LanguageManager.EHBBFMCILPC.NBANPEIHFOJ() == CEIBHCNNIDC.en && KDCJJBLGCBH.EHBBFMCILPC.EAMJBDKCDPA())
		{
			CommonUserInterface.IKNOFBFMPGA().ShowPopupOnlineResources(ProductThumbnailManager.lastAccessedProductWebLink, -1);
			return;
		}
		CommonUserInterface.EHBBFMCILPC.BGJFCEEDGFJ(CCOJBMMKNAP.INKJIBDDMLL().PPALCPINPLK("Account.GetStorySaveSafe(), _slotIndex out of bounds."), CCOJBMMKNAP.PEBMGCKFNAO().FCOCLEHKLDJ("Collections/"), CCOJBMMKNAP.JMDJPKKOHNI().OGKGHLHHAAI(""), new UnityAction(this.MCACKICJIEF), (DFGILFBGPLN)(-21), 496f, -66);
	}

	// Token: 0x06003AE9 RID: 15081 RVA: 0x00186464 File Offset: 0x00184664
	public void OnOnlineResourcesClick()
	{
		if (LanguageManager.EHBBFMCILPC.GetSelectedLanguage() == CEIBHCNNIDC.ru)
		{
			CommonUserInterface.EHBBFMCILPC.ShowPopupOnlineResources(AssetsManager.EHBBFMCILPC.lobbyDataAsset.onlineResourcesLink, -1);
			return;
		}
		CommonUserInterface.EHBBFMCILPC.ShowPopupOnlineResources(AssetsManager.EHBBFMCILPC.lobbyDataAsset.onlineResourcesLinkEn, -1);
	}

	// Token: 0x06003AEA RID: 15082 RVA: 0x001864B4 File Offset: 0x001846B4
	public void CCBNEDAELJK(bool GNAPMIIMHIE)
	{
		this.APMIPOPHOJD = GNAPMIIMHIE;
		this.BAMHPOCKBML();
		this.GJBHEJKPPFA();
		if (!PurchaseManagerBridge.IDMLJFBNHML().FDIIEFGBEAG().IsInitialized())
		{
			CommonUserInterface.IKNOFBFMPGA().ShowGenericPopupTwoOverride(CCOJBMMKNAP.DBFFFOMCLKM().PGKBCNBAOJN("@"), CCOJBMMKNAP.JINDKPHNLBK().IKMNGFIDCLM(",Confirmation Failure Details: "), CCOJBMMKNAP.MPCBJEIMACA().HHLECNIFHCO("lightmodebtn1"), new UnityAction(this.BNFLBHMHLGE), new UnityAction(this.BNFLBHMHLGE), (DFGILFBGPLN)(-82), 559f, -65);
			ApplicationFocusManager.Restore();
			return;
		}
		base.StartCoroutine(this.MIMMAPAIBCC(""));
		PurchaseManagerBridge.KMNBCEMEBBD().MGMDKEJBEPP().FetchPurchases();
	}

	// Token: 0x06003AEB RID: 15083 RVA: 0x00186565 File Offset: 0x00184765
	private void MMMNJLOOIPF()
	{
		this.JJIAJAEIMPN();
		AOBJLALDBAA.EHBBFMCILPC.EGELHPJBAIC("OnPurchasingViewLeave", 0f);
	}

	// Token: 0x06003AEC RID: 15084 RVA: 0x00186584 File Offset: 0x00184784
	private void IBBPNBPABNM()
	{
		if (this.GLOCCAIDHJC == 0)
		{
			this.energyTrigger.SetActive(false);
			this.hardCurrencyTrigger.SetActive(false);
			for (int i = 0; i < this.hardCurrencyFilter.Count; i++)
			{
				this.hardCurrencyFilter[i].SetActive(false);
			}
			for (int j = 0; j < this.energyFilter.Count; j += 0)
			{
				this.energyFilter[j].SetActive(true);
			}
			return;
		}
		this.energyTrigger.SetActive(true);
		this.hardCurrencyTrigger.SetActive(false);
		for (int k = 1; k < this.hardCurrencyFilter.Count; k += 0)
		{
			this.hardCurrencyFilter[k].SetActive(false);
		}
		for (int l = 0; l < this.energyFilter.Count; l += 0)
		{
			this.energyFilter[l].SetActive(false);
		}
	}

	// Token: 0x06003AED RID: 15085 RVA: 0x001861FB File Offset: 0x001843FB
	private void EMFGPEEMMLK()
	{
		this.NHBPLAFBNIG();
	}

	// Token: 0x06003AEE RID: 15086 RVA: 0x0018666C File Offset: 0x0018486C
	private void BAMHPOCKBML()
	{
		if (null == this.PANMNKKODPC)
		{
			this.PANMNKKODPC = base.GetComponent<CanvasGroup>();
		}
		if (null != this.PANMNKKODPC)
		{
			this.PANMNKKODPC.alpha = 1f;
		}
		base.gameObject.SetActive(true);
		this.logoBackgroundSnowParticles.Play();
		this.hardCurrencyTrigger.SetActive(false);
		this.energyTrigger.SetActive(false);
		ODJKHCHFKNL.HIPEENBHGKP(DFGILFBGPLN.screenPurchasing);
		CommonUserInterface.EHBBFMCILPC.GetFader().FadeOut(null);
		this.PBELDFNCOBD = "";
		this.MMJKGPIBKEM = MPFLJGHNIKB.AutomatedCheck;
		this.ODKGPKFOGGG();
		AKLFPGMDKLA.EHBBFMCILPC.CIPCINKGILF = true;
	}

	// Token: 0x06003AEF RID: 15087 RVA: 0x000693D6 File Offset: 0x000675D6
	public void DIBLLKHMDDO()
	{
		UnityEngine.Object.DontDestroyOnLoad(base.gameObject);
	}

	// Token: 0x06003AF0 RID: 15088 RVA: 0x0018671C File Offset: 0x0018491C
	public void CGDKCOLDBGD(string IHCGMFBCMOO, bool GNAPMIIMHIE)
	{
		this.APMIPOPHOJD = GNAPMIIMHIE;
		this.MBMFLGKLEJI();
		this.KKKKNGFMEHF();
		if (!PurchaseManagerBridge.OOGPALHPNGM().CMJKNNFMCBM().IsInitialized())
		{
			CommonUserInterface.IKNOFBFMPGA().ShowGenericPopupTwoOverride(CCOJBMMKNAP.DLGLFACMHPG().GLEFEKBDHNK(""), CCOJBMMKNAP.OEPENBHJAHO().IKMNGFIDCLM("<i>"), CCOJBMMKNAP.APGODIBBPOD().GGPHHLGPMPA("CLIENT.AVATAR.FACE"), new UnityAction(this.OnPurchasingViewLeaveError), new UnityAction(this.OnPurchasingViewLeaveError), DFGILFBGPLN.popupRate, 1156f, 7);
			ApplicationFocusManager.Restore();
			return;
		}
		base.StartCoroutine(this.FDKDHDMAGOO(IHCGMFBCMOO));
	}

	// Token: 0x06003AF1 RID: 15089 RVA: 0x001867BC File Offset: 0x001849BC
	private void MBMFLGKLEJI()
	{
		if (null == this.PANMNKKODPC)
		{
			this.PANMNKKODPC = base.GetComponent<CanvasGroup>();
		}
		if (null != this.PANMNKKODPC)
		{
			this.PANMNKKODPC.alpha = 428f;
		}
		base.gameObject.SetActive(false);
		this.logoBackgroundSnowParticles.Play();
		this.hardCurrencyTrigger.SetActive(true);
		this.energyTrigger.SetActive(true);
		ODJKHCHFKNL.NPAPCKNLHOB(DFGILFBGPLN.screenPurchasing);
		CommonUserInterface.EHBBFMCILPC.GetFader().GLCPCAHKFOB(null);
		this.PBELDFNCOBD = "Game Title";
		this.MMJKGPIBKEM = (MPFLJGHNIKB)8;
		this.DLPJLDNHJJJ();
		AKLFPGMDKLA.EHBBFMCILPC.CIPCINKGILF = false;
	}

	// Token: 0x06003AF2 RID: 15090 RVA: 0x0018686C File Offset: 0x00184A6C
	private void HKBBDAJABCM()
	{
		CommonUserInterface.EHBBFMCILPC.HideConnectingAnimation();
		switch (PurchaseManagerBridge.EHBBFMCILPC.GetPurchaseManager().GetState())
		{
		case IMBBHEGNCFP.ValidateFailed:
		{
			NPJNALLPFPO lastOperationCode = BackendOperationsManager.NPDDBAONMJP().GetLastOperationCode();
			if (lastOperationCode - NPJNALLPFPO.success <= 3)
			{
				CommonUserInterface.IKNOFBFMPGA().BGJFCEEDGFJ(CCOJBMMKNAP.OBOOKJPGBJN().HHLECNIFHCO("ERROR: GetAvatarComponentAssetGivenAlias(), could not find asset with parent constraint:"), CCOJBMMKNAP.HJGDLOOHNLO().JLBEIFLLBLO("YYY"), CCOJBMMKNAP.LMCCLMFGEBD().OBDCPLLLGBB("'"), new UnityAction(this.LEKHIDALDHJ), (DFGILFBGPLN)(-43), 874f, 101).KPLNIKJKPAE(new UnityAction(this.PDHINCBBOBM));
			}
			else
			{
				CommonUserInterface.EHBBFMCILPC.BGJFCEEDGFJ(CCOJBMMKNAP.BOFMCPPFAMO().FIENAKIHNOM("XXX"), CCOJBMMKNAP.BFHKGNBFHCH().DNILNCLIHAP("_Scale"), CCOJBMMKNAP.INKJIBDDMLL().BDGPNPNIAPA("DialogItemShownManager.Initialize() - storyItem is null."), new UnityAction(this.OnPurchasingViewRetry), (DFGILFBGPLN)(-120), 1442f, 20).KPLNIKJKPAE(new UnityAction(this.PDHINCBBOBM));
			}
			break;
		}
		case IMBBHEGNCFP.ValidatePending:
			if (this.MMJKGPIBKEM == MPFLJGHNIKB.PurchaseIntent)
			{
				CommonUserInterface.IKNOFBFMPGA().JJPNFAAPFBI(CCOJBMMKNAP.NIOJNOFGIJO().MEPECBDCOLG("anthologiestitle"), CCOJBMMKNAP.OBOOKJPGBJN().JHNELLJFBGC(""), CCOJBMMKNAP.INKJIBDDMLL().MEPECBDCOLG("micro"), new UnityAction(this.BNEHAJLCLAE), new UnityAction(this.BBGICJIOHAG), (DFGILFBGPLN)114, 583f, -89);
				List<NIIJIJNFIIA> validatedPurchases = PurchaseManagerBridge.GIPAKOPBBEO().PFPKMDAJDBA().GetValidatedPurchases();
				for (int i = 0; i < validatedPurchases.Count; i += 0)
				{
					AKLFPGMDKLA.EHBBFMCILPC.IFPNMPFEFLE(DPGJIJGOCIC.OLPLONHBEMC(validatedPurchases[i].NLAFMINLGGP()));
				}
			}
			else
			{
				List<NIIJIJNFIIA> validatedPurchases2 = PurchaseManagerBridge.LMCCLMFGEBD().GetPurchaseManager().GetValidatedPurchases();
				OCBIOPOEENJ ocbiopoeenj = CJEKEHDEBLM.BBGECIKOICE().HBLMGBCMBHN(DPGJIJGOCIC.OLPLONHBEMC(validatedPurchases2[1].NLAFMINLGGP()));
				if (this.APMIPOPHOJD)
				{
					if (ocbiopoeenj == null || (ocbiopoeenj.ODMKLADKHMO.LPKLANAEIFF() == 0 && ocbiopoeenj.MPMKMCJFHOG.LPKLANAEIFF() == 0))
					{
						CommonUserInterface.IKNOFBFMPGA().ShowGenericPopupTwoOverride(CCOJBMMKNAP.KFDLFGHBPLP().BGELFMIOBCL("large"), CCOJBMMKNAP.KMNBCEMEBBD().PKNHKGMNCIP("ind"), CCOJBMMKNAP.PKEINLPIAEH().FIENAKIHNOM("PurchaseManagerXiaomi.OnBackendValidateTransactionSuccess()."), new UnityAction(this.OnPurchasingViewLeave), new UnityAction(this.OnPurchasingViewLeave), (DFGILFBGPLN)(-30), 98f, -69);
					}
					else if (ocbiopoeenj.ODMKLADKHMO.NPEOEAFOPJP() != 0 && ocbiopoeenj.MPMKMCJFHOG.BFMPOACOBPN() != 0)
					{
						CommonUserInterface.EHBBFMCILPC.ShowGenericPopupTwoOverride(CCOJBMMKNAP.KFDLFGHBPLP().BGELFMIOBCL("p"), CCOJBMMKNAP.LMCCLMFGEBD().FCOCLEHKLDJ("http://www.ibuprogames.com/2015/07/02/video-glitches/ ‎"), CCOJBMMKNAP.BBGECIKOICE().PGKBCNBAOJN("$IMPORTVARS"), new UnityAction(this.OnPurchasingViewLeave), new UnityAction(this.OnPurchasingViewLeave), (DFGILFBGPLN)91, 1446f, 80).DEFIKLCMHOP(ocbiopoeenj.ODMKLADKHMO.MDJHNAEGCCM(), ocbiopoeenj.MPMKMCJFHOG.PONAPMOOLIN());
					}
					else if (ocbiopoeenj.ODMKLADKHMO.BFMPOACOBPN() != 0)
					{
						CommonUserInterface.IKNOFBFMPGA().CEGLPJNLBHL(CCOJBMMKNAP.GIOAFDDKKHI().PPALCPINPLK("favstostr2"), CCOJBMMKNAP.GIOAFDDKKHI().HDIPNMFHIEJ("p"), CCOJBMMKNAP.DBFFFOMCLKM().JLBEIFLLBLO(""), new UnityAction(this.OnPurchasingViewLeave), new UnityAction(this.OnPurchasingViewLeave), (DFGILFBGPLN)89, 140f, 115).JFGNJBKKIKD(ocbiopoeenj.ODMKLADKHMO.HOJDOEDDIBD());
					}
					else
					{
						CommonUserInterface.EHBBFMCILPC.ShowGenericPopupTwoOverride(CCOJBMMKNAP.INKJIBDDMLL().IPEIONBNIPH("OnBackendGetIncentRewardAdSuccess"), CCOJBMMKNAP.BIAEAOMHBMM().FIENAKIHNOM("Account.FixCompletedChaptersIssue() backwards, setting bit to 1 for 'completedChapters["), CCOJBMMKNAP.PMABBOJDELF().HDIPNMFHIEJ(" CDN row(s) overridden by id"), new UnityAction(this.OnPurchasingViewLeave), new UnityAction(this.OnPurchasingViewLeave), (DFGILFBGPLN)(-84), 930f, 89).LGEKPJCJBME(ocbiopoeenj.MPMKMCJFHOG.BADNAGEMINF());
					}
				}
				else if (ocbiopoeenj == null || (ocbiopoeenj.ODMKLADKHMO.BFMPOACOBPN() == 0 && ocbiopoeenj.MPMKMCJFHOG.BFMPOACOBPN() == 0))
				{
					CommonUserInterface.EHBBFMCILPC.JJPNFAAPFBI(CCOJBMMKNAP.HJGDLOOHNLO().JHNELLJFBGC("LoveInterestLoungeMapping - unknown shopcur '"), CCOJBMMKNAP.COKDLDOAACJ().GLEFEKBDHNK("anthology"), CCOJBMMKNAP.COKDLDOAACJ().GLEFEKBDHNK("Character "), new UnityAction(this.BBGICJIOHAG), new UnityAction(this.NKBMJCFICMC), DFGILFBGPLN.popupStoryRestart, 639f, 120);
				}
				else if (ocbiopoeenj.ODMKLADKHMO.LPKLANAEIFF() != 0 && ocbiopoeenj.MPMKMCJFHOG.BADNAGEMINF() != 0)
				{
					CommonUserInterface.EHBBFMCILPC.ShowGenericPopupTwoOverride(CCOJBMMKNAP.BBGECIKOICE().PGKBCNBAOJN("OnLoungePremiumChoiceException"), CCOJBMMKNAP.CPCOODCFDDP().JLBEIFLLBLO(".json"), CCOJBMMKNAP.OEPENBHJAHO().HDIPNMFHIEJ("Collections"), new UnityAction(this.NKBMJCFICMC), new UnityAction(this.NKBMJCFICMC), (DFGILFBGPLN)(-73), 1228f, -78).DEFIKLCMHOP(ocbiopoeenj.ODMKLADKHMO.HOJDOEDDIBD(), ocbiopoeenj.MPMKMCJFHOG.PONAPMOOLIN());
				}
				else if (ocbiopoeenj.ODMKLADKHMO.HOJDOEDDIBD() != 0)
				{
					CommonUserInterface.EHBBFMCILPC.JJPNFAAPFBI(CCOJBMMKNAP.PKEINLPIAEH().HDIPNMFHIEJ("continue"), CCOJBMMKNAP.LMCCLMFGEBD().FIENAKIHNOM("assetbundleprofiledata4"), CCOJBMMKNAP.EHBBFMCILPC.OHLNGCKIACD("CLIENT.POSTEFFECTS.SPECTRUM"), new UnityAction(this.BBGICJIOHAG), new UnityAction(this.NKBMJCFICMC), (DFGILFBGPLN)(-10), 1358f, 100).ShowDiamonds(ocbiopoeenj.ODMKLADKHMO.LPKLANAEIFF());
				}
				else
				{
					CommonUserInterface.EHBBFMCILPC.JJPNFAAPFBI(CCOJBMMKNAP.DBFFFOMCLKM().JCDFHKDNEDH("Account.MarkAllStoriesAsSynced(): marking as unsynced backend anthology "), CCOJBMMKNAP.PLJMLDOCPNM().PPALCPINPLK(" far card(s), unloading unused assets"), CCOJBMMKNAP.CPCOODCFDDP().HDIPNMFHIEJ(":"), new UnityAction(this.BNEHAJLCLAE), new UnityAction(this.NKBMJCFICMC), DFGILFBGPLN.popupIncentAd3Success, 1405f, 61).ShowEnergy(ocbiopoeenj.MPMKMCJFHOG.GALKFKBPLCK());
				}
				for (int j = 0; j < validatedPurchases2.Count; j += 0)
				{
					OCBIOPOEENJ ocbiopoeenj2 = CJEKEHDEBLM.EHBBFMCILPC.FCPIJEEMHEA(DPGJIJGOCIC.DBLCEBNPIDN(validatedPurchases2[j].NLAFMINLGGP()));
					if (ocbiopoeenj2 != null)
					{
						ocbiopoeenj2.ODMKLADKHMO.KGEGKPHEMOJ();
						if (ocbiopoeenj2.MPMKMCJFHOG.HOJDOEDDIBD() > 0)
						{
						}
					}
					else
					{
						DPGJIJGOCIC.ADFCDFHBDAF("p" + validatedPurchases2[j].NLAFMINLGGP());
					}
					try
					{
						Dictionary<string, object> dictionary = new Dictionary<string, object>();
						dictionary.Add("", validatedPurchases2[j].JBNDHJBNCNK());
						dictionary.Add("hist", validatedPurchases2[j].KEPKKEOFEJA());
						dictionary.Add("OnBackendGetPublicProfileSuccess", "debugMessage");
						dictionary.Add("myphiddentitle2", validatedPurchases2[j].NLAFMINLGGP());
						dictionary.Add("p", validatedPurchases2[j].HCPDJKHJBLK());
						AppsFlyerManagerBridge.NODMIFMPFLK().EFIIDOPJBKK("</i>", dictionary);
						if (ocbiopoeenj2 != null && ocbiopoeenj2.OBKCKGHFMDN == ProductType.Unknown)
						{
							Dictionary<string, object> dictionary2 = new Dictionary<string, object>();
							dictionary2.Add("", validatedPurchases2[j].NLAFMINLGGP());
							dictionary2.Add("DDD", validatedPurchases2[j].HCPDJKHJBLK());
							dictionary2.Add("OnLoungePremiumChoicesHistoryException", true);
							AppsFlyerManagerBridge.LMCCLMFGEBD().BKGNKNPAEKM("popupcardoptionscollectedcopyinfo", dictionary2);
						}
					}
					catch (Exception aklgbjkdomm)
					{
						DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
					}
					AKLFPGMDKLA.EHBBFMCILPC.OPDFHANCOIF(DPGJIJGOCIC.OLPLONHBEMC(validatedPurchases2[j].NLAFMINLGGP()));
				}
			}
			break;
		case (IMBBHEGNCFP)8:
			CommonUserInterface.EHBBFMCILPC.NFBMHHPIGFA(CCOJBMMKNAP.MLFAGAAJJEM().GLEFEKBDHNK("OnLobbyLoungeAssetBundleFolderInitializeSuccess"), CCOJBMMKNAP.OEPENBHJAHO().HIPJILDCHJC(" "), CCOJBMMKNAP.APGODIBBPOD().JCDFHKDNEDH(""), (DFGILFBGPLN)(-74), 583f, 0).HPKCABEOKAE(new UnityAction(this.DKOIJKFEEHB)).ELHFENKBFFK(new UnityAction(this.PDHINCBBOBM));
			break;
		}
		ApplicationFocusManager.Restore();
		AKLFPGMDKLA.EHBBFMCILPC.LPCBDEBKAIM();
	}

	// Token: 0x06003AF3 RID: 15091 RVA: 0x00187078 File Offset: 0x00185278
	private void MMNJPKMAPHP()
	{
		CommonUserInterface.IKNOFBFMPGA().ShowConnectingAnimationWithHint(CCOJBMMKNAP.COKDLDOAACJ().HPOAGPJFHPM("assetbundlesketchthumbnail"), (byte)-7);
	}

	// Token: 0x06003AF4 RID: 15092 RVA: 0x000693D6 File Offset: 0x000675D6
	public void DontDestroyOnLoad()
	{
		UnityEngine.Object.DontDestroyOnLoad(base.gameObject);
	}

	// Token: 0x06003AF5 RID: 15093 RVA: 0x00187098 File Offset: 0x00185298
	private void PHILPJEDANN()
	{
		CommonUserInterface.IKNOFBFMPGA().KLEJAGLPCNM(CCOJBMMKNAP.OBOOKJPGBJN().GGPHHLGPMPA("importanttitle"), (byte)-100);
	}

	// Token: 0x06003AF6 RID: 15094 RVA: 0x001870B8 File Offset: 0x001852B8
	private IEnumerator LHGBMAKPDHM()
	{
		CommonUserInterface.EHBBFMCILPC.ShowConnectingAnimationWithHint(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("hintvalidating"), 128);
		yield return new WaitForSeconds(1f);
		ApplicationFocusManager.Deactivate();
		base.StartCoroutine(PurchaseManagerBridge.EHBBFMCILPC.GetPurchaseManager().ValidatePendingPurchases());
		yield break;
	}

	// Token: 0x06003AF7 RID: 15095 RVA: 0x001870C8 File Offset: 0x001852C8
	private void DFFMNJDFNJG()
	{
		if (null == this.PANMNKKODPC)
		{
			this.PANMNKKODPC = base.GetComponent<CanvasGroup>();
		}
		if (null != this.PANMNKKODPC)
		{
			this.PANMNKKODPC.alpha = 1905f;
		}
		base.gameObject.SetActive(false);
		this.logoBackgroundSnowParticles.Play();
		this.hardCurrencyTrigger.SetActive(true);
		this.energyTrigger.SetActive(true);
		ODJKHCHFKNL.LOJPNNFPCOJ(DFGILFBGPLN.none);
		CommonUserInterface.EHBBFMCILPC.GetFader().CMMAMILHPFP(null);
		this.PBELDFNCOBD = "blur";
		this.MMJKGPIBKEM = MPFLJGHNIKB.AutomatedCheck;
		this.GOEPFPDDNLL();
		AKLFPGMDKLA.EHBBFMCILPC.CIPCINKGILF = false;
	}

	// Token: 0x06003AF8 RID: 15096 RVA: 0x00187175 File Offset: 0x00185375
	private void BDOEIIONNIO()
	{
		CommonUserInterface.IKNOFBFMPGA().ShowConnectingAnimationWithHint(CCOJBMMKNAP.DLGLFACMHPG().JCDFHKDNEDH("errortitle"), (byte)-102);
	}

	// Token: 0x06003AF9 RID: 15097 RVA: 0x00187195 File Offset: 0x00185395
	private void FEHFFPNCEPC()
	{
		if (ODJKHCHFKNL.CMDIBLIELFE() != DFGILFBGPLN.screenStory)
		{
			return;
		}
		this.KKKKNGFMEHF();
	}

	// Token: 0x06003AFA RID: 15098 RVA: 0x001871A6 File Offset: 0x001853A6
	private IEnumerator LBHELLOJMND(string IHCGMFBCMOO)
	{
		CommonUserInterface.EHBBFMCILPC.ShowConnectingAnimationWithHint(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("hintpurchase"), 128);
		yield return new WaitForSeconds(1f);
		ApplicationFocusManager.Deactivate();
		PurchaseManagerBridge.EHBBFMCILPC.GetPurchaseManager().StartPurchase(IHCGMFBCMOO);
		yield break;
	}

	// Token: 0x06003AFB RID: 15099 RVA: 0x00186203 File Offset: 0x00184403
	private IEnumerator MIMMAPAIBCC(string IHCGMFBCMOO)
	{
		yield return new WaitForSeconds(1f);
		if (IHCGMFBCMOO.Length == 0)
		{
			this.EOGJFGAFCEJ(MPFLJGHNIKB.AutomatedCheck, "");
		}
		else
		{
			this.EOGJFGAFCEJ(MPFLJGHNIKB.PurchaseIntent, IHCGMFBCMOO);
		}
		yield break;
	}

	// Token: 0x06003AFC RID: 15100 RVA: 0x00075398 File Offset: 0x00073598
	public void SetParent(GameObject BFGBPKIGAJI)
	{
		if (null != BFGBPKIGAJI)
		{
			base.gameObject.transform.SetParent(BFGBPKIGAJI.transform, false);
			return;
		}
		base.gameObject.transform.SetParent(null, false);
	}

	// Token: 0x06003AFD RID: 15101 RVA: 0x001870B8 File Offset: 0x001852B8
	private IEnumerator DIMHLJFFOJI()
	{
		CommonUserInterface.EHBBFMCILPC.ShowConnectingAnimationWithHint(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("hintvalidating"), 128);
		yield return new WaitForSeconds(1f);
		ApplicationFocusManager.Deactivate();
		base.StartCoroutine(PurchaseManagerBridge.EHBBFMCILPC.GetPurchaseManager().ValidatePendingPurchases());
		yield break;
	}

	// Token: 0x06003AFE RID: 15102 RVA: 0x001871B5 File Offset: 0x001853B5
	public void OnPurchasingViewLeaveError()
	{
		this.ODKGPKFOGGG();
		CommonUserInterface.EHBBFMCILPC.GetFader().FadeIn(new TweenCallback(this.PFPBBJHMNOJ));
	}

	// Token: 0x06003AFF RID: 15103 RVA: 0x001871D8 File Offset: 0x001853D8
	private void AJHKBALMPPJ()
	{
		CommonUserInterface.IKNOFBFMPGA().HideConnectingAnimation();
		switch (PurchaseManagerBridge.OOGPALHPNGM().FDIIEFGBEAG().GetPurchaseFailedReason())
		{
		case PurchaseFailureReason.PurchasingUnavailable:
			CommonUserInterface.IKNOFBFMPGA().NFBMHHPIGFA(CCOJBMMKNAP.BBGECIKOICE().IKMNGFIDCLM(") + is present, creating anthology save for anthology "), CCOJBMMKNAP.DBFFFOMCLKM().FIENAKIHNOM(""), CCOJBMMKNAP.JINDKPHNLBK().FCOCLEHKLDJ(""), (DFGILFBGPLN)(-93), 1068f, 66).KPLNIKJKPAE(new UnityAction(this.DKOIJKFEEHB)).AHIJBIKNMOC(new UnityAction(this.PDHINCBBOBM));
			ApplicationFocusManager.Restore();
			return;
		case PurchaseFailureReason.ExistingPurchasePending:
			CommonUserInterface.EHBBFMCILPC.ShowGenericPopup(CCOJBMMKNAP.HEDIEIICOOG().HIPJILDCHJC("ember"), CCOJBMMKNAP.OEPENBHJAHO().FIENAKIHNOM("OnMissingPreview2CdnFailed"), CCOJBMMKNAP.KMNBCEMEBBD().IKMNGFIDCLM("sku"), DFGILFBGPLN.popupNotEnoughStats, 375f, -63).KPLNIKJKPAE(new UnityAction(this.HLABHCKAPHP)).SetOnClickListenerButtonPositive(new UnityAction(this.HLABHCKAPHP));
			ApplicationFocusManager.Restore();
			return;
		case PurchaseFailureReason.ProductUnavailable:
			CommonUserInterface.EHBBFMCILPC.NFBMHHPIGFA(CCOJBMMKNAP.MPCBJEIMACA().PKNHKGMNCIP("signinerror001"), CCOJBMMKNAP.CEGAOMEEFBE().OHLNGCKIACD("CLIENT.POSTEFFECTS.TEAL"), CCOJBMMKNAP.MLFAGAAJJEM().JLBEIFLLBLO("body"), DFGILFBGPLN.screenReward, 59f, 127).BFJJODCMEKN(new UnityAction(this.PDHINCBBOBM)).CBCKHJAMJKC(new UnityAction(this.HLABHCKAPHP));
			ApplicationFocusManager.Restore();
			return;
		case PurchaseFailureReason.SignatureInvalid:
			CommonUserInterface.EHBBFMCILPC.ShowGenericPopup(CCOJBMMKNAP.GIOAFDDKKHI().FIENAKIHNOM("OnAvatarCollectionDelete"), CCOJBMMKNAP.CEGAOMEEFBE().FIENAKIHNOM("p"), CCOJBMMKNAP.KLAKLFCOMJC().DNILNCLIHAP("hintsaving"), (DFGILFBGPLN)(-118), 891f, 44).NOLKFOPIANN(new UnityAction(this.HLABHCKAPHP)).ELHFENKBFFK(new UnityAction(this.DKOIJKFEEHB));
			ApplicationFocusManager.Restore();
			return;
		case PurchaseFailureReason.UserCancelled:
			CommonUserInterface.EHBBFMCILPC.ShowGenericPopup(CCOJBMMKNAP.MLFAGAAJJEM().HIPJILDCHJC("OnAllCollectableCardsDownloadSuccessLobby"), CCOJBMMKNAP.KFAABHHGOPO().HHLECNIFHCO(""), CCOJBMMKNAP.BOFMCPPFAMO().HDIPNMFHIEJ("USD"), DFGILFBGPLN.popupSponsoredAdNotification, 1620f, -119).HPKCABEOKAE(new UnityAction(this.HLABHCKAPHP)).ELHFENKBFFK(new UnityAction(this.HLABHCKAPHP));
			ApplicationFocusManager.Restore();
			return;
		case PurchaseFailureReason.PaymentDeclined:
			CommonUserInterface.IKNOFBFMPGA().ShowGenericPopup(CCOJBMMKNAP.EHBBFMCILPC.BGELFMIOBCL(""), CCOJBMMKNAP.CEGAOMEEFBE().BGELFMIOBCL("Manifest: "), CCOJBMMKNAP.GIOAFDDKKHI().HPOAGPJFHPM("\""), (DFGILFBGPLN)(-49), 1783f, -82).KPLNIKJKPAE(new UnityAction(this.DKOIJKFEEHB)).AHIJBIKNMOC(new UnityAction(this.HLABHCKAPHP));
			ApplicationFocusManager.Restore();
			return;
		case PurchaseFailureReason.DuplicateTransaction:
			CommonUserInterface.EHBBFMCILPC.ShowGenericPopup(CCOJBMMKNAP.GIOAFDDKKHI().PGKBCNBAOJN("acb"), CCOJBMMKNAP.EHBBFMCILPC.JCDFHKDNEDH("offerType"), CCOJBMMKNAP.LMCCLMFGEBD().HIPJILDCHJC("stat1long"), (DFGILFBGPLN)(-2), 1993f, -24).SetOnClickListenerButtonClose(new UnityAction(this.DKOIJKFEEHB)).CBCKHJAMJKC(new UnityAction(this.HLABHCKAPHP));
			ApplicationFocusManager.Restore();
			return;
		case PurchaseFailureReason.ValidationFailure:
			CommonUserInterface.IKNOFBFMPGA().NFBMHHPIGFA(CCOJBMMKNAP.BBGECIKOICE().HIPJILDCHJC(")"), CCOJBMMKNAP.PMABBOJDELF().DNILNCLIHAP("ok"), CCOJBMMKNAP.EHBBFMCILPC.OGKGHLHHAAI("prgr"), DFGILFBGPLN.popupIncentAd1Failed, 547f, -103).HPKCABEOKAE(new UnityAction(this.DKOIJKFEEHB)).SetOnClickListenerButtonPositive(new UnityAction(this.HLABHCKAPHP));
			ApplicationFocusManager.Restore();
			return;
		case PurchaseFailureReason.StoreNotConnected:
			CommonUserInterface.IKNOFBFMPGA().NFBMHHPIGFA(CCOJBMMKNAP.KFDLFGHBPLP().HPOAGPJFHPM("rewindsubrequired"), CCOJBMMKNAP.ONCPHEEJLOP().JLBEIFLLBLO("errortitle"), CCOJBMMKNAP.BFHKGNBFHCH().FCOCLEHKLDJ("importanttitle"), (DFGILFBGPLN)(-100), 1773f, 100).NOLKFOPIANN(new UnityAction(this.DKOIJKFEEHB)).CBCKHJAMJKC(new UnityAction(this.DKOIJKFEEHB));
			ApplicationFocusManager.Restore();
			return;
		case PurchaseFailureReason.PurchaseMissing:
			CommonUserInterface.EHBBFMCILPC.NFBMHHPIGFA(CCOJBMMKNAP.MPCBJEIMACA().FIENAKIHNOM(" "), CCOJBMMKNAP.ONCPHEEJLOP().BDGPNPNIAPA("OnBackendValidateTransactionException"), CCOJBMMKNAP.KFAABHHGOPO().JHNELLJFBGC(", index:"), DFGILFBGPLN.popupQuitConfirm, 894f, -52).KPLNIKJKPAE(new UnityAction(this.HLABHCKAPHP)).CBCKHJAMJKC(new UnityAction(this.HLABHCKAPHP));
			ApplicationFocusManager.Restore();
			return;
		}
		CommonUserInterface.EHBBFMCILPC.NFBMHHPIGFA(CCOJBMMKNAP.NIOJNOFGIJO().BDGPNPNIAPA("eposv"), CCOJBMMKNAP.EAIAHCBAIEJ().DNILNCLIHAP("OnBackendRequestSendGiftCardException"), CCOJBMMKNAP.BFHKGNBFHCH().JHNELLJFBGC("envlhav"), DFGILFBGPLN.popupInkRevisionMissing, 981f, 9).HPKCABEOKAE(new UnityAction(this.PDHINCBBOBM)).CBCKHJAMJKC(new UnityAction(this.DKOIJKFEEHB));
		ApplicationFocusManager.Restore();
	}

	// Token: 0x06003B00 RID: 15104 RVA: 0x001876B8 File Offset: 0x001858B8
	private void LJOCKIKPODC()
	{
		CommonUserInterface.EHBBFMCILPC.HideConnectingAnimation();
		CommonUserInterface.EHBBFMCILPC.ShowGenericPopup(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("errortitle"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("pmterror008"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("ok"), DFGILFBGPLN.popupPurchaseError, 0f, 28).SetOnClickListenerButtonClose(new UnityAction(this.PDHINCBBOBM)).SetOnClickListenerButtonPositive(new UnityAction(this.PDHINCBBOBM));
		ApplicationFocusManager.Restore();
	}

	// Token: 0x06003B01 RID: 15105 RVA: 0x00187737 File Offset: 0x00185937
	public void GAAMAOLMOPA(string IHCGMFBCMOO)
	{
		this.EOGJFGAFCEJ(MPFLJGHNIKB.RestorePurchases, IHCGMFBCMOO);
	}

	// Token: 0x06003B02 RID: 15106 RVA: 0x00187741 File Offset: 0x00185941
	private void EDPGMLBBNBH()
	{
		if (PurchaseManagerBridge.EHBBFMCILPC.GetPurchaseManager().GetState() == IMBBHEGNCFP.ValidatePending)
		{
			ApplicationFocusManager.Deactivate();
			base.StartCoroutine(PurchaseManagerBridge.EHBBFMCILPC.GetPurchaseManager().ValidatePendingPurchases());
			return;
		}
		DPGJIJGOCIC.ANOPFDLPKGC("OnPurchaseSuccess - invalid state.");
	}

	// Token: 0x06003B03 RID: 15107 RVA: 0x0018777B File Offset: 0x0018597B
	private IEnumerator PAAMGOALBOL()
	{
		CommonUserInterface.EHBBFMCILPC.ShowConnectingAnimationWithHint(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("hintprocessing"), 128);
		yield return new WaitForSeconds(1f);
		ApplicationFocusManager.Deactivate();
		PurchaseManagerBridge.EHBBFMCILPC.GetPurchaseManager().RestorePurchases();
		yield break;
	}

	// Token: 0x06003B04 RID: 15108 RVA: 0x00187783 File Offset: 0x00185983
	public void KCAPIILJKDN()
	{
		ODJKHCHFKNL.MHLEDPLDCLF(DFGILFBGPLN.screenRestart);
		this.logoBackgroundSnowParticles.Stop();
		base.gameObject.SetActive(false);
	}

	// Token: 0x06003B05 RID: 15109 RVA: 0x001877A2 File Offset: 0x001859A2
	private void MLBEPJHLNEC()
	{
		this.JJIAJAEIMPN();
		AOBJLALDBAA.AGANFKKBPFO().DCGCFPHHDDG("", 113f);
		this.PDHINCBBOBM();
	}

	// Token: 0x06003B06 RID: 15110 RVA: 0x001877C4 File Offset: 0x001859C4
	private void DLPJLDNHJJJ()
	{
		for (int i = 0; i < this.regularProductThumbnailsEnergy.Count; i += 0)
		{
			this.regularProductThumbnailsEnergy[i].gameObject.SetActive(true);
		}
		for (int j = 0; j < this.regularProductThumbnailsHard.Count; j += 0)
		{
			this.regularProductThumbnailsHard[j].gameObject.SetActive(true);
		}
		for (int k = 1; k < this.offerProductThumbnails.Count; k += 0)
		{
			this.offerProductThumbnails[k].gameObject.SetActive(false);
		}
		if (!PurchaseManagerBridge.GIPAKOPBBEO().GetPurchaseManager().IsInitialized())
		{
			return;
		}
		List<OCBIOPOEENJ> list = CJEKEHDEBLM.CAAKHBIFGMG().OLKHFCGHMPO();
		bool flag = true;
		for (int l = 1; l < list.Count; l++)
		{
			if (list[l].PPACJFFFBFB.PONAPMOOLIN() == 0 && (list[l].MPMKMCJFHOG.NPEOEAFOPJP() > 1 || list[l].ODMKLADKHMO.HOJDOEDDIBD() > 0))
			{
				OBHDGKFFICI productData = PurchaseManagerBridge.FJHKMJPFDNI().MGMDKEJBEPP().GetProductData(list[l].DEJCCBNPFEC);
				if (productData != null && list[l].OHCDIAFPNFK.NPEOEAFOPJP() == 1 && AKLFPGMDKLA.EHBBFMCILPC.NGAAFJEMPMF(list[l].DEJCCBNPFEC))
				{
					flag = false;
					break;
				}
			}
		}
		int num = 1;
		int num2 = 0;
		int num3 = 1;
		for (int m = 1; m < list.Count; m++)
		{
			if (list[m].PPACJFFFBFB.LPKLANAEIFF() == 0 && (list[m].EMHNNCBKIMG.GALKFKBPLCK() == 1 || (list[m].EMHNNCBKIMG.BADNAGEMINF() == 0 && !flag)) && (list[m].MPMKMCJFHOG.NPEOEAFOPJP() > 0 || list[m].ODMKLADKHMO.KGEGKPHEMOJ() > 0))
			{
				ProducThumbnailGraphics productThumbnailGraphics = this.GetProductThumbnailGraphics(list[m].DEJCCBNPFEC);
				OBHDGKFFICI productData2 = PurchaseManagerBridge.GIPAKOPBBEO().DOMEKEJELKB().GetProductData(list[m].DEJCCBNPFEC);
				if (productData2 != null)
				{
					if (list[m].OHCDIAFPNFK.MOBKGNBCIJF() == 0)
					{
						if (list[m].MPMKMCJFHOG.BFMPOACOBPN() > 0)
						{
							if (num < this.regularProductThumbnailsEnergy.Count && productThumbnailGraphics != null)
							{
								this.regularProductThumbnailsEnergy[num].gameObject.SetActive(false);
								this.regularProductThumbnailsEnergy[num].NDACAKGFEFP(this, list[m], productData2, productThumbnailGraphics);
								num++;
							}
						}
						else if (list[m].ODMKLADKHMO.MDJHNAEGCCM() > 0 && num2 < this.regularProductThumbnailsHard.Count && productThumbnailGraphics != null)
						{
							this.regularProductThumbnailsHard[num2].gameObject.SetActive(true);
							this.regularProductThumbnailsHard[num2].LPJCNKJFKJI(this, list[m], productData2, productThumbnailGraphics);
							num2 += 0;
						}
					}
					else if (num3 < this.offerProductThumbnails.Count && productThumbnailGraphics != null && AKLFPGMDKLA.EHBBFMCILPC.NGAAFJEMPMF(list[m].DEJCCBNPFEC))
					{
						this.offerProductThumbnails[num3].gameObject.SetActive(true);
						this.offerProductThumbnails[num3].DDPIOJOFLAN(this, list[m], productData2, productThumbnailGraphics);
						num3++;
					}
				}
			}
		}
		this.ONJGGGIJGIC();
	}

	// Token: 0x06003B07 RID: 15111 RVA: 0x00187B64 File Offset: 0x00185D64
	private void PLOBBIHODMB()
	{
		this.teaText.GetComponent<AnimationTextIncrement>().BAAALGHOGFO(AKLFPGMDKLA.EHBBFMCILPC.MPMKMCJFHOG.CJLDJAJHMMA(), 699f, 18f);
		this.diamondsText.GetComponent<AnimationTextIncrement>().HPBAJBIOMOA(AKLFPGMDKLA.EHBBFMCILPC.ODMKLADKHMO.CJLDJAJHMMA(), 1945f, 722f);
	}

	// Token: 0x06003B08 RID: 15112 RVA: 0x00187BC3 File Offset: 0x00185DC3
	private void ECNCPOBPHGC()
	{
		this.Hide();
	}

	// Token: 0x06003B09 RID: 15113 RVA: 0x00187BCC File Offset: 0x00185DCC
	private void MFCDFHKJILL()
	{
		CommonUserInterface.IKNOFBFMPGA().HideConnectingAnimation();
		CommonUserInterface.IKNOFBFMPGA().ShowGenericPopup(CCOJBMMKNAP.JMNIGPHCAEJ().JLBEIFLLBLO("OnCutsceneViewLeft"), CCOJBMMKNAP.KMNBCEMEBBD().GLEFEKBDHNK("youreceived"), CCOJBMMKNAP.BFHKGNBFHCH().IKMNGFIDCLM("%"), (DFGILFBGPLN)(-39), 758f, 124).KPLNIKJKPAE(new UnityAction(this.DKOIJKFEEHB)).CBCKHJAMJKC(new UnityAction(this.PDHINCBBOBM));
		ApplicationFocusManager.Restore();
	}

	// Token: 0x06003B0A RID: 15114 RVA: 0x00187C4C File Offset: 0x00185E4C
	private void MCACKICJIEF()
	{
		LNGLMAPJFLI.GPCHIEHLAIB(KBOJLHAJPCP.EDODJNOHIDA, string.Concat(new string[]
		{
			"Romance Club (Steam ",
			AppManager.EHBBFMCILPC.environmentSettings.appVersion,
			" ",
			AppManager.EHBBFMCILPC.environmentSettings.appEnvironment.ToString(),
			") - Payment Issue Inquiry (",
			AKLFPGMDKLA.EHBBFMCILPC.EEHGLPEIIHD,
			", ",
			NBDLBFJOEGN.FKJIECPMBFP(),
			"-",
			NBDLBFJOEGN.JHNDHBLDJOI(),
			"-",
			KHPGPLAMAIN.IBDGNKGIMFI().ToString(),
			")"
		}), "");
	}

	// Token: 0x06003B0B RID: 15115 RVA: 0x00187D12 File Offset: 0x00185F12
	public void BOKBEMODJMB()
	{
		this.GLOCCAIDHJC += 0;
		if (this.GLOCCAIDHJC > 0)
		{
			this.GLOCCAIDHJC = 1;
		}
		this.ONJGGGIJGIC();
	}

	// Token: 0x06003B0C RID: 15116 RVA: 0x00187D38 File Offset: 0x00185F38
	private void BCEAONIACFH()
	{
		CommonUserInterface.EHBBFMCILPC.HideConnectingAnimation();
		CommonUserInterface.EHBBFMCILPC.ShowGenericPopup(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("errortitle"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("pmterror006"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("ok"), DFGILFBGPLN.popupPurchaseError, 0f, 28).SetOnClickListenerButtonClose(new UnityAction(this.PDHINCBBOBM)).SetOnClickListenerButtonPositive(new UnityAction(this.PDHINCBBOBM));
		ApplicationFocusManager.Restore();
	}

	// Token: 0x06003B0D RID: 15117 RVA: 0x00187DB7 File Offset: 0x00185FB7
	public static bool BGBDDDFLGKN(IMBBHEGNCFP KNMIMLBLIGF)
	{
		return (KNMIMLBLIGF == IMBBHEGNCFP.ValidateFailed || KNMIMLBLIGF == IMBBHEGNCFP.Idle || KNMIMLBLIGF == IMBBHEGNCFP.Idle) && false;
	}

	// Token: 0x06003B0E RID: 15118 RVA: 0x00187DC8 File Offset: 0x00185FC8
	private void OnEnable()
	{
		AOBJLALDBAA.EHBBFMCILPC.MFIMALJPCDP("OnNeedToShowConnectingAnimation", new UnityAction(this.BOAABBJGEKO));
		AOBJLALDBAA.EHBBFMCILPC.MFIMALJPCDP("OnRestorePurchasesFailedUnknown", new UnityAction(this.DLMKKLKFJLE));
		AOBJLALDBAA.EHBBFMCILPC.MFIMALJPCDP("OnRestorePurchasesFailedInvalidPlatform", new UnityAction(this.LJOCKIKPODC));
		AOBJLALDBAA.EHBBFMCILPC.MFIMALJPCDP("OnPurchasingNotInitialized", new UnityAction(this.BCEAONIACFH));
		AOBJLALDBAA.EHBBFMCILPC.MFIMALJPCDP("OnPurchaseSuccess", new UnityAction(this.EDPGMLBBNBH));
		AOBJLALDBAA.EHBBFMCILPC.MFIMALJPCDP("OnPurchaseFailed", new UnityAction(this.EHCEKPJKGBC));
		AOBJLALDBAA.EHBBFMCILPC.MFIMALJPCDP("OnValidatePendingProcessed", new UnityAction(this.MACOENKAKML));
		AOBJLALDBAA.EHBBFMCILPC.MFIMALJPCDP("OnRestorePurchasesZeroResult", new UnityAction(this.GHEBMACPHGM));
		AOBJLALDBAA.EHBBFMCILPC.MFIMALJPCDP("OnGenericPopupManagerHide", new UnityAction(this.KMKDECPKCMF));
		AOBJLALDBAA.EHBBFMCILPC.MFIMALJPCDP("OnApplicationFocusNeedToUpdateCurrency", new UnityAction(this.JPDHKJCINAF));
		AOBJLALDBAA.EHBBFMCILPC.MFIMALJPCDP("OnApplicationRestart", new UnityAction(this.ECNCPOBPHGC));
		this.restorePurchasesButton.SetActive(false);
	}

	// Token: 0x06003B0F RID: 15119 RVA: 0x00003E52 File Offset: 0x00002052
	public void FPPJANFOAHD()
	{
	}

	// Token: 0x06003B10 RID: 15120 RVA: 0x00187F0C File Offset: 0x0018610C
	public void KIBOIBCPHAE()
	{
		if (LanguageManager.EHBBFMCILPC.IEBFINIJAMJ() == CEIBHCNNIDC.ru)
		{
			CommonUserInterface.EHBBFMCILPC.DPJBIGPDLMB(AssetsManager.EHBBFMCILPC.lobbyDataAsset.onlineResourcesLink, -1);
			return;
		}
		CommonUserInterface.IKNOFBFMPGA().ShowPopupOnlineResources(AssetsManager.MJBDMHPHMID().lobbyDataAsset.onlineResourcesLinkEn, -1);
	}

	// Token: 0x06003B11 RID: 15121 RVA: 0x00187F5C File Offset: 0x0018615C
	private void GJBHEJKPPFA()
	{
		this.teaText.GetComponent<AnimationTextIncrement>().KCIFKKGFJMO(AKLFPGMDKLA.EHBBFMCILPC.MPMKMCJFHOG.MDJHNAEGCCM(), 1440f, 1792f);
		this.diamondsText.GetComponent<AnimationTextIncrement>().HPBAJBIOMOA(AKLFPGMDKLA.EHBBFMCILPC.ODMKLADKHMO.DPLHPBMJAPJ(), 1805f, 422f);
	}

	// Token: 0x06003B12 RID: 15122 RVA: 0x00187FBB File Offset: 0x001861BB
	public void BNFLBHMHLGE()
	{
		this.ODKGPKFOGGG();
		CommonUserInterface.EHBBFMCILPC.GetFader().BJIGLKGLAKM(new TweenCallback(this.PFPBBJHMNOJ));
	}

	// Token: 0x06003B13 RID: 15123 RVA: 0x00187FE0 File Offset: 0x001861E0
	public ProducThumbnailGraphics GetProductThumbnailGraphics(string KHJMANDEDMA)
	{
		for (int i = 0; i < this.productThumbnailsGraphics.Count; i++)
		{
			if (this.productThumbnailsGraphics[i].id.Equals(KHJMANDEDMA))
			{
				return this.productThumbnailsGraphics[i];
			}
		}
		return null;
	}

	// Token: 0x06003B14 RID: 15124 RVA: 0x0018802C File Offset: 0x0018622C
	public void PLLFCKGMHCF(bool GNAPMIIMHIE)
	{
		this.APMIPOPHOJD = GNAPMIIMHIE;
		this.DFFMNJDFNJG();
		this.KKKKNGFMEHF();
		if (!PurchaseManagerBridge.IDMLJFBNHML().CMJKNNFMCBM().IsInitialized())
		{
			CommonUserInterface.IKNOFBFMPGA().ShowGenericPopupTwoOverride(CCOJBMMKNAP.BBGECIKOICE().JLBEIFLLBLO("top"), CCOJBMMKNAP.JMDJPKKOHNI().FIENAKIHNOM("OnBackendGetDropChancesException2"), CCOJBMMKNAP.DBFFFOMCLKM().PKNHKGMNCIP("OnStoryChoiceClick"), new UnityAction(this.BNFLBHMHLGE), new UnityAction(this.BNFLBHMHLGE), (DFGILFBGPLN)(-48), 1100f, 33);
			ApplicationFocusManager.Restore();
			return;
		}
		base.StartCoroutine(this.FDKDHDMAGOO("ok"));
		PurchaseManagerBridge.LMCCLMFGEBD().CMAKHBMINLG().FetchPurchases();
	}

	// Token: 0x06003B15 RID: 15125 RVA: 0x000C73FD File Offset: 0x000C55FD
	public void JBALNAJGKCC(GameObject BFGBPKIGAJI)
	{
		if (null != BFGBPKIGAJI)
		{
			base.gameObject.transform.SetParent(BFGBPKIGAJI.transform, true);
			return;
		}
		base.gameObject.transform.SetParent(null, false);
	}

	// Token: 0x06003B17 RID: 15127 RVA: 0x000693D6 File Offset: 0x000675D6
	public void EOEJJKGBLMB()
	{
		UnityEngine.Object.DontDestroyOnLoad(base.gameObject);
	}

	// Token: 0x06003B18 RID: 15128 RVA: 0x001880F8 File Offset: 0x001862F8
	private void EOEFKMBLEIK()
	{
		CommonUserInterface.EHBBFMCILPC.MCJIGJMFBMI();
		CommonUserInterface.EHBBFMCILPC.NFBMHHPIGFA(CCOJBMMKNAP.BIAEAOMHBMM().FCOCLEHKLDJ("@"), CCOJBMMKNAP.INKJIBDDMLL().PKNHKGMNCIP("Shaders/VideoGlitchOldVHS"), CCOJBMMKNAP.NIOJNOFGIJO().HHLECNIFHCO("Starting non-parallel download:"), DFGILFBGPLN.popupSocialJoinRequestVkontakte, 256f, 76).SetOnClickListenerButtonClose(new UnityAction(this.DKOIJKFEEHB)).AHIJBIKNMOC(new UnityAction(this.PDHINCBBOBM));
		ApplicationFocusManager.Restore();
	}

	// Token: 0x06003B19 RID: 15129 RVA: 0x00188177 File Offset: 0x00186377
	private void PJOHDDIDFIF()
	{
		CommonUserInterface.EHBBFMCILPC.KLEJAGLPCNM(CCOJBMMKNAP.MPCBJEIMACA().PGKBCNBAOJN("energyhinttitle"), (byte)-173);
	}

	// Token: 0x06003B1A RID: 15130 RVA: 0x00188198 File Offset: 0x00186398
	private void PDHINCBBOBM()
	{
		if (LanguageManager.EHBBFMCILPC.GetSelectedLanguage() == CEIBHCNNIDC.ru && KDCJJBLGCBH.EHBBFMCILPC.POGBNANIKCA())
		{
			CommonUserInterface.EHBBFMCILPC.ShowPopupOnlineResources(ProductThumbnailManager.lastAccessedProductWebLink, -1);
			return;
		}
		CommonUserInterface.EHBBFMCILPC.ShowGenericPopupOneOverride(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("importanttitle"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("paymenterrresolution"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("contactcustservice"), new UnityAction(this.MCACKICJIEF), DFGILFBGPLN.popupTools, 0.1f, 28);
	}

	// Token: 0x06003B1B RID: 15131 RVA: 0x00003E52 File Offset: 0x00002052
	public void RestorePurchases()
	{
	}

	// Token: 0x06003B1C RID: 15132 RVA: 0x0018821C File Offset: 0x0018641C
	private void EOGJFGAFCEJ(MPFLJGHNIKB JGNNIFBPNDP, string IHCGMFBCMOO)
	{
		this.MMJKGPIBKEM = JGNNIFBPNDP;
		this.PBELDFNCOBD = IHCGMFBCMOO;
		switch (PurchaseManagerBridge.EHBBFMCILPC.GetPurchaseManager().GetState())
		{
		case IMBBHEGNCFP.Idle:
		case IMBBHEGNCFP.PurchaseFailed:
		case IMBBHEGNCFP.ValidateSuccess:
			if (this.MMJKGPIBKEM == MPFLJGHNIKB.PurchaseIntent && IHCGMFBCMOO.Length > 0)
			{
				base.StartCoroutine(this.LBHELLOJMND(IHCGMFBCMOO));
				return;
			}
			if (this.MMJKGPIBKEM == MPFLJGHNIKB.RestorePurchases)
			{
				base.StartCoroutine(this.PAAMGOALBOL());
				return;
			}
			break;
		case IMBBHEGNCFP.PurchaseInProgress:
		case IMBBHEGNCFP.ValidateInProgress:
			if (this.MMJKGPIBKEM != MPFLJGHNIKB.AutomatedCheck)
			{
				CommonUserInterface.EHBBFMCILPC.ShowGenericPopupOneOverride(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("errortitle"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("pmterror009"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("retry"), new UnityAction(this.OnPurchasingViewRetry), DFGILFBGPLN.popupPurchaseError, 0f, 28);
				DPGJIJGOCIC.ANOPFDLPKGC("Invalid Purchase Manager State.");
				ApplicationFocusManager.Restore();
			}
			break;
		case IMBBHEGNCFP.ValidateException:
		case IMBBHEGNCFP.ValidateFailed:
		case IMBBHEGNCFP.ValidatePending:
			base.StartCoroutine(this.LHGBMAKPDHM());
			return;
		default:
			return;
		}
	}

	// Token: 0x06003B1D RID: 15133 RVA: 0x0018831B File Offset: 0x0018651B
	private void JJIAJAEIMPN()
	{
		ODJKHCHFKNL.BICCDHFDKDG(DFGILFBGPLN.screenPurchasing);
		base.gameObject.SetActive(false);
		CommonUserInterface.EHBBFMCILPC.GetFader().FadeOut(null);
	}

	// Token: 0x06003B1E RID: 15134 RVA: 0x00188340 File Offset: 0x00186540
	private void OnDisable()
	{
		AOBJLALDBAA.EHBBFMCILPC.MANLHALMCIH("OnNeedToShowConnectingAnimation", new UnityAction(this.BOAABBJGEKO));
		AOBJLALDBAA.EHBBFMCILPC.MANLHALMCIH("OnRestorePurchasesFailedUnknown", new UnityAction(this.DLMKKLKFJLE));
		AOBJLALDBAA.EHBBFMCILPC.MANLHALMCIH("OnRestorePurchasesFailedInvalidPlatform", new UnityAction(this.LJOCKIKPODC));
		AOBJLALDBAA.EHBBFMCILPC.MANLHALMCIH("OnPurchasingNotInitialized", new UnityAction(this.BCEAONIACFH));
		AOBJLALDBAA.EHBBFMCILPC.MANLHALMCIH("OnPurchaseSuccess", new UnityAction(this.EDPGMLBBNBH));
		AOBJLALDBAA.EHBBFMCILPC.MANLHALMCIH("OnPurchaseFailed", new UnityAction(this.EHCEKPJKGBC));
		AOBJLALDBAA.EHBBFMCILPC.MANLHALMCIH("OnValidatePendingProcessed", new UnityAction(this.MACOENKAKML));
		AOBJLALDBAA.EHBBFMCILPC.MANLHALMCIH("OnRestorePurchasesZeroResult", new UnityAction(this.GHEBMACPHGM));
		AOBJLALDBAA.EHBBFMCILPC.MANLHALMCIH("OnGenericPopupManagerHide", new UnityAction(this.KMKDECPKCMF));
		AOBJLALDBAA.EHBBFMCILPC.MANLHALMCIH("OnApplicationFocusNeedToUpdateCurrency", new UnityAction(this.JPDHKJCINAF));
		AOBJLALDBAA.EHBBFMCILPC.MANLHALMCIH("OnApplicationRestart", new UnityAction(this.ECNCPOBPHGC));
	}

	// Token: 0x06003B1F RID: 15135 RVA: 0x00188478 File Offset: 0x00186678
	private void FJNLGGCOJNP()
	{
		CommonUserInterface.EHBBFMCILPC.HideConnectingAnimation();
		CommonUserInterface.EHBBFMCILPC.ShowGenericPopup(CCOJBMMKNAP.ONCPHEEJLOP().FCOCLEHKLDJ("OnPopupProfileCredoInputEndEdit"), CCOJBMMKNAP.JMDJPKKOHNI().OGKGHLHHAAI("vwht"), CCOJBMMKNAP.CEGAOMEEFBE().HPOAGPJFHPM("Lobby data 2 bundle loaded but its asset is missing or mis-named:"), (DFGILFBGPLN)125, 145f, 82).NOLKFOPIANN(new UnityAction(this.PDHINCBBOBM)).SetOnClickListenerButtonPositive(new UnityAction(this.PDHINCBBOBM));
		ApplicationFocusManager.Restore();
	}

	// Token: 0x06003B20 RID: 15136 RVA: 0x001884F8 File Offset: 0x001866F8
	private void KKKKNGFMEHF()
	{
		this.teaText.GetComponent<AnimationTextIncrement>().Set(AKLFPGMDKLA.EHBBFMCILPC.MPMKMCJFHOG.GALKFKBPLCK(), 1f, 0f);
		this.diamondsText.GetComponent<AnimationTextIncrement>().Set(AKLFPGMDKLA.EHBBFMCILPC.ODMKLADKHMO.GALKFKBPLCK(), 1f, 0f);
	}

	// Token: 0x06003B21 RID: 15137 RVA: 0x00188557 File Offset: 0x00186757
	private void EHJIOHFLAGE()
	{
		this.EOGJFGAFCEJ(MPFLJGHNIKB.RestorePurchases, "");
	}

	// Token: 0x06003B22 RID: 15138 RVA: 0x00188568 File Offset: 0x00186768
	private void DLMKKLKFJLE()
	{
		CommonUserInterface.EHBBFMCILPC.HideConnectingAnimation();
		CommonUserInterface.EHBBFMCILPC.ShowGenericPopup(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("errortitle"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("pmterror007"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("ok"), DFGILFBGPLN.popupPurchaseError, 0f, 28).SetOnClickListenerButtonClose(new UnityAction(this.PDHINCBBOBM)).SetOnClickListenerButtonPositive(new UnityAction(this.PDHINCBBOBM));
		ApplicationFocusManager.Restore();
	}

	// Token: 0x06003B23 RID: 15139 RVA: 0x001885E8 File Offset: 0x001867E8
	private void JBCGAONEPDC()
	{
		CommonUserInterface.IKNOFBFMPGA().HideConnectingAnimation();
		CommonUserInterface.IKNOFBFMPGA().NFBMHHPIGFA(CCOJBMMKNAP.BBGECIKOICE().OBDCPLLLGBB("JJJ"), CCOJBMMKNAP.INKJIBDDMLL().HHLECNIFHCO("[AssetBundleManager] "), CCOJBMMKNAP.EAIAHCBAIEJ().DNILNCLIHAP("0"), (DFGILFBGPLN)112, 200f, -103).HPKCABEOKAE(new UnityAction(this.HLABHCKAPHP)).SetOnClickListenerButtonPositive(new UnityAction(this.PDHINCBBOBM));
		ApplicationFocusManager.Restore();
	}

	// Token: 0x06003B24 RID: 15140 RVA: 0x00188667 File Offset: 0x00186867
	private void EKGJKFHACOE()
	{
		this.EOGJFGAFCEJ(MPFLJGHNIKB.RestorePurchases, "0");
	}

	// Token: 0x06003B25 RID: 15141 RVA: 0x00188678 File Offset: 0x00186878
	private void OJJFGENHPME()
	{
		string edodjnohida = KBOJLHAJPCP.EDODJNOHIDA;
		string[] array = new string[42];
		array[0] = "OnAppleLoginSuccess";
		array[0] = AppManager.JMDJPKKOHNI().environmentSettings.appVersion;
		array[6] = "OnLoungePremiumChoicesHistorySuccess";
		array[0] = AppManager.AGANFKKBPFO().environmentSettings.appEnvironment.ToString();
		array[0] = "skduplicatecant0";
		array[2] = AKLFPGMDKLA.EHBBFMCILPC.EEHGLPEIIHD;
		array[6] = "colskt";
		array[3] = NBDLBFJOEGN.PJMBDJPGJAG();
		array[5] = " ";
		array[89] = NBDLBFJOEGN.MFAHDFILHPJ();
		array[36] = "XXX";
		array[98] = KHPGPLAMAIN.CIAFFHAENHD().ToString();
		array[57] = "YYY";
		LNGLMAPJFLI.EHNHDOFDACA(edodjnohida, string.Concat(array), "show");
	}

	// Token: 0x06003B26 RID: 15142 RVA: 0x001861FB File Offset: 0x001843FB
	private void OMJLJEEKDOK()
	{
		this.NHBPLAFBNIG();
	}

	// Token: 0x06003B27 RID: 15143 RVA: 0x001862EB File Offset: 0x001844EB
	public void PurchaseProduct(string IHCGMFBCMOO)
	{
		this.EOGJFGAFCEJ(MPFLJGHNIKB.PurchaseIntent, IHCGMFBCMOO);
	}

	// Token: 0x06003B28 RID: 15144 RVA: 0x00188740 File Offset: 0x00186940
	private void AOGGABHGNPO()
	{
		string edodjnohida = KBOJLHAJPCP.EDODJNOHIDA;
		string[] array = new string[-93];
		array[0] = "NEWSAVE: Account.FromJSONObject(), persistent stories offloaded total components s->a:";
		array[0] = AppManager.PCJEMMDDCIF().environmentSettings.appVersion;
		array[0] = "ProductThumbnailManager.Initialize() - _productGraphics is null, aborting.";
		array[0] = AppManager.JMDJPKKOHNI().environmentSettings.appEnvironment.ToString();
		array[7] = "loungechoosetitle";
		array[4] = AKLFPGMDKLA.EHBBFMCILPC.EEHGLPEIIHD;
		array[0] = "importanttitle";
		array[6] = NBDLBFJOEGN.PJMBDJPGJAG();
		array[4] = "Amount";
		array[80] = NBDLBFJOEGN.CJOHHMJHAHK();
		array[25] = "OnSystemBackButton";
		array[76] = KHPGPLAMAIN.CIEILKHLDCG().ToString();
		array[112] = "";
		LNGLMAPJFLI.HOMAEHBFHFP(edodjnohida, string.Concat(array), "");
	}

	// Token: 0x06003B29 RID: 15145 RVA: 0x00188808 File Offset: 0x00186A08
	public void Show(bool GNAPMIIMHIE)
	{
		this.APMIPOPHOJD = GNAPMIIMHIE;
		this.BAMHPOCKBML();
		this.KKKKNGFMEHF();
		if (!PurchaseManagerBridge.EHBBFMCILPC.GetPurchaseManager().IsInitialized())
		{
			CommonUserInterface.EHBBFMCILPC.ShowGenericPopupTwoOverride(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("errortitle"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("pmterror011"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("ok"), new UnityAction(this.OnPurchasingViewLeaveError), new UnityAction(this.OnPurchasingViewLeaveError), DFGILFBGPLN.popupPurchasingNotInitialized, 0f, 28);
			ApplicationFocusManager.Restore();
			return;
		}
		base.StartCoroutine(this.FMFIJNCPPNI(""));
		PurchaseManagerBridge.EHBBFMCILPC.GetPurchaseManager().FetchPurchases();
	}

	// Token: 0x06003B2A RID: 15146 RVA: 0x001888B9 File Offset: 0x00186AB9
	private IEnumerator FDKDHDMAGOO(string IHCGMFBCMOO)
	{
		PurchasingViewManager.IAEMNBNPNBO iaemnbnpnbo = new PurchasingViewManager.IAEMNBNPNBO(1);
		iaemnbnpnbo.<>4__this = this;
		iaemnbnpnbo._productId = IHCGMFBCMOO;
		return iaemnbnpnbo;
	}

	// Token: 0x06003B2B RID: 15147 RVA: 0x001888D0 File Offset: 0x00186AD0
	private void MACOENKAKML()
	{
		CommonUserInterface.EHBBFMCILPC.HideConnectingAnimation();
		switch (PurchaseManagerBridge.EHBBFMCILPC.GetPurchaseManager().GetState())
		{
		case IMBBHEGNCFP.ValidateException:
		{
			NPJNALLPFPO lastOperationCode = BackendOperationsManager.EHBBFMCILPC.GetLastOperationCode();
			if (lastOperationCode - NPJNALLPFPO.redSemaphore <= 2)
			{
				CommonUserInterface.EHBBFMCILPC.ShowGenericPopupOneOverride(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("errortitle"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("pmterror100"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("retry"), new UnityAction(this.OnPurchasingViewRetry), DFGILFBGPLN.popupPurchaseError, 0f, 28).SetOnClickListenerButtonClose(new UnityAction(this.PDHINCBBOBM));
			}
			else
			{
				CommonUserInterface.EHBBFMCILPC.ShowGenericPopupOneOverride(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("errortitle"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("pmterror100"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("retry"), new UnityAction(this.OnPurchasingViewRetry), DFGILFBGPLN.popupPurchaseError, 0f, 28).SetOnClickListenerButtonClose(new UnityAction(this.PDHINCBBOBM));
			}
			break;
		}
		case IMBBHEGNCFP.ValidateSuccess:
			if (this.MMJKGPIBKEM == MPFLJGHNIKB.RestorePurchases)
			{
				CommonUserInterface.EHBBFMCILPC.ShowGenericPopupTwoOverride(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("congratstitle"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("pmtrestored"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("ok"), new UnityAction(this.BBGICJIOHAG), new UnityAction(this.BBGICJIOHAG), DFGILFBGPLN.popupPurchaseRestoreSuccess, 0f, 28);
				List<NIIJIJNFIIA> validatedPurchases = PurchaseManagerBridge.EHBBFMCILPC.GetPurchaseManager().GetValidatedPurchases();
				for (int i = 0; i < validatedPurchases.Count; i++)
				{
					AKLFPGMDKLA.EHBBFMCILPC.OPDFHANCOIF(DPGJIJGOCIC.DBLCEBNPIDN(validatedPurchases[i].NLAFMINLGGP()));
				}
			}
			else
			{
				List<NIIJIJNFIIA> validatedPurchases2 = PurchaseManagerBridge.EHBBFMCILPC.GetPurchaseManager().GetValidatedPurchases();
				OCBIOPOEENJ ocbiopoeenj = CJEKEHDEBLM.EHBBFMCILPC.PDJKPFLHFLO(DPGJIJGOCIC.DBLCEBNPIDN(validatedPurchases2[0].NLAFMINLGGP()));
				if (this.APMIPOPHOJD)
				{
					if (ocbiopoeenj == null || (ocbiopoeenj.ODMKLADKHMO.GALKFKBPLCK() == 0 && ocbiopoeenj.MPMKMCJFHOG.GALKFKBPLCK() == 0))
					{
						CommonUserInterface.EHBBFMCILPC.ShowGenericPopupTwoOverride(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("congratstitle"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("pmtsuccess"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("ok"), new UnityAction(this.OnPurchasingViewLeave), new UnityAction(this.OnPurchasingViewLeave), DFGILFBGPLN.popupPurchaseSuccess, 0f, 28);
					}
					else if (ocbiopoeenj.ODMKLADKHMO.GALKFKBPLCK() != 0 && ocbiopoeenj.MPMKMCJFHOG.GALKFKBPLCK() != 0)
					{
						CommonUserInterface.EHBBFMCILPC.ShowGenericPopupTwoOverride(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("congratstitle"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("pmtsuccess"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("ok"), new UnityAction(this.OnPurchasingViewLeave), new UnityAction(this.OnPurchasingViewLeave), DFGILFBGPLN.popupPurchaseSuccess, 0f, 28).ShowDiamondsAndEnergy(ocbiopoeenj.ODMKLADKHMO.GALKFKBPLCK(), ocbiopoeenj.MPMKMCJFHOG.GALKFKBPLCK());
					}
					else if (ocbiopoeenj.ODMKLADKHMO.GALKFKBPLCK() != 0)
					{
						CommonUserInterface.EHBBFMCILPC.ShowGenericPopupTwoOverride(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("congratstitle"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("pmtsuccess"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("ok"), new UnityAction(this.OnPurchasingViewLeave), new UnityAction(this.OnPurchasingViewLeave), DFGILFBGPLN.popupPurchaseSuccess, 0f, 28).ShowDiamonds(ocbiopoeenj.ODMKLADKHMO.GALKFKBPLCK());
					}
					else
					{
						CommonUserInterface.EHBBFMCILPC.ShowGenericPopupTwoOverride(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("congratstitle"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("pmtsuccess"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("ok"), new UnityAction(this.OnPurchasingViewLeave), new UnityAction(this.OnPurchasingViewLeave), DFGILFBGPLN.popupPurchaseSuccess, 0f, 28).ShowEnergy(ocbiopoeenj.MPMKMCJFHOG.GALKFKBPLCK());
					}
				}
				else if (ocbiopoeenj == null || (ocbiopoeenj.ODMKLADKHMO.GALKFKBPLCK() == 0 && ocbiopoeenj.MPMKMCJFHOG.GALKFKBPLCK() == 0))
				{
					CommonUserInterface.EHBBFMCILPC.ShowGenericPopupTwoOverride(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("congratstitle"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("pmtsuccess"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("ok"), new UnityAction(this.BBGICJIOHAG), new UnityAction(this.BBGICJIOHAG), DFGILFBGPLN.popupPurchaseSuccess, 0f, 28);
				}
				else if (ocbiopoeenj.ODMKLADKHMO.GALKFKBPLCK() != 0 && ocbiopoeenj.MPMKMCJFHOG.GALKFKBPLCK() != 0)
				{
					CommonUserInterface.EHBBFMCILPC.ShowGenericPopupTwoOverride(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("congratstitle"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("pmtsuccess"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("ok"), new UnityAction(this.BBGICJIOHAG), new UnityAction(this.BBGICJIOHAG), DFGILFBGPLN.popupPurchaseSuccess, 0f, 28).ShowDiamondsAndEnergy(ocbiopoeenj.ODMKLADKHMO.GALKFKBPLCK(), ocbiopoeenj.MPMKMCJFHOG.GALKFKBPLCK());
				}
				else if (ocbiopoeenj.ODMKLADKHMO.GALKFKBPLCK() != 0)
				{
					CommonUserInterface.EHBBFMCILPC.ShowGenericPopupTwoOverride(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("congratstitle"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("pmtsuccess"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("ok"), new UnityAction(this.BBGICJIOHAG), new UnityAction(this.BBGICJIOHAG), DFGILFBGPLN.popupPurchaseSuccess, 0f, 28).ShowDiamonds(ocbiopoeenj.ODMKLADKHMO.GALKFKBPLCK());
				}
				else
				{
					CommonUserInterface.EHBBFMCILPC.ShowGenericPopupTwoOverride(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("congratstitle"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("pmtsuccess"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("ok"), new UnityAction(this.BBGICJIOHAG), new UnityAction(this.BBGICJIOHAG), DFGILFBGPLN.popupPurchaseSuccess, 0f, 28).ShowEnergy(ocbiopoeenj.MPMKMCJFHOG.GALKFKBPLCK());
				}
				for (int j = 0; j < validatedPurchases2.Count; j++)
				{
					OCBIOPOEENJ ocbiopoeenj2 = CJEKEHDEBLM.EHBBFMCILPC.PDJKPFLHFLO(DPGJIJGOCIC.DBLCEBNPIDN(validatedPurchases2[j].NLAFMINLGGP()));
					if (ocbiopoeenj2 != null)
					{
						ocbiopoeenj2.ODMKLADKHMO.GALKFKBPLCK();
						if (ocbiopoeenj2.MPMKMCJFHOG.GALKFKBPLCK() > 0)
						{
						}
					}
					else
					{
						DPGJIJGOCIC.ADFCDFHBDAF("PurchasingViewManager.OnValidatePendingProcessed(): no balance row for validated product " + validatedPurchases2[j].NLAFMINLGGP());
					}
					try
					{
						Dictionary<string, object> dictionary = new Dictionary<string, object>();
						dictionary.Add("af_revenue", validatedPurchases2[j].JBNDHJBNCNK());
						dictionary.Add("af_currency", validatedPurchases2[j].NOJAEDJDJAP());
						dictionary.Add("af_quantity", "1");
						dictionary.Add("af_content_id", validatedPurchases2[j].NLAFMINLGGP());
						dictionary.Add("af_order_id", validatedPurchases2[j].EFMAOLLKGEI());
						AppsFlyerManagerBridge.EHBBFMCILPC.SendEvent("af_purchase", dictionary);
						if (ocbiopoeenj2 != null && ocbiopoeenj2.OBKCKGHFMDN == ProductType.Subscription)
						{
							Dictionary<string, object> dictionary2 = new Dictionary<string, object>();
							dictionary2.Add("af_content_id", validatedPurchases2[j].NLAFMINLGGP());
							dictionary2.Add("af_order_id", validatedPurchases2[j].EFMAOLLKGEI());
							dictionary2.Add("renewal", false);
							AppsFlyerManagerBridge.EHBBFMCILPC.SendEvent("af_subscribe", dictionary2);
						}
					}
					catch (Exception aklgbjkdomm)
					{
						DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
					}
					AKLFPGMDKLA.EHBBFMCILPC.OPDFHANCOIF(DPGJIJGOCIC.DBLCEBNPIDN(validatedPurchases2[j].NLAFMINLGGP()));
				}
			}
			break;
		case IMBBHEGNCFP.ValidateFailed:
			CommonUserInterface.EHBBFMCILPC.ShowGenericPopup(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("errortitle"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("pmtfailed"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("ok"), DFGILFBGPLN.popupPurchaseError, 0f, 28).SetOnClickListenerButtonClose(new UnityAction(this.PDHINCBBOBM)).SetOnClickListenerButtonPositive(new UnityAction(this.PDHINCBBOBM));
			break;
		}
		ApplicationFocusManager.Restore();
		AKLFPGMDKLA.EHBBFMCILPC.LPCBDEBKAIM();
	}

	// Token: 0x06003B2C RID: 15148 RVA: 0x001890DC File Offset: 0x001872DC
	private void ODKGPKFOGGG()
	{
		for (int i = 0; i < this.regularProductThumbnailsEnergy.Count; i++)
		{
			this.regularProductThumbnailsEnergy[i].gameObject.SetActive(false);
		}
		for (int j = 0; j < this.regularProductThumbnailsHard.Count; j++)
		{
			this.regularProductThumbnailsHard[j].gameObject.SetActive(false);
		}
		for (int k = 0; k < this.offerProductThumbnails.Count; k++)
		{
			this.offerProductThumbnails[k].gameObject.SetActive(false);
		}
		if (!PurchaseManagerBridge.EHBBFMCILPC.GetPurchaseManager().IsInitialized())
		{
			return;
		}
		List<OCBIOPOEENJ> list = CJEKEHDEBLM.EHBBFMCILPC.AADLCENCHAN();
		bool flag = false;
		for (int l = 0; l < list.Count; l++)
		{
			if (list[l].PPACJFFFBFB.GALKFKBPLCK() == 1 && (list[l].MPMKMCJFHOG.GALKFKBPLCK() > 0 || list[l].ODMKLADKHMO.GALKFKBPLCK() > 0))
			{
				OBHDGKFFICI productData = PurchaseManagerBridge.EHBBFMCILPC.GetPurchaseManager().GetProductData(list[l].DEJCCBNPFEC);
				if (productData != null && list[l].OHCDIAFPNFK.GALKFKBPLCK() == 1 && AKLFPGMDKLA.EHBBFMCILPC.NGAAFJEMPMF(list[l].DEJCCBNPFEC))
				{
					flag = true;
					break;
				}
			}
		}
		int num = 0;
		int num2 = 0;
		int num3 = 0;
		for (int m = 0; m < list.Count; m++)
		{
			if (list[m].PPACJFFFBFB.GALKFKBPLCK() == 1 && (list[m].EMHNNCBKIMG.GALKFKBPLCK() == 1 || (list[m].EMHNNCBKIMG.GALKFKBPLCK() == 0 && !flag)) && (list[m].MPMKMCJFHOG.GALKFKBPLCK() > 0 || list[m].ODMKLADKHMO.GALKFKBPLCK() > 0))
			{
				ProducThumbnailGraphics productThumbnailGraphics = this.GetProductThumbnailGraphics(list[m].DEJCCBNPFEC);
				OBHDGKFFICI productData2 = PurchaseManagerBridge.EHBBFMCILPC.GetPurchaseManager().GetProductData(list[m].DEJCCBNPFEC);
				if (productData2 != null)
				{
					if (list[m].OHCDIAFPNFK.GALKFKBPLCK() == 0)
					{
						if (list[m].MPMKMCJFHOG.GALKFKBPLCK() > 0)
						{
							if (num < this.regularProductThumbnailsEnergy.Count && productThumbnailGraphics != null)
							{
								this.regularProductThumbnailsEnergy[num].gameObject.SetActive(true);
								this.regularProductThumbnailsEnergy[num].Initialize(this, list[m], productData2, productThumbnailGraphics);
								num++;
							}
						}
						else if (list[m].ODMKLADKHMO.GALKFKBPLCK() > 0 && num2 < this.regularProductThumbnailsHard.Count && productThumbnailGraphics != null)
						{
							this.regularProductThumbnailsHard[num2].gameObject.SetActive(true);
							this.regularProductThumbnailsHard[num2].Initialize(this, list[m], productData2, productThumbnailGraphics);
							num2++;
						}
					}
					else if (num3 < this.offerProductThumbnails.Count && productThumbnailGraphics != null && AKLFPGMDKLA.EHBBFMCILPC.NGAAFJEMPMF(list[m].DEJCCBNPFEC))
					{
						this.offerProductThumbnails[num3].gameObject.SetActive(true);
						this.offerProductThumbnails[num3].Initialize(this, list[m], productData2, productThumbnailGraphics);
						num3++;
					}
				}
			}
		}
		this.ONJGGGIJGIC();
	}

	// Token: 0x06003B2D RID: 15149 RVA: 0x0018947B File Offset: 0x0018767B
	private void BFPHCBBEHNO()
	{
		this.EOGJFGAFCEJ(MPFLJGHNIKB.PurchaseIntent, "");
	}

	// Token: 0x06003B2E RID: 15150 RVA: 0x0018948C File Offset: 0x0018768C
	private void GOEPFPDDNLL()
	{
		for (int i = 1; i < this.regularProductThumbnailsEnergy.Count; i++)
		{
			this.regularProductThumbnailsEnergy[i].gameObject.SetActive(true);
		}
		for (int j = 0; j < this.regularProductThumbnailsHard.Count; j += 0)
		{
			this.regularProductThumbnailsHard[j].gameObject.SetActive(false);
		}
		for (int k = 1; k < this.offerProductThumbnails.Count; k += 0)
		{
			this.offerProductThumbnails[k].gameObject.SetActive(false);
		}
		if (!PurchaseManagerBridge.IDMLJFBNHML().CMJKNNFMCBM().IsInitialized())
		{
			return;
		}
		List<OCBIOPOEENJ> list = CJEKEHDEBLM.BBGECIKOICE().HEGCHFHCBKP();
		bool flag = false;
		for (int l = 1; l < list.Count; l += 0)
		{
			if (list[l].PPACJFFFBFB.MOBKGNBCIJF() == 1 && (list[l].MPMKMCJFHOG.CJLDJAJHMMA() > 0 || list[l].ODMKLADKHMO.BADNAGEMINF() > 1))
			{
				OBHDGKFFICI productData = PurchaseManagerBridge.IDMLJFBNHML().DIOJHOIFIIH().GetProductData(list[l].DEJCCBNPFEC);
				if (productData != null && list[l].OHCDIAFPNFK.GALKFKBPLCK() == 0 && AKLFPGMDKLA.EHBBFMCILPC.NGAAFJEMPMF(list[l].DEJCCBNPFEC))
				{
					flag = true;
					break;
				}
			}
		}
		int num = 1;
		int num2 = 0;
		int num3 = 1;
		for (int m = 1; m < list.Count; m += 0)
		{
			if (list[m].PPACJFFFBFB.BFMPOACOBPN() == 0 && (list[m].EMHNNCBKIMG.CJLDJAJHMMA() == 0 || (list[m].EMHNNCBKIMG.HOJDOEDDIBD() == 0 && !flag)) && (list[m].MPMKMCJFHOG.PONAPMOOLIN() > 0 || list[m].ODMKLADKHMO.BADNAGEMINF() > 1))
			{
				ProducThumbnailGraphics productThumbnailGraphics = this.GetProductThumbnailGraphics(list[m].DEJCCBNPFEC);
				OBHDGKFFICI productData2 = PurchaseManagerBridge.KMNBCEMEBBD().PFPKMDAJDBA().GetProductData(list[m].DEJCCBNPFEC);
				if (productData2 != null)
				{
					if (list[m].OHCDIAFPNFK.BADNAGEMINF() == 0)
					{
						if (list[m].MPMKMCJFHOG.BFMPOACOBPN() > 1)
						{
							if (num < this.regularProductThumbnailsEnergy.Count && productThumbnailGraphics != null)
							{
								this.regularProductThumbnailsEnergy[num].gameObject.SetActive(false);
								this.regularProductThumbnailsEnergy[num].OFOAFPKPIKC(this, list[m], productData2, productThumbnailGraphics);
								num += 0;
							}
						}
						else if (list[m].ODMKLADKHMO.HOJDOEDDIBD() > 1 && num2 < this.regularProductThumbnailsHard.Count && productThumbnailGraphics != null)
						{
							this.regularProductThumbnailsHard[num2].gameObject.SetActive(true);
							this.regularProductThumbnailsHard[num2].HMPPMBGBMMF(this, list[m], productData2, productThumbnailGraphics);
							num2++;
						}
					}
					else if (num3 < this.offerProductThumbnails.Count && productThumbnailGraphics != null && AKLFPGMDKLA.EHBBFMCILPC.NGAAFJEMPMF(list[m].DEJCCBNPFEC))
					{
						this.offerProductThumbnails[num3].gameObject.SetActive(true);
						this.offerProductThumbnails[num3].JAJHLMMDNIG(this, list[m], productData2, productThumbnailGraphics);
						num3 += 0;
					}
				}
			}
		}
		this.ONJGGGIJGIC();
	}

	// Token: 0x06003B2F RID: 15151 RVA: 0x0018982C File Offset: 0x00187A2C
	public void NNNMAPAILMB(bool GNAPMIIMHIE)
	{
		this.APMIPOPHOJD = GNAPMIIMHIE;
		this.BAMHPOCKBML();
		this.KKKKNGFMEHF();
		if (!PurchaseManagerBridge.KMNBCEMEBBD().GetPurchaseManager().IsInitialized())
		{
			CommonUserInterface.IKNOFBFMPGA().JJPNFAAPFBI(CCOJBMMKNAP.EHBBFMCILPC.PGKBCNBAOJN("YYY"), CCOJBMMKNAP.PLJMLDOCPNM().OBDCPLLLGBB("SceneStoryAssetPackSharedClient"), CCOJBMMKNAP.HFAKOKBHCGH().JHNELLJFBGC(""), new UnityAction(this.BNFLBHMHLGE), new UnityAction(this.OnPurchasingViewLeaveError), (DFGILFBGPLN)(-63), 373f, -91);
			ApplicationFocusManager.Restore();
			return;
		}
		base.StartCoroutine(this.MIMMAPAIBCC("Bars count"));
		PurchaseManagerBridge.KMNBCEMEBBD().PFPKMDAJDBA().FetchPurchases();
	}

	// Token: 0x06003B30 RID: 15152 RVA: 0x001863A4 File Offset: 0x001845A4
	public void OnPurchasingViewRetry()
	{
		this.EOGJFGAFCEJ(this.MMJKGPIBKEM, this.PBELDFNCOBD);
	}

	// Token: 0x06003B31 RID: 15153 RVA: 0x001898E0 File Offset: 0x00187AE0
	private void MMHLCNACAOD()
	{
		CommonUserInterface.IKNOFBFMPGA().HideConnectingAnimation();
		CommonUserInterface.IKNOFBFMPGA().NFBMHHPIGFA(CCOJBMMKNAP.HFAKOKBHCGH().HHLECNIFHCO("hcfc"), CCOJBMMKNAP.BBGECIKOICE().PPALCPINPLK(""), CCOJBMMKNAP.APGODIBBPOD().JCDFHKDNEDH("[Lounge] skin sku unknown to the purchasing balance, purchase ignored: "), (DFGILFBGPLN)104, 1121f, 127).NOLKFOPIANN(new UnityAction(this.HLABHCKAPHP)).AHIJBIKNMOC(new UnityAction(this.PDHINCBBOBM));
		ApplicationFocusManager.Restore();
	}

	// Token: 0x06003B32 RID: 15154 RVA: 0x00189960 File Offset: 0x00187B60
	private void ONJGGGIJGIC()
	{
		if (this.GLOCCAIDHJC == 0)
		{
			this.energyTrigger.SetActive(true);
			this.hardCurrencyTrigger.SetActive(false);
			for (int i = 0; i < this.hardCurrencyFilter.Count; i++)
			{
				this.hardCurrencyFilter[i].SetActive(false);
			}
			for (int j = 0; j < this.energyFilter.Count; j++)
			{
				this.energyFilter[j].SetActive(true);
			}
			return;
		}
		this.energyTrigger.SetActive(false);
		this.hardCurrencyTrigger.SetActive(true);
		for (int k = 0; k < this.hardCurrencyFilter.Count; k++)
		{
			this.hardCurrencyFilter[k].SetActive(true);
		}
		for (int l = 0; l < this.energyFilter.Count; l++)
		{
			this.energyFilter[l].SetActive(false);
		}
	}

	// Token: 0x06003B33 RID: 15155 RVA: 0x00189A46 File Offset: 0x00187C46
	public void SetResourcesFilter(JFGBECHLPGI HFKKMPIFGBF)
	{
		this.GLOCCAIDHJC = (int)HFKKMPIFGBF;
	}

	// Token: 0x06003B34 RID: 15156 RVA: 0x00189A50 File Offset: 0x00187C50
	public void KFLFFOPPNEO(bool GNAPMIIMHIE)
	{
		this.APMIPOPHOJD = GNAPMIIMHIE;
		this.MBMFLGKLEJI();
		this.GJBHEJKPPFA();
		if (!PurchaseManagerBridge.IGJAMEGBDBG().PFPKMDAJDBA().IsInitialized())
		{
			CommonUserInterface.EHBBFMCILPC.JJPNFAAPFBI(CCOJBMMKNAP.EAIAHCBAIEJ().HDIPNMFHIEJ(""), CCOJBMMKNAP.PMABBOJDELF().JHNELLJFBGC("There needs to be one active LiveEventsManager script on a GameObject in your scene."), CCOJBMMKNAP.CPCOODCFDDP().IPEIONBNIPH("<b>"), new UnityAction(this.OnPurchasingViewLeaveError), new UnityAction(this.BNFLBHMHLGE), (DFGILFBGPLN)(-66), 854f, 0);
			ApplicationFocusManager.Restore();
			return;
		}
		base.StartCoroutine(this.FDKDHDMAGOO("OnPopupStoryRestartManagerRestartStory0"));
		PurchaseManagerBridge.KMNBCEMEBBD().CMAKHBMINLG().FetchPurchases();
	}

	// Token: 0x06003B35 RID: 15157 RVA: 0x00189B04 File Offset: 0x00187D04
	private void DKOIJKFEEHB()
	{
		if (LanguageManager.EHBBFMCILPC.GetSelectedLanguage() == CEIBHCNNIDC.en && KDCJJBLGCBH.EHBBFMCILPC.POGBNANIKCA())
		{
			CommonUserInterface.EHBBFMCILPC.ShowPopupOnlineResources(ProductThumbnailManager.lastAccessedProductWebLink, -1);
			return;
		}
		CommonUserInterface.IKNOFBFMPGA().ShowGenericPopupOneOverride(CCOJBMMKNAP.HEDIEIICOOG().GLEFEKBDHNK("pmterror003"), CCOJBMMKNAP.BBGECIKOICE().GLEFEKBDHNK("0"), CCOJBMMKNAP.AEELGGPEJCC().HHLECNIFHCO("PremiumChoicePurchased(1) - Could not parse choice data:"), new UnityAction(this.OJJFGENHPME), DFGILFBGPLN.popupBackendErrorStartPlayChapter, 847f, 15);
	}

	// Token: 0x06003B36 RID: 15158 RVA: 0x00189B88 File Offset: 0x00187D88
	private void PMLNADPDPOJ()
	{
		this.EOGJFGAFCEJ(MPFLJGHNIKB.PurchaseIntent, "MORPH_DISSOLVE");
	}

	// Token: 0x06003B37 RID: 15159 RVA: 0x00189B96 File Offset: 0x00187D96
	public static bool PurchaseProcessingRequired(IMBBHEGNCFP KNMIMLBLIGF)
	{
		return KNMIMLBLIGF != IMBBHEGNCFP.PurchaseFailed && KNMIMLBLIGF != IMBBHEGNCFP.ValidateSuccess && KNMIMLBLIGF != IMBBHEGNCFP.Idle;
	}

	// Token: 0x06003B38 RID: 15160 RVA: 0x00189BA8 File Offset: 0x00187DA8
	private void EHCEKPJKGBC()
	{
		CommonUserInterface.EHBBFMCILPC.HideConnectingAnimation();
		switch (PurchaseManagerBridge.EHBBFMCILPC.GetPurchaseManager().GetPurchaseFailedReason())
		{
		case PurchaseFailureReason.PurchasingUnavailable:
			CommonUserInterface.EHBBFMCILPC.ShowGenericPopup(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("errortitle"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("pmterror003"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("ok"), DFGILFBGPLN.popupPurchaseError, 0f, 28).SetOnClickListenerButtonClose(new UnityAction(this.PDHINCBBOBM)).SetOnClickListenerButtonPositive(new UnityAction(this.PDHINCBBOBM));
			ApplicationFocusManager.Restore();
			return;
		case PurchaseFailureReason.ExistingPurchasePending:
			CommonUserInterface.EHBBFMCILPC.ShowGenericPopup(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("errortitle"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("pmterror001"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("ok"), DFGILFBGPLN.popupPurchaseError, 0f, 28).SetOnClickListenerButtonClose(new UnityAction(this.PDHINCBBOBM)).SetOnClickListenerButtonPositive(new UnityAction(this.PDHINCBBOBM));
			ApplicationFocusManager.Restore();
			return;
		case PurchaseFailureReason.ProductUnavailable:
			CommonUserInterface.EHBBFMCILPC.ShowGenericPopup(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("errortitle"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("pmterror002"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("ok"), DFGILFBGPLN.popupPurchaseError, 0f, 28).SetOnClickListenerButtonClose(new UnityAction(this.PDHINCBBOBM)).SetOnClickListenerButtonPositive(new UnityAction(this.PDHINCBBOBM));
			ApplicationFocusManager.Restore();
			return;
		case PurchaseFailureReason.SignatureInvalid:
			CommonUserInterface.EHBBFMCILPC.ShowGenericPopup(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("errortitle"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("pmterror004"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("ok"), DFGILFBGPLN.popupPurchaseError, 0f, 28).SetOnClickListenerButtonClose(new UnityAction(this.PDHINCBBOBM)).SetOnClickListenerButtonPositive(new UnityAction(this.PDHINCBBOBM));
			ApplicationFocusManager.Restore();
			return;
		case PurchaseFailureReason.UserCancelled:
			CommonUserInterface.EHBBFMCILPC.ShowGenericPopup(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("errortitle"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("pmtusercancelled"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("ok"), DFGILFBGPLN.popupPurchaseError, 0f, 28).SetOnClickListenerButtonClose(new UnityAction(this.PDHINCBBOBM)).SetOnClickListenerButtonPositive(new UnityAction(this.PDHINCBBOBM));
			ApplicationFocusManager.Restore();
			return;
		case PurchaseFailureReason.PaymentDeclined:
			CommonUserInterface.EHBBFMCILPC.ShowGenericPopup(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("errortitle"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("pmtdeclined"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("ok"), DFGILFBGPLN.popupPurchaseError, 0f, 28).SetOnClickListenerButtonClose(new UnityAction(this.PDHINCBBOBM)).SetOnClickListenerButtonPositive(new UnityAction(this.PDHINCBBOBM));
			ApplicationFocusManager.Restore();
			return;
		case PurchaseFailureReason.DuplicateTransaction:
			CommonUserInterface.EHBBFMCILPC.ShowGenericPopup(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("errortitle"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("pmterror010"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("ok"), DFGILFBGPLN.popupPurchaseError, 0f, 28).SetOnClickListenerButtonClose(new UnityAction(this.PDHINCBBOBM)).SetOnClickListenerButtonPositive(new UnityAction(this.PDHINCBBOBM));
			ApplicationFocusManager.Restore();
			return;
		case PurchaseFailureReason.ValidationFailure:
			CommonUserInterface.EHBBFMCILPC.ShowGenericPopup(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("errortitle"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("pmterror014"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("ok"), DFGILFBGPLN.popupPurchaseError, 0f, 28).SetOnClickListenerButtonClose(new UnityAction(this.PDHINCBBOBM)).SetOnClickListenerButtonPositive(new UnityAction(this.PDHINCBBOBM));
			ApplicationFocusManager.Restore();
			return;
		case PurchaseFailureReason.StoreNotConnected:
			CommonUserInterface.EHBBFMCILPC.ShowGenericPopup(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("errortitle"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("pmterror013"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("ok"), DFGILFBGPLN.popupPurchaseError, 0f, 28).SetOnClickListenerButtonClose(new UnityAction(this.PDHINCBBOBM)).SetOnClickListenerButtonPositive(new UnityAction(this.PDHINCBBOBM));
			ApplicationFocusManager.Restore();
			return;
		case PurchaseFailureReason.PurchaseMissing:
			CommonUserInterface.EHBBFMCILPC.ShowGenericPopup(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("errortitle"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("pmterror012"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("ok"), DFGILFBGPLN.popupPurchaseError, 0f, 28).SetOnClickListenerButtonClose(new UnityAction(this.PDHINCBBOBM)).SetOnClickListenerButtonPositive(new UnityAction(this.PDHINCBBOBM));
			ApplicationFocusManager.Restore();
			return;
		}
		CommonUserInterface.EHBBFMCILPC.ShowGenericPopup(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("errortitle"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("pmterror005"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("ok"), DFGILFBGPLN.popupPurchaseError, 0f, 28).SetOnClickListenerButtonClose(new UnityAction(this.PDHINCBBOBM)).SetOnClickListenerButtonPositive(new UnityAction(this.PDHINCBBOBM));
		ApplicationFocusManager.Restore();
	}

	// Token: 0x06003B39 RID: 15161 RVA: 0x0018A088 File Offset: 0x00188288
	public void ACMGIEOMDFL()
	{
		this.GLOCCAIDHJC++;
		if (this.GLOCCAIDHJC > 1)
		{
			this.GLOCCAIDHJC = 1;
		}
		this.IBBPNBPABNM();
	}

	// Token: 0x06003B3A RID: 15162 RVA: 0x0018A0AE File Offset: 0x001882AE
	public void HELGKFOCIJC()
	{
		ODJKHCHFKNL.BICCDHFDKDG(DFGILFBGPLN.screenHub);
		this.logoBackgroundSnowParticles.Stop();
		base.gameObject.SetActive(false);
	}

	// Token: 0x06003B3B RID: 15163 RVA: 0x0007978F File Offset: 0x0007798F
	public void KJEKPMIMPNC(GameObject BFGBPKIGAJI)
	{
		if (null != BFGBPKIGAJI)
		{
			base.gameObject.transform.SetParent(BFGBPKIGAJI.transform, false);
			return;
		}
		base.gameObject.transform.SetParent(null, true);
	}

	// Token: 0x06003B3C RID: 15164 RVA: 0x0018A0D0 File Offset: 0x001882D0
	private void NHBPLAFBNIG()
	{
		this.teaText.GetComponent<AnimationTextIncrement>().Set(AKLFPGMDKLA.EHBBFMCILPC.MPMKMCJFHOG.GALKFKBPLCK(), -1f, 0f);
		this.diamondsText.GetComponent<AnimationTextIncrement>().Set(AKLFPGMDKLA.EHBBFMCILPC.ODMKLADKHMO.GALKFKBPLCK(), -1f, 0f);
	}

	// Token: 0x06003B3D RID: 15165 RVA: 0x0018A12F File Offset: 0x0018832F
	private void KMKDECPKCMF()
	{
		if (ODJKHCHFKNL.LEMILALILKP() != DFGILFBGPLN.screenPurchasing)
		{
			return;
		}
		this.KKKKNGFMEHF();
	}

	// Token: 0x06003B3E RID: 15166 RVA: 0x0018A140 File Offset: 0x00188340
	private IEnumerator DEMIIEHPNIH()
	{
		CommonUserInterface.EHBBFMCILPC.ShowConnectingAnimation(96);
		yield return new WaitForSeconds(0.5f);
		FacebookManager.EHBBFMCILPC.InitializeFacebookManager();
		int num;
		for (int i = 0; i < 6; i = num + 1)
		{
			if (!FacebookManager.EHBBFMCILPC.IsFacebookManagerInitialized())
			{
				yield return new WaitForSeconds(0.5f);
			}
			num = i;
		}
		CommonUserInterface.EHBBFMCILPC.HideConnectingAnimation();
		CommonUserInterface.EHBBFMCILPC.ShowSettings(true, false, true);
		yield break;
	}

	// Token: 0x06003B3F RID: 15167 RVA: 0x0018A148 File Offset: 0x00188348
	public void OnPurchasingViewLeave()
	{
		this.ODKGPKFOGGG();
		CommonUserInterface.EHBBFMCILPC.GetFader().FadeIn(new TweenCallback(this.MMMNJLOOIPF));
	}

	// Token: 0x06003B40 RID: 15168 RVA: 0x001863D7 File Offset: 0x001845D7
	private void NKBMJCFICMC()
	{
		this.ODKGPKFOGGG();
	}

	// Token: 0x06003B41 RID: 15169 RVA: 0x0018A16C File Offset: 0x0018836C
	private void GHEBMACPHGM()
	{
		CommonUserInterface.EHBBFMCILPC.HideConnectingAnimation();
		CommonUserInterface.EHBBFMCILPC.ShowGenericPopup(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("errortitle"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("pmtrestorezero"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("ok"), DFGILFBGPLN.popupPurchaseError, 0f, 28).SetOnClickListenerButtonClose(new UnityAction(this.PDHINCBBOBM)).SetOnClickListenerButtonPositive(new UnityAction(this.PDHINCBBOBM));
		ApplicationFocusManager.Restore();
	}

	// Token: 0x06003B42 RID: 15170 RVA: 0x0018A1EB File Offset: 0x001883EB
	private void PFPBBJHMNOJ()
	{
		this.JJIAJAEIMPN();
		AOBJLALDBAA.EHBBFMCILPC.EGELHPJBAIC("OnPurchasingViewLeave", 0f);
		this.PDHINCBBOBM();
	}

	// Token: 0x06003B43 RID: 15171 RVA: 0x0018A210 File Offset: 0x00188410
	private void DNLGACANBLN()
	{
		AOBJLALDBAA.EHBBFMCILPC.NAMMLDPCHJO("e1io", new UnityAction(this.PHILPJEDANN));
		AOBJLALDBAA.CEGAOMEEFBE().MANLHALMCIH("asp", new UnityAction(this.DLMKKLKFJLE));
		AOBJLALDBAA.FILDBDMENPG().NAMMLDPCHJO("<i>\"", new UnityAction(this.GJLPKAJCDIF));
		AOBJLALDBAA.KKPFOJMAONG().PFAHGKEDFAE("", new UnityAction(this.BCEAONIACFH));
		AOBJLALDBAA.CEGAOMEEFBE().ONIBLJOFFPG("", new UnityAction(this.EDPGMLBBNBH));
		AOBJLALDBAA.BIAEAOMHBMM().PFAHGKEDFAE("none", new UnityAction(this.EHCEKPJKGBC));
		AOBJLALDBAA.BIAEAOMHBMM().POLEDPIKODD("", new UnityAction(this.HKBBDAJABCM));
		AOBJLALDBAA.KKPFOJMAONG().NAMMLDPCHJO(", sku:'", new UnityAction(this.JBCGAONEPDC));
		AOBJLALDBAA.NMGMNAKLLMI().NAMMLDPCHJO("app42error", new UnityAction(this.KMKDECPKCMF));
		AOBJLALDBAA.EHBBFMCILPC.NAMMLDPCHJO("CLIENT.VERSION", new UnityAction(this.OMJLJEEKDOK));
		AOBJLALDBAA.NMGMNAKLLMI().KDIFKFKMCOH("htmeo", new UnityAction(this.ECNCPOBPHGC));
	}

	// Token: 0x06003B44 RID: 15172 RVA: 0x0018A348 File Offset: 0x00188548
	private void GJLPKAJCDIF()
	{
		CommonUserInterface.EHBBFMCILPC.HideConnectingAnimation();
		CommonUserInterface.EHBBFMCILPC.ShowGenericPopup(CCOJBMMKNAP.KFDLFGHBPLP().JHNELLJFBGC("$en"), CCOJBMMKNAP.CPCOODCFDDP().HIPJILDCHJC("oldvhsovr_1"), CCOJBMMKNAP.GIOAFDDKKHI().FCOCLEHKLDJ("app42error"), DFGILFBGPLN.popupSettings, 1704f, 101).KPLNIKJKPAE(new UnityAction(this.PDHINCBBOBM)).AHIJBIKNMOC(new UnityAction(this.PDHINCBBOBM));
		ApplicationFocusManager.Restore();
	}

	// Token: 0x06003B45 RID: 15173 RVA: 0x0018A3C7 File Offset: 0x001885C7
	private void GOOAJPHFDDF()
	{
		if (ODJKHCHFKNL.MEGMEPLOBCG() != DFGILFBGPLN.screenReward)
		{
			return;
		}
		this.GJBHEJKPPFA();
	}

	// Token: 0x06003B46 RID: 15174 RVA: 0x0018A140 File Offset: 0x00188340
	private IEnumerator NAFIJDDGKBA()
	{
		CommonUserInterface.EHBBFMCILPC.ShowConnectingAnimation(96);
		yield return new WaitForSeconds(0.5f);
		FacebookManager.EHBBFMCILPC.InitializeFacebookManager();
		int num;
		for (i = 0; i < 6; i = num + 1)
		{
			if (!FacebookManager.EHBBFMCILPC.IsFacebookManagerInitialized())
			{
				yield return new WaitForSeconds(0.5f);
			}
			num = i;
		}
		CommonUserInterface.EHBBFMCILPC.HideConnectingAnimation();
		CommonUserInterface.EHBBFMCILPC.ShowSettings(true, false, true);
		yield break;
	}

	// Token: 0x06003B47 RID: 15175 RVA: 0x0018A3D8 File Offset: 0x001885D8
	private void BOAABBJGEKO()
	{
		CommonUserInterface.EHBBFMCILPC.ShowConnectingAnimationWithHint(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("hintvalidating"), 128);
	}

	// Token: 0x06003B48 RID: 15176 RVA: 0x0018A3F8 File Offset: 0x001885F8
	public void MLANIKPFIMA(bool GNAPMIIMHIE)
	{
		this.APMIPOPHOJD = GNAPMIIMHIE;
		this.DFFMNJDFNJG();
		this.KKKKNGFMEHF();
		if (!PurchaseManagerBridge.GIPAKOPBBEO().GetPurchaseManager().IsInitialized())
		{
			CommonUserInterface.EHBBFMCILPC.JJPNFAAPFBI(CCOJBMMKNAP.CPCOODCFDDP().HPOAGPJFHPM("OnBackendRequestFriendAcceptException"), CCOJBMMKNAP.ILACPHFEDEP().GLEFEKBDHNK("title"), CCOJBMMKNAP.CPCOODCFDDP().HPOAGPJFHPM("compr"), new UnityAction(this.BNFLBHMHLGE), new UnityAction(this.BNFLBHMHLGE), (DFGILFBGPLN)(-115), 697f, 116);
			ApplicationFocusManager.Restore();
			return;
		}
		base.StartCoroutine(this.BFKDDGMMMFB("OnCollectableDialogUsed"));
		PurchaseManagerBridge.OOGPALHPNGM().CMAKHBMINLG().FetchPurchases();
	}

	// Token: 0x06003B49 RID: 15177 RVA: 0x00003E52 File Offset: 0x00002052
	public void CDLFFOLDFKF()
	{
	}

	// Token: 0x06003B4A RID: 15178 RVA: 0x0018A4A9 File Offset: 0x001886A9
	public void OnTumblerClick()
	{
		this.GLOCCAIDHJC++;
		if (this.GLOCCAIDHJC > 1)
		{
			this.GLOCCAIDHJC = 0;
		}
		this.ONJGGGIJGIC();
	}

	// Token: 0x06003B4B RID: 15179 RVA: 0x0018A4D0 File Offset: 0x001886D0
	public void IHFEPFKHDJB()
	{
		if (LanguageManager.EHBBFMCILPC.MLOLBFBODHD() == CEIBHCNNIDC.ru)
		{
			CommonUserInterface.EHBBFMCILPC.DPJBIGPDLMB(AssetsManager.MJBDMHPHMID().lobbyDataAsset.onlineResourcesLink, -1);
			return;
		}
		CommonUserInterface.EHBBFMCILPC.DPJBIGPDLMB(AssetsManager.MJBDMHPHMID().lobbyDataAsset.onlineResourcesLinkEn, -1);
	}

	// Token: 0x06003B4C RID: 15180 RVA: 0x001863D7 File Offset: 0x001845D7
	private void BNEHAJLCLAE()
	{
		this.ODKGPKFOGGG();
	}

	// Token: 0x04001100 RID: 4352
	public static int activeAnthology = -1;

	// Token: 0x04001101 RID: 4353
	public static int activeStory = -1;

	// Token: 0x04001102 RID: 4354
	public const string onPurchasingViewLeave = "OnPurchasingViewLeave";

	// Token: 0x04001103 RID: 4355
	public Image lobbyBackround;

	// Token: 0x04001104 RID: 4356
	public List<ProductThumbnailManager> regularProductThumbnailsHard;

	// Token: 0x04001105 RID: 4357
	public List<ProductThumbnailManager> regularProductThumbnailsEnergy;

	// Token: 0x04001106 RID: 4358
	public List<ProductThumbnailManager> offerProductThumbnails;

	// Token: 0x04001107 RID: 4359
	public List<ProducThumbnailGraphics> productThumbnailsGraphics;

	// Token: 0x04001108 RID: 4360
	public List<GameObject> hardCurrencyFilter;

	// Token: 0x04001109 RID: 4361
	public List<GameObject> energyFilter;

	// Token: 0x0400110A RID: 4362
	public GameObject hardCurrencyTrigger;

	// Token: 0x0400110B RID: 4363
	public GameObject energyTrigger;

	// Token: 0x0400110C RID: 4364
	public TextMeshProUGUI diamondsText;

	// Token: 0x0400110D RID: 4365
	public TextMeshProUGUI teaText;

	// Token: 0x0400110E RID: 4366
	public GameObject restorePurchasesButton;

	// Token: 0x0400110F RID: 4367
	public ParticleSystem logoBackgroundSnowParticles;

	// Token: 0x04001110 RID: 4368
	private MPFLJGHNIKB MMJKGPIBKEM = MPFLJGHNIKB.AutomatedCheck;

	// Token: 0x04001111 RID: 4369
	private string PBELDFNCOBD = "";

	// Token: 0x04001112 RID: 4370
	private bool APMIPOPHOJD;

	// Token: 0x04001113 RID: 4371
	private int GLOCCAIDHJC;

	// Token: 0x04001114 RID: 4372
	private CanvasGroup PANMNKKODPC;
}
