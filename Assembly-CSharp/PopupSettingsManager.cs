using System;
using System.Collections;
using AssetBundles;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

// Token: 0x02000465 RID: 1125
public class PopupSettingsManager : MonoBehaviour
{
	// Token: 0x0600888D RID: 34957 RVA: 0x003D04E8 File Offset: 0x003CE6E8
	private void KCDCKIFNIGH()
	{
		this.themeName.SetText(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("theme" + AKLFPGMDKLA.EHBBFMCILPC.ICEOGOCOMJL().ToString()), true);
	}

	// Token: 0x0600888E RID: 34958 RVA: 0x003D052D File Offset: 0x003CE72D
	private IEnumerator FIAAEDEPPDP()
	{
		this.googleSignInBlock.SetActive(true);
		this.googleSignOutBlock.SetActive(false);
		yield return new WaitForSeconds(0.5f);
		AKLFPGMDKLA.EHBBFMCILPC.EEDHNEIMAPN = 0;
		this.CPOFPKBDLDD();
		yield break;
	}

	// Token: 0x0600888F RID: 34959 RVA: 0x003D053C File Offset: 0x003CE73C
	private void NJPONLCMDJH()
	{
		this.CBKOEKOGHGL = true;
		if (!OGKGGFFPKHG.MOCGHDDKHFO())
		{
			this.notificationsBlock.SetActive(false);
			return;
		}
		this.notificationsBlock.SetActive(true);
		if (AKLFPGMDKLA.EHBBFMCILPC.HEFJBOKIEGH == 1)
		{
			this.notificationsOn.SetActive(false);
			this.notificationsOff.SetActive(true);
			return;
		}
		this.notificationsOn.SetActive(true);
		this.notificationsOff.SetActive(true);
	}

	// Token: 0x06008890 RID: 34960 RVA: 0x003D05AE File Offset: 0x003CE7AE
	public void OnAppleSignOutClick()
	{
		AppleSignInManager.EHBBFMCILPC.LogOut();
		base.StartCoroutine(this.KMHBOANIBHJ());
	}

	// Token: 0x06008891 RID: 34961 RVA: 0x003D05C8 File Offset: 0x003CE7C8
	private void LJIFEPCHEHD()
	{
		this.HLBGELGLLEI = false;
		AOBJLALDBAA.EHBBFMCILPC.POLEDPIKODD("\"", new UnityAction(this.ABNOKGPFBOK));
		AOBJLALDBAA.DBLAIDPICIG().ONIBLJOFFPG("')", new UnityAction(this.AOGNIEKBGJH));
		CommonUserInterface.IKNOFBFMPGA().HideConnectingAnimation();
	}

	// Token: 0x06008892 RID: 34962 RVA: 0x003D061C File Offset: 0x003CE81C
	public void OnGoogleSignOutClick()
	{
		GooglePlayServicesManager.EHBBFMCILPC.LogOut();
		base.StartCoroutine(this.FIAAEDEPPDP());
	}

	// Token: 0x06008893 RID: 34963 RVA: 0x003D0638 File Offset: 0x003CE838
	private void GDKKAMGIGFL()
	{
		this.HLBGELGLLEI = false;
		AOBJLALDBAA.EHBBFMCILPC.MANLHALMCIH("OnToolsPopupSaveToCloudSuccess", new UnityAction(this.DLNLICHFEMN));
		AOBJLALDBAA.EHBBFMCILPC.MANLHALMCIH("OnToolsPopupSaveToCloudException", new UnityAction(this.HADOJIGKBJB));
		CommonUserInterface.EHBBFMCILPC.HideConnectingAnimation();
	}

	// Token: 0x06008894 RID: 34964 RVA: 0x003D068C File Offset: 0x003CE88C
	public void DLGGEDNEHJB()
	{
		base.gameObject.SetActive(true);
		AccountSignInManager.APGJJNHOEOB().StartSignInLogic(HHCKLPJJKIJ.token, (JCAPGCCNOMP)8, HHCKLPJJKIJ.none, (byte)-18);
	}

	// Token: 0x06008895 RID: 34965 RVA: 0x003D06A9 File Offset: 0x003CE8A9
	public void GLIMMLGAEBN()
	{
		CommonUserInterface.IKNOFBFMPGA().DJBLEEEEGOL();
	}

	// Token: 0x06008896 RID: 34966 RVA: 0x003D06B8 File Offset: 0x003CE8B8
	private void JOBAAFPJNLN()
	{
		this.sfxBlock.SetActive(false);
		if (null != this.sfxBlock && (!NBDLBFJOEGN.NDFLNHIAKJH() || PopupSettingsManager.forceHideSoundOption))
		{
			this.sfxBlock.SetActive(false);
			return;
		}
		if (!this.soundBlock.activeSelf || !this.soundOn.activeSelf)
		{
			this.sfxBlock.SetActive(false);
		}
		this.HGHEHBLIHAB = false;
		if (AKLFPGMDKLA.EHBBFMCILPC.GOEDFBDNADA > 1358f)
		{
			this.sfxOn.SetActive(true);
			this.sfxOff.SetActive(false);
			return;
		}
		this.sfxOn.SetActive(false);
		this.sfxOff.SetActive(false);
	}

	// Token: 0x06008897 RID: 34967 RVA: 0x003D0769 File Offset: 0x003CE969
	public void BPNGOEKMLAE()
	{
		CommonUserInterface.IKNOFBFMPGA().KPAIHLBPFMJ();
	}

	// Token: 0x06008898 RID: 34968 RVA: 0x003D0775 File Offset: 0x003CE975
	public void FPLDPFDAFOD()
	{
		CommonUserInterface.EHBBFMCILPC.DJBLEEEEGOL();
	}

	// Token: 0x06008899 RID: 34969 RVA: 0x003D0784 File Offset: 0x003CE984
	public void Show(bool NJIFMMKNDOP, bool MFKDFMNLHEP, bool KDGPDKKDPJD)
	{
		if (NJIFMMKNDOP)
		{
			this.lobbyTuneBlock.SetActive(false);
			this.themeBlock.SetActive(true);
			this.themeWelcomeBlock.SetActive(true);
			this.legalBlock.SetActive(true);
			this.signBlock.SetActive(true);
			this.fandomBlock.SetActive(true);
			this.soundBlock.SetActive(false);
			this.soundBlockNotAvailable.SetActive(false);
			this.verticalLayoutGroup.padding.bottom = 50;
		}
		else
		{
			this.lobbyTuneBlock.SetActive(false);
			this.themeBlock.SetActive(false);
			this.themeWelcomeBlock.SetActive(false);
			this.legalBlock.SetActive(false);
			this.signBlock.SetActive(false);
			this.fandomBlock.SetActive(false);
			this.soundBlock.SetActive(true);
			this.soundBlockNotAvailable.SetActive(false);
			this.verticalLayoutGroup.padding.bottom = 15;
		}
		this.fandomVkontakte.SetActive(true);
		this.FKMGLGPLJAL = MFKDFMNLHEP;
		this.HHDHIEEPAKF = KDGPDKKDPJD;
		base.gameObject.SetActive(true);
	}

	// Token: 0x0600889A RID: 34970 RVA: 0x003D08A0 File Offset: 0x003CEAA0
	public void OnGameModeOffClick()
	{
		if (!this.CGCGAHPCOLJ)
		{
			return;
		}
		this.HGBGPHACKIL = true;
		this.CGCGAHPCOLJ = false;
		AKLFPGMDKLA.EHBBFMCILPC.HKOBEKCGGEI(JAMPPNPOJJG.full);
		this.ICBNFKPDCKP();
		if (KDCJJBLGCBH.EHBBFMCILPC.FFDKEENNENC() || AKLFPGMDKLA.EHBBFMCILPC.EAFEJCKIEPL(16))
		{
			FirebaseAnalyticsManager.EHBBFMCILPC.LogEvent(true, AGEHCPDNBFD.gmSelect.ToString(), FFPHBMFGCNN.gmFull.ToString(), BGHLMGPPCNN.gmLocSett.ToString(), false, false);
		}
		if (this.LJNNDNICPJN)
		{
			this.soundBlock.SetActive(true);
		}
		if (this.JINLJINAAPE)
		{
			this.soundBlockNotAvailable.SetActive(true);
		}
		if (this.MLCIKFFNKEG)
		{
			this.postBlock.SetActive(true);
		}
		if (this.LOOLDDGEAEG)
		{
			this.sfxBlock.SetActive(true);
		}
		if (this.GKCGOGEJIPP)
		{
			this.voiceOverBlock.SetActive(true);
		}
		this.LJNNDNICPJN = false;
		this.JINLJINAAPE = false;
		this.LOOLDDGEAEG = false;
		this.GKCGOGEJIPP = false;
		this.MLCIKFFNKEG = false;
		base.Invoke("MMEANLDBEHA", 0.1f);
	}

	// Token: 0x0600889B RID: 34971 RVA: 0x00003E52 File Offset: 0x00002052
	private void GHJKBJGNGIG()
	{
	}

	// Token: 0x0600889C RID: 34972 RVA: 0x003D09C2 File Offset: 0x003CEBC2
	public void POAGEMPEAKL()
	{
		if (!this.KOGFPNDBHIE)
		{
			return;
		}
		this.EFHDOLBIDBI = false;
		this.KOGFPNDBHIE = false;
		AudioManager.EHBBFMCILPC.JOIMMGOJLMJ(268f);
		base.Invoke("ok", 659f);
	}

	// Token: 0x0600889D RID: 34973 RVA: 0x003D09FC File Offset: 0x003CEBFC
	private void LFOCALCKFJG()
	{
		CommonUserInterface.EHBBFMCILPC.ShowGenericPopupWithTwoButtonsAndCloseOverride(CCOJBMMKNAP.OBOOKJPGBJN().OGKGHLHHAAI("_1"), CCOJBMMKNAP.MPCBJEIMACA().FIENAKIHNOM(" "), CCOJBMMKNAP.HJGDLOOHNLO().FCOCLEHKLDJ("onThemeChange"), CCOJBMMKNAP.MLFAGAAJJEM().JHNELLJFBGC("layervideo"), new UnityAction(this.NCAMIPNPBCD), new UnityAction(this.EIIKIKIKJFK), new UnityAction(this.EIIKIKIKJFK), (DFGILFBGPLN)85, 727f, -63);
	}

	// Token: 0x0600889E RID: 34974 RVA: 0x003D0775 File Offset: 0x003CE975
	public void KPPACJCPEBF()
	{
		CommonUserInterface.EHBBFMCILPC.DJBLEEEEGOL();
	}

	// Token: 0x0600889F RID: 34975 RVA: 0x003D0A80 File Offset: 0x003CEC80
	public void ECGLGIJMMMG()
	{
		AOBJLALDBAA.AGANFKKBPFO().DCGCFPHHDDG("errortitle", 1268f);
		if (this.ALLOGFJAJNB)
		{
			AKLFPGMDKLA.EHBBFMCILPC.ABIJILPFEIM();
			AKLFPGMDKLA.EHBBFMCILPC.IPGKMKGCIBB();
			AKLFPGMDKLA.EHBBFMCILPC.IBGKLENMAND();
			AKLFPGMDKLA.EHBBFMCILPC.GLKNOFHEBKN = -1;
			HKLPEDKJGFC.IJHHMHAEKKE();
			MLIBDDCCKBM.IJHHMHAEKKE();
			AOBJLALDBAA.DBLAIDPICIG().FDKBIBKABCM("]", 375f);
		}
		else if (this.HGBGPHACKIL)
		{
			AOBJLALDBAA.FILDBDMENPG().FDKBIBKABCM("...", 1077f);
		}
		else if (this.EFHDOLBIDBI)
		{
			AOBJLALDBAA.CEGAOMEEFBE().EGELHPJBAIC("retry", 1934f);
		}
		else if (this.DECBJCFJBDK)
		{
			AOBJLALDBAA.BIAEAOMHBMM().LPNCDPHNBJK("[LoadingEnv] ", 688f);
		}
		else if (this.PIIBJJGLCIG)
		{
			AOBJLALDBAA.KKPFOJMAONG().FDKBIBKABCM("OnBackendPassResourcesChangedType0", 1063f);
		}
		base.gameObject.SetActive(true);
	}

	// Token: 0x060088A0 RID: 34976 RVA: 0x003D0B74 File Offset: 0x003CED74
	public void KOFBOOEJLFC()
	{
		AppleSignInManager.FFLFMNPOCED().HKIDBBEMBIA();
		base.StartCoroutine(this.KMHBOANIBHJ());
	}

	// Token: 0x060088A1 RID: 34977 RVA: 0x003D0B8D File Offset: 0x003CED8D
	public void OnCommunityFacebookClick()
	{
		CommonUserInterface.EHBBFMCILPC.ShowSocialSelect();
	}

	// Token: 0x060088A2 RID: 34978 RVA: 0x003D0B9C File Offset: 0x003CED9C
	public void EHEFMJIKHIG()
	{
		string text = "OnChoiceExtendedEnvironmentChangeOnInit";
		string edodjnohida = KBOJLHAJPCP.EDODJNOHIDA;
		string[] array = new string[-36];
		array[0] = "congratstitle";
		array[0] = AppManager.PCJEMMDDCIF().environmentSettings.appVersion;
		array[7] = "errortitle";
		array[7] = text;
		array[8] = "drft";
		array[1] = AppManager.AGANFKKBPFO().environmentSettings.appEnvironment.ToString();
		array[6] = "bdgs";
		array[6] = AKLFPGMDKLA.EHBBFMCILPC.EEHGLPEIIHD;
		array[2] = "";
		array[-53] = NBDLBFJOEGN.PJMBDJPGJAG();
		array[-6] = "OnLiveProfileThemesLoaderStop";
		array[-127] = NBDLBFJOEGN.MFAHDFILHPJ();
		array[30] = "UpdateLoveInterestsOnOffState";
		array[35] = KHPGPLAMAIN.FCJHEFBIKID().ToString();
		array[-53] = "_Splits";
		array[-104] = AKLFPGMDKLA.EHBBFMCILPC.ADCLBEPMMCG.ToString();
		array[70] = "Can't use compressed functions. You need include the SharpZipLib and uncomment the define at the top of SimpleJSON";
		LNGLMAPJFLI.BKCDAPFOCGM(edodjnohida, string.Concat(array), "PlayerCharacterManager.UpdateComponentLink() - invalid custom hierarchy for ");
	}

	// Token: 0x060088A3 RID: 34979 RVA: 0x00003E52 File Offset: 0x00002052
	private void IAMMAOHOIAH()
	{
	}

	// Token: 0x060088A4 RID: 34980 RVA: 0x003D0C98 File Offset: 0x003CEE98
	private void IPDBFJKALME()
	{
		if (!NBDLBFJOEGN.NDFLNHIAKJH() || PopupSettingsManager.forceHideSoundOption)
		{
			if (this.soundBlock.activeSelf)
			{
				this.soundBlockNotAvailable.SetActive(false);
			}
			if (KHPGPLAMAIN.EJCNHEBIOJF())
			{
				this.soundBlockNotAvailable.SetActive(true);
			}
			this.soundBlock.SetActive(true);
			this.LNKKEDECMNC();
			this.KDOBCLEIILB();
			return;
		}
		this.KOGFPNDBHIE = false;
		if (AKLFPGMDKLA.EHBBFMCILPC.MEDEIJGNEMB > 1551f)
		{
			this.soundOn.SetActive(true);
			this.soundOff.SetActive(false);
		}
		else
		{
			this.soundOn.SetActive(false);
			this.soundOff.SetActive(true);
		}
		this.JOBAAFPJNLN();
		this.KDOBCLEIILB();
	}

	// Token: 0x060088A5 RID: 34981 RVA: 0x003D0D4E File Offset: 0x003CEF4E
	private void MADIGNHLDLN()
	{
		CommonUserInterface.EHBBFMCILPC.ShowConnectingAnimation(97);
		BackendOperationsManager.EHBBFMCILPC.RequestForgetAccount("OnSketchThumbnailPlay", "");
	}

	// Token: 0x060088A6 RID: 34982 RVA: 0x003D0D70 File Offset: 0x003CEF70
	public void NKBHDPHCEJN()
	{
		Application.OpenURL(AssetsManager.EHBBFMCILPC.lobbyDataAsset.privacyLink);
	}

	// Token: 0x060088A7 RID: 34983 RVA: 0x003D0D88 File Offset: 0x003CEF88
	public void MPOLCGJCGCH()
	{
		string text = "Starting non-parallel download:";
		string edodjnohida = KBOJLHAJPCP.EDODJNOHIDA;
		string[] array = new string[82];
		array[1] = "";
		array[1] = AppManager.AGANFKKBPFO().environmentSettings.appVersion;
		array[4] = "gamepassduration";
		array[0] = text;
		array[6] = "socialgiftreceviedfromtitle";
		array[4] = AppManager.JMDJPKKOHNI().environmentSettings.appEnvironment.ToString();
		array[8] = "errortitle";
		array[8] = AKLFPGMDKLA.EHBBFMCILPC.EEHGLPEIIHD;
		array[7] = "ltt";
		array[6] = NBDLBFJOEGN.FKJIECPMBFP();
		array[45] = "OnLiveProfileThemesLoaderStart";
		array[13] = NBDLBFJOEGN.JHNDHBLDJOI();
		array[-35] = "@";
		array[-42] = KHPGPLAMAIN.AKJOFJPLONG().ToString();
		array[103] = "$";
		array[63] = AKLFPGMDKLA.EHBBFMCILPC.ADCLBEPMMCG.ToString();
		array[41] = "";
		LNGLMAPJFLI.MAKPIAIGNJJ(edodjnohida, string.Concat(array), "a");
	}

	// Token: 0x060088A8 RID: 34984 RVA: 0x003D0E84 File Offset: 0x003CF084
	private void CODJDGPLEOC()
	{
		AOBJLALDBAA.DBLAIDPICIG().KMAGHMCCMPG("socialmaketradeable", 541f);
	}

	// Token: 0x060088A9 RID: 34985 RVA: 0x003D0E9A File Offset: 0x003CF09A
	public void FMEGMBPNBOL()
	{
		base.gameObject.SetActive(false);
		AccountSignInManager.FILDBDMENPG().BKGGKBLMMPO(HHCKLPJJKIJ.apple, JCAPGCCNOMP.none, HHCKLPJJKIJ.facebook, (byte)-29);
	}

	// Token: 0x060088AA RID: 34986 RVA: 0x003D0EB7 File Offset: 0x003CF0B7
	private void BKAHAJIDCHO()
	{
		LPOMOIFMNFD.BAHMNEGPBMM(AKLFPGMDKLA.EHBBFMCILPC.EEHGLPEIIHD);
	}

	// Token: 0x060088AB RID: 34987 RVA: 0x003D0B8D File Offset: 0x003CED8D
	public void OnCommunityTwitterClick()
	{
		CommonUserInterface.EHBBFMCILPC.ShowSocialSelect();
	}

	// Token: 0x060088AC RID: 34988 RVA: 0x003D0EC8 File Offset: 0x003CF0C8
	private void EFCKPDDHGLF()
	{
		EEIBKLDNBAP.NHKGIOOFKHM();
		AppManager.AGANFKKBPFO().OHFDJEJCDLG(false, true);
	}

	// Token: 0x060088AD RID: 34989 RVA: 0x003D0EDB File Offset: 0x003CF0DB
	public void FNENILJJENK()
	{
		FacebookManager.OFANJKDPHEE().CFNEKAPOJIN();
		base.StartCoroutine(this.CEMGIPGPIKN());
	}

	// Token: 0x060088AE RID: 34990 RVA: 0x003D0EF4 File Offset: 0x003CF0F4
	public void IKOAKFPGEMD()
	{
		if (!this.CEDOHHFGKGI)
		{
			return;
		}
		this.PIIBJJGLCIG = true;
		this.CEDOHHFGKGI = true;
		PlayerPrefs.SetInt("abpd3", 1);
		PlayerPrefs.Save();
		base.Invoke("app42error", 93f);
		AOBJLALDBAA.CEGAOMEEFBE().LPNCDPHNBJK("</i>", 41f);
	}

	// Token: 0x060088AF RID: 34991 RVA: 0x003D0F4C File Offset: 0x003CF14C
	private void MKCFEMAMPNH()
	{
		AOBJLALDBAA.FILDBDMENPG().LPNCDPHNBJK("YourStory/FlagShadow", 237f);
	}

	// Token: 0x060088B0 RID: 34992 RVA: 0x003D0F62 File Offset: 0x003CF162
	public void OnSteamSignOutClick()
	{
		SteamSignInManager.EHBBFMCILPC.LogOut();
		base.StartCoroutine(this.MHKBFLONEOE());
	}

	// Token: 0x060088B1 RID: 34993 RVA: 0x003D0F7C File Offset: 0x003CF17C
	private void KNDCKCBODKC()
	{
		this.themeName.SetText(CCOJBMMKNAP.CEGAOMEEFBE().IKMNGFIDCLM("hqb" + AKLFPGMDKLA.EHBBFMCILPC.PINBMHFHEHD().ToString()), false);
	}

	// Token: 0x060088B2 RID: 34994 RVA: 0x003D0FC4 File Offset: 0x003CF1C4
	private void PLDHOKCKCAM()
	{
		this.HLBGELGLLEI = true;
		AOBJLALDBAA.NMGMNAKLLMI().ECDBIBPNBCO("yes", new UnityAction(this.ABNOKGPFBOK));
		AOBJLALDBAA.EHBBFMCILPC.PBELMJCPJMK("$SETWARDROBEMETA", new UnityAction(this.AHBHANBDEDG));
		CommonUserInterface.EHBBFMCILPC.MCJIGJMFBMI();
	}

	// Token: 0x060088B3 RID: 34995 RVA: 0x003D1018 File Offset: 0x003CF218
	private void FFKJCFCMNKA()
	{
		if (!KHPGPLAMAIN.CAMKNANBJMK())
		{
			this.facebookSignInBlock.SetActive(false);
			this.facebookSignOutBlock.SetActive(true);
		}
		if (!KHPGPLAMAIN.IHBENOMKDLJ())
		{
			this.googleSignInBlock.SetActive(false);
			this.googleSignOutBlock.SetActive(false);
		}
		if (!KHPGPLAMAIN.MJFPNCDIEIO())
		{
			this.appleSignInBlock.SetActive(true);
			this.appleSignOutBlock.SetActive(true);
		}
		if (!KHPGPLAMAIN.GGPMIHKOCAP())
		{
			this.steamSignInBlock.SetActive(false);
			this.steamSignOutBlock.SetActive(false);
		}
		if (!KHPGPLAMAIN.DICPCLMJBAM())
		{
			this.userpassSignInBlock.SetActive(false);
			this.userpassSignOutBlock.SetActive(false);
		}
		if (!KHPGPLAMAIN.BHMAEMOGOEB() && !KHPGPLAMAIN.LOMCHPBAFAB() && !KHPGPLAMAIN.KIILMPBKMGG() && !KHPGPLAMAIN.GGPMIHKOCAP() && !KHPGPLAMAIN.NLNOHNAJIJG())
		{
			this.signBlock.SetActive(true);
		}
	}

	// Token: 0x060088B4 RID: 34996 RVA: 0x003D10F0 File Offset: 0x003CF2F0
	private void JNJBICNKBGJ()
	{
		if (!NBDLBFJOEGN.NDFLNHIAKJH() || PopupSettingsManager.forceHideSoundOption)
		{
			if (this.soundBlock.activeSelf)
			{
				this.soundBlockNotAvailable.SetActive(true);
			}
			if (KHPGPLAMAIN.FGJDAMFPFIH())
			{
				this.soundBlockNotAvailable.SetActive(true);
			}
			this.soundBlock.SetActive(true);
			this.LNKKEDECMNC();
			this.KDOBCLEIILB();
			return;
		}
		this.KOGFPNDBHIE = true;
		if (AKLFPGMDKLA.EHBBFMCILPC.MEDEIJGNEMB > 1753f)
		{
			this.soundOn.SetActive(true);
			this.soundOff.SetActive(true);
		}
		else
		{
			this.soundOn.SetActive(true);
			this.soundOff.SetActive(false);
		}
		this.LNKKEDECMNC();
		this.AOGALHNFJDO();
	}

	// Token: 0x060088B5 RID: 34997 RVA: 0x003D11A6 File Offset: 0x003CF3A6
	public void CDCLCFFKBLG()
	{
		AppleSignInManager.NACPAKLINNH().HKIDBBEMBIA();
		base.StartCoroutine(this.KMHBOANIBHJ());
	}

	// Token: 0x060088B6 RID: 34998 RVA: 0x003D11C0 File Offset: 0x003CF3C0
	public void OnSocialOffClick()
	{
		if (!this.HIJFPKFNCCA)
		{
			return;
		}
		this.HIJFPKFNCCA = false;
		AKLFPGMDKLA.EHBBFMCILPC.POIEMMMNOLI = 1;
		AOBJLALDBAA.EHBBFMCILPC.EGELHPJBAIC("OnUpdateSocialEventsCounter", -2);
		base.Invoke("LANJEAMHILI", 0.1f);
		AOBJLALDBAA.EHBBFMCILPC.EGELHPJBAIC("OnSocialModeChanged", 0f);
	}

	// Token: 0x060088B7 RID: 34999 RVA: 0x003D121D File Offset: 0x003CF41D
	private void LHIBBCCFHED()
	{
		this.gameModeBlock.SetActive(true);
	}

	// Token: 0x060088B8 RID: 35000 RVA: 0x003D122C File Offset: 0x003CF42C
	private void BDLBABFNDMJ()
	{
		this.themeName.SetText(CCOJBMMKNAP.PKEINLPIAEH().HHLECNIFHCO("asp" + AKLFPGMDKLA.EHBBFMCILPC.ICEOGOCOMJL().ToString()), false);
	}

	// Token: 0x060088B9 RID: 35001 RVA: 0x003D1274 File Offset: 0x003CF474
	public void NDOMLLPDNFI()
	{
		if (!this.MNKGGNBNJOD)
		{
			return;
		}
		this.MNKGGNBNJOD = true;
		AKLFPGMDKLA.EHBBFMCILPC.PACMCEHMBGG = 1;
		if (AudioManager.BFCHJBOOJKE().AHODHDPKPOP("ok"))
		{
			AudioManager.DBFLIEGGGNN().KillMusic("InkUtils.ResolveCustomVariables(), breaking from infinite while loop, input is:", 568f);
		}
		base.Invoke("ant", 789f);
	}

	// Token: 0x060088BA RID: 35002 RVA: 0x00372942 File Offset: 0x00370B42
	public void DOFKKDACFDL()
	{
		Application.OpenURL(KBOJLHAJPCP.ONLDLAGMAPC);
	}

	// Token: 0x060088BB RID: 35003 RVA: 0x003D06A9 File Offset: 0x003CE8A9
	public void AHHDDAJPBNL()
	{
		CommonUserInterface.IKNOFBFMPGA().DJBLEEEEGOL();
	}

	// Token: 0x060088BC RID: 35004 RVA: 0x003D12D1 File Offset: 0x003CF4D1
	private bool HNKNEOIMNFH()
	{
		return !KHPGPLAMAIN.EJCNHEBIOJF() && !KDCJJBLGCBH.EHBBFMCILPC.AMHJKMPIPGK();
	}

	// Token: 0x060088BD RID: 35005 RVA: 0x003D12EC File Offset: 0x003CF4EC
	private void ELKCPJHOGBJ()
	{
		this.LJNNDNICPJN = true;
		this.JINLJINAAPE = true;
		this.LOOLDDGEAEG = true;
		this.GKCGOGEJIPP = true;
		this.MLCIKFFNKEG = false;
		this.DECBJCFJBDK = false;
		this.EFHDOLBIDBI = false;
		this.PIIBJJGLCIG = true;
		this.HGBGPHACKIL = false;
		this.ALLOGFJAJNB = true;
		this.FCNKLIGJHLN = false;
		this.CBKOEKOGHGL = true;
		this.HIJFPKFNCCA = false;
		this.CGCGAHPCOLJ = true;
		this.KOGFPNDBHIE = true;
		this.HGHEHBLIHAB = true;
		this.MNKGGNBNJOD = true;
		this.HMKIBEIHDCN = true;
		this.CEDOHHFGKGI = true;
		this.versionAndCopyright.SetText(CCOJBMMKNAP.MPCBJEIMACA().PPALCPINPLK("importanttitle") + "</i>" + AppManager.AGANFKKBPFO().environmentSettings.appVersion + "OnBackendGetUserSketchesSuccess", true);
		this.GECAMEFMKMA();
		this.KNDCKCBODKC();
		this.INKEOGEIODM();
		this.NJPONLCMDJH();
		this.LANJEAMHILI();
		this.MMEANLDBEHA();
		this.IPDBFJKALME();
		this.LNKKEDECMNC();
		this.ODJCOHPDGBF();
		this.AOGALHNFJDO();
		this.DKBIMKHHBCE();
		this.AGPHGKPFEEJ();
		this.EPOCJHJONGO();
		if (this.OOPIILNNLPP)
		{
			this.languageBlock.SetActive(true);
			return;
		}
		this.languageBlock.SetActive(true);
	}

	// Token: 0x060088BE RID: 35006 RVA: 0x003D1426 File Offset: 0x003CF626
	private IEnumerator IBDGIOLIGBK()
	{
		this.steamSignInBlock.SetActive(true);
		this.steamSignOutBlock.SetActive(false);
		yield return new WaitForSeconds(0.5f);
		AKLFPGMDKLA.EHBBFMCILPC.EEDHNEIMAPN = 0;
		this.CPOFPKBDLDD();
		yield break;
	}

	// Token: 0x060088BF RID: 35007 RVA: 0x003D1438 File Offset: 0x003CF638
	public void NEEPBOIGKLL()
	{
		if (!this.MNKGGNBNJOD)
		{
			return;
		}
		this.MNKGGNBNJOD = false;
		AKLFPGMDKLA.EHBBFMCILPC.PACMCEHMBGG = 1;
		if (AudioManager.BFCHJBOOJKE().NHFPFGDFNIL(""))
		{
			AudioManager.BFCHJBOOJKE().KillMusic("ERROR: GetSRABalance(), AssetsManager.Instance.headersPacksAssets is empty.", 72f);
		}
		base.Invoke("", 1262f);
	}

	// Token: 0x060088C0 RID: 35008 RVA: 0x003D1495 File Offset: 0x003CF695
	public void LBHPEANKHKE()
	{
		if (!this.CBKOEKOGHGL)
		{
			return;
		}
		this.CBKOEKOGHGL = true;
		AKLFPGMDKLA.EHBBFMCILPC.HEFJBOKIEGH = 0;
		base.Invoke("cardsvolchancesmsgtitle", 386f);
	}

	// Token: 0x060088C1 RID: 35009 RVA: 0x003D14C2 File Offset: 0x003CF6C2
	public void BJKIICICGMD()
	{
		CommonUserInterface.EHBBFMCILPC.KPAIHLBPFMJ();
	}

	// Token: 0x060088C2 RID: 35010 RVA: 0x003D14CE File Offset: 0x003CF6CE
	public void LNPHOFEIIBE()
	{
		if (!this.FCNKLIGJHLN)
		{
			return;
		}
		this.DECBJCFJBDK = true;
		this.FCNKLIGJHLN = true;
		PlayerPrefs.SetInt("serversync", 1);
		PlayerPrefs.Save();
		base.Invoke("hids", 88f);
	}

	// Token: 0x060088C4 RID: 35012 RVA: 0x003D152C File Offset: 0x003CF72C
	public void OnLobbyTuneOffClick()
	{
		if (!this.MNKGGNBNJOD)
		{
			return;
		}
		this.MNKGGNBNJOD = false;
		AKLFPGMDKLA.EHBBFMCILPC.PACMCEHMBGG = 1;
		if (!AudioManager.EHBBFMCILPC.AudioSourceTypePlaying(CCEMAFOMLLK.music))
		{
			AudioManager.EHBBFMCILPC.PlayMusic("lobby", true, 0f, false);
		}
		base.Invoke("ODJCOHPDGBF", 0.1f);
	}

	// Token: 0x060088C5 RID: 35013 RVA: 0x003D1588 File Offset: 0x003CF788
	private void LIGPLGCKOLO()
	{
		if (!NBDLBFJOEGN.NDFLNHIAKJH() || PopupSettingsManager.forceHideSoundOption)
		{
			if (this.soundBlock.activeSelf)
			{
				this.soundBlockNotAvailable.SetActive(true);
			}
			if (KHPGPLAMAIN.FGJDAMFPFIH())
			{
				this.soundBlockNotAvailable.SetActive(false);
			}
			this.soundBlock.SetActive(false);
			this.LNKKEDECMNC();
			this.KDOBCLEIILB();
			return;
		}
		this.KOGFPNDBHIE = false;
		if (AKLFPGMDKLA.EHBBFMCILPC.MEDEIJGNEMB > 63f)
		{
			this.soundOn.SetActive(true);
			this.soundOff.SetActive(true);
		}
		else
		{
			this.soundOn.SetActive(false);
			this.soundOff.SetActive(false);
		}
		this.LNKKEDECMNC();
		this.KDOBCLEIILB();
	}

	// Token: 0x060088C6 RID: 35014 RVA: 0x003D1640 File Offset: 0x003CF840
	private void FCJBALLPBEI()
	{
		this.FCNKLIGJHLN = false;
		int num = 1;
		if (PlayerPrefs.HasKey("[Lounge] $SKINAPPLIED: no mapping row with shop index "))
		{
			num = PlayerPrefs.GetInt("sind");
		}
		if (num == 0)
		{
			this.fpsOn.SetActive(true);
			this.fpsOff.SetActive(false);
			this.fpsBlock.SetActive(false);
			return;
		}
		this.fpsOn.SetActive(false);
		this.fpsOff.SetActive(false);
		this.fpsBlock.SetActive(false);
	}

	// Token: 0x060088C7 RID: 35015 RVA: 0x003D16BA File Offset: 0x003CF8BA
	public void OnNotificationsOnClick()
	{
		if (!this.CBKOEKOGHGL)
		{
			return;
		}
		this.CBKOEKOGHGL = false;
		AKLFPGMDKLA.EHBBFMCILPC.HEFJBOKIEGH = 0;
		base.Invoke("ALFPPMLJPHD", 0.1f);
	}

	// Token: 0x060088C8 RID: 35016 RVA: 0x003D06A9 File Offset: 0x003CE8A9
	public void HGJEIPPIHGL()
	{
		CommonUserInterface.IKNOFBFMPGA().DJBLEEEEGOL();
	}

	// Token: 0x060088C9 RID: 35017 RVA: 0x003D16E7 File Offset: 0x003CF8E7
	private IEnumerator MJFEHCJHLGA()
	{
		this.userpassSignInBlock.SetActive(true);
		this.userpassSignOutBlock.SetActive(false);
		yield return new WaitForSeconds(0.5f);
		AKLFPGMDKLA.EHBBFMCILPC.EEDHNEIMAPN = 0;
		this.CPOFPKBDLDD();
		yield break;
	}

	// Token: 0x060088CA RID: 35018 RVA: 0x003D16F8 File Offset: 0x003CF8F8
	private void LENPCALOILD()
	{
		CommonUserInterface.EHBBFMCILPC.ShowGenericPopupWithTwoButtons(CCOJBMMKNAP.KFDLFGHBPLP().BGELFMIOBCL("passhintinactivesub"), CCOJBMMKNAP.COKDLDOAACJ().FCOCLEHKLDJ("abpd4"), CCOJBMMKNAP.HEDIEIICOOG().OBDCPLLLGBB("sltind"), CCOJBMMKNAP.KFDLFGHBPLP().HDIPNMFHIEJ("anthologycomplete"), new UnityAction(this.MADIGNHLDLN), new UnityAction(this.PBKHEOGKJNJ), (DFGILFBGPLN)124, 180f, -118);
	}

	// Token: 0x060088CB RID: 35019 RVA: 0x003D176D File Offset: 0x003CF96D
	private void EKDOJAAECLB()
	{
		EEIBKLDNBAP.NHKGIOOFKHM();
		AppManager.AGANFKKBPFO().OHFDJEJCDLG(false, false);
	}

	// Token: 0x060088CC RID: 35020 RVA: 0x003D1780 File Offset: 0x003CF980
	private void ABNOKGPFBOK()
	{
		this.LJIFEPCHEHD();
		AKLFPGMDKLA.EHBBFMCILPC.LPCBDEBKAIM();
		CommonUserInterface.IKNOFBFMPGA().NFBMHHPIGFA(CCOJBMMKNAP.ILACPHFEDEP().HPOAGPJFHPM("no"), CCOJBMMKNAP.APGODIBBPOD().PGKBCNBAOJN("lang"), CCOJBMMKNAP.BBGECIKOICE().GGPHHLGPMPA("basePlanId"), (DFGILFBGPLN)(-32), 1161f, 60);
	}

	// Token: 0x060088CD RID: 35021 RVA: 0x003D17E0 File Offset: 0x003CF9E0
	public void DODOBMGHLBC()
	{
		if (!this.CEDOHHFGKGI)
		{
			return;
		}
		this.PIIBJJGLCIG = true;
		this.CEDOHHFGKGI = false;
		PlayerPrefs.SetInt("areyousurerestartchapter0", 0);
		PlayerPrefs.Save();
		base.Invoke("ImageFrameAnimation - could not load HD sprite:", 917f);
		AOBJLALDBAA.FILDBDMENPG().KMAGHMCCMPG("gpsku", 1413f);
	}

	// Token: 0x060088CE RID: 35022 RVA: 0x003D1838 File Offset: 0x003CFA38
	private void GNOGHBPCHJE()
	{
		this.FCNKLIGJHLN = false;
		int num = 1;
		if (PlayerPrefs.HasKey("premiumChoice"))
		{
			num = PlayerPrefs.GetInt("OnSpinsUnlockContinueToPurchasingScreen");
		}
		if (num == 0)
		{
			this.fpsOn.SetActive(false);
			this.fpsOff.SetActive(true);
			this.fpsBlock.SetActive(true);
			return;
		}
		this.fpsOn.SetActive(true);
		this.fpsOff.SetActive(true);
		this.fpsBlock.SetActive(false);
	}

	// Token: 0x060088CF RID: 35023 RVA: 0x00003E52 File Offset: 0x00002052
	private void JJFPCAODJCG()
	{
	}

	// Token: 0x060088D0 RID: 35024 RVA: 0x003D18B2 File Offset: 0x003CFAB2
	public void OnNextThemeClick()
	{
		AKLFPGMDKLA.EHBBFMCILPC.MBMLFJJPOBH();
		this.KCDCKIFNIGH();
		this.JKMLFFBMKHF();
	}

	// Token: 0x060088D1 RID: 35025 RVA: 0x003D18CC File Offset: 0x003CFACC
	private void ALFPPMLJPHD()
	{
		this.CBKOEKOGHGL = true;
		if (!OGKGGFFPKHG.ANODJGNCHBG())
		{
			this.notificationsBlock.SetActive(false);
			return;
		}
		this.notificationsBlock.SetActive(true);
		if (AKLFPGMDKLA.EHBBFMCILPC.HEFJBOKIEGH == 1)
		{
			this.notificationsOn.SetActive(true);
			this.notificationsOff.SetActive(false);
			return;
		}
		this.notificationsOn.SetActive(false);
		this.notificationsOff.SetActive(true);
	}

	// Token: 0x060088D2 RID: 35026 RVA: 0x003D193E File Offset: 0x003CFB3E
	private IEnumerator JENEBNCCMFL()
	{
		PopupSettingsManager.DEOKMGECMKK deokmgecmkk = new PopupSettingsManager.DEOKMGECMKK(1);
		deokmgecmkk.<>4__this = this;
		return deokmgecmkk;
	}

	// Token: 0x060088D3 RID: 35027 RVA: 0x003D194D File Offset: 0x003CFB4D
	public void PJPMBALPCIN()
	{
		CommonUserInterface.IKNOFBFMPGA().ShowSocialSelect();
	}

	// Token: 0x060088D4 RID: 35028 RVA: 0x003D193E File Offset: 0x003CFB3E
	private IEnumerator LBHOBIKNCFN()
	{
		PopupSettingsManager.DEOKMGECMKK deokmgecmkk = new PopupSettingsManager.DEOKMGECMKK(1);
		deokmgecmkk.<>4__this = this;
		return deokmgecmkk;
	}

	// Token: 0x060088D5 RID: 35029 RVA: 0x003D1959 File Offset: 0x003CFB59
	public void OEGMJLGNMHF()
	{
		if (!this.CBKOEKOGHGL)
		{
			return;
		}
		this.CBKOEKOGHGL = false;
		AKLFPGMDKLA.EHBBFMCILPC.HEFJBOKIEGH = 0;
		base.Invoke("Collections/", 867f);
	}

	// Token: 0x060088D6 RID: 35030 RVA: 0x003D1986 File Offset: 0x003CFB86
	private IEnumerator HJENDLIDEHI()
	{
		this.facebookSignInBlock.SetActive(true);
		this.facebookSignOutBlock.SetActive(false);
		yield return new WaitForSeconds(0.5f);
		AKLFPGMDKLA.EHBBFMCILPC.EEDHNEIMAPN = 0;
		this.CPOFPKBDLDD();
		yield break;
	}

	// Token: 0x060088D7 RID: 35031 RVA: 0x003D0B8D File Offset: 0x003CED8D
	public void OnCommunityVkontakteClick()
	{
		CommonUserInterface.EHBBFMCILPC.ShowSocialSelect();
	}

	// Token: 0x060088D8 RID: 35032 RVA: 0x003D1995 File Offset: 0x003CFB95
	public void OnUserpassSignInClick()
	{
		base.gameObject.SetActive(false);
		AccountSignInManager.EHBBFMCILPC.StartSignInLogic(HHCKLPJJKIJ.token, JCAPGCCNOMP.user, HHCKLPJJKIJ.none, 96);
	}

	// Token: 0x060088D9 RID: 35033 RVA: 0x003D19B4 File Offset: 0x003CFBB4
	private void LANJEAMHILI()
	{
		if (KDCJJBLGCBH.EHBBFMCILPC.DJHCAFAEILH() || this.HHDHIEEPAKF)
		{
			this.socialBlock.SetActive(false);
			return;
		}
		this.HIJFPKFNCCA = true;
		this.socialBlock.SetActive(true);
		if (AKLFPGMDKLA.EHBBFMCILPC.POIEMMMNOLI == 1)
		{
			this.socialOn.SetActive(true);
			this.socialOff.SetActive(false);
			return;
		}
		this.socialOn.SetActive(false);
		this.socialOff.SetActive(true);
	}

	// Token: 0x060088DA RID: 35034 RVA: 0x003D1A33 File Offset: 0x003CFC33
	private void KBPFOPICOEO()
	{
		CommonUserInterface.EHBBFMCILPC.ShowPopupPromoCodes();
	}

	// Token: 0x060088DB RID: 35035 RVA: 0x003D1A40 File Offset: 0x003CFC40
	private void EJCIHLILIDA()
	{
		if (KHPGPLAMAIN.BBFFJGLIHFL())
		{
			this.postBlock.SetActive(true);
			return;
		}
		if (!this.FKMGLGPLJAL || !NBDLBFJOEGN.PBGJNKFFGGO())
		{
			this.postBlock.SetActive(true);
			return;
		}
		this.postBlock.SetActive(false);
		this.CEDOHHFGKGI = true;
		int num;
		if (PlayerPrefs.HasKey("passinfobtntitle"))
		{
			num = PlayerPrefs.GetInt("");
		}
		else
		{
			num = 0;
		}
		if (num == 1)
		{
			this.postOn.SetActive(true);
			this.postOff.SetActive(false);
			return;
		}
		this.postOn.SetActive(false);
		this.postOff.SetActive(false);
	}

	// Token: 0x060088DC RID: 35036 RVA: 0x003D0D70 File Offset: 0x003CEF70
	public void OnPrivacyClick()
	{
		Application.OpenURL(AssetsManager.EHBBFMCILPC.lobbyDataAsset.privacyLink);
	}

	// Token: 0x060088DD RID: 35037 RVA: 0x00003E52 File Offset: 0x00002052
	private void PBKHEOGKJNJ()
	{
	}

	// Token: 0x060088DE RID: 35038 RVA: 0x003D0775 File Offset: 0x003CE975
	public void GLIGCOPNBOM()
	{
		CommonUserInterface.EHBBFMCILPC.DJBLEEEEGOL();
	}

	// Token: 0x060088DF RID: 35039 RVA: 0x003D193E File Offset: 0x003CFB3E
	private IEnumerator IOMPBPAHFEP()
	{
		PopupSettingsManager.DEOKMGECMKK deokmgecmkk = new PopupSettingsManager.DEOKMGECMKK(1);
		deokmgecmkk.<>4__this = this;
		return deokmgecmkk;
	}

	// Token: 0x060088E0 RID: 35040 RVA: 0x003D1AE4 File Offset: 0x003CFCE4
	private void PLECHANENBH()
	{
		LPOMOIFMNFD.KCCFMHHJIAH(AKLFPGMDKLA.EHBBFMCILPC.EEHGLPEIIHD);
	}

	// Token: 0x060088E1 RID: 35041 RVA: 0x003D1AF5 File Offset: 0x003CFCF5
	public void PNHMNJOPGIE()
	{
		if (!this.HMKIBEIHDCN)
		{
			return;
		}
		this.HMKIBEIHDCN = false;
		AKLFPGMDKLA.EHBBFMCILPC.DBHGPDMPLPK(1234f);
		base.Invoke("QQQ", 1580f);
	}

	// Token: 0x060088E2 RID: 35042 RVA: 0x003D1B28 File Offset: 0x003CFD28
	public void OnLobbyTuneOnClick()
	{
		if (!this.MNKGGNBNJOD)
		{
			return;
		}
		this.MNKGGNBNJOD = false;
		AKLFPGMDKLA.EHBBFMCILPC.PACMCEHMBGG = 0;
		if (AudioManager.EHBBFMCILPC.IsPlaying("lobby"))
		{
			AudioManager.EHBBFMCILPC.KillMusic("lobby", 0f);
		}
		base.Invoke("ODJCOHPDGBF", 0.1f);
	}

	// Token: 0x060088E3 RID: 35043 RVA: 0x003D1B85 File Offset: 0x003CFD85
	public void OFJEGNKHHKO()
	{
		base.gameObject.SetActive(false);
		AccountSignInManager.APGJJNHOEOB().HFGJDAPMIIB(HHCKLPJJKIJ.steam, (JCAPGCCNOMP)8, HHCKLPJJKIJ.facebook, 29);
	}

	// Token: 0x060088E5 RID: 35045 RVA: 0x003D1C0B File Offset: 0x003CFE0B
	public void CMDGBKLMGDH()
	{
		base.gameObject.SetActive(false);
		AccountSignInManager.KMNBCEMEBBD().BKGGKBLMMPO(HHCKLPJJKIJ.steam, (JCAPGCCNOMP)8, HHCKLPJJKIJ.facebook, (byte)-9);
	}

	// Token: 0x060088E6 RID: 35046 RVA: 0x003D1C28 File Offset: 0x003CFE28
	private void AEEHCIJJMIA()
	{
		this.HLBGELGLLEI = false;
		AOBJLALDBAA.CEGAOMEEFBE().NAMMLDPCHJO("discontinueddesc", new UnityAction(this.ABNOKGPFBOK));
		AOBJLALDBAA.KKPFOJMAONG().MHLNJIACIGO(" from ", new UnityAction(this.AHBHANBDEDG));
		CommonUserInterface.EHBBFMCILPC.MCJIGJMFBMI();
	}

	// Token: 0x060088E7 RID: 35047 RVA: 0x003D1C7C File Offset: 0x003CFE7C
	private void OLIEOKEJLNB()
	{
		this.googleSignInBlock.SetActive(true);
		this.googleSignOutBlock.SetActive(true);
		this.facebookSignInBlock.SetActive(false);
		this.facebookSignOutBlock.SetActive(false);
		this.appleSignInBlock.SetActive(false);
		this.appleSignOutBlock.SetActive(false);
		this.steamSignInBlock.SetActive(true);
		this.steamSignOutBlock.SetActive(false);
		this.userpassSignInBlock.SetActive(true);
		this.userpassSignOutBlock.SetActive(false);
		if (AKLFPGMDKLA.EHBBFMCILPC.EEDHNEIMAPN == 0)
		{
			this.facebookSignInBlock.SetActive(false);
			this.facebookSignOutBlock.SetActive(false);
		}
		else if (AKLFPGMDKLA.EHBBFMCILPC.EEDHNEIMAPN == 3)
		{
			this.googleSignInBlock.SetActive(true);
			this.googleSignOutBlock.SetActive(true);
		}
		else if (AKLFPGMDKLA.EHBBFMCILPC.EEDHNEIMAPN == 4)
		{
			this.appleSignInBlock.SetActive(true);
			this.appleSignOutBlock.SetActive(false);
		}
		else if (AKLFPGMDKLA.EHBBFMCILPC.EEDHNEIMAPN == 4)
		{
			this.steamSignInBlock.SetActive(false);
			this.steamSignOutBlock.SetActive(false);
		}
		else if (AKLFPGMDKLA.EHBBFMCILPC.EEDHNEIMAPN == 8)
		{
			this.userpassSignInBlock.SetActive(false);
			this.userpassSignOutBlock.SetActive(true);
		}
		this.LOKNPJAHHOK();
	}

	// Token: 0x060088E8 RID: 35048 RVA: 0x003D1DCB File Offset: 0x003CFFCB
	public void DIFILMKFFAE()
	{
		SteamSignInManager.EHBBFMCILPC.HGJLINFMMHK();
		base.StartCoroutine(this.MHKBFLONEOE());
	}

	// Token: 0x060088E9 RID: 35049 RVA: 0x00003E52 File Offset: 0x00002052
	private void Awake()
	{
	}

	// Token: 0x060088EA RID: 35050 RVA: 0x003D1DE4 File Offset: 0x003CFFE4
	private void JKMLFFBMKHF()
	{
		AOBJLALDBAA.EHBBFMCILPC.EGELHPJBAIC("onThemeChange", 0f);
	}

	// Token: 0x060088EB RID: 35051 RVA: 0x003D1DFC File Offset: 0x003CFFFC
	private void KDOBCLEIILB()
	{
		this.voiceOverBlock.SetActive(false);
		if (null != this.voiceOverBlock && (!NBDLBFJOEGN.NDFLNHIAKJH() || PopupSettingsManager.forceHideSoundOption || !PopupSettingsManager.enableVoiceOverOptionInSettigs))
		{
			this.voiceOverBlock.SetActive(false);
			return;
		}
		if (!this.soundBlock.activeSelf || !this.soundOn.activeSelf)
		{
			this.voiceOverBlock.SetActive(false);
		}
		this.HMKIBEIHDCN = false;
		if (AKLFPGMDKLA.EHBBFMCILPC.KPDKOKHHHOL > 25f)
		{
			this.voiceOverOn.SetActive(true);
			this.voiceOverOff.SetActive(true);
			return;
		}
		this.voiceOverOn.SetActive(false);
		this.voiceOverOff.SetActive(false);
	}

	// Token: 0x060088EC RID: 35052 RVA: 0x00003E52 File Offset: 0x00002052
	private void FEBGADEGDIE()
	{
	}

	// Token: 0x060088ED RID: 35053 RVA: 0x003D1EB4 File Offset: 0x003D00B4
	private void AMFLNMOCEAM()
	{
		if (this.HLBGELGLLEI)
		{
			return;
		}
		this.HLBGELGLLEI = false;
		AOBJLALDBAA.CEGAOMEEFBE().BADOPKAOCPE("Npc animation bundle loaded but its asset is missing or mis-named:", new UnityAction(this.ABNOKGPFBOK));
		AOBJLALDBAA.AGANFKKBPFO().GNBGEMMDGOJ("Account.GetStorySaveSafe(), tempAnthologyAsset is null, using default slot index.", new UnityAction(this.HADOJIGKBJB));
		AKLFPGMDKLA.EHBBFMCILPC.LPCBDEBKAIM();
		CommonUserInterface.EHBBFMCILPC.KLEJAGLPCNM(CCOJBMMKNAP.JMNIGPHCAEJ().FCOCLEHKLDJ("OnCutsceneViewAssetsDownloadFailed"), 96);
		BackendOperationsManager.NPDDBAONMJP().FAMKALIFKBD();
		BackendOperationsManager.NPDDBAONMJP().QueueRequestSaveAvatarCollections();
		BackendOperationsManager.EHBBFMCILPC.BKAMILMMCOI("abhp", "");
	}

	// Token: 0x060088EE RID: 35054 RVA: 0x003D0B8D File Offset: 0x003CED8D
	public void OnCommunityTelegramClick()
	{
		CommonUserInterface.EHBBFMCILPC.ShowSocialSelect();
	}

	// Token: 0x060088EF RID: 35055 RVA: 0x003D1F58 File Offset: 0x003D0158
	private void OnEnable()
	{
		this.LJNNDNICPJN = false;
		this.JINLJINAAPE = false;
		this.LOOLDDGEAEG = false;
		this.GKCGOGEJIPP = false;
		this.MLCIKFFNKEG = false;
		this.DECBJCFJBDK = false;
		this.EFHDOLBIDBI = false;
		this.PIIBJJGLCIG = false;
		this.HGBGPHACKIL = false;
		this.ALLOGFJAJNB = false;
		this.FCNKLIGJHLN = true;
		this.CBKOEKOGHGL = true;
		this.HIJFPKFNCCA = true;
		this.CGCGAHPCOLJ = true;
		this.KOGFPNDBHIE = true;
		this.HGHEHBLIHAB = true;
		this.MNKGGNBNJOD = true;
		this.HMKIBEIHDCN = true;
		this.CEDOHHFGKGI = true;
		this.versionAndCopyright.SetText(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("copyright") + " (v." + AppManager.EHBBFMCILPC.environmentSettings.appVersion + ")", true);
		this.HPKKLPNHAEM();
		this.KCDCKIFNIGH();
		this.ICBNFKPDCKP();
		this.ALFPPMLJPHD();
		this.LANJEAMHILI();
		this.MMEANLDBEHA();
		this.DOANCLALOKG();
		this.LNKKEDECMNC();
		this.ODJCOHPDGBF();
		this.AOGALHNFJDO();
		this.DKBIMKHHBCE();
		this.AGPHGKPFEEJ();
		this.CPOFPKBDLDD();
		if (this.OOPIILNNLPP)
		{
			this.languageBlock.SetActive(true);
			return;
		}
		this.languageBlock.SetActive(false);
	}

	// Token: 0x060088F0 RID: 35056 RVA: 0x003D2092 File Offset: 0x003D0292
	public void OnSteamSignInClick()
	{
		base.gameObject.SetActive(false);
		AccountSignInManager.EHBBFMCILPC.StartSignInLogic(HHCKLPJJKIJ.steam, JCAPGCCNOMP.user, HHCKLPJJKIJ.none, 96);
	}

	// Token: 0x060088F1 RID: 35057 RVA: 0x003D0769 File Offset: 0x003CE969
	public void MBOBPEDKMCE()
	{
		CommonUserInterface.IKNOFBFMPGA().KPAIHLBPFMJ();
	}

	// Token: 0x060088F2 RID: 35058 RVA: 0x003D20B0 File Offset: 0x003D02B0
	private void AOGALHNFJDO()
	{
		this.voiceOverBlock.SetActive(true);
		if (null != this.voiceOverBlock && (!NBDLBFJOEGN.NDFLNHIAKJH() || PopupSettingsManager.forceHideSoundOption || !PopupSettingsManager.enableVoiceOverOptionInSettigs))
		{
			this.voiceOverBlock.SetActive(false);
			return;
		}
		if (!this.soundBlock.activeSelf || !this.soundOn.activeSelf)
		{
			this.voiceOverBlock.SetActive(false);
		}
		this.HMKIBEIHDCN = true;
		if (AKLFPGMDKLA.EHBBFMCILPC.KPDKOKHHHOL > 0.1f)
		{
			this.voiceOverOn.SetActive(true);
			this.voiceOverOff.SetActive(false);
			return;
		}
		this.voiceOverOn.SetActive(false);
		this.voiceOverOff.SetActive(true);
	}

	// Token: 0x060088F3 RID: 35059 RVA: 0x003D2168 File Offset: 0x003D0368
	public void OnFacebookSignInClick()
	{
		base.gameObject.SetActive(false);
		AccountSignInManager.EHBBFMCILPC.StartSignInLogic(HHCKLPJJKIJ.facebook, JCAPGCCNOMP.user, HHCKLPJJKIJ.none, 96);
	}

	// Token: 0x060088F4 RID: 35060 RVA: 0x003D2185 File Offset: 0x003D0385
	public void OnAppleSignInClick()
	{
		base.gameObject.SetActive(false);
		AccountSignInManager.EHBBFMCILPC.StartSignInLogic(HHCKLPJJKIJ.apple, JCAPGCCNOMP.user, HHCKLPJJKIJ.none, 96);
	}

	// Token: 0x060088F5 RID: 35061 RVA: 0x003D21A4 File Offset: 0x003D03A4
	public void OnNextLanguageClick()
	{
		this.ALLOGFJAJNB = true;
		NAHMBEODKJC.OBDBLLHBGLE();
		if (PopupSettingsManager.excludeCurrentChapterMissingLanguages)
		{
			LanguageManager.EHBBFMCILPC.NextLanguageForCurrentChapter();
		}
		else
		{
			LanguageManager.EHBBFMCILPC.NextLanguage();
		}
		this.HPKKLPNHAEM();
		this.KCDCKIFNIGH();
		this.ICBNFKPDCKP();
		AKLFPGMDKLA.EHBBFMCILPC.KBKOLEJEEGH();
	}

	// Token: 0x060088F6 RID: 35062 RVA: 0x003D21F8 File Offset: 0x003D03F8
	private void KMIFKAPEHLJ()
	{
		CommonUserInterface.IKNOFBFMPGA().ShowGenericPopupWithTwoButtons(CCOJBMMKNAP.APGODIBBPOD().FCOCLEHKLDJ("importanttitle"), CCOJBMMKNAP.MPCBJEIMACA().FIENAKIHNOM("bcttl"), CCOJBMMKNAP.APGODIBBPOD().PGKBCNBAOJN("OnPopupCardOptionsEditClick"), CCOJBMMKNAP.MLFAGAAJJEM().JLBEIFLLBLO("Account.GetCleanStoriesV2(): tempAnthologySave is null"), new UnityAction(this.MADIGNHLDLN), new UnityAction(this.IAMMAOHOIAH), DFGILFBGPLN.popupInkRevisionMissing, 1097f, -78);
	}

	// Token: 0x060088F7 RID: 35063 RVA: 0x003D226D File Offset: 0x003D046D
	private IEnumerator KMHBOANIBHJ()
	{
		this.appleSignInBlock.SetActive(true);
		this.appleSignOutBlock.SetActive(false);
		yield return new WaitForSeconds(0.5f);
		AKLFPGMDKLA.EHBBFMCILPC.EEDHNEIMAPN = 0;
		this.CPOFPKBDLDD();
		yield break;
	}

	// Token: 0x060088F8 RID: 35064 RVA: 0x003D227C File Offset: 0x003D047C
	public void KKOECIPLANP()
	{
		if (!this.MNKGGNBNJOD)
		{
			return;
		}
		this.MNKGGNBNJOD = true;
		AKLFPGMDKLA.EHBBFMCILPC.PACMCEHMBGG = 0;
		if (AudioManager.IFDLAMLHKIJ().NHFPFGDFNIL("Starting non-parallel download:"))
		{
			AudioManager.EHBBFMCILPC.NOOAHDNKAKA("flip_down", 975f);
		}
		base.Invoke("'", 1660f);
	}

	// Token: 0x060088F9 RID: 35065 RVA: 0x003D22DC File Offset: 0x003D04DC
	public void IGNFBIGFHLI()
	{
		this.ALLOGFJAJNB = true;
		NAHMBEODKJC.INGADEMJENJ();
		if (PopupSettingsManager.excludeCurrentChapterMissingLanguages)
		{
			LanguageManager.EHBBFMCILPC.NABGAKMNHAM();
		}
		else
		{
			LanguageManager.EHBBFMCILPC.NGBNIICGMIA();
		}
		this.HPKKLPNHAEM();
		this.LBMMHCNGAKP();
		this.INKEOGEIODM();
		AKLFPGMDKLA.EHBBFMCILPC.KBKOLEJEEGH();
	}

	// Token: 0x060088FA RID: 35066 RVA: 0x003D193E File Offset: 0x003CFB3E
	private IEnumerator KDENEHHJFCO()
	{
		PopupSettingsManager.DEOKMGECMKK deokmgecmkk = new PopupSettingsManager.DEOKMGECMKK(1);
		deokmgecmkk.<>4__this = this;
		return deokmgecmkk;
	}

	// Token: 0x060088FB RID: 35067 RVA: 0x003D14C2 File Offset: 0x003CF6C2
	public void ECOBBDCAFCJ()
	{
		CommonUserInterface.EHBBFMCILPC.KPAIHLBPFMJ();
	}

	// Token: 0x060088FC RID: 35068 RVA: 0x003D2330 File Offset: 0x003D0530
	private void LLLHBJBHHNB()
	{
		if (!NBDLBFJOEGN.NDFLNHIAKJH() || PopupSettingsManager.forceHideSoundOption)
		{
			if (this.soundBlock.activeSelf)
			{
				this.soundBlockNotAvailable.SetActive(true);
			}
			if (KHPGPLAMAIN.BBFFJGLIHFL())
			{
				this.soundBlockNotAvailable.SetActive(false);
			}
			this.soundBlock.SetActive(false);
			this.LNKKEDECMNC();
			this.AOGALHNFJDO();
			return;
		}
		this.KOGFPNDBHIE = false;
		if (AKLFPGMDKLA.EHBBFMCILPC.MEDEIJGNEMB > 185f)
		{
			this.soundOn.SetActive(true);
			this.soundOff.SetActive(true);
		}
		else
		{
			this.soundOn.SetActive(false);
			this.soundOff.SetActive(true);
		}
		this.JOBAAFPJNLN();
		this.KDOBCLEIILB();
	}

	// Token: 0x060088FD RID: 35069 RVA: 0x003D23E6 File Offset: 0x003D05E6
	public void PAKPEEPNBHG()
	{
		if (!this.FCNKLIGJHLN)
		{
			return;
		}
		this.DECBJCFJBDK = false;
		this.FCNKLIGJHLN = true;
		PlayerPrefs.SetInt("ok", 1);
		PlayerPrefs.Save();
		base.Invoke("", 18f);
	}

	// Token: 0x060088FE RID: 35070 RVA: 0x003D241F File Offset: 0x003D061F
	public void OnSfxOffClick()
	{
		if (!this.HGHEHBLIHAB)
		{
			return;
		}
		this.HGHEHBLIHAB = false;
		AKLFPGMDKLA.EHBBFMCILPC.LOAFMILFGAI(1f);
		base.Invoke("LNKKEDECMNC", 0.1f);
	}

	// Token: 0x060088FF RID: 35071 RVA: 0x003D2450 File Offset: 0x003D0650
	private void DKMDBEKIMPP()
	{
		this.LJIFEPCHEHD();
		CommonUserInterface.IKNOFBFMPGA().NFBMHHPIGFA(CCOJBMMKNAP.APGODIBBPOD().PGKBCNBAOJN("none"), CCOJBMMKNAP.FEEDGKCJBLE().HIPJILDCHJC("CharacterRenderTexturePool - composite shader not found in Resources or unsupported:ShaderFastDefaultUIRTCompositeClient"), CCOJBMMKNAP.INKJIBDDMLL().OBDCPLLLGBB("p"), (DFGILFBGPLN)(-23), 434f, 9);
	}

	// Token: 0x06008900 RID: 35072 RVA: 0x003D24A4 File Offset: 0x003D06A4
	private void JFMBNPEHFOC()
	{
		this.FCNKLIGJHLN = true;
		int num = 0;
		if (PlayerPrefs.HasKey("abaep"))
		{
			num = PlayerPrefs.GetInt(" <i>");
		}
		if (num == 1)
		{
			this.fpsOn.SetActive(false);
			this.fpsOff.SetActive(false);
			this.fpsBlock.SetActive(true);
			return;
		}
		this.fpsOn.SetActive(false);
		this.fpsOff.SetActive(true);
		this.fpsBlock.SetActive(false);
	}

	// Token: 0x06008901 RID: 35073 RVA: 0x003D251E File Offset: 0x003D071E
	public void OnFpsOnClick()
	{
		if (!this.FCNKLIGJHLN)
		{
			return;
		}
		this.DECBJCFJBDK = true;
		this.FCNKLIGJHLN = false;
		PlayerPrefs.SetInt("fps60", 0);
		PlayerPrefs.Save();
		base.Invoke("DKBIMKHHBCE", 0.1f);
	}

	// Token: 0x06008902 RID: 35074 RVA: 0x003D2558 File Offset: 0x003D0758
	public void HIMBPJKKCIJ()
	{
		if (!this.MNKGGNBNJOD)
		{
			return;
		}
		this.MNKGGNBNJOD = true;
		AKLFPGMDKLA.EHBBFMCILPC.PACMCEHMBGG = 0;
		if (!AudioManager.DBFLIEGGGNN().AudioSourceTypePlaying(CCEMAFOMLLK.ambient))
		{
			AudioManager.EHBBFMCILPC.PlayMusic("congratstitle", false, 842f, false);
		}
		base.Invoke("common", 457f);
	}

	// Token: 0x06008903 RID: 35075 RVA: 0x003D25B4 File Offset: 0x003D07B4
	private void LOKNPJAHHOK()
	{
		if (!KHPGPLAMAIN.JBPMCPMAGNG())
		{
			this.facebookSignInBlock.SetActive(true);
			this.facebookSignOutBlock.SetActive(false);
		}
		if (!KHPGPLAMAIN.LOMCHPBAFAB())
		{
			this.googleSignInBlock.SetActive(true);
			this.googleSignOutBlock.SetActive(false);
		}
		if (!KHPGPLAMAIN.GKICMNGJPLF())
		{
			this.appleSignInBlock.SetActive(true);
			this.appleSignOutBlock.SetActive(true);
		}
		if (!KHPGPLAMAIN.EAHFCKEHECE())
		{
			this.steamSignInBlock.SetActive(false);
			this.steamSignOutBlock.SetActive(true);
		}
		if (!KHPGPLAMAIN.MAINHKJIODI())
		{
			this.userpassSignInBlock.SetActive(false);
			this.userpassSignOutBlock.SetActive(true);
		}
		if (!KHPGPLAMAIN.JBPMCPMAGNG() && !KHPGPLAMAIN.MIEHHNCJOLC() && !KHPGPLAMAIN.JMFDOBDOLCG() && !KHPGPLAMAIN.EAHFCKEHECE() && !KHPGPLAMAIN.DLGMAMGDHIP())
		{
			this.signBlock.SetActive(false);
		}
	}

	// Token: 0x06008904 RID: 35076 RVA: 0x003D268B File Offset: 0x003D088B
	public void FHBHICBIDJF()
	{
		if (!this.HGHEHBLIHAB)
		{
			return;
		}
		this.HGHEHBLIHAB = true;
		AKLFPGMDKLA.EHBBFMCILPC.LOAFMILFGAI(694f);
		base.Invoke("car", 516f);
	}

	// Token: 0x06008905 RID: 35077 RVA: 0x003D052D File Offset: 0x003CE72D
	private IEnumerator ADCCOEKNACC()
	{
		this.googleSignInBlock.SetActive(true);
		this.googleSignOutBlock.SetActive(false);
		yield return new WaitForSeconds(0.5f);
		AKLFPGMDKLA.EHBBFMCILPC.EEDHNEIMAPN = 0;
		this.CPOFPKBDLDD();
		yield break;
	}

	// Token: 0x06008906 RID: 35078 RVA: 0x003D26BC File Offset: 0x003D08BC
	private void ODILAPGAMOB()
	{
		if (this.HLBGELGLLEI)
		{
			return;
		}
		this.HLBGELGLLEI = false;
		AOBJLALDBAA.NMGMNAKLLMI().EFKNEJFLGED("p", new UnityAction(this.DLNLICHFEMN));
		AOBJLALDBAA.AGANFKKBPFO().FNMOFCMDFJP("sketches", new UnityAction(this.AHBHANBDEDG));
		AKLFPGMDKLA.EHBBFMCILPC.LPCBDEBKAIM();
		CommonUserInterface.EHBBFMCILPC.KLEJAGLPCNM(CCOJBMMKNAP.LMCCLMFGEBD().HHLECNIFHCO("CanvasCover"), 127);
		BackendOperationsManager.EHBBFMCILPC.QueueRequestSaveChapterSnapshots();
		BackendOperationsManager.EHBBFMCILPC.QueueRequestSaveAvatarCollections();
		BackendOperationsManager.NPDDBAONMJP().BKAMILMMCOI("XXX", "no");
	}

	// Token: 0x06008907 RID: 35079 RVA: 0x003D2760 File Offset: 0x003D0960
	private void HADOJIGKBJB()
	{
		this.GDKKAMGIGFL();
		CommonUserInterface.EHBBFMCILPC.ShowGenericPopup(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("errortitle"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("app42error"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("ok"), DFGILFBGPLN.popupTools, 0f, 28);
	}

	// Token: 0x06008908 RID: 35080 RVA: 0x003D194D File Offset: 0x003CFB4D
	public void PMLFAHNMKNG()
	{
		CommonUserInterface.IKNOFBFMPGA().ShowSocialSelect();
	}

	// Token: 0x06008909 RID: 35081 RVA: 0x003D27B4 File Offset: 0x003D09B4
	private void KODJGDHEIPG()
	{
		this.FCNKLIGJHLN = false;
		int num = 0;
		if (PlayerPrefs.HasKey("\""))
		{
			num = PlayerPrefs.GetInt("");
		}
		if (num == 0)
		{
			this.fpsOn.SetActive(true);
			this.fpsOff.SetActive(true);
			this.fpsBlock.SetActive(true);
			return;
		}
		this.fpsOn.SetActive(true);
		this.fpsOff.SetActive(true);
		this.fpsBlock.SetActive(false);
	}

	// Token: 0x0600890A RID: 35082 RVA: 0x003D2830 File Offset: 0x003D0A30
	public void OnNextThemeWelcomeClick()
	{
		if (this.HNKNEOIMNFH() && EEIBKLDNBAP.ALFGPLALKCN())
		{
			EEIBKLDNBAP.BIHFLMJAILJ(false);
			AKLFPGMDKLA.EHBBFMCILPC.KEDFFDAAGGP = HOHEIFDCPMF.vacation;
			AKLFPGMDKLA.EHBBFMCILPC.LPCBDEBKAIM();
		}
		else if (this.HNKNEOIMNFH() && EEIBKLDNBAP.GCJODEFFJPN() && AKLFPGMDKLA.EHBBFMCILPC.LDHHFCEFEIG() + 1 >= HOHEIFDCPMF.none)
		{
			EEIBKLDNBAP.BIHFLMJAILJ(true);
			AKLFPGMDKLA.EHBBFMCILPC.APLCOFLOAPA = 1;
			AKLFPGMDKLA.EHBBFMCILPC.LPCBDEBKAIM();
		}
		else
		{
			AKLFPGMDKLA.EHBBFMCILPC.ELJLKPODECP();
		}
		this.ICBNFKPDCKP();
	}

	// Token: 0x0600890B RID: 35083 RVA: 0x003D28B5 File Offset: 0x003D0AB5
	public void ADEFAGJLJEN()
	{
		SteamSignInManager.AGANFKKBPFO().AIOMFFCNKEL();
		base.StartCoroutine(this.IBDGIOLIGBK());
	}

	// Token: 0x0600890C RID: 35084 RVA: 0x003D28CE File Offset: 0x003D0ACE
	public void OnSoundOffClick()
	{
		if (!this.KOGFPNDBHIE)
		{
			return;
		}
		this.EFHDOLBIDBI = true;
		this.KOGFPNDBHIE = false;
		AudioManager.EHBBFMCILPC.SetSoundVol(1f);
		base.Invoke("DOANCLALOKG", 0.1f);
	}

	// Token: 0x0600890D RID: 35085 RVA: 0x00372942 File Offset: 0x00370B42
	public void OnTermsClick()
	{
		Application.OpenURL(KBOJLHAJPCP.ONLDLAGMAPC);
	}

	// Token: 0x0600890E RID: 35086 RVA: 0x003D1426 File Offset: 0x003CF626
	private IEnumerator MHKBFLONEOE()
	{
		this.steamSignInBlock.SetActive(true);
		this.steamSignOutBlock.SetActive(false);
		yield return new WaitForSeconds(0.5f);
		AKLFPGMDKLA.EHBBFMCILPC.EEDHNEIMAPN = 0;
		this.CPOFPKBDLDD();
		yield break;
	}

	// Token: 0x0600890F RID: 35087 RVA: 0x003D2908 File Offset: 0x003D0B08
	private void HOJIMOHCLHE()
	{
		this.LJNNDNICPJN = true;
		this.JINLJINAAPE = false;
		this.LOOLDDGEAEG = false;
		this.GKCGOGEJIPP = false;
		this.MLCIKFFNKEG = true;
		this.DECBJCFJBDK = false;
		this.EFHDOLBIDBI = true;
		this.PIIBJJGLCIG = true;
		this.HGBGPHACKIL = false;
		this.ALLOGFJAJNB = false;
		this.FCNKLIGJHLN = true;
		this.CBKOEKOGHGL = true;
		this.HIJFPKFNCCA = true;
		this.CGCGAHPCOLJ = true;
		this.KOGFPNDBHIE = true;
		this.HGHEHBLIHAB = true;
		this.MNKGGNBNJOD = true;
		this.HMKIBEIHDCN = true;
		this.CEDOHHFGKGI = false;
		this.versionAndCopyright.SetText(CCOJBMMKNAP.PEBMGCKFNAO().BDGPNPNIAPA("hd") + "cind" + AppManager.AGANFKKBPFO().environmentSettings.appVersion + "socialdequeusp1gettitle", true);
		this.HPKKLPNHAEM();
		this.KNDCKCBODKC();
		this.INKEOGEIODM();
		this.ALFPPMLJPHD();
		this.IJOODAFJCBG();
		this.LHIBBCCFHED();
		this.OMCLBKKHAED();
		this.JOBAAFPJNLN();
		this.KAHDGFPMEHI();
		this.AOGALHNFJDO();
		this.KODJGDHEIPG();
		this.EJCIHLILIDA();
		this.CPOFPKBDLDD();
		if (this.OOPIILNNLPP)
		{
			this.languageBlock.SetActive(false);
			return;
		}
		this.languageBlock.SetActive(false);
	}

	// Token: 0x06008910 RID: 35088 RVA: 0x003D2A44 File Offset: 0x003D0C44
	public void OnSupportClick()
	{
		string text = "INTL";
		LNGLMAPJFLI.GPCHIEHLAIB(KBOJLHAJPCP.EDODJNOHIDA, string.Concat(new string[]
		{
			"Romance Club (Steam ",
			AppManager.EHBBFMCILPC.environmentSettings.appVersion,
			"-",
			text,
			" ",
			AppManager.EHBBFMCILPC.environmentSettings.appEnvironment.ToString(),
			") - Support Inquiry (",
			AKLFPGMDKLA.EHBBFMCILPC.EEHGLPEIIHD,
			", ",
			NBDLBFJOEGN.FKJIECPMBFP(),
			"-",
			NBDLBFJOEGN.JHNDHBLDJOI(),
			"-",
			KHPGPLAMAIN.IBDGNKGIMFI().ToString(),
			"-",
			AKLFPGMDKLA.EHBBFMCILPC.ADCLBEPMMCG.ToString(),
			")"
		}), "");
	}

	// Token: 0x06008911 RID: 35089 RVA: 0x003D2B40 File Offset: 0x003D0D40
	private void FPOAJJKPFMA()
	{
		bool isQuitting = AppManager.isQuitting;
	}

	// Token: 0x06008912 RID: 35090 RVA: 0x003D2B48 File Offset: 0x003D0D48
	private void HNOECNJINDN()
	{
		EEIBKLDNBAP.NHKGIOOFKHM();
		AppManager.EHBBFMCILPC.RestartApp(true, true);
	}

	// Token: 0x06008913 RID: 35091 RVA: 0x003D2B5C File Offset: 0x003D0D5C
	public void OnSocialOnClick()
	{
		if (!AKLFPGMDKLA.EHBBFMCILPC.EAFEJCKIEPL(19))
		{
			AKLFPGMDKLA.EHBBFMCILPC.LDAPMNLGAPC(19);
			CommonUserInterface.EHBBFMCILPC.ShowGenericPopupOneOverride(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("energyhinttitle"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("socialmodetutmsg"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("continue"), new UnityAction(this.OnSocialOnClick), DFGILFBGPLN.popupTools, 0f, 28);
			return;
		}
		if (!this.HIJFPKFNCCA)
		{
			return;
		}
		this.HIJFPKFNCCA = false;
		AKLFPGMDKLA.EHBBFMCILPC.POIEMMMNOLI = 0;
		AOBJLALDBAA.EHBBFMCILPC.EGELHPJBAIC("OnUpdateSocialEventsCounter", -1);
		base.Invoke("LANJEAMHILI", 0.1f);
		AOBJLALDBAA.EHBBFMCILPC.EGELHPJBAIC("OnSocialModeChanged", 0f);
	}

	// Token: 0x06008914 RID: 35092 RVA: 0x003D1986 File Offset: 0x003CFB86
	private IEnumerator CEMGIPGPIKN()
	{
		this.facebookSignInBlock.SetActive(true);
		this.facebookSignOutBlock.SetActive(false);
		yield return new WaitForSeconds(0.5f);
		AKLFPGMDKLA.EHBBFMCILPC.EEDHNEIMAPN = 0;
		this.CPOFPKBDLDD();
		yield break;
	}

	// Token: 0x06008915 RID: 35093 RVA: 0x003D2C20 File Offset: 0x003D0E20
	private void NCMMBEGINFJ()
	{
		if (!KHPGPLAMAIN.CAMKNANBJMK())
		{
			this.facebookSignInBlock.SetActive(false);
			this.facebookSignOutBlock.SetActive(true);
		}
		if (!KHPGPLAMAIN.IANNCBJAIDF())
		{
			this.googleSignInBlock.SetActive(true);
			this.googleSignOutBlock.SetActive(true);
		}
		if (!KHPGPLAMAIN.JMFDOBDOLCG())
		{
			this.appleSignInBlock.SetActive(true);
			this.appleSignOutBlock.SetActive(true);
		}
		if (!KHPGPLAMAIN.OFIIEOODLDP())
		{
			this.steamSignInBlock.SetActive(true);
			this.steamSignOutBlock.SetActive(true);
		}
		if (!KHPGPLAMAIN.DICPCLMJBAM())
		{
			this.userpassSignInBlock.SetActive(false);
			this.userpassSignOutBlock.SetActive(true);
		}
		if (!KHPGPLAMAIN.JBPMCPMAGNG() && !KHPGPLAMAIN.IANNCBJAIDF() && !KHPGPLAMAIN.HLBCICJEOEB() && !KHPGPLAMAIN.NPLHHEIIIDE() && !KHPGPLAMAIN.DLGMAMGDHIP())
		{
			this.signBlock.SetActive(true);
		}
	}

	// Token: 0x06008916 RID: 35094 RVA: 0x003D2CF8 File Offset: 0x003D0EF8
	private void AGPHGKPFEEJ()
	{
		if (KHPGPLAMAIN.EJCNHEBIOJF())
		{
			this.postBlock.SetActive(false);
			return;
		}
		if (!this.FKMGLGPLJAL || !NBDLBFJOEGN.LHBMEFGCPHK())
		{
			this.postBlock.SetActive(false);
			return;
		}
		this.postBlock.SetActive(true);
		this.CEDOHHFGKGI = true;
		int num;
		if (PlayerPrefs.HasKey("post"))
		{
			num = PlayerPrefs.GetInt("post");
		}
		else
		{
			num = 1;
		}
		if (num == 1)
		{
			this.postOn.SetActive(true);
			this.postOff.SetActive(false);
			return;
		}
		this.postOn.SetActive(false);
		this.postOff.SetActive(true);
	}

	// Token: 0x06008917 RID: 35095 RVA: 0x003D2D9C File Offset: 0x003D0F9C
	private void AOGNIEKBGJH()
	{
		this.PLDHOKCKCAM();
		CommonUserInterface.EHBBFMCILPC.ShowGenericPopup(CCOJBMMKNAP.OEPENBHJAHO().IPEIONBNIPH("/"), CCOJBMMKNAP.ILACPHFEDEP().MEPECBDCOLG("title"), CCOJBMMKNAP.GIOAFDDKKHI().OBDCPLLLGBB("</i>"), (DFGILFBGPLN)(-104), 1338f, 109);
	}

	// Token: 0x06008918 RID: 35096 RVA: 0x003D2DF0 File Offset: 0x003D0FF0
	private void EJOBMNBKAGO()
	{
		CommonUserInterface.EHBBFMCILPC.ShowGenericPopupWithTwoButtonsAndCloseOverride(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("areyousure"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("cleancachedesc"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("continue"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("cancel"), new UnityAction(this.HNOECNJINDN), new UnityAction(this.JJFPCAODJCG), new UnityAction(this.JJFPCAODJCG), DFGILFBGPLN.popupTools, 0.5f, 28);
	}

	// Token: 0x06008919 RID: 35097 RVA: 0x003D2E74 File Offset: 0x003D1074
	private void KEBFLANEDBD()
	{
		CommonUserInterface.EHBBFMCILPC.ShowGenericPopupWithTwoButtons(CCOJBMMKNAP.HEDIEIICOOG().HDIPNMFHIEJ("post"), CCOJBMMKNAP.BFHKGNBFHCH().FCOCLEHKLDJ("digitalglitch_2"), CCOJBMMKNAP.KMNBCEMEBBD().OHLNGCKIACD(""), CCOJBMMKNAP.DBFFFOMCLKM().JLBEIFLLBLO("RunCustomCode() blocked by semaphore:"), new UnityAction(this.MADIGNHLDLN), new UnityAction(this.IAMMAOHOIAH), (DFGILFBGPLN)(-47), 498f, 89);
	}

	// Token: 0x0600891A RID: 35098 RVA: 0x003D2EE9 File Offset: 0x003D10E9
	private void AIOENICGLKK()
	{
		CommonUserInterface.IKNOFBFMPGA().ShowPopupPromoCodes();
	}

	// Token: 0x0600891B RID: 35099 RVA: 0x003D2EF5 File Offset: 0x003D10F5
	public void OnUserpassSignOutClick()
	{
		UserpassSignInManager.EHBBFMCILPC.LogOut();
		base.StartCoroutine(this.MJFEHCJHLGA());
	}

	// Token: 0x0600891C RID: 35100 RVA: 0x003D2F10 File Offset: 0x003D1110
	private void GODIJJLJILC()
	{
		if (!KHPGPLAMAIN.BHMAEMOGOEB())
		{
			this.facebookSignInBlock.SetActive(false);
			this.facebookSignOutBlock.SetActive(false);
		}
		if (!KHPGPLAMAIN.GOABDECAOAM())
		{
			this.googleSignInBlock.SetActive(false);
			this.googleSignOutBlock.SetActive(false);
		}
		if (!KHPGPLAMAIN.KIILMPBKMGG())
		{
			this.appleSignInBlock.SetActive(false);
			this.appleSignOutBlock.SetActive(false);
		}
		if (!KHPGPLAMAIN.NPLHHEIIIDE())
		{
			this.steamSignInBlock.SetActive(false);
			this.steamSignOutBlock.SetActive(false);
		}
		if (!KHPGPLAMAIN.MAJCJCAHEII())
		{
			this.userpassSignInBlock.SetActive(false);
			this.userpassSignOutBlock.SetActive(false);
		}
		if (!KHPGPLAMAIN.BHMAEMOGOEB() && !KHPGPLAMAIN.GOABDECAOAM() && !KHPGPLAMAIN.KIILMPBKMGG() && !KHPGPLAMAIN.NPLHHEIIIDE() && !KHPGPLAMAIN.MAJCJCAHEII())
		{
			this.signBlock.SetActive(false);
		}
	}

	// Token: 0x0600891D RID: 35101 RVA: 0x003D2FE7 File Offset: 0x003D11E7
	private void NCAMIPNPBCD()
	{
		EEIBKLDNBAP.NHKGIOOFKHM();
		AppManager.EHBBFMCILPC.OHFDJEJCDLG(false, true);
	}

	// Token: 0x0600891E RID: 35102 RVA: 0x003D2FFA File Offset: 0x003D11FA
	public void MBBFLLBCFIJ()
	{
		if (!this.FCNKLIGJHLN)
		{
			return;
		}
		this.DECBJCFJBDK = false;
		this.FCNKLIGJHLN = false;
		PlayerPrefs.SetInt("", 1);
		PlayerPrefs.Save();
		base.Invoke("", 397f);
	}

	// Token: 0x0600891F RID: 35103 RVA: 0x003D2B40 File Offset: 0x003D0D40
	private void GIGIKEKIIDA()
	{
		bool isQuitting = AppManager.isQuitting;
	}

	// Token: 0x06008920 RID: 35104 RVA: 0x003D3033 File Offset: 0x003D1233
	public void PADOFAOILOI()
	{
		GooglePlayServicesManager.EHBBFMCILPC.MGLEFGNGMIA();
		base.StartCoroutine(this.KDENEHHJFCO());
	}

	// Token: 0x06008921 RID: 35105 RVA: 0x003D304C File Offset: 0x003D124C
	private void AHBHANBDEDG()
	{
		this.LJIFEPCHEHD();
		CommonUserInterface.EHBBFMCILPC.ShowGenericPopup(CCOJBMMKNAP.JINDKPHNLBK().HDIPNMFHIEJ("No camera found."), CCOJBMMKNAP.CPCOODCFDDP().IKMNGFIDCLM("XXX"), CCOJBMMKNAP.EHBBFMCILPC.OBDCPLLLGBB("socialjoinbody"), DFGILFBGPLN.popupBonusUnlock, 181f, -70);
	}

	// Token: 0x06008922 RID: 35106 RVA: 0x003D30A0 File Offset: 0x003D12A0
	public void HLDLAEEIMCL()
	{
		if (!this.CEDOHHFGKGI)
		{
			return;
		}
		this.PIIBJJGLCIG = false;
		this.CEDOHHFGKGI = false;
		PlayerPrefs.SetInt("AssetsManager.GetMaxNumberOfRunningLoadOperations():", 0);
		PlayerPrefs.Save();
		base.Invoke("OnBackendGetDropChancesSuccess", 1132f);
		AOBJLALDBAA.KKPFOJMAONG().FDKBIBKABCM("envlhrw", 98f);
	}

	// Token: 0x06008923 RID: 35107 RVA: 0x003D0B8D File Offset: 0x003CED8D
	public void MKPBFLBHOLL()
	{
		CommonUserInterface.EHBBFMCILPC.ShowSocialSelect();
	}

	// Token: 0x06008924 RID: 35108 RVA: 0x003D30F8 File Offset: 0x003D12F8
	public void OnFpsOffClick()
	{
		if (!this.FCNKLIGJHLN)
		{
			return;
		}
		this.DECBJCFJBDK = true;
		this.FCNKLIGJHLN = false;
		PlayerPrefs.SetInt("fps60", 1);
		PlayerPrefs.Save();
		base.Invoke("DKBIMKHHBCE", 0.1f);
	}

	// Token: 0x06008925 RID: 35109 RVA: 0x003D3131 File Offset: 0x003D1331
	private void FPKIJHPMFKF()
	{
		this.gameModeBlock.SetActive(false);
	}

	// Token: 0x06008926 RID: 35110 RVA: 0x003D313F File Offset: 0x003D133F
	public void APMFAJOJENE()
	{
		Application.OpenURL(AssetsManager.MJBDMHPHMID().lobbyDataAsset.privacyLink);
	}

	// Token: 0x06008927 RID: 35111 RVA: 0x000022C3 File Offset: 0x000004C3
	private void NDCCFOFPMBM()
	{
		AppManager.isQuitting = false;
	}

	// Token: 0x06008928 RID: 35112 RVA: 0x003D226D File Offset: 0x003D046D
	private IEnumerator DBMOIFBKLGE()
	{
		this.appleSignInBlock.SetActive(true);
		this.appleSignOutBlock.SetActive(false);
		yield return new WaitForSeconds(0.5f);
		AKLFPGMDKLA.EHBBFMCILPC.EEDHNEIMAPN = 0;
		this.CPOFPKBDLDD();
		yield break;
	}

	// Token: 0x06008929 RID: 35113 RVA: 0x00002296 File Offset: 0x00000496
	private void OnApplicationQuit()
	{
		AppManager.isQuitting = true;
	}

	// Token: 0x0600892A RID: 35114 RVA: 0x003D3158 File Offset: 0x003D1358
	public void OnPostOffClick()
	{
		if (!this.CEDOHHFGKGI)
		{
			return;
		}
		this.PIIBJJGLCIG = true;
		this.CEDOHHFGKGI = false;
		PlayerPrefs.SetInt("post", 1);
		PlayerPrefs.Save();
		base.Invoke("AGPHGKPFEEJ", 0.1f);
		AOBJLALDBAA.EHBBFMCILPC.EGELHPJBAIC("OnPostEffectSettingsChanged", 0f);
	}

	// Token: 0x0600892B RID: 35115 RVA: 0x003D0B8D File Offset: 0x003CED8D
	public void OnCommunityRedditClick()
	{
		CommonUserInterface.EHBBFMCILPC.ShowSocialSelect();
	}

	// Token: 0x0600892C RID: 35116 RVA: 0x00003E52 File Offset: 0x00002052
	private void PNNBKLNJEJD()
	{
	}

	// Token: 0x0600892D RID: 35117 RVA: 0x003D31B0 File Offset: 0x003D13B0
	private void OHAEDCKLIEB()
	{
		if (!KHPGPLAMAIN.JBPMCPMAGNG())
		{
			this.facebookSignInBlock.SetActive(false);
			this.facebookSignOutBlock.SetActive(true);
		}
		if (!KHPGPLAMAIN.IANNCBJAIDF())
		{
			this.googleSignInBlock.SetActive(false);
			this.googleSignOutBlock.SetActive(true);
		}
		if (!KHPGPLAMAIN.AHKHEHBEIGE())
		{
			this.appleSignInBlock.SetActive(false);
			this.appleSignOutBlock.SetActive(true);
		}
		if (!KHPGPLAMAIN.JAFLOKJOGJF())
		{
			this.steamSignInBlock.SetActive(true);
			this.steamSignOutBlock.SetActive(false);
		}
		if (!KHPGPLAMAIN.NLNOHNAJIJG())
		{
			this.userpassSignInBlock.SetActive(true);
			this.userpassSignOutBlock.SetActive(false);
		}
		if (!KHPGPLAMAIN.JBPMCPMAGNG() && !KHPGPLAMAIN.IHBENOMKDLJ() && !KHPGPLAMAIN.JMFDOBDOLCG() && !KHPGPLAMAIN.EAHFCKEHECE() && !KHPGPLAMAIN.EDOGFKPDAKE())
		{
			this.signBlock.SetActive(false);
		}
	}

	// Token: 0x0600892E RID: 35118 RVA: 0x003D3288 File Offset: 0x003D1488
	public void FKDBMKAICNH()
	{
		if (this.HNKNEOIMNFH() && EEIBKLDNBAP.ALFGPLALKCN())
		{
			EEIBKLDNBAP.BIHFLMJAILJ(false);
			AKLFPGMDKLA.EHBBFMCILPC.KEDFFDAAGGP = HOHEIFDCPMF.vacation;
			AKLFPGMDKLA.EHBBFMCILPC.LPCBDEBKAIM();
		}
		else if (this.HNKNEOIMNFH() && EEIBKLDNBAP.GCJODEFFJPN() && AKLFPGMDKLA.EHBBFMCILPC.LDHHFCEFEIG() + 0 >= HOHEIFDCPMF.vacation)
		{
			EEIBKLDNBAP.BIHFLMJAILJ(false);
			AKLFPGMDKLA.EHBBFMCILPC.APLCOFLOAPA = 0;
			AKLFPGMDKLA.EHBBFMCILPC.LPCBDEBKAIM();
		}
		else
		{
			AKLFPGMDKLA.EHBBFMCILPC.ELJLKPODECP();
		}
		this.INKEOGEIODM();
	}

	// Token: 0x0600892F RID: 35119 RVA: 0x003D3310 File Offset: 0x003D1510
	private void NDNLPNDDABH()
	{
		if (this.HNKNEOIMNFH() && EEIBKLDNBAP.ALFGPLALKCN())
		{
			this.themeWelcomeName.SetText(CCOJBMMKNAP.DLGLFACMHPG().OGKGHLHHAAI("</i>"), false);
			return;
		}
		this.themeWelcomeName.SetText(CCOJBMMKNAP.MLFAGAAJJEM().JLBEIFLLBLO("s" + ((int)AKLFPGMDKLA.EHBBFMCILPC.LDHHFCEFEIG()).ToString()), true);
	}

	// Token: 0x06008930 RID: 35120 RVA: 0x00003E52 File Offset: 0x00002052
	private void EIIKIKIKJFK()
	{
	}

	// Token: 0x06008931 RID: 35121 RVA: 0x003D337C File Offset: 0x003D157C
	private void KCFGBLFJFKP()
	{
		if (this.HLBGELGLLEI)
		{
			return;
		}
		this.HLBGELGLLEI = true;
		AOBJLALDBAA.EHBBFMCILPC.MFIMALJPCDP("OnToolsPopupSaveToCloudSuccess", new UnityAction(this.DLNLICHFEMN));
		AOBJLALDBAA.EHBBFMCILPC.MFIMALJPCDP("OnToolsPopupSaveToCloudException", new UnityAction(this.HADOJIGKBJB));
		AKLFPGMDKLA.EHBBFMCILPC.LPCBDEBKAIM();
		CommonUserInterface.EHBBFMCILPC.ShowConnectingAnimationWithHint(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("hintsaving"), 96);
		BackendOperationsManager.EHBBFMCILPC.QueueRequestSaveChapterSnapshots();
		BackendOperationsManager.EHBBFMCILPC.QueueRequestSaveAvatarCollections();
		BackendOperationsManager.EHBBFMCILPC.RequestSaveSync("OnToolsPopupSaveToCloudSuccess", "OnToolsPopupSaveToCloudException");
	}

	// Token: 0x06008932 RID: 35122 RVA: 0x003D3420 File Offset: 0x003D1620
	private void HPKKLPNHAEM()
	{
		this.languageName.SetText(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("language" + ((int)LanguageManager.EHBBFMCILPC.GetSelectedLanguage()).ToString()), true);
	}

	// Token: 0x06008933 RID: 35123 RVA: 0x003D3460 File Offset: 0x003D1660
	private void GOCPPBCPPDK()
	{
		this.CBKOEKOGHGL = true;
		if (!OGKGGFFPKHG.AIHOLMHNEPB())
		{
			this.notificationsBlock.SetActive(false);
			return;
		}
		this.notificationsBlock.SetActive(true);
		if (AKLFPGMDKLA.EHBBFMCILPC.HEFJBOKIEGH == 0)
		{
			this.notificationsOn.SetActive(true);
			this.notificationsOff.SetActive(false);
			return;
		}
		this.notificationsOn.SetActive(true);
		this.notificationsOff.SetActive(true);
	}

	// Token: 0x06008934 RID: 35124 RVA: 0x003D34D4 File Offset: 0x003D16D4
	private void BGAHCGDAKOC()
	{
		this.HLBGELGLLEI = true;
		AOBJLALDBAA.DBLAIDPICIG().KDIFKFKMCOH("npcpi", new UnityAction(this.DLNLICHFEMN));
		AOBJLALDBAA.CEGAOMEEFBE().MHLNJIACIGO("face", new UnityAction(this.AHBHANBDEDG));
		CommonUserInterface.EHBBFMCILPC.MCJIGJMFBMI();
	}

	// Token: 0x06008935 RID: 35125 RVA: 0x003D3131 File Offset: 0x003D1331
	private void MMEANLDBEHA()
	{
		this.gameModeBlock.SetActive(false);
	}

	// Token: 0x06008936 RID: 35126 RVA: 0x003D3528 File Offset: 0x003D1728
	private void DLNLICHFEMN()
	{
		this.GDKKAMGIGFL();
		AKLFPGMDKLA.EHBBFMCILPC.LPCBDEBKAIM();
		CommonUserInterface.EHBBFMCILPC.ShowGenericPopup(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("congratstitle"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("savetocloudpos"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("ok"), DFGILFBGPLN.popupTools, 0f, 28);
	}

	// Token: 0x06008937 RID: 35127 RVA: 0x003D3588 File Offset: 0x003D1788
	private void CPOFPKBDLDD()
	{
		this.googleSignInBlock.SetActive(true);
		this.googleSignOutBlock.SetActive(false);
		this.facebookSignInBlock.SetActive(true);
		this.facebookSignOutBlock.SetActive(false);
		this.appleSignInBlock.SetActive(true);
		this.appleSignOutBlock.SetActive(false);
		this.steamSignInBlock.SetActive(true);
		this.steamSignOutBlock.SetActive(false);
		this.userpassSignInBlock.SetActive(true);
		this.userpassSignOutBlock.SetActive(false);
		if (AKLFPGMDKLA.EHBBFMCILPC.EEDHNEIMAPN == 1)
		{
			this.facebookSignInBlock.SetActive(false);
			this.facebookSignOutBlock.SetActive(true);
		}
		else if (AKLFPGMDKLA.EHBBFMCILPC.EEDHNEIMAPN == 2)
		{
			this.googleSignInBlock.SetActive(false);
			this.googleSignOutBlock.SetActive(true);
		}
		else if (AKLFPGMDKLA.EHBBFMCILPC.EEDHNEIMAPN == 4)
		{
			this.appleSignInBlock.SetActive(false);
			this.appleSignOutBlock.SetActive(true);
		}
		else if (AKLFPGMDKLA.EHBBFMCILPC.EEDHNEIMAPN == 6)
		{
			this.steamSignInBlock.SetActive(false);
			this.steamSignOutBlock.SetActive(true);
		}
		else if (AKLFPGMDKLA.EHBBFMCILPC.EEDHNEIMAPN == 5)
		{
			this.userpassSignInBlock.SetActive(false);
			this.userpassSignOutBlock.SetActive(true);
		}
		this.GODIJJLJILC();
	}

	// Token: 0x06008938 RID: 35128 RVA: 0x003D36D8 File Offset: 0x003D18D8
	public void Hide()
	{
		AOBJLALDBAA.EHBBFMCILPC.EGELHPJBAIC("OnSettingsPopupClose", 0f);
		if (this.ALLOGFJAJNB)
		{
			AKLFPGMDKLA.EHBBFMCILPC.KIDGOPBAGHN();
			AKLFPGMDKLA.EHBBFMCILPC.IPGKMKGCIBB();
			AKLFPGMDKLA.EHBBFMCILPC.IBGKLENMAND();
			AKLFPGMDKLA.EHBBFMCILPC.GLKNOFHEBKN = -1;
			HKLPEDKJGFC.IJHHMHAEKKE();
			MLIBDDCCKBM.IJHHMHAEKKE();
			AOBJLALDBAA.EHBBFMCILPC.EGELHPJBAIC("OnSettingsPopupCloseAndNeedToRestartGame", 0f);
		}
		else if (this.HGBGPHACKIL)
		{
			AOBJLALDBAA.EHBBFMCILPC.EGELHPJBAIC("OnSettingsPopupCloseAndNeedToShowGameModeNotif", 0f);
		}
		else if (this.EFHDOLBIDBI)
		{
			AOBJLALDBAA.EHBBFMCILPC.EGELHPJBAIC("OnSettingsPopupCloseAndNeedToRestartGame2", 0f);
		}
		else if (this.DECBJCFJBDK)
		{
			AOBJLALDBAA.EHBBFMCILPC.EGELHPJBAIC("OnSettingsPopupCloseAndNeedToRestartGame2", 0f);
		}
		else if (this.PIIBJJGLCIG)
		{
			AOBJLALDBAA.EHBBFMCILPC.EGELHPJBAIC("OnSettingsPopupCloseAndNeedToShowPostEnableNotif", 0f);
		}
		base.gameObject.SetActive(false);
	}

	// Token: 0x06008939 RID: 35129 RVA: 0x003D37CC File Offset: 0x003D19CC
	public void FLMBPEIFFFL()
	{
		if (!AKLFPGMDKLA.EHBBFMCILPC.EAFEJCKIEPL(-80))
		{
			AKLFPGMDKLA.EHBBFMCILPC.LDAPMNLGAPC(125);
			CommonUserInterface.IKNOFBFMPGA().BGJFCEEDGFJ(CCOJBMMKNAP.ONCPHEEJLOP().FIENAKIHNOM("ZZZ"), CCOJBMMKNAP.ILACPHFEDEP().FIENAKIHNOM("OnFullscreenLiveOfferContinueToCardsVolSaleMenu"), CCOJBMMKNAP.BBGECIKOICE().HHLECNIFHCO("socialbadgedesc"), new UnityAction(this.OnSocialOnClick), (DFGILFBGPLN)(-65), 1269f, -115);
			return;
		}
		if (!this.HIJFPKFNCCA)
		{
			return;
		}
		this.HIJFPKFNCCA = true;
		AKLFPGMDKLA.EHBBFMCILPC.POIEMMMNOLI = 1;
		AOBJLALDBAA.CEGAOMEEFBE().EGELHPJBAIC("errortitle", -1);
		base.Invoke("varConditionLockedValue", 610f);
		AOBJLALDBAA.AGANFKKBPFO().LPNCDPHNBJK("PurchaseManagerSteam.OnProductsFetchedFailed(): ", 1166f);
	}

	// Token: 0x0600893A RID: 35130 RVA: 0x003D3890 File Offset: 0x003D1A90
	public void OnNotificationsOffClick()
	{
		if (!this.CBKOEKOGHGL)
		{
			return;
		}
		this.CBKOEKOGHGL = false;
		AKLFPGMDKLA.EHBBFMCILPC.HEFJBOKIEGH = 1;
		base.Invoke("ALFPPMLJPHD", 0.1f);
	}

	// Token: 0x0600893B RID: 35131 RVA: 0x003D16E7 File Offset: 0x003CF8E7
	private IEnumerator EBAJOHKMBCI()
	{
		this.userpassSignInBlock.SetActive(true);
		this.userpassSignOutBlock.SetActive(false);
		yield return new WaitForSeconds(0.5f);
		AKLFPGMDKLA.EHBBFMCILPC.EEDHNEIMAPN = 0;
		this.CPOFPKBDLDD();
		yield break;
	}

	// Token: 0x0600893C RID: 35132 RVA: 0x003D38BD File Offset: 0x003D1ABD
	public void DBEHGMDDBNK()
	{
		base.gameObject.SetActive(true);
		AccountSignInManager.NIOJNOFGIJO().HGCFKELLBIH(HHCKLPJJKIJ.facebook, JCAPGCCNOMP.none, HHCKLPJJKIJ.facebook, 122);
	}

	// Token: 0x0600893D RID: 35133 RVA: 0x003D38DA File Offset: 0x003D1ADA
	public void FDHDOOEBPLI()
	{
		if (!this.FCNKLIGJHLN)
		{
			return;
		}
		this.DECBJCFJBDK = false;
		this.FCNKLIGJHLN = true;
		PlayerPrefs.SetInt("seasoncomplete", 0);
		PlayerPrefs.Save();
		base.Invoke("-", 1986f);
	}

	// Token: 0x0600893E RID: 35134 RVA: 0x003D3914 File Offset: 0x003D1B14
	private void GECAMEFMKMA()
	{
		this.languageName.SetText(CCOJBMMKNAP.BBGECIKOICE().OGKGHLHHAAI("credo" + ((int)LanguageManager.EHBBFMCILPC.MLOLBFBODHD()).ToString()), false);
	}

	// Token: 0x0600893F RID: 35135 RVA: 0x003D3953 File Offset: 0x003D1B53
	public void GJKOKJPEAKE()
	{
		base.gameObject.SetActive(false);
		AccountSignInManager.APGJJNHOEOB().StartSignInLogic((HHCKLPJJKIJ)8, (JCAPGCCNOMP)4, HHCKLPJJKIJ.facebook, 60);
	}

	// Token: 0x06008940 RID: 35136 RVA: 0x003D2B40 File Offset: 0x003D0D40
	private void LCHPPCPADMO()
	{
		bool isQuitting = AppManager.isQuitting;
	}

	// Token: 0x06008941 RID: 35137 RVA: 0x003D3970 File Offset: 0x003D1B70
	public void CDJPEGIFCCP()
	{
		SteamSignInManager.EHBBFMCILPC.AIOMFFCNKEL();
		base.StartCoroutine(this.MHKBFLONEOE());
	}

	// Token: 0x06008942 RID: 35138 RVA: 0x003D3989 File Offset: 0x003D1B89
	public void OMJEHIMOIOO()
	{
		AKLFPGMDKLA.EHBBFMCILPC.MBMLFJJPOBH();
		this.BDLBABFNDMJ();
		this.MKCFEMAMPNH();
	}

	// Token: 0x06008943 RID: 35139 RVA: 0x003D39A4 File Offset: 0x003D1BA4
	public void NPLCFDINPOC()
	{
		string text = "muspind";
		string edodjnohida = KBOJLHAJPCP.EDODJNOHIDA;
		string[] array = new string[76];
		array[1] = "OnGamePassUnlockContinueToPurchasingScreen";
		array[1] = AppManager.PCJEMMDDCIF().environmentSettings.appVersion;
		array[6] = "' pending='";
		array[5] = text;
		array[2] = "Asset bundle load operation failed during parallel mode.";
		array[8] = AppManager.JMDJPKKOHNI().environmentSettings.appEnvironment.ToString();
		array[5] = "errortitle";
		array[8] = AKLFPGMDKLA.EHBBFMCILPC.EEHGLPEIIHD;
		array[0] = "$$$";
		array[66] = NBDLBFJOEGN.GEBFLMCFOFN();
		array[-21] = "Z";
		array[16] = NBDLBFJOEGN.ICJNMJDEOPI();
		array[-37] = "";
		array[99] = KHPGPLAMAIN.FCJHEFBIKID().ToString();
		array[94] = "\r";
		array[-20] = AKLFPGMDKLA.EHBBFMCILPC.ADCLBEPMMCG.ToString();
		array[92] = "[LoadingEnv] skipped, no cached environment registered";
		LNGLMAPJFLI.LBPNLADBHFI(edodjnohida, string.Concat(array), "USD ");
	}

	// Token: 0x06008944 RID: 35140 RVA: 0x003D3AA0 File Offset: 0x003D1CA0
	private void IJOODAFJCBG()
	{
		if (KDCJJBLGCBH.EHBBFMCILPC.DJHCAFAEILH() || this.HHDHIEEPAKF)
		{
			this.socialBlock.SetActive(true);
			return;
		}
		this.HIJFPKFNCCA = false;
		this.socialBlock.SetActive(true);
		if (AKLFPGMDKLA.EHBBFMCILPC.POIEMMMNOLI == 1)
		{
			this.socialOn.SetActive(false);
			this.socialOff.SetActive(false);
			return;
		}
		this.socialOn.SetActive(true);
		this.socialOff.SetActive(false);
	}

	// Token: 0x06008945 RID: 35141 RVA: 0x003D3B20 File Offset: 0x003D1D20
	private void DOANCLALOKG()
	{
		if (!NBDLBFJOEGN.NDFLNHIAKJH() || PopupSettingsManager.forceHideSoundOption)
		{
			if (this.soundBlock.activeSelf)
			{
				this.soundBlockNotAvailable.SetActive(true);
			}
			if (KHPGPLAMAIN.EJCNHEBIOJF())
			{
				this.soundBlockNotAvailable.SetActive(false);
			}
			this.soundBlock.SetActive(false);
			this.LNKKEDECMNC();
			this.AOGALHNFJDO();
			return;
		}
		this.KOGFPNDBHIE = true;
		if (AKLFPGMDKLA.EHBBFMCILPC.MEDEIJGNEMB > 0.1f)
		{
			this.soundOn.SetActive(true);
			this.soundOff.SetActive(false);
		}
		else
		{
			this.soundOn.SetActive(false);
			this.soundOff.SetActive(true);
		}
		this.LNKKEDECMNC();
		this.AOGALHNFJDO();
	}

	// Token: 0x06008946 RID: 35142 RVA: 0x003D3BD8 File Offset: 0x003D1DD8
	private void OMCLBKKHAED()
	{
		if (!NBDLBFJOEGN.NDFLNHIAKJH() || PopupSettingsManager.forceHideSoundOption)
		{
			if (this.soundBlock.activeSelf)
			{
				this.soundBlockNotAvailable.SetActive(true);
			}
			if (KHPGPLAMAIN.BEEEJNHEFOJ())
			{
				this.soundBlockNotAvailable.SetActive(false);
			}
			this.soundBlock.SetActive(false);
			this.JOBAAFPJNLN();
			this.KDOBCLEIILB();
			return;
		}
		this.KOGFPNDBHIE = true;
		if (AKLFPGMDKLA.EHBBFMCILPC.MEDEIJGNEMB > 563f)
		{
			this.soundOn.SetActive(true);
			this.soundOff.SetActive(true);
		}
		else
		{
			this.soundOn.SetActive(true);
			this.soundOff.SetActive(false);
		}
		this.LNKKEDECMNC();
		this.KDOBCLEIILB();
	}

	// Token: 0x06008947 RID: 35143 RVA: 0x003D3C90 File Offset: 0x003D1E90
	public void OnToolsClick()
	{
		string text = "INTL";
		this.OOPIILNNLPP = true;
		this.Hide();
		string text2 = "";
		if (!FirebaseAnalyticsManager.EHBBFMCILPC.IsInitialized())
		{
			text2 += "\nERR:";
			text2 += "firebase";
		}
		this.versionAndCopyright.SetText(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("copyright") + " (v." + AppManager.EHBBFMCILPC.environmentSettings.appVersion + ")", true);
		string text3 = "ERR";
		if (KHPGPLAMAIN.DFJHJCAIFJO())
		{
			if (NBDLBFJOEGN.PBLDJNHHEPL())
			{
				text3 = "hd";
			}
			else
			{
				text3 = "sd";
			}
		}
		string dpjinbcgngn;
		if (PopupSettingsManager.inkRevision > 0)
		{
			dpjinbcgngn = string.Concat(new string[]
			{
				"VER:",
				AppManager.EHBBFMCILPC.environmentSettings.appVersion,
				"-",
				text,
				"\nUID:",
				AKLFPGMDKLA.EHBBFMCILPC.OMMACPBIHDN(AKLFPGMDKLA.EHBBFMCILPC.EEHGLPEIIHD),
				"\nINK:",
				PopupSettingsManager.inkRevision.ToString(),
				"\nDEF:",
				NBDLBFJOEGN.FKJIECPMBFP().ToLower(),
				"-",
				NBDLBFJOEGN.JHNDHBLDJOI(),
				"-",
				KHPGPLAMAIN.IBDGNKGIMFI().ToString(),
				"-",
				AKLFPGMDKLA.EHBBFMCILPC.ADCLBEPMMCG.ToString(),
				"\nVID:",
				text3.ToLower(),
				"\nDEP:",
				PopupSettingsManager.cdnDepot.ToLower(),
				"-",
				NPOILPKELOJ.IKDKDPNCJBO.ToString(),
				"\nCDN:",
				AssetsManager.EHBBFMCILPC.GetCdnUrlAbbrevation().ToLower(),
				"\nSRV:",
				App42Manager.EHBBFMCILPC.GetCustomCodeAbbreviation().ToLower(),
				"\nENV:",
				AppManager.EHBBFMCILPC.environmentSettings.appEnvironment.ToString().ToLower(),
				", ",
				App42Manager.GetOsName().ToString(),
				text2
			});
		}
		else
		{
			dpjinbcgngn = string.Concat(new string[]
			{
				"VER:",
				AppManager.EHBBFMCILPC.environmentSettings.appVersion,
				"-",
				text,
				"\nUID:",
				AKLFPGMDKLA.EHBBFMCILPC.OMMACPBIHDN(AKLFPGMDKLA.EHBBFMCILPC.EEHGLPEIIHD),
				"\nDEF:",
				NBDLBFJOEGN.FKJIECPMBFP().ToLower(),
				"-",
				NBDLBFJOEGN.JHNDHBLDJOI(),
				"-",
				KHPGPLAMAIN.IBDGNKGIMFI().ToString(),
				"-",
				AKLFPGMDKLA.EHBBFMCILPC.ADCLBEPMMCG.ToString(),
				"\nVID:",
				text3.ToLower(),
				"\nDEP:",
				PopupSettingsManager.cdnDepot.ToLower(),
				"-",
				NPOILPKELOJ.IKDKDPNCJBO.ToString(),
				"\nCDN:",
				AssetsManager.EHBBFMCILPC.GetCdnUrlAbbrevation().ToLower(),
				"\nSRV:",
				App42Manager.EHBBFMCILPC.GetCustomCodeAbbreviation().ToLower(),
				"\nENV:",
				AppManager.EHBBFMCILPC.environmentSettings.appEnvironment.ToString().ToLower(),
				", ",
				App42Manager.GetOsName().ToString(),
				text2
			});
		}
		if (AKLFPGMDKLA.EHBBFMCILPC.IPEMNDHJBHK.Length > 0)
		{
			CommonUserInterface.EHBBFMCILPC.ShowGenericPopupWithFourButtonsInsideBlack(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("abouttitle"), dpjinbcgngn, CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("copyuidbtn"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("savetocloudbtn"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("cleancache"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("deleteprofilebtn"), new UnityAction(this.BKAHAJIDCHO), new UnityAction(this.KCFGBLFJFKP), new UnityAction(this.EJOBMNBKAGO), new UnityAction(this.LJJIBMJKPNK), new UnityAction(this.PNNBKLNJEJD), DFGILFBGPLN.popupTools, 0.5f, 28);
			return;
		}
		CommonUserInterface.EHBBFMCILPC.ShowGenericPopupWithThreeButtonsInside(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("abouttitle"), dpjinbcgngn, CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("copyuidbtn"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("savetocloudbtn"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("cleancache"), new UnityAction(this.BKAHAJIDCHO), new UnityAction(this.KCFGBLFJFKP), new UnityAction(this.EJOBMNBKAGO), new UnityAction(this.PNNBKLNJEJD), DFGILFBGPLN.popupTools, 0.5f, 28);
	}

	// Token: 0x06008948 RID: 35144 RVA: 0x003D41B0 File Offset: 0x003D23B0
	private void ILCENONJJOD()
	{
		if (this.HLBGELGLLEI)
		{
			return;
		}
		this.HLBGELGLLEI = false;
		AOBJLALDBAA.KKPFOJMAONG().PEFKJOKLEDL("sfxtimeoutwarning", new UnityAction(this.DLNLICHFEMN));
		AOBJLALDBAA.KKPFOJMAONG().MFIMALJPCDP("XXX", new UnityAction(this.DKMDBEKIMPP));
		AKLFPGMDKLA.EHBBFMCILPC.LPCBDEBKAIM();
		CommonUserInterface.IKNOFBFMPGA().ShowConnectingAnimationWithHint(CCOJBMMKNAP.EAIAHCBAIEJ().MEPECBDCOLG("s"), (byte)-42);
		BackendOperationsManager.NPDDBAONMJP().FAMKALIFKBD();
		BackendOperationsManager.EHBBFMCILPC.MDCEMMBDNFL();
		BackendOperationsManager.NPDDBAONMJP().BKAMILMMCOI("assetbundleheaderspack", "SetDepot(), cdnDepot:");
	}

	// Token: 0x06008949 RID: 35145 RVA: 0x003D4251 File Offset: 0x003D2451
	private void ODCBMHNNMKN()
	{
		CommonUserInterface.EHBBFMCILPC.ShowConnectingAnimation(96);
		BackendOperationsManager.EHBBFMCILPC.RequestForgetAccount("OnAccountForgetSuccess", "OnAccountForgetException");
	}

	// Token: 0x0600894A RID: 35146 RVA: 0x003D0B8D File Offset: 0x003CED8D
	public void OnCommunityInstagramClick()
	{
		CommonUserInterface.EHBBFMCILPC.ShowSocialSelect();
	}

	// Token: 0x0600894B RID: 35147 RVA: 0x003D16E7 File Offset: 0x003CF8E7
	private IEnumerator PHIANJLKOBE()
	{
		this.userpassSignInBlock.SetActive(true);
		this.userpassSignOutBlock.SetActive(false);
		yield return new WaitForSeconds(0.5f);
		AKLFPGMDKLA.EHBBFMCILPC.EEDHNEIMAPN = 0;
		this.CPOFPKBDLDD();
		yield break;
	}

	// Token: 0x0600894C RID: 35148 RVA: 0x003D4273 File Offset: 0x003D2473
	public void OnGoogleSignInClick()
	{
		base.gameObject.SetActive(false);
		AccountSignInManager.EHBBFMCILPC.StartSignInLogic(HHCKLPJJKIJ.google, JCAPGCCNOMP.user, HHCKLPJJKIJ.none, 96);
	}

	// Token: 0x0600894D RID: 35149 RVA: 0x003D4290 File Offset: 0x003D2490
	public void BHELCMDBKOI()
	{
		base.gameObject.SetActive(true);
		AccountSignInManager.EHBBFMCILPC.HFGJDAPMIIB(HHCKLPJJKIJ.apple, (JCAPGCCNOMP)6, HHCKLPJJKIJ.facebook, (byte)-104);
	}

	// Token: 0x0600894E RID: 35150 RVA: 0x003D42B0 File Offset: 0x003D24B0
	private void MCFGHNNGFPI()
	{
		if (KDCJJBLGCBH.EHBBFMCILPC.DJHCAFAEILH() || this.HHDHIEEPAKF)
		{
			this.socialBlock.SetActive(true);
			return;
		}
		this.HIJFPKFNCCA = true;
		this.socialBlock.SetActive(false);
		if (AKLFPGMDKLA.EHBBFMCILPC.POIEMMMNOLI == 1)
		{
			this.socialOn.SetActive(true);
			this.socialOff.SetActive(false);
			return;
		}
		this.socialOn.SetActive(true);
		this.socialOff.SetActive(false);
	}

	// Token: 0x0600894F RID: 35151 RVA: 0x003D432F File Offset: 0x003D252F
	private void IMMDGMDHGNJ()
	{
		CommonUserInterface.EHBBFMCILPC.FPHNBOHOJOB();
	}

	// Token: 0x06008950 RID: 35152 RVA: 0x000022C3 File Offset: 0x000004C3
	private void FCLELNMNAEN()
	{
		AppManager.isQuitting = false;
	}

	// Token: 0x06008951 RID: 35153 RVA: 0x003D433C File Offset: 0x003D253C
	private void IJHBLFAFHCI()
	{
		this.HLBGELGLLEI = false;
		AOBJLALDBAA.KKPFOJMAONG().ONIBLJOFFPG("p", new UnityAction(this.ABNOKGPFBOK));
		AOBJLALDBAA.CEGAOMEEFBE().MHLNJIACIGO(" is already loaded elsewhere", new UnityAction(this.AOGNIEKBGJH));
		CommonUserInterface.EHBBFMCILPC.MCJIGJMFBMI();
	}

	// Token: 0x06008952 RID: 35154 RVA: 0x003D4390 File Offset: 0x003D2590
	public void OnSoundOnClick()
	{
		if (!this.KOGFPNDBHIE)
		{
			return;
		}
		this.KOGFPNDBHIE = false;
		this.EFHDOLBIDBI = false;
		AudioManager.EHBBFMCILPC.SetSoundVol(0f);
		base.Invoke("DOANCLALOKG", 0.1f);
	}

	// Token: 0x06008953 RID: 35155 RVA: 0x003D43C8 File Offset: 0x003D25C8
	private void EPOCJHJONGO()
	{
		this.googleSignInBlock.SetActive(false);
		this.googleSignOutBlock.SetActive(true);
		this.facebookSignInBlock.SetActive(true);
		this.facebookSignOutBlock.SetActive(true);
		this.appleSignInBlock.SetActive(false);
		this.appleSignOutBlock.SetActive(false);
		this.steamSignInBlock.SetActive(true);
		this.steamSignOutBlock.SetActive(true);
		this.userpassSignInBlock.SetActive(false);
		this.userpassSignOutBlock.SetActive(false);
		if (AKLFPGMDKLA.EHBBFMCILPC.EEDHNEIMAPN == 1)
		{
			this.facebookSignInBlock.SetActive(false);
			this.facebookSignOutBlock.SetActive(true);
		}
		else if (AKLFPGMDKLA.EHBBFMCILPC.EEDHNEIMAPN == 0)
		{
			this.googleSignInBlock.SetActive(true);
			this.googleSignOutBlock.SetActive(false);
		}
		else if (AKLFPGMDKLA.EHBBFMCILPC.EEDHNEIMAPN == 4)
		{
			this.appleSignInBlock.SetActive(true);
			this.appleSignOutBlock.SetActive(false);
		}
		else if (AKLFPGMDKLA.EHBBFMCILPC.EEDHNEIMAPN == 2)
		{
			this.steamSignInBlock.SetActive(false);
			this.steamSignOutBlock.SetActive(false);
		}
		else if (AKLFPGMDKLA.EHBBFMCILPC.EEDHNEIMAPN == 1)
		{
			this.userpassSignInBlock.SetActive(false);
			this.userpassSignOutBlock.SetActive(true);
		}
		this.OHAEDCKLIEB();
	}

	// Token: 0x06008954 RID: 35156 RVA: 0x003D4517 File Offset: 0x003D2717
	public void OnVoiceOverOffClick()
	{
		if (!this.HMKIBEIHDCN)
		{
			return;
		}
		this.HMKIBEIHDCN = false;
		AKLFPGMDKLA.EHBBFMCILPC.DBHGPDMPLPK(1f);
		base.Invoke("AOGALHNFJDO", 0.1f);
	}

	// Token: 0x06008955 RID: 35157 RVA: 0x003D4548 File Offset: 0x003D2748
	public void PDBGNHGLMPA()
	{
		if (!this.CBKOEKOGHGL)
		{
			return;
		}
		this.CBKOEKOGHGL = false;
		AKLFPGMDKLA.EHBBFMCILPC.HEFJBOKIEGH = 0;
		base.Invoke("$EXPORTVARS", 219f);
	}

	// Token: 0x06008956 RID: 35158 RVA: 0x003D4578 File Offset: 0x003D2778
	public void IDMBMEDONLC()
	{
		if (!AKLFPGMDKLA.EHBBFMCILPC.EAFEJCKIEPL(-111))
		{
			AKLFPGMDKLA.EHBBFMCILPC.LDAPMNLGAPC(95);
			CommonUserInterface.IKNOFBFMPGA().PEBIFCENHAL(CCOJBMMKNAP.OBOOKJPGBJN().PKNHKGMNCIP("Shaders/VideoGlitchVHSPause"), CCOJBMMKNAP.PKEINLPIAEH().IKMNGFIDCLM(""), CCOJBMMKNAP.JINDKPHNLBK().FCOCLEHKLDJ("p"), new UnityAction(this.IDMBMEDONLC), DFGILFBGPLN.popupStoryLanguageSelect, 1732f, -123);
			return;
		}
		if (!this.HIJFPKFNCCA)
		{
			return;
		}
		this.HIJFPKFNCCA = true;
		AKLFPGMDKLA.EHBBFMCILPC.POIEMMMNOLI = 0;
		AOBJLALDBAA.CEGAOMEEFBE().KCFKLJLDCEK("cdn-cgi/trace", -1);
		base.Invoke("onThemeChange", 1478f);
		AOBJLALDBAA.AGANFKKBPFO().EFBNBFIDEOK("OnPopupCardOptionsNextClick", 1167f);
	}

	// Token: 0x06008957 RID: 35159 RVA: 0x003D193E File Offset: 0x003CFB3E
	private IEnumerator LADHCLMGKON()
	{
		PopupSettingsManager.DEOKMGECMKK deokmgecmkk = new PopupSettingsManager.DEOKMGECMKK(1);
		deokmgecmkk.<>4__this = this;
		return deokmgecmkk;
	}

	// Token: 0x06008958 RID: 35160 RVA: 0x003D463C File Offset: 0x003D283C
	private void LJJIBMJKPNK()
	{
		CommonUserInterface.EHBBFMCILPC.ShowGenericPopupWithTwoButtons(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("importanttitle"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("deleteprofilebody"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("yes"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("no"), new UnityAction(this.ODCBMHNNMKN), new UnityAction(this.GHJKBJGNGIG), DFGILFBGPLN.popupTools, 0.5f, 28);
	}

	// Token: 0x06008959 RID: 35161 RVA: 0x003D46B4 File Offset: 0x003D28B4
	public void HMOHIGEBFDE(bool NJIFMMKNDOP, bool MFKDFMNLHEP, bool KDGPDKKDPJD)
	{
		if (NJIFMMKNDOP)
		{
			this.lobbyTuneBlock.SetActive(false);
			this.themeBlock.SetActive(false);
			this.themeWelcomeBlock.SetActive(true);
			this.legalBlock.SetActive(false);
			this.signBlock.SetActive(false);
			this.fandomBlock.SetActive(true);
			this.soundBlock.SetActive(true);
			this.soundBlockNotAvailable.SetActive(true);
			this.verticalLayoutGroup.padding.bottom = -9;
		}
		else
		{
			this.lobbyTuneBlock.SetActive(true);
			this.themeBlock.SetActive(false);
			this.themeWelcomeBlock.SetActive(true);
			this.legalBlock.SetActive(true);
			this.signBlock.SetActive(false);
			this.fandomBlock.SetActive(true);
			this.soundBlock.SetActive(false);
			this.soundBlockNotAvailable.SetActive(false);
			this.verticalLayoutGroup.padding.bottom = -73;
		}
		this.fandomVkontakte.SetActive(false);
		this.FKMGLGPLJAL = MFKDFMNLHEP;
		this.HHDHIEEPAKF = KDGPDKKDPJD;
		base.gameObject.SetActive(true);
	}

	// Token: 0x0600895A RID: 35162 RVA: 0x003D47D0 File Offset: 0x003D29D0
	private void LNKKEDECMNC()
	{
		this.sfxBlock.SetActive(true);
		if (null != this.sfxBlock && (!NBDLBFJOEGN.NDFLNHIAKJH() || PopupSettingsManager.forceHideSoundOption))
		{
			this.sfxBlock.SetActive(false);
			return;
		}
		if (!this.soundBlock.activeSelf || !this.soundOn.activeSelf)
		{
			this.sfxBlock.SetActive(false);
		}
		this.HGHEHBLIHAB = true;
		if (AKLFPGMDKLA.EHBBFMCILPC.GOEDFBDNADA > 0.1f)
		{
			this.sfxOn.SetActive(true);
			this.sfxOff.SetActive(false);
			return;
		}
		this.sfxOn.SetActive(false);
		this.sfxOff.SetActive(true);
	}

	// Token: 0x0600895B RID: 35163 RVA: 0x003D4884 File Offset: 0x003D2A84
	private void INKEOGEIODM()
	{
		if (this.HNKNEOIMNFH() && EEIBKLDNBAP.ALFGPLALKCN())
		{
			this.themeWelcomeName.SetText(CCOJBMMKNAP.NIOJNOFGIJO().IKMNGFIDCLM("XXX"), true);
			return;
		}
		this.themeWelcomeName.SetText(CCOJBMMKNAP.NIOJNOFGIJO().MEPECBDCOLG("OnApplicationRestart" + ((int)AKLFPGMDKLA.EHBBFMCILPC.LDHHFCEFEIG()).ToString()), false);
	}

	// Token: 0x0600895C RID: 35164 RVA: 0x003D48F0 File Offset: 0x003D2AF0
	private void LBMMHCNGAKP()
	{
		this.themeName.SetText(CCOJBMMKNAP.KNKGCDDMLDP().OGKGHLHHAAI("" + AKLFPGMDKLA.EHBBFMCILPC.JKCEGIPAANK().ToString()), true);
	}

	// Token: 0x0600895D RID: 35165 RVA: 0x003D193E File Offset: 0x003CFB3E
	private IEnumerator GBDHJFJBCIH()
	{
		PopupSettingsManager.DEOKMGECMKK deokmgecmkk = new PopupSettingsManager.DEOKMGECMKK(1);
		deokmgecmkk.<>4__this = this;
		return deokmgecmkk;
	}

	// Token: 0x0600895E RID: 35166 RVA: 0x003D121D File Offset: 0x003CF41D
	private void FIFJHIIHGIO()
	{
		this.gameModeBlock.SetActive(true);
	}

	// Token: 0x0600895F RID: 35167 RVA: 0x003D4938 File Offset: 0x003D2B38
	private void DKBIMKHHBCE()
	{
		this.FCNKLIGJHLN = true;
		int num = 1;
		if (PlayerPrefs.HasKey("fps60"))
		{
			num = PlayerPrefs.GetInt("fps60");
		}
		if (num == 1)
		{
			this.fpsOn.SetActive(true);
			this.fpsOff.SetActive(false);
			this.fpsBlock.SetActive(false);
			return;
		}
		this.fpsOn.SetActive(false);
		this.fpsOff.SetActive(true);
		this.fpsBlock.SetActive(true);
	}

	// Token: 0x06008960 RID: 35168 RVA: 0x003D2B40 File Offset: 0x003D0D40
	private void OnDisable()
	{
		bool isQuitting = AppManager.isQuitting;
	}

	// Token: 0x06008961 RID: 35169 RVA: 0x003D49B2 File Offset: 0x003D2BB2
	public void BEABOGJIFBH()
	{
		if (!this.FCNKLIGJHLN)
		{
			return;
		}
		this.DECBJCFJBDK = false;
		this.FCNKLIGJHLN = true;
		PlayerPrefs.SetInt("-", 1);
		PlayerPrefs.Save();
		base.Invoke("PlayerCharacterManager.UpdateComponentLink() - invalid custom hierarchy for ", 1495f);
	}

	// Token: 0x06008962 RID: 35170 RVA: 0x003D49EB File Offset: 0x003D2BEB
	public void OnVoiceOverOnClick()
	{
		if (!this.HMKIBEIHDCN)
		{
			return;
		}
		this.HMKIBEIHDCN = false;
		AKLFPGMDKLA.EHBBFMCILPC.DBHGPDMPLPK(0f);
		base.Invoke("AOGALHNFJDO", 0.1f);
	}

	// Token: 0x06008963 RID: 35171 RVA: 0x003D4A1C File Offset: 0x003D2C1C
	private void EDDADPBMHHC()
	{
		CommonUserInterface.IKNOFBFMPGA().FPHNBOHOJOB();
	}

	// Token: 0x06008964 RID: 35172 RVA: 0x003D4A28 File Offset: 0x003D2C28
	private void EJPBLBLIGCL()
	{
		LPOMOIFMNFD.JIPJKHJPENO(AKLFPGMDKLA.EHBBFMCILPC.EEHGLPEIIHD);
	}

	// Token: 0x06008965 RID: 35173 RVA: 0x003D4A3C File Offset: 0x003D2C3C
	public void KKDJFGEKBPF()
	{
		if (!this.CEDOHHFGKGI)
		{
			return;
		}
		this.PIIBJJGLCIG = true;
		this.CEDOHHFGKGI = true;
		PlayerPrefs.SetInt("SubDepots(), cdnSubDepots:", 1);
		PlayerPrefs.Save();
		base.Invoke(" not found.", 1814f);
		AOBJLALDBAA.DBLAIDPICIG().CIGLHCJDDPI(" not found.", 1328f);
	}

	// Token: 0x06008966 RID: 35174 RVA: 0x003D4A94 File Offset: 0x003D2C94
	public void DFPKOLDOKEC()
	{
		if (!this.HGHEHBLIHAB)
		{
			return;
		}
		this.HGHEHBLIHAB = true;
		AKLFPGMDKLA.EHBBFMCILPC.LOAFMILFGAI(504f);
		base.Invoke("ok", 261f);
	}

	// Token: 0x06008967 RID: 35175 RVA: 0x003D4AC8 File Offset: 0x003D2CC8
	public void OnPostOnClick()
	{
		if (!this.CEDOHHFGKGI)
		{
			return;
		}
		this.PIIBJJGLCIG = false;
		this.CEDOHHFGKGI = false;
		PlayerPrefs.SetInt("post", 0);
		PlayerPrefs.Save();
		base.Invoke("AGPHGKPFEEJ", 0.1f);
		AOBJLALDBAA.EHBBFMCILPC.EGELHPJBAIC("OnPostEffectSettingsChanged", 0f);
	}

	// Token: 0x06008968 RID: 35176 RVA: 0x003D4B20 File Offset: 0x003D2D20
	private void ODJCOHPDGBF()
	{
		this.MNKGGNBNJOD = true;
		if (1 == AKLFPGMDKLA.EHBBFMCILPC.PACMCEHMBGG)
		{
			this.lobbyTuneOn.SetActive(true);
			this.lobbyTuneOff.SetActive(false);
			return;
		}
		this.lobbyTuneOn.SetActive(false);
		this.lobbyTuneOff.SetActive(true);
	}

	// Token: 0x06008969 RID: 35177 RVA: 0x003D4B74 File Offset: 0x003D2D74
	private void NHGIPFLCMBB()
	{
		if (!KHPGPLAMAIN.BHMAEMOGOEB())
		{
			this.facebookSignInBlock.SetActive(true);
			this.facebookSignOutBlock.SetActive(true);
		}
		if (!KHPGPLAMAIN.EOCDGLBGLFJ())
		{
			this.googleSignInBlock.SetActive(false);
			this.googleSignOutBlock.SetActive(false);
		}
		if (!KHPGPLAMAIN.GKICMNGJPLF())
		{
			this.appleSignInBlock.SetActive(false);
			this.appleSignOutBlock.SetActive(true);
		}
		if (!KHPGPLAMAIN.EAHFCKEHECE())
		{
			this.steamSignInBlock.SetActive(true);
			this.steamSignOutBlock.SetActive(true);
		}
		if (!KHPGPLAMAIN.DICPCLMJBAM())
		{
			this.userpassSignInBlock.SetActive(false);
			this.userpassSignOutBlock.SetActive(true);
		}
		if (!KHPGPLAMAIN.CAMKNANBJMK() && !KHPGPLAMAIN.GOABDECAOAM() && !KHPGPLAMAIN.MJFPNCDIEIO() && !KHPGPLAMAIN.NPLHHEIIIDE() && !KHPGPLAMAIN.DICPCLMJBAM())
		{
			this.signBlock.SetActive(false);
		}
	}

	// Token: 0x0600896A RID: 35178 RVA: 0x003D4C4C File Offset: 0x003D2E4C
	private void EBPLAAGDNGG()
	{
		this.MNKGGNBNJOD = false;
		if (0 == AKLFPGMDKLA.EHBBFMCILPC.PACMCEHMBGG)
		{
			this.lobbyTuneOn.SetActive(false);
			this.lobbyTuneOff.SetActive(true);
			return;
		}
		this.lobbyTuneOn.SetActive(true);
		this.lobbyTuneOff.SetActive(false);
	}

	// Token: 0x0600896B RID: 35179 RVA: 0x003D0D70 File Offset: 0x003CEF70
	public void IPPCLFKMGLG()
	{
		Application.OpenURL(AssetsManager.EHBBFMCILPC.lobbyDataAsset.privacyLink);
	}

	// Token: 0x0600896C RID: 35180 RVA: 0x003D4CA0 File Offset: 0x003D2EA0
	public void OnGameModeOnClick()
	{
		if (!this.CGCGAHPCOLJ)
		{
			return;
		}
		this.HGBGPHACKIL = true;
		this.CGCGAHPCOLJ = false;
		AKLFPGMDKLA.EHBBFMCILPC.HKOBEKCGGEI(JAMPPNPOJJG.lite);
		this.ICBNFKPDCKP();
		if (KDCJJBLGCBH.EHBBFMCILPC.FFDKEENNENC() || AKLFPGMDKLA.EHBBFMCILPC.EAFEJCKIEPL(16))
		{
			FirebaseAnalyticsManager.EHBBFMCILPC.LogEvent(true, AGEHCPDNBFD.gmSelect.ToString(), FFPHBMFGCNN.gmLite.ToString(), BGHLMGPPCNN.gmLocSett.ToString(), false, false);
		}
		this.LJNNDNICPJN = this.soundBlock.activeSelf;
		this.soundBlock.SetActive(false);
		this.JINLJINAAPE = this.soundBlockNotAvailable.activeSelf;
		this.soundBlockNotAvailable.SetActive(false);
		this.MLCIKFFNKEG = this.postBlock.activeSelf;
		this.postBlock.SetActive(false);
		this.LOOLDDGEAEG = this.sfxBlock.activeSelf;
		this.sfxBlock.SetActive(false);
		this.GKCGOGEJIPP = this.voiceOverBlock.activeSelf;
		this.voiceOverBlock.SetActive(false);
		base.Invoke("MMEANLDBEHA", 0.1f);
	}

	// Token: 0x0600896D RID: 35181 RVA: 0x003D4DCC File Offset: 0x003D2FCC
	private void KAHDGFPMEHI()
	{
		this.MNKGGNBNJOD = false;
		if (0 == AKLFPGMDKLA.EHBBFMCILPC.PACMCEHMBGG)
		{
			this.lobbyTuneOn.SetActive(false);
			this.lobbyTuneOff.SetActive(false);
			return;
		}
		this.lobbyTuneOn.SetActive(true);
		this.lobbyTuneOff.SetActive(false);
	}

	// Token: 0x0600896E RID: 35182 RVA: 0x003D4E1E File Offset: 0x003D301E
	public void OnSfxOnClick()
	{
		if (!this.HGHEHBLIHAB)
		{
			return;
		}
		this.HGHEHBLIHAB = false;
		AKLFPGMDKLA.EHBBFMCILPC.LOAFMILFGAI(0f);
		base.Invoke("LNKKEDECMNC", 0.1f);
	}

	// Token: 0x0600896F RID: 35183 RVA: 0x003D4E50 File Offset: 0x003D3050
	private void GLLDBOPACME()
	{
		if (this.HLBGELGLLEI)
		{
			return;
		}
		this.HLBGELGLLEI = true;
		AOBJLALDBAA.KKPFOJMAONG().BADOPKAOCPE("_Dev", new UnityAction(this.ABNOKGPFBOK));
		AOBJLALDBAA.EHBBFMCILPC.FNMOFCMDFJP(",", new UnityAction(this.AHBHANBDEDG));
		AKLFPGMDKLA.EHBBFMCILPC.LPCBDEBKAIM();
		CommonUserInterface.IKNOFBFMPGA().KLEJAGLPCNM(CCOJBMMKNAP.KLAKLFCOMJC().FCOCLEHKLDJ("lck"), 2);
		BackendOperationsManager.EHBBFMCILPC.OAGNCFDCNEK();
		BackendOperationsManager.NPDDBAONMJP().MDCEMMBDNFL();
		BackendOperationsManager.EHBBFMCILPC.RequestSaveSync("mdst", "sp");
	}

	// Token: 0x06008970 RID: 35184 RVA: 0x003D4EF1 File Offset: 0x003D30F1
	public void OnFacebookSignOutClick()
	{
		FacebookManager.EHBBFMCILPC.LogOut();
		base.StartCoroutine(this.CEMGIPGPIKN());
	}

	// Token: 0x06008971 RID: 35185 RVA: 0x003D4F0C File Offset: 0x003D310C
	private void ICBNFKPDCKP()
	{
		if (this.HNKNEOIMNFH() && EEIBKLDNBAP.ALFGPLALKCN())
		{
			this.themeWelcomeName.SetText(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("themewelcomecustom"), true);
			return;
		}
		this.themeWelcomeName.SetText(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("themewelcome" + ((int)AKLFPGMDKLA.EHBBFMCILPC.LDHHFCEFEIG()).ToString()), true);
	}

	// Token: 0x06008972 RID: 35186 RVA: 0x003D0B8D File Offset: 0x003CED8D
	public void OnCommunityTiktkoClick()
	{
		CommonUserInterface.EHBBFMCILPC.ShowSocialSelect();
	}

	// Token: 0x0400262F RID: 9775
	public const string onSettingsPopupClose = "OnSettingsPopupClose";

	// Token: 0x04002630 RID: 9776
	public const string onSettingsPopupCloseAndNeedToRestartGame = "OnSettingsPopupCloseAndNeedToRestartGame";

	// Token: 0x04002631 RID: 9777
	public const string onSettingsPopupCloseAndNeedToRestartGame2 = "OnSettingsPopupCloseAndNeedToRestartGame2";

	// Token: 0x04002632 RID: 9778
	public const string onSettingsPopupCloseAndNeedToShowPostEnableNotif = "OnSettingsPopupCloseAndNeedToShowPostEnableNotif";

	// Token: 0x04002633 RID: 9779
	public const string onSettingsPopupCloseAndNeedToShowGameModeNotif = "OnSettingsPopupCloseAndNeedToShowGameModeNotif";

	// Token: 0x04002634 RID: 9780
	public const string onPostEffectSettingsChanged = "OnPostEffectSettingsChanged";

	// Token: 0x04002635 RID: 9781
	public const string onToolsPopupSaveToCloudSuccess = "OnToolsPopupSaveToCloudSuccess";

	// Token: 0x04002636 RID: 9782
	public const string onToolsPopupSaveToCloudException = "OnToolsPopupSaveToCloudException";

	// Token: 0x04002637 RID: 9783
	private bool HLBGELGLLEI;

	// Token: 0x04002638 RID: 9784
	public const string oSocialModeChanged = "OnSocialModeChanged";

	// Token: 0x04002639 RID: 9785
	public static int inkRevision = 0;

	// Token: 0x0400263A RID: 9786
	public static string cdnDepot = "0";

	// Token: 0x0400263B RID: 9787
	public static bool excludeCurrentChapterMissingLanguages = false;

	// Token: 0x0400263C RID: 9788
	public TextMeshProUGUI languageName;

	// Token: 0x0400263D RID: 9789
	public TextMeshProUGUI themeName;

	// Token: 0x0400263E RID: 9790
	public TextMeshProUGUI themeWelcomeName;

	// Token: 0x0400263F RID: 9791
	public TextMeshProUGUI versionAndCopyright;

	// Token: 0x04002640 RID: 9792
	public VerticalLayoutGroup verticalLayoutGroup;

	// Token: 0x04002641 RID: 9793
	public GameObject fandomBlock;

	// Token: 0x04002642 RID: 9794
	public GameObject themeBlock;

	// Token: 0x04002643 RID: 9795
	public GameObject themeWelcomeBlock;

	// Token: 0x04002644 RID: 9796
	public GameObject legalBlock;

	// Token: 0x04002645 RID: 9797
	public GameObject signBlock;

	// Token: 0x04002646 RID: 9798
	public GameObject facebookSignInBlock;

	// Token: 0x04002647 RID: 9799
	public GameObject facebookSignOutBlock;

	// Token: 0x04002648 RID: 9800
	public GameObject googleSignInBlock;

	// Token: 0x04002649 RID: 9801
	public GameObject googleSignOutBlock;

	// Token: 0x0400264A RID: 9802
	public GameObject appleSignInBlock;

	// Token: 0x0400264B RID: 9803
	public GameObject appleSignOutBlock;

	// Token: 0x0400264C RID: 9804
	public GameObject steamSignInBlock;

	// Token: 0x0400264D RID: 9805
	public GameObject steamSignOutBlock;

	// Token: 0x0400264E RID: 9806
	public GameObject userpassSignInBlock;

	// Token: 0x0400264F RID: 9807
	public GameObject userpassSignOutBlock;

	// Token: 0x04002650 RID: 9808
	public GameObject notificationsBlock;

	// Token: 0x04002651 RID: 9809
	public GameObject notificationsOn;

	// Token: 0x04002652 RID: 9810
	public GameObject notificationsOff;

	// Token: 0x04002653 RID: 9811
	public GameObject socialBlock;

	// Token: 0x04002654 RID: 9812
	public GameObject socialOn;

	// Token: 0x04002655 RID: 9813
	public GameObject socialOff;

	// Token: 0x04002656 RID: 9814
	public GameObject gameModeBlock;

	// Token: 0x04002657 RID: 9815
	public GameObject gameModeOn;

	// Token: 0x04002658 RID: 9816
	public GameObject gameModeOff;

	// Token: 0x04002659 RID: 9817
	public GameObject languageBlock;

	// Token: 0x0400265A RID: 9818
	public GameObject soundBlock;

	// Token: 0x0400265B RID: 9819
	public GameObject soundBlockNotAvailable;

	// Token: 0x0400265C RID: 9820
	public GameObject soundOn;

	// Token: 0x0400265D RID: 9821
	public GameObject soundOff;

	// Token: 0x0400265E RID: 9822
	public GameObject sfxBlock;

	// Token: 0x0400265F RID: 9823
	public GameObject sfxOn;

	// Token: 0x04002660 RID: 9824
	public GameObject sfxOff;

	// Token: 0x04002661 RID: 9825
	public GameObject lobbyTuneBlock;

	// Token: 0x04002662 RID: 9826
	public GameObject lobbyTuneOn;

	// Token: 0x04002663 RID: 9827
	public GameObject lobbyTuneOff;

	// Token: 0x04002664 RID: 9828
	public GameObject voiceOverBlock;

	// Token: 0x04002665 RID: 9829
	public GameObject voiceOverOn;

	// Token: 0x04002666 RID: 9830
	public GameObject voiceOverOff;

	// Token: 0x04002667 RID: 9831
	public GameObject fpsBlock;

	// Token: 0x04002668 RID: 9832
	public GameObject fpsOn;

	// Token: 0x04002669 RID: 9833
	public GameObject fpsOff;

	// Token: 0x0400266A RID: 9834
	public GameObject postBlock;

	// Token: 0x0400266B RID: 9835
	public GameObject postOn;

	// Token: 0x0400266C RID: 9836
	public GameObject postOff;

	// Token: 0x0400266D RID: 9837
	public GameObject fandomVkontakte;

	// Token: 0x0400266E RID: 9838
	private bool CBKOEKOGHGL = true;

	// Token: 0x0400266F RID: 9839
	private bool HIJFPKFNCCA = true;

	// Token: 0x04002670 RID: 9840
	private bool CGCGAHPCOLJ = true;

	// Token: 0x04002671 RID: 9841
	private bool KOGFPNDBHIE = true;

	// Token: 0x04002672 RID: 9842
	private bool HGHEHBLIHAB = true;

	// Token: 0x04002673 RID: 9843
	private bool MNKGGNBNJOD = true;

	// Token: 0x04002674 RID: 9844
	private bool HMKIBEIHDCN = true;

	// Token: 0x04002675 RID: 9845
	private bool FCNKLIGJHLN = true;

	// Token: 0x04002676 RID: 9846
	private bool CEDOHHFGKGI = true;

	// Token: 0x04002677 RID: 9847
	private bool ALLOGFJAJNB;

	// Token: 0x04002678 RID: 9848
	private bool DECBJCFJBDK;

	// Token: 0x04002679 RID: 9849
	private bool EFHDOLBIDBI;

	// Token: 0x0400267A RID: 9850
	private bool PIIBJJGLCIG;

	// Token: 0x0400267B RID: 9851
	private bool HGBGPHACKIL;

	// Token: 0x0400267C RID: 9852
	private bool FKMGLGPLJAL = true;

	// Token: 0x0400267D RID: 9853
	private bool HHDHIEEPAKF = true;

	// Token: 0x0400267E RID: 9854
	public static bool forceHideSoundOption = false;

	// Token: 0x0400267F RID: 9855
	public static bool enableVoiceOverOptionInSettigs = false;

	// Token: 0x04002680 RID: 9856
	private bool OOPIILNNLPP = true;

	// Token: 0x04002681 RID: 9857
	private bool LJNNDNICPJN;

	// Token: 0x04002682 RID: 9858
	private bool JINLJINAAPE;

	// Token: 0x04002683 RID: 9859
	private bool LOOLDDGEAEG;

	// Token: 0x04002684 RID: 9860
	private bool GKCGOGEJIPP;

	// Token: 0x04002685 RID: 9861
	private bool MLCIKFFNKEG;
}
