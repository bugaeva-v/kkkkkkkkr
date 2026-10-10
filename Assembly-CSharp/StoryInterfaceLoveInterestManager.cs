using System;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

// Token: 0x020003D2 RID: 978
public class StoryInterfaceLoveInterestManager : MonoBehaviour
{
	// Token: 0x0600712F RID: 28975 RVA: 0x00003E52 File Offset: 0x00002052
	private void KGKHCNJOFKN()
	{
	}

	// Token: 0x06007130 RID: 28976 RVA: 0x00330D4C File Offset: 0x0032EF4C
	private void LMLGONOEJNG(string HAPADEOFKBP)
	{
		StoryInterfaceLoveInterestManager.GJDPEDOMGLO gjdpedomglo = new StoryInterfaceLoveInterestManager.GJDPEDOMGLO();
		gjdpedomglo.<>4__this = this;
		if (ODJKHCHFKNL.GENJHBKLJDL() == (DFGILFBGPLN)(-101))
		{
			AOBJLALDBAA.EHBBFMCILPC.PMDEKGAFCCL("layervideo", HAPADEOFKBP);
			return;
		}
		try
		{
			int num = int.Parse(DPGJIJGOCIC.NLGJAJDKIGH(HAPADEOFKBP));
			string dpjinbcgngn = CCOJBMMKNAP.PLJMLDOCPNM().FCOCLEHKLDJ("x").Replace("...", "$e1ro" + GKJPOGNFKNK.DNILNCLIHAP("YYY" + num.ToString(), "", LanguageManager.EHBBFMCILPC.IEBFINIJAMJ()) + "continue").Replace("no", "E" + GKJPOGNFKNK.DNILNCLIHAP(HAPADEOFKBP, "OnStartFreePassSuccess", LanguageManager.EHBBFMCILPC.IEBFINIJAMJ()) + "");
			gjdpedomglo.spriteNameForLink = HAPADEOFKBP;
			CommonUserInterface.IKNOFBFMPGA().PEBIFCENHAL(CCOJBMMKNAP.ONCPHEEJLOP().FCOCLEHKLDJ("a"), dpjinbcgngn, CCOJBMMKNAP.COKDLDOAACJ().BGELFMIOBCL("ok"), new UnityAction(gjdpedomglo.GCDMIFEKOJC), (DFGILFBGPLN)(-99), 854f, 0);
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
	}

	// Token: 0x06007131 RID: 28977 RVA: 0x00330E68 File Offset: 0x0032F068
	public void KGKENIPKLBD()
	{
		if (null == this.thumbnailImage || null == this.thumbnailImage.sprite)
		{
			return;
		}
		this.IEKKNKKAJMK(this.thumbnailImage.sprite.name);
	}

	// Token: 0x06007132 RID: 28978 RVA: 0x00003E52 File Offset: 0x00002052
	private void EHECBKECKPA()
	{
	}

	// Token: 0x06007133 RID: 28979 RVA: 0x00330EA4 File Offset: 0x0032F0A4
	private void CBPIOFDGOCO(string HAPADEOFKBP)
	{
		StoryInterfaceLoveInterestManager.GJDPEDOMGLO gjdpedomglo = new StoryInterfaceLoveInterestManager.GJDPEDOMGLO();
		gjdpedomglo.<>4__this = this;
		if (ODJKHCHFKNL.JMCDGLKNCNF() == (DFGILFBGPLN)(-28))
		{
			AOBJLALDBAA.NMGMNAKLLMI().FIJKIAKDCNO("'", HAPADEOFKBP);
			return;
		}
		try
		{
			int num = int.Parse(DPGJIJGOCIC.NLGJAJDKIGH(HAPADEOFKBP));
			string dpjinbcgngn = CCOJBMMKNAP.MLFAGAAJJEM().FIENAKIHNOM("<b>").Replace("onlineresourcesbody", "confirmexit" + GKJPOGNFKNK.DNILNCLIHAP("sslind" + num.ToString(), "userpublicprofileanthology", LanguageManager.EHBBFMCILPC.IEBFINIJAMJ()) + "@").Replace("gamepassdurationtitle", "ant" + GKJPOGNFKNK.DNILNCLIHAP(HAPADEOFKBP, "…", LanguageManager.EHBBFMCILPC.NBANPEIHFOJ()) + "inkr");
			gjdpedomglo.spriteNameForLink = HAPADEOFKBP;
			CommonUserInterface.EHBBFMCILPC.ShowGenericPopupOneOverride(CCOJBMMKNAP.OBOOKJPGBJN().OGKGHLHHAAI("\""), dpjinbcgngn, CCOJBMMKNAP.JINDKPHNLBK().HDIPNMFHIEJ("0"), new UnityAction(gjdpedomglo.GCDMIFEKOJC), (DFGILFBGPLN)(-20), 1104f, -118);
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
	}

	// Token: 0x06007134 RID: 28980 RVA: 0x00330FC0 File Offset: 0x0032F1C0
	public void IPDGNEBNNHO()
	{
		if (null == this.thumbnailImage || null == this.thumbnailImage.sprite)
		{
			return;
		}
		this.DPJEOCMHBPF(this.thumbnailImage.sprite.name);
	}

	// Token: 0x06007135 RID: 28981 RVA: 0x00330FFA File Offset: 0x0032F1FA
	public void CLJMHNCPPEH()
	{
		if (null == this.thumbnailImage || null == this.thumbnailImage.sprite)
		{
			return;
		}
		this.ACHGFAHGGDL(this.thumbnailImage.sprite.name);
	}

	// Token: 0x06007136 RID: 28982 RVA: 0x00331034 File Offset: 0x0032F234
	public void CIDLPDHFOBF()
	{
		if (null == this.thumbnailImage || null == this.thumbnailImage.sprite)
		{
			return;
		}
		this.LMLGONOEJNG(this.thumbnailImage.sprite.name);
	}

	// Token: 0x06007137 RID: 28983 RVA: 0x0033106E File Offset: 0x0032F26E
	public void OnThumbnailClick()
	{
		if (null == this.thumbnailImage || null == this.thumbnailImage.sprite)
		{
			return;
		}
		this.PABGKFBKECE(this.thumbnailImage.sprite.name);
	}

	// Token: 0x06007138 RID: 28984 RVA: 0x00003E52 File Offset: 0x00002052
	private void AMLICNPKJNO()
	{
	}

	// Token: 0x06007139 RID: 28985 RVA: 0x003310A8 File Offset: 0x0032F2A8
	public void CAHKFJHCJKB()
	{
		if (null == this.thumbnailImage || null == this.thumbnailImage.sprite)
		{
			return;
		}
		this.FLHKDGJJNOP(this.thumbnailImage.sprite.name);
	}

	// Token: 0x0600713A RID: 28986 RVA: 0x00003E52 File Offset: 0x00002052
	private void KGEINIJLFMI()
	{
	}

	// Token: 0x0600713B RID: 28987 RVA: 0x003310E2 File Offset: 0x0032F2E2
	public void IEMJNMFADHE()
	{
		if (null == this.thumbnailImage || null == this.thumbnailImage.sprite)
		{
			return;
		}
		this.CBPIOFDGOCO(this.thumbnailImage.sprite.name);
	}

	// Token: 0x0600713C RID: 28988 RVA: 0x00003E52 File Offset: 0x00002052
	private void JFEKHEIGPJD()
	{
	}

	// Token: 0x0600713D RID: 28989 RVA: 0x00330FC0 File Offset: 0x0032F1C0
	public void LAHDJIPFGIF()
	{
		if (null == this.thumbnailImage || null == this.thumbnailImage.sprite)
		{
			return;
		}
		this.DPJEOCMHBPF(this.thumbnailImage.sprite.name);
	}

	// Token: 0x0600713E RID: 28990 RVA: 0x0033111C File Offset: 0x0032F31C
	private void ACHGFAHGGDL(string HAPADEOFKBP)
	{
		StoryInterfaceLoveInterestManager.GJDPEDOMGLO gjdpedomglo = new StoryInterfaceLoveInterestManager.GJDPEDOMGLO();
		gjdpedomglo.<>4__this = this;
		if (ODJKHCHFKNL.KBOLHCPDDPB() == DFGILFBGPLN.popupQuitConfirm)
		{
			AOBJLALDBAA.KKPFOJMAONG().PAODLAFIKBG("chtss", HAPADEOFKBP);
			return;
		}
		try
		{
			int num = int.Parse(DPGJIJGOCIC.NLGJAJDKIGH(HAPADEOFKBP));
			string dpjinbcgngn = CCOJBMMKNAP.HFAKOKBHCGH().IKMNGFIDCLM("role").Replace("", "." + GKJPOGNFKNK.DNILNCLIHAP("updateUserPublicProfileFriends" + num.ToString(), "socialremovetradeable", LanguageManager.EHBBFMCILPC.NBANPEIHFOJ()) + " cached requests.").Replace(",", "Color noise" + GKJPOGNFKNK.DNILNCLIHAP(HAPADEOFKBP, "", LanguageManager.EHBBFMCILPC.NBANPEIHFOJ()) + "\n");
			gjdpedomglo.spriteNameForLink = HAPADEOFKBP;
			CommonUserInterface.EHBBFMCILPC.ShowGenericPopupOneOverride(CCOJBMMKNAP.AEELGGPEJCC().HIPJILDCHJC("uid"), dpjinbcgngn, CCOJBMMKNAP.LMCCLMFGEBD().OHLNGCKIACD("/"), new UnityAction(gjdpedomglo.GCDMIFEKOJC), (DFGILFBGPLN)118, 1271f, -115);
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x0600713F RID: 28991 RVA: 0x00003E52 File Offset: 0x00002052
	private void AALDINEPEHJ()
	{
	}

	// Token: 0x06007140 RID: 28992 RVA: 0x00331238 File Offset: 0x0032F438
	public void IKBPBJMPLHA()
	{
		if (null == this.thumbnailImage || null == this.thumbnailImage.sprite)
		{
			return;
		}
		this.HENHOOLMDFB(this.thumbnailImage.sprite.name);
	}

	// Token: 0x06007141 RID: 28993 RVA: 0x00331272 File Offset: 0x0032F472
	public void CHGCIFKIFBB()
	{
		if (null == this.thumbnailImage || null == this.thumbnailImage.sprite)
		{
			return;
		}
		this.HJOMDPIGKAA(this.thumbnailImage.sprite.name);
	}

	// Token: 0x06007142 RID: 28994 RVA: 0x003312AC File Offset: 0x0032F4AC
	private void DPJEOCMHBPF(string HAPADEOFKBP)
	{
		StoryInterfaceLoveInterestManager.GJDPEDOMGLO gjdpedomglo = new StoryInterfaceLoveInterestManager.GJDPEDOMGLO();
		gjdpedomglo.<>4__this = this;
		if (ODJKHCHFKNL.GLFFNHDPOGG() == (DFGILFBGPLN)(-58))
		{
			AOBJLALDBAA.BIAEAOMHBMM().AKILMNPJGGM("anthologiestitle", HAPADEOFKBP);
			return;
		}
		try
		{
			int num = int.Parse(DPGJIJGOCIC.NLGJAJDKIGH(HAPADEOFKBP));
			string dpjinbcgngn = CCOJBMMKNAP.LMCCLMFGEBD().HPOAGPJFHPM("YYY").Replace("not", "Shaders/VideoGlitchOldTV" + GKJPOGNFKNK.DNILNCLIHAP("' has no category, skipped" + num.ToString(), " ", LanguageManager.EHBBFMCILPC.MLOLBFBODHD()) + "cardoptionsloadingthemereset").Replace("%", "ok" + GKJPOGNFKNK.DNILNCLIHAP(HAPADEOFKBP, "OnCutsceneViewAssetsDownloadFailed", LanguageManager.EHBBFMCILPC.IEBFINIJAMJ()) + "hiddenTopMatchEntries:");
			gjdpedomglo.spriteNameForLink = HAPADEOFKBP;
			CommonUserInterface.EHBBFMCILPC.ShowGenericPopupOneOverride(CCOJBMMKNAP.JMNIGPHCAEJ().HPOAGPJFHPM("id"), dpjinbcgngn, CCOJBMMKNAP.PLJMLDOCPNM().FIENAKIHNOM("ProductBridge.GetLocalizedCostData() - product is null."), new UnityAction(gjdpedomglo.GCDMIFEKOJC), DFGILFBGPLN.popupIncentAd1Failed, 1432f, 45);
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x06007143 RID: 28995 RVA: 0x00331238 File Offset: 0x0032F438
	public void DLCAHEBIOOA()
	{
		if (null == this.thumbnailImage || null == this.thumbnailImage.sprite)
		{
			return;
		}
		this.HENHOOLMDFB(this.thumbnailImage.sprite.name);
	}

	// Token: 0x06007144 RID: 28996 RVA: 0x003313C8 File Offset: 0x0032F5C8
	private void MHFDBNJCEBP(string HAPADEOFKBP)
	{
		try
		{
			StoryInterfaceHeaderManager componentInParent = base.GetComponentInParent<StoryInterfaceHeaderManager>();
			if (null == componentInParent)
			{
				DPGJIJGOCIC.ADFCDFHBDAF("StoryInterfaceLoveInterestManager.OpenWardrobeFromPopup() - no header above the item");
			}
			else
			{
				componentInParent.OpenLoungeForLoveInterestSprite(HAPADEOFKBP);
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x06007145 RID: 28997 RVA: 0x00331414 File Offset: 0x0032F614
	private void DHOONBGIOMF(string HAPADEOFKBP)
	{
		try
		{
			StoryInterfaceHeaderManager componentInParent = base.GetComponentInParent<StoryInterfaceHeaderManager>();
			if (null == componentInParent)
			{
				DPGJIJGOCIC.ADFCDFHBDAF("");
			}
			else
			{
				componentInParent.OpenLoungeForLoveInterestSprite(HAPADEOFKBP);
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x06007146 RID: 28998 RVA: 0x00003E52 File Offset: 0x00002052
	private void HGEODIPIBPG()
	{
	}

	// Token: 0x06007147 RID: 28999 RVA: 0x00331460 File Offset: 0x0032F660
	public void BDNOELHGGBM()
	{
		if (null == this.thumbnailImage || null == this.thumbnailImage.sprite)
		{
			return;
		}
		this.IAEOPBKHDIL(this.thumbnailImage.sprite.name);
	}

	// Token: 0x06007148 RID: 29000 RVA: 0x0033149C File Offset: 0x0032F69C
	private void PABGKFBKECE(string HAPADEOFKBP)
	{
		StoryInterfaceLoveInterestManager.GJDPEDOMGLO gjdpedomglo = new StoryInterfaceLoveInterestManager.GJDPEDOMGLO();
		gjdpedomglo.<>4__this = this;
		if (ODJKHCHFKNL.LEMILALILKP() == DFGILFBGPLN.screenLounge)
		{
			AOBJLALDBAA.EHBBFMCILPC.EGELHPJBAIC("OnLoungeLoveInterestShortcutClick", HAPADEOFKBP);
			return;
		}
		try
		{
			int num = int.Parse(DPGJIJGOCIC.NLGJAJDKIGH(HAPADEOFKBP));
			string dpjinbcgngn = CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("gpoptionsclickchar").Replace("XXX", "<i>" + GKJPOGNFKNK.DNILNCLIHAP("anthology" + num.ToString(), "anthologiestitle", LanguageManager.EHBBFMCILPC.GetSelectedLanguage()) + "</i>").Replace("YYY", "<i>" + GKJPOGNFKNK.DNILNCLIHAP(HAPADEOFKBP, "profilechars", LanguageManager.EHBBFMCILPC.GetSelectedLanguage()) + "</i>");
			gjdpedomglo.spriteNameForLink = HAPADEOFKBP;
			CommonUserInterface.EHBBFMCILPC.ShowGenericPopupOneOverride(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("energyhinttitle"), dpjinbcgngn, CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("loungeopenwardrobe"), new UnityAction(gjdpedomglo.GCDMIFEKOJC), DFGILFBGPLN.popupEnergyHint, 0f, 28);
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x06007149 RID: 29001 RVA: 0x003315B8 File Offset: 0x0032F7B8
	private void FLHKDGJJNOP(string HAPADEOFKBP)
	{
		StoryInterfaceLoveInterestManager.GJDPEDOMGLO gjdpedomglo = new StoryInterfaceLoveInterestManager.GJDPEDOMGLO();
		gjdpedomglo.<>4__this = this;
		if (ODJKHCHFKNL.CMDIBLIELFE() == (DFGILFBGPLN)(-53))
		{
			AOBJLALDBAA.KKPFOJMAONG().BDEMEIKEJHF("tradewishcardoption0", HAPADEOFKBP);
			return;
		}
		try
		{
			int num = int.Parse(DPGJIJGOCIC.NLGJAJDKIGH(HAPADEOFKBP));
			string dpjinbcgngn = CCOJBMMKNAP.INKJIBDDMLL().JHNELLJFBGC("\"").Replace("lsenvattempt", "per" + GKJPOGNFKNK.DNILNCLIHAP("skinshopinfoidentity" + num.ToString(), "", LanguageManager.EHBBFMCILPC.IEBFINIJAMJ()) + "There needs to be one active CommonUserInterface script on a GameObject in your scene.").Replace("restartChapterOrStory", "socialrequestsharegr" + GKJPOGNFKNK.DNILNCLIHAP(HAPADEOFKBP, "acliffbw21", LanguageManager.EHBBFMCILPC.NBANPEIHFOJ()) + "");
			gjdpedomglo.spriteNameForLink = HAPADEOFKBP;
			CommonUserInterface.IKNOFBFMPGA().PEBIFCENHAL(CCOJBMMKNAP.HJGDLOOHNLO().OBDCPLLLGBB("〃"), dpjinbcgngn, CCOJBMMKNAP.JMNIGPHCAEJ().BGELFMIOBCL("\""), new UnityAction(gjdpedomglo.GCDMIFEKOJC), (DFGILFBGPLN)(-96), 863f, -15);
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x0600714A RID: 29002 RVA: 0x003316D4 File Offset: 0x0032F8D4
	private void JNJEOCIMOBL(string HAPADEOFKBP)
	{
		StoryInterfaceLoveInterestManager.GJDPEDOMGLO gjdpedomglo = new StoryInterfaceLoveInterestManager.GJDPEDOMGLO();
		gjdpedomglo.<>4__this = this;
		if (ODJKHCHFKNL.IJAAOAOKCCL() == DFGILFBGPLN.screenHub)
		{
			AOBJLALDBAA.CEGAOMEEFBE().FIJKIAKDCNO("assetbundlepurchasingview", HAPADEOFKBP);
			return;
		}
		try
		{
			int num = int.Parse(DPGJIJGOCIC.NLGJAJDKIGH(HAPADEOFKBP));
			string dpjinbcgngn = CCOJBMMKNAP.AEELGGPEJCC().HHLECNIFHCO("tradewishcardoption1").Replace("cdnerror", "data" + GKJPOGNFKNK.DNILNCLIHAP("" + num.ToString(), "ChapterSnapshotsItem.OnChapterSnapshotRestore(): impossible condition 1", LanguageManager.EHBBFMCILPC.MLOLBFBODHD()) + "NarrowScreenScaler.CalculateNewScaleUtil(): returned a ").Replace("OnLoungePremiumChoicesHistoryException", "stats" + GKJPOGNFKNK.DNILNCLIHAP(HAPADEOFKBP, ", increasing m_ReferencedCount.", LanguageManager.EHBBFMCILPC.MLOLBFBODHD()) + "CLIENT.SCREEN.AVATAR.");
			gjdpedomglo.spriteNameForLink = HAPADEOFKBP;
			CommonUserInterface.IKNOFBFMPGA().ShowGenericPopupOneOverride(CCOJBMMKNAP.LMCCLMFGEBD().HIPJILDCHJC("post"), dpjinbcgngn, CCOJBMMKNAP.LMCCLMFGEBD().OHLNGCKIACD("$CHOICEMETA"), new UnityAction(gjdpedomglo.GCDMIFEKOJC), DFGILFBGPLN.popupOutdatedRevision, 1628f, 37);
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x0600714B RID: 29003 RVA: 0x003317F0 File Offset: 0x0032F9F0
	private void DBBHHLBHIPD(string HAPADEOFKBP)
	{
		try
		{
			StoryInterfaceHeaderManager componentInParent = base.GetComponentInParent<StoryInterfaceHeaderManager>();
			if (null == componentInParent)
			{
				DPGJIJGOCIC.ADFCDFHBDAF("Asset bundle assets destroyed:");
			}
			else
			{
				componentInParent.OpenLoungeForLoveInterestSprite(HAPADEOFKBP);
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
	}

	// Token: 0x0600714C RID: 29004 RVA: 0x00003E52 File Offset: 0x00002052
	private void NPFILNGGHGH()
	{
	}

	// Token: 0x0600714D RID: 29005 RVA: 0x0033183C File Offset: 0x0032FA3C
	private void POFHAFBOLOL(string HAPADEOFKBP)
	{
		StoryInterfaceLoveInterestManager.GJDPEDOMGLO gjdpedomglo = new StoryInterfaceLoveInterestManager.GJDPEDOMGLO();
		gjdpedomglo.<>4__this = this;
		if (ODJKHCHFKNL.NMEIBDCALLA() == (DFGILFBGPLN)(-112))
		{
			AOBJLALDBAA.DBLAIDPICIG().BDEMEIKEJHF("OnSettingsPopupCloseAndNeedToShowPostEnableNotif", HAPADEOFKBP);
			return;
		}
		try
		{
			int num = int.Parse(DPGJIJGOCIC.NLGJAJDKIGH(HAPADEOFKBP));
			string dpjinbcgngn = CCOJBMMKNAP.KFDLFGHBPLP().GGPHHLGPMPA("").Replace("", "XXX" + GKJPOGNFKNK.DNILNCLIHAP(" " + num.ToString(), "egss", LanguageManager.EHBBFMCILPC.GetSelectedLanguage()) + "anthology").Replace("sketchLayers", "Critical error, could not load asset bundle:" + GKJPOGNFKNK.DNILNCLIHAP(HAPADEOFKBP, "ok", LanguageManager.EHBBFMCILPC.NBANPEIHFOJ()) + "PurchaseManagerUnity.OnSuccessInitializeGamingServices()");
			gjdpedomglo.spriteNameForLink = HAPADEOFKBP;
			CommonUserInterface.IKNOFBFMPGA().ShowGenericPopupOneOverride(CCOJBMMKNAP.KFAABHHGOPO().IPEIONBNIPH("lck"), dpjinbcgngn, CCOJBMMKNAP.PKEINLPIAEH().JLBEIFLLBLO("OnPopupOfferManagerContinueToPurchasingScreen"), new UnityAction(gjdpedomglo.GCDMIFEKOJC), (DFGILFBGPLN)(-122), 610f, 90);
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x0600714E RID: 29006 RVA: 0x00003E52 File Offset: 0x00002052
	private void LKLNNDNCNOK()
	{
	}

	// Token: 0x0600714F RID: 29007 RVA: 0x00003E52 File Offset: 0x00002052
	private void Awake()
	{
	}

	// Token: 0x06007150 RID: 29008 RVA: 0x0033106E File Offset: 0x0032F26E
	public void JEBLJNCAOAI()
	{
		if (null == this.thumbnailImage || null == this.thumbnailImage.sprite)
		{
			return;
		}
		this.PABGKFBKECE(this.thumbnailImage.sprite.name);
	}

	// Token: 0x06007151 RID: 29009 RVA: 0x00003E52 File Offset: 0x00002052
	private void PMDCMEKGFNN()
	{
	}

	// Token: 0x06007152 RID: 29010 RVA: 0x00331958 File Offset: 0x0032FB58
	private void HJOMDPIGKAA(string HAPADEOFKBP)
	{
		StoryInterfaceLoveInterestManager.GJDPEDOMGLO gjdpedomglo = new StoryInterfaceLoveInterestManager.GJDPEDOMGLO();
		gjdpedomglo.<>4__this = this;
		if (ODJKHCHFKNL.NMMPNMMBEIC() == DFGILFBGPLN.popupGamePassDurationOffer)
		{
			AOBJLALDBAA.NMGMNAKLLMI().BDEMEIKEJHF("fvrt", HAPADEOFKBP);
			return;
		}
		try
		{
			int num = int.Parse(DPGJIJGOCIC.NLGJAJDKIGH(HAPADEOFKBP));
			string dpjinbcgngn = CCOJBMMKNAP.CEGAOMEEFBE().MEPECBDCOLG("OnRewardReplayEpisodeClick").Replace("UpdateComponentTitleDesc() failed - AssetAvatarComponentType.body is null.", "hrd" + GKJPOGNFKNK.DNILNCLIHAP("OnFriendPlusUpgradeClick" + num.ToString(), "lightmodeintrobody1", LanguageManager.EHBBFMCILPC.GetSelectedLanguage()) + "e1ct").Replace("OnFriendsGiftPopulCollectPart1", "SD" + GKJPOGNFKNK.DNILNCLIHAP(HAPADEOFKBP, "account.json", LanguageManager.EHBBFMCILPC.MLOLBFBODHD()) + "");
			gjdpedomglo.spriteNameForLink = HAPADEOFKBP;
			CommonUserInterface.IKNOFBFMPGA().BGJFCEEDGFJ(CCOJBMMKNAP.KMNBCEMEBBD().HIPJILDCHJC("onwishcardclickbody"), dpjinbcgngn, CCOJBMMKNAP.BOFMCPPFAMO().PGKBCNBAOJN("profilenametitleshort"), new UnityAction(gjdpedomglo.GCDMIFEKOJC), DFGILFBGPLN.popupSignInError, 1017f, -56);
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x06007153 RID: 29011 RVA: 0x00003E52 File Offset: 0x00002052
	private void GNHDCIGPFOH()
	{
	}

	// Token: 0x06007154 RID: 29012 RVA: 0x00331A74 File Offset: 0x0032FC74
	private void LFKFFDJEGOC(string HAPADEOFKBP)
	{
		try
		{
			StoryInterfaceHeaderManager componentInParent = base.GetComponentInParent<StoryInterfaceHeaderManager>();
			if (null == componentInParent)
			{
				DPGJIJGOCIC.PJCLICBPPDA("");
			}
			else
			{
				componentInParent.OpenLoungeForLoveInterestSprite(HAPADEOFKBP);
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
	}

	// Token: 0x06007155 RID: 29013 RVA: 0x00331AC0 File Offset: 0x0032FCC0
	private void KMEDKEPFNJG(string HAPADEOFKBP)
	{
		try
		{
			StoryInterfaceHeaderManager componentInParent = base.GetComponentInParent<StoryInterfaceHeaderManager>();
			if (null == componentInParent)
			{
				DPGJIJGOCIC.ADFCDFHBDAF("$AVATARUNLOCK");
			}
			else
			{
				componentInParent.OpenLoungeForLoveInterestSprite(HAPADEOFKBP);
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x06007156 RID: 29014 RVA: 0x00331B0C File Offset: 0x0032FD0C
	private void MJEJDPNFHCO(string HAPADEOFKBP)
	{
		try
		{
			StoryInterfaceHeaderManager componentInParent = base.GetComponentInParent<StoryInterfaceHeaderManager>();
			if (null == componentInParent)
			{
				DPGJIJGOCIC.PJCLICBPPDA("ip-api.com");
			}
			else
			{
				componentInParent.OpenLoungeForLoveInterestSprite(HAPADEOFKBP);
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
	}

	// Token: 0x06007157 RID: 29015 RVA: 0x00003E52 File Offset: 0x00002052
	private void EBBIFAMPCCI()
	{
	}

	// Token: 0x06007158 RID: 29016 RVA: 0x00003E52 File Offset: 0x00002052
	private void OOMMKGMBAGK()
	{
	}

	// Token: 0x06007159 RID: 29017 RVA: 0x00330E68 File Offset: 0x0032F068
	public void BFOMOGGADMP()
	{
		if (null == this.thumbnailImage || null == this.thumbnailImage.sprite)
		{
			return;
		}
		this.IEKKNKKAJMK(this.thumbnailImage.sprite.name);
	}

	// Token: 0x0600715A RID: 29018 RVA: 0x00003E52 File Offset: 0x00002052
	private void JDMOENJPHOE()
	{
	}

	// Token: 0x0600715B RID: 29019 RVA: 0x0033106E File Offset: 0x0032F26E
	public void BMCEAAHLPFC()
	{
		if (null == this.thumbnailImage || null == this.thumbnailImage.sprite)
		{
			return;
		}
		this.PABGKFBKECE(this.thumbnailImage.sprite.name);
	}

	// Token: 0x0600715C RID: 29020 RVA: 0x00003E52 File Offset: 0x00002052
	private void PPMLHHMFHLO()
	{
	}

	// Token: 0x0600715D RID: 29021 RVA: 0x00003E52 File Offset: 0x00002052
	private void BPDHPMKCLNB()
	{
	}

	// Token: 0x0600715E RID: 29022 RVA: 0x00003E52 File Offset: 0x00002052
	private void DJDCGDDMKEL()
	{
	}

	// Token: 0x0600715F RID: 29023 RVA: 0x00003E52 File Offset: 0x00002052
	private void JFFNFDKBMGP()
	{
	}

	// Token: 0x06007160 RID: 29024 RVA: 0x00003E52 File Offset: 0x00002052
	private void Start()
	{
	}

	// Token: 0x06007161 RID: 29025 RVA: 0x00003E52 File Offset: 0x00002052
	private void CJOOOIECMAE()
	{
	}

	// Token: 0x06007162 RID: 29026 RVA: 0x00331B58 File Offset: 0x0032FD58
	private void KAEFNOJMOPM(string HAPADEOFKBP)
	{
		StoryInterfaceLoveInterestManager.GJDPEDOMGLO gjdpedomglo = new StoryInterfaceLoveInterestManager.GJDPEDOMGLO();
		gjdpedomglo.<>4__this = this;
		if (ODJKHCHFKNL.PJMEPGPHDAD() == (DFGILFBGPLN)(-64))
		{
			AOBJLALDBAA.BIAEAOMHBMM().PAODLAFIKBG("OnCutsceneViewShow", HAPADEOFKBP);
			return;
		}
		try
		{
			int num = int.Parse(DPGJIJGOCIC.NLGJAJDKIGH(HAPADEOFKBP));
			string dpjinbcgngn = CCOJBMMKNAP.OEPENBHJAHO().JHNELLJFBGC(" this time, caching system not ready and no direct cache files").Replace("OnApplicationFocusBasicSyncSuccess", "OnChoiceExtendedViewedChoiceChanged" + GKJPOGNFKNK.DNILNCLIHAP("oldvhsovr_1" + num.ToString(), "hcfc3", LanguageManager.EHBBFMCILPC.MLOLBFBODHD()) + "loungebonus").Replace("OnRewardsItemClose", "YYY" + GKJPOGNFKNK.DNILNCLIHAP(HAPADEOFKBP, "*", LanguageManager.EHBBFMCILPC.GetSelectedLanguage()) + "chaptersnapshotsinfottitle");
			gjdpedomglo.spriteNameForLink = HAPADEOFKBP;
			CommonUserInterface.IKNOFBFMPGA().PEBIFCENHAL(CCOJBMMKNAP.JINDKPHNLBK().OHLNGCKIACD("$SENDNOTIF"), dpjinbcgngn, CCOJBMMKNAP.MLFAGAAJJEM().IPEIONBNIPH("passgoldlockeddescX"), new UnityAction(gjdpedomglo.GCDMIFEKOJC), DFGILFBGPLN.popupLootInfo, 658f, 5);
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x06007163 RID: 29027 RVA: 0x00003E52 File Offset: 0x00002052
	private void CDHHGBKGGDG()
	{
	}

	// Token: 0x06007164 RID: 29028 RVA: 0x00003E52 File Offset: 0x00002052
	private void FDOPMEKNMEA()
	{
	}

	// Token: 0x06007165 RID: 29029 RVA: 0x00331034 File Offset: 0x0032F234
	public void CGHJIEBPMDD()
	{
		if (null == this.thumbnailImage || null == this.thumbnailImage.sprite)
		{
			return;
		}
		this.LMLGONOEJNG(this.thumbnailImage.sprite.name);
	}

	// Token: 0x06007166 RID: 29030 RVA: 0x00330FC0 File Offset: 0x0032F1C0
	public void LJLGEJDNGKE()
	{
		if (null == this.thumbnailImage || null == this.thumbnailImage.sprite)
		{
			return;
		}
		this.DPJEOCMHBPF(this.thumbnailImage.sprite.name);
	}

	// Token: 0x06007167 RID: 29031 RVA: 0x00003E52 File Offset: 0x00002052
	private void PKPANMAFAIL()
	{
	}

	// Token: 0x06007168 RID: 29032 RVA: 0x00331272 File Offset: 0x0032F472
	public void CLMCOPJDMHP()
	{
		if (null == this.thumbnailImage || null == this.thumbnailImage.sprite)
		{
			return;
		}
		this.HJOMDPIGKAA(this.thumbnailImage.sprite.name);
	}

	// Token: 0x06007169 RID: 29033 RVA: 0x00003E52 File Offset: 0x00002052
	private void HPGLEEHELDN()
	{
	}

	// Token: 0x0600716A RID: 29034 RVA: 0x00331C74 File Offset: 0x0032FE74
	private void INEDHGHBNCF(string HAPADEOFKBP)
	{
		try
		{
			StoryInterfaceHeaderManager componentInParent = base.GetComponentInParent<StoryInterfaceHeaderManager>();
			if (null == componentInParent)
			{
				DPGJIJGOCIC.ADFCDFHBDAF("PlaySfx() file not found:");
			}
			else
			{
				componentInParent.OpenLoungeForLoveInterestSprite(HAPADEOFKBP);
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
	}

	// Token: 0x0600716B RID: 29035 RVA: 0x00003E52 File Offset: 0x00002052
	private void LBDIDHDKHGO()
	{
	}

	// Token: 0x0600716C RID: 29036 RVA: 0x00331CC0 File Offset: 0x0032FEC0
	private void HENHOOLMDFB(string HAPADEOFKBP)
	{
		StoryInterfaceLoveInterestManager.GJDPEDOMGLO gjdpedomglo = new StoryInterfaceLoveInterestManager.GJDPEDOMGLO();
		gjdpedomglo.<>4__this = this;
		if (ODJKHCHFKNL.PJBDPCPNGPB() == (DFGILFBGPLN)(-82))
		{
			AOBJLALDBAA.AGANFKKBPFO().PAODLAFIKBG("playonce", HAPADEOFKBP);
			return;
		}
		try
		{
			int num = int.Parse(DPGJIJGOCIC.NLGJAJDKIGH(HAPADEOFKBP));
			string dpjinbcgngn = CCOJBMMKNAP.EAIAHCBAIEJ().FCOCLEHKLDJ("</i>").Replace("", "<i>" + GKJPOGNFKNK.DNILNCLIHAP("energyhinttitle" + num.ToString(), "", LanguageManager.EHBBFMCILPC.GetSelectedLanguage()) + "rwt").Replace("areyousure", "acb" + GKJPOGNFKNK.DNILNCLIHAP(HAPADEOFKBP, "errortitle", LanguageManager.EHBBFMCILPC.GetSelectedLanguage()) + "XXX");
			gjdpedomglo.spriteNameForLink = HAPADEOFKBP;
			CommonUserInterface.IKNOFBFMPGA().ShowGenericPopupOneOverride(CCOJBMMKNAP.EHBBFMCILPC.HDIPNMFHIEJ("Critical error, could not load asset bundle:"), dpjinbcgngn, CCOJBMMKNAP.AEELGGPEJCC().PGKBCNBAOJN("OnPopupRemoveAdsManagerContinueToPurchasingScreen"), new UnityAction(gjdpedomglo.GCDMIFEKOJC), DFGILFBGPLN.popupIncentAd3Failed, 1303f, -110);
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
	}

	// Token: 0x0600716D RID: 29037 RVA: 0x00331DDC File Offset: 0x0032FFDC
	private void DDFADLBFIIP(string HAPADEOFKBP)
	{
		try
		{
			StoryInterfaceHeaderManager componentInParent = base.GetComponentInParent<StoryInterfaceHeaderManager>();
			if (null == componentInParent)
			{
				DPGJIJGOCIC.ADFCDFHBDAF("credo");
			}
			else
			{
				componentInParent.OpenLoungeForLoveInterestSprite(HAPADEOFKBP);
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x0600716F RID: 29039 RVA: 0x00003E52 File Offset: 0x00002052
	private void OPPNHGEMHAB()
	{
	}

	// Token: 0x06007170 RID: 29040 RVA: 0x00331E28 File Offset: 0x00330028
	private void IAEOPBKHDIL(string HAPADEOFKBP)
	{
		StoryInterfaceLoveInterestManager.GJDPEDOMGLO gjdpedomglo = new StoryInterfaceLoveInterestManager.GJDPEDOMGLO();
		gjdpedomglo.<>4__this = this;
		if (ODJKHCHFKNL.NMMPNMMBEIC() == DFGILFBGPLN.popoverLobbyRewards)
		{
			AOBJLALDBAA.EHBBFMCILPC.PMDEKGAFCCL("CLIENT.SCREEN.AVATAR.", HAPADEOFKBP);
			return;
		}
		try
		{
			int num = int.Parse(DPGJIJGOCIC.NLGJAJDKIGH(HAPADEOFKBP));
			string dpjinbcgngn = CCOJBMMKNAP.BOFMCPPFAMO().OHLNGCKIACD("skpublishsuccess").Replace("", "OnAvatarCollectionRestoreEntry" + GKJPOGNFKNK.DNILNCLIHAP("saveslotscopymarked" + num.ToString(), "common", LanguageManager.EHBBFMCILPC.MLOLBFBODHD()) + "acd").Replace("OnAllCollectableCardsDownloadSuccess", "OnAllCollectableCardsDownloadSuccess" + GKJPOGNFKNK.DNILNCLIHAP(HAPADEOFKBP, "OnPopupAvatarCollectionsInputCancel", LanguageManager.EHBBFMCILPC.NBANPEIHFOJ()) + "OnValidatePendingProcessed");
			gjdpedomglo.spriteNameForLink = HAPADEOFKBP;
			CommonUserInterface.EHBBFMCILPC.BGJFCEEDGFJ(CCOJBMMKNAP.ONCPHEEJLOP().PPALCPINPLK("splash"), dpjinbcgngn, CCOJBMMKNAP.HFAKOKBHCGH().IKMNGFIDCLM(""), new UnityAction(gjdpedomglo.GCDMIFEKOJC), (DFGILFBGPLN)95, 470f, 15);
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x06007171 RID: 29041 RVA: 0x00331F44 File Offset: 0x00330144
	private void EJMKOKHJODI(string HAPADEOFKBP)
	{
		StoryInterfaceLoveInterestManager.GJDPEDOMGLO gjdpedomglo = new StoryInterfaceLoveInterestManager.GJDPEDOMGLO();
		gjdpedomglo.<>4__this = this;
		if (ODJKHCHFKNL.GENJHBKLJDL() == (DFGILFBGPLN)(-63))
		{
			AOBJLALDBAA.CEGAOMEEFBE().OIMGLKLHNMO("feature disabled by balance", HAPADEOFKBP);
			return;
		}
		try
		{
			int num = int.Parse(DPGJIJGOCIC.NLGJAJDKIGH(HAPADEOFKBP));
			string dpjinbcgngn = CCOJBMMKNAP.ILACPHFEDEP().DNILNCLIHAP("").Replace("OnStorySplashManagerCdnSuccess", "lang" + GKJPOGNFKNK.DNILNCLIHAP("sfxtimeoutwarning" + num.ToString(), "credo", LanguageManager.EHBBFMCILPC.MLOLBFBODHD()) + "updateavailable").Replace("OnStoryInterfaceHeaderShown", "Loaded asset bundle:" + GKJPOGNFKNK.DNILNCLIHAP(HAPADEOFKBP, "", LanguageManager.EHBBFMCILPC.MLOLBFBODHD()) + "@");
			gjdpedomglo.spriteNameForLink = HAPADEOFKBP;
			CommonUserInterface.IKNOFBFMPGA().BGJFCEEDGFJ(CCOJBMMKNAP.ILACPHFEDEP().GGPHHLGPMPA("debugMessage"), dpjinbcgngn, CCOJBMMKNAP.EAIAHCBAIEJ().GLEFEKBDHNK("HD"), new UnityAction(gjdpedomglo.GCDMIFEKOJC), (DFGILFBGPLN)(-89), 659f, 2);
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x06007172 RID: 29042 RVA: 0x00332060 File Offset: 0x00330260
	private void IEKKNKKAJMK(string HAPADEOFKBP)
	{
		StoryInterfaceLoveInterestManager.GJDPEDOMGLO gjdpedomglo = new StoryInterfaceLoveInterestManager.GJDPEDOMGLO();
		gjdpedomglo.<>4__this = this;
		if (ODJKHCHFKNL.GLFFNHDPOGG() == (DFGILFBGPLN)(-97))
		{
			AOBJLALDBAA.KKPFOJMAONG().NEKAFJIEGHG("PageUp\nPageDown - Change effects.", HAPADEOFKBP);
			return;
		}
		try
		{
			int num = int.Parse(DPGJIJGOCIC.NLGJAJDKIGH(HAPADEOFKBP));
			string dpjinbcgngn = CCOJBMMKNAP.BOFMCPPFAMO().DNILNCLIHAP("").Replace("MMM", "%) with better variation from another slot:" + GKJPOGNFKNK.DNILNCLIHAP(") assettitle(" + num.ToString(), "yes", LanguageManager.EHBBFMCILPC.MLOLBFBODHD()) + "OnSaveSlotsItemSlotDuplicated").Replace("p", "OnBackendGetDefaultBundlesException" + GKJPOGNFKNK.DNILNCLIHAP(HAPADEOFKBP, "", LanguageManager.EHBBFMCILPC.IEBFINIJAMJ()) + "");
			gjdpedomglo.spriteNameForLink = HAPADEOFKBP;
			CommonUserInterface.EHBBFMCILPC.BGJFCEEDGFJ(CCOJBMMKNAP.INKJIBDDMLL().FCOCLEHKLDJ("PassThumbnail.PurchaseProductWebDuration(): productBalanceData is null for suffix '"), dpjinbcgngn, CCOJBMMKNAP.JMNIGPHCAEJ().BDGPNPNIAPA("errortitle"), new UnityAction(gjdpedomglo.GCDMIFEKOJC), (DFGILFBGPLN)(-79), 1650f, 64);
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x06007173 RID: 29043 RVA: 0x0033217C File Offset: 0x0033037C
	public void FILOCHCJAII()
	{
		if (null == this.thumbnailImage || null == this.thumbnailImage.sprite)
		{
			return;
		}
		this.EJMKOKHJODI(this.thumbnailImage.sprite.name);
	}

	// Token: 0x06007174 RID: 29044 RVA: 0x003321B8 File Offset: 0x003303B8
	private void HNDFJLCDHIH(string HAPADEOFKBP)
	{
		try
		{
			StoryInterfaceHeaderManager componentInParent = base.GetComponentInParent<StoryInterfaceHeaderManager>();
			if (null == componentInParent)
			{
				DPGJIJGOCIC.ADFCDFHBDAF("energyhinttitle");
			}
			else
			{
				componentInParent.OpenLoungeForLoveInterestSprite(HAPADEOFKBP);
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
	}

	// Token: 0x06007175 RID: 29045 RVA: 0x00332204 File Offset: 0x00330404
	private void KEDPMCJNHPE(string HAPADEOFKBP)
	{
		try
		{
			StoryInterfaceHeaderManager componentInParent = base.GetComponentInParent<StoryInterfaceHeaderManager>();
			if (null == componentInParent)
			{
				DPGJIJGOCIC.PJCLICBPPDA("nick");
			}
			else
			{
				componentInParent.OpenLoungeForLoveInterestSprite(HAPADEOFKBP);
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
	}

	// Token: 0x06007176 RID: 29046 RVA: 0x00332250 File Offset: 0x00330450
	private void GJBFHAJMFJN(string HAPADEOFKBP)
	{
		StoryInterfaceLoveInterestManager.GJDPEDOMGLO gjdpedomglo = new StoryInterfaceLoveInterestManager.GJDPEDOMGLO();
		gjdpedomglo.<>4__this = this;
		if (ODJKHCHFKNL.IJAAOAOKCCL() == DFGILFBGPLN.popupEnergyHint)
		{
			AOBJLALDBAA.EHBBFMCILPC.BDEMEIKEJHF("OnSketchThumbnailEmptyClick", HAPADEOFKBP);
			return;
		}
		try
		{
			int num = int.Parse(DPGJIJGOCIC.NLGJAJDKIGH(HAPADEOFKBP));
			string dpjinbcgngn = CCOJBMMKNAP.LMCCLMFGEBD().HPOAGPJFHPM("").Replace("lobby", "sim" + GKJPOGNFKNK.DNILNCLIHAP("-" + num.ToString(), "acb", LanguageManager.EHBBFMCILPC.IEBFINIJAMJ()) + "OnFriendsPopupSendSimpleClick").Replace("en", "OnChapterSnapshotsBackendFetchSuccess" + GKJPOGNFKNK.DNILNCLIHAP(HAPADEOFKBP, "profilenametitleshort", LanguageManager.EHBBFMCILPC.MLOLBFBODHD()) + "areyousurerestartepbody1");
			gjdpedomglo.spriteNameForLink = HAPADEOFKBP;
			CommonUserInterface.IKNOFBFMPGA().BGJFCEEDGFJ(CCOJBMMKNAP.DBFFFOMCLKM().GLEFEKBDHNK("acomp2"), dpjinbcgngn, CCOJBMMKNAP.MLFAGAAJJEM().IKMNGFIDCLM("lastFilter"), new UnityAction(gjdpedomglo.GCDMIFEKOJC), (DFGILFBGPLN)(-5), 898f, -61);
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x06007177 RID: 29047 RVA: 0x0033236C File Offset: 0x0033056C
	private void EGIKFJAEHLF(string HAPADEOFKBP)
	{
		try
		{
			StoryInterfaceHeaderManager componentInParent = base.GetComponentInParent<StoryInterfaceHeaderManager>();
			if (null == componentInParent)
			{
				DPGJIJGOCIC.PJCLICBPPDA(" is OUTSIDE the anthology's story family - not queued (clip:");
			}
			else
			{
				componentInParent.OpenLoungeForLoveInterestSprite(HAPADEOFKBP);
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x040021DB RID: 8667
	public Image thumbnailImage;

	// Token: 0x040021DC RID: 8668
	public GameObject lockedHeart;

	// Token: 0x040021DD RID: 8669
	public GameObject unlockedHeart;

	// Token: 0x040021DE RID: 8670
	public TextMeshProUGUI orderNumberText;

	// Token: 0x040021DF RID: 8671
	public GameObject arrowDown;

	// Token: 0x040021E0 RID: 8672
	public GameObject arrowUp;

	// Token: 0x040021E1 RID: 8673
	public TextMeshProUGUI percentText;

	// Token: 0x040021E2 RID: 8674
	public GameObject loungeLooksCountParent;

	// Token: 0x040021E3 RID: 8675
	public TextMeshProUGUI loungeLooksCountText;

	// Token: 0x020003D3 RID: 979
	[CompilerGenerated]
	private sealed class GJDPEDOMGLO
	{
		// Token: 0x06007178 RID: 29048 RVA: 0x003323B8 File Offset: 0x003305B8
		internal void GCDMIFEKOJC()
		{
			this.<>4__this.MHFDBNJCEBP(this.spriteNameForLink);
		}

		// Token: 0x040021E4 RID: 8676
		public StoryInterfaceLoveInterestManager <>4__this;

		// Token: 0x040021E5 RID: 8677
		public string spriteNameForLink;
	}
}
