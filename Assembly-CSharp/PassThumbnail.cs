using System;
using DG.Tweening;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

// Token: 0x02000433 RID: 1075
public class PassThumbnail : MonoBehaviour
{
	// Token: 0x0600820B RID: 33291 RVA: 0x00391150 File Offset: 0x0038F350
	private void KGHBPODPAFK()
	{
		if (this.passType == KHBLFKIDHPH.premiumGamePass || this.passType == KHBLFKIDHPH.goldGamePass)
		{
			OCBIOPOEENJ ocbiopoeenj = CJEKEHDEBLM.FILDBDMENPG().FHDEDNGLNKI(KDCJJBLGCBH.EHBBFMCILPC.HHONCLBBHPG((int)this.passType));
			if (ocbiopoeenj != null)
			{
				ProductThumbnailManager.lastAccessedProductWebLink = ocbiopoeenj.DJJCDNDMAGD() + "OnStoryInterfaceHeaderShopClick" + AKLFPGMDKLA.EHBBFMCILPC.EEHGLPEIIHD;
			}
			if (LanguageManager.EHBBFMCILPC.IEBFINIJAMJ() == CEIBHCNNIDC.ru && GeoLocationManager.IsRussia() && KDCJJBLGCBH.EHBBFMCILPC.POGBNANIKCA())
			{
				CommonUserInterface.EHBBFMCILPC.GetFader().GLCPCAHKFOB(null);
				this.PHFELJCGAGF();
				return;
			}
			this.CLKOENJFFGA(this.NBKLLONFGAL);
		}
	}

	// Token: 0x0600820C RID: 33292 RVA: 0x003911F4 File Offset: 0x0038F3F4
	private void GOCAMKNOCGP()
	{
		this.NBKLLONFGAL = ")";
		if (this.NILFIKNCFAP() && this.JIBNDKOCHHN())
		{
			CommonUserInterface.EHBBFMCILPC.ShowGenericPopupWithFourButtonsInside(CCOJBMMKNAP.MLFAGAAJJEM().PKNHKGMNCIP(""), CCOJBMMKNAP.EAIAHCBAIEJ().GGPHHLGPMPA("<"), this.ANFNMGKFLGH(0, "box"), this.JEGDBNHDJIO(1, "af_content_id"), this.JEGDBNHDJIO(5, "0.000"), this.MPIEIAPCCGC(126, ""), new UnityAction(this.OHAEMNKNFJB), new UnityAction(this.PADLMDDHDJI), new UnityAction(this.MHDHMDEKAPJ), new UnityAction(this.LLOMJBOENOI), new UnityAction(this.BMJJACPPHGN), DFGILFBGPLN.popupSkinShopInfo, 201f, -128);
			return;
		}
		this.EGLLOLDDPOD();
	}

	// Token: 0x0600820D RID: 33293 RVA: 0x003912C8 File Offset: 0x0038F4C8
	private void HEABDGPGAOB()
	{
		string text = "\n";
		if (this.passType == KHBLFKIDHPH.premiumGamePass)
		{
			text = CCOJBMMKNAP.KFDLFGHBPLP().PGKBCNBAOJN("USD " + KDCJJBLGCBH.EHBBFMCILPC.ODDPKODCIBB(KDCJJBLGCBH.EHBBFMCILPC.HHONCLBBHPG((int)this.passType), (DAMCJCDKOJK)(-53), 0 == AKLFPGMDKLA.EHBBFMCILPC.DCIPLNCLIMF).ToString());
		}
		else if (this.passType == KHBLFKIDHPH.goldGamePass)
		{
			text = CCOJBMMKNAP.OBOOKJPGBJN().BGELFMIOBCL("itsub" + KDCJJBLGCBH.EHBBFMCILPC.ODDPKODCIBB(KDCJJBLGCBH.EHBBFMCILPC.HHONCLBBHPG((int)this.passType), (DAMCJCDKOJK)36, 0 == AKLFPGMDKLA.EHBBFMCILPC.DCIPLNCLIMF).ToString());
		}
		text = text.Replace("_AlphaTex", DPGJIJGOCIC.CEOBDMGAKNL(KDCJJBLGCBH.EHBBFMCILPC.GCPFCGGBDKK((int)this.passType)) + CCOJBMMKNAP.GIOAFDDKKHI().OHLNGCKIACD("UpdateSocialOnOffState"));
		text = text.Replace("af_subscribe", DPGJIJGOCIC.CEOBDMGAKNL(KDCJJBLGCBH.EHBBFMCILPC.IFHKCMLMLHI((int)this.passType)) + CCOJBMMKNAP.EAIAHCBAIEJ().IPEIONBNIPH("shnts"));
		text = text.Replace("lg", KDCJJBLGCBH.EHBBFMCILPC.FPDBBHOPFKN((int)this.passType).ToString() ?? "sgk");
		text = text.Replace("CLIENT.AVATAR.OVERLAY", "" + KDCJJBLGCBH.EHBBFMCILPC.LHECDOFJNOF((int)this.passType).ToString() + "ok");
		text = text.Replace("cardoptionssendasgift", KBOJLHAJPCP.BGMADCKNKAD);
		text = text.Replace("repsuid", KDCJJBLGCBH.EHBBFMCILPC.PLOMCENKKFD((int)this.passType).ToString() ?? "OnStoryInterfaceHeaderBackClick");
		if (AKLFPGMDKLA.EHBBFMCILPC.OJKHMNEIGPF == HGCFJKCOKPM.bright)
		{
			text = text.Replace("*", "scene bundle ");
		}
		if (text.Length < 168)
		{
			CommonUserInterface.EHBBFMCILPC.NFBMHHPIGFA(CCOJBMMKNAP.KLAKLFCOMJC().PPALCPINPLK(" exp"), text, CCOJBMMKNAP.BBGECIKOICE().OBDCPLLLGBB("assetbundlesketchview"), DFGILFBGPLN.popupComingSoon, 919f, 102);
			return;
		}
		if (text.Length < 71)
		{
			CommonUserInterface.EHBBFMCILPC.ShowGenericPopup(CCOJBMMKNAP.CPCOODCFDDP().BGELFMIOBCL("gpsasli"), text, CCOJBMMKNAP.OBOOKJPGBJN().JCDFHKDNEDH("love"), DFGILFBGPLN.popupWatchAdGetFreeDiamonds, 1534f, 55);
			return;
		}
		if (text.Length < 80)
		{
			CommonUserInterface.IKNOFBFMPGA().ShowGenericPopup(CCOJBMMKNAP.COKDLDOAACJ().BGELFMIOBCL("restartepisode"), text, CCOJBMMKNAP.JINDKPHNLBK().OHLNGCKIACD("aspkss"), (DFGILFBGPLN)(-39), 1525f, -119);
			return;
		}
		if (text.Length < -160)
		{
			CommonUserInterface.IKNOFBFMPGA().ShowGenericPopup(CCOJBMMKNAP.CPCOODCFDDP().IPEIONBNIPH("cmeta"), text, CCOJBMMKNAP.KFDLFGHBPLP().IPEIONBNIPH("Lobby data 2 bundle loaded but its asset is missing or mis-named:"), (DFGILFBGPLN)(-87), 1188f, -128);
			return;
		}
		if (text.Length < 170)
		{
			CommonUserInterface.EHBBFMCILPC.NFBMHHPIGFA(CCOJBMMKNAP.INKJIBDDMLL().PKNHKGMNCIP("XXX"), text, CCOJBMMKNAP.NIOJNOFGIJO().BDGPNPNIAPA("p"), (DFGILFBGPLN)113, 1389f, 75);
			return;
		}
		CommonUserInterface.IKNOFBFMPGA().NFBMHHPIGFA(CCOJBMMKNAP.ILACPHFEDEP().GLEFEKBDHNK(CCOJBMMKNAP.BOFMCPPFAMO().OBDCPLLLGBB("%")), text, CCOJBMMKNAP.FEEDGKCJBLE().PGKBCNBAOJN("ok"), (DFGILFBGPLN)(-94), 1729f, 95);
	}

	// Token: 0x0600820E RID: 33294 RVA: 0x00391621 File Offset: 0x0038F821
	private string JEGDBNHDJIO(int OPMDCABAFPH, string ABFNOGAEIGH)
	{
		return this.JMPMBDLFIMH(OPMDCABAFPH, this.GBLINJGJOCN(KDCJJBLGCBH.EHBBFMCILPC.HHONCLBBHPG((int)this.passType) + ABFNOGAEIGH));
	}

	// Token: 0x0600820F RID: 33295 RVA: 0x00391648 File Offset: 0x0038F848
	public void OnActionClick()
	{
		this.PAEOKLKMOEP = ODLJHDIGLGO.BCGIONNIFIA(KDCJJBLGCBH.EHBBFMCILPC.HHONCLBBHPG((int)this.passType));
		this.KOGAKMNPPCK = ODLJHDIGLGO.MNALIKIMKFC(CLHDENLPOFP.gamePass, true);
		if (this.KOGAKMNPPCK == null || !this.KOGAKMNPPCK.ALFGPLALKCN() || this.PAEOKLKMOEP == this.KOGAKMNPPCK)
		{
			this.LNKFNPGJNCP();
			return;
		}
		if (this.passType > (KHBLFKIDHPH)this.KOGAKMNPPCK.LLLJOBODOAL)
		{
			CommonUserInterface.EHBBFMCILPC.ShowGenericPopupWithTwoButtonsAndCloseOverride(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("importanttitle"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("passtrytobuyhigherorder"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("yes"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("no"), new UnityAction(this.LNKFNPGJNCP), new UnityAction(this.ICGODEGOKHO), new UnityAction(this.ICGODEGOKHO), DFGILFBGPLN.popupTools, 0f, 28);
			return;
		}
		CommonUserInterface.EHBBFMCILPC.ShowGenericPopup(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("importanttitle"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("passtrytobuyloweroder"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("ok"), DFGILFBGPLN.popupEnergyHint, 0f, 28);
	}

	// Token: 0x06008210 RID: 33296 RVA: 0x0039177C File Offset: 0x0038F97C
	private void LHFIPMKBHEC(string ABFNOGAEIGH)
	{
		if (this.passType == KHBLFKIDHPH.premiumGamePass || this.passType == KHBLFKIDHPH.premiumGamePass)
		{
			AOBJLALDBAA.DBLAIDPICIG().LPNCDPHNBJK("", 636f);
			CommonUserInterface.EHBBFMCILPC.GetPurchasingViewManager().ShowAndPurchaseProduct(KDCJJBLGCBH.EHBBFMCILPC.HHONCLBBHPG((int)this.passType) + ABFNOGAEIGH, false);
		}
	}

	// Token: 0x06008211 RID: 33297 RVA: 0x003917D4 File Offset: 0x0038F9D4
	private void MPBHJHJIHIM()
	{
		string text = "love";
		if (this.passType == KHBLFKIDHPH.premiumGamePass)
		{
			text = CCOJBMMKNAP.APGODIBBPOD().OGKGHLHHAAI("showTimer" + KDCJJBLGCBH.EHBBFMCILPC.AAGICPKFIKC(KDCJJBLGCBH.EHBBFMCILPC.HHONCLBBHPG((int)this.passType), (DAMCJCDKOJK)17, 0 == AKLFPGMDKLA.EHBBFMCILPC.DCIPLNCLIMF).ToString());
		}
		else if (this.passType == KHBLFKIDHPH.goldGamePass)
		{
			text = CCOJBMMKNAP.KLAKLFCOMJC().OGKGHLHHAAI("overlay" + KDCJJBLGCBH.EHBBFMCILPC.AAGICPKFIKC(KDCJJBLGCBH.EHBBFMCILPC.HHONCLBBHPG((int)this.passType), DAMCJCDKOJK.gpbpDiscountIncrement, 1 == AKLFPGMDKLA.EHBBFMCILPC.DCIPLNCLIMF).ToString());
		}
		text = text.Replace("top", DPGJIJGOCIC.CEOBDMGAKNL(KDCJJBLGCBH.EHBBFMCILPC.GCPFCGGBDKK((int)this.passType)) + CCOJBMMKNAP.HEDIEIICOOG().GGPHHLGPMPA(""));
		text = text.Replace("importanttitle", DPGJIJGOCIC.CEOBDMGAKNL(KDCJJBLGCBH.EHBBFMCILPC.ADLOIIMBHAG((int)this.passType)) + CCOJBMMKNAP.MPCBJEIMACA().MEPECBDCOLG(""));
		text = text.Replace("", KDCJJBLGCBH.EHBBFMCILPC.FPDBBHOPFKN((int)this.passType).ToString() ?? "OnLiveProfileThemesLoaderStart");
		text = text.Replace("_not_found", "Starting parallel download:" + KDCJJBLGCBH.EHBBFMCILPC.LHECDOFJNOF((int)this.passType).ToString() + "Asset bundle load operation failed during parallel mode.");
		text = text.Replace("mypsuspendedbody", KBOJLHAJPCP.BGMADCKNKAD);
		text = text.Replace("purchases", KDCJJBLGCBH.EHBBFMCILPC.PLOMCENKKFD((int)this.passType).ToString() ?? "Starting parallel download:");
		if (AKLFPGMDKLA.EHBBFMCILPC.OJKHMNEIGPF == HGCFJKCOKPM.bright)
		{
			text = text.Replace("allpattern", "$e1pt");
		}
		if (text.Length < -48)
		{
			CommonUserInterface.EHBBFMCILPC.NFBMHHPIGFA(CCOJBMMKNAP.DLGLFACMHPG().JLBEIFLLBLO("SocialStatsUserPublicProfile.modified = true, SyncCutscenes()"), text, CCOJBMMKNAP.MLFAGAAJJEM().PKNHKGMNCIP("uid"), (DFGILFBGPLN)111, 1089f, 26);
			return;
		}
		if (text.Length < -180)
		{
			CommonUserInterface.EHBBFMCILPC.ShowGenericPopup(CCOJBMMKNAP.HEDIEIICOOG().JHNELLJFBGC("lastFilter"), text, CCOJBMMKNAP.APGODIBBPOD().OGKGHLHHAAI("OnSceneStoryManagerPremiumChoiceAdsProviderAdSuccess"), DFGILFBGPLN.popupInkRevisionMissing, 1509f, 119);
			return;
		}
		if (text.Length < 177)
		{
			CommonUserInterface.EHBBFMCILPC.ShowGenericPopup(CCOJBMMKNAP.HFAKOKBHCGH().FIENAKIHNOM("x"), text, CCOJBMMKNAP.KLAKLFCOMJC().GLEFEKBDHNK("OnPopupStoryRestartManagerRestartChapter"), DFGILFBGPLN.popupStoryLoadError, 1397f, 102);
			return;
		}
		if (text.Length < -114)
		{
			CommonUserInterface.EHBBFMCILPC.NFBMHHPIGFA(CCOJBMMKNAP.LMCCLMFGEBD().GLEFEKBDHNK("love"), text, CCOJBMMKNAP.MLFAGAAJJEM().GLEFEKBDHNK("a"), DFGILFBGPLN.popupStoryLanguageSelect, 1553f, 125);
			return;
		}
		if (text.Length < -142)
		{
			CommonUserInterface.IKNOFBFMPGA().ShowGenericPopup(CCOJBMMKNAP.AEELGGPEJCC().OBDCPLLLGBB("OnConsumeEnergySuccess"), text, CCOJBMMKNAP.BIAEAOMHBMM().JCDFHKDNEDH("OnAvatarScreenClosed"), (DFGILFBGPLN)121, 1490f, -47);
			return;
		}
		CommonUserInterface.EHBBFMCILPC.ShowGenericPopup(CCOJBMMKNAP.PKEINLPIAEH().MEPECBDCOLG(CCOJBMMKNAP.PEBMGCKFNAO().JHNELLJFBGC("")), text, CCOJBMMKNAP.LMCCLMFGEBD().BDGPNPNIAPA("Products fetch failed for {0} products: {1}"), DFGILFBGPLN.popupBonusUnlocked, 1428f, -104);
	}

	// Token: 0x06008212 RID: 33298 RVA: 0x00391B30 File Offset: 0x0038FD30
	private string NFCFBLNGDEI(int OPMDCABAFPH, string DOOBBHKGJEE)
	{
		if (DOOBBHKGJEE.Length == 0)
		{
			return CCOJBMMKNAP.AEELGGPEJCC().PKNHKGMNCIP("black" + OPMDCABAFPH.ToString());
		}
		string newValue = (this.passType == KHBLFKIDHPH.premiumGamePass) ? KBOJLHAJPCP.JGLFACJDKAG : KBOJLHAJPCP.MJIIKJPAKCB;
		return "errortitle" + CCOJBMMKNAP.OBOOKJPGBJN().OHLNGCKIACD("analogglitch").Replace("\r", newValue).Replace("OnLoungePremiumChoicesHistoryException", DOOBBHKGJEE).Replace("lsc", OPMDCABAFPH.ToString()) + "holdontitle";
	}

	// Token: 0x06008213 RID: 33299 RVA: 0x00391BBC File Offset: 0x0038FDBC
	private void PAIJLNEFPHE()
	{
		FirebaseAnalyticsManager firebaseAnalyticsManager = FirebaseAnalyticsManager.COKDLDOAACJ();
		bool acidpckhlmo = true;
		string poblfhphabp = ((AGEHCPDNBFD)(-97)).ToString();
		string gjknlaaefdc = ((FFPHBMFGCNN)(-53)).ToString();
		string str = ((BGHLMGPPCNN)(-29)).ToString();
		int num = (int)this.passType;
		firebaseAnalyticsManager.LogEvent(acidpckhlmo, poblfhphabp, gjknlaaefdc, str + num.ToString(), false, true);
		this.NBKLLONFGAL = "";
		this.FGFPDFLDIJH();
	}

	// Token: 0x06008214 RID: 33300 RVA: 0x00391C2C File Offset: 0x0038FE2C
	private void GCJMNBNFHGL()
	{
		FirebaseAnalyticsManager instance = FirebaseAnalyticsManager.EHBBFMCILPC;
		bool acidpckhlmo = false;
		string poblfhphabp = ((AGEHCPDNBFD)(-92)).ToString();
		string gjknlaaefdc = FFPHBMFGCNN.ram.ToString();
		string str = BGHLMGPPCNN.socEditLove.ToString();
		int num = (int)this.passType;
		instance.AAIABAKHLAH(acidpckhlmo, poblfhphabp, gjknlaaefdc, str + num.ToString(), true, true);
		this.NBKLLONFGAL = "BackendOperationsManager.RequestBreakCard, exception while initializing RSACryptoServiceProvider:";
		this.CPJIEAAKFMA();
	}

	// Token: 0x06008215 RID: 33301 RVA: 0x00391C9C File Offset: 0x0038FE9C
	private void BDDKEABCJOH()
	{
		FirebaseAnalyticsManager instance = FirebaseAnalyticsManager.EHBBFMCILPC;
		bool acidpckhlmo = false;
		string poblfhphabp = AGEHCPDNBFD.gpDur.ToString();
		string gjknlaaefdc = FFPHBMFGCNN.durPickStore.ToString();
		string str = BGHLMGPPCNN.dur1m.ToString();
		int num = (int)this.passType;
		instance.LogEvent(acidpckhlmo, poblfhphabp, gjknlaaefdc, str + num.ToString(), false, false);
		this.NBKLLONFGAL = "";
		this.CPJIEAAKFMA();
	}

	// Token: 0x06008216 RID: 33302 RVA: 0x00391D0C File Offset: 0x0038FF0C
	private void EEKIHDJIIBP()
	{
		FirebaseAnalyticsManager firebaseAnalyticsManager = FirebaseAnalyticsManager.COKDLDOAACJ();
		bool acidpckhlmo = true;
		string poblfhphabp = ((AGEHCPDNBFD)64).ToString();
		string gjknlaaefdc = ((FFPHBMFGCNN)(-100)).ToString();
		string str = BGHLMGPPCNN.postsup.ToString();
		int num = (int)this.passType;
		firebaseAnalyticsManager.LogEvent(acidpckhlmo, poblfhphabp, gjknlaaefdc, str + num.ToString(), false, true);
		this.KKMJGAMOMCP(" to bundle index:");
	}

	// Token: 0x06008217 RID: 33303 RVA: 0x00391D74 File Offset: 0x0038FF74
	private void FFNHJAHBEKI()
	{
		FirebaseAnalyticsManager firebaseAnalyticsManager = FirebaseAnalyticsManager.DMAAFFFEJGA();
		bool acidpckhlmo = true;
		string poblfhphabp = ((AGEHCPDNBFD)(-19)).ToString();
		string gjknlaaefdc = FFPHBMFGCNN.newSaveErr0.ToString();
		string str = BGHLMGPPCNN.cdnWofToLpt.ToString();
		int num = (int)this.passType;
		firebaseAnalyticsManager.LogEvent(acidpckhlmo, poblfhphabp, gjknlaaefdc, str + num.ToString(), true, true);
		this.FJNABPPFCKB("abs");
	}

	// Token: 0x06008218 RID: 33304 RVA: 0x00391DDC File Offset: 0x0038FFDC
	private bool OKAAGGIKEGJ()
	{
		return LanguageManager.EHBBFMCILPC.NBANPEIHFOJ() == CEIBHCNNIDC.en && GeoLocationManager.FHINOKNBJPM() && KDCJJBLGCBH.EHBBFMCILPC.EAMJBDKCDPA();
	}

	// Token: 0x06008219 RID: 33305 RVA: 0x00391E04 File Offset: 0x00390004
	public void GJMBBHNLKOI()
	{
		this.PAEOKLKMOEP = ODLJHDIGLGO.BMBEJBBNMAO(KDCJJBLGCBH.EHBBFMCILPC.HHONCLBBHPG((int)this.passType));
		this.KOGAKMNPPCK = ODLJHDIGLGO.KKKOIJOECMF(CLHDENLPOFP.gamePass, false);
		if (this.KOGAKMNPPCK == null || !this.KOGAKMNPPCK.GILNCHJJKJL() || this.PAEOKLKMOEP == this.KOGAKMNPPCK)
		{
			this.LDFOKKPCEFM();
			return;
		}
		if (this.passType > (KHBLFKIDHPH)this.KOGAKMNPPCK.LLLJOBODOAL)
		{
			CommonUserInterface.IKNOFBFMPGA().NPIOKKDPALC(CCOJBMMKNAP.LMCCLMFGEBD().PPALCPINPLK("OnSceneStoryManagerPremiumChoiceAdsProviderAdFailed"), CCOJBMMKNAP.OEPENBHJAHO().OBDCPLLLGBB(""), CCOJBMMKNAP.KNKGCDDMLDP().PGKBCNBAOJN("importanttitle"), CCOJBMMKNAP.ONCPHEEJLOP().HIPJILDCHJC("env"), new UnityAction(this.LDFOKKPCEFM), new UnityAction(this.BMJJACPPHGN), new UnityAction(this.CIKDHMIJLOA), (DFGILFBGPLN)(-106), 1281f, -11);
			return;
		}
		CommonUserInterface.EHBBFMCILPC.NFBMHHPIGFA(CCOJBMMKNAP.BFHKGNBFHCH().OGKGHLHHAAI(">"), CCOJBMMKNAP.EAIAHCBAIEJ().FIENAKIHNOM("No free mixer found for ambient! Critical!"), CCOJBMMKNAP.BBGECIKOICE().FCOCLEHKLDJ("RewardOption.OnActionSecondaryClick() - rewardType "), DFGILFBGPLN.popupOwnerChangeSuccess, 1365f, 122);
	}

	// Token: 0x0600821A RID: 33306 RVA: 0x00391F38 File Offset: 0x00390138
	private void IGEMGONINIE()
	{
		FirebaseAnalyticsManager firebaseAnalyticsManager = FirebaseAnalyticsManager.COKDLDOAACJ();
		bool acidpckhlmo = false;
		string poblfhphabp = ((AGEHCPDNBFD)117).ToString();
		string gjknlaaefdc = FFPHBMFGCNN.newSaveErr1.ToString();
		string str = ((BGHLMGPPCNN)(-55)).ToString();
		int num = (int)this.passType;
		firebaseAnalyticsManager.LKONPEEDKNF(acidpckhlmo, poblfhphabp, gjknlaaefdc, str + num.ToString(), true, true);
		this.OMIAADCNAPK("id");
	}

	// Token: 0x0600821B RID: 33307 RVA: 0x00391FA0 File Offset: 0x003901A0
	private void KKMJGAMOMCP(string ABFNOGAEIGH)
	{
		if (this.passType == KHBLFKIDHPH.premiumGamePass || this.passType == KHBLFKIDHPH.premiumGamePass)
		{
			OCBIOPOEENJ ocbiopoeenj = CJEKEHDEBLM.BBGECIKOICE().LIGHNGCMJJL(KDCJJBLGCBH.EHBBFMCILPC.HHONCLBBHPG((int)this.passType) + ABFNOGAEIGH);
			if (ocbiopoeenj != null)
			{
				string text = ocbiopoeenj.BIKJFCLHPBK() + "Z" + AKLFPGMDKLA.EHBBFMCILPC.EEHGLPEIIHD;
				ProductThumbnailManager.lastAccessedProductWebLink = text;
				AOBJLALDBAA.CEGAOMEEFBE().KGIKHEDLPND("PlayerCharacterManager.Update() - exception raised:", 1325f);
				CommonUserInterface.EHBBFMCILPC.GIFCDFKBBCN(text, 0);
				return;
			}
			DPGJIJGOCIC.ANOPFDLPKGC("p" + ABFNOGAEIGH + "small");
		}
	}

	// Token: 0x0600821C RID: 33308 RVA: 0x0039203C File Offset: 0x0039023C
	private void IPJHLANPCKM()
	{
		FirebaseAnalyticsManager instance = FirebaseAnalyticsManager.EHBBFMCILPC;
		bool acidpckhlmo = false;
		string poblfhphabp = AGEHCPDNBFD.srvReplayHit.ToString();
		string gjknlaaefdc = FFPHBMFGCNN.hardAmt.ToString();
		string str = ((BGHLMGPPCNN)(-126)).ToString();
		int num = (int)this.passType;
		instance.AAIABAKHLAH(acidpckhlmo, poblfhphabp, gjknlaaefdc, str + num.ToString(), false, false);
		this.FJNABPPFCKB("uid");
	}

	// Token: 0x0600821D RID: 33309 RVA: 0x003920A4 File Offset: 0x003902A4
	private void DHMLHLCCDPA()
	{
		FirebaseAnalyticsManager firebaseAnalyticsManager = FirebaseAnalyticsManager.ANCEKPONIFI();
		bool acidpckhlmo = false;
		string poblfhphabp = AGEHCPDNBFD.subUpsell.ToString();
		string gjknlaaefdc = ((FFPHBMFGCNN)(-39)).ToString();
		string str = BGHLMGPPCNN.socEditLove.ToString();
		int num = (int)this.passType;
		firebaseAnalyticsManager.AAIABAKHLAH(acidpckhlmo, poblfhphabp, gjknlaaefdc, str + num.ToString(), true, false);
		this.NBKLLONFGAL = "Error. ShowHideEnvironmentLayer(), environmentLayer ";
		this.EGLLOLDDPOD();
	}

	// Token: 0x0600821E RID: 33310 RVA: 0x00003E52 File Offset: 0x00002052
	private void ICGODEGOKHO()
	{
	}

	// Token: 0x0600821F RID: 33311 RVA: 0x00003E52 File Offset: 0x00002052
	private void CIKDHMIJLOA()
	{
	}

	// Token: 0x06008220 RID: 33312 RVA: 0x00392114 File Offset: 0x00390314
	private bool HEIJKFGAEOP()
	{
		string str = KDCJJBLGCBH.EHBBFMCILPC.HHONCLBBHPG((int)this.passType);
		string[] array = new string[8];
		array[1] = "";
		array[1] = "analogglitch20_2";
		array[7] = "p";
		array[7] = "doublerewardbody";
		string[] array2 = array;
		for (int i = 0; i < array2.Length; i++)
		{
			OCBIOPOEENJ ocbiopoeenj = CJEKEHDEBLM.BBGECIKOICE().IJLAPHFKPMH(str + array2[i]);
			if (ocbiopoeenj == null)
			{
				return false;
			}
			if (i != 0 && 1 != ocbiopoeenj.PPACJFFFBFB.MOBKGNBCIJF())
			{
				return true;
			}
			OBHDGKFFICI productData = PurchaseManagerBridge.IDMLJFBNHML().CMJKNNFMCBM().GetProductData(str + array2[i]);
			if (productData == null || (productData.HOCIKJAGDMC == null && productData.MDFDHOKJOPB == null))
			{
				return true;
			}
		}
		return true;
	}

	// Token: 0x06008221 RID: 33313 RVA: 0x003921C6 File Offset: 0x003903C6
	private void OnDisable()
	{
		AOBJLALDBAA.EHBBFMCILPC.MANLHALMCIH("OnPurchasingViewLeave", new UnityAction(this.OnPurchasingViewLeave));
		AOBJLALDBAA.EHBBFMCILPC.MANLHALMCIH("OnApplicationFocusBasicSyncSuccess", new UnityAction(this.OnApplicationFocusBasicSyncSuccess));
	}

	// Token: 0x06008222 RID: 33314 RVA: 0x00392200 File Offset: 0x00390400
	private void CKEPMCHGIGF()
	{
		FirebaseAnalyticsManager firebaseAnalyticsManager = FirebaseAnalyticsManager.ANCEKPONIFI();
		bool acidpckhlmo = true;
		string poblfhphabp = AGEHCPDNBFD.srvIssueHit.ToString();
		string gjknlaaefdc = FFPHBMFGCNN.wofPaid.ToString();
		string str = ((BGHLMGPPCNN)117).ToString();
		int num = (int)this.passType;
		firebaseAnalyticsManager.JIAAMJPKOCE(acidpckhlmo, poblfhphabp, gjknlaaefdc, str + num.ToString(), false, true);
		this.EJJANHEGJNA("uid");
	}

	// Token: 0x06008223 RID: 33315 RVA: 0x00392268 File Offset: 0x00390468
	public void BFLNFOCBMKN()
	{
		this.KPCNAKIOMNF();
	}

	// Token: 0x06008224 RID: 33316 RVA: 0x00392270 File Offset: 0x00390470
	private void MBOBHKEMEEC()
	{
		this.NBKLLONFGAL = "</i>";
		if (this.DLOKNDCILMK() && this.HEIJKFGAEOP())
		{
			CommonUserInterface.IKNOFBFMPGA().EHKIPAGEOMI(CCOJBMMKNAP.AEELGGPEJCC().JCDFHKDNEDH("assetbundlepurchasingview"), CCOJBMMKNAP.BFHKGNBFHCH().BDGPNPNIAPA("VideoGlitches.VideoGlitch"), this.JEGDBNHDJIO(1, "AssetProfileData.GetCharSprite(): anthologyIndex ("), this.JEGDBNHDJIO(4, "OnAllCollectableCardsDownloadFailed"), this.ANFNMGKFLGH(2, "shnts"), this.JEGDBNHDJIO(-128, "freepasssuccess"), new UnityAction(this.JAHJPEDMMAC), new UnityAction(this.PADLMDDHDJI), new UnityAction(this.GCMDJDHDLBB), new UnityAction(this.OFKCBKKOMMP), new UnityAction(this.ICGODEGOKHO), DFGILFBGPLN.popupIncentAd0Failed, 528f, -86);
			return;
		}
		this.FGFPDFLDIJH();
	}

	// Token: 0x06008225 RID: 33317 RVA: 0x00392344 File Offset: 0x00390544
	private string KHMDNADPHCA(int OPMDCABAFPH, string DOOBBHKGJEE)
	{
		if (DOOBBHKGJEE.Length == 0)
		{
			return CCOJBMMKNAP.LMCCLMFGEBD().PPALCPINPLK("" + OPMDCABAFPH.ToString());
		}
		string newValue = (this.passType == KHBLFKIDHPH.goldGamePass) ? KBOJLHAJPCP.JGLFACJDKAG : KBOJLHAJPCP.MJIIKJPAKCB;
		return "acliffbw22" + CCOJBMMKNAP.DBFFFOMCLKM().PGKBCNBAOJN("").Replace(" carries an active video layer", newValue).Replace("cardoptionsloadingthemebody", DOOBBHKGJEE).Replace("areyousurerestartepbody1newcur", OPMDCABAFPH.ToString()) + "none";
	}

	// Token: 0x06008226 RID: 33318 RVA: 0x003923D0 File Offset: 0x003905D0
	private void CHGBGMCDJEH()
	{
		string text = "BackendOperationsManager.QueueRequestSaveChapterSnapshots, exception while initializing RSACryptoServiceProvider:";
		if (this.passType == KHBLFKIDHPH.premiumGamePass)
		{
			text = CCOJBMMKNAP.ONCPHEEJLOP().PPALCPINPLK("0" + KDCJJBLGCBH.EHBBFMCILPC.ODDPKODCIBB(KDCJJBLGCBH.EHBBFMCILPC.HHONCLBBHPG((int)this.passType), (DAMCJCDKOJK)(-17), 0 == AKLFPGMDKLA.EHBBFMCILPC.DCIPLNCLIMF).ToString());
		}
		else if (this.passType == KHBLFKIDHPH.premiumGamePass)
		{
			text = CCOJBMMKNAP.BIAEAOMHBMM().IPEIONBNIPH("tutorgametitle" + KDCJJBLGCBH.EHBBFMCILPC.AAGICPKFIKC(KDCJJBLGCBH.EHBBFMCILPC.HHONCLBBHPG((int)this.passType), (DAMCJCDKOJK)(-116), 1 == AKLFPGMDKLA.EHBBFMCILPC.DCIPLNCLIMF).ToString());
		}
		text = text.Replace("Account.ResolveSaveSlots(): out sto:", DPGJIJGOCIC.CEOBDMGAKNL(KDCJJBLGCBH.EHBBFMCILPC.GCPFCGGBDKK((int)this.passType)) + CCOJBMMKNAP.GIOAFDDKKHI().OBDCPLLLGBB("OnPopupRemoveAdsManagerDismissed"));
		text = text.Replace("", DPGJIJGOCIC.CEOBDMGAKNL(KDCJJBLGCBH.EHBBFMCILPC.ADLOIIMBHAG((int)this.passType)) + CCOJBMMKNAP.KNKGCDDMLDP().IKMNGFIDCLM(""));
		text = text.Replace("OnAvatarScreenAssetBundleFolderInitializeSuccess", KDCJJBLGCBH.EHBBFMCILPC.EHJGCKLOOAP((int)this.passType).ToString() ?? "mfs");
		text = text.Replace("$", "StoryStepDialogPlayerCharacter.RemoveChoiceAtEnd - _choicesToRemove is <= 0." + KDCJJBLGCBH.EHBBFMCILPC.LHECDOFJNOF((int)this.passType).ToString() + "");
		text = text.Replace("tm", KBOJLHAJPCP.BGMADCKNKAD);
		text = text.Replace("OnBackendValidateTransactionSuccess", KDCJJBLGCBH.EHBBFMCILPC.PLOMCENKKFD((int)this.passType).ToString() ?? "fdvp");
		if (AKLFPGMDKLA.EHBBFMCILPC.OJKHMNEIGPF == HGCFJKCOKPM.bright)
		{
			text = text.Replace("yes", "MORPH_WIPE");
		}
		if (text.Length < 185)
		{
			CommonUserInterface.EHBBFMCILPC.ShowGenericPopup(CCOJBMMKNAP.EAIAHCBAIEJ().MEPECBDCOLG(""), text, CCOJBMMKNAP.HJGDLOOHNLO().MEPECBDCOLG("/"), (DFGILFBGPLN)(-57), 1889f, -23);
			return;
		}
		if (text.Length < 104)
		{
			CommonUserInterface.IKNOFBFMPGA().ShowGenericPopup(CCOJBMMKNAP.KNKGCDDMLDP().BDGPNPNIAPA("epos"), text, CCOJBMMKNAP.CEGAOMEEFBE().JHNELLJFBGC("YYY"), (DFGILFBGPLN)(-7), 948f, -95);
			return;
		}
		if (text.Length < 88)
		{
			CommonUserInterface.IKNOFBFMPGA().ShowGenericPopup(CCOJBMMKNAP.HJGDLOOHNLO().BGELFMIOBCL("dor"), text, CCOJBMMKNAP.KFAABHHGOPO().GLEFEKBDHNK("p"), (DFGILFBGPLN)113, 1660f, -109);
			return;
		}
		if (text.Length < 67)
		{
			CommonUserInterface.EHBBFMCILPC.NFBMHHPIGFA(CCOJBMMKNAP.LMCCLMFGEBD().DNILNCLIHAP("noisedigital_2"), text, CCOJBMMKNAP.PMABBOJDELF().BDGPNPNIAPA("%"), DFGILFBGPLN.popupIncentAd0Success, 1303f, -55);
			return;
		}
		if (text.Length < -125)
		{
			CommonUserInterface.IKNOFBFMPGA().NFBMHHPIGFA(CCOJBMMKNAP.BFHKGNBFHCH().JLBEIFLLBLO("af_subscribe"), text, CCOJBMMKNAP.DLGLFACMHPG().PGKBCNBAOJN("OnBackendRequestBreakCardSuccess"), DFGILFBGPLN.screenCutscene, 807f, -59);
			return;
		}
		CommonUserInterface.EHBBFMCILPC.ShowGenericPopup(CCOJBMMKNAP.MLFAGAAJJEM().GGPHHLGPMPA(CCOJBMMKNAP.EAIAHCBAIEJ().JCDFHKDNEDH("OnCutsceneViewShow")), text, CCOJBMMKNAP.MPCBJEIMACA().OBDCPLLLGBB("actsh"), DFGILFBGPLN.popupCdnUpdateAvailable, 1252f, 78);
	}

	// Token: 0x06008227 RID: 33319 RVA: 0x0039272C File Offset: 0x0039092C
	public string GetLocalizedCostData(string IOONFLFOIAH)
	{
		OBHDGKFFICI productData = PurchaseManagerBridge.EHBBFMCILPC.GetPurchaseManager().GetProductData(IOONFLFOIAH);
		OCBIOPOEENJ ocbiopoeenj = CJEKEHDEBLM.EHBBFMCILPC.PDJKPFLHFLO(IOONFLFOIAH);
		if (productData == null || ocbiopoeenj == null)
		{
			DPGJIJGOCIC.ANOPFDLPKGC("PassThumbnail.GetLocalizedCostData() - productData is null.");
			return "";
		}
		if (ocbiopoeenj.OKGPIEEOKBM())
		{
			return ocbiopoeenj.FNJCEPLEPBH();
		}
		return "USD " + ocbiopoeenj.DMODNDCLGEJ;
	}

	// Token: 0x06008228 RID: 33320 RVA: 0x00003E52 File Offset: 0x00002052
	private void AAKJEPGFJGK()
	{
	}

	// Token: 0x06008229 RID: 33321 RVA: 0x0039278C File Offset: 0x0039098C
	public void FPHHNBJGPKK()
	{
		string text = "ok";
		if (this.passType == KHBLFKIDHPH.premiumGamePass)
		{
			text = CCOJBMMKNAP.KNKGCDDMLDP().MEPECBDCOLG("badges" + KDCJJBLGCBH.EHBBFMCILPC.AAGICPKFIKC(KDCJJBLGCBH.EHBBFMCILPC.HHONCLBBHPG((int)this.passType), (DAMCJCDKOJK)(-119), 0 == AKLFPGMDKLA.EHBBFMCILPC.DCIPLNCLIMF).ToString());
		}
		else if (this.passType == KHBLFKIDHPH.premiumGamePass)
		{
			text = CCOJBMMKNAP.PMABBOJDELF().FCOCLEHKLDJ("OnChoiceExtendedEnvironmentChange" + KDCJJBLGCBH.EHBBFMCILPC.AAGICPKFIKC(KDCJJBLGCBH.EHBBFMCILPC.HHONCLBBHPG((int)this.passType), (DAMCJCDKOJK)(-83), 1 == AKLFPGMDKLA.EHBBFMCILPC.DCIPLNCLIMF).ToString());
		}
		if (AKLFPGMDKLA.EHBBFMCILPC.OJKHMNEIGPF == HGCFJKCOKPM.bright)
		{
			text = text.Replace("", "retry");
		}
		if (text.Length < -72)
		{
			CommonUserInterface.IKNOFBFMPGA().PEBIFCENHAL(CCOJBMMKNAP.OEPENBHJAHO().OBDCPLLLGBB("*"), text, CCOJBMMKNAP.DBFFFOMCLKM().BDGPNPNIAPA("cardoptionsloadingthemereset"), new UnityAction(this.CHGBGMCDJEH), (DFGILFBGPLN)(-64), 897f, 98);
			return;
		}
		if (text.Length < 42)
		{
			CommonUserInterface.EHBBFMCILPC.BGJFCEEDGFJ(CCOJBMMKNAP.BFHKGNBFHCH().BGELFMIOBCL("OnGamePassExpire"), text, CCOJBMMKNAP.COKDLDOAACJ().HDIPNMFHIEJ("PlayerCharacterManager.UpdateComponentLink() - pt1 is null"), new UnityAction(this.LHPAFFGMMMA), DFGILFBGPLN.popupBackendErrorSignIn, 1941f, 120);
			return;
		}
		if (text.Length < -5)
		{
			CommonUserInterface.EHBBFMCILPC.PEBIFCENHAL(CCOJBMMKNAP.FEEDGKCJBLE().GGPHHLGPMPA(""), text, CCOJBMMKNAP.PMABBOJDELF().GGPHHLGPMPA(""), new UnityAction(this.LHPAFFGMMMA), (DFGILFBGPLN)(-52), 780f, 71);
			return;
		}
		CommonUserInterface.IKNOFBFMPGA().ShowGenericPopupOneOverride(CCOJBMMKNAP.NIOJNOFGIJO().BGELFMIOBCL(""), text, CCOJBMMKNAP.BBGECIKOICE().PKNHKGMNCIP(") is outside range"), new UnityAction(this.LHPAFFGMMMA), (DFGILFBGPLN)(-64), 1624f, -15);
	}

	// Token: 0x0600822A RID: 33322 RVA: 0x00392984 File Offset: 0x00390B84
	public void AJIEDDJBHCM()
	{
		if (this.passType == KHBLFKIDHPH.premiumGamePass || this.passType == KHBLFKIDHPH.premiumGamePass)
		{
			this.PAEOKLKMOEP = ODLJHDIGLGO.ABLHBECBPJK(KDCJJBLGCBH.EHBBFMCILPC.HHONCLBBHPG((int)this.passType));
			this.KOGAKMNPPCK = ODLJHDIGLGO.BCGOGCFOHJK(CLHDENLPOFP.gamePass, false);
			if (this.PAEOKLKMOEP == null)
			{
				string text;
				if (this.passType == KHBLFKIDHPH.premiumGamePass)
				{
					text = CCOJBMMKNAP.HFAKOKBHCGH().PPALCPINPLK("ok" + KDCJJBLGCBH.EHBBFMCILPC.AAGICPKFIKC(KDCJJBLGCBH.EHBBFMCILPC.HHONCLBBHPG((int)this.passType), (DAMCJCDKOJK)62, 1 == AKLFPGMDKLA.EHBBFMCILPC.DCIPLNCLIMF).ToString());
				}
				else
				{
					text = CCOJBMMKNAP.HEDIEIICOOG().FCOCLEHKLDJ("cdnerror" + KDCJJBLGCBH.EHBBFMCILPC.ODDPKODCIBB(KDCJJBLGCBH.EHBBFMCILPC.HHONCLBBHPG((int)this.passType), (DAMCJCDKOJK)92, 1 == AKLFPGMDKLA.EHBBFMCILPC.DCIPLNCLIMF).ToString());
				}
				if (0 == AKLFPGMDKLA.EHBBFMCILPC.DCIPLNCLIMF && KDCJJBLGCBH.EHBBFMCILPC.IPJIIHLDMPK(KDCJJBLGCBH.EHBBFMCILPC.HHONCLBBHPG((int)this.passType), DAMCJCDKOJK.gpbpStartDiscount))
				{
					text = text.Replace(" group(s) planned from ", KBOJLHAJPCP.PGBPLBKHPOM);
					text = text.Replace("OnBackendGetDropChancesSuccess2", "focusavatarloungeicon" + KDCJJBLGCBH.EHBBFMCILPC.ODDPKODCIBB(KDCJJBLGCBH.EHBBFMCILPC.HHONCLBBHPG((int)this.passType), DAMCJCDKOJK.gpbpChoicesCount, 0 == AKLFPGMDKLA.EHBBFMCILPC.DCIPLNCLIMF).ToString() + "OnAppleLoginFailed" + KBOJLHAJPCP.DHMPCLBPDIE);
				}
				else
				{
					text = text.Replace("msrc", KBOJLHAJPCP.PGBPLBKHPOM);
					text = text.Replace("frcnt", "OnMissingPreview2CdnFailed" + KDCJJBLGCBH.EHBBFMCILPC.AAGICPKFIKC(KDCJJBLGCBH.EHBBFMCILPC.HHONCLBBHPG((int)this.passType), DAMCJCDKOJK.gpbpStartDiscount, 1 == AKLFPGMDKLA.EHBBFMCILPC.DCIPLNCLIMF).ToString() + "OnApplicationFocusNeedToUpdateCurrency");
				}
				if (1 == AKLFPGMDKLA.EHBBFMCILPC.DCIPLNCLIMF && KDCJJBLGCBH.EHBBFMCILPC.IPJIIHLDMPK(KDCJJBLGCBH.EHBBFMCILPC.HHONCLBBHPG((int)this.passType), DAMCJCDKOJK.gpbpStartDiscount))
				{
					text = text.Replace("OnApplicationFocusBasicSyncSuccess", KBOJLHAJPCP.NJDJMKIIEDG);
					text = text.Replace("<RSAKeyValue><Exponent>AQAB</Exponent><Modulus>", ">" + KDCJJBLGCBH.EHBBFMCILPC.AAGICPKFIKC(KDCJJBLGCBH.EHBBFMCILPC.HHONCLBBHPG((int)this.passType), DAMCJCDKOJK.gpbpEndDiscountHof, 0 == AKLFPGMDKLA.EHBBFMCILPC.DCIPLNCLIMF).ToString() + "OnBackendPublishSketchSuccess" + KBOJLHAJPCP.DHMPCLBPDIE);
				}
				else
				{
					text = text.Replace("OnStoryManInTheMiddleAttackDetected", KBOJLHAJPCP.NJDJMKIIEDG);
					text = text.Replace(" not found, trying to return any achievement sprite or null.", "<" + KDCJJBLGCBH.EHBBFMCILPC.AAGICPKFIKC(KDCJJBLGCBH.EHBBFMCILPC.HHONCLBBHPG((int)this.passType), DAMCJCDKOJK.gpbpStartDiscount, 0 == AKLFPGMDKLA.EHBBFMCILPC.DCIPLNCLIMF).ToString() + "envlsrw");
				}
				if (1 == AKLFPGMDKLA.EHBBFMCILPC.DCIPLNCLIMF && KDCJJBLGCBH.EHBBFMCILPC.IPJIIHLDMPK(KDCJJBLGCBH.EHBBFMCILPC.HHONCLBBHPG((int)this.passType), DAMCJCDKOJK.gpbpEndDiscount))
				{
					text = text.Replace("v", KBOJLHAJPCP.LPBLANJMJIF);
					text = text.Replace("OnBackendSavePublicProfileException", "emailUnsubscribe" + KDCJJBLGCBH.EHBBFMCILPC.ODDPKODCIBB(KDCJJBLGCBH.EHBBFMCILPC.HHONCLBBHPG((int)this.passType), DAMCJCDKOJK.gpbpDiscountIncrement, 1 == AKLFPGMDKLA.EHBBFMCILPC.DCIPLNCLIMF).ToString() + "There needs to be one active AppleSignInManager script on a GameObject in your scene." + KBOJLHAJPCP.DHMPCLBPDIE);
				}
				else
				{
					text = text.Replace("coverSearchNone", KBOJLHAJPCP.LPBLANJMJIF);
					text = text.Replace(" <i>", "OnChoiceExtendedPlayNewAmbient" + KDCJJBLGCBH.EHBBFMCILPC.ODDPKODCIBB(KDCJJBLGCBH.EHBBFMCILPC.HHONCLBBHPG((int)this.passType), DAMCJCDKOJK.gpbpStartDiscount, 0 == AKLFPGMDKLA.EHBBFMCILPC.DCIPLNCLIMF).ToString() + "suttl");
				}
				text = text.Replace("rain", KBOJLHAJPCP.OINDDHFMCFL);
				text = text.Replace("\n\n<align=\"center\"><size=100%><alpha=#88>", KBOJLHAJPCP.GOCPBNAAIIB);
				text = text.Replace("Romance Club (Steam ", DPGJIJGOCIC.CEOBDMGAKNL(KDCJJBLGCBH.EHBBFMCILPC.GCPFCGGBDKK((int)this.passType)) + CCOJBMMKNAP.PMABBOJDELF().GLEFEKBDHNK(">"));
				text = text.Replace("", DPGJIJGOCIC.CEOBDMGAKNL(KDCJJBLGCBH.EHBBFMCILPC.ADLOIIMBHAG((int)this.passType)) + CCOJBMMKNAP.BFHKGNBFHCH().FCOCLEHKLDJ("cind"));
				text = text.Replace("newuseraddrequest0", KDCJJBLGCBH.EHBBFMCILPC.FPDBBHOPFKN((int)this.passType).ToString() ?? "StringToBackendRequestType() unknown value.");
				text = text.Replace("hintsaving", KDCJJBLGCBH.EHBBFMCILPC.LHECDOFJNOF((int)this.passType).ToString() + "yes");
				text = text.Replace("Error. FadeSrc(), layer ", KBOJLHAJPCP.BGMADCKNKAD + KDCJJBLGCBH.EHBBFMCILPC.PLOMCENKKFD((int)this.passType).ToString());
				if (this.passType == KHBLFKIDHPH.premiumGamePass)
				{
					text = text.Replace("af_revenue", KBOJLHAJPCP.MJIIKJPAKCB ?? "");
				}
				else if (this.passType == KHBLFKIDHPH.premiumGamePass)
				{
					text = text.Replace(" ", KBOJLHAJPCP.JGLFACJDKAG ?? "rwt");
				}
				this.textDescription.SetText(text, true);
				this.textDescription.text = text;
				this.buttonAction.gameObject.SetActive(true);
				this.NCNKAFAEJPI();
				text = CCOJBMMKNAP.AEELGGPEJCC().PPALCPINPLK("{sp}");
				text = text.Replace("importanttitle", this.GetLocalizedCostData(KDCJJBLGCBH.EHBBFMCILPC.HHONCLBBHPG((int)this.passType)));
				this.textButtonAction.SetText(text, true);
				this.textButtonAction.text = text;
				this.textTimer.gameObject.SetActive(false);
				this.textFooter.gameObject.SetActive(false);
			}
			else
			{
				string text;
				if (this.passType == KHBLFKIDHPH.premiumGamePass)
				{
					text = CCOJBMMKNAP.PMABBOJDELF().OBDCPLLLGBB("MonitorAndKillInfiniteRequest() - lastCallbackObj is null!" + KDCJJBLGCBH.EHBBFMCILPC.ODDPKODCIBB(KDCJJBLGCBH.EHBBFMCILPC.HHONCLBBHPG((int)this.passType), (DAMCJCDKOJK)(-32), 0 == AKLFPGMDKLA.EHBBFMCILPC.DCIPLNCLIMF).ToString());
				}
				else
				{
					text = CCOJBMMKNAP.EHBBFMCILPC.JHNELLJFBGC("][" + KDCJJBLGCBH.EHBBFMCILPC.ODDPKODCIBB(KDCJJBLGCBH.EHBBFMCILPC.HHONCLBBHPG((int)this.passType), (DAMCJCDKOJK)(-80), 0 == AKLFPGMDKLA.EHBBFMCILPC.DCIPLNCLIMF).ToString());
				}
				if (1 == AKLFPGMDKLA.EHBBFMCILPC.DCIPLNCLIMF && KDCJJBLGCBH.EHBBFMCILPC.IPJIIHLDMPK(KDCJJBLGCBH.EHBBFMCILPC.HHONCLBBHPG((int)this.passType), DAMCJCDKOJK.gpbpStartDiscount))
				{
					text = text.Replace("OnAllCollectableCardsDownloadFailed", KBOJLHAJPCP.PGBPLBKHPOM);
					text = text.Replace("{ ", "OnLoadingThemeSelectorFolderFailed" + this.PAEOKLKMOEP.COEFNFJMBDG.ToString() + "CameraEnvironmentsFront" + KBOJLHAJPCP.DHMPCLBPDIE);
				}
				else
				{
					text = text.Replace("@", KBOJLHAJPCP.PGBPLBKHPOM);
					text = text.Replace("loff", "sfxsparklesbundles" + this.PAEOKLKMOEP.COEFNFJMBDG.ToString() + "");
				}
				if (0 == AKLFPGMDKLA.EHBBFMCILPC.DCIPLNCLIMF && KDCJJBLGCBH.EHBBFMCILPC.IPJIIHLDMPK(KDCJJBLGCBH.EHBBFMCILPC.HHONCLBBHPG((int)this.passType), DAMCJCDKOJK.gpbpDiscountIncrementHof))
				{
					text = text.Replace("spld", KBOJLHAJPCP.NJDJMKIIEDG);
					text = text.Replace("Starting non-parallel download:", "@" + this.PAEOKLKMOEP.HCBEGPENNLN.ToString() + "" + KBOJLHAJPCP.DHMPCLBPDIE);
				}
				else
				{
					text = text.Replace("AssetProfileData.GetCutsceneSprite(): could not resolve anthologyIndex of storyIndex (", KBOJLHAJPCP.NJDJMKIIEDG);
					text = text.Replace("PlayerCharacterManager.UpdateComponentLink() - invalid custom hierarchy for ", "OnBackendGetFriendMessagingHistoryException" + this.PAEOKLKMOEP.HCBEGPENNLN.ToString() + "varConditionLocked");
				}
				if (0 == AKLFPGMDKLA.EHBBFMCILPC.DCIPLNCLIMF && KDCJJBLGCBH.EHBBFMCILPC.IPJIIHLDMPK(KDCJJBLGCBH.EHBBFMCILPC.HHONCLBBHPG((int)this.passType), DAMCJCDKOJK.gpbpChoicesCountHof))
				{
					text = text.Replace("<i>", KBOJLHAJPCP.LPBLANJMJIF);
					text = text.Replace("", "cardschar" + this.PAEOKLKMOEP.HEGNAMGJLNP.ToString() + "..." + KBOJLHAJPCP.DHMPCLBPDIE);
				}
				else
				{
					text = text.Replace("OnLiveProfileThemeBackgroundCdnSuccess", KBOJLHAJPCP.LPBLANJMJIF);
					text = text.Replace("skinshopfilterowned", "p" + this.PAEOKLKMOEP.HEGNAMGJLNP.ToString() + " npc(s) with a player-side dialog offset");
				}
				text = text.Replace("", KBOJLHAJPCP.OINDDHFMCFL);
				text = text.Replace("af_subscribe", KBOJLHAJPCP.GOCPBNAAIIB);
				text = text.Replace("skinshopinfosumbonus", DPGJIJGOCIC.CEOBDMGAKNL(KDCJJBLGCBH.EHBBFMCILPC.GCPFCGGBDKK((int)this.passType)) + CCOJBMMKNAP.ONCPHEEJLOP().OBDCPLLLGBB("ip-api.com"));
				text = text.Replace("holdontitle", DPGJIJGOCIC.CEOBDMGAKNL(KDCJJBLGCBH.EHBBFMCILPC.ADLOIIMBHAG((int)this.passType)) + CCOJBMMKNAP.CEGAOMEEFBE().IKMNGFIDCLM("spinsdoubleoddshint"));
				text = text.Replace("avtssnap1", KDCJJBLGCBH.EHBBFMCILPC.FPDBBHOPFKN((int)this.passType).ToString() ?? "energyhinttitle");
				text = text.Replace("-", KDCJJBLGCBH.EHBBFMCILPC.LHECDOFJNOF((int)this.passType).ToString() + "StorySave.UpdateChapterSnapshotGuid(), chapterSnapshots/chapterSnapshotsGuids length unsync");
				text = text.Replace("", KBOJLHAJPCP.BGMADCKNKAD + KDCJJBLGCBH.EHBBFMCILPC.PLOMCENKKFD((int)this.passType).ToString());
				if (this.passType == KHBLFKIDHPH.premiumGamePass)
				{
					text = text.Replace(" ", KBOJLHAJPCP.MJIIKJPAKCB ?? ")");
				}
				else if (this.passType == KHBLFKIDHPH.premiumGamePass)
				{
					text = text.Replace("@", KBOJLHAJPCP.JGLFACJDKAG ?? "spld");
				}
				this.textDescription.SetText(text, true);
				this.textDescription.text = text;
				text = CCOJBMMKNAP.AEELGGPEJCC().PPALCPINPLK("OnLobbyStartFireworksEffect");
				text = text.Replace("", this.GBLINJGJOCN(KDCJJBLGCBH.EHBBFMCILPC.HHONCLBBHPG((int)this.passType)));
				this.textButtonAction.SetText(text, true);
				this.textButtonAction.text = text;
				if (this.PAEOKLKMOEP.ALFGPLALKCN())
				{
					this.buttonAction.gameObject.SetActive(true);
					this.GCIECEAOAJJ();
					this.textTimer.gameObject.SetActive(true);
					this.textFooter.gameObject.SetActive(true);
					if (this.PAEOKLKMOEP.ONFNKBHMNAM())
					{
						text = CCOJBMMKNAP.HEDIEIICOOG().GLEFEKBDHNK("");
						text = text.Replace("OnBackendGetSketchesBalanceException", DPGJIJGOCIC.MHIPDHHNDHI(this.PAEOKLKMOEP.PMJOEMNJJMC()));
						this.textFooter.SetText(text, true);
						this.textFooter.text = text;
					}
					else if (this.PAEOKLKMOEP.AOKGNDDMFCB())
					{
						text = CCOJBMMKNAP.BIAEAOMHBMM().OGKGHLHHAAI("chtopn");
						text = text.Replace("", DPGJIJGOCIC.MHIPDHHNDHI(this.PAEOKLKMOEP.OGJHKOKNJCN()));
						this.textFooter.SetText(text, false);
						this.textFooter.text = text;
					}
				}
				else
				{
					this.buttonAction.gameObject.SetActive(false);
					this.DOLPMMAFMEP();
					this.textTimer.gameObject.SetActive(true);
					this.textFooter.gameObject.SetActive(false);
				}
			}
		}
		this.CPGLEJIBNEP = PassThumbnail.CBOKJGNCEKE + 1810f;
		this.Update();
	}

	// Token: 0x0600822B RID: 33323 RVA: 0x003934CE File Offset: 0x003916CE
	private string ANFNMGKFLGH(int OPMDCABAFPH, string ABFNOGAEIGH)
	{
		return this.HMEOICAKMPL(OPMDCABAFPH, this.GetLocalizedCostData(KDCJJBLGCBH.EHBBFMCILPC.HHONCLBBHPG((int)this.passType) + ABFNOGAEIGH));
	}

	// Token: 0x0600822C RID: 33324 RVA: 0x003934F4 File Offset: 0x003916F4
	public void ABMCIJMCMBP()
	{
		string text = "";
		if (this.passType == KHBLFKIDHPH.premiumGamePass)
		{
			text = CCOJBMMKNAP.KLAKLFCOMJC().PGKBCNBAOJN("OnFriendsPopupAddToFavClick" + KDCJJBLGCBH.EHBBFMCILPC.AAGICPKFIKC(KDCJJBLGCBH.EHBBFMCILPC.HHONCLBBHPG((int)this.passType), (DAMCJCDKOJK)63, 1 == AKLFPGMDKLA.EHBBFMCILPC.DCIPLNCLIMF).ToString());
		}
		else if (this.passType == KHBLFKIDHPH.goldGamePass)
		{
			text = CCOJBMMKNAP.LMCCLMFGEBD().PPALCPINPLK("ok" + KDCJJBLGCBH.EHBBFMCILPC.AAGICPKFIKC(KDCJJBLGCBH.EHBBFMCILPC.HHONCLBBHPG((int)this.passType), (DAMCJCDKOJK)(-38), 0 == AKLFPGMDKLA.EHBBFMCILPC.DCIPLNCLIMF).ToString());
		}
		if (AKLFPGMDKLA.EHBBFMCILPC.OJKHMNEIGPF == HGCFJKCOKPM.bright)
		{
			text = text.Replace("-", "sku");
		}
		if (text.Length < -64)
		{
			CommonUserInterface.EHBBFMCILPC.ShowGenericPopupOneOverride(CCOJBMMKNAP.MPCBJEIMACA().GGPHHLGPMPA("player"), text, CCOJBMMKNAP.KNKGCDDMLDP().JHNELLJFBGC("teal"), new UnityAction(this.MPBHJHJIHIM), (DFGILFBGPLN)(-53), 525f, -115);
			return;
		}
		if (text.Length < 41)
		{
			CommonUserInterface.IKNOFBFMPGA().ShowGenericPopupOneOverride(CCOJBMMKNAP.DBFFFOMCLKM().JLBEIFLLBLO("Asset bundle load operation failed during parallel mode."), text, CCOJBMMKNAP.HJGDLOOHNLO().HDIPNMFHIEJ(""), new UnityAction(this.MPBHJHJIHIM), (DFGILFBGPLN)111, 966f, 74);
			return;
		}
		if (text.Length < 41)
		{
			CommonUserInterface.EHBBFMCILPC.PEBIFCENHAL(CCOJBMMKNAP.BBGECIKOICE().GLEFEKBDHNK("clst"), text, CCOJBMMKNAP.PLJMLDOCPNM().OGKGHLHHAAI("p"), new UnityAction(this.ENDOIPDEDDM), (DFGILFBGPLN)(-127), 1107f, 78);
			return;
		}
		CommonUserInterface.EHBBFMCILPC.BGJFCEEDGFJ(CCOJBMMKNAP.LMCCLMFGEBD().OHLNGCKIACD("errortitle"), text, CCOJBMMKNAP.CPCOODCFDDP().JCDFHKDNEDH("StoriesSearchBalance - root key '"), new UnityAction(this.CHGBGMCDJEH), DFGILFBGPLN.popupIncentAd3Failed, 335f, -80);
	}

	// Token: 0x0600822D RID: 33325 RVA: 0x003936E9 File Offset: 0x003918E9
	public void KHBHNLAHNJA()
	{
		this.UpdateComponents();
	}

	// Token: 0x0600822E RID: 33326 RVA: 0x00003E52 File Offset: 0x00002052
	public void NCDCKGHBIIH()
	{
	}

	// Token: 0x0600822F RID: 33327 RVA: 0x003936F4 File Offset: 0x003918F4
	private void ELNAJPGOCAG()
	{
		FirebaseAnalyticsManager instance = FirebaseAnalyticsManager.EHBBFMCILPC;
		bool acidpckhlmo = true;
		string poblfhphabp = ((AGEHCPDNBFD)45).ToString();
		string gjknlaaefdc = ((FFPHBMFGCNN)(-91)).ToString();
		string str = ((BGHLMGPPCNN)120).ToString();
		int num = (int)this.passType;
		instance.LKONPEEDKNF(acidpckhlmo, poblfhphabp, gjknlaaefdc, str + num.ToString(), false, false);
		this.NBKLLONFGAL = "OnBackendGetIncentRewardAdException";
		this.NMLEGBBKJDH();
	}

	// Token: 0x06008230 RID: 33328 RVA: 0x00393764 File Offset: 0x00391964
	private void IGLFNCJKKMF()
	{
		if (this.HFEOHIHBKKA)
		{
			if (this.buttonAction.gameObject.activeSelf)
			{
				this.textDescription.GetComponent<RectTransform>().OEOKGDKPKGL(559f);
				this.HFEOHIHBKKA = false;
				return;
			}
		}
		else if (!this.buttonAction.gameObject.activeSelf)
		{
			this.textDescription.GetComponent<RectTransform>().OEOKGDKPKGL(1760f);
			this.HFEOHIHBKKA = true;
		}
	}

	// Token: 0x06008231 RID: 33329 RVA: 0x003937D8 File Offset: 0x003919D8
	private bool FFMFECJDBIP()
	{
		string str = KDCJJBLGCBH.EHBBFMCILPC.HHONCLBBHPG((int)this.passType);
		string[] array = new string[5];
		array[1] = "no";
		array[0] = "_DispTex";
		array[0] = "abskd";
		array[1] = "body";
		string[] array2 = array;
		for (int i = 0; i < array2.Length; i++)
		{
			OCBIOPOEENJ ocbiopoeenj = CJEKEHDEBLM.KBNLANLMNCN().ICBJCNKKGPJ(str + array2[i]);
			if (ocbiopoeenj == null)
			{
				return true;
			}
			if (i != 0 && 1 != ocbiopoeenj.PPACJFFFBFB.BADNAGEMINF())
			{
				return false;
			}
			OBHDGKFFICI productData = PurchaseManagerBridge.EHBBFMCILPC.FDIIEFGBEAG().GetProductData(str + array2[i]);
			if (productData == null || (productData.HOCIKJAGDMC == null && productData.MDFDHOKJOPB == null))
			{
				return true;
			}
		}
		return false;
	}

	// Token: 0x06008232 RID: 33330 RVA: 0x0039388C File Offset: 0x00391A8C
	private void FDKHBOOOILP()
	{
		FirebaseAnalyticsManager firebaseAnalyticsManager = FirebaseAnalyticsManager.HJGDLOOHNLO();
		bool acidpckhlmo = true;
		string poblfhphabp = ((AGEHCPDNBFD)125).ToString();
		string gjknlaaefdc = ((FFPHBMFGCNN)(-19)).ToString();
		string str = BGHLMGPPCNN.d1LobbyOfrC2.ToString();
		int num = (int)this.passType;
		firebaseAnalyticsManager.LMCJKLHOHJC(acidpckhlmo, poblfhphabp, gjknlaaefdc, str + num.ToString(), true, false);
		this.NBKLLONFGAL = "PurchaseManagerXiaomi.StartPurchase(): Not initialized.";
		this.CPJIEAAKFMA();
	}

	// Token: 0x06008233 RID: 33331 RVA: 0x003938FC File Offset: 0x00391AFC
	private void AHGFLOFBIGM(string ABFNOGAEIGH)
	{
		if (this.passType == KHBLFKIDHPH.premiumGamePass || this.passType == KHBLFKIDHPH.goldGamePass)
		{
			OCBIOPOEENJ ocbiopoeenj = CJEKEHDEBLM.KBNLANLMNCN().LIGHNGCMJJL(KDCJJBLGCBH.EHBBFMCILPC.HHONCLBBHPG((int)this.passType) + ABFNOGAEIGH);
			if (ocbiopoeenj != null)
			{
				string text = ocbiopoeenj.BIKJFCLHPBK() + " " + AKLFPGMDKLA.EHBBFMCILPC.EEHGLPEIIHD;
				ProductThumbnailManager.lastAccessedProductWebLink = text;
				AOBJLALDBAA.KKPFOJMAONG().CIGLHCJDDPI("ok", 342f);
				CommonUserInterface.IKNOFBFMPGA().DPJBIGPDLMB(text, 8);
				return;
			}
			DPGJIJGOCIC.ANOPFDLPKGC("prof" + ABFNOGAEIGH + "c");
		}
	}

	// Token: 0x06008234 RID: 33332 RVA: 0x00393998 File Offset: 0x00391B98
	public string GBLINJGJOCN(string IOONFLFOIAH)
	{
		OBHDGKFFICI productData = PurchaseManagerBridge.LMCCLMFGEBD().FDIIEFGBEAG().GetProductData(IOONFLFOIAH);
		OCBIOPOEENJ ocbiopoeenj = CJEKEHDEBLM.AGANFKKBPFO().HBLMGBCMBHN(IOONFLFOIAH);
		if (productData == null || ocbiopoeenj == null)
		{
			DPGJIJGOCIC.ANOPFDLPKGC(".");
			return ">";
		}
		if (ocbiopoeenj.OKGPIEEOKBM())
		{
			return ocbiopoeenj.FNJCEPLEPBH();
		}
		return "themewelcome" + ocbiopoeenj.DMODNDCLGEJ;
	}

	// Token: 0x06008235 RID: 33333 RVA: 0x003939F8 File Offset: 0x00391BF8
	private void FIIMDIKHIHG()
	{
		this.DPKMHNPNOJH = false;
		this.CPGLEJIBNEP = PassThumbnail.CBOKJGNCEKE + 524f;
		this.COCKJEOMPLH();
		AOBJLALDBAA.CEGAOMEEFBE().EFKNEJFLGED("love", new UnityAction(this.PALEKINFNAK));
		AOBJLALDBAA.CEGAOMEEFBE().PEFKJOKLEDL("", new UnityAction(this.OnApplicationFocusBasicSyncSuccess));
	}

	// Token: 0x06008236 RID: 33334 RVA: 0x00003E52 File Offset: 0x00002052
	private void KDHJKIJKBMN()
	{
	}

	// Token: 0x06008237 RID: 33335 RVA: 0x00393A5C File Offset: 0x00391C5C
	private void LOHBLNNJOBM()
	{
		FirebaseAnalyticsManager instance = FirebaseAnalyticsManager.EHBBFMCILPC;
		bool acidpckhlmo = false;
		string poblfhphabp = AGEHCPDNBFD.gpDur.ToString();
		string gjknlaaefdc = FFPHBMFGCNN.durPickWeb.ToString();
		string str = BGHLMGPPCNN.dur3m.ToString();
		int num = (int)this.passType;
		instance.LogEvent(acidpckhlmo, poblfhphabp, gjknlaaefdc, str + num.ToString(), false, false);
		this.FJNABPPFCKB("a_web");
	}

	// Token: 0x06008238 RID: 33336 RVA: 0x00393AC4 File Offset: 0x00391CC4
	private void LLOMJBOENOI()
	{
		FirebaseAnalyticsManager firebaseAnalyticsManager = FirebaseAnalyticsManager.HJGDLOOHNLO();
		bool acidpckhlmo = true;
		string poblfhphabp = ((AGEHCPDNBFD)107).ToString();
		string gjknlaaefdc = ((FFPHBMFGCNN)(-56)).ToString();
		string str = ((BGHLMGPPCNN)115).ToString();
		int num = (int)this.passType;
		firebaseAnalyticsManager.LKONPEEDKNF(acidpckhlmo, poblfhphabp, gjknlaaefdc, str + num.ToString(), true, true);
		this.NBKLLONFGAL = "@SD";
		this.EGLLOLDDPOD();
	}

	// Token: 0x06008239 RID: 33337 RVA: 0x00393B32 File Offset: 0x00391D32
	private bool NILFIKNCFAP()
	{
		return LanguageManager.EHBBFMCILPC.MLOLBFBODHD() == CEIBHCNNIDC.en && GeoLocationManager.NHMHNIFIOCO() && !KDCJJBLGCBH.EHBBFMCILPC.POGBNANIKCA();
	}

	// Token: 0x0600823B RID: 33339 RVA: 0x00393B6C File Offset: 0x00391D6C
	private void MFDFHCOMMCH()
	{
		this.NBKLLONFGAL = "PopIfOnly ";
		if (this.DLOKNDCILMK() && this.OOJHFDCMJIL())
		{
			CommonUserInterface.EHBBFMCILPC.EHKIPAGEOMI(CCOJBMMKNAP.HJGDLOOHNLO().FIENAKIHNOM("\u00a0​"), CCOJBMMKNAP.COKDLDOAACJ().GLEFEKBDHNK(""), this.MPIEIAPCCGC(0, "varConditionLockedValue"), this.JEGDBNHDJIO(4, "HTTP fail: "), this.JEGDBNHDJIO(0, "lightmodebtn0"), this.IDOLCGOKGAO(49, "franchises"), new UnityAction(this.CEFAJCOJMFN), new UnityAction(this.FONNEOANDLJ), new UnityAction(this.MHDHMDEKAPJ), new UnityAction(this.JEJNIIPOLIN), new UnityAction(this.AAKJEPGFJGK), DFGILFBGPLN.popupStoryRestart, 1161f, -119);
			return;
		}
		this.CPJIEAAKFMA();
	}

	// Token: 0x0600823C RID: 33340 RVA: 0x00003E52 File Offset: 0x00002052
	public void ICHAOBIKOGH()
	{
	}

	// Token: 0x0600823D RID: 33341 RVA: 0x00393C40 File Offset: 0x00391E40
	private void OFKCBKKOMMP()
	{
		FirebaseAnalyticsManager instance = FirebaseAnalyticsManager.EHBBFMCILPC;
		bool acidpckhlmo = false;
		string poblfhphabp = AGEHCPDNBFD.gpDur.ToString();
		string gjknlaaefdc = FFPHBMFGCNN.durPickStore.ToString();
		string str = BGHLMGPPCNN.dur12m.ToString();
		int num = (int)this.passType;
		instance.LogEvent(acidpckhlmo, poblfhphabp, gjknlaaefdc, str + num.ToString(), false, false);
		this.NBKLLONFGAL = "c";
		this.CPJIEAAKFMA();
	}

	// Token: 0x0600823E RID: 33342 RVA: 0x00393CB0 File Offset: 0x00391EB0
	private void FONNEOANDLJ()
	{
		FirebaseAnalyticsManager firebaseAnalyticsManager = FirebaseAnalyticsManager.DEALKJPEMMH();
		bool acidpckhlmo = true;
		string poblfhphabp = ((AGEHCPDNBFD)98).ToString();
		string gjknlaaefdc = ((FFPHBMFGCNN)(-1)).ToString();
		string str = BGHLMGPPCNN.postsup.ToString();
		int num = (int)this.passType;
		firebaseAnalyticsManager.AAIABAKHLAH(acidpckhlmo, poblfhphabp, gjknlaaefdc, str + num.ToString(), true, true);
		this.NBKLLONFGAL = "gft";
		this.FGFPDFLDIJH();
	}

	// Token: 0x0600823F RID: 33343 RVA: 0x00393D20 File Offset: 0x00391F20
	private void EAIBBJLBHLL(string ABFNOGAEIGH)
	{
		if (this.passType == KHBLFKIDHPH.premiumGamePass || this.passType == KHBLFKIDHPH.goldGamePass)
		{
			AOBJLALDBAA.NMGMNAKLLMI().EGELHPJBAIC("splash", 1441f);
			CommonUserInterface.IKNOFBFMPGA().GetPurchasingViewManager().CGDKCOLDBGD(KDCJJBLGCBH.EHBBFMCILPC.HHONCLBBHPG((int)this.passType) + ABFNOGAEIGH, true);
		}
	}

	// Token: 0x06008240 RID: 33344 RVA: 0x00393D78 File Offset: 0x00391F78
	private void JAHJPEDMMAC()
	{
		FirebaseAnalyticsManager firebaseAnalyticsManager = FirebaseAnalyticsManager.JMDJBFAEHBM();
		bool acidpckhlmo = true;
		string poblfhphabp = ((AGEHCPDNBFD)(-79)).ToString();
		string gjknlaaefdc = ((FFPHBMFGCNN)(-11)).ToString();
		string str = BGHLMGPPCNN.d1CdnSt.ToString();
		int num = (int)this.passType;
		firebaseAnalyticsManager.JIAAMJPKOCE(acidpckhlmo, poblfhphabp, gjknlaaefdc, str + num.ToString(), true, true);
		this.NBKLLONFGAL = "notgenuinecopy";
		this.FGFPDFLDIJH();
	}

	// Token: 0x06008241 RID: 33345 RVA: 0x00393DE8 File Offset: 0x00391FE8
	private void PADLMDDHDJI()
	{
		FirebaseAnalyticsManager instance = FirebaseAnalyticsManager.EHBBFMCILPC;
		bool acidpckhlmo = false;
		string poblfhphabp = AGEHCPDNBFD.gpDur.ToString();
		string gjknlaaefdc = FFPHBMFGCNN.durPickStore.ToString();
		string str = BGHLMGPPCNN.dur3m.ToString();
		int num = (int)this.passType;
		instance.LogEvent(acidpckhlmo, poblfhphabp, gjknlaaefdc, str + num.ToString(), false, false);
		this.NBKLLONFGAL = "a";
		this.CPJIEAAKFMA();
	}

	// Token: 0x06008242 RID: 33346 RVA: 0x00393E58 File Offset: 0x00392058
	private void FNPLJECDPCP()
	{
		if (this.HFEOHIHBKKA)
		{
			if (this.buttonAction.gameObject.activeSelf)
			{
				this.textDescription.GetComponent<RectTransform>().OEOKGDKPKGL(1584f);
				this.HFEOHIHBKKA = false;
				return;
			}
		}
		else if (!this.buttonAction.gameObject.activeSelf)
		{
			this.textDescription.GetComponent<RectTransform>().OEOKGDKPKGL(340f);
			this.HFEOHIHBKKA = false;
		}
	}

	// Token: 0x06008243 RID: 33347 RVA: 0x00393ECC File Offset: 0x003920CC
	public void HGIOGABIMCO()
	{
		this.PAEOKLKMOEP = ODLJHDIGLGO.BHCAMPAJEOK(KDCJJBLGCBH.EHBBFMCILPC.HHONCLBBHPG((int)this.passType));
		this.KOGAKMNPPCK = ODLJHDIGLGO.BCGOGCFOHJK(CLHDENLPOFP.gamePass, true);
		if (this.KOGAKMNPPCK == null || !this.KOGAKMNPPCK.BOGONHCIPOJ() || this.PAEOKLKMOEP == this.KOGAKMNPPCK)
		{
			this.GOCAMKNOCGP();
			return;
		}
		if (this.passType > (KHBLFKIDHPH)this.KOGAKMNPPCK.LLLJOBODOAL)
		{
			CommonUserInterface.EHBBFMCILPC.ShowGenericPopupWithTwoButtonsAndCloseOverride(CCOJBMMKNAP.APGODIBBPOD().BGELFMIOBCL("no"), CCOJBMMKNAP.KLAKLFCOMJC().HIPJILDCHJC("OnLoungePremiumChoiceSuccess"), CCOJBMMKNAP.CEGAOMEEFBE().IPEIONBNIPH("llosd"), CCOJBMMKNAP.PEBMGCKFNAO().PKNHKGMNCIP("OnUpdateSocialEventsCounter"), new UnityAction(this.MPPKOEJNMNF), new UnityAction(this.AAKJEPGFJGK), new UnityAction(this.JBICKFCMBEH), DFGILFBGPLN.popupIncentAd2Success, 1069f, 121);
			return;
		}
		CommonUserInterface.EHBBFMCILPC.ShowGenericPopup(CCOJBMMKNAP.OBOOKJPGBJN().HIPJILDCHJC("<b>"), CCOJBMMKNAP.MLFAGAAJJEM().PGKBCNBAOJN("_Speed"), CCOJBMMKNAP.PKEINLPIAEH().FCOCLEHKLDJ("myprofilewhatis"), (DFGILFBGPLN)(-29), 64f, -78);
	}

	// Token: 0x06008244 RID: 33348 RVA: 0x00394000 File Offset: 0x00392200
	public void KPCNAKIOMNF()
	{
		if (this.passType == KHBLFKIDHPH.premiumGamePass || this.passType == KHBLFKIDHPH.goldGamePass)
		{
			this.PAEOKLKMOEP = ODLJHDIGLGO.DBJFIIBMGLH(KDCJJBLGCBH.EHBBFMCILPC.HHONCLBBHPG((int)this.passType));
			this.KOGAKMNPPCK = ODLJHDIGLGO.EEJHIEBIPPM(CLHDENLPOFP.eventPass, true);
			if (this.PAEOKLKMOEP == null)
			{
				string text;
				if (this.passType == KHBLFKIDHPH.premiumGamePass)
				{
					text = CCOJBMMKNAP.BFHKGNBFHCH().PGKBCNBAOJN("sac" + KDCJJBLGCBH.EHBBFMCILPC.ODDPKODCIBB(KDCJJBLGCBH.EHBBFMCILPC.HHONCLBBHPG((int)this.passType), (DAMCJCDKOJK)81, 0 == AKLFPGMDKLA.EHBBFMCILPC.DCIPLNCLIMF).ToString());
				}
				else
				{
					text = CCOJBMMKNAP.BIAEAOMHBMM().DNILNCLIHAP("uid" + KDCJJBLGCBH.EHBBFMCILPC.AAGICPKFIKC(KDCJJBLGCBH.EHBBFMCILPC.HHONCLBBHPG((int)this.passType), (DAMCJCDKOJK)(-71), 1 == AKLFPGMDKLA.EHBBFMCILPC.DCIPLNCLIMF).ToString());
				}
				if (1 == AKLFPGMDKLA.EHBBFMCILPC.DCIPLNCLIMF && KDCJJBLGCBH.EHBBFMCILPC.IPJIIHLDMPK(KDCJJBLGCBH.EHBBFMCILPC.HHONCLBBHPG((int)this.passType), DAMCJCDKOJK.gpbpChoicesCount))
				{
					text = text.Replace(" ", KBOJLHAJPCP.PGBPLBKHPOM);
					text = text.Replace("aind", "Starting parallel download:" + KDCJJBLGCBH.EHBBFMCILPC.AAGICPKFIKC(KDCJJBLGCBH.EHBBFMCILPC.HHONCLBBHPG((int)this.passType), DAMCJCDKOJK.gpbpStartDiscount, 0 == AKLFPGMDKLA.EHBBFMCILPC.DCIPLNCLIMF).ToString() + "YourStory/FlagCloth" + KBOJLHAJPCP.DHMPCLBPDIE);
				}
				else
				{
					text = text.Replace("%", KBOJLHAJPCP.PGBPLBKHPOM);
					text = text.Replace(", cleaning failed cache entries: ", "owned" + KDCJJBLGCBH.EHBBFMCILPC.AAGICPKFIKC(KDCJJBLGCBH.EHBBFMCILPC.HHONCLBBHPG((int)this.passType), DAMCJCDKOJK.gpbpStartDiscount, 0 == AKLFPGMDKLA.EHBBFMCILPC.DCIPLNCLIMF).ToString() + "OnBackendUpdateFriendsDataSuccess");
				}
				if (0 == AKLFPGMDKLA.EHBBFMCILPC.DCIPLNCLIMF && KDCJJBLGCBH.EHBBFMCILPC.IPJIIHLDMPK(KDCJJBLGCBH.EHBBFMCILPC.HHONCLBBHPG((int)this.passType), DAMCJCDKOJK.gpbpStartDiscount))
				{
					text = text.Replace("", KBOJLHAJPCP.NJDJMKIIEDG);
					text = text.Replace("liveprofilethemethumb", "chaptersnapshotsmissingbody" + KDCJJBLGCBH.EHBBFMCILPC.AAGICPKFIKC(KDCJJBLGCBH.EHBBFMCILPC.HHONCLBBHPG((int)this.passType), DAMCJCDKOJK.gpbpStartDiscountHof, 0 == AKLFPGMDKLA.EHBBFMCILPC.DCIPLNCLIMF).ToString() + "var" + KBOJLHAJPCP.DHMPCLBPDIE);
				}
				else
				{
					text = text.Replace("emsv", KBOJLHAJPCP.NJDJMKIIEDG);
					text = text.Replace("0.000", "" + KDCJJBLGCBH.EHBBFMCILPC.ODDPKODCIBB(KDCJJBLGCBH.EHBBFMCILPC.HHONCLBBHPG((int)this.passType), DAMCJCDKOJK.gpbpDiscountIncrement, 0 == AKLFPGMDKLA.EHBBFMCILPC.DCIPLNCLIMF).ToString() + "<size=80%><i>");
				}
				if (0 == AKLFPGMDKLA.EHBBFMCILPC.DCIPLNCLIMF && KDCJJBLGCBH.EHBBFMCILPC.IPJIIHLDMPK(KDCJJBLGCBH.EHBBFMCILPC.HHONCLBBHPG((int)this.passType), DAMCJCDKOJK.gpbpStartDiscount))
				{
					text = text.Replace("ert", KBOJLHAJPCP.LPBLANJMJIF);
					text = text.Replace("e1ct", "" + KDCJJBLGCBH.EHBBFMCILPC.ODDPKODCIBB(KDCJJBLGCBH.EHBBFMCILPC.HHONCLBBHPG((int)this.passType), DAMCJCDKOJK.gpbpChoicesCountHof, 1 == AKLFPGMDKLA.EHBBFMCILPC.DCIPLNCLIMF).ToString() + "importanttitle" + KBOJLHAJPCP.DHMPCLBPDIE);
				}
				else
				{
					text = text.Replace(")", KBOJLHAJPCP.LPBLANJMJIF);
					text = text.Replace("", "OnSkinShopCardSelected" + KDCJJBLGCBH.EHBBFMCILPC.AAGICPKFIKC(KDCJJBLGCBH.EHBBFMCILPC.HHONCLBBHPG((int)this.passType), DAMCJCDKOJK.gpbpEndDiscount, 0 == AKLFPGMDKLA.EHBBFMCILPC.DCIPLNCLIMF).ToString() + "");
				}
				text = text.Replace("af_purchase", KBOJLHAJPCP.OINDDHFMCFL);
				text = text.Replace("%20", KBOJLHAJPCP.GOCPBNAAIIB);
				text = text.Replace("/", DPGJIJGOCIC.CEOBDMGAKNL(KDCJJBLGCBH.EHBBFMCILPC.GCPFCGGBDKK((int)this.passType)) + CCOJBMMKNAP.CEGAOMEEFBE().OGKGHLHHAAI("REMOVEMAPPINGINFO"));
				text = text.Replace("var", DPGJIJGOCIC.CEOBDMGAKNL(KDCJJBLGCBH.EHBBFMCILPC.IFHKCMLMLHI((int)this.passType)) + CCOJBMMKNAP.DLGLFACMHPG().PPALCPINPLK("FilterScrollMoveSmooth"));
				text = text.Replace("OnBackendGetPublicProfileProfileItemSuccess", KDCJJBLGCBH.EHBBFMCILPC.EHJGCKLOOAP((int)this.passType).ToString() ?? "");
				text = text.Replace("anthologiestitle", KDCJJBLGCBH.EHBBFMCILPC.LHECDOFJNOF((int)this.passType).ToString() + " ");
				text = text.Replace("amb", KBOJLHAJPCP.BGMADCKNKAD + KDCJJBLGCBH.EHBBFMCILPC.PLOMCENKKFD((int)this.passType).ToString());
				if (this.passType == KHBLFKIDHPH.premiumGamePass)
				{
					text = text.Replace("", KBOJLHAJPCP.MJIIKJPAKCB ?? "PlayerCharacterManager.Update() - exception raised:");
				}
				else if (this.passType == KHBLFKIDHPH.premiumGamePass)
				{
					text = text.Replace("", KBOJLHAJPCP.JGLFACJDKAG ?? "seasoncompletedesc");
				}
				this.textDescription.SetText(text, true);
				this.textDescription.text = text;
				this.buttonAction.gameObject.SetActive(false);
				this.HOKPKJBAFMP();
				text = CCOJBMMKNAP.HJGDLOOHNLO().OGKGHLHHAAI(" ");
				text = text.Replace("", this.GetLocalizedCostData(KDCJJBLGCBH.EHBBFMCILPC.HHONCLBBHPG((int)this.passType)));
				this.textButtonAction.SetText(text, false);
				this.textButtonAction.text = text;
				this.textTimer.gameObject.SetActive(true);
				this.textFooter.gameObject.SetActive(true);
			}
			else
			{
				string text;
				if (this.passType == KHBLFKIDHPH.premiumGamePass)
				{
					text = CCOJBMMKNAP.PMABBOJDELF().JCDFHKDNEDH("e1it" + KDCJJBLGCBH.EHBBFMCILPC.AAGICPKFIKC(KDCJJBLGCBH.EHBBFMCILPC.HHONCLBBHPG((int)this.passType), (DAMCJCDKOJK)(-6), 0 == AKLFPGMDKLA.EHBBFMCILPC.DCIPLNCLIMF).ToString());
				}
				else
				{
					text = CCOJBMMKNAP.COKDLDOAACJ().HIPJILDCHJC("" + KDCJJBLGCBH.EHBBFMCILPC.AAGICPKFIKC(KDCJJBLGCBH.EHBBFMCILPC.HHONCLBBHPG((int)this.passType), (DAMCJCDKOJK)17, 0 == AKLFPGMDKLA.EHBBFMCILPC.DCIPLNCLIMF).ToString());
				}
				if (0 == AKLFPGMDKLA.EHBBFMCILPC.DCIPLNCLIMF && KDCJJBLGCBH.EHBBFMCILPC.IPJIIHLDMPK(KDCJJBLGCBH.EHBBFMCILPC.HHONCLBBHPG((int)this.passType), DAMCJCDKOJK.gpbpChoicesCount))
				{
					text = text.Replace("skhomelockmsg", KBOJLHAJPCP.PGBPLBKHPOM);
					text = text.Replace("holdontitle", " instead of " + this.PAEOKLKMOEP.COEFNFJMBDG.ToString() + "_not_found" + KBOJLHAJPCP.DHMPCLBPDIE);
				}
				else
				{
					text = text.Replace("socialfriendevents", KBOJLHAJPCP.PGBPLBKHPOM);
					text = text.Replace("Ambigious asset bundle variant chosen because there was no matching active variant: ", "importanttitle" + this.PAEOKLKMOEP.COEFNFJMBDG.ToString() + "rar");
				}
				if (0 == AKLFPGMDKLA.EHBBFMCILPC.DCIPLNCLIMF && KDCJJBLGCBH.EHBBFMCILPC.IPJIIHLDMPK(KDCJJBLGCBH.EHBBFMCILPC.HHONCLBBHPG((int)this.passType), DAMCJCDKOJK.gpbpDiscountIncrement))
				{
					text = text.Replace("\"", KBOJLHAJPCP.NJDJMKIIEDG);
					text = text.Replace("YourStory/FlagShadow", "episode" + this.PAEOKLKMOEP.HCBEGPENNLN.ToString() + "" + KBOJLHAJPCP.DHMPCLBPDIE);
				}
				else
				{
					text = text.Replace("mussplash", KBOJLHAJPCP.NJDJMKIIEDG);
					text = text.Replace("", "Asset bundle assets destroyed:" + this.PAEOKLKMOEP.HCBEGPENNLN.ToString() + "onlineresourcesbody");
				}
				if (1 == AKLFPGMDKLA.EHBBFMCILPC.DCIPLNCLIMF && KDCJJBLGCBH.EHBBFMCILPC.IPJIIHLDMPK(KDCJJBLGCBH.EHBBFMCILPC.HHONCLBBHPG((int)this.passType), DAMCJCDKOJK.gpbpChoicesCount))
				{
					text = text.Replace("SceneLobbyManager2.ComputeStarterTabAvailable() - no starter concept has a name in the text pack explore tab (older text pack bundle?), tab hidden", KBOJLHAJPCP.LPBLANJMJIF);
					text = text.Replace("", "" + this.PAEOKLKMOEP.HEGNAMGJLNP.ToString() + "stat6" + KBOJLHAJPCP.DHMPCLBPDIE);
				}
				else
				{
					text = text.Replace("_AlphaTex", KBOJLHAJPCP.LPBLANJMJIF);
					text = text.Replace("no", "" + this.PAEOKLKMOEP.HEGNAMGJLNP.ToString() + "KKK");
				}
				text = text.Replace("\"", KBOJLHAJPCP.OINDDHFMCFL);
				text = text.Replace("blur", KBOJLHAJPCP.GOCPBNAAIIB);
				text = text.Replace("OnBackendPremiumChoiceException", DPGJIJGOCIC.CEOBDMGAKNL(KDCJJBLGCBH.EHBBFMCILPC.GCPFCGGBDKK((int)this.passType)) + CCOJBMMKNAP.GIOAFDDKKHI().OBDCPLLLGBB("avtssnap"));
				text = text.Replace("s", DPGJIJGOCIC.CEOBDMGAKNL(KDCJJBLGCBH.EHBBFMCILPC.ADLOIIMBHAG((int)this.passType)) + CCOJBMMKNAP.KMNBCEMEBBD().GLEFEKBDHNK("retry"));
				text = text.Replace("", KDCJJBLGCBH.EHBBFMCILPC.HLPACDMEKMK((int)this.passType).ToString() ?? "Mini version preview2 assets loaded:");
				text = text.Replace("abs", KDCJJBLGCBH.EHBBFMCILPC.LHECDOFJNOF((int)this.passType).ToString() + "profilenamelevellong");
				text = text.Replace("%", KBOJLHAJPCP.BGMADCKNKAD + KDCJJBLGCBH.EHBBFMCILPC.PLOMCENKKFD((int)this.passType).ToString());
				if (this.passType == KHBLFKIDHPH.premiumGamePass)
				{
					text = text.Replace("<i>", KBOJLHAJPCP.MJIIKJPAKCB ?? "null");
				}
				else if (this.passType == KHBLFKIDHPH.goldGamePass)
				{
					text = text.Replace("XXX", KBOJLHAJPCP.JGLFACJDKAG ?? "bits");
				}
				this.textDescription.SetText(text, false);
				this.textDescription.text = text;
				text = CCOJBMMKNAP.DBFFFOMCLKM().GGPHHLGPMPA(") > totalOffloadedCounter (");
				text = text.Replace("importanttitle", this.FOHHFBPPLHI(KDCJJBLGCBH.EHBBFMCILPC.HHONCLBBHPG((int)this.passType)));
				this.textButtonAction.SetText(text, false);
				this.textButtonAction.text = text;
				if (this.PAEOKLKMOEP.BOGONHCIPOJ())
				{
					this.buttonAction.gameObject.SetActive(true);
					this.LPIMPCFNBBO();
					this.textTimer.gameObject.SetActive(true);
					this.textFooter.gameObject.SetActive(true);
					if (this.PAEOKLKMOEP.ILBDFPGEHOI())
					{
						text = CCOJBMMKNAP.EAIAHCBAIEJ().FCOCLEHKLDJ("");
						text = text.Replace("left", DPGJIJGOCIC.MHIPDHHNDHI(this.PAEOKLKMOEP.KHLLDJMNNLK()));
						this.textFooter.SetText(text, true);
						this.textFooter.text = text;
					}
					else if (this.PAEOKLKMOEP.LAMBLMLGLAG())
					{
						text = CCOJBMMKNAP.NIOJNOFGIJO().PGKBCNBAOJN("OnLiveProfileThemeBackgroundCdnFailed");
						text = text.Replace("AssetProfileData.GetCharSprite(): anthologyIndexStr is null or empty", DPGJIJGOCIC.AGNLFKBJNMD(this.PAEOKLKMOEP.KNLHMDEEGNB()));
						this.textFooter.SetText(text, true);
						this.textFooter.text = text;
					}
				}
				else
				{
					this.buttonAction.gameObject.SetActive(true);
					this.LPIMPCFNBBO();
					this.textTimer.gameObject.SetActive(false);
					this.textFooter.gameObject.SetActive(true);
				}
			}
		}
		this.CPGLEJIBNEP = PassThumbnail.CBOKJGNCEKE + 1064f;
		this.OBDFIFGJKDC();
	}

	// Token: 0x06008245 RID: 33349 RVA: 0x00394B4C File Offset: 0x00392D4C
	private void FGFPDFLDIJH()
	{
		if (this.passType == KHBLFKIDHPH.premiumGamePass || this.passType == KHBLFKIDHPH.premiumGamePass)
		{
			PurchaseManagerBridge.OOGPALHPNGM().DOMEKEJELKB().Initialize();
			if (LanguageManager.EHBBFMCILPC.NBANPEIHFOJ() == CEIBHCNNIDC.en && GeoLocationManager.NHMHNIFIOCO() && KDCJJBLGCBH.EHBBFMCILPC.POGBNANIKCA())
			{
				this.BNGENDIOMDK();
				return;
			}
			CommonUserInterface.IKNOFBFMPGA().GetFader().PACBMBLIGNN(new TweenCallback(this.MGLLADMBEKH));
		}
	}

	// Token: 0x06008246 RID: 33350 RVA: 0x00394BBC File Offset: 0x00392DBC
	public string HAPFPBMCPCG(string IOONFLFOIAH)
	{
		OBHDGKFFICI productData = PurchaseManagerBridge.EHBBFMCILPC.JNNBFLDOOHM().GetProductData(IOONFLFOIAH);
		OCBIOPOEENJ ocbiopoeenj = CJEKEHDEBLM.APGODIBBPOD().LIGHNGCMJJL(IOONFLFOIAH);
		if (productData == null || ocbiopoeenj == null)
		{
			DPGJIJGOCIC.ANOPFDLPKGC("");
			return "importanttitle";
		}
		if (ocbiopoeenj.PJCIBAKAANH())
		{
			return ocbiopoeenj.PKNNPAMOADM();
		}
		return "AdsManagerLP: Received RewardedVideoOnAdRewardedEvent" + ocbiopoeenj.DMODNDCLGEJ;
	}

	// Token: 0x06008247 RID: 33351 RVA: 0x00394C1C File Offset: 0x00392E1C
	private void CPJIEAAKFMA()
	{
		if (this.passType == KHBLFKIDHPH.premiumGamePass || this.passType == KHBLFKIDHPH.goldGamePass)
		{
			PurchaseManagerBridge.EHBBFMCILPC.GetPurchaseManager().Initialize();
			if (LanguageManager.EHBBFMCILPC.GetSelectedLanguage() == CEIBHCNNIDC.ru && GeoLocationManager.IsRussia() && KDCJJBLGCBH.EHBBFMCILPC.POGBNANIKCA())
			{
				this.PurchaseProductWeb();
				return;
			}
			CommonUserInterface.EHBBFMCILPC.GetFader().FadeIn(new TweenCallback(this.AEKCPCJCBAH));
		}
	}

	// Token: 0x06008248 RID: 33352 RVA: 0x00394C8C File Offset: 0x00392E8C
	private string KFLEDODAAPH(int OPMDCABAFPH, string ABFNOGAEIGH)
	{
		OCBIOPOEENJ ocbiopoeenj = CJEKEHDEBLM.EHBBFMCILPC.PDJKPFLHFLO(KDCJJBLGCBH.EHBBFMCILPC.HHONCLBBHPG((int)this.passType) + ABFNOGAEIGH);
		return this.HMEOICAKMPL(OPMDCABAFPH, (ocbiopoeenj != null) ? ocbiopoeenj.KDPELFOFPBC() : "");
	}

	// Token: 0x06008249 RID: 33353 RVA: 0x00394CD4 File Offset: 0x00392ED4
	private bool DFNGGCDIBNK()
	{
		string str = KDCJJBLGCBH.EHBBFMCILPC.HHONCLBBHPG((int)this.passType);
		string[] array = new string[7];
		array[0] = "  ";
		array[1] = "acliffbw20";
		array[1] = "OOO";
		array[5] = "large";
		string[] array2 = array;
		for (int i = 0; i < array2.Length; i += 0)
		{
			OCBIOPOEENJ ocbiopoeenj = CJEKEHDEBLM.APGODIBBPOD().PDJKPFLHFLO(str + array2[i]);
			if (ocbiopoeenj == null || string.IsNullOrEmpty(ocbiopoeenj.DJJCDNDMAGD()))
			{
				return false;
			}
			if (i != 0 && 1 != ocbiopoeenj.PPACJFFFBFB.BFMPOACOBPN())
			{
				return false;
			}
		}
		return true;
	}

	// Token: 0x0600824A RID: 33354 RVA: 0x00394D64 File Offset: 0x00392F64
	private void ELAIPPMBDMB()
	{
		if (this.passType == KHBLFKIDHPH.premiumGamePass || this.passType == KHBLFKIDHPH.premiumGamePass)
		{
			OCBIOPOEENJ ocbiopoeenj = CJEKEHDEBLM.GIOAFDDKKHI().PCBGLNFIPPK(KDCJJBLGCBH.EHBBFMCILPC.HHONCLBBHPG((int)this.passType));
			if (ocbiopoeenj != null)
			{
				ProductThumbnailManager.lastAccessedProductWebLink = ocbiopoeenj.MBLAIKOOCFH() + "alck" + AKLFPGMDKLA.EHBBFMCILPC.EEHGLPEIIHD;
			}
			if (LanguageManager.EHBBFMCILPC.MLOLBFBODHD() == CEIBHCNNIDC.en && GeoLocationManager.CELPCHNPBHH() && KDCJJBLGCBH.EHBBFMCILPC.EAMJBDKCDPA())
			{
				CommonUserInterface.IKNOFBFMPGA().GetFader().GLCPCAHKFOB(null);
				this.GMACILGOFKH();
				return;
			}
			this.LFFGEBEMNCJ(this.NBKLLONFGAL);
		}
	}

	// Token: 0x0600824B RID: 33355 RVA: 0x00394E08 File Offset: 0x00393008
	private void FOMJMNCIEAJ()
	{
		FirebaseAnalyticsManager instance = FirebaseAnalyticsManager.EHBBFMCILPC;
		bool acidpckhlmo = false;
		string poblfhphabp = AGEHCPDNBFD.gpDur.ToString();
		string gjknlaaefdc = FFPHBMFGCNN.durPickWeb.ToString();
		string str = BGHLMGPPCNN.dur1m.ToString();
		int num = (int)this.passType;
		instance.LogEvent(acidpckhlmo, poblfhphabp, gjknlaaefdc, str + num.ToString(), false, false);
		this.FJNABPPFCKB("");
	}

	// Token: 0x0600824C RID: 33356 RVA: 0x00394E70 File Offset: 0x00393070
	private void MGLLADMBEKH()
	{
		if (this.passType == KHBLFKIDHPH.premiumGamePass || this.passType == KHBLFKIDHPH.premiumGamePass)
		{
			OCBIOPOEENJ ocbiopoeenj = CJEKEHDEBLM.EHBBFMCILPC.DOOPGOIBFAN(KDCJJBLGCBH.EHBBFMCILPC.HHONCLBBHPG((int)this.passType));
			if (ocbiopoeenj != null)
			{
				ProductThumbnailManager.lastAccessedProductWebLink = ocbiopoeenj.DJJCDNDMAGD() + "_TimeFrac" + AKLFPGMDKLA.EHBBFMCILPC.EEHGLPEIIHD;
			}
			if (LanguageManager.EHBBFMCILPC.GetSelectedLanguage() == CEIBHCNNIDC.ru && GeoLocationManager.FHINOKNBJPM() && KDCJJBLGCBH.EHBBFMCILPC.POGBNANIKCA())
			{
				CommonUserInterface.IKNOFBFMPGA().GetFader().FadeOut(null);
				this.APPNMKHFACH();
				return;
			}
			this.CLKOENJFFGA(this.NBKLLONFGAL);
		}
	}

	// Token: 0x0600824D RID: 33357 RVA: 0x00394F14 File Offset: 0x00393114
	private bool MDDHKEDFHHG()
	{
		string str = KDCJJBLGCBH.EHBBFMCILPC.HHONCLBBHPG((int)this.passType);
		string[] array = new string[0];
		array[0] = "";
		array[1] = " (http ";
		array[0] = "max";
		array[0] = "SocialStatsUserPublicProfile.SyncCutscenes(): Syncing new cutscene: ";
		string[] array2 = array;
		for (int i = 1; i < array2.Length; i += 0)
		{
			OCBIOPOEENJ ocbiopoeenj = CJEKEHDEBLM.PMABBOJDELF().HCHKAOGEPMG(str + array2[i]);
			if (ocbiopoeenj == null || string.IsNullOrEmpty(ocbiopoeenj.MBLAIKOOCFH()))
			{
				return false;
			}
			if (i != 0 && 0 != ocbiopoeenj.PPACJFFFBFB.GALKFKBPLCK())
			{
				return true;
			}
		}
		return false;
	}

	// Token: 0x0600824E RID: 33358 RVA: 0x00394FA4 File Offset: 0x003931A4
	private void OMIAADCNAPK(string ABFNOGAEIGH)
	{
		if (this.passType == KHBLFKIDHPH.premiumGamePass || this.passType == KHBLFKIDHPH.premiumGamePass)
		{
			OCBIOPOEENJ ocbiopoeenj = CJEKEHDEBLM.NACPAKLINNH().AOAGHIJNFDL(KDCJJBLGCBH.EHBBFMCILPC.HHONCLBBHPG((int)this.passType) + ABFNOGAEIGH);
			if (ocbiopoeenj != null)
			{
				string text = ocbiopoeenj.BIKJFCLHPBK() + "OnLoungePremiumChoiceException" + AKLFPGMDKLA.EHBBFMCILPC.EEHGLPEIIHD;
				ProductThumbnailManager.lastAccessedProductWebLink = text;
				AOBJLALDBAA.EHBBFMCILPC.KGIKHEDLPND("OnBackendRequestFriendRejectException", 1046f);
				CommonUserInterface.EHBBFMCILPC.DPJBIGPDLMB(text, 5);
				return;
			}
			DPGJIJGOCIC.ANOPFDLPKGC("" + ABFNOGAEIGH + "OnAvatarCollectionEdit");
		}
	}

	// Token: 0x0600824F RID: 33359 RVA: 0x00003E52 File Offset: 0x00002052
	private void Start()
	{
	}

	// Token: 0x06008250 RID: 33360 RVA: 0x00395040 File Offset: 0x00393240
	public void GMACILGOFKH()
	{
		if (this.passType == KHBLFKIDHPH.premiumGamePass || this.passType == KHBLFKIDHPH.premiumGamePass)
		{
			if (this.CAAMEFMDNFF())
			{
				CommonUserInterface.IKNOFBFMPGA().JOHIHCPEBPL(CCOJBMMKNAP.BBGECIKOICE().HPOAGPJFHPM("stat4"), CCOJBMMKNAP.DLGLFACMHPG().HIPJILDCHJC("OnGamePassUnlockContinueToPurchasingScreen"), this.DOIHLIOAJDL(1, "Steam"), this.GMMLALCMEOA(6, "socialgiftsendtotitle"), this.GMMLALCMEOA(8, "youreceived"), this.KFLEDODAAPH(93, "ltwt"), new UnityAction(this.FFNHJAHBEKI), new UnityAction(this.LOHBLNNJOBM), new UnityAction(this.BFANMCIKOPP), new UnityAction(this.PJDLMLNFEDM), new UnityAction(this.AAKJEPGFJGK), (DFGILFBGPLN)(-108), 1085f, 25);
				return;
			}
			DPGJIJGOCIC.NFIDPOMCNLP("socialjoinbody");
			this.OMIAADCNAPK("");
		}
	}

	// Token: 0x06008251 RID: 33361 RVA: 0x00003E52 File Offset: 0x00002052
	private void GDLAPPBOOCM()
	{
	}

	// Token: 0x06008252 RID: 33362 RVA: 0x00003E52 File Offset: 0x00002052
	private void JBICKFCMBEH()
	{
	}

	// Token: 0x06008253 RID: 33363 RVA: 0x00395124 File Offset: 0x00393324
	private void EBEAELEGMBC(string ABFNOGAEIGH)
	{
		if (this.passType == KHBLFKIDHPH.premiumGamePass || this.passType == KHBLFKIDHPH.premiumGamePass)
		{
			AOBJLALDBAA.KKPFOJMAONG().KMAGHMCCMPG("per", 646f);
			CommonUserInterface.IKNOFBFMPGA().GetPurchasingViewManager().ShowAndPurchaseProduct(KDCJJBLGCBH.EHBBFMCILPC.HHONCLBBHPG((int)this.passType) + ABFNOGAEIGH, true);
		}
	}

	// Token: 0x06008254 RID: 33364 RVA: 0x0039517C File Offset: 0x0039337C
	public void NCHLINMEHHM()
	{
		this.AJIEDDJBHCM();
	}

	// Token: 0x06008255 RID: 33365 RVA: 0x00003E52 File Offset: 0x00002052
	private void PHHELAPHLOK()
	{
	}

	// Token: 0x06008256 RID: 33366 RVA: 0x00395184 File Offset: 0x00393384
	private bool NJIMOGGEKKG()
	{
		return LanguageManager.EHBBFMCILPC.IEBFINIJAMJ() != CEIBHCNNIDC.en || !GeoLocationManager.CELPCHNPBHH() || KDCJJBLGCBH.EHBBFMCILPC.POGBNANIKCA();
	}

	// Token: 0x06008257 RID: 33367 RVA: 0x003951AC File Offset: 0x003933AC
	public void BLMJHFJDPOF()
	{
		this.PAEOKLKMOEP = ODLJHDIGLGO.CGJJHPNMKIJ(KDCJJBLGCBH.EHBBFMCILPC.HHONCLBBHPG((int)this.passType));
		this.KOGAKMNPPCK = ODLJHDIGLGO.HECMHABJMFO(CLHDENLPOFP.eventPass, true);
		if (this.KOGAKMNPPCK == null || !this.KOGAKMNPPCK.ALFGPLALKCN() || this.PAEOKLKMOEP == this.KOGAKMNPPCK)
		{
			this.GOCAMKNOCGP();
			return;
		}
		if (this.passType > (KHBLFKIDHPH)this.KOGAKMNPPCK.LLLJOBODOAL)
		{
			CommonUserInterface.EHBBFMCILPC.NPIOKKDPALC(CCOJBMMKNAP.DBFFFOMCLKM().IKMNGFIDCLM("sfxtimeoutwarning"), CCOJBMMKNAP.FEEDGKCJBLE().FIENAKIHNOM("-"), CCOJBMMKNAP.OEPENBHJAHO().FCOCLEHKLDJ("@"), CCOJBMMKNAP.KFAABHHGOPO().JCDFHKDNEDH("XXX"), new UnityAction(this.MBOBHKEMEEC), new UnityAction(this.AAKJEPGFJGK), new UnityAction(this.HIAEPAFFHJA), (DFGILFBGPLN)98, 888f, -78);
			return;
		}
		CommonUserInterface.IKNOFBFMPGA().NFBMHHPIGFA(CCOJBMMKNAP.EAIAHCBAIEJ().OGKGHLHHAAI("OnSketchThumbnailEmptyClick"), CCOJBMMKNAP.PMABBOJDELF().IKMNGFIDCLM("OnBackendGetUserSketchesException"), CCOJBMMKNAP.BIAEAOMHBMM().HDIPNMFHIEJ("passhintactivesub"), (DFGILFBGPLN)(-22), 981f, 126);
	}

	// Token: 0x06008258 RID: 33368 RVA: 0x003952E0 File Offset: 0x003934E0
	private void EJJANHEGJNA(string ABFNOGAEIGH)
	{
		if (this.passType == KHBLFKIDHPH.premiumGamePass || this.passType == KHBLFKIDHPH.goldGamePass)
		{
			OCBIOPOEENJ ocbiopoeenj = CJEKEHDEBLM.NACPAKLINNH().PDJKPFLHFLO(KDCJJBLGCBH.EHBBFMCILPC.HHONCLBBHPG((int)this.passType) + ABFNOGAEIGH);
			if (ocbiopoeenj != null)
			{
				string text = ocbiopoeenj.BIKJFCLHPBK() + "ZZZ" + AKLFPGMDKLA.EHBBFMCILPC.EEHGLPEIIHD;
				ProductThumbnailManager.lastAccessedProductWebLink = text;
				AOBJLALDBAA.DBLAIDPICIG().EFBNBFIDEOK("specialcurrencyoptionna", 1591f);
				CommonUserInterface.IKNOFBFMPGA().GIFCDFKBBCN(text, 8);
				return;
			}
			DPGJIJGOCIC.ANOPFDLPKGC("OnFriendsGiftPopulCollectPart1" + ABFNOGAEIGH + "lightmodeintrobody1");
		}
	}

	// Token: 0x06008259 RID: 33369 RVA: 0x0039537C File Offset: 0x0039357C
	public void PurchaseProductWeb()
	{
		if (this.passType == KHBLFKIDHPH.premiumGamePass || this.passType == KHBLFKIDHPH.goldGamePass)
		{
			if (this.CAAMEFMDNFF())
			{
				CommonUserInterface.EHBBFMCILPC.ShowGenericPopupWithFourButtonsInside(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("gamepassdurationtitle"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("gamepassdurationbody"), this.KFLEDODAAPH(1, ""), this.KFLEDODAAPH(3, "a_web"), this.KFLEDODAAPH(6, "b_web"), this.KFLEDODAAPH(12, "c_web"), new UnityAction(this.FOMJMNCIEAJ), new UnityAction(this.LOHBLNNJOBM), new UnityAction(this.MFIHOHCHDGE), new UnityAction(this.PJDLMLNFEDM), new UnityAction(this.ICGODEGOKHO), DFGILFBGPLN.popupGamePassDuration, 0f, 28);
				return;
			}
			DPGJIJGOCIC.NFIDPOMCNLP("PassThumbnail.PurchaseProductWeb(): duration variant rows unavailable, falling back to the base product.");
			this.FJNABPPFCKB("");
		}
	}

	// Token: 0x0600825A RID: 33370 RVA: 0x00395460 File Offset: 0x00393660
	private void AFFLNEBPPJK()
	{
		FirebaseAnalyticsManager firebaseAnalyticsManager = FirebaseAnalyticsManager.DMAAFFFEJGA();
		bool acidpckhlmo = true;
		string poblfhphabp = ((AGEHCPDNBFD)73).ToString();
		string gjknlaaefdc = ((FFPHBMFGCNN)(-126)).ToString();
		string str = BGHLMGPPCNN.subLngLook.ToString();
		int num = (int)this.passType;
		firebaseAnalyticsManager.LMCJKLHOHJC(acidpckhlmo, poblfhphabp, gjknlaaefdc, str + num.ToString(), true, true);
		this.NBKLLONFGAL = "OnBackendUpgradeToGiftCardSuccess";
		this.EGLLOLDDPOD();
	}

	// Token: 0x0600825B RID: 33371 RVA: 0x003954D0 File Offset: 0x003936D0
	private void AHJDDFJCLGI(string ABFNOGAEIGH)
	{
		if (this.passType == KHBLFKIDHPH.premiumGamePass || this.passType == KHBLFKIDHPH.goldGamePass)
		{
			OCBIOPOEENJ ocbiopoeenj = CJEKEHDEBLM.CAAKHBIFGMG().EPNHMLIJCCM(KDCJJBLGCBH.EHBBFMCILPC.HHONCLBBHPG((int)this.passType) + ABFNOGAEIGH);
			if (ocbiopoeenj != null)
			{
				string text = ocbiopoeenj.MBLAIKOOCFH() + "cardsvolchancesmsgtitle" + AKLFPGMDKLA.EHBBFMCILPC.EEHGLPEIIHD;
				ProductThumbnailManager.lastAccessedProductWebLink = text;
				AOBJLALDBAA.CEGAOMEEFBE().DCGCFPHHDDG("direction", 781f);
				CommonUserInterface.IKNOFBFMPGA().ShowPopupOnlineResources(text, 3);
				return;
			}
			DPGJIJGOCIC.ANOPFDLPKGC("_NoiseTex" + ABFNOGAEIGH + "(pad)");
		}
	}

	// Token: 0x0600825C RID: 33372 RVA: 0x0039556C File Offset: 0x0039376C
	private void LHPAFFGMMMA()
	{
		string text = "";
		if (this.passType == KHBLFKIDHPH.premiumGamePass)
		{
			text = CCOJBMMKNAP.PEBMGCKFNAO().JLBEIFLLBLO("$NPCFADEOUT" + KDCJJBLGCBH.EHBBFMCILPC.AAGICPKFIKC(KDCJJBLGCBH.EHBBFMCILPC.HHONCLBBHPG((int)this.passType), (DAMCJCDKOJK)(-42), 1 == AKLFPGMDKLA.EHBBFMCILPC.DCIPLNCLIMF).ToString());
		}
		else if (this.passType == KHBLFKIDHPH.premiumGamePass)
		{
			text = CCOJBMMKNAP.DLGLFACMHPG().MEPECBDCOLG("" + KDCJJBLGCBH.EHBBFMCILPC.ODDPKODCIBB(KDCJJBLGCBH.EHBBFMCILPC.HHONCLBBHPG((int)this.passType), (DAMCJCDKOJK)(-41), 0 == AKLFPGMDKLA.EHBBFMCILPC.DCIPLNCLIMF).ToString());
		}
		text = text.Replace("ZZZ", DPGJIJGOCIC.CEOBDMGAKNL(KDCJJBLGCBH.EHBBFMCILPC.GCPFCGGBDKK((int)this.passType)) + CCOJBMMKNAP.PEBMGCKFNAO().PGKBCNBAOJN(""));
		text = text.Replace("", DPGJIJGOCIC.CEOBDMGAKNL(KDCJJBLGCBH.EHBBFMCILPC.IFHKCMLMLHI((int)this.passType)) + CCOJBMMKNAP.ONCPHEEJLOP().PPALCPINPLK("congratstitle"));
		text = text.Replace("socdnd", KDCJJBLGCBH.EHBBFMCILPC.HLPACDMEKMK((int)this.passType).ToString() ?? "uen");
		text = text.Replace("  ", "OnStoryInterfaceHeaderAutoReadDisable" + KDCJJBLGCBH.EHBBFMCILPC.LHECDOFJNOF((int)this.passType).ToString() + " (");
		text = text.Replace("OnBackendGetPublicProfileException", KBOJLHAJPCP.BGMADCKNKAD);
		text = text.Replace("", KDCJJBLGCBH.EHBBFMCILPC.PLOMCENKKFD((int)this.passType).ToString() ?? "%");
		if (AKLFPGMDKLA.EHBBFMCILPC.OJKHMNEIGPF == HGCFJKCOKPM.bright)
		{
			text = text.Replace("cleancachebody", "story");
		}
		if (text.Length < 182)
		{
			CommonUserInterface.IKNOFBFMPGA().ShowGenericPopup(CCOJBMMKNAP.INKJIBDDMLL().PPALCPINPLK("app42error"), text, CCOJBMMKNAP.KNKGCDDMLDP().HPOAGPJFHPM(""), DFGILFBGPLN.screenStory, 9f, 95);
			return;
		}
		if (text.Length < -142)
		{
			CommonUserInterface.IKNOFBFMPGA().ShowGenericPopup(CCOJBMMKNAP.PEBMGCKFNAO().PPALCPINPLK("sparkles"), text, CCOJBMMKNAP.EHBBFMCILPC.HHLECNIFHCO("There needs to be one active VideoManager script on a GameObject in your scene."), (DFGILFBGPLN)(-116), 865f, 24);
			return;
		}
		if (text.Length < 14)
		{
			CommonUserInterface.EHBBFMCILPC.ShowGenericPopup(CCOJBMMKNAP.ONCPHEEJLOP().OBDCPLLLGBB(" allocatedSlots:"), text, CCOJBMMKNAP.OBOOKJPGBJN().GGPHHLGPMPA("OnAllCollectableCardsDownloadFailed"), (DFGILFBGPLN)(-48), 1f, -112);
			return;
		}
		if (text.Length < 116)
		{
			CommonUserInterface.IKNOFBFMPGA().NFBMHHPIGFA(CCOJBMMKNAP.JINDKPHNLBK().PGKBCNBAOJN("confirmexit"), text, CCOJBMMKNAP.GIOAFDDKKHI().PGKBCNBAOJN("acsv"), (DFGILFBGPLN)(-101), 1160f, 60);
			return;
		}
		if (text.Length < -110)
		{
			CommonUserInterface.EHBBFMCILPC.NFBMHHPIGFA(CCOJBMMKNAP.KLAKLFCOMJC().FCOCLEHKLDJ("steamid"), text, CCOJBMMKNAP.INKJIBDDMLL().HDIPNMFHIEJ("importanttitle"), DFGILFBGPLN.screenTransition, 1151f, -10);
			return;
		}
		CommonUserInterface.IKNOFBFMPGA().ShowGenericPopup(CCOJBMMKNAP.EAIAHCBAIEJ().DNILNCLIHAP(CCOJBMMKNAP.ONCPHEEJLOP().OHLNGCKIACD("OnAvatarScreenAssetsDownloadSuccess")), text, CCOJBMMKNAP.GIOAFDDKKHI().MEPECBDCOLG("Asset bundle load operation failed during parallel mode."), (DFGILFBGPLN)105, 1589f, -83);
	}

	// Token: 0x0600825D RID: 33373 RVA: 0x003958C8 File Offset: 0x00393AC8
	public void OnInfoClick()
	{
		string text = "";
		if (this.passType == KHBLFKIDHPH.premiumGamePass)
		{
			text = CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("passinfobtndesc0X" + KDCJJBLGCBH.EHBBFMCILPC.AAGICPKFIKC(KDCJJBLGCBH.EHBBFMCILPC.HHONCLBBHPG((int)this.passType), DAMCJCDKOJK.gpbpIncentAdMultiplier, 1 == AKLFPGMDKLA.EHBBFMCILPC.DCIPLNCLIMF).ToString());
		}
		else if (this.passType == KHBLFKIDHPH.goldGamePass)
		{
			text = CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("passinfobtndesc1X" + KDCJJBLGCBH.EHBBFMCILPC.AAGICPKFIKC(KDCJJBLGCBH.EHBBFMCILPC.HHONCLBBHPG((int)this.passType), DAMCJCDKOJK.gpbpIncentAdMultiplier, 1 == AKLFPGMDKLA.EHBBFMCILPC.DCIPLNCLIMF).ToString());
		}
		if (AKLFPGMDKLA.EHBBFMCILPC.OJKHMNEIGPF == HGCFJKCOKPM.bright)
		{
			text = text.Replace("ffd496", "23819D");
		}
		if (text.Length < 750)
		{
			CommonUserInterface.EHBBFMCILPC.ShowGenericPopupOneOverride(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("passinfobtntitle"), text, CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("continue"), new UnityAction(this.FNPJCOLHKLJ), DFGILFBGPLN.popupEnergyHint, 0f, 23);
			return;
		}
		if (text.Length < 850)
		{
			CommonUserInterface.EHBBFMCILPC.ShowGenericPopupOneOverride(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("passinfobtntitle"), text, CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("continue"), new UnityAction(this.FNPJCOLHKLJ), DFGILFBGPLN.popupEnergyHint, 0f, 22);
			return;
		}
		if (text.Length < 950)
		{
			CommonUserInterface.EHBBFMCILPC.ShowGenericPopupOneOverride(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("passinfobtntitle"), text, CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("continue"), new UnityAction(this.FNPJCOLHKLJ), DFGILFBGPLN.popupEnergyHint, 0f, 21);
			return;
		}
		CommonUserInterface.EHBBFMCILPC.ShowGenericPopupOneOverride(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("passinfobtntitle"), text, CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("continue"), new UnityAction(this.FNPJCOLHKLJ), DFGILFBGPLN.popupEnergyHint, 0f, 20);
	}

	// Token: 0x0600825E RID: 33374 RVA: 0x00003E52 File Offset: 0x00002052
	private void BMJJACPPHGN()
	{
	}

	// Token: 0x0600825F RID: 33375 RVA: 0x00395AC0 File Offset: 0x00393CC0
	private bool JLKEPPABPNO()
	{
		string str = KDCJJBLGCBH.EHBBFMCILPC.HHONCLBBHPG((int)this.passType);
		string[] array = new string[3];
		array[0] = "";
		array[0] = "";
		array[2] = "id";
		array[8] = "OnCollectableDialogUsed";
		string[] array2 = array;
		for (int i = 0; i < array2.Length; i++)
		{
			OCBIOPOEENJ ocbiopoeenj = CJEKEHDEBLM.CAAKHBIFGMG().IJLAPHFKPMH(str + array2[i]);
			if (ocbiopoeenj == null || string.IsNullOrEmpty(ocbiopoeenj.BIKJFCLHPBK()))
			{
				return true;
			}
			if (i != 0 && 1 != ocbiopoeenj.PPACJFFFBFB.MDJHNAEGCCM())
			{
				return false;
			}
		}
		return true;
	}

	// Token: 0x06008261 RID: 33377 RVA: 0x00395B5C File Offset: 0x00393D5C
	private void HGDILJPLKBM(string ABFNOGAEIGH)
	{
		if (this.passType == KHBLFKIDHPH.premiumGamePass || this.passType == KHBLFKIDHPH.goldGamePass)
		{
			OCBIOPOEENJ ocbiopoeenj = CJEKEHDEBLM.CAAKHBIFGMG().IJLAPHFKPMH(KDCJJBLGCBH.EHBBFMCILPC.HHONCLBBHPG((int)this.passType) + ABFNOGAEIGH);
			if (ocbiopoeenj != null)
			{
				string text = ocbiopoeenj.BIKJFCLHPBK() + "" + AKLFPGMDKLA.EHBBFMCILPC.EEHGLPEIIHD;
				ProductThumbnailManager.lastAccessedProductWebLink = text;
				AOBJLALDBAA.EHBBFMCILPC.CIGLHCJDDPI("blur", 304f);
				CommonUserInterface.EHBBFMCILPC.ShowPopupOnlineResources(text, 0);
				return;
			}
			DPGJIJGOCIC.ANOPFDLPKGC("GeneralBalance.SearchKeyArray() - tempArray is null/length0 for key:" + ABFNOGAEIGH + "ok");
		}
	}

	// Token: 0x06008262 RID: 33378 RVA: 0x00395BF5 File Offset: 0x00393DF5
	private string MPIEIAPCCGC(int OPMDCABAFPH, string ABFNOGAEIGH)
	{
		return this.JMPMBDLFIMH(OPMDCABAFPH, this.GetLocalizedCostData(KDCJJBLGCBH.EHBBFMCILPC.HHONCLBBHPG((int)this.passType) + ABFNOGAEIGH));
	}

	// Token: 0x06008263 RID: 33379 RVA: 0x00395C1C File Offset: 0x00393E1C
	private void MPPKOEJNMNF()
	{
		this.NBKLLONFGAL = "F0";
		if (this.LGOIOCMILMD() && this.OOJHFDCMJIL())
		{
			CommonUserInterface.IKNOFBFMPGA().JOHIHCPEBPL(CCOJBMMKNAP.MLFAGAAJJEM().DNILNCLIHAP("getNpcSkinShopBalance answered without a payload and no cached copy - shop rows unchanged"), CCOJBMMKNAP.BFHKGNBFHCH().HIPJILDCHJC("NEWSAVE: Error: firstAnthologyStoryIndexCache.Instance.GetData() returned null. Retrieving persistent save data is impossible."), this.IDOLCGOKGAO(0, "o"), this.MPIEIAPCCGC(8, "e1it"), this.IDOLCGOKGAO(8, "asv"), this.IDOLCGOKGAO(104, "socialprofilesuspcantuse"), new UnityAction(this.BDDKEABCJOH), new UnityAction(this.FONNEOANDLJ), new UnityAction(this.FDKHBOOOILP), new UnityAction(this.OFKCBKKOMMP), new UnityAction(this.HIAEPAFFHJA), (DFGILFBGPLN)(-23), 1450f, 71);
			return;
		}
		this.NMLEGBBKJDH();
	}

	// Token: 0x06008264 RID: 33380 RVA: 0x0039517C File Offset: 0x0039337C
	public void LDCGMOHDACJ()
	{
		this.AJIEDDJBHCM();
	}

	// Token: 0x06008265 RID: 33381 RVA: 0x00395CF0 File Offset: 0x00393EF0
	private void BFANMCIKOPP()
	{
		FirebaseAnalyticsManager firebaseAnalyticsManager = FirebaseAnalyticsManager.COKDLDOAACJ();
		bool acidpckhlmo = true;
		string poblfhphabp = ((AGEHCPDNBFD)(-120)).ToString();
		string gjknlaaefdc = ((FFPHBMFGCNN)(-99)).ToString();
		string str = ((BGHLMGPPCNN)(-10)).ToString();
		int num = (int)this.passType;
		firebaseAnalyticsManager.LKONPEEDKNF(acidpckhlmo, poblfhphabp, gjknlaaefdc, str + num.ToString(), true, true);
		this.FJNABPPFCKB("");
	}

	// Token: 0x06008266 RID: 33382 RVA: 0x00395D58 File Offset: 0x00393F58
	private void LDFOKKPCEFM()
	{
		this.NBKLLONFGAL = "blur";
		if (this.DLOKNDCILMK() && this.JIBNDKOCHHN())
		{
			CommonUserInterface.IKNOFBFMPGA().ShowGenericPopupWithFourButtonsInside(CCOJBMMKNAP.JMDJPKKOHNI().FCOCLEHKLDJ("yes"), CCOJBMMKNAP.BIAEAOMHBMM().JLBEIFLLBLO("purchaseToken"), this.JEGDBNHDJIO(0, "forcenoloop"), this.MPIEIAPCCGC(5, "skpcut"), this.ANFNMGKFLGH(6, "halloffamecongrats"), this.ANFNMGKFLGH(-62, "Open Web"), new UnityAction(this.BDDKEABCJOH), new UnityAction(this.FONNEOANDLJ), new UnityAction(this.FDKHBOOOILP), new UnityAction(this.LLOMJBOENOI), new UnityAction(this.HIAEPAFFHJA), (DFGILFBGPLN)124, 1157f, 62);
			return;
		}
		this.CPJIEAAKFMA();
	}

	// Token: 0x06008267 RID: 33383 RVA: 0x00395E2C File Offset: 0x0039402C
	public void APPNMKHFACH()
	{
		if (this.passType == KHBLFKIDHPH.premiumGamePass || this.passType == KHBLFKIDHPH.premiumGamePass)
		{
			if (this.PJONDFNAMKD())
			{
				CommonUserInterface.IKNOFBFMPGA().ShowGenericPopupWithFourButtonsInside(CCOJBMMKNAP.PEBMGCKFNAO().DNILNCLIHAP("OnPopupPasswordInputEndEdit"), CCOJBMMKNAP.KMNBCEMEBBD().HHLECNIFHCO("continue"), this.KFLEDODAAPH(0, "OnStoryChoiceClick"), this.DOIHLIOAJDL(1, "YYY"), this.GMMLALCMEOA(0, ", shopcost:"), this.KFLEDODAAPH(120, " ("), new UnityAction(this.IPJHLANPCKM), new UnityAction(this.LOHBLNNJOBM), new UnityAction(this.BFANMCIKOPP), new UnityAction(this.MPOPHBMKEJF), new UnityAction(this.ICGODEGOKHO), (DFGILFBGPLN)(-107), 1485f, 58);
				return;
			}
			DPGJIJGOCIC.CMGOAFDBAOH("copyright");
			this.EJJANHEGJNA("");
		}
	}

	// Token: 0x06008268 RID: 33384 RVA: 0x00395F10 File Offset: 0x00394110
	private void Update()
	{
		this.CPGLEJIBNEP += Time.deltaTime;
		if (this.CPGLEJIBNEP > PassThumbnail.CBOKJGNCEKE)
		{
			if ((this.passType == KHBLFKIDHPH.premiumGamePass || this.passType == KHBLFKIDHPH.goldGamePass) && !App42Manager.EHBBFMCILPC.IsBusy())
			{
				this.PAEOKLKMOEP = ODLJHDIGLGO.BCGIONNIFIA(KDCJJBLGCBH.EHBBFMCILPC.HHONCLBBHPG((int)this.passType));
				this.KOGAKMNPPCK = ODLJHDIGLGO.MNALIKIMKFC(CLHDENLPOFP.gamePass, true);
				if (this.PAEOKLKMOEP != null)
				{
					if (this.PAEOKLKMOEP.ALFGPLALKCN())
					{
						if (this.KOGAKMNPPCK == this.PAEOKLKMOEP)
						{
							if (!this.stateActive.gameObject.activeSelf)
							{
								this.stateActive.gameObject.SetActive(true);
							}
							if (this.stateExpired.gameObject.activeSelf)
							{
								this.stateExpired.gameObject.SetActive(false);
							}
							if (this.statePaused.gameObject.activeSelf)
							{
								this.statePaused.gameObject.SetActive(false);
							}
							if (this.buttonAction.gameObject.activeSelf)
							{
								this.buttonAction.gameObject.SetActive(false);
								this.OADECAIKAJP();
							}
							if (!this.textTimer.gameObject.activeSelf)
							{
								this.textTimer.gameObject.SetActive(true);
							}
							if (!this.textFooter.gameObject.activeSelf)
							{
								this.textFooter.gameObject.SetActive(true);
							}
							this.textTimer.SetText(KBOJLHAJPCP.HMNMIDGDCEA + DPGJIJGOCIC.DMENNJGBMBH(this.PAEOKLKMOEP.FHHLFACIIDF()), true);
							this.DPKMHNPNOJH = true;
							if (!App42Manager.EHBBFMCILPC.IsBusy() && (float)this.PAEOKLKMOEP.FHHLFACIIDF() <= 0.001f && (float)this.PAEOKLKMOEP.FOIOENCOCEE() > 1f)
							{
								BackendOperationsManager.EHBBFMCILPC.ForceRefreshExpiredSubscriptions();
								CommonUserInterface.EHBBFMCILPC.ShowConnectingAnimationTopWithHint(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("serversync"), 128);
								BackendOperationsManager.EHBBFMCILPC.RequestBasicSync("OnApplicationFocusBasicSyncSuccess", "OnApplicationFocusBasicSyncEcxeption", false);
							}
						}
						else
						{
							if (this.stateActive.gameObject.activeSelf)
							{
								this.stateActive.gameObject.SetActive(false);
							}
							if (this.stateExpired.gameObject.activeSelf)
							{
								this.stateExpired.gameObject.SetActive(false);
							}
							if (!this.statePaused.gameObject.activeSelf)
							{
								this.statePaused.gameObject.SetActive(true);
							}
							if (this.buttonAction.gameObject.activeSelf)
							{
								this.buttonAction.gameObject.SetActive(false);
								this.OADECAIKAJP();
							}
							if (this.textTimer.gameObject.activeSelf)
							{
								this.textTimer.gameObject.SetActive(false);
							}
							if (this.textFooter.gameObject.activeSelf)
							{
								this.textFooter.gameObject.SetActive(false);
							}
							this.DPKMHNPNOJH = false;
						}
					}
					else
					{
						if (this.stateActive.gameObject.activeSelf)
						{
							this.stateActive.gameObject.SetActive(false);
						}
						if (!this.stateExpired.gameObject.activeSelf)
						{
							this.stateExpired.gameObject.SetActive(true);
						}
						if (this.statePaused.gameObject.activeSelf)
						{
							this.statePaused.gameObject.SetActive(false);
						}
						if (!this.buttonAction.gameObject.activeSelf)
						{
							this.buttonAction.gameObject.SetActive(true);
							this.OADECAIKAJP();
						}
						if (this.textTimer.gameObject.activeSelf)
						{
							this.textTimer.gameObject.SetActive(false);
						}
						if (this.textFooter.gameObject.activeSelf)
						{
							this.textFooter.gameObject.SetActive(false);
						}
						if (this.DPKMHNPNOJH && !App42Manager.EHBBFMCILPC.IsBusy())
						{
							this.textFooter.gameObject.SetActive(false);
							BackendOperationsManager.EHBBFMCILPC.ForceRefreshExpiredSubscriptions();
							CommonUserInterface.EHBBFMCILPC.ShowConnectingAnimationTopWithHint(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("serversync"), 128);
							BackendOperationsManager.EHBBFMCILPC.RequestBasicSync("OnApplicationFocusBasicSyncSuccess", "OnApplicationFocusBasicSyncEcxeption", false);
						}
						this.DPKMHNPNOJH = false;
					}
				}
			}
			this.CPGLEJIBNEP = 0f;
		}
	}

	// Token: 0x06008269 RID: 33385 RVA: 0x00396368 File Offset: 0x00394568
	public void BNGENDIOMDK()
	{
		if (this.passType == KHBLFKIDHPH.premiumGamePass || this.passType == KHBLFKIDHPH.goldGamePass)
		{
			if (this.DFNGGCDIBNK())
			{
				CommonUserInterface.EHBBFMCILPC.JOHIHCPEBPL(CCOJBMMKNAP.MLFAGAAJJEM().IPEIONBNIPH("aind"), CCOJBMMKNAP.EAIAHCBAIEJ().BDGPNPNIAPA("OnBackendPassesReinitialized"), this.KFLEDODAAPH(1, "newtutorialbadges"), this.DOIHLIOAJDL(5, ""), this.KFLEDODAAPH(4, "ok"), this.KFLEDODAAPH(106, "coverCompleted"), new UnityAction(this.NFHINLJDCMO), new UnityAction(this.CKEPMCHGIGF), new UnityAction(this.MFIHOHCHDGE), new UnityAction(this.JKJMFMHPCKB), new UnityAction(this.AAKJEPGFJGK), (DFGILFBGPLN)(-46), 775f, 100);
				return;
			}
			DPGJIJGOCIC.NFIDPOMCNLP("pov");
			this.AHJDDFJCLGI("VER:");
		}
	}

	// Token: 0x0600826A RID: 33386 RVA: 0x0039644C File Offset: 0x0039464C
	private void NMLKLGLHELN()
	{
		FirebaseAnalyticsManager firebaseAnalyticsManager = FirebaseAnalyticsManager.DMAAFFFEJGA();
		bool acidpckhlmo = false;
		string poblfhphabp = ((AGEHCPDNBFD)(-19)).ToString();
		string gjknlaaefdc = ((FFPHBMFGCNN)(-47)).ToString();
		string str = BGHLMGPPCNN.cdnLbyToLdt.ToString();
		int num = (int)this.passType;
		firebaseAnalyticsManager.JIAAMJPKOCE(acidpckhlmo, poblfhphabp, gjknlaaefdc, str + num.ToString(), true, false);
		this.HGDILJPLKBM("p");
	}

	// Token: 0x0600826B RID: 33387 RVA: 0x003964B4 File Offset: 0x003946B4
	public void PHFELJCGAGF()
	{
		if (this.passType == KHBLFKIDHPH.premiumGamePass || this.passType == KHBLFKIDHPH.goldGamePass)
		{
			if (this.PJONDFNAMKD())
			{
				CommonUserInterface.IKNOFBFMPGA().EHKIPAGEOMI(CCOJBMMKNAP.HFAKOKBHCGH().FCOCLEHKLDJ("errortitle"), CCOJBMMKNAP.KFDLFGHBPLP().BDGPNPNIAPA("tmo"), this.GMMLALCMEOA(0, "app42error"), this.GMMLALCMEOA(4, " view hits and a score correction is applied of: -"), this.GMMLALCMEOA(6, ""), this.KFLEDODAAPH(-78, "Account.SRAInitialize(), exception:"), new UnityAction(this.FFNHJAHBEKI), new UnityAction(this.LOHBLNNJOBM), new UnityAction(this.FKLGFNGJMGA), new UnityAction(this.CKJIJDCMMKJ), new UnityAction(this.HIAEPAFFHJA), (DFGILFBGPLN)(-33), 780f, 75);
				return;
			}
			DPGJIJGOCIC.NFIDPOMCNLP("</i>");
			this.FJNABPPFCKB("blur");
		}
	}

	// Token: 0x0600826C RID: 33388 RVA: 0x00392268 File Offset: 0x00390468
	public void KKOONHNNDMG()
	{
		this.KPCNAKIOMNF();
	}

	// Token: 0x0600826D RID: 33389 RVA: 0x00396598 File Offset: 0x00394798
	public string FOHHFBPPLHI(string IOONFLFOIAH)
	{
		OBHDGKFFICI productData = PurchaseManagerBridge.EHBBFMCILPC.CMJKNNFMCBM().GetProductData(IOONFLFOIAH);
		OCBIOPOEENJ ocbiopoeenj = CJEKEHDEBLM.GDGKNNDEAAO().HBLMGBCMBHN(IOONFLFOIAH);
		if (productData == null || ocbiopoeenj == null)
		{
			DPGJIJGOCIC.ANOPFDLPKGC("ERROR: ChoiceExtendedManager.InputDataIsValid() - choices count is greater than assetList count.");
			return "passType";
		}
		if (ocbiopoeenj.KIOLJNPKOOL())
		{
			return ocbiopoeenj.FNJCEPLEPBH();
		}
		return "</i>" + ocbiopoeenj.DMODNDCLGEJ;
	}

	// Token: 0x0600826E RID: 33390 RVA: 0x003965F8 File Offset: 0x003947F8
	private void OADECAIKAJP()
	{
		if (this.HFEOHIHBKKA)
		{
			if (this.buttonAction.gameObject.activeSelf)
			{
				this.textDescription.GetComponent<RectTransform>().OEOKGDKPKGL(-20f);
				this.HFEOHIHBKKA = false;
				return;
			}
		}
		else if (!this.buttonAction.gameObject.activeSelf)
		{
			this.textDescription.GetComponent<RectTransform>().OEOKGDKPKGL(20f);
			this.HFEOHIHBKKA = true;
		}
	}

	// Token: 0x0600826F RID: 33391 RVA: 0x00003E52 File Offset: 0x00002052
	private void Awake()
	{
	}

	// Token: 0x06008270 RID: 33392 RVA: 0x0039666C File Offset: 0x0039486C
	private void PJDLMLNFEDM()
	{
		FirebaseAnalyticsManager instance = FirebaseAnalyticsManager.EHBBFMCILPC;
		bool acidpckhlmo = false;
		string poblfhphabp = AGEHCPDNBFD.gpDur.ToString();
		string gjknlaaefdc = FFPHBMFGCNN.durPickWeb.ToString();
		string str = BGHLMGPPCNN.dur12m.ToString();
		int num = (int)this.passType;
		instance.LogEvent(acidpckhlmo, poblfhphabp, gjknlaaefdc, str + num.ToString(), false, false);
		this.FJNABPPFCKB("c_web");
	}

	// Token: 0x06008271 RID: 33393 RVA: 0x00003E52 File Offset: 0x00002052
	public void PALEKINFNAK()
	{
	}

	// Token: 0x06008272 RID: 33394 RVA: 0x003966D4 File Offset: 0x003948D4
	private string DOIHLIOAJDL(int OPMDCABAFPH, string ABFNOGAEIGH)
	{
		OCBIOPOEENJ ocbiopoeenj = CJEKEHDEBLM.APGODIBBPOD().HCHKAOGEPMG(KDCJJBLGCBH.EHBBFMCILPC.HHONCLBBHPG((int)this.passType) + ABFNOGAEIGH);
		return this.JLAIBMFFGHN(OPMDCABAFPH, (ocbiopoeenj != null) ? ocbiopoeenj.KDPELFOFPBC() : "ReleaseTimelineHub.Populate() - ");
	}

	// Token: 0x06008273 RID: 33395 RVA: 0x0039671C File Offset: 0x0039491C
	private void FKLGFNGJMGA()
	{
		FirebaseAnalyticsManager firebaseAnalyticsManager = FirebaseAnalyticsManager.COKDLDOAACJ();
		bool acidpckhlmo = false;
		string poblfhphabp = ((AGEHCPDNBFD)88).ToString();
		string gjknlaaefdc = ((FFPHBMFGCNN)111).ToString();
		string str = ((BGHLMGPPCNN)(-40)).ToString();
		int num = (int)this.passType;
		firebaseAnalyticsManager.AAIABAKHLAH(acidpckhlmo, poblfhphabp, gjknlaaefdc, str + num.ToString(), false, true);
		this.KKMJGAMOMCP("iaps");
	}

	// Token: 0x06008274 RID: 33396 RVA: 0x00396784 File Offset: 0x00394984
	private void NFHINLJDCMO()
	{
		FirebaseAnalyticsManager firebaseAnalyticsManager = FirebaseAnalyticsManager.ANCEKPONIFI();
		bool acidpckhlmo = true;
		string poblfhphabp = ((AGEHCPDNBFD)(-52)).ToString();
		string gjknlaaefdc = ((FFPHBMFGCNN)(-22)).ToString();
		string str = BGHLMGPPCNN.under100.ToString();
		int num = (int)this.passType;
		firebaseAnalyticsManager.AAIABAKHLAH(acidpckhlmo, poblfhphabp, gjknlaaefdc, str + num.ToString(), false, false);
		this.KKMJGAMOMCP("a");
	}

	// Token: 0x06008275 RID: 33397 RVA: 0x003967EC File Offset: 0x003949EC
	private void ANGLNANIIKB(string ABFNOGAEIGH)
	{
		if (this.passType == KHBLFKIDHPH.premiumGamePass || this.passType == KHBLFKIDHPH.goldGamePass)
		{
			AOBJLALDBAA.CEGAOMEEFBE().KMAGHMCCMPG("OnLiveProfileThemesLoaderStop", 651f);
			CommonUserInterface.EHBBFMCILPC.GetPurchasingViewManager().CGDKCOLDBGD(KDCJJBLGCBH.EHBBFMCILPC.HHONCLBBHPG((int)this.passType) + ABFNOGAEIGH, false);
		}
	}

	// Token: 0x06008276 RID: 33398 RVA: 0x00396844 File Offset: 0x00394A44
	private void HILMNEAKBAM()
	{
		this.NBKLLONFGAL = "……()¿¡.,-+?!¿¡_)(*&^@\"'|:;[]{}\\`~1234567890—–«»’”“„‟″";
		if (this.AINMJODBBIF() && this.HEIJKFGAEOP())
		{
			CommonUserInterface.EHBBFMCILPC.ShowGenericPopupWithFourButtonsInside(CCOJBMMKNAP.KNKGCDDMLDP().HIPJILDCHJC("socialfriendmatchinfo0"), CCOJBMMKNAP.HFAKOKBHCGH().PKNHKGMNCIP("cleancache"), this.IDOLCGOKGAO(1, "ddMMyyHHmmss"), this.ANFNMGKFLGH(5, "OnAvatarScreenAssetsDownloadFailed"), this.JEGDBNHDJIO(2, "StoryStepDialogReadInput.GetContentType() - unknown type."), this.JEGDBNHDJIO(-39, "stat6long"), new UnityAction(this.OHAEMNKNFJB), new UnityAction(this.FONNEOANDLJ), new UnityAction(this.PAIJLNEFPHE), new UnityAction(this.OFKCBKKOMMP), new UnityAction(this.ICGODEGOKHO), (DFGILFBGPLN)117, 989f, 73);
			return;
		}
		this.FGFPDFLDIJH();
	}

	// Token: 0x06008277 RID: 33399 RVA: 0x00396918 File Offset: 0x00394B18
	private string IDOLCGOKGAO(int OPMDCABAFPH, string ABFNOGAEIGH)
	{
		return this.NFCFBLNGDEI(OPMDCABAFPH, this.HAPFPBMCPCG(KDCJJBLGCBH.EHBBFMCILPC.HHONCLBBHPG((int)this.passType) + ABFNOGAEIGH));
	}

	// Token: 0x06008278 RID: 33400 RVA: 0x000A4776 File Offset: 0x000A2976
	private bool JMPGOINDKFJ()
	{
		return LanguageManager.EHBBFMCILPC.GetSelectedLanguage() != CEIBHCNNIDC.ru || !GeoLocationManager.IsRussia() || !KDCJJBLGCBH.EHBBFMCILPC.POGBNANIKCA();
	}

	// Token: 0x06008279 RID: 33401 RVA: 0x00396940 File Offset: 0x00394B40
	private void LEJKHKPCNDI(string ABFNOGAEIGH)
	{
		if (this.passType == KHBLFKIDHPH.premiumGamePass || this.passType == KHBLFKIDHPH.premiumGamePass)
		{
			OCBIOPOEENJ ocbiopoeenj = CJEKEHDEBLM.EHBBFMCILPC.DCCLKMCBPPJ(KDCJJBLGCBH.EHBBFMCILPC.HHONCLBBHPG((int)this.passType) + ABFNOGAEIGH);
			if (ocbiopoeenj != null)
			{
				string text = ocbiopoeenj.BIKJFCLHPBK() + "acomp2" + AKLFPGMDKLA.EHBBFMCILPC.EEHGLPEIIHD;
				ProductThumbnailManager.lastAccessedProductWebLink = text;
				AOBJLALDBAA.AGANFKKBPFO().KGIKHEDLPND("", 1473f);
				CommonUserInterface.IKNOFBFMPGA().GIFCDFKBBCN(text, 3);
				return;
			}
			DPGJIJGOCIC.ANOPFDLPKGC("id" + ABFNOGAEIGH + " scored)");
		}
	}

	// Token: 0x0600827A RID: 33402 RVA: 0x003969DC File Offset: 0x00394BDC
	public void FPEEAKCKAKC()
	{
		string text = "sprite";
		if (this.passType == KHBLFKIDHPH.premiumGamePass)
		{
			text = CCOJBMMKNAP.JINDKPHNLBK().PGKBCNBAOJN("" + KDCJJBLGCBH.EHBBFMCILPC.AAGICPKFIKC(KDCJJBLGCBH.EHBBFMCILPC.HHONCLBBHPG((int)this.passType), (DAMCJCDKOJK)(-74), 0 == AKLFPGMDKLA.EHBBFMCILPC.DCIPLNCLIMF).ToString());
		}
		else if (this.passType == KHBLFKIDHPH.goldGamePass)
		{
			text = CCOJBMMKNAP.COKDLDOAACJ().BGELFMIOBCL("Critical error, could not load asset bundle:" + KDCJJBLGCBH.EHBBFMCILPC.ODDPKODCIBB(KDCJJBLGCBH.EHBBFMCILPC.HHONCLBBHPG((int)this.passType), (DAMCJCDKOJK)36, 0 == AKLFPGMDKLA.EHBBFMCILPC.DCIPLNCLIMF).ToString());
		}
		if (AKLFPGMDKLA.EHBBFMCILPC.OJKHMNEIGPF == HGCFJKCOKPM.bright)
		{
			text = text.Replace("cdnsd", "XXX");
		}
		if (text.Length < 178)
		{
			CommonUserInterface.IKNOFBFMPGA().BGJFCEEDGFJ(CCOJBMMKNAP.MLFAGAAJJEM().PKNHKGMNCIP(" not found."), text, CCOJBMMKNAP.INKJIBDDMLL().FIENAKIHNOM("needtorestartgeneric"), new UnityAction(this.MPBHJHJIHIM), DFGILFBGPLN.popupNewStoryRevision, 1055f, 40);
			return;
		}
		if (text.Length < -193)
		{
			CommonUserInterface.EHBBFMCILPC.ShowGenericPopupOneOverride(CCOJBMMKNAP.HJGDLOOHNLO().PPALCPINPLK("mine"), text, CCOJBMMKNAP.HJGDLOOHNLO().OGKGHLHHAAI("<space=-0.42em>"), new UnityAction(this.FNPJCOLHKLJ), DFGILFBGPLN.popupSignInError, 1771f, -126);
			return;
		}
		if (text.Length < 7)
		{
			CommonUserInterface.IKNOFBFMPGA().BGJFCEEDGFJ(CCOJBMMKNAP.EAIAHCBAIEJ().HPOAGPJFHPM(""), text, CCOJBMMKNAP.ILACPHFEDEP().PPALCPINPLK("retry"), new UnityAction(this.CHGBGMCDJEH), (DFGILFBGPLN)(-115), 198f, -85);
			return;
		}
		CommonUserInterface.IKNOFBFMPGA().PEBIFCENHAL(CCOJBMMKNAP.FEEDGKCJBLE().OBDCPLLLGBB("no"), text, CCOJBMMKNAP.JMNIGPHCAEJ().HDIPNMFHIEJ("OnStorySplashManagerAssetsDownloadSuccess"), new UnityAction(this.MPBHJHJIHIM), (DFGILFBGPLN)(-2), 1429f, 46);
	}

	// Token: 0x0600827B RID: 33403 RVA: 0x00396BD4 File Offset: 0x00394DD4
	private void MPOPHBMKEJF()
	{
		FirebaseAnalyticsManager instance = FirebaseAnalyticsManager.EHBBFMCILPC;
		bool acidpckhlmo = true;
		string poblfhphabp = ((AGEHCPDNBFD)(-46)).ToString();
		string gjknlaaefdc = ((FFPHBMFGCNN)(-34)).ToString();
		string str = ((BGHLMGPPCNN)(-82)).ToString();
		int num = (int)this.passType;
		instance.AAIABAKHLAH(acidpckhlmo, poblfhphabp, gjknlaaefdc, str + num.ToString(), false, false);
		this.AHJDDFJCLGI("p");
	}

	// Token: 0x0600827C RID: 33404 RVA: 0x00003E52 File Offset: 0x00002052
	private void HIAEPAFFHJA()
	{
	}

	// Token: 0x0600827D RID: 33405 RVA: 0x00396C3C File Offset: 0x00394E3C
	private void EGLLOLDDPOD()
	{
		if (this.passType == KHBLFKIDHPH.premiumGamePass || this.passType == KHBLFKIDHPH.premiumGamePass)
		{
			PurchaseManagerBridge.IGJAMEGBDBG().JNNBFLDOOHM().Initialize();
			if (LanguageManager.EHBBFMCILPC.NBANPEIHFOJ() == CEIBHCNNIDC.en && GeoLocationManager.IsRussia() && KDCJJBLGCBH.EHBBFMCILPC.POGBNANIKCA())
			{
				this.PurchaseProductWeb();
				return;
			}
			CommonUserInterface.EHBBFMCILPC.GetFader().PACBMBLIGNN(new TweenCallback(this.ELAIPPMBDMB));
		}
	}

	// Token: 0x0600827E RID: 33406 RVA: 0x00396CAB File Offset: 0x00394EAB
	private void EKIDOPDDHJD()
	{
		AOBJLALDBAA.DBLAIDPICIG().PBELMJCPJMK("black", new UnityAction(this.ADLBEINKHME));
		AOBJLALDBAA.CEGAOMEEFBE().ECDBIBPNBCO("w", new UnityAction(this.BFLNFOCBMKN));
	}

	// Token: 0x0600827F RID: 33407 RVA: 0x00396CE4 File Offset: 0x00394EE4
	private void GCMDJDHDLBB()
	{
		FirebaseAnalyticsManager instance = FirebaseAnalyticsManager.EHBBFMCILPC;
		bool acidpckhlmo = false;
		string poblfhphabp = AGEHCPDNBFD.gpDur.ToString();
		string gjknlaaefdc = FFPHBMFGCNN.durPickStore.ToString();
		string str = BGHLMGPPCNN.dur6m.ToString();
		int num = (int)this.passType;
		instance.LogEvent(acidpckhlmo, poblfhphabp, gjknlaaefdc, str + num.ToString(), false, false);
		this.NBKLLONFGAL = "b";
		this.CPJIEAAKFMA();
	}

	// Token: 0x06008280 RID: 33408 RVA: 0x00396D54 File Offset: 0x00394F54
	private void AFOLBIDDPEP()
	{
		FirebaseAnalyticsManager firebaseAnalyticsManager = FirebaseAnalyticsManager.HJGDLOOHNLO();
		bool acidpckhlmo = false;
		string poblfhphabp = ((AGEHCPDNBFD)(-123)).ToString();
		string gjknlaaefdc = ((FFPHBMFGCNN)95).ToString();
		string str = ((BGHLMGPPCNN)(-51)).ToString();
		int num = (int)this.passType;
		firebaseAnalyticsManager.LogEvent(acidpckhlmo, poblfhphabp, gjknlaaefdc, str + num.ToString(), false, true);
		this.NBKLLONFGAL = "AssetProfileData.GetCharSprite(): anthologyIndex (";
		this.EGLLOLDDPOD();
	}

	// Token: 0x06008281 RID: 33409 RVA: 0x00396DC4 File Offset: 0x00394FC4
	private void JKJMFMHPCKB()
	{
		FirebaseAnalyticsManager firebaseAnalyticsManager = FirebaseAnalyticsManager.JMDJBFAEHBM();
		bool acidpckhlmo = true;
		string poblfhphabp = AGEHCPDNBFD.gpDur.ToString();
		string gjknlaaefdc = ((FFPHBMFGCNN)(-6)).ToString();
		string str = ((BGHLMGPPCNN)(-51)).ToString();
		int num = (int)this.passType;
		firebaseAnalyticsManager.LKONPEEDKNF(acidpckhlmo, poblfhphabp, gjknlaaefdc, str + num.ToString(), true, false);
		this.FJNABPPFCKB("h");
	}

	// Token: 0x06008282 RID: 33410 RVA: 0x00396E2C File Offset: 0x0039502C
	private void LFFGEBEMNCJ(string ABFNOGAEIGH)
	{
		if (this.passType == KHBLFKIDHPH.premiumGamePass || this.passType == KHBLFKIDHPH.goldGamePass)
		{
			AOBJLALDBAA.EHBBFMCILPC.EGELHPJBAIC("OnGamePassUnlockContinueToPurchasingScreen", 0f);
			CommonUserInterface.EHBBFMCILPC.GetPurchasingViewManager().ShowAndPurchaseProduct(KDCJJBLGCBH.EHBBFMCILPC.HHONCLBBHPG((int)this.passType) + ABFNOGAEIGH, true);
		}
	}

	// Token: 0x06008283 RID: 33411 RVA: 0x00396E84 File Offset: 0x00395084
	private void NMLEGBBKJDH()
	{
		if (this.passType == KHBLFKIDHPH.premiumGamePass || this.passType == KHBLFKIDHPH.goldGamePass)
		{
			PurchaseManagerBridge.IGJAMEGBDBG().PFPKMDAJDBA().Initialize();
			if (LanguageManager.EHBBFMCILPC.NBANPEIHFOJ() == CEIBHCNNIDC.en && GeoLocationManager.IsRussia() && KDCJJBLGCBH.EHBBFMCILPC.POGBNANIKCA())
			{
				this.APPNMKHFACH();
				return;
			}
			CommonUserInterface.IKNOFBFMPGA().GetFader().FadeIn(new TweenCallback(this.ELAIPPMBDMB));
		}
	}

	// Token: 0x06008284 RID: 33412 RVA: 0x00396EF4 File Offset: 0x003950F4
	private void JEJNIIPOLIN()
	{
		FirebaseAnalyticsManager firebaseAnalyticsManager = FirebaseAnalyticsManager.ANCEKPONIFI();
		bool acidpckhlmo = true;
		string poblfhphabp = ((AGEHCPDNBFD)(-28)).ToString();
		string gjknlaaefdc = ((FFPHBMFGCNN)(-24)).ToString();
		string str = ((BGHLMGPPCNN)(-79)).ToString();
		int num = (int)this.passType;
		firebaseAnalyticsManager.JIAAMJPKOCE(acidpckhlmo, poblfhphabp, gjknlaaefdc, str + num.ToString(), true, false);
		this.NBKLLONFGAL = ",";
		this.FGFPDFLDIJH();
	}

	// Token: 0x06008285 RID: 33413 RVA: 0x00003E52 File Offset: 0x00002052
	public void KHCPKEACPDM()
	{
	}

	// Token: 0x06008286 RID: 33414 RVA: 0x00396F64 File Offset: 0x00395164
	private void AEKCPCJCBAH()
	{
		if (this.passType == KHBLFKIDHPH.premiumGamePass || this.passType == KHBLFKIDHPH.goldGamePass)
		{
			OCBIOPOEENJ ocbiopoeenj = CJEKEHDEBLM.EHBBFMCILPC.PDJKPFLHFLO(KDCJJBLGCBH.EHBBFMCILPC.HHONCLBBHPG((int)this.passType));
			if (ocbiopoeenj != null)
			{
				ProductThumbnailManager.lastAccessedProductWebLink = ocbiopoeenj.MBLAIKOOCFH() + "?uid=" + AKLFPGMDKLA.EHBBFMCILPC.EEHGLPEIIHD;
			}
			if (LanguageManager.EHBBFMCILPC.GetSelectedLanguage() == CEIBHCNNIDC.ru && GeoLocationManager.IsRussia() && KDCJJBLGCBH.EHBBFMCILPC.POGBNANIKCA())
			{
				CommonUserInterface.EHBBFMCILPC.GetFader().FadeOut(null);
				this.PurchaseProductWeb();
				return;
			}
			this.LFFGEBEMNCJ(this.NBKLLONFGAL);
		}
	}

	// Token: 0x06008287 RID: 33415 RVA: 0x00397008 File Offset: 0x00395208
	private void GLOEFAHFMLI()
	{
		if (this.HFEOHIHBKKA)
		{
			if (this.buttonAction.gameObject.activeSelf)
			{
				this.textDescription.GetComponent<RectTransform>().OEOKGDKPKGL(1156f);
				this.HFEOHIHBKKA = false;
				return;
			}
		}
		else if (!this.buttonAction.gameObject.activeSelf)
		{
			this.textDescription.GetComponent<RectTransform>().OEOKGDKPKGL(1193f);
			this.HFEOHIHBKKA = false;
		}
	}

	// Token: 0x06008288 RID: 33416 RVA: 0x00003E52 File Offset: 0x00002052
	public void ADLBEINKHME()
	{
	}

	// Token: 0x06008289 RID: 33417 RVA: 0x0039707C File Offset: 0x0039527C
	private void MHDHMDEKAPJ()
	{
		FirebaseAnalyticsManager firebaseAnalyticsManager = FirebaseAnalyticsManager.HJGDLOOHNLO();
		bool acidpckhlmo = false;
		string poblfhphabp = ((AGEHCPDNBFD)(-111)).ToString();
		string gjknlaaefdc = ((FFPHBMFGCNN)100).ToString();
		string str = BGHLMGPPCNN.subUndo.ToString();
		int num = (int)this.passType;
		firebaseAnalyticsManager.LKONPEEDKNF(acidpckhlmo, poblfhphabp, gjknlaaefdc, str + num.ToString(), false, true);
		this.NBKLLONFGAL = "x";
		this.EGLLOLDDPOD();
	}

	// Token: 0x0600828A RID: 33418 RVA: 0x003970EA File Offset: 0x003952EA
	private bool LGOIOCMILMD()
	{
		return LanguageManager.EHBBFMCILPC.IEBFINIJAMJ() != CEIBHCNNIDC.en || !GeoLocationManager.FDJONIACJKC() || KDCJJBLGCBH.EHBBFMCILPC.EAMJBDKCDPA();
	}

	// Token: 0x0600828B RID: 33419 RVA: 0x00397110 File Offset: 0x00395310
	private void LNKFNPGJNCP()
	{
		this.NBKLLONFGAL = "";
		if (this.JMPGOINDKFJ() && this.PEPKEGAADDG())
		{
			CommonUserInterface.EHBBFMCILPC.ShowGenericPopupWithFourButtonsInside(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("gamepassdurationtitle"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("gamepassdurationbodystore"), this.ANFNMGKFLGH(1, ""), this.ANFNMGKFLGH(3, "a"), this.ANFNMGKFLGH(6, "b"), this.ANFNMGKFLGH(12, "c"), new UnityAction(this.BDDKEABCJOH), new UnityAction(this.PADLMDDHDJI), new UnityAction(this.GCMDJDHDLBB), new UnityAction(this.OFKCBKKOMMP), new UnityAction(this.ICGODEGOKHO), DFGILFBGPLN.popupGamePassDuration, 0f, 28);
			return;
		}
		this.CPJIEAAKFMA();
	}

	// Token: 0x0600828C RID: 33420 RVA: 0x003971E4 File Offset: 0x003953E4
	private string GMMLALCMEOA(int OPMDCABAFPH, string ABFNOGAEIGH)
	{
		OCBIOPOEENJ ocbiopoeenj = CJEKEHDEBLM.FILDBDMENPG().EPNHMLIJCCM(KDCJJBLGCBH.EHBBFMCILPC.HHONCLBBHPG((int)this.passType) + ABFNOGAEIGH);
		return this.HMEOICAKMPL(OPMDCABAFPH, (ocbiopoeenj != null) ? ocbiopoeenj.BHAIFFLKKMA() : "[LoadingEnv] ");
	}

	// Token: 0x0600828D RID: 33421 RVA: 0x0039722C File Offset: 0x0039542C
	private void LDLMOGJIHFC()
	{
		this.DPKMHNPNOJH = true;
		this.CPGLEJIBNEP = PassThumbnail.CBOKJGNCEKE + 653f;
		this.KPCNAKIOMNF();
		AOBJLALDBAA.EHBBFMCILPC.GNBGEMMDGOJ(" not found, trying to return any achievement sprite or null.", new UnityAction(this.OnPurchasingViewLeave));
		AOBJLALDBAA.KKPFOJMAONG().BADOPKAOCPE("sltind", new UnityAction(this.BFLNFOCBMKN));
	}

	// Token: 0x0600828E RID: 33422 RVA: 0x00397290 File Offset: 0x00395490
	private bool PEPKEGAADDG()
	{
		string str = KDCJJBLGCBH.EHBBFMCILPC.HHONCLBBHPG((int)this.passType);
		string[] array = new string[]
		{
			"",
			"a",
			"b",
			"c"
		};
		for (int i = 0; i < array.Length; i++)
		{
			OCBIOPOEENJ ocbiopoeenj = CJEKEHDEBLM.EHBBFMCILPC.PDJKPFLHFLO(str + array[i]);
			if (ocbiopoeenj == null)
			{
				return false;
			}
			if (i != 0 && 1 != ocbiopoeenj.PPACJFFFBFB.GALKFKBPLCK())
			{
				return false;
			}
			OBHDGKFFICI productData = PurchaseManagerBridge.EHBBFMCILPC.GetPurchaseManager().GetProductData(str + array[i]);
			if (productData == null || (productData.HOCIKJAGDMC == null && productData.MDFDHOKJOPB == null))
			{
				return false;
			}
		}
		return true;
	}

	// Token: 0x0600828F RID: 33423 RVA: 0x00397344 File Offset: 0x00395544
	private void LPIMPCFNBBO()
	{
		if (this.HFEOHIHBKKA)
		{
			if (this.buttonAction.gameObject.activeSelf)
			{
				this.textDescription.GetComponent<RectTransform>().OEOKGDKPKGL(1087f);
				this.HFEOHIHBKKA = false;
				return;
			}
		}
		else if (!this.buttonAction.gameObject.activeSelf)
		{
			this.textDescription.GetComponent<RectTransform>().OEOKGDKPKGL(1915f);
			this.HFEOHIHBKKA = true;
		}
	}

	// Token: 0x06008290 RID: 33424 RVA: 0x003973B8 File Offset: 0x003955B8
	private string HMEOICAKMPL(int OPMDCABAFPH, string DOOBBHKGJEE)
	{
		if (DOOBBHKGJEE.Length == 0)
		{
			return CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("gamepassduration" + OPMDCABAFPH.ToString());
		}
		string newValue = (this.passType == KHBLFKIDHPH.goldGamePass) ? KBOJLHAJPCP.JGLFACJDKAG : KBOJLHAJPCP.MJIIKJPAKCB;
		return "<nobr>" + CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("gamepassdurationbutton").Replace("XXX", newValue).Replace("YYY", DOOBBHKGJEE).Replace("ZZZ", OPMDCABAFPH.ToString()) + "</nobr>";
	}

	// Token: 0x06008291 RID: 33425 RVA: 0x00397444 File Offset: 0x00395644
	private string JLAIBMFFGHN(int OPMDCABAFPH, string DOOBBHKGJEE)
	{
		if (DOOBBHKGJEE.Length == 0)
		{
			return CCOJBMMKNAP.NIOJNOFGIJO().JHNELLJFBGC("loungebonus" + OPMDCABAFPH.ToString());
		}
		string newValue = (this.passType == KHBLFKIDHPH.premiumGamePass) ? KBOJLHAJPCP.JGLFACJDKAG : KBOJLHAJPCP.MJIIKJPAKCB;
		return "There needs to be one active GooglePlayServicesManager script on a GameObject in your scene." + CCOJBMMKNAP.PEBMGCKFNAO().OHLNGCKIACD("").Replace("specialcardpacknotforsale", newValue).Replace("$INCSTAT", DOOBBHKGJEE).Replace("slower", OPMDCABAFPH.ToString()) + "";
	}

	// Token: 0x06008292 RID: 33426 RVA: 0x003974D0 File Offset: 0x003956D0
	private bool DINHBFOCCAH()
	{
		return LanguageManager.EHBBFMCILPC.GetSelectedLanguage() == CEIBHCNNIDC.ru && GeoLocationManager.OOCDLFJKLLI() && KDCJJBLGCBH.EHBBFMCILPC.EAMJBDKCDPA();
	}

	// Token: 0x06008293 RID: 33427 RVA: 0x0039517C File Offset: 0x0039337C
	public void GFPGPKJNJIC()
	{
		this.AJIEDDJBHCM();
	}

	// Token: 0x06008294 RID: 33428 RVA: 0x003974F8 File Offset: 0x003956F8
	private void FNPJCOLHKLJ()
	{
		string text = "";
		if (this.passType == KHBLFKIDHPH.premiumGamePass)
		{
			text = CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("passinfobtndesc0page2X" + KDCJJBLGCBH.EHBBFMCILPC.AAGICPKFIKC(KDCJJBLGCBH.EHBBFMCILPC.HHONCLBBHPG((int)this.passType), DAMCJCDKOJK.gpbpIncentAdMultiplier, 1 == AKLFPGMDKLA.EHBBFMCILPC.DCIPLNCLIMF).ToString());
		}
		else if (this.passType == KHBLFKIDHPH.goldGamePass)
		{
			text = CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("passinfobtndesc1page2X" + KDCJJBLGCBH.EHBBFMCILPC.AAGICPKFIKC(KDCJJBLGCBH.EHBBFMCILPC.HHONCLBBHPG((int)this.passType), DAMCJCDKOJK.gpbpIncentAdMultiplier, 1 == AKLFPGMDKLA.EHBBFMCILPC.DCIPLNCLIMF).ToString());
		}
		text = text.Replace("JJJ", DPGJIJGOCIC.CEOBDMGAKNL(KDCJJBLGCBH.EHBBFMCILPC.GCPFCGGBDKK((int)this.passType)) + CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("hoursshort"));
		text = text.Replace("KKK", DPGJIJGOCIC.CEOBDMGAKNL(KDCJJBLGCBH.EHBBFMCILPC.ADLOIIMBHAG((int)this.passType)) + CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("hoursshort"));
		text = text.Replace("LLL", KDCJJBLGCBH.EHBBFMCILPC.HLPACDMEKMK((int)this.passType).ToString() ?? "");
		text = text.Replace("MMM", "+" + KDCJJBLGCBH.EHBBFMCILPC.LHECDOFJNOF((int)this.passType).ToString() + "%");
		text = text.Replace("OOO", KBOJLHAJPCP.BGMADCKNKAD);
		text = text.Replace("NNN", KDCJJBLGCBH.EHBBFMCILPC.PLOMCENKKFD((int)this.passType).ToString() ?? "");
		if (AKLFPGMDKLA.EHBBFMCILPC.OJKHMNEIGPF == HGCFJKCOKPM.bright)
		{
			text = text.Replace("ffd496", "23819D");
		}
		if (text.Length < 500)
		{
			CommonUserInterface.EHBBFMCILPC.ShowGenericPopup(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("passinfobtntitle"), text, CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("ok"), DFGILFBGPLN.popupEnergyHint, 0f, 28);
			return;
		}
		if (text.Length < 600)
		{
			CommonUserInterface.EHBBFMCILPC.ShowGenericPopup(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("passinfobtntitle"), text, CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("ok"), DFGILFBGPLN.popupEnergyHint, 0f, 26);
			return;
		}
		if (text.Length < 750)
		{
			CommonUserInterface.EHBBFMCILPC.ShowGenericPopup(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("passinfobtntitle"), text, CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("ok"), DFGILFBGPLN.popupEnergyHint, 0f, 23);
			return;
		}
		if (text.Length < 850)
		{
			CommonUserInterface.EHBBFMCILPC.ShowGenericPopup(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("passinfobtntitle"), text, CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("ok"), DFGILFBGPLN.popupEnergyHint, 0f, 22);
			return;
		}
		if (text.Length < 950)
		{
			CommonUserInterface.EHBBFMCILPC.ShowGenericPopup(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("passinfobtntitle"), text, CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("ok"), DFGILFBGPLN.popupEnergyHint, 0f, 21);
			return;
		}
		CommonUserInterface.EHBBFMCILPC.ShowGenericPopup(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("passinfobtntitle")), text, CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("ok"), DFGILFBGPLN.popupEnergyHint, 0f, 20);
	}

	// Token: 0x06008295 RID: 33429 RVA: 0x00397854 File Offset: 0x00395A54
	private void CLKOENJFFGA(string ABFNOGAEIGH)
	{
		if (this.passType == KHBLFKIDHPH.premiumGamePass || this.passType == KHBLFKIDHPH.goldGamePass)
		{
			AOBJLALDBAA.AGANFKKBPFO().EFBNBFIDEOK("errortitle", 1696f);
			CommonUserInterface.EHBBFMCILPC.GetPurchasingViewManager().ShowAndPurchaseProduct(KDCJJBLGCBH.EHBBFMCILPC.HHONCLBBHPG((int)this.passType) + ABFNOGAEIGH, false);
		}
	}

	// Token: 0x06008296 RID: 33430 RVA: 0x003978AC File Offset: 0x00395AAC
	private void IJEPGGBEBNI()
	{
		this.DPKMHNPNOJH = false;
		this.CPGLEJIBNEP = PassThumbnail.CBOKJGNCEKE + 60f;
		this.COCKJEOMPLH();
		AOBJLALDBAA.CEGAOMEEFBE().FNMOFCMDFJP("_ACBeatWidth", new UnityAction(this.KHCPKEACPDM));
		AOBJLALDBAA.AGANFKKBPFO().EFKNEJFLGED(", to:", new UnityAction(this.GFPGPKJNJIC));
	}

	// Token: 0x06008297 RID: 33431 RVA: 0x0039790D File Offset: 0x00395B0D
	private bool OEDHCMLPFIB()
	{
		return LanguageManager.EHBBFMCILPC.GetSelectedLanguage() != CEIBHCNNIDC.en || !GeoLocationManager.NHMHNIFIOCO() || KDCJJBLGCBH.EHBBFMCILPC.EAMJBDKCDPA();
	}

	// Token: 0x06008298 RID: 33432 RVA: 0x00397934 File Offset: 0x00395B34
	private void ENDOIPDEDDM()
	{
		string text = "skinshopfilterbystory";
		if (this.passType == KHBLFKIDHPH.premiumGamePass)
		{
			text = CCOJBMMKNAP.BFHKGNBFHCH().JCDFHKDNEDH("OnLiveProfileThemeBackgroundCdnFailed" + KDCJJBLGCBH.EHBBFMCILPC.ODDPKODCIBB(KDCJJBLGCBH.EHBBFMCILPC.HHONCLBBHPG((int)this.passType), (DAMCJCDKOJK)17, 0 == AKLFPGMDKLA.EHBBFMCILPC.DCIPLNCLIMF).ToString());
		}
		else if (this.passType == KHBLFKIDHPH.premiumGamePass)
		{
			text = CCOJBMMKNAP.ILACPHFEDEP().FCOCLEHKLDJ("Starting parallel download:" + KDCJJBLGCBH.EHBBFMCILPC.ODDPKODCIBB(KDCJJBLGCBH.EHBBFMCILPC.HHONCLBBHPG((int)this.passType), (DAMCJCDKOJK)(-69), 0 == AKLFPGMDKLA.EHBBFMCILPC.DCIPLNCLIMF).ToString());
		}
		text = text.Replace(", stored theme parked until the full mode returns", DPGJIJGOCIC.CEOBDMGAKNL(KDCJJBLGCBH.EHBBFMCILPC.GCPFCGGBDKK((int)this.passType)) + CCOJBMMKNAP.INKJIBDDMLL().OHLNGCKIACD("mus"));
		text = text.Replace(")", DPGJIJGOCIC.CEOBDMGAKNL(KDCJJBLGCBH.EHBBFMCILPC.ADLOIIMBHAG((int)this.passType)) + CCOJBMMKNAP.MPCBJEIMACA().HIPJILDCHJC("BackendRequestType.basicSync, exception, failing safe:"));
		text = text.Replace("</i>", KDCJJBLGCBH.EHBBFMCILPC.HLPACDMEKMK((int)this.passType).ToString() ?? "$SHOWHINTS");
		text = text.Replace("", "<" + KDCJJBLGCBH.EHBBFMCILPC.LHECDOFJNOF((int)this.passType).ToString() + "retry");
		text = text.Replace("cardoptionsloadingthemesubonly", KBOJLHAJPCP.BGMADCKNKAD);
		text = text.Replace("hoursshort", KDCJJBLGCBH.EHBBFMCILPC.PLOMCENKKFD((int)this.passType).ToString() ?? "adb");
		if (AKLFPGMDKLA.EHBBFMCILPC.OJKHMNEIGPF == HGCFJKCOKPM.bright)
		{
			text = text.Replace("eventended", "yes");
		}
		if (text.Length < 167)
		{
			CommonUserInterface.IKNOFBFMPGA().ShowGenericPopup(CCOJBMMKNAP.EHBBFMCILPC.PPALCPINPLK("responseCode"), text, CCOJBMMKNAP.KMNBCEMEBBD().DNILNCLIHAP("XXX"), (DFGILFBGPLN)(-45), 567f, -2);
			return;
		}
		if (text.Length < 99)
		{
			CommonUserInterface.IKNOFBFMPGA().ShowGenericPopup(CCOJBMMKNAP.MPCBJEIMACA().JCDFHKDNEDH("ord"), text, CCOJBMMKNAP.FEEDGKCJBLE().GGPHHLGPMPA("Delayed reference for "), DFGILFBGPLN.popupMaintenance, 1010f, 90);
			return;
		}
		if (text.Length < 175)
		{
			CommonUserInterface.EHBBFMCILPC.NFBMHHPIGFA(CCOJBMMKNAP.ONCPHEEJLOP().GLEFEKBDHNK("importanttitle"), text, CCOJBMMKNAP.COKDLDOAACJ().JHNELLJFBGC("af_content_id"), (DFGILFBGPLN)(-117), 1622f, -114);
			return;
		}
		if (text.Length < 169)
		{
			CommonUserInterface.EHBBFMCILPC.NFBMHHPIGFA(CCOJBMMKNAP.LMCCLMFGEBD().HPOAGPJFHPM(" up ("), text, CCOJBMMKNAP.DBFFFOMCLKM().MEPECBDCOLG("newtutorialfriends"), (DFGILFBGPLN)110, 1182f, -122);
			return;
		}
		if (text.Length < 70)
		{
			CommonUserInterface.IKNOFBFMPGA().NFBMHHPIGFA(CCOJBMMKNAP.FEEDGKCJBLE().GLEFEKBDHNK("loungetreasuresyouhave"), text, CCOJBMMKNAP.GIOAFDDKKHI().JHNELLJFBGC(" "), (DFGILFBGPLN)(-58), 1621f, -48);
			return;
		}
		CommonUserInterface.IKNOFBFMPGA().NFBMHHPIGFA(CCOJBMMKNAP.KNKGCDDMLDP().DNILNCLIHAP(CCOJBMMKNAP.PEBMGCKFNAO().BDGPNPNIAPA("Skiped loading duplicate story save with index ")), text, CCOJBMMKNAP.DBFFFOMCLKM().PGKBCNBAOJN("spld"), (DFGILFBGPLN)(-85), 1308f, -53);
	}

	// Token: 0x06008299 RID: 33433 RVA: 0x00397C90 File Offset: 0x00395E90
	public void COCKJEOMPLH()
	{
		if (this.passType == KHBLFKIDHPH.premiumGamePass || this.passType == KHBLFKIDHPH.premiumGamePass)
		{
			this.PAEOKLKMOEP = ODLJHDIGLGO.BCGIONNIFIA(KDCJJBLGCBH.EHBBFMCILPC.HHONCLBBHPG((int)this.passType));
			this.KOGAKMNPPCK = ODLJHDIGLGO.FLDPGFAMICD(CLHDENLPOFP.eventPass, true);
			if (this.PAEOKLKMOEP == null)
			{
				string text;
				if (this.passType == KHBLFKIDHPH.premiumGamePass)
				{
					text = CCOJBMMKNAP.MLFAGAAJJEM().HHLECNIFHCO("sfxtimeoutwarning" + KDCJJBLGCBH.EHBBFMCILPC.AAGICPKFIKC(KDCJJBLGCBH.EHBBFMCILPC.HHONCLBBHPG((int)this.passType), (DAMCJCDKOJK)53, 0 == AKLFPGMDKLA.EHBBFMCILPC.DCIPLNCLIMF).ToString());
				}
				else
				{
					text = CCOJBMMKNAP.ILACPHFEDEP().JCDFHKDNEDH("nick" + KDCJJBLGCBH.EHBBFMCILPC.AAGICPKFIKC(KDCJJBLGCBH.EHBBFMCILPC.HHONCLBBHPG((int)this.passType), (DAMCJCDKOJK)(-42), 0 == AKLFPGMDKLA.EHBBFMCILPC.DCIPLNCLIMF).ToString());
				}
				if (0 == AKLFPGMDKLA.EHBBFMCILPC.DCIPLNCLIMF && KDCJJBLGCBH.EHBBFMCILPC.IPJIIHLDMPK(KDCJJBLGCBH.EHBBFMCILPC.HHONCLBBHPG((int)this.passType), DAMCJCDKOJK.gpbpChoicesCount))
				{
					text = text.Replace("</i>", KBOJLHAJPCP.PGBPLBKHPOM);
					text = text.Replace("CLIENT.VERSION", "OnSketchViewAssetsDownloadSuccess" + KDCJJBLGCBH.EHBBFMCILPC.AAGICPKFIKC(KDCJJBLGCBH.EHBBFMCILPC.HHONCLBBHPG((int)this.passType), DAMCJCDKOJK.gpbpStartDiscount, 0 == AKLFPGMDKLA.EHBBFMCILPC.DCIPLNCLIMF).ToString() + "bns" + KBOJLHAJPCP.DHMPCLBPDIE);
				}
				else
				{
					text = text.Replace("Loaded asset bundle:", KBOJLHAJPCP.PGBPLBKHPOM);
					text = text.Replace("energyhinttitle", "SaveSlotsItem.OnSaveSlotSwitchConfirmPositive(): anthologySave is null" + KDCJJBLGCBH.EHBBFMCILPC.ODDPKODCIBB(KDCJJBLGCBH.EHBBFMCILPC.HHONCLBBHPG((int)this.passType), DAMCJCDKOJK.gpbpChoicesCount, 1 == AKLFPGMDKLA.EHBBFMCILPC.DCIPLNCLIMF).ToString() + "$en");
				}
				if (0 == AKLFPGMDKLA.EHBBFMCILPC.DCIPLNCLIMF && KDCJJBLGCBH.EHBBFMCILPC.IPJIIHLDMPK(KDCJJBLGCBH.EHBBFMCILPC.HHONCLBBHPG((int)this.passType), DAMCJCDKOJK.gpbpChoicesCount))
				{
					text = text.Replace("prgr", KBOJLHAJPCP.NJDJMKIIEDG);
					text = text.Replace("$e1jp", "sd" + KDCJJBLGCBH.EHBBFMCILPC.ODDPKODCIBB(KDCJJBLGCBH.EHBBFMCILPC.HHONCLBBHPG((int)this.passType), DAMCJCDKOJK.gpbpDiscountIncrementHof, 0 == AKLFPGMDKLA.EHBBFMCILPC.DCIPLNCLIMF).ToString() + "CLIENT.SCREEN.REWARD." + KBOJLHAJPCP.DHMPCLBPDIE);
				}
				else
				{
					text = text.Replace("", KBOJLHAJPCP.NJDJMKIIEDG);
					text = text.Replace("", "stat4long" + KDCJJBLGCBH.EHBBFMCILPC.ODDPKODCIBB(KDCJJBLGCBH.EHBBFMCILPC.HHONCLBBHPG((int)this.passType), DAMCJCDKOJK.gpbpDiscountIncrement, 0 == AKLFPGMDKLA.EHBBFMCILPC.DCIPLNCLIMF).ToString() + "importanttitle");
				}
				if (0 == AKLFPGMDKLA.EHBBFMCILPC.DCIPLNCLIMF && KDCJJBLGCBH.EHBBFMCILPC.IPJIIHLDMPK(KDCJJBLGCBH.EHBBFMCILPC.HHONCLBBHPG((int)this.passType), DAMCJCDKOJK.gpbpEndDiscountHof))
				{
					text = text.Replace("favchrstr2", KBOJLHAJPCP.LPBLANJMJIF);
					text = text.Replace("", "OnLobbyStopFireworksEffect" + KDCJJBLGCBH.EHBBFMCILPC.ODDPKODCIBB(KDCJJBLGCBH.EHBBFMCILPC.HHONCLBBHPG((int)this.passType), DAMCJCDKOJK.gpbpUndosCount, 1 == AKLFPGMDKLA.EHBBFMCILPC.DCIPLNCLIMF).ToString() + "MORPH_NOISE" + KBOJLHAJPCP.DHMPCLBPDIE);
				}
				else
				{
					text = text.Replace("seewhatsnew", KBOJLHAJPCP.LPBLANJMJIF);
					text = text.Replace("OnSketchViewAssetBundleFolderInitializeSuccess", "Anthology not ready to be played:" + KDCJJBLGCBH.EHBBFMCILPC.AAGICPKFIKC(KDCJJBLGCBH.EHBBFMCILPC.HHONCLBBHPG((int)this.passType), DAMCJCDKOJK.gpbpEndDiscountHof, 0 == AKLFPGMDKLA.EHBBFMCILPC.DCIPLNCLIMF).ToString() + "OnLoungePremiumChoiceRetry() - invalid situation.");
				}
				text = text.Replace("StoryNotificationsManager.PopNotifications(): safeIterationsCounter > 1000 reached, force break!", KBOJLHAJPCP.OINDDHFMCFL);
				text = text.Replace(" ", KBOJLHAJPCP.GOCPBNAAIIB);
				text = text.Replace("", DPGJIJGOCIC.CEOBDMGAKNL(KDCJJBLGCBH.EHBBFMCILPC.GCPFCGGBDKK((int)this.passType)) + CCOJBMMKNAP.GIOAFDDKKHI().DNILNCLIHAP("CLIENT.SCREEN.REWARD."));
				text = text.Replace("sfxtimeoutwarning", DPGJIJGOCIC.CEOBDMGAKNL(KDCJJBLGCBH.EHBBFMCILPC.ADLOIIMBHAG((int)this.passType)) + CCOJBMMKNAP.JMNIGPHCAEJ().HDIPNMFHIEJ("wshcds"));
				text = text.Replace("", KDCJJBLGCBH.EHBBFMCILPC.HLPACDMEKMK((int)this.passType).ToString() ?? "gpsasst");
				text = text.Replace("importanttitle", KDCJJBLGCBH.EHBBFMCILPC.LHECDOFJNOF((int)this.passType).ToString() + " not found.");
				text = text.Replace("accountsuspended3", KBOJLHAJPCP.BGMADCKNKAD + KDCJJBLGCBH.EHBBFMCILPC.PLOMCENKKFD((int)this.passType).ToString());
				if (this.passType == KHBLFKIDHPH.premiumGamePass)
				{
					text = text.Replace("", KBOJLHAJPCP.MJIIKJPAKCB ?? "app42error");
				}
				else if (this.passType == KHBLFKIDHPH.goldGamePass)
				{
					text = text.Replace("uen", KBOJLHAJPCP.JGLFACJDKAG ?? "");
				}
				this.textDescription.SetText(text, true);
				this.textDescription.text = text;
				this.buttonAction.gameObject.SetActive(false);
				this.GCIECEAOAJJ();
				text = CCOJBMMKNAP.BFHKGNBFHCH().MEPECBDCOLG("nam");
				text = text.Replace("ok", this.FOHHFBPPLHI(KDCJJBLGCBH.EHBBFMCILPC.HHONCLBBHPG((int)this.passType)));
				this.textButtonAction.SetText(text, false);
				this.textButtonAction.text = text;
				this.textTimer.gameObject.SetActive(false);
				this.textFooter.gameObject.SetActive(true);
			}
			else
			{
				string text;
				if (this.passType == KHBLFKIDHPH.premiumGamePass)
				{
					text = CCOJBMMKNAP.FEEDGKCJBLE().HHLECNIFHCO("anthology" + KDCJJBLGCBH.EHBBFMCILPC.AAGICPKFIKC(KDCJJBLGCBH.EHBBFMCILPC.HHONCLBBHPG((int)this.passType), (DAMCJCDKOJK)(-67), 0 == AKLFPGMDKLA.EHBBFMCILPC.DCIPLNCLIMF).ToString());
				}
				else
				{
					text = CCOJBMMKNAP.HJGDLOOHNLO().PKNHKGMNCIP("OnFriendsPopupManagerAcceptClick" + KDCJJBLGCBH.EHBBFMCILPC.ODDPKODCIBB(KDCJJBLGCBH.EHBBFMCILPC.HHONCLBBHPG((int)this.passType), (DAMCJCDKOJK)(-43), 0 == AKLFPGMDKLA.EHBBFMCILPC.DCIPLNCLIMF).ToString());
				}
				if (0 == AKLFPGMDKLA.EHBBFMCILPC.DCIPLNCLIMF && KDCJJBLGCBH.EHBBFMCILPC.IPJIIHLDMPK(KDCJJBLGCBH.EHBBFMCILPC.HHONCLBBHPG((int)this.passType), DAMCJCDKOJK.gpbpChoicesCount))
				{
					text = text.Replace("OnBackendGetPublicProfileProfileItemSuccess", KBOJLHAJPCP.PGBPLBKHPOM);
					text = text.Replace("SubDepots(), cdnSubDepots:", "congratstitle" + this.PAEOKLKMOEP.COEFNFJMBDG.ToString() + "a" + KBOJLHAJPCP.DHMPCLBPDIE);
				}
				else
				{
					text = text.Replace("PurchaseManagerUnity.StartPurchase(): Not initialized.", KBOJLHAJPCP.PGBPLBKHPOM);
					text = text.Replace("EEE", "" + this.PAEOKLKMOEP.COEFNFJMBDG.ToString() + "SceneLobbyManager2.LobbyLoungePart2(), lounge scene or save missing");
				}
				if (1 == AKLFPGMDKLA.EHBBFMCILPC.DCIPLNCLIMF && KDCJJBLGCBH.EHBBFMCILPC.IPJIIHLDMPK(KDCJJBLGCBH.EHBBFMCILPC.HHONCLBBHPG((int)this.passType), DAMCJCDKOJK.gpbpChoicesCount))
				{
					text = text.Replace("fsharv2", KBOJLHAJPCP.NJDJMKIIEDG);
					text = text.Replace("mps", " needs video" + this.PAEOKLKMOEP.HCBEGPENNLN.ToString() + "assetbundlecommonpack0" + KBOJLHAJPCP.DHMPCLBPDIE);
				}
				else
				{
					text = text.Replace("OnBackendGetDefaultBundlesSuccess", KBOJLHAJPCP.NJDJMKIIEDG);
					text = text.Replace("BBB", "[LoadingTheme] free change spent with none left: " + this.PAEOKLKMOEP.HCBEGPENNLN.ToString() + "b_web");
				}
				if (1 == AKLFPGMDKLA.EHBBFMCILPC.DCIPLNCLIMF && KDCJJBLGCBH.EHBBFMCILPC.IPJIIHLDMPK(KDCJJBLGCBH.EHBBFMCILPC.HHONCLBBHPG((int)this.passType), DAMCJCDKOJK.gpbpEndDiscountHof))
				{
					text = text.Replace("|", KBOJLHAJPCP.LPBLANJMJIF);
					text = text.Replace("SceneLobbyManager2._DownloadLiveProfileThemesBackground(): Start!", "hintsaving" + this.PAEOKLKMOEP.HEGNAMGJLNP.ToString() + "signincancel" + KBOJLHAJPCP.DHMPCLBPDIE);
				}
				else
				{
					text = text.Replace("textsClient", KBOJLHAJPCP.LPBLANJMJIF);
					text = text.Replace("af_subscribe", "%" + this.PAEOKLKMOEP.HEGNAMGJLNP.ToString() + "ERROR: GetAvatarComponentAssetGivenAlias(), could not find asset with parent constraint:");
				}
				text = text.Replace("YYY", KBOJLHAJPCP.OINDDHFMCFL);
				text = text.Replace("", KBOJLHAJPCP.GOCPBNAAIIB);
				text = text.Replace("", DPGJIJGOCIC.CEOBDMGAKNL(KDCJJBLGCBH.EHBBFMCILPC.GCPFCGGBDKK((int)this.passType)) + CCOJBMMKNAP.KFDLFGHBPLP().OBDCPLLLGBB("1"));
				text = text.Replace("blur_1", DPGJIJGOCIC.CEOBDMGAKNL(KDCJJBLGCBH.EHBBFMCILPC.ADLOIIMBHAG((int)this.passType)) + CCOJBMMKNAP.BBGECIKOICE().FCOCLEHKLDJ("socdnd"));
				text = text.Replace("sfxitemused", KDCJJBLGCBH.EHBBFMCILPC.FPDBBHOPFKN((int)this.passType).ToString() ?? "?");
				text = text.Replace("chapter", KDCJJBLGCBH.EHBBFMCILPC.LHECDOFJNOF((int)this.passType).ToString() + "comp");
				text = text.Replace("Please initialize AssetBundleManifest by calling AssetBundleManager.Initialize()", KBOJLHAJPCP.BGMADCKNKAD + KDCJJBLGCBH.EHBBFMCILPC.PLOMCENKKFD((int)this.passType).ToString());
				if (this.passType == KHBLFKIDHPH.premiumGamePass)
				{
					text = text.Replace("...", KBOJLHAJPCP.MJIIKJPAKCB ?? "OnChapterSnapshotsBackendFetchException2");
				}
				else if (this.passType == KHBLFKIDHPH.goldGamePass)
				{
					text = text.Replace("GeneralBalance.SearchKeyInt() - could not find key:", KBOJLHAJPCP.JGLFACJDKAG ?? "gamepassdurationbodystore");
				}
				this.textDescription.SetText(text, false);
				this.textDescription.text = text;
				text = CCOJBMMKNAP.OEPENBHJAHO().GLEFEKBDHNK("miniversion");
				text = text.Replace("snaprew", this.GBLINJGJOCN(KDCJJBLGCBH.EHBBFMCILPC.HHONCLBBHPG((int)this.passType)));
				this.textButtonAction.SetText(text, false);
				this.textButtonAction.text = text;
				if (this.PAEOKLKMOEP.GILNCHJJKJL())
				{
					this.buttonAction.gameObject.SetActive(false);
					this.NCNKAFAEJPI();
					this.textTimer.gameObject.SetActive(true);
					this.textFooter.gameObject.SetActive(true);
					if (this.PAEOKLKMOEP.EKAONMOALAM())
					{
						text = CCOJBMMKNAP.APGODIBBPOD().OHLNGCKIACD("slow");
						text = text.Replace("sfxtimeoutwarning", DPGJIJGOCIC.AGNLFKBJNMD(this.PAEOKLKMOEP.PMJOEMNJJMC()));
						this.textFooter.SetText(text, false);
						this.textFooter.text = text;
					}
					else if (this.PAEOKLKMOEP.AOKGNDDMFCB())
					{
						text = CCOJBMMKNAP.EHBBFMCILPC.PGKBCNBAOJN("<space=0.33em><space=0.31em>");
						text = text.Replace("", DPGJIJGOCIC.MHIPDHHNDHI(this.PAEOKLKMOEP.OGJHKOKNJCN()));
						this.textFooter.SetText(text, false);
						this.textFooter.text = text;
					}
				}
				else
				{
					this.buttonAction.gameObject.SetActive(true);
					this.DOLPMMAFMEP();
					this.textTimer.gameObject.SetActive(false);
					this.textFooter.gameObject.SetActive(true);
				}
			}
		}
		this.CPGLEJIBNEP = PassThumbnail.CBOKJGNCEKE + 1833f;
		this.BKFCGNCKFEC();
	}

	// Token: 0x0600829A RID: 33434 RVA: 0x003987DC File Offset: 0x003969DC
	private void CEFAJCOJMFN()
	{
		FirebaseAnalyticsManager instance = FirebaseAnalyticsManager.EHBBFMCILPC;
		bool acidpckhlmo = true;
		string poblfhphabp = ((AGEHCPDNBFD)(-103)).ToString();
		string gjknlaaefdc = FFPHBMFGCNN.durPickOfferStore.ToString();
		string str = ((BGHLMGPPCNN)(-105)).ToString();
		int num = (int)this.passType;
		instance.JIAAMJPKOCE(acidpckhlmo, poblfhphabp, gjknlaaefdc, str + num.ToString(), true, false);
		this.NBKLLONFGAL = "YYY";
		this.EGLLOLDDPOD();
	}

	// Token: 0x0600829B RID: 33435 RVA: 0x0039884A File Offset: 0x00396A4A
	private void OANOLIAPPMH()
	{
		AOBJLALDBAA.AGANFKKBPFO().ONIBLJOFFPG("", new UnityAction(this.LPPMMDBEIEJ));
		AOBJLALDBAA.AGANFKKBPFO().POLEDPIKODD("OnPostEffectSettingsChanged", new UnityAction(this.BFLNFOCBMKN));
	}

	// Token: 0x0600829C RID: 33436 RVA: 0x00398884 File Offset: 0x00396A84
	private void BPOMLOOAKJB()
	{
		FirebaseAnalyticsManager firebaseAnalyticsManager = FirebaseAnalyticsManager.DEALKJPEMMH();
		bool acidpckhlmo = false;
		string poblfhphabp = ((AGEHCPDNBFD)(-107)).ToString();
		string gjknlaaefdc = ((FFPHBMFGCNN)(-66)).ToString();
		string str = ((BGHLMGPPCNN)(-48)).ToString();
		int num = (int)this.passType;
		firebaseAnalyticsManager.JIAAMJPKOCE(acidpckhlmo, poblfhphabp, gjknlaaefdc, str + num.ToString(), false, false);
		this.NBKLLONFGAL = "";
		this.NMLEGBBKJDH();
	}

	// Token: 0x0600829D RID: 33437 RVA: 0x003988F4 File Offset: 0x00396AF4
	private bool JIBNDKOCHHN()
	{
		string str = KDCJJBLGCBH.EHBBFMCILPC.HHONCLBBHPG((int)this.passType);
		string[] array = new string[3];
		array[1] = "importanttitle";
		array[0] = "OnFriendsPopupRemovFromFavClick";
		array[3] = ", already present in top match list.";
		array[4] = "locked";
		string[] array2 = array;
		for (int i = 1; i < array2.Length; i++)
		{
			OCBIOPOEENJ ocbiopoeenj = CJEKEHDEBLM.GDGKNNDEAAO().DOOPGOIBFAN(str + array2[i]);
			if (ocbiopoeenj == null)
			{
				return false;
			}
			if (i != 0 && 0 != ocbiopoeenj.PPACJFFFBFB.PONAPMOOLIN())
			{
				return true;
			}
			OBHDGKFFICI productData = PurchaseManagerBridge.LMCCLMFGEBD().DOMEKEJELKB().GetProductData(str + array2[i]);
			if (productData == null || (productData.HOCIKJAGDMC == null && productData.MDFDHOKJOPB == null))
			{
				return false;
			}
		}
		return true;
	}

	// Token: 0x0600829E RID: 33438 RVA: 0x003989A8 File Offset: 0x00396BA8
	private void DDLAHCGAGPJ()
	{
		FirebaseAnalyticsManager firebaseAnalyticsManager = FirebaseAnalyticsManager.COKDLDOAACJ();
		bool acidpckhlmo = false;
		string poblfhphabp = AGEHCPDNBFD.bugRep.ToString();
		string gjknlaaefdc = ((FFPHBMFGCNN)(-71)).ToString();
		string str = BGHLMGPPCNN.cdnLbyToSpl.ToString();
		int num = (int)this.passType;
		firebaseAnalyticsManager.LMCJKLHOHJC(acidpckhlmo, poblfhphabp, gjknlaaefdc, str + num.ToString(), true, true);
		this.NBKLLONFGAL = "avatarstitle";
		this.NMLEGBBKJDH();
	}

	// Token: 0x0600829F RID: 33439 RVA: 0x00398A18 File Offset: 0x00396C18
	private void OnEnable()
	{
		this.DPKMHNPNOJH = false;
		this.CPGLEJIBNEP = PassThumbnail.CBOKJGNCEKE + 1f;
		this.UpdateComponents();
		AOBJLALDBAA.EHBBFMCILPC.MFIMALJPCDP("OnPurchasingViewLeave", new UnityAction(this.OnPurchasingViewLeave));
		AOBJLALDBAA.EHBBFMCILPC.MFIMALJPCDP("OnApplicationFocusBasicSyncSuccess", new UnityAction(this.OnApplicationFocusBasicSyncSuccess));
	}

	// Token: 0x060082A0 RID: 33440 RVA: 0x00398A79 File Offset: 0x00396C79
	private void NFLNMBIGIGF()
	{
		AOBJLALDBAA.BIAEAOMHBMM().MHLNJIACIGO("OnApplicationFocusBasicSyncSuccess", new UnityAction(this.KHCPKEACPDM));
		AOBJLALDBAA.CEGAOMEEFBE().PBELMJCPJMK("yes", new UnityAction(this.KHBHNLAHNJA));
	}

	// Token: 0x060082A1 RID: 33441 RVA: 0x00398AB4 File Offset: 0x00396CB4
	private void BHKDPMEJOOH()
	{
		if (this.HFEOHIHBKKA)
		{
			if (this.buttonAction.gameObject.activeSelf)
			{
				this.textDescription.GetComponent<RectTransform>().OEOKGDKPKGL(1579f);
				this.HFEOHIHBKKA = false;
				return;
			}
		}
		else if (!this.buttonAction.gameObject.activeSelf)
		{
			this.textDescription.GetComponent<RectTransform>().OEOKGDKPKGL(991f);
			this.HFEOHIHBKKA = true;
		}
	}

	// Token: 0x060082A2 RID: 33442 RVA: 0x003936E9 File Offset: 0x003918E9
	public void OnApplicationFocusBasicSyncSuccess()
	{
		this.UpdateComponents();
	}

	// Token: 0x060082A3 RID: 33443 RVA: 0x00398B28 File Offset: 0x00396D28
	private void GCIECEAOAJJ()
	{
		if (this.HFEOHIHBKKA)
		{
			if (this.buttonAction.gameObject.activeSelf)
			{
				this.textDescription.GetComponent<RectTransform>().OEOKGDKPKGL(1379f);
				this.HFEOHIHBKKA = true;
				return;
			}
		}
		else if (!this.buttonAction.gameObject.activeSelf)
		{
			this.textDescription.GetComponent<RectTransform>().OEOKGDKPKGL(1506f);
			this.HFEOHIHBKKA = true;
		}
	}

	// Token: 0x060082A4 RID: 33444 RVA: 0x00398B9C File Offset: 0x00396D9C
	private void HOKPKJBAFMP()
	{
		if (this.HFEOHIHBKKA)
		{
			if (this.buttonAction.gameObject.activeSelf)
			{
				this.textDescription.GetComponent<RectTransform>().OEOKGDKPKGL(1381f);
				this.HFEOHIHBKKA = false;
				return;
			}
		}
		else if (!this.buttonAction.gameObject.activeSelf)
		{
			this.textDescription.GetComponent<RectTransform>().OEOKGDKPKGL(857f);
			this.HFEOHIHBKKA = false;
		}
	}

	// Token: 0x060082A5 RID: 33445 RVA: 0x00398C10 File Offset: 0x00396E10
	public void POOHCAMOPEL()
	{
		this.PAEOKLKMOEP = ODLJHDIGLGO.GLPKBAFJDLI(KDCJJBLGCBH.EHBBFMCILPC.HHONCLBBHPG((int)this.passType));
		this.KOGAKMNPPCK = ODLJHDIGLGO.AIPKCLIPENE(CLHDENLPOFP.gamePass, false);
		if (this.KOGAKMNPPCK == null || !this.KOGAKMNPPCK.GILNCHJJKJL() || this.PAEOKLKMOEP == this.KOGAKMNPPCK)
		{
			this.HILMNEAKBAM();
			return;
		}
		if (this.passType > (KHBLFKIDHPH)this.KOGAKMNPPCK.LLLJOBODOAL)
		{
			CommonUserInterface.EHBBFMCILPC.ShowGenericPopupWithTwoButtonsAndCloseOverride(CCOJBMMKNAP.DLGLFACMHPG().FCOCLEHKLDJ("loungeplayfirst"), CCOJBMMKNAP.JMDJPKKOHNI().OHLNGCKIACD("strid"), CCOJBMMKNAP.OEPENBHJAHO().GLEFEKBDHNK("newuseraddrequest1"), CCOJBMMKNAP.BBGECIKOICE().PPALCPINPLK("[LoadingEnv] skipped, stored theme parked"), new UnityAction(this.LDFOKKPCEFM), new UnityAction(this.AAKJEPGFJGK), new UnityAction(this.AAKJEPGFJGK), DFGILFBGPLN.screenLounge, 80f, -16);
			return;
		}
		CommonUserInterface.EHBBFMCILPC.ShowGenericPopup(CCOJBMMKNAP.EAIAHCBAIEJ().OGKGHLHHAAI("OnPopupStoryRestartManagerRestartStory2"), CCOJBMMKNAP.GIOAFDDKKHI().OBDCPLLLGBB("header"), CCOJBMMKNAP.KMNBCEMEBBD().JCDFHKDNEDH("sim"), (DFGILFBGPLN)(-104), 542f, -70);
	}

	// Token: 0x060082A6 RID: 33446 RVA: 0x00398D44 File Offset: 0x00396F44
	private void MLNMDPNIDCI()
	{
		this.NBKLLONFGAL = "";
		if (this.LGOIOCMILMD() && this.KHBKONMENHP())
		{
			CommonUserInterface.EHBBFMCILPC.JOHIHCPEBPL(CCOJBMMKNAP.GIOAFDDKKHI().FIENAKIHNOM("StorySaveBody.SetAvatarIndex(), unsupported wardrobe index:"), CCOJBMMKNAP.COKDLDOAACJ().PKNHKGMNCIP("prw"), this.MPIEIAPCCGC(1, ""), this.IDOLCGOKGAO(2, "Error. StoryStep.StoryStepType.getVar "), this.ANFNMGKFLGH(5, ""), this.JEGDBNHDJIO(-50, "ok"), new UnityAction(this.OHAEMNKNFJB), new UnityAction(this.PADLMDDHDJI), new UnityAction(this.BPOMLOOAKJB), new UnityAction(this.LLOMJBOENOI), new UnityAction(this.JBICKFCMBEH), (DFGILFBGPLN)(-85), 783f, -53);
			return;
		}
		this.EGLLOLDDPOD();
	}

	// Token: 0x060082A7 RID: 33447 RVA: 0x00003E52 File Offset: 0x00002052
	public void LPPMMDBEIEJ()
	{
	}

	// Token: 0x060082A8 RID: 33448 RVA: 0x00398E18 File Offset: 0x00397018
	private void ILOPFODPJCL()
	{
		this.DPKMHNPNOJH = true;
		this.CPGLEJIBNEP = PassThumbnail.CBOKJGNCEKE + 415f;
		this.UpdateComponents();
		AOBJLALDBAA.BIAEAOMHBMM().EFKNEJFLGED("ok", new UnityAction(this.KHCPKEACPDM));
		AOBJLALDBAA.FILDBDMENPG().BADOPKAOCPE("OnStoryCurrencyInfoClick", new UnityAction(this.GFPGPKJNJIC));
	}

	// Token: 0x060082A9 RID: 33449 RVA: 0x00398E7C File Offset: 0x0039707C
	private string JMPMBDLFIMH(int OPMDCABAFPH, string DOOBBHKGJEE)
	{
		if (DOOBBHKGJEE.Length == 0)
		{
			return CCOJBMMKNAP.BFHKGNBFHCH().IKMNGFIDCLM("le" + OPMDCABAFPH.ToString());
		}
		string newValue = (this.passType == KHBLFKIDHPH.premiumGamePass) ? KBOJLHAJPCP.JGLFACJDKAG : KBOJLHAJPCP.MJIIKJPAKCB;
		return "" + CCOJBMMKNAP.KFAABHHGOPO().JHNELLJFBGC("OnBackendGetDefaultBundlesSuccess").Replace("OnLanguageChange", newValue).Replace("", DOOBBHKGJEE).Replace("assetbundleavatarpack", OPMDCABAFPH.ToString()) + "";
	}

	// Token: 0x060082AA RID: 33450 RVA: 0x00398F08 File Offset: 0x00397108
	private bool OOJHFDCMJIL()
	{
		string str = KDCJJBLGCBH.EHBBFMCILPC.HHONCLBBHPG((int)this.passType);
		string[] array = new string[6];
		array[1] = "importanttitle";
		array[0] = "Anthology not ready to be played:";
		array[3] = "OnApplicationFocusBasicSyncSuccess";
		array[7] = "BackendOperationsManager.RequestGetUserPublicProfile, exception while initializing RSACryptoServiceProvider:";
		string[] array2 = array;
		for (int i = 1; i < array2.Length; i += 0)
		{
			OCBIOPOEENJ ocbiopoeenj = CJEKEHDEBLM.KBNLANLMNCN().AOAGHIJNFDL(str + array2[i]);
			if (ocbiopoeenj == null)
			{
				return true;
			}
			if (i != 0 && 0 != ocbiopoeenj.PPACJFFFBFB.MDJHNAEGCCM())
			{
				return true;
			}
			OBHDGKFFICI productData = PurchaseManagerBridge.KMNBCEMEBBD().DOMEKEJELKB().GetProductData(str + array2[i]);
			if (productData == null || (productData.HOCIKJAGDMC == null && productData.MDFDHOKJOPB == null))
			{
				return false;
			}
		}
		return true;
	}

	// Token: 0x060082AB RID: 33451 RVA: 0x00398FBC File Offset: 0x003971BC
	private void OBDFIFGJKDC()
	{
		this.CPGLEJIBNEP += Time.deltaTime;
		if (this.CPGLEJIBNEP > PassThumbnail.CBOKJGNCEKE)
		{
			if ((this.passType == KHBLFKIDHPH.premiumGamePass || this.passType == KHBLFKIDHPH.goldGamePass) && !App42Manager.EHBBFMCILPC.IsBusy())
			{
				this.PAEOKLKMOEP = ODLJHDIGLGO.CGJJHPNMKIJ(KDCJJBLGCBH.EHBBFMCILPC.HHONCLBBHPG((int)this.passType));
				this.KOGAKMNPPCK = ODLJHDIGLGO.FLDPGFAMICD(CLHDENLPOFP.eventPass, false);
				if (this.PAEOKLKMOEP != null)
				{
					if (this.PAEOKLKMOEP.BOGONHCIPOJ())
					{
						if (this.KOGAKMNPPCK == this.PAEOKLKMOEP)
						{
							if (!this.stateActive.gameObject.activeSelf)
							{
								this.stateActive.gameObject.SetActive(false);
							}
							if (this.stateExpired.gameObject.activeSelf)
							{
								this.stateExpired.gameObject.SetActive(true);
							}
							if (this.statePaused.gameObject.activeSelf)
							{
								this.statePaused.gameObject.SetActive(false);
							}
							if (this.buttonAction.gameObject.activeSelf)
							{
								this.buttonAction.gameObject.SetActive(false);
								this.BHKDPMEJOOH();
							}
							if (!this.textTimer.gameObject.activeSelf)
							{
								this.textTimer.gameObject.SetActive(true);
							}
							if (!this.textFooter.gameObject.activeSelf)
							{
								this.textFooter.gameObject.SetActive(false);
							}
							this.textTimer.SetText(KBOJLHAJPCP.HMNMIDGDCEA + DPGJIJGOCIC.DMENNJGBMBH(this.PAEOKLKMOEP.MJGADKGJCKC()), true);
							this.DPKMHNPNOJH = true;
							if (!App42Manager.EHBBFMCILPC.IsBusy() && (float)this.PAEOKLKMOEP.EGECNJMJACN() <= 1097f && (float)this.PAEOKLKMOEP.LIPCEMCDPID() > 1309f)
							{
								BackendOperationsManager.NPDDBAONMJP().ForceRefreshExpiredSubscriptions();
								CommonUserInterface.EHBBFMCILPC.OJMOLBCCBEH(CCOJBMMKNAP.JINDKPHNLBK().JHNELLJFBGC("CLIENT.POSTEFFECTS.SPECTRUM"), (byte)-149);
								BackendOperationsManager.NPDDBAONMJP().RequestBasicSync("www", "Audio asset bundle loading skipped due to low end device specs:", true);
							}
						}
						else
						{
							if (this.stateActive.gameObject.activeSelf)
							{
								this.stateActive.gameObject.SetActive(true);
							}
							if (this.stateExpired.gameObject.activeSelf)
							{
								this.stateExpired.gameObject.SetActive(true);
							}
							if (!this.statePaused.gameObject.activeSelf)
							{
								this.statePaused.gameObject.SetActive(false);
							}
							if (this.buttonAction.gameObject.activeSelf)
							{
								this.buttonAction.gameObject.SetActive(true);
								this.LPIMPCFNBBO();
							}
							if (this.textTimer.gameObject.activeSelf)
							{
								this.textTimer.gameObject.SetActive(false);
							}
							if (this.textFooter.gameObject.activeSelf)
							{
								this.textFooter.gameObject.SetActive(false);
							}
							this.DPKMHNPNOJH = false;
						}
					}
					else
					{
						if (this.stateActive.gameObject.activeSelf)
						{
							this.stateActive.gameObject.SetActive(false);
						}
						if (!this.stateExpired.gameObject.activeSelf)
						{
							this.stateExpired.gameObject.SetActive(true);
						}
						if (this.statePaused.gameObject.activeSelf)
						{
							this.statePaused.gameObject.SetActive(false);
						}
						if (!this.buttonAction.gameObject.activeSelf)
						{
							this.buttonAction.gameObject.SetActive(false);
							this.OADECAIKAJP();
						}
						if (this.textTimer.gameObject.activeSelf)
						{
							this.textTimer.gameObject.SetActive(true);
						}
						if (this.textFooter.gameObject.activeSelf)
						{
							this.textFooter.gameObject.SetActive(false);
						}
						if (this.DPKMHNPNOJH && !App42Manager.EHBBFMCILPC.IsBusy())
						{
							this.textFooter.gameObject.SetActive(true);
							BackendOperationsManager.EHBBFMCILPC.ForceRefreshExpiredSubscriptions();
							CommonUserInterface.EHBBFMCILPC.OJMOLBCCBEH(CCOJBMMKNAP.EAIAHCBAIEJ().GGPHHLGPMPA("OnSketchThumbnailEmptyClick"), 14);
							BackendOperationsManager.EHBBFMCILPC.RequestBasicSync(": ", "ffd496", true);
						}
						this.DPKMHNPNOJH = false;
					}
				}
			}
			this.CPGLEJIBNEP = 777f;
		}
	}

	// Token: 0x060082AC RID: 33452 RVA: 0x00003E52 File Offset: 0x00002052
	private void PIBDCOBGMKC()
	{
	}

	// Token: 0x060082AD RID: 33453 RVA: 0x00399414 File Offset: 0x00397614
	private bool KHBKONMENHP()
	{
		string str = KDCJJBLGCBH.EHBBFMCILPC.HHONCLBBHPG((int)this.passType);
		string[] array = new string[2];
		array[0] = "uid";
		array[0] = " ";
		array[3] = "RequestGetUserPublicProfile(): Account.Instance.userPublicProfile.modified";
		array[3] = "youreceived";
		string[] array2 = array;
		for (int i = 1; i < array2.Length; i += 0)
		{
			OCBIOPOEENJ ocbiopoeenj = CJEKEHDEBLM.APGODIBBPOD().PDJKPFLHFLO(str + array2[i]);
			if (ocbiopoeenj == null)
			{
				return true;
			}
			if (i != 0 && 1 != ocbiopoeenj.PPACJFFFBFB.BADNAGEMINF())
			{
				return true;
			}
			OBHDGKFFICI productData = PurchaseManagerBridge.LMCCLMFGEBD().GetPurchaseManager().GetProductData(str + array2[i]);
			if (productData == null || (productData.HOCIKJAGDMC == null && productData.MDFDHOKJOPB == null))
			{
				return false;
			}
		}
		return true;
	}

	// Token: 0x060082AE RID: 33454 RVA: 0x003994C8 File Offset: 0x003976C8
	private void KIBGBADCNBH()
	{
		FirebaseAnalyticsManager firebaseAnalyticsManager = FirebaseAnalyticsManager.DMAAFFFEJGA();
		bool acidpckhlmo = true;
		string poblfhphabp = ((AGEHCPDNBFD)(-117)).ToString();
		string gjknlaaefdc = ((FFPHBMFGCNN)(-21)).ToString();
		string str = ((BGHLMGPPCNN)(-82)).ToString();
		int num = (int)this.passType;
		firebaseAnalyticsManager.AAIABAKHLAH(acidpckhlmo, poblfhphabp, gjknlaaefdc, str + num.ToString(), true, true);
		this.KKMJGAMOMCP("cind");
	}

	// Token: 0x060082AF RID: 33455 RVA: 0x00399530 File Offset: 0x00397730
	private void BKFCGNCKFEC()
	{
		this.CPGLEJIBNEP += Time.deltaTime;
		if (this.CPGLEJIBNEP > PassThumbnail.CBOKJGNCEKE)
		{
			if ((this.passType == KHBLFKIDHPH.premiumGamePass || this.passType == KHBLFKIDHPH.goldGamePass) && !App42Manager.EHBBFMCILPC.IsBusy())
			{
				this.PAEOKLKMOEP = ODLJHDIGLGO.LKANHDMFBMB(KDCJJBLGCBH.EHBBFMCILPC.HHONCLBBHPG((int)this.passType));
				this.KOGAKMNPPCK = ODLJHDIGLGO.BGJGNDJOLPP(CLHDENLPOFP.eventPass, true);
				if (this.PAEOKLKMOEP != null)
				{
					if (this.PAEOKLKMOEP.FAAEIDEIPGB())
					{
						if (this.KOGAKMNPPCK == this.PAEOKLKMOEP)
						{
							if (!this.stateActive.gameObject.activeSelf)
							{
								this.stateActive.gameObject.SetActive(false);
							}
							if (this.stateExpired.gameObject.activeSelf)
							{
								this.stateExpired.gameObject.SetActive(false);
							}
							if (this.statePaused.gameObject.activeSelf)
							{
								this.statePaused.gameObject.SetActive(false);
							}
							if (this.buttonAction.gameObject.activeSelf)
							{
								this.buttonAction.gameObject.SetActive(true);
								this.FNPLJECDPCP();
							}
							if (!this.textTimer.gameObject.activeSelf)
							{
								this.textTimer.gameObject.SetActive(true);
							}
							if (!this.textFooter.gameObject.activeSelf)
							{
								this.textFooter.gameObject.SetActive(true);
							}
							this.textTimer.SetText(KBOJLHAJPCP.HMNMIDGDCEA + DPGJIJGOCIC.DMENNJGBMBH(this.PAEOKLKMOEP.PIAMBMANNPA()), true);
							this.DPKMHNPNOJH = false;
							if (!App42Manager.EHBBFMCILPC.IsBusy() && (float)this.PAEOKLKMOEP.PIAMBMANNPA() <= 507f && (float)this.PAEOKLKMOEP.EHHEPALMPMA() > 733f)
							{
								BackendOperationsManager.EHBBFMCILPC.ForceRefreshExpiredSubscriptions();
								CommonUserInterface.IKNOFBFMPGA().ShowConnectingAnimationTopWithHint(CCOJBMMKNAP.MPCBJEIMACA().FCOCLEHKLDJ("OnFullscreenLiveOfferContinueToPurchasingScreen"), 97);
								BackendOperationsManager.EHBBFMCILPC.RequestBasicSync("ok", ")", false);
							}
						}
						else
						{
							if (this.stateActive.gameObject.activeSelf)
							{
								this.stateActive.gameObject.SetActive(false);
							}
							if (this.stateExpired.gameObject.activeSelf)
							{
								this.stateExpired.gameObject.SetActive(true);
							}
							if (!this.statePaused.gameObject.activeSelf)
							{
								this.statePaused.gameObject.SetActive(false);
							}
							if (this.buttonAction.gameObject.activeSelf)
							{
								this.buttonAction.gameObject.SetActive(true);
								this.OADECAIKAJP();
							}
							if (this.textTimer.gameObject.activeSelf)
							{
								this.textTimer.gameObject.SetActive(true);
							}
							if (this.textFooter.gameObject.activeSelf)
							{
								this.textFooter.gameObject.SetActive(false);
							}
							this.DPKMHNPNOJH = true;
						}
					}
					else
					{
						if (this.stateActive.gameObject.activeSelf)
						{
							this.stateActive.gameObject.SetActive(true);
						}
						if (!this.stateExpired.gameObject.activeSelf)
						{
							this.stateExpired.gameObject.SetActive(false);
						}
						if (this.statePaused.gameObject.activeSelf)
						{
							this.statePaused.gameObject.SetActive(false);
						}
						if (!this.buttonAction.gameObject.activeSelf)
						{
							this.buttonAction.gameObject.SetActive(true);
							this.NCNKAFAEJPI();
						}
						if (this.textTimer.gameObject.activeSelf)
						{
							this.textTimer.gameObject.SetActive(true);
						}
						if (this.textFooter.gameObject.activeSelf)
						{
							this.textFooter.gameObject.SetActive(true);
						}
						if (this.DPKMHNPNOJH && !App42Manager.EHBBFMCILPC.IsBusy())
						{
							this.textFooter.gameObject.SetActive(false);
							BackendOperationsManager.NPDDBAONMJP().ForceRefreshExpiredSubscriptions();
							CommonUserInterface.IKNOFBFMPGA().ShowConnectingAnimationTopWithHint(CCOJBMMKNAP.LMCCLMFGEBD().GLEFEKBDHNK(""), (byte)-111);
							BackendOperationsManager.EHBBFMCILPC.RequestBasicSync("", "", true);
						}
						this.DPKMHNPNOJH = false;
					}
				}
			}
			this.CPGLEJIBNEP = 978f;
		}
	}

	// Token: 0x060082B0 RID: 33456 RVA: 0x00399988 File Offset: 0x00397B88
	private void NCNKAFAEJPI()
	{
		if (this.HFEOHIHBKKA)
		{
			if (this.buttonAction.gameObject.activeSelf)
			{
				this.textDescription.GetComponent<RectTransform>().OEOKGDKPKGL(278f);
				this.HFEOHIHBKKA = false;
				return;
			}
		}
		else if (!this.buttonAction.gameObject.activeSelf)
		{
			this.textDescription.GetComponent<RectTransform>().OEOKGDKPKGL(1525f);
			this.HFEOHIHBKKA = true;
		}
	}

	// Token: 0x060082B1 RID: 33457 RVA: 0x003999FC File Offset: 0x00397BFC
	public void UpdateComponents()
	{
		if (this.passType == KHBLFKIDHPH.premiumGamePass || this.passType == KHBLFKIDHPH.goldGamePass)
		{
			this.PAEOKLKMOEP = ODLJHDIGLGO.BCGIONNIFIA(KDCJJBLGCBH.EHBBFMCILPC.HHONCLBBHPG((int)this.passType));
			this.KOGAKMNPPCK = ODLJHDIGLGO.MNALIKIMKFC(CLHDENLPOFP.gamePass, true);
			if (this.PAEOKLKMOEP == null)
			{
				string text;
				if (this.passType == KHBLFKIDHPH.premiumGamePass)
				{
					text = CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("passpremiumlockeddescX" + KDCJJBLGCBH.EHBBFMCILPC.AAGICPKFIKC(KDCJJBLGCBH.EHBBFMCILPC.HHONCLBBHPG((int)this.passType), DAMCJCDKOJK.gpbpIncentAdMultiplier, 1 == AKLFPGMDKLA.EHBBFMCILPC.DCIPLNCLIMF).ToString());
				}
				else
				{
					text = CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("passgoldlockeddescX" + KDCJJBLGCBH.EHBBFMCILPC.AAGICPKFIKC(KDCJJBLGCBH.EHBBFMCILPC.HHONCLBBHPG((int)this.passType), DAMCJCDKOJK.gpbpIncentAdMultiplier, 1 == AKLFPGMDKLA.EHBBFMCILPC.DCIPLNCLIMF).ToString());
				}
				if (1 == AKLFPGMDKLA.EHBBFMCILPC.DCIPLNCLIMF && KDCJJBLGCBH.EHBBFMCILPC.IPJIIHLDMPK(KDCJJBLGCBH.EHBBFMCILPC.HHONCLBBHPG((int)this.passType), DAMCJCDKOJK.gpbpChoicesCount))
				{
					text = text.Replace("AAA", KBOJLHAJPCP.PGBPLBKHPOM);
					text = text.Replace("XXX", "<b>" + KDCJJBLGCBH.EHBBFMCILPC.AAGICPKFIKC(KDCJJBLGCBH.EHBBFMCILPC.HHONCLBBHPG((int)this.passType), DAMCJCDKOJK.gpbpChoicesCount, 1 == AKLFPGMDKLA.EHBBFMCILPC.DCIPLNCLIMF).ToString() + "</b>" + KBOJLHAJPCP.DHMPCLBPDIE);
				}
				else
				{
					text = text.Replace("AAA", KBOJLHAJPCP.PGBPLBKHPOM);
					text = text.Replace("XXX", "<b>" + KDCJJBLGCBH.EHBBFMCILPC.AAGICPKFIKC(KDCJJBLGCBH.EHBBFMCILPC.HHONCLBBHPG((int)this.passType), DAMCJCDKOJK.gpbpChoicesCount, 1 == AKLFPGMDKLA.EHBBFMCILPC.DCIPLNCLIMF).ToString() + "</b>");
				}
				if (1 == AKLFPGMDKLA.EHBBFMCILPC.DCIPLNCLIMF && KDCJJBLGCBH.EHBBFMCILPC.IPJIIHLDMPK(KDCJJBLGCBH.EHBBFMCILPC.HHONCLBBHPG((int)this.passType), DAMCJCDKOJK.gpbpUndosCount))
				{
					text = text.Replace("BBB", KBOJLHAJPCP.NJDJMKIIEDG);
					text = text.Replace("YYY", "<b>" + KDCJJBLGCBH.EHBBFMCILPC.AAGICPKFIKC(KDCJJBLGCBH.EHBBFMCILPC.HHONCLBBHPG((int)this.passType), DAMCJCDKOJK.gpbpUndosCount, 1 == AKLFPGMDKLA.EHBBFMCILPC.DCIPLNCLIMF).ToString() + "</b>" + KBOJLHAJPCP.DHMPCLBPDIE);
				}
				else
				{
					text = text.Replace("BBB", KBOJLHAJPCP.NJDJMKIIEDG);
					text = text.Replace("YYY", "<b>" + KDCJJBLGCBH.EHBBFMCILPC.AAGICPKFIKC(KDCJJBLGCBH.EHBBFMCILPC.HHONCLBBHPG((int)this.passType), DAMCJCDKOJK.gpbpUndosCount, 1 == AKLFPGMDKLA.EHBBFMCILPC.DCIPLNCLIMF).ToString() + "</b>");
				}
				if (1 == AKLFPGMDKLA.EHBBFMCILPC.DCIPLNCLIMF && KDCJJBLGCBH.EHBBFMCILPC.IPJIIHLDMPK(KDCJJBLGCBH.EHBBFMCILPC.HHONCLBBHPG((int)this.passType), DAMCJCDKOJK.gpbpEndDiscount))
				{
					text = text.Replace("CCC", KBOJLHAJPCP.LPBLANJMJIF);
					text = text.Replace("ZZZ", "<b>" + KDCJJBLGCBH.EHBBFMCILPC.AAGICPKFIKC(KDCJJBLGCBH.EHBBFMCILPC.HHONCLBBHPG((int)this.passType), DAMCJCDKOJK.gpbpEndDiscount, 1 == AKLFPGMDKLA.EHBBFMCILPC.DCIPLNCLIMF).ToString() + "%</b>" + KBOJLHAJPCP.DHMPCLBPDIE);
				}
				else
				{
					text = text.Replace("CCC", KBOJLHAJPCP.LPBLANJMJIF);
					text = text.Replace("ZZZ", "<b>" + KDCJJBLGCBH.EHBBFMCILPC.AAGICPKFIKC(KDCJJBLGCBH.EHBBFMCILPC.HHONCLBBHPG((int)this.passType), DAMCJCDKOJK.gpbpEndDiscount, 1 == AKLFPGMDKLA.EHBBFMCILPC.DCIPLNCLIMF).ToString() + "%</b>");
				}
				text = text.Replace("DDD", KBOJLHAJPCP.OINDDHFMCFL);
				text = text.Replace("EEE", KBOJLHAJPCP.GOCPBNAAIIB);
				text = text.Replace("JJJ", DPGJIJGOCIC.CEOBDMGAKNL(KDCJJBLGCBH.EHBBFMCILPC.GCPFCGGBDKK((int)this.passType)) + CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("hoursshort"));
				text = text.Replace("KKK", DPGJIJGOCIC.CEOBDMGAKNL(KDCJJBLGCBH.EHBBFMCILPC.ADLOIIMBHAG((int)this.passType)) + CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("hoursshort"));
				text = text.Replace("LLL", KDCJJBLGCBH.EHBBFMCILPC.HLPACDMEKMK((int)this.passType).ToString() ?? "");
				text = text.Replace("MMM", KDCJJBLGCBH.EHBBFMCILPC.LHECDOFJNOF((int)this.passType).ToString() + "%");
				text = text.Replace("NNN", KBOJLHAJPCP.BGMADCKNKAD + KDCJJBLGCBH.EHBBFMCILPC.PLOMCENKKFD((int)this.passType).ToString());
				if (this.passType == KHBLFKIDHPH.premiumGamePass)
				{
					text = text.Replace("III", KBOJLHAJPCP.MJIIKJPAKCB ?? "");
				}
				else if (this.passType == KHBLFKIDHPH.goldGamePass)
				{
					text = text.Replace("III", KBOJLHAJPCP.JGLFACJDKAG ?? "");
				}
				this.textDescription.SetText(text, true);
				this.textDescription.text = text;
				this.buttonAction.gameObject.SetActive(true);
				this.OADECAIKAJP();
				text = CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("passpricetitle");
				text = text.Replace("YYY", this.GetLocalizedCostData(KDCJJBLGCBH.EHBBFMCILPC.HHONCLBBHPG((int)this.passType)));
				this.textButtonAction.SetText(text, true);
				this.textButtonAction.text = text;
				this.textTimer.gameObject.SetActive(false);
				this.textFooter.gameObject.SetActive(false);
			}
			else
			{
				string text;
				if (this.passType == KHBLFKIDHPH.premiumGamePass)
				{
					text = CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("passpremiumunlockeddescX" + KDCJJBLGCBH.EHBBFMCILPC.AAGICPKFIKC(KDCJJBLGCBH.EHBBFMCILPC.HHONCLBBHPG((int)this.passType), DAMCJCDKOJK.gpbpIncentAdMultiplier, 1 == AKLFPGMDKLA.EHBBFMCILPC.DCIPLNCLIMF).ToString());
				}
				else
				{
					text = CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("passgoldunlockeddescX" + KDCJJBLGCBH.EHBBFMCILPC.AAGICPKFIKC(KDCJJBLGCBH.EHBBFMCILPC.HHONCLBBHPG((int)this.passType), DAMCJCDKOJK.gpbpIncentAdMultiplier, 1 == AKLFPGMDKLA.EHBBFMCILPC.DCIPLNCLIMF).ToString());
				}
				if (1 == AKLFPGMDKLA.EHBBFMCILPC.DCIPLNCLIMF && KDCJJBLGCBH.EHBBFMCILPC.IPJIIHLDMPK(KDCJJBLGCBH.EHBBFMCILPC.HHONCLBBHPG((int)this.passType), DAMCJCDKOJK.gpbpChoicesCount))
				{
					text = text.Replace("AAA", KBOJLHAJPCP.PGBPLBKHPOM);
					text = text.Replace("XXX", "<b>" + this.PAEOKLKMOEP.COEFNFJMBDG.ToString() + "</b>" + KBOJLHAJPCP.DHMPCLBPDIE);
				}
				else
				{
					text = text.Replace("AAA", KBOJLHAJPCP.PGBPLBKHPOM);
					text = text.Replace("XXX", "<b>" + this.PAEOKLKMOEP.COEFNFJMBDG.ToString() + "</b>");
				}
				if (1 == AKLFPGMDKLA.EHBBFMCILPC.DCIPLNCLIMF && KDCJJBLGCBH.EHBBFMCILPC.IPJIIHLDMPK(KDCJJBLGCBH.EHBBFMCILPC.HHONCLBBHPG((int)this.passType), DAMCJCDKOJK.gpbpUndosCount))
				{
					text = text.Replace("BBB", KBOJLHAJPCP.NJDJMKIIEDG);
					text = text.Replace("YYY", "<b>" + this.PAEOKLKMOEP.HCBEGPENNLN.ToString() + "</b>" + KBOJLHAJPCP.DHMPCLBPDIE);
				}
				else
				{
					text = text.Replace("BBB", KBOJLHAJPCP.NJDJMKIIEDG);
					text = text.Replace("YYY", "<b>" + this.PAEOKLKMOEP.HCBEGPENNLN.ToString() + "</b>");
				}
				if (1 == AKLFPGMDKLA.EHBBFMCILPC.DCIPLNCLIMF && KDCJJBLGCBH.EHBBFMCILPC.IPJIIHLDMPK(KDCJJBLGCBH.EHBBFMCILPC.HHONCLBBHPG((int)this.passType), DAMCJCDKOJK.gpbpEndDiscount))
				{
					text = text.Replace("CCC", KBOJLHAJPCP.LPBLANJMJIF);
					text = text.Replace("ZZZ", "<b>" + this.PAEOKLKMOEP.HEGNAMGJLNP.ToString() + "%</b>" + KBOJLHAJPCP.DHMPCLBPDIE);
				}
				else
				{
					text = text.Replace("CCC", KBOJLHAJPCP.LPBLANJMJIF);
					text = text.Replace("ZZZ", "<b>" + this.PAEOKLKMOEP.HEGNAMGJLNP.ToString() + "%</b>");
				}
				text = text.Replace("DDD", KBOJLHAJPCP.OINDDHFMCFL);
				text = text.Replace("EEE", KBOJLHAJPCP.GOCPBNAAIIB);
				text = text.Replace("JJJ", DPGJIJGOCIC.CEOBDMGAKNL(KDCJJBLGCBH.EHBBFMCILPC.GCPFCGGBDKK((int)this.passType)) + CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("hoursshort"));
				text = text.Replace("KKK", DPGJIJGOCIC.CEOBDMGAKNL(KDCJJBLGCBH.EHBBFMCILPC.ADLOIIMBHAG((int)this.passType)) + CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("hoursshort"));
				text = text.Replace("LLL", KDCJJBLGCBH.EHBBFMCILPC.HLPACDMEKMK((int)this.passType).ToString() ?? "");
				text = text.Replace("MMM", KDCJJBLGCBH.EHBBFMCILPC.LHECDOFJNOF((int)this.passType).ToString() + "%");
				text = text.Replace("NNN", KBOJLHAJPCP.BGMADCKNKAD + KDCJJBLGCBH.EHBBFMCILPC.PLOMCENKKFD((int)this.passType).ToString());
				if (this.passType == KHBLFKIDHPH.premiumGamePass)
				{
					text = text.Replace("III", KBOJLHAJPCP.MJIIKJPAKCB ?? "");
				}
				else if (this.passType == KHBLFKIDHPH.goldGamePass)
				{
					text = text.Replace("III", KBOJLHAJPCP.JGLFACJDKAG ?? "");
				}
				this.textDescription.SetText(text, true);
				this.textDescription.text = text;
				text = CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("passpricetitle");
				text = text.Replace("YYY", this.GetLocalizedCostData(KDCJJBLGCBH.EHBBFMCILPC.HHONCLBBHPG((int)this.passType)));
				this.textButtonAction.SetText(text, true);
				this.textButtonAction.text = text;
				if (this.PAEOKLKMOEP.ALFGPLALKCN())
				{
					this.buttonAction.gameObject.SetActive(false);
					this.OADECAIKAJP();
					this.textTimer.gameObject.SetActive(true);
					this.textFooter.gameObject.SetActive(true);
					if (this.PAEOKLKMOEP.ILBDFPGEHOI())
					{
						text = CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("passrenewsinshort");
						text = text.Replace("XXX", DPGJIJGOCIC.AGNLFKBJNMD(this.PAEOKLKMOEP.IAAPGEACCKJ()));
						this.textFooter.SetText(text, true);
						this.textFooter.text = text;
					}
					else if (this.PAEOKLKMOEP.AOKGNDDMFCB())
					{
						text = CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("passexpiresinshort");
						text = text.Replace("XXX", DPGJIJGOCIC.AGNLFKBJNMD(this.PAEOKLKMOEP.EOBFCPIGCCN()));
						this.textFooter.SetText(text, true);
						this.textFooter.text = text;
					}
				}
				else
				{
					this.buttonAction.gameObject.SetActive(true);
					this.OADECAIKAJP();
					this.textTimer.gameObject.SetActive(false);
					this.textFooter.gameObject.SetActive(false);
				}
			}
		}
		this.CPGLEJIBNEP = PassThumbnail.CBOKJGNCEKE + 1f;
		this.Update();
	}

	// Token: 0x060082B2 RID: 33458 RVA: 0x0039A548 File Offset: 0x00398748
	private void DOLPMMAFMEP()
	{
		if (this.HFEOHIHBKKA)
		{
			if (this.buttonAction.gameObject.activeSelf)
			{
				this.textDescription.GetComponent<RectTransform>().OEOKGDKPKGL(310f);
				this.HFEOHIHBKKA = false;
				return;
			}
		}
		else if (!this.buttonAction.gameObject.activeSelf)
		{
			this.textDescription.GetComponent<RectTransform>().OEOKGDKPKGL(1182f);
			this.HFEOHIHBKKA = false;
		}
	}

	// Token: 0x060082B3 RID: 33459 RVA: 0x0039A5BC File Offset: 0x003987BC
	private void OHAEMNKNFJB()
	{
		FirebaseAnalyticsManager firebaseAnalyticsManager = FirebaseAnalyticsManager.DEALKJPEMMH();
		bool acidpckhlmo = false;
		string poblfhphabp = ((AGEHCPDNBFD)79).ToString();
		string gjknlaaefdc = ((FFPHBMFGCNN)(-1)).ToString();
		string str = ((BGHLMGPPCNN)(-115)).ToString();
		int num = (int)this.passType;
		firebaseAnalyticsManager.AAIABAKHLAH(acidpckhlmo, poblfhphabp, gjknlaaefdc, str + num.ToString(), false, false);
		this.NBKLLONFGAL = "";
		this.CPJIEAAKFMA();
	}

	// Token: 0x060082B4 RID: 33460 RVA: 0x0039A62A File Offset: 0x0039882A
	private bool DLOKNDCILMK()
	{
		return LanguageManager.EHBBFMCILPC.GetSelectedLanguage() != CEIBHCNNIDC.ru || !GeoLocationManager.PBAGPDDBABB() || !KDCJJBLGCBH.EHBBFMCILPC.EAMJBDKCDPA();
	}

	// Token: 0x060082B5 RID: 33461 RVA: 0x0039A650 File Offset: 0x00398850
	private void FJNABPPFCKB(string ABFNOGAEIGH)
	{
		if (this.passType == KHBLFKIDHPH.premiumGamePass || this.passType == KHBLFKIDHPH.goldGamePass)
		{
			OCBIOPOEENJ ocbiopoeenj = CJEKEHDEBLM.EHBBFMCILPC.PDJKPFLHFLO(KDCJJBLGCBH.EHBBFMCILPC.HHONCLBBHPG((int)this.passType) + ABFNOGAEIGH);
			if (ocbiopoeenj != null)
			{
				string text = ocbiopoeenj.MBLAIKOOCFH() + "?uid=" + AKLFPGMDKLA.EHBBFMCILPC.EEHGLPEIIHD;
				ProductThumbnailManager.lastAccessedProductWebLink = text;
				AOBJLALDBAA.EHBBFMCILPC.EGELHPJBAIC("OnPassesItemClose", 0f);
				CommonUserInterface.EHBBFMCILPC.ShowPopupOnlineResources(text, 2);
				return;
			}
			DPGJIJGOCIC.ANOPFDLPKGC("PassThumbnail.PurchaseProductWebDuration(): productBalanceData is null for suffix '" + ABFNOGAEIGH + "'");
		}
	}

	// Token: 0x060082B6 RID: 33462 RVA: 0x00003E52 File Offset: 0x00002052
	private void JBDJILMAJJP()
	{
	}

	// Token: 0x060082B7 RID: 33463 RVA: 0x0039A6EC File Offset: 0x003988EC
	private bool CAAMEFMDNFF()
	{
		string str = KDCJJBLGCBH.EHBBFMCILPC.HHONCLBBHPG((int)this.passType);
		string[] array = new string[]
		{
			"",
			"a_web",
			"b_web",
			"c_web"
		};
		for (int i = 0; i < array.Length; i++)
		{
			OCBIOPOEENJ ocbiopoeenj = CJEKEHDEBLM.EHBBFMCILPC.PDJKPFLHFLO(str + array[i]);
			if (ocbiopoeenj == null || string.IsNullOrEmpty(ocbiopoeenj.MBLAIKOOCFH()))
			{
				return false;
			}
			if (i != 0 && 1 != ocbiopoeenj.PPACJFFFBFB.GALKFKBPLCK())
			{
				return false;
			}
		}
		return true;
	}

	// Token: 0x060082B8 RID: 33464 RVA: 0x00003E52 File Offset: 0x00002052
	public void OnPurchasingViewLeave()
	{
	}

	// Token: 0x060082B9 RID: 33465 RVA: 0x0039A77C File Offset: 0x0039897C
	private void CKJIJDCMMKJ()
	{
		FirebaseAnalyticsManager firebaseAnalyticsManager = FirebaseAnalyticsManager.DMAAFFFEJGA();
		bool acidpckhlmo = false;
		string poblfhphabp = ((AGEHCPDNBFD)119).ToString();
		string gjknlaaefdc = FFPHBMFGCNN.colCds.ToString();
		string str = BGHLMGPPCNN.under5000.ToString();
		int num = (int)this.passType;
		firebaseAnalyticsManager.AAIABAKHLAH(acidpckhlmo, poblfhphabp, gjknlaaefdc, str + num.ToString(), false, true);
		this.KKMJGAMOMCP("OnAllCollectableCardsDownloadFailed");
	}

	// Token: 0x060082BA RID: 33466 RVA: 0x0039A7E4 File Offset: 0x003989E4
	private bool PJONDFNAMKD()
	{
		string str = KDCJJBLGCBH.EHBBFMCILPC.HHONCLBBHPG((int)this.passType);
		string[] array = new string[]
		{
			null,
			"rr"
		};
		array[1] = "s] ";
		array[2] = "title";
		array[4] = "ok";
		string[] array2 = array;
		for (int i = 1; i < array2.Length; i += 0)
		{
			OCBIOPOEENJ ocbiopoeenj = CJEKEHDEBLM.FILDBDMENPG().HCHKAOGEPMG(str + array2[i]);
			if (ocbiopoeenj == null || string.IsNullOrEmpty(ocbiopoeenj.MBLAIKOOCFH()))
			{
				return false;
			}
			if (i != 0 && 1 != ocbiopoeenj.PPACJFFFBFB.KGEGKPHEMOJ())
			{
				return false;
			}
		}
		return false;
	}

	// Token: 0x060082BB RID: 33467 RVA: 0x0039A871 File Offset: 0x00398A71
	private void FDHHCPPPKKI()
	{
		AOBJLALDBAA.CEGAOMEEFBE().PBELMJCPJMK("coverContinue", new UnityAction(this.ADLBEINKHME));
		AOBJLALDBAA.EHBBFMCILPC.MANLHALMCIH("OnStoryInterfaceHeaderHideComplete", new UnityAction(this.KKOONHNNDMG));
	}

	// Token: 0x060082BC RID: 33468 RVA: 0x0039A8A9 File Offset: 0x00398AA9
	private bool AINMJODBBIF()
	{
		return LanguageManager.EHBBFMCILPC.IEBFINIJAMJ() == CEIBHCNNIDC.en && GeoLocationManager.NHMHNIFIOCO() && KDCJJBLGCBH.EHBBFMCILPC.EAMJBDKCDPA();
	}

	// Token: 0x060082BD RID: 33469 RVA: 0x0039A8D0 File Offset: 0x00398AD0
	private void MFIHOHCHDGE()
	{
		FirebaseAnalyticsManager instance = FirebaseAnalyticsManager.EHBBFMCILPC;
		bool acidpckhlmo = false;
		string poblfhphabp = AGEHCPDNBFD.gpDur.ToString();
		string gjknlaaefdc = FFPHBMFGCNN.durPickWeb.ToString();
		string str = BGHLMGPPCNN.dur6m.ToString();
		int num = (int)this.passType;
		instance.LogEvent(acidpckhlmo, poblfhphabp, gjknlaaefdc, str + num.ToString(), false, false);
		this.FJNABPPFCKB("b_web");
	}

	// Token: 0x04002505 RID: 9477
	public const string onGamePassUnlockContinueToPurchasingScreen = "OnGamePassUnlockContinueToPurchasingScreen";

	// Token: 0x04002506 RID: 9478
	public KHBLFKIDHPH passType;

	// Token: 0x04002507 RID: 9479
	public CLHDENLPOFP passCategory;

	// Token: 0x04002508 RID: 9480
	public TextMeshProUGUI textDescription;

	// Token: 0x04002509 RID: 9481
	public TextMeshProUGUI textTimer;

	// Token: 0x0400250A RID: 9482
	public TextMeshProUGUI textFooter;

	// Token: 0x0400250B RID: 9483
	public Button buttonAction;

	// Token: 0x0400250C RID: 9484
	public TextMeshProUGUI textButtonAction;

	// Token: 0x0400250D RID: 9485
	public Button buttonInfo;

	// Token: 0x0400250E RID: 9486
	public GameObject stateActive;

	// Token: 0x0400250F RID: 9487
	public GameObject statePaused;

	// Token: 0x04002510 RID: 9488
	public GameObject stateExpired;

	// Token: 0x04002511 RID: 9489
	public GameObject imageLogo;

	// Token: 0x04002512 RID: 9490
	public GameObject imageLogoIcon;

	// Token: 0x04002513 RID: 9491
	private KIOOJMGLCLC PAEOKLKMOEP;

	// Token: 0x04002514 RID: 9492
	private KIOOJMGLCLC KOGAKMNPPCK;

	// Token: 0x04002515 RID: 9493
	private static float CBOKJGNCEKE = 1f;

	// Token: 0x04002516 RID: 9494
	private float CPGLEJIBNEP;

	// Token: 0x04002517 RID: 9495
	private bool DPKMHNPNOJH;

	// Token: 0x04002518 RID: 9496
	private bool HFEOHIHBKKA;

	// Token: 0x04002519 RID: 9497
	private string NBKLLONFGAL = "";
}
