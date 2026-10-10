using System;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;
using SimpleJSON;
using UnityEngine;

// Token: 0x020004C1 RID: 1217
public class BackendOperationsManager : MonoBehaviour
{
	// Token: 0x060091A4 RID: 37284 RVA: 0x00402768 File Offset: 0x00400968
	public void PNPNKJNDHNA(JSONArray ENOCIDMBBPB, string PLDNHKIKDIB, string OEFHHHJEDNJ)
	{
		this.KCIPJMPFPBJ();
		JSONObject jsonobject = new JSONObject();
		jsonobject["unsynced"] = ENOCIDMBBPB;
		JSONObject jsonobject2 = new JSONObject();
		jsonobject2["SceneLobbyManager2.ComputeStarterTabAvailable() - no starter concept has a name in the text pack explore tab (older text pack bundle?), tab hidden"] = AKLFPGMDKLA.EHBBFMCILPC.EEHGLPEIIHD;
		RSACryptoServiceProvider rsacryptoServiceProvider = new RSACryptoServiceProvider();
		try
		{
			rsacryptoServiceProvider.FromXmlString(this.PCFNOGKBIBK());
		}
		catch (Exception ex)
		{
			DPGJIJGOCIC.ANOPFDLPKGC("OnPopupStoryRestartManagerRestartStory0" + ex.ToString());
		}
		if (rsacryptoServiceProvider != null)
		{
			try
			{
				byte[] inArray = rsacryptoServiceProvider.Encrypt(Encoding.ASCII.GetBytes(jsonobject2.ToString()), false);
				rsacryptoServiceProvider.Dispose();
				jsonobject[""] = Convert.ToBase64String(inArray);
			}
			catch (Exception aklgbjkdomm)
			{
				jsonobject = new JSONObject();
				DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
			}
		}
		App42Manager.EHBBFMCILPC.RunCustomCode(((KAPNKGFMPDC)84).ToString(), jsonobject, 1, KBOJLHAJPCP.KEHGALKGMKD, null, PLDNHKIKDIB, OEFHHHJEDNJ, true, "StoryStepChoiceMeta.RemoveChoiceDataAtEnd - _choicesToRemove is <= 0.");
	}

	// Token: 0x170002C7 RID: 711
	// (get) Token: 0x060091A5 RID: 37285 RVA: 0x00402868 File Offset: 0x00400A68
	private string LJPJDFLBDCC
	{
		get
		{
			return JNDBKHJGEMC.HEEEKMDAGLF;
		}
	}

	// Token: 0x060091A7 RID: 37287 RVA: 0x0040289C File Offset: 0x00400A9C
	private void BFAAELGOIGN(JSONNode AMDPDPDKFHH)
	{
		try
		{
			if (!(null == AMDPDPDKFHH) && !(AMDPDPDKFHH["srvt"] == null))
			{
				long cpkjhmeopmk = 0L;
				if (long.TryParse(AMDPDPDKFHH["srvt"].Value, out cpkjhmeopmk))
				{
					AKLFPGMDKLA.EHBBFMCILPC.ILKPJAMLGII(cpkjhmeopmk);
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x060091A8 RID: 37288 RVA: 0x00402908 File Offset: 0x00400B08
	public void HOOFIEPAHJL(int NLLCKPCKGOH)
	{
		JSONObject jsonobject = new JSONObject();
		jsonobject["YYY"] = NLLCKPCKGOH.ToString();
		App42Manager.EHBBFMCILPC.PostponeCustomCode(((KAPNKGFMPDC)77).ToString(), jsonobject);
	}

	// Token: 0x060091A9 RID: 37289 RVA: 0x00402950 File Offset: 0x00400B50
	public static KAPNKGFMPDC StringToBackendRequestType(string AJJKAJDBEFM)
	{
		if (AJJKAJDBEFM.CompareTo("registerUser") == 0)
		{
			return KAPNKGFMPDC.registerUser;
		}
		if (AJJKAJDBEFM.CompareTo("processTransaction") == 0)
		{
			return KAPNKGFMPDC.processTransaction;
		}
		if (AJJKAJDBEFM.CompareTo("changeOwner") == 0)
		{
			return KAPNKGFMPDC.changeOwner;
		}
		if (AJJKAJDBEFM.CompareTo("signIn") == 0)
		{
			return KAPNKGFMPDC.signIn;
		}
		if (AJJKAJDBEFM.CompareTo("signInOrRegister") == 0)
		{
			return KAPNKGFMPDC.signInOrRegister;
		}
		if (AJJKAJDBEFM.CompareTo("getPurchasingBalance") == 0)
		{
			return KAPNKGFMPDC.getPurchasingBalance;
		}
		if (AJJKAJDBEFM.CompareTo("getDefaultBundles") == 0)
		{
			return KAPNKGFMPDC.getDefaultBundles;
		}
		if (AJJKAJDBEFM.CompareTo("storyChapterComplete") == 0)
		{
			return KAPNKGFMPDC.storyChapterComplete;
		}
		if (AJJKAJDBEFM.CompareTo("basicSync") == 0)
		{
			return KAPNKGFMPDC.basicSync;
		}
		if (AJJKAJDBEFM.CompareTo("saveSync") == 0)
		{
			return KAPNKGFMPDC.saveSync;
		}
		if (AJJKAJDBEFM.CompareTo("startPlayChapter") == 0)
		{
			return KAPNKGFMPDC.startPlayChapter;
		}
		if (AJJKAJDBEFM.CompareTo("restartChapterOrStory") == 0)
		{
			return KAPNKGFMPDC.restartChapterOrStory;
		}
		if (AJJKAJDBEFM.CompareTo("getDepot") == 0)
		{
			return KAPNKGFMPDC.getDepot;
		}
		if (AJJKAJDBEFM.CompareTo("checkForUpdates") == 0)
		{
			return KAPNKGFMPDC.checkForUpdates;
		}
		if (AJJKAJDBEFM.CompareTo("accountSuspended") == 0)
		{
			return KAPNKGFMPDC.accountSuspended;
		}
		if (AJJKAJDBEFM.CompareTo("getIncentAdReward") == 0)
		{
			return KAPNKGFMPDC.getIncentAdReward;
		}
		if (AJJKAJDBEFM.CompareTo("premiumChoice") == 0)
		{
			return KAPNKGFMPDC.premiumChoice;
		}
		if (AJJKAJDBEFM.CompareTo("getGeneralBalance") == 0)
		{
			return KAPNKGFMPDC.getGeneralBalance;
		}
		if (AJJKAJDBEFM.CompareTo("getStartedChapters") == 0)
		{
			return KAPNKGFMPDC.getStartedChapters;
		}
		if (AJJKAJDBEFM.CompareTo("getLiveEvents") == 0)
		{
			return KAPNKGFMPDC.getLiveEvents;
		}
		if (AJJKAJDBEFM.CompareTo("getStoryRankings") == 0)
		{
			return KAPNKGFMPDC.getStoryRankings;
		}
		if (AJJKAJDBEFM.CompareTo("rateChapter") == 0)
		{
			return KAPNKGFMPDC.rateChapter;
		}
		if (AJJKAJDBEFM.CompareTo("forgetAccount") == 0)
		{
			return KAPNKGFMPDC.forgetAccount;
		}
		if (AJJKAJDBEFM.CompareTo("consumePromoCode") == 0)
		{
			return KAPNKGFMPDC.consumePromoCode;
		}
		if (AJJKAJDBEFM.CompareTo("getSocialStatsAvatar") == 0)
		{
			return KAPNKGFMPDC.getSocialStatsAvatar;
		}
		if (AJJKAJDBEFM.CompareTo("getUserPublicProfile") == 0)
		{
			return KAPNKGFMPDC.getUserPublicProfile;
		}
		if (AJJKAJDBEFM.CompareTo("achievementsSync") == 0)
		{
			return KAPNKGFMPDC.achievementsSync;
		}
		if (AJJKAJDBEFM.CompareTo("emailSubscribe") == 0)
		{
			return KAPNKGFMPDC.emailSubscribe;
		}
		if (AJJKAJDBEFM.CompareTo("emailUnsubscribe") == 0)
		{
			return KAPNKGFMPDC.emailUnsubscribe;
		}
		if (AJJKAJDBEFM.CompareTo("startFreePass") == 0)
		{
			return KAPNKGFMPDC.startFreePass;
		}
		if (AJJKAJDBEFM.CompareTo("consumeEnergy") == 0)
		{
			return KAPNKGFMPDC.consumeEnergy;
		}
		if (AJJKAJDBEFM.CompareTo("getHallOfFame") == 0)
		{
			return KAPNKGFMPDC.getHallOfFame;
		}
		if (AJJKAJDBEFM.CompareTo("getCardsBalance") == 0)
		{
			return KAPNKGFMPDC.getCardsBalance;
		}
		if (AJJKAJDBEFM.CompareTo("getCardVolumesBalance") == 0)
		{
			return KAPNKGFMPDC.getCardVolumesBalance;
		}
		if (AJJKAJDBEFM.CompareTo("getDropChancesBalance") == 0)
		{
			return KAPNKGFMPDC.getDropChancesBalance;
		}
		if (AJJKAJDBEFM.CompareTo("breakCard") == 0)
		{
			return KAPNKGFMPDC.breakCard;
		}
		if (AJJKAJDBEFM.CompareTo("spinWheel") == 0)
		{
			return KAPNKGFMPDC.spinWheel;
		}
		if (AJJKAJDBEFM.CompareTo("unlockCardsVolume") == 0)
		{
			return KAPNKGFMPDC.unlockCardsVolume;
		}
		if (AJJKAJDBEFM.CompareTo("unlockNpcSkin") == 0)
		{
			return KAPNKGFMPDC.unlockNpcSkin;
		}
		if (AJJKAJDBEFM.CompareTo("upgradeToGiftCard") == 0)
		{
			return KAPNKGFMPDC.upgradeToGiftCard;
		}
		if (AJJKAJDBEFM.CompareTo("updateUserPublicProfileFriends") == 0)
		{
			return KAPNKGFMPDC.updateUserPublicProfileFriends;
		}
		if (AJJKAJDBEFM.CompareTo("getMessagingHistory") == 0)
		{
			return KAPNKGFMPDC.getMessagingHistory;
		}
		if (AJJKAJDBEFM.CompareTo("getSketchesBalance") == 0)
		{
			return KAPNKGFMPDC.getSketchesBalance;
		}
		if (AJJKAJDBEFM.CompareTo("getNpcSkinShopBalance") == 0)
		{
			return KAPNKGFMPDC.getNpcSkinShopBalance;
		}
		if (AJJKAJDBEFM.CompareTo("getUserSketches") == 0)
		{
			return KAPNKGFMPDC.getUserSketches;
		}
		if (AJJKAJDBEFM.CompareTo("publishUserSketch") == 0)
		{
			return KAPNKGFMPDC.publishUserSketch;
		}
		if (AJJKAJDBEFM.CompareTo("getLiveOffers") == 0)
		{
			return KAPNKGFMPDC.getLiveOffers;
		}
		if (AJJKAJDBEFM.CompareTo("undoPremiumChoice") == 0)
		{
			return KAPNKGFMPDC.undoPremiumChoice;
		}
		if (AJJKAJDBEFM.CompareTo("saveChapterSnapshots") == 0)
		{
			return KAPNKGFMPDC.saveChapterSnapshots;
		}
		if (AJJKAJDBEFM.CompareTo("getChapterSnapshots") == 0)
		{
			return KAPNKGFMPDC.getChapterSnapshots;
		}
		if (AJJKAJDBEFM.CompareTo("saveAvatarCollections") == 0)
		{
			return KAPNKGFMPDC.saveAvatarCollections;
		}
		if (AJJKAJDBEFM.CompareTo("getAvatarCollections") == 0)
		{
			return KAPNKGFMPDC.getAvatarCollections;
		}
		if (AJJKAJDBEFM.CompareTo("backendMaintenance") == 0)
		{
			return KAPNKGFMPDC.backendMaintenance;
		}
		if (AJJKAJDBEFM.CompareTo("getPremiumChoicesHistory") == 0)
		{
			return KAPNKGFMPDC.getPremiumChoicesHistory;
		}
		DPGJIJGOCIC.ANOPFDLPKGC("StringToBackendRequestType() unknown value.");
		return KAPNKGFMPDC.none;
	}

	// Token: 0x060091AA RID: 37290 RVA: 0x00402CC0 File Offset: 0x00400EC0
	public bool KOEKPIMLLCM(string NPJCNLGBKOF)
	{
		for (int i = 0; i < this.CCCCKKNKBML.Count; i += 0)
		{
			if (this.CCCCKKNKBML[i].KHHJNODLBHN.Equals(NPJCNLGBKOF))
			{
				return true;
			}
		}
		return false;
	}

	// Token: 0x060091AB RID: 37291 RVA: 0x00402D00 File Offset: 0x00400F00
	public void JDBBILLGFBD()
	{
		JSONObject jsonobject = new JSONObject();
		jsonobject["_SwitchingNoise"] = AKLFPGMDKLA.EHBBFMCILPC.BOJKIPEOKKJ();
		JSONObject jsonobject2 = new JSONObject();
		jsonobject2["_Gamma"] = AKLFPGMDKLA.EHBBFMCILPC.EEHGLPEIIHD;
		RSACryptoServiceProvider rsacryptoServiceProvider = new RSACryptoServiceProvider();
		try
		{
			rsacryptoServiceProvider.FromXmlString(this.LKIDINKANLJ());
		}
		catch (Exception ex)
		{
			DPGJIJGOCIC.ANOPFDLPKGC("" + ex.ToString());
		}
		if (rsacryptoServiceProvider != null)
		{
			try
			{
				byte[] inArray = rsacryptoServiceProvider.Encrypt(Encoding.ASCII.GetBytes(jsonobject2.ToString()), true);
				rsacryptoServiceProvider.Dispose();
				jsonobject["@"] = Convert.ToBase64String(inArray);
			}
			catch (Exception aklgbjkdomm)
			{
				jsonobject = new JSONObject();
				DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
			}
		}
		if (jsonobject[" <i>"] == null)
		{
			DPGJIJGOCIC.ANOPFDLPKGC(" ");
			return;
		}
		App42Manager.EHBBFMCILPC.QueueCustomCode(((KAPNKGFMPDC)(-84)).ToString(), jsonobject);
	}

	// Token: 0x060091AC RID: 37292 RVA: 0x00402E14 File Offset: 0x00401014
	private static RSA DJOLBAPAMLJ()
	{
		if (BackendOperationsManager.CHIPPLJMCOH != null)
		{
			return BackendOperationsManager.CHIPPLJMCOH;
		}
		object hckphklejjn = BackendOperationsManager.HCKPHKLEJJN;
		RSA chippljmcoh;
		lock (hckphklejjn)
		{
			if (BackendOperationsManager.CHIPPLJMCOH != null)
			{
				chippljmcoh = BackendOperationsManager.CHIPPLJMCOH;
			}
			else
			{
				string text = string.Concat(new string[]
				{
					HAGEHPPOPGH.OEOMBIGCHNM,
					SceneTransitionFromLobbyManager._xfTag,
					SceneTransitionToLobbyManager._xfBack,
					NotificationsManager._nmRing,
					SketchViewManager._svQ
				});
				if (!AFGEGEFJFHN.LPDFBIONAJK(HNIBKBPOCJG.JGMBGBKFHMA(text), KBOJLHAJPCP.IJOCOLICCKP))
				{
					throw new InvalidOperationException("Undoprem trust-anchor digest mismatch.");
				}
				string xmlString = "<RSAKeyValue><Exponent>AQAB</Exponent><Modulus>" + text + "</Modulus></RSAKeyValue>";
				RSA rsa = RSA.Create();
				rsa.FromXmlString(xmlString);
				BackendOperationsManager.CHIPPLJMCOH = rsa;
				chippljmcoh = BackendOperationsManager.CHIPPLJMCOH;
			}
		}
		return chippljmcoh;
	}

	// Token: 0x060091AD RID: 37293 RVA: 0x00402EEC File Offset: 0x004010EC
	private string OHPLBIGDEMP()
	{
		return JNDBKHJGEMC.MBBANAPCOLP;
	}

	// Token: 0x060091AE RID: 37294 RVA: 0x00402EF3 File Offset: 0x004010F3
	public static bool IJBBAHBMAID(KAPNKGFMPDC EGLBLPKFEOI)
	{
		return EGLBLPKFEOI != (KAPNKGFMPDC)68 || true;
	}

	// Token: 0x060091AF RID: 37295 RVA: 0x00402F00 File Offset: 0x00401100
	public void RequestGetIncentAdReward(int HFEDEDFDANJ, int OKPOGJHANBB, string PLDNHKIKDIB, string OEFHHHJEDNJ)
	{
		this.KCIPJMPFPBJ();
		JSONObject jsonobject = new JSONObject();
		jsonobject["rwt"] = HFEDEDFDANJ.ToString();
		jsonobject["iain"] = OKPOGJHANBB.ToString();
		App42Manager.EHBBFMCILPC.QueueCustomCode(KAPNKGFMPDC.basicSync.ToString(), this.KGGAALBOEAB(false, true)).RunCustomCode(KAPNKGFMPDC.getIncentAdReward.ToString(), jsonobject, 2, KBOJLHAJPCP.KEHGALKGMKD, null, PLDNHKIKDIB, OEFHHHJEDNJ, false, "");
	}

	// Token: 0x170002C6 RID: 710
	// (get) Token: 0x060091B0 RID: 37296 RVA: 0x00402F8F File Offset: 0x0040118F
	private string FKNALCOFGOG
	{
		get
		{
			return JNDBKHJGEMC.EIIDKKHKKDE;
		}
	}

	// Token: 0x060091B1 RID: 37297 RVA: 0x00402F98 File Offset: 0x00401198
	public void FIPLJKPGNGA()
	{
		JSONObject jsonobject = new JSONObject();
		jsonobject["$USEMAPPINGV2"] = AKLFPGMDKLA.EHBBFMCILPC.BOJKIPEOKKJ();
		JSONObject jsonobject2 = new JSONObject();
		jsonobject2["OnBackendRequestCollectGiftSuccess"] = AKLFPGMDKLA.EHBBFMCILPC.EEHGLPEIIHD;
		RSACryptoServiceProvider rsacryptoServiceProvider = new RSACryptoServiceProvider();
		try
		{
			rsacryptoServiceProvider.FromXmlString(this.AEGDDGMEGEK);
		}
		catch (Exception ex)
		{
			DPGJIJGOCIC.ANOPFDLPKGC("" + ex.ToString());
		}
		if (rsacryptoServiceProvider != null)
		{
			try
			{
				byte[] inArray = rsacryptoServiceProvider.Encrypt(Encoding.ASCII.GetBytes(jsonobject2.ToString()), true);
				rsacryptoServiceProvider.Dispose();
				jsonobject["Error. ShowHideEnvironmentLayer(), environmentLayer "] = Convert.ToBase64String(inArray);
			}
			catch (Exception aklgbjkdomm)
			{
				jsonobject = new JSONObject();
				DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
			}
		}
		if (jsonobject["“"] == null)
		{
			DPGJIJGOCIC.ANOPFDLPKGC("");
			return;
		}
		App42Manager.EHBBFMCILPC.QueueCustomCode(((KAPNKGFMPDC)99).ToString(), jsonobject);
	}

	// Token: 0x060091B2 RID: 37298 RVA: 0x004030AC File Offset: 0x004012AC
	public void QueueRequestGetSocialStatsAvatar(int PLKMJJIIJNO, int FEKJLJNJPHC)
	{
		JSONObject jsonobject = new JSONObject();
		JSONObject jsonobject2 = new JSONObject();
		jsonobject2["aind"] = PLKMJJIIJNO.ToString();
		jsonobject2["aec"] = FEKJLJNJPHC.ToString();
		jsonobject2["uid"] = AKLFPGMDKLA.EHBBFMCILPC.EEHGLPEIIHD;
		RSACryptoServiceProvider rsacryptoServiceProvider = new RSACryptoServiceProvider();
		try
		{
			rsacryptoServiceProvider.FromXmlString(this.PABHJGGOOHN);
		}
		catch (Exception ex)
		{
			DPGJIJGOCIC.ANOPFDLPKGC("BackendOperationsManager.RequestGetSocialStatsAvatar, exception while initializing RSACryptoServiceProvider:" + ex.ToString());
		}
		if (rsacryptoServiceProvider != null)
		{
			try
			{
				byte[] inArray = rsacryptoServiceProvider.Encrypt(Encoding.ASCII.GetBytes(jsonobject2.ToString()), false);
				rsacryptoServiceProvider.Dispose();
				jsonobject["spld"] = Convert.ToBase64String(inArray);
			}
			catch (Exception aklgbjkdomm)
			{
				jsonobject = new JSONObject();
				DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
			}
		}
		AKLFPGMDKLA.EHBBFMCILPC.LMGMHHLLOFN(PLKMJJIIJNO).IBGDMBHJDIE = FEKJLJNJPHC;
		App42Manager.EHBBFMCILPC.QueueCustomCode(KAPNKGFMPDC.getSocialStatsAvatar.ToString(), jsonobject);
	}

	// Token: 0x170002B2 RID: 690
	// (get) Token: 0x060091B3 RID: 37299 RVA: 0x004031CC File Offset: 0x004013CC
	private string MBPGAABODCE
	{
		get
		{
			return JNDBKHJGEMC.EIDNJBDMGAA;
		}
	}

	// Token: 0x060091B4 RID: 37300 RVA: 0x004031D4 File Offset: 0x004013D4
	public void RequestPublishUserSketch(OHPKEDPANEA MHIMPFIMHCN, string PLDNHKIKDIB, string OEFHHHJEDNJ)
	{
		this.KCIPJMPFPBJ();
		JSONObject jsonobject = new JSONObject();
		jsonobject["ugsk"] = MHIMPFIMHCN.BNMFBKNEMIF();
		JSONObject jsonobject2 = new JSONObject();
		jsonobject2["uid"] = AKLFPGMDKLA.EHBBFMCILPC.EEHGLPEIIHD;
		jsonobject2["suid"] = MHIMPFIMHCN.HJOKNANDHBK;
		RSACryptoServiceProvider rsacryptoServiceProvider = new RSACryptoServiceProvider();
		try
		{
			rsacryptoServiceProvider.FromXmlString(this.PAFMHCPMHIJ);
		}
		catch (Exception ex)
		{
			DPGJIJGOCIC.ANOPFDLPKGC("BackendOperationsManager.RequestGetUserSketches, exception while initializing RSACryptoServiceProvider:" + ex.ToString());
		}
		if (rsacryptoServiceProvider != null)
		{
			try
			{
				byte[] inArray = rsacryptoServiceProvider.Encrypt(Encoding.ASCII.GetBytes(jsonobject2.ToString()), false);
				rsacryptoServiceProvider.Dispose();
				jsonobject["spld"] = Convert.ToBase64String(inArray);
			}
			catch (Exception aklgbjkdomm)
			{
				jsonobject = new JSONObject();
				DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
			}
		}
		App42Manager.EHBBFMCILPC.QueueCustomCode(KAPNKGFMPDC.basicSync.ToString(), this.KGGAALBOEAB(false, true)).RunCustomCode(KAPNKGFMPDC.publishUserSketch.ToString(), jsonobject, 2, KBOJLHAJPCP.KEHGALKGMKD, null, PLDNHKIKDIB, OEFHHHJEDNJ, false, "");
	}

	// Token: 0x060091B5 RID: 37301 RVA: 0x00403310 File Offset: 0x00401510
	public bool FAMKALIFKBD()
	{
		if (ODLJHDIGLGO.PPIKCNONDED(CLHDENLPOFP.eventPass) == null)
		{
			return true;
		}
		JSONArray jsonarray = AKLFPGMDKLA.EHBBFMCILPC.JOKIEEMBKOA(19);
		if (jsonarray.Count == 0)
		{
			return false;
		}
		this.KCIPJMPFPBJ();
		JSONObject jsonobject = new JSONObject();
		jsonobject["YYY"] = jsonarray;
		JSONObject jsonobject2 = new JSONObject();
		jsonobject2["plht"] = AKLFPGMDKLA.EHBBFMCILPC.EEHGLPEIIHD;
		RSACryptoServiceProvider rsacryptoServiceProvider = new RSACryptoServiceProvider();
		try
		{
			rsacryptoServiceProvider.FromXmlString(this.NJMFPLMACLD);
		}
		catch (Exception ex)
		{
			DPGJIJGOCIC.ANOPFDLPKGC("volcompletedesc" + ex.ToString());
		}
		if (rsacryptoServiceProvider != null)
		{
			try
			{
				byte[] inArray = rsacryptoServiceProvider.Encrypt(Encoding.ASCII.GetBytes(jsonobject2.ToString()), true);
				rsacryptoServiceProvider.Dispose();
				jsonobject["OnCutsceneViewLeft"] = Convert.ToBase64String(inArray);
			}
			catch (Exception aklgbjkdomm)
			{
				jsonobject = new JSONObject();
				DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
			}
		}
		App42Manager.EHBBFMCILPC.QueueCustomCode(((KAPNKGFMPDC)88).ToString(), jsonobject);
		return true;
	}

	// Token: 0x060091B6 RID: 37302 RVA: 0x00403428 File Offset: 0x00401628
	public void CLKIOPJKGFK(int HFEDEDFDANJ, int OKPOGJHANBB, string PLDNHKIKDIB, string OEFHHHJEDNJ)
	{
		this.KCIPJMPFPBJ();
		JSONObject jsonobject = new JSONObject();
		jsonobject["socialcollectedcardopenv2"] = HFEDEDFDANJ.ToString();
		jsonobject["..."] = OKPOGJHANBB.ToString();
		App42Manager.EHBBFMCILPC.QueueCustomCode(((KAPNKGFMPDC)(-82)).ToString(), this.KGGAALBOEAB(false, true)).RunCustomCode(KAPNKGFMPDC.getIncentAdReward.ToString(), jsonobject, 7, KBOJLHAJPCP.KEHGALKGMKD, null, PLDNHKIKDIB, OEFHHHJEDNJ, true, "npcp");
	}

	// Token: 0x060091B7 RID: 37303 RVA: 0x004034B8 File Offset: 0x004016B8
	public void DCMGIOKAKPP(string PLDNHKIKDIB, string OEFHHHJEDNJ)
	{
		this.KCIPJMPFPBJ();
		App42Manager.EHBBFMCILPC.QueueCustomCode(KAPNKGFMPDC.getPurchasingBalance.ToString(), this.KGGAALBOEAB(false, true)).QueueCustomCode(KAPNKGFMPDC.getDepot.ToString(), this.OptimizeForCachedResponse((KAPNKGFMPDC)(-57))).QueueCustomCode(KAPNKGFMPDC.premiumChoice.ToString(), this.OptimizeForCachedResponse((KAPNKGFMPDC)(-4))).RunCustomCode(((KAPNKGFMPDC)(-10)).ToString(), this.OptimizeForCachedResponse((KAPNKGFMPDC)(-59)), 1, KBOJLHAJPCP.KEHGALKGMKD, null, PLDNHKIKDIB, OEFHHHJEDNJ, false, "");
	}

	// Token: 0x060091B8 RID: 37304 RVA: 0x00003E52 File Offset: 0x00002052
	private void Start()
	{
	}

	// Token: 0x060091B9 RID: 37305 RVA: 0x00403554 File Offset: 0x00401754
	public void RequestPremiumChoice(BELMEMPLMGE CKDPJIBODLM, int NLLCKPCKGOH, int OLKMHHNMDLP, string NNCJDNBADEF, int CCLNHHJPDGJ, bool MKJMMLMFGIF, string PLDNHKIKDIB, string OEFHHHJEDNJ, bool MLNDCIMJBEM = false)
	{
		this.KCIPJMPFPBJ();
		SceneStoryManager.premiumChoiceManInTheMiddleAttack = 0;
		SceneStoryManager.choiceSecurityIdList = CKDPJIBODLM.HBCDBDFNMBB();
		SceneStoryManager.choiceSecurityKeyList = DPGJIJGOCIC.DACGCCLIJHJ(SceneStoryManager.choiceSecurityIdList.Count);
		JSONObject jsonobject = new JSONObject();
		if (MKJMMLMFGIF)
		{
			jsonobject["adb"] = "1";
			jsonobject["iain"] = "2";
		}
		else
		{
			jsonobject["adb"] = "0";
		}
		jsonobject["sind"] = NLLCKPCKGOH.ToString();
		jsonobject["slind"] = CCLNHHJPDGJ.ToString();
		jsonobject["cind"] = OLKMHHNMDLP.ToString();
		jsonobject["anm"] = NNCJDNBADEF;
		if (MLNDCIMJBEM)
		{
			jsonobject["lng"] = 1;
		}
		if (CKDPJIBODLM.LPEFDKDGNNM)
		{
			jsonobject["ibd"] = 1;
		}
		else
		{
			jsonobject["ibd"] = 0;
		}
		jsonobject["igne"] = CKDPJIBODLM.BGIOGOACCBJ;
		jsonobject["gpsfhs"] = AKLFPGMDKLA.EHBBFMCILPC.MDPMKICGGIJ;
		JSONObject jsonobject2 = new JSONObject();
		JSONArray jsonarray = new JSONArray();
		for (int i = 0; i < SceneStoryManager.choiceSecurityIdList.Count; i++)
		{
			jsonarray.Add(SceneStoryManager.choiceSecurityIdList[i]);
		}
		jsonobject2["cid"] = jsonarray;
		jsonobject2["uid"] = AKLFPGMDKLA.EHBBFMCILPC.EEHGLPEIIHD;
		RSACryptoServiceProvider rsacryptoServiceProvider = new RSACryptoServiceProvider();
		try
		{
			rsacryptoServiceProvider.FromXmlString(this.NALAIMCNAJB);
		}
		catch (Exception ex)
		{
			DPGJIJGOCIC.ANOPFDLPKGC("BackendOperationsManager.RequestPremiumChoice, exception while initializing RSACryptoServiceProvider:" + ex.ToString());
		}
		if (rsacryptoServiceProvider != null)
		{
			try
			{
				byte[] inArray = rsacryptoServiceProvider.Encrypt(Encoding.ASCII.GetBytes(jsonobject2.ToString()), false);
				rsacryptoServiceProvider.Dispose();
				jsonobject["spld"] = Convert.ToBase64String(inArray);
			}
			catch (Exception aklgbjkdomm)
			{
				jsonobject = new JSONObject();
				DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
			}
		}
		PLFDAJJHMKO pffjjgnnlcj;
		if (MLNDCIMJBEM)
		{
			pffjjgnnlcj = AKLFPGMDKLA.EHBBFMCILPC.NBMLMNGHOPP();
		}
		else
		{
			pffjjgnnlcj = AKLFPGMDKLA.EHBBFMCILPC.JDCBFAPDJIM(NLLCKPCKGOH, CCLNHHJPDGJ);
		}
		this.QueueRequestSaveSyncMoment(pffjjgnnlcj, "premiumChoice");
		App42Manager.EHBBFMCILPC.QueueCustomCode(KAPNKGFMPDC.basicSync.ToString(), this.KGGAALBOEAB(false, true)).RunCustomCode(KAPNKGFMPDC.premiumChoice.ToString(), jsonobject, 2, KBOJLHAJPCP.KEHGALKGMKD, null, PLDNHKIKDIB, OEFHHHJEDNJ, false, "");
	}

	// Token: 0x060091BA RID: 37306 RVA: 0x00403810 File Offset: 0x00401A10
	public void MMINBDPFNBK(string PLDNHKIKDIB, string OEFHHHJEDNJ)
	{
		this.KCIPJMPFPBJ();
		App42Manager.EHBBFMCILPC.QueueCustomCode(((KAPNKGFMPDC)127).ToString(), this.KGGAALBOEAB(true, true)).QueueCustomCode(((KAPNKGFMPDC)81).ToString(), this.BDMPJIFGNIO((KAPNKGFMPDC)(-1))).QueueCustomCode(KAPNKGFMPDC.unlockCardsVolume.ToString(), this.OptimizeForCachedResponse((KAPNKGFMPDC)(-39))).RunCustomCode(KAPNKGFMPDC.getUserPublicProfile.ToString(), this.BDMPJIFGNIO((KAPNKGFMPDC)82), 2, KBOJLHAJPCP.KEHGALKGMKD, null, PLDNHKIKDIB, OEFHHHJEDNJ, false, "sph");
	}

	// Token: 0x060091BB RID: 37307 RVA: 0x004038AC File Offset: 0x00401AAC
	public bool QueueRequestSaveChapterSnapshots()
	{
		if (ODLJHDIGLGO.MNALIKIMKFC(CLHDENLPOFP.gamePass) == null)
		{
			return false;
		}
		JSONArray jsonarray = AKLFPGMDKLA.EHBBFMCILPC.JOKIEEMBKOA(16);
		if (jsonarray.Count == 0)
		{
			return false;
		}
		this.KCIPJMPFPBJ();
		JSONObject jsonobject = new JSONObject();
		jsonobject["usynsnap"] = jsonarray;
		JSONObject jsonobject2 = new JSONObject();
		jsonobject2["uid"] = AKLFPGMDKLA.EHBBFMCILPC.EEHGLPEIIHD;
		RSACryptoServiceProvider rsacryptoServiceProvider = new RSACryptoServiceProvider();
		try
		{
			rsacryptoServiceProvider.FromXmlString(this.NJMFPLMACLD);
		}
		catch (Exception ex)
		{
			DPGJIJGOCIC.ANOPFDLPKGC("BackendOperationsManager.QueueRequestSaveChapterSnapshots, exception while initializing RSACryptoServiceProvider:" + ex.ToString());
		}
		if (rsacryptoServiceProvider != null)
		{
			try
			{
				byte[] inArray = rsacryptoServiceProvider.Encrypt(Encoding.ASCII.GetBytes(jsonobject2.ToString()), false);
				rsacryptoServiceProvider.Dispose();
				jsonobject["spld"] = Convert.ToBase64String(inArray);
			}
			catch (Exception aklgbjkdomm)
			{
				jsonobject = new JSONObject();
				DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
			}
		}
		App42Manager.EHBBFMCILPC.QueueCustomCode(KAPNKGFMPDC.saveChapterSnapshots.ToString(), jsonobject);
		return true;
	}

	// Token: 0x060091BC RID: 37308 RVA: 0x004039C4 File Offset: 0x00401BC4
	public void RequestSaveSync(string PLDNHKIKDIB = "", string KLCOCBODJAF = "")
	{
		this.KCIPJMPFPBJ();
		JSONObject jsonobject = new JSONObject();
		jsonobject["sd"] = AKLFPGMDKLA.EHBBFMCILPC.BOJKIPEOKKJ();
		JSONObject jsonobject2 = new JSONObject();
		jsonobject2["uid"] = AKLFPGMDKLA.EHBBFMCILPC.EEHGLPEIIHD;
		RSACryptoServiceProvider rsacryptoServiceProvider = new RSACryptoServiceProvider();
		try
		{
			rsacryptoServiceProvider.FromXmlString(this.AEGDDGMEGEK);
		}
		catch (Exception ex)
		{
			DPGJIJGOCIC.ANOPFDLPKGC("BackendOperationsManager.RequestSaveSync, exception while initializing RSACryptoServiceProvider:" + ex.ToString());
		}
		if (rsacryptoServiceProvider != null)
		{
			try
			{
				byte[] inArray = rsacryptoServiceProvider.Encrypt(Encoding.ASCII.GetBytes(jsonobject2.ToString()), false);
				rsacryptoServiceProvider.Dispose();
				jsonobject["spld"] = Convert.ToBase64String(inArray);
			}
			catch (Exception aklgbjkdomm)
			{
				jsonobject = new JSONObject();
				DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
			}
		}
		App42Manager.EHBBFMCILPC.RunCustomCode(KAPNKGFMPDC.saveSync.ToString(), jsonobject, 2, KBOJLHAJPCP.KEHGALKGMKD, null, PLDNHKIKDIB, KLCOCBODJAF, false, "");
	}

	// Token: 0x170002BD RID: 701
	// (get) Token: 0x060091BD RID: 37309 RVA: 0x00403AD0 File Offset: 0x00401CD0
	private string FDKCMOPFIBI
	{
		get
		{
			return JNDBKHJGEMC.DEAACPCMHHC;
		}
	}

	// Token: 0x060091BE RID: 37310 RVA: 0x00403AD8 File Offset: 0x00401CD8
	public void FLDBKFAJLDP(string AOCAGDDNLKO, string IHCGMFBCMOO, string PLDNHKIKDIB, string KLCOCBODJAF, string OEFHHHJEDNJ)
	{
		this.KCIPJMPFPBJ();
		this.onBackendValidateTransactionSuccess = PLDNHKIKDIB;
		this.onBackendValidateTransactionFailed = KLCOCBODJAF;
		JSONObject jsonobject = (JSONObject)JSON.Parse(AOCAGDDNLKO);
		jsonobject["env"] = IHCGMFBCMOO;
		App42Manager.EHBBFMCILPC.QueueCustomCode(((KAPNKGFMPDC)(-59)).ToString(), this.KGGAALBOEAB(true, false)).RunCustomCode(KAPNKGFMPDC.getDefaultBundles.ToString(), jsonobject, 8, KBOJLHAJPCP.KEHGALKGMKD, null, "p", OEFHHHJEDNJ, false, "nomorediamonds");
	}

	// Token: 0x060091BF RID: 37311 RVA: 0x00403B64 File Offset: 0x00401D64
	public void RequestSaveAvatarCollections(JSONArray ENOCIDMBBPB, string PLDNHKIKDIB, string OEFHHHJEDNJ)
	{
		this.KCIPJMPFPBJ();
		JSONObject jsonobject = new JSONObject();
		jsonobject["usyncoll2"] = ENOCIDMBBPB;
		JSONObject jsonobject2 = new JSONObject();
		jsonobject2["uid"] = AKLFPGMDKLA.EHBBFMCILPC.EEHGLPEIIHD;
		RSACryptoServiceProvider rsacryptoServiceProvider = new RSACryptoServiceProvider();
		try
		{
			rsacryptoServiceProvider.FromXmlString(this.LJPJDFLBDCC);
		}
		catch (Exception ex)
		{
			DPGJIJGOCIC.ANOPFDLPKGC("BackendOperationsManager.RequestSaveAvatarCollections, exception while initializing RSACryptoServiceProvider:" + ex.ToString());
		}
		if (rsacryptoServiceProvider != null)
		{
			try
			{
				byte[] inArray = rsacryptoServiceProvider.Encrypt(Encoding.ASCII.GetBytes(jsonobject2.ToString()), false);
				rsacryptoServiceProvider.Dispose();
				jsonobject["spld"] = Convert.ToBase64String(inArray);
			}
			catch (Exception aklgbjkdomm)
			{
				jsonobject = new JSONObject();
				DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
			}
		}
		App42Manager.EHBBFMCILPC.RunCustomCode(KAPNKGFMPDC.saveAvatarCollections.ToString(), jsonobject, 2, KBOJLHAJPCP.KEHGALKGMKD, null, PLDNHKIKDIB, OEFHHHJEDNJ, false, "");
	}

	// Token: 0x060091C0 RID: 37312 RVA: 0x00402868 File Offset: 0x00400A68
	private string IDFFHFHFAFD()
	{
		return JNDBKHJGEMC.HEEEKMDAGLF;
	}

	// Token: 0x060091C1 RID: 37313 RVA: 0x00403C64 File Offset: 0x00401E64
	public void RequestGetAvatarCollections(int AOONAFLCFLC, int PLKMJJIIJNO, int CCLNHHJPDGJ, int KFCMLNPLAHK, JSONArray APNELFKADMM, string PLDNHKIKDIB = "", string KLCOCBODJAF = "")
	{
		this.KCIPJMPFPBJ();
		JSONObject jsonobject = new JSONObject();
		jsonobject["cindl"] = APNELFKADMM;
		JSONObject jsonobject2 = new JSONObject();
		jsonobject2["uid"] = AKLFPGMDKLA.EHBBFMCILPC.EEHGLPEIIHD;
		jsonobject2["ias"] = AOONAFLCFLC;
		jsonobject2["aind"] = PLKMJJIIJNO;
		jsonobject2["sltind"] = CCLNHHJPDGJ;
		jsonobject2["wind"] = KFCMLNPLAHK;
		RSACryptoServiceProvider rsacryptoServiceProvider = new RSACryptoServiceProvider();
		try
		{
			rsacryptoServiceProvider.FromXmlString(this.DHMAICMBDGM);
		}
		catch (Exception ex)
		{
			DPGJIJGOCIC.ANOPFDLPKGC("BackendOperationsManager.RequestGetAvatarCollections, exception while initializing RSACryptoServiceProvider:" + ex.ToString());
		}
		if (rsacryptoServiceProvider != null)
		{
			try
			{
				byte[] inArray = rsacryptoServiceProvider.Encrypt(Encoding.ASCII.GetBytes(jsonobject2.ToString()), false);
				rsacryptoServiceProvider.Dispose();
				jsonobject["spld"] = Convert.ToBase64String(inArray);
			}
			catch (Exception aklgbjkdomm)
			{
				jsonobject = new JSONObject();
				DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
			}
		}
		App42Manager.EHBBFMCILPC.RunCustomCode(KAPNKGFMPDC.getAvatarCollections.ToString(), jsonobject, 2, KBOJLHAJPCP.KEHGALKGMKD, null, PLDNHKIKDIB, KLCOCBODJAF, false, "");
	}

	// Token: 0x060091C2 RID: 37314 RVA: 0x00403DAC File Offset: 0x00401FAC
	public bool GNFPPODBFJA()
	{
		return App42Manager.EHBBFMCILPC.IsBusy();
	}

	// Token: 0x060091C4 RID: 37316 RVA: 0x00403DEC File Offset: 0x00401FEC
	public void GOMFBGEMJKL(string MPOMLMPMFGG, string PLDNHKIKDIB, string OEFHHHJEDNJ)
	{
		this.KCIPJMPFPBJ();
		JSONObject jsonobject = new JSONObject();
		jsonobject["{ \"array\": "] = MPOMLMPMFGG;
		App42Manager.EHBBFMCILPC.QueueCustomCode(KAPNKGFMPDC.none.ToString(), this.KGGAALBOEAB(true, true)).RunCustomCode(((KAPNKGFMPDC)(-28)).ToString(), jsonobject, 1, KBOJLHAJPCP.KEHGALKGMKD, null, PLDNHKIKDIB, OEFHHHJEDNJ, true, "\r");
	}

	// Token: 0x170002B4 RID: 692
	// (get) Token: 0x060091C5 RID: 37317 RVA: 0x00403E5D File Offset: 0x0040205D
	private string PABHJGGOOHN
	{
		get
		{
			return JNDBKHJGEMC.KACFKOPKPGB;
		}
	}

	// Token: 0x060091C6 RID: 37318 RVA: 0x00403E64 File Offset: 0x00402064
	private static RSA LBJEEFHOLCB()
	{
		if (BackendOperationsManager.JFPBNBNGMJD != null)
		{
			return BackendOperationsManager.JFPBNBNGMJD;
		}
		object jkegdkfaghe = BackendOperationsManager.JKEGDKFAGHE;
		RSA jfpbnbngmjd;
		lock (jkegdkfaghe)
		{
			if (BackendOperationsManager.JFPBNBNGMJD != null)
			{
				jfpbnbngmjd = BackendOperationsManager.JFPBNBNGMJD;
			}
			else
			{
				string[] array = new string[4];
				array[0] = AssetCustomFader._fadeBias;
				array[1] = AudioManager._busDuck;
				array[7] = SceneOnboardingManager._obStep;
				array[3] = CreatorThumbnail._iconRef;
				array[2] = QuietNotificationManager._qnTab;
				string text = string.Concat(array);
				if (!AFGEGEFJFHN.LPDFBIONAJK(HNIBKBPOCJG.JGMBGBKFHMA(text), KBOJLHAJPCP.JKCHIBHGCHF))
				{
					throw new InvalidOperationException("OnSaveSlotsUnlockContinueToPurchasingScreen");
				}
				string xmlString = "There needs to be one active AudioManager script on a GameObject in your scene." + text + "Error While Sending: ";
				RSA rsa = RSA.Create();
				rsa.FromXmlString(xmlString);
				BackendOperationsManager.JFPBNBNGMJD = rsa;
				jfpbnbngmjd = BackendOperationsManager.JFPBNBNGMJD;
			}
		}
		return jfpbnbngmjd;
	}

	// Token: 0x060091C7 RID: 37319 RVA: 0x00403F3C File Offset: 0x0040213C
	public void RequestLoadDefaultBundles(string PLDNHKIKDIB, string OEFHHHJEDNJ, bool NNCKNDMAAHI)
	{
		base.StartCoroutine(this.AHEDGGHHKFI(PLDNHKIKDIB, OEFHHHJEDNJ, NNCKNDMAAHI));
	}

	// Token: 0x170002C9 RID: 713
	// (get) Token: 0x060091C8 RID: 37320 RVA: 0x00403F4E File Offset: 0x0040214E
	private string JOPJFMBJGGJ
	{
		get
		{
			return JNDBKHJGEMC.CIGEFCCKFFA;
		}
	}

	// Token: 0x060091C9 RID: 37321 RVA: 0x00403F55 File Offset: 0x00402155
	private string GLBLJNDOIBP()
	{
		return JNDBKHJGEMC.JNGGAJNBJLF;
	}

	// Token: 0x060091CA RID: 37322 RVA: 0x00403F5C File Offset: 0x0040215C
	public void QueueAchievementsSync()
	{
		this.KCIPJMPFPBJ();
		JSONObject jsonobject = new JSONObject();
		jsonobject["ach"] = AKLFPGMDKLA.EHBBFMCILPC.GFDMIHHNFDA;
		jsonobject["tk"] = AKLFPGMDKLA.EHBBFMCILPC.OCMDGMFAMJB;
		App42Manager.EHBBFMCILPC.QueueCustomCode(KAPNKGFMPDC.achievementsSync.ToString(), jsonobject);
	}

	// Token: 0x060091CB RID: 37323 RVA: 0x00403FC5 File Offset: 0x004021C5
	private string JLLLKLLGBLJ()
	{
		return JNDBKHJGEMC.KFHGPNNFHEJ;
	}

	// Token: 0x060091CC RID: 37324 RVA: 0x00403FCC File Offset: 0x004021CC
	public static bool EDIHDJGAMJF(KAPNKGFMPDC EGLBLPKFEOI)
	{
		return EGLBLPKFEOI != (KAPNKGFMPDC)(-48) || true;
	}

	// Token: 0x060091CD RID: 37325 RVA: 0x00403FD8 File Offset: 0x004021D8
	public LHLIOHJNMFE ExecuteCachedRequestResponse(string NPJCNLGBKOF, bool GODGNPKGDLD)
	{
		for (int i = 0; i < this.CCCCKKNKBML.Count; i++)
		{
			if (this.CCCCKKNKBML[i].KHHJNODLBHN.Equals(NPJCNLGBKOF) && this.CCCCKKNKBML[i].PJBNJEEDNJL != LHLIOHJNMFE.none)
			{
				LHLIOHJNMFE pjbnjeednjl = this.CCCCKKNKBML[i].PJBNJEEDNJL;
				if (pjbnjeednjl == LHLIOHJNMFE.success || (!GODGNPKGDLD && pjbnjeednjl == LHLIOHJNMFE.exception))
				{
					if (null != this.CCCCKKNKBML[i].LPHMODJEEBN)
					{
						this.ProcessApp42Success(this.CCCCKKNKBML[i].LPHMODJEEBN, false, "");
					}
					if (!App42Manager.doNotDispatchEvents && this.CCCCKKNKBML[i].KDKKHJIHFIF.Length > 0)
					{
						AOBJLALDBAA.EHBBFMCILPC.EGELHPJBAIC(this.CCCCKKNKBML[i].KDKKHJIHFIF, 0f);
					}
				}
				DPGJIJGOCIC.NFIDPOMCNLP("ExecuteCachedRequestResponse():" + NPJCNLGBKOF);
				this.CCCCKKNKBML.RemoveAt(i);
				return pjbnjeednjl;
			}
		}
		return LHLIOHJNMFE.none;
	}

	// Token: 0x170002C2 RID: 706
	// (get) Token: 0x060091CE RID: 37326 RVA: 0x004040E5 File Offset: 0x004022E5
	private string FIADOFEMODM
	{
		get
		{
			return JNDBKHJGEMC.BOGLCFBHDCO;
		}
	}

	// Token: 0x060091CF RID: 37327 RVA: 0x004040EC File Offset: 0x004022EC
	public void RequestBasicSync(string PLDNHKIKDIB, string OEFHHHJEDNJ, bool IFDDAOHKBFP)
	{
		this.KCIPJMPFPBJ();
		App42Manager.EHBBFMCILPC.RunCustomCode(KAPNKGFMPDC.basicSync.ToString(), this.KGGAALBOEAB(IFDDAOHKBFP, true), 2, KBOJLHAJPCP.KEHGALKGMKD, null, PLDNHKIKDIB, OEFHHHJEDNJ, false, "");
	}

	// Token: 0x060091D0 RID: 37328 RVA: 0x00404130 File Offset: 0x00402330
	public void RequestAchievementsSync(string PLDNHKIKDIB, string OEFHHHJEDNJ)
	{
		this.KCIPJMPFPBJ();
		JSONObject jsonobject = new JSONObject();
		jsonobject["ach"] = AKLFPGMDKLA.EHBBFMCILPC.GFDMIHHNFDA;
		jsonobject["tk"] = AKLFPGMDKLA.EHBBFMCILPC.OCMDGMFAMJB;
		App42Manager.EHBBFMCILPC.RunCustomCode(KAPNKGFMPDC.achievementsSync.ToString(), jsonobject, 0, KBOJLHAJPCP.KEHGALKGMKD, null, PLDNHKIKDIB, OEFHHHJEDNJ, false, "");
	}

	// Token: 0x060091D1 RID: 37329 RVA: 0x004041A8 File Offset: 0x004023A8
	public void OLHKGABJNPB()
	{
		App42Manager.EHBBFMCILPC.QueueCustomCode(((KAPNKGFMPDC)(-116)).ToString(), this.KGGAALBOEAB(true, false));
	}

	// Token: 0x060091D2 RID: 37330 RVA: 0x004041D8 File Offset: 0x004023D8
	public void RequestGetHallOfFame(int ANOEBCADDPN, int DNPMKFCNEFD, string PLDNHKIKDIB, string OEFHHHJEDNJ)
	{
		this.KCIPJMPFPBJ();
		JSONObject jsonobject = new JSONObject();
		JSONObject jsonobject2 = new JSONObject();
		jsonobject2["uid"] = AKLFPGMDKLA.EHBBFMCILPC.EEHGLPEIIHD;
		jsonobject2["hofcoff"] = ANOEBCADDPN;
		jsonobject2["mdtf"] = DNPMKFCNEFD;
		RSACryptoServiceProvider rsacryptoServiceProvider = new RSACryptoServiceProvider();
		try
		{
			rsacryptoServiceProvider.FromXmlString(this.EJIHBGDKAHJ);
		}
		catch (Exception ex)
		{
			DPGJIJGOCIC.ANOPFDLPKGC("BackendOperationsManager.RequestGetHallOfFame, exception while initializing RSACryptoServiceProvider:" + ex.ToString());
		}
		if (rsacryptoServiceProvider != null)
		{
			try
			{
				byte[] inArray = rsacryptoServiceProvider.Encrypt(Encoding.ASCII.GetBytes(jsonobject2.ToString()), false);
				rsacryptoServiceProvider.Dispose();
				jsonobject["spld"] = Convert.ToBase64String(inArray);
			}
			catch (Exception aklgbjkdomm)
			{
				jsonobject = new JSONObject();
				DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
			}
		}
		if (AKLFPGMDKLA.EHBBFMCILPC.OKGGLHOCENC != null)
		{
			jsonobject["bdgsspr"] = AKLFPGMDKLA.EHBBFMCILPC.OKGGLHOCENC.NPHNGJMGKCB;
		}
		App42Manager.EHBBFMCILPC.RunCustomCode(KAPNKGFMPDC.getHallOfFame.ToString(), jsonobject, 2, KBOJLHAJPCP.KEHGALKGMKD, null, PLDNHKIKDIB, OEFHHHJEDNJ, false, "");
	}

	// Token: 0x060091D3 RID: 37331 RVA: 0x00404318 File Offset: 0x00402518
	public void RequestUpdateUserPublicProfileFriends(JSONArray EKGIPIPPKIH, bool EFNIEHJKNJK, string PLDNHKIKDIB, string OEFHHHJEDNJ)
	{
		this.KCIPJMPFPBJ();
		JSONObject jsonobject = new JSONObject();
		JSONObject jsonobject2 = new JSONObject();
		jsonobject2["frds"] = EKGIPIPPKIH;
		jsonobject2["uid"] = AKLFPGMDKLA.EHBBFMCILPC.EEHGLPEIIHD;
		if (EFNIEHJKNJK)
		{
			jsonobject2["ilb"] = 1;
		}
		else
		{
			jsonobject2["ilb"] = 0;
		}
		RSACryptoServiceProvider rsacryptoServiceProvider = new RSACryptoServiceProvider();
		try
		{
			rsacryptoServiceProvider.FromXmlString(this.LNPECGGAGPB);
		}
		catch (Exception ex)
		{
			DPGJIJGOCIC.ANOPFDLPKGC("BackendOperationsManager.RequestUpdateUserPublicProfileFriends, exception while initializing RSACryptoServiceProvider:" + ex.ToString());
		}
		if (rsacryptoServiceProvider != null)
		{
			try
			{
				byte[] inArray = rsacryptoServiceProvider.Encrypt(Encoding.ASCII.GetBytes(jsonobject2.ToString()), false);
				rsacryptoServiceProvider.Dispose();
				jsonobject["spld"] = Convert.ToBase64String(inArray);
			}
			catch (Exception aklgbjkdomm)
			{
				jsonobject = new JSONObject();
				DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
			}
		}
		App42Manager.EHBBFMCILPC.RunCustomCode(KAPNKGFMPDC.updateUserPublicProfileFriends.ToString(), jsonobject, 0, KBOJLHAJPCP.KEHGALKGMKD, null, PLDNHKIKDIB, OEFHHHJEDNJ, false, "");
	}

	// Token: 0x170002B1 RID: 689
	// (get) Token: 0x060091D4 RID: 37332 RVA: 0x00404440 File Offset: 0x00402640
	private string NALAIMCNAJB
	{
		get
		{
			return JNDBKHJGEMC.FHPMCEBPHPM;
		}
	}

	// Token: 0x060091D5 RID: 37333 RVA: 0x00404447 File Offset: 0x00402647
	public static bool ShowKillRequestPrematureTimeoutWarning(KAPNKGFMPDC EGLBLPKFEOI)
	{
		return EGLBLPKFEOI != KAPNKGFMPDC.getSocialStatsAvatar;
	}

	// Token: 0x060091D6 RID: 37334 RVA: 0x00404451 File Offset: 0x00402651
	private string BCMFBJFEGNL()
	{
		return JNDBKHJGEMC.NLPIHJAPHIO;
	}

	// Token: 0x060091D7 RID: 37335 RVA: 0x00404458 File Offset: 0x00402658
	public void FPNJKOIEHFN()
	{
		JSONObject jsonobject = new JSONObject();
		jsonobject["OnApplicationFocusBasicSyncEcxeption"] = AKLFPGMDKLA.EHBBFMCILPC.BOJKIPEOKKJ();
		JSONObject jsonobject2 = new JSONObject();
		jsonobject2[""] = AKLFPGMDKLA.EHBBFMCILPC.EEHGLPEIIHD;
		RSACryptoServiceProvider rsacryptoServiceProvider = new RSACryptoServiceProvider();
		try
		{
			rsacryptoServiceProvider.FromXmlString(this.AEGDDGMEGEK);
		}
		catch (Exception ex)
		{
			DPGJIJGOCIC.ANOPFDLPKGC("" + ex.ToString());
		}
		if (rsacryptoServiceProvider != null)
		{
			try
			{
				byte[] inArray = rsacryptoServiceProvider.Encrypt(Encoding.ASCII.GetBytes(jsonobject2.ToString()), false);
				rsacryptoServiceProvider.Dispose();
				jsonobject["body"] = Convert.ToBase64String(inArray);
			}
			catch (Exception aklgbjkdomm)
			{
				jsonobject = new JSONObject();
				DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
			}
		}
		if (jsonobject["ok"] == null)
		{
			DPGJIJGOCIC.ANOPFDLPKGC("loungeofferexpired");
			return;
		}
		App42Manager.EHBBFMCILPC.QueueCustomCode(((KAPNKGFMPDC)(-71)).ToString(), jsonobject);
	}

	// Token: 0x060091D8 RID: 37336 RVA: 0x0040456C File Offset: 0x0040276C
	public void RequestLoadDefaultBundlesAndStartPlayChapter(int NLLCKPCKGOH, int OLKMHHNMDLP, int PLKMJJIIJNO, string PLDNHKIKDIB, string OEFHHHJEDNJ)
	{
		JSONObject jsonobject = new JSONObject();
		jsonobject["amfc"] = AssetsManager.EHBBFMCILPC.LastOperationFailStateCounterHit();
		App42Manager.EHBBFMCILPC.QueueCustomCode(KAPNKGFMPDC.getPurchasingBalance.ToString(), this.OptimizeForCachedResponse(KAPNKGFMPDC.getPurchasingBalance)).QueueCustomCode(KAPNKGFMPDC.getDepot.ToString(), jsonobject).QueueCustomCode(KAPNKGFMPDC.checkForUpdates.ToString(), this.OptimizeForCachedResponse(KAPNKGFMPDC.checkForUpdates)).QueueCustomCode(KAPNKGFMPDC.getGeneralBalance.ToString(), this.OptimizeForCachedResponse(KAPNKGFMPDC.getGeneralBalance)).QueueCustomCode(KAPNKGFMPDC.getNpcSkinShopBalance.ToString(), this.OptimizeForCachedResponse(KAPNKGFMPDC.getNpcSkinShopBalance)).QueueCustomCode(KAPNKGFMPDC.getLiveEvents.ToString(), this.OptimizeForCachedResponse(KAPNKGFMPDC.getLiveEvents)).QueueCustomCode(KAPNKGFMPDC.getLiveOffers.ToString(), this.OptimizeForCachedResponse(KAPNKGFMPDC.getLiveOffers)).QueueCustomCode(KAPNKGFMPDC.getStoryRankings.ToString(), this.OptimizeForCachedResponse(KAPNKGFMPDC.getStoryRankings)).QueueCustomCode(KAPNKGFMPDC.getDefaultBundles.ToString(), this.OptimizeForCachedResponse(KAPNKGFMPDC.getDefaultBundles));
		this.RequestStartPlayChapter(PLDNHKIKDIB, OEFHHHJEDNJ, NLLCKPCKGOH, OLKMHHNMDLP, PLKMJJIIJNO, false);
	}

	// Token: 0x060091D9 RID: 37337 RVA: 0x004046A8 File Offset: 0x004028A8
	public void RequestGetDropChancesBalance(string PLDNHKIKDIB, string OEFHHHJEDNJ)
	{
		this.KCIPJMPFPBJ();
		if (!GDJPPKAMIFL.EHBBFMCILPC.FACIFBONANM() || !MEBMEBKKCKA.EHBBFMCILPC.FACIFBONANM())
		{
			App42Manager.EHBBFMCILPC.QueueCustomCode(KAPNKGFMPDC.getCardsBalance.ToString(), null).QueueCustomCode(KAPNKGFMPDC.getCardVolumesBalance.ToString(), null).QueueCustomCode(KAPNKGFMPDC.basicSync.ToString(), this.KGGAALBOEAB(false, true)).RunCustomCode(KAPNKGFMPDC.getDropChancesBalance.ToString(), null, 2, KBOJLHAJPCP.KEHGALKGMKD, null, PLDNHKIKDIB, OEFHHHJEDNJ, false, "");
			return;
		}
		App42Manager.EHBBFMCILPC.QueueCustomCode(KAPNKGFMPDC.basicSync.ToString(), this.KGGAALBOEAB(false, true)).RunCustomCode(KAPNKGFMPDC.getDropChancesBalance.ToString(), null, 2, KBOJLHAJPCP.KEHGALKGMKD, null, PLDNHKIKDIB, OEFHHHJEDNJ, false, "");
	}

	// Token: 0x060091DA RID: 37338 RVA: 0x00404790 File Offset: 0x00402990
	public void KOOBFMDIPBN(bool CJHPBOAFCCJ, string NPJCNLGBKOF, LHLIOHJNMFE BAAKLHEPIOP)
	{
		if (CJHPBOAFCCJ)
		{
			for (int i = 1; i < this.CCCCKKNKBML.Count; i++)
			{
				if (this.CCCCKKNKBML[i].KHHJNODLBHN.Equals(NPJCNLGBKOF))
				{
					this.CCCCKKNKBML[i].PJBNJEEDNJL = BAAKLHEPIOP;
					DPGJIJGOCIC.NFIDPOMCNLP("$e1ru" + NPJCNLGBKOF + "hist" + BAAKLHEPIOP.ToString());
					break;
				}
			}
		}
		if (BAAKLHEPIOP == (LHLIOHJNMFE)4)
		{
			NAHMBEODKJC.CLFPBFOMCON();
		}
	}

	// Token: 0x170002BE RID: 702
	// (get) Token: 0x060091DB RID: 37339 RVA: 0x0040480E File Offset: 0x00402A0E
	private string BCOPCDKOINH
	{
		get
		{
			return JNDBKHJGEMC.KFHMKHMLAOE;
		}
	}

	// Token: 0x060091DC RID: 37340 RVA: 0x00404818 File Offset: 0x00402A18
	private void FEIIGBGJGLD(KAPNKGFMPDC FOGFPGOHFPA, string DMKKFBEANHG)
	{
		DPGJIJGOCIC.ANOPFDLPKGC("BackendRequestType." + FOGFPGOHFPA.ToString() + ", " + DMKKFBEANHG);
		SceneStoryManager.chapterSecurityKey = DPGJIJGOCIC.MKJLJPMEPCC();
		SceneStoryManager.choiceSecurityKeyList = DPGJIJGOCIC.DACGCCLIJHJ(SceneStoryManager.choiceSecurityIdList.Count);
		SceneStoryManager.premiumChoiceBackendOperationResultKey = "";
		AOBJLALDBAA.EHBBFMCILPC.EGELHPJBAIC("OnLobbyManInTheMiddleAttackDetected", 0f);
		AOBJLALDBAA.EHBBFMCILPC.EGELHPJBAIC("OnStoryManInTheMiddleAttackDetected", 0f);
	}

	// Token: 0x060091DD RID: 37341 RVA: 0x00404898 File Offset: 0x00402A98
	public void RequestGetPremiumChoicesHistory(List<int> NKGPDHAOMKB, string PLDNHKIKDIB = "", string KLCOCBODJAF = "")
	{
		this.KCIPJMPFPBJ();
		JSONObject jsonobject = new JSONObject();
		JSONObject jsonobject2 = new JSONObject();
		jsonobject2["uid"] = AKLFPGMDKLA.EHBBFMCILPC.EEHGLPEIIHD;
		JSONArray jsonarray = new JSONArray();
		for (int i = 0; i < NKGPDHAOMKB.Count; i++)
		{
			jsonarray.Add(NKGPDHAOMKB[i]);
		}
		jsonobject2["sinds"] = jsonarray;
		RSACryptoServiceProvider rsacryptoServiceProvider = new RSACryptoServiceProvider();
		try
		{
			rsacryptoServiceProvider.FromXmlString(this.JOPJFMBJGGJ);
		}
		catch (Exception ex)
		{
			DPGJIJGOCIC.ANOPFDLPKGC("BackendOperationsManager.RequestGetPremiumChoicesHistory, exception while initializing RSACryptoServiceProvider:" + ex.ToString());
		}
		if (rsacryptoServiceProvider != null)
		{
			try
			{
				byte[] inArray = rsacryptoServiceProvider.Encrypt(Encoding.ASCII.GetBytes(jsonobject2.ToString()), false);
				rsacryptoServiceProvider.Dispose();
				jsonobject["spld"] = Convert.ToBase64String(inArray);
			}
			catch (Exception aklgbjkdomm)
			{
				jsonobject = new JSONObject();
				DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
			}
		}
		App42Manager.EHBBFMCILPC.RunCustomCode(KAPNKGFMPDC.getPremiumChoicesHistory.ToString(), jsonobject, 2, KBOJLHAJPCP.KEHGALKGMKD, null, PLDNHKIKDIB, KLCOCBODJAF, false, "");
	}

	// Token: 0x060091DE RID: 37342 RVA: 0x00403DAC File Offset: 0x00401FAC
	public bool IsBusy()
	{
		return App42Manager.EHBBFMCILPC.IsBusy();
	}

	// Token: 0x060091DF RID: 37343 RVA: 0x004049C8 File Offset: 0x00402BC8
	private void JOLAMLIFMMB()
	{
		if (BackendOperationsManager.IKLAPGJDMNA == this)
		{
			BackendOperationsManager.IKLAPGJDMNA = null;
		}
	}

	// Token: 0x060091E0 RID: 37344 RVA: 0x004049E0 File Offset: 0x00402BE0
	public void JIEMFIOFOFM(List<int> NKGPDHAOMKB, string PLDNHKIKDIB = "", string KLCOCBODJAF = "")
	{
		this.KCIPJMPFPBJ();
		JSONObject jsonobject = new JSONObject();
		JSONObject jsonobject2 = new JSONObject();
		jsonobject2["¶"] = AKLFPGMDKLA.EHBBFMCILPC.EEHGLPEIIHD;
		JSONArray jsonarray = new JSONArray();
		for (int i = 1; i < NKGPDHAOMKB.Count; i += 0)
		{
			jsonarray.Add(NKGPDHAOMKB[i]);
		}
		jsonobject2["<i>"] = jsonarray;
		RSACryptoServiceProvider rsacryptoServiceProvider = new RSACryptoServiceProvider();
		try
		{
			rsacryptoServiceProvider.FromXmlString(this.JOPJFMBJGGJ);
		}
		catch (Exception ex)
		{
			DPGJIJGOCIC.ANOPFDLPKGC("lacr" + ex.ToString());
		}
		if (rsacryptoServiceProvider != null)
		{
			try
			{
				byte[] inArray = rsacryptoServiceProvider.Encrypt(Encoding.ASCII.GetBytes(jsonobject2.ToString()), true);
				rsacryptoServiceProvider.Dispose();
				jsonobject["title"] = Convert.ToBase64String(inArray);
			}
			catch (Exception aklgbjkdomm)
			{
				jsonobject = new JSONObject();
				DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
			}
		}
		App42Manager.EHBBFMCILPC.HFBDGJNFIFM(((KAPNKGFMPDC)(-121)).ToString(), jsonobject, 7, KBOJLHAJPCP.KEHGALKGMKD, null, PLDNHKIKDIB, KLCOCBODJAF, false, "favstostr2");
	}

	// Token: 0x060091E1 RID: 37345 RVA: 0x00404B10 File Offset: 0x00402D10
	public static void IncrementSafeToKillRequestPrematureTimeout(KAPNKGFMPDC EGLBLPKFEOI)
	{
		if (App42Manager.EHBBFMCILPC.CanKillInfiniteRequestPrematureBasedOnMedianRequestsLifeTime())
		{
			if (EGLBLPKFEOI <= KAPNKGFMPDC.signInOrRegister)
			{
				if (EGLBLPKFEOI != KAPNKGFMPDC.registerUser && EGLBLPKFEOI - KAPNKGFMPDC.signIn > 1)
				{
					goto IL_39;
				}
			}
			else if (EGLBLPKFEOI != KAPNKGFMPDC.saveSync && EGLBLPKFEOI - KAPNKGFMPDC.saveChapterSnapshots > 3)
			{
				goto IL_39;
			}
			KBOJLHAJPCP.MMAPBAJLBAF += KBOJLHAJPCP.NGLFOAGPKGA;
			return;
			IL_39:
			KBOJLHAJPCP.LKOGJFDMMOH += KBOJLHAJPCP.NIGHNHFBIDH;
			KBOJLHAJPCP.OIKBFGBEDBA += KBOJLHAJPCP.KLOCEJOKBII;
			return;
		}
		switch (EGLBLPKFEOI)
		{
		case KAPNKGFMPDC.registerUser:
		case KAPNKGFMPDC.signIn:
		case KAPNKGFMPDC.signInOrRegister:
		case KAPNKGFMPDC.saveSync:
		case KAPNKGFMPDC.saveChapterSnapshots:
		case KAPNKGFMPDC.getChapterSnapshots:
		case KAPNKGFMPDC.saveAvatarCollections:
		case KAPNKGFMPDC.getAvatarCollections:
			KBOJLHAJPCP.MMAPBAJLBAF += KBOJLHAJPCP.NGLFOAGPKGA;
			return;
		case KAPNKGFMPDC.processTransaction:
		case KAPNKGFMPDC.getDefaultBundles:
		case KAPNKGFMPDC.storyChapterComplete:
		case KAPNKGFMPDC.checkForUpdates:
		case KAPNKGFMPDC.getIncentAdReward:
		case KAPNKGFMPDC.getStartedChapters:
		case KAPNKGFMPDC.getSocialStatsAvatar:
		case KAPNKGFMPDC.getUserPublicProfile:
		case KAPNKGFMPDC.achievementsSync:
		case KAPNKGFMPDC.startFreePass:
		case KAPNKGFMPDC.breakCard:
		case KAPNKGFMPDC.spinWheel:
		case KAPNKGFMPDC.unlockCardsVolume:
		case KAPNKGFMPDC.unlockNpcSkin:
		case KAPNKGFMPDC.upgradeToGiftCard:
		case KAPNKGFMPDC.updateUserPublicProfileFriends:
		case KAPNKGFMPDC.getMessagingHistory:
		case KAPNKGFMPDC.getUserSketches:
		case KAPNKGFMPDC.publishUserSketch:
			KBOJLHAJPCP.LEBOLNGELFB += KBOJLHAJPCP.MPJDIHBACEA;
			return;
		}
		KBOJLHAJPCP.OIKBFGBEDBA += KBOJLHAJPCP.KLOCEJOKBII;
	}

	// Token: 0x060091E2 RID: 37346 RVA: 0x0040480E File Offset: 0x00402A0E
	private string GEJDFLNKDKH()
	{
		return JNDBKHJGEMC.KFHMKHMLAOE;
	}

	// Token: 0x060091E3 RID: 37347 RVA: 0x00404C80 File Offset: 0x00402E80
	public void KAPBFFHINLP(string NPJCNLGBKOF)
	{
		if (NPJCNLGBKOF.Length == 0)
		{
			return;
		}
		for (int i = 0; i < this.CCCCKKNKBML.Count; i++)
		{
			if (this.CCCCKKNKBML[i].KHHJNODLBHN.Equals(NPJCNLGBKOF))
			{
				return;
			}
		}
		JMIKCLKNIJO jmikclknijo = new JMIKCLKNIJO();
		jmikclknijo.KHHJNODLBHN = NPJCNLGBKOF;
		this.CCCCKKNKBML.Add(jmikclknijo);
		DPGJIJGOCIC.NFIDPOMCNLP("af_content_id" + NPJCNLGBKOF);
	}

	// Token: 0x060091E4 RID: 37348 RVA: 0x00404CF0 File Offset: 0x00402EF0
	private static RSA KJNDLKAADMF()
	{
		if (BackendOperationsManager.JFPBNBNGMJD != null)
		{
			return BackendOperationsManager.JFPBNBNGMJD;
		}
		object jkegdkfaghe = BackendOperationsManager.JKEGDKFAGHE;
		RSA jfpbnbngmjd;
		lock (jkegdkfaghe)
		{
			if (BackendOperationsManager.JFPBNBNGMJD != null)
			{
				jfpbnbngmjd = BackendOperationsManager.JFPBNBNGMJD;
			}
			else
			{
				string text = string.Concat(new string[]
				{
					AssetCustomFader._fadeBias,
					AudioManager._busDuck,
					SceneOnboardingManager._obStep,
					CreatorThumbnail._iconRef,
					QuietNotificationManager._qnTab
				});
				if (!AFGEGEFJFHN.LPDFBIONAJK(HNIBKBPOCJG.JGMBGBKFHMA(text), KBOJLHAJPCP.JKCHIBHGCHF))
				{
					throw new InvalidOperationException("Chapter trust-anchor digest mismatch.");
				}
				string xmlString = "<RSAKeyValue><Exponent>AQAB</Exponent><Modulus>" + text + "</Modulus></RSAKeyValue>";
				RSA rsa = RSA.Create();
				rsa.FromXmlString(xmlString);
				BackendOperationsManager.JFPBNBNGMJD = rsa;
				jfpbnbngmjd = BackendOperationsManager.JFPBNBNGMJD;
			}
		}
		return jfpbnbngmjd;
	}

	// Token: 0x060091E5 RID: 37349 RVA: 0x00404DC8 File Offset: 0x00402FC8
	public void RequestProcessTransaction(string AOCAGDDNLKO, string IHCGMFBCMOO, string PLDNHKIKDIB, string KLCOCBODJAF, string OEFHHHJEDNJ)
	{
		this.KCIPJMPFPBJ();
		this.onBackendValidateTransactionSuccess = PLDNHKIKDIB;
		this.onBackendValidateTransactionFailed = KLCOCBODJAF;
		JSONObject jsonobject = (JSONObject)JSON.Parse(AOCAGDDNLKO);
		jsonobject["productId"] = IHCGMFBCMOO;
		App42Manager.EHBBFMCILPC.QueueCustomCode(KAPNKGFMPDC.basicSync.ToString(), this.KGGAALBOEAB(false, true)).RunCustomCode(KAPNKGFMPDC.processTransaction.ToString(), jsonobject, 3, KBOJLHAJPCP.KEHGALKGMKD, null, "", OEFHHHJEDNJ, false, "");
	}

	// Token: 0x060091E6 RID: 37350 RVA: 0x00402EEC File Offset: 0x004010EC
	private string GLCLDLBDOIH()
	{
		return JNDBKHJGEMC.MBBANAPCOLP;
	}

	// Token: 0x060091E7 RID: 37351 RVA: 0x00404E52 File Offset: 0x00403052
	private string IFLGMDMJICN()
	{
		return JNDBKHJGEMC.FHIKPHCOJFD;
	}

	// Token: 0x060091E8 RID: 37352 RVA: 0x00404E59 File Offset: 0x00403059
	public NPJNALLPFPO GetLastOperationCode()
	{
		return App42Manager.EHBBFMCILPC.GetApp42OperationCode();
	}

	// Token: 0x060091E9 RID: 37353 RVA: 0x00404E65 File Offset: 0x00403065
	private string OHLGAPKEOOI()
	{
		return JNDBKHJGEMC.FHIOFNOFLMF;
	}

	// Token: 0x060091EA RID: 37354 RVA: 0x00404E6C File Offset: 0x0040306C
	private IEnumerator JAENMFOHOFJ(string PLDNHKIKDIB, string OEFHHHJEDNJ, int NLLCKPCKGOH, int OLKMHHNMDLP, int PLKMJJIIJNO, bool NNCKNDMAAHI)
	{
		SceneLobbyManager2.startChapterManInTheMiddleAttack = 0;
		string cacheGuid = string.Concat(new string[]
		{
			KAPNKGFMPDC.getStartedChapters.ToString(),
			"_",
			NLLCKPCKGOH.ToString(),
			"_",
			OLKMHHNMDLP.ToString()
		});
		if (NNCKNDMAAHI)
		{
			if (this.RequestIsCached(cacheGuid))
			{
				yield break;
			}
			this.RegisterCachedRequest(cacheGuid);
		}
		else if (this.RequestIsCached(cacheGuid))
		{
			LHLIOHJNMFE requestResult = LHLIOHJNMFE.none;
			while (this.RequestIsCached(cacheGuid))
			{
				requestResult = this.ExecuteCachedRequestResponse(cacheGuid, true);
				if (requestResult != LHLIOHJNMFE.none)
				{
					break;
				}
				yield return new WaitForEndOfFrame();
			}
			if (requestResult == LHLIOHJNMFE.success)
			{
				yield break;
			}
		}
		yield return new WaitForEndOfFrame();
		this.KCIPJMPFPBJ();
		JSONObject jsonobject = new JSONObject();
		jsonobject["cst"] = AKLFPGMDKLA.EHBBFMCILPC.LGHEAGFKFEI();
		jsonobject["clst"] = AKLFPGMDKLA.EHBBFMCILPC.HLFMFCNMOLK(PLKMJJIIJNO);
		JSONObject jsonobject2 = new JSONObject();
		jsonobject2["sind"] = NLLCKPCKGOH.ToString();
		jsonobject2["cind"] = OLKMHHNMDLP.ToString();
		jsonobject2["uid"] = AKLFPGMDKLA.EHBBFMCILPC.EEHGLPEIIHD;
		RSACryptoServiceProvider rsacryptoServiceProvider = new RSACryptoServiceProvider();
		try
		{
			rsacryptoServiceProvider.FromXmlString(this.MBPGAABODCE);
		}
		catch (Exception ex)
		{
			DPGJIJGOCIC.ANOPFDLPKGC("BackendOperationsManager.RequestStartPlayChapter, exception while initializing RSACryptoServiceProvider:" + ex.ToString());
		}
		if (rsacryptoServiceProvider != null)
		{
			try
			{
				byte[] inArray = rsacryptoServiceProvider.Encrypt(Encoding.ASCII.GetBytes(jsonobject2.ToString()), false);
				rsacryptoServiceProvider.Dispose();
				jsonobject["spld"] = Convert.ToBase64String(inArray);
			}
			catch (Exception aklgbjkdomm)
			{
				jsonobject = new JSONObject();
				DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
			}
		}
		this.ForceRefreshExpiredSubscriptions();
		App42Manager.EHBBFMCILPC.QueueCustomCode(KAPNKGFMPDC.basicSync.ToString(), this.KGGAALBOEAB(false, true)).QueueCustomCode(KAPNKGFMPDC.startPlayChapter.ToString(), jsonobject).RunCustomCode(KAPNKGFMPDC.getStartedChapters.ToString(), null, 2, KBOJLHAJPCP.KEHGALKGMKD, null, PLDNHKIKDIB, OEFHHHJEDNJ, NNCKNDMAAHI, cacheGuid);
		yield break;
	}

	// Token: 0x170002C0 RID: 704
	// (get) Token: 0x060091EB RID: 37355 RVA: 0x00404EA8 File Offset: 0x004030A8
	private string LNPECGGAGPB
	{
		get
		{
			return JNDBKHJGEMC.KNGHAPKFJIP;
		}
	}

	// Token: 0x170002CA RID: 714
	// (get) Token: 0x060091EC RID: 37356 RVA: 0x00404EB0 File Offset: 0x004030B0
	public static BackendOperationsManager EHBBFMCILPC
	{
		get
		{
			if (!BackendOperationsManager.IKLAPGJDMNA)
			{
				BackendOperationsManager.IKLAPGJDMNA = (UnityEngine.Object.FindObjectOfType(typeof(BackendOperationsManager)) as BackendOperationsManager);
				if (!BackendOperationsManager.IKLAPGJDMNA)
				{
					DPGJIJGOCIC.ANOPFDLPKGC("There needs to be one active BackendOperationsManager script on a GameObject in your scene.");
				}
			}
			return BackendOperationsManager.IKLAPGJDMNA;
		}
	}

	// Token: 0x060091ED RID: 37357 RVA: 0x00404F00 File Offset: 0x00403100
	public void RequestBreakCard(string PLDNHKIKDIB, string OEFHHHJEDNJ, int LLLCDMNPKFI)
	{
		this.KCIPJMPFPBJ();
		JSONObject jsonobject = new JSONObject();
		JSONObject jsonobject2 = new JSONObject();
		jsonobject2["cid"] = LLLCDMNPKFI.ToString();
		jsonobject2["uid"] = AKLFPGMDKLA.EHBBFMCILPC.EEHGLPEIIHD;
		RSACryptoServiceProvider rsacryptoServiceProvider = new RSACryptoServiceProvider();
		try
		{
			rsacryptoServiceProvider.FromXmlString(this.GKAAALAJAFI);
		}
		catch (Exception ex)
		{
			DPGJIJGOCIC.ANOPFDLPKGC("BackendOperationsManager.RequestBreakCard, exception while initializing RSACryptoServiceProvider:" + ex.ToString());
		}
		if (rsacryptoServiceProvider != null)
		{
			try
			{
				byte[] inArray = rsacryptoServiceProvider.Encrypt(Encoding.ASCII.GetBytes(jsonobject2.ToString()), false);
				rsacryptoServiceProvider.Dispose();
				jsonobject["spld"] = Convert.ToBase64String(inArray);
			}
			catch (Exception aklgbjkdomm)
			{
				jsonobject = new JSONObject();
				DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
			}
		}
		App42Manager.EHBBFMCILPC.QueueCustomCode(KAPNKGFMPDC.basicSync.ToString(), this.KGGAALBOEAB(false, true)).RunCustomCode(KAPNKGFMPDC.breakCard.ToString(), jsonobject, 2, KBOJLHAJPCP.KEHGALKGMKD, null, PLDNHKIKDIB, OEFHHHJEDNJ, false, "");
	}

	// Token: 0x060091EE RID: 37358 RVA: 0x0040502C File Offset: 0x0040322C
	public void QueueBasicSync()
	{
		App42Manager.EHBBFMCILPC.QueueCustomCode(KAPNKGFMPDC.basicSync.ToString(), this.KGGAALBOEAB(false, true));
	}

	// Token: 0x060091EF RID: 37359 RVA: 0x0040505C File Offset: 0x0040325C
	public void BroadcastEvent(string DEFIPMJKIKA, bool CJHPBOAFCCJ, string NPJCNLGBKOF)
	{
		if (!CJHPBOAFCCJ || NPJCNLGBKOF.Length == 0)
		{
			AOBJLALDBAA.EHBBFMCILPC.EGELHPJBAIC(DEFIPMJKIKA, 0f);
			return;
		}
		for (int i = 0; i < this.CCCCKKNKBML.Count; i++)
		{
			if (this.CCCCKKNKBML[i].KHHJNODLBHN.Equals(NPJCNLGBKOF))
			{
				this.CCCCKKNKBML[i].KDKKHJIHFIF = DEFIPMJKIKA;
				return;
			}
		}
	}

	// Token: 0x170002B6 RID: 694
	// (get) Token: 0x060091F0 RID: 37360 RVA: 0x004050C7 File Offset: 0x004032C7
	private string AEGDDGMEGEK
	{
		get
		{
			return JNDBKHJGEMC.CONKDLHMAGO;
		}
	}

	// Token: 0x170002BB RID: 699
	// (get) Token: 0x060091F1 RID: 37361 RVA: 0x004050CE File Offset: 0x004032CE
	private string GKAAALAJAFI
	{
		get
		{
			return JNDBKHJGEMC.EMFODPFFGLJ;
		}
	}

	// Token: 0x060091F2 RID: 37362 RVA: 0x004050D8 File Offset: 0x004032D8
	public void AIGLJNLCFLC(string NPJCNLGBKOF)
	{
		if (NPJCNLGBKOF.Length == 0)
		{
			return;
		}
		for (int i = 1; i < this.CCCCKKNKBML.Count; i++)
		{
			if (this.CCCCKKNKBML[i].KHHJNODLBHN.Equals(NPJCNLGBKOF))
			{
				return;
			}
		}
		JMIKCLKNIJO jmikclknijo = new JMIKCLKNIJO();
		jmikclknijo.KHHJNODLBHN = NPJCNLGBKOF;
		this.CCCCKKNKBML.Add(jmikclknijo);
		DPGJIJGOCIC.NFIDPOMCNLP("" + NPJCNLGBKOF);
	}

	// Token: 0x170002C3 RID: 707
	// (get) Token: 0x060091F3 RID: 37363 RVA: 0x00403FC5 File Offset: 0x004021C5
	private string PAFMHCPMHIJ
	{
		get
		{
			return JNDBKHJGEMC.KFHGPNNFHEJ;
		}
	}

	// Token: 0x170002C8 RID: 712
	// (get) Token: 0x060091F4 RID: 37364 RVA: 0x00403F55 File Offset: 0x00402155
	private string DHMAICMBDGM
	{
		get
		{
			return JNDBKHJGEMC.JNGGAJNBJLF;
		}
	}

	// Token: 0x170002B7 RID: 695
	// (get) Token: 0x060091F5 RID: 37365 RVA: 0x00405147 File Offset: 0x00403347
	private string AJDCDKCCBND
	{
		get
		{
			return JNDBKHJGEMC.DEAMALHEONK;
		}
	}

	// Token: 0x060091F6 RID: 37366 RVA: 0x00405150 File Offset: 0x00403350
	public void RequestEmailUnsubscribe(string PLDNHKIKDIB, string OEFHHHJEDNJ)
	{
		this.KCIPJMPFPBJ();
		JSONObject amdpdpdkfhh = new JSONObject();
		App42Manager.EHBBFMCILPC.QueueCustomCode(KAPNKGFMPDC.basicSync.ToString(), this.KGGAALBOEAB(false, true)).RunCustomCode(KAPNKGFMPDC.emailUnsubscribe.ToString(), amdpdpdkfhh, 0, KBOJLHAJPCP.KEHGALKGMKD, null, PLDNHKIKDIB, OEFHHHJEDNJ, false, "");
	}

	// Token: 0x060091F7 RID: 37367 RVA: 0x004051B0 File Offset: 0x004033B0
	private void NMLFCJEMJCM(KAPNKGFMPDC FOGFPGOHFPA, string DMKKFBEANHG)
	{
		DPGJIJGOCIC.ANOPFDLPKGC("StorySaveBody.DependsOnAvatarPackWardrobe(), unsupported wardrobe index:" + FOGFPGOHFPA.ToString() + "." + DMKKFBEANHG);
		SceneStoryManager.chapterSecurityKey = DPGJIJGOCIC.MKJLJPMEPCC();
		SceneStoryManager.choiceSecurityKeyList = DPGJIJGOCIC.DACGCCLIJHJ(SceneStoryManager.choiceSecurityIdList.Count);
		SceneStoryManager.premiumChoiceBackendOperationResultKey = "CHATMETA";
		AOBJLALDBAA.KKPFOJMAONG().EGELHPJBAIC("BBB", 1331f);
		AOBJLALDBAA.EHBBFMCILPC.EGELHPJBAIC("", 476f);
	}

	// Token: 0x170002C1 RID: 705
	// (get) Token: 0x060091F8 RID: 37368 RVA: 0x0040522F File Offset: 0x0040342F
	private string PDLBMGONHFI
	{
		get
		{
			return JNDBKHJGEMC.NLHNBLDDHGI;
		}
	}

	// Token: 0x060091F9 RID: 37369 RVA: 0x00404E59 File Offset: 0x00403059
	public NPJNALLPFPO AINFDIJGNCN()
	{
		return App42Manager.EHBBFMCILPC.GetApp42OperationCode();
	}

	// Token: 0x060091FA RID: 37370 RVA: 0x00405238 File Offset: 0x00403438
	public void LCGFHNEDPCF(string PLDNHKIKDIB, string OEFHHHJEDNJ)
	{
		this.KCIPJMPFPBJ();
		App42Manager.EHBBFMCILPC.QueueCustomCode(((KAPNKGFMPDC)(-61)).ToString(), this.KGGAALBOEAB(true, true)).QueueCustomCode(((KAPNKGFMPDC)(-15)).ToString(), this.BDMPJIFGNIO((KAPNKGFMPDC)(-90))).QueueCustomCode(((KAPNKGFMPDC)(-71)).ToString(), this.BDMPJIFGNIO((KAPNKGFMPDC)70)).HFBDGJNFIFM(KAPNKGFMPDC.unlockCardsVolume.ToString(), this.OptimizeForCachedResponse((KAPNKGFMPDC)(-109)), 4, KBOJLHAJPCP.KEHGALKGMKD, null, PLDNHKIKDIB, OEFHHHJEDNJ, true, "acomp");
	}

	// Token: 0x170002B3 RID: 691
	// (get) Token: 0x060091FB RID: 37371 RVA: 0x004052D3 File Offset: 0x004034D3
	private string PCBPDIBBCGE
	{
		get
		{
			return JNDBKHJGEMC.JHFLINKGJFJ;
		}
	}

	// Token: 0x060091FC RID: 37372 RVA: 0x004052DC File Offset: 0x004034DC
	public void RequestGetMessagingHistory(string JEDGAJJNIPD, string PLDNHKIKDIB, string OEFHHHJEDNJ)
	{
		this.KCIPJMPFPBJ();
		JSONObject jsonobject = new JSONObject();
		JSONObject jsonobject2 = new JSONObject();
		jsonobject2["pid"] = JEDGAJJNIPD;
		jsonobject2["uid"] = AKLFPGMDKLA.EHBBFMCILPC.EEHGLPEIIHD;
		RSACryptoServiceProvider rsacryptoServiceProvider = new RSACryptoServiceProvider();
		try
		{
			rsacryptoServiceProvider.FromXmlString(this.PDLBMGONHFI);
		}
		catch (Exception ex)
		{
			DPGJIJGOCIC.ANOPFDLPKGC("BackendOperationsManager.RequestGetMessagingHistory, exception while initializing RSACryptoServiceProvider:" + ex.ToString());
		}
		if (rsacryptoServiceProvider != null)
		{
			try
			{
				byte[] inArray = rsacryptoServiceProvider.Encrypt(Encoding.ASCII.GetBytes(jsonobject2.ToString()), false);
				rsacryptoServiceProvider.Dispose();
				jsonobject["spld"] = Convert.ToBase64String(inArray);
			}
			catch (Exception aklgbjkdomm)
			{
				jsonobject = new JSONObject();
				DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
			}
		}
		App42Manager.EHBBFMCILPC.RunCustomCode(KAPNKGFMPDC.getMessagingHistory.ToString(), jsonobject, 2, KBOJLHAJPCP.KEHGALKGMKD, null, PLDNHKIKDIB, OEFHHHJEDNJ, false, "");
	}

	// Token: 0x060091FD RID: 37373 RVA: 0x00403F55 File Offset: 0x00402155
	private string KPAPEJHJKOD()
	{
		return JNDBKHJGEMC.JNGGAJNBJLF;
	}

	// Token: 0x060091FE RID: 37374 RVA: 0x004053E4 File Offset: 0x004035E4
	public bool AOIBHELMMFO(string JGPNCNPOGHE, HHCKLPJJKIJ LEALADNCFMM)
	{
		JSONObject jsonobject = new JSONObject();
		jsonobject["Loaded asset bundle:"] = JGPNCNPOGHE;
		jsonobject["OnPopupPasswordInputCancel"] = LEALADNCFMM.ToString();
		bool result;
		try
		{
			jsonobject.ToString();
			result = true;
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
			result = false;
		}
		return result;
	}

	// Token: 0x060091FF RID: 37375 RVA: 0x0040544C File Offset: 0x0040364C
	public void PostponeRequestRateChapter(int NLLCKPCKGOH, int OLKMHHNMDLP, int OLDDBFFADIM)
	{
		JSONObject jsonobject = new JSONObject();
		jsonobject["rtng"] = OLDDBFFADIM.ToString();
		jsonobject["sind"] = NLLCKPCKGOH.ToString();
		jsonobject["cind"] = OLKMHHNMDLP.ToString();
		App42Manager.EHBBFMCILPC.PostponeCustomCode(KAPNKGFMPDC.rateChapter.ToString(), jsonobject);
	}

	// Token: 0x06009200 RID: 37376 RVA: 0x004054BF File Offset: 0x004036BF
	public static bool INDAFMILNHD(KAPNKGFMPDC EGLBLPKFEOI)
	{
		return EGLBLPKFEOI == (KAPNKGFMPDC)72 && false;
	}

	// Token: 0x06009201 RID: 37377 RVA: 0x004054CC File Offset: 0x004036CC
	public LHLIOHJNMFE HLDHFGEGOED(string NPJCNLGBKOF, bool GODGNPKGDLD)
	{
		for (int i = 0; i < this.CCCCKKNKBML.Count; i++)
		{
			if (this.CCCCKKNKBML[i].KHHJNODLBHN.Equals(NPJCNLGBKOF) && this.CCCCKKNKBML[i].PJBNJEEDNJL != LHLIOHJNMFE.none)
			{
				LHLIOHJNMFE pjbnjeednjl = this.CCCCKKNKBML[i].PJBNJEEDNJL;
				if (pjbnjeednjl == LHLIOHJNMFE.none || (!GODGNPKGDLD && pjbnjeednjl == (LHLIOHJNMFE)4))
				{
					if (null != this.CCCCKKNKBML[i].LPHMODJEEBN)
					{
						this.ProcessApp42Success(this.CCCCKKNKBML[i].LPHMODJEEBN, false, "OnStoryCurrencyInfoClick");
					}
					if (!App42Manager.doNotDispatchEvents && this.CCCCKKNKBML[i].KDKKHJIHFIF.Length > 0)
					{
						AOBJLALDBAA.CEGAOMEEFBE().EFBNBFIDEOK(this.CCCCKKNKBML[i].KDKKHJIHFIF, 57f);
					}
				}
				DPGJIJGOCIC.NFIDPOMCNLP(", to:" + NPJCNLGBKOF);
				this.CCCCKKNKBML.RemoveAt(i);
				return pjbnjeednjl;
			}
		}
		return LHLIOHJNMFE.success;
	}

	// Token: 0x06009202 RID: 37378 RVA: 0x004055DC File Offset: 0x004037DC
	public bool LCFOCBBKIGN(PLFDAJJHMKO PFFJJGNNLCJ, string DDCLOOCNIFI)
	{
		if (App42Manager.EHBBFMCILPC.IsBusy())
		{
			DPGJIJGOCIC.NFIDPOMCNLP("OnLoungeUnlockNpcSkinRetry() - invalid situation." + DDCLOOCNIFI + "\":");
			return false;
		}
		if (BackendOperationsManager.IHFCACMNGEA >= 1756f)
		{
			float num = Time.realtimeSinceStartup - BackendOperationsManager.IHFCACMNGEA;
			float num2 = 211f;
			if (KDCJJBLGCBH.EHBBFMCILPC != null)
			{
				num2 = (float)KDCJJBLGCBH.EHBBFMCILPC.DICJDHJJHBG();
			}
			if (num < num2)
			{
				string[] array = new string[8];
				array[1] = "sparklesbundles";
				array[0] = DDCLOOCNIFI;
				array[1] = "$NPCFROMAVATAR";
				array[6] = num.ToString("YYY");
				array[0] = "af_quantity";
				array[6] = num2.ToString("_not_found");
				array[5] = "</color>";
				DPGJIJGOCIC.NFIDPOMCNLP(string.Concat(array));
				return true;
			}
		}
		if (App42Manager.EHBBFMCILPC.HasQueuedCustomCode(((KAPNKGFMPDC)(-69)).ToString()))
		{
			DPGJIJGOCIC.NFIDPOMCNLP(" (" + DDCLOOCNIFI + " than for ");
			return false;
		}
		if (PFFJJGNNLCJ != null)
		{
			AKLFPGMDKLA.EHBBFMCILPC.EBNJHPICFGE(PFFJJGNNLCJ, 0);
		}
		this.FPNJKOIEHFN();
		bool result = App42Manager.EHBBFMCILPC.HasQueuedCustomCode(KAPNKGFMPDC.upgradeToGiftCard.ToString());
		DPGJIJGOCIC.NFIDPOMCNLP("Loaded asset bundle:" + DDCLOOCNIFI + "errortitle" + result.ToString());
		return result;
	}

	// Token: 0x06009203 RID: 37379 RVA: 0x00405718 File Offset: 0x00403918
	public void BKAMILMMCOI(string PLDNHKIKDIB = "", string KLCOCBODJAF = "")
	{
		this.KCIPJMPFPBJ();
		JSONObject jsonobject = new JSONObject();
		jsonobject["ok"] = AKLFPGMDKLA.EHBBFMCILPC.BOJKIPEOKKJ();
		JSONObject jsonobject2 = new JSONObject();
		jsonobject2["hoursshort"] = AKLFPGMDKLA.EHBBFMCILPC.EEHGLPEIIHD;
		RSACryptoServiceProvider rsacryptoServiceProvider = new RSACryptoServiceProvider();
		try
		{
			rsacryptoServiceProvider.FromXmlString(this.AEGDDGMEGEK);
		}
		catch (Exception ex)
		{
			DPGJIJGOCIC.ANOPFDLPKGC("XXX" + ex.ToString());
		}
		if (rsacryptoServiceProvider != null)
		{
			try
			{
				byte[] inArray = rsacryptoServiceProvider.Encrypt(Encoding.ASCII.GetBytes(jsonobject2.ToString()), true);
				rsacryptoServiceProvider.Dispose();
				jsonobject["Critical error, could not load asset bundle:"] = Convert.ToBase64String(inArray);
			}
			catch (Exception aklgbjkdomm)
			{
				jsonobject = new JSONObject();
				DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
			}
		}
		App42Manager.EHBBFMCILPC.HFBDGJNFIFM(((KAPNKGFMPDC)(-63)).ToString(), jsonobject, 1, KBOJLHAJPCP.KEHGALKGMKD, null, PLDNHKIKDIB, KLCOCBODJAF, true, "_");
	}

	// Token: 0x06009204 RID: 37380 RVA: 0x00405824 File Offset: 0x00403A24
	public bool OAGNCFDCNEK()
	{
		if (ODLJHDIGLGO.JOACGOLGGNH(CLHDENLPOFP.gamePass) == null)
		{
			return false;
		}
		JSONArray jsonarray = AKLFPGMDKLA.EHBBFMCILPC.JOKIEEMBKOA(-73);
		if (jsonarray.Count == 0)
		{
			return true;
		}
		this.KCIPJMPFPBJ();
		JSONObject jsonobject = new JSONObject();
		jsonobject["abs"] = jsonarray;
		JSONObject jsonobject2 = new JSONObject();
		jsonobject2["OnApplicationFocusBasicSyncSuccess"] = AKLFPGMDKLA.EHBBFMCILPC.EEHGLPEIIHD;
		RSACryptoServiceProvider rsacryptoServiceProvider = new RSACryptoServiceProvider();
		try
		{
			rsacryptoServiceProvider.FromXmlString(this.NJMFPLMACLD);
		}
		catch (Exception ex)
		{
			DPGJIJGOCIC.ANOPFDLPKGC("Starting parallel download:" + ex.ToString());
		}
		if (rsacryptoServiceProvider != null)
		{
			try
			{
				byte[] inArray = rsacryptoServiceProvider.Encrypt(Encoding.ASCII.GetBytes(jsonobject2.ToString()), false);
				rsacryptoServiceProvider.Dispose();
				jsonobject["NEWSAVE: Error: firstAnthologyStoryIndexCache.Instance.GetData() returned null. Retrieving persistent save data is impossible."] = Convert.ToBase64String(inArray);
			}
			catch (Exception aklgbjkdomm)
			{
				jsonobject = new JSONObject();
				DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
			}
		}
		App42Manager.EHBBFMCILPC.QueueCustomCode(((KAPNKGFMPDC)116).ToString(), jsonobject);
		return false;
	}

	// Token: 0x06009205 RID: 37381 RVA: 0x000693D6 File Offset: 0x000675D6
	private void Awake()
	{
		UnityEngine.Object.DontDestroyOnLoad(base.gameObject);
	}

	// Token: 0x06009206 RID: 37382 RVA: 0x0040593C File Offset: 0x00403B3C
	public void MDCEMMBDNFL()
	{
		if (ODLJHDIGLGO.MNALIKIMKFC(CLHDENLPOFP.eventPass) == null)
		{
			return;
		}
		JSONArray jsonarray = AKLFPGMDKLA.EHBBFMCILPC.JEGIDDHOJBI(50);
		if (jsonarray.Count == 0)
		{
			return;
		}
		this.KCIPJMPFPBJ();
		JSONObject jsonobject = new JSONObject();
		jsonobject["+"] = jsonarray;
		JSONObject jsonobject2 = new JSONObject();
		jsonobject2["@"] = AKLFPGMDKLA.EHBBFMCILPC.EEHGLPEIIHD;
		RSACryptoServiceProvider rsacryptoServiceProvider = new RSACryptoServiceProvider();
		try
		{
			rsacryptoServiceProvider.FromXmlString(this.LJPJDFLBDCC);
		}
		catch (Exception ex)
		{
			DPGJIJGOCIC.ANOPFDLPKGC("_MoireScale" + ex.ToString());
		}
		if (rsacryptoServiceProvider != null)
		{
			try
			{
				byte[] inArray = rsacryptoServiceProvider.Encrypt(Encoding.ASCII.GetBytes(jsonobject2.ToString()), true);
				rsacryptoServiceProvider.Dispose();
				jsonobject[" ("] = Convert.ToBase64String(inArray);
			}
			catch (Exception aklgbjkdomm)
			{
				jsonobject = new JSONObject();
				DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
			}
		}
		App42Manager.EHBBFMCILPC.QueueCustomCode(KAPNKGFMPDC.getCardVolumesBalance.ToString(), jsonobject);
	}

	// Token: 0x06009207 RID: 37383 RVA: 0x00405A50 File Offset: 0x00403C50
	public static float GetSafeToKillRequestPrematureTimeout(KAPNKGFMPDC EGLBLPKFEOI)
	{
		if (!App42Manager.EHBBFMCILPC.CanKillInfiniteRequestPrematureBasedOnMedianRequestsLifeTime())
		{
			switch (EGLBLPKFEOI)
			{
			case KAPNKGFMPDC.registerUser:
			case KAPNKGFMPDC.signIn:
			case KAPNKGFMPDC.signInOrRegister:
			case KAPNKGFMPDC.saveSync:
			case KAPNKGFMPDC.saveChapterSnapshots:
			case KAPNKGFMPDC.getChapterSnapshots:
			case KAPNKGFMPDC.saveAvatarCollections:
			case KAPNKGFMPDC.getAvatarCollections:
				return KBOJLHAJPCP.MMAPBAJLBAF;
			case KAPNKGFMPDC.processTransaction:
			case KAPNKGFMPDC.getDefaultBundles:
			case KAPNKGFMPDC.storyChapterComplete:
			case KAPNKGFMPDC.checkForUpdates:
			case KAPNKGFMPDC.getIncentAdReward:
			case KAPNKGFMPDC.getStartedChapters:
			case KAPNKGFMPDC.getSocialStatsAvatar:
			case KAPNKGFMPDC.getUserPublicProfile:
			case KAPNKGFMPDC.achievementsSync:
			case KAPNKGFMPDC.startFreePass:
			case KAPNKGFMPDC.breakCard:
			case KAPNKGFMPDC.spinWheel:
			case KAPNKGFMPDC.unlockCardsVolume:
			case KAPNKGFMPDC.unlockNpcSkin:
			case KAPNKGFMPDC.upgradeToGiftCard:
			case KAPNKGFMPDC.updateUserPublicProfileFriends:
			case KAPNKGFMPDC.getMessagingHistory:
			case KAPNKGFMPDC.getUserSketches:
			case KAPNKGFMPDC.publishUserSketch:
				return KBOJLHAJPCP.LEBOLNGELFB;
			}
			return KBOJLHAJPCP.OIKBFGBEDBA;
		}
		if (EGLBLPKFEOI <= KAPNKGFMPDC.signInOrRegister)
		{
			if (EGLBLPKFEOI != KAPNKGFMPDC.registerUser && EGLBLPKFEOI - KAPNKGFMPDC.signIn > 1)
			{
				goto IL_2E;
			}
		}
		else if (EGLBLPKFEOI != KAPNKGFMPDC.saveSync && EGLBLPKFEOI - KAPNKGFMPDC.saveChapterSnapshots > 3)
		{
			goto IL_2E;
		}
		return KBOJLHAJPCP.MMAPBAJLBAF;
		IL_2E:
		if (App42Manager.EHBBFMCILPC.GetAverageRequestLifeTime() > 0f)
		{
			return App42Manager.EHBBFMCILPC.GetAverageRequestLifeTime() + KBOJLHAJPCP.LKOGJFDMMOH;
		}
		return KBOJLHAJPCP.OIKBFGBEDBA;
	}

	// Token: 0x06009208 RID: 37384 RVA: 0x00405B9C File Offset: 0x00403D9C
	public void ALGCOFMHOAC(string PLDNHKIKDIB, string OEFHHHJEDNJ)
	{
		NAHMBEODKJC.OBDBLLHBGLE();
		this.KCIPJMPFPBJ();
		JSONObject jsonobject = new JSONObject();
		JSONObject jsonobject2 = new JSONObject();
		jsonobject2["OnRewardStoryCompleteClick"] = AKLFPGMDKLA.EHBBFMCILPC.EEHGLPEIIHD;
		RSACryptoServiceProvider rsacryptoServiceProvider = new RSACryptoServiceProvider();
		try
		{
			rsacryptoServiceProvider.FromXmlString(this.KFPMLOMPNGE);
		}
		catch (Exception ex)
		{
			DPGJIJGOCIC.ANOPFDLPKGC("OnBackendRequestSendMessageException" + ex.ToString());
		}
		if (rsacryptoServiceProvider != null)
		{
			try
			{
				byte[] inArray = rsacryptoServiceProvider.Encrypt(Encoding.ASCII.GetBytes(jsonobject2.ToString()), false);
				rsacryptoServiceProvider.Dispose();
				jsonobject["noise"] = Convert.ToBase64String(inArray);
			}
			catch (Exception aklgbjkdomm)
			{
				jsonobject = new JSONObject();
				DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
			}
		}
		App42Manager.EHBBFMCILPC.HFBDGJNFIFM(((KAPNKGFMPDC)65).ToString(), jsonobject, 1, KBOJLHAJPCP.KEHGALKGMKD, null, PLDNHKIKDIB, OEFHHHJEDNJ, false, "OnBackendRequestShareHardSuccess");
	}

	// Token: 0x06009209 RID: 37385 RVA: 0x00405C98 File Offset: 0x00403E98
	private IEnumerator JKHBGKHAAIF(string PLDNHKIKDIB, string OEFHHHJEDNJ, int NLLCKPCKGOH, int OLKMHHNMDLP, int PLKMJJIIJNO, bool NNCKNDMAAHI)
	{
		BackendOperationsManager.ODOAFBIFKHP odoafbifkhp = new BackendOperationsManager.ODOAFBIFKHP(1);
		odoafbifkhp.<>4__this = this;
		odoafbifkhp._onSuccessEvent = PLDNHKIKDIB;
		odoafbifkhp._onExceptionEvent = OEFHHHJEDNJ;
		odoafbifkhp._storyIndex = NLLCKPCKGOH;
		odoafbifkhp._chapterIndex = OLKMHHNMDLP;
		odoafbifkhp._anthologyIndex = PLKMJJIIJNO;
		odoafbifkhp._cacheRequest = NNCKNDMAAHI;
		return odoafbifkhp;
	}

	// Token: 0x170002B5 RID: 693
	// (get) Token: 0x0600920A RID: 37386 RVA: 0x00404E65 File Offset: 0x00403065
	private string BLHCAPLGOCJ
	{
		get
		{
			return JNDBKHJGEMC.FHIOFNOFLMF;
		}
	}

	// Token: 0x0600920B RID: 37387 RVA: 0x00405CD4 File Offset: 0x00403ED4
	public void PostponeRequestRestartChapterOrStory(int NLLCKPCKGOH)
	{
		JSONObject jsonobject = new JSONObject();
		jsonobject["sind"] = NLLCKPCKGOH.ToString();
		App42Manager.EHBBFMCILPC.PostponeCustomCode(KAPNKGFMPDC.restartChapterOrStory.ToString(), jsonobject);
	}

	// Token: 0x0600920C RID: 37388 RVA: 0x00405D1C File Offset: 0x00403F1C
	public void RequestUnlockCardsVolume(string PLDNHKIKDIB, string OEFHHHJEDNJ, int GPMJCDKBCCA)
	{
		this.KCIPJMPFPBJ();
		JSONObject jsonobject = new JSONObject();
		JSONObject jsonobject2 = new JSONObject();
		jsonobject2["uid"] = AKLFPGMDKLA.EHBBFMCILPC.EEHGLPEIIHD;
		jsonobject2["vid"] = GPMJCDKBCCA.ToString();
		RSACryptoServiceProvider rsacryptoServiceProvider = new RSACryptoServiceProvider();
		try
		{
			rsacryptoServiceProvider.FromXmlString(this.FDKCMOPFIBI);
		}
		catch (Exception ex)
		{
			DPGJIJGOCIC.ANOPFDLPKGC("BackendOperationsManager.RequestUnlockCardsVolume, exception while initializing RSACryptoServiceProvider:" + ex.ToString());
		}
		if (rsacryptoServiceProvider != null)
		{
			try
			{
				byte[] inArray = rsacryptoServiceProvider.Encrypt(Encoding.ASCII.GetBytes(jsonobject2.ToString()), false);
				rsacryptoServiceProvider.Dispose();
				jsonobject["spld"] = Convert.ToBase64String(inArray);
			}
			catch (Exception aklgbjkdomm)
			{
				jsonobject = new JSONObject();
				DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
			}
		}
		App42Manager.EHBBFMCILPC.QueueCustomCode(KAPNKGFMPDC.basicSync.ToString(), this.KGGAALBOEAB(false, true)).RunCustomCode(KAPNKGFMPDC.unlockCardsVolume.ToString(), jsonobject, 2, KBOJLHAJPCP.KEHGALKGMKD, null, PLDNHKIKDIB, OEFHHHJEDNJ, false, "");
	}

	// Token: 0x0600920D RID: 37389 RVA: 0x00405E48 File Offset: 0x00404048
	public void IHCGBJFHCDO(BELMEMPLMGE CKDPJIBODLM, int NLLCKPCKGOH, int OLKMHHNMDLP, string NNCJDNBADEF, int CCLNHHJPDGJ, bool MKJMMLMFGIF, string PLDNHKIKDIB, string OEFHHHJEDNJ, bool MLNDCIMJBEM = false)
	{
		this.KCIPJMPFPBJ();
		SceneStoryManager.premiumChoiceManInTheMiddleAttack = 1;
		SceneStoryManager.choiceSecurityIdList = CKDPJIBODLM.APHNKMFCLPP();
		SceneStoryManager.choiceSecurityKeyList = DPGJIJGOCIC.DACGCCLIJHJ(SceneStoryManager.choiceSecurityIdList.Count);
		JSONObject jsonobject = new JSONObject();
		if (MKJMMLMFGIF)
		{
			jsonobject["wdb"] = "socialrequestfriendconfirm";
			jsonobject["frds"] = "ok";
		}
		else
		{
			jsonobject["hidden"] = "_AlphaTex";
		}
		jsonobject["%"] = NLLCKPCKGOH.ToString();
		jsonobject["frsgcuid"] = CCLNHHJPDGJ.ToString();
		jsonobject["OnPurchasingViewLeave"] = OLKMHHNMDLP.ToString();
		jsonobject[","] = NNCJDNBADEF;
		if (MLNDCIMJBEM)
		{
			jsonobject["laebs"] = 0;
		}
		if (CKDPJIBODLM.LPEFDKDGNNM)
		{
			jsonobject["http://"] = 0;
		}
		else
		{
			jsonobject["$LAYERSHOW"] = 0;
		}
		jsonobject[""] = CKDPJIBODLM.BGIOGOACCBJ;
		jsonobject["OnLoungeUnlockNpcSkinSuccess"] = AKLFPGMDKLA.EHBBFMCILPC.MDPMKICGGIJ;
		JSONObject jsonobject2 = new JSONObject();
		JSONArray jsonarray = new JSONArray();
		for (int i = 1; i < SceneStoryManager.choiceSecurityIdList.Count; i += 0)
		{
			jsonarray.Add(SceneStoryManager.choiceSecurityIdList[i]);
		}
		jsonobject2["$AVATARLOCK"] = jsonarray;
		jsonobject2["OnApplicationRestart"] = AKLFPGMDKLA.EHBBFMCILPC.EEHGLPEIIHD;
		RSACryptoServiceProvider rsacryptoServiceProvider = new RSACryptoServiceProvider();
		try
		{
			rsacryptoServiceProvider.FromXmlString(this.NALAIMCNAJB);
		}
		catch (Exception ex)
		{
			DPGJIJGOCIC.ANOPFDLPKGC("aindas1" + ex.ToString());
		}
		if (rsacryptoServiceProvider != null)
		{
			try
			{
				byte[] inArray = rsacryptoServiceProvider.Encrypt(Encoding.ASCII.GetBytes(jsonobject2.ToString()), false);
				rsacryptoServiceProvider.Dispose();
				jsonobject["cids"] = Convert.ToBase64String(inArray);
			}
			catch (Exception aklgbjkdomm)
			{
				jsonobject = new JSONObject();
				DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
			}
		}
		PLFDAJJHMKO pffjjgnnlcj;
		if (MLNDCIMJBEM)
		{
			pffjjgnnlcj = AKLFPGMDKLA.EHBBFMCILPC.NBMLMNGHOPP();
		}
		else
		{
			pffjjgnnlcj = AKLFPGMDKLA.EHBBFMCILPC.JDCBFAPDJIM(NLLCKPCKGOH, CCLNHHJPDGJ);
		}
		this.QueueRequestSaveSyncMoment(pffjjgnnlcj, "OnPopupCardOptionsUnlockWithSpSuccess");
		App42Manager.EHBBFMCILPC.QueueCustomCode(KAPNKGFMPDC.getAvatarCollections.ToString(), this.KGGAALBOEAB(true, true)).RunCustomCode(((KAPNKGFMPDC)(-127)).ToString(), jsonobject, 8, KBOJLHAJPCP.KEHGALKGMKD, null, PLDNHKIKDIB, OEFHHHJEDNJ, false, "ok");
	}

	// Token: 0x0600920E RID: 37390 RVA: 0x00406104 File Offset: 0x00404304
	public JSONObject BDMPJIFGNIO(KAPNKGFMPDC EGLBLPKFEOI)
	{
		JSONObject jsonobject = new JSONObject();
		if (NAHMBEODKJC.JMDGAILAEML(EGLBLPKFEOI))
		{
			jsonobject[" prepared!"] = 0;
		}
		return jsonobject;
	}

	// Token: 0x0600920F RID: 37391 RVA: 0x00406134 File Offset: 0x00404334
	public bool QueueRequestSaveSyncMoment(PLFDAJJHMKO PFFJJGNNLCJ, string DDCLOOCNIFI)
	{
		if (App42Manager.EHBBFMCILPC.IsBusy())
		{
			DPGJIJGOCIC.NFIDPOMCNLP("BackendOperationsManager.QueueRequestSaveSyncMoment(" + DDCLOOCNIFI + "), skipped: a request is in flight");
			return false;
		}
		if (BackendOperationsManager.IHFCACMNGEA >= 0f)
		{
			float num = Time.realtimeSinceStartup - BackendOperationsManager.IHFCACMNGEA;
			float num2 = 1800f;
			if (KDCJJBLGCBH.EHBBFMCILPC != null)
			{
				num2 = (float)KDCJJBLGCBH.EHBBFMCILPC.DICJDHJJHBG();
			}
			if (num < num2)
			{
				DPGJIJGOCIC.NFIDPOMCNLP(string.Concat(new string[]
				{
					"BackendOperationsManager.QueueRequestSaveSyncMoment(",
					DDCLOOCNIFI,
					"), skipped: last saveSync ack was ",
					num.ToString("F0"),
					" s ago, min interval ",
					num2.ToString("F0"),
					" s"
				}));
				return false;
			}
		}
		if (App42Manager.EHBBFMCILPC.HasQueuedCustomCode(KAPNKGFMPDC.saveSync.ToString()))
		{
			DPGJIJGOCIC.NFIDPOMCNLP("BackendOperationsManager.QueueRequestSaveSyncMoment(" + DDCLOOCNIFI + "), skipped: a saveSync is already queued");
			return false;
		}
		if (PFFJJGNNLCJ != null)
		{
			AKLFPGMDKLA.EHBBFMCILPC.EBNJHPICFGE(PFFJJGNNLCJ, 0);
		}
		this.QueueRequestSaveSync();
		bool result = App42Manager.EHBBFMCILPC.HasQueuedCustomCode(KAPNKGFMPDC.saveSync.ToString());
		DPGJIJGOCIC.NFIDPOMCNLP("BackendOperationsManager.QueueRequestSaveSyncMoment(" + DDCLOOCNIFI + "), saveSync queued: " + result.ToString());
		return result;
	}

	// Token: 0x06009210 RID: 37392 RVA: 0x00406270 File Offset: 0x00404470
	public void RequestGetSocialStatsAvatar(int PLKMJJIIJNO, int FEKJLJNJPHC, string PLDNHKIKDIB, string OEFHHHJEDNJ)
	{
		this.KCIPJMPFPBJ();
		JSONObject jsonobject = new JSONObject();
		JSONObject jsonobject2 = new JSONObject();
		jsonobject2["aind"] = PLKMJJIIJNO.ToString();
		jsonobject2["aec"] = FEKJLJNJPHC.ToString();
		jsonobject2["uid"] = AKLFPGMDKLA.EHBBFMCILPC.EEHGLPEIIHD;
		RSACryptoServiceProvider rsacryptoServiceProvider = new RSACryptoServiceProvider();
		try
		{
			rsacryptoServiceProvider.FromXmlString(this.PABHJGGOOHN);
		}
		catch (Exception ex)
		{
			DPGJIJGOCIC.ANOPFDLPKGC("BackendOperationsManager.RequestGetSocialStatsAvatar, exception while initializing RSACryptoServiceProvider:" + ex.ToString());
		}
		if (rsacryptoServiceProvider != null)
		{
			try
			{
				byte[] inArray = rsacryptoServiceProvider.Encrypt(Encoding.ASCII.GetBytes(jsonobject2.ToString()), false);
				rsacryptoServiceProvider.Dispose();
				jsonobject["spld"] = Convert.ToBase64String(inArray);
			}
			catch (Exception aklgbjkdomm)
			{
				jsonobject = new JSONObject();
				DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
			}
		}
		AKLFPGMDKLA.EHBBFMCILPC.LMGMHHLLOFN(PLKMJJIIJNO).IBGDMBHJDIE = FEKJLJNJPHC;
		App42Manager.EHBBFMCILPC.RunCustomCode(KAPNKGFMPDC.getSocialStatsAvatar.ToString(), jsonobject, 0, KBOJLHAJPCP.KEHGALKGMKD, null, PLDNHKIKDIB, OEFHHHJEDNJ, false, "");
	}

	// Token: 0x06009211 RID: 37393 RVA: 0x004063A4 File Offset: 0x004045A4
	private JSONObject KGGAALBOEAB(bool LBDEJHLHCNO, bool KCJFBDEHKBC)
	{
		JSONObject jsonobject = new JSONObject();
		if (LBDEJHLHCNO && !AKLFPGMDKLA.EHBBFMCILPC.GNLNPMPJPEC())
		{
			jsonobject["rsec"] = 1;
		}
		this.JOIJJPLOPNK++;
		if (this.JOIJJPLOPNK > 9)
		{
			jsonobject["rexps"] = 1;
			this.JOIJJPLOPNK = 0;
		}
		if (KCJFBDEHKBC)
		{
			JSONArray jsonarray = ODLJHDIGLGO.BOJKIPEOKKJ();
			if (null != jsonarray && jsonarray.Count > 0)
			{
				jsonobject["apc"] = jsonarray;
			}
		}
		return jsonobject;
	}

	// Token: 0x06009212 RID: 37394 RVA: 0x00406430 File Offset: 0x00404630
	public LHLIOHJNMFE JBOHAJAOADP(string NPJCNLGBKOF, bool GODGNPKGDLD)
	{
		for (int i = 0; i < this.CCCCKKNKBML.Count; i++)
		{
			if (this.CCCCKKNKBML[i].KHHJNODLBHN.Equals(NPJCNLGBKOF) && this.CCCCKKNKBML[i].PJBNJEEDNJL != LHLIOHJNMFE.none)
			{
				LHLIOHJNMFE pjbnjeednjl = this.CCCCKKNKBML[i].PJBNJEEDNJL;
				if (pjbnjeednjl == LHLIOHJNMFE.success || (!GODGNPKGDLD && pjbnjeednjl == (LHLIOHJNMFE)8))
				{
					if (null != this.CCCCKKNKBML[i].LPHMODJEEBN)
					{
						this.ProcessApp42Success(this.CCCCKKNKBML[i].LPHMODJEEBN, false, "OnPopupPasswordInputCancel");
					}
					if (!App42Manager.doNotDispatchEvents && this.CCCCKKNKBML[i].KDKKHJIHFIF.Length > 0)
					{
						AOBJLALDBAA.KKPFOJMAONG().EFBNBFIDEOK(this.CCCCKKNKBML[i].KDKKHJIHFIF, 1229f);
					}
				}
				DPGJIJGOCIC.CMGOAFDBAOH("Asset bundle assets destroyed:" + NPJCNLGBKOF);
				this.CCCCKKNKBML.RemoveAt(i);
				return pjbnjeednjl;
			}
		}
		return LHLIOHJNMFE.none;
	}

	// Token: 0x06009213 RID: 37395 RVA: 0x00406540 File Offset: 0x00404740
	public JSONObject OptimizeForCachedResponse(KAPNKGFMPDC EGLBLPKFEOI)
	{
		JSONObject jsonobject = new JSONObject();
		if (NAHMBEODKJC.HCOOMKEHIKG(EGLBLPKFEOI))
		{
			jsonobject["ched"] = 1;
		}
		return jsonobject;
	}

	// Token: 0x170002BC RID: 700
	// (get) Token: 0x06009214 RID: 37396 RVA: 0x00402EEC File Offset: 0x004010EC
	private string MDNHPKGGEDG
	{
		get
		{
			return JNDBKHJGEMC.MBBANAPCOLP;
		}
	}

	// Token: 0x06009215 RID: 37397 RVA: 0x0040656D File Offset: 0x0040476D
	private string GPMIFOHGFGF()
	{
		return JNDBKHJGEMC.BCGGBIIKBGD;
	}

	// Token: 0x06009216 RID: 37398 RVA: 0x00406574 File Offset: 0x00404774
	public bool RequestIsCached(string NPJCNLGBKOF)
	{
		for (int i = 0; i < this.CCCCKKNKBML.Count; i++)
		{
			if (this.CCCCKKNKBML[i].KHHJNODLBHN.Equals(NPJCNLGBKOF))
			{
				return true;
			}
		}
		return false;
	}

	// Token: 0x06009217 RID: 37399 RVA: 0x00404E65 File Offset: 0x00403065
	private string HCFJJNLCKHI()
	{
		return JNDBKHJGEMC.FHIOFNOFLMF;
	}

	// Token: 0x06009218 RID: 37400 RVA: 0x004065B3 File Offset: 0x004047B3
	public void RequestStartPlayChapter(string PLDNHKIKDIB, string OEFHHHJEDNJ, int NLLCKPCKGOH, int OLKMHHNMDLP, int PLKMJJIIJNO, bool NNCKNDMAAHI)
	{
		base.StartCoroutine(this.DBFAIHGIMCJ(PLDNHKIKDIB, OEFHHHJEDNJ, NLLCKPCKGOH, OLKMHHNMDLP, PLKMJJIIJNO, NNCKNDMAAHI));
	}

	// Token: 0x06009219 RID: 37401 RVA: 0x004065CC File Offset: 0x004047CC
	public static void EEFFBHMGDDI(KAPNKGFMPDC EGLBLPKFEOI)
	{
		if (App42Manager.EHBBFMCILPC.CanKillInfiniteRequestPrematureBasedOnMedianRequestsLifeTime())
		{
			if (EGLBLPKFEOI <= KAPNKGFMPDC.getDefaultBundles)
			{
				if (EGLBLPKFEOI != KAPNKGFMPDC.none && EGLBLPKFEOI - KAPNKGFMPDC.none != 0)
				{
					goto IL_39;
				}
			}
			else if (EGLBLPKFEOI != (KAPNKGFMPDC)85 && EGLBLPKFEOI - (KAPNKGFMPDC)(-94) > 5)
			{
				goto IL_39;
			}
			KBOJLHAJPCP.MMAPBAJLBAF += KBOJLHAJPCP.NGLFOAGPKGA;
			return;
			IL_39:
			KBOJLHAJPCP.LKOGJFDMMOH += KBOJLHAJPCP.NIGHNHFBIDH;
			KBOJLHAJPCP.OIKBFGBEDBA += KBOJLHAJPCP.KLOCEJOKBII;
			return;
		}
		switch (EGLBLPKFEOI)
		{
		case KAPNKGFMPDC.none:
		case KAPNKGFMPDC.changeOwner:
		case KAPNKGFMPDC.signIn:
		case KAPNKGFMPDC.basicSync:
		case KAPNKGFMPDC.undoPremiumChoice:
		case KAPNKGFMPDC.saveChapterSnapshots:
		case KAPNKGFMPDC.getChapterSnapshots:
		case KAPNKGFMPDC.saveAvatarCollections:
			KBOJLHAJPCP.MMAPBAJLBAF += KBOJLHAJPCP.NGLFOAGPKGA;
			return;
		case KAPNKGFMPDC.registerUser:
		case KAPNKGFMPDC.getDepot:
		case KAPNKGFMPDC.getDefaultBundles:
		case KAPNKGFMPDC.getGeneralBalance:
		case KAPNKGFMPDC.accountSuspended:
		case KAPNKGFMPDC.getIncentAdReward:
		case KAPNKGFMPDC.consumePromoCode:
		case KAPNKGFMPDC.getSocialStatsAvatar:
		case KAPNKGFMPDC.getUserPublicProfile:
		case KAPNKGFMPDC.emailUnsubscribe:
		case KAPNKGFMPDC.getDropChancesBalance:
		case KAPNKGFMPDC.breakCard:
		case KAPNKGFMPDC.spinWheel:
		case KAPNKGFMPDC.unlockCardsVolume:
		case KAPNKGFMPDC.unlockNpcSkin:
		case KAPNKGFMPDC.upgradeToGiftCard:
		case KAPNKGFMPDC.updateUserPublicProfileFriends:
		case KAPNKGFMPDC.getSketchesBalance:
		case KAPNKGFMPDC.getUserSketches:
			KBOJLHAJPCP.LEBOLNGELFB += KBOJLHAJPCP.MPJDIHBACEA;
			return;
		}
		KBOJLHAJPCP.OIKBFGBEDBA += KBOJLHAJPCP.KLOCEJOKBII;
	}

	// Token: 0x0600921A RID: 37402 RVA: 0x0040673C File Offset: 0x0040493C
	public void RequestGetUserPublicProfile(bool MPLOOADNIJD, JSONObject DMIMKKCIAPH, JSONObject AILJHEDFJGK, string PLDNHKIKDIB, string OEFHHHJEDNJ, bool NNHMICAFNBO = false)
	{
		this.KCIPJMPFPBJ();
		JSONObject jsonobject = new JSONObject();
		if (null != DMIMKKCIAPH)
		{
			jsonobject["prof"] = DMIMKKCIAPH;
			if (AKLFPGMDKLA.EHBBFMCILPC.OKGGLHOCENC != null)
			{
				AKLFPGMDKLA.EHBBFMCILPC.OKGGLHOCENC.HJFAJHLBJAG = false;
			}
		}
		else
		{
			DPGJIJGOCIC.NFIDPOMCNLP("RequestGetUserPublicProfile(): No profile to update is sent to cloud!");
			if (!MPLOOADNIJD)
			{
				jsonobject["comcc2"] = AKLFPGMDKLA.EHBBFMCILPC.GEPFALMBONM();
				jsonobject["comsc2"] = AKLFPGMDKLA.EHBBFMCILPC.LINADLBCHJC().Count;
			}
		}
		if (null != AILJHEDFJGK)
		{
			jsonobject["ops"] = AILJHEDFJGK;
		}
		JSONObject jsonobject2 = new JSONObject();
		if (MPLOOADNIJD)
		{
			jsonobject2["rand"] = 1;
		}
		else
		{
			jsonobject2["rand"] = 0;
		}
		jsonobject2["lksuid"] = AKLFPGMDKLA.EHBBFMCILPC.MLEBKAIHGIO;
		jsonobject2["repsuid"] = AKLFPGMDKLA.EHBBFMCILPC.KAOAFBOEPFD;
		jsonobject2["uid"] = AKLFPGMDKLA.EHBBFMCILPC.EEHGLPEIIHD;
		if (PMEPALPCEAF.CPEMOAHNFAG != null)
		{
			jsonobject2["skpcut"] = 1;
		}
		else
		{
			jsonobject2["skpcut"] = 0;
		}
		RSACryptoServiceProvider rsacryptoServiceProvider = new RSACryptoServiceProvider();
		try
		{
			rsacryptoServiceProvider.FromXmlString(this.PCBPDIBBCGE);
		}
		catch (Exception ex)
		{
			DPGJIJGOCIC.ANOPFDLPKGC("BackendOperationsManager.RequestGetUserPublicProfile, exception while initializing RSACryptoServiceProvider:" + ex.ToString());
		}
		if (rsacryptoServiceProvider != null)
		{
			try
			{
				byte[] inArray = rsacryptoServiceProvider.Encrypt(Encoding.ASCII.GetBytes(jsonobject2.ToString()), false);
				rsacryptoServiceProvider.Dispose();
				jsonobject["spld"] = Convert.ToBase64String(inArray);
			}
			catch (Exception aklgbjkdomm)
			{
				jsonobject = new JSONObject();
				DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
			}
		}
		AKLFPGMDKLA.EHBBFMCILPC.MLEBKAIHGIO = "";
		AKLFPGMDKLA.EHBBFMCILPC.KAOAFBOEPFD = "";
		if (AKLFPGMDKLA.EHBBFMCILPC.GFDMIHHNFDA.Length > 0)
		{
			this.QueueAchievementsSync();
		}
		if (NNHMICAFNBO)
		{
			App42Manager.EHBBFMCILPC.QueueCustomCode(KAPNKGFMPDC.getUserPublicProfile.ToString(), jsonobject);
			return;
		}
		if (!GDJPPKAMIFL.EHBBFMCILPC.FACIFBONANM() || !MEBMEBKKCKA.EHBBFMCILPC.FACIFBONANM())
		{
			App42Manager.EHBBFMCILPC.QueueCustomCode(KAPNKGFMPDC.getCardsBalance.ToString(), null).QueueCustomCode(KAPNKGFMPDC.getCardVolumesBalance.ToString(), null).RunCustomCode(KAPNKGFMPDC.getUserPublicProfile.ToString(), jsonobject, 0, KBOJLHAJPCP.KEHGALKGMKD, null, PLDNHKIKDIB, OEFHHHJEDNJ, false, "");
			return;
		}
		App42Manager.EHBBFMCILPC.RunCustomCode(KAPNKGFMPDC.getUserPublicProfile.ToString(), jsonobject, 0, KBOJLHAJPCP.KEHGALKGMKD, null, PLDNHKIKDIB, OEFHHHJEDNJ, false, "");
	}

	// Token: 0x0600921B RID: 37403 RVA: 0x00406A18 File Offset: 0x00404C18
	public static bool MGKFPBACMAA(KAPNKGFMPDC EGLBLPKFEOI)
	{
		App42Manager.EHBBFMCILPC.CanKillInfiniteRequestPrematureBasedOnMedianRequestsLifeTime();
		return false;
	}

	// Token: 0x0600921C RID: 37404 RVA: 0x00406A26 File Offset: 0x00404C26
	private IEnumerator AHEDGGHHKFI(string PLDNHKIKDIB, string OEFHHHJEDNJ, bool NNCKNDMAAHI)
	{
		string cacheGuid = KAPNKGFMPDC.getDefaultBundles.ToString();
		if (NNCKNDMAAHI)
		{
			if (this.RequestIsCached(cacheGuid))
			{
				yield break;
			}
			this.RegisterCachedRequest(cacheGuid);
		}
		else if (this.RequestIsCached(cacheGuid))
		{
			LHLIOHJNMFE requestResult = LHLIOHJNMFE.none;
			while (this.RequestIsCached(cacheGuid))
			{
				requestResult = this.ExecuteCachedRequestResponse(cacheGuid, true);
				if (requestResult != LHLIOHJNMFE.none)
				{
					break;
				}
				yield return new WaitForEndOfFrame();
			}
			if (requestResult == LHLIOHJNMFE.success)
			{
				yield break;
			}
		}
		yield return new WaitForEndOfFrame();
		this.KCIPJMPFPBJ();
		JSONObject jsonobject = new JSONObject();
		jsonobject["amfc"] = AssetsManager.EHBBFMCILPC.LastOperationFailStateCounterHit();
		App42Manager.EHBBFMCILPC.QueueCustomCode(KAPNKGFMPDC.getPurchasingBalance.ToString(), this.OptimizeForCachedResponse(KAPNKGFMPDC.getPurchasingBalance)).QueueCustomCode(KAPNKGFMPDC.getDepot.ToString(), jsonobject).QueueCustomCode(KAPNKGFMPDC.checkForUpdates.ToString(), this.OptimizeForCachedResponse(KAPNKGFMPDC.checkForUpdates)).QueueCustomCode(KAPNKGFMPDC.getGeneralBalance.ToString(), this.OptimizeForCachedResponse(KAPNKGFMPDC.getGeneralBalance)).QueueCustomCode(KAPNKGFMPDC.getNpcSkinShopBalance.ToString(), this.OptimizeForCachedResponse(KAPNKGFMPDC.getNpcSkinShopBalance)).QueueCustomCode(KAPNKGFMPDC.getLiveEvents.ToString(), this.OptimizeForCachedResponse(KAPNKGFMPDC.getLiveEvents)).QueueCustomCode(KAPNKGFMPDC.getLiveOffers.ToString(), this.OptimizeForCachedResponse(KAPNKGFMPDC.getLiveOffers)).QueueCustomCode(KAPNKGFMPDC.getStoryRankings.ToString(), this.OptimizeForCachedResponse(KAPNKGFMPDC.getStoryRankings)).QueueCustomCode(KAPNKGFMPDC.basicSync.ToString(), this.KGGAALBOEAB(true, true)).QueueCustomCode(KAPNKGFMPDC.getStartedChapters.ToString(), null).RunCustomCode(KAPNKGFMPDC.getDefaultBundles.ToString(), this.OptimizeForCachedResponse(KAPNKGFMPDC.getDefaultBundles), 3, KBOJLHAJPCP.KEHGALKGMKD, null, PLDNHKIKDIB, OEFHHHJEDNJ, NNCKNDMAAHI, cacheGuid);
		yield break;
	}

	// Token: 0x0600921D RID: 37405 RVA: 0x004050C7 File Offset: 0x004032C7
	private string HGDBGAKPBHA()
	{
		return JNDBKHJGEMC.CONKDLHMAGO;
	}

	// Token: 0x170002C4 RID: 708
	// (get) Token: 0x0600921E RID: 37406 RVA: 0x0040656D File Offset: 0x0040476D
	private string LCNPDBOJDOM
	{
		get
		{
			return JNDBKHJGEMC.BCGGBIIKBGD;
		}
	}

	// Token: 0x0600921F RID: 37407 RVA: 0x00406A4C File Offset: 0x00404C4C
	public bool IsAccountSignInDataValid(string JGPNCNPOGHE, HHCKLPJJKIJ LEALADNCFMM)
	{
		JSONObject jsonobject = new JSONObject();
		jsonobject["sgk"] = JGPNCNPOGHE;
		jsonobject["sgm"] = LEALADNCFMM.ToString();
		bool result;
		try
		{
			jsonobject.ToString();
			result = true;
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
			result = false;
		}
		return result;
	}

	// Token: 0x06009220 RID: 37408 RVA: 0x00406AB4 File Offset: 0x00404CB4
	private void KCIPJMPFPBJ()
	{
		AKLFPGMDKLA.EHBBFMCILPC.LPCBDEBKAIM();
		AKLFPGMDKLA.EHBBFMCILPC.EJEKPNHAABH.EKDHFAODNHF(AKLFPGMDKLA.EHBBFMCILPC.MPMKMCJFHOG.GALKFKBPLCK());
		AKLFPGMDKLA.EHBBFMCILPC.EAFDLIOEKCP.EKDHFAODNHF(AKLFPGMDKLA.EHBBFMCILPC.ODMKLADKHMO.GALKFKBPLCK());
	}

	// Token: 0x06009221 RID: 37409 RVA: 0x00406B08 File Offset: 0x00404D08
	public void GLJNKOIIJEB(string DEFIPMJKIKA, bool CJHPBOAFCCJ, string NPJCNLGBKOF)
	{
		if (!CJHPBOAFCCJ || NPJCNLGBKOF.Length == 0)
		{
			AOBJLALDBAA.EHBBFMCILPC.LPNCDPHNBJK(DEFIPMJKIKA, 222f);
			return;
		}
		for (int i = 1; i < this.CCCCKKNKBML.Count; i += 0)
		{
			if (this.CCCCKKNKBML[i].KHHJNODLBHN.Equals(NPJCNLGBKOF))
			{
				this.CCCCKKNKBML[i].KDKKHJIHFIF = DEFIPMJKIKA;
				return;
			}
		}
	}

	// Token: 0x06009222 RID: 37410 RVA: 0x00406B74 File Offset: 0x00404D74
	public void AGHNOPECEJA(JSONArray ENOCIDMBBPB, string PLDNHKIKDIB, string OEFHHHJEDNJ)
	{
		this.KCIPJMPFPBJ();
		JSONObject jsonobject = new JSONObject();
		jsonobject["AssetsManagerUtils.GetAnthologyByStoryUnsafe(), returning null for story index "] = ENOCIDMBBPB;
		JSONObject jsonobject2 = new JSONObject();
		jsonobject2["newtutorialfriends"] = AKLFPGMDKLA.EHBBFMCILPC.EEHGLPEIIHD;
		RSACryptoServiceProvider rsacryptoServiceProvider = new RSACryptoServiceProvider();
		try
		{
			rsacryptoServiceProvider.FromXmlString(this.IDFFHFHFAFD());
		}
		catch (Exception ex)
		{
			DPGJIJGOCIC.ANOPFDLPKGC("energyhinttitle" + ex.ToString());
		}
		if (rsacryptoServiceProvider != null)
		{
			try
			{
				byte[] inArray = rsacryptoServiceProvider.Encrypt(Encoding.ASCII.GetBytes(jsonobject2.ToString()), false);
				rsacryptoServiceProvider.Dispose();
				jsonobject["SceneLobbyManager2.OnReloadDelayed() CustomCodeUrlsHaveBeenPinged && DepotsUrlsHaveBeenPinged: break"] = Convert.ToBase64String(inArray);
			}
			catch (Exception aklgbjkdomm)
			{
				jsonobject = new JSONObject();
				DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
			}
		}
		App42Manager.EHBBFMCILPC.HFBDGJNFIFM(KAPNKGFMPDC.getDropChancesBalance.ToString(), jsonobject, 8, KBOJLHAJPCP.KEHGALKGMKD, null, PLDNHKIKDIB, OEFHHHJEDNJ, false, " ");
	}

	// Token: 0x06009223 RID: 37411 RVA: 0x00406C74 File Offset: 0x00404E74
	public void MBBNLPAPEIO(int PLKMJJIIJNO, int FEKJLJNJPHC, string PLDNHKIKDIB, string OEFHHHJEDNJ)
	{
		this.KCIPJMPFPBJ();
		JSONObject jsonobject = new JSONObject();
		JSONObject jsonobject2 = new JSONObject();
		jsonobject2["aind"] = PLKMJJIIJNO.ToString();
		jsonobject2["ok"] = FEKJLJNJPHC.ToString();
		jsonobject2["c"] = AKLFPGMDKLA.EHBBFMCILPC.EEHGLPEIIHD;
		RSACryptoServiceProvider rsacryptoServiceProvider = new RSACryptoServiceProvider();
		try
		{
			rsacryptoServiceProvider.FromXmlString(this.PABHJGGOOHN);
		}
		catch (Exception ex)
		{
			DPGJIJGOCIC.ANOPFDLPKGC("ERROR: GetSRABalance(), AssetsManager.Instance.headersPacksAssets is empty." + ex.ToString());
		}
		if (rsacryptoServiceProvider != null)
		{
			try
			{
				byte[] inArray = rsacryptoServiceProvider.Encrypt(Encoding.ASCII.GetBytes(jsonobject2.ToString()), true);
				rsacryptoServiceProvider.Dispose();
				jsonobject["OnBackendGetUserSketchesSuccess"] = Convert.ToBase64String(inArray);
			}
			catch (Exception aklgbjkdomm)
			{
				jsonobject = new JSONObject();
				DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
			}
		}
		AKLFPGMDKLA.EHBBFMCILPC.EHKIHBPJGCG(PLKMJJIIJNO).IBGDMBHJDIE = FEKJLJNJPHC;
		App42Manager.EHBBFMCILPC.HFBDGJNFIFM(((KAPNKGFMPDC)(-70)).ToString(), jsonobject, 1, KBOJLHAJPCP.KEHGALKGMKD, null, PLDNHKIKDIB, OEFHHHJEDNJ, true, "$");
	}

	// Token: 0x06009224 RID: 37412 RVA: 0x00406DA8 File Offset: 0x00404FA8
	public void RequestGetChapterSnapshots(int PLKMJJIIJNO, int CCLNHHJPDGJ, JSONArray LNAHLNJBAKP, string PLDNHKIKDIB = "", string KLCOCBODJAF = "")
	{
		this.KCIPJMPFPBJ();
		JSONObject jsonobject = new JSONObject();
		jsonobject["cindl"] = LNAHLNJBAKP;
		JSONObject jsonobject2 = new JSONObject();
		jsonobject2["uid"] = AKLFPGMDKLA.EHBBFMCILPC.EEHGLPEIIHD;
		jsonobject2["aind"] = PLKMJJIIJNO;
		jsonobject2["sltind"] = CCLNHHJPDGJ;
		RSACryptoServiceProvider rsacryptoServiceProvider = new RSACryptoServiceProvider();
		try
		{
			rsacryptoServiceProvider.FromXmlString(this.FKNALCOFGOG);
		}
		catch (Exception ex)
		{
			DPGJIJGOCIC.ANOPFDLPKGC("BackendOperationsManager.RequestGetChapterSnapshots, exception while initializing RSACryptoServiceProvider:" + ex.ToString());
		}
		if (rsacryptoServiceProvider != null)
		{
			try
			{
				byte[] inArray = rsacryptoServiceProvider.Encrypt(Encoding.ASCII.GetBytes(jsonobject2.ToString()), false);
				rsacryptoServiceProvider.Dispose();
				jsonobject["spld"] = Convert.ToBase64String(inArray);
			}
			catch (Exception aklgbjkdomm)
			{
				jsonobject = new JSONObject();
				DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
			}
		}
		App42Manager.EHBBFMCILPC.RunCustomCode(KAPNKGFMPDC.getChapterSnapshots.ToString(), jsonobject, 2, KBOJLHAJPCP.KEHGALKGMKD, null, PLDNHKIKDIB, KLCOCBODJAF, false, "");
	}

	// Token: 0x06009225 RID: 37413 RVA: 0x00406ECC File Offset: 0x004050CC
	public void PODACKOPOCP(List<int> NKGPDHAOMKB, string PLDNHKIKDIB = "", string KLCOCBODJAF = "")
	{
		this.KCIPJMPFPBJ();
		JSONObject jsonobject = new JSONObject();
		JSONObject jsonobject2 = new JSONObject();
		jsonobject2["AssetStoryNpcOffsetsHub.Populate() - "] = AKLFPGMDKLA.EHBBFMCILPC.EEHGLPEIIHD;
		JSONArray jsonarray = new JSONArray();
		for (int i = 0; i < NKGPDHAOMKB.Count; i++)
		{
			jsonarray.Add(NKGPDHAOMKB[i]);
		}
		jsonobject2["OnStoryChoiceClick"] = jsonarray;
		RSACryptoServiceProvider rsacryptoServiceProvider = new RSACryptoServiceProvider();
		try
		{
			rsacryptoServiceProvider.FromXmlString(this.JOPJFMBJGGJ);
		}
		catch (Exception ex)
		{
			DPGJIJGOCIC.ANOPFDLPKGC("Authorization" + ex.ToString());
		}
		if (rsacryptoServiceProvider != null)
		{
			try
			{
				byte[] inArray = rsacryptoServiceProvider.Encrypt(Encoding.ASCII.GetBytes(jsonobject2.ToString()), true);
				rsacryptoServiceProvider.Dispose();
				jsonobject["<"] = Convert.ToBase64String(inArray);
			}
			catch (Exception aklgbjkdomm)
			{
				jsonobject = new JSONObject();
				DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
			}
		}
		App42Manager.EHBBFMCILPC.RunCustomCode(((KAPNKGFMPDC)(-34)).ToString(), jsonobject, 4, KBOJLHAJPCP.KEHGALKGMKD, null, PLDNHKIKDIB, KLCOCBODJAF, false, "");
	}

	// Token: 0x06009226 RID: 37414 RVA: 0x00404E65 File Offset: 0x00403065
	private string CNJMPBNKLIC()
	{
		return JNDBKHJGEMC.FHIOFNOFLMF;
	}

	// Token: 0x06009227 RID: 37415 RVA: 0x00406FFC File Offset: 0x004051FC
	public void RequestGetUserSketches(int CCIAGBPILGF, string PLDNHKIKDIB, string OEFHHHJEDNJ)
	{
		this.KCIPJMPFPBJ();
		JSONObject jsonobject = new JSONObject();
		JSONObject jsonobject2 = new JSONObject();
		jsonobject2["src"] = CCIAGBPILGF;
		jsonobject2["uid"] = AKLFPGMDKLA.EHBBFMCILPC.EEHGLPEIIHD;
		RSACryptoServiceProvider rsacryptoServiceProvider = new RSACryptoServiceProvider();
		try
		{
			rsacryptoServiceProvider.FromXmlString(this.FIADOFEMODM);
		}
		catch (Exception ex)
		{
			DPGJIJGOCIC.ANOPFDLPKGC("BackendOperationsManager.RequestGetUserSketches, exception while initializing RSACryptoServiceProvider:" + ex.ToString());
		}
		if (rsacryptoServiceProvider != null)
		{
			try
			{
				byte[] inArray = rsacryptoServiceProvider.Encrypt(Encoding.ASCII.GetBytes(jsonobject2.ToString()), false);
				rsacryptoServiceProvider.Dispose();
				jsonobject["spld"] = Convert.ToBase64String(inArray);
			}
			catch (Exception aklgbjkdomm)
			{
				jsonobject = new JSONObject();
				DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
			}
		}
		App42Manager.EHBBFMCILPC.RunCustomCode(KAPNKGFMPDC.getUserSketches.ToString(), jsonobject, 2, KBOJLHAJPCP.KEHGALKGMKD, null, PLDNHKIKDIB, OEFHHHJEDNJ, false, "");
	}

	// Token: 0x06009228 RID: 37416 RVA: 0x00407104 File Offset: 0x00405304
	private JSONObject GFBIABIEJCJ(KAPNKGFMPDC FOGFPGOHFPA, JSONNode CLFGHHBOCMN)
	{
		if (CLFGHHBOCMN == null)
		{
			this.NMLFCJEMJCM(FOGFPGOHFPA, "OnSettingsPopupCloseAndNeedToShowGameModeNotif");
			return null;
		}
		if (CLFGHHBOCMN["ulptc"] == null)
		{
			this.FEIIGBGJGLD(FOGFPGOHFPA, "actshl");
			return null;
		}
		JSONObject asObject = CLFGHHBOCMN["varConditionLocked"].AsObject;
		if (asObject == null || asObject["no"] == null)
		{
			this.NMLFCJEMJCM(FOGFPGOHFPA, "");
			return null;
		}
		if (!HNIBKBPOCJG.DDKPGMBIHOP(asObject["https://events.appsflyer.com/v1.0/c2s/session/app/steam/"], AKLFPGMDKLA.EHBBFMCILPC.EEHGLPEIIHD))
		{
			this.FEIIGBGJGLD(FOGFPGOHFPA, "myphiddentitle2");
			return null;
		}
		RSA rsa;
		try
		{
			rsa = this.FJEPKIMHLBG(FOGFPGOHFPA);
		}
		catch (Exception ex)
		{
			this.FEIIGBGJGLD(FOGFPGOHFPA, " and save slot " + ex.Message);
			return null;
		}
		if (rsa == null)
		{
			this.FEIIGBGJGLD(FOGFPGOHFPA, " scenario=");
			return null;
		}
		byte[] bytes;
		try
		{
			bytes = Encoding.UTF8.GetBytes(asObject.ToString());
		}
		catch (Exception ex2)
		{
			this.FEIIGBGJGLD(FOGFPGOHFPA, "socialprivatenofriendsadd" + ex2.Message);
			return null;
		}
		byte[] signature;
		try
		{
			signature = Convert.FromBase64String(CLFGHHBOCMN["gsec"]);
		}
		catch
		{
			this.NMLFCJEMJCM(FOGFPGOHFPA, "socialbadge");
			return null;
		}
		bool flag;
		try
		{
			flag = rsa.VerifyData(bytes, signature, HashAlgorithmName.SHA256, RSASignaturePadding.Pkcs1);
		}
		catch (Exception ex3)
		{
			this.FEIIGBGJGLD(FOGFPGOHFPA, "p" + ex3.Message);
			return null;
		}
		if (!flag)
		{
			this.FEIIGBGJGLD(FOGFPGOHFPA, "$HIDEADS");
			return null;
		}
		DPGJIJGOCIC.NFIDPOMCNLP("User stats stored for app {0}" + FOGFPGOHFPA.ToString() + "spark");
		return asObject;
	}

	// Token: 0x170002BA RID: 698
	// (get) Token: 0x06009229 RID: 37417 RVA: 0x004072F4 File Offset: 0x004054F4
	private string EJIHBGDKAHJ
	{
		get
		{
			return JNDBKHJGEMC.PKEEBBJKELA;
		}
	}

	// Token: 0x0600922A RID: 37418 RVA: 0x00402868 File Offset: 0x00400A68
	private string PCFNOGKBIBK()
	{
		return JNDBKHJGEMC.HEEEKMDAGLF;
	}

	// Token: 0x0600922B RID: 37419 RVA: 0x004072FC File Offset: 0x004054FC
	public void RequestAccountSignIn(string JGPNCNPOGHE, HHCKLPJJKIJ LEALADNCFMM, string PLDNHKIKDIB, string OEFHHHJEDNJ)
	{
		NAHMBEODKJC.OBDBLLHBGLE();
		this.KCIPJMPFPBJ();
		JSONObject jsonobject = new JSONObject();
		JSONObject jsonobject2 = new JSONObject();
		jsonobject2["sgk"] = JGPNCNPOGHE;
		jsonobject2["sgm"] = LEALADNCFMM.ToString();
		RSACryptoServiceProvider rsacryptoServiceProvider = new RSACryptoServiceProvider();
		try
		{
			rsacryptoServiceProvider.FromXmlString(this.BLHCAPLGOCJ);
		}
		catch (Exception ex)
		{
			DPGJIJGOCIC.ANOPFDLPKGC("BackendOperationsManager.RequestAccountSignIn, exception while initializing RSACryptoServiceProvider:" + ex.ToString());
		}
		if (rsacryptoServiceProvider != null)
		{
			try
			{
				byte[] inArray = rsacryptoServiceProvider.Encrypt(Encoding.ASCII.GetBytes(jsonobject2.ToString()), false);
				rsacryptoServiceProvider.Dispose();
				jsonobject["spld"] = Convert.ToBase64String(inArray);
			}
			catch (Exception aklgbjkdomm)
			{
				jsonobject = new JSONObject();
				DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
			}
		}
		if (AKLFPGMDKLA.EHBBFMCILPC.EEHGLPEIIHD == null || AKLFPGMDKLA.EHBBFMCILPC.EEHGLPEIIHD.Length == 0)
		{
			App42Manager.EHBBFMCILPC.QueueCustomCode(KAPNKGFMPDC.basicSync.ToString(), this.KGGAALBOEAB(false, true)).QueueCustomCode(KAPNKGFMPDC.getGeneralBalance.ToString(), this.OptimizeForCachedResponse(KAPNKGFMPDC.getGeneralBalance)).RunCustomCode(KAPNKGFMPDC.signInOrRegister.ToString(), jsonobject, 3, KBOJLHAJPCP.KEHGALKGMKD, null, PLDNHKIKDIB, OEFHHHJEDNJ, false, "");
			return;
		}
		App42Manager.EHBBFMCILPC.RunCustomCode(KAPNKGFMPDC.signIn.ToString(), jsonobject, 3, KBOJLHAJPCP.KEHGALKGMKD, null, PLDNHKIKDIB, OEFHHHJEDNJ, false, "");
	}

	// Token: 0x0600922C RID: 37420 RVA: 0x00407490 File Offset: 0x00405690
	public void RequestForgetAccount(string PLDNHKIKDIB, string OEFHHHJEDNJ)
	{
		NAHMBEODKJC.OBDBLLHBGLE();
		this.KCIPJMPFPBJ();
		JSONObject jsonobject = new JSONObject();
		JSONObject jsonobject2 = new JSONObject();
		jsonobject2["uid"] = AKLFPGMDKLA.EHBBFMCILPC.EEHGLPEIIHD;
		RSACryptoServiceProvider rsacryptoServiceProvider = new RSACryptoServiceProvider();
		try
		{
			rsacryptoServiceProvider.FromXmlString(this.KFPMLOMPNGE);
		}
		catch (Exception ex)
		{
			DPGJIJGOCIC.ANOPFDLPKGC("BackendOperationsManager.RequestForgetAccount, exception while initializing RSACryptoServiceProvider:" + ex.ToString());
		}
		if (rsacryptoServiceProvider != null)
		{
			try
			{
				byte[] inArray = rsacryptoServiceProvider.Encrypt(Encoding.ASCII.GetBytes(jsonobject2.ToString()), false);
				rsacryptoServiceProvider.Dispose();
				jsonobject["spld"] = Convert.ToBase64String(inArray);
			}
			catch (Exception aklgbjkdomm)
			{
				jsonobject = new JSONObject();
				DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
			}
		}
		App42Manager.EHBBFMCILPC.RunCustomCode(KAPNKGFMPDC.forgetAccount.ToString(), jsonobject, 0, KBOJLHAJPCP.KEHGALKGMKD, null, PLDNHKIKDIB, OEFHHHJEDNJ, false, "");
	}

	// Token: 0x0600922D RID: 37421 RVA: 0x0040758C File Offset: 0x0040578C
	public void RequestEmailSubscribe(string EEJBGBFIGEN, string PLDNHKIKDIB, string OEFHHHJEDNJ)
	{
		this.KCIPJMPFPBJ();
		JSONObject jsonobject = new JSONObject();
		jsonobject["eml"] = EEJBGBFIGEN;
		App42Manager.EHBBFMCILPC.QueueCustomCode(KAPNKGFMPDC.basicSync.ToString(), this.KGGAALBOEAB(false, true)).RunCustomCode(KAPNKGFMPDC.emailSubscribe.ToString(), jsonobject, 0, KBOJLHAJPCP.KEHGALKGMKD, null, PLDNHKIKDIB, OEFHHHJEDNJ, false, "");
	}

	// Token: 0x0600922E RID: 37422 RVA: 0x004050CE File Offset: 0x004032CE
	private string LKACDICLKJC()
	{
		return JNDBKHJGEMC.EMFODPFFGLJ;
	}

	// Token: 0x0600922F RID: 37423 RVA: 0x004075FD File Offset: 0x004057FD
	public static bool SafeToKillRequestPremature(KAPNKGFMPDC EGLBLPKFEOI)
	{
		App42Manager.EHBBFMCILPC.CanKillInfiniteRequestPrematureBasedOnMedianRequestsLifeTime();
		return true;
	}

	// Token: 0x06009230 RID: 37424 RVA: 0x0040760C File Offset: 0x0040580C
	public void RequestStartFreePass(string MPOMLMPMFGG, string PLDNHKIKDIB, string OEFHHHJEDNJ)
	{
		this.KCIPJMPFPBJ();
		JSONObject jsonobject = new JSONObject();
		jsonobject["fpi"] = MPOMLMPMFGG;
		App42Manager.EHBBFMCILPC.QueueCustomCode(KAPNKGFMPDC.basicSync.ToString(), this.KGGAALBOEAB(false, true)).RunCustomCode(KAPNKGFMPDC.startFreePass.ToString(), jsonobject, 0, KBOJLHAJPCP.KEHGALKGMKD, null, PLDNHKIKDIB, OEFHHHJEDNJ, false, "");
	}

	// Token: 0x06009231 RID: 37425 RVA: 0x00407680 File Offset: 0x00405880
	public void RequestUndoPremiumChoice(JSONArray MIDDFFCLPKB, int NLLCKPCKGOH, int CCLNHHJPDGJ, string PLDNHKIKDIB, string OEFHHHJEDNJ)
	{
		this.KCIPJMPFPBJ();
		SceneStoryManager.premiumChoiceManInTheMiddleAttack = 0;
		JSONObject jsonobject = new JSONObject();
		JSONObject jsonobject2 = new JSONObject();
		jsonobject2["sind"] = NLLCKPCKGOH.ToString();
		jsonobject2["slind"] = CCLNHHJPDGJ.ToString();
		jsonobject2["cid"] = MIDDFFCLPKB;
		jsonobject2["uid"] = AKLFPGMDKLA.EHBBFMCILPC.EEHGLPEIIHD;
		RSACryptoServiceProvider rsacryptoServiceProvider = new RSACryptoServiceProvider();
		try
		{
			rsacryptoServiceProvider.FromXmlString(this.LCNPDBOJDOM);
		}
		catch (Exception ex)
		{
			DPGJIJGOCIC.ANOPFDLPKGC("BackendOperationsManager.RequestUndoPremiumChoice, exception while initializing RSACryptoServiceProvider:" + ex.ToString());
		}
		if (rsacryptoServiceProvider != null)
		{
			try
			{
				byte[] inArray = rsacryptoServiceProvider.Encrypt(Encoding.ASCII.GetBytes(jsonobject2.ToString()), false);
				rsacryptoServiceProvider.Dispose();
				jsonobject["spld"] = Convert.ToBase64String(inArray);
			}
			catch (Exception aklgbjkdomm)
			{
				jsonobject = new JSONObject();
				DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
			}
		}
		App42Manager.EHBBFMCILPC.QueueCustomCode(KAPNKGFMPDC.basicSync.ToString(), this.KGGAALBOEAB(false, true)).RunCustomCode(KAPNKGFMPDC.undoPremiumChoice.ToString(), jsonobject, 2, KBOJLHAJPCP.KEHGALKGMKD, null, PLDNHKIKDIB, OEFHHHJEDNJ, false, "");
	}

	// Token: 0x06009232 RID: 37426 RVA: 0x004077D4 File Offset: 0x004059D4
	public void RequestUnlockNpcSkin(string PLDNHKIKDIB, string OEFHHHJEDNJ, int GELBBKHCIBA, int COOCLNADECD, int OPFKGLHHDCP)
	{
		this.KCIPJMPFPBJ();
		JSONObject jsonobject = new JSONObject();
		JSONObject jsonobject2 = new JSONObject();
		jsonobject2["uid"] = AKLFPGMDKLA.EHBBFMCILPC.EEHGLPEIIHD;
		jsonobject2["sind"] = GELBBKHCIBA.ToString();
		if (OPFKGLHHDCP > 0)
		{
			jsonobject2["pm"] = OPFKGLHHDCP.ToString();
		}
		if (COOCLNADECD >= 0)
		{
			jsonobject2["amt"] = COOCLNADECD.ToString();
		}
		RSACryptoServiceProvider rsacryptoServiceProvider = new RSACryptoServiceProvider();
		try
		{
			rsacryptoServiceProvider.FromXmlString(this.KDFHCFMIGGC);
		}
		catch (Exception ex)
		{
			DPGJIJGOCIC.ANOPFDLPKGC("BackendOperationsManager.RequestUnlockNpcSkin, exception while initializing RSACryptoServiceProvider:" + ex.ToString());
		}
		if (rsacryptoServiceProvider != null)
		{
			try
			{
				byte[] inArray = rsacryptoServiceProvider.Encrypt(Encoding.ASCII.GetBytes(jsonobject2.ToString()), false);
				rsacryptoServiceProvider.Dispose();
				jsonobject["spld"] = Convert.ToBase64String(inArray);
			}
			catch (Exception aklgbjkdomm)
			{
				jsonobject = new JSONObject();
				DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
			}
		}
		App42Manager.EHBBFMCILPC.QueueCustomCode(KAPNKGFMPDC.basicSync.ToString(), this.KGGAALBOEAB(false, true)).RunCustomCode(KAPNKGFMPDC.unlockNpcSkin.ToString(), jsonobject, 2, KBOJLHAJPCP.KEHGALKGMKD, null, PLDNHKIKDIB, OEFHHHJEDNJ, false, "");
	}

	// Token: 0x06009233 RID: 37427 RVA: 0x00407938 File Offset: 0x00405B38
	public void RequestGetSketchesBalance(string PLDNHKIKDIB, string OEFHHHJEDNJ)
	{
		this.KCIPJMPFPBJ();
		App42Manager.EHBBFMCILPC.RunCustomCode(KAPNKGFMPDC.getSketchesBalance.ToString(), null, 2, KBOJLHAJPCP.KEHGALKGMKD, null, PLDNHKIKDIB, OEFHHHJEDNJ, false, "");
	}

	// Token: 0x06009234 RID: 37428 RVA: 0x00407978 File Offset: 0x00405B78
	public void DBMLGLIFFON(string EEJBGBFIGEN, string PLDNHKIKDIB, string OEFHHHJEDNJ)
	{
		this.KCIPJMPFPBJ();
		JSONObject jsonobject = new JSONObject();
		jsonobject["anthology"] = EEJBGBFIGEN;
		App42Manager.EHBBFMCILPC.QueueCustomCode(((KAPNKGFMPDC)95).ToString(), this.KGGAALBOEAB(true, false)).RunCustomCode(KAPNKGFMPDC.consumePromoCode.ToString(), jsonobject, 0, KBOJLHAJPCP.KEHGALKGMKD, null, PLDNHKIKDIB, OEFHHHJEDNJ, false, "storiesSearchBalance");
	}

	// Token: 0x06009235 RID: 37429 RVA: 0x00402F8F File Offset: 0x0040118F
	private string NAIPMCGJFLA()
	{
		return JNDBKHJGEMC.EIIDKKHKKDE;
	}

	// Token: 0x06009236 RID: 37430 RVA: 0x004079EC File Offset: 0x00405BEC
	public void RequestSpinWheel(GDOKLFCLLIK HGNJKFCDGOE, string PLDNHKIKDIB, string OEFHHHJEDNJ)
	{
		this.KCIPJMPFPBJ();
		JSONObject jsonobject = new JSONObject();
		jsonobject["ulptc"] = new JSONArray();
		jsonobject["uccc"] = new JSONArray();
		JSONObject jsonobject2 = new JSONObject();
		jsonobject2["uid"] = AKLFPGMDKLA.EHBBFMCILPC.EEHGLPEIIHD;
		if (WheelItem.doubleOddsRequested)
		{
			jsonobject2["dor"] = 1;
		}
		else
		{
			jsonobject2["dor"] = 0;
		}
		if (HGNJKFCDGOE != null && HGNJKFCDGOE.OLNJMJMNBCN() == AKLFPGMDKLA.EHBBFMCILPC.COJFECEAKKI)
		{
			jsonobject2["dceoiv"] = AKLFPGMDKLA.EHBBFMCILPC.COJFECEAKKI;
		}
		AKLFPGMDKLA.EHBBFMCILPC.PFCCNPIPPPO();
		jsonobject2["wshcds"] = AKLFPGMDKLA.EHBBFMCILPC.PLLGPNGEHLL;
		int n = AssetsManager.EHBBFMCILPC.lobbyDataAsset.maxLiveProfileThemeId + 1;
		jsonobject2["lptc"] = n;
		RSACryptoServiceProvider rsacryptoServiceProvider = new RSACryptoServiceProvider();
		try
		{
			rsacryptoServiceProvider.FromXmlString(this.MDNHPKGGEDG);
		}
		catch (Exception ex)
		{
			DPGJIJGOCIC.ANOPFDLPKGC("BackendOperationsManager.RequestSpinWheel, exception while initializing RSACryptoServiceProvider:" + ex.ToString());
		}
		if (rsacryptoServiceProvider != null)
		{
			try
			{
				byte[] inArray = rsacryptoServiceProvider.Encrypt(Encoding.ASCII.GetBytes(jsonobject2.ToString()), false);
				rsacryptoServiceProvider.Dispose();
				jsonobject["spld"] = Convert.ToBase64String(inArray);
			}
			catch (Exception aklgbjkdomm)
			{
				jsonobject = new JSONObject();
				DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
			}
		}
		WheelItem.doubleOddsRequested = false;
		this.QueueRequestSaveSyncMoment(null, "spinWheel");
		App42Manager.EHBBFMCILPC.QueueCustomCode(KAPNKGFMPDC.basicSync.ToString(), this.KGGAALBOEAB(false, true)).RunCustomCode(KAPNKGFMPDC.spinWheel.ToString(), jsonobject, 2, KBOJLHAJPCP.KEHGALKGMKD, null, PLDNHKIKDIB, OEFHHHJEDNJ, false, "");
	}

	// Token: 0x06009237 RID: 37431 RVA: 0x00407BD0 File Offset: 0x00405DD0
	public void CLLNMFNFGJC(string PLDNHKIKDIB, string OEFHHHJEDNJ)
	{
		this.KCIPJMPFPBJ();
		App42Manager.EHBBFMCILPC.QueueCustomCode(((KAPNKGFMPDC)(-82)).ToString(), this.KGGAALBOEAB(true, true)).QueueCustomCode(KAPNKGFMPDC.getUserSketches.ToString(), this.BDMPJIFGNIO((KAPNKGFMPDC)121)).QueueCustomCode(((KAPNKGFMPDC)(-17)).ToString(), this.BDMPJIFGNIO((KAPNKGFMPDC)123)).RunCustomCode(((KAPNKGFMPDC)117).ToString(), this.BDMPJIFGNIO((KAPNKGFMPDC)(-98)), 1, KBOJLHAJPCP.KEHGALKGMKD, null, PLDNHKIKDIB, OEFHHHJEDNJ, true, "ach");
	}

	// Token: 0x06009238 RID: 37432 RVA: 0x00407C6C File Offset: 0x00405E6C
	public void RegisterCachedRequest(string NPJCNLGBKOF)
	{
		if (NPJCNLGBKOF.Length == 0)
		{
			return;
		}
		for (int i = 0; i < this.CCCCKKNKBML.Count; i++)
		{
			if (this.CCCCKKNKBML[i].KHHJNODLBHN.Equals(NPJCNLGBKOF))
			{
				return;
			}
		}
		JMIKCLKNIJO jmikclknijo = new JMIKCLKNIJO();
		jmikclknijo.KHHJNODLBHN = NPJCNLGBKOF;
		this.CCCCKKNKBML.Add(jmikclknijo);
		DPGJIJGOCIC.NFIDPOMCNLP("RegisterCachedRequest():" + NPJCNLGBKOF);
	}

	// Token: 0x06009239 RID: 37433 RVA: 0x00407CDC File Offset: 0x00405EDC
	private static RSA KJPIGIKONEM()
	{
		if (BackendOperationsManager.HCJOIGDJHFO != null)
		{
			return BackendOperationsManager.HCJOIGDJHFO;
		}
		object chaolajbabc = BackendOperationsManager.CHAOLAJBABC;
		RSA hcjoigdjhfo;
		lock (chaolajbabc)
		{
			if (BackendOperationsManager.HCJOIGDJHFO != null)
			{
				hcjoigdjhfo = BackendOperationsManager.HCJOIGDJHFO;
			}
			else
			{
				string text = string.Concat(new string[]
				{
					AnimationButtonFlash._flickerSeed,
					SketchThumbnail.tplCode,
					GICFHALNBOI.HDNGJKHELBI,
					AvatarNameResolver.nmTag,
					SceneRestartManager._rsPing
				});
				if (!AFGEGEFJFHN.LPDFBIONAJK(HNIBKBPOCJG.JGMBGBKFHMA(text), KBOJLHAJPCP.GJKLBJOLOOL))
				{
					throw new InvalidOperationException("Prem trust-anchor digest mismatch.");
				}
				string xmlString = "<RSAKeyValue><Exponent>AQAB</Exponent><Modulus>" + text + "</Modulus></RSAKeyValue>";
				RSA rsa = RSA.Create();
				rsa.FromXmlString(xmlString);
				BackendOperationsManager.HCJOIGDJHFO = rsa;
				hcjoigdjhfo = BackendOperationsManager.HCJOIGDJHFO;
			}
		}
		return hcjoigdjhfo;
	}

	// Token: 0x0600923A RID: 37434 RVA: 0x00404E6C File Offset: 0x0040306C
	private IEnumerator DBFAIHGIMCJ(string PLDNHKIKDIB, string OEFHHHJEDNJ, int NLLCKPCKGOH, int OLKMHHNMDLP, int PLKMJJIIJNO, bool NNCKNDMAAHI)
	{
		SceneLobbyManager2.startChapterManInTheMiddleAttack = 0;
		cacheGuid = string.Concat(new string[]
		{
			KAPNKGFMPDC.getStartedChapters.ToString(),
			"_",
			NLLCKPCKGOH.ToString(),
			"_",
			OLKMHHNMDLP.ToString()
		});
		if (NNCKNDMAAHI)
		{
			if (this.RequestIsCached(cacheGuid))
			{
				yield break;
			}
			this.RegisterCachedRequest(cacheGuid);
		}
		else if (this.RequestIsCached(cacheGuid))
		{
			requestResult = LHLIOHJNMFE.none;
			while (this.RequestIsCached(cacheGuid))
			{
				requestResult = this.ExecuteCachedRequestResponse(cacheGuid, true);
				if (requestResult != LHLIOHJNMFE.none)
				{
					break;
				}
				yield return new WaitForEndOfFrame();
			}
			if (requestResult == LHLIOHJNMFE.success)
			{
				yield break;
			}
		}
		yield return new WaitForEndOfFrame();
		this.KCIPJMPFPBJ();
		JSONObject jsonobject = new JSONObject();
		jsonobject["cst"] = AKLFPGMDKLA.EHBBFMCILPC.LGHEAGFKFEI();
		jsonobject["clst"] = AKLFPGMDKLA.EHBBFMCILPC.HLFMFCNMOLK(PLKMJJIIJNO);
		JSONObject jsonobject2 = new JSONObject();
		jsonobject2["sind"] = NLLCKPCKGOH.ToString();
		jsonobject2["cind"] = OLKMHHNMDLP.ToString();
		jsonobject2["uid"] = AKLFPGMDKLA.EHBBFMCILPC.EEHGLPEIIHD;
		RSACryptoServiceProvider rsacryptoServiceProvider = new RSACryptoServiceProvider();
		try
		{
			rsacryptoServiceProvider.FromXmlString(this.MBPGAABODCE);
		}
		catch (Exception ex)
		{
			DPGJIJGOCIC.ANOPFDLPKGC("BackendOperationsManager.RequestStartPlayChapter, exception while initializing RSACryptoServiceProvider:" + ex.ToString());
		}
		if (rsacryptoServiceProvider != null)
		{
			try
			{
				byte[] inArray = rsacryptoServiceProvider.Encrypt(Encoding.ASCII.GetBytes(jsonobject2.ToString()), false);
				rsacryptoServiceProvider.Dispose();
				jsonobject["spld"] = Convert.ToBase64String(inArray);
			}
			catch (Exception aklgbjkdomm)
			{
				jsonobject = new JSONObject();
				DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
			}
		}
		this.ForceRefreshExpiredSubscriptions();
		App42Manager.EHBBFMCILPC.QueueCustomCode(KAPNKGFMPDC.basicSync.ToString(), this.KGGAALBOEAB(false, true)).QueueCustomCode(KAPNKGFMPDC.startPlayChapter.ToString(), jsonobject).RunCustomCode(KAPNKGFMPDC.getStartedChapters.ToString(), null, 2, KBOJLHAJPCP.KEHGALKGMKD, null, PLDNHKIKDIB, OEFHHHJEDNJ, NNCKNDMAAHI, cacheGuid);
		yield break;
	}

	// Token: 0x0600923B RID: 37435 RVA: 0x00403FC5 File Offset: 0x004021C5
	private string OFDKKFAMPMP()
	{
		return JNDBKHJGEMC.KFHGPNNFHEJ;
	}

	// Token: 0x0600923C RID: 37436 RVA: 0x00404E6C File Offset: 0x0040306C
	private IEnumerator EEMBPKPABCK(string PLDNHKIKDIB, string OEFHHHJEDNJ, int NLLCKPCKGOH, int OLKMHHNMDLP, int PLKMJJIIJNO, bool NNCKNDMAAHI)
	{
		SceneLobbyManager2.startChapterManInTheMiddleAttack = 0;
		cacheGuid = string.Concat(new string[]
		{
			KAPNKGFMPDC.getStartedChapters.ToString(),
			"_",
			NLLCKPCKGOH.ToString(),
			"_",
			OLKMHHNMDLP.ToString()
		});
		if (NNCKNDMAAHI)
		{
			if (this.RequestIsCached(cacheGuid))
			{
				yield break;
			}
			this.RegisterCachedRequest(cacheGuid);
		}
		else if (this.RequestIsCached(cacheGuid))
		{
			requestResult = LHLIOHJNMFE.none;
			while (this.RequestIsCached(cacheGuid))
			{
				requestResult = this.ExecuteCachedRequestResponse(cacheGuid, true);
				if (requestResult != LHLIOHJNMFE.none)
				{
					break;
				}
				yield return new WaitForEndOfFrame();
			}
			if (requestResult == LHLIOHJNMFE.success)
			{
				yield break;
			}
		}
		yield return new WaitForEndOfFrame();
		this.KCIPJMPFPBJ();
		JSONObject jsonobject = new JSONObject();
		jsonobject["cst"] = AKLFPGMDKLA.EHBBFMCILPC.LGHEAGFKFEI();
		jsonobject["clst"] = AKLFPGMDKLA.EHBBFMCILPC.HLFMFCNMOLK(PLKMJJIIJNO);
		JSONObject jsonobject2 = new JSONObject();
		jsonobject2["sind"] = NLLCKPCKGOH.ToString();
		jsonobject2["cind"] = OLKMHHNMDLP.ToString();
		jsonobject2["uid"] = AKLFPGMDKLA.EHBBFMCILPC.EEHGLPEIIHD;
		RSACryptoServiceProvider rsacryptoServiceProvider = new RSACryptoServiceProvider();
		try
		{
			rsacryptoServiceProvider.FromXmlString(this.MBPGAABODCE);
		}
		catch (Exception ex)
		{
			DPGJIJGOCIC.ANOPFDLPKGC("BackendOperationsManager.RequestStartPlayChapter, exception while initializing RSACryptoServiceProvider:" + ex.ToString());
		}
		if (rsacryptoServiceProvider != null)
		{
			try
			{
				byte[] inArray = rsacryptoServiceProvider.Encrypt(Encoding.ASCII.GetBytes(jsonobject2.ToString()), false);
				rsacryptoServiceProvider.Dispose();
				jsonobject["spld"] = Convert.ToBase64String(inArray);
			}
			catch (Exception aklgbjkdomm)
			{
				jsonobject = new JSONObject();
				DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
			}
		}
		this.ForceRefreshExpiredSubscriptions();
		App42Manager.EHBBFMCILPC.QueueCustomCode(KAPNKGFMPDC.basicSync.ToString(), this.KGGAALBOEAB(false, true)).QueueCustomCode(KAPNKGFMPDC.startPlayChapter.ToString(), jsonobject).RunCustomCode(KAPNKGFMPDC.getStartedChapters.ToString(), null, 2, KBOJLHAJPCP.KEHGALKGMKD, null, PLDNHKIKDIB, OEFHHHJEDNJ, NNCKNDMAAHI, cacheGuid);
		yield break;
	}

	// Token: 0x0600923D RID: 37437 RVA: 0x00407DB4 File Offset: 0x00405FB4
	public void BLNCOOLAMIM(bool CJHPBOAFCCJ, string NPJCNLGBKOF, LHLIOHJNMFE BAAKLHEPIOP)
	{
		if (CJHPBOAFCCJ)
		{
			for (int i = 1; i < this.CCCCKKNKBML.Count; i += 0)
			{
				if (this.CCCCKKNKBML[i].KHHJNODLBHN.Equals(NPJCNLGBKOF))
				{
					this.CCCCKKNKBML[i].PJBNJEEDNJL = BAAKLHEPIOP;
					DPGJIJGOCIC.CMGOAFDBAOH("Lobby data 2 bundle loaded but its asset is missing or mis-named:" + NPJCNLGBKOF + "" + BAAKLHEPIOP.ToString());
					break;
				}
			}
		}
		if (BAAKLHEPIOP == (LHLIOHJNMFE)4)
		{
			NAHMBEODKJC.ENHDJEFEFCL();
		}
	}

	// Token: 0x170002B8 RID: 696
	// (get) Token: 0x0600923E RID: 37438 RVA: 0x00407E32 File Offset: 0x00406032
	private string ELGBCHAMJLD
	{
		get
		{
			return JNDBKHJGEMC.JCDODBKOBPJ;
		}
	}

	// Token: 0x0600923F RID: 37439 RVA: 0x00407E3C File Offset: 0x0040603C
	public void KJEHILCCLJD(int PLKMJJIIJNO, int FEKJLJNJPHC, string PLDNHKIKDIB, string OEFHHHJEDNJ)
	{
		this.KCIPJMPFPBJ();
		JSONObject jsonobject = new JSONObject();
		JSONObject jsonobject2 = new JSONObject();
		jsonobject2["title"] = PLKMJJIIJNO.ToString();
		jsonobject2["voiceovervol"] = FEKJLJNJPHC.ToString();
		jsonobject2["ok"] = AKLFPGMDKLA.EHBBFMCILPC.EEHGLPEIIHD;
		RSACryptoServiceProvider rsacryptoServiceProvider = new RSACryptoServiceProvider();
		try
		{
			rsacryptoServiceProvider.FromXmlString(this.PABHJGGOOHN);
		}
		catch (Exception ex)
		{
			DPGJIJGOCIC.ANOPFDLPKGC("skinshopinfosummary" + ex.ToString());
		}
		if (rsacryptoServiceProvider != null)
		{
			try
			{
				byte[] inArray = rsacryptoServiceProvider.Encrypt(Encoding.ASCII.GetBytes(jsonobject2.ToString()), true);
				rsacryptoServiceProvider.Dispose();
				jsonobject["$"] = Convert.ToBase64String(inArray);
			}
			catch (Exception aklgbjkdomm)
			{
				jsonobject = new JSONObject();
				DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
			}
		}
		AKLFPGMDKLA.EHBBFMCILPC.LMGMHHLLOFN(PLKMJJIIJNO).IBGDMBHJDIE = FEKJLJNJPHC;
		App42Manager.EHBBFMCILPC.HFBDGJNFIFM(((KAPNKGFMPDC)(-60)).ToString(), jsonobject, 0, KBOJLHAJPCP.KEHGALKGMKD, null, PLDNHKIKDIB, OEFHHHJEDNJ, false, "51B334");
	}

	// Token: 0x06009240 RID: 37440 RVA: 0x00407F70 File Offset: 0x00406170
	public void RequestConsumePromoCode(string IOILFKGBDLF, string PLDNHKIKDIB, string OEFHHHJEDNJ)
	{
		this.KCIPJMPFPBJ();
		JSONObject jsonobject = new JSONObject();
		jsonobject["cid"] = IOILFKGBDLF.ToUpperInvariant();
		App42Manager.EHBBFMCILPC.QueueCustomCode(KAPNKGFMPDC.basicSync.ToString(), this.KGGAALBOEAB(false, true)).RunCustomCode(KAPNKGFMPDC.consumePromoCode.ToString(), jsonobject, 0, KBOJLHAJPCP.KEHGALKGMKD, null, PLDNHKIKDIB, OEFHHHJEDNJ, false, "");
	}

	// Token: 0x06009241 RID: 37441 RVA: 0x00407FE8 File Offset: 0x004061E8
	public void RequestConsumeEnergy(string PLDNHKIKDIB, string OEFHHHJEDNJ, int NLLCKPCKGOH, int OLKMHHNMDLP, int PLKMJJIIJNO)
	{
		this.KCIPJMPFPBJ();
		JSONObject jsonobject = new JSONObject();
		JSONObject jsonobject2 = new JSONObject();
		jsonobject2["sind"] = NLLCKPCKGOH.ToString();
		jsonobject2["cind"] = OLKMHHNMDLP.ToString();
		jsonobject2["uid"] = AKLFPGMDKLA.EHBBFMCILPC.EEHGLPEIIHD;
		RSACryptoServiceProvider rsacryptoServiceProvider = new RSACryptoServiceProvider();
		try
		{
			rsacryptoServiceProvider.FromXmlString(this.AJDCDKCCBND);
		}
		catch (Exception ex)
		{
			DPGJIJGOCIC.ANOPFDLPKGC("BackendOperationsManager.RequestConsumeEnergy, exception while initializing RSACryptoServiceProvider:" + ex.ToString());
		}
		if (rsacryptoServiceProvider != null)
		{
			try
			{
				byte[] inArray = rsacryptoServiceProvider.Encrypt(Encoding.ASCII.GetBytes(jsonobject2.ToString()), false);
				rsacryptoServiceProvider.Dispose();
				jsonobject["spld"] = Convert.ToBase64String(inArray);
			}
			catch (Exception aklgbjkdomm)
			{
				jsonobject = new JSONObject();
				DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
			}
		}
		App42Manager.EHBBFMCILPC.QueueCustomCode(KAPNKGFMPDC.basicSync.ToString(), this.KGGAALBOEAB(false, true)).RunCustomCode(KAPNKGFMPDC.consumeEnergy.ToString(), jsonobject, 2, KBOJLHAJPCP.KEHGALKGMKD, null, PLDNHKIKDIB, OEFHHHJEDNJ, false, "");
	}

	// Token: 0x06009242 RID: 37442 RVA: 0x00403F55 File Offset: 0x00402155
	private string PKFHJILCENE()
	{
		return JNDBKHJGEMC.JNGGAJNBJLF;
	}

	// Token: 0x06009243 RID: 37443 RVA: 0x00408128 File Offset: 0x00406328
	public void GHDGCOHNCGI(JSONArray EKGIPIPPKIH, bool EFNIEHJKNJK, string PLDNHKIKDIB, string OEFHHHJEDNJ)
	{
		this.KCIPJMPFPBJ();
		JSONObject jsonobject = new JSONObject();
		JSONObject jsonobject2 = new JSONObject();
		jsonobject2["iaps"] = EKGIPIPPKIH;
		jsonobject2["1"] = AKLFPGMDKLA.EHBBFMCILPC.EEHGLPEIIHD;
		if (EFNIEHJKNJK)
		{
			jsonobject2["skinshoptutorbody"] = 1;
		}
		else
		{
			jsonobject2["stat1long"] = 1;
		}
		RSACryptoServiceProvider rsacryptoServiceProvider = new RSACryptoServiceProvider();
		try
		{
			rsacryptoServiceProvider.FromXmlString(this.HLAGHGIGPOE());
		}
		catch (Exception ex)
		{
			DPGJIJGOCIC.ANOPFDLPKGC("OnCutsceneViewAssetsDownloadFailed" + ex.ToString());
		}
		if (rsacryptoServiceProvider != null)
		{
			try
			{
				byte[] inArray = rsacryptoServiceProvider.Encrypt(Encoding.ASCII.GetBytes(jsonobject2.ToString()), false);
				rsacryptoServiceProvider.Dispose();
				jsonobject["uid"] = Convert.ToBase64String(inArray);
			}
			catch (Exception aklgbjkdomm)
			{
				jsonobject = new JSONObject();
				DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
			}
		}
		App42Manager.EHBBFMCILPC.HFBDGJNFIFM(((KAPNKGFMPDC)(-8)).ToString(), jsonobject, 1, KBOJLHAJPCP.KEHGALKGMKD, null, PLDNHKIKDIB, OEFHHHJEDNJ, false, "\n");
	}

	// Token: 0x06009244 RID: 37444 RVA: 0x00408250 File Offset: 0x00406450
	private static RSA DCBNDECNGKB()
	{
		if (BackendOperationsManager.HCJOIGDJHFO != null)
		{
			return BackendOperationsManager.HCJOIGDJHFO;
		}
		object chaolajbabc = BackendOperationsManager.CHAOLAJBABC;
		RSA hcjoigdjhfo;
		lock (chaolajbabc)
		{
			if (BackendOperationsManager.HCJOIGDJHFO != null)
			{
				hcjoigdjhfo = BackendOperationsManager.HCJOIGDJHFO;
			}
			else
			{
				string[] array = new string[4];
				array[1] = AnimationButtonFlash._flickerSeed;
				array[1] = SketchThumbnail.tplCode;
				array[6] = GICFHALNBOI.HDNGJKHELBI;
				array[8] = AvatarNameResolver.nmTag;
				array[0] = SceneRestartManager._rsPing;
				string text = string.Concat(array);
				if (!AFGEGEFJFHN.LPDFBIONAJK(HNIBKBPOCJG.JGMBGBKFHMA(text), KBOJLHAJPCP.GJKLBJOLOOL))
				{
					throw new InvalidOperationException("OnReturnRewardPopupHide");
				}
				string xmlString = "OnPopupAvatarCollectionsInputEndEdit" + text + ", out:";
				RSA rsa = RSA.Create();
				rsa.FromXmlString(xmlString);
				BackendOperationsManager.HCJOIGDJHFO = rsa;
				hcjoigdjhfo = BackendOperationsManager.HCJOIGDJHFO;
			}
		}
		return hcjoigdjhfo;
	}

	// Token: 0x06009245 RID: 37445 RVA: 0x00408328 File Offset: 0x00406528
	public void QueueRequestSaveSync()
	{
		JSONObject jsonobject = new JSONObject();
		jsonobject["sd"] = AKLFPGMDKLA.EHBBFMCILPC.BOJKIPEOKKJ();
		JSONObject jsonobject2 = new JSONObject();
		jsonobject2["uid"] = AKLFPGMDKLA.EHBBFMCILPC.EEHGLPEIIHD;
		RSACryptoServiceProvider rsacryptoServiceProvider = new RSACryptoServiceProvider();
		try
		{
			rsacryptoServiceProvider.FromXmlString(this.AEGDDGMEGEK);
		}
		catch (Exception ex)
		{
			DPGJIJGOCIC.ANOPFDLPKGC("BackendOperationsManager.QueueRequestSaveSync, exception while initializing RSACryptoServiceProvider:" + ex.ToString());
		}
		if (rsacryptoServiceProvider != null)
		{
			try
			{
				byte[] inArray = rsacryptoServiceProvider.Encrypt(Encoding.ASCII.GetBytes(jsonobject2.ToString()), false);
				rsacryptoServiceProvider.Dispose();
				jsonobject["spld"] = Convert.ToBase64String(inArray);
			}
			catch (Exception aklgbjkdomm)
			{
				jsonobject = new JSONObject();
				DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
			}
		}
		if (jsonobject["spld"] == null)
		{
			DPGJIJGOCIC.ANOPFDLPKGC("BackendOperationsManager.QueueRequestSaveSync, no spld - not queueing");
			return;
		}
		App42Manager.EHBBFMCILPC.QueueCustomCode(KAPNKGFMPDC.saveSync.ToString(), jsonobject);
	}

	// Token: 0x06009246 RID: 37446 RVA: 0x0040843C File Offset: 0x0040663C
	public void MHKCMDLENHO(string DEFIPMJKIKA, bool CJHPBOAFCCJ, string NPJCNLGBKOF)
	{
		if (!CJHPBOAFCCJ || NPJCNLGBKOF.Length == 0)
		{
			AOBJLALDBAA.KKPFOJMAONG().KMAGHMCCMPG(DEFIPMJKIKA, 938f);
			return;
		}
		for (int i = 0; i < this.CCCCKKNKBML.Count; i += 0)
		{
			if (this.CCCCKKNKBML[i].KHHJNODLBHN.Equals(NPJCNLGBKOF))
			{
				this.CCCCKKNKBML[i].KDKKHJIHFIF = DEFIPMJKIKA;
				return;
			}
		}
	}

	// Token: 0x06009247 RID: 37447 RVA: 0x00405C98 File Offset: 0x00403E98
	private IEnumerator CILPDAGJBEI(string PLDNHKIKDIB, string OEFHHHJEDNJ, int NLLCKPCKGOH, int OLKMHHNMDLP, int PLKMJJIIJNO, bool NNCKNDMAAHI)
	{
		BackendOperationsManager.ODOAFBIFKHP odoafbifkhp = new BackendOperationsManager.ODOAFBIFKHP(1);
		odoafbifkhp.<>4__this = this;
		odoafbifkhp._onSuccessEvent = PLDNHKIKDIB;
		odoafbifkhp._onExceptionEvent = OEFHHHJEDNJ;
		odoafbifkhp._storyIndex = NLLCKPCKGOH;
		odoafbifkhp._chapterIndex = OLKMHHNMDLP;
		odoafbifkhp._anthologyIndex = PLKMJJIIJNO;
		odoafbifkhp._cacheRequest = NNCKNDMAAHI;
		return odoafbifkhp;
	}

	// Token: 0x06009248 RID: 37448 RVA: 0x004084A8 File Offset: 0x004066A8
	public void FinishRequest(bool CJHPBOAFCCJ, string NPJCNLGBKOF, LHLIOHJNMFE BAAKLHEPIOP)
	{
		if (CJHPBOAFCCJ)
		{
			for (int i = 0; i < this.CCCCKKNKBML.Count; i++)
			{
				if (this.CCCCKKNKBML[i].KHHJNODLBHN.Equals(NPJCNLGBKOF))
				{
					this.CCCCKKNKBML[i].PJBNJEEDNJL = BAAKLHEPIOP;
					DPGJIJGOCIC.NFIDPOMCNLP("FinishRequest():" + NPJCNLGBKOF + ", " + BAAKLHEPIOP.ToString());
					break;
				}
			}
		}
		if (BAAKLHEPIOP == LHLIOHJNMFE.exception)
		{
			NAHMBEODKJC.OBDBLLHBGLE();
		}
	}

	// Token: 0x06009249 RID: 37449 RVA: 0x00408528 File Offset: 0x00406728
	public static BackendOperationsManager NPDDBAONMJP()
	{
		if (!BackendOperationsManager.IKLAPGJDMNA)
		{
			BackendOperationsManager.IKLAPGJDMNA = (UnityEngine.Object.FindObjectOfType(typeof(BackendOperationsManager)) as BackendOperationsManager);
			if (!BackendOperationsManager.IKLAPGJDMNA)
			{
				DPGJIJGOCIC.ANOPFDLPKGC("");
			}
		}
		return BackendOperationsManager.IKLAPGJDMNA;
	}

	// Token: 0x0600924A RID: 37450 RVA: 0x00408578 File Offset: 0x00406778
	public void APIDBEMMPMC(string IOILFKGBDLF, string PLDNHKIKDIB, string OEFHHHJEDNJ)
	{
		this.KCIPJMPFPBJ();
		JSONObject jsonobject = new JSONObject();
		jsonobject["scene bundle "] = IOILFKGBDLF.ToUpperInvariant();
		App42Manager.EHBBFMCILPC.QueueCustomCode(((KAPNKGFMPDC)(-94)).ToString(), this.KGGAALBOEAB(false, false)).RunCustomCode(((KAPNKGFMPDC)(-65)).ToString(), jsonobject, 0, KBOJLHAJPCP.KEHGALKGMKD, null, PLDNHKIKDIB, OEFHHHJEDNJ, false, "htmeo");
	}

	// Token: 0x0600924B RID: 37451 RVA: 0x0040480E File Offset: 0x00402A0E
	private string LMGELIHBAPD()
	{
		return JNDBKHJGEMC.KFHMKHMLAOE;
	}

	// Token: 0x0600924C RID: 37452 RVA: 0x004085F0 File Offset: 0x004067F0
	public void FIJKIAKDCNO(string DEFIPMJKIKA, bool CJHPBOAFCCJ, string NPJCNLGBKOF)
	{
		if (!CJHPBOAFCCJ || NPJCNLGBKOF.Length == 0)
		{
			AOBJLALDBAA.DBLAIDPICIG().EGELHPJBAIC(DEFIPMJKIKA, 1342f);
			return;
		}
		for (int i = 0; i < this.CCCCKKNKBML.Count; i++)
		{
			if (this.CCCCKKNKBML[i].KHHJNODLBHN.Equals(NPJCNLGBKOF))
			{
				this.CCCCKKNKBML[i].KDKKHJIHFIF = DEFIPMJKIKA;
				return;
			}
		}
	}

	// Token: 0x0600924D RID: 37453 RVA: 0x0040865C File Offset: 0x0040685C
	public bool RequestSaveChapterSnapshots(string PLDNHKIKDIB = "", string KLCOCBODJAF = "")
	{
		if (ODLJHDIGLGO.MNALIKIMKFC(CLHDENLPOFP.gamePass) == null)
		{
			return false;
		}
		JSONArray jsonarray = AKLFPGMDKLA.EHBBFMCILPC.JOKIEEMBKOA(16);
		if (jsonarray.Count == 0)
		{
			return false;
		}
		this.KCIPJMPFPBJ();
		JSONObject jsonobject = new JSONObject();
		jsonobject["usynsnap"] = jsonarray;
		JSONObject jsonobject2 = new JSONObject();
		jsonobject2["uid"] = AKLFPGMDKLA.EHBBFMCILPC.EEHGLPEIIHD;
		RSACryptoServiceProvider rsacryptoServiceProvider = new RSACryptoServiceProvider();
		try
		{
			rsacryptoServiceProvider.FromXmlString(this.NJMFPLMACLD);
		}
		catch (Exception ex)
		{
			DPGJIJGOCIC.ANOPFDLPKGC("BackendOperationsManager.RequestSaveChapterSnapshots, exception while initializing RSACryptoServiceProvider:" + ex.ToString());
		}
		if (rsacryptoServiceProvider != null)
		{
			try
			{
				byte[] inArray = rsacryptoServiceProvider.Encrypt(Encoding.ASCII.GetBytes(jsonobject2.ToString()), false);
				rsacryptoServiceProvider.Dispose();
				jsonobject["spld"] = Convert.ToBase64String(inArray);
			}
			catch (Exception aklgbjkdomm)
			{
				jsonobject = new JSONObject();
				DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
			}
		}
		App42Manager.EHBBFMCILPC.RunCustomCode(KAPNKGFMPDC.saveChapterSnapshots.ToString(), jsonobject, 1, 1, null, PLDNHKIKDIB, KLCOCBODJAF, false, "");
		return true;
	}

	// Token: 0x0600924E RID: 37454 RVA: 0x0040877C File Offset: 0x0040697C
	public void ForceRefreshExpiredSubscriptions()
	{
		this.JOIJJPLOPNK = 100000;
	}

	// Token: 0x0600924F RID: 37455 RVA: 0x0040878C File Offset: 0x0040698C
	private JSONObject MIDDKNEEGNK(KAPNKGFMPDC FOGFPGOHFPA, JSONNode CLFGHHBOCMN)
	{
		if (CLFGHHBOCMN == null)
		{
			this.FEIIGBGJGLD(FOGFPGOHFPA, "response object is null");
			return null;
		}
		if (CLFGHHBOCMN["sig"] == null)
		{
			this.FEIIGBGJGLD(FOGFPGOHFPA, "signature not found");
			return null;
		}
		JSONObject asObject = CLFGHHBOCMN["p"].AsObject;
		if (asObject == null || asObject["uid"] == null)
		{
			this.FEIIGBGJGLD(FOGFPGOHFPA, "uid not found");
			return null;
		}
		if (!HNIBKBPOCJG.DDKPGMBIHOP(asObject["uid"], AKLFPGMDKLA.EHBBFMCILPC.EEHGLPEIIHD))
		{
			this.FEIIGBGJGLD(FOGFPGOHFPA, "uid not confirmed");
			return null;
		}
		RSA rsa;
		try
		{
			rsa = this.FJEPKIMHLBG(FOGFPGOHFPA);
		}
		catch (Exception ex)
		{
			this.FEIIGBGJGLD(FOGFPGOHFPA, "trust-anchor load failed: " + ex.Message);
			return null;
		}
		if (rsa == null)
		{
			this.FEIIGBGJGLD(FOGFPGOHFPA, "no trust anchor for opType");
			return null;
		}
		byte[] bytes;
		try
		{
			bytes = Encoding.UTF8.GetBytes(asObject.ToString());
		}
		catch (Exception ex2)
		{
			this.FEIIGBGJGLD(FOGFPGOHFPA, "payload serialize failed: " + ex2.Message);
			return null;
		}
		byte[] signature;
		try
		{
			signature = Convert.FromBase64String(CLFGHHBOCMN["sig"]);
		}
		catch
		{
			this.FEIIGBGJGLD(FOGFPGOHFPA, "sig not base64");
			return null;
		}
		bool flag;
		try
		{
			flag = rsa.VerifyData(bytes, signature, HashAlgorithmName.SHA256, RSASignaturePadding.Pkcs1);
		}
		catch (Exception ex3)
		{
			this.FEIIGBGJGLD(FOGFPGOHFPA, "verify threw: " + ex3.Message);
			return null;
		}
		if (!flag)
		{
			this.FEIIGBGJGLD(FOGFPGOHFPA, "signature is invalid");
			return null;
		}
		DPGJIJGOCIC.NFIDPOMCNLP("BackendRequestType." + FOGFPGOHFPA.ToString() + ", signature verification successful!");
		return asObject;
	}

	// Token: 0x06009250 RID: 37456 RVA: 0x004049C8 File Offset: 0x00402BC8
	private void OnDestroy()
	{
		if (BackendOperationsManager.IKLAPGJDMNA == this)
		{
			BackendOperationsManager.IKLAPGJDMNA = null;
		}
	}

	// Token: 0x06009251 RID: 37457 RVA: 0x0040897C File Offset: 0x00406B7C
	public void CleanCachedRequestsData()
	{
		this.CCCCKKNKBML.Clear();
	}

	// Token: 0x170002C5 RID: 709
	// (get) Token: 0x06009252 RID: 37458 RVA: 0x00404451 File Offset: 0x00402651
	private string NJMFPLMACLD
	{
		get
		{
			return JNDBKHJGEMC.NLPIHJAPHIO;
		}
	}

	// Token: 0x06009253 RID: 37459 RVA: 0x00404EA8 File Offset: 0x004030A8
	private string HLAGHGIGPOE()
	{
		return JNDBKHJGEMC.KNGHAPKFJIP;
	}

	// Token: 0x06009254 RID: 37460 RVA: 0x0040898C File Offset: 0x00406B8C
	public void RequestBasicSyncAndSaveSync(string PLDNHKIKDIB, string OEFHHHJEDNJ, bool IFDDAOHKBFP)
	{
		this.KCIPJMPFPBJ();
		this.QueueRequestSaveSyncMoment(null, "refocus");
		App42Manager.EHBBFMCILPC.RunCustomCode(KAPNKGFMPDC.basicSync.ToString(), this.KGGAALBOEAB(IFDDAOHKBFP, true), 2, KBOJLHAJPCP.KEHGALKGMKD, null, PLDNHKIKDIB, OEFHHHJEDNJ, false, "");
	}

	// Token: 0x06009255 RID: 37461 RVA: 0x004089E0 File Offset: 0x00406BE0
	public void CFEEIAMCACA(string PLDNHKIKDIB, string OEFHHHJEDNJ, int NLLCKPCKGOH, int OLKMHHNMDLP, int PLKMJJIIJNO)
	{
		this.KCIPJMPFPBJ();
		JSONObject jsonobject = new JSONObject();
		JSONObject jsonobject2 = new JSONObject();
		jsonobject2[""] = NLLCKPCKGOH.ToString();
		jsonobject2["importanttitle"] = OLKMHHNMDLP.ToString();
		jsonobject2["sslt"] = AKLFPGMDKLA.EHBBFMCILPC.EEHGLPEIIHD;
		RSACryptoServiceProvider rsacryptoServiceProvider = new RSACryptoServiceProvider();
		try
		{
			rsacryptoServiceProvider.FromXmlString(this.AJDCDKCCBND);
		}
		catch (Exception ex)
		{
			DPGJIJGOCIC.ANOPFDLPKGC("mypsuspintrobtn" + ex.ToString());
		}
		if (rsacryptoServiceProvider != null)
		{
			try
			{
				byte[] inArray = rsacryptoServiceProvider.Encrypt(Encoding.ASCII.GetBytes(jsonobject2.ToString()), false);
				rsacryptoServiceProvider.Dispose();
				jsonobject["no"] = Convert.ToBase64String(inArray);
			}
			catch (Exception aklgbjkdomm)
			{
				jsonobject = new JSONObject();
				DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
			}
		}
		App42Manager.EHBBFMCILPC.QueueCustomCode(((KAPNKGFMPDC)72).ToString(), this.KGGAALBOEAB(true, false)).HFBDGJNFIFM(KAPNKGFMPDC.startFreePass.ToString(), jsonobject, 5, KBOJLHAJPCP.KEHGALKGMKD, null, PLDNHKIKDIB, OEFHHHJEDNJ, true, "OnSketchThumbnailsCdnSuccess");
	}

	// Token: 0x06009256 RID: 37462 RVA: 0x00408B20 File Offset: 0x00406D20
	public void PostponeRequestStoryChapterComplete(int NLLCKPCKGOH, int OLKMHHNMDLP)
	{
		JSONObject jsonobject = new JSONObject();
		JSONObject jsonobject2 = new JSONObject();
		jsonobject2["cind"] = OLKMHHNMDLP.ToString();
		jsonobject2["sind"] = NLLCKPCKGOH.ToString();
		jsonobject2["uid"] = AKLFPGMDKLA.EHBBFMCILPC.EEHGLPEIIHD;
		RSACryptoServiceProvider rsacryptoServiceProvider = new RSACryptoServiceProvider();
		try
		{
			rsacryptoServiceProvider.FromXmlString(this.ELGBCHAMJLD);
		}
		catch (Exception ex)
		{
			DPGJIJGOCIC.ANOPFDLPKGC("BackendOperationsManager.RequestGetSocialStatsAvatar, exception while initializing RSACryptoServiceProvider:" + ex.ToString());
		}
		if (rsacryptoServiceProvider != null)
		{
			try
			{
				byte[] inArray = rsacryptoServiceProvider.Encrypt(Encoding.ASCII.GetBytes(jsonobject2.ToString()), false);
				rsacryptoServiceProvider.Dispose();
				jsonobject["spld"] = Convert.ToBase64String(inArray);
			}
			catch (Exception aklgbjkdomm)
			{
				jsonobject = new JSONObject();
				DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
			}
		}
		App42Manager.EHBBFMCILPC.PostponeCustomCode(KAPNKGFMPDC.storyChapterComplete.ToString(), jsonobject);
	}

	// Token: 0x170002BF RID: 703
	// (get) Token: 0x06009257 RID: 37463 RVA: 0x00404E52 File Offset: 0x00403052
	private string KDFHCFMIGGC
	{
		get
		{
			return JNDBKHJGEMC.FHIKPHCOJFD;
		}
	}

	// Token: 0x06009258 RID: 37464 RVA: 0x00408C30 File Offset: 0x00406E30
	public void AIKAHFFOLBB(string PLDNHKIKDIB, string OEFHHHJEDNJ)
	{
		NAHMBEODKJC.DDDBGPPPDJA();
		this.KCIPJMPFPBJ();
		JSONObject jsonobject = new JSONObject();
		JSONObject jsonobject2 = new JSONObject();
		jsonobject2["signinerror001"] = AKLFPGMDKLA.EHBBFMCILPC.EEHGLPEIIHD;
		RSACryptoServiceProvider rsacryptoServiceProvider = new RSACryptoServiceProvider();
		try
		{
			rsacryptoServiceProvider.FromXmlString(this.KFPMLOMPNGE);
		}
		catch (Exception ex)
		{
			DPGJIJGOCIC.ANOPFDLPKGC("small" + ex.ToString());
		}
		if (rsacryptoServiceProvider != null)
		{
			try
			{
				byte[] inArray = rsacryptoServiceProvider.Encrypt(Encoding.ASCII.GetBytes(jsonobject2.ToString()), true);
				rsacryptoServiceProvider.Dispose();
				jsonobject["OnSystemBackButton"] = Convert.ToBase64String(inArray);
			}
			catch (Exception aklgbjkdomm)
			{
				jsonobject = new JSONObject();
				DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
			}
		}
		App42Manager.EHBBFMCILPC.RunCustomCode(((KAPNKGFMPDC)(-65)).ToString(), jsonobject, 0, KBOJLHAJPCP.KEHGALKGMKD, null, PLDNHKIKDIB, OEFHHHJEDNJ, false, "Video:");
	}

	// Token: 0x06009259 RID: 37465 RVA: 0x00402EEC File Offset: 0x004010EC
	private string GMJMCPEJPAB()
	{
		return JNDBKHJGEMC.MBBANAPCOLP;
	}

	// Token: 0x0600925A RID: 37466 RVA: 0x00408D2C File Offset: 0x00406F2C
	private RSA FJEPKIMHLBG(KAPNKGFMPDC FOGFPGOHFPA)
	{
		if (FOGFPGOHFPA == KAPNKGFMPDC.startPlayChapter)
		{
			return BackendOperationsManager.KJNDLKAADMF();
		}
		if (FOGFPGOHFPA == KAPNKGFMPDC.premiumChoice)
		{
			return BackendOperationsManager.KJPIGIKONEM();
		}
		if (FOGFPGOHFPA != KAPNKGFMPDC.undoPremiumChoice)
		{
			return null;
		}
		return BackendOperationsManager.DJOLBAPAMLJ();
	}

	// Token: 0x0600925B RID: 37467 RVA: 0x00408D54 File Offset: 0x00406F54
	public void CFPGDIAGJFA(string PLDNHKIKDIB, string OEFHHHJEDNJ, int NLLCKPCKGOH, int OLKMHHNMDLP, int PLKMJJIIJNO)
	{
		this.KCIPJMPFPBJ();
		JSONObject jsonobject = new JSONObject();
		JSONObject jsonobject2 = new JSONObject();
		jsonobject2[". "] = NLLCKPCKGOH.ToString();
		jsonobject2["spr"] = OLKMHHNMDLP.ToString();
		jsonobject2["+"] = AKLFPGMDKLA.EHBBFMCILPC.EEHGLPEIIHD;
		RSACryptoServiceProvider rsacryptoServiceProvider = new RSACryptoServiceProvider();
		try
		{
			rsacryptoServiceProvider.FromXmlString(this.AJDCDKCCBND);
		}
		catch (Exception ex)
		{
			DPGJIJGOCIC.ANOPFDLPKGC("acomp" + ex.ToString());
		}
		if (rsacryptoServiceProvider != null)
		{
			try
			{
				byte[] inArray = rsacryptoServiceProvider.Encrypt(Encoding.ASCII.GetBytes(jsonobject2.ToString()), false);
				rsacryptoServiceProvider.Dispose();
				jsonobject[""] = Convert.ToBase64String(inArray);
			}
			catch (Exception aklgbjkdomm)
			{
				jsonobject = new JSONObject();
				DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
			}
		}
		App42Manager.EHBBFMCILPC.QueueCustomCode(((KAPNKGFMPDC)(-16)).ToString(), this.KGGAALBOEAB(false, true)).HFBDGJNFIFM(((KAPNKGFMPDC)76).ToString(), jsonobject, 8, KBOJLHAJPCP.KEHGALKGMKD, null, PLDNHKIKDIB, OEFHHHJEDNJ, true, " ");
	}

	// Token: 0x0600925C RID: 37468 RVA: 0x00407E32 File Offset: 0x00406032
	private string PGLFLGNKJEM()
	{
		return JNDBKHJGEMC.JCDODBKOBPJ;
	}

	// Token: 0x0600925D RID: 37469 RVA: 0x00408E94 File Offset: 0x00407094
	public void RequestCheckForUpdates(string PLDNHKIKDIB, string OEFHHHJEDNJ)
	{
		this.KCIPJMPFPBJ();
		App42Manager.EHBBFMCILPC.QueueCustomCode(KAPNKGFMPDC.basicSync.ToString(), this.KGGAALBOEAB(false, true)).QueueCustomCode(KAPNKGFMPDC.getLiveEvents.ToString(), this.OptimizeForCachedResponse(KAPNKGFMPDC.getLiveEvents)).QueueCustomCode(KAPNKGFMPDC.getLiveOffers.ToString(), this.OptimizeForCachedResponse(KAPNKGFMPDC.getLiveOffers)).RunCustomCode(KAPNKGFMPDC.checkForUpdates.ToString(), this.OptimizeForCachedResponse(KAPNKGFMPDC.checkForUpdates), 2, KBOJLHAJPCP.KEHGALKGMKD, null, PLDNHKIKDIB, OEFHHHJEDNJ, false, "");
	}

	// Token: 0x0600925E RID: 37470 RVA: 0x0040897C File Offset: 0x00406B7C
	public void ENPDOAKBIHC()
	{
		this.CCCCKKNKBML.Clear();
	}

	// Token: 0x0600925F RID: 37471 RVA: 0x004050C7 File Offset: 0x004032C7
	private string LKIDINKANLJ()
	{
		return JNDBKHJGEMC.CONKDLHMAGO;
	}

	// Token: 0x06009260 RID: 37472 RVA: 0x00408F30 File Offset: 0x00407130
	public void QueueRequestSaveAvatarCollections()
	{
		if (ODLJHDIGLGO.MNALIKIMKFC(CLHDENLPOFP.gamePass) == null)
		{
			return;
		}
		JSONArray jsonarray = AKLFPGMDKLA.EHBBFMCILPC.KKMCNPJNGNL(16);
		if (jsonarray.Count == 0)
		{
			return;
		}
		this.KCIPJMPFPBJ();
		JSONObject jsonobject = new JSONObject();
		jsonobject["usyncoll2"] = jsonarray;
		JSONObject jsonobject2 = new JSONObject();
		jsonobject2["uid"] = AKLFPGMDKLA.EHBBFMCILPC.EEHGLPEIIHD;
		RSACryptoServiceProvider rsacryptoServiceProvider = new RSACryptoServiceProvider();
		try
		{
			rsacryptoServiceProvider.FromXmlString(this.LJPJDFLBDCC);
		}
		catch (Exception ex)
		{
			DPGJIJGOCIC.ANOPFDLPKGC("BackendOperationsManager.QueueRequestSaveAvatarCollections, exception while initializing RSACryptoServiceProvider:" + ex.ToString());
		}
		if (rsacryptoServiceProvider != null)
		{
			try
			{
				byte[] inArray = rsacryptoServiceProvider.Encrypt(Encoding.ASCII.GetBytes(jsonobject2.ToString()), false);
				rsacryptoServiceProvider.Dispose();
				jsonobject["spld"] = Convert.ToBase64String(inArray);
			}
			catch (Exception aklgbjkdomm)
			{
				jsonobject = new JSONObject();
				DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
			}
		}
		App42Manager.EHBBFMCILPC.QueueCustomCode(KAPNKGFMPDC.saveAvatarCollections.ToString(), jsonobject);
	}

	// Token: 0x06009261 RID: 37473 RVA: 0x00409044 File Offset: 0x00407244
	public void CNEHDBBBKNE(string NPJCNLGBKOF)
	{
		if (NPJCNLGBKOF.Length == 0)
		{
			return;
		}
		for (int i = 0; i < this.CCCCKKNKBML.Count; i++)
		{
			if (this.CCCCKKNKBML[i].KHHJNODLBHN.Equals(NPJCNLGBKOF))
			{
				return;
			}
		}
		JMIKCLKNIJO jmikclknijo = new JMIKCLKNIJO();
		jmikclknijo.KHHJNODLBHN = NPJCNLGBKOF;
		this.CCCCKKNKBML.Add(jmikclknijo);
		DPGJIJGOCIC.CMGOAFDBAOH("idmr" + NPJCNLGBKOF);
	}

	// Token: 0x06009262 RID: 37474 RVA: 0x004090B4 File Offset: 0x004072B4
	public void ProcessApp42Success(JSONObject FBEGMMDDOIG, bool NNCKNDMAAHI, string NPJCNLGBKOF)
	{
		if (NNCKNDMAAHI)
		{
			for (int i = 0; i < this.CCCCKKNKBML.Count; i++)
			{
				if (this.CCCCKKNKBML[i].KHHJNODLBHN.Equals(NPJCNLGBKOF))
				{
					this.CCCCKKNKBML[i].LPHMODJEEBN = FBEGMMDDOIG;
					DPGJIJGOCIC.NFIDPOMCNLP("Cached, app42 reponse received, not dispatched:" + FBEGMMDDOIG.ToString());
					return;
				}
			}
			return;
		}
		JSONArray asArray = FBEGMMDDOIG["res"].AsArray;
		DPGJIJGOCIC.NFIDPOMCNLP("Response custom code: " + asArray.ToString());
		bool flag = false;
		if (asArray.Count == 0)
		{
			DPGJIJGOCIC.ADFCDFHBDAF("Custom code returned an empty response array! This is not possible.");
		}
		else
		{
			int j = 0;
			while (j < asArray.Count)
			{
				JSONObject asObject = asArray[j].AsObject;
				NAHMBEODKJC.JCOHHLCKHMD(asObject);
				switch (BackendOperationsManager.StringToBackendRequestType(asObject["rt"]))
				{
				case KAPNKGFMPDC.registerUser:
					goto IL_884;
				case KAPNKGFMPDC.processTransaction:
					if (asObject["p"]["rsl"].AsInt == 1)
					{
						AOBJLALDBAA.EHBBFMCILPC.EGELHPJBAIC(this.onBackendValidateTransactionSuccess, asObject);
					}
					else
					{
						AOBJLALDBAA.EHBBFMCILPC.EGELHPJBAIC(this.onBackendValidateTransactionFailed, 0f);
					}
					break;
				case KAPNKGFMPDC.changeOwner:
					try
					{
						if (asObject["p"]["acoll"] != null)
						{
							FirebaseAnalyticsManager.EHBBFMCILPC.LogEvent(false, AGEHCPDNBFD.issueRep.ToString(), FFPHBMFGCNN.accCollision.ToString(), App42Manager.GetOsName().ToString(), false, false);
						}
					}
					catch (Exception aklgbjkdomm)
					{
						DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
					}
					AKLFPGMDKLA.EHBBFMCILPC.IGDFOFLIAIC();
					AKLFPGMDKLA.EHBBFMCILPC.BBAEMGBHMAN();
					BackendOperationsManager.IHFCACMNGEA = -1f;
					App42Manager.doNotDispatchEvents = true;
					AKLFPGMDKLA.EHBBFMCILPC.NHDMCKPHEIA(asObject["p"]["sd"].AsObject);
					AppManager.EHBBFMCILPC.RestartApp(true, false);
					break;
				case KAPNKGFMPDC.signIn:
					if (asObject["p"]["sd"] != null)
					{
						AKLFPGMDKLA.EHBBFMCILPC.IGDFOFLIAIC();
						AKLFPGMDKLA.EHBBFMCILPC.BBAEMGBHMAN();
						AKLFPGMDKLA.EHBBFMCILPC.NHDMCKPHEIA(asObject["p"]["sd"].AsObject);
						AKLFPGMDKLA.EHBBFMCILPC.KBKOLEJEEGH();
					}
					this.BFAAELGOIGN(asObject["p"]);
					break;
				case KAPNKGFMPDC.getPurchasingBalance:
					CJEKEHDEBLM.EHBBFMCILPC.BAMHPOCKBML(asObject["p"]["purchasingBalance"].AsArray);
					PurchaseManagerBridge.EHBBFMCILPC.GetPurchaseManager().Initialize();
					break;
				case KAPNKGFMPDC.getDepot:
					AssetsManager.EHBBFMCILPC.SetDepot(asObject["p"]["cdndu"], asObject["p"]["cdnsd"].AsArray);
					break;
				case KAPNKGFMPDC.getDefaultBundles:
					AssetsManager.EHBBFMCILPC.QueueAssetBundleDownload(NMKDCBPMCKI.AssetBundleHeadersPack, -1, -1, FLDBFOADFLH.startDownloadAndProceed, false, true, false, null, -1, false, "", false, false);
					AssetsManager.EHBBFMCILPC.QueueAssetBundleDownload(NMKDCBPMCKI.AssetBundleHeadersPack2, -1, -1, FLDBFOADFLH.startDownloadAndProceed, false, true, false, null, -1, false, "", false, false);
					AssetsManager.EHBBFMCILPC.QueueAssetBundleDownload(NMKDCBPMCKI.AssetBundleTextPack, -1, -1, FLDBFOADFLH.startDownloadAndProceed, false, true, false, null, -1, false, "", false, false);
					AssetsManager.EHBBFMCILPC.QueueAssetBundleDownload(NMKDCBPMCKI.AssetBundlePurchasingView, -1, -1, FLDBFOADFLH.startDownloadAndProceed, false, true, true, null, -1, false, "", false, false);
					break;
				case KAPNKGFMPDC.storyChapterComplete:
					if (asObject["p"] != null && asObject["p"]["psk"] != null)
					{
						AKLFPGMDKLA.EHBBFMCILPC.IPEMNDHJBHK = asObject["p"]["psk"];
					}
					break;
				case KAPNKGFMPDC.basicSync:
				{
					try
					{
						if (asObject["p"]["cfp"] != null)
						{
							AKLFPGMDKLA.EHBBFMCILPC.LAHPLEFAGLH = DPGJIJGOCIC.POHBFGLLKFD(asObject["p"]["cfp"].AsArray);
						}
						else
						{
							AKLFPGMDKLA.EHBBFMCILPC.LAHPLEFAGLH = new List<string>();
						}
					}
					catch (Exception ex)
					{
						DPGJIJGOCIC.ANOPFDLPKGC("BackendRequestType.basicSync, exception, failing safe:" + ex.ToString());
						AKLFPGMDKLA.EHBBFMCILPC.LAHPLEFAGLH = new List<string>();
					}
					try
					{
						if (asObject["p"]["gsec"] != null)
						{
							int asInt = asObject["p"]["gsec"].AsInt;
							AOBJLALDBAA.EHBBFMCILPC.EGELHPJBAIC("OnUpdateSocialEventsCounter", asObject["p"]["gsec"].AsInt);
							if (asInt > 0 && !ProfileItem2.profileWindowActive)
							{
								AKLFPGMDKLA.EHBBFMCILPC.CIPCINKGILF = true;
							}
						}
					}
					catch (Exception ex2)
					{
						DPGJIJGOCIC.ANOPFDLPKGC("BackendRequestType.basicSync, exception, failing safe:" + ex2.ToString());
					}
					try
					{
						if (asObject["p"]["drft"] != null)
						{
							SceneLobbyManager2.dailyRewardFireTime = asObject["p"]["drft"].AsInt;
						}
						else
						{
							SceneLobbyManager2.dailyRewardFireTime = 86400;
						}
					}
					catch (Exception ex3)
					{
						DPGJIJGOCIC.ANOPFDLPKGC("BackendRequestType.basicSync, exception, failing safe:" + ex3.ToString());
						SceneLobbyManager2.dailyRewardFireTime = 86400;
					}
					if (asObject["p"]["eml"] != null)
					{
						AKLFPGMDKLA.EHBBFMCILPC.EGBMBHJGPMA = asObject["p"]["eml"];
					}
					else
					{
						AKLFPGMDKLA.EHBBFMCILPC.EGBMBHJGPMA = "";
					}
					if (asObject["p"]["psk"] != null)
					{
						AKLFPGMDKLA.EHBBFMCILPC.IPEMNDHJBHK = asObject["p"]["psk"];
					}
					if (asObject["p"]["off"] != null)
					{
						AKLFPGMDKLA.EHBBFMCILPC.DAAHGKPHIPO(asObject["p"]["off"].AsArray);
					}
					if (asObject["p"]["dr"] != null)
					{
						AKLFPGMDKLA.EHBBFMCILPC.JMEMHOGKKCP(asObject["p"]["dr"].AsObject);
					}
					if (asObject["p"]["rr"] != null)
					{
						AKLFPGMDKLA.EHBBFMCILPC.IKOCNPFLOPD(asObject["p"]["rr"].AsObject);
					}
					if (asObject["p"]["iaps"] != null)
					{
						AKLFPGMDKLA.EHBBFMCILPC.DJKLDDLCNKI = DPGJIJGOCIC.POHBFGLLKFD(asObject["p"]["iaps"].AsArray);
					}
					if (asObject["p"]["colcds"] != null)
					{
						AKLFPGMDKLA.EHBBFMCILPC.FBCFOIOCOEC(asObject["p"]["colcds"].AsArray);
					}
					if (asObject["p"]["gftcds"] != null)
					{
						AKLFPGMDKLA.EHBBFMCILPC.ILNLMCECNNM(asObject["p"]["gftcds"].AsArray);
					}
					if (asObject["p"]["upgcds"] != null)
					{
						AKLFPGMDKLA.EHBBFMCILPC.BKNAPDIHNOG(asObject["p"]["upgcds"].AsArray);
					}
					if (asObject["p"]["ulsk"] != null)
					{
						AKLFPGMDKLA.EHBBFMCILPC.KFAJNOOEAPB(asObject["p"]["ulsk"].AsArray);
					}
					if (asObject["p"]["nsktk"] != null)
					{
						AKLFPGMDKLA.EHBBFMCILPC.POMNOOBNDED(asObject["p"]["nsktk"].AsArray);
					}
					if (asObject["p"]["collpt"] != null)
					{
						AKLFPGMDKLA.EHBBFMCILPC.EKBICKBKHFI(asObject["p"]["collpt"].AsArray);
					}
					if (asObject["p"]["colskt"] != null)
					{
						AKLFPGMDKLA.EHBBFMCILPC.KCEOCFNHABG(asObject["p"]["colskt"].AsArray);
					}
					if (asObject["p"]["apb"] != null)
					{
						ODLJHDIGLGO.BAMHPOCKBML(asObject["p"]["apb"].AsArray);
					}
					LJNMIPMNOKF.EHBBFMCILPC.DENIEGBICKJ();
					AKLFPGMDKLA.EHBBFMCILPC.ODMKLADKHMO = new LDLLJFOJCDF(asObject["p"]["h"].AsInt);
					this.BFAAELGOIGN(asObject["p"]);
					AKLFPGMDKLA.EHBBFMCILPC.KLPBIGJBOBE = asObject["p"]["isp"].AsInt;
					AKLFPGMDKLA.EHBBFMCILPC.JHDDPLAMOPK = asObject["p"]["drs2"].AsInt;
					AKLFPGMDKLA.EHBBFMCILPC.MPMKMCJFHOG = new LDLLJFOJCDF(asObject["p"]["e"].AsInt);
					SceneLobbyManager2.energyFireTime = asObject["p"]["eft"].AsInt;
					AKLFPGMDKLA.EHBBFMCILPC.ABGNIKKFFAC = new LDLLJFOJCDF(asObject["p"]["spns"].AsInt);
					AKLFPGMDKLA.EHBBFMCILPC.DJLLDNNIMMK = new LDLLJFOJCDF(asObject["p"]["dospns"].AsInt);
					SceneLobbyManager2.spinsFireTime = (WheelItem.spinsFireTime = asObject["p"]["sft"].AsInt);
					AKLFPGMDKLA.EHBBFMCILPC.BKADBDBHFCP = DPGJIJGOCIC.DDNFIDBDEGC(asObject["p"]["gcdsch"].AsArray);
					AKLFPGMDKLA.EHBBFMCILPC.KCFMAEFDGPK = asObject["p"]["iat0"].AsInt;
					AKLFPGMDKLA.EHBBFMCILPC.PPIBBJPMJBN = asObject["p"]["iat1"].AsInt;
					AKLFPGMDKLA.EHBBFMCILPC.PANBDFNFFJE = asObject["p"]["iat2"].AsInt;
					AKLFPGMDKLA.EHBBFMCILPC.DNFICKOIFEM = asObject["p"]["iat3"].AsInt;
					if (asObject["p"]["adsvc"] != null)
					{
						AKLFPGMDKLA.EHBBFMCILPC.ECPKIEMGLNN = asObject["p"]["adsvc"].AsInt;
					}
					if (asObject["p"]["sp0"] != null)
					{
						AKLFPGMDKLA.EHBBFMCILPC.OJNBAMPGBLJ = new LDLLJFOJCDF(asObject["p"]["sp0"].AsInt);
					}
					if (asObject["p"]["sp1"] != null)
					{
						AKLFPGMDKLA.EHBBFMCILPC.DOFKEHNPCIJ = new LDLLJFOJCDF(asObject["p"]["sp1"].AsInt);
					}
					if (asObject["p"]["sp2"] != null)
					{
						AKLFPGMDKLA.EHBBFMCILPC.PBEPCNFADAA = new LDLLJFOJCDF(asObject["p"]["sp2"].AsInt);
					}
					if (asObject["p"]["nfcss"] != null)
					{
						AKLFPGMDKLA.EHBBFMCILPC.DPIMKIDKOOI();
						AKLFPGMDKLA.EHBBFMCILPC.NKAMGBCGCPM = true;
					}
					if (asObject["p"]["nspsci"] != null)
					{
						AKLFPGMDKLA.EHBBFMCILPC.GIJOJGMJKKG = asObject["p"]["nspsci"].AsInt;
					}
					AKLFPGMDKLA.EHBBFMCILPC.FDJKFAOBCOM = asObject["p"]["ahash"];
					try
					{
						if (asObject["p"]["wph"] != null)
						{
							JSONArray asArray2 = asObject["p"]["wph"].AsArray;
							for (int k = 0; k < asArray2.Count; k++)
							{
								string ihcgmfbcmoo = asArray2[k];
								OCBIOPOEENJ ocbiopoeenj = CJEKEHDEBLM.EHBBFMCILPC.PDJKPFLHFLO(ihcgmfbcmoo);
								if (ocbiopoeenj != null)
								{
									Dictionary<string, object> dictionary = new Dictionary<string, object>();
									dictionary.Add("af_revenue", ocbiopoeenj.JKBLBOAHJDE);
									dictionary.Add("af_currency", "USD");
									dictionary.Add("af_quantity", "1");
									dictionary.Add("af_content_id", ocbiopoeenj.DEJCCBNPFEC);
									dictionary.Add("af_order_id", DPGJIJGOCIC.IIIFGKFBBEP());
									AppsFlyerManagerBridge.EHBBFMCILPC.SendEvent("af_purchase", dictionary);
									AKLFPGMDKLA.EHBBFMCILPC.OPDFHANCOIF(ocbiopoeenj.DEJCCBNPFEC);
									AKLFPGMDKLA.EHBBFMCILPC.OPDFHANCOIF(ocbiopoeenj.DEJCCBNPFEC.Replace("_web", ""));
								}
							}
						}
					}
					catch (Exception ex4)
					{
						DPGJIJGOCIC.ANOPFDLPKGC("BackendOperationsManager.ProcessApp42Success() - exception when processing the web purchases history:" + ex4.ToString());
					}
					try
					{
						if (asObject["p"]["subrnw"] != null)
						{
							JSONArray asArray3 = asObject["p"]["subrnw"].AsArray;
							for (int l = 0; l < asArray3.Count; l++)
							{
								JSONObject asObject2 = asArray3[l].AsObject;
								string text = asObject2["sku"];
								OCBIOPOEENJ ocbiopoeenj2 = CJEKEHDEBLM.EHBBFMCILPC.PDJKPFLHFLO(text);
								if (ocbiopoeenj2 == null && text.Contains(KDCJJBLGCBH.EHBBFMCILPC.HHONCLBBHPG("")))
								{
									ocbiopoeenj2 = CJEKEHDEBLM.EHBBFMCILPC.PDJKPFLHFLO(KDCJJBLGCBH.EHBBFMCILPC.HHONCLBBHPG(DPGJIJGOCIC.AMACOOGPPEC(text)));
								}
								if (ocbiopoeenj2 != null)
								{
									Dictionary<string, object> dictionary2 = new Dictionary<string, object>();
									dictionary2.Add("af_revenue", ocbiopoeenj2.JKBLBOAHJDE);
									dictionary2.Add("af_currency", "USD");
									dictionary2.Add("af_quantity", "1");
									dictionary2.Add("af_content_id", asObject2["sku"]);
									dictionary2.Add("af_order_id", asObject2["order"]);
									AppsFlyerManagerBridge.EHBBFMCILPC.SendEvent("af_purchase", dictionary2);
									Dictionary<string, object> dictionary3 = new Dictionary<string, object>();
									dictionary3.Add("af_content_id", asObject2["sku"]);
									dictionary3.Add("af_order_id", asObject2["order"]);
									dictionary3.Add("renewal", true);
									AppsFlyerManagerBridge.EHBBFMCILPC.SendEvent("af_subscribe", dictionary3);
								}
							}
						}
					}
					catch (Exception ex5)
					{
						DPGJIJGOCIC.ANOPFDLPKGC("BackendOperationsManager.ProcessApp42Success() - exception when processing the subscriptions renewals:" + ex5.ToString());
					}
					if (asObject["p"]["ishof"] != null)
					{
						AKLFPGMDKLA.EHBBFMCILPC.DCIPLNCLIMF = asObject["p"]["ishof"].AsInt;
					}
					int num = AKLFPGMDKLA.EHBBFMCILPC.DHFJGFHBIOH(JFGBECHLPGI.hardCurrency);
					int num2 = AKLFPGMDKLA.EHBBFMCILPC.DHFJGFHBIOH(JFGBECHLPGI.energy);
					if (num > 0 || num2 > 0)
					{
						AOBJLALDBAA.EHBBFMCILPC.EGELHPJBAIC("OnApplicationFocusNeedToUpdateCurrency", 0f);
					}
					break;
				}
				case KAPNKGFMPDC.saveSync:
					AKLFPGMDKLA.EHBBFMCILPC.JHLHHFCMOEA(asObject["p"]["unsynced"].AsArray);
					if (asObject["p"]["unsynced"] == null || asObject["p"]["unsynced"].AsArray.Count == 0)
					{
						BackendOperationsManager.IHFCACMNGEA = Time.realtimeSinceStartup;
					}
					break;
				case KAPNKGFMPDC.startPlayChapter:
				{
					JSONObject jsonobject = this.MIDDKNEEGNK(KAPNKGFMPDC.startPlayChapter, asObject);
					if (!(jsonobject == null))
					{
						SceneLobbyManager2.startPlayChapterBackendOperationResult = jsonobject["rsl"].AsInt;
						SceneStoryManager.chapterSecurityKey = ((jsonobject["sk"] != null) ? jsonobject["sk"] : DPGJIJGOCIC.MKJLJPMEPCC());
						JSONArray asArray4 = jsonobject["chsf"].AsArray;
						SceneStoryManager.freePremiumChoicesFallback.Clear();
						SceneStoryManager.loungePremiumChoicesHistoryState = 0;
						if (null != asArray4)
						{
							for (int m = 0; m < asArray4.Count; m++)
							{
								SceneStoryManager.freePremiumChoicesFallback.Add(asArray4[m]);
							}
						}
						JSONArray asArray5 = jsonobject["chs"].AsArray;
						SceneStoryManager.freePremiumChoices.Clear();
						if (null != asArray5)
						{
							for (int n = 0; n < asArray5.Count; n++)
							{
								SceneStoryManager.freePremiumChoices.Add(asArray5[n]);
							}
						}
						if (jsonobject["cv"] != null)
						{
							HLDNEMHDEDH.OOJDEPAGNJB(jsonobject["cv"].AsArray);
						}
						if (jsonobject["ach"] != null)
						{
							SceneStoryManager.achievements = jsonobject["ach"].AsArray;
						}
					}
					break;
				}
				case KAPNKGFMPDC.premiumChoice:
				{
					JSONObject jsonobject2 = this.MIDDKNEEGNK(KAPNKGFMPDC.premiumChoice, asObject);
					if (!(jsonobject2 == null))
					{
						SceneStoryManager.premiumChoiceBackendOperationResult = jsonobject2["rsl"].AsInt;
						SceneStoryManager.premiumChoiceBackendOperationResult2 = jsonobject2["rsl2"].AsInt;
						SceneStoryManager.premiumChoiceBackendOperationResultKey = jsonobject2["rsl3"];
						SceneStoryManager.choiceSecurityKeyList = ((jsonobject2["sk"] != null) ? DPGJIJGOCIC.POHBFGLLKFD(jsonobject2["sk"].AsArray) : DPGJIJGOCIC.DACGCCLIJHJ(SceneStoryManager.choiceSecurityIdList.Count));
					}
					break;
				}
				case KAPNKGFMPDC.getGeneralBalance:
					KDCJJBLGCBH.EHBBFMCILPC.BAMHPOCKBML(asObject["p"]["generalBalance"].AsArray);
					EEIBKLDNBAP.PKPDLCOKNMI();
					AssetsManager.EHBBFMCILPC.SetMaxNumberOfParallelDownloads(KDCJJBLGCBH.EHBBFMCILPC.GAOBDHNPING());
					break;
				case KAPNKGFMPDC.checkForUpdates:
					AKLFPGMDKLA.EHBBFMCILPC.NNEFJNGKJMK = asObject["p"]["minr"].AsInt;
					AKLFPGMDKLA.EHBBFMCILPC.OHLMJHHMDJF = asObject["p"]["maxr"].AsInt;
					AKLFPGMDKLA.EHBBFMCILPC.PCMNOPFHKDJ = asObject["p"]["maxrf"].AsInt;
					break;
				case KAPNKGFMPDC.accountSuspended:
					if (asObject["p"]["ec"] != null)
					{
						AKLFPGMDKLA.EHBBFMCILPC.NHBLMCJBLAC = asObject["p"]["ec"].AsInt;
					}
					if (AKLFPGMDKLA.EHBBFMCILPC.NHBLMCJBLAC == 0)
					{
						AKLFPGMDKLA.EHBBFMCILPC.MLLOENOIKGA = true;
						AKLFPGMDKLA.EHBBFMCILPC.BNGHKCHKMPB = 0;
						if (asObject["p"]["time"] != null)
						{
							AKLFPGMDKLA.EHBBFMCILPC.BNGHKCHKMPB = asObject["p"]["time"].AsInt;
						}
						if (!SceneLobbyManager2.lobbyIsLoading)
						{
							AppManager.EHBBFMCILPC.RestartApp(true, false);
						}
					}
					else
					{
						FirebaseAnalyticsManager.EHBBFMCILPC.LogEvent(false, AGEHCPDNBFD.coVerif.ToString(), FFPHBMFGCNN.coVerfailed.ToString(), "", false, false);
						AKLFPGMDKLA.EHBBFMCILPC.NHBLMCJBLAC = 0;
						CommonUserInterface.EHBBFMCILPC.HideConnectingAnimation();
						AppleSignInManager.EHBBFMCILPC.LogOut();
						FacebookManager.EHBBFMCILPC.LogOut();
						GooglePlayServicesManager.EHBBFMCILPC.LogOut();
						SteamSignInManager.EHBBFMCILPC.LogOut();
						AKLFPGMDKLA.EHBBFMCILPC.IJHHMHAEKKE();
						BackendOperationsManager.IHFCACMNGEA = -1f;
						SceneRestartManager.clearProfile = true;
						KHPGPLAMAIN.ADCLBEPMMCG = JAMPPNPOJJG.full;
						EEIBKLDNBAP.ONMPPJOGCDO(false);
						EEIBKLDNBAP.IJHHMHAEKKE();
						AppManager.EHBBFMCILPC.RestartApp(true, false);
					}
					break;
				case KAPNKGFMPDC.getIncentAdReward:
					AKLFPGMDKLA.EHBBFMCILPC.KBKOLEJEEGH();
					SceneLobbyManager2.incentAdResultRewardType = asObject["p"]["rwt"].AsInt;
					SceneLobbyManager2.incentAdResultAmount = (SceneRewardManager.incentAdResultAmount = asObject["p"]["amt"].AsInt);
					break;
				case KAPNKGFMPDC.getStartedChapters:
					AKLFPGMDKLA.EHBBFMCILPC.IFGFLLHMLLB(asObject["p"]["sc"].AsArray);
					break;
				case KAPNKGFMPDC.getLiveEvents:
					if (asObject["p"]["le"] != null && asObject["ched"] == null)
					{
						LiveEventsManager.EHBBFMCILPC.Initialize(asObject["p"]["le"].AsArray);
					}
					break;
				case KAPNKGFMPDC.getStoryRankings:
					try
					{
						PLBBPHIJMAH.IJHHMHAEKKE();
						if (asObject["p"]["votes"] != null)
						{
							PLBBPHIJMAH.OMAICGNPPLF(asObject["p"]["votes"].AsArray);
						}
						break;
					}
					catch (Exception aklgbjkdomm2)
					{
						DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm2);
						break;
					}
					goto IL_884;
				case KAPNKGFMPDC.forgetAccount:
					AKLFPGMDKLA.EHBBFMCILPC.CDFKCAKGOAH = (asObject["p"]["rsl"].AsInt == 1);
					AKLFPGMDKLA.EHBBFMCILPC.KBKOLEJEEGH();
					break;
				case KAPNKGFMPDC.consumePromoCode:
					PromoCodesManager.backendOperationResult = asObject["p"]["rsl"].AsInt;
					break;
				case KAPNKGFMPDC.getSocialStatsAvatar:
					try
					{
						if (asObject["p"]["top"] != null)
						{
							int asInt2 = asObject["p"]["top"].AsInt;
							if (SceneAvatarManager.topPercent > 0 && SceneAvatarManager.topPercent <= 100 && asInt2 > 0 && asInt2 <= 100 && SceneAvatarManager.topPercentActiveStory >= 0 && SceneAvatarManager.topPercentActiveStory == AKLFPGMDKLA.EHBBFMCILPC.GLKNOFHEBKN)
							{
								SceneAvatarManager.topPercentDifference = SceneAvatarManager.topPercent - asInt2;
							}
							else
							{
								SceneAvatarManager.topPercentDifference = 0;
							}
							SceneAvatarManager.topPercent = asInt2;
							SceneAvatarManager.topPercentActiveStory = AKLFPGMDKLA.EHBBFMCILPC.GLKNOFHEBKN;
						}
						break;
					}
					catch (Exception aklgbjkdomm3)
					{
						DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm3);
						break;
					}
					goto IL_25F;
				case KAPNKGFMPDC.getUserPublicProfile:
					goto IL_25F;
				case KAPNKGFMPDC.achievementsSync:
					AKLFPGMDKLA.EHBBFMCILPC.GFDMIHHNFDA = "";
					AKLFPGMDKLA.EHBBFMCILPC.OCMDGMFAMJB = "";
					if (asObject["p"]["ach"] != null)
					{
						SceneStoryManager.achievements = asObject["p"]["ach"].AsArray;
					}
					if (asObject["p"]["h"] != null)
					{
						SceneStoryManager.achievementSyncReward = asObject["p"]["h"].AsInt;
					}
					break;
				case KAPNKGFMPDC.consumeEnergy:
					SceneStoryManager.consumeEnergyBackendOperationResult = asObject["p"]["rsl"].AsInt;
					break;
				case KAPNKGFMPDC.getHallOfFame:
					goto IL_55E;
				case KAPNKGFMPDC.getCardsBalance:
					GDJPPKAMIFL.EHBBFMCILPC.BAMHPOCKBML(asObject["p"]["cardsBalance"].AsArray);
					break;
				case KAPNKGFMPDC.getCardVolumesBalance:
					MEBMEBKKCKA.EHBBFMCILPC.BAMHPOCKBML(asObject["p"]["cardVolumesBalance"].AsArray);
					break;
				case KAPNKGFMPDC.getDropChancesBalance:
					AKLFMGKJLJN.EHBBFMCILPC.BAMHPOCKBML(asObject["p"]["dropChancesBalance"].AsArray);
					break;
				case KAPNKGFMPDC.breakCard:
					ProfileItem2.breakCardsResult = asObject["p"]["rsl"].AsInt;
					if (ProfileItem2.breakCardsResult > 0 && asObject["p"]["brsl"] != null)
					{
						ProfileItem2.breakCardSpecialCurrenciesReward = DPGJIJGOCIC.DDNFIDBDEGC(asObject["p"]["brsl"].AsArray);
					}
					break;
				case KAPNKGFMPDC.spinWheel:
					WheelItem.spinWheelResult = asObject["p"]["rsl"].AsInt;
					if (WheelItem.spinWheelResult > 0)
					{
						if (asObject["p"]["it"] != null)
						{
							WheelItem.spinWheelReward = asObject["p"]["it"].AsInt;
							if (asObject["p"]["itsub"] != null)
							{
								WheelItem.spinWheelRewardSubcategory = asObject["p"]["itsub"].AsInt;
							}
							else
							{
								WheelItem.spinWheelRewardSubcategory = 0;
							}
							if (asObject["p"]["itsubv"] != null)
							{
								WheelItem.spinWheelRewardSubcategoryValue = asObject["p"]["itsubv"].AsInt;
							}
							else
							{
								WheelItem.spinWheelRewardSubcategoryValue = 0;
							}
						}
						if (asObject["p"]["a"] != null)
						{
							WheelItem.spinWheelAmount = asObject["p"]["a"].AsInt;
						}
						if (asObject["p"]["cid"] != null)
						{
							WheelItem.spinWheelCardIndex = asObject["p"]["cid"].AsInt;
						}
					}
					break;
				case KAPNKGFMPDC.unlockCardsVolume:
					ProfileItem2.unlockCardWithSpecialCurrencyResult = asObject["p"]["rsl"].AsInt;
					break;
				case KAPNKGFMPDC.unlockNpcSkin:
					SceneLoungeManager.unlockNpcSkinResult = asObject["p"]["rsl"].AsInt;
					SceneLoungeManager.unlockNpcSkinError = ((asObject["p"]["err"] != null) ? asObject["p"]["err"].AsInt : 0);
					break;
				case KAPNKGFMPDC.upgradeToGiftCard:
					ProfileItem2.upgradeToGiftCardResult = asObject["p"]["rsl"].AsInt;
					break;
				case KAPNKGFMPDC.updateUserPublicProfileFriends:
					if (asObject["p"]["notgenuine"] != null)
					{
						AOBJLALDBAA.EHBBFMCILPC.EGELHPJBAIC("OnLobbyManInTheMiddleAttackDetected", 0f);
						AOBJLALDBAA.EHBBFMCILPC.EGELHPJBAIC("OnStoryManInTheMiddleAttackDetected", 0f);
					}
					else if (asObject["p"]["frds"] != null && AKLFPGMDKLA.EHBBFMCILPC.OKGGLHOCENC != null)
					{
						AKLFPGMDKLA.EHBBFMCILPC.OKGGLHOCENC.JNNBNNDOGIM.CLODNMBHLLI = asObject["p"]["frds"].AsArray;
					}
					break;
				case KAPNKGFMPDC.getMessagingHistory:
					if (asObject["p"]["notgenuine"] != null)
					{
						AOBJLALDBAA.EHBBFMCILPC.EGELHPJBAIC("OnLobbyManInTheMiddleAttackDetected", 0f);
						AOBJLALDBAA.EHBBFMCILPC.EGELHPJBAIC("OnStoryManInTheMiddleAttackDetected", 0f);
					}
					else
					{
						ProfileItem2.backendMessagingHistoryJSONArrayResponse = asObject["p"]["msh"].AsArray;
					}
					break;
				case KAPNKGFMPDC.getSketchesBalance:
					FANFNBCJJDA.EHBBFMCILPC.BAMHPOCKBML(asObject["p"]["sketchesBalance"].AsArray);
					break;
				case KAPNKGFMPDC.getUserSketches:
					HAGEHPPOPGH.EHBBFMCILPC.PKNKLEMENMN((CEEIOOODMKK)asObject["p"]["src"].AsInt, asObject["p"]["sketches"].AsObject, false);
					break;
				case KAPNKGFMPDC.publishUserSketch:
					SketchesItem.publishSketchBackendResult = asObject["p"]["rsl"].AsInt;
					SketchesItem.publishSketchBackendError = asObject["p"]["err"].AsInt;
					HAGEHPPOPGH.EHBBFMCILPC.PKNKLEMENMN(CEEIOOODMKK.sketchesPageEditorPublished, asObject["p"]["sketches"].AsObject, true);
					break;
				case KAPNKGFMPDC.getLiveOffers:
					if (asObject["p"]["lo"] != null && asObject["ched"] == null)
					{
						DNPIKPDMKKI.BAMHPOCKBML(asObject["p"]["lo"].AsArray);
					}
					break;
				case KAPNKGFMPDC.undoPremiumChoice:
				{
					JSONObject jsonobject3 = this.MIDDKNEEGNK(KAPNKGFMPDC.undoPremiumChoice, asObject);
					if (!(jsonobject3 == null))
					{
						SceneStoryManager.premiumChoiceBackendOperationResultKey = jsonobject3["rsl3"];
					}
					break;
				}
				case KAPNKGFMPDC.saveChapterSnapshots:
					if (asObject["p"]["synsnap"] != null)
					{
						AKLFPGMDKLA.EHBBFMCILPC.EAPNBGDAILG(asObject["p"]["synsnap"].AsArray);
					}
					break;
				case KAPNKGFMPDC.getChapterSnapshots:
					if (asObject["p"]["snap"] != null)
					{
						AKLFPGMDKLA.EHBBFMCILPC.HHIFKFJNBII(asObject["p"]["aind"].AsInt, asObject["p"]["sltind"].AsInt, asObject["p"]["snap"].AsArray);
					}
					break;
				case KAPNKGFMPDC.saveAvatarCollections:
					goto IL_169A;
				case KAPNKGFMPDC.getAvatarCollections:
					if (asObject["p"]["coll2"] != null && null != AssetsManager.EHBBFMCILPC.GetSceneAvatarManager(0))
					{
						AssetsManager.EHBBFMCILPC.GetSceneAvatarManager(0).ProcessBackendGetAvatarCollectionsResponse(asObject["p"]["coll2"].AsArray);
					}
					break;
				case KAPNKGFMPDC.backendMaintenance:
					AKLFPGMDKLA.EHBBFMCILPC.CBOKIJMGNFH = true;
					AKLFPGMDKLA.EHBBFMCILPC.BLJDFLHCEDE = 0;
					if (asObject["p"]["mnth"] != null)
					{
						AKLFPGMDKLA.EHBBFMCILPC.BLJDFLHCEDE = asObject["p"]["mnth"].AsInt;
					}
					if (!SceneLobbyManager2.lobbyIsLoading)
					{
						AppManager.EHBBFMCILPC.RestartApp(true, false);
					}
					break;
				case KAPNKGFMPDC.getPremiumChoicesHistory:
					try
					{
						if (asObject["p"]["chl"] != null)
						{
							JSONArray asArray6 = asObject["p"]["chl"].AsArray;
							for (int num3 = 0; num3 < asArray6.Count; num3++)
							{
								string text2 = asArray6[num3];
								if (text2 != null && text2.Length > 0 && !SceneStoryManager.freePremiumChoicesFallback.Contains(text2))
								{
									SceneStoryManager.freePremiumChoicesFallback.Add(text2);
								}
							}
						}
						break;
					}
					catch (Exception aklgbjkdomm4)
					{
						DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm4);
						break;
					}
					goto IL_169A;
				case KAPNKGFMPDC.getNpcSkinShopBalance:
					if (asObject["p"] == null || asObject["p"]["npcSkinShopBalance"] == null)
					{
						DPGJIJGOCIC.ADFCDFHBDAF("getNpcSkinShopBalance answered without a payload and no cached copy - shop rows unchanged");
					}
					else
					{
						KKLFGEHAMMC.EHBBFMCILPC.BAMHPOCKBML(asObject["p"]["npcSkinShopBalance"].AsArray);
						if (null != AssetsManager.EHBBFMCILPC && null != AssetsManager.EHBBFMCILPC.lobbyDataAsset && AssetsManager.EHBBFMCILPC.lobbyDataAsset.MFMJHIFAOHE() != null)
						{
							AssetsManager.EHBBFMCILPC.lobbyDataAsset.MFMJHIFAOHE().NHDMCKPHEIA();
						}
					}
					break;
				}
				IL_262F:
				j++;
				continue;
				IL_25F:
				try
				{
					if (asObject["p"]["notgenuine"] != null)
					{
						AKLFPGMDKLA.EHBBFMCILPC.CIPCINKGILF = false;
						AKLFPGMDKLA.EHBBFMCILPC.OKGGLHOCENC = null;
						AKLFPGMDKLA.EHBBFMCILPC.CLDBILNPMCN = null;
						AOBJLALDBAA.EHBBFMCILPC.EGELHPJBAIC("OnLobbyManInTheMiddleAttackDetected", 0f);
						AOBJLALDBAA.EHBBFMCILPC.EGELHPJBAIC("OnStoryManInTheMiddleAttackDetected", 0f);
					}
					else
					{
						if (AKLFPGMDKLA.EHBBFMCILPC.OKGGLHOCENC != null && AKLFPGMDKLA.EHBBFMCILPC.OFNHOICCBAM.Count > 0 && asObject["p"]["syn"] != null)
						{
							DPGJIJGOCIC.NFIDPOMCNLP("RequestGetUserPublicProfile.ProcessApp42Success(): getUserPublicProfile: client cutscenes (" + AKLFPGMDKLA.EHBBFMCILPC.OFNHOICCBAM.Count.ToString() + ") synced, clearing data.");
							AKLFPGMDKLA.EHBBFMCILPC.OFNHOICCBAM.Clear();
						}
						AKLFPGMDKLA.EHBBFMCILPC.ELAGGOHBOOA = new JSONObject();
						if (asObject["p"]["ops"] != null)
						{
							AKLFPGMDKLA.EHBBFMCILPC.ELAGGOHBOOA = asObject["p"]["ops"].AsObject;
						}
						if (asObject["p"]["gsec"] != null)
						{
							AOBJLALDBAA.EHBBFMCILPC.EGELHPJBAIC("OnUpdateSocialEventsCounter", asObject["p"]["gsec"].AsInt);
						}
						if (asObject["p"]["profRand"] != null)
						{
							AKLFPGMDKLA.EHBBFMCILPC.CLDBILNPMCN = new PMEPALPCEAF();
							AKLFPGMDKLA.EHBBFMCILPC.CLDBILNPMCN.FGJPKGLOGNC(asObject["p"]["profRand"].AsObject);
						}
						if (asObject["p"]["prof"] != null)
						{
							AKLFPGMDKLA.EHBBFMCILPC.CIPCINKGILF = false;
							AKLFPGMDKLA.EHBBFMCILPC.OKGGLHOCENC = new PMEPALPCEAF();
							AKLFPGMDKLA.EHBBFMCILPC.OKGGLHOCENC.FGJPKGLOGNC(asObject["p"]["prof"].AsObject);
							if (asObject["p"]["cuta"] != null)
							{
								AKLFPGMDKLA.EHBBFMCILPC.OKGGLHOCENC.EONNDBCFGMM(asObject["p"]["cuta"].AsArray);
								try
								{
									AKLFPGMDKLA.EHBBFMCILPC.OKGGLHOCENC.IPNOKENGAPB();
								}
								catch (Exception aklgbjkdomm5)
								{
									DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm5);
								}
							}
							flag = true;
						}
						else if (asObject["p"]["modelse"] != null && !AKLFPGMDKLA.EHBBFMCILPC.CIPCINKGILF)
						{
							AKLFPGMDKLA.EHBBFMCILPC.CIPCINKGILF = (asObject["p"]["modelse"].AsInt == 1);
						}
					}
					goto IL_262F;
				}
				catch (Exception aklgbjkdomm6)
				{
					DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm6);
					goto IL_262F;
				}
				IL_55E:
				AKLFPGMDKLA.EHBBFMCILPC.AONCINPNHDD = new List<PMEPALPCEAF>();
				if (asObject["p"]["notgenuine"] != null)
				{
					AOBJLALDBAA.EHBBFMCILPC.EGELHPJBAIC("OnLobbyManInTheMiddleAttackDetected", 0f);
					AOBJLALDBAA.EHBBFMCILPC.EGELHPJBAIC("OnStoryManInTheMiddleAttackDetected", 0f);
					goto IL_262F;
				}
				if (asObject["p"]["hof"] != null)
				{
					if (ContentHallOfFamePage.hallOfFameCollectionOffsetBackend < 0)
					{
						AKLFPGMDKLA.EHBBFMCILPC.LNEPJBGFEBG(asObject["p"]["hof"].AsArray);
					}
					else
					{
						AKLFPGMDKLA.EHBBFMCILPC.BHBEOELKMOC(asObject["p"]["hof"].AsArray);
					}
				}
				if (asObject["p"]["hofcoff"] != null)
				{
					ContentHallOfFamePage.hallOfFameCollectionOffsetBackend = asObject["p"]["hofcoff"].AsInt;
					goto IL_262F;
				}
				goto IL_262F;
				IL_884:
				AKLFPGMDKLA.EHBBFMCILPC.EEHGLPEIIHD = asObject["p"]["uid"];
				if (asObject["p"]["psk"] != null)
				{
					AKLFPGMDKLA.EHBBFMCILPC.IPEMNDHJBHK = asObject["p"]["psk"];
					goto IL_262F;
				}
				goto IL_262F;
				IL_169A:
				if (asObject["p"]["syncoll2"] != null)
				{
					AKLFPGMDKLA.EHBBFMCILPC.CFDMMAOFBNC(asObject["p"]["syncoll2"].AsArray);
					goto IL_262F;
				}
				goto IL_262F;
			}
		}
		if (flag)
		{
			try
			{
				LJNMIPMNOKF.EHBBFMCILPC.KNAEAJPDGKB(GCFLILHCOEI.cardsFilterNone, -1, -1);
				IOGOGMEJCIK.EHBBFMCILPC.EPJKDCDOEMM();
				if (AssetsManager.EHBBFMCILPC.profileDataAsset2 != null)
				{
					IOGOGMEJCIK.EHBBFMCILPC.LMIGKJJBFPM();
					AKLFPGMDKLA.EHBBFMCILPC.OKGGLHOCENC.AAHPPDCDNCC();
					AKLFPGMDKLA.EHBBFMCILPC.OKGGLHOCENC.MGCCGKOEJCN(false);
					AKLFPGMDKLA.EHBBFMCILPC.OKGGLHOCENC.MGCCGKOEJCN(true);
				}
			}
			catch (Exception aklgbjkdomm7)
			{
				DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm7);
			}
		}
	}

	// Token: 0x06009263 RID: 37475 RVA: 0x0040B894 File Offset: 0x00409A94
	public void RequestUpgradeToGiftCard(string PLDNHKIKDIB, string OEFHHHJEDNJ, int LLLCDMNPKFI)
	{
		this.KCIPJMPFPBJ();
		JSONObject jsonobject = new JSONObject();
		JSONObject jsonobject2 = new JSONObject();
		jsonobject2["uid"] = AKLFPGMDKLA.EHBBFMCILPC.EEHGLPEIIHD;
		jsonobject2["cid"] = LLLCDMNPKFI.ToString();
		RSACryptoServiceProvider rsacryptoServiceProvider = new RSACryptoServiceProvider();
		try
		{
			rsacryptoServiceProvider.FromXmlString(this.BCOPCDKOINH);
		}
		catch (Exception ex)
		{
			DPGJIJGOCIC.ANOPFDLPKGC("BackendOperationsManager.RequestUpgradeToGiftCard, exception while initializing RSACryptoServiceProvider:" + ex.ToString());
		}
		if (rsacryptoServiceProvider != null)
		{
			try
			{
				byte[] inArray = rsacryptoServiceProvider.Encrypt(Encoding.ASCII.GetBytes(jsonobject2.ToString()), false);
				rsacryptoServiceProvider.Dispose();
				jsonobject["spld"] = Convert.ToBase64String(inArray);
			}
			catch (Exception aklgbjkdomm)
			{
				jsonobject = new JSONObject();
				DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
			}
		}
		App42Manager.EHBBFMCILPC.QueueCustomCode(KAPNKGFMPDC.basicSync.ToString(), this.KGGAALBOEAB(false, true)).RunCustomCode(KAPNKGFMPDC.upgradeToGiftCard.ToString(), jsonobject, 2, KBOJLHAJPCP.KEHGALKGMKD, null, PLDNHKIKDIB, OEFHHHJEDNJ, false, "");
	}

	// Token: 0x170002B9 RID: 697
	// (get) Token: 0x06009264 RID: 37476 RVA: 0x0040B9C0 File Offset: 0x00409BC0
	private string KFPMLOMPNGE
	{
		get
		{
			return JNDBKHJGEMC.HKLDMPDHBEL;
		}
	}

	// Token: 0x06009265 RID: 37477 RVA: 0x0040B9C8 File Offset: 0x00409BC8
	public static float IPOJDFGHION(KAPNKGFMPDC EGLBLPKFEOI)
	{
		if (!App42Manager.EHBBFMCILPC.CanKillInfiniteRequestPrematureBasedOnMedianRequestsLifeTime())
		{
			switch (EGLBLPKFEOI)
			{
			case KAPNKGFMPDC.none:
			case KAPNKGFMPDC.changeOwner:
			case KAPNKGFMPDC.signIn:
			case KAPNKGFMPDC.basicSync:
			case KAPNKGFMPDC.undoPremiumChoice:
			case KAPNKGFMPDC.saveChapterSnapshots:
			case KAPNKGFMPDC.getChapterSnapshots:
			case KAPNKGFMPDC.saveAvatarCollections:
				return KBOJLHAJPCP.MMAPBAJLBAF;
			case KAPNKGFMPDC.registerUser:
			case KAPNKGFMPDC.getDepot:
			case KAPNKGFMPDC.getDefaultBundles:
			case KAPNKGFMPDC.getGeneralBalance:
			case KAPNKGFMPDC.accountSuspended:
			case KAPNKGFMPDC.getIncentAdReward:
			case KAPNKGFMPDC.consumePromoCode:
			case KAPNKGFMPDC.getSocialStatsAvatar:
			case KAPNKGFMPDC.getUserPublicProfile:
			case KAPNKGFMPDC.emailUnsubscribe:
			case KAPNKGFMPDC.getDropChancesBalance:
			case KAPNKGFMPDC.breakCard:
			case KAPNKGFMPDC.spinWheel:
			case KAPNKGFMPDC.unlockCardsVolume:
			case KAPNKGFMPDC.unlockNpcSkin:
			case KAPNKGFMPDC.upgradeToGiftCard:
			case KAPNKGFMPDC.updateUserPublicProfileFriends:
			case KAPNKGFMPDC.getSketchesBalance:
			case KAPNKGFMPDC.getUserSketches:
				return KBOJLHAJPCP.LEBOLNGELFB;
			}
			return KBOJLHAJPCP.OIKBFGBEDBA;
		}
		if (EGLBLPKFEOI <= KAPNKGFMPDC.changeOwner)
		{
			if (EGLBLPKFEOI != KAPNKGFMPDC.registerUser && EGLBLPKFEOI - KAPNKGFMPDC.signInOrRegister != 0)
			{
				goto IL_2E;
			}
		}
		else if (EGLBLPKFEOI != (KAPNKGFMPDC)(-8) && EGLBLPKFEOI - (KAPNKGFMPDC)96 > 3)
		{
			goto IL_2E;
		}
		return KBOJLHAJPCP.MMAPBAJLBAF;
		IL_2E:
		if (App42Manager.EHBBFMCILPC.GetAverageRequestLifeTime() > 1302f)
		{
			return App42Manager.EHBBFMCILPC.KCPKEPFAELG() + KBOJLHAJPCP.LKOGJFDMMOH;
		}
		return KBOJLHAJPCP.OIKBFGBEDBA;
	}

	// Token: 0x040028EC RID: 10476
	public string onBackendValidateTransactionSuccess = "";

	// Token: 0x040028ED RID: 10477
	public string onBackendValidateTransactionFailed = "";

	// Token: 0x040028EE RID: 10478
	private static BackendOperationsManager IKLAPGJDMNA;

	// Token: 0x040028EF RID: 10479
	private List<JMIKCLKNIJO> CCCCKKNKBML = new List<JMIKCLKNIJO>();

	// Token: 0x040028F0 RID: 10480
	private int JOIJJPLOPNK = 100000;

	// Token: 0x040028F1 RID: 10481
	public const float SAVE_SYNC_MOMENT_MIN_INTERVAL_SECONDS = 1800f;

	// Token: 0x040028F2 RID: 10482
	private static float IHFCACMNGEA = -1f;

	// Token: 0x040028F3 RID: 10483
	private static RSA JFPBNBNGMJD;

	// Token: 0x040028F4 RID: 10484
	private static readonly object JKEGDKFAGHE = new object();

	// Token: 0x040028F5 RID: 10485
	private static RSA HCJOIGDJHFO;

	// Token: 0x040028F6 RID: 10486
	private static readonly object CHAOLAJBABC = new object();

	// Token: 0x040028F7 RID: 10487
	private static RSA CHIPPLJMCOH;

	// Token: 0x040028F8 RID: 10488
	private static readonly object HCKPHKLEJJN = new object();
}
