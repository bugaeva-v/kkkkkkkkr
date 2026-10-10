using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using AssetBundles;
using DG.Tweening;
using SimpleJSON;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

// Token: 0x020000E5 RID: 229
public class SceneLobbyManager2 : MonoBehaviour
{
	// Token: 0x060021C6 RID: 8646 RVA: 0x000EC404 File Offset: 0x000EA604
	private void GEMOOEPJGHP()
	{
		if (!HKLPEDKJGFC.FACIFBONANM())
		{
			HKLPEDKJGFC.BAMHPOCKBML(GKJPOGNFKNK.HJNFBFBFDKL(), LanguageManager.EHBBFMCILPC.GetSelectedLanguage(), false);
		}
		if (!MLIBDDCCKBM.FACIFBONANM())
		{
			try
			{
				bool kgjkmcjjmji = false;
				bool mjdmmlmcdal = false;
				MLIBDDCCKBM.BAMHPOCKBML(GKJPOGNFKNK.ECBPPPIEPHM(), kgjkmcjjmji, mjdmmlmcdal);
			}
			catch (Exception aklgbjkdomm)
			{
				DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
			}
		}
		AKLFPGMDKLA.EHBBFMCILPC.IPIKGIOIPMP(AssetsManager.EHBBFMCILPC.anthologyAssets);
		this.UpdateAnthologiesPropertiesV2(false, false);
		if (AKLFPGMDKLA.EHBBFMCILPC.EKEHBBGKMHA)
		{
			this.shuffleButton.SetActive(true);
			this.PGKHOKJOCKP = true;
		}
		else
		{
			this.shuffleButton.SetActive(false);
			this.PGKHOKJOCKP = false;
		}
		PLBBPHIJMAH.HNFKFGAMNFE(AssetsManager.EHBBFMCILPC.anthologyAssets);
		if (SceneLobbyManager2.selectedFirstStoryOffering < 0)
		{
			for (int i = 0; i < AssetsManager.EHBBFMCILPC.anthologyAssets.Count; i++)
			{
				AssetsManager.EHBBFMCILPC.QueueAssetBundleDownload(NMKDCBPMCKI.AssetBundleAnthologyPreview2, AssetsManager.EHBBFMCILPC.anthologyAssets[i].header.index, -1, FLDBFOADFLH.startDownloadAndProceed, false, false, false, null, -1, false, "", this.DBBKFHBELNJ(AssetsManager.EHBBFMCILPC.anthologyAssets[i], false), this.DBBKFHBELNJ(AssetsManager.EHBBFMCILPC.anthologyAssets[i], true));
			}
			for (int j = 0; j < LiveEventsManager.EHBBFMCILPC.liveEvents.Count; j++)
			{
				if (!LiveEventsManager.EHBBFMCILPC.liveEvents[j].OFEAPOEDNPC && LiveEventsManager.EHBBFMCILPC.liveEvents[j].HHEFKECNJDA(LanguageManager.EHBBFMCILPC.GetSelectedLanguage()))
				{
					AssetsManager.EHBBFMCILPC.QueueAssetBundleDownload(NMKDCBPMCKI.AssetBundleLiveEventContent, LiveEventsManager.EHBBFMCILPC.liveEvents[j].MHLOFNCHELC, -1, FLDBFOADFLH.startDownloadAndProceed, false, false, false, null, -1, false, LiveEventsManager.EHBBFMCILPC.liveEvents[j].IFKICNLMPPD, this.BKIMAKDLMMK(LiveEventsManager.EHBBFMCILPC.liveEvents[j]), false);
				}
			}
		}
		GDOKLFCLLIK gdoklfcllik = DNPIKPDMKKI.GLLDFBGBLCM("lobby", false);
		if (gdoklfcllik != null)
		{
			AssetsManager.EHBBFMCILPC.QueueAssetBundleDownload(NMKDCBPMCKI.AssetBundleLiveOfferContent, gdoklfcllik.JKLHDDADKNH, -1, FLDBFOADFLH.startDownloadAndProceed, false, false, false, null, -1, false, "", false, false);
		}
		AssetsManager.EHBBFMCILPC.QueueAssetBundleDownload(NMKDCBPMCKI.AssetBundleLobbyData, 0, -1, FLDBFOADFLH.startDownloadAndProceed, false, false, false, null, -1, false, "", false, false);
		AssetsManager.EHBBFMCILPC.QueueLobbyData2Bundle();
		AssetsManager.EHBBFMCILPC.QueueAssetBundleDownload(NMKDCBPMCKI.AssetBundleProfileData, 0, -1, FLDBFOADFLH.startDownloadAndProceed, false, false, false, null, -1, false, "", false, false);
		if (SceneLobbyManager2.selectedFirstStoryOffering >= 0)
		{
			AssetsManager.EHBBFMCILPC.GetLoadingProgressSnapshot().GIJKJMMDJEL(0.25f, 0.8f);
		}
		else if (this.PLJLNEAKFDK == EJDDNONEDNM.loadIntoStory)
		{
			AssetsManager.EHBBFMCILPC.GetLoadingProgressSnapshot().GIJKJMMDJEL(0.2f, 0.9f);
		}
		else
		{
			AssetsManager.EHBBFMCILPC.GetLoadingProgressSnapshot().GIJKJMMDJEL(0.2f, 1f);
		}
		AssetsManager.EHBBFMCILPC.GetLoadingProgressSnapshot().CLIOEOLFFLO(LEJKDNAGDHC.Normal);
		AssetsManager.EHBBFMCILPC.DownloadQueuedAssetBundles("OnSceneLobbyManagerRound0aAssetsDownloadSuccess", "OnSceneLobbyManagerAssetsDownloadFailed", false);
		FirebaseAnalyticsManager.EHBBFMCILPC.LogEvent(false, AGEHCPDNBFD.cdnActiv.ToString(), FFPHBMFGCNN.dldStart.ToString(), BGHLMGPPCNN.cdnLbyLoadPt2.ToString(), false, false);
	}

	// Token: 0x060021C7 RID: 8647 RVA: 0x000EC72C File Offset: 0x000EA92C
	private void AFJFEPIBBHN()
	{
		SceneLobbyManager2.lobbyIsActive = false;
		this.PEOGENJHMLL();
		AssetsManager.EHBBFMCILPC.ELMMNGFPGKE(KDCJJBLGCBH.EHBBFMCILPC.GAOBDHNPING());
		this.PDFIHFFJMJN = false;
		SceneLobbyManager2.lobbyIsLoading = true;
		this.EFJGLLPDJKO();
		this.DDBMAENEIAA();
		this.PGFANABDIBK = true;
		if (AKLFPGMDKLA.EHBBFMCILPC.EGOCMDJBLNJ > 0)
		{
			AKLFPGMDKLA.EHBBFMCILPC.IEGJCPDCLMM = -1;
		}
		if (AKLFPGMDKLA.EHBBFMCILPC.EEHGLPEIIHD == null || AKLFPGMDKLA.EHBBFMCILPC.EEHGLPEIIHD.Length == 0)
		{
			this.KLLKPDGCMLH();
			return;
		}
		if (AKLFPGMDKLA.EHBBFMCILPC.IEGJCPDCLMM >= 0 && AKLFPGMDKLA.EHBBFMCILPC.EJLCEBPHPJE >= 1 && AKLFPGMDKLA.EHBBFMCILPC.AMAMNOFLPGM(AKLFPGMDKLA.EHBBFMCILPC.EJLCEBPHPJE) != null)
		{
			this.PLJLNEAKFDK = EJDDNONEDNM.stayInLobby;
		}
		else
		{
			this.PLJLNEAKFDK = EJDDNONEDNM.loadIntoStory;
		}
		CommonUserInterface.EHBBFMCILPC.KLEJAGLPCNM(CCOJBMMKNAP.AEELGGPEJCC().PKNHKGMNCIP("dialogOffsetYPlayerSideSeparate"), 0);
		if (this.PLJLNEAKFDK == EJDDNONEDNM.loadIntoStory)
		{
			this.PGFANABDIBK = true;
			AKLFPGMDKLA.EHBBFMCILPC.EBNJHPICFGE(AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(AKLFPGMDKLA.EHBBFMCILPC.MLIDICIPNDK(AKLFPGMDKLA.EHBBFMCILPC.EJLCEBPHPJE).ILOKBAPEJPK), 1);
			BackendOperationsManager.EHBBFMCILPC.ENPDOAKBIHC();
			BackendOperationsManager.EHBBFMCILPC.RequestLoadDefaultBundlesAndStartPlayChapter(AKLFPGMDKLA.GIJABPFHGMO(AKLFPGMDKLA.EHBBFMCILPC.IEGJCPDCLMM, AKLFPGMDKLA.EHBBFMCILPC.LMGMHHLLOFN(AKLFPGMDKLA.EHBBFMCILPC.EJLCEBPHPJE).ILOKBAPEJPK), AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(AKLFPGMDKLA.EHBBFMCILPC.EDHKCJCAFIO(AKLFPGMDKLA.EHBBFMCILPC.EJLCEBPHPJE).ILOKBAPEJPK).DHONIOBOLEL.DDEDAHCFHJN(), AKLFPGMDKLA.EHBBFMCILPC.EJLCEBPHPJE, "energyhinttitle", "passinfobtndesc0X");
			return;
		}
		BackendOperationsManager.NPDDBAONMJP().RequestLoadDefaultBundles("OnCutsceneViewAssetsDownloadSuccess", "SceneLobbyManager2._DownloadLiveProfileThemesBackground(): downloading live profile themes ", false);
	}

	// Token: 0x060021C8 RID: 8648 RVA: 0x000EC8E4 File Offset: 0x000EAAE4
	public void PreInitializeThumbnailsPart1()
	{
		bool flag = false;
		bool flag2 = false;
		bool flag3 = false;
		bool flag4 = false;
		bool flag5 = false;
		bool flag6 = false;
		bool flag7 = false;
		bool flag8 = false;
		if (HBKMKCBPJDI.BHJPELGEBBI())
		{
			AKLFPGMDKLA.EHBBFMCILPC.LPCBDEBKAIM();
		}
		if (EEIBKLDNBAP.PCJGFGDGIDM() && 1 != AKLFPGMDKLA.EHBBFMCILPC.APLCOFLOAPA)
		{
			DPGJIJGOCIC.NFIDPOMCNLP("[LoadingTheme] drop notice without a marked theme, dropped");
			EEIBKLDNBAP.JFMGICMMFBC();
		}
		if (AKLFPGMDKLA.EHBBFMCILPC.JDMBJMHEPMD > 0 || AKLFPGMDKLA.EHBBFMCILPC.CGFOFGGHLEE > 0)
		{
			flag3 = true;
			this.returnRewardManager.Show(AKLFPGMDKLA.EHBBFMCILPC.JDMBJMHEPMD, AKLFPGMDKLA.EHBBFMCILPC.CGFOFGGHLEE);
		}
		else if (AKLFPGMDKLA.EHBBFMCILPC.HCEHBFCIIHN() >= 3 && null != AssetsManager.EHBBFMCILPC.lobbyDataAsset && !AKLFPGMDKLA.EHBBFMCILPC.EFENJAOHCIH.Equals(AssetsManager.EHBBFMCILPC.lobbyDataAsset.updateWelcomeId) && AssetsManager.EHBBFMCILPC.lobbyDataAsset.updateWelcomeSupportedLangs.Contains(LanguageManager.EHBBFMCILPC.GetSelectedLanguage().ToString()))
		{
			flag = true;
			CommonUserInterface.EHBBFMCILPC.ShowPopupUpdateWelcome();
		}
		else if (AKLFPGMDKLA.EHBBFMCILPC.BJIDACANAJH > 0 || AKLFPGMDKLA.EHBBFMCILPC.PNNHDJFBHOL > 0)
		{
			flag2 = true;
			int pnnhdjfbhol = AKLFPGMDKLA.EHBBFMCILPC.PNNHDJFBHOL;
			int bjidacanajh = AKLFPGMDKLA.EHBBFMCILPC.BJIDACANAJH;
			this.dailyRewardManager.Show(AKLFPGMDKLA.EHBBFMCILPC.DBJMOAOBHKE, AKLFPGMDKLA.EHBBFMCILPC.BJIDACANAJH, AKLFPGMDKLA.EHBBFMCILPC.PNNHDJFBHOL);
		}
		else if (!AKLFPGMDKLA.EHBBFMCILPC.EAFEJCKIEPL(5))
		{
			flag4 = true;
			AKLFPGMDKLA.EHBBFMCILPC.LDAPMNLGAPC(5);
			AKLFPGMDKLA.EHBBFMCILPC.LDAPMNLGAPC(59);
			CommonUserInterface.EHBBFMCILPC.ShowGenericPopupTwoOverride(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("tutorgametitle"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("tutorgamebody"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("ok"), new UnityAction(this.BCKFLJLMNDC), new UnityAction(this.BCKFLJLMNDC), DFGILFBGPLN.popupTutorialLobby0, 0f, 28);
		}
		else if (!AKLFPGMDKLA.EHBBFMCILPC.EAFEJCKIEPL(6) && LanguageManager.EHBBFMCILPC.GetSelectedLanguage() == CEIBHCNNIDC.ru && AKLFPGMDKLA.EHBBFMCILPC.HCEHBFCIIHN() >= 3 && KDCJJBLGCBH.EHBBFMCILPC.POGBNANIKCA())
		{
			flag5 = true;
			AKLFPGMDKLA.EHBBFMCILPC.LDAPMNLGAPC(6);
			if (LanguageManager.EHBBFMCILPC.GetSelectedLanguage() == CEIBHCNNIDC.ru)
			{
				CommonUserInterface.EHBBFMCILPC.ShowPopupOnlineResources(AssetsManager.EHBBFMCILPC.lobbyDataAsset.onlineResourcesLink, -1);
			}
			else
			{
				CommonUserInterface.EHBBFMCILPC.ShowPopupOnlineResources(AssetsManager.EHBBFMCILPC.lobbyDataAsset.onlineResourcesLinkEn, -1);
			}
		}
		else if (AKLFPGMDKLA.EHBBFMCILPC.JPDHGCINOJD())
		{
			flag6 = true;
			CommonUserInterface.EHBBFMCILPC.ShowGenericPopupTwoOverride(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("importanttitle"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("ownerchangesuccess"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("ok"), new UnityAction(this.BCKFLJLMNDC), new UnityAction(this.BCKFLJLMNDC), DFGILFBGPLN.popupOwnerChangeSuccess, 0f, 28);
		}
		else if (!AKLFPGMDKLA.EHBBFMCILPC.EAFEJCKIEPL(60) && !AKLFPGMDKLA.EHBBFMCILPC.MMILLGIKOFJ(true, true, true, true, true))
		{
			flag7 = true;
			AKLFPGMDKLA.EHBBFMCILPC.LDAPMNLGAPC(60);
			CommonUserInterface.EHBBFMCILPC.ShowGenericPopupTwoOverride(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("importanttitle"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("tutorialsigninrec"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("ok"), new UnityAction(this.BCKFLJLMNDC), new UnityAction(this.BCKFLJLMNDC), DFGILFBGPLN.popupTutorialLobby0, 0f, 28);
		}
		else if (1 == AKLFPGMDKLA.EHBBFMCILPC.APLCOFLOAPA && EEIBKLDNBAP.OCNPLOOGPCN() == 0 && !KDCJJBLGCBH.EHBBFMCILPC.AMHJKMPIPGK())
		{
			AKLFPGMDKLA.EHBBFMCILPC.APLCOFLOAPA = 0;
			flag8 = true;
			string dmnkdcgmkkp = "cardoptionsloadingthemelost";
			if (EEIBKLDNBAP.PCJGFGDGIDM())
			{
				EEIBKLDNBAP.JFMGICMMFBC();
				if (HBKMKCBPJDI.MCNPBFPFBDA())
				{
					dmnkdcgmkkp = "cardoptionsloadingthemelostbonus";
				}
			}
			CommonUserInterface.EHBBFMCILPC.ShowGenericPopupTwoOverride(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("importanttitle"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP(dmnkdcgmkkp), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("ok"), new UnityAction(this.BCKFLJLMNDC), new UnityAction(this.BCKFLJLMNDC), DFGILFBGPLN.popupTutorialLobby0, 0f, 28);
			AKLFPGMDKLA.EHBBFMCILPC.LPCBDEBKAIM();
		}
		else if (EEIBKLDNBAP.ECMBPHMLCOI())
		{
			EEIBKLDNBAP.MJDIDOBOOEN();
			if (!KDCJJBLGCBH.EHBBFMCILPC.AMHJKMPIPGK())
			{
				flag8 = true;
				CommonUserInterface.EHBBFMCILPC.ShowGenericPopupTwoOverride(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("importanttitle"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("cardoptionsloadingthemelostlite"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("ok"), new UnityAction(this.BCKFLJLMNDC), new UnityAction(this.BCKFLJLMNDC), DFGILFBGPLN.popupTutorialLobby0, 0f, 28);
			}
		}
		else if (EEIBKLDNBAP.EKDKPPOGMGP())
		{
			EEIBKLDNBAP.OJIHFHOLPCA();
			if (!KDCJJBLGCBH.EHBBFMCILPC.AMHJKMPIPGK())
			{
				flag8 = true;
				CommonUserInterface.EHBBFMCILPC.ShowGenericPopupTwoOverride(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("importanttitle"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("cardoptionsloadingthemecrash"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("ok"), new UnityAction(this.BCKFLJLMNDC), new UnityAction(this.BCKFLJLMNDC), DFGILFBGPLN.popupTutorialLobby0, 0f, 28);
			}
		}
		if (null != AssetsManager.EHBBFMCILPC.lobbyDataAsset)
		{
			if (!AKLFPGMDKLA.EHBBFMCILPC.EFENJAOHCIH.Equals(AssetsManager.EHBBFMCILPC.lobbyDataAsset.updateWelcomeId))
			{
				AKLFPGMDKLA.EHBBFMCILPC.KOLIAGHNJCN();
			}
			AKLFPGMDKLA.EHBBFMCILPC.EFENJAOHCIH = AssetsManager.EHBBFMCILPC.lobbyDataAsset.updateWelcomeId;
		}
		AKLFPGMDKLA.EHBBFMCILPC.JPDHGCINOJD();
		this.NAEHPAIOHLG.EPJKDCDOEMM((float)SceneLobbyManager2.energyFireTime);
		this.ENJMJIPADNO.EPJKDCDOEMM((float)SceneLobbyManager2.dailyRewardFireTime);
		if (!flag3 && !flag && !flag2 && !flag4 && !flag5 && !flag7 && !flag8 && !flag6)
		{
			this.FNGNDLPNNBH();
			this.KKKKNGFMEHF();
			return;
		}
		if (flag3)
		{
			this.NHBPLAFBNIG(AKLFPGMDKLA.EHBBFMCILPC.MPMKMCJFHOG.GALKFKBPLCK() - AKLFPGMDKLA.EHBBFMCILPC.JDMBJMHEPMD, AKLFPGMDKLA.EHBBFMCILPC.ODMKLADKHMO.GALKFKBPLCK() - AKLFPGMDKLA.EHBBFMCILPC.CGFOFGGHLEE);
			AKLFPGMDKLA.EHBBFMCILPC.JDMBJMHEPMD = -1;
			AKLFPGMDKLA.EHBBFMCILPC.CGFOFGGHLEE = -1;
			return;
		}
		if (flag2)
		{
			this.NHBPLAFBNIG(AKLFPGMDKLA.EHBBFMCILPC.MPMKMCJFHOG.GALKFKBPLCK() - AKLFPGMDKLA.EHBBFMCILPC.BJIDACANAJH, AKLFPGMDKLA.EHBBFMCILPC.ODMKLADKHMO.GALKFKBPLCK() - AKLFPGMDKLA.EHBBFMCILPC.PNNHDJFBHOL);
			AKLFPGMDKLA.EHBBFMCILPC.BJIDACANAJH = -1;
			AKLFPGMDKLA.EHBBFMCILPC.PNNHDJFBHOL = -1;
			AKLFPGMDKLA.EHBBFMCILPC.DBJMOAOBHKE = -1;
			return;
		}
		if (flag4 || flag6 || flag5 || flag || flag7 || flag8)
		{
			this.KKKKNGFMEHF();
		}
	}

	// Token: 0x060021C9 RID: 8649 RVA: 0x000ECF85 File Offset: 0x000EB185
	private void BMIOALPLMAK()
	{
		this.DCFBAMCJCFK = 0;
		this.OBPPPNCALNP = 1;
		this.FJIAGECENLF = 1;
		this.LIDPKKFBNMC = 0;
		this.HGIKEMNOGOO = 0;
		this.NEEMPAAFHEI = 1;
		this.CDJGGOJBGJF = 1;
	}

	// Token: 0x060021CA RID: 8650 RVA: 0x000ECFB8 File Offset: 0x000EB1B8
	private void IDJEMNCLFDN()
	{
		try
		{
			SceneLobbyManager2.KAFNANCDMNF = null;
			this.KOGLEPFNALN = false;
			this.MJOMHIEMKMK = "";
			this.BPCHEOFFPCN.Clear();
			this.EEGHJFAIMBF.Clear();
			this.IIDEKJNAFKG.Clear();
			this.NODBJCOJNLJ.Clear();
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x060021CB RID: 8651 RVA: 0x000ED024 File Offset: 0x000EB224
	public void EANHFNEFGFB()
	{
		LobbyUserInterface.EHBBFMCILPC.MKJHHOJAMHN().FlipVerticalAnimatedPopupManagerAnimationsScale();
		this.ShowCardOptionsOrDownload();
	}

	// Token: 0x060021CC RID: 8652 RVA: 0x000ED03C File Offset: 0x000EB23C
	private bool OGMODMPACPJ()
	{
		bool result;
		try
		{
			if (this.DINHJIBBGJL >= 0)
			{
				result = (1 == this.DINHJIBBGJL);
			}
			else
			{
				bool flag = this.IAJDGBMPJNC();
				if (flag)
				{
					this.DINHJIBBGJL = 1;
				}
				else
				{
					this.DINHJIBBGJL = 0;
				}
				result = flag;
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
			result = false;
		}
		return result;
	}

	// Token: 0x060021CD RID: 8653 RVA: 0x000ED094 File Offset: 0x000EB294
	private void OFHBPNBDAKO()
	{
		this.KKKKNGFMEHF();
		if (SceneLobbyManager2.startChapterManInTheMiddleAttack == 1)
		{
			CommonUserInterface.EHBBFMCILPC.HideConnectingAnimation();
			return;
		}
		if (SceneLobbyManager2.startPlayChapterBackendOperationResult >= 0)
		{
			if (AKLFPGMDKLA.EHBBFMCILPC.DHFJGFHBIOH(JFGBECHLPGI.energy) != 0)
			{
				this.currencyTeaFallingImage.gameObject.SetActive(true);
				this.currencyTeaFallingImage.GetComponent<AnimationTranslation>().PlayAnimation();
				this.currencyTeaFallingImage.GetComponent<AnimationCanvasGroupAlpha>().PlayAnimation(false);
				int klpbigjbobe = AKLFPGMDKLA.EHBBFMCILPC.KLPBIGJBOBE;
			}
			base.StartCoroutine(this.LLBEBFGIMKL());
			return;
		}
		this.GBBHKFFENBE = false;
		CommonUserInterface.EHBBFMCILPC.HideConnectingAnimation();
		CommonUserInterface.EHBBFMCILPC.GetPurchasingViewManager().SetResourcesFilter(JFGBECHLPGI.energy);
		this.OnNeedToShowNoMoreEnergyPopup();
	}

	// Token: 0x060021CE RID: 8654 RVA: 0x000ED143 File Offset: 0x000EB343
	public void OnOpenStoryCardFocusItem()
	{
		this.focusItem.GetComponent<FocusItem>().CloseFocus();
		this.CPLLGNAKIIL(this.LGKGGPDKAHF);
	}

	// Token: 0x060021CF RID: 8655 RVA: 0x000ED164 File Offset: 0x000EB364
	private bool IAJDGBMPJNC()
	{
		bool result;
		try
		{
			if (!this.OIOACPLBJLJ())
			{
				result = false;
			}
			else if (this.MMJJBECDAOC())
			{
				result = false;
			}
			else if (null == AssetsManager.EHBBFMCILPC || null == AssetsManager.EHBBFMCILPC.lobbyDataAsset)
			{
				result = false;
			}
			else if (!AssetsManager.EHBBFMCILPC.lobbyDataAsset.HFHBDPDGEGJ())
			{
				result = false;
			}
			else if (!AssetsManager.EHBBFMCILPC.lobbyDataAsset.DKIPBODMOHM(LanguageManager.EHBBFMCILPC.GetSelectedLanguage()))
			{
				result = false;
			}
			else
			{
				List<POKPDFKMOFC> list = this.PGJLBHNMHMP();
				if (list == null || list.Count == 0)
				{
					result = false;
				}
				else
				{
					EAFPOMNMOFP eafpomnmofp = AssetsManager.EHBBFMCILPC.lobbyDataAsset.JDMCDEKHDHM();
					CEIBHCNNIDC selectedLanguage = LanguageManager.EHBBFMCILPC.GetSelectedLanguage();
					for (int i = 0; i < list.Count; i++)
					{
						string text = eafpomnmofp.CFBKLIEBLOF(list[i].IEJLOIMDPDO, selectedLanguage);
						if (text != null && text.Length > 0)
						{
							return true;
						}
					}
					DPGJIJGOCIC.ADFCDFHBDAF("SceneLobbyManager2.ComputeStarterTabAvailable() - no starter concept has a name in the text pack explore tab (older text pack bundle?), tab hidden");
					result = false;
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
			result = false;
		}
		return result;
	}

	// Token: 0x060021D0 RID: 8656 RVA: 0x000ED288 File Offset: 0x000EB488
	private void HINDFDCEKAK()
	{
		SceneLoungeManager sceneLoungeManager = AssetsManager.EHBBFMCILPC.GetSceneLoungeManager(0);
		PLFDAJJHMKO plfdajjhmko = AKLFPGMDKLA.EHBBFMCILPC.NBMLMNGHOPP();
		if (null == sceneLoungeManager || plfdajjhmko == null)
		{
			DPGJIJGOCIC.ANOPFDLPKGC("SceneLobbyManager2.LobbyLoungePart2(), lounge scene or save missing");
			this.MHAMPPBECNM = false;
			SceneLoungeManager.SetPendingLoungeCharacter(null);
			SceneLoungeManager.SetPendingLoungeLook(null);
			CommonUserInterface.EHBBFMCILPC.GetFader().FadeOut(null);
			return;
		}
		if (this.DFEMFJJDGML.Count == 0)
		{
			DPGJIJGOCIC.ANOPFDLPKGC("SceneLobbyManager2.LobbyLoungePart2(), no eligible lounge characters");
			this.MHAMPPBECNM = false;
			SceneLoungeManager.SetPendingLoungeCharacter(null);
			SceneLoungeManager.SetPendingLoungeLook(null);
			CommonUserInterface.EHBBFMCILPC.GetFader().FadeOut(null);
			CommonUserInterface.EHBBFMCILPC.ShowGenericPopup(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("importanttitle"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("loungenotavailable"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("ok"), DFGILFBGPLN.popupSignInQuestion, 0f, 28);
			for (int i = 0; i < this.lobbyParticles.Count; i++)
			{
				if (null != this.lobbyParticles[i])
				{
					this.lobbyParticles[i].gameObject.SetActive(true);
					this.lobbyParticles[i].Play();
				}
			}
			this.OBKCLKMPKCI = false;
			this.FMJEJOGDBHA = false;
			base.StartCoroutine(this.MKMFFEOMLIO());
			return;
		}
		AOBJLALDBAA.EHBBFMCILPC.EGELHPJBAIC("OnNeedToDeactivateFocusItemCloseButton", 0f);
		this.OKKBOFKILEA();
		this.ALGIAIKDEPH();
		for (int j = 0; j < this.lobbyParticles.Count; j++)
		{
			if (null != this.lobbyParticles[j])
			{
				this.lobbyParticles[j].Clear();
				this.lobbyParticles[j].gameObject.SetActive(false);
			}
		}
		this.LLHKAGPCAKD(plfdajjhmko);
		SceneLoungeManager.SetPendingLoungeMode(this.OBKCLKMPKCI, this.FMJEJOGDBHA);
		SceneLoungeManager.SetPendingLoungeLoveInterestsStripHidden(this.EDGAPOIIHKC);
		sceneLoungeManager.SetLoungeCharacters(this.DFEMFJJDGML);
		for (int k = 0; k < this.PEFDGDNCHGD.Count; k++)
		{
			StoryEnvironmentManager storyEnvironmentManager = SceneLobbyManager2.KFLJELOKJJO(this.KGOCEEAGLKO, this.PEFDGDNCHGD[k], plfdajjhmko);
			if (null == storyEnvironmentManager)
			{
				DPGJIJGOCIC.ANOPFDLPKGC("SceneLobbyManager2.LobbyLoungePart2(), lounge environment not found:" + this.PEFDGDNCHGD[k]);
			}
			else
			{
				sceneLoungeManager.SetLoungeEnvironment(this.FLLHKGKNAOK[k], storyEnvironmentManager.gameObject);
				StoryEnvironmentManager storyEnvironmentManager2 = SceneLobbyManager2.KFLJELOKJJO(this.OEDPPJGKPFO, this.PEFDGDNCHGD[k], plfdajjhmko);
				if (null != storyEnvironmentManager2)
				{
					sceneLoungeManager.SetLoungeEnvironment(this.FLLHKGKNAOK[k], storyEnvironmentManager2.gameObject);
				}
			}
		}
		sceneLoungeManager.Show(false);
		AudioManager.EHBBFMCILPC.FadeMusic(1f, 1f);
	}

	// Token: 0x060021D1 RID: 8657 RVA: 0x000ED54C File Offset: 0x000EB74C
	private void AOLGCEPKNDB()
	{
		try
		{
			this.rewardFade.SetActive(true);
			base.StartCoroutine(this.FINPCOMDIFD(this.rewardFade, this.rewardItem, this.timeFocusItemAnimation, true));
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x060021D2 RID: 8658 RVA: 0x000ED5A0 File Offset: 0x000EB7A0
	private IEnumerator ELPJIHLDEFP(JBBNEEHANHL GLOCCAIDHJC)
	{
		SceneLobbyManager2.GDEHICBPJMC gdehicbpjmc = new SceneLobbyManager2.GDEHICBPJMC();
		gdehicbpjmc.filter = GLOCCAIDHJC;
		if (JBBNEEHANHL.filterSearch == gdehicbpjmc.filter)
		{
			if (!this.KOGLEPFNALN || this.BPCHEOFFPCN.Count == 0)
			{
				yield break;
			}
			this.LBHJBEANCDC();
		}
		try
		{
			if (JBBNEEHANHL.filterTopRated == gdehicbpjmc.filter || JBBNEEHANHL.filterExplore == gdehicbpjmc.filter)
			{
				this.recommendedSetupButton.SetActive(true);
				this.MKOHINMNEAI = true;
			}
			else
			{
				this.recommendedSetupButton.SetActive(false);
				this.MKOHINMNEAI = false;
			}
			if (SceneLobbyManager2.IsGroupedFilter(gdehicbpjmc.filter) && this.HKNBOLLEAGE(gdehicbpjmc.filter) && !this.MGNNOFPKGJF.Exists(new Predicate<GameObject>(gdehicbpjmc.NJJOADMCJLD)))
			{
				this.HPOCOHEODDF(gdehicbpjmc.filter);
			}
			if (KDCJJBLGCBH.EHBBFMCILPC.FPLLPBJFCIK() && JBBNEEHANHL.filterSearch != gdehicbpjmc.filter && !SceneLobbyManager2.IsGroupedFilter(gdehicbpjmc.filter) && !this.MGNNOFPKGJF.Exists(new Predicate<GameObject>(gdehicbpjmc.NCAIKNPLINE)))
			{
				GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(this.smallItemParentPrefab, this.scrollView0Content);
				gameObject.GetComponent<GridController>().filter = gdehicbpjmc.filter;
				this.MGNNOFPKGJF.Add(gameObject);
				this.MHFIHLIELBH(gdehicbpjmc.filter, gameObject);
				gameObject.GetComponent<GridController>().UpdateGrid();
				float gridHeight = gameObject.GetComponent<GridController>().GetGridHeight();
				gameObject.GetComponent<RectTransform>().ACBKFBBCNNC(gridHeight);
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
		yield return new WaitForEndOfFrame();
		try
		{
			foreach (GameObject gameObject2 in this.MGNNOFPKGJF)
			{
				if (gameObject2.activeSelf)
				{
					gameObject2.SetActive(false);
				}
			}
			foreach (GameObject gameObject3 in this.MGNNOFPKGJF)
			{
				if (gameObject3.GetComponent<GridController>().filter == gdehicbpjmc.filter)
				{
					gameObject3.SetActive(true);
				}
			}
			yield break;
		}
		catch (Exception aklgbjkdomm2)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm2);
			yield break;
		}
		yield break;
	}

	// Token: 0x060021D3 RID: 8659 RVA: 0x000ED5B6 File Offset: 0x000EB7B6
	private void HGPGOPCOFKB()
	{
		base.StartCoroutine(this.LCNJLBEOKPB());
	}

	// Token: 0x060021D4 RID: 8660 RVA: 0x000ED5C5 File Offset: 0x000EB7C5
	private IEnumerator MEHPOEFIGHG()
	{
		yield return new WaitForSeconds(3f);
		this.MBGPADGCJBM = false;
		yield break;
	}

	// Token: 0x060021D5 RID: 8661 RVA: 0x000ED5D4 File Offset: 0x000EB7D4
	private void IOPEFJJGAFF()
	{
		CommonUserInterface.EHBBFMCILPC.HideConnectingAnimation();
		this.LDENMOBNFIP();
	}

	// Token: 0x060021D6 RID: 8662 RVA: 0x000ED5E8 File Offset: 0x000EB7E8
	private void POGPOFCBJJC()
	{
		if (DNPIKPDMKKI.EOKDBPJCHIE("ExploreHub.Populate() - row ") != null && DNPIKPDMKKI.EACEODHOPIN("$").NHKCEMHKODM == LJLAENEAOIM.liveOfferPass)
		{
			KIOOJMGLCLC kioojmglclc = ODLJHDIGLGO.DMHPFIOMFGD(DNPIKPDMKKI.EEDJKIJJDAN("p").OKHMNFLFDOM);
			if (kioojmglclc != null && kioojmglclc.ALFGPLALKCN())
			{
				AOBJLALDBAA.BIAEAOMHBMM().FDKBIBKABCM(DNPIKPDMKKI.LEMILALILKP("</i>").BDKJOHKAFFO, 394f);
			}
		}
		DNPIKPDMKKI.POBOHFGNPGK();
	}

	// Token: 0x060021D7 RID: 8663 RVA: 0x000ED658 File Offset: 0x000EB858
	private void KBNJAFKIGHD()
	{
		try
		{
			CommonUserInterface.EHBBFMCILPC.ResumeUX();
			int num = 0;
			if (PlayerPrefs.HasKey("ratePopupResult"))
			{
				num = PlayerPrefs.GetInt("ratePopupResult");
			}
			bool flag = false;
			if (AKLFPGMDKLA.EHBBFMCILPC.KLLJJOLILJN() > (double)KBOJLHAJPCP.IDINKPALBDE && num != 4 && num != 2 && (num == 0 || (num == 3 && AKLFPGMDKLA.EHBBFMCILPC.ICHIDHIENAO() > (double)KBOJLHAJPCP.KPPEDMIMEJP)))
			{
				AKLFPGMDKLA.EHBBFMCILPC.JNKFGNJJHBD();
				flag = true;
				ApplicationFocusManager.Deactivate();
				CommonUserInterface.EHBBFMCILPC.ShowGenericPopupWithThreeButtonsInside(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("ratetitle"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("ratebody"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("rateyes"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("ratelater"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("rateno"), new UnityAction(this.LCONLDIONOE), new UnityAction(this.IODEDCGDMDE), new UnityAction(this.AMMBPNFINOH), new UnityAction(this.NBPBCFIBDPO), DFGILFBGPLN.popupTools, 0.5f, 28).ShowStars();
			}
			if (AKLFPGMDKLA.EHBBFMCILPC.KLLJJOLILJN() > (double)KBOJLHAJPCP.HCECNEDKJDP && !flag && !PlayerPrefs.HasKey("socialJoinRequest"))
			{
				this.PAJHBBAHDOM();
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
			CommonUserInterface.EHBBFMCILPC.ResumeUX();
		}
	}

	// Token: 0x060021D8 RID: 8664 RVA: 0x000ED7C8 File Offset: 0x000EB9C8
	private void ELKBJDBEMCP()
	{
		this.NLAFDANCAFK();
		this.EMLEKJBMOPC();
		this.IIDHAKNKIKO();
		JBBNEEHANHL[] array = new JBBNEEHANHL[]
		{
			JBBNEEHANHL.filterStarter,
			JBBNEEHANHL.filterNew,
			JBBNEEHANHL.filterTopRated,
			JBBNEEHANHL.filterExplore,
			JBBNEEHANHL.filterFranchises,
			JBBNEEHANHL.filterMostPopular,
			JBBNEEHANHL.filterFavorites,
			JBBNEEHANHL.filterContinuePlaying,
			JBBNEEHANHL.filterAll
		};
		Transform transform = null;
		foreach (JBBNEEHANHL jbbneehanhl in array)
		{
			if (this.CMGDKBFDGLF(jbbneehanhl) && (jbbneehanhl != JBBNEEHANHL.filterNew || !this.MMJJBECDAOC()) && (jbbneehanhl != JBBNEEHANHL.filterTopRated || AKLFPGMDKLA.EHBBFMCILPC.JPANCNNAEEJ().Count >= 2) && (JBBNEEHANHL.filterTopRated != jbbneehanhl || !this.IINBDHLPNMP()) && (jbbneehanhl != JBBNEEHANHL.filterMostPopular || PLBBPHIJMAH.FGCMPALLMCD.Count != 0) && (jbbneehanhl != JBBNEEHANHL.filterContinuePlaying || this.LGFLDJCAJNC() != 0 || this.LINADLBCHJC() != 0) && jbbneehanhl != JBBNEEHANHL.filterCompleted && (jbbneehanhl != JBBNEEHANHL.filterFavorites || AKLFPGMDKLA.EHBBFMCILPC.JCBEPJJHAII(AssetsManager.EHBBFMCILPC.anthologyAssets).Count != 0))
			{
				GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(this.filterItemPrefab, this.filterItemsParent);
				this.EKIFLHLCLKG.Add(gameObject);
				gameObject.GetComponent<Toggle>().group = this.toogleGroupOnFilterItemsParent;
				if (jbbneehanhl.ToString() == this.AECCHBMDHBE())
				{
					transform = gameObject.transform;
				}
				gameObject.GetComponent<FilterItem>().SetContent(jbbneehanhl, new UnityAction<JBBNEEHANHL>(this.OHGHMGPHLBM), this.scrollView2Controller);
			}
		}
		try
		{
			if (null == transform && this.EKIFLHLCLKG.Count > 0)
			{
				transform = this.EKIFLHLCLKG[0].transform;
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
		base.StartCoroutine(this.APOFMEEFIGD(transform));
	}

	// Token: 0x060021D9 RID: 8665 RVA: 0x000ED970 File Offset: 0x000EBB70
	private void FGOFPMAGNMJ()
	{
		this.NPLNHOMBILM++;
		if (this.NPLNHOMBILM >= KBOJLHAJPCP.LPJOFEDNKHA)
		{
			CommonUserInterface.EHBBFMCILPC.HideConnectingAnimation();
			FirebaseAnalyticsManager.EHBBFMCILPC.LogEvent(false, AGEHCPDNBFD.cdnActiv.ToString(), FFPHBMFGCNN.dldFail.ToString(), BGHLMGPPCNN.cdnLbyToSks.ToString(), false, false);
			this.NPLNHOMBILM = 0;
			this.GBBHKFFENBE = false;
			CommonUserInterface.EHBBFMCILPC.ShowGenericPopupOneOverride(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("errortitle"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("cdnerror"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("retry"), new UnityAction(this.OnSkinShopClick), DFGILFBGPLN.popupCdnDownloadFailed, 0f, 28);
			return;
		}
		this.OnSkinShopClick();
	}

	// Token: 0x060021DA RID: 8666 RVA: 0x000EDA43 File Offset: 0x000EBC43
	private void OLEJFLFKLNL()
	{
		if (!this.KDLBELFIIDL)
		{
			return;
		}
		if (this.EOOJGEFLJEN.Count > 1)
		{
			base.Invoke("CharacterTransitionManager - acknowledge shader unsupported, skipping accent:", 527f);
			return;
		}
		this.KDLBELFIIDL = false;
		base.StartCoroutine(this.OLMEEDAFNAE());
	}

	// Token: 0x060021DB RID: 8667 RVA: 0x000EDA84 File Offset: 0x000EBC84
	private void ONBPCOOBOFB(JBBNEEHANHL HBBJBNJBMPK)
	{
		try
		{
			FilterItem[] componentsInChildren = this.scrollView2Controller.GetComponentsInChildren<FilterItem>(true);
			for (int i = 0; i < componentsInChildren.Length; i++)
			{
				if (componentsInChildren[i].id == HBBJBNJBMPK)
				{
					componentsInChildren[i].SetActiveFilter(true);
					this.scrollView2Controller.SetItemOnCenterImmediate(componentsInChildren[i].transform);
					break;
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x060021DC RID: 8668 RVA: 0x000EDAF0 File Offset: 0x000EBCF0
	private void ANLMMKGOMLD()
	{
		if (this.PHMIBKAJKMB == null)
		{
			this.PHMIBKAJKMB = FADIGFEOCND.JHMKFKNAADK(1500f);
		}
	}

	// Token: 0x060021DD RID: 8669 RVA: 0x000EDB0C File Offset: 0x000EBD0C
	private void FKOPCAFJEKE()
	{
		if (this.LLCBNGOAGHK >= 259f)
		{
			try
			{
				this.LLCBNGOAGHK -= Time.deltaTime / 91f;
				for (int i = 0; i < this.themesParticles.Count; i += 0)
				{
					if (null != this.themesParticles[i])
					{
						this.themesParticles[i].GetComponent<Renderer>().material.SetColor("PlayerCharacterManager.SetTrinketComponent() - input is null.", new Color(743f, 239f, 628f, this.LLCBNGOAGHK));
					}
				}
				if (this.LLCBNGOAGHK <= 1763f)
				{
					this.LLCBNGOAGHK = 803f;
				}
			}
			catch (Exception aklgbjkdomm)
			{
				DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
			}
		}
		this.PHNIFGGEADM();
		if (this.PDFIHFFJMJN)
		{
			this.EAMBMLCNPNC();
			this.BGNMIIHJALJ();
			this.IKFIJBALMCK();
			this.HCMDGPOACOL -= Time.deltaTime;
			if (this.HCMDGPOACOL <= 1199f)
			{
				this.HCMDGPOACOL = 1279f;
				this.JGOAOAKBONB();
			}
			this.LMIMBBPADKE();
			if ((this.scrollView0Content.offsetMax.y >= 748f || !this.PGKHOKJOCKP) && this.shuffleButton.gameObject.activeSelf)
			{
				this.shuffleButton.gameObject.SetActive(false);
			}
			else if (this.scrollView0Content.offsetMax.y < 293f && !this.shuffleButton.gameObject.activeSelf && this.PGKHOKJOCKP)
			{
				this.shuffleButton.gameObject.SetActive(false);
			}
			if (this.shuffleButton.gameObject.activeSelf)
			{
				this.KHKDPJNCPJN.alpha = Mathf.Clamp01(234f - Mathf.Abs(this.scrollView0Content.offsetMax.y) / 1487f);
				if (!this.EONFEFBLLMK())
				{
					this.KHKDPJNCPJN.alpha = 1963f;
				}
				if (this.KHKDPJNCPJN.alpha > 581f)
				{
					this.shuffleButtonButton.interactable = true;
				}
				else
				{
					this.shuffleButtonButton.interactable = false;
				}
				this.KHGNNCCKEPG.OGOFACPLOGO(this.KIODPNAKDIF);
				if (NarrowScreenScaler.ScreenIsTooNarrow(989f))
				{
					NarrowScreenScaler.showLogs = true;
					float num = Mathf.Abs(1226f - NarrowScreenScaler.PFHKBMALNJF(508f, (IMBLFHMKMAD)(-130)));
					NarrowScreenScaler.showLogs = false;
					num = Mathf.Clamp01(num);
					this.KHGNNCCKEPG.AHLJBONHHKL(261f * num, this.scrollView0Content.offsetMax.y * 124f);
				}
				else
				{
					this.KHGNNCCKEPG.AHLJBONHHKL(1436f, this.scrollView0Content.offsetMax.y * 1958f);
				}
			}
			if ((this.scrollView0Content.offsetMax.y >= 591f || !this.MKOHINMNEAI) && this.recommendedSetupButton.gameObject.activeSelf)
			{
				this.recommendedSetupButton.gameObject.SetActive(false);
			}
			else if (this.scrollView0Content.offsetMax.y < 211f && !this.recommendedSetupButton.gameObject.activeSelf && this.MKOHINMNEAI)
			{
				this.recommendedSetupButton.gameObject.SetActive(false);
			}
			if (this.recommendedSetupButton.gameObject.activeSelf)
			{
				if (this.scrollView0Content.offsetMax.y >= 1699f)
				{
					this.BDLMHIGGAHI.alpha = Mathf.Clamp01(466f - Mathf.Abs(this.scrollView0Content.offsetMax.y - 848f) / 540f);
				}
				else if (this.scrollView0Content.offsetMax.y < 1865f)
				{
					this.BDLMHIGGAHI.alpha = Mathf.Clamp01(644f - Mathf.Abs(this.scrollView0Content.offsetMax.y) / 1666f);
				}
				else
				{
					this.BDLMHIGGAHI.alpha = 1122f;
				}
				this.EJNCBBFGGLH.OGOFACPLOGO(this.CGHKPPLLBKN);
				this.EJNCBBFGGLH.AHLJBONHHKL(1411f, this.scrollView0Content.offsetMax.y * 999f);
			}
		}
		float num2 = AssetsManager.EHBBFMCILPC.GetLoadingProgressSnapshot().LBCJELEFGIJ();
		if (!SceneLobbyManager2.doNotUpdatePercent)
		{
			CommonUserInterface.EHBBFMCILPC.MPELPKNEPOO((num2 * 1568f).ToString("aind1") + "OnLobbyStopFireworksEffect");
		}
	}

	// Token: 0x060021DE RID: 8670 RVA: 0x000EDF98 File Offset: 0x000EC198
	public int GetAnthologyTotalChaptersCount(int PLKMJJIIJNO)
	{
		int result;
		try
		{
			int num = 0;
			for (int i = 0; i < AssetsManager.EHBBFMCILPC.anthologyAssets.Count; i++)
			{
				if (AssetsManager.EHBBFMCILPC.anthologyAssets[i].header.index == PLKMJJIIJNO)
				{
					for (int j = 0; j < AssetsManager.EHBBFMCILPC.anthologyAssets[i].header.maxStories; j++)
					{
						if (j < AssetsManager.EHBBFMCILPC.anthologyAssets[i].header.availableStories.Count)
						{
							AssetStoryHeader assetStoryHeader = GKJPOGNFKNK.CDCEFHLNNEC(AssetsManager.EHBBFMCILPC.anthologyAssets[i].header.availableStories[j]);
							if (null != assetStoryHeader)
							{
								num += assetStoryHeader.totalChaptersCount;
							}
							else
							{
								num += AssetsManager.EHBBFMCILPC.anthologyAssets[i].header.plannedChaptersPerSeason;
							}
						}
						else
						{
							num += AssetsManager.EHBBFMCILPC.anthologyAssets[i].header.plannedChaptersPerSeason;
						}
					}
				}
			}
			result = num;
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
			result = 0;
		}
		return result;
	}

	// Token: 0x060021DF RID: 8671 RVA: 0x000EE0D8 File Offset: 0x000EC2D8
	private void JGOAOAKBONB()
	{
		try
		{
			if (!(null == this.footerRewardsLabel))
			{
				GDOKLFCLLIK gdoklfcllik = DNPIKPDMKKI.MCOMGMOACEM(LJLAENEAOIM.liveOfferCardsVolSale);
				if (gdoklfcllik != null)
				{
					this.footerRewardsLabel.SetText(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP(1282).Replace("{percent}", gdoklfcllik.KEJCIIFAJCA().ToString() ?? ""), true);
					this.footerRewardsLabel.color = SceneLobbyManager2.JFANHEDJDMK;
				}
				else
				{
					this.footerRewardsLabel.SetText(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP(815), true);
					this.footerRewardsLabel.color = Color.white;
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x060021E0 RID: 8672 RVA: 0x000EE19C File Offset: 0x000EC39C
	public PLFDAJJHMKO GetActiveAnthologyStorySafe(int PLKMJJIIJNO)
	{
		AssetAnthology assetAnthology = GKJPOGNFKNK.LDFIAOCJEOJ(PLKMJJIIJNO);
		EIOPLEFLLIM eioplefllim = AKLFPGMDKLA.EHBBFMCILPC.GJBDBONJCDL(PLKMJJIIJNO);
		if (eioplefllim == null)
		{
			return AKLFPGMDKLA.EHBBFMCILPC.JDCBFAPDJIM(assetAnthology.header.availableStories[0], -1);
		}
		if (eioplefllim.EGHHCFFLPCP(-1) >= assetAnthology.header.availableStories.Count)
		{
			return AKLFPGMDKLA.EHBBFMCILPC.JDCBFAPDJIM(assetAnthology.header.availableStories[assetAnthology.header.availableStories.Count - 1], -1);
		}
		return AKLFPGMDKLA.EHBBFMCILPC.JDCBFAPDJIM(assetAnthology.header.availableStories[eioplefllim.EGHHCFFLPCP(-1)], -1);
	}

	// Token: 0x060021E1 RID: 8673 RVA: 0x000EE248 File Offset: 0x000EC448
	public void GEBCCMDEFMH()
	{
		CommonUserInterface.IKNOFBFMPGA().BGJFCEEDGFJ(CCOJBMMKNAP.CEGAOMEEFBE().BGELFMIOBCL(""), CCOJBMMKNAP.DLGLFACMHPG().GGPHHLGPMPA("ok"), CCOJBMMKNAP.PMABBOJDELF().HIPJILDCHJC(""), new UnityAction(this.OnQuitClickPart2), (DFGILFBGPLN)(-127), 1038f, 120);
	}

	// Token: 0x060021E2 RID: 8674 RVA: 0x0005F01E File Offset: 0x0005D21E
	private void HBPLGJFPFKM()
	{
		CommonUserInterface.EHBBFMCILPC.ShowGamePasses();
	}

	// Token: 0x060021E3 RID: 8675 RVA: 0x000EE2A4 File Offset: 0x000EC4A4
	private int LGFLDJCAJNC()
	{
		int num = 0;
		for (int i = 0; i < this.JDFKLJAIHLH.Length; i++)
		{
			if (this.JDFKLJAIHLH[i] > 0 && this.JDFKLJAIHLH[i] < 100)
			{
				num++;
			}
		}
		return num;
	}

	// Token: 0x060021E4 RID: 8676 RVA: 0x000EE2E4 File Offset: 0x000EC4E4
	private void OBCFGOCKEEP()
	{
		if (!this.PDFIHFFJMJN)
		{
			return;
		}
		CommonUserInterface.EHBBFMCILPC.ShowGenericPopup(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("errortitle"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("adserrorbody"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("ok"), DFGILFBGPLN.popupIncentAd0Failed, 0f, 28);
	}

	// Token: 0x060021E5 RID: 8677 RVA: 0x000EE33B File Offset: 0x000EC53B
	private void ICBMJPGFGGN()
	{
		DPGJIJGOCIC.BOODEMPCMBA();
		Application.Quit();
	}

	// Token: 0x060021E6 RID: 8678 RVA: 0x000EE347 File Offset: 0x000EC547
	private bool CMGDKBFDGLF(JBBNEEHANHL GLOCCAIDHJC)
	{
		if (SceneLobbyManager2.IsGroupedFilter(GLOCCAIDHJC))
		{
			return this.HKNBOLLEAGE(GLOCCAIDHJC);
		}
		return this.JCPEDJJGFOO(GLOCCAIDHJC);
	}

	// Token: 0x060021E7 RID: 8679 RVA: 0x000EE360 File Offset: 0x000EC560
	private void KNJCJCLNBFA()
	{
		DPGJIJGOCIC.ADFCDFHBDAF("app42error");
	}

	// Token: 0x060021E8 RID: 8680 RVA: 0x000EE36C File Offset: 0x000EC56C
	private void CGDGJIKCLBL()
	{
		CommonUserInterface.EHBBFMCILPC.HideConnectingAnimation();
		this.CPLLGNAKIIL(this.LGKGGPDKAHF);
		if (null != this.LGKGGPDKAHF)
		{
			this.ONGICLLGJGO(this.LGKGGPDKAHF.index);
		}
		base.StartCoroutine(this.NAJEFKOKLKJ());
	}

	// Token: 0x060021E9 RID: 8681 RVA: 0x000EE3BB File Offset: 0x000EC5BB
	private IEnumerator BPFOFJJDHHD()
	{
		SceneLobbyManager2.lobbyIsActive = false;
		this.PEOGENJHMLL();
		GKJPOGNFKNK.FHFKDGHIEPI();
		GKJPOGNFKNK.LHFAFEPHINM();
		AssetsManager.EHBBFMCILPC.DestroyAssetBundleAssets(NMKDCBPMCKI.AssetBundleAnthologyAvatar, -1);
		AssetsManager.EHBBFMCILPC.DestroyAssetBundleAssets(NMKDCBPMCKI.AssetBundleAnthologyLounge, -1);
		AssetsManager.EHBBFMCILPC.DestroyAssetBundleAssets(NMKDCBPMCKI.AssetBundleCutsceneView, -1);
		AssetsManager.EHBBFMCILPC.DestroyAssetBundleAssets(NMKDCBPMCKI.AssetBundleSketchView, -1);
		AssetsManager.EHBBFMCILPC.DestroyAssetBundleAssets(NMKDCBPMCKI.AssetBundleCollectableCard, -1);
		AssetsManager.EHBBFMCILPC.DestroyAssetBundleAssets(NMKDCBPMCKI.AssetBundleLiveOfferContent, -1);
		AssetsManager.EHBBFMCILPC.DestroyAssetBundleAssets(NMKDCBPMCKI.AssetBundleSketchThumbnail, -1);
		AssetsManager.EHBBFMCILPC.DestroyAssetBundleAssets(NMKDCBPMCKI.AssetBundleSketchActors, -1);
		AssetsManager.EHBBFMCILPC.DestroyAssetBundleAssets(NMKDCBPMCKI.AssetBundleLobbyData2, -1);
		if (null != this.HFFIIBBJBMH && !this.HFFIIBBJBMH.header.enableSplashScreenAudio)
		{
			AssetsManager.EHBBFMCILPC.DestroyAssetBundleAssets(NMKDCBPMCKI.AssetBundleKeepAlivePack, -1);
		}
		if (!KHPGPLAMAIN.CNFPCHNGKPB())
		{
			AssetsManager.EHBBFMCILPC.DestroyAssetBundleAssets(NMKDCBPMCKI.AssetBundleProfileData2, -1);
			AssetsManager.EHBBFMCILPC.DestroyAssetBundleAssets(NMKDCBPMCKI.AssetBundleProfileData3, -1);
			AssetsManager.EHBBFMCILPC.DestroyAssetBundleAssets(NMKDCBPMCKI.AssetBundleProfileData4, -1);
			AssetsManager.EHBBFMCILPC.DestroyAssetBundleAssets(NMKDCBPMCKI.AssetBundleProfileData5, -1);
			AssetsManager.EHBBFMCILPC.DestroyAssetBundleAssets(NMKDCBPMCKI.AssetBundleProfileDataLocalized, -1);
			AssetsManager.EHBBFMCILPC.DestroyAssetBundleAssets(NMKDCBPMCKI.AssetBundleAnthologyPreview2, -1);
			AssetsManager.EHBBFMCILPC.DestroyAssetBundleAssets(NMKDCBPMCKI.AssetBundleLiveEventContent, -1);
		}
		yield return new WaitForSeconds(0.05f);
		BackendOperationsManager.EHBBFMCILPC.CleanCachedRequestsData();
		SceneManager.LoadScene("SceneTransitionFromLobby");
		yield break;
	}

	// Token: 0x060021EA RID: 8682 RVA: 0x000EE3CA File Offset: 0x000EC5CA
	private void OLLKOHMOEGI()
	{
		base.StartCoroutine(this.MJCAENEALOP());
	}

	// Token: 0x060021EB RID: 8683 RVA: 0x000EE3DC File Offset: 0x000EC5DC
	private bool OIOACPLBJLJ()
	{
		bool result;
		try
		{
			if (this.KCJIIEIBAPI >= 0)
			{
				result = (1 == this.KCJIIEIBAPI);
			}
			else if (AKLFPGMDKLA.EHBBFMCILPC == null)
			{
				result = false;
			}
			else
			{
				bool flag = AKLFPGMDKLA.EHBBFMCILPC.HCEHBFCIIHN() < KBOJLHAJPCP.FMIKGCDCKCC;
				if (flag)
				{
					this.KCJIIEIBAPI = 1;
				}
				else
				{
					this.KCJIIEIBAPI = 0;
				}
				result = flag;
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
			result = false;
		}
		return result;
	}

	// Token: 0x060021EC RID: 8684 RVA: 0x000EE44C File Offset: 0x000EC64C
	private void OPCIECLHNGP(JBBNEEHANHL AJLPALFJHCC)
	{
		this.FIPGMHIMFMK(AJLPALFJHCC);
	}

	// Token: 0x060021ED RID: 8685 RVA: 0x00003E52 File Offset: 0x00002052
	private void KKGMNKEMAHP()
	{
	}

	// Token: 0x060021EE RID: 8686 RVA: 0x000EE458 File Offset: 0x000EC658
	private void DDGPJJHEHLG()
	{
		this.LIDPKKFBNMC++;
		if (this.LIDPKKFBNMC >= KBOJLHAJPCP.LPJOFEDNKHA)
		{
			CommonUserInterface.EHBBFMCILPC.HideConnectingAnimation();
			FirebaseAnalyticsManager.EHBBFMCILPC.LogEvent(false, AGEHCPDNBFD.cdnActiv.ToString(), FFPHBMFGCNN.dldFail.ToString(), BGHLMGPPCNN.cdnLbyToSkt.ToString(), false, false);
			this.LIDPKKFBNMC = 0;
			CommonUserInterface.EHBBFMCILPC.ShowGenericPopupOneOverride(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("errortitle"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("cdnerror"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("retry"), new UnityAction(this.OnSketchesButtonClick), DFGILFBGPLN.popupCdnDownloadFailed, 0f, 28);
			this.GBBHKFFENBE = false;
			return;
		}
		this.OnSketchesButtonClick();
	}

	// Token: 0x060021EF RID: 8687 RVA: 0x000EE52C File Offset: 0x000EC72C
	private void LGKCHPBIIGA(bool JEGEKHCMLCD)
	{
		try
		{
			JBBNEEHANHL jbbneehanhl = JBBNEEHANHL.filterFavorites;
			if (SceneLobbyManager2.IsGroupedFilter(jbbneehanhl))
			{
				GameObject gameObject = null;
				for (int i = 0; i < this.MGNNOFPKGJF.Count; i++)
				{
					if (null != this.MGNNOFPKGJF[i] && jbbneehanhl == this.MGNNOFPKGJF[i].GetComponent<GridController>().filter)
					{
						gameObject = this.MGNNOFPKGJF[i];
						break;
					}
				}
				if (null == gameObject)
				{
					if (JEGEKHCMLCD && (!KDCJJBLGCBH.EHBBFMCILPC.FPLLPBJFCIK() || this.LPBFGPLHDPM) && 1 == AKLFPGMDKLA.EHBBFMCILPC.JCBEPJJHAII(AssetsManager.EHBBFMCILPC.anthologyAssets).Count)
					{
						FilterItem[] componentsInChildren = this.scrollView2Controller.GetComponentsInChildren<FilterItem>(true);
						for (int j = 0; j < componentsInChildren.Length; j++)
						{
							if (jbbneehanhl == componentsInChildren[j].id)
							{
								componentsInChildren[j].toggle.isOn = true;
								break;
							}
						}
					}
				}
				else
				{
					bool activeSelf = gameObject.activeSelf;
					this.LPBFGPLHDPM = true;
					this.KLBBGAFDNMP(jbbneehanhl);
					this.OBMFDJJNOJJ(jbbneehanhl);
					if (activeSelf && this.HKNBOLLEAGE(jbbneehanhl))
					{
						GameObject gameObject2 = this.HPOCOHEODDF(jbbneehanhl);
						if (null != gameObject2)
						{
							gameObject2.SetActive(true);
						}
					}
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x060021F0 RID: 8688 RVA: 0x000EE680 File Offset: 0x000EC880
	private void OBMFDJJNOJJ(JBBNEEHANHL HBBJBNJBMPK)
	{
		for (int i = this.AAHJNGODNKI.Count - 1; i >= 0; i--)
		{
			if (this.AAHJNGODNKI[i] == null || this.AAHJNGODNKI[i].GLOCCAIDHJC == HBBJBNJBMPK)
			{
				this.AAHJNGODNKI.RemoveAt(i);
			}
		}
	}

	// Token: 0x060021F1 RID: 8689 RVA: 0x000EE6D4 File Offset: 0x000EC8D4
	private void MNGIPAFFFEA()
	{
		SceneLobbyManager2.lobbyIsActive = false;
		this.PEOGENJHMLL();
		AssetsManager.EHBBFMCILPC.SetMaxNumberOfParallelDownloads(KDCJJBLGCBH.EHBBFMCILPC.GAOBDHNPING());
		this.PDFIHFFJMJN = false;
		SceneLobbyManager2.lobbyIsLoading = true;
		this.EFJGLLPDJKO();
		this.DDBMAENEIAA();
		this.PGFANABDIBK = false;
		if (AKLFPGMDKLA.EHBBFMCILPC.EGOCMDJBLNJ > 2)
		{
			AKLFPGMDKLA.EHBBFMCILPC.IEGJCPDCLMM = -1;
		}
		if (AKLFPGMDKLA.EHBBFMCILPC.EEHGLPEIIHD == null || AKLFPGMDKLA.EHBBFMCILPC.EEHGLPEIIHD.Length == 0)
		{
			this.KLLKPDGCMLH();
			return;
		}
		if (AKLFPGMDKLA.EHBBFMCILPC.IEGJCPDCLMM >= 0 && AKLFPGMDKLA.EHBBFMCILPC.EJLCEBPHPJE >= 0 && AKLFPGMDKLA.EHBBFMCILPC.GJBDBONJCDL(AKLFPGMDKLA.EHBBFMCILPC.EJLCEBPHPJE) != null)
		{
			this.PLJLNEAKFDK = EJDDNONEDNM.loadIntoStory;
		}
		else
		{
			this.PLJLNEAKFDK = EJDDNONEDNM.stayInLobby;
		}
		CommonUserInterface.EHBBFMCILPC.ShowConnectingAnimationWithHint(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("hintloading"), 0);
		if (this.PLJLNEAKFDK == EJDDNONEDNM.loadIntoStory)
		{
			this.PGFANABDIBK = true;
			AKLFPGMDKLA.EHBBFMCILPC.EBNJHPICFGE(AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(AKLFPGMDKLA.EHBBFMCILPC.LMGMHHLLOFN(AKLFPGMDKLA.EHBBFMCILPC.EJLCEBPHPJE).ILOKBAPEJPK), 0);
			BackendOperationsManager.EHBBFMCILPC.CleanCachedRequestsData();
			BackendOperationsManager.EHBBFMCILPC.RequestLoadDefaultBundlesAndStartPlayChapter(AKLFPGMDKLA.ACFJMCBMOFG(AKLFPGMDKLA.EHBBFMCILPC.IEGJCPDCLMM, AKLFPGMDKLA.EHBBFMCILPC.LMGMHHLLOFN(AKLFPGMDKLA.EHBBFMCILPC.EJLCEBPHPJE).ILOKBAPEJPK), AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(AKLFPGMDKLA.EHBBFMCILPC.LMGMHHLLOFN(AKLFPGMDKLA.EHBBFMCILPC.EJLCEBPHPJE).ILOKBAPEJPK).DHONIOBOLEL.DDEDAHCFHJN(), AKLFPGMDKLA.EHBBFMCILPC.EJLCEBPHPJE, "OnBackendGetDefaultBundlesSuccess", "OnBackendGetDefaultBundlesException");
			return;
		}
		BackendOperationsManager.EHBBFMCILPC.RequestLoadDefaultBundles("OnBackendGetDefaultBundlesSuccess", "OnBackendGetDefaultBundlesException", false);
	}

	// Token: 0x060021F2 RID: 8690 RVA: 0x000EE88C File Offset: 0x000ECA8C
	private void CAOBCDPGEIM(ThumbnailItem LFOLNLDPKHO, int PLKMJJIIJNO, JBBNEEHANHL HBBJBNJBMPK)
	{
		try
		{
			if (!(null == LFOLNLDPKHO))
			{
				if (JBBNEEHANHL.filterSearch == HBBJBNJBMPK)
				{
					this.KCAFGDAIDLG(LFOLNLDPKHO, PLKMJJIIJNO);
				}
				else
				{
					SceneLobbyManager2.LDGNIDMIIIA ldgnidmiiia = this.BAKAHKFKAHL(PLKMJJIIJNO);
					if (ldgnidmiiia == null || ldgnidmiiia.FKCNMAEBNNK == null)
					{
						LFOLNLDPKHO.SetCardChips(null, null);
					}
					else
					{
						List<string> edhheeipncp = ldgnidmiiia.AIJFJMKHAOO;
						if (ldgnidmiiia.DPENIDKNIMK)
						{
							this.LDDOHLGKALJ.Clear();
							if (ldgnidmiiia.JCMIJCCCCLC != null)
							{
								this.LDDOHLGKALJ.Add(ldgnidmiiia.JCMIJCCCCLC);
							}
							edhheeipncp = this.LDDOHLGKALJ;
						}
						string jcmijcccclc = LFOLNLDPKHO.SetCardChips(ldgnidmiiia.FKCNMAEBNNK, edhheeipncp);
						if (!ldgnidmiiia.DPENIDKNIMK)
						{
							ldgnidmiiia.JCMIJCCCCLC = jcmijcccclc;
							ldgnidmiiia.DPENIDKNIMK = true;
						}
					}
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x060021F3 RID: 8691 RVA: 0x000EE950 File Offset: 0x000ECB50
	private void JPNCOLAKDHG()
	{
		base.StartCoroutine(this.BPFOFJJDHHD());
	}

	// Token: 0x060021F4 RID: 8692 RVA: 0x000EE95F File Offset: 0x000ECB5F
	private void IMINAEKJFCK()
	{
		this.KHCPHAIGBJE();
	}

	// Token: 0x060021F5 RID: 8693 RVA: 0x000EE968 File Offset: 0x000ECB68
	private void HKHKEMFOMBK()
	{
		this.DFNOAOLCGGB++;
		if (this.DFNOAOLCGGB < KBOJLHAJPCP.LPJOFEDNKHA)
		{
			this.IBBHBBNAOKL.Clear();
			base.StartCoroutine(this.OLMEEDAFNAE());
			return;
		}
		CommonUserInterface.EHBBFMCILPC.HideConnectingAnimation();
		FirebaseAnalyticsManager.EHBBFMCILPC.LogEvent(false, AGEHCPDNBFD.cdnActiv.ToString(), FFPHBMFGCNN.dldFail.ToString(), BGHLMGPPCNN.cdnLbyToLng.ToString(), false, false);
		this.DFNOAOLCGGB = 0;
		this.GBBHKFFENBE = false;
		this.MHAMPPBECNM = false;
		if (!this.OBKCLKMPKCI)
		{
			SceneLoungeManager.SetPendingLoungeCharacter(null);
			SceneLoungeManager.SetPendingLoungeLook(null);
		}
		this.LFMFIIPJECJ();
		if (this.OBKCLKMPKCI)
		{
			CommonUserInterface.EHBBFMCILPC.ShowGenericPopupWithTwoButtons(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("errortitle"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("cdnerror"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("retry"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("cancel"), new UnityAction(this.FDBMOJMACBN), new UnityAction(this.FLCPIFDIBDM), DFGILFBGPLN.popupCdnDownloadFailed, 0f, 28);
			return;
		}
		CommonUserInterface.EHBBFMCILPC.ShowGenericPopupOneOverride(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("errortitle"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("cdnerror"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("retry"), new UnityAction(this.BAKCPDNFFMH), DFGILFBGPLN.popupCdnDownloadFailed, 0f, 28);
	}

	// Token: 0x060021F6 RID: 8694 RVA: 0x000EEAE0 File Offset: 0x000ECCE0
	private void OINFFDNGJHF()
	{
		CommonUserInterface.EHBBFMCILPC.HideConnectingAnimation();
		CommonUserInterface.EHBBFMCILPC.GetFader().FadeIn(new TweenCallback(this.OnAvatarClickPart2));
		for (int i = 0; i < this.lobbyParticles.Count; i++)
		{
			if (null != this.lobbyParticles[i])
			{
				this.lobbyParticles[i].Stop();
			}
		}
		this.CMDIKMNEGEN();
		this.GBBHKFFENBE = false;
	}

	// Token: 0x060021F7 RID: 8695 RVA: 0x00003E52 File Offset: 0x00002052
	public void OnSearchQueryStarted()
	{
	}

	// Token: 0x060021F8 RID: 8696 RVA: 0x000EEB5C File Offset: 0x000ECD5C
	public void UpdateAnthologiesHints()
	{
		this.PMFMEBGNCME = new NDHKFLHAFNA[76];
		this.HKJCANHMEED = new NDHKFLHAFNA[76];
		this.CBBNGDBFDPO = new NDHKFLHAFNA[76];
		this.CIFKLOHBHJB = new NDHKFLHAFNA[76];
		for (int i = 0; i < this.KHOELODHGGF.Length; i++)
		{
			this.PMFMEBGNCME[i] = NDHKFLHAFNA.hintNone;
			this.HKJCANHMEED[i] = NDHKFLHAFNA.hintNone;
			this.CBBNGDBFDPO[i] = NDHKFLHAFNA.hintNone;
			this.CIFKLOHBHJB[i] = NDHKFLHAFNA.hintNone;
		}
		try
		{
			this.COJEBPAFPFP = (null == AssetsManager.EHBBFMCILPC.lobbyDataAsset);
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
		bool flag = this.MMJJBECDAOC();
		try
		{
			for (int j = 0; j < AssetsManager.EHBBFMCILPC.anthologyAssets.Count; j++)
			{
				IJLJDFKJIJM ijljdfkjijm = HKLPEDKJGFC.BBEPEBHNNGE(AssetsManager.EHBBFMCILPC.anthologyAssets[j].header.index);
				PLFDAJJHMKO activeAnthologyStorySafe = this.GetActiveAnthologyStorySafe(AssetsManager.EHBBFMCILPC.anthologyAssets[j].header.index);
				int num = activeAnthologyStorySafe.DHONIOBOLEL.DDEDAHCFHJN();
				AssetStoryHeader assetStoryHeader = GKJPOGNFKNK.CDCEFHLNNEC(activeAnthologyStorySafe.DHONIOBOLEL.GGICIBLJIKI);
				bool flag2 = this.CILHBPNJDFA(assetStoryHeader, num, activeAnthologyStorySafe.DHONIOBOLEL.CFGFOEEEJKJ, LanguageManager.EHBBFMCILPC.GetSelectedLanguage());
				try
				{
					if (!flag2 && LanguageManager.EHBBFMCILPC.GetSelectedLanguage() != CEIBHCNNIDC.en && LanguageManager.EHBBFMCILPC.GetSelectedLanguage() != CEIBHCNNIDC.ru && num < assetStoryHeader.chapterAssetPacks.Count)
					{
						int num2 = assetStoryHeader.EJPLMFAOJIB(num);
						if (this.CILHBPNJDFA(assetStoryHeader, num, num2, LanguageManager.EHBBFMCILPC.GetSelectedLanguage()))
						{
							this.RestartChapterSilent(assetStoryHeader, activeAnthologyStorySafe);
							flag2 = true;
							activeAnthologyStorySafe.DHONIOBOLEL.CFGFOEEEJKJ = num2;
						}
					}
				}
				catch (Exception aklgbjkdomm2)
				{
					DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm2);
				}
				if (assetStoryHeader.MLGKEPJPICJ(num))
				{
					this.PMFMEBGNCME[AssetsManager.EHBBFMCILPC.anthologyAssets[j].header.index] = NDHKFLHAFNA.hintCompleted;
					this.HKJCANHMEED[AssetsManager.EHBBFMCILPC.anthologyAssets[j].header.index] = NDHKFLHAFNA.hintCompleted;
					this.CBBNGDBFDPO[AssetsManager.EHBBFMCILPC.anthologyAssets[j].header.index] = NDHKFLHAFNA.hintCompleted;
					this.CIFKLOHBHJB[AssetsManager.EHBBFMCILPC.anthologyAssets[j].header.index] = NDHKFLHAFNA.hintCompleted;
				}
				else if (assetStoryHeader.OAJGLLHCBAB(num) || !flag2)
				{
					NDHKFLHAFNA ndhkflhafna = NDHKFLHAFNA.hintInDevelopment;
					if (flag)
					{
						ndhkflhafna = NDHKFLHAFNA.hintDiscontinued;
					}
					else if (ijljdfkjijm != null && ijljdfkjijm.FKEBMPGOKLK())
					{
						ndhkflhafna = NDHKFLHAFNA.hintOnHiatus;
					}
					this.PMFMEBGNCME[AssetsManager.EHBBFMCILPC.anthologyAssets[j].header.index] = ndhkflhafna;
					this.HKJCANHMEED[AssetsManager.EHBBFMCILPC.anthologyAssets[j].header.index] = ndhkflhafna;
					this.CBBNGDBFDPO[AssetsManager.EHBBFMCILPC.anthologyAssets[j].header.index] = ndhkflhafna;
					this.CIFKLOHBHJB[AssetsManager.EHBBFMCILPC.anthologyAssets[j].header.index] = ndhkflhafna;
				}
				else
				{
					if (ijljdfkjijm != null && (ijljdfkjijm.MGDAFCPCOFH == JBBNEEHANHL.filterNew || ijljdfkjijm.HLEHGFIIEJN == JBBNEEHANHL.filterNew || ijljdfkjijm.BFJKEJLJAIH == JBBNEEHANHL.filterNew || ijljdfkjijm.MBIDFCCNCKL == JBBNEEHANHL.filterNew || ijljdfkjijm.KGFKAIBMGOP == JBBNEEHANHL.filterNew))
					{
						this.CBBNGDBFDPO[AssetsManager.EHBBFMCILPC.anthologyAssets[j].header.index] = ijljdfkjijm.GNPIBDFMMCO;
						if (this.CBBNGDBFDPO[AssetsManager.EHBBFMCILPC.anthologyAssets[j].header.index] == NDHKFLHAFNA.hintNewStory && this.HNLPNMJIBIK[AssetsManager.EHBBFMCILPC.anthologyAssets[j].header.index] <= 0)
						{
							this.CIFKLOHBHJB[AssetsManager.EHBBFMCILPC.anthologyAssets[j].header.index] = NDHKFLHAFNA.hintNewStory;
						}
					}
					if (this.HNLPNMJIBIK[AssetsManager.EHBBFMCILPC.anthologyAssets[j].header.index] > 0)
					{
						this.PMFMEBGNCME[AssetsManager.EHBBFMCILPC.anthologyAssets[j].header.index] = NDHKFLHAFNA.hintContinuePlaying;
						this.HKJCANHMEED[AssetsManager.EHBBFMCILPC.anthologyAssets[j].header.index] = NDHKFLHAFNA.hintContinuePlaying;
						this.CIFKLOHBHJB[AssetsManager.EHBBFMCILPC.anthologyAssets[j].header.index] = NDHKFLHAFNA.hintContinuePlaying;
					}
				}
			}
		}
		catch (Exception aklgbjkdomm3)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm3);
		}
	}

	// Token: 0x060021F9 RID: 8697 RVA: 0x000EF014 File Offset: 0x000ED214
	private void DLNHHHHFGGA()
	{
		SceneLobbyManager2.incentAdResultRewardType = 1;
		AKLFPGMDKLA.EHBBFMCILPC.LPCBDEBKAIM();
		if (AdsManagerLP.EHBBFMCILPC.IsReadyRewarded())
		{
			AdsManagerLP.EHBBFMCILPC.ShowAdRewarded(SceneLobbyManager2.EIODJHDOHPE, SceneLobbyManager2.MHOJMLGCLOD, SceneLobbyManager2.MHOJMLGCLOD);
			return;
		}
		AOBJLALDBAA.EHBBFMCILPC.EGELHPJBAIC(SceneLobbyManager2.MHOJMLGCLOD, 0.1f);
	}

	// Token: 0x060021FA RID: 8698 RVA: 0x000EF06B File Offset: 0x000ED26B
	private void MLDOEOKAPEH()
	{
		UnityEngine.Object.Instantiate<GameObject>(this.pageIndicatorPrefab, this.pageIndicatorsParent);
		this.scrollView1Controller.UpdateIndicatorsButtonsSize();
	}

	// Token: 0x060021FB RID: 8699 RVA: 0x000EF08A File Offset: 0x000ED28A
	private IEnumerator NAJEFKOKLKJ()
	{
		yield return new WaitForSeconds(1f);
		CommonUserInterface.EHBBFMCILPC.ShowGenericPopup(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("importanttitle"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("saveslotsduplicatepos").Replace("XXX", SaveSlotsItem.duplicatedSlotTitle), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("ok"), DFGILFBGPLN.popupEnergyHint, 0f, 28);
		CommonUserInterface.EHBBFMCILPC.ResumeUX();
		AssetsManager.EHBBFMCILPC.DestroyAssetBundleAssets(NMKDCBPMCKI.AssetBundleCollectableCard, -1);
		yield break;
	}

	// Token: 0x060021FC RID: 8700 RVA: 0x000EF094 File Offset: 0x000ED294
	private void CJHCAPFJDJM()
	{
		try
		{
			if (this.KDLBELFIIDL && this.EOOJGEFLJEN.Count != 0)
			{
				List<int> list = new List<int>();
				while (this.EOOJGEFLJEN.Count > 0 && list.Count < 8)
				{
					list.Add(this.EOOJGEFLJEN[0]);
					this.EOOJGEFLJEN.RemoveAt(0);
				}
				BackendOperationsManager.EHBBFMCILPC.RequestGetPremiumChoicesHistory(list, "OnLoungePremiumChoicesHistorySuccess", "OnLoungePremiumChoicesHistoryException");
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
			this.EEGDFPJGECN();
		}
	}

	// Token: 0x060021FD RID: 8701 RVA: 0x000EF12C File Offset: 0x000ED32C
	public void OnRestartClick()
	{
		if (this.NeedToCompletePrequelAnthology())
		{
			return;
		}
		KIOOJMGLCLC kioojmglclc = ODLJHDIGLGO.MNALIKIMKFC(CLHDENLPOFP.gamePass);
		this.focusItem.GetComponent<FocusItem>().ShowChapterSnapshots(kioojmglclc == null);
	}

	// Token: 0x060021FE RID: 8702 RVA: 0x000EF160 File Offset: 0x000ED360
	private void GPNFLDDKLAJ()
	{
		if (1 == AKLFPGMDKLA.EHBBFMCILPC.PACMCEHMBGG)
		{
			AudioManager.EHBBFMCILPC.PlayMusic("lobby", true, -1f, false);
		}
		for (int i = 0; i < this.lobbyParticles.Count; i++)
		{
			if (null != this.lobbyParticles[i])
			{
				this.lobbyParticles[i].gameObject.SetActive(true);
				this.lobbyParticles[i].Play();
			}
		}
		this.ODOPEGPBCCD();
		this.OPEGJAEFAJL();
		base.StartCoroutine(this.KLPHDBHBAMK());
	}

	// Token: 0x060021FF RID: 8703 RVA: 0x000EF1FC File Offset: 0x000ED3FC
	private bool EONFEFBLLMK()
	{
		bool result;
		try
		{
			if (null == this.pageIndicatorsParent || this.pageIndicatorsParent.childCount == 0)
			{
				result = false;
			}
			else if ((double)NBDLBFJOEGN.LAIDCKNIOIN() >= 2.16)
			{
				result = true;
			}
			else
			{
				int num = this.pageIndicatorsParent.childCount - 1;
				int num2 = num / 2;
				foreach (object obj in this.pageIndicatorsParent)
				{
					Transform transform = (Transform)obj;
					if (transform.GetChild(0).gameObject.activeSelf)
					{
						int siblingIndex = transform.GetSiblingIndex();
						if (siblingIndex == num2)
						{
							return true;
						}
						if (siblingIndex > 0 && siblingIndex < num)
						{
							return true;
						}
						return false;
					}
				}
				result = true;
			}
		}
		catch (Exception)
		{
			result = true;
		}
		return result;
	}

	// Token: 0x06002200 RID: 8704 RVA: 0x000EF2EC File Offset: 0x000ED4EC
	private bool OIKCNJIJNAC(PLFDAJJHMKO LFLOCKNKAKC)
	{
		try
		{
			if (LFLOCKNKAKC != null && LFLOCKNKAKC.DHONIOBOLEL != null && LFLOCKNKAKC.DHONIOBOLEL.LKIKEHFANBO != null && LFLOCKNKAKC.DHONIOBOLEL.LKIKEHFANBO.Length != 0 && LFLOCKNKAKC.DHONIOBOLEL.LKIKEHFANBO[0] >= 0)
			{
				return true;
			}
			if (null != this.HFFIIBBJBMH && null != this.HFFIIBBJBMH.header)
			{
				EIOPLEFLLIM eioplefllim = AKLFPGMDKLA.EHBBFMCILPC.GJBDBONJCDL(this.HFFIIBBJBMH.header.index);
				if (eioplefllim != null && eioplefllim.EGHHCFFLPCP(-1) > 0)
				{
					return true;
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
		return false;
	}

	// Token: 0x06002201 RID: 8705 RVA: 0x000EF39C File Offset: 0x000ED59C
	public void OnPlaySoonClick()
	{
		try
		{
			if (null != AssetsManager.EHBBFMCILPC.lobbyDataAsset && AssetsManager.EHBBFMCILPC.lobbyDataAsset.FBMBHBAJMPJ(LanguageManager.EHBBFMCILPC.GetSelectedLanguage()))
			{
				CommonUserInterface.EHBBFMCILPC.ShowGenericPopup(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("discontinuedtitle"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("discontinueddesc"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("ok"), DFGILFBGPLN.popupComingSoon, 0f, 28);
				return;
			}
			if (null != this.HFFIIBBJBMH)
			{
				IJLJDFKJIJM ijljdfkjijm = HKLPEDKJGFC.BBEPEBHNNGE(this.HFFIIBBJBMH.header.index);
				if (ijljdfkjijm != null && ijljdfkjijm.FKEBMPGOKLK())
				{
					CommonUserInterface.EHBBFMCILPC.ShowGenericPopup(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("onhiatustitle"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("onhiatusdesc"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("ok"), DFGILFBGPLN.popupComingSoon, 0f, 28);
					return;
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
		string text = CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("comingsoondesc");
		if (null != AssetsManager.EHBBFMCILPC.lobbyDataAsset)
		{
			if (LanguageManager.EHBBFMCILPC.GetSelectedLanguage() == CEIBHCNNIDC.ru)
			{
				text = text + " <i>" + AssetsManager.EHBBFMCILPC.lobbyDataAsset.nextUpdateIntervalRu + "</i>.";
			}
			else if (LanguageManager.EHBBFMCILPC.GetSelectedLanguage() == CEIBHCNNIDC.tr)
			{
				text = text + " <i>" + AssetsManager.EHBBFMCILPC.lobbyDataAsset.nextUpdateIntervalTr + "</i>.";
			}
			else if (LanguageManager.EHBBFMCILPC.GetSelectedLanguage() == CEIBHCNNIDC.pl)
			{
				text = text + " <i>" + AssetsManager.EHBBFMCILPC.lobbyDataAsset.nextUpdateIntervalPl + "</i>.";
			}
			else if (LanguageManager.EHBBFMCILPC.GetSelectedLanguage() == CEIBHCNNIDC.es)
			{
				text = text + " <i>" + AssetsManager.EHBBFMCILPC.lobbyDataAsset.nextUpdateIntervalEs + "</i>.";
			}
			else if (LanguageManager.EHBBFMCILPC.GetSelectedLanguage() == CEIBHCNNIDC.de)
			{
				text = text + " <i>" + AssetsManager.EHBBFMCILPC.lobbyDataAsset.nextUpdateIntervalDe + "</i>.";
			}
			else if (LanguageManager.EHBBFMCILPC.GetSelectedLanguage() == CEIBHCNNIDC.ro)
			{
				text = text + " <i>" + AssetsManager.EHBBFMCILPC.lobbyDataAsset.nextUpdateIntervalRo + "</i>.";
			}
			else if (LanguageManager.EHBBFMCILPC.GetSelectedLanguage() == CEIBHCNNIDC.cz)
			{
				text = text + " <i>" + AssetsManager.EHBBFMCILPC.lobbyDataAsset.nextUpdateIntervalCz + "</i>.";
			}
			else if (LanguageManager.EHBBFMCILPC.GetSelectedLanguage() == CEIBHCNNIDC.fr)
			{
				text = text + " <i>" + AssetsManager.EHBBFMCILPC.lobbyDataAsset.nextUpdateIntervalFr + "</i>.";
			}
			else
			{
				text = text + " <i>" + AssetsManager.EHBBFMCILPC.lobbyDataAsset.nextUpdateIntervalEn + "</i>.";
			}
		}
		CommonUserInterface.EHBBFMCILPC.ShowGenericPopup(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("comingsoontitle"), text, CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("ok"), DFGILFBGPLN.popupComingSoon, 0f, 28);
	}

	// Token: 0x06002202 RID: 8706 RVA: 0x000EF6AC File Offset: 0x000ED8AC
	private string GDAPJCHEDOK(string IGPPDLNCBME)
	{
		try
		{
			if (char.IsUpper(IGPPDLNCBME[0]))
			{
				return IGPPDLNCBME;
			}
			CultureInfo culture = (this.NBNKDKCCNKI == null) ? CultureInfo.InvariantCulture : this.NBNKDKCCNKI;
			return char.ToUpper(IGPPDLNCBME[0], culture).ToString() + IGPPDLNCBME.Substring(1);
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
		return IGPPDLNCBME;
	}

	// Token: 0x06002203 RID: 8707 RVA: 0x000EF720 File Offset: 0x000ED920
	private bool NFDFGBMMLBF(MJJBPLAMLAN MIDLEBAGDMN, MJJBPLAMLAN DFNFPEMFNPN)
	{
		if (MIDLEBAGDMN.EAGKOGODBMG != DFNFPEMFNPN.EAGKOGODBMG)
		{
			return MIDLEBAGDMN.EAGKOGODBMG > DFNFPEMFNPN.EAGKOGODBMG;
		}
		return MIDLEBAGDMN.NJBCLIILMOF > DFNFPEMFNPN.NJBCLIILMOF;
	}

	// Token: 0x06002204 RID: 8708 RVA: 0x000EF750 File Offset: 0x000ED950
	private void PHNIFGGEADM()
	{
		try
		{
			for (int i = 1; i < this.AAHJNGODNKI.Count; i++)
			{
				HAKFHALKMBH hakfhalkmbh = this.AAHJNGODNKI[i];
				if (hakfhalkmbh != null && !(null == hakfhalkmbh.NHOAHJMPCFC) && hakfhalkmbh.CCKABAENJPK != 0 && hakfhalkmbh.CKBJGCFCHGA < hakfhalkmbh.LGIAOIGIGPI.Count && hakfhalkmbh.NHOAHJMPCFC.activeInHierarchy)
				{
					RectTransform rectTransform = this.scrollView0Content.parent as RectTransform;
					if (!(null == rectTransform))
					{
						Vector3[] array = new Vector3[3];
						hakfhalkmbh.NHOAHJMPCFC.GetComponent<RectTransform>().GetWorldCorners(array);
						float y = rectTransform.InverseTransformPoint(array[1]).y;
						if (rectTransform.rect.yMin - y <= rectTransform.rect.height * 627f)
						{
							this.KCPLIPJHCAO(hakfhalkmbh, hakfhalkmbh.CCKABAENJPK);
						}
					}
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
	}

	// Token: 0x06002205 RID: 8709 RVA: 0x000EF864 File Offset: 0x000EDA64
	public void RestartStory1()
	{
		this.RestartStoryX(1);
	}

	// Token: 0x06002206 RID: 8710 RVA: 0x000EF86D File Offset: 0x000EDA6D
	private void FMHCMHNFOPC()
	{
		base.StartCoroutine(this.PLMDDBLOKNM());
	}

	// Token: 0x06002207 RID: 8711 RVA: 0x000EF87C File Offset: 0x000EDA7C
	private void MIPEOPGCNIA()
	{
		List<int> list = AKLFPGMDKLA.EHBBFMCILPC.FKJEAIALJMC();
		if (list.Count > 0)
		{
			AssetAnthologyPreview2 assetAnthologyPreview = GKJPOGNFKNK.OGKPKBLFGMJ(list[DPGJIJGOCIC.IOOHGEJIPFP(0, list.Count)]);
			if (null != assetAnthologyPreview)
			{
				this.CPLLGNAKIIL(assetAnthologyPreview);
			}
			DPGJIJGOCIC.NFIDPOMCNLP("SceneLobbyManager2.OnRewardFirstEpisodeClick() getting one random out of " + list.Count.ToString());
		}
	}

	// Token: 0x06002208 RID: 8712 RVA: 0x000EF8E4 File Offset: 0x000EDAE4
	private void KOGCOFOIMOG(int[] PBGCMMKBLBG)
	{
		if (PBGCMMKBLBG == null)
		{
			return;
		}
		int[] array = new int[]
		{
			4,
			5,
			3,
			2
		};
		for (int i = 0; i < array.Length; i++)
		{
			foreach (int num in PBGCMMKBLBG)
			{
				if (num >= 0 && array[i] == MLIBDDCCKBM.KBNBLLJIPIJ(num) && !this.LCIKAHNGIJG.Contains(num) && !("genre_lgbtq" == MLIBDDCCKBM.LCNMONKLPIG(num)) && !MLIBDDCCKBM.BBIJHBHHGFB(num) && !MLIBDDCCKBM.JAGLHPDCEGF(num) && (4 != array[i] || !("author" == MLIBDDCCKBM.DIFPDJMGECC(num))) && (4 != array[i] || !("lgbtq" == MLIBDDCCKBM.DIFPDJMGECC(num))))
				{
					this.LCIKAHNGIJG.Add(num);
				}
			}
		}
	}

	// Token: 0x06002209 RID: 8713 RVA: 0x000EF9B0 File Offset: 0x000EDBB0
	public string GetIncentAdRewardText()
	{
		KIOOJMGLCLC kioojmglclc = ODLJHDIGLGO.MNALIKIMKFC(CLHDENLPOFP.gamePass, true);
		int num = 1;
		if (kioojmglclc != null)
		{
			num = KDCJJBLGCBH.EHBBFMCILPC.AAGICPKFIKC(KDCJJBLGCBH.EHBBFMCILPC.HHONCLBBHPG(kioojmglclc.LLLJOBODOAL), DAMCJCDKOJK.gpbpIncentAdMultiplier, 1 == AKLFPGMDKLA.EHBBFMCILPC.DCIPLNCLIMF);
		}
		return "+" + (KDCJJBLGCBH.EHBBFMCILPC.NEOIABIBJOI(0) * num).ToString();
	}

	// Token: 0x0600220A RID: 8714 RVA: 0x000EFA14 File Offset: 0x000EDC14
	private List<MJJBPLAMLAN> BDNMFNABLEG(List<MJJBPLAMLAN> OFPLLEEJIJF)
	{
		List<MJJBPLAMLAN> list = new List<MJJBPLAMLAN>();
		try
		{
			if (OFPLLEEJIJF == null || null == AssetsManager.MJBDMHPHMID() || null == AssetsManager.EHBBFMCILPC.lobbyDataAsset)
			{
				return list;
			}
			EAFPOMNMOFP eafpomnmofp = AssetsManager.MJBDMHPHMID().lobbyDataAsset.JDMCDEKHDHM();
			CEIBHCNNIDC niiimdhggen = LanguageManager.EHBBFMCILPC.NBANPEIHFOJ();
			for (int i = 1; i < OFPLLEEJIJF.Count; i += 0)
			{
				string text = eafpomnmofp.DKDFKDOKOEA(OFPLLEEJIJF[i].DBHMNECMIAB, niiimdhggen);
				if (text != null && text.Length != 0)
				{
					list.Add(OFPLLEEJIJF[i]);
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
		return list;
	}

	// Token: 0x0600220B RID: 8715 RVA: 0x000EFACC File Offset: 0x000EDCCC
	private void AECHPENEOCI()
	{
		AOBJLALDBAA.EHBBFMCILPC.MANLHALMCIH("OnLobbyLoungeOpenRequested", new UnityAction(this.BAKCPDNFFMH));
		AOBJLALDBAA.EHBBFMCILPC.MANLHALMCIH("OnLobbyLoungeAssetBundleFolderInitializeSuccess", new UnityAction(this.FMHCMHNFOPC));
		AOBJLALDBAA.EHBBFMCILPC.MANLHALMCIH("OnLobbyLoungeAssetsDownloadSuccess", new UnityAction(this.AGGHLICBNNF));
		AOBJLALDBAA.EHBBFMCILPC.MANLHALMCIH("OnLobbyLoungeAssetsDownloadFailed", new UnityAction(this.HKHKEMFOMBK));
		AOBJLALDBAA.EHBBFMCILPC.MANLHALMCIH("OnLoungePremiumChoicesHistorySuccess", new UnityAction(this.ICLFENDADFN));
		AOBJLALDBAA.EHBBFMCILPC.MANLHALMCIH("OnLoungePremiumChoicesHistoryException", new UnityAction(this.EEGDFPJGECN));
		AOBJLALDBAA.EHBBFMCILPC.MANLHALMCIH(SceneLoungeManager.onLoungeScreenLeft, new UnityAction(this.LODFBFMAOGL));
	}

	// Token: 0x0600220C RID: 8716 RVA: 0x000EFB98 File Offset: 0x000EDD98
	public void OnFreeDiamondsClick()
	{
		if (this.BJGAJOKENMG.HHGAPKJFBMC() || AKLFPGMDKLA.EHBBFMCILPC.KCFMAEFDGPK == 0)
		{
			CommonUserInterface.EHBBFMCILPC.ShowGenericPopupOneOverride(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("freediamonds"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("freediamondsbody"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("watchvideo"), new UnityAction(this.DLNHHHHFGGA), DFGILFBGPLN.popupWatchAdGetFreeDiamonds, 0f, 28);
			return;
		}
		this.OnAdTimerClick();
	}

	// Token: 0x0600220D RID: 8717 RVA: 0x000EFC14 File Offset: 0x000EDE14
	private static void NBBJMAPHBNP(List<SceneLobbyManager2.BBNDCCPKNJL> JAPOJOAHHBO, bool LCMLHFHNJHN, string GBBOOLJENNL, List<SceneLobbyManager2.BBNDCCPKNJL> PEDCLABFOLK)
	{
		PEDCLABFOLK.Clear();
		for (int i = 0; i < JAPOJOAHHBO.Count; i++)
		{
			SceneLobbyManager2.BBNDCCPKNJL bbndccpknjl = JAPOJOAHHBO[i];
			if ((LCMLHFHNJHN ? bbndccpknjl.DCMKIKIHACO : bbndccpknjl.FJNECDBGMOK) && (GBBOOLJENNL == null || !string.Equals(bbndccpknjl.IEIAICGOENJ, GBBOOLJENNL, StringComparison.OrdinalIgnoreCase)))
			{
				PEDCLABFOLK.Add(bbndccpknjl);
			}
		}
		PEDCLABFOLK.Sort(new Comparison<SceneLobbyManager2.BBNDCCPKNJL>(SceneLobbyManager2.GINEIIANOAE));
	}

	// Token: 0x0600220E RID: 8718 RVA: 0x000EFC80 File Offset: 0x000EDE80
	private List<KLJCEMBNKNI> FDDNNGNHMFP()
	{
		List<KLJCEMBNKNI> list = new List<KLJCEMBNKNI>();
		try
		{
			List<int> list2 = this.DGPAFDKHLJL(JBBNEEHANHL.filterFavorites);
			if (list2.Count > 0)
			{
				list.Add(this.AGFJMDBMKBN("coverFavorites", list2.Count, 0, 0, "", "favoritespattern", JBBNEEHANHL.filterFavorites, list2));
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
		return list;
	}

	// Token: 0x0600220F RID: 8719 RVA: 0x000EFCE8 File Offset: 0x000EDEE8
	public void OnQuitClickPart2()
	{
		AKLFPGMDKLA.EHBBFMCILPC.LPCBDEBKAIM();
		CommonUserInterface.EHBBFMCILPC.ShowConnectingAnimationWithHint(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("hintsaving"), 96);
		BackendOperationsManager.EHBBFMCILPC.QueueRequestSaveChapterSnapshots();
		BackendOperationsManager.EHBBFMCILPC.QueueRequestSaveAvatarCollections();
		BackendOperationsManager.EHBBFMCILPC.RequestSaveSync("OnSceneLobbyManagerExitSyncSuccess", "OnSceneLobbyManagerExitSyncSuccess");
	}

	// Token: 0x06002210 RID: 8720 RVA: 0x000EFD44 File Offset: 0x000EDF44
	private void IEJGBPPPIHD()
	{
		FirebaseAnalyticsManager.EHBBFMCILPC.LogEvent(false, AGEHCPDNBFD.cdnActiv.ToString(), FFPHBMFGCNN.dldCompl.ToString(), BGHLMGPPCNN.cdnLbyToSpl.ToString(), false, false);
		CommonUserInterface.EHBBFMCILPC.HideConnectingAnimation();
		if (null != AssetsManager.EHBBFMCILPC.GetStorySplashManager(0))
		{
			AudioManager.EHBBFMCILPC.KillMusic("", CommonUserInterface.EHBBFMCILPC.GetFader().GetFadeInDuration());
			CommonUserInterface.EHBBFMCILPC.GetFader().FadeIn(new TweenCallback(this.JPNCOLAKDHG));
		}
		else
		{
			DPGJIJGOCIC.ANOPFDLPKGC("There are no story splash managers!");
		}
		this.CMDIKMNEGEN();
	}

	// Token: 0x06002211 RID: 8721 RVA: 0x000EFDF5 File Offset: 0x000EDFF5
	private void GONBHNMNOLP()
	{
		AKLFPGMDKLA.EHBBFMCILPC.LPCBDEBKAIM();
		Application.Quit();
	}

	// Token: 0x06002212 RID: 8722 RVA: 0x000EFE08 File Offset: 0x000EE008
	private bool LBBMPAGCDAO(OKAFAHMOFII DDGHKOFHOGN)
	{
		bool result;
		try
		{
			if (KDCJJBLGCBH.EHBBFMCILPC.BOPBHFAICBB())
			{
				this.ADAACGDPKDC++;
				result = true;
			}
			else if (!DDGHKOFHOGN.MIACKIKIFJJ)
			{
				this.ADAACGDPKDC++;
				result = false;
			}
			else if (KDCJJBLGCBH.EHBBFMCILPC.PCDHDFCEODB() || KHPGPLAMAIN.BOIFOPEAIBN())
			{
				result = true;
			}
			else
			{
				if (KHPGPLAMAIN.IBDGNKGIMFI() != (IIHCCPLGGHP)3)
				{
					this.ADAACGDPKDC += 0;
				}
				result = (KHPGPLAMAIN.CIAFFHAENHD() == IIHCCPLGGHP.lowEnd);
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
			this.ADAACGDPKDC++;
			result = false;
		}
		return result;
	}

	// Token: 0x06002213 RID: 8723 RVA: 0x000EFEB0 File Offset: 0x000EE0B0
	private void DEOEFKNLOHM()
	{
		FirebaseAnalyticsManager.EHBBFMCILPC.LogEvent(false, AGEHCPDNBFD.cdnActiv.ToString(), FFPHBMFGCNN.dldCompl.ToString(), BGHLMGPPCNN.cdnLbyLoadPt2.ToString(), false, false);
		CommonUserInterface.EHBBFMCILPC.HideConnectingAnimation();
		CommonUserInterface.EHBBFMCILPC.GetFader().FadeIn(new TweenCallback(this.LFFAPMLLHFH));
	}

	// Token: 0x06002214 RID: 8724 RVA: 0x000EFF20 File Offset: 0x000EE120
	private bool JCPEDJJGFOO(JBBNEEHANHL HBBJBNJBMPK)
	{
		if (HBBJBNJBMPK == JBBNEEHANHL.filterTopRated || HBBJBNJBMPK == JBBNEEHANHL.filterMostPopular || HBBJBNJBMPK == JBBNEEHANHL.filterContinuePlaying || HBBJBNJBMPK == JBBNEEHANHL.filterCompleted || HBBJBNJBMPK == JBBNEEHANHL.filterFavorites || HBBJBNJBMPK == JBBNEEHANHL.filterSearch)
		{
			return true;
		}
		foreach (AssetAnthology assetAnthology in AssetsManager.EHBBFMCILPC.anthologyAssets)
		{
			IJLJDFKJIJM ijljdfkjijm = HKLPEDKJGFC.BBEPEBHNNGE(assetAnthology.header.index);
			if (ijljdfkjijm != null)
			{
				if (ijljdfkjijm.MGDAFCPCOFH == HBBJBNJBMPK)
				{
					return true;
				}
				if (ijljdfkjijm.HLEHGFIIEJN == HBBJBNJBMPK)
				{
					return true;
				}
				if (ijljdfkjijm.BFJKEJLJAIH == HBBJBNJBMPK)
				{
					return true;
				}
				if (ijljdfkjijm.MBIDFCCNCKL == HBBJBNJBMPK)
				{
					return true;
				}
				if (ijljdfkjijm.KGFKAIBMGOP == HBBJBNJBMPK)
				{
					return true;
				}
			}
		}
		return false;
	}

	// Token: 0x06002215 RID: 8725 RVA: 0x000EFFE8 File Offset: 0x000EE1E8
	private void LMJGOIINBIC()
	{
		if (ODJKHCHFKNL.LEMILALILKP() != DFGILFBGPLN.screenLobby)
		{
			return;
		}
		PassesItem.reopenOnPurchasingScreenLeft = true;
		CommonUserInterface.EHBBFMCILPC.GetGamePasses().InstantClose();
		this.ALGIAIKDEPH();
	}

	// Token: 0x06002216 RID: 8726 RVA: 0x000F0010 File Offset: 0x000EE210
	private static string LNDMCMKAFFH(JBBNEEHANHL HBBJBNJBMPK)
	{
		string text = HBBJBNJBMPK.ToString();
		if (text.StartsWith("newFilter"))
		{
			text = text.Substring("newFilter".Length);
		}
		else if (text.StartsWith("filter"))
		{
			text = text.Substring("filter".Length);
		}
		return text.ToLowerInvariant();
	}

	// Token: 0x06002217 RID: 8727 RVA: 0x000F006F File Offset: 0x000EE26F
	public void OnFooterRewardsClick()
	{
		if (!this.PDFIHFFJMJN)
		{
			return;
		}
		if (null != this.rewardsPopover)
		{
			this.rewardsPopover.Toggle();
		}
	}

	// Token: 0x06002218 RID: 8728 RVA: 0x000F0093 File Offset: 0x000EE293
	private void LCONLDIONOE()
	{
		DPGJIJGOCIC.NFIDPOMCNLP("Rate Option picked");
		PlayerPrefs.SetInt("ratePopupResult", 2);
		PlayerPrefs.Save();
		DPGJIJGOCIC.IJADBLJOAHE();
	}

	// Token: 0x06002219 RID: 8729 RVA: 0x000F00B4 File Offset: 0x000EE2B4
	private void GDCKODKFEMP()
	{
		AKLFPGMDKLA.EHBBFMCILPC.MDMPJINECJD();
		DPGJIJGOCIC.IJADBLJOAHE();
		Application.Quit();
	}

	// Token: 0x0600221A RID: 8730 RVA: 0x000F00CC File Offset: 0x000EE2CC
	private List<KLJCEMBNKNI> CHIGBPGKPFI()
	{
		List<KLJCEMBNKNI> list = new List<KLJCEMBNKNI>();
		try
		{
			List<POKPDFKMOFC> list2 = this.BELBLACNAEM();
			if (list2 == null || null == AssetsManager.EHBBFMCILPC || null == AssetsManager.EHBBFMCILPC.lobbyDataAsset)
			{
				return list;
			}
			EAFPOMNMOFP eafpomnmofp = AssetsManager.EHBBFMCILPC.lobbyDataAsset.JDMCDEKHDHM();
			CEIBHCNNIDC selectedLanguage = LanguageManager.EHBBFMCILPC.GetSelectedLanguage();
			for (int i = 0; i < list2.Count; i++)
			{
				string text = eafpomnmofp.CFBKLIEBLOF(list2[i].IEJLOIMDPDO, selectedLanguage);
				if (text == null || text.Length == 0)
				{
					DPGJIJGOCIC.ADFCDFHBDAF("SceneLobbyManager2.BuildExploreSpecs() - concept " + list2[i].IEJLOIMDPDO + " has no name in the text pack explore tab, group skipped");
				}
				else
				{
					list.Add(new KLJCEMBNKNI
					{
						HPJNLEBDMEP = KLMEAFCEKOI.coverTextExplore,
						IEJLOIMDPDO = list2[i].IEJLOIMDPDO,
						AEGIBKHFEOF = "explorepattern",
						OGKIINMNBLH = JBBNEEHANHL.filterExplore,
						BLKPIAEAANG = true,
						CDEAAKHGKIF = 1,
						FKBCEMFCBOG = false,
						JAPFMDOBPKJ = new List<int>(list2[i].JAPFMDOBPKJ)
					});
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
		return list;
	}

	// Token: 0x0600221B RID: 8731 RVA: 0x000F0228 File Offset: 0x000EE428
	private void CCODIOPDAPH()
	{
		CommonUserInterface.IKNOFBFMPGA().MCJIGJMFBMI();
		CommonUserInterface.IKNOFBFMPGA().NFBMHHPIGFA(CCOJBMMKNAP.OBOOKJPGBJN().FIENAKIHNOM("wofrewardmsgcard1"), CCOJBMMKNAP.CEGAOMEEFBE().GLEFEKBDHNK("hdr"), CCOJBMMKNAP.BFHKGNBFHCH().PPALCPINPLK("energyhinttitle"), DFGILFBGPLN.popupSignInQuestion, 787f, -12);
	}

	// Token: 0x0600221C RID: 8732 RVA: 0x000F0280 File Offset: 0x000EE480
	private List<POKPDFKMOFC> BELBLACNAEM()
	{
		List<POKPDFKMOFC> result;
		try
		{
			if (this.NIIKKCHINDO != null)
			{
				result = this.NIIKKCHINDO;
			}
			else if (null == AssetsManager.EHBBFMCILPC || null == AssetsManager.EHBBFMCILPC.lobbyDataAsset)
			{
				result = null;
			}
			else
			{
				List<MJJBPLAMLAN> list = this.BBAGGFICFDK(AssetsManager.EHBBFMCILPC.lobbyDataAsset.JDMCDEKHDHM().ACPLGCFMOCE());
				EGBNGOMIJEE egbngomijee = this.ODJAPCCLBLE();
				this.NIIKKCHINDO = GOAEAMLNFOC.DMJNCOAHBHI(list, egbngomijee, new Func<int, bool>(this.GFNPELMOHNK), new Func<int, List<JBBNEEHANHL>>(this.JNOKFMBPKMP), new Func<int, float>(this.CPOFEEGOFLP));
				DPGJIJGOCIC.NFIDPOMCNLP(string.Concat(new string[]
				{
					"SceneLobbyManager2.GetExplorePlan() - ",
					this.NIIKKCHINDO.Count.ToString(),
					" group(s) planned from ",
					list.Count.ToString(),
					" concept(s), week ",
					egbngomijee.LOPKBMGNEGJ.ToString(),
					", day ",
					egbngomijee.PBJGGLCJADD.ToString()
				}));
				result = this.NIIKKCHINDO;
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
			result = null;
		}
		return result;
	}

	// Token: 0x0600221D RID: 8733 RVA: 0x000F03BC File Offset: 0x000EE5BC
	private bool PIECGBHMOCB()
	{
		return null != AssetsManager.EHBBFMCILPC && null != AssetsManager.EHBBFMCILPC.lobbyDataAsset && AssetsManager.EHBBFMCILPC.lobbyDataAsset.PIECGBHMOCB();
	}

	// Token: 0x0600221E RID: 8734 RVA: 0x000F03EE File Offset: 0x000EE5EE
	private void FGIMMLMHMGJ()
	{
		if (ODJKHCHFKNL.LEMILALILKP() != DFGILFBGPLN.screenLobby)
		{
			return;
		}
		this.KKKKNGFMEHF();
	}

	// Token: 0x0600221F RID: 8735 RVA: 0x000F0400 File Offset: 0x000EE600
	private void MFCCFINBHEK()
	{
		this.fireworksParticles.Stop();
	}

	// Token: 0x06002220 RID: 8736 RVA: 0x000F0410 File Offset: 0x000EE610
	private void EPECDBPOOLB()
	{
		this.AECHPENEOCI();
		SceneLobbyManager2.lobbyIsActive = false;
		this.PEOGENJHMLL();
		ODJKHCHFKNL.GBCJBFACPID();
		AOBJLALDBAA.FILDBDMENPG().ONIBLJOFFPG("sfxtimeoutwarning", new UnityAction(this.ViewCardCutsceneLobby));
		AOBJLALDBAA.DBLAIDPICIG().ECDBIBPNBCO("errortitle", new UnityAction(this.IHBCLCLNFJM));
		AOBJLALDBAA.AGANFKKBPFO().ECDBIBPNBCO("SceneLobbyManager.UpdateAnthologiesHints() - exception", new UnityAction(this.NKDJKLHMAJN));
		AOBJLALDBAA.DBLAIDPICIG().PFAHGKEDFAE("pmterror013", new UnityAction(this.ICPIGGMCHEN));
		AOBJLALDBAA.BIAEAOMHBMM().MANLHALMCIH("ok", new UnityAction(this.CKNBPMFGHML));
		AOBJLALDBAA.KKPFOJMAONG().ONIBLJOFFPG("hintsigning", new UnityAction(this.OOALGPIOODP));
		AOBJLALDBAA.AGANFKKBPFO().ECDBIBPNBCO("OnResolutionChanged", new UnityAction(this.EANHFNEFGFB));
		AOBJLALDBAA.CEGAOMEEFBE().PBELMJCPJMK("Asset bundle assets destroyed:", new UnityAction(this.OnPopupCardOptionsNextClickLobby));
		AOBJLALDBAA.EHBBFMCILPC.NAMMLDPCHJO("XXX", new UnityAction(this.JEPJKDAFBMH));
		AOBJLALDBAA.CEGAOMEEFBE().MHLNJIACIGO("restartepisode", new UnityAction(this.JNCJEGFNCCP));
		AOBJLALDBAA.KKPFOJMAONG().ECDBIBPNBCO("brsl", new UnityAction(this.DHGGEFIJBHM));
		AOBJLALDBAA.KKPFOJMAONG().PBELMJCPJMK("ert", new UnityAction(this.LBFDDEFKCJN));
		AOBJLALDBAA.DBLAIDPICIG().KDIFKFKMCOH("socialfriendrequestfailedxxx", new UnityAction(this.EHIBOKHHKBF));
		AOBJLALDBAA.AGANFKKBPFO().PFAHGKEDFAE("loungeskinunavailable", new UnityAction(this.KHCPHAIGBJE));
		AOBJLALDBAA.AGANFKKBPFO().PFAHGKEDFAE("_BLEND_ADDITIVE", new UnityAction(this.IMINAEKJFCK));
		AOBJLALDBAA.DBLAIDPICIG().PBELMJCPJMK("pt", new UnityAction(this.EHBEAAKMMLL));
		AOBJLALDBAA.BIAEAOMHBMM().ECDBIBPNBCO("[LoadingEnv] loading theme set: ", new UnityAction(this.GIIFOHCFDEJ));
		AOBJLALDBAA.NMGMNAKLLMI().NAMMLDPCHJO("w", new UnityAction(this.LBEMJPOHBGK));
		AOBJLALDBAA.FILDBDMENPG().MANLHALMCIH(" (", new UnityAction(this.DGNPNOKIKJC));
		AOBJLALDBAA.FILDBDMENPG().KDIFKFKMCOH(", ", new UnityAction(this.MPLJEMEGMKA));
		AOBJLALDBAA.AGANFKKBPFO().PFAHGKEDFAE("", new UnityAction(this.PHHHJMEDNGD));
		AOBJLALDBAA.EHBBFMCILPC.KDIFKFKMCOH("p", new UnityAction(this.NLFMLMDKLNH));
		AOBJLALDBAA.KKPFOJMAONG().KDIFKFKMCOH("sfxsparklesbundles", new UnityAction(this.DPFBLBPHLGC));
		AOBJLALDBAA.DBLAIDPICIG().POLEDPIKODD("passhintinactivesub", new UnityAction(this.COIJDOCAABP));
		AOBJLALDBAA.FILDBDMENPG().ECDBIBPNBCO("", new UnityAction(this.MBEIIFKJEKD));
		AOBJLALDBAA.AGANFKKBPFO().POLEDPIKODD("OnSaveSlotsUnlockContinueToPurchasingScreen", new UnityAction(this.BJPEICPDFHJ));
		AOBJLALDBAA.BIAEAOMHBMM().KDIFKFKMCOH("Value:", new UnityAction(this.BAGNOCIMPBD));
		AOBJLALDBAA.DBLAIDPICIG().MANLHALMCIH("c_web", new UnityAction(this.JGIMEDGEAGE));
		AOBJLALDBAA.AGANFKKBPFO().PBELMJCPJMK("", new UnityAction(this.PCCPFFIJNIO));
		AOBJLALDBAA.NMGMNAKLLMI().ECDBIBPNBCO("cid", new UnityAction(this.AELPLJGOJJK));
		AOBJLALDBAA.NMGMNAKLLMI().PFAHGKEDFAE("Shaders/VideoGlitchNoiseAnalog", new UnityAction(this.GMOBHPBBPNF));
		AOBJLALDBAA.FILDBDMENPG().ECDBIBPNBCO("reward", new UnityAction(this.NELHGHFAGFH));
		AOBJLALDBAA.DBLAIDPICIG().POLEDPIKODD("ok", new UnityAction(this.FECFNFKHLKM));
		AOBJLALDBAA.KKPFOJMAONG().POLEDPIKODD("subrnw", new UnityAction(this.KBOOHCDEOIJ));
		AOBJLALDBAA.AGANFKKBPFO().MANLHALMCIH("OnSettingsPopupCloseAndNeedToShowGameModeNotif", new UnityAction(this.HAJDMFMINFE));
		AOBJLALDBAA.FILDBDMENPG().PFAHGKEDFAE("vol", new UnityAction(this.FMJMDIEKHCH));
		AOBJLALDBAA.BIAEAOMHBMM().ONIBLJOFFPG("Critical error, could not load asset bundle:", new UnityAction(this.BMPNMJCMHDG));
		AOBJLALDBAA.DBLAIDPICIG().PFAHGKEDFAE("", new UnityAction(this.MCPPLMGAGJN));
		AOBJLALDBAA.BIAEAOMHBMM().PFAHGKEDFAE(">", new UnityAction(this.ODFHPOEACJH));
		AOBJLALDBAA.CEGAOMEEFBE().ONIBLJOFFPG(" • ", new UnityAction(this.ALPMLMMFNBM));
		AOBJLALDBAA.BIAEAOMHBMM().MHLNJIACIGO("", new UnityAction(this.KCLCJADHJEH));
		AOBJLALDBAA.DBLAIDPICIG().ECDBIBPNBCO("syn", new UnityAction(this.CMKPNGPCDAB));
		AOBJLALDBAA.BIAEAOMHBMM().MANLHALMCIH("", new UnityAction(this.DNGHLBFEODC));
		AOBJLALDBAA.KKPFOJMAONG().ONIBLJOFFPG("XXX", new UnityAction(this.OCIAMGMLMLG));
		AOBJLALDBAA.EHBBFMCILPC.ECDBIBPNBCO("ok", new UnityAction(this.IKFEBEDGOIG));
		AOBJLALDBAA.CEGAOMEEFBE().MHLNJIACIGO(SceneAvatarManager.onAvatarScreenLeft, new UnityAction(this.GPNFLDDKLAJ));
		AOBJLALDBAA.EHBBFMCILPC.MANLHALMCIH("DDD", new UnityAction(this.OINFFDNGJHF));
		AOBJLALDBAA.DBLAIDPICIG().MANLHALMCIH("focuswardrobebody", new UnityAction(this.IBCPIFOFMPB));
		AOBJLALDBAA.DBLAIDPICIG().PBELMJCPJMK("sto", new UnityAction(this.GNEIAKDLELG));
		AOBJLALDBAA.BIAEAOMHBMM().NAMMLDPCHJO("errortitle", new UnityAction(this.OnChapterSnapshotRestoreExecute));
		AOBJLALDBAA.FILDBDMENPG().MANLHALMCIH("-", new UnityAction(this.RestartChapter));
		AOBJLALDBAA.AGANFKKBPFO().PBELMJCPJMK(" ", new UnityAction(this.RestartStory));
		AOBJLALDBAA.BIAEAOMHBMM().PBELMJCPJMK("PurchaseManagerUnity.OnPurchaseConfirmed(): Purchase confirmed - Product: ", new UnityAction(this.FHGDOCIIJIO));
		AOBJLALDBAA.BIAEAOMHBMM().ONIBLJOFFPG("SocialStatsUserPublicProfile.modified = false, OnPopupProfileUIDInputEndEdit()", new UnityAction(this.RestartStory1));
		AOBJLALDBAA.CEGAOMEEFBE().KDIFKFKMCOH("areyousure", new UnityAction(this.RestartStory2));
		AOBJLALDBAA.DBLAIDPICIG().ECDBIBPNBCO("OnApplicationBeforeRestart", new UnityAction(this.FIFIHHAPDBP));
		AOBJLALDBAA.CEGAOMEEFBE().NAMMLDPCHJO("OnLoadingThemeSelectorFolderFailed", new UnityAction(this.RestartStory4));
		AOBJLALDBAA.NMGMNAKLLMI().MHLNJIACIGO("htme", new UnityAction(this.OFHBPNBDAKO));
		AOBJLALDBAA.NMGMNAKLLMI().ECDBIBPNBCO("' is not an array", new UnityAction(this.EOPMIONFFPM));
		AOBJLALDBAA.CEGAOMEEFBE().MHLNJIACIGO("XXX", new UnityAction(this.DBHOJGKJPND));
		AOBJLALDBAA.KKPFOJMAONG().MANLHALMCIH("BackendRequestType.", new UnityAction(this.IEJGBPPPIHD));
		AOBJLALDBAA.FILDBDMENPG().ECDBIBPNBCO(SceneLobbyManager2.EIODJHDOHPE, new UnityAction(this.JEPHPIMHGJD));
		AOBJLALDBAA.FILDBDMENPG().PFAHGKEDFAE(SceneLobbyManager2.MHOJMLGCLOD, new UnityAction(this.OBCFGOCKEEP));
		AOBJLALDBAA.DBLAIDPICIG().PFAHGKEDFAE("sslind", new UnityAction(this.DHBMBBEGJDB));
		AOBJLALDBAA.CEGAOMEEFBE().KDIFKFKMCOH("e1pt", new UnityAction(this.LGEHFJOINIL));
		AOBJLALDBAA.AGANFKKBPFO().KDIFKFKMCOH("There needs to be one active VideoManager script on a GameObject in your scene.", new UnityAction(this.KMKDECPKCMF));
		AOBJLALDBAA.FILDBDMENPG().ONIBLJOFFPG("CLIENT.AVATAR.BODY", new UnityAction(this.CPEELJJHCNA));
		AOBJLALDBAA.DBLAIDPICIG().KDIFKFKMCOH("msUntilExpireAuto", new UnityAction(this.IAIIODBDKHK));
		AOBJLALDBAA.CEGAOMEEFBE().MHLNJIACIGO("nomorediamonds", new UnityAction(this.NCCHJAOOGBA));
		AOBJLALDBAA.AGANFKKBPFO().ECDBIBPNBCO("OnSketchThumbnailDuplicatePositive", new UnityAction(this.FGIMMLMHMGJ));
		AOBJLALDBAA.EHBBFMCILPC.NAMMLDPCHJO("$", new UnityAction(this.GONBHNMNOLP));
		AOBJLALDBAA.CEGAOMEEFBE().NAMMLDPCHJO("CHECKSUM", new UnityAction(this.OnNeedToShowNoMoreEnergyPopup));
		AOBJLALDBAA.CEGAOMEEFBE().PFAHGKEDFAE("", new UnityAction(this.OnNeedToShowNoMoreHardPopup));
		AOBJLALDBAA.BIAEAOMHBMM().KDIFKFKMCOH("OnUserpassLoginFailed", new UnityAction(this.GMFFLAFLGHH));
		AOBJLALDBAA.DBLAIDPICIG().PBELMJCPJMK("env", new UnityAction(this.LLMPAPDBHEL));
		AOBJLALDBAA.KKPFOJMAONG().ECDBIBPNBCO("", new UnityAction(this.FCJAODPFFGC));
		AOBJLALDBAA.BIAEAOMHBMM().MHLNJIACIGO("  token[", new UnityAction(this.BHGOGAKGGEG));
		AOBJLALDBAA.AGANFKKBPFO().PFAHGKEDFAE("wshcds", new UnityAction(this.GEMOOEPJGHP));
		AOBJLALDBAA.EHBBFMCILPC.PFAHGKEDFAE("offerToken", new UnityAction(this.DEOEFKNLOHM));
		AOBJLALDBAA.AGANFKKBPFO().POLEDPIKODD("OnGenericPopupManagerHide", new UnityAction(this.NAIPKHPLOGF));
		AOBJLALDBAA.BIAEAOMHBMM().ONIBLJOFFPG("ok", new UnityAction(this.CCJNHFAIMKI));
		AOBJLALDBAA.AGANFKKBPFO().ONIBLJOFFPG("", new UnityAction(this.KNLCPLJLJCC));
		AOBJLALDBAA.NMGMNAKLLMI().MANLHALMCIH("+", new UnityAction(this.JPDHKJCINAF));
		AOBJLALDBAA.DBLAIDPICIG().NAMMLDPCHJO("uid", new UnityAction(this.OnSocialModeChanged));
		AOBJLALDBAA.KKPFOJMAONG().KDIFKFKMCOH("x", new UnityAction(this.MICIKCIBLCP));
		AOBJLALDBAA.AGANFKKBPFO().ECDBIBPNBCO("_BLEND_MULTIPLY", new UnityAction(this.FLOAFHNAKJM));
		AOBJLALDBAA.BIAEAOMHBMM().PFAHGKEDFAE("cids", new UnityAction(this.KBEFBEIJPHP));
		AOBJLALDBAA.NMGMNAKLLMI().PBELMJCPJMK("OnBackendGetDefaultBundlesSuccess", new UnityAction(this.CCODIOPDAPH));
		AOBJLALDBAA.KKPFOJMAONG().MANLHALMCIH("", new UnityAction(this.OBDEAPLGMDM));
		AOBJLALDBAA.KKPFOJMAONG().MHLNJIACIGO("%", new UnityAction(this.MIPEOPGCNIA));
		AOBJLALDBAA.DBLAIDPICIG().PBELMJCPJMK("p", new UnityAction(this.NMJNFFCENDF));
		AOBJLALDBAA.DBLAIDPICIG().MHLNJIACIGO("ind", new UnityAction(this.HIPCMBBPLLC));
		AOBJLALDBAA.EHBBFMCILPC.ONIBLJOFFPG("congratstitle", new UnityAction(this.OJEMLBDNFKE));
		AOBJLALDBAA.CEGAOMEEFBE().PFAHGKEDFAE("no", new UnityAction(this.GLDAFFNHKFJ));
		AOBJLALDBAA.CEGAOMEEFBE().POLEDPIKODD("p", new UnityAction(this.HGDMADKACMJ));
		AOBJLALDBAA.BIAEAOMHBMM().NAMMLDPCHJO("errortitle", new UnityAction(this.MNHPBGIFPJK));
		AOBJLALDBAA.EHBBFMCILPC.ONIBLJOFFPG("Cdn host asset {0} is a {1} host. It must reference a {2} one.", new UnityAction(this.OFFBAMLEFNH));
		AOBJLALDBAA.EHBBFMCILPC.PBELMJCPJMK("uid", new UnityAction(this.CHAKGJICCJG));
		AOBJLALDBAA.NMGMNAKLLMI().MHLNJIACIGO(", ", new UnityAction(this.ABCCMIBKPFL));
		AOBJLALDBAA.AGANFKKBPFO().PBELMJCPJMK("Frame containers are disabled by the balance (fdfrc), bundle skipped:", new UnityAction(this.DJDBKHPCDKM));
		AOBJLALDBAA.EHBBFMCILPC.MANLHALMCIH("popupcardoptionscollectedcopyinfo", new UnityAction(this.AAMCENHGBCM));
		AOBJLALDBAA.DBLAIDPICIG().MANLHALMCIH("timeoutwarning", new UnityAction(this.BCEMOOCBJFJ));
		AOBJLALDBAA.BIAEAOMHBMM().ECDBIBPNBCO("ias", new UnityAction(this.ADPBMDNMDNG));
		AOBJLALDBAA.DBLAIDPICIG().POLEDPIKODD("aind", new UnityAction(this.NGOJBIDKBHL));
		AOBJLALDBAA.NMGMNAKLLMI().PFAHGKEDFAE("SceneLobbyManager2.OnLiveProfileThumbnailsCdnSuccess(): resident=", new UnityAction(this.LHGOFKKNKOE));
		AOBJLALDBAA.AGANFKKBPFO().KDIFKFKMCOH("importanttitle", new UnityAction(this.PIEHMJKPIGK));
		AOBJLALDBAA.CEGAOMEEFBE().ONIBLJOFFPG("", new UnityAction(this.FGOFPMAGNMJ));
		AOBJLALDBAA.CEGAOMEEFBE().POLEDPIKODD("eval", new UnityAction(this.EDMJHANBNIN));
		AOBJLALDBAA.CEGAOMEEFBE().POLEDPIKODD("NEWSAVE: Warning: Missing anthology save data, yet story save data (", new UnityAction(this.EHKDHDDJHLL));
		AOBJLALDBAA.CEGAOMEEFBE().POLEDPIKODD("JSON Parse: Quotation marks seems to be messed up.", new UnityAction(this.CPCHLINKCAK));
		AOBJLALDBAA.EHBBFMCILPC.MANLHALMCIH("cid", new UnityAction(this.AMFLJPANFGF));
		AOBJLALDBAA.NMGMNAKLLMI().MANLHALMCIH("USD", new UnityAction(this.PAFLEJIHGKJ));
		AOBJLALDBAA.FILDBDMENPG().ECDBIBPNBCO("null", new UnityAction(this.MFCCFINBHEK));
		AOBJLALDBAA.KKPFOJMAONG().NAMMLDPCHJO("skinshopinfolireq", new UnityAction(this.GOAEKMDPMEA));
		AOBJLALDBAA.EHBBFMCILPC.MHLNJIACIGO("$SETWARDROBEMETA", new UnityAction(this.HKPFHDPBJOI));
		AOBJLALDBAA.EHBBFMCILPC.PBELMJCPJMK("sfxtimeoutwarning", new UnityAction(this.BLKMDHJFNFL));
		AOBJLALDBAA.FILDBDMENPG().ONIBLJOFFPG("OnApplicationFocusNeedToUpdateCurrency", new UnityAction(this.MNJNCFPELEC));
		AOBJLALDBAA.EHBBFMCILPC.POLEDPIKODD("ok", new UnityAction(this.DDGPJJHEHLG));
		AOBJLALDBAA.BIAEAOMHBMM().ONIBLJOFFPG("hint2", new UnityAction(this.BKAJMNDHHEN));
		AOBJLALDBAA.DBLAIDPICIG().KDIFKFKMCOH("PurchaseManagerUnity.OnPurchaseFailed(): Could not find product in failed order.", new UnityAction(this.GHOHFJCGAMJ));
		AOBJLALDBAA.EHBBFMCILPC.POLEDPIKODD("ShaderEnvMorphClient", new UnityAction(this.JMBBBIDIHLO));
		AOBJLALDBAA.BIAEAOMHBMM().KDIFKFKMCOH("OnPopupPasswordInputEndEdit", new UnityAction(this.DLHBCDJOMMC));
		AOBJLALDBAA.EHBBFMCILPC.PFAHGKEDFAE("' dropped", new UnityAction(this.FAIDPMGBPIF));
		AOBJLALDBAA.DBLAIDPICIG().MANLHALMCIH("YYY", new UnityAction(this.CJEJENJBDDF));
		AOBJLALDBAA.AGANFKKBPFO().NAMMLDPCHJO("OnPurchasingViewLeave", new UnityAction(this.AJPPPKIOGKK));
	}

	// Token: 0x06002221 RID: 8737 RVA: 0x000F1163 File Offset: 0x000EF363
	private void JPDHKJCINAF()
	{
		this.NHBPLAFBNIG(-1, -1);
	}

	// Token: 0x06002222 RID: 8738 RVA: 0x000ED5C5 File Offset: 0x000EB7C5
	private IEnumerator HHHIHFAICPC()
	{
		yield return new WaitForSeconds(3f);
		this.MBGPADGCJBM = false;
		yield break;
	}

	// Token: 0x06002223 RID: 8739 RVA: 0x000F1170 File Offset: 0x000EF370
	public void OnCurrencyClick()
	{
		PurchaseManagerBridge.EHBBFMCILPC.GetPurchaseManager().Initialize();
		for (int i = 0; i < this.lobbyParticles.Count; i++)
		{
			if (null != this.lobbyParticles[i])
			{
				this.lobbyParticles[i].Stop();
			}
		}
		CommonUserInterface.EHBBFMCILPC.GetFader().FadeIn(new TweenCallback(this.OnCurrencyClickPart2));
	}

	// Token: 0x06002224 RID: 8740 RVA: 0x000F11E4 File Offset: 0x000EF3E4
	private void ALGIAIKDEPH()
	{
		for (int i = 0; i < this.canvases.Count; i++)
		{
			this.canvases[i].enabled = false;
		}
	}

	// Token: 0x06002225 RID: 8741 RVA: 0x000F121C File Offset: 0x000EF41C
	private void DNGHLBFEODC()
	{
		CommonUserInterface.EHBBFMCILPC.ShowGenericPopupTwoOverride(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("importanttitle"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("needtorestartgeneric"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("ok"), new UnityAction(this.FKPLFIDCPLP), new UnityAction(this.FKPLFIDCPLP), DFGILFBGPLN.popupSignInSuccess, 0.2f, 28);
	}

	// Token: 0x06002226 RID: 8742 RVA: 0x000F1284 File Offset: 0x000EF484
	private void MOEFNMKJPBK(OKAFAHMOFII FNJJIPNFCMK, AssetLiveEventContent NBKNFJNIDKC)
	{
		try
		{
			if (!(null == NBKNFJNIDKC) && FNJJIPNFCMK != null)
			{
				AssetAnthology assetAnthology = GKJPOGNFKNK.CMPFBJCPGGA(FNJJIPNFCMK, AKLFPGMDKLA.EHBBFMCILPC.GLKNOFHEBKN);
				bool flag = true;
				if (FNJJIPNFCMK.KONDFFEKAND == (EGMCEPOABBF)6 || FNJJIPNFCMK.KONDFFEKAND == EGMCEPOABBF.liveEventMessage || FNJJIPNFCMK.KONDFFEKAND == EGMCEPOABBF.liveEventMessage || FNJJIPNFCMK.KONDFFEKAND == EGMCEPOABBF.liveEventMessage)
				{
					flag = false;
				}
				if (null == assetAnthology && flag)
				{
					try
					{
						if (FNJJIPNFCMK.KONDFFEKAND == EGMCEPOABBF.liveEventFreeTea)
						{
							AKLFPGMDKLA.EHBBFMCILPC.GLKNOFHEBKN = FNJJIPNFCMK.EDDNDKEBMDE();
						}
					}
					catch (Exception aklgbjkdomm)
					{
						DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
					}
					CommonUserInterface.IKNOFBFMPGA().ShowGenericPopupTwoOverride(CCOJBMMKNAP.FEEDGKCJBLE().HHLECNIFHCO("<i>"), CCOJBMMKNAP.PLJMLDOCPNM().PKNHKGMNCIP("continue"), CCOJBMMKNAP.DBFFFOMCLKM().OGKGHLHHAAI("WebGL"), new UnityAction(this.FKPLFIDCPLP), new UnityAction(this.FKPLFIDCPLP), DFGILFBGPLN.popupTutorialLobby1, 606f, 60);
				}
				else
				{
					if (null != assetAnthology)
					{
						AssetAnthologyPreview2 assetAnthologyPreview = GKJPOGNFKNK.OGKPKBLFGMJ(assetAnthology.header.index);
						if (null != assetAnthologyPreview)
						{
							this.LGKGGPDKAHF = assetAnthologyPreview;
							this.IPFPANDOKKI(this.LGKGGPDKAHF);
						}
						else
						{
							DPGJIJGOCIC.ANOPFDLPKGC("ok" + assetAnthology.header.index.ToString());
						}
					}
					this.focusFade.SetActive(false);
					this.focusItem.GetComponent<FocusItem>().UpdateCardContent(FNJJIPNFCMK, NBKNFJNIDKC);
					base.StartCoroutine(this.MDFNFDIEIOH(this.focusFade, this.focusItem, this.timeFocusItemAnimation, true));
				}
			}
		}
		catch (Exception aklgbjkdomm2)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm2);
		}
	}

	// Token: 0x06002227 RID: 8743 RVA: 0x000F143C File Offset: 0x000EF63C
	private IEnumerator HNKPMLGCKHO()
	{
		AssetsManager.EHBBFMCILPC.InitializeAssetBundleFolder(this.HFFIIBBJBMH.header.CKACBBGHJGI() + LNDOOJOFFOM.Anthology0, "OnAvatarScreenAssetBundleFolderInitializeSuccess", "OnAvatarScreenAssetsDownloadFailed");
		yield return null;
		yield break;
	}

	// Token: 0x06002228 RID: 8744 RVA: 0x000F144C File Offset: 0x000EF64C
	private JBBNEEHANHL CBCGEFKGFKH(int GGICIBLJIKI)
	{
		JBBNEEHANHL result = JBBNEEHANHL.filterNone;
		foreach (AssetAnthology assetAnthology in AssetsManager.EHBBFMCILPC.anthologyAssets)
		{
			IJLJDFKJIJM ijljdfkjijm = HKLPEDKJGFC.BBEPEBHNNGE(assetAnthology.header.index);
			if (assetAnthology.header.index == GGICIBLJIKI && ijljdfkjijm != null)
			{
				if (ijljdfkjijm.MGDAFCPCOFH != JBBNEEHANHL.filterNew && ijljdfkjijm.MGDAFCPCOFH != JBBNEEHANHL.filterAll && ijljdfkjijm.MGDAFCPCOFH != JBBNEEHANHL.filterContinuePlaying && ijljdfkjijm.MGDAFCPCOFH != JBBNEEHANHL.filterCompleted && ijljdfkjijm.MGDAFCPCOFH != JBBNEEHANHL.filterFavorites && ijljdfkjijm.MGDAFCPCOFH != JBBNEEHANHL.filterMostPopular && ijljdfkjijm.MGDAFCPCOFH != JBBNEEHANHL.filterTopRated && ijljdfkjijm.MGDAFCPCOFH != JBBNEEHANHL.filterSearch && ijljdfkjijm.MGDAFCPCOFH != JBBNEEHANHL.filterNone)
				{
					return ijljdfkjijm.MGDAFCPCOFH;
				}
				if (ijljdfkjijm.HLEHGFIIEJN != JBBNEEHANHL.filterNew && ijljdfkjijm.HLEHGFIIEJN != JBBNEEHANHL.filterAll && ijljdfkjijm.HLEHGFIIEJN != JBBNEEHANHL.filterContinuePlaying && ijljdfkjijm.HLEHGFIIEJN != JBBNEEHANHL.filterCompleted && ijljdfkjijm.HLEHGFIIEJN != JBBNEEHANHL.filterFavorites && ijljdfkjijm.HLEHGFIIEJN != JBBNEEHANHL.filterMostPopular && ijljdfkjijm.HLEHGFIIEJN != JBBNEEHANHL.filterTopRated && ijljdfkjijm.HLEHGFIIEJN != JBBNEEHANHL.filterSearch && ijljdfkjijm.HLEHGFIIEJN != JBBNEEHANHL.filterNone)
				{
					return ijljdfkjijm.HLEHGFIIEJN;
				}
				if (ijljdfkjijm.BFJKEJLJAIH != JBBNEEHANHL.filterNew && ijljdfkjijm.BFJKEJLJAIH != JBBNEEHANHL.filterAll && ijljdfkjijm.BFJKEJLJAIH != JBBNEEHANHL.filterContinuePlaying && ijljdfkjijm.BFJKEJLJAIH != JBBNEEHANHL.filterCompleted && ijljdfkjijm.BFJKEJLJAIH != JBBNEEHANHL.filterFavorites && ijljdfkjijm.BFJKEJLJAIH != JBBNEEHANHL.filterMostPopular && ijljdfkjijm.BFJKEJLJAIH != JBBNEEHANHL.filterTopRated && ijljdfkjijm.BFJKEJLJAIH != JBBNEEHANHL.filterSearch && ijljdfkjijm.BFJKEJLJAIH != JBBNEEHANHL.filterNone)
				{
					return ijljdfkjijm.BFJKEJLJAIH;
				}
			}
		}
		return result;
	}

	// Token: 0x06002229 RID: 8745 RVA: 0x000F15FC File Offset: 0x000EF7FC
	private List<MJJBPLAMLAN> BBAGGFICFDK(List<MJJBPLAMLAN> OFPLLEEJIJF)
	{
		List<MJJBPLAMLAN> list = new List<MJJBPLAMLAN>();
		try
		{
			if (OFPLLEEJIJF == null || null == AssetsManager.EHBBFMCILPC || null == AssetsManager.EHBBFMCILPC.lobbyDataAsset)
			{
				return list;
			}
			EAFPOMNMOFP eafpomnmofp = AssetsManager.EHBBFMCILPC.lobbyDataAsset.JDMCDEKHDHM();
			CEIBHCNNIDC selectedLanguage = LanguageManager.EHBBFMCILPC.GetSelectedLanguage();
			for (int i = 0; i < OFPLLEEJIJF.Count; i++)
			{
				string text = eafpomnmofp.CFBKLIEBLOF(OFPLLEEJIJF[i].DBHMNECMIAB, selectedLanguage);
				if (text != null && text.Length != 0)
				{
					list.Add(OFPLLEEJIJF[i]);
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
		return list;
	}

	// Token: 0x0600222A RID: 8746 RVA: 0x000F16B4 File Offset: 0x000EF8B4
	private void OPFLFDKJGFJ()
	{
		SceneLobbyManager2.BJBOJLBOOEF = this;
		this.IPAFGLONDJF = false;
		this.NJOHOGOEINP();
		SceneLobbyManager2.CHGGOOEADOC = false;
		if (GeoLocationManager.OBLBFDGDGBC().Equals("OnBackendUpgradeToGiftCardSuccess"))
		{
			FirebaseAnalyticsManager.DMAAFFFEJGA().LogEvent(false, AGEHCPDNBFD.srvMode.ToString(), LanguageManager.EHBBFMCILPC.IEBFINIJAMJ().ToString(), GeoLocationManager.CHFGBBHJCGM(), false, true);
		}
		FirebaseAnalyticsManager.ANCEKPONIFI().LKONPEEDKNF(false, AGEHCPDNBFD.rqst.ToString(), NBDLBFJOEGN.GKDEMBJGKJP(), NBDLBFJOEGN.JHNDHBLDJOI(), false, true);
		FirebaseAnalyticsManager.COKDLDOAACJ().JIAAMJPKOCE(false, AGEHCPDNBFD.techDef.ToString(), FFPHBMFGCNN.post.ToString(), KHPGPLAMAIN.AKJOFJPLONG().ToString(), true, false);
		if (KHPGPLAMAIN.NKMCPGBKEEP())
		{
			FirebaseAnalyticsManager.COKDLDOAACJ().LMCJKLHOHJC(false, AGEHCPDNBFD.d1Ret.ToString(), ((FFPHBMFGCNN)97).ToString(), BGHLMGPPCNN.d1AdSplashEnd.ToString(), false, false);
		}
		else
		{
			FirebaseAnalyticsManager.EHBBFMCILPC.JIAAMJPKOCE(true, AGEHCPDNBFD.rqst.ToString(), ((FFPHBMFGCNN)(-68)).ToString(), ((BGHLMGPPCNN)(-72)).ToString(), true, false);
		}
		if (KHPGPLAMAIN.BBHKHCBICGA())
		{
			FirebaseAnalyticsManager.DMAAFFFEJGA().LKONPEEDKNF(false, AGEHCPDNBFD.gnrSelect.ToString(), FFPHBMFGCNN.socReport.ToString(), BGHLMGPPCNN.d1LobbyOpen.ToString(), true, false);
		}
		else
		{
			FirebaseAnalyticsManager.EHBBFMCILPC.AAIABAKHLAH(false, AGEHCPDNBFD.d1Ret.ToString(), ((FFPHBMFGCNN)(-118)).ToString(), ((BGHLMGPPCNN)(-53)).ToString(), true, true);
		}
		if (KHPGPLAMAIN.AKEFOGDGCBJ())
		{
			FirebaseAnalyticsManager.DEALKJPEMMH().AAIABAKHLAH(false, AGEHCPDNBFD.gnrSelect.ToString(), FFPHBMFGCNN.coVerfailed.ToString(), ((BGHLMGPPCNN)(-87)).ToString(), false, false);
		}
		else
		{
			FirebaseAnalyticsManager.ANCEKPONIFI().LKONPEEDKNF(false, AGEHCPDNBFD.d1Ret.ToString(), ((FFPHBMFGCNN)(-81)).ToString(), ((BGHLMGPPCNN)(-31)).ToString(), true, false);
		}
		this.EJNCBBFGGLH = this.recommendedSetupButton.GetComponent<RectTransform>();
		this.KHGNNCCKEPG = this.shuffleButton.GetComponent<RectTransform>();
		this.CGHKPPLLBKN = this.EJNCBBFGGLH.anchoredPosition;
		this.KIODPNAKDIF = this.KHGNNCCKEPG.anchoredPosition;
		this.BDLMHIGGAHI = this.recommendedSetupButton.GetComponent<CanvasGroup>();
		this.KHKDPJNCPJN = this.shuffleButton.GetComponent<CanvasGroup>();
		ImageFrameAnimation.NEODHMLNJDG(-1);
		this.EKNLABKCIJF();
		AKLFPGMDKLA.EHBBFMCILPC.EGOCMDJBLNJ++;
		AssetsManager.MJBDMHPHMID().GetLoadingProgressSnapshot().IBBOJOJCDAJ(0);
	}

	// Token: 0x0600222B RID: 8747 RVA: 0x000F19A8 File Offset: 0x000EFBA8
	private List<KLJCEMBNKNI> PGBKAHOGNGO()
	{
		List<KLJCEMBNKNI> list = new List<KLJCEMBNKNI>();
		try
		{
			List<int> list2 = this.DGPAFDKHLJL(JBBNEEHANHL.filterNew);
			if (list2.Count == 0)
			{
				return list;
			}
			CMOLLGLINGG cmollglingg = null;
			if (null != AssetsManager.EHBBFMCILPC && null != AssetsManager.EHBBFMCILPC.lobbyDataAsset)
			{
				cmollglingg = AssetsManager.EHBBFMCILPC.lobbyDataAsset.FLFDAOMEDDB().BBKIHDLBLFA();
			}
			int enonnldggin = 0;
			int cngainaigbb = 0;
			int num = -1;
			if (cmollglingg != null)
			{
				enonnldggin = cmollglingg.KFIIKPJIBFA;
				cngainaigbb = cmollglingg.LDMPKCEGKLJ;
				num = LGAADGMPCLJ.IIONBBBMMHE(cmollglingg, LanguageManager.EHBBFMCILPC.GetSelectedLanguage());
			}
			if (num > 0)
			{
				KLJCEMBNKNI kljcembnkni = this.AGFJMDBMKBN("coverNew", num, enonnldggin, cngainaigbb, "", "newpattern", JBBNEEHANHL.filterNew, list2);
				kljcembnkni.IHIDEHKNBBH = false;
				list.Add(kljcembnkni);
			}
			else
			{
				list.Add(this.AGFJMDBMKBN("coverNewFallback", 0, enonnldggin, cngainaigbb, "", "newpattern", JBBNEEHANHL.filterNew, list2));
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
		return list;
	}

	// Token: 0x0600222C RID: 8748 RVA: 0x000EF864 File Offset: 0x000EDA64
	public void LICMHDGKOOH()
	{
		this.RestartStoryX(1);
	}

	// Token: 0x0600222D RID: 8749 RVA: 0x000F1AA8 File Offset: 0x000EFCA8
	private string AECCHBMDHBE()
	{
		string @string = PlayerPrefs.GetString("lastFilter", JBBNEEHANHL.filterNew.ToString());
		if (!PlayerPrefs.HasKey("lastFilterTapped") && this.OGMODMPACPJ())
		{
			return JBBNEEHANHL.filterStarter.ToString();
		}
		if (JBBNEEHANHL.filterStarter.ToString() == @string && !this.OGMODMPACPJ())
		{
			return JBBNEEHANHL.filterNew.ToString();
		}
		if (JBBNEEHANHL.filterTopRated.ToString() == @string && this.IINBDHLPNMP())
		{
			return JBBNEEHANHL.filterExplore.ToString();
		}
		if (JBBNEEHANHL.filterCompleted.ToString() == @string)
		{
			return JBBNEEHANHL.filterContinuePlaying.ToString();
		}
		return @string;
	}

	// Token: 0x0600222E RID: 8750 RVA: 0x000F1B80 File Offset: 0x000EFD80
	private void GMOBHPBBPNF()
	{
		List<int> ilpnkgbhgol = this.ILPNKGBHGOL;
		this.ILPNKGBHGOL = new List<int>();
		if (this.EPJBDIIAIAJ)
		{
			this.EPJBDIIAIAJ = false;
			this.CJEJCGOCFJF = false;
			return;
		}
		for (int i = 0; i < ilpnkgbhgol.Count; i++)
		{
			int num = ilpnkgbhgol[i];
			if (num >= 0 && !GKJPOGNFKNK.AKJCGMFMGMK(num))
			{
				int num2 = 0;
				this.LCMLDDFFBGM.TryGetValue(num, out num2);
				num2++;
				this.LCMLDDFFBGM[num] = num2;
				DPGJIJGOCIC.ADFCDFHBDAF("SceneLobbyManager2.OnLiveProfileThemeBackgroundCdnFailed(): live profile theme " + num.ToString() + " attempt " + num2.ToString());
				if (num2 >= 3 && !this.EMFGMAIBBLE.Contains(num))
				{
					this.EMFGMAIBBLE.Add(num);
				}
			}
		}
		this.EPJBDIIAIAJ = false;
		base.StartCoroutine(this.KGCKFGMOCJK());
	}

	// Token: 0x0600222F RID: 8751 RVA: 0x000F1C54 File Offset: 0x000EFE54
	private void FIPGMHIMFMK(JBBNEEHANHL GLOCCAIDHJC)
	{
		base.StartCoroutine(this.ELPJIHLDEFP(GLOCCAIDHJC));
	}

	// Token: 0x06002230 RID: 8752 RVA: 0x000F1C64 File Offset: 0x000EFE64
	public void RestartChapter()
	{
		FPEHHFKFBJK fpehhfkfbjk = null;
		try
		{
			fpehhfkfbjk = this.focusItem.GetComponent<FocusItem>().chapterSnapshotsItem.GetLastChapterSnapshotRestoreDesc();
		}
		catch (Exception aklgbjkdomm)
		{
			fpehhfkfbjk = null;
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
		if (fpehhfkfbjk != null && LanguageManager.EHBBFMCILPC.GetSelectedLanguage() != CEIBHCNNIDC.en && LanguageManager.EHBBFMCILPC.GetSelectedLanguage() != CEIBHCNNIDC.ru)
		{
			try
			{
				AssetStoryHeader assetStoryHeader = null;
				if (null != this.HFFIIBBJBMH)
				{
					assetStoryHeader = GKJPOGNFKNK.CDCEFHLNNEC(this.HFFIIBBJBMH.header.availableStories[fpehhfkfbjk.MIBPOIDDBAD]);
				}
				if (assetStoryHeader != null && !this.CILHBPNJDFA(assetStoryHeader, fpehhfkfbjk.FEJANNNLLON, -1, LanguageManager.EHBBFMCILPC.GetSelectedLanguage()))
				{
					this.OnPlaySoonClick();
					return;
				}
			}
			catch (Exception aklgbjkdomm2)
			{
				DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm2);
			}
		}
		this.HideStoryRestartPopup();
		this.GKHNIMJJLJL.KJKMJBMFDAN();
		BackendOperationsManager.EHBBFMCILPC.PostponeRequestRestartChapterOrStory(AKLFPGMDKLA.ACFJMCBMOFG(this.LDIGGOPHGMI.index, AKLFPGMDKLA.EHBBFMCILPC.NCOCIAENGJF(this.LDIGGOPHGMI.index)));
		AKLFPGMDKLA.EHBBFMCILPC.EACONLGBIFC(AKLFPGMDKLA.ACFJMCBMOFG(this.LDIGGOPHGMI.index, AKLFPGMDKLA.EHBBFMCILPC.NCOCIAENGJF(this.LDIGGOPHGMI.index)), this.GKHNIMJJLJL.DHONIOBOLEL.DDEDAHCFHJN());
		this.EFPDMJBADBB(this.LGKGGPDKAHF);
		this.OnPlayClickStart();
	}

	// Token: 0x06002231 RID: 8753 RVA: 0x000F1DC8 File Offset: 0x000EFFC8
	public void OnPopupNotEnoughEnergyOrHardCurrencyGetMore()
	{
		PurchaseManagerBridge.EHBBFMCILPC.GetPurchaseManager().Initialize();
		CommonUserInterface.EHBBFMCILPC.GetFader().FadeIn(new TweenCallback(this.OnPopupNotEnoughEnergyOrHardCurrencyGetMore2));
	}

	// Token: 0x06002232 RID: 8754 RVA: 0x000F1DF4 File Offset: 0x000EFFF4
	private void NHBPLAFBNIG(int IPBIPCLNOIE = -1, int MDGNDDPFJLP = -1)
	{
		if (IPBIPCLNOIE >= 0)
		{
			this.teaText.GetComponent<AnimationTextIncrement>().Set(IPBIPCLNOIE, -1f, 0f);
		}
		else
		{
			this.teaText.GetComponent<AnimationTextIncrement>().Set(AKLFPGMDKLA.EHBBFMCILPC.MPMKMCJFHOG.GALKFKBPLCK(), -1f, 0f);
		}
		if (MDGNDDPFJLP >= 0)
		{
			this.diamondsText.GetComponent<AnimationTextIncrement>().Set(MDGNDDPFJLP, -1f, 0f);
			return;
		}
		this.diamondsText.GetComponent<AnimationTextIncrement>().Set(AKLFPGMDKLA.EHBBFMCILPC.ODMKLADKHMO.GALKFKBPLCK(), -1f, 0f);
	}

	// Token: 0x06002233 RID: 8755 RVA: 0x000F1E94 File Offset: 0x000F0094
	public bool NeedToCompletePrequelAnthology()
	{
		try
		{
			if (this.HFFIIBBJBMH.header.completedStoryIndexRequirement >= 0)
			{
				AssetStoryHeader assetStoryHeader = GKJPOGNFKNK.CDCEFHLNNEC(this.HFFIIBBJBMH.header.completedStoryIndexRequirement);
				if (null != assetStoryHeader && !assetStoryHeader.MLGKEPJPICJ(AKLFPGMDKLA.EHBBFMCILPC.JDCBFAPDJIM(assetStoryHeader.index, -1).DHONIOBOLEL.DDEDAHCFHJN()))
				{
					AssetAnthology assetAnthology = GKJPOGNFKNK.GJAAHGIAPMH(assetStoryHeader.index);
					this.OnNeedToCompleteAnthology(assetAnthology.header.index);
					return true;
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
		return false;
	}

	// Token: 0x06002234 RID: 8756 RVA: 0x000F1F34 File Offset: 0x000F0134
	private void DPEDKLLEABO()
	{
		DPGJIJGOCIC.IJADBLJOAHE();
		Application.Quit();
	}

	// Token: 0x06002235 RID: 8757 RVA: 0x000F1F40 File Offset: 0x000F0140
	private void LBPCHKHFKIK()
	{
		if (this == SceneLobbyManager2.BJBOJLBOOEF)
		{
			SceneLobbyManager2.BJBOJLBOOEF = null;
		}
		try
		{
			FADIGFEOCND.BGMALDJFMKE(this.NAEHPAIOHLG);
			FADIGFEOCND.BGMALDJFMKE(this.BJGAJOKENMG);
			FADIGFEOCND.NEDPAGFLFNO(this.ENJMJIPADNO);
			FADIGFEOCND.IOENHNIKIIC(this.PHMIBKAJKMB);
			this.NAEHPAIOHLG = (this.BJGAJOKENMG = (this.ENJMJIPADNO = null));
			this.EFJGLLPDJKO();
			this.DDBMAENEIAA();
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x06002236 RID: 8758 RVA: 0x000F1FCC File Offset: 0x000F01CC
	private void KBOOHCDEOIJ()
	{
		base.StartCoroutine(this.FINPCOMDIFD(this.profileFade2, this.profileItem2, this.timeFocusItemAnimation, false));
	}

	// Token: 0x06002238 RID: 8760 RVA: 0x000F221C File Offset: 0x000F041C
	private void ONBMOPMOIKI()
	{
		CommonUserInterface.EHBBFMCILPC.ShowGenericPopup(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("importanttitle"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("featurenotavailable"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("ok"), DFGILFBGPLN.popupSignInQuestion, 0f, 28);
	}

	// Token: 0x06002239 RID: 8761 RVA: 0x000F226C File Offset: 0x000F046C
	private void MOKILOPIIAD()
	{
		if (this.NAEHPAIOHLG == null)
		{
			this.NAEHPAIOHLG = FADIGFEOCND.IMEFIJEKFGI(1326f);
		}
		if (this.BJGAJOKENMG == null)
		{
			this.BJGAJOKENMG = FADIGFEOCND.JHMKFKNAADK(865f);
		}
		if (this.ENJMJIPADNO == null)
		{
			this.ENJMJIPADNO = FADIGFEOCND.IMEFIJEKFGI(208f);
		}
	}

	// Token: 0x0600223A RID: 8762 RVA: 0x000F22C1 File Offset: 0x000F04C1
	private void FHGEMNHNNLB()
	{
		this.IDJEMNCLFDN();
		AppManager.EHBBFMCILPC.RestartApp(true, true);
	}

	// Token: 0x0600223B RID: 8763 RVA: 0x000F22D8 File Offset: 0x000F04D8
	private void JFKINOOLKJN()
	{
		AOBJLALDBAA.EHBBFMCILPC.MFIMALJPCDP("OnLobbyLoungeOpenRequested", new UnityAction(this.BAKCPDNFFMH));
		AOBJLALDBAA.EHBBFMCILPC.MFIMALJPCDP("OnLobbyLoungeAssetBundleFolderInitializeSuccess", new UnityAction(this.FMHCMHNFOPC));
		AOBJLALDBAA.EHBBFMCILPC.MFIMALJPCDP("OnLobbyLoungeAssetsDownloadSuccess", new UnityAction(this.AGGHLICBNNF));
		AOBJLALDBAA.EHBBFMCILPC.MFIMALJPCDP("OnLobbyLoungeAssetsDownloadFailed", new UnityAction(this.HKHKEMFOMBK));
		AOBJLALDBAA.EHBBFMCILPC.MFIMALJPCDP("OnLoungePremiumChoicesHistorySuccess", new UnityAction(this.ICLFENDADFN));
		AOBJLALDBAA.EHBBFMCILPC.MFIMALJPCDP("OnLoungePremiumChoicesHistoryException", new UnityAction(this.EEGDFPJGECN));
		AOBJLALDBAA.EHBBFMCILPC.MFIMALJPCDP(SceneLoungeManager.onLoungeScreenLeft, new UnityAction(this.LODFBFMAOGL));
	}

	// Token: 0x0600223C RID: 8764 RVA: 0x000F23A4 File Offset: 0x000F05A4
	private void EMMKCALILGG(JBBNEEHANHL GLOCCAIDHJC, GameObject MIKAOBOCICP)
	{
		List<int> list = this.DGPAFDKHLJL(GLOCCAIDHJC);
		for (int i = 0; i < list.Count; i++)
		{
			this.LHGBCPLGLDB(list[i], MIKAOBOCICP, GLOCCAIDHJC);
		}
	}

	// Token: 0x0600223D RID: 8765 RVA: 0x000F23DC File Offset: 0x000F05DC
	public void CDBIMLMNCBJ()
	{
		FPEHHFKFBJK fpehhfkfbjk = null;
		try
		{
			fpehhfkfbjk = this.focusItem.GetComponent<FocusItem>().chapterSnapshotsItem.GDKLFFHGFOL();
		}
		catch (Exception aklgbjkdomm)
		{
			fpehhfkfbjk = null;
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
		if (fpehhfkfbjk != null && LanguageManager.EHBBFMCILPC.MLOLBFBODHD() != CEIBHCNNIDC.en && LanguageManager.EHBBFMCILPC.GetSelectedLanguage() != CEIBHCNNIDC.en)
		{
			try
			{
				AssetStoryHeader assetStoryHeader = null;
				if (null != this.HFFIIBBJBMH)
				{
					assetStoryHeader = GKJPOGNFKNK.CDCEFHLNNEC(this.HFFIIBBJBMH.header.availableStories[fpehhfkfbjk.MIBPOIDDBAD]);
				}
				if (assetStoryHeader != null && !this.CILHBPNJDFA(assetStoryHeader, fpehhfkfbjk.FEJANNNLLON, -1, LanguageManager.EHBBFMCILPC.GetSelectedLanguage()))
				{
					this.OnPlaySoonClick();
					return;
				}
			}
			catch (Exception aklgbjkdomm2)
			{
				DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm2);
			}
		}
		this.HideStoryRestartPopup();
		this.GKHNIMJJLJL.JGPEPCDDFPA();
		BackendOperationsManager.NPDDBAONMJP().HOOFIEPAHJL(AKLFPGMDKLA.GIJABPFHGMO(this.LDIGGOPHGMI.index, AKLFPGMDKLA.EHBBFMCILPC.NCOCIAENGJF(this.LDIGGOPHGMI.index)));
		AKLFPGMDKLA.EHBBFMCILPC.EACONLGBIFC(AKLFPGMDKLA.GIJABPFHGMO(this.LDIGGOPHGMI.index, AKLFPGMDKLA.EHBBFMCILPC.NCOCIAENGJF(this.LDIGGOPHGMI.index)), this.GKHNIMJJLJL.DHONIOBOLEL.DDEDAHCFHJN());
		this.EFPDMJBADBB(this.LGKGGPDKAHF);
		this.OnPlayClickStart();
	}

	// Token: 0x0600223E RID: 8766 RVA: 0x000F2540 File Offset: 0x000F0740
	private void JGIMEDGEAGE()
	{
		if (!ProfileItem2.profileWindowActive)
		{
			return;
		}
		this.DGCNKCFHGAO = true;
		this.BDGPIIONPIA = false;
		if (this.IFHLHLICMHP == null)
		{
			this.IFHLHLICMHP = base.StartCoroutine(this.POCCFEKFBKI());
		}
	}

	// Token: 0x0600223F RID: 8767 RVA: 0x000F2572 File Offset: 0x000F0772
	private int CHBDAKMFMGL(JBBNEEHANHL HBBJBNJBMPK)
	{
		if (JBBNEEHANHL.filterExplore == HBBJBNJBMPK)
		{
			return 5;
		}
		return 0;
	}

	// Token: 0x06002240 RID: 8768 RVA: 0x000F257C File Offset: 0x000F077C
	private void BGNMIIHJALJ()
	{
		if (AKLFPGMDKLA.EHBBFMCILPC.MPMKMCJFHOG.GALKFKBPLCK() == 0)
		{
			this.energyTimerBlock.SetActive(true);
			this.textEnergyTimer.text = DPGJIJGOCIC.DMENNJGBMBH((int)this.NAEHPAIOHLG.ODHBINFKIPL());
			this.textEnergyTimer.SetText(DPGJIJGOCIC.DMENNJGBMBH((int)this.NAEHPAIOHLG.ODHBINFKIPL()), true);
			if (this.NAEHPAIOHLG.HACBALNLLPP())
			{
				AKLFPGMDKLA.EHBBFMCILPC.MPMKMCJFHOG.IIFIBJDPHFF(1);
				this.NHBPLAFBNIG(-1, -1);
			}
		}
		else
		{
			this.energyTimerBlock.SetActive(false);
		}
		if (AKLFPGMDKLA.EHBBFMCILPC.MPMKMCJFHOG.GALKFKBPLCK() < 3 && this.NAEHPAIOHLG != null)
		{
			RewardOption.energyFireTime = (int)this.NAEHPAIOHLG.ODHBINFKIPL();
		}
		RewardOption.spinFireTime = (int)this.PHMIBKAJKMB.ODHBINFKIPL();
	}

	// Token: 0x06002241 RID: 8769 RVA: 0x000F2650 File Offset: 0x000F0850
	private List<KLJCEMBNKNI> HOCALHHJHNE()
	{
		List<KLJCEMBNKNI> list = new List<KLJCEMBNKNI>();
		try
		{
			List<int> list2 = this.DGPAFDKHLJL(JBBNEEHANHL.filterContinuePlaying);
			if (list2.Count > 0)
			{
				list.Add(this.AGFJMDBMKBN("coverContinue", list2.Count, 0, 0, "", "mystoriespattern", JBBNEEHANHL.filterContinuePlaying, list2));
			}
			List<int> list3 = this.DGPAFDKHLJL(JBBNEEHANHL.filterCompleted);
			if (list3.Count > 0)
			{
				list.Add(this.AGFJMDBMKBN("coverCompleted", list3.Count, 0, 0, "", "mystoriespattern", JBBNEEHANHL.filterContinuePlaying, list3));
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
		return list;
	}

	// Token: 0x06002242 RID: 8770 RVA: 0x000F26EC File Offset: 0x000F08EC
	private void NLAFDANCAFK()
	{
		this.AAHJNGODNKI.Clear();
		this.LPBFGPLHDPM = false;
	}

	// Token: 0x06002243 RID: 8771 RVA: 0x000F2700 File Offset: 0x000F0900
	public void KGMEJHNLKHG()
	{
		if (this.LDIGGOPHGMI.ECDNLLDDMEA(this.GKHNIMJJLJL.DHONIOBOLEL.CFGFOEEEJKJ) == null)
		{
			CommonUserInterface.IKNOFBFMPGA().ShowGenericPopupOneOverride(CCOJBMMKNAP.CEGAOMEEFBE().HDIPNMFHIEJ("null"), CCOJBMMKNAP.LMCCLMFGEBD().IPEIONBNIPH("socialmaketradeable"), CCOJBMMKNAP.GIOAFDDKKHI().GLEFEKBDHNK("sscsp") + "anthologiestitle" + (this.MICMIKNOOEC + 1).ToString(), new UnityAction(this.OnRestartClick), (DFGILFBGPLN)(-52), 290f, -17);
			return;
		}
		this.OnPlayClickExecute();
	}

	// Token: 0x06002244 RID: 8772 RVA: 0x000F2798 File Offset: 0x000F0998
	public void SetBlockDownloadMissingLowPreview2Assets(bool DFFHLDNHDPM)
	{
		this.GBBHKFFENBE = DFFHLDNHDPM;
	}

	// Token: 0x06002245 RID: 8773 RVA: 0x000F27A4 File Offset: 0x000F09A4
	private bool CILHBPNJDFA(AssetStoryHeader JFCABBGNNKJ, int OLKMHHNMDLP, int GPIKAPMPCNL, CEIBHCNNIDC NIIIMDHGGEN)
	{
		bool result;
		try
		{
			if (OLKMHHNMDLP >= JFCABBGNNKJ.chapterAssetPacks.Count)
			{
				result = false;
			}
			else
			{
				for (int i = JFCABBGNNKJ.chapterAssetPacks[OLKMHHNMDLP].inkRevisions.Count - 1; i >= 0; i--)
				{
					if (JFCABBGNNKJ.chapterAssetPacks[OLKMHHNMDLP].inkRevisions[i].revision == GPIKAPMPCNL || GPIKAPMPCNL <= 0)
					{
						for (int j = 0; j < JFCABBGNNKJ.chapterAssetPacks[OLKMHHNMDLP].inkRevisions[i].supportedLanguages.Count; j++)
						{
							if (NIIIMDHGGEN == JFCABBGNNKJ.chapterAssetPacks[OLKMHHNMDLP].inkRevisions[i].supportedLanguages[j])
							{
								return true;
							}
						}
						break;
					}
				}
				result = false;
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
			result = true;
		}
		return result;
	}

	// Token: 0x06002246 RID: 8774 RVA: 0x000F2888 File Offset: 0x000F0A88
	private void PEKMHDKPKML()
	{
		this.MNGIPAFFFEA();
	}

	// Token: 0x06002247 RID: 8775 RVA: 0x000F2890 File Offset: 0x000F0A90
	public bool GetBlockDownloadMissingLowPreview2Assets()
	{
		return this.GBBHKFFENBE;
	}

	// Token: 0x06002248 RID: 8776 RVA: 0x000F2898 File Offset: 0x000F0A98
	public void OnPlayClickExecute()
	{
		this.GBBHKFFENBE = true;
		this.PEOGENJHMLL();
		AssetsManager.EHBBFMCILPC.ForceStopAllOperations();
		if (this.GKHNIMJJLJL != null)
		{
			AKLFPGMDKLA.EHBBFMCILPC.EBNJHPICFGE(this.GKHNIMJJLJL, 0);
		}
		if (this.JCEPMIFAIIH != null)
		{
			this.JCEPMIFAIIH.CNOLLGNCLDD = 0;
			this.JCEPMIFAIIH.GHPOILLKPJD++;
			SceneLobbyManager2.currentlyPlayingAnthology = this.JCEPMIFAIIH.GGICIBLJIKI;
		}
		BackendOperationsManager.EHBBFMCILPC.QueueRequestSaveSyncMoment(null, "startPlayChapter");
		BackendOperationsManager.EHBBFMCILPC.RequestStartPlayChapter("OnBackendStartPlayChapterSuccess", "OnBackendStartPlayChapterException", AKLFPGMDKLA.ACFJMCBMOFG(this.LDIGGOPHGMI.index, AKLFPGMDKLA.EHBBFMCILPC.NCOCIAENGJF(this.LDIGGOPHGMI.index)), this.MICMIKNOOEC, SceneLobbyManager2.currentlyPlayingAnthology, false);
		CommonUserInterface.EHBBFMCILPC.ShowConnectingAnimation(96);
		AdsManagerLP.EHBBFMCILPC.RefreshAdUnits();
		ApplicationFocusManager.Deactivate();
	}

	// Token: 0x06002249 RID: 8777 RVA: 0x000F2980 File Offset: 0x000F0B80
	private void IKFEBEDGOIG()
	{
		if (!KDCJJBLGCBH.EHBBFMCILPC.FFDKEENNENC() && !AKLFPGMDKLA.EHBBFMCILPC.EAFEJCKIEPL(16))
		{
			CommonUserInterface.EHBBFMCILPC.ShowGenericPopupWithTwoButtonsAndCloseOverride(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("lightmodetitle"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("lightmodeintrobody"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("lightmodebtn0"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("lightmodebtn1"), new UnityAction(this.CIBKGEHJKCC), new UnityAction(this.HOJKLCFKFLL), new UnityAction(this.HOJKLCFKFLL), DFGILFBGPLN.popupTools, 0.15f, 28);
			AKLFPGMDKLA.EHBBFMCILPC.LDAPMNLGAPC(16);
			return;
		}
		if (KHPGPLAMAIN.EJCNHEBIOJF())
		{
			CommonUserInterface.EHBBFMCILPC.ShowGenericPopupTwoOverride(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("lightmodebtn0") + " (" + CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("ontitle").ToLower() + ")", CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("lightmodeintrobody1"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("ok"), new UnityAction(this.FKPLFIDCPLP), new UnityAction(this.FKPLFIDCPLP), DFGILFBGPLN.popupSignInSuccess, 0.2f, 28);
			return;
		}
		CommonUserInterface.EHBBFMCILPC.ShowGenericPopupTwoOverride(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("lightmodebtn1") + " (" + CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("ontitle").ToLower() + ")", CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("lightmodeintrobody2"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("ok"), new UnityAction(this.FKPLFIDCPLP), new UnityAction(this.FKPLFIDCPLP), DFGILFBGPLN.popupSignInSuccess, 0.2f, 28);
	}

	// Token: 0x0600224A RID: 8778 RVA: 0x000F2B2C File Offset: 0x000F0D2C
	private int KCPLIPJHCAO(HAKFHALKMBH PIEEFOHHDKO, int CMBCNMLGPPC)
	{
		int num = 1;
		try
		{
			if (PIEEFOHHDKO == null || null == PIEEFOHHDKO.NHOAHJMPCFC)
			{
				return 0;
			}
			GameObject gameObject = Resources.Load<GameObject>("");
			if (null == gameObject)
			{
				return 1;
			}
			RectTransform component = PIEEFOHHDKO.NHOAHJMPCFC.GetComponent<RectTransform>();
			float num2 = component.rect.height;
			this.LBHJBEANCDC();
			while (num < CMBCNMLGPPC && PIEEFOHHDKO.CKBJGCFCHGA < PIEEFOHHDKO.LGIAOIGIGPI.Count)
			{
				int ckbjgcfchga = PIEEFOHHDKO.CKBJGCFCHGA;
				KLJCEMBNKNI kljcembnkni = PIEEFOHHDKO.LGIAOIGIGPI[ckbjgcfchga];
				PIEEFOHHDKO.CKBJGCFCHGA += 0;
				if (kljcembnkni != null)
				{
					string hjejjgafham = "";
					string mchooehcanp = "";
					if (!this.KBDAFKOEDCK(kljcembnkni, out hjejjgafham, out mchooehcanp))
					{
						string[] array = new string[73];
						array[0] = "assetbundleprofiledata3";
						array[0] = PIEEFOHHDKO.GLOCCAIDHJC.ToString();
						array[3] = "Avatar pack (hidden or exposed) has been LOADED:";
						array[1] = ckbjgcfchga.ToString();
						array[5] = "$STOPMUS";
						array[0] = kljcembnkni.MHCFDMNGOEF;
						array[6] = kljcembnkni.IEJLOIMDPDO;
						array[2] = "*";
						array[1] = kljcembnkni.KCIODOKEDAM.ToString();
						array[22] = "YYY";
						DPGJIJGOCIC.ADFCDFHBDAF(string.Concat(array));
					}
					else
					{
						GameObject gameObject2 = UnityEngine.Object.Instantiate<GameObject>(this.smallItemParentPrefab, PIEEFOHHDKO.NHOAHJMPCFC.transform);
						gameObject2.layer = PIEEFOHHDKO.NHOAHJMPCFC.layer;
						GridController component2 = gameObject2.GetComponent<GridController>();
						component2.filter = PIEEFOHHDKO.GLOCCAIDHJC;
						GameObject gameObject3 = UnityEngine.Object.Instantiate<GameObject>(gameObject, gameObject2.transform);
						gameObject3.layer = PIEEFOHHDKO.NHOAHJMPCFC.layer;
						for (int i = 0; i < kljcembnkni.JAPFMDOBPKJ.Count; i += 0)
						{
							int num3 = kljcembnkni.JAPFMDOBPKJ[i];
							if (!(null == GKJPOGNFKNK.LDFIAOCJEOJ(num3)))
							{
								this.LHGBCPLGLDB(num3, gameObject2, PIEEFOHHDKO.GLOCCAIDHJC);
								if (kljcembnkni.FKBCEMFCBOG)
								{
									ThumbnailItem component3 = gameObject2.transform.GetChild(gameObject2.transform.childCount - 1).GetComponent<ThumbnailItem>();
									if (null != component3)
									{
										component3.PAMCPENBICF(gameObject2.transform.childCount - 0);
									}
								}
							}
						}
						int num4 = gameObject2.transform.childCount - 0;
						if (num4 < 0 || num4 < kljcembnkni.CDEAAKHGKIF)
						{
							for (int j = this.GMGKODLANOP.Count - 1; j >= 1; j--)
							{
								if (null == this.GMGKODLANOP[j] || this.GMGKODLANOP[j].transform.IsChildOf(gameObject2.transform))
								{
									this.GMGKODLANOP.RemoveAt(j);
								}
							}
							gameObject2.SetActive(false);
							gameObject2.transform.SetParent(null, true);
							UnityEngine.Object.Destroy(gameObject2);
						}
						else
						{
							component2.FEOMAHLMBBB();
							float num5 = component2.LAKNKHEPEOM();
							gameObject2.GetComponent<RectTransform>().ACBKFBBCNNC(num5);
							LayoutRebuilder.ForceRebuildLayoutImmediate(gameObject2.GetComponent<RectTransform>());
							if (kljcembnkni.HPJNLEBDMEP == KLMEAFCEKOI.coverTextClient && kljcembnkni.JAIGAGGAGFE > 1 && num4 != kljcembnkni.JAIGAGGAGFE && kljcembnkni.IHIDEHKNBBH)
							{
								kljcembnkni.JAIGAGGAGFE = num4;
								this.KBDAFKOEDCK(kljcembnkni, out hjejjgafham, out mchooehcanp);
							}
							int cmbcnmlgppc = -1;
							if (kljcembnkni.BLKPIAEAANG)
							{
								cmbcnmlgppc = num4;
							}
							CoverCardItem component4 = gameObject3.GetComponent<CoverCardItem>();
							component4.KOHFANGHNJB(ckbjgcfchga, hjejjgafham, mchooehcanp, cmbcnmlgppc, this.HDBMEAPNFPK(kljcembnkni.OGKIINMNBLH), GKJPOGNFKNK.MIICMJEIPIK(kljcembnkni.AEGIBKHFEOF));
							PIEEFOHHDKO.BGKBLIAAFCK.Add(component4);
							num2 += num5;
							num++;
						}
					}
				}
			}
			component.ACBKFBBCNNC(num2);
			if (num > 0)
			{
				string[] array2 = new string[-85];
				array2[1] = "uid";
				array2[1] = PIEEFOHHDKO.GLOCCAIDHJC.ToString();
				array2[2] = "continue";
				array2[8] = num.ToString();
				array2[1] = "assetbundleprofiledata6";
				array2[6] = PIEEFOHHDKO.CKBJGCFCHGA.ToString();
				array2[2] = "Asset bundle load operation failed during parallel mode.";
				array2[7] = PIEEFOHHDKO.LGIAOIGIGPI.Count.ToString();
				array2[7] = "YYY";
				array2[-73] = num2.ToString();
				DPGJIJGOCIC.CMGOAFDBAOH(string.Concat(array2));
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
		return num;
	}

	// Token: 0x0600224B RID: 8779 RVA: 0x000F2F94 File Offset: 0x000F1194
	private void BKAJMNDHHEN()
	{
		if (ODJKHCHFKNL.JMCDGLKNCNF() != (DFGILFBGPLN)(-71))
		{
			return;
		}
		PassesItem.reopenOnPurchasingScreenLeft = false;
		CommonUserInterface.IKNOFBFMPGA().PJFDODCHHHK().InstantClose();
		this.ALGIAIKDEPH();
	}

	// Token: 0x0600224C RID: 8780 RVA: 0x000F2FBB File Offset: 0x000F11BB
	private void IHBCLCLNFJM()
	{
		base.StartCoroutine(this.EIFAANDLKNB());
	}

	// Token: 0x0600224D RID: 8781 RVA: 0x000F2FCC File Offset: 0x000F11CC
	private void IPFPANDOKKI(AssetAnthologyPreview2 NBKNFJNIDKC)
	{
		this.HFFIIBBJBMH = GKJPOGNFKNK.LDFIAOCJEOJ(NBKNFJNIDKC.index);
		this.JCEPMIFAIIH = AKLFPGMDKLA.EHBBFMCILPC.GJBDBONJCDL(NBKNFJNIDKC.index);
		if (this.JCEPMIFAIIH == null)
		{
			AKLFPGMDKLA.EHBBFMCILPC.GLKNOFHEBKN = this.HFFIIBBJBMH.header.availableStories[0];
			this.MIBPOIDDBAD = 0;
		}
		else if (this.JCEPMIFAIIH.EGHHCFFLPCP(-1) < this.HFFIIBBJBMH.header.availableStories.Count)
		{
			AKLFPGMDKLA.EHBBFMCILPC.GLKNOFHEBKN = this.HFFIIBBJBMH.header.availableStories[this.JCEPMIFAIIH.EGHHCFFLPCP(-1)];
			this.MIBPOIDDBAD = this.JCEPMIFAIIH.EGHHCFFLPCP(-1);
		}
		else
		{
			AKLFPGMDKLA.EHBBFMCILPC.GLKNOFHEBKN = this.HFFIIBBJBMH.header.availableStories[this.HFFIIBBJBMH.header.availableStories.Count - 1];
			this.MIBPOIDDBAD = this.HFFIIBBJBMH.header.availableStories.Count - 1;
		}
		this.JCEPMIFAIIH = AKLFPGMDKLA.EHBBFMCILPC.LMGMHHLLOFN(NBKNFJNIDKC.index);
		this.GKHNIMJJLJL = AKLFPGMDKLA.EHBBFMCILPC.JDCBFAPDJIM(AKLFPGMDKLA.EHBBFMCILPC.GLKNOFHEBKN, -1);
		this.LDIGGOPHGMI = GKJPOGNFKNK.CDCEFHLNNEC(AKLFPGMDKLA.EHBBFMCILPC.GLKNOFHEBKN);
		this.MICMIKNOOEC = this.GKHNIMJJLJL.DHONIOBOLEL.DDEDAHCFHJN();
		SceneLobbyManager2.anthologyIsComplete = false;
		bool flag = false;
		bool flag2 = false;
		if (null != this.HFFIIBBJBMH)
		{
			int i = 0;
			while (i < this.HFFIIBBJBMH.header.availableStories.Count)
			{
				if (this.HFFIIBBJBMH.header.availableStories[i] == AKLFPGMDKLA.EHBBFMCILPC.GLKNOFHEBKN)
				{
					if (i == this.HFFIIBBJBMH.header.availableStories.Count - 1)
					{
						flag = (i == this.HFFIIBBJBMH.header.maxStories - 1);
					}
					else
					{
						flag = (i < AKLFPGMDKLA.EHBBFMCILPC.LMGMHHLLOFN(this.HFFIIBBJBMH.header.index).EGHHCFFLPCP(-1));
					}
					if (i == 0 && this.MICMIKNOOEC == 0)
					{
						flag2 = true;
						break;
					}
					break;
				}
				else
				{
					i++;
				}
			}
		}
		else
		{
			DPGJIJGOCIC.ANOPFDLPKGC("InitStoryChapterInformation() - currentAnthology is null.");
		}
		if (!this.GKHNIMJJLJL.DHONIOBOLEL.LOKHOADFCDF() && this.MICMIKNOOEC < this.LDIGGOPHGMI.chapterAssetPacks.Count)
		{
			this.GKHNIMJJLJL.DHONIOBOLEL.CFGFOEEEJKJ = this.LDIGGOPHGMI.EJPLMFAOJIB(this.MICMIKNOOEC);
		}
		PopupSettingsManager.inkRevision = this.GKHNIMJJLJL.DHONIOBOLEL.CFGFOEEEJKJ;
		bool flag3 = this.CILHBPNJDFA(this.LDIGGOPHGMI, this.MICMIKNOOEC, this.GKHNIMJJLJL.DHONIOBOLEL.CFGFOEEEJKJ, LanguageManager.EHBBFMCILPC.GetSelectedLanguage());
		if (flag2)
		{
			PopupStoryRestartManager.currentChapterAvailableForSelectedLanguage = true;
		}
		else
		{
			PopupStoryRestartManager.currentChapterAvailableForSelectedLanguage = flag3;
		}
		this.teaTextCost.gameObject.SetActive(false);
		this.teaCostSpacing.SetActive(false);
		this.teaImageCost.SetActive(false);
		this.playButton.interactable = true;
		this.playButton.gameObject.GetComponent<CanvasGroup>().alpha = 1f;
		this.playButton.gameObject.GetComponent<HorizontalLayoutGroup>().padding.left = 15;
		this.playButton.gameObject.GetComponent<HorizontalLayoutGroup>().padding.right = 27;
		this.MBCAHEEBBGE = false;
		PurchasingViewManager.activeAnthology = this.HFFIIBBJBMH.header.index;
		PurchasingViewManager.activeStory = this.LDIGGOPHGMI.index;
		if (this.LDIGGOPHGMI.MLGKEPJPICJ(this.MICMIKNOOEC))
		{
			if (!flag)
			{
				this.MBCAHEEBBGE = true;
				this.playButton.gameObject.GetComponent<AnimationButtonFlash>().StopFlashAnimation();
			}
			else
			{
				SceneLobbyManager2.anthologyIsComplete = true;
				this.MBCAHEEBBGE = false;
				this.playButton.interactable = false;
				this.playButton.gameObject.GetComponent<CanvasGroup>().alpha = 0.3f;
				this.playButton.gameObject.GetComponent<AnimationButtonFlash>().StopFlashAnimation();
			}
			if (this.HFFIIBBJBMH.header.maxStories == 1)
			{
				this.textDescription.text = CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("volcompletedesc");
				this.textDescription.SetText(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("volcompletedesc"), true);
			}
			else
			{
				this.textDescription.text = CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("seasoncompletedesc");
				this.textDescription.SetText(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("seasoncompletedesc"), true);
			}
			this.textEpisode.text = CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("seasoncomplete");
			this.textEpisode.SetText(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("seasoncomplete"), true);
		}
		else
		{
			if (this.LDIGGOPHGMI.OAJGLLHCBAB(this.MICMIKNOOEC) || !flag3)
			{
				this.MBCAHEEBBGE = true;
				this.playButton.gameObject.GetComponent<AnimationButtonFlash>().StopFlashAnimation();
			}
			else
			{
				this.playButton.gameObject.GetComponent<AnimationButtonFlash>().RestartFlashAnimation();
			}
			if (!AKLFPGMDKLA.EHBBFMCILPC.GONFHNCEMCA(AKLFPGMDKLA.ACFJMCBMOFG(this.GKHNIMJJLJL.DHONIOBOLEL.GGICIBLJIKI, AKLFPGMDKLA.EHBBFMCILPC.NCOCIAENGJF(this.GKHNIMJJLJL.DHONIOBOLEL.GGICIBLJIKI)), this.MICMIKNOOEC) && !LiveEventsManager.EHBBFMCILPC.LiveEventActive(EGMCEPOABBF.liveEventFreeTea, -1, -1) && !LiveEventsManager.EHBBFMCILPC.LiveEventActive(EGMCEPOABBF.liveEventFreeStory, this.LDIGGOPHGMI.index, -1))
			{
				this.teaTextCost.gameObject.SetActive(true);
				this.teaImageCost.SetActive(true);
				this.teaTextCost.text = "1";
				this.teaTextCost.SetText("1", true);
				this.teaCostSpacing.SetActive(true);
				this.playButton.gameObject.GetComponent<HorizontalLayoutGroup>().padding.left = 12;
				this.playButton.gameObject.GetComponent<HorizontalLayoutGroup>().padding.right = 30;
			}
		}
		if (!this.MBCAHEEBBGE && this.JCEPMIFAIIH != null)
		{
			this.JCEPMIFAIIH.IABDPENJEPM();
		}
	}

	// Token: 0x0600224E RID: 8782 RVA: 0x000F3604 File Offset: 0x000F1804
	private int LINADLBCHJC()
	{
		int num = 0;
		for (int i = 0; i < AssetsManager.EHBBFMCILPC.anthologyAssets.Count; i++)
		{
			if (AKLFPGMDKLA.EHBBFMCILPC.GJBDBONJCDL(AssetsManager.EHBBFMCILPC.anthologyAssets[i].header.index) != null && AssetsManager.EHBBFMCILPC.anthologyAssets[i].header.MLGKEPJPICJ(AKLFPGMDKLA.EHBBFMCILPC.GJBDBONJCDL(AssetsManager.EHBBFMCILPC.anthologyAssets[i].header.index).EGHHCFFLPCP(-1)))
			{
				num++;
			}
		}
		return num;
	}

	// Token: 0x0600224F RID: 8783 RVA: 0x000F36A4 File Offset: 0x000F18A4
	private List<SceneLobbyManager2.BBNDCCPKNJL> LEAJJAFAKLH(int PLKMJJIIJNO)
	{
		List<SceneLobbyManager2.BBNDCCPKNJL> list = null;
		if (this.MHHEBPDIGFB.TryGetValue(PLKMJJIIJNO, out list))
		{
			return list;
		}
		list = new List<SceneLobbyManager2.BBNDCCPKNJL>();
		try
		{
			if (MLIBDDCCKBM.FACIFBONANM() && !KDCJJBLGCBH.EHBBFMCILPC.GNGCDGBAALO())
			{
				if (!MLIBDDCCKBM.KEDEPEDDNJP())
				{
					MLIBDDCCKBM.MAAPBEBFHLJ();
				}
				if (this.NBNKDKCCNKI == null)
				{
					this.NBNKDKCCNKI = this.CLCLLJGGMEF();
				}
				int eenglnknapf = GADABGOBJIM.IJBHNMOOIJF(LanguageManager.EHBBFMCILPC.GetSelectedLanguage());
				IJLJDFKJIJM ijljdfkjijm = HKLPEDKJGFC.BBEPEBHNNGE(PLKMJJIIJNO);
				string b = (ijljdfkjijm == null) ? "" : SceneLobbyManager2.LNDMCMKAFFH(ijljdfkjijm.MGDAFCPCOFH);
				string b2 = (ijljdfkjijm == null) ? "" : SceneLobbyManager2.LNDMCMKAFFH(ijljdfkjijm.HLEHGFIIEJN);
				string b3 = (ijljdfkjijm == null) ? "" : SceneLobbyManager2.LNDMCMKAFFH(ijljdfkjijm.BFJKEJLJAIH);
				MLIBDDCCKBM.DCJGMAOFJID(PLKMJJIIJNO, this.ABFFODCEIHO);
				for (int i = 0; i < this.ABFFODCEIHO.Count; i++)
				{
					int onfoahiakjf = this.ABFFODCEIHO[i];
					int num = MLIBDDCCKBM.KBNBLLJIPIJ(onfoahiakjf);
					if ((4 == num || 5 == num) && !MLIBDDCCKBM.KDKNDGHKABE(onfoahiakjf) && MLIBDDCCKBM.PEAABLAKMLG(onfoahiakjf) > 0 && !MLIBDDCCKBM.BBIJHBHHGFB(onfoahiakjf) && !MLIBDDCCKBM.JAGLHPDCEGF(onfoahiakjf))
					{
						string text = MLIBDDCCKBM.LCNMONKLPIG(onfoahiakjf);
						if (text == null)
						{
							text = "";
						}
						if (!("genre_lgbtq" == text))
						{
							SceneLobbyManager2.BBNDCCPKNJL bbndccpknjl = new SceneLobbyManager2.BBNDCCPKNJL();
							if (5 == num)
							{
								string a = text.StartsWith("genre_") ? text.Substring("genre_".Length) : text;
								bbndccpknjl.DCMKIKIHACO = true;
								bbndccpknjl.OKJNEMPGHDJ = true;
								bbndccpknjl.AGMOECJFFJI = ((a == b) ? 100f : ((a == b2) ? 90f : ((a == b3) ? 80f : 70f)));
							}
							else
							{
								float num2 = (float)MLIBDDCCKBM.PEAABLAKMLG(onfoahiakjf);
								string b4 = MLIBDDCCKBM.DIFPDJMGECC(onfoahiakjf);
								if ("author" == b4 || "lgbtq" == b4)
								{
									goto IL_335;
								}
								if ("creature" == b4)
								{
									bbndccpknjl.DCMKIKIHACO = true;
									bbndccpknjl.AGMOECJFFJI = num2 + 10f;
								}
								else if ("trope" == b4)
								{
									bbndccpknjl.DCMKIKIHACO = true;
									bbndccpknjl.FJNECDBGMOK = true;
									bbndccpknjl.AGMOECJFFJI = num2;
								}
								else if ("place" == b4 || "era" == b4)
								{
									bbndccpknjl.FJNECDBGMOK = true;
									bbndccpknjl.AGMOECJFFJI = num2 + 10f;
								}
								else if ("role" == b4)
								{
									bbndccpknjl.FJNECDBGMOK = true;
									bbndccpknjl.AGMOECJFFJI = num2 - 10f;
								}
								else
								{
									bbndccpknjl.FJNECDBGMOK = true;
									bbndccpknjl.AGMOECJFFJI = num2 - 15f;
								}
							}
							string text2 = MLIBDDCCKBM.GJJKGNLNNDG(onfoahiakjf, eenglnknapf);
							if (text2 != null && text2.Length != 0 && text2.Length <= 26)
							{
								bbndccpknjl.IEIAICGOENJ = this.GDAPJCHEDOK(text2);
								bool flag = false;
								for (int j = 0; j < list.Count; j++)
								{
									if (string.Equals(list[j].IEIAICGOENJ, bbndccpknjl.IEIAICGOENJ, StringComparison.OrdinalIgnoreCase))
									{
										flag = true;
										break;
									}
								}
								if (!flag)
								{
									list.Add(bbndccpknjl);
								}
							}
						}
					}
					IL_335:;
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
		if (MLIBDDCCKBM.FACIFBONANM() || KDCJJBLGCBH.EHBBFMCILPC.GNGCDGBAALO())
		{
			this.MHHEBPDIGFB[PLKMJJIIJNO] = list;
		}
		return list;
	}

	// Token: 0x06002250 RID: 8784 RVA: 0x000F3A44 File Offset: 0x000F1C44
	private void JBLNEPHFINA()
	{
		AssetsManager.EHBBFMCILPC.NADFIDNMKFK();
		if (SceneLobbyManager2.showNewSeasonUnlocked)
		{
			SceneLobbyManager2.showNewSeasonUnlocked = false;
			CommonUserInterface.IKNOFBFMPGA().ShowGenericPopupOneOverride(CCOJBMMKNAP.PLJMLDOCPNM().HIPJILDCHJC("YYY"), CCOJBMMKNAP.DBFFFOMCLKM().OGKGHLHHAAI("frsendhres2"), CCOJBMMKNAP.FEEDGKCJBLE().PGKBCNBAOJN("strtd"), new UnityAction(this.OnNewSeasonMessageClose), (DFGILFBGPLN)127, 1942f, 47);
			return;
		}
		if (SceneLobbyManager2.showAnthologyComplete)
		{
			if (SceneLobbyManager2.showAnthologyCompleteSpecialEpisode)
			{
				CommonUserInterface.IKNOFBFMPGA().ShowGenericPopup(CCOJBMMKNAP.FEEDGKCJBLE().JCDFHKDNEDH("swgdh"), CCOJBMMKNAP.GIOAFDDKKHI().HPOAGPJFHPM("socialgiftcollectinfodone2"), CCOJBMMKNAP.PKEINLPIAEH().PKNHKGMNCIP("usyncoll2"), (DFGILFBGPLN)(-106), 371f, 105);
			}
			else
			{
				CommonUserInterface.EHBBFMCILPC.NFBMHHPIGFA(CCOJBMMKNAP.NIOJNOFGIJO().JLBEIFLLBLO("C"), CCOJBMMKNAP.EHBBFMCILPC.HIPJILDCHJC("storiesSearchStopwords"), CCOJBMMKNAP.DLGLFACMHPG().GLEFEKBDHNK("rar"), (DFGILFBGPLN)(-124), 932f, -55);
			}
			SceneLobbyManager2.showAnthologyComplete = false;
			SceneLobbyManager2.showAnthologyCompleteSpecialEpisode = false;
			return;
		}
		GDOKLFCLLIK gdoklfcllik = DNPIKPDMKKI.MIMCONEEPNJ("sparklesbundles", false);
		if (gdoklfcllik != null)
		{
			CommonUserInterface.EHBBFMCILPC.AOLMLLCPJEG().Show(gdoklfcllik);
			return;
		}
		if (SceneStoryManager.anyChapterCompleted)
		{
			CommonUserInterface.IKNOFBFMPGA().FreezeUX();
			base.Invoke("passhintchoices", 1413f);
		}
	}

	// Token: 0x06002251 RID: 8785 RVA: 0x000F3B99 File Offset: 0x000F1D99
	private IEnumerator JKGIIGPDMLF()
	{
		AssetsManager.EHBBFMCILPC.InitializeAssetBundleFolder((LNDOOJOFFOM)this.BMODBEEEABE.FJFEPNKBELL, "OnCutsceneViewLobbyAssetBundleFolderInitializeSuccess", "OnCutsceneViewLobbyAssetsDownloadFailed");
		yield return null;
		yield break;
	}

	// Token: 0x06002252 RID: 8786 RVA: 0x000F3BA8 File Offset: 0x000F1DA8
	private void JLFGANHMMOM()
	{
		try
		{
			if (null != this.footerRewardsGemPill)
			{
				this.footerRewardsGemPill.SetActive(KHPGPLAMAIN.NGPOHAPMMAI());
			}
			if (null != this.footerRewardsGemPillText)
			{
				this.footerRewardsGemPillText.SetText(this.GetIncentAdRewardText(), true);
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x06002253 RID: 8787 RVA: 0x000F3C0C File Offset: 0x000F1E0C
	private void ODOPEGPBCCD()
	{
		for (int i = 0; i < this.canvases.Count; i++)
		{
			this.canvases[i].enabled = true;
		}
	}

	// Token: 0x06002254 RID: 8788 RVA: 0x000F3C44 File Offset: 0x000F1E44
	private List<int> DGPAFDKHLJL(JBBNEEHANHL HBBJBNJBMPK)
	{
		List<int> list = new List<int>();
		List<AssetAnthology> list2 = new List<AssetAnthology>();
		List<AssetAnthology> list3 = new List<AssetAnthology>();
		List<AssetAnthology> list4 = new List<AssetAnthology>();
		List<AssetAnthology> list5 = new List<AssetAnthology>();
		List<AssetAnthology> list6 = new List<AssetAnthology>();
		for (int i = 0; i < this.PMFMEBGNCME.Length; i++)
		{
			this.PMFMEBGNCME[i] = this.HKJCANHMEED[i];
		}
		if (HBBJBNJBMPK != JBBNEEHANHL.filterTopRated && HBBJBNJBMPK != JBBNEEHANHL.filterMostPopular && HBBJBNJBMPK != JBBNEEHANHL.filterSearch)
		{
			foreach (AssetAnthology assetAnthology in AssetsManager.EHBBFMCILPC.anthologyAssets)
			{
				if (this.PMFMEBGNCME[assetAnthology.header.index] == NDHKFLHAFNA.hintCompleted)
				{
					list2.Add(assetAnthology);
				}
				else if (this.PMFMEBGNCME[assetAnthology.header.index] == NDHKFLHAFNA.hintInDevelopment || this.PMFMEBGNCME[assetAnthology.header.index] == NDHKFLHAFNA.hintOnHiatus || this.PMFMEBGNCME[assetAnthology.header.index] == NDHKFLHAFNA.hintDiscontinued)
				{
					list3.Add(assetAnthology);
				}
				else if (this.CBBNGDBFDPO[assetAnthology.header.index] == NDHKFLHAFNA.hintNewStory)
				{
					list4.Add(assetAnthology);
				}
				else
				{
					list6.Add(assetAnthology);
				}
			}
			list2 = list2.OrderByDescending(new Func<AssetAnthology, int>(SceneLobbyManager2.<>c.<>9.DOBBGLEPHOC)).ToList<AssetAnthology>();
			list3 = list3.OrderByDescending(new Func<AssetAnthology, int>(SceneLobbyManager2.<>c.<>9.IJBLKCLBOOG)).ToList<AssetAnthology>();
			list6 = list6.OrderByDescending(new Func<AssetAnthology, int>(SceneLobbyManager2.<>c.<>9.NDGIMENFPEJ)).ToList<AssetAnthology>();
			list4 = list4.OrderByDescending(new Func<AssetAnthology, int>(SceneLobbyManager2.<>c.<>9.GIKHEJNEGKL)).ToList<AssetAnthology>();
			list5.AddRange(list4);
			list5.AddRange(list6);
			list5.AddRange(list3);
			list5.AddRange(list2);
		}
		else if (HBBJBNJBMPK == JBBNEEHANHL.filterTopRated)
		{
			List<int> list7 = AKLFPGMDKLA.EHBBFMCILPC.JPANCNNAEEJ();
			for (int j = 0; j < list7.Count; j++)
			{
				foreach (AssetAnthology assetAnthology2 in AssetsManager.EHBBFMCILPC.anthologyAssets)
				{
					if (list7[j] == assetAnthology2.header.index && this.CBBNGDBFDPO[assetAnthology2.header.index] != NDHKFLHAFNA.hintNewStory)
					{
						list5.Add(assetAnthology2);
						if (this.PMFMEBGNCME[list7[j]] == NDHKFLHAFNA.hintCompleted)
						{
							this.PMFMEBGNCME[list7[j]] = NDHKFLHAFNA.hintPlayAgain;
							break;
						}
						if (this.PMFMEBGNCME[list7[j]] == NDHKFLHAFNA.hintContinuePlaying)
						{
							this.PMFMEBGNCME[list7[j]] = NDHKFLHAFNA.hintTryAgain;
							break;
						}
						if (this.PMFMEBGNCME[list7[j]] != NDHKFLHAFNA.hintInDevelopment && this.PMFMEBGNCME[list7[j]] != NDHKFLHAFNA.hintOnHiatus && this.PMFMEBGNCME[list7[j]] != NDHKFLHAFNA.hintDiscontinued)
						{
							this.PMFMEBGNCME[list7[j]] = NDHKFLHAFNA.hintSuggested;
							break;
						}
						break;
					}
				}
				if ((NBDLBFJOEGN.IEGBGGMAOLD() && list5.Count >= 21) || (!NBDLBFJOEGN.IEGBGGMAOLD() && list5.Count >= 20))
				{
					break;
				}
			}
		}
		else if (HBBJBNJBMPK == JBBNEEHANHL.filterMostPopular)
		{
			for (int k = 0; k < PLBBPHIJMAH.FGCMPALLMCD.Count; k++)
			{
				if (k >= PLBBPHIJMAH.IFHJAFDPBKD)
				{
					break;
				}
				foreach (AssetAnthology assetAnthology3 in AssetsManager.EHBBFMCILPC.anthologyAssets)
				{
					if (assetAnthology3.header.index == PLBBPHIJMAH.FGCMPALLMCD[k].AMKCLHLIIMN)
					{
						list5.Add(assetAnthology3);
					}
				}
			}
		}
		else if (JBBNEEHANHL.filterSearch == HBBJBNJBMPK)
		{
			for (int l = 0; l < this.BPCHEOFFPCN.Count; l++)
			{
				int plkmjjiijno = this.BPCHEOFFPCN[l];
				AssetAnthology assetAnthology4 = GKJPOGNFKNK.LDFIAOCJEOJ(plkmjjiijno);
				if (null == assetAnthology4)
				{
					DPGJIJGOCIC.ADFCDFHBDAF("SceneLobbyManager2.CollectFilteredAinds() - search result " + plkmjjiijno.ToString() + " is not a loaded anthology, skipping");
				}
				else
				{
					list5.Add(assetAnthology4);
				}
			}
		}
		List<int> list8 = AKLFPGMDKLA.EHBBFMCILPC.JCBEPJJHAII(AssetsManager.EHBBFMCILPC.anthologyAssets);
		foreach (AssetAnthology assetAnthology5 in list5)
		{
			IJLJDFKJIJM ijljdfkjijm = HKLPEDKJGFC.BBEPEBHNNGE(assetAnthology5.header.index);
			if (ijljdfkjijm != null)
			{
				if (ijljdfkjijm.MGDAFCPCOFH == HBBJBNJBMPK)
				{
					this.EFCMNDMKNLD(list, assetAnthology5.header.index);
				}
				if (ijljdfkjijm.HLEHGFIIEJN == HBBJBNJBMPK)
				{
					this.EFCMNDMKNLD(list, assetAnthology5.header.index);
				}
				if (ijljdfkjijm.BFJKEJLJAIH == HBBJBNJBMPK)
				{
					this.EFCMNDMKNLD(list, assetAnthology5.header.index);
				}
				if (ijljdfkjijm.MBIDFCCNCKL == HBBJBNJBMPK)
				{
					this.EFCMNDMKNLD(list, assetAnthology5.header.index);
				}
				if (ijljdfkjijm.KGFKAIBMGOP == HBBJBNJBMPK)
				{
					this.EFCMNDMKNLD(list, assetAnthology5.header.index);
				}
			}
			if (JBBNEEHANHL.filterTopRated == HBBJBNJBMPK || JBBNEEHANHL.filterSearch == HBBJBNJBMPK)
			{
				this.EFCMNDMKNLD(list, assetAnthology5.header.index);
			}
			if (HBBJBNJBMPK == JBBNEEHANHL.filterMostPopular && PLBBPHIJMAH.OIMFAKMKLNL(assetAnthology5.header.index))
			{
				this.EFCMNDMKNLD(list, assetAnthology5.header.index);
			}
			if (HBBJBNJBMPK == JBBNEEHANHL.filterContinuePlaying && this.JDFKLJAIHLH[assetAnthology5.header.index] > 0 && this.JDFKLJAIHLH[assetAnthology5.header.index] < 100)
			{
				this.EFCMNDMKNLD(list, assetAnthology5.header.index);
			}
			if (HBBJBNJBMPK == JBBNEEHANHL.filterCompleted && AKLFPGMDKLA.EHBBFMCILPC.GJBDBONJCDL(assetAnthology5.header.index) != null && assetAnthology5.header.MLGKEPJPICJ(AKLFPGMDKLA.EHBBFMCILPC.GJBDBONJCDL(assetAnthology5.header.index).EGHHCFFLPCP(-1)))
			{
				this.EFCMNDMKNLD(list, assetAnthology5.header.index);
			}
			if (HBBJBNJBMPK == JBBNEEHANHL.filterFavorites && list8.Contains(assetAnthology5.header.index))
			{
				this.EFCMNDMKNLD(list, assetAnthology5.header.index);
			}
		}
		return list;
	}

	// Token: 0x06002255 RID: 8789 RVA: 0x000F4334 File Offset: 0x000F2534
	private void JGGBJJJCFFD()
	{
		if (null != this.LGKGGPDKAHF)
		{
			try
			{
				this.UpdateAnthologiesHints();
			}
			catch (Exception aklgbjkdomm)
			{
				DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
			}
			AKLFPGMDKLA.EHBBFMCILPC.LPCBDEBKAIM();
			CommonUserInterface.EHBBFMCILPC.ShowConnectingAnimationWithHint(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("serversync"), 96);
			BackendOperationsManager.EHBBFMCILPC.QueueRequestSaveChapterSnapshots();
			BackendOperationsManager.EHBBFMCILPC.QueueRequestSaveAvatarCollections();
			BackendOperationsManager.EHBBFMCILPC.RequestSaveSync("OnSaveSyncAnyResult", "OnSaveSyncAnyResult");
			SaveSlotsItem.slotDeleted = false;
			SaveSlotsItem.slotEdited = false;
			SaveSlotsItem.slotChanged = false;
			SaveSlotsItem.slotDuplicated = false;
		}
	}

	// Token: 0x06002256 RID: 8790 RVA: 0x000F43D4 File Offset: 0x000F25D4
	private string DCPEGOONIJM(int PLKMJJIIJNO, List<string> EDHHEEIPNCP)
	{
		EDHHEEIPNCP.Clear();
		List<SceneLobbyManager2.BBNDCCPKNJL> list = this.LEAJJAFAKLH(PLKMJJIIJNO);
		if (list == null || list.Count == 0)
		{
			return null;
		}
		SceneLobbyManager2.NBBJMAPHBNP(list, true, null, this.NOMLNLBOOKD);
		SceneLobbyManager2.BBNDCCPKNJL bbndccpknjl = SceneLobbyManager2.JAGPHAPKGDF(this.NOMLNLBOOKD, 0);
		if (bbndccpknjl == null)
		{
			SceneLobbyManager2.NBBJMAPHBNP(list, false, null, this.AILKPKDEIKO);
			bbndccpknjl = SceneLobbyManager2.JAGPHAPKGDF(this.AILKPKDEIKO, 0);
		}
		if (bbndccpknjl == null)
		{
			return null;
		}
		SceneLobbyManager2.NBBJMAPHBNP(list, false, bbndccpknjl.IEIAICGOENJ, this.AILKPKDEIKO);
		SceneLobbyManager2.BBNDCCPKNJL bbndccpknjl2 = SceneLobbyManager2.JAGPHAPKGDF(this.AILKPKDEIKO, 0);
		if (bbndccpknjl2 != null)
		{
			EDHHEEIPNCP.Add(bbndccpknjl2.IEIAICGOENJ);
		}
		int num = 0;
		while (num < this.AILKPKDEIKO.Count && EDHHEEIPNCP.Count < 4)
		{
			if (!EDHHEEIPNCP.Contains(this.AILKPKDEIKO[num].IEIAICGOENJ))
			{
				EDHHEEIPNCP.Add(this.AILKPKDEIKO[num].IEIAICGOENJ);
			}
			num++;
		}
		SceneLobbyManager2.NBBJMAPHBNP(list, true, bbndccpknjl.IEIAICGOENJ, this.NOMLNLBOOKD);
		int num2 = 0;
		while (num2 < this.NOMLNLBOOKD.Count && EDHHEEIPNCP.Count < 6)
		{
			if ((!bbndccpknjl.OKJNEMPGHDJ || !this.NOMLNLBOOKD[num2].OKJNEMPGHDJ) && !EDHHEEIPNCP.Contains(this.NOMLNLBOOKD[num2].IEIAICGOENJ))
			{
				EDHHEEIPNCP.Add(this.NOMLNLBOOKD[num2].IEIAICGOENJ);
			}
			num2++;
		}
		return bbndccpknjl.IEIAICGOENJ;
	}

	// Token: 0x06002257 RID: 8791 RVA: 0x000F4544 File Offset: 0x000F2744
	private void FNGNDLPNNBH()
	{
		AssetsManager.EHBBFMCILPC.UnloadPersistentAssetBundles();
		if (SceneLobbyManager2.showNewSeasonUnlocked)
		{
			SceneLobbyManager2.showNewSeasonUnlocked = false;
			CommonUserInterface.EHBBFMCILPC.ShowGenericPopupOneOverride(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("newseasontitle"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("newseasonawaits"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("ok"), new UnityAction(this.OnNewSeasonMessageClose), DFGILFBGPLN.popupSeasonComplete, 1f, 28);
			return;
		}
		if (SceneLobbyManager2.showAnthologyComplete)
		{
			if (SceneLobbyManager2.showAnthologyCompleteSpecialEpisode)
			{
				CommonUserInterface.EHBBFMCILPC.ShowGenericPopup(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("anthologycompletetitle"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("anthologycompletespecialepisode"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("ok"), DFGILFBGPLN.popupSeasonComplete, 1f, 28);
			}
			else
			{
				CommonUserInterface.EHBBFMCILPC.ShowGenericPopup(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("anthologycompletetitle"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("anthologycomplete"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("ok"), DFGILFBGPLN.popupSeasonComplete, 1f, 28);
			}
			SceneLobbyManager2.showAnthologyComplete = false;
			SceneLobbyManager2.showAnthologyCompleteSpecialEpisode = false;
			return;
		}
		GDOKLFCLLIK gdoklfcllik = DNPIKPDMKKI.GLLDFBGBLCM("lobby", true);
		if (gdoklfcllik != null)
		{
			CommonUserInterface.EHBBFMCILPC.GetFullscreenLiveOffer().Show(gdoklfcllik);
			return;
		}
		if (SceneStoryManager.anyChapterCompleted)
		{
			CommonUserInterface.EHBBFMCILPC.FreezeUX();
			base.Invoke("KBNJAFKIGHD", 1f);
		}
	}

	// Token: 0x06002258 RID: 8792 RVA: 0x000F4699 File Offset: 0x000F2899
	private IEnumerator GLBNDFFMKFB()
	{
		yield return new WaitForSeconds(0.5f);
		this.OnPopupCardOptionsReopen();
		yield break;
	}

	// Token: 0x06002259 RID: 8793 RVA: 0x000F46A8 File Offset: 0x000F28A8
	[CompilerGenerated]
	private void JMCDFDBADMC(JBBNEEHANHL AJLPALFJHCC)
	{
		this.BCOOKJICILK(AJLPALFJHCC);
	}

	// Token: 0x0600225A RID: 8794 RVA: 0x000F46B1 File Offset: 0x000F28B1
	public void OnSocialModeChanged()
	{
		this.ShowHideSocialFeatures();
	}

	// Token: 0x0600225B RID: 8795 RVA: 0x000F46BC File Offset: 0x000F28BC
	private KLJCEMBNKNI AGFJMDBMKBN(string LBIHODEIDEG, int HHKIAICFCKC, int ENONNLDGGIN, int CNGAINAIGBB, string GOJOGDKCNMO, string EKFAEKCLJKP, JBBNEEHANHL HFHAAEOGCNB, List<int> NANPCEFKHMH)
	{
		return new KLJCEMBNKNI
		{
			HPJNLEBDMEP = KLMEAFCEKOI.coverTextClient,
			MHCFDMNGOEF = LBIHODEIDEG,
			JAIGAGGAGFE = HHKIAICFCKC,
			KFIIKPJIBFA = ENONNLDGGIN,
			LDMPKCEGKLJ = CNGAINAIGBB,
			JMJCHPPNJHB = GOJOGDKCNMO,
			AEGIBKHFEOF = EKFAEKCLJKP,
			OGKIINMNBLH = HFHAAEOGCNB,
			BLKPIAEAANG = false,
			CDEAAKHGKIF = 1,
			FKBCEMFCBOG = false,
			JAPFMDOBPKJ = new List<int>(NANPCEFKHMH)
		};
	}

	// Token: 0x0600225C RID: 8796 RVA: 0x000F472C File Offset: 0x000F292C
	private void IAPJENPEBLG()
	{
		for (int i = 0; i < this.wheelItem.GetComponent<WheelItem>().lobbyCanvases.Count; i++)
		{
			this.wheelItem.GetComponent<WheelItem>().lobbyCanvases[i].enabled = true;
		}
	}

	// Token: 0x0600225D RID: 8797 RVA: 0x000F4775 File Offset: 0x000F2975
	private void MBEIIFKJEKD()
	{
		if (this.backgroundJobIndicator.activeSelf)
		{
			this.backgroundJobIndicator.SetActive(false);
		}
		base.StartCoroutine(this.HHHIHFAICPC());
	}

	// Token: 0x0600225E RID: 8798 RVA: 0x000F479D File Offset: 0x000F299D
	private void BIMLEBJFIJJ()
	{
		AccountSignInManager.EHBBFMCILPC.StartSignInLogic(HHCKLPJJKIJ.facebook, JCAPGCCNOMP.auto, HHCKLPJJKIJ.none, 0);
	}

	// Token: 0x0600225F RID: 8799 RVA: 0x000F47AD File Offset: 0x000F29AD
	private IEnumerator IGDDHKJKIME()
	{
		AssetsManager.EHBBFMCILPC.GetLoadingProgressSnapshot().EPJKDCDOEMM(0);
		CommonUserInterface.EHBBFMCILPC.ShowConnectingAnimationWithProgress(96);
		yield return new WaitForEndOfFrame();
		while (AssetsManager.EHBBFMCILPC.IsBusy())
		{
			DPGJIJGOCIC.NFIDPOMCNLP("SceneLobbyManager2.OpenSketchesCdn(): AssetsManager.Instance.IsBusy()");
			yield return new WaitForSeconds(0.05f);
		}
		AssetsManager.EHBBFMCILPC.QueueAssetBundleDownload(NMKDCBPMCKI.AssetBundleSketchesData, 0, -1, FLDBFOADFLH.startDownloadAndProceed, false, false, false, null, -1, false, "", false, false);
		List<int> list = FANFNBCJJDA.EHBBFMCILPC.LPJJGMLEHHH(AppManager.EHBBFMCILPC.GetRevision());
		for (int i = 0; i < list.Count; i++)
		{
			AssetsManager.EHBBFMCILPC.QueueAssetBundleDownload(NMKDCBPMCKI.AssetBundleSketchThumbnail, list[i], -1, FLDBFOADFLH.startDownloadAndProceed, false, false, false, null, -1, false, "", this.DELEBCMPCEO(), false);
			AssetsManager.EHBBFMCILPC.QueueAssetBundleDownload(NMKDCBPMCKI.AssetBundleSketchActors, list[i], -1, FLDBFOADFLH.startDownloadAndProceed, false, false, false, null, -1, false, "", false, false);
		}
		AssetsManager.EHBBFMCILPC.GetLoadingProgressSnapshot().CLIOEOLFFLO(LEJKDNAGDHC.Fast);
		AssetsManager.EHBBFMCILPC.GetLoadingProgressSnapshot().GIJKJMMDJEL(0f, 1f);
		AssetsManager.EHBBFMCILPC.DownloadQueuedAssetBundles("OnSketchThumbnailsCdnSuccess", "OnSketchThumbnailsCdnFailed", false);
		yield break;
	}

	// Token: 0x06002260 RID: 8800 RVA: 0x000F47BC File Offset: 0x000F29BC
	private IEnumerator MDBIBFJMFEL()
	{
		if (null != AssetsManager.EHBBFMCILPC.profileDataAsset5)
		{
			CommonUserInterface.EHBBFMCILPC.ShowSkinShop(-1);
			yield break;
		}
		this.GBBHKFFENBE = true;
		AssetsManager.EHBBFMCILPC.GetLoadingProgressSnapshot().EPJKDCDOEMM(0);
		CommonUserInterface.EHBBFMCILPC.ShowConnectingAnimationWithProgress(96);
		yield return new WaitForEndOfFrame();
		while (AssetsManager.EHBBFMCILPC.IsBusy())
		{
			yield return new WaitForSeconds(0.05f);
		}
		AssetsManager.EHBBFMCILPC.QueueAssetBundleDownload(NMKDCBPMCKI.AssetBundleProfileData5, 0, -1, FLDBFOADFLH.startDownloadAndProceed, false, false, false, null, -1, false, "", false, false);
		AssetsManager.EHBBFMCILPC.GetLoadingProgressSnapshot().CLIOEOLFFLO(LEJKDNAGDHC.Fast);
		AssetsManager.EHBBFMCILPC.GetLoadingProgressSnapshot().GIJKJMMDJEL(0f, 1f);
		AssetsManager.EHBBFMCILPC.DownloadQueuedAssetBundles("OnLobbySkinShopCdnSuccess", "OnLobbySkinShopCdnFailed", false);
		yield break;
	}

	// Token: 0x06002261 RID: 8801 RVA: 0x000F47CB File Offset: 0x000F29CB
	private void JEPHPIMHGJD()
	{
		CommonUserInterface.EHBBFMCILPC.ShowConnectingAnimation(96);
		BackendOperationsManager.EHBBFMCILPC.RequestGetIncentAdReward(SceneLobbyManager2.incentAdResultRewardType, 0, "OnBackendGetIncentRewardAdSuccess", "OnBackendGetIncentRewardAdException");
	}

	// Token: 0x06002262 RID: 8802 RVA: 0x000F47F4 File Offset: 0x000F29F4
	public void OnAvatarClickPart2()
	{
		AOBJLALDBAA.EHBBFMCILPC.EGELHPJBAIC("OnNeedToDeactivateFocusItemCloseButton", 0f);
		this.OKKBOFKILEA();
		this.ALGIAIKDEPH();
		for (int i = 0; i < this.lobbyParticles.Count; i++)
		{
			if (null != this.lobbyParticles[i])
			{
				this.lobbyParticles[i].Clear();
				this.lobbyParticles[i].gameObject.SetActive(false);
			}
		}
		AssetsManager.EHBBFMCILPC.GetSceneAvatarManager(0).Show(null, null, null, null, null, true, false, true, false);
	}

	// Token: 0x06002263 RID: 8803 RVA: 0x000F488C File Offset: 0x000F2A8C
	private bool AMHFDOEDOOE()
	{
		bool result;
		try
		{
			if (null == AssetsManager.EHBBFMCILPC || null == AssetsManager.EHBBFMCILPC.lobbyDataAsset)
			{
				result = false;
			}
			else if (!AssetsManager.EHBBFMCILPC.lobbyDataAsset.HFHBDPDGEGJ())
			{
				result = false;
			}
			else if (!AssetsManager.EHBBFMCILPC.lobbyDataAsset.DKIPBODMOHM(LanguageManager.EHBBFMCILPC.GetSelectedLanguage()))
			{
				result = false;
			}
			else
			{
				List<POKPDFKMOFC> list = this.BELBLACNAEM();
				if (list == null || list.Count == 0)
				{
					result = false;
				}
				else
				{
					EAFPOMNMOFP eafpomnmofp = AssetsManager.EHBBFMCILPC.lobbyDataAsset.JDMCDEKHDHM();
					CEIBHCNNIDC selectedLanguage = LanguageManager.EHBBFMCILPC.GetSelectedLanguage();
					for (int i = 0; i < list.Count; i++)
					{
						string text = eafpomnmofp.CFBKLIEBLOF(list[i].IEJLOIMDPDO, selectedLanguage);
						if (text != null && text.Length > 0)
						{
							return true;
						}
					}
					DPGJIJGOCIC.ADFCDFHBDAF("SceneLobbyManager2.ExploreTabAvailable() - no planned concept has a name in the text pack explore tab (older text pack bundle?), tab hidden");
					result = false;
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
			result = false;
		}
		return result;
	}

	// Token: 0x06002264 RID: 8804 RVA: 0x000F4990 File Offset: 0x000F2B90
	private NDHKFLHAFNA OBJKELOHJDH(int PLKMJJIIJNO)
	{
		NDHKFLHAFNA ndhkflhafna = this.PMFMEBGNCME[PLKMJJIIJNO];
		if (this.EEGHJFAIMBF.Contains(PLKMJJIIJNO))
		{
			if (NDHKFLHAFNA.hintInDevelopment != ndhkflhafna && NDHKFLHAFNA.hintOnHiatus != ndhkflhafna && NDHKFLHAFNA.hintDiscontinued != ndhkflhafna)
			{
				ndhkflhafna = NDHKFLHAFNA.hintSuggested;
			}
			return ndhkflhafna;
		}
		return ndhkflhafna;
	}

	// Token: 0x06002265 RID: 8805 RVA: 0x000F49C7 File Offset: 0x000F2BC7
	private IEnumerator NLCIHPDMECL(RectTransform FMJNOIIKHLM, ScrollRect CDENMGEDLBN, float KIJAHFBGGOB)
	{
		float startYTemp = FMJNOIIKHLM.anchoredPosition.y;
		float writtenYTemp = startYTemp;
		float elapsedTemp = 0f;
		while (elapsedTemp < 0.25f)
		{
			if (null == FMJNOIIKHLM || null == CDENMGEDLBN)
			{
				yield break;
			}
			if (Mathf.Abs(FMJNOIIKHLM.anchoredPosition.y - writtenYTemp) > 0.5f)
			{
				this.HOPLLEOGDEK = null;
				yield break;
			}
			elapsedTemp += Mathf.Min(Time.unscaledDeltaTime, 0.033333335f);
			float t = Mathf.SmoothStep(0f, 1f, Mathf.Clamp01(elapsedTemp / 0.25f));
			CDENMGEDLBN.velocity = Vector2.zero;
			writtenYTemp = Mathf.Lerp(startYTemp, KIJAHFBGGOB, t);
			FMJNOIIKHLM.anchoredPosition = new Vector2(FMJNOIIKHLM.anchoredPosition.x, writtenYTemp);
			yield return null;
		}
		if (null != FMJNOIIKHLM && Mathf.Abs(FMJNOIIKHLM.anchoredPosition.y - writtenYTemp) <= 0.5f)
		{
			FMJNOIIKHLM.anchoredPosition = new Vector2(FMJNOIIKHLM.anchoredPosition.x, KIJAHFBGGOB);
		}
		this.HOPLLEOGDEK = null;
		yield break;
	}

	// Token: 0x06002266 RID: 8806 RVA: 0x000F49EC File Offset: 0x000F2BEC
	private bool FDMGKEAHGFK()
	{
		if (null == this.FIBKHPMLNJN)
		{
			return false;
		}
		FilterItem component = this.FIBKHPMLNJN.GetComponent<FilterItem>();
		return this.FIBKHPMLNJN.activeSelf && null != component && null != component.toggle && component.toggle.isOn;
	}

	// Token: 0x06002267 RID: 8807 RVA: 0x000F4A46 File Offset: 0x000F2C46
	private IEnumerator DMAFLGMFILA()
	{
		yield return new WaitForSeconds(1f);
		string text = CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("saveslotsswitchdone");
		string text2 = AKLFPGMDKLA.EHBBFMCILPC.LMGMHHLLOFN(this.LGKGGPDKAHF.index).BFCBDALFNHA(-1);
		if (text2.Length == 0)
		{
			text2 = (AKLFPGMDKLA.EHBBFMCILPC.LMGMHHLLOFN(this.LGKGGPDKAHF.index).ILOKBAPEJPK + 1).ToString();
		}
		text = text.Replace("XXX", text2);
		CommonUserInterface.EHBBFMCILPC.ShowGenericPopup(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("importanttitle"), text, CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("ok"), DFGILFBGPLN.popupEnergyHint, 0f, 28);
		CommonUserInterface.EHBBFMCILPC.ResumeUX();
		AssetsManager.EHBBFMCILPC.DestroyAssetBundleAssets(NMKDCBPMCKI.AssetBundleCollectableCard, -1);
		yield break;
	}

	// Token: 0x06002268 RID: 8808 RVA: 0x000F4A55 File Offset: 0x000F2C55
	private void FMJMDIEKHCH()
	{
		base.StartCoroutine(this.CPKEKFFODHH());
	}

	// Token: 0x06002269 RID: 8809 RVA: 0x000F4A64 File Offset: 0x000F2C64
	private void EFJGLLPDJKO()
	{
		if (this.KOGLEPFNALN && this.MJOMHIEMKMK != null && this.MJOMHIEMKMK.Length > 0)
		{
			SceneLobbyManager2.KAFNANCDMNF = this.MJOMHIEMKMK;
		}
	}

	// Token: 0x0600226A RID: 8810 RVA: 0x000F4A8F File Offset: 0x000F2C8F
	private void DJDBKHPCDKM()
	{
		base.StartCoroutine(this.BBFOGBLKJCF());
	}

	// Token: 0x0600226B RID: 8811 RVA: 0x000F4AA0 File Offset: 0x000F2CA0
	private void AOOIJKNMGEF()
	{
		for (int i = 1; i < this.cameras.Count; i += 0)
		{
			this.cameras[i].enabled = false;
		}
	}

	// Token: 0x0600226C RID: 8812 RVA: 0x000F4AD8 File Offset: 0x000F2CD8
	private void LKGINKICMLH(bool AMDHFNLCJGA)
	{
		try
		{
			if (this.KOGLEPFNALN)
			{
				this.KOGLEPFNALN = false;
				this.MJOMHIEMKMK = "https://sandbox-events.appsflyer.com/v1.0/c2s/inapp/app/steam/";
				this.BPCHEOFFPCN.Clear();
				this.EEGHJFAIMBF.Clear();
				this.IIDEKJNAFKG.Clear();
				this.NODBJCOJNLJ.Clear();
				bool flag = this.FDMGKEAHGFK();
				bool flag2 = null != this.FIBKHPMLNJN && this.FIBKHPMLNJN.activeSelf;
				if (AMDHFNLCJGA && flag && HKLPEDKJGFC.JEFCNJCCLMN())
				{
					JBBNEEHANHL hbbjbnjbmpk = this.GINJCMEHKLO();
					this.ONBPCOOBOFB(hbbjbnjbmpk);
					this.KFCKNJDLHMC(hbbjbnjbmpk);
				}
				this.KLBBGAFDNMP(JBBNEEHANHL.newFilterAdventure);
				this.NFBOBHDHJNM();
				if (AMDHFNLCJGA && flag2 && HKLPEDKJGFC.FACIFBONANM())
				{
					this.GJOEMCBBPFC(this.GINJCMEHKLO());
					this.CFKGMCPAFHP(this.GINJCMEHKLO());
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x0600226D RID: 8813 RVA: 0x000F4BC0 File Offset: 0x000F2DC0
	private void JMBBBIDIHLO()
	{
		this.OnCardsVolSaleClick();
	}

	// Token: 0x0600226E RID: 8814 RVA: 0x000F4BC8 File Offset: 0x000F2DC8
	public static bool TryGetSharedCardPitch(int PLKMJJIIJNO, out string HHNGGFLJAIJ, out string FBDPELCOKOP)
	{
		HHNGGFLJAIJ = null;
		FBDPELCOKOP = null;
		try
		{
			if (null == SceneLobbyManager2.BJBOJLBOOEF)
			{
				return false;
			}
			SceneLobbyManager2.LDGNIDMIIIA ldgnidmiiia = SceneLobbyManager2.BJBOJLBOOEF.BAKAHKFKAHL(PLKMJJIIJNO);
			if (ldgnidmiiia == null || ldgnidmiiia.FKCNMAEBNNK == null)
			{
				return false;
			}
			ldgnidmiiia.DPENIDKNIMK = true;
			HHNGGFLJAIJ = ldgnidmiiia.FKCNMAEBNNK;
			FBDPELCOKOP = ((ldgnidmiiia.JCMIJCCCCLC != null) ? ldgnidmiiia.JCMIJCCCCLC : ldgnidmiiia.MEHHECKMOAD);
			return true;
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
		return false;
	}

	// Token: 0x0600226F RID: 8815 RVA: 0x000F4C4C File Offset: 0x000F2E4C
	private List<KLJCEMBNKNI> OKPNLKEBMPH()
	{
		List<KLJCEMBNKNI> list = new List<KLJCEMBNKNI>();
		try
		{
			List<int> list2 = this.DGPAFDKHLJL(JBBNEEHANHL.filterMostPopular);
			if (list2.Count > 0)
			{
				list.Add(this.AGFJMDBMKBN("coverPopular", list2.Count, 0, 0, "", "popularpattern", JBBNEEHANHL.filterMostPopular, list2));
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
		return list;
	}

	// Token: 0x06002270 RID: 8816 RVA: 0x000F4CB4 File Offset: 0x000F2EB4
	public bool GetSearchStateForEditor(out List<int> IMDMGILBEIG, out List<GameObject> NHLNJDPABKC, out List<GameObject> JABDHGENJEG, out GameObject JHOLNDADPJB, out Transform GAOAJINIOOC)
	{
		IMDMGILBEIG = new List<int>(this.BPCHEOFFPCN);
		NHLNJDPABKC = new List<GameObject>(this.MGNNOFPKGJF);
		JABDHGENJEG = new List<GameObject>(this.GMGKODLANOP);
		JHOLNDADPJB = this.FIBKHPMLNJN;
		GAOAJINIOOC = this.scrollView0Content;
		return this.KOGLEPFNALN;
	}

	// Token: 0x06002271 RID: 8817 RVA: 0x000F4D00 File Offset: 0x000F2F00
	private void LJBNMDCFLNM()
	{
		this.LAENHLLONAI = 0;
	}

	// Token: 0x06002272 RID: 8818 RVA: 0x000F4D0C File Offset: 0x000F2F0C
	private void HGDMADKACMJ()
	{
		if (this.PHMIBKAJKMB.KCKFFONKMPI() || SceneLobbyManager2.spinsFireTime <= 1 || AKLFPGMDKLA.EHBBFMCILPC.ABGNIKKFFAC.KGEGKPHEMOJ() > 1)
		{
			this.OnWheelOfFortuneClick();
			return;
		}
		CommonUserInterface.EHBBFMCILPC.NFBMHHPIGFA(CCOJBMMKNAP.LMCCLMFGEBD().OGKGHLHHAAI("retry"), CCOJBMMKNAP.HFAKOKBHCGH().DNILNCLIHAP("<b>"), CCOJBMMKNAP.FEEDGKCJBLE().IKMNGFIDCLM("acliffbw22"), (DFGILFBGPLN)(-120), 128f, -58);
	}

	// Token: 0x06002273 RID: 8819 RVA: 0x000F4D88 File Offset: 0x000F2F88
	private void BHGOGAKGGEG()
	{
		DNPIKPDMKKI.GFEOFIABBKM();
		bool flag = false;
		if (this.PLJLNEAKFDK == EJDDNONEDNM.loadIntoStory && AKLFPGMDKLA.EHBBFMCILPC.PKNIPLDMJGG(AKLFPGMDKLA.EHBBFMCILPC.IEGJCPDCLMM, -1) != null)
		{
			if (SceneTransitionToLobbyManager.isRestartingChapter)
			{
				this.GKHNIMJJLJL = AKLFPGMDKLA.EHBBFMCILPC.PKNIPLDMJGG(AKLFPGMDKLA.EHBBFMCILPC.IEGJCPDCLMM, -1);
				this.GKHNIMJJLJL.KJKMJBMFDAN();
				flag = true;
			}
			else if (SceneTransitionToLobbyManager.isRestoringUndoPoint)
			{
				this.GKHNIMJJLJL = AKLFPGMDKLA.EHBBFMCILPC.PKNIPLDMJGG(AKLFPGMDKLA.EHBBFMCILPC.IEGJCPDCLMM, -1);
				this.GKHNIMJJLJL.NNFJIGFJOMG(SceneStoryManager.premiumChoiceBackendOperationResultKey);
				flag = true;
			}
			else if (SceneTransitionToLobbyManager.isRestoringRewindPoint)
			{
				this.GKHNIMJJLJL = AKLFPGMDKLA.EHBBFMCILPC.PKNIPLDMJGG(AKLFPGMDKLA.EHBBFMCILPC.IEGJCPDCLMM, -1);
				this.GKHNIMJJLJL.MJEAMNEAPGE();
				flag = true;
			}
		}
		SceneTransitionToLobbyManager.isRestartingChapter = false;
		SceneTransitionToLobbyManager.isRestoringUndoPoint = false;
		SceneTransitionToLobbyManager.isRestoringRewindPoint = false;
		SceneLobbyManager2.lobbyIsLoading = false;
		SceneLobbyManager2.MMICAAKCHBJ++;
		for (int i = 0; i < AssetsManager.EHBBFMCILPC.anthologyAssets.Count; i++)
		{
			if (null != AssetsManager.EHBBFMCILPC.anthologyAssets[i])
			{
				EIOPLEFLLIM eioplefllim = AKLFPGMDKLA.EHBBFMCILPC.GJBDBONJCDL(AssetsManager.EHBBFMCILPC.anthologyAssets[i].header.index);
				if (eioplefllim != null)
				{
					for (int j = 0; j < AssetsManager.EHBBFMCILPC.anthologyAssets[i].header.availableStories.Count; j++)
					{
						PLFDAJJHMKO plfdajjhmko = AKLFPGMDKLA.EHBBFMCILPC.PKNIPLDMJGG(AssetsManager.EHBBFMCILPC.anthologyAssets[i].header.availableStories[j], -1);
						if (plfdajjhmko != null)
						{
							AssetStoryHeader assetStoryHeader = GKJPOGNFKNK.CDCEFHLNNEC(AssetsManager.EHBBFMCILPC.anthologyAssets[i].header.availableStories[j]);
							if (null != assetStoryHeader && assetStoryHeader.MLGKEPJPICJ(plfdajjhmko.DHONIOBOLEL.DDEDAHCFHJN()) && eioplefllim.EGHHCFFLPCP(-1) <= j)
							{
								eioplefllim.LDPCILACGCO(j + 1, -1);
								Debug.LogError("Fixed the bug when anthology progress would not be incremented in SceneStoryManager at chapter end, for story with index:" + assetStoryHeader.index.ToString());
							}
						}
					}
				}
			}
		}
		FirebaseAnalyticsManager.EHBBFMCILPC.LogEvent(false, AGEHCPDNBFD.cdnActiv.ToString(), FFPHBMFGCNN.dldCompl.ToString(), BGHLMGPPCNN.cdnLbyLoadPt2.ToString(), false, false);
		if (NPOILPKELOJ.DJPKNMEEFPK)
		{
			if (NPOILPKELOJ.IKDKDPNCJBO == LKBEFCALCCC.ultra)
			{
				FirebaseAnalyticsManager.EHBBFMCILPC.LogEvent(false, AGEHCPDNBFD.issueRepCdn.ToString(), FFPHBMFGCNN.cdnSigUltra.ToString(), "", false, false);
			}
			else if (NPOILPKELOJ.IKDKDPNCJBO == LKBEFCALCCC.high)
			{
				FirebaseAnalyticsManager.EHBBFMCILPC.LogEvent(false, AGEHCPDNBFD.issueRepCdn.ToString(), FFPHBMFGCNN.cdnSigHigh.ToString(), "", false, false);
			}
			else if (NPOILPKELOJ.IKDKDPNCJBO == LKBEFCALCCC.mid)
			{
				FirebaseAnalyticsManager.EHBBFMCILPC.LogEvent(false, AGEHCPDNBFD.issueRepCdn.ToString(), FFPHBMFGCNN.cdnSigMid.ToString(), "", false, false);
			}
			else if (NPOILPKELOJ.IKDKDPNCJBO == LKBEFCALCCC.low)
			{
				FirebaseAnalyticsManager.EHBBFMCILPC.LogEvent(false, AGEHCPDNBFD.issueRepCdn.ToString(), FFPHBMFGCNN.cdnSigLow.ToString(), "", false, false);
			}
			NPOILPKELOJ.DJPKNMEEFPK = false;
		}
		if (SceneLobbyManager2.selectedFirstStoryOffering >= 0)
		{
			AKLFPGMDKLA.EHBBFMCILPC.LDAPMNLGAPC(5);
		}
		if ((AKLFPGMDKLA.EHBBFMCILPC.BJIDACANAJH > 0 || AKLFPGMDKLA.EHBBFMCILPC.PNNHDJFBHOL > 0 || AKLFPGMDKLA.EHBBFMCILPC.JDMBJMHEPMD > 0 || AKLFPGMDKLA.EHBBFMCILPC.CGFOFGGHLEE > 0 || (!AKLFPGMDKLA.EHBBFMCILPC.EAFEJCKIEPL(5) && SceneLobbyManager2.selectedFirstStoryOffering == -1)) && !flag)
		{
			this.PLJLNEAKFDK = EJDDNONEDNM.stayInLobby;
		}
		try
		{
			if (this.PLJLNEAKFDK == EJDDNONEDNM.loadIntoStory && AKLFPGMDKLA.EHBBFMCILPC.IEGJCPDCLMM >= 0)
			{
				AssetAnthology y = GKJPOGNFKNK.MLDENPHFNPH(AKLFPGMDKLA.EHBBFMCILPC.IEGJCPDCLMM, false);
				if (null != y)
				{
					AssetStoryHeader assetStoryHeader2 = GKJPOGNFKNK.CDCEFHLNNEC(AKLFPGMDKLA.EHBBFMCILPC.IEGJCPDCLMM);
					if (null != assetStoryHeader2)
					{
						int index = AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).DHONIOBOLEL.DDEDAHCFHJN();
						if (assetStoryHeader2.chapterAssetPacks[index].assetPacks.Count == 0)
						{
							AKLFPGMDKLA.EHBBFMCILPC.IEGJCPDCLMM = -1;
							this.PLJLNEAKFDK = EJDDNONEDNM.stayInLobby;
							DPGJIJGOCIC.ADFCDFHBDAF("Blocking automatic story load attempt for a chapter with 0 asset packs - story:" + AKLFPGMDKLA.EHBBFMCILPC.IEGJCPDCLMM.ToString() + ", chapter:" + index.ToString());
						}
					}
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
		if (AKLFPGMDKLA.EHBBFMCILPC.HCEHBFCIIHN() < 1 && 1 == AKLFPGMDKLA.EHBBFMCILPC.MJPKIMHENNF)
		{
			FirebaseAnalyticsManager.EHBBFMCILPC.LogEvent(true, AGEHCPDNBFD.d1Ret.ToString(), FFPHBMFGCNN.d1Board.ToString(), BGHLMGPPCNN.d1LobbyLoaded.ToString(), true, false);
		}
		if (SceneLobbyManager2.selectedFirstStoryOffering >= 0)
		{
			AssetsManager.EHBBFMCILPC.GetLoadingProgressSnapshot().GIJKJMMDJEL(0.8f, 1f);
		}
		else if (this.PLJLNEAKFDK == EJDDNONEDNM.loadIntoStory)
		{
			AssetsManager.EHBBFMCILPC.GetLoadingProgressSnapshot().GIJKJMMDJEL(0.9f, 1f);
		}
		else
		{
			AssetsManager.EHBBFMCILPC.GetLoadingProgressSnapshot().GIJKJMMDJEL(0f, 1f);
		}
		if (this.PLJLNEAKFDK == EJDDNONEDNM.stayInLobby)
		{
			try
			{
				if (this.COJEBPAFPFP && this.MMJJBECDAOC())
				{
					this.UpdateAnthologiesPropertiesV2(false, true);
					this.BMHEEAJGFJI = true;
				}
			}
			catch (Exception aklgbjkdomm2)
			{
				DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm2);
			}
			this.TransitionToLobby();
			this.scrollView0Content.GetComponent<VerticalLayoutGroup>().padding.top = (int)(-23f * (1f - KHPGPLAMAIN.PPCIFCGLKJD(0f, 1.5f)));
			this.IADPDLIEHBD();
			this.ELKBJDBEMCP();
			this.BPHPLAHKPPE();
			this.OHNOJBCDJKI();
		}
		else
		{
			SceneLobbyManager2.returnedFromCompletedStoryChapter = false;
			AssetAnthology edpkckmfnkg = GKJPOGNFKNK.GJAAHGIAPMH(AKLFPGMDKLA.EHBBFMCILPC.IEGJCPDCLMM);
			this.FIFEJGHAHGB(edpkckmfnkg);
		}
		if (SceneLobbyManager2.MGCECGDMAMK && !SceneLobbyManager2.CEOACAJHGEN)
		{
			SceneLobbyManager2.CEOACAJHGEN = true;
			FirebaseAnalyticsManager.EHBBFMCILPC.LogEvent(false, AGEHCPDNBFD.lobbyHitNew.ToString(), FFPHBMFGCNN.lbyEnd.ToString(), BGHLMGPPCNN.lbyCdnTry.ToString() + AssetsManager.EHBBFMCILPC.GetSetDepotsCount().ToString(), false, false);
			FirebaseAnalyticsManager.EHBBFMCILPC.LogEvent(false, AGEHCPDNBFD.lobbyHitNew.ToString(), FFPHBMFGCNN.lbyEnd.ToString(), BGHLMGPPCNN.lbySrvTry.ToString() + App42Manager.EHBBFMCILPC.GetCustomCodeUrlOffset().ToString(), false, false);
			FirebaseAnalyticsManager.EHBBFMCILPC.LogEvent(false, AGEHCPDNBFD.lobbyHitNew.ToString(), FFPHBMFGCNN.lbyEnd.ToString(), "", false, false);
		}
	}

	// Token: 0x06002274 RID: 8820 RVA: 0x000F54A4 File Offset: 0x000F36A4
	private void MEBFPCDBDNM()
	{
		if (null != this.focusItem)
		{
			this.focusItem.GetComponent<FocusItem>().OpenLounge();
		}
	}

	// Token: 0x06002275 RID: 8821 RVA: 0x000F54A4 File Offset: 0x000F36A4
	private void ONEPBGINIEH()
	{
		if (null != this.focusItem)
		{
			this.focusItem.GetComponent<FocusItem>().OpenLounge();
		}
	}

	// Token: 0x06002276 RID: 8822 RVA: 0x000F54C4 File Offset: 0x000F36C4
	private void BMPNMJCMHDG()
	{
		if (ContentAvatarPage.closeProfileAndOpenWheelOfFortune)
		{
			base.Invoke("a_web", 292f);
			ContentAvatarPage.closeProfileAndOpenWheelOfFortune = true;
			return;
		}
		if (HBKMKCBPJDI.NBLBPEJOFPC)
		{
			CommonUserInterface.EHBBFMCILPC.HideConnectingAnimation();
			base.Invoke("hdr", 598f);
			HBKMKCBPJDI.NBLBPEJOFPC = false;
			return;
		}
		CommonUserInterface.EHBBFMCILPC.MCJIGJMFBMI();
	}

	// Token: 0x06002277 RID: 8823 RVA: 0x000F5521 File Offset: 0x000F3721
	private void CJEJENJBDDF()
	{
		this.HBPLGJFPFKM();
	}

	// Token: 0x06002278 RID: 8824 RVA: 0x000F552C File Offset: 0x000F372C
	private void ENKCJJDAPNF(ECJCFGAOPHJ FFACCDIEBIA)
	{
		if (FFACCDIEBIA == null || FFACCDIEBIA.APDJNDIIILK == null)
		{
			return;
		}
		for (int i = 0; i < FFACCDIEBIA.APDJNDIIILK.Count; i++)
		{
			int num = FFACCDIEBIA.APDJNDIIILK[i];
			if (num / 100000 != this.HFFIIBBJBMH.header.CKACBBGHJGI())
			{
				DPGJIJGOCIC.ADFCDFHBDAF(string.Concat(new string[]
				{
					"[Lounge/lobby] npc animation pack of another anthology skipped: ",
					num.ToString(),
					" (",
					FFACCDIEBIA.IJEEKLNDJGE,
					")"
				}));
			}
			else
			{
				AssetsManager.EHBBFMCILPC.QueueNpcAnimationBundle(num);
			}
		}
	}

	// Token: 0x06002279 RID: 8825 RVA: 0x000F55CD File Offset: 0x000F37CD
	private IEnumerator FFJCMHGBHNF()
	{
		AssetsManager.EHBBFMCILPC.GetLoadingProgressSnapshot().EPJKDCDOEMM(0);
		CommonUserInterface.EHBBFMCILPC.ShowConnectingAnimationWithProgress(96);
		yield return new WaitForEndOfFrame();
		while (AssetsManager.EHBBFMCILPC.IsBusy())
		{
			DPGJIJGOCIC.NFIDPOMCNLP("SceneLobbyManager2.OpenWheelOfFortuneCdn(): AssetsManager.Instance.IsBusy()");
			yield return new WaitForSeconds(0.05f);
		}
		AssetsManager.EHBBFMCILPC.QueueAssetBundleDownload(NMKDCBPMCKI.AssetBundleProfileData4, 0, -1, FLDBFOADFLH.startDownloadAndProceed, false, false, false, null, -1, false, "", false, false);
		AssetsManager.EHBBFMCILPC.GetLoadingProgressSnapshot().CLIOEOLFFLO(LEJKDNAGDHC.Fast);
		AssetsManager.EHBBFMCILPC.GetLoadingProgressSnapshot().GIJKJMMDJEL(0f, 1f);
		AssetsManager.EHBBFMCILPC.DownloadQueuedAssetBundles("OnLobbyWheelDataCdnSuccess", "OnLobbyWheelDataDataCdnFailed", false);
		yield break;
	}

	// Token: 0x0600227A RID: 8826 RVA: 0x000F4A55 File Offset: 0x000F2C55
	private void MOCCHMAHHNK()
	{
		base.StartCoroutine(this.CPKEKFFODHH());
	}

	// Token: 0x0600227B RID: 8827 RVA: 0x000F55D8 File Offset: 0x000F37D8
	private void IAIIODBDKHK()
	{
		if (ODJKHCHFKNL.LEMILALILKP() != DFGILFBGPLN.screenLobby)
		{
			return;
		}
		this.PHMIBKAJKMB.EPJKDCDOEMM((float)SceneLobbyManager2.spinsFireTime);
		this.NAEHPAIOHLG.EPJKDCDOEMM((float)SceneLobbyManager2.energyFireTime);
		for (int i = 0; i < this.lobbyParticles.Count; i++)
		{
			if (null != this.lobbyParticles[i])
			{
				this.lobbyParticles[i].gameObject.SetActive(true);
				this.lobbyParticles[i].Play();
			}
		}
		this.ODOPEGPBCCD();
		this.NHBPLAFBNIG(-1, -1);
		AOBJLALDBAA.EHBBFMCILPC.EGELHPJBAIC("OnNeedToActivateFocusItemCloseButton", 0f);
		this.CBNBDIMFAII();
		if (PassesItem.reopenOnPurchasingScreenLeft)
		{
			this.HBPLGJFPFKM();
		}
		this.PCLAANFABBB();
		this.JLFGANHMMOM();
		this.OnPopupCardOptionsReopen();
	}

	// Token: 0x0600227C RID: 8828 RVA: 0x000F56AC File Offset: 0x000F38AC
	private void EBEODGBEEMI()
	{
		try
		{
			if (this.FDMGKEAHGFK())
			{
				this.BCOOKJICILK(JBBNEEHANHL.filterSearch);
				this.scrollView2Controller.SetItemOnCenterImmediate(this.FIBKHPMLNJN.transform);
			}
			else
			{
				this.ONBPCOOBOFB(JBBNEEHANHL.filterSearch);
			}
			this.HNDHIAEMNAJ();
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x0600227D RID: 8829 RVA: 0x000F5708 File Offset: 0x000F3908
	public void OnPopupNotEnoughEnergyOrHardCurrencyGetMore2()
	{
		this.ALGIAIKDEPH();
		CommonUserInterface.EHBBFMCILPC.GetPurchasingViewManager().Show(true);
	}

	// Token: 0x0600227E RID: 8830 RVA: 0x000F5720 File Offset: 0x000F3920
	private void IKNJHAPNPHI()
	{
		if (null != this.LGKGGPDKAHF)
		{
			this.CPLLGNAKIIL(this.LGKGGPDKAHF);
			base.StartCoroutine(this.PLAHBLEFONH());
		}
	}

	// Token: 0x0600227F RID: 8831 RVA: 0x000F5749 File Offset: 0x000F3949
	private void HKPFHDPBJOI()
	{
		base.StartCoroutine(this.IGDDHKJKIME());
	}

	// Token: 0x06002280 RID: 8832 RVA: 0x000F5758 File Offset: 0x000F3958
	private void PAFLEJIHGKJ()
	{
		this.fireworksParticles.Play();
	}

	// Token: 0x06002281 RID: 8833 RVA: 0x000F5768 File Offset: 0x000F3968
	private void ABOLIKOEIDM(List<string> BGBNABJJMEI, string IGPPDLNCBME)
	{
		if (BGBNABJJMEI == null || IGPPDLNCBME == null || IGPPDLNCBME.Length == 0 || IGPPDLNCBME.Length > 26)
		{
			return;
		}
		IGPPDLNCBME = this.GDAPJCHEDOK(IGPPDLNCBME);
		for (int i = 0; i < BGBNABJJMEI.Count; i++)
		{
			if (string.Equals(BGBNABJJMEI[i], IGPPDLNCBME, StringComparison.OrdinalIgnoreCase))
			{
				return;
			}
		}
		BGBNABJJMEI.Add(IGPPDLNCBME);
	}

	// Token: 0x06002282 RID: 8834 RVA: 0x000F57C0 File Offset: 0x000F39C0
	public void PMGBKOEKNLH()
	{
		this.RestartStoryX(2);
	}

	// Token: 0x06002283 RID: 8835 RVA: 0x000F57CC File Offset: 0x000F39CC
	private void NKKDELLNMHD()
	{
		KIOOJMGLCLC kioojmglclc = ODLJHDIGLGO.MNALIKIMKFC(CLHDENLPOFP.gamePass, true);
		KIOOJMGLCLC kioojmglclc2 = ODLJHDIGLGO.MNALIKIMKFC(CLHDENLPOFP.gamePass, false);
		this.passesButtonExpiredExclamation.SetActive(kioojmglclc == null && kioojmglclc2 != null);
		if (null != this.footerPassesExpiredExclamation)
		{
			this.footerPassesExpiredExclamation.SetActive(this.passesButtonExpiredExclamation.activeSelf);
		}
	}

	// Token: 0x06002284 RID: 8836 RVA: 0x000F5822 File Offset: 0x000F3A22
	private void OBDEAPLGMDM()
	{
		this.OnPublicProfileClick();
	}

	// Token: 0x06002285 RID: 8837 RVA: 0x000F582A File Offset: 0x000F3A2A
	public void OnCurrencyDiamontsClick()
	{
		CommonUserInterface.EHBBFMCILPC.GetPurchasingViewManager().SetResourcesFilter(JFGBECHLPGI.hardCurrency);
		this.OnCurrencyClick();
	}

	// Token: 0x06002286 RID: 8838 RVA: 0x000F5842 File Offset: 0x000F3A42
	private int FNDKJANAFLE(JBBNEEHANHL HBBJBNJBMPK)
	{
		return 6;
	}

	// Token: 0x06002287 RID: 8839 RVA: 0x000F5848 File Offset: 0x000F3A48
	private void LGEHFJOINIL()
	{
		CommonUserInterface.EHBBFMCILPC.HideConnectingAnimation();
		CommonUserInterface.EHBBFMCILPC.ShowGenericPopupOneOverride(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("errortitle"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("app42error") + " (" + AKLFPGMDKLA.EHBBFMCILPC.EEHGLPEIIHD + ")", CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("retry"), new UnityAction(this.JEPHPIMHGJD), DFGILFBGPLN.popupBackendError, 0f, 28);
	}

	// Token: 0x06002288 RID: 8840 RVA: 0x000F58C8 File Offset: 0x000F3AC8
	private void OnDisable()
	{
		this.AECHPENEOCI();
		SceneLobbyManager2.lobbyIsActive = false;
		this.PEOGENJHMLL();
		ODJKHCHFKNL.GFEOFIABBKM();
		AOBJLALDBAA.EHBBFMCILPC.MANLHALMCIH("OnFullscreenCardOptionClickLobby", new UnityAction(this.ViewCardCutsceneLobby));
		AOBJLALDBAA.EHBBFMCILPC.MANLHALMCIH("OnCutsceneViewLobbyAssetBundleFolderInitializeSuccess", new UnityAction(this.IHBCLCLNFJM));
		AOBJLALDBAA.EHBBFMCILPC.MANLHALMCIH("OnCutsceneViewLobbyAssetsDownloadSuccess", new UnityAction(this.NKDJKLHMAJN));
		AOBJLALDBAA.EHBBFMCILPC.MANLHALMCIH("OnCutsceneViewLobbyAssetsDownloadFailed", new UnityAction(this.ICPIGGMCHEN));
		AOBJLALDBAA.EHBBFMCILPC.MANLHALMCIH("OnBackendPassesReinitialized", new UnityAction(this.CKNBPMFGHML));
		AOBJLALDBAA.EHBBFMCILPC.MANLHALMCIH("OnPopupCardOptionsUnlockWithSpSuccessContinueLobby", new UnityAction(this.OOALGPIOODP));
		AOBJLALDBAA.EHBBFMCILPC.MANLHALMCIH("OnPopupCardOptionsBackClickLobby", new UnityAction(this.OnPopupCardOptionsBackClickLobby));
		AOBJLALDBAA.EHBBFMCILPC.MANLHALMCIH("OnPopupCardOptionsNextClickLobby", new UnityAction(this.OnPopupCardOptionsNextClickLobby));
		AOBJLALDBAA.EHBBFMCILPC.MANLHALMCIH("OnAllCollectableCardsDownloadSuccessLobby", new UnityAction(this.JEPJKDAFBMH));
		AOBJLALDBAA.EHBBFMCILPC.MANLHALMCIH("OnAllCollectableCardsDownloadFailedLobby", new UnityAction(this.JNCJEGFNCCP));
		AOBJLALDBAA.EHBBFMCILPC.MANLHALMCIH("OnUpdateSocialEventsCounter", new UnityAction(this.DHGGEFIJBHM));
		AOBJLALDBAA.EHBBFMCILPC.MANLHALMCIH("OnCutsceneViewLeft", new UnityAction(this.LBFDDEFKCJN));
		AOBJLALDBAA.EHBBFMCILPC.MANLHALMCIH("OnSketchViewLeft", new UnityAction(this.EHIBOKHHKBF));
		AOBJLALDBAA.EHBBFMCILPC.MANLHALMCIH("OnCutsceneViewShow", new UnityAction(this.KHCPHAIGBJE));
		AOBJLALDBAA.EHBBFMCILPC.MANLHALMCIH("OnCutsceneViewShowWI", new UnityAction(this.IMINAEKJFCK));
		AOBJLALDBAA.EHBBFMCILPC.MANLHALMCIH("OnSketchViewShowWI", new UnityAction(this.EHBEAAKMMLL));
		AOBJLALDBAA.EHBBFMCILPC.MANLHALMCIH("OnSaveSyncAnyResult", new UnityAction(this.GIIFOHCFDEJ));
		AOBJLALDBAA.EHBBFMCILPC.MANLHALMCIH("OnSaveSlotsUnlockContinueToPurchasingScreen", new UnityAction(this.LBEMJPOHBGK));
		AOBJLALDBAA.EHBBFMCILPC.MANLHALMCIH("OnSaveSlotsItemSlotChanged", new UnityAction(this.DGNPNOKIKJC));
		AOBJLALDBAA.EHBBFMCILPC.MANLHALMCIH("OnSaveSlotsItemSlotDeleted", new UnityAction(this.EFNPBHABEME));
		AOBJLALDBAA.EHBBFMCILPC.MANLHALMCIH("OnSaveSlotsItemSlotDuplicated", new UnityAction(this.HBLJJDBLGMG));
		AOBJLALDBAA.EHBBFMCILPC.MANLHALMCIH("OnSaveSyncAnyResultDuplicate", new UnityAction(this.CGDGJIKCLBL));
		AOBJLALDBAA.EHBBFMCILPC.MANLHALMCIH("OnApplicationBeforeRestart", new UnityAction(this.JEKCPAGMFBE));
		AOBJLALDBAA.EHBBFMCILPC.MANLHALMCIH("OnMissingPreview2CdnSuccess", new UnityAction(this.COIJDOCAABP));
		AOBJLALDBAA.EHBBFMCILPC.MANLHALMCIH("OnMissingPreview2CdnFailed", new UnityAction(this.MBEIIFKJEKD));
		AOBJLALDBAA.EHBBFMCILPC.MANLHALMCIH("OnLiveProfileThumbnailsCdnSuccess", new UnityAction(this.BJPEICPDFHJ));
		AOBJLALDBAA.EHBBFMCILPC.MANLHALMCIH("OnLiveProfileThumbnailsCdnFailed", new UnityAction(this.BAGNOCIMPBD));
		AOBJLALDBAA.EHBBFMCILPC.MANLHALMCIH("OnLiveProfileThemesLoaderStart", new UnityAction(this.JGIMEDGEAGE));
		AOBJLALDBAA.EHBBFMCILPC.MANLHALMCIH("OnLiveProfileThemesLoaderStop", new UnityAction(this.PCCPFFIJNIO));
		AOBJLALDBAA.EHBBFMCILPC.MANLHALMCIH("OnLiveProfileThemeBackgroundCdnSuccess", new UnityAction(this.AELPLJGOJJK));
		AOBJLALDBAA.EHBBFMCILPC.MANLHALMCIH("OnLiveProfileThemeBackgroundCdnFailed", new UnityAction(this.GMOBHPBBPNF));
		AOBJLALDBAA.EHBBFMCILPC.MANLHALMCIH("OnLobbyProfileDataCdnSuccess", new UnityAction(this.NELHGHFAGFH));
		AOBJLALDBAA.EHBBFMCILPC.MANLHALMCIH("OnLobbyProfileDataCdnFailed", new UnityAction(this.FECFNFKHLKM));
		AOBJLALDBAA.EHBBFMCILPC.MANLHALMCIH("OnNeedToRestartProfileItemAnimation", new UnityAction(this.KBOOHCDEOIJ));
		AOBJLALDBAA.EHBBFMCILPC.MANLHALMCIH("OnBackendGetPublicProfileException", new UnityAction(this.HAJDMFMINFE));
		AOBJLALDBAA.EHBBFMCILPC.MANLHALMCIH("OnBackendGetPublicProfileSuccess", new UnityAction(this.MOCCHMAHHNK));
		AOBJLALDBAA.EHBBFMCILPC.MANLHALMCIH("OnBackendSavePublicProfileException", new UnityAction(this.EGINOCCMDMD));
		AOBJLALDBAA.EHBBFMCILPC.MANLHALMCIH("OnBackendSavePublicProfileSuccess", new UnityAction(this.MCPPLMGAGJN));
		AOBJLALDBAA.EHBBFMCILPC.MANLHALMCIH("OnLobbyManInTheMiddleAttackDetected", new UnityAction(this.IIEGAKKFKIJ));
		AOBJLALDBAA.EHBBFMCILPC.MANLHALMCIH("OnPopupUpdateWelcomeWhatsMoreClick", new UnityAction(this.JOFDIMJKENC));
		AOBJLALDBAA.EHBBFMCILPC.MANLHALMCIH("OnResolutionChanged", new UnityAction(this.KCLCJADHJEH));
		AOBJLALDBAA.EHBBFMCILPC.MANLHALMCIH("OnSettingsPopupCloseAndNeedToRestartGame", new UnityAction(this.CMKPNGPCDAB));
		AOBJLALDBAA.EHBBFMCILPC.MANLHALMCIH("OnSettingsPopupCloseAndNeedToRestartGame2", new UnityAction(this.DNGHLBFEODC));
		AOBJLALDBAA.EHBBFMCILPC.MANLHALMCIH("OnSettingsPopupCloseAndNeedToShowPostEnableNotif", new UnityAction(this.OCIAMGMLMLG));
		AOBJLALDBAA.EHBBFMCILPC.MANLHALMCIH("OnSettingsPopupCloseAndNeedToShowGameModeNotif", new UnityAction(this.IKFEBEDGOIG));
		AOBJLALDBAA.EHBBFMCILPC.MANLHALMCIH(SceneAvatarManager.onAvatarScreenLeft, new UnityAction(this.GPNFLDDKLAJ));
		AOBJLALDBAA.EHBBFMCILPC.MANLHALMCIH("OnAvatarScreenAssetsDownloadSuccess", new UnityAction(this.OINFFDNGJHF));
		AOBJLALDBAA.EHBBFMCILPC.MANLHALMCIH("OnAvatarScreenAssetBundleFolderInitializeSuccess", new UnityAction(this.HGPGOPCOFKB));
		AOBJLALDBAA.EHBBFMCILPC.MANLHALMCIH("OnAvatarScreenAssetsDownloadFailed", new UnityAction(this.GNEIAKDLELG));
		AOBJLALDBAA.EHBBFMCILPC.MANLHALMCIH("OnChapterSnapshotRestoreExecute", new UnityAction(this.OnChapterSnapshotRestoreExecute));
		AOBJLALDBAA.EHBBFMCILPC.MANLHALMCIH("OnPopupStoryRestartManagerRestartChapter", new UnityAction(this.RestartChapter));
		AOBJLALDBAA.EHBBFMCILPC.MANLHALMCIH("OnPopupStoryRestartManagerRestartStory", new UnityAction(this.RestartStory));
		AOBJLALDBAA.EHBBFMCILPC.MANLHALMCIH("OnPopupStoryRestartManagerRestartStory0", new UnityAction(this.RestartStory0));
		AOBJLALDBAA.EHBBFMCILPC.MANLHALMCIH("OnPopupStoryRestartManagerRestartStory1", new UnityAction(this.RestartStory1));
		AOBJLALDBAA.EHBBFMCILPC.MANLHALMCIH("OnPopupStoryRestartManagerRestartStory2", new UnityAction(this.RestartStory2));
		AOBJLALDBAA.EHBBFMCILPC.MANLHALMCIH("OnPopupStoryRestartManagerRestartStory3", new UnityAction(this.RestartStory3));
		AOBJLALDBAA.EHBBFMCILPC.MANLHALMCIH("OnPopupStoryRestartManagerRestartStory4", new UnityAction(this.RestartStory4));
		AOBJLALDBAA.EHBBFMCILPC.MANLHALMCIH("OnBackendStartPlayChapterSuccess", new UnityAction(this.OFHBPNBDAKO));
		AOBJLALDBAA.EHBBFMCILPC.MANLHALMCIH("OnBackendStartPlayChapterException", new UnityAction(this.EOPMIONFFPM));
		AOBJLALDBAA.EHBBFMCILPC.MANLHALMCIH("OnLobbyStoryManagerDownloadSplashScreenFailed", new UnityAction(this.DBHOJGKJPND));
		AOBJLALDBAA.EHBBFMCILPC.MANLHALMCIH("OnLobbyStoryManagerDownloadSplashScreenSuccess", new UnityAction(this.IEJGBPPPIHD));
		AOBJLALDBAA.EHBBFMCILPC.MANLHALMCIH(SceneLobbyManager2.EIODJHDOHPE, new UnityAction(this.JEPHPIMHGJD));
		AOBJLALDBAA.EHBBFMCILPC.MANLHALMCIH(SceneLobbyManager2.MHOJMLGCLOD, new UnityAction(this.OBCFGOCKEEP));
		AOBJLALDBAA.EHBBFMCILPC.MANLHALMCIH("OnBackendGetIncentRewardAdSuccess", new UnityAction(this.ILBNPEIJKJM));
		AOBJLALDBAA.EHBBFMCILPC.MANLHALMCIH("OnBackendGetIncentRewardAdException", new UnityAction(this.LGEHFJOINIL));
		AOBJLALDBAA.EHBBFMCILPC.MANLHALMCIH("OnGenericPopupManagerHide", new UnityAction(this.KMKDECPKCMF));
		AOBJLALDBAA.EHBBFMCILPC.MANLHALMCIH("OnPopupOfferManagerContinueToPurchasingScreen", new UnityAction(this.CPEELJJHCNA));
		AOBJLALDBAA.EHBBFMCILPC.MANLHALMCIH("OnPurchasingViewLeave", new UnityAction(this.IAIIODBDKHK));
		AOBJLALDBAA.EHBBFMCILPC.MANLHALMCIH("OnDailyRewardPopupHide", new UnityAction(this.BCKFLJLMNDC));
		AOBJLALDBAA.EHBBFMCILPC.MANLHALMCIH("OnReturnRewardPopupHide", new UnityAction(this.FGIMMLMHMGJ));
		AOBJLALDBAA.EHBBFMCILPC.MANLHALMCIH("OnSceneLobbyManagerExitSyncSuccess", new UnityAction(this.GONBHNMNOLP));
		AOBJLALDBAA.EHBBFMCILPC.MANLHALMCIH("OnNeedToShowNoMoreEnergyPopup", new UnityAction(this.OnNeedToShowNoMoreEnergyPopup));
		AOBJLALDBAA.EHBBFMCILPC.MANLHALMCIH("OnNeedToShowNoMoreHardPopup", new UnityAction(this.OnNeedToShowNoMoreHardPopup));
		AOBJLALDBAA.EHBBFMCILPC.MANLHALMCIH("OnAccountSignInSuccess", new UnityAction(this.GMFFLAFLGHH));
		AOBJLALDBAA.EHBBFMCILPC.MANLHALMCIH("OnLanguageChange", new UnityAction(this.LLMPAPDBHEL));
		AOBJLALDBAA.EHBBFMCILPC.MANLHALMCIH("OnSceneLobbyManagerRound0AssetsDownloadSuccess", new UnityAction(this.FCJAODPFFGC));
		AOBJLALDBAA.EHBBFMCILPC.MANLHALMCIH("OnSceneLobbyManagerRound0aAssetsDownloadSuccess", new UnityAction(this.BHGOGAKGGEG));
		AOBJLALDBAA.EHBBFMCILPC.MANLHALMCIH("OnSceneLobbyManagerRound0aaAssetsDownloadSuccess", new UnityAction(this.GEMOOEPJGHP));
		AOBJLALDBAA.EHBBFMCILPC.MANLHALMCIH("OnSceneLobbyManagerRound1AssetsDownloadSuccess", new UnityAction(this.DEOEFKNLOHM));
		AOBJLALDBAA.EHBBFMCILPC.MANLHALMCIH("OnSceneLobbyManagerAssetsDownloadFailed", new UnityAction(this.NAIPKHPLOGF));
		AOBJLALDBAA.EHBBFMCILPC.MANLHALMCIH("OnBackendGetDefaultBundlesSuccess", new UnityAction(this.PDLHBIIGLJD));
		AOBJLALDBAA.EHBBFMCILPC.MANLHALMCIH("OnBackendGetDefaultBundlesException", new UnityAction(this.KNLCPLJLJCC));
		AOBJLALDBAA.EHBBFMCILPC.MANLHALMCIH("OnApplicationFocusNeedToUpdateCurrency", new UnityAction(this.JPDHKJCINAF));
		AOBJLALDBAA.EHBBFMCILPC.MANLHALMCIH("OnSocialModeChanged", new UnityAction(this.OnSocialModeChanged));
		AOBJLALDBAA.EHBBFMCILPC.MANLHALMCIH("OnEmailSubscribeSuccess", new UnityAction(this.IOPEFJJGAFF));
		AOBJLALDBAA.EHBBFMCILPC.MANLHALMCIH("OnEmailSubscribeException", new UnityAction(this.FLOAFHNAKJM));
		AOBJLALDBAA.EHBBFMCILPC.MANLHALMCIH("OnEmailUnsubscribeSuccess", new UnityAction(this.PACLPFDOHEI));
		AOBJLALDBAA.EHBBFMCILPC.MANLHALMCIH("OnEmailUnsubscribeException", new UnityAction(this.LCLOPECGHMG));
		AOBJLALDBAA.EHBBFMCILPC.MANLHALMCIH("OnRewardOptionProfileClick", new UnityAction(this.OBDEAPLGMDM));
		AOBJLALDBAA.EHBBFMCILPC.MANLHALMCIH("OnRewardFirstEpisodeClick", new UnityAction(this.MIPEOPGCNIA));
		AOBJLALDBAA.EHBBFMCILPC.MANLHALMCIH("OnRewardSubsequentEpisodeClick", new UnityAction(this.NMJNFFCENDF));
		AOBJLALDBAA.EHBBFMCILPC.MANLHALMCIH("OnRewardReplayEpisodeClick", new UnityAction(this.PBDBLMMMMFF));
		AOBJLALDBAA.EHBBFMCILPC.MANLHALMCIH("OnRewardStoryCompleteClick", new UnityAction(this.OJEMLBDNFKE));
		AOBJLALDBAA.EHBBFMCILPC.MANLHALMCIH("OnRewardFreeDiamondsClick", new UnityAction(this.GLDAFFNHKFJ));
		AOBJLALDBAA.EHBBFMCILPC.MANLHALMCIH("OnRewardFreeSpinsClick", new UnityAction(this.PDPAOELMHKF));
		AOBJLALDBAA.EHBBFMCILPC.MANLHALMCIH("OnRewardFreePassPlayStore", new UnityAction(this.MNHPBGIFPJK));
		AOBJLALDBAA.EHBBFMCILPC.MANLHALMCIH("OnApplicationFocusBasicSyncSuccess", new UnityAction(this.OFFBAMLEFNH));
		AOBJLALDBAA.EHBBFMCILPC.MANLHALMCIH("OnCardVolumeUnlockContinueToPurchasingScreen", new UnityAction(this.CHAKGJICCJG));
		AOBJLALDBAA.EHBBFMCILPC.MANLHALMCIH("OnFriendsPlusUnlockContinueToPurchasingScreen", new UnityAction(this.ABCCMIBKPFL));
		AOBJLALDBAA.EHBBFMCILPC.MANLHALMCIH("OnBackendGetDropChancesSuccess", new UnityAction(this.DJDBKHPCDKM));
		AOBJLALDBAA.EHBBFMCILPC.MANLHALMCIH("OnBackendGetDropChancesException", new UnityAction(this.AAMCENHGBCM));
		AOBJLALDBAA.EHBBFMCILPC.MANLHALMCIH("OnBackendGetDropChancesSuccess2", new UnityAction(this.BCEMOOCBJFJ));
		AOBJLALDBAA.EHBBFMCILPC.MANLHALMCIH("OnBackendGetDropChancesException2", new UnityAction(this.ADPBMDNMDNG));
		AOBJLALDBAA.EHBBFMCILPC.MANLHALMCIH("OnLobbyWheelDataCdnSuccess", new UnityAction(this.ONHLICMODAO));
		AOBJLALDBAA.EHBBFMCILPC.MANLHALMCIH("OnLobbyWheelDataDataCdnFailed", new UnityAction(this.LHGOFKKNKOE));
		AOBJLALDBAA.EHBBFMCILPC.MANLHALMCIH("OnLobbySkinShopCdnSuccess", new UnityAction(this.PIEHMJKPIGK));
		AOBJLALDBAA.EHBBFMCILPC.MANLHALMCIH("OnLobbySkinShopCdnFailed", new UnityAction(this.FGOFPMAGNMJ));
		AOBJLALDBAA.EHBBFMCILPC.MANLHALMCIH("OnSkinShopClose", new UnityAction(this.EDMJHANBNIN));
		AOBJLALDBAA.EHBBFMCILPC.MANLHALMCIH("OnSkinShopCardSelected", new UnityAction(this.EHKDHDDJHLL));
		AOBJLALDBAA.EHBBFMCILPC.MANLHALMCIH("OnSpinsUnlockContinueToPurchasingScreen", new UnityAction(this.CPCHLINKCAK));
		AOBJLALDBAA.EHBBFMCILPC.MANLHALMCIH("OnCardUpgradeContinueToPurchasingScreen", new UnityAction(this.AMFLJPANFGF));
		AOBJLALDBAA.EHBBFMCILPC.MANLHALMCIH("OnLobbyStartFireworksEffect", new UnityAction(this.PAFLEJIHGKJ));
		AOBJLALDBAA.EHBBFMCILPC.MANLHALMCIH("OnLobbyStopFireworksEffect", new UnityAction(this.HCLLBPGCHID));
		AOBJLALDBAA.EHBBFMCILPC.MANLHALMCIH("OnLobbyStartFireworksEffectAutoHide", new UnityAction(this.OLLKOHMOEGI));
		AOBJLALDBAA.EHBBFMCILPC.MANLHALMCIH("OnBackendGetSketchesBalanceSuccess", new UnityAction(this.HKPFHDPBJOI));
		AOBJLALDBAA.EHBBFMCILPC.MANLHALMCIH("OnBackendGetSketchesBalanceException", new UnityAction(this.KHELKJHAPPJ));
		AOBJLALDBAA.EHBBFMCILPC.MANLHALMCIH("OnSketchThumbnailsCdnSuccess", new UnityAction(this.MNJNCFPELEC));
		AOBJLALDBAA.EHBBFMCILPC.MANLHALMCIH("OnSketchThumbnailsCdnFailed", new UnityAction(this.DDGPJJHEHLG));
		AOBJLALDBAA.EHBBFMCILPC.MANLHALMCIH("OnGamePassUnlockContinueToPurchasingScreen", new UnityAction(this.LMJGOIINBIC));
		AOBJLALDBAA.EHBBFMCILPC.MANLHALMCIH("OnFullscreenLiveOfferContinueToPurchasingScreen", new UnityAction(this.GHOHFJCGAMJ));
		AOBJLALDBAA.EHBBFMCILPC.MANLHALMCIH("OnFullscreenLiveOfferContinueToCardsVolSaleMenu", new UnityAction(this.JMBBBIDIHLO));
		AOBJLALDBAA.EHBBFMCILPC.MANLHALMCIH("OnLiveOfferSuccessShowPassesWindow", new UnityAction(this.DLHBCDJOMMC));
		AOBJLALDBAA.EHBBFMCILPC.MANLHALMCIH("OnRestartChapterUpsellGetPassNegative", new UnityAction(this.FAIDPMGBPIF));
		AOBJLALDBAA.EHBBFMCILPC.MANLHALMCIH("OnRestartChapterUpsellGetPassPositive", new UnityAction(this.CJEJENJBDDF));
		AOBJLALDBAA.EHBBFMCILPC.MANLHALMCIH("onLoadingThemeSubscribeRequested", new UnityAction(this.AJPPPKIOGKK));
	}

	// Token: 0x06002289 RID: 8841 RVA: 0x000F661B File Offset: 0x000F481B
	private void MBINGGKGNGM()
	{
		this.GBBHKFFENBE = true;
		AssetsManager.EHBBFMCILPC.ForceStopAllOperations();
		AssetsManager.EHBBFMCILPC.DestroyAssetBundleAssets(NMKDCBPMCKI.AssetBundleLobbyData2, -1);
		SceneManager.LoadScene("SceneOnboarding");
		CommonUserInterface.EHBBFMCILPC.GetFader().FadeOut(null);
	}

	// Token: 0x0600228A RID: 8842 RVA: 0x000F6655 File Offset: 0x000F4855
	private bool IJAAEHODHLB()
	{
		return this.AMHFDOEDOOE();
	}

	// Token: 0x0600228B RID: 8843 RVA: 0x000F665D File Offset: 0x000F485D
	private void CIGEEDJDGGL()
	{
		this.disclaimerImpers.text = CCOJBMMKNAP.GIOAFDDKKHI().HIPJILDCHJC("");
		base.Invoke("cardoptionsloadingthemedone", this.disclaimerImpersLifeTime);
	}

	// Token: 0x0600228C RID: 8844 RVA: 0x000F668A File Offset: 0x000F488A
	private void GHOHFJCGAMJ()
	{
		this.ALGIAIKDEPH();
	}

	// Token: 0x0600228D RID: 8845 RVA: 0x000F6692 File Offset: 0x000F4892
	private IEnumerator LLBEBFGIMKL()
	{
		this.GKHNIMJJLJL.DHONIOBOLEL.KIDGLJCJGLD = 1;
		CommonUserInterface.EHBBFMCILPC.ShowConnectingAnimation(96);
		yield return new WaitForEndOfFrame();
		while (AssetsManager.EHBBFMCILPC.IsBusy())
		{
			DPGJIJGOCIC.NFIDPOMCNLP("SceneLobbyManager2.ShowStorySplash(): AssetsManager.Instance.IsBusy()");
			yield return new WaitForSeconds(0.05f);
		}
		if (this.GKHNIMJJLJL.NCAMFPGMCIG.GGICIBLJIKI < 0)
		{
			CommonUserInterface.EHBBFMCILPC.HideConnectingAnimation();
			DPGJIJGOCIC.ANOPFDLPKGC("SceneLobbyManager.ShowStorySplash() - Body index is negative.");
		}
		else
		{
			if (!KHPGPLAMAIN.CNFPCHNGKPB())
			{
				AssetsManager.EHBBFMCILPC.DestroyAssetBundleAssets(NMKDCBPMCKI.AssetBundleIconsPack, -1);
			}
			if (null != AssetsManager.EHBBFMCILPC.profileDataAsset)
			{
				AssetsManager.EHBBFMCILPC.profileDataAsset.CMPFJLLGKCC();
			}
			AssetsManager.EHBBFMCILPC.DestroyAssetBundleAssets(NMKDCBPMCKI.AssetBundleProfilePack, -1);
			AssetsManager.EHBBFMCILPC.DestroyAssetBundleAssets(NMKDCBPMCKI.AssetBundleLiveProfileTheme, -1);
			AssetsManager.EHBBFMCILPC.DestroyAssetBundleAssets(NMKDCBPMCKI.AssetBundleProfileData6, -1);
			AssetsManager.EHBBFMCILPC.DestroyAssetBundleAssets(NMKDCBPMCKI.AssetBundleCustomFader, -1);
			AssetsManager.EHBBFMCILPC.DestroyAssetBundleAssets(NMKDCBPMCKI.AssetBundleCustomEffects, -1);
			AssetsManager.EHBBFMCILPC.DestroyAssetBundleAssets(NMKDCBPMCKI.AssetBundleNpcAnimationPack, -1);
			AssetsManager.EHBBFMCILPC.DestroyAssetBundleAssets(NMKDCBPMCKI.AssetBundleItemAnimationPack, -1);
			AssetsManager.EHBBFMCILPC.DestroyAssetBundleAssets(NMKDCBPMCKI.AssetBundleFrameContainer, -1);
			AssetsManager.EHBBFMCILPC.DestroyAssetBundleAssets(NMKDCBPMCKI.AssetBundleLobbyData2, -1);
			AssetsManager.EHBBFMCILPC.UnloadPersistentAssetBundles();
			AKLFPGMDKLA.EHBBFMCILPC.IEGJCPDCLMM = this.LDIGGOPHGMI.index;
			if (null != GKJPOGNFKNK.MLDENPHFNPH(AKLFPGMDKLA.EHBBFMCILPC.IEGJCPDCLMM, false))
			{
				AKLFPGMDKLA.EHBBFMCILPC.EJLCEBPHPJE = GKJPOGNFKNK.MLDENPHFNPH(AKLFPGMDKLA.EHBBFMCILPC.IEGJCPDCLMM, false).header.index;
			}
			AKLFPGMDKLA.EHBBFMCILPC.BMBCCPMCAIM(this.LDIGGOPHGMI.index);
			FirebaseAnalyticsManager.EHBBFMCILPC.LogEvent(false, AGEHCPDNBFD.cdnActiv.ToString(), FFPHBMFGCNN.dldStart.ToString(), BGHLMGPPCNN.cdnLbyToSpl.ToString(), false, false);
			if (AKLFPGMDKLA.EHBBFMCILPC.HCEHBFCIIHN() < 1 && 1 == AKLFPGMDKLA.EHBBFMCILPC.MJPKIMHENNF)
			{
				FirebaseAnalyticsManager.EHBBFMCILPC.LogEvent(true, AGEHCPDNBFD.d1Ret.ToString(), FFPHBMFGCNN.d1Board.ToString(), BGHLMGPPCNN.d1SplashCdnSt.ToString(), true, false);
			}
			if (null != this.HFFIIBBJBMH && this.HFFIIBBJBMH.header.enableSplashScreenAudio)
			{
				int num = AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).DHONIOBOLEL.DDEDAHCFHJN();
				if (num < this.LDIGGOPHGMI.chapterAssetPacks.Count)
				{
					AssetsManager.EHBBFMCILPC.QueueAssetBundleDownload(NMKDCBPMCKI.AssetBundleKeepAlivePack, this.HFFIIBBJBMH.header.CKACBBGHJGI(), -1, FLDBFOADFLH.finishDownloadAndProceed, true, false, false, null, -1, (this.LDIGGOPHGMI.chapterAssetPacks[num].skipLoadKeepAliveBundlesForDefaultCompression && NBDLBFJOEGN.OMNHINGKGNP()) || (this.LDIGGOPHGMI.chapterAssetPacks[num].skipLoadKeepAliveBundlesForLowEndDevices && KHPGPLAMAIN.IBDGNKGIMFI() == IIHCCPLGGHP.lowEnd), "", false, false);
				}
			}
			if (null != this.HFFIIBBJBMH && this.HFFIIBBJBMH.header.enableIconsPack)
			{
				AssetsManager.EHBBFMCILPC.QueueAssetBundleDownload(NMKDCBPMCKI.AssetBundleIconsPack, this.HFFIIBBJBMH.header.CKACBBGHJGI(), -1, FLDBFOADFLH.startDownloadAndProceed, false, false, false, null, -1, false, "", false, false);
			}
			if (null != this.HFFIIBBJBMH)
			{
				AssetsManager.EHBBFMCILPC.QueueAssetBundleDownload(NMKDCBPMCKI.AssetBundleProfilePack, this.HFFIIBBJBMH.header.CKACBBGHJGI(), -1, FLDBFOADFLH.startDownloadAndProceed, false, false, false, null, -1, false, "", false, false);
			}
			AssetsManager.EHBBFMCILPC.QueueAssetBundleDownload(NMKDCBPMCKI.AssetBundleStorySplash, this.LDIGGOPHGMI.index, -1, FLDBFOADFLH.finishDownloadAndProceed, false, false, true, null, -1, false, "", this.EPFLNNFPHFE(this.HFFIIBBJBMH), false);
			AssetsManager.EHBBFMCILPC.GetLoadingProgressSnapshot().CLIOEOLFFLO(LEJKDNAGDHC.Fast);
			if (!AKLFPGMDKLA.EHBBFMCILPC.EAFEJCKIEPL(73))
			{
				AssetsManager.EHBBFMCILPC.QueueFrameContainerBundle(0);
			}
			AssetsManager.EHBBFMCILPC.DownloadQueuedAssetBundles("OnLobbyStoryManagerDownloadSplashScreenSuccess", "OnLobbyStoryManagerDownloadSplashScreenFailed", false);
			if (AssetAnthologyPreview2.isLowVersion && SceneLobbyManager2.NeedToReloadPreview2Assets())
			{
				DPGJIJGOCIC.ADFCDFHBDAF("High/low version preview2 assets scheme will be re-loaded: need to update featured section assets from low to high.");
			}
		}
		yield break;
	}

	// Token: 0x0600228E RID: 8846 RVA: 0x000F66A4 File Offset: 0x000F48A4
	private bool AOKDEICAFMM(string IGPPDLNCBME)
	{
		if (IGPPDLNCBME == null || IGPPDLNCBME.Length == 0 || IGPPDLNCBME.Length > 26)
		{
			return true;
		}
		IGPPDLNCBME = this.GDAPJCHEDOK(IGPPDLNCBME);
		for (int i = 0; i < this.JECFMCGHNGC.Count; i++)
		{
			if (string.Equals(this.JECFMCGHNGC[i], IGPPDLNCBME, StringComparison.OrdinalIgnoreCase))
			{
				return true;
			}
		}
		if (this.JECFMCGHNGC.Count >= 5)
		{
			return false;
		}
		this.JECFMCGHNGC.Add(IGPPDLNCBME);
		return true;
	}

	// Token: 0x0600228F RID: 8847 RVA: 0x000F671B File Offset: 0x000F491B
	private void JEKCPAGMFBE()
	{
		this.GBBHKFFENBE = true;
		SaveSlotsItem.ClearCopyMarker();
	}

	// Token: 0x06002290 RID: 8848 RVA: 0x000F672C File Offset: 0x000F492C
	private void NELHGHFAGFH()
	{
		CommonUserInterface.EHBBFMCILPC.HideConnectingAnimation();
		this.NEEMPAAFHEI = 0;
		MEAHFFHIACD.EHBBFMCILPC.BAMHPOCKBML(LanguageManager.EHBBFMCILPC.GetSelectedLanguage());
		try
		{
			AssetsManager.EHBBFMCILPC.profileDataAsset.FCFBJGCPFFB();
			IOGOGMEJCIK.EHBBFMCILPC.LMIGKJJBFPM();
			AKLFPGMDKLA.EHBBFMCILPC.OKGGLHOCENC.KJANHNKJMKF();
			AKLFPGMDKLA.EHBBFMCILPC.OKGGLHOCENC.AAHPPDCDNCC();
			AKLFPGMDKLA.EHBBFMCILPC.OKGGLHOCENC.MGCCGKOEJCN(false);
			AKLFPGMDKLA.EHBBFMCILPC.OKGGLHOCENC.MGCCGKOEJCN(true);
			IOGOGMEJCIK.EHBBFMCILPC.KOHINGHLPDM();
			IOGOGMEJCIK.EHBBFMCILPC.EGFKMLPLMFA();
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
		this.IMCJMMDJOAH(AKLFPGMDKLA.EHBBFMCILPC.OKGGLHOCENC);
		if (!ProfileItem2.profileWindowActive)
		{
			this.GBBHKFFENBE = false;
		}
	}

	// Token: 0x06002291 RID: 8849 RVA: 0x000F6800 File Offset: 0x000F4A00
	private SceneLobbyManager2.LDGNIDMIIIA BAKAHKFKAHL(int PLKMJJIIJNO)
	{
		SceneLobbyManager2.LDGNIDMIIIA ldgnidmiiia = null;
		if (this.BBNFIHLCHAO.TryGetValue(PLKMJJIIJNO, out ldgnidmiiia))
		{
			return ldgnidmiiia;
		}
		ldgnidmiiia = new SceneLobbyManager2.LDGNIDMIIIA();
		try
		{
			ldgnidmiiia.FKCNMAEBNNK = this.DCPEGOONIJM(PLKMJJIIJNO, this.FODKLALANIM);
			if (ldgnidmiiia.FKCNMAEBNNK != null)
			{
				ldgnidmiiia.AIJFJMKHAOO.AddRange(this.FODKLALANIM);
				ldgnidmiiia.MEHHECKMOAD = ((ldgnidmiiia.AIJFJMKHAOO.Count > 0) ? ldgnidmiiia.AIJFJMKHAOO[0] : null);
				for (int i = 0; i < ldgnidmiiia.AIJFJMKHAOO.Count; i++)
				{
					if (this.LNNMAMLCBMF(ldgnidmiiia.FKCNMAEBNNK, ldgnidmiiia.AIJFJMKHAOO[i]))
					{
						ldgnidmiiia.JCMIJCCCCLC = ldgnidmiiia.AIJFJMKHAOO[i];
						break;
					}
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
		if (ldgnidmiiia.FKCNMAEBNNK != null || MLIBDDCCKBM.FACIFBONANM() || KDCJJBLGCBH.EHBBFMCILPC.GNGCDGBAALO())
		{
			this.BBNFIHLCHAO[PLKMJJIIJNO] = ldgnidmiiia;
		}
		return ldgnidmiiia;
	}

	// Token: 0x06002292 RID: 8850 RVA: 0x000F68FC File Offset: 0x000F4AFC
	public void OnFavoritesDeactivate()
	{
		JBBNEEHANHL jbbneehanhl = JBBNEEHANHL.filterFavorites;
		if (AKLFPGMDKLA.EHBBFMCILPC.JCBEPJJHAII(AssetsManager.EHBBFMCILPC.anthologyAssets).Count <= 0)
		{
			FilterItem[] componentsInChildren = this.scrollView2Controller.GetComponentsInChildren<FilterItem>(true);
			for (int i = 0; i < componentsInChildren.Count<FilterItem>(); i++)
			{
				if (componentsInChildren[i].id == jbbneehanhl)
				{
					FilterItem filterItem = null;
					int siblingIndex = componentsInChildren[i].transform.GetSiblingIndex();
					int childCount = this.filterItemsParent.transform.childCount;
					for (int j = 1; j < childCount; j++)
					{
						int index = (siblingIndex + j) % childCount;
						FilterItem component = this.filterItemsParent.transform.GetChild(index).GetComponent<FilterItem>();
						if (!(null == component) && component.gameObject.activeSelf && jbbneehanhl != component.id && JBBNEEHANHL.filterSearch != component.id)
						{
							filterItem = component;
							break;
						}
					}
					if (null == filterItem)
					{
						DPGJIJGOCIC.ANOPFDLPKGC("SceneLobbyManager2.OnFavoritesDeactivate() - no active filter tab left to switch to");
						return;
					}
					filterItem.toggle.isOn = true;
					this.BCOOKJICILK(filterItem.id);
					componentsInChildren[i].toggle.isOn = false;
					componentsInChildren[i].gameObject.SetActive(false);
				}
			}
			foreach (GridController gridController in this.scrollView0Controller.GetComponentsInChildren<GridController>(true))
			{
				if (gridController.filter == jbbneehanhl && !SceneLobbyManager2.IsGroupedFilter(jbbneehanhl))
				{
					gridController.gameObject.SetActive(false);
					gridController.transform.SetSiblingIndex(4);
					foreach (ThumbnailItem thumbnailItem in gridController.GetComponentsInChildren<ThumbnailItem>(true))
					{
						if (thumbnailItem.index == this.focusItem.GetComponent<FocusItem>().currentAnthologyIndex)
						{
							UnityEngine.Object.Destroy(thumbnailItem.gameObject);
						}
					}
				}
			}
			this.LGKCHPBIIGA(false);
			return;
		}
		foreach (GridController gridController2 in this.scrollView0Controller.GetComponentsInChildren<GridController>(true))
		{
			if (gridController2.filter == jbbneehanhl && !SceneLobbyManager2.IsGroupedFilter(jbbneehanhl))
			{
				foreach (ThumbnailItem thumbnailItem2 in gridController2.GetComponentsInChildren<ThumbnailItem>(true))
				{
					if (thumbnailItem2.index == this.focusItem.GetComponent<FocusItem>().currentAnthologyIndex)
					{
						UnityEngine.Object.Destroy(thumbnailItem2.gameObject);
						base.StartCoroutine(this.OIFMCGLDCJK(gridController2.gameObject));
					}
				}
			}
		}
		this.LGKCHPBIIGA(false);
	}

	// Token: 0x06002293 RID: 8851 RVA: 0x000F6B7C File Offset: 0x000F4D7C
	public void OnSetupRecommendedFinalize()
	{
		AKLFPGMDKLA.EHBBFMCILPC.IJMCBDIKMAB(10);
		AKLFPGMDKLA.EHBBFMCILPC.IJMCBDIKMAB(11);
		AKLFPGMDKLA.EHBBFMCILPC.IJMCBDIKMAB(12);
		AKLFPGMDKLA.EHBBFMCILPC.IJMCBDIKMAB(13);
		AKLFPGMDKLA.EHBBFMCILPC.IJMCBDIKMAB(14);
		SceneOnboardingManager.startAtStep = 3;
		CommonUserInterface.EHBBFMCILPC.GetFader().FadeIn(new TweenCallback(this.MBINGGKGNGM));
	}

	// Token: 0x06002294 RID: 8852 RVA: 0x000F668A File Offset: 0x000F488A
	private void POGLMDJIAAI()
	{
		this.ALGIAIKDEPH();
	}

	// Token: 0x06002295 RID: 8853 RVA: 0x000F6BE6 File Offset: 0x000F4DE6
	private IEnumerator MNBHMJPGHAG()
	{
		this.GBBHKFFENBE = true;
		AssetsManager.EHBBFMCILPC.ForceStopAllOperations();
		yield return new WaitForEndOfFrame();
		while (AssetsManager.EHBBFMCILPC.IsBusy())
		{
			DPGJIJGOCIC.NFIDPOMCNLP("SceneLobbyManager2.PreInitializeAssetBundleFolder(): AssetsManager.Instance.IsBusy()");
			yield return new WaitForSeconds(0.05f);
		}
		base.StartCoroutine(this.HNKPMLGCKHO());
		yield break;
	}

	// Token: 0x06002296 RID: 8854 RVA: 0x000F6BF5 File Offset: 0x000F4DF5
	private void IEALAHCOPKC()
	{
		this.MBGPADGCJBM = false;
	}

	// Token: 0x06002297 RID: 8855 RVA: 0x000F6C00 File Offset: 0x000F4E00
	private void BIBDIFGBHPI()
	{
		for (int i = 0; i < this.wheelItem.GetComponent<WheelItem>().lobbyCanvases.Count; i++)
		{
			this.wheelItem.GetComponent<WheelItem>().lobbyCanvases[i].enabled = false;
		}
	}

	// Token: 0x06002298 RID: 8856 RVA: 0x000F6C4C File Offset: 0x000F4E4C
	public void OnPopupNotEnoughEnergyOrHardCurrencyDecline()
	{
		LMHHKDFCKFC lmhhkdfckfc = AKLFPGMDKLA.EHBBFMCILPC.PNLLCLPMIGA();
		if (lmhhkdfckfc != null && PurchaseManagerBridge.EHBBFMCILPC.GetPurchaseManager().GetProductData(lmhhkdfckfc.DEJCCBNPFEC) != null)
		{
			CommonUserInterface.EHBBFMCILPC.ShowPopupOffer(lmhhkdfckfc.DEJCCBNPFEC, CommonUserInterface.EHBBFMCILPC.GetPurchasingViewManager().GetProductThumbnailGraphics(lmhhkdfckfc.DEJCCBNPFEC));
		}
	}

	// Token: 0x06002299 RID: 8857 RVA: 0x000F6CA4 File Offset: 0x000F4EA4
	public void OnPopupCardOptionsReopen()
	{
		if (PopupCardOptions.reopenCardOptionsFlag && PopupCardOptions.showType == HKPBEDBPHNJ.purchaseCardLobby)
		{
			if (this.OGHHLFOEJKO != null)
			{
				this.EJECJLAAHLE = true;
			}
			PopupCardOptions.reopenCardOptionsFlag = false;
			LJNMIPMNOKF.EHBBFMCILPC.DENIEGBICKJ();
			if (LJNMIPMNOKF.EHBBFMCILPC.JDDHHIOIAOJ() > 0)
			{
				this.ShowCardOptionsOrDownload();
			}
		}
	}

	// Token: 0x0600229A RID: 8858 RVA: 0x000F6CF2 File Offset: 0x000F4EF2
	private void ALPMLMMFNBM()
	{
		this.ActivateFilter(JBBNEEHANHL.filterNew);
	}

	// Token: 0x0600229B RID: 8859 RVA: 0x000F6CFC File Offset: 0x000F4EFC
	private float IHANGMOKOOA()
	{
		float num = 0f;
		for (int i = 0; i < this.CIBDADPLOMG.Count; i++)
		{
			if (this.CIBDADPLOMG[i].AGMOECJFFJI > num)
			{
				num = this.CIBDADPLOMG[i].AGMOECJFFJI;
			}
		}
		if (num <= 0f)
		{
			return 1f;
		}
		return num;
	}

	// Token: 0x0600229C RID: 8860 RVA: 0x000F6D5A File Offset: 0x000F4F5A
	private void BAGNOCIMPBD()
	{
		DPGJIJGOCIC.ADFCDFHBDAF("SceneLobbyManager2.OnLiveProfileThumbnailsCdnFailed()");
	}

	// Token: 0x0600229D RID: 8861 RVA: 0x000F6D66 File Offset: 0x000F4F66
	private void JDFKJADDMAN()
	{
		if (AKLFPGMDKLA.EHBBFMCILPC.EEHGLPEIIHD != null && AKLFPGMDKLA.EHBBFMCILPC.EEHGLPEIIHD.Length > 0)
		{
			LPOMOIFMNFD.BAHMNEGPBMM(AKLFPGMDKLA.EHBBFMCILPC.EEHGLPEIIHD);
		}
		Application.Quit();
	}

	// Token: 0x0600229E RID: 8862 RVA: 0x000F6D9C File Offset: 0x000F4F9C
	private void GAPBNDBHPCP()
	{
		try
		{
			if (!(null == this.FIBKHPMLNJN))
			{
				FilterItem component = this.FIBKHPMLNJN.GetComponent<FilterItem>();
				if (null != component)
				{
					component.StopPulse();
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x0600229F RID: 8863 RVA: 0x000F6DF0 File Offset: 0x000F4FF0
	private IEnumerator IAPKPMHMIIA()
	{
		yield return new WaitForSeconds(1f);
		CommonUserInterface.EHBBFMCILPC.ShowGenericPopup(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("importanttitle"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("saveslotsdeletepos"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("ok"), DFGILFBGPLN.popupEnergyHint, 0f, 28);
		CommonUserInterface.EHBBFMCILPC.ResumeUX();
		AssetsManager.EHBBFMCILPC.DestroyAssetBundleAssets(NMKDCBPMCKI.AssetBundleCollectableCard, -1);
		yield break;
	}

	// Token: 0x060022A0 RID: 8864 RVA: 0x000F6DF8 File Offset: 0x000F4FF8
	private void LHHMOOBDGGO()
	{
		try
		{
			if (!(null == this.FIBKHPMLNJN) && this.FIBKHPMLNJN.activeInHierarchy)
			{
				FilterItem component = this.FIBKHPMLNJN.GetComponent<FilterItem>();
				if (null != component)
				{
					component.KDEMPDFNIHI();
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x060022A1 RID: 8865 RVA: 0x000F668A File Offset: 0x000F488A
	private void CPEELJJHCNA()
	{
		this.ALGIAIKDEPH();
	}

	// Token: 0x060022A2 RID: 8866 RVA: 0x000F6E58 File Offset: 0x000F5058
	private void PACLPFDOHEI()
	{
		CommonUserInterface.EHBBFMCILPC.HideConnectingAnimation();
		this.CFKMKEGMFJH();
	}

	// Token: 0x060022A3 RID: 8867 RVA: 0x000F6E6C File Offset: 0x000F506C
	private void IMCJMMDJOAH(PMEPALPCEAF FOKFGMIEEDB)
	{
		try
		{
			if (FOKFGMIEEDB != null)
			{
				DPGJIJGOCIC.NFIDPOMCNLP("SocialStatsUserPublicProfile.modified = false, OpenUserPublicProfile()");
				ContentAvatarPage.closeProfileAndOpenWheelOfFortune = false;
				HBKMKCBPJDI.NBLBPEJOFPC = false;
				FOKFGMIEEDB.CHCBHLIBGFA = false;
				this.profileFade2.SetActive(true);
				this.profileItem2.GetComponent<ProfileItem2>().UpdateContent(FOKFGMIEEDB, AMMHDNONFHM.MyProfile);
				base.StartCoroutine(this.FINPCOMDIFD(this.profileFade2, this.profileItem2, this.timeFocusItemAnimation, true));
				if (!AKLFPGMDKLA.EHBBFMCILPC.GNLNPMPJPEC())
				{
					if (!AKLFPGMDKLA.EHBBFMCILPC.EAFEJCKIEPL(23))
					{
						AKLFPGMDKLA.EHBBFMCILPC.LDAPMNLGAPC(23);
					}
					else if (!AKLFPGMDKLA.EHBBFMCILPC.EAFEJCKIEPL(24))
					{
						AKLFPGMDKLA.EHBBFMCILPC.LDAPMNLGAPC(24);
						if (JGLMNGOLBIG.EHBBFMCILPC.ENDDKMPKINP() == 0)
						{
							CommonUserInterface.EHBBFMCILPC.ShowGenericPopup(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("importanttitle"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("mypsuspintrobody"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("mypsuspintrobtn"), DFGILFBGPLN.popupTools, 0.75f, 28);
						}
					}
				}
				FirebaseAnalyticsManager.EHBBFMCILPC.LogEvent(false, AGEHCPDNBFD.socActiv.ToString(), FFPHBMFGCNN.socView.ToString(), "", false, false);
				try
				{
					List<int> list = FOKFGMIEEDB.FCCNNMOIMGC();
					if (AKLFPGMDKLA.EHBBFMCILPC.KLPBIGJBOBE == 1)
					{
						if (list.Count <= 10)
						{
							FirebaseAnalyticsManager.EHBBFMCILPC.LogEvent(false, AGEHCPDNBFD.ecnmyPayer.ToString(), FFPHBMFGCNN.colCds.ToString(), BGHLMGPPCNN.under10.ToString(), false, false);
						}
						else if (list.Count <= 50)
						{
							FirebaseAnalyticsManager.EHBBFMCILPC.LogEvent(false, AGEHCPDNBFD.ecnmyPayer.ToString(), FFPHBMFGCNN.colCds.ToString(), BGHLMGPPCNN.under50.ToString(), false, false);
						}
						else if (list.Count <= 100)
						{
							FirebaseAnalyticsManager.EHBBFMCILPC.LogEvent(false, AGEHCPDNBFD.ecnmyPayer.ToString(), FFPHBMFGCNN.colCds.ToString(), BGHLMGPPCNN.under100.ToString(), false, false);
						}
						else if (list.Count <= 500)
						{
							FirebaseAnalyticsManager.EHBBFMCILPC.LogEvent(false, AGEHCPDNBFD.ecnmyPayer.ToString(), FFPHBMFGCNN.colCds.ToString(), BGHLMGPPCNN.under500.ToString(), false, false);
						}
						else if (list.Count <= 1000)
						{
							FirebaseAnalyticsManager.EHBBFMCILPC.LogEvent(false, AGEHCPDNBFD.ecnmyPayer.ToString(), FFPHBMFGCNN.colCds.ToString(), BGHLMGPPCNN.under1000.ToString(), false, false);
						}
					}
					else if (list.Count <= 10)
					{
						FirebaseAnalyticsManager.EHBBFMCILPC.LogEvent(false, AGEHCPDNBFD.ecnmyFree.ToString(), FFPHBMFGCNN.colCds.ToString(), BGHLMGPPCNN.under10.ToString(), false, false);
					}
					else if (list.Count <= 50)
					{
						FirebaseAnalyticsManager.EHBBFMCILPC.LogEvent(false, AGEHCPDNBFD.ecnmyFree.ToString(), FFPHBMFGCNN.colCds.ToString(), BGHLMGPPCNN.under50.ToString(), false, false);
					}
					else if (list.Count <= 100)
					{
						FirebaseAnalyticsManager.EHBBFMCILPC.LogEvent(false, AGEHCPDNBFD.ecnmyFree.ToString(), FFPHBMFGCNN.colCds.ToString(), BGHLMGPPCNN.under100.ToString(), false, false);
					}
					else if (list.Count <= 500)
					{
						FirebaseAnalyticsManager.EHBBFMCILPC.LogEvent(false, AGEHCPDNBFD.ecnmyFree.ToString(), FFPHBMFGCNN.colCds.ToString(), BGHLMGPPCNN.under500.ToString(), false, false);
					}
					else if (list.Count <= 1000)
					{
						FirebaseAnalyticsManager.EHBBFMCILPC.LogEvent(false, AGEHCPDNBFD.ecnmyFree.ToString(), FFPHBMFGCNN.colCds.ToString(), BGHLMGPPCNN.under1000.ToString(), false, false);
					}
					int num = FOKFGMIEEDB.MKABKEDMLMI();
					if (num <= 10)
					{
						FirebaseAnalyticsManager.EHBBFMCILPC.LogEvent(false, AGEHCPDNBFD.socFriend.ToString(), FFPHBMFGCNN.frCount.ToString(), BGHLMGPPCNN.under10.ToString(), false, false);
					}
					else if (num <= 30)
					{
						FirebaseAnalyticsManager.EHBBFMCILPC.LogEvent(false, AGEHCPDNBFD.socFriend.ToString(), FFPHBMFGCNN.frCount.ToString(), BGHLMGPPCNN.under30.ToString(), false, false);
					}
					else if (num <= 50)
					{
						FirebaseAnalyticsManager.EHBBFMCILPC.LogEvent(false, AGEHCPDNBFD.socFriend.ToString(), FFPHBMFGCNN.frCount.ToString(), BGHLMGPPCNN.under50.ToString(), false, false);
					}
					else if (list.Count <= 100)
					{
						FirebaseAnalyticsManager.EHBBFMCILPC.LogEvent(false, AGEHCPDNBFD.socFriend.ToString(), FFPHBMFGCNN.frCount.ToString(), BGHLMGPPCNN.under100.ToString(), false, false);
					}
				}
				catch (Exception aklgbjkdomm)
				{
					DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
				}
			}
		}
		catch (Exception aklgbjkdomm2)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm2);
		}
	}

	// Token: 0x060022A4 RID: 8868 RVA: 0x000F742C File Offset: 0x000F562C
	private NDHKFLHAFNA FFPFFJJONCF(int PLKMJJIIJNO)
	{
		NDHKFLHAFNA ndhkflhafna = this.PMFMEBGNCME[PLKMJJIIJNO];
		if (this.EEGHJFAIMBF.Contains(PLKMJJIIJNO))
		{
			if (NDHKFLHAFNA.hintEditorsChoice != ndhkflhafna && (NDHKFLHAFNA)(-3) != ndhkflhafna && (NDHKFLHAFNA)(-106) != ndhkflhafna)
			{
				ndhkflhafna = NDHKFLHAFNA.hintNewStory;
			}
			return ndhkflhafna;
		}
		return ndhkflhafna;
	}

	// Token: 0x060022A5 RID: 8869 RVA: 0x000F7464 File Offset: 0x000F5664
	private void PCLAANFABBB()
	{
		KIOOJMGLCLC kioojmglclc = ODLJHDIGLGO.MNALIKIMKFC(CLHDENLPOFP.gamePass, true);
		int num = 1;
		if (kioojmglclc != null)
		{
			num = KDCJJBLGCBH.EHBBFMCILPC.AAGICPKFIKC(KDCJJBLGCBH.EHBBFMCILPC.HHONCLBBHPG(kioojmglclc.LLLJOBODOAL), DAMCJCDKOJK.gpbpIncentAdMultiplier, 1 == AKLFPGMDKLA.EHBBFMCILPC.DCIPLNCLIMF);
		}
		this.notificationFreeDiamondsText.text = "+" + (KDCJJBLGCBH.EHBBFMCILPC.NEOIABIBJOI(0) * num).ToString();
		this.notificationFreeDiamondsText.SetText("+" + (KDCJJBLGCBH.EHBBFMCILPC.NEOIABIBJOI(0) * num).ToString(), true);
	}

	// Token: 0x060022A6 RID: 8870 RVA: 0x000F74FD File Offset: 0x000F56FD
	private void AMMBPNFINOH()
	{
		DPGJIJGOCIC.NFIDPOMCNLP("Declined Option picked");
		PlayerPrefs.SetInt("ratePopupResult", 4);
		PlayerPrefs.Save();
	}

	// Token: 0x060022A7 RID: 8871 RVA: 0x000F751C File Offset: 0x000F571C
	private bool BGAHIHIOJOJ(string MKAICFMEEII)
	{
		return NDHKFLHAFNA.hintInDevelopment.ToString().Equals(MKAICFMEEII) || NDHKFLHAFNA.hintOnHiatus.ToString().Equals(MKAICFMEEII) || NDHKFLHAFNA.hintDiscontinued.ToString().Equals(MKAICFMEEII);
	}

	// Token: 0x060022A8 RID: 8872 RVA: 0x000F7570 File Offset: 0x000F5770
	public void FJCDOGINLHJ()
	{
		JBBNEEHANHL jbbneehanhl = (JBBNEEHANHL)(-111);
		if (AKLFPGMDKLA.EHBBFMCILPC.IGLLOABLMGM(AssetsManager.EHBBFMCILPC.anthologyAssets).Count <= 0)
		{
			FilterItem[] componentsInChildren = this.scrollView2Controller.GetComponentsInChildren<FilterItem>(true);
			for (int i = 1; i < componentsInChildren.Count<FilterItem>(); i++)
			{
				if (componentsInChildren[i].id == jbbneehanhl)
				{
					FilterItem filterItem = null;
					int siblingIndex = componentsInChildren[i].transform.GetSiblingIndex();
					int childCount = this.filterItemsParent.transform.childCount;
					for (int j = 1; j < childCount; j++)
					{
						int index = (siblingIndex + j) % childCount;
						FilterItem component = this.filterItemsParent.transform.GetChild(index).GetComponent<FilterItem>();
						if (!(null == component) && component.gameObject.activeSelf && jbbneehanhl != component.id && (JBBNEEHANHL)108 != component.id)
						{
							filterItem = component;
							break;
						}
					}
					if (null == filterItem)
					{
						DPGJIJGOCIC.ANOPFDLPKGC("socialprivatenohalloffame");
						return;
					}
					filterItem.toggle.isOn = true;
					this.FIPGMHIMFMK(filterItem.id);
					componentsInChildren[i].toggle.isOn = true;
					componentsInChildren[i].gameObject.SetActive(true);
				}
			}
			GridController[] componentsInChildren2 = this.scrollView0Controller.GetComponentsInChildren<GridController>(true);
			for (int k = 1; k < componentsInChildren2.Length; k += 0)
			{
				GridController gridController = componentsInChildren2[k];
				if (gridController.filter == jbbneehanhl && !SceneLobbyManager2.IsGroupedFilter(jbbneehanhl))
				{
					gridController.gameObject.SetActive(false);
					gridController.transform.SetSiblingIndex(7);
					ThumbnailItem[] componentsInChildren3 = gridController.GetComponentsInChildren<ThumbnailItem>(false);
					for (int l = 1; l < componentsInChildren3.Length; l++)
					{
						ThumbnailItem thumbnailItem = componentsInChildren3[l];
						if (thumbnailItem.index == this.focusItem.GetComponent<FocusItem>().currentAnthologyIndex)
						{
							UnityEngine.Object.Destroy(thumbnailItem.gameObject);
						}
					}
				}
			}
			this.LGKCHPBIIGA(false);
			return;
		}
		foreach (GridController gridController2 in this.scrollView0Controller.GetComponentsInChildren<GridController>(true))
		{
			if (gridController2.filter == jbbneehanhl && !SceneLobbyManager2.IsGroupedFilter(jbbneehanhl))
			{
				foreach (ThumbnailItem thumbnailItem2 in gridController2.GetComponentsInChildren<ThumbnailItem>(false))
				{
					if (thumbnailItem2.index == this.focusItem.GetComponent<FocusItem>().currentAnthologyIndex)
					{
						UnityEngine.Object.Destroy(thumbnailItem2.gameObject);
						base.StartCoroutine(this.OIFMCGLDCJK(gridController2.gameObject));
					}
				}
			}
		}
		this.LGKCHPBIIGA(false);
	}

	// Token: 0x060022A9 RID: 8873 RVA: 0x000F77F0 File Offset: 0x000F59F0
	private void LDENMOBNFIP()
	{
		CommonUserInterface.EHBBFMCILPC.ShowGenericPopup(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("emailcollecheader"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("emailcollectthanks0"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("ok"), DFGILFBGPLN.popupTools, 0f, 28);
	}

	// Token: 0x060022AA RID: 8874 RVA: 0x000F7840 File Offset: 0x000F5A40
	public int GetAnthologyAvailableChaptersCount(int PLKMJJIIJNO)
	{
		int result;
		try
		{
			int num = 0;
			for (int i = 0; i < AssetsManager.EHBBFMCILPC.anthologyAssets.Count; i++)
			{
				if (AssetsManager.EHBBFMCILPC.anthologyAssets[i].header.index == PLKMJJIIJNO)
				{
					for (int j = 0; j < AssetsManager.EHBBFMCILPC.anthologyAssets[i].header.maxStories; j++)
					{
						if (j < AssetsManager.EHBBFMCILPC.anthologyAssets[i].header.availableStories.Count)
						{
							AssetStoryHeader assetStoryHeader = GKJPOGNFKNK.CDCEFHLNNEC(AssetsManager.EHBBFMCILPC.anthologyAssets[i].header.availableStories[j]);
							if (null != assetStoryHeader)
							{
								num += assetStoryHeader.availableChaptersCount;
							}
						}
					}
				}
			}
			result = num;
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
			result = 0;
		}
		return result;
	}

	// Token: 0x060022AB RID: 8875 RVA: 0x000F792C File Offset: 0x000F5B2C
	private string[] EDHCEJMLPEO(int PLKMJJIIJNO, string[] EKPANFDMKON, JBBNEEHANHL HBBJBNJBMPK)
	{
		try
		{
			if (EKPANFDMKON == null || EKPANFDMKON.Length == 0)
			{
				return null;
			}
			if (EKPANFDMKON.Length >= 2)
			{
				return EKPANFDMKON;
			}
			string text = null;
			if (JBBNEEHANHL.filterSearch == HBBJBNJBMPK)
			{
				string[] array = null;
				if (this.IIDEKJNAFKG.TryGetValue(PLKMJJIIJNO, out array) && array != null)
				{
					for (int i = 0; i < array.Length; i++)
					{
						if (!string.IsNullOrEmpty(array[i]) && !string.Equals(array[i], EKPANFDMKON[0], StringComparison.OrdinalIgnoreCase))
						{
							text = array[i];
							break;
						}
					}
				}
			}
			if (text == null)
			{
				SceneLobbyManager2.LDGNIDMIIIA ldgnidmiiia = this.BAKAHKFKAHL(PLKMJJIIJNO);
				if (ldgnidmiiia != null && ldgnidmiiia.FKCNMAEBNNK != null)
				{
					if (string.Equals(ldgnidmiiia.FKCNMAEBNNK, EKPANFDMKON[0], StringComparison.OrdinalIgnoreCase))
					{
						text = ((ldgnidmiiia.JCMIJCCCCLC != null) ? ldgnidmiiia.JCMIJCCCCLC : ldgnidmiiia.MEHHECKMOAD);
					}
					else
					{
						text = ldgnidmiiia.FKCNMAEBNNK;
					}
				}
			}
			if (text == null || string.Equals(text, EKPANFDMKON[0], StringComparison.OrdinalIgnoreCase))
			{
				return EKPANFDMKON;
			}
			return new string[]
			{
				EKPANFDMKON[0],
				text
			};
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
		return EKPANFDMKON;
	}

	// Token: 0x060022AC RID: 8876 RVA: 0x000F7A2C File Offset: 0x000F5C2C
	private int GKCNIFOCLOL(ECAPOEGMMIB DCEEBNNKPGJ)
	{
		try
		{
			if (DCEEBNNKPGJ.KPPJINFHMIP == null || DCEEBNNKPGJ.KPPJINFHMIP.Length == 0 || DCEEBNNKPGJ.IHMEFMPMDFC <= 0)
			{
				return 0;
			}
			if (!NBDLBFJOEGN.NDFLNHIAKJH() || AKLFPGMDKLA.EHBBFMCILPC.BFKIHOBDNNB())
			{
				return 0;
			}
			if (!this.HFFIIBBJBMH.header.availableStories.Contains(DCEEBNNKPGJ.IHMEFMPMDFC))
			{
				DPGJIJGOCIC.ADFCDFHBDAF(string.Concat(new string[]
				{
					"[Lounge/lobby] wardrobe music pack mps:",
					DCEEBNNKPGJ.IHMEFMPMDFC.ToString(),
					" is OUTSIDE the anthology's story family - not queued (clip:",
					DCEEBNNKPGJ.KPPJINFHMIP,
					")"
				}));
				return 0;
			}
			if (AudioManager.EHBBFMCILPC.AudioClipAvailable(CCEMAFOMLLK.music, DCEEBNNKPGJ.KPPJINFHMIP))
			{
				return 0;
			}
			string item = "abs" + DCEEBNNKPGJ.IHMEFMPMDFC.ToString() + "asp" + DCEEBNNKPGJ.OAMJJIFAAHJ.ToString();
			if (this.IBBHBBNAOKL.Contains(item))
			{
				return 0;
			}
			this.IBBHBBNAOKL.Add(item);
			string item2 = OMIMIKMIMFE.NCDEKILOHGF(NMKDCBPMCKI.AssetBundleStoryAssetPack, DCEEBNNKPGJ.IHMEFMPMDFC, DCEEBNNKPGJ.OAMJJIFAAHJ, -1);
			if (!this.HHILBMHMJBH.Contains(item2))
			{
				this.HHILBMHMJBH.Add(item2);
			}
			AssetsManager.EHBBFMCILPC.QueueAssetBundleDownload(NMKDCBPMCKI.AssetBundleStoryAssetPack, DCEEBNNKPGJ.IHMEFMPMDFC, DCEEBNNKPGJ.OAMJJIFAAHJ, FLDBFOADFLH.startDownloadAndProceed, true, true, false, null, 900000, false, "", false, false);
			return 1;
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
		return 0;
	}

	// Token: 0x060022AD RID: 8877 RVA: 0x000F7BBC File Offset: 0x000F5DBC
	private void DHFFJJHIHKO()
	{
		if (null != this.LGKGGPDKAHF)
		{
			try
			{
				this.UpdateAnthologiesHints();
			}
			catch (Exception aklgbjkdomm)
			{
				DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
			}
			AKLFPGMDKLA.EHBBFMCILPC.LPCBDEBKAIM();
			CommonUserInterface.EHBBFMCILPC.ShowConnectingAnimationWithHint(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("serversync"), 96);
			BackendOperationsManager.EHBBFMCILPC.QueueRequestSaveChapterSnapshots();
			BackendOperationsManager.EHBBFMCILPC.QueueRequestSaveAvatarCollections();
			BackendOperationsManager.EHBBFMCILPC.RequestSaveSync("OnSaveSyncAnyResultDuplicate", "OnSaveSyncAnyResultDuplicate");
			SaveSlotsItem.slotDeleted = false;
			SaveSlotsItem.slotEdited = false;
			SaveSlotsItem.slotChanged = false;
			SaveSlotsItem.slotDuplicated = false;
			return;
		}
		AKLFPGMDKLA.EHBBFMCILPC.LPCBDEBKAIM();
		BackendOperationsManager.EHBBFMCILPC.QueueRequestSaveChapterSnapshots();
		BackendOperationsManager.EHBBFMCILPC.QueueRequestSaveAvatarCollections();
		BackendOperationsManager.EHBBFMCILPC.RequestSaveSync("", "");
		SaveSlotsItem.slotDeleted = false;
		SaveSlotsItem.slotEdited = false;
		SaveSlotsItem.slotChanged = false;
		SaveSlotsItem.slotDuplicated = false;
		CommonUserInterface.EHBBFMCILPC.ResumeUX();
	}

	// Token: 0x060022AE RID: 8878 RVA: 0x000F7CB4 File Offset: 0x000F5EB4
	private bool FKKMJNADLHJ(int PLKMJJIIJNO, string AFHIPGHANJE)
	{
		List<SceneLobbyManager2.BBNDCCPKNJL> list = this.LEAJJAFAKLH(PLKMJJIIJNO);
		if (list == null || AFHIPGHANJE == null)
		{
			return true;
		}
		for (int i = 0; i < list.Count; i++)
		{
			if (string.Equals(list[i].IEIAICGOENJ, AFHIPGHANJE, (StringComparison)8))
			{
				return list[i].OKJNEMPGHDJ;
			}
		}
		return false;
	}

	// Token: 0x060022AF RID: 8879 RVA: 0x000F7D08 File Offset: 0x000F5F08
	private void JNKEHEBNBAP()
	{
		KIOOJMGLCLC kioojmglclc = ODLJHDIGLGO.MNALIKIMKFC(CLHDENLPOFP.gamePass, true);
		int num = 1;
		if (kioojmglclc != null)
		{
			num = KDCJJBLGCBH.EHBBFMCILPC.AAGICPKFIKC(KDCJJBLGCBH.EHBBFMCILPC.HHONCLBBHPG(kioojmglclc.LLLJOBODOAL), DAMCJCDKOJK.gpbpIncentAdMultiplier, 1 == AKLFPGMDKLA.EHBBFMCILPC.DCIPLNCLIMF);
		}
		this.notificationFreeDiamondsHiddenText.text = "+" + (KDCJJBLGCBH.EHBBFMCILPC.NEOIABIBJOI(0) * num).ToString();
		this.notificationFreeDiamondsHiddenText.SetText("+" + (KDCJJBLGCBH.EHBBFMCILPC.NEOIABIBJOI(0) * num).ToString(), true);
	}

	// Token: 0x060022B0 RID: 8880 RVA: 0x000F7DA4 File Offset: 0x000F5FA4
	private void ICKLABCOKMO()
	{
		List<int> list = AKLFPGMDKLA.EHBBFMCILPC.OHFPNLJEHGA();
		if (list.Count > 1)
		{
			AssetAnthologyPreview2 assetAnthologyPreview = GKJPOGNFKNK.OGKPKBLFGMJ(list[DPGJIJGOCIC.IOOHGEJIPFP(1, list.Count)]);
			if (null != assetAnthologyPreview)
			{
				this.CPLLGNAKIIL(assetAnthologyPreview);
			}
			DPGJIJGOCIC.CMGOAFDBAOH("length" + list.Count.ToString());
		}
	}

	// Token: 0x060022B1 RID: 8881 RVA: 0x000F7E0A File Offset: 0x000F600A
	public void OnCurrencyCupClick()
	{
		CommonUserInterface.EHBBFMCILPC.GetPurchasingViewManager().SetResourcesFilter(JFGBECHLPGI.energy);
		this.OnCurrencyClick();
	}

	// Token: 0x060022B2 RID: 8882 RVA: 0x000F7E24 File Offset: 0x000F6024
	private void NKDJKLHMAJN()
	{
		CommonUserInterface.EHBBFMCILPC.HideGenericPopupNoButtons();
		CommonUserInterface.EHBBFMCILPC.HideConnectingAnimation();
		CommonUserInterface.EHBBFMCILPC.GetFader().FadeIn(new TweenCallback(this.KAFKDGHHGAI));
		AudioManager.EHBBFMCILPC.KillMusic("", -1f);
		this.KIFPEADFOOJ();
	}

	// Token: 0x060022B3 RID: 8883 RVA: 0x000F7E7A File Offset: 0x000F607A
	private void ONHLICMODAO()
	{
		CommonUserInterface.EHBBFMCILPC.HideConnectingAnimation();
		this.HGIKEMNOGOO = 0;
		LJNMIPMNOKF.EHBBFMCILPC.KNAEAJPDGKB(GCFLILHCOEI.cardsFilterNone, -1, -1);
		this.OpenWheelOfFortuneFinal();
		this.GBBHKFFENBE = false;
	}

	// Token: 0x060022B4 RID: 8884 RVA: 0x000F7EA8 File Offset: 0x000F60A8
	private void ONGICLLGJGO(int PLKMJJIIJNO)
	{
		try
		{
			foreach (GameObject gameObject in this.PHHNFBLIGJB)
			{
				ThumbnailItem component = gameObject.GetComponent<ThumbnailItem>();
				if (component.index == PLKMJJIIJNO)
				{
					component.UpdateAnthologieHint(this.PMFMEBGNCME[PLKMJJIIJNO]);
				}
			}
			foreach (GameObject gameObject2 in this.GMGKODLANOP)
			{
				ThumbnailItem component2 = gameObject2.GetComponent<ThumbnailItem>();
				if (component2.index == PLKMJJIIJNO)
				{
					NDHKFLHAFNA ndipghmnccf = this.PMFMEBGNCME[PLKMJJIIJNO];
					GridController component3 = gameObject2.transform.parent.GetComponent<GridController>();
					if (null != component3 && component3.filter == JBBNEEHANHL.filterNew)
					{
						ndipghmnccf = this.CBBNGDBFDPO[PLKMJJIIJNO];
					}
					else if (null != component3 && JBBNEEHANHL.filterSearch == component3.filter)
					{
						ndipghmnccf = this.OBJKELOHJDH(PLKMJJIIJNO);
					}
					component2.UpdateAnthologieHint(ndipghmnccf);
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x060022B5 RID: 8885 RVA: 0x000F7FD4 File Offset: 0x000F61D4
	public void BMJCEMCDODB()
	{
		this.OGHHLFOEJKO = DNPIKPDMKKI.PDMOMOPBDHC(LJLAENEAOIM.liveOfferPass);
		if (this.OGHHLFOEJKO != null)
		{
			LJNMIPMNOKF.NMGMNAKLLMI().CAFENOOKEII(GCFLILHCOEI.cardsFilterCollected, -1, this.OGHHLFOEJKO.CHJNOKPOBPO());
			this.ShowCardOptionsOrDownload();
			return;
		}
		CommonUserInterface.IKNOFBFMPGA().HideConnectingAnimation();
		this.GBBHKFFENBE = true;
	}

	// Token: 0x060022B6 RID: 8886 RVA: 0x000F8024 File Offset: 0x000F6224
	public void OnSetupRecommended()
	{
		if (!AKLFPGMDKLA.EHBBFMCILPC.EAFEJCKIEPL(9))
		{
			AKLFPGMDKLA.EHBBFMCILPC.LDAPMNLGAPC(9);
			CommonUserInterface.EHBBFMCILPC.ShowGenericPopupOneOverride(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("energyhinttitle"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("tutrecommbody"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("continue"), new UnityAction(this.OnSetupRecommended), DFGILFBGPLN.popupTools, 0f, 28);
			return;
		}
		this.OnSetupRecommendedFinalize();
	}

	// Token: 0x060022B7 RID: 8887 RVA: 0x000F80A0 File Offset: 0x000F62A0
	public void OnCardsVolSaleClick()
	{
		this.LEFNOKMNHIA = -1;
		AKLFPGMDKLA.EHBBFMCILPC.KBKOLEJEEGH();
		this.GBBHKFFENBE = true;
		CommonUserInterface.EHBBFMCILPC.ShowConnectingAnimation(96);
		if (!AKLFMGKJLJN.EHBBFMCILPC.FACIFBONANM())
		{
			BackendOperationsManager.EHBBFMCILPC.RequestGetDropChancesBalance("OnBackendGetDropChancesSuccess2", "OnBackendGetDropChancesException2");
			return;
		}
		BackendOperationsManager.EHBBFMCILPC.RequestBasicSync("OnBackendGetDropChancesSuccess2", "OnBackendGetDropChancesSuccess2", false);
	}

	// Token: 0x060022B8 RID: 8888 RVA: 0x000F8107 File Offset: 0x000F6307
	private IEnumerator LCNJLBEOKPB()
	{
		AssetsManager.EHBBFMCILPC.GetLoadingProgressSnapshot().EPJKDCDOEMM(0);
		CommonUserInterface.EHBBFMCILPC.ShowConnectingAnimationWithProgress(96);
		yield return new WaitForSeconds(0.2f);
		AssetsManager.EHBBFMCILPC.QueueAssetBundleDownload(NMKDCBPMCKI.AssetBundleKeepAlivePack, this.HFFIIBBJBMH.header.CKACBBGHJGI(), -1, FLDBFOADFLH.startDownloadAndProceed, true, false, false, null, -1, false, "", false, false);
		for (int i = 0; i < this.HFFIIBBJBMH.header.defaultAvatarPacks.Count; i++)
		{
			AssetsManager.EHBBFMCILPC.QueueAssetBundleDownload(NMKDCBPMCKI.AssetBundleAvatarPack, this.HFFIIBBJBMH.header.defaultAvatarPacks[i], -1, FLDBFOADFLH.startDownloadAndProceed, false, false, false, null, -1, false, "", false, false);
		}
		for (int j = 0; j < this.HFFIIBBJBMH.header.defaultAvatarPacks1.Count; j++)
		{
			AssetsManager.EHBBFMCILPC.QueueAssetBundleDownload(NMKDCBPMCKI.AssetBundleAvatarPack, this.HFFIIBBJBMH.header.defaultAvatarPacks1[j], -1, FLDBFOADFLH.startDownloadAndProceed, false, false, false, null, -1, false, "", false, false);
		}
		for (int k = 0; k < this.HFFIIBBJBMH.header.defaultAvatarPacks2.Count; k++)
		{
			AssetsManager.EHBBFMCILPC.QueueAssetBundleDownload(NMKDCBPMCKI.AssetBundleAvatarPack, this.HFFIIBBJBMH.header.defaultAvatarPacks2[k], -1, FLDBFOADFLH.startDownloadAndProceed, false, false, false, null, -1, false, "", false, false);
		}
		for (int l = 0; l < AKLFPGMDKLA.EHBBFMCILPC.EEILOKHLKIM().GNHBHIALAAH.Count; l++)
		{
			AssetsManager.EHBBFMCILPC.QueueAssetBundleDownload(NMKDCBPMCKI.AssetBundleAvatarPack, AKLFPGMDKLA.EHBBFMCILPC.EEILOKHLKIM().GNHBHIALAAH[l], -1, FLDBFOADFLH.startDownloadAndProceed, false, false, false, null, -1, false, "", false, false);
		}
		for (int m = 0; m < AKLFPGMDKLA.EHBBFMCILPC.EEILOKHLKIM().JAJJFPNIBGI.Count; m++)
		{
			AssetsManager.EHBBFMCILPC.QueueAssetBundleDownload(NMKDCBPMCKI.AssetBundleAvatarPack, AKLFPGMDKLA.EHBBFMCILPC.EEILOKHLKIM().JAJJFPNIBGI[m], -1, FLDBFOADFLH.startDownloadAndProceed, false, false, false, null, -1, false, "", false, false);
		}
		for (int n = 0; n < AKLFPGMDKLA.EHBBFMCILPC.EEILOKHLKIM().FCOLLNPADDA.Count; n++)
		{
			AssetsManager.EHBBFMCILPC.QueueAssetBundleDownload(NMKDCBPMCKI.AssetBundleAvatarPack, AKLFPGMDKLA.EHBBFMCILPC.EEILOKHLKIM().FCOLLNPADDA[n], -1, FLDBFOADFLH.startDownloadAndProceed, false, false, false, null, -1, false, "", false, false);
		}
		for (int num = 0; num < this.HFFIIBBJBMH.header.avatarScreenAvatarPacks.Count; num++)
		{
			AssetsManager.EHBBFMCILPC.QueueAssetBundleDownload(NMKDCBPMCKI.AssetBundleAvatarPack, this.HFFIIBBJBMH.header.avatarScreenAvatarPacks[num], -1, FLDBFOADFLH.startDownloadAndProceed, false, false, false, null, -1, false, "", false, false);
		}
		for (int num2 = 0; num2 < this.HFFIIBBJBMH.header.avatarScreenAvatarPacks1.Count; num2++)
		{
			AssetsManager.EHBBFMCILPC.QueueAssetBundleDownload(NMKDCBPMCKI.AssetBundleAvatarPack, this.HFFIIBBJBMH.header.avatarScreenAvatarPacks1[num2], -1, FLDBFOADFLH.startDownloadAndProceed, false, false, false, null, -1, false, "", false, false);
		}
		for (int num3 = 0; num3 < this.HFFIIBBJBMH.header.avatarScreenAvatarPacks2.Count; num3++)
		{
			AssetsManager.EHBBFMCILPC.QueueAssetBundleDownload(NMKDCBPMCKI.AssetBundleAvatarPack, this.HFFIIBBJBMH.header.avatarScreenAvatarPacks2[num3], -1, FLDBFOADFLH.startDownloadAndProceed, false, false, false, null, -1, false, "", false, false);
		}
		for (int num4 = 0; num4 < this.HFFIIBBJBMH.header.avatarScreenAvatarExtensionPacks.Count; num4++)
		{
			AssetsManager.EHBBFMCILPC.QueueAssetBundleDownload(NMKDCBPMCKI.AssetBundleAvatarExtensionPack, this.HFFIIBBJBMH.header.avatarScreenAvatarExtensionPacks[num4], -1, FLDBFOADFLH.startDownloadAndProceed, false, false, false, null, -1, false, "", false, false);
		}
		if (this.HFFIIBBJBMH.header.HGIIJABNDCD(1) != null)
		{
			AssetsManager.EHBBFMCILPC.QueueAssetBundleDownload(NMKDCBPMCKI.AssetBundleCustomFader, this.HFFIIBBJBMH.header.HGIIJABNDCD(1).assetIndex, -1, FLDBFOADFLH.startDownloadAndProceed, false, false, false, null, -1, false, "", false, false);
		}
		AssetsManager.EHBBFMCILPC.QueueAssetBundleDownload(NMKDCBPMCKI.AssetBundleAnthologyAvatar, this.HFFIIBBJBMH.header.CKACBBGHJGI(), -1, FLDBFOADFLH.finishDownloadAndProceed, false, true, false, null, -1, false, "", false, false);
		AssetsManager.EHBBFMCILPC.QueueCustomEffectsBundles(this.HFFIIBBJBMH.header);
		if (!AKLFPGMDKLA.EHBBFMCILPC.EAFEJCKIEPL(73))
		{
			AssetsManager.EHBBFMCILPC.QueueFrameContainerBundle(0);
		}
		AssetsManager.EHBBFMCILPC.GetLoadingProgressSnapshot().CLIOEOLFFLO(LEJKDNAGDHC.Fast);
		AssetsManager.EHBBFMCILPC.GetLoadingProgressSnapshot().GIJKJMMDJEL(0f, 1f);
		AssetsManager.EHBBFMCILPC.DownloadQueuedAssetBundles("OnAvatarScreenAssetsDownloadSuccess", "OnAvatarScreenAssetsDownloadFailed", false);
		yield break;
	}

	// Token: 0x060022B9 RID: 8889 RVA: 0x000F8116 File Offset: 0x000F6316
	public void DownloadAssetBundleFolderLobby()
	{
		base.StartCoroutine(this.JKGIIGPDMLF());
	}

	// Token: 0x060022BA RID: 8890 RVA: 0x000F8128 File Offset: 0x000F6328
	private void NPGMAIPHIML(bool AMDHFNLCJGA)
	{
		try
		{
			if (this.KOGLEPFNALN)
			{
				this.KOGLEPFNALN = false;
				this.MJOMHIEMKMK = "";
				this.BPCHEOFFPCN.Clear();
				this.EEGHJFAIMBF.Clear();
				this.IIDEKJNAFKG.Clear();
				this.NODBJCOJNLJ.Clear();
				bool flag = this.FDMGKEAHGFK();
				bool flag2 = null != this.FIBKHPMLNJN && this.FIBKHPMLNJN.activeSelf;
				if (AMDHFNLCJGA && flag && HKLPEDKJGFC.FACIFBONANM())
				{
					JBBNEEHANHL hbbjbnjbmpk = this.GINJCMEHKLO();
					this.ONBPCOOBOFB(hbbjbnjbmpk);
					this.KFCKNJDLHMC(hbbjbnjbmpk);
				}
				this.KLBBGAFDNMP(JBBNEEHANHL.filterSearch);
				this.NFBOBHDHJNM();
				if (AMDHFNLCJGA && flag2 && HKLPEDKJGFC.FACIFBONANM())
				{
					this.GJOEMCBBPFC(this.GINJCMEHKLO());
					this.CFKGMCPAFHP(this.GINJCMEHKLO());
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x060022BB RID: 8891 RVA: 0x000F8210 File Offset: 0x000F6410
	public void HKANMOICHLO()
	{
		CommonUserInterface.IKNOFBFMPGA().GetPurchasingViewManager().SetResourcesFilter(JFGBECHLPGI.hardCurrency);
		this.OnCurrencyClick();
	}

	// Token: 0x060022BC RID: 8892 RVA: 0x000F8228 File Offset: 0x000F6428
	public void OnSearchClear()
	{
		try
		{
			SceneLobbyManager2.KAFNANCDMNF = null;
			this.NPGMAIPHIML(true);
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x060022BD RID: 8893 RVA: 0x000F825C File Offset: 0x000F645C
	private void BPHPLAHKPPE()
	{
		JBBNEEHANHL[] array = new JBBNEEHANHL[]
		{
			JBBNEEHANHL.filterStarter,
			JBBNEEHANHL.filterNew,
			JBBNEEHANHL.filterTopRated,
			JBBNEEHANHL.filterExplore,
			JBBNEEHANHL.filterFranchises,
			JBBNEEHANHL.filterMostPopular,
			JBBNEEHANHL.filterFavorites,
			JBBNEEHANHL.filterContinuePlaying,
			JBBNEEHANHL.filterAll
		};
		for (int i = 0; i < array.Length; i++)
		{
			SceneLobbyManager2.LPIADNIFNNM lpiadnifnnm = new SceneLobbyManager2.LPIADNIFNNM();
			lpiadnifnnm.filter = array[i];
			if (this.CMGDKBFDGLF(lpiadnifnnm.filter) && (lpiadnifnnm.filter != JBBNEEHANHL.filterNew || !this.MMJJBECDAOC()) && (lpiadnifnnm.filter != JBBNEEHANHL.filterTopRated || AKLFPGMDKLA.EHBBFMCILPC.JPANCNNAEEJ().Count >= 2) && (JBBNEEHANHL.filterTopRated != lpiadnifnnm.filter || !this.IINBDHLPNMP()) && (lpiadnifnnm.filter != JBBNEEHANHL.filterMostPopular || PLBBPHIJMAH.FGCMPALLMCD.Count != 0) && (lpiadnifnnm.filter != JBBNEEHANHL.filterContinuePlaying || this.LGFLDJCAJNC() != 0 || this.LINADLBCHJC() != 0) && lpiadnifnnm.filter != JBBNEEHANHL.filterCompleted && (lpiadnifnnm.filter != JBBNEEHANHL.filterFavorites || AKLFPGMDKLA.EHBBFMCILPC.JCBEPJJHAII(AssetsManager.EHBBFMCILPC.anthologyAssets).Count != 0))
			{
				string value = this.AECCHBMDHBE();
				JBBNEEHANHL jbbneehanhl = JBBNEEHANHL.filterNew;
				try
				{
					jbbneehanhl = (JBBNEEHANHL)Enum.Parse(typeof(JBBNEEHANHL), value);
				}
				catch (Exception aklgbjkdomm)
				{
					DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
					jbbneehanhl = JBBNEEHANHL.filterNew;
				}
				if (JBBNEEHANHL.filterSearch == jbbneehanhl)
				{
					jbbneehanhl = JBBNEEHANHL.filterNew;
				}
				if (KDCJJBLGCBH.EHBBFMCILPC.FPLLPBJFCIK())
				{
					if (jbbneehanhl == lpiadnifnnm.filter)
					{
						this.BCOOKJICILK(jbbneehanhl);
					}
				}
				else if (SceneLobbyManager2.IsGroupedFilter(lpiadnifnnm.filter))
				{
					if (!this.MGNNOFPKGJF.Exists(new Predicate<GameObject>(lpiadnifnnm.GAFHIDBDFPE)))
					{
						this.HPOCOHEODDF(lpiadnifnnm.filter);
					}
					this.BCOOKJICILK(jbbneehanhl);
				}
				else
				{
					GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(this.smallItemParentPrefab, this.scrollView0Content);
					gameObject.GetComponent<GridController>().filter = lpiadnifnnm.filter;
					this.MGNNOFPKGJF.Add(gameObject);
					this.MHFIHLIELBH(lpiadnifnnm.filter, gameObject);
					gameObject.GetComponent<GridController>().UpdateGrid();
					this.BCOOKJICILK(jbbneehanhl);
				}
			}
		}
	}

	// Token: 0x060022BE RID: 8894 RVA: 0x000F8460 File Offset: 0x000F6660
	private GameObject HPOCOHEODDF(JBBNEEHANHL HBBJBNJBMPK)
	{
		GameObject result;
		try
		{
			this.KLBBGAFDNMP(HBBJBNJBMPK);
			this.OBMFDJJNOJJ(HBBJBNJBMPK);
			if (null == AssetsManager.EHBBFMCILPC || null == AssetsManager.EHBBFMCILPC.lobbyDataAsset)
			{
				result = null;
			}
			else
			{
				List<KLJCEMBNKNI> list = this.EPMMCPAPNLM(HBBJBNJBMPK);
				if (list == null || list.Count == 0)
				{
					DPGJIJGOCIC.ADFCDFHBDAF("SceneLobbyManager2.BuildGroupedParent() - no group for " + HBBJBNJBMPK.ToString() + ", container not built");
					result = null;
				}
				else
				{
					GameObject gameObject = Resources.Load<GameObject>("GroupedParent");
					GameObject y = Resources.Load<GameObject>("CoverCard");
					if (null == gameObject || null == y)
					{
						DPGJIJGOCIC.ANOPFDLPKGC("SceneLobbyManager2.BuildGroupedParent() - Resources prefab missing (GroupedParent / CoverCard), run ROMANCE/Debug/Lobby/Build cover card prefabs");
						result = null;
					}
					else
					{
						GameObject gameObject2 = UnityEngine.Object.Instantiate<GameObject>(gameObject, this.scrollView0Content);
						gameObject2.name = "GroupedParent_" + HBBJBNJBMPK.ToString();
						gameObject2.layer = this.scrollView0Content.gameObject.layer;
						gameObject2.GetComponent<GridController>().filter = HBBJBNJBMPK;
						gameObject2.GetComponent<RectTransform>().ACBKFBBCNNC(0f);
						this.MGNNOFPKGJF.Add(gameObject2);
						HAKFHALKMBH hakfhalkmbh = new HAKFHALKMBH();
						hakfhalkmbh.GLOCCAIDHJC = HBBJBNJBMPK;
						hakfhalkmbh.NHOAHJMPCFC = gameObject2;
						hakfhalkmbh.LGIAOIGIGPI = list;
						hakfhalkmbh.CCKABAENJPK = this.CHBDAKMFMGL(HBBJBNJBMPK);
						this.AAHJNGODNKI.Add(hakfhalkmbh);
						int num = hakfhalkmbh.CCKABAENJPK;
						if (num == 0)
						{
							num = list.Count;
						}
						int num2 = 0;
						while (num2 == 0 && hakfhalkmbh.CKBJGCFCHGA < list.Count)
						{
							num2 = this.NHCNNBNPPMG(hakfhalkmbh, num);
						}
						if (num2 == 0)
						{
							DPGJIJGOCIC.ADFCDFHBDAF("SceneLobbyManager2.BuildGroupedParent() - no group could be built for " + HBBJBNJBMPK.ToString() + ", container dropped");
							this.KLBBGAFDNMP(HBBJBNJBMPK);
							this.OBMFDJJNOJJ(HBBJBNJBMPK);
							result = null;
						}
						else
						{
							result = gameObject2;
						}
					}
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
			this.KLBBGAFDNMP(HBBJBNJBMPK);
			this.OBMFDJJNOJJ(HBBJBNJBMPK);
			result = null;
		}
		return result;
	}

	// Token: 0x060022C0 RID: 8896 RVA: 0x000F8780 File Offset: 0x000F6980
	public void TransitionToLobby()
	{
		this.JNKEHEBNBAP();
		this.JLFGANHMMOM();
		if (1 == AKLFPGMDKLA.EHBBFMCILPC.PACMCEHMBGG)
		{
			AudioManager.EHBBFMCILPC.PlayMusic("lobby", true, -1f, false);
		}
		this.PHMIBKAJKMB.EPJKDCDOEMM((float)SceneLobbyManager2.spinsFireTime);
		PurchaseManagerBridge.EHBBFMCILPC.GetPurchaseManager().Initialize();
		this.OnSocialModeChanged();
		FirebaseAnalyticsManager.EHBBFMCILPC.LogEvent(false, AGEHCPDNBFD.cdnDepot.ToString(), AssetsManager.cdnDepotForAnalytics, "", false, false);
		NPOILPKELOJ.BGPKAOFOHHB = 0;
		this.quitButtonHidden.SetActive(false);
		this.quitButtonAvailable.SetActive(true);
		this.passesButton.gameObject.SetActive(true);
		this.NKKDELLNMHD();
		if (null != this.skinShopButton)
		{
			this.skinShopButton.SetActive(this.PIECGBHMOCB() && KDCJJBLGCBH.EHBBFMCILPC.NJFAOIDGFGC() && KKLFGEHAMMC.EHBBFMCILPC.FACIFBONANM());
			if (null != this.footerSkinShopButton)
			{
				this.footerSkinShopButton.SetActive(this.skinShopButton.activeSelf);
			}
		}
		this.HDPICAFMHPH();
		GDOKLFCLLIK gdoklfcllik = DNPIKPDMKKI.MCOMGMOACEM(LJLAENEAOIM.liveOfferCardsVolSale);
		if (gdoklfcllik != null)
		{
			this.cardsVolSaleButton.gameObject.SetActive(true);
			int num = gdoklfcllik.OLNJMJMNBCN() + 1;
			this.cardsVolSaleButtonText.text = (num.ToString() ?? "");
			this.cardsVolSaleButtonText.SetText(num.ToString() ?? "", true);
		}
		else
		{
			this.cardsVolSaleButton.gameObject.SetActive(false);
		}
		this.JGOAOAKBONB();
		int num2 = 0;
		if (this.cardsVolSaleButton.gameObject.activeSelf)
		{
			num2++;
		}
		if (this.passesButton.gameObject.activeSelf)
		{
			num2++;
		}
		if (null != this.skinShopButton && this.skinShopButton.activeSelf)
		{
			num2++;
		}
		if (!SceneLobbyManager2.PBFHBAAFHJD)
		{
			num2 = 0;
		}
		if (num2 > 0)
		{
			RectTransform component = this.extrasParent.GetComponent<RectTransform>();
			this.PDNHECGONHE();
			this.JJKGBEMFKBD(component, num2);
			this.extrasParent.SetActive(true);
			component.DOAnchorPos(new Vector2(4f, component.anchoredPosition.y), 1f, false).SetDelay(2f);
		}
		else
		{
			this.extrasParent.SetActive(false);
		}
		ApplicationFocusManager.Activate();
		this.CMDIKMNEGEN();
		this.PDFIHFFJMJN = true;
		SceneLobbyManager2.lobbyIsActive = true;
		this.IDLPKJBJKCP();
		this.disclaimerImpers.DOFade(0f, 1f);
		LoadingEnvironmentManager.WipeOutAndDestroy(0.75f, 0.8f);
		float width = this.logoBackgroundNew.rect.width;
		this.logoBackgroundMask.GetComponent<AnimationTranslation>().translationAmountX = -width;
		this.logoBackgroundNew.GetComponent<AnimationTranslation>().translationAmountX = width;
		if (StorySplashManager.scriptHitCounter == 0)
		{
			this.heartsParticles.Play();
		}
		for (int i = 0; i < this.themesParticles.Count; i++)
		{
			if (null != this.themesParticles[i])
			{
				this.themesParticles[i].Stop();
			}
		}
		this.LLCBNGOAGHK = 0.5f;
		for (int j = 0; j < this.lobbyParticles.Count; j++)
		{
			if (null != this.lobbyParticles[j])
			{
				this.lobbyParticles[j].gameObject.SetActive(true);
				this.lobbyParticles[j].Play();
			}
		}
		this.logoBackgroundMask.GetComponent<AnimationTranslation>().enabled = true;
		this.logoBackgroundMask.GetComponent<AnimationCanvasGroupAlpha>().enabled = true;
		this.logoBackgroundNew.GetComponent<AnimationTranslation>().enabled = true;
		base.StartCoroutine(this.PGGHOFFIGOG());
		if (LoadingEnvironmentManager.IsAlive())
		{
			this.logoBackgroundMask.gameObject.SetActive(false);
			this.logoBackgroundNew.gameObject.SetActive(false);
		}
	}

	// Token: 0x060022C1 RID: 8897 RVA: 0x000F8B74 File Offset: 0x000F6D74
	private void JPAGPOKBHMI()
	{
		try
		{
			if (!string.IsNullOrEmpty(SceneLobbyManager2.KAFNANCDMNF))
			{
				string kafnancdmnf = SceneLobbyManager2.KAFNANCDMNF;
				SceneLobbyManager2.KAFNANCDMNF = null;
				if (null == this.lobbySearchBar || !this.lobbySearchBar.gameObject.activeInHierarchy)
				{
					DPGJIJGOCIC.ADFCDFHBDAF("SceneLobbyManager2.TryApplyPendingSearchQuery() - bar not active in hierarchy, restored query '" + kafnancdmnf + "' dropped");
				}
				else if (!KDCJJBLGCBH.EHBBFMCILPC.GNGCDGBAALO() && MLIBDDCCKBM.FACIFBONANM())
				{
					this.lobbySearchBar.SetQueryAndApply(kafnancdmnf);
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x060022C2 RID: 8898 RVA: 0x000F8C0C File Offset: 0x000F6E0C
	private void LLMPAPDBHEL()
	{
		try
		{
			this.IDJEMNCLFDN();
			this.UpdateAnthologiesHints();
			foreach (GameObject gameObject in this.PHHNFBLIGJB)
			{
				ThumbnailItem component = gameObject.GetComponent<ThumbnailItem>();
				component.OnLanguageChange();
				component.UpdateAnthologieHint(this.PMFMEBGNCME[component.index]);
			}
			foreach (GameObject gameObject2 in this.KKPNDGIHFLN)
			{
				gameObject2.GetComponent<CardItem>().OnLanguageChange();
			}
			foreach (GameObject gameObject3 in this.EKIFLHLCLKG)
			{
				gameObject3.GetComponent<FilterItem>().OnLanguageChange();
			}
			this.AEGIFDILJDP();
			foreach (GameObject gameObject4 in this.GMGKODLANOP)
			{
				ThumbnailItem component2 = gameObject4.GetComponent<ThumbnailItem>();
				component2.OnLanguageChange();
				try
				{
					NDHKFLHAFNA ndhkflhafna = this.PMFMEBGNCME[component2.index];
					GridController component3 = gameObject4.transform.parent.GetComponent<GridController>();
					if (null != component3 && component3.filter == JBBNEEHANHL.filterNew)
					{
						ndhkflhafna = this.CBBNGDBFDPO[component2.index];
					}
					else if (null != component3 && JBBNEEHANHL.filterSearch == component3.filter)
					{
						ndhkflhafna = this.OBJKELOHJDH(component2.index);
					}
					if (this.BGAHIHIOJOJ(ndhkflhafna) || this.BGAHIHIOJOJ(component2.GetAnthologyHintName()))
					{
						component2.UpdateAnthologieHint(ndhkflhafna);
					}
				}
				catch (Exception aklgbjkdomm)
				{
					DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
				}
			}
			this.focusItem.GetComponent<FocusItem>().OnLanguageChange();
			try
			{
				if (null != this.LGKGGPDKAHF)
				{
					FocusItem component4 = this.focusItem.GetComponent<FocusItem>();
					NDHKFLHAFNA ndhkflhafna2 = this.PMFMEBGNCME[this.LGKGGPDKAHF.index];
					if (this.BGAHIHIOJOJ(ndhkflhafna2) || this.BGAHIHIOJOJ(component4.GetAnthologyHint()))
					{
						component4.RefreshAnthologyHint(ndhkflhafna2, this.EMEPIGEFMEA(ndhkflhafna2));
					}
				}
			}
			catch (Exception aklgbjkdomm2)
			{
				DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm2);
			}
		}
		catch (Exception aklgbjkdomm3)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm3);
		}
		this.JGOAOAKBONB();
	}

	// Token: 0x060022C3 RID: 8899 RVA: 0x000F8EE8 File Offset: 0x000F70E8
	private List<KLJCEMBNKNI> DEFGJKADGKB()
	{
		List<KLJCEMBNKNI> list = new List<KLJCEMBNKNI>();
		try
		{
			List<int> list2 = this.DGPAFDKHLJL(JBBNEEHANHL.filterAll);
			if (list2.Count == 0 || null == AssetsManager.EHBBFMCILPC || null == AssetsManager.EHBBFMCILPC.lobbyDataAsset)
			{
				return list;
			}
			EFKIAFDJBOE efkiafdjboe = AssetsManager.EHBBFMCILPC.lobbyDataAsset.LAOCCHFCLAD();
			List<int> list3 = new List<int>();
			Dictionary<int, List<int>> dictionary = new Dictionary<int, List<int>>();
			List<int> list4 = new List<int>();
			for (int i = 0; i < list2.Count; i++)
			{
				LNEMNOKIIAP lnemnokiiap = efkiafdjboe.CKCHHBNMKHG(list2[i]);
				if (lnemnokiiap == null)
				{
					list4.Add(list2[i]);
				}
				else
				{
					if (!dictionary.ContainsKey(lnemnokiiap.KFIIKPJIBFA))
					{
						dictionary[lnemnokiiap.KFIIKPJIBFA] = new List<int>();
						list3.Add(lnemnokiiap.KFIIKPJIBFA);
					}
					dictionary[lnemnokiiap.KFIIKPJIBFA].Add(list2[i]);
				}
			}
			for (int j = 1; j < list3.Count; j++)
			{
				int num = list3[j];
				int num2 = j - 1;
				while (num2 >= 0 && list3[num2] < num)
				{
					list3[num2 + 1] = list3[num2];
					num2--;
				}
				list3[num2 + 1] = num;
			}
			for (int k = 0; k < list3.Count; k++)
			{
				List<int> list5 = dictionary[list3[k]];
				for (int l = 1; l < list5.Count; l++)
				{
					int num3 = list5[l];
					int num4 = l - 1;
					while (num4 >= 0 && list5[num4] < num3)
					{
						list5[num4 + 1] = list5[num4];
						num4--;
					}
					list5[num4 + 1] = num3;
				}
				list.Add(this.AGFJMDBMKBN("coverYear", list5.Count, list3[k], 0, "", "allpattern", JBBNEEHANHL.filterAll, list5));
			}
			if (list4.Count > 0)
			{
				for (int m = 1; m < list4.Count; m++)
				{
					int num5 = list4[m];
					int num6 = m - 1;
					while (num6 >= 0 && list4[num6] < num5)
					{
						list4[num6 + 1] = list4[num6];
						num6--;
					}
					list4[num6 + 1] = num5;
				}
				list.Add(this.AGFJMDBMKBN("coverUndated", list4.Count, 0, 0, "", "allpattern", JBBNEEHANHL.filterAll, list4));
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
		return list;
	}

	// Token: 0x060022C4 RID: 8900 RVA: 0x000F91B4 File Offset: 0x000F73B4
	private int JGAGICJMICN(PLFDAJJHMKO LFLOCKNKAKC)
	{
		try
		{
			return this.NIHGAACGFHB(LFLOCKNKAKC);
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
		return 0;
	}

	// Token: 0x060022C5 RID: 8901 RVA: 0x000F91E8 File Offset: 0x000F73E8
	private CultureInfo CLCLLJGGMEF()
	{
		CultureInfo result;
		try
		{
			result = CultureInfo.GetCultureInfo(LanguageManager.FixLanguageCode(LanguageManager.EHBBFMCILPC.GetSelectedLanguage().ToString()));
		}
		catch (Exception)
		{
			result = CultureInfo.InvariantCulture;
		}
		return result;
	}

	// Token: 0x060022C6 RID: 8902 RVA: 0x000F9234 File Offset: 0x000F7434
	private void CAKDKGOIOOL()
	{
		try
		{
			SceneLobbyManager2.KAFNANCDMNF = null;
			this.KOGLEPFNALN = false;
			this.MJOMHIEMKMK = "c";
			this.BPCHEOFFPCN.Clear();
			this.EEGHJFAIMBF.Clear();
			this.IIDEKJNAFKG.Clear();
			this.NODBJCOJNLJ.Clear();
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x060022C7 RID: 8903 RVA: 0x000F92A0 File Offset: 0x000F74A0
	private Sprite EMEPIGEFMEA(NDHKFLHAFNA CDHFOGMHAOK)
	{
		if (CDHFOGMHAOK == NDHKFLHAFNA.hintInDevelopment)
		{
			return this.inDevelopmentTagSprite;
		}
		if (CDHFOGMHAOK == NDHKFLHAFNA.hintOnHiatus || CDHFOGMHAOK == NDHKFLHAFNA.hintDiscontinued)
		{
			return this.onHiatusTagSprite;
		}
		if (CDHFOGMHAOK == NDHKFLHAFNA.hintCompleted || CDHFOGMHAOK == NDHKFLHAFNA.hintPlayAgain)
		{
			return this.completedTagSprite;
		}
		return this.defaultTagSprite;
	}

	// Token: 0x060022C8 RID: 8904 RVA: 0x000EE95F File Offset: 0x000ECB5F
	private void EHBEAAKMMLL()
	{
		this.KHCPHAIGBJE();
	}

	// Token: 0x060022C9 RID: 8905 RVA: 0x000F92D4 File Offset: 0x000F74D4
	public static string BuildSharedPitchLine(string HHNGGFLJAIJ, string FBDPELCOKOP, string CPDHECJIMHO)
	{
		string text = HHNGGFLJAIJ;
		if (FBDPELCOKOP != null && 0 < FBDPELCOKOP.Length)
		{
			text = text + " • " + FBDPELCOKOP;
		}
		if (CPDHECJIMHO != null && 0 < CPDHECJIMHO.Length)
		{
			text = text + " • " + CPDHECJIMHO;
		}
		return text;
	}

	// Token: 0x060022CA RID: 8906 RVA: 0x000F9318 File Offset: 0x000F7518
	private void AELPLJGOJJK()
	{
		DPGJIJGOCIC.NFIDPOMCNLP("SceneLobbyManager2.OnLiveProfileThemeBackgroundCdnSuccess(): live profile themes " + SceneLobbyManager2.LCBGEAPPODB(this.ILPNKGBHGOL) + " resident=" + AssetsManager.EHBBFMCILPC.liveProfileThemesAssets.Count.ToString());
		this.ILPNKGBHGOL = new List<int>();
		this.EPJBDIIAIAJ = false;
		this.CJEJCGOCFJF = false;
	}

	// Token: 0x060022CB RID: 8907 RVA: 0x000F9374 File Offset: 0x000F7574
	private void PCPBEDEPMMJ()
	{
		try
		{
			if (null == this.FIBKHPMLNJN)
			{
				this.FIBKHPMLNJN = UnityEngine.Object.Instantiate<GameObject>(this.filterItemPrefab, this.filterItemsParent);
				this.FIBKHPMLNJN.layer = this.filterItemsParent.gameObject.layer;
				this.EKIFLHLCLKG.Add(this.FIBKHPMLNJN);
				this.FIBKHPMLNJN.GetComponent<Toggle>().group = this.toogleGroupOnFilterItemsParent;
				this.FIBKHPMLNJN.GetComponent<FilterItem>().SetContent(JBBNEEHANHL.filterSearch, new UnityAction<JBBNEEHANHL>(this.JMCDFDBADMC), this.scrollView2Controller);
				if (NBDLBFJOEGN.PBLDJNHHEPL())
				{
					HDTrigger componentInChildren = this.FIBKHPMLNJN.GetComponentInChildren<HDTrigger>(true);
					if (null != componentInChildren)
					{
						componentInChildren.SetQuality("HD");
					}
				}
			}
			this.FIBKHPMLNJN.transform.SetAsFirstSibling();
			if (!this.FIBKHPMLNJN.activeSelf)
			{
				this.FIBKHPMLNJN.SetActive(true);
			}
			LayoutRebuilder.ForceRebuildLayoutImmediate(this.filterItemsParent);
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x060022CC RID: 8908 RVA: 0x000F9484 File Offset: 0x000F7684
	private bool CLEMDBANFDE(JBBNEEHANHL HBBJBNJBMPK)
	{
		for (int i = 0; i < this.EKIFLHLCLKG.Count; i++)
		{
			if (null != this.EKIFLHLCLKG[i] && this.EKIFLHLCLKG[i].activeSelf && this.EKIFLHLCLKG[i].GetComponent<FilterItem>().id == HBBJBNJBMPK)
			{
				return true;
			}
		}
		return false;
	}

	// Token: 0x060022CD RID: 8909 RVA: 0x000F94EA File Offset: 0x000F76EA
	public void RestartStory4()
	{
		this.RestartStoryX(4);
	}

	// Token: 0x060022CE RID: 8910 RVA: 0x000F94F3 File Offset: 0x000F76F3
	private bool BGAHIHIOJOJ(NDHKFLHAFNA CDHFOGMHAOK)
	{
		return CDHFOGMHAOK == NDHKFLHAFNA.hintInDevelopment || CDHFOGMHAOK == NDHKFLHAFNA.hintOnHiatus || CDHFOGMHAOK == NDHKFLHAFNA.hintDiscontinued;
	}

	// Token: 0x060022CF RID: 8911 RVA: 0x000F9505 File Offset: 0x000F7705
	private void IODEDCGDMDE()
	{
		DPGJIJGOCIC.NFIDPOMCNLP("Remind Option picked");
		PlayerPrefs.SetInt("ratePopupResult", 3);
		PlayerPrefs.Save();
	}

	// Token: 0x060022D0 RID: 8912 RVA: 0x000F9524 File Offset: 0x000F7724
	private void JJKGBEMFKBD(RectTransform HJPHOHFAIIO, int NNPOKGKLMPG)
	{
		try
		{
			GameObject[] array = new GameObject[]
			{
				this.cardsVolSaleButton,
				this.passesButton,
				this.skinShopButton
			};
			int num = 0;
			for (int i = 0; i < array.Length; i++)
			{
				if (!(null == array[i]) && array[i].activeSelf)
				{
					RectTransform component = array[i].GetComponent<RectTransform>();
					if (null != component)
					{
						float num2 = 71f + 122f * (float)num;
						if (array[i] == this.skinShopButton && num > 0)
						{
							num2 += 16f;
						}
						component.anchoredPosition = new Vector2(num2, component.anchoredPosition.y);
					}
					num++;
				}
			}
			float num3 = 289f + 122f * (float)Mathf.Max(0, NNPOKGKLMPG - 2);
			if (null != this.skinShopButton && this.skinShopButton.activeSelf && NNPOKGKLMPG > 1)
			{
				num3 += 16f;
			}
			HJPHOHFAIIO.sizeDelta = new Vector2(num3, HJPHOHFAIIO.sizeDelta.y);
			HJPHOHFAIIO.anchoredPosition = new Vector2(-(num3 + 20f), HJPHOHFAIIO.anchoredPosition.y);
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x060022D1 RID: 8913 RVA: 0x000F9670 File Offset: 0x000F7870
	private void LLHKAGPCAKD(PLFDAJJHMKO LFLOCKNKAKC)
	{
		LFLOCKNKAKC.NCAMFPGMCIG.FKDMPMKBCBL = new List<IMMKFHKEEBF>();
		this.EDGAPOIIHKC = false;
		try
		{
			if (!(null == AssetsManager.EHBBFMCILPC.profileDataAsset))
			{
				JSONArray jsonarray = AssetsManager.EHBBFMCILPC.profileDataAsset.GIOFKDDKAPD();
				if (!(null == jsonarray) && LFLOCKNKAKC.NCAMFPGMCIG.EIEIDFBDPKO != null && LFLOCKNKAKC.NCAMFPGMCIG.EIEIDFBDPKO.Length != 0)
				{
					int num = this.HFFIIBBJBMH.header.CJJOGBNCCCH(LFLOCKNKAKC.DHONIOBOLEL.GGICIBLJIKI);
					string[] array = LFLOCKNKAKC.NCAMFPGMCIG.EIEIDFBDPKO.Split(';', StringSplitOptions.None);
					List<IMMKFHKEEBF> list = new List<IMMKFHKEEBF>();
					for (int i = 0; i < array.Length; i++)
					{
						string[] array2 = array[i].Split(':', StringSplitOptions.None);
						if (array2.Length >= 4)
						{
							string text = array2[0].Replace(" ", "");
							int num2 = 0;
							if (int.TryParse(text, out num2))
							{
								this.EDGAPOIIHKC = true;
								return;
							}
							int num3 = 0;
							int num4 = 0;
							int mjkicdjifip = 0;
							if (int.TryParse(array2[1], out num3) && int.TryParse(array2[2], out num4) && int.TryParse(array2[3], out mjkicdjifip) && SceneStoryManager.LoungeSnapshotSpriteUsable(text))
							{
								int num5 = SceneLobbyManager2.DFOKDGOHBFN(jsonarray, this.HFFIIBBJBMH.header.index, text);
								if (num5 >= 0)
								{
									JSONObject asObject = jsonarray[num5].AsObject;
									IMMKFHKEEBF immkfhkeebf = new IMMKFHKEEBF();
									immkfhkeebf.ACAGNLALNPA = this.HFFIIBBJBMH.header.index;
									immkfhkeebf.ODGNIFJGEHL = asObject["var"].Replace(" ", "") + this.HFFIIBBJBMH.header.index.ToString();
									immkfhkeebf.PFFCLABCNHI = asObject["sprite"].Replace(" ", "");
									immkfhkeebf.OMEEKCMIEJM = num5;
									immkfhkeebf.BIBKFNMPHIK = num4;
									immkfhkeebf.PHIEEHJCHAK = num4;
									immkfhkeebf.MJKICDJIFIP = mjkicdjifip;
									immkfhkeebf.KJNJOOHIBDF = ((asObject["mins"] != null) ? asObject["mins"].AsInt : 0);
									immkfhkeebf.DNOIMFDKCEM = ((asObject["mine"] != null) ? asObject["mine"].AsInt : 0);
									immkfhkeebf.PDKKPKCAILC = ((asObject["wdb"] != null) ? asObject["wdb"].AsInt : 0);
									bool flag = num > immkfhkeebf.KJNJOOHIBDF || (num == immkfhkeebf.KJNJOOHIBDF && LFLOCKNKAKC.DHONIOBOLEL.LKIKEHFANBO[0] >= immkfhkeebf.DNOIMFDKCEM);
									if (!flag && this.FJOMBPDEMCM != null)
									{
										flag = this.FJOMBPDEMCM.JGPFKEIHGOE(immkfhkeebf.KJNJOOHIBDF, immkfhkeebf.DNOIMFDKCEM);
									}
									bool flag2 = this.JGPMELNOCOM(immkfhkeebf.PDKKPKCAILC, LFLOCKNKAKC);
									immkfhkeebf.PPACJFFFBFB = ((1 == num3 && flag && flag2) ? 1 : 0);
									list.Add(immkfhkeebf);
								}
							}
						}
					}
					for (int j = 0; j < list.Count; j++)
					{
						int num6 = j;
						for (int k = j + 1; k < list.Count; k++)
						{
							if (list[k].BIBKFNMPHIK > list[num6].BIBKFNMPHIK)
							{
								num6 = k;
							}
						}
						if (num6 != j)
						{
							IMMKFHKEEBF value = list[j];
							list[j] = list[num6];
							list[num6] = value;
						}
					}
					LFLOCKNKAKC.NCAMFPGMCIG.FKDMPMKBCBL = list;
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x060022D2 RID: 8914 RVA: 0x000F9A64 File Offset: 0x000F7C64
	private JBBNEEHANHL DJMKGHMPMPP()
	{
		for (int i = 0; i < this.EKIFLHLCLKG.Count; i++)
		{
			FilterItem filterItem = (null == this.EKIFLHLCLKG[i]) ? null : this.EKIFLHLCLKG[i].GetComponent<FilterItem>();
			if (null != filterItem && JBBNEEHANHL.filterSearch != filterItem.id && this.EKIFLHLCLKG[i].activeSelf)
			{
				return filterItem.id;
			}
		}
		return JBBNEEHANHL.filterNew;
	}

	// Token: 0x060022D3 RID: 8915 RVA: 0x000F9ADE File Offset: 0x000F7CDE
	private IEnumerator OIFMCGLDCJK(GameObject ABHNFBBBAKG)
	{
		yield return new WaitForEndOfFrame();
		if (PlayerPrefs.GetString("lastFilter", JBBNEEHANHL.filterNew.ToString()) == JBBNEEHANHL.filterFavorites.ToString())
		{
			ABHNFBBBAKG.GetComponent<GridLayoutGroup>().enabled = false;
			ABHNFBBBAKG.GetComponent<GridLayoutGroup>().enabled = true;
		}
		Canvas.ForceUpdateCanvases();
		yield return null;
		yield break;
	}

	// Token: 0x060022D4 RID: 8916 RVA: 0x000F9AF0 File Offset: 0x000F7CF0
	public void OnCurrencyClickPart2()
	{
		for (int i = 0; i < this.lobbyParticles.Count; i++)
		{
			if (null != this.lobbyParticles[i])
			{
				this.lobbyParticles[i].Clear();
				this.lobbyParticles[i].gameObject.SetActive(false);
			}
		}
		AOBJLALDBAA.EHBBFMCILPC.EGELHPJBAIC("OnNeedToDeactivateFocusItemCloseButton", 0f);
		this.ALGIAIKDEPH();
		CommonUserInterface.EHBBFMCILPC.GetPurchasingViewManager().Show(false);
	}

	// Token: 0x060022D5 RID: 8917 RVA: 0x000F9B79 File Offset: 0x000F7D79
	private void FBCGCAKDGLF()
	{
		if (KHPGPLAMAIN.GAKPCLCOJKO())
		{
			AccountSignInManager.FILDBDMENPG().HGCFKELLBIH(HHCKLPJJKIJ.device, JCAPGCCNOMP.auto, (HHCKLPJJKIJ)7, 0);
			return;
		}
		AccountSignInManager.EHBBFMCILPC.KINKAIPKIAM(HHCKLPJJKIJ.google, JCAPGCCNOMP.auto, HHCKLPJJKIJ.facebook, 1);
	}

	// Token: 0x060022D6 RID: 8918 RVA: 0x000F9B9F File Offset: 0x000F7D9F
	private void HBLJJDBLGMG()
	{
		CommonUserInterface.EHBBFMCILPC.FreezeUX();
		CommonUserInterface.EHBBFMCILPC.GetFader().FadeIn(new TweenCallback(this.FDCBDGNPJMG));
	}

	// Token: 0x060022D7 RID: 8919 RVA: 0x000F9BC6 File Offset: 0x000F7DC6
	private void KBGDOGLEIIB()
	{
		DPGJIJGOCIC.JCBPCOEIIKK(LanguageManager.EHBBFMCILPC.GetSelectedLanguage() == CEIBHCNNIDC.ru);
	}

	// Token: 0x060022D8 RID: 8920 RVA: 0x000F9BDC File Offset: 0x000F7DDC
	private static int DFOKDGOHBFN(JSONArray DJJDGLLEJCK, int PLKMJJIIJNO, string HAPADEOFKBP)
	{
		for (int i = 0; i < DJJDGLLEJCK.Count; i++)
		{
			JSONObject asObject = DJJDGLLEJCK[i].AsObject;
			if (asObject["ant"].AsInt == PLKMJJIIJNO)
			{
				string text = "";
				if (null != asObject["sprite"])
				{
					text = asObject["sprite"].Replace(" ", "");
				}
				if (text.Equals(HAPADEOFKBP))
				{
					return i;
				}
			}
		}
		return -1;
	}

	// Token: 0x060022D9 RID: 8921 RVA: 0x000F9C60 File Offset: 0x000F7E60
	private void CPLLGNAKIIL(AssetAnthologyPreview2 KJNNEPNHHFL, string[] PCEIDBNGNMA)
	{
		try
		{
			this.OCKANDFLMBG = PCEIDBNGNMA;
			this.FLPJFHKDIOG = ((null == KJNNEPNHHFL) ? -1 : KJNNEPNHHFL.index);
			this.CPLLGNAKIIL(KJNNEPNHHFL);
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
		finally
		{
			this.OCKANDFLMBG = null;
			this.FLPJFHKDIOG = -1;
		}
	}

	// Token: 0x060022DA RID: 8922 RVA: 0x000F9CC8 File Offset: 0x000F7EC8
	private void LCLOPECGHMG()
	{
		CommonUserInterface.EHBBFMCILPC.HideConnectingAnimation();
		CommonUserInterface.EHBBFMCILPC.ShowGenericPopup(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("errortitle"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("app42error"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("ok"), DFGILFBGPLN.popupBackendError, 0f, 28);
	}

	// Token: 0x060022DB RID: 8923 RVA: 0x000F9D20 File Offset: 0x000F7F20
	private bool HKNBOLLEAGE(JBBNEEHANHL HBBJBNJBMPK)
	{
		bool result;
		try
		{
			if (HBBJBNJBMPK != JBBNEEHANHL.filterNew)
			{
				switch (HBBJBNJBMPK)
				{
				case JBBNEEHANHL.filterAll:
				case JBBNEEHANHL.filterMostPopular:
					return this.JCPEDJJGFOO(HBBJBNJBMPK);
				case JBBNEEHANHL.filterContinuePlaying:
					return (this.LGFLDJCAJNC() > 0 || this.LINADLBCHJC() > 0) && this.JCPEDJJGFOO(HBBJBNJBMPK);
				case JBBNEEHANHL.filterTopRated:
				case JBBNEEHANHL.filterSpecialEpisodes:
					break;
				default:
					switch (HBBJBNJBMPK)
					{
					case JBBNEEHANHL.filterFavorites:
						return AKLFPGMDKLA.EHBBFMCILPC.JCBEPJJHAII(AssetsManager.EHBBFMCILPC.anthologyAssets).Count > 0 && this.JCPEDJJGFOO(HBBJBNJBMPK);
					case JBBNEEHANHL.filterSearch:
						return this.KOGLEPFNALN && this.BPCHEOFFPCN.Count > 0;
					case JBBNEEHANHL.filterFranchises:
						return this.AEDFFAHINBH();
					case JBBNEEHANHL.filterExplore:
						return this.AMHFDOEDOOE();
					case JBBNEEHANHL.filterStarter:
						return this.OGMODMPACPJ();
					}
					break;
				}
				result = false;
			}
			else
			{
				result = (!this.MMJJBECDAOC() && this.JCPEDJJGFOO(HBBJBNJBMPK));
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
			result = false;
		}
		return result;
	}

	// Token: 0x060022DC RID: 8924 RVA: 0x000F9E34 File Offset: 0x000F8034
	public void OnAvatarClickProceed()
	{
		CommonUserInterface.EHBBFMCILPC.ShowConnectingAnimation(96);
		base.StartCoroutine(this.MNBHMJPGHAG());
	}

	// Token: 0x060022DD RID: 8925 RVA: 0x000F9E50 File Offset: 0x000F8050
	private void EHKDHDDJHLL()
	{
		if (ODJKHCHFKNL.LEMILALILKP() != DFGILFBGPLN.screenLobby)
		{
			return;
		}
		HECEJCDAIOJ lastSelectedEntry = SkinShopItem.lastSelectedEntry;
		SkinShopItem.lastSelectedEntry = null;
		if (lastSelectedEntry == null)
		{
			return;
		}
		try
		{
			CommonUserInterface.EHBBFMCILPC.GetSkinShop().InstantClose();
			this.HDPICAFMHPH();
			AssetsManager.EHBBFMCILPC.DestroyAssetBundleAssets(NMKDCBPMCKI.AssetBundleProfileData5, -1);
			if (!GKJPOGNFKNK.NLBKIPMKKMC(lastSelectedEntry.AMKCLHLIIMN))
			{
				CommonUserInterface.EHBBFMCILPC.ShowGenericPopup(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("importanttitle"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("loungenotavailable"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("ok"), DFGILFBGPLN.popupSignInQuestion, 0f, 28);
			}
			else
			{
				AssetAnthologyPreview2 nbknfjnidkc = GKJPOGNFKNK.OGKPKBLFGMJ(lastSelectedEntry.AMKCLHLIIMN);
				FJLGCKNOJMJ fjlgcknojmj = AssetsManager.EHBBFMCILPC.lobbyDataAsset.MFMJHIFAOHE().ELDKHHGLNBK(lastSelectedEntry.AMKCLHLIIMN);
				if (fjlgcknojmj == null || !fjlgcknojmj.PPACJFFFBFB || !KDCJJBLGCBH.EHBBFMCILPC.NJFAOIDGFGC())
				{
					CommonUserInterface.EHBBFMCILPC.ShowGenericPopup(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("importanttitle"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("loungenotavailable"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("ok"), DFGILFBGPLN.popupSignInQuestion, 0f, 28);
				}
				else
				{
					this.IPFPANDOKKI(nbknfjnidkc);
					this.MGNKGDNOKEK(true);
					SceneLoungeManager.SetPendingLoungeCharacter(lastSelectedEntry.KALBADOPCDN);
					SceneLoungeManager.SetPendingLoungeLook(lastSelectedEntry.BDIHOCKCCBL);
					AOBJLALDBAA.EHBBFMCILPC.EGELHPJBAIC("OnLobbyLoungeOpenRequested", 0f);
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x060022DE RID: 8926 RVA: 0x000F9FCC File Offset: 0x000F81CC
	private void NGOJBIDKBHL()
	{
		CommonUserInterface.EHBBFMCILPC.HideConnectingAnimation();
		this.HGIKEMNOGOO = 0;
		LJNMIPMNOKF.EHBBFMCILPC.HHFPCCGBDNF(GCFLILHCOEI.cardsFilterCollected, -1, -1);
		this.OpenWheelOfFortuneFinal();
		this.GBBHKFFENBE = false;
	}

	// Token: 0x060022DF RID: 8927 RVA: 0x000F9FFC File Offset: 0x000F81FC
	private void CBNBDIMFAII()
	{
		if (DNPIKPDMKKI.LEMILALILKP("lobby") != null && DNPIKPDMKKI.LEMILALILKP("lobby").NHKCEMHKODM == LJLAENEAOIM.liveOfferPass)
		{
			KIOOJMGLCLC kioojmglclc = ODLJHDIGLGO.BCGIONNIFIA(DNPIKPDMKKI.LEMILALILKP("lobby").OKHMNFLFDOM);
			if (kioojmglclc != null && kioojmglclc.ALFGPLALKCN())
			{
				AOBJLALDBAA.EHBBFMCILPC.EGELHPJBAIC(DNPIKPDMKKI.LEMILALILKP("lobby").BDKJOHKAFFO, 0.5f);
			}
		}
		DNPIKPDMKKI.GFEOFIABBKM();
	}

	// Token: 0x060022E0 RID: 8928 RVA: 0x000FA06C File Offset: 0x000F826C
	private void EOPMIONFFPM()
	{
		this.GBBHKFFENBE = false;
		CommonUserInterface.EHBBFMCILPC.HideConnectingAnimation();
		CommonUserInterface.EHBBFMCILPC.ShowGenericPopupTwoOverride(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("errortitle"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("app42error") + " (" + AKLFPGMDKLA.EHBBFMCILPC.EEHGLPEIIHD + ")", CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("retry"), new UnityAction(this.JLFKKFCFJIC), new UnityAction(this.MMLFBNPEOPP), DFGILFBGPLN.popupBackendErrorStartPlayChapter, 0f, 28);
	}

	// Token: 0x060022E1 RID: 8929 RVA: 0x000FA0FC File Offset: 0x000F82FC
	private bool IOLIAJFHGFI(JBBNEEHANHL HBBJBNJBMPK)
	{
		if (HBBJBNJBMPK == (JBBNEEHANHL)33 || HBBJBNJBMPK == (JBBNEEHANHL)67 || HBBJBNJBMPK == JBBNEEHANHL.filterNew || HBBJBNJBMPK == (JBBNEEHANHL)(-51) || HBBJBNJBMPK == (JBBNEEHANHL)117 || HBBJBNJBMPK == (JBBNEEHANHL)(-62))
		{
			return false;
		}
		foreach (AssetAnthology assetAnthology in AssetsManager.EHBBFMCILPC.anthologyAssets)
		{
			IJLJDFKJIJM ijljdfkjijm = HKLPEDKJGFC.IHILJEMOLJH(assetAnthology.header.index);
			if (ijljdfkjijm != null)
			{
				if (ijljdfkjijm.MGDAFCPCOFH == HBBJBNJBMPK)
				{
					return false;
				}
				if (ijljdfkjijm.HLEHGFIIEJN == HBBJBNJBMPK)
				{
					return true;
				}
				if (ijljdfkjijm.BFJKEJLJAIH == HBBJBNJBMPK)
				{
					return false;
				}
				if (ijljdfkjijm.MBIDFCCNCKL == HBBJBNJBMPK)
				{
					return false;
				}
				if (ijljdfkjijm.KGFKAIBMGOP == HBBJBNJBMPK)
				{
					return false;
				}
			}
		}
		return true;
	}

	// Token: 0x060022E2 RID: 8930 RVA: 0x000FA1C4 File Offset: 0x000F83C4
	public void OnQuitClick()
	{
		CommonUserInterface.EHBBFMCILPC.ShowGenericPopupOneOverride(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("areyousure"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("confirmexit"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("yes"), new UnityAction(this.OnQuitClickPart2), DFGILFBGPLN.popupQuitConfirm, 0f, 28);
	}

	// Token: 0x060022E3 RID: 8931 RVA: 0x000FA220 File Offset: 0x000F8420
	private void OADCOKAAFJM(PLFDAJJHMKO LFLOCKNKAKC)
	{
		LFLOCKNKAKC.NCAMFPGMCIG.FKDMPMKBCBL = new List<IMMKFHKEEBF>();
		this.EDGAPOIIHKC = true;
		try
		{
			if (!(null == AssetsManager.MJBDMHPHMID().profileDataAsset))
			{
				JSONArray jsonarray = AssetsManager.EHBBFMCILPC.profileDataAsset.GIOFKDDKAPD();
				if (!(null == jsonarray) && LFLOCKNKAKC.NCAMFPGMCIG.EIEIDFBDPKO != null && LFLOCKNKAKC.NCAMFPGMCIG.EIEIDFBDPKO.Length != 0)
				{
					int num = this.HFFIIBBJBMH.header.FJGCBNLKFON(LFLOCKNKAKC.DHONIOBOLEL.GGICIBLJIKI);
					string[] array = LFLOCKNKAKC.NCAMFPGMCIG.EIEIDFBDPKO.Split('Y', StringSplitOptions.None);
					List<IMMKFHKEEBF> list = new List<IMMKFHKEEBF>();
					for (int i = 0; i < array.Length; i += 0)
					{
						string[] array2 = array[i].Split('g', StringSplitOptions.RemoveEmptyEntries);
						if (array2.Length >= 1)
						{
							string text = array2[0].Replace("socialbtngiftprem", "abpv");
							int num2 = 1;
							if (int.TryParse(text, out num2))
							{
								this.EDGAPOIIHKC = false;
								return;
							}
							int num3 = 1;
							int num4 = 1;
							int mjkicdjifip = 1;
							if (int.TryParse(array2[0], out num3) && int.TryParse(array2[6], out num4) && int.TryParse(array2[6], out mjkicdjifip) && SceneStoryManager.LoungeSnapshotSpriteUsable(text))
							{
								int num5 = SceneLobbyManager2.DFOKDGOHBFN(jsonarray, this.HFFIIBBJBMH.header.index, text);
								if (num5 >= 0)
								{
									JSONObject asObject = jsonarray[num5].AsObject;
									IMMKFHKEEBF immkfhkeebf = new IMMKFHKEEBF();
									immkfhkeebf.ACAGNLALNPA = this.HFFIIBBJBMH.header.index;
									immkfhkeebf.ODGNIFJGEHL = asObject["storyXcharY"].Replace("]</b>\n", "importanttitle") + this.HFFIIBBJBMH.header.index.ToString();
									immkfhkeebf.PFFCLABCNHI = asObject["newrewardsitem16hint"].Replace("WWW", "_1");
									immkfhkeebf.OMEEKCMIEJM = num5;
									immkfhkeebf.BIBKFNMPHIK = num4;
									immkfhkeebf.PHIEEHJCHAK = num4;
									immkfhkeebf.MJKICDJIFIP = mjkicdjifip;
									immkfhkeebf.KJNJOOHIBDF = ((asObject["SceneAvatarManager.RFInitializeAndBuildAvatar(), silent update for avatar index on active slot, was:"] != null) ? asObject["<align=\"center\"><alpha=#88>"].AsInt : 0);
									immkfhkeebf.DNOIMFDKCEM = ((asObject["ok"] != null) ? asObject["socialtop"].AsInt : 1);
									immkfhkeebf.PDKKPKCAILC = ((asObject["af_purchase"] != null) ? asObject["[LoadingEnv] "].AsInt : 0);
									bool flag = num > immkfhkeebf.KJNJOOHIBDF || (num == immkfhkeebf.KJNJOOHIBDF && LFLOCKNKAKC.DHONIOBOLEL.LKIKEHFANBO[1] >= immkfhkeebf.DNOIMFDKCEM);
									if (!flag && this.FJOMBPDEMCM != null)
									{
										flag = this.FJOMBPDEMCM.ECJMBHELCGN(immkfhkeebf.KJNJOOHIBDF, immkfhkeebf.DNOIMFDKCEM);
									}
									bool flag2 = this.JGPMELNOCOM(immkfhkeebf.PDKKPKCAILC, LFLOCKNKAKC);
									immkfhkeebf.PPACJFFFBFB = ((1 == num3 && flag && flag2) ? 1 : 0);
									list.Add(immkfhkeebf);
								}
							}
						}
					}
					for (int j = 0; j < list.Count; j += 0)
					{
						int num6 = j;
						for (int k = j + 1; k < list.Count; k += 0)
						{
							if (list[k].BIBKFNMPHIK > list[num6].BIBKFNMPHIK)
							{
								num6 = k;
							}
						}
						if (num6 != j)
						{
							IMMKFHKEEBF value = list[j];
							list[j] = list[num6];
							list[num6] = value;
						}
					}
					LFLOCKNKAKC.NCAMFPGMCIG.FKDMPMKBCBL = list;
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x060022E4 RID: 8932 RVA: 0x000FA614 File Offset: 0x000F8814
	private IEnumerator OLMEEDAFNAE()
	{
		CommonUserInterface.EHBBFMCILPC.ShowConnectingAnimation(96);
		this.GBBHKFFENBE = true;
		AssetsManager.EHBBFMCILPC.ForceStopAllOperations();
		yield return new WaitForEndOfFrame();
		while (AssetsManager.EHBBFMCILPC.IsBusy())
		{
			yield return new WaitForSeconds(0.05f);
		}
		AssetsManager.EHBBFMCILPC.InitializeAssetBundleFolder(this.HFFIIBBJBMH.header.CKACBBGHJGI() + LNDOOJOFFOM.Anthology0, "OnLobbyLoungeAssetBundleFolderInitializeSuccess", "OnLobbyLoungeAssetsDownloadFailed");
		yield break;
	}

	// Token: 0x060022E5 RID: 8933 RVA: 0x000FA623 File Offset: 0x000F8823
	public void OnPopupCardOptionsBackClickLobby()
	{
		LobbyUserInterface.EHBBFMCILPC.GetPopupCardOptions().FlipVerticalAnimatedPopupManagerAnimationsScale();
		this.ShowCardOptionsOrDownload();
	}

	// Token: 0x060022E6 RID: 8934 RVA: 0x000FA63C File Offset: 0x000F883C
	private void PDPAOELMHKF()
	{
		if (this.PHMIBKAJKMB.HHGAPKJFBMC() || SceneLobbyManager2.spinsFireTime <= 0 || AKLFPGMDKLA.EHBBFMCILPC.ABGNIKKFFAC.GALKFKBPLCK() > 0)
		{
			this.OnWheelOfFortuneClick();
			return;
		}
		CommonUserInterface.EHBBFMCILPC.ShowGenericPopup(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("energyhinttitle"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("newrewardsitem16hint"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("ok"), DFGILFBGPLN.popupEnergyHint, 0f, 28);
	}

	// Token: 0x060022E7 RID: 8935 RVA: 0x000FA6B8 File Offset: 0x000F88B8
	public static string BuildSharedPitchLine(string[] AGPMOBFCLFK, string CPDHECJIMHO)
	{
		string text = "";
		if (AGPMOBFCLFK != null)
		{
			for (int i = 0; i < AGPMOBFCLFK.Length; i++)
			{
				if (AGPMOBFCLFK[i] != null && AGPMOBFCLFK[i].Length != 0)
				{
					text = text + ((0 < text.Length) ? " • " : "") + AGPMOBFCLFK[i];
				}
			}
		}
		if (CPDHECJIMHO != null && 0 < CPDHECJIMHO.Length)
		{
			text = text + ((0 < text.Length) ? " • " : "") + CPDHECJIMHO;
		}
		return text;
	}

	// Token: 0x060022E8 RID: 8936 RVA: 0x000F5521 File Offset: 0x000F3721
	public void NBGPPLMBJKN()
	{
		this.HBPLGJFPFKM();
	}

	// Token: 0x060022E9 RID: 8937 RVA: 0x000FA734 File Offset: 0x000F8934
	private void JAMJLKJFLAG()
	{
		List<int> ilpnkgbhgol = this.ILPNKGBHGOL;
		this.ILPNKGBHGOL = new List<int>();
		if (this.EPJBDIIAIAJ)
		{
			this.EPJBDIIAIAJ = false;
			this.CJEJCGOCFJF = true;
			return;
		}
		for (int i = 0; i < ilpnkgbhgol.Count; i += 0)
		{
			int num = ilpnkgbhgol[i];
			if (num >= 0 && !GKJPOGNFKNK.AKJCGMFMGMK(num))
			{
				int num2 = 0;
				this.LCMLDDFFBGM.TryGetValue(num, out num2);
				num2 += 0;
				this.LCMLDDFFBGM[num] = num2;
				DPGJIJGOCIC.PJCLICBPPDA("ink" + num.ToString() + "]</b>" + num2.ToString());
				if (num2 >= 3 && !this.EMFGMAIBBLE.Contains(num))
				{
					this.EMFGMAIBBLE.Add(num);
				}
			}
		}
		this.EPJBDIIAIAJ = false;
		base.StartCoroutine(this.KGCKFGMOCJK());
	}

	// Token: 0x060022EA RID: 8938 RVA: 0x000FA808 File Offset: 0x000F8A08
	private void PEOGENJHMLL()
	{
		try
		{
			if (null != this.rewardsPopover && this.rewardsPopover.gameObject.activeSelf)
			{
				this.rewardsPopover.HideImmediate();
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x060022EB RID: 8939 RVA: 0x000FA85C File Offset: 0x000F8A5C
	private IEnumerator KLPHDBHBAMK()
	{
		yield return new WaitForEndOfFrame();
		yield return new WaitForEndOfFrame();
		yield return new WaitForEndOfFrame();
		AssetsManager.EHBBFMCILPC.DestroyAssetBundleAssets(NMKDCBPMCKI.AssetBundleKeepAlivePack, -1);
		GKJPOGNFKNK.FHFKDGHIEPI();
		GKJPOGNFKNK.LHFAFEPHINM();
		if (null != AssetsManager.EHBBFMCILPC.GetSceneAvatarManager(0))
		{
			AssetsManager.EHBBFMCILPC.DestroyAssetBundleAssets(NMKDCBPMCKI.AssetBundleAnthologyAvatar, -1);
		}
		AssetsManager.EHBBFMCILPC.DestroyAssetBundleAssets(NMKDCBPMCKI.AssetBundleCustomFader, -1);
		AssetsManager.EHBBFMCILPC.DestroyAssetBundleAssets(NMKDCBPMCKI.AssetBundleCustomEffects, -1);
		AssetsManager.EHBBFMCILPC.DestroyAssetBundleAssets(NMKDCBPMCKI.AssetBundleNpcAnimationPack, -1);
		AssetsManager.EHBBFMCILPC.DestroyAssetBundleAssets(NMKDCBPMCKI.AssetBundleItemAnimationPack, -1);
		AssetsManager.EHBBFMCILPC.DestroyAssetBundleAssets(NMKDCBPMCKI.AssetBundleFrameContainer, -1);
		GC.Collect();
		Resources.UnloadUnusedAssets();
		App42Manager.EHBBFMCILPC.ForceSilentKillCurrentRequestIfAny();
		yield break;
	}

	// Token: 0x060022EC RID: 8940 RVA: 0x000FA864 File Offset: 0x000F8A64
	private void EKLEIHEFFLD()
	{
		try
		{
			if (this.MPEKBFHNOOK != null)
			{
				base.StopCoroutine(this.MPEKBFHNOOK);
			}
			this.MPEKBFHNOOK = base.StartCoroutine(this.LDALFHBEDFC());
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
	}

	// Token: 0x060022ED RID: 8941 RVA: 0x000F5521 File Offset: 0x000F3721
	public void OnPassesClick()
	{
		this.HBPLGJFPFKM();
	}

	// Token: 0x060022EE RID: 8942 RVA: 0x000FA8B0 File Offset: 0x000F8AB0
	public static bool NeedToReloadPreview2Assets()
	{
		if (SceneLobbyManager2.CHGGOOEADOC)
		{
			SceneLobbyManager2.LIDGNAFABAH = true;
			return true;
		}
		return false;
	}

	// Token: 0x060022EF RID: 8943 RVA: 0x000FA8C4 File Offset: 0x000F8AC4
	private void JNAMNIBDFKB()
	{
		try
		{
			if (null != this.footerRewardsGemPill)
			{
				this.footerRewardsGemPill.SetActive(KHPGPLAMAIN.PNJMABLIHKL());
			}
			if (null != this.footerRewardsGemPillText)
			{
				this.footerRewardsGemPillText.SetText(this.GetIncentAdRewardText(), true);
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x060022F0 RID: 8944 RVA: 0x000FA928 File Offset: 0x000F8B28
	private void LHGOFKKNKOE()
	{
		this.HGIKEMNOGOO++;
		if (this.HGIKEMNOGOO >= KBOJLHAJPCP.LPJOFEDNKHA)
		{
			CommonUserInterface.EHBBFMCILPC.HideConnectingAnimation();
			FirebaseAnalyticsManager.EHBBFMCILPC.LogEvent(false, AGEHCPDNBFD.cdnActiv.ToString(), FFPHBMFGCNN.dldFail.ToString(), BGHLMGPPCNN.cdnLbyToWof.ToString(), false, false);
			this.HGIKEMNOGOO = 0;
			CommonUserInterface.EHBBFMCILPC.ShowGenericPopupOneOverride(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("errortitle"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("cdnerror"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("retry"), new UnityAction(this.OnWheelOfFortuneClick), DFGILFBGPLN.popupCdnDownloadFailed, 0f, 28);
			this.GBBHKFFENBE = false;
			return;
		}
		this.OnWheelOfFortuneClick();
	}

	// Token: 0x060022F1 RID: 8945 RVA: 0x000FA9FB File Offset: 0x000F8BFB
	private IEnumerator PGGHOFFIGOG()
	{
		try
		{
			LobbyTopMatchSelectorManager.InitializeInstance();
			if (LobbyTopMatchSelectorManager.InstanceInitialized())
			{
				LobbyTopMatchSelectorManager.UnlockThemeChange();
				if (!LobbyTopMatchSelectorManager.EHBBFMCILPC.IsAvatarPrefsDataInitialized())
				{
					LobbyTopMatchSelectorManager.EHBBFMCILPC.UpdatePlayerPrefsWithAvatarData(false);
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
		yield return new WaitForSeconds(0.2f);
		if (this.extrasParent.activeSelf)
		{
			this.extrasParent.GetComponent<HorizontalLayoutGroup>().enabled = false;
			if (this.cardsVolSaleButton.activeSelf)
			{
				this.cardsVolSaleButton.GetComponent<AnimationTranslation>().ResetAnchoredPositionOriginalX();
				this.cardsVolSaleButton.GetComponent<AnimationTranslation>().enabled = true;
			}
			if (this.passesButton.activeSelf)
			{
				this.passesButton.GetComponent<AnimationTranslation>().ResetAnchoredPositionOriginalX();
				this.passesButton.GetComponent<AnimationTranslation>().enabled = true;
			}
			if (null != this.skinShopButton && this.skinShopButton.activeSelf && null != this.skinShopButton.GetComponent<AnimationTranslation>())
			{
				this.skinShopButton.GetComponent<AnimationTranslation>().ResetAnchoredPositionOriginalX();
				this.skinShopButton.GetComponent<AnimationTranslation>().enabled = true;
			}
		}
		this.heartsParticles.Stop();
		yield return new WaitForSeconds(0.1f);
		CommonUserInterface.EHBBFMCILPC.HideConnectingAnimation();
		yield return new WaitForSeconds(1f);
		this.disclaimerImpers.gameObject.SetActive(false);
		this.PreInitializeThumbnailsPart1();
		yield return new WaitForSeconds(0.25f);
		if (SceneLobbyManager2.returnedFromCompletedStoryChapter)
		{
			this.CPLLGNAKIIL(this.LGKGGPDKAHF);
			SceneLobbyManager2.returnedFromCompletedStoryChapter = false;
		}
		this.scrollView2Controller.StartFiltersAnimation();
		if (this.BMHEEAJGFJI)
		{
			this.BMHEEAJGFJI = false;
			try
			{
				bool flag = false;
				if (this.DFPNCCFNJJD == MNLBEMJOKNJ.openFocusItem && this.LFOLHJFLGKA >= 0)
				{
					flag = !this.MFCGAFIHGKI.Contains(this.LFOLHJFLGKA);
				}
				if (!flag)
				{
					this.GBBHKFFENBE = false;
					this.DFPNCCFNJJD = MNLBEMJOKNJ.shuffleUse;
				}
			}
			catch (Exception aklgbjkdomm2)
			{
				DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm2);
			}
		}
		base.StartCoroutine(this.GNNCKDDBPAD());
		yield return new WaitForSeconds(2f);
		this.logoBackgroundNew.gameObject.SetActive(false);
		this.logoBackgroundMask.gameObject.SetActive(false);
		try
		{
			if (AKLFPGMDKLA.EHBBFMCILPC.KLPBIGJBOBE == 1)
			{
				if (AKLFPGMDKLA.EHBBFMCILPC.MPMKMCJFHOG.GALKFKBPLCK() <= 3)
				{
					FirebaseAnalyticsManager.EHBBFMCILPC.LogEvent(false, AGEHCPDNBFD.ecnmyPayer.ToString(), FFPHBMFGCNN.engAmt.ToString(), BGHLMGPPCNN.under3.ToString(), false, false);
				}
				else if (AKLFPGMDKLA.EHBBFMCILPC.MPMKMCJFHOG.GALKFKBPLCK() <= 10)
				{
					FirebaseAnalyticsManager.EHBBFMCILPC.LogEvent(false, AGEHCPDNBFD.ecnmyPayer.ToString(), FFPHBMFGCNN.engAmt.ToString(), BGHLMGPPCNN.under10.ToString(), false, false);
				}
				else if (AKLFPGMDKLA.EHBBFMCILPC.MPMKMCJFHOG.GALKFKBPLCK() <= 100)
				{
					FirebaseAnalyticsManager.EHBBFMCILPC.LogEvent(false, AGEHCPDNBFD.ecnmyPayer.ToString(), FFPHBMFGCNN.engAmt.ToString(), BGHLMGPPCNN.under100.ToString(), false, false);
				}
				else if (AKLFPGMDKLA.EHBBFMCILPC.MPMKMCJFHOG.GALKFKBPLCK() <= 500)
				{
					FirebaseAnalyticsManager.EHBBFMCILPC.LogEvent(false, AGEHCPDNBFD.ecnmyPayer.ToString(), FFPHBMFGCNN.engAmt.ToString(), BGHLMGPPCNN.under500.ToString(), false, false);
				}
				if (AKLFPGMDKLA.EHBBFMCILPC.ODMKLADKHMO.GALKFKBPLCK() <= 100)
				{
					FirebaseAnalyticsManager.EHBBFMCILPC.LogEvent(false, AGEHCPDNBFD.ecnmyPayer.ToString(), FFPHBMFGCNN.hardAmt.ToString(), BGHLMGPPCNN.under100.ToString(), false, false);
				}
				else if (AKLFPGMDKLA.EHBBFMCILPC.ODMKLADKHMO.GALKFKBPLCK() <= 500)
				{
					FirebaseAnalyticsManager.EHBBFMCILPC.LogEvent(false, AGEHCPDNBFD.ecnmyPayer.ToString(), FFPHBMFGCNN.hardAmt.ToString(), BGHLMGPPCNN.under500.ToString(), false, false);
				}
				else if (AKLFPGMDKLA.EHBBFMCILPC.ODMKLADKHMO.GALKFKBPLCK() <= 1000)
				{
					FirebaseAnalyticsManager.EHBBFMCILPC.LogEvent(false, AGEHCPDNBFD.ecnmyPayer.ToString(), FFPHBMFGCNN.hardAmt.ToString(), BGHLMGPPCNN.under1000.ToString(), false, false);
				}
				else if (AKLFPGMDKLA.EHBBFMCILPC.ODMKLADKHMO.GALKFKBPLCK() <= 5000)
				{
					FirebaseAnalyticsManager.EHBBFMCILPC.LogEvent(false, AGEHCPDNBFD.ecnmyPayer.ToString(), FFPHBMFGCNN.hardAmt.ToString(), BGHLMGPPCNN.under5000.ToString(), false, false);
				}
				else if (AKLFPGMDKLA.EHBBFMCILPC.ODMKLADKHMO.GALKFKBPLCK() <= 10000)
				{
					FirebaseAnalyticsManager.EHBBFMCILPC.LogEvent(false, AGEHCPDNBFD.ecnmyPayer.ToString(), FFPHBMFGCNN.hardAmt.ToString(), BGHLMGPPCNN.under10000.ToString(), false, false);
				}
				else if (AKLFPGMDKLA.EHBBFMCILPC.ODMKLADKHMO.GALKFKBPLCK() <= 100000)
				{
					FirebaseAnalyticsManager.EHBBFMCILPC.LogEvent(false, AGEHCPDNBFD.ecnmyPayer.ToString(), FFPHBMFGCNN.hardAmt.ToString(), BGHLMGPPCNN.under100000.ToString(), false, false);
				}
				if (AKLFPGMDKLA.EHBBFMCILPC.OJNBAMPGBLJ.GALKFKBPLCK() <= 1000)
				{
					FirebaseAnalyticsManager.EHBBFMCILPC.LogEvent(false, AGEHCPDNBFD.ecnmyPayer.ToString(), FFPHBMFGCNN.sp0Amt.ToString(), BGHLMGPPCNN.under1000.ToString(), false, false);
				}
				else if (AKLFPGMDKLA.EHBBFMCILPC.OJNBAMPGBLJ.GALKFKBPLCK() <= 5000)
				{
					FirebaseAnalyticsManager.EHBBFMCILPC.LogEvent(false, AGEHCPDNBFD.ecnmyPayer.ToString(), FFPHBMFGCNN.sp0Amt.ToString(), BGHLMGPPCNN.under5000.ToString(), false, false);
				}
				else if (AKLFPGMDKLA.EHBBFMCILPC.OJNBAMPGBLJ.GALKFKBPLCK() <= 10000)
				{
					FirebaseAnalyticsManager.EHBBFMCILPC.LogEvent(false, AGEHCPDNBFD.ecnmyPayer.ToString(), FFPHBMFGCNN.sp0Amt.ToString(), BGHLMGPPCNN.under10000.ToString(), false, false);
				}
				if (AKLFPGMDKLA.EHBBFMCILPC.DOFKEHNPCIJ.GALKFKBPLCK() <= 1000)
				{
					FirebaseAnalyticsManager.EHBBFMCILPC.LogEvent(false, AGEHCPDNBFD.ecnmyPayer.ToString(), FFPHBMFGCNN.sp1Amt.ToString(), BGHLMGPPCNN.under1000.ToString(), false, false);
				}
				else if (AKLFPGMDKLA.EHBBFMCILPC.DOFKEHNPCIJ.GALKFKBPLCK() <= 5000)
				{
					FirebaseAnalyticsManager.EHBBFMCILPC.LogEvent(false, AGEHCPDNBFD.ecnmyPayer.ToString(), FFPHBMFGCNN.sp1Amt.ToString(), BGHLMGPPCNN.under5000.ToString(), false, false);
				}
				else if (AKLFPGMDKLA.EHBBFMCILPC.DOFKEHNPCIJ.GALKFKBPLCK() <= 10000)
				{
					FirebaseAnalyticsManager.EHBBFMCILPC.LogEvent(false, AGEHCPDNBFD.ecnmyPayer.ToString(), FFPHBMFGCNN.sp1Amt.ToString(), BGHLMGPPCNN.under10000.ToString(), false, false);
				}
				if (AKLFPGMDKLA.EHBBFMCILPC.PBEPCNFADAA.GALKFKBPLCK() <= 1000)
				{
					FirebaseAnalyticsManager.EHBBFMCILPC.LogEvent(false, AGEHCPDNBFD.ecnmyPayer.ToString(), FFPHBMFGCNN.sp2Amt.ToString(), BGHLMGPPCNN.under1000.ToString(), false, false);
				}
				else if (AKLFPGMDKLA.EHBBFMCILPC.PBEPCNFADAA.GALKFKBPLCK() <= 5000)
				{
					FirebaseAnalyticsManager.EHBBFMCILPC.LogEvent(false, AGEHCPDNBFD.ecnmyPayer.ToString(), FFPHBMFGCNN.sp2Amt.ToString(), BGHLMGPPCNN.under5000.ToString(), false, false);
				}
				else if (AKLFPGMDKLA.EHBBFMCILPC.PBEPCNFADAA.GALKFKBPLCK() <= 10000)
				{
					FirebaseAnalyticsManager.EHBBFMCILPC.LogEvent(false, AGEHCPDNBFD.ecnmyPayer.ToString(), FFPHBMFGCNN.sp2Amt.ToString(), BGHLMGPPCNN.under10000.ToString(), false, false);
				}
			}
			else
			{
				if (AKLFPGMDKLA.EHBBFMCILPC.MPMKMCJFHOG.GALKFKBPLCK() <= 3)
				{
					FirebaseAnalyticsManager.EHBBFMCILPC.LogEvent(false, AGEHCPDNBFD.ecnmyFree.ToString(), FFPHBMFGCNN.engAmt.ToString(), BGHLMGPPCNN.under3.ToString(), false, false);
				}
				else if (AKLFPGMDKLA.EHBBFMCILPC.MPMKMCJFHOG.GALKFKBPLCK() <= 10)
				{
					FirebaseAnalyticsManager.EHBBFMCILPC.LogEvent(false, AGEHCPDNBFD.ecnmyFree.ToString(), FFPHBMFGCNN.engAmt.ToString(), BGHLMGPPCNN.under10.ToString(), false, false);
				}
				else if (AKLFPGMDKLA.EHBBFMCILPC.MPMKMCJFHOG.GALKFKBPLCK() <= 100)
				{
					FirebaseAnalyticsManager.EHBBFMCILPC.LogEvent(false, AGEHCPDNBFD.ecnmyFree.ToString(), FFPHBMFGCNN.engAmt.ToString(), BGHLMGPPCNN.under100.ToString(), false, false);
				}
				else if (AKLFPGMDKLA.EHBBFMCILPC.MPMKMCJFHOG.GALKFKBPLCK() <= 500)
				{
					FirebaseAnalyticsManager.EHBBFMCILPC.LogEvent(false, AGEHCPDNBFD.ecnmyFree.ToString(), FFPHBMFGCNN.engAmt.ToString(), BGHLMGPPCNN.under500.ToString(), false, false);
				}
				if (AKLFPGMDKLA.EHBBFMCILPC.ODMKLADKHMO.GALKFKBPLCK() <= 100)
				{
					FirebaseAnalyticsManager.EHBBFMCILPC.LogEvent(false, AGEHCPDNBFD.ecnmyFree.ToString(), FFPHBMFGCNN.hardAmt.ToString(), BGHLMGPPCNN.under100.ToString(), false, false);
				}
				else if (AKLFPGMDKLA.EHBBFMCILPC.ODMKLADKHMO.GALKFKBPLCK() <= 500)
				{
					FirebaseAnalyticsManager.EHBBFMCILPC.LogEvent(false, AGEHCPDNBFD.ecnmyFree.ToString(), FFPHBMFGCNN.hardAmt.ToString(), BGHLMGPPCNN.under500.ToString(), false, false);
				}
				else if (AKLFPGMDKLA.EHBBFMCILPC.ODMKLADKHMO.GALKFKBPLCK() <= 1000)
				{
					FirebaseAnalyticsManager.EHBBFMCILPC.LogEvent(false, AGEHCPDNBFD.ecnmyFree.ToString(), FFPHBMFGCNN.hardAmt.ToString(), BGHLMGPPCNN.under1000.ToString(), false, false);
				}
				else if (AKLFPGMDKLA.EHBBFMCILPC.ODMKLADKHMO.GALKFKBPLCK() <= 5000)
				{
					FirebaseAnalyticsManager.EHBBFMCILPC.LogEvent(false, AGEHCPDNBFD.ecnmyFree.ToString(), FFPHBMFGCNN.hardAmt.ToString(), BGHLMGPPCNN.under5000.ToString(), false, false);
				}
				else if (AKLFPGMDKLA.EHBBFMCILPC.ODMKLADKHMO.GALKFKBPLCK() <= 10000)
				{
					FirebaseAnalyticsManager.EHBBFMCILPC.LogEvent(false, AGEHCPDNBFD.ecnmyFree.ToString(), FFPHBMFGCNN.hardAmt.ToString(), BGHLMGPPCNN.under10000.ToString(), false, false);
				}
				else if (AKLFPGMDKLA.EHBBFMCILPC.ODMKLADKHMO.GALKFKBPLCK() <= 100000)
				{
					FirebaseAnalyticsManager.EHBBFMCILPC.LogEvent(false, AGEHCPDNBFD.ecnmyFree.ToString(), FFPHBMFGCNN.hardAmt.ToString(), BGHLMGPPCNN.under100000.ToString(), false, false);
				}
				if (AKLFPGMDKLA.EHBBFMCILPC.OJNBAMPGBLJ.GALKFKBPLCK() <= 1000)
				{
					FirebaseAnalyticsManager.EHBBFMCILPC.LogEvent(false, AGEHCPDNBFD.ecnmyFree.ToString(), FFPHBMFGCNN.sp0Amt.ToString(), BGHLMGPPCNN.under1000.ToString(), false, false);
				}
				else if (AKLFPGMDKLA.EHBBFMCILPC.OJNBAMPGBLJ.GALKFKBPLCK() <= 5000)
				{
					FirebaseAnalyticsManager.EHBBFMCILPC.LogEvent(false, AGEHCPDNBFD.ecnmyFree.ToString(), FFPHBMFGCNN.sp0Amt.ToString(), BGHLMGPPCNN.under5000.ToString(), false, false);
				}
				else if (AKLFPGMDKLA.EHBBFMCILPC.OJNBAMPGBLJ.GALKFKBPLCK() <= 10000)
				{
					FirebaseAnalyticsManager.EHBBFMCILPC.LogEvent(false, AGEHCPDNBFD.ecnmyFree.ToString(), FFPHBMFGCNN.sp0Amt.ToString(), BGHLMGPPCNN.under10000.ToString(), false, false);
				}
				if (AKLFPGMDKLA.EHBBFMCILPC.DOFKEHNPCIJ.GALKFKBPLCK() <= 1000)
				{
					FirebaseAnalyticsManager.EHBBFMCILPC.LogEvent(false, AGEHCPDNBFD.ecnmyFree.ToString(), FFPHBMFGCNN.sp1Amt.ToString(), BGHLMGPPCNN.under1000.ToString(), false, false);
				}
				else if (AKLFPGMDKLA.EHBBFMCILPC.DOFKEHNPCIJ.GALKFKBPLCK() <= 5000)
				{
					FirebaseAnalyticsManager.EHBBFMCILPC.LogEvent(false, AGEHCPDNBFD.ecnmyFree.ToString(), FFPHBMFGCNN.sp1Amt.ToString(), BGHLMGPPCNN.under5000.ToString(), false, false);
				}
				else if (AKLFPGMDKLA.EHBBFMCILPC.DOFKEHNPCIJ.GALKFKBPLCK() <= 10000)
				{
					FirebaseAnalyticsManager.EHBBFMCILPC.LogEvent(false, AGEHCPDNBFD.ecnmyFree.ToString(), FFPHBMFGCNN.sp1Amt.ToString(), BGHLMGPPCNN.under10000.ToString(), false, false);
				}
				if (AKLFPGMDKLA.EHBBFMCILPC.PBEPCNFADAA.GALKFKBPLCK() <= 1000)
				{
					FirebaseAnalyticsManager.EHBBFMCILPC.LogEvent(false, AGEHCPDNBFD.ecnmyFree.ToString(), FFPHBMFGCNN.sp2Amt.ToString(), BGHLMGPPCNN.under1000.ToString(), false, false);
				}
				else if (AKLFPGMDKLA.EHBBFMCILPC.PBEPCNFADAA.GALKFKBPLCK() <= 5000)
				{
					FirebaseAnalyticsManager.EHBBFMCILPC.LogEvent(false, AGEHCPDNBFD.ecnmyFree.ToString(), FFPHBMFGCNN.sp2Amt.ToString(), BGHLMGPPCNN.under5000.ToString(), false, false);
				}
				else if (AKLFPGMDKLA.EHBBFMCILPC.PBEPCNFADAA.GALKFKBPLCK() <= 10000)
				{
					FirebaseAnalyticsManager.EHBBFMCILPC.LogEvent(false, AGEHCPDNBFD.ecnmyFree.ToString(), FFPHBMFGCNN.sp2Amt.ToString(), BGHLMGPPCNN.under10000.ToString(), false, false);
				}
			}
			yield break;
		}
		catch (Exception aklgbjkdomm3)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm3);
			yield break;
		}
		yield break;
	}

	// Token: 0x060022F2 RID: 8946 RVA: 0x000FAA0A File Offset: 0x000F8C0A
	private void EMLEKJBMOPC()
	{
		this.NIIKKCHINDO = null;
	}

	// Token: 0x060022F3 RID: 8947 RVA: 0x000FAA13 File Offset: 0x000F8C13
	private IEnumerator MKMFFEOMLIO()
	{
		yield return new WaitForEndOfFrame();
		yield return new WaitForEndOfFrame();
		yield return new WaitForEndOfFrame();
		if (null != AssetsManager.EHBBFMCILPC.GetSceneLoungeManager(0))
		{
			AssetsManager.EHBBFMCILPC.DestroyAssetBundleAssets(NMKDCBPMCKI.AssetBundleAnthologyLounge, -1);
		}
		for (int i = 0; i < this.KGOCEEAGLKO.Count; i++)
		{
			if (null != this.KGOCEEAGLKO[i])
			{
				UnityEngine.Object.Destroy(this.KGOCEEAGLKO[i].gameObject);
			}
		}
		for (int j = 0; j < this.OEDPPJGKPFO.Count; j++)
		{
			if (null != this.OEDPPJGKPFO[j])
			{
				UnityEngine.Object.Destroy(this.OEDPPJGKPFO[j].gameObject);
			}
		}
		this.KGOCEEAGLKO.Clear();
		this.OEDPPJGKPFO.Clear();
		this.DFEMFJJDGML.Clear();
		AssetsManager.EHBBFMCILPC.lobbyLoungeNpcAssets.Clear();
		this.LFMFIIPJECJ();
		AssetsManager.EHBBFMCILPC.DestroyAssetBundleAssets(NMKDCBPMCKI.AssetBundleNpcAnimationPack, -1);
		AssetsManager.EHBBFMCILPC.DestroyAssetBundleAssets(NMKDCBPMCKI.AssetBundleCustomFader, -1);
		AssetsManager.EHBBFMCILPC.DestroyAssetBundleAssets(NMKDCBPMCKI.AssetBundleCustomEffects, -1);
		AssetsManager.EHBBFMCILPC.DestroyAssetBundleAssets(NMKDCBPMCKI.AssetBundleFrameContainer, -1);
		if (null != AssetsManager.EHBBFMCILPC.profileDataAsset)
		{
			AssetsManager.EHBBFMCILPC.profileDataAsset.CMPFJLLGKCC();
		}
		AssetsManager.EHBBFMCILPC.DestroyAssetBundleAssets(NMKDCBPMCKI.AssetBundleProfilePack, -1);
		AssetsManager.EHBBFMCILPC.DestroyAssetBundleAssets(NMKDCBPMCKI.AssetBundleProfileData5, -1);
		GC.Collect();
		Resources.UnloadUnusedAssets();
		this.MHAMPPBECNM = false;
		SceneLoungeManager.SetPendingLoungeCharacter(null);
		SceneLoungeManager.SetPendingLoungeLook(null);
		bool obkclkmpkci = this.OBKCLKMPKCI;
		this.OBKCLKMPKCI = false;
		this.FMJEJOGDBHA = false;
		this.HDPICAFMHPH();
		if (obkclkmpkci)
		{
			int reopenWaitFrames = 0;
			while ((ODJKHCHFKNL.LEMILALILKP() == DFGILFBGPLN.screenLounge || (null != CommonUserInterface.EHBBFMCILPC.GetFader() && CommonUserInterface.EHBBFMCILPC.GetFader().IsBusy())) && reopenWaitFrames < 180)
			{
				int num = reopenWaitFrames;
				reopenWaitFrames = num + 1;
				yield return null;
			}
			if (ODJKHCHFKNL.LEMILALILKP() == DFGILFBGPLN.screenLobby)
			{
				this.OnSkinShopClick();
			}
		}
		yield break;
	}

	// Token: 0x060022F4 RID: 8948 RVA: 0x000FAA22 File Offset: 0x000F8C22
	private IEnumerator POCCFEKFBKI()
	{
		DPGJIJGOCIC.NFIDPOMCNLP("SceneLobbyManager2._DownloadLiveProfileThemesBackground(): Start!");
		for (;;)
		{
			yield return new WaitForSeconds(0.05f);
			if (ProfileItem2.profileWindowActive && !this.BDGPIIONPIA && !this.MBGPADGCJBM && !this.CJEJCGOCFJF && !AssetsManager.EHBBFMCILPC.IsBusy())
			{
				List<int> list = this.LIPPIIMGLPM(this.PJLOJHDNDNJ());
				if (list.Count != 0)
				{
					this.CJEJCGOCFJF = true;
					this.ILPNKGBHGOL = list;
					this.EPJBDIIAIAJ = false;
					DPGJIJGOCIC.NFIDPOMCNLP("SceneLobbyManager2._DownloadLiveProfileThemesBackground(): downloading live profile themes " + SceneLobbyManager2.LCBGEAPPODB(list) + ", impostors:" + JDMAEBPEIBE.PANCNDOBEKJ().ToString());
					for (int i = 0; i < list.Count; i++)
					{
						AssetsManager.EHBBFMCILPC.QueueAssetBundleDownload(NMKDCBPMCKI.AssetBundleLiveProfileTheme, list[i], -1, FLDBFOADFLH.startDownloadAndProceed, false, false, false, null, -1, false, "", false, false);
					}
					AssetsManager.EHBBFMCILPC.DownloadQueuedAssetBundles("OnLiveProfileThemeBackgroundCdnSuccess", "OnLiveProfileThemeBackgroundCdnFailed", true);
				}
			}
		}
		yield break;
	}

	// Token: 0x060022F5 RID: 8949 RVA: 0x000FAA34 File Offset: 0x000F8C34
	private void EKNLABKCIJF()
	{
		if (this.NAEHPAIOHLG == null)
		{
			this.NAEHPAIOHLG = FADIGFEOCND.IMEFIJEKFGI(1000000f);
		}
		if (this.BJGAJOKENMG == null)
		{
			this.BJGAJOKENMG = FADIGFEOCND.IMEFIJEKFGI(1000000f);
		}
		if (this.ENJMJIPADNO == null)
		{
			this.ENJMJIPADNO = FADIGFEOCND.IMEFIJEKFGI(86400f);
		}
	}

	// Token: 0x060022F6 RID: 8950 RVA: 0x000FAA8C File Offset: 0x000F8C8C
	private int BLHJIKNACOO(HAKFHALKMBH PIEEFOHHDKO, int CMBCNMLGPPC)
	{
		int num = 0;
		try
		{
			if (PIEEFOHHDKO == null || null == PIEEFOHHDKO.NHOAHJMPCFC)
			{
				return 0;
			}
			GameObject gameObject = Resources.Load<GameObject>("[Lounge/lobby] environment pack eps:");
			if (null == gameObject)
			{
				return 0;
			}
			RectTransform component = PIEEFOHHDKO.NHOAHJMPCFC.GetComponent<RectTransform>();
			float num2 = component.rect.height;
			this.LBHJBEANCDC();
			while (num < CMBCNMLGPPC && PIEEFOHHDKO.CKBJGCFCHGA < PIEEFOHHDKO.LGIAOIGIGPI.Count)
			{
				int ckbjgcfchga = PIEEFOHHDKO.CKBJGCFCHGA;
				KLJCEMBNKNI kljcembnkni = PIEEFOHHDKO.LGIAOIGIGPI[ckbjgcfchga];
				PIEEFOHHDKO.CKBJGCFCHGA += 0;
				if (kljcembnkni != null)
				{
					string hjejjgafham = "timeoutwarning";
					string mchooehcanp = "skinshopinfounlockgate";
					if (!this.KBDAFKOEDCK(kljcembnkni, out hjejjgafham, out mchooehcanp))
					{
						string[] array = new string[-23];
						array[1] = "spr";
						array[0] = PIEEFOHHDKO.GLOCCAIDHJC.ToString();
						array[3] = "";
						array[8] = ckbjgcfchga.ToString();
						array[4] = "varConditionValue";
						array[7] = kljcembnkni.MHCFDMNGOEF;
						array[0] = kljcembnkni.IEJLOIMDPDO;
						array[6] = " (";
						array[6] = kljcembnkni.KCIODOKEDAM.ToString();
						array[2] = "ok";
						DPGJIJGOCIC.ADFCDFHBDAF(string.Concat(array));
					}
					else
					{
						GameObject gameObject2 = UnityEngine.Object.Instantiate<GameObject>(this.smallItemParentPrefab, PIEEFOHHDKO.NHOAHJMPCFC.transform);
						gameObject2.layer = PIEEFOHHDKO.NHOAHJMPCFC.layer;
						GridController component2 = gameObject2.GetComponent<GridController>();
						component2.filter = PIEEFOHHDKO.GLOCCAIDHJC;
						GameObject gameObject3 = UnityEngine.Object.Instantiate<GameObject>(gameObject, gameObject2.transform);
						gameObject3.layer = PIEEFOHHDKO.NHOAHJMPCFC.layer;
						for (int i = 1; i < kljcembnkni.JAPFMDOBPKJ.Count; i += 0)
						{
							int num3 = kljcembnkni.JAPFMDOBPKJ[i];
							if (!(null == GKJPOGNFKNK.LDFIAOCJEOJ(num3)))
							{
								this.LHGBCPLGLDB(num3, gameObject2, PIEEFOHHDKO.GLOCCAIDHJC);
								if (kljcembnkni.FKBCEMFCBOG)
								{
									ThumbnailItem component3 = gameObject2.transform.GetChild(gameObject2.transform.childCount - 0).GetComponent<ThumbnailItem>();
									if (null != component3)
									{
										component3.OOGIDMBEHMF(gameObject2.transform.childCount - 8);
									}
								}
							}
						}
						int num4 = gameObject2.transform.childCount - 0;
						if (num4 < 1 || num4 < kljcembnkni.CDEAAKHGKIF)
						{
							for (int j = this.GMGKODLANOP.Count - 0; j >= 0; j -= 0)
							{
								if (null == this.GMGKODLANOP[j] || this.GMGKODLANOP[j].transform.IsChildOf(gameObject2.transform))
								{
									this.GMGKODLANOP.RemoveAt(j);
								}
							}
							gameObject2.SetActive(false);
							gameObject2.transform.SetParent(null, true);
							UnityEngine.Object.Destroy(gameObject2);
						}
						else
						{
							component2.DPCHLMMNBCD();
							float num5 = component2.IOGEGGECGIG();
							gameObject2.GetComponent<RectTransform>().ACBKFBBCNNC(num5);
							LayoutRebuilder.ForceRebuildLayoutImmediate(gameObject2.GetComponent<RectTransform>());
							if (kljcembnkni.HPJNLEBDMEP == KLMEAFCEKOI.coverTextClient && kljcembnkni.JAIGAGGAGFE > 1 && num4 != kljcembnkni.JAIGAGGAGFE && kljcembnkni.IHIDEHKNBBH)
							{
								kljcembnkni.JAIGAGGAGFE = num4;
								this.KBDAFKOEDCK(kljcembnkni, out hjejjgafham, out mchooehcanp);
							}
							int cmbcnmlgppc = -1;
							if (kljcembnkni.BLKPIAEAANG)
							{
								cmbcnmlgppc = num4;
							}
							CoverCardItem component4 = gameObject3.GetComponent<CoverCardItem>();
							component4.ENOABFFIFAI(ckbjgcfchga, hjejjgafham, mchooehcanp, cmbcnmlgppc, this.HDBMEAPNFPK(kljcembnkni.OGKIINMNBLH), GKJPOGNFKNK.MIICMJEIPIK(kljcembnkni.AEGIBKHFEOF));
							PIEEFOHHDKO.BGKBLIAAFCK.Add(component4);
							num2 += num5;
							num++;
						}
					}
				}
			}
			component.ACBKFBBCNNC(num2);
			if (num > 1)
			{
				string[] array2 = new string[57];
				array2[0] = "), the full themes load as before";
				array2[1] = PIEEFOHHDKO.GLOCCAIDHJC.ToString();
				array2[5] = "ok";
				array2[0] = num.ToString();
				array2[6] = "cdnerror";
				array2[3] = PIEEFOHHDKO.CKBJGCFCHGA.ToString();
				array2[1] = "OnLiveProfileThemesLoaderStart";
				array2[8] = PIEEFOHHDKO.LGIAOIGIGPI.Count.ToString();
				array2[5] = "OnStorySplashManagerAdsProviderAdSuccess";
				array2[15] = num2.ToString();
				DPGJIJGOCIC.CMGOAFDBAOH(string.Concat(array2));
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
		return num;
	}

	// Token: 0x060022F7 RID: 8951 RVA: 0x000FAEF4 File Offset: 0x000F90F4
	private void HLDAIPNELHP(int PLKMJJIIJNO, List<string> JGHOLDLMMFC, List<string> HBLMLOLMHLL)
	{
		JGHOLDLMMFC.Clear();
		HBLMLOLMHLL.Clear();
		try
		{
			SceneLobbyManager2.LDGNIDMIIIA ldgnidmiiia = this.BAKAHKFKAHL(PLKMJJIIJNO);
			if (ldgnidmiiia != null && ldgnidmiiia.FKCNMAEBNNK != null)
			{
				this.ABOLIKOEIDM(this.FALNDKMJNMF(PLKMJJIIJNO, ldgnidmiiia.FKCNMAEBNNK) ? JGHOLDLMMFC : HBLMLOLMHLL, ldgnidmiiia.FKCNMAEBNNK);
				string text = (ldgnidmiiia.JCMIJCCCCLC != null) ? ldgnidmiiia.JCMIJCCCCLC : ldgnidmiiia.MEHHECKMOAD;
				if (text != null)
				{
					this.ABOLIKOEIDM(this.FALNDKMJNMF(PLKMJJIIJNO, text) ? JGHOLDLMMFC : HBLMLOLMHLL, text);
				}
				for (int i = 0; i < ldgnidmiiia.AIJFJMKHAOO.Count; i++)
				{
					this.ABOLIKOEIDM(this.FALNDKMJNMF(PLKMJJIIJNO, ldgnidmiiia.AIJFJMKHAOO[i]) ? JGHOLDLMMFC : HBLMLOLMHLL, ldgnidmiiia.AIJFJMKHAOO[i]);
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x060022F8 RID: 8952 RVA: 0x000FAFD0 File Offset: 0x000F91D0
	private void IEGNEPMIKMD()
	{
		Application.Quit();
	}

	// Token: 0x060022F9 RID: 8953 RVA: 0x000FAFD8 File Offset: 0x000F91D8
	private JBBNEEHANHL FJDGIHGJHOI()
	{
		for (int i = 0; i < this.EKIFLHLCLKG.Count; i++)
		{
			FilterItem filterItem = (null == this.EKIFLHLCLKG[i]) ? null : this.EKIFLHLCLKG[i].GetComponent<FilterItem>();
			if (null != filterItem && JBBNEEHANHL.filterSearch != filterItem.id && this.EKIFLHLCLKG[i].activeSelf && null != filterItem.toggle && filterItem.toggle.isOn)
			{
				return filterItem.id;
			}
		}
		try
		{
			JBBNEEHANHL jbbneehanhl = (JBBNEEHANHL)Enum.Parse(typeof(JBBNEEHANHL), this.AECCHBMDHBE());
			if (JBBNEEHANHL.filterSearch != jbbneehanhl)
			{
				return jbbneehanhl;
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
		return JBBNEEHANHL.filterNew;
	}

	// Token: 0x060022FA RID: 8954 RVA: 0x000FB0B0 File Offset: 0x000F92B0
	private void NBPBCFIBDPO()
	{
		DPGJIJGOCIC.NFIDPOMCNLP("Dismissed Option picked");
		PlayerPrefs.SetInt("ratePopupResult", 3);
		PlayerPrefs.Save();
	}

	// Token: 0x060022FB RID: 8955 RVA: 0x000FB0CC File Offset: 0x000F92CC
	private List<JBBNEEHANHL> JNOKFMBPKMP(int PLKMJJIIJNO)
	{
		List<JBBNEEHANHL> list = new List<JBBNEEHANHL>();
		try
		{
			IJLJDFKJIJM ijljdfkjijm = HKLPEDKJGFC.MMGOOHLBAFD(PLKMJJIIJNO);
			if (ijljdfkjijm == null)
			{
				return list;
			}
			if (GOAEAMLNFOC.DLIKABOBPIO(ijljdfkjijm.MGDAFCPCOFH))
			{
				list.Add(ijljdfkjijm.MGDAFCPCOFH);
			}
			if (GOAEAMLNFOC.DLIKABOBPIO(ijljdfkjijm.HLEHGFIIEJN))
			{
				list.Add(ijljdfkjijm.HLEHGFIIEJN);
			}
			if (GOAEAMLNFOC.DLIKABOBPIO(ijljdfkjijm.BFJKEJLJAIH))
			{
				list.Add(ijljdfkjijm.BFJKEJLJAIH);
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
		return list;
	}

	// Token: 0x060022FC RID: 8956 RVA: 0x000FB154 File Offset: 0x000F9354
	private IEnumerator DIIMKKCDBAI()
	{
		yield return new WaitForSeconds(0.25f);
		yield return new WaitForEndOfFrame();
		this.PEKMHDKPKML();
		yield break;
	}

	// Token: 0x060022FD RID: 8957 RVA: 0x000FB163 File Offset: 0x000F9363
	private void FDBMOJMACBN()
	{
		this.MGNKGDNOKEK(this.FMJEJOGDBHA);
		this.BAKCPDNFFMH();
	}

	// Token: 0x060022FE RID: 8958 RVA: 0x000FB177 File Offset: 0x000F9377
	public void OnSettingsClick()
	{
		if (FacebookManager.EHBBFMCILPC.IsFacebookManagerInitialized())
		{
			CommonUserInterface.EHBBFMCILPC.ShowSettings(true, false, false);
			return;
		}
		base.StartCoroutine(this.DEMIIEHPNIH());
	}

	// Token: 0x060022FF RID: 8959 RVA: 0x000FB1A0 File Offset: 0x000F93A0
	private void EDMJHANBNIN()
	{
		if (ODJKHCHFKNL.LEMILALILKP() != DFGILFBGPLN.screenLobby)
		{
			return;
		}
		AssetsManager.EHBBFMCILPC.DestroyAssetBundleAssets(NMKDCBPMCKI.AssetBundleProfileData5, -1);
		this.HDPICAFMHPH();
	}

	// Token: 0x06002300 RID: 8960 RVA: 0x000FB1BF File Offset: 0x000F93BF
	public void OnPlayClick()
	{
		if (this.NeedToCompletePrequelAnthology())
		{
			return;
		}
		if (!this.MBCAHEEBBGE)
		{
			this.OnPlayClickStart();
			return;
		}
		this.OnPlaySoonClick();
	}

	// Token: 0x06002301 RID: 8961 RVA: 0x000FB1DF File Offset: 0x000F93DF
	private bool GDNHLCMDFHA()
	{
		return FocusItem.isFocusOpened || (null != this.focusFade && this.focusFade.activeSelf);
	}

	// Token: 0x06002302 RID: 8962 RVA: 0x000FB208 File Offset: 0x000F9408
	private void FCJAODPFFGC()
	{
		AssetsManager.EHBBFMCILPC.CleanAssetBundleManagerHasBeenResetFlag();
		try
		{
			for (int i = 0; i < AssetsManager.EHBBFMCILPC.anthologyAssets.Count; i++)
			{
				if (AKLFPGMDKLA.EHBBFMCILPC.GJBDBONJCDL(AssetsManager.EHBBFMCILPC.anthologyAssets[i].header.index) != null && AssetsManager.EHBBFMCILPC.anthologyAssets[i].header.MLGKEPJPICJ(AKLFPGMDKLA.EHBBFMCILPC.GJBDBONJCDL(AssetsManager.EHBBFMCILPC.anthologyAssets[i].header.index).EGHHCFFLPCP(-1)))
				{
					PLFDAJJHMKO plfdajjhmko = AKLFPGMDKLA.EHBBFMCILPC.JDCBFAPDJIM(AssetsManager.EHBBFMCILPC.anthologyAssets[i].header.availableStories[AssetsManager.EHBBFMCILPC.anthologyAssets[i].header.availableStories.Count - 1], -1);
					if (plfdajjhmko != null)
					{
						AssetStoryHeader assetStoryHeader = GKJPOGNFKNK.CDCEFHLNNEC(plfdajjhmko.DHONIOBOLEL.GGICIBLJIKI);
						if (null != assetStoryHeader && (plfdajjhmko.DHONIOBOLEL.LKIKEHFANBO[0] != assetStoryHeader.totalChaptersCount - 1 || plfdajjhmko.DHONIOBOLEL.LKIKEHFANBO[1] != assetStoryHeader.totalChaptersCount - 1))
						{
							DPGJIJGOCIC.ANOPFDLPKGC("(fixed) Unknown last season chapter progress reset situation, while story is completed, for anthology:" + AssetsManager.EHBBFMCILPC.anthologyAssets[i].header.index.ToString());
							FirebaseAnalyticsManager.EHBBFMCILPC.LogEvent(false, AGEHCPDNBFD.bugRep.ToString(), FFPHBMFGCNN.handBfix.ToString(), BGHLMGPPCNN.bugPrgrReset.ToString(), false, false);
							plfdajjhmko.DHONIOBOLEL.LKIKEHFANBO[0] = (plfdajjhmko.DHONIOBOLEL.LKIKEHFANBO[1] = assetStoryHeader.totalChaptersCount - 1);
							plfdajjhmko.DHONIOBOLEL.NJPFIIDIABG(0);
						}
					}
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
		if (this.PLJLNEAKFDK == EJDDNONEDNM.loadIntoStory && AKLFPGMDKLA.EHBBFMCILPC.IEGJCPDCLMM >= 0 && null == GKJPOGNFKNK.MLDENPHFNPH(AKLFPGMDKLA.EHBBFMCILPC.IEGJCPDCLMM, true))
		{
			DPGJIJGOCIC.ANOPFDLPKGC("Account.Instance.activeStory is set to " + AKLFPGMDKLA.EHBBFMCILPC.IEGJCPDCLMM.ToString() + ", but an anthology asset was not loaded for this story, falling back to lobby loading.");
			AKLFPGMDKLA.EHBBFMCILPC.IEGJCPDCLMM = -1;
			this.PLJLNEAKFDK = EJDDNONEDNM.stayInLobby;
		}
		FirebaseAnalyticsManager.EHBBFMCILPC.LogEvent(false, AGEHCPDNBFD.cdnActiv.ToString(), FFPHBMFGCNN.dldCompl.ToString(), BGHLMGPPCNN.cdnLbyLoadPt1.ToString(), false, false);
		this.GEMOOEPJGHP();
	}

	// Token: 0x06002303 RID: 8963 RVA: 0x000FB4BC File Offset: 0x000F96BC
	private float HOPIBIMLJNN()
	{
		float num = 1495f;
		for (int i = 1; i < this.CIBDADPLOMG.Count; i += 0)
		{
			if (this.CIBDADPLOMG[i].AGMOECJFFJI > num)
			{
				num = this.CIBDADPLOMG[i].AGMOECJFFJI;
			}
		}
		if (num <= 1810f)
		{
			return 375f;
		}
		return num;
	}

	// Token: 0x06002304 RID: 8964 RVA: 0x000FB51A File Offset: 0x000F971A
	private void MGNKGDNOKEK(bool AGMPHFNAFEB)
	{
		this.FKMHOJNLOIL = true;
		this.KOMBACJDBAH = AGMPHFNAFEB;
	}

	// Token: 0x06002305 RID: 8965 RVA: 0x000FB52C File Offset: 0x000F972C
	public void OnPublicProfileClick()
	{
		AKLFPGMDKLA.EHBBFMCILPC.LGFDPCALDAF();
		if (this.IHIHDNNPBKA > 0)
		{
			AKLFPGMDKLA.EHBBFMCILPC.KBKOLEJEEGH();
		}
		if (!AKLFPGMDKLA.EHBBFMCILPC.JBEPHLFCLEC())
		{
			CommonUserInterface.EHBBFMCILPC.ShowGenericPopup(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("energyhinttitle"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("myprofilelimitation"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("continue"), DFGILFBGPLN.popupTools, 0f, 28);
			return;
		}
		if (!AKLFPGMDKLA.EHBBFMCILPC.EAFEJCKIEPL(17))
		{
			AKLFPGMDKLA.EHBBFMCILPC.LDAPMNLGAPC(17);
			CommonUserInterface.EHBBFMCILPC.ShowGenericPopupOneOverride(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("energyhinttitle"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("myprofilewhatis"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("continue"), new UnityAction(this.OnPublicProfileClick), DFGILFBGPLN.popupTools, 0f, 28);
			return;
		}
		this.GBBHKFFENBE = true;
		AssetsManager.EHBBFMCILPC.ForceStopAllOperations();
		if (AKLFPGMDKLA.EHBBFMCILPC.OKGGLHOCENC == null)
		{
			AKLFPGMDKLA.EHBBFMCILPC.NGGEJLDMOBK();
			CommonUserInterface.EHBBFMCILPC.ShowConnectingAnimation(96);
			BackendOperationsManager.EHBBFMCILPC.QueueBasicSync();
			BackendOperationsManager.EHBBFMCILPC.RequestGetUserPublicProfile(false, null, null, "OnBackendGetPublicProfileSuccess", "OnBackendGetPublicProfileException", false);
			return;
		}
		base.StartCoroutine(this.CPKEKFFODHH());
	}

	// Token: 0x06002306 RID: 8966 RVA: 0x000ED143 File Offset: 0x000EB343
	public void BGIBLCNNCPO()
	{
		this.focusItem.GetComponent<FocusItem>().CloseFocus();
		this.CPLLGNAKIIL(this.LGKGGPDKAHF);
	}

	// Token: 0x06002307 RID: 8967 RVA: 0x000FB674 File Offset: 0x000F9874
	private NDHKFLHAFNA AMPMKNKINDL(int PLKMJJIIJNO)
	{
		NDHKFLHAFNA ndhkflhafna = this.PMFMEBGNCME[PLKMJJIIJNO];
		if (this.EEGHJFAIMBF.Contains(PLKMJJIIJNO))
		{
			if (NDHKFLHAFNA.hintCompleted != ndhkflhafna && (NDHKFLHAFNA)(-5) != ndhkflhafna && (NDHKFLHAFNA)(-91) != ndhkflhafna)
			{
				ndhkflhafna = NDHKFLHAFNA.hintSuggested;
			}
			return ndhkflhafna;
		}
		return ndhkflhafna;
	}

	// Token: 0x06002308 RID: 8968 RVA: 0x000FB6AC File Offset: 0x000F98AC
	private int PJLOJHDNDNJ()
	{
		int num = KBOJLHAJPCP.PFHKHMLNBAB;
		IIHCCPLGGHP iihccplgghp = KHPGPLAMAIN.IBDGNKGIMFI();
		if (iihccplgghp == IIHCCPLGGHP.highEnd)
		{
			num = KBOJLHAJPCP.FBGICLAPEFK;
		}
		else if (iihccplgghp == IIHCCPLGGHP.midEnd)
		{
			num = KBOJLHAJPCP.DHCHJOAJNML;
		}
		if (num < 1)
		{
			num = 1;
		}
		return num;
	}

	// Token: 0x06002309 RID: 8969 RVA: 0x000F1C54 File Offset: 0x000EFE54
	private void BCOOKJICILK(JBBNEEHANHL GLOCCAIDHJC)
	{
		base.StartCoroutine(this.ELPJIHLDEFP(GLOCCAIDHJC));
	}

	// Token: 0x0600230A RID: 8970 RVA: 0x000FB6E4 File Offset: 0x000F98E4
	private void EHIBOKHHKBF()
	{
		for (int i = 0; i < this.lobbyParticles.Count; i++)
		{
			if (null != this.lobbyParticles[i])
			{
				this.lobbyParticles[i].gameObject.SetActive(true);
				this.lobbyParticles[i].Play();
			}
		}
		this.EPDHPBPMLLO();
	}

	// Token: 0x0600230B RID: 8971 RVA: 0x000FB749 File Offset: 0x000F9949
	private void OOALGPIOODP()
	{
		base.StartCoroutine(this.GLBNDFFMKFB());
	}

	// Token: 0x0600230C RID: 8972 RVA: 0x000FB758 File Offset: 0x000F9958
	private void IIDHAKNKIKO()
	{
		this.CHDBIMNLHBC = null;
		this.KCJIIEIBAPI = -1;
		this.DINHJIBBGJL = -1;
	}

	// Token: 0x0600230D RID: 8973 RVA: 0x000FB76F File Offset: 0x000F996F
	private void PHHHJMEDNGD()
	{
		CommonUserInterface.IKNOFBFMPGA().FreezeUX();
		CommonUserInterface.EHBBFMCILPC.GetFader().PACBMBLIGNN(new TweenCallback(this.FDCBDGNPJMG));
	}

	// Token: 0x0600230E RID: 8974 RVA: 0x000FB796 File Offset: 0x000F9996
	private void KAFKDGHHGAI()
	{
		this.IPAFGLONDJF = true;
		this.DKOHLEEEEEA();
		this.BIBDIFGBHPI();
		this.KHCPHAIGBJE();
		CommonUserInterface.EHBBFMCILPC.GetCutsceneViewManager().Show(this.BMODBEEEABE);
	}

	// Token: 0x0600230F RID: 8975 RVA: 0x000FB7C8 File Offset: 0x000F99C8
	private void NLFMLMDKLNH()
	{
		CommonUserInterface.EHBBFMCILPC.MCJIGJMFBMI();
		this.CPLLGNAKIIL(this.LGKGGPDKAHF);
		if (null != this.LGKGGPDKAHF)
		{
			this.ONGICLLGJGO(this.LGKGGPDKAHF.index);
		}
		base.StartCoroutine(this.NAJEFKOKLKJ());
	}

	// Token: 0x06002310 RID: 8976 RVA: 0x000FB818 File Offset: 0x000F9A18
	private void KHCPHAIGBJE()
	{
		for (int i = 0; i < this.lobbyParticles.Count; i++)
		{
			if (null != this.lobbyParticles[i])
			{
				this.lobbyParticles[i].Stop();
			}
		}
		this.HJIBMCAMAKA();
	}

	// Token: 0x06002311 RID: 8977 RVA: 0x000FB868 File Offset: 0x000F9A68
	private void LHGMJAJAJID()
	{
		if (!this.notificationFreeDiamonds.activeSelf && KHPGPLAMAIN.IGKCLMLPLAC() && AdsManagerLP.OOGPALHPNGM().MMBBMDNBHJL())
		{
			this.notificationFreeDiamonds.SetActive(true);
			this.notificationFreeDiamondsHidden.SetActive(false);
			this.PCLAANFABBB();
			this.JNAMNIBDFKB();
			if (AKLFPGMDKLA.EHBBFMCILPC.KCFMAEFDGPK == 0)
			{
				this.incentAdHardButton.interactable = true;
			}
			else
			{
				this.BJGAJOKENMG.OOFKLOIEPDK((float)AKLFPGMDKLA.EHBBFMCILPC.KCFMAEFDGPK);
				this.incentAdHardButton.interactable = false;
			}
		}
		this.incentAdHardButton.interactable = true;
	}

	// Token: 0x06002312 RID: 8978 RVA: 0x000FB904 File Offset: 0x000F9B04
	private void BAKCPDNFFMH()
	{
		this.OBKCLKMPKCI = this.FKMHOJNLOIL;
		this.FMJEJOGDBHA = this.KOMBACJDBAH;
		this.FKMHOJNLOIL = false;
		this.KOMBACJDBAH = false;
		if (!this.OBKCLKMPKCI)
		{
			SceneLoungeManager.SetPendingLoungeCharacter(null);
			SceneLoungeManager.SetPendingLoungeLook(null);
		}
		if (this.MHAMPPBECNM)
		{
			return;
		}
		if (!this.PIECGBHMOCB())
		{
			this.ONBMOPMOIKI();
			return;
		}
		if (null == this.HFFIIBBJBMH || null == this.HFFIIBBJBMH.header)
		{
			return;
		}
		PLFDAJJHMKO plfdajjhmko = AKLFPGMDKLA.EHBBFMCILPC.NBMLMNGHOPP();
		if (plfdajjhmko == null)
		{
			return;
		}
		if (!this.OBKCLKMPKCI && !plfdajjhmko.NCAMFPGMCIG.CHOFDAELJIH())
		{
			bool flag = this.OIKCNJIJNAC(plfdajjhmko);
			CommonUserInterface.EHBBFMCILPC.ShowGenericPopup(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("importanttitle"), SceneLobbyManager2.FALBDONHAAL(flag ? "loungeplayfirstprogress" : "loungeplayfirst", flag ? "loungeplayfirst" : "loungenotavailable"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("ok"), DFGILFBGPLN.popupSignInQuestion, 0.1f, 28);
			return;
		}
		StoryInterfaceHeaderManager.anthologyIndex = this.HFFIIBBJBMH.header.index;
		StoryInterfaceHeaderManager.storyIndex = plfdajjhmko.DHONIOBOLEL.GGICIBLJIKI;
		if (!(this.OBKCLKMPKCI ? SceneStoryManager.AnyShopRowListedInShopMode(this.HFFIIBBJBMH.header.index) : SceneStoryManager.AnyLoungeCharacterInVisitedWardrobes(this.HFFIIBBJBMH.header.index, plfdajjhmko)))
		{
			SceneLoungeManager.SetPendingLoungeCharacter(null);
			SceneLoungeManager.SetPendingLoungeLook(null);
			CommonUserInterface.EHBBFMCILPC.ShowGenericPopup(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("importanttitle"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("loungenotavailable"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("ok"), DFGILFBGPLN.popupSignInQuestion, 0f, 28);
			return;
		}
		this.MHAMPPBECNM = true;
		this.DFNOAOLCGGB = 0;
		this.IBBHBBNAOKL.Clear();
		this.FJOMBPDEMCM = AKLFPGMDKLA.EHBBFMCILPC.GKNBOCPKMDM(this.HFFIIBBJBMH.header.index);
		this.LHMIICJFLFP(plfdajjhmko);
	}

	// Token: 0x06002313 RID: 8979 RVA: 0x000FBAF1 File Offset: 0x000F9CF1
	private void MKAPABLPCIM()
	{
		this.focusItem.GetComponent<FocusItem>().CloseFocus();
		CommonUserInterface.EHBBFMCILPC.GetFader().FadeOut(new TweenCallback(this.IKNJHAPNPHI));
	}

	// Token: 0x06002314 RID: 8980 RVA: 0x000FBB20 File Offset: 0x000F9D20
	private void FIFEJGHAHGB(AssetAnthology EDPKCKMFNKG)
	{
		if (!KHPGPLAMAIN.CNFPCHNGKPB())
		{
			AssetsManager.EHBBFMCILPC.DestroyAssetBundleAssets(NMKDCBPMCKI.AssetBundleIconsPack, -1);
		}
		if (null != AssetsManager.EHBBFMCILPC.profileDataAsset)
		{
			AssetsManager.EHBBFMCILPC.profileDataAsset.CMPFJLLGKCC();
		}
		AssetsManager.EHBBFMCILPC.DestroyAssetBundleAssets(NMKDCBPMCKI.AssetBundleProfilePack, -1);
		AssetsManager.EHBBFMCILPC.DestroyAssetBundleAssets(NMKDCBPMCKI.AssetBundleLiveProfileTheme, -1);
		AssetsManager.EHBBFMCILPC.DestroyAssetBundleAssets(NMKDCBPMCKI.AssetBundleProfileData6, -1);
		AssetsManager.EHBBFMCILPC.DestroyAssetBundleAssets(NMKDCBPMCKI.AssetBundleCustomFader, -1);
		AssetsManager.EHBBFMCILPC.DestroyAssetBundleAssets(NMKDCBPMCKI.AssetBundleCustomEffects, -1);
		AssetsManager.EHBBFMCILPC.DestroyAssetBundleAssets(NMKDCBPMCKI.AssetBundleNpcAnimationPack, -1);
		AssetsManager.EHBBFMCILPC.DestroyAssetBundleAssets(NMKDCBPMCKI.AssetBundleItemAnimationPack, -1);
		AssetsManager.EHBBFMCILPC.DestroyAssetBundleAssets(NMKDCBPMCKI.AssetBundleFrameContainer, -1);
		AssetsManager.EHBBFMCILPC.DestroyAssetBundleAssets(NMKDCBPMCKI.AssetBundleLobbyData2, -1);
		AssetsManager.EHBBFMCILPC.UnloadPersistentAssetBundles();
		if (AKLFPGMDKLA.EHBBFMCILPC.KLPBIGJBOBE == 0 && AKLFPGMDKLA.EHBBFMCILPC.HCEHBFCIIHN() < 28)
		{
			int num = -1;
			if (PlayerPrefs.HasKey("erd"))
			{
				num = PlayerPrefs.GetInt("erd");
			}
			if (num < 0 || num != AKLFPGMDKLA.EHBBFMCILPC.HCEHBFCIIHN())
			{
				PlayerPrefs.SetInt("erd", AKLFPGMDKLA.EHBBFMCILPC.HCEHBFCIIHN());
				PlayerPrefs.Save();
			}
		}
		FirebaseAnalyticsManager.EHBBFMCILPC.LogEvent(false, AGEHCPDNBFD.cdnActiv.ToString(), FFPHBMFGCNN.dldStart.ToString(), BGHLMGPPCNN.cdnLbyToSpl.ToString(), false, false);
		if (this.PLJLNEAKFDK == EJDDNONEDNM.loadIntoStory)
		{
			CommonUserInterface.EHBBFMCILPC.ShowConnectingAnimationWithProgress(0);
		}
		else
		{
			CommonUserInterface.EHBBFMCILPC.ShowConnectingAnimation(0);
		}
		AudioManager.EHBBFMCILPC.KillMusic("", -1f);
		if (AKLFPGMDKLA.EHBBFMCILPC.HCEHBFCIIHN() < 1 && 1 == AKLFPGMDKLA.EHBBFMCILPC.MJPKIMHENNF)
		{
			FirebaseAnalyticsManager.EHBBFMCILPC.LogEvent(true, AGEHCPDNBFD.d1Ret.ToString(), FFPHBMFGCNN.d1Board.ToString(), BGHLMGPPCNN.d1SplashCdnSt.ToString(), true, false);
		}
		this.LDIGGOPHGMI = GKJPOGNFKNK.CDCEFHLNNEC(AKLFPGMDKLA.EHBBFMCILPC.IEGJCPDCLMM);
		this.HFFIIBBJBMH = GKJPOGNFKNK.MLDENPHFNPH(AKLFPGMDKLA.EHBBFMCILPC.IEGJCPDCLMM, true);
		if (null != this.LDIGGOPHGMI && null != this.HFFIIBBJBMH && this.HFFIIBBJBMH.header.enableSplashScreenAudio)
		{
			int num2 = AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).DHONIOBOLEL.DDEDAHCFHJN();
			if (num2 < this.LDIGGOPHGMI.chapterAssetPacks.Count)
			{
				AssetsManager.EHBBFMCILPC.QueueAssetBundleDownload(NMKDCBPMCKI.AssetBundleKeepAlivePack, this.HFFIIBBJBMH.header.CKACBBGHJGI(), -1, FLDBFOADFLH.finishDownloadAndProceed, true, false, false, null, -1, (this.LDIGGOPHGMI.chapterAssetPacks[num2].skipLoadKeepAliveBundlesForDefaultCompression && NBDLBFJOEGN.OMNHINGKGNP()) || (this.LDIGGOPHGMI.chapterAssetPacks[num2].skipLoadKeepAliveBundlesForLowEndDevices && KHPGPLAMAIN.IBDGNKGIMFI() == IIHCCPLGGHP.lowEnd), "", false, false);
			}
		}
		if (null != this.HFFIIBBJBMH && this.HFFIIBBJBMH.header.enableIconsPack)
		{
			AssetsManager.EHBBFMCILPC.QueueAssetBundleDownload(NMKDCBPMCKI.AssetBundleIconsPack, this.HFFIIBBJBMH.header.CKACBBGHJGI(), -1, FLDBFOADFLH.startDownloadAndProceed, false, false, false, null, -1, false, "", false, false);
		}
		if (null != this.HFFIIBBJBMH)
		{
			AssetsManager.EHBBFMCILPC.QueueAssetBundleDownload(NMKDCBPMCKI.AssetBundleProfilePack, this.HFFIIBBJBMH.header.CKACBBGHJGI(), -1, FLDBFOADFLH.startDownloadAndProceed, false, false, false, null, -1, false, "", false, false);
		}
		AssetsManager.EHBBFMCILPC.QueueAssetBundleDownload(NMKDCBPMCKI.AssetBundleStorySplash, AKLFPGMDKLA.EHBBFMCILPC.IEGJCPDCLMM, -1, FLDBFOADFLH.finishDownloadAndProceed, false, false, true, null, -1, false, "", this.EPFLNNFPHFE(this.HFFIIBBJBMH), false);
		if (!AKLFPGMDKLA.EHBBFMCILPC.EAFEJCKIEPL(73))
		{
			AssetsManager.EHBBFMCILPC.QueueFrameContainerBundle(0);
		}
		AssetsManager.EHBBFMCILPC.DownloadQueuedAssetBundles("OnSceneLobbyManagerRound1AssetsDownloadSuccess", "OnSceneLobbyManagerAssetsDownloadFailed", false);
	}

	// Token: 0x06002315 RID: 8981 RVA: 0x000FBEE4 File Offset: 0x000FA0E4
	private void HOJKLCFKFLL()
	{
		AKLFPGMDKLA.EHBBFMCILPC.HKOBEKCGGEI(JAMPPNPOJJG.full);
		FirebaseAnalyticsManager.EHBBFMCILPC.LogEvent(true, AGEHCPDNBFD.gmSelect.ToString(), FFPHBMFGCNN.gmFull.ToString(), BGHLMGPPCNN.gmLocSett.ToString(), false, false);
		this.DNGHLBFEODC();
	}

	// Token: 0x06002316 RID: 8982 RVA: 0x000F4A46 File Offset: 0x000F2C46
	private IEnumerator MEMFKOENHKF()
	{
		yield return new WaitForSeconds(1f);
		string text = CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("saveslotsswitchdone");
		string text2 = AKLFPGMDKLA.EHBBFMCILPC.LMGMHHLLOFN(this.LGKGGPDKAHF.index).BFCBDALFNHA(-1);
		if (text2.Length == 0)
		{
			text2 = (AKLFPGMDKLA.EHBBFMCILPC.LMGMHHLLOFN(this.LGKGGPDKAHF.index).ILOKBAPEJPK + 1).ToString();
		}
		text = text.Replace("XXX", text2);
		CommonUserInterface.EHBBFMCILPC.ShowGenericPopup(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("importanttitle"), text, CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("ok"), DFGILFBGPLN.popupEnergyHint, 0f, 28);
		CommonUserInterface.EHBBFMCILPC.ResumeUX();
		AssetsManager.EHBBFMCILPC.DestroyAssetBundleAssets(NMKDCBPMCKI.AssetBundleCollectableCard, -1);
		yield break;
	}

	// Token: 0x06002317 RID: 8983 RVA: 0x000F0400 File Offset: 0x000EE600
	private void HCLLBPGCHID()
	{
		this.fireworksParticles.Stop();
	}

	// Token: 0x06002318 RID: 8984 RVA: 0x000FBF3E File Offset: 0x000FA13E
	public void RestartStory3()
	{
		this.RestartStoryX(3);
	}

	// Token: 0x06002319 RID: 8985 RVA: 0x000FBF48 File Offset: 0x000FA148
	private void KLBBGAFDNMP(JBBNEEHANHL HBBJBNJBMPK)
	{
		try
		{
			for (int i = this.MGNNOFPKGJF.Count - 1; i >= 0; i--)
			{
				GameObject gameObject = this.MGNNOFPKGJF[i];
				if (!(null == gameObject) && gameObject.GetComponent<GridController>().filter == HBBJBNJBMPK)
				{
					for (int j = this.GMGKODLANOP.Count - 1; j >= 0; j--)
					{
						if (null == this.GMGKODLANOP[j] || this.GMGKODLANOP[j].transform.parent == gameObject.transform || this.GMGKODLANOP[j].transform.IsChildOf(gameObject.transform))
						{
							this.GMGKODLANOP.RemoveAt(j);
						}
					}
					this.MGNNOFPKGJF.RemoveAt(i);
					gameObject.SetActive(false);
					gameObject.transform.SetParent(null, false);
					UnityEngine.Object.Destroy(gameObject);
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x0600231A RID: 8986 RVA: 0x000FC058 File Offset: 0x000FA258
	private void GKLFOGFNPNP(AssetAnthology EDPKCKMFNKG)
	{
		if (!KHPGPLAMAIN.CNFPCHNGKPB())
		{
			AssetsManager.EHBBFMCILPC.DestroyAssetBundleAssets((NMKDCBPMCKI)(-9), -1);
		}
		if (null != AssetsManager.EHBBFMCILPC.profileDataAsset)
		{
			AssetsManager.EHBBFMCILPC.profileDataAsset.CMPFJLLGKCC();
		}
		AssetsManager.EHBBFMCILPC.DestroyAssetBundleAssets((NMKDCBPMCKI)(-49), -1);
		AssetsManager.MJBDMHPHMID().FJNNMGFLBKA((NMKDCBPMCKI)(-69), -1);
		AssetsManager.EHBBFMCILPC.NJEPIEPCCOF(NMKDCBPMCKI.AssetBundleProfileData5, -1);
		AssetsManager.MJBDMHPHMID().DestroyAssetBundleAssets(NMKDCBPMCKI.AssetBundleCollectableCard, -1);
		AssetsManager.EHBBFMCILPC.NJEPIEPCCOF(NMKDCBPMCKI._deprecated3, -1);
		AssetsManager.EHBBFMCILPC.FJNNMGFLBKA((NMKDCBPMCKI)(-58), -1);
		AssetsManager.EHBBFMCILPC.DestroyAssetBundleAssets(NMKDCBPMCKI.Count, -1);
		AssetsManager.MJBDMHPHMID().DestroyAssetBundleAssets(NMKDCBPMCKI.AssetBundleKeepAlivePack, -1);
		AssetsManager.EHBBFMCILPC.FJNNMGFLBKA((NMKDCBPMCKI)(-82), -1);
		AssetsManager.MJBDMHPHMID().NADFIDNMKFK();
		if (AKLFPGMDKLA.EHBBFMCILPC.KLPBIGJBOBE == 0 && AKLFPGMDKLA.EHBBFMCILPC.HCEHBFCIIHN() < 49)
		{
			int num = -1;
			if (PlayerPrefs.HasKey("startsInSeconds"))
			{
				num = PlayerPrefs.GetInt("ok");
			}
			if (num < 0 || num != AKLFPGMDKLA.EHBBFMCILPC.HCEHBFCIIHN())
			{
				PlayerPrefs.SetInt("", AKLFPGMDKLA.EHBBFMCILPC.HCEHBFCIIHN());
				PlayerPrefs.Save();
			}
		}
		FirebaseAnalyticsManager.DMAAFFFEJGA().LMCJKLHOHJC(false, AGEHCPDNBFD.mntActiv.ToString(), FFPHBMFGCNN.reqCback1.ToString(), BGHLMGPPCNN.d1ChaptEndOld.ToString(), true, false);
		if (this.PLJLNEAKFDK == EJDDNONEDNM.loadIntoStory)
		{
			CommonUserInterface.EHBBFMCILPC.LANLNOLFHMG(1);
		}
		else
		{
			CommonUserInterface.IKNOFBFMPGA().ShowConnectingAnimation(0);
		}
		AudioManager.APGODIBBPOD().NOOAHDNKAKA("p", 655f);
		if (AKLFPGMDKLA.EHBBFMCILPC.HCEHBFCIIHN() < 0 && 0 == AKLFPGMDKLA.EHBBFMCILPC.MJPKIMHENNF)
		{
			FirebaseAnalyticsManager.DEALKJPEMMH().LKONPEEDKNF(true, AGEHCPDNBFD.d1Ret.ToString(), ((FFPHBMFGCNN)92).ToString(), BGHLMGPPCNN.cdnLbyLoadPt2.ToString(), false, true);
		}
		this.LDIGGOPHGMI = GKJPOGNFKNK.CDCEFHLNNEC(AKLFPGMDKLA.EHBBFMCILPC.IEGJCPDCLMM);
		this.HFFIIBBJBMH = GKJPOGNFKNK.MLDENPHFNPH(AKLFPGMDKLA.EHBBFMCILPC.IEGJCPDCLMM, true);
		if (null != this.LDIGGOPHGMI && null != this.HFFIIBBJBMH && this.HFFIIBBJBMH.header.enableSplashScreenAudio)
		{
			int num2 = AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).DHONIOBOLEL.FFIJHHCEKAJ();
			if (num2 < this.LDIGGOPHGMI.chapterAssetPacks.Count)
			{
				AssetsManager.MJBDMHPHMID().QueueAssetBundleDownload((NMKDCBPMCKI)(-8), this.HFFIIBBJBMH.header.CKACBBGHJGI(), -1, FLDBFOADFLH.startDownloadAndProceed, false, true, false, null, -1, (this.LDIGGOPHGMI.chapterAssetPacks[num2].skipLoadKeepAliveBundlesForDefaultCompression && NBDLBFJOEGN.LNBGPABLOMF()) || (this.LDIGGOPHGMI.chapterAssetPacks[num2].skipLoadKeepAliveBundlesForLowEndDevices && KHPGPLAMAIN.CIEILKHLDCG() == (IIHCCPLGGHP)4), "assetbundlepurchasingview", true, true);
			}
		}
		if (null != this.HFFIIBBJBMH && this.HFFIIBBJBMH.header.enableIconsPack)
		{
			AssetsManager.EHBBFMCILPC.QueueAssetBundleDownload((NMKDCBPMCKI)96, this.HFFIIBBJBMH.header.CKACBBGHJGI(), -1, FLDBFOADFLH.finishDownloadAndProceed, true, true, true, null, -1, false, "Asset bundle load operation failed during parallel mode.", true, false);
		}
		if (null != this.HFFIIBBJBMH)
		{
			AssetsManager.EHBBFMCILPC.QueueAssetBundleDownload((NMKDCBPMCKI)(-98), this.HFFIIBBJBMH.header.CKACBBGHJGI(), -1, FLDBFOADFLH.startDownloadAndProceed, true, false, false, null, -1, true, ",", false, true);
		}
		AssetsManager.EHBBFMCILPC.QueueAssetBundleDownload(NMKDCBPMCKI._deprecated0, AKLFPGMDKLA.EHBBFMCILPC.IEGJCPDCLMM, -1, FLDBFOADFLH.startDownloadAndProceed, true, true, false, null, -1, false, "OnAvatarScreenAssetsDownloadSuccess", this.EPFLNNFPHFE(this.HFFIIBBJBMH), true);
		if (!AKLFPGMDKLA.EHBBFMCILPC.EAFEJCKIEPL(-2))
		{
			AssetsManager.MJBDMHPHMID().QueueFrameContainerBundle(1);
		}
		AssetsManager.MJBDMHPHMID().IBMPFCLJINB("OnBackendGetIncentRewardAdSuccess", "_AlphaTex", true);
	}

	// Token: 0x0600231B RID: 8987 RVA: 0x000FC41C File Offset: 0x000FA61C
	private bool DBBKFHBELNJ(AssetAnthology AAOGJEGPCAE, bool NOGJCGPAECH)
	{
		bool result;
		try
		{
			if (NOGJCGPAECH && KDCJJBLGCBH.EHBBFMCILPC.DLJGJOCJIED())
			{
				result = false;
			}
			else if (NOGJCGPAECH && !AAOGJEGPCAE.mini2VersionAvailable)
			{
				result = false;
			}
			else if (KDCJJBLGCBH.EHBBFMCILPC.BOPBHFAICBB())
			{
				SceneLobbyManager2.CHGGOOEADOC = true;
				if (!NOGJCGPAECH)
				{
					this.ADAACGDPKDC++;
				}
				result = false;
			}
			else if (!AAOGJEGPCAE.lowEndVersionAvailable)
			{
				SceneLobbyManager2.CHGGOOEADOC = true;
				if (!NOGJCGPAECH)
				{
					this.ADAACGDPKDC++;
				}
				result = false;
			}
			else if (KDCJJBLGCBH.EHBBFMCILPC.PCDHDFCEODB() || KHPGPLAMAIN.EJCNHEBIOJF())
			{
				if (!NOGJCGPAECH)
				{
					result = true;
				}
				else if (this.KHOELODHGGF[AAOGJEGPCAE.header.index] >= 0)
				{
					result = false;
				}
				else
				{
					result = true;
				}
			}
			else if (KHPGPLAMAIN.IBDGNKGIMFI() == IIHCCPLGGHP.lowEnd)
			{
				if (!NOGJCGPAECH)
				{
					result = true;
				}
				else if (this.KHOELODHGGF[AAOGJEGPCAE.header.index] >= 0)
				{
					result = false;
				}
				else
				{
					result = true;
				}
			}
			else
			{
				SceneLobbyManager2.CHGGOOEADOC = true;
				if (this.KHOELODHGGF[AAOGJEGPCAE.header.index] >= 0)
				{
					if (!NOGJCGPAECH)
					{
						this.ADAACGDPKDC++;
					}
					result = false;
				}
				else
				{
					result = true;
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			SceneLobbyManager2.CHGGOOEADOC = true;
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
			if (!NOGJCGPAECH)
			{
				this.ADAACGDPKDC++;
			}
			result = false;
		}
		return result;
	}

	// Token: 0x0600231C RID: 8988 RVA: 0x000FC580 File Offset: 0x000FA780
	private IEnumerator EIFAANDLKNB()
	{
		AssetsManager.EHBBFMCILPC.GetLoadingProgressSnapshot().EPJKDCDOEMM(0);
		CommonUserInterface.EHBBFMCILPC.ShowConnectingAnimationWithProgress(96);
		yield return new WaitForSeconds(0.2f);
		AssetsManager.EHBBFMCILPC.QueueAssetBundleDownload(NMKDCBPMCKI.AssetBundleCutsceneView, -1, -1, FLDBFOADFLH.finishDownloadAndProceed, false, true, false, null, -1, false, "", false, false);
		AssetsManager.EHBBFMCILPC.QueueAssetBundleDownload(NMKDCBPMCKI.AssetBundleStoryAssetPack, this.BMODBEEEABE.OCPJHLCBIPB(), this.BMODBEEEABE.FECFDDGCPGB(), FLDBFOADFLH.finishDownloadAndProceed, false, true, false, null, -1, false, "", false, false);
		if (this.BMODBEEEABE.BEKNKDKEECD() >= 0 && this.BMODBEEEABE.BMPELDJNGLF() >= 0 && this.BMODBEEEABE.FONKDFDJFEL.Length > 0)
		{
			AssetsManager.EHBBFMCILPC.QueueAssetBundleDownload(NMKDCBPMCKI.AssetBundleStoryAssetPack, this.BMODBEEEABE.BEKNKDKEECD(), this.BMODBEEEABE.BMPELDJNGLF(), FLDBFOADFLH.finishDownloadAndProceed, true, true, false, null, -1, false, "", false, false);
		}
		if (this.BMODBEEEABE.EABCCNCDNCI() >= 0 && this.BMODBEEEABE.NIBFBJFMKBG() >= 0 && this.BMODBEEEABE.JLEAIJGBGHL.Length > 0)
		{
			AssetsManager.EHBBFMCILPC.QueueAssetBundleDownload(NMKDCBPMCKI.AssetBundleStoryAssetPack, this.BMODBEEEABE.EABCCNCDNCI(), this.BMODBEEEABE.NIBFBJFMKBG(), FLDBFOADFLH.finishDownloadAndProceed, true, true, false, null, -1, false, "", false, false);
		}
		if (this.BMODBEEEABE.OCNMOBKOPIJ() >= 0 && this.BMODBEEEABE.LHNIAKBBPDN() >= 0)
		{
			AssetsManager.EHBBFMCILPC.QueueAssetBundleDownloadNoSkip(NMKDCBPMCKI.AssetBundleStoryAssetPack, this.BMODBEEEABE.OCNMOBKOPIJ(), this.BMODBEEEABE.LHNIAKBBPDN(), FLDBFOADFLH.finishDownloadAndProceed, true, true, false, null, -1, "", false, KHPGPLAMAIN.HHDAPAJEIML());
		}
		AssetsManager.EHBBFMCILPC.QueueAssetBundleDownload(NMKDCBPMCKI.AssetBundleStoryAssetPackActivate, 0, 0, FLDBFOADFLH.finishDownloadAndProceed, false, false, false, null, -1, false, "", false, false);
		AssetsManager.EHBBFMCILPC.GetLoadingProgressSnapshot().CLIOEOLFFLO(LEJKDNAGDHC.Fast);
		AssetsManager.EHBBFMCILPC.GetLoadingProgressSnapshot().GIJKJMMDJEL(0f, 1f);
		AssetsManager.EHBBFMCILPC.DownloadQueuedAssetBundles("OnCutsceneViewLobbyAssetsDownloadSuccess", "OnCutsceneViewLobbyAssetsDownloadFailed", false);
		yield break;
	}

	// Token: 0x0600231D RID: 8989 RVA: 0x000FC58F File Offset: 0x000FA78F
	private void DGNPNOKIKJC()
	{
		CommonUserInterface.EHBBFMCILPC.FreezeUX();
		CommonUserInterface.EHBBFMCILPC.GetFader().FadeIn(new TweenCallback(this.BCKDAJLGAEE));
	}

	// Token: 0x0600231E RID: 8990 RVA: 0x000FC5B6 File Offset: 0x000FA7B6
	private void KBEFBEIJPHP()
	{
		CommonUserInterface.EHBBFMCILPC.MCJIGJMFBMI();
		this.CFKMKEGMFJH();
	}

	// Token: 0x0600231F RID: 8991 RVA: 0x000FC5C8 File Offset: 0x000FA7C8
	private void IADPDLIEHBD()
	{
		this.MFCGAFIHGKI.Clear();
		this.PHHNFBLIGJB.Clear();
		this.KKPNDGIHFLN.Clear();
		Dictionary<int, int> dictionary = new Dictionary<int, int>();
		for (int i = 0; i < this.KHOELODHGGF.Length; i++)
		{
			dictionary.Add(i, this.KHOELODHGGF[i]);
		}
		dictionary = dictionary.OrderBy(new Func<KeyValuePair<int, int>, int>(SceneLobbyManager2.<>c.<>9.GENBANEBDNH)).Where(new Func<KeyValuePair<int, int>, bool>(SceneLobbyManager2.<>c.<>9.DBNIHAONGFO)).ToDictionary(new Func<KeyValuePair<int, int>, int>(SceneLobbyManager2.<>c.<>9.LOOAHDCBIBG), new Func<KeyValuePair<int, int>, int>(SceneLobbyManager2.<>c.<>9.CIPPKHEEAOA));
		List<int> list = new List<int>();
		List<int> list2 = new List<int>();
		List<int> list3 = new List<int>();
		for (int j = 0; j < dictionary.Count; j++)
		{
			if (j % 2 == 0)
			{
				list.Add(dictionary.Keys.ElementAt(j));
			}
			else
			{
				list2.Add(dictionary.Keys.ElementAt(j));
			}
		}
		list2.Reverse();
		list3.AddRange(list2);
		list3.AddRange(list);
		int num = list3.Count / 2;
		for (int k = 0; k < list3.Count; k++)
		{
			SceneLobbyManager2.CJENNIDBPLN cjennidbpln = new SceneLobbyManager2.CJENNIDBPLN();
			cjennidbpln.<>4__this = this;
			cjennidbpln.tempAssetAnthologyPreview2 = GKJPOGNFKNK.OGKPKBLFGMJ(list3[k]);
			if (null != cjennidbpln.tempAssetAnthologyPreview2)
			{
				GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(this.largeItemPrefab, this.largeItemsParent);
				this.PHHNFBLIGJB.Add(gameObject);
				gameObject.GetComponent<ThumbnailItem>().SetContent(cjennidbpln.tempAssetAnthologyPreview2, new UnityAction(cjennidbpln.FPNMIDODBGP), this.CIFKLOHBHJB[cjennidbpln.tempAssetAnthologyPreview2.index], this.defaultTagSprite, this.inDevelopmentTagSprite, this.completedTagSprite, this.onHiatusTagSprite, null, this.CBCGEFKGFKH(cjennidbpln.tempAssetAnthologyPreview2.index));
				this.MLDOEOKAPEH();
				if (k == num)
				{
					this.LGKGGPDKAHF = cjennidbpln.tempAssetAnthologyPreview2;
				}
			}
			else
			{
				DPGJIJGOCIC.ANOPFDLPKGC("SceneLobbyManager.InstantiateLargeItems() - could not find AssetAnthologyPreview2 for anthology with index:" + list3[k].ToString());
			}
		}
		if (null != this.LGKGGPDKAHF)
		{
			this.MFCGAFIHGKI.Add(this.LGKGGPDKAHF.index);
		}
		for (int l = 0; l < list3.Count; l++)
		{
			this.MFCGAFIHGKI.Add(list3[l]);
		}
		int num2 = list3.Count;
		bool flag = false;
		foreach (OKAFAHMOFII okafahmofii in LiveEventsManager.EHBBFMCILPC.GetLiveEvents())
		{
			SceneLobbyManager2.AFLNAFOHGJC aflnafohgjc = new SceneLobbyManager2.AFLNAFOHGJC();
			aflnafohgjc.<>4__this = this;
			aflnafohgjc.liveEventDesc = okafahmofii;
			aflnafohgjc.scriptableObject = GKJPOGNFKNK.AIDLIPGKHHE(okafahmofii.MHLOFNCHELC);
			if (aflnafohgjc.scriptableObject != null)
			{
				num2++;
				GameObject gameObject2 = UnityEngine.Object.Instantiate<GameObject>(this.cardItemPrefab, this.largeItemsParent);
				this.KKPNDGIHFLN.Add(gameObject2);
				gameObject2.GetComponent<CardItem>().SetContent(aflnafohgjc.liveEventDesc, aflnafohgjc.scriptableObject, new UnityAction(aflnafohgjc.MDBKKKMOHPI));
				UnityEngine.Object.Instantiate<GameObject>(this.pageIndicatorPrefab, this.pageIndicatorsParent);
				if (!flag && !this.MBACGFKOKJD && SceneLobbyManager2.anthologyPropertiesInitializationCounter == 1 && AKLFPGMDKLA.EHBBFMCILPC.KNDMKJOHCHJ(aflnafohgjc.liveEventDesc) && (aflnafohgjc.liveEventDesc.IACMODHPFKI.HHGAPKJFBMC() || aflnafohgjc.liveEventDesc.IACMODHPFKI.ODHBINFKIPL() <= 1f))
				{
					AKLFPGMDKLA.EHBBFMCILPC.JLCDJHABABP(aflnafohgjc.liveEventDesc);
					num = num2 - 1;
					flag = true;
				}
			}
		}
		int bgbdbbbmpab = 0;
		int ofohgkbndod = num2 - 1;
		this.scrollView1Controller.UpdateContentAssetsDownloadSuccess(num, bgbdbbbmpab, ofohgkbndod);
	}

	// Token: 0x06002320 RID: 8992 RVA: 0x000FCA00 File Offset: 0x000FAC00
	private List<KLJCEMBNKNI> HMJLJCLPLIK()
	{
		List<KLJCEMBNKNI> list = new List<KLJCEMBNKNI>();
		try
		{
			if (null == AssetsManager.EHBBFMCILPC || null == AssetsManager.EHBBFMCILPC.lobbyDataAsset)
			{
				return list;
			}
			List<LPJPFJOMGPA> list2 = AssetsManager.EHBBFMCILPC.lobbyDataAsset.FGLPBJAPBJK().KJLOAEIODFK();
			for (int i = 0; i < list2.Count; i++)
			{
				if (list2[i] != null && list2[i].JAPFMDOBPKJ.Count != 0)
				{
					list.Add(new KLJCEMBNKNI
					{
						HPJNLEBDMEP = KLMEAFCEKOI.coverTextFranchise,
						KCIODOKEDAM = list2[i].KCIODOKEDAM,
						AEGIBKHFEOF = "franchisepattern",
						OGKIINMNBLH = JBBNEEHANHL.filterFranchises,
						BLKPIAEAANG = true,
						CDEAAKHGKIF = 1,
						FKBCEMFCBOG = true,
						JAPFMDOBPKJ = new List<int>(list2[i].JAPFMDOBPKJ)
					});
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
		return list;
	}

	// Token: 0x06002321 RID: 8993 RVA: 0x000FCB10 File Offset: 0x000FAD10
	private void FDOJPHBLJJE()
	{
		KIOOJMGLCLC kioojmglclc = ODLJHDIGLGO.FLDPGFAMICD(CLHDENLPOFP.eventPass, false);
		int num = 0;
		if (kioojmglclc != null)
		{
			num = KDCJJBLGCBH.EHBBFMCILPC.AAGICPKFIKC(KDCJJBLGCBH.EHBBFMCILPC.HHONCLBBHPG(kioojmglclc.LLLJOBODOAL), (DAMCJCDKOJK)57, 0 == AKLFPGMDKLA.EHBBFMCILPC.DCIPLNCLIMF);
		}
		this.notificationFreeDiamondsHiddenText.text = "Z" + (KDCJJBLGCBH.EHBBFMCILPC.NEOIABIBJOI(1) * num).ToString();
		this.notificationFreeDiamondsHiddenText.SetText("n/a" + (KDCJJBLGCBH.EHBBFMCILPC.NEOIABIBJOI(0) * num).ToString(), true);
	}

	// Token: 0x06002322 RID: 8994 RVA: 0x000FCBA9 File Offset: 0x000FADA9
	private void ANFLJCPEPGI()
	{
		DPGJIJGOCIC.DGAFMHCFFBF();
	}

	// Token: 0x06002323 RID: 8995 RVA: 0x000FCBB0 File Offset: 0x000FADB0
	public void ViewCardCutsceneLobby()
	{
		int lllcdmnpkfi = AOBJLALDBAA.EHBBFMCILPC.MJLACDOKGNE();
		CLGFGOHBCGJ clgfgohbcgj = LJNMIPMNOKF.EHBBFMCILPC.KMDBNEFCPOH(lllcdmnpkfi);
		BNFCLKNDBLO bnfclkndblo = new BNFCLKNDBLO();
		bnfclkndblo.IBFLNCMCKAL = GDJPPKAMIFL.EHBBFMCILPC.KANJCCECECA(lllcdmnpkfi);
		string text = GKJPOGNFKNK.OCOEFCIJGIE(lllcdmnpkfi);
		if (text.Length > 0)
		{
			bnfclkndblo.IBFLNCMCKAL = text;
		}
		bnfclkndblo.FPJPHNLANPG = 2;
		bnfclkndblo.PGEKNGNHANN = clgfgohbcgj.APMIAIEKIHD;
		bnfclkndblo.FONKDFDJFEL = GDJPPKAMIFL.EHBBFMCILPC.EDBFHCLIONI(lllcdmnpkfi);
		bnfclkndblo.AMKCLHLIIMN = GDJPPKAMIFL.EHBBFMCILPC.GJEINLADFKA(lllcdmnpkfi);
		bnfclkndblo.FJFEPNKBELL = bnfclkndblo.AMKCLHLIIMN + 1;
		int num = GDJPPKAMIFL.EHBBFMCILPC.GCDJGGEMDLP(lllcdmnpkfi);
		int num2 = GKJPOGNFKNK.HPMGFDAPLLP(lllcdmnpkfi);
		if (num2 >= 0)
		{
			num = num2;
		}
		bnfclkndblo.CIEHGJMAFKH = "abs" + GDJPPKAMIFL.EHBBFMCILPC.HBKANKMHEMN(lllcdmnpkfi).ToString() + "asp" + num.ToString();
		bnfclkndblo.OEOPLGFENOO = "abs" + GDJPPKAMIFL.EHBBFMCILPC.BIHMLDGDEGP(lllcdmnpkfi).ToString() + "asp" + GDJPPKAMIFL.EHBBFMCILPC.LDKDEPIGOFN(lllcdmnpkfi).ToString();
		bnfclkndblo.CGBHBJPLKIM = clgfgohbcgj;
		this.ViewCutsceneLobby(bnfclkndblo);
	}

	// Token: 0x06002324 RID: 8996 RVA: 0x000FCCE0 File Offset: 0x000FAEE0
	private void OnEnable()
	{
		PopupSettingsManager.enableVoiceOverOptionInSettigs = false;
		EEIBKLDNBAP.ONMPPJOGCDO(KHPGPLAMAIN.EJCNHEBIOJF());
		if (GeoLocationManager.GeoZoneMayBeFirewalled(LanguageManager.EHBBFMCILPC.GetSelectedLanguage()) && !SceneLobbyManager2.MGCECGDMAMK)
		{
			SceneLobbyManager2.MGCECGDMAMK = true;
			FirebaseAnalyticsManager.EHBBFMCILPC.LogEvent(false, AGEHCPDNBFD.lobbyHitNew.ToString(), FFPHBMFGCNN.lbyStart.ToString(), "", false, false);
		}
		SceneLobbyManager2.doNotUpdatePercent = false;
		try
		{
			base.StartCoroutine(this.CHGNEAGFGDC(this.objectBeforeAds));
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
		LobbyTopMatchSelectorManager.updatePlayerPrefsWithAvatarDataOnAwake = false;
		SceneLobbyManager2.currentlyPlayingAnthology = -1;
		if (SceneLobbyManager2.newSaveSystemErrorCode0 >= 0)
		{
			FirebaseAnalyticsManager.EHBBFMCILPC.LogEvent(false, AGEHCPDNBFD.issueRep.ToString(), FFPHBMFGCNN.newSaveErr0.ToString() + SceneLobbyManager2.newSaveSystemErrorCode0.ToString(), "", true, true);
		}
		if (SceneLobbyManager2.newSaveSystemErrorCode1 >= 0)
		{
			FirebaseAnalyticsManager.EHBBFMCILPC.LogEvent(false, AGEHCPDNBFD.issueRep.ToString(), FFPHBMFGCNN.newSaveErr1.ToString() + SceneLobbyManager2.newSaveSystemErrorCode1.ToString(), "", true, true);
		}
		if (SceneLobbyManager2.newSaveSystemErrorCode2 >= 0)
		{
			FirebaseAnalyticsManager.EHBBFMCILPC.LogEvent(false, AGEHCPDNBFD.issueRep.ToString(), FFPHBMFGCNN.newSaveErr2.ToString() + SceneLobbyManager2.newSaveSystemErrorCode2.ToString(), "", true, true);
		}
		SceneLobbyManager2.newSaveSystemErrorCode0 = -1;
		SceneLobbyManager2.newSaveSystemErrorCode1 = -1;
		SceneLobbyManager2.newSaveSystemErrorCode2 = -1;
		this.scrollView0Controller.GetComponent<ScrollRect>().scrollSensitivity = 100f;
		this.scrollView1Controller.GetComponent<ScrollRect>().scrollSensitivity = 100f;
		this.scrollView2Controller.GetComponent<ScrollRect>().scrollSensitivity = 100f;
		this.rewardItemScrollRect.scrollSensitivity = 100f;
		FocusItem.isFocusOpened = false;
		SystemBackButtonManager.SetActiveGlobal(true);
		PlayerCharacterManager.SetCurrentAnthologyIndex(-1);
		PopupSettingsManager.forceHideSoundOption = false;
		LPEMDECEIAO.IJJJHIGEANA();
		ApplicationFocusManager.Deactivate();
		if (NBDLBFJOEGN.LAIDCKNIOIN() > 2.35f)
		{
			this.headerLayoutGroup.spacing = 3f;
			this.additionalHeaderSpacing.GetComponent<RectTransform>().EFOCKEJENAC(5f);
		}
		else
		{
			this.headerLayoutGroup.spacing = 13f;
			this.additionalHeaderSpacing.GetComponent<RectTransform>().EFOCKEJENAC(-6f);
		}
		AssetsManager.EHBBFMCILPC.GetLoadingProgressSnapshot().CLIOEOLFFLO(LEJKDNAGDHC.Fast);
		this.notificationFreeDiamonds.SetActive(false);
		this.notificationFreeDiamondsHidden.SetActive(true);
		this.JNKEHEBNBAP();
		this.JLFGANHMMOM();
		AssetsManager.CacheAssetBundle(OMIMIKMIMFE.OLLHNNHBEJB("assetbundlecommonpack0"));
		ODJKHCHFKNL.HIPEENBHGKP(DFGILFBGPLN.screenLobby);
		LoadingEnvironmentManager.AdoptOverlayElement(this.disclaimerImpers.rectTransform);
		if (!SceneRestartManager.sceneRestartManagerHit)
		{
			CommonUserInterface.EHBBFMCILPC.GetFader().FadeOut(null);
		}
		SceneRestartManager.sceneRestartManagerHit = false;
		if (!AKLFPGMDKLA.EHBBFMCILPC.INEKFCLBCAB())
		{
			AKLFPGMDKLA.EHBBFMCILPC.IDPFOGHKMBL();
			AKLFPGMDKLA.EHBBFMCILPC.IEGJCPDCLMM = -1;
		}
		StorySplashManager.skipIntrusiveAd = false;
		PopupSettingsManager.excludeCurrentChapterMissingLanguages = false;
		this.EKNLABKCIJF();
		AOBJLALDBAA.EHBBFMCILPC.MFIMALJPCDP("OnFullscreenCardOptionClickLobby", new UnityAction(this.ViewCardCutsceneLobby));
		AOBJLALDBAA.EHBBFMCILPC.MFIMALJPCDP("OnCutsceneViewLobbyAssetBundleFolderInitializeSuccess", new UnityAction(this.IHBCLCLNFJM));
		AOBJLALDBAA.EHBBFMCILPC.MFIMALJPCDP("OnCutsceneViewLobbyAssetsDownloadSuccess", new UnityAction(this.NKDJKLHMAJN));
		AOBJLALDBAA.EHBBFMCILPC.MFIMALJPCDP("OnCutsceneViewLobbyAssetsDownloadFailed", new UnityAction(this.ICPIGGMCHEN));
		AOBJLALDBAA.EHBBFMCILPC.MFIMALJPCDP("OnBackendPassesReinitialized", new UnityAction(this.CKNBPMFGHML));
		AOBJLALDBAA.EHBBFMCILPC.MFIMALJPCDP("OnPopupCardOptionsUnlockWithSpSuccessContinueLobby", new UnityAction(this.OOALGPIOODP));
		AOBJLALDBAA.EHBBFMCILPC.MFIMALJPCDP("OnPopupCardOptionsBackClickLobby", new UnityAction(this.OnPopupCardOptionsBackClickLobby));
		AOBJLALDBAA.EHBBFMCILPC.MFIMALJPCDP("OnPopupCardOptionsNextClickLobby", new UnityAction(this.OnPopupCardOptionsNextClickLobby));
		AOBJLALDBAA.EHBBFMCILPC.MFIMALJPCDP("OnAllCollectableCardsDownloadSuccessLobby", new UnityAction(this.JEPJKDAFBMH));
		AOBJLALDBAA.EHBBFMCILPC.MFIMALJPCDP("OnAllCollectableCardsDownloadFailedLobby", new UnityAction(this.JNCJEGFNCCP));
		AOBJLALDBAA.EHBBFMCILPC.MFIMALJPCDP("OnUpdateSocialEventsCounter", new UnityAction(this.DHGGEFIJBHM));
		AOBJLALDBAA.EHBBFMCILPC.MFIMALJPCDP("OnCutsceneViewLeft", new UnityAction(this.LBFDDEFKCJN));
		AOBJLALDBAA.EHBBFMCILPC.MFIMALJPCDP("OnSketchViewLeft", new UnityAction(this.EHIBOKHHKBF));
		AOBJLALDBAA.EHBBFMCILPC.MFIMALJPCDP("OnCutsceneViewShow", new UnityAction(this.KHCPHAIGBJE));
		AOBJLALDBAA.EHBBFMCILPC.MFIMALJPCDP("OnCutsceneViewShowWI", new UnityAction(this.IMINAEKJFCK));
		AOBJLALDBAA.EHBBFMCILPC.MFIMALJPCDP("OnSketchViewShowWI", new UnityAction(this.EHBEAAKMMLL));
		AOBJLALDBAA.EHBBFMCILPC.MFIMALJPCDP("OnSaveSyncAnyResult", new UnityAction(this.GIIFOHCFDEJ));
		AOBJLALDBAA.EHBBFMCILPC.MFIMALJPCDP("OnSaveSlotsUnlockContinueToPurchasingScreen", new UnityAction(this.LBEMJPOHBGK));
		AOBJLALDBAA.EHBBFMCILPC.MFIMALJPCDP("OnSaveSlotsItemSlotChanged", new UnityAction(this.DGNPNOKIKJC));
		AOBJLALDBAA.EHBBFMCILPC.MFIMALJPCDP("OnSaveSlotsItemSlotDeleted", new UnityAction(this.EFNPBHABEME));
		AOBJLALDBAA.EHBBFMCILPC.MFIMALJPCDP("OnSaveSlotsItemSlotDuplicated", new UnityAction(this.HBLJJDBLGMG));
		AOBJLALDBAA.EHBBFMCILPC.MFIMALJPCDP("OnSaveSyncAnyResultDuplicate", new UnityAction(this.CGDGJIKCLBL));
		AOBJLALDBAA.EHBBFMCILPC.MFIMALJPCDP("OnApplicationBeforeRestart", new UnityAction(this.JEKCPAGMFBE));
		AOBJLALDBAA.EHBBFMCILPC.MFIMALJPCDP("OnMissingPreview2CdnSuccess", new UnityAction(this.COIJDOCAABP));
		AOBJLALDBAA.EHBBFMCILPC.MFIMALJPCDP("OnMissingPreview2CdnFailed", new UnityAction(this.MBEIIFKJEKD));
		AOBJLALDBAA.EHBBFMCILPC.MFIMALJPCDP("OnLiveProfileThumbnailsCdnSuccess", new UnityAction(this.BJPEICPDFHJ));
		AOBJLALDBAA.EHBBFMCILPC.MFIMALJPCDP("OnLiveProfileThumbnailsCdnFailed", new UnityAction(this.BAGNOCIMPBD));
		AOBJLALDBAA.EHBBFMCILPC.MFIMALJPCDP("OnLiveProfileThemesLoaderStart", new UnityAction(this.JGIMEDGEAGE));
		AOBJLALDBAA.EHBBFMCILPC.MFIMALJPCDP("OnLiveProfileThemesLoaderStop", new UnityAction(this.PCCPFFIJNIO));
		AOBJLALDBAA.EHBBFMCILPC.MFIMALJPCDP("OnLiveProfileThemeBackgroundCdnSuccess", new UnityAction(this.AELPLJGOJJK));
		AOBJLALDBAA.EHBBFMCILPC.MFIMALJPCDP("OnLiveProfileThemeBackgroundCdnFailed", new UnityAction(this.GMOBHPBBPNF));
		AOBJLALDBAA.EHBBFMCILPC.MFIMALJPCDP("OnLobbyProfileDataCdnSuccess", new UnityAction(this.NELHGHFAGFH));
		AOBJLALDBAA.EHBBFMCILPC.MFIMALJPCDP("OnLobbyProfileDataCdnFailed", new UnityAction(this.FECFNFKHLKM));
		AOBJLALDBAA.EHBBFMCILPC.MFIMALJPCDP("OnNeedToRestartProfileItemAnimation", new UnityAction(this.KBOOHCDEOIJ));
		AOBJLALDBAA.EHBBFMCILPC.MFIMALJPCDP("OnBackendGetPublicProfileException", new UnityAction(this.HAJDMFMINFE));
		AOBJLALDBAA.EHBBFMCILPC.MFIMALJPCDP("OnBackendGetPublicProfileSuccess", new UnityAction(this.MOCCHMAHHNK));
		AOBJLALDBAA.EHBBFMCILPC.MFIMALJPCDP("OnBackendSavePublicProfileException", new UnityAction(this.EGINOCCMDMD));
		AOBJLALDBAA.EHBBFMCILPC.MFIMALJPCDP("OnBackendSavePublicProfileSuccess", new UnityAction(this.MCPPLMGAGJN));
		AOBJLALDBAA.EHBBFMCILPC.MFIMALJPCDP("OnLobbyManInTheMiddleAttackDetected", new UnityAction(this.IIEGAKKFKIJ));
		AOBJLALDBAA.EHBBFMCILPC.MFIMALJPCDP("OnPopupUpdateWelcomeWhatsMoreClick", new UnityAction(this.JOFDIMJKENC));
		AOBJLALDBAA.EHBBFMCILPC.MFIMALJPCDP("OnResolutionChanged", new UnityAction(this.KCLCJADHJEH));
		AOBJLALDBAA.EHBBFMCILPC.MFIMALJPCDP("OnSettingsPopupCloseAndNeedToRestartGame", new UnityAction(this.CMKPNGPCDAB));
		AOBJLALDBAA.EHBBFMCILPC.MFIMALJPCDP("OnSettingsPopupCloseAndNeedToRestartGame2", new UnityAction(this.DNGHLBFEODC));
		AOBJLALDBAA.EHBBFMCILPC.MFIMALJPCDP("OnSettingsPopupCloseAndNeedToShowPostEnableNotif", new UnityAction(this.OCIAMGMLMLG));
		AOBJLALDBAA.EHBBFMCILPC.MFIMALJPCDP("OnSettingsPopupCloseAndNeedToShowGameModeNotif", new UnityAction(this.IKFEBEDGOIG));
		AOBJLALDBAA.EHBBFMCILPC.MFIMALJPCDP("OnPurchasingViewLeave", new UnityAction(this.IAIIODBDKHK));
		AOBJLALDBAA.EHBBFMCILPC.MFIMALJPCDP(SceneAvatarManager.onAvatarScreenLeft, new UnityAction(this.GPNFLDDKLAJ));
		this.JFKINOOLKJN();
		AOBJLALDBAA.EHBBFMCILPC.MFIMALJPCDP("OnAvatarScreenAssetsDownloadSuccess", new UnityAction(this.OINFFDNGJHF));
		AOBJLALDBAA.EHBBFMCILPC.MFIMALJPCDP("OnAvatarScreenAssetBundleFolderInitializeSuccess", new UnityAction(this.HGPGOPCOFKB));
		AOBJLALDBAA.EHBBFMCILPC.MFIMALJPCDP("OnAvatarScreenAssetsDownloadFailed", new UnityAction(this.GNEIAKDLELG));
		AOBJLALDBAA.EHBBFMCILPC.MFIMALJPCDP("OnChapterSnapshotRestoreExecute", new UnityAction(this.OnChapterSnapshotRestoreExecute));
		AOBJLALDBAA.EHBBFMCILPC.MFIMALJPCDP("OnPopupStoryRestartManagerRestartChapter", new UnityAction(this.RestartChapter));
		AOBJLALDBAA.EHBBFMCILPC.MFIMALJPCDP("OnPopupStoryRestartManagerRestartStory", new UnityAction(this.RestartStory));
		AOBJLALDBAA.EHBBFMCILPC.MFIMALJPCDP("OnPopupStoryRestartManagerRestartStory0", new UnityAction(this.RestartStory0));
		AOBJLALDBAA.EHBBFMCILPC.MFIMALJPCDP("OnPopupStoryRestartManagerRestartStory1", new UnityAction(this.RestartStory1));
		AOBJLALDBAA.EHBBFMCILPC.MFIMALJPCDP("OnPopupStoryRestartManagerRestartStory2", new UnityAction(this.RestartStory2));
		AOBJLALDBAA.EHBBFMCILPC.MFIMALJPCDP("OnPopupStoryRestartManagerRestartStory3", new UnityAction(this.RestartStory3));
		AOBJLALDBAA.EHBBFMCILPC.MFIMALJPCDP("OnPopupStoryRestartManagerRestartStory4", new UnityAction(this.RestartStory4));
		AOBJLALDBAA.EHBBFMCILPC.MFIMALJPCDP("OnBackendStartPlayChapterSuccess", new UnityAction(this.OFHBPNBDAKO));
		AOBJLALDBAA.EHBBFMCILPC.MFIMALJPCDP("OnBackendStartPlayChapterException", new UnityAction(this.EOPMIONFFPM));
		AOBJLALDBAA.EHBBFMCILPC.MFIMALJPCDP("OnLobbyStoryManagerDownloadSplashScreenFailed", new UnityAction(this.DBHOJGKJPND));
		AOBJLALDBAA.EHBBFMCILPC.MFIMALJPCDP("OnLobbyStoryManagerDownloadSplashScreenSuccess", new UnityAction(this.IEJGBPPPIHD));
		AOBJLALDBAA.EHBBFMCILPC.MFIMALJPCDP(SceneLobbyManager2.EIODJHDOHPE, new UnityAction(this.JEPHPIMHGJD));
		AOBJLALDBAA.EHBBFMCILPC.MFIMALJPCDP(SceneLobbyManager2.MHOJMLGCLOD, new UnityAction(this.OBCFGOCKEEP));
		AOBJLALDBAA.EHBBFMCILPC.MFIMALJPCDP("OnBackendGetIncentRewardAdSuccess", new UnityAction(this.ILBNPEIJKJM));
		AOBJLALDBAA.EHBBFMCILPC.MFIMALJPCDP("OnBackendGetIncentRewardAdException", new UnityAction(this.LGEHFJOINIL));
		AOBJLALDBAA.EHBBFMCILPC.MFIMALJPCDP("OnGenericPopupManagerHide", new UnityAction(this.KMKDECPKCMF));
		AOBJLALDBAA.EHBBFMCILPC.MFIMALJPCDP("OnPopupOfferManagerContinueToPurchasingScreen", new UnityAction(this.CPEELJJHCNA));
		AOBJLALDBAA.EHBBFMCILPC.MFIMALJPCDP("OnDailyRewardPopupHide", new UnityAction(this.BCKFLJLMNDC));
		AOBJLALDBAA.EHBBFMCILPC.MFIMALJPCDP("OnReturnRewardPopupHide", new UnityAction(this.FGIMMLMHMGJ));
		AOBJLALDBAA.EHBBFMCILPC.MFIMALJPCDP("OnSceneLobbyManagerExitSyncSuccess", new UnityAction(this.GONBHNMNOLP));
		AOBJLALDBAA.EHBBFMCILPC.MFIMALJPCDP("OnNeedToShowNoMoreEnergyPopup", new UnityAction(this.OnNeedToShowNoMoreEnergyPopup));
		AOBJLALDBAA.EHBBFMCILPC.MFIMALJPCDP("OnNeedToShowNoMoreHardPopup", new UnityAction(this.OnNeedToShowNoMoreHardPopup));
		AOBJLALDBAA.EHBBFMCILPC.MFIMALJPCDP("OnAccountSignInSuccess", new UnityAction(this.GMFFLAFLGHH));
		AOBJLALDBAA.EHBBFMCILPC.MFIMALJPCDP("OnLanguageChange", new UnityAction(this.LLMPAPDBHEL));
		AOBJLALDBAA.EHBBFMCILPC.MFIMALJPCDP("OnSceneLobbyManagerRound0AssetsDownloadSuccess", new UnityAction(this.FCJAODPFFGC));
		AOBJLALDBAA.EHBBFMCILPC.MFIMALJPCDP("OnSceneLobbyManagerRound0aAssetsDownloadSuccess", new UnityAction(this.BHGOGAKGGEG));
		AOBJLALDBAA.EHBBFMCILPC.MFIMALJPCDP("OnSceneLobbyManagerRound0aaAssetsDownloadSuccess", new UnityAction(this.GEMOOEPJGHP));
		AOBJLALDBAA.EHBBFMCILPC.MFIMALJPCDP("OnSceneLobbyManagerRound1AssetsDownloadSuccess", new UnityAction(this.DEOEFKNLOHM));
		AOBJLALDBAA.EHBBFMCILPC.MFIMALJPCDP("OnSceneLobbyManagerAssetsDownloadFailed", new UnityAction(this.NAIPKHPLOGF));
		AOBJLALDBAA.EHBBFMCILPC.MFIMALJPCDP("OnBackendGetDefaultBundlesSuccess", new UnityAction(this.PDLHBIIGLJD));
		AOBJLALDBAA.EHBBFMCILPC.MFIMALJPCDP("OnBackendGetDefaultBundlesException", new UnityAction(this.KNLCPLJLJCC));
		AOBJLALDBAA.EHBBFMCILPC.MFIMALJPCDP("OnApplicationFocusNeedToUpdateCurrency", new UnityAction(this.JPDHKJCINAF));
		AOBJLALDBAA.EHBBFMCILPC.MFIMALJPCDP("OnSocialModeChanged", new UnityAction(this.OnSocialModeChanged));
		AOBJLALDBAA.EHBBFMCILPC.MFIMALJPCDP("OnEmailSubscribeSuccess", new UnityAction(this.IOPEFJJGAFF));
		AOBJLALDBAA.EHBBFMCILPC.MFIMALJPCDP("OnEmailSubscribeException", new UnityAction(this.FLOAFHNAKJM));
		AOBJLALDBAA.EHBBFMCILPC.MFIMALJPCDP("OnEmailUnsubscribeSuccess", new UnityAction(this.PACLPFDOHEI));
		AOBJLALDBAA.EHBBFMCILPC.MFIMALJPCDP("OnEmailUnsubscribeException", new UnityAction(this.LCLOPECGHMG));
		AOBJLALDBAA.EHBBFMCILPC.MFIMALJPCDP("OnRewardOptionProfileClick", new UnityAction(this.OBDEAPLGMDM));
		AOBJLALDBAA.EHBBFMCILPC.MFIMALJPCDP("OnRewardFirstEpisodeClick", new UnityAction(this.MIPEOPGCNIA));
		AOBJLALDBAA.EHBBFMCILPC.MFIMALJPCDP("OnRewardSubsequentEpisodeClick", new UnityAction(this.NMJNFFCENDF));
		AOBJLALDBAA.EHBBFMCILPC.MFIMALJPCDP("OnRewardReplayEpisodeClick", new UnityAction(this.PBDBLMMMMFF));
		AOBJLALDBAA.EHBBFMCILPC.MFIMALJPCDP("OnRewardStoryCompleteClick", new UnityAction(this.OJEMLBDNFKE));
		AOBJLALDBAA.EHBBFMCILPC.MFIMALJPCDP("OnRewardFreeDiamondsClick", new UnityAction(this.GLDAFFNHKFJ));
		AOBJLALDBAA.EHBBFMCILPC.MFIMALJPCDP("OnRewardFreeSpinsClick", new UnityAction(this.PDPAOELMHKF));
		AOBJLALDBAA.EHBBFMCILPC.MFIMALJPCDP("OnRewardFreePassPlayStore", new UnityAction(this.MNHPBGIFPJK));
		AOBJLALDBAA.EHBBFMCILPC.MFIMALJPCDP("OnApplicationFocusBasicSyncSuccess", new UnityAction(this.OFFBAMLEFNH));
		AOBJLALDBAA.EHBBFMCILPC.MFIMALJPCDP("OnCardVolumeUnlockContinueToPurchasingScreen", new UnityAction(this.CHAKGJICCJG));
		AOBJLALDBAA.EHBBFMCILPC.MFIMALJPCDP("OnFriendsPlusUnlockContinueToPurchasingScreen", new UnityAction(this.ABCCMIBKPFL));
		AOBJLALDBAA.EHBBFMCILPC.MFIMALJPCDP("OnBackendGetDropChancesSuccess", new UnityAction(this.DJDBKHPCDKM));
		AOBJLALDBAA.EHBBFMCILPC.MFIMALJPCDP("OnBackendGetDropChancesException", new UnityAction(this.AAMCENHGBCM));
		AOBJLALDBAA.EHBBFMCILPC.MFIMALJPCDP("OnBackendGetDropChancesSuccess2", new UnityAction(this.BCEMOOCBJFJ));
		AOBJLALDBAA.EHBBFMCILPC.MFIMALJPCDP("OnBackendGetDropChancesException2", new UnityAction(this.ADPBMDNMDNG));
		AOBJLALDBAA.EHBBFMCILPC.MFIMALJPCDP("OnLobbyWheelDataCdnSuccess", new UnityAction(this.ONHLICMODAO));
		AOBJLALDBAA.EHBBFMCILPC.MFIMALJPCDP("OnLobbyWheelDataDataCdnFailed", new UnityAction(this.LHGOFKKNKOE));
		AOBJLALDBAA.EHBBFMCILPC.MFIMALJPCDP("OnLobbySkinShopCdnSuccess", new UnityAction(this.PIEHMJKPIGK));
		AOBJLALDBAA.EHBBFMCILPC.MFIMALJPCDP("OnLobbySkinShopCdnFailed", new UnityAction(this.FGOFPMAGNMJ));
		AOBJLALDBAA.EHBBFMCILPC.MFIMALJPCDP("OnSkinShopClose", new UnityAction(this.EDMJHANBNIN));
		AOBJLALDBAA.EHBBFMCILPC.MFIMALJPCDP("OnSkinShopCardSelected", new UnityAction(this.EHKDHDDJHLL));
		AOBJLALDBAA.EHBBFMCILPC.MFIMALJPCDP("OnSpinsUnlockContinueToPurchasingScreen", new UnityAction(this.CPCHLINKCAK));
		AOBJLALDBAA.EHBBFMCILPC.MFIMALJPCDP("OnCardUpgradeContinueToPurchasingScreen", new UnityAction(this.AMFLJPANFGF));
		AOBJLALDBAA.EHBBFMCILPC.MFIMALJPCDP("OnLobbyStartFireworksEffect", new UnityAction(this.PAFLEJIHGKJ));
		AOBJLALDBAA.EHBBFMCILPC.MFIMALJPCDP("OnLobbyStopFireworksEffect", new UnityAction(this.HCLLBPGCHID));
		AOBJLALDBAA.EHBBFMCILPC.MFIMALJPCDP("OnLobbyStartFireworksEffectAutoHide", new UnityAction(this.OLLKOHMOEGI));
		AOBJLALDBAA.EHBBFMCILPC.MFIMALJPCDP("OnBackendGetSketchesBalanceSuccess", new UnityAction(this.HKPFHDPBJOI));
		AOBJLALDBAA.EHBBFMCILPC.MFIMALJPCDP("OnBackendGetSketchesBalanceException", new UnityAction(this.KHELKJHAPPJ));
		AOBJLALDBAA.EHBBFMCILPC.MFIMALJPCDP("OnSketchThumbnailsCdnSuccess", new UnityAction(this.MNJNCFPELEC));
		AOBJLALDBAA.EHBBFMCILPC.MFIMALJPCDP("OnSketchThumbnailsCdnFailed", new UnityAction(this.DDGPJJHEHLG));
		AOBJLALDBAA.EHBBFMCILPC.MFIMALJPCDP("OnGamePassUnlockContinueToPurchasingScreen", new UnityAction(this.LMJGOIINBIC));
		AOBJLALDBAA.EHBBFMCILPC.MFIMALJPCDP("OnFullscreenLiveOfferContinueToPurchasingScreen", new UnityAction(this.GHOHFJCGAMJ));
		AOBJLALDBAA.EHBBFMCILPC.MFIMALJPCDP("OnFullscreenLiveOfferContinueToCardsVolSaleMenu", new UnityAction(this.JMBBBIDIHLO));
		AOBJLALDBAA.EHBBFMCILPC.MFIMALJPCDP("OnLiveOfferSuccessShowPassesWindow", new UnityAction(this.DLHBCDJOMMC));
		AOBJLALDBAA.EHBBFMCILPC.MFIMALJPCDP("OnRestartChapterUpsellGetPassNegative", new UnityAction(this.FAIDPMGBPIF));
		AOBJLALDBAA.EHBBFMCILPC.MFIMALJPCDP("OnRestartChapterUpsellGetPassPositive", new UnityAction(this.CJEJENJBDDF));
		AOBJLALDBAA.EHBBFMCILPC.MFIMALJPCDP("onLoadingThemeSubscribeRequested", new UnityAction(this.AJPPPKIOGKK));
		base.StartCoroutine(this.IEGMGIEGIGJ());
		this.ShowHideSocialFeatures();
	}

	// Token: 0x06002325 RID: 8997 RVA: 0x000FDD34 File Offset: 0x000FBF34
	public void MNGLPIMCAED()
	{
		JBBNEEHANHL jbbneehanhl = (JBBNEEHANHL)(-13);
		GridController[] componentsInChildren2;
		if (AKLFPGMDKLA.EHBBFMCILPC.JCBEPJJHAII(AssetsManager.MJBDMHPHMID().anthologyAssets).Count <= 0)
		{
			FilterItem[] componentsInChildren = this.scrollView2Controller.GetComponentsInChildren<FilterItem>(false);
			for (int i = 0; i < componentsInChildren.Count<FilterItem>(); i += 0)
			{
				if (componentsInChildren[i].id == jbbneehanhl)
				{
					FilterItem filterItem = null;
					int siblingIndex = componentsInChildren[i].transform.GetSiblingIndex();
					int childCount = this.filterItemsParent.transform.childCount;
					for (int j = 0; j < childCount; j++)
					{
						int index = (siblingIndex + j) % childCount;
						FilterItem component = this.filterItemsParent.transform.GetChild(index).GetComponent<FilterItem>();
						if (!(null == component) && component.gameObject.activeSelf && jbbneehanhl != component.id && (JBBNEEHANHL)(-52) != component.id)
						{
							filterItem = component;
							break;
						}
					}
					if (null == filterItem)
					{
						DPGJIJGOCIC.ANOPFDLPKGC("wofbutton3");
						return;
					}
					filterItem.toggle.isOn = true;
					this.BCOOKJICILK(filterItem.id);
					componentsInChildren[i].toggle.isOn = true;
					componentsInChildren[i].gameObject.SetActive(false);
				}
			}
			componentsInChildren2 = this.scrollView0Controller.GetComponentsInChildren<GridController>(false);
			for (int k = 1; k < componentsInChildren2.Length; k++)
			{
				GridController gridController = componentsInChildren2[k];
				if (gridController.filter == jbbneehanhl && !SceneLobbyManager2.IsGroupedFilter(jbbneehanhl))
				{
					gridController.gameObject.SetActive(false);
					gridController.transform.SetSiblingIndex(2);
					ThumbnailItem[] componentsInChildren3 = gridController.GetComponentsInChildren<ThumbnailItem>(true);
					for (int l = 0; l < componentsInChildren3.Length; l += 0)
					{
						ThumbnailItem thumbnailItem = componentsInChildren3[l];
						if (thumbnailItem.index == this.focusItem.GetComponent<FocusItem>().currentAnthologyIndex)
						{
							UnityEngine.Object.Destroy(thumbnailItem.gameObject);
						}
					}
				}
			}
			this.LGKCHPBIIGA(false);
			return;
		}
		componentsInChildren2 = this.scrollView0Controller.GetComponentsInChildren<GridController>(true);
		for (int k = 0; k < componentsInChildren2.Length; k += 0)
		{
			GridController gridController2 = componentsInChildren2[k];
			if (gridController2.filter == jbbneehanhl && !SceneLobbyManager2.IsGroupedFilter(jbbneehanhl))
			{
				ThumbnailItem[] componentsInChildren3 = gridController2.GetComponentsInChildren<ThumbnailItem>(false);
				for (int l = 0; l < componentsInChildren3.Length; l += 0)
				{
					ThumbnailItem thumbnailItem2 = componentsInChildren3[l];
					if (thumbnailItem2.index == this.focusItem.GetComponent<FocusItem>().currentAnthologyIndex)
					{
						UnityEngine.Object.Destroy(thumbnailItem2.gameObject);
						base.StartCoroutine(this.OIFMCGLDCJK(gridController2.gameObject));
					}
				}
			}
		}
		this.LGKCHPBIIGA(false);
	}

	// Token: 0x06002326 RID: 8998 RVA: 0x000F6CF2 File Offset: 0x000F4EF2
	private void JOFDIMJKENC()
	{
		this.ActivateFilter(JBBNEEHANHL.filterNew);
	}

	// Token: 0x06002327 RID: 8999 RVA: 0x000F03EE File Offset: 0x000EE5EE
	private void BCKFLJLMNDC()
	{
		if (ODJKHCHFKNL.LEMILALILKP() != DFGILFBGPLN.screenLobby)
		{
			return;
		}
		this.KKKKNGFMEHF();
	}

	// Token: 0x06002328 RID: 9000 RVA: 0x000FDFB4 File Offset: 0x000FC1B4
	private void GIIFOHCFDEJ()
	{
		CommonUserInterface.EHBBFMCILPC.HideConnectingAnimation();
		this.CPLLGNAKIIL(this.LGKGGPDKAHF);
		if (null != this.LGKGGPDKAHF)
		{
			this.ONGICLLGJGO(this.LGKGGPDKAHF.index);
		}
		base.StartCoroutine(this.MEMFKOENHKF());
	}

	// Token: 0x06002329 RID: 9001 RVA: 0x000FE003 File Offset: 0x000FC203
	private IEnumerator NBKMFHDIBPK()
	{
		AssetsManager.EHBBFMCILPC.GetLoadingProgressSnapshot().EPJKDCDOEMM(0);
		CommonUserInterface.EHBBFMCILPC.ShowConnectingAnimationWithProgress(96);
		yield return new WaitForSeconds(0.2f);
		List<CLGFGOHBCGJ> list = LJNMIPMNOKF.EHBBFMCILPC.AOOPMDIBAFP();
		for (int i = 0; i < list.Count; i++)
		{
			int mefkfohcohk = list[i].CCMDLENEDGJ;
			int num = GKJPOGNFKNK.IDKIIANDMPM(list[i].CCMDLENEDGJ);
			if (num >= 0)
			{
				mefkfohcohk = num;
			}
			AssetsManager.EHBBFMCILPC.QueueAssetBundleDownload(NMKDCBPMCKI.AssetBundleCollectableCard, mefkfohcohk, -1, FLDBFOADFLH.finishDownloadAndProceed, false, false, false, null, -1, false, "", false, false);
		}
		AssetsManager.EHBBFMCILPC.GetLoadingProgressSnapshot().CLIOEOLFFLO(LEJKDNAGDHC.Fast);
		AssetsManager.EHBBFMCILPC.GetLoadingProgressSnapshot().GIJKJMMDJEL(0f, 1f);
		AssetsManager.EHBBFMCILPC.DownloadQueuedAssetBundles("OnAllCollectableCardsDownloadSuccessLobby", "OnAllCollectableCardsDownloadFailedLobby", false);
		yield break;
	}

	// Token: 0x0600232A RID: 9002 RVA: 0x000FE00C File Offset: 0x000FC20C
	private void NMJNFFCENDF()
	{
		if (AKLFPGMDKLA.EHBBFMCILPC.IKHNDKEEECD().Count > 0)
		{
			AssetAnthologyPreview2 assetAnthologyPreview = GKJPOGNFKNK.OGKPKBLFGMJ(AKLFPGMDKLA.EHBBFMCILPC.IKHNDKEEECD()[DPGJIJGOCIC.IOOHGEJIPFP(0, AKLFPGMDKLA.EHBBFMCILPC.IKHNDKEEECD().Count)]);
			if (null != assetAnthologyPreview)
			{
				this.CPLLGNAKIIL(assetAnthologyPreview);
			}
			DPGJIJGOCIC.NFIDPOMCNLP("SceneLobbyManager2.OnRewardSubsequentEpisodeClick() getting one random out of " + AKLFPGMDKLA.EHBBFMCILPC.IKHNDKEEECD().Count.ToString());
		}
	}

	// Token: 0x0600232B RID: 9003 RVA: 0x000FE08C File Offset: 0x000FC28C
	private static StoryEnvironmentManager KFLJELOKJJO(List<StoryEnvironmentManager> KNPGOLNLHJC, string KHJMANDEDMA, PLFDAJJHMKO LFLOCKNKAKC)
	{
		if (KNPGOLNLHJC == null || KHJMANDEDMA == null || LFLOCKNKAKC == null)
		{
			return null;
		}
		string value = LFLOCKNKAKC.NCAMFPGMCIG.GCOHKKMPJKJ(KHJMANDEDMA);
		for (int i = 0; i < KNPGOLNLHJC.Count; i++)
		{
			if (null != KNPGOLNLHJC[i] && KNPGOLNLHJC[i].gameObject.name.Equals(value))
			{
				return KNPGOLNLHJC[i];
			}
		}
		return null;
	}

	// Token: 0x0600232C RID: 9004 RVA: 0x000FE0F4 File Offset: 0x000FC2F4
	public void OnAvatarClick()
	{
		if (this.NeedToCompletePrequelAnthology())
		{
			return;
		}
		FocusItem focusItem = (null != this.focusItem) ? this.focusItem.GetComponent<FocusItem>() : null;
		if (null != focusItem && focusItem.AvatarButtonOffersLounge())
		{
			CommonUserInterface.EHBBFMCILPC.ShowGenericPopupWithTwoButtonsAndCloseOverride(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("focuswardrobetitle"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("focuswardrobebody"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("focuswardrobeavatar"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("focuswardrobelounge"), new UnityAction(this.OnAvatarClickProceed), new UnityAction(this.ONEPBGINIEH), new UnityAction(this.FMPNGJCANAG), DFGILFBGPLN.popupSignInQuestion, 0f, 28);
			return;
		}
		this.OnAvatarClickProceed();
	}

	// Token: 0x0600232D RID: 9005 RVA: 0x000FE1B4 File Offset: 0x000FC3B4
	private List<KLJCEMBNKNI> EPMMCPAPNLM(JBBNEEHANHL HBBJBNJBMPK)
	{
		if (HBBJBNJBMPK != JBBNEEHANHL.filterNew)
		{
			switch (HBBJBNJBMPK)
			{
			case JBBNEEHANHL.filterAll:
				return this.DEFGJKADGKB();
			case JBBNEEHANHL.filterContinuePlaying:
				return this.HOCALHHJHNE();
			case JBBNEEHANHL.filterTopRated:
			case JBBNEEHANHL.filterSpecialEpisodes:
				break;
			case JBBNEEHANHL.filterMostPopular:
				return this.OKPNLKEBMPH();
			default:
				switch (HBBJBNJBMPK)
				{
				case JBBNEEHANHL.filterFavorites:
					return this.FDDNNGNHMFP();
				case JBBNEEHANHL.filterSearch:
					return this.LIAHCBGCPEN();
				case JBBNEEHANHL.filterFranchises:
					return this.HMJLJCLPLIK();
				case JBBNEEHANHL.filterExplore:
					return this.CHIGBPGKPFI();
				case JBBNEEHANHL.filterStarter:
					return this.GNPBHDFEEHE();
				}
				break;
			}
			return new List<KLJCEMBNKNI>();
		}
		return this.PGBKAHOGNGO();
	}

	// Token: 0x0600232E RID: 9006 RVA: 0x000FE244 File Offset: 0x000FC444
	private void AGGHLICBNNF()
	{
		this.EFHDFDHBKLM();
		CommonUserInterface.EHBBFMCILPC.HideConnectingAnimation();
		CommonUserInterface.EHBBFMCILPC.GetFader().FadeIn(new TweenCallback(this.HINDFDCEKAK));
		for (int i = 0; i < this.lobbyParticles.Count; i++)
		{
			if (null != this.lobbyParticles[i])
			{
				this.lobbyParticles[i].Stop();
			}
		}
		this.CMDIKMNEGEN();
		this.GBBHKFFENBE = false;
	}

	// Token: 0x0600232F RID: 9007 RVA: 0x000FE2C4 File Offset: 0x000FC4C4
	private void KCLCJADHJEH()
	{
		if (this.PDFIHFFJMJN && !App42Manager.EHBBFMCILPC.IsBusy() && !AssetsManager.EHBBFMCILPC.IsBusy())
		{
			CommonUserInterface.EHBBFMCILPC.ShowGenericPopupTwoOverride(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("importanttitle"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("needtorestartgeneric"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("ok"), new UnityAction(this.FKPLFIDCPLP), new UnityAction(this.FKPLFIDCPLP), DFGILFBGPLN.popupSignInSuccess, 0.2f, 28);
			AudioManager.EHBBFMCILPC.ResetAudioSettings();
		}
	}

	// Token: 0x06002330 RID: 9008 RVA: 0x000FE354 File Offset: 0x000FC554
	private void LFFAPMLLHFH()
	{
		LoadingEnvironmentManager.DestroyIfAlive();
		if (null != AssetsManager.EHBBFMCILPC.GetStorySplashManager(0))
		{
			base.StartCoroutine(this.BPFOFJJDHHD());
			return;
		}
		DPGJIJGOCIC.ANOPFDLPKGC("There are no story splash managers!");
	}

	// Token: 0x06002331 RID: 9009 RVA: 0x000FB163 File Offset: 0x000F9363
	private void CANCPNMKKFM()
	{
		this.MGNKGDNOKEK(this.FMJEJOGDBHA);
		this.BAKCPDNFFMH();
	}

	// Token: 0x06002332 RID: 9010 RVA: 0x000FE386 File Offset: 0x000FC586
	private IEnumerator KGCKFGMOCJK()
	{
		yield return new WaitForSeconds(3f);
		this.CJEJCGOCFJF = false;
		yield break;
	}

	// Token: 0x06002333 RID: 9011 RVA: 0x000FE398 File Offset: 0x000FC598
	public void RestartStory0()
	{
		FPEHHFKFBJK fpehhfkfbjk = null;
		try
		{
			fpehhfkfbjk = this.focusItem.GetComponent<FocusItem>().chapterSnapshotsItem.GetLastChapterSnapshotRestoreDesc();
		}
		catch (Exception aklgbjkdomm)
		{
			fpehhfkfbjk = null;
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
		if (fpehhfkfbjk != null && LanguageManager.EHBBFMCILPC.GetSelectedLanguage() != CEIBHCNNIDC.en && LanguageManager.EHBBFMCILPC.GetSelectedLanguage() != CEIBHCNNIDC.ru)
		{
			try
			{
				AssetStoryHeader assetStoryHeader = null;
				if (null != this.HFFIIBBJBMH)
				{
					assetStoryHeader = GKJPOGNFKNK.CDCEFHLNNEC(this.HFFIIBBJBMH.header.availableStories[fpehhfkfbjk.MIBPOIDDBAD]);
				}
				if (assetStoryHeader != null && !this.CILHBPNJDFA(assetStoryHeader, fpehhfkfbjk.FEJANNNLLON, -1, LanguageManager.EHBBFMCILPC.GetSelectedLanguage()))
				{
					this.OnPlaySoonClick();
					return;
				}
			}
			catch (Exception aklgbjkdomm2)
			{
				DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm2);
			}
		}
		this.HideStoryRestartPopup();
		if (null != this.HFFIIBBJBMH)
		{
			int num = AKLFPGMDKLA.EHBBFMCILPC.LMGMHHLLOFN(this.HFFIIBBJBMH.header.index).EGHHCFFLPCP(-1);
			for (int i = 0; i <= num; i++)
			{
				if (i < this.HFFIIBBJBMH.header.availableStories.Count && AKLFPGMDKLA.EHBBFMCILPC.LAEKDOCIMBK(this.HFFIIBBJBMH.header.availableStories[i]))
				{
					AKLFPGMDKLA.EHBBFMCILPC.JDCBFAPDJIM(this.HFFIIBBJBMH.header.availableStories[i], -1).EPJKDCDOEMM(true);
				}
			}
			AKLFPGMDKLA.EHBBFMCILPC.LMGMHHLLOFN(this.HFFIIBBJBMH.header.index).LDPCILACGCO(0, -1);
		}
		AKLFPGMDKLA.EHBBFMCILPC.BJECGAMNDDH();
		this.EFPDMJBADBB(this.LGKGGPDKAHF);
		this.OnPlayClickStart();
	}

	// Token: 0x06002334 RID: 9012 RVA: 0x000FE550 File Offset: 0x000FC750
	private void EFHDFDHBKLM()
	{
		SceneStoryAssetPackManager[] array = UnityEngine.Object.FindObjectsOfType(typeof(SceneStoryAssetPackManager)) as SceneStoryAssetPackManager[];
		int num = 0;
		for (int i = 0; i < array.Length; i++)
		{
			for (int j = 0; j < array[i].environmentsBackList.Count; j++)
			{
				if (null != array[i].environmentsBackList[j])
				{
					array[i].environmentsBackList[j].transform.SetParent(null, false);
					this.KGOCEEAGLKO.Add(array[i].environmentsBackList[j]);
				}
			}
			for (int k = 0; k < array[i].environmentsFrontList.Count; k++)
			{
				if (null != array[i].environmentsFrontList[k])
				{
					array[i].environmentsFrontList[k].transform.SetParent(null, false);
					this.OEDPPJGKPFO.Add(array[i].environmentsFrontList[k]);
				}
			}
			for (int l = 0; l < array[i].storyNpcAssets.Count; l++)
			{
				if (null != array[i].storyNpcAssets[l] && !AssetsManager.EHBBFMCILPC.lobbyLoungeNpcAssets.Contains(array[i].storyNpcAssets[l]))
				{
					AssetsManager.EHBBFMCILPC.lobbyLoungeNpcAssets.Add(array[i].storyNpcAssets[l]);
					num++;
				}
			}
			UnityEngine.Object.Destroy(array[i].gameObject);
		}
	}

	// Token: 0x06002335 RID: 9013 RVA: 0x000FE6D4 File Offset: 0x000FC8D4
	private void EEGDFPJGECN()
	{
		if (!this.KDLBELFIIDL)
		{
			return;
		}
		this.KDLBELFIIDL = false;
		this.EOOJGEFLJEN.Clear();
		this.MHAMPPBECNM = false;
		SceneLoungeManager.SetPendingLoungeCharacter(null);
		SceneLoungeManager.SetPendingLoungeLook(null);
		CommonUserInterface.EHBBFMCILPC.HideConnectingAnimation();
		CommonUserInterface.EHBBFMCILPC.ShowGenericPopup(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("errortitle"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("app42error"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("ok"), DFGILFBGPLN.popupBackendError, 0f, 28);
	}

	// Token: 0x06002336 RID: 9014 RVA: 0x000FE75C File Offset: 0x000FC95C
	private void DBHOJGKJPND()
	{
		this.OBPPPNCALNP++;
		if (this.OBPPPNCALNP >= KBOJLHAJPCP.LPJOFEDNKHA)
		{
			this.OBPPPNCALNP = 0;
			FirebaseAnalyticsManager.EHBBFMCILPC.LogEvent(false, AGEHCPDNBFD.cdnActiv.ToString(), FFPHBMFGCNN.dldFail.ToString(), BGHLMGPPCNN.cdnLbyToSpl.ToString(), false, false);
			CommonUserInterface.EHBBFMCILPC.HideConnectingAnimation();
			CommonUserInterface.EHBBFMCILPC.ShowGenericPopupTwoOverride(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("errortitle"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("cdnerror"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("retry"), new UnityAction(this.JLFKKFCFJIC), new UnityAction(this.MMLFBNPEOPP), DFGILFBGPLN.popupCdnDownloadFailed, 0f, 28);
			this.GBBHKFFENBE = false;
			return;
		}
		base.StartCoroutine(this.JPEPPPHJIBN());
	}

	// Token: 0x06002337 RID: 9015 RVA: 0x000FE844 File Offset: 0x000FCA44
	public void OnFavoritesActivate()
	{
		JBBNEEHANHL jbbneehanhl = JBBNEEHANHL.filterFavorites;
		FilterItem[] componentsInChildren = this.scrollView2Controller.GetComponentsInChildren<FilterItem>(true);
		if (Array.Exists<FilterItem>(componentsInChildren, new Predicate<FilterItem>(SceneLobbyManager2.<>c.<>9.OBGKGBGMPLB)))
		{
			foreach (FilterItem filterItem in componentsInChildren)
			{
				if (filterItem.id == jbbneehanhl)
				{
					filterItem.gameObject.SetActive(true);
					foreach (GridController gridController in this.scrollView0Controller.GetComponentsInChildren<GridController>(true))
					{
						if (gridController.filter == jbbneehanhl && !SceneLobbyManager2.IsGroupedFilter(jbbneehanhl))
						{
							if (gridController.transform.childCount == 0)
							{
								filterItem.toggle.isOn = true;
							}
							if (!gridController.gameObject.activeSelf)
							{
								gridController.gameObject.SetActive(true);
								Canvas.ForceUpdateCanvases();
								this.LHGBCPLGLDB(this.focusItem.GetComponent<FocusItem>().currentAnthologyIndex, gridController.gameObject, jbbneehanhl);
								foreach (object obj in gridController.transform)
								{
									Transform transform = (Transform)obj;
									if (this.focusItem.GetComponent<FocusItem>().currentAnthologyIndex == transform.GetComponent<ThumbnailItem>().index)
									{
										transform.SetAsFirstSibling();
									}
								}
								if (!filterItem.toggle.isOn)
								{
									gridController.gameObject.SetActive(false);
								}
							}
							else
							{
								this.LHGBCPLGLDB(this.focusItem.GetComponent<FocusItem>().currentAnthologyIndex, gridController.gameObject, jbbneehanhl);
								foreach (object obj2 in gridController.transform)
								{
									Transform transform2 = (Transform)obj2;
									if (this.focusItem.GetComponent<FocusItem>().currentAnthologyIndex == transform2.GetComponent<ThumbnailItem>().index)
									{
										transform2.SetAsFirstSibling();
									}
								}
							}
						}
					}
					this.LGKCHPBIIGA(true);
				}
			}
			return;
		}
		GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(this.filterItemPrefab, this.filterItemsParent);
		this.EKIFLHLCLKG.Add(gameObject);
		gameObject.GetComponent<Toggle>().group = this.toogleGroupOnFilterItemsParent;
		gameObject.GetComponent<FilterItem>().SetContent(jbbneehanhl, new UnityAction<JBBNEEHANHL>(this.PPPMPCJNKNB), this.scrollView2Controller);
		gameObject.transform.SetAsFirstSibling();
		gameObject.GetComponent<Toggle>().isOn = true;
	}

	// Token: 0x06002338 RID: 9016 RVA: 0x000FEAF8 File Offset: 0x000FCCF8
	public void UpdateAnthologiesPropertiesV2(bool IJLGHINKEFK = false, bool AKJFNEBCINP = false)
	{
		if (!AKJFNEBCINP)
		{
			SceneLobbyManager2.anthologyPropertiesInitializationCounter++;
			this.GKEGDHDJFAF = -1;
		}
		this.KHOELODHGGF = new int[76];
		this.HNLPNMJIBIK = new int[76];
		this.JDFKLJAIHLH = new int[76];
		for (int i = 0; i < this.KHOELODHGGF.Length; i++)
		{
			this.JDFKLJAIHLH[i] = (this.HNLPNMJIBIK[i] = 0);
			this.KHOELODHGGF[i] = -1;
		}
		try
		{
			for (int j = 0; j < AssetsManager.EHBBFMCILPC.anthologyAssets.Count; j++)
			{
				this.JDFKLJAIHLH[AssetsManager.EHBBFMCILPC.anthologyAssets[j].header.index] = (this.HNLPNMJIBIK[AssetsManager.EHBBFMCILPC.anthologyAssets[j].header.index] = this.GetAnthologyProgressPercent(AssetsManager.EHBBFMCILPC.anthologyAssets[j].header.index));
			}
			List<int> list = new List<int>();
			this.UpdateAnthologiesHints();
			int num = 0;
			if (IJLGHINKEFK)
			{
				List<int> list2 = AKLFPGMDKLA.EHBBFMCILPC.IIJKEKGIAKN(this.DNFBBDFPFJJ);
				for (int k = 0; k < list2.Count; k++)
				{
					if (this.KHOELODHGGF[list2[k]] < 0)
					{
						for (int l = 0; l < AssetsManager.EHBBFMCILPC.anthologyAssets.Count; l++)
						{
							if (AssetsManager.EHBBFMCILPC.anthologyAssets[l].header.index == list2[k])
							{
								this.KHOELODHGGF[list2[k]] = num;
								if (this.CIFKLOHBHJB[list2[k]] == NDHKFLHAFNA.hintCompleted)
								{
									this.CIFKLOHBHJB[list2[k]] = NDHKFLHAFNA.hintPlayAgain;
								}
								else if (this.CIFKLOHBHJB[list2[k]] == NDHKFLHAFNA.hintContinuePlaying)
								{
									this.CIFKLOHBHJB[list2[k]] = NDHKFLHAFNA.hintTryAgain;
								}
								else if (this.CIFKLOHBHJB[list2[k]] != NDHKFLHAFNA.hintInDevelopment && this.CIFKLOHBHJB[list2[k]] != NDHKFLHAFNA.hintOnHiatus && this.CIFKLOHBHJB[list2[k]] != NDHKFLHAFNA.hintDiscontinued)
								{
									this.CIFKLOHBHJB[list2[k]] = NDHKFLHAFNA.hintSuggested;
								}
								num++;
								break;
							}
						}
					}
				}
			}
			else
			{
				this.DNFBBDFPFJJ = -1;
				if (AKJFNEBCINP)
				{
					if (this.GKEGDHDJFAF >= 0 && this.KHOELODHGGF[this.GKEGDHDJFAF] < 0)
					{
						this.KHOELODHGGF[this.GKEGDHDJFAF] = num;
						num++;
						if (HKLPEDKJGFC.FACIFBONANM())
						{
							list.AddRange(HKLPEDKJGFC.CCANONHEJMP(this.GKEGDHDJFAF));
						}
					}
				}
				else if (!this.MBACGFKOKJD && !SceneLobbyManager2.returnedFromStory && AKLFPGMDKLA.EHBBFMCILPC.HCEHBFCIIHN() >= KBOJLHAJPCP.FMIKGCDCKCC)
				{
					int m = 0;
					while (m < AssetsManager.EHBBFMCILPC.anthologyAssets.Count)
					{
						IJLJDFKJIJM ijljdfkjijm = HKLPEDKJGFC.BBEPEBHNNGE(AssetsManager.EHBBFMCILPC.anthologyAssets[m].header.index);
						if (this.CIFKLOHBHJB[AssetsManager.EHBBFMCILPC.anthologyAssets[m].header.index] == NDHKFLHAFNA.hintNewStory && this.KHOELODHGGF[AssetsManager.EHBBFMCILPC.anthologyAssets[m].header.index] < 0 && AKLFPGMDKLA.EHBBFMCILPC.PFLAJHMJFCG(AssetsManager.EHBBFMCILPC.anthologyAssets[m].header) && ijljdfkjijm != null && AKLFPGMDKLA.EHBBFMCILPC.MPLENGHOJAC(AssetsManager.EHBBFMCILPC.anthologyAssets[m].header.index, ijljdfkjijm))
						{
							this.KHOELODHGGF[AssetsManager.EHBBFMCILPC.anthologyAssets[m].header.index] = num;
							num++;
							AKLFPGMDKLA.EHBBFMCILPC.LIIPLPNDFKA(AssetsManager.EHBBFMCILPC.anthologyAssets[m].header.index);
							this.GKEGDHDJFAF = AssetsManager.EHBBFMCILPC.anthologyAssets[m].header.index;
							if (HKLPEDKJGFC.FACIFBONANM())
							{
								list.AddRange(HKLPEDKJGFC.CCANONHEJMP(AssetsManager.EHBBFMCILPC.anthologyAssets[m].header.index));
								break;
							}
							break;
						}
						else
						{
							m++;
						}
					}
				}
				SceneLobbyManager2.returnedFromStory = false;
				try
				{
					if (AKLFPGMDKLA.EHBBFMCILPC.GLKNOFHEBKN >= 0)
					{
						AssetAnthology assetAnthology = GKJPOGNFKNK.MLDENPHFNPH(AKLFPGMDKLA.EHBBFMCILPC.GLKNOFHEBKN, false);
						if (null != assetAnthology && this.KHOELODHGGF[assetAnthology.header.index] < 0)
						{
							this.KHOELODHGGF[assetAnthology.header.index] = num;
							num++;
						}
					}
				}
				catch (Exception ex)
				{
					DPGJIJGOCIC.ANOPFDLPKGC("SceneLobbyManager.UpdateAnthologiesHints() - exception when adding anthology based on Account.Instance.activeStoryLobby:" + ex.ToString());
				}
				try
				{
					for (int n = 0; n < AKLFPGMDKLA.EHBBFMCILPC.DGBOBDAFHGC.Count; n++)
					{
						AssetAnthology assetAnthology2 = GKJPOGNFKNK.MLDENPHFNPH(AKLFPGMDKLA.EHBBFMCILPC.DGBOBDAFHGC[n], false);
						if (null != assetAnthology2 && this.KHOELODHGGF[assetAnthology2.header.index] < 0 && this.HNLPNMJIBIK[assetAnthology2.header.index] < 100)
						{
							this.KHOELODHGGF[assetAnthology2.header.index] = num;
							num++;
						}
					}
				}
				catch (Exception ex2)
				{
					DPGJIJGOCIC.ANOPFDLPKGC("SceneLobbyManager.UpdateAnthologiesHints() - exception when adding anthology based on (add last 3 played anthologies):" + ex2.ToString());
				}
				int num2 = 6 - num;
				if (num2 < 2)
				{
					num2 = 2;
				}
				List<int> list3 = AKLFPGMDKLA.EHBBFMCILPC.PFDFLFPPKJN();
				for (int num3 = 0; num3 < list3.Count; num3++)
				{
					foreach (AssetAnthology assetAnthology3 in AssetsManager.EHBBFMCILPC.anthologyAssets)
					{
						if (list3[num3] == assetAnthology3.header.index && !list.Contains(list3[num3]) && this.KHOELODHGGF[list3[num3]] < 0 && this.CIFKLOHBHJB[list3[num3]] != NDHKFLHAFNA.hintNewStory && this.CBBNGDBFDPO[list3[num3]] != NDHKFLHAFNA.hintNewStory)
						{
							if (this.CIFKLOHBHJB[list3[num3]] == NDHKFLHAFNA.hintCompleted)
							{
								this.CIFKLOHBHJB[list3[num3]] = NDHKFLHAFNA.hintPlayAgain;
							}
							else if (this.CIFKLOHBHJB[list3[num3]] == NDHKFLHAFNA.hintContinuePlaying)
							{
								this.CIFKLOHBHJB[list3[num3]] = NDHKFLHAFNA.hintTryAgain;
							}
							else if (this.CIFKLOHBHJB[list3[num3]] != NDHKFLHAFNA.hintInDevelopment && this.CIFKLOHBHJB[list3[num3]] != NDHKFLHAFNA.hintOnHiatus && this.CIFKLOHBHJB[list3[num3]] != NDHKFLHAFNA.hintDiscontinued)
							{
								this.CIFKLOHBHJB[list3[num3]] = NDHKFLHAFNA.hintSuggested;
							}
							this.KHOELODHGGF[list3[num3]] = num;
							num++;
							if (HKLPEDKJGFC.FACIFBONANM())
							{
								list.AddRange(HKLPEDKJGFC.CCANONHEJMP(list3[num3]));
							}
							num2--;
							if (num2 <= 0)
							{
								break;
							}
						}
					}
					if (num2 <= 0)
					{
						break;
					}
				}
				num2 = 6 - num;
				if (num2 < 2)
				{
					num2 = 2;
				}
				list3 = AKLFPGMDKLA.EHBBFMCILPC.IKHNDKEEECD();
				for (int num4 = 0; num4 < list3.Count; num4++)
				{
					foreach (AssetAnthology assetAnthology4 in AssetsManager.EHBBFMCILPC.anthologyAssets)
					{
						if (list3[num4] == assetAnthology4.header.index && !list.Contains(list3[num4]) && this.KHOELODHGGF[list3[num4]] < 0)
						{
							if (this.CIFKLOHBHJB[list3[num4]] == NDHKFLHAFNA.hintCompleted)
							{
								this.CIFKLOHBHJB[list3[num4]] = NDHKFLHAFNA.hintPlayAgain;
							}
							else if (this.CIFKLOHBHJB[list3[num4]] == NDHKFLHAFNA.hintContinuePlaying)
							{
								this.CIFKLOHBHJB[list3[num4]] = NDHKFLHAFNA.hintTryAgain;
							}
							else if (this.CIFKLOHBHJB[list3[num4]] != NDHKFLHAFNA.hintInDevelopment && this.CIFKLOHBHJB[list3[num4]] != NDHKFLHAFNA.hintOnHiatus && this.CIFKLOHBHJB[list3[num4]] != NDHKFLHAFNA.hintDiscontinued)
							{
								this.CIFKLOHBHJB[list3[num4]] = NDHKFLHAFNA.hintSuggested;
							}
							this.KHOELODHGGF[list3[num4]] = num;
							num++;
							if (HKLPEDKJGFC.FACIFBONANM())
							{
								list.AddRange(HKLPEDKJGFC.CCANONHEJMP(list3[num4]));
							}
							num2--;
							if (num2 <= 0)
							{
								break;
							}
						}
					}
					if (num2 <= 0)
					{
						break;
					}
				}
				num2 = 6 - num;
				if (num2 < 1)
				{
					num2 = 1;
				}
				list3 = AKLFPGMDKLA.EHBBFMCILPC.APEFDFEIFFJ();
				for (int num5 = 0; num5 < list3.Count; num5++)
				{
					foreach (AssetAnthology assetAnthology5 in AssetsManager.EHBBFMCILPC.anthologyAssets)
					{
						if (list3[num5] == assetAnthology5.header.index && !list.Contains(list3[num5]) && this.KHOELODHGGF[list3[num5]] < 0)
						{
							if (this.CIFKLOHBHJB[list3[num5]] == NDHKFLHAFNA.hintCompleted)
							{
								this.CIFKLOHBHJB[list3[num5]] = NDHKFLHAFNA.hintPlayAgain;
							}
							else if (this.CIFKLOHBHJB[list3[num5]] == NDHKFLHAFNA.hintContinuePlaying)
							{
								this.CIFKLOHBHJB[list3[num5]] = NDHKFLHAFNA.hintTryAgain;
							}
							else if (this.CIFKLOHBHJB[list3[num5]] != NDHKFLHAFNA.hintInDevelopment && this.CIFKLOHBHJB[list3[num5]] != NDHKFLHAFNA.hintOnHiatus && this.CIFKLOHBHJB[list3[num5]] != NDHKFLHAFNA.hintDiscontinued)
							{
								this.CIFKLOHBHJB[list3[num5]] = NDHKFLHAFNA.hintSuggested;
							}
							this.KHOELODHGGF[list3[num5]] = num;
							num++;
							if (HKLPEDKJGFC.FACIFBONANM())
							{
								list.AddRange(HKLPEDKJGFC.CCANONHEJMP(list3[num5]));
							}
							num2--;
							if (num2 <= 0)
							{
								break;
							}
						}
					}
					if (num2 <= 0)
					{
						break;
					}
				}
				try
				{
					if (num < 3)
					{
						for (int num6 = 0; num6 < 3; num6++)
						{
							for (int num7 = 0; num7 < AssetsManager.EHBBFMCILPC.anthologyAssets.Count; num7++)
							{
								IJLJDFKJIJM ijljdfkjijm2 = HKLPEDKJGFC.BBEPEBHNNGE(AssetsManager.EHBBFMCILPC.anthologyAssets[num7].header.index);
								if (ijljdfkjijm2 != null && ijljdfkjijm2.FAGCAMPMDCL == num6 && this.KHOELODHGGF[AssetsManager.EHBBFMCILPC.anthologyAssets[num7].header.index] < 0)
								{
									if (this.CIFKLOHBHJB[AssetsManager.EHBBFMCILPC.anthologyAssets[num7].header.index] == NDHKFLHAFNA.hintCompleted)
									{
										this.CIFKLOHBHJB[AssetsManager.EHBBFMCILPC.anthologyAssets[num7].header.index] = NDHKFLHAFNA.hintPlayAgain;
									}
									else if (this.CIFKLOHBHJB[AssetsManager.EHBBFMCILPC.anthologyAssets[num7].header.index] == NDHKFLHAFNA.hintContinuePlaying || this.CIFKLOHBHJB[AssetsManager.EHBBFMCILPC.anthologyAssets[num7].header.index] == NDHKFLHAFNA.hintInDevelopment)
									{
										this.CIFKLOHBHJB[AssetsManager.EHBBFMCILPC.anthologyAssets[num7].header.index] = NDHKFLHAFNA.hintTryAgain;
									}
									else if (this.CIFKLOHBHJB[AssetsManager.EHBBFMCILPC.anthologyAssets[num7].header.index] != NDHKFLHAFNA.hintInDevelopment && this.CIFKLOHBHJB[AssetsManager.EHBBFMCILPC.anthologyAssets[num7].header.index] != NDHKFLHAFNA.hintOnHiatus && this.CIFKLOHBHJB[AssetsManager.EHBBFMCILPC.anthologyAssets[num7].header.index] != NDHKFLHAFNA.hintDiscontinued)
									{
										this.CIFKLOHBHJB[AssetsManager.EHBBFMCILPC.anthologyAssets[num7].header.index] = NDHKFLHAFNA.hintSuggested;
									}
									this.KHOELODHGGF[AssetsManager.EHBBFMCILPC.anthologyAssets[num7].header.index] = num;
									num++;
									break;
								}
							}
						}
					}
					for (int num8 = 0; num8 < this.KHOELODHGGF.Length; num8++)
					{
						if (this.KHOELODHGGF[num8] == 0)
						{
							this.DNFBBDFPFJJ = num8;
							break;
						}
					}
				}
				catch (Exception ex3)
				{
					DPGJIJGOCIC.ANOPFDLPKGC("SceneLobbyManager.UpdateAnthologiesHints() - exception" + ex3.ToString());
				}
			}
		}
		catch (Exception ex4)
		{
			DPGJIJGOCIC.ANOPFDLPKGC("SceneLobbyManager.UpdateAnthologiesHints() - exception" + ex4.ToString());
		}
	}

	// Token: 0x06002339 RID: 9017 RVA: 0x000FF88C File Offset: 0x000FDA8C
	public void NAEGBCBAEGB()
	{
		if (KDCJJBLGCBH.EHBBFMCILPC.DJHCAFAEILH())
		{
			this.profileButtonAvailable.gameObject.SetActive(true);
			this.profileButtonHidden.gameObject.SetActive(true);
			return;
		}
		this.profileButtonHidden.gameObject.SetActive(true);
		if (!AKLFPGMDKLA.EHBBFMCILPC.GNLNPMPJPEC())
		{
			this.profileButtonAvailable.gameObject.SetActive(false);
			this.profileButtonOffline.gameObject.SetActive(false);
			return;
		}
		this.profileButtonAvailable.gameObject.SetActive(true);
		this.profileButtonOffline.gameObject.SetActive(true);
	}

	// Token: 0x0600233A RID: 9018 RVA: 0x000F57C0 File Offset: 0x000F39C0
	public void RestartStory2()
	{
		this.RestartStoryX(2);
	}

	// Token: 0x0600233B RID: 9019 RVA: 0x000FF92C File Offset: 0x000FDB2C
	private void HAJDMFMINFE()
	{
		CommonUserInterface.EHBBFMCILPC.HideConnectingAnimation();
		CommonUserInterface.EHBBFMCILPC.ShowGenericPopupOneOverride(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("errortitle"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("app42error"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("retry"), new UnityAction(this.OnPublicProfileClick), DFGILFBGPLN.popupBackendError, 0f, 28);
		this.GBBHKFFENBE = false;
	}

	// Token: 0x0600233C RID: 9020 RVA: 0x000FF998 File Offset: 0x000FDB98
	private List<KLJCEMBNKNI> LIAHCBGCPEN()
	{
		List<KLJCEMBNKNI> list = new List<KLJCEMBNKNI>();
		try
		{
			List<int> list2 = new List<int>();
			List<int> list3 = new List<int>();
			for (int i = 0; i < this.BPCHEOFFPCN.Count; i++)
			{
				int num = this.BPCHEOFFPCN[i];
				if (!(null == GKJPOGNFKNK.LDFIAOCJEOJ(num)))
				{
					if (this.EEGHJFAIMBF.Contains(num))
					{
						if (!list3.Contains(num))
						{
							list3.Add(num);
						}
					}
					else if (!list2.Contains(num))
					{
						list2.Add(num);
					}
				}
			}
			if (list2.Count > 0)
			{
				list.Add(this.AGFJMDBMKBN("coverSearch", list2.Count, 0, 0, this.MJOMHIEMKMK, "searchpattern", JBBNEEHANHL.filterSearch, list2));
			}
			if (list3.Count > 0)
			{
				string lbihodeideg = "coverSearchMore";
				if (list2.Count == 0)
				{
					lbihodeideg = "coverSearchNone";
				}
				list.Add(this.AGFJMDBMKBN(lbihodeideg, list3.Count, 0, 0, this.MJOMHIEMKMK, "searchpattern", JBBNEEHANHL.filterSearch, list3));
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
		return list;
	}

	// Token: 0x0600233D RID: 9021 RVA: 0x000FFAAC File Offset: 0x000FDCAC
	private void ICLFENDADFN()
	{
		if (!this.KDLBELFIIDL)
		{
			return;
		}
		if (this.EOOJGEFLJEN.Count > 0)
		{
			base.Invoke("CJHCAPFJDJM", 0.25f);
			return;
		}
		this.KDLBELFIIDL = false;
		base.StartCoroutine(this.OLMEEDAFNAE());
	}

	// Token: 0x0600233E RID: 9022 RVA: 0x000FFAEC File Offset: 0x000FDCEC
	private void LMNLGFEIHGO()
	{
		this.FIBKHPMLNJN = null;
		this.KOGLEPFNALN = false;
		this.MJOMHIEMKMK = "";
		this.BPCHEOFFPCN.Clear();
		this.EEGHJFAIMBF.Clear();
		this.IIDEKJNAFKG.Clear();
		this.NODBJCOJNLJ.Clear();
		if (this.EGNDHGMJJJL != null)
		{
			base.StopCoroutine(this.EGNDHGMJJJL);
			this.EGNDHGMJJJL = null;
		}
	}

	// Token: 0x0600233F RID: 9023 RVA: 0x000FB749 File Offset: 0x000F9949
	private void BCHKELGGGAB()
	{
		base.StartCoroutine(this.GLBNDFFMKFB());
	}

	// Token: 0x06002340 RID: 9024 RVA: 0x000FFB5C File Offset: 0x000FDD5C
	private static string LCBGEAPPODB(List<int> HJDGJIPAEKM)
	{
		string text = "";
		for (int i = 0; i < HJDGJIPAEKM.Count; i++)
		{
			if (i > 0)
			{
				text += ",";
			}
			text += HJDGJIPAEKM[i].ToString();
		}
		return text;
	}

	// Token: 0x06002341 RID: 9025 RVA: 0x000FFBA8 File Offset: 0x000FDDA8
	private void BDGEAAJKPLH()
	{
		this.KPDGEKGMAKO.Clear();
		try
		{
			List<int> list = AKLFPGMDKLA.EHBBFMCILPC.KMOJMMHEDEM();
			if (list != null)
			{
				for (int i = 0; i < list.Count; i++)
				{
					if (this.DHLOGNEMLGH(list[i]) && !this.KPDGEKGMAKO.Contains(list[i]))
					{
						this.KPDGEKGMAKO.Add(list[i]);
					}
				}
			}
			List<int> list2 = new List<int>();
			for (int j = 0; j < AssetsManager.EHBBFMCILPC.anthologyAssets.Count; j++)
			{
				if (!(null == AssetsManager.EHBBFMCILPC.anthologyAssets[j]))
				{
					int index = AssetsManager.EHBBFMCILPC.anthologyAssets[j].header.index;
					if (this.DHLOGNEMLGH(index) && !this.KPDGEKGMAKO.Contains(index) && !list2.Contains(index))
					{
						int index2 = list2.Count;
						for (int k = 0; k < list2.Count; k++)
						{
							if (index > list2[k])
							{
								index2 = k;
								break;
							}
						}
						list2.Insert(index2, index);
					}
				}
			}
			this.KPDGEKGMAKO.AddRange(list2);
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x06002342 RID: 9026 RVA: 0x000FFCFC File Offset: 0x000FDEFC
	private void EPDHPBPMLLO()
	{
		for (int i = 0; i < this.cameras.Count; i++)
		{
			this.cameras[i].enabled = true;
		}
	}

	// Token: 0x06002343 RID: 9027 RVA: 0x000F6BF5 File Offset: 0x000F4DF5
	private void COIJDOCAABP()
	{
		this.MBGPADGCJBM = false;
	}

	// Token: 0x06002344 RID: 9028 RVA: 0x000FFD34 File Offset: 0x000FDF34
	private int AIPCPDAAMJN()
	{
		int num = 0;
		for (int i = 0; i < this.MGNNOFPKGJF.Count; i++)
		{
			if (null != this.MGNNOFPKGJF[i] && JBBNEEHANHL.filterSearch == this.MGNNOFPKGJF[i].GetComponent<GridController>().filter)
			{
				num += this.MGNNOFPKGJF[i].GetComponentsInChildren<ThumbnailItem>(true).Length;
			}
		}
		return num;
	}

	// Token: 0x06002345 RID: 9029 RVA: 0x000FFDA0 File Offset: 0x000FDFA0
	private void CIBKGEHJKCC()
	{
		AKLFPGMDKLA.EHBBFMCILPC.HKOBEKCGGEI(JAMPPNPOJJG.lite);
		FirebaseAnalyticsManager.EHBBFMCILPC.LogEvent(true, AGEHCPDNBFD.gmSelect.ToString(), FFPHBMFGCNN.gmLite.ToString(), BGHLMGPPCNN.gmLocSett.ToString(), false, false);
		this.DNGHLBFEODC();
	}

	// Token: 0x06002346 RID: 9030 RVA: 0x000FFDFC File Offset: 0x000FDFFC
	public void ShowCardOptionsOrDownload()
	{
		int num = KDCJJBLGCBH.EHBBFMCILPC.OFKOCAGJLMP();
		bool flag;
		if (num > 0)
		{
			flag = !LJNMIPMNOKF.EHBBFMCILPC.IHOIGNLKNDA();
		}
		else
		{
			flag = !GKJPOGNFKNK.CEHOHNOKLIK(LJNMIPMNOKF.EHBBFMCILPC.AOOPMDIBAFP());
		}
		if (!flag)
		{
			if (this.FGDEGMOLIDB)
			{
				this.FGDEGMOLIDB = false;
				CommonUserInterface.EHBBFMCILPC.HideGenericPopupNoButtons();
				this.CMDIKMNEGEN();
			}
			CommonUserInterface.EHBBFMCILPC.HideConnectingAnimation();
			LobbyUserInterface.EHBBFMCILPC.ShowPopupCardOptions(LJNMIPMNOKF.EHBBFMCILPC.EBBLJMHNDKK(), null, HKPBEDBPHNJ.purchaseCardLobby, "", this.OGHHLFOEJKO);
			this.GBBHKFFENBE = false;
			if (this.EJECJLAAHLE && AKLFPGMDKLA.EHBBFMCILPC.KGHMOKADNKK.Count > this.LEFNOKMNHIA && this.LEFNOKMNHIA >= 0)
			{
				int num2 = this.OGHHLFOEJKO.OLNJMJMNBCN() + 1;
				string text = CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("cardvolsalethankings");
				text = text.Replace("XXX", num2.ToString() ?? "");
				CommonUserInterface.EHBBFMCILPC.ShowGenericPopup(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("onboardingthankyoutitle"), text, CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("ok"), DFGILFBGPLN.popupSeasonComplete, 0.5f, 28);
			}
			this.EJECJLAAHLE = false;
			this.LEFNOKMNHIA = AKLFPGMDKLA.EHBBFMCILPC.KGHMOKADNKK.Count;
			return;
		}
		if (num > 0)
		{
			base.StartCoroutine(this.HCAHEOPANBC(num));
			return;
		}
		base.StartCoroutine(this.NBKMFHDIBPK());
	}

	// Token: 0x06002347 RID: 9031 RVA: 0x000FFF68 File Offset: 0x000FE168
	private void ODFHPOEACJH()
	{
		SceneLobbyManager2.startChapterManInTheMiddleAttack = 1;
		CommonUserInterface.EHBBFMCILPC.HideConnectingAnimation();
		CommonUserInterface.EHBBFMCILPC.ShowGenericPopupTwoOverride(CCOJBMMKNAP.MLFAGAAJJEM().OHLNGCKIACD("F0"), CCOJBMMKNAP.ILACPHFEDEP().JLBEIFLLBLO("importanttitle") + "sto" + AKLFPGMDKLA.EHBBFMCILPC.EEHGLPEIIHD + " ", CCOJBMMKNAP.LMCCLMFGEBD().HHLECNIFHCO(""), new UnityAction(this.JDFKJADDMAN), new UnityAction(this.JDFKJADDMAN), (DFGILFBGPLN)(-55), 297f, -78);
	}

	// Token: 0x06002348 RID: 9032 RVA: 0x000FFFF7 File Offset: 0x000FE1F7
	private IEnumerator LDALFHBEDFC()
	{
		float num = 0f;
		try
		{
			if (null != this.logoBackgroundMask)
			{
				AnimationTranslation component = this.logoBackgroundMask.GetComponent<AnimationTranslation>();
				if (null != component)
				{
					num = component.delayAtStart + component.animationTime;
				}
			}
			if (LoadingEnvironmentManager.IsAlive())
			{
				num = Mathf.Max(num, 1.55f);
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
		yield return new WaitForSecondsRealtime(num + 0.5f);
		this.MPEKBFHNOOK = null;
		if (null != this.lobbySearchBar && this.lobbySearchBar.gameObject.activeInHierarchy)
		{
			this.lobbySearchBar.PulseIcon();
		}
		yield break;
	}

	// Token: 0x06002349 RID: 9033 RVA: 0x00100006 File Offset: 0x000FE206
	private static int GINEIIANOAE(SceneLobbyManager2.BBNDCCPKNJL MIDLEBAGDMN, SceneLobbyManager2.BBNDCCPKNJL DFNFPEMFNPN)
	{
		return DFNFPEMFNPN.AGMOECJFFJI.CompareTo(MIDLEBAGDMN.AGMOECJFFJI);
	}

	// Token: 0x0600234A RID: 9034 RVA: 0x0010001C File Offset: 0x000FE21C
	private HAKFHALKMBH FFBHJJIIDIK(JBBNEEHANHL HBBJBNJBMPK)
	{
		for (int i = this.AAHJNGODNKI.Count - 1; i >= 0; i--)
		{
			if (this.AAHJNGODNKI[i] != null && this.AAHJNGODNKI[i].GLOCCAIDHJC == HBBJBNJBMPK)
			{
				if (!(null == this.AAHJNGODNKI[i].NHOAHJMPCFC))
				{
					return this.AAHJNGODNKI[i];
				}
				this.AAHJNGODNKI.RemoveAt(i);
			}
		}
		return null;
	}

	// Token: 0x0600234B RID: 9035 RVA: 0x00100098 File Offset: 0x000FE298
	public void RestartStoryX(int OAJPPEFDPMB)
	{
		FPEHHFKFBJK fpehhfkfbjk = null;
		try
		{
			fpehhfkfbjk = this.focusItem.GetComponent<FocusItem>().chapterSnapshotsItem.GetLastChapterSnapshotRestoreDesc();
		}
		catch (Exception aklgbjkdomm)
		{
			fpehhfkfbjk = null;
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
		if (fpehhfkfbjk != null && LanguageManager.EHBBFMCILPC.GetSelectedLanguage() != CEIBHCNNIDC.en && LanguageManager.EHBBFMCILPC.GetSelectedLanguage() != CEIBHCNNIDC.ru)
		{
			try
			{
				AssetStoryHeader assetStoryHeader = null;
				if (null != this.HFFIIBBJBMH)
				{
					assetStoryHeader = GKJPOGNFKNK.CDCEFHLNNEC(this.HFFIIBBJBMH.header.availableStories[fpehhfkfbjk.MIBPOIDDBAD]);
				}
				if (assetStoryHeader != null && !this.CILHBPNJDFA(assetStoryHeader, fpehhfkfbjk.FEJANNNLLON, -1, LanguageManager.EHBBFMCILPC.GetSelectedLanguage()))
				{
					this.OnPlaySoonClick();
					return;
				}
			}
			catch (Exception aklgbjkdomm2)
			{
				DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm2);
			}
		}
		this.HideStoryRestartPopup();
		if (null != this.HFFIIBBJBMH)
		{
			int num = AKLFPGMDKLA.EHBBFMCILPC.LMGMHHLLOFN(this.HFFIIBBJBMH.header.index).EGHHCFFLPCP(-1);
			for (int i = OAJPPEFDPMB; i <= num; i++)
			{
				if (i < this.HFFIIBBJBMH.header.availableStories.Count && AKLFPGMDKLA.EHBBFMCILPC.LAEKDOCIMBK(this.HFFIIBBJBMH.header.availableStories[i]))
				{
					AKLFPGMDKLA.EHBBFMCILPC.JDCBFAPDJIM(this.HFFIIBBJBMH.header.availableStories[i], -1).EPJKDCDOEMM(true);
				}
			}
			AKLFPGMDKLA.EHBBFMCILPC.LMGMHHLLOFN(this.HFFIIBBJBMH.header.index).LDPCILACGCO(OAJPPEFDPMB, -1);
		}
		AKLFPGMDKLA.EHBBFMCILPC.BJECGAMNDDH();
		this.EFPDMJBADBB(this.LGKGGPDKAHF);
		this.OnPlayClickStart();
	}

	// Token: 0x0600234C RID: 9036 RVA: 0x00100250 File Offset: 0x000FE450
	private void GMFFLAFLGHH()
	{
		LobbyTopMatchSelectorManager.InitializeInstance();
		if (LobbyTopMatchSelectorManager.InstanceInitialized())
		{
			LobbyTopMatchSelectorManager.LockThemeChange();
		}
		if (AKLFPGMDKLA.EHBBFMCILPC.CBOKIJMGNFH)
		{
			CommonUserInterface.EHBBFMCILPC.HideConnectingAnimation();
			this.GPBDCGNNEBI();
			return;
		}
		if (AKLFPGMDKLA.EHBBFMCILPC.MLLOENOIKGA)
		{
			CommonUserInterface.EHBBFMCILPC.HideConnectingAnimation();
			if (AKLFPGMDKLA.EHBBFMCILPC.BNGHKCHKMPB > 0)
			{
				string text = CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("accountsuspended4");
				text = text.Replace("XXX", AKLFPGMDKLA.EHBBFMCILPC.OMMACPBIHDN(AKLFPGMDKLA.EHBBFMCILPC.EEHGLPEIIHD));
				text = text.Replace("YYY", AKLFPGMDKLA.EHBBFMCILPC.GKJIAEHDBNM().ToString() ?? "");
				CommonUserInterface.EHBBFMCILPC.ShowGenericPopupTwoOverride(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("importanttitle"), text, CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("copyuidbtn"), new UnityAction(this.JDFKJADDMAN), new UnityAction(this.JDFKJADDMAN), DFGILFBGPLN.popupAccountSuspended, 0f, 28);
				return;
			}
			if (AKLFPGMDKLA.EHBBFMCILPC.NHBLMCJBLAC == 1)
			{
				string text2 = CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("accountsuspended5");
				text2 = text2.Replace("XXX", AKLFPGMDKLA.EHBBFMCILPC.OMMACPBIHDN(AKLFPGMDKLA.EHBBFMCILPC.EEHGLPEIIHD));
				CommonUserInterface.EHBBFMCILPC.ShowGenericPopupTwoOverride(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("importanttitle"), text2, CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("copyuidbtn"), new UnityAction(this.JDFKJADDMAN), new UnityAction(this.JDFKJADDMAN), DFGILFBGPLN.popupAccountSuspended, 0f, 28);
				return;
			}
			string text3 = CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("accountsuspended3");
			text3 = text3.Replace("XXX", AKLFPGMDKLA.EHBBFMCILPC.OMMACPBIHDN(AKLFPGMDKLA.EHBBFMCILPC.EEHGLPEIIHD));
			CommonUserInterface.EHBBFMCILPC.ShowGenericPopupTwoOverride(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("importanttitle"), text3, CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("copyuidbtn"), new UnityAction(this.JDFKJADDMAN), new UnityAction(this.JDFKJADDMAN), DFGILFBGPLN.popupAccountSuspended, 0f, 28);
			return;
		}
		else
		{
			if (AccountSignInManager.EHBBFMCILPC.GetSignInSource() == JCAPGCCNOMP.auto)
			{
				AKLFPGMDKLA.EHBBFMCILPC.JPDHGCINOJD();
				this.MNGIPAFFFEA();
				AOBJLALDBAA.EHBBFMCILPC.EGELHPJBAIC("onThemeChange", 0f);
				return;
			}
			AppManager.EHBBFMCILPC.RestartApp(true, false);
			return;
		}
	}

	// Token: 0x0600234D RID: 9037 RVA: 0x000FB758 File Offset: 0x000F9958
	private void HJMNCCNAFDB()
	{
		this.CHDBIMNLHBC = null;
		this.KCJIIEIBAPI = -1;
		this.DINHJIBBGJL = -1;
	}

	// Token: 0x0600234E RID: 9038 RVA: 0x0010049B File Offset: 0x000FE69B
	private void CMDIKMNEGEN()
	{
		this.DCFBAMCJCFK = 0;
		this.OBPPPNCALNP = 0;
		this.FJIAGECENLF = 0;
		this.LIDPKKFBNMC = 0;
		this.HGIKEMNOGOO = 0;
		this.NEEMPAAFHEI = 0;
		this.CDJGGOJBGJF = 0;
	}

	// Token: 0x0600234F RID: 9039 RVA: 0x001004D0 File Offset: 0x000FE6D0
	private void CCJNHFAIMKI()
	{
		if (AKLFPGMDKLA.EHBBFMCILPC.CBOKIJMGNFH)
		{
			CommonUserInterface.EHBBFMCILPC.MCJIGJMFBMI();
			this.GPBDCGNNEBI();
			return;
		}
		if (!AKLFPGMDKLA.EHBBFMCILPC.DHHNMAEABFI())
		{
			AssetsManager.EHBBFMCILPC.CleanupDownloadQueue();
			CommonUserInterface.IKNOFBFMPGA().HideConnectingAnimation();
			SceneOnboardingManager.startAtStep = 1;
			CommonUserInterface.IKNOFBFMPGA().GetFader().PACBMBLIGNN(new TweenCallback(this.MBINGGKGNGM));
			return;
		}
		if (null != AssetsManager.MJBDMHPHMID().profileDataAsset)
		{
			AssetsManager.EHBBFMCILPC.profileDataAsset.BAAKLNDKMDG();
		}
		if (AssetsManager.MJBDMHPHMID().OMPIABBPDKB() || SceneLobbyManager2.LIDGNAFABAH)
		{
			OKJHCOIKEJA.IJHHMHAEKKE();
			DPPMPNEOPNF.MAJAFJCMCJL();
			EELCJOKFHHC.MIJAEFDBJFJ();
			PBIBIOOCDKF.OLLHICPGHHM();
			FANFNBCJJDA.GCCADHCFBJH().IJHHMHAEKKE();
			AssetsManager.EHBBFMCILPC.DestroyAssetBundleAssets(NMKDCBPMCKI._deprecated1, -1);
			AssetsManager.EHBBFMCILPC.NJEPIEPCCOF((NMKDCBPMCKI)(-73), -1);
			AssetsManager.MJBDMHPHMID().FJNNMGFLBKA((NMKDCBPMCKI)79, -1);
			AssetsManager.MJBDMHPHMID().FJNNMGFLBKA((NMKDCBPMCKI)(-27), -1);
			AssetsManager.EHBBFMCILPC.DestroyAssetBundleAssets(NMKDCBPMCKI.AssetBundleTextPack, -1);
			AssetsManager.EHBBFMCILPC.DestroyAssetBundleAssets((NMKDCBPMCKI)59, -1);
			AssetsManager.MJBDMHPHMID().DestroyAssetBundleAssets(NMKDCBPMCKI._deprecated0, -1);
			AssetsManager.EHBBFMCILPC.FJNNMGFLBKA(NMKDCBPMCKI.AssetBundleStory, -1);
			AssetsManager.EHBBFMCILPC.NJEPIEPCCOF(NMKDCBPMCKI._deprecated1, -1);
			AssetsManager.MJBDMHPHMID().NJEPIEPCCOF((NMKDCBPMCKI)(-77), -1);
			AssetsManager.EHBBFMCILPC.FJNNMGFLBKA((NMKDCBPMCKI)(-19), -1);
			AssetsManager.EHBBFMCILPC.FJNNMGFLBKA((NMKDCBPMCKI)(-101), -1);
			AssetsManager.EHBBFMCILPC.NJEPIEPCCOF(NMKDCBPMCKI.AssetBundleLiveOfferContent, -1);
			AssetsManager.EHBBFMCILPC.NJEPIEPCCOF((NMKDCBPMCKI)(-12), -1);
			AssetsManager.MJBDMHPHMID().FJNNMGFLBKA(NMKDCBPMCKI.AssetBundleAnthologyLounge, -1);
			AssetsManager.EHBBFMCILPC.FJNNMGFLBKA((NMKDCBPMCKI)79, -1);
			AssetsManager.MJBDMHPHMID().DestroyAssetBundleAssets((NMKDCBPMCKI)(-97), -1);
			AssetsManager.MJBDMHPHMID().FJNNMGFLBKA((NMKDCBPMCKI)(-59), -1);
			AssetsManager.EHBBFMCILPC.FJNNMGFLBKA((NMKDCBPMCKI)(-88), -1);
			AssetsManager.MJBDMHPHMID().NJEPIEPCCOF((NMKDCBPMCKI)100, -1);
			AssetsManager.EHBBFMCILPC.DestroyAssetBundleAssets((NMKDCBPMCKI)106, -1);
			AssetsManager.EHBBFMCILPC.FJNNMGFLBKA(NMKDCBPMCKI.LowEndVersion, -1);
			AssetsManager.EHBBFMCILPC.DestroyAssetBundleAssets((NMKDCBPMCKI)97, -1);
			AssetsManager.EHBBFMCILPC.DestroyAssetBundleAssets((NMKDCBPMCKI)61, -1);
			AssetsManager.EHBBFMCILPC.DestroyAssetBundleAssets((NMKDCBPMCKI)115, -1);
			AssetsManager.MJBDMHPHMID().FJNNMGFLBKA(NMKDCBPMCKI.AssetBundleStory, -1);
			AssetsManager.EHBBFMCILPC.FJNNMGFLBKA(NMKDCBPMCKI.AssetBundleCollectableCard, -1);
			AssetsManager.MJBDMHPHMID().DestroyAssetBundleAssets((NMKDCBPMCKI)(-14), -1);
			AssetsManager.EHBBFMCILPC.DestroyAssetBundleAssets((NMKDCBPMCKI)116, -1);
			AssetsManager.EHBBFMCILPC.NJEPIEPCCOF(NMKDCBPMCKI.AssetBundleAvatarExtensionPack, -1);
			AssetsManager.EHBBFMCILPC.DestroyAssetBundleAssets((NMKDCBPMCKI)(-117), -1);
			AssetsManager.MJBDMHPHMID().NJEPIEPCCOF((NMKDCBPMCKI)80, -1);
			AssetsManager.MJBDMHPHMID().DestroyAssetBundleAssets((NMKDCBPMCKI)66, -1);
			AssetsManager.EHBBFMCILPC.DestroyAssetBundleAssets(NMKDCBPMCKI.AssetBundleStory, -1);
			AssetsManager.MJBDMHPHMID().NJEPIEPCCOF((NMKDCBPMCKI)121, -1);
			MLIBDDCCKBM.IJHHMHAEKKE();
			AssetsManager.MJBDMHPHMID().FJNNMGFLBKA((NMKDCBPMCKI)(-77), -1);
			AssetsManager.EHBBFMCILPC.FJNNMGFLBKA(NMKDCBPMCKI.AssetBundleIconsPack, -1);
			AssetsManager.EHBBFMCILPC.NJEPIEPCCOF((NMKDCBPMCKI)(-38), -1);
			AssetsManager.MJBDMHPHMID().DestroyAssetBundleAssets(NMKDCBPMCKI.AssetBundleStory, -1);
		}
		else
		{
			AssetsManager.MJBDMHPHMID().FJNNMGFLBKA((NMKDCBPMCKI)59, -1);
			AssetsManager.EHBBFMCILPC.NJEPIEPCCOF((NMKDCBPMCKI)79, -1);
			AssetsManager.EHBBFMCILPC.FJNNMGFLBKA((NMKDCBPMCKI)(-89), -1);
			AssetsManager.MJBDMHPHMID().DestroyAssetBundleAssets((NMKDCBPMCKI)(-98), -1);
			AssetsManager.MJBDMHPHMID().NJEPIEPCCOF(NMKDCBPMCKI.AssetBundleStoryAssetPack, -1);
			AssetsManager.EHBBFMCILPC.NJEPIEPCCOF((NMKDCBPMCKI)(-79), -1);
			AssetsManager.MJBDMHPHMID().NJEPIEPCCOF(NMKDCBPMCKI._deprecated0, -1);
			AssetsManager.EHBBFMCILPC.NJEPIEPCCOF(NMKDCBPMCKI.AssetBundleAvatarPack, -1);
			AssetsManager.MJBDMHPHMID().NJEPIEPCCOF(NMKDCBPMCKI.AssetBundleStorySplash, -1);
			AssetsManager.EHBBFMCILPC.DestroyAssetBundleAssets((NMKDCBPMCKI)110, -1);
			AssetsManager.MJBDMHPHMID().NJEPIEPCCOF(NMKDCBPMCKI.AssetBundleCutsceneView, -1);
			AssetsManager.EHBBFMCILPC.FJNNMGFLBKA((NMKDCBPMCKI)(-106), -1);
			AssetsManager.EHBBFMCILPC.FJNNMGFLBKA((NMKDCBPMCKI)(-28), -1);
			AssetsManager.MJBDMHPHMID().FJNNMGFLBKA((NMKDCBPMCKI)(-70), -1);
			AssetsManager.MJBDMHPHMID().DestroyAssetBundleAssets((NMKDCBPMCKI)82, -1);
			AssetsManager.EHBBFMCILPC.NJEPIEPCCOF(NMKDCBPMCKI.AssetBundleLobbyData, -1);
			AssetsManager.EHBBFMCILPC.FJNNMGFLBKA((NMKDCBPMCKI)123, -1);
			AssetsManager.MJBDMHPHMID().FJNNMGFLBKA((NMKDCBPMCKI)97, -1);
			AssetsManager.MJBDMHPHMID().FJNNMGFLBKA((NMKDCBPMCKI)(-56), -1);
			AssetsManager.MJBDMHPHMID().FJNNMGFLBKA((NMKDCBPMCKI)(-23), -1);
			AssetsManager.MJBDMHPHMID().NJEPIEPCCOF((NMKDCBPMCKI)(-21), -1);
			AssetsManager.EHBBFMCILPC.NJEPIEPCCOF((NMKDCBPMCKI)(-84), -1);
			AssetsManager.MJBDMHPHMID().FJNNMGFLBKA((NMKDCBPMCKI)(-107), -1);
			AssetsManager.EHBBFMCILPC.DestroyAssetBundleAssets(NMKDCBPMCKI._deprecated2, -1);
			if (!KHPGPLAMAIN.BBHKHCBICGA())
			{
				AssetsManager.MJBDMHPHMID().NJEPIEPCCOF((NMKDCBPMCKI)62, -1);
				AssetsManager.MJBDMHPHMID().NJEPIEPCCOF((NMKDCBPMCKI)(-108), -1);
				AssetsManager.MJBDMHPHMID().DestroyAssetBundleAssets(NMKDCBPMCKI.Count, -1);
				AssetsManager.MJBDMHPHMID().NJEPIEPCCOF((NMKDCBPMCKI)(-56), -1);
				AssetsManager.MJBDMHPHMID().NJEPIEPCCOF((NMKDCBPMCKI)83, -1);
				AssetsManager.EHBBFMCILPC.NJEPIEPCCOF(NMKDCBPMCKI.AssetBundleHeadersPack, -1);
				AssetsManager.EHBBFMCILPC.NJEPIEPCCOF((NMKDCBPMCKI)77, -1);
				AssetsManager.EHBBFMCILPC.FJNNMGFLBKA((NMKDCBPMCKI)102, -1);
			}
		}
		SceneLobbyManager2.LIDGNAFABAH = true;
		if (this.PGFANABDIBK && SceneLobbyManager2.startPlayChapterBackendOperationResult < 0)
		{
			AKLFPGMDKLA.EHBBFMCILPC.IEGJCPDCLMM = -1;
			this.PLJLNEAKFDK = EJDDNONEDNM.stayInLobby;
		}
		if (AKLFPGMDKLA.EHBBFMCILPC.MLLOENOIKGA)
		{
			CommonUserInterface.IKNOFBFMPGA().MCJIGJMFBMI();
			if (AKLFPGMDKLA.EHBBFMCILPC.BNGHKCHKMPB > 0)
			{
				string text = CCOJBMMKNAP.AEELGGPEJCC().HPOAGPJFHPM("OnCutsceneViewLeft");
				text = text.Replace("XXX", AKLFPGMDKLA.EHBBFMCILPC.PHMBDKKKKAO(AKLFPGMDKLA.EHBBFMCILPC.EEHGLPEIIHD));
				text = text.Replace("assetbundleitemanimationpack", AKLFPGMDKLA.EHBBFMCILPC.NDIDDOIPFON().ToString() ?? "black");
				CommonUserInterface.EHBBFMCILPC.CEGLPJNLBHL(CCOJBMMKNAP.MLFAGAAJJEM().OHLNGCKIACD(" folded='"), text, CCOJBMMKNAP.KNKGCDDMLDP().OGKGHLHHAAI(""), new UnityAction(this.JDFKJADDMAN), new UnityAction(this.JDFKJADDMAN), (DFGILFBGPLN)87, 853f, 0);
				return;
			}
			if (AKLFPGMDKLA.EHBBFMCILPC.NHBLMCJBLAC == 1)
			{
				string text2 = CCOJBMMKNAP.KMNBCEMEBBD().HHLECNIFHCO("0");
				text2 = text2.Replace("cid", AKLFPGMDKLA.EHBBFMCILPC.PHMBDKKKKAO(AKLFPGMDKLA.EHBBFMCILPC.EEHGLPEIIHD));
				CommonUserInterface.IKNOFBFMPGA().JJPNFAAPFBI(CCOJBMMKNAP.APGODIBBPOD().HIPJILDCHJC("NO BUNDLE"), text2, CCOJBMMKNAP.BBGECIKOICE().BGELFMIOBCL("max"), new UnityAction(this.JDFKJADDMAN), new UnityAction(this.JDFKJADDMAN), (DFGILFBGPLN)(-52), 1810f, -40);
				return;
			}
			string text3 = CCOJBMMKNAP.EAIAHCBAIEJ().OHLNGCKIACD("app42error");
			text3 = text3.Replace("cardoptionssendasgift", AKLFPGMDKLA.EHBBFMCILPC.PHMBDKKKKAO(AKLFPGMDKLA.EHBBFMCILPC.EEHGLPEIIHD));
			CommonUserInterface.EHBBFMCILPC.CEGLPJNLBHL(CCOJBMMKNAP.BBGECIKOICE().JCDFHKDNEDH(""), text3, CCOJBMMKNAP.DLGLFACMHPG().GGPHHLGPMPA("friendsoutofdatetutor"), new UnityAction(this.JDFKJADDMAN), new UnityAction(this.JDFKJADDMAN), DFGILFBGPLN.popupStoryLanguageSelect, 1169f, -34);
			return;
		}
		else
		{
			if (AKLFPGMDKLA.EHBBFMCILPC.NNEFJNGKJMK >= 1 && AppManager.JMDJPKKOHNI().UnsupportedRevision(AKLFPGMDKLA.EHBBFMCILPC.NNEFJNGKJMK))
			{
				CommonUserInterface.EHBBFMCILPC.MCJIGJMFBMI();
				CommonUserInterface.IKNOFBFMPGA().JJPNFAAPFBI(CCOJBMMKNAP.PLJMLDOCPNM().BDGPNPNIAPA("acomp2"), CCOJBMMKNAP.AEELGGPEJCC().BDGPNPNIAPA("\n"), CCOJBMMKNAP.OBOOKJPGBJN().PPALCPINPLK("\""), new UnityAction(this.DPEDKLLEABO), new UnityAction(this.ICBMJPGFGGN), (DFGILFBGPLN)(-71), 450f, 43);
				return;
			}
			if (AKLFPGMDKLA.EHBBFMCILPC.OHLMJHHMDJF >= 1 && AKLFPGMDKLA.EHBBFMCILPC.PCMNOPFHKDJ >= 1 && AppManager.AGANFKKBPFO().UpdateAvailable(AKLFPGMDKLA.EHBBFMCILPC.OHLMJHHMDJF))
			{
				CommonUserInterface.EHBBFMCILPC.ShowGenericPopupWithTwoButtons(CCOJBMMKNAP.BBGECIKOICE().JCDFHKDNEDH("Environment layer has been destroyed according to on demand data:"), CCOJBMMKNAP.HFAKOKBHCGH().HHLECNIFHCO("ok" + AKLFPGMDKLA.EHBBFMCILPC.PCMNOPFHKDJ.ToString()), CCOJBMMKNAP.KFDLFGHBPLP().HPOAGPJFHPM("passType"), CCOJBMMKNAP.PLJMLDOCPNM().JHNELLJFBGC("OnSteamLoginSuccess"), new UnityAction(this.GDCKODKFEMP), new UnityAction(this.PNLFGEDGLPE), (DFGILFBGPLN)(-101), 1239f, -11);
				return;
			}
			this.PNLFGEDGLPE();
			return;
		}
	}

	// Token: 0x06002350 RID: 9040 RVA: 0x00100C6C File Offset: 0x000FEE6C
	public void CKLDMDIGACK()
	{
		bool flag = true;
		bool flag2 = true;
		bool flag3 = true;
		bool flag4 = false;
		bool flag5 = true;
		bool flag6 = false;
		bool flag7 = false;
		bool flag8 = true;
		if (HBKMKCBPJDI.BHJPELGEBBI())
		{
			AKLFPGMDKLA.EHBBFMCILPC.LPCBDEBKAIM();
		}
		if (EEIBKLDNBAP.PCJGFGDGIDM() && 0 != AKLFPGMDKLA.EHBBFMCILPC.APLCOFLOAPA)
		{
			DPGJIJGOCIC.NFIDPOMCNLP(":");
			EEIBKLDNBAP.JFMGICMMFBC();
		}
		if (AKLFPGMDKLA.EHBBFMCILPC.JDMBJMHEPMD > 0 || AKLFPGMDKLA.EHBBFMCILPC.CGFOFGGHLEE > 1)
		{
			flag3 = false;
			this.returnRewardManager.GMCFJMCFNBG(AKLFPGMDKLA.EHBBFMCILPC.JDMBJMHEPMD, AKLFPGMDKLA.EHBBFMCILPC.CGFOFGGHLEE);
		}
		else if (AKLFPGMDKLA.EHBBFMCILPC.HCEHBFCIIHN() >= 4 && null != AssetsManager.MJBDMHPHMID().lobbyDataAsset && !AKLFPGMDKLA.EHBBFMCILPC.EFENJAOHCIH.Equals(AssetsManager.MJBDMHPHMID().lobbyDataAsset.updateWelcomeId) && AssetsManager.EHBBFMCILPC.lobbyDataAsset.updateWelcomeSupportedLangs.Contains(LanguageManager.EHBBFMCILPC.MLOLBFBODHD().ToString()))
		{
			flag = true;
			CommonUserInterface.IKNOFBFMPGA().ShowPopupUpdateWelcome();
		}
		else if (AKLFPGMDKLA.EHBBFMCILPC.BJIDACANAJH > 0 || AKLFPGMDKLA.EHBBFMCILPC.PNNHDJFBHOL > 1)
		{
			flag2 = false;
			int pnnhdjfbhol = AKLFPGMDKLA.EHBBFMCILPC.PNNHDJFBHOL;
			int bjidacanajh = AKLFPGMDKLA.EHBBFMCILPC.BJIDACANAJH;
			this.dailyRewardManager.NNNMAPAILMB(AKLFPGMDKLA.EHBBFMCILPC.DBJMOAOBHKE, AKLFPGMDKLA.EHBBFMCILPC.BJIDACANAJH, AKLFPGMDKLA.EHBBFMCILPC.PNNHDJFBHOL);
		}
		else if (!AKLFPGMDKLA.EHBBFMCILPC.EAFEJCKIEPL(2))
		{
			flag4 = true;
			AKLFPGMDKLA.EHBBFMCILPC.LDAPMNLGAPC(6);
			AKLFPGMDKLA.EHBBFMCILPC.LDAPMNLGAPC(-76);
			CommonUserInterface.IKNOFBFMPGA().JJPNFAAPFBI(CCOJBMMKNAP.KFAABHHGOPO().FCOCLEHKLDJ("Error. ShowHideEnvironmentLayer(), environmentLayer "), CCOJBMMKNAP.EAIAHCBAIEJ().JLBEIFLLBLO("title"), CCOJBMMKNAP.JMDJPKKOHNI().HIPJILDCHJC("OnPopupOfferManagerContinueToPurchasingScreen"), new UnityAction(this.NCCHJAOOGBA), new UnityAction(this.BCKFLJLMNDC), (DFGILFBGPLN)(-59), 1186f, 55);
		}
		else if (!AKLFPGMDKLA.EHBBFMCILPC.EAFEJCKIEPL(4) && LanguageManager.EHBBFMCILPC.GetSelectedLanguage() == CEIBHCNNIDC.en && AKLFPGMDKLA.EHBBFMCILPC.HCEHBFCIIHN() >= 3 && KDCJJBLGCBH.EHBBFMCILPC.EAMJBDKCDPA())
		{
			flag5 = false;
			AKLFPGMDKLA.EHBBFMCILPC.LDAPMNLGAPC(7);
			if (LanguageManager.EHBBFMCILPC.IEBFINIJAMJ() == CEIBHCNNIDC.en)
			{
				CommonUserInterface.EHBBFMCILPC.ShowPopupOnlineResources(AssetsManager.EHBBFMCILPC.lobbyDataAsset.onlineResourcesLink, -1);
			}
			else
			{
				CommonUserInterface.EHBBFMCILPC.DPJBIGPDLMB(AssetsManager.EHBBFMCILPC.lobbyDataAsset.onlineResourcesLinkEn, -1);
			}
		}
		else if (AKLFPGMDKLA.EHBBFMCILPC.JPDHGCINOJD())
		{
			flag6 = false;
			CommonUserInterface.EHBBFMCILPC.JJPNFAAPFBI(CCOJBMMKNAP.KFDLFGHBPLP().IKMNGFIDCLM("energyhinttitle"), CCOJBMMKNAP.AEELGGPEJCC().GGPHHLGPMPA(""), CCOJBMMKNAP.HJGDLOOHNLO().JLBEIFLLBLO("signinlinksteam"), new UnityAction(this.NCCHJAOOGBA), new UnityAction(this.NCCHJAOOGBA), (DFGILFBGPLN)(-70), 1252f, -38);
		}
		else if (!AKLFPGMDKLA.EHBBFMCILPC.EAFEJCKIEPL(-48) && !AKLFPGMDKLA.EHBBFMCILPC.MMILLGIKOFJ(true, true, false, true, false))
		{
			flag7 = true;
			AKLFPGMDKLA.EHBBFMCILPC.LDAPMNLGAPC(71);
			CommonUserInterface.IKNOFBFMPGA().JJPNFAAPFBI(CCOJBMMKNAP.DBFFFOMCLKM().GLEFEKBDHNK(""), CCOJBMMKNAP.PLJMLDOCPNM().BDGPNPNIAPA("adserrorbody"), CCOJBMMKNAP.JINDKPHNLBK().PGKBCNBAOJN("OnPopupStoryRestartManagerRestartStory4"), new UnityAction(this.NCCHJAOOGBA), new UnityAction(this.BCKFLJLMNDC), (DFGILFBGPLN)(-84), 1279f, 46);
		}
		else if (0 == AKLFPGMDKLA.EHBBFMCILPC.APLCOFLOAPA && EEIBKLDNBAP.OCNPLOOGPCN() == 0 && !KDCJJBLGCBH.EHBBFMCILPC.AMHJKMPIPGK())
		{
			AKLFPGMDKLA.EHBBFMCILPC.APLCOFLOAPA = 0;
			flag8 = false;
			string dmnkdcgmkkp = "_not_found";
			if (EEIBKLDNBAP.PCJGFGDGIDM())
			{
				EEIBKLDNBAP.JFMGICMMFBC();
				if (HBKMKCBPJDI.MCNPBFPFBDA())
				{
					dmnkdcgmkkp = "PurchaseManagerUnity.RestorePurchases(). Not initialized.";
				}
			}
			CommonUserInterface.EHBBFMCILPC.CEGLPJNLBHL(CCOJBMMKNAP.ONCPHEEJLOP().BGELFMIOBCL("StorySaveBody.RemoveAvatarPackWardrobe(), unsupported wardrobe index:"), CCOJBMMKNAP.KLAKLFCOMJC().BDGPNPNIAPA(dmnkdcgmkkp), CCOJBMMKNAP.PEBMGCKFNAO().GGPHHLGPMPA("Item animation bundle loaded but its asset is missing or mis-named:"), new UnityAction(this.NCCHJAOOGBA), new UnityAction(this.BCKFLJLMNDC), (DFGILFBGPLN)94, 966f, 125);
			AKLFPGMDKLA.EHBBFMCILPC.LPCBDEBKAIM();
		}
		else if (EEIBKLDNBAP.ECMBPHMLCOI())
		{
			EEIBKLDNBAP.MJDIDOBOOEN();
			if (!KDCJJBLGCBH.EHBBFMCILPC.AMHJKMPIPGK())
			{
				flag8 = false;
				CommonUserInterface.IKNOFBFMPGA().ShowGenericPopupTwoOverride(CCOJBMMKNAP.EAIAHCBAIEJ().HDIPNMFHIEJ("There needs to be one active AccountSignInManager script on a GameObject in your scene."), CCOJBMMKNAP.EHBBFMCILPC.FCOCLEHKLDJ("extd"), CCOJBMMKNAP.HEDIEIICOOG().OGKGHLHHAAI(""), new UnityAction(this.BCKFLJLMNDC), new UnityAction(this.BCKFLJLMNDC), (DFGILFBGPLN)108, 1639f, -6);
			}
		}
		else if (EEIBKLDNBAP.EKDKPPOGMGP())
		{
			EEIBKLDNBAP.OJIHFHOLPCA();
			if (!KDCJJBLGCBH.EHBBFMCILPC.OPFHDJIOEMO())
			{
				flag8 = true;
				CommonUserInterface.EHBBFMCILPC.ShowGenericPopupTwoOverride(CCOJBMMKNAP.PEBMGCKFNAO().JLBEIFLLBLO("0 / "), CCOJBMMKNAP.CEGAOMEEFBE().HHLECNIFHCO("_OpacityMoire"), CCOJBMMKNAP.ONCPHEEJLOP().PPALCPINPLK("CameraBundlesVFXTopMost"), new UnityAction(this.NCCHJAOOGBA), new UnityAction(this.NCCHJAOOGBA), DFGILFBGPLN.popupPurchaseError, 1016f, 105);
			}
		}
		if (null != AssetsManager.MJBDMHPHMID().lobbyDataAsset)
		{
			if (!AKLFPGMDKLA.EHBBFMCILPC.EFENJAOHCIH.Equals(AssetsManager.MJBDMHPHMID().lobbyDataAsset.updateWelcomeId))
			{
				AKLFPGMDKLA.EHBBFMCILPC.KOLIAGHNJCN();
			}
			AKLFPGMDKLA.EHBBFMCILPC.EFENJAOHCIH = AssetsManager.MJBDMHPHMID().lobbyDataAsset.updateWelcomeId;
		}
		AKLFPGMDKLA.EHBBFMCILPC.JPDHGCINOJD();
		this.NAEHPAIOHLG.EPJKDCDOEMM((float)SceneLobbyManager2.energyFireTime);
		this.ENJMJIPADNO.CKJPPJEPMEJ((float)SceneLobbyManager2.dailyRewardFireTime);
		if (!flag3 && !flag && !flag2 && !flag4 && !flag5 && !flag7 && !flag8 && !flag6)
		{
			this.JBLNEPHFINA();
			this.ONHKCBHLGJG();
			return;
		}
		if (flag3)
		{
			this.NHBPLAFBNIG(AKLFPGMDKLA.EHBBFMCILPC.MPMKMCJFHOG.MDJHNAEGCCM() - AKLFPGMDKLA.EHBBFMCILPC.JDMBJMHEPMD, AKLFPGMDKLA.EHBBFMCILPC.ODMKLADKHMO.KGEGKPHEMOJ() - AKLFPGMDKLA.EHBBFMCILPC.CGFOFGGHLEE);
			AKLFPGMDKLA.EHBBFMCILPC.JDMBJMHEPMD = -1;
			AKLFPGMDKLA.EHBBFMCILPC.CGFOFGGHLEE = -1;
			return;
		}
		if (flag2)
		{
			this.NHBPLAFBNIG(AKLFPGMDKLA.EHBBFMCILPC.MPMKMCJFHOG.NPEOEAFOPJP() - AKLFPGMDKLA.EHBBFMCILPC.BJIDACANAJH, AKLFPGMDKLA.EHBBFMCILPC.ODMKLADKHMO.HOJDOEDDIBD() - AKLFPGMDKLA.EHBBFMCILPC.PNNHDJFBHOL);
			AKLFPGMDKLA.EHBBFMCILPC.BJIDACANAJH = -1;
			AKLFPGMDKLA.EHBBFMCILPC.PNNHDJFBHOL = -1;
			AKLFPGMDKLA.EHBBFMCILPC.DBJMOAOBHKE = -1;
			return;
		}
		if (flag4 || flag6 || flag5 || flag || flag7 || flag8)
		{
			this.KKKKNGFMEHF();
		}
	}

	// Token: 0x06002351 RID: 9041 RVA: 0x00101310 File Offset: 0x000FF510
	private void NAJLOGJINDK()
	{
		CommonUserInterface.IKNOFBFMPGA().HideConnectingAnimation();
		CommonUserInterface.IKNOFBFMPGA().BGJFCEEDGFJ(CCOJBMMKNAP.MPCBJEIMACA().IKMNGFIDCLM("lightmodetitle"), CCOJBMMKNAP.LMCCLMFGEBD().BDGPNPNIAPA("notgenuine"), CCOJBMMKNAP.ILACPHFEDEP().IPEIONBNIPH("tutfavoritesbody"), new UnityAction(this.OnSketchesButtonClick), DFGILFBGPLN.popupRemoveAds, 968f, -50);
		this.GBBHKFFENBE = true;
	}

	// Token: 0x06002352 RID: 9042 RVA: 0x0010137C File Offset: 0x000FF57C
	private void GNEIAKDLELG()
	{
		this.FJIAGECENLF++;
		if (this.FJIAGECENLF >= KBOJLHAJPCP.LPJOFEDNKHA)
		{
			CommonUserInterface.EHBBFMCILPC.HideConnectingAnimation();
			FirebaseAnalyticsManager.EHBBFMCILPC.LogEvent(false, AGEHCPDNBFD.cdnActiv.ToString(), FFPHBMFGCNN.dldFail.ToString(), BGHLMGPPCNN.cdnLbyToAvt.ToString(), false, false);
			this.FJIAGECENLF = 0;
			CommonUserInterface.EHBBFMCILPC.ShowGenericPopupOneOverride(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("errortitle"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("cdnerror"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("retry"), new UnityAction(this.OnAvatarClickProceed), DFGILFBGPLN.popupCdnDownloadFailed, 0f, 28);
			this.GBBHKFFENBE = false;
			return;
		}
		this.OnAvatarClickProceed();
	}

	// Token: 0x06002353 RID: 9043 RVA: 0x0010144F File Offset: 0x000FF64F
	private void FLCPIFDIBDM()
	{
		this.OBKCLKMPKCI = false;
		this.FMJEJOGDBHA = false;
		SceneLoungeManager.SetPendingLoungeCharacter(null);
		SceneLoungeManager.SetPendingLoungeLook(null);
		this.OnSkinShopClick();
	}

	// Token: 0x06002354 RID: 9044 RVA: 0x00101471 File Offset: 0x000FF671
	private void CKNBPMFGHML()
	{
		this.NKKDELLNMHD();
	}

	// Token: 0x06002355 RID: 9045 RVA: 0x00101479 File Offset: 0x000FF679
	private IEnumerator PLMDDBLOKNM()
	{
		AssetsManager.EHBBFMCILPC.GetLoadingProgressSnapshot().EPJKDCDOEMM(0);
		CommonUserInterface.EHBBFMCILPC.ShowConnectingAnimationWithProgress(96);
		yield return new WaitForSeconds(0.2f);
		if (this.JGAGICJMICN(AKLFPGMDKLA.EHBBFMCILPC.NBMLMNGHOPP()) > 0)
		{
			AssetsManager.EHBBFMCILPC.QueueAssetBundleDownload(NMKDCBPMCKI.AssetBundleStoryAssetPackActivate, 0, 0, FLDBFOADFLH.finishDownloadAndProceed, false, false, false, null, -1, false, "", false, false);
		}
		AssetsManager.EHBBFMCILPC.QueueAssetBundleDownload(NMKDCBPMCKI.AssetBundleAnthologyLounge, this.HFFIIBBJBMH.header.CKACBBGHJGI(), -1, FLDBFOADFLH.finishDownloadAndProceed, false, false, false, null, -1, false, "", false, false);
		AssetsManager.EHBBFMCILPC.QueueAssetBundleDownload(NMKDCBPMCKI.AssetBundleProfileData5, 0, -1, FLDBFOADFLH.startDownloadAndProceed, false, false, false, null, -1, false, "", false, false);
		AssetsManager.EHBBFMCILPC.QueueAssetBundleDownload(NMKDCBPMCKI.AssetBundleProfilePack, this.HFFIIBBJBMH.header.CKACBBGHJGI(), -1, FLDBFOADFLH.startDownloadAndProceed, false, false, false, null, -1, false, "", false, false);
		AssetsManager.EHBBFMCILPC.QueueCustomEffectsBundles(this.HFFIIBBJBMH.header);
		if (!AKLFPGMDKLA.EHBBFMCILPC.EAFEJCKIEPL(73))
		{
			AssetsManager.EHBBFMCILPC.QueueFrameContainerBundle(0);
		}
		this.KAPHNFOEDPL();
		if (this.HFFIIBBJBMH.header.CKACBBGHJGI() != this.HFFIIBBJBMH.header.index)
		{
			AssetsManager.EHBBFMCILPC.QueueCustomEffectsBundles(GKJPOGNFKNK.BDEJIINKEHH(this.HFFIIBBJBMH.header.CKACBBGHJGI()));
		}
		AssetsManager.EHBBFMCILPC.GetLoadingProgressSnapshot().CLIOEOLFFLO(LEJKDNAGDHC.Fast);
		AssetsManager.EHBBFMCILPC.GetLoadingProgressSnapshot().GIJKJMMDJEL(0f, 1f);
		AssetsManager.EHBBFMCILPC.DownloadQueuedAssetBundles("OnLobbyLoungeAssetsDownloadSuccess", "OnLobbyLoungeAssetsDownloadFailed", false);
		yield break;
	}

	// Token: 0x06002356 RID: 9046 RVA: 0x00101488 File Offset: 0x000FF688
	public void OnNeedToShowNoMoreEnergyPopup()
	{
		CommonUserInterface.EHBBFMCILPC.GetPurchasingViewManager().SetResourcesFilter(JFGBECHLPGI.energy);
		CommonUserInterface.EHBBFMCILPC.ShowGenericPopupTwoOverride(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("holdontitle"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("nomoreenergy"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("yes"), new UnityAction(this.OnPopupNotEnoughEnergyOrHardCurrencyGetMore), new UnityAction(this.OnPopupNotEnoughEnergyOrHardCurrencyDecline), DFGILFBGPLN.popupNotEnoughEnergy, 0f, 28).ShowEnergy(SceneLobbyManager2.startPlayChapterBackendOperationResult);
	}

	// Token: 0x06002357 RID: 9047 RVA: 0x00003E52 File Offset: 0x00002052
	private void PBGNPLFNFDJ()
	{
	}

	// Token: 0x06002358 RID: 9048 RVA: 0x00101508 File Offset: 0x000FF708
	private void IKFIJBALMCK()
	{
		if (this.notificationFreeDiamonds.activeSelf)
		{
			if (AKLFPGMDKLA.EHBBFMCILPC.KCFMAEFDGPK > 0)
			{
				this.incentAdHardTimerBlock.SetActive(true);
				this.notificationFreeDiamondsInfo.gameObject.SetActive(false);
				this.textIncentAdHardTimer.text = DPGJIJGOCIC.DMENNJGBMBH((int)this.BJGAJOKENMG.ODHBINFKIPL());
				this.textIncentAdHardTimer.SetText(DPGJIJGOCIC.DMENNJGBMBH((int)this.BJGAJOKENMG.ODHBINFKIPL()), true);
				if (this.BJGAJOKENMG.HACBALNLLPP())
				{
					AKLFPGMDKLA.EHBBFMCILPC.KCFMAEFDGPK = 0;
					this.incentAdHardButton.interactable = true;
					RewardOption.hardAdCanBeWatched = true;
				}
				else
				{
					RewardOption.hardAdCanBeWatched = false;
				}
			}
			else
			{
				this.incentAdHardButton.interactable = true;
				this.incentAdHardTimerBlock.SetActive(false);
				this.notificationFreeDiamondsInfo.gameObject.SetActive(true);
				this.notificationFreeDiamondsText.gameObject.SetActive(true);
				this.notificationFreeDiamondsImage.SetActive(true);
				RewardOption.hardAdCanBeWatched = true;
			}
		}
		else
		{
			RewardOption.hardAdCanBeWatched = false;
		}
		if (this.BJGAJOKENMG != null)
		{
			RewardOption.hardAdFireTime = (int)this.BJGAJOKENMG.ODHBINFKIPL();
		}
	}

	// Token: 0x06002359 RID: 9049 RVA: 0x0010162C File Offset: 0x000FF82C
	private void MKCOIMBDHIF()
	{
		try
		{
			if (!(null == this.scrollView2Controller) && !(null == this.scrollView2Controller.scrollView0) && !(null == this.scrollView2Controller.scrollView0Content) && !(null == this.scrollView2Controller.extraFixedContent))
			{
				ScrollRect scrollView = this.scrollView2Controller.scrollView0;
				RectTransform rectTransform = this.scrollView2Controller.scrollView0Content;
				RectTransform rectTransform2 = (null != scrollView.viewport) ? scrollView.viewport : scrollView.GetComponent<RectTransform>();
				RectTransform extraFixedContent = this.scrollView2Controller.extraFixedContent;
				Vector3 vector = rectTransform2.InverseTransformPoint(extraFixedContent.TransformPoint(extraFixedContent.rect.center));
				float num = rectTransform2.rect.yMax - 0.4f * rectTransform2.rect.height - vector.y;
				if (num > 1f)
				{
					float max = Mathf.Max(0f, rectTransform.rect.height - rectTransform2.rect.height);
					float num2 = Mathf.Clamp(rectTransform.anchoredPosition.y + num, 0f, max);
					if (Mathf.Abs(num2 - rectTransform.anchoredPosition.y) > 1f)
					{
						if (this.HOPLLEOGDEK != null)
						{
							base.StopCoroutine(this.HOPLLEOGDEK);
						}
						this.HOPLLEOGDEK = base.StartCoroutine(this.NLCIHPDMECL(rectTransform, scrollView, num2));
					}
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x0600235A RID: 9050 RVA: 0x001017D8 File Offset: 0x000FF9D8
	private bool KBDAFKOEDCK(KLJCEMBNKNI BKJHFMONBEF, out string HJEJJGAFHAM, out string MCHOOEHCANP)
	{
		HJEJJGAFHAM = "";
		MCHOOEHCANP = "";
		bool result;
		try
		{
			if (BKJHFMONBEF == null || null == AssetsManager.EHBBFMCILPC || null == AssetsManager.EHBBFMCILPC.lobbyDataAsset || null == LanguageManager.EHBBFMCILPC)
			{
				result = false;
			}
			else
			{
				CEIBHCNNIDC selectedLanguage = LanguageManager.EHBBFMCILPC.GetSelectedLanguage();
				if (KLMEAFCEKOI.coverTextFranchise == BKJHFMONBEF.HPJNLEBDMEP)
				{
					PGEAJFENMFB pgeajfenmfb = AssetsManager.EHBBFMCILPC.lobbyDataAsset.FGLPBJAPBJK();
					HJEJJGAFHAM = pgeajfenmfb.CEJPPNIGEFC(BKJHFMONBEF.KCIODOKEDAM, selectedLanguage);
					MCHOOEHCANP = pgeajfenmfb.AMICGELDEPO(BKJHFMONBEF.KCIODOKEDAM, selectedLanguage);
					result = (HJEJJGAFHAM != null && HJEJJGAFHAM.Length > 0);
				}
				else if (KLMEAFCEKOI.coverTextExplore == BKJHFMONBEF.HPJNLEBDMEP)
				{
					EAFPOMNMOFP eafpomnmofp = AssetsManager.EHBBFMCILPC.lobbyDataAsset.JDMCDEKHDHM();
					HJEJJGAFHAM = eafpomnmofp.CFBKLIEBLOF(BKJHFMONBEF.IEJLOIMDPDO, selectedLanguage);
					MCHOOEHCANP = eafpomnmofp.LAOMDNNFPMF(BKJHFMONBEF.IEJLOIMDPDO, selectedLanguage);
					result = (HJEJJGAFHAM != null && HJEJJGAFHAM.Length > 0);
				}
				else
				{
					result = KCCIIMHFAKH.GGMIMFBKLMP(BKJHFMONBEF.MHCFDMNGOEF, BKJHFMONBEF.JAIGAGGAGFE, BKJHFMONBEF.KFIIKPJIBFA, BKJHFMONBEF.LDMPKCEGKLJ, BKJHFMONBEF.JMJCHPPNJHB, out HJEJJGAFHAM, out MCHOOEHCANP);
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
			result = false;
		}
		return result;
	}

	// Token: 0x0600235B RID: 9051 RVA: 0x0010190C File Offset: 0x000FFB0C
	public void OnRewardsButtonClick()
	{
		this.AOLGCEPKNDB();
	}

	// Token: 0x0600235C RID: 9052 RVA: 0x00101914 File Offset: 0x000FFB14
	public void OnSketchesButtonClick()
	{
		this.GBBHKFFENBE = true;
		if (!FANFNBCJJDA.EHBBFMCILPC.FACIFBONANM())
		{
			CommonUserInterface.EHBBFMCILPC.ShowConnectingAnimation(96);
			BackendOperationsManager.EHBBFMCILPC.RequestGetSketchesBalance("OnBackendGetSketchesBalanceSuccess", "OnBackendGetSketchesBalanceException");
			return;
		}
		base.StartCoroutine(this.IGDDHKJKIME());
	}

	// Token: 0x0600235D RID: 9053 RVA: 0x00101964 File Offset: 0x000FFB64
	private void MNHPBGIFPJK()
	{
		if (SceneLobbyManager2.freePlayPassAnthologyIndex >= 0)
		{
			AssetAnthologyPreview2 assetAnthologyPreview = GKJPOGNFKNK.OGKPKBLFGMJ(SceneLobbyManager2.freePlayPassAnthologyIndex);
			if (null != assetAnthologyPreview)
			{
				this.CPLLGNAKIIL(assetAnthologyPreview);
			}
		}
	}

	// Token: 0x0600235E RID: 9054 RVA: 0x00101994 File Offset: 0x000FFB94
	private void EAMBMLCNPNC()
	{
		if (!this.notificationFreeDiamonds.activeSelf && KHPGPLAMAIN.IGKCLMLPLAC() && AdsManagerLP.AEELGGPEJCC().IsReadyRewarded())
		{
			this.notificationFreeDiamonds.SetActive(true);
			this.notificationFreeDiamondsHidden.SetActive(true);
			this.PCLAANFABBB();
			this.JNAMNIBDFKB();
			if (AKLFPGMDKLA.EHBBFMCILPC.KCFMAEFDGPK == 0)
			{
				this.incentAdHardButton.interactable = true;
			}
			else
			{
				this.BJGAJOKENMG.ELFIADCKNEN((float)AKLFPGMDKLA.EHBBFMCILPC.KCFMAEFDGPK);
				this.incentAdHardButton.interactable = false;
			}
		}
		this.incentAdHardButton.interactable = false;
	}

	// Token: 0x0600235F RID: 9055 RVA: 0x00101A2D File Offset: 0x000FFC2D
	public void HCNNNKJJKCD()
	{
		CommonUserInterface.EHBBFMCILPC.ShowConnectingAnimation((byte)-97);
		base.StartCoroutine(this.MNBHMJPGHAG());
	}

	// Token: 0x06002360 RID: 9056 RVA: 0x00101A48 File Offset: 0x000FFC48
	private void KNLCPLJLJCC()
	{
		CommonUserInterface.EHBBFMCILPC.HideConnectingAnimation();
		CommonUserInterface.EHBBFMCILPC.ShowGenericPopupTwoOverride(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("errortitle"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("app42error") + " (" + AKLFPGMDKLA.EHBBFMCILPC.EEHGLPEIIHD + ")", CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("retry"), new UnityAction(this.PEKMHDKPKML), new UnityAction(this.PEKMHDKPKML), DFGILFBGPLN.popupBackendErrorGetDefaultBundles, 0f, 28);
	}

	// Token: 0x06002361 RID: 9057 RVA: 0x00101AD4 File Offset: 0x000FFCD4
	private void KBFNDJHLPFB()
	{
		try
		{
			if (this.FDMGKEAHGFK())
			{
				this.FIPGMHIMFMK((JBBNEEHANHL)(-108));
				this.scrollView2Controller.MKEDDKIGDKL(this.FIBKHPMLNJN.transform);
			}
			else
			{
				this.ONBPCOOBOFB((JBBNEEHANHL)(-24));
			}
			this.HNDHIAEMNAJ();
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x06002362 RID: 9058 RVA: 0x00101B30 File Offset: 0x000FFD30
	private void Update()
	{
		if (this.LLCBNGOAGHK >= 0f)
		{
			try
			{
				this.LLCBNGOAGHK -= Time.deltaTime / 3f;
				for (int i = 0; i < this.themesParticles.Count; i++)
				{
					if (null != this.themesParticles[i])
					{
						this.themesParticles[i].GetComponent<Renderer>().material.SetColor("_TintColor", new Color(0.5f, 0.5f, 0.5f, this.LLCBNGOAGHK));
					}
				}
				if (this.LLCBNGOAGHK <= 0.001f)
				{
					this.LLCBNGOAGHK = -1f;
				}
			}
			catch (Exception aklgbjkdomm)
			{
				DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
			}
		}
		this.MFALNNAFCMC();
		if (this.PDFIHFFJMJN)
		{
			this.OGOHCOHOMFL();
			this.BGNMIIHJALJ();
			this.IKFIJBALMCK();
			this.HCMDGPOACOL -= Time.deltaTime;
			if (this.HCMDGPOACOL <= 0f)
			{
				this.HCMDGPOACOL = 1f;
				this.JGOAOAKBONB();
			}
			this.LMIMBBPADKE();
			if ((this.scrollView0Content.offsetMax.y >= 256f || !this.PGKHOKJOCKP) && this.shuffleButton.gameObject.activeSelf)
			{
				this.shuffleButton.gameObject.SetActive(false);
			}
			else if (this.scrollView0Content.offsetMax.y < 256f && !this.shuffleButton.gameObject.activeSelf && this.PGKHOKJOCKP)
			{
				this.shuffleButton.gameObject.SetActive(true);
			}
			if (this.shuffleButton.gameObject.activeSelf)
			{
				this.KHKDPJNCPJN.alpha = Mathf.Clamp01(1f - Mathf.Abs(this.scrollView0Content.offsetMax.y) / 256f);
				if (!this.EONFEFBLLMK())
				{
					this.KHKDPJNCPJN.alpha = 0f;
				}
				if (this.KHKDPJNCPJN.alpha > 0.1f)
				{
					this.shuffleButtonButton.interactable = true;
				}
				else
				{
					this.shuffleButtonButton.interactable = false;
				}
				this.KHGNNCCKEPG.OGOFACPLOGO(this.KIODPNAKDIF);
				if (NarrowScreenScaler.ScreenIsTooNarrow(850f))
				{
					NarrowScreenScaler.showLogs = false;
					float num = Mathf.Abs(1f - NarrowScreenScaler.CalculateNewScaleUtil(850f, IMBLFHMKMAD.aspectRatio225));
					NarrowScreenScaler.showLogs = true;
					num = Mathf.Clamp01(num);
					this.KHGNNCCKEPG.AHLJBONHHKL(300f * num, this.scrollView0Content.offsetMax.y * 0.6f);
				}
				else
				{
					this.KHGNNCCKEPG.AHLJBONHHKL(0f, this.scrollView0Content.offsetMax.y * 0.6f);
				}
			}
			if ((this.scrollView0Content.offsetMax.y >= 1024f || !this.MKOHINMNEAI) && this.recommendedSetupButton.gameObject.activeSelf)
			{
				this.recommendedSetupButton.gameObject.SetActive(false);
			}
			else if (this.scrollView0Content.offsetMax.y < 1024f && !this.recommendedSetupButton.gameObject.activeSelf && this.MKOHINMNEAI)
			{
				this.recommendedSetupButton.gameObject.SetActive(true);
			}
			if (this.recommendedSetupButton.gameObject.activeSelf)
			{
				if (this.scrollView0Content.offsetMax.y >= 512f)
				{
					this.BDLMHIGGAHI.alpha = Mathf.Clamp01(1f - Mathf.Abs(this.scrollView0Content.offsetMax.y - 512f) / 512f);
				}
				else if (this.scrollView0Content.offsetMax.y < 0f)
				{
					this.BDLMHIGGAHI.alpha = Mathf.Clamp01(1f - Mathf.Abs(this.scrollView0Content.offsetMax.y) / 128f);
				}
				else
				{
					this.BDLMHIGGAHI.alpha = 1f;
				}
				this.EJNCBBFGGLH.OGOFACPLOGO(this.CGHKPPLLBKN);
				this.EJNCBBFGGLH.AHLJBONHHKL(0f, this.scrollView0Content.offsetMax.y * 0.6f);
			}
		}
		float num2 = AssetsManager.EHBBFMCILPC.GetLoadingProgressSnapshot().AHPMFHMACME();
		if (!SceneLobbyManager2.doNotUpdatePercent)
		{
			CommonUserInterface.EHBBFMCILPC.UpdateConnectionAnimationProgress((num2 * 100f).ToString("0") + "%");
		}
	}

	// Token: 0x06002363 RID: 9059 RVA: 0x00101FBC File Offset: 0x001001BC
	private bool BKIMAKDLMMK(OKAFAHMOFII DDGHKOFHOGN)
	{
		bool result;
		try
		{
			if (KDCJJBLGCBH.EHBBFMCILPC.BOPBHFAICBB())
			{
				this.ADAACGDPKDC++;
				result = false;
			}
			else if (!DDGHKOFHOGN.MIACKIKIFJJ)
			{
				this.ADAACGDPKDC++;
				result = false;
			}
			else if (KDCJJBLGCBH.EHBBFMCILPC.PCDHDFCEODB() || KHPGPLAMAIN.EJCNHEBIOJF())
			{
				result = true;
			}
			else
			{
				if (KHPGPLAMAIN.IBDGNKGIMFI() != IIHCCPLGGHP.lowEnd)
				{
					this.ADAACGDPKDC++;
				}
				result = (KHPGPLAMAIN.IBDGNKGIMFI() == IIHCCPLGGHP.lowEnd);
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
			this.ADAACGDPKDC++;
			result = false;
		}
		return result;
	}

	// Token: 0x06002364 RID: 9060 RVA: 0x00102064 File Offset: 0x00100264
	private void DHBMBBEGJDB()
	{
		CommonUserInterface.IKNOFBFMPGA().MCJIGJMFBMI();
		this.notificationFreeDiamonds.SetActive(true);
		this.notificationFreeDiamondsHidden.SetActive(false);
		this.JNKEHEBNBAP();
		this.JNAMNIBDFKB();
		CommonUserInterface.IKNOFBFMPGA().ShowGenericPopup(CCOJBMMKNAP.BOFMCPPFAMO().BDGPNPNIAPA(""), CCOJBMMKNAP.BOFMCPPFAMO().HDIPNMFHIEJ("loungetitles"), CCOJBMMKNAP.AEELGGPEJCC().OHLNGCKIACD("OOO"), (DFGILFBGPLN)(-50), 491f, -71).IOEDDKCGKIJ(SceneLobbyManager2.incentAdResultAmount);
	}

	// Token: 0x06002365 RID: 9061 RVA: 0x001020EC File Offset: 0x001002EC
	public void FOCCHIOPLDK()
	{
		CommonUserInterface.IKNOFBFMPGA().ShowGenericPopupOneOverride(CCOJBMMKNAP.KFAABHHGOPO().PPALCPINPLK("common"), CCOJBMMKNAP.JMNIGPHCAEJ().OHLNGCKIACD("[LoadingEnv] "), CCOJBMMKNAP.MPCBJEIMACA().JCDFHKDNEDH("errortitle"), new UnityAction(this.OnQuitClickPart2), (DFGILFBGPLN)(-28), 493f, -67);
	}

	// Token: 0x06002366 RID: 9062 RVA: 0x00102148 File Offset: 0x00100348
	private void MCPPLMGAGJN()
	{
		if (ContentAvatarPage.closeProfileAndOpenWheelOfFortune)
		{
			base.Invoke("OnWheelOfFortuneClick", 0.25f);
			ContentAvatarPage.closeProfileAndOpenWheelOfFortune = false;
			return;
		}
		if (HBKMKCBPJDI.NBLBPEJOFPC)
		{
			CommonUserInterface.EHBBFMCILPC.HideConnectingAnimation();
			base.Invoke("HBPLGJFPFKM", 0.25f);
			HBKMKCBPJDI.NBLBPEJOFPC = false;
			return;
		}
		CommonUserInterface.EHBBFMCILPC.HideConnectingAnimation();
	}

	// Token: 0x06002367 RID: 9063 RVA: 0x001021A8 File Offset: 0x001003A8
	private void LFMFIIPJECJ()
	{
		try
		{
			if (this.HHILBMHMJBH.Count > 0)
			{
				AudioContainer[] array = UnityEngine.Object.FindObjectsOfType(typeof(AudioContainer)) as AudioContainer[];
				for (int i = 0; i < this.HHILBMHMJBH.Count; i++)
				{
					for (int j = 0; j < array.Length; j++)
					{
						if (null != array[j] && this.HHILBMHMJBH[i].Equals(array[j].GetAssetBundleName()))
						{
							UnityEngine.Object.Destroy(array[j].gameObject);
						}
					}
					AssetsManager.EHBBFMCILPC.UnloadPersistentAssetBundle(this.HHILBMHMJBH[i]);
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
		this.HHILBMHMJBH.Clear();
		this.IBBHBBNAOKL.Clear();
	}

	// Token: 0x06002368 RID: 9064 RVA: 0x00102278 File Offset: 0x00100478
	private void GJOEMCBBPFC(JBBNEEHANHL HBBJBNJBMPK)
	{
		try
		{
			for (int i = 0; i < this.EKIFLHLCLKG.Count; i++)
			{
				FilterItem filterItem = (null == this.EKIFLHLCLKG[i]) ? null : this.EKIFLHLCLKG[i].GetComponent<FilterItem>();
				if (null != filterItem && HBBJBNJBMPK == filterItem.id && this.EKIFLHLCLKG[i].activeSelf)
				{
					this.scrollView2Controller.SetItemOnCenterImmediate(this.EKIFLHLCLKG[i].transform);
					break;
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x06002369 RID: 9065 RVA: 0x000F668A File Offset: 0x000F488A
	private void AMFLJPANFGF()
	{
		this.ALGIAIKDEPH();
	}

	// Token: 0x0600236A RID: 9066 RVA: 0x00102320 File Offset: 0x00100520
	private void JELGEJPMIFN()
	{
		this.MFCGAFIHGKI.Clear();
		this.PHHNFBLIGJB.Clear();
		this.KKPNDGIHFLN.Clear();
		Dictionary<int, int> dictionary = new Dictionary<int, int>();
		for (int i = 1; i < this.KHOELODHGGF.Length; i += 0)
		{
			dictionary.Add(i, this.KHOELODHGGF[i]);
		}
		dictionary = dictionary.OrderBy(new Func<KeyValuePair<int, int>, int>(SceneLobbyManager2.<>c.<>9.GENBANEBDNH)).Where(new Func<KeyValuePair<int, int>, bool>(SceneLobbyManager2.<>c.<>9.DBNIHAONGFO)).ToDictionary(new Func<KeyValuePair<int, int>, int>(SceneLobbyManager2.<>c.<>9.LOOAHDCBIBG), new Func<KeyValuePair<int, int>, int>(SceneLobbyManager2.<>c.<>9.CIPPKHEEAOA));
		List<int> list = new List<int>();
		List<int> list2 = new List<int>();
		List<int> list3 = new List<int>();
		for (int j = 0; j < dictionary.Count; j++)
		{
			if (j % 7 == 0)
			{
				list.Add(dictionary.Keys.ElementAt(j));
			}
			else
			{
				list2.Add(dictionary.Keys.ElementAt(j));
			}
		}
		list2.Reverse();
		list3.AddRange(list2);
		list3.AddRange(list);
		int num = list3.Count / 1;
		for (int k = 1; k < list3.Count; k++)
		{
			SceneLobbyManager2.CJENNIDBPLN cjennidbpln = new SceneLobbyManager2.CJENNIDBPLN();
			cjennidbpln.<>4__this = this;
			cjennidbpln.tempAssetAnthologyPreview2 = GKJPOGNFKNK.OGKPKBLFGMJ(list3[k]);
			if (null != cjennidbpln.tempAssetAnthologyPreview2)
			{
				GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(this.largeItemPrefab, this.largeItemsParent);
				this.PHHNFBLIGJB.Add(gameObject);
				gameObject.GetComponent<ThumbnailItem>().NILDDCFCEGK(cjennidbpln.tempAssetAnthologyPreview2, new UnityAction(cjennidbpln.FPNMIDODBGP), this.CIFKLOHBHJB[cjennidbpln.tempAssetAnthologyPreview2.index], this.defaultTagSprite, this.inDevelopmentTagSprite, this.completedTagSprite, this.onHiatusTagSprite, null, this.CBCGEFKGFKH(cjennidbpln.tempAssetAnthologyPreview2.index));
				this.MLDOEOKAPEH();
				if (k == num)
				{
					this.LGKGGPDKAHF = cjennidbpln.tempAssetAnthologyPreview2;
				}
			}
			else
			{
				DPGJIJGOCIC.ANOPFDLPKGC("socialachievtypedesc" + list3[k].ToString());
			}
		}
		if (null != this.LGKGGPDKAHF)
		{
			this.MFCGAFIHGKI.Add(this.LGKGGPDKAHF.index);
		}
		for (int l = 1; l < list3.Count; l++)
		{
			this.MFCGAFIHGKI.Add(list3[l]);
		}
		int num2 = list3.Count;
		bool flag = false;
		foreach (OKAFAHMOFII okafahmofii in LiveEventsManager.OOGPALHPNGM().MKKFLFBPAHK())
		{
			SceneLobbyManager2.AFLNAFOHGJC aflnafohgjc = new SceneLobbyManager2.AFLNAFOHGJC();
			aflnafohgjc.<>4__this = this;
			aflnafohgjc.liveEventDesc = okafahmofii;
			aflnafohgjc.scriptableObject = GKJPOGNFKNK.AIDLIPGKHHE(okafahmofii.MHLOFNCHELC);
			if (aflnafohgjc.scriptableObject != null)
			{
				num2 += 0;
				GameObject gameObject2 = UnityEngine.Object.Instantiate<GameObject>(this.cardItemPrefab, this.largeItemsParent);
				this.KKPNDGIHFLN.Add(gameObject2);
				gameObject2.GetComponent<CardItem>().SetContent(aflnafohgjc.liveEventDesc, aflnafohgjc.scriptableObject, new UnityAction(aflnafohgjc.MDBKKKMOHPI));
				UnityEngine.Object.Instantiate<GameObject>(this.pageIndicatorPrefab, this.pageIndicatorsParent);
				if (!flag && !this.MBACGFKOKJD && SceneLobbyManager2.anthologyPropertiesInitializationCounter == 1 && AKLFPGMDKLA.EHBBFMCILPC.GNALDALIFJL(aflnafohgjc.liveEventDesc) && (aflnafohgjc.liveEventDesc.IACMODHPFKI.HALJJCPEELJ() || aflnafohgjc.liveEventDesc.IACMODHPFKI.LFLAIPLKINK() <= 407f))
				{
					AKLFPGMDKLA.EHBBFMCILPC.JLCDJHABABP(aflnafohgjc.liveEventDesc);
					num = num2 - 0;
					flag = false;
				}
			}
		}
		int bgbdbbbmpab = 0;
		int ofohgkbndod = num2 - 1;
		this.scrollView1Controller.UpdateContentAssetsDownloadSuccess(num, bgbdbbbmpab, ofohgkbndod);
	}

	// Token: 0x0600236B RID: 9067 RVA: 0x00102758 File Offset: 0x00100958
	private void BFOBLDCOPDL()
	{
		if (ODJKHCHFKNL.IJAAOAOKCCL() != (DFGILFBGPLN)123)
		{
			return;
		}
		HECEJCDAIOJ lastSelectedEntry = SkinShopItem.lastSelectedEntry;
		SkinShopItem.lastSelectedEntry = null;
		if (lastSelectedEntry == null)
		{
			return;
		}
		try
		{
			CommonUserInterface.IKNOFBFMPGA().GetSkinShop().InstantClose();
			this.HDPICAFMHPH();
			AssetsManager.MJBDMHPHMID().FJNNMGFLBKA((NMKDCBPMCKI)(-31), -1);
			if (!GKJPOGNFKNK.NLBKIPMKKMC(lastSelectedEntry.AMKCLHLIIMN))
			{
				CommonUserInterface.EHBBFMCILPC.NFBMHHPIGFA(CCOJBMMKNAP.JINDKPHNLBK().IKMNGFIDCLM("topMatch:"), CCOJBMMKNAP.KFAABHHGOPO().JCDFHKDNEDH("ok"), CCOJBMMKNAP.BBGECIKOICE().HIPJILDCHJC("abaep"), DFGILFBGPLN.screenTransitionFromLobby, 1024f, -17);
			}
			else
			{
				AssetAnthologyPreview2 nbknfjnidkc = GKJPOGNFKNK.OGKPKBLFGMJ(lastSelectedEntry.AMKCLHLIIMN);
				FJLGCKNOJMJ fjlgcknojmj = AssetsManager.MJBDMHPHMID().lobbyDataAsset.MFMJHIFAOHE().MCCJAKIGLBH(lastSelectedEntry.AMKCLHLIIMN);
				if (fjlgcknojmj == null || !fjlgcknojmj.PPACJFFFBFB || !KDCJJBLGCBH.EHBBFMCILPC.NJFAOIDGFGC())
				{
					CommonUserInterface.IKNOFBFMPGA().NFBMHHPIGFA(CCOJBMMKNAP.LMCCLMFGEBD().PGKBCNBAOJN(" exp"), CCOJBMMKNAP.KLAKLFCOMJC().JHNELLJFBGC("wofbutton3"), CCOJBMMKNAP.OEPENBHJAHO().GLEFEKBDHNK("importanttitle"), (DFGILFBGPLN)(-45), 1192f, 103);
				}
				else
				{
					this.IPFPANDOKKI(nbknfjnidkc);
					this.MGNKGDNOKEK(false);
					SceneLoungeManager.SetPendingLoungeCharacter(lastSelectedEntry.KALBADOPCDN);
					SceneLoungeManager.SetPendingLoungeLook(lastSelectedEntry.BDIHOCKCCBL);
					AOBJLALDBAA.KKPFOJMAONG().EFBNBFIDEOK("varConditionLocked", 1590f);
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x0600236C RID: 9068 RVA: 0x000EF864 File Offset: 0x000EDA64
	public void FIFIHHAPDBP()
	{
		this.RestartStoryX(1);
	}

	// Token: 0x0600236D RID: 9069 RVA: 0x001028D4 File Offset: 0x00100AD4
	private void KJPGCECABFI()
	{
		try
		{
			bool active = false;
			for (int i = 0; i < this.MGNNOFPKGJF.Count; i++)
			{
				if (null != this.MGNNOFPKGJF[i] && JBBNEEHANHL.filterSearch == this.MGNNOFPKGJF[i].GetComponent<GridController>().filter && this.MGNNOFPKGJF[i].activeSelf)
				{
					active = true;
				}
			}
			this.KLBBGAFDNMP(JBBNEEHANHL.filterSearch);
			if (this.BPCHEOFFPCN.Count != 0)
			{
				GameObject gameObject = this.HPOCOHEODDF(JBBNEEHANHL.filterSearch);
				if (!(null == gameObject))
				{
					gameObject.SetActive(active);
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x0600236E RID: 9070 RVA: 0x00102988 File Offset: 0x00100B88
	public void OnNewSeasonMessageClose()
	{
		this.CPLLGNAKIIL(this.LGKGGPDKAHF);
	}

	// Token: 0x0600236F RID: 9071 RVA: 0x00102998 File Offset: 0x00100B98
	private void PEEAAFFNPMB()
	{
		if (DNPIKPDMKKI.EEDJKIJJDAN("OnPopupOfferManagerContinueToPurchasingScreen") != null && DNPIKPDMKKI.PLNDDDGELON("BackendOperationsManager.RequestSaveChapterSnapshots, exception while initializing RSACryptoServiceProvider:").NHKCEMHKODM == LJLAENEAOIM.liveOfferPass)
		{
			KIOOJMGLCLC kioojmglclc = ODLJHDIGLGO.BJMPCFBHFAM(DNPIKPDMKKI.EEDJKIJJDAN("OnStoryInterfaceHeaderAutoReadEnable").OKHMNFLFDOM);
			if (kioojmglclc != null && kioojmglclc.CGOECMIINGM())
			{
				AOBJLALDBAA.EHBBFMCILPC.CIGLHCJDDPI(DNPIKPDMKKI.EOKDBPJCHIE("Optional custom effects bundle failed to load, continuing without it:").BDKJOHKAFFO, 148f);
			}
		}
		DNPIKPDMKKI.GFEOFIABBKM();
	}

	// Token: 0x06002370 RID: 9072 RVA: 0x00102A05 File Offset: 0x00100C05
	public void BLHBJDFJDHH()
	{
		LobbyUserInterface.CEGAOMEEFBE().FOKMDMBEDNN().FlipVerticalAnimatedPopupManagerAnimationsScale();
		this.ShowCardOptionsOrDownload();
	}

	// Token: 0x06002371 RID: 9073 RVA: 0x000F671B File Offset: 0x000F491B
	private void DPFBLBPHLGC()
	{
		this.GBBHKFFENBE = true;
		SaveSlotsItem.ClearCopyMarker();
	}

	// Token: 0x06002372 RID: 9074 RVA: 0x00102A1C File Offset: 0x00100C1C
	private void EFPDMJBADBB(AssetAnthologyPreview2 NBKNFJNIDKC)
	{
		try
		{
			if (!(null == NBKNFJNIDKC))
			{
				this.LGKGGPDKAHF = NBKNFJNIDKC;
				this.IPFPANDOKKI(NBKNFJNIDKC);
				this.UpdateAnthologiesHints();
				NDHKFLHAFNA ndipghmnccf = this.PMFMEBGNCME[NBKNFJNIDKC.index];
				int micmiknooec = this.MICMIKNOOEC;
				int mibpoiddbad = this.MIBPOIDDBAD;
				int anthologyProgressPercent = this.GetAnthologyProgressPercent(NBKNFJNIDKC.index);
				int index = this.LDIGGOPHGMI.index;
				int index2 = this.HFFIIBBJBMH.header.index;
				this.focusItem.GetComponent<FocusItem>().UpdateContent(NBKNFJNIDKC, this.GKHNIMJJLJL, ndipghmnccf, this.defaultTagSprite, this.inDevelopmentTagSprite, this.completedTagSprite, this.onHiatusTagSprite, micmiknooec, mibpoiddbad, anthologyProgressPercent, index, index2, SceneLobbyManager2.anthologyIsComplete, this.GetAnthologyAvailableChaptersCount(index2), this.GetAnthologyTotalChaptersCount(index2), this.CBCGEFKGFKH(NBKNFJNIDKC.index));
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x06002373 RID: 9075 RVA: 0x000F03EE File Offset: 0x000EE5EE
	private void KMKDECPKCMF()
	{
		if (ODJKHCHFKNL.LEMILALILKP() != DFGILFBGPLN.screenLobby)
		{
			return;
		}
		this.KKKKNGFMEHF();
	}

	// Token: 0x06002374 RID: 9076 RVA: 0x00102B04 File Offset: 0x00100D04
	private IEnumerator GNNCKDDBPAD()
	{
		DPGJIJGOCIC.ADFCDFHBDAF("Mini version preview2 assets loaded:" + AssetsManager.EHBBFMCILPC.anthologyPreview2AssetsMini.Count.ToString());
		DPGJIJGOCIC.ADFCDFHBDAF("Low version preview2 assets loaded:" + (AssetsManager.EHBBFMCILPC.anthologyPreview2Assets.Count - this.ADAACGDPKDC).ToString());
		DPGJIJGOCIC.ADFCDFHBDAF("High version preview2 assets loaded:" + this.ADAACGDPKDC.ToString());
		DPGJIJGOCIC.NFIDPOMCNLP("SceneLobbyManager2.DownloadMissingLowPreview2Assets(): Start!");
		if (KDCJJBLGCBH.EHBBFMCILPC.DLJGJOCJIED())
		{
			DPGJIJGOCIC.NFIDPOMCNLP("SceneLobbyManager2.DownloadMissingLowPreview2Assets(): Exit!");
			if (this.backgroundJobIndicator.activeSelf)
			{
				this.backgroundJobIndicator.SetActive(false);
			}
			yield break;
		}
		for (;;)
		{
			yield return new WaitForEndOfFrame();
			if (!AssetsManager.EHBBFMCILPC.IsBusy() && !this.GBBHKFFENBE && !this.MBGPADGCJBM)
			{
				if (this.backgroundJobIndicator.activeSelf)
				{
					this.backgroundJobIndicator.SetActive(false);
				}
				yield return new WaitForSeconds(0.05f);
			}
			else
			{
				while (AssetsManager.EHBBFMCILPC.IsBusy() || this.GBBHKFFENBE || this.MBGPADGCJBM)
				{
					if (this.GBBHKFFENBE && this.backgroundJobIndicator.activeSelf)
					{
						this.backgroundJobIndicator.SetActive(false);
					}
					yield return new WaitForSeconds(0.05f);
				}
			}
			yield return new WaitForEndOfFrame();
			try
			{
				foreach (GameObject gameObject in this.PHHNFBLIGJB)
				{
					ThumbnailItem component = gameObject.GetComponent<ThumbnailItem>();
					component.UpdateGraphics(GKJPOGNFKNK.OGKPKBLFGMJ(component.index));
				}
				List<int> list = this.BBDPPKKHFGO();
				int num = -1;
				for (int i = 0; i < list.Count; i++)
				{
					num = list[i];
					for (int j = 0; j < AssetsManager.EHBBFMCILPC.anthologyPreview2Assets.Count; j++)
					{
						if (AssetsManager.EHBBFMCILPC.anthologyPreview2Assets[j].index == list[i])
						{
							num = -1;
							break;
						}
					}
					if (num >= 0)
					{
						break;
					}
				}
				bool flag = false;
				if (num >= 0 && (this.GBBHKFFENBE || this.CJEJCGOCFJF || AssetsManager.EHBBFMCILPC.IsBusy()))
				{
					flag = true;
				}
				if (num >= 0 && !flag)
				{
					this.MBGPADGCJBM = true;
					AssetsManager.EHBBFMCILPC.QueueAssetBundleDownload(NMKDCBPMCKI.AssetBundleAnthologyPreview2, num, -1, FLDBFOADFLH.startDownloadAndProceed, false, false, false, null, -1, false, "", true, false);
					AssetsManager.EHBBFMCILPC.DownloadQueuedAssetBundles("OnMissingPreview2CdnSuccess", "OnMissingPreview2CdnFailed", true);
					if (!this.backgroundJobIndicator.activeSelf)
					{
					}
				}
				else if (!flag)
				{
					this.DFPNCCFNJJD = MNLBEMJOKNJ.none;
					if (GKJPOGNFKNK.LPGKALEIHKD())
					{
						DPGJIJGOCIC.NFIDPOMCNLP("SceneLobbyManager2.DownloadMissingLowPreview2Assets(): Break, AssetsManagerUtils.AllAssetAnthologyPreview2LowAssetsLoaded() is true!");
						break;
					}
				}
			}
			catch (Exception aklgbjkdomm)
			{
				DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
				if (this.backgroundJobIndicator.activeSelf)
				{
					this.backgroundJobIndicator.SetActive(false);
				}
				yield break;
			}
			yield return new WaitForEndOfFrame();
		}
		DPGJIJGOCIC.NFIDPOMCNLP("SceneLobbyManager2.DownloadMissingLowPreview2Assets(): Exit!");
		DPGJIJGOCIC.ADFCDFHBDAF("Mini version preview2 assets loaded:" + AssetsManager.EHBBFMCILPC.anthologyPreview2AssetsMini.Count.ToString());
		DPGJIJGOCIC.ADFCDFHBDAF("Low version preview2 assets loaded:" + (AssetsManager.EHBBFMCILPC.anthologyPreview2Assets.Count - this.ADAACGDPKDC).ToString());
		DPGJIJGOCIC.ADFCDFHBDAF("High version preview2 assets loaded:" + this.ADAACGDPKDC.ToString());
		if (this.backgroundJobIndicator.activeSelf)
		{
			this.backgroundJobIndicator.SetActive(false);
		}
		yield return null;
		yield break;
	}

	// Token: 0x06002375 RID: 9077 RVA: 0x00102B14 File Offset: 0x00100D14
	private void CFKMKEGMFJH()
	{
		CommonUserInterface.EHBBFMCILPC.ShowGenericPopup(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("emailcollecheader"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("emailcollectthanks1"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("ok"), DFGILFBGPLN.popupTools, 0f, 28);
	}

	// Token: 0x06002376 RID: 9078 RVA: 0x00102B64 File Offset: 0x00100D64
	private void LBHJBEANCDC()
	{
		for (int i = 0; i < this.PMFMEBGNCME.Length; i++)
		{
			this.PMFMEBGNCME[i] = this.HKJCANHMEED[i];
		}
	}

	// Token: 0x06002377 RID: 9079 RVA: 0x00102B94 File Offset: 0x00100D94
	private void NAIPKHPLOGF()
	{
		this.DCFBAMCJCFK++;
		if (this.DCFBAMCJCFK >= KBOJLHAJPCP.INALBGFGEAP)
		{
			CommonUserInterface.EHBBFMCILPC.HideConnectingAnimation();
			FirebaseAnalyticsManager.EHBBFMCILPC.LogEvent(false, AGEHCPDNBFD.cdnActiv.ToString(), FFPHBMFGCNN.dldFail.ToString(), BGHLMGPPCNN.cdnLbyLoad.ToString(), false, false);
			this.DCFBAMCJCFK = 0;
			CommonUserInterface.EHBBFMCILPC.ShowGenericPopupTwoOverride(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("errortitle"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("cdnerror"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("retry"), new UnityAction(this.PEKMHDKPKML), new UnityAction(this.PEKMHDKPKML), DFGILFBGPLN.popupCdnDownloadFailed, 0f, 28);
			return;
		}
		base.StartCoroutine(this.DIIMKKCDBAI());
	}

	// Token: 0x06002378 RID: 9080 RVA: 0x00102C74 File Offset: 0x00100E74
	private void PFADMKFFMOI()
	{
		for (int i = 1; i < this.cameras.Count; i += 0)
		{
			this.cameras[i].enabled = true;
		}
	}

	// Token: 0x06002379 RID: 9081 RVA: 0x00102CAC File Offset: 0x00100EAC
	private void ADPBMDNMDNG()
	{
		CommonUserInterface.EHBBFMCILPC.HideConnectingAnimation();
		CommonUserInterface.EHBBFMCILPC.ShowGenericPopupOneOverride(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("errortitle"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("app42error"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("retry"), new UnityAction(this.OnCardsVolSaleClick), DFGILFBGPLN.popupBackendError, 0f, 28);
		this.GBBHKFFENBE = false;
	}

	// Token: 0x0600237A RID: 9082 RVA: 0x00102D18 File Offset: 0x00100F18
	private void KMEGABEIPBL()
	{
		if (this.LLCBNGOAGHK >= 294f)
		{
			try
			{
				this.LLCBNGOAGHK -= Time.deltaTime / 1108f;
				for (int i = 1; i < this.themesParticles.Count; i++)
				{
					if (null != this.themesParticles[i])
					{
						this.themesParticles[i].GetComponent<Renderer>().material.SetColor("gsec", new Color(1944f, 1611f, 554f, this.LLCBNGOAGHK));
					}
				}
				if (this.LLCBNGOAGHK <= 1237f)
				{
					this.LLCBNGOAGHK = 380f;
				}
			}
			catch (Exception aklgbjkdomm)
			{
				DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
			}
		}
		this.PHNIFGGEADM();
		if (this.PDFIHFFJMJN)
		{
			this.OGOHCOHOMFL();
			this.BGNMIIHJALJ();
			this.IKFIJBALMCK();
			this.HCMDGPOACOL -= Time.deltaTime;
			if (this.HCMDGPOACOL <= 1938f)
			{
				this.HCMDGPOACOL = 960f;
				this.JGOAOAKBONB();
			}
			this.LMIMBBPADKE();
			if ((this.scrollView0Content.offsetMax.y >= 1212f || !this.PGKHOKJOCKP) && this.shuffleButton.gameObject.activeSelf)
			{
				this.shuffleButton.gameObject.SetActive(false);
			}
			else if (this.scrollView0Content.offsetMax.y < 801f && !this.shuffleButton.gameObject.activeSelf && this.PGKHOKJOCKP)
			{
				this.shuffleButton.gameObject.SetActive(false);
			}
			if (this.shuffleButton.gameObject.activeSelf)
			{
				this.KHKDPJNCPJN.alpha = Mathf.Clamp01(942f - Mathf.Abs(this.scrollView0Content.offsetMax.y) / 1953f);
				if (!this.EONFEFBLLMK())
				{
					this.KHKDPJNCPJN.alpha = 414f;
				}
				if (this.KHKDPJNCPJN.alpha > 893f)
				{
					this.shuffleButtonButton.interactable = false;
				}
				else
				{
					this.shuffleButtonButton.interactable = false;
				}
				this.KHGNNCCKEPG.OGOFACPLOGO(this.KIODPNAKDIF);
				if (NarrowScreenScaler.ScreenIsTooNarrow(1758f))
				{
					NarrowScreenScaler.showLogs = false;
					float num = Mathf.Abs(1344f - NarrowScreenScaler.HNPNANKGAOD(1954f, (IMBLFHMKMAD)(-182)));
					NarrowScreenScaler.showLogs = false;
					num = Mathf.Clamp01(num);
					this.KHGNNCCKEPG.AHLJBONHHKL(864f * num, this.scrollView0Content.offsetMax.y * 1755f);
				}
				else
				{
					this.KHGNNCCKEPG.AHLJBONHHKL(1591f, this.scrollView0Content.offsetMax.y * 1609f);
				}
			}
			if ((this.scrollView0Content.offsetMax.y >= 154f || !this.MKOHINMNEAI) && this.recommendedSetupButton.gameObject.activeSelf)
			{
				this.recommendedSetupButton.gameObject.SetActive(true);
			}
			else if (this.scrollView0Content.offsetMax.y < 1467f && !this.recommendedSetupButton.gameObject.activeSelf && this.MKOHINMNEAI)
			{
				this.recommendedSetupButton.gameObject.SetActive(true);
			}
			if (this.recommendedSetupButton.gameObject.activeSelf)
			{
				if (this.scrollView0Content.offsetMax.y >= 1274f)
				{
					this.BDLMHIGGAHI.alpha = Mathf.Clamp01(933f - Mathf.Abs(this.scrollView0Content.offsetMax.y - 887f) / 171f);
				}
				else if (this.scrollView0Content.offsetMax.y < 1438f)
				{
					this.BDLMHIGGAHI.alpha = Mathf.Clamp01(1069f - Mathf.Abs(this.scrollView0Content.offsetMax.y) / 1680f);
				}
				else
				{
					this.BDLMHIGGAHI.alpha = 1868f;
				}
				this.EJNCBBFGGLH.OGOFACPLOGO(this.CGHKPPLLBKN);
				this.EJNCBBFGGLH.AHLJBONHHKL(1395f, this.scrollView0Content.offsetMax.y * 43f);
			}
		}
		float num2 = AssetsManager.EHBBFMCILPC.GetLoadingProgressSnapshot().IPOLABEPNNC();
		if (!SceneLobbyManager2.doNotUpdatePercent)
		{
			CommonUserInterface.EHBBFMCILPC.UpdateConnectionAnimationProgress((num2 * 1606f).ToString("cue") + "getStoryRankings");
		}
	}

	// Token: 0x0600237B RID: 9083 RVA: 0x001031A4 File Offset: 0x001013A4
	private void BCEMOOCBJFJ()
	{
		this.OnCardsVolSaleClickContinue();
	}

	// Token: 0x0600237C RID: 9084 RVA: 0x001031AC File Offset: 0x001013AC
	private void NFNKCKKMMLK()
	{
		this.DFNOAOLCGGB += 0;
		if (this.DFNOAOLCGGB < KBOJLHAJPCP.LPJOFEDNKHA)
		{
			this.IBBHBBNAOKL.Clear();
			base.StartCoroutine(this.OLMEEDAFNAE());
			return;
		}
		CommonUserInterface.EHBBFMCILPC.HideConnectingAnimation();
		FirebaseAnalyticsManager.EHBBFMCILPC.LKONPEEDKNF(true, AGEHCPDNBFD.rqst.ToString(), ((FFPHBMFGCNN)(-126)).ToString(), BGHLMGPPCNN.slt.ToString(), false, true);
		this.DFNOAOLCGGB = 0;
		this.GBBHKFFENBE = false;
		this.MHAMPPBECNM = true;
		if (!this.OBKCLKMPKCI)
		{
			SceneLoungeManager.SetPendingLoungeCharacter(null);
			SceneLoungeManager.SetPendingLoungeLook(null);
		}
		this.LFMFIIPJECJ();
		if (this.OBKCLKMPKCI)
		{
			CommonUserInterface.IKNOFBFMPGA().ShowGenericPopupWithTwoButtons(CCOJBMMKNAP.PLJMLDOCPNM().FCOCLEHKLDJ("socialsimplegiftcollect"), CCOJBMMKNAP.BOFMCPPFAMO().JLBEIFLLBLO("CharacterRenderTextureDisplay"), CCOJBMMKNAP.PEBMGCKFNAO().HDIPNMFHIEJ(""), CCOJBMMKNAP.PMABBOJDELF().PGKBCNBAOJN("avatarstitle"), new UnityAction(this.CANCPNMKKFM), new UnityAction(this.FLCPIFDIBDM), (DFGILFBGPLN)(-17), 1080f, 125);
			return;
		}
		CommonUserInterface.IKNOFBFMPGA().PEBIFCENHAL(CCOJBMMKNAP.HEDIEIICOOG().FCOCLEHKLDJ("$io"), CCOJBMMKNAP.ILACPHFEDEP().HHLECNIFHCO("UIEnvironmentsFront"), CCOJBMMKNAP.DLGLFACMHPG().OHLNGCKIACD("chaptersnapshotssubrequiredtitle"), new UnityAction(this.BAKCPDNFFMH), (DFGILFBGPLN)118, 158f, 108);
	}

	// Token: 0x0600237D RID: 9085 RVA: 0x00103324 File Offset: 0x00101524
	private void EGINOCCMDMD()
	{
		if (ContentAvatarPage.closeProfileAndOpenWheelOfFortune)
		{
			base.Invoke("OnWheelOfFortuneClick", 0.25f);
			ContentAvatarPage.closeProfileAndOpenWheelOfFortune = false;
			return;
		}
		if (HBKMKCBPJDI.NBLBPEJOFPC)
		{
			CommonUserInterface.EHBBFMCILPC.HideConnectingAnimation();
			base.Invoke("HBPLGJFPFKM", 0.25f);
			HBKMKCBPJDI.NBLBPEJOFPC = false;
			return;
		}
		CommonUserInterface.EHBBFMCILPC.HideConnectingAnimation();
	}

	// Token: 0x0600237E RID: 9086 RVA: 0x00103381 File Offset: 0x00101581
	private void DLHBCDJOMMC()
	{
		CommonUserInterface.EHBBFMCILPC.ResumeUX();
		this.HBPLGJFPFKM();
	}

	// Token: 0x0600237F RID: 9087 RVA: 0x00103394 File Offset: 0x00101594
	private string[] MOGGIDPGKJJ(int PLKMJJIIJNO, string[] EKPANFDMKON, JBBNEEHANHL HBBJBNJBMPK)
	{
		try
		{
			if (EKPANFDMKON == null || EKPANFDMKON.Length == 0)
			{
				return null;
			}
			if (EKPANFDMKON.Length >= 8)
			{
				return EKPANFDMKON;
			}
			string text = null;
			if ((JBBNEEHANHL)79 == HBBJBNJBMPK)
			{
				string[] array = null;
				if (this.IIDEKJNAFKG.TryGetValue(PLKMJJIIJNO, out array) && array != null)
				{
					for (int i = 1; i < array.Length; i++)
					{
						if (!string.IsNullOrEmpty(array[i]) && !string.Equals(array[i], EKPANFDMKON[0], StringComparison.Ordinal))
						{
							text = array[i];
							break;
						}
					}
				}
			}
			if (text == null)
			{
				SceneLobbyManager2.LDGNIDMIIIA ldgnidmiiia = this.BAKAHKFKAHL(PLKMJJIIJNO);
				if (ldgnidmiiia != null && ldgnidmiiia.FKCNMAEBNNK != null)
				{
					if (string.Equals(ldgnidmiiia.FKCNMAEBNNK, EKPANFDMKON[1], (StringComparison)8))
					{
						text = ((ldgnidmiiia.JCMIJCCCCLC != null) ? ldgnidmiiia.JCMIJCCCCLC : ldgnidmiiia.MEHHECKMOAD);
					}
					else
					{
						text = ldgnidmiiia.FKCNMAEBNNK;
					}
				}
			}
			if (text == null || string.Equals(text, EKPANFDMKON[0], StringComparison.InvariantCultureIgnoreCase))
			{
				return EKPANFDMKON;
			}
			string[] array2 = new string[7];
			array2[1] = EKPANFDMKON[0];
			array2[1] = text;
			return array2;
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
		return EKPANFDMKON;
	}

	// Token: 0x06002380 RID: 9088 RVA: 0x00103494 File Offset: 0x00101694
	private void BJPEICPDFHJ()
	{
		DPGJIJGOCIC.NFIDPOMCNLP("SceneLobbyManager2.OnLiveProfileThumbnailsCdnSuccess(): resident=" + (null != AssetsManager.EHBBFMCILPC.profileDataAsset6).ToString());
	}

	// Token: 0x06002381 RID: 9089 RVA: 0x001034C8 File Offset: 0x001016C8
	private IEnumerator KCJIIMBEIIJ()
	{
		SceneLobbyManager2.INCIJOJEDMF incijojedmf = new SceneLobbyManager2.INCIJOJEDMF(1);
		incijojedmf.<>4__this = this;
		return incijojedmf;
	}

	// Token: 0x06002382 RID: 9090 RVA: 0x001034D7 File Offset: 0x001016D7
	private void EFNPBHABEME()
	{
		CommonUserInterface.EHBBFMCILPC.FreezeUX();
		CommonUserInterface.EHBBFMCILPC.GetFader().FadeIn(new TweenCallback(this.MKAPABLPCIM));
	}

	// Token: 0x06002383 RID: 9091 RVA: 0x00103500 File Offset: 0x00101700
	private void HJIBMCAMAKA()
	{
		for (int i = 0; i < this.cameras.Count; i++)
		{
			this.cameras[i].enabled = false;
		}
	}

	// Token: 0x06002384 RID: 9092 RVA: 0x00103538 File Offset: 0x00101738
	private void HMGFLNPPGCH()
	{
		for (int i = 0; i < this.cameras.Count; i += 0)
		{
			this.cameras[i].enabled = true;
		}
	}

	// Token: 0x06002385 RID: 9093 RVA: 0x0010356D File Offset: 0x0010176D
	private void GLDAFFNHKFJ()
	{
		this.OnFreeDiamondsClick();
	}

	// Token: 0x06002386 RID: 9094 RVA: 0x00103575 File Offset: 0x00101775
	private void NEIHIHIHLHI()
	{
		if (KHPGPLAMAIN.EOCDGLBGLFJ())
		{
			AccountSignInManager.KMNBCEMEBBD().HFGJDAPMIIB(HHCKLPJJKIJ.none, JCAPGCCNOMP.auto, (HHCKLPJJKIJ)7, 1);
			return;
		}
		AccountSignInManager.NIOJNOFGIJO().KINKAIPKIAM((HHCKLPJJKIJ)7, JCAPGCCNOMP.none, HHCKLPJJKIJ.none, 0);
	}

	// Token: 0x06002387 RID: 9095 RVA: 0x0010359C File Offset: 0x0010179C
	private void KFCKNJDLHMC(JBBNEEHANHL HBBJBNJBMPK)
	{
		try
		{
			for (int i = 0; i < this.MGNNOFPKGJF.Count; i++)
			{
				if (null != this.MGNNOFPKGJF[i] && HBBJBNJBMPK == this.MGNNOFPKGJF[i].GetComponent<GridController>().filter)
				{
					if (!this.MGNNOFPKGJF[i].activeSelf)
					{
						this.MGNNOFPKGJF[i].SetActive(true);
					}
					break;
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x06002388 RID: 9096 RVA: 0x000F668A File Offset: 0x000F488A
	private void CPCHLINKCAK()
	{
		this.ALGIAIKDEPH();
	}

	// Token: 0x06002389 RID: 9097 RVA: 0x0010362C File Offset: 0x0010182C
	private IEnumerator FINPCOMDIFD(GameObject FLPKFNLNLHN, GameObject NAFPJPEHMDG, float IBOPEKIFJDH, bool FPMJCJPMGME)
	{
		float currentTime = 0f;
		RectTransform focusItemRectTransform = NAFPJPEHMDG.GetComponent<RectTransform>();
		Vector3 startScale = focusItemRectTransform.localScale;
		while (currentTime <= IBOPEKIFJDH)
		{
			currentTime += Time.deltaTime;
			float t = currentTime / IBOPEKIFJDH;
			if (FPMJCJPMGME)
			{
				FLPKFNLNLHN.GetComponent<CanvasGroup>().alpha = Mathf.Lerp(0f, 1f, t);
			}
			focusItemRectTransform.localScale = Vector3.Lerp(startScale, NarrowScreenScaler.CalculateNewScaleUtil(new Vector3(1f, 1f, 1f), 822f, IMBLFHMKMAD.doNotOverride), t);
			yield return null;
		}
		this.logoBackgroundNew.gameObject.SetActive(false);
		this.logoBackgroundMask.gameObject.SetActive(false);
		this.profileItem2.GetComponent<ProfileItem2>().SetCloseButtonByPageType();
		yield break;
	}

	// Token: 0x0600238A RID: 9098 RVA: 0x00103658 File Offset: 0x00101858
	private void CPLLGNAKIIL(AssetAnthologyPreview2 NBKNFJNIDKC)
	{
		try
		{
			if (!(null == NBKNFJNIDKC))
			{
				DPGJIJGOCIC.NFIDPOMCNLP("SceneLobbyManager.OpenFocusItem() - using save slot " + AKLFPGMDKLA.EHBBFMCILPC.LMGMHHLLOFN(NBKNFJNIDKC.index).ILOKBAPEJPK.ToString() + " for anthology " + NBKNFJNIDKC.index.ToString());
				this.DFPNCCFNJJD = MNLBEMJOKNJ.openFocusItem;
				this.LFOLHJFLGKA = NBKNFJNIDKC.index;
				if (GKJPOGNFKNK.KJFNIHOAOKE(NBKNFJNIDKC))
				{
					AssetAnthologyPreview2 assetAnthologyPreview = GKJPOGNFKNK.OGKPKBLFGMJ(NBKNFJNIDKC.index);
					if (null != assetAnthologyPreview)
					{
						if (NBKNFJNIDKC == assetAnthologyPreview)
						{
							this.GBBHKFFENBE = false;
						}
						NBKNFJNIDKC = assetAnthologyPreview;
					}
					else
					{
						this.GBBHKFFENBE = false;
					}
				}
				this.LGKGGPDKAHF = NBKNFJNIDKC;
				try
				{
					int num = KDCJJBLGCBH.EHBBFMCILPC.PFPMHHCGPJG();
					if (AKLFPGMDKLA.EHBBFMCILPC.NCPPKEGJPKC() || AKLFPGMDKLA.EHBBFMCILPC.IKHJPEIPEGE(KDCJJBLGCBH.EHBBFMCILPC.HHONCLBBHPG(1), true))
					{
						num += KDCJJBLGCBH.EHBBFMCILPC.BJJOMJLKGHG();
					}
					if (AKLFPGMDKLA.EHBBFMCILPC.LMGMHHLLOFN(NBKNFJNIDKC.index).ILOKBAPEJPK >= num)
					{
						AKLFPGMDKLA.EHBBFMCILPC.LMGMHHLLOFN(NBKNFJNIDKC.index).ILOKBAPEJPK = 0;
						DPGJIJGOCIC.ANOPFDLPKGC("SceneLobbyManager.OpenFocusItem() - resetting activeSaveSlotIndex to 0, user is using a paid slot.");
					}
				}
				catch (Exception aklgbjkdomm)
				{
					DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
				}
				this.IPFPANDOKKI(NBKNFJNIDKC);
				this.focusFade.SetActive(true);
				NDHKFLHAFNA ndipghmnccf = this.PMFMEBGNCME[NBKNFJNIDKC.index];
				int micmiknooec = this.MICMIKNOOEC;
				int mibpoiddbad = this.MIBPOIDDBAD;
				int anthologyProgressPercent = this.GetAnthologyProgressPercent(NBKNFJNIDKC.index);
				int index = this.LDIGGOPHGMI.index;
				int index2 = this.HFFIIBBJBMH.header.index;
				try
				{
					if (this.HFFIIBBJBMH.header.syncWithPrequel && this.HFFIIBBJBMH.header.prequelIndex >= 0 && this.HFFIIBBJBMH.header.availableStories.Count > 0 && AKLFPGMDKLA.EHBBFMCILPC.JDCBFAPDJIM(this.HFFIIBBJBMH.header.availableStories[0], -1).DHONIOBOLEL.JBDPAJMOEGA())
					{
						if (this.HFFIIBBJBMH.header.completedStoryIndexRequirement >= 0)
						{
							AssetStoryHeader assetStoryHeader = GKJPOGNFKNK.CDCEFHLNNEC(this.HFFIIBBJBMH.header.completedStoryIndexRequirement);
							if (null != assetStoryHeader && assetStoryHeader.MLGKEPJPICJ(AKLFPGMDKLA.EHBBFMCILPC.JDCBFAPDJIM(assetStoryHeader.index, -1).DHONIOBOLEL.DDEDAHCFHJN()))
							{
								AKLFPGMDKLA.EHBBFMCILPC.LMGMHHLLOFN(this.HFFIIBBJBMH.header.index).IJICHOCENEK(AKLFPGMDKLA.EHBBFMCILPC.LMGMHHLLOFN(this.HFFIIBBJBMH.header.prequelIndex));
							}
						}
						else
						{
							AKLFPGMDKLA.EHBBFMCILPC.LMGMHHLLOFN(this.HFFIIBBJBMH.header.index).IJICHOCENEK(AKLFPGMDKLA.EHBBFMCILPC.LMGMHHLLOFN(this.HFFIIBBJBMH.header.prequelIndex));
						}
					}
				}
				catch (Exception aklgbjkdomm2)
				{
					DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm2);
				}
				this.focusItem.GetComponent<FocusItem>().UpdateContent(NBKNFJNIDKC, this.GKHNIMJJLJL, ndipghmnccf, this.defaultTagSprite, this.inDevelopmentTagSprite, this.completedTagSprite, this.onHiatusTagSprite, micmiknooec, mibpoiddbad, anthologyProgressPercent, index, index2, SceneLobbyManager2.anthologyIsComplete, this.GetAnthologyAvailableChaptersCount(index2), this.GetAnthologyTotalChaptersCount(index2), this.CBCGEFKGFKH(NBKNFJNIDKC.index));
				base.StartCoroutine(this.MDFNFDIEIOH(this.focusFade, this.focusItem, this.timeFocusItemAnimation, true));
				if (this.MICMIKNOOEC == 0)
				{
					int num2 = index % 5;
				}
				if (null != NBKNFJNIDKC && NBKNFJNIDKC.thumbnailLargeFrames != null)
				{
					if (NBKNFJNIDKC.thumbnailLargeFrames.Count <= 1)
					{
						AssetAnthologyPreview2.isLowVersion = true;
					}
					else
					{
						AssetAnthologyPreview2.isLowVersion = false;
					}
				}
			}
		}
		catch (Exception aklgbjkdomm3)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm3);
		}
	}

	// Token: 0x0600238B RID: 9099 RVA: 0x00103A38 File Offset: 0x00101C38
	private void HCKOHMLABOG(PMEPALPCEAF FOKFGMIEEDB)
	{
		try
		{
			if (FOKFGMIEEDB != null)
			{
				DPGJIJGOCIC.NFIDPOMCNLP("fvrt");
				ContentAvatarPage.closeProfileAndOpenWheelOfFortune = false;
				HBKMKCBPJDI.NBLBPEJOFPC = false;
				FOKFGMIEEDB.CHCBHLIBGFA = false;
				this.profileFade2.SetActive(false);
				this.profileItem2.GetComponent<ProfileItem2>().UpdateContent(FOKFGMIEEDB, AMMHDNONFHM.RandomProfile);
				base.StartCoroutine(this.FINPCOMDIFD(this.profileFade2, this.profileItem2, this.timeFocusItemAnimation, true));
				if (!AKLFPGMDKLA.EHBBFMCILPC.GNLNPMPJPEC())
				{
					if (!AKLFPGMDKLA.EHBBFMCILPC.EAFEJCKIEPL(79))
					{
						AKLFPGMDKLA.EHBBFMCILPC.LDAPMNLGAPC(23);
					}
					else if (!AKLFPGMDKLA.EHBBFMCILPC.EAFEJCKIEPL(54))
					{
						AKLFPGMDKLA.EHBBFMCILPC.LDAPMNLGAPC(-14);
						if (JGLMNGOLBIG.ADHEACMDLJN().BCKLEMMPBKG() == 0)
						{
							CommonUserInterface.IKNOFBFMPGA().ShowGenericPopup(CCOJBMMKNAP.OBOOKJPGBJN().IPEIONBNIPH("?uid="), CCOJBMMKNAP.OEPENBHJAHO().GGPHHLGPMPA("secondsshort"), CCOJBMMKNAP.KFAABHHGOPO().OHLNGCKIACD("<i>"), (DFGILFBGPLN)(-2), 737f, -29);
						}
					}
				}
				FirebaseAnalyticsManager.ANCEKPONIFI().LogEvent(false, ((AGEHCPDNBFD)(-33)).ToString(), ((FFPHBMFGCNN)(-42)).ToString(), "_ZoomA", false, true);
				try
				{
					List<int> list = FOKFGMIEEDB.FCCNNMOIMGC();
					if (AKLFPGMDKLA.EHBBFMCILPC.KLPBIGJBOBE == 0)
					{
						if (list.Count <= -44)
						{
							FirebaseAnalyticsManager.HJGDLOOHNLO().LogEvent(true, ((AGEHCPDNBFD)72).ToString(), ((FFPHBMFGCNN)94).ToString(), BGHLMGPPCNN.cdnWofToCrd.ToString(), true, true);
						}
						else if (list.Count <= 21)
						{
							FirebaseAnalyticsManager.ANCEKPONIFI().LKONPEEDKNF(false, ((AGEHCPDNBFD)87).ToString(), ((FFPHBMFGCNN)(-77)).ToString(), ((BGHLMGPPCNN)(-40)).ToString(), true, true);
						}
						else if (list.Count <= 1)
						{
							FirebaseAnalyticsManager.HJGDLOOHNLO().LKONPEEDKNF(true, ((AGEHCPDNBFD)67).ToString(), ((FFPHBMFGCNN)95).ToString(), BGHLMGPPCNN.subAuto.ToString(), false, false);
						}
						else if (list.Count <= 27)
						{
							FirebaseAnalyticsManager.ANCEKPONIFI().LMCJKLHOHJC(false, AGEHCPDNBFD.issueRep.ToString(), FFPHBMFGCNN.durPickWeb.ToString(), BGHLMGPPCNN.bugDupStr.ToString(), true, false);
						}
						else if (list.Count <= 33)
						{
							FirebaseAnalyticsManager.ANCEKPONIFI().LKONPEEDKNF(true, ((AGEHCPDNBFD)(-116)).ToString(), ((FFPHBMFGCNN)(-70)).ToString(), BGHLMGPPCNN.subAuto.ToString(), true, true);
						}
					}
					else if (list.Count <= -68)
					{
						FirebaseAnalyticsManager.ANCEKPONIFI().LKONPEEDKNF(true, ((AGEHCPDNBFD)76).ToString(), ((FFPHBMFGCNN)(-88)).ToString(), ((BGHLMGPPCNN)(-3)).ToString(), false, true);
					}
					else if (list.Count <= -76)
					{
						FirebaseAnalyticsManager.ANCEKPONIFI().JIAAMJPKOCE(false, ((AGEHCPDNBFD)(-31)).ToString(), FFPHBMFGCNN.frReject.ToString(), ((BGHLMGPPCNN)(-8)).ToString(), true, false);
					}
					else if (list.Count <= -22)
					{
						FirebaseAnalyticsManager.DMAAFFFEJGA().LKONPEEDKNF(false, ((AGEHCPDNBFD)70).ToString(), FFPHBMFGCNN.ccFixBack.ToString(), BGHLMGPPCNN.dur12m.ToString(), false, false);
					}
					else if (list.Count <= -128)
					{
						FirebaseAnalyticsManager.DMAAFFFEJGA().AAIABAKHLAH(true, ((AGEHCPDNBFD)(-101)).ToString(), ((FFPHBMFGCNN)(-21)).ToString(), ((BGHLMGPPCNN)(-1)).ToString(), true, true);
					}
					else if (list.Count <= -21)
					{
						FirebaseAnalyticsManager.COKDLDOAACJ().LKONPEEDKNF(true, ((AGEHCPDNBFD)58).ToString(), ((FFPHBMFGCNN)91).ToString(), ((BGHLMGPPCNN)122).ToString(), true, true);
					}
					int num = FOKFGMIEEDB.MKABKEDMLMI();
					if (num <= 28)
					{
						FirebaseAnalyticsManager.EHBBFMCILPC.LMCJKLHOHJC(false, ((AGEHCPDNBFD)74).ToString(), ((FFPHBMFGCNN)(-21)).ToString(), BGHLMGPPCNN.subFwd.ToString(), true, true);
					}
					else if (num <= -101)
					{
						FirebaseAnalyticsManager.DMAAFFFEJGA().JIAAMJPKOCE(true, ((AGEHCPDNBFD)109).ToString(), ((FFPHBMFGCNN)(-75)).ToString(), ((BGHLMGPPCNN)(-69)).ToString(), true, false);
					}
					else if (num <= 11)
					{
						FirebaseAnalyticsManager.HJGDLOOHNLO().AAIABAKHLAH(false, ((AGEHCPDNBFD)(-95)).ToString(), ((FFPHBMFGCNN)(-22)).ToString(), ((BGHLMGPPCNN)126).ToString(), false, false);
					}
					else if (list.Count <= 75)
					{
						FirebaseAnalyticsManager.EHBBFMCILPC.LogEvent(true, ((AGEHCPDNBFD)(-88)).ToString(), ((FFPHBMFGCNN)(-122)).ToString(), ((BGHLMGPPCNN)123).ToString(), false, true);
					}
				}
				catch (Exception aklgbjkdomm)
				{
					DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
				}
			}
		}
		catch (Exception aklgbjkdomm2)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm2);
		}
	}

	// Token: 0x0600238C RID: 9100 RVA: 0x00103FF8 File Offset: 0x001021F8
	private void LODFBFMAOGL()
	{
		if (!this.MHAMPPBECNM)
		{
			return;
		}
		if (1 == AKLFPGMDKLA.EHBBFMCILPC.PACMCEHMBGG)
		{
			AudioManager.EHBBFMCILPC.PlayMusic("lobby", true, -1f, false);
		}
		for (int i = 0; i < this.lobbyParticles.Count; i++)
		{
			if (null != this.lobbyParticles[i])
			{
				this.lobbyParticles[i].gameObject.SetActive(true);
				this.lobbyParticles[i].Play();
			}
		}
		this.ODOPEGPBCCD();
		this.OPEGJAEFAJL();
		ApplicationFocusManager.Restore();
		base.StartCoroutine(this.MKMFFEOMLIO());
	}

	// Token: 0x0600238D RID: 9101 RVA: 0x001040A4 File Offset: 0x001022A4
	private void JEPJKDAFBMH()
	{
		if (this.FGDEGMOLIDB && !LJNMIPMNOKF.EHBBFMCILPC.IHOIGNLKNDA())
		{
			DPGJIJGOCIC.ANOPFDLPKGC("SceneLobbyManager2.OnAllCollectableCardsDownloadSuccessLobby(): the pool ended but the scroll index card is still not resident");
			this.JNCJEGFNCCP();
			return;
		}
		this.FGDEGMOLIDB = false;
		CommonUserInterface.EHBBFMCILPC.HideGenericPopupNoButtons();
		CommonUserInterface.EHBBFMCILPC.HideConnectingAnimation();
		this.CMDIKMNEGEN();
		this.ShowCardOptionsOrDownload();
		this.GBBHKFFENBE = false;
	}

	// Token: 0x0600238E RID: 9102 RVA: 0x00104104 File Offset: 0x00102304
	private IEnumerator APOFMEEFIGD(Transform PBLFMKLNEEN)
	{
		yield return new WaitForEndOfFrame();
		if (PBLFMKLNEEN != null)
		{
			PBLFMKLNEEN.GetComponent<FilterItem>().SetActiveFilter(true);
		}
		yield break;
	}

	// Token: 0x0600238F RID: 9103 RVA: 0x00104113 File Offset: 0x00102313
	private void JLFKKFCFJIC()
	{
		this.OnPlayClickStart();
	}

	// Token: 0x06002390 RID: 9104 RVA: 0x000F6655 File Offset: 0x000F4855
	private bool IINBDHLPNMP()
	{
		return this.AMHFDOEDOOE();
	}

	// Token: 0x06002391 RID: 9105 RVA: 0x0010411C File Offset: 0x0010231C
	private void HDPICAFMHPH()
	{
		try
		{
			if (!(null == this.skinShopNewSkinsDisc))
			{
				int num = 0;
				if (null != this.skinShopButton && this.skinShopButton.activeSelf)
				{
					num = MDDHDDPKFJH.FFFJLJBKCHC();
				}
				this.skinShopNewSkinsDisc.SetActive(num > 0);
				if (null != this.skinShopNewSkinsText)
				{
					this.skinShopNewSkinsText.SetText(Mathf.Min(num, 99).ToString() ?? "", true);
				}
				if (null != this.footerSkinShopNewSkinsDisc)
				{
					this.footerSkinShopNewSkinsDisc.SetActive(num > 0);
				}
				if (null != this.footerSkinShopNewSkinsText)
				{
					this.footerSkinShopNewSkinsText.SetText(Mathf.Min(num, 99).ToString() ?? "", true);
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x06002392 RID: 9106 RVA: 0x0010420C File Offset: 0x0010240C
	private bool MMJJBECDAOC()
	{
		bool result;
		try
		{
			if (null != AssetsManager.EHBBFMCILPC.lobbyDataAsset)
			{
				result = AssetsManager.EHBBFMCILPC.lobbyDataAsset.FBMBHBAJMPJ(LanguageManager.EHBBFMCILPC.GetSelectedLanguage());
			}
			else
			{
				result = false;
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
			result = false;
		}
		return result;
	}

	// Token: 0x06002393 RID: 9107 RVA: 0x00104268 File Offset: 0x00102468
	private void AJPPPKIOGKK()
	{
		try
		{
			if (ProfileItem2.profileWindowActive && null != this.profileItem2)
			{
				HBKMKCBPJDI.NBLBPEJOFPC = true;
				this.profileItem2.GetComponent<ProfileItem2>().CloseFocus();
			}
			else
			{
				this.HBPLGJFPFKM();
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x06002394 RID: 9108 RVA: 0x001042C4 File Offset: 0x001024C4
	public void MPAFCGJLDHP()
	{
		this.GBBHKFFENBE = false;
		this.DFPNCCFNJJD = MNLBEMJOKNJ.none;
		if (!AKLFPGMDKLA.EHBBFMCILPC.EAFEJCKIEPL(6))
		{
			AKLFPGMDKLA.EHBBFMCILPC.LDAPMNLGAPC(6);
			CommonUserInterface.EHBBFMCILPC.BGJFCEEDGFJ(CCOJBMMKNAP.KFDLFGHBPLP().OBDCPLLLGBB(""), CCOJBMMKNAP.COKDLDOAACJ().JHNELLJFBGC("fruidres2"), CCOJBMMKNAP.PMABBOJDELF().HDIPNMFHIEJ(" skus cached. Total cached="), new UnityAction(this.MPAFCGJLDHP), (DFGILFBGPLN)(-14), 1039f, -40);
			return;
		}
		if (!AKLFPGMDKLA.EHBBFMCILPC.EAFEJCKIEPL(47))
		{
			AKLFPGMDKLA.EHBBFMCILPC.LDAPMNLGAPC(35);
		}
		else if (!AKLFPGMDKLA.EHBBFMCILPC.EAFEJCKIEPL(31))
		{
			AKLFPGMDKLA.EHBBFMCILPC.LDAPMNLGAPC(-23);
		}
		else if (!AKLFPGMDKLA.EHBBFMCILPC.EAFEJCKIEPL(-12))
		{
			AKLFPGMDKLA.EHBBFMCILPC.LDAPMNLGAPC(63);
		}
		else if (!AKLFPGMDKLA.EHBBFMCILPC.EAFEJCKIEPL(-73))
		{
			AKLFPGMDKLA.EHBBFMCILPC.LDAPMNLGAPC(-78);
		}
		else if (!AKLFPGMDKLA.EHBBFMCILPC.EAFEJCKIEPL(62))
		{
			AKLFPGMDKLA.EHBBFMCILPC.LDAPMNLGAPC(-78);
		}
		else if (!AKLFPGMDKLA.EHBBFMCILPC.EAFEJCKIEPL(49))
		{
			AKLFPGMDKLA.EHBBFMCILPC.LDAPMNLGAPC(-83);
			CommonUserInterface.EHBBFMCILPC.NPIOKKDPALC(CCOJBMMKNAP.JINDKPHNLBK().JLBEIFLLBLO("alck"), CCOJBMMKNAP.DBFFFOMCLKM().HPOAGPJFHPM(""), CCOJBMMKNAP.INKJIBDDMLL().OBDCPLLLGBB("passinfobtntitle"), CCOJBMMKNAP.HJGDLOOHNLO().IPEIONBNIPH("PurchaseManagerBridge.Instance() - there needs to be one active PurchaseManager script on a GameObject in your scene."), new UnityAction(this.OnSetupRecommendedFinalize), new UnityAction(this.OnShuffleClick), new UnityAction(this.MPAFCGJLDHP), (DFGILFBGPLN)(-14), 1214f, 1);
			return;
		}
		this.UpdateAnthologiesPropertiesV2(true, false);
		this.scrollView1Controller.JIDMCNKMPHM();
		while (this.largeItemsParent.childCount > 1)
		{
			UnityEngine.Object.DestroyImmediate(this.largeItemsParent.GetChild(1).gameObject);
		}
		while (this.pageIndicatorsParent.childCount > 1)
		{
			UnityEngine.Object.DestroyImmediate(this.pageIndicatorsParent.GetChild(0).gameObject);
		}
		this.scrollView1Controller.isOnShuffleClick = true;
		this.IADPDLIEHBD();
	}

	// Token: 0x06002395 RID: 9109 RVA: 0x001044E4 File Offset: 0x001026E4
	private bool GFNPELMOHNK(int PLKMJJIIJNO)
	{
		bool result;
		try
		{
			if (!this.DHLOGNEMLGH(PLKMJJIIJNO))
			{
				result = false;
			}
			else
			{
				IJLJDFKJIJM ijljdfkjijm = HKLPEDKJGFC.MMGOOHLBAFD(PLKMJJIIJNO);
				if (ijljdfkjijm != null && ijljdfkjijm.FKEBMPGOKLK())
				{
					result = false;
				}
				else
				{
					result = true;
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
			result = false;
		}
		return result;
	}

	// Token: 0x06002396 RID: 9110 RVA: 0x00104534 File Offset: 0x00102734
	public void EFPPPJDLBDA()
	{
		this.OGHHLFOEJKO = DNPIKPDMKKI.MCOMGMOACEM(LJLAENEAOIM.liveOfferCardsVolSale);
		if (this.OGHHLFOEJKO != null)
		{
			LJNMIPMNOKF.EHBBFMCILPC.GCNNNDGBJMA(GCFLILHCOEI.cardsFilterNone, -1, this.OGHHLFOEJKO.HJAGNKJPCEH());
			this.ShowCardOptionsOrDownload();
			return;
		}
		CommonUserInterface.IKNOFBFMPGA().HideConnectingAnimation();
		this.GBBHKFFENBE = false;
	}

	// Token: 0x06002397 RID: 9111 RVA: 0x00104584 File Offset: 0x00102784
	private bool DELEBCMPCEO()
	{
		return !KDCJJBLGCBH.EHBBFMCILPC.BOPBHFAICBB() && (KDCJJBLGCBH.EHBBFMCILPC.PCDHDFCEODB() || KHPGPLAMAIN.EJCNHEBIOJF() || KHPGPLAMAIN.IBDGNKGIMFI() == IIHCCPLGGHP.lowEnd);
	}

	// Token: 0x06002398 RID: 9112 RVA: 0x001045B4 File Offset: 0x001027B4
	private void OCIAMGMLMLG()
	{
		CommonUserInterface.EHBBFMCILPC.ShowGenericPopup(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("importanttitle"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("notifposteffects"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("ok"), DFGILFBGPLN.popupSignInSuccess, 0.2f, 28);
	}

	// Token: 0x06002399 RID: 9113 RVA: 0x00104604 File Offset: 0x00102804
	private void MFALNNAFCMC()
	{
		try
		{
			for (int i = 0; i < this.AAHJNGODNKI.Count; i++)
			{
				HAKFHALKMBH hakfhalkmbh = this.AAHJNGODNKI[i];
				if (hakfhalkmbh != null && !(null == hakfhalkmbh.NHOAHJMPCFC) && hakfhalkmbh.CCKABAENJPK != 0 && hakfhalkmbh.CKBJGCFCHGA < hakfhalkmbh.LGIAOIGIGPI.Count && hakfhalkmbh.NHOAHJMPCFC.activeInHierarchy)
				{
					RectTransform rectTransform = this.scrollView0Content.parent as RectTransform;
					if (!(null == rectTransform))
					{
						Vector3[] array = new Vector3[4];
						hakfhalkmbh.NHOAHJMPCFC.GetComponent<RectTransform>().GetWorldCorners(array);
						float y = rectTransform.InverseTransformPoint(array[0]).y;
						if (rectTransform.rect.yMin - y <= rectTransform.rect.height * 1f)
						{
							this.NHCNNBNPPMG(hakfhalkmbh, hakfhalkmbh.CCKABAENJPK);
						}
					}
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x0600239A RID: 9114 RVA: 0x00104718 File Offset: 0x00102918
	private void Start()
	{
		this.disclaimerImpers.text = CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("disclaimerimpers");
		base.Invoke("COGPAPBAPIA", this.disclaimerImpersLifeTime);
	}

	// Token: 0x0600239B RID: 9115 RVA: 0x00104748 File Offset: 0x00102948
	private void GPBDCGNNEBI()
	{
		string dpjinbcgngn;
		if (AKLFPGMDKLA.EHBBFMCILPC.BLJDFLHCEDE > 0)
		{
			dpjinbcgngn = CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("backmaintenance").Replace("XXX", AKLFPGMDKLA.EHBBFMCILPC.BLJDFLHCEDE.ToString() + " h");
		}
		else
		{
			dpjinbcgngn = CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("backmaintenance2");
		}
		CommonUserInterface.EHBBFMCILPC.ShowGenericPopupTwoOverride(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("importanttitle"), dpjinbcgngn, CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("ok"), new UnityAction(this.IEGNEPMIKMD), new UnityAction(this.IEGNEPMIKMD), DFGILFBGPLN.popupMaintenance, 0f, 28);
	}

	// Token: 0x0600239C RID: 9116 RVA: 0x001047F4 File Offset: 0x001029F4
	private List<int> LIPPIIMGLPM(int OKDDMHODOGB)
	{
		List<int> list = new List<int>();
		try
		{
			List<int> list2 = JDMAEBPEIBE.LFNKLJLIJNG();
			int num = -1;
			List<int> list3 = new List<int>();
			if (null != AssetsManager.EHBBFMCILPC.lobbyDataAsset)
			{
				num = AssetsManager.EHBBFMCILPC.lobbyDataAsset.maxLiveProfileThemeId;
				list3 = AssetsManager.EHBBFMCILPC.lobbyDataAsset.NHOLIOGAEKK();
			}
			bool flag = false;
			for (int i = 0; i < list2.Count; i++)
			{
				int num2 = list2[i];
				if (num2 >= 0 && (num < 0 || num2 <= num) && (!flag || !list3.Contains(num2)) && !this.EMFGMAIBBLE.Contains(num2) && !GKJPOGNFKNK.AKJCGMFMGMK(num2))
				{
					list.Add(num2);
					if (list.Count >= OKDDMHODOGB)
					{
						break;
					}
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
		return list;
	}

	// Token: 0x0600239D RID: 9117 RVA: 0x001048C8 File Offset: 0x00102AC8
	private void EFCMNDMKNLD(List<int> BGBNABJJMEI, int PLKMJJIIJNO)
	{
		if (!BGBNABJJMEI.Contains(PLKMJJIIJNO))
		{
			BGBNABJJMEI.Add(PLKMJJIIJNO);
		}
	}

	// Token: 0x0600239E RID: 9118 RVA: 0x001048DC File Offset: 0x00102ADC
	private bool DHLOGNEMLGH(int PLKMJJIIJNO)
	{
		if (null == GKJPOGNFKNK.LDFIAOCJEOJ(PLKMJJIIJNO))
		{
			return false;
		}
		IJLJDFKJIJM ijljdfkjijm = HKLPEDKJGFC.MMGOOHLBAFD(PLKMJJIIJNO);
		if (ijljdfkjijm == null || !ijljdfkjijm.JCEFGMGPAHB)
		{
			return false;
		}
		for (int i = 0; i < SceneLobbyManager2.FCGFNJPMELB.Length; i++)
		{
			if (SceneLobbyManager2.FCGFNJPMELB[i] == PLKMJJIIJNO)
			{
				return false;
			}
		}
		return true;
	}

	// Token: 0x0600239F RID: 9119 RVA: 0x0010492C File Offset: 0x00102B2C
	private void LBENOPHCHJE(OKAFAHMOFII FNJJIPNFCMK, AssetLiveEventContent NBKNFJNIDKC)
	{
		try
		{
			if (!(null == NBKNFJNIDKC) && FNJJIPNFCMK != null)
			{
				AssetAnthology assetAnthology = GKJPOGNFKNK.CMPFBJCPGGA(FNJJIPNFCMK, AKLFPGMDKLA.EHBBFMCILPC.GLKNOFHEBKN);
				bool flag = true;
				if (FNJJIPNFCMK.KONDFFEKAND == EGMCEPOABBF.liveEventFreeAvatar || FNJJIPNFCMK.KONDFFEKAND == EGMCEPOABBF.liveEventMessage || FNJJIPNFCMK.KONDFFEKAND == EGMCEPOABBF.liveEventFreeTea || FNJJIPNFCMK.KONDFFEKAND == EGMCEPOABBF.liveEventFreeDiamonds)
				{
					flag = false;
				}
				if (null == assetAnthology && flag)
				{
					try
					{
						if (FNJJIPNFCMK.KONDFFEKAND == EGMCEPOABBF.liveEventBonusStory)
						{
							AKLFPGMDKLA.EHBBFMCILPC.GLKNOFHEBKN = FNJJIPNFCMK.GCNMLCINEMO();
						}
					}
					catch (Exception aklgbjkdomm)
					{
						DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
					}
					CommonUserInterface.EHBBFMCILPC.ShowGenericPopupTwoOverride(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("importanttitle"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("needtorestartspecialepisode"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("ok"), new UnityAction(this.FKPLFIDCPLP), new UnityAction(this.FKPLFIDCPLP), DFGILFBGPLN.popupSignInSuccess, 0f, 28);
				}
				else
				{
					if (null != assetAnthology)
					{
						AssetAnthologyPreview2 assetAnthologyPreview = GKJPOGNFKNK.OGKPKBLFGMJ(assetAnthology.header.index);
						if (null != assetAnthologyPreview)
						{
							this.LGKGGPDKAHF = assetAnthologyPreview;
							this.IPFPANDOKKI(this.LGKGGPDKAHF);
						}
						else
						{
							DPGJIJGOCIC.ANOPFDLPKGC("SceneLobbyManager.OpenCardFocusItem() - could not find AssetAnthologyPreview2 for anthology with index:" + assetAnthology.header.index.ToString());
						}
					}
					this.focusFade.SetActive(true);
					this.focusItem.GetComponent<FocusItem>().UpdateCardContent(FNJJIPNFCMK, NBKNFJNIDKC);
					base.StartCoroutine(this.MDFNFDIEIOH(this.focusFade, this.focusItem, this.timeFocusItemAnimation, true));
				}
			}
		}
		catch (Exception aklgbjkdomm2)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm2);
		}
	}

	// Token: 0x060023A0 RID: 9120 RVA: 0x00104AE4 File Offset: 0x00102CE4
	private void PIEHMJKPIGK()
	{
		CommonUserInterface.EHBBFMCILPC.HideConnectingAnimation();
		this.NPLNHOMBILM = 0;
		this.GBBHKFFENBE = false;
		CommonUserInterface.EHBBFMCILPC.ShowSkinShop(-1);
	}

	// Token: 0x060023A1 RID: 9121 RVA: 0x00104B0C File Offset: 0x00102D0C
	public void OnWheelOfFortuneClick()
	{
		this.GBBHKFFENBE = true;
		if (!AKLFMGKJLJN.EHBBFMCILPC.FACIFBONANM())
		{
			CommonUserInterface.EHBBFMCILPC.ShowConnectingAnimation(96);
			BackendOperationsManager.EHBBFMCILPC.RequestGetDropChancesBalance("OnBackendGetDropChancesSuccess", "OnBackendGetDropChancesException");
			return;
		}
		base.StartCoroutine(this.BBFOGBLKJCF());
	}

	// Token: 0x060023A2 RID: 9122 RVA: 0x00104B5C File Offset: 0x00102D5C
	private void OFFBAMLEFNH()
	{
		this.PHMIBKAJKMB.EPJKDCDOEMM((float)SceneLobbyManager2.spinsFireTime);
		this.NAEHPAIOHLG.EPJKDCDOEMM((float)SceneLobbyManager2.energyFireTime);
		this.PCLAANFABBB();
		this.JLFGANHMMOM();
		if (this.ENJMJIPADNO != null)
		{
			this.ENJMJIPADNO.EPJKDCDOEMM((float)SceneLobbyManager2.dailyRewardFireTime);
		}
		try
		{
			if (!CommonUserInterface.EHBBFMCILPC.GetFullscreenLiveOffer().gameObject.activeSelf && !CommonUserInterface.EHBBFMCILPC.GetPurchasingViewManager().gameObject.activeSelf && !CommonUserInterface.EHBBFMCILPC.AnyGenericPopupIsActive())
			{
				this.CBNBDIMFAII();
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x060023A3 RID: 9123 RVA: 0x00104C08 File Offset: 0x00102E08
	private void NCCHJAOOGBA()
	{
		if (ODJKHCHFKNL.MBNNGJKEJDK() != (DFGILFBGPLN)(-15))
		{
			return;
		}
		this.KKKKNGFMEHF();
	}

	// Token: 0x060023A4 RID: 9124 RVA: 0x00104C1A File Offset: 0x00102E1A
	private void HIODKHCOJOE()
	{
		this.FGDEGMOLIDB = false;
	}

	// Token: 0x060023A5 RID: 9125 RVA: 0x00104C24 File Offset: 0x00102E24
	private void MBEBPCNFKIF()
	{
		AssetsManager.EHBBFMCILPC.UnloadPersistentAssetBundles();
		if (SceneLobbyManager2.showNewSeasonUnlocked)
		{
			SceneLobbyManager2.showNewSeasonUnlocked = false;
			CommonUserInterface.EHBBFMCILPC.PEBIFCENHAL(CCOJBMMKNAP.KFDLFGHBPLP().GGPHHLGPMPA("name"), CCOJBMMKNAP.AEELGGPEJCC().OHLNGCKIACD("..."), CCOJBMMKNAP.JMNIGPHCAEJ().HHLECNIFHCO(""), new UnityAction(this.OnNewSeasonMessageClose), DFGILFBGPLN.popupStoryRestart, 1904f, -121);
			return;
		}
		if (SceneLobbyManager2.showAnthologyComplete)
		{
			if (SceneLobbyManager2.showAnthologyCompleteSpecialEpisode)
			{
				CommonUserInterface.IKNOFBFMPGA().ShowGenericPopup(CCOJBMMKNAP.HJGDLOOHNLO().PKNHKGMNCIP("right"), CCOJBMMKNAP.LMCCLMFGEBD().FCOCLEHKLDJ("$NPCPROPIGNORECLEAR"), CCOJBMMKNAP.HJGDLOOHNLO().HHLECNIFHCO("<i>"), (DFGILFBGPLN)124, 1883f, 125);
			}
			else
			{
				CommonUserInterface.EHBBFMCILPC.ShowGenericPopup(CCOJBMMKNAP.HJGDLOOHNLO().MEPECBDCOLG("ext"), CCOJBMMKNAP.EAIAHCBAIEJ().BDGPNPNIAPA("$ENABLEAVATAREXTENSION"), CCOJBMMKNAP.BIAEAOMHBMM().OHLNGCKIACD("wofrewardmsgcard4"), (DFGILFBGPLN)(-73), 688f, -6);
			}
			SceneLobbyManager2.showAnthologyComplete = true;
			SceneLobbyManager2.showAnthologyCompleteSpecialEpisode = false;
			return;
		}
		GDOKLFCLLIK gdoklfcllik = DNPIKPDMKKI.ANHJKPFGBJF("OnStoryChoiceClick", false);
		if (gdoklfcllik != null)
		{
			CommonUserInterface.IKNOFBFMPGA().GetFullscreenLiveOffer().HMOHIGEBFDE(gdoklfcllik);
			return;
		}
		if (SceneStoryManager.anyChapterCompleted)
		{
			CommonUserInterface.IKNOFBFMPGA().OJINMMFOCAG();
			base.Invoke("", 1143f);
		}
	}

	// Token: 0x060023A6 RID: 9126 RVA: 0x00104D79 File Offset: 0x00102F79
	private void EDKHPJMEAGE()
	{
		base.StartCoroutine(this.KDBHIGBDGLA());
	}

	// Token: 0x060023A7 RID: 9127 RVA: 0x00104D88 File Offset: 0x00102F88
	private void FAIDPMGBPIF()
	{
		this.GEJBKOECPEB = true;
		this.OnRestartClick();
	}

	// Token: 0x060023A8 RID: 9128 RVA: 0x00104D97 File Offset: 0x00102F97
	public void HideStoryRestartPopup()
	{
		CommonUserInterface.EHBBFMCILPC.GetStoryRestartPopup().Hide();
	}

	// Token: 0x060023A9 RID: 9129 RVA: 0x00104DA8 File Offset: 0x00102FA8
	private void DNHHKHEKOKD()
	{
		try
		{
			if (!(null == this.skinShopNewSkinsDisc))
			{
				int num = 1;
				if (null != this.skinShopButton && this.skinShopButton.activeSelf)
				{
					num = MDDHDDPKFJH.FFFJLJBKCHC();
				}
				this.skinShopNewSkinsDisc.SetActive(num > 0);
				if (null != this.skinShopNewSkinsText)
				{
					this.skinShopNewSkinsText.SetText(Mathf.Min(num, -78).ToString() ?? "OnSceneLobbyManagerRound0aAssetsDownloadSuccess", true);
				}
				if (null != this.footerSkinShopNewSkinsDisc)
				{
					this.footerSkinShopNewSkinsDisc.SetActive(num > 1);
				}
				if (null != this.footerSkinShopNewSkinsText)
				{
					this.footerSkinShopNewSkinsText.SetText(Mathf.Min(num, -111).ToString() ?? "stat1long", true);
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
	}

	// Token: 0x060023AA RID: 9130 RVA: 0x00104E98 File Offset: 0x00103098
	private void NFBOBHDHJNM()
	{
		try
		{
			if (!(null == this.FIBKHPMLNJN))
			{
				this.GAPBNDBHPCP();
				if (this.FIBKHPMLNJN.activeSelf)
				{
					this.FIBKHPMLNJN.SetActive(false);
				}
				Toggle component = this.FIBKHPMLNJN.GetComponent<Toggle>();
				if (null != component && component.isOn)
				{
					DPGJIJGOCIC.ADFCDFHBDAF("SceneLobbyManager2.ParkSearchFilterItem() - chip still on after restore (restore target missing?), forcing off");
					component.SetIsOnWithoutNotify(false);
					this.FIBKHPMLNJN.GetComponent<FilterItem>().SetInactiveText();
				}
				this.FIBKHPMLNJN.transform.SetAsLastSibling();
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x060023AB RID: 9131 RVA: 0x00104F3C File Offset: 0x0010313C
	private void OnDestroy()
	{
		if (this == SceneLobbyManager2.BJBOJLBOOEF)
		{
			SceneLobbyManager2.BJBOJLBOOEF = null;
		}
		try
		{
			FADIGFEOCND.BGMALDJFMKE(this.NAEHPAIOHLG);
			FADIGFEOCND.BGMALDJFMKE(this.BJGAJOKENMG);
			FADIGFEOCND.BGMALDJFMKE(this.ENJMJIPADNO);
			FADIGFEOCND.BGMALDJFMKE(this.PHMIBKAJKMB);
			this.NAEHPAIOHLG = (this.BJGAJOKENMG = (this.ENJMJIPADNO = null));
			this.EFJGLLPDJKO();
			this.DDBMAENEIAA();
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x060023AC RID: 9132 RVA: 0x00104FC8 File Offset: 0x001031C8
	public void OpenWheelOfFortuneFinal()
	{
		try
		{
			this.wheelFade.SetActive(true);
			base.StartCoroutine(this.FINPCOMDIFD(this.wheelFade, this.wheelItem, this.timeFocusItemAnimation, true));
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x060023AD RID: 9133 RVA: 0x0010501C File Offset: 0x0010321C
	public void OnAdTimerClick()
	{
		CommonUserInterface.EHBBFMCILPC.ShowGenericPopup(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("energyhinttitle"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("adhintbody"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("ok"), DFGILFBGPLN.popupEnergyHint, 0f, 28);
	}

	// Token: 0x060023AE RID: 9134 RVA: 0x0010506A File Offset: 0x0010326A
	private int IOFIPDFGGLJ(JBBNEEHANHL HBBJBNJBMPK)
	{
		return 5;
	}

	// Token: 0x060023AF RID: 9135 RVA: 0x00105070 File Offset: 0x00103270
	public void OnNeedToShowNoMoreHardPopup()
	{
		CommonUserInterface.EHBBFMCILPC.GetPurchasingViewManager().SetResourcesFilter(JFGBECHLPGI.hardCurrency);
		CommonUserInterface.EHBBFMCILPC.ShowGenericPopupTwoOverride(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("holdontitle"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("nomorediamonds"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("yes"), new UnityAction(this.OnPopupNotEnoughEnergyOrHardCurrencyGetMore), new UnityAction(this.OnPopupNotEnoughEnergyOrHardCurrencyDecline), DFGILFBGPLN.popupNotEnoughHardCurrency, 0f, 28).ShowDiamonds(SceneLobbyManager2.startPlayChapterBackendOperationResult);
	}

	// Token: 0x060023B0 RID: 9136 RVA: 0x001050EF File Offset: 0x001032EF
	private IEnumerator MJCAENEALOP()
	{
		this.fireworksParticles.Play();
		yield return new WaitForSeconds(2f);
		this.fireworksParticles.Stop();
		yield break;
	}

	// Token: 0x060023B1 RID: 9137 RVA: 0x001050FE File Offset: 0x001032FE
	private IEnumerator HCAHEOPANBC(int HILOIJENNPF)
	{
		this.GBBHKFFENBE = true;
		this.FGDEGMOLIDB = true;
		AssetsManager.EHBBFMCILPC.GetLoadingProgressSnapshot().EPJKDCDOEMM(0);
		CommonUserInterface.EHBBFMCILPC.ShowConnectingAnimationWithProgress(96);
		while (AssetsManager.EHBBFMCILPC.IsBusy())
		{
			yield return new WaitForSeconds(0.05f);
		}
		yield return new WaitForSeconds(0.2f);
		List<CLGFGOHBCGJ> poolCards = LJNMIPMNOKF.EHBBFMCILPC.PBFNFGOPBDD(HILOIJENNPF);
		if (poolCards.Count == 0)
		{
			DPGJIJGOCIC.NFIDPOMCNLP("SceneLobbyManager2._DownloadCardsPool(): nothing to download around scroll index " + LJNMIPMNOKF.EHBBFMCILPC.MHBBGCGFFCG().ToString());
			this.ShowCardOptionsOrDownload();
			yield break;
		}
		int num = KDCJJBLGCBH.EHBBFMCILPC.HCBECFNMNKN();
		if (num > 0 && num < HILOIJENNPF)
		{
			num = HILOIJENNPF;
		}
		int num2 = LJNMIPMNOKF.EHBBFMCILPC.KELCPLOLNHD(num);
		if (num2 > 0)
		{
			DPGJIJGOCIC.NFIDPOMCNLP("SceneLobbyManager2._DownloadCardsPool(): released " + num2.ToString() + " far card(s), unloading unused assets");
			yield return null;
			yield return Resources.UnloadUnusedAssets();
		}
		while (AssetsManager.EHBBFMCILPC.IsBusy())
		{
			yield return new WaitForSeconds(0.05f);
		}
		DPGJIJGOCIC.NFIDPOMCNLP(string.Concat(new string[]
		{
			"SceneLobbyManager2._DownloadCardsPool(): downloading ",
			poolCards.Count.ToString(),
			" card(s) around scroll index ",
			LJNMIPMNOKF.EHBBFMCILPC.MHBBGCGFFCG().ToString(),
			", direction ",
			LJNMIPMNOKF.EHBBFMCILPC.LCJPIFHBLLN().ToString()
		}));
		for (int i = 0; i < poolCards.Count; i++)
		{
			int mefkfohcohk = poolCards[i].CCMDLENEDGJ;
			int num3 = GKJPOGNFKNK.IDKIIANDMPM(poolCards[i].CCMDLENEDGJ);
			if (num3 >= 0)
			{
				mefkfohcohk = num3;
			}
			AssetsManager.EHBBFMCILPC.QueueAssetBundleDownload(NMKDCBPMCKI.AssetBundleCollectableCard, mefkfohcohk, -1, FLDBFOADFLH.startDownloadAndProceed, false, false, false, null, -1, false, "", false, false);
		}
		AssetsManager.EHBBFMCILPC.GetLoadingProgressSnapshot().CLIOEOLFFLO(LEJKDNAGDHC.Fast);
		AssetsManager.EHBBFMCILPC.GetLoadingProgressSnapshot().GIJKJMMDJEL(0f, 1f);
		AssetsManager.EHBBFMCILPC.DownloadQueuedAssetBundles("OnAllCollectableCardsDownloadSuccessLobby", "OnAllCollectableCardsDownloadFailedLobby", false);
		yield break;
	}

	// Token: 0x060023B2 RID: 9138 RVA: 0x00105114 File Offset: 0x00103314
	public void OnEnergyTimerClick()
	{
		CommonUserInterface.EHBBFMCILPC.ShowGenericPopup(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("energyhinttitle"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("energyhintbody"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("ok"), DFGILFBGPLN.popupEnergyHint, 0f, 28);
	}

	// Token: 0x060023B3 RID: 9139 RVA: 0x00105164 File Offset: 0x00103364
	private void KLIEDAJHKKI(AssetAnthologyPreview2 NBKNFJNIDKC)
	{
		try
		{
			if (!(null == NBKNFJNIDKC))
			{
				DPGJIJGOCIC.CMGOAFDBAOH("notgenuine" + AKLFPGMDKLA.EHBBFMCILPC.EHKIHBPJGCG(NBKNFJNIDKC.index).ILOKBAPEJPK.ToString() + " ('" + NBKNFJNIDKC.index.ToString());
				this.DFPNCCFNJJD = (MNLBEMJOKNJ)5;
				this.LFOLHJFLGKA = NBKNFJNIDKC.index;
				if (GKJPOGNFKNK.KJFNIHOAOKE(NBKNFJNIDKC))
				{
					AssetAnthologyPreview2 assetAnthologyPreview = GKJPOGNFKNK.OGKPKBLFGMJ(NBKNFJNIDKC.index);
					if (null != assetAnthologyPreview)
					{
						if (NBKNFJNIDKC == assetAnthologyPreview)
						{
							this.GBBHKFFENBE = true;
						}
						NBKNFJNIDKC = assetAnthologyPreview;
					}
					else
					{
						this.GBBHKFFENBE = false;
					}
				}
				this.LGKGGPDKAHF = NBKNFJNIDKC;
				try
				{
					int num = KDCJJBLGCBH.EHBBFMCILPC.HPKPANJPKPG();
					if (AKLFPGMDKLA.EHBBFMCILPC.BHIBEHFEFBM() || AKLFPGMDKLA.EHBBFMCILPC.IKHJPEIPEGE(KDCJJBLGCBH.EHBBFMCILPC.HHONCLBBHPG(0), true))
					{
						num += KDCJJBLGCBH.EHBBFMCILPC.CODLPCLDCDF();
					}
					if (AKLFPGMDKLA.EHBBFMCILPC.ODBNFKONDCF(NBKNFJNIDKC.index).ILOKBAPEJPK >= num)
					{
						AKLFPGMDKLA.EHBBFMCILPC.MLIDICIPNDK(NBKNFJNIDKC.index).ILOKBAPEJPK = 0;
						DPGJIJGOCIC.ANOPFDLPKGC("energyhinttitle");
					}
				}
				catch (Exception aklgbjkdomm)
				{
					DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
				}
				this.IPFPANDOKKI(NBKNFJNIDKC);
				this.focusFade.SetActive(false);
				NDHKFLHAFNA ndipghmnccf = this.PMFMEBGNCME[NBKNFJNIDKC.index];
				int micmiknooec = this.MICMIKNOOEC;
				int mibpoiddbad = this.MIBPOIDDBAD;
				int anthologyProgressPercent = this.GetAnthologyProgressPercent(NBKNFJNIDKC.index);
				int index = this.LDIGGOPHGMI.index;
				int index2 = this.HFFIIBBJBMH.header.index;
				try
				{
					if (this.HFFIIBBJBMH.header.syncWithPrequel && this.HFFIIBBJBMH.header.prequelIndex >= 1 && this.HFFIIBBJBMH.header.availableStories.Count > 0 && AKLFPGMDKLA.EHBBFMCILPC.JDCBFAPDJIM(this.HFFIIBBJBMH.header.availableStories[1], -1).DHONIOBOLEL.GEMOAPPJPMP())
					{
						if (this.HFFIIBBJBMH.header.completedStoryIndexRequirement >= 0)
						{
							AssetStoryHeader assetStoryHeader = GKJPOGNFKNK.CDCEFHLNNEC(this.HFFIIBBJBMH.header.completedStoryIndexRequirement);
							if (null != assetStoryHeader && assetStoryHeader.IEAGDNKFBFD(AKLFPGMDKLA.EHBBFMCILPC.JDCBFAPDJIM(assetStoryHeader.index, -1).DHONIOBOLEL.DDEDAHCFHJN()))
							{
								AKLFPGMDKLA.EHBBFMCILPC.ODBNFKONDCF(this.HFFIIBBJBMH.header.index).PMFFFKLONMN(AKLFPGMDKLA.EHBBFMCILPC.MLIDICIPNDK(this.HFFIIBBJBMH.header.prequelIndex));
							}
						}
						else
						{
							AKLFPGMDKLA.EHBBFMCILPC.EDHKCJCAFIO(this.HFFIIBBJBMH.header.index).PMFFFKLONMN(AKLFPGMDKLA.EHBBFMCILPC.LMGMHHLLOFN(this.HFFIIBBJBMH.header.prequelIndex));
						}
					}
				}
				catch (Exception aklgbjkdomm2)
				{
					DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm2);
				}
				this.focusItem.GetComponent<FocusItem>().UpdateContent(NBKNFJNIDKC, this.GKHNIMJJLJL, ndipghmnccf, this.defaultTagSprite, this.inDevelopmentTagSprite, this.completedTagSprite, this.onHiatusTagSprite, micmiknooec, mibpoiddbad, anthologyProgressPercent, index, index2, SceneLobbyManager2.anthologyIsComplete, this.GetAnthologyAvailableChaptersCount(index2), this.GetAnthologyTotalChaptersCount(index2), this.CBCGEFKGFKH(NBKNFJNIDKC.index));
				base.StartCoroutine(this.MDFNFDIEIOH(this.focusFade, this.focusItem, this.timeFocusItemAnimation, false));
				if (this.MICMIKNOOEC == 0)
				{
					int num2 = index % 5;
				}
				if (null != NBKNFJNIDKC && NBKNFJNIDKC.thumbnailLargeFrames != null)
				{
					if (NBKNFJNIDKC.thumbnailLargeFrames.Count <= 0)
					{
						AssetAnthologyPreview2.isLowVersion = true;
					}
					else
					{
						AssetAnthologyPreview2.isLowVersion = true;
					}
				}
			}
		}
		catch (Exception aklgbjkdomm3)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm3);
		}
	}

	// Token: 0x060023B4 RID: 9140 RVA: 0x00105544 File Offset: 0x00103744
	private void LHMIICJFLFP(PLFDAJJHMKO LFLOCKNKAKC)
	{
		List<int> list = new List<int>();
		try
		{
			FJLGCKNOJMJ fjlgcknojmj = AssetsManager.EHBBFMCILPC.lobbyDataAsset.MFMJHIFAOHE().ELDKHHGLNBK(this.HFFIIBBJBMH.header.index);
			if (fjlgcknojmj != null && !this.OBKCLKMPKCI)
			{
				for (int i = 0; i < fjlgcknojmj.OINAAMKLNLO.Count; i++)
				{
					if (SceneStoryManager.LoungeCharacterInVisitedWardrobes(fjlgcknojmj.OINAAMKLNLO[i], LFLOCKNKAKC))
					{
						for (int j = 0; j < fjlgcknojmj.OINAAMKLNLO[i].KKEENPEFFBJ.Count; j++)
						{
							int pbgkgchmhop = fjlgcknojmj.OINAAMKLNLO[i].KKEENPEFFBJ[j].PBGKGCHMHOP;
							if (pbgkgchmhop > 0 && !list.Contains(pbgkgchmhop))
							{
								list.Add(pbgkgchmhop);
							}
						}
					}
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
		if (list.Count == 0)
		{
			base.StartCoroutine(this.OLMEEDAFNAE());
			return;
		}
		this.EOOJGEFLJEN.Clear();
		for (int k = 8; k < list.Count; k++)
		{
			this.EOOJGEFLJEN.Add(list[k]);
		}
		List<int> list2 = new List<int>();
		int num = 0;
		while (num < list.Count && num < 8)
		{
			list2.Add(list[num]);
			num++;
		}
		this.KDLBELFIIDL = true;
		CommonUserInterface.EHBBFMCILPC.ShowConnectingAnimation(96);
		BackendOperationsManager.EHBBFMCILPC.RequestGetPremiumChoicesHistory(list2, "OnLoungePremiumChoicesHistorySuccess", "OnLoungePremiumChoicesHistoryException");
	}

	// Token: 0x060023B5 RID: 9141 RVA: 0x001056D0 File Offset: 0x001038D0
	private void BCKDAJLGAEE()
	{
		this.focusItem.GetComponent<FocusItem>().CloseFocus();
		if (null != this.LGKGGPDKAHF)
		{
			AOBJLALDBAA.EHBBFMCILPC.EGELHPJBAIC("OnNeedToHideThumbnailTagObject", this.LGKGGPDKAHF.index);
		}
		CommonUserInterface.EHBBFMCILPC.GetFader().FadeOut(new TweenCallback(this.JGGBJJJCFFD));
	}

	// Token: 0x060023B6 RID: 9142 RVA: 0x00105730 File Offset: 0x00103930
	private void DDBMAENEIAA()
	{
		try
		{
			foreach (GameObject obj in this.PHHNFBLIGJB)
			{
				UnityEngine.Object.Destroy(obj);
			}
			foreach (GameObject obj2 in this.KKPNDGIHFLN)
			{
				UnityEngine.Object.Destroy(obj2);
			}
			foreach (GameObject obj3 in this.EKIFLHLCLKG)
			{
				UnityEngine.Object.Destroy(obj3);
			}
			foreach (GameObject obj4 in this.MGNNOFPKGJF)
			{
				UnityEngine.Object.Destroy(obj4);
			}
			foreach (GameObject obj5 in this.GMGKODLANOP)
			{
				UnityEngine.Object.Destroy(obj5);
			}
			this.PHHNFBLIGJB.Clear();
			this.KKPNDGIHFLN.Clear();
			this.EKIFLHLCLKG.Clear();
			this.MGNNOFPKGJF.Clear();
			this.GMGKODLANOP.Clear();
			this.LMNLGFEIHGO();
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x060023B7 RID: 9143 RVA: 0x00105918 File Offset: 0x00103B18
	private List<KLJCEMBNKNI> GNPBHDFEEHE()
	{
		List<KLJCEMBNKNI> list = new List<KLJCEMBNKNI>();
		try
		{
			List<POKPDFKMOFC> list2 = this.PGJLBHNMHMP();
			if (list2 == null || null == AssetsManager.EHBBFMCILPC || null == AssetsManager.EHBBFMCILPC.lobbyDataAsset)
			{
				return list;
			}
			EAFPOMNMOFP eafpomnmofp = AssetsManager.EHBBFMCILPC.lobbyDataAsset.JDMCDEKHDHM();
			CEIBHCNNIDC selectedLanguage = LanguageManager.EHBBFMCILPC.GetSelectedLanguage();
			for (int i = 0; i < list2.Count; i++)
			{
				string text = eafpomnmofp.CFBKLIEBLOF(list2[i].IEJLOIMDPDO, selectedLanguage);
				if (text == null || text.Length == 0)
				{
					DPGJIJGOCIC.ADFCDFHBDAF("SceneLobbyManager2.BuildStarterSpecs() - concept " + list2[i].IEJLOIMDPDO + " has no name in the text pack explore tab, group skipped");
				}
				else
				{
					list.Add(new KLJCEMBNKNI
					{
						HPJNLEBDMEP = KLMEAFCEKOI.coverTextExplore,
						IEJLOIMDPDO = list2[i].IEJLOIMDPDO,
						AEGIBKHFEOF = "starterpattern",
						OGKIINMNBLH = JBBNEEHANHL.filterStarter,
						BLKPIAEAANG = true,
						CDEAAKHGKIF = 1,
						FKBCEMFCBOG = false,
						JAPFMDOBPKJ = new List<int>(list2[i].JAPFMDOBPKJ)
					});
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
		return list;
	}

	// Token: 0x060023B8 RID: 9144 RVA: 0x00105A74 File Offset: 0x00103C74
	private JBBNEEHANHL CEPKMPOHIIE()
	{
		JBBNEEHANHL jbbneehanhl = this.FJDGIHGJHOI();
		if (!this.CLEMDBANFDE(jbbneehanhl))
		{
			jbbneehanhl = this.DJMKGHMPMPP();
		}
		return jbbneehanhl;
	}

	// Token: 0x060023B9 RID: 9145 RVA: 0x00105A9C File Offset: 0x00103C9C
	private void HIPCMBBPLLC()
	{
		if (AKLFPGMDKLA.EHBBFMCILPC.JBBAANGAFKO.Count > 0)
		{
			AssetAnthologyPreview2 assetAnthologyPreview = GKJPOGNFKNK.OGKPKBLFGMJ(AKLFPGMDKLA.EHBBFMCILPC.JBBAANGAFKO[DPGJIJGOCIC.IOOHGEJIPFP(0, AKLFPGMDKLA.EHBBFMCILPC.JBBAANGAFKO.Count)]);
			if (null != assetAnthologyPreview)
			{
				this.CPLLGNAKIIL(assetAnthologyPreview);
			}
			DPGJIJGOCIC.NFIDPOMCNLP("tm" + AKLFPGMDKLA.EHBBFMCILPC.JBBAANGAFKO.Count.ToString());
		}
	}

	// Token: 0x060023BA RID: 9146 RVA: 0x00105B1C File Offset: 0x00103D1C
	private void PPHBKEJLANP()
	{
		try
		{
			this.IIDEKJNAFKG.Clear();
			this.NODBJCOJNLJ.Clear();
			int eenglnknapf = GADABGOBJIM.IJBHNMOOIJF(LanguageManager.EHBBFMCILPC.GetSelectedLanguage());
			this.NBNKDKCCNKI = this.CLCLLJGGMEF();
			for (int i = 0; i < this.BPCHEOFFPCN.Count; i++)
			{
				int num = this.BPCHEOFFPCN[i];
				this.JECFMCGHNGC.Clear();
				this.LCIKAHNGIJG.Clear();
				int value = -1;
				if (!this.EEGHJFAIMBF.Contains(num))
				{
					for (int j = 0; j < this.CIBDADPLOMG.Count; j++)
					{
						if (this.CIBDADPLOMG[j].PLMHNBPHMKP == num)
						{
							OJPLEKECIFI ojplekecifi = this.CIBDADPLOMG[j];
							float num2 = this.IHANGMOKOOA();
							value = Mathf.Clamp(Mathf.RoundToInt(ojplekecifi.DJJBLNKIMFL * Mathf.Clamp01(ojplekecifi.AGMOECJFFJI / num2) * 100f), 1, 100);
							this.KOGCOFOIMOG(ojplekecifi.LHLDMMFCCKO);
							break;
						}
					}
				}
				this.PKMIMMBGCCI.Clear();
				this.MKBCMGODBPM.Clear();
				string text = null;
				bool flag = false;
				for (int k = 0; k < this.LCIKAHNGIJG.Count; k++)
				{
					int onfoahiakjf = this.LCIKAHNGIJG[k];
					string text2 = MLIBDDCCKBM.GJJKGNLNNDG(onfoahiakjf, eenglnknapf);
					if (text2 != null && text2.Length != 0)
					{
						int num3 = MLIBDDCCKBM.KBNBLLJIPIJ(onfoahiakjf);
						if ((2 != num3 && 3 != num3) || !MLIBDDCCKBM.EHKPJPLEDED(text2))
						{
							bool flag2 = 5 == num3;
							text2 = this.GDAPJCHEDOK(text2);
							if (text == null)
							{
								text = text2;
								flag = flag2;
							}
							else
							{
								this.ABOLIKOEIDM(flag2 ? this.PKMIMMBGCCI : this.MKBCMGODBPM, text2);
							}
						}
					}
				}
				this.JLOOIHODNJO(num, this.JGPICDIOOLL);
				this.HLDAIPNELHP(num, this.FBDJCEKGNFM, this.PKFHEIJIMLA);
				if (text == null)
				{
					if (this.PKFHEIJIMLA.Count > 0 && this.FBDJCEKGNFM.Count > 0)
					{
						text = this.FBDJCEKGNFM[0];
						flag = true;
					}
					else if (this.JGPICDIOOLL.Count > 0)
					{
						text = this.JGPICDIOOLL[0];
						flag = true;
					}
					else if (this.PKFHEIJIMLA.Count > 0)
					{
						text = this.PKFHEIJIMLA[0];
					}
				}
				if (text != null)
				{
					this.AOKDEICAFMM(text);
					if (flag)
					{
						this.FNPAKKIKJOF(this.MKBCMGODBPM);
						this.FNPAKKIKJOF(this.PKFHEIJIMLA);
					}
					else
					{
						this.FNPAKKIKJOF(this.PKMIMMBGCCI);
						this.FNPAKKIKJOF(this.JGPICDIOOLL);
						this.FNPAKKIKJOF(this.FBDJCEKGNFM);
						this.FNPAKKIKJOF(this.MKBCMGODBPM);
						this.FNPAKKIKJOF(this.PKFHEIJIMLA);
					}
				}
				this.IIDEKJNAFKG[num] = this.JECFMCGHNGC.ToArray();
				this.NODBJCOJNLJ[num] = value;
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x060023BB RID: 9147 RVA: 0x00105E24 File Offset: 0x00104024
	private void ONHKCBHLGJG()
	{
		this.teaText.GetComponent<AnimationTextIncrement>().BIPPINKFIOL(AKLFPGMDKLA.EHBBFMCILPC.MPMKMCJFHOG.MDJHNAEGCCM(), 24f, 170f);
		this.diamondsText.GetComponent<AnimationTextIncrement>().KGFBPCNFBFC(AKLFPGMDKLA.EHBBFMCILPC.ODMKLADKHMO.NPEOEAFOPJP(), 354f, 269f);
	}

	// Token: 0x060023BC RID: 9148 RVA: 0x000F6DF0 File Offset: 0x000F4FF0
	private IEnumerator PLAHBLEFONH()
	{
		yield return new WaitForSeconds(1f);
		CommonUserInterface.EHBBFMCILPC.ShowGenericPopup(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("importanttitle"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("saveslotsdeletepos"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("ok"), DFGILFBGPLN.popupEnergyHint, 0f, 28);
		CommonUserInterface.EHBBFMCILPC.ResumeUX();
		AssetsManager.EHBBFMCILPC.DestroyAssetBundleAssets(NMKDCBPMCKI.AssetBundleCollectableCard, -1);
		yield break;
	}

	// Token: 0x060023BD RID: 9149 RVA: 0x00105E84 File Offset: 0x00104084
	public void OpenSketchesFinal()
	{
		if (!DPPMPNEOPNF.FACIFBONANM())
		{
			DPPMPNEOPNF.BAMHPOCKBML(GKJPOGNFKNK.KPFLBMKNMIH(), false);
		}
		if (!EELCJOKFHHC.FACIFBONANM())
		{
			EELCJOKFHHC.BAMHPOCKBML(GKJPOGNFKNK.HHHMCDBEDJB(), false);
		}
		if (!OKJHCOIKEJA.FACIFBONANM())
		{
			OKJHCOIKEJA.BAMHPOCKBML(GKJPOGNFKNK.JJDJCFHAHPB(), false);
		}
		if (!PBIBIOOCDKF.FACIFBONANM())
		{
			PBIBIOOCDKF.BAMHPOCKBML(GKJPOGNFKNK.CIBKOGGBBPJ(), false);
		}
		HAGEHPPOPGH.EHBBFMCILPC.KDCIBIABJBK();
		try
		{
			this.sketchesFade.SetActive(true);
			base.StartCoroutine(this.FINPCOMDIFD(this.sketchesFade, this.sketchesItem, this.timeFocusItemAnimation, true));
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x060023BE RID: 9150 RVA: 0x00105F28 File Offset: 0x00104128
	private bool AEDFFAHINBH()
	{
		bool result;
		try
		{
			if (null == AssetsManager.EHBBFMCILPC || null == AssetsManager.EHBBFMCILPC.lobbyDataAsset)
			{
				result = false;
			}
			else if (!AssetsManager.EHBBFMCILPC.lobbyDataAsset.CDJKGIALFNF())
			{
				result = false;
			}
			else if (!AssetsManager.EHBBFMCILPC.lobbyDataAsset.IBFBCLFBBBJ(LanguageManager.EHBBFMCILPC.GetSelectedLanguage()))
			{
				result = false;
			}
			else
			{
				List<LPJPFJOMGPA> list = AssetsManager.EHBBFMCILPC.lobbyDataAsset.FGLPBJAPBJK().KJLOAEIODFK();
				for (int i = 0; i < list.Count; i++)
				{
					for (int j = 0; j < list[i].JAPFMDOBPKJ.Count; j++)
					{
						if (null != GKJPOGNFKNK.LDFIAOCJEOJ(list[i].JAPFMDOBPKJ[j]))
						{
							return true;
						}
					}
				}
				result = false;
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
			result = false;
		}
		return result;
	}

	// Token: 0x060023BF RID: 9151 RVA: 0x00106018 File Offset: 0x00104218
	private void PDLHBIIGLJD()
	{
		if (AKLFPGMDKLA.EHBBFMCILPC.CBOKIJMGNFH)
		{
			CommonUserInterface.EHBBFMCILPC.HideConnectingAnimation();
			this.GPBDCGNNEBI();
			return;
		}
		if (!AKLFPGMDKLA.EHBBFMCILPC.DHHNMAEABFI())
		{
			AssetsManager.EHBBFMCILPC.CleanupDownloadQueue();
			CommonUserInterface.EHBBFMCILPC.HideConnectingAnimation();
			SceneOnboardingManager.startAtStep = 0;
			CommonUserInterface.EHBBFMCILPC.GetFader().FadeIn(new TweenCallback(this.MBINGGKGNGM));
			return;
		}
		if (null != AssetsManager.EHBBFMCILPC.profileDataAsset)
		{
			AssetsManager.EHBBFMCILPC.profileDataAsset.CMPFJLLGKCC();
		}
		if (AssetsManager.EHBBFMCILPC.AssetBundleManagerHasBeenReset() || SceneLobbyManager2.LIDGNAFABAH)
		{
			OKJHCOIKEJA.IJHHMHAEKKE();
			DPPMPNEOPNF.IJHHMHAEKKE();
			EELCJOKFHHC.IJHHMHAEKKE();
			PBIBIOOCDKF.IJHHMHAEKKE();
			FANFNBCJJDA.EHBBFMCILPC.IJHHMHAEKKE();
			AssetsManager.EHBBFMCILPC.DestroyAssetBundleAssets(NMKDCBPMCKI.AssetBundleAnthologyAvatar, -1);
			AssetsManager.EHBBFMCILPC.DestroyAssetBundleAssets(NMKDCBPMCKI.AssetBundleAnthologyLounge, -1);
			AssetsManager.EHBBFMCILPC.DestroyAssetBundleAssets(NMKDCBPMCKI.AssetBundleAnthologyReward, -1);
			AssetsManager.EHBBFMCILPC.DestroyAssetBundleAssets(NMKDCBPMCKI.AssetBundleAvatarExtensionPack, -1);
			AssetsManager.EHBBFMCILPC.DestroyAssetBundleAssets(NMKDCBPMCKI.AssetBundleAvatarPack, -1);
			AssetsManager.EHBBFMCILPC.DestroyAssetBundleAssets(NMKDCBPMCKI.AssetBundleKeepAlivePack, -1);
			AssetsManager.EHBBFMCILPC.DestroyAssetBundleAssets(NMKDCBPMCKI.AssetBundleStory, -1);
			AssetsManager.EHBBFMCILPC.DestroyAssetBundleAssets(NMKDCBPMCKI.AssetBundleStoryAssetPack, -1);
			AssetsManager.EHBBFMCILPC.DestroyAssetBundleAssets(NMKDCBPMCKI.AssetBundleStorySplash, -1);
			AssetsManager.EHBBFMCILPC.DestroyAssetBundleAssets(NMKDCBPMCKI.AssetBundleCutsceneView, -1);
			AssetsManager.EHBBFMCILPC.DestroyAssetBundleAssets(NMKDCBPMCKI.AssetBundleSketchView, -1);
			AssetsManager.EHBBFMCILPC.DestroyAssetBundleAssets(NMKDCBPMCKI.AssetBundleProfilePack, -1);
			AssetsManager.EHBBFMCILPC.DestroyAssetBundleAssets(NMKDCBPMCKI.AssetBundleLiveProfileTheme, -1);
			AssetsManager.EHBBFMCILPC.DestroyAssetBundleAssets(NMKDCBPMCKI.AssetBundleProfileData6, -1);
			AssetsManager.EHBBFMCILPC.DestroyAssetBundleAssets(NMKDCBPMCKI.AssetBundleCustomFader, -1);
			AssetsManager.EHBBFMCILPC.DestroyAssetBundleAssets(NMKDCBPMCKI.AssetBundleCustomEffects, -1);
			AssetsManager.EHBBFMCILPC.DestroyAssetBundleAssets(NMKDCBPMCKI.AssetBundleNpcAnimationPack, -1);
			AssetsManager.EHBBFMCILPC.DestroyAssetBundleAssets(NMKDCBPMCKI.AssetBundleItemAnimationPack, -1);
			AssetsManager.EHBBFMCILPC.DestroyAssetBundleAssets(NMKDCBPMCKI.AssetBundleFrameContainer, -1);
			AssetsManager.EHBBFMCILPC.DestroyAssetBundleAssets(NMKDCBPMCKI.AssetBundleLobbyData2, -1);
			AssetsManager.EHBBFMCILPC.DestroyAssetBundleAssets(NMKDCBPMCKI.AssetBundleProfileData, -1);
			AssetsManager.EHBBFMCILPC.DestroyAssetBundleAssets(NMKDCBPMCKI.AssetBundleProfileData2, -1);
			AssetsManager.EHBBFMCILPC.DestroyAssetBundleAssets(NMKDCBPMCKI.AssetBundleProfileData3, -1);
			AssetsManager.EHBBFMCILPC.DestroyAssetBundleAssets(NMKDCBPMCKI.AssetBundleProfileData4, -1);
			AssetsManager.EHBBFMCILPC.DestroyAssetBundleAssets(NMKDCBPMCKI.AssetBundleProfileData5, -1);
			AssetsManager.EHBBFMCILPC.DestroyAssetBundleAssets(NMKDCBPMCKI.AssetBundleProfileDataLocalized, -1);
			AssetsManager.EHBBFMCILPC.DestroyAssetBundleAssets(NMKDCBPMCKI.AssetBundleAnthologyPreview2, -1);
			AssetsManager.EHBBFMCILPC.DestroyAssetBundleAssets(NMKDCBPMCKI.AssetBundleLiveEventContent, -1);
			AssetsManager.EHBBFMCILPC.DestroyAssetBundleAssets(NMKDCBPMCKI.AssetBundleCollectableCard, -1);
			AssetsManager.EHBBFMCILPC.DestroyAssetBundleAssets(NMKDCBPMCKI.AssetBundleLiveOfferContent, -1);
			AssetsManager.EHBBFMCILPC.DestroyAssetBundleAssets(NMKDCBPMCKI.AssetBundleSketchThumbnail, -1);
			AssetsManager.EHBBFMCILPC.DestroyAssetBundleAssets(NMKDCBPMCKI.AssetBundleSketchActors, -1);
			AssetsManager.EHBBFMCILPC.DestroyAssetBundleAssets(NMKDCBPMCKI.AssetBundleIconsPack, -1);
			AssetsManager.EHBBFMCILPC.DestroyAssetBundleAssets(NMKDCBPMCKI.AssetBundlePurchasingView, -1);
			AssetsManager.EHBBFMCILPC.DestroyAssetBundleAssets(NMKDCBPMCKI.AssetBundleHeadersPack, -1);
			MLIBDDCCKBM.IJHHMHAEKKE();
			AssetsManager.EHBBFMCILPC.DestroyAssetBundleAssets(NMKDCBPMCKI.AssetBundleHeadersPack2, -1);
			AssetsManager.EHBBFMCILPC.DestroyAssetBundleAssets(NMKDCBPMCKI.AssetBundleLobbyData, -1);
			AssetsManager.EHBBFMCILPC.DestroyAssetBundleAssets(NMKDCBPMCKI.AssetBundleSketchesData, -1);
			AssetsManager.EHBBFMCILPC.DestroyAssetBundleAssets(NMKDCBPMCKI.AssetBundleTextPack, -1);
		}
		else
		{
			AssetsManager.EHBBFMCILPC.DestroyAssetBundleAssets(NMKDCBPMCKI.AssetBundleAnthologyAvatar, -1);
			AssetsManager.EHBBFMCILPC.DestroyAssetBundleAssets(NMKDCBPMCKI.AssetBundleAnthologyLounge, -1);
			AssetsManager.EHBBFMCILPC.DestroyAssetBundleAssets(NMKDCBPMCKI.AssetBundleAnthologyReward, -1);
			AssetsManager.EHBBFMCILPC.DestroyAssetBundleAssets(NMKDCBPMCKI.AssetBundleAvatarExtensionPack, -1);
			AssetsManager.EHBBFMCILPC.DestroyAssetBundleAssets(NMKDCBPMCKI.AssetBundleAvatarPack, -1);
			AssetsManager.EHBBFMCILPC.DestroyAssetBundleAssets(NMKDCBPMCKI.AssetBundleKeepAlivePack, -1);
			AssetsManager.EHBBFMCILPC.DestroyAssetBundleAssets(NMKDCBPMCKI.AssetBundleStory, -1);
			AssetsManager.EHBBFMCILPC.DestroyAssetBundleAssets(NMKDCBPMCKI.AssetBundleStoryAssetPack, -1);
			AssetsManager.EHBBFMCILPC.DestroyAssetBundleAssets(NMKDCBPMCKI.AssetBundleStorySplash, -1);
			AssetsManager.EHBBFMCILPC.DestroyAssetBundleAssets(NMKDCBPMCKI.AssetBundleCutsceneView, -1);
			AssetsManager.EHBBFMCILPC.DestroyAssetBundleAssets(NMKDCBPMCKI.AssetBundleSketchView, -1);
			AssetsManager.EHBBFMCILPC.DestroyAssetBundleAssets(NMKDCBPMCKI.AssetBundleProfilePack, -1);
			AssetsManager.EHBBFMCILPC.DestroyAssetBundleAssets(NMKDCBPMCKI.AssetBundleLiveProfileTheme, -1);
			AssetsManager.EHBBFMCILPC.DestroyAssetBundleAssets(NMKDCBPMCKI.AssetBundleProfileData6, -1);
			AssetsManager.EHBBFMCILPC.DestroyAssetBundleAssets(NMKDCBPMCKI.AssetBundleCustomFader, -1);
			AssetsManager.EHBBFMCILPC.DestroyAssetBundleAssets(NMKDCBPMCKI.AssetBundleCustomEffects, -1);
			AssetsManager.EHBBFMCILPC.DestroyAssetBundleAssets(NMKDCBPMCKI.AssetBundleNpcAnimationPack, -1);
			AssetsManager.EHBBFMCILPC.DestroyAssetBundleAssets(NMKDCBPMCKI.AssetBundleItemAnimationPack, -1);
			AssetsManager.EHBBFMCILPC.DestroyAssetBundleAssets(NMKDCBPMCKI.AssetBundleFrameContainer, -1);
			AssetsManager.EHBBFMCILPC.DestroyAssetBundleAssets(NMKDCBPMCKI.AssetBundleLobbyData2, -1);
			AssetsManager.EHBBFMCILPC.DestroyAssetBundleAssets(NMKDCBPMCKI.AssetBundleCollectableCard, -1);
			AssetsManager.EHBBFMCILPC.DestroyAssetBundleAssets(NMKDCBPMCKI.AssetBundleLiveOfferContent, -1);
			AssetsManager.EHBBFMCILPC.DestroyAssetBundleAssets(NMKDCBPMCKI.AssetBundleSketchThumbnail, -1);
			AssetsManager.EHBBFMCILPC.DestroyAssetBundleAssets(NMKDCBPMCKI.AssetBundleSketchActors, -1);
			if (!KHPGPLAMAIN.CNFPCHNGKPB())
			{
				AssetsManager.EHBBFMCILPC.DestroyAssetBundleAssets(NMKDCBPMCKI.AssetBundleProfileData2, -1);
				AssetsManager.EHBBFMCILPC.DestroyAssetBundleAssets(NMKDCBPMCKI.AssetBundleProfileData3, -1);
				AssetsManager.EHBBFMCILPC.DestroyAssetBundleAssets(NMKDCBPMCKI.AssetBundleProfileData4, -1);
				AssetsManager.EHBBFMCILPC.DestroyAssetBundleAssets(NMKDCBPMCKI.AssetBundleProfileData5, -1);
				AssetsManager.EHBBFMCILPC.DestroyAssetBundleAssets(NMKDCBPMCKI.AssetBundleProfileDataLocalized, -1);
				AssetsManager.EHBBFMCILPC.DestroyAssetBundleAssets(NMKDCBPMCKI.AssetBundleAnthologyPreview2, -1);
				AssetsManager.EHBBFMCILPC.DestroyAssetBundleAssets(NMKDCBPMCKI.AssetBundleLiveEventContent, -1);
				AssetsManager.EHBBFMCILPC.DestroyAssetBundleAssets(NMKDCBPMCKI.AssetBundleIconsPack, -1);
			}
		}
		SceneLobbyManager2.LIDGNAFABAH = false;
		if (this.PGFANABDIBK && SceneLobbyManager2.startPlayChapterBackendOperationResult < 0)
		{
			AKLFPGMDKLA.EHBBFMCILPC.IEGJCPDCLMM = -1;
			this.PLJLNEAKFDK = EJDDNONEDNM.stayInLobby;
		}
		if (AKLFPGMDKLA.EHBBFMCILPC.MLLOENOIKGA)
		{
			CommonUserInterface.EHBBFMCILPC.HideConnectingAnimation();
			if (AKLFPGMDKLA.EHBBFMCILPC.BNGHKCHKMPB > 0)
			{
				string text = CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("accountsuspended4");
				text = text.Replace("XXX", AKLFPGMDKLA.EHBBFMCILPC.OMMACPBIHDN(AKLFPGMDKLA.EHBBFMCILPC.EEHGLPEIIHD));
				text = text.Replace("YYY", AKLFPGMDKLA.EHBBFMCILPC.GKJIAEHDBNM().ToString() ?? "");
				CommonUserInterface.EHBBFMCILPC.ShowGenericPopupTwoOverride(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("importanttitle"), text, CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("copyuidbtn"), new UnityAction(this.JDFKJADDMAN), new UnityAction(this.JDFKJADDMAN), DFGILFBGPLN.popupAccountSuspended, 0f, 28);
				return;
			}
			if (AKLFPGMDKLA.EHBBFMCILPC.NHBLMCJBLAC == 1)
			{
				string text2 = CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("accountsuspended5");
				text2 = text2.Replace("XXX", AKLFPGMDKLA.EHBBFMCILPC.OMMACPBIHDN(AKLFPGMDKLA.EHBBFMCILPC.EEHGLPEIIHD));
				CommonUserInterface.EHBBFMCILPC.ShowGenericPopupTwoOverride(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("importanttitle"), text2, CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("copyuidbtn"), new UnityAction(this.JDFKJADDMAN), new UnityAction(this.JDFKJADDMAN), DFGILFBGPLN.popupAccountSuspended, 0f, 28);
				return;
			}
			string text3 = CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("accountsuspended3");
			text3 = text3.Replace("XXX", AKLFPGMDKLA.EHBBFMCILPC.OMMACPBIHDN(AKLFPGMDKLA.EHBBFMCILPC.EEHGLPEIIHD));
			CommonUserInterface.EHBBFMCILPC.ShowGenericPopupTwoOverride(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("importanttitle"), text3, CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("copyuidbtn"), new UnityAction(this.JDFKJADDMAN), new UnityAction(this.JDFKJADDMAN), DFGILFBGPLN.popupAccountSuspended, 0f, 28);
			return;
		}
		else
		{
			if (AKLFPGMDKLA.EHBBFMCILPC.NNEFJNGKJMK >= 0 && AppManager.EHBBFMCILPC.UnsupportedRevision(AKLFPGMDKLA.EHBBFMCILPC.NNEFJNGKJMK))
			{
				CommonUserInterface.EHBBFMCILPC.HideConnectingAnimation();
				CommonUserInterface.EHBBFMCILPC.ShowGenericPopupTwoOverride(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("importanttitle"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("outdatedrev"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("ok"), new UnityAction(this.DPEDKLLEABO), new UnityAction(this.DPEDKLLEABO), DFGILFBGPLN.popupOutdatedRevision, 0f, 28);
				return;
			}
			if (AKLFPGMDKLA.EHBBFMCILPC.OHLMJHHMDJF >= 0 && AKLFPGMDKLA.EHBBFMCILPC.PCMNOPFHKDJ >= 0 && AppManager.EHBBFMCILPC.UpdateAvailable(AKLFPGMDKLA.EHBBFMCILPC.OHLMJHHMDJF))
			{
				CommonUserInterface.EHBBFMCILPC.ShowGenericPopupWithTwoButtons(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("importanttitle"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("updateavailable" + AKLFPGMDKLA.EHBBFMCILPC.PCMNOPFHKDJ.ToString()), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("ok"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("later"), new UnityAction(this.GDCKODKFEMP), new UnityAction(this.PNLFGEDGLPE), DFGILFBGPLN.popupStoreUpdateAvailable, 0f, 28);
				return;
			}
			this.PNLFGEDGLPE();
			return;
		}
	}

	// Token: 0x060023C0 RID: 9152 RVA: 0x001034D7 File Offset: 0x001016D7
	private void MPLJEMEGMKA()
	{
		CommonUserInterface.EHBBFMCILPC.FreezeUX();
		CommonUserInterface.EHBBFMCILPC.GetFader().FadeIn(new TweenCallback(this.MKAPABLPCIM));
	}

	// Token: 0x060023C1 RID: 9153 RVA: 0x001067B4 File Offset: 0x001049B4
	private void HAPJNANNGPL()
	{
		try
		{
			if (this.FDMGKEAHGFK())
			{
				this.BCOOKJICILK((JBBNEEHANHL)79);
				this.scrollView2Controller.SetItemOnCenterImmediate(this.FIBKHPMLNJN.transform);
			}
			else
			{
				this.ONBPCOOBOFB((JBBNEEHANHL)49);
			}
			this.LHHMOOBDGGO();
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
	}

	// Token: 0x060023C2 RID: 9154 RVA: 0x00106810 File Offset: 0x00104A10
	private void PNLFGEDGLPE()
	{
		if (AKLFPGMDKLA.EHBBFMCILPC.HCEHBFCIIHN() < 1 && 1 == AKLFPGMDKLA.EHBBFMCILPC.MJPKIMHENNF)
		{
			FirebaseAnalyticsManager.EHBBFMCILPC.LogEvent(true, AGEHCPDNBFD.d1Ret.ToString(), FFPHBMFGCNN.d1Board.ToString(), BGHLMGPPCNN.d1CdnSt.ToString(), true, false);
		}
		AKLFPGMDKLA.EHBBFMCILPC.MDMPJINECJD();
		FirebaseAnalyticsManager.EHBBFMCILPC.LogEvent(false, AGEHCPDNBFD.cdnActiv.ToString(), FFPHBMFGCNN.dldStart.ToString(), BGHLMGPPCNN.cdnLbyLoadPt1.ToString(), false, false);
		if (AssetsManager.EHBBFMCILPC.CacheCleanScheduled())
		{
			CommonUserInterface.EHBBFMCILPC.ShowConnectingAnimation(0);
		}
		else if (SceneLobbyManager2.MMICAAKCHBJ > 0)
		{
			if (KHPGPLAMAIN.CNFPCHNGKPB() && !AssetsManager.EHBBFMCILPC.AssetBundleManagerHasBeenReset() && AssetsManager.EHBBFMCILPC.LobbyAssetsLoaded())
			{
				CommonUserInterface.EHBBFMCILPC.ShowConnectingAnimationWithHint(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("hintloading"), 0);
			}
			else
			{
				CommonUserInterface.EHBBFMCILPC.ShowConnectingAnimationWithProgress(0);
			}
		}
		else
		{
			CommonUserInterface.EHBBFMCILPC.ShowConnectingAnimationWithProgress(0);
		}
		if (SceneLobbyManager2.selectedFirstStoryOffering >= 0)
		{
			AssetsManager.EHBBFMCILPC.GetLoadingProgressSnapshot().GIJKJMMDJEL(0f, 0.25f);
		}
		else
		{
			AssetsManager.EHBBFMCILPC.GetLoadingProgressSnapshot().GIJKJMMDJEL(0f, 0.2f);
		}
		AssetsManager.EHBBFMCILPC.DownloadQueuedAssetBundles("OnSceneLobbyManagerRound0AssetsDownloadSuccess", "OnSceneLobbyManagerAssetsDownloadFailed", false);
	}

	// Token: 0x060023C3 RID: 9155 RVA: 0x0010697C File Offset: 0x00104B7C
	private void PAOLDGBPFFN()
	{
		this.DCFBAMCJCFK += 0;
		if (this.DCFBAMCJCFK >= KBOJLHAJPCP.INALBGFGEAP)
		{
			CommonUserInterface.IKNOFBFMPGA().MCJIGJMFBMI();
			FirebaseAnalyticsManager.DMAAFFFEJGA().LogEvent(false, AGEHCPDNBFD.rqst.ToString(), ((FFPHBMFGCNN)104).ToString(), BGHLMGPPCNN.mntOfferClose.ToString(), false, true);
			this.DCFBAMCJCFK = 0;
			CommonUserInterface.IKNOFBFMPGA().ShowGenericPopupTwoOverride(CCOJBMMKNAP.DLGLFACMHPG().HPOAGPJFHPM("{tk}"), CCOJBMMKNAP.PKEINLPIAEH().FIENAKIHNOM("OnAvatarScreenAssetBundleFolderInitializeSuccess"), CCOJBMMKNAP.CPCOODCFDDP().OHLNGCKIACD("tutorialsigninrec"), new UnityAction(this.BIHAHOCIDKK), new UnityAction(this.BIHAHOCIDKK), (DFGILFBGPLN)88, 1768f, -45);
			return;
		}
		base.StartCoroutine(this.DIIMKKCDBAI());
	}

	// Token: 0x060023C4 RID: 9156 RVA: 0x000F668A File Offset: 0x000F488A
	private void CHAKGJICCJG()
	{
		this.ALGIAIKDEPH();
	}

	// Token: 0x060023C5 RID: 9157 RVA: 0x00106A5C File Offset: 0x00104C5C
	private void OHNOJBCDJKI()
	{
		try
		{
			if (null == this.lobbySearchBar)
			{
				SceneLobbyManager2.KAFNANCDMNF = null;
			}
			else
			{
				bool flag = !KDCJJBLGCBH.EHBBFMCILPC.GNGCDGBAALO() && MLIBDDCCKBM.FACIFBONANM();
				this.lobbySearchBar.gameObject.SetActive(flag);
				if (null != this.scrollView2Controller.extraFixedContent)
				{
					this.scrollView2Controller.extraFixedContent.gameObject.SetActive(flag);
				}
				if (!flag)
				{
					SceneLobbyManager2.KAFNANCDMNF = null;
				}
				else
				{
					this.lobbySearchBar.Initialize(new UnityAction(this.OnSearchQueryStarted), new Func<string, int>(this.RunStorySearch), new UnityAction(this.OnSearchClear), new UnityAction(this.OnSearchFocusClosed), new UnityAction(this.MKCOIMBDHIF));
					if (!string.IsNullOrEmpty(SceneLobbyManager2.KAFNANCDMNF))
					{
						if (this.EGNDHGMJJJL != null)
						{
							base.StopCoroutine(this.EGNDHGMJJJL);
							this.EGNDHGMJJJL = null;
						}
						this.EGNDHGMJJJL = base.StartCoroutine(this.BPHOMBLHPEH());
					}
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x060023C6 RID: 9158 RVA: 0x000F4D00 File Offset: 0x000F2F00
	private void KIFPEADFOOJ()
	{
		this.LAENHLLONAI = 0;
	}

	// Token: 0x060023C7 RID: 9159 RVA: 0x00106B78 File Offset: 0x00104D78
	private JBBNEEHANHL GINJCMEHKLO()
	{
		JBBNEEHANHL jbbneehanhl = this.FJDGIHGJHOI();
		if (!this.CLEMDBANFDE(jbbneehanhl))
		{
			jbbneehanhl = this.DJMKGHMPMPP();
		}
		return jbbneehanhl;
	}

	// Token: 0x060023C8 RID: 9160 RVA: 0x00106BA0 File Offset: 0x00104DA0
	private int NHCNNBNPPMG(HAKFHALKMBH PIEEFOHHDKO, int CMBCNMLGPPC)
	{
		int num = 0;
		try
		{
			if (PIEEFOHHDKO == null || null == PIEEFOHHDKO.NHOAHJMPCFC)
			{
				return 0;
			}
			GameObject gameObject = Resources.Load<GameObject>("CoverCard");
			if (null == gameObject)
			{
				return 0;
			}
			RectTransform component = PIEEFOHHDKO.NHOAHJMPCFC.GetComponent<RectTransform>();
			float num2 = component.rect.height;
			this.LBHJBEANCDC();
			while (num < CMBCNMLGPPC && PIEEFOHHDKO.CKBJGCFCHGA < PIEEFOHHDKO.LGIAOIGIGPI.Count)
			{
				int ckbjgcfchga = PIEEFOHHDKO.CKBJGCFCHGA;
				KLJCEMBNKNI kljcembnkni = PIEEFOHHDKO.LGIAOIGIGPI[ckbjgcfchga];
				PIEEFOHHDKO.CKBJGCFCHGA++;
				if (kljcembnkni != null)
				{
					string hjejjgafham = "";
					string mchooehcanp = "";
					if (!this.KBDAFKOEDCK(kljcembnkni, out hjejjgafham, out mchooehcanp))
					{
						DPGJIJGOCIC.ADFCDFHBDAF(string.Concat(new string[]
						{
							"SceneLobbyManager2.AppendGroupBatch() - ",
							PIEEFOHHDKO.GLOCCAIDHJC.ToString(),
							" group ",
							ckbjgcfchga.ToString(),
							" (",
							kljcembnkni.MHCFDMNGOEF,
							kljcembnkni.IEJLOIMDPDO,
							" fid ",
							kljcembnkni.KCIODOKEDAM.ToString(),
							") has no cover name, group skipped"
						}));
					}
					else
					{
						GameObject gameObject2 = UnityEngine.Object.Instantiate<GameObject>(this.smallItemParentPrefab, PIEEFOHHDKO.NHOAHJMPCFC.transform);
						gameObject2.layer = PIEEFOHHDKO.NHOAHJMPCFC.layer;
						GridController component2 = gameObject2.GetComponent<GridController>();
						component2.filter = PIEEFOHHDKO.GLOCCAIDHJC;
						GameObject gameObject3 = UnityEngine.Object.Instantiate<GameObject>(gameObject, gameObject2.transform);
						gameObject3.layer = PIEEFOHHDKO.NHOAHJMPCFC.layer;
						for (int i = 0; i < kljcembnkni.JAPFMDOBPKJ.Count; i++)
						{
							int num3 = kljcembnkni.JAPFMDOBPKJ[i];
							if (!(null == GKJPOGNFKNK.LDFIAOCJEOJ(num3)))
							{
								this.LHGBCPLGLDB(num3, gameObject2, PIEEFOHHDKO.GLOCCAIDHJC);
								if (kljcembnkni.FKBCEMFCBOG)
								{
									ThumbnailItem component3 = gameObject2.transform.GetChild(gameObject2.transform.childCount - 1).GetComponent<ThumbnailItem>();
									if (null != component3)
									{
										component3.SetPopularNumber(gameObject2.transform.childCount - 2);
									}
								}
							}
						}
						int num4 = gameObject2.transform.childCount - 1;
						if (num4 < 1 || num4 < kljcembnkni.CDEAAKHGKIF)
						{
							for (int j = this.GMGKODLANOP.Count - 1; j >= 0; j--)
							{
								if (null == this.GMGKODLANOP[j] || this.GMGKODLANOP[j].transform.IsChildOf(gameObject2.transform))
								{
									this.GMGKODLANOP.RemoveAt(j);
								}
							}
							gameObject2.SetActive(false);
							gameObject2.transform.SetParent(null, false);
							UnityEngine.Object.Destroy(gameObject2);
						}
						else
						{
							component2.UpdateGrid();
							float gridHeight = component2.GetGridHeight();
							gameObject2.GetComponent<RectTransform>().ACBKFBBCNNC(gridHeight);
							LayoutRebuilder.ForceRebuildLayoutImmediate(gameObject2.GetComponent<RectTransform>());
							if (kljcembnkni.HPJNLEBDMEP == KLMEAFCEKOI.coverTextClient && kljcembnkni.JAIGAGGAGFE > 0 && num4 != kljcembnkni.JAIGAGGAGFE && kljcembnkni.IHIDEHKNBBH)
							{
								kljcembnkni.JAIGAGGAGFE = num4;
								this.KBDAFKOEDCK(kljcembnkni, out hjejjgafham, out mchooehcanp);
							}
							int cmbcnmlgppc = -1;
							if (kljcembnkni.BLKPIAEAANG)
							{
								cmbcnmlgppc = num4;
							}
							CoverCardItem component4 = gameObject3.GetComponent<CoverCardItem>();
							component4.SetCover(ckbjgcfchga, hjejjgafham, mchooehcanp, cmbcnmlgppc, this.HDBMEAPNFPK(kljcembnkni.OGKIINMNBLH), GKJPOGNFKNK.MIICMJEIPIK(kljcembnkni.AEGIBKHFEOF));
							PIEEFOHHDKO.BGKBLIAAFCK.Add(component4);
							num2 += gridHeight;
							num++;
						}
					}
				}
			}
			component.ACBKFBBCNNC(num2);
			if (num > 0)
			{
				DPGJIJGOCIC.NFIDPOMCNLP(string.Concat(new string[]
				{
					"SceneLobbyManager2.AppendGroupBatch() - ",
					PIEEFOHHDKO.GLOCCAIDHJC.ToString(),
					": ",
					num.ToString(),
					" group(s) built, ",
					PIEEFOHHDKO.CKBJGCFCHGA.ToString(),
					" of ",
					PIEEFOHHDKO.LGIAOIGIGPI.Count.ToString(),
					" spec(s) consumed, height ",
					num2.ToString()
				}));
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
		return num;
	}

	// Token: 0x060023C9 RID: 9161 RVA: 0x00107008 File Offset: 0x00105208
	private void JNCJEGFNCCP()
	{
		if (this.FGDEGMOLIDB && LJNMIPMNOKF.EHBBFMCILPC.IHOIGNLKNDA())
		{
			DPGJIJGOCIC.ADFCDFHBDAF("SceneLobbyManager2.OnAllCollectableCardsDownloadFailedLobby(): the pool run failed but the scroll index card is resident, showing");
			this.ShowCardOptionsOrDownload();
			return;
		}
		this.CDJGGOJBGJF++;
		if (this.CDJGGOJBGJF >= KBOJLHAJPCP.LPJOFEDNKHA)
		{
			CommonUserInterface.EHBBFMCILPC.HideConnectingAnimation();
			CommonUserInterface.EHBBFMCILPC.HideGenericPopupNoButtons();
			FirebaseAnalyticsManager.EHBBFMCILPC.LogEvent(false, AGEHCPDNBFD.cdnActiv.ToString(), FFPHBMFGCNN.dldFail.ToString(), BGHLMGPPCNN.cdnPrfToCrd.ToString(), false, false);
			this.CDJGGOJBGJF = 0;
			CommonUserInterface.EHBBFMCILPC.ShowGenericPopupTwoOverride(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("errortitle"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("cdnerror"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("retry"), new UnityAction(this.ShowCardOptionsOrDownload), new UnityAction(this.HIODKHCOJOE), DFGILFBGPLN.popupCdnDownloadFailed, 0f, 28);
			this.GBBHKFFENBE = false;
			return;
		}
		this.ShowCardOptionsOrDownload();
	}

	// Token: 0x060023CA RID: 9162 RVA: 0x00107118 File Offset: 0x00105318
	private void AEGIFDILJDP()
	{
		try
		{
			for (int i = 0; i < this.AAHJNGODNKI.Count; i++)
			{
				HAKFHALKMBH hakfhalkmbh = this.AAHJNGODNKI[i];
				if (hakfhalkmbh != null && !(null == hakfhalkmbh.NHOAHJMPCFC))
				{
					for (int j = 0; j < hakfhalkmbh.BGKBLIAAFCK.Count; j++)
					{
						CoverCardItem coverCardItem = hakfhalkmbh.BGKBLIAAFCK[j];
						if (!(null == coverCardItem))
						{
							int groupIndex = coverCardItem.GetGroupIndex();
							if (groupIndex >= 0 && groupIndex < hakfhalkmbh.LGIAOIGIGPI.Count)
							{
								string hjejjgafham = "";
								string mchooehcanp = "";
								if (this.KBDAFKOEDCK(hakfhalkmbh.LGIAOIGIGPI[groupIndex], out hjejjgafham, out mchooehcanp))
								{
									coverCardItem.SetCoverTexts(hjejjgafham, mchooehcanp);
								}
							}
						}
					}
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x060023CB RID: 9163 RVA: 0x001071F4 File Offset: 0x001053F4
	private void KCAFGDAIDLG(ThumbnailItem LFOLNLDPKHO, int PLKMJJIIJNO)
	{
		try
		{
			if (!(null == LFOLNLDPKHO))
			{
				string[] agpmobfclfk = null;
				int highdddhkcd = -1;
				this.IIDEKJNAFKG.TryGetValue(PLKMJJIIJNO, out agpmobfclfk);
				if (!this.NODBJCOJNLJ.TryGetValue(PLKMJJIIJNO, out highdddhkcd))
				{
					highdddhkcd = -1;
				}
				LFOLNLDPKHO.SetSearchMatch(agpmobfclfk, highdddhkcd);
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x060023CC RID: 9164 RVA: 0x00107254 File Offset: 0x00105454
	private void PKIGIFGLAMB()
	{
		CommonUserInterface.IKNOFBFMPGA().HideConnectingAnimation();
		this.CPLLGNAKIIL(this.LGKGGPDKAHF);
		if (null != this.LGKGGPDKAHF)
		{
			this.ONGICLLGJGO(this.LGKGGPDKAHF.index);
		}
		base.StartCoroutine(this.NAJEFKOKLKJ());
	}

	// Token: 0x060023CD RID: 9165 RVA: 0x000EE3CA File Offset: 0x000EC5CA
	private void GOAEKMDPMEA()
	{
		base.StartCoroutine(this.MJCAENEALOP());
	}

	// Token: 0x060023CE RID: 9166 RVA: 0x000F46A8 File Offset: 0x000F28A8
	[CompilerGenerated]
	private void PPPMPCJNKNB(JBBNEEHANHL AJLPALFJHCC)
	{
		this.BCOOKJICILK(AJLPALFJHCC);
	}

	// Token: 0x060023CF RID: 9167 RVA: 0x001072A4 File Offset: 0x001054A4
	public void RestartStory()
	{
		this.HideStoryRestartPopup();
		this.GKHNIMJJLJL.EPJKDCDOEMM(true);
		if (null != this.HFFIIBBJBMH)
		{
			for (int i = 0; i < this.HFFIIBBJBMH.header.availableStories.Count; i++)
			{
				if (this.HFFIIBBJBMH.header.availableStories[i] == AKLFPGMDKLA.EHBBFMCILPC.GLKNOFHEBKN)
				{
					int num = AKLFPGMDKLA.EHBBFMCILPC.LMGMHHLLOFN(this.HFFIIBBJBMH.header.index).EGHHCFFLPCP(-1);
					for (int j = i + 1; j <= num; j++)
					{
						if (j < this.HFFIIBBJBMH.header.availableStories.Count && AKLFPGMDKLA.EHBBFMCILPC.LAEKDOCIMBK(this.HFFIIBBJBMH.header.availableStories[j]))
						{
							AKLFPGMDKLA.EHBBFMCILPC.JDCBFAPDJIM(this.HFFIIBBJBMH.header.availableStories[j], -1).EPJKDCDOEMM(true);
						}
					}
					AKLFPGMDKLA.EHBBFMCILPC.LMGMHHLLOFN(this.HFFIIBBJBMH.header.index).LDPCILACGCO(i, -1);
					break;
				}
			}
		}
		AKLFPGMDKLA.EHBBFMCILPC.BJECGAMNDDH();
		this.EFPDMJBADBB(this.LGKGGPDKAHF);
		this.OnPlayClickStart();
	}

	// Token: 0x060023D0 RID: 9168 RVA: 0x001073F0 File Offset: 0x001055F0
	private void DHGGEFIJBHM()
	{
		try
		{
			int num = AOBJLALDBAA.EHBBFMCILPC.MJLACDOKGNE();
			if (num >= 0)
			{
				this.IHIHDNNPBKA = num;
			}
			else if (num == -1)
			{
				this.socialEventCounterObject.gameObject.SetActive(false);
			}
			else if (num == -2)
			{
				this.socialEventCounterObject.gameObject.SetActive(true);
			}
			else
			{
				this.socialEventCounterObject.gameObject.SetActive(false);
			}
			if (this.IHIHDNNPBKA == 0)
			{
				this.socialEventCounterObject.gameObject.SetActive(false);
			}
			else
			{
				this.socialEventCounterObject.gameObject.SetActive(true);
				this.socialEventCounterObjectText.text = (this.IHIHDNNPBKA.ToString() ?? "");
				this.socialEventCounterObjectText.SetText(this.IHIHDNNPBKA.ToString() ?? "", true);
			}
		}
		catch (Exception aklgbjkdomm)
		{
			this.IHIHDNNPBKA = 0;
			this.socialEventCounterObject.gameObject.SetActive(false);
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x060023D1 RID: 9169 RVA: 0x001074F4 File Offset: 0x001056F4
	private void JLOOIHODNJO(int PLKMJJIIJNO, List<string> ILLICMIMLAA)
	{
		ILLICMIMLAA.Clear();
		IJLJDFKJIJM ijljdfkjijm = HKLPEDKJGFC.BBEPEBHNNGE(PLKMJJIIJNO);
		if (ijljdfkjijm == null)
		{
			return;
		}
		JBBNEEHANHL[] array = new JBBNEEHANHL[]
		{
			ijljdfkjijm.MGDAFCPCOFH,
			ijljdfkjijm.HLEHGFIIEJN,
			ijljdfkjijm.BFJKEJLJAIH
		};
		for (int i = 0; i < array.Length; i++)
		{
			if (JBBNEEHANHL.filterNone != array[i] && JBBNEEHANHL.filterSearch != array[i] && JBBNEEHANHL.newFilterLgbtq != array[i])
			{
				this.ABOLIKOEIDM(ILLICMIMLAA, CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP(array[i].ToString()));
			}
		}
	}

	// Token: 0x060023D2 RID: 9170 RVA: 0x00107579 File Offset: 0x00105779
	private void LMIMBBPADKE()
	{
		if (this.ENJMJIPADNO != null)
		{
			RewardOption.dailyRewardFireTime = (int)this.ENJMJIPADNO.ODHBINFKIPL();
			return;
		}
		RewardOption.dailyRewardFireTime = 86400;
	}

	// Token: 0x060023D3 RID: 9171 RVA: 0x0010759F File Offset: 0x0010579F
	private void MNJNCFPELEC()
	{
		CommonUserInterface.EHBBFMCILPC.HideConnectingAnimation();
		this.LIDPKKFBNMC = 0;
		this.OpenSketchesFinal();
		this.GBBHKFFENBE = false;
	}

	// Token: 0x060023D4 RID: 9172 RVA: 0x001075C0 File Offset: 0x001057C0
	public void OnSkinShopClick()
	{
		if (!this.PIECGBHMOCB() || !KDCJJBLGCBH.EHBBFMCILPC.NJFAOIDGFGC() || !KKLFGEHAMMC.EHBBFMCILPC.FACIFBONANM())
		{
			this.ONBMOPMOIKI();
			return;
		}
		if (!DHFLKLPKNJG.PDCGKIJCCJI())
		{
			CommonUserInterface.EHBBFMCILPC.ShowGenericPopup(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("importanttitle"), SceneLobbyManager2.FALBDONHAAL("skinshopnoskinslanguage", "skinshopempty"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("ok"), DFGILFBGPLN.popupSignInQuestion, 0f, 28);
			return;
		}
		base.StartCoroutine(this.MDBIBFJMFEL());
	}

	// Token: 0x060023D5 RID: 9173 RVA: 0x000F582A File Offset: 0x000F3A2A
	public void KKHFCJNHAAP()
	{
		CommonUserInterface.EHBBFMCILPC.GetPurchasingViewManager().SetResourcesFilter(JFGBECHLPGI.hardCurrency);
		this.OnCurrencyClick();
	}

	// Token: 0x060023D6 RID: 9174 RVA: 0x0010764C File Offset: 0x0010584C
	private void FDCBDGNPJMG()
	{
		this.focusItem.GetComponent<FocusItem>().CloseFocus();
		if (null != this.LGKGGPDKAHF)
		{
			AOBJLALDBAA.EHBBFMCILPC.EGELHPJBAIC("OnNeedToHideThumbnailTagObject", this.LGKGGPDKAHF.index);
		}
		CommonUserInterface.EHBBFMCILPC.GetFader().FadeOut(new TweenCallback(this.DHFFJJHIHKO));
	}

	// Token: 0x060023D7 RID: 9175 RVA: 0x001076AC File Offset: 0x001058AC
	public void ShowHideSocialFeatures()
	{
		if (KDCJJBLGCBH.EHBBFMCILPC.DJHCAFAEILH())
		{
			this.profileButtonAvailable.gameObject.SetActive(false);
			this.profileButtonHidden.gameObject.SetActive(true);
			return;
		}
		this.profileButtonHidden.gameObject.SetActive(false);
		if (!AKLFPGMDKLA.EHBBFMCILPC.GNLNPMPJPEC())
		{
			this.profileButtonAvailable.gameObject.SetActive(true);
			this.profileButtonOffline.gameObject.SetActive(false);
			return;
		}
		this.profileButtonAvailable.gameObject.SetActive(false);
		this.profileButtonOffline.gameObject.SetActive(true);
	}

	// Token: 0x060023D8 RID: 9176 RVA: 0x000F55CD File Offset: 0x000F37CD
	private IEnumerator BBFOGBLKJCF()
	{
		AssetsManager.EHBBFMCILPC.GetLoadingProgressSnapshot().EPJKDCDOEMM(0);
		CommonUserInterface.EHBBFMCILPC.ShowConnectingAnimationWithProgress(96);
		yield return new WaitForEndOfFrame();
		while (AssetsManager.EHBBFMCILPC.IsBusy())
		{
			DPGJIJGOCIC.NFIDPOMCNLP("SceneLobbyManager2.OpenWheelOfFortuneCdn(): AssetsManager.Instance.IsBusy()");
			yield return new WaitForSeconds(0.05f);
		}
		AssetsManager.EHBBFMCILPC.QueueAssetBundleDownload(NMKDCBPMCKI.AssetBundleProfileData4, 0, -1, FLDBFOADFLH.startDownloadAndProceed, false, false, false, null, -1, false, "", false, false);
		AssetsManager.EHBBFMCILPC.GetLoadingProgressSnapshot().CLIOEOLFFLO(LEJKDNAGDHC.Fast);
		AssetsManager.EHBBFMCILPC.GetLoadingProgressSnapshot().GIJKJMMDJEL(0f, 1f);
		AssetsManager.EHBBFMCILPC.DownloadQueuedAssetBundles("OnLobbyWheelDataCdnSuccess", "OnLobbyWheelDataDataCdnFailed", false);
		yield break;
	}

	// Token: 0x060023D9 RID: 9177 RVA: 0x0010774C File Offset: 0x0010594C
	private int NIHGAACGFHB(PLFDAJJHMKO LFLOCKNKAKC)
	{
		int num = 0;
		this.FLLHKGKNAOK.Clear();
		this.PEFDGDNCHGD.Clear();
		this.DFEMFJJDGML.Clear();
		if (LFLOCKNKAKC == null)
		{
			return 0;
		}
		FJLGCKNOJMJ fjlgcknojmj = AssetsManager.EHBBFMCILPC.lobbyDataAsset.MFMJHIFAOHE().ELDKHHGLNBK(this.HFFIIBBJBMH.header.index);
		if (fjlgcknojmj == null)
		{
			return 0;
		}
		PBFOHLJEMBF icmkgdalkhh = new PBFOHLJEMBF(LFLOCKNKAKC.NCAMFPGMCIG);
		List<int> list = new List<int>();
		for (int i = 0; i < fjlgcknojmj.OINAAMKLNLO.Count; i++)
		{
			if (this.OBKCLKMPKCI || SceneStoryManager.LoungeCharacterInVisitedWardrobes(fjlgcknojmj.OINAAMKLNLO[i], LFLOCKNKAKC))
			{
				bool flag = false;
				GHMINFEGBGN ghminfegbgn = new GHMINFEGBGN();
				ghminfegbgn.KALBADOPCDN = fjlgcknojmj.OINAAMKLNLO[i].KALBADOPCDN;
				ghminfegbgn.OIBGFPEGLME = fjlgcknojmj.OINAAMKLNLO[i].OIBGFPEGLME;
				int j = 0;
				while (j < fjlgcknojmj.OINAAMKLNLO[i].KKEENPEFFBJ.Count)
				{
					ECJCFGAOPHJ ecjcfgaophj = fjlgcknojmj.OINAAMKLNLO[i].KKEENPEFFBJ[j];
					if (this.OBKCLKMPKCI)
					{
						if (SceneStoryManager.LoungeMappingListedInShopMode(ecjcfgaophj))
						{
							goto IL_115;
						}
					}
					else if (SceneStoryManager.LoungeMappingIsEligible(ecjcfgaophj, LFLOCKNKAKC, this.FJOMBPDEMCM, icmkgdalkhh))
					{
						goto IL_115;
					}
					IL_33C:
					j++;
					continue;
					IL_115:
					bool flag2 = null != GKJPOGNFKNK.IAJMHBFGKBA(ecjcfgaophj.IJEEKLNDJGE, "");
					if (ecjcfgaophj.AJPBPJDHFOH <= 0 && !flag2)
					{
						goto IL_33C;
					}
					if (!flag2 && ecjcfgaophj.AJPBPJDHFOH > 0 && !this.HFFIIBBJBMH.header.availableStories.Contains(ecjcfgaophj.AJPBPJDHFOH))
					{
						DPGJIJGOCIC.ADFCDFHBDAF("[Lounge/lobby] look pack eps:" + ecjcfgaophj.AJPBPJDHFOH.ToString() + " is OUTSIDE the anthology's published story family - look not offered: " + ecjcfgaophj.IJEEKLNDJGE);
						goto IL_33C;
					}
					flag = true;
					AFIBCKPKDHB afibckpkdhb = new AFIBCKPKDHB();
					afibckpkdhb.BDIHOCKCCBL = ecjcfgaophj.IJEEKLNDJGE;
					afibckpkdhb.CENMIEOCAMN = ecjcfgaophj.CENMIEOCAMN;
					afibckpkdhb.JCJNJNMPPOK = ecjcfgaophj.JCJNJNMPPOK;
					afibckpkdhb.ENBBONPKHBC = ecjcfgaophj.ENBBONPKHBC;
					afibckpkdhb.KEFMKINFOFA = ecjcfgaophj.KEFMKINFOFA;
					afibckpkdhb.NLCHIGHHAEC = ecjcfgaophj.PBGKGCHMHOP;
					afibckpkdhb.PKJHDFINDHP = ecjcfgaophj.CGKKPPEIFJH;
					afibckpkdhb.MJLAEJCFCEF = SceneStoryManager.LoungeMappingIsLockedPreview(ecjcfgaophj, LFLOCKNKAKC);
					afibckpkdhb.OLAKHHEICKO = ecjcfgaophj.OLAKHHEICKO;
					afibckpkdhb.MDKIKKJNJKK = ecjcfgaophj.MDKIKKJNJKK;
					afibckpkdhb.JNCJNLEAFLG = ecjcfgaophj.JNCJNLEAFLG;
					afibckpkdhb.IENEDGACMMK = ecjcfgaophj.LMEALGJPGDA();
					afibckpkdhb.OBLBNLBFBNI = ecjcfgaophj.OBLBNLBFBNI;
					afibckpkdhb.LOFFJOKOOKD = ecjcfgaophj.LOFFJOKOOKD;
					afibckpkdhb.PODGFLMDBEC = ecjcfgaophj.PODGFLMDBEC;
					afibckpkdhb.CECLJNKHJEE = ecjcfgaophj.CECLJNKHJEE;
					afibckpkdhb.MNBBOAPGCMM = ecjcfgaophj.MNBBOAPGCMM;
					afibckpkdhb.HKLEKGFCMFI = ecjcfgaophj.NIOGHOKEKDI(AKLFPGMDKLA.EHBBFMCILPC.CDNGHFCPPEA());
					afibckpkdhb.CGCLCPOHJEP = ecjcfgaophj.BMJIGANCIDG(AKLFPGMDKLA.EHBBFMCILPC.CDNGHFCPPEA());
					afibckpkdhb.CBLPKDDMLBL = ecjcfgaophj.CBLPKDDMLBL;
					afibckpkdhb.JBFCIJKENJP = ecjcfgaophj.JBFCIJKENJP;
					afibckpkdhb.PMFNECKIMBG = ecjcfgaophj.PMFNECKIMBG;
					afibckpkdhb.DENODLCMDAL = ecjcfgaophj;
					ghminfegbgn.LJFCMJJFCOI.Add(afibckpkdhb);
					this.ENKCJJDAPNF(ecjcfgaophj);
					if (!flag2)
					{
						AssetsManager.EHBBFMCILPC.QueueAssetBundleDownload(NMKDCBPMCKI.AssetBundleStoryAssetPack, ecjcfgaophj.AJPBPJDHFOH, ecjcfgaophj.BACMOGGNBNH, FLDBFOADFLH.startDownloadAndProceed, false, true, false, null, 900000, false, "", false, false);
						num++;
						goto IL_33C;
					}
					goto IL_33C;
				}
				if (flag)
				{
					this.DFEMFJJDGML.Add(ghminfegbgn);
					int oibgfpeglme = fjlgcknojmj.OINAAMKLNLO[i].OIBGFPEGLME;
					if (oibgfpeglme < 0)
					{
						oibgfpeglme = LFLOCKNKAKC.NCAMFPGMCIG.OIBGFPEGLME;
					}
					if (!list.Contains(oibgfpeglme))
					{
						list.Add(oibgfpeglme);
					}
				}
			}
		}
		for (int k = 0; k < fjlgcknojmj.NAAGOKCKHEC.Count; k++)
		{
			if (list.Contains(fjlgcknojmj.NAAGOKCKHEC[k].OIBGFPEGLME))
			{
				num += this.GKCNIFOCLOL(fjlgcknojmj.NAAGOKCKHEC[k]);
				this.FLLHKGKNAOK.Add(fjlgcknojmj.NAAGOKCKHEC[k].OIBGFPEGLME);
				this.PEFDGDNCHGD.Add(fjlgcknojmj.NAAGOKCKHEC[k].FLPGNPNHJNK);
				if (!(null != SceneLobbyManager2.KFLJELOKJJO(this.KGOCEEAGLKO, fjlgcknojmj.NAAGOKCKHEC[k].FLPGNPNHJNK, LFLOCKNKAKC)) && fjlgcknojmj.NAAGOKCKHEC[k].HAHPPPLJJPE > 0)
				{
					if (!this.HFFIIBBJBMH.header.availableStories.Contains(fjlgcknojmj.NAAGOKCKHEC[k].HAHPPPLJJPE))
					{
						DPGJIJGOCIC.ADFCDFHBDAF(string.Concat(new string[]
						{
							"[Lounge/lobby] environment pack eps:",
							fjlgcknojmj.NAAGOKCKHEC[k].HAHPPPLJJPE.ToString(),
							" is OUTSIDE the anthology's published story family - not queued (environment:",
							fjlgcknojmj.NAAGOKCKHEC[k].FLPGNPNHJNK,
							")"
						}));
					}
					else
					{
						AssetsManager.EHBBFMCILPC.QueueAssetBundleDownload(NMKDCBPMCKI.AssetBundleStoryAssetPack, fjlgcknojmj.NAAGOKCKHEC[k].HAHPPPLJJPE, fjlgcknojmj.NAAGOKCKHEC[k].FOMDAACIIJN, FLDBFOADFLH.startDownloadAndProceed, false, true, false, null, 900000, false, "", false, false);
						num++;
					}
				}
			}
		}
		return num;
	}

	// Token: 0x060023DA RID: 9178 RVA: 0x00107CB0 File Offset: 0x00105EB0
	public void ActivateFilter(JBBNEEHANHL OFLADADMBJN)
	{
		try
		{
			foreach (FilterItem filterItem in this.scrollView2Controller.GetComponentsInChildren<FilterItem>(true))
			{
				if (filterItem.id == OFLADADMBJN)
				{
					filterItem.GetComponent<FilterItem>().SetActiveFilter(true);
					this.scrollView2Controller.SetItemOnCenter(filterItem.transform, false);
					break;
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x060023DB RID: 9179 RVA: 0x00107D20 File Offset: 0x00105F20
	private void OJEMLBDNFKE()
	{
		List<int> list = AKLFPGMDKLA.EHBBFMCILPC.CEAOAFBKNAP(AssetsManager.EHBBFMCILPC.anthologyAssets);
		if (list.Count > 0)
		{
			AssetAnthologyPreview2 assetAnthologyPreview = GKJPOGNFKNK.OGKPKBLFGMJ(list[DPGJIJGOCIC.IOOHGEJIPFP(0, list.Count)]);
			if (null != assetAnthologyPreview)
			{
				this.CPLLGNAKIIL(assetAnthologyPreview);
			}
			DPGJIJGOCIC.NFIDPOMCNLP("SceneLobbyManager2.OnRewardStoryCompleteClick() getting one random out of " + list.Count.ToString());
		}
	}

	// Token: 0x060023DC RID: 9180 RVA: 0x00107D90 File Offset: 0x00105F90
	private void PAJHBBAHDOM()
	{
		PlayerPrefs.SetInt("socialJoinRequest", 1);
		PlayerPrefs.Save();
		if (LanguageManager.EHBBFMCILPC.GetSelectedLanguage() == CEIBHCNNIDC.ru)
		{
			CommonUserInterface.EHBBFMCILPC.ShowGenericPopupWithTwoButtons(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("socialjointitle"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("socialjoinbody"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("socialjoinyes"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("socialjoinno"), new UnityAction(this.KBGDOGLEIIB), new UnityAction(this.KKGMNKEMAHP), DFGILFBGPLN.popupSocialJoinRequestVkontakte, 0f, 28);
			return;
		}
		CommonUserInterface.EHBBFMCILPC.ShowGenericPopupWithTwoButtons(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("socialjointitle"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("socialjoinbody"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("socialjoinyes"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("socialjoinno"), new UnityAction(this.ANFLJCPEPGI), new UnityAction(this.KKGMNKEMAHP), DFGILFBGPLN.popupSocialJoinRequestFacebook, 0f, 28);
	}

	// Token: 0x060023DD RID: 9181 RVA: 0x00107E8C File Offset: 0x0010608C
	private void CFKGMCPAFHP(JBBNEEHANHL HBBJBNJBMPK)
	{
		try
		{
			for (int i = 0; i < this.EKIFLHLCLKG.Count; i++)
			{
				FilterItem filterItem = (null == this.EKIFLHLCLKG[i]) ? null : this.EKIFLHLCLKG[i].GetComponent<FilterItem>();
				if (null != filterItem && HBBJBNJBMPK == filterItem.id && this.EKIFLHLCLKG[i].activeInHierarchy)
				{
					filterItem.PulseIcon();
					break;
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x060023DE RID: 9182 RVA: 0x00107F20 File Offset: 0x00106120
	private JBBNEEHANHL MEPIIPCPNGL(int GGICIBLJIKI)
	{
		JBBNEEHANHL result = (JBBNEEHANHL)(-39);
		foreach (AssetAnthology assetAnthology in AssetsManager.MJBDMHPHMID().anthologyAssets)
		{
			IJLJDFKJIJM ijljdfkjijm = HKLPEDKJGFC.MBLDKCIKLPN(assetAnthology.header.index);
			if (assetAnthology.header.index == GGICIBLJIKI && ijljdfkjijm != null)
			{
				if (ijljdfkjijm.MGDAFCPCOFH != JBBNEEHANHL.filterNew && ijljdfkjijm.MGDAFCPCOFH != JBBNEEHANHL.filterNew && ijljdfkjijm.MGDAFCPCOFH != JBBNEEHANHL.filterContinuePlaying && ijljdfkjijm.MGDAFCPCOFH != (JBBNEEHANHL)(-85) && ijljdfkjijm.MGDAFCPCOFH != (JBBNEEHANHL)(-105) && ijljdfkjijm.MGDAFCPCOFH != (JBBNEEHANHL)86 && ijljdfkjijm.MGDAFCPCOFH != (JBBNEEHANHL)(-93) && ijljdfkjijm.MGDAFCPCOFH != (JBBNEEHANHL)(-61) && ijljdfkjijm.MGDAFCPCOFH != JBBNEEHANHL.filterSpecialEpisodes)
				{
					return ijljdfkjijm.MGDAFCPCOFH;
				}
				if (ijljdfkjijm.HLEHGFIIEJN != JBBNEEHANHL.filterNew && ijljdfkjijm.HLEHGFIIEJN != JBBNEEHANHL.newFilterContemporary && ijljdfkjijm.HLEHGFIIEJN != JBBNEEHANHL.newFilterContemporary && ijljdfkjijm.HLEHGFIIEJN != (JBBNEEHANHL)91 && ijljdfkjijm.HLEHGFIIEJN != (JBBNEEHANHL)(-70) && ijljdfkjijm.HLEHGFIIEJN != (JBBNEEHANHL)(-119) && ijljdfkjijm.HLEHGFIIEJN != (JBBNEEHANHL)(-45) && ijljdfkjijm.HLEHGFIIEJN != (JBBNEEHANHL)(-109) && ijljdfkjijm.HLEHGFIIEJN != (JBBNEEHANHL)(-97))
				{
					return ijljdfkjijm.HLEHGFIIEJN;
				}
				if (ijljdfkjijm.BFJKEJLJAIH != JBBNEEHANHL.filterNew && ijljdfkjijm.BFJKEJLJAIH != JBBNEEHANHL.newFilterDrama && ijljdfkjijm.BFJKEJLJAIH != JBBNEEHANHL.newFilterSupernatural && ijljdfkjijm.BFJKEJLJAIH != (JBBNEEHANHL)(-11) && ijljdfkjijm.BFJKEJLJAIH != (JBBNEEHANHL)43 && ijljdfkjijm.BFJKEJLJAIH != (JBBNEEHANHL)(-49) && ijljdfkjijm.BFJKEJLJAIH != (JBBNEEHANHL)(-110) && ijljdfkjijm.BFJKEJLJAIH != (JBBNEEHANHL)38 && ijljdfkjijm.BFJKEJLJAIH != (JBBNEEHANHL)(-67))
				{
					return ijljdfkjijm.BFJKEJLJAIH;
				}
			}
		}
		return result;
	}

	// Token: 0x060023DF RID: 9183 RVA: 0x001080D0 File Offset: 0x001062D0
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
		CommonUserInterface.EHBBFMCILPC.ShowSettings(true, false, false);
		yield break;
	}

	// Token: 0x060023E0 RID: 9184 RVA: 0x001080D8 File Offset: 0x001062D8
	private IEnumerator MDFNFDIEIOH(GameObject FLPKFNLNLHN, GameObject NAFPJPEHMDG, float IBOPEKIFJDH, bool FPMJCJPMGME)
	{
		float currentTime = 0f;
		RectTransform focusItemRectTransform = NAFPJPEHMDG.GetComponent<RectTransform>();
		Vector3 startScale = focusItemRectTransform.localScale;
		while (currentTime <= IBOPEKIFJDH)
		{
			currentTime += Time.deltaTime;
			float t = currentTime / IBOPEKIFJDH;
			if (FPMJCJPMGME)
			{
				FLPKFNLNLHN.GetComponent<CanvasGroup>().alpha = Mathf.Lerp(0f, 1f, t);
			}
			focusItemRectTransform.localScale = Vector3.Lerp(startScale, NarrowScreenScaler.CalculateNewScaleUtil(new Vector3(1f, 1f, 1f), 822f, IMBLFHMKMAD.doNotOverride), t);
			yield return null;
		}
		this.logoBackgroundNew.gameObject.SetActive(false);
		this.logoBackgroundMask.gameObject.SetActive(false);
		yield break;
	}

	// Token: 0x060023E1 RID: 9185 RVA: 0x00003E52 File Offset: 0x00002052
	private void PCMOOHFJJHD()
	{
	}

	// Token: 0x060023E2 RID: 9186 RVA: 0x00108104 File Offset: 0x00106304
	private void MPLFMJKMAIL()
	{
		try
		{
			this.rewardFade.SetActive(true);
			base.StartCoroutine(this.FINPCOMDIFD(this.rewardFade, this.rewardItem, this.timeFocusItemAnimation, true));
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
	}

	// Token: 0x060023E3 RID: 9187 RVA: 0x00108158 File Offset: 0x00106358
	private void IIEGAKKFKIJ()
	{
		SceneLobbyManager2.startChapterManInTheMiddleAttack = 1;
		CommonUserInterface.EHBBFMCILPC.HideConnectingAnimation();
		CommonUserInterface.EHBBFMCILPC.ShowGenericPopupTwoOverride(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("errortitle"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("notgenuinecopy") + " (" + AKLFPGMDKLA.EHBBFMCILPC.EEHGLPEIIHD + ")", CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("ok"), new UnityAction(this.JDFKJADDMAN), new UnityAction(this.JDFKJADDMAN), DFGILFBGPLN.popupAccountSuspended, 0f, 28);
	}

	// Token: 0x060023E4 RID: 9188 RVA: 0x001081E8 File Offset: 0x001063E8
	private bool LNNMAMLCBMF(string HHNGGFLJAIJ, string FBDPELCOKOP)
	{
		try
		{
			if (null == this.smallItemPrefab)
			{
				return false;
			}
			ThumbnailItem component = this.smallItemPrefab.GetComponent<ThumbnailItem>();
			return null != component && component.CardChipsFit(HHNGGFLJAIJ, FBDPELCOKOP);
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
		return false;
	}

	// Token: 0x060023E5 RID: 9189 RVA: 0x00108244 File Offset: 0x00106444
	private bool FALNDKMJNMF(int PLKMJJIIJNO, string AFHIPGHANJE)
	{
		List<SceneLobbyManager2.BBNDCCPKNJL> list = this.LEAJJAFAKLH(PLKMJJIIJNO);
		if (list == null || AFHIPGHANJE == null)
		{
			return false;
		}
		for (int i = 0; i < list.Count; i++)
		{
			if (string.Equals(list[i].IEIAICGOENJ, AFHIPGHANJE, StringComparison.OrdinalIgnoreCase))
			{
				return list[i].OKJNEMPGHDJ;
			}
		}
		return false;
	}

	// Token: 0x060023E6 RID: 9190 RVA: 0x00108295 File Offset: 0x00106495
	private void FKPLFIDCPLP()
	{
		this.IDJEMNCLFDN();
		AppManager.EHBBFMCILPC.RestartApp(true, false);
	}

	// Token: 0x060023E7 RID: 9191 RVA: 0x001082AC File Offset: 0x001064AC
	private EGBNGOMIJEE ODJAPCCLBLE()
	{
		EGBNGOMIJEE egbngomijee = new EGBNGOMIJEE();
		try
		{
			List<int> list = AKLFPGMDKLA.EHBBFMCILPC.NJCPMPKNPHE();
			bool[] array = new bool[egbngomijee.OKAONKKBAFK.Length];
			List<int> list2 = new List<int>();
			for (int i = 0; i < list.Count; i++)
			{
				if (list[i] >= 0 && list[i] < egbngomijee.OKAONKKBAFK.Length && GOAEAMLNFOC.DLIKABOBPIO((JBBNEEHANHL)list[i]))
				{
					array[list[i]] = true;
					egbngomijee.OKAONKKBAFK[list[i]] = 1f;
					if (!list2.Contains(list[i]))
					{
						list2.Add(list[i]);
					}
				}
			}
			egbngomijee.OPDNPPGBELO = AKLFPGMDKLA.EHBBFMCILPC.LINADLBCHJC();
			List<int> list3 = AKLFPGMDKLA.EHBBFMCILPC.MHFFFOBMPAK();
			for (int j = 0; j < list3.Count; j++)
			{
				egbngomijee.NBABLDKAEBC.Add(list3[j]);
			}
			for (int k = 0; k < egbngomijee.OPDNPPGBELO.Count; k++)
			{
				if (!egbngomijee.NBABLDKAEBC.Contains(egbngomijee.OPDNPPGBELO[k]))
				{
					egbngomijee.NBABLDKAEBC.Add(egbngomijee.OPDNPPGBELO[k]);
				}
			}
			egbngomijee.ECOBLMDOBBF = AKLFPGMDKLA.EHBBFMCILPC.JCBEPJJHAII(AssetsManager.EHBBFMCILPC.anthologyAssets);
			float[] array2 = new float[egbngomijee.OKAONKKBAFK.Length];
			for (int l = 0; l < egbngomijee.NBABLDKAEBC.Count; l++)
			{
				List<JBBNEEHANHL> list4 = this.JNOKFMBPKMP(egbngomijee.NBABLDKAEBC[l]);
				int num = 0;
				while (num < list4.Count && num < 2)
				{
					float num2 = 0.05f;
					if (num == 0)
					{
						num2 = 0.15f;
					}
					array2[(int)list4[num]] += num2;
					num++;
				}
			}
			for (int m = 0; m < egbngomijee.OKAONKKBAFK.Length; m++)
			{
				if (!array[m])
				{
					egbngomijee.OKAONKKBAFK[m] = Mathf.Clamp(array2[m], 0f, 0.3f);
				}
			}
			bool flag = false;
			bool flag2 = false;
			egbngomijee.EEHAMAJIHOA = (flag2 || (flag && CEIBHCNNIDC.ru == LanguageManager.EHBBFMCILPC.GetSelectedLanguage()));
			string text = AKLFPGMDKLA.EHBBFMCILPC.EEHGLPEIIHD;
			if (text == null || text.Length == 0)
			{
				text = AKLFPGMDKLA.EHBBFMCILPC.HFDMBCHLCOJ;
			}
			if (text == null || text.Length == 0)
			{
				text = AKLFPGMDKLA.EHBBFMCILPC.EPFIHIAKPIH.Ticks.ToString();
			}
			egbngomijee.LBLLBJKKOAP = GOAEAMLNFOC.BPIKBAEIIAA(text);
			egbngomijee.JNKDDGGHOEA = GOAEAMLNFOC.FKKNGEFLDAN(egbngomijee.LBLLBJKKOAP, list2, egbngomijee.NBABLDKAEBC);
			long num3 = AKLFPGMDKLA.EHBBFMCILPC.CDNGHFCPPEA();
			egbngomijee.LOPKBMGNEGJ = (int)(num3 / 604800L);
			egbngomijee.PBJGGLCJADD = (int)(num3 / 86400L);
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
		return egbngomijee;
	}

	// Token: 0x060023E8 RID: 9192 RVA: 0x001085B0 File Offset: 0x001067B0
	private IEnumerator KDBHIGBDGLA()
	{
		this.GBBHKFFENBE = true;
		ProfileItem2.expandCollectedCardsByDefault = false;
		ProfileItem2.expandBadgesByDefault = false;
		AssetsManager.EHBBFMCILPC.GetLoadingProgressSnapshot().EPJKDCDOEMM(0);
		CommonUserInterface.EHBBFMCILPC.ShowConnectingAnimationWithProgress(96);
		yield return new WaitForEndOfFrame();
		while (AssetsManager.EHBBFMCILPC.IsBusy())
		{
			DPGJIJGOCIC.NFIDPOMCNLP("SceneLobbyManager2.OpenPublicProfile(): AssetsManager.Instance.IsBusy()");
			yield return new WaitForSeconds(0.05f);
		}
		if (!KDCJJBLGCBH.EHBBFMCILPC.PJFKDFIDPGH() && null == AssetsManager.EHBBFMCILPC.profileDataAsset6 && !this.CGPGMJKCBBJ)
		{
			AssetsManager.EHBBFMCILPC.GetLoadingProgressSnapshot().CLIOEOLFFLO(LEJKDNAGDHC.Fast);
			AssetsManager.EHBBFMCILPC.GetLoadingProgressSnapshot().GIJKJMMDJEL(0f, 1f);
			AssetsManager.EHBBFMCILPC.QueueLiveProfileThumbnailsBundle();
			AssetsManager.EHBBFMCILPC.DownloadQueuedAssetBundles("OnLiveProfileThumbnailsCdnSuccess", "OnLiveProfileThumbnailsCdnFailed", true);
			yield return new WaitForEndOfFrame();
			while (AssetsManager.EHBBFMCILPC.IsBusy())
			{
				yield return new WaitForSeconds(0.05f);
			}
			if (null == AssetsManager.EHBBFMCILPC.profileDataAsset6)
			{
				this.IMOHHHALBAP++;
				if (this.IMOHHHALBAP >= 2)
				{
					this.CGPGMJKCBBJ = true;
				}
				DPGJIJGOCIC.ADFCDFHBDAF("SceneLobbyManager2.OpenPublicProfile(): live profile theme thumbnails unavailable (miss " + this.IMOHHHALBAP.ToString() + "), the full themes load as before");
			}
			AssetsManager.EHBBFMCILPC.GetLoadingProgressSnapshot().EPJKDCDOEMM(0);
		}
		int num = (int)LanguageManager.EHBBFMCILPC.GetSelectedLanguage();
		if (num > 1)
		{
			num = 0;
		}
		AssetsManager.EHBBFMCILPC.QueueAssetBundleDownload(NMKDCBPMCKI.AssetBundleProfileDataLocalized, num, -1, FLDBFOADFLH.finishDownloadAndProceed, false, false, false, null, -1, false, "", false, false);
		AssetsManager.EHBBFMCILPC.QueueAssetBundleDownload(NMKDCBPMCKI.AssetBundleProfileData, 0, -1, FLDBFOADFLH.finishDownloadAndProceed, false, false, false, null, -1, false, "", false, false);
		for (int i = 0; i < AssetsManager.EHBBFMCILPC.lobbyDataAsset.maxAnthologyIndex + 1; i++)
		{
			if (true)
			{
				AssetsManager.EHBBFMCILPC.QueueAssetBundleDownload(NMKDCBPMCKI.AssetBundleProfilePack, i, -1, FLDBFOADFLH.startDownloadAndProceed, false, false, false, null, -1, false, "", false, false);
			}
		}
		if (null != AssetsManager.EHBBFMCILPC.lobbyDataAsset)
		{
			AssetsManager.EHBBFMCILPC.lobbyDataAsset.NHOLIOGAEKK();
			for (int j = 0; j < AssetsManager.EHBBFMCILPC.lobbyDataAsset.maxLiveProfileThemeId + 1; j++)
			{
				if (!(null != AssetsManager.EHBBFMCILPC.profileDataAsset6) || !AssetsManager.EHBBFMCILPC.profileDataAsset6.IOBAGEDAJKE(j))
				{
					AssetsManager.EHBBFMCILPC.QueueAssetBundleDownload(NMKDCBPMCKI.AssetBundleLiveProfileTheme, j, -1, FLDBFOADFLH.startDownloadAndProceed, false, false, false, null, -1, false, "", false, false);
				}
			}
		}
		for (int k = 0; k < AssetsManager.EHBBFMCILPC.anthologyAssets.Count; k++)
		{
			if (null != AssetsManager.EHBBFMCILPC.anthologyAssets[k] && AssetsManager.EHBBFMCILPC.anthologyAssets[k].header.enableIconsPack)
			{
				AssetsManager.EHBBFMCILPC.QueueAssetBundleDownload(NMKDCBPMCKI.AssetBundleIconsPack, AssetsManager.EHBBFMCILPC.anthologyAssets[k].header.CKACBBGHJGI(), -1, FLDBFOADFLH.startDownloadAndProceed, false, false, false, null, -1, false, "", false, false);
			}
		}
		AssetsManager.EHBBFMCILPC.QueueAssetBundleDownload(NMKDCBPMCKI.AssetBundleProfileData2, 0, -1, FLDBFOADFLH.startDownloadAndProceed, false, false, false, null, -1, false, "", false, false);
		AssetsManager.EHBBFMCILPC.QueueAssetBundleDownload(NMKDCBPMCKI.AssetBundleProfileData3, 0, -1, FLDBFOADFLH.startDownloadAndProceed, false, false, false, null, -1, false, "", false, false);
		AssetsManager.EHBBFMCILPC.GetLoadingProgressSnapshot().CLIOEOLFFLO(LEJKDNAGDHC.Slow);
		AssetsManager.EHBBFMCILPC.GetLoadingProgressSnapshot().GIJKJMMDJEL(0f, 1f);
		AssetsManager.EHBBFMCILPC.DownloadQueuedAssetBundles("OnLobbyProfileDataCdnSuccess", "OnLobbyProfileDataCdnFailed", false);
		yield break;
	}

	// Token: 0x060023E9 RID: 9193 RVA: 0x001085C0 File Offset: 0x001067C0
	public void OnFreeDiamondsClickNotAvaiable()
	{
		if (!this.PDFIHFFJMJN)
		{
			return;
		}
		CommonUserInterface.EHBBFMCILPC.ShowGenericPopup(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("importanttitle"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("adserrorbody"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("ok"), DFGILFBGPLN.popupEnergyHint, 0f, 28);
	}

	// Token: 0x060023EA RID: 9194 RVA: 0x00003E52 File Offset: 0x00002052
	public void IOMIOELPLHJ()
	{
	}

	// Token: 0x060023EB RID: 9195 RVA: 0x00108618 File Offset: 0x00106818
	public int RunStorySearch(string GOJOGDKCNMO)
	{
		int result;
		try
		{
			if (KDCJJBLGCBH.EHBBFMCILPC.GNGCDGBAALO() || !MLIBDDCCKBM.FACIFBONANM())
			{
				if (this.KOGLEPFNALN)
				{
					this.NPGMAIPHIML(true);
				}
				SceneLobbyManager2.KAFNANCDMNF = null;
				result = -2;
			}
			else if (SceneLobbyManager2.lobbyIsLoading || !HKLPEDKJGFC.FACIFBONANM() || this.EKIFLHLCLKG.Count == 0)
			{
				DPGJIJGOCIC.ADFCDFHBDAF("SceneLobbyManager2.RunStorySearch() - lobby not ready, query ignored");
				result = -1;
			}
			else if (this.GDNHLCMDFHA())
			{
				result = -1;
			}
			else
			{
				string text = (GOJOGDKCNMO == null) ? "" : GOJOGDKCNMO.TrimStart();
				string text2 = text.Trim();
				if (text2.Length == 0)
				{
					this.OnSearchClear();
					result = -1;
				}
				else
				{
					this.MJOMHIEMKMK = text2;
					this.BDGEAAJKPLH();
					MLIBDDCCKBM.MCOMGMOACEM(text, LanguageManager.EHBBFMCILPC.GetSelectedLanguage(), this.KPDGEKGMAKO, this.CIBDADPLOMG);
					this.BPCHEOFFPCN.Clear();
					this.EEGHJFAIMBF.Clear();
					this.IIDEKJNAFKG.Clear();
					this.NODBJCOJNLJ.Clear();
					int num = KDCJJBLGCBH.EHBBFMCILPC.HDOLFGLBEHL();
					if (num > 0 && num < 6)
					{
						num = 6;
					}
					int num2 = 0;
					while (num2 < this.CIBDADPLOMG.Count && (num <= 0 || this.BPCHEOFFPCN.Count < num))
					{
						int plmhnbphmkp = this.CIBDADPLOMG[num2].PLMHNBPHMKP;
						if (!this.KPDGEKGMAKO.Contains(plmhnbphmkp))
						{
							DPGJIJGOCIC.ADFCDFHBDAF("SceneLobbyManager2.RunStorySearch() - ranker returned non-candidate anthology " + plmhnbphmkp.ToString() + ", dropped");
						}
						else if (!this.BPCHEOFFPCN.Contains(plmhnbphmkp))
						{
							this.BPCHEOFFPCN.Add(plmhnbphmkp);
						}
						num2++;
					}
					int num3 = 0;
					while (num3 < this.KPDGEKGMAKO.Count && this.BPCHEOFFPCN.Count < 6)
					{
						int item = this.KPDGEKGMAKO[num3];
						if (!this.BPCHEOFFPCN.Contains(item))
						{
							this.BPCHEOFFPCN.Add(item);
							this.EEGHJFAIMBF.Add(item);
						}
						num3++;
					}
					this.PPHBKEJLANP();
					if (this.BPCHEOFFPCN.Count == 0)
					{
						DPGJIJGOCIC.ADFCDFHBDAF("SceneLobbyManager2.RunStorySearch() - no candidates, nothing to show for '" + this.MJOMHIEMKMK + "'");
						this.MJOMHIEMKMK = "";
						this.EEGHJFAIMBF.Clear();
						this.IIDEKJNAFKG.Clear();
						this.NODBJCOJNLJ.Clear();
						result = -1;
					}
					else
					{
						this.KOGLEPFNALN = true;
						this.KJPGCECABFI();
						int num4 = this.AIPCPDAAMJN();
						if (num4 == 0)
						{
							DPGJIJGOCIC.ADFCDFHBDAF("SceneLobbyManager2.RunStorySearch() - no card for any result of '" + this.MJOMHIEMKMK + "', nothing to show");
							this.NPGMAIPHIML(true);
							result = -1;
						}
						else
						{
							this.PCPBEDEPMMJ();
							this.EBEODGBEEMI();
							result = num4;
						}
					}
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
			result = -1;
		}
		return result;
	}

	// Token: 0x060023EC RID: 9196 RVA: 0x001088EC File Offset: 0x00106AEC
	private void GAFCLPHKMFP()
	{
		try
		{
			bool active = false;
			for (int i = 0; i < this.MGNNOFPKGJF.Count; i++)
			{
				if (null != this.MGNNOFPKGJF[i] && (JBBNEEHANHL)(-11) == this.MGNNOFPKGJF[i].GetComponent<GridController>().filter && this.MGNNOFPKGJF[i].activeSelf)
				{
					active = false;
				}
			}
			this.KLBBGAFDNMP((JBBNEEHANHL)(-109));
			if (this.BPCHEOFFPCN.Count != 0)
			{
				GameObject gameObject = this.HPOCOHEODDF((JBBNEEHANHL)(-125));
				if (!(null == gameObject))
				{
					gameObject.SetActive(active);
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x060023ED RID: 9197 RVA: 0x001089A0 File Offset: 0x00106BA0
	private void NJOHOGOEINP()
	{
		if (this.PHMIBKAJKMB == null)
		{
			this.PHMIBKAJKMB = FADIGFEOCND.IMEFIJEKFGI(1000000f);
		}
	}

	// Token: 0x060023EE RID: 9198 RVA: 0x000ED5B6 File Offset: 0x000EB7B6
	private void IBCPIFOFMPB()
	{
		base.StartCoroutine(this.LCNJLBEOKPB());
	}

	// Token: 0x060023EF RID: 9199 RVA: 0x001089BC File Offset: 0x00106BBC
	private void ILBNPEIJKJM()
	{
		CommonUserInterface.EHBBFMCILPC.HideConnectingAnimation();
		this.notificationFreeDiamonds.SetActive(false);
		this.notificationFreeDiamondsHidden.SetActive(true);
		this.JNKEHEBNBAP();
		this.JLFGANHMMOM();
		CommonUserInterface.EHBBFMCILPC.ShowGenericPopup(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("rewardtitle"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("incentadthanks"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("collect"), DFGILFBGPLN.popupIncentAd0Success, 0f, 28).ShowDiamonds(SceneLobbyManager2.incentAdResultAmount);
	}

	// Token: 0x060023F0 RID: 9200 RVA: 0x00108A44 File Offset: 0x00106C44
	public static bool TryGetFocusCardWords(int PLKMJJIIJNO, out string[] AGPMOBFCLFK)
	{
		AGPMOBFCLFK = null;
		if (null == SceneLobbyManager2.BJBOJLBOOEF || SceneLobbyManager2.BJBOJLBOOEF.OCKANDFLMBG == null || SceneLobbyManager2.BJBOJLBOOEF.OCKANDFLMBG.Length == 0 || PLKMJJIIJNO != SceneLobbyManager2.BJBOJLBOOEF.FLPJFHKDIOG)
		{
			return false;
		}
		AGPMOBFCLFK = SceneLobbyManager2.BJBOJLBOOEF.OCKANDFLMBG;
		return true;
	}

	// Token: 0x060023F1 RID: 9201 RVA: 0x00108A96 File Offset: 0x00106C96
	private IEnumerator JPEPPPHJIBN()
	{
		yield return new WaitForSeconds(0.25f);
		yield return new WaitForEndOfFrame();
		this.JLFKKFCFJIC();
		yield break;
	}

	// Token: 0x060023F2 RID: 9202 RVA: 0x00108AA8 File Offset: 0x00106CA8
	private bool EPFLNNFPHFE(AssetAnthology AAOGJEGPCAE)
	{
		bool result;
		try
		{
			if (null == AAOGJEGPCAE)
			{
				result = false;
			}
			else if (KDCJJBLGCBH.EHBBFMCILPC.BOPBHFAICBB())
			{
				result = false;
			}
			else if (!AAOGJEGPCAE.splashLowEndVersionAvailable)
			{
				result = false;
			}
			else if (KDCJJBLGCBH.EHBBFMCILPC.PCDHDFCEODB() || KHPGPLAMAIN.EJCNHEBIOJF())
			{
				result = true;
			}
			else
			{
				result = (KHPGPLAMAIN.IBDGNKGIMFI() == IIHCCPLGGHP.lowEnd);
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
			result = false;
		}
		return result;
	}

	// Token: 0x060023F3 RID: 9203 RVA: 0x00108B1C File Offset: 0x00106D1C
	public int GetAnthologyProgressPercent(int PLKMJJIIJNO)
	{
		int result;
		try
		{
			float num = 0f;
			float num2 = 0f;
			bool flag = false;
			int i = 0;
			while (i < AssetsManager.EHBBFMCILPC.anthologyAssets.Count)
			{
				if (AssetsManager.EHBBFMCILPC.anthologyAssets[i].header.index == PLKMJJIIJNO)
				{
					EIOPLEFLLIM eioplefllim = AKLFPGMDKLA.EHBBFMCILPC.GJBDBONJCDL(PLKMJJIIJNO);
					if (eioplefllim != null)
					{
						for (int j = 0; j < AssetsManager.EHBBFMCILPC.anthologyAssets[i].header.maxStories; j++)
						{
							if (j <= eioplefllim.EGHHCFFLPCP(-1))
							{
								AssetStoryHeader assetStoryHeader = GKJPOGNFKNK.CDCEFHLNNEC(AssetsManager.EHBBFMCILPC.anthologyAssets[i].header.availableStories[j]);
								if (j == eioplefllim.EGHHCFFLPCP(-1))
								{
									PLFDAJJHMKO plfdajjhmko = AKLFPGMDKLA.EHBBFMCILPC.PKNIPLDMJGG(assetStoryHeader.index, -1);
									if (plfdajjhmko != null)
									{
										if (plfdajjhmko.DHONIOBOLEL.LKIKEHFANBO[1] >= 0 && plfdajjhmko.DHONIOBOLEL.LKIKEHFANBO[1] < 100)
										{
											num2 += (float)(plfdajjhmko.DHONIOBOLEL.LKIKEHFANBO[1] + 1);
										}
										else if (plfdajjhmko.DHONIOBOLEL.LKIKEHFANBO[1] < 0)
										{
											num2 += 0f;
										}
										else
										{
											num2 += (float)assetStoryHeader.availableChaptersCount;
										}
										if (j == 0 && plfdajjhmko.DHONIOBOLEL.LKIKEHFANBO[0] == 0)
										{
											flag = true;
										}
									}
									else
									{
										num2 += (float)assetStoryHeader.availableChaptersCount;
									}
								}
								else
								{
									num2 += (float)assetStoryHeader.availableChaptersCount;
								}
								num += (float)assetStoryHeader.totalChaptersCount;
							}
							else
							{
								num += (float)AssetsManager.EHBBFMCILPC.anthologyAssets[i].header.plannedChaptersPerSeason;
							}
						}
						break;
					}
					return 0;
				}
				else
				{
					i++;
				}
			}
			if (num > 0f)
			{
				float num3 = num2 / num;
				if (!flag)
				{
					result = (int)(num3 * 100f);
				}
				else
				{
					result = (int)(num3 * 100f) + 1;
				}
			}
			else if (!flag)
			{
				result = 0;
			}
			else
			{
				result = 1;
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
			result = 0;
		}
		return result;
	}

	// Token: 0x060023F4 RID: 9204 RVA: 0x00108295 File Offset: 0x00106495
	private void MMLFBNPEOPP()
	{
		this.IDJEMNCLFDN();
		AppManager.EHBBFMCILPC.RestartApp(true, false);
	}

	// Token: 0x060023F5 RID: 9205 RVA: 0x00108D3C File Offset: 0x00106F3C
	private void CKKGJEOHAIG()
	{
		if (this.PHMIBKAJKMB.HHGAPKJFBMC() || SceneLobbyManager2.spinsFireTime <= 0 || AKLFPGMDKLA.EHBBFMCILPC.ABGNIKKFFAC.LPKLANAEIFF() > 0)
		{
			this.OnWheelOfFortuneClick();
			return;
		}
		CommonUserInterface.IKNOFBFMPGA().NFBMHHPIGFA(CCOJBMMKNAP.BOFMCPPFAMO().DNILNCLIHAP("OnCaptersSnapshotsGamePassSubscribePositive"), CCOJBMMKNAP.KLAKLFCOMJC().PKNHKGMNCIP("popupcardoptionsgiftcopyinfo"), CCOJBMMKNAP.DLGLFACMHPG().PKNHKGMNCIP("Asset bundle assets destroyed:"), (DFGILFBGPLN)(-68), 19f, 57);
	}

	// Token: 0x060023F6 RID: 9206 RVA: 0x00108DB8 File Offset: 0x00106FB8
	private void PCCPFFIJNIO()
	{
		this.BDGPIIONPIA = true;
		if (this.IFHLHLICMHP != null)
		{
			base.StopCoroutine(this.IFHLHLICMHP);
			this.IFHLHLICMHP = null;
		}
		if (this.CJEJCGOCFJF && this.ILPNKGBHGOL.Count > 0 && AssetsManager.EHBBFMCILPC.IsBusy())
		{
			DPGJIJGOCIC.NFIDPOMCNLP("SceneLobbyManager2.OnLiveProfileThemesLoaderStop(): aborting the in-flight live profile themes " + SceneLobbyManager2.LCBGEAPPODB(this.ILPNKGBHGOL));
			this.EPJBDIIAIAJ = true;
			AssetsManager.EHBBFMCILPC.ForceStopAllOperations();
		}
		if (!ProfileItem2.profileWindowActive && this.DGCNKCFHGAO)
		{
			this.DGCNKCFHGAO = false;
			this.LCMLDDFFBGM.Clear();
			this.EMFGMAIBBLE.Clear();
			this.GBBHKFFENBE = false;
		}
	}

	// Token: 0x060023F7 RID: 9207 RVA: 0x00108E68 File Offset: 0x00107068
	public void OnNeedToCompleteAnthology(int PLKMJJIIJNO)
	{
		string dpjinbcgngn = CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("onneedtocompleteanthology") + " <i>" + GKJPOGNFKNK.DNILNCLIHAP("anthology" + PLKMJJIIJNO.ToString(), "anthologiestitle", LanguageManager.EHBBFMCILPC.GetSelectedLanguage()) + "</i>.";
		CommonUserInterface.EHBBFMCILPC.ShowGenericPopup(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("importanttitle"), dpjinbcgngn, CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("ok"), DFGILFBGPLN.popupComingSoon, 0f, 28);
	}

	// Token: 0x060023F8 RID: 9208 RVA: 0x000F6655 File Offset: 0x000F4855
	private bool MAHOKGAFGHM()
	{
		return this.AMHFDOEDOOE();
	}

	// Token: 0x060023F9 RID: 9209 RVA: 0x00108EEC File Offset: 0x001070EC
	private void Awake()
	{
		SceneLobbyManager2.BJBOJLBOOEF = this;
		this.IPAFGLONDJF = false;
		this.NJOHOGOEINP();
		SceneLobbyManager2.CHGGOOEADOC = false;
		if (GeoLocationManager.GetCountryCode().Equals("de"))
		{
			FirebaseAnalyticsManager.EHBBFMCILPC.LogEvent(false, AGEHCPDNBFD.lang.ToString(), LanguageManager.EHBBFMCILPC.GetSelectedLanguage().ToString(), GeoLocationManager.GetCountryCode(), true, true);
		}
		FirebaseAnalyticsManager.EHBBFMCILPC.LogEvent(false, AGEHCPDNBFD.techDef.ToString(), NBDLBFJOEGN.FKJIECPMBFP(), NBDLBFJOEGN.JHNDHBLDJOI(), true, true);
		FirebaseAnalyticsManager.EHBBFMCILPC.LogEvent(false, AGEHCPDNBFD.techDef.ToString(), FFPHBMFGCNN.tier.ToString(), KHPGPLAMAIN.IBDGNKGIMFI().ToString(), true, true);
		if (KHPGPLAMAIN.DFJHJCAIFJO())
		{
			FirebaseAnalyticsManager.EHBBFMCILPC.LogEvent(false, AGEHCPDNBFD.techDef.ToString(), FFPHBMFGCNN.video.ToString(), BGHLMGPPCNN.vidsup.ToString(), true, true);
		}
		else
		{
			FirebaseAnalyticsManager.EHBBFMCILPC.LogEvent(false, AGEHCPDNBFD.techDef.ToString(), FFPHBMFGCNN.video.ToString(), BGHLMGPPCNN.vidnosup.ToString(), true, true);
		}
		if (KHPGPLAMAIN.CNFPCHNGKPB())
		{
			FirebaseAnalyticsManager.EHBBFMCILPC.LogEvent(false, AGEHCPDNBFD.techDef.ToString(), FFPHBMFGCNN.ram.ToString(), BGHLMGPPCNN.resloadskp.ToString(), true, true);
		}
		else
		{
			FirebaseAnalyticsManager.EHBBFMCILPC.LogEvent(false, AGEHCPDNBFD.techDef.ToString(), FFPHBMFGCNN.ram.ToString(), BGHLMGPPCNN.resloadalw.ToString(), true, true);
		}
		if (KHPGPLAMAIN.BNKOGIHGDNI())
		{
			FirebaseAnalyticsManager.EHBBFMCILPC.LogEvent(false, AGEHCPDNBFD.techDef.ToString(), FFPHBMFGCNN.post.ToString(), BGHLMGPPCNN.postsup.ToString(), true, true);
		}
		else
		{
			FirebaseAnalyticsManager.EHBBFMCILPC.LogEvent(false, AGEHCPDNBFD.techDef.ToString(), FFPHBMFGCNN.post.ToString(), BGHLMGPPCNN.postnosup.ToString(), true, true);
		}
		this.EJNCBBFGGLH = this.recommendedSetupButton.GetComponent<RectTransform>();
		this.KHGNNCCKEPG = this.shuffleButton.GetComponent<RectTransform>();
		this.CGHKPPLLBKN = this.EJNCBBFGGLH.anchoredPosition;
		this.KIODPNAKDIF = this.KHGNNCCKEPG.anchoredPosition;
		this.BDLMHIGGAHI = this.recommendedSetupButton.GetComponent<CanvasGroup>();
		this.KHKDPJNCPJN = this.shuffleButton.GetComponent<CanvasGroup>();
		ImageFrameAnimation.SetAnimationSystemVersionOverride(-1);
		this.EKNLABKCIJF();
		AKLFPGMDKLA.EHBBFMCILPC.EGOCMDJBLNJ++;
		AssetsManager.EHBBFMCILPC.GetLoadingProgressSnapshot().EPJKDCDOEMM(0);
	}

	// Token: 0x060023FA RID: 9210 RVA: 0x001091DF File Offset: 0x001073DF
	private IEnumerator BPHOMBLHPEH()
	{
		while (SceneLobbyManager2.lobbyIsLoading || !SceneLobbyManager2.lobbyIsActive || SceneLobbyManager2.returnedFromCompletedStoryChapter || this.GDNHLCMDFHA())
		{
			yield return null;
		}
		int framesTemp = 0;
		while (null != this.lobbySearchBar && !this.lobbySearchBar.gameObject.activeInHierarchy && framesTemp < 300)
		{
			int num = framesTemp;
			framesTemp = num + 1;
			yield return null;
		}
		yield return null;
		this.EGNDHGMJJJL = null;
		this.JPAGPOKBHMI();
		yield break;
	}

	// Token: 0x060023FB RID: 9211 RVA: 0x001091F0 File Offset: 0x001073F0
	private void ECLOLAPJJOK()
	{
		this.FIBKHPMLNJN = null;
		this.KOGLEPFNALN = false;
		this.MJOMHIEMKMK = "OnStoryInterfaceHeaderBackClick";
		this.BPCHEOFFPCN.Clear();
		this.EEGHJFAIMBF.Clear();
		this.IIDEKJNAFKG.Clear();
		this.NODBJCOJNLJ.Clear();
		if (this.EGNDHGMJJJL != null)
		{
			base.StopCoroutine(this.EGNDHGMJJJL);
			this.EGNDHGMJJJL = null;
		}
	}

	// Token: 0x060023FC RID: 9212 RVA: 0x000F2888 File Offset: 0x000F0A88
	private void BIHAHOCIDKK()
	{
		this.MNGIPAFFFEA();
	}

	// Token: 0x060023FD RID: 9213 RVA: 0x00003E52 File Offset: 0x00002052
	private void FMPNGJCANAG()
	{
	}

	// Token: 0x060023FE RID: 9214 RVA: 0x00109260 File Offset: 0x00107460
	private void OGOHCOHOMFL()
	{
		if (!this.notificationFreeDiamonds.activeSelf && KHPGPLAMAIN.NGPOHAPMMAI() && AdsManagerLP.EHBBFMCILPC.IsReadyRewarded())
		{
			this.notificationFreeDiamonds.SetActive(true);
			this.notificationFreeDiamondsHidden.SetActive(false);
			this.PCLAANFABBB();
			this.JLFGANHMMOM();
			if (AKLFPGMDKLA.EHBBFMCILPC.KCFMAEFDGPK == 0)
			{
				this.incentAdHardButton.interactable = true;
			}
			else
			{
				this.BJGAJOKENMG.EPJKDCDOEMM((float)AKLFPGMDKLA.EHBBFMCILPC.KCFMAEFDGPK);
				this.incentAdHardButton.interactable = false;
			}
		}
		this.incentAdHardButton.interactable = true;
	}

	// Token: 0x060023FF RID: 9215 RVA: 0x001092FC File Offset: 0x001074FC
	private void DKOHLEEEEEA()
	{
		for (int i = 0; i < this.wheelItem.GetComponent<WheelItem>().lobbyCameras.Count; i++)
		{
			this.wheelItem.GetComponent<WheelItem>().lobbyCameras[i].enabled = false;
		}
	}

	// Token: 0x06002400 RID: 9216 RVA: 0x00109348 File Offset: 0x00107548
	public void OnShuffleClick()
	{
		this.GBBHKFFENBE = false;
		this.DFPNCCFNJJD = MNLBEMJOKNJ.shuffleUse;
		if (!AKLFPGMDKLA.EHBBFMCILPC.EAFEJCKIEPL(8))
		{
			AKLFPGMDKLA.EHBBFMCILPC.LDAPMNLGAPC(8);
			CommonUserInterface.EHBBFMCILPC.ShowGenericPopupOneOverride(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("energyhinttitle"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("tutshufflebody"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("continue"), new UnityAction(this.OnShuffleClick), DFGILFBGPLN.popupTools, 0f, 28);
			return;
		}
		if (!AKLFPGMDKLA.EHBBFMCILPC.EAFEJCKIEPL(10))
		{
			AKLFPGMDKLA.EHBBFMCILPC.LDAPMNLGAPC(10);
		}
		else if (!AKLFPGMDKLA.EHBBFMCILPC.EAFEJCKIEPL(11))
		{
			AKLFPGMDKLA.EHBBFMCILPC.LDAPMNLGAPC(11);
		}
		else if (!AKLFPGMDKLA.EHBBFMCILPC.EAFEJCKIEPL(12))
		{
			AKLFPGMDKLA.EHBBFMCILPC.LDAPMNLGAPC(12);
		}
		else if (!AKLFPGMDKLA.EHBBFMCILPC.EAFEJCKIEPL(13))
		{
			AKLFPGMDKLA.EHBBFMCILPC.LDAPMNLGAPC(13);
		}
		else if (!AKLFPGMDKLA.EHBBFMCILPC.EAFEJCKIEPL(14))
		{
			AKLFPGMDKLA.EHBBFMCILPC.LDAPMNLGAPC(14);
		}
		else if (!AKLFPGMDKLA.EHBBFMCILPC.EAFEJCKIEPL(15))
		{
			AKLFPGMDKLA.EHBBFMCILPC.LDAPMNLGAPC(15);
			CommonUserInterface.EHBBFMCILPC.ShowGenericPopupWithTwoButtonsAndCloseOverride(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("energyhinttitle"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("tutshufflereconfigbody"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("yes"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("no"), new UnityAction(this.OnSetupRecommendedFinalize), new UnityAction(this.OnShuffleClick), new UnityAction(this.OnShuffleClick), DFGILFBGPLN.popupTools, 0f, 28);
			return;
		}
		this.UpdateAnthologiesPropertiesV2(true, false);
		this.scrollView1Controller.StopAnimationOnShuffleCoroutine();
		while (this.largeItemsParent.childCount > 0)
		{
			UnityEngine.Object.DestroyImmediate(this.largeItemsParent.GetChild(0).gameObject);
		}
		while (this.pageIndicatorsParent.childCount > 0)
		{
			UnityEngine.Object.DestroyImmediate(this.pageIndicatorsParent.GetChild(0).gameObject);
		}
		this.scrollView1Controller.isOnShuffleClick = true;
		this.IADPDLIEHBD();
	}

	// Token: 0x06002401 RID: 9217 RVA: 0x000F668A File Offset: 0x000F488A
	private void LBEMJPOHBGK()
	{
		this.ALGIAIKDEPH();
	}

	// Token: 0x06002402 RID: 9218 RVA: 0x00109568 File Offset: 0x00107768
	public void OnCardsVolSaleClickContinue()
	{
		this.OGHHLFOEJKO = DNPIKPDMKKI.MCOMGMOACEM(LJLAENEAOIM.liveOfferCardsVolSale);
		if (this.OGHHLFOEJKO != null)
		{
			LJNMIPMNOKF.EHBBFMCILPC.KNAEAJPDGKB(GCFLILHCOEI.cardsFilterNone, -1, this.OGHHLFOEJKO.OLNJMJMNBCN());
			this.ShowCardOptionsOrDownload();
			return;
		}
		CommonUserInterface.EHBBFMCILPC.HideConnectingAnimation();
		this.GBBHKFFENBE = false;
	}

	// Token: 0x06002403 RID: 9219 RVA: 0x001095B8 File Offset: 0x001077B8
	public void FHGDOCIIJIO()
	{
		FPEHHFKFBJK fpehhfkfbjk = null;
		try
		{
			fpehhfkfbjk = this.focusItem.GetComponent<FocusItem>().chapterSnapshotsItem.GDKLFFHGFOL();
		}
		catch (Exception aklgbjkdomm)
		{
			fpehhfkfbjk = null;
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
		if (fpehhfkfbjk != null && LanguageManager.EHBBFMCILPC.IEBFINIJAMJ() != CEIBHCNNIDC.en && LanguageManager.EHBBFMCILPC.IEBFINIJAMJ() != CEIBHCNNIDC.en)
		{
			try
			{
				AssetStoryHeader assetStoryHeader = null;
				if (null != this.HFFIIBBJBMH)
				{
					assetStoryHeader = GKJPOGNFKNK.CDCEFHLNNEC(this.HFFIIBBJBMH.header.availableStories[fpehhfkfbjk.MIBPOIDDBAD]);
				}
				if (assetStoryHeader != null && !this.CILHBPNJDFA(assetStoryHeader, fpehhfkfbjk.FEJANNNLLON, -1, LanguageManager.EHBBFMCILPC.GetSelectedLanguage()))
				{
					this.OnPlaySoonClick();
					return;
				}
			}
			catch (Exception aklgbjkdomm2)
			{
				DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm2);
			}
		}
		this.HideStoryRestartPopup();
		if (null != this.HFFIIBBJBMH)
		{
			int num = AKLFPGMDKLA.EHBBFMCILPC.MLIDICIPNDK(this.HFFIIBBJBMH.header.index).EKONMCADECD(-1);
			for (int i = 1; i <= num; i++)
			{
				if (i < this.HFFIIBBJBMH.header.availableStories.Count && AKLFPGMDKLA.EHBBFMCILPC.LAEKDOCIMBK(this.HFFIIBBJBMH.header.availableStories[i]))
				{
					AKLFPGMDKLA.EHBBFMCILPC.JDCBFAPDJIM(this.HFFIIBBJBMH.header.availableStories[i], -1).MOCHAJPADAJ(false);
				}
			}
			AKLFPGMDKLA.EHBBFMCILPC.EDHKCJCAFIO(this.HFFIIBBJBMH.header.index).LDPCILACGCO(1, -1);
		}
		AKLFPGMDKLA.EHBBFMCILPC.BJECGAMNDDH();
		this.EFPDMJBADBB(this.LGKGGPDKAHF);
		this.KGMEJHNLKHG();
	}

	// Token: 0x06002404 RID: 9220 RVA: 0x00109770 File Offset: 0x00107970
	private void FNPAKKIKJOF(List<string> AGPMOBFCLFK)
	{
		for (int i = 0; i < AGPMOBFCLFK.Count; i++)
		{
			if (!this.AOKDEICAFMM(AGPMOBFCLFK[i]))
			{
				return;
			}
		}
	}

	// Token: 0x06002405 RID: 9221 RVA: 0x001097A0 File Offset: 0x001079A0
	private void ICPIGGMCHEN()
	{
		this.LAENHLLONAI++;
		if (this.LAENHLLONAI >= KBOJLHAJPCP.LPJOFEDNKHA)
		{
			CommonUserInterface.EHBBFMCILPC.HideConnectingAnimation();
			FirebaseAnalyticsManager.EHBBFMCILPC.LogEvent(false, AGEHCPDNBFD.cdnActiv.ToString(), FFPHBMFGCNN.dldFail.ToString(), BGHLMGPPCNN.cdnWofToCut.ToString(), false, false);
			this.LAENHLLONAI = 0;
			CommonUserInterface.EHBBFMCILPC.ShowGenericPopupOneOverride(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("errortitle"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("cdnerror"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("retry"), new UnityAction(this.DownloadAssetBundleFolderLobby), DFGILFBGPLN.popupCdnDownloadFailed, 0f, 28);
			return;
		}
		this.DownloadAssetBundleFolderLobby();
	}

	// Token: 0x06002406 RID: 9222 RVA: 0x0010986C File Offset: 0x00107A6C
	private List<POKPDFKMOFC> PGJLBHNMHMP()
	{
		List<POKPDFKMOFC> result;
		try
		{
			if (this.CHDBIMNLHBC != null)
			{
				result = this.CHDBIMNLHBC;
			}
			else if (null == AssetsManager.EHBBFMCILPC || null == AssetsManager.EHBBFMCILPC.lobbyDataAsset)
			{
				result = null;
			}
			else
			{
				List<MJJBPLAMLAN> list = this.BBAGGFICFDK(AssetsManager.EHBBFMCILPC.lobbyDataAsset.JDMCDEKHDHM().ACPLGCFMOCE());
				EGBNGOMIJEE egbngomijee = this.ODJAPCCLBLE();
				List<MJJBPLAMLAN> list2 = new List<MJJBPLAMLAN>();
				for (int i = 0; i < list.Count; i++)
				{
					MJJBPLAMLAN mjjbplamlan = list[i];
					if (mjjbplamlan != null && mjjbplamlan.HPNIKIJKJEG && mjjbplamlan.GOMICAEJLAM && (egbngomijee == null || !egbngomijee.EEHAMAJIHOA || !mjjbplamlan.LJOAEJHFHIL))
					{
						list2.Add(mjjbplamlan);
					}
				}
				for (int j = 1; j < list2.Count; j++)
				{
					MJJBPLAMLAN mjjbplamlan2 = list2[j];
					int num = j - 1;
					while (num >= 0 && this.NFDFGBMMLBF(list2[num], mjjbplamlan2))
					{
						list2[num + 1] = list2[num];
						num--;
					}
					list2[num + 1] = mjjbplamlan2;
				}
				List<POKPDFKMOFC> list3 = new List<POKPDFKMOFC>();
				for (int k = 0; k < list2.Count; k++)
				{
					MJJBPLAMLAN mjjbplamlan3 = list2[k];
					List<int> list4 = new List<int>();
					List<float> list5 = new List<float>();
					for (int l = 0; l < mjjbplamlan3.JAPFMDOBPKJ.Count; l++)
					{
						int num2 = mjjbplamlan3.JAPFMDOBPKJ[l];
						if (!list4.Contains(num2) && this.GFNPELMOHNK(num2))
						{
							float num3 = this.CPOFEEGOFLP(num2);
							int num4 = list4.Count;
							while (num4 > 0 && list5[num4 - 1] < num3)
							{
								num4--;
							}
							list4.Insert(num4, num2);
							list5.Insert(num4, num3);
						}
					}
					if (list4.Count >= 1)
					{
						if (list4.Count > 3)
						{
							list4.RemoveRange(3, list4.Count - 3);
						}
						list3.Add(new POKPDFKMOFC
						{
							IEJLOIMDPDO = mjjbplamlan3.DBHMNECMIAB,
							JAPFMDOBPKJ = list4
						});
					}
				}
				this.CHDBIMNLHBC = list3;
				DPGJIJGOCIC.NFIDPOMCNLP(string.Concat(new string[]
				{
					"SceneLobbyManager2.GetStarterGroups() - ",
					list3.Count.ToString(),
					" group(s) from ",
					list2.Count.ToString(),
					" starter concept(s)"
				}));
				result = this.CHDBIMNLHBC;
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
			result = null;
		}
		return result;
	}

	// Token: 0x06002407 RID: 9223 RVA: 0x00003E52 File Offset: 0x00002052
	public void OnSearchFocusClosed()
	{
	}

	// Token: 0x06002408 RID: 9224 RVA: 0x00109B20 File Offset: 0x00107D20
	private void PDNHECGONHE()
	{
		GameObject[] array = new GameObject[]
		{
			this.cardsVolSaleButton,
			this.passesButton,
			this.skinShopButton
		};
		for (int i = 0; i < array.Length; i++)
		{
			if (!(null == array[i]))
			{
				AnimationTranslation component = array[i].GetComponent<AnimationTranslation>();
				if (null != component)
				{
					component.enabled = false;
				}
			}
		}
	}

	// Token: 0x06002409 RID: 9225 RVA: 0x00109B84 File Offset: 0x00107D84
	private void BLKMDHJFNFL()
	{
		CommonUserInterface.IKNOFBFMPGA().HideConnectingAnimation();
		CommonUserInterface.IKNOFBFMPGA().BGJFCEEDGFJ(CCOJBMMKNAP.PMABBOJDELF().PPALCPINPLK("errortitle"), CCOJBMMKNAP.KMNBCEMEBBD().OBDCPLLLGBB("p"), CCOJBMMKNAP.COKDLDOAACJ().GGPHHLGPMPA("err"), new UnityAction(this.OnSketchesButtonClick), (DFGILFBGPLN)(-9), 136f, -41);
		this.GBBHKFFENBE = false;
	}

	// Token: 0x0600240A RID: 9226 RVA: 0x00109BF0 File Offset: 0x00107DF0
	private void AAMCENHGBCM()
	{
		CommonUserInterface.EHBBFMCILPC.HideConnectingAnimation();
		CommonUserInterface.EHBBFMCILPC.ShowGenericPopupOneOverride(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("errortitle"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("app42error"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("retry"), new UnityAction(this.OnWheelOfFortuneClick), DFGILFBGPLN.popupBackendError, 0f, 28);
		this.GBBHKFFENBE = false;
	}

	// Token: 0x0600240B RID: 9227 RVA: 0x00109C5C File Offset: 0x00107E5C
	private static string FALBDONHAAL(string MJHGIIEINOE, string CABHBIJCMOM)
	{
		string text = CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP(MJHGIIEINOE);
		if (text == null || text.Length == 0 || text.EndsWith("_not_found"))
		{
			return CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP(CABHBIJCMOM);
		}
		return text;
	}

	// Token: 0x0600240C RID: 9228 RVA: 0x00109C9C File Offset: 0x00107E9C
	private void KAPHNFOEDPL()
	{
		try
		{
			if (!KHPGPLAMAIN.EJCNHEBIOJF() && KHPGPLAMAIN.IBDGNKGIMFI() != IIHCCPLGGHP.lowEnd)
			{
				CustomFaderSettings customFaderSettings = this.HFFIIBBJBMH.header.HGIIJABNDCD(100);
				if (customFaderSettings != null)
				{
					AssetsManager.EHBBFMCILPC.QueueAssetBundleDownload(NMKDCBPMCKI.AssetBundleCustomFader, customFaderSettings.assetIndex, -1, FLDBFOADFLH.finishDownloadAndProceed, false, false, false, null, -1, false, "", false, false);
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x0600240D RID: 9229 RVA: 0x00109D0C File Offset: 0x00107F0C
	private void NOGMNPGCAEK()
	{
		this.OBPPPNCALNP += 0;
		if (this.OBPPPNCALNP >= KBOJLHAJPCP.LPJOFEDNKHA)
		{
			this.OBPPPNCALNP = 0;
			FirebaseAnalyticsManager.DEALKJPEMMH().AAIABAKHLAH(true, AGEHCPDNBFD.d1Ret.ToString(), ((FFPHBMFGCNN)96).ToString(), ((BGHLMGPPCNN)111).ToString(), true, true);
			CommonUserInterface.EHBBFMCILPC.HideConnectingAnimation();
			CommonUserInterface.IKNOFBFMPGA().ShowGenericPopupTwoOverride(CCOJBMMKNAP.MPCBJEIMACA().JCDFHKDNEDH("+"), CCOJBMMKNAP.NIOJNOFGIJO().HHLECNIFHCO("</i>"), CCOJBMMKNAP.DLGLFACMHPG().DNILNCLIHAP(" Руб."), new UnityAction(this.JLFKKFCFJIC), new UnityAction(this.MMLFBNPEOPP), (DFGILFBGPLN)105, 1195f, 103);
			this.GBBHKFFENBE = true;
			return;
		}
		base.StartCoroutine(this.JPEPPPHJIBN());
	}

	// Token: 0x0600240E RID: 9230 RVA: 0x00109DF4 File Offset: 0x00107FF4
	private EGBNGOMIJEE PJPLKLDFCNO()
	{
		EGBNGOMIJEE egbngomijee = new EGBNGOMIJEE();
		try
		{
			List<int> list = AKLFPGMDKLA.EHBBFMCILPC.NJCPMPKNPHE();
			bool[] array = new bool[egbngomijee.OKAONKKBAFK.Length];
			List<int> list2 = new List<int>();
			for (int i = 1; i < list.Count; i++)
			{
				if (list[i] >= 1 && list[i] < egbngomijee.OKAONKKBAFK.Length && GOAEAMLNFOC.DLIKABOBPIO((JBBNEEHANHL)list[i]))
				{
					array[list[i]] = false;
					egbngomijee.OKAONKKBAFK[list[i]] = 541f;
					if (!list2.Contains(list[i]))
					{
						list2.Add(list[i]);
					}
				}
			}
			egbngomijee.OPDNPPGBELO = AKLFPGMDKLA.EHBBFMCILPC.LINADLBCHJC();
			List<int> list3 = AKLFPGMDKLA.EHBBFMCILPC.NOEIMOMKMCH();
			for (int j = 1; j < list3.Count; j += 0)
			{
				egbngomijee.NBABLDKAEBC.Add(list3[j]);
			}
			for (int k = 0; k < egbngomijee.OPDNPPGBELO.Count; k += 0)
			{
				if (!egbngomijee.NBABLDKAEBC.Contains(egbngomijee.OPDNPPGBELO[k]))
				{
					egbngomijee.NBABLDKAEBC.Add(egbngomijee.OPDNPPGBELO[k]);
				}
			}
			egbngomijee.ECOBLMDOBBF = AKLFPGMDKLA.EHBBFMCILPC.JCBEPJJHAII(AssetsManager.MJBDMHPHMID().anthologyAssets);
			float[] array2 = new float[egbngomijee.OKAONKKBAFK.Length];
			for (int l = 0; l < egbngomijee.NBABLDKAEBC.Count; l++)
			{
				List<JBBNEEHANHL> list4 = this.JNOKFMBPKMP(egbngomijee.NBABLDKAEBC[l]);
				int num = 1;
				while (num < list4.Count && num < 5)
				{
					float num2 = 268f;
					if (num == 0)
					{
						num2 = 1657f;
					}
					array2[(int)list4[num]] += num2;
					num += 0;
				}
			}
			for (int m = 1; m < egbngomijee.OKAONKKBAFK.Length; m++)
			{
				if (!array[m])
				{
					egbngomijee.OKAONKKBAFK[m] = Mathf.Clamp(array2[m], 688f, 1005f);
				}
			}
			bool flag = true;
			bool flag2 = false;
			egbngomijee.EEHAMAJIHOA = (flag2 || !flag || CEIBHCNNIDC.ru == LanguageManager.EHBBFMCILPC.NBANPEIHFOJ());
			string text = AKLFPGMDKLA.EHBBFMCILPC.EEHGLPEIIHD;
			if (text == null || text.Length == 0)
			{
				text = AKLFPGMDKLA.EHBBFMCILPC.HFDMBCHLCOJ;
			}
			if (text == null || text.Length == 0)
			{
				text = AKLFPGMDKLA.EHBBFMCILPC.EPFIHIAKPIH.Ticks.ToString();
			}
			egbngomijee.LBLLBJKKOAP = GOAEAMLNFOC.BPIKBAEIIAA(text);
			egbngomijee.JNKDDGGHOEA = GOAEAMLNFOC.FKKNGEFLDAN(egbngomijee.LBLLBJKKOAP, list2, egbngomijee.NBABLDKAEBC);
			long num3 = AKLFPGMDKLA.EHBBFMCILPC.CDNGHFCPPEA();
			egbngomijee.LOPKBMGNEGJ = (int)(num3 / 116L);
			egbngomijee.PBJGGLCJADD = (int)(num3 / -63L);
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
		return egbngomijee;
	}

	// Token: 0x0600240F RID: 9231 RVA: 0x0010A0F8 File Offset: 0x001082F8
	private Sprite HDBMEAPNFPK(JBBNEEHANHL HBBJBNJBMPK)
	{
		Sprite result;
		try
		{
			if (null == this.filterItemPrefab)
			{
				result = null;
			}
			else
			{
				FilterItem component = this.filterItemPrefab.GetComponent<FilterItem>();
				if (null == component || component.sprites == null)
				{
					result = null;
				}
				else if (HBBJBNJBMPK < JBBNEEHANHL.filterNew || HBBJBNJBMPK >= (JBBNEEHANHL)component.sprites.Length)
				{
					result = null;
				}
				else
				{
					result = component.sprites[(int)HBBJBNJBMPK];
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
			result = null;
		}
		return result;
	}

	// Token: 0x06002410 RID: 9232 RVA: 0x000EFDF5 File Offset: 0x000EDFF5
	private void FCKAGPPAAJN()
	{
		AKLFPGMDKLA.EHBBFMCILPC.LPCBDEBKAIM();
		Application.Quit();
	}

	// Token: 0x06002411 RID: 9233 RVA: 0x0010A174 File Offset: 0x00108374
	private void OPEGJAEFAJL()
	{
		for (int i = 0; i < this.cameras.Count; i++)
		{
			this.cameras[i].enabled = true;
		}
	}

	// Token: 0x06002412 RID: 9234 RVA: 0x0010A1AC File Offset: 0x001083AC
	private void PGBLKCAMKGN()
	{
		for (int i = 0; i < this.wheelItem.GetComponent<WheelItem>().lobbyCameras.Count; i++)
		{
			this.wheelItem.GetComponent<WheelItem>().lobbyCameras[i].enabled = true;
		}
	}

	// Token: 0x06002413 RID: 9235 RVA: 0x0010A1F8 File Offset: 0x001083F8
	private void IBPDFPGCOAI()
	{
		if (null != this.LGKGGPDKAHF)
		{
			try
			{
				this.UpdateAnthologiesHints();
			}
			catch (Exception aklgbjkdomm)
			{
				DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
			}
			AKLFPGMDKLA.EHBBFMCILPC.LPCBDEBKAIM();
			CommonUserInterface.IKNOFBFMPGA().ShowConnectingAnimationWithHint(CCOJBMMKNAP.CPCOODCFDDP().FIENAKIHNOM("$pt"), (byte)-19);
			BackendOperationsManager.EHBBFMCILPC.QueueRequestSaveChapterSnapshots();
			BackendOperationsManager.EHBBFMCILPC.QueueRequestSaveAvatarCollections();
			BackendOperationsManager.EHBBFMCILPC.RequestSaveSync("importanttitle", "$EXPORTVARS");
			SaveSlotsItem.slotDeleted = false;
			SaveSlotsItem.slotEdited = true;
			SaveSlotsItem.slotChanged = true;
			SaveSlotsItem.slotDuplicated = true;
			return;
		}
		AKLFPGMDKLA.EHBBFMCILPC.LPCBDEBKAIM();
		BackendOperationsManager.NPDDBAONMJP().OAGNCFDCNEK();
		BackendOperationsManager.NPDDBAONMJP().MDCEMMBDNFL();
		BackendOperationsManager.EHBBFMCILPC.BKAMILMMCOI("", "*");
		SaveSlotsItem.slotDeleted = false;
		SaveSlotsItem.slotEdited = false;
		SaveSlotsItem.slotChanged = false;
		SaveSlotsItem.slotDuplicated = false;
		CommonUserInterface.EHBBFMCILPC.ResumeUX();
	}

	// Token: 0x06002414 RID: 9236 RVA: 0x0010A2F0 File Offset: 0x001084F0
	private bool JGPMELNOCOM(int EADNDIDNMLH, PLFDAJJHMKO LFLOCKNKAKC)
	{
		if (EADNDIDNMLH < 0)
		{
			return true;
		}
		List<int> activeWardrobeMixList = SceneStoryManager.GetActiveWardrobeMixList(LFLOCKNKAKC);
		if (activeWardrobeMixList != null)
		{
			if (activeWardrobeMixList.Contains(EADNDIDNMLH))
			{
				return true;
			}
		}
		else if (LFLOCKNKAKC.NCAMFPGMCIG.OIBGFPEGLME == EADNDIDNMLH || LFLOCKNKAKC.NCAMFPGMCIG.OIBGFPEGLME < 0)
		{
			return true;
		}
		return SceneStoryManager.LoungeWardrobeVisited(EADNDIDNMLH, LFLOCKNKAKC);
	}

	// Token: 0x06002415 RID: 9237 RVA: 0x0010A33D File Offset: 0x0010853D
	private void FDHIFIEHEBM()
	{
		DPGJIJGOCIC.CMGOAFDBAOH("$CHOICEEXECUTED");
		PlayerPrefs.SetInt("Speed", 5);
		PlayerPrefs.Save();
	}

	// Token: 0x06002416 RID: 9238 RVA: 0x000F46A8 File Offset: 0x000F28A8
	[CompilerGenerated]
	private void OHGHMGPHLBM(JBBNEEHANHL AJLPALFJHCC)
	{
		this.BCOOKJICILK(AJLPALFJHCC);
	}

	// Token: 0x06002417 RID: 9239 RVA: 0x0010A35C File Offset: 0x0010855C
	private void OKKBOFKILEA()
	{
		for (int i = 0; i < this.cameras.Count; i++)
		{
			this.cameras[i].enabled = false;
		}
	}

	// Token: 0x06002418 RID: 9240 RVA: 0x000F668A File Offset: 0x000F488A
	private void ABCCMIBKPFL()
	{
		this.ALGIAIKDEPH();
	}

	// Token: 0x06002419 RID: 9241 RVA: 0x0010A394 File Offset: 0x00108594
	private List<int> BBDPPKKHFGO()
	{
		List<int> list = new List<int>();
		if (this.DFPNCCFNJJD == MNLBEMJOKNJ.openFocusItem && this.LFOLHJFLGKA >= 0)
		{
			list.Add(this.LFOLHJFLGKA);
		}
		else if (this.DFPNCCFNJJD == MNLBEMJOKNJ.shuffleUse && this.MFCGAFIHGKI.Count >= 0)
		{
			list.AddRange(this.MFCGAFIHGKI.GetRange(0, this.MFCGAFIHGKI.Count));
		}
		return list;
	}

	// Token: 0x0600241A RID: 9242 RVA: 0x0010A3FC File Offset: 0x001085FC
	public void OnPlayClickStart()
	{
		if (this.LDIGGOPHGMI.MNHHMKFBHDH(this.GKHNIMJJLJL.DHONIOBOLEL.CFGFOEEEJKJ) == null)
		{
			CommonUserInterface.EHBBFMCILPC.ShowGenericPopupOneOverride(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("errortitle"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("inkrevisionmissing"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("restartepisode") + " " + (this.MICMIKNOOEC + 1).ToString(), new UnityAction(this.OnRestartClick), DFGILFBGPLN.popupInkRevisionMissing, 0f, 28);
			return;
		}
		this.OnPlayClickExecute();
	}

	// Token: 0x0600241B RID: 9243 RVA: 0x0010A494 File Offset: 0x00108694
	public static bool IsGroupedFilter(JBBNEEHANHL HBBJBNJBMPK)
	{
		if (HBBJBNJBMPK <= JBBNEEHANHL.filterContinuePlaying)
		{
			if (HBBJBNJBMPK != JBBNEEHANHL.filterNew && HBBJBNJBMPK - JBBNEEHANHL.filterAll > 1)
			{
				return false;
			}
		}
		else if (HBBJBNJBMPK != JBBNEEHANHL.filterMostPopular && HBBJBNJBMPK - JBBNEEHANHL.filterFavorites > 4)
		{
			return false;
		}
		return true;
	}

	// Token: 0x0600241C RID: 9244 RVA: 0x0010A4B4 File Offset: 0x001086B4
	public string DumpSearchState()
	{
		StringBuilder stringBuilder = new StringBuilder();
		try
		{
			stringBuilder.Append(string.Concat(new string[]
			{
				"LobbySearch dump: active=",
				this.KOGLEPFNALN.ToString(),
				" query='",
				this.MJOMHIEMKMK,
				"' pending='",
				(SceneLobbyManager2.KAFNANCDMNF == null) ? "" : SceneLobbyManager2.KAFNANCDMNF,
				"'"
			}));
			stringBuilder.Append(string.Concat(new string[]
			{
				" candidates=",
				this.KPDGEKGMAKO.Count.ToString(),
				" results=",
				this.BPCHEOFFPCN.Count.ToString(),
				" padded=",
				this.EEGHJFAIMBF.Count.ToString()
			}));
			stringBuilder.Append(string.Concat(new string[]
			{
				" scenario=",
				this.DFPNCCFNJJD.ToString(),
				" lastFilter=",
				PlayerPrefs.GetString("lastFilter", ""),
				" lobbyIsLoading=",
				SceneLobbyManager2.lobbyIsLoading.ToString(),
				" focusOpened=",
				FocusItem.isFocusOpened.ToString()
			}));
			stringBuilder.Append(string.Concat(new string[]
			{
				" barAvailable=",
				(null != this.lobbySearchBar && this.lobbySearchBar.gameObject.activeSelf).ToString(),
				" barText='",
				(null == this.lobbySearchBar) ? "" : this.lobbySearchBar.GetText(),
				"'"
			}));
			stringBuilder.Append("\nresults=");
			for (int i = 0; i < this.BPCHEOFFPCN.Count; i++)
			{
				stringBuilder.Append(this.BPCHEOFFPCN[i].ToString() + (this.EEGHJFAIMBF.Contains(this.BPCHEOFFPCN[i]) ? "(pad)" : "") + " ");
			}
			string str = "none";
			if (null != this.FIBKHPMLNJN)
			{
				str = string.Concat(new string[]
				{
					this.FIBKHPMLNJN.activeSelf ? "shown" : "parked",
					"/",
					this.FIBKHPMLNJN.GetComponent<Toggle>().isOn ? "on" : "off",
					"/sibling",
					this.FIBKHPMLNJN.transform.GetSiblingIndex().ToString(),
					"/",
					this.filterItemsParent.childCount.ToString()
				});
			}
			stringBuilder.Append("\nchip=" + str + " filterItems=" + this.EKIFLHLCLKG.Count.ToString());
			int num = 0;
			int num2 = 0;
			int num3 = 0;
			int num4 = 0;
			int num5 = 0;
			for (int j = 0; j < this.MGNNOFPKGJF.Count; j++)
			{
				if (!(null == this.MGNNOFPKGJF[j]))
				{
					num3 += this.MGNNOFPKGJF[j].transform.childCount;
					if (SceneLobbyManager2.IsGroupedFilter(this.MGNNOFPKGJF[j].GetComponent<GridController>().filter))
					{
						num3 -= this.MGNNOFPKGJF[j].transform.childCount;
						num3 += this.MGNNOFPKGJF[j].GetComponentsInChildren<ThumbnailItem>(true).Length;
					}
					if (this.MGNNOFPKGJF[j].transform.childCount == 0)
					{
						num5++;
					}
					if (JBBNEEHANHL.filterSearch == this.MGNNOFPKGJF[j].GetComponent<GridController>().filter)
					{
						num++;
						num2 += this.MGNNOFPKGJF[j].transform.childCount;
						stringBuilder.Append("\nsearch grid " + (this.MGNNOFPKGJF[j].activeSelf ? "shown" : "hidden") + " cards=");
						for (int k = 0; k < this.MGNNOFPKGJF[j].transform.childCount; k++)
						{
							ThumbnailItem component = this.MGNNOFPKGJF[j].transform.GetChild(k).GetComponent<ThumbnailItem>();
							stringBuilder.Append(((null == component) ? "?" : component.index.ToString()) + " ");
						}
					}
				}
			}
			for (int l = 0; l < this.GMGKODLANOP.Count; l++)
			{
				if (null == this.GMGKODLANOP[l])
				{
					num4++;
				}
			}
			int childCount = this.scrollView0Content.childCount;
			int num6 = (childCount > 0) ? this.scrollView0Content.GetChild(childCount - 1).childCount : -1;
			stringBuilder.Append(string.Concat(new string[]
			{
				"\nsmallItemsParents=",
				this.MGNNOFPKGJF.Count.ToString(),
				" searchParents=",
				num.ToString(),
				" searchCards=",
				num2.ToString(),
				" parentCards=",
				num3.ToString(),
				" smallItems=",
				this.GMGKODLANOP.Count.ToString(),
				" nullSmallItems=",
				num4.ToString(),
				" emptyParents=",
				num5.ToString(),
				" scrollView0Content children=",
				childCount.ToString(),
				" lastChildCards=",
				num6.ToString()
			}));
		}
		catch (Exception ex)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(ex);
			stringBuilder.Append("\nEXCEPTION " + ex.Message);
		}
		return stringBuilder.ToString();
	}

	// Token: 0x0600241D RID: 9245 RVA: 0x0010AB04 File Offset: 0x00108D04
	private void LHGBCPLGLDB(int AMKCLHLIIMN, GameObject MIKAOBOCICP, JBBNEEHANHL GLOCCAIDHJC)
	{
		SceneLobbyManager2.AELKIAMLOBH aelkiamlobh = new SceneLobbyManager2.AELKIAMLOBH();
		aelkiamlobh.<>4__this = this;
		aelkiamlobh.filter = GLOCCAIDHJC;
		aelkiamlobh.tempAssetAnthologyPreview2 = null;
		aelkiamlobh.tempAssetAnthologyPreview2 = GKJPOGNFKNK.OGKPKBLFGMJ(AMKCLHLIIMN);
		if (!(null != aelkiamlobh.tempAssetAnthologyPreview2))
		{
			DPGJIJGOCIC.ANOPFDLPKGC("SceneLobbyManager.InstantiateLargeItems() - could not find AssetAnthologyPreview2 for anthology with index:" + AMKCLHLIIMN.ToString());
			return;
		}
		if (aelkiamlobh.filter == JBBNEEHANHL.filterNew)
		{
			SceneLobbyManager2.FLPFBMIBJDD flpfbmibjdd = new SceneLobbyManager2.FLPFBMIBJDD();
			flpfbmibjdd.CS$<>8__locals1 = aelkiamlobh;
			flpfbmibjdd.item = UnityEngine.Object.Instantiate<GameObject>(this.smallItemPrefab, MIKAOBOCICP.GetComponent<RectTransform>());
			this.GMGKODLANOP.Add(flpfbmibjdd.item);
			flpfbmibjdd.item.GetComponent<ThumbnailItem>().SetContent(flpfbmibjdd.CS$<>8__locals1.tempAssetAnthologyPreview2, new UnityAction(flpfbmibjdd.CEOCHAFMFLP), this.CBBNGDBFDPO[flpfbmibjdd.CS$<>8__locals1.tempAssetAnthologyPreview2.index], this.defaultTagSprite, this.inDevelopmentTagSprite, this.completedTagSprite, this.onHiatusTagSprite, null, this.CBCGEFKGFKH(flpfbmibjdd.CS$<>8__locals1.tempAssetAnthologyPreview2.index));
			this.CAOBCDPGEIM(flpfbmibjdd.item.GetComponent<ThumbnailItem>(), AMKCLHLIIMN, flpfbmibjdd.CS$<>8__locals1.filter);
			return;
		}
		if (aelkiamlobh.filter == JBBNEEHANHL.filterMostPopular)
		{
			SceneLobbyManager2.KLHKEHPOCNH klhkehpocnh = new SceneLobbyManager2.KLHKEHPOCNH();
			klhkehpocnh.CS$<>8__locals2 = aelkiamlobh;
			klhkehpocnh.item = UnityEngine.Object.Instantiate<GameObject>(this.smallItemPrefab, MIKAOBOCICP.GetComponent<RectTransform>());
			this.GMGKODLANOP.Add(klhkehpocnh.item);
			klhkehpocnh.item.GetComponent<ThumbnailItem>().SetContent(klhkehpocnh.CS$<>8__locals2.tempAssetAnthologyPreview2, new UnityAction(klhkehpocnh.IELEDLJCCMD), this.PMFMEBGNCME[klhkehpocnh.CS$<>8__locals2.tempAssetAnthologyPreview2.index], this.defaultTagSprite, this.inDevelopmentTagSprite, this.completedTagSprite, this.onHiatusTagSprite, PLBBPHIJMAH.BKOBNBMBFBC(klhkehpocnh.CS$<>8__locals2.tempAssetAnthologyPreview2.index), this.CBCGEFKGFKH(klhkehpocnh.CS$<>8__locals2.tempAssetAnthologyPreview2.index));
			int num = klhkehpocnh.item.transform.GetSiblingIndex();
			if (MIKAOBOCICP.transform.childCount > 0 && null != MIKAOBOCICP.transform.GetChild(0).GetComponent<CoverCardItem>())
			{
				num--;
			}
			klhkehpocnh.item.GetComponent<ThumbnailItem>().SetPopularNumber(num);
			this.CAOBCDPGEIM(klhkehpocnh.item.GetComponent<ThumbnailItem>(), AMKCLHLIIMN, klhkehpocnh.CS$<>8__locals2.filter);
			return;
		}
		SceneLobbyManager2.PKGNMBJJDAF pkgnmbjjdaf = new SceneLobbyManager2.PKGNMBJJDAF();
		pkgnmbjjdaf.CS$<>8__locals3 = aelkiamlobh;
		pkgnmbjjdaf.item = UnityEngine.Object.Instantiate<GameObject>(this.smallItemPrefab, MIKAOBOCICP.GetComponent<RectTransform>());
		this.GMGKODLANOP.Add(pkgnmbjjdaf.item);
		pkgnmbjjdaf.item.GetComponent<ThumbnailItem>().SetContent(pkgnmbjjdaf.CS$<>8__locals3.tempAssetAnthologyPreview2, new UnityAction(pkgnmbjjdaf.MKDNJEKKDBO), (JBBNEEHANHL.filterSearch == pkgnmbjjdaf.CS$<>8__locals3.filter) ? this.OBJKELOHJDH(pkgnmbjjdaf.CS$<>8__locals3.tempAssetAnthologyPreview2.index) : this.PMFMEBGNCME[pkgnmbjjdaf.CS$<>8__locals3.tempAssetAnthologyPreview2.index], this.defaultTagSprite, this.inDevelopmentTagSprite, this.completedTagSprite, this.onHiatusTagSprite, null, this.CBCGEFKGFKH(pkgnmbjjdaf.CS$<>8__locals3.tempAssetAnthologyPreview2.index));
		this.CAOBCDPGEIM(pkgnmbjjdaf.item.GetComponent<ThumbnailItem>(), AMKCLHLIIMN, pkgnmbjjdaf.CS$<>8__locals3.filter);
	}

	// Token: 0x0600241E RID: 9246 RVA: 0x0010AE4C File Offset: 0x0010904C
	private void NOBAIHNMLHP()
	{
		try
		{
			for (int i = 0; i < this.AAHJNGODNKI.Count; i++)
			{
				HAKFHALKMBH hakfhalkmbh = this.AAHJNGODNKI[i];
				if (hakfhalkmbh != null && !(null == hakfhalkmbh.NHOAHJMPCFC) && hakfhalkmbh.CCKABAENJPK != 0 && hakfhalkmbh.CKBJGCFCHGA < hakfhalkmbh.LGIAOIGIGPI.Count && hakfhalkmbh.NHOAHJMPCFC.activeInHierarchy)
				{
					RectTransform rectTransform = this.scrollView0Content.parent as RectTransform;
					if (!(null == rectTransform))
					{
						Vector3[] array = new Vector3[2];
						hakfhalkmbh.NHOAHJMPCFC.GetComponent<RectTransform>().GetWorldCorners(array);
						float y = rectTransform.InverseTransformPoint(array[1]).y;
						if (rectTransform.rect.yMin - y <= rectTransform.rect.height * 187f)
						{
							this.NHCNNBNPPMG(hakfhalkmbh, hakfhalkmbh.CCKABAENJPK);
						}
					}
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x0600241F RID: 9247 RVA: 0x0010AF60 File Offset: 0x00109160
	private float AIMMLDJOGDM(int PLKMJJIIJNO)
	{
		float result;
		try
		{
			IJLJDFKJIJM ijljdfkjijm = HKLPEDKJGFC.MMGOOHLBAFD(PLKMJJIIJNO);
			if (ijljdfkjijm == null)
			{
				result = 1790f;
			}
			else
			{
				result = ijljdfkjijm.BEKGIOLLBHL * ijljdfkjijm.NPCLFEAKBDB;
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
			result = 848f;
		}
		return result;
	}

	// Token: 0x06002420 RID: 9248 RVA: 0x0010AFB0 File Offset: 0x001091B0
	private bool DKMOLMKFGOJ()
	{
		return FocusItem.isFocusOpened || !(null != this.focusFade) || this.focusFade.activeSelf;
	}

	// Token: 0x06002421 RID: 9249 RVA: 0x0010AFD6 File Offset: 0x001091D6
	private IEnumerator IEGMGIEGIGJ()
	{
		if (GeoLocationManager.GeoZoneMayBeFirewalled(LanguageManager.EHBBFMCILPC.GetSelectedLanguage()))
		{
			App42Manager.EHBBFMCILPC.TryPingCustomCodeUrls();
			AssetsManager.EHBBFMCILPC.TryPingDepotDefaultUrls();
			float pingTimeTotal = 0f;
			while (!App42Manager.EHBBFMCILPC.CustomCodeUrlsHaveBeenPinged() || !AssetsManager.EHBBFMCILPC.DepotsUrlsHaveBeenPinged())
			{
				yield return new WaitForEndOfFrame();
				pingTimeTotal += Time.deltaTime;
				if (pingTimeTotal > (float)(KBOJLHAJPCP.MHKLILPDMII / 1000))
				{
					DPGJIJGOCIC.NFIDPOMCNLP("SceneLobbyManager2.OnReloadDelayed() ping timeout: break");
					IL_CB:
					if (!SceneLobbyManager2.HPDEAEBBKCJ && null != AssetsManager.EHBBFMCILPC.GetUrlPingManager() && AssetsManager.EHBBFMCILPC.GetUrlPingManager().GetPingableUrlsCount() == 1)
					{
						App42Manager.EHBBFMCILPC.EnableKillInfiniteRequestPrematureBasedOnMedianRequestsLifeTime();
					}
					SceneLobbyManager2.HPDEAEBBKCJ = true;
					goto IL_106;
				}
			}
			DPGJIJGOCIC.NFIDPOMCNLP("SceneLobbyManager2.OnReloadDelayed() CustomCodeUrlsHaveBeenPinged && DepotsUrlsHaveBeenPinged: break");
			goto IL_CB;
		}
		IL_106:
		yield return new WaitForSeconds(0.05f);
		this.MNGIPAFFFEA();
		yield break;
	}

	// Token: 0x06002422 RID: 9250 RVA: 0x0010AFE8 File Offset: 0x001091E8
	private void KHELKJHAPPJ()
	{
		CommonUserInterface.EHBBFMCILPC.HideConnectingAnimation();
		CommonUserInterface.EHBBFMCILPC.ShowGenericPopupOneOverride(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("errortitle"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("app42error"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("retry"), new UnityAction(this.OnSketchesButtonClick), DFGILFBGPLN.popupBackendError, 0f, 28);
		this.GBBHKFFENBE = false;
	}

	// Token: 0x06002423 RID: 9251 RVA: 0x0010B054 File Offset: 0x00109254
	private static SceneLobbyManager2.BBNDCCPKNJL JAGPHAPKGDF(List<SceneLobbyManager2.BBNDCCPKNJL> JOFCKIFBACA, int IPPEMBAHDMD)
	{
		if (JOFCKIFBACA.Count == 0)
		{
			return null;
		}
		int num = Mathf.Min(3, JOFCKIFBACA.Count);
		float num2 = 0f;
		for (int i = 0; i < num; i++)
		{
			if (IPPEMBAHDMD <= 0 || JOFCKIFBACA[i].IEIAICGOENJ.Length <= IPPEMBAHDMD)
			{
				num2 += JOFCKIFBACA[i].AGMOECJFFJI * JOFCKIFBACA[i].AGMOECJFFJI * JOFCKIFBACA[i].AGMOECJFFJI;
			}
		}
		if (num2 <= 0f)
		{
			SceneLobbyManager2.BBNDCCPKNJL bbndccpknjl = JOFCKIFBACA[0];
			for (int j = 1; j < num; j++)
			{
				if (JOFCKIFBACA[j].IEIAICGOENJ.Length < bbndccpknjl.IEIAICGOENJ.Length)
				{
					bbndccpknjl = JOFCKIFBACA[j];
				}
			}
			return bbndccpknjl;
		}
		float num3 = UnityEngine.Random.value * num2;
		float num4 = 0f;
		for (int k = 0; k < num; k++)
		{
			if (IPPEMBAHDMD <= 0 || JOFCKIFBACA[k].IEIAICGOENJ.Length <= IPPEMBAHDMD)
			{
				num4 += JOFCKIFBACA[k].AGMOECJFFJI * JOFCKIFBACA[k].AGMOECJFFJI * JOFCKIFBACA[k].AGMOECJFFJI;
				if (num3 <= num4)
				{
					return JOFCKIFBACA[k];
				}
			}
		}
		return JOFCKIFBACA[0];
	}

	// Token: 0x06002424 RID: 9252 RVA: 0x0010B198 File Offset: 0x00109398
	private void FLOAFHNAKJM()
	{
		CommonUserInterface.EHBBFMCILPC.HideConnectingAnimation();
		CommonUserInterface.EHBBFMCILPC.ShowGenericPopup(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("errortitle"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("app42error"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("ok"), DFGILFBGPLN.popupBackendError, 0f, 28);
	}

	// Token: 0x06002425 RID: 9253 RVA: 0x0010B1F0 File Offset: 0x001093F0
	private float CPOFEEGOFLP(int PLKMJJIIJNO)
	{
		float result;
		try
		{
			IJLJDFKJIJM ijljdfkjijm = HKLPEDKJGFC.MMGOOHLBAFD(PLKMJJIIJNO);
			if (ijljdfkjijm == null)
			{
				result = 0f;
			}
			else
			{
				result = ijljdfkjijm.BEKGIOLLBHL * ijljdfkjijm.NPCLFEAKBDB;
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
			result = 0f;
		}
		return result;
	}

	// Token: 0x06002426 RID: 9254 RVA: 0x0010B240 File Offset: 0x00109440
	private void CFLAECDEFDE()
	{
		DPGJIJGOCIC.NFIDPOMCNLP("favstostr2");
		PlayerPrefs.SetInt("+", 4);
		PlayerPrefs.Save();
		DPGJIJGOCIC.IJADBLJOAHE();
	}

	// Token: 0x06002427 RID: 9255 RVA: 0x0010B264 File Offset: 0x00109464
	private void LBFDDEFKCJN()
	{
		for (int i = 0; i < this.lobbyParticles.Count; i++)
		{
			if (null != this.lobbyParticles[i])
			{
				this.lobbyParticles[i].gameObject.SetActive(true);
				this.lobbyParticles[i].Play();
			}
		}
		this.EPDHPBPMLLO();
		if (this.IPAFGLONDJF)
		{
			if (1 == AKLFPGMDKLA.EHBBFMCILPC.PACMCEHMBGG)
			{
				AudioManager.EHBBFMCILPC.PlayMusic("lobby", true, -1f, false);
			}
			this.PGBLKCAMKGN();
			this.IAPJENPEBLG();
			AssetsManager.EHBBFMCILPC.DestroyAssetBundleAssets(NMKDCBPMCKI.AssetBundleCutsceneView, -1);
			this.OnPopupCardOptionsReopen();
			this.IPAFGLONDJF = false;
		}
	}

	// Token: 0x06002428 RID: 9256 RVA: 0x000FA623 File Offset: 0x000F8823
	public void OnPopupCardOptionsNextClickLobby()
	{
		LobbyUserInterface.EHBBFMCILPC.GetPopupCardOptions().FlipVerticalAnimatedPopupManagerAnimationsScale();
		this.ShowCardOptionsOrDownload();
	}

	// Token: 0x06002429 RID: 9257 RVA: 0x0010B31C File Offset: 0x0010951C
	private void MHFIHLIELBH(JBBNEEHANHL GLOCCAIDHJC, GameObject MIKAOBOCICP)
	{
		List<int> list = this.DGPAFDKHLJL(GLOCCAIDHJC);
		for (int i = 0; i < list.Count; i++)
		{
			this.LHGBCPLGLDB(list[i], MIKAOBOCICP, GLOCCAIDHJC);
		}
	}

	// Token: 0x0600242A RID: 9258 RVA: 0x0010B351 File Offset: 0x00109551
	private IEnumerator CHGNEAGFGDC(GameObject JFKDEMMNEGP)
	{
		if (null != JFKDEMMNEGP)
		{
			yield return new WaitForEndOfFrame();
			JFKDEMMNEGP.gameObject.GetComponent<RectTransform>().EFOCKEJENAC(80f);
			yield return new WaitForEndOfFrame();
			JFKDEMMNEGP.gameObject.SetActive(false);
			yield return new WaitForEndOfFrame();
			JFKDEMMNEGP.gameObject.SetActive(true);
			yield return new WaitForEndOfFrame();
		}
		yield break;
	}

	// Token: 0x0600242B RID: 9259 RVA: 0x0010B360 File Offset: 0x00109560
	private void FECFNFKHLKM()
	{
		this.NEEMPAAFHEI++;
		if (this.NEEMPAAFHEI >= KBOJLHAJPCP.LPJOFEDNKHA)
		{
			CommonUserInterface.EHBBFMCILPC.HideConnectingAnimation();
			FirebaseAnalyticsManager.EHBBFMCILPC.LogEvent(false, AGEHCPDNBFD.cdnActiv.ToString(), FFPHBMFGCNN.dldFail.ToString(), BGHLMGPPCNN.cdnLbyToPrf.ToString(), false, false);
			this.NEEMPAAFHEI = 0;
			CommonUserInterface.EHBBFMCILPC.ShowGenericPopupOneOverride(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("errortitle"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("cdnerror"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("retry"), new UnityAction(this.MOCCHMAHHNK), DFGILFBGPLN.popupCdnDownloadFailed, 0f, 28);
			this.GBBHKFFENBE = false;
			return;
		}
		this.MOCCHMAHHNK();
	}

	// Token: 0x0600242C RID: 9260 RVA: 0x0010B434 File Offset: 0x00109634
	private void IDLPKJBJKCP()
	{
		try
		{
			if (this.MPEKBFHNOOK != null)
			{
				base.StopCoroutine(this.MPEKBFHNOOK);
			}
			this.MPEKBFHNOOK = base.StartCoroutine(this.LDALFHBEDFC());
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x0600242D RID: 9261 RVA: 0x0010B480 File Offset: 0x00109680
	private void COGPAPBAPIA()
	{
		this.disclaimerImpers.text = CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("copyrightlobby");
	}

	// Token: 0x0600242E RID: 9262 RVA: 0x0010B49C File Offset: 0x0010969C
	private void HNDHIAEMNAJ()
	{
		try
		{
			if (!(null == this.FIBKHPMLNJN) && this.FIBKHPMLNJN.activeInHierarchy)
			{
				FilterItem component = this.FIBKHPMLNJN.GetComponent<FilterItem>();
				if (null != component)
				{
					component.PulseIcon();
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x0600242F RID: 9263 RVA: 0x0010B4FC File Offset: 0x001096FC
	private List<KLJCEMBNKNI> NLALKLBLNDF(JBBNEEHANHL HBBJBNJBMPK)
	{
		if (HBBJBNJBMPK != JBBNEEHANHL.filterNew)
		{
			switch (HBBJBNJBMPK)
			{
			case JBBNEEHANHL.filterAll:
				return this.DEFGJKADGKB();
			case JBBNEEHANHL.filterContinuePlaying:
				return this.HOCALHHJHNE();
			case JBBNEEHANHL.filterTopRated:
			case JBBNEEHANHL.filterSpecialEpisodes:
				break;
			case JBBNEEHANHL.filterMostPopular:
				return this.OKPNLKEBMPH();
			default:
				switch (HBBJBNJBMPK)
				{
				case JBBNEEHANHL.filterTopRated:
					return this.FDDNNGNHMFP();
				case JBBNEEHANHL.filterSpecialEpisodes:
					return this.LIAHCBGCPEN();
				case JBBNEEHANHL.filterMostPopular:
					return this.HMJLJCLPLIK();
				case JBBNEEHANHL.filterNone:
					return this.CHIGBPGKPFI();
				case JBBNEEHANHL.newFilterAdventure:
					return this.GNPBHDFEEHE();
				}
				break;
			}
			return new List<KLJCEMBNKNI>();
		}
		return this.PGBKAHOGNGO();
	}

	// Token: 0x06002430 RID: 9264 RVA: 0x0010B58C File Offset: 0x0010978C
	public void ViewCutsceneLobby(BNFCLKNDBLO CIBKELALAHF)
	{
		if (CIBKELALAHF != null)
		{
			if (CIBKELALAHF.LHNIAKBBPDN() > 0 && !KHPGPLAMAIN.DFJHJCAIFJO())
			{
				CommonUserInterface.EHBBFMCILPC.ShowGenericPopup(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("importanttitle"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("novideosupportmsg"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("ok"), DFGILFBGPLN.popupEnergyHint, 0f, 28);
				return;
			}
			this.BMODBEEEABE = CIBKELALAHF;
			AssetsManager.EHBBFMCILPC.UnloadPersistentAssetBundles();
			this.DownloadAssetBundleFolderLobby();
		}
	}

	// Token: 0x06002431 RID: 9265 RVA: 0x0010B608 File Offset: 0x00109808
	private void KKKKNGFMEHF()
	{
		this.teaText.GetComponent<AnimationTextIncrement>().Set(AKLFPGMDKLA.EHBBFMCILPC.MPMKMCJFHOG.GALKFKBPLCK(), 1f, 0f);
		this.diamondsText.GetComponent<AnimationTextIncrement>().Set(AKLFPGMDKLA.EHBBFMCILPC.ODMKLADKHMO.GALKFKBPLCK(), 1f, 0f);
	}

	// Token: 0x06002432 RID: 9266 RVA: 0x001085B0 File Offset: 0x001067B0
	private IEnumerator CPKEKFFODHH()
	{
		this.GBBHKFFENBE = true;
		ProfileItem2.expandCollectedCardsByDefault = false;
		ProfileItem2.expandBadgesByDefault = false;
		AssetsManager.EHBBFMCILPC.GetLoadingProgressSnapshot().EPJKDCDOEMM(0);
		CommonUserInterface.EHBBFMCILPC.ShowConnectingAnimationWithProgress(96);
		yield return new WaitForEndOfFrame();
		while (AssetsManager.EHBBFMCILPC.IsBusy())
		{
			DPGJIJGOCIC.NFIDPOMCNLP("SceneLobbyManager2.OpenPublicProfile(): AssetsManager.Instance.IsBusy()");
			yield return new WaitForSeconds(0.05f);
		}
		if (!KDCJJBLGCBH.EHBBFMCILPC.PJFKDFIDPGH() && null == AssetsManager.EHBBFMCILPC.profileDataAsset6 && !this.CGPGMJKCBBJ)
		{
			AssetsManager.EHBBFMCILPC.GetLoadingProgressSnapshot().CLIOEOLFFLO(LEJKDNAGDHC.Fast);
			AssetsManager.EHBBFMCILPC.GetLoadingProgressSnapshot().GIJKJMMDJEL(0f, 1f);
			AssetsManager.EHBBFMCILPC.QueueLiveProfileThumbnailsBundle();
			AssetsManager.EHBBFMCILPC.DownloadQueuedAssetBundles("OnLiveProfileThumbnailsCdnSuccess", "OnLiveProfileThumbnailsCdnFailed", true);
			yield return new WaitForEndOfFrame();
			while (AssetsManager.EHBBFMCILPC.IsBusy())
			{
				yield return new WaitForSeconds(0.05f);
			}
			if (null == AssetsManager.EHBBFMCILPC.profileDataAsset6)
			{
				this.IMOHHHALBAP++;
				if (this.IMOHHHALBAP >= 2)
				{
					this.CGPGMJKCBBJ = true;
				}
				DPGJIJGOCIC.ADFCDFHBDAF("SceneLobbyManager2.OpenPublicProfile(): live profile theme thumbnails unavailable (miss " + this.IMOHHHALBAP.ToString() + "), the full themes load as before");
			}
			AssetsManager.EHBBFMCILPC.GetLoadingProgressSnapshot().EPJKDCDOEMM(0);
		}
		int num = (int)LanguageManager.EHBBFMCILPC.GetSelectedLanguage();
		if (num > 1)
		{
			num = 0;
		}
		AssetsManager.EHBBFMCILPC.QueueAssetBundleDownload(NMKDCBPMCKI.AssetBundleProfileDataLocalized, num, -1, FLDBFOADFLH.finishDownloadAndProceed, false, false, false, null, -1, false, "", false, false);
		AssetsManager.EHBBFMCILPC.QueueAssetBundleDownload(NMKDCBPMCKI.AssetBundleProfileData, 0, -1, FLDBFOADFLH.finishDownloadAndProceed, false, false, false, null, -1, false, "", false, false);
		for (int i = 0; i < AssetsManager.EHBBFMCILPC.lobbyDataAsset.maxAnthologyIndex + 1; i++)
		{
			if (true)
			{
				AssetsManager.EHBBFMCILPC.QueueAssetBundleDownload(NMKDCBPMCKI.AssetBundleProfilePack, i, -1, FLDBFOADFLH.startDownloadAndProceed, false, false, false, null, -1, false, "", false, false);
			}
		}
		if (null != AssetsManager.EHBBFMCILPC.lobbyDataAsset)
		{
			AssetsManager.EHBBFMCILPC.lobbyDataAsset.NHOLIOGAEKK();
			for (int j = 0; j < AssetsManager.EHBBFMCILPC.lobbyDataAsset.maxLiveProfileThemeId + 1; j++)
			{
				if (!(null != AssetsManager.EHBBFMCILPC.profileDataAsset6) || !AssetsManager.EHBBFMCILPC.profileDataAsset6.IOBAGEDAJKE(j))
				{
					AssetsManager.EHBBFMCILPC.QueueAssetBundleDownload(NMKDCBPMCKI.AssetBundleLiveProfileTheme, j, -1, FLDBFOADFLH.startDownloadAndProceed, false, false, false, null, -1, false, "", false, false);
				}
			}
		}
		for (int k = 0; k < AssetsManager.EHBBFMCILPC.anthologyAssets.Count; k++)
		{
			if (null != AssetsManager.EHBBFMCILPC.anthologyAssets[k] && AssetsManager.EHBBFMCILPC.anthologyAssets[k].header.enableIconsPack)
			{
				AssetsManager.EHBBFMCILPC.QueueAssetBundleDownload(NMKDCBPMCKI.AssetBundleIconsPack, AssetsManager.EHBBFMCILPC.anthologyAssets[k].header.CKACBBGHJGI(), -1, FLDBFOADFLH.startDownloadAndProceed, false, false, false, null, -1, false, "", false, false);
			}
		}
		AssetsManager.EHBBFMCILPC.QueueAssetBundleDownload(NMKDCBPMCKI.AssetBundleProfileData2, 0, -1, FLDBFOADFLH.startDownloadAndProceed, false, false, false, null, -1, false, "", false, false);
		AssetsManager.EHBBFMCILPC.QueueAssetBundleDownload(NMKDCBPMCKI.AssetBundleProfileData3, 0, -1, FLDBFOADFLH.startDownloadAndProceed, false, false, false, null, -1, false, "", false, false);
		AssetsManager.EHBBFMCILPC.GetLoadingProgressSnapshot().CLIOEOLFFLO(LEJKDNAGDHC.Slow);
		AssetsManager.EHBBFMCILPC.GetLoadingProgressSnapshot().GIJKJMMDJEL(0f, 1f);
		AssetsManager.EHBBFMCILPC.DownloadQueuedAssetBundles("OnLobbyProfileDataCdnSuccess", "OnLobbyProfileDataCdnFailed", false);
		yield break;
	}

	// Token: 0x06002433 RID: 9267 RVA: 0x0010B667 File Offset: 0x00109867
	private void KLLKPDGCMLH()
	{
		if (KHPGPLAMAIN.GOABDECAOAM())
		{
			AccountSignInManager.EHBBFMCILPC.StartSignInLogic(HHCKLPJJKIJ.google, JCAPGCCNOMP.auto, HHCKLPJJKIJ.device, 0);
			return;
		}
		AccountSignInManager.EHBBFMCILPC.StartSignInLogic(HHCKLPJJKIJ.device, JCAPGCCNOMP.auto, HHCKLPJJKIJ.none, 0);
	}

	// Token: 0x06002434 RID: 9268 RVA: 0x000ED5D4 File Offset: 0x000EB7D4
	private void MICIKCIBLCP()
	{
		CommonUserInterface.EHBBFMCILPC.HideConnectingAnimation();
		this.LDENMOBNFIP();
	}

	// Token: 0x06002435 RID: 9269 RVA: 0x0010B690 File Offset: 0x00109890
	private void CMKPNGPCDAB()
	{
		AKLFPGMDKLA.EHBBFMCILPC.GLKNOFHEBKN = -1;
		AKLFPGMDKLA.EHBBFMCILPC.IEGJCPDCLMM = -1;
		this.IDJEMNCLFDN();
		PlayerPrefs.DeleteKey("lastFilter");
		PlayerPrefs.DeleteKey("lastFilterTapped");
		PlayerPrefs.Save();
		CommonUserInterface.EHBBFMCILPC.ShowGenericPopupTwoOverride(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("importanttitle"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("needtorestartgeneric"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("ok"), new UnityAction(this.FKPLFIDCPLP), new UnityAction(this.FKPLFIDCPLP), DFGILFBGPLN.popupSignInSuccess, 0.2f, 28);
	}

	// Token: 0x06002436 RID: 9270 RVA: 0x0010B72C File Offset: 0x0010992C
	public void RestartChapterSilent(AssetStoryHeader JFCABBGNNKJ, PLFDAJJHMKO BAOKJBJIFBH)
	{
		BAOKJBJIFBH.KJKMJBMFDAN();
		BackendOperationsManager.EHBBFMCILPC.PostponeRequestRestartChapterOrStory(AKLFPGMDKLA.ACFJMCBMOFG(JFCABBGNNKJ.index, AKLFPGMDKLA.EHBBFMCILPC.NCOCIAENGJF(JFCABBGNNKJ.index)));
		AKLFPGMDKLA.EHBBFMCILPC.EACONLGBIFC(AKLFPGMDKLA.ACFJMCBMOFG(JFCABBGNNKJ.index, AKLFPGMDKLA.EHBBFMCILPC.NCOCIAENGJF(JFCABBGNNKJ.index)), BAOKJBJIFBH.DHONIOBOLEL.DDEDAHCFHJN());
		DPGJIJGOCIC.ANOPFDLPKGC("Error: SceneLobbyManager2.RestartChapterSilent() hit. Send this message to Vlad.");
	}

	// Token: 0x06002437 RID: 9271 RVA: 0x0010B7A0 File Offset: 0x001099A0
	private void PBDBLMMMMFF()
	{
		if (AKLFPGMDKLA.EHBBFMCILPC.JBBAANGAFKO.Count > 0)
		{
			AssetAnthologyPreview2 assetAnthologyPreview = GKJPOGNFKNK.OGKPKBLFGMJ(AKLFPGMDKLA.EHBBFMCILPC.JBBAANGAFKO[DPGJIJGOCIC.IOOHGEJIPFP(0, AKLFPGMDKLA.EHBBFMCILPC.JBBAANGAFKO.Count)]);
			if (null != assetAnthologyPreview)
			{
				this.CPLLGNAKIIL(assetAnthologyPreview);
			}
			DPGJIJGOCIC.NFIDPOMCNLP("SceneLobbyManager2.OnRewardReplayEpisodeClick() getting one random out of " + AKLFPGMDKLA.EHBBFMCILPC.JBBAANGAFKO.Count.ToString());
		}
	}

	// Token: 0x06002438 RID: 9272 RVA: 0x0010B81F File Offset: 0x00109A1F
	private IEnumerator LKPOMOJBIOO()
	{
		SceneLobbyManager2.FFKKBMBOOMG ffkkbmboomg = new SceneLobbyManager2.FFKKBMBOOMG(1);
		ffkkbmboomg.<>4__this = this;
		return ffkkbmboomg;
	}

	// Token: 0x06002439 RID: 9273 RVA: 0x0010B830 File Offset: 0x00109A30
	public void BLFEJNEBHGL()
	{
		if (KDCJJBLGCBH.EHBBFMCILPC.DJHCAFAEILH())
		{
			this.profileButtonAvailable.gameObject.SetActive(true);
			this.profileButtonHidden.gameObject.SetActive(true);
			return;
		}
		this.profileButtonHidden.gameObject.SetActive(false);
		if (!AKLFPGMDKLA.EHBBFMCILPC.GNLNPMPJPEC())
		{
			this.profileButtonAvailable.gameObject.SetActive(true);
			this.profileButtonOffline.gameObject.SetActive(true);
			return;
		}
		this.profileButtonAvailable.gameObject.SetActive(false);
		this.profileButtonOffline.gameObject.SetActive(false);
	}

	// Token: 0x0600243A RID: 9274 RVA: 0x0010B8D0 File Offset: 0x00109AD0
	public void OnChapterSnapshotRestoreExecute()
	{
		FPEHHFKFBJK fpehhfkfbjk = null;
		try
		{
			fpehhfkfbjk = this.focusItem.GetComponent<FocusItem>().chapterSnapshotsItem.GetLastChapterSnapshotRestoreDesc();
		}
		catch (Exception aklgbjkdomm)
		{
			fpehhfkfbjk = null;
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
		if (fpehhfkfbjk != null && LanguageManager.EHBBFMCILPC.GetSelectedLanguage() != CEIBHCNNIDC.en && LanguageManager.EHBBFMCILPC.GetSelectedLanguage() != CEIBHCNNIDC.ru)
		{
			try
			{
				AssetStoryHeader assetStoryHeader = null;
				if (null != this.HFFIIBBJBMH)
				{
					assetStoryHeader = GKJPOGNFKNK.CDCEFHLNNEC(this.HFFIIBBJBMH.header.availableStories[fpehhfkfbjk.MIBPOIDDBAD]);
				}
				if (assetStoryHeader != null && !this.CILHBPNJDFA(assetStoryHeader, fpehhfkfbjk.FEJANNNLLON, -1, LanguageManager.EHBBFMCILPC.GetSelectedLanguage()))
				{
					this.OnPlaySoonClick();
					return;
				}
			}
			catch (Exception aklgbjkdomm2)
			{
				DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm2);
			}
		}
		if (fpehhfkfbjk != null && fpehhfkfbjk.PMDMNNBJEEP && null != this.HFFIIBBJBMH)
		{
			int num = AKLFPGMDKLA.EHBBFMCILPC.LMGMHHLLOFN(this.HFFIIBBJBMH.header.index).EGHHCFFLPCP(-1);
			if (fpehhfkfbjk.MIBPOIDDBAD < num)
			{
				for (int i = fpehhfkfbjk.MIBPOIDDBAD + 1; i <= num; i++)
				{
					if (i < this.HFFIIBBJBMH.header.availableStories.Count && AKLFPGMDKLA.EHBBFMCILPC.LAEKDOCIMBK(this.HFFIIBBJBMH.header.availableStories[i]))
					{
						AKLFPGMDKLA.EHBBFMCILPC.JDCBFAPDJIM(this.HFFIIBBJBMH.header.availableStories[i], -1).EPJKDCDOEMM(true);
					}
				}
			}
			AKLFPGMDKLA.EHBBFMCILPC.LMGMHHLLOFN(this.HFFIIBBJBMH.header.index).LDPCILACGCO(fpehhfkfbjk.MIBPOIDDBAD, -1);
			this.LDIGGOPHGMI = GKJPOGNFKNK.CDCEFHLNNEC(this.HFFIIBBJBMH.header.availableStories[fpehhfkfbjk.MIBPOIDDBAD]);
			this.GKHNIMJJLJL = AKLFPGMDKLA.EHBBFMCILPC.JDCBFAPDJIM(this.HFFIIBBJBMH.header.availableStories[fpehhfkfbjk.MIBPOIDDBAD], -1);
			if (null != this.LDIGGOPHGMI && this.GKHNIMJJLJL != null && this.GKHNIMJJLJL.EBGCEGFBEBN(fpehhfkfbjk.FEJANNNLLON))
			{
				BackendOperationsManager.EHBBFMCILPC.PostponeRequestRestartChapterOrStory(AKLFPGMDKLA.ACFJMCBMOFG(this.LDIGGOPHGMI.index, AKLFPGMDKLA.EHBBFMCILPC.NCOCIAENGJF(this.LDIGGOPHGMI.index)));
				AKLFPGMDKLA.EHBBFMCILPC.EACONLGBIFC(AKLFPGMDKLA.ACFJMCBMOFG(this.LDIGGOPHGMI.index, AKLFPGMDKLA.EHBBFMCILPC.NCOCIAENGJF(this.LDIGGOPHGMI.index)), this.GKHNIMJJLJL.DHONIOBOLEL.DDEDAHCFHJN());
				AKLFPGMDKLA.EHBBFMCILPC.BJECGAMNDDH();
				this.EFPDMJBADBB(this.LGKGGPDKAHF);
				this.OnPlayClickStart();
			}
		}
	}

	// Token: 0x0400099C RID: 2460
	public static int freePlayPassAnthologyIndex = -1;

	// Token: 0x0400099D RID: 2461
	private static bool LIDGNAFABAH = false;

	// Token: 0x0400099E RID: 2462
	private static bool CHGGOOEADOC = false;

	// Token: 0x0400099F RID: 2463
	public static int currentlyPlayingAnthology = -1;

	// Token: 0x040009A0 RID: 2464
	public static int newSaveSystemErrorCode0 = -1;

	// Token: 0x040009A1 RID: 2465
	public static int newSaveSystemErrorCode1 = -1;

	// Token: 0x040009A2 RID: 2466
	public static int newSaveSystemErrorCode2 = -1;

	// Token: 0x040009A3 RID: 2467
	public static int selectedFirstStoryOffering = -1;

	// Token: 0x040009A4 RID: 2468
	public static int anthologyPropertiesInitializationCounter = 0;

	// Token: 0x040009A5 RID: 2469
	public static bool returnedFromCompletedStoryChapter = false;

	// Token: 0x040009A6 RID: 2470
	public static bool returnedFromStory = false;

	// Token: 0x040009A7 RID: 2471
	public static bool lobbyIsLoading = false;

	// Token: 0x040009A8 RID: 2472
	public static bool anthologyIsComplete = false;

	// Token: 0x040009A9 RID: 2473
	public const string onNeedToShowNoMoreEnergyPopup = "OnNeedToShowNoMoreEnergyPopup";

	// Token: 0x040009AA RID: 2474
	public const string onNeedToShowNoMoreHardPopup = "OnNeedToShowNoMoreHardPopup";

	// Token: 0x040009AB RID: 2475
	private const string IEBOBPDGOCL = "OnSceneLobbyManagerExitSyncSuccess";

	// Token: 0x040009AC RID: 2476
	private const string FNGPJCEPOFK = "OnSceneLobbyManagerRound0AssetsDownloadSuccess";

	// Token: 0x040009AD RID: 2477
	private const string OHGADLLPANL = "OnSceneLobbyManagerRound0aAssetsDownloadSuccess";

	// Token: 0x040009AE RID: 2478
	private const string GDNGNPCIHJJ = "OnSceneLobbyManagerRound0aaAssetsDownloadSuccess";

	// Token: 0x040009AF RID: 2479
	private const string AKBFJOFIJIK = "OnSceneLobbyManagerRound1AssetsDownloadSuccess";

	// Token: 0x040009B0 RID: 2480
	private const string MLEMBHJALLN = "OnSceneLobbyManagerAssetsDownloadFailed";

	// Token: 0x040009B1 RID: 2481
	public const string onBackendGetDefaultBundlesSuccess = "OnBackendGetDefaultBundlesSuccess";

	// Token: 0x040009B2 RID: 2482
	public const string onBackendGetDefaultBundlesException = "OnBackendGetDefaultBundlesException";

	// Token: 0x040009B3 RID: 2483
	private const string HJPNFNLGIOH = "OnAvatarScreenAssetsDownloadSuccess";

	// Token: 0x040009B4 RID: 2484
	private const string NFMIOJHMGNP = "OnAvatarScreenAssetBundleFolderInitializeSuccess";

	// Token: 0x040009B5 RID: 2485
	private const string KGPGCBONCKN = "OnAvatarScreenAssetsDownloadFailed";

	// Token: 0x040009B6 RID: 2486
	private static string EIODJHDOHPE = "OnLobbyStoryManagerAdsProviderAdSuccess";

	// Token: 0x040009B7 RID: 2487
	private static string MHOJMLGCLOD = "OnLobbyStoryManagerAdsProviderAdFailed";

	// Token: 0x040009B8 RID: 2488
	private const string KNCHIOMFHOF = "OnBackendStartPlayChapterSuccess";

	// Token: 0x040009B9 RID: 2489
	private const string IMOCHFMPILL = "OnBackendStartPlayChapterException";

	// Token: 0x040009BA RID: 2490
	private const string MICABBEMBDF = "OnLobbyStoryManagerDownloadSplashScreenFailed";

	// Token: 0x040009BB RID: 2491
	private const string PMACMMGJFOE = "OnLobbyStoryManagerDownloadSplashScreenSuccess";

	// Token: 0x040009BC RID: 2492
	private const string PKNMNDLFGNB = "OnBackendGetIncentRewardAdSuccess";

	// Token: 0x040009BD RID: 2493
	private const string IONFBGKHPGO = "OnBackendGetIncentRewardAdException";

	// Token: 0x040009BE RID: 2494
	private const string DNNFECFLKDA = "OnLobbyStoryManagerExitSyncSuccess";

	// Token: 0x040009BF RID: 2495
	public const string onLobbyManInTheMiddleAttackDetected = "OnLobbyManInTheMiddleAttackDetected";

	// Token: 0x040009C0 RID: 2496
	public const string onBackendGetPublicProfileSuccess = "OnBackendGetPublicProfileSuccess";

	// Token: 0x040009C1 RID: 2497
	public const string onBackendGetPublicProfileException = "OnBackendGetPublicProfileException";

	// Token: 0x040009C2 RID: 2498
	public const string onBackendSavePublicProfileSuccess = "OnBackendSavePublicProfileSuccess";

	// Token: 0x040009C3 RID: 2499
	public const string onBackendSavePublicProfileException = "OnBackendSavePublicProfileException";

	// Token: 0x040009C4 RID: 2500
	public const string onNeedToRestartProfileItemAnimation = "OnNeedToRestartProfileItemAnimation";

	// Token: 0x040009C5 RID: 2501
	public const string onLobbyProfileDataCdnSuccess = "OnLobbyProfileDataCdnSuccess";

	// Token: 0x040009C6 RID: 2502
	public const string onLobbyProfileDataCdnFailed = "OnLobbyProfileDataCdnFailed";

	// Token: 0x040009C7 RID: 2503
	public const string onMissingPreview2CdnSuccess = "OnMissingPreview2CdnSuccess";

	// Token: 0x040009C8 RID: 2504
	public const string onMissingPreview2CdnFailed = "OnMissingPreview2CdnFailed";

	// Token: 0x040009C9 RID: 2505
	public const string onLiveProfileThumbnailsCdnSuccess = "OnLiveProfileThumbnailsCdnSuccess";

	// Token: 0x040009CA RID: 2506
	public const string onLiveProfileThumbnailsCdnFailed = "OnLiveProfileThumbnailsCdnFailed";

	// Token: 0x040009CB RID: 2507
	public const string onLiveProfileThemeBackgroundCdnSuccess = "OnLiveProfileThemeBackgroundCdnSuccess";

	// Token: 0x040009CC RID: 2508
	public const string onLiveProfileThemeBackgroundCdnFailed = "OnLiveProfileThemeBackgroundCdnFailed";

	// Token: 0x040009CD RID: 2509
	public const string onSaveSyncAnyResult = "OnSaveSyncAnyResult";

	// Token: 0x040009CE RID: 2510
	public const string onSaveSyncAnyResultDuplicate = "OnSaveSyncAnyResultDuplicate";

	// Token: 0x040009CF RID: 2511
	public const string onUpdateSocialEventsCounter = "OnUpdateSocialEventsCounter";

	// Token: 0x040009D0 RID: 2512
	public const string onPopupUpdateWelcomeWhatsMoreClick = "OnPopupUpdateWelcomeWhatsMoreClick";

	// Token: 0x040009D1 RID: 2513
	public const string onBackendGetDropChancesSuccess = "OnBackendGetDropChancesSuccess";

	// Token: 0x040009D2 RID: 2514
	public const string onBackendGetDropChancesException = "OnBackendGetDropChancesException";

	// Token: 0x040009D3 RID: 2515
	public const string onBackendGetDropChancesSuccess2 = "OnBackendGetDropChancesSuccess2";

	// Token: 0x040009D4 RID: 2516
	public const string onBackendGetDropChancesException2 = "OnBackendGetDropChancesException2";

	// Token: 0x040009D5 RID: 2517
	public const string onBackendGetSketchesBalanceSuccess = "OnBackendGetSketchesBalanceSuccess";

	// Token: 0x040009D6 RID: 2518
	public const string onBackendGetSketchesBalanceException = "OnBackendGetSketchesBalanceException";

	// Token: 0x040009D7 RID: 2519
	public const string onLobbyWheelDataCdnSuccess = "OnLobbyWheelDataCdnSuccess";

	// Token: 0x040009D8 RID: 2520
	public const string onLobbyWheelDataCdnFailed = "OnLobbyWheelDataDataCdnFailed";

	// Token: 0x040009D9 RID: 2521
	public const string onLobbySkinShopCdnSuccess = "OnLobbySkinShopCdnSuccess";

	// Token: 0x040009DA RID: 2522
	public const string onLobbySkinShopCdnFailed = "OnLobbySkinShopCdnFailed";

	// Token: 0x040009DB RID: 2523
	public const string onSketchThumbnailsCdnSuccess = "OnSketchThumbnailsCdnSuccess";

	// Token: 0x040009DC RID: 2524
	public const string onSketchThumbnailsCdnFailed = "OnSketchThumbnailsCdnFailed";

	// Token: 0x040009DD RID: 2525
	public const string onLobbyStartFireworksEffectAutoHide = "OnLobbyStartFireworksEffectAutoHide";

	// Token: 0x040009DE RID: 2526
	public const string onLobbyStartFireworksEffect = "OnLobbyStartFireworksEffect";

	// Token: 0x040009DF RID: 2527
	public const string onLobbyStopFireworksEffect = "OnLobbyStopFireworksEffect";

	// Token: 0x040009E0 RID: 2528
	public const string onLiveOfferSuccessShowPassesWindow = "OnLiveOfferSuccessShowPassesWindow";

	// Token: 0x040009E1 RID: 2529
	private const string OLIOJPHEBLK = "OnAllCollectableCardsDownloadSuccessLobby";

	// Token: 0x040009E2 RID: 2530
	private const string GECLECJKGPG = "OnAllCollectableCardsDownloadFailedLobby";

	// Token: 0x040009E3 RID: 2531
	private const string IIOANIADHBH = "OnCutsceneViewLobbyAssetBundleFolderInitializeSuccess";

	// Token: 0x040009E4 RID: 2532
	private const string GLFCNMOHJBF = "OnCutsceneViewLobbyAssetsDownloadSuccess";

	// Token: 0x040009E5 RID: 2533
	private const string BOAAAIHOOJD = "OnCutsceneViewLobbyAssetsDownloadFailed";

	// Token: 0x040009E6 RID: 2534
	public List<Canvas> canvases = new List<Canvas>();

	// Token: 0x040009E7 RID: 2535
	public List<Camera> cameras = new List<Camera>();

	// Token: 0x040009E8 RID: 2536
	public TextMeshProUGUI diamondsText;

	// Token: 0x040009E9 RID: 2537
	public TextMeshProUGUI teaText;

	// Token: 0x040009EA RID: 2538
	public PopupDailyRewardManager dailyRewardManager;

	// Token: 0x040009EB RID: 2539
	public PopupReturnRewardManager returnRewardManager;

	// Token: 0x040009EC RID: 2540
	public TextMeshProUGUI textDescription;

	// Token: 0x040009ED RID: 2541
	public TextMeshProUGUI textEpisode;

	// Token: 0x040009EE RID: 2542
	public TextMeshProUGUI textSeason;

	// Token: 0x040009EF RID: 2543
	public static int incentAdResultAmount = 0;

	// Token: 0x040009F0 RID: 2544
	public static int incentAdResultRewardType = 0;

	// Token: 0x040009F1 RID: 2545
	public static int startPlayChapterBackendOperationResult = 0;

	// Token: 0x040009F2 RID: 2546
	public static int energyFireTime = 1000000;

	// Token: 0x040009F3 RID: 2547
	public static int dailyRewardFireTime = 86400;

	// Token: 0x040009F4 RID: 2548
	public static bool showNewSeasonUnlocked = false;

	// Token: 0x040009F5 RID: 2549
	public static bool showAnthologyComplete = false;

	// Token: 0x040009F6 RID: 2550
	public static bool showAnthologyCompleteSpecialEpisode = false;

	// Token: 0x040009F7 RID: 2551
	public Image currencyTeaFallingImage;

	// Token: 0x040009F8 RID: 2552
	public Image currencyHardFallingImage;

	// Token: 0x040009F9 RID: 2553
	public GameObject incentAdHardTimerBlock;

	// Token: 0x040009FA RID: 2554
	public Button incentAdHardButton;

	// Token: 0x040009FB RID: 2555
	public TextMeshProUGUI textIncentAdHardTimer;

	// Token: 0x040009FC RID: 2556
	public GameObject energyTimerBlock;

	// Token: 0x040009FD RID: 2557
	public TextMeshProUGUI textEnergyTimer;

	// Token: 0x040009FE RID: 2558
	public Button playButton;

	// Token: 0x040009FF RID: 2559
	public GameObject notificationFreeDiamonds;

	// Token: 0x04000A00 RID: 2560
	public GameObject notificationFreeDiamondsHidden;

	// Token: 0x04000A01 RID: 2561
	public TextMeshProUGUI notificationFreeDiamondsHiddenText;

	// Token: 0x04000A02 RID: 2562
	public TextMeshProUGUI notificationFreeDiamondsText;

	// Token: 0x04000A03 RID: 2563
	public TextMeshProUGUI notificationFreeDiamondsInfo;

	// Token: 0x04000A04 RID: 2564
	public GameObject notificationFreeDiamondsImage;

	// Token: 0x04000A05 RID: 2565
	public TextMeshProUGUI teaTextCost;

	// Token: 0x04000A06 RID: 2566
	public GameObject teaCostSpacing;

	// Token: 0x04000A07 RID: 2567
	public GameObject teaImageCost;

	// Token: 0x04000A08 RID: 2568
	private FADIGFEOCND NAEHPAIOHLG;

	// Token: 0x04000A09 RID: 2569
	private FADIGFEOCND BJGAJOKENMG;

	// Token: 0x04000A0A RID: 2570
	private FADIGFEOCND ENJMJIPADNO;

	// Token: 0x04000A0B RID: 2571
	private EJDDNONEDNM PLJLNEAKFDK;

	// Token: 0x04000A0C RID: 2572
	private bool PGFANABDIBK;

	// Token: 0x04000A0D RID: 2573
	private AssetStoryHeader LDIGGOPHGMI;

	// Token: 0x04000A0E RID: 2574
	private PLFDAJJHMKO GKHNIMJJLJL;

	// Token: 0x04000A0F RID: 2575
	private EIOPLEFLLIM JCEPMIFAIIH;

	// Token: 0x04000A10 RID: 2576
	private AssetAnthology HFFIIBBJBMH;

	// Token: 0x04000A11 RID: 2577
	private int MICMIKNOOEC;

	// Token: 0x04000A12 RID: 2578
	private int MIBPOIDDBAD;

	// Token: 0x04000A13 RID: 2579
	private static int MMICAAKCHBJ = 0;

	// Token: 0x04000A14 RID: 2580
	private int DCFBAMCJCFK;

	// Token: 0x04000A15 RID: 2581
	private int OBPPPNCALNP;

	// Token: 0x04000A16 RID: 2582
	private int FJIAGECENLF;

	// Token: 0x04000A17 RID: 2583
	private int LIDPKKFBNMC;

	// Token: 0x04000A18 RID: 2584
	private int HGIKEMNOGOO;

	// Token: 0x04000A19 RID: 2585
	private int NPLNHOMBILM;

	// Token: 0x04000A1A RID: 2586
	private int NEEMPAAFHEI;

	// Token: 0x04000A1B RID: 2587
	private bool MBACGFKOKJD;

	// Token: 0x04000A1C RID: 2588
	private bool MBCAHEEBBGE;

	// Token: 0x04000A1D RID: 2589
	private AssetAnthologyPreview2 LGKGGPDKAHF;

	// Token: 0x04000A1E RID: 2590
	private bool PDFIHFFJMJN;

	// Token: 0x04000A1F RID: 2591
	private int[] KHOELODHGGF;

	// Token: 0x04000A20 RID: 2592
	private NDHKFLHAFNA[] CIFKLOHBHJB;

	// Token: 0x04000A21 RID: 2593
	private NDHKFLHAFNA[] PMFMEBGNCME;

	// Token: 0x04000A22 RID: 2594
	private NDHKFLHAFNA[] HKJCANHMEED;

	// Token: 0x04000A23 RID: 2595
	private NDHKFLHAFNA[] CBBNGDBFDPO;

	// Token: 0x04000A24 RID: 2596
	private int[] HNLPNMJIBIK;

	// Token: 0x04000A25 RID: 2597
	private int[] JDFKLJAIHLH;

	// Token: 0x04000A26 RID: 2598
	public TextMeshProUGUI disclaimerImpers;

	// Token: 0x04000A27 RID: 2599
	public float disclaimerImpersLifeTime = 5f;

	// Token: 0x04000A28 RID: 2600
	public RectTransform logoBackgroundMask;

	// Token: 0x04000A29 RID: 2601
	public RectTransform logoBackgroundNew;

	// Token: 0x04000A2A RID: 2602
	public ParticleSystem heartsParticles;

	// Token: 0x04000A2B RID: 2603
	public ParticleSystem fireworksParticles;

	// Token: 0x04000A2C RID: 2604
	public List<ParticleSystem> themesParticles;

	// Token: 0x04000A2D RID: 2605
	public List<ParticleSystem> lobbyParticles;

	// Token: 0x04000A2E RID: 2606
	public GameObject scrollView0Controller;

	// Token: 0x04000A2F RID: 2607
	public ScrollView1Controller scrollView1Controller;

	// Token: 0x04000A30 RID: 2608
	public GameObject largeItemPrefab;

	// Token: 0x04000A31 RID: 2609
	public GameObject cardItemPrefab;

	// Token: 0x04000A32 RID: 2610
	public RectTransform largeItemsParent;

	// Token: 0x04000A33 RID: 2611
	public GameObject pageIndicatorPrefab;

	// Token: 0x04000A34 RID: 2612
	public RectTransform pageIndicatorsParent;

	// Token: 0x04000A35 RID: 2613
	public GameObject filterItemPrefab;

	// Token: 0x04000A36 RID: 2614
	public RectTransform filterItemsParent;

	// Token: 0x04000A37 RID: 2615
	public ToggleGroup toogleGroupOnFilterItemsParent;

	// Token: 0x04000A38 RID: 2616
	public ScrollView2Controller scrollView2Controller;

	// Token: 0x04000A39 RID: 2617
	public HorizontalLayoutGroup filterItemsParentHorizontalLayoutGroup;

	// Token: 0x04000A3A RID: 2618
	public ContentSizeFitter filterItemsParentContentSizeFitter;

	// Token: 0x04000A3B RID: 2619
	public GameObject smallItemPrefab;

	// Token: 0x04000A3C RID: 2620
	public GameObject smallItemParentPrefab;

	// Token: 0x04000A3D RID: 2621
	public RectTransform scrollView0Content;

	// Token: 0x04000A3E RID: 2622
	public float timeFocusItemAnimation;

	// Token: 0x04000A3F RID: 2623
	public GameObject focusFade;

	// Token: 0x04000A40 RID: 2624
	public GameObject focusItem;

	// Token: 0x04000A41 RID: 2625
	public GameObject profileFade2;

	// Token: 0x04000A42 RID: 2626
	public GameObject profileItem2;

	// Token: 0x04000A43 RID: 2627
	public GameObject wheelFade;

	// Token: 0x04000A44 RID: 2628
	public GameObject wheelItem;

	// Token: 0x04000A45 RID: 2629
	public GameObject rewardFade;

	// Token: 0x04000A46 RID: 2630
	public GameObject rewardItem;

	// Token: 0x04000A47 RID: 2631
	public ScrollRect rewardItemScrollRect;

	// Token: 0x04000A48 RID: 2632
	public GameObject sketchesFade;

	// Token: 0x04000A49 RID: 2633
	public GameObject sketchesItem;

	// Token: 0x04000A4A RID: 2634
	public Sprite defaultTagSprite;

	// Token: 0x04000A4B RID: 2635
	public Sprite inDevelopmentTagSprite;

	// Token: 0x04000A4C RID: 2636
	public Sprite completedTagSprite;

	// Token: 0x04000A4D RID: 2637
	public Sprite onHiatusTagSprite;

	// Token: 0x04000A4E RID: 2638
	private List<GameObject> PHHNFBLIGJB = new List<GameObject>();

	// Token: 0x04000A4F RID: 2639
	private List<int> MFCGAFIHGKI = new List<int>();

	// Token: 0x04000A50 RID: 2640
	private List<GameObject> KKPNDGIHFLN = new List<GameObject>();

	// Token: 0x04000A51 RID: 2641
	private List<GameObject> EKIFLHLCLKG = new List<GameObject>();

	// Token: 0x04000A52 RID: 2642
	private List<GameObject> MGNNOFPKGJF = new List<GameObject>();

	// Token: 0x04000A53 RID: 2643
	private List<GameObject> GMGKODLANOP = new List<GameObject>();

	// Token: 0x04000A54 RID: 2644
	private int ADAACGDPKDC;

	// Token: 0x04000A55 RID: 2645
	public GameObject footerObject;

	// Token: 0x04000A56 RID: 2646
	public RectTransform viewportRectTransform;

	// Token: 0x04000A57 RID: 2647
	public GameObject passesButton;

	// Token: 0x04000A58 RID: 2648
	public GameObject passesButtonExpiredExclamation;

	// Token: 0x04000A59 RID: 2649
	public GameObject cardsVolSaleButton;

	// Token: 0x04000A5A RID: 2650
	public TextMeshProUGUI cardsVolSaleButtonText;

	// Token: 0x04000A5B RID: 2651
	public GameObject skinShopButton;

	// Token: 0x04000A5C RID: 2652
	public GameObject skinShopNewSkinsDisc;

	// Token: 0x04000A5D RID: 2653
	public TextMeshProUGUI skinShopNewSkinsText;

	// Token: 0x04000A5E RID: 2654
	public GameObject quitButtonAvailable;

	// Token: 0x04000A5F RID: 2655
	public GameObject quitButtonHidden;

	// Token: 0x04000A60 RID: 2656
	public GameObject profileButtonAvailable;

	// Token: 0x04000A61 RID: 2657
	public GameObject profileButtonOffline;

	// Token: 0x04000A62 RID: 2658
	public GameObject profileButtonHidden;

	// Token: 0x04000A63 RID: 2659
	public HorizontalLayoutGroup headerLayoutGroup;

	// Token: 0x04000A64 RID: 2660
	public GameObject additionalHeaderSpacing;

	// Token: 0x04000A65 RID: 2661
	public GameObject recommendedSetupButton;

	// Token: 0x04000A66 RID: 2662
	public GameObject shuffleButton;

	// Token: 0x04000A67 RID: 2663
	public Button shuffleButtonButton;

	// Token: 0x04000A68 RID: 2664
	public GameObject objectBeforeAds;

	// Token: 0x04000A69 RID: 2665
	public GameObject backgroundJobIndicator;

	// Token: 0x04000A6A RID: 2666
	public GameObject socialEventCounterObject;

	// Token: 0x04000A6B RID: 2667
	public TextMeshProUGUI socialEventCounterObjectText;

	// Token: 0x04000A6C RID: 2668
	public GameObject extrasParent;

	// Token: 0x04000A6D RID: 2669
	public GameObject footerPassesButton;

	// Token: 0x04000A6E RID: 2670
	public GameObject footerPassesExpiredExclamation;

	// Token: 0x04000A6F RID: 2671
	public GameObject footerSkinShopButton;

	// Token: 0x04000A70 RID: 2672
	public GameObject footerSkinShopNewSkinsDisc;

	// Token: 0x04000A71 RID: 2673
	public TextMeshProUGUI footerSkinShopNewSkinsText;

	// Token: 0x04000A72 RID: 2674
	public GameObject footerRewardsButton;

	// Token: 0x04000A73 RID: 2675
	public GameObject footerRewardsGemPill;

	// Token: 0x04000A74 RID: 2676
	public TextMeshProUGUI footerRewardsGemPillText;

	// Token: 0x04000A75 RID: 2677
	public TextMeshProUGUI footerRewardsLabel;

	// Token: 0x04000A76 RID: 2678
	public LobbyRewardsPopover rewardsPopover;

	// Token: 0x04000A77 RID: 2679
	public const int footerPassesTextIndex = 975;

	// Token: 0x04000A78 RID: 2680
	public const int footerSkinShopTextIndex = 1281;

	// Token: 0x04000A79 RID: 2681
	public const int footerSaleTextIndex = 1282;

	// Token: 0x04000A7A RID: 2682
	private float HCMDGPOACOL;

	// Token: 0x04000A7B RID: 2683
	private const float BODLHMCIOJL = 1f;

	// Token: 0x04000A7C RID: 2684
	private static readonly Color32 JFANHEDJDMK = new Color32(246, 189, 98, byte.MaxValue);

	// Token: 0x04000A7D RID: 2685
	private static readonly bool PBFHBAAFHJD = false;

	// Token: 0x04000A7E RID: 2686
	private RectTransform EJNCBBFGGLH;

	// Token: 0x04000A7F RID: 2687
	private RectTransform KHGNNCCKEPG;

	// Token: 0x04000A80 RID: 2688
	private CanvasGroup BDLMHIGGAHI;

	// Token: 0x04000A81 RID: 2689
	private CanvasGroup KHKDPJNCPJN;

	// Token: 0x04000A82 RID: 2690
	private Vector2 CGHKPPLLBKN;

	// Token: 0x04000A83 RID: 2691
	private Vector2 KIODPNAKDIF;

	// Token: 0x04000A84 RID: 2692
	private bool MKOHINMNEAI;

	// Token: 0x04000A85 RID: 2693
	private bool PGKHOKJOCKP;

	// Token: 0x04000A86 RID: 2694
	private const int HBAAAHBKMGP = -23;

	// Token: 0x04000A87 RID: 2695
	private int DNFBBDFPFJJ = -1;

	// Token: 0x04000A88 RID: 2696
	public static int startChapterManInTheMiddleAttack = 0;

	// Token: 0x04000A89 RID: 2697
	private bool GBBHKFFENBE = true;

	// Token: 0x04000A8A RID: 2698
	private bool MBGPADGCJBM;

	// Token: 0x04000A8B RID: 2699
	private bool CGPGMJKCBBJ;

	// Token: 0x04000A8C RID: 2700
	private Coroutine IFHLHLICMHP;

	// Token: 0x04000A8D RID: 2701
	private bool BDGPIIONPIA = true;

	// Token: 0x04000A8E RID: 2702
	private bool CJEJCGOCFJF;

	// Token: 0x04000A8F RID: 2703
	private List<int> ILPNKGBHGOL = new List<int>();

	// Token: 0x04000A90 RID: 2704
	private Dictionary<int, int> LCMLDDFFBGM = new Dictionary<int, int>();

	// Token: 0x04000A91 RID: 2705
	private List<int> EMFGMAIBBLE = new List<int>();

	// Token: 0x04000A92 RID: 2706
	private const int GDHGNFPEIDD = 3;

	// Token: 0x04000A93 RID: 2707
	private bool EPJBDIIAIAJ;

	// Token: 0x04000A94 RID: 2708
	private bool DGCNKCFHGAO;

	// Token: 0x04000A95 RID: 2709
	private int IMOHHHALBAP;

	// Token: 0x04000A96 RID: 2710
	private const int HKLKAPFGJGE = 2;

	// Token: 0x04000A97 RID: 2711
	private MNLBEMJOKNJ DFPNCCFNJJD;

	// Token: 0x04000A98 RID: 2712
	private int LFOLHJFLGKA = -1;

	// Token: 0x04000A99 RID: 2713
	private float LLCBNGOAGHK = -1f;

	// Token: 0x04000A9A RID: 2714
	private int IHIHDNNPBKA;

	// Token: 0x04000A9B RID: 2715
	public static bool lobbyIsActive = false;

	// Token: 0x04000A9C RID: 2716
	public static bool doNotUpdatePercent = false;

	// Token: 0x04000A9D RID: 2717
	private static bool MGCECGDMAMK = false;

	// Token: 0x04000A9E RID: 2718
	private static bool CEOACAJHGEN = false;

	// Token: 0x04000A9F RID: 2719
	private static bool HPDEAEBBKCJ = false;

	// Token: 0x04000AA0 RID: 2720
	private FADIGFEOCND PHMIBKAJKMB;

	// Token: 0x04000AA1 RID: 2721
	public static int spinsFireTime = 1000000;

	// Token: 0x04000AA2 RID: 2722
	private bool GEJBKOECPEB;

	// Token: 0x04000AA3 RID: 2723
	private int CDJGGOJBGJF;

	// Token: 0x04000AA4 RID: 2724
	private bool FGDEGMOLIDB;

	// Token: 0x04000AA5 RID: 2725
	private GDOKLFCLLIK OGHHLFOEJKO;

	// Token: 0x04000AA6 RID: 2726
	private bool EJECJLAAHLE;

	// Token: 0x04000AA7 RID: 2727
	private int LEFNOKMNHIA = -1;

	// Token: 0x04000AA8 RID: 2728
	private BNFCLKNDBLO BMODBEEEABE;

	// Token: 0x04000AA9 RID: 2729
	private int LAENHLLONAI;

	// Token: 0x04000AAA RID: 2730
	private bool IPAFGLONDJF;

	// Token: 0x04000AAB RID: 2731
	private bool COJEBPAFPFP;

	// Token: 0x04000AAC RID: 2732
	private int GKEGDHDJFAF = -1;

	// Token: 0x04000AAD RID: 2733
	private bool BMHEEAJGFJI;

	// Token: 0x04000AAE RID: 2734
	private const float EPGOGMJEBEJ = 71f;

	// Token: 0x04000AAF RID: 2735
	private const float KOHGBFEDEEK = 122f;

	// Token: 0x04000AB0 RID: 2736
	private const float MDGPHGBAEDD = 289f;

	// Token: 0x04000AB1 RID: 2737
	private const float JEFJFJNCOAD = 4f;

	// Token: 0x04000AB2 RID: 2738
	private const float CJIABKBGBKF = 20f;

	// Token: 0x04000AB3 RID: 2739
	private const float EIJFLBJACOJ = 16f;

	// Token: 0x04000AB4 RID: 2740
	public LobbySearchBar lobbySearchBar;

	// Token: 0x04000AB5 RID: 2741
	private bool KOGLEPFNALN;

	// Token: 0x04000AB6 RID: 2742
	private string MJOMHIEMKMK = "";

	// Token: 0x04000AB7 RID: 2743
	private List<int> KPDGEKGMAKO = new List<int>();

	// Token: 0x04000AB8 RID: 2744
	private List<int> BPCHEOFFPCN = new List<int>();

	// Token: 0x04000AB9 RID: 2745
	private List<OJPLEKECIFI> CIBDADPLOMG = new List<OJPLEKECIFI>();

	// Token: 0x04000ABA RID: 2746
	private HashSet<int> EEGHJFAIMBF = new HashSet<int>();

	// Token: 0x04000ABB RID: 2747
	private Dictionary<int, string[]> IIDEKJNAFKG = new Dictionary<int, string[]>();

	// Token: 0x04000ABC RID: 2748
	private Dictionary<int, int> NODBJCOJNLJ = new Dictionary<int, int>();

	// Token: 0x04000ABD RID: 2749
	private List<string> JECFMCGHNGC = new List<string>();

	// Token: 0x04000ABE RID: 2750
	private List<int> LCIKAHNGIJG = new List<int>();

	// Token: 0x04000ABF RID: 2751
	private CultureInfo NBNKDKCCNKI;

	// Token: 0x04000AC0 RID: 2752
	private Dictionary<int, List<SceneLobbyManager2.BBNDCCPKNJL>> MHHEBPDIGFB = new Dictionary<int, List<SceneLobbyManager2.BBNDCCPKNJL>>();

	// Token: 0x04000AC1 RID: 2753
	private List<int> ABFFODCEIHO = new List<int>();

	// Token: 0x04000AC2 RID: 2754
	private List<SceneLobbyManager2.BBNDCCPKNJL> NOMLNLBOOKD = new List<SceneLobbyManager2.BBNDCCPKNJL>();

	// Token: 0x04000AC3 RID: 2755
	private List<SceneLobbyManager2.BBNDCCPKNJL> AILKPKDEIKO = new List<SceneLobbyManager2.BBNDCCPKNJL>();

	// Token: 0x04000AC4 RID: 2756
	private const int OINBEHCPHPF = 3;

	// Token: 0x04000AC5 RID: 2757
	private const int CMJCIPODGPO = 4;

	// Token: 0x04000AC6 RID: 2758
	private const int OIPLPBMKMFA = 5;

	// Token: 0x04000AC7 RID: 2759
	private const int JCPJIFKLPBC = 26;

	// Token: 0x04000AC8 RID: 2760
	private const float BIGDDJBEMAD = 0.5f;

	// Token: 0x04000AC9 RID: 2761
	private Coroutine MPEKBFHNOOK;

	// Token: 0x04000ACA RID: 2762
	private List<string> FODKLALANIM = new List<string>();

	// Token: 0x04000ACB RID: 2763
	private List<string> LDDOHLGKALJ = new List<string>();

	// Token: 0x04000ACC RID: 2764
	private List<string> PKMIMMBGCCI = new List<string>();

	// Token: 0x04000ACD RID: 2765
	private List<string> MKBCMGODBPM = new List<string>();

	// Token: 0x04000ACE RID: 2766
	private List<string> JGPICDIOOLL = new List<string>();

	// Token: 0x04000ACF RID: 2767
	private List<string> FBDJCEKGNFM = new List<string>();

	// Token: 0x04000AD0 RID: 2768
	private List<string> PKFHEIJIMLA = new List<string>();

	// Token: 0x04000AD1 RID: 2769
	private Dictionary<int, SceneLobbyManager2.LDGNIDMIIIA> BBNFIHLCHAO = new Dictionary<int, SceneLobbyManager2.LDGNIDMIIIA>();

	// Token: 0x04000AD2 RID: 2770
	private static SceneLobbyManager2 BJBOJLBOOEF = null;

	// Token: 0x04000AD3 RID: 2771
	private string[] OCKANDFLMBG;

	// Token: 0x04000AD4 RID: 2772
	private int FLPJFHKDIOG = -1;

	// Token: 0x04000AD5 RID: 2773
	private GameObject FIBKHPMLNJN;

	// Token: 0x04000AD6 RID: 2774
	private static string KAFNANCDMNF = null;

	// Token: 0x04000AD7 RID: 2775
	private Coroutine EGNDHGMJJJL;

	// Token: 0x04000AD8 RID: 2776
	private const int CGENACNPEGL = 6;

	// Token: 0x04000AD9 RID: 2777
	private const float BDKMGFBIMOH = 0.4f;

	// Token: 0x04000ADA RID: 2778
	private const float IKMCFELBJGJ = 0.25f;

	// Token: 0x04000ADB RID: 2779
	private const float JPOHGIGJHEE = 0.033333335f;

	// Token: 0x04000ADC RID: 2780
	private Coroutine HOPLLEOGDEK;

	// Token: 0x04000ADD RID: 2781
	private const int KPCICINIMPG = 300;

	// Token: 0x04000ADE RID: 2782
	private static readonly int[] FCGFNJPMELB = new int[]
	{
		21
	};

	// Token: 0x04000ADF RID: 2783
	private const string KPPFKIICFMF = "GroupedParent";

	// Token: 0x04000AE0 RID: 2784
	private const string HEKLKABILII = "CoverCard";

	// Token: 0x04000AE1 RID: 2785
	private const int OGOFCOPPFIG = 5;

	// Token: 0x04000AE2 RID: 2786
	private const float IMDKAMEDNCE = 1f;

	// Token: 0x04000AE3 RID: 2787
	private List<HAKFHALKMBH> AAHJNGODNKI = new List<HAKFHALKMBH>();

	// Token: 0x04000AE4 RID: 2788
	private const string NBEHIDBOBCH = "coverNew";

	// Token: 0x04000AE5 RID: 2789
	private const string KBPJMLKOMKH = "coverNewFallback";

	// Token: 0x04000AE6 RID: 2790
	private const string IDMDJCJCEAC = "coverPopular";

	// Token: 0x04000AE7 RID: 2791
	private const string FFNJNPCGLAO = "coverYear";

	// Token: 0x04000AE8 RID: 2792
	private const string EBBOCHKPPGG = "coverUndated";

	// Token: 0x04000AE9 RID: 2793
	private const string GEPOBJBCLDA = "coverSearch";

	// Token: 0x04000AEA RID: 2794
	private const string DGOHNOIGNBK = "coverSearchMore";

	// Token: 0x04000AEB RID: 2795
	private const string PHLNCJIJCKL = "coverSearchNone";

	// Token: 0x04000AEC RID: 2796
	private const string INLBIMGAFIM = "coverContinue";

	// Token: 0x04000AED RID: 2797
	private const string LNMCPCADNLN = "coverCompleted";

	// Token: 0x04000AEE RID: 2798
	private const string MNOEMANMDLO = "coverFavorites";

	// Token: 0x04000AEF RID: 2799
	private const string EGPGMKBHBPN = "newpattern";

	// Token: 0x04000AF0 RID: 2800
	private const string ECEJBHEMANH = "popularpattern";

	// Token: 0x04000AF1 RID: 2801
	private const string GGNNODJBLBH = "allpattern";

	// Token: 0x04000AF2 RID: 2802
	private const string OAPMMPFDADA = "searchpattern";

	// Token: 0x04000AF3 RID: 2803
	private const string INNJMOILHJH = "mystoriespattern";

	// Token: 0x04000AF4 RID: 2804
	private const string NFKKOMDNMDP = "favoritespattern";

	// Token: 0x04000AF5 RID: 2805
	private const string NBGHBIDLAKH = "starterpattern";

	// Token: 0x04000AF6 RID: 2806
	private List<POKPDFKMOFC> CHDBIMNLHBC;

	// Token: 0x04000AF7 RID: 2807
	private int KCJIIEIBAPI = -1;

	// Token: 0x04000AF8 RID: 2808
	private int DINHJIBBGJL = -1;

	// Token: 0x04000AF9 RID: 2809
	private List<POKPDFKMOFC> NIIKKCHINDO;

	// Token: 0x04000AFA RID: 2810
	private const string JDBPHBJGNCB = "explorepattern";

	// Token: 0x04000AFB RID: 2811
	private const string APIAMOKFEGM = "franchisepattern";

	// Token: 0x04000AFC RID: 2812
	private bool LPBFGPLHDPM;

	// Token: 0x04000AFD RID: 2813
	public const string onLobbyLoungeOpenRequested = "OnLobbyLoungeOpenRequested";

	// Token: 0x04000AFE RID: 2814
	public const string onLobbyLoungeAssetBundleFolderInitializeSuccess = "OnLobbyLoungeAssetBundleFolderInitializeSuccess";

	// Token: 0x04000AFF RID: 2815
	public const string onLobbyLoungeAssetsDownloadSuccess = "OnLobbyLoungeAssetsDownloadSuccess";

	// Token: 0x04000B00 RID: 2816
	public const string onLobbyLoungeAssetsDownloadFailed = "OnLobbyLoungeAssetsDownloadFailed";

	// Token: 0x04000B01 RID: 2817
	private bool MHAMPPBECNM;

	// Token: 0x04000B02 RID: 2818
	private bool KDLBELFIIDL;

	// Token: 0x04000B03 RID: 2819
	private List<int> EOOJGEFLJEN = new List<int>();

	// Token: 0x04000B04 RID: 2820
	private APNIHJMGNIM FJOMBPDEMCM;

	// Token: 0x04000B05 RID: 2821
	private List<GHMINFEGBGN> DFEMFJJDGML = new List<GHMINFEGBGN>();

	// Token: 0x04000B06 RID: 2822
	private List<int> FLLHKGKNAOK = new List<int>();

	// Token: 0x04000B07 RID: 2823
	private List<string> PEFDGDNCHGD = new List<string>();

	// Token: 0x04000B08 RID: 2824
	private List<StoryEnvironmentManager> KGOCEEAGLKO = new List<StoryEnvironmentManager>();

	// Token: 0x04000B09 RID: 2825
	private List<StoryEnvironmentManager> OEDPPJGKPFO = new List<StoryEnvironmentManager>();

	// Token: 0x04000B0A RID: 2826
	private List<string> IBBHBBNAOKL = new List<string>();

	// Token: 0x04000B0B RID: 2827
	private List<string> HHILBMHMJBH = new List<string>();

	// Token: 0x04000B0C RID: 2828
	private int DFNOAOLCGGB;

	// Token: 0x04000B0D RID: 2829
	private bool FKMHOJNLOIL;

	// Token: 0x04000B0E RID: 2830
	private bool KOMBACJDBAH;

	// Token: 0x04000B0F RID: 2831
	private bool OBKCLKMPKCI;

	// Token: 0x04000B10 RID: 2832
	private bool FMJEJOGDBHA;

	// Token: 0x04000B11 RID: 2833
	private bool EDGAPOIIHKC;

	// Token: 0x020000E6 RID: 230
	private class LDGNIDMIIIA
	{
		// Token: 0x04000B12 RID: 2834
		public string FKCNMAEBNNK;

		// Token: 0x04000B13 RID: 2835
		public string JCMIJCCCCLC;

		// Token: 0x04000B14 RID: 2836
		public string MEHHECKMOAD;

		// Token: 0x04000B15 RID: 2837
		public List<string> AIJFJMKHAOO = new List<string>();

		// Token: 0x04000B16 RID: 2838
		public bool DPENIDKNIMK;
	}

	// Token: 0x020000E7 RID: 231
	private class BBNDCCPKNJL
	{
		// Token: 0x04000B17 RID: 2839
		public string IEIAICGOENJ;

		// Token: 0x04000B18 RID: 2840
		public float AGMOECJFFJI;

		// Token: 0x04000B19 RID: 2841
		public bool DCMKIKIHACO;

		// Token: 0x04000B1A RID: 2842
		public bool FJNECDBGMOK;

		// Token: 0x04000B1B RID: 2843
		public bool OKJNEMPGHDJ;
	}

	// Token: 0x02000108 RID: 264
	[CompilerGenerated]
	private sealed class CJENNIDBPLN
	{
		// Token: 0x060024FD RID: 9469 RVA: 0x0010F9A6 File Offset: 0x0010DBA6
		internal void FPNMIDODBGP()
		{
			this.<>4__this.CPLLGNAKIIL(this.tempAssetAnthologyPreview2);
		}

		// Token: 0x04000B81 RID: 2945
		public AssetAnthologyPreview2 tempAssetAnthologyPreview2;

		// Token: 0x04000B82 RID: 2946
		public SceneLobbyManager2 <>4__this;
	}

	// Token: 0x02000109 RID: 265
	[CompilerGenerated]
	private sealed class AFLNAFOHGJC
	{
		// Token: 0x06002500 RID: 9472 RVA: 0x0010F9B9 File Offset: 0x0010DBB9
		internal void MDBKKKMOHPI()
		{
			this.<>4__this.LBENOPHCHJE(this.liveEventDesc, this.scriptableObject);
		}

		// Token: 0x04000B83 RID: 2947
		public OKAFAHMOFII liveEventDesc;

		// Token: 0x04000B84 RID: 2948
		public AssetLiveEventContent scriptableObject;

		// Token: 0x04000B85 RID: 2949
		public SceneLobbyManager2 <>4__this;
	}

	// Token: 0x0200010C RID: 268
	[CompilerGenerated]
	private sealed class LPIADNIFNNM
	{
		// Token: 0x06002512 RID: 9490 RVA: 0x0010FA8B File Offset: 0x0010DC8B
		internal bool GAFHIDBDFPE(GameObject item)
		{
			return null != item && item.GetComponent<GridController>().filter == this.filter;
		}

		// Token: 0x04000B93 RID: 2963
		public JBBNEEHANHL filter;
	}

	// Token: 0x0200010D RID: 269
	[CompilerGenerated]
	private sealed class AELKIAMLOBH
	{
		// Token: 0x04000B94 RID: 2964
		public SceneLobbyManager2 <>4__this;

		// Token: 0x04000B95 RID: 2965
		public AssetAnthologyPreview2 tempAssetAnthologyPreview2;

		// Token: 0x04000B96 RID: 2966
		public JBBNEEHANHL filter;
	}

	// Token: 0x0200010E RID: 270
	[CompilerGenerated]
	private sealed class FLPFBMIBJDD
	{
		// Token: 0x06002516 RID: 9494 RVA: 0x0010FAAC File Offset: 0x0010DCAC
		internal void CEOCHAFMFLP()
		{
			this.CS$<>8__locals1.<>4__this.CPLLGNAKIIL(this.CS$<>8__locals1.tempAssetAnthologyPreview2, this.CS$<>8__locals1.<>4__this.EDHCEJMLPEO(this.CS$<>8__locals1.tempAssetAnthologyPreview2.index, this.item.GetComponent<ThumbnailItem>().GetShownChipWords(), this.CS$<>8__locals1.filter));
		}

		// Token: 0x04000B97 RID: 2967
		public GameObject item;

		// Token: 0x04000B98 RID: 2968
		public SceneLobbyManager2.AELKIAMLOBH CS$<>8__locals1;
	}

	// Token: 0x0200010F RID: 271
	[CompilerGenerated]
	private sealed class KLHKEHPOCNH
	{
		// Token: 0x06002517 RID: 9495 RVA: 0x0010FB10 File Offset: 0x0010DD10
		internal void IELEDLJCCMD()
		{
			this.CS$<>8__locals2.<>4__this.CPLLGNAKIIL(this.CS$<>8__locals2.tempAssetAnthologyPreview2, this.CS$<>8__locals2.<>4__this.EDHCEJMLPEO(this.CS$<>8__locals2.tempAssetAnthologyPreview2.index, this.item.GetComponent<ThumbnailItem>().GetShownChipWords(), this.CS$<>8__locals2.filter));
		}

		// Token: 0x04000B99 RID: 2969
		public GameObject item;

		// Token: 0x04000B9A RID: 2970
		public SceneLobbyManager2.AELKIAMLOBH CS$<>8__locals2;
	}

	// Token: 0x02000110 RID: 272
	[CompilerGenerated]
	private sealed class PKGNMBJJDAF
	{
		// Token: 0x06002519 RID: 9497 RVA: 0x0010FB74 File Offset: 0x0010DD74
		internal void MKDNJEKKDBO()
		{
			this.CS$<>8__locals3.<>4__this.CPLLGNAKIIL(this.CS$<>8__locals3.tempAssetAnthologyPreview2, this.CS$<>8__locals3.<>4__this.EDHCEJMLPEO(this.CS$<>8__locals3.tempAssetAnthologyPreview2.index, this.item.GetComponent<ThumbnailItem>().GetShownChipWords(), this.CS$<>8__locals3.filter));
		}

		// Token: 0x04000B9B RID: 2971
		public GameObject item;

		// Token: 0x04000B9C RID: 2972
		public SceneLobbyManager2.AELKIAMLOBH CS$<>8__locals3;
	}

	// Token: 0x02000111 RID: 273
	[CompilerGenerated]
	private sealed class GDEHICBPJMC
	{
		// Token: 0x0600251C RID: 9500 RVA: 0x0010FBD7 File Offset: 0x0010DDD7
		internal bool NCAIKNPLINE(GameObject item)
		{
			return item.GetComponent<GridController>().filter == this.filter;
		}

		// Token: 0x0600251D RID: 9501 RVA: 0x0010FBEC File Offset: 0x0010DDEC
		internal bool NJJOADMCJLD(GameObject item)
		{
			return null != item && item.GetComponent<GridController>().filter == this.filter;
		}

		// Token: 0x04000B9D RID: 2973
		public JBBNEEHANHL filter;
	}
}
