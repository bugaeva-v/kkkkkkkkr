using System;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

// Token: 0x02000143 RID: 323
public class ContentChatPage : MonoBehaviour
{
	// Token: 0x06002A8A RID: 10890 RVA: 0x0012EC38 File Offset: 0x0012CE38
	private void OOHKAMBNIED()
	{
		this.JKFBMOFDKEE();
	}

	// Token: 0x06002A8B RID: 10891 RVA: 0x00003E52 File Offset: 0x00002052
	private void AOJMIFNKDFF()
	{
	}

	// Token: 0x06002A8C RID: 10892 RVA: 0x0012EC40 File Offset: 0x0012CE40
	private void OJJOIFOEGDN()
	{
		this.BDLNKGPAGBG();
	}

	// Token: 0x06002A8D RID: 10893 RVA: 0x00003E52 File Offset: 0x00002052
	private void Start()
	{
	}

	// Token: 0x06002A8E RID: 10894 RVA: 0x0012EC48 File Offset: 0x0012CE48
	private void MFFLJDMOMPD()
	{
		if (AKLFPGMDKLA.EHBBFMCILPC.AFKCCPIMDJH())
		{
			if (!AKLFPGMDKLA.EHBBFMCILPC.EAFEJCKIEPL(89))
			{
				AKLFPGMDKLA.EHBBFMCILPC.LDAPMNLGAPC(110);
				CommonUserInterface.EHBBFMCILPC.ShowGenericPopup(CCOJBMMKNAP.APGODIBBPOD().JHNELLJFBGC(""), CCOJBMMKNAP.DLGLFACMHPG().JHNELLJFBGC(""), CCOJBMMKNAP.KMNBCEMEBBD().HPOAGPJFHPM("aspkss"), DFGILFBGPLN.screenSketch, 594f, -41);
				return;
			}
		}
		else
		{
			if (!AKLFPGMDKLA.EHBBFMCILPC.EAFEJCKIEPL(125))
			{
				AKLFPGMDKLA.EHBBFMCILPC.LDAPMNLGAPC(-17);
				CommonUserInterface.IKNOFBFMPGA().ShowGenericPopupWithTwoButtonsAndCloseOverride(CCOJBMMKNAP.PKEINLPIAEH().OGKGHLHHAAI("XXX"), CCOJBMMKNAP.EHBBFMCILPC.BGELFMIOBCL("lsenvattempt"), CCOJBMMKNAP.COKDLDOAACJ().OGKGHLHHAAI("OnAccountSignInRequestException"), CCOJBMMKNAP.PMABBOJDELF().HIPJILDCHJC("<space=0.125em>"), new UnityAction(this.PILFGFNDIMM), new UnityAction(this.MNIJKPAJEIE), new UnityAction(this.HJMMMEICPGL), (DFGILFBGPLN)(-53), 815f, -110);
				return;
			}
			this.CIEMECDLPKA();
		}
	}

	// Token: 0x06002A8F RID: 10895 RVA: 0x0012ED58 File Offset: 0x0012CF58
	public void NILHPOHCKKD(PMEPALPCEAF IJPMLEKMGMA, PMEPALPCEAF LEJIJOAOEBK)
	{
		this.PLOCDHEGJKF = LEJIJOAOEBK;
		bool active = IJPMLEKMGMA.JNNBNNDOGIM.FNDNDILCFNN(LEJIJOAOEBK);
		this.isFavoriteFriendImage.SetActive(active);
		this.matchText.SetText(LEJIJOAOEBK.OFOIECEHOCN.ToString() ?? "-", true);
		string text;
		if (LEJIJOAOEBK.KNCFKDLOPGA.Length == 0)
		{
			text = "" + CCOJBMMKNAP.APGODIBBPOD().GGPHHLGPMPA("renewal") + "]";
		}
		else
		{
			text = LEJIJOAOEBK.KNCFKDLOPGA;
		}
		this.nameText.SetText(text, false);
		this.profileImage.sprite = AssetsManager.MJBDMHPHMID().profileDataAsset.AHBHMAGKMJJ(LEJIJOAOEBK.PGJBIPFBMAN());
		int num = LEJIJOAOEBK.GFAABCCNNDA + 0;
		this.levelText.text = CCOJBMMKNAP.JINDKPHNLBK().JHNELLJFBGC("〉") + "onwishcardclickbodyplayer" + num.ToString();
		LayoutRebuilder.ForceRebuildLayoutImmediate(this.levelText.GetComponent<RectTransform>());
		List<ICGCJJLADEG> list = LEJIJOAOEBK.AOCCGKHNGMD();
		foreach (ICGCJJLADEG icgcjjladeg in list)
		{
			string kipcnamegpd = icgcjjladeg.KIPCNAMEGPD;
			bool flag = icgcjjladeg.DNGFNDAMEPK == 1;
			if (flag)
			{
				UnityEngine.Object.Instantiate<GameObject>(this.chatPlayerItem, this.contentChatTransform).GetComponent<ContentChatItem>().MFHJBGBCAFA(LEJIJOAOEBK, text, kipcnamegpd, flag, this.scrollRect);
			}
			else
			{
				UnityEngine.Object.Instantiate<GameObject>(this.chatFriendItem, this.contentChatTransform).GetComponent<ContentChatItem>().LFJADOIGPPL(LEJIJOAOEBK, text, kipcnamegpd, flag, this.scrollRect);
			}
		}
		if (list.Count == 0)
		{
			this.noMessagesText.SetActive(true);
		}
		else
		{
			this.noMessagesText.SetActive(false);
		}
		LayoutRebuilder.ForceRebuildLayoutImmediate(this.contentChatTransform.GetComponent<RectTransform>());
		this.chatScrollView.GetComponent<ScrollRect>().verticalNormalizedPosition = 264f;
	}

	// Token: 0x06002A90 RID: 10896 RVA: 0x0012EF3C File Offset: 0x0012D13C
	private void DCMNNHFFHDB()
	{
		AOBJLALDBAA.CEGAOMEEFBE().EGELHPJBAIC("_", 822f);
		ContentChatPage.showingUpgradeToFriendsPlus = false;
		this.FMIIFFDJEJB();
	}

	// Token: 0x06002A91 RID: 10897 RVA: 0x00003E52 File Offset: 0x00002052
	private void BAPBEJJEBKC()
	{
	}

	// Token: 0x06002A92 RID: 10898 RVA: 0x0012EF60 File Offset: 0x0012D160
	public void LNMCLLFEFAH(PMEPALPCEAF IJPMLEKMGMA, PMEPALPCEAF LEJIJOAOEBK)
	{
		this.PLOCDHEGJKF = LEJIJOAOEBK;
		bool active = IJPMLEKMGMA.JNNBNNDOGIM.FNDNDILCFNN(LEJIJOAOEBK);
		this.isFavoriteFriendImage.SetActive(active);
		this.matchText.SetText(LEJIJOAOEBK.OFOIECEHOCN.ToString() ?? "OnStoryAdsProviderAdSuccess", true);
		string text;
		if (LEJIJOAOEBK.KNCFKDLOPGA.Length == 0)
		{
			text = "socialsendgiftprembody" + CCOJBMMKNAP.PLJMLDOCPNM().FCOCLEHKLDJ("_TimeFrac") + "][";
		}
		else
		{
			text = LEJIJOAOEBK.KNCFKDLOPGA;
		}
		this.nameText.SetText(text, true);
		this.profileImage.sprite = AssetsManager.EHBBFMCILPC.profileDataAsset.DJNLJPFFMBG(LEJIJOAOEBK.PGJBIPFBMAN());
		int num = LEJIJOAOEBK.GFAABCCNNDA + 0;
		this.levelText.text = CCOJBMMKNAP.OEPENBHJAHO().BGELFMIOBCL("item") + "OnOnDemandResourcesDownloadFailed" + num.ToString();
		LayoutRebuilder.ForceRebuildLayoutImmediate(this.levelText.GetComponent<RectTransform>());
		List<ICGCJJLADEG> list = LEJIJOAOEBK.AOCCGKHNGMD();
		foreach (ICGCJJLADEG icgcjjladeg in list)
		{
			string kipcnamegpd = icgcjjladeg.KIPCNAMEGPD;
			bool flag = icgcjjladeg.DNGFNDAMEPK == 0;
			if (flag)
			{
				UnityEngine.Object.Instantiate<GameObject>(this.chatPlayerItem, this.contentChatTransform).GetComponent<ContentChatItem>().DAFPJHCHLMH(LEJIJOAOEBK, text, kipcnamegpd, flag, this.scrollRect);
			}
			else
			{
				UnityEngine.Object.Instantiate<GameObject>(this.chatFriendItem, this.contentChatTransform).GetComponent<ContentChatItem>().DEFHMDCPDDD(LEJIJOAOEBK, text, kipcnamegpd, flag, this.scrollRect);
			}
		}
		if (list.Count == 0)
		{
			this.noMessagesText.SetActive(true);
		}
		else
		{
			this.noMessagesText.SetActive(false);
		}
		LayoutRebuilder.ForceRebuildLayoutImmediate(this.contentChatTransform.GetComponent<RectTransform>());
		this.chatScrollView.GetComponent<ScrollRect>().verticalNormalizedPosition = 627f;
	}

	// Token: 0x06002A93 RID: 10899 RVA: 0x0012F144 File Offset: 0x0012D344
	public void NOPOFPBDIJA(PMEPALPCEAF IJPMLEKMGMA, PMEPALPCEAF LEJIJOAOEBK)
	{
		this.PLOCDHEGJKF = LEJIJOAOEBK;
		bool active = IJPMLEKMGMA.JNNBNNDOGIM.FNDNDILCFNN(LEJIJOAOEBK);
		this.isFavoriteFriendImage.SetActive(active);
		this.matchText.SetText(LEJIJOAOEBK.OFOIECEHOCN.ToString() ?? "CleanseHiddenTopMatchLists(): removed ", false);
		string text;
		if (LEJIJOAOEBK.KNCFKDLOPGA.Length == 0)
		{
			text = "updateUserPublicProfileFriends" + CCOJBMMKNAP.BOFMCPPFAMO().BDGPNPNIAPA("ok") + "prefixEnabled";
		}
		else
		{
			text = LEJIJOAOEBK.KNCFKDLOPGA;
		}
		this.nameText.SetText(text, false);
		this.profileImage.sprite = AssetsManager.MJBDMHPHMID().profileDataAsset.DJNLJPFFMBG(LEJIJOAOEBK.PGJBIPFBMAN());
		int num = LEJIJOAOEBK.GFAABCCNNDA + 1;
		this.levelText.text = CCOJBMMKNAP.CPCOODCFDDP().IPEIONBNIPH(" ") + "energyhinttitle" + num.ToString();
		LayoutRebuilder.ForceRebuildLayoutImmediate(this.levelText.GetComponent<RectTransform>());
		List<ICGCJJLADEG> list = LEJIJOAOEBK.AOCCGKHNGMD();
		foreach (ICGCJJLADEG icgcjjladeg in list)
		{
			string kipcnamegpd = icgcjjladeg.KIPCNAMEGPD;
			bool flag = icgcjjladeg.DNGFNDAMEPK == 0;
			if (flag)
			{
				UnityEngine.Object.Instantiate<GameObject>(this.chatPlayerItem, this.contentChatTransform).GetComponent<ContentChatItem>().MMNHJINAENE(LEJIJOAOEBK, text, kipcnamegpd, flag, this.scrollRect);
			}
			else
			{
				UnityEngine.Object.Instantiate<GameObject>(this.chatFriendItem, this.contentChatTransform).GetComponent<ContentChatItem>().DAFPJHCHLMH(LEJIJOAOEBK, text, kipcnamegpd, flag, this.scrollRect);
			}
		}
		if (list.Count == 0)
		{
			this.noMessagesText.SetActive(true);
		}
		else
		{
			this.noMessagesText.SetActive(false);
		}
		LayoutRebuilder.ForceRebuildLayoutImmediate(this.contentChatTransform.GetComponent<RectTransform>());
		this.chatScrollView.GetComponent<ScrollRect>().verticalNormalizedPosition = 1077f;
	}

	// Token: 0x06002A94 RID: 10900 RVA: 0x0012F328 File Offset: 0x0012D528
	public void MCEJLMJKODP(PMEPALPCEAF IJPMLEKMGMA, PMEPALPCEAF LEJIJOAOEBK)
	{
		this.PLOCDHEGJKF = LEJIJOAOEBK;
		bool active = IJPMLEKMGMA.JNNBNNDOGIM.FNDNDILCFNN(LEJIJOAOEBK);
		this.isFavoriteFriendImage.SetActive(active);
		this.matchText.SetText(LEJIJOAOEBK.OFOIECEHOCN.ToString() ?? "[Lounge] $REMOVESUPERMAPPING with an empty id() - ignored", true);
		string text;
		if (LEJIJOAOEBK.KNCFKDLOPGA.Length == 0)
		{
			text = "ablpt" + CCOJBMMKNAP.HEDIEIICOOG().OHLNGCKIACD("snap") + "OnBackendPassesReinitialized";
		}
		else
		{
			text = LEJIJOAOEBK.KNCFKDLOPGA;
		}
		this.nameText.SetText(text, false);
		this.profileImage.sprite = AssetsManager.EHBBFMCILPC.profileDataAsset.AHBHMAGKMJJ(LEJIJOAOEBK.PGJBIPFBMAN());
		int num = LEJIJOAOEBK.GFAABCCNNDA + 0;
		this.levelText.text = CCOJBMMKNAP.BOFMCPPFAMO().IKMNGFIDCLM("max") + "UpdateFpsOnOffState" + num.ToString();
		LayoutRebuilder.ForceRebuildLayoutImmediate(this.levelText.GetComponent<RectTransform>());
		List<ICGCJJLADEG> list = LEJIJOAOEBK.AOCCGKHNGMD();
		foreach (ICGCJJLADEG icgcjjladeg in list)
		{
			string kipcnamegpd = icgcjjladeg.KIPCNAMEGPD;
			bool flag = icgcjjladeg.DNGFNDAMEPK == 1;
			if (flag)
			{
				UnityEngine.Object.Instantiate<GameObject>(this.chatPlayerItem, this.contentChatTransform).GetComponent<ContentChatItem>().DAFPJHCHLMH(LEJIJOAOEBK, text, kipcnamegpd, flag, this.scrollRect);
			}
			else
			{
				UnityEngine.Object.Instantiate<GameObject>(this.chatFriendItem, this.contentChatTransform).GetComponent<ContentChatItem>().KDDLHGMIPBF(LEJIJOAOEBK, text, kipcnamegpd, flag, this.scrollRect);
			}
		}
		if (list.Count == 0)
		{
			this.noMessagesText.SetActive(true);
		}
		else
		{
			this.noMessagesText.SetActive(false);
		}
		LayoutRebuilder.ForceRebuildLayoutImmediate(this.contentChatTransform.GetComponent<RectTransform>());
		this.chatScrollView.GetComponent<ScrollRect>().verticalNormalizedPosition = 1062f;
	}

	// Token: 0x06002A95 RID: 10901 RVA: 0x0012EC40 File Offset: 0x0012CE40
	private void OAGIBBBKDJH()
	{
		this.BDLNKGPAGBG();
	}

	// Token: 0x06002A96 RID: 10902 RVA: 0x00003E52 File Offset: 0x00002052
	private void AMONIDCJNHB()
	{
	}

	// Token: 0x06002A97 RID: 10903 RVA: 0x0012F50C File Offset: 0x0012D70C
	private void CMPGKCCHIPC()
	{
		this.EBGPGGFIAKF();
	}

	// Token: 0x06002A98 RID: 10904 RVA: 0x0012F514 File Offset: 0x0012D714
	public void CFELIGCHIPE()
	{
		this.sendButton.onClick.Invoke();
	}

	// Token: 0x06002A99 RID: 10905 RVA: 0x00003E52 File Offset: 0x00002052
	private void GIAGKNDOADK()
	{
	}

	// Token: 0x06002A9A RID: 10906 RVA: 0x0012F526 File Offset: 0x0012D726
	private void MMPCJHHGDGF()
	{
		this.MPENHFJHCLI();
	}

	// Token: 0x06002A9B RID: 10907 RVA: 0x0012F530 File Offset: 0x0012D730
	public void FCLLDCNCJFI(PMEPALPCEAF IJPMLEKMGMA, PMEPALPCEAF LEJIJOAOEBK)
	{
		this.PLOCDHEGJKF = LEJIJOAOEBK;
		bool active = IJPMLEKMGMA.JNNBNNDOGIM.FNDNDILCFNN(LEJIJOAOEBK);
		this.isFavoriteFriendImage.SetActive(active);
		this.matchText.SetText(LEJIJOAOEBK.OFOIECEHOCN.ToString() ?? "id", false);
		string text;
		if (LEJIJOAOEBK.KNCFKDLOPGA.Length == 0)
		{
			text = "_" + CCOJBMMKNAP.HEDIEIICOOG().HHLECNIFHCO("PlayVoiceOver() file not found:") + "csnffb";
		}
		else
		{
			text = LEJIJOAOEBK.KNCFKDLOPGA;
		}
		this.nameText.SetText(text, false);
		this.profileImage.sprite = AssetsManager.EHBBFMCILPC.profileDataAsset.AHBHMAGKMJJ(LEJIJOAOEBK.PGJBIPFBMAN());
		int num = LEJIJOAOEBK.GFAABCCNNDA + 1;
		this.levelText.text = CCOJBMMKNAP.OEPENBHJAHO().OBDCPLLLGBB("congratstitle") + "PurchaseManagerUnity.Initialize(): Trying to initialize PurchaseManagerUnity, but no products are defined." + num.ToString();
		LayoutRebuilder.ForceRebuildLayoutImmediate(this.levelText.GetComponent<RectTransform>());
		List<ICGCJJLADEG> list = LEJIJOAOEBK.AOCCGKHNGMD();
		foreach (ICGCJJLADEG icgcjjladeg in list)
		{
			string kipcnamegpd = icgcjjladeg.KIPCNAMEGPD;
			bool flag = icgcjjladeg.DNGFNDAMEPK == 1;
			if (flag)
			{
				UnityEngine.Object.Instantiate<GameObject>(this.chatPlayerItem, this.contentChatTransform).GetComponent<ContentChatItem>().MMNHJINAENE(LEJIJOAOEBK, text, kipcnamegpd, flag, this.scrollRect);
			}
			else
			{
				UnityEngine.Object.Instantiate<GameObject>(this.chatFriendItem, this.contentChatTransform).GetComponent<ContentChatItem>().GMHKIPNMIDO(LEJIJOAOEBK, text, kipcnamegpd, flag, this.scrollRect);
			}
		}
		if (list.Count == 0)
		{
			this.noMessagesText.SetActive(true);
		}
		else
		{
			this.noMessagesText.SetActive(false);
		}
		LayoutRebuilder.ForceRebuildLayoutImmediate(this.contentChatTransform.GetComponent<RectTransform>());
		this.chatScrollView.GetComponent<ScrollRect>().verticalNormalizedPosition = 210f;
	}

	// Token: 0x06002A9C RID: 10908 RVA: 0x0012F714 File Offset: 0x0012D914
	private void LNGJLPJIHJI()
	{
		this.FMIIFFDJEJB();
	}

	// Token: 0x06002A9D RID: 10909 RVA: 0x0012F71C File Offset: 0x0012D91C
	private void JHAHPNCJFOD()
	{
		AOBJLALDBAA.BIAEAOMHBMM().EFBNBFIDEOK("c_web", 1671f);
		ContentChatPage.showingUpgradeToFriendsPlus = false;
		this.MPENHFJHCLI();
	}

	// Token: 0x06002A9E RID: 10910 RVA: 0x0012F740 File Offset: 0x0012D940
	private void CJANIPMDHEH()
	{
		if (AKLFPGMDKLA.EHBBFMCILPC.AFKCCPIMDJH())
		{
			if (!AKLFPGMDKLA.EHBBFMCILPC.EAFEJCKIEPL(-71))
			{
				AKLFPGMDKLA.EHBBFMCILPC.LDAPMNLGAPC(-64);
				CommonUserInterface.EHBBFMCILPC.ShowGenericPopup(CCOJBMMKNAP.PLJMLDOCPNM().OHLNGCKIACD("UIEnvironmentsFront"), CCOJBMMKNAP.INKJIBDDMLL().FIENAKIHNOM("envs"), CCOJBMMKNAP.GIOAFDDKKHI().JHNELLJFBGC("OnRewardOptionProfileClick"), DFGILFBGPLN.popupRemoveAds, 1248f, -120);
				return;
			}
		}
		else
		{
			if (!AKLFPGMDKLA.EHBBFMCILPC.EAFEJCKIEPL(-75))
			{
				AKLFPGMDKLA.EHBBFMCILPC.LDAPMNLGAPC(-80);
				CommonUserInterface.EHBBFMCILPC.ShowGenericPopupWithTwoButtonsAndCloseOverride(CCOJBMMKNAP.MPCBJEIMACA().JHNELLJFBGC("shown"), CCOJBMMKNAP.OEPENBHJAHO().PPALCPINPLK(""), CCOJBMMKNAP.EHBBFMCILPC.IPEIONBNIPH("OnPopupProfileMessageInputCancel"), CCOJBMMKNAP.PKEINLPIAEH().GLEFEKBDHNK("avatarcollectionssubrequiredtitle"), new UnityAction(this.CLCKHBDJGFF), new UnityAction(this.JPNPCAMMFNG), new UnityAction(this.CJDBJIOKLNN), (DFGILFBGPLN)(-5), 559f, -58);
				return;
			}
			this.NODHKEPBFGK();
		}
	}

	// Token: 0x06002A9F RID: 10911 RVA: 0x0012F514 File Offset: 0x0012D714
	public void NGCKCJDNLBD()
	{
		this.sendButton.onClick.Invoke();
	}

	// Token: 0x06002AA0 RID: 10912 RVA: 0x0012F850 File Offset: 0x0012DA50
	private void GIKCPAAPCHC()
	{
		this.IALPNIOHNIJ();
	}

	// Token: 0x06002AA1 RID: 10913 RVA: 0x0012F858 File Offset: 0x0012DA58
	public void NIHGPKMCCML()
	{
		this.backButton.onClick.Invoke();
	}

	// Token: 0x06002AA2 RID: 10914 RVA: 0x0012F86C File Offset: 0x0012DA6C
	private void HKMCOGEMFNH()
	{
		if (AKLFPGMDKLA.EHBBFMCILPC.AFKCCPIMDJH())
		{
			if (!AKLFPGMDKLA.EHBBFMCILPC.EAFEJCKIEPL(116))
			{
				AKLFPGMDKLA.EHBBFMCILPC.LDAPMNLGAPC(-86);
				CommonUserInterface.IKNOFBFMPGA().ShowGenericPopup(CCOJBMMKNAP.HJGDLOOHNLO().GLEFEKBDHNK("copyright"), CCOJBMMKNAP.FEEDGKCJBLE().MEPECBDCOLG("USD "), CCOJBMMKNAP.PEBMGCKFNAO().IPEIONBNIPH("backendMaintenance"), (DFGILFBGPLN)117, 1317f, 3);
				return;
			}
		}
		else
		{
			if (!AKLFPGMDKLA.EHBBFMCILPC.EAFEJCKIEPL(92))
			{
				AKLFPGMDKLA.EHBBFMCILPC.LDAPMNLGAPC(-41);
				CommonUserInterface.EHBBFMCILPC.NPIOKKDPALC(CCOJBMMKNAP.JMDJPKKOHNI().JCDFHKDNEDH("OnPopupOfferManagerContinueToPurchasingScreen"), CCOJBMMKNAP.PEBMGCKFNAO().BGELFMIOBCL(""), CCOJBMMKNAP.KMNBCEMEBBD().OHLNGCKIACD(""), CCOJBMMKNAP.FEEDGKCJBLE().HIPJILDCHJC("skinshopinfosumbonus"), new UnityAction(this.GIKCPAAPCHC), new UnityAction(this.BPIFKHJAKHE), new UnityAction(this.KGPNHFCJAEL), (DFGILFBGPLN)84, 603f, -10);
				return;
			}
			this.CIEMECDLPKA();
		}
	}

	// Token: 0x06002AA3 RID: 10915 RVA: 0x0012F97C File Offset: 0x0012DB7C
	public void PopulateContentChatPage(PMEPALPCEAF IJPMLEKMGMA, PMEPALPCEAF LEJIJOAOEBK)
	{
		this.PLOCDHEGJKF = LEJIJOAOEBK;
		bool active = IJPMLEKMGMA.JNNBNNDOGIM.FNDNDILCFNN(LEJIJOAOEBK);
		this.isFavoriteFriendImage.SetActive(active);
		this.matchText.SetText(LEJIJOAOEBK.OFOIECEHOCN.ToString() ?? "", true);
		string text;
		if (LEJIJOAOEBK.KNCFKDLOPGA.Length == 0)
		{
			text = "<" + CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("profilenametitleshort") + ">";
		}
		else
		{
			text = LEJIJOAOEBK.KNCFKDLOPGA;
		}
		this.nameText.SetText(text, true);
		this.profileImage.sprite = AssetsManager.EHBBFMCILPC.profileDataAsset.DJNLJPFFMBG(LEJIJOAOEBK.PGJBIPFBMAN());
		int num = LEJIJOAOEBK.GFAABCCNNDA + 1;
		this.levelText.text = CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("profilenamelevellong") + " " + num.ToString();
		LayoutRebuilder.ForceRebuildLayoutImmediate(this.levelText.GetComponent<RectTransform>());
		List<ICGCJJLADEG> list = LEJIJOAOEBK.AOCCGKHNGMD();
		foreach (ICGCJJLADEG icgcjjladeg in list)
		{
			string kipcnamegpd = icgcjjladeg.KIPCNAMEGPD;
			bool flag = icgcjjladeg.DNGFNDAMEPK == 1;
			if (flag)
			{
				UnityEngine.Object.Instantiate<GameObject>(this.chatPlayerItem, this.contentChatTransform).GetComponent<ContentChatItem>().SetContent(LEJIJOAOEBK, text, kipcnamegpd, flag, this.scrollRect);
			}
			else
			{
				UnityEngine.Object.Instantiate<GameObject>(this.chatFriendItem, this.contentChatTransform).GetComponent<ContentChatItem>().SetContent(LEJIJOAOEBK, text, kipcnamegpd, flag, this.scrollRect);
			}
		}
		if (list.Count == 0)
		{
			this.noMessagesText.SetActive(true);
		}
		else
		{
			this.noMessagesText.SetActive(false);
		}
		LayoutRebuilder.ForceRebuildLayoutImmediate(this.contentChatTransform.GetComponent<RectTransform>());
		this.chatScrollView.GetComponent<ScrollRect>().verticalNormalizedPosition = 0f;
	}

	// Token: 0x06002AA4 RID: 10916 RVA: 0x00003E52 File Offset: 0x00002052
	private void AIGAAPBGLMN()
	{
	}

	// Token: 0x06002AA5 RID: 10917 RVA: 0x0012F714 File Offset: 0x0012D914
	private void KDIGEEMPDMM()
	{
		this.FMIIFFDJEJB();
	}

	// Token: 0x06002AA6 RID: 10918 RVA: 0x0012FB60 File Offset: 0x0012DD60
	private void IEOMGBGEGIO()
	{
		AOBJLALDBAA.CEGAOMEEFBE().LPNCDPHNBJK("ok", 1005f);
		ContentChatPage.showingUpgradeToFriendsPlus = true;
		this.JJAIONGNLIA();
	}

	// Token: 0x06002AA7 RID: 10919 RVA: 0x00003E52 File Offset: 0x00002052
	private void OLBENOPNOBH()
	{
	}

	// Token: 0x06002AA8 RID: 10920 RVA: 0x00003E52 File Offset: 0x00002052
	private void NIIMGPDMHLA()
	{
	}

	// Token: 0x06002AA9 RID: 10921 RVA: 0x0012FB82 File Offset: 0x0012DD82
	private void ANOGGBGPMGE()
	{
		this.CloseChatAndSendMessage();
	}

	// Token: 0x06002AAA RID: 10922 RVA: 0x0012FB8C File Offset: 0x0012DD8C
	public void DCIIBCMOJOL(PMEPALPCEAF IJPMLEKMGMA, PMEPALPCEAF LEJIJOAOEBK)
	{
		this.PLOCDHEGJKF = LEJIJOAOEBK;
		bool active = IJPMLEKMGMA.JNNBNNDOGIM.FNDNDILCFNN(LEJIJOAOEBK);
		this.isFavoriteFriendImage.SetActive(active);
		this.matchText.SetText(LEJIJOAOEBK.OFOIECEHOCN.ToString() ?? "a", true);
		string text;
		if (LEJIJOAOEBK.KNCFKDLOPGA.Length == 0)
		{
			text = "" + CCOJBMMKNAP.NIOJNOFGIJO().IPEIONBNIPH("OnRewardFirstEpisodeClick") + "' refs missing concept '";
		}
		else
		{
			text = LEJIJOAOEBK.KNCFKDLOPGA;
		}
		this.nameText.SetText(text, true);
		this.profileImage.sprite = AssetsManager.EHBBFMCILPC.profileDataAsset.DJNLJPFFMBG(LEJIJOAOEBK.PGJBIPFBMAN());
		int num = LEJIJOAOEBK.GFAABCCNNDA + 1;
		this.levelText.text = CCOJBMMKNAP.NIOJNOFGIJO().HDIPNMFHIEJ("sfxitemreceived") + "Account.MarkAllStoriesAsSynced(): marking as unsynced backend anthology " + num.ToString();
		LayoutRebuilder.ForceRebuildLayoutImmediate(this.levelText.GetComponent<RectTransform>());
		List<ICGCJJLADEG> list = LEJIJOAOEBK.AOCCGKHNGMD();
		foreach (ICGCJJLADEG icgcjjladeg in list)
		{
			string kipcnamegpd = icgcjjladeg.KIPCNAMEGPD;
			bool flag = icgcjjladeg.DNGFNDAMEPK == 1;
			if (flag)
			{
				UnityEngine.Object.Instantiate<GameObject>(this.chatPlayerItem, this.contentChatTransform).GetComponent<ContentChatItem>().KCIKGOCKPKB(LEJIJOAOEBK, text, kipcnamegpd, flag, this.scrollRect);
			}
			else
			{
				UnityEngine.Object.Instantiate<GameObject>(this.chatFriendItem, this.contentChatTransform).GetComponent<ContentChatItem>().GINANAIPOPG(LEJIJOAOEBK, text, kipcnamegpd, flag, this.scrollRect);
			}
		}
		if (list.Count == 0)
		{
			this.noMessagesText.SetActive(false);
		}
		else
		{
			this.noMessagesText.SetActive(true);
		}
		LayoutRebuilder.ForceRebuildLayoutImmediate(this.contentChatTransform.GetComponent<RectTransform>());
		this.chatScrollView.GetComponent<ScrollRect>().verticalNormalizedPosition = 1836f;
	}

	// Token: 0x06002AAB RID: 10923 RVA: 0x0012F514 File Offset: 0x0012D714
	public void BDLNKGPAGBG()
	{
		this.sendButton.onClick.Invoke();
	}

	// Token: 0x06002AAC RID: 10924 RVA: 0x0012FD70 File Offset: 0x0012DF70
	private void JPNPCAMMFNG()
	{
		AOBJLALDBAA.DBLAIDPICIG().KMAGHMCCMPG(" (shopind:", 1875f);
		ContentChatPage.showingUpgradeToFriendsPlus = false;
		this.HKOKAMGHGNL();
	}

	// Token: 0x06002AAD RID: 10925 RVA: 0x0012FD94 File Offset: 0x0012DF94
	private void ICDHNPPEONB()
	{
		if (AKLFPGMDKLA.EHBBFMCILPC.AFKCCPIMDJH())
		{
			if (!AKLFPGMDKLA.EHBBFMCILPC.EAFEJCKIEPL(99))
			{
				AKLFPGMDKLA.EHBBFMCILPC.LDAPMNLGAPC(-112);
				CommonUserInterface.IKNOFBFMPGA().NFBMHHPIGFA(CCOJBMMKNAP.APGODIBBPOD().MEPECBDCOLG("errortitle"), CCOJBMMKNAP.JMDJPKKOHNI().IKMNGFIDCLM("[LOG] "), CCOJBMMKNAP.ONCPHEEJLOP().HPOAGPJFHPM("Account.GetStorySaveUnsafe(), _slotIndex out of bounds."), (DFGILFBGPLN)91, 135f, 59);
				return;
			}
		}
		else
		{
			if (!AKLFPGMDKLA.EHBBFMCILPC.EAFEJCKIEPL(-124))
			{
				AKLFPGMDKLA.EHBBFMCILPC.LDAPMNLGAPC(92);
				CommonUserInterface.EHBBFMCILPC.NPIOKKDPALC(CCOJBMMKNAP.INKJIBDDMLL().DNILNCLIHAP("OnApplicationFocusBasicSyncSuccess"), CCOJBMMKNAP.KMNBCEMEBBD().MEPECBDCOLG("CLIENT.AVATAR.CLOTHES"), CCOJBMMKNAP.OBOOKJPGBJN().JCDFHKDNEDH("analogglitch_1"), CCOJBMMKNAP.ILACPHFEDEP().PPALCPINPLK("PivotButton"), new UnityAction(this.IHMJDMPCGGG), new UnityAction(this.DCMNNHFFHDB), new UnityAction(this.KDIGEEMPDMM), (DFGILFBGPLN)(-15), 854f, 11);
				return;
			}
			this.NODHKEPBFGK();
		}
	}

	// Token: 0x06002AAE RID: 10926 RVA: 0x0012FEA4 File Offset: 0x0012E0A4
	public void LOOFFFBFMAP(PMEPALPCEAF IJPMLEKMGMA, PMEPALPCEAF LEJIJOAOEBK)
	{
		this.PLOCDHEGJKF = LEJIJOAOEBK;
		bool active = IJPMLEKMGMA.JNNBNNDOGIM.FNDNDILCFNN(LEJIJOAOEBK);
		this.isFavoriteFriendImage.SetActive(active);
		this.matchText.SetText(LEJIJOAOEBK.OFOIECEHOCN.ToString() ?? "mussind", true);
		string text;
		if (LEJIJOAOEBK.KNCFKDLOPGA.Length == 0)
		{
			text = "StoriesSearchBalance.Initialize() - source is null, search disabled" + CCOJBMMKNAP.NIOJNOFGIJO().JHNELLJFBGC("PurchaseManagerXiaomi.OnBridgeInitialized(): failed code=") + "- ";
		}
		else
		{
			text = LEJIJOAOEBK.KNCFKDLOPGA;
		}
		this.nameText.SetText(text, false);
		this.profileImage.sprite = AssetsManager.EHBBFMCILPC.profileDataAsset.DJNLJPFFMBG(LEJIJOAOEBK.PGJBIPFBMAN());
		int num = LEJIJOAOEBK.GFAABCCNNDA + 0;
		this.levelText.text = CCOJBMMKNAP.OEPENBHJAHO().MEPECBDCOLG("") + "</i>." + num.ToString();
		LayoutRebuilder.ForceRebuildLayoutImmediate(this.levelText.GetComponent<RectTransform>());
		List<ICGCJJLADEG> list = LEJIJOAOEBK.AOCCGKHNGMD();
		foreach (ICGCJJLADEG icgcjjladeg in list)
		{
			string kipcnamegpd = icgcjjladeg.KIPCNAMEGPD;
			bool flag = icgcjjladeg.DNGFNDAMEPK == 0;
			if (flag)
			{
				UnityEngine.Object.Instantiate<GameObject>(this.chatPlayerItem, this.contentChatTransform).GetComponent<ContentChatItem>().KCIKGOCKPKB(LEJIJOAOEBK, text, kipcnamegpd, flag, this.scrollRect);
			}
			else
			{
				UnityEngine.Object.Instantiate<GameObject>(this.chatFriendItem, this.contentChatTransform).GetComponent<ContentChatItem>().SetContent(LEJIJOAOEBK, text, kipcnamegpd, flag, this.scrollRect);
			}
		}
		if (list.Count == 0)
		{
			this.noMessagesText.SetActive(true);
		}
		else
		{
			this.noMessagesText.SetActive(false);
		}
		LayoutRebuilder.ForceRebuildLayoutImmediate(this.contentChatTransform.GetComponent<RectTransform>());
		this.chatScrollView.GetComponent<ScrollRect>().verticalNormalizedPosition = 980f;
	}

	// Token: 0x06002AAF RID: 10927 RVA: 0x00130088 File Offset: 0x0012E288
	private void GMBJBOOPGOP()
	{
		if (AKLFPGMDKLA.EHBBFMCILPC.AFKCCPIMDJH())
		{
			if (!AKLFPGMDKLA.EHBBFMCILPC.EAFEJCKIEPL(114))
			{
				AKLFPGMDKLA.EHBBFMCILPC.LDAPMNLGAPC(-87);
				CommonUserInterface.EHBBFMCILPC.ShowGenericPopup(CCOJBMMKNAP.KFDLFGHBPLP().IKMNGFIDCLM(" "), CCOJBMMKNAP.KFAABHHGOPO().PPALCPINPLK(" <i>"), CCOJBMMKNAP.APGODIBBPOD().PGKBCNBAOJN(""), (DFGILFBGPLN)(-33), 1544f, -55);
				return;
			}
		}
		else
		{
			if (!AKLFPGMDKLA.EHBBFMCILPC.EAFEJCKIEPL(90))
			{
				AKLFPGMDKLA.EHBBFMCILPC.LDAPMNLGAPC(43);
				CommonUserInterface.EHBBFMCILPC.ShowGenericPopupWithTwoButtonsAndCloseOverride(CCOJBMMKNAP.BOFMCPPFAMO().PKNHKGMNCIP("cdnerror"), CCOJBMMKNAP.BOFMCPPFAMO().GGPHHLGPMPA(" ("), CCOJBMMKNAP.OEPENBHJAHO().HDIPNMFHIEJ("OnSceneStoryManagerPremiumChoiceAdsProviderAdSuccess"), CCOJBMMKNAP.PMABBOJDELF().OHLNGCKIACD("layervideo"), new UnityAction(this.IHMJDMPCGGG), new UnityAction(this.JHAHPNCJFOD), new UnityAction(this.MLAAPEKNBJP), (DFGILFBGPLN)(-80), 1285f, 74);
				return;
			}
			this.HAOAPFFMPPC();
		}
	}

	// Token: 0x06002AB0 RID: 10928 RVA: 0x00130198 File Offset: 0x0012E398
	private void MLAAPEKNBJP()
	{
		this.NIHGPKMCCML();
	}

	// Token: 0x06002AB1 RID: 10929 RVA: 0x001301A0 File Offset: 0x0012E3A0
	private void FLHDCGCLJMC()
	{
		this.NNGBEIDFLCJ();
	}

	// Token: 0x06002AB2 RID: 10930 RVA: 0x001301A8 File Offset: 0x0012E3A8
	private void KGPNHFCJAEL()
	{
		this.HAOAPFFMPPC();
	}

	// Token: 0x06002AB3 RID: 10931 RVA: 0x001301A8 File Offset: 0x0012E3A8
	private void CJDBJIOKLNN()
	{
		this.HAOAPFFMPPC();
	}

	// Token: 0x06002AB4 RID: 10932 RVA: 0x00003E52 File Offset: 0x00002052
	private void AOOANKECKCJ()
	{
	}

	// Token: 0x06002AB5 RID: 10933 RVA: 0x001301B0 File Offset: 0x0012E3B0
	public void AALJNIBPOMG(PMEPALPCEAF IJPMLEKMGMA, PMEPALPCEAF LEJIJOAOEBK)
	{
		this.PLOCDHEGJKF = LEJIJOAOEBK;
		bool active = IJPMLEKMGMA.JNNBNNDOGIM.FNDNDILCFNN(LEJIJOAOEBK);
		this.isFavoriteFriendImage.SetActive(active);
		this.matchText.SetText(LEJIJOAOEBK.OFOIECEHOCN.ToString() ?? "snapundo", false);
		string text;
		if (LEJIJOAOEBK.KNCFKDLOPGA.Length == 0)
		{
			text = "skhomelockmsg" + CCOJBMMKNAP.JMDJPKKOHNI().IKMNGFIDCLM("LLL") + " ";
		}
		else
		{
			text = LEJIJOAOEBK.KNCFKDLOPGA;
		}
		this.nameText.SetText(text, true);
		this.profileImage.sprite = AssetsManager.EHBBFMCILPC.profileDataAsset.NFOFFLDJDEI(LEJIJOAOEBK.PGJBIPFBMAN());
		int num = LEJIJOAOEBK.GFAABCCNNDA + 1;
		this.levelText.text = CCOJBMMKNAP.DBFFFOMCLKM().HPOAGPJFHPM("retry") + "lobby" + num.ToString();
		LayoutRebuilder.ForceRebuildLayoutImmediate(this.levelText.GetComponent<RectTransform>());
		List<ICGCJJLADEG> list = LEJIJOAOEBK.AOCCGKHNGMD();
		foreach (ICGCJJLADEG icgcjjladeg in list)
		{
			string kipcnamegpd = icgcjjladeg.KIPCNAMEGPD;
			bool flag = icgcjjladeg.DNGFNDAMEPK == 0;
			if (flag)
			{
				UnityEngine.Object.Instantiate<GameObject>(this.chatPlayerItem, this.contentChatTransform).GetComponent<ContentChatItem>().LFJADOIGPPL(LEJIJOAOEBK, text, kipcnamegpd, flag, this.scrollRect);
			}
			else
			{
				UnityEngine.Object.Instantiate<GameObject>(this.chatFriendItem, this.contentChatTransform).GetComponent<ContentChatItem>().DEFHMDCPDDD(LEJIJOAOEBK, text, kipcnamegpd, flag, this.scrollRect);
			}
		}
		if (list.Count == 0)
		{
			this.noMessagesText.SetActive(false);
		}
		else
		{
			this.noMessagesText.SetActive(true);
		}
		LayoutRebuilder.ForceRebuildLayoutImmediate(this.contentChatTransform.GetComponent<RectTransform>());
		this.chatScrollView.GetComponent<ScrollRect>().verticalNormalizedPosition = 467f;
	}

	// Token: 0x06002AB6 RID: 10934 RVA: 0x0012F514 File Offset: 0x0012D714
	public void NNGBEIDFLCJ()
	{
		this.sendButton.onClick.Invoke();
	}

	// Token: 0x06002AB7 RID: 10935 RVA: 0x00003E52 File Offset: 0x00002052
	private void HHHJOCGGNHE()
	{
	}

	// Token: 0x06002AB8 RID: 10936 RVA: 0x00003E52 File Offset: 0x00002052
	private void ALCHECCLCMM()
	{
	}

	// Token: 0x06002AB9 RID: 10937 RVA: 0x0012F714 File Offset: 0x0012D914
	private void GCIELGKOLJI()
	{
		this.FMIIFFDJEJB();
	}

	// Token: 0x06002ABA RID: 10938 RVA: 0x00130394 File Offset: 0x0012E594
	private void KGENGPOFIEL()
	{
		if (AKLFPGMDKLA.EHBBFMCILPC.AFKCCPIMDJH())
		{
			if (!AKLFPGMDKLA.EHBBFMCILPC.EAFEJCKIEPL(-67))
			{
				AKLFPGMDKLA.EHBBFMCILPC.LDAPMNLGAPC(-116);
				CommonUserInterface.EHBBFMCILPC.ShowGenericPopup(CCOJBMMKNAP.CEGAOMEEFBE().FCOCLEHKLDJ("c"), CCOJBMMKNAP.EHBBFMCILPC.HDIPNMFHIEJ("SocialStatsUserPublicProfile.modified = true, SetFavoriteStories()"), CCOJBMMKNAP.PEBMGCKFNAO().JHNELLJFBGC("acli20"), (DFGILFBGPLN)(-92), 519f, -114);
				return;
			}
		}
		else
		{
			if (!AKLFPGMDKLA.EHBBFMCILPC.EAFEJCKIEPL(-57))
			{
				AKLFPGMDKLA.EHBBFMCILPC.LDAPMNLGAPC(-110);
				CommonUserInterface.IKNOFBFMPGA().NPIOKKDPALC(CCOJBMMKNAP.PLJMLDOCPNM().FIENAKIHNOM("importanttitle"), CCOJBMMKNAP.FEEDGKCJBLE().OBDCPLLLGBB("[Lounge/lobby] look pack eps:"), CCOJBMMKNAP.INKJIBDDMLL().DNILNCLIHAP(""), CCOJBMMKNAP.BIAEAOMHBMM().HPOAGPJFHPM("YYY"), new UnityAction(this.FLHDCGCLJMC), new UnityAction(this.DMAPNGIJHKN), new UnityAction(this.KGPNHFCJAEL), DFGILFBGPLN.popupIncentAd3Failed, 940f, 41);
				return;
			}
			this.AIKLPBPCEJN();
		}
	}

	// Token: 0x06002ABB RID: 10939 RVA: 0x0012F858 File Offset: 0x0012DA58
	public void HKOKAMGHGNL()
	{
		this.backButton.onClick.Invoke();
	}

	// Token: 0x06002ABC RID: 10940 RVA: 0x00003E52 File Offset: 0x00002052
	private void DEOBBAHAMLD()
	{
	}

	// Token: 0x06002ABD RID: 10941 RVA: 0x00003E52 File Offset: 0x00002052
	private void BPDHPMKCLNB()
	{
	}

	// Token: 0x06002ABE RID: 10942 RVA: 0x00003E52 File Offset: 0x00002052
	private void GDLAPPBOOCM()
	{
	}

	// Token: 0x06002ABF RID: 10943 RVA: 0x001304A4 File Offset: 0x0012E6A4
	private void LGIDMIADIDJ()
	{
		AOBJLALDBAA.CEGAOMEEFBE().EGELHPJBAIC(" dated story(ies)", 314f);
		ContentChatPage.showingUpgradeToFriendsPlus = false;
		this.MPENHFJHCLI();
	}

	// Token: 0x06002AC0 RID: 10944 RVA: 0x001304C6 File Offset: 0x0012E6C6
	private void JKOLHBOMCEP()
	{
		this.POBMIEENFDI();
	}

	// Token: 0x06002AC1 RID: 10945 RVA: 0x001304CE File Offset: 0x0012E6CE
	private void GOHADOJPONE()
	{
		AOBJLALDBAA.AGANFKKBPFO().KGIKHEDLPND("xx", 647f);
		ContentChatPage.showingUpgradeToFriendsPlus = false;
		this.CIEMECDLPKA();
	}

	// Token: 0x06002AC2 RID: 10946 RVA: 0x00003E52 File Offset: 0x00002052
	private void GEJFLNPODAD()
	{
	}

	// Token: 0x06002AC3 RID: 10947 RVA: 0x001304F0 File Offset: 0x0012E6F0
	private void PNIPJLJKNBB()
	{
		this.JJAIONGNLIA();
	}

	// Token: 0x06002AC4 RID: 10948 RVA: 0x0012F514 File Offset: 0x0012D714
	public void EBGPGGFIAKF()
	{
		this.sendButton.onClick.Invoke();
	}

	// Token: 0x06002AC5 RID: 10949 RVA: 0x0012F514 File Offset: 0x0012D714
	public void DDGNBEKKHEK()
	{
		this.sendButton.onClick.Invoke();
	}

	// Token: 0x06002AC6 RID: 10950 RVA: 0x001304F8 File Offset: 0x0012E6F8
	public void PKDKMBDNJBM(PMEPALPCEAF IJPMLEKMGMA, PMEPALPCEAF LEJIJOAOEBK)
	{
		this.PLOCDHEGJKF = LEJIJOAOEBK;
		bool active = IJPMLEKMGMA.JNNBNNDOGIM.FNDNDILCFNN(LEJIJOAOEBK);
		this.isFavoriteFriendImage.SetActive(active);
		this.matchText.SetText(LEJIJOAOEBK.OFOIECEHOCN.ToString() ?? "genre_lgbtq", true);
		string text;
		if (LEJIJOAOEBK.KNCFKDLOPGA.Length == 0)
		{
			text = "aindas1" + CCOJBMMKNAP.JINDKPHNLBK().BDGPNPNIAPA("areyousurerestartnotea") + " not found in the pack";
		}
		else
		{
			text = LEJIJOAOEBK.KNCFKDLOPGA;
		}
		this.nameText.SetText(text, true);
		this.profileImage.sprite = AssetsManager.MJBDMHPHMID().profileDataAsset.NFOFFLDJDEI(LEJIJOAOEBK.PGJBIPFBMAN());
		int num = LEJIJOAOEBK.GFAABCCNNDA + 0;
		this.levelText.text = CCOJBMMKNAP.KNKGCDDMLDP().GGPHHLGPMPA("OnToolsPopupSaveToCloudSuccess") + "coverPopular" + num.ToString();
		LayoutRebuilder.ForceRebuildLayoutImmediate(this.levelText.GetComponent<RectTransform>());
		List<ICGCJJLADEG> list = LEJIJOAOEBK.AOCCGKHNGMD();
		foreach (ICGCJJLADEG icgcjjladeg in list)
		{
			string kipcnamegpd = icgcjjladeg.KIPCNAMEGPD;
			bool flag = icgcjjladeg.DNGFNDAMEPK == 0;
			if (flag)
			{
				UnityEngine.Object.Instantiate<GameObject>(this.chatPlayerItem, this.contentChatTransform).GetComponent<ContentChatItem>().KCIKGOCKPKB(LEJIJOAOEBK, text, kipcnamegpd, flag, this.scrollRect);
			}
			else
			{
				UnityEngine.Object.Instantiate<GameObject>(this.chatFriendItem, this.contentChatTransform).GetComponent<ContentChatItem>().KCIKGOCKPKB(LEJIJOAOEBK, text, kipcnamegpd, flag, this.scrollRect);
			}
		}
		if (list.Count == 0)
		{
			this.noMessagesText.SetActive(true);
		}
		else
		{
			this.noMessagesText.SetActive(false);
		}
		LayoutRebuilder.ForceRebuildLayoutImmediate(this.contentChatTransform.GetComponent<RectTransform>());
		this.chatScrollView.GetComponent<ScrollRect>().verticalNormalizedPosition = 1376f;
	}

	// Token: 0x06002AC7 RID: 10951 RVA: 0x00003E52 File Offset: 0x00002052
	private void NAILCGJFKJN()
	{
	}

	// Token: 0x06002AC8 RID: 10952 RVA: 0x00003E52 File Offset: 0x00002052
	private void COKALJONCMC()
	{
	}

	// Token: 0x06002AC9 RID: 10953 RVA: 0x0012F514 File Offset: 0x0012D714
	public void IALPNIOHNIJ()
	{
		this.sendButton.onClick.Invoke();
	}

	// Token: 0x06002ACA RID: 10954 RVA: 0x00003E52 File Offset: 0x00002052
	private void CNEGBHKEMPL()
	{
	}

	// Token: 0x06002ACB RID: 10955 RVA: 0x0012F50C File Offset: 0x0012D70C
	private void HAJKLNPKMPJ()
	{
		this.EBGPGGFIAKF();
	}

	// Token: 0x06002ACC RID: 10956 RVA: 0x00003E52 File Offset: 0x00002052
	private void OnDisable()
	{
	}

	// Token: 0x06002ACD RID: 10957 RVA: 0x0012F858 File Offset: 0x0012DA58
	public void JJAIONGNLIA()
	{
		this.backButton.onClick.Invoke();
	}

	// Token: 0x06002ACE RID: 10958 RVA: 0x001306DC File Offset: 0x0012E8DC
	public void GEBJDHFMDCB(PMEPALPCEAF IJPMLEKMGMA, PMEPALPCEAF LEJIJOAOEBK)
	{
		this.PLOCDHEGJKF = LEJIJOAOEBK;
		bool active = IJPMLEKMGMA.JNNBNNDOGIM.FNDNDILCFNN(LEJIJOAOEBK);
		this.isFavoriteFriendImage.SetActive(active);
		this.matchText.SetText(LEJIJOAOEBK.OFOIECEHOCN.ToString() ?? "XXX", true);
		string text;
		if (LEJIJOAOEBK.KNCFKDLOPGA.Length == 0)
		{
			text = "OnStartFreePassSuccess" + CCOJBMMKNAP.MLFAGAAJJEM().JCDFHKDNEDH("") + "_1";
		}
		else
		{
			text = LEJIJOAOEBK.KNCFKDLOPGA;
		}
		this.nameText.SetText(text, false);
		this.profileImage.sprite = AssetsManager.EHBBFMCILPC.profileDataAsset.AHBHMAGKMJJ(LEJIJOAOEBK.PGJBIPFBMAN());
		int num = LEJIJOAOEBK.GFAABCCNNDA + 0;
		this.levelText.text = CCOJBMMKNAP.ONCPHEEJLOP().JCDFHKDNEDH("ssnind") + "" + num.ToString();
		LayoutRebuilder.ForceRebuildLayoutImmediate(this.levelText.GetComponent<RectTransform>());
		List<ICGCJJLADEG> list = LEJIJOAOEBK.AOCCGKHNGMD();
		foreach (ICGCJJLADEG icgcjjladeg in list)
		{
			string kipcnamegpd = icgcjjladeg.KIPCNAMEGPD;
			bool flag = icgcjjladeg.DNGFNDAMEPK == 1;
			if (flag)
			{
				UnityEngine.Object.Instantiate<GameObject>(this.chatPlayerItem, this.contentChatTransform).GetComponent<ContentChatItem>().KCIKGOCKPKB(LEJIJOAOEBK, text, kipcnamegpd, flag, this.scrollRect);
			}
			else
			{
				UnityEngine.Object.Instantiate<GameObject>(this.chatFriendItem, this.contentChatTransform).GetComponent<ContentChatItem>().CJCAIJFFNBE(LEJIJOAOEBK, text, kipcnamegpd, flag, this.scrollRect);
			}
		}
		if (list.Count == 0)
		{
			this.noMessagesText.SetActive(true);
		}
		else
		{
			this.noMessagesText.SetActive(true);
		}
		LayoutRebuilder.ForceRebuildLayoutImmediate(this.contentChatTransform.GetComponent<RectTransform>());
		this.chatScrollView.GetComponent<ScrollRect>().verticalNormalizedPosition = 1712f;
	}

	// Token: 0x06002ACF RID: 10959 RVA: 0x00130198 File Offset: 0x0012E398
	private void DMKFKIAOAII()
	{
		this.NIHGPKMCCML();
	}

	// Token: 0x06002AD0 RID: 10960 RVA: 0x001308C0 File Offset: 0x0012EAC0
	private void BPIFKHJAKHE()
	{
		AOBJLALDBAA.EHBBFMCILPC.KMAGHMCCMPG("stat2long", 999f);
		ContentChatPage.showingUpgradeToFriendsPlus = true;
		this.CloseChat();
	}

	// Token: 0x06002AD1 RID: 10961 RVA: 0x0012F50C File Offset: 0x0012D70C
	private void IHMJDMPCGGG()
	{
		this.EBGPGGFIAKF();
	}

	// Token: 0x06002AD2 RID: 10962 RVA: 0x001308E4 File Offset: 0x0012EAE4
	public void LLINFICFNEJ(PMEPALPCEAF IJPMLEKMGMA, PMEPALPCEAF LEJIJOAOEBK)
	{
		this.PLOCDHEGJKF = LEJIJOAOEBK;
		bool active = IJPMLEKMGMA.JNNBNNDOGIM.FNDNDILCFNN(LEJIJOAOEBK);
		this.isFavoriteFriendImage.SetActive(active);
		this.matchText.SetText(LEJIJOAOEBK.OFOIECEHOCN.ToString() ?? "Asset bundle load operation failed during parallel mode.", true);
		string text;
		if (LEJIJOAOEBK.KNCFKDLOPGA.Length == 0)
		{
			text = "TV dots" + CCOJBMMKNAP.KFDLFGHBPLP().HDIPNMFHIEJ("ok") + "anthology";
		}
		else
		{
			text = LEJIJOAOEBK.KNCFKDLOPGA;
		}
		this.nameText.SetText(text, false);
		this.profileImage.sprite = AssetsManager.EHBBFMCILPC.profileDataAsset.AHBHMAGKMJJ(LEJIJOAOEBK.PGJBIPFBMAN());
		int num = LEJIJOAOEBK.GFAABCCNNDA + 1;
		this.levelText.text = CCOJBMMKNAP.KFDLFGHBPLP().FIENAKIHNOM("Skiped loading duplicate story save with index ") + "lsn" + num.ToString();
		LayoutRebuilder.ForceRebuildLayoutImmediate(this.levelText.GetComponent<RectTransform>());
		List<ICGCJJLADEG> list = LEJIJOAOEBK.AOCCGKHNGMD();
		foreach (ICGCJJLADEG icgcjjladeg in list)
		{
			string kipcnamegpd = icgcjjladeg.KIPCNAMEGPD;
			bool flag = icgcjjladeg.DNGFNDAMEPK == 0;
			if (flag)
			{
				UnityEngine.Object.Instantiate<GameObject>(this.chatPlayerItem, this.contentChatTransform).GetComponent<ContentChatItem>().KCIKGOCKPKB(LEJIJOAOEBK, text, kipcnamegpd, flag, this.scrollRect);
			}
			else
			{
				UnityEngine.Object.Instantiate<GameObject>(this.chatFriendItem, this.contentChatTransform).GetComponent<ContentChatItem>().JFLPIIBJBLA(LEJIJOAOEBK, text, kipcnamegpd, flag, this.scrollRect);
			}
		}
		if (list.Count == 0)
		{
			this.noMessagesText.SetActive(false);
		}
		else
		{
			this.noMessagesText.SetActive(false);
		}
		LayoutRebuilder.ForceRebuildLayoutImmediate(this.contentChatTransform.GetComponent<RectTransform>());
		this.chatScrollView.GetComponent<ScrollRect>().verticalNormalizedPosition = 601f;
	}

	// Token: 0x06002AD3 RID: 10963 RVA: 0x0012F514 File Offset: 0x0012D714
	public void OGHLCJMJBDD()
	{
		this.sendButton.onClick.Invoke();
	}

	// Token: 0x06002AD4 RID: 10964 RVA: 0x00003E52 File Offset: 0x00002052
	private void ENNCLHFGHDO()
	{
	}

	// Token: 0x06002AD5 RID: 10965 RVA: 0x001304F0 File Offset: 0x0012E6F0
	private void NADGLPOMAMM()
	{
		this.JJAIONGNLIA();
	}

	// Token: 0x06002AD6 RID: 10966 RVA: 0x0012F514 File Offset: 0x0012D714
	public void KGEHDBLPLKJ()
	{
		this.sendButton.onClick.Invoke();
	}

	// Token: 0x06002AD7 RID: 10967 RVA: 0x00130AC8 File Offset: 0x0012ECC8
	private void AEMMGIDDBHO()
	{
		if (AKLFPGMDKLA.EHBBFMCILPC.AFKCCPIMDJH())
		{
			if (!AKLFPGMDKLA.EHBBFMCILPC.EAFEJCKIEPL(81))
			{
				AKLFPGMDKLA.EHBBFMCILPC.LDAPMNLGAPC(123);
				CommonUserInterface.IKNOFBFMPGA().ShowGenericPopup(CCOJBMMKNAP.APGODIBBPOD().IKMNGFIDCLM(""), CCOJBMMKNAP.OBOOKJPGBJN().JLBEIFLLBLO("digitalglitch_1"), CCOJBMMKNAP.LMCCLMFGEBD().FIENAKIHNOM("[LoadingEnv] "), DFGILFBGPLN.popupOffer, 35f, 59);
				return;
			}
		}
		else
		{
			if (!AKLFPGMDKLA.EHBBFMCILPC.EAFEJCKIEPL(94))
			{
				AKLFPGMDKLA.EHBBFMCILPC.LDAPMNLGAPC(-105);
				CommonUserInterface.EHBBFMCILPC.NPIOKKDPALC(CCOJBMMKNAP.PLJMLDOCPNM().JLBEIFLLBLO(") shopref("), CCOJBMMKNAP.GIOAFDDKKHI().HHLECNIFHCO("XXX"), CCOJBMMKNAP.COKDLDOAACJ().MEPECBDCOLG(""), CCOJBMMKNAP.COKDLDOAACJ().JCDFHKDNEDH("energyhinttitle"), new UnityAction(this.DMLMANCGKHE), new UnityAction(this.MNIJKPAJEIE), new UnityAction(this.LNGJLPJIHJI), DFGILFBGPLN.popupIncentAd3Failed, 194f, -106);
				return;
			}
			this.FMIIFFDJEJB();
		}
	}

	// Token: 0x06002AD8 RID: 10968 RVA: 0x00130BD8 File Offset: 0x0012EDD8
	private void MNIJKPAJEIE()
	{
		AOBJLALDBAA.FILDBDMENPG().FDKBIBKABCM("_StripeVelocity", 1737f);
		ContentChatPage.showingUpgradeToFriendsPlus = true;
		this.HKOKAMGHGNL();
	}

	// Token: 0x06002AD9 RID: 10969 RVA: 0x00003E52 File Offset: 0x00002052
	private void LAMJLLGDDPL()
	{
	}

	// Token: 0x06002ADA RID: 10970 RVA: 0x00003E52 File Offset: 0x00002052
	private void KBGOLEGBMAP()
	{
	}

	// Token: 0x06002ADB RID: 10971 RVA: 0x00130BFC File Offset: 0x0012EDFC
	private void EHBJOHMNJFH()
	{
		if (AKLFPGMDKLA.EHBBFMCILPC.AFKCCPIMDJH())
		{
			if (!AKLFPGMDKLA.EHBBFMCILPC.EAFEJCKIEPL(6))
			{
				AKLFPGMDKLA.EHBBFMCILPC.LDAPMNLGAPC(-108);
				CommonUserInterface.EHBBFMCILPC.ShowGenericPopup(CCOJBMMKNAP.BFHKGNBFHCH().PGKBCNBAOJN("vhspauseovr"), CCOJBMMKNAP.EHBBFMCILPC.JHNELLJFBGC("UpdateSocialOnOffState"), CCOJBMMKNAP.JMNIGPHCAEJ().MEPECBDCOLG("*"), DFGILFBGPLN.popoverLobbyRewards, 1780f, -27);
				return;
			}
		}
		else
		{
			if (!AKLFPGMDKLA.EHBBFMCILPC.EAFEJCKIEPL(70))
			{
				AKLFPGMDKLA.EHBBFMCILPC.LDAPMNLGAPC(-115);
				CommonUserInterface.IKNOFBFMPGA().NPIOKKDPALC(CCOJBMMKNAP.GIOAFDDKKHI().BGELFMIOBCL("StoriesSearchBalance - row '"), CCOJBMMKNAP.PMABBOJDELF().HIPJILDCHJC("OnSpinsUnlockContinueToPurchasingScreen"), CCOJBMMKNAP.BIAEAOMHBMM().BDGPNPNIAPA(""), CCOJBMMKNAP.KMNBCEMEBBD().GLEFEKBDHNK("OnLiveProfileThemeDownloadFailed"), new UnityAction(this.CLCKHBDJGFF), new UnityAction(this.EAAOMOKKINK), new UnityAction(this.HJMMMEICPGL), (DFGILFBGPLN)94, 807f, 107);
				return;
			}
			this.JBLPAAGAOPO();
		}
	}

	// Token: 0x06002ADC RID: 10972 RVA: 0x00130D0C File Offset: 0x0012EF0C
	public void JDCHBPLIDOD(PMEPALPCEAF IJPMLEKMGMA, PMEPALPCEAF LEJIJOAOEBK)
	{
		this.PLOCDHEGJKF = LEJIJOAOEBK;
		bool active = IJPMLEKMGMA.JNNBNNDOGIM.FNDNDILCFNN(LEJIJOAOEBK);
		this.isFavoriteFriendImage.SetActive(active);
		this.matchText.SetText(LEJIJOAOEBK.OFOIECEHOCN.ToString() ?? "getDefaultBundles", false);
		string text;
		if (LEJIJOAOEBK.KNCFKDLOPGA.Length == 0)
		{
			text = "adb" + CCOJBMMKNAP.MPCBJEIMACA().HPOAGPJFHPM("OnSketchViewShowWI") + "acb";
		}
		else
		{
			text = LEJIJOAOEBK.KNCFKDLOPGA;
		}
		this.nameText.SetText(text, true);
		this.profileImage.sprite = AssetsManager.MJBDMHPHMID().profileDataAsset.NFOFFLDJDEI(LEJIJOAOEBK.PGJBIPFBMAN());
		int num = LEJIJOAOEBK.GFAABCCNNDA + 1;
		this.levelText.text = CCOJBMMKNAP.BIAEAOMHBMM().PGKBCNBAOJN("") + "OnAchievementSyncSuccess" + num.ToString();
		LayoutRebuilder.ForceRebuildLayoutImmediate(this.levelText.GetComponent<RectTransform>());
		List<ICGCJJLADEG> list = LEJIJOAOEBK.AOCCGKHNGMD();
		foreach (ICGCJJLADEG icgcjjladeg in list)
		{
			string kipcnamegpd = icgcjjladeg.KIPCNAMEGPD;
			bool flag = icgcjjladeg.DNGFNDAMEPK == 0;
			if (flag)
			{
				UnityEngine.Object.Instantiate<GameObject>(this.chatPlayerItem, this.contentChatTransform).GetComponent<ContentChatItem>().HBOBOKGLEGM(LEJIJOAOEBK, text, kipcnamegpd, flag, this.scrollRect);
			}
			else
			{
				UnityEngine.Object.Instantiate<GameObject>(this.chatFriendItem, this.contentChatTransform).GetComponent<ContentChatItem>().SetContent(LEJIJOAOEBK, text, kipcnamegpd, flag, this.scrollRect);
			}
		}
		if (list.Count == 0)
		{
			this.noMessagesText.SetActive(false);
		}
		else
		{
			this.noMessagesText.SetActive(false);
		}
		LayoutRebuilder.ForceRebuildLayoutImmediate(this.contentChatTransform.GetComponent<RectTransform>());
		this.chatScrollView.GetComponent<ScrollRect>().verticalNormalizedPosition = 316f;
	}

	// Token: 0x06002ADD RID: 10973 RVA: 0x00130EF0 File Offset: 0x0012F0F0
	private void FOBJABNIPPB()
	{
		if (AKLFPGMDKLA.EHBBFMCILPC.AFKCCPIMDJH())
		{
			if (!AKLFPGMDKLA.EHBBFMCILPC.EAFEJCKIEPL(-17))
			{
				AKLFPGMDKLA.EHBBFMCILPC.LDAPMNLGAPC(102);
				CommonUserInterface.EHBBFMCILPC.ShowGenericPopup(CCOJBMMKNAP.EHBBFMCILPC.HPOAGPJFHPM("No camera found."), CCOJBMMKNAP.MLFAGAAJJEM().BGELFMIOBCL("newrewardsitem16hint"), CCOJBMMKNAP.KFDLFGHBPLP().JCDFHKDNEDH(""), (DFGILFBGPLN)(-59), 29f, -105);
				return;
			}
		}
		else
		{
			if (!AKLFPGMDKLA.EHBBFMCILPC.EAFEJCKIEPL(-40))
			{
				AKLFPGMDKLA.EHBBFMCILPC.LDAPMNLGAPC(45);
				CommonUserInterface.EHBBFMCILPC.ShowGenericPopupWithTwoButtonsAndCloseOverride(CCOJBMMKNAP.BOFMCPPFAMO().FIENAKIHNOM("loop"), CCOJBMMKNAP.PEBMGCKFNAO().BDGPNPNIAPA("OnRestorePurchasesZeroResult"), CCOJBMMKNAP.KNKGCDDMLDP().OHLNGCKIACD("oldvhs"), CCOJBMMKNAP.HFAKOKBHCGH().HIPJILDCHJC("@SD"), new UnityAction(this.GIKCPAAPCHC), new UnityAction(this.MNIJKPAJEIE), new UnityAction(this.PNIPJLJKNBB), (DFGILFBGPLN)(-9), 1930f, -73);
				return;
			}
			this.HKOKAMGHGNL();
		}
	}

	// Token: 0x06002ADE RID: 10974 RVA: 0x00003E52 File Offset: 0x00002052
	private void EKIDOPDDHJD()
	{
	}

	// Token: 0x06002ADF RID: 10975 RVA: 0x00131000 File Offset: 0x0012F200
	public void FKJBEIICHDP(PMEPALPCEAF IJPMLEKMGMA, PMEPALPCEAF LEJIJOAOEBK)
	{
		this.PLOCDHEGJKF = LEJIJOAOEBK;
		bool active = IJPMLEKMGMA.JNNBNNDOGIM.FNDNDILCFNN(LEJIJOAOEBK);
		this.isFavoriteFriendImage.SetActive(active);
		this.matchText.SetText(LEJIJOAOEBK.OFOIECEHOCN.ToString() ?? "sp1", false);
		string text;
		if (LEJIJOAOEBK.KNCFKDLOPGA.Length == 0)
		{
			text = "requirePayer" + CCOJBMMKNAP.ILACPHFEDEP().JCDFHKDNEDH("OnBackendGetSketchesBalanceSuccess") + "[LoadingEnv] dropping ";
		}
		else
		{
			text = LEJIJOAOEBK.KNCFKDLOPGA;
		}
		this.nameText.SetText(text, true);
		this.profileImage.sprite = AssetsManager.MJBDMHPHMID().profileDataAsset.AHBHMAGKMJJ(LEJIJOAOEBK.PGJBIPFBMAN());
		int num = LEJIJOAOEBK.GFAABCCNNDA + 0;
		this.levelText.text = CCOJBMMKNAP.HEDIEIICOOG().FCOCLEHKLDJ("") + "OnPopupPromoCodesReadInputEndEdit" + num.ToString();
		LayoutRebuilder.ForceRebuildLayoutImmediate(this.levelText.GetComponent<RectTransform>());
		List<ICGCJJLADEG> list = LEJIJOAOEBK.AOCCGKHNGMD();
		foreach (ICGCJJLADEG icgcjjladeg in list)
		{
			string kipcnamegpd = icgcjjladeg.KIPCNAMEGPD;
			bool flag = icgcjjladeg.DNGFNDAMEPK == 0;
			if (flag)
			{
				UnityEngine.Object.Instantiate<GameObject>(this.chatPlayerItem, this.contentChatTransform).GetComponent<ContentChatItem>().EPBDNOFEEJH(LEJIJOAOEBK, text, kipcnamegpd, flag, this.scrollRect);
			}
			else
			{
				UnityEngine.Object.Instantiate<GameObject>(this.chatFriendItem, this.contentChatTransform).GetComponent<ContentChatItem>().JFLPIIBJBLA(LEJIJOAOEBK, text, kipcnamegpd, flag, this.scrollRect);
			}
		}
		if (list.Count == 0)
		{
			this.noMessagesText.SetActive(false);
		}
		else
		{
			this.noMessagesText.SetActive(true);
		}
		LayoutRebuilder.ForceRebuildLayoutImmediate(this.contentChatTransform.GetComponent<RectTransform>());
		this.chatScrollView.GetComponent<ScrollRect>().verticalNormalizedPosition = 1503f;
	}

	// Token: 0x06002AE0 RID: 10976 RVA: 0x00003E52 File Offset: 0x00002052
	private void PCMFDMEOCKE()
	{
	}

	// Token: 0x06002AE1 RID: 10977 RVA: 0x00003E52 File Offset: 0x00002052
	private void AEOKJCHEALH()
	{
	}

	// Token: 0x06002AE2 RID: 10978 RVA: 0x0012F514 File Offset: 0x0012D714
	public void CloseChatAndSendMessage()
	{
		this.sendButton.onClick.Invoke();
	}

	// Token: 0x06002AE3 RID: 10979 RVA: 0x00003E52 File Offset: 0x00002052
	private void OPFLFDKJGFJ()
	{
	}

	// Token: 0x06002AE4 RID: 10980 RVA: 0x00003E52 File Offset: 0x00002052
	private void DOECDMINNOK()
	{
	}

	// Token: 0x06002AE5 RID: 10981 RVA: 0x00003E52 File Offset: 0x00002052
	private void JEKOEDIBHPJ()
	{
	}

	// Token: 0x06002AE6 RID: 10982 RVA: 0x00003E52 File Offset: 0x00002052
	private void JOOPBAEMBCP()
	{
	}

	// Token: 0x06002AE7 RID: 10983 RVA: 0x00003E52 File Offset: 0x00002052
	private void BHGOKICGBKO()
	{
	}

	// Token: 0x06002AE8 RID: 10984 RVA: 0x00003E52 File Offset: 0x00002052
	private void DCOGIJMKHMJ()
	{
	}

	// Token: 0x06002AE9 RID: 10985 RVA: 0x001311E4 File Offset: 0x0012F3E4
	public void MMAGJGDBFDC(PMEPALPCEAF IJPMLEKMGMA, PMEPALPCEAF LEJIJOAOEBK)
	{
		this.PLOCDHEGJKF = LEJIJOAOEBK;
		bool active = IJPMLEKMGMA.JNNBNNDOGIM.FNDNDILCFNN(LEJIJOAOEBK);
		this.isFavoriteFriendImage.SetActive(active);
		this.matchText.SetText(LEJIJOAOEBK.OFOIECEHOCN.ToString() ?? "OnNeedToActivateFocusItemCloseButton", true);
		string text;
		if (LEJIJOAOEBK.KNCFKDLOPGA.Length == 0)
		{
			text = "tradewishcardoption2" + CCOJBMMKNAP.EHBBFMCILPC.HPOAGPJFHPM("Asset bundle load operation failed during parallel mode.") + "a";
		}
		else
		{
			text = LEJIJOAOEBK.KNCFKDLOPGA;
		}
		this.nameText.SetText(text, false);
		this.profileImage.sprite = AssetsManager.EHBBFMCILPC.profileDataAsset.DJNLJPFFMBG(LEJIJOAOEBK.PGJBIPFBMAN());
		int num = LEJIJOAOEBK.GFAABCCNNDA + 0;
		this.levelText.text = CCOJBMMKNAP.JMDJPKKOHNI().FCOCLEHKLDJ("energyhinttitle") + "header" + num.ToString();
		LayoutRebuilder.ForceRebuildLayoutImmediate(this.levelText.GetComponent<RectTransform>());
		List<ICGCJJLADEG> list = LEJIJOAOEBK.AOCCGKHNGMD();
		foreach (ICGCJJLADEG icgcjjladeg in list)
		{
			string kipcnamegpd = icgcjjladeg.KIPCNAMEGPD;
			bool flag = icgcjjladeg.DNGFNDAMEPK == 1;
			if (flag)
			{
				UnityEngine.Object.Instantiate<GameObject>(this.chatPlayerItem, this.contentChatTransform).GetComponent<ContentChatItem>().LFPCCLGCPOP(LEJIJOAOEBK, text, kipcnamegpd, flag, this.scrollRect);
			}
			else
			{
				UnityEngine.Object.Instantiate<GameObject>(this.chatFriendItem, this.contentChatTransform).GetComponent<ContentChatItem>().DAFPJHCHLMH(LEJIJOAOEBK, text, kipcnamegpd, flag, this.scrollRect);
			}
		}
		if (list.Count == 0)
		{
			this.noMessagesText.SetActive(true);
		}
		else
		{
			this.noMessagesText.SetActive(true);
		}
		LayoutRebuilder.ForceRebuildLayoutImmediate(this.contentChatTransform.GetComponent<RectTransform>());
		this.chatScrollView.GetComponent<ScrollRect>().verticalNormalizedPosition = 1031f;
	}

	// Token: 0x06002AEA RID: 10986 RVA: 0x001313C8 File Offset: 0x0012F5C8
	private void OnEnable()
	{
		if (AKLFPGMDKLA.EHBBFMCILPC.AFKCCPIMDJH())
		{
			if (!AKLFPGMDKLA.EHBBFMCILPC.EAFEJCKIEPL(46))
			{
				AKLFPGMDKLA.EHBBFMCILPC.LDAPMNLGAPC(46);
				CommonUserInterface.EHBBFMCILPC.ShowGenericPopup(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("energyhinttitle"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("friendspluschattutorialactive"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("continue"), DFGILFBGPLN.popupTools, 0.5f, 28);
				return;
			}
		}
		else
		{
			if (!AKLFPGMDKLA.EHBBFMCILPC.EAFEJCKIEPL(41))
			{
				AKLFPGMDKLA.EHBBFMCILPC.LDAPMNLGAPC(41);
				CommonUserInterface.EHBBFMCILPC.ShowGenericPopupWithTwoButtonsAndCloseOverride(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("energyhinttitle"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("friendspluschattutorialinactive"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("friendspluschattutorialinactivebtn0"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("friendspluschattutorialinactivebtn1"), new UnityAction(this.ANOGGBGPMGE), new UnityAction(this.HKGKDCJDBOL), new UnityAction(this.EGBCMFEFGDI), DFGILFBGPLN.popupTools, 0.5f, 28);
				return;
			}
			this.CloseChat();
		}
	}

	// Token: 0x06002AEB RID: 10987 RVA: 0x00003E52 File Offset: 0x00002052
	private void HHDMNFGALBA()
	{
	}

	// Token: 0x06002AEC RID: 10988 RVA: 0x001314D8 File Offset: 0x0012F6D8
	private void BIGPHDKLOGF()
	{
		AOBJLALDBAA.FILDBDMENPG().EGELHPJBAIC("err", 446f);
		ContentChatPage.showingUpgradeToFriendsPlus = true;
		this.AIKLPBPCEJN();
	}

	// Token: 0x06002AED RID: 10989 RVA: 0x00003E52 File Offset: 0x00002052
	private void OOOHPJJOODA()
	{
	}

	// Token: 0x06002AEE RID: 10990 RVA: 0x00003E52 File Offset: 0x00002052
	private void LDDMIGLADBE()
	{
	}

	// Token: 0x06002AEF RID: 10991 RVA: 0x001314FA File Offset: 0x0012F6FA
	private void DMAPNGIJHKN()
	{
		AOBJLALDBAA.BIAEAOMHBMM().DCGCFPHHDDG("Collections", 928f);
		ContentChatPage.showingUpgradeToFriendsPlus = true;
		this.HKOKAMGHGNL();
	}

	// Token: 0x06002AF0 RID: 10992 RVA: 0x0013151C File Offset: 0x0012F71C
	private void LCJONBOEKDO()
	{
		this.CloseChat();
	}

	// Token: 0x06002AF1 RID: 10993 RVA: 0x00131524 File Offset: 0x0012F724
	public void HEKBKJEPBPK(PMEPALPCEAF IJPMLEKMGMA, PMEPALPCEAF LEJIJOAOEBK)
	{
		this.PLOCDHEGJKF = LEJIJOAOEBK;
		bool active = IJPMLEKMGMA.JNNBNNDOGIM.FNDNDILCFNN(LEJIJOAOEBK);
		this.isFavoriteFriendImage.SetActive(active);
		this.matchText.SetText(LEJIJOAOEBK.OFOIECEHOCN.ToString() ?? "OnChapterSnapshotsBackendFetchException", false);
		string text;
		if (LEJIJOAOEBK.KNCFKDLOPGA.Length == 0)
		{
			text = "/" + CCOJBMMKNAP.KMNBCEMEBBD().HDIPNMFHIEJ("importanttitle") + "p";
		}
		else
		{
			text = LEJIJOAOEBK.KNCFKDLOPGA;
		}
		this.nameText.SetText(text, false);
		this.profileImage.sprite = AssetsManager.MJBDMHPHMID().profileDataAsset.DJNLJPFFMBG(LEJIJOAOEBK.PGJBIPFBMAN());
		int num = LEJIJOAOEBK.GFAABCCNNDA + 0;
		this.levelText.text = CCOJBMMKNAP.KFAABHHGOPO().MEPECBDCOLG("\n") + "OnPopupCardOptionsNextClickLobby" + num.ToString();
		LayoutRebuilder.ForceRebuildLayoutImmediate(this.levelText.GetComponent<RectTransform>());
		List<ICGCJJLADEG> list = LEJIJOAOEBK.AOCCGKHNGMD();
		foreach (ICGCJJLADEG icgcjjladeg in list)
		{
			string kipcnamegpd = icgcjjladeg.KIPCNAMEGPD;
			bool flag = icgcjjladeg.DNGFNDAMEPK == 0;
			if (flag)
			{
				UnityEngine.Object.Instantiate<GameObject>(this.chatPlayerItem, this.contentChatTransform).GetComponent<ContentChatItem>().DAFPJHCHLMH(LEJIJOAOEBK, text, kipcnamegpd, flag, this.scrollRect);
			}
			else
			{
				UnityEngine.Object.Instantiate<GameObject>(this.chatFriendItem, this.contentChatTransform).GetComponent<ContentChatItem>().HBOBOKGLEGM(LEJIJOAOEBK, text, kipcnamegpd, flag, this.scrollRect);
			}
		}
		if (list.Count == 0)
		{
			this.noMessagesText.SetActive(true);
		}
		else
		{
			this.noMessagesText.SetActive(false);
		}
		LayoutRebuilder.ForceRebuildLayoutImmediate(this.contentChatTransform.GetComponent<RectTransform>());
		this.chatScrollView.GetComponent<ScrollRect>().verticalNormalizedPosition = 1351f;
	}

	// Token: 0x06002AF2 RID: 10994 RVA: 0x0012F514 File Offset: 0x0012D714
	public void FNHAHPHEOEN()
	{
		this.sendButton.onClick.Invoke();
	}

	// Token: 0x06002AF3 RID: 10995 RVA: 0x00131708 File Offset: 0x0012F908
	private void EAAOMOKKINK()
	{
		AOBJLALDBAA.DBLAIDPICIG().FDKBIBKABCM("usynach", 1398f);
		ContentChatPage.showingUpgradeToFriendsPlus = false;
		this.NODHKEPBFGK();
	}

	// Token: 0x06002AF4 RID: 10996 RVA: 0x00003E52 File Offset: 0x00002052
	private void CKKAKPFCPEG()
	{
	}

	// Token: 0x06002AF5 RID: 10997 RVA: 0x001301A8 File Offset: 0x0012E3A8
	private void HJMMMEICPGL()
	{
		this.HAOAPFFMPPC();
	}

	// Token: 0x06002AF6 RID: 10998 RVA: 0x0012F858 File Offset: 0x0012DA58
	public void FMIIFFDJEJB()
	{
		this.backButton.onClick.Invoke();
	}

	// Token: 0x06002AF7 RID: 10999 RVA: 0x0013172C File Offset: 0x0012F92C
	private void JLCMPGICMDC()
	{
		if (AKLFPGMDKLA.EHBBFMCILPC.AFKCCPIMDJH())
		{
			if (!AKLFPGMDKLA.EHBBFMCILPC.EAFEJCKIEPL(43))
			{
				AKLFPGMDKLA.EHBBFMCILPC.LDAPMNLGAPC(-101);
				CommonUserInterface.IKNOFBFMPGA().NFBMHHPIGFA(CCOJBMMKNAP.HEDIEIICOOG().FCOCLEHKLDJ("{month}"), CCOJBMMKNAP.OBOOKJPGBJN().OBDCPLLLGBB("anthology"), CCOJBMMKNAP.OEPENBHJAHO().OGKGHLHHAAI(""), (DFGILFBGPLN)(-68), 449f, -40);
				return;
			}
		}
		else
		{
			if (!AKLFPGMDKLA.EHBBFMCILPC.EAFEJCKIEPL(-2))
			{
				AKLFPGMDKLA.EHBBFMCILPC.LDAPMNLGAPC(19);
				CommonUserInterface.EHBBFMCILPC.ShowGenericPopupWithTwoButtonsAndCloseOverride(CCOJBMMKNAP.PEBMGCKFNAO().JLBEIFLLBLO("@"), CCOJBMMKNAP.FEEDGKCJBLE().GGPHHLGPMPA(""), CCOJBMMKNAP.KNKGCDDMLDP().FIENAKIHNOM("OnPopupCardOptionsSendGiftClick"), CCOJBMMKNAP.AEELGGPEJCC().FCOCLEHKLDJ("app42error"), new UnityAction(this.OJJOIFOEGDN), new UnityAction(this.IEOMGBGEGIO), new UnityAction(this.PNIPJLJKNBB), (DFGILFBGPLN)(-42), 1429f, -73);
				return;
			}
			this.JJAIONGNLIA();
		}
	}

	// Token: 0x06002AF8 RID: 11000 RVA: 0x0013183C File Offset: 0x0012FA3C
	public void OOGLOLAEKFH(PMEPALPCEAF IJPMLEKMGMA, PMEPALPCEAF LEJIJOAOEBK)
	{
		this.PLOCDHEGJKF = LEJIJOAOEBK;
		bool active = IJPMLEKMGMA.JNNBNNDOGIM.FNDNDILCFNN(LEJIJOAOEBK);
		this.isFavoriteFriendImage.SetActive(active);
		this.matchText.SetText(LEJIJOAOEBK.OFOIECEHOCN.ToString() ?? "", false);
		string text;
		if (LEJIJOAOEBK.KNCFKDLOPGA.Length == 0)
		{
			text = "dceoiv" + CCOJBMMKNAP.FEEDGKCJBLE().PKNHKGMNCIP("socialgiftcollectinfodone") + "srvt";
		}
		else
		{
			text = LEJIJOAOEBK.KNCFKDLOPGA;
		}
		this.nameText.SetText(text, true);
		this.profileImage.sprite = AssetsManager.MJBDMHPHMID().profileDataAsset.AHBHMAGKMJJ(LEJIJOAOEBK.PGJBIPFBMAN());
		int num = LEJIJOAOEBK.GFAABCCNNDA + 1;
		this.levelText.text = CCOJBMMKNAP.BIAEAOMHBMM().DNILNCLIHAP("StorySaveBody.GetAvatarIndexAutoSuffix(), unsupported wardrobe index:") + "cs" + num.ToString();
		LayoutRebuilder.ForceRebuildLayoutImmediate(this.levelText.GetComponent<RectTransform>());
		List<ICGCJJLADEG> list = LEJIJOAOEBK.AOCCGKHNGMD();
		foreach (ICGCJJLADEG icgcjjladeg in list)
		{
			string kipcnamegpd = icgcjjladeg.KIPCNAMEGPD;
			bool flag = icgcjjladeg.DNGFNDAMEPK == 1;
			if (flag)
			{
				UnityEngine.Object.Instantiate<GameObject>(this.chatPlayerItem, this.contentChatTransform).GetComponent<ContentChatItem>().KCIKGOCKPKB(LEJIJOAOEBK, text, kipcnamegpd, flag, this.scrollRect);
			}
			else
			{
				UnityEngine.Object.Instantiate<GameObject>(this.chatFriendItem, this.contentChatTransform).GetComponent<ContentChatItem>().LFPCCLGCPOP(LEJIJOAOEBK, text, kipcnamegpd, flag, this.scrollRect);
			}
		}
		if (list.Count == 0)
		{
			this.noMessagesText.SetActive(true);
		}
		else
		{
			this.noMessagesText.SetActive(false);
		}
		LayoutRebuilder.ForceRebuildLayoutImmediate(this.contentChatTransform.GetComponent<RectTransform>());
		this.chatScrollView.GetComponent<ScrollRect>().verticalNormalizedPosition = 261f;
	}

	// Token: 0x06002AF9 RID: 11001 RVA: 0x0012F858 File Offset: 0x0012DA58
	public void HAOAPFFMPPC()
	{
		this.backButton.onClick.Invoke();
	}

	// Token: 0x06002AFA RID: 11002 RVA: 0x0012F514 File Offset: 0x0012D714
	public void JKFBMOFDKEE()
	{
		this.sendButton.onClick.Invoke();
	}

	// Token: 0x06002AFB RID: 11003 RVA: 0x00131A20 File Offset: 0x0012FC20
	public void FGFKLOKJHKC(PMEPALPCEAF IJPMLEKMGMA, PMEPALPCEAF LEJIJOAOEBK)
	{
		this.PLOCDHEGJKF = LEJIJOAOEBK;
		bool active = IJPMLEKMGMA.JNNBNNDOGIM.FNDNDILCFNN(LEJIJOAOEBK);
		this.isFavoriteFriendImage.SetActive(active);
		this.matchText.SetText(LEJIJOAOEBK.OFOIECEHOCN.ToString() ?? " (", true);
		string text;
		if (LEJIJOAOEBK.KNCFKDLOPGA.Length == 0)
		{
			text = "ERROR: StoryStepChoiceExtended.StoryStepStage.executeChoice.clothes: bulk choice index must be > 0." + CCOJBMMKNAP.PEBMGCKFNAO().DNILNCLIHAP("UNHIDEAVATARCOMPONENT") + "no";
		}
		else
		{
			text = LEJIJOAOEBK.KNCFKDLOPGA;
		}
		this.nameText.SetText(text, true);
		this.profileImage.sprite = AssetsManager.EHBBFMCILPC.profileDataAsset.NFOFFLDJDEI(LEJIJOAOEBK.PGJBIPFBMAN());
		int num = LEJIJOAOEBK.GFAABCCNNDA + 1;
		this.levelText.text = CCOJBMMKNAP.HJGDLOOHNLO().OGKGHLHHAAI("OnStorySplashManagerHideAndCleanCache") + "PendingPurchase.GetReceipt(): Receipt is null or empty" + num.ToString();
		LayoutRebuilder.ForceRebuildLayoutImmediate(this.levelText.GetComponent<RectTransform>());
		List<ICGCJJLADEG> list = LEJIJOAOEBK.AOCCGKHNGMD();
		foreach (ICGCJJLADEG icgcjjladeg in list)
		{
			string kipcnamegpd = icgcjjladeg.KIPCNAMEGPD;
			bool flag = icgcjjladeg.DNGFNDAMEPK == 1;
			if (flag)
			{
				UnityEngine.Object.Instantiate<GameObject>(this.chatPlayerItem, this.contentChatTransform).GetComponent<ContentChatItem>().LHHFFLOPLOH(LEJIJOAOEBK, text, kipcnamegpd, flag, this.scrollRect);
			}
			else
			{
				UnityEngine.Object.Instantiate<GameObject>(this.chatFriendItem, this.contentChatTransform).GetComponent<ContentChatItem>().DEFHMDCPDDD(LEJIJOAOEBK, text, kipcnamegpd, flag, this.scrollRect);
			}
		}
		if (list.Count == 0)
		{
			this.noMessagesText.SetActive(false);
		}
		else
		{
			this.noMessagesText.SetActive(false);
		}
		LayoutRebuilder.ForceRebuildLayoutImmediate(this.contentChatTransform.GetComponent<RectTransform>());
		this.chatScrollView.GetComponent<ScrollRect>().verticalNormalizedPosition = 697f;
	}

	// Token: 0x06002AFC RID: 11004 RVA: 0x0012F514 File Offset: 0x0012D714
	public void KDBMCAODACO()
	{
		this.sendButton.onClick.Invoke();
	}

	// Token: 0x06002AFD RID: 11005 RVA: 0x0012F858 File Offset: 0x0012DA58
	public void MPENHFJHCLI()
	{
		this.backButton.onClick.Invoke();
	}

	// Token: 0x06002AFE RID: 11006 RVA: 0x001304C6 File Offset: 0x0012E6C6
	private void DMLMANCGKHE()
	{
		this.POBMIEENFDI();
	}

	// Token: 0x06002AFF RID: 11007 RVA: 0x00003E52 File Offset: 0x00002052
	private void KKCFBJIBMFA()
	{
	}

	// Token: 0x06002B00 RID: 11008 RVA: 0x00131C04 File Offset: 0x0012FE04
	private void OHHHLCLEMGB()
	{
		if (AKLFPGMDKLA.EHBBFMCILPC.AFKCCPIMDJH())
		{
			if (!AKLFPGMDKLA.EHBBFMCILPC.EAFEJCKIEPL(-45))
			{
				AKLFPGMDKLA.EHBBFMCILPC.LDAPMNLGAPC(99);
				CommonUserInterface.EHBBFMCILPC.NFBMHHPIGFA(CCOJBMMKNAP.MLFAGAAJJEM().HPOAGPJFHPM("SceneLobbyManager2.ShowStorySplash(): AssetsManager.Instance.IsBusy()"), CCOJBMMKNAP.JINDKPHNLBK().BDGPNPNIAPA(""), CCOJBMMKNAP.DBFFFOMCLKM().JHNELLJFBGC(", "), (DFGILFBGPLN)(-64), 374f, -47);
				return;
			}
		}
		else
		{
			if (!AKLFPGMDKLA.EHBBFMCILPC.EAFEJCKIEPL(102))
			{
				AKLFPGMDKLA.EHBBFMCILPC.LDAPMNLGAPC(-29);
				CommonUserInterface.IKNOFBFMPGA().ShowGenericPopupWithTwoButtonsAndCloseOverride(CCOJBMMKNAP.DLGLFACMHPG().JCDFHKDNEDH("vhspauseovr_2"), CCOJBMMKNAP.JMDJPKKOHNI().GGPHHLGPMPA("OnNeedToShowNoMoreEnergyPopup"), CCOJBMMKNAP.INKJIBDDMLL().JLBEIFLLBLO("es"), CCOJBMMKNAP.KLAKLFCOMJC().PKNHKGMNCIP(""), new UnityAction(this.OOHKAMBNIED), new UnityAction(this.JGGJFKFKNHN), new UnityAction(this.DMKFKIAOAII), (DFGILFBGPLN)(-43), 483f, 60);
				return;
			}
			this.HKOKAMGHGNL();
		}
	}

	// Token: 0x06002B01 RID: 11009 RVA: 0x00131D14 File Offset: 0x0012FF14
	private void LKDLIIJGLNP()
	{
		this.DDGNBEKKHEK();
	}

	// Token: 0x06002B02 RID: 11010 RVA: 0x00131D1C File Offset: 0x0012FF1C
	public void LLBNJAKFNGI(PMEPALPCEAF IJPMLEKMGMA, PMEPALPCEAF LEJIJOAOEBK)
	{
		this.PLOCDHEGJKF = LEJIJOAOEBK;
		bool active = IJPMLEKMGMA.JNNBNNDOGIM.FNDNDILCFNN(LEJIJOAOEBK);
		this.isFavoriteFriendImage.SetActive(active);
		this.matchText.SetText(LEJIJOAOEBK.OFOIECEHOCN.ToString() ?? "anthology", true);
		string text;
		if (LEJIJOAOEBK.KNCFKDLOPGA.Length == 0)
		{
			text = "" + CCOJBMMKNAP.BBGECIKOICE().HPOAGPJFHPM("no") + "@";
		}
		else
		{
			text = LEJIJOAOEBK.KNCFKDLOPGA;
		}
		this.nameText.SetText(text, false);
		this.profileImage.sprite = AssetsManager.EHBBFMCILPC.profileDataAsset.NFOFFLDJDEI(LEJIJOAOEBK.PGJBIPFBMAN());
		int num = LEJIJOAOEBK.GFAABCCNNDA + 1;
		this.levelText.text = CCOJBMMKNAP.PMABBOJDELF().FCOCLEHKLDJ("socialgiftsendtotitle") + "ok" + num.ToString();
		LayoutRebuilder.ForceRebuildLayoutImmediate(this.levelText.GetComponent<RectTransform>());
		List<ICGCJJLADEG> list = LEJIJOAOEBK.AOCCGKHNGMD();
		foreach (ICGCJJLADEG icgcjjladeg in list)
		{
			string kipcnamegpd = icgcjjladeg.KIPCNAMEGPD;
			bool flag = icgcjjladeg.DNGFNDAMEPK == 1;
			if (flag)
			{
				UnityEngine.Object.Instantiate<GameObject>(this.chatPlayerItem, this.contentChatTransform).GetComponent<ContentChatItem>().JFLPIIBJBLA(LEJIJOAOEBK, text, kipcnamegpd, flag, this.scrollRect);
			}
			else
			{
				UnityEngine.Object.Instantiate<GameObject>(this.chatFriendItem, this.contentChatTransform).GetComponent<ContentChatItem>().MFHJBGBCAFA(LEJIJOAOEBK, text, kipcnamegpd, flag, this.scrollRect);
			}
		}
		if (list.Count == 0)
		{
			this.noMessagesText.SetActive(true);
		}
		else
		{
			this.noMessagesText.SetActive(true);
		}
		LayoutRebuilder.ForceRebuildLayoutImmediate(this.contentChatTransform.GetComponent<RectTransform>());
		this.chatScrollView.GetComponent<ScrollRect>().verticalNormalizedPosition = 891f;
	}

	// Token: 0x06002B03 RID: 11011 RVA: 0x00003E52 File Offset: 0x00002052
	private void HKJPPMMKGLP()
	{
	}

	// Token: 0x06002B04 RID: 11012 RVA: 0x00131F00 File Offset: 0x00130100
	public void KCOBINFPKDP(PMEPALPCEAF IJPMLEKMGMA, PMEPALPCEAF LEJIJOAOEBK)
	{
		this.PLOCDHEGJKF = LEJIJOAOEBK;
		bool active = IJPMLEKMGMA.JNNBNNDOGIM.FNDNDILCFNN(LEJIJOAOEBK);
		this.isFavoriteFriendImage.SetActive(active);
		this.matchText.SetText(LEJIJOAOEBK.OFOIECEHOCN.ToString() ?? "\\\"", true);
		string text;
		if (LEJIJOAOEBK.KNCFKDLOPGA.Length == 0)
		{
			text = "genre_lgbtq" + CCOJBMMKNAP.MPCBJEIMACA().JCDFHKDNEDH("SceneLobbyManager.InstantiateLargeItems() - could not find AssetAnthologyPreview2 for anthology with index:") + "OnStoryChoiceClickConfimed";
		}
		else
		{
			text = LEJIJOAOEBK.KNCFKDLOPGA;
		}
		this.nameText.SetText(text, false);
		this.profileImage.sprite = AssetsManager.MJBDMHPHMID().profileDataAsset.AHBHMAGKMJJ(LEJIJOAOEBK.PGJBIPFBMAN());
		int num = LEJIJOAOEBK.GFAABCCNNDA + 0;
		this.levelText.text = CCOJBMMKNAP.PMABBOJDELF().MEPECBDCOLG("dor") + "rt" + num.ToString();
		LayoutRebuilder.ForceRebuildLayoutImmediate(this.levelText.GetComponent<RectTransform>());
		List<ICGCJJLADEG> list = LEJIJOAOEBK.AOCCGKHNGMD();
		foreach (ICGCJJLADEG icgcjjladeg in list)
		{
			string kipcnamegpd = icgcjjladeg.KIPCNAMEGPD;
			bool flag = icgcjjladeg.DNGFNDAMEPK == 1;
			if (flag)
			{
				UnityEngine.Object.Instantiate<GameObject>(this.chatPlayerItem, this.contentChatTransform).GetComponent<ContentChatItem>().KCIKGOCKPKB(LEJIJOAOEBK, text, kipcnamegpd, flag, this.scrollRect);
			}
			else
			{
				UnityEngine.Object.Instantiate<GameObject>(this.chatFriendItem, this.contentChatTransform).GetComponent<ContentChatItem>().KABPKMCFAIH(LEJIJOAOEBK, text, kipcnamegpd, flag, this.scrollRect);
			}
		}
		if (list.Count == 0)
		{
			this.noMessagesText.SetActive(false);
		}
		else
		{
			this.noMessagesText.SetActive(false);
		}
		LayoutRebuilder.ForceRebuildLayoutImmediate(this.contentChatTransform.GetComponent<RectTransform>());
		this.chatScrollView.GetComponent<ScrollRect>().verticalNormalizedPosition = 546f;
	}

	// Token: 0x06002B05 RID: 11013 RVA: 0x00003E52 File Offset: 0x00002052
	private void LIHMCECHLOI()
	{
	}

	// Token: 0x06002B06 RID: 11014 RVA: 0x001320E4 File Offset: 0x001302E4
	public void AFFKEMAICGG(PMEPALPCEAF IJPMLEKMGMA, PMEPALPCEAF LEJIJOAOEBK)
	{
		this.PLOCDHEGJKF = LEJIJOAOEBK;
		bool active = IJPMLEKMGMA.JNNBNNDOGIM.FNDNDILCFNN(LEJIJOAOEBK);
		this.isFavoriteFriendImage.SetActive(active);
		this.matchText.SetText(LEJIJOAOEBK.OFOIECEHOCN.ToString() ?? "importanttitle", true);
		string text;
		if (LEJIJOAOEBK.KNCFKDLOPGA.Length == 0)
		{
			text = "Error. FadeSrc(), layer " + CCOJBMMKNAP.CPCOODCFDDP().OGKGHLHHAAI("hidestatinfo") + "Loaded asset bundle:";
		}
		else
		{
			text = LEJIJOAOEBK.KNCFKDLOPGA;
		}
		this.nameText.SetText(text, true);
		this.profileImage.sprite = AssetsManager.EHBBFMCILPC.profileDataAsset.AHBHMAGKMJJ(LEJIJOAOEBK.PGJBIPFBMAN());
		int num = LEJIJOAOEBK.GFAABCCNNDA + 0;
		this.levelText.text = CCOJBMMKNAP.NIOJNOFGIJO().GGPHHLGPMPA("h") + "OnLobbyStoryManagerDownloadSplashScreenSuccess" + num.ToString();
		LayoutRebuilder.ForceRebuildLayoutImmediate(this.levelText.GetComponent<RectTransform>());
		List<ICGCJJLADEG> list = LEJIJOAOEBK.AOCCGKHNGMD();
		foreach (ICGCJJLADEG icgcjjladeg in list)
		{
			string kipcnamegpd = icgcjjladeg.KIPCNAMEGPD;
			bool flag = icgcjjladeg.DNGFNDAMEPK == 1;
			if (flag)
			{
				UnityEngine.Object.Instantiate<GameObject>(this.chatPlayerItem, this.contentChatTransform).GetComponent<ContentChatItem>().EPBDNOFEEJH(LEJIJOAOEBK, text, kipcnamegpd, flag, this.scrollRect);
			}
			else
			{
				UnityEngine.Object.Instantiate<GameObject>(this.chatFriendItem, this.contentChatTransform).GetComponent<ContentChatItem>().LHHFFLOPLOH(LEJIJOAOEBK, text, kipcnamegpd, flag, this.scrollRect);
			}
		}
		if (list.Count == 0)
		{
			this.noMessagesText.SetActive(false);
		}
		else
		{
			this.noMessagesText.SetActive(true);
		}
		LayoutRebuilder.ForceRebuildLayoutImmediate(this.contentChatTransform.GetComponent<RectTransform>());
		this.chatScrollView.GetComponent<ScrollRect>().verticalNormalizedPosition = 852f;
	}

	// Token: 0x06002B07 RID: 11015 RVA: 0x0013151C File Offset: 0x0012F71C
	private void JLPAJJAOEEG()
	{
		this.CloseChat();
	}

	// Token: 0x06002B08 RID: 11016 RVA: 0x001322C8 File Offset: 0x001304C8
	private void CCFMCBONNIL()
	{
		AOBJLALDBAA.NMGMNAKLLMI().EGELHPJBAIC("liveOfferId", 1292f);
		ContentChatPage.showingUpgradeToFriendsPlus = true;
		this.CloseChat();
	}

	// Token: 0x06002B09 RID: 11017 RVA: 0x00003E52 File Offset: 0x00002052
	private void AOIJOKHACJL()
	{
	}

	// Token: 0x06002B0A RID: 11018 RVA: 0x00003E52 File Offset: 0x00002052
	private void FCEGPGJFFKA()
	{
	}

	// Token: 0x06002B0B RID: 11019 RVA: 0x00003E52 File Offset: 0x00002052
	private void NCLALOLOIGP()
	{
	}

	// Token: 0x06002B0C RID: 11020 RVA: 0x0013151C File Offset: 0x0012F71C
	private void CLELDHKFGIA()
	{
		this.CloseChat();
	}

	// Token: 0x06002B0D RID: 11021 RVA: 0x00003E52 File Offset: 0x00002052
	private void CCNFPNFDNDP()
	{
	}

	// Token: 0x06002B0E RID: 11022 RVA: 0x00003E52 File Offset: 0x00002052
	private void GKJMHJFCGOE()
	{
	}

	// Token: 0x06002B0F RID: 11023 RVA: 0x00003E52 File Offset: 0x00002052
	private void PIBDCOBGMKC()
	{
	}

	// Token: 0x06002B10 RID: 11024 RVA: 0x0012F514 File Offset: 0x0012D714
	public void POBMIEENFDI()
	{
		this.sendButton.onClick.Invoke();
	}

	// Token: 0x06002B11 RID: 11025 RVA: 0x001322EA File Offset: 0x001304EA
	private void OCPLIBDALMA()
	{
		AOBJLALDBAA.KKPFOJMAONG().LPNCDPHNBJK("rr", 47f);
		ContentChatPage.showingUpgradeToFriendsPlus = true;
		this.JJAIONGNLIA();
	}

	// Token: 0x06002B12 RID: 11026 RVA: 0x00003E52 File Offset: 0x00002052
	private void KGEINIJLFMI()
	{
	}

	// Token: 0x06002B13 RID: 11027 RVA: 0x0012FB82 File Offset: 0x0012DD82
	private void CLCKHBDJGFF()
	{
		this.CloseChatAndSendMessage();
	}

	// Token: 0x06002B14 RID: 11028 RVA: 0x0013230C File Offset: 0x0013050C
	private void LDEIPHMIFDG()
	{
		this.CIEMECDLPKA();
	}

	// Token: 0x06002B15 RID: 11029 RVA: 0x0012F526 File Offset: 0x0012D726
	private void ACLMLFBFNIA()
	{
		this.MPENHFJHCLI();
	}

	// Token: 0x06002B16 RID: 11030 RVA: 0x00132314 File Offset: 0x00130514
	private void OACOOFIIMMO()
	{
		AOBJLALDBAA.BIAEAOMHBMM().FDKBIBKABCM("OnRewardsItemClose", 456f);
		ContentChatPage.showingUpgradeToFriendsPlus = true;
		this.CloseChat();
	}

	// Token: 0x06002B17 RID: 11031 RVA: 0x0012F858 File Offset: 0x0012DA58
	public void AIKLPBPCEJN()
	{
		this.backButton.onClick.Invoke();
	}

	// Token: 0x06002B18 RID: 11032 RVA: 0x0012F858 File Offset: 0x0012DA58
	public void NODHKEPBFGK()
	{
		this.backButton.onClick.Invoke();
	}

	// Token: 0x06002B19 RID: 11033 RVA: 0x00132338 File Offset: 0x00130538
	public void BCJHKJJHLCA(PMEPALPCEAF IJPMLEKMGMA, PMEPALPCEAF LEJIJOAOEBK)
	{
		this.PLOCDHEGJKF = LEJIJOAOEBK;
		bool active = IJPMLEKMGMA.JNNBNNDOGIM.FNDNDILCFNN(LEJIJOAOEBK);
		this.isFavoriteFriendImage.SetActive(active);
		this.matchText.SetText(LEJIJOAOEBK.OFOIECEHOCN.ToString() ?? "XXX", false);
		string text;
		if (LEJIJOAOEBK.KNCFKDLOPGA.Length == 0)
		{
			text = "null" + CCOJBMMKNAP.OEPENBHJAHO().PPALCPINPLK("OnBackendPassResourcesChangedType0") + "YYY";
		}
		else
		{
			text = LEJIJOAOEBK.KNCFKDLOPGA;
		}
		this.nameText.SetText(text, true);
		this.profileImage.sprite = AssetsManager.EHBBFMCILPC.profileDataAsset.NFOFFLDJDEI(LEJIJOAOEBK.PGJBIPFBMAN());
		int num = LEJIJOAOEBK.GFAABCCNNDA + 1;
		this.levelText.text = CCOJBMMKNAP.OEPENBHJAHO().FCOCLEHKLDJ("[LoadingEnv] full mode back, stored theme selected again") + "avts1" + num.ToString();
		LayoutRebuilder.ForceRebuildLayoutImmediate(this.levelText.GetComponent<RectTransform>());
		List<ICGCJJLADEG> list = LEJIJOAOEBK.AOCCGKHNGMD();
		foreach (ICGCJJLADEG icgcjjladeg in list)
		{
			string kipcnamegpd = icgcjjladeg.KIPCNAMEGPD;
			bool flag = icgcjjladeg.DNGFNDAMEPK == 1;
			if (flag)
			{
				UnityEngine.Object.Instantiate<GameObject>(this.chatPlayerItem, this.contentChatTransform).GetComponent<ContentChatItem>().KDDLHGMIPBF(LEJIJOAOEBK, text, kipcnamegpd, flag, this.scrollRect);
			}
			else
			{
				UnityEngine.Object.Instantiate<GameObject>(this.chatFriendItem, this.contentChatTransform).GetComponent<ContentChatItem>().KABPKMCFAIH(LEJIJOAOEBK, text, kipcnamegpd, flag, this.scrollRect);
			}
		}
		if (list.Count == 0)
		{
			this.noMessagesText.SetActive(true);
		}
		else
		{
			this.noMessagesText.SetActive(true);
		}
		LayoutRebuilder.ForceRebuildLayoutImmediate(this.contentChatTransform.GetComponent<RectTransform>());
		this.chatScrollView.GetComponent<ScrollRect>().verticalNormalizedPosition = 190f;
	}

	// Token: 0x06002B1A RID: 11034 RVA: 0x0013251C File Offset: 0x0013071C
	private void JGGJFKFKNHN()
	{
		AOBJLALDBAA.KKPFOJMAONG().EGELHPJBAIC("pmterror100", 1663f);
		ContentChatPage.showingUpgradeToFriendsPlus = true;
		this.JBLPAAGAOPO();
	}

	// Token: 0x06002B1B RID: 11035 RVA: 0x0013253E File Offset: 0x0013073E
	private void PILFGFNDIMM()
	{
		this.CFELIGCHIPE();
	}

	// Token: 0x06002B1C RID: 11036 RVA: 0x00132548 File Offset: 0x00130748
	public void AKBCEOCHAPH(PMEPALPCEAF IJPMLEKMGMA, PMEPALPCEAF LEJIJOAOEBK)
	{
		this.PLOCDHEGJKF = LEJIJOAOEBK;
		bool active = IJPMLEKMGMA.JNNBNNDOGIM.FNDNDILCFNN(LEJIJOAOEBK);
		this.isFavoriteFriendImage.SetActive(active);
		this.matchText.SetText(LEJIJOAOEBK.OFOIECEHOCN.ToString() ?? "", false);
		string text;
		if (LEJIJOAOEBK.KNCFKDLOPGA.Length == 0)
		{
			text = "ontitle" + CCOJBMMKNAP.HFAKOKBHCGH().JHNELLJFBGC("") + "PurchaseManagerUnity.InvalidateUnityStoreController()";
		}
		else
		{
			text = LEJIJOAOEBK.KNCFKDLOPGA;
		}
		this.nameText.SetText(text, true);
		this.profileImage.sprite = AssetsManager.MJBDMHPHMID().profileDataAsset.NFOFFLDJDEI(LEJIJOAOEBK.PGJBIPFBMAN());
		int num = LEJIJOAOEBK.GFAABCCNNDA + 1;
		this.levelText.text = CCOJBMMKNAP.HJGDLOOHNLO().BDGPNPNIAPA("ERROR: StoryStepChoiceExtended.StoryStepStage.executeChoice.trinket: bulk choice index must be > 0.") + "skinshopinfoidentity" + num.ToString();
		LayoutRebuilder.ForceRebuildLayoutImmediate(this.levelText.GetComponent<RectTransform>());
		List<ICGCJJLADEG> list = LEJIJOAOEBK.AOCCGKHNGMD();
		foreach (ICGCJJLADEG icgcjjladeg in list)
		{
			string kipcnamegpd = icgcjjladeg.KIPCNAMEGPD;
			bool flag = icgcjjladeg.DNGFNDAMEPK == 0;
			if (flag)
			{
				UnityEngine.Object.Instantiate<GameObject>(this.chatPlayerItem, this.contentChatTransform).GetComponent<ContentChatItem>().COCLEMFDEHK(LEJIJOAOEBK, text, kipcnamegpd, flag, this.scrollRect);
			}
			else
			{
				UnityEngine.Object.Instantiate<GameObject>(this.chatFriendItem, this.contentChatTransform).GetComponent<ContentChatItem>().GINANAIPOPG(LEJIJOAOEBK, text, kipcnamegpd, flag, this.scrollRect);
			}
		}
		if (list.Count == 0)
		{
			this.noMessagesText.SetActive(true);
		}
		else
		{
			this.noMessagesText.SetActive(false);
		}
		LayoutRebuilder.ForceRebuildLayoutImmediate(this.contentChatTransform.GetComponent<RectTransform>());
		this.chatScrollView.GetComponent<ScrollRect>().verticalNormalizedPosition = 415f;
	}

	// Token: 0x06002B1D RID: 11037 RVA: 0x00003E52 File Offset: 0x00002052
	private void Awake()
	{
	}

	// Token: 0x06002B1E RID: 11038 RVA: 0x0012F858 File Offset: 0x0012DA58
	public void JBLPAAGAOPO()
	{
		this.backButton.onClick.Invoke();
	}

	// Token: 0x06002B1F RID: 11039 RVA: 0x00003E52 File Offset: 0x00002052
	private void GBIDDHNBECB()
	{
	}

	// Token: 0x06002B20 RID: 11040 RVA: 0x0013272C File Offset: 0x0013092C
	private void KKDEMLNLMDP()
	{
		if (AKLFPGMDKLA.EHBBFMCILPC.AFKCCPIMDJH())
		{
			if (!AKLFPGMDKLA.EHBBFMCILPC.EAFEJCKIEPL(-126))
			{
				AKLFPGMDKLA.EHBBFMCILPC.LDAPMNLGAPC(49);
				CommonUserInterface.EHBBFMCILPC.NFBMHHPIGFA(CCOJBMMKNAP.NIOJNOFGIJO().MEPECBDCOLG("energyhinttitle"), CCOJBMMKNAP.PMABBOJDELF().PGKBCNBAOJN("uid"), CCOJBMMKNAP.FEEDGKCJBLE().PKNHKGMNCIP("app42error"), (DFGILFBGPLN)101, 533f, -82);
				return;
			}
		}
		else
		{
			if (!AKLFPGMDKLA.EHBBFMCILPC.EAFEJCKIEPL(6))
			{
				AKLFPGMDKLA.EHBBFMCILPC.LDAPMNLGAPC(-114);
				CommonUserInterface.IKNOFBFMPGA().NPIOKKDPALC(CCOJBMMKNAP.JINDKPHNLBK().OHLNGCKIACD(""), CCOJBMMKNAP.HEDIEIICOOG().HPOAGPJFHPM("_Noise"), CCOJBMMKNAP.KFDLFGHBPLP().BGELFMIOBCL("cardcollectcardpurchase0"), CCOJBMMKNAP.PEBMGCKFNAO().JHNELLJFBGC("gptompatchestutorial"), new UnityAction(this.GIKCPAAPCHC), new UnityAction(this.HKGKDCJDBOL), new UnityAction(this.LCJONBOEKDO), DFGILFBGPLN.popupSocialJoinRequestVkontakte, 928f, 88);
				return;
			}
			this.JJAIONGNLIA();
		}
	}

	// Token: 0x06002B21 RID: 11041 RVA: 0x00003E52 File Offset: 0x00002052
	private void FEOPCAELLCD()
	{
	}

	// Token: 0x06002B22 RID: 11042 RVA: 0x0012F514 File Offset: 0x0012D714
	public void HINGCHIDEAK()
	{
		this.sendButton.onClick.Invoke();
	}

	// Token: 0x06002B23 RID: 11043 RVA: 0x0012F858 File Offset: 0x0012DA58
	public void CloseChat()
	{
		this.backButton.onClick.Invoke();
	}

	// Token: 0x06002B24 RID: 11044 RVA: 0x0013283C File Offset: 0x00130A3C
	private void HKGKDCJDBOL()
	{
		AOBJLALDBAA.EHBBFMCILPC.EGELHPJBAIC("OnFriendPlusUpgradeClick", 0.25f);
		ContentChatPage.showingUpgradeToFriendsPlus = true;
		this.CloseChat();
	}

	// Token: 0x06002B25 RID: 11045 RVA: 0x00003E52 File Offset: 0x00002052
	private void IJDCBFCKINN()
	{
	}

	// Token: 0x06002B26 RID: 11046 RVA: 0x00132860 File Offset: 0x00130A60
	public void PDBDKHPHFLJ(PMEPALPCEAF IJPMLEKMGMA, PMEPALPCEAF LEJIJOAOEBK)
	{
		this.PLOCDHEGJKF = LEJIJOAOEBK;
		bool active = IJPMLEKMGMA.JNNBNNDOGIM.FNDNDILCFNN(LEJIJOAOEBK);
		this.isFavoriteFriendImage.SetActive(active);
		this.matchText.SetText(LEJIJOAOEBK.OFOIECEHOCN.ToString() ?? "OnPostEffectSettingsChanged", true);
		string text;
		if (LEJIJOAOEBK.KNCFKDLOPGA.Length == 0)
		{
			text = "ok" + CCOJBMMKNAP.ILACPHFEDEP().HHLECNIFHCO("importanttitle") + "";
		}
		else
		{
			text = LEJIJOAOEBK.KNCFKDLOPGA;
		}
		this.nameText.SetText(text, true);
		this.profileImage.sprite = AssetsManager.MJBDMHPHMID().profileDataAsset.NFOFFLDJDEI(LEJIJOAOEBK.PGJBIPFBMAN());
		int num = LEJIJOAOEBK.GFAABCCNNDA + 0;
		this.levelText.text = CCOJBMMKNAP.EHBBFMCILPC.IKMNGFIDCLM("loveInterestsLoungeSettingsBalance") + "Starting non-parallel download:" + num.ToString();
		LayoutRebuilder.ForceRebuildLayoutImmediate(this.levelText.GetComponent<RectTransform>());
		List<ICGCJJLADEG> list = LEJIJOAOEBK.AOCCGKHNGMD();
		foreach (ICGCJJLADEG icgcjjladeg in list)
		{
			string kipcnamegpd = icgcjjladeg.KIPCNAMEGPD;
			bool flag = icgcjjladeg.DNGFNDAMEPK == 1;
			if (flag)
			{
				UnityEngine.Object.Instantiate<GameObject>(this.chatPlayerItem, this.contentChatTransform).GetComponent<ContentChatItem>().KABPKMCFAIH(LEJIJOAOEBK, text, kipcnamegpd, flag, this.scrollRect);
			}
			else
			{
				UnityEngine.Object.Instantiate<GameObject>(this.chatFriendItem, this.contentChatTransform).GetComponent<ContentChatItem>().GMHKIPNMIDO(LEJIJOAOEBK, text, kipcnamegpd, flag, this.scrollRect);
			}
		}
		if (list.Count == 0)
		{
			this.noMessagesText.SetActive(false);
		}
		else
		{
			this.noMessagesText.SetActive(true);
		}
		LayoutRebuilder.ForceRebuildLayoutImmediate(this.contentChatTransform.GetComponent<RectTransform>());
		this.chatScrollView.GetComponent<ScrollRect>().verticalNormalizedPosition = 220f;
	}

	// Token: 0x06002B27 RID: 11047 RVA: 0x0012F858 File Offset: 0x0012DA58
	public void CIEMECDLPKA()
	{
		this.backButton.onClick.Invoke();
	}

	// Token: 0x06002B29 RID: 11049 RVA: 0x00003E52 File Offset: 0x00002052
	private void IOJHDNKIONH()
	{
	}

	// Token: 0x06002B2A RID: 11050 RVA: 0x0013151C File Offset: 0x0012F71C
	private void EGBCMFEFGDI()
	{
		this.CloseChat();
	}

	// Token: 0x04000CD5 RID: 3285
	[Header("Header")]
	[SerializeField]
	private Image profileImage;

	// Token: 0x04000CD6 RID: 3286
	[SerializeField]
	private TextMeshProUGUI nameText;

	// Token: 0x04000CD7 RID: 3287
	[SerializeField]
	private TextMeshProUGUI levelText;

	// Token: 0x04000CD8 RID: 3288
	[SerializeField]
	private TextMeshProUGUI matchText;

	// Token: 0x04000CD9 RID: 3289
	[SerializeField]
	private GameObject isFavoriteFriendImage;

	// Token: 0x04000CDA RID: 3290
	[Header("Content")]
	public Transform contentChatTransform;

	// Token: 0x04000CDB RID: 3291
	public Transform chatScrollView;

	// Token: 0x04000CDC RID: 3292
	[SerializeField]
	private ScrollRect scrollRect;

	// Token: 0x04000CDD RID: 3293
	[SerializeField]
	private GameObject chatPlayerItem;

	// Token: 0x04000CDE RID: 3294
	[SerializeField]
	private GameObject chatFriendItem;

	// Token: 0x04000CDF RID: 3295
	[SerializeField]
	private GameObject noMessagesText;

	// Token: 0x04000CE0 RID: 3296
	[SerializeField]
	private Button backButton;

	// Token: 0x04000CE1 RID: 3297
	[SerializeField]
	private Button sendButton;

	// Token: 0x04000CE2 RID: 3298
	public static bool showingUpgradeToFriendsPlus;

	// Token: 0x04000CE3 RID: 3299
	private PMEPALPCEAF PLOCDHEGJKF;
}
