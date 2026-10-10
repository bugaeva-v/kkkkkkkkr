using System;
using System.Collections;
using DG.Tweening;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x02000402 RID: 1026
public class RewardOption : MonoBehaviour
{
	// Token: 0x06007A0B RID: 31243 RVA: 0x00366E5B File Offset: 0x0036505B
	private void IFBCKJLCCAK()
	{
		this.CPGLEJIBNEP = RewardOption.CBOKJGNCEKE + 1650f;
	}

	// Token: 0x06007A0C RID: 31244 RVA: 0x00366E6E File Offset: 0x0036506E
	private void GFJBNGMOBAC()
	{
		this.CPGLEJIBNEP = RewardOption.CBOKJGNCEKE + 83f;
	}

	// Token: 0x06007A0D RID: 31245 RVA: 0x00366E84 File Offset: 0x00365084
	public void OnActionSecondaryClick()
	{
		if (this.rewardType == CMCMEJMOPEC.rewardFreePass)
		{
			try
			{
				SceneLobbyManager2.freePlayPassAnthologyIndex = int.Parse(this.extraData);
				AOBJLALDBAA.EHBBFMCILPC.EGELHPJBAIC("OnRewardsItemClose", 0f);
				AOBJLALDBAA.EHBBFMCILPC.EGELHPJBAIC("OnRewardFreePassPlayStore", 0.15f);
				return;
			}
			catch (Exception aklgbjkdomm)
			{
				SceneLobbyManager2.freePlayPassAnthologyIndex = -1;
				DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
				return;
			}
		}
		DPGJIJGOCIC.ANOPFDLPKGC("RewardOption.OnActionSecondaryClick() - rewardType " + this.rewardType.ToString() + " not implemented.");
	}

	// Token: 0x06007A0E RID: 31246 RVA: 0x00366F18 File Offset: 0x00365118
	private string EMLPPCDOAFP(string KEGBCGMJOLC)
	{
		string text = KEGBCGMJOLC;
		if (this.rewardType == (CMCMEJMOPEC)91)
		{
			OBHDGKFFICI productData = PurchaseManagerBridge.FJHKMJPFDNI().JNNBFLDOOHM().GetProductData(this.extraData);
			OCBIOPOEENJ ocbiopoeenj = CJEKEHDEBLM.CAAKHBIFGMG().EPNHMLIJCCM(this.extraData);
			if (ocbiopoeenj != null && productData != null)
			{
				string newValue;
				if (ocbiopoeenj.PJCIBAKAANH())
				{
					newValue = ocbiopoeenj.FNJCEPLEPBH();
				}
				else
				{
					newValue = "mystoriespattern" + ocbiopoeenj.DMODNDCLGEJ;
				}
				text = text.Replace("p", ocbiopoeenj.MPMKMCJFHOG.ToString());
				text = text.Replace(" padded=", ocbiopoeenj.ODMKLADKHMO.ToString());
				text = text.Replace("$SHOWADS", newValue);
			}
			else
			{
				DPGJIJGOCIC.ANOPFDLPKGC(" ");
			}
		}
		else if (this.rewardType == CMCMEJMOPEC.rewardSubsequentEpisode)
		{
			text = text.Replace("(text)", KDCJJBLGCBH.EHBBFMCILPC.PPKDBCLAGOG().ToString() ?? "saveslotsduplicatepos");
		}
		else if (this.rewardType == CMCMEJMOPEC.rewardDiamondRush)
		{
			text = text.Replace(", candidates ", KDCJJBLGCBH.EHBBFMCILPC.BPIMKFIFKDE(ODLJHDIGLGO.HECMHABJMFO(CLHDENLPOFP.eventPass, true)).ToString() ?? "-");
			text = text.Replace("envlsrw", this.KKEDNJIJECI(0).ToString() ?? "@");
		}
		else if (this.rewardType == CMCMEJMOPEC.rewardReplayEpisode)
		{
			text = text.Replace("plht", KDCJJBLGCBH.EHBBFMCILPC.HHCMJBBEAKO().ToString() ?? "");
			text = text.Replace("[LoadingEnv] skipped, editor simulates asset bundles", this.KKEDNJIJECI(0).ToString() ?? "abld2");
		}
		else if (this.rewardType == CMCMEJMOPEC.rewardAchievements)
		{
			text = text.Replace("layervideo", KDCJJBLGCBH.EHBBFMCILPC.IEBEBBNMEIN().ToString() ?? "' c=");
		}
		else if (this.rewardType == CMCMEJMOPEC.rewardFreeTea)
		{
			text = text.Replace("OnApplicationFocusBasicSyncSuccess", this.KKEDNJIJECI(0).ToString() ?? "OnPopupUpdateWelcomeWhatsMoreClick");
		}
		else if (this.rewardType == (CMCMEJMOPEC)78)
		{
			text = text.Replace(" not found.", DPGJIJGOCIC.CEOBDMGAKNL(KDCJJBLGCBH.EHBBFMCILPC.ADLOIIMBHAG(ODLJHDIGLGO.HECMHABJMFO(CLHDENLPOFP.gamePass, true))) ?? "_ACBeatWidth");
		}
		else if (this.rewardType == CMCMEJMOPEC.rewardFreeTea)
		{
			text = text.Replace("", DPGJIJGOCIC.CEOBDMGAKNL(KDCJJBLGCBH.EHBBFMCILPC.GCPFCGGBDKK(ODLJHDIGLGO.KJIAJJOCMOD(CLHDENLPOFP.gamePass, true))) ?? "fah");
		}
		return text;
	}

	// Token: 0x06007A10 RID: 31248 RVA: 0x003671C0 File Offset: 0x003653C0
	private string FNFJHAFCEOK(string KEGBCGMJOLC)
	{
		string text = KEGBCGMJOLC;
		if (this.rewardType == CMCMEJMOPEC.rewardOffer)
		{
			OBHDGKFFICI productData = PurchaseManagerBridge.EHBBFMCILPC.GetPurchaseManager().GetProductData(this.extraData);
			OCBIOPOEENJ ocbiopoeenj = CJEKEHDEBLM.EHBBFMCILPC.PDJKPFLHFLO(this.extraData);
			if (ocbiopoeenj != null && productData != null)
			{
				string newValue;
				if (ocbiopoeenj.OKGPIEEOKBM())
				{
					newValue = ocbiopoeenj.FNJCEPLEPBH();
				}
				else
				{
					newValue = "USD " + ocbiopoeenj.DMODNDCLGEJ;
				}
				text = text.Replace("XXX", ocbiopoeenj.MPMKMCJFHOG.ToString());
				text = text.Replace("YYY", ocbiopoeenj.ODMKLADKHMO.ToString());
				text = text.Replace("ZZZ", newValue);
			}
			else
			{
				DPGJIJGOCIC.ANOPFDLPKGC("RewardOption.ResolveStringVars() - productBalanceData or productData is null.");
			}
		}
		else if (this.rewardType == CMCMEJMOPEC.rewardFirstEpisode)
		{
			text = text.Replace("XXX", KDCJJBLGCBH.EHBBFMCILPC.PPKDBCLAGOG().ToString() ?? "");
		}
		else if (this.rewardType == CMCMEJMOPEC.rewardSubsequentEpisode)
		{
			text = text.Replace("XXX", KDCJJBLGCBH.EHBBFMCILPC.PLOMCENKKFD(ODLJHDIGLGO.MNALIKIMKFC(CLHDENLPOFP.gamePass, true)).ToString() ?? "");
			text = text.Replace("YYY", this.KKEDNJIJECI(1).ToString() ?? "");
		}
		else if (this.rewardType == CMCMEJMOPEC.rewardReplayEpisode)
		{
			text = text.Replace("XXX", KDCJJBLGCBH.EHBBFMCILPC.HHCMJBBEAKO().ToString() ?? "");
			text = text.Replace("YYY", this.KKEDNJIJECI(1).ToString() ?? "");
		}
		else if (this.rewardType == CMCMEJMOPEC.rewardStoryComplete)
		{
			text = text.Replace("XXX", KDCJJBLGCBH.EHBBFMCILPC.JIMOMNGLIMC().ToString() ?? "");
		}
		else if (this.rewardType == CMCMEJMOPEC.rewardFreeDiamonds)
		{
			text = text.Replace("XXX", this.KKEDNJIJECI(0).ToString() ?? "");
		}
		else if (this.rewardType == CMCMEJMOPEC.rewardSpinWheel)
		{
			text = text.Replace("XXX", DPGJIJGOCIC.CEOBDMGAKNL(KDCJJBLGCBH.EHBBFMCILPC.ADLOIIMBHAG(ODLJHDIGLGO.MNALIKIMKFC(CLHDENLPOFP.gamePass, true))) ?? "");
		}
		else if (this.rewardType == CMCMEJMOPEC.rewardFreeTea)
		{
			text = text.Replace("XXX", DPGJIJGOCIC.CEOBDMGAKNL(KDCJJBLGCBH.EHBBFMCILPC.GCPFCGGBDKK(ODLJHDIGLGO.MNALIKIMKFC(CLHDENLPOFP.gamePass, true))) ?? "");
		}
		return text;
	}

	// Token: 0x06007A11 RID: 31249 RVA: 0x0036743E File Offset: 0x0036563E
	private void LDBGDLHLKBE()
	{
		CommonUserInterface.IKNOFBFMPGA().ShowConnectingAnimation(24);
		BackendOperationsManager.NPDDBAONMJP().RequestEmailUnsubscribe("_NoiseColor", "retry");
	}

	// Token: 0x06007A13 RID: 31251 RVA: 0x00367470 File Offset: 0x00365670
	public void CBLLECFMEID()
	{
		if (this.rewardType == (CMCMEJMOPEC)(-69))
		{
			try
			{
				SceneLobbyManager2.freePlayPassAnthologyIndex = int.Parse(this.extraData);
				AOBJLALDBAA.CEGAOMEEFBE().KGIKHEDLPND("sd", 32f);
				AOBJLALDBAA.CEGAOMEEFBE().DCGCFPHHDDG("no", 1397f);
				return;
			}
			catch (Exception aklgbjkdomm)
			{
				SceneLobbyManager2.freePlayPassAnthologyIndex = -1;
				DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
				return;
			}
		}
		DPGJIJGOCIC.ANOPFDLPKGC("=== RU FIREWALL === chapter end: snapshots save deferred to a standalone second request, the storyChapterComplete envelope stays replay-cacheable" + this.rewardType.ToString() + "〈");
	}

	// Token: 0x06007A14 RID: 31252 RVA: 0x00367504 File Offset: 0x00365704
	private void MIKOEKPAIGP()
	{
		CommonUserInterface.EHBBFMCILPC.ShowConnectingAnimation((byte)-120);
		BackendOperationsManager.NPDDBAONMJP().RequestEmailUnsubscribe("OnPurchasingViewLeave", "Critical error, could not load asset bundle:");
	}

	// Token: 0x06007A15 RID: 31253 RVA: 0x00367528 File Offset: 0x00365728
	private void LPHKPADFMCI()
	{
		AOBJLALDBAA.KKPFOJMAONG().LPNCDPHNBJK("energyhinttitle", 1723f);
		if (LanguageManager.EHBBFMCILPC.NBANPEIHFOJ() == CEIBHCNNIDC.ru && GeoLocationManager.IsRussia() && KDCJJBLGCBH.EHBBFMCILPC.EAMJBDKCDPA())
		{
			CommonUserInterface.EHBBFMCILPC.GetPurchasingViewManager().CCBNEDAELJK(true);
			return;
		}
		CommonUserInterface.IKNOFBFMPGA().GetPurchasingViewManager().CGDKCOLDBGD(this.extraData, true);
	}

	// Token: 0x06007A16 RID: 31254 RVA: 0x00367590 File Offset: 0x00365790
	private void ILOPFODPJCL()
	{
		this.CPGLEJIBNEP = RewardOption.CBOKJGNCEKE + 1364f;
	}

	// Token: 0x06007A17 RID: 31255 RVA: 0x003675A4 File Offset: 0x003657A4
	public void HHGAHCPMCPL()
	{
		if (this.rewardType != (CMCMEJMOPEC)(-91))
		{
			if (this.rewardType != (CMCMEJMOPEC)(-120))
			{
				if (this.rewardType == CMCMEJMOPEC.rewardDiamondRush)
				{
					CommonUserInterface.EHBBFMCILPC.KPAIHLBPFMJ();
					return;
				}
				if (this.rewardType == (CMCMEJMOPEC)(-123))
				{
					CommonUserInterface.IKNOFBFMPGA().ShowSocialSelect();
					return;
				}
				if (this.rewardType == (CMCMEJMOPEC)(-100))
				{
					CommonUserInterface.EHBBFMCILPC.ShowSocialSelect();
					return;
				}
				if (this.rewardType == (CMCMEJMOPEC)(-22))
				{
					CommonUserInterface.EHBBFMCILPC.ShowPopupPromoCodes();
					return;
				}
				if (this.rewardType == (CMCMEJMOPEC)(-115))
				{
					CommonUserInterface.IKNOFBFMPGA().ShowConnectingAnimation(118);
					BackendOperationsManager.EHBBFMCILPC.RequestStartFreePass(this.extraData, "", "UpdateLobbyTuneOnOffState");
					return;
				}
				if (this.rewardType == (CMCMEJMOPEC)26)
				{
					PurchaseManagerBridge.FJHKMJPFDNI().CMJKNNFMCBM().Initialize();
					AOBJLALDBAA.BIAEAOMHBMM().LPNCDPHNBJK("fdlse", 660f);
					CommonUserInterface.IKNOFBFMPGA().GetFader().BJIGLKGLAKM(new TweenCallback(this.BCKCCEIOHAK));
					return;
				}
				if (this.rewardType == CMCMEJMOPEC.rewardDiamondRush)
				{
					AOBJLALDBAA.NMGMNAKLLMI().EGELHPJBAIC("@", 1770f);
					AOBJLALDBAA.BIAEAOMHBMM().LPNCDPHNBJK("snapundocosth", 596f);
					return;
				}
				if (this.rewardType == CMCMEJMOPEC.rewardAchievements)
				{
					AOBJLALDBAA.FILDBDMENPG().EGELHPJBAIC("", 816f);
					AOBJLALDBAA.DBLAIDPICIG().DCGCFPHHDDG("", 396f);
					return;
				}
				if (this.rewardType == CMCMEJMOPEC.rewardSubsequentEpisode)
				{
					AOBJLALDBAA.BIAEAOMHBMM().LPNCDPHNBJK("onConversionDataSuccess", 1769f);
					AOBJLALDBAA.CEGAOMEEFBE().CIGLHCJDDPI("no", 1368f);
					return;
				}
				if (this.rewardType == CMCMEJMOPEC.rewardFreeDiamonds)
				{
					AOBJLALDBAA.CEGAOMEEFBE().EFBNBFIDEOK("etfskv", 1424f);
					AOBJLALDBAA.EHBBFMCILPC.FDKBIBKABCM("h", 24f);
					return;
				}
				if (this.rewardType == CMCMEJMOPEC.rewardSubsequentEpisode)
				{
					AOBJLALDBAA.FILDBDMENPG().DCGCFPHHDDG("sprite", 851f);
					AOBJLALDBAA.AGANFKKBPFO().EGELHPJBAIC("", 1261f);
					return;
				}
				if (this.rewardType == CMCMEJMOPEC.rewardFreeDiamonds)
				{
					if (RewardOption.hardAdCanBeWatched)
					{
						AOBJLALDBAA.NMGMNAKLLMI().FDKBIBKABCM("", 1234f);
						AOBJLALDBAA.AGANFKKBPFO().EGELHPJBAIC(". ", 576f);
						return;
					}
					AOBJLALDBAA.AGANFKKBPFO().CIGLHCJDDPI("_not_found", 1682f);
					return;
				}
				else if (this.rewardType == (CMCMEJMOPEC)20)
				{
					if (RewardOption.spinFireTime <= 0 || AKLFPGMDKLA.EHBBFMCILPC.ABGNIKKFFAC.MDJHNAEGCCM() > 1)
					{
						AOBJLALDBAA.BIAEAOMHBMM().CIGLHCJDDPI("scki2", 1738f);
						AOBJLALDBAA.KKPFOJMAONG().KMAGHMCCMPG("gfts", 473f);
						return;
					}
					AOBJLALDBAA.AGANFKKBPFO().KMAGHMCCMPG("facr", 1267f);
					return;
				}
				else if (this.rewardType == CMCMEJMOPEC.rewardDailyLogin)
				{
					if (RewardOption.dailyRewardFireTime > 1)
					{
						CommonUserInterface.IKNOFBFMPGA().ShowGenericPopup(CCOJBMMKNAP.HEDIEIICOOG().HDIPNMFHIEJ("onLoadingThemeSubscribeRequested"), CCOJBMMKNAP.PEBMGCKFNAO().HDIPNMFHIEJ("priceAmountMicros"), CCOJBMMKNAP.PMABBOJDELF().HPOAGPJFHPM("passinfobtndesc1page2X"), (DFGILFBGPLN)85, 89f, 119);
						return;
					}
					ApplicationFocusManager.AGANFKKBPFO().ForceBasicSync();
					return;
				}
				else
				{
					DPGJIJGOCIC.ANOPFDLPKGC("aind" + this.rewardType.ToString() + "x");
				}
			}
			return;
		}
		if (LanguageManager.EHBBFMCILPC.GetSelectedLanguage() == CEIBHCNNIDC.ru)
		{
			Application.OpenURL(AssetsManager.EHBBFMCILPC.lobbyDataAsset.newsletterSignUpRu);
			return;
		}
		Application.OpenURL(AssetsManager.EHBBFMCILPC.lobbyDataAsset.newsletterSignUpEn);
	}

	// Token: 0x06007A18 RID: 31256 RVA: 0x003678FC File Offset: 0x00365AFC
	private int HHPPEAGBLBL(int MEFKFOHCOHK)
	{
		KIOOJMGLCLC kioojmglclc = ODLJHDIGLGO.DIJMIMMCIKA(CLHDENLPOFP.gamePass);
		int num = 1;
		if (kioojmglclc != null && kioojmglclc.GILNCHJJKJL())
		{
			num = KDCJJBLGCBH.EHBBFMCILPC.AAGICPKFIKC(KDCJJBLGCBH.EHBBFMCILPC.HHONCLBBHPG(kioojmglclc.LLLJOBODOAL), (DAMCJCDKOJK)70, 0 == AKLFPGMDKLA.EHBBFMCILPC.DCIPLNCLIMF);
		}
		return KDCJJBLGCBH.EHBBFMCILPC.NEOIABIBJOI(MEFKFOHCOHK) * num;
	}

	// Token: 0x06007A19 RID: 31257 RVA: 0x00367954 File Offset: 0x00365B54
	private string BGFDNHKMHPE(string KEGBCGMJOLC)
	{
		string text = KEGBCGMJOLC;
		if (this.rewardType == (CMCMEJMOPEC)42)
		{
			OBHDGKFFICI productData = PurchaseManagerBridge.KMNBCEMEBBD().CMAKHBMINLG().GetProductData(this.extraData);
			OCBIOPOEENJ ocbiopoeenj = CJEKEHDEBLM.NACPAKLINNH().DCCLKMCBPPJ(this.extraData);
			if (ocbiopoeenj != null && productData != null)
			{
				string newValue;
				if (ocbiopoeenj.OKGPIEEOKBM())
				{
					newValue = ocbiopoeenj.PKNNPAMOADM();
				}
				else
				{
					newValue = "assetbundlekeepalivepack" + ocbiopoeenj.DMODNDCLGEJ;
				}
				text = text.Replace("sknothingtoshocreators", ocbiopoeenj.MPMKMCJFHOG.ToString());
				text = text.Replace("continue", ocbiopoeenj.ODMKLADKHMO.ToString());
				text = text.Replace("continue", newValue);
			}
			else
			{
				DPGJIJGOCIC.ANOPFDLPKGC(" (loaded via the ");
			}
		}
		else if (this.rewardType == CMCMEJMOPEC.rewardReplayEpisode)
		{
			text = text.Replace("OnLanguageChange", KDCJJBLGCBH.EHBBFMCILPC.PPKDBCLAGOG().ToString() ?? "/");
		}
		else if (this.rewardType == CMCMEJMOPEC.rewardFirstEpisode)
		{
			text = text.Replace("", KDCJJBLGCBH.EHBBFMCILPC.BPIMKFIFKDE(ODLJHDIGLGO.FLDPGFAMICD(CLHDENLPOFP.eventPass, true)).ToString() ?? "Tracking status received: {0}");
			text = text.Replace("passtrytobuyloweroder", this.BNLJGJLMIDA(0).ToString() ?? "");
		}
		else if (this.rewardType == CMCMEJMOPEC.rewardDailyLogin)
		{
			text = text.Replace("", KDCJJBLGCBH.EHBBFMCILPC.HHCMJBBEAKO().ToString() ?? "prw");
			text = text.Replace("PurchaseManagerXiaomi.StartPurchase(): Start purchase ", this.LPGFLGGHGLC(0).ToString() ?? "OnStoryChoiceClickConfimed");
		}
		else if (this.rewardType == CMCMEJMOPEC.rewardSubsequentEpisode)
		{
			text = text.Replace("emlooprestart", KDCJJBLGCBH.EHBBFMCILPC.JIMOMNGLIMC().ToString() ?? "trust-anchor load failed: ");
		}
		else if (this.rewardType == CMCMEJMOPEC.rewardFreeDiamonds)
		{
			text = text.Replace("OnPopupCardOptionsUnlockWithSpException", this.LPGFLGGHGLC(0).ToString() ?? "sto");
		}
		else if (this.rewardType == (CMCMEJMOPEC)69)
		{
			text = text.Replace("language", DPGJIJGOCIC.CEOBDMGAKNL(KDCJJBLGCBH.EHBBFMCILPC.ADLOIIMBHAG(ODLJHDIGLGO.BGJGNDJOLPP(CLHDENLPOFP.gamePass, false))) ?? "OnSaveSyncAnyResult");
		}
		else if (this.rewardType == CMCMEJMOPEC.rewardFreeTea)
		{
			text = text.Replace("cardbreakconfirmationbody", DPGJIJGOCIC.CEOBDMGAKNL(KDCJJBLGCBH.EHBBFMCILPC.GCPFCGGBDKK(ODLJHDIGLGO.KJIAJJOCMOD(CLHDENLPOFP.eventPass, true))) ?? " $0");
		}
		return text;
	}

	// Token: 0x06007A1A RID: 31258 RVA: 0x00367BD4 File Offset: 0x00365DD4
	public void BNHNAEIDGGG()
	{
		if (this.rewardType == (CMCMEJMOPEC)(-20))
		{
			try
			{
				SceneLobbyManager2.freePlayPassAnthologyIndex = int.Parse(this.extraData);
				AOBJLALDBAA.CEGAOMEEFBE().EFBNBFIDEOK("'", 257f);
				AOBJLALDBAA.BIAEAOMHBMM().EGELHPJBAIC("apkshe2", 924f);
				return;
			}
			catch (Exception aklgbjkdomm)
			{
				SceneLobbyManager2.freePlayPassAnthologyIndex = -1;
				DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
				return;
			}
		}
		DPGJIJGOCIC.ANOPFDLPKGC("EmotionLoopManager.RegisterEmotionLoop(): Input data is invalid." + this.rewardType.ToString() + "p");
	}

	// Token: 0x06007A1B RID: 31259 RVA: 0x00367C68 File Offset: 0x00365E68
	private string KEIJCFCDIKP(string KEGBCGMJOLC)
	{
		string text = KEGBCGMJOLC;
		if (this.rewardType == (CMCMEJMOPEC)35)
		{
			OBHDGKFFICI productData = PurchaseManagerBridge.LMCCLMFGEBD().PFPKMDAJDBA().GetProductData(this.extraData);
			OCBIOPOEENJ ocbiopoeenj = CJEKEHDEBLM.FILDBDMENPG().PDJKPFLHFLO(this.extraData);
			if (ocbiopoeenj != null && productData != null)
			{
				string newValue;
				if (ocbiopoeenj.OKGPIEEOKBM())
				{
					newValue = ocbiopoeenj.ILAPDGNDFGC();
				}
				else
				{
					newValue = "+" + ocbiopoeenj.DMODNDCLGEJ;
				}
				text = text.Replace("ok", ocbiopoeenj.MPMKMCJFHOG.ToString());
				text = text.Replace("lititle", ocbiopoeenj.ODMKLADKHMO.ToString());
				text = text.Replace("", newValue);
			}
			else
			{
				DPGJIJGOCIC.ANOPFDLPKGC("");
			}
		}
		else if (this.rewardType == CMCMEJMOPEC.rewardStoryComplete)
		{
			text = text.Replace("\"", KDCJJBLGCBH.EHBBFMCILPC.PPKDBCLAGOG().ToString() ?? "fw");
		}
		else if (this.rewardType == CMCMEJMOPEC.rewardFreeDiamonds)
		{
			text = text.Replace("cv", KDCJJBLGCBH.EHBBFMCILPC.BPIMKFIFKDE(ODLJHDIGLGO.KJIAJJOCMOD(CLHDENLPOFP.gamePass, false)).ToString() ?? "OnApplicationFocusBasicSyncSuccess");
			text = text.Replace("profilechars", this.BNLJGJLMIDA(0).ToString() ?? "");
		}
		else if (this.rewardType == CMCMEJMOPEC.rewardFreeTea)
		{
			text = text.Replace("</b>", KDCJJBLGCBH.EHBBFMCILPC.HHCMJBBEAKO().ToString() ?? "Snapshots/");
			text = text.Replace("story", this.LPGFLGGHGLC(1).ToString() ?? "");
		}
		else if (this.rewardType == CMCMEJMOPEC.rewardDiamondRush)
		{
			text = text.Replace("ok", KDCJJBLGCBH.EHBBFMCILPC.IEBEBBNMEIN().ToString() ?? "usynach");
		}
		else if (this.rewardType == CMCMEJMOPEC.rewardFreeDiamonds)
		{
			text = text.Replace("F0", this.BNLJGJLMIDA(1).ToString() ?? "stat5long");
		}
		else if (this.rewardType == (CMCMEJMOPEC)(-50))
		{
			text = text.Replace("", DPGJIJGOCIC.CEOBDMGAKNL(KDCJJBLGCBH.EHBBFMCILPC.ADLOIIMBHAG(ODLJHDIGLGO.KBNEGBIKKNI(CLHDENLPOFP.gamePass, true))) ?? "SetDepot(), cdnDepot:");
		}
		else if (this.rewardType == CMCMEJMOPEC.rewardFreeTea)
		{
			text = text.Replace("Vignette softness", DPGJIJGOCIC.CEOBDMGAKNL(KDCJJBLGCBH.EHBBFMCILPC.PFIONLJNAPB(ODLJHDIGLGO.EEJHIEBIPPM(CLHDENLPOFP.eventPass, true))) ?? "importanttitle");
		}
		return text;
	}

	// Token: 0x06007A1C RID: 31260 RVA: 0x00367EE8 File Offset: 0x003660E8
	public void HIOCBCMPFIF()
	{
		if (this.rewardType != (CMCMEJMOPEC)112)
		{
			if (this.rewardType != (CMCMEJMOPEC)87)
			{
				if (this.rewardType == CMCMEJMOPEC.rewardSubsequentEpisode)
				{
					CommonUserInterface.EHBBFMCILPC.KPAIHLBPFMJ();
					return;
				}
				if (this.rewardType == (CMCMEJMOPEC)(-68))
				{
					CommonUserInterface.EHBBFMCILPC.KPAIHLBPFMJ();
					return;
				}
				if (this.rewardType == (CMCMEJMOPEC)(-15))
				{
					CommonUserInterface.IKNOFBFMPGA().DJBLEEEEGOL();
					return;
				}
				if (this.rewardType == CMCMEJMOPEC.rewardTeaParty)
				{
					CommonUserInterface.EHBBFMCILPC.ShowPopupPromoCodes();
					return;
				}
				if (this.rewardType == (CMCMEJMOPEC)121)
				{
					CommonUserInterface.IKNOFBFMPGA().ShowConnectingAnimation((byte)-53);
					BackendOperationsManager.NPDDBAONMJP().GOMFBGEMJKL(this.extraData, "</i>", "OnBackendGetDropChancesException2");
					return;
				}
				if (this.rewardType == (CMCMEJMOPEC)(-45))
				{
					PurchaseManagerBridge.IGJAMEGBDBG().JNNBFLDOOHM().Initialize();
					AOBJLALDBAA.EHBBFMCILPC.EFBNBFIDEOK("", 1148f);
					CommonUserInterface.IKNOFBFMPGA().GetFader().PACBMBLIGNN(new TweenCallback(this.IJEKPAOBMIP));
					return;
				}
				if (this.rewardType == CMCMEJMOPEC.rewardAchievements)
				{
					AOBJLALDBAA.CEGAOMEEFBE().FDKBIBKABCM("ok", 764f);
					AOBJLALDBAA.DBLAIDPICIG().DCGCFPHHDDG("\"", 377f);
					return;
				}
				if (this.rewardType == CMCMEJMOPEC.rewardAchievements)
				{
					AOBJLALDBAA.NMGMNAKLLMI().LPNCDPHNBJK("", 195f);
					AOBJLALDBAA.DBLAIDPICIG().LPNCDPHNBJK(" not found.", 1362f);
					return;
				}
				if (this.rewardType == CMCMEJMOPEC.rewardReplayEpisode)
				{
					AOBJLALDBAA.NMGMNAKLLMI().CIGLHCJDDPI("box", 292f);
					AOBJLALDBAA.AGANFKKBPFO().CIGLHCJDDPI("Can't use compressed functions. You need include the SharpZipLib and uncomment the define at the top of SimpleJSON", 748f);
					return;
				}
				if (this.rewardType == CMCMEJMOPEC.rewardAchievements)
				{
					AOBJLALDBAA.FILDBDMENPG().LPNCDPHNBJK("'{0}' material null.", 1962f);
					AOBJLALDBAA.EHBBFMCILPC.CIGLHCJDDPI("OnAllCollectableCardsDownloadSuccess", 1258f);
					return;
				}
				if (this.rewardType == CMCMEJMOPEC.rewardFreeTea)
				{
					AOBJLALDBAA.KKPFOJMAONG().EFBNBFIDEOK("FinishRequest():", 1159f);
					AOBJLALDBAA.BIAEAOMHBMM().KGIKHEDLPND("avatarcollectionsalltitle", 1958f);
					return;
				}
				if (this.rewardType == CMCMEJMOPEC.rewardFreeDiamonds)
				{
					if (RewardOption.hardAdCanBeWatched)
					{
						AOBJLALDBAA.NMGMNAKLLMI().DCGCFPHHDDG("OnStorySplashManagerAdsProviderAdSuccess", 1414f);
						AOBJLALDBAA.EHBBFMCILPC.CIGLHCJDDPI("", 1344f);
						return;
					}
					AOBJLALDBAA.NMGMNAKLLMI().LPNCDPHNBJK("Products fetched successfully for {0} products.", 1f);
					return;
				}
				else if (this.rewardType == (CMCMEJMOPEC)114)
				{
					if (RewardOption.spinFireTime <= 0 || AKLFPGMDKLA.EHBBFMCILPC.ABGNIKKFFAC.PONAPMOOLIN() > 1)
					{
						AOBJLALDBAA.BIAEAOMHBMM().KGIKHEDLPND("uid", 629f);
						AOBJLALDBAA.FILDBDMENPG().CIGLHCJDDPI("،", 594f);
						return;
					}
					AOBJLALDBAA.BIAEAOMHBMM().DCGCFPHHDDG("Asset bundle load operation failed during parallel mode.", 1466f);
					return;
				}
				else if (this.rewardType == CMCMEJMOPEC.rewardDiamondRush)
				{
					if (RewardOption.dailyRewardFireTime > 1)
					{
						CommonUserInterface.EHBBFMCILPC.ShowGenericPopup(CCOJBMMKNAP.BBGECIKOICE().HPOAGPJFHPM("$e1it"), CCOJBMMKNAP.BBGECIKOICE().FCOCLEHKLDJ(" "), CCOJBMMKNAP.JINDKPHNLBK().MEPECBDCOLG("OnBackendGetDropChancesException2"), (DFGILFBGPLN)122, 67f, 53);
						return;
					}
					ApplicationFocusManager.EHBBFMCILPC.ForceBasicSync();
					return;
				}
				else
				{
					DPGJIJGOCIC.ANOPFDLPKGC("importanttitle" + this.rewardType.ToString() + "sfxtimeoutwarning");
				}
			}
			return;
		}
		if (LanguageManager.EHBBFMCILPC.MLOLBFBODHD() == CEIBHCNNIDC.ru)
		{
			Application.OpenURL(AssetsManager.MJBDMHPHMID().lobbyDataAsset.newsletterSignUpRu);
			return;
		}
		Application.OpenURL(AssetsManager.EHBBFMCILPC.lobbyDataAsset.newsletterSignUpEn);
	}

	// Token: 0x06007A1D RID: 31261 RVA: 0x00368240 File Offset: 0x00366440
	private void Update()
	{
		this.CPGLEJIBNEP += Time.deltaTime;
		if (this.CPGLEJIBNEP > RewardOption.CBOKJGNCEKE)
		{
			if (this.rewardType == CMCMEJMOPEC.rewardFreePass && this.timerBlock.gameObject.activeSelf)
			{
				if (LiveEventsManager.EHBBFMCILPC.LiveEventActive(this.extraData))
				{
					this.OHGGDAHPNJM = LiveEventsManager.EHBBFMCILPC.GetLiveEvent(this.extraData);
					if (this.OHGGDAHPNJM != null)
					{
						this.textTimer.SetText(DPGJIJGOCIC.DMENNJGBMBH((int)this.OHGGDAHPNJM.ONMADEIOOKN.ODHBINFKIPL()), true);
					}
				}
			}
			else if (this.rewardType == CMCMEJMOPEC.rewardFreeTea && this.timerBlock.gameObject.activeSelf)
			{
				this.textTimer.SetText(DPGJIJGOCIC.DMENNJGBMBH(RewardOption.energyFireTime), true);
			}
			else if (this.rewardType == CMCMEJMOPEC.rewardFreeDiamonds)
			{
				if (!RewardOption.hardAdCanBeWatched)
				{
					if (!this.timerBlock.gameObject.activeSelf)
					{
						this.timerBlock.gameObject.SetActive(true);
					}
					this.textTimer.SetText(DPGJIJGOCIC.DMENNJGBMBH(RewardOption.hardAdFireTime), true);
				}
				else if (this.timerBlock.gameObject.activeSelf)
				{
					this.timerBlock.gameObject.SetActive(false);
				}
			}
			else if (this.rewardType == CMCMEJMOPEC.rewardSpinWheel)
			{
				if (RewardOption.spinFireTime > 0 && AKLFPGMDKLA.EHBBFMCILPC.ABGNIKKFFAC.GALKFKBPLCK() < KDCJJBLGCBH.EHBBFMCILPC.HLPACDMEKMK(ODLJHDIGLGO.MNALIKIMKFC(CLHDENLPOFP.gamePass, true)))
				{
					if (!this.timerBlock.gameObject.activeSelf)
					{
						this.timerBlock.gameObject.SetActive(true);
					}
					this.textTimer.SetText(DPGJIJGOCIC.DMENNJGBMBH(RewardOption.spinFireTime), true);
				}
				else if (this.timerBlock.gameObject.activeSelf)
				{
					this.timerBlock.gameObject.SetActive(false);
				}
			}
			else if (this.rewardType == CMCMEJMOPEC.rewardDailyLogin)
			{
				if (RewardOption.dailyRewardFireTime > 0)
				{
					if (!this.timerBlock.gameObject.activeSelf)
					{
						this.timerBlock.gameObject.SetActive(true);
					}
					this.textTimer.SetText(DPGJIJGOCIC.DMENNJGBMBH(RewardOption.dailyRewardFireTime), true);
				}
				else if (this.timerBlock.gameObject.activeSelf)
				{
					this.timerBlock.gameObject.SetActive(false);
				}
			}
			this.CPGLEJIBNEP = 0f;
		}
	}

	// Token: 0x06007A1E RID: 31262 RVA: 0x003684AD File Offset: 0x003666AD
	private void ALGIBDJPJBM()
	{
		CommonUserInterface.EHBBFMCILPC.ShowConnectingAnimation(96);
		BackendOperationsManager.EHBBFMCILPC.RequestEmailUnsubscribe("OnEmailUnsubscribeSuccess", "OnEmailUnsubscribeException");
	}

	// Token: 0x06007A1F RID: 31263 RVA: 0x00003E52 File Offset: 0x00002052
	private void PHANLJBFCHF()
	{
	}

	// Token: 0x06007A20 RID: 31264 RVA: 0x003684D0 File Offset: 0x003666D0
	public void FLKFOIDAHGA()
	{
		if (this.rewardType == (CMCMEJMOPEC)(-96))
		{
			try
			{
				SceneLobbyManager2.freePlayPassAnthologyIndex = int.Parse(this.extraData);
				AOBJLALDBAA.KKPFOJMAONG().LPNCDPHNBJK("cleancache", 331f);
				AOBJLALDBAA.NMGMNAKLLMI().DCGCFPHHDDG("registered environments unusable", 1707f);
				return;
			}
			catch (Exception aklgbjkdomm)
			{
				SceneLobbyManager2.freePlayPassAnthologyIndex = -1;
				DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
				return;
			}
		}
		DPGJIJGOCIC.ANOPFDLPKGC("$HINTSHOW" + this.rewardType.ToString() + "OnRewardsItemClose");
	}

	// Token: 0x06007A21 RID: 31265 RVA: 0x00368564 File Offset: 0x00366764
	private void AAGKOINJGOL()
	{
		this.CPGLEJIBNEP = RewardOption.CBOKJGNCEKE + 238f;
	}

	// Token: 0x06007A22 RID: 31266 RVA: 0x00368578 File Offset: 0x00366778
	private int LPGFLGGHGLC(int MEFKFOHCOHK)
	{
		KIOOJMGLCLC kioojmglclc = ODLJHDIGLGO.PPIKCNONDED(CLHDENLPOFP.eventPass);
		int num = 1;
		if (kioojmglclc != null && kioojmglclc.GILNCHJJKJL())
		{
			num = KDCJJBLGCBH.EHBBFMCILPC.ODDPKODCIBB(KDCJJBLGCBH.EHBBFMCILPC.HHONCLBBHPG(kioojmglclc.LLLJOBODOAL), (DAMCJCDKOJK)(-12), 0 == AKLFPGMDKLA.EHBBFMCILPC.DCIPLNCLIMF);
		}
		return KDCJJBLGCBH.EHBBFMCILPC.NEOIABIBJOI(MEFKFOHCOHK) * num;
	}

	// Token: 0x06007A23 RID: 31267 RVA: 0x003685D0 File Offset: 0x003667D0
	public void FHMAMAEGDJG()
	{
		if (this.rewardType != CMCMEJMOPEC.rewardNewsletterUnsubscribe)
		{
			if (this.rewardType != CMCMEJMOPEC.rewardSubsequentEpisode)
			{
				if (this.rewardType == CMCMEJMOPEC.rewardStoryComplete)
				{
					CommonUserInterface.EHBBFMCILPC.KPAIHLBPFMJ();
					return;
				}
				if (this.rewardType == (CMCMEJMOPEC)(-3))
				{
					CommonUserInterface.EHBBFMCILPC.KPAIHLBPFMJ();
					return;
				}
				if (this.rewardType == (CMCMEJMOPEC)(-82))
				{
					CommonUserInterface.IKNOFBFMPGA().KPAIHLBPFMJ();
					return;
				}
				if (this.rewardType == (CMCMEJMOPEC)104)
				{
					CommonUserInterface.EHBBFMCILPC.FPHNBOHOJOB();
					return;
				}
				if (this.rewardType == (CMCMEJMOPEC)35)
				{
					CommonUserInterface.IKNOFBFMPGA().ShowConnectingAnimation(26);
					BackendOperationsManager.NPDDBAONMJP().GOMFBGEMJKL(this.extraData, "BackendOperationsManager.QueueRequestSaveAvatarCollections, exception while initializing RSACryptoServiceProvider:", "StorySaveBody.RemoveAvatarPackWardrobe(), unsupported wardrobe index:");
					return;
				}
				if (this.rewardType == (CMCMEJMOPEC)36)
				{
					PurchaseManagerBridge.EHBBFMCILPC.CMJKNNFMCBM().Initialize();
					AOBJLALDBAA.CEGAOMEEFBE().LPNCDPHNBJK("spld", 134f);
					CommonUserInterface.IKNOFBFMPGA().GetFader().FadeIn(new TweenCallback(this.MDBDKBEANOJ));
					return;
				}
				if (this.rewardType == CMCMEJMOPEC.rewardFirstEpisode)
				{
					AOBJLALDBAA.CEGAOMEEFBE().EGELHPJBAIC("", 407f);
					AOBJLALDBAA.BIAEAOMHBMM().EGELHPJBAIC("RequestGetUserPublicProfile(): Account.Instance.userPublicProfile.modified", 1439f);
					return;
				}
				if (this.rewardType == CMCMEJMOPEC.rewardReplayEpisode)
				{
					AOBJLALDBAA.EHBBFMCILPC.KMAGHMCCMPG("lo", 534f);
					AOBJLALDBAA.FILDBDMENPG().FDKBIBKABCM("<i>", 1785f);
					return;
				}
				if (this.rewardType == CMCMEJMOPEC.rewardReplayEpisode)
				{
					AOBJLALDBAA.BIAEAOMHBMM().KGIKHEDLPND("sprite", 474f);
					AOBJLALDBAA.EHBBFMCILPC.KMAGHMCCMPG("ip", 1087f);
					return;
				}
				if (this.rewardType == CMCMEJMOPEC.rewardSubsequentEpisode)
				{
					AOBJLALDBAA.CEGAOMEEFBE().EGELHPJBAIC("lobby", 1425f);
					AOBJLALDBAA.KKPFOJMAONG().DCGCFPHHDDG("OnSketchThumbnailEditTitle", 149f);
					return;
				}
				if (this.rewardType == CMCMEJMOPEC.rewardFreeDiamonds)
				{
					AOBJLALDBAA.FILDBDMENPG().EGELHPJBAIC("@", 1868f);
					AOBJLALDBAA.AGANFKKBPFO().KMAGHMCCMPG("player", 1011f);
					return;
				}
				if (this.rewardType == CMCMEJMOPEC.rewardFreeDiamonds)
				{
					if (RewardOption.hardAdCanBeWatched)
					{
						AOBJLALDBAA.FILDBDMENPG().EFBNBFIDEOK("id", 69f);
						AOBJLALDBAA.EHBBFMCILPC.DCGCFPHHDDG("\n", 679f);
						return;
					}
					AOBJLALDBAA.KKPFOJMAONG().KGIKHEDLPND("id", 1932f);
					return;
				}
				else if (this.rewardType == (CMCMEJMOPEC)(-98))
				{
					if (RewardOption.spinFireTime <= 0 || AKLFPGMDKLA.EHBBFMCILPC.ABGNIKKFFAC.HOJDOEDDIBD() > 1)
					{
						AOBJLALDBAA.CEGAOMEEFBE().EFBNBFIDEOK("\n\n", 1192f);
						AOBJLALDBAA.FILDBDMENPG().EFBNBFIDEOK("XXX", 1906f);
						return;
					}
					AOBJLALDBAA.EHBBFMCILPC.EFBNBFIDEOK("app42error", 1349f);
					return;
				}
				else if (this.rewardType == CMCMEJMOPEC.rewardFirstEpisode)
				{
					if (RewardOption.dailyRewardFireTime > 0)
					{
						CommonUserInterface.EHBBFMCILPC.NFBMHHPIGFA(CCOJBMMKNAP.COKDLDOAACJ().FIENAKIHNOM("areyousure"), CCOJBMMKNAP.OBOOKJPGBJN().PGKBCNBAOJN("SceneLobbyManager.UpdateAnthologiesHints() - exception when adding anthology based on (add last 3 played anthologies):"), CCOJBMMKNAP.KFAABHHGOPO().BDGPNPNIAPA("skinshopinfotimeddiscount"), (DFGILFBGPLN)(-116), 1585f, -98);
						return;
					}
					ApplicationFocusManager.AGANFKKBPFO().ForceBasicSync();
					return;
				}
				else
				{
					DPGJIJGOCIC.ANOPFDLPKGC("guaranteedcarddrophint" + this.rewardType.ToString() + "");
				}
			}
			return;
		}
		if (LanguageManager.EHBBFMCILPC.MLOLBFBODHD() == CEIBHCNNIDC.en)
		{
			Application.OpenURL(AssetsManager.EHBBFMCILPC.lobbyDataAsset.newsletterSignUpRu);
			return;
		}
		Application.OpenURL(AssetsManager.EHBBFMCILPC.lobbyDataAsset.newsletterSignUpEn);
	}

	// Token: 0x06007A24 RID: 31268 RVA: 0x00368925 File Offset: 0x00366B25
	private void ANPIDDAIALE()
	{
		if (LanguageManager.EHBBFMCILPC.GetSelectedLanguage() == CEIBHCNNIDC.ru || LanguageManager.EHBBFMCILPC.GetSelectedLanguage() == CEIBHCNNIDC.en)
		{
			this.textTitle.fontSizeMax = 1149f;
			return;
		}
		this.textTitle.fontSizeMax = 1377f;
	}

	// Token: 0x06007A25 RID: 31269 RVA: 0x00368964 File Offset: 0x00366B64
	private void AMLICNPKJNO()
	{
		base.StartCoroutine(this.DHBLONGMJCA(this.textLayout.GetComponent<RectTransform>()));
		if (this.customTextDescriptionStringIndexClient >= 0)
		{
			string kegbcgmjolc = CCOJBMMKNAP.LMCCLMFGEBD().EDADDMHFLOL(this.customTextDescriptionStringIndexClient);
			this.textDescription.text = this.BGFDNHKMHPE(kegbcgmjolc);
			this.textDescription.SetText(this.DLIBEAJOCLB(kegbcgmjolc), true);
		}
	}

	// Token: 0x06007A26 RID: 31270 RVA: 0x003689C8 File Offset: 0x00366BC8
	private IEnumerator LKKLIOGPIPG(RectTransform DGAAFGDHHHJ)
	{
		yield return new WaitForEndOfFrame();
		LayoutRebuilder.ForceRebuildLayoutImmediate(DGAAFGDHHHJ);
		yield break;
	}

	// Token: 0x06007A27 RID: 31271 RVA: 0x003689D8 File Offset: 0x00366BD8
	public void OnActionClick()
	{
		if (this.rewardType != CMCMEJMOPEC.rewardNewsletterSubscribe)
		{
			if (this.rewardType != CMCMEJMOPEC.rewardNewsletterUnsubscribe)
			{
				if (this.rewardType == CMCMEJMOPEC.rewardDiamondRush)
				{
					CommonUserInterface.EHBBFMCILPC.ShowSocialSelect();
					return;
				}
				if (this.rewardType == CMCMEJMOPEC.rewardShoppingDay)
				{
					CommonUserInterface.EHBBFMCILPC.ShowSocialSelect();
					return;
				}
				if (this.rewardType == CMCMEJMOPEC.rewardTeaParty)
				{
					CommonUserInterface.EHBBFMCILPC.ShowSocialSelect();
					return;
				}
				if (this.rewardType == CMCMEJMOPEC.rewardPromoCodes)
				{
					CommonUserInterface.EHBBFMCILPC.ShowPopupPromoCodes();
					return;
				}
				if (this.rewardType == CMCMEJMOPEC.rewardFreePass)
				{
					CommonUserInterface.EHBBFMCILPC.ShowConnectingAnimation(96);
					BackendOperationsManager.EHBBFMCILPC.RequestStartFreePass(this.extraData, "OnStartFreePassSuccess", "OnStartFreePassException");
					return;
				}
				if (this.rewardType == CMCMEJMOPEC.rewardOffer)
				{
					PurchaseManagerBridge.EHBBFMCILPC.GetPurchaseManager().Initialize();
					AOBJLALDBAA.EHBBFMCILPC.EGELHPJBAIC("OnRewardsItemClose", 0f);
					CommonUserInterface.EHBBFMCILPC.GetFader().FadeIn(new TweenCallback(this.EOOPGNHJCGD));
					return;
				}
				if (this.rewardType == CMCMEJMOPEC.rewardAchievements)
				{
					AOBJLALDBAA.EHBBFMCILPC.EGELHPJBAIC("OnRewardsItemClose", 0f);
					AOBJLALDBAA.EHBBFMCILPC.EGELHPJBAIC("OnRewardOptionProfileClick", 0.15f);
					return;
				}
				if (this.rewardType == CMCMEJMOPEC.rewardFirstEpisode)
				{
					AOBJLALDBAA.EHBBFMCILPC.EGELHPJBAIC("OnRewardsItemClose", 0f);
					AOBJLALDBAA.EHBBFMCILPC.EGELHPJBAIC("OnRewardFirstEpisodeClick", 0.15f);
					return;
				}
				if (this.rewardType == CMCMEJMOPEC.rewardSubsequentEpisode)
				{
					AOBJLALDBAA.EHBBFMCILPC.EGELHPJBAIC("OnRewardsItemClose", 0f);
					AOBJLALDBAA.EHBBFMCILPC.EGELHPJBAIC("OnRewardSubsequentEpisodeClick", 0.15f);
					return;
				}
				if (this.rewardType == CMCMEJMOPEC.rewardReplayEpisode)
				{
					AOBJLALDBAA.EHBBFMCILPC.EGELHPJBAIC("OnRewardsItemClose", 0f);
					AOBJLALDBAA.EHBBFMCILPC.EGELHPJBAIC("OnRewardReplayEpisodeClick", 0.15f);
					return;
				}
				if (this.rewardType == CMCMEJMOPEC.rewardStoryComplete)
				{
					AOBJLALDBAA.EHBBFMCILPC.EGELHPJBAIC("OnRewardsItemClose", 0f);
					AOBJLALDBAA.EHBBFMCILPC.EGELHPJBAIC("OnRewardStoryCompleteClick", 0.15f);
					return;
				}
				if (this.rewardType == CMCMEJMOPEC.rewardFreeDiamonds)
				{
					if (RewardOption.hardAdCanBeWatched)
					{
						AOBJLALDBAA.EHBBFMCILPC.EGELHPJBAIC("OnRewardsItemClose", 0f);
						AOBJLALDBAA.EHBBFMCILPC.EGELHPJBAIC("OnRewardFreeDiamondsClick", 0.15f);
						return;
					}
					AOBJLALDBAA.EHBBFMCILPC.EGELHPJBAIC("OnRewardFreeDiamondsClick", 0f);
					return;
				}
				else if (this.rewardType == CMCMEJMOPEC.rewardSpinWheel)
				{
					if (RewardOption.spinFireTime <= 0 || AKLFPGMDKLA.EHBBFMCILPC.ABGNIKKFFAC.GALKFKBPLCK() > 0)
					{
						AOBJLALDBAA.EHBBFMCILPC.EGELHPJBAIC("OnRewardsItemClose", 0f);
						AOBJLALDBAA.EHBBFMCILPC.EGELHPJBAIC("OnRewardFreeSpinsClick", 0.15f);
						return;
					}
					AOBJLALDBAA.EHBBFMCILPC.EGELHPJBAIC("OnRewardFreeSpinsClick", 0f);
					return;
				}
				else if (this.rewardType == CMCMEJMOPEC.rewardDailyLogin)
				{
					if (RewardOption.dailyRewardFireTime > 0)
					{
						CommonUserInterface.EHBBFMCILPC.ShowGenericPopup(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("energyhinttitle"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("newrewardsdailywaiting"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("ok"), DFGILFBGPLN.popupIncentAd0Failed, 0f, 28);
						return;
					}
					ApplicationFocusManager.EHBBFMCILPC.ForceBasicSync();
					return;
				}
				else
				{
					DPGJIJGOCIC.ANOPFDLPKGC("RewardOption.OnActionClick() - rewardType " + this.rewardType.ToString() + " not implemented.");
				}
			}
			return;
		}
		if (LanguageManager.EHBBFMCILPC.GetSelectedLanguage() == CEIBHCNNIDC.ru)
		{
			Application.OpenURL(AssetsManager.EHBBFMCILPC.lobbyDataAsset.newsletterSignUpRu);
			return;
		}
		Application.OpenURL(AssetsManager.EHBBFMCILPC.lobbyDataAsset.newsletterSignUpEn);
	}

	// Token: 0x06007A28 RID: 31272 RVA: 0x003689C8 File Offset: 0x00366BC8
	private IEnumerator LPBCLJDDHGH(RectTransform DGAAFGDHHHJ)
	{
		yield return new WaitForEndOfFrame();
		LayoutRebuilder.ForceRebuildLayoutImmediate(DGAAFGDHHHJ);
		yield break;
	}

	// Token: 0x06007A29 RID: 31273 RVA: 0x00368D30 File Offset: 0x00366F30
	public void KAHDNDMCPDC()
	{
		if (this.rewardType != (CMCMEJMOPEC)21)
		{
			if (this.rewardType != (CMCMEJMOPEC)25)
			{
				if (this.rewardType == CMCMEJMOPEC.rewardReplayEpisode)
				{
					CommonUserInterface.IKNOFBFMPGA().ShowSocialSelect();
					return;
				}
				if (this.rewardType == (CMCMEJMOPEC)78)
				{
					CommonUserInterface.IKNOFBFMPGA().DJBLEEEEGOL();
					return;
				}
				if (this.rewardType == (CMCMEJMOPEC)33)
				{
					CommonUserInterface.EHBBFMCILPC.ShowSocialSelect();
					return;
				}
				if (this.rewardType == (CMCMEJMOPEC)69)
				{
					CommonUserInterface.EHBBFMCILPC.ShowPopupPromoCodes();
					return;
				}
				if (this.rewardType == (CMCMEJMOPEC)59)
				{
					CommonUserInterface.IKNOFBFMPGA().ShowConnectingAnimation((byte)-70);
					BackendOperationsManager.EHBBFMCILPC.GOMFBGEMJKL(this.extraData, "/", "\n");
					return;
				}
				if (this.rewardType == (CMCMEJMOPEC)74)
				{
					PurchaseManagerBridge.EHBBFMCILPC.MGMDKEJBEPP().Initialize();
					AOBJLALDBAA.KKPFOJMAONG().KGIKHEDLPND("spld", 335f);
					CommonUserInterface.EHBBFMCILPC.GetFader().FadeIn(new TweenCallback(this.OECKPNCHMNO));
					return;
				}
				if (this.rewardType == CMCMEJMOPEC.rewardFreeTea)
				{
					AOBJLALDBAA.CEGAOMEEFBE().EFBNBFIDEOK("", 9f);
					AOBJLALDBAA.FILDBDMENPG().LPNCDPHNBJK("+", 309f);
					return;
				}
				if (this.rewardType == CMCMEJMOPEC.rewardFreeDiamonds)
				{
					AOBJLALDBAA.AGANFKKBPFO().CIGLHCJDDPI("OnStoryChoiceClick", 764f);
					AOBJLALDBAA.EHBBFMCILPC.LPNCDPHNBJK("", 485f);
					return;
				}
				if (this.rewardType == CMCMEJMOPEC.rewardFreeDiamonds)
				{
					AOBJLALDBAA.AGANFKKBPFO().KGIKHEDLPND(" (bonus now ", 941f);
					AOBJLALDBAA.CEGAOMEEFBE().KMAGHMCCMPG("YourStory/FlagShadow", 1852f);
					return;
				}
				if (this.rewardType == CMCMEJMOPEC.rewardAchievements)
				{
					AOBJLALDBAA.EHBBFMCILPC.CIGLHCJDDPI("ok", 653f);
					AOBJLALDBAA.EHBBFMCILPC.CIGLHCJDDPI("onFriendsPopupOpenMessageHistory", 331f);
					return;
				}
				if (this.rewardType == CMCMEJMOPEC.rewardFreeDiamonds)
				{
					AOBJLALDBAA.BIAEAOMHBMM().FDKBIBKABCM("Starting parallel download:", 1151f);
					AOBJLALDBAA.AGANFKKBPFO().EFBNBFIDEOK("<b>", 1082f);
					return;
				}
				if (this.rewardType == CMCMEJMOPEC.rewardFreeTea)
				{
					if (RewardOption.hardAdCanBeWatched)
					{
						AOBJLALDBAA.KKPFOJMAONG().KGIKHEDLPND("comsc2", 1067f);
						AOBJLALDBAA.KKPFOJMAONG().EFBNBFIDEOK("importanttitle", 834f);
						return;
					}
					AOBJLALDBAA.BIAEAOMHBMM().DCGCFPHHDDG("ltwt", 230f);
					return;
				}
				else if (this.rewardType == (CMCMEJMOPEC)118)
				{
					if (RewardOption.spinFireTime <= 0 || AKLFPGMDKLA.EHBBFMCILPC.ABGNIKKFFAC.KGEGKPHEMOJ() > 1)
					{
						AOBJLALDBAA.DBLAIDPICIG().KMAGHMCCMPG("invalid registry entry", 1552f);
						AOBJLALDBAA.AGANFKKBPFO().FDKBIBKABCM("OnContinueToSendSimpleMessage", 1870f);
						return;
					}
					AOBJLALDBAA.FILDBDMENPG().DCGCFPHHDDG(") asset(", 1525f);
					return;
				}
				else if (this.rewardType == CMCMEJMOPEC.rewardDailyLogin)
				{
					if (RewardOption.dailyRewardFireTime > 1)
					{
						CommonUserInterface.EHBBFMCILPC.ShowGenericPopup(CCOJBMMKNAP.PEBMGCKFNAO().DNILNCLIHAP("ok"), CCOJBMMKNAP.HEDIEIICOOG().JHNELLJFBGC(""), CCOJBMMKNAP.MLFAGAAJJEM().BGELFMIOBCL(""), DFGILFBGPLN.screenOnboarding, 718f, 110);
						return;
					}
					ApplicationFocusManager.AGANFKKBPFO().ForceBasicSync();
					return;
				}
				else
				{
					DPGJIJGOCIC.ANOPFDLPKGC("onLoadingThemeSubscribeRequested" + this.rewardType.ToString() + "");
				}
			}
			return;
		}
		if (LanguageManager.EHBBFMCILPC.MLOLBFBODHD() == CEIBHCNNIDC.ru)
		{
			Application.OpenURL(AssetsManager.MJBDMHPHMID().lobbyDataAsset.newsletterSignUpRu);
			return;
		}
		Application.OpenURL(AssetsManager.MJBDMHPHMID().lobbyDataAsset.newsletterSignUpEn);
	}

	// Token: 0x06007A2A RID: 31274 RVA: 0x00369088 File Offset: 0x00367288
	private void PKCHKBAPBKF()
	{
		AOBJLALDBAA.DBLAIDPICIG().LPNCDPHNBJK("cut", 1091f);
		if (LanguageManager.EHBBFMCILPC.MLOLBFBODHD() == CEIBHCNNIDC.en && GeoLocationManager.PBAGPDDBABB() && KDCJJBLGCBH.EHBBFMCILPC.POGBNANIKCA())
		{
			CommonUserInterface.EHBBFMCILPC.GetPurchasingViewManager().MLANIKPFIMA(false);
			return;
		}
		CommonUserInterface.IKNOFBFMPGA().GetPurchasingViewManager().ShowAndPurchaseProduct(this.extraData, false);
	}

	// Token: 0x06007A2B RID: 31275 RVA: 0x003690F0 File Offset: 0x003672F0
	public void GENCHMHFBHE()
	{
		if (this.rewardType != (CMCMEJMOPEC)(-47))
		{
			if (this.rewardType != (CMCMEJMOPEC)(-25))
			{
				if (this.rewardType == CMCMEJMOPEC.rewardAchievements)
				{
					CommonUserInterface.EHBBFMCILPC.ShowSocialSelect();
					return;
				}
				if (this.rewardType == (CMCMEJMOPEC)(-42))
				{
					CommonUserInterface.IKNOFBFMPGA().ShowSocialSelect();
					return;
				}
				if (this.rewardType == (CMCMEJMOPEC)86)
				{
					CommonUserInterface.EHBBFMCILPC.ShowSocialSelect();
					return;
				}
				if (this.rewardType == (CMCMEJMOPEC)66)
				{
					CommonUserInterface.EHBBFMCILPC.ShowPopupPromoCodes();
					return;
				}
				if (this.rewardType == (CMCMEJMOPEC)(-47))
				{
					CommonUserInterface.EHBBFMCILPC.ShowConnectingAnimation(116);
					BackendOperationsManager.NPDDBAONMJP().GOMFBGEMJKL(this.extraData, "abs", "Account.SRAInitialize(), exception:");
					return;
				}
				if (this.rewardType == (CMCMEJMOPEC)(-91))
				{
					PurchaseManagerBridge.EHBBFMCILPC.PFPKMDAJDBA().Initialize();
					AOBJLALDBAA.FILDBDMENPG().DCGCFPHHDDG("the last bundle of the chain carries no scene", 753f);
					CommonUserInterface.IKNOFBFMPGA().GetFader().BJIGLKGLAKM(new TweenCallback(this.LPHKPADFMCI));
					return;
				}
				if (this.rewardType == CMCMEJMOPEC.rewardFreeTea)
				{
					AOBJLALDBAA.FILDBDMENPG().KMAGHMCCMPG("NEWSAVE: Warning: Missing anthology save data, yet story save data (", 465f);
					AOBJLALDBAA.EHBBFMCILPC.KGIKHEDLPND("OnSketchThumbnailsCdnFailed", 807f);
					return;
				}
				if (this.rewardType == CMCMEJMOPEC.rewardFreeTea)
				{
					AOBJLALDBAA.DBLAIDPICIG().FDKBIBKABCM("sfxsparklesbundles", 1605f);
					AOBJLALDBAA.AGANFKKBPFO().DCGCFPHHDDG(") title(", 484f);
					return;
				}
				if (this.rewardType == CMCMEJMOPEC.rewardSubsequentEpisode)
				{
					AOBJLALDBAA.FILDBDMENPG().DCGCFPHHDDG("", 551f);
					AOBJLALDBAA.FILDBDMENPG().DCGCFPHHDDG("thmstr", 838f);
					return;
				}
				if (this.rewardType == CMCMEJMOPEC.rewardReplayEpisode)
				{
					AOBJLALDBAA.DBLAIDPICIG().KGIKHEDLPND("update", 828f);
					AOBJLALDBAA.EHBBFMCILPC.CIGLHCJDDPI("sindp", 644f);
					return;
				}
				if (this.rewardType == CMCMEJMOPEC.rewardFreeTea)
				{
					AOBJLALDBAA.CEGAOMEEFBE().KMAGHMCCMPG("،", 1485f);
					AOBJLALDBAA.EHBBFMCILPC.DCGCFPHHDDG("", 1378f);
					return;
				}
				if (this.rewardType == CMCMEJMOPEC.rewardFreeDiamonds)
				{
					if (RewardOption.hardAdCanBeWatched)
					{
						AOBJLALDBAA.NMGMNAKLLMI().DCGCFPHHDDG("BackendOperationsManager.RequestUnlockCardsVolume, exception while initializing RSACryptoServiceProvider:", 1840f);
						AOBJLALDBAA.KKPFOJMAONG().FDKBIBKABCM("Starting non-parallel download:", 1810f);
						return;
					}
					AOBJLALDBAA.CEGAOMEEFBE().LPNCDPHNBJK("", 781f);
					return;
				}
				else if (this.rewardType == (CMCMEJMOPEC)20)
				{
					if (RewardOption.spinFireTime <= 0 || AKLFPGMDKLA.EHBBFMCILPC.ABGNIKKFFAC.PONAPMOOLIN() > 0)
					{
						AOBJLALDBAA.BIAEAOMHBMM().DCGCFPHHDDG("Starting non-parallel download:", 1449f);
						AOBJLALDBAA.DBLAIDPICIG().EGELHPJBAIC("hintsaving", 816f);
						return;
					}
					AOBJLALDBAA.BIAEAOMHBMM().EFBNBFIDEOK("continue", 1046f);
					return;
				}
				else if (this.rewardType == CMCMEJMOPEC.rewardAchievements)
				{
					if (RewardOption.dailyRewardFireTime > 0)
					{
						CommonUserInterface.EHBBFMCILPC.ShowGenericPopup(CCOJBMMKNAP.INKJIBDDMLL().HPOAGPJFHPM(" not found."), CCOJBMMKNAP.KMNBCEMEBBD().PKNHKGMNCIP("AssetsManagerUtils.GetEnvironmentIdForCardBodyVariation(), CardsBalance is not initialized."), CCOJBMMKNAP.CPCOODCFDDP().GGPHHLGPMPA("yes"), (DFGILFBGPLN)105, 1757f, 67);
						return;
					}
					ApplicationFocusManager.EHBBFMCILPC.ForceBasicSync();
					return;
				}
				else
				{
					DPGJIJGOCIC.ANOPFDLPKGC("serversync" + this.rewardType.ToString() + "ec");
				}
			}
			return;
		}
		if (LanguageManager.EHBBFMCILPC.NBANPEIHFOJ() == CEIBHCNNIDC.ru)
		{
			Application.OpenURL(AssetsManager.MJBDMHPHMID().lobbyDataAsset.newsletterSignUpRu);
			return;
		}
		Application.OpenURL(AssetsManager.EHBBFMCILPC.lobbyDataAsset.newsletterSignUpEn);
	}

	// Token: 0x06007A2C RID: 31276 RVA: 0x00369445 File Offset: 0x00367645
	private void APLBAENGMJH()
	{
		if (LanguageManager.EHBBFMCILPC.NBANPEIHFOJ() == CEIBHCNNIDC.en || LanguageManager.EHBBFMCILPC.IEBFINIJAMJ() == CEIBHCNNIDC.en)
		{
			this.textTitle.fontSizeMax = 1361f;
			return;
		}
		this.textTitle.fontSizeMax = 63f;
	}

	// Token: 0x06007A2D RID: 31277 RVA: 0x00369484 File Offset: 0x00367684
	public void LCALOJBCCGD()
	{
		if (this.rewardType == (CMCMEJMOPEC)(-30))
		{
			try
			{
				SceneLobbyManager2.freePlayPassAnthologyIndex = int.Parse(this.extraData);
				AOBJLALDBAA.FILDBDMENPG().EFBNBFIDEOK("profilenametitleshort", 1680f);
				AOBJLALDBAA.KKPFOJMAONG().LPNCDPHNBJK("", 1196f);
				return;
			}
			catch (Exception aklgbjkdomm)
			{
				SceneLobbyManager2.freePlayPassAnthologyIndex = -1;
				DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
				return;
			}
		}
		DPGJIJGOCIC.ANOPFDLPKGC("socialcollectedcardopenv2" + this.rewardType.ToString() + "stat5long");
	}

	// Token: 0x06007A2E RID: 31278 RVA: 0x00369518 File Offset: 0x00367718
	private void MADHLGLFNNN()
	{
		base.StartCoroutine(this.LMMLDNBEFPC(this.textLayout.GetComponent<RectTransform>()));
		if (this.customTextDescriptionStringIndexClient >= 0)
		{
			string kegbcgmjolc = CCOJBMMKNAP.HEDIEIICOOG().DJFKLMBAHJA(this.customTextDescriptionStringIndexClient);
			this.textDescription.text = this.DLIBEAJOCLB(kegbcgmjolc);
			this.textDescription.SetText(this.EMLPPCDOAFP(kegbcgmjolc), true);
		}
	}

	// Token: 0x06007A2F RID: 31279 RVA: 0x0036957C File Offset: 0x0036777C
	private void EOOPGNHJCGD()
	{
		AOBJLALDBAA.EHBBFMCILPC.EGELHPJBAIC("OnPopupOfferManagerContinueToPurchasingScreen", 0f);
		if (LanguageManager.EHBBFMCILPC.GetSelectedLanguage() == CEIBHCNNIDC.ru && GeoLocationManager.IsRussia() && KDCJJBLGCBH.EHBBFMCILPC.POGBNANIKCA())
		{
			CommonUserInterface.EHBBFMCILPC.GetPurchasingViewManager().Show(false);
			return;
		}
		CommonUserInterface.EHBBFMCILPC.GetPurchasingViewManager().ShowAndPurchaseProduct(this.extraData, true);
	}

	// Token: 0x06007A30 RID: 31280 RVA: 0x003695E4 File Offset: 0x003677E4
	private string GGGLOBDGHIK(string KEGBCGMJOLC)
	{
		string text = KEGBCGMJOLC;
		if (this.rewardType == (CMCMEJMOPEC)103)
		{
			OBHDGKFFICI productData = PurchaseManagerBridge.IDMLJFBNHML().DOMEKEJELKB().GetProductData(this.extraData);
			OCBIOPOEENJ ocbiopoeenj = CJEKEHDEBLM.BBGECIKOICE().PDJKPFLHFLO(this.extraData);
			if (ocbiopoeenj != null && productData != null)
			{
				string newValue;
				if (ocbiopoeenj.IMKLGJBEMPH())
				{
					newValue = ocbiopoeenj.ILAPDGNDFGC();
				}
				else
				{
					newValue = "OnFriendsCurrencyPopupCollect" + ocbiopoeenj.DMODNDCLGEJ;
				}
				text = text.Replace("", ocbiopoeenj.MPMKMCJFHOG.ToString());
				text = text.Replace("comcc2", ocbiopoeenj.ODMKLADKHMO.ToString());
				text = text.Replace("' key='", newValue);
			}
			else
			{
				DPGJIJGOCIC.ANOPFDLPKGC("Starting non-parallel download:");
			}
		}
		else if (this.rewardType == CMCMEJMOPEC.rewardFirstEpisode)
		{
			text = text.Replace("OnSpinsUnlockContinueToPurchasingScreen", KDCJJBLGCBH.EHBBFMCILPC.PPKDBCLAGOG().ToString() ?? "OnFriendsPopupManagerAcceptClick");
		}
		else if (this.rewardType == CMCMEJMOPEC.rewardAchievements)
		{
			text = text.Replace("OnBackendGetDropChancesSuccess2", KDCJJBLGCBH.EHBBFMCILPC.PLOMCENKKFD(ODLJHDIGLGO.MNALIKIMKFC(CLHDENLPOFP.eventPass, false)).ToString() ?? "continue");
			text = text.Replace("0.00", this.KKEDNJIJECI(1).ToString() ?? "stat6long");
		}
		else if (this.rewardType == CMCMEJMOPEC.rewardAchievements)
		{
			text = text.Replace("socialsendpremcardmissuidornick", KDCJJBLGCBH.EHBBFMCILPC.HHCMJBBEAKO().ToString() ?? "s]");
			text = text.Replace("yes", this.HHPPEAGBLBL(0).ToString() ?? "Starting parallel download:");
		}
		else if (this.rewardType == CMCMEJMOPEC.rewardDailyLogin)
		{
			text = text.Replace("   ", KDCJJBLGCBH.EHBBFMCILPC.IEBEBBNMEIN().ToString() ?? "ii");
		}
		else if (this.rewardType == CMCMEJMOPEC.rewardFreeDiamonds)
		{
			text = text.Replace("OnBackendGetPublicProfileHallOfFameSuccess", this.DDLFLNDOABO(1).ToString() ?? "");
		}
		else if (this.rewardType == (CMCMEJMOPEC)(-124))
		{
			text = text.Replace("", DPGJIJGOCIC.CEOBDMGAKNL(KDCJJBLGCBH.EHBBFMCILPC.ADLOIIMBHAG(ODLJHDIGLGO.BCGOGCFOHJK(CLHDENLPOFP.eventPass, false))) ?? "،");
		}
		else if (this.rewardType == CMCMEJMOPEC.rewardFreeTea)
		{
			text = text.Replace("Speed", DPGJIJGOCIC.CEOBDMGAKNL(KDCJJBLGCBH.EHBBFMCILPC.PFIONLJNAPB(ODLJHDIGLGO.EEJHIEBIPPM(CLHDENLPOFP.gamePass, true))) ?? "OnSketchThumbnailDuplicatePositive");
		}
		return text;
	}

	// Token: 0x06007A31 RID: 31281 RVA: 0x00369862 File Offset: 0x00367A62
	private void MFLCLDAGFNK()
	{
		this.CPGLEJIBNEP = RewardOption.CBOKJGNCEKE + 776f;
	}

	// Token: 0x06007A32 RID: 31282 RVA: 0x00369875 File Offset: 0x00367A75
	private void IJIDLNOIHCD()
	{
		if (LanguageManager.EHBBFMCILPC.IEBFINIJAMJ() == CEIBHCNNIDC.en || LanguageManager.EHBBFMCILPC.MLOLBFBODHD() == CEIBHCNNIDC.en)
		{
			this.textTitle.fontSizeMax = 527f;
			return;
		}
		this.textTitle.fontSizeMax = 891f;
	}

	// Token: 0x06007A33 RID: 31283 RVA: 0x003698B1 File Offset: 0x00367AB1
	private void Awake()
	{
		if (LanguageManager.EHBBFMCILPC.GetSelectedLanguage() == CEIBHCNNIDC.ru || LanguageManager.EHBBFMCILPC.GetSelectedLanguage() == CEIBHCNNIDC.en)
		{
			this.textTitle.fontSizeMax = 32f;
			return;
		}
		this.textTitle.fontSizeMax = 30f;
	}

	// Token: 0x06007A34 RID: 31284 RVA: 0x003698F0 File Offset: 0x00367AF0
	public void PJEDOGIMEHP()
	{
		if (this.rewardType != (CMCMEJMOPEC)(-35))
		{
			if (this.rewardType != (CMCMEJMOPEC)32)
			{
				if (this.rewardType == CMCMEJMOPEC.rewardDiamondRush)
				{
					CommonUserInterface.IKNOFBFMPGA().DJBLEEEEGOL();
					return;
				}
				if (this.rewardType == (CMCMEJMOPEC)38)
				{
					CommonUserInterface.EHBBFMCILPC.KPAIHLBPFMJ();
					return;
				}
				if (this.rewardType == (CMCMEJMOPEC)(-23))
				{
					CommonUserInterface.EHBBFMCILPC.KPAIHLBPFMJ();
					return;
				}
				if (this.rewardType == (CMCMEJMOPEC)(-30))
				{
					CommonUserInterface.EHBBFMCILPC.ShowPopupPromoCodes();
					return;
				}
				if (this.rewardType == (CMCMEJMOPEC)(-36))
				{
					CommonUserInterface.EHBBFMCILPC.ShowConnectingAnimation((byte)-36);
					BackendOperationsManager.NPDDBAONMJP().GOMFBGEMJKL(this.extraData, "releasedchapterscount", "OnPassesItemClose");
					return;
				}
				if (this.rewardType == (CMCMEJMOPEC)(-76))
				{
					PurchaseManagerBridge.OOGPALHPNGM().PFPKMDAJDBA().Initialize();
					AOBJLALDBAA.DBLAIDPICIG().LPNCDPHNBJK("season", 1132f);
					CommonUserInterface.EHBBFMCILPC.GetFader().PACBMBLIGNN(new TweenCallback(this.ODNBEODOOJE));
					return;
				}
				if (this.rewardType == CMCMEJMOPEC.rewardDiamondRush)
				{
					AOBJLALDBAA.BIAEAOMHBMM().CIGLHCJDDPI("", 1698f);
					AOBJLALDBAA.AGANFKKBPFO().KGIKHEDLPND("Character ", 776f);
					return;
				}
				if (this.rewardType == CMCMEJMOPEC.rewardReplayEpisode)
				{
					AOBJLALDBAA.BIAEAOMHBMM().EFBNBFIDEOK("ind", 518f);
					AOBJLALDBAA.NMGMNAKLLMI().DCGCFPHHDDG("$USEITEM", 1911f);
					return;
				}
				if (this.rewardType == CMCMEJMOPEC.rewardFreeDiamonds)
				{
					AOBJLALDBAA.EHBBFMCILPC.KMAGHMCCMPG(" ", 220f);
					AOBJLALDBAA.DBLAIDPICIG().EGELHPJBAIC("", 1135f);
					return;
				}
				if (this.rewardType == CMCMEJMOPEC.rewardFreeDiamonds)
				{
					AOBJLALDBAA.DBLAIDPICIG().EGELHPJBAIC("%", 857f);
					AOBJLALDBAA.KKPFOJMAONG().KGIKHEDLPND("Error. MoveEnvironment(), environment ", 585f);
					return;
				}
				if (this.rewardType == CMCMEJMOPEC.rewardAchievements)
				{
					AOBJLALDBAA.NMGMNAKLLMI().CIGLHCJDDPI("passinfobtntitle", 477f);
					AOBJLALDBAA.NMGMNAKLLMI().FDKBIBKABCM(", ", 1289f);
					return;
				}
				if (this.rewardType == CMCMEJMOPEC.rewardFreeDiamonds)
				{
					if (RewardOption.hardAdCanBeWatched)
					{
						AOBJLALDBAA.BIAEAOMHBMM().KGIKHEDLPND(" <i>", 1365f);
						AOBJLALDBAA.DBLAIDPICIG().KMAGHMCCMPG("loungenotavailable", 1954f);
						return;
					}
					AOBJLALDBAA.AGANFKKBPFO().KMAGHMCCMPG("OnBackendValidateTransactionFailed", 525f);
					return;
				}
				else if (this.rewardType == (CMCMEJMOPEC)(-52))
				{
					if (RewardOption.spinFireTime <= 1 || AKLFPGMDKLA.EHBBFMCILPC.ABGNIKKFFAC.BFMPOACOBPN() > 0)
					{
						AOBJLALDBAA.EHBBFMCILPC.DCGCFPHHDDG("apkshe1", 402f);
						AOBJLALDBAA.CEGAOMEEFBE().LPNCDPHNBJK("DialogItemUsedManager.Initialize() - storyItem is null.", 790f);
						return;
					}
					AOBJLALDBAA.KKPFOJMAONG().DCGCFPHHDDG("uid", 1917f);
					return;
				}
				else if (this.rewardType == CMCMEJMOPEC.rewardDailyLogin)
				{
					if (RewardOption.dailyRewardFireTime > 0)
					{
						CommonUserInterface.EHBBFMCILPC.NFBMHHPIGFA(CCOJBMMKNAP.MPCBJEIMACA().BGELFMIOBCL("OnStartFreePassException"), CCOJBMMKNAP.AEELGGPEJCC().PPALCPINPLK("/"), CCOJBMMKNAP.AEELGGPEJCC().PGKBCNBAOJN("needtorestartgeneric"), DFGILFBGPLN.popupTutorialLobby1, 1451f, 78);
						return;
					}
					ApplicationFocusManager.AGANFKKBPFO().ForceBasicSync();
					return;
				}
				else
				{
					DPGJIJGOCIC.ANOPFDLPKGC("Asset bundle assets destroyed:" + this.rewardType.ToString() + "sto");
				}
			}
			return;
		}
		if (LanguageManager.EHBBFMCILPC.MLOLBFBODHD() == CEIBHCNNIDC.ru)
		{
			Application.OpenURL(AssetsManager.EHBBFMCILPC.lobbyDataAsset.newsletterSignUpRu);
			return;
		}
		Application.OpenURL(AssetsManager.MJBDMHPHMID().lobbyDataAsset.newsletterSignUpEn);
	}

	// Token: 0x06007A35 RID: 31285 RVA: 0x00369C48 File Offset: 0x00367E48
	private int KKEDNJIJECI(int MEFKFOHCOHK)
	{
		KIOOJMGLCLC kioojmglclc = ODLJHDIGLGO.MNALIKIMKFC(CLHDENLPOFP.gamePass);
		int num = 1;
		if (kioojmglclc != null && kioojmglclc.ALFGPLALKCN())
		{
			num = KDCJJBLGCBH.EHBBFMCILPC.AAGICPKFIKC(KDCJJBLGCBH.EHBBFMCILPC.HHONCLBBHPG(kioojmglclc.LLLJOBODOAL), DAMCJCDKOJK.gpbpIncentAdMultiplier, 1 == AKLFPGMDKLA.EHBBFMCILPC.DCIPLNCLIMF);
		}
		return KDCJJBLGCBH.EHBBFMCILPC.NEOIABIBJOI(MEFKFOHCOHK) * num;
	}

	// Token: 0x06007A36 RID: 31286 RVA: 0x00369CA0 File Offset: 0x00367EA0
	private void JEPDCCLFEJP()
	{
		CommonUserInterface.IKNOFBFMPGA().ShowConnectingAnimation(35);
		BackendOperationsManager.EHBBFMCILPC.RequestEmailUnsubscribe("skinshopinfosumavailable", ";");
	}

	// Token: 0x06007A37 RID: 31287 RVA: 0x00369CC2 File Offset: 0x00367EC2
	private void GMLJGEPKGBK()
	{
		CommonUserInterface.IKNOFBFMPGA().ShowConnectingAnimation((byte)-23);
		BackendOperationsManager.EHBBFMCILPC.RequestEmailUnsubscribe("$NPCPROPDISABLE", "OnChapterSnapshotsBackendFetchSuccess2");
	}

	// Token: 0x06007A38 RID: 31288 RVA: 0x00369CE4 File Offset: 0x00367EE4
	public void OECKMHCIKJH()
	{
		if (this.rewardType != (CMCMEJMOPEC)(-59))
		{
			if (this.rewardType != (CMCMEJMOPEC)22)
			{
				if (this.rewardType == CMCMEJMOPEC.rewardSubsequentEpisode)
				{
					CommonUserInterface.EHBBFMCILPC.KPAIHLBPFMJ();
					return;
				}
				if (this.rewardType == CMCMEJMOPEC.rewardFirstEpisode)
				{
					CommonUserInterface.IKNOFBFMPGA().ShowSocialSelect();
					return;
				}
				if (this.rewardType == (CMCMEJMOPEC)66)
				{
					CommonUserInterface.IKNOFBFMPGA().ShowSocialSelect();
					return;
				}
				if (this.rewardType == (CMCMEJMOPEC)60)
				{
					CommonUserInterface.EHBBFMCILPC.ShowPopupPromoCodes();
					return;
				}
				if (this.rewardType == (CMCMEJMOPEC)(-22))
				{
					CommonUserInterface.IKNOFBFMPGA().ShowConnectingAnimation((byte)-85);
					BackendOperationsManager.EHBBFMCILPC.GOMFBGEMJKL(this.extraData, "", "ok");
					return;
				}
				if (this.rewardType == (CMCMEJMOPEC)116)
				{
					PurchaseManagerBridge.IGJAMEGBDBG().PFPKMDAJDBA().Initialize();
					AOBJLALDBAA.FILDBDMENPG().LPNCDPHNBJK("", 420f);
					CommonUserInterface.EHBBFMCILPC.GetFader().PACBMBLIGNN(new TweenCallback(this.JOEGGDDACPM));
					return;
				}
				if (this.rewardType == CMCMEJMOPEC.rewardFreeTea)
				{
					AOBJLALDBAA.NMGMNAKLLMI().EGELHPJBAIC("{sp1}", 1653f);
					AOBJLALDBAA.EHBBFMCILPC.EFBNBFIDEOK("ok", 475f);
					return;
				}
				if (this.rewardType == CMCMEJMOPEC.rewardDailyLogin)
				{
					AOBJLALDBAA.CEGAOMEEFBE().DCGCFPHHDDG("hair", 1458f);
					AOBJLALDBAA.KKPFOJMAONG().LPNCDPHNBJK("OnSteamLoginSuccess", 934f);
					return;
				}
				if (this.rewardType == CMCMEJMOPEC.rewardStoryComplete)
				{
					AOBJLALDBAA.BIAEAOMHBMM().CIGLHCJDDPI("getCardVolumesBalance", 795f);
					AOBJLALDBAA.FILDBDMENPG().KGIKHEDLPND("SocialStatsUserPublicProfile.modified = false, OnAddFriendByProfileId()", 946f);
					return;
				}
				if (this.rewardType == CMCMEJMOPEC.rewardFreeTea)
				{
					AOBJLALDBAA.DBLAIDPICIG().LPNCDPHNBJK("lck", 160f);
					AOBJLALDBAA.BIAEAOMHBMM().EGELHPJBAIC("importanttitle", 49f);
					return;
				}
				if (this.rewardType == CMCMEJMOPEC.rewardFreeDiamonds)
				{
					AOBJLALDBAA.KKPFOJMAONG().LPNCDPHNBJK("ok", 1414f);
					AOBJLALDBAA.KKPFOJMAONG().KMAGHMCCMPG("NarrowScreenScaler(): applied a ", 1120f);
					return;
				}
				if (this.rewardType == CMCMEJMOPEC.rewardFreeDiamonds)
				{
					if (RewardOption.hardAdCanBeWatched)
					{
						AOBJLALDBAA.FILDBDMENPG().FDKBIBKABCM("OnSceneLobbyManagerAssetsDownloadFailed", 1284f);
						AOBJLALDBAA.DBLAIDPICIG().EGELHPJBAIC("skinshopinfolireq", 200f);
						return;
					}
					AOBJLALDBAA.BIAEAOMHBMM().CIGLHCJDDPI(")", 1588f);
					return;
				}
				else if (this.rewardType == (CMCMEJMOPEC)(-52))
				{
					if (RewardOption.spinFireTime <= 0 || AKLFPGMDKLA.EHBBFMCILPC.ABGNIKKFFAC.MDJHNAEGCCM() > 0)
					{
						AOBJLALDBAA.FILDBDMENPG().EFBNBFIDEOK("OnSketchViewAssetBundleFolderInitializeSuccess", 623f);
						AOBJLALDBAA.KKPFOJMAONG().EGELHPJBAIC("sind", 744f);
						return;
					}
					AOBJLALDBAA.AGANFKKBPFO().KGIKHEDLPND(" not found.", 145f);
					return;
				}
				else if (this.rewardType == CMCMEJMOPEC.rewardDailyLogin)
				{
					if (RewardOption.dailyRewardFireTime > 0)
					{
						CommonUserInterface.IKNOFBFMPGA().NFBMHHPIGFA(CCOJBMMKNAP.EHBBFMCILPC.JCDFHKDNEDH("srt"), CCOJBMMKNAP.JMNIGPHCAEJ().BDGPNPNIAPA("msg64"), CCOJBMMKNAP.HJGDLOOHNLO().JLBEIFLLBLO(""), (DFGILFBGPLN)(-96), 1130f, 65);
						return;
					}
					ApplicationFocusManager.AGANFKKBPFO().ForceBasicSync();
					return;
				}
				else
				{
					DPGJIJGOCIC.ANOPFDLPKGC("OnBackendPremiumChoiceException" + this.rewardType.ToString() + "JJJ");
				}
			}
			return;
		}
		if (LanguageManager.EHBBFMCILPC.NBANPEIHFOJ() == CEIBHCNNIDC.en)
		{
			Application.OpenURL(AssetsManager.EHBBFMCILPC.lobbyDataAsset.newsletterSignUpRu);
			return;
		}
		Application.OpenURL(AssetsManager.MJBDMHPHMID().lobbyDataAsset.newsletterSignUpEn);
	}

	// Token: 0x06007A39 RID: 31289 RVA: 0x0036A039 File Offset: 0x00368239
	private IEnumerator JLBDAMPPALK(RectTransform DGAAFGDHHHJ)
	{
		RewardOption.FLFLIOFLOEE flfliofloee = new RewardOption.FLFLIOFLOEE(1);
		flfliofloee.rectTransform = DGAAFGDHHHJ;
		return flfliofloee;
	}

	// Token: 0x06007A3A RID: 31290 RVA: 0x0036A048 File Offset: 0x00368248
	private void HFCMCNBJPEE()
	{
		base.StartCoroutine(this.LHNMEHHAPAO(this.textLayout.GetComponent<RectTransform>()));
		if (this.customTextDescriptionStringIndexClient >= 1)
		{
			string kegbcgmjolc = CCOJBMMKNAP.ILACPHFEDEP().OFOFBBPBFBN(this.customTextDescriptionStringIndexClient);
			this.textDescription.text = this.BGFDNHKMHPE(kegbcgmjolc);
			this.textDescription.SetText(this.NIHKJEDCOHJ(kegbcgmjolc), false);
		}
	}

	// Token: 0x06007A3B RID: 31291 RVA: 0x0036A0AC File Offset: 0x003682AC
	private void IOBGOFAAPOM()
	{
		CommonUserInterface.IKNOFBFMPGA().ShowConnectingAnimation((byte)-119);
		BackendOperationsManager.EHBBFMCILPC.RequestEmailUnsubscribe("mypofflinebody", "owned");
	}

	// Token: 0x06007A3C RID: 31292 RVA: 0x0036A039 File Offset: 0x00368239
	private IEnumerator DHBLONGMJCA(RectTransform DGAAFGDHHHJ)
	{
		RewardOption.FLFLIOFLOEE flfliofloee = new RewardOption.FLFLIOFLOEE(1);
		flfliofloee.rectTransform = DGAAFGDHHHJ;
		return flfliofloee;
	}

	// Token: 0x06007A3D RID: 31293 RVA: 0x0036A0CE File Offset: 0x003682CE
	private void LFABJIFAAII()
	{
		this.CPGLEJIBNEP = RewardOption.CBOKJGNCEKE + 1691f;
	}

	// Token: 0x06007A3E RID: 31294 RVA: 0x0036A0E1 File Offset: 0x003682E1
	private void IAKKINHMFNA()
	{
		if (LanguageManager.EHBBFMCILPC.NBANPEIHFOJ() == CEIBHCNNIDC.ru || LanguageManager.EHBBFMCILPC.NBANPEIHFOJ() == CEIBHCNNIDC.en)
		{
			this.textTitle.fontSizeMax = 996f;
			return;
		}
		this.textTitle.fontSizeMax = 1453f;
	}

	// Token: 0x06007A3F RID: 31295 RVA: 0x0036A120 File Offset: 0x00368320
	public void GFFNNFDMPAN()
	{
		if (this.rewardType == (CMCMEJMOPEC)83)
		{
			try
			{
				SceneLobbyManager2.freePlayPassAnthologyIndex = int.Parse(this.extraData);
				AOBJLALDBAA.KKPFOJMAONG().FDKBIBKABCM("congratstitle", 648f);
				AOBJLALDBAA.CEGAOMEEFBE().FDKBIBKABCM("endsInSeconds", 1330f);
				return;
			}
			catch (Exception aklgbjkdomm)
			{
				SceneLobbyManager2.freePlayPassAnthologyIndex = -1;
				DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
				return;
			}
		}
		DPGJIJGOCIC.ANOPFDLPKGC("newReleases" + this.rewardType.ToString() + "PlayerCharacterManager.Update() - exception raised:");
	}

	// Token: 0x06007A40 RID: 31296 RVA: 0x0036A1B4 File Offset: 0x003683B4
	private void IHDNAJNJEBD()
	{
		AOBJLALDBAA.BIAEAOMHBMM().EGELHPJBAIC("adsvc", 981f);
		if (LanguageManager.EHBBFMCILPC.MLOLBFBODHD() == CEIBHCNNIDC.en && GeoLocationManager.FDJONIACJKC() && KDCJJBLGCBH.EHBBFMCILPC.EAMJBDKCDPA())
		{
			CommonUserInterface.EHBBFMCILPC.GetPurchasingViewManager().PLLFCKGMHCF(false);
			return;
		}
		CommonUserInterface.IKNOFBFMPGA().GetPurchasingViewManager().ShowAndPurchaseProduct(this.extraData, true);
	}

	// Token: 0x06007A41 RID: 31297 RVA: 0x0036A21C File Offset: 0x0036841C
	public void HKOMHDIEPHF()
	{
		if (this.rewardType != (CMCMEJMOPEC)(-33))
		{
			if (this.rewardType != (CMCMEJMOPEC)(-94))
			{
				if (this.rewardType == CMCMEJMOPEC.rewardReplayEpisode)
				{
					CommonUserInterface.EHBBFMCILPC.KPAIHLBPFMJ();
					return;
				}
				if (this.rewardType == (CMCMEJMOPEC)(-39))
				{
					CommonUserInterface.EHBBFMCILPC.ShowSocialSelect();
					return;
				}
				if (this.rewardType == CMCMEJMOPEC.rewardFreePass)
				{
					CommonUserInterface.EHBBFMCILPC.ShowSocialSelect();
					return;
				}
				if (this.rewardType == (CMCMEJMOPEC)89)
				{
					CommonUserInterface.IKNOFBFMPGA().ShowPopupPromoCodes();
					return;
				}
				if (this.rewardType == CMCMEJMOPEC.rewardNewsletterUnsubscribe)
				{
					CommonUserInterface.IKNOFBFMPGA().ShowConnectingAnimation(98);
					BackendOperationsManager.NPDDBAONMJP().GOMFBGEMJKL(this.extraData, "", "");
					return;
				}
				if (this.rewardType == (CMCMEJMOPEC)72)
				{
					PurchaseManagerBridge.LMCCLMFGEBD().MGMDKEJBEPP().Initialize();
					AOBJLALDBAA.FILDBDMENPG().FDKBIBKABCM("p", 623f);
					CommonUserInterface.IKNOFBFMPGA().GetFader().BJIGLKGLAKM(new TweenCallback(this.ODNBEODOOJE));
					return;
				}
				if (this.rewardType == CMCMEJMOPEC.rewardAchievements)
				{
					AOBJLALDBAA.DBLAIDPICIG().EGELHPJBAIC("musavatar", 1172f);
					AOBJLALDBAA.BIAEAOMHBMM().FDKBIBKABCM(" ", 547f);
					return;
				}
				if (this.rewardType == CMCMEJMOPEC.rewardDailyLogin)
				{
					AOBJLALDBAA.CEGAOMEEFBE().KMAGHMCCMPG("EnvironmentsPivot", 956f);
					AOBJLALDBAA.FILDBDMENPG().LPNCDPHNBJK("", 1508f);
					return;
				}
				if (this.rewardType == CMCMEJMOPEC.rewardSubsequentEpisode)
				{
					AOBJLALDBAA.BIAEAOMHBMM().KGIKHEDLPND("(", 728f);
					AOBJLALDBAA.NMGMNAKLLMI().KGIKHEDLPND("FranchisesHub.Populate() - ", 1099f);
					return;
				}
				if (this.rewardType == CMCMEJMOPEC.rewardDiamondRush)
				{
					AOBJLALDBAA.CEGAOMEEFBE().KGIKHEDLPND("p", 1309f);
					AOBJLALDBAA.AGANFKKBPFO().KGIKHEDLPND(") + is present, creating anthology save for anthology ", 498f);
					return;
				}
				if (this.rewardType == CMCMEJMOPEC.rewardStoryComplete)
				{
					AOBJLALDBAA.NMGMNAKLLMI().DCGCFPHHDDG("", 307f);
					AOBJLALDBAA.DBLAIDPICIG().KGIKHEDLPND("lititle", 1058f);
					return;
				}
				if (this.rewardType == CMCMEJMOPEC.rewardFreeTea)
				{
					if (RewardOption.hardAdCanBeWatched)
					{
						AOBJLALDBAA.CEGAOMEEFBE().EGELHPJBAIC("not", 1010f);
						AOBJLALDBAA.DBLAIDPICIG().EGELHPJBAIC("RunCustomCode() needToChangeCustomCodeUrl", 232f);
						return;
					}
					AOBJLALDBAA.BIAEAOMHBMM().CIGLHCJDDPI("PurchaseManagerUnity.CompletePurchase(): _order is null, can happen when restoring purchases.", 970f);
					return;
				}
				else if (this.rewardType == (CMCMEJMOPEC)53)
				{
					if (RewardOption.spinFireTime <= 1 || AKLFPGMDKLA.EHBBFMCILPC.ABGNIKKFFAC.BADNAGEMINF() > 1)
					{
						AOBJLALDBAA.EHBBFMCILPC.EFBNBFIDEOK("fast", 841f);
						AOBJLALDBAA.EHBBFMCILPC.CIGLHCJDDPI("OOO", 234f);
						return;
					}
					AOBJLALDBAA.KKPFOJMAONG().EGELHPJBAIC("acli21", 825f);
					return;
				}
				else if (this.rewardType == CMCMEJMOPEC.rewardReplayEpisode)
				{
					if (RewardOption.dailyRewardFireTime > 1)
					{
						CommonUserInterface.EHBBFMCILPC.ShowGenericPopup(CCOJBMMKNAP.BIAEAOMHBMM().GGPHHLGPMPA("</i>"), CCOJBMMKNAP.BIAEAOMHBMM().FCOCLEHKLDJ("importanttitle"), CCOJBMMKNAP.BFHKGNBFHCH().HIPJILDCHJC(". Retrieving persistent save data is impossible."), (DFGILFBGPLN)101, 1025f, -52);
						return;
					}
					ApplicationFocusManager.AGANFKKBPFO().ForceBasicSync();
					return;
				}
				else
				{
					DPGJIJGOCIC.ANOPFDLPKGC("lsenvlite" + this.rewardType.ToString() + "ind");
				}
			}
			return;
		}
		if (LanguageManager.EHBBFMCILPC.NBANPEIHFOJ() == CEIBHCNNIDC.ru)
		{
			Application.OpenURL(AssetsManager.EHBBFMCILPC.lobbyDataAsset.newsletterSignUpRu);
			return;
		}
		Application.OpenURL(AssetsManager.EHBBFMCILPC.lobbyDataAsset.newsletterSignUpEn);
	}

	// Token: 0x06007A42 RID: 31298 RVA: 0x0036A574 File Offset: 0x00368774
	public void FHGHFPNKODE()
	{
		if (this.rewardType == (CMCMEJMOPEC)(-1))
		{
			try
			{
				SceneLobbyManager2.freePlayPassAnthologyIndex = int.Parse(this.extraData);
				AOBJLALDBAA.EHBBFMCILPC.FDKBIBKABCM("SocialStatsUserPublicProfile.modified = true, AddCutsceneToFavorites()", 19f);
				AOBJLALDBAA.EHBBFMCILPC.DCGCFPHHDDG("XXX", 1198f);
				return;
			}
			catch (Exception aklgbjkdomm)
			{
				SceneLobbyManager2.freePlayPassAnthologyIndex = -1;
				DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
				return;
			}
		}
		DPGJIJGOCIC.ANOPFDLPKGC("orderid" + this.rewardType.ToString() + "XXX");
	}

	// Token: 0x06007A43 RID: 31299 RVA: 0x0036A608 File Offset: 0x00368808
	private void ODNBEODOOJE()
	{
		AOBJLALDBAA.EHBBFMCILPC.LPNCDPHNBJK("Invalid custom effects bundle index in anthology header, skipped:", 776f);
		if (LanguageManager.EHBBFMCILPC.IEBFINIJAMJ() == CEIBHCNNIDC.en && GeoLocationManager.PBAGPDDBABB() && KDCJJBLGCBH.EHBBFMCILPC.POGBNANIKCA())
		{
			CommonUserInterface.EHBBFMCILPC.GetPurchasingViewManager().NNNMAPAILMB(false);
			return;
		}
		CommonUserInterface.EHBBFMCILPC.GetPurchasingViewManager().ShowAndPurchaseProduct(this.extraData, false);
	}

	// Token: 0x06007A44 RID: 31300 RVA: 0x003689C8 File Offset: 0x00366BC8
	private IEnumerator KHBNLLDBHBP(RectTransform DGAAFGDHHHJ)
	{
		yield return new WaitForEndOfFrame();
		LayoutRebuilder.ForceRebuildLayoutImmediate(DGAAFGDHHHJ);
		yield break;
	}

	// Token: 0x06007A45 RID: 31301 RVA: 0x0036A670 File Offset: 0x00368870
	private void GLKDEMNJKEF()
	{
		this.CPGLEJIBNEP += Time.deltaTime;
		if (this.CPGLEJIBNEP > RewardOption.CBOKJGNCEKE)
		{
			if (this.rewardType == (CMCMEJMOPEC)59 && this.timerBlock.gameObject.activeSelf)
			{
				if (LiveEventsManager.ONCPHEEJLOP().ANFEMPBJKEI(this.extraData))
				{
					this.OHGGDAHPNJM = LiveEventsManager.OOGPALHPNGM().OOGOFKHMFOB(this.extraData);
					if (this.OHGGDAHPNJM != null)
					{
						this.textTimer.SetText(DPGJIJGOCIC.ICCGLKHPFAJ((int)this.OHGGDAHPNJM.ONMADEIOOKN.EKJIJLMOBIG()), true);
					}
				}
			}
			else if (this.rewardType == CMCMEJMOPEC.rewardFreeTea && this.timerBlock.gameObject.activeSelf)
			{
				this.textTimer.SetText(DPGJIJGOCIC.LGMEIBNFMBB(RewardOption.energyFireTime), false);
			}
			else if (this.rewardType == CMCMEJMOPEC.rewardFreeDiamonds)
			{
				if (!RewardOption.hardAdCanBeWatched)
				{
					if (!this.timerBlock.gameObject.activeSelf)
					{
						this.timerBlock.gameObject.SetActive(false);
					}
					this.textTimer.SetText(DPGJIJGOCIC.ICCGLKHPFAJ(RewardOption.hardAdFireTime), false);
				}
				else if (this.timerBlock.gameObject.activeSelf)
				{
					this.timerBlock.gameObject.SetActive(true);
				}
			}
			else if (this.rewardType == (CMCMEJMOPEC)83)
			{
				if (RewardOption.spinFireTime > 0 && AKLFPGMDKLA.EHBBFMCILPC.ABGNIKKFFAC.KGEGKPHEMOJ() < KDCJJBLGCBH.EHBBFMCILPC.HLPACDMEKMK(ODLJHDIGLGO.GOBKMIMGPDD(CLHDENLPOFP.eventPass, false)))
				{
					if (!this.timerBlock.gameObject.activeSelf)
					{
						this.timerBlock.gameObject.SetActive(true);
					}
					this.textTimer.SetText(DPGJIJGOCIC.DMENNJGBMBH(RewardOption.spinFireTime), false);
				}
				else if (this.timerBlock.gameObject.activeSelf)
				{
					this.timerBlock.gameObject.SetActive(true);
				}
			}
			else if (this.rewardType == CMCMEJMOPEC.rewardReplayEpisode)
			{
				if (RewardOption.dailyRewardFireTime > 0)
				{
					if (!this.timerBlock.gameObject.activeSelf)
					{
						this.timerBlock.gameObject.SetActive(false);
					}
					this.textTimer.SetText(DPGJIJGOCIC.LGMEIBNFMBB(RewardOption.dailyRewardFireTime), false);
				}
				else if (this.timerBlock.gameObject.activeSelf)
				{
					this.timerBlock.gameObject.SetActive(false);
				}
			}
			this.CPGLEJIBNEP = 291f;
		}
	}

	// Token: 0x06007A46 RID: 31302 RVA: 0x0036A8DD File Offset: 0x00368ADD
	private void GMPHANBKGBK()
	{
		if (LanguageManager.EHBBFMCILPC.GetSelectedLanguage() == CEIBHCNNIDC.ru || LanguageManager.EHBBFMCILPC.IEBFINIJAMJ() == CEIBHCNNIDC.en)
		{
			this.textTitle.fontSizeMax = 412f;
			return;
		}
		this.textTitle.fontSizeMax = 929f;
	}

	// Token: 0x06007A47 RID: 31303 RVA: 0x003689C8 File Offset: 0x00366BC8
	private IEnumerator LHNMEHHAPAO(RectTransform DGAAFGDHHHJ)
	{
		yield return new WaitForEndOfFrame();
		LayoutRebuilder.ForceRebuildLayoutImmediate(DGAAFGDHHHJ);
		yield break;
	}

	// Token: 0x06007A48 RID: 31304 RVA: 0x0036A91C File Offset: 0x00368B1C
	private void BFGFJIJPMEH()
	{
		base.StartCoroutine(this.JLBDAMPPALK(this.textLayout.GetComponent<RectTransform>()));
		if (this.customTextDescriptionStringIndexClient >= 0)
		{
			string kegbcgmjolc = CCOJBMMKNAP.APGODIBBPOD().CGNFIBHFLOP(this.customTextDescriptionStringIndexClient);
			this.textDescription.text = this.FNFJHAFCEOK(kegbcgmjolc);
			this.textDescription.SetText(this.FNFJHAFCEOK(kegbcgmjolc), false);
		}
	}

	// Token: 0x06007A49 RID: 31305 RVA: 0x0036A980 File Offset: 0x00368B80
	private void LPFHPJEFFEA()
	{
		CommonUserInterface.EHBBFMCILPC.ShowConnectingAnimation(9);
		BackendOperationsManager.EHBBFMCILPC.RequestEmailUnsubscribe(" not found.", "");
	}

	// Token: 0x06007A4A RID: 31306 RVA: 0x0036A9A4 File Offset: 0x00368BA4
	private void JOEGGDDACPM()
	{
		AOBJLALDBAA.AGANFKKBPFO().KMAGHMCCMPG("trsv", 1160f);
		if (LanguageManager.EHBBFMCILPC.MLOLBFBODHD() == CEIBHCNNIDC.ru && GeoLocationManager.FDJONIACJKC() && KDCJJBLGCBH.EHBBFMCILPC.EAMJBDKCDPA())
		{
			CommonUserInterface.IKNOFBFMPGA().GetPurchasingViewManager().NNNMAPAILMB(false);
			return;
		}
		CommonUserInterface.IKNOFBFMPGA().GetPurchasingViewManager().ShowAndPurchaseProduct(this.extraData, true);
	}

	// Token: 0x06007A4B RID: 31307 RVA: 0x0036AA0C File Offset: 0x00368C0C
	private string DLIBEAJOCLB(string KEGBCGMJOLC)
	{
		string text = KEGBCGMJOLC;
		if (this.rewardType == (CMCMEJMOPEC)(-111))
		{
			OBHDGKFFICI productData = PurchaseManagerBridge.FJHKMJPFDNI().DOMEKEJELKB().GetProductData(this.extraData);
			OCBIOPOEENJ ocbiopoeenj = CJEKEHDEBLM.PMABBOJDELF().AOAGHIJNFDL(this.extraData);
			if (ocbiopoeenj != null && productData != null)
			{
				string newValue;
				if (ocbiopoeenj.PJCIBAKAANH())
				{
					newValue = ocbiopoeenj.DOLEPIMNJLG();
				}
				else
				{
					newValue = "x" + ocbiopoeenj.DMODNDCLGEJ;
				}
				text = text.Replace("x", ocbiopoeenj.MPMKMCJFHOG.ToString());
				text = text.Replace("pmterror012", ocbiopoeenj.ODMKLADKHMO.ToString());
				text = text.Replace("", newValue);
			}
			else
			{
				DPGJIJGOCIC.ANOPFDLPKGC("OnBackendRequestFriendRejectSuccess");
			}
		}
		else if (this.rewardType == CMCMEJMOPEC.rewardFirstEpisode)
		{
			text = text.Replace("_web", KDCJJBLGCBH.EHBBFMCILPC.PPKDBCLAGOG().ToString() ?? " msg=");
		}
		else if (this.rewardType == CMCMEJMOPEC.rewardReplayEpisode)
		{
			text = text.Replace("<align=\"left\"><alpha=#FF>\n\n", KDCJJBLGCBH.EHBBFMCILPC.PLOMCENKKFD(ODLJHDIGLGO.KJIAJJOCMOD(CLHDENLPOFP.eventPass, false)).ToString() ?? "");
			text = text.Replace("", this.DDLFLNDOABO(1).ToString() ?? "sku");
		}
		else if (this.rewardType == CMCMEJMOPEC.rewardFirstEpisode)
		{
			text = text.Replace("SceneLobbyManager2.OpenPublicProfile(): AssetsManager.Instance.IsBusy()", KDCJJBLGCBH.EHBBFMCILPC.HHCMJBBEAKO().ToString() ?? "http://");
			text = text.Replace("ched", this.BNLJGJLMIDA(0).ToString() ?? "snapundo");
		}
		else if (this.rewardType == CMCMEJMOPEC.rewardDiamondRush)
		{
			text = text.Replace("vrt", KDCJJBLGCBH.EHBBFMCILPC.JIMOMNGLIMC().ToString() ?? "Amplitude");
		}
		else if (this.rewardType == CMCMEJMOPEC.rewardFreeTea)
		{
			text = text.Replace("importanttitle", this.DDLFLNDOABO(0).ToString() ?? "/");
		}
		else if (this.rewardType == (CMCMEJMOPEC)57)
		{
			text = text.Replace(", rid:", DPGJIJGOCIC.CEOBDMGAKNL(KDCJJBLGCBH.EHBBFMCILPC.ADLOIIMBHAG(ODLJHDIGLGO.MNALIKIMKFC(CLHDENLPOFP.eventPass, false))) ?? "<size=28px>");
		}
		else if (this.rewardType == CMCMEJMOPEC.rewardFreeTea)
		{
			text = text.Replace("anthologiestitle", DPGJIJGOCIC.CEOBDMGAKNL(KDCJJBLGCBH.EHBBFMCILPC.GCPFCGGBDKK(ODLJHDIGLGO.FLDPGFAMICD(CLHDENLPOFP.eventPass, false))) ?? ", already present in top match list.");
		}
		return text;
	}

	// Token: 0x06007A4C RID: 31308 RVA: 0x00003E52 File Offset: 0x00002052
	private void BMNPIEBKBHO()
	{
	}

	// Token: 0x06007A4D RID: 31309 RVA: 0x0036AC8C File Offset: 0x00368E8C
	private void BCKCCEIOHAK()
	{
		AOBJLALDBAA.EHBBFMCILPC.EFBNBFIDEOK("XXX", 681f);
		if (LanguageManager.EHBBFMCILPC.MLOLBFBODHD() == CEIBHCNNIDC.ru && GeoLocationManager.OOCDLFJKLLI() && KDCJJBLGCBH.EHBBFMCILPC.POGBNANIKCA())
		{
			CommonUserInterface.IKNOFBFMPGA().GetPurchasingViewManager().NNNMAPAILMB(false);
			return;
		}
		CommonUserInterface.IKNOFBFMPGA().GetPurchasingViewManager().CGDKCOLDBGD(this.extraData, false);
	}

	// Token: 0x06007A4E RID: 31310 RVA: 0x00003E52 File Offset: 0x00002052
	private void BFEGALBLKEI()
	{
	}

	// Token: 0x06007A4F RID: 31311 RVA: 0x0036ACF4 File Offset: 0x00368EF4
	private void PIHONDPKDBB()
	{
		if (LanguageManager.EHBBFMCILPC.MLOLBFBODHD() == CEIBHCNNIDC.en || LanguageManager.EHBBFMCILPC.MLOLBFBODHD() == CEIBHCNNIDC.en)
		{
			this.textTitle.fontSizeMax = 1605f;
			return;
		}
		this.textTitle.fontSizeMax = 1094f;
	}

	// Token: 0x06007A50 RID: 31312 RVA: 0x0036AD30 File Offset: 0x00368F30
	private void KPJMABLNOLD()
	{
		CommonUserInterface.IKNOFBFMPGA().ShowConnectingAnimation(90);
		BackendOperationsManager.NPDDBAONMJP().RequestEmailUnsubscribe("OnLobbyStartFireworksEffectAutoHide", " • ");
	}

	// Token: 0x06007A51 RID: 31313 RVA: 0x0036AD54 File Offset: 0x00368F54
	private string NIHKJEDCOHJ(string KEGBCGMJOLC)
	{
		string text = KEGBCGMJOLC;
		if (this.rewardType == (CMCMEJMOPEC)96)
		{
			OBHDGKFFICI productData = PurchaseManagerBridge.KMNBCEMEBBD().JNNBFLDOOHM().GetProductData(this.extraData);
			OCBIOPOEENJ ocbiopoeenj = CJEKEHDEBLM.GDGKNNDEAAO().EPNHMLIJCCM(this.extraData);
			if (ocbiopoeenj != null && productData != null)
			{
				string newValue;
				if (ocbiopoeenj.PJCIBAKAANH())
				{
					newValue = ocbiopoeenj.ILAPDGNDFGC();
				}
				else
				{
					newValue = "" + ocbiopoeenj.DMODNDCLGEJ;
				}
				text = text.Replace("spns", ocbiopoeenj.MPMKMCJFHOG.ToString());
				text = text.Replace("OnUpdateSocialEventsCounter", ocbiopoeenj.ODMKLADKHMO.ToString());
				text = text.Replace("c", newValue);
			}
			else
			{
				DPGJIJGOCIC.ANOPFDLPKGC("OnBackendRequestSendGiftCardSuccess");
			}
		}
		else if (this.rewardType == CMCMEJMOPEC.rewardStoryComplete)
		{
			text = text.Replace("OnFriendsPopupManagerAcceptClick", KDCJJBLGCBH.EHBBFMCILPC.PPKDBCLAGOG().ToString() ?? "");
		}
		else if (this.rewardType == CMCMEJMOPEC.rewardSubsequentEpisode)
		{
			text = text.Replace("", KDCJJBLGCBH.EHBBFMCILPC.PLOMCENKKFD(ODLJHDIGLGO.DBLAFNFGPDB(CLHDENLPOFP.gamePass, false)).ToString() ?? "ok");
			text = text.Replace(", discounted cost:", this.KKEDNJIJECI(0).ToString() ?? "stat0long");
		}
		else if (this.rewardType == CMCMEJMOPEC.rewardDailyLogin)
		{
			text = text.Replace("skinshopinfosumavailable", KDCJJBLGCBH.EHBBFMCILPC.HHCMJBBEAKO().ToString() ?? "eventsoon");
			text = text.Replace("digitalglitchovr_1", this.BNLJGJLMIDA(0).ToString() ?? "OnSketchesItemClose");
		}
		else if (this.rewardType == CMCMEJMOPEC.rewardDailyLogin)
		{
			text = text.Replace("%", KDCJJBLGCBH.EHBBFMCILPC.JIMOMNGLIMC().ToString() ?? "OnNeedToShowConnectingAnimation");
		}
		else if (this.rewardType == CMCMEJMOPEC.rewardFreeTea)
		{
			text = text.Replace("s", this.HHPPEAGBLBL(0).ToString() ?? "OnFriendsPopupFriendMatchClick");
		}
		else if (this.rewardType == (CMCMEJMOPEC)120)
		{
			text = text.Replace("NNN", DPGJIJGOCIC.CEOBDMGAKNL(KDCJJBLGCBH.EHBBFMCILPC.ADLOIIMBHAG(ODLJHDIGLGO.HECMHABJMFO(CLHDENLPOFP.eventPass, false))) ?? "<i>");
		}
		else if (this.rewardType == CMCMEJMOPEC.rewardFreeTea)
		{
			text = text.Replace(">", DPGJIJGOCIC.CEOBDMGAKNL(KDCJJBLGCBH.EHBBFMCILPC.GCPFCGGBDKK(ODLJHDIGLGO.FLDPGFAMICD(CLHDENLPOFP.gamePass, true))) ?? "OnRewardFreeDiamondsClick");
		}
		return text;
	}

	// Token: 0x06007A52 RID: 31314 RVA: 0x00003E52 File Offset: 0x00002052
	private void MAMAMNOCECB()
	{
	}

	// Token: 0x06007A53 RID: 31315 RVA: 0x0036AFD4 File Offset: 0x003691D4
	private int BNLJGJLMIDA(int MEFKFOHCOHK)
	{
		KIOOJMGLCLC kioojmglclc = ODLJHDIGLGO.DCADGAIHIII(CLHDENLPOFP.eventPass);
		int num = 1;
		if (kioojmglclc != null && kioojmglclc.CGOECMIINGM())
		{
			num = KDCJJBLGCBH.EHBBFMCILPC.ODDPKODCIBB(KDCJJBLGCBH.EHBBFMCILPC.HHONCLBBHPG(kioojmglclc.LLLJOBODOAL), (DAMCJCDKOJK)54, 1 == AKLFPGMDKLA.EHBBFMCILPC.DCIPLNCLIMF);
		}
		return KDCJJBLGCBH.EHBBFMCILPC.NEOIABIBJOI(MEFKFOHCOHK) * num;
	}

	// Token: 0x06007A54 RID: 31316 RVA: 0x0036B02C File Offset: 0x0036922C
	public void DKGDMLOGPED()
	{
		if (this.rewardType == (CMCMEJMOPEC)(-75))
		{
			try
			{
				SceneLobbyManager2.freePlayPassAnthologyIndex = int.Parse(this.extraData);
				AOBJLALDBAA.EHBBFMCILPC.CIGLHCJDDPI("passtrytobuyhigherorder", 721f);
				AOBJLALDBAA.CEGAOMEEFBE().LPNCDPHNBJK("HTTP fail: ", 823f);
				return;
			}
			catch (Exception aklgbjkdomm)
			{
				SceneLobbyManager2.freePlayPassAnthologyIndex = -1;
				DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
				return;
			}
		}
		DPGJIJGOCIC.ANOPFDLPKGC("XXX" + this.rewardType.ToString() + "genre_");
	}

	// Token: 0x06007A55 RID: 31317 RVA: 0x003689C8 File Offset: 0x00366BC8
	private IEnumerator LMMLDNBEFPC(RectTransform DGAAFGDHHHJ)
	{
		yield return new WaitForEndOfFrame();
		LayoutRebuilder.ForceRebuildLayoutImmediate(DGAAFGDHHHJ);
		yield break;
	}

	// Token: 0x06007A56 RID: 31318 RVA: 0x0036A039 File Offset: 0x00368239
	private IEnumerator DDNMKHHAONK(RectTransform DGAAFGDHHHJ)
	{
		RewardOption.FLFLIOFLOEE flfliofloee = new RewardOption.FLFLIOFLOEE(1);
		flfliofloee.rectTransform = DGAAFGDHHHJ;
		return flfliofloee;
	}

	// Token: 0x06007A57 RID: 31319 RVA: 0x0036B0C0 File Offset: 0x003692C0
	private void Start()
	{
		base.StartCoroutine(this.LHNMEHHAPAO(this.textLayout.GetComponent<RectTransform>()));
		if (this.customTextDescriptionStringIndexClient >= 0)
		{
			string kegbcgmjolc = CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP(this.customTextDescriptionStringIndexClient);
			this.textDescription.text = this.FNFJHAFCEOK(kegbcgmjolc);
			this.textDescription.SetText(this.FNFJHAFCEOK(kegbcgmjolc), true);
		}
	}

	// Token: 0x06007A58 RID: 31320 RVA: 0x0036B124 File Offset: 0x00369324
	private void MNFCEKMJKLE()
	{
		AOBJLALDBAA.EHBBFMCILPC.KGIKHEDLPND("mfs", 497f);
		if (LanguageManager.EHBBFMCILPC.NBANPEIHFOJ() == CEIBHCNNIDC.ru && GeoLocationManager.IsRussia() && KDCJJBLGCBH.EHBBFMCILPC.EAMJBDKCDPA())
		{
			CommonUserInterface.IKNOFBFMPGA().GetPurchasingViewManager().MLANIKPFIMA(true);
			return;
		}
		CommonUserInterface.IKNOFBFMPGA().GetPurchasingViewManager().CGDKCOLDBGD(this.extraData, true);
	}

	// Token: 0x06007A59 RID: 31321 RVA: 0x0036B18C File Offset: 0x0036938C
	private int DDLFLNDOABO(int MEFKFOHCOHK)
	{
		KIOOJMGLCLC kioojmglclc = ODLJHDIGLGO.HFDJCJOHLOF(CLHDENLPOFP.gamePass);
		int num = 1;
		if (kioojmglclc != null && kioojmglclc.CGOECMIINGM())
		{
			num = KDCJJBLGCBH.EHBBFMCILPC.ODDPKODCIBB(KDCJJBLGCBH.EHBBFMCILPC.HHONCLBBHPG(kioojmglclc.LLLJOBODOAL), (DAMCJCDKOJK)126, 1 == AKLFPGMDKLA.EHBBFMCILPC.DCIPLNCLIMF);
		}
		return KDCJJBLGCBH.EHBBFMCILPC.NEOIABIBJOI(MEFKFOHCOHK) * num;
	}

	// Token: 0x06007A5A RID: 31322 RVA: 0x0036B1E4 File Offset: 0x003693E4
	private void MDBDKBEANOJ()
	{
		AOBJLALDBAA.AGANFKKBPFO().EFBNBFIDEOK("hist", 302f);
		if (LanguageManager.EHBBFMCILPC.MLOLBFBODHD() == CEIBHCNNIDC.ru && GeoLocationManager.FDJONIACJKC() && KDCJJBLGCBH.EHBBFMCILPC.POGBNANIKCA())
		{
			CommonUserInterface.IKNOFBFMPGA().GetPurchasingViewManager().KFLFFOPPNEO(true);
			return;
		}
		CommonUserInterface.EHBBFMCILPC.GetPurchasingViewManager().ShowAndPurchaseProduct(this.extraData, false);
	}

	// Token: 0x06007A5B RID: 31323 RVA: 0x0036B24C File Offset: 0x0036944C
	private void OnEnable()
	{
		this.CPGLEJIBNEP = RewardOption.CBOKJGNCEKE + 1f;
	}

	// Token: 0x06007A5C RID: 31324 RVA: 0x0036B25F File Offset: 0x0036945F
	private void EGMHPEFIOIC()
	{
		if (LanguageManager.EHBBFMCILPC.GetSelectedLanguage() == CEIBHCNNIDC.ru || LanguageManager.EHBBFMCILPC.NBANPEIHFOJ() == CEIBHCNNIDC.en)
		{
			this.textTitle.fontSizeMax = 1373f;
			return;
		}
		this.textTitle.fontSizeMax = 14f;
	}

	// Token: 0x06007A5D RID: 31325 RVA: 0x0036B29B File Offset: 0x0036949B
	private void HCKLMFNDKBC()
	{
		this.CPGLEJIBNEP = RewardOption.CBOKJGNCEKE + 1051f;
	}

	// Token: 0x06007A5E RID: 31326 RVA: 0x0036B2B0 File Offset: 0x003694B0
	private void IJEKPAOBMIP()
	{
		AOBJLALDBAA.FILDBDMENPG().KMAGHMCCMPG("achiev", 427f);
		if (LanguageManager.EHBBFMCILPC.MLOLBFBODHD() == CEIBHCNNIDC.ru && GeoLocationManager.FHINOKNBJPM() && KDCJJBLGCBH.EHBBFMCILPC.POGBNANIKCA())
		{
			CommonUserInterface.EHBBFMCILPC.GetPurchasingViewManager().PLLFCKGMHCF(false);
			return;
		}
		CommonUserInterface.IKNOFBFMPGA().GetPurchasingViewManager().CGDKCOLDBGD(this.extraData, false);
	}

	// Token: 0x06007A5F RID: 31327 RVA: 0x0036B318 File Offset: 0x00369518
	private void EIHOIEGKJLA()
	{
		base.StartCoroutine(this.LHNMEHHAPAO(this.textLayout.GetComponent<RectTransform>()));
		if (this.customTextDescriptionStringIndexClient >= 1)
		{
			string kegbcgmjolc = CCOJBMMKNAP.AEELGGPEJCC().CLFFOEGMCAE(this.customTextDescriptionStringIndexClient);
			this.textDescription.text = this.BGFDNHKMHPE(kegbcgmjolc);
			this.textDescription.SetText(this.DLIBEAJOCLB(kegbcgmjolc), true);
		}
	}

	// Token: 0x06007A60 RID: 31328 RVA: 0x0036B37C File Offset: 0x0036957C
	private void OECKPNCHMNO()
	{
		AOBJLALDBAA.BIAEAOMHBMM().LPNCDPHNBJK("lf1", 1866f);
		if (LanguageManager.EHBBFMCILPC.NBANPEIHFOJ() == CEIBHCNNIDC.ru && GeoLocationManager.OOCDLFJKLLI() && KDCJJBLGCBH.EHBBFMCILPC.EAMJBDKCDPA())
		{
			CommonUserInterface.IKNOFBFMPGA().GetPurchasingViewManager().NNNMAPAILMB(true);
			return;
		}
		CommonUserInterface.EHBBFMCILPC.GetPurchasingViewManager().CGDKCOLDBGD(this.extraData, false);
	}

	// Token: 0x06007A61 RID: 31329 RVA: 0x00003E52 File Offset: 0x00002052
	private void CEJPJJAGDNO()
	{
	}

	// Token: 0x06007A62 RID: 31330 RVA: 0x0036A039 File Offset: 0x00368239
	private IEnumerator IBHBPBDDGLP(RectTransform DGAAFGDHHHJ)
	{
		RewardOption.FLFLIOFLOEE flfliofloee = new RewardOption.FLFLIOFLOEE(1);
		flfliofloee.rectTransform = DGAAFGDHHHJ;
		return flfliofloee;
	}

	// Token: 0x0400235D RID: 9053
	public static int energyFireTime = 0;

	// Token: 0x0400235E RID: 9054
	public static int hardAdFireTime = 0;

	// Token: 0x0400235F RID: 9055
	public static int dailyRewardFireTime = 0;

	// Token: 0x04002360 RID: 9056
	public static int spinFireTime = 0;

	// Token: 0x04002361 RID: 9057
	public static bool hardAdCanBeWatched = false;

	// Token: 0x04002362 RID: 9058
	public const string onStartFreePassSuccess = "OnStartFreePassSuccess";

	// Token: 0x04002363 RID: 9059
	public const string onStartFreePassException = "OnStartFreePassException";

	// Token: 0x04002364 RID: 9060
	public const string onEmailSubscribeSuccess = "OnEmailSubscribeSuccess";

	// Token: 0x04002365 RID: 9061
	public const string onEmailSubscribeException = "OnEmailSubscribeException";

	// Token: 0x04002366 RID: 9062
	public const string onEmailUnsubscribeSuccess = "OnEmailUnsubscribeSuccess";

	// Token: 0x04002367 RID: 9063
	public const string onEmailUnsubscribeException = "OnEmailUnsubscribeException";

	// Token: 0x04002368 RID: 9064
	public const string onRewardOptionProfileClick = "OnRewardOptionProfileClick";

	// Token: 0x04002369 RID: 9065
	public const string onRewardFirstEpisodeClick = "OnRewardFirstEpisodeClick";

	// Token: 0x0400236A RID: 9066
	public const string onRewardSubsequentEpisodeClick = "OnRewardSubsequentEpisodeClick";

	// Token: 0x0400236B RID: 9067
	public const string onRewardReplayEpisodeClick = "OnRewardReplayEpisodeClick";

	// Token: 0x0400236C RID: 9068
	public const string onRewardStoryCompleteClick = "OnRewardStoryCompleteClick";

	// Token: 0x0400236D RID: 9069
	public const string onRewardFreeDiamondsClick = "OnRewardFreeDiamondsClick";

	// Token: 0x0400236E RID: 9070
	public const string onRewardFreeSpinsClick = "OnRewardFreeSpinsClick";

	// Token: 0x0400236F RID: 9071
	public const string onRewardFreePassPlayStory = "OnRewardFreePassPlayStore";

	// Token: 0x04002370 RID: 9072
	public CMCMEJMOPEC rewardType;

	// Token: 0x04002371 RID: 9073
	public VerticalLayoutGroup textLayout;

	// Token: 0x04002372 RID: 9074
	public TextMeshProUGUI textTitle;

	// Token: 0x04002373 RID: 9075
	public TextMeshProUGUI textDescription;

	// Token: 0x04002374 RID: 9076
	public GameObject timerBlock;

	// Token: 0x04002375 RID: 9077
	public GameObject imageSandglass;

	// Token: 0x04002376 RID: 9078
	public GameObject imageLock;

	// Token: 0x04002377 RID: 9079
	public TextMeshProUGUI textTimer;

	// Token: 0x04002378 RID: 9080
	public Button button;

	// Token: 0x04002379 RID: 9081
	public Button buttonSecondary;

	// Token: 0x0400237A RID: 9082
	public string extraData;

	// Token: 0x0400237B RID: 9083
	public int customTextDescriptionStringIndexClient = -1;

	// Token: 0x0400237C RID: 9084
	private OKAFAHMOFII OHGGDAHPNJM;

	// Token: 0x0400237D RID: 9085
	private static float CBOKJGNCEKE = 1f;

	// Token: 0x0400237E RID: 9086
	private float CPGLEJIBNEP;
}
