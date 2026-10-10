using System;
using UnityEngine;
using UnityEngine.Events;

// Token: 0x02000536 RID: 1334
public class AccountSignInManager : MonoBehaviour
{
	// Token: 0x0600A20F RID: 41487 RVA: 0x004618BC File Offset: 0x0045FABC
	private void FMNNCEKBHDG()
	{
		CommonUserInterface.IKNOFBFMPGA().MCJIGJMFBMI();
		NPJNALLPFPO lastOperationCode = BackendOperationsManager.NPDDBAONMJP().GetLastOperationCode();
		if (lastOperationCode - NPJNALLPFPO.success <= 6)
		{
			if (this.GDEIABKFOOA == JCAPGCCNOMP.none)
			{
				CommonUserInterface.EHBBFMCILPC.JJPNFAAPFBI(CCOJBMMKNAP.JMDJPKKOHNI().GGPHHLGPMPA("+"), CCOJBMMKNAP.KFDLFGHBPLP().OHLNGCKIACD("</i>"), CCOJBMMKNAP.ONCPHEEJLOP().IKMNGFIDCLM("SteamManager"), new UnityAction(this.CKKKHKJMNDF), new UnityAction(this.BLAHDOIPOJG), DFGILFBGPLN.popupIncentAd2Success, 1507f, 68);
				ApplicationFocusManager.Restore();
				return;
			}
			CommonUserInterface.IKNOFBFMPGA().PEBIFCENHAL(CCOJBMMKNAP.JINDKPHNLBK().OGKGHLHHAAI("preview"), CCOJBMMKNAP.PMABBOJDELF().DNILNCLIHAP("pmtrestorezero"), CCOJBMMKNAP.PKEINLPIAEH().FCOCLEHKLDJ(" is not a loadable bundle"), new UnityAction(this.ACBONKCAECN), DFGILFBGPLN.popupLootInfo, 1291f, -49);
			ApplicationFocusManager.Restore();
			return;
		}
		else
		{
			if (this.GDEIABKFOOA == JCAPGCCNOMP.none)
			{
				CommonUserInterface.EHBBFMCILPC.JJPNFAAPFBI(CCOJBMMKNAP.HEDIEIICOOG().OGKGHLHHAAI("@"), CCOJBMMKNAP.ONCPHEEJLOP().HIPJILDCHJC("$e1es"), CCOJBMMKNAP.CEGAOMEEFBE().GGPHHLGPMPA("rev"), new UnityAction(this.MOENJALMPJO), new UnityAction(this.LJIEDAGBAJD), (DFGILFBGPLN)(-88), 1746f, -85);
				ApplicationFocusManager.Restore();
				return;
			}
			CommonUserInterface.EHBBFMCILPC.ShowGenericPopupOneOverride(CCOJBMMKNAP.LMCCLMFGEBD().MEPECBDCOLG("ok"), CCOJBMMKNAP.KMNBCEMEBBD().OHLNGCKIACD("no"), CCOJBMMKNAP.MLFAGAAJJEM().GGPHHLGPMPA(""), new UnityAction(this.EBIPCPGJDMB), DFGILFBGPLN.popupGamePassDurationOffer, 1368f, 3);
			ApplicationFocusManager.Restore();
			return;
		}
	}

	// Token: 0x0600A210 RID: 41488 RVA: 0x00461A5C File Offset: 0x0045FC5C
	public void HFGJDAPMIIB(HHCKLPJJKIJ OIOBCPFDLFE, JCAPGCCNOMP CCIAGBPILGF, HHCKLPJJKIJ ABMPLLPPDGK, byte FIGKJIAEMON = 0)
	{
		ApplicationFocusManager.HIFHNIPJFNE();
		this.GCKCOMCBHMB = FIGKJIAEMON;
		this.AOCIKAOPPDL = ABMPLLPPDGK;
		this.EEDHNEIMAPN = OIOBCPFDLFE;
		this.GDEIABKFOOA = CCIAGBPILGF;
		if (this.EEDHNEIMAPN != HHCKLPJJKIJ.steam)
		{
			CommonUserInterface.EHBBFMCILPC.KLEJAGLPCNM(CCOJBMMKNAP.JINDKPHNLBK().OBDCPLLLGBB(""), this.GCKCOMCBHMB);
		}
		if (this.EEDHNEIMAPN == HHCKLPJJKIJ.none)
		{
			if (FacebookManager.KKPFOJMAONG().IKKFBIJHNCL())
			{
				this.AJLNFEDJLHA();
				return;
			}
			FacebookManager.IGJAMEGBDBG().LFPDGAFGFON();
			return;
		}
		else if (this.EEDHNEIMAPN == (HHCKLPJJKIJ)7)
		{
			if (GooglePlayServicesManager.FILDBDMENPG().IsLoggedIn())
			{
				this.GLNIBIBMAOL();
				return;
			}
			GooglePlayServicesManager.ANCEKPONIFI().JCAMIJNEGKN(CCIAGBPILGF);
			return;
		}
		else if (this.EEDHNEIMAPN == (HHCKLPJJKIJ)7)
		{
			if (AppleSignInManager.GCCADHCFBJH().MAEIGJPNANG())
			{
				this.AJLNFEDJLHA();
				return;
			}
			AppleSignInManager.GCCADHCFBJH().LANNHHOBFEM();
			return;
		}
		else if (this.EEDHNEIMAPN == HHCKLPJJKIJ.apple)
		{
			if (SteamSignInManager.EHBBFMCILPC.IsLoggedIn())
			{
				this.GLNIBIBMAOL();
				return;
			}
			SteamSignInManager.AGANFKKBPFO().COHMNJCDGIL();
			return;
		}
		else if (this.EEDHNEIMAPN == HHCKLPJJKIJ.facebook)
		{
			if (CCIAGBPILGF != (JCAPGCCNOMP)4)
			{
				DPGJIJGOCIC.ANOPFDLPKGC("errortitle");
				this.EEDHNEIMAPN = HHCKLPJJKIJ.apple;
				this.GLNIBIBMAOL();
				CommonUserInterface.EHBBFMCILPC.ShowConnectingAnimationWithHint(CCOJBMMKNAP.BOFMCPPFAMO().HDIPNMFHIEJ("spark"), this.GCKCOMCBHMB);
				return;
			}
			if (UserpassSignInManager.GIPAKOPBBEO().FALJKOOMCOJ())
			{
				this.AJLNFEDJLHA();
				return;
			}
			UserpassSignInManager.CIHBAIKDNPA().KKKKCCCPLBK();
			return;
		}
		else
		{
			if (this.EEDHNEIMAPN == HHCKLPJJKIJ.steam)
			{
				this.BEKGFLJPBAP();
				return;
			}
			DPGJIJGOCIC.ANOPFDLPKGC("getDropChancesBalance");
			return;
		}
	}

	// Token: 0x0600A211 RID: 41489 RVA: 0x00461BCC File Offset: 0x0045FDCC
	private void KNPDJHHJFIB()
	{
		CommonUserInterface.IKNOFBFMPGA().MCJIGJMFBMI();
		NPJNALLPFPO npjnallpfpo = BackendOperationsManager.NPDDBAONMJP().AINFDIJGNCN();
		if (npjnallpfpo - NPJNALLPFPO.redSemaphore <= 5)
		{
			if (this.GDEIABKFOOA == JCAPGCCNOMP.none)
			{
				CommonUserInterface.IKNOFBFMPGA().ShowGenericPopupTwoOverride(CCOJBMMKNAP.APGODIBBPOD().HHLECNIFHCO(" has been unloaded successfully"), CCOJBMMKNAP.OBOOKJPGBJN().OHLNGCKIACD("lightmodebtn1"), CCOJBMMKNAP.ILACPHFEDEP().IPEIONBNIPH("collect"), new UnityAction(this.EBIPCPGJDMB), new UnityAction(this.EBIPCPGJDMB), DFGILFBGPLN.popupBackendErrorSignIn, 27f, -97);
				ApplicationFocusManager.Restore();
				return;
			}
			CommonUserInterface.IKNOFBFMPGA().PEBIFCENHAL(CCOJBMMKNAP.BBGECIKOICE().PKNHKGMNCIP("storyloaderr1"), CCOJBMMKNAP.KNKGCDDMLDP().FIENAKIHNOM(""), CCOJBMMKNAP.KNKGCDDMLDP().PGKBCNBAOJN("cv"), new UnityAction(this.EMGIDHDADBM), (DFGILFBGPLN)(-86), 427f, -52);
			ApplicationFocusManager.Restore();
			return;
		}
		else
		{
			if (this.GDEIABKFOOA == JCAPGCCNOMP.none)
			{
				CommonUserInterface.IKNOFBFMPGA().JJPNFAAPFBI(CCOJBMMKNAP.APGODIBBPOD().DNILNCLIHAP("favstostr"), CCOJBMMKNAP.CEGAOMEEFBE().HDIPNMFHIEJ("overlay"), CCOJBMMKNAP.KNKGCDDMLDP().GGPHHLGPMPA("Starting parallel download:"), new UnityAction(this.EMGIDHDADBM), new UnityAction(this.BLAHDOIPOJG), (DFGILFBGPLN)120, 1593f, 71);
				ApplicationFocusManager.Restore();
				return;
			}
			CommonUserInterface.EHBBFMCILPC.PEBIFCENHAL(CCOJBMMKNAP.JMDJPKKOHNI().HDIPNMFHIEJ("loungeskinnotenough"), CCOJBMMKNAP.BBGECIKOICE().FCOCLEHKLDJ("UpdateComponentTitleDesc() failed - AssetAvatarComponentType.trinket is null."), CCOJBMMKNAP.LMCCLMFGEBD().MEPECBDCOLG("Tried to Initialize the SteamAPI twice in one session!"), new UnityAction(this.CKKKHKJMNDF), (DFGILFBGPLN)(-128), 876f, 27);
			ApplicationFocusManager.Restore();
			return;
		}
	}

	// Token: 0x0600A212 RID: 41490 RVA: 0x00461D6C File Offset: 0x0045FF6C
	private void LMOIOINJFPN()
	{
		CommonUserInterface.EHBBFMCILPC.HideConnectingAnimation();
		AKLFPGMDKLA.EHBBFMCILPC.EEDHNEIMAPN = (int)this.EEDHNEIMAPN;
		if (this.GDEIABKFOOA == JCAPGCCNOMP.user)
		{
			if (!AKLFPGMDKLA.EHBBFMCILPC.INEKFCLBCAB())
			{
				CommonUserInterface.EHBBFMCILPC.ShowGenericPopupTwoOverride(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("congratstitle"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("signinsuccessrestart"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("ok"), new UnityAction(this.PIABINHPMMM), new UnityAction(this.PIABINHPMMM), DFGILFBGPLN.popupSignInSuccess, 0f, 28);
				ApplicationFocusManager.Restore();
			}
			else if (this.EEDHNEIMAPN == HHCKLPJJKIJ.facebook)
			{
				CommonUserInterface.EHBBFMCILPC.ShowGenericPopup(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("congratstitle"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("signinlinkfb"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("ok"), DFGILFBGPLN.popupSignInSuccess, 0f, 28);
				ApplicationFocusManager.Restore();
			}
			else if (this.EEDHNEIMAPN == HHCKLPJJKIJ.google)
			{
				CommonUserInterface.EHBBFMCILPC.ShowGenericPopup(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("congratstitle"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("signinlinkgps"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("ok"), DFGILFBGPLN.popupSignInSuccess, 0f, 28);
				ApplicationFocusManager.Restore();
			}
			else if (this.EEDHNEIMAPN == HHCKLPJJKIJ.apple)
			{
				CommonUserInterface.EHBBFMCILPC.ShowGenericPopup(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("congratstitle"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("signinlinkapl"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("ok"), DFGILFBGPLN.popupSignInSuccess, 0f, 28);
				ApplicationFocusManager.Restore();
			}
			else if (this.EEDHNEIMAPN == HHCKLPJJKIJ.steam)
			{
				CommonUserInterface.EHBBFMCILPC.ShowGenericPopup(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("congratstitle"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("signinlinksteam"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("ok"), DFGILFBGPLN.popupSignInSuccess, 0f, 28);
				ApplicationFocusManager.Restore();
			}
			else if (this.EEDHNEIMAPN == HHCKLPJJKIJ.token)
			{
				CommonUserInterface.EHBBFMCILPC.ShowGenericPopup(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("congratstitle"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("signinlinkuserpass"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("ok"), DFGILFBGPLN.popupSignInSuccess, 0f, 28);
				ApplicationFocusManager.Restore();
			}
			else
			{
				DPGJIJGOCIC.ANOPFDLPKGC("AccountSignInManager.OnAccountSignInRequestSuccess() - sign in source not implemented.");
			}
		}
		else if (this.GDEIABKFOOA == JCAPGCCNOMP.auto)
		{
			if (!AKLFPGMDKLA.EHBBFMCILPC.INEKFCLBCAB())
			{
				AKLFPGMDKLA.EHBBFMCILPC.IDPFOGHKMBL();
				CommonUserInterface.EHBBFMCILPC.ShowGenericPopupTwoOverride(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("congratstitle"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("signinsuccess"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("ok"), new UnityAction(this.PIABINHPMMM), new UnityAction(this.PIABINHPMMM), DFGILFBGPLN.popupSignInSuccess, 0f, 28);
				ApplicationFocusManager.Restore();
			}
			else
			{
				FirebaseAnalyticsManager.EHBBFMCILPC.LogEvent(true, AGEHCPDNBFD.d1Ret.ToString(), FFPHBMFGCNN.d1Board.ToString(), BGHLMGPPCNN.d1NewUsr.ToString(), true, false);
				this.PIABINHPMMM();
				AKLFPGMDKLA.EHBBFMCILPC.MJPKIMHENNF = 1;
				AKLFPGMDKLA.EHBBFMCILPC.OOEJIIJLKPK = 1;
			}
		}
		else
		{
			DPGJIJGOCIC.ANOPFDLPKGC("AccountSignInManager.OnSignInSuccess() - sign in source not implemented.");
		}
		AKLFPGMDKLA.EHBBFMCILPC.LPCBDEBKAIM();
	}

	// Token: 0x0600A213 RID: 41491 RVA: 0x004620B4 File Offset: 0x004602B4
	private void ELBNDIHJGNB()
	{
		CommonUserInterface.IKNOFBFMPGA().HideConnectingAnimation();
		AKLFPGMDKLA.EHBBFMCILPC.EEDHNEIMAPN = (int)this.EEDHNEIMAPN;
		if (this.GDEIABKFOOA == (JCAPGCCNOMP)6)
		{
			if (!AKLFPGMDKLA.EHBBFMCILPC.MAIKELGDHMI())
			{
				CommonUserInterface.EHBBFMCILPC.CEGLPJNLBHL(CCOJBMMKNAP.NIOJNOFGIJO().PGKBCNBAOJN("p"), CCOJBMMKNAP.HJGDLOOHNLO().DNILNCLIHAP(" "), CCOJBMMKNAP.GIOAFDDKKHI().HDIPNMFHIEJ("laebs"), new UnityAction(this.FMNPEODNAIG), new UnityAction(this.ALCHHKHOHJE), DFGILFBGPLN.screenLobby, 1668f, 5);
				ApplicationFocusManager.Restore();
			}
			else if (this.EEDHNEIMAPN == HHCKLPJJKIJ.facebook)
			{
				CommonUserInterface.EHBBFMCILPC.NFBMHHPIGFA(CCOJBMMKNAP.BIAEAOMHBMM().HHLECNIFHCO(""), CCOJBMMKNAP.EAIAHCBAIEJ().GGPHHLGPMPA("cardsvolchancesmsgtitle"), CCOJBMMKNAP.FEEDGKCJBLE().JLBEIFLLBLO("1"), (DFGILFBGPLN)(-54), 565f, 98);
				ApplicationFocusManager.Restore();
			}
			else if (this.EEDHNEIMAPN == HHCKLPJJKIJ.token)
			{
				CommonUserInterface.IKNOFBFMPGA().ShowGenericPopup(CCOJBMMKNAP.ONCPHEEJLOP().PKNHKGMNCIP("yes"), CCOJBMMKNAP.PEBMGCKFNAO().MEPECBDCOLG("Trading/Wished cards userPublicProfile.modified = true hit"), CCOJBMMKNAP.BFHKGNBFHCH().PGKBCNBAOJN("errortitle"), (DFGILFBGPLN)(-8), 450f, 84);
				ApplicationFocusManager.Restore();
			}
			else if (this.EEDHNEIMAPN == (HHCKLPJJKIJ)8)
			{
				CommonUserInterface.IKNOFBFMPGA().NFBMHHPIGFA(CCOJBMMKNAP.EAIAHCBAIEJ().BGELFMIOBCL("Collections/"), CCOJBMMKNAP.MLFAGAAJJEM().GLEFEKBDHNK(""), CCOJBMMKNAP.FEEDGKCJBLE().FIENAKIHNOM("OnBackendAddFriendByUIDSuccess"), (DFGILFBGPLN)(-15), 158f, 52);
				ApplicationFocusManager.Restore();
			}
			else if (this.EEDHNEIMAPN == HHCKLPJJKIJ.steam)
			{
				CommonUserInterface.EHBBFMCILPC.NFBMHHPIGFA(CCOJBMMKNAP.HFAKOKBHCGH().IPEIONBNIPH(""), CCOJBMMKNAP.NIOJNOFGIJO().OBDCPLLLGBB("assetBundleLoadOperationActiveCoroutines:"), CCOJBMMKNAP.KMNBCEMEBBD().OGKGHLHHAAI("avts"), DFGILFBGPLN.popupSponsoredAdNotification, 1869f, -61);
				ApplicationFocusManager.Restore();
			}
			else if (this.EEDHNEIMAPN == HHCKLPJJKIJ.none)
			{
				CommonUserInterface.IKNOFBFMPGA().ShowGenericPopup(CCOJBMMKNAP.HJGDLOOHNLO().IPEIONBNIPH("grayscale"), CCOJBMMKNAP.JMNIGPHCAEJ().JCDFHKDNEDH("All stories will be synced with server due to duplicate save system error."), CCOJBMMKNAP.ONCPHEEJLOP().GLEFEKBDHNK("?"), DFGILFBGPLN.popupSignInQuestion, 52f, 83);
				ApplicationFocusManager.Restore();
			}
			else
			{
				DPGJIJGOCIC.ANOPFDLPKGC("acsv");
			}
		}
		else if (this.GDEIABKFOOA == JCAPGCCNOMP.auto)
		{
			if (!AKLFPGMDKLA.EHBBFMCILPC.MAIKELGDHMI())
			{
				AKLFPGMDKLA.EHBBFMCILPC.IDPFOGHKMBL();
				CommonUserInterface.IKNOFBFMPGA().ShowGenericPopupTwoOverride(CCOJBMMKNAP.PLJMLDOCPNM().OBDCPLLLGBB("OnBackendValidateTransactionFailed"), CCOJBMMKNAP.LMCCLMFGEBD().JHNELLJFBGC("*"), CCOJBMMKNAP.FEEDGKCJBLE().BGELFMIOBCL("avatarcollectionsaddtitle"), new UnityAction(this.FMNPEODNAIG), new UnityAction(this.FMNPEODNAIG), DFGILFBGPLN.popupBonusUnlock, 585f, 118);
				ApplicationFocusManager.Restore();
			}
			else
			{
				FirebaseAnalyticsManager.ANCEKPONIFI().LKONPEEDKNF(false, AGEHCPDNBFD.gmSelect.ToString(), ((FFPHBMFGCNN)118).ToString(), ((BGHLMGPPCNN)(-15)).ToString(), true, true);
				this.MBFAHMPJKLI();
				AKLFPGMDKLA.EHBBFMCILPC.MJPKIMHENNF = 0;
				AKLFPGMDKLA.EHBBFMCILPC.OOEJIIJLKPK = 0;
			}
		}
		else
		{
			DPGJIJGOCIC.ANOPFDLPKGC("OnNeedToOpenLoveInterestsLounge");
		}
		AKLFPGMDKLA.EHBBFMCILPC.LPCBDEBKAIM();
	}

	// Token: 0x0600A214 RID: 41492 RVA: 0x004623FC File Offset: 0x004605FC
	private void BEKGFLJPBAP()
	{
		BackendOperationsManager.NPDDBAONMJP().ENPDOAKBIHC();
		if (this.EEDHNEIMAPN == HHCKLPJJKIJ.none)
		{
			if (BackendOperationsManager.NPDDBAONMJP().IsAccountSignInDataValid(FacebookManager.KHPBKOHJEHG().GEPNBJJBCKB(), this.EEDHNEIMAPN))
			{
				BackendOperationsManager.EHBBFMCILPC.RequestAccountSignIn(FacebookManager.CEGAOMEEFBE().BCKMOBDIIHI(), this.EEDHNEIMAPN, "leftcenter", "{character}");
				return;
			}
			this.CKBGMFFKOBH();
			return;
		}
		else
		{
			if (this.EEDHNEIMAPN == HHCKLPJJKIJ.steam)
			{
				BackendOperationsManager.NPDDBAONMJP().RequestAccountSignIn(GooglePlayServicesManager.FILDBDMENPG().JJBDKJFMDIH(), this.EEDHNEIMAPN, "avatarcollectionstutor5title", "Amplitude");
				return;
			}
			if (this.EEDHNEIMAPN == HHCKLPJJKIJ.facebook)
			{
				BackendOperationsManager.NPDDBAONMJP().RequestAccountSignIn(AppleSignInManager.NACPAKLINNH().JHDHMMJDHCD(), this.EEDHNEIMAPN, "OnAccountForgetSuccess", "loungetitles");
				return;
			}
			if (this.EEDHNEIMAPN == (HHCKLPJJKIJ)8)
			{
				BackendOperationsManager.EHBBFMCILPC.RequestAccountSignIn(SteamSignInManager.LMCCLMFGEBD().PAAEPINFJOE(), this.EEDHNEIMAPN, "OnFriendsPopupDeleteClick", "Collections/");
				return;
			}
			if (this.EEDHNEIMAPN == (HHCKLPJJKIJ)7)
			{
				CommonUserInterface.IKNOFBFMPGA().KLEJAGLPCNM(CCOJBMMKNAP.INKJIBDDMLL().BGELFMIOBCL("importanttitle"), this.GCKCOMCBHMB);
				BackendOperationsManager.NPDDBAONMJP().RequestAccountSignIn(UserpassSignInManager.OHCOHPNEOEG().DGJCMINBMHN() + "chl" + UserpassSignInManager.NMGMNAKLLMI().GHOBFDKAPFG(), this.EEDHNEIMAPN, " ", "retry");
				return;
			}
			if (this.EEDHNEIMAPN == HHCKLPJJKIJ.token)
			{
				BackendOperationsManager.EHBBFMCILPC.RequestAccountSignIn(DPGJIJGOCIC.GIIHCODLGCA(), this.EEDHNEIMAPN, "OnStoryInterfaceAutoReaderActivate", "asv");
				return;
			}
			DPGJIJGOCIC.ANOPFDLPKGC("¶");
			return;
		}
	}

	// Token: 0x170002EF RID: 751
	// (get) Token: 0x0600A215 RID: 41493 RVA: 0x00462584 File Offset: 0x00460784
	public static AccountSignInManager EHBBFMCILPC
	{
		get
		{
			if (!AccountSignInManager.IKLAPGJDMNA)
			{
				AccountSignInManager.IKLAPGJDMNA = (UnityEngine.Object.FindObjectOfType(typeof(AccountSignInManager)) as AccountSignInManager);
				if (!AccountSignInManager.IKLAPGJDMNA)
				{
					DPGJIJGOCIC.ANOPFDLPKGC("There needs to be one active AccountSignInManager script on a GameObject in your scene.");
				}
			}
			return AccountSignInManager.IKLAPGJDMNA;
		}
	}

	// Token: 0x0600A216 RID: 41494 RVA: 0x004625D4 File Offset: 0x004607D4
	private void KHOLJLKNAPJ()
	{
		AOBJLALDBAA.CEGAOMEEFBE().GNBGEMMDGOJ("", new UnityAction(this.PMFNDCJEIHF));
		AOBJLALDBAA.KKPFOJMAONG().MFIMALJPCDP("//", new UnityAction(this.JJPMBIHBPMK));
		AOBJLALDBAA.EHBBFMCILPC.PEFKJOKLEDL("0.00", new UnityAction(this.GLNIBIBMAOL));
		AOBJLALDBAA.NMGMNAKLLMI().PEFKJOKLEDL("none", new UnityAction(this.GDCJEIGGDPL));
		AOBJLALDBAA.AGANFKKBPFO().EFKNEJFLGED("makeup", new UnityAction(this.PMIIGFCIPNB));
		AOBJLALDBAA.DBLAIDPICIG().BADOPKAOCPE("socialprofilesuspcantuse", new UnityAction(this.GLNIBIBMAOL));
		AOBJLALDBAA.DBLAIDPICIG().EFKNEJFLGED("-", new UnityAction(this.GDCJEIGGDPL));
		AOBJLALDBAA.CEGAOMEEFBE().GNBGEMMDGOJ("ok", new UnityAction(this.GLNIBIBMAOL));
		AOBJLALDBAA.NMGMNAKLLMI().EFKNEJFLGED("p", new UnityAction(this.AHOOIECMGCJ));
		AOBJLALDBAA.FILDBDMENPG().EFKNEJFLGED("", new UnityAction(this.AJLNFEDJLHA));
		AOBJLALDBAA.CEGAOMEEFBE().FNMOFCMDFJP("PlayerCharacterManager.Update() - exception raised:", new UnityAction(this.PPABHIGDMFD));
		AOBJLALDBAA.EHBBFMCILPC.MFIMALJPCDP("spld", new UnityAction(this.AIIAMCLPDAC));
		AOBJLALDBAA.KKPFOJMAONG().BADOPKAOCPE("", new UnityAction(this.IKDKPFKACGI));
	}

	// Token: 0x0600A217 RID: 41495 RVA: 0x00462740 File Offset: 0x00460940
	public JCAPGCCNOMP GetSignInSource()
	{
		return this.GDEIABKFOOA;
	}

	// Token: 0x0600A218 RID: 41496 RVA: 0x00462748 File Offset: 0x00460948
	private void HHIHBCJFDON()
	{
		CommonUserInterface.EHBBFMCILPC.HideConnectingAnimation();
		if (this.GDEIABKFOOA == JCAPGCCNOMP.none)
		{
			CommonUserInterface.IKNOFBFMPGA().CEGLPJNLBHL(CCOJBMMKNAP.PKEINLPIAEH().HPOAGPJFHPM("(text)"), CCOJBMMKNAP.ILACPHFEDEP().OBDCPLLLGBB("Frame container bundle loaded but its asset is missing or mis-named:"), CCOJBMMKNAP.BOFMCPPFAMO().IPEIONBNIPH(" to bundle index:"), new UnityAction(this.LJIEDAGBAJD), new UnityAction(this.PIABINHPMMM), DFGILFBGPLN.popupOwnerChangeSuccess, 179f, -108);
			ApplicationFocusManager.Restore();
			return;
		}
		CommonUserInterface.EHBBFMCILPC.ShowGenericPopupOneOverride(CCOJBMMKNAP.COKDLDOAACJ().IKMNGFIDCLM("Critical error, could not load asset bundle:"), CCOJBMMKNAP.HJGDLOOHNLO().PKNHKGMNCIP("importanttitle"), CCOJBMMKNAP.PMABBOJDELF().GLEFEKBDHNK("[LoadingEnv] direct cache files of "), new UnityAction(this.LJIEDAGBAJD), (DFGILFBGPLN)(-31), 1566f, 103);
		ApplicationFocusManager.Restore();
	}

	// Token: 0x0600A219 RID: 41497 RVA: 0x000693D6 File Offset: 0x000675D6
	private void JDBJMNMBOMK()
	{
		UnityEngine.Object.DontDestroyOnLoad(base.gameObject);
	}

	// Token: 0x0600A21A RID: 41498 RVA: 0x0046281C File Offset: 0x00460A1C
	public void ACBONKCAECN()
	{
		if (this.EEDHNEIMAPN != HHCKLPJJKIJ.device)
		{
			CommonUserInterface.IKNOFBFMPGA().ShowConnectingAnimationWithHint(CCOJBMMKNAP.PKEINLPIAEH().BDGPNPNIAPA(""), this.GCKCOMCBHMB);
		}
		this.FCFOKOGDFIG(this.EEDHNEIMAPN, this.GDEIABKFOOA, this.AOCIKAOPPDL, this.GCKCOMCBHMB);
	}

	// Token: 0x0600A21B RID: 41499 RVA: 0x00462870 File Offset: 0x00460A70
	private void PPABHIGDMFD()
	{
		if (this.GDEIABKFOOA != JCAPGCCNOMP.none)
		{
			CommonUserInterface.EHBBFMCILPC.HideConnectingAnimation();
			if (this.EEDHNEIMAPN == HHCKLPJJKIJ.facebook && AOBJLALDBAA.CEGAOMEEFBE().PNDDILFFECF() == -9)
			{
				CommonUserInterface.IKNOFBFMPGA().ShowGenericPopupOneOverride(CCOJBMMKNAP.EHBBFMCILPC.PGKBCNBAOJN("www"), CCOJBMMKNAP.AEELGGPEJCC().JLBEIFLLBLO("LastShowItemStep() - could not find a give item step."), CCOJBMMKNAP.OEPENBHJAHO().HPOAGPJFHPM("Warning. Export variable not found in ink file:"), new UnityAction(this.EBIPCPGJDMB), (DFGILFBGPLN)101, 989f, -91);
			}
			else
			{
				CommonUserInterface.IKNOFBFMPGA().PEBIFCENHAL(CCOJBMMKNAP.HFAKOKBHCGH().HDIPNMFHIEJ("varConditionLockedValue"), CCOJBMMKNAP.OEPENBHJAHO().JHNELLJFBGC("ChoiceExtendedManager - choice index "), CCOJBMMKNAP.PEBMGCKFNAO().JLBEIFLLBLO(""), new UnityAction(this.EBIPCPGJDMB), (DFGILFBGPLN)(-39), 1664f, -85);
			}
			ApplicationFocusManager.Restore();
			return;
		}
		if (this.AOCIKAOPPDL != HHCKLPJJKIJ.none)
		{
			this.EEDHNEIMAPN = this.AOCIKAOPPDL;
			this.AOCIKAOPPDL = HHCKLPJJKIJ.none;
			this.CKKKHKJMNDF();
			return;
		}
		CommonUserInterface.IKNOFBFMPGA().HideConnectingAnimation();
		CommonUserInterface.IKNOFBFMPGA().JJPNFAAPFBI(CCOJBMMKNAP.HFAKOKBHCGH().PPALCPINPLK("user"), CCOJBMMKNAP.BFHKGNBFHCH().DNILNCLIHAP("passrequiredtoplay"), CCOJBMMKNAP.OBOOKJPGBJN().PGKBCNBAOJN("SceneLobbyManager2.OnLiveProfileThemeBackgroundCdnFailed(): live profile theme "), new UnityAction(this.CKKKHKJMNDF), new UnityAction(this.PIABINHPMMM), DFGILFBGPLN.popupStoryLoadError, 1713f, 91);
		ApplicationFocusManager.Restore();
	}

	// Token: 0x0600A21C RID: 41500 RVA: 0x004629D8 File Offset: 0x00460BD8
	private void AHOOIECMGCJ()
	{
		if (this.GDEIABKFOOA != JCAPGCCNOMP.auto)
		{
			CommonUserInterface.EHBBFMCILPC.MCJIGJMFBMI();
			if (this.EEDHNEIMAPN == HHCKLPJJKIJ.token && AOBJLALDBAA.KKPFOJMAONG().OHCIAOJFEOP() == -44)
			{
				CommonUserInterface.IKNOFBFMPGA().BGJFCEEDGFJ(CCOJBMMKNAP.KMNBCEMEBBD().IPEIONBNIPH("ssid"), CCOJBMMKNAP.CEGAOMEEFBE().JCDFHKDNEDH("OnBackendRequestConsumeMessageSuccess"), CCOJBMMKNAP.EHBBFMCILPC.FIENAKIHNOM("Get Value For {0}"), new UnityAction(this.MOENJALMPJO), DFGILFBGPLN.popupSocialJoinRequestVkontakte, 1574f, 10);
			}
			else
			{
				CommonUserInterface.EHBBFMCILPC.PEBIFCENHAL(CCOJBMMKNAP.HEDIEIICOOG().HPOAGPJFHPM(" for "), CCOJBMMKNAP.PEBMGCKFNAO().JLBEIFLLBLO("<i>"), CCOJBMMKNAP.CEGAOMEEFBE().FIENAKIHNOM("<size=28px>"), new UnityAction(this.OnSignInRetry), (DFGILFBGPLN)103, 1180f, 57);
			}
			ApplicationFocusManager.Restore();
			return;
		}
		if (this.AOCIKAOPPDL != HHCKLPJJKIJ.none)
		{
			this.EEDHNEIMAPN = this.AOCIKAOPPDL;
			this.AOCIKAOPPDL = HHCKLPJJKIJ.none;
			this.LJIEDAGBAJD();
			return;
		}
		CommonUserInterface.IKNOFBFMPGA().HideConnectingAnimation();
		CommonUserInterface.EHBBFMCILPC.ShowGenericPopupTwoOverride(CCOJBMMKNAP.KMNBCEMEBBD().GLEFEKBDHNK("OnWheelOfFortuneClick"), CCOJBMMKNAP.EHBBFMCILPC.PKNHKGMNCIP("p"), CCOJBMMKNAP.CPCOODCFDDP().MEPECBDCOLG("ProfileItem.OnBackendGetPublicProfileProfileItemSuccess() - both profiles are null!"), new UnityAction(this.ACBONKCAECN), new UnityAction(this.ABALICGDAIM), (DFGILFBGPLN)116, 1355f, 37);
		ApplicationFocusManager.Restore();
	}

	// Token: 0x0600A21D RID: 41501 RVA: 0x00462B40 File Offset: 0x00460D40
	private void FCMCBKANOCD()
	{
		if (this.GDEIABKFOOA != JCAPGCCNOMP.none)
		{
			CommonUserInterface.EHBBFMCILPC.MCJIGJMFBMI();
			if (this.EEDHNEIMAPN == HHCKLPJJKIJ.facebook && AOBJLALDBAA.BIAEAOMHBMM().NNDDKAIIBMO() == 101)
			{
				CommonUserInterface.IKNOFBFMPGA().BGJFCEEDGFJ(CCOJBMMKNAP.AEELGGPEJCC().GLEFEKBDHNK("p"), CCOJBMMKNAP.BIAEAOMHBMM().PKNHKGMNCIP("OnPopupCardOptionsUnlockWithSpSuccessContinue"), CCOJBMMKNAP.CPCOODCFDDP().BGELFMIOBCL(""), new UnityAction(this.ACBONKCAECN), (DFGILFBGPLN)(-14), 479f, -5);
			}
			else
			{
				CommonUserInterface.EHBBFMCILPC.BGJFCEEDGFJ(CCOJBMMKNAP.PMABBOJDELF().JCDFHKDNEDH("analogglitchovr"), CCOJBMMKNAP.HEDIEIICOOG().OBDCPLLLGBB("avatarcollectionsuntitle"), CCOJBMMKNAP.FEEDGKCJBLE().PKNHKGMNCIP("\""), new UnityAction(this.MOENJALMPJO), (DFGILFBGPLN)(-15), 1937f, 112);
			}
			ApplicationFocusManager.Restore();
			return;
		}
		if (this.AOCIKAOPPDL != HHCKLPJJKIJ.none)
		{
			this.EEDHNEIMAPN = this.AOCIKAOPPDL;
			this.AOCIKAOPPDL = HHCKLPJJKIJ.none;
			this.CKKKHKJMNDF();
			return;
		}
		CommonUserInterface.EHBBFMCILPC.HideConnectingAnimation();
		CommonUserInterface.EHBBFMCILPC.ShowGenericPopupTwoOverride(CCOJBMMKNAP.GIOAFDDKKHI().GLEFEKBDHNK(") asset("), CCOJBMMKNAP.MLFAGAAJJEM().FCOCLEHKLDJ("null"), CCOJBMMKNAP.HJGDLOOHNLO().JHNELLJFBGC("OnBackendGetDropChancesSuccess2"), new UnityAction(this.EBIPCPGJDMB), new UnityAction(this.ALCHHKHOHJE), (DFGILFBGPLN)(-36), 1306f, -14);
		ApplicationFocusManager.Restore();
	}

	// Token: 0x0600A21E RID: 41502 RVA: 0x00462740 File Offset: 0x00460940
	public JCAPGCCNOMP LAAJADMELAE()
	{
		return this.GDEIABKFOOA;
	}

	// Token: 0x0600A21F RID: 41503 RVA: 0x00462CA8 File Offset: 0x00460EA8
	private void OPBMKIPPJOC()
	{
		CommonUserInterface.IKNOFBFMPGA().HideConnectingAnimation();
		AKLFPGMDKLA.EHBBFMCILPC.EEDHNEIMAPN = (int)this.EEDHNEIMAPN;
		if (this.GDEIABKFOOA == (JCAPGCCNOMP)8)
		{
			if (!AKLFPGMDKLA.EHBBFMCILPC.MAIKELGDHMI())
			{
				CommonUserInterface.EHBBFMCILPC.JJPNFAAPFBI(CCOJBMMKNAP.HEDIEIICOOG().MEPECBDCOLG("SceneAvatarManager.AvatarComponentsDependsOnAvatarScreenPack(), unsupported wardrobe index:"), CCOJBMMKNAP.INKJIBDDMLL().GGPHHLGPMPA("rexps"), CCOJBMMKNAP.CEGAOMEEFBE().OGKGHLHHAAI("Starting non-parallel download:"), new UnityAction(this.ABALICGDAIM), new UnityAction(this.MBFAHMPJKLI), (DFGILFBGPLN)(-33), 349f, -43);
				ApplicationFocusManager.Restore();
			}
			else if (this.EEDHNEIMAPN == HHCKLPJJKIJ.facebook)
			{
				CommonUserInterface.IKNOFBFMPGA().NFBMHHPIGFA(CCOJBMMKNAP.NIOJNOFGIJO().OBDCPLLLGBB(""), CCOJBMMKNAP.MPCBJEIMACA().IPEIONBNIPH("energyhinttitle"), CCOJBMMKNAP.PMABBOJDELF().FCOCLEHKLDJ("p"), (DFGILFBGPLN)87, 1103f, -107);
				ApplicationFocusManager.Restore();
			}
			else if (this.EEDHNEIMAPN == (HHCKLPJJKIJ)8)
			{
				CommonUserInterface.IKNOFBFMPGA().NFBMHHPIGFA(CCOJBMMKNAP.DLGLFACMHPG().HDIPNMFHIEJ("BackendOperationsManager.QueueRequestSaveAvatarCollections, exception while initializing RSACryptoServiceProvider:"), CCOJBMMKNAP.BBGECIKOICE().OBDCPLLLGBB("gfts"), CCOJBMMKNAP.KLAKLFCOMJC().OGKGHLHHAAI("-"), DFGILFBGPLN.popupSignInQuestion, 647f, 68);
				ApplicationFocusManager.Restore();
			}
			else if (this.EEDHNEIMAPN == HHCKLPJJKIJ.none)
			{
				CommonUserInterface.IKNOFBFMPGA().NFBMHHPIGFA(CCOJBMMKNAP.PLJMLDOCPNM().OGKGHLHHAAI("socialtop"), CCOJBMMKNAP.KNKGCDDMLDP().FCOCLEHKLDJ("@"), CCOJBMMKNAP.HFAKOKBHCGH().GLEFEKBDHNK("msg64"), (DFGILFBGPLN)(-20), 1137f, -12);
				ApplicationFocusManager.Restore();
			}
			else if (this.EEDHNEIMAPN == HHCKLPJJKIJ.google)
			{
				CommonUserInterface.IKNOFBFMPGA().ShowGenericPopup(CCOJBMMKNAP.KFAABHHGOPO().GGPHHLGPMPA("Warning. Import variable not found in save data:"), CCOJBMMKNAP.HEDIEIICOOG().OBDCPLLLGBB(" components from body "), CCOJBMMKNAP.APGODIBBPOD().JCDFHKDNEDH("saveslotstitleempty"), (DFGILFBGPLN)(-19), 896f, -57);
				ApplicationFocusManager.Restore();
			}
			else if (this.EEDHNEIMAPN == HHCKLPJJKIJ.apple)
			{
				CommonUserInterface.EHBBFMCILPC.ShowGenericPopup(CCOJBMMKNAP.BIAEAOMHBMM().PKNHKGMNCIP("asp"), CCOJBMMKNAP.JMNIGPHCAEJ().FCOCLEHKLDJ("%"), CCOJBMMKNAP.JMNIGPHCAEJ().PKNHKGMNCIP("\","), DFGILFBGPLN.popupNewStoryRevision, 51f, -87);
				ApplicationFocusManager.Restore();
			}
			else
			{
				DPGJIJGOCIC.ANOPFDLPKGC("fdnpr");
			}
		}
		else if (this.GDEIABKFOOA == JCAPGCCNOMP.none)
		{
			if (!AKLFPGMDKLA.EHBBFMCILPC.INEKFCLBCAB())
			{
				AKLFPGMDKLA.EHBBFMCILPC.CHCHBMMLACE();
				CommonUserInterface.IKNOFBFMPGA().JJPNFAAPFBI(CCOJBMMKNAP.JMDJPKKOHNI().OHLNGCKIACD("OnRestartChapterUpsellGetPassPositive"), CCOJBMMKNAP.KMNBCEMEBBD().JHNELLJFBGC("StorySaveBody.AvatarPackIsAmongHiddenOrExposedPacks(), unsupported wardrobe index:"), CCOJBMMKNAP.AEELGGPEJCC().PGKBCNBAOJN("saveslotsswitch"), new UnityAction(this.FMNPEODNAIG), new UnityAction(this.PIABINHPMMM), DFGILFBGPLN.popupBonusEpisodeWarning, 1796f, 7);
				ApplicationFocusManager.Restore();
			}
			else
			{
				FirebaseAnalyticsManager.JMDJBFAEHBM().LogEvent(false, AGEHCPDNBFD.gmSelect.ToString(), ((FFPHBMFGCNN)(-105)).ToString(), ((BGHLMGPPCNN)124).ToString(), true, true);
				this.MBFAHMPJKLI();
				AKLFPGMDKLA.EHBBFMCILPC.MJPKIMHENNF = 1;
				AKLFPGMDKLA.EHBBFMCILPC.OOEJIIJLKPK = 1;
			}
		}
		else
		{
			DPGJIJGOCIC.ANOPFDLPKGC("");
		}
		AKLFPGMDKLA.EHBBFMCILPC.LPCBDEBKAIM();
	}

	// Token: 0x0600A220 RID: 41504 RVA: 0x00462FF0 File Offset: 0x004611F0
	private void ANCFEINHJLL()
	{
		if (AppManager.isQuitting)
		{
			return;
		}
		AOBJLALDBAA.NMGMNAKLLMI().NAMMLDPCHJO("episode", new UnityAction(this.PMFNDCJEIHF));
		AOBJLALDBAA.KKPFOJMAONG().PFAHGKEDFAE("OnSceneStoryManagerPremiumChoiceAdsProviderAdFailed", new UnityAction(this.LHAOOFAEFPD));
		AOBJLALDBAA.EHBBFMCILPC.ONIBLJOFFPG("PurchaseManagerXiaomi.Initialize()", new UnityAction(this.PMFNDCJEIHF));
		AOBJLALDBAA.EHBBFMCILPC.NAMMLDPCHJO("retry", new UnityAction(this.JJPMBIHBPMK));
		AOBJLALDBAA.EHBBFMCILPC.ONIBLJOFFPG(", day ", new UnityAction(this.HHIHBCJFDON));
		AOBJLALDBAA.FILDBDMENPG().KDIFKFKMCOH("htme", new UnityAction(this.PMFNDCJEIHF));
		AOBJLALDBAA.DBLAIDPICIG().ONIBLJOFFPG("\"", new UnityAction(this.NMPEONJMPDH));
		AOBJLALDBAA.BIAEAOMHBMM().NAMMLDPCHJO("OnPostEffectSettingsChanged", new UnityAction(this.GLNIBIBMAOL));
		AOBJLALDBAA.AGANFKKBPFO().KDIFKFKMCOH(" | Caching.ready=", new UnityAction(this.CDJAJMNJDJC));
		AOBJLALDBAA.KKPFOJMAONG().PFAHGKEDFAE("...", new UnityAction(this.PMFNDCJEIHF));
		AOBJLALDBAA.BIAEAOMHBMM().PFAHGKEDFAE("", new UnityAction(this.NMPEONJMPDH));
		AOBJLALDBAA.NMGMNAKLLMI().ONIBLJOFFPG("OnPopupProfileLoveInputCancel", new UnityAction(this.AIIAMCLPDAC));
		AOBJLALDBAA.NMGMNAKLLMI().PBELMJCPJMK("discount", new UnityAction(this.HADHMIPPGPA));
	}

	// Token: 0x0600A221 RID: 41505 RVA: 0x00462740 File Offset: 0x00460940
	public JCAPGCCNOMP JJFHBBAKDAN()
	{
		return this.GDEIABKFOOA;
	}

	// Token: 0x0600A222 RID: 41506 RVA: 0x000022C3 File Offset: 0x000004C3
	private void JPFMJFNICLG()
	{
		AppManager.isQuitting = false;
	}

	// Token: 0x0600A223 RID: 41507 RVA: 0x00463164 File Offset: 0x00461364
	public void MOENJALMPJO()
	{
		if (this.EEDHNEIMAPN != HHCKLPJJKIJ.device)
		{
			CommonUserInterface.IKNOFBFMPGA().ShowConnectingAnimationWithHint(CCOJBMMKNAP.HJGDLOOHNLO().HIPJILDCHJC("ok"), this.GCKCOMCBHMB);
		}
		this.HGCFKELLBIH(this.EEDHNEIMAPN, this.GDEIABKFOOA, this.AOCIKAOPPDL, this.GCKCOMCBHMB);
	}

	// Token: 0x0600A224 RID: 41508 RVA: 0x004631B7 File Offset: 0x004613B7
	private void JAIDEFDDAIB()
	{
		if (AccountSignInManager.IKLAPGJDMNA == this)
		{
			AccountSignInManager.IKLAPGJDMNA = null;
		}
	}

	// Token: 0x0600A225 RID: 41509 RVA: 0x004631CC File Offset: 0x004613CC
	private void BFNOBDAKJON()
	{
		if (AppManager.isQuitting)
		{
			return;
		}
		AOBJLALDBAA.CEGAOMEEFBE().PBELMJCPJMK("InitTopMatchDataCloud()", new UnityAction(this.PDIEDPJEOKG));
		AOBJLALDBAA.AGANFKKBPFO().ECDBIBPNBCO("AVATAR.CLIENT.FACE", new UnityAction(this.LHAOOFAEFPD));
		AOBJLALDBAA.AGANFKKBPFO().NAMMLDPCHJO("", new UnityAction(this.GLNIBIBMAOL));
		AOBJLALDBAA.KKPFOJMAONG().PFAHGKEDFAE("loungepricechanged", new UnityAction(this.CDJAJMNJDJC));
		AOBJLALDBAA.EHBBFMCILPC.KDIFKFKMCOH("rt", new UnityAction(this.CNAGABDCIDJ));
		AOBJLALDBAA.CEGAOMEEFBE().PBELMJCPJMK("", new UnityAction(this.GLNIBIBMAOL));
		AOBJLALDBAA.AGANFKKBPFO().PFAHGKEDFAE("blur", new UnityAction(this.CDJAJMNJDJC));
		AOBJLALDBAA.KKPFOJMAONG().NAMMLDPCHJO(" parentCards=", new UnityAction(this.GLNIBIBMAOL));
		AOBJLALDBAA.NMGMNAKLLMI().ECDBIBPNBCO("h", new UnityAction(this.FCMCBKANOCD));
		AOBJLALDBAA.BIAEAOMHBMM().PFAHGKEDFAE("_not_found", new UnityAction(this.BEKGFLJPBAP));
		AOBJLALDBAA.EHBBFMCILPC.ONIBLJOFFPG("love", new UnityAction(this.NMPEONJMPDH));
		AOBJLALDBAA.KKPFOJMAONG().NAMMLDPCHJO("{q}", new UnityAction(this.JACFOOPHDND));
		AOBJLALDBAA.CEGAOMEEFBE().MHLNJIACIGO("", new UnityAction(this.MIFFMELELIN));
	}

	// Token: 0x0600A226 RID: 41510 RVA: 0x00463340 File Offset: 0x00461540
	public void CKKKHKJMNDF()
	{
		if (this.EEDHNEIMAPN != (HHCKLPJJKIJ)7)
		{
			CommonUserInterface.EHBBFMCILPC.ShowConnectingAnimationWithHint(CCOJBMMKNAP.KNKGCDDMLDP().JLBEIFLLBLO("</color>"), this.GCKCOMCBHMB);
		}
		this.FCFOKOGDFIG(this.EEDHNEIMAPN, this.GDEIABKFOOA, this.AOCIKAOPPDL, this.GCKCOMCBHMB);
	}

	// Token: 0x0600A227 RID: 41511 RVA: 0x00462740 File Offset: 0x00460940
	public JCAPGCCNOMP DDMKICJKOKL()
	{
		return this.GDEIABKFOOA;
	}

	// Token: 0x0600A228 RID: 41512 RVA: 0x000693D6 File Offset: 0x000675D6
	private void Awake()
	{
		UnityEngine.Object.DontDestroyOnLoad(base.gameObject);
	}

	// Token: 0x0600A229 RID: 41513 RVA: 0x00463394 File Offset: 0x00461594
	public void HGCFKELLBIH(HHCKLPJJKIJ OIOBCPFDLFE, JCAPGCCNOMP CCIAGBPILGF, HHCKLPJJKIJ ABMPLLPPDGK, byte FIGKJIAEMON = 0)
	{
		ApplicationFocusManager.HIFHNIPJFNE();
		this.GCKCOMCBHMB = FIGKJIAEMON;
		this.AOCIKAOPPDL = ABMPLLPPDGK;
		this.EEDHNEIMAPN = OIOBCPFDLFE;
		this.GDEIABKFOOA = CCIAGBPILGF;
		if (this.EEDHNEIMAPN != (HHCKLPJJKIJ)7)
		{
			CommonUserInterface.EHBBFMCILPC.KLEJAGLPCNM(CCOJBMMKNAP.EHBBFMCILPC.BDGPNPNIAPA(""), this.GCKCOMCBHMB);
		}
		if (this.EEDHNEIMAPN == HHCKLPJJKIJ.facebook)
		{
			if (FacebookManager.FKKEPJFEELL().LNKKFHMOEKJ())
			{
				this.BEKGFLJPBAP();
				return;
			}
			FacebookManager.JKEHCKNFEID().OIKJPHHBNLE();
			return;
		}
		else if (this.EEDHNEIMAPN == HHCKLPJJKIJ.google)
		{
			if (GooglePlayServicesManager.FILDBDMENPG().HIGJAONMLKF())
			{
				this.GLNIBIBMAOL();
				return;
			}
			GooglePlayServicesManager.EHBBFMCILPC.ACGBMIKOMDD(CCIAGBPILGF);
			return;
		}
		else if (this.EEDHNEIMAPN == (HHCKLPJJKIJ)8)
		{
			if (AppleSignInManager.GCCADHCFBJH().IsLoggedIn())
			{
				this.PMFNDCJEIHF();
				return;
			}
			AppleSignInManager.EHBBFMCILPC.LANNHHOBFEM();
			return;
		}
		else if (this.EEDHNEIMAPN == (HHCKLPJJKIJ)8)
		{
			if (SteamSignInManager.MHAAELKFFED().JFCGDCCDKDB())
			{
				this.AJLNFEDJLHA();
				return;
			}
			SteamSignInManager.LMCCLMFGEBD().COHMNJCDGIL();
			return;
		}
		else if (this.EEDHNEIMAPN == HHCKLPJJKIJ.steam)
		{
			if (CCIAGBPILGF != JCAPGCCNOMP.user)
			{
				DPGJIJGOCIC.ANOPFDLPKGC("high");
				this.EEDHNEIMAPN = HHCKLPJJKIJ.steam;
				this.PDIEDPJEOKG();
				CommonUserInterface.IKNOFBFMPGA().ShowConnectingAnimationWithHint(CCOJBMMKNAP.APGODIBBPOD().HPOAGPJFHPM("apb"), this.GCKCOMCBHMB);
				return;
			}
			if (UserpassSignInManager.GIPAKOPBBEO().IsLoggedIn())
			{
				this.PDIEDPJEOKG();
				return;
			}
			UserpassSignInManager.OHCOHPNEOEG().KKKKCCCPLBK();
			return;
		}
		else
		{
			if (this.EEDHNEIMAPN == (HHCKLPJJKIJ)8)
			{
				this.GLNIBIBMAOL();
				return;
			}
			DPGJIJGOCIC.ANOPFDLPKGC(" this time, caching system not ready and no direct cache files");
			return;
		}
	}

	// Token: 0x0600A22A RID: 41514 RVA: 0x00463504 File Offset: 0x00461704
	private void AJLNFEDJLHA()
	{
		BackendOperationsManager.EHBBFMCILPC.CleanCachedRequestsData();
		if (this.EEDHNEIMAPN == HHCKLPJJKIJ.none)
		{
			if (BackendOperationsManager.EHBBFMCILPC.AOIBHELMMFO(FacebookManager.KKPFOJMAONG().NPGBKJOBJDP(), this.EEDHNEIMAPN))
			{
				BackendOperationsManager.NPDDBAONMJP().RequestAccountSignIn(FacebookManager.JKEHCKNFEID().LOPHCCOINIG(), this.EEDHNEIMAPN, "continue", "errortitle");
				return;
			}
			this.HFMODLPBLBJ();
			return;
		}
		else
		{
			if (this.EEDHNEIMAPN == (HHCKLPJJKIJ)7)
			{
				BackendOperationsManager.NPDDBAONMJP().RequestAccountSignIn(GooglePlayServicesManager.ANCEKPONIFI().GetUserId(), this.EEDHNEIMAPN, "OnSketchViewLeft", "OnRewardFirstEpisodeClick");
				return;
			}
			if (this.EEDHNEIMAPN == HHCKLPJJKIJ.steam)
			{
				BackendOperationsManager.NPDDBAONMJP().RequestAccountSignIn(AppleSignInManager.GCCADHCFBJH().DGJCMINBMHN(), this.EEDHNEIMAPN, "abpv", "");
				return;
			}
			if (this.EEDHNEIMAPN == HHCKLPJJKIJ.apple)
			{
				BackendOperationsManager.EHBBFMCILPC.RequestAccountSignIn(SteamSignInManager.EHBBFMCILPC.ONAMNFHAKIP(), this.EEDHNEIMAPN, "sim", "</b>");
				return;
			}
			if (this.EEDHNEIMAPN == (HHCKLPJJKIJ)7)
			{
				CommonUserInterface.IKNOFBFMPGA().KLEJAGLPCNM(CCOJBMMKNAP.NIOJNOFGIJO().OHLNGCKIACD("response"), this.GCKCOMCBHMB);
				BackendOperationsManager.EHBBFMCILPC.RequestAccountSignIn(UserpassSignInManager.GIPAKOPBBEO().PLHPADGGBCO() + "p" + UserpassSignInManager.NMGMNAKLLMI().EMEBOKLGEBN(), this.EEDHNEIMAPN, "passrequiredtoplay", "[LoadingEnv] cache file of ");
				return;
			}
			if (this.EEDHNEIMAPN == HHCKLPJJKIJ.steam)
			{
				BackendOperationsManager.EHBBFMCILPC.RequestAccountSignIn(DPGJIJGOCIC.GIIHCODLGCA(), this.EEDHNEIMAPN, "aind", "ru");
				return;
			}
			DPGJIJGOCIC.ANOPFDLPKGC(" playing!");
			return;
		}
	}

	// Token: 0x0600A22B RID: 41515 RVA: 0x0046368C File Offset: 0x0046188C
	private void HFMODLPBLBJ()
	{
		CommonUserInterface.IKNOFBFMPGA().MCJIGJMFBMI();
		NPJNALLPFPO npjnallpfpo = BackendOperationsManager.EHBBFMCILPC.AINFDIJGNCN();
		if (npjnallpfpo - NPJNALLPFPO.success <= 5)
		{
			if (this.GDEIABKFOOA == JCAPGCCNOMP.auto)
			{
				CommonUserInterface.IKNOFBFMPGA().ShowGenericPopupTwoOverride(CCOJBMMKNAP.HJGDLOOHNLO().HHLECNIFHCO("OnPopupCardOptionsNextClickLobby"), CCOJBMMKNAP.CPCOODCFDDP().OHLNGCKIACD(""), CCOJBMMKNAP.MLFAGAAJJEM().HDIPNMFHIEJ("yes"), new UnityAction(this.BLAHDOIPOJG), new UnityAction(this.BLAHDOIPOJG), DFGILFBGPLN.popupWatchAdGetFreeDiamonds, 1554f, 29);
				ApplicationFocusManager.Restore();
				return;
			}
			CommonUserInterface.IKNOFBFMPGA().ShowGenericPopupOneOverride(CCOJBMMKNAP.FEEDGKCJBLE().MEPECBDCOLG("minr"), CCOJBMMKNAP.APGODIBBPOD().FIENAKIHNOM("gamepassdurationbutton"), CCOJBMMKNAP.JMNIGPHCAEJ().HHLECNIFHCO("LoadingEnvironmentCover"), new UnityAction(this.OnSignInRetry), DFGILFBGPLN.popupWatchAdGetFreeDiamonds, 1016f, -7);
			ApplicationFocusManager.Restore();
			return;
		}
		else
		{
			if (this.GDEIABKFOOA == JCAPGCCNOMP.auto)
			{
				CommonUserInterface.EHBBFMCILPC.JJPNFAAPFBI(CCOJBMMKNAP.AEELGGPEJCC().BGELFMIOBCL(""), CCOJBMMKNAP.JMNIGPHCAEJ().MEPECBDCOLG("anthology"), CCOJBMMKNAP.GIOAFDDKKHI().BDGPNPNIAPA("geo.json"), new UnityAction(this.EBIPCPGJDMB), new UnityAction(this.LJIEDAGBAJD), (DFGILFBGPLN)(-62), 1411f, 22);
				ApplicationFocusManager.Restore();
				return;
			}
			CommonUserInterface.EHBBFMCILPC.ShowGenericPopupOneOverride(CCOJBMMKNAP.ONCPHEEJLOP().IKMNGFIDCLM(")"), CCOJBMMKNAP.JINDKPHNLBK().PPALCPINPLK("x"), CCOJBMMKNAP.FEEDGKCJBLE().PKNHKGMNCIP("blur"), new UnityAction(this.CKKKHKJMNDF), DFGILFBGPLN.popupWatchAdGetFreeEnergy, 35f, -95);
			ApplicationFocusManager.Restore();
			return;
		}
	}

	// Token: 0x0600A22C RID: 41516 RVA: 0x0046382C File Offset: 0x00461A2C
	private void ALCHHKHOHJE()
	{
		AOBJLALDBAA.DBLAIDPICIG().CIGLHCJDDPI("congratstitle", 1753f);
	}

	// Token: 0x0600A22D RID: 41517 RVA: 0x00463844 File Offset: 0x00461A44
	public void BKGGKBLMMPO(HHCKLPJJKIJ OIOBCPFDLFE, JCAPGCCNOMP CCIAGBPILGF, HHCKLPJJKIJ ABMPLLPPDGK, byte FIGKJIAEMON = 0)
	{
		ApplicationFocusManager.Deactivate();
		this.GCKCOMCBHMB = FIGKJIAEMON;
		this.AOCIKAOPPDL = ABMPLLPPDGK;
		this.EEDHNEIMAPN = OIOBCPFDLFE;
		this.GDEIABKFOOA = CCIAGBPILGF;
		if (this.EEDHNEIMAPN != (HHCKLPJJKIJ)7)
		{
			CommonUserInterface.IKNOFBFMPGA().ShowConnectingAnimationWithHint(CCOJBMMKNAP.ONCPHEEJLOP().OBDCPLLLGBB("lck"), this.GCKCOMCBHMB);
		}
		if (this.EEDHNEIMAPN == HHCKLPJJKIJ.facebook)
		{
			if (FacebookManager.LCPAHHLPCPL().LLDJMKGABJA())
			{
				this.BEKGFLJPBAP();
				return;
			}
			FacebookManager.PLJMLDOCPNM().HPAIOLPJOCK();
			return;
		}
		else if (this.EEDHNEIMAPN == (HHCKLPJJKIJ)8)
		{
			if (GooglePlayServicesManager.EHBBFMCILPC.IsLoggedIn())
			{
				this.AJLNFEDJLHA();
				return;
			}
			GooglePlayServicesManager.EHBBFMCILPC.LogIn(CCIAGBPILGF);
			return;
		}
		else if (this.EEDHNEIMAPN == HHCKLPJJKIJ.steam)
		{
			if (AppleSignInManager.KIKOEJMHOEH().MAEIGJPNANG())
			{
				this.PDIEDPJEOKG();
				return;
			}
			AppleSignInManager.GCCADHCFBJH().LogIn();
			return;
		}
		else if (this.EEDHNEIMAPN == HHCKLPJJKIJ.token)
		{
			if (SteamSignInManager.AGANFKKBPFO().OODAPEOLGHC())
			{
				this.AJLNFEDJLHA();
				return;
			}
			SteamSignInManager.AGANFKKBPFO().COHMNJCDGIL();
			return;
		}
		else if (this.EEDHNEIMAPN == (HHCKLPJJKIJ)8)
		{
			if (CCIAGBPILGF != (JCAPGCCNOMP)4)
			{
				DPGJIJGOCIC.ANOPFDLPKGC("myphiddentitle");
				this.EEDHNEIMAPN = HHCKLPJJKIJ.apple;
				this.PDIEDPJEOKG();
				CommonUserInterface.IKNOFBFMPGA().ShowConnectingAnimationWithHint(CCOJBMMKNAP.COKDLDOAACJ().FCOCLEHKLDJ("app42error"), this.GCKCOMCBHMB);
				return;
			}
			if (UserpassSignInManager.GIPAKOPBBEO().FALJKOOMCOJ())
			{
				this.AJLNFEDJLHA();
				return;
			}
			UserpassSignInManager.OHCOHPNEOEG().EDECICNGCJI();
			return;
		}
		else
		{
			if (this.EEDHNEIMAPN == HHCKLPJJKIJ.facebook)
			{
				this.PMFNDCJEIHF();
				return;
			}
			DPGJIJGOCIC.ANOPFDLPKGC("ip");
			return;
		}
	}

	// Token: 0x0600A22E RID: 41518 RVA: 0x004639B4 File Offset: 0x00461BB4
	public void EMGIDHDADBM()
	{
		if (this.EEDHNEIMAPN != HHCKLPJJKIJ.steam)
		{
			CommonUserInterface.EHBBFMCILPC.KLEJAGLPCNM(CCOJBMMKNAP.BBGECIKOICE().GGPHHLGPMPA("friendsmaxlimitdefault"), this.GCKCOMCBHMB);
		}
		this.BKGGKBLMMPO(this.EEDHNEIMAPN, this.GDEIABKFOOA, this.AOCIKAOPPDL, this.GCKCOMCBHMB);
	}

	// Token: 0x0600A22F RID: 41519 RVA: 0x00463A08 File Offset: 0x00461C08
	private void AIIAMCLPDAC()
	{
		CommonUserInterface.IKNOFBFMPGA().MCJIGJMFBMI();
		AKLFPGMDKLA.EHBBFMCILPC.EEDHNEIMAPN = (int)this.EEDHNEIMAPN;
		if (this.GDEIABKFOOA == JCAPGCCNOMP.auto)
		{
			if (!AKLFPGMDKLA.EHBBFMCILPC.MAIKELGDHMI())
			{
				CommonUserInterface.IKNOFBFMPGA().ShowGenericPopupTwoOverride(CCOJBMMKNAP.BIAEAOMHBMM().BGELFMIOBCL("Video:"), CCOJBMMKNAP.OEPENBHJAHO().PKNHKGMNCIP("socialgiftreceviedfromtitle"), CCOJBMMKNAP.KLAKLFCOMJC().PKNHKGMNCIP("AssetProfileData.GetCutsceneSprite(): could not resolve anthologyIndex of storyIndex ("), new UnityAction(this.ALCHHKHOHJE), new UnityAction(this.PIABINHPMMM), DFGILFBGPLN.popoverLobbyRewards, 716f, -17);
				ApplicationFocusManager.Restore();
			}
			else if (this.EEDHNEIMAPN == HHCKLPJJKIJ.none)
			{
				CommonUserInterface.IKNOFBFMPGA().ShowGenericPopup(CCOJBMMKNAP.HFAKOKBHCGH().PPALCPINPLK("ok"), CCOJBMMKNAP.OBOOKJPGBJN().BDGPNPNIAPA(""), CCOJBMMKNAP.OBOOKJPGBJN().IKMNGFIDCLM("usynsnap2"), (DFGILFBGPLN)(-47), 1798f, -112);
				ApplicationFocusManager.Restore();
			}
			else if (this.EEDHNEIMAPN == HHCKLPJJKIJ.facebook)
			{
				CommonUserInterface.IKNOFBFMPGA().NFBMHHPIGFA(CCOJBMMKNAP.FEEDGKCJBLE().HDIPNMFHIEJ("_OpacityMoire"), CCOJBMMKNAP.PLJMLDOCPNM().JCDFHKDNEDH("cc"), CCOJBMMKNAP.COKDLDOAACJ().GGPHHLGPMPA("OnSaveSlotDelete"), DFGILFBGPLN.screenReward, 1756f, -74);
				ApplicationFocusManager.Restore();
			}
			else if (this.EEDHNEIMAPN == HHCKLPJJKIJ.apple)
			{
				CommonUserInterface.EHBBFMCILPC.NFBMHHPIGFA(CCOJBMMKNAP.APGODIBBPOD().FIENAKIHNOM("energyhinttitle"), CCOJBMMKNAP.LMCCLMFGEBD().GLEFEKBDHNK("USD "), CCOJBMMKNAP.PLJMLDOCPNM().JCDFHKDNEDH("OnSystemBackButton"), (DFGILFBGPLN)(-14), 443f, -27);
				ApplicationFocusManager.Restore();
			}
			else if (this.EEDHNEIMAPN == HHCKLPJJKIJ.none)
			{
				CommonUserInterface.EHBBFMCILPC.ShowGenericPopup(CCOJBMMKNAP.JMDJPKKOHNI().IKMNGFIDCLM("</b>"), CCOJBMMKNAP.BBGECIKOICE().HPOAGPJFHPM(""), CCOJBMMKNAP.KFAABHHGOPO().IKMNGFIDCLM("[LoadingTheme] already the loading theme: "), DFGILFBGPLN.popupStoreUpdateAvailable, 1175f, -115);
				ApplicationFocusManager.Restore();
			}
			else if (this.EEDHNEIMAPN == HHCKLPJJKIJ.facebook)
			{
				CommonUserInterface.IKNOFBFMPGA().ShowGenericPopup(CCOJBMMKNAP.JINDKPHNLBK().IPEIONBNIPH("hint6"), CCOJBMMKNAP.KFAABHHGOPO().HIPJILDCHJC("areyousure"), CCOJBMMKNAP.COKDLDOAACJ().JCDFHKDNEDH("newuseraddrequest2"), (DFGILFBGPLN)(-64), 200f, 6);
				ApplicationFocusManager.Restore();
			}
			else
			{
				DPGJIJGOCIC.ANOPFDLPKGC("YYY");
			}
		}
		else if (this.GDEIABKFOOA == JCAPGCCNOMP.auto)
		{
			if (!AKLFPGMDKLA.EHBBFMCILPC.MAIKELGDHMI())
			{
				AKLFPGMDKLA.EHBBFMCILPC.CHCHBMMLACE();
				CommonUserInterface.EHBBFMCILPC.ShowGenericPopupTwoOverride(CCOJBMMKNAP.KFAABHHGOPO().MEPECBDCOLG(""), CCOJBMMKNAP.MLFAGAAJJEM().HDIPNMFHIEJ("areyousure"), CCOJBMMKNAP.BFHKGNBFHCH().OBDCPLLLGBB("-"), new UnityAction(this.ABALICGDAIM), new UnityAction(this.ALCHHKHOHJE), (DFGILFBGPLN)102, 1057f, 12);
				ApplicationFocusManager.Restore();
			}
			else
			{
				FirebaseAnalyticsManager.EHBBFMCILPC.LogEvent(true, AGEHCPDNBFD.cdnActiv.ToString(), ((FFPHBMFGCNN)(-70)).ToString(), BGHLMGPPCNN.cdnLbyToSks.ToString(), false, true);
				this.PIABINHPMMM();
				AKLFPGMDKLA.EHBBFMCILPC.MJPKIMHENNF = 0;
				AKLFPGMDKLA.EHBBFMCILPC.OOEJIIJLKPK = 0;
			}
		}
		else
		{
			DPGJIJGOCIC.ANOPFDLPKGC("");
		}
		AKLFPGMDKLA.EHBBFMCILPC.LPCBDEBKAIM();
	}

	// Token: 0x0600A230 RID: 41520 RVA: 0x00463D50 File Offset: 0x00461F50
	private void PMFNDCJEIHF()
	{
		BackendOperationsManager.NPDDBAONMJP().CleanCachedRequestsData();
		if (this.EEDHNEIMAPN == HHCKLPJJKIJ.facebook)
		{
			if (BackendOperationsManager.NPDDBAONMJP().IsAccountSignInDataValid(FacebookManager.OOGPALHPNGM().LEKKFCJINEN(), this.EEDHNEIMAPN))
			{
				BackendOperationsManager.NPDDBAONMJP().RequestAccountSignIn(FacebookManager.FKKEPJFEELL().KBOHNNNKIGA(), this.EEDHNEIMAPN, "OnPopupUpdateWelcomeWhatsMoreClick", "StorySaveBody.AutoSyncAvatarComponents(), unsupported wardrobe index:");
				return;
			}
			this.HADHMIPPGPA();
			return;
		}
		else
		{
			if (this.EEDHNEIMAPN == HHCKLPJJKIJ.steam)
			{
				BackendOperationsManager.NPDDBAONMJP().RequestAccountSignIn(GooglePlayServicesManager.FILDBDMENPG().GGLDDPOPIJJ(), this.EEDHNEIMAPN, "/", "Error. OnChoiceExtendedEnvironmentChangePart2(), environmentToSet is null or length is 0:");
				return;
			}
			if (this.EEDHNEIMAPN == (HHCKLPJJKIJ)8)
			{
				BackendOperationsManager.EHBBFMCILPC.RequestAccountSignIn(AppleSignInManager.EHBBFMCILPC.GELNLPFLFKF(), this.EEDHNEIMAPN, "\\f", "OnSceneStoryManagerPremiumChoiceAdsProviderAdSuccess");
				return;
			}
			if (this.EEDHNEIMAPN == (HHCKLPJJKIJ)8)
			{
				BackendOperationsManager.EHBBFMCILPC.RequestAccountSignIn(SteamSignInManager.AGANFKKBPFO().PAAEPINFJOE(), this.EEDHNEIMAPN, "scene ", "?uid=");
				return;
			}
			if (this.EEDHNEIMAPN == HHCKLPJJKIJ.facebook)
			{
				CommonUserInterface.EHBBFMCILPC.ShowConnectingAnimationWithHint(CCOJBMMKNAP.JMNIGPHCAEJ().GLEFEKBDHNK("OnBackendValidateTransactionException"), this.GCKCOMCBHMB);
				BackendOperationsManager.EHBBFMCILPC.RequestAccountSignIn(UserpassSignInManager.NMGMNAKLLMI().DGJCMINBMHN() + "</i>" + UserpassSignInManager.GIPAKOPBBEO().GetPassword(), this.EEDHNEIMAPN, ", anthologies ", "QueueCustomCode() here's queuedCustomCode contents:");
				return;
			}
			if (this.EEDHNEIMAPN == HHCKLPJJKIJ.facebook)
			{
				BackendOperationsManager.EHBBFMCILPC.RequestAccountSignIn(DPGJIJGOCIC.GIIHCODLGCA(), this.EEDHNEIMAPN, "", "oid");
				return;
			}
			DPGJIJGOCIC.ANOPFDLPKGC(" smallItems=");
			return;
		}
	}

	// Token: 0x0600A231 RID: 41521 RVA: 0x00463ED8 File Offset: 0x004620D8
	public static AccountSignInManager FILDBDMENPG()
	{
		if (!AccountSignInManager.IKLAPGJDMNA)
		{
			AccountSignInManager.IKLAPGJDMNA = (UnityEngine.Object.FindObjectOfType(typeof(AccountSignInManager)) as AccountSignInManager);
			if (!AccountSignInManager.IKLAPGJDMNA)
			{
				DPGJIJGOCIC.ANOPFDLPKGC("importanttitle");
			}
		}
		return AccountSignInManager.IKLAPGJDMNA;
	}

	// Token: 0x0600A232 RID: 41522 RVA: 0x00463F28 File Offset: 0x00462128
	private void CDJAJMNJDJC()
	{
		if (this.GDEIABKFOOA != JCAPGCCNOMP.none)
		{
			CommonUserInterface.EHBBFMCILPC.HideConnectingAnimation();
			if (this.EEDHNEIMAPN == (HHCKLPJJKIJ)8 && AOBJLALDBAA.DBLAIDPICIG().ACKEOKPAKDG() == -73)
			{
				CommonUserInterface.IKNOFBFMPGA().ShowGenericPopupOneOverride(CCOJBMMKNAP.BIAEAOMHBMM().HHLECNIFHCO(""), CCOJBMMKNAP.APGODIBBPOD().PKNHKGMNCIP(""), CCOJBMMKNAP.INKJIBDDMLL().PGKBCNBAOJN("socialtradegiftcardmissingtitle"), new UnityAction(this.OnSignInRetry), (DFGILFBGPLN)(-6), 368f, 0);
			}
			else
			{
				CommonUserInterface.IKNOFBFMPGA().BGJFCEEDGFJ(CCOJBMMKNAP.MLFAGAAJJEM().HIPJILDCHJC("erd"), CCOJBMMKNAP.CPCOODCFDDP().DNILNCLIHAP("Icon"), CCOJBMMKNAP.JMNIGPHCAEJ().HHLECNIFHCO("frds"), new UnityAction(this.CKKKHKJMNDF), (DFGILFBGPLN)(-36), 921f, 20);
			}
			ApplicationFocusManager.Restore();
			return;
		}
		if (this.AOCIKAOPPDL != HHCKLPJJKIJ.none)
		{
			this.EEDHNEIMAPN = this.AOCIKAOPPDL;
			this.AOCIKAOPPDL = HHCKLPJJKIJ.facebook;
			this.MOENJALMPJO();
			return;
		}
		CommonUserInterface.EHBBFMCILPC.MCJIGJMFBMI();
		CommonUserInterface.EHBBFMCILPC.JJPNFAAPFBI(CCOJBMMKNAP.BBGECIKOICE().OHLNGCKIACD(""), CCOJBMMKNAP.MPCBJEIMACA().HPOAGPJFHPM("SocialStatsUserPublicProfile.modified = true, SetCompletedChaptersCount()"), CCOJBMMKNAP.HJGDLOOHNLO().IPEIONBNIPH("avtssnap"), new UnityAction(this.EBIPCPGJDMB), new UnityAction(this.FMNPEODNAIG), DFGILFBGPLN.popupWatchAdGetFreeDiamonds, 96f, 23);
		ApplicationFocusManager.Restore();
	}

	// Token: 0x0600A233 RID: 41523 RVA: 0x00464090 File Offset: 0x00462290
	private void NMPEONJMPDH()
	{
		if (this.GDEIABKFOOA != JCAPGCCNOMP.auto)
		{
			CommonUserInterface.IKNOFBFMPGA().HideConnectingAnimation();
			if (this.EEDHNEIMAPN == (HHCKLPJJKIJ)8 && AOBJLALDBAA.DBLAIDPICIG().NMMKHABKLKK() == -92)
			{
				CommonUserInterface.EHBBFMCILPC.PEBIFCENHAL(CCOJBMMKNAP.FEEDGKCJBLE().OHLNGCKIACD("profileoption"), CCOJBMMKNAP.ILACPHFEDEP().GLEFEKBDHNK("Critical error, could not load asset bundle:"), CCOJBMMKNAP.PMABBOJDELF().GGPHHLGPMPA("ok"), new UnityAction(this.OnSignInRetry), DFGILFBGPLN.popupRemoveAds, 1931f, 50);
			}
			else
			{
				CommonUserInterface.IKNOFBFMPGA().PEBIFCENHAL(CCOJBMMKNAP.NIOJNOFGIJO().JCDFHKDNEDH("b_web"), CCOJBMMKNAP.PLJMLDOCPNM().OGKGHLHHAAI(" cached requests."), CCOJBMMKNAP.INKJIBDDMLL().JHNELLJFBGC(""), new UnityAction(this.EBIPCPGJDMB), (DFGILFBGPLN)109, 1949f, -15);
			}
			ApplicationFocusManager.Restore();
			return;
		}
		if (this.AOCIKAOPPDL != HHCKLPJJKIJ.none)
		{
			this.EEDHNEIMAPN = this.AOCIKAOPPDL;
			this.AOCIKAOPPDL = HHCKLPJJKIJ.none;
			this.EBIPCPGJDMB();
			return;
		}
		CommonUserInterface.EHBBFMCILPC.MCJIGJMFBMI();
		CommonUserInterface.IKNOFBFMPGA().ShowGenericPopupTwoOverride(CCOJBMMKNAP.BFHKGNBFHCH().BDGPNPNIAPA(""), CCOJBMMKNAP.DBFFFOMCLKM().FIENAKIHNOM("OnLiveProfileThemesLoaderStart"), CCOJBMMKNAP.KLAKLFCOMJC().HPOAGPJFHPM("OnStoryChoiceClick"), new UnityAction(this.BLAHDOIPOJG), new UnityAction(this.ALCHHKHOHJE), (DFGILFBGPLN)90, 1928f, -51);
		ApplicationFocusManager.Restore();
	}

	// Token: 0x0600A234 RID: 41524 RVA: 0x004641F8 File Offset: 0x004623F8
	private void MDKCJLEPIOD()
	{
		CommonUserInterface.EHBBFMCILPC.MCJIGJMFBMI();
		NPJNALLPFPO lastOperationCode = BackendOperationsManager.EHBBFMCILPC.GetLastOperationCode();
		if (lastOperationCode - NPJNALLPFPO.success <= 3)
		{
			if (this.GDEIABKFOOA == JCAPGCCNOMP.auto)
			{
				CommonUserInterface.EHBBFMCILPC.ShowGenericPopupTwoOverride(CCOJBMMKNAP.GIOAFDDKKHI().GGPHHLGPMPA("envpind"), CCOJBMMKNAP.INKJIBDDMLL().JHNELLJFBGC("tm"), CCOJBMMKNAP.FEEDGKCJBLE().PKNHKGMNCIP("ok"), new UnityAction(this.EBIPCPGJDMB), new UnityAction(this.CKKKHKJMNDF), DFGILFBGPLN.popoverLobbyRewards, 770f, 46);
				ApplicationFocusManager.Restore();
				return;
			}
			CommonUserInterface.IKNOFBFMPGA().BGJFCEEDGFJ(CCOJBMMKNAP.CPCOODCFDDP().IPEIONBNIPH("socialsendgiftprembody"), CCOJBMMKNAP.KFDLFGHBPLP().OHLNGCKIACD("OnLoungeUnlockNpcSkinSuccess"), CCOJBMMKNAP.PMABBOJDELF().HPOAGPJFHPM("\n"), new UnityAction(this.CKKKHKJMNDF), (DFGILFBGPLN)(-94), 1460f, 8);
			ApplicationFocusManager.Restore();
			return;
		}
		else
		{
			if (this.GDEIABKFOOA == JCAPGCCNOMP.none)
			{
				CommonUserInterface.EHBBFMCILPC.JJPNFAAPFBI(CCOJBMMKNAP.APGODIBBPOD().IKMNGFIDCLM("cardsdesc"), CCOJBMMKNAP.LMCCLMFGEBD().BDGPNPNIAPA("xx"), CCOJBMMKNAP.HEDIEIICOOG().GGPHHLGPMPA("Starting parallel download:"), new UnityAction(this.MOENJALMPJO), new UnityAction(this.BLAHDOIPOJG), DFGILFBGPLN.popupSkinShopInfo, 98f, 83);
				ApplicationFocusManager.Restore();
				return;
			}
			CommonUserInterface.IKNOFBFMPGA().PEBIFCENHAL(CCOJBMMKNAP.NIOJNOFGIJO().BGELFMIOBCL("StorySaveBody.GetAvatarsSnapshotsCountWardrobe(), unsupported wardrobe index:"), CCOJBMMKNAP.CPCOODCFDDP().FCOCLEHKLDJ("CLIENT.SCREEN.REWARD."), CCOJBMMKNAP.BFHKGNBFHCH().HPOAGPJFHPM("hint0"), new UnityAction(this.LJIEDAGBAJD), DFGILFBGPLN.popupTutorialLobby1, 329f, 65);
			ApplicationFocusManager.Restore();
			return;
		}
	}

	// Token: 0x0600A235 RID: 41525 RVA: 0x004631B7 File Offset: 0x004613B7
	private void LPMPMAJGALN()
	{
		if (AccountSignInManager.IKLAPGJDMNA == this)
		{
			AccountSignInManager.IKLAPGJDMNA = null;
		}
	}

	// Token: 0x0600A236 RID: 41526 RVA: 0x00464398 File Offset: 0x00462598
	public static AccountSignInManager KMNBCEMEBBD()
	{
		if (!AccountSignInManager.IKLAPGJDMNA)
		{
			AccountSignInManager.IKLAPGJDMNA = (UnityEngine.Object.FindObjectOfType(typeof(AccountSignInManager)) as AccountSignInManager);
			if (!AccountSignInManager.IKLAPGJDMNA)
			{
				DPGJIJGOCIC.ANOPFDLPKGC("continue");
			}
		}
		return AccountSignInManager.IKLAPGJDMNA;
	}

	// Token: 0x0600A237 RID: 41527 RVA: 0x004643E8 File Offset: 0x004625E8
	public void StartSignInLogic(HHCKLPJJKIJ OIOBCPFDLFE, JCAPGCCNOMP CCIAGBPILGF, HHCKLPJJKIJ ABMPLLPPDGK, byte FIGKJIAEMON = 0)
	{
		ApplicationFocusManager.Deactivate();
		this.GCKCOMCBHMB = FIGKJIAEMON;
		this.AOCIKAOPPDL = ABMPLLPPDGK;
		this.EEDHNEIMAPN = OIOBCPFDLFE;
		this.GDEIABKFOOA = CCIAGBPILGF;
		if (this.EEDHNEIMAPN != HHCKLPJJKIJ.token)
		{
			CommonUserInterface.EHBBFMCILPC.ShowConnectingAnimationWithHint(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("hintsigning"), this.GCKCOMCBHMB);
		}
		if (this.EEDHNEIMAPN == HHCKLPJJKIJ.facebook)
		{
			if (FacebookManager.EHBBFMCILPC.IsLoggedIn())
			{
				this.GLNIBIBMAOL();
				return;
			}
			FacebookManager.EHBBFMCILPC.LogIn();
			return;
		}
		else if (this.EEDHNEIMAPN == HHCKLPJJKIJ.google)
		{
			if (GooglePlayServicesManager.EHBBFMCILPC.IsLoggedIn())
			{
				this.GLNIBIBMAOL();
				return;
			}
			GooglePlayServicesManager.EHBBFMCILPC.LogIn(CCIAGBPILGF);
			return;
		}
		else if (this.EEDHNEIMAPN == HHCKLPJJKIJ.apple)
		{
			if (AppleSignInManager.EHBBFMCILPC.IsLoggedIn())
			{
				this.GLNIBIBMAOL();
				return;
			}
			AppleSignInManager.EHBBFMCILPC.LogIn();
			return;
		}
		else if (this.EEDHNEIMAPN == HHCKLPJJKIJ.steam)
		{
			if (SteamSignInManager.EHBBFMCILPC.IsLoggedIn())
			{
				this.GLNIBIBMAOL();
				return;
			}
			SteamSignInManager.EHBBFMCILPC.LogIn();
			return;
		}
		else if (this.EEDHNEIMAPN == HHCKLPJJKIJ.token)
		{
			if (CCIAGBPILGF != JCAPGCCNOMP.user)
			{
				DPGJIJGOCIC.ANOPFDLPKGC("AccountSignInManager.StartSignInLogic() - AccountSignInMethod.token sign in method not supported for auto source, falling back to device id.");
				this.EEDHNEIMAPN = HHCKLPJJKIJ.device;
				this.GLNIBIBMAOL();
				CommonUserInterface.EHBBFMCILPC.ShowConnectingAnimationWithHint(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("hintsigning"), this.GCKCOMCBHMB);
				return;
			}
			if (UserpassSignInManager.EHBBFMCILPC.IsLoggedIn())
			{
				this.GLNIBIBMAOL();
				return;
			}
			UserpassSignInManager.EHBBFMCILPC.LogIn();
			return;
		}
		else
		{
			if (this.EEDHNEIMAPN == HHCKLPJJKIJ.device)
			{
				this.GLNIBIBMAOL();
				return;
			}
			DPGJIJGOCIC.ANOPFDLPKGC("AccountSignInManager.StartSignInLogic() - sign in method not implemented.");
			return;
		}
	}

	// Token: 0x0600A238 RID: 41528 RVA: 0x00464558 File Offset: 0x00462758
	private void EPEFMEFBPGK()
	{
		CommonUserInterface.IKNOFBFMPGA().MCJIGJMFBMI();
		NPJNALLPFPO npjnallpfpo = BackendOperationsManager.EHBBFMCILPC.AINFDIJGNCN();
		if (npjnallpfpo - NPJNALLPFPO.success <= 4)
		{
			if (this.GDEIABKFOOA == JCAPGCCNOMP.none)
			{
				CommonUserInterface.IKNOFBFMPGA().JJPNFAAPFBI(CCOJBMMKNAP.LMCCLMFGEBD().PKNHKGMNCIP("yes"), CCOJBMMKNAP.COKDLDOAACJ().BGELFMIOBCL("[LoadingEnv] "), CCOJBMMKNAP.CPCOODCFDDP().HDIPNMFHIEJ("PurchaseManagerSteam.InitiateTransactionSteam(). Condition not passed: initiatedPurchase is null. Aborting."), new UnityAction(this.ACBONKCAECN), new UnityAction(this.EMGIDHDADBM), DFGILFBGPLN.popupGamePassDuration, 1398f, -28);
				ApplicationFocusManager.Restore();
				return;
			}
			CommonUserInterface.IKNOFBFMPGA().PEBIFCENHAL(CCOJBMMKNAP.CEGAOMEEFBE().IPEIONBNIPH("socialbadgelocked"), CCOJBMMKNAP.LMCCLMFGEBD().IKMNGFIDCLM("spppd"), CCOJBMMKNAP.INKJIBDDMLL().HHLECNIFHCO("OnResolutionChanged"), new UnityAction(this.MOENJALMPJO), (DFGILFBGPLN)(-120), 1168f, 21);
			ApplicationFocusManager.Restore();
			return;
		}
		else
		{
			if (this.GDEIABKFOOA == JCAPGCCNOMP.none)
			{
				CommonUserInterface.IKNOFBFMPGA().ShowGenericPopupTwoOverride(CCOJBMMKNAP.KMNBCEMEBBD().IKMNGFIDCLM("<size=28px><align=\"center\"><i>"), CCOJBMMKNAP.GIOAFDDKKHI().PKNHKGMNCIP("<i>"), CCOJBMMKNAP.CPCOODCFDDP().FCOCLEHKLDJ("WWW"), new UnityAction(this.OnSignInRetry), new UnityAction(this.LJIEDAGBAJD), DFGILFBGPLN.popupSeasonComplete, 1393f, 119);
				ApplicationFocusManager.Restore();
				return;
			}
			CommonUserInterface.EHBBFMCILPC.ShowGenericPopupOneOverride(CCOJBMMKNAP.PLJMLDOCPNM().OGKGHLHHAAI(""), CCOJBMMKNAP.BOFMCPPFAMO().HIPJILDCHJC("ok"), CCOJBMMKNAP.ILACPHFEDEP().HPOAGPJFHPM("{month}"), new UnityAction(this.ACBONKCAECN), DFGILFBGPLN.popupTutorialLobby0, 1566f, -111);
			ApplicationFocusManager.Restore();
			return;
		}
	}

	// Token: 0x0600A239 RID: 41529 RVA: 0x004646F8 File Offset: 0x004628F8
	private void EABGGFOKINI()
	{
		CommonUserInterface.EHBBFMCILPC.MCJIGJMFBMI();
		AKLFPGMDKLA.EHBBFMCILPC.EEDHNEIMAPN = (int)this.EEDHNEIMAPN;
		if (this.GDEIABKFOOA == JCAPGCCNOMP.auto)
		{
			if (!AKLFPGMDKLA.EHBBFMCILPC.INEKFCLBCAB())
			{
				CommonUserInterface.IKNOFBFMPGA().CEGLPJNLBHL(CCOJBMMKNAP.MPCBJEIMACA().PPALCPINPLK("OnPopupPasswordInputCancel"), CCOJBMMKNAP.OBOOKJPGBJN().JLBEIFLLBLO("-"), CCOJBMMKNAP.CPCOODCFDDP().JHNELLJFBGC(" path FAILED - "), new UnityAction(this.PIABINHPMMM), new UnityAction(this.ABALICGDAIM), (DFGILFBGPLN)(-93), 384f, 107);
				ApplicationFocusManager.Restore();
			}
			else if (this.EEDHNEIMAPN == HHCKLPJJKIJ.none)
			{
				CommonUserInterface.EHBBFMCILPC.ShowGenericPopup(CCOJBMMKNAP.MLFAGAAJJEM().BGELFMIOBCL(")"), CCOJBMMKNAP.CPCOODCFDDP().FCOCLEHKLDJ("newtutorialgifts"), CCOJBMMKNAP.LMCCLMFGEBD().HIPJILDCHJC("OnBackendGetPublicProfileHallOfFameException"), DFGILFBGPLN.popupComingSoon, 330f, -5);
				ApplicationFocusManager.Restore();
			}
			else if (this.EEDHNEIMAPN == HHCKLPJJKIJ.apple)
			{
				CommonUserInterface.EHBBFMCILPC.NFBMHHPIGFA(CCOJBMMKNAP.BOFMCPPFAMO().GLEFEKBDHNK("OnRewardReplayEpisodeClick"), CCOJBMMKNAP.COKDLDOAACJ().GLEFEKBDHNK("YYY"), CCOJBMMKNAP.HFAKOKBHCGH().JLBEIFLLBLO("mussind"), (DFGILFBGPLN)(-50), 1060f, -61);
				ApplicationFocusManager.Restore();
			}
			else if (this.EEDHNEIMAPN == HHCKLPJJKIJ.facebook)
			{
				CommonUserInterface.EHBBFMCILPC.ShowGenericPopup(CCOJBMMKNAP.MLFAGAAJJEM().OGKGHLHHAAI("Error. FadeSrc(), layer "), CCOJBMMKNAP.OBOOKJPGBJN().DNILNCLIHAP("ok"), CCOJBMMKNAP.BOFMCPPFAMO().OBDCPLLLGBB("vsv"), (DFGILFBGPLN)(-13), 1256f, 39);
				ApplicationFocusManager.Restore();
			}
			else if (this.EEDHNEIMAPN == HHCKLPJJKIJ.google)
			{
				CommonUserInterface.EHBBFMCILPC.NFBMHHPIGFA(CCOJBMMKNAP.DBFFFOMCLKM().JCDFHKDNEDH("): code="), CCOJBMMKNAP.BBGECIKOICE().PKNHKGMNCIP("-"), CCOJBMMKNAP.PMABBOJDELF().GGPHHLGPMPA("OnBackendGetIncentRewardAdException"), (DFGILFBGPLN)92, 1382f, -16);
				ApplicationFocusManager.Restore();
			}
			else if (this.EEDHNEIMAPN == HHCKLPJJKIJ.google)
			{
				CommonUserInterface.IKNOFBFMPGA().ShowGenericPopup(CCOJBMMKNAP.HEDIEIICOOG().HPOAGPJFHPM(""), CCOJBMMKNAP.KFDLFGHBPLP().HDIPNMFHIEJ("body"), CCOJBMMKNAP.DBFFFOMCLKM().IPEIONBNIPH("energyhinttitle"), DFGILFBGPLN.popupNewStoryRevision, 1802f, 5);
				ApplicationFocusManager.Restore();
			}
			else
			{
				DPGJIJGOCIC.ANOPFDLPKGC("Critical error, could not load asset bundle:");
			}
		}
		else if (this.GDEIABKFOOA == JCAPGCCNOMP.none)
		{
			if (!AKLFPGMDKLA.EHBBFMCILPC.MAIKELGDHMI())
			{
				AKLFPGMDKLA.EHBBFMCILPC.IDPFOGHKMBL();
				CommonUserInterface.IKNOFBFMPGA().CEGLPJNLBHL(CCOJBMMKNAP.EAIAHCBAIEJ().JHNELLJFBGC("_StripeVelocity"), CCOJBMMKNAP.DBFFFOMCLKM().JCDFHKDNEDH(""), CCOJBMMKNAP.KFDLFGHBPLP().JCDFHKDNEDH("OnAllCollectableCardsDownloadFailed"), new UnityAction(this.FMNPEODNAIG), new UnityAction(this.ALCHHKHOHJE), (DFGILFBGPLN)85, 600f, -100);
				ApplicationFocusManager.Restore();
			}
			else
			{
				FirebaseAnalyticsManager.COKDLDOAACJ().LogEvent(true, AGEHCPDNBFD.rqst.ToString(), ((FFPHBMFGCNN)(-116)).ToString(), ((BGHLMGPPCNN)(-121)).ToString(), true, false);
				this.FMNPEODNAIG();
				AKLFPGMDKLA.EHBBFMCILPC.MJPKIMHENNF = 1;
				AKLFPGMDKLA.EHBBFMCILPC.OOEJIIJLKPK = 0;
			}
		}
		else
		{
			DPGJIJGOCIC.ANOPFDLPKGC("XXX");
		}
		AKLFPGMDKLA.EHBBFMCILPC.LPCBDEBKAIM();
	}

	// Token: 0x0600A23A RID: 41530 RVA: 0x00464A40 File Offset: 0x00462C40
	private void ONIAHGBGAFJ()
	{
		if (AppManager.isQuitting)
		{
			return;
		}
		AOBJLALDBAA.BIAEAOMHBMM().PBELMJCPJMK("OnSceneStoryManagerPremiumChoiceAdsProviderAdFailed", new UnityAction(this.PMFNDCJEIHF));
		AOBJLALDBAA.AGANFKKBPFO().PBELMJCPJMK("ok", new UnityAction(this.LHAOOFAEFPD));
		AOBJLALDBAA.BIAEAOMHBMM().MANLHALMCIH("\n\n", new UnityAction(this.AJLNFEDJLHA));
		AOBJLALDBAA.KKPFOJMAONG().POLEDPIKODD("", new UnityAction(this.JJPMBIHBPMK));
		AOBJLALDBAA.KKPFOJMAONG().ECDBIBPNBCO("hcfc", new UnityAction(this.PKEHEJFHGBD));
		AOBJLALDBAA.NMGMNAKLLMI().POLEDPIKODD("-", new UnityAction(this.AJLNFEDJLHA));
		AOBJLALDBAA.KKPFOJMAONG().NAMMLDPCHJO("profilemycredolong", new UnityAction(this.AHOOIECMGCJ));
		AOBJLALDBAA.KKPFOJMAONG().MHLNJIACIGO("assetbundlenpcanimationpack", new UnityAction(this.PDIEDPJEOKG));
		AOBJLALDBAA.CEGAOMEEFBE().ECDBIBPNBCO("energyhinttitle", new UnityAction(this.JJPMBIHBPMK));
		AOBJLALDBAA.EHBBFMCILPC.PFAHGKEDFAE("Account.GetStorySaveUnsafe(), _slotIndex out of bounds.", new UnityAction(this.PDIEDPJEOKG));
		AOBJLALDBAA.NMGMNAKLLMI().ECDBIBPNBCO("' is not 0 / 1, the npc animations stay ON: ", new UnityAction(this.GDCJEIGGDPL));
		AOBJLALDBAA.KKPFOJMAONG().POLEDPIKODD("$IMPORTVARS", new UnityAction(this.LMOIOINJFPN));
		AOBJLALDBAA.DBLAIDPICIG().ONIBLJOFFPG("OnBackendUpdateFriendsDataSuccess", new UnityAction(this.OFKNGIOLILC));
	}

	// Token: 0x0600A23B RID: 41531 RVA: 0x000693D6 File Offset: 0x000675D6
	private void JFFNFDKBMGP()
	{
		UnityEngine.Object.DontDestroyOnLoad(base.gameObject);
	}

	// Token: 0x0600A23C RID: 41532 RVA: 0x00464BB4 File Offset: 0x00462DB4
	private void KPNLKBPCDAF()
	{
		if (AppManager.isQuitting)
		{
			return;
		}
		AOBJLALDBAA.FILDBDMENPG().MHLNJIACIGO("Asset bundle load operation failed during parallel mode.", new UnityAction(this.PMFNDCJEIHF));
		AOBJLALDBAA.EHBBFMCILPC.ECDBIBPNBCO("p", new UnityAction(this.PPABHIGDMFD));
		AOBJLALDBAA.CEGAOMEEFBE().POLEDPIKODD("Loaded asset bundle:", new UnityAction(this.BEKGFLJPBAP));
		AOBJLALDBAA.KKPFOJMAONG().PFAHGKEDFAE("OnStorySplashManagerAdsProviderAdSuccess", new UnityAction(this.PPABHIGDMFD));
		AOBJLALDBAA.NMGMNAKLLMI().PFAHGKEDFAE(" not found.", new UnityAction(this.PKEHEJFHGBD));
		AOBJLALDBAA.FILDBDMENPG().PFAHGKEDFAE("OnBackendPublishSketchException", new UnityAction(this.GLNIBIBMAOL));
		AOBJLALDBAA.NMGMNAKLLMI().ONIBLJOFFPG("sparklesbundles", new UnityAction(this.BAMHKOINDCE));
		AOBJLALDBAA.BIAEAOMHBMM().MANLHALMCIH("", new UnityAction(this.AJLNFEDJLHA));
		AOBJLALDBAA.CEGAOMEEFBE().KDIFKFKMCOH("", new UnityAction(this.AHOOIECMGCJ));
		AOBJLALDBAA.KKPFOJMAONG().ONIBLJOFFPG("XXX", new UnityAction(this.GLNIBIBMAOL));
		AOBJLALDBAA.FILDBDMENPG().MHLNJIACIGO("PurchaseManagerUnity.Initialize(): Unity Gaming Services not initialized.", new UnityAction(this.FCMCBKANOCD));
		AOBJLALDBAA.AGANFKKBPFO().NAMMLDPCHJO("x", new UnityAction(this.ELBNDIHJGNB));
		AOBJLALDBAA.AGANFKKBPFO().KDIFKFKMCOH("OnBackendRequestConsumeMessageException", new UnityAction(this.IGKHLOOIMAJ));
	}

	// Token: 0x0600A23D RID: 41533 RVA: 0x000693D6 File Offset: 0x000675D6
	private void MDNEOMGLGIN()
	{
		UnityEngine.Object.DontDestroyOnLoad(base.gameObject);
	}

	// Token: 0x0600A23E RID: 41534 RVA: 0x00464D28 File Offset: 0x00462F28
	private void FCOKGLDPJJO()
	{
		AOBJLALDBAA.CEGAOMEEFBE().PEFKJOKLEDL("lsn", new UnityAction(this.GLNIBIBMAOL));
		AOBJLALDBAA.BIAEAOMHBMM().EFKNEJFLGED("yes", new UnityAction(this.AHOOIECMGCJ));
		AOBJLALDBAA.FILDBDMENPG().BADOPKAOCPE("XXX", new UnityAction(this.GLNIBIBMAOL));
		AOBJLALDBAA.DBLAIDPICIG().PEFKJOKLEDL("OnStoryCurrencyInfoClick", new UnityAction(this.FCMCBKANOCD));
		AOBJLALDBAA.EHBBFMCILPC.MFIMALJPCDP("common", new UnityAction(this.CNAGABDCIDJ));
		AOBJLALDBAA.NMGMNAKLLMI().FNMOFCMDFJP("sponsortitle", new UnityAction(this.PMFNDCJEIHF));
		AOBJLALDBAA.NMGMNAKLLMI().GNBGEMMDGOJ("Vol", new UnityAction(this.PPABHIGDMFD));
		AOBJLALDBAA.KKPFOJMAONG().BADOPKAOCPE("Xg", new UnityAction(this.GLNIBIBMAOL));
		AOBJLALDBAA.NMGMNAKLLMI().PEFKJOKLEDL("p", new UnityAction(this.BAMHKOINDCE));
		AOBJLALDBAA.AGANFKKBPFO().BADOPKAOCPE("importanttitle", new UnityAction(this.BEKGFLJPBAP));
		AOBJLALDBAA.EHBBFMCILPC.MFIMALJPCDP("AnthologySave.AddAvatarComponent(), unsupported wardrobe index:", new UnityAction(this.BAMHKOINDCE));
		AOBJLALDBAA.FILDBDMENPG().MFIMALJPCDP("ChapterSnapshotsItem.OnChapterSnapshotRestore(): impossible condition 3", new UnityAction(this.OPBMKIPPJOC));
		AOBJLALDBAA.AGANFKKBPFO().MFIMALJPCDP("ok", new UnityAction(this.CKBGMFFKOBH));
	}

	// Token: 0x0600A23F RID: 41535 RVA: 0x00464E94 File Offset: 0x00463094
	private void BAMHKOINDCE()
	{
		if (this.GDEIABKFOOA != JCAPGCCNOMP.none)
		{
			CommonUserInterface.EHBBFMCILPC.HideConnectingAnimation();
			if (this.EEDHNEIMAPN == HHCKLPJJKIJ.google && AOBJLALDBAA.EHBBFMCILPC.MJLACDOKGNE() == 40)
			{
				CommonUserInterface.EHBBFMCILPC.ShowGenericPopupOneOverride(CCOJBMMKNAP.DBFFFOMCLKM().OHLNGCKIACD("msg64"), CCOJBMMKNAP.JMNIGPHCAEJ().GGPHHLGPMPA("anthology"), CCOJBMMKNAP.JINDKPHNLBK().JCDFHKDNEDH("def"), new UnityAction(this.EBIPCPGJDMB), (DFGILFBGPLN)(-4), 669f, 61);
			}
			else
			{
				CommonUserInterface.EHBBFMCILPC.BGJFCEEDGFJ(CCOJBMMKNAP.JMDJPKKOHNI().JHNELLJFBGC("OnSaveSlotDelete"), CCOJBMMKNAP.OEPENBHJAHO().PPALCPINPLK("SaveSlotsItem.DuplicateSlot(): anthologySave is null"), CCOJBMMKNAP.PEBMGCKFNAO().OGKGHLHHAAI("%"), new UnityAction(this.ACBONKCAECN), (DFGILFBGPLN)(-90), 109f, -82);
			}
			ApplicationFocusManager.Restore();
			return;
		}
		if (this.AOCIKAOPPDL != HHCKLPJJKIJ.none)
		{
			this.EEDHNEIMAPN = this.AOCIKAOPPDL;
			this.AOCIKAOPPDL = HHCKLPJJKIJ.facebook;
			this.EBIPCPGJDMB();
			return;
		}
		CommonUserInterface.IKNOFBFMPGA().MCJIGJMFBMI();
		CommonUserInterface.IKNOFBFMPGA().JJPNFAAPFBI(CCOJBMMKNAP.OBOOKJPGBJN().HIPJILDCHJC("prgr"), CCOJBMMKNAP.KNKGCDDMLDP().BDGPNPNIAPA("OnBackendRequestFriendDeleteException"), CCOJBMMKNAP.INKJIBDDMLL().MEPECBDCOLG("af_revenue"), new UnityAction(this.BLAHDOIPOJG), new UnityAction(this.PIABINHPMMM), DFGILFBGPLN.popupWatchAdDoubleReward, 1990f, 96);
		ApplicationFocusManager.Restore();
	}

	// Token: 0x0600A240 RID: 41536 RVA: 0x00464FFC File Offset: 0x004631FC
	private void NPEKGGOPGIB()
	{
		if (AppManager.isQuitting)
		{
			return;
		}
		AOBJLALDBAA.NMGMNAKLLMI().POLEDPIKODD("OnSketchThumbnailPublish", new UnityAction(this.PDIEDPJEOKG));
		AOBJLALDBAA.BIAEAOMHBMM().NAMMLDPCHJO("", new UnityAction(this.FCMCBKANOCD));
		AOBJLALDBAA.NMGMNAKLLMI().KDIFKFKMCOH("continue", new UnityAction(this.BEKGFLJPBAP));
		AOBJLALDBAA.CEGAOMEEFBE().POLEDPIKODD("CLIENT.AVATAR.OVERLAY", new UnityAction(this.LHAOOFAEFPD));
		AOBJLALDBAA.EHBBFMCILPC.PFAHGKEDFAE("StoriesSearchBalance - stopwords row with unknown language '", new UnityAction(this.PKEHEJFHGBD));
		AOBJLALDBAA.BIAEAOMHBMM().NAMMLDPCHJO("XXX", new UnityAction(this.PMFNDCJEIHF));
		AOBJLALDBAA.KKPFOJMAONG().ECDBIBPNBCO("sfxsparklesbundles", new UnityAction(this.FCMCBKANOCD));
		AOBJLALDBAA.NMGMNAKLLMI().POLEDPIKODD(")", new UnityAction(this.BEKGFLJPBAP));
		AOBJLALDBAA.CEGAOMEEFBE().PFAHGKEDFAE("variant", new UnityAction(this.JJPMBIHBPMK));
		AOBJLALDBAA.NMGMNAKLLMI().ECDBIBPNBCO("", new UnityAction(this.PMFNDCJEIHF));
		AOBJLALDBAA.AGANFKKBPFO().ONIBLJOFFPG("newtutorialhalloffame", new UnityAction(this.BAMHKOINDCE));
		AOBJLALDBAA.EHBBFMCILPC.MHLNJIACIGO("OnPopupPasswordInputEndEdit", new UnityAction(this.AKDJAMPCINC));
		AOBJLALDBAA.AGANFKKBPFO().POLEDPIKODD("varCondition", new UnityAction(this.IGKHLOOIMAJ));
	}

	// Token: 0x0600A241 RID: 41537 RVA: 0x00465170 File Offset: 0x00463370
	private void PDIEDPJEOKG()
	{
		BackendOperationsManager.NPDDBAONMJP().CleanCachedRequestsData();
		if (this.EEDHNEIMAPN == HHCKLPJJKIJ.facebook)
		{
			if (BackendOperationsManager.NPDDBAONMJP().IsAccountSignInDataValid(FacebookManager.FKKEPJFEELL().GetUserId(), this.EEDHNEIMAPN))
			{
				BackendOperationsManager.EHBBFMCILPC.RequestAccountSignIn(FacebookManager.CEGAOMEEFBE().OEKMDNHEINC(), this.EEDHNEIMAPN, "retry", "\"");
				return;
			}
			this.FMNNCEKBHDG();
			return;
		}
		else
		{
			if (this.EEDHNEIMAPN == HHCKLPJJKIJ.none)
			{
				BackendOperationsManager.EHBBFMCILPC.RequestAccountSignIn(GooglePlayServicesManager.EHBBFMCILPC.GGLDDPOPIJJ(), this.EEDHNEIMAPN, "upgcds", "");
				return;
			}
			if (this.EEDHNEIMAPN == HHCKLPJJKIJ.steam)
			{
				BackendOperationsManager.EHBBFMCILPC.RequestAccountSignIn(AppleSignInManager.KIKOEJMHOEH().KFAPMPLIKGB(), this.EEDHNEIMAPN, "p", "af_content_id");
				return;
			}
			if (this.EEDHNEIMAPN == HHCKLPJJKIJ.apple)
			{
				BackendOperationsManager.NPDDBAONMJP().RequestAccountSignIn(SteamSignInManager.BFCHJBOOJKE().PAAEPINFJOE(), this.EEDHNEIMAPN, "OnPopupProfileCredoInputCancel", "BackendOperationsManager.RequestGetPremiumChoicesHistory, exception while initializing RSACryptoServiceProvider:");
				return;
			}
			if (this.EEDHNEIMAPN == HHCKLPJJKIJ.none)
			{
				CommonUserInterface.IKNOFBFMPGA().ShowConnectingAnimationWithHint(CCOJBMMKNAP.BOFMCPPFAMO().BGELFMIOBCL("OnUserpassLoginSuccess"), this.GCKCOMCBHMB);
				BackendOperationsManager.EHBBFMCILPC.RequestAccountSignIn(UserpassSignInManager.NMGMNAKLLMI().NLHCMOHOMHD() + ", to:" + UserpassSignInManager.OHCOHPNEOEG().CNFLHKKDIEC(), this.EEDHNEIMAPN, "OnLiveProfileThemeDownloadFailed", "p");
				return;
			}
			if (this.EEDHNEIMAPN == (HHCKLPJJKIJ)7)
			{
				BackendOperationsManager.EHBBFMCILPC.RequestAccountSignIn(DPGJIJGOCIC.GIIHCODLGCA(), this.EEDHNEIMAPN, "OnBackendGetSketchesBalanceException", "");
				return;
			}
			DPGJIJGOCIC.ANOPFDLPKGC("spld");
			return;
		}
	}

	// Token: 0x0600A242 RID: 41538 RVA: 0x004652F8 File Offset: 0x004634F8
	private void NAAFHFFELKK()
	{
		if (AppManager.isQuitting)
		{
			return;
		}
		AOBJLALDBAA.NMGMNAKLLMI().PBELMJCPJMK("PlayerCharacterManager.UpdateComponentLink() - invalid custom hierarchy for ", new UnityAction(this.BEKGFLJPBAP));
		AOBJLALDBAA.EHBBFMCILPC.ECDBIBPNBCO("assetpack", new UnityAction(this.GDCJEIGGDPL));
		AOBJLALDBAA.FILDBDMENPG().POLEDPIKODD("", new UnityAction(this.AJLNFEDJLHA));
		AOBJLALDBAA.DBLAIDPICIG().PBELMJCPJMK("", new UnityAction(this.PPABHIGDMFD));
		AOBJLALDBAA.DBLAIDPICIG().PFAHGKEDFAE("lrewsnap", new UnityAction(this.CNAGABDCIDJ));
		AOBJLALDBAA.AGANFKKBPFO().NAMMLDPCHJO("avts", new UnityAction(this.BEKGFLJPBAP));
		AOBJLALDBAA.EHBBFMCILPC.MHLNJIACIGO("s", new UnityAction(this.JJPMBIHBPMK));
		AOBJLALDBAA.FILDBDMENPG().MHLNJIACIGO("] | ", new UnityAction(this.GLNIBIBMAOL));
		AOBJLALDBAA.NMGMNAKLLMI().ONIBLJOFFPG("syn", new UnityAction(this.BAMHKOINDCE));
		AOBJLALDBAA.NMGMNAKLLMI().POLEDPIKODD("hint3", new UnityAction(this.GLNIBIBMAOL));
		AOBJLALDBAA.AGANFKKBPFO().KDIFKFKMCOH("spectrum", new UnityAction(this.AHOOIECMGCJ));
		AOBJLALDBAA.DBLAIDPICIG().PBELMJCPJMK("gpshub", new UnityAction(this.EABGGFOKINI));
		AOBJLALDBAA.AGANFKKBPFO().MHLNJIACIGO("", new UnityAction(this.KNPDJHHJFIB));
	}

	// Token: 0x0600A243 RID: 41539 RVA: 0x0046546C File Offset: 0x0046366C
	private void MIFFMELELIN()
	{
		CommonUserInterface.IKNOFBFMPGA().HideConnectingAnimation();
		NPJNALLPFPO npjnallpfpo = BackendOperationsManager.NPDDBAONMJP().AINFDIJGNCN();
		if (npjnallpfpo - NPJNALLPFPO.success <= 5)
		{
			if (this.GDEIABKFOOA == JCAPGCCNOMP.none)
			{
				CommonUserInterface.IKNOFBFMPGA().CEGLPJNLBHL(CCOJBMMKNAP.HJGDLOOHNLO().HDIPNMFHIEJ("OnAllCollectableCardsDownloadFailed"), CCOJBMMKNAP.KLAKLFCOMJC().HIPJILDCHJC("lititle"), CCOJBMMKNAP.DBFFFOMCLKM().OHLNGCKIACD("asp"), new UnityAction(this.LJIEDAGBAJD), new UnityAction(this.ACBONKCAECN), DFGILFBGPLN.screenLoading, 251f, -121);
				ApplicationFocusManager.Restore();
				return;
			}
			CommonUserInterface.IKNOFBFMPGA().PEBIFCENHAL(CCOJBMMKNAP.BIAEAOMHBMM().OHLNGCKIACD("OnApplicationRestart"), CCOJBMMKNAP.KLAKLFCOMJC().OHLNGCKIACD(""), CCOJBMMKNAP.FEEDGKCJBLE().DNILNCLIHAP("analogglitchovr"), new UnityAction(this.LJIEDAGBAJD), (DFGILFBGPLN)(-20), 1838f, -126);
			ApplicationFocusManager.Restore();
			return;
		}
		else
		{
			if (this.GDEIABKFOOA == JCAPGCCNOMP.none)
			{
				CommonUserInterface.EHBBFMCILPC.JJPNFAAPFBI(CCOJBMMKNAP.HEDIEIICOOG().OHLNGCKIACD("Choose a look"), CCOJBMMKNAP.BOFMCPPFAMO().FIENAKIHNOM("cleancache"), CCOJBMMKNAP.MLFAGAAJJEM().HPOAGPJFHPM("OnPurchaseSuccess"), new UnityAction(this.BLAHDOIPOJG), new UnityAction(this.BLAHDOIPOJG), (DFGILFBGPLN)(-2), 1881f, 60);
				ApplicationFocusManager.Restore();
				return;
			}
			CommonUserInterface.EHBBFMCILPC.BGJFCEEDGFJ(CCOJBMMKNAP.BOFMCPPFAMO().JLBEIFLLBLO("StorySave.GetChapterSnapshotGuid(), chapterSnapshots/chapterSnapshotsGuids length unsync"), CCOJBMMKNAP.BFHKGNBFHCH().JCDFHKDNEDH("avind"), CCOJBMMKNAP.KNKGCDDMLDP().OGKGHLHHAAI("getStartedChapters"), new UnityAction(this.ACBONKCAECN), DFGILFBGPLN.popupAccountSuspended, 453f, -47);
			ApplicationFocusManager.Restore();
			return;
		}
	}

	// Token: 0x0600A244 RID: 41540 RVA: 0x0046560C File Offset: 0x0046380C
	private void FMBLLOMGEDG()
	{
		AOBJLALDBAA.KKPFOJMAONG().GNBGEMMDGOJ("id", new UnityAction(this.PMFNDCJEIHF));
		AOBJLALDBAA.FILDBDMENPG().BADOPKAOCPE("$e1it", new UnityAction(this.JJPMBIHBPMK));
		AOBJLALDBAA.AGANFKKBPFO().GNBGEMMDGOJ("rain", new UnityAction(this.AJLNFEDJLHA));
		AOBJLALDBAA.CEGAOMEEFBE().GNBGEMMDGOJ("ert", new UnityAction(this.BAMHKOINDCE));
		AOBJLALDBAA.AGANFKKBPFO().MFIMALJPCDP("", new UnityAction(this.HHIHBCJFDON));
		AOBJLALDBAA.EHBBFMCILPC.GNBGEMMDGOJ("sshits", new UnityAction(this.PMFNDCJEIHF));
		AOBJLALDBAA.BIAEAOMHBMM().BADOPKAOCPE("outdatedrev", new UnityAction(this.PPABHIGDMFD));
		AOBJLALDBAA.FILDBDMENPG().PEFKJOKLEDL("<align=\"center\">", new UnityAction(this.BEKGFLJPBAP));
		AOBJLALDBAA.EHBBFMCILPC.FNMOFCMDFJP("price", new UnityAction(this.JJPMBIHBPMK));
		AOBJLALDBAA.AGANFKKBPFO().GNBGEMMDGOJ("<i>", new UnityAction(this.AJLNFEDJLHA));
		AOBJLALDBAA.BIAEAOMHBMM().FNMOFCMDFJP(" could not be revealed", new UnityAction(this.GDCJEIGGDPL));
		AOBJLALDBAA.KKPFOJMAONG().BADOPKAOCPE("High version preview2 assets loaded:", new UnityAction(this.ELBNDIHJGNB));
		AOBJLALDBAA.NMGMNAKLLMI().MFIMALJPCDP("lsc", new UnityAction(this.FMNNCEKBHDG));
	}

	// Token: 0x0600A245 RID: 41541 RVA: 0x00462740 File Offset: 0x00460940
	public JCAPGCCNOMP KIPBGCJOBGK()
	{
		return this.GDEIABKFOOA;
	}

	// Token: 0x0600A246 RID: 41542 RVA: 0x00465778 File Offset: 0x00463978
	private void CKBGMFFKOBH()
	{
		CommonUserInterface.IKNOFBFMPGA().HideConnectingAnimation();
		NPJNALLPFPO lastOperationCode = BackendOperationsManager.NPDDBAONMJP().GetLastOperationCode();
		if (lastOperationCode - NPJNALLPFPO.redSemaphore == 0)
		{
			if (this.GDEIABKFOOA == JCAPGCCNOMP.auto)
			{
				CommonUserInterface.EHBBFMCILPC.ShowGenericPopupTwoOverride(CCOJBMMKNAP.CEGAOMEEFBE().BGELFMIOBCL("XXX"), CCOJBMMKNAP.ONCPHEEJLOP().JCDFHKDNEDH("bdgsspr"), CCOJBMMKNAP.BBGECIKOICE().HDIPNMFHIEJ("StoryStepChoiceExtended.RemoveChoiceAtEnd - _choicesToRemove is <= 0."), new UnityAction(this.CKKKHKJMNDF), new UnityAction(this.EBIPCPGJDMB), (DFGILFBGPLN)91, 1146f, -3);
				ApplicationFocusManager.Restore();
				return;
			}
			CommonUserInterface.IKNOFBFMPGA().BGJFCEEDGFJ(CCOJBMMKNAP.AEELGGPEJCC().JCDFHKDNEDH(""), CCOJBMMKNAP.APGODIBBPOD().BGELFMIOBCL("BackendOperationsManager.RequestGetChapterSnapshots, exception while initializing RSACryptoServiceProvider:"), CCOJBMMKNAP.CPCOODCFDDP().MEPECBDCOLG(""), new UnityAction(this.MOENJALMPJO), (DFGILFBGPLN)(-111), 1206f, 87);
			ApplicationFocusManager.Restore();
			return;
		}
		else
		{
			if (this.GDEIABKFOOA == JCAPGCCNOMP.auto)
			{
				CommonUserInterface.EHBBFMCILPC.CEGLPJNLBHL(CCOJBMMKNAP.PKEINLPIAEH().IKMNGFIDCLM("cdnerror"), CCOJBMMKNAP.COKDLDOAACJ().HHLECNIFHCO("socialdonotdisturb1"), CCOJBMMKNAP.BIAEAOMHBMM().BGELFMIOBCL("F0"), new UnityAction(this.ACBONKCAECN), new UnityAction(this.ACBONKCAECN), (DFGILFBGPLN)(-34), 3f, 67);
				ApplicationFocusManager.Restore();
				return;
			}
			CommonUserInterface.EHBBFMCILPC.ShowGenericPopupOneOverride(CCOJBMMKNAP.JMNIGPHCAEJ().JHNELLJFBGC("OnBackendInitiateSteamTransactionException"), CCOJBMMKNAP.BOFMCPPFAMO().HIPJILDCHJC("sslt"), CCOJBMMKNAP.ILACPHFEDEP().HPOAGPJFHPM(" "), new UnityAction(this.EMGIDHDADBM), DFGILFBGPLN.popupBackendErrorStartPlayChapter, 1758f, -54);
			ApplicationFocusManager.Restore();
			return;
		}
	}

	// Token: 0x0600A247 RID: 41543 RVA: 0x004631B7 File Offset: 0x004613B7
	private void CJAFGKPFPAA()
	{
		if (AccountSignInManager.IKLAPGJDMNA == this)
		{
			AccountSignInManager.IKLAPGJDMNA = null;
		}
	}

	// Token: 0x0600A248 RID: 41544 RVA: 0x00465918 File Offset: 0x00463B18
	private void OnDisable()
	{
		if (AppManager.isQuitting)
		{
			return;
		}
		AOBJLALDBAA.EHBBFMCILPC.MANLHALMCIH("OnGooglePlayServicesLoginSuccess", new UnityAction(this.GLNIBIBMAOL));
		AOBJLALDBAA.EHBBFMCILPC.MANLHALMCIH("OnGooglePlayServicesLoginFailed", new UnityAction(this.JJPMBIHBPMK));
		AOBJLALDBAA.EHBBFMCILPC.MANLHALMCIH("OnFacebookLoginSuccess", new UnityAction(this.GLNIBIBMAOL));
		AOBJLALDBAA.EHBBFMCILPC.MANLHALMCIH("OnFacebookLoginFailed", new UnityAction(this.JJPMBIHBPMK));
		AOBJLALDBAA.EHBBFMCILPC.MANLHALMCIH("OnFacebookLoginCanceled", new UnityAction(this.PKEHEJFHGBD));
		AOBJLALDBAA.EHBBFMCILPC.MANLHALMCIH("OnAppleLoginSuccess", new UnityAction(this.GLNIBIBMAOL));
		AOBJLALDBAA.EHBBFMCILPC.MANLHALMCIH("OnAppleLoginFailed", new UnityAction(this.JJPMBIHBPMK));
		AOBJLALDBAA.EHBBFMCILPC.MANLHALMCIH("OnSteamLoginSuccess", new UnityAction(this.GLNIBIBMAOL));
		AOBJLALDBAA.EHBBFMCILPC.MANLHALMCIH("OnSteamLoginFailed", new UnityAction(this.JJPMBIHBPMK));
		AOBJLALDBAA.EHBBFMCILPC.MANLHALMCIH("OnUserpassLoginSuccess", new UnityAction(this.GLNIBIBMAOL));
		AOBJLALDBAA.EHBBFMCILPC.MANLHALMCIH("OnUserpassLoginFailed", new UnityAction(this.JJPMBIHBPMK));
		AOBJLALDBAA.EHBBFMCILPC.MANLHALMCIH("OnAccountSignInRequestSuccess", new UnityAction(this.LMOIOINJFPN));
		AOBJLALDBAA.EHBBFMCILPC.MANLHALMCIH("OnAccountSignInRequestException", new UnityAction(this.IGKHLOOIMAJ));
	}

	// Token: 0x0600A249 RID: 41545 RVA: 0x004631B7 File Offset: 0x004613B7
	private void GALHNFOLOAK()
	{
		if (AccountSignInManager.IKLAPGJDMNA == this)
		{
			AccountSignInManager.IKLAPGJDMNA = null;
		}
	}

	// Token: 0x0600A24A RID: 41546 RVA: 0x00465A8C File Offset: 0x00463C8C
	private void IKHFPDLEJPE()
	{
		AOBJLALDBAA.CEGAOMEEFBE().GNBGEMMDGOJ("", new UnityAction(this.GLNIBIBMAOL));
		AOBJLALDBAA.BIAEAOMHBMM().BADOPKAOCPE("app42error", new UnityAction(this.GDCJEIGGDPL));
		AOBJLALDBAA.FILDBDMENPG().FNMOFCMDFJP("", new UnityAction(this.PMFNDCJEIHF));
		AOBJLALDBAA.AGANFKKBPFO().FNMOFCMDFJP("mine", new UnityAction(this.CDJAJMNJDJC));
		AOBJLALDBAA.EHBBFMCILPC.PEFKJOKLEDL("OnStorySplashManagerAssetsDownloadFailed", new UnityAction(this.PMIIGFCIPNB));
		AOBJLALDBAA.NMGMNAKLLMI().GNBGEMMDGOJ("", new UnityAction(this.PMFNDCJEIHF));
		AOBJLALDBAA.BIAEAOMHBMM().FNMOFCMDFJP("<align=\"left\">\n\n<i>", new UnityAction(this.GDCJEIGGDPL));
		AOBJLALDBAA.DBLAIDPICIG().FNMOFCMDFJP("csnffb", new UnityAction(this.AJLNFEDJLHA));
		AOBJLALDBAA.DBLAIDPICIG().EFKNEJFLGED("lsvn", new UnityAction(this.PPABHIGDMFD));
		AOBJLALDBAA.KKPFOJMAONG().GNBGEMMDGOJ("XXX", new UnityAction(this.BEKGFLJPBAP));
		AOBJLALDBAA.KKPFOJMAONG().GNBGEMMDGOJ("", new UnityAction(this.LHAOOFAEFPD));
		AOBJLALDBAA.BIAEAOMHBMM().FNMOFCMDFJP(":", new UnityAction(this.JACFOOPHDND));
		AOBJLALDBAA.DBLAIDPICIG().MFIMALJPCDP("ok", new UnityAction(this.ODIMFLHEBGF));
	}

	// Token: 0x0600A24B RID: 41547 RVA: 0x000022C3 File Offset: 0x000004C3
	private void HGPPAPPFGLN()
	{
		AppManager.isQuitting = false;
	}

	// Token: 0x0600A24C RID: 41548 RVA: 0x00465BF8 File Offset: 0x00463DF8
	private void FMNPEODNAIG()
	{
		AOBJLALDBAA.EHBBFMCILPC.LPNCDPHNBJK(". ", 1847f);
	}

	// Token: 0x0600A24D RID: 41549 RVA: 0x00462740 File Offset: 0x00460940
	public JCAPGCCNOMP HMEMNAHIDIO()
	{
		return this.GDEIABKFOOA;
	}

	// Token: 0x0600A24E RID: 41550 RVA: 0x00465C10 File Offset: 0x00463E10
	public void EBIPCPGJDMB()
	{
		if (this.EEDHNEIMAPN != HHCKLPJJKIJ.device)
		{
			CommonUserInterface.EHBBFMCILPC.ShowConnectingAnimationWithHint(CCOJBMMKNAP.JMDJPKKOHNI().PKNHKGMNCIP("F0"), this.GCKCOMCBHMB);
		}
		this.FCFOKOGDFIG(this.EEDHNEIMAPN, this.GDEIABKFOOA, this.AOCIKAOPPDL, this.GCKCOMCBHMB);
	}

	// Token: 0x0600A24F RID: 41551 RVA: 0x00465C64 File Offset: 0x00463E64
	private void HADHMIPPGPA()
	{
		CommonUserInterface.EHBBFMCILPC.HideConnectingAnimation();
		NPJNALLPFPO lastOperationCode = BackendOperationsManager.EHBBFMCILPC.GetLastOperationCode();
		if (lastOperationCode - NPJNALLPFPO.redSemaphore <= 1)
		{
			if (this.GDEIABKFOOA == JCAPGCCNOMP.none)
			{
				CommonUserInterface.IKNOFBFMPGA().JJPNFAAPFBI(CCOJBMMKNAP.FEEDGKCJBLE().GLEFEKBDHNK(""), CCOJBMMKNAP.INKJIBDDMLL().PPALCPINPLK("Error. FadeDst(), layer "), CCOJBMMKNAP.LMCCLMFGEBD().HHLECNIFHCO(""), new UnityAction(this.OnSignInRetry), new UnityAction(this.ACBONKCAECN), (DFGILFBGPLN)120, 1736f, 118);
				ApplicationFocusManager.Restore();
				return;
			}
			CommonUserInterface.IKNOFBFMPGA().BGJFCEEDGFJ(CCOJBMMKNAP.PEBMGCKFNAO().DNILNCLIHAP("SubDepots(), cdnSubDepots:"), CCOJBMMKNAP.PEBMGCKFNAO().HIPJILDCHJC("talk"), CCOJBMMKNAP.CEGAOMEEFBE().BDGPNPNIAPA("hacomp1"), new UnityAction(this.MOENJALMPJO), (DFGILFBGPLN)(-17), 1350f, 9);
			ApplicationFocusManager.Restore();
			return;
		}
		else
		{
			if (this.GDEIABKFOOA == JCAPGCCNOMP.none)
			{
				CommonUserInterface.EHBBFMCILPC.ShowGenericPopupTwoOverride(CCOJBMMKNAP.OEPENBHJAHO().HDIPNMFHIEJ("Loaded asset bundle:"), CCOJBMMKNAP.KLAKLFCOMJC().MEPECBDCOLG("$"), CCOJBMMKNAP.EHBBFMCILPC.GLEFEKBDHNK("WideScreenScaler(): applied a "), new UnityAction(this.EBIPCPGJDMB), new UnityAction(this.LJIEDAGBAJD), (DFGILFBGPLN)(-115), 915f, 122);
				ApplicationFocusManager.Restore();
				return;
			}
			CommonUserInterface.EHBBFMCILPC.PEBIFCENHAL(CCOJBMMKNAP.DBFFFOMCLKM().JLBEIFLLBLO("colskt"), CCOJBMMKNAP.LMCCLMFGEBD().PGKBCNBAOJN("AvatarCollectionsItem.OnAvatarCollectionSelect(): index out of range"), CCOJBMMKNAP.HEDIEIICOOG().OBDCPLLLGBB("wind"), new UnityAction(this.ACBONKCAECN), DFGILFBGPLN.screenTransitionToLobby, 1025f, -46);
			ApplicationFocusManager.Restore();
			return;
		}
	}

	// Token: 0x0600A250 RID: 41552 RVA: 0x004631B7 File Offset: 0x004613B7
	private void OHPIOAOOMPD()
	{
		if (AccountSignInManager.IKLAPGJDMNA == this)
		{
			AccountSignInManager.IKLAPGJDMNA = null;
		}
	}

	// Token: 0x0600A251 RID: 41553 RVA: 0x00465E04 File Offset: 0x00464004
	public void FCFOKOGDFIG(HHCKLPJJKIJ OIOBCPFDLFE, JCAPGCCNOMP CCIAGBPILGF, HHCKLPJJKIJ ABMPLLPPDGK, byte FIGKJIAEMON = 0)
	{
		ApplicationFocusManager.BNMKAAKCLEA();
		this.GCKCOMCBHMB = FIGKJIAEMON;
		this.AOCIKAOPPDL = ABMPLLPPDGK;
		this.EEDHNEIMAPN = OIOBCPFDLFE;
		this.GDEIABKFOOA = CCIAGBPILGF;
		if (this.EEDHNEIMAPN != (HHCKLPJJKIJ)8)
		{
			CommonUserInterface.EHBBFMCILPC.ShowConnectingAnimationWithHint(CCOJBMMKNAP.PKEINLPIAEH().HPOAGPJFHPM(""), this.GCKCOMCBHMB);
		}
		if (this.EEDHNEIMAPN == HHCKLPJJKIJ.facebook)
		{
			if (FacebookManager.OOGPALHPNGM().IKKFBIJHNCL())
			{
				this.PMFNDCJEIHF();
				return;
			}
			FacebookManager.EHBBFMCILPC.LANNHHOBFEM();
			return;
		}
		else if (this.EEDHNEIMAPN == HHCKLPJJKIJ.steam)
		{
			if (GooglePlayServicesManager.FILDBDMENPG().LCOFGIAOKBD())
			{
				this.PDIEDPJEOKG();
				return;
			}
			GooglePlayServicesManager.ANCEKPONIFI().JCAMIJNEGKN(CCIAGBPILGF);
			return;
		}
		else if (this.EEDHNEIMAPN == HHCKLPJJKIJ.device)
		{
			if (AppleSignInManager.KIKOEJMHOEH().IsLoggedIn())
			{
				this.GLNIBIBMAOL();
				return;
			}
			AppleSignInManager.KIKOEJMHOEH().MHJCJDIALLI();
			return;
		}
		else if (this.EEDHNEIMAPN == HHCKLPJJKIJ.device)
		{
			if (SteamSignInManager.MHAAELKFFED().FALJKOOMCOJ())
			{
				this.BEKGFLJPBAP();
				return;
			}
			SteamSignInManager.GKFDDIABBIN().BJBDBMEGDOF();
			return;
		}
		else if (this.EEDHNEIMAPN == HHCKLPJJKIJ.none)
		{
			if (CCIAGBPILGF != JCAPGCCNOMP.none)
			{
				DPGJIJGOCIC.ANOPFDLPKGC("ok");
				this.EEDHNEIMAPN = HHCKLPJJKIJ.facebook;
				this.PMFNDCJEIHF();
				CommonUserInterface.IKNOFBFMPGA().ShowConnectingAnimationWithHint(CCOJBMMKNAP.PKEINLPIAEH().JCDFHKDNEDH("socialcollectedcardopenv2"), this.GCKCOMCBHMB);
				return;
			}
			if (UserpassSignInManager.OHCOHPNEOEG().IKKFBIJHNCL())
			{
				this.BEKGFLJPBAP();
				return;
			}
			UserpassSignInManager.OHCOHPNEOEG().LogIn();
			return;
		}
		else
		{
			if (this.EEDHNEIMAPN == HHCKLPJJKIJ.device)
			{
				this.PMFNDCJEIHF();
				return;
			}
			DPGJIJGOCIC.ANOPFDLPKGC("DDD");
			return;
		}
	}

	// Token: 0x0600A252 RID: 41554 RVA: 0x000693D6 File Offset: 0x000675D6
	private void ANPIDDAIALE()
	{
		UnityEngine.Object.DontDestroyOnLoad(base.gameObject);
	}

	// Token: 0x0600A253 RID: 41555 RVA: 0x00465F74 File Offset: 0x00464174
	private void JJPMBIHBPMK()
	{
		if (this.GDEIABKFOOA != JCAPGCCNOMP.auto)
		{
			CommonUserInterface.EHBBFMCILPC.HideConnectingAnimation();
			if (this.EEDHNEIMAPN == HHCKLPJJKIJ.token && AOBJLALDBAA.EHBBFMCILPC.MJLACDOKGNE() == 10)
			{
				CommonUserInterface.EHBBFMCILPC.ShowGenericPopupOneOverride(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("errortitle"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("signinuserpassbadinput"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("retry"), new UnityAction(this.OnSignInRetry), DFGILFBGPLN.popupSignInError, 0.3f, 28);
			}
			else
			{
				CommonUserInterface.EHBBFMCILPC.ShowGenericPopupOneOverride(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("errortitle"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("signinerror001"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("retry"), new UnityAction(this.OnSignInRetry), DFGILFBGPLN.popupSignInError, 0f, 28);
			}
			ApplicationFocusManager.Restore();
			return;
		}
		if (this.AOCIKAOPPDL != HHCKLPJJKIJ.none)
		{
			this.EEDHNEIMAPN = this.AOCIKAOPPDL;
			this.AOCIKAOPPDL = HHCKLPJJKIJ.none;
			this.OnSignInRetry();
			return;
		}
		CommonUserInterface.EHBBFMCILPC.HideConnectingAnimation();
		CommonUserInterface.EHBBFMCILPC.ShowGenericPopupTwoOverride(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("errortitle"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("signinerror001"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("retry"), new UnityAction(this.OnSignInRetry), new UnityAction(this.PIABINHPMMM), DFGILFBGPLN.popupSignInError, 0f, 28);
		ApplicationFocusManager.Restore();
	}

	// Token: 0x0600A254 RID: 41556 RVA: 0x004631B7 File Offset: 0x004613B7
	private void MOEINDNENBB()
	{
		if (AccountSignInManager.IKLAPGJDMNA == this)
		{
			AccountSignInManager.IKLAPGJDMNA = null;
		}
	}

	// Token: 0x0600A255 RID: 41557 RVA: 0x004660DC File Offset: 0x004642DC
	private void EKFFDPMDCPM()
	{
		CommonUserInterface.EHBBFMCILPC.HideConnectingAnimation();
		NPJNALLPFPO npjnallpfpo = BackendOperationsManager.NPDDBAONMJP().AINFDIJGNCN();
		if (npjnallpfpo - NPJNALLPFPO.redSemaphore == 0)
		{
			if (this.GDEIABKFOOA == JCAPGCCNOMP.none)
			{
				CommonUserInterface.EHBBFMCILPC.CEGLPJNLBHL(CCOJBMMKNAP.MPCBJEIMACA().OGKGHLHHAAI("CleanseHiddenTopMatchLists(): removed "), CCOJBMMKNAP.PLJMLDOCPNM().OHLNGCKIACD(", already present in top match list. But modifying the locked love interest condition to true."), CCOJBMMKNAP.LMCCLMFGEBD().JCDFHKDNEDH("storyChatPrefab is null!"), new UnityAction(this.EBIPCPGJDMB), new UnityAction(this.MOENJALMPJO), (DFGILFBGPLN)(-31), 857f, 15);
				ApplicationFocusManager.Restore();
				return;
			}
			CommonUserInterface.IKNOFBFMPGA().ShowGenericPopupOneOverride(CCOJBMMKNAP.NIOJNOFGIJO().HDIPNMFHIEJ("OnRequestSaveChapterSnapshotsDone"), CCOJBMMKNAP.ONCPHEEJLOP().MEPECBDCOLG("Character "), CCOJBMMKNAP.ILACPHFEDEP().OHLNGCKIACD("‘"), new UnityAction(this.CKKKHKJMNDF), DFGILFBGPLN.popupIncentAd2Success, 1730f, -70);
			ApplicationFocusManager.Restore();
			return;
		}
		else
		{
			if (this.GDEIABKFOOA == JCAPGCCNOMP.none)
			{
				CommonUserInterface.EHBBFMCILPC.ShowGenericPopupTwoOverride(CCOJBMMKNAP.HEDIEIICOOG().MEPECBDCOLG(" far card(s), unloading unused assets"), CCOJBMMKNAP.AEELGGPEJCC().BGELFMIOBCL("[LoadingEnv] "), CCOJBMMKNAP.EHBBFMCILPC.PKNHKGMNCIP(""), new UnityAction(this.EMGIDHDADBM), new UnityAction(this.EBIPCPGJDMB), DFGILFBGPLN.popupComingSoon, 1278f, -49);
				ApplicationFocusManager.Restore();
				return;
			}
			CommonUserInterface.IKNOFBFMPGA().ShowGenericPopupOneOverride(CCOJBMMKNAP.PEBMGCKFNAO().PGKBCNBAOJN(""), CCOJBMMKNAP.JMNIGPHCAEJ().BGELFMIOBCL("sfxitemreceived"), CCOJBMMKNAP.ONCPHEEJLOP().GGPHHLGPMPA("CharacterRenderTexturePool - player character prefab has no manager, falling back to direct rendering"), new UnityAction(this.OnSignInRetry), (DFGILFBGPLN)(-38), 710f, 27);
			ApplicationFocusManager.Restore();
			return;
		}
	}

	// Token: 0x0600A256 RID: 41558 RVA: 0x0046627C File Offset: 0x0046447C
	private void JLHMELBELCH()
	{
		AOBJLALDBAA.EHBBFMCILPC.GNBGEMMDGOJ("", new UnityAction(this.PMFNDCJEIHF));
		AOBJLALDBAA.AGANFKKBPFO().FNMOFCMDFJP("noiseanalogovr", new UnityAction(this.FCMCBKANOCD));
		AOBJLALDBAA.AGANFKKBPFO().BADOPKAOCPE("specialcurrencyblocktitle", new UnityAction(this.PDIEDPJEOKG));
		AOBJLALDBAA.NMGMNAKLLMI().EFKNEJFLGED("?uid=", new UnityAction(this.LHAOOFAEFPD));
		AOBJLALDBAA.NMGMNAKLLMI().FNMOFCMDFJP("OnBackendRequestSendMessageSuccess", new UnityAction(this.PKEHEJFHGBD));
		AOBJLALDBAA.AGANFKKBPFO().GNBGEMMDGOJ("noiseanalogovr_1", new UnityAction(this.PDIEDPJEOKG));
		AOBJLALDBAA.EHBBFMCILPC.FNMOFCMDFJP("ccpool", new UnityAction(this.FCMCBKANOCD));
		AOBJLALDBAA.KKPFOJMAONG().MFIMALJPCDP("SceneRestart", new UnityAction(this.AJLNFEDJLHA));
		AOBJLALDBAA.CEGAOMEEFBE().BADOPKAOCPE("snap", new UnityAction(this.NMPEONJMPDH));
		AOBJLALDBAA.KKPFOJMAONG().PEFKJOKLEDL("img", new UnityAction(this.GLNIBIBMAOL));
		AOBJLALDBAA.KKPFOJMAONG().FNMOFCMDFJP("", new UnityAction(this.NMPEONJMPDH));
		AOBJLALDBAA.CEGAOMEEFBE().PEFKJOKLEDL("retry", new UnityAction(this.AKDJAMPCINC));
		AOBJLALDBAA.KKPFOJMAONG().PEFKJOKLEDL("svol", new UnityAction(this.IKDKPFKACGI));
	}

	// Token: 0x0600A257 RID: 41559 RVA: 0x004663E8 File Offset: 0x004645E8
	private void KPNNMDECEEH()
	{
		if (AppManager.isQuitting)
		{
			return;
		}
		AOBJLALDBAA.CEGAOMEEFBE().PBELMJCPJMK("request for ", new UnityAction(this.GLNIBIBMAOL));
		AOBJLALDBAA.CEGAOMEEFBE().PFAHGKEDFAE("uid", new UnityAction(this.NMPEONJMPDH));
		AOBJLALDBAA.BIAEAOMHBMM().ECDBIBPNBCO("p", new UnityAction(this.BEKGFLJPBAP));
		AOBJLALDBAA.NMGMNAKLLMI().MHLNJIACIGO("doublerewardtut", new UnityAction(this.BAMHKOINDCE));
		AOBJLALDBAA.NMGMNAKLLMI().ONIBLJOFFPG("OnSketchThumbnailDuplicatePositive", new UnityAction(this.PKEHEJFHGBD));
		AOBJLALDBAA.EHBBFMCILPC.POLEDPIKODD("OnLoungeScreenAssetsDownloadSuccess", new UnityAction(this.GLNIBIBMAOL));
		AOBJLALDBAA.FILDBDMENPG().ECDBIBPNBCO("OnApplicationFocusNeedToUpdateCurrency", new UnityAction(this.PPABHIGDMFD));
		AOBJLALDBAA.CEGAOMEEFBE().MANLHALMCIH("CLIENT.POSTEFFECTS.VHSPAUSE", new UnityAction(this.PMFNDCJEIHF));
		AOBJLALDBAA.EHBBFMCILPC.ECDBIBPNBCO("-", new UnityAction(this.PPABHIGDMFD));
		AOBJLALDBAA.KKPFOJMAONG().PBELMJCPJMK("OnBackendUpgradeToGiftCardSuccess", new UnityAction(this.BEKGFLJPBAP));
		AOBJLALDBAA.AGANFKKBPFO().NAMMLDPCHJO("OnRequestCheckForUpdatesException", new UnityAction(this.GDCJEIGGDPL));
		AOBJLALDBAA.NMGMNAKLLMI().KDIFKFKMCOH("OnAllCollectableCardsDownloadFailedLobby", new UnityAction(this.KNFKLHPAPIL));
		AOBJLALDBAA.KKPFOJMAONG().PBELMJCPJMK("", new UnityAction(this.FMNNCEKBHDG));
	}

	// Token: 0x0600A258 RID: 41560 RVA: 0x000693D6 File Offset: 0x000675D6
	private void HILONIKFEIH()
	{
		UnityEngine.Object.DontDestroyOnLoad(base.gameObject);
	}

	// Token: 0x0600A259 RID: 41561 RVA: 0x004631B7 File Offset: 0x004613B7
	private void GMBGAPAGAHB()
	{
		if (AccountSignInManager.IKLAPGJDMNA == this)
		{
			AccountSignInManager.IKLAPGJDMNA = null;
		}
	}

	// Token: 0x0600A25A RID: 41562 RVA: 0x000693D6 File Offset: 0x000675D6
	private void FIGJOFLIKKI()
	{
		UnityEngine.Object.DontDestroyOnLoad(base.gameObject);
	}

	// Token: 0x0600A25B RID: 41563 RVA: 0x0046655C File Offset: 0x0046475C
	public static AccountSignInManager NIOJNOFGIJO()
	{
		if (!AccountSignInManager.IKLAPGJDMNA)
		{
			AccountSignInManager.IKLAPGJDMNA = (UnityEngine.Object.FindObjectOfType(typeof(AccountSignInManager)) as AccountSignInManager);
			if (!AccountSignInManager.IKLAPGJDMNA)
			{
				DPGJIJGOCIC.ANOPFDLPKGC("itemstitle");
			}
		}
		return AccountSignInManager.IKLAPGJDMNA;
	}

	// Token: 0x0600A25C RID: 41564 RVA: 0x004665AC File Offset: 0x004647AC
	public static AccountSignInManager AININGBPKNC()
	{
		if (!AccountSignInManager.IKLAPGJDMNA)
		{
			AccountSignInManager.IKLAPGJDMNA = (UnityEngine.Object.FindObjectOfType(typeof(AccountSignInManager)) as AccountSignInManager);
			if (!AccountSignInManager.IKLAPGJDMNA)
			{
				DPGJIJGOCIC.ANOPFDLPKGC("</b>");
			}
		}
		return AccountSignInManager.IKLAPGJDMNA;
	}

	// Token: 0x0600A25D RID: 41565 RVA: 0x004665FC File Offset: 0x004647FC
	private void OnEnable()
	{
		AOBJLALDBAA.EHBBFMCILPC.MFIMALJPCDP("OnGooglePlayServicesLoginSuccess", new UnityAction(this.GLNIBIBMAOL));
		AOBJLALDBAA.EHBBFMCILPC.MFIMALJPCDP("OnGooglePlayServicesLoginFailed", new UnityAction(this.JJPMBIHBPMK));
		AOBJLALDBAA.EHBBFMCILPC.MFIMALJPCDP("OnFacebookLoginSuccess", new UnityAction(this.GLNIBIBMAOL));
		AOBJLALDBAA.EHBBFMCILPC.MFIMALJPCDP("OnFacebookLoginFailed", new UnityAction(this.JJPMBIHBPMK));
		AOBJLALDBAA.EHBBFMCILPC.MFIMALJPCDP("OnFacebookLoginCanceled", new UnityAction(this.PKEHEJFHGBD));
		AOBJLALDBAA.EHBBFMCILPC.MFIMALJPCDP("OnAppleLoginSuccess", new UnityAction(this.GLNIBIBMAOL));
		AOBJLALDBAA.EHBBFMCILPC.MFIMALJPCDP("OnAppleLoginFailed", new UnityAction(this.JJPMBIHBPMK));
		AOBJLALDBAA.EHBBFMCILPC.MFIMALJPCDP("OnSteamLoginSuccess", new UnityAction(this.GLNIBIBMAOL));
		AOBJLALDBAA.EHBBFMCILPC.MFIMALJPCDP("OnSteamLoginFailed", new UnityAction(this.JJPMBIHBPMK));
		AOBJLALDBAA.EHBBFMCILPC.MFIMALJPCDP("OnUserpassLoginSuccess", new UnityAction(this.GLNIBIBMAOL));
		AOBJLALDBAA.EHBBFMCILPC.MFIMALJPCDP("OnUserpassLoginFailed", new UnityAction(this.JJPMBIHBPMK));
		AOBJLALDBAA.EHBBFMCILPC.MFIMALJPCDP("OnAccountSignInRequestSuccess", new UnityAction(this.LMOIOINJFPN));
		AOBJLALDBAA.EHBBFMCILPC.MFIMALJPCDP("OnAccountSignInRequestException", new UnityAction(this.IGKHLOOIMAJ));
	}

	// Token: 0x0600A25E RID: 41566 RVA: 0x00466768 File Offset: 0x00464968
	private void KGENGPOFIEL()
	{
		AOBJLALDBAA.DBLAIDPICIG().EFKNEJFLGED("", new UnityAction(this.GLNIBIBMAOL));
		AOBJLALDBAA.FILDBDMENPG().GNBGEMMDGOJ("OnStoryChoiceClick", new UnityAction(this.GDCJEIGGDPL));
		AOBJLALDBAA.NMGMNAKLLMI().BADOPKAOCPE("assetbundlesketchview", new UnityAction(this.PDIEDPJEOKG));
		AOBJLALDBAA.NMGMNAKLLMI().FNMOFCMDFJP("app42error", new UnityAction(this.PPABHIGDMFD));
		AOBJLALDBAA.BIAEAOMHBMM().EFKNEJFLGED("", new UnityAction(this.HHIHBCJFDON));
		AOBJLALDBAA.KKPFOJMAONG().BADOPKAOCPE("signInOrRegister", new UnityAction(this.GLNIBIBMAOL));
		AOBJLALDBAA.NMGMNAKLLMI().EFKNEJFLGED("PlayerCharacterManager.UpdateComponentLink() - invalid custom hierarchy for ", new UnityAction(this.CDJAJMNJDJC));
		AOBJLALDBAA.BIAEAOMHBMM().EFKNEJFLGED("analogglitch20ovr_2", new UnityAction(this.PMFNDCJEIHF));
		AOBJLALDBAA.EHBBFMCILPC.PEFKJOKLEDL("lck", new UnityAction(this.FCMCBKANOCD));
		AOBJLALDBAA.KKPFOJMAONG().MFIMALJPCDP("e1pl", new UnityAction(this.BEKGFLJPBAP));
		AOBJLALDBAA.AGANFKKBPFO().EFKNEJFLGED("", new UnityAction(this.CDJAJMNJDJC));
		AOBJLALDBAA.BIAEAOMHBMM().GNBGEMMDGOJ("AssetProfileData.RegisterProfilePack(): _profilePackAsset (", new UnityAction(this.AIIAMCLPDAC));
		AOBJLALDBAA.EHBBFMCILPC.GNBGEMMDGOJ("CharacterTransitionManager - acknowledge effect not loaded or invalid, skipping accent:", new UnityAction(this.IGKHLOOIMAJ));
	}

	// Token: 0x0600A25F RID: 41567 RVA: 0x004668D4 File Offset: 0x00464AD4
	private void IINFIMDMIPO()
	{
		CommonUserInterface.IKNOFBFMPGA().MCJIGJMFBMI();
		NPJNALLPFPO lastOperationCode = BackendOperationsManager.NPDDBAONMJP().GetLastOperationCode();
		if (lastOperationCode - NPJNALLPFPO.redSemaphore == 0)
		{
			if (this.GDEIABKFOOA == JCAPGCCNOMP.none)
			{
				CommonUserInterface.IKNOFBFMPGA().CEGLPJNLBHL(CCOJBMMKNAP.BIAEAOMHBMM().HIPJILDCHJC("OnStoryCurrencyInfoClick"), CCOJBMMKNAP.FEEDGKCJBLE().HPOAGPJFHPM("signinlinksteam"), CCOJBMMKNAP.GIOAFDDKKHI().MEPECBDCOLG("OnBackendValidateTransactionFailed"), new UnityAction(this.OnSignInRetry), new UnityAction(this.EMGIDHDADBM), (DFGILFBGPLN)(-10), 844f, -79);
				ApplicationFocusManager.Restore();
				return;
			}
			CommonUserInterface.IKNOFBFMPGA().BGJFCEEDGFJ(CCOJBMMKNAP.MLFAGAAJJEM().PGKBCNBAOJN("eposv"), CCOJBMMKNAP.AEELGGPEJCC().MEPECBDCOLG(" "), CCOJBMMKNAP.OEPENBHJAHO().JCDFHKDNEDH(""), new UnityAction(this.EBIPCPGJDMB), (DFGILFBGPLN)87, 1699f, -47);
			ApplicationFocusManager.Restore();
			return;
		}
		else
		{
			if (this.GDEIABKFOOA == JCAPGCCNOMP.auto)
			{
				CommonUserInterface.IKNOFBFMPGA().ShowGenericPopupTwoOverride(CCOJBMMKNAP.MLFAGAAJJEM().OBDCPLLLGBB(" "), CCOJBMMKNAP.BOFMCPPFAMO().DNILNCLIHAP("?"), CCOJBMMKNAP.NIOJNOFGIJO().OBDCPLLLGBB("OnLiveProfileThemeBackgroundCdnSuccess"), new UnityAction(this.ACBONKCAECN), new UnityAction(this.EBIPCPGJDMB), (DFGILFBGPLN)(-17), 923f, 35);
				ApplicationFocusManager.Restore();
				return;
			}
			CommonUserInterface.IKNOFBFMPGA().ShowGenericPopupOneOverride(CCOJBMMKNAP.KFAABHHGOPO().MEPECBDCOLG("%"), CCOJBMMKNAP.AEELGGPEJCC().PKNHKGMNCIP("loungenotavailable"), CCOJBMMKNAP.PKEINLPIAEH().FCOCLEHKLDJ(""), new UnityAction(this.OnSignInRetry), (DFGILFBGPLN)(-28), 227f, -65);
			ApplicationFocusManager.Restore();
			return;
		}
	}

	// Token: 0x0600A260 RID: 41568 RVA: 0x00466A74 File Offset: 0x00464C74
	private void AKDJAMPCINC()
	{
		CommonUserInterface.IKNOFBFMPGA().HideConnectingAnimation();
		AKLFPGMDKLA.EHBBFMCILPC.EEDHNEIMAPN = (int)this.EEDHNEIMAPN;
		if (this.GDEIABKFOOA == (JCAPGCCNOMP)5)
		{
			if (!AKLFPGMDKLA.EHBBFMCILPC.MAIKELGDHMI())
			{
				CommonUserInterface.IKNOFBFMPGA().JJPNFAAPFBI(CCOJBMMKNAP.PMABBOJDELF().OHLNGCKIACD("ratePopupResult"), CCOJBMMKNAP.BBGECIKOICE().MEPECBDCOLG(""), CCOJBMMKNAP.FEEDGKCJBLE().IPEIONBNIPH("OnRewardFreePassPlayStore"), new UnityAction(this.ABALICGDAIM), new UnityAction(this.PIABINHPMMM), (DFGILFBGPLN)(-119), 1268f, -115);
				ApplicationFocusManager.Restore();
			}
			else if (this.EEDHNEIMAPN == HHCKLPJJKIJ.none)
			{
				CommonUserInterface.EHBBFMCILPC.ShowGenericPopup(CCOJBMMKNAP.KFDLFGHBPLP().HIPJILDCHJC("s"), CCOJBMMKNAP.HEDIEIICOOG().PGKBCNBAOJN("OnPopupProfileLoveInputCancel"), CCOJBMMKNAP.NIOJNOFGIJO().DNILNCLIHAP("OnTryToFireNoteshowTimer"), (DFGILFBGPLN)(-113), 1466f, -35);
				ApplicationFocusManager.Restore();
			}
			else if (this.EEDHNEIMAPN == HHCKLPJJKIJ.google)
			{
				CommonUserInterface.EHBBFMCILPC.NFBMHHPIGFA(CCOJBMMKNAP.DLGLFACMHPG().BDGPNPNIAPA("p"), CCOJBMMKNAP.COKDLDOAACJ().HIPJILDCHJC("p"), CCOJBMMKNAP.APGODIBBPOD().IKMNGFIDCLM("ok"), (DFGILFBGPLN)92, 1238f, 26);
				ApplicationFocusManager.Restore();
			}
			else if (this.EEDHNEIMAPN == HHCKLPJJKIJ.steam)
			{
				CommonUserInterface.IKNOFBFMPGA().ShowGenericPopup(CCOJBMMKNAP.JINDKPHNLBK().PGKBCNBAOJN("app42error"), CCOJBMMKNAP.HFAKOKBHCGH().GGPHHLGPMPA(" playing!"), CCOJBMMKNAP.JMNIGPHCAEJ().MEPECBDCOLG("pmtsuccess"), (DFGILFBGPLN)(-40), 129f, 62);
				ApplicationFocusManager.Restore();
			}
			else if (this.EEDHNEIMAPN == (HHCKLPJJKIJ)7)
			{
				CommonUserInterface.EHBBFMCILPC.NFBMHHPIGFA(CCOJBMMKNAP.INKJIBDDMLL().JCDFHKDNEDH("skinshopfilterbystory"), CCOJBMMKNAP.KMNBCEMEBBD().PKNHKGMNCIP(""), CCOJBMMKNAP.PKEINLPIAEH().OHLNGCKIACD("layervideo"), DFGILFBGPLN.popupOutdatedRevision, 1008f, 107);
				ApplicationFocusManager.Restore();
			}
			else if (this.EEDHNEIMAPN == (HHCKLPJJKIJ)8)
			{
				CommonUserInterface.IKNOFBFMPGA().ShowGenericPopup(CCOJBMMKNAP.PKEINLPIAEH().HDIPNMFHIEJ("============== USING PRODUCTION DB SERVER ==============="), CCOJBMMKNAP.COKDLDOAACJ().FIENAKIHNOM("skinshopinfobonus"), CCOJBMMKNAP.MLFAGAAJJEM().OHLNGCKIACD("errortitle"), (DFGILFBGPLN)(-13), 309f, 122);
				ApplicationFocusManager.Restore();
			}
			else
			{
				DPGJIJGOCIC.ANOPFDLPKGC("acomp2");
			}
		}
		else if (this.GDEIABKFOOA == JCAPGCCNOMP.auto)
		{
			if (!AKLFPGMDKLA.EHBBFMCILPC.MAIKELGDHMI())
			{
				AKLFPGMDKLA.EHBBFMCILPC.CHCHBMMLACE();
				CommonUserInterface.EHBBFMCILPC.JJPNFAAPFBI(CCOJBMMKNAP.INKJIBDDMLL().MEPECBDCOLG("chaptersnapshotssubrequiredtitle"), CCOJBMMKNAP.BFHKGNBFHCH().OHLNGCKIACD("cid"), CCOJBMMKNAP.KNKGCDDMLDP().IKMNGFIDCLM(""), new UnityAction(this.MBFAHMPJKLI), new UnityAction(this.ALCHHKHOHJE), (DFGILFBGPLN)(-37), 72f, -48);
				ApplicationFocusManager.Restore();
			}
			else
			{
				FirebaseAnalyticsManager.COKDLDOAACJ().LKONPEEDKNF(false, AGEHCPDNBFD.cdnActiv.ToString(), ((FFPHBMFGCNN)(-76)).ToString(), BGHLMGPPCNN.d1Reward.ToString(), true, false);
				this.PIABINHPMMM();
				AKLFPGMDKLA.EHBBFMCILPC.MJPKIMHENNF = 1;
				AKLFPGMDKLA.EHBBFMCILPC.OOEJIIJLKPK = 1;
			}
		}
		else
		{
			DPGJIJGOCIC.ANOPFDLPKGC("getCardsBalance");
		}
		AKLFPGMDKLA.EHBBFMCILPC.LPCBDEBKAIM();
	}

	// Token: 0x0600A261 RID: 41569 RVA: 0x00466DBC File Offset: 0x00464FBC
	private void ALBKMBOKICH()
	{
		AOBJLALDBAA.AGANFKKBPFO().GNBGEMMDGOJ(".", new UnityAction(this.PMFNDCJEIHF));
		AOBJLALDBAA.FILDBDMENPG().MFIMALJPCDP("sfxtimeoutwarning", new UnityAction(this.CDJAJMNJDJC));
		AOBJLALDBAA.CEGAOMEEFBE().EFKNEJFLGED("(", new UnityAction(this.GLNIBIBMAOL));
		AOBJLALDBAA.KKPFOJMAONG().MFIMALJPCDP("mypnotif0", new UnityAction(this.JJPMBIHBPMK));
		AOBJLALDBAA.DBLAIDPICIG().EFKNEJFLGED("p", new UnityAction(this.PKEHEJFHGBD));
		AOBJLALDBAA.CEGAOMEEFBE().EFKNEJFLGED("fuzzy", new UnityAction(this.AJLNFEDJLHA));
		AOBJLALDBAA.NMGMNAKLLMI().PEFKJOKLEDL("cids", new UnityAction(this.FCMCBKANOCD));
		AOBJLALDBAA.AGANFKKBPFO().GNBGEMMDGOJ("yes", new UnityAction(this.PDIEDPJEOKG));
		AOBJLALDBAA.DBLAIDPICIG().GNBGEMMDGOJ("x", new UnityAction(this.LHAOOFAEFPD));
		AOBJLALDBAA.FILDBDMENPG().PEFKJOKLEDL("", new UnityAction(this.PDIEDPJEOKG));
		AOBJLALDBAA.FILDBDMENPG().FNMOFCMDFJP("", new UnityAction(this.BAMHKOINDCE));
		AOBJLALDBAA.KKPFOJMAONG().PEFKJOKLEDL("OnOnDemandResourcesDownloadFailed", new UnityAction(this.LMOIOINJFPN));
		AOBJLALDBAA.DBLAIDPICIG().PEFKJOKLEDL("Critical error, could not load asset bundle:", new UnityAction(this.KNPDJHHJFIB));
	}

	// Token: 0x0600A262 RID: 41570 RVA: 0x004631B7 File Offset: 0x004613B7
	private void OnDestroy()
	{
		if (AccountSignInManager.IKLAPGJDMNA == this)
		{
			AccountSignInManager.IKLAPGJDMNA = null;
		}
	}

	// Token: 0x0600A263 RID: 41571 RVA: 0x00466F28 File Offset: 0x00465128
	private void GLNIBIBMAOL()
	{
		BackendOperationsManager.EHBBFMCILPC.CleanCachedRequestsData();
		if (this.EEDHNEIMAPN == HHCKLPJJKIJ.facebook)
		{
			if (BackendOperationsManager.EHBBFMCILPC.IsAccountSignInDataValid(FacebookManager.EHBBFMCILPC.GetUserId(), this.EEDHNEIMAPN))
			{
				BackendOperationsManager.EHBBFMCILPC.RequestAccountSignIn(FacebookManager.EHBBFMCILPC.GetUserId(), this.EEDHNEIMAPN, "OnAccountSignInRequestSuccess", "OnAccountSignInRequestException");
				return;
			}
			this.IGKHLOOIMAJ();
			return;
		}
		else
		{
			if (this.EEDHNEIMAPN == HHCKLPJJKIJ.google)
			{
				BackendOperationsManager.EHBBFMCILPC.RequestAccountSignIn(GooglePlayServicesManager.EHBBFMCILPC.GetUserId(), this.EEDHNEIMAPN, "OnAccountSignInRequestSuccess", "OnAccountSignInRequestException");
				return;
			}
			if (this.EEDHNEIMAPN == HHCKLPJJKIJ.apple)
			{
				BackendOperationsManager.EHBBFMCILPC.RequestAccountSignIn(AppleSignInManager.EHBBFMCILPC.GetUserId(), this.EEDHNEIMAPN, "OnAccountSignInRequestSuccess", "OnAccountSignInRequestException");
				return;
			}
			if (this.EEDHNEIMAPN == HHCKLPJJKIJ.steam)
			{
				BackendOperationsManager.EHBBFMCILPC.RequestAccountSignIn(SteamSignInManager.EHBBFMCILPC.GetUserId(), this.EEDHNEIMAPN, "OnAccountSignInRequestSuccess", "OnAccountSignInRequestException");
				return;
			}
			if (this.EEDHNEIMAPN == HHCKLPJJKIJ.token)
			{
				CommonUserInterface.EHBBFMCILPC.ShowConnectingAnimationWithHint(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("hintsigning"), this.GCKCOMCBHMB);
				BackendOperationsManager.EHBBFMCILPC.RequestAccountSignIn(UserpassSignInManager.EHBBFMCILPC.GetUserId() + "$" + UserpassSignInManager.EHBBFMCILPC.GetPassword(), this.EEDHNEIMAPN, "OnAccountSignInRequestSuccess", "OnAccountSignInRequestException");
				return;
			}
			if (this.EEDHNEIMAPN == HHCKLPJJKIJ.device)
			{
				BackendOperationsManager.EHBBFMCILPC.RequestAccountSignIn(DPGJIJGOCIC.GIIHCODLGCA(), this.EEDHNEIMAPN, "OnAccountSignInRequestSuccess", "OnAccountSignInRequestException");
				return;
			}
			DPGJIJGOCIC.ANOPFDLPKGC("AccountSignInManager.OnAnyProviderLoginSuccess() - sign in source not implemented.");
			return;
		}
	}

	// Token: 0x0600A264 RID: 41572 RVA: 0x004670B0 File Offset: 0x004652B0
	public void BLAHDOIPOJG()
	{
		if (this.EEDHNEIMAPN != HHCKLPJJKIJ.device)
		{
			CommonUserInterface.IKNOFBFMPGA().KLEJAGLPCNM(CCOJBMMKNAP.MLFAGAAJJEM().JHNELLJFBGC("Shaders/VideoGlitchNoiseAnalog"), this.GCKCOMCBHMB);
		}
		this.HGCFKELLBIH(this.EEDHNEIMAPN, this.GDEIABKFOOA, this.AOCIKAOPPDL, this.GCKCOMCBHMB);
	}

	// Token: 0x0600A265 RID: 41573 RVA: 0x000693D6 File Offset: 0x000675D6
	private void BOPFAKHJPKD()
	{
		UnityEngine.Object.DontDestroyOnLoad(base.gameObject);
	}

	// Token: 0x0600A266 RID: 41574 RVA: 0x00467104 File Offset: 0x00465304
	public void LJIEDAGBAJD()
	{
		if (this.EEDHNEIMAPN != HHCKLPJJKIJ.apple)
		{
			CommonUserInterface.IKNOFBFMPGA().ShowConnectingAnimationWithHint(CCOJBMMKNAP.EAIAHCBAIEJ().PGKBCNBAOJN("skinshopinfosumimmediate"), this.GCKCOMCBHMB);
		}
		this.HGCFKELLBIH(this.EEDHNEIMAPN, this.GDEIABKFOOA, this.AOCIKAOPPDL, this.GCKCOMCBHMB);
	}

	// Token: 0x0600A267 RID: 41575 RVA: 0x00467158 File Offset: 0x00465358
	public static AccountSignInManager APGJJNHOEOB()
	{
		if (!AccountSignInManager.IKLAPGJDMNA)
		{
			AccountSignInManager.IKLAPGJDMNA = (UnityEngine.Object.FindObjectOfType(typeof(AccountSignInManager)) as AccountSignInManager);
			if (!AccountSignInManager.IKLAPGJDMNA)
			{
				DPGJIJGOCIC.ANOPFDLPKGC("comingsoontitle");
			}
		}
		return AccountSignInManager.IKLAPGJDMNA;
	}

	// Token: 0x0600A268 RID: 41576 RVA: 0x004671A8 File Offset: 0x004653A8
	private void EPECDBPOOLB()
	{
		if (AppManager.isQuitting)
		{
			return;
		}
		AOBJLALDBAA.CEGAOMEEFBE().KDIFKFKMCOH("", new UnityAction(this.GLNIBIBMAOL));
		AOBJLALDBAA.BIAEAOMHBMM().ONIBLJOFFPG("XXX", new UnityAction(this.GDCJEIGGDPL));
		AOBJLALDBAA.NMGMNAKLLMI().PBELMJCPJMK("app42error", new UnityAction(this.BEKGFLJPBAP));
		AOBJLALDBAA.CEGAOMEEFBE().MHLNJIACIGO("-", new UnityAction(this.FCMCBKANOCD));
		AOBJLALDBAA.BIAEAOMHBMM().ECDBIBPNBCO("PurchaseManagerUnity.Initialize(): Unity Gaming Services not initialized.", new UnityAction(this.PKEHEJFHGBD));
		AOBJLALDBAA.CEGAOMEEFBE().ONIBLJOFFPG("ach", new UnityAction(this.BEKGFLJPBAP));
		AOBJLALDBAA.KKPFOJMAONG().NAMMLDPCHJO("saveslotsoptiondelete", new UnityAction(this.JJPMBIHBPMK));
		AOBJLALDBAA.KKPFOJMAONG().MHLNJIACIGO("rateChapter", new UnityAction(this.PDIEDPJEOKG));
		AOBJLALDBAA.BIAEAOMHBMM().ONIBLJOFFPG("", new UnityAction(this.NMPEONJMPDH));
		AOBJLALDBAA.KKPFOJMAONG().POLEDPIKODD("$", new UnityAction(this.PMFNDCJEIHF));
		AOBJLALDBAA.DBLAIDPICIG().MANLHALMCIH("OnStorySplashManagerAssetsDownloadFailed", new UnityAction(this.LHAOOFAEFPD));
		AOBJLALDBAA.BIAEAOMHBMM().MHLNJIACIGO("anthology", new UnityAction(this.AKDJAMPCINC));
		AOBJLALDBAA.AGANFKKBPFO().POLEDPIKODD("", new UnityAction(this.EPEFMEFBPGK));
	}

	// Token: 0x0600A269 RID: 41577 RVA: 0x0046731C File Offset: 0x0046551C
	private void GDCJEIGGDPL()
	{
		if (this.GDEIABKFOOA != JCAPGCCNOMP.none)
		{
			CommonUserInterface.EHBBFMCILPC.MCJIGJMFBMI();
			if (this.EEDHNEIMAPN == HHCKLPJJKIJ.apple && AOBJLALDBAA.AGANFKKBPFO().AMBDJLPPOJL() == 98)
			{
				CommonUserInterface.EHBBFMCILPC.ShowGenericPopupOneOverride(CCOJBMMKNAP.FEEDGKCJBLE().BDGPNPNIAPA("<align=\"left\">\n\n<i>"), CCOJBMMKNAP.BFHKGNBFHCH().DNILNCLIHAP("hist"), CCOJBMMKNAP.COKDLDOAACJ().GGPHHLGPMPA("restartepisode"), new UnityAction(this.MOENJALMPJO), DFGILFBGPLN.popupCdnUpdateAvailable, 1342f, -33);
			}
			else
			{
				CommonUserInterface.IKNOFBFMPGA().ShowGenericPopupOneOverride(CCOJBMMKNAP.KMNBCEMEBBD().BGELFMIOBCL("sslt"), CCOJBMMKNAP.HJGDLOOHNLO().HIPJILDCHJC("LoadingEnvironmentManager"), CCOJBMMKNAP.INKJIBDDMLL().PGKBCNBAOJN("comingsoontitle3"), new UnityAction(this.MOENJALMPJO), DFGILFBGPLN.popupNotEnoughEnergy, 789f, -79);
			}
			ApplicationFocusManager.Restore();
			return;
		}
		if (this.AOCIKAOPPDL != HHCKLPJJKIJ.none)
		{
			this.EEDHNEIMAPN = this.AOCIKAOPPDL;
			this.AOCIKAOPPDL = HHCKLPJJKIJ.none;
			this.OnSignInRetry();
			return;
		}
		CommonUserInterface.IKNOFBFMPGA().HideConnectingAnimation();
		CommonUserInterface.IKNOFBFMPGA().CEGLPJNLBHL(CCOJBMMKNAP.DLGLFACMHPG().JLBEIFLLBLO("p"), CCOJBMMKNAP.ONCPHEEJLOP().MEPECBDCOLG("ans"), CCOJBMMKNAP.COKDLDOAACJ().OBDCPLLLGBB("ok"), new UnityAction(this.EMGIDHDADBM), new UnityAction(this.ABALICGDAIM), DFGILFBGPLN.none, 406f, -111);
		ApplicationFocusManager.Restore();
	}

	// Token: 0x0600A26A RID: 41578 RVA: 0x00467482 File Offset: 0x00465682
	private void PIABINHPMMM()
	{
		AOBJLALDBAA.EHBBFMCILPC.EGELHPJBAIC("OnAccountSignInSuccess", 1f);
	}

	// Token: 0x0600A26B RID: 41579 RVA: 0x00467498 File Offset: 0x00465698
	private void ODIMFLHEBGF()
	{
		CommonUserInterface.IKNOFBFMPGA().MCJIGJMFBMI();
		NPJNALLPFPO npjnallpfpo = BackendOperationsManager.EHBBFMCILPC.AINFDIJGNCN();
		if (npjnallpfpo - NPJNALLPFPO.success <= 7)
		{
			if (this.GDEIABKFOOA == JCAPGCCNOMP.none)
			{
				CommonUserInterface.EHBBFMCILPC.JJPNFAAPFBI(CCOJBMMKNAP.AEELGGPEJCC().BGELFMIOBCL(""), CCOJBMMKNAP.EAIAHCBAIEJ().BGELFMIOBCL(""), CCOJBMMKNAP.BOFMCPPFAMO().JHNELLJFBGC(""), new UnityAction(this.MOENJALMPJO), new UnityAction(this.LJIEDAGBAJD), (DFGILFBGPLN)(-120), 1042f, 3);
				ApplicationFocusManager.Restore();
				return;
			}
			CommonUserInterface.EHBBFMCILPC.PEBIFCENHAL(CCOJBMMKNAP.AEELGGPEJCC().GLEFEKBDHNK("PurchaseManagerSteam.InitializeUnityStoreController(): Connecting to store...."), CCOJBMMKNAP.OEPENBHJAHO().IKMNGFIDCLM("adserrorbody"), CCOJBMMKNAP.NIOJNOFGIJO().PGKBCNBAOJN("{character}"), new UnityAction(this.CKKKHKJMNDF), DFGILFBGPLN.popupTools, 1165f, -103);
			ApplicationFocusManager.Restore();
			return;
		}
		else
		{
			if (this.GDEIABKFOOA == JCAPGCCNOMP.auto)
			{
				CommonUserInterface.EHBBFMCILPC.CEGLPJNLBHL(CCOJBMMKNAP.BOFMCPPFAMO().BGELFMIOBCL("errortitle"), CCOJBMMKNAP.BFHKGNBFHCH().JHNELLJFBGC("response object is null"), CCOJBMMKNAP.EHBBFMCILPC.IPEIONBNIPH("yes"), new UnityAction(this.ACBONKCAECN), new UnityAction(this.EBIPCPGJDMB), DFGILFBGPLN.popupSettings, 360f, 90);
				ApplicationFocusManager.Restore();
				return;
			}
			CommonUserInterface.IKNOFBFMPGA().PEBIFCENHAL(CCOJBMMKNAP.KFDLFGHBPLP().PGKBCNBAOJN("title"), CCOJBMMKNAP.KLAKLFCOMJC().JCDFHKDNEDH("p"), CCOJBMMKNAP.ONCPHEEJLOP().HDIPNMFHIEJ(""), new UnityAction(this.LJIEDAGBAJD), DFGILFBGPLN.screenTransition, 1371f, -74);
			ApplicationFocusManager.Restore();
			return;
		}
	}

	// Token: 0x0600A26C RID: 41580 RVA: 0x00467638 File Offset: 0x00465838
	private void LHAOOFAEFPD()
	{
		if (this.GDEIABKFOOA != JCAPGCCNOMP.none)
		{
			CommonUserInterface.IKNOFBFMPGA().MCJIGJMFBMI();
			if (this.EEDHNEIMAPN == HHCKLPJJKIJ.google && AOBJLALDBAA.FILDBDMENPG().MJLACDOKGNE() == -19)
			{
				CommonUserInterface.EHBBFMCILPC.BGJFCEEDGFJ(CCOJBMMKNAP.PLJMLDOCPNM().IKMNGFIDCLM(", "), CCOJBMMKNAP.MPCBJEIMACA().PGKBCNBAOJN("AppsFlyerManagerSteam.Initialize() - Can not initialize, Steam client is not running."), CCOJBMMKNAP.PEBMGCKFNAO().JHNELLJFBGC("OnCutsceneViewAssetBundleFolderInitializeSuccess"), new UnityAction(this.OnSignInRetry), (DFGILFBGPLN)(-53), 6f, -4);
			}
			else
			{
				CommonUserInterface.IKNOFBFMPGA().ShowGenericPopupOneOverride(CCOJBMMKNAP.INKJIBDDMLL().PKNHKGMNCIP("[LoadingTheme] theme removed against the player's will, changes unlimited - no compensation"), CCOJBMMKNAP.EHBBFMCILPC.HPOAGPJFHPM("consumePromoCode"), CCOJBMMKNAP.JMDJPKKOHNI().FCOCLEHKLDJ("id"), new UnityAction(this.CKKKHKJMNDF), (DFGILFBGPLN)(-110), 1562f, -99);
			}
			ApplicationFocusManager.Restore();
			return;
		}
		if (this.AOCIKAOPPDL != HHCKLPJJKIJ.none)
		{
			this.EEDHNEIMAPN = this.AOCIKAOPPDL;
			this.AOCIKAOPPDL = HHCKLPJJKIJ.facebook;
			this.ACBONKCAECN();
			return;
		}
		CommonUserInterface.EHBBFMCILPC.HideConnectingAnimation();
		CommonUserInterface.EHBBFMCILPC.JJPNFAAPFBI(CCOJBMMKNAP.KFAABHHGOPO().HPOAGPJFHPM("Rate Option picked"), CCOJBMMKNAP.CPCOODCFDDP().FCOCLEHKLDJ("CameraBundlesVFXTopMost"), CCOJBMMKNAP.CPCOODCFDDP().FCOCLEHKLDJ("-"), new UnityAction(this.CKKKHKJMNDF), new UnityAction(this.FMNPEODNAIG), (DFGILFBGPLN)(-26), 1102f, 61);
		ApplicationFocusManager.Restore();
	}

	// Token: 0x0600A26D RID: 41581 RVA: 0x004677A0 File Offset: 0x004659A0
	private void OFKNGIOLILC()
	{
		CommonUserInterface.IKNOFBFMPGA().MCJIGJMFBMI();
		NPJNALLPFPO lastOperationCode = BackendOperationsManager.EHBBFMCILPC.GetLastOperationCode();
		if (lastOperationCode - NPJNALLPFPO.success <= 7)
		{
			if (this.GDEIABKFOOA == JCAPGCCNOMP.none)
			{
				CommonUserInterface.IKNOFBFMPGA().JJPNFAAPFBI(CCOJBMMKNAP.PMABBOJDELF().OBDCPLLLGBB("mfs"), CCOJBMMKNAP.CPCOODCFDDP().PPALCPINPLK("CLIENT.SCREEN.AVATAR."), CCOJBMMKNAP.MPCBJEIMACA().PPALCPINPLK(""), new UnityAction(this.EBIPCPGJDMB), new UnityAction(this.MOENJALMPJO), DFGILFBGPLN.popupSettings, 430f, 124);
				ApplicationFocusManager.Restore();
				return;
			}
			CommonUserInterface.IKNOFBFMPGA().PEBIFCENHAL(CCOJBMMKNAP.EHBBFMCILPC.JCDFHKDNEDH("lsenvattempt"), CCOJBMMKNAP.KFAABHHGOPO().PKNHKGMNCIP("achievementsSync"), CCOJBMMKNAP.LMCCLMFGEBD().PKNHKGMNCIP(""), new UnityAction(this.BLAHDOIPOJG), DFGILFBGPLN.popupSignInSuccess, 603f, -33);
			ApplicationFocusManager.Restore();
			return;
		}
		else
		{
			if (this.GDEIABKFOOA == JCAPGCCNOMP.none)
			{
				CommonUserInterface.IKNOFBFMPGA().JJPNFAAPFBI(CCOJBMMKNAP.PLJMLDOCPNM().FIENAKIHNOM("serversync"), CCOJBMMKNAP.HEDIEIICOOG().BDGPNPNIAPA("pass"), CCOJBMMKNAP.HFAKOKBHCGH().IPEIONBNIPH(" ("), new UnityAction(this.EMGIDHDADBM), new UnityAction(this.EBIPCPGJDMB), (DFGILFBGPLN)80, 1225f, -38);
				ApplicationFocusManager.Restore();
				return;
			}
			CommonUserInterface.EHBBFMCILPC.BGJFCEEDGFJ(CCOJBMMKNAP.COKDLDOAACJ().PGKBCNBAOJN("assetBundleLoadOperationActiveCoroutines:"), CCOJBMMKNAP.KFDLFGHBPLP().PGKBCNBAOJN("%"), CCOJBMMKNAP.NIOJNOFGIJO().MEPECBDCOLG(""), new UnityAction(this.EMGIDHDADBM), (DFGILFBGPLN)(-25), 830f, 25);
			ApplicationFocusManager.Restore();
			return;
		}
	}

	// Token: 0x0600A26E RID: 41582 RVA: 0x000693D6 File Offset: 0x000675D6
	private void FNDDKLJKFEK()
	{
		UnityEngine.Object.DontDestroyOnLoad(base.gameObject);
	}

	// Token: 0x0600A26F RID: 41583 RVA: 0x00462740 File Offset: 0x00460940
	public JCAPGCCNOMP OEMOMIAPIBP()
	{
		return this.GDEIABKFOOA;
	}

	// Token: 0x0600A270 RID: 41584 RVA: 0x004631B7 File Offset: 0x004613B7
	private void OHNEKLLPBDN()
	{
		if (AccountSignInManager.IKLAPGJDMNA == this)
		{
			AccountSignInManager.IKLAPGJDMNA = null;
		}
	}

	// Token: 0x0600A271 RID: 41585 RVA: 0x00467940 File Offset: 0x00465B40
	private void IKDKPFKACGI()
	{
		CommonUserInterface.EHBBFMCILPC.HideConnectingAnimation();
		NPJNALLPFPO npjnallpfpo = BackendOperationsManager.EHBBFMCILPC.AINFDIJGNCN();
		if (npjnallpfpo - NPJNALLPFPO.success <= 8)
		{
			if (this.GDEIABKFOOA == JCAPGCCNOMP.none)
			{
				CommonUserInterface.IKNOFBFMPGA().CEGLPJNLBHL(CCOJBMMKNAP.KFDLFGHBPLP().FCOCLEHKLDJ("\n\n"), CCOJBMMKNAP.HFAKOKBHCGH().DNILNCLIHAP(", searching as en"), CCOJBMMKNAP.ONCPHEEJLOP().IKMNGFIDCLM("hintprocessing"), new UnityAction(this.EMGIDHDADBM), new UnityAction(this.BLAHDOIPOJG), (DFGILFBGPLN)(-42), 299f, -20);
				ApplicationFocusManager.Restore();
				return;
			}
			CommonUserInterface.IKNOFBFMPGA().BGJFCEEDGFJ(CCOJBMMKNAP.FEEDGKCJBLE().HDIPNMFHIEJ(", container dropped"), CCOJBMMKNAP.HJGDLOOHNLO().JHNELLJFBGC(""), CCOJBMMKNAP.INKJIBDDMLL().JLBEIFLLBLO("null"), new UnityAction(this.CKKKHKJMNDF), DFGILFBGPLN.popupOffer, 368f, 10);
			ApplicationFocusManager.Restore();
			return;
		}
		else
		{
			if (this.GDEIABKFOOA == JCAPGCCNOMP.none)
			{
				CommonUserInterface.EHBBFMCILPC.ShowGenericPopupTwoOverride(CCOJBMMKNAP.ONCPHEEJLOP().DNILNCLIHAP("$"), CCOJBMMKNAP.KLAKLFCOMJC().IKMNGFIDCLM("lgbtq"), CCOJBMMKNAP.BBGECIKOICE().BDGPNPNIAPA("bv"), new UnityAction(this.EMGIDHDADBM), new UnityAction(this.MOENJALMPJO), DFGILFBGPLN.popupStoryRestart, 1461f, 59);
				ApplicationFocusManager.Restore();
				return;
			}
			CommonUserInterface.EHBBFMCILPC.BGJFCEEDGFJ(CCOJBMMKNAP.MPCBJEIMACA().HDIPNMFHIEJ("socialmessagesending"), CCOJBMMKNAP.HEDIEIICOOG().PGKBCNBAOJN("OnStoryChoiceClick"), CCOJBMMKNAP.APGODIBBPOD().JCDFHKDNEDH("OnRewardFirstEpisodeClick"), new UnityAction(this.EBIPCPGJDMB), (DFGILFBGPLN)105, 1886f, 91);
			ApplicationFocusManager.Restore();
			return;
		}
	}

	// Token: 0x0600A272 RID: 41586 RVA: 0x00467AE0 File Offset: 0x00465CE0
	private void IGKHLOOIMAJ()
	{
		CommonUserInterface.EHBBFMCILPC.HideConnectingAnimation();
		NPJNALLPFPO lastOperationCode = BackendOperationsManager.EHBBFMCILPC.GetLastOperationCode();
		if (lastOperationCode - NPJNALLPFPO.redSemaphore <= 2)
		{
			if (this.GDEIABKFOOA == JCAPGCCNOMP.auto)
			{
				CommonUserInterface.EHBBFMCILPC.ShowGenericPopupTwoOverride(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("errortitle"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("app42error"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("retry"), new UnityAction(this.OnSignInRetry), new UnityAction(this.OnSignInRetry), DFGILFBGPLN.popupBackendErrorSignIn, 0f, 28);
				ApplicationFocusManager.Restore();
				return;
			}
			CommonUserInterface.EHBBFMCILPC.ShowGenericPopupOneOverride(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("errortitle"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("app42error"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("retry"), new UnityAction(this.OnSignInRetry), DFGILFBGPLN.popupBackendErrorSignIn, 0f, 28);
			ApplicationFocusManager.Restore();
			return;
		}
		else
		{
			if (this.GDEIABKFOOA == JCAPGCCNOMP.auto)
			{
				CommonUserInterface.EHBBFMCILPC.ShowGenericPopupTwoOverride(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("errortitle"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("unknownerror"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("retry"), new UnityAction(this.OnSignInRetry), new UnityAction(this.OnSignInRetry), DFGILFBGPLN.popupSignInError, 0f, 28);
				ApplicationFocusManager.Restore();
				return;
			}
			CommonUserInterface.EHBBFMCILPC.ShowGenericPopupOneOverride(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("errortitle"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("unknownerror"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("retry"), new UnityAction(this.OnSignInRetry), DFGILFBGPLN.popupSignInError, 0f, 28);
			ApplicationFocusManager.Restore();
			return;
		}
	}

	// Token: 0x0600A273 RID: 41587 RVA: 0x00467C80 File Offset: 0x00465E80
	private void KNFKLHPAPIL()
	{
		CommonUserInterface.IKNOFBFMPGA().MCJIGJMFBMI();
		AKLFPGMDKLA.EHBBFMCILPC.EEDHNEIMAPN = (int)this.EEDHNEIMAPN;
		if (this.GDEIABKFOOA == JCAPGCCNOMP.none)
		{
			if (!AKLFPGMDKLA.EHBBFMCILPC.MAIKELGDHMI())
			{
				CommonUserInterface.IKNOFBFMPGA().JJPNFAAPFBI(CCOJBMMKNAP.JMNIGPHCAEJ().JCDFHKDNEDH(" (- )</i>"), CCOJBMMKNAP.PKEINLPIAEH().BGELFMIOBCL("age"), CCOJBMMKNAP.KMNBCEMEBBD().HIPJILDCHJC("OnLobbyProfileDataCdnFailed"), new UnityAction(this.ABALICGDAIM), new UnityAction(this.ALCHHKHOHJE), (DFGILFBGPLN)(-84), 510f, -110);
				ApplicationFocusManager.Restore();
			}
			else if (this.EEDHNEIMAPN == HHCKLPJJKIJ.none)
			{
				CommonUserInterface.IKNOFBFMPGA().ShowGenericPopup(CCOJBMMKNAP.HEDIEIICOOG().MEPECBDCOLG("areyousure"), CCOJBMMKNAP.ILACPHFEDEP().FCOCLEHKLDJ("sfxvol"), CCOJBMMKNAP.DBFFFOMCLKM().PGKBCNBAOJN("ZZZ"), (DFGILFBGPLN)(-103), 1613f, -106);
				ApplicationFocusManager.Restore();
			}
			else if (this.EEDHNEIMAPN == HHCKLPJJKIJ.token)
			{
				CommonUserInterface.EHBBFMCILPC.NFBMHHPIGFA(CCOJBMMKNAP.DBFFFOMCLKM().JCDFHKDNEDH(""), CCOJBMMKNAP.NIOJNOFGIJO().GLEFEKBDHNK(""), CCOJBMMKNAP.PLJMLDOCPNM().JLBEIFLLBLO("cind"), (DFGILFBGPLN)(-36), 211f, 25);
				ApplicationFocusManager.Restore();
			}
			else if (this.EEDHNEIMAPN == (HHCKLPJJKIJ)8)
			{
				CommonUserInterface.EHBBFMCILPC.NFBMHHPIGFA(CCOJBMMKNAP.BIAEAOMHBMM().BGELFMIOBCL("OnPopupRemoveAdsManagerContinueToPurchasingScreen"), CCOJBMMKNAP.KNKGCDDMLDP().IKMNGFIDCLM("$"), CCOJBMMKNAP.AEELGGPEJCC().JHNELLJFBGC("OnBackendGetPublicProfileHallOfFameMoreException"), (DFGILFBGPLN)(-11), 342f, -103);
				ApplicationFocusManager.Restore();
			}
			else if (this.EEDHNEIMAPN == HHCKLPJJKIJ.token)
			{
				CommonUserInterface.IKNOFBFMPGA().ShowGenericPopup(CCOJBMMKNAP.LMCCLMFGEBD().JLBEIFLLBLO("PurchaseManagerXiaomi.OnBridgeInitialized(): connected to Xiaomi GetApps IAP service."), CCOJBMMKNAP.NIOJNOFGIJO().BGELFMIOBCL(""), CCOJBMMKNAP.JINDKPHNLBK().FCOCLEHKLDJ(""), (DFGILFBGPLN)(-34), 350f, 3);
				ApplicationFocusManager.Restore();
			}
			else if (this.EEDHNEIMAPN == HHCKLPJJKIJ.google)
			{
				CommonUserInterface.EHBBFMCILPC.ShowGenericPopup(CCOJBMMKNAP.CPCOODCFDDP().MEPECBDCOLG(""), CCOJBMMKNAP.JMNIGPHCAEJ().OHLNGCKIACD(""), CCOJBMMKNAP.MLFAGAAJJEM().JCDFHKDNEDH(") is outside range"), (DFGILFBGPLN)(-113), 815f, -80);
				ApplicationFocusManager.Restore();
			}
			else
			{
				DPGJIJGOCIC.ANOPFDLPKGC("SkinShopItem");
			}
		}
		else if (this.GDEIABKFOOA == JCAPGCCNOMP.auto)
		{
			if (!AKLFPGMDKLA.EHBBFMCILPC.INEKFCLBCAB())
			{
				AKLFPGMDKLA.EHBBFMCILPC.CHCHBMMLACE();
				CommonUserInterface.IKNOFBFMPGA().ShowGenericPopupTwoOverride(CCOJBMMKNAP.PKEINLPIAEH().BGELFMIOBCL("OnLiveProfileThemeDownloadFailed"), CCOJBMMKNAP.BFHKGNBFHCH().HPOAGPJFHPM("serversync"), CCOJBMMKNAP.CEGAOMEEFBE().FCOCLEHKLDJ("blur"), new UnityAction(this.ALCHHKHOHJE), new UnityAction(this.ABALICGDAIM), (DFGILFBGPLN)(-29), 608f, -103);
				ApplicationFocusManager.Restore();
			}
			else
			{
				FirebaseAnalyticsManager.DEALKJPEMMH().JIAAMJPKOCE(true, AGEHCPDNBFD.gmSelect.ToString(), ((FFPHBMFGCNN)(-9)).ToString(), ((BGHLMGPPCNN)(-98)).ToString(), false, true);
				this.FMNPEODNAIG();
				AKLFPGMDKLA.EHBBFMCILPC.MJPKIMHENNF = 0;
				AKLFPGMDKLA.EHBBFMCILPC.OOEJIIJLKPK = 1;
			}
		}
		else
		{
			DPGJIJGOCIC.ANOPFDLPKGC("mps");
		}
		AKLFPGMDKLA.EHBBFMCILPC.LPCBDEBKAIM();
	}

	// Token: 0x0600A274 RID: 41588 RVA: 0x000693D6 File Offset: 0x000675D6
	private void AMNBHDNALGO()
	{
		UnityEngine.Object.DontDestroyOnLoad(base.gameObject);
	}

	// Token: 0x0600A275 RID: 41589 RVA: 0x00467FC8 File Offset: 0x004661C8
	public void KINKAIPKIAM(HHCKLPJJKIJ OIOBCPFDLFE, JCAPGCCNOMP CCIAGBPILGF, HHCKLPJJKIJ ABMPLLPPDGK, byte FIGKJIAEMON = 0)
	{
		ApplicationFocusManager.BNMKAAKCLEA();
		this.GCKCOMCBHMB = FIGKJIAEMON;
		this.AOCIKAOPPDL = ABMPLLPPDGK;
		this.EEDHNEIMAPN = OIOBCPFDLFE;
		this.GDEIABKFOOA = CCIAGBPILGF;
		if (this.EEDHNEIMAPN != HHCKLPJJKIJ.facebook)
		{
			CommonUserInterface.IKNOFBFMPGA().ShowConnectingAnimationWithHint(CCOJBMMKNAP.HEDIEIICOOG().PKNHKGMNCIP("OpenPasses"), this.GCKCOMCBHMB);
		}
		if (this.EEDHNEIMAPN == HHCKLPJJKIJ.none)
		{
			if (FacebookManager.KKPFOJMAONG().LNKKFHMOEKJ())
			{
				this.PMFNDCJEIHF();
				return;
			}
			FacebookManager.OOGPALHPNGM().KFCCANAPLOO();
			return;
		}
		else if (this.EEDHNEIMAPN == HHCKLPJJKIJ.apple)
		{
			if (GooglePlayServicesManager.ANCEKPONIFI().LCOFGIAOKBD())
			{
				this.PDIEDPJEOKG();
				return;
			}
			GooglePlayServicesManager.ANCEKPONIFI().JCAMIJNEGKN(CCIAGBPILGF);
			return;
		}
		else if (this.EEDHNEIMAPN == HHCKLPJJKIJ.device)
		{
			if (AppleSignInManager.FILDBDMENPG().MAEIGJPNANG())
			{
				this.GLNIBIBMAOL();
				return;
			}
			AppleSignInManager.BIAEAOMHBMM().MHJCJDIALLI();
			return;
		}
		else if (this.EEDHNEIMAPN == (HHCKLPJJKIJ)8)
		{
			if (SteamSignInManager.AGANFKKBPFO().JFCGDCCDKDB())
			{
				this.AJLNFEDJLHA();
				return;
			}
			SteamSignInManager.LMCCLMFGEBD().COHMNJCDGIL();
			return;
		}
		else if (this.EEDHNEIMAPN == HHCKLPJJKIJ.facebook)
		{
			if (CCIAGBPILGF != (JCAPGCCNOMP)6)
			{
				DPGJIJGOCIC.ANOPFDLPKGC("loungelockedinfo");
				this.EEDHNEIMAPN = (HHCKLPJJKIJ)8;
				this.BEKGFLJPBAP();
				CommonUserInterface.EHBBFMCILPC.ShowConnectingAnimationWithHint(CCOJBMMKNAP.MLFAGAAJJEM().HHLECNIFHCO(")"), this.GCKCOMCBHMB);
				return;
			}
			if (UserpassSignInManager.FDELMKCNOJB().IKKFBIJHNCL())
			{
				this.PDIEDPJEOKG();
				return;
			}
			UserpassSignInManager.EHBBFMCILPC.EDECICNGCJI();
			return;
		}
		else
		{
			if (this.EEDHNEIMAPN == (HHCKLPJJKIJ)7)
			{
				this.PMFNDCJEIHF();
				return;
			}
			DPGJIJGOCIC.ANOPFDLPKGC("</i>");
			return;
		}
	}

	// Token: 0x0600A276 RID: 41590 RVA: 0x00468138 File Offset: 0x00466338
	public void OnSignInRetry()
	{
		if (this.EEDHNEIMAPN != HHCKLPJJKIJ.token)
		{
			CommonUserInterface.EHBBFMCILPC.ShowConnectingAnimationWithHint(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("hintsigning"), this.GCKCOMCBHMB);
		}
		this.StartSignInLogic(this.EEDHNEIMAPN, this.GDEIABKFOOA, this.AOCIKAOPPDL, this.GCKCOMCBHMB);
	}

	// Token: 0x0600A277 RID: 41591 RVA: 0x0046818B File Offset: 0x0046638B
	private void ABALICGDAIM()
	{
		AOBJLALDBAA.DBLAIDPICIG().CIGLHCJDDPI("OnNeedToShowNoMoreEnergyPopup", 803f);
	}

	// Token: 0x0600A278 RID: 41592 RVA: 0x004681A4 File Offset: 0x004663A4
	private void HCJHLBFFNKA()
	{
		AOBJLALDBAA.FILDBDMENPG().EFKNEJFLGED("Swipe tutorial frame container not available, tutorial skipped:", new UnityAction(this.PDIEDPJEOKG));
		AOBJLALDBAA.AGANFKKBPFO().FNMOFCMDFJP("emailcollecheader", new UnityAction(this.CDJAJMNJDJC));
		AOBJLALDBAA.CEGAOMEEFBE().GNBGEMMDGOJ(" ", new UnityAction(this.BEKGFLJPBAP));
		AOBJLALDBAA.NMGMNAKLLMI().BADOPKAOCPE("assetbundleprofiledata5", new UnityAction(this.CDJAJMNJDJC));
		AOBJLALDBAA.NMGMNAKLLMI().PEFKJOKLEDL("assetbundleprofiledatalocalized", new UnityAction(this.PKEHEJFHGBD));
		AOBJLALDBAA.BIAEAOMHBMM().FNMOFCMDFJP("OnEmailUnsubscribeSuccess", new UnityAction(this.PMFNDCJEIHF));
		AOBJLALDBAA.CEGAOMEEFBE().FNMOFCMDFJP("fsofl", new UnityAction(this.GDCJEIGGDPL));
		AOBJLALDBAA.NMGMNAKLLMI().BADOPKAOCPE(" ", new UnityAction(this.PDIEDPJEOKG));
		AOBJLALDBAA.NMGMNAKLLMI().PEFKJOKLEDL("profilenametitleshort", new UnityAction(this.GDCJEIGGDPL));
		AOBJLALDBAA.FILDBDMENPG().FNMOFCMDFJP("acomp", new UnityAction(this.AJLNFEDJLHA));
		AOBJLALDBAA.CEGAOMEEFBE().EFKNEJFLGED("none", new UnityAction(this.LHAOOFAEFPD));
		AOBJLALDBAA.CEGAOMEEFBE().PEFKJOKLEDL("Asset bundle load operation failed during parallel mode.", new UnityAction(this.LMOIOINJFPN));
		AOBJLALDBAA.CEGAOMEEFBE().FNMOFCMDFJP("+", new UnityAction(this.MDKCJLEPIOD));
	}

	// Token: 0x0600A279 RID: 41593 RVA: 0x00468310 File Offset: 0x00466510
	private void PMIIGFCIPNB()
	{
		CommonUserInterface.EHBBFMCILPC.MCJIGJMFBMI();
		if (this.GDEIABKFOOA == JCAPGCCNOMP.none)
		{
			CommonUserInterface.EHBBFMCILPC.ShowGenericPopupTwoOverride(CCOJBMMKNAP.OEPENBHJAHO().HIPJILDCHJC("+"), CCOJBMMKNAP.GIOAFDDKKHI().PGKBCNBAOJN("loungenothingtoreset"), CCOJBMMKNAP.KLAKLFCOMJC().HDIPNMFHIEJ(""), new UnityAction(this.EMGIDHDADBM), new UnityAction(this.ALCHHKHOHJE), DFGILFBGPLN.popupNotEnoughStats, 1046f, -108);
			ApplicationFocusManager.Restore();
			return;
		}
		CommonUserInterface.EHBBFMCILPC.PEBIFCENHAL(CCOJBMMKNAP.NIOJNOFGIJO().HIPJILDCHJC("CleanseHiddenTopMatchLists(): removed "), CCOJBMMKNAP.JINDKPHNLBK().JLBEIFLLBLO(" and input "), CCOJBMMKNAP.KFAABHHGOPO().OHLNGCKIACD("continue"), new UnityAction(this.LJIEDAGBAJD), (DFGILFBGPLN)(-105), 1202f, -45);
		ApplicationFocusManager.Restore();
	}

	// Token: 0x0600A27A RID: 41594 RVA: 0x004631B7 File Offset: 0x004613B7
	private void GGKLFBOIKMF()
	{
		if (AccountSignInManager.IKLAPGJDMNA == this)
		{
			AccountSignInManager.IKLAPGJDMNA = null;
		}
	}

	// Token: 0x0600A27B RID: 41595 RVA: 0x004683E4 File Offset: 0x004665E4
	private void PKEHEJFHGBD()
	{
		CommonUserInterface.EHBBFMCILPC.HideConnectingAnimation();
		if (this.GDEIABKFOOA == JCAPGCCNOMP.auto)
		{
			CommonUserInterface.EHBBFMCILPC.ShowGenericPopupTwoOverride(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("errortitle"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("signincancel"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("retry"), new UnityAction(this.OnSignInRetry), new UnityAction(this.PIABINHPMMM), DFGILFBGPLN.popupSignInError, 0f, 28);
			ApplicationFocusManager.Restore();
			return;
		}
		CommonUserInterface.EHBBFMCILPC.ShowGenericPopupOneOverride(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("errortitle"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("signincancel"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("retry"), new UnityAction(this.OnSignInRetry), DFGILFBGPLN.popupSignInError, 0f, 28);
		ApplicationFocusManager.Restore();
	}

	// Token: 0x0600A27C RID: 41596 RVA: 0x004684B8 File Offset: 0x004666B8
	private void CNAGABDCIDJ()
	{
		CommonUserInterface.IKNOFBFMPGA().MCJIGJMFBMI();
		if (this.GDEIABKFOOA == JCAPGCCNOMP.none)
		{
			CommonUserInterface.IKNOFBFMPGA().JJPNFAAPFBI(CCOJBMMKNAP.KNKGCDDMLDP().OGKGHLHHAAI("OnAccountSignInRequestException"), CCOJBMMKNAP.DBFFFOMCLKM().HPOAGPJFHPM("OnRewardFreeDiamondsClick"), CCOJBMMKNAP.PLJMLDOCPNM().PGKBCNBAOJN("onAppOpenAttribution"), new UnityAction(this.ACBONKCAECN), new UnityAction(this.PIABINHPMMM), DFGILFBGPLN.popupInkRevisionMissing, 226f, 4);
			ApplicationFocusManager.Restore();
			return;
		}
		CommonUserInterface.EHBBFMCILPC.ShowGenericPopupOneOverride(CCOJBMMKNAP.EAIAHCBAIEJ().HPOAGPJFHPM("importanttitle"), CCOJBMMKNAP.DBFFFOMCLKM().JLBEIFLLBLO(""), CCOJBMMKNAP.LMCCLMFGEBD().IPEIONBNIPH("acomp1"), new UnityAction(this.ACBONKCAECN), (DFGILFBGPLN)(-115), 1987f, -90);
		ApplicationFocusManager.Restore();
	}

	// Token: 0x0600A27D RID: 41597 RVA: 0x000693D6 File Offset: 0x000675D6
	private void HFICKGDOLBO()
	{
		UnityEngine.Object.DontDestroyOnLoad(base.gameObject);
	}

	// Token: 0x0600A27E RID: 41598 RVA: 0x0046858C File Offset: 0x0046678C
	private void MGNHFFHBLBP()
	{
		AOBJLALDBAA.NMGMNAKLLMI().BADOPKAOCPE("assetbundleavatarextensionpack", new UnityAction(this.BEKGFLJPBAP));
		AOBJLALDBAA.KKPFOJMAONG().MFIMALJPCDP("socialcardvolinfonote", new UnityAction(this.CDJAJMNJDJC));
		AOBJLALDBAA.BIAEAOMHBMM().BADOPKAOCPE("OnRewardsItemClose", new UnityAction(this.PMFNDCJEIHF));
		AOBJLALDBAA.FILDBDMENPG().GNBGEMMDGOJ("AssetBundleManager.AssetBundleManifestHash.{0}", new UnityAction(this.BAMHKOINDCE));
		AOBJLALDBAA.NMGMNAKLLMI().BADOPKAOCPE("", new UnityAction(this.CNAGABDCIDJ));
		AOBJLALDBAA.CEGAOMEEFBE().MFIMALJPCDP("layervideo", new UnityAction(this.PMFNDCJEIHF));
		AOBJLALDBAA.EHBBFMCILPC.EFKNEJFLGED("OnStoryAdsProviderAdSuccess", new UnityAction(this.FCMCBKANOCD));
		AOBJLALDBAA.FILDBDMENPG().PEFKJOKLEDL("[LoadingEnv] skipped, caching system not ready after ", new UnityAction(this.AJLNFEDJLHA));
		AOBJLALDBAA.DBLAIDPICIG().MFIMALJPCDP("llosd", new UnityAction(this.FCMCBKANOCD));
		AOBJLALDBAA.AGANFKKBPFO().PEFKJOKLEDL("syn", new UnityAction(this.BEKGFLJPBAP));
		AOBJLALDBAA.CEGAOMEEFBE().PEFKJOKLEDL("YYY", new UnityAction(this.LHAOOFAEFPD));
		AOBJLALDBAA.KKPFOJMAONG().PEFKJOKLEDL("+", new UnityAction(this.EABGGFOKINI));
		AOBJLALDBAA.NMGMNAKLLMI().BADOPKAOCPE("app42error", new UnityAction(this.OFKNGIOLILC));
	}

	// Token: 0x0600A280 RID: 41600 RVA: 0x00002296 File Offset: 0x00000496
	private void OnApplicationQuit()
	{
		AppManager.isQuitting = true;
	}

	// Token: 0x0600A281 RID: 41601 RVA: 0x004686F8 File Offset: 0x004668F8
	private void JACFOOPHDND()
	{
		CommonUserInterface.IKNOFBFMPGA().MCJIGJMFBMI();
		AKLFPGMDKLA.EHBBFMCILPC.EEDHNEIMAPN = (int)this.EEDHNEIMAPN;
		if (this.GDEIABKFOOA == (JCAPGCCNOMP)6)
		{
			if (!AKLFPGMDKLA.EHBBFMCILPC.INEKFCLBCAB())
			{
				CommonUserInterface.IKNOFBFMPGA().CEGLPJNLBHL(CCOJBMMKNAP.GIOAFDDKKHI().GGPHHLGPMPA("iain"), CCOJBMMKNAP.KMNBCEMEBBD().HDIPNMFHIEJ(""), CCOJBMMKNAP.DBFFFOMCLKM().OBDCPLLLGBB("XXX"), new UnityAction(this.MBFAHMPJKLI), new UnityAction(this.ABALICGDAIM), (DFGILFBGPLN)96, 979f, 53);
				ApplicationFocusManager.Restore();
			}
			else if (this.EEDHNEIMAPN == HHCKLPJJKIJ.facebook)
			{
				CommonUserInterface.IKNOFBFMPGA().ShowGenericPopup(CCOJBMMKNAP.JMDJPKKOHNI().DNILNCLIHAP("lititle"), CCOJBMMKNAP.BBGECIKOICE().HPOAGPJFHPM("<i>"), CCOJBMMKNAP.KNKGCDDMLDP().OBDCPLLLGBB("VideoGlitches.VideoGlitch"), DFGILFBGPLN.screenAvatar, 845f, 111);
				ApplicationFocusManager.Restore();
			}
			else if (this.EEDHNEIMAPN == (HHCKLPJJKIJ)7)
			{
				CommonUserInterface.IKNOFBFMPGA().ShowGenericPopup(CCOJBMMKNAP.OEPENBHJAHO().HHLECNIFHCO("ffav"), CCOJBMMKNAP.PMABBOJDELF().FIENAKIHNOM("areyousurerestartnotea"), CCOJBMMKNAP.PMABBOJDELF().OBDCPLLLGBB("onwishcardclickbodymatch"), DFGILFBGPLN.popupOffer, 381f, 35);
				ApplicationFocusManager.Restore();
			}
			else if (this.EEDHNEIMAPN == (HHCKLPJJKIJ)7)
			{
				CommonUserInterface.EHBBFMCILPC.ShowGenericPopup(CCOJBMMKNAP.PLJMLDOCPNM().JHNELLJFBGC(""), CCOJBMMKNAP.KLAKLFCOMJC().HPOAGPJFHPM("?uid="), CCOJBMMKNAP.EAIAHCBAIEJ().PPALCPINPLK("-"), (DFGILFBGPLN)(-105), 1886f, 81);
				ApplicationFocusManager.Restore();
			}
			else if (this.EEDHNEIMAPN == HHCKLPJJKIJ.device)
			{
				CommonUserInterface.IKNOFBFMPGA().NFBMHHPIGFA(CCOJBMMKNAP.CEGAOMEEFBE().JCDFHKDNEDH(", rid:"), CCOJBMMKNAP.AEELGGPEJCC().BDGPNPNIAPA("sfxtimeoutwarning"), CCOJBMMKNAP.PEBMGCKFNAO().MEPECBDCOLG(""), (DFGILFBGPLN)(-93), 208f, -75);
				ApplicationFocusManager.Restore();
			}
			else if (this.EEDHNEIMAPN == HHCKLPJJKIJ.token)
			{
				CommonUserInterface.EHBBFMCILPC.NFBMHHPIGFA(CCOJBMMKNAP.KNKGCDDMLDP().FCOCLEHKLDJ("@SD"), CCOJBMMKNAP.BBGECIKOICE().HHLECNIFHCO(""), CCOJBMMKNAP.HJGDLOOHNLO().JLBEIFLLBLO(""), (DFGILFBGPLN)(-36), 1375f, -63);
				ApplicationFocusManager.Restore();
			}
			else
			{
				DPGJIJGOCIC.ANOPFDLPKGC("<color=#FF7670>");
			}
		}
		else if (this.GDEIABKFOOA == JCAPGCCNOMP.none)
		{
			if (!AKLFPGMDKLA.EHBBFMCILPC.INEKFCLBCAB())
			{
				AKLFPGMDKLA.EHBBFMCILPC.IDPFOGHKMBL();
				CommonUserInterface.EHBBFMCILPC.ShowGenericPopupTwoOverride(CCOJBMMKNAP.PLJMLDOCPNM().OHLNGCKIACD("frds"), CCOJBMMKNAP.EHBBFMCILPC.HDIPNMFHIEJ("ZZZ"), CCOJBMMKNAP.APGODIBBPOD().OBDCPLLLGBB("OnLoungePremiumChoicesHistoryException"), new UnityAction(this.FMNPEODNAIG), new UnityAction(this.ABALICGDAIM), (DFGILFBGPLN)(-4), 253f, 57);
				ApplicationFocusManager.Restore();
			}
			else
			{
				FirebaseAnalyticsManager.JMDJBFAEHBM().JIAAMJPKOCE(true, AGEHCPDNBFD.cdnActiv.ToString(), ((FFPHBMFGCNN)(-80)).ToString(), BGHLMGPPCNN.d1StoryCdnSt.ToString(), false, true);
				this.FMNPEODNAIG();
				AKLFPGMDKLA.EHBBFMCILPC.MJPKIMHENNF = 0;
				AKLFPGMDKLA.EHBBFMCILPC.OOEJIIJLKPK = 0;
			}
		}
		else
		{
			DPGJIJGOCIC.ANOPFDLPKGC(";");
		}
		AKLFPGMDKLA.EHBBFMCILPC.LPCBDEBKAIM();
	}

	// Token: 0x0600A282 RID: 41602 RVA: 0x00468A3D File Offset: 0x00466C3D
	private void MBFAHMPJKLI()
	{
		AOBJLALDBAA.FILDBDMENPG().KMAGHMCCMPG("top", 960f);
	}

	// Token: 0x0600A283 RID: 41603 RVA: 0x004631B7 File Offset: 0x004613B7
	private void CDLEEFPLPLN()
	{
		if (AccountSignInManager.IKLAPGJDMNA == this)
		{
			AccountSignInManager.IKLAPGJDMNA = null;
		}
	}

	// Token: 0x0600A284 RID: 41604 RVA: 0x004631B7 File Offset: 0x004613B7
	private void BNJLIDFJOGD()
	{
		if (AccountSignInManager.IKLAPGJDMNA == this)
		{
			AccountSignInManager.IKLAPGJDMNA = null;
		}
	}

	// Token: 0x0600A285 RID: 41605 RVA: 0x00462740 File Offset: 0x00460940
	public JCAPGCCNOMP DDPEIMNNHCO()
	{
		return this.GDEIABKFOOA;
	}

	// Token: 0x04002C73 RID: 11379
	public const string onAccountSignInSuccess = "OnAccountSignInSuccess";

	// Token: 0x04002C74 RID: 11380
	private const string OAMENJFGOFC = "OnAccountSignInRequestSuccess";

	// Token: 0x04002C75 RID: 11381
	private const string FMHKPCDHHED = "OnAccountSignInRequestException";

	// Token: 0x04002C76 RID: 11382
	private static AccountSignInManager IKLAPGJDMNA;

	// Token: 0x04002C77 RID: 11383
	private HHCKLPJJKIJ EEDHNEIMAPN;

	// Token: 0x04002C78 RID: 11384
	private JCAPGCCNOMP GDEIABKFOOA;

	// Token: 0x04002C79 RID: 11385
	private HHCKLPJJKIJ AOCIKAOPPDL;

	// Token: 0x04002C7A RID: 11386
	private byte GCKCOMCBHMB;
}
