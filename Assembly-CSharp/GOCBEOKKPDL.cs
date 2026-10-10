using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

// Token: 0x020003DD RID: 989
public static class GOCBEOKKPDL
{
	// Token: 0x06007287 RID: 29319 RVA: 0x003394F0 File Offset: 0x003376F0
	private static void JMCFKOPKDAG()
	{
		try
		{
			GOCBEOKKPDL.JIEGCNEJMNO();
			if (null != GOCBEOKKPDL.CFMOCDKKELJ)
			{
				GOCBEOKKPDL.CFMOCDKKELJ.SetBlockDownloadMissingLowPreview2Assets(GOCBEOKKPDL.CFIIBMEJNNI);
			}
			if (ProfileItem2.profileWindowActive)
			{
				AOBJLALDBAA.EHBBFMCILPC.EGELHPJBAIC("OnLiveProfileThemesLoaderStart", 0f);
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
		GOCBEOKKPDL.CFMOCDKKELJ = null;
		GOCBEOKKPDL.JLHFNPKOGIJ = false;
		GOCBEOKKPDL.KLJKCLKMAGO = null;
	}

	// Token: 0x06007288 RID: 29320 RVA: 0x00339564 File Offset: 0x00337764
	private static void DDBHAAHNBMN()
	{
		CommonUserInterface.EHBBFMCILPC.ShowGenericPopup(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("congratstitle"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("cardoptionsloadingthemedone"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("ok"), DFGILFBGPLN.popupEnergyHint, 0f, 28);
	}

	// Token: 0x06007289 RID: 29321 RVA: 0x003395B4 File Offset: 0x003377B4
	private static void FFOEDOCELIE()
	{
		CommonUserInterface.EHBBFMCILPC.ShowGenericPopupOneOverride(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("errortitle"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("cdnerror"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("retry"), new UnityAction(GOCBEOKKPDL.FHPFJPIOLMH), DFGILFBGPLN.popupCdnDownloadFailed, 0f, 28);
	}

	// Token: 0x0600728A RID: 29322 RVA: 0x0033960E File Offset: 0x0033780E
	private static IEnumerator KFIALFMFHDI()
	{
		yield return null;
		yield return Resources.UnloadUnusedAssets();
		yield break;
	}

	// Token: 0x0600728B RID: 29323 RVA: 0x00339618 File Offset: 0x00337818
	private static StoryEnvironmentManager AANNAALDDJD(SceneStoryAssetPackManager[] AKHNDEPBBAC, string ICAHJJBAEHB)
	{
		for (int i = 0; i < AKHNDEPBBAC.Length; i++)
		{
			if (AKHNDEPBBAC[i].environmentsBackList != null)
			{
				for (int j = 0; j < AKHNDEPBBAC[i].environmentsBackList.Count; j++)
				{
					StoryEnvironmentManager storyEnvironmentManager = AKHNDEPBBAC[i].environmentsBackList[j];
					if (!(null == storyEnvironmentManager) && storyEnvironmentManager.mappings != null)
					{
						for (int k = 0; k < storyEnvironmentManager.mappings.Count; k++)
						{
							if (storyEnvironmentManager.mappings[k].Equals(ICAHJJBAEHB))
							{
								DPGJIJGOCIC.ADFCDFHBDAF("[LoadingTheme] environment " + ICAHJJBAEHB + " not found, replacing with " + storyEnvironmentManager.gameObject.name);
								return storyEnvironmentManager;
							}
						}
					}
				}
			}
		}
		return null;
	}

	// Token: 0x0600728C RID: 29324 RVA: 0x003396CC File Offset: 0x003378CC
	public static void KDNNJKMHMCE(int LLLCDMNPKFI)
	{
		try
		{
			if (!GOCBEOKKPDL.JLHFNPKOGIJ)
			{
				BNFCLKNDBLO bnfclkndblo = GOCBEOKKPDL.HMHMFOLAOCN(LLLCDMNPKFI);
				if (bnfclkndblo == null)
				{
					GOCBEOKKPDL.EFBHJMDIBGC();
				}
				else
				{
					GOCBEOKKPDL.KDNNJKMHMCE(bnfclkndblo);
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
			GOCBEOKKPDL.FAHJBKEFKBF();
		}
	}

	// Token: 0x0600728D RID: 29325 RVA: 0x00339718 File Offset: 0x00337918
	private static void FAHJBKEFKBF()
	{
		DPGJIJGOCIC.ADFCDFHBDAF("[LoadingTheme] environment download failed");
		bool flag = GOCBEOKKPDL.JLHFNPKOGIJ && GOCBEOKKPDL.KLJKCLKMAGO != null;
		if (flag && GOCBEOKKPDL.AMMGBDJPIPJ())
		{
			return;
		}
		CommonUserInterface.EHBBFMCILPC.HideConnectingAnimation();
		if (flag)
		{
			GOCBEOKKPDL.KEECIEPCCMF = GOCBEOKKPDL.KLJKCLKMAGO;
			GOCBEOKKPDL.JMCFKOPKDAG();
			FirebaseAnalyticsManager.EHBBFMCILPC.LogEvent(false, AGEHCPDNBFD.cdnActiv.ToString(), FFPHBMFGCNN.dldFail.ToString(), BGHLMGPPCNN.cdnLbyToLdt.ToString(), false, false);
			GOCBEOKKPDL.NPMNDNEDBGC = 0;
			GOCBEOKKPDL.FFOEDOCELIE();
			return;
		}
		GOCBEOKKPDL.JMCFKOPKDAG();
		GOCBEOKKPDL.BDNAPKGLNNE();
	}

	// Token: 0x0600728E RID: 29326 RVA: 0x003397BC File Offset: 0x003379BC
	private static void LBDDJIIOIBN()
	{
		HJEEGEOCEGI hjeegeocegi = HJEEGEOCEGI.environmentMissing;
		GOCBEOKKPDL.NPMNDNEDBGC = 0;
		try
		{
			SceneStoryAssetPackManager[] array = UnityEngine.Object.FindObjectsOfType(typeof(SceneStoryAssetPackManager)) as SceneStoryAssetPackManager[];
			StoryEnvironmentManager storyEnvironmentManager = GOCBEOKKPDL.AFMLKAHFGLI(array, GOCBEOKKPDL.KLJKCLKMAGO.IBFLNCMCKAL, true);
			if (null == storyEnvironmentManager)
			{
				storyEnvironmentManager = GOCBEOKKPDL.AANNAALDDJD(array, GOCBEOKKPDL.KLJKCLKMAGO.IBFLNCMCKAL);
			}
			if (null != storyEnvironmentManager)
			{
				StoryEnvironmentManager hkeflhbankp = GOCBEOKKPDL.AFMLKAHFGLI(array, storyEnvironmentManager.gameObject.name, false);
				hjeegeocegi = EEIBKLDNBAP.NAGNMBGLLEI(GOCBEOKKPDL.KLJKCLKMAGO, storyEnvironmentManager, hkeflhbankp);
			}
			else
			{
				DPGJIJGOCIC.ADFCDFHBDAF("[LoadingTheme] environment " + GOCBEOKKPDL.KLJKCLKMAGO.IBFLNCMCKAL + " not found in the downloaded pack " + GOCBEOKKPDL.KLJKCLKMAGO.CIEHGJMAFKH);
			}
			for (int i = 0; i < array.Length; i++)
			{
				if (null != array[i])
				{
					UnityEngine.Object.Destroy(array[i].gameObject);
				}
			}
			GOCBEOKKPDL.OBDNNGKCAPP();
			CommonUserInterface.EHBBFMCILPC.StartCoroutine(GOCBEOKKPDL.KFIALFMFHDI());
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
			hjeegeocegi = HJEEGEOCEGI.notResolvable;
		}
		CommonUserInterface.EHBBFMCILPC.HideConnectingAnimation();
		GOCBEOKKPDL.JMCFKOPKDAG();
		if (hjeegeocegi == HJEEGEOCEGI.set)
		{
			try
			{
				AKLFPGMDKLA.EHBBFMCILPC.APLCOFLOAPA = 1;
				HBKMKCBPJDI.LFGGDBICHFB();
				AKLFPGMDKLA.EHBBFMCILPC.LPCBDEBKAIM();
			}
			catch (Exception aklgbjkdomm2)
			{
				DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm2);
			}
			GOCBEOKKPDL.DDBHAAHNBMN();
			return;
		}
		GOCBEOKKPDL.EFBHJMDIBGC();
	}

	// Token: 0x0600728F RID: 29327 RVA: 0x00339910 File Offset: 0x00337B10
	private static void OBDNNGKCAPP()
	{
		try
		{
			GameObject[] rootGameObjects = SceneManager.GetActiveScene().GetRootGameObjects();
			for (int i = 0; i < rootGameObjects.Length; i++)
			{
				if (null != rootGameObjects[i] && rootGameObjects[i].name.Equals("_Dev"))
				{
					UnityEngine.Object.Destroy(rootGameObjects[i]);
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x06007290 RID: 29328 RVA: 0x0033997C File Offset: 0x00337B7C
	private static void KDIOLKNDDKK()
	{
		GOCBEOKKPDL.NPMNDNEDBGC = KBOJLHAJPCP.LPJOFEDNKHA;
		GOCBEOKKPDL.FAHJBKEFKBF();
	}

	// Token: 0x06007291 RID: 29329 RVA: 0x00339990 File Offset: 0x00337B90
	public static BNFCLKNDBLO HMHMFOLAOCN(int LLLCDMNPKFI)
	{
		CLGFGOHBCGJ clgfgohbcgj = LJNMIPMNOKF.EHBBFMCILPC.KMDBNEFCPOH(LLLCDMNPKFI);
		if (clgfgohbcgj == null)
		{
			return null;
		}
		BNFCLKNDBLO bnfclkndblo = new BNFCLKNDBLO();
		bnfclkndblo.IBFLNCMCKAL = GDJPPKAMIFL.EHBBFMCILPC.KANJCCECECA(LLLCDMNPKFI);
		string text = GKJPOGNFKNK.OCOEFCIJGIE(LLLCDMNPKFI);
		if (text != null && text.Length > 0)
		{
			bnfclkndblo.IBFLNCMCKAL = text;
		}
		if (bnfclkndblo.IBFLNCMCKAL == null || bnfclkndblo.IBFLNCMCKAL.Length == 0)
		{
			return null;
		}
		bnfclkndblo.FPJPHNLANPG = 2;
		bnfclkndblo.PGEKNGNHANN = clgfgohbcgj.APMIAIEKIHD;
		bnfclkndblo.AMKCLHLIIMN = GDJPPKAMIFL.EHBBFMCILPC.GJEINLADFKA(LLLCDMNPKFI);
		bnfclkndblo.FJFEPNKBELL = bnfclkndblo.AMKCLHLIIMN + 1;
		int num = GDJPPKAMIFL.EHBBFMCILPC.GCDJGGEMDLP(LLLCDMNPKFI);
		int num2 = GKJPOGNFKNK.HPMGFDAPLLP(LLLCDMNPKFI);
		if (num2 >= 0)
		{
			num = num2;
		}
		bnfclkndblo.CIEHGJMAFKH = "abs" + GDJPPKAMIFL.EHBBFMCILPC.HBKANKMHEMN(LLLCDMNPKFI).ToString() + "asp" + num.ToString();
		bnfclkndblo.CGBHBJPLKIM = clgfgohbcgj;
		return bnfclkndblo;
	}

	// Token: 0x06007292 RID: 29330 RVA: 0x00339A7C File Offset: 0x00337C7C
	private static StoryEnvironmentManager AFMLKAHFGLI(SceneStoryAssetPackManager[] AKHNDEPBBAC, string ICAHJJBAEHB, bool KOOMFOOEDNH)
	{
		for (int i = 0; i < AKHNDEPBBAC.Length; i++)
		{
			List<StoryEnvironmentManager> list = KOOMFOOEDNH ? AKHNDEPBBAC[i].environmentsBackList : AKHNDEPBBAC[i].environmentsFrontList;
			if (list != null)
			{
				for (int j = 0; j < list.Count; j++)
				{
					if (null != list[j] && list[j].gameObject.name.Equals(ICAHJJBAEHB))
					{
						return list[j];
					}
				}
			}
		}
		return null;
	}

	// Token: 0x06007293 RID: 29331 RVA: 0x00339AF2 File Offset: 0x00337CF2
	private static void FHPFJPIOLMH()
	{
		if (GOCBEOKKPDL.KEECIEPCCMF == null)
		{
			return;
		}
		GOCBEOKKPDL.KDNNJKMHMCE(GOCBEOKKPDL.KEECIEPCCMF);
	}

	// Token: 0x06007294 RID: 29332 RVA: 0x00339B08 File Offset: 0x00337D08
	public static bool BHHMCPFKHBH(int LLLCDMNPKFI)
	{
		bool result;
		try
		{
			string text = GDJPPKAMIFL.EHBBFMCILPC.KANJCCECECA(LLLCDMNPKFI);
			if (text == null || text.Length == 0)
			{
				result = false;
			}
			else
			{
				result = (GDJPPKAMIFL.EHBBFMCILPC.HBKANKMHEMN(LLLCDMNPKFI) >= 0 && GDJPPKAMIFL.EHBBFMCILPC.GCDJGGEMDLP(LLLCDMNPKFI) > 0);
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
			result = false;
		}
		return result;
	}

	// Token: 0x06007295 RID: 29333 RVA: 0x00339B6C File Offset: 0x00337D6C
	private static void ANBAJDILPMP()
	{
		AOBJLALDBAA.EHBBFMCILPC.MFIMALJPCDP("OnLoadingThemeSelectorFolderInitialized", new UnityAction(GOCBEOKKPDL.CHLJKNHDGID));
		AOBJLALDBAA.EHBBFMCILPC.MFIMALJPCDP("OnLoadingThemeSelectorFolderFailed", new UnityAction(GOCBEOKKPDL.FAHJBKEFKBF));
		AOBJLALDBAA.EHBBFMCILPC.MFIMALJPCDP("OnLoadingThemeSelectorDownloadSuccess", new UnityAction(GOCBEOKKPDL.LBDDJIIOIBN));
		AOBJLALDBAA.EHBBFMCILPC.MFIMALJPCDP("OnLoadingThemeSelectorDownloadFailed", new UnityAction(GOCBEOKKPDL.FAHJBKEFKBF));
	}

	// Token: 0x06007296 RID: 29334 RVA: 0x00339BE8 File Offset: 0x00337DE8
	public static bool JHIDJNFGJBI(BNFCLKNDBLO CLNJABMOEBA)
	{
		bool result;
		try
		{
			if (CLNJABMOEBA == null || CLNJABMOEBA.IBFLNCMCKAL == null || CLNJABMOEBA.IBFLNCMCKAL.Length == 0 || CLNJABMOEBA.CIEHGJMAFKH == null || CLNJABMOEBA.CIEHGJMAFKH.Length == 0)
			{
				result = false;
			}
			else
			{
				result = !GOCBEOKKPDL.FDAJGHFIDLN(CLNJABMOEBA);
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
			result = false;
		}
		return result;
	}

	// Token: 0x06007297 RID: 29335 RVA: 0x00339C4C File Offset: 0x00337E4C
	private static IEnumerator LBLJJBEMDBJ()
	{
		yield return new WaitForEndOfFrame();
		float waited = 0f;
		while (GOCBEOKKPDL.JLHFNPKOGIJ && AssetsManager.EHBBFMCILPC.IsBusy() && waited < 20f)
		{
			waited += 0.05f;
			yield return new WaitForSeconds(0.05f);
		}
		if (!GOCBEOKKPDL.JLHFNPKOGIJ)
		{
			yield break;
		}
		if (AssetsManager.EHBBFMCILPC.IsBusy())
		{
			DPGJIJGOCIC.ADFCDFHBDAF("[LoadingTheme] asset bundle pipeline still busy after " + 20f.ToString() + "s");
			GOCBEOKKPDL.KDIOLKNDDKK();
			yield break;
		}
		try
		{
			AssetsManager.EHBBFMCILPC.InitializeAssetBundleFolder((LNDOOJOFFOM)GOCBEOKKPDL.KLJKCLKMAGO.FJFEPNKBELL, "OnLoadingThemeSelectorFolderInitialized", "OnLoadingThemeSelectorFolderFailed");
			yield break;
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
			GOCBEOKKPDL.FAHJBKEFKBF();
			yield break;
		}
		yield break;
	}

	// Token: 0x06007298 RID: 29336 RVA: 0x00339C54 File Offset: 0x00337E54
	private static void EFBHJMDIBGC()
	{
		CommonUserInterface.EHBBFMCILPC.ShowGenericPopup(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("importanttitle"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("cardoptionsloadingthemevideo"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("ok"), DFGILFBGPLN.popupEnergyHint, 0f, 28);
	}

	// Token: 0x06007299 RID: 29337 RVA: 0x00339CA4 File Offset: 0x00337EA4
	public static void KDNNJKMHMCE(BNFCLKNDBLO CLNJABMOEBA)
	{
		try
		{
			if (!GOCBEOKKPDL.JLHFNPKOGIJ)
			{
				if (CLNJABMOEBA == null || CLNJABMOEBA.IBFLNCMCKAL == null || CLNJABMOEBA.IBFLNCMCKAL.Length == 0 || CLNJABMOEBA.CIEHGJMAFKH == null || CLNJABMOEBA.CIEHGJMAFKH.Length == 0)
				{
					GOCBEOKKPDL.EFBHJMDIBGC();
				}
				else if (GOCBEOKKPDL.FDAJGHFIDLN(CLNJABMOEBA))
				{
					DPGJIJGOCIC.NFIDPOMCNLP("[LoadingTheme] not usable: " + CLNJABMOEBA.IBFLNCMCKAL + " needs video");
					GOCBEOKKPDL.EFBHJMDIBGC();
				}
				else if (EEIBKLDNBAP.PNHLBGBGFIG(CLNJABMOEBA))
				{
					DPGJIJGOCIC.NFIDPOMCNLP("[LoadingTheme] already the loading theme: " + CLNJABMOEBA.IBFLNCMCKAL);
					EEIBKLDNBAP.BIHFLMJAILJ(true);
					if (1 != AKLFPGMDKLA.EHBBFMCILPC.APLCOFLOAPA)
					{
						AKLFPGMDKLA.EHBBFMCILPC.APLCOFLOAPA = 1;
						AKLFPGMDKLA.EHBBFMCILPC.LPCBDEBKAIM();
					}
					CommonUserInterface.EHBBFMCILPC.ShowGenericPopup(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("congratstitle"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("cardoptionsloadingthemedone"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("ok"), DFGILFBGPLN.popupEnergyHint, 0.15f, 28);
				}
				else
				{
					GOCBEOKKPDL.JLHFNPKOGIJ = true;
					GOCBEOKKPDL.KLJKCLKMAGO = CLNJABMOEBA;
					GOCBEOKKPDL.NPMNDNEDBGC = 0;
					GOCBEOKKPDL.ANBAJDILPMP();
					AssetsManager.EHBBFMCILPC.GetLoadingProgressSnapshot().EPJKDCDOEMM(0);
					CommonUserInterface.EHBBFMCILPC.ShowConnectingAnimationWithProgress(96);
					GOCBEOKKPDL.CFMOCDKKELJ = UnityEngine.Object.FindObjectOfType<SceneLobbyManager2>();
					if (null != GOCBEOKKPDL.CFMOCDKKELJ)
					{
						GOCBEOKKPDL.CFIIBMEJNNI = GOCBEOKKPDL.CFMOCDKKELJ.GetBlockDownloadMissingLowPreview2Assets();
						GOCBEOKKPDL.CFMOCDKKELJ.SetBlockDownloadMissingLowPreview2Assets(true);
					}
					AOBJLALDBAA.EHBBFMCILPC.EGELHPJBAIC("OnLiveProfileThemesLoaderStop", 0f);
					AssetsManager.EHBBFMCILPC.ForceStopAllOperations();
					DPGJIJGOCIC.NFIDPOMCNLP("[LoadingTheme] downloading " + CLNJABMOEBA.CIEHGJMAFKH + " for " + CLNJABMOEBA.IBFLNCMCKAL);
					CommonUserInterface.EHBBFMCILPC.StartCoroutine(GOCBEOKKPDL.LBLJJBEMDBJ());
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
			GOCBEOKKPDL.FAHJBKEFKBF();
		}
	}

	// Token: 0x0600729A RID: 29338 RVA: 0x00339E8C File Offset: 0x0033808C
	private static bool AMMGBDJPIPJ()
	{
		GOCBEOKKPDL.NPMNDNEDBGC++;
		if (GOCBEOKKPDL.NPMNDNEDBGC >= KBOJLHAJPCP.LPJOFEDNKHA)
		{
			return false;
		}
		bool result;
		try
		{
			DPGJIJGOCIC.NFIDPOMCNLP("[LoadingTheme] auto retry " + GOCBEOKKPDL.NPMNDNEDBGC.ToString());
			AssetsManager.EHBBFMCILPC.GetLoadingProgressSnapshot().EPJKDCDOEMM(0);
			CommonUserInterface.EHBBFMCILPC.StartCoroutine(GOCBEOKKPDL.LBLJJBEMDBJ());
			result = true;
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
			result = false;
		}
		return result;
	}

	// Token: 0x0600729B RID: 29339 RVA: 0x00339F0C File Offset: 0x0033810C
	private static void JIEGCNEJMNO()
	{
		AOBJLALDBAA.EHBBFMCILPC.MANLHALMCIH("OnLoadingThemeSelectorFolderInitialized", new UnityAction(GOCBEOKKPDL.CHLJKNHDGID));
		AOBJLALDBAA.EHBBFMCILPC.MANLHALMCIH("OnLoadingThemeSelectorFolderFailed", new UnityAction(GOCBEOKKPDL.FAHJBKEFKBF));
		AOBJLALDBAA.EHBBFMCILPC.MANLHALMCIH("OnLoadingThemeSelectorDownloadSuccess", new UnityAction(GOCBEOKKPDL.LBDDJIIOIBN));
		AOBJLALDBAA.EHBBFMCILPC.MANLHALMCIH("OnLoadingThemeSelectorDownloadFailed", new UnityAction(GOCBEOKKPDL.FAHJBKEFKBF));
	}

	// Token: 0x0600729C RID: 29340 RVA: 0x00339F88 File Offset: 0x00338188
	private static bool FDAJGHFIDLN(BNFCLKNDBLO CLNJABMOEBA)
	{
		if (CLNJABMOEBA.EHCMMPCCHPD != null && CLNJABMOEBA.EHCMMPCCHPD.Length > 0)
		{
			return true;
		}
		for (int i = 0; i < CLNJABMOEBA.PIMEHAPFCHC.Count; i++)
		{
			if (CLNJABMOEBA.PIMEHAPFCHC[i] != null && CLNJABMOEBA.PIMEHAPFCHC[i].ToLowerInvariant().Contains("layervideo"))
			{
				return true;
			}
		}
		return false;
	}

	// Token: 0x0600729D RID: 29341 RVA: 0x00339FF4 File Offset: 0x003381F4
	private static void CHLJKNHDGID()
	{
		try
		{
			AssetsManager.EHBBFMCILPC.QueueAssetBundleDownload(NMKDCBPMCKI.AssetBundleStoryAssetPack, GOCBEOKKPDL.KLJKCLKMAGO.OCPJHLCBIPB(), GOCBEOKKPDL.KLJKCLKMAGO.FECFDDGCPGB(), FLDBFOADFLH.finishDownloadAndProceed, false, true, false, null, -1, false, "", false, false);
			AssetsManager.EHBBFMCILPC.QueueAssetBundleDownload(NMKDCBPMCKI.AssetBundleStoryAssetPackActivate, 0, 0, FLDBFOADFLH.finishDownloadAndProceed, false, false, false, null, -1, false, "", false, false);
			AssetsManager.EHBBFMCILPC.GetLoadingProgressSnapshot().CLIOEOLFFLO(LEJKDNAGDHC.Fast);
			AssetsManager.EHBBFMCILPC.GetLoadingProgressSnapshot().GIJKJMMDJEL(0f, 1f);
			AssetsManager.EHBBFMCILPC.DownloadQueuedAssetBundles("OnLoadingThemeSelectorDownloadSuccess", "OnLoadingThemeSelectorDownloadFailed", false);
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
			GOCBEOKKPDL.FAHJBKEFKBF();
		}
	}

	// Token: 0x0600729E RID: 29342 RVA: 0x0033A0A8 File Offset: 0x003382A8
	private static void BDNAPKGLNNE()
	{
		CommonUserInterface.EHBBFMCILPC.ShowGenericPopup(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("errortitle"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("cdnerror"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("ok"), DFGILFBGPLN.popupCdnDownloadFailed, 0f, 28);
	}

	// Token: 0x0400221C RID: 8732
	private const string OEKGIOEPDNC = "OnLoadingThemeSelectorFolderInitialized";

	// Token: 0x0400221D RID: 8733
	private const string BPGOFNBMPBK = "OnLoadingThemeSelectorFolderFailed";

	// Token: 0x0400221E RID: 8734
	private const string EJFDJCKDDKM = "OnLoadingThemeSelectorDownloadSuccess";

	// Token: 0x0400221F RID: 8735
	private const string EBDOBDLLCML = "OnLoadingThemeSelectorDownloadFailed";

	// Token: 0x04002220 RID: 8736
	private const string KJEPDBDDOKF = "[LoadingTheme] ";

	// Token: 0x04002221 RID: 8737
	private const float KONHFOGJJFH = 20f;

	// Token: 0x04002222 RID: 8738
	private const string BIGLEHJDKJD = "_Dev";

	// Token: 0x04002223 RID: 8739
	private static bool JLHFNPKOGIJ;

	// Token: 0x04002224 RID: 8740
	private static BNFCLKNDBLO KLJKCLKMAGO;

	// Token: 0x04002225 RID: 8741
	private static SceneLobbyManager2 CFMOCDKKELJ;

	// Token: 0x04002226 RID: 8742
	private static bool CFIIBMEJNNI;

	// Token: 0x04002227 RID: 8743
	private static int NPMNDNEDBGC;

	// Token: 0x04002228 RID: 8744
	private static BNFCLKNDBLO KEECIEPCCMF;
}
