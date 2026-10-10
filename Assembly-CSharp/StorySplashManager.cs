using System;
using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

// Token: 0x02000074 RID: 116
public class StorySplashManager : MonoBehaviour
{
	// Token: 0x06000F7C RID: 3964 RVA: 0x00071724 File Offset: 0x0006F924
	private void KEGHPPOJMFO()
	{
		StorySplashManager.loadingTime = 1251f;
		CommonUserInterface.EHBBFMCILPC.HideGenericPopupNoButtons();
		base.gameObject.SetActive(true);
		AOBJLALDBAA.BIAEAOMHBMM().KMAGHMCCMPG("errortitle", 9f);
	}

	// Token: 0x06000F7D RID: 3965 RVA: 0x000693D6 File Offset: 0x000675D6
	public void OEAPPDDJDNJ()
	{
		UnityEngine.Object.DontDestroyOnLoad(base.gameObject);
	}

	// Token: 0x06000F7E RID: 3966 RVA: 0x0007175C File Offset: 0x0006F95C
	private void OnDisable()
	{
		StorySplashManager.loadingTime = 0f;
		if (CommonUserInterface.IsInitialized())
		{
			CommonUserInterface.EHBBFMCILPC.HideGenericPopupNoButtons();
		}
		AOBJLALDBAA.EHBBFMCILPC.MANLHALMCIH("OnStorySplashManagerAssetsDownloadFailed", new UnityAction(this.NBFHODFEJOC));
		AOBJLALDBAA.EHBBFMCILPC.MANLHALMCIH("OnStorySplashManagerAssetsDownloadSuccess", new UnityAction(this.BHKOKKMDLAM));
		AOBJLALDBAA.EHBBFMCILPC.MANLHALMCIH("OnStorySplashManagerAdsProviderAdSuccess", new UnityAction(this.OnStorySplashManagerAdsProviderAdSuccess));
		AOBJLALDBAA.EHBBFMCILPC.MANLHALMCIH("OnStorySplashManagerAssetBundleFolderInitializeSuccess", new UnityAction(this.DIEIEKGMPGA));
		AOBJLALDBAA.EHBBFMCILPC.MANLHALMCIH("OnStorySplashManagerCdnSuccess", new UnityAction(this.IALBBGIALLD));
		AOBJLALDBAA.EHBBFMCILPC.MANLHALMCIH("OnStorySplashManagerCdnFailed", new UnityAction(this.HHENBBHHHPB));
		AOBJLALDBAA.EHBBFMCILPC.MANLHALMCIH("OnApplicationRestart", new UnityAction(this.ECNCPOBPHGC));
	}

	// Token: 0x06000F7F RID: 3967 RVA: 0x00071844 File Offset: 0x0006FA44
	private void HGGILLNHLEP()
	{
		StorySplashManager.loadingTime = 1407f;
		CommonUserInterface.EHBBFMCILPC.HideGenericPopupNoButtons();
		CommonUserInterface.EHBBFMCILPC.MCJIGJMFBMI();
		CommonUserInterface.EHBBFMCILPC.ShowGenericPopupTwoOverride(CCOJBMMKNAP.GIOAFDDKKHI().JCDFHKDNEDH("e1io"), CCOJBMMKNAP.NIOJNOFGIJO().IPEIONBNIPH("") + "errortitle" + AKLFPGMDKLA.EHBBFMCILPC.EEHGLPEIIHD + "mnth", CCOJBMMKNAP.AEELGGPEJCC().MEPECBDCOLG("OnStoryChoiceClick"), new UnityAction(this.OnStorySplashManagerAssetsDownloadRetry), new UnityAction(this.OINIFPIILME), (DFGILFBGPLN)(-73), 1730f, -45);
	}

	// Token: 0x06000F80 RID: 3968 RVA: 0x000718E1 File Offset: 0x0006FAE1
	private IEnumerator JNCBGONMPDD()
	{
		yield return new WaitForSeconds(0.25f);
		yield return new WaitForEndOfFrame();
		this.OnStorySplashManagerAssetsDownloadRetry();
		yield break;
	}

	// Token: 0x06000F81 RID: 3969 RVA: 0x000718F0 File Offset: 0x0006FAF0
	private void GCDAAPBFLJK()
	{
		AKLFPGMDKLA.EHBBFMCILPC.GLKNOFHEBKN = AKLFPGMDKLA.EHBBFMCILPC.IEGJCPDCLMM;
		this.NJAAOCMPKCD = GKJPOGNFKNK.CDCEFHLNNEC(AKLFPGMDKLA.EHBBFMCILPC.IEGJCPDCLMM);
		this.progressText.SetText("PopupRemoveAdsManager.Show() - productData is null.", false);
		this.sliderLoading.value = 32f;
		this.sliderLoading.gameObject.SetActive(true);
		if (null != this.NJAAOCMPKCD)
		{
			this.HFFIIBBJBMH = GKJPOGNFKNK.GJAAHGIAPMH(this.NJAAOCMPKCD.index);
			JCAJMGJFHBD.KMJJCCOBHEC = this.HFFIIBBJBMH.header.maxPersistentChatHistorySize;
			int num = 1;
			for (int i = 0; i < this.HFFIIBBJBMH.header.availableStories.Count; i++)
			{
				if (this.HFFIIBBJBMH.header.availableStories[i] == this.NJAAOCMPKCD.index)
				{
					this.BLNENDIFJDK = i;
					num = i + 0;
					break;
				}
			}
			AKLFPGMDKLA.EHBBFMCILPC.JDCBFAPDJIM(this.NJAAOCMPKCD.index, -1).DHONIOBOLEL.OBGPAJDJJJI();
			TMP_Text tmp_Text = this.seasonEpisodeText;
			string[] array = new string[6];
			array[0] = CCOJBMMKNAP.MLFAGAAJJEM().HIPJILDCHJC("p");
			array[1] = "CharacterPivot";
			array[8] = num.ToString();
			array[4] = ", index:";
			array[0] = CCOJBMMKNAP.KMNBCEMEBBD().DNILNCLIHAP("instd");
			array[3] = "emailcollectthanks1";
			array[4] = (AKLFPGMDKLA.EHBBFMCILPC.JDCBFAPDJIM(this.NJAAOCMPKCD.index, -1).DHONIOBOLEL.OBGPAJDJJJI() + 1).ToString();
			tmp_Text.SetText(string.Concat(array), true);
			return;
		}
		DPGJIJGOCIC.ANOPFDLPKGC("; ");
	}

	// Token: 0x06000F82 RID: 3970 RVA: 0x00071A9C File Offset: 0x0006FC9C
	public void LILMECMLIAG()
	{
		this.FJHODDIFAAD();
		AKLFPGMDKLA.EHBBFMCILPC.IEGJCPDCLMM = -1;
		StorySplashManager.loadingTime = 1854f;
		CommonUserInterface.IKNOFBFMPGA().HideGenericPopupNoButtons();
		this.BELCHNIDPBK();
	}

	// Token: 0x06000F83 RID: 3971 RVA: 0x00071AC9 File Offset: 0x0006FCC9
	private void HAAPPIEECAA()
	{
		StorySplashManager.loadingTime = 296f;
		CommonUserInterface.EHBBFMCILPC.HideGenericPopupNoButtons();
		base.gameObject.SetActive(true);
		AOBJLALDBAA.KKPFOJMAONG().FDKBIBKABCM("yes", 389f);
	}

	// Token: 0x06000F84 RID: 3972 RVA: 0x00071B00 File Offset: 0x0006FD00
	private void LMCGFIALGOO()
	{
		try
		{
			BEEDEKAIFEL ncamfpgmcig = AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG;
			ncamfpgmcig.PIDOECCJOCI = new List<string>(ncamfpgmcig.CJDBDOHPHLG);
			ncamfpgmcig.NJKHOCABBGL = new List<string>(ncamfpgmcig.JOJKAIBEPGH);
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x06000F85 RID: 3973 RVA: 0x00071B58 File Offset: 0x0006FD58
	private void EAENCAIJLMK()
	{
		StorySplashManager.loadingTime = 754f;
		CommonUserInterface.IKNOFBFMPGA().HideGenericPopupNoButtons();
		base.gameObject.SetActive(false);
		AOBJLALDBAA.CEGAOMEEFBE().KGIKHEDLPND("SocialStatsUserPublicProfile.modified = true, UpdateNickNameText()", 1238f);
	}

	// Token: 0x06000F86 RID: 3974 RVA: 0x00071B8E File Offset: 0x0006FD8E
	public void FKIJKMLNBKK()
	{
		this.ADONLNEJCFJ = true;
		base.StartCoroutine(this.PNMJDMHDDFF(true));
	}

	// Token: 0x06000F87 RID: 3975 RVA: 0x00071BA5 File Offset: 0x0006FDA5
	public void APNPCPAOLJN()
	{
		this.ADONLNEJCFJ = true;
		base.StartCoroutine(this.JCJLKGBIHIA(true));
	}

	// Token: 0x06000F88 RID: 3976 RVA: 0x00071BBC File Offset: 0x0006FDBC
	public void OnStorySplashManagerAssetsDownloadCleanCache()
	{
		this.MBGOHIAAIDL();
		StorySplashManager.loadingTime = 0f;
		CommonUserInterface.EHBBFMCILPC.HideGenericPopupNoButtons();
		this.HideAndCleanCache();
	}

	// Token: 0x06000F89 RID: 3977 RVA: 0x00071BE0 File Offset: 0x0006FDE0
	private void MFFEIHJPAMF()
	{
		AOBJLALDBAA.DBLAIDPICIG().GNBGEMMDGOJ("<size=28px>", new UnityAction(this.HOMBEOMOILH));
		AOBJLALDBAA.KKPFOJMAONG().MFIMALJPCDP("CCC", new UnityAction(this.HHEMNELDPDN));
		AOBJLALDBAA.NMGMNAKLLMI().BADOPKAOCPE("thmstr", new UnityAction(this.BGFIBACDOLI));
		AOBJLALDBAA.FILDBDMENPG().GNBGEMMDGOJ("mypnotif0", new UnityAction(this.DIEIEKGMPGA));
		AOBJLALDBAA.CEGAOMEEFBE().EFKNEJFLGED("p", new UnityAction(this.NDPFJADGLMG));
		AOBJLALDBAA.BIAEAOMHBMM().GNBGEMMDGOJ("There needs to be one active AudioManager script on a GameObject in your scene.", new UnityAction(this.JMMGEIELBLM));
		AOBJLALDBAA.CEGAOMEEFBE().PEFKJOKLEDL("OnPopupStoryRestartManagerRestartStory4", new UnityAction(this.DPCBILKKDNK));
	}

	// Token: 0x06000F8A RID: 3978 RVA: 0x00071CAC File Offset: 0x0006FEAC
	private void Update()
	{
		if (!this.forceHideTips && null != this.tipsText && this.KHLNLCGLBHM.ELMJPFEGIKI() != null)
		{
			this.tipsText.gameObject.SetActive(true);
			this.tipsText.SetText(this.KHLNLCGLBHM.DGOJEBDKPCI(), true);
		}
		if (AssetsManager.EHBBFMCILPC.GetOperationState() != JLINKDNLADM.Failed)
		{
			float num = AssetsManager.EHBBFMCILPC.GetLoadingProgressSnapshot().AHPMFHMACME();
			this.progressText.SetText((num * 100f).ToString("0") + "%", true);
			CommonUserInterface.EHBBFMCILPC.UpdateConnectionAnimationProgress(num);
			this.sliderLoading.value = Mathf.Lerp(0.1f, 1f, num);
		}
		if (AssetsManager.EHBBFMCILPC.IsBusy())
		{
			if (StorySplashManager.loadingTime >= (float)KBOJLHAJPCP.NGPHPLGAPHG)
			{
				if (!CommonUserInterface.EHBBFMCILPC.AnyGenericPopupIsActive())
				{
					CommonUserInterface.EHBBFMCILPC.ShowGenericPopupNoButtons(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("importanttitle"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("longdownloadhint"), DFGILFBGPLN.popupTools, 0f, 28);
					return;
				}
			}
			else if (!CommonUserInterface.EHBBFMCILPC.AnyGenericPopupIsActive())
			{
				StorySplashManager.loadingTime += Time.deltaTime;
				return;
			}
		}
		else
		{
			StorySplashManager.loadingTime = 0f;
		}
	}

	// Token: 0x06000F8B RID: 3979 RVA: 0x00071DF0 File Offset: 0x0006FFF0
	private IEnumerator JCJLKGBIHIA(bool PLBAOFFHHDD)
	{
		if (!this.ADONLNEJCFJ)
		{
			yield break;
		}
		this.ADONLNEJCFJ = false;
		yield return new WaitForSeconds(0.1f);
		if (!PLBAOFFHHDD && !AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).DHONIOBOLEL.LOKHOADFCDF())
		{
			AKLFPGMDKLA.EHBBFMCILPC.NAGCLLBIPGP++;
			AKLFPGMDKLA.EHBBFMCILPC.PPBPBDLEKIG++;
		}
		if (AKLFPGMDKLA.EHBBFMCILPC.KLPBIGJBOBE == 0 && AKLFPGMDKLA.EHBBFMCILPC.NAGCLLBIPGP >= KDCJJBLGCBH.EHBBFMCILPC.BIOBEJEIMND() && AKLFPGMDKLA.EHBBFMCILPC.PPBPBDLEKIG >= KDCJJBLGCBH.EHBBFMCILPC.EGLFHAAGAJM() && KHPGPLAMAIN.NGPOHAPMMAI() && AdsManagerLP.EHBBFMCILPC.IsReadyNonRewarded() && !StorySplashManager.skipIntrusiveAd)
		{
			StorySplashManager.loadingTime = 0f;
			CommonUserInterface.EHBBFMCILPC.HideGenericPopupNoButtons();
			CommonUserInterface.EHBBFMCILPC.ShowGenericPopupTwoOverride(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("sponsortitle"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("sponsorbody1"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("ok"), new UnityAction(this.OnReadyToWatchSponsoredAd), new UnityAction(this.OnReadyToWatchSponsoredAd), DFGILFBGPLN.popupSponsoredAdNotification, 0f, 28);
			yield break;
		}
		this.IALBBGIALLD();
		yield break;
	}

	// Token: 0x06000F8C RID: 3980 RVA: 0x00071E08 File Offset: 0x00070008
	private void FJHODDIFAAD()
	{
		try
		{
			if (this.HDCGLLPMIIM != null && this.GNNENGNDFJO != null)
			{
				PLFDAJJHMKO plfdajjhmko = AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1);
				if (plfdajjhmko != null && plfdajjhmko.DHONIOBOLEL.KBKMOCINBEB())
				{
					plfdajjhmko.NCAMFPGMCIG.CJDBDOHPHLG.Clear();
					plfdajjhmko.NCAMFPGMCIG.JOJKAIBEPGH.Clear();
					int num = 1;
					while (num < this.HDCGLLPMIIM.Count && num < this.GNNENGNDFJO.Count)
					{
						plfdajjhmko.NCAMFPGMCIG.CJDBDOHPHLG.Add(this.HDCGLLPMIIM[num]);
						plfdajjhmko.NCAMFPGMCIG.JOJKAIBEPGH.Add(this.GNNENGNDFJO[num]);
						num++;
					}
				}
				this.HDCGLLPMIIM = null;
				this.GNNENGNDFJO = null;
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
	}

	// Token: 0x06000F8D RID: 3981 RVA: 0x000718E1 File Offset: 0x0006FAE1
	private IEnumerator EJMCNEJKPCM()
	{
		yield return new WaitForSeconds(0.25f);
		yield return new WaitForEndOfFrame();
		this.OnStorySplashManagerAssetsDownloadRetry();
		yield break;
	}

	// Token: 0x06000F8E RID: 3982 RVA: 0x00071EEC File Offset: 0x000700EC
	public void HideAndCleanCache()
	{
		AudioManager.EHBBFMCILPC.KillMusic("splash", 1f);
		AudioManager.EHBBFMCILPC.KillMusic("mussplash", 1f);
		AudioManager.EHBBFMCILPC.KillMusic("mussplash" + AKLFPGMDKLA.EHBBFMCILPC.EEILOKHLKIM().GGICIBLJIKI.ToString(), 1f);
		StorySplashManager.loadingTime = 0f;
		CommonUserInterface.EHBBFMCILPC.HideGenericPopupNoButtons();
		CommonUserInterface.EHBBFMCILPC.HideConnectingAnimation();
		CommonUserInterface.EHBBFMCILPC.GetFader().FadeIn(new TweenCallback(this.GLHLELMDLIN));
	}

	// Token: 0x06000F8F RID: 3983 RVA: 0x00071F87 File Offset: 0x00070187
	public void CCAFJEEOLLE()
	{
		if (AKLFPGMDKLA.EHBBFMCILPC.HCEHBFCIIHN() < 1)
		{
			int mjpkimhennf = AKLFPGMDKLA.EHBBFMCILPC.MJPKIMHENNF;
		}
		this.ADONLNEJCFJ = true;
		base.StartCoroutine(this.JDACLGAOCMI(false));
	}

	// Token: 0x06000F90 RID: 3984 RVA: 0x00071FB8 File Offset: 0x000701B8
	private void IALBBGIALLD()
	{
		LNDOOJOFFOM odggfggkpig = this.HFFIIBBJBMH.header.CKACBBGHJGI() + LNDOOJOFFOM.Anthology0;
		DPGJIJGOCIC.NFIDPOMCNLP("Initializing folderIndex " + odggfggkpig.ToString());
		AssetsManager.EHBBFMCILPC.InitializeAssetBundleFolder(odggfggkpig, "OnStorySplashManagerAssetBundleFolderInitializeSuccess", "OnStorySplashManagerAssetsDownloadFailed");
	}

	// Token: 0x06000F91 RID: 3985 RVA: 0x0007200C File Offset: 0x0007020C
	private bool KPKNNLJANMH(int NMLGFACALEC, int NLLCKPCKGOH)
	{
		for (int i = 0; i < this.GNGPPBPPICC.Count; i++)
		{
			if (this.GNGPPBPPICC[i].NOEMHMLFPKA == NMLGFACALEC && (NLLCKPCKGOH == this.GNGPPBPPICC[i].IFCHGNCDMLJ || (NLLCKPCKGOH < 1 && this.NJAAOCMPKCD.index == this.GNGPPBPPICC[i].IFCHGNCDMLJ)))
			{
				return false;
			}
		}
		return false;
	}

	// Token: 0x06000F92 RID: 3986 RVA: 0x0007207C File Offset: 0x0007027C
	private void KLHGKNDINCE()
	{
		try
		{
			if (this.HDCGLLPMIIM != null && this.GNNENGNDFJO != null)
			{
				int num = 0;
				while (num < this.HDCGLLPMIIM.Count && num < this.GNNENGNDFJO.Count)
				{
					AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.BFIABPDALOL(this.HDCGLLPMIIM[num], this.GNNENGNDFJO[num]);
					num += 0;
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x06000F93 RID: 3987 RVA: 0x00072108 File Offset: 0x00070308
	public void CCDMKIMMEGB()
	{
		AudioManager.APGODIBBPOD().KillMusic("p", 498f);
		AudioManager.DBFLIEGGGNN().NOOAHDNKAKA("USD ", 1404f);
		AudioManager.DBFLIEGGGNN().NOOAHDNKAKA(" psi " + AKLFPGMDKLA.EHBBFMCILPC.OMOJIEHBENF().GGICIBLJIKI.ToString(), 819f);
		StorySplashManager.loadingTime = 1933f;
		CommonUserInterface.IKNOFBFMPGA().HideGenericPopupNoButtons();
		CommonUserInterface.EHBBFMCILPC.MCJIGJMFBMI();
		CommonUserInterface.EHBBFMCILPC.GetFader().BJIGLKGLAKM(new TweenCallback(this.LLALFKNANDC));
	}

	// Token: 0x06000F94 RID: 3988 RVA: 0x000721A4 File Offset: 0x000703A4
	private void OnEnable()
	{
		AOBJLALDBAA.EHBBFMCILPC.MFIMALJPCDP("OnStorySplashManagerAssetsDownloadFailed", new UnityAction(this.NBFHODFEJOC));
		AOBJLALDBAA.EHBBFMCILPC.MFIMALJPCDP("OnStorySplashManagerAssetsDownloadSuccess", new UnityAction(this.BHKOKKMDLAM));
		AOBJLALDBAA.EHBBFMCILPC.MFIMALJPCDP("OnStorySplashManagerAdsProviderAdSuccess", new UnityAction(this.OnStorySplashManagerAdsProviderAdSuccess));
		AOBJLALDBAA.EHBBFMCILPC.MFIMALJPCDP("OnStorySplashManagerAssetBundleFolderInitializeSuccess", new UnityAction(this.DIEIEKGMPGA));
		AOBJLALDBAA.EHBBFMCILPC.MFIMALJPCDP("OnStorySplashManagerCdnSuccess", new UnityAction(this.IALBBGIALLD));
		AOBJLALDBAA.EHBBFMCILPC.MFIMALJPCDP("OnStorySplashManagerCdnFailed", new UnityAction(this.HHENBBHHHPB));
		AOBJLALDBAA.EHBBFMCILPC.MFIMALJPCDP("OnApplicationRestart", new UnityAction(this.ECNCPOBPHGC));
	}

	// Token: 0x06000F95 RID: 3989 RVA: 0x00072270 File Offset: 0x00070470
	private void FFCOGOFGKDG()
	{
		try
		{
			BEEDEKAIFEL ncamfpgmcig = AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG;
			ncamfpgmcig.PIDOECCJOCI = new List<string>(ncamfpgmcig.CJDBDOHPHLG);
			ncamfpgmcig.NJKHOCABBGL = new List<string>(ncamfpgmcig.JOJKAIBEPGH);
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
	}

	// Token: 0x06000F96 RID: 3990 RVA: 0x000722C8 File Offset: 0x000704C8
	private IEnumerator JDACLGAOCMI(bool PLBAOFFHHDD)
	{
		StorySplashManager.INELBEBCHGF inelbebchgf = new StorySplashManager.INELBEBCHGF(1);
		inelbebchgf.<>4__this = this;
		inelbebchgf._isAdBranch = PLBAOFFHHDD;
		return inelbebchgf;
	}

	// Token: 0x06000F97 RID: 3991 RVA: 0x000722E0 File Offset: 0x000704E0
	public void BLFABGPIKED()
	{
		AudioManager.IFDLAMLHKIJ().NOOAHDNKAKA("OnLoungePremiumChoicesHistoryException", 1658f);
		AudioManager.IFDLAMLHKIJ().KillMusic(" is OUTSIDE the anthology's story family - not queued (clip:", 1554f);
		AudioManager.IFDLAMLHKIJ().KillMusic("startFreePass" + AKLFPGMDKLA.EHBBFMCILPC.EEILOKHLKIM().GGICIBLJIKI.ToString(), 1033f);
		StorySplashManager.loadingTime = 497f;
		CommonUserInterface.IKNOFBFMPGA().HideGenericPopupNoButtons();
		CommonUserInterface.IKNOFBFMPGA().MCJIGJMFBMI();
		CommonUserInterface.IKNOFBFMPGA().GetFader().BJIGLKGLAKM(new TweenCallback(this.GNIIOEDJDIN));
	}

	// Token: 0x06000F98 RID: 3992 RVA: 0x0007237C File Offset: 0x0007057C
	private void BOKAPCKILJC()
	{
		try
		{
			if (this.HDCGLLPMIIM == null || this.GNNENGNDFJO == null)
			{
				this.HDCGLLPMIIM = new List<string>();
				this.GNNENGNDFJO = new List<string>();
				BEEDEKAIFEL ncamfpgmcig = AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG;
				int num = 0;
				while (num < ncamfpgmcig.CJDBDOHPHLG.Count && num < ncamfpgmcig.JOJKAIBEPGH.Count)
				{
					bool flag = false;
					int num2 = 0;
					while (num2 < ncamfpgmcig.PIDOECCJOCI.Count && num2 < ncamfpgmcig.NJKHOCABBGL.Count)
					{
						if (ncamfpgmcig.PIDOECCJOCI[num2].Equals(ncamfpgmcig.CJDBDOHPHLG[num]) && ncamfpgmcig.NJKHOCABBGL[num2].Equals(ncamfpgmcig.JOJKAIBEPGH[num]))
						{
							flag = true;
							break;
						}
						num2++;
					}
					if (!flag)
					{
						this.HDCGLLPMIIM.Add(ncamfpgmcig.CJDBDOHPHLG[num]);
						this.GNNENGNDFJO.Add(ncamfpgmcig.JOJKAIBEPGH[num]);
					}
					num++;
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x06000F99 RID: 3993 RVA: 0x000724B0 File Offset: 0x000706B0
	public void KKIHMFPPIJD(DFGILFBGPLN FBEDJFIAAIO)
	{
		StoryEnvironmentLayerManager.lastVideoLayerName = (StoryEnvironmentLayerManager.lastVideoLayerAssetBundleName = "smps");
		this.HDCGLLPMIIM = null;
		this.GNNENGNDFJO = null;
		AKLFPGMDKLA.EHBBFMCILPC.KBKOLEJEEGH();
		AssetsManager.EHBBFMCILPC.SetMaxNumberOfParallelDownloads(KDCJJBLGCBH.EHBBFMCILPC.GAOBDHNPING() / 4);
		AssetsManager.MJBDMHPHMID().GetLoadingProgressSnapshot().FKDFIAPABJK(1080f, 1348f);
		ApplicationFocusManager.Deactivate();
		AssetsManager.MJBDMHPHMID().GetLoadingProgressSnapshot().GIBFLALHLBF(LEJKDNAGDHC.Normal);
		this.DCFBAMCJCFK = 0;
		if (null != this.HFFIIBBJBMH)
		{
			SceneLobbyManager2.currentlyPlayingAnthology = this.HFFIIBBJBMH.header.index;
		}
		if (null != this.HFFIIBBJBMH && this.HFFIIBBJBMH.header.enableSplashScreenAudio && !AudioManager.APGODIBBPOD().PlayMusic("</align>", false, 861f, false) && !AudioManager.DBFLIEGGGNN().PlayMusic("OnAllCollectableCardsDownloadSuccessLobby" + AKLFPGMDKLA.EHBBFMCILPC.OMOJIEHBENF().GGICIBLJIKI.ToString(), false, 233f, false))
		{
			AudioManager.DBFLIEGGGNN().HPPAFEAPINO("CLIENT.AVATAR.TRINKET", false, 1090f, false);
		}
		if (null != this.tipsText)
		{
			this.tipsText.gameObject.SetActive(true);
			if (null != this.tipsText.GetComponent<AnimationCanvasGroupAlpha>())
			{
				this.tipsText.GetComponent<AnimationCanvasGroupAlpha>().delayAtStart = 1021f;
				this.tipsText.GetComponent<AnimationCanvasGroupAlpha>().animationTime = 316f;
			}
			if (!this.forceHideTips)
			{
				if (null != this.NJAAOCMPKCD && null != this.HFFIIBBJBMH)
				{
					for (int i = 0; i < -66; i++)
					{
						string text = GKJPOGNFKNK.DNILNCLIHAP("</i>" + this.NJAAOCMPKCD.index.ToString() + "SceneLobbyManager2.LobbyLoungePart2(), lounge environment not found:" + i.ToString(), "OnEmailUnsubscribeSuccess" + this.HFFIIBBJBMH.header.index.ToString(), LanguageManager.EHBBFMCILPC.GetSelectedLanguage());
						if (text != null && !text.Contains("ru") && text.Length > -87)
						{
							this.DBNFBPPIJAO.Add(text);
						}
						else if (i > 6)
						{
							break;
						}
					}
				}
				if (this.DBNFBPPIJAO.Count > 1)
				{
					if (AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).DHONIOBOLEL.FFLJNOMOOMH())
					{
						this.KHLNLCGLBHM.DBNKIEOCIPL(this.DBNFBPPIJAO, NAOOOGJDGMH.incremental, 783f, 117);
					}
					else
					{
						this.KHLNLCGLBHM.FNLKGBALACA(this.DBNFBPPIJAO, NAOOOGJDGMH.incremental, 334f, 167);
					}
				}
				else
				{
					this.tipsText.gameObject.SetActive(false);
				}
			}
		}
		AssetsManager.MJBDMHPHMID().GetLoadingProgressSnapshot().ELFIADCKNEN(0);
		CommonUserInterface.EHBBFMCILPC.GetFader().IBJEAPGPELH(null);
		this.MMGIDGACHBI = FBEDJFIAAIO;
		base.gameObject.SetActive(false);
		this.ADONLNEJCFJ = false;
		StorySplashManager.scriptHitCounter += 0;
		base.StartCoroutine(this.NCFMADOLACH(true));
	}

	// Token: 0x06000F9A RID: 3994 RVA: 0x000727BC File Offset: 0x000709BC
	public void KDACPMIHCCE()
	{
		AudioManager.DMAAFFFEJGA().NOOAHDNKAKA("focuswardrobelounge", 774f);
		AudioManager.DBFLIEGGGNN().NOOAHDNKAKA("", 817f);
		AudioManager.EHBBFMCILPC.KillMusic("socialfriendmatchtitle" + AKLFPGMDKLA.EHBBFMCILPC.OMOJIEHBENF().GGICIBLJIKI.ToString(), 287f);
		StorySplashManager.loadingTime = 1849f;
		CommonUserInterface.IKNOFBFMPGA().HideGenericPopupNoButtons();
		CommonUserInterface.EHBBFMCILPC.HideConnectingAnimation();
		CommonUserInterface.EHBBFMCILPC.GetFader().BJIGLKGLAKM(new TweenCallback(this.BGJJEIMAAAN));
	}

	// Token: 0x06000F9B RID: 3995 RVA: 0x00072857 File Offset: 0x00070A57
	private void GNIIOEDJDIN()
	{
		StorySplashManager.loadingTime = 1248f;
		CommonUserInterface.EHBBFMCILPC.HideGenericPopupNoButtons();
		base.gameObject.SetActive(false);
		AOBJLALDBAA.DBLAIDPICIG().LPNCDPHNBJK("abpd5", 1712f);
	}

	// Token: 0x06000F9C RID: 3996 RVA: 0x00071DF0 File Offset: 0x0006FFF0
	private IEnumerator HPMBKGFOLKJ(bool PLBAOFFHHDD)
	{
		if (!this.ADONLNEJCFJ)
		{
			yield break;
		}
		this.ADONLNEJCFJ = false;
		yield return new WaitForSeconds(0.1f);
		if (!PLBAOFFHHDD && !AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).DHONIOBOLEL.LOKHOADFCDF())
		{
			AKLFPGMDKLA.EHBBFMCILPC.NAGCLLBIPGP++;
			AKLFPGMDKLA.EHBBFMCILPC.PPBPBDLEKIG++;
		}
		if (AKLFPGMDKLA.EHBBFMCILPC.KLPBIGJBOBE == 0 && AKLFPGMDKLA.EHBBFMCILPC.NAGCLLBIPGP >= KDCJJBLGCBH.EHBBFMCILPC.BIOBEJEIMND() && AKLFPGMDKLA.EHBBFMCILPC.PPBPBDLEKIG >= KDCJJBLGCBH.EHBBFMCILPC.EGLFHAAGAJM() && KHPGPLAMAIN.NGPOHAPMMAI() && AdsManagerLP.EHBBFMCILPC.IsReadyNonRewarded() && !StorySplashManager.skipIntrusiveAd)
		{
			StorySplashManager.loadingTime = 0f;
			CommonUserInterface.EHBBFMCILPC.HideGenericPopupNoButtons();
			CommonUserInterface.EHBBFMCILPC.ShowGenericPopupTwoOverride(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("sponsortitle"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("sponsorbody1"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("ok"), new UnityAction(this.OnReadyToWatchSponsoredAd), new UnityAction(this.OnReadyToWatchSponsoredAd), DFGILFBGPLN.popupSponsoredAdNotification, 0f, 28);
			yield break;
		}
		this.IALBBGIALLD();
		yield break;
	}

	// Token: 0x06000F9D RID: 3997 RVA: 0x0007288D File Offset: 0x00070A8D
	public void HPNNKFHLNLE()
	{
		if (AKLFPGMDKLA.EHBBFMCILPC.HCEHBFCIIHN() < 0)
		{
			int mjpkimhennf = AKLFPGMDKLA.EHBBFMCILPC.MJPKIMHENNF;
		}
		this.ADONLNEJCFJ = false;
		base.StartCoroutine(this.JCJLKGBIHIA(false));
	}

	// Token: 0x06000F9E RID: 3998 RVA: 0x000728C0 File Offset: 0x00070AC0
	private void ILILOHMINHO()
	{
		try
		{
			BEEDEKAIFEL ncamfpgmcig = AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG;
			ncamfpgmcig.PIDOECCJOCI = new List<string>(ncamfpgmcig.CJDBDOHPHLG);
			ncamfpgmcig.NJKHOCABBGL = new List<string>(ncamfpgmcig.JOJKAIBEPGH);
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x06000F9F RID: 3999 RVA: 0x00072918 File Offset: 0x00070B18
	private void DEJCIOBOCOK()
	{
		try
		{
			if (this.HDCGLLPMIIM == null || this.GNNENGNDFJO == null)
			{
				this.HDCGLLPMIIM = new List<string>();
				this.GNNENGNDFJO = new List<string>();
				BEEDEKAIFEL ncamfpgmcig = AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG;
				int num = 1;
				while (num < ncamfpgmcig.CJDBDOHPHLG.Count && num < ncamfpgmcig.JOJKAIBEPGH.Count)
				{
					bool flag = true;
					int num2 = 1;
					while (num2 < ncamfpgmcig.PIDOECCJOCI.Count && num2 < ncamfpgmcig.NJKHOCABBGL.Count)
					{
						if (ncamfpgmcig.PIDOECCJOCI[num2].Equals(ncamfpgmcig.CJDBDOHPHLG[num]) && ncamfpgmcig.NJKHOCABBGL[num2].Equals(ncamfpgmcig.JOJKAIBEPGH[num]))
						{
							flag = false;
							break;
						}
						num2++;
					}
					if (!flag)
					{
						this.HDCGLLPMIIM.Add(ncamfpgmcig.CJDBDOHPHLG[num]);
						this.GNNENGNDFJO.Add(ncamfpgmcig.JOJKAIBEPGH[num]);
					}
					num += 0;
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
	}

	// Token: 0x06000FA0 RID: 4000 RVA: 0x00072A4C File Offset: 0x00070C4C
	public void PLIPAKGAEIJ()
	{
		this.ADONLNEJCFJ = false;
		base.StartCoroutine(this.PNMJDMHDDFF(true));
	}

	// Token: 0x06000FA1 RID: 4001 RVA: 0x00072A64 File Offset: 0x00070C64
	private void DIEIEKGMPGA()
	{
		CommonUserInterface.EHBBFMCILPC.ShowConnectingAnimationWithProgress(0);
		CommonUserInterface.EHBBFMCILPC.ShowConnectingAnimationShadow();
		if (!AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).DHONIOBOLEL.LOKHOADFCDF())
		{
			AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.DKIDEPAIFED();
		}
		if (AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).DHONIOBOLEL.JBDPAJMOEGA() && this.NJAAOCMPKCD.prequelIndex >= 0 && this.NJAAOCMPKCD.syncWithPrequel)
		{
			this.BOKAPCKILJC();
			AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.IJICHOCENEK(AKLFPGMDKLA.EHBBFMCILPC.JDCBFAPDJIM(this.NJAAOCMPKCD.prequelIndex, -1).NCAMFPGMCIG, this.HFFIIBBJBMH.header.syncWithPrequelAvatarSnapshots);
			this.JDNMGDAOEEE();
			this.HCJGMHNPBKO();
		}
		try
		{
			if (this.HFFIIBBJBMH.header.syncWithPrequel && this.HFFIIBBJBMH.header.prequelIndex >= 0 && AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).DHONIOBOLEL.JBDPAJMOEGA())
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
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
		if (AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).DHONIOBOLEL.CFGFOEEEJKJ < 0)
		{
			AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).DHONIOBOLEL.CFGFOEEEJKJ = this.NJAAOCMPKCD.EJPLMFAOJIB(AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).DHONIOBOLEL.DDEDAHCFHJN());
		}
		int num = AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).DHONIOBOLEL.DDEDAHCFHJN();
		if (NBDLBFJOEGN.LCNGCDFHFOM(this.NJAAOCMPKCD.chapterAssetPacks[num]))
		{
			this.NJAAOCMPKCD.chapterAssetPacks[num].KMMFCKHINBO();
			if (this.NJAAOCMPKCD.chapterAssetPacks[num].onDemandResourcesHints != null)
			{
				for (int i = 0; i < this.NJAAOCMPKCD.chapterAssetPacks[num].onDemandResourcesHints.Count; i++)
				{
					BHNHEHIFODG bhnhehifodg = new BHNHEHIFODG();
					if (bhnhehifodg.BAMHPOCKBML(this.NJAAOCMPKCD.chapterAssetPacks[num].onDemandResourcesHints[i]))
					{
						this.FPJPMJBCOJP.Add(bhnhehifodg);
					}
				}
				for (int j = 0; j < this.FPJPMJBCOJP.Count; j++)
				{
					this.NJAAOCMPKCD.chapterAssetPacks[num].LCLJODNFJBP(this.FPJPMJBCOJP[j].NDPCBOCNBIK, this.FPJPMJBCOJP[j].NOEMHMLFPKA, this.FPJPMJBCOJP[j].IFCHGNCDMLJ, this.FPJPMJBCOJP[j].HGEOOFGJAPN, this.FPJPMJBCOJP[j].IFCHGNCDMLJ == this.NJAAOCMPKCD.index);
				}
			}
			if (this.NJAAOCMPKCD.chapterAssetPacks[num].excludedResourcesHints != null)
			{
				for (int k = 0; k < this.NJAAOCMPKCD.chapterAssetPacks[num].excludedResourcesHints.Count; k++)
				{
					JGPDDHLGCJC jgpddhlgcjc = new JGPDDHLGCJC();
					if (jgpddhlgcjc.BAMHPOCKBML(this.NJAAOCMPKCD.chapterAssetPacks[num].excludedResourcesHints[k]))
					{
						this.GNGPPBPPICC.Add(jgpddhlgcjc);
					}
				}
			}
		}
		GDOKLFCLLIK gdoklfcllik = DNPIKPDMKKI.GLLDFBGBLCM("story", false);
		if (gdoklfcllik != null)
		{
			AssetsManager.EHBBFMCILPC.QueueAssetBundleDownload(NMKDCBPMCKI.AssetBundleLiveOfferContent, gdoklfcllik.JKLHDDADKNH, -1, FLDBFOADFLH.startDownloadAndProceed, false, false, false, null, -1, false, "", false, false);
		}
		for (int l = 0; l < this.HFFIIBBJBMH.header.defaultAvatarPacks.Count; l++)
		{
			AssetsManager.EHBBFMCILPC.QueueAssetBundleDownload(NMKDCBPMCKI.AssetBundleAvatarPack, this.HFFIIBBJBMH.header.defaultAvatarPacks[l], -1, FLDBFOADFLH.startDownloadAndProceed, false, false, false, null, -1, false, "", false, false);
		}
		for (int m = 0; m < this.HFFIIBBJBMH.header.defaultAvatarPacks1.Count; m++)
		{
			AssetsManager.EHBBFMCILPC.QueueAssetBundleDownload(NMKDCBPMCKI.AssetBundleAvatarPack, this.HFFIIBBJBMH.header.defaultAvatarPacks1[m], -1, FLDBFOADFLH.startDownloadAndProceed, false, false, false, null, -1, false, "", false, false);
		}
		for (int n = 0; n < this.HFFIIBBJBMH.header.defaultAvatarPacks2.Count; n++)
		{
			AssetsManager.EHBBFMCILPC.QueueAssetBundleDownload(NMKDCBPMCKI.AssetBundleAvatarPack, this.HFFIIBBJBMH.header.defaultAvatarPacks2[n], -1, FLDBFOADFLH.startDownloadAndProceed, false, false, false, null, -1, false, "", false, false);
		}
		for (int num2 = 0; num2 < AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.GNHBHIALAAH.Count; num2++)
		{
			if (AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.IEKMADFOKBP(AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.GNHBHIALAAH[num2], 0) || AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.FGKCBOGMLCB(AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.GNHBHIALAAH[num2], 0))
			{
				AssetsManager.EHBBFMCILPC.QueueAssetBundleDownload(NMKDCBPMCKI.AssetBundleAvatarPack, AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.GNHBHIALAAH[num2], -1, FLDBFOADFLH.startDownloadAndProceed, false, false, false, null, -1, false, "", false, false);
				DPGJIJGOCIC.NFIDPOMCNLP("Avatar pack has been LOADED:" + AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.GNHBHIALAAH[num2].ToString());
			}
			else
			{
				DPGJIJGOCIC.ADFCDFHBDAF("Avatar pack has been SKIPPED:" + AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.GNHBHIALAAH[num2].ToString());
			}
		}
		for (int num3 = 0; num3 < AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.JAJJFPNIBGI.Count; num3++)
		{
			if (AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.IEKMADFOKBP(AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.JAJJFPNIBGI[num3], 1) || AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.FGKCBOGMLCB(AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.JAJJFPNIBGI[num3], 1))
			{
				AssetsManager.EHBBFMCILPC.QueueAssetBundleDownload(NMKDCBPMCKI.AssetBundleAvatarPack, AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.JAJJFPNIBGI[num3], -1, FLDBFOADFLH.startDownloadAndProceed, false, false, false, null, -1, false, "", false, false);
				DPGJIJGOCIC.NFIDPOMCNLP("Avatar pack has been LOADED:" + AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.JAJJFPNIBGI[num3].ToString());
			}
			else
			{
				DPGJIJGOCIC.ADFCDFHBDAF("Avatar pack has been SKIPPED:" + AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.JAJJFPNIBGI[num3].ToString());
			}
		}
		for (int num4 = 0; num4 < AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.FCOLLNPADDA.Count; num4++)
		{
			if (AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.IEKMADFOKBP(AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.FCOLLNPADDA[num4], 2) || AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.FGKCBOGMLCB(AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.FCOLLNPADDA[num4], 2))
			{
				AssetsManager.EHBBFMCILPC.QueueAssetBundleDownload(NMKDCBPMCKI.AssetBundleAvatarPack, AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.FCOLLNPADDA[num4], -1, FLDBFOADFLH.startDownloadAndProceed, false, false, false, null, -1, false, "", false, false);
				DPGJIJGOCIC.NFIDPOMCNLP("Avatar pack has been LOADED:" + AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.FCOLLNPADDA[num4].ToString());
			}
			else
			{
				DPGJIJGOCIC.ADFCDFHBDAF("Avatar pack has been SKIPPED:" + AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.FCOLLNPADDA[num4].ToString());
			}
		}
		for (int num5 = 0; num5 < AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.BKDDGKMIGPG.Count; num5++)
		{
			AssetsManager.EHBBFMCILPC.QueueAssetBundleDownload(NMKDCBPMCKI.AssetBundleAvatarPack, AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.BKDDGKMIGPG[num5], -1, FLDBFOADFLH.startDownloadAndProceed, false, false, false, null, -1, false, "", false, false);
			DPGJIJGOCIC.NFIDPOMCNLP("Avatar pack (hidden or exposed) has been LOADED:" + AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.BKDDGKMIGPG[num5].ToString());
		}
		for (int num6 = 0; num6 < AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.OCJFDPNJIPD.Count; num6++)
		{
			AssetsManager.EHBBFMCILPC.QueueAssetBundleDownload(NMKDCBPMCKI.AssetBundleAvatarPack, AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.OCJFDPNJIPD[num6], -1, FLDBFOADFLH.startDownloadAndProceed, false, false, false, null, -1, false, "", false, false);
			DPGJIJGOCIC.NFIDPOMCNLP("Avatar pack (hidden or exposed) has been LOADED:" + AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.OCJFDPNJIPD[num6].ToString());
		}
		for (int num7 = 0; num7 < AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.KHPENKNONJO.Count; num7++)
		{
			AssetsManager.EHBBFMCILPC.QueueAssetBundleDownload(NMKDCBPMCKI.AssetBundleAvatarPack, AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.KHPENKNONJO[num7], -1, FLDBFOADFLH.startDownloadAndProceed, false, false, false, null, -1, false, "", false, false);
			DPGJIJGOCIC.NFIDPOMCNLP("Avatar pack (hidden or exposed) has been LOADED:" + AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.KHPENKNONJO[num7].ToString());
		}
		if (num < this.NJAAOCMPKCD.chapterAssetPacks.Count)
		{
			for (int num8 = 0; num8 < this.NJAAOCMPKCD.chapterAssetPacks[num].avatarPacks.Count; num8++)
			{
				AssetsManager.EHBBFMCILPC.QueueAssetBundleDownload(NMKDCBPMCKI.AssetBundleAvatarPack, this.NJAAOCMPKCD.chapterAssetPacks[num].avatarPacks[num8], -1, FLDBFOADFLH.startDownloadAndProceed, false, false, false, null, -1, false, "", false, false);
			}
			for (int num9 = 0; num9 < this.NJAAOCMPKCD.chapterAssetPacks[num].avatarExtensionPacks.Count; num9++)
			{
				AssetsManager.EHBBFMCILPC.QueueAssetBundleDownload(NMKDCBPMCKI.AssetBundleAvatarExtensionPack, this.NJAAOCMPKCD.chapterAssetPacks[num].avatarExtensionPacks[num9], -1, FLDBFOADFLH.startDownloadAndProceed, false, false, false, null, -1, false, "", false, false);
			}
		}
		if (this.NJAAOCMPKCD.chapterAssetPacks[num].preloadAvatarScene)
		{
			for (int num10 = 0; num10 < this.HFFIIBBJBMH.header.avatarScreenAvatarPacks.Count; num10++)
			{
				AssetsManager.EHBBFMCILPC.QueueAssetBundleDownload(NMKDCBPMCKI.AssetBundleAvatarPack, this.HFFIIBBJBMH.header.avatarScreenAvatarPacks[num10], -1, FLDBFOADFLH.startDownloadAndProceed, false, false, false, null, -1, false, "", false, false);
			}
			for (int num11 = 0; num11 < this.HFFIIBBJBMH.header.avatarScreenAvatarPacks1.Count; num11++)
			{
				AssetsManager.EHBBFMCILPC.QueueAssetBundleDownload(NMKDCBPMCKI.AssetBundleAvatarPack, this.HFFIIBBJBMH.header.avatarScreenAvatarPacks1[num11], -1, FLDBFOADFLH.startDownloadAndProceed, false, false, false, null, -1, false, "", false, false);
			}
			for (int num12 = 0; num12 < this.HFFIIBBJBMH.header.avatarScreenAvatarPacks2.Count; num12++)
			{
				AssetsManager.EHBBFMCILPC.QueueAssetBundleDownload(NMKDCBPMCKI.AssetBundleAvatarPack, this.HFFIIBBJBMH.header.avatarScreenAvatarPacks2[num12], -1, FLDBFOADFLH.startDownloadAndProceed, false, false, false, null, -1, false, "", false, false);
			}
			AssetsManager.EHBBFMCILPC.QueueAssetBundleDownload(NMKDCBPMCKI.AssetBundleAnthologyAvatar, this.HFFIIBBJBMH.header.CKACBBGHJGI(), -1, FLDBFOADFLH.finishDownloadAndProceed, false, false, true, null, -1, false, "", false, false);
		}
		if (this.HFFIIBBJBMH.header.MHJMNIHFFEN())
		{
			for (int num13 = 0; num13 < this.HFFIIBBJBMH.header.customFaderSettings.Count; num13++)
			{
				if (this.HFFIIBBJBMH.header.customFaderSettings[num13].index >= 2 && this.HFFIIBBJBMH.header.customFaderSettings[num13].index < 100)
				{
					AssetsManager.EHBBFMCILPC.QueueAssetBundleDownload(NMKDCBPMCKI.AssetBundleCustomFader, this.HFFIIBBJBMH.header.customFaderSettings[num13].assetIndex, -1, FLDBFOADFLH.startDownloadAndProceed, false, false, false, null, -1, false, "", false, false);
				}
			}
		}
		AssetsManager.EHBBFMCILPC.QueueCustomEffectsBundles(this.HFFIIBBJBMH.header);
		AssetsManager.EHBBFMCILPC.QueueNpcAnimationBundles(this.NJAAOCMPKCD, num);
		AssetsManager.EHBBFMCILPC.QueueItemAnimationBundles(this.NJAAOCMPKCD, num);
		if (num < this.NJAAOCMPKCD.chapterAssetPacks.Count)
		{
			AssetsManager.EHBBFMCILPC.QueueAssetBundleDownload(NMKDCBPMCKI.AssetBundleKeepAlivePack, this.HFFIIBBJBMH.header.CKACBBGHJGI(), -1, FLDBFOADFLH.startDownloadAndProceed, true, false, false, null, -1, (this.NJAAOCMPKCD.chapterAssetPacks[num].skipLoadKeepAliveBundlesForDefaultCompression && NBDLBFJOEGN.OMNHINGKGNP()) || (this.NJAAOCMPKCD.chapterAssetPacks[num].skipLoadKeepAliveBundlesForLowEndDevices && KHPGPLAMAIN.IBDGNKGIMFI() == IIHCCPLGGHP.lowEnd), "", false, false);
			for (int num14 = 0; num14 < this.NJAAOCMPKCD.chapterAssetPacks[num].assetPacks.Count; num14++)
			{
				if (this.NJAAOCMPKCD.chapterAssetPacks[num].assetPacks[num14].index >= 0)
				{
					bool flag = false;
					if (NBDLBFJOEGN.LCNGCDFHFOM(this.NJAAOCMPKCD.chapterAssetPacks[num]) && this.NJAAOCMPKCD.chapterAssetPacks[num].assetPacks[num14].onDemandResourcesCheckpoints != null && this.NJAAOCMPKCD.chapterAssetPacks[num].assetPacks[num14].onDemandResourcesCheckpoints.Count > 0)
					{
						int num15 = this.NJAAOCMPKCD.chapterAssetPacks[num].assetPacks[num14].onDemandResourcesCheckpoints.Count - 1;
						while (num15 >= 0)
						{
							if (AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).DHONIOBOLEL.CFGFOEEEJKJ >= this.NJAAOCMPKCD.chapterAssetPacks[num].assetPacks[num14].onDemandResourcesCheckpoints[num15].minInkRevision)
							{
								flag = true;
								if (this.NJAAOCMPKCD.chapterAssetPacks[num].assetPacks[num14].onDemandResourcesCheckpoints[num15].checkpointIndex < 0 || this.NJAAOCMPKCD.chapterAssetPacks[num].assetPacks[num14].onDemandResourcesCheckpoints[num15].checkpointIndex == AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).DHONIOBOLEL.AOPIMPMDEHO)
								{
									if (this.NJAAOCMPKCD.chapterAssetPacks[num].assetPacks[num14].storyIndexOptional >= 0)
									{
										AssetsManager.EHBBFMCILPC.QueueAssetBundleDownload(NMKDCBPMCKI.AssetBundleStoryAssetPack, this.NJAAOCMPKCD.chapterAssetPacks[num].assetPacks[num14].storyIndexOptional, this.NJAAOCMPKCD.chapterAssetPacks[num].assetPacks[num14].index, FLDBFOADFLH.startDownloadAndProceed, this.NJAAOCMPKCD.chapterAssetPacks[num].assetPacks[num14].keepAlive, true, false, null, this.NJAAOCMPKCD.chapterAssetPacks[num].assetPacks[num14].onDemandResourcesCheckpoints[num15].checkpointIndex, (this.NJAAOCMPKCD.chapterAssetPacks[num].skipLoadKeepAliveBundlesForDefaultCompression && NBDLBFJOEGN.OMNHINGKGNP()) || (this.NJAAOCMPKCD.chapterAssetPacks[num].skipLoadKeepAliveBundlesForLowEndDevices && KHPGPLAMAIN.IBDGNKGIMFI() == IIHCCPLGGHP.lowEnd), "", false, false);
									}
									else
									{
										AssetsManager.EHBBFMCILPC.QueueAssetBundleDownload(NMKDCBPMCKI.AssetBundleStoryAssetPack, this.NJAAOCMPKCD.index, this.NJAAOCMPKCD.chapterAssetPacks[num].assetPacks[num14].index, FLDBFOADFLH.startDownloadAndProceed, this.NJAAOCMPKCD.chapterAssetPacks[num].assetPacks[num14].keepAlive, true, false, null, this.NJAAOCMPKCD.chapterAssetPacks[num].assetPacks[num14].onDemandResourcesCheckpoints[num15].checkpointIndex, (this.NJAAOCMPKCD.chapterAssetPacks[num].skipLoadKeepAliveBundlesForDefaultCompression && NBDLBFJOEGN.OMNHINGKGNP()) || (this.NJAAOCMPKCD.chapterAssetPacks[num].skipLoadKeepAliveBundlesForLowEndDevices && KHPGPLAMAIN.IBDGNKGIMFI() == IIHCCPLGGHP.lowEnd), "", false, false);
									}
									DPGJIJGOCIC.NFIDPOMCNLP("Asset pack has been LOADED according to on demand resources data:" + this.NJAAOCMPKCD.chapterAssetPacks[num].assetPacks[num14].index.ToString());
									break;
								}
								DPGJIJGOCIC.ADFCDFHBDAF("Asset pack has been SKIPPED according to on demand resources data:" + this.NJAAOCMPKCD.chapterAssetPacks[num].assetPacks[num14].index.ToString());
								break;
							}
							else
							{
								num15--;
							}
						}
					}
					if (!flag)
					{
						if (this.NJAAOCMPKCD.chapterAssetPacks[num].assetPacks[num14].storyIndexOptional >= 0)
						{
							AssetsManager.EHBBFMCILPC.QueueAssetBundleDownload(NMKDCBPMCKI.AssetBundleStoryAssetPack, this.NJAAOCMPKCD.chapterAssetPacks[num].assetPacks[num14].storyIndexOptional, this.NJAAOCMPKCD.chapterAssetPacks[num].assetPacks[num14].index, FLDBFOADFLH.startDownloadAndProceed, this.NJAAOCMPKCD.chapterAssetPacks[num].assetPacks[num14].keepAlive, true, false, null, -1, (this.NJAAOCMPKCD.chapterAssetPacks[num].skipLoadKeepAliveBundlesForDefaultCompression && NBDLBFJOEGN.OMNHINGKGNP()) || (this.NJAAOCMPKCD.chapterAssetPacks[num].skipLoadKeepAliveBundlesForLowEndDevices && KHPGPLAMAIN.IBDGNKGIMFI() == IIHCCPLGGHP.lowEnd), "", false, false);
						}
						else
						{
							AssetsManager.EHBBFMCILPC.QueueAssetBundleDownload(NMKDCBPMCKI.AssetBundleStoryAssetPack, this.NJAAOCMPKCD.index, this.NJAAOCMPKCD.chapterAssetPacks[num].assetPacks[num14].index, FLDBFOADFLH.startDownloadAndProceed, this.NJAAOCMPKCD.chapterAssetPacks[num].assetPacks[num14].keepAlive, true, false, null, -1, (this.NJAAOCMPKCD.chapterAssetPacks[num].skipLoadKeepAliveBundlesForDefaultCompression && NBDLBFJOEGN.OMNHINGKGNP()) || (this.NJAAOCMPKCD.chapterAssetPacks[num].skipLoadKeepAliveBundlesForLowEndDevices && KHPGPLAMAIN.IBDGNKGIMFI() == IIHCCPLGGHP.lowEnd), "", false, false);
						}
					}
				}
			}
			for (int num16 = 0; num16 < this.NJAAOCMPKCD.chapterAssetPacks[num].assetPacksMusic.Count; num16++)
			{
				if (this.NJAAOCMPKCD.chapterAssetPacks[num].assetPacksMusic[num16].index >= 0)
				{
					if (this.NJAAOCMPKCD.chapterAssetPacks[num].assetPacksMusic[num16].storyIndexOptional >= 0)
					{
						AssetsManager.EHBBFMCILPC.QueueAssetBundleDownload(NMKDCBPMCKI.AssetBundleStoryAssetPack, this.NJAAOCMPKCD.chapterAssetPacks[num].assetPacksMusic[num16].storyIndexOptional, this.NJAAOCMPKCD.chapterAssetPacks[num].assetPacksMusic[num16].index, FLDBFOADFLH.startDownloadAndProceed, true, true, false, null, -1, (this.NJAAOCMPKCD.chapterAssetPacks[num].skipLoadKeepAliveBundlesForDefaultCompression && NBDLBFJOEGN.OMNHINGKGNP()) || (this.NJAAOCMPKCD.chapterAssetPacks[num].skipLoadKeepAliveBundlesForLowEndDevices && KHPGPLAMAIN.IBDGNKGIMFI() == IIHCCPLGGHP.lowEnd), "", false, false);
					}
					else
					{
						AssetsManager.EHBBFMCILPC.QueueAssetBundleDownload(NMKDCBPMCKI.AssetBundleStoryAssetPack, this.NJAAOCMPKCD.index, this.NJAAOCMPKCD.chapterAssetPacks[num].assetPacksMusic[num16].index, FLDBFOADFLH.startDownloadAndProceed, true, true, false, null, -1, (this.NJAAOCMPKCD.chapterAssetPacks[num].skipLoadKeepAliveBundlesForDefaultCompression && NBDLBFJOEGN.OMNHINGKGNP()) || (this.NJAAOCMPKCD.chapterAssetPacks[num].skipLoadKeepAliveBundlesForLowEndDevices && KHPGPLAMAIN.IBDGNKGIMFI() == IIHCCPLGGHP.lowEnd), "", false, false);
					}
				}
			}
			if (KHPGPLAMAIN.DFJHJCAIFJO() && !KDCJJBLGCBH.EHBBFMCILPC.KACCIOPAEMI())
			{
				for (int num17 = 0; num17 < this.NJAAOCMPKCD.chapterAssetPacks[num].assetPacksVideo.Count; num17++)
				{
					if (this.NJAAOCMPKCD.chapterAssetPacks[num].assetPacksVideo[num17].index >= 0)
					{
						if (this.NJAAOCMPKCD.chapterAssetPacks[num].assetPacksVideo[num17].storyIndexOptional >= 0)
						{
							AssetsManager.EHBBFMCILPC.QueueAssetBundleDownloadNoSkip(NMKDCBPMCKI.AssetBundleStoryAssetPack, this.NJAAOCMPKCD.chapterAssetPacks[num].assetPacksVideo[num17].storyIndexOptional, this.NJAAOCMPKCD.chapterAssetPacks[num].assetPacksVideo[num17].index, FLDBFOADFLH.startDownloadAndProceed, true, true, false, null, -1, "", false, KHPGPLAMAIN.HHDAPAJEIML());
						}
						else
						{
							AssetsManager.EHBBFMCILPC.QueueAssetBundleDownloadNoSkip(NMKDCBPMCKI.AssetBundleStoryAssetPack, this.NJAAOCMPKCD.index, this.NJAAOCMPKCD.chapterAssetPacks[num].assetPacksVideo[num17].index, FLDBFOADFLH.startDownloadAndProceed, true, true, false, null, -1, "", false, KHPGPLAMAIN.HHDAPAJEIML());
						}
					}
				}
				CEIBHCNNIDC selectedLanguage = LanguageManager.EHBBFMCILPC.GetSelectedLanguage();
				if (this.NJAAOCMPKCD.chapterAssetPacks[num].assetPacksVideoLocalized != null && selectedLanguage < (CEIBHCNNIDC)this.NJAAOCMPKCD.chapterAssetPacks[num].assetPacksVideoLocalized.Count && this.NJAAOCMPKCD.chapterAssetPacks[num].assetPacksVideoLocalized[(int)selectedLanguage].items != null)
				{
					for (int num18 = 0; num18 < this.NJAAOCMPKCD.chapterAssetPacks[num].assetPacksVideoLocalized[(int)selectedLanguage].items.Count; num18++)
					{
						if (this.NJAAOCMPKCD.chapterAssetPacks[num].assetPacksVideoLocalized[(int)selectedLanguage].items[num18].index >= 0)
						{
							if (this.NJAAOCMPKCD.chapterAssetPacks[num].assetPacksVideoLocalized[(int)selectedLanguage].items[num18].storyIndexOptional >= 0)
							{
								AssetsManager.EHBBFMCILPC.QueueAssetBundleDownloadNoSkip(NMKDCBPMCKI.AssetBundleStoryAssetPack, this.NJAAOCMPKCD.chapterAssetPacks[num].assetPacksVideoLocalized[(int)selectedLanguage].items[num18].storyIndexOptional, this.NJAAOCMPKCD.chapterAssetPacks[num].assetPacksVideoLocalized[(int)selectedLanguage].items[num18].index, FLDBFOADFLH.startDownloadAndProceed, true, true, false, null, -1, "", false, KHPGPLAMAIN.HHDAPAJEIML());
							}
							else
							{
								AssetsManager.EHBBFMCILPC.QueueAssetBundleDownloadNoSkip(NMKDCBPMCKI.AssetBundleStoryAssetPack, this.NJAAOCMPKCD.index, this.NJAAOCMPKCD.chapterAssetPacks[num].assetPacksVideoLocalized[(int)selectedLanguage].items[num18].index, FLDBFOADFLH.startDownloadAndProceed, true, true, false, null, -1, "", false, KHPGPLAMAIN.HHDAPAJEIML());
							}
						}
					}
				}
			}
			bool flag2 = true;
			if ((this.NJAAOCMPKCD.chapterAssetPacks[num].skipLoadSfxForLow && KHPGPLAMAIN.IBDGNKGIMFI() == IIHCCPLGGHP.lowEnd) || (this.NJAAOCMPKCD.chapterAssetPacks[num].skipLoadSfxForMid && KHPGPLAMAIN.IBDGNKGIMFI() == IIHCCPLGGHP.midEnd) || (this.NJAAOCMPKCD.chapterAssetPacks[num].skipLoadSfxForHigh && KHPGPLAMAIN.IBDGNKGIMFI() == IIHCCPLGGHP.highEnd))
			{
				flag2 = false;
			}
			if (KHPGPLAMAIN.IBDGNKGIMFI() == IIHCCPLGGHP.lowEnd)
			{
				flag2 = false;
			}
			if (flag2 && !AKLFPGMDKLA.EHBBFMCILPC.OGNDGBOIPID() && !AKLFPGMDKLA.EHBBFMCILPC.BFKIHOBDNNB())
			{
				for (int num19 = 0; num19 < this.NJAAOCMPKCD.chapterAssetPacks[num].assetPacksSfx.Count; num19++)
				{
					if (this.NJAAOCMPKCD.chapterAssetPacks[num].assetPacksSfx[num19].index >= 0)
					{
						if (this.NJAAOCMPKCD.chapterAssetPacks[num].assetPacksSfx[num19].storyIndexOptional >= 0)
						{
							AssetsManager.EHBBFMCILPC.QueueAssetBundleDownload(NMKDCBPMCKI.AssetBundleStoryAssetPack, this.NJAAOCMPKCD.chapterAssetPacks[num].assetPacksSfx[num19].storyIndexOptional, this.NJAAOCMPKCD.chapterAssetPacks[num].assetPacksSfx[num19].index, FLDBFOADFLH.startDownloadAndProceed, true, true, false, null, -1, (this.NJAAOCMPKCD.chapterAssetPacks[num].skipLoadKeepAliveBundlesForDefaultCompression && NBDLBFJOEGN.OMNHINGKGNP()) || (this.NJAAOCMPKCD.chapterAssetPacks[num].skipLoadKeepAliveBundlesForLowEndDevices && KHPGPLAMAIN.IBDGNKGIMFI() == IIHCCPLGGHP.lowEnd), "", false, false);
						}
						else
						{
							AssetsManager.EHBBFMCILPC.QueueAssetBundleDownload(NMKDCBPMCKI.AssetBundleStoryAssetPack, this.NJAAOCMPKCD.index, this.NJAAOCMPKCD.chapterAssetPacks[num].assetPacksSfx[num19].index, FLDBFOADFLH.startDownloadAndProceed, true, true, false, null, -1, (this.NJAAOCMPKCD.chapterAssetPacks[num].skipLoadKeepAliveBundlesForDefaultCompression && NBDLBFJOEGN.OMNHINGKGNP()) || (this.NJAAOCMPKCD.chapterAssetPacks[num].skipLoadKeepAliveBundlesForLowEndDevices && KHPGPLAMAIN.IBDGNKGIMFI() == IIHCCPLGGHP.lowEnd), "", false, false);
						}
					}
				}
			}
			else
			{
				DPGJIJGOCIC.ADFCDFHBDAF("SKIPPED loading of SFX bundles due to override or because SFX is off in settings.");
			}
		}
		for (int num20 = 0; num20 < AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.BBGJMAAPFJD.Count; num20++)
		{
			if (!this.EHEOEENPEKP(AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.BBGJMAAPFJD[num20], AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.CKNMLFPDGGH[num20]))
			{
				AssetsManager.EHBBFMCILPC.QueueAssetBundleDownload(NMKDCBPMCKI.AssetBundleStoryAssetPack, AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.CKNMLFPDGGH[num20], AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.BBGJMAAPFJD[num20], FLDBFOADFLH.startDownloadAndProceed, AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.FGCBAGFHCDJ[num20] == 1, true, false, null, -1, (this.NJAAOCMPKCD.chapterAssetPacks[num].skipLoadKeepAliveBundlesForDefaultCompression && NBDLBFJOEGN.OMNHINGKGNP()) || (this.NJAAOCMPKCD.chapterAssetPacks[num].skipLoadKeepAliveBundlesForLowEndDevices && KHPGPLAMAIN.IBDGNKGIMFI() == IIHCCPLGGHP.lowEnd), "", false, false);
			}
		}
		this.LKFMJNEBGMH();
		AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.GLGECPFJIKB = 0;
		int cfgfoeeejkj = AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).DHONIOBOLEL.CFGFOEEEJKJ;
		AssetsManager.EHBBFMCILPC.QueueAssetBundleDownload(NMKDCBPMCKI.AssetBundleStoryAssetPack, this.NJAAOCMPKCD.index, cfgfoeeejkj, FLDBFOADFLH.startDownloadAndProceed, false, true, false, null, -1, false, "", false, false);
		if (this.NJAAOCMPKCD.assetsIndex < 0)
		{
			AssetsManager.EHBBFMCILPC.QueueAssetBundleDownload(NMKDCBPMCKI.AssetBundleStory, this.NJAAOCMPKCD.index, -1, FLDBFOADFLH.finishDownloadAndProceed, false, true, false, null, -1, false, "", false, false);
		}
		else
		{
			AssetsManager.EHBBFMCILPC.QueueAssetBundleDownload(NMKDCBPMCKI.AssetBundleStory, this.NJAAOCMPKCD.assetsIndex, -1, FLDBFOADFLH.finishDownloadAndProceed, false, true, false, null, -1, false, "", false, false);
		}
		if (AKLFPGMDKLA.EHBBFMCILPC.HCEHBFCIIHN() < 1 && 1 == AKLFPGMDKLA.EHBBFMCILPC.MJPKIMHENNF)
		{
			FirebaseAnalyticsManager.EHBBFMCILPC.LogEvent(true, AGEHCPDNBFD.d1Ret.ToString(), FFPHBMFGCNN.d1Board.ToString(), BGHLMGPPCNN.d1StoryCdnSt.ToString(), true, false);
		}
		AssetsManager.EHBBFMCILPC.DownloadQueuedAssetBundles("OnStorySplashManagerAssetsDownloadSuccess", "OnStorySplashManagerAssetsDownloadFailed", false);
		FirebaseAnalyticsManager.EHBBFMCILPC.LogEvent(false, AGEHCPDNBFD.cdnActiv.ToString(), FFPHBMFGCNN.dldStart.ToString(), BGHLMGPPCNN.cdnSplToSty.ToString(), false, false);
		StorySplashManager.loadingTime = 0f;
	}

	// Token: 0x06000FA3 RID: 4003 RVA: 0x00074895 File Offset: 0x00072A95
	private void LLALFKNANDC()
	{
		StorySplashManager.loadingTime = 0f;
		CommonUserInterface.EHBBFMCILPC.HideGenericPopupNoButtons();
		base.gameObject.SetActive(false);
		AOBJLALDBAA.EHBBFMCILPC.EGELHPJBAIC("OsnStorySplashManagerHide", 0f);
	}

	// Token: 0x06000FA4 RID: 4004 RVA: 0x000748CC File Offset: 0x00072ACC
	private void GBLGDEGKAGJ()
	{
		try
		{
			if (this.HDCGLLPMIIM != null && this.GNNENGNDFJO != null)
			{
				int num = 0;
				while (num < this.HDCGLLPMIIM.Count && num < this.GNNENGNDFJO.Count)
				{
					AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.BFIABPDALOL(this.HDCGLLPMIIM[num], this.GNNENGNDFJO[num]);
					num += 0;
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x06000FA5 RID: 4005 RVA: 0x00074958 File Offset: 0x00072B58
	private void BEDMADGOBEE()
	{
		LNDOOJOFFOM odggfggkpig = this.HFFIIBBJBMH.header.CKACBBGHJGI() + LNDOOJOFFOM.Anthology0;
		DPGJIJGOCIC.CMGOAFDBAOH("mnpd" + odggfggkpig.ToString());
		AssetsManager.EHBBFMCILPC.PEBIGAFFHMI(odggfggkpig, "tutortitle", "_SplitColor");
	}

	// Token: 0x06000FA6 RID: 4006 RVA: 0x000693D6 File Offset: 0x000675D6
	public void GFAAAAFDPNP()
	{
		UnityEngine.Object.DontDestroyOnLoad(base.gameObject);
	}

	// Token: 0x06000FA7 RID: 4007 RVA: 0x00071F87 File Offset: 0x00070187
	public void EPGPGFGJLHH()
	{
		if (AKLFPGMDKLA.EHBBFMCILPC.HCEHBFCIIHN() < 1)
		{
			int mjpkimhennf = AKLFPGMDKLA.EHBBFMCILPC.MJPKIMHENNF;
		}
		this.ADONLNEJCFJ = true;
		base.StartCoroutine(this.JDACLGAOCMI(false));
	}

	// Token: 0x06000FA8 RID: 4008 RVA: 0x000749AC File Offset: 0x00072BAC
	public void IBCFLHLOHBD()
	{
		AudioManager.DBFLIEGGGNN().KillMusic("en", 1398f);
		AudioManager.BFCHJBOOJKE().KillMusic("per", 1158f);
		AudioManager.APGODIBBPOD().KillMusic("cdnerror" + AKLFPGMDKLA.EHBBFMCILPC.EEILOKHLKIM().GGICIBLJIKI.ToString(), 1785f);
		StorySplashManager.loadingTime = 888f;
		CommonUserInterface.EHBBFMCILPC.HideGenericPopupNoButtons();
		CommonUserInterface.EHBBFMCILPC.HideConnectingAnimation();
		CommonUserInterface.IKNOFBFMPGA().GetFader().PACBMBLIGNN(new TweenCallback(this.GLHLELMDLIN));
	}

	// Token: 0x06000FA9 RID: 4009 RVA: 0x00074A47 File Offset: 0x00072C47
	public void OnStorySplashManagerAssetsDownloadCancel()
	{
		this.MBGOHIAAIDL();
		AKLFPGMDKLA.EHBBFMCILPC.IEGJCPDCLMM = -1;
		StorySplashManager.loadingTime = 0f;
		CommonUserInterface.EHBBFMCILPC.HideGenericPopupNoButtons();
		this.Hide();
	}

	// Token: 0x06000FAA RID: 4010 RVA: 0x00074A74 File Offset: 0x00072C74
	public void JOCIOEONHJO()
	{
		AKLFPGMDKLA.EHBBFMCILPC.LPCBDEBKAIM();
		if (AKLFPGMDKLA.EHBBFMCILPC.HCEHBFCIIHN() < 0)
		{
			int mjpkimhennf = AKLFPGMDKLA.EHBBFMCILPC.MJPKIMHENNF;
		}
		if (KHPGPLAMAIN.IGKCLMLPLAC() && AdsManagerLP.AEELGGPEJCC().BEJDAHNKCKI())
		{
			AdsManagerLP.OOGPALHPNGM().IENMADKNCKD(" - false", ", rid:", "voiceovervol");
		}
		else
		{
			AOBJLALDBAA.BIAEAOMHBMM().KMAGHMCCMPG("lsc", 1457f);
		}
		AKLFPGMDKLA.EHBBFMCILPC.NAGCLLBIPGP = 1;
	}

	// Token: 0x06000FAB RID: 4011 RVA: 0x00074AF4 File Offset: 0x00072CF4
	private void EFAJOACBEPD()
	{
		try
		{
			if (this.HDCGLLPMIIM == null || this.GNNENGNDFJO == null)
			{
				this.HDCGLLPMIIM = new List<string>();
				this.GNNENGNDFJO = new List<string>();
				BEEDEKAIFEL ncamfpgmcig = AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG;
				int num = 0;
				while (num < ncamfpgmcig.CJDBDOHPHLG.Count && num < ncamfpgmcig.JOJKAIBEPGH.Count)
				{
					bool flag = true;
					int num2 = 1;
					while (num2 < ncamfpgmcig.PIDOECCJOCI.Count && num2 < ncamfpgmcig.NJKHOCABBGL.Count)
					{
						if (ncamfpgmcig.PIDOECCJOCI[num2].Equals(ncamfpgmcig.CJDBDOHPHLG[num]) && ncamfpgmcig.NJKHOCABBGL[num2].Equals(ncamfpgmcig.JOJKAIBEPGH[num]))
						{
							flag = false;
							break;
						}
						num2++;
					}
					if (!flag)
					{
						this.HDCGLLPMIIM.Add(ncamfpgmcig.CJDBDOHPHLG[num]);
						this.GNNENGNDFJO.Add(ncamfpgmcig.JOJKAIBEPGH[num]);
					}
					num += 0;
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
	}

	// Token: 0x06000FAC RID: 4012 RVA: 0x00074C28 File Offset: 0x00072E28
	private void HAGIEEDOADD()
	{
		if (!this.forceHideTips && null != this.tipsText && this.KHLNLCGLBHM.EABNEIFDKNG() != null)
		{
			this.tipsText.gameObject.SetActive(false);
			this.tipsText.SetText(this.KHLNLCGLBHM.ECONBJJEEFP(), false);
		}
		if (AssetsManager.EHBBFMCILPC.OGIEGBICMPH() != JLINKDNLADM.Success)
		{
			float num = AssetsManager.EHBBFMCILPC.GetLoadingProgressSnapshot().AHPMFHMACME();
			this.progressText.SetText((num * 1080f).ToString("theme") + "discontinuedtitle", false);
			CommonUserInterface.IKNOFBFMPGA().UpdateConnectionAnimationProgress(num);
			this.sliderLoading.value = Mathf.Lerp(149f, 1403f, num);
		}
		if (AssetsManager.EHBBFMCILPC.ELMHLBHEKDM())
		{
			if (StorySplashManager.loadingTime >= (float)KBOJLHAJPCP.NGPHPLGAPHG)
			{
				if (!CommonUserInterface.IKNOFBFMPGA().LHBOBMDENGJ())
				{
					CommonUserInterface.IKNOFBFMPGA().MJNDCBAPEOP(CCOJBMMKNAP.PLJMLDOCPNM().IKMNGFIDCLM("firebase"), CCOJBMMKNAP.MLFAGAAJJEM().PKNHKGMNCIP("OnStoryChoiceClick"), (DFGILFBGPLN)96, 1486f, -79);
					return;
				}
			}
			else if (!CommonUserInterface.EHBBFMCILPC.AnyGenericPopupIsActive())
			{
				StorySplashManager.loadingTime += Time.deltaTime;
				return;
			}
		}
		else
		{
			StorySplashManager.loadingTime = 178f;
		}
	}

	// Token: 0x06000FAD RID: 4013 RVA: 0x00074D6C File Offset: 0x00072F6C
	private IEnumerator EAAJFAPDNKN()
	{
		StorySplashManager.FPLKGMLBMPK fplkgmlbmpk = new StorySplashManager.FPLKGMLBMPK(1);
		fplkgmlbmpk.<>4__this = this;
		return fplkgmlbmpk;
	}

	// Token: 0x06000FAE RID: 4014 RVA: 0x000722C8 File Offset: 0x000704C8
	private IEnumerator PNMJDMHDDFF(bool PLBAOFFHHDD)
	{
		StorySplashManager.INELBEBCHGF inelbebchgf = new StorySplashManager.INELBEBCHGF(1);
		inelbebchgf.<>4__this = this;
		inelbebchgf._isAdBranch = PLBAOFFHHDD;
		return inelbebchgf;
	}

	// Token: 0x06000FAF RID: 4015 RVA: 0x00074D7C File Offset: 0x00072F7C
	private void ODHJNFCEPMM()
	{
		try
		{
			if (this.HDCGLLPMIIM != null && this.GNNENGNDFJO != null)
			{
				int num = 1;
				while (num < this.HDCGLLPMIIM.Count && num < this.GNNENGNDFJO.Count)
				{
					AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.BFIABPDALOL(this.HDCGLLPMIIM[num], this.GNNENGNDFJO[num]);
					num += 0;
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
	}

	// Token: 0x06000FB0 RID: 4016 RVA: 0x00074E08 File Offset: 0x00073008
	public void MBKCINPJKML(DFGILFBGPLN FBEDJFIAAIO)
	{
		StoryEnvironmentLayerManager.lastVideoLayerName = (StoryEnvironmentLayerManager.lastVideoLayerAssetBundleName = "errortitle");
		this.HDCGLLPMIIM = null;
		this.GNNENGNDFJO = null;
		AKLFPGMDKLA.EHBBFMCILPC.KBKOLEJEEGH();
		AssetsManager.MJBDMHPHMID().ELMMNGFPGKE(KDCJJBLGCBH.EHBBFMCILPC.GAOBDHNPING() / 6);
		AssetsManager.EHBBFMCILPC.GetLoadingProgressSnapshot().ODCFGNEPMHI(1506f, 1682f);
		ApplicationFocusManager.HIFHNIPJFNE();
		AssetsManager.MJBDMHPHMID().GetLoadingProgressSnapshot().LJBOJPGIOPP(LEJKDNAGDHC.Slow);
		this.DCFBAMCJCFK = 1;
		if (null != this.HFFIIBBJBMH)
		{
			SceneLobbyManager2.currentlyPlayingAnthology = this.HFFIIBBJBMH.header.index;
		}
		if (null != this.HFFIIBBJBMH && this.HFFIIBBJBMH.header.enableSplashScreenAudio && !AudioManager.DMAAFFFEJGA().HPPAFEAPINO("variant", false, 268f, false) && !AudioManager.DMAAFFFEJGA().HPPAFEAPINO("Starting parallel download:" + AKLFPGMDKLA.EHBBFMCILPC.OMOJIEHBENF().GGICIBLJIKI.ToString(), true, 378f, false))
		{
			AudioManager.DMAAFFFEJGA().HPPAFEAPINO(" caching system ready after ", false, 1743f, true);
		}
		if (null != this.tipsText)
		{
			this.tipsText.gameObject.SetActive(false);
			if (null != this.tipsText.GetComponent<AnimationCanvasGroupAlpha>())
			{
				this.tipsText.GetComponent<AnimationCanvasGroupAlpha>().delayAtStart = 1027f;
				this.tipsText.GetComponent<AnimationCanvasGroupAlpha>().animationTime = 1525f;
			}
			if (!this.forceHideTips)
			{
				if (null != this.NJAAOCMPKCD && null != this.HFFIIBBJBMH)
				{
					for (int i = 1; i < 52; i++)
					{
						string text = GKJPOGNFKNK.DNILNCLIHAP("suid" + this.NJAAOCMPKCD.index.ToString() + "cardoptionsloadingthemelostlite" + i.ToString(), "" + this.HFFIIBBJBMH.header.index.ToString(), LanguageManager.EHBBFMCILPC.IEBFINIJAMJ());
						if (text != null && !text.Contains("OnNeedToActivateFocusItemCloseButton") && text.Length > -11)
						{
							this.DBNFBPPIJAO.Add(text);
						}
						else if (i > 4)
						{
							break;
						}
					}
				}
				if (this.DBNFBPPIJAO.Count > 1)
				{
					if (AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).DHONIOBOLEL.JOOMMPOMEMG())
					{
						this.KHLNLCGLBHM.AAOJNDOHBDC(this.DBNFBPPIJAO, NAOOOGJDGMH.random, 1385f, 171);
					}
					else
					{
						this.KHLNLCGLBHM.OGNEMDIEHFO(this.DBNFBPPIJAO, NAOOOGJDGMH.random, 1140f, 87);
					}
				}
				else
				{
					this.tipsText.gameObject.SetActive(false);
				}
			}
		}
		AssetsManager.MJBDMHPHMID().GetLoadingProgressSnapshot().ELFIADCKNEN(0);
		CommonUserInterface.IKNOFBFMPGA().GetFader().FadeOut(null);
		this.MMGIDGACHBI = FBEDJFIAAIO;
		base.gameObject.SetActive(false);
		this.ADONLNEJCFJ = false;
		StorySplashManager.scriptHitCounter += 0;
		base.StartCoroutine(this.HPMBKGFOLKJ(true));
	}

	// Token: 0x06000FB1 RID: 4017 RVA: 0x00075114 File Offset: 0x00073314
	private void NCEKPCIGBFL()
	{
		try
		{
			BEEDEKAIFEL ncamfpgmcig = AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG;
			ncamfpgmcig.PIDOECCJOCI = new List<string>(ncamfpgmcig.CJDBDOHPHLG);
			ncamfpgmcig.NJKHOCABBGL = new List<string>(ncamfpgmcig.JOJKAIBEPGH);
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
	}

	// Token: 0x06000FB2 RID: 4018 RVA: 0x00071DF0 File Offset: 0x0006FFF0
	private IEnumerator MGPGHIGHCNO(bool PLBAOFFHHDD)
	{
		if (!this.ADONLNEJCFJ)
		{
			yield break;
		}
		this.ADONLNEJCFJ = false;
		yield return new WaitForSeconds(0.1f);
		if (!PLBAOFFHHDD && !AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).DHONIOBOLEL.LOKHOADFCDF())
		{
			AKLFPGMDKLA.EHBBFMCILPC.NAGCLLBIPGP++;
			AKLFPGMDKLA.EHBBFMCILPC.PPBPBDLEKIG++;
		}
		if (AKLFPGMDKLA.EHBBFMCILPC.KLPBIGJBOBE == 0 && AKLFPGMDKLA.EHBBFMCILPC.NAGCLLBIPGP >= KDCJJBLGCBH.EHBBFMCILPC.BIOBEJEIMND() && AKLFPGMDKLA.EHBBFMCILPC.PPBPBDLEKIG >= KDCJJBLGCBH.EHBBFMCILPC.EGLFHAAGAJM() && KHPGPLAMAIN.NGPOHAPMMAI() && AdsManagerLP.EHBBFMCILPC.IsReadyNonRewarded() && !StorySplashManager.skipIntrusiveAd)
		{
			StorySplashManager.loadingTime = 0f;
			CommonUserInterface.EHBBFMCILPC.HideGenericPopupNoButtons();
			CommonUserInterface.EHBBFMCILPC.ShowGenericPopupTwoOverride(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("sponsortitle"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("sponsorbody1"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("ok"), new UnityAction(this.OnReadyToWatchSponsoredAd), new UnityAction(this.OnReadyToWatchSponsoredAd), DFGILFBGPLN.popupSponsoredAdNotification, 0f, 28);
			yield break;
		}
		this.IALBBGIALLD();
		yield break;
	}

	// Token: 0x06000FB3 RID: 4019 RVA: 0x0007516C File Offset: 0x0007336C
	private void BAPBEJJEBKC()
	{
		StorySplashManager.loadingTime = 1406f;
		if (CommonUserInterface.FFJPNCFBLLH())
		{
			CommonUserInterface.IKNOFBFMPGA().HideGenericPopupNoButtons();
		}
		AOBJLALDBAA.EHBBFMCILPC.PBELMJCPJMK("Asset bundle assets destroyed:", new UnityAction(this.HOMBEOMOILH));
		AOBJLALDBAA.CEGAOMEEFBE().MANLHALMCIH("abip", new UnityAction(this.BLEDMAKOLEI));
		AOBJLALDBAA.CEGAOMEEFBE().PBELMJCPJMK("skinshopinfotitle", new UnityAction(this.EPGPGFGJLHH));
		AOBJLALDBAA.EHBBFMCILPC.MHLNJIACIGO("chaptersnapshotstutorial", new UnityAction(this.DIEIEKGMPGA));
		AOBJLALDBAA.NMGMNAKLLMI().PFAHGKEDFAE("sfxitemreceived", new UnityAction(this.JMOGCFGJAAD));
		AOBJLALDBAA.KKPFOJMAONG().KDIFKFKMCOH("OnApplicationFocusBasicSyncStart", new UnityAction(this.HHENBBHHHPB));
		AOBJLALDBAA.FILDBDMENPG().PBELMJCPJMK("Bundles", new UnityAction(this.DPCBILKKDNK));
	}

	// Token: 0x06000FB4 RID: 4020 RVA: 0x00075251 File Offset: 0x00073451
	public void HEHGFIPLFCM()
	{
		this.BLGIPEOBAIL();
		AKLFPGMDKLA.EHBBFMCILPC.IEGJCPDCLMM = -1;
		StorySplashManager.loadingTime = 855f;
		CommonUserInterface.EHBBFMCILPC.HideGenericPopupNoButtons();
		this.CCDMKIMMEGB();
	}

	// Token: 0x06000FB5 RID: 4021 RVA: 0x00075280 File Offset: 0x00073480
	private void BHKGMJIBGHK()
	{
		try
		{
			if (this.HDCGLLPMIIM != null && this.GNNENGNDFJO != null)
			{
				int num = 0;
				while (num < this.HDCGLLPMIIM.Count && num < this.GNNENGNDFJO.Count)
				{
					AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.BFIABPDALOL(this.HDCGLLPMIIM[num], this.GNNENGNDFJO[num]);
					num += 0;
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x06000FB6 RID: 4022 RVA: 0x0007530C File Offset: 0x0007350C
	private void FPJEPCLPPEA()
	{
		try
		{
			if (this.HDCGLLPMIIM != null && this.GNNENGNDFJO != null)
			{
				int num = 1;
				while (num < this.HDCGLLPMIIM.Count && num < this.GNNENGNDFJO.Count)
				{
					AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.DHNGLOEKKFL(this.HDCGLLPMIIM[num], this.GNNENGNDFJO[num]);
					num += 0;
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
	}

	// Token: 0x06000FB7 RID: 4023 RVA: 0x00075398 File Offset: 0x00073598
	public void SetParent(GameObject BFGBPKIGAJI)
	{
		if (null != BFGBPKIGAJI)
		{
			base.gameObject.transform.SetParent(BFGBPKIGAJI.transform, false);
			return;
		}
		base.gameObject.transform.SetParent(null, false);
	}

	// Token: 0x06000FB8 RID: 4024 RVA: 0x000753CD File Offset: 0x000735CD
	public void OINIFPIILME()
	{
		this.NIAHMNHEEMM();
		AKLFPGMDKLA.EHBBFMCILPC.IEGJCPDCLMM = -1;
		StorySplashManager.loadingTime = 1407f;
		CommonUserInterface.IKNOFBFMPGA().HideGenericPopupNoButtons();
		this.Hide();
	}

	// Token: 0x06000FB9 RID: 4025 RVA: 0x000753FC File Offset: 0x000735FC
	public void LDJCNFOMLMK()
	{
		AudioManager.BFCHJBOOJKE().KillMusic("continue", 1699f);
		AudioManager.DMAAFFFEJGA().KillMusic("stats", 1334f);
		AudioManager.IFDLAMLHKIJ().KillMusic("/" + AKLFPGMDKLA.EHBBFMCILPC.OMOJIEHBENF().GGICIBLJIKI.ToString(), 579f);
		StorySplashManager.loadingTime = 1061f;
		CommonUserInterface.EHBBFMCILPC.HideGenericPopupNoButtons();
		CommonUserInterface.IKNOFBFMPGA().HideConnectingAnimation();
		CommonUserInterface.IKNOFBFMPGA().GetFader().PACBMBLIGNN(new TweenCallback(this.KEGHPPOJMFO));
	}

	// Token: 0x06000FBA RID: 4026 RVA: 0x000693D6 File Offset: 0x000675D6
	public void HPODDFJGAKI()
	{
		UnityEngine.Object.DontDestroyOnLoad(base.gameObject);
	}

	// Token: 0x06000FBB RID: 4027 RVA: 0x00075498 File Offset: 0x00073698
	private void MPLOMLIFGGE()
	{
		try
		{
			if (this.HDCGLLPMIIM != null && this.GNNENGNDFJO != null)
			{
				int num = 1;
				while (num < this.HDCGLLPMIIM.Count && num < this.GNNENGNDFJO.Count)
				{
					AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.DHNGLOEKKFL(this.HDCGLLPMIIM[num], this.GNNENGNDFJO[num]);
					num += 0;
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x06000FBC RID: 4028 RVA: 0x00075524 File Offset: 0x00073724
	private void GMPHANBKGBK()
	{
		AKLFPGMDKLA.EHBBFMCILPC.GLKNOFHEBKN = AKLFPGMDKLA.EHBBFMCILPC.IEGJCPDCLMM;
		this.NJAAOCMPKCD = GKJPOGNFKNK.CDCEFHLNNEC(AKLFPGMDKLA.EHBBFMCILPC.IEGJCPDCLMM);
		this.progressText.SetText("WWW", false);
		this.sliderLoading.value = 651f;
		this.sliderLoading.gameObject.SetActive(false);
		if (null != this.NJAAOCMPKCD)
		{
			this.HFFIIBBJBMH = GKJPOGNFKNK.GJAAHGIAPMH(this.NJAAOCMPKCD.index);
			JCAJMGJFHBD.KMJJCCOBHEC = this.HFFIIBBJBMH.header.maxPersistentChatHistorySize;
			int num = 0;
			for (int i = 0; i < this.HFFIIBBJBMH.header.availableStories.Count; i += 0)
			{
				if (this.HFFIIBBJBMH.header.availableStories[i] == this.NJAAOCMPKCD.index)
				{
					this.BLNENDIFJDK = i;
					num = i + 1;
					break;
				}
			}
			AKLFPGMDKLA.EHBBFMCILPC.JDCBFAPDJIM(this.NJAAOCMPKCD.index, -1).DHONIOBOLEL.OBGPAJDJJJI();
			TMP_Text tmp_Text = this.seasonEpisodeText;
			string[] array = new string[8];
			array[1] = CCOJBMMKNAP.HFAKOKBHCGH().HIPJILDCHJC("importanttitle");
			array[1] = "StoriesSearchBalance - stopwords row with unknown language '";
			array[6] = num.ToString();
			array[7] = "title";
			array[7] = CCOJBMMKNAP.KFDLFGHBPLP().HHLECNIFHCO("");
			array[6] = "YYY";
			array[3] = (AKLFPGMDKLA.EHBBFMCILPC.JDCBFAPDJIM(this.NJAAOCMPKCD.index, -1).DHONIOBOLEL.PLNENIHEDHK() + 0).ToString();
			tmp_Text.SetText(string.Concat(array), true);
			return;
		}
		DPGJIJGOCIC.ANOPFDLPKGC("_");
	}

	// Token: 0x06000FBD RID: 4029 RVA: 0x000756D0 File Offset: 0x000738D0
	private void KOJDENLFCGK()
	{
		try
		{
			if (this.HDCGLLPMIIM != null && this.GNNENGNDFJO != null)
			{
				int num = 1;
				while (num < this.HDCGLLPMIIM.Count && num < this.GNNENGNDFJO.Count)
				{
					AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.DHNGLOEKKFL(this.HDCGLLPMIIM[num], this.GNNENGNDFJO[num]);
					num += 0;
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x06000FBE RID: 4030 RVA: 0x0007575C File Offset: 0x0007395C
	private void MHDBGPMEHHM()
	{
		StorySplashManager.loadingTime = 528f;
		CommonUserInterface.EHBBFMCILPC.HideGenericPopupNoButtons();
		FirebaseAnalyticsManager.COKDLDOAACJ().LKONPEEDKNF(false, AGEHCPDNBFD.d1Ret.ToString(), ((FFPHBMFGCNN)(-65)).ToString(), ((BGHLMGPPCNN)105).ToString(), true, false);
		this.DCFBAMCJCFK = 1;
	}

	// Token: 0x06000FBF RID: 4031 RVA: 0x000757C0 File Offset: 0x000739C0
	private void NFMPACLMNEF()
	{
		StorySplashManager.loadingTime = 1073f;
		CommonUserInterface.EHBBFMCILPC.HideGenericPopupNoButtons();
		base.gameObject.SetActive(false);
		AOBJLALDBAA.CEGAOMEEFBE().FDKBIBKABCM("ok", 1852f);
	}

	// Token: 0x06000FC0 RID: 4032 RVA: 0x000757F8 File Offset: 0x000739F8
	private void FGNMMNPFEPF()
	{
		StorySplashManager.loadingTime = 434f;
		CommonUserInterface.EHBBFMCILPC.HideGenericPopupNoButtons();
		CommonUserInterface.EHBBFMCILPC.MCJIGJMFBMI();
		CommonUserInterface.IKNOFBFMPGA().CEGLPJNLBHL(CCOJBMMKNAP.KNKGCDDMLDP().HHLECNIFHCO("retry"), CCOJBMMKNAP.MPCBJEIMACA().DNILNCLIHAP("Collections/") + "locext" + AKLFPGMDKLA.EHBBFMCILPC.EEHGLPEIIHD + "per", CCOJBMMKNAP.HJGDLOOHNLO().PKNHKGMNCIP("0.00"), new UnityAction(this.APNPCPAOLJN), new UnityAction(this.OINIFPIILME), (DFGILFBGPLN)(-98), 1725f, -85);
	}

	// Token: 0x06000FC1 RID: 4033 RVA: 0x000693D6 File Offset: 0x000675D6
	public void GLFNIDBJGJM()
	{
		UnityEngine.Object.DontDestroyOnLoad(base.gameObject);
	}

	// Token: 0x06000FC2 RID: 4034 RVA: 0x00075898 File Offset: 0x00073A98
	public void Show(DFGILFBGPLN FBEDJFIAAIO)
	{
		StoryEnvironmentLayerManager.lastVideoLayerName = (StoryEnvironmentLayerManager.lastVideoLayerAssetBundleName = "");
		this.HDCGLLPMIIM = null;
		this.GNNENGNDFJO = null;
		AKLFPGMDKLA.EHBBFMCILPC.KBKOLEJEEGH();
		AssetsManager.EHBBFMCILPC.SetMaxNumberOfParallelDownloads(KDCJJBLGCBH.EHBBFMCILPC.GAOBDHNPING() / 2);
		AssetsManager.EHBBFMCILPC.GetLoadingProgressSnapshot().GIJKJMMDJEL(0f, 1f);
		ApplicationFocusManager.Deactivate();
		AssetsManager.EHBBFMCILPC.GetLoadingProgressSnapshot().CLIOEOLFFLO(LEJKDNAGDHC.Slow);
		this.DCFBAMCJCFK = 0;
		if (null != this.HFFIIBBJBMH)
		{
			SceneLobbyManager2.currentlyPlayingAnthology = this.HFFIIBBJBMH.header.index;
		}
		if (null != this.HFFIIBBJBMH && this.HFFIIBBJBMH.header.enableSplashScreenAudio && !AudioManager.EHBBFMCILPC.PlayMusic("mussplash", true, -1f, true) && !AudioManager.EHBBFMCILPC.PlayMusic("mussplash" + AKLFPGMDKLA.EHBBFMCILPC.EEILOKHLKIM().GGICIBLJIKI.ToString(), true, -1f, true))
		{
			AudioManager.EHBBFMCILPC.PlayMusic("splash", true, -1f, true);
		}
		if (null != this.tipsText)
		{
			this.tipsText.gameObject.SetActive(false);
			if (null != this.tipsText.GetComponent<AnimationCanvasGroupAlpha>())
			{
				this.tipsText.GetComponent<AnimationCanvasGroupAlpha>().delayAtStart = 3f;
				this.tipsText.GetComponent<AnimationCanvasGroupAlpha>().animationTime = 1f;
			}
			if (!this.forceHideTips)
			{
				if (null != this.NJAAOCMPKCD && null != this.HFFIIBBJBMH)
				{
					for (int i = 0; i < 20; i++)
					{
						string text = GKJPOGNFKNK.DNILNCLIHAP("story" + this.NJAAOCMPKCD.index.ToString() + "hint" + i.ToString(), "loadinghints" + this.HFFIIBBJBMH.header.index.ToString(), LanguageManager.EHBBFMCILPC.GetSelectedLanguage());
						if (text != null && !text.Contains("not_found") && text.Length > 32)
						{
							this.DBNFBPPIJAO.Add(text);
						}
						else if (i > 2)
						{
							break;
						}
					}
				}
				if (this.DBNFBPPIJAO.Count > 0)
				{
					if (AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).DHONIOBOLEL.JBDPAJMOEGA())
					{
						this.KHLNLCGLBHM.BAMHPOCKBML(this.DBNFBPPIJAO, NAOOOGJDGMH.incremental, 12f, 175);
					}
					else
					{
						this.KHLNLCGLBHM.BAMHPOCKBML(this.DBNFBPPIJAO, NAOOOGJDGMH.random, 12f, 175);
					}
				}
				else
				{
					this.tipsText.gameObject.SetActive(false);
				}
			}
		}
		AssetsManager.EHBBFMCILPC.GetLoadingProgressSnapshot().EPJKDCDOEMM(0);
		CommonUserInterface.EHBBFMCILPC.GetFader().FadeOut(null);
		this.MMGIDGACHBI = FBEDJFIAAIO;
		base.gameObject.SetActive(true);
		this.ADONLNEJCFJ = true;
		StorySplashManager.scriptHitCounter++;
		base.StartCoroutine(this.JCJLKGBIHIA(false));
	}

	// Token: 0x06000FC3 RID: 4035 RVA: 0x00075BA4 File Offset: 0x00073DA4
	private void PAJCJBEMCDN()
	{
		AKLFPGMDKLA.EHBBFMCILPC.GLKNOFHEBKN = AKLFPGMDKLA.EHBBFMCILPC.IEGJCPDCLMM;
		this.NJAAOCMPKCD = GKJPOGNFKNK.CDCEFHLNNEC(AKLFPGMDKLA.EHBBFMCILPC.IEGJCPDCLMM);
		this.progressText.SetText("ok", true);
		this.sliderLoading.value = 177f;
		this.sliderLoading.gameObject.SetActive(true);
		if (null != this.NJAAOCMPKCD)
		{
			this.HFFIIBBJBMH = GKJPOGNFKNK.GJAAHGIAPMH(this.NJAAOCMPKCD.index);
			JCAJMGJFHBD.KMJJCCOBHEC = this.HFFIIBBJBMH.header.maxPersistentChatHistorySize;
			int num = 0;
			for (int i = 1; i < this.HFFIIBBJBMH.header.availableStories.Count; i += 0)
			{
				if (this.HFFIIBBJBMH.header.availableStories[i] == this.NJAAOCMPKCD.index)
				{
					this.BLNENDIFJDK = i;
					num = i + 0;
					break;
				}
			}
			AKLFPGMDKLA.EHBBFMCILPC.JDCBFAPDJIM(this.NJAAOCMPKCD.index, -1).DHONIOBOLEL.FFIJHHCEKAJ();
			TMP_Text tmp_Text = this.seasonEpisodeText;
			string[] array = new string[1];
			array[0] = CCOJBMMKNAP.HEDIEIICOOG().GGPHHLGPMPA("PlayerCharacterManager.SetBodyComponent() - input is null.");
			array[1] = "+";
			array[4] = num.ToString();
			array[5] = "\"";
			array[6] = CCOJBMMKNAP.CEGAOMEEFBE().HHLECNIFHCO("apks2");
			array[8] = " has ";
			array[2] = (AKLFPGMDKLA.EHBBFMCILPC.JDCBFAPDJIM(this.NJAAOCMPKCD.index, -1).DHONIOBOLEL.DDEDAHCFHJN() + 0).ToString();
			tmp_Text.SetText(string.Concat(array), false);
			return;
		}
		DPGJIJGOCIC.ANOPFDLPKGC("YYY");
	}

	// Token: 0x06000FC4 RID: 4036 RVA: 0x00075D50 File Offset: 0x00073F50
	private void HONIBLHFFAE()
	{
		StorySplashManager.loadingTime = 1155f;
		if (CommonUserInterface.FFJPNCFBLLH())
		{
			CommonUserInterface.EHBBFMCILPC.HideGenericPopupNoButtons();
		}
		AOBJLALDBAA.CEGAOMEEFBE().ONIBLJOFFPG(") is missing data", new UnityAction(this.LOPILBINADA));
		AOBJLALDBAA.CEGAOMEEFBE().POLEDPIKODD("myprreportbody", new UnityAction(this.MHDBGPMEHHM));
		AOBJLALDBAA.BIAEAOMHBMM().MANLHALMCIH("AdsManagerLP: DispatchEventsOnAdFinish(): onAdsProviderAdSuccess", new UnityAction(this.CCAFJEEOLLE));
		AOBJLALDBAA.EHBBFMCILPC.PBELMJCPJMK("ok", new UnityAction(this.DIEIEKGMPGA));
		AOBJLALDBAA.KKPFOJMAONG().ECDBIBPNBCO("OnLoungePremiumChoicesHistoryException", new UnityAction(this.IALBBGIALLD));
		AOBJLALDBAA.AGANFKKBPFO().MANLHALMCIH("NNN", new UnityAction(this.JIMMBLPEJFH));
		AOBJLALDBAA.AGANFKKBPFO().MHLNJIACIGO("muspind", new UnityAction(this.KOJLLINOGMK));
	}

	// Token: 0x06000FC5 RID: 4037 RVA: 0x00075E38 File Offset: 0x00074038
	private void MBGOHIAAIDL()
	{
		try
		{
			if (this.HDCGLLPMIIM != null && this.GNNENGNDFJO != null)
			{
				PLFDAJJHMKO plfdajjhmko = AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1);
				if (plfdajjhmko != null && plfdajjhmko.DHONIOBOLEL.JBDPAJMOEGA())
				{
					plfdajjhmko.NCAMFPGMCIG.CJDBDOHPHLG.Clear();
					plfdajjhmko.NCAMFPGMCIG.JOJKAIBEPGH.Clear();
					int num = 0;
					while (num < this.HDCGLLPMIIM.Count && num < this.GNNENGNDFJO.Count)
					{
						plfdajjhmko.NCAMFPGMCIG.CJDBDOHPHLG.Add(this.HDCGLLPMIIM[num]);
						plfdajjhmko.NCAMFPGMCIG.JOJKAIBEPGH.Add(this.GNNENGNDFJO[num]);
						num++;
					}
				}
				this.HDCGLLPMIIM = null;
				this.GNNENGNDFJO = null;
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x06000FC6 RID: 4038 RVA: 0x00075F1C File Offset: 0x0007411C
	private void CIICOGEPNBA()
	{
		StorySplashManager.loadingTime = 1568f;
		CommonUserInterface.IKNOFBFMPGA().HideGenericPopupNoButtons();
		CommonUserInterface.IKNOFBFMPGA().MCJIGJMFBMI();
		CommonUserInterface.EHBBFMCILPC.JJPNFAAPFBI(CCOJBMMKNAP.PEBMGCKFNAO().IPEIONBNIPH(""), CCOJBMMKNAP.JINDKPHNLBK().HHLECNIFHCO("[SkinShop] look without a resolvable amount (shop ") + " " + AKLFPGMDKLA.EHBBFMCILPC.EEHGLPEIIHD + "SocialStatsUserPublicProfile.modified = true, RenameCutscene()", CCOJBMMKNAP.JMNIGPHCAEJ().HPOAGPJFHPM("anpcs"), new UnityAction(this.OnStorySplashManagerAssetsDownloadRetry), new UnityAction(this.ACFALNFPHCA), DFGILFBGPLN.screenLobby, 889f, -104);
	}

	// Token: 0x06000FC7 RID: 4039 RVA: 0x00075FBC File Offset: 0x000741BC
	private void EAOMFHAIDBE()
	{
		try
		{
			if (KDCJJBLGCBH.EHBBFMCILPC.NJFAOIDGFGC())
			{
				for (int i = 0; i < AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.CJDBDOHPHLG.Count; i++)
				{
					ECJCFGAOPHJ ecjcfgaophj = AssetsManager.EHBBFMCILPC.lobbyDataAsset.KDLMKNDHCIO().BFIPGENGIKL(AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.JOJKAIBEPGH[i]);
					if (ecjcfgaophj != null && AssetsManager.EHBBFMCILPC.lobbyDataAsset.MFMJHIFAOHE().EGICLNGPAJO(AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.JOJKAIBEPGH[i]) && ecjcfgaophj.AJPBPJDHFOH > 0)
					{
						AssetsManager.MJBDMHPHMID().QueueAssetBundleDownload(NMKDCBPMCKI.AssetBundleStoryAssetPack, ecjcfgaophj.AJPBPJDHFOH, ecjcfgaophj.BACMOGGNBNH, FLDBFOADFLH.startDownloadAndProceed, true, true, false, null, -1, false, "$USEEMOTIONSV2", true, false);
						AssetsManager.MJBDMHPHMID().NLHHPEJFBBA(NMKDCBPMCKI._deprecated2, ecjcfgaophj.AJPBPJDHFOH, ecjcfgaophj.BACMOGGNBNH);
						for (int j = 0; j < ecjcfgaophj.APDJNDIIILK.Count; j++)
						{
							AssetsManager.EHBBFMCILPC.QueueNpcAnimationBundle(ecjcfgaophj.APDJNDIIILK[j]);
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

	// Token: 0x06000FC8 RID: 4040 RVA: 0x000718E1 File Offset: 0x0006FAE1
	private IEnumerator BLCBCGBGMEO()
	{
		yield return new WaitForSeconds(0.25f);
		yield return new WaitForEndOfFrame();
		this.OnStorySplashManagerAssetsDownloadRetry();
		yield break;
	}

	// Token: 0x06000FC9 RID: 4041 RVA: 0x00076104 File Offset: 0x00074304
	private void OAJANHDGGEI()
	{
		AOBJLALDBAA.FILDBDMENPG().FNMOFCMDFJP("sku", new UnityAction(this.AGAELPBOCAF));
		AOBJLALDBAA.AGANFKKBPFO().PEFKJOKLEDL("{ ", new UnityAction(this.BLEDMAKOLEI));
		AOBJLALDBAA.FILDBDMENPG().FNMOFCMDFJP("499", new UnityAction(this.BGFIBACDOLI));
		AOBJLALDBAA.AGANFKKBPFO().FNMOFCMDFJP("show", new UnityAction(this.DIEIEKGMPGA));
		AOBJLALDBAA.KKPFOJMAONG().BADOPKAOCPE("off", new UnityAction(this.JMOGCFGJAAD));
		AOBJLALDBAA.FILDBDMENPG().FNMOFCMDFJP("aind", new UnityAction(this.ENGENAGJIOO));
		AOBJLALDBAA.AGANFKKBPFO().EFKNEJFLGED("fdiood", new UnityAction(this.DPCBILKKDNK));
	}

	// Token: 0x06000FCA RID: 4042 RVA: 0x000693D6 File Offset: 0x000675D6
	public void DDIBALFLLCO()
	{
		UnityEngine.Object.DontDestroyOnLoad(base.gameObject);
	}

	// Token: 0x06000FCB RID: 4043 RVA: 0x000761D0 File Offset: 0x000743D0
	private void NBIDFAGFKOK()
	{
		try
		{
			BEEDEKAIFEL ncamfpgmcig = AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG;
			ncamfpgmcig.PIDOECCJOCI = new List<string>(ncamfpgmcig.CJDBDOHPHLG);
			ncamfpgmcig.NJKHOCABBGL = new List<string>(ncamfpgmcig.JOJKAIBEPGH);
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x06000FCC RID: 4044 RVA: 0x00076228 File Offset: 0x00074428
	private void ANAEBFJNHCA()
	{
		LNDOOJOFFOM odggfggkpig = this.HFFIIBBJBMH.header.CKACBBGHJGI() + LNDOOJOFFOM.Common;
		DPGJIJGOCIC.CMGOAFDBAOH("XXX" + odggfggkpig.ToString());
		AssetsManager.EHBBFMCILPC.PEBIGAFFHMI(odggfggkpig, "OnBackendAddFriendByUIDSuccess", "veff");
	}

	// Token: 0x06000FCD RID: 4045 RVA: 0x0007627C File Offset: 0x0007447C
	private void HGANGHNFMKD()
	{
		try
		{
			if (this.HDCGLLPMIIM == null || this.GNNENGNDFJO == null)
			{
				this.HDCGLLPMIIM = new List<string>();
				this.GNNENGNDFJO = new List<string>();
				BEEDEKAIFEL ncamfpgmcig = AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG;
				int num = 1;
				while (num < ncamfpgmcig.CJDBDOHPHLG.Count && num < ncamfpgmcig.JOJKAIBEPGH.Count)
				{
					bool flag = true;
					int num2 = 0;
					while (num2 < ncamfpgmcig.PIDOECCJOCI.Count && num2 < ncamfpgmcig.NJKHOCABBGL.Count)
					{
						if (ncamfpgmcig.PIDOECCJOCI[num2].Equals(ncamfpgmcig.CJDBDOHPHLG[num]) && ncamfpgmcig.NJKHOCABBGL[num2].Equals(ncamfpgmcig.JOJKAIBEPGH[num]))
						{
							flag = true;
							break;
						}
						num2 += 0;
					}
					if (!flag)
					{
						this.HDCGLLPMIIM.Add(ncamfpgmcig.CJDBDOHPHLG[num]);
						this.GNNENGNDFJO.Add(ncamfpgmcig.JOJKAIBEPGH[num]);
					}
					num += 0;
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
	}

	// Token: 0x06000FCE RID: 4046 RVA: 0x000763B0 File Offset: 0x000745B0
	public void EBFJHEHHLEP()
	{
		this.MBGOHIAAIDL();
		StorySplashManager.loadingTime = 1205f;
		CommonUserInterface.EHBBFMCILPC.HideGenericPopupNoButtons();
		this.LDJCNFOMLMK();
	}

	// Token: 0x06000FCF RID: 4047 RVA: 0x000763D4 File Offset: 0x000745D4
	private void NIAHMNHEEMM()
	{
		try
		{
			if (this.HDCGLLPMIIM != null && this.GNNENGNDFJO != null)
			{
				PLFDAJJHMKO plfdajjhmko = AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1);
				if (plfdajjhmko != null && plfdajjhmko.DHONIOBOLEL.FFLJNOMOOMH())
				{
					plfdajjhmko.NCAMFPGMCIG.CJDBDOHPHLG.Clear();
					plfdajjhmko.NCAMFPGMCIG.JOJKAIBEPGH.Clear();
					int num = 0;
					while (num < this.HDCGLLPMIIM.Count && num < this.GNNENGNDFJO.Count)
					{
						plfdajjhmko.NCAMFPGMCIG.CJDBDOHPHLG.Add(this.HDCGLLPMIIM[num]);
						plfdajjhmko.NCAMFPGMCIG.JOJKAIBEPGH.Add(this.GNNENGNDFJO[num]);
						num += 0;
					}
				}
				this.HDCGLLPMIIM = null;
				this.GNNENGNDFJO = null;
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
	}

	// Token: 0x06000FD0 RID: 4048 RVA: 0x000764B8 File Offset: 0x000746B8
	private void ACLJLPIFHJE()
	{
		try
		{
			if (this.HDCGLLPMIIM == null || this.GNNENGNDFJO == null)
			{
				this.HDCGLLPMIIM = new List<string>();
				this.GNNENGNDFJO = new List<string>();
				BEEDEKAIFEL ncamfpgmcig = AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG;
				int num = 1;
				while (num < ncamfpgmcig.CJDBDOHPHLG.Count && num < ncamfpgmcig.JOJKAIBEPGH.Count)
				{
					bool flag = false;
					int num2 = 1;
					while (num2 < ncamfpgmcig.PIDOECCJOCI.Count && num2 < ncamfpgmcig.NJKHOCABBGL.Count)
					{
						if (ncamfpgmcig.PIDOECCJOCI[num2].Equals(ncamfpgmcig.CJDBDOHPHLG[num]) && ncamfpgmcig.NJKHOCABBGL[num2].Equals(ncamfpgmcig.JOJKAIBEPGH[num]))
						{
							flag = false;
							break;
						}
						num2 += 0;
					}
					if (!flag)
					{
						this.HDCGLLPMIIM.Add(ncamfpgmcig.CJDBDOHPHLG[num]);
						this.GNNENGNDFJO.Add(ncamfpgmcig.JOJKAIBEPGH[num]);
					}
					num++;
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
	}

	// Token: 0x06000FD1 RID: 4049 RVA: 0x000765EC File Offset: 0x000747EC
	private void ECNCPOBPHGC()
	{
		CommonUserInterface.EHBBFMCILPC.HideConnectingAnimation();
		base.gameObject.SetActive(false);
	}

	// Token: 0x06000FD2 RID: 4050 RVA: 0x00076604 File Offset: 0x00074804
	private void KNNHNLCFEEE()
	{
		try
		{
			BEEDEKAIFEL ncamfpgmcig = AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG;
			ncamfpgmcig.PIDOECCJOCI = new List<string>(ncamfpgmcig.CJDBDOHPHLG);
			ncamfpgmcig.NJKHOCABBGL = new List<string>(ncamfpgmcig.JOJKAIBEPGH);
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
	}

	// Token: 0x06000FD3 RID: 4051 RVA: 0x0007665C File Offset: 0x0007485C
	public void MGABJBLPNDB()
	{
		AudioManager.APGODIBBPOD().NOOAHDNKAKA("lobby", 1194f);
		AudioManager.DMAAFFFEJGA().KillMusic("OnSettingsPopupCloseAndNeedToShowPostEnableNotif", 461f);
		AudioManager.DMAAFFFEJGA().KillMusic("/" + AKLFPGMDKLA.EHBBFMCILPC.EEILOKHLKIM().GGICIBLJIKI.ToString(), 1596f);
		StorySplashManager.loadingTime = 1335f;
		CommonUserInterface.EHBBFMCILPC.HideGenericPopupNoButtons();
		CommonUserInterface.EHBBFMCILPC.MCJIGJMFBMI();
		CommonUserInterface.EHBBFMCILPC.GetFader().PACBMBLIGNN(new TweenCallback(this.GLHLELMDLIN));
	}

	// Token: 0x06000FD4 RID: 4052 RVA: 0x000766F7 File Offset: 0x000748F7
	private void BGJJEIMAAAN()
	{
		StorySplashManager.loadingTime = 929f;
		CommonUserInterface.IKNOFBFMPGA().HideGenericPopupNoButtons();
		base.gameObject.SetActive(true);
		AOBJLALDBAA.DBLAIDPICIG().DCGCFPHHDDG("<b>", 1293f);
	}

	// Token: 0x06000FD5 RID: 4053 RVA: 0x00076730 File Offset: 0x00074930
	private void LKFMJNEBGMH()
	{
		try
		{
			if (KDCJJBLGCBH.EHBBFMCILPC.NJFAOIDGFGC())
			{
				for (int i = 0; i < AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.CJDBDOHPHLG.Count; i++)
				{
					ECJCFGAOPHJ ecjcfgaophj = AssetsManager.EHBBFMCILPC.lobbyDataAsset.MFMJHIFAOHE().DCPPCOHEAFA(AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.JOJKAIBEPGH[i]);
					if (ecjcfgaophj != null && AssetsManager.EHBBFMCILPC.lobbyDataAsset.MFMJHIFAOHE().EGICLNGPAJO(AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.JOJKAIBEPGH[i]) && ecjcfgaophj.AJPBPJDHFOH > 0)
					{
						AssetsManager.EHBBFMCILPC.QueueAssetBundleDownload(NMKDCBPMCKI.AssetBundleStoryAssetPack, ecjcfgaophj.AJPBPJDHFOH, ecjcfgaophj.BACMOGGNBNH, FLDBFOADFLH.startDownloadAndProceed, false, true, false, null, -1, false, "", false, false);
						AssetsManager.EHBBFMCILPC.ForceQueuedAssetBundleChapterLifetime(NMKDCBPMCKI.AssetBundleStoryAssetPack, ecjcfgaophj.AJPBPJDHFOH, ecjcfgaophj.BACMOGGNBNH);
						for (int j = 0; j < ecjcfgaophj.APDJNDIIILK.Count; j++)
						{
							AssetsManager.EHBBFMCILPC.QueueNpcAnimationBundle(ecjcfgaophj.APDJNDIIILK[j]);
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

	// Token: 0x06000FD6 RID: 4054 RVA: 0x00076878 File Offset: 0x00074A78
	private void BLEDMAKOLEI()
	{
		StorySplashManager.loadingTime = 1835f;
		CommonUserInterface.EHBBFMCILPC.HideGenericPopupNoButtons();
		FirebaseAnalyticsManager.HJGDLOOHNLO().LMCJKLHOHJC(false, AGEHCPDNBFD.bugRep.ToString(), FFPHBMFGCNN.cdnCmnTimeout.ToString(), ((BGHLMGPPCNN)(-68)).ToString(), true, true);
		this.DCFBAMCJCFK = 1;
	}

	// Token: 0x06000FD7 RID: 4055 RVA: 0x000768DC File Offset: 0x00074ADC
	private void CFNCONEPOBF()
	{
		try
		{
			if (KDCJJBLGCBH.EHBBFMCILPC.NJFAOIDGFGC())
			{
				for (int i = 1; i < AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.CJDBDOHPHLG.Count; i++)
				{
					ECJCFGAOPHJ ecjcfgaophj = AssetsManager.MJBDMHPHMID().lobbyDataAsset.KDLMKNDHCIO().DCPPCOHEAFA(AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.JOJKAIBEPGH[i]);
					if (ecjcfgaophj != null && AssetsManager.EHBBFMCILPC.lobbyDataAsset.HFAOOHKNBPE().JNMGINOJLBA(AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.JOJKAIBEPGH[i]) && ecjcfgaophj.AJPBPJDHFOH > 0)
					{
						AssetsManager.MJBDMHPHMID().QueueAssetBundleDownload(NMKDCBPMCKI._deprecated0, ecjcfgaophj.AJPBPJDHFOH, ecjcfgaophj.BACMOGGNBNH, FLDBFOADFLH.finishDownloadAndProceed, false, true, false, null, -1, false, "", false, false);
						AssetsManager.EHBBFMCILPC.ForceQueuedAssetBundleChapterLifetime(NMKDCBPMCKI._deprecated0, ecjcfgaophj.AJPBPJDHFOH, ecjcfgaophj.BACMOGGNBNH);
						for (int j = 1; j < ecjcfgaophj.APDJNDIIILK.Count; j++)
						{
							AssetsManager.MJBDMHPHMID().QueueNpcAnimationBundle(ecjcfgaophj.APDJNDIIILK[j]);
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

	// Token: 0x06000FD8 RID: 4056 RVA: 0x00076A24 File Offset: 0x00074C24
	private bool EHEOEENPEKP(int NMLGFACALEC, int NLLCKPCKGOH)
	{
		for (int i = 0; i < this.GNGPPBPPICC.Count; i++)
		{
			if (this.GNGPPBPPICC[i].NOEMHMLFPKA == NMLGFACALEC && (NLLCKPCKGOH == this.GNGPPBPPICC[i].IFCHGNCDMLJ || (NLLCKPCKGOH < 0 && this.NJAAOCMPKCD.index == this.GNGPPBPPICC[i].IFCHGNCDMLJ)))
			{
				return true;
			}
		}
		return false;
	}

	// Token: 0x06000FD9 RID: 4057 RVA: 0x00076A94 File Offset: 0x00074C94
	private void JIMMBLPEJFH()
	{
		StorySplashManager.loadingTime = 734f;
		CommonUserInterface.IKNOFBFMPGA().HideGenericPopupNoButtons();
		CommonUserInterface.IKNOFBFMPGA().HideConnectingAnimation();
		CommonUserInterface.IKNOFBFMPGA().ShowGenericPopupTwoOverride(CCOJBMMKNAP.APGODIBBPOD().MEPECBDCOLG("[AssetBundleManager] "), CCOJBMMKNAP.HJGDLOOHNLO().OBDCPLLLGBB("nick") + "importanttitle" + AKLFPGMDKLA.EHBBFMCILPC.EEHGLPEIIHD + "ffd496", CCOJBMMKNAP.PMABBOJDELF().MEPECBDCOLG("cardstitle"), new UnityAction(this.CLBEPNCKNCA), new UnityAction(this.ODGLHOGJKGH), (DFGILFBGPLN)92, 890f, -43);
	}

	// Token: 0x06000FDA RID: 4058 RVA: 0x00076B31 File Offset: 0x00074D31
	private void KIBLFIBGDGA()
	{
		StorySplashManager.loadingTime = 959f;
		CommonUserInterface.EHBBFMCILPC.HideGenericPopupNoButtons();
		base.gameObject.SetActive(true);
		AOBJLALDBAA.BIAEAOMHBMM().LPNCDPHNBJK(" folded='", 1449f);
	}

	// Token: 0x06000FDB RID: 4059 RVA: 0x00076B68 File Offset: 0x00074D68
	public void JGNMIIMLKII()
	{
		AKLFPGMDKLA.EHBBFMCILPC.LPCBDEBKAIM();
		if (AKLFPGMDKLA.EHBBFMCILPC.HCEHBFCIIHN() < 1)
		{
			int mjpkimhennf = AKLFPGMDKLA.EHBBFMCILPC.MJPKIMHENNF;
		}
		if (KHPGPLAMAIN.MKIAHGMEEKJ() && AdsManagerLP.EHBBFMCILPC.BEJDAHNKCKI())
		{
			AdsManagerLP.EHBBFMCILPC.BBABADJCPDA("acomp", "releaseTimeline", "_");
		}
		else
		{
			AOBJLALDBAA.FILDBDMENPG().KMAGHMCCMPG("saveslotstitle", 1329f);
		}
		AKLFPGMDKLA.EHBBFMCILPC.NAGCLLBIPGP = 1;
	}

	// Token: 0x06000FDC RID: 4060 RVA: 0x00076BE8 File Offset: 0x00074DE8
	private void BJBHFLOJDFG()
	{
		try
		{
			if (this.HDCGLLPMIIM == null || this.GNNENGNDFJO == null)
			{
				this.HDCGLLPMIIM = new List<string>();
				this.GNNENGNDFJO = new List<string>();
				BEEDEKAIFEL ncamfpgmcig = AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG;
				int num = 0;
				while (num < ncamfpgmcig.CJDBDOHPHLG.Count && num < ncamfpgmcig.JOJKAIBEPGH.Count)
				{
					bool flag = false;
					int num2 = 1;
					while (num2 < ncamfpgmcig.PIDOECCJOCI.Count && num2 < ncamfpgmcig.NJKHOCABBGL.Count)
					{
						if (ncamfpgmcig.PIDOECCJOCI[num2].Equals(ncamfpgmcig.CJDBDOHPHLG[num]) && ncamfpgmcig.NJKHOCABBGL[num2].Equals(ncamfpgmcig.JOJKAIBEPGH[num]))
						{
							flag = false;
							break;
						}
						num2++;
					}
					if (!flag)
					{
						this.HDCGLLPMIIM.Add(ncamfpgmcig.CJDBDOHPHLG[num]);
						this.GNNENGNDFJO.Add(ncamfpgmcig.JOJKAIBEPGH[num]);
					}
					num += 0;
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
	}

	// Token: 0x06000FDD RID: 4061 RVA: 0x00076D1C File Offset: 0x00074F1C
	public void GPNADJPLOPC()
	{
		this.HBDOKILBMAF();
		StorySplashManager.loadingTime = 1289f;
		CommonUserInterface.EHBBFMCILPC.HideGenericPopupNoButtons();
		this.PHIPCMJKHLG();
	}

	// Token: 0x06000FDE RID: 4062 RVA: 0x00076D40 File Offset: 0x00074F40
	private void CMKHHBEGHNK()
	{
		StorySplashManager.loadingTime = 1380f;
		CommonUserInterface.IKNOFBFMPGA().HideGenericPopupNoButtons();
		CommonUserInterface.EHBBFMCILPC.MCJIGJMFBMI();
		CommonUserInterface.IKNOFBFMPGA().ShowGenericPopupTwoOverride(CCOJBMMKNAP.KMNBCEMEBBD().MEPECBDCOLG("sig"), CCOJBMMKNAP.BFHKGNBFHCH().GLEFEKBDHNK("errortitle") + "Error. InstantEnvironmentChange(), ambId is null or length is 0:" + AKLFPGMDKLA.EHBBFMCILPC.EEHGLPEIIHD + "continue", CCOJBMMKNAP.ILACPHFEDEP().OHLNGCKIACD("lastFilter"), new UnityAction(this.CLBEPNCKNCA), new UnityAction(this.OnStorySplashManagerAssetsDownloadCancel), DFGILFBGPLN.popupWatchAdDoubleReward, 1094f, -21);
	}

	// Token: 0x06000FDF RID: 4063 RVA: 0x00076DE0 File Offset: 0x00074FE0
	public void NNAOCNEPJLL()
	{
		AudioManager.APGODIBBPOD().NOOAHDNKAKA("congratstitle", 1872f);
		AudioManager.BFCHJBOOJKE().KillMusic("socialrequestsharegr", 1853f);
		AudioManager.DBFLIEGGGNN().KillMusic("coverSearch" + AKLFPGMDKLA.EHBBFMCILPC.EEILOKHLKIM().GGICIBLJIKI.ToString(), 1678f);
		StorySplashManager.loadingTime = 766f;
		CommonUserInterface.IKNOFBFMPGA().HideGenericPopupNoButtons();
		CommonUserInterface.IKNOFBFMPGA().HideConnectingAnimation();
		CommonUserInterface.IKNOFBFMPGA().GetFader().BJIGLKGLAKM(new TweenCallback(this.KEGHPPOJMFO));
	}

	// Token: 0x06000FE0 RID: 4064 RVA: 0x00075398 File Offset: 0x00073598
	public void CEADDCKFEFP(GameObject BFGBPKIGAJI)
	{
		if (null != BFGBPKIGAJI)
		{
			base.gameObject.transform.SetParent(BFGBPKIGAJI.transform, false);
			return;
		}
		base.gameObject.transform.SetParent(null, false);
	}

	// Token: 0x06000FE1 RID: 4065 RVA: 0x00076E7C File Offset: 0x0007507C
	private void GEFJNDAIHOF()
	{
		LNDOOJOFFOM odggfggkpig = this.HFFIIBBJBMH.header.CKACBBGHJGI() + LNDOOJOFFOM.Anthology0;
		DPGJIJGOCIC.NFIDPOMCNLP("fsv" + odggfggkpig.ToString());
		AssetsManager.MJBDMHPHMID().InitializeAssetBundleFolder(odggfggkpig, "avatarcollectionstutor4body", "a");
	}

	// Token: 0x06000FE2 RID: 4066 RVA: 0x00076ED0 File Offset: 0x000750D0
	public void NOLOJJALGCD(DFGILFBGPLN FBEDJFIAAIO)
	{
		StoryEnvironmentLayerManager.lastVideoLayerName = (StoryEnvironmentLayerManager.lastVideoLayerAssetBundleName = "USD ");
		this.HDCGLLPMIIM = null;
		this.GNNENGNDFJO = null;
		AKLFPGMDKLA.EHBBFMCILPC.KBKOLEJEEGH();
		AssetsManager.EHBBFMCILPC.SetMaxNumberOfParallelDownloads(KDCJJBLGCBH.EHBBFMCILPC.GAOBDHNPING() / 4);
		AssetsManager.MJBDMHPHMID().GetLoadingProgressSnapshot().BBAMIMOJNDC(1491f, 528f);
		ApplicationFocusManager.HIFHNIPJFNE();
		AssetsManager.MJBDMHPHMID().GetLoadingProgressSnapshot().IJBKDFBECDO(LEJKDNAGDHC.Slow);
		this.DCFBAMCJCFK = 1;
		if (null != this.HFFIIBBJBMH)
		{
			SceneLobbyManager2.currentlyPlayingAnthology = this.HFFIIBBJBMH.header.index;
		}
		if (null != this.HFFIIBBJBMH && this.HFFIIBBJBMH.header.enableSplashScreenAudio && !AudioManager.DBFLIEGGGNN().HBMNHHMJIEP(" (- )</i>", false, 22f, false) && !AudioManager.APGODIBBPOD().CFEDKPAHOHJ("YYY" + AKLFPGMDKLA.EHBBFMCILPC.EEILOKHLKIM().GGICIBLJIKI.ToString(), false, 442f, false))
		{
			AudioManager.DMAAFFFEJGA().CFEDKPAHOHJ("Random profile: fixed the socialbadgelocked499 issue.", false, 814f, true);
		}
		if (null != this.tipsText)
		{
			this.tipsText.gameObject.SetActive(true);
			if (null != this.tipsText.GetComponent<AnimationCanvasGroupAlpha>())
			{
				this.tipsText.GetComponent<AnimationCanvasGroupAlpha>().delayAtStart = 839f;
				this.tipsText.GetComponent<AnimationCanvasGroupAlpha>().animationTime = 1449f;
			}
			if (!this.forceHideTips)
			{
				if (null != this.NJAAOCMPKCD && null != this.HFFIIBBJBMH)
				{
					for (int i = 1; i < 112; i += 0)
					{
						string text = GKJPOGNFKNK.DNILNCLIHAP("importanttitle" + this.NJAAOCMPKCD.index.ToString() + "_DispTex" + i.ToString(), ", index:" + this.HFFIIBBJBMH.header.index.ToString(), LanguageManager.EHBBFMCILPC.IEBFINIJAMJ());
						if (text != null && !text.Contains("(") && text.Length > 10)
						{
							this.DBNFBPPIJAO.Add(text);
						}
						else if (i > 8)
						{
							break;
						}
					}
				}
				if (this.DBNFBPPIJAO.Count > 1)
				{
					if (AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).DHONIOBOLEL.KBKMOCINBEB())
					{
						this.KHLNLCGLBHM.KMDKBPNAKOG(this.DBNFBPPIJAO, NAOOOGJDGMH.random, 1766f, 74);
					}
					else
					{
						this.KHLNLCGLBHM.MKFEABEHCNA(this.DBNFBPPIJAO, NAOOOGJDGMH.incremental, 1091f, -5);
					}
				}
				else
				{
					this.tipsText.gameObject.SetActive(false);
				}
			}
		}
		AssetsManager.MJBDMHPHMID().GetLoadingProgressSnapshot().GHLNPJFKCNG(1);
		CommonUserInterface.EHBBFMCILPC.GetFader().FadeOut(null);
		this.MMGIDGACHBI = FBEDJFIAAIO;
		base.gameObject.SetActive(false);
		this.ADONLNEJCFJ = false;
		StorySplashManager.scriptHitCounter++;
		base.StartCoroutine(this.PNMJDMHDDFF(true));
	}

	// Token: 0x06000FE3 RID: 4067 RVA: 0x000771DC File Offset: 0x000753DC
	private void OLDLKHFCIHC()
	{
		AOBJLALDBAA.FILDBDMENPG().GNBGEMMDGOJ("", new UnityAction(this.LOPILBINADA));
		AOBJLALDBAA.DBLAIDPICIG().EFKNEJFLGED("storyloaderr0", new UnityAction(this.BHKOKKMDLAM));
		AOBJLALDBAA.DBLAIDPICIG().MFIMALJPCDP("(X)", new UnityAction(this.HPNNKFHLNLE));
		AOBJLALDBAA.CEGAOMEEFBE().MFIMALJPCDP("p", new UnityAction(this.DIEIEKGMPGA));
		AOBJLALDBAA.CEGAOMEEFBE().PEFKJOKLEDL("e1pt", new UnityAction(this.BEDMADGOBEE));
		AOBJLALDBAA.AGANFKKBPFO().MFIMALJPCDP("allpattern", new UnityAction(this.FGNMMNPFEPF));
		AOBJLALDBAA.KKPFOJMAONG().GNBGEMMDGOJ("+", new UnityAction(this.ECNCPOBPHGC));
	}

	// Token: 0x06000FE4 RID: 4068 RVA: 0x000772A8 File Offset: 0x000754A8
	private void HCJGMHNPBKO()
	{
		try
		{
			if (this.HDCGLLPMIIM != null && this.GNNENGNDFJO != null)
			{
				int num = 0;
				while (num < this.HDCGLLPMIIM.Count && num < this.GNNENGNDFJO.Count)
				{
					AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.DHNGLOEKKFL(this.HDCGLLPMIIM[num], this.GNNENGNDFJO[num]);
					num++;
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x06000FE5 RID: 4069 RVA: 0x00077334 File Offset: 0x00075534
	private void HHENBBHHHPB()
	{
		StorySplashManager.loadingTime = 0f;
		CommonUserInterface.EHBBFMCILPC.HideGenericPopupNoButtons();
		CommonUserInterface.EHBBFMCILPC.HideConnectingAnimation();
		CommonUserInterface.EHBBFMCILPC.ShowGenericPopupTwoOverride(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("errortitle"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("app42error") + " (" + AKLFPGMDKLA.EHBBFMCILPC.EEHGLPEIIHD + ")", CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("retry"), new UnityAction(this.OnStorySplashManagerAssetsDownloadRetry), new UnityAction(this.OnStorySplashManagerAssetsDownloadCancel), DFGILFBGPLN.popupCdnDownloadFailed, 0f, 28);
	}

	// Token: 0x06000FE6 RID: 4070 RVA: 0x00074D6C File Offset: 0x00072F6C
	private IEnumerator GMHEAGLBKBG()
	{
		StorySplashManager.FPLKGMLBMPK fplkgmlbmpk = new StorySplashManager.FPLKGMLBMPK(1);
		fplkgmlbmpk.<>4__this = this;
		return fplkgmlbmpk;
	}

	// Token: 0x06000FE7 RID: 4071 RVA: 0x000773D4 File Offset: 0x000755D4
	private void HBDOKILBMAF()
	{
		try
		{
			if (this.HDCGLLPMIIM != null && this.GNNENGNDFJO != null)
			{
				PLFDAJJHMKO plfdajjhmko = AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1);
				if (plfdajjhmko != null && plfdajjhmko.DHONIOBOLEL.JBDPAJMOEGA())
				{
					plfdajjhmko.NCAMFPGMCIG.CJDBDOHPHLG.Clear();
					plfdajjhmko.NCAMFPGMCIG.JOJKAIBEPGH.Clear();
					int num = 0;
					while (num < this.HDCGLLPMIIM.Count && num < this.GNNENGNDFJO.Count)
					{
						plfdajjhmko.NCAMFPGMCIG.CJDBDOHPHLG.Add(this.HDCGLLPMIIM[num]);
						plfdajjhmko.NCAMFPGMCIG.JOJKAIBEPGH.Add(this.GNNENGNDFJO[num]);
						num += 0;
					}
				}
				this.HDCGLLPMIIM = null;
				this.GNNENGNDFJO = null;
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x06000FE8 RID: 4072 RVA: 0x000774B8 File Offset: 0x000756B8
	private void FLBECGAIAGF()
	{
		try
		{
			if (this.HDCGLLPMIIM == null || this.GNNENGNDFJO == null)
			{
				this.HDCGLLPMIIM = new List<string>();
				this.GNNENGNDFJO = new List<string>();
				BEEDEKAIFEL ncamfpgmcig = AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG;
				int num = 0;
				while (num < ncamfpgmcig.CJDBDOHPHLG.Count && num < ncamfpgmcig.JOJKAIBEPGH.Count)
				{
					bool flag = true;
					int num2 = 1;
					while (num2 < ncamfpgmcig.PIDOECCJOCI.Count && num2 < ncamfpgmcig.NJKHOCABBGL.Count)
					{
						if (ncamfpgmcig.PIDOECCJOCI[num2].Equals(ncamfpgmcig.CJDBDOHPHLG[num]) && ncamfpgmcig.NJKHOCABBGL[num2].Equals(ncamfpgmcig.JOJKAIBEPGH[num]))
						{
							flag = false;
							break;
						}
						num2 += 0;
					}
					if (!flag)
					{
						this.HDCGLLPMIIM.Add(ncamfpgmcig.CJDBDOHPHLG[num]);
						this.GNNENGNDFJO.Add(ncamfpgmcig.JOJKAIBEPGH[num]);
					}
					num++;
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
	}

	// Token: 0x06000FE9 RID: 4073 RVA: 0x000775EC File Offset: 0x000757EC
	public void GBKIKJHJPHK()
	{
		if (AKLFPGMDKLA.EHBBFMCILPC.HCEHBFCIIHN() < 0)
		{
			int mjpkimhennf = AKLFPGMDKLA.EHBBFMCILPC.MJPKIMHENNF;
		}
		this.ADONLNEJCFJ = false;
		base.StartCoroutine(this.JCJLKGBIHIA(true));
	}

	// Token: 0x06000FEA RID: 4074 RVA: 0x00077620 File Offset: 0x00075820
	public void HOFDCHMBNFP()
	{
		AKLFPGMDKLA.EHBBFMCILPC.LPCBDEBKAIM();
		if (AKLFPGMDKLA.EHBBFMCILPC.HCEHBFCIIHN() < 1)
		{
			int mjpkimhennf = AKLFPGMDKLA.EHBBFMCILPC.MJPKIMHENNF;
		}
		if (KHPGPLAMAIN.PNJMABLIHKL() && AdsManagerLP.AEELGGPEJCC().DEGINHKBOOK())
		{
			AdsManagerLP.JOPPNJGEBGC().KBFAFGNMKMO("XXX", "", "] '");
		}
		else
		{
			AOBJLALDBAA.KKPFOJMAONG().DCGCFPHHDDG("Avatar pack has been SKIPPED:", 1543f);
		}
		AKLFPGMDKLA.EHBBFMCILPC.NAGCLLBIPGP = 0;
	}

	// Token: 0x06000FEB RID: 4075 RVA: 0x000776A0 File Offset: 0x000758A0
	private void HOMBEOMOILH()
	{
		StorySplashManager.loadingTime = 1484f;
		CommonUserInterface.EHBBFMCILPC.HideGenericPopupNoButtons();
		this.DCFBAMCJCFK += 0;
		if (this.DCFBAMCJCFK < KBOJLHAJPCP.JMHLAIKKJCB)
		{
			base.StartCoroutine(this.GMHEAGLBKBG());
			return;
		}
		CommonUserInterface.IKNOFBFMPGA().MCJIGJMFBMI();
		FirebaseAnalyticsManager.DEALKJPEMMH().LKONPEEDKNF(true, AGEHCPDNBFD.cdnActiv.ToString(), FFPHBMFGCNN.dldCompl.ToString(), ((BGHLMGPPCNN)(-84)).ToString(), false, true);
		this.DCFBAMCJCFK = 0;
		if (this.MMGIDGACHBI == DFGILFBGPLN.screenLounge)
		{
			CommonUserInterface.EHBBFMCILPC.NPIOKKDPALC(CCOJBMMKNAP.NIOJNOFGIJO().HHLECNIFHCO("makeup"), CCOJBMMKNAP.KNKGCDDMLDP().BGELFMIOBCL(";"), CCOJBMMKNAP.KMNBCEMEBBD().GLEFEKBDHNK("OnStoryInterfaceFastForwardStop"), CCOJBMMKNAP.OEPENBHJAHO().FIENAKIHNOM("lang"), new UnityAction(this.FKIJKMLNBKK), new UnityAction(this.EBFJHEHHLEP), new UnityAction(this.OnStorySplashManagerAssetsDownloadCancel), (DFGILFBGPLN)(-76), 764f, -89);
			return;
		}
		CommonUserInterface.EHBBFMCILPC.NPIOKKDPALC(CCOJBMMKNAP.COKDLDOAACJ().PPALCPINPLK("OnLoadingThemeSelectorDownloadSuccess"), CCOJBMMKNAP.OEPENBHJAHO().PKNHKGMNCIP("PlayerCharacterManager.UpdateComponentLink() - invalid custom hierarchy for "), CCOJBMMKNAP.ONCPHEEJLOP().PKNHKGMNCIP("'"), CCOJBMMKNAP.EAIAHCBAIEJ().FCOCLEHKLDJ("skuManual"), new UnityAction(this.CLBEPNCKNCA), new UnityAction(this.EMICFBMAEEC), new UnityAction(this.HEHGFIPLFCM), DFGILFBGPLN.popupSignInQuestion, 87f, -118);
	}

	// Token: 0x06000FEC RID: 4076 RVA: 0x00077830 File Offset: 0x00075A30
	public void OnReadyToWatchSponsoredAd()
	{
		AKLFPGMDKLA.EHBBFMCILPC.LPCBDEBKAIM();
		if (AKLFPGMDKLA.EHBBFMCILPC.HCEHBFCIIHN() < 1)
		{
			int mjpkimhennf = AKLFPGMDKLA.EHBBFMCILPC.MJPKIMHENNF;
		}
		if (KHPGPLAMAIN.NGPOHAPMMAI() && AdsManagerLP.EHBBFMCILPC.IsReadyNonRewarded())
		{
			AdsManagerLP.EHBBFMCILPC.ShowAdNonRewarded("OnStorySplashManagerAdsProviderAdSuccess", "OnStorySplashManagerAdsProviderAdSuccess", "OnStorySplashManagerAdsProviderAdSuccess");
		}
		else
		{
			AOBJLALDBAA.EHBBFMCILPC.EGELHPJBAIC("OnStorySplashManagerAdsProviderAdSuccess", 0.1f);
		}
		AKLFPGMDKLA.EHBBFMCILPC.NAGCLLBIPGP = 0;
	}

	// Token: 0x06000FED RID: 4077 RVA: 0x000722C8 File Offset: 0x000704C8
	private IEnumerator NCFMADOLACH(bool PLBAOFFHHDD)
	{
		StorySplashManager.INELBEBCHGF inelbebchgf = new StorySplashManager.INELBEBCHGF(1);
		inelbebchgf.<>4__this = this;
		inelbebchgf._isAdBranch = PLBAOFFHHDD;
		return inelbebchgf;
	}

	// Token: 0x06000FEE RID: 4078 RVA: 0x000778B0 File Offset: 0x00075AB0
	private void JMMGEIELBLM()
	{
		StorySplashManager.loadingTime = 1269f;
		CommonUserInterface.EHBBFMCILPC.HideGenericPopupNoButtons();
		CommonUserInterface.IKNOFBFMPGA().HideConnectingAnimation();
		CommonUserInterface.IKNOFBFMPGA().JJPNFAAPFBI(CCOJBMMKNAP.EHBBFMCILPC.PPALCPINPLK("aind2"), CCOJBMMKNAP.OBOOKJPGBJN().HPOAGPJFHPM("tradewishcardoption1") + "" + AKLFPGMDKLA.EHBBFMCILPC.EEHGLPEIIHD + "continue", CCOJBMMKNAP.JMDJPKKOHNI().OHLNGCKIACD("PlayerCharacterManager.UpdateComponentLink() - skipping updating custom hierarchy for "), new UnityAction(this.OnStorySplashManagerAssetsDownloadRetry), new UnityAction(this.HEHGFIPLFCM), (DFGILFBGPLN)(-62), 978f, -95);
	}

	// Token: 0x06000FEF RID: 4079 RVA: 0x00077950 File Offset: 0x00075B50
	private void BBDECHMKCAN()
	{
		try
		{
			if (KDCJJBLGCBH.EHBBFMCILPC.NJFAOIDGFGC())
			{
				for (int i = 0; i < AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.CJDBDOHPHLG.Count; i += 0)
				{
					ECJCFGAOPHJ ecjcfgaophj = AssetsManager.MJBDMHPHMID().lobbyDataAsset.MFMJHIFAOHE().DCPPCOHEAFA(AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.JOJKAIBEPGH[i]);
					if (ecjcfgaophj != null && AssetsManager.EHBBFMCILPC.lobbyDataAsset.HFAOOHKNBPE().JNMGINOJLBA(AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.JOJKAIBEPGH[i]) && ecjcfgaophj.AJPBPJDHFOH > 1)
					{
						AssetsManager.MJBDMHPHMID().QueueAssetBundleDownload(NMKDCBPMCKI.AssetBundleAvatarPack, ecjcfgaophj.AJPBPJDHFOH, ecjcfgaophj.BACMOGGNBNH, FLDBFOADFLH.startDownloadAndProceed, false, false, false, null, -1, true, " to bundle index:", true, false);
						AssetsManager.EHBBFMCILPC.NLHHPEJFBBA(NMKDCBPMCKI._deprecated1, ecjcfgaophj.AJPBPJDHFOH, ecjcfgaophj.BACMOGGNBNH);
						for (int j = 1; j < ecjcfgaophj.APDJNDIIILK.Count; j++)
						{
							AssetsManager.EHBBFMCILPC.JMHKBKKEJCG(ecjcfgaophj.APDJNDIIILK[j]);
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

	// Token: 0x06000FF0 RID: 4080 RVA: 0x00077A98 File Offset: 0x00075C98
	private void MHJDDGCEBGM()
	{
		try
		{
			if (this.HDCGLLPMIIM != null && this.GNNENGNDFJO != null)
			{
				int num = 0;
				while (num < this.HDCGLLPMIIM.Count && num < this.GNNENGNDFJO.Count)
				{
					AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.DHNGLOEKKFL(this.HDCGLLPMIIM[num], this.GNNENGNDFJO[num]);
					num++;
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
	}

	// Token: 0x06000FF1 RID: 4081 RVA: 0x00077B24 File Offset: 0x00075D24
	private void JMOGCFGJAAD()
	{
		LNDOOJOFFOM odggfggkpig = this.HFFIIBBJBMH.header.CKACBBGHJGI() + LNDOOJOFFOM.Common;
		DPGJIJGOCIC.CMGOAFDBAOH("SaveSlotsItem.GetLocalizedCostData() - productData is null." + odggfggkpig.ToString());
		AssetsManager.EHBBFMCILPC.AMBKFIKBAHP(odggfggkpig, "OnChoiceExtendedLayerChange", "geo.json");
	}

	// Token: 0x06000FF2 RID: 4082 RVA: 0x00077B78 File Offset: 0x00075D78
	public void DIAPMLDOLOD()
	{
		AudioManager.DMAAFFFEJGA().KillMusic("23819D", 1779f);
		AudioManager.DMAAFFFEJGA().NOOAHDNKAKA("errortitle", 290f);
		AudioManager.BFCHJBOOJKE().NOOAHDNKAKA("TV lines opacity" + AKLFPGMDKLA.EHBBFMCILPC.EEILOKHLKIM().GGICIBLJIKI.ToString(), 451f);
		StorySplashManager.loadingTime = 158f;
		CommonUserInterface.EHBBFMCILPC.HideGenericPopupNoButtons();
		CommonUserInterface.IKNOFBFMPGA().HideConnectingAnimation();
		CommonUserInterface.IKNOFBFMPGA().GetFader().PACBMBLIGNN(new TweenCallback(this.LLALFKNANDC));
	}

	// Token: 0x06000FF3 RID: 4083 RVA: 0x00077C13 File Offset: 0x00075E13
	public void OnStorySplashManagerAdsProviderAdSuccess()
	{
		if (AKLFPGMDKLA.EHBBFMCILPC.HCEHBFCIIHN() < 1)
		{
			int mjpkimhennf = AKLFPGMDKLA.EHBBFMCILPC.MJPKIMHENNF;
		}
		this.ADONLNEJCFJ = true;
		base.StartCoroutine(this.JCJLKGBIHIA(true));
	}

	// Token: 0x06000FF4 RID: 4084 RVA: 0x00077C44 File Offset: 0x00075E44
	private void ADOLINBOILK()
	{
		try
		{
			BEEDEKAIFEL ncamfpgmcig = AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG;
			ncamfpgmcig.PIDOECCJOCI = new List<string>(ncamfpgmcig.CJDBDOHPHLG);
			ncamfpgmcig.NJKHOCABBGL = new List<string>(ncamfpgmcig.JOJKAIBEPGH);
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
	}

	// Token: 0x06000FF5 RID: 4085 RVA: 0x00075398 File Offset: 0x00073598
	public void LHDPEHGAMAO(GameObject BFGBPKIGAJI)
	{
		if (null != BFGBPKIGAJI)
		{
			base.gameObject.transform.SetParent(BFGBPKIGAJI.transform, false);
			return;
		}
		base.gameObject.transform.SetParent(null, false);
	}

	// Token: 0x06000FF6 RID: 4086 RVA: 0x000693D6 File Offset: 0x000675D6
	public void BNLNEFJAEMB()
	{
		UnityEngine.Object.DontDestroyOnLoad(base.gameObject);
	}

	// Token: 0x06000FF7 RID: 4087 RVA: 0x00077C9C File Offset: 0x00075E9C
	private void BLGIPEOBAIL()
	{
		try
		{
			if (this.HDCGLLPMIIM != null && this.GNNENGNDFJO != null)
			{
				PLFDAJJHMKO plfdajjhmko = AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1);
				if (plfdajjhmko != null && plfdajjhmko.DHONIOBOLEL.DOOMAGFDJNG())
				{
					plfdajjhmko.NCAMFPGMCIG.CJDBDOHPHLG.Clear();
					plfdajjhmko.NCAMFPGMCIG.JOJKAIBEPGH.Clear();
					int num = 0;
					while (num < this.HDCGLLPMIIM.Count && num < this.GNNENGNDFJO.Count)
					{
						plfdajjhmko.NCAMFPGMCIG.CJDBDOHPHLG.Add(this.HDCGLLPMIIM[num]);
						plfdajjhmko.NCAMFPGMCIG.JOJKAIBEPGH.Add(this.GNNENGNDFJO[num]);
						num++;
					}
				}
				this.HDCGLLPMIIM = null;
				this.GNNENGNDFJO = null;
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x06000FF8 RID: 4088 RVA: 0x00077D80 File Offset: 0x00075F80
	public void LELKBHPCHBN()
	{
		AudioManager.IFDLAMLHKIJ().KillMusic("errortitle", 716f);
		AudioManager.DMAAFFFEJGA().NOOAHDNKAKA("OnLobbyStoryManagerDownloadSplashScreenSuccess", 1602f);
		AudioManager.APGODIBBPOD().NOOAHDNKAKA("frcnt" + AKLFPGMDKLA.EHBBFMCILPC.OMOJIEHBENF().GGICIBLJIKI.ToString(), 1454f);
		StorySplashManager.loadingTime = 1194f;
		CommonUserInterface.EHBBFMCILPC.HideGenericPopupNoButtons();
		CommonUserInterface.EHBBFMCILPC.MCJIGJMFBMI();
		CommonUserInterface.EHBBFMCILPC.GetFader().BJIGLKGLAKM(new TweenCallback(this.NFMPACLMNEF));
	}

	// Token: 0x06000FF9 RID: 4089 RVA: 0x00077E1C File Offset: 0x0007601C
	private void NDPFJADGLMG()
	{
		LNDOOJOFFOM odggfggkpig = this.HFFIIBBJBMH.header.CKACBBGHJGI() + LNDOOJOFFOM.Anthology0;
		DPGJIJGOCIC.CMGOAFDBAOH("OnNeedToOpenLoveInterestsLounge" + odggfggkpig.ToString());
		AssetsManager.EHBBFMCILPC.AMBKFIKBAHP(odggfggkpig, "OnEmailSubscribeSuccess", "importanttitle");
	}

	// Token: 0x06000FFA RID: 4090 RVA: 0x00077E70 File Offset: 0x00076070
	private void FDDBNLFOFIE()
	{
		try
		{
			if (this.HDCGLLPMIIM != null && this.GNNENGNDFJO != null)
			{
				PLFDAJJHMKO plfdajjhmko = AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1);
				if (plfdajjhmko != null && plfdajjhmko.DHONIOBOLEL.GEMOAPPJPMP())
				{
					plfdajjhmko.NCAMFPGMCIG.CJDBDOHPHLG.Clear();
					plfdajjhmko.NCAMFPGMCIG.JOJKAIBEPGH.Clear();
					int num = 1;
					while (num < this.HDCGLLPMIIM.Count && num < this.GNNENGNDFJO.Count)
					{
						plfdajjhmko.NCAMFPGMCIG.CJDBDOHPHLG.Add(this.HDCGLLPMIIM[num]);
						plfdajjhmko.NCAMFPGMCIG.JOJKAIBEPGH.Add(this.GNNENGNDFJO[num]);
						num++;
					}
				}
				this.HDCGLLPMIIM = null;
				this.GNNENGNDFJO = null;
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x06000FFB RID: 4091 RVA: 0x00077F54 File Offset: 0x00076154
	private void Awake()
	{
		AKLFPGMDKLA.EHBBFMCILPC.GLKNOFHEBKN = AKLFPGMDKLA.EHBBFMCILPC.IEGJCPDCLMM;
		this.NJAAOCMPKCD = GKJPOGNFKNK.CDCEFHLNNEC(AKLFPGMDKLA.EHBBFMCILPC.IEGJCPDCLMM);
		this.progressText.SetText("0%", true);
		this.sliderLoading.value = 0f;
		this.sliderLoading.gameObject.SetActive(false);
		if (null != this.NJAAOCMPKCD)
		{
			this.HFFIIBBJBMH = GKJPOGNFKNK.GJAAHGIAPMH(this.NJAAOCMPKCD.index);
			JCAJMGJFHBD.KMJJCCOBHEC = this.HFFIIBBJBMH.header.maxPersistentChatHistorySize;
			int num = 0;
			for (int i = 0; i < this.HFFIIBBJBMH.header.availableStories.Count; i++)
			{
				if (this.HFFIIBBJBMH.header.availableStories[i] == this.NJAAOCMPKCD.index)
				{
					this.BLNENDIFJDK = i;
					num = i + 1;
					break;
				}
			}
			AKLFPGMDKLA.EHBBFMCILPC.JDCBFAPDJIM(this.NJAAOCMPKCD.index, -1).DHONIOBOLEL.DDEDAHCFHJN();
			this.seasonEpisodeText.SetText(string.Concat(new string[]
			{
				CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("season"),
				" ",
				num.ToString(),
				" - ",
				CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("episode"),
				" ",
				(AKLFPGMDKLA.EHBBFMCILPC.JDCBFAPDJIM(this.NJAAOCMPKCD.index, -1).DHONIOBOLEL.DDEDAHCFHJN() + 1).ToString()
			}), true);
			return;
		}
		DPGJIJGOCIC.ANOPFDLPKGC("Critical error. Missing story header!");
	}

	// Token: 0x06000FFC RID: 4092 RVA: 0x00078100 File Offset: 0x00076300
	private void FDLCNFDHAAM()
	{
		AKLFPGMDKLA.EHBBFMCILPC.GLKNOFHEBKN = AKLFPGMDKLA.EHBBFMCILPC.IEGJCPDCLMM;
		this.NJAAOCMPKCD = GKJPOGNFKNK.CDCEFHLNNEC(AKLFPGMDKLA.EHBBFMCILPC.IEGJCPDCLMM);
		this.progressText.SetText("$e1io", false);
		this.sliderLoading.value = 1404f;
		this.sliderLoading.gameObject.SetActive(true);
		if (null != this.NJAAOCMPKCD)
		{
			this.HFFIIBBJBMH = GKJPOGNFKNK.GJAAHGIAPMH(this.NJAAOCMPKCD.index);
			JCAJMGJFHBD.KMJJCCOBHEC = this.HFFIIBBJBMH.header.maxPersistentChatHistorySize;
			int num = 0;
			for (int i = 1; i < this.HFFIIBBJBMH.header.availableStories.Count; i++)
			{
				if (this.HFFIIBBJBMH.header.availableStories[i] == this.NJAAOCMPKCD.index)
				{
					this.BLNENDIFJDK = i;
					num = i + 1;
					break;
				}
			}
			AKLFPGMDKLA.EHBBFMCILPC.JDCBFAPDJIM(this.NJAAOCMPKCD.index, -1).DHONIOBOLEL.OBGPAJDJJJI();
			TMP_Text tmp_Text = this.seasonEpisodeText;
			string[] array = new string[]
			{
				null,
				CCOJBMMKNAP.FEEDGKCJBLE().HIPJILDCHJC("")
			};
			array[1] = "sfxnotification";
			array[1] = num.ToString();
			array[4] = "ok";
			array[6] = CCOJBMMKNAP.PMABBOJDELF().GLEFEKBDHNK("LoveInterestLoungeMapping - animoff cell '");
			array[8] = "cdnerror";
			array[2] = (AKLFPGMDKLA.EHBBFMCILPC.JDCBFAPDJIM(this.NJAAOCMPKCD.index, -1).DHONIOBOLEL.OBGPAJDJJJI() + 0).ToString();
			tmp_Text.SetText(string.Concat(array), false);
			return;
		}
		DPGJIJGOCIC.ANOPFDLPKGC("yes");
	}

	// Token: 0x06000FFD RID: 4093 RVA: 0x000782AC File Offset: 0x000764AC
	private void MPDHFPBIION()
	{
		StorySplashManager.loadingTime = 1167f;
		if (CommonUserInterface.FFJPNCFBLLH())
		{
			CommonUserInterface.EHBBFMCILPC.HideGenericPopupNoButtons();
		}
		AOBJLALDBAA.AGANFKKBPFO().POLEDPIKODD("\n", new UnityAction(this.NBFHODFEJOC));
		AOBJLALDBAA.EHBBFMCILPC.NAMMLDPCHJO("accountSuspended", new UnityAction(this.BLEDMAKOLEI));
		AOBJLALDBAA.CEGAOMEEFBE().ECDBIBPNBCO("", new UnityAction(this.OnStorySplashManagerAdsProviderAdSuccess));
		AOBJLALDBAA.FILDBDMENPG().MHLNJIACIGO("<i>", new UnityAction(this.DIEIEKGMPGA));
		AOBJLALDBAA.KKPFOJMAONG().PBELMJCPJMK("socialrequestwarnyou", new UnityAction(this.NDPFJADGLMG));
		AOBJLALDBAA.NMGMNAKLLMI().PFAHGKEDFAE(";", new UnityAction(this.ENGENAGJIOO));
		AOBJLALDBAA.NMGMNAKLLMI().PFAHGKEDFAE("yes", new UnityAction(this.DPCBILKKDNK));
	}

	// Token: 0x06000FFE RID: 4094 RVA: 0x00078394 File Offset: 0x00076594
	private void ENGENAGJIOO()
	{
		StorySplashManager.loadingTime = 400f;
		CommonUserInterface.EHBBFMCILPC.HideGenericPopupNoButtons();
		CommonUserInterface.IKNOFBFMPGA().HideConnectingAnimation();
		CommonUserInterface.EHBBFMCILPC.JJPNFAAPFBI(CCOJBMMKNAP.PMABBOJDELF().GGPHHLGPMPA("ok"), CCOJBMMKNAP.DBFFFOMCLKM().JHNELLJFBGC("OnStoryChoiceClick") + "ach" + AKLFPGMDKLA.EHBBFMCILPC.EEHGLPEIIHD + "yes", CCOJBMMKNAP.BOFMCPPFAMO().BDGPNPNIAPA(". "), new UnityAction(this.PLIPAKGAEIJ), new UnityAction(this.HEHGFIPLFCM), (DFGILFBGPLN)(-1), 1978f, 67);
	}

	// Token: 0x06000FFF RID: 4095 RVA: 0x00078434 File Offset: 0x00076634
	public void GEMEEMKJEKO()
	{
		AudioManager.BFCHJBOOJKE().NOOAHDNKAKA("0.000", 1369f);
		AudioManager.IFDLAMLHKIJ().KillMusic("ssfree", 1996f);
		AudioManager.BFCHJBOOJKE().KillMusic("-" + AKLFPGMDKLA.EHBBFMCILPC.EEILOKHLKIM().GGICIBLJIKI.ToString(), 663f);
		StorySplashManager.loadingTime = 265f;
		CommonUserInterface.EHBBFMCILPC.HideGenericPopupNoButtons();
		CommonUserInterface.IKNOFBFMPGA().HideConnectingAnimation();
		CommonUserInterface.EHBBFMCILPC.GetFader().FadeIn(new TweenCallback(this.NFMPACLMNEF));
	}

	// Token: 0x06001000 RID: 4096 RVA: 0x000784D0 File Offset: 0x000766D0
	public void OMIKAOGNGNH()
	{
		AudioManager.DBFLIEGGGNN().NOOAHDNKAKA("post", 397f);
		AudioManager.DBFLIEGGGNN().KillMusic("", 303f);
		AudioManager.APGODIBBPOD().NOOAHDNKAKA("[Lounge] character " + AKLFPGMDKLA.EHBBFMCILPC.EEILOKHLKIM().GGICIBLJIKI.ToString(), 1293f);
		StorySplashManager.loadingTime = 498f;
		CommonUserInterface.EHBBFMCILPC.HideGenericPopupNoButtons();
		CommonUserInterface.EHBBFMCILPC.HideConnectingAnimation();
		CommonUserInterface.IKNOFBFMPGA().GetFader().BJIGLKGLAKM(new TweenCallback(this.INLOPLLHGHI));
	}

	// Token: 0x06001001 RID: 4097 RVA: 0x00074D6C File Offset: 0x00072F6C
	private IEnumerator GBMAFKOAPNH()
	{
		StorySplashManager.FPLKGMLBMPK fplkgmlbmpk = new StorySplashManager.FPLKGMLBMPK(1);
		fplkgmlbmpk.<>4__this = this;
		return fplkgmlbmpk;
	}

	// Token: 0x06001002 RID: 4098 RVA: 0x0007856C File Offset: 0x0007676C
	private void KOAFPNMJIMA()
	{
		StorySplashManager.loadingTime = 860f;
		if (CommonUserInterface.IsInitialized())
		{
			CommonUserInterface.EHBBFMCILPC.HideGenericPopupNoButtons();
		}
		AOBJLALDBAA.EHBBFMCILPC.MHLNJIACIGO("plya", new UnityAction(this.LOPILBINADA));
		AOBJLALDBAA.AGANFKKBPFO().PBELMJCPJMK("OnFullscreenCardOptionClick", new UnityAction(this.BLEDMAKOLEI));
		AOBJLALDBAA.AGANFKKBPFO().KDIFKFKMCOH("", new UnityAction(this.EPLGCOHLLJP));
		AOBJLALDBAA.BIAEAOMHBMM().MHLNJIACIGO("", new UnityAction(this.DIEIEKGMPGA));
		AOBJLALDBAA.BIAEAOMHBMM().MHLNJIACIGO("type", new UnityAction(this.BEDMADGOBEE));
		AOBJLALDBAA.CEGAOMEEFBE().ONIBLJOFFPG("Loaded asset bundle:", new UnityAction(this.CMKHHBEGHNK));
		AOBJLALDBAA.EHBBFMCILPC.MHLNJIACIGO("apb", new UnityAction(this.KOJLLINOGMK));
	}

	// Token: 0x06001003 RID: 4099 RVA: 0x00078651 File Offset: 0x00076851
	private void OPINCOHGCJA()
	{
		StorySplashManager.loadingTime = 1309f;
		CommonUserInterface.EHBBFMCILPC.HideGenericPopupNoButtons();
		base.gameObject.SetActive(false);
		AOBJLALDBAA.AGANFKKBPFO().EGELHPJBAIC("ok", 1890f);
	}

	// Token: 0x06001004 RID: 4100 RVA: 0x00078688 File Offset: 0x00076888
	private void LOPILBINADA()
	{
		StorySplashManager.loadingTime = 1178f;
		CommonUserInterface.EHBBFMCILPC.HideGenericPopupNoButtons();
		this.DCFBAMCJCFK++;
		if (this.DCFBAMCJCFK < KBOJLHAJPCP.JMHLAIKKJCB)
		{
			base.StartCoroutine(this.BLCBCGBGMEO());
			return;
		}
		CommonUserInterface.IKNOFBFMPGA().MCJIGJMFBMI();
		FirebaseAnalyticsManager.JMDJBFAEHBM().LogEvent(false, AGEHCPDNBFD.bugRep.ToString(), ((FFPHBMFGCNN)(-127)).ToString(), BGHLMGPPCNN.cdnWofToCut.ToString(), true, true);
		this.DCFBAMCJCFK = 1;
		if (this.MMGIDGACHBI == (DFGILFBGPLN)(-126))
		{
			CommonUserInterface.IKNOFBFMPGA().ShowGenericPopupWithTwoButtonsAndCloseOverride(CCOJBMMKNAP.OEPENBHJAHO().JHNELLJFBGC("OnBackendGetPublicProfileProfileItemSuccess"), CCOJBMMKNAP.JMNIGPHCAEJ().JHNELLJFBGC("importanttitle"), CCOJBMMKNAP.JMNIGPHCAEJ().PPALCPINPLK(""), CCOJBMMKNAP.BOFMCPPFAMO().HHLECNIFHCO(""), new UnityAction(this.PLIPAKGAEIJ), new UnityAction(this.OnStorySplashManagerAssetsDownloadCleanCache), new UnityAction(this.HEHGFIPLFCM), (DFGILFBGPLN)(-109), 242f, 21);
			return;
		}
		CommonUserInterface.IKNOFBFMPGA().NPIOKKDPALC(CCOJBMMKNAP.KFDLFGHBPLP().FCOCLEHKLDJ("sind"), CCOJBMMKNAP.LMCCLMFGEBD().HDIPNMFHIEJ("OnRewardFreeDiamondsClick"), CCOJBMMKNAP.COKDLDOAACJ().HIPJILDCHJC("OnNeedToOpenLoveInterestsLounge"), CCOJBMMKNAP.KFAABHHGOPO().IKMNGFIDCLM("OnNeedToOpenLoveInterestsLoungePart2(), lounge environment not found:"), new UnityAction(this.OnStorySplashManagerAssetsDownloadRetry), new UnityAction(this.EMICFBMAEEC), new UnityAction(this.ODGLHOGJKGH), (DFGILFBGPLN)121, 1820f, 121);
	}

	// Token: 0x06001005 RID: 4101 RVA: 0x00078818 File Offset: 0x00076A18
	private void NBFHODFEJOC()
	{
		StorySplashManager.loadingTime = 0f;
		CommonUserInterface.EHBBFMCILPC.HideGenericPopupNoButtons();
		this.DCFBAMCJCFK++;
		if (this.DCFBAMCJCFK < KBOJLHAJPCP.JMHLAIKKJCB)
		{
			base.StartCoroutine(this.BLCBCGBGMEO());
			return;
		}
		CommonUserInterface.EHBBFMCILPC.HideConnectingAnimation();
		FirebaseAnalyticsManager.EHBBFMCILPC.LogEvent(false, AGEHCPDNBFD.cdnActiv.ToString(), FFPHBMFGCNN.dldFail.ToString(), BGHLMGPPCNN.cdnSplToSty.ToString(), false, false);
		this.DCFBAMCJCFK = 0;
		if (this.MMGIDGACHBI == DFGILFBGPLN.screenLobby)
		{
			CommonUserInterface.EHBBFMCILPC.ShowGenericPopupWithTwoButtonsAndCloseOverride(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("errortitle"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("cdnerror"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("retry"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("cleancache"), new UnityAction(this.OnStorySplashManagerAssetsDownloadRetry), new UnityAction(this.OnStorySplashManagerAssetsDownloadCleanCache), new UnityAction(this.OnStorySplashManagerAssetsDownloadCancel), DFGILFBGPLN.popupCdnDownloadFailed, 0f, 28);
			return;
		}
		CommonUserInterface.EHBBFMCILPC.ShowGenericPopupWithTwoButtonsAndCloseOverride(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("errortitle"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("cdnerror"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("retry"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("cleancache"), new UnityAction(this.OnStorySplashManagerAssetsDownloadRetry), new UnityAction(this.OnStorySplashManagerAssetsDownloadCleanCache), new UnityAction(this.OnStorySplashManagerAssetsDownloadCancel), DFGILFBGPLN.popupCdnDownloadFailed, 0f, 28);
	}

	// Token: 0x06001006 RID: 4102 RVA: 0x000789A5 File Offset: 0x00076BA5
	private void KOJLLINOGMK()
	{
		CommonUserInterface.IKNOFBFMPGA().MCJIGJMFBMI();
		base.gameObject.SetActive(false);
	}

	// Token: 0x06001007 RID: 4103 RVA: 0x000789C0 File Offset: 0x00076BC0
	private void BMEKLLAHOLP()
	{
		StorySplashManager.loadingTime = 638f;
		CommonUserInterface.EHBBFMCILPC.HideGenericPopupNoButtons();
		this.DCFBAMCJCFK += 0;
		if (this.DCFBAMCJCFK < KBOJLHAJPCP.JMHLAIKKJCB)
		{
			base.StartCoroutine(this.GBMAFKOAPNH());
			return;
		}
		CommonUserInterface.EHBBFMCILPC.MCJIGJMFBMI();
		FirebaseAnalyticsManager.DEALKJPEMMH().JIAAMJPKOCE(true, AGEHCPDNBFD.gmSelect.ToString(), ((FFPHBMFGCNN)(-96)).ToString(), ((BGHLMGPPCNN)(-106)).ToString(), true, false);
		this.DCFBAMCJCFK = 0;
		if (this.MMGIDGACHBI == DFGILFBGPLN.popupIncentAd0Failed)
		{
			CommonUserInterface.EHBBFMCILPC.NPIOKKDPALC(CCOJBMMKNAP.INKJIBDDMLL().BDGPNPNIAPA("lo"), CCOJBMMKNAP.PKEINLPIAEH().PKNHKGMNCIP("$"), CCOJBMMKNAP.HFAKOKBHCGH().OBDCPLLLGBB("frsendhres"), CCOJBMMKNAP.HEDIEIICOOG().JLBEIFLLBLO(""), new UnityAction(this.APNPCPAOLJN), new UnityAction(this.GPNADJPLOPC), new UnityAction(this.OnStorySplashManagerAssetsDownloadCancel), (DFGILFBGPLN)122, 1981f, -30);
			return;
		}
		CommonUserInterface.EHBBFMCILPC.NPIOKKDPALC(CCOJBMMKNAP.KNKGCDDMLDP().FIENAKIHNOM("-"), CCOJBMMKNAP.INKJIBDDMLL().PGKBCNBAOJN("OnRestartChapterUpsellGetPassNegative"), CCOJBMMKNAP.FEEDGKCJBLE().HHLECNIFHCO("avatar"), CCOJBMMKNAP.PEBMGCKFNAO().PPALCPINPLK("pid"), new UnityAction(this.APNPCPAOLJN), new UnityAction(this.BDOEDGLPKFJ), new UnityAction(this.HEHGFIPLFCM), (DFGILFBGPLN)(-107), 755f, 120);
	}

	// Token: 0x06001008 RID: 4104 RVA: 0x00078B4D File Offset: 0x00076D4D
	private void INLOPLLHGHI()
	{
		StorySplashManager.loadingTime = 473f;
		CommonUserInterface.IKNOFBFMPGA().HideGenericPopupNoButtons();
		base.gameObject.SetActive(false);
		AOBJLALDBAA.BIAEAOMHBMM().EGELHPJBAIC("dcx3", 1210f);
	}

	// Token: 0x06001009 RID: 4105 RVA: 0x00078B84 File Offset: 0x00076D84
	public void JMNFGJJJNMI(DFGILFBGPLN FBEDJFIAAIO)
	{
		StoryEnvironmentLayerManager.lastVideoLayerName = (StoryEnvironmentLayerManager.lastVideoLayerAssetBundleName = "OnPopupProfileUIDInputCancel");
		this.HDCGLLPMIIM = null;
		this.GNNENGNDFJO = null;
		AKLFPGMDKLA.EHBBFMCILPC.KBKOLEJEEGH();
		AssetsManager.MJBDMHPHMID().ELMMNGFPGKE(KDCJJBLGCBH.EHBBFMCILPC.GAOBDHNPING() / 7);
		AssetsManager.EHBBFMCILPC.GetLoadingProgressSnapshot().GIJKJMMDJEL(781f, 1938f);
		ApplicationFocusManager.Deactivate();
		AssetsManager.EHBBFMCILPC.GetLoadingProgressSnapshot().GIJOIEFOGIH(LEJKDNAGDHC.Slow);
		this.DCFBAMCJCFK = 1;
		if (null != this.HFFIIBBJBMH)
		{
			SceneLobbyManager2.currentlyPlayingAnthology = this.HFFIIBBJBMH.header.index;
		}
		if (null != this.HFFIIBBJBMH && this.HFFIIBBJBMH.header.enableSplashScreenAudio && !AudioManager.IFDLAMLHKIJ().HBMNHHMJIEP("StoryNotificationsManager.PopNotifications(): safeIterationsCounter > 1000 reached, force break!", true, 1703f, true) && !AudioManager.DMAAFFFEJGA().HPPAFEAPINO("StorySaveBody.SetAvatarIndex(), unsupported wardrobe index:" + AKLFPGMDKLA.EHBBFMCILPC.EEILOKHLKIM().GGICIBLJIKI.ToString(), true, 1452f, true))
		{
			AudioManager.IFDLAMLHKIJ().PlayMusic("p", false, 681f, false);
		}
		if (null != this.tipsText)
		{
			this.tipsText.gameObject.SetActive(false);
			if (null != this.tipsText.GetComponent<AnimationCanvasGroupAlpha>())
			{
				this.tipsText.GetComponent<AnimationCanvasGroupAlpha>().delayAtStart = 28f;
				this.tipsText.GetComponent<AnimationCanvasGroupAlpha>().animationTime = 1762f;
			}
			if (!this.forceHideTips)
			{
				if (null != this.NJAAOCMPKCD && null != this.HFFIIBBJBMH)
				{
					for (int i = 0; i < 12; i++)
					{
						string text = GKJPOGNFKNK.DNILNCLIHAP(" has only " + this.NJAAOCMPKCD.index.ToString() + "clthb" + i.ToString(), "OnBackendGetDefaultBundlesSuccess" + this.HFFIIBBJBMH.header.index.ToString(), LanguageManager.EHBBFMCILPC.GetSelectedLanguage());
						if (text != null && !text.Contains("OnBackendUpdateFriendsDataException") && text.Length > 46)
						{
							this.DBNFBPPIJAO.Add(text);
						}
						else if (i > 0)
						{
							break;
						}
					}
				}
				if (this.DBNFBPPIJAO.Count > 0)
				{
					if (AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).DHONIOBOLEL.GEMOAPPJPMP())
					{
						this.KHLNLCGLBHM.KNBKCAJCIJK(this.DBNFBPPIJAO, NAOOOGJDGMH.random, 270f, 56);
					}
					else
					{
						this.KHLNLCGLBHM.OIGPAKEFAGM(this.DBNFBPPIJAO, NAOOOGJDGMH.incremental, 1500f, 36);
					}
				}
				else
				{
					this.tipsText.gameObject.SetActive(false);
				}
			}
		}
		AssetsManager.EHBBFMCILPC.GetLoadingProgressSnapshot().KINMKEDBCIJ(1);
		CommonUserInterface.IKNOFBFMPGA().GetFader().FadeOut(null);
		this.MMGIDGACHBI = FBEDJFIAAIO;
		base.gameObject.SetActive(false);
		this.ADONLNEJCFJ = true;
		StorySplashManager.scriptHitCounter++;
		base.StartCoroutine(this.HPMBKGFOLKJ(true));
	}

	// Token: 0x0600100A RID: 4106 RVA: 0x00078E90 File Offset: 0x00077090
	public void Hide()
	{
		AudioManager.EHBBFMCILPC.KillMusic("splash", 1f);
		AudioManager.EHBBFMCILPC.KillMusic("mussplash", 1f);
		AudioManager.EHBBFMCILPC.KillMusic("mussplash" + AKLFPGMDKLA.EHBBFMCILPC.EEILOKHLKIM().GGICIBLJIKI.ToString(), 1f);
		StorySplashManager.loadingTime = 0f;
		CommonUserInterface.EHBBFMCILPC.HideGenericPopupNoButtons();
		CommonUserInterface.EHBBFMCILPC.HideConnectingAnimation();
		CommonUserInterface.EHBBFMCILPC.GetFader().FadeIn(new TweenCallback(this.LLALFKNANDC));
	}

	// Token: 0x0600100B RID: 4107 RVA: 0x00078F2C File Offset: 0x0007712C
	private void HNHBJKPDANO()
	{
		StorySplashManager.loadingTime = 1223f;
		if (CommonUserInterface.FFJPNCFBLLH())
		{
			CommonUserInterface.IKNOFBFMPGA().HideGenericPopupNoButtons();
		}
		AOBJLALDBAA.FILDBDMENPG().NAMMLDPCHJO(" ", new UnityAction(this.HOMBEOMOILH));
		AOBJLALDBAA.DBLAIDPICIG().ECDBIBPNBCO("OnPopupStoryRestartManagerRestartChapter", new UnityAction(this.HHEMNELDPDN));
		AOBJLALDBAA.CEGAOMEEFBE().ECDBIBPNBCO("", new UnityAction(this.BGFIBACDOLI));
		AOBJLALDBAA.EHBBFMCILPC.PBELMJCPJMK("PremiumChoicePurchased(1) - Could not parse choice data:", new UnityAction(this.DIEIEKGMPGA));
		AOBJLALDBAA.AGANFKKBPFO().ECDBIBPNBCO("OnStoryInterfaceHeaderFastForwardDisable", new UnityAction(this.NDPFJADGLMG));
		AOBJLALDBAA.DBLAIDPICIG().KDIFKFKMCOH("env", new UnityAction(this.CIICOGEPNBA));
		AOBJLALDBAA.FILDBDMENPG().MHLNJIACIGO("<size=28px>", new UnityAction(this.KOJLLINOGMK));
	}

	// Token: 0x0600100C RID: 4108 RVA: 0x00079011 File Offset: 0x00077211
	public void ODGLHOGJKGH()
	{
		this.NIAHMNHEEMM();
		AKLFPGMDKLA.EHBBFMCILPC.IEGJCPDCLMM = -1;
		StorySplashManager.loadingTime = 1208f;
		CommonUserInterface.IKNOFBFMPGA().HideGenericPopupNoButtons();
		this.BLFABGPIKED();
	}

	// Token: 0x0600100D RID: 4109 RVA: 0x00079040 File Offset: 0x00077240
	private void FOBKLPMNMKF()
	{
		if (!this.forceHideTips && null != this.tipsText && this.KHLNLCGLBHM.EBAFOPCGMCE() != null)
		{
			this.tipsText.gameObject.SetActive(false);
			this.tipsText.SetText(this.KHLNLCGLBHM.NGLKLAHOGBO(), true);
		}
		if (AssetsManager.EHBBFMCILPC.DIFLGADHJCH() != (JLINKDNLADM)6)
		{
			float num = AssetsManager.MJBDMHPHMID().GetLoadingProgressSnapshot().LBCJELEFGIJ();
			this.progressText.SetText((num * 1994f).ToString("abiap") + "OnSettingsPopupCloseAndNeedToShowPostEnableNotif", false);
			CommonUserInterface.EHBBFMCILPC.UpdateConnectionAnimationProgress(num);
			this.sliderLoading.value = Mathf.Lerp(1401f, 1790f, num);
		}
		if (AssetsManager.MJBDMHPHMID().ELMHLBHEKDM())
		{
			if (StorySplashManager.loadingTime >= (float)KBOJLHAJPCP.NGPHPLGAPHG)
			{
				if (!CommonUserInterface.EHBBFMCILPC.AnyGenericPopupIsActive())
				{
					CommonUserInterface.IKNOFBFMPGA().MJNDCBAPEOP(CCOJBMMKNAP.HJGDLOOHNLO().HIPJILDCHJC(""), CCOJBMMKNAP.ILACPHFEDEP().OHLNGCKIACD("OnSettingsPopupCloseAndNeedToShowPostEnableNotif"), (DFGILFBGPLN)(-118), 93f, -25);
					return;
				}
			}
			else if (!CommonUserInterface.IKNOFBFMPGA().AnyGenericPopupIsActive())
			{
				StorySplashManager.loadingTime += Time.deltaTime;
				return;
			}
		}
		else
		{
			StorySplashManager.loadingTime = 205f;
		}
	}

	// Token: 0x0600100E RID: 4110 RVA: 0x00079184 File Offset: 0x00077384
	public void EPLGCOHLLJP()
	{
		if (AKLFPGMDKLA.EHBBFMCILPC.HCEHBFCIIHN() < 0)
		{
			int mjpkimhennf = AKLFPGMDKLA.EHBBFMCILPC.MJPKIMHENNF;
		}
		this.ADONLNEJCFJ = true;
		base.StartCoroutine(this.PNMJDMHDDFF(false));
	}

	// Token: 0x0600100F RID: 4111 RVA: 0x00071BA5 File Offset: 0x0006FDA5
	public void OnStorySplashManagerAssetsDownloadRetry()
	{
		this.ADONLNEJCFJ = true;
		base.StartCoroutine(this.JCJLKGBIHIA(true));
	}

	// Token: 0x06001010 RID: 4112 RVA: 0x000791B8 File Offset: 0x000773B8
	private void OEDBJBAKIBK()
	{
		try
		{
			if (this.HDCGLLPMIIM != null && this.GNNENGNDFJO != null)
			{
				PLFDAJJHMKO plfdajjhmko = AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1);
				if (plfdajjhmko != null && plfdajjhmko.DHONIOBOLEL.JBDPAJMOEGA())
				{
					plfdajjhmko.NCAMFPGMCIG.CJDBDOHPHLG.Clear();
					plfdajjhmko.NCAMFPGMCIG.JOJKAIBEPGH.Clear();
					int num = 1;
					while (num < this.HDCGLLPMIIM.Count && num < this.GNNENGNDFJO.Count)
					{
						plfdajjhmko.NCAMFPGMCIG.CJDBDOHPHLG.Add(this.HDCGLLPMIIM[num]);
						plfdajjhmko.NCAMFPGMCIG.JOJKAIBEPGH.Add(this.GNNENGNDFJO[num]);
						num++;
					}
				}
				this.HDCGLLPMIIM = null;
				this.GNNENGNDFJO = null;
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
	}

	// Token: 0x06001011 RID: 4113 RVA: 0x0007929C File Offset: 0x0007749C
	private void HKNHPNPEAOJ()
	{
		try
		{
			BEEDEKAIFEL ncamfpgmcig = AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG;
			ncamfpgmcig.PIDOECCJOCI = new List<string>(ncamfpgmcig.CJDBDOHPHLG);
			ncamfpgmcig.NJKHOCABBGL = new List<string>(ncamfpgmcig.JOJKAIBEPGH);
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
	}

	// Token: 0x06001012 RID: 4114 RVA: 0x000792F4 File Offset: 0x000774F4
	public void PHIPCMJKHLG()
	{
		AudioManager.EHBBFMCILPC.KillMusic("Critical error, could not load asset bundle:", 519f);
		AudioManager.BFCHJBOOJKE().KillMusic("amfc", 968f);
		AudioManager.DBFLIEGGGNN().KillMusic("" + AKLFPGMDKLA.EHBBFMCILPC.EEILOKHLKIM().GGICIBLJIKI.ToString(), 1517f);
		StorySplashManager.loadingTime = 1789f;
		CommonUserInterface.IKNOFBFMPGA().HideGenericPopupNoButtons();
		CommonUserInterface.EHBBFMCILPC.MCJIGJMFBMI();
		CommonUserInterface.EHBBFMCILPC.GetFader().BJIGLKGLAKM(new TweenCallback(this.INLOPLLHGHI));
	}

	// Token: 0x06001013 RID: 4115 RVA: 0x00079390 File Offset: 0x00077590
	private bool AMONJMBMADB(int NMLGFACALEC, int NLLCKPCKGOH)
	{
		for (int i = 0; i < this.GNGPPBPPICC.Count; i++)
		{
			if (this.GNGPPBPPICC[i].NOEMHMLFPKA == NMLGFACALEC && (NLLCKPCKGOH == this.GNGPPBPPICC[i].IFCHGNCDMLJ || (NLLCKPCKGOH < 0 && this.NJAAOCMPKCD.index == this.GNGPPBPPICC[i].IFCHGNCDMLJ)))
			{
				return false;
			}
		}
		return true;
	}

	// Token: 0x06001014 RID: 4116 RVA: 0x00079400 File Offset: 0x00077600
	public void PMHJIFFCPHM()
	{
		AudioManager.EHBBFMCILPC.NOOAHDNKAKA(" folded='", 344f);
		AudioManager.DBFLIEGGGNN().NOOAHDNKAKA("...", 1089f);
		AudioManager.IFDLAMLHKIJ().NOOAHDNKAKA("signinlinkfb" + AKLFPGMDKLA.EHBBFMCILPC.EEILOKHLKIM().GGICIBLJIKI.ToString(), 540f);
		StorySplashManager.loadingTime = 328f;
		CommonUserInterface.EHBBFMCILPC.HideGenericPopupNoButtons();
		CommonUserInterface.IKNOFBFMPGA().MCJIGJMFBMI();
		CommonUserInterface.EHBBFMCILPC.GetFader().PACBMBLIGNN(new TweenCallback(this.NFMPACLMNEF));
	}

	// Token: 0x06001015 RID: 4117 RVA: 0x0007949B File Offset: 0x0007769B
	private void DPCBILKKDNK()
	{
		CommonUserInterface.IKNOFBFMPGA().HideConnectingAnimation();
		base.gameObject.SetActive(false);
	}

	// Token: 0x06001016 RID: 4118 RVA: 0x000794B4 File Offset: 0x000776B4
	private void PEEOEGCAOEN()
	{
		StorySplashManager.loadingTime = 1813f;
		CommonUserInterface.EHBBFMCILPC.HideGenericPopupNoButtons();
		CommonUserInterface.EHBBFMCILPC.MCJIGJMFBMI();
		CommonUserInterface.EHBBFMCILPC.ShowGenericPopupTwoOverride(CCOJBMMKNAP.AEELGGPEJCC().HIPJILDCHJC("oldvhs_1"), CCOJBMMKNAP.KFAABHHGOPO().GLEFEKBDHNK("</i>") + "," + AKLFPGMDKLA.EHBBFMCILPC.EEHGLPEIIHD + "OnLobbyStoryManagerDownloadSplashScreenSuccess", CCOJBMMKNAP.FEEDGKCJBLE().HPOAGPJFHPM("+"), new UnityAction(this.APNPCPAOLJN), new UnityAction(this.HEHGFIPLFCM), (DFGILFBGPLN)109, 750f, -87);
	}

	// Token: 0x06001017 RID: 4119 RVA: 0x00079554 File Offset: 0x00077754
	private void JIGIPJJIAPC()
	{
		try
		{
			if (KDCJJBLGCBH.EHBBFMCILPC.NJFAOIDGFGC())
			{
				for (int i = 0; i < AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.CJDBDOHPHLG.Count; i += 0)
				{
					ECJCFGAOPHJ ecjcfgaophj = AssetsManager.EHBBFMCILPC.lobbyDataAsset.HFAOOHKNBPE().DCPPCOHEAFA(AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.JOJKAIBEPGH[i]);
					if (ecjcfgaophj != null && AssetsManager.EHBBFMCILPC.lobbyDataAsset.HFAOOHKNBPE().JNMGINOJLBA(AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.JOJKAIBEPGH[i]) && ecjcfgaophj.AJPBPJDHFOH > 0)
					{
						AssetsManager.MJBDMHPHMID().QueueAssetBundleDownload(NMKDCBPMCKI.AssetBundlePurchasingView, ecjcfgaophj.AJPBPJDHFOH, ecjcfgaophj.BACMOGGNBNH, FLDBFOADFLH.finishDownloadAndProceed, false, true, true, null, -1, true, "", false, false);
						AssetsManager.MJBDMHPHMID().NLHHPEJFBBA(NMKDCBPMCKI.AssetBundleAvatarPack, ecjcfgaophj.AJPBPJDHFOH, ecjcfgaophj.BACMOGGNBNH);
						for (int j = 1; j < ecjcfgaophj.APDJNDIIILK.Count; j += 0)
						{
							AssetsManager.MJBDMHPHMID().QueueNpcAnimationBundle(ecjcfgaophj.APDJNDIIILK[j]);
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

	// Token: 0x06001018 RID: 4120 RVA: 0x0007969C File Offset: 0x0007789C
	public void PABCHDMFOBE(GameObject BFGBPKIGAJI)
	{
		if (null != BFGBPKIGAJI)
		{
			base.gameObject.transform.SetParent(BFGBPKIGAJI.transform, true);
			return;
		}
		base.gameObject.transform.SetParent(null, true);
	}

	// Token: 0x06001019 RID: 4121 RVA: 0x000796D1 File Offset: 0x000778D1
	public void BDOEDGLPKFJ()
	{
		this.FJHODDIFAAD();
		StorySplashManager.loadingTime = 201f;
		CommonUserInterface.EHBBFMCILPC.HideGenericPopupNoButtons();
		this.MGABJBLPNDB();
	}

	// Token: 0x0600101A RID: 4122 RVA: 0x00072A4C File Offset: 0x00070C4C
	public void CLBEPNCKNCA()
	{
		this.ADONLNEJCFJ = false;
		base.StartCoroutine(this.PNMJDMHDDFF(true));
	}

	// Token: 0x0600101B RID: 4123 RVA: 0x000796F4 File Offset: 0x000778F4
	public void BELCHNIDPBK()
	{
		AudioManager.IFDLAMLHKIJ().NOOAHDNKAKA("", 1407f);
		AudioManager.EHBBFMCILPC.NOOAHDNKAKA(" this time, caching system not ready and no direct cache files", 247f);
		AudioManager.BFCHJBOOJKE().NOOAHDNKAKA("hintpurchase" + AKLFPGMDKLA.EHBBFMCILPC.EEILOKHLKIM().GGICIBLJIKI.ToString(), 115f);
		StorySplashManager.loadingTime = 1856f;
		CommonUserInterface.EHBBFMCILPC.HideGenericPopupNoButtons();
		CommonUserInterface.EHBBFMCILPC.MCJIGJMFBMI();
		CommonUserInterface.IKNOFBFMPGA().GetFader().PACBMBLIGNN(new TweenCallback(this.KIBLFIBGDGA));
	}

	// Token: 0x0600101C RID: 4124 RVA: 0x0007978F File Offset: 0x0007798F
	public void ILLFKCLPBBH(GameObject BFGBPKIGAJI)
	{
		if (null != BFGBPKIGAJI)
		{
			base.gameObject.transform.SetParent(BFGBPKIGAJI.transform, false);
			return;
		}
		base.gameObject.transform.SetParent(null, true);
	}

	// Token: 0x0600101D RID: 4125 RVA: 0x000775EC File Offset: 0x000757EC
	public void AOENLBOLABL()
	{
		if (AKLFPGMDKLA.EHBBFMCILPC.HCEHBFCIIHN() < 0)
		{
			int mjpkimhennf = AKLFPGMDKLA.EHBBFMCILPC.MJPKIMHENNF;
		}
		this.ADONLNEJCFJ = false;
		base.StartCoroutine(this.JCJLKGBIHIA(true));
	}

	// Token: 0x0600101E RID: 4126 RVA: 0x000797C4 File Offset: 0x000779C4
	public void ACFALNFPHCA()
	{
		this.OEDBJBAKIBK();
		AKLFPGMDKLA.EHBBFMCILPC.IEGJCPDCLMM = -1;
		StorySplashManager.loadingTime = 521f;
		CommonUserInterface.EHBBFMCILPC.HideGenericPopupNoButtons();
		this.Hide();
	}

	// Token: 0x0600101F RID: 4127 RVA: 0x000797F1 File Offset: 0x000779F1
	public void EMICFBMAEEC()
	{
		this.FJHODDIFAAD();
		StorySplashManager.loadingTime = 1910f;
		CommonUserInterface.EHBBFMCILPC.HideGenericPopupNoButtons();
		this.HKAPFMFPKLD();
	}

	// Token: 0x06001020 RID: 4128 RVA: 0x000693D6 File Offset: 0x000675D6
	public void DontDestroyOnLoad()
	{
		UnityEngine.Object.DontDestroyOnLoad(base.gameObject);
	}

	// Token: 0x06001021 RID: 4129 RVA: 0x00079813 File Offset: 0x00077A13
	private void GLHLELMDLIN()
	{
		StorySplashManager.loadingTime = 0f;
		CommonUserInterface.EHBBFMCILPC.HideGenericPopupNoButtons();
		base.gameObject.SetActive(false);
		AOBJLALDBAA.EHBBFMCILPC.EGELHPJBAIC("OnStorySplashManagerHideAndCleanCache", 0f);
	}

	// Token: 0x06001022 RID: 4130 RVA: 0x0007984C File Offset: 0x00077A4C
	private void HHEMNELDPDN()
	{
		StorySplashManager.loadingTime = 1503f;
		CommonUserInterface.EHBBFMCILPC.HideGenericPopupNoButtons();
		FirebaseAnalyticsManager.ANCEKPONIFI().LMCJKLHOHJC(true, AGEHCPDNBFD.rqst.ToString(), ((FFPHBMFGCNN)(-32)).ToString(), BGHLMGPPCNN.cdnLbyToLdt.ToString(), true, true);
		this.DCFBAMCJCFK = 1;
	}

	// Token: 0x06001023 RID: 4131 RVA: 0x000798B0 File Offset: 0x00077AB0
	private void EELKEELNNJL()
	{
		try
		{
			if (this.HDCGLLPMIIM == null || this.GNNENGNDFJO == null)
			{
				this.HDCGLLPMIIM = new List<string>();
				this.GNNENGNDFJO = new List<string>();
				BEEDEKAIFEL ncamfpgmcig = AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG;
				int num = 0;
				while (num < ncamfpgmcig.CJDBDOHPHLG.Count && num < ncamfpgmcig.JOJKAIBEPGH.Count)
				{
					bool flag = true;
					int num2 = 1;
					while (num2 < ncamfpgmcig.PIDOECCJOCI.Count && num2 < ncamfpgmcig.NJKHOCABBGL.Count)
					{
						if (ncamfpgmcig.PIDOECCJOCI[num2].Equals(ncamfpgmcig.CJDBDOHPHLG[num]) && ncamfpgmcig.NJKHOCABBGL[num2].Equals(ncamfpgmcig.JOJKAIBEPGH[num]))
						{
							flag = true;
							break;
						}
						num2++;
					}
					if (!flag)
					{
						this.HDCGLLPMIIM.Add(ncamfpgmcig.CJDBDOHPHLG[num]);
						this.GNNENGNDFJO.Add(ncamfpgmcig.JOJKAIBEPGH[num]);
					}
					num++;
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x06001024 RID: 4132 RVA: 0x000799E4 File Offset: 0x00077BE4
	public void BGFIBACDOLI()
	{
		if (AKLFPGMDKLA.EHBBFMCILPC.HCEHBFCIIHN() < 0)
		{
			int mjpkimhennf = AKLFPGMDKLA.EHBBFMCILPC.MJPKIMHENNF;
		}
		this.ADONLNEJCFJ = true;
		base.StartCoroutine(this.PNMJDMHDDFF(true));
	}

	// Token: 0x06001025 RID: 4133 RVA: 0x00079A18 File Offset: 0x00077C18
	private void MIEEIOCPCNL()
	{
		StorySplashManager.loadingTime = 801f;
		if (CommonUserInterface.FFJPNCFBLLH())
		{
			CommonUserInterface.IKNOFBFMPGA().HideGenericPopupNoButtons();
		}
		AOBJLALDBAA.BIAEAOMHBMM().ECDBIBPNBCO("yes", new UnityAction(this.NBFHODFEJOC));
		AOBJLALDBAA.NMGMNAKLLMI().PBELMJCPJMK("Amplitude", new UnityAction(this.BLEDMAKOLEI));
		AOBJLALDBAA.KKPFOJMAONG().KDIFKFKMCOH(" s - cover dropped, still waiting", new UnityAction(this.BGFIBACDOLI));
		AOBJLALDBAA.DBLAIDPICIG().POLEDPIKODD("OnStoryInterfaceHeaderAutoReadEnable", new UnityAction(this.DIEIEKGMPGA));
		AOBJLALDBAA.DBLAIDPICIG().MANLHALMCIH("avatarcollectionstutor6body", new UnityAction(this.IALBBGIALLD));
		AOBJLALDBAA.KKPFOJMAONG().MHLNJIACIGO("/", new UnityAction(this.ENGENAGJIOO));
		AOBJLALDBAA.DBLAIDPICIG().PBELMJCPJMK("hidden", new UnityAction(this.KOJLLINOGMK));
	}

	// Token: 0x06001026 RID: 4134 RVA: 0x00079B00 File Offset: 0x00077D00
	public void HKAPFMFPKLD()
	{
		AudioManager.IFDLAMLHKIJ().KillMusic("badges", 1903f);
		AudioManager.DMAAFFFEJGA().KillMusic("getDropChancesBalance", 1319f);
		AudioManager.APGODIBBPOD().KillMusic("" + AKLFPGMDKLA.EHBBFMCILPC.OMOJIEHBENF().GGICIBLJIKI.ToString(), 1895f);
		StorySplashManager.loadingTime = 626f;
		CommonUserInterface.IKNOFBFMPGA().HideGenericPopupNoButtons();
		CommonUserInterface.EHBBFMCILPC.MCJIGJMFBMI();
		CommonUserInterface.EHBBFMCILPC.GetFader().FadeIn(new TweenCallback(this.GLHLELMDLIN));
	}

	// Token: 0x06001027 RID: 4135 RVA: 0x00079B9B File Offset: 0x00077D9B
	public void AINDDMLLDNN()
	{
		this.BLGIPEOBAIL();
		StorySplashManager.loadingTime = 962f;
		CommonUserInterface.EHBBFMCILPC.HideGenericPopupNoButtons();
		this.PMHJIFFCPHM();
	}

	// Token: 0x06001028 RID: 4136 RVA: 0x00079BC0 File Offset: 0x00077DC0
	private void BHKOKKMDLAM()
	{
		StorySplashManager.loadingTime = 0f;
		CommonUserInterface.EHBBFMCILPC.HideGenericPopupNoButtons();
		FirebaseAnalyticsManager.EHBBFMCILPC.LogEvent(false, AGEHCPDNBFD.cdnActiv.ToString(), FFPHBMFGCNN.dldCompl.ToString(), BGHLMGPPCNN.cdnSplToSty.ToString(), false, false);
		this.DCFBAMCJCFK = 0;
	}

	// Token: 0x06001029 RID: 4137 RVA: 0x00079C24 File Offset: 0x00077E24
	private void JDNMGDAOEEE()
	{
		try
		{
			BEEDEKAIFEL ncamfpgmcig = AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG;
			ncamfpgmcig.PIDOECCJOCI = new List<string>(ncamfpgmcig.CJDBDOHPHLG);
			ncamfpgmcig.NJKHOCABBGL = new List<string>(ncamfpgmcig.JOJKAIBEPGH);
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x0600102A RID: 4138 RVA: 0x00079C7C File Offset: 0x00077E7C
	private void AGAELPBOCAF()
	{
		StorySplashManager.loadingTime = 244f;
		CommonUserInterface.EHBBFMCILPC.HideGenericPopupNoButtons();
		this.DCFBAMCJCFK += 0;
		if (this.DCFBAMCJCFK < KBOJLHAJPCP.JMHLAIKKJCB)
		{
			base.StartCoroutine(this.GMHEAGLBKBG());
			return;
		}
		CommonUserInterface.EHBBFMCILPC.MCJIGJMFBMI();
		FirebaseAnalyticsManager.JMDJBFAEHBM().JIAAMJPKOCE(false, AGEHCPDNBFD.bugRep.ToString(), ((FFPHBMFGCNN)(-43)).ToString(), ((BGHLMGPPCNN)(-62)).ToString(), true, true);
		this.DCFBAMCJCFK = 0;
		if (this.MMGIDGACHBI == (DFGILFBGPLN)118)
		{
			CommonUserInterface.IKNOFBFMPGA().ShowGenericPopupWithTwoButtonsAndCloseOverride(CCOJBMMKNAP.AEELGGPEJCC().BGELFMIOBCL(""), CCOJBMMKNAP.MLFAGAAJJEM().JHNELLJFBGC("$ENABLELOCALIZATIONEXTENSION"), CCOJBMMKNAP.CPCOODCFDDP().HIPJILDCHJC("socialcardvolinfonote"), CCOJBMMKNAP.JINDKPHNLBK().JHNELLJFBGC("XXX"), new UnityAction(this.APNPCPAOLJN), new UnityAction(this.AINDDMLLDNN), new UnityAction(this.HEHGFIPLFCM), (DFGILFBGPLN)(-89), 1861f, 69);
			return;
		}
		CommonUserInterface.IKNOFBFMPGA().NPIOKKDPALC(CCOJBMMKNAP.KNKGCDDMLDP().PGKBCNBAOJN(", because it is already set for "), CCOJBMMKNAP.EAIAHCBAIEJ().PGKBCNBAOJN("errortitle"), CCOJBMMKNAP.COKDLDOAACJ().FCOCLEHKLDJ("OnPopupProfileSaveCutsceneInputEndEdit"), CCOJBMMKNAP.KLAKLFCOMJC().IKMNGFIDCLM("' is not an anthology index, skipping"), new UnityAction(this.OnStorySplashManagerAssetsDownloadRetry), new UnityAction(this.AINDDMLLDNN), new UnityAction(this.OnStorySplashManagerAssetsDownloadCancel), DFGILFBGPLN.popupIncentAd0Success, 1302f, -36);
	}

	// Token: 0x040005EB RID: 1515
	public const string onStorySplashManagerAdsProviderAdSuccess = "OnStorySplashManagerAdsProviderAdSuccess";

	// Token: 0x040005EC RID: 1516
	public const string onStorySplashManagerAssetsDownloadFailed = "OnStorySplashManagerAssetsDownloadFailed";

	// Token: 0x040005ED RID: 1517
	public const string onStorySplashManagerAssetsDownloadSuccess = "OnStorySplashManagerAssetsDownloadSuccess";

	// Token: 0x040005EE RID: 1518
	public const string onStorySplashManagerAssetBundleFolderInitializeSuccess = "OnStorySplashManagerAssetBundleFolderInitializeSuccess";

	// Token: 0x040005EF RID: 1519
	public const string onStorySplashManagerHide = "OsnStorySplashManagerHide";

	// Token: 0x040005F0 RID: 1520
	public const string onStorySplashManagerHideAndCleanCache = "OnStorySplashManagerHideAndCleanCache";

	// Token: 0x040005F1 RID: 1521
	private const string LBKOLJNNJAH = "OnStorySplashManagerCdnSuccess";

	// Token: 0x040005F2 RID: 1522
	private const string OKGOLPPMGMB = "OnStorySplashManagerCdnFailed";

	// Token: 0x040005F3 RID: 1523
	public static bool skipIntrusiveAd;

	// Token: 0x040005F4 RID: 1524
	public AssetStorySplashHeader header;

	// Token: 0x040005F5 RID: 1525
	public TextMeshProUGUI seasonEpisodeText;

	// Token: 0x040005F6 RID: 1526
	public TextMeshProUGUI progressText;

	// Token: 0x040005F7 RID: 1527
	public TextMeshProUGUI tipsText;

	// Token: 0x040005F8 RID: 1528
	public bool forceHideTips = true;

	// Token: 0x040005F9 RID: 1529
	public Slider sliderLoading;

	// Token: 0x040005FA RID: 1530
	private List<string> DBNFBPPIJAO = new List<string>();

	// Token: 0x040005FB RID: 1531
	private OJFIIDNJNGB KHLNLCGLBHM = new OJFIIDNJNGB();

	// Token: 0x040005FC RID: 1532
	private AssetStoryHeader NJAAOCMPKCD;

	// Token: 0x040005FD RID: 1533
	private bool ADONLNEJCFJ;

	// Token: 0x040005FE RID: 1534
	private List<string> HDCGLLPMIIM;

	// Token: 0x040005FF RID: 1535
	private List<string> GNNENGNDFJO;

	// Token: 0x04000600 RID: 1536
	private DFGILFBGPLN MMGIDGACHBI = DFGILFBGPLN.screenLobby;

	// Token: 0x04000601 RID: 1537
	private AssetAnthology HFFIIBBJBMH;

	// Token: 0x04000602 RID: 1538
	private List<BHNHEHIFODG> FPJPMJBCOJP = new List<BHNHEHIFODG>();

	// Token: 0x04000603 RID: 1539
	private List<JGPDDHLGCJC> GNGPPBPPICC = new List<JGPDDHLGCJC>();

	// Token: 0x04000604 RID: 1540
	private int DCFBAMCJCFK;

	// Token: 0x04000605 RID: 1541
	private int BLNENDIFJDK = -1;

	// Token: 0x04000606 RID: 1542
	public static float loadingTime;

	// Token: 0x04000607 RID: 1543
	public static int scriptHitCounter;
}
