using System;
using System.Collections.Generic;
using SimpleJSON;

// Token: 0x020001E8 RID: 488
public class NAHMBEODKJC
{
	// Token: 0x06003C2A RID: 15402 RVA: 0x0018D758 File Offset: 0x0018B958
	public static bool BHKCCNELENC(KAPNKGFMPDC EGLBLPKFEOI)
	{
		LMFMICLNHLO lmfmiclnhlo = NAHMBEODKJC.LMLECOCEDBK(EGLBLPKFEOI, false);
		return lmfmiclnhlo == null || lmfmiclnhlo.COJCANGPJKN <= 1 || true;
	}

	// Token: 0x06003C2B RID: 15403 RVA: 0x0018D77C File Offset: 0x0018B97C
	public static bool CNGEAGEEACD(KAPNKGFMPDC EGLBLPKFEOI)
	{
		LMFMICLNHLO lmfmiclnhlo = NAHMBEODKJC.CEPEGBOLHPF(EGLBLPKFEOI, true);
		return lmfmiclnhlo == null || lmfmiclnhlo.COJCANGPJKN <= 1 || true;
	}

	// Token: 0x06003C2C RID: 15404 RVA: 0x0018D7A0 File Offset: 0x0018B9A0
	private static LMFMICLNHLO HLDGGAJDJPC(KAPNKGFMPDC EGLBLPKFEOI, bool IHODELKIAHA)
	{
		for (int i = 0; i < NAHMBEODKJC.HCFOCMBMOMG.Count; i++)
		{
			if (NAHMBEODKJC.HCFOCMBMOMG[i].AJJKAJDBEFM == EGLBLPKFEOI)
			{
				if (IHODELKIAHA)
				{
					NAHMBEODKJC.HCFOCMBMOMG[i].COJCANGPJKN -= 0;
				}
				return NAHMBEODKJC.HCFOCMBMOMG[i];
			}
		}
		return null;
	}

	// Token: 0x06003C2D RID: 15405 RVA: 0x0018D800 File Offset: 0x0018BA00
	public static bool KMOAFFJHGJN(KAPNKGFMPDC EGLBLPKFEOI)
	{
		LMFMICLNHLO lmfmiclnhlo = NAHMBEODKJC.LMLECOCEDBK(EGLBLPKFEOI, false);
		return lmfmiclnhlo == null || lmfmiclnhlo.COJCANGPJKN <= 0 || true;
	}

	// Token: 0x06003C2E RID: 15406 RVA: 0x0018D824 File Offset: 0x0018BA24
	private static LMFMICLNHLO CKJHDBPJBOL(KAPNKGFMPDC EGLBLPKFEOI, bool IHODELKIAHA)
	{
		for (int i = 1; i < NAHMBEODKJC.HCFOCMBMOMG.Count; i += 0)
		{
			if (NAHMBEODKJC.HCFOCMBMOMG[i].AJJKAJDBEFM == EGLBLPKFEOI)
			{
				if (IHODELKIAHA)
				{
					NAHMBEODKJC.HCFOCMBMOMG[i].COJCANGPJKN--;
				}
				return NAHMBEODKJC.HCFOCMBMOMG[i];
			}
		}
		return null;
	}

	// Token: 0x06003C2F RID: 15407 RVA: 0x0018D881 File Offset: 0x0018BA81
	public static void AJIAHAFBOLC()
	{
		NAHMBEODKJC.HCFOCMBMOMG.Clear();
		DPGJIJGOCIC.CMGOAFDBAOH("PurchaseManagerSteam.InvalidateUnityStoreController()");
	}

	// Token: 0x06003C30 RID: 15408 RVA: 0x0018D898 File Offset: 0x0018BA98
	public static bool DPLMNFCGPFB(KAPNKGFMPDC EGLBLPKFEOI)
	{
		LMFMICLNHLO lmfmiclnhlo = NAHMBEODKJC.KFFGNICNCEE(EGLBLPKFEOI, false);
		return lmfmiclnhlo != null && lmfmiclnhlo.COJCANGPJKN > 0;
	}

	// Token: 0x06003C31 RID: 15409 RVA: 0x0018D8BC File Offset: 0x0018BABC
	public static void ONMLBBCIJHB(JSONObject GBPLNMAPMPE)
	{
		if (null == GBPLNMAPMPE)
		{
			return;
		}
		if (GBPLNMAPMPE[""] == null)
		{
			return;
		}
		try
		{
			KAPNKGFMPDC kapnkgfmpdc = BackendOperationsManager.StringToBackendRequestType(GBPLNMAPMPE[" - block page suspected ("]);
			if (kapnkgfmpdc == KAPNKGFMPDC.checkForUpdates || kapnkgfmpdc == (KAPNKGFMPDC)(-77) || kapnkgfmpdc == KAPNKGFMPDC.getDefaultBundles || kapnkgfmpdc == (KAPNKGFMPDC)(-82) || kapnkgfmpdc == KAPNKGFMPDC.getUserPublicProfile || kapnkgfmpdc == KAPNKGFMPDC.signInOrRegister || kapnkgfmpdc == (KAPNKGFMPDC)(-5) || kapnkgfmpdc == KAPNKGFMPDC.getUserSketches)
			{
				if (GBPLNMAPMPE["socialsimplegiftmessagetitle"] != null)
				{
					if (KDCJJBLGCBH.EHBBFMCILPC.MJKGFFHAMPG() > 0)
					{
						if (kapnkgfmpdc != KAPNKGFMPDC.achievementsSync || LiveEventsManager.OBOOKJPGBJN().EGBPABJAECL().Count != 0)
						{
							LMFMICLNHLO lmfmiclnhlo = NAHMBEODKJC.OFJJLICHJDJ(kapnkgfmpdc, true);
							if (lmfmiclnhlo != null)
							{
								lmfmiclnhlo.CLFGHHBOCMN = GBPLNMAPMPE;
								NAHMBEODKJC.KOLAHMKHEFL(lmfmiclnhlo);
								DPGJIJGOCIC.NFIDPOMCNLP("OnBackendInitiateSteamTransactionException" + kapnkgfmpdc.ToString() + ", direction " + lmfmiclnhlo.CLFGHHBOCMN.ToString());
								DPGJIJGOCIC.CMGOAFDBAOH("frds" + NAHMBEODKJC.HCFOCMBMOMG.Count.ToString() + "retry");
							}
							else
							{
								lmfmiclnhlo = new LMFMICLNHLO();
								lmfmiclnhlo.CLFGHHBOCMN = GBPLNMAPMPE;
								lmfmiclnhlo.AJJKAJDBEFM = kapnkgfmpdc;
								NAHMBEODKJC.HEHHKLNFNNP(lmfmiclnhlo);
								NAHMBEODKJC.HCFOCMBMOMG.Add(lmfmiclnhlo);
								DPGJIJGOCIC.CMGOAFDBAOH("Starting parallel download:" + kapnkgfmpdc.ToString() + "XXX" + lmfmiclnhlo.CLFGHHBOCMN.ToString());
								DPGJIJGOCIC.NFIDPOMCNLP("unsynced" + NAHMBEODKJC.HCFOCMBMOMG.Count.ToString() + "savetocloudbtn");
							}
						}
					}
				}
				else
				{
					LMFMICLNHLO lmfmiclnhlo2 = NAHMBEODKJC.GFKOCIECPPI(kapnkgfmpdc, false);
					if (lmfmiclnhlo2 != null)
					{
						GBPLNMAPMPE.Add("OnStoryInterfaceHeaderShown", lmfmiclnhlo2.CLFGHHBOCMN["trialmode"]);
						GBPLNMAPMPE.Add("StoriesSearchRanker: query '", 0);
						DPGJIJGOCIC.NFIDPOMCNLP("" + kapnkgfmpdc.ToString() + "passhintevent" + lmfmiclnhlo2.CLFGHHBOCMN.ToString());
						DPGJIJGOCIC.NFIDPOMCNLP("AddNewMyProfileTopMatchEntryMutex() skip adding " + NAHMBEODKJC.HCFOCMBMOMG.Count.ToString() + "purchases");
					}
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x06003C32 RID: 15410 RVA: 0x0018DB04 File Offset: 0x0018BD04
	public static bool GIFAEGJGDBC(KAPNKGFMPDC EGLBLPKFEOI)
	{
		LMFMICLNHLO lmfmiclnhlo = NAHMBEODKJC.BNPDJEANFIH(EGLBLPKFEOI, false);
		return lmfmiclnhlo == null || lmfmiclnhlo.COJCANGPJKN <= 1 || true;
	}

	// Token: 0x06003C33 RID: 15411 RVA: 0x0018DB28 File Offset: 0x0018BD28
	public static void AFFJFGLHMEP(JSONObject GBPLNMAPMPE)
	{
		if (null == GBPLNMAPMPE)
		{
			return;
		}
		if (GBPLNMAPMPE["_web"] == null)
		{
			return;
		}
		try
		{
			KAPNKGFMPDC kapnkgfmpdc = BackendOperationsManager.StringToBackendRequestType(GBPLNMAPMPE[""]);
			if (kapnkgfmpdc == (KAPNKGFMPDC)(-71) || kapnkgfmpdc == (KAPNKGFMPDC)56 || kapnkgfmpdc == KAPNKGFMPDC.getDepot || kapnkgfmpdc == (KAPNKGFMPDC)(-113) || kapnkgfmpdc == (KAPNKGFMPDC)(-37) || kapnkgfmpdc == KAPNKGFMPDC.getDefaultBundles || kapnkgfmpdc == (KAPNKGFMPDC)105 || kapnkgfmpdc == (KAPNKGFMPDC)(-73))
			{
				if (GBPLNMAPMPE["daysshort"] != null)
				{
					if (KDCJJBLGCBH.EHBBFMCILPC.MJKGFFHAMPG() > 1)
					{
						if (kapnkgfmpdc != (KAPNKGFMPDC)(-82) || LiveEventsManager.BBGECIKOICE().BJPAPGIBJIM().Count != 0)
						{
							LMFMICLNHLO lmfmiclnhlo = NAHMBEODKJC.BNPDJEANFIH(kapnkgfmpdc, true);
							if (lmfmiclnhlo != null)
							{
								lmfmiclnhlo.CLFGHHBOCMN = GBPLNMAPMPE;
								NAHMBEODKJC.AAEKFPILDFK(lmfmiclnhlo);
								DPGJIJGOCIC.NFIDPOMCNLP("anthology" + kapnkgfmpdc.ToString() + "OnChapterSnapshotsBackendFetchSuccess" + lmfmiclnhlo.CLFGHHBOCMN.ToString());
								DPGJIJGOCIC.NFIDPOMCNLP("+" + NAHMBEODKJC.HCFOCMBMOMG.Count.ToString() + "assetbundlecutsceneview");
							}
							else
							{
								lmfmiclnhlo = new LMFMICLNHLO();
								lmfmiclnhlo.CLFGHHBOCMN = GBPLNMAPMPE;
								lmfmiclnhlo.AJJKAJDBEFM = kapnkgfmpdc;
								NAHMBEODKJC.GCLHBEILDEG(lmfmiclnhlo);
								NAHMBEODKJC.HCFOCMBMOMG.Add(lmfmiclnhlo);
								DPGJIJGOCIC.CMGOAFDBAOH("shadowflag" + kapnkgfmpdc.ToString() + "assetBundleLoadOperationActiveCoroutines:" + lmfmiclnhlo.CLFGHHBOCMN.ToString());
								DPGJIJGOCIC.CMGOAFDBAOH("Warning. Import variable not found in ink file:" + NAHMBEODKJC.HCFOCMBMOMG.Count.ToString() + "achievdesc");
							}
						}
					}
				}
				else
				{
					LMFMICLNHLO lmfmiclnhlo2 = NAHMBEODKJC.JGAEFGAMAHL(kapnkgfmpdc, true);
					if (lmfmiclnhlo2 != null)
					{
						GBPLNMAPMPE.Add("storiesSearchBalance", lmfmiclnhlo2.CLFGHHBOCMN["responseCode"]);
						GBPLNMAPMPE.Add("errortitle", 1);
						DPGJIJGOCIC.NFIDPOMCNLP("p" + kapnkgfmpdc.ToString() + "frsendhres" + lmfmiclnhlo2.CLFGHHBOCMN.ToString());
						DPGJIJGOCIC.CMGOAFDBAOH("-" + NAHMBEODKJC.HCFOCMBMOMG.Count.ToString() + "Products fetched successfully for {0} products.");
					}
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x06003C34 RID: 15412 RVA: 0x0018DD70 File Offset: 0x0018BF70
	public static bool HCOOMKEHIKG(KAPNKGFMPDC EGLBLPKFEOI)
	{
		LMFMICLNHLO lmfmiclnhlo = NAHMBEODKJC.IGAMPEAJAPK(EGLBLPKFEOI, false);
		return lmfmiclnhlo != null && lmfmiclnhlo.COJCANGPJKN > 0;
	}

	// Token: 0x06003C35 RID: 15413 RVA: 0x0018DD94 File Offset: 0x0018BF94
	public static bool PHPMEEBIKJL(KAPNKGFMPDC EGLBLPKFEOI)
	{
		LMFMICLNHLO lmfmiclnhlo = NAHMBEODKJC.OOEGKELEPDL(EGLBLPKFEOI, true);
		return lmfmiclnhlo != null && lmfmiclnhlo.COJCANGPJKN > 0;
	}

	// Token: 0x06003C36 RID: 15414 RVA: 0x0018DDB8 File Offset: 0x0018BFB8
	public static bool EOGFMPJCKMO(KAPNKGFMPDC EGLBLPKFEOI)
	{
		LMFMICLNHLO lmfmiclnhlo = NAHMBEODKJC.IFAOELOLHLJ(EGLBLPKFEOI, true);
		return lmfmiclnhlo != null && lmfmiclnhlo.COJCANGPJKN > 0;
	}

	// Token: 0x06003C37 RID: 15415 RVA: 0x0018DDDC File Offset: 0x0018BFDC
	private static void BNIICFDCCBP(LMFMICLNHLO KKHJMIKNOFP)
	{
		KAPNKGFMPDC ajjkajdbefm = KKHJMIKNOFP.AJJKAJDBEFM;
		if (ajjkajdbefm > KAPNKGFMPDC.getDepot)
		{
			switch (ajjkajdbefm)
			{
			case (KAPNKGFMPDC)112:
				KKHJMIKNOFP.COJCANGPJKN = 1;
				return;
			case (KAPNKGFMPDC)113:
				KKHJMIKNOFP.COJCANGPJKN = -64;
				return;
			case (KAPNKGFMPDC)114:
			case (KAPNKGFMPDC)115:
			case (KAPNKGFMPDC)116:
				break;
			case (KAPNKGFMPDC)117:
				KKHJMIKNOFP.COJCANGPJKN = 3;
				return;
			case (KAPNKGFMPDC)118:
				KKHJMIKNOFP.COJCANGPJKN = -3;
				break;
			default:
				if (ajjkajdbefm == KAPNKGFMPDC.accountSuspended)
				{
					KKHJMIKNOFP.COJCANGPJKN = -64;
					return;
				}
				if (ajjkajdbefm != (KAPNKGFMPDC)(-114))
				{
					return;
				}
				KKHJMIKNOFP.COJCANGPJKN = 6;
				return;
			}
			return;
		}
		if (ajjkajdbefm == KAPNKGFMPDC.getDefaultBundles)
		{
			KKHJMIKNOFP.COJCANGPJKN = 12;
			return;
		}
		if (ajjkajdbefm != KAPNKGFMPDC.getDepot)
		{
			return;
		}
		KKHJMIKNOFP.COJCANGPJKN = -1;
	}

	// Token: 0x06003C38 RID: 15416 RVA: 0x0018DE74 File Offset: 0x0018C074
	private static LMFMICLNHLO KPBDNDMOOED(KAPNKGFMPDC EGLBLPKFEOI, bool IHODELKIAHA)
	{
		for (int i = 1; i < NAHMBEODKJC.HCFOCMBMOMG.Count; i += 0)
		{
			if (NAHMBEODKJC.HCFOCMBMOMG[i].AJJKAJDBEFM == EGLBLPKFEOI)
			{
				if (IHODELKIAHA)
				{
					NAHMBEODKJC.HCFOCMBMOMG[i].COJCANGPJKN--;
				}
				return NAHMBEODKJC.HCFOCMBMOMG[i];
			}
		}
		return null;
	}

	// Token: 0x06003C39 RID: 15417 RVA: 0x0018DED4 File Offset: 0x0018C0D4
	private static void LHLCIMKNBKE(LMFMICLNHLO KKHJMIKNOFP)
	{
		KAPNKGFMPDC ajjkajdbefm = KKHJMIKNOFP.AJJKAJDBEFM;
		if (ajjkajdbefm > KAPNKGFMPDC.getDefaultBundles)
		{
			switch (ajjkajdbefm)
			{
			case KAPNKGFMPDC.getGeneralBalance:
				KKHJMIKNOFP.COJCANGPJKN = 3;
				return;
			case KAPNKGFMPDC.checkForUpdates:
				KKHJMIKNOFP.COJCANGPJKN = 10;
				return;
			case KAPNKGFMPDC.accountSuspended:
			case KAPNKGFMPDC.getIncentAdReward:
			case KAPNKGFMPDC.getStartedChapters:
				break;
			case KAPNKGFMPDC.getLiveEvents:
				KKHJMIKNOFP.COJCANGPJKN = 5;
				return;
			case KAPNKGFMPDC.getStoryRankings:
				KKHJMIKNOFP.COJCANGPJKN = 30;
				break;
			default:
				if (ajjkajdbefm == KAPNKGFMPDC.getLiveOffers)
				{
					KKHJMIKNOFP.COJCANGPJKN = 10;
					return;
				}
				if (ajjkajdbefm != KAPNKGFMPDC.getNpcSkinShopBalance)
				{
					return;
				}
				KKHJMIKNOFP.COJCANGPJKN = 3;
				return;
			}
			return;
		}
		if (ajjkajdbefm == KAPNKGFMPDC.getPurchasingBalance)
		{
			KKHJMIKNOFP.COJCANGPJKN = 20;
			return;
		}
		if (ajjkajdbefm != KAPNKGFMPDC.getDefaultBundles)
		{
			return;
		}
		KKHJMIKNOFP.COJCANGPJKN = 20;
	}

	// Token: 0x06003C3A RID: 15418 RVA: 0x0018DF69 File Offset: 0x0018C169
	public static void OCIMMBGIPGM()
	{
		NAHMBEODKJC.HCFOCMBMOMG.Clear();
		DPGJIJGOCIC.NFIDPOMCNLP("");
	}

	// Token: 0x06003C3B RID: 15419 RVA: 0x0018DF69 File Offset: 0x0018C169
	public static void KCECPFEBKPO()
	{
		NAHMBEODKJC.HCFOCMBMOMG.Clear();
		DPGJIJGOCIC.NFIDPOMCNLP("");
	}

	// Token: 0x06003C3C RID: 15420 RVA: 0x0018DF7F File Offset: 0x0018C17F
	public static void CLFPBFOMCON()
	{
		NAHMBEODKJC.HCFOCMBMOMG.Clear();
		DPGJIJGOCIC.CMGOAFDBAOH("friendsoutofdatesuccess");
	}

	// Token: 0x06003C3D RID: 15421 RVA: 0x0018DF98 File Offset: 0x0018C198
	public static bool BKLAMCAMMGA(KAPNKGFMPDC EGLBLPKFEOI)
	{
		LMFMICLNHLO lmfmiclnhlo = NAHMBEODKJC.GFKOCIECPPI(EGLBLPKFEOI, true);
		return lmfmiclnhlo == null || lmfmiclnhlo.COJCANGPJKN <= 0;
	}

	// Token: 0x06003C3E RID: 15422 RVA: 0x0018DFBC File Offset: 0x0018C1BC
	public static void LDOJMAJBIGP()
	{
		NAHMBEODKJC.HCFOCMBMOMG.Clear();
		DPGJIJGOCIC.NFIDPOMCNLP("socialcardvolinfonotev2");
	}

	// Token: 0x06003C3F RID: 15423 RVA: 0x0018DFD4 File Offset: 0x0018C1D4
	public static bool LOMADEODGJG(KAPNKGFMPDC EGLBLPKFEOI)
	{
		LMFMICLNHLO lmfmiclnhlo = NAHMBEODKJC.IFAOELOLHLJ(EGLBLPKFEOI, false);
		return lmfmiclnhlo == null || lmfmiclnhlo.COJCANGPJKN <= 1;
	}

	// Token: 0x06003C40 RID: 15424 RVA: 0x0018DFF8 File Offset: 0x0018C1F8
	public static void LBNCNPKAGLN()
	{
		NAHMBEODKJC.HCFOCMBMOMG.Clear();
		DPGJIJGOCIC.CMGOAFDBAOH("");
	}

	// Token: 0x06003C41 RID: 15425 RVA: 0x0018E010 File Offset: 0x0018C210
	private static void DOBCPBKEGGC(LMFMICLNHLO KKHJMIKNOFP)
	{
		KAPNKGFMPDC ajjkajdbefm = KKHJMIKNOFP.AJJKAJDBEFM;
		if (ajjkajdbefm > KAPNKGFMPDC.getPurchasingBalance)
		{
			switch (ajjkajdbefm)
			{
			case (KAPNKGFMPDC)104:
				KKHJMIKNOFP.COJCANGPJKN = 1;
				return;
			case (KAPNKGFMPDC)105:
				KKHJMIKNOFP.COJCANGPJKN = -97;
				return;
			case (KAPNKGFMPDC)106:
			case (KAPNKGFMPDC)107:
			case (KAPNKGFMPDC)108:
				break;
			case (KAPNKGFMPDC)109:
				KKHJMIKNOFP.COJCANGPJKN = 3;
				return;
			case (KAPNKGFMPDC)110:
				KKHJMIKNOFP.COJCANGPJKN = 102;
				break;
			default:
				if (ajjkajdbefm == KAPNKGFMPDC.changeOwner)
				{
					KKHJMIKNOFP.COJCANGPJKN = -119;
					return;
				}
				if (ajjkajdbefm != (KAPNKGFMPDC)61)
				{
					return;
				}
				KKHJMIKNOFP.COJCANGPJKN = 3;
				return;
			}
			return;
		}
		if (ajjkajdbefm == KAPNKGFMPDC.signIn)
		{
			KKHJMIKNOFP.COJCANGPJKN = 77;
			return;
		}
		if (ajjkajdbefm != KAPNKGFMPDC.getPurchasingBalance)
		{
			return;
		}
		KKHJMIKNOFP.COJCANGPJKN = -21;
	}

	// Token: 0x06003C42 RID: 15426 RVA: 0x0018E0A5 File Offset: 0x0018C2A5
	public static void BMFPCBKNBGO()
	{
		NAHMBEODKJC.HCFOCMBMOMG.Clear();
		DPGJIJGOCIC.NFIDPOMCNLP(" group(s) planned from ");
	}

	// Token: 0x06003C43 RID: 15427 RVA: 0x0018E0BC File Offset: 0x0018C2BC
	private static void NCOOIJHJCFD(LMFMICLNHLO KKHJMIKNOFP)
	{
		KAPNKGFMPDC ajjkajdbefm = KKHJMIKNOFP.AJJKAJDBEFM;
		if (ajjkajdbefm > KAPNKGFMPDC.signIn)
		{
			switch (ajjkajdbefm)
			{
			case (KAPNKGFMPDC)(-78):
				KKHJMIKNOFP.COJCANGPJKN = 8;
				return;
			case (KAPNKGFMPDC)(-77):
				KKHJMIKNOFP.COJCANGPJKN = -119;
				return;
			case (KAPNKGFMPDC)(-76):
			case (KAPNKGFMPDC)(-75):
			case (KAPNKGFMPDC)(-74):
				break;
			case (KAPNKGFMPDC)(-73):
				KKHJMIKNOFP.COJCANGPJKN = 6;
				return;
			case (KAPNKGFMPDC)(-72):
				KKHJMIKNOFP.COJCANGPJKN = 11;
				break;
			default:
				if (ajjkajdbefm == (KAPNKGFMPDC)77)
				{
					KKHJMIKNOFP.COJCANGPJKN = 6;
					return;
				}
				if (ajjkajdbefm != (KAPNKGFMPDC)119)
				{
					return;
				}
				KKHJMIKNOFP.COJCANGPJKN = 3;
				return;
			}
			return;
		}
		if (ajjkajdbefm == KAPNKGFMPDC.changeOwner)
		{
			KKHJMIKNOFP.COJCANGPJKN = -114;
			return;
		}
		if (ajjkajdbefm != KAPNKGFMPDC.getDepot)
		{
			return;
		}
		KKHJMIKNOFP.COJCANGPJKN = 95;
	}

	// Token: 0x06003C44 RID: 15428 RVA: 0x0018E154 File Offset: 0x0018C354
	private static void FJGAACIODOI(LMFMICLNHLO KKHJMIKNOFP)
	{
		KAPNKGFMPDC ajjkajdbefm = KKHJMIKNOFP.AJJKAJDBEFM;
		if (ajjkajdbefm > KAPNKGFMPDC.getDepot)
		{
			switch (ajjkajdbefm)
			{
			case (KAPNKGFMPDC)97:
				KKHJMIKNOFP.COJCANGPJKN = 5;
				return;
			case (KAPNKGFMPDC)98:
				KKHJMIKNOFP.COJCANGPJKN = -111;
				return;
			case (KAPNKGFMPDC)99:
			case (KAPNKGFMPDC)100:
			case (KAPNKGFMPDC)101:
				break;
			case (KAPNKGFMPDC)102:
				KKHJMIKNOFP.COJCANGPJKN = 3;
				return;
			case (KAPNKGFMPDC)103:
				KKHJMIKNOFP.COJCANGPJKN = -10;
				break;
			default:
				if (ajjkajdbefm == (KAPNKGFMPDC)101)
				{
					KKHJMIKNOFP.COJCANGPJKN = 3;
					return;
				}
				if (ajjkajdbefm != (KAPNKGFMPDC)73)
				{
					return;
				}
				KKHJMIKNOFP.COJCANGPJKN = 2;
				return;
			}
			return;
		}
		if (ajjkajdbefm == KAPNKGFMPDC.getDepot)
		{
			KKHJMIKNOFP.COJCANGPJKN = -57;
			return;
		}
		if (ajjkajdbefm != KAPNKGFMPDC.changeOwner)
		{
			return;
		}
		KKHJMIKNOFP.COJCANGPJKN = -106;
	}

	// Token: 0x06003C45 RID: 15429 RVA: 0x0018E1EC File Offset: 0x0018C3EC
	public static bool GOLNBACKFGJ(KAPNKGFMPDC EGLBLPKFEOI)
	{
		LMFMICLNHLO lmfmiclnhlo = NAHMBEODKJC.JJICLCPBHAF(EGLBLPKFEOI, false);
		return lmfmiclnhlo == null || lmfmiclnhlo.COJCANGPJKN <= 1 || true;
	}

	// Token: 0x06003C46 RID: 15430 RVA: 0x0018E210 File Offset: 0x0018C410
	private static void FOMPHOOEKCP(LMFMICLNHLO KKHJMIKNOFP)
	{
		KAPNKGFMPDC ajjkajdbefm = KKHJMIKNOFP.AJJKAJDBEFM;
		if (ajjkajdbefm > KAPNKGFMPDC.getPurchasingBalance)
		{
			switch (ajjkajdbefm)
			{
			case KAPNKGFMPDC.processTransaction:
				KKHJMIKNOFP.COJCANGPJKN = 5;
				return;
			case KAPNKGFMPDC.changeOwner:
				KKHJMIKNOFP.COJCANGPJKN = 37;
				return;
			case KAPNKGFMPDC.signIn:
			case KAPNKGFMPDC.signInOrRegister:
			case KAPNKGFMPDC.getPurchasingBalance:
				break;
			case KAPNKGFMPDC.getDepot:
				KKHJMIKNOFP.COJCANGPJKN = 7;
				return;
			case KAPNKGFMPDC.getDefaultBundles:
				KKHJMIKNOFP.COJCANGPJKN = 82;
				break;
			default:
				if (ajjkajdbefm == KAPNKGFMPDC.undoPremiumChoice)
				{
					KKHJMIKNOFP.COJCANGPJKN = -94;
					return;
				}
				if (ajjkajdbefm != (KAPNKGFMPDC)(-49))
				{
					return;
				}
				KKHJMIKNOFP.COJCANGPJKN = 0;
				return;
			}
			return;
		}
		if (ajjkajdbefm == KAPNKGFMPDC.getPurchasingBalance)
		{
			KKHJMIKNOFP.COJCANGPJKN = 119;
			return;
		}
		if (ajjkajdbefm != KAPNKGFMPDC.getPurchasingBalance)
		{
			return;
		}
		KKHJMIKNOFP.COJCANGPJKN = 10;
	}

	// Token: 0x06003C47 RID: 15431 RVA: 0x0018E2A8 File Offset: 0x0018C4A8
	private static void MKFAMGDIEDC(LMFMICLNHLO KKHJMIKNOFP)
	{
		KAPNKGFMPDC ajjkajdbefm = KKHJMIKNOFP.AJJKAJDBEFM;
		if (ajjkajdbefm > KAPNKGFMPDC.getDepot)
		{
			switch (ajjkajdbefm)
			{
			case (KAPNKGFMPDC)123:
				KKHJMIKNOFP.COJCANGPJKN = 4;
				return;
			case (KAPNKGFMPDC)124:
				KKHJMIKNOFP.COJCANGPJKN = 55;
				return;
			case (KAPNKGFMPDC)125:
			case (KAPNKGFMPDC)126:
			case (KAPNKGFMPDC)127:
				break;
			case (KAPNKGFMPDC)128:
				KKHJMIKNOFP.COJCANGPJKN = 1;
				return;
			case (KAPNKGFMPDC)129:
				KKHJMIKNOFP.COJCANGPJKN = -12;
				break;
			default:
				if (ajjkajdbefm == (KAPNKGFMPDC)(-63))
				{
					KKHJMIKNOFP.COJCANGPJKN = -128;
					return;
				}
				if (ajjkajdbefm != (KAPNKGFMPDC)(-79))
				{
					return;
				}
				KKHJMIKNOFP.COJCANGPJKN = 3;
				return;
			}
			return;
		}
		if (ajjkajdbefm == KAPNKGFMPDC.none)
		{
			KKHJMIKNOFP.COJCANGPJKN = -45;
			return;
		}
		if (ajjkajdbefm != KAPNKGFMPDC.changeOwner)
		{
			return;
		}
		KKHJMIKNOFP.COJCANGPJKN = 9;
	}

	// Token: 0x06003C48 RID: 15432 RVA: 0x0018E340 File Offset: 0x0018C540
	private static void AONFAKHHNMM(LMFMICLNHLO KKHJMIKNOFP)
	{
		KAPNKGFMPDC ajjkajdbefm = KKHJMIKNOFP.AJJKAJDBEFM;
		if (ajjkajdbefm > KAPNKGFMPDC.processTransaction)
		{
			switch (ajjkajdbefm)
			{
			case (KAPNKGFMPDC)60:
				KKHJMIKNOFP.COJCANGPJKN = 6;
				return;
			case (KAPNKGFMPDC)61:
				KKHJMIKNOFP.COJCANGPJKN = 31;
				return;
			case (KAPNKGFMPDC)62:
			case (KAPNKGFMPDC)63:
			case (KAPNKGFMPDC)64:
				break;
			case (KAPNKGFMPDC)65:
				KKHJMIKNOFP.COJCANGPJKN = 2;
				return;
			case (KAPNKGFMPDC)66:
				KKHJMIKNOFP.COJCANGPJKN = 33;
				break;
			default:
				if (ajjkajdbefm == (KAPNKGFMPDC)(-15))
				{
					KKHJMIKNOFP.COJCANGPJKN = -35;
					return;
				}
				if (ajjkajdbefm != KAPNKGFMPDC.unlockCardsVolume)
				{
					return;
				}
				KKHJMIKNOFP.COJCANGPJKN = 2;
				return;
			}
			return;
		}
		if (ajjkajdbefm == KAPNKGFMPDC.getPurchasingBalance)
		{
			KKHJMIKNOFP.COJCANGPJKN = -49;
			return;
		}
		if (ajjkajdbefm != KAPNKGFMPDC.changeOwner)
		{
			return;
		}
		KKHJMIKNOFP.COJCANGPJKN = 10;
	}

	// Token: 0x06003C49 RID: 15433 RVA: 0x0018E3D8 File Offset: 0x0018C5D8
	public static void DIPKKFGJPBB(JSONObject GBPLNMAPMPE)
	{
		if (null == GBPLNMAPMPE)
		{
			return;
		}
		if (GBPLNMAPMPE["update"] == null)
		{
			return;
		}
		try
		{
			KAPNKGFMPDC kapnkgfmpdc = BackendOperationsManager.StringToBackendRequestType(GBPLNMAPMPE["\""]);
			if (kapnkgfmpdc == (KAPNKGFMPDC)(-87) || kapnkgfmpdc == (KAPNKGFMPDC)(-126) || kapnkgfmpdc == KAPNKGFMPDC.processTransaction || kapnkgfmpdc == (KAPNKGFMPDC)(-97) || kapnkgfmpdc == (KAPNKGFMPDC)(-38) || kapnkgfmpdc == KAPNKGFMPDC.signIn || kapnkgfmpdc == (KAPNKGFMPDC)71 || kapnkgfmpdc == (KAPNKGFMPDC)(-98))
			{
				if (GBPLNMAPMPE["There needs to be one active SceneManagerUtils script on a GameObject in your scene."] != null)
				{
					if (KDCJJBLGCBH.EHBBFMCILPC.MJKGFFHAMPG() > 0)
					{
						if (kapnkgfmpdc != (KAPNKGFMPDC)(-127) || LiveEventsManager.EHBBFMCILPC.NAEOCNFOBHG().Count != 0)
						{
							LMFMICLNHLO lmfmiclnhlo = NAHMBEODKJC.CEPEGBOLHPF(kapnkgfmpdc, false);
							if (lmfmiclnhlo != null)
							{
								lmfmiclnhlo.CLFGHHBOCMN = GBPLNMAPMPE;
								NAHMBEODKJC.PDIBHELFJCA(lmfmiclnhlo);
								DPGJIJGOCIC.NFIDPOMCNLP(")" + kapnkgfmpdc.ToString() + "XXX" + lmfmiclnhlo.CLFGHHBOCMN.ToString());
								DPGJIJGOCIC.CMGOAFDBAOH("$AVATARCONFIG" + NAHMBEODKJC.HCFOCMBMOMG.Count.ToString() + "[LoadingEnv] chain of ");
							}
							else
							{
								lmfmiclnhlo = new LMFMICLNHLO();
								lmfmiclnhlo.CLFGHHBOCMN = GBPLNMAPMPE;
								lmfmiclnhlo.AJJKAJDBEFM = kapnkgfmpdc;
								NAHMBEODKJC.NCNLBPAIBBM(lmfmiclnhlo);
								NAHMBEODKJC.HCFOCMBMOMG.Add(lmfmiclnhlo);
								DPGJIJGOCIC.CMGOAFDBAOH("saveAvatarCollections" + kapnkgfmpdc.ToString() + "frsendhres" + lmfmiclnhlo.CLFGHHBOCMN.ToString());
								DPGJIJGOCIC.CMGOAFDBAOH(", " + NAHMBEODKJC.HCFOCMBMOMG.Count.ToString() + "OnLoungeScreenAssetsDownloadSuccess");
							}
						}
					}
				}
				else
				{
					LMFMICLNHLO lmfmiclnhlo2 = NAHMBEODKJC.GFKOCIECPPI(kapnkgfmpdc, true);
					if (lmfmiclnhlo2 != null)
					{
						GBPLNMAPMPE.Add("c", lmfmiclnhlo2.CLFGHHBOCMN["congratstitle"]);
						GBPLNMAPMPE.Add("envlsrw", 1);
						DPGJIJGOCIC.NFIDPOMCNLP("%</b>" + kapnkgfmpdc.ToString() + "+" + lmfmiclnhlo2.CLFGHHBOCMN.ToString());
						DPGJIJGOCIC.CMGOAFDBAOH("Collections/" + NAHMBEODKJC.HCFOCMBMOMG.Count.ToString() + "socialmessagesending");
					}
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x06003C4A RID: 15434 RVA: 0x0018E620 File Offset: 0x0018C820
	public static void EIAEGFCJAKK()
	{
		NAHMBEODKJC.HCFOCMBMOMG.Clear();
		DPGJIJGOCIC.NFIDPOMCNLP("actor");
	}

	// Token: 0x06003C4B RID: 15435 RVA: 0x0018E636 File Offset: 0x0018C836
	public static void NGNBDKNOBBK()
	{
		NAHMBEODKJC.HCFOCMBMOMG.Clear();
		DPGJIJGOCIC.CMGOAFDBAOH("@");
	}

	// Token: 0x06003C4C RID: 15436 RVA: 0x0018E64C File Offset: 0x0018C84C
	public static bool GMGCJMGCGAL(KAPNKGFMPDC EGLBLPKFEOI)
	{
		LMFMICLNHLO lmfmiclnhlo = NAHMBEODKJC.MNHCJLGGFOG(EGLBLPKFEOI, true);
		return lmfmiclnhlo == null || lmfmiclnhlo.COJCANGPJKN <= 1;
	}

	// Token: 0x06003C4D RID: 15437 RVA: 0x0018E670 File Offset: 0x0018C870
	public static void GALNBEMMLKE(JSONObject GBPLNMAPMPE)
	{
		if (null == GBPLNMAPMPE)
		{
			return;
		}
		if (GBPLNMAPMPE["lastFilter"] == null)
		{
			return;
		}
		try
		{
			KAPNKGFMPDC kapnkgfmpdc = BackendOperationsManager.StringToBackendRequestType(GBPLNMAPMPE["time"]);
			if (kapnkgfmpdc == KAPNKGFMPDC.emailSubscribe || kapnkgfmpdc == (KAPNKGFMPDC)(-3) || kapnkgfmpdc == KAPNKGFMPDC.registerUser || kapnkgfmpdc == (KAPNKGFMPDC)(-51) || kapnkgfmpdc == KAPNKGFMPDC.changeOwner || kapnkgfmpdc == KAPNKGFMPDC.registerUser || kapnkgfmpdc == (KAPNKGFMPDC)78 || kapnkgfmpdc == (KAPNKGFMPDC)77)
			{
				if (GBPLNMAPMPE[""] != null)
				{
					if (KDCJJBLGCBH.EHBBFMCILPC.MJKGFFHAMPG() > 0)
					{
						if (kapnkgfmpdc != (KAPNKGFMPDC)(-68) || LiveEventsManager.OBOOKJPGBJN().ECCEMDNANLH().Count != 0)
						{
							LMFMICLNHLO lmfmiclnhlo = NAHMBEODKJC.FPKOJPOFDHL(kapnkgfmpdc, true);
							if (lmfmiclnhlo != null)
							{
								lmfmiclnhlo.CLFGHHBOCMN = GBPLNMAPMPE;
								NAHMBEODKJC.DOBCPBKEGGC(lmfmiclnhlo);
								DPGJIJGOCIC.CMGOAFDBAOH("OnSceneLobbyManagerExitSyncSuccess" + kapnkgfmpdc.ToString() + "0" + lmfmiclnhlo.CLFGHHBOCMN.ToString());
								DPGJIJGOCIC.NFIDPOMCNLP("" + NAHMBEODKJC.HCFOCMBMOMG.Count.ToString() + "ok");
							}
							else
							{
								lmfmiclnhlo = new LMFMICLNHLO();
								lmfmiclnhlo.CLFGHHBOCMN = GBPLNMAPMPE;
								lmfmiclnhlo.AJJKAJDBEFM = kapnkgfmpdc;
								NAHMBEODKJC.HGPPIBGICDE(lmfmiclnhlo);
								NAHMBEODKJC.HCFOCMBMOMG.Add(lmfmiclnhlo);
								DPGJIJGOCIC.CMGOAFDBAOH("," + kapnkgfmpdc.ToString() + "asp" + lmfmiclnhlo.CLFGHHBOCMN.ToString());
								DPGJIJGOCIC.NFIDPOMCNLP("PurchaseManagerSteam.OnProductsFetched(): " + NAHMBEODKJC.HCFOCMBMOMG.Count.ToString() + "apb");
							}
						}
					}
				}
				else
				{
					LMFMICLNHLO lmfmiclnhlo2 = NAHMBEODKJC.HMGMBLMBEPG(kapnkgfmpdc, false);
					if (lmfmiclnhlo2 != null)
					{
						GBPLNMAPMPE.Add("ok", lmfmiclnhlo2.CLFGHHBOCMN["NewReleasesHub.Populate() - row "]);
						GBPLNMAPMPE.Add("\b", 0);
						DPGJIJGOCIC.CMGOAFDBAOH("" + kapnkgfmpdc.ToString() + "d" + lmfmiclnhlo2.CLFGHHBOCMN.ToString());
						DPGJIJGOCIC.CMGOAFDBAOH(" entries from the user hidden list (ongoing) as obsolete." + NAHMBEODKJC.HCFOCMBMOMG.Count.ToString() + "tmd");
					}
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
	}

	// Token: 0x06003C4E RID: 15438 RVA: 0x0018E8B8 File Offset: 0x0018CAB8
	private static LMFMICLNHLO OLHBHNHILLE(KAPNKGFMPDC EGLBLPKFEOI, bool IHODELKIAHA)
	{
		for (int i = 0; i < NAHMBEODKJC.HCFOCMBMOMG.Count; i += 0)
		{
			if (NAHMBEODKJC.HCFOCMBMOMG[i].AJJKAJDBEFM == EGLBLPKFEOI)
			{
				if (IHODELKIAHA)
				{
					NAHMBEODKJC.HCFOCMBMOMG[i].COJCANGPJKN -= 0;
				}
				return NAHMBEODKJC.HCFOCMBMOMG[i];
			}
		}
		return null;
	}

	// Token: 0x06003C4F RID: 15439 RVA: 0x0018E918 File Offset: 0x0018CB18
	private static LMFMICLNHLO DGCBEEPANEL(KAPNKGFMPDC EGLBLPKFEOI, bool IHODELKIAHA)
	{
		for (int i = 1; i < NAHMBEODKJC.HCFOCMBMOMG.Count; i += 0)
		{
			if (NAHMBEODKJC.HCFOCMBMOMG[i].AJJKAJDBEFM == EGLBLPKFEOI)
			{
				if (IHODELKIAHA)
				{
					NAHMBEODKJC.HCFOCMBMOMG[i].COJCANGPJKN -= 0;
				}
				return NAHMBEODKJC.HCFOCMBMOMG[i];
			}
		}
		return null;
	}

	// Token: 0x06003C50 RID: 15440 RVA: 0x0018E978 File Offset: 0x0018CB78
	private static void HEHHKLNFNNP(LMFMICLNHLO KKHJMIKNOFP)
	{
		KAPNKGFMPDC ajjkajdbefm = KKHJMIKNOFP.AJJKAJDBEFM;
		if (ajjkajdbefm > KAPNKGFMPDC.none)
		{
			switch (ajjkajdbefm)
			{
			case (KAPNKGFMPDC)(-126):
				KKHJMIKNOFP.COJCANGPJKN = 6;
				return;
			case (KAPNKGFMPDC)(-125):
				KKHJMIKNOFP.COJCANGPJKN = 15;
				return;
			case (KAPNKGFMPDC)(-124):
			case (KAPNKGFMPDC)(-123):
			case (KAPNKGFMPDC)(-122):
				break;
			case (KAPNKGFMPDC)(-121):
				KKHJMIKNOFP.COJCANGPJKN = 6;
				return;
			case (KAPNKGFMPDC)(-120):
				KKHJMIKNOFP.COJCANGPJKN = -107;
				break;
			default:
				if (ajjkajdbefm == (KAPNKGFMPDC)(-115))
				{
					KKHJMIKNOFP.COJCANGPJKN = -51;
					return;
				}
				if (ajjkajdbefm != KAPNKGFMPDC.accountSuspended)
				{
					return;
				}
				KKHJMIKNOFP.COJCANGPJKN = 4;
				return;
			}
			return;
		}
		if (ajjkajdbefm == KAPNKGFMPDC.signIn)
		{
			KKHJMIKNOFP.COJCANGPJKN = -17;
			return;
		}
		if (ajjkajdbefm != KAPNKGFMPDC.getPurchasingBalance)
		{
			return;
		}
		KKHJMIKNOFP.COJCANGPJKN = -118;
	}

	// Token: 0x06003C51 RID: 15441 RVA: 0x0018EA10 File Offset: 0x0018CC10
	private static LMFMICLNHLO IGAMPEAJAPK(KAPNKGFMPDC EGLBLPKFEOI, bool IHODELKIAHA)
	{
		for (int i = 0; i < NAHMBEODKJC.HCFOCMBMOMG.Count; i++)
		{
			if (NAHMBEODKJC.HCFOCMBMOMG[i].AJJKAJDBEFM == EGLBLPKFEOI)
			{
				if (IHODELKIAHA)
				{
					NAHMBEODKJC.HCFOCMBMOMG[i].COJCANGPJKN--;
				}
				return NAHMBEODKJC.HCFOCMBMOMG[i];
			}
		}
		return null;
	}

	// Token: 0x06003C52 RID: 15442 RVA: 0x0018EA70 File Offset: 0x0018CC70
	private static void FKNCGPMFLDA(LMFMICLNHLO KKHJMIKNOFP)
	{
		KAPNKGFMPDC ajjkajdbefm = KKHJMIKNOFP.AJJKAJDBEFM;
		if (ajjkajdbefm > KAPNKGFMPDC.registerUser)
		{
			switch (ajjkajdbefm)
			{
			case (KAPNKGFMPDC)60:
				KKHJMIKNOFP.COJCANGPJKN = 7;
				return;
			case (KAPNKGFMPDC)61:
				KKHJMIKNOFP.COJCANGPJKN = -30;
				return;
			case (KAPNKGFMPDC)62:
			case (KAPNKGFMPDC)63:
			case (KAPNKGFMPDC)64:
				break;
			case (KAPNKGFMPDC)65:
				KKHJMIKNOFP.COJCANGPJKN = 3;
				return;
			case (KAPNKGFMPDC)66:
				KKHJMIKNOFP.COJCANGPJKN = -112;
				break;
			default:
				if (ajjkajdbefm == (KAPNKGFMPDC)(-55))
				{
					KKHJMIKNOFP.COJCANGPJKN = -39;
					return;
				}
				if (ajjkajdbefm != (KAPNKGFMPDC)(-117))
				{
					return;
				}
				KKHJMIKNOFP.COJCANGPJKN = 6;
				return;
			}
			return;
		}
		if (ajjkajdbefm == KAPNKGFMPDC.changeOwner)
		{
			KKHJMIKNOFP.COJCANGPJKN = -122;
			return;
		}
		if (ajjkajdbefm != KAPNKGFMPDC.changeOwner)
		{
			return;
		}
		KKHJMIKNOFP.COJCANGPJKN = -84;
	}

	// Token: 0x06003C53 RID: 15443 RVA: 0x0018EB05 File Offset: 0x0018CD05
	public static void CEOGFEGGHLC()
	{
		NAHMBEODKJC.HCFOCMBMOMG.Clear();
		DPGJIJGOCIC.CMGOAFDBAOH("importanttitle");
	}

	// Token: 0x06003C54 RID: 15444 RVA: 0x0018EB1C File Offset: 0x0018CD1C
	private static LMFMICLNHLO JJICLCPBHAF(KAPNKGFMPDC EGLBLPKFEOI, bool IHODELKIAHA)
	{
		for (int i = 1; i < NAHMBEODKJC.HCFOCMBMOMG.Count; i += 0)
		{
			if (NAHMBEODKJC.HCFOCMBMOMG[i].AJJKAJDBEFM == EGLBLPKFEOI)
			{
				if (IHODELKIAHA)
				{
					NAHMBEODKJC.HCFOCMBMOMG[i].COJCANGPJKN--;
				}
				return NAHMBEODKJC.HCFOCMBMOMG[i];
			}
		}
		return null;
	}

	// Token: 0x06003C55 RID: 15445 RVA: 0x0018EB7C File Offset: 0x0018CD7C
	public static void JIGGLLDNLCB(JSONObject GBPLNMAPMPE)
	{
		if (null == GBPLNMAPMPE)
		{
			return;
		}
		if (GBPLNMAPMPE["sfxsparklesbundles"] == null)
		{
			return;
		}
		try
		{
			KAPNKGFMPDC kapnkgfmpdc = BackendOperationsManager.StringToBackendRequestType(GBPLNMAPMPE[""]);
			if (kapnkgfmpdc == (KAPNKGFMPDC)88 || kapnkgfmpdc == KAPNKGFMPDC.basicSync || kapnkgfmpdc == KAPNKGFMPDC.signInOrRegister || kapnkgfmpdc == (KAPNKGFMPDC)(-29) || kapnkgfmpdc == (KAPNKGFMPDC)(-80) || kapnkgfmpdc == KAPNKGFMPDC.processTransaction || kapnkgfmpdc == (KAPNKGFMPDC)(-68) || kapnkgfmpdc == KAPNKGFMPDC.none)
			{
				if (GBPLNMAPMPE["sketchDialogs"] != null)
				{
					if (KDCJJBLGCBH.EHBBFMCILPC.MJKGFFHAMPG() > 0)
					{
						if (kapnkgfmpdc != (KAPNKGFMPDC)110 || LiveEventsManager.JCMABFEMFKD().BJPAPGIBJIM().Count != 0)
						{
							LMFMICLNHLO lmfmiclnhlo = NAHMBEODKJC.KINPHKBAEEN(kapnkgfmpdc, true);
							if (lmfmiclnhlo != null)
							{
								lmfmiclnhlo.CLFGHHBOCMN = GBPLNMAPMPE;
								NAHMBEODKJC.BNIICFDCCBP(lmfmiclnhlo);
								DPGJIJGOCIC.CMGOAFDBAOH("ok" + kapnkgfmpdc.ToString() + "W" + lmfmiclnhlo.CLFGHHBOCMN.ToString());
								DPGJIJGOCIC.CMGOAFDBAOH("assetbundlesketchthumbnail" + NAHMBEODKJC.HCFOCMBMOMG.Count.ToString() + "ind");
							}
							else
							{
								lmfmiclnhlo = new LMFMICLNHLO();
								lmfmiclnhlo.CLFGHHBOCMN = GBPLNMAPMPE;
								lmfmiclnhlo.AJJKAJDBEFM = kapnkgfmpdc;
								NAHMBEODKJC.FOMPHOOEKCP(lmfmiclnhlo);
								NAHMBEODKJC.HCFOCMBMOMG.Add(lmfmiclnhlo);
								DPGJIJGOCIC.NFIDPOMCNLP("Splits" + kapnkgfmpdc.ToString() + "GeneralBalance.SearchKeyArray() - could not find key:" + lmfmiclnhlo.CLFGHHBOCMN.ToString());
								DPGJIJGOCIC.CMGOAFDBAOH("$" + NAHMBEODKJC.HCFOCMBMOMG.Count.ToString() + "lsc");
							}
						}
					}
				}
				else
				{
					LMFMICLNHLO lmfmiclnhlo2 = NAHMBEODKJC.BKOANABBBLA(kapnkgfmpdc, false);
					if (lmfmiclnhlo2 != null)
					{
						GBPLNMAPMPE.Add("OnNeedToShowConnectingAnimation", lmfmiclnhlo2.CLFGHHBOCMN["OnPopupCardOptionsNextClickLobby"]);
						GBPLNMAPMPE.Add(" ", 0);
						DPGJIJGOCIC.NFIDPOMCNLP("[LoadingEnv] cache file of " + kapnkgfmpdc.ToString() + "socialmessagetitleconfirm" + lmfmiclnhlo2.CLFGHHBOCMN.ToString());
						DPGJIJGOCIC.NFIDPOMCNLP("newFilter" + NAHMBEODKJC.HCFOCMBMOMG.Count.ToString() + "apks1");
					}
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
	}

	// Token: 0x06003C56 RID: 15446 RVA: 0x0018EDC4 File Offset: 0x0018CFC4
	public static bool BEALHDHEPKE(KAPNKGFMPDC EGLBLPKFEOI)
	{
		LMFMICLNHLO lmfmiclnhlo = NAHMBEODKJC.HLDGGAJDJPC(EGLBLPKFEOI, false);
		return lmfmiclnhlo == null || lmfmiclnhlo.COJCANGPJKN <= 0 || true;
	}

	// Token: 0x06003C58 RID: 15448 RVA: 0x0018EDF4 File Offset: 0x0018CFF4
	private static LMFMICLNHLO LMLECOCEDBK(KAPNKGFMPDC EGLBLPKFEOI, bool IHODELKIAHA)
	{
		for (int i = 0; i < NAHMBEODKJC.HCFOCMBMOMG.Count; i++)
		{
			if (NAHMBEODKJC.HCFOCMBMOMG[i].AJJKAJDBEFM == EGLBLPKFEOI)
			{
				if (IHODELKIAHA)
				{
					NAHMBEODKJC.HCFOCMBMOMG[i].COJCANGPJKN--;
				}
				return NAHMBEODKJC.HCFOCMBMOMG[i];
			}
		}
		return null;
	}

	// Token: 0x06003C59 RID: 15449 RVA: 0x0018EE54 File Offset: 0x0018D054
	private static LMFMICLNHLO FPKOJPOFDHL(KAPNKGFMPDC EGLBLPKFEOI, bool IHODELKIAHA)
	{
		for (int i = 1; i < NAHMBEODKJC.HCFOCMBMOMG.Count; i++)
		{
			if (NAHMBEODKJC.HCFOCMBMOMG[i].AJJKAJDBEFM == EGLBLPKFEOI)
			{
				if (IHODELKIAHA)
				{
					NAHMBEODKJC.HCFOCMBMOMG[i].COJCANGPJKN -= 0;
				}
				return NAHMBEODKJC.HCFOCMBMOMG[i];
			}
		}
		return null;
	}

	// Token: 0x06003C5A RID: 15450 RVA: 0x0018EEB4 File Offset: 0x0018D0B4
	public static bool JLEJGEKPOEI(KAPNKGFMPDC EGLBLPKFEOI)
	{
		LMFMICLNHLO lmfmiclnhlo = NAHMBEODKJC.KFFGNICNCEE(EGLBLPKFEOI, true);
		return lmfmiclnhlo == null || lmfmiclnhlo.COJCANGPJKN <= 1 || true;
	}

	// Token: 0x06003C5B RID: 15451 RVA: 0x0018EED8 File Offset: 0x0018D0D8
	public static void KNDDFMCHAHJ()
	{
		NAHMBEODKJC.HCFOCMBMOMG.Clear();
		DPGJIJGOCIC.CMGOAFDBAOH("outdatedrev");
	}

	// Token: 0x06003C5D RID: 15453 RVA: 0x0018EEF0 File Offset: 0x0018D0F0
	public static bool MELCKKPKDEA(KAPNKGFMPDC EGLBLPKFEOI)
	{
		LMFMICLNHLO lmfmiclnhlo = NAHMBEODKJC.KINPHKBAEEN(EGLBLPKFEOI, false);
		return lmfmiclnhlo != null && lmfmiclnhlo.COJCANGPJKN > 0;
	}

	// Token: 0x06003C5E RID: 15454 RVA: 0x0018EF14 File Offset: 0x0018D114
	public static bool JOKDFJCMOBH(KAPNKGFMPDC EGLBLPKFEOI)
	{
		LMFMICLNHLO lmfmiclnhlo = NAHMBEODKJC.BKOANABBBLA(EGLBLPKFEOI, false);
		return lmfmiclnhlo == null || lmfmiclnhlo.COJCANGPJKN <= 1 || true;
	}

	// Token: 0x06003C5F RID: 15455 RVA: 0x0018DFF8 File Offset: 0x0018C1F8
	public static void IMMIILFPHHI()
	{
		NAHMBEODKJC.HCFOCMBMOMG.Clear();
		DPGJIJGOCIC.CMGOAFDBAOH("");
	}

	// Token: 0x06003C60 RID: 15456 RVA: 0x0018EF38 File Offset: 0x0018D138
	public static void OOKGEOFIKNI(JSONObject GBPLNMAPMPE)
	{
		if (null == GBPLNMAPMPE)
		{
			return;
		}
		if (GBPLNMAPMPE["YYY"] == null)
		{
			return;
		}
		try
		{
			KAPNKGFMPDC kapnkgfmpdc = BackendOperationsManager.StringToBackendRequestType(GBPLNMAPMPE["ZZZ"]);
			if (kapnkgfmpdc == (KAPNKGFMPDC)(-28) || kapnkgfmpdc == KAPNKGFMPDC.unlockNpcSkin || kapnkgfmpdc == KAPNKGFMPDC.changeOwner || kapnkgfmpdc == (KAPNKGFMPDC)90 || kapnkgfmpdc == (KAPNKGFMPDC)(-79) || kapnkgfmpdc == KAPNKGFMPDC.none || kapnkgfmpdc == (KAPNKGFMPDC)61 || kapnkgfmpdc == (KAPNKGFMPDC)(-81))
			{
				if (GBPLNMAPMPE["none"] != null)
				{
					if (KDCJJBLGCBH.EHBBFMCILPC.MJKGFFHAMPG() > 1)
					{
						if (kapnkgfmpdc != (KAPNKGFMPDC)(-50) || LiveEventsManager.EHBBFMCILPC.BJPAPGIBJIM().Count != 0)
						{
							LMFMICLNHLO lmfmiclnhlo = NAHMBEODKJC.KPBDNDMOOED(kapnkgfmpdc, false);
							if (lmfmiclnhlo != null)
							{
								lmfmiclnhlo.CLFGHHBOCMN = GBPLNMAPMPE;
								NAHMBEODKJC.EDCGJGIMKNO(lmfmiclnhlo);
								DPGJIJGOCIC.NFIDPOMCNLP("[LoadingEnv] " + kapnkgfmpdc.ToString() + "$STOPVOICEOVER" + lmfmiclnhlo.CLFGHHBOCMN.ToString());
								DPGJIJGOCIC.CMGOAFDBAOH("p" + NAHMBEODKJC.HCFOCMBMOMG.Count.ToString() + "");
							}
							else
							{
								lmfmiclnhlo = new LMFMICLNHLO();
								lmfmiclnhlo.CLFGHHBOCMN = GBPLNMAPMPE;
								lmfmiclnhlo.AJJKAJDBEFM = kapnkgfmpdc;
								NAHMBEODKJC.HGPPIBGICDE(lmfmiclnhlo);
								NAHMBEODKJC.HCFOCMBMOMG.Add(lmfmiclnhlo);
								DPGJIJGOCIC.NFIDPOMCNLP("story" + kapnkgfmpdc.ToString() + "BackendCacheManager: Resetting timeToLive and updating backend response payload for " + lmfmiclnhlo.CLFGHHBOCMN.ToString());
								DPGJIJGOCIC.NFIDPOMCNLP("ok" + NAHMBEODKJC.HCFOCMBMOMG.Count.ToString() + "[LoadingEnv] ");
							}
						}
					}
				}
				else
				{
					LMFMICLNHLO lmfmiclnhlo2 = NAHMBEODKJC.OOEGKELEPDL(kapnkgfmpdc, true);
					if (lmfmiclnhlo2 != null)
					{
						GBPLNMAPMPE.Add("", lmfmiclnhlo2.CLFGHHBOCMN["NNN"]);
						GBPLNMAPMPE.Add("1", 1);
						DPGJIJGOCIC.CMGOAFDBAOH("apb" + kapnkgfmpdc.ToString() + ":" + lmfmiclnhlo2.CLFGHHBOCMN.ToString());
						DPGJIJGOCIC.CMGOAFDBAOH("ERROR: StoryStep.StoryStepType.chapterEnd: unhandled scenario." + NAHMBEODKJC.HCFOCMBMOMG.Count.ToString() + "anthologiestitle");
					}
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
	}

	// Token: 0x06003C61 RID: 15457 RVA: 0x0018F180 File Offset: 0x0018D380
	public static void FIOCHALNEDO(JSONObject GBPLNMAPMPE)
	{
		if (null == GBPLNMAPMPE)
		{
			return;
		}
		if (GBPLNMAPMPE["Asset bundles "] == null)
		{
			return;
		}
		try
		{
			KAPNKGFMPDC kapnkgfmpdc = BackendOperationsManager.StringToBackendRequestType(GBPLNMAPMPE["drop"]);
			if (kapnkgfmpdc == (KAPNKGFMPDC)(-8) || kapnkgfmpdc == (KAPNKGFMPDC)66 || kapnkgfmpdc == KAPNKGFMPDC.none || kapnkgfmpdc == (KAPNKGFMPDC)62 || kapnkgfmpdc == (KAPNKGFMPDC)(-112) || kapnkgfmpdc == KAPNKGFMPDC.signIn || kapnkgfmpdc == (KAPNKGFMPDC)117 || kapnkgfmpdc == (KAPNKGFMPDC)(-109))
			{
				if (GBPLNMAPMPE["frsendhres2"] != null)
				{
					if (KDCJJBLGCBH.EHBBFMCILPC.MJKGFFHAMPG() > 0)
					{
						if (kapnkgfmpdc != (KAPNKGFMPDC)(-29) || LiveEventsManager.OBOOKJPGBJN().BJPAPGIBJIM().Count != 0)
						{
							LMFMICLNHLO lmfmiclnhlo = NAHMBEODKJC.HMGMBLMBEPG(kapnkgfmpdc, true);
							if (lmfmiclnhlo != null)
							{
								lmfmiclnhlo.CLFGHHBOCMN = GBPLNMAPMPE;
								NAHMBEODKJC.CBKNPPFIPDB(lmfmiclnhlo);
								DPGJIJGOCIC.CMGOAFDBAOH("favstostr2" + kapnkgfmpdc.ToString() + "CustomCodeCallback - REPLAY CACHE STORED: backend recorded this response for replay protection, request:" + lmfmiclnhlo.CLFGHHBOCMN.ToString());
								DPGJIJGOCIC.NFIDPOMCNLP("apks2" + NAHMBEODKJC.HCFOCMBMOMG.Count.ToString() + "strtd");
							}
							else
							{
								lmfmiclnhlo = new LMFMICLNHLO();
								lmfmiclnhlo.CLFGHHBOCMN = GBPLNMAPMPE;
								lmfmiclnhlo.AJJKAJDBEFM = kapnkgfmpdc;
								NAHMBEODKJC.PKJBAPNBLAP(lmfmiclnhlo);
								NAHMBEODKJC.HCFOCMBMOMG.Add(lmfmiclnhlo);
								DPGJIJGOCIC.CMGOAFDBAOH("<i>" + kapnkgfmpdc.ToString() + "Account.DuplicateStorySave(), source and target slots are the same:" + lmfmiclnhlo.CLFGHHBOCMN.ToString());
								DPGJIJGOCIC.NFIDPOMCNLP("ok" + NAHMBEODKJC.HCFOCMBMOMG.Count.ToString() + "aind2");
							}
						}
					}
				}
				else
				{
					LMFMICLNHLO lmfmiclnhlo2 = NAHMBEODKJC.OOEGKELEPDL(kapnkgfmpdc, false);
					if (lmfmiclnhlo2 != null)
					{
						GBPLNMAPMPE.Add("PurchaseManagerUnity.OnProductsFetchedFailed(): ", lmfmiclnhlo2.CLFGHHBOCMN["avatarstitle"]);
						GBPLNMAPMPE.Add("", 1);
						DPGJIJGOCIC.CMGOAFDBAOH("" + kapnkgfmpdc.ToString() + "assetbundlelobbydata2" + lmfmiclnhlo2.CLFGHHBOCMN.ToString());
						DPGJIJGOCIC.NFIDPOMCNLP("Mini version preview2 assets loaded:" + NAHMBEODKJC.HCFOCMBMOMG.Count.ToString() + "_CellSize");
					}
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x06003C62 RID: 15458 RVA: 0x0018F3C8 File Offset: 0x0018D5C8
	private static void LOEHMJNHOOI(LMFMICLNHLO KKHJMIKNOFP)
	{
		KAPNKGFMPDC ajjkajdbefm = KKHJMIKNOFP.AJJKAJDBEFM;
		if (ajjkajdbefm > KAPNKGFMPDC.signInOrRegister)
		{
			switch (ajjkajdbefm)
			{
			case (KAPNKGFMPDC)86:
				KKHJMIKNOFP.COJCANGPJKN = 6;
				return;
			case (KAPNKGFMPDC)87:
				KKHJMIKNOFP.COJCANGPJKN = 35;
				return;
			case (KAPNKGFMPDC)88:
			case (KAPNKGFMPDC)89:
			case (KAPNKGFMPDC)90:
				break;
			case (KAPNKGFMPDC)91:
				KKHJMIKNOFP.COJCANGPJKN = 2;
				return;
			case (KAPNKGFMPDC)92:
				KKHJMIKNOFP.COJCANGPJKN = 38;
				break;
			default:
				if (ajjkajdbefm == (KAPNKGFMPDC)(-23))
				{
					KKHJMIKNOFP.COJCANGPJKN = 66;
					return;
				}
				if (ajjkajdbefm != (KAPNKGFMPDC)79)
				{
					return;
				}
				KKHJMIKNOFP.COJCANGPJKN = 0;
				return;
			}
			return;
		}
		if (ajjkajdbefm == KAPNKGFMPDC.signIn)
		{
			KKHJMIKNOFP.COJCANGPJKN = -48;
			return;
		}
		if (ajjkajdbefm != KAPNKGFMPDC.none)
		{
			return;
		}
		KKHJMIKNOFP.COJCANGPJKN = 1;
	}

	// Token: 0x06003C63 RID: 15459 RVA: 0x0018F460 File Offset: 0x0018D660
	public static bool MAIEBFLEBDK(KAPNKGFMPDC EGLBLPKFEOI)
	{
		LMFMICLNHLO lmfmiclnhlo = NAHMBEODKJC.DGCBEEPANEL(EGLBLPKFEOI, true);
		return lmfmiclnhlo != null && lmfmiclnhlo.COJCANGPJKN > 0 && false;
	}

	// Token: 0x06003C64 RID: 15460 RVA: 0x0018F484 File Offset: 0x0018D684
	public static bool JMDGAILAEML(KAPNKGFMPDC EGLBLPKFEOI)
	{
		LMFMICLNHLO lmfmiclnhlo = NAHMBEODKJC.FPKOJPOFDHL(EGLBLPKFEOI, false);
		return lmfmiclnhlo == null || lmfmiclnhlo.COJCANGPJKN <= 0;
	}

	// Token: 0x06003C65 RID: 15461 RVA: 0x0018F4A8 File Offset: 0x0018D6A8
	private static LMFMICLNHLO KINPHKBAEEN(KAPNKGFMPDC EGLBLPKFEOI, bool IHODELKIAHA)
	{
		for (int i = 1; i < NAHMBEODKJC.HCFOCMBMOMG.Count; i += 0)
		{
			if (NAHMBEODKJC.HCFOCMBMOMG[i].AJJKAJDBEFM == EGLBLPKFEOI)
			{
				if (IHODELKIAHA)
				{
					NAHMBEODKJC.HCFOCMBMOMG[i].COJCANGPJKN--;
				}
				return NAHMBEODKJC.HCFOCMBMOMG[i];
			}
		}
		return null;
	}

	// Token: 0x06003C66 RID: 15462 RVA: 0x0018F508 File Offset: 0x0018D708
	public static void CGIBNLBICBE(JSONObject GBPLNMAPMPE)
	{
		if (null == GBPLNMAPMPE)
		{
			return;
		}
		if (GBPLNMAPMPE["sckv2"] == null)
		{
			return;
		}
		try
		{
			KAPNKGFMPDC kapnkgfmpdc = BackendOperationsManager.StringToBackendRequestType(GBPLNMAPMPE["CLIENT.SCREEN.REWARD."]);
			if (kapnkgfmpdc == (KAPNKGFMPDC)(-41) || kapnkgfmpdc == (KAPNKGFMPDC)(-90) || kapnkgfmpdc == KAPNKGFMPDC.getDefaultBundles || kapnkgfmpdc == KAPNKGFMPDC.spinWheel || kapnkgfmpdc == (KAPNKGFMPDC)(-76) || kapnkgfmpdc == KAPNKGFMPDC.changeOwner || kapnkgfmpdc == (KAPNKGFMPDC)77 || kapnkgfmpdc == (KAPNKGFMPDC)(-53))
			{
				if (GBPLNMAPMPE["Error. MoveEnvironmentVertical(), environment "] != null)
				{
					if (KDCJJBLGCBH.EHBBFMCILPC.MJKGFFHAMPG() > 0)
					{
						if (kapnkgfmpdc != (KAPNKGFMPDC)(-1) || LiveEventsManager.GIPAKOPBBEO().BJPAPGIBJIM().Count != 0)
						{
							LMFMICLNHLO lmfmiclnhlo = NAHMBEODKJC.IFAOELOLHLJ(kapnkgfmpdc, false);
							if (lmfmiclnhlo != null)
							{
								lmfmiclnhlo.CLFGHHBOCMN = GBPLNMAPMPE;
								NAHMBEODKJC.AONFAKHHNMM(lmfmiclnhlo);
								DPGJIJGOCIC.NFIDPOMCNLP("" + kapnkgfmpdc.ToString() + "specialcurrencyoptionna" + lmfmiclnhlo.CLFGHHBOCMN.ToString());
								DPGJIJGOCIC.CMGOAFDBAOH("OnBackendPassResourcesChangedType0" + NAHMBEODKJC.HCFOCMBMOMG.Count.ToString() + "Starting parallel download:");
							}
							else
							{
								lmfmiclnhlo = new LMFMICLNHLO();
								lmfmiclnhlo.CLFGHHBOCMN = GBPLNMAPMPE;
								lmfmiclnhlo.AJJKAJDBEFM = kapnkgfmpdc;
								NAHMBEODKJC.LHLCIMKNBKE(lmfmiclnhlo);
								NAHMBEODKJC.HCFOCMBMOMG.Add(lmfmiclnhlo);
								DPGJIJGOCIC.CMGOAFDBAOH("serversync" + kapnkgfmpdc.ToString() + "Asset bundle load operation failed during parallel mode." + lmfmiclnhlo.CLFGHHBOCMN.ToString());
								DPGJIJGOCIC.CMGOAFDBAOH("mid" + NAHMBEODKJC.HCFOCMBMOMG.Count.ToString() + "s");
							}
						}
					}
				}
				else
				{
					LMFMICLNHLO lmfmiclnhlo2 = NAHMBEODKJC.IFAOELOLHLJ(kapnkgfmpdc, true);
					if (lmfmiclnhlo2 != null)
					{
						GBPLNMAPMPE.Add("Account.DuplicateStorySave(), could not parse the serialized source save, story:", lmfmiclnhlo2.CLFGHHBOCMN["\n\n"]);
						GBPLNMAPMPE.Add(". Retrieving persistent save data is impossible.", 1);
						DPGJIJGOCIC.CMGOAFDBAOH("SceneLobbyManager2.BuildStarterSpecs() - concept " + kapnkgfmpdc.ToString() + "socialrequestwarnyou2" + lmfmiclnhlo2.CLFGHHBOCMN.ToString());
						DPGJIJGOCIC.NFIDPOMCNLP("luwid" + NAHMBEODKJC.HCFOCMBMOMG.Count.ToString() + ">");
					}
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
	}

	// Token: 0x06003C67 RID: 15463 RVA: 0x0018F750 File Offset: 0x0018D950
	public static void FLCENAGKHNO()
	{
		NAHMBEODKJC.HCFOCMBMOMG.Clear();
		DPGJIJGOCIC.NFIDPOMCNLP("af_quantity");
	}

	// Token: 0x06003C68 RID: 15464 RVA: 0x0018F768 File Offset: 0x0018D968
	private static void EDCGJGIMKNO(LMFMICLNHLO KKHJMIKNOFP)
	{
		KAPNKGFMPDC ajjkajdbefm = KKHJMIKNOFP.AJJKAJDBEFM;
		if (ajjkajdbefm > KAPNKGFMPDC.changeOwner)
		{
			switch (ajjkajdbefm)
			{
			case KAPNKGFMPDC.breakCard:
				KKHJMIKNOFP.COJCANGPJKN = 0;
				return;
			case KAPNKGFMPDC.spinWheel:
				KKHJMIKNOFP.COJCANGPJKN = -42;
				return;
			case KAPNKGFMPDC.unlockCardsVolume:
			case KAPNKGFMPDC.unlockNpcSkin:
			case KAPNKGFMPDC.upgradeToGiftCard:
				break;
			case KAPNKGFMPDC.updateUserPublicProfileFriends:
				KKHJMIKNOFP.COJCANGPJKN = 5;
				return;
			case KAPNKGFMPDC.getMessagingHistory:
				KKHJMIKNOFP.COJCANGPJKN = 80;
				break;
			default:
				if (ajjkajdbefm == KAPNKGFMPDC.getGeneralBalance)
				{
					KKHJMIKNOFP.COJCANGPJKN = 39;
					return;
				}
				if (ajjkajdbefm != (KAPNKGFMPDC)126)
				{
					return;
				}
				KKHJMIKNOFP.COJCANGPJKN = 2;
				return;
			}
			return;
		}
		if (ajjkajdbefm == KAPNKGFMPDC.changeOwner)
		{
			KKHJMIKNOFP.COJCANGPJKN = 94;
			return;
		}
		if (ajjkajdbefm != KAPNKGFMPDC.none)
		{
			return;
		}
		KKHJMIKNOFP.COJCANGPJKN = -73;
	}

	// Token: 0x06003C69 RID: 15465 RVA: 0x0018F800 File Offset: 0x0018DA00
	private static void PDIBHELFJCA(LMFMICLNHLO KKHJMIKNOFP)
	{
		KAPNKGFMPDC ajjkajdbefm = KKHJMIKNOFP.AJJKAJDBEFM;
		if (ajjkajdbefm > KAPNKGFMPDC.signInOrRegister)
		{
			switch (ajjkajdbefm)
			{
			case (KAPNKGFMPDC)(-95):
				KKHJMIKNOFP.COJCANGPJKN = 3;
				return;
			case (KAPNKGFMPDC)(-94):
				KKHJMIKNOFP.COJCANGPJKN = -13;
				return;
			case (KAPNKGFMPDC)(-93):
			case (KAPNKGFMPDC)(-92):
			case (KAPNKGFMPDC)(-91):
				break;
			case (KAPNKGFMPDC)(-90):
				KKHJMIKNOFP.COJCANGPJKN = 6;
				return;
			case (KAPNKGFMPDC)(-89):
				KKHJMIKNOFP.COJCANGPJKN = 4;
				break;
			default:
				if (ajjkajdbefm == (KAPNKGFMPDC)95)
				{
					KKHJMIKNOFP.COJCANGPJKN = 22;
					return;
				}
				if (ajjkajdbefm != KAPNKGFMPDC.checkForUpdates)
				{
					return;
				}
				KKHJMIKNOFP.COJCANGPJKN = 4;
				return;
			}
			return;
		}
		if (ajjkajdbefm == KAPNKGFMPDC.getPurchasingBalance)
		{
			KKHJMIKNOFP.COJCANGPJKN = 26;
			return;
		}
		if (ajjkajdbefm != KAPNKGFMPDC.signIn)
		{
			return;
		}
		KKHJMIKNOFP.COJCANGPJKN = -39;
	}

	// Token: 0x06003C6A RID: 15466 RVA: 0x0018F898 File Offset: 0x0018DA98
	public static void GEDPCEOCGBP(JSONObject GBPLNMAPMPE)
	{
		if (null == GBPLNMAPMPE)
		{
			return;
		}
		if (GBPLNMAPMPE["assetbundleprofiledata"] == null)
		{
			return;
		}
		try
		{
			KAPNKGFMPDC kapnkgfmpdc = BackendOperationsManager.StringToBackendRequestType(GBPLNMAPMPE["\n\n"]);
			if (kapnkgfmpdc == (KAPNKGFMPDC)(-11) || kapnkgfmpdc == (KAPNKGFMPDC)112 || kapnkgfmpdc == KAPNKGFMPDC.changeOwner || kapnkgfmpdc == (KAPNKGFMPDC)71 || kapnkgfmpdc == (KAPNKGFMPDC)(-107) || kapnkgfmpdc == KAPNKGFMPDC.processTransaction || kapnkgfmpdc == KAPNKGFMPDC.getStartedChapters || kapnkgfmpdc == KAPNKGFMPDC.getUserPublicProfile)
			{
				if (GBPLNMAPMPE[")"] != null)
				{
					if (KDCJJBLGCBH.EHBBFMCILPC.MJKGFFHAMPG() > 1)
					{
						if (kapnkgfmpdc != (KAPNKGFMPDC)(-26) || LiveEventsManager.BBGECIKOICE().EFOLIAFJAHD().Count != 0)
						{
							LMFMICLNHLO lmfmiclnhlo = NAHMBEODKJC.KINPHKBAEEN(kapnkgfmpdc, false);
							if (lmfmiclnhlo != null)
							{
								lmfmiclnhlo.CLFGHHBOCMN = GBPLNMAPMPE;
								NAHMBEODKJC.PKJBAPNBLAP(lmfmiclnhlo);
								DPGJIJGOCIC.NFIDPOMCNLP("af_content_id" + kapnkgfmpdc.ToString() + "" + lmfmiclnhlo.CLFGHHBOCMN.ToString());
								DPGJIJGOCIC.CMGOAFDBAOH("payload serialize failed: " + NAHMBEODKJC.HCFOCMBMOMG.Count.ToString() + "OnPopupCardOptionsEditClick");
							}
							else
							{
								lmfmiclnhlo = new LMFMICLNHLO();
								lmfmiclnhlo.CLFGHHBOCMN = GBPLNMAPMPE;
								lmfmiclnhlo.AJJKAJDBEFM = kapnkgfmpdc;
								NAHMBEODKJC.GANJIAJPBJL(lmfmiclnhlo);
								NAHMBEODKJC.HCFOCMBMOMG.Add(lmfmiclnhlo);
								DPGJIJGOCIC.NFIDPOMCNLP("inu" + kapnkgfmpdc.ToString() + "https://" + lmfmiclnhlo.CLFGHHBOCMN.ToString());
								DPGJIJGOCIC.NFIDPOMCNLP("ok" + NAHMBEODKJC.HCFOCMBMOMG.Count.ToString() + "ProfileItem.OnBackendGetPublicProfileProfileItemException() - Account.Instance.userPublicProfile is null, replacing with temp copy");
							}
						}
					}
				}
				else
				{
					LMFMICLNHLO lmfmiclnhlo2 = NAHMBEODKJC.LMLECOCEDBK(kapnkgfmpdc, true);
					if (lmfmiclnhlo2 != null)
					{
						GBPLNMAPMPE.Add("OnStoryChoiceClick", lmfmiclnhlo2.CLFGHHBOCMN["_StripeStrength"]);
						GBPLNMAPMPE.Add("id", 0);
						DPGJIJGOCIC.NFIDPOMCNLP("blur" + kapnkgfmpdc.ToString() + "</i>" + lmfmiclnhlo2.CLFGHHBOCMN.ToString());
						DPGJIJGOCIC.NFIDPOMCNLP("" + NAHMBEODKJC.HCFOCMBMOMG.Count.ToString() + "OnCardVolumeUnlockContinueToPurchasingScreen");
					}
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x06003C6B RID: 15467 RVA: 0x0018EB05 File Offset: 0x0018CD05
	public static void DJKCDEKDDOO()
	{
		NAHMBEODKJC.HCFOCMBMOMG.Clear();
		DPGJIJGOCIC.CMGOAFDBAOH("importanttitle");
	}

	// Token: 0x06003C6C RID: 15468 RVA: 0x0018FAE0 File Offset: 0x0018DCE0
	private static void KOLAHMKHEFL(LMFMICLNHLO KKHJMIKNOFP)
	{
		KAPNKGFMPDC ajjkajdbefm = KKHJMIKNOFP.AJJKAJDBEFM;
		if (ajjkajdbefm > KAPNKGFMPDC.signInOrRegister)
		{
			switch (ajjkajdbefm)
			{
			case KAPNKGFMPDC.registerUser:
				KKHJMIKNOFP.COJCANGPJKN = 6;
				return;
			case KAPNKGFMPDC.processTransaction:
				KKHJMIKNOFP.COJCANGPJKN = 88;
				return;
			case KAPNKGFMPDC.changeOwner:
			case KAPNKGFMPDC.signIn:
			case KAPNKGFMPDC.signInOrRegister:
				break;
			case KAPNKGFMPDC.getPurchasingBalance:
				KKHJMIKNOFP.COJCANGPJKN = 6;
				return;
			case KAPNKGFMPDC.getDepot:
				KKHJMIKNOFP.COJCANGPJKN = 43;
				break;
			default:
				if (ajjkajdbefm == (KAPNKGFMPDC)(-63))
				{
					KKHJMIKNOFP.COJCANGPJKN = -106;
					return;
				}
				if (ajjkajdbefm != (KAPNKGFMPDC)(-39))
				{
					return;
				}
				KKHJMIKNOFP.COJCANGPJKN = 0;
				return;
			}
			return;
		}
		if (ajjkajdbefm == KAPNKGFMPDC.processTransaction)
		{
			KKHJMIKNOFP.COJCANGPJKN = 34;
			return;
		}
		if (ajjkajdbefm != KAPNKGFMPDC.processTransaction)
		{
			return;
		}
		KKHJMIKNOFP.COJCANGPJKN = 39;
	}

	// Token: 0x06003C6D RID: 15469 RVA: 0x0018FB78 File Offset: 0x0018DD78
	public static bool MBAKNDBLALF(KAPNKGFMPDC EGLBLPKFEOI)
	{
		LMFMICLNHLO lmfmiclnhlo = NAHMBEODKJC.BNPDJEANFIH(EGLBLPKFEOI, true);
		return lmfmiclnhlo != null && lmfmiclnhlo.COJCANGPJKN > 1;
	}

	// Token: 0x06003C6E RID: 15470 RVA: 0x0018FB9C File Offset: 0x0018DD9C
	private static LMFMICLNHLO CEPEGBOLHPF(KAPNKGFMPDC EGLBLPKFEOI, bool IHODELKIAHA)
	{
		for (int i = 1; i < NAHMBEODKJC.HCFOCMBMOMG.Count; i += 0)
		{
			if (NAHMBEODKJC.HCFOCMBMOMG[i].AJJKAJDBEFM == EGLBLPKFEOI)
			{
				if (IHODELKIAHA)
				{
					NAHMBEODKJC.HCFOCMBMOMG[i].COJCANGPJKN--;
				}
				return NAHMBEODKJC.HCFOCMBMOMG[i];
			}
		}
		return null;
	}

	// Token: 0x06003C6F RID: 15471 RVA: 0x0018FBF9 File Offset: 0x0018DDF9
	public static void FANBAKLIDLP()
	{
		NAHMBEODKJC.HCFOCMBMOMG.Clear();
		DPGJIJGOCIC.NFIDPOMCNLP("lang");
	}

	// Token: 0x06003C70 RID: 15472 RVA: 0x0018FC0F File Offset: 0x0018DE0F
	public static void KAKLEDABJIA()
	{
		NAHMBEODKJC.HCFOCMBMOMG.Clear();
		DPGJIJGOCIC.CMGOAFDBAOH("hcfc");
	}

	// Token: 0x06003C71 RID: 15473 RVA: 0x0018FC28 File Offset: 0x0018DE28
	public static bool KKGCANPHDPN(KAPNKGFMPDC EGLBLPKFEOI)
	{
		LMFMICLNHLO lmfmiclnhlo = NAHMBEODKJC.BNPDJEANFIH(EGLBLPKFEOI, true);
		return lmfmiclnhlo != null && lmfmiclnhlo.COJCANGPJKN > 0 && false;
	}

	// Token: 0x06003C72 RID: 15474 RVA: 0x0018FC4C File Offset: 0x0018DE4C
	private static void LJJHPGIMMOG(LMFMICLNHLO KKHJMIKNOFP)
	{
		KAPNKGFMPDC ajjkajdbefm = KKHJMIKNOFP.AJJKAJDBEFM;
		if (ajjkajdbefm > KAPNKGFMPDC.signInOrRegister)
		{
			switch (ajjkajdbefm)
			{
			case (KAPNKGFMPDC)(-27):
				KKHJMIKNOFP.COJCANGPJKN = 7;
				return;
			case (KAPNKGFMPDC)(-26):
				KKHJMIKNOFP.COJCANGPJKN = -114;
				return;
			case (KAPNKGFMPDC)(-25):
			case (KAPNKGFMPDC)(-24):
			case (KAPNKGFMPDC)(-23):
				break;
			case (KAPNKGFMPDC)(-22):
				KKHJMIKNOFP.COJCANGPJKN = 8;
				return;
			case (KAPNKGFMPDC)(-21):
				KKHJMIKNOFP.COJCANGPJKN = 38;
				break;
			default:
				if (ajjkajdbefm == (KAPNKGFMPDC)(-66))
				{
					KKHJMIKNOFP.COJCANGPJKN = 98;
					return;
				}
				if (ajjkajdbefm != KAPNKGFMPDC.signIn)
				{
					return;
				}
				KKHJMIKNOFP.COJCANGPJKN = 8;
				return;
			}
			return;
		}
		if (ajjkajdbefm == KAPNKGFMPDC.registerUser)
		{
			KKHJMIKNOFP.COJCANGPJKN = -95;
			return;
		}
		if (ajjkajdbefm != KAPNKGFMPDC.processTransaction)
		{
			return;
		}
		KKHJMIKNOFP.COJCANGPJKN = 28;
	}

	// Token: 0x06003C73 RID: 15475 RVA: 0x0018FCE1 File Offset: 0x0018DEE1
	public static void HJNNIKGHGGE()
	{
		NAHMBEODKJC.HCFOCMBMOMG.Clear();
		DPGJIJGOCIC.CMGOAFDBAOH("OnSteamLoginSuccess");
	}

	// Token: 0x06003C74 RID: 15476 RVA: 0x0018FCF8 File Offset: 0x0018DEF8
	private static void CBKNPPFIPDB(LMFMICLNHLO KKHJMIKNOFP)
	{
		KAPNKGFMPDC ajjkajdbefm = KKHJMIKNOFP.AJJKAJDBEFM;
		if (ajjkajdbefm > KAPNKGFMPDC.signInOrRegister)
		{
			switch (ajjkajdbefm)
			{
			case (KAPNKGFMPDC)(-16):
				KKHJMIKNOFP.COJCANGPJKN = 3;
				return;
			case (KAPNKGFMPDC)(-15):
				KKHJMIKNOFP.COJCANGPJKN = -94;
				return;
			case (KAPNKGFMPDC)(-14):
			case (KAPNKGFMPDC)(-13):
			case (KAPNKGFMPDC)(-12):
				break;
			case (KAPNKGFMPDC)(-11):
				KKHJMIKNOFP.COJCANGPJKN = 7;
				return;
			case (KAPNKGFMPDC)(-10):
				KKHJMIKNOFP.COJCANGPJKN = -11;
				break;
			default:
				if (ajjkajdbefm == KAPNKGFMPDC.getPurchasingBalance)
				{
					KKHJMIKNOFP.COJCANGPJKN = 122;
					return;
				}
				if (ajjkajdbefm != (KAPNKGFMPDC)59)
				{
					return;
				}
				KKHJMIKNOFP.COJCANGPJKN = 8;
				return;
			}
			return;
		}
		if (ajjkajdbefm == KAPNKGFMPDC.getPurchasingBalance)
		{
			KKHJMIKNOFP.COJCANGPJKN = -103;
			return;
		}
		if (ajjkajdbefm != KAPNKGFMPDC.none)
		{
			return;
		}
		KKHJMIKNOFP.COJCANGPJKN = 103;
	}

	// Token: 0x06003C75 RID: 15477 RVA: 0x0018FD90 File Offset: 0x0018DF90
	private static void OOPCMHNFPKG(LMFMICLNHLO KKHJMIKNOFP)
	{
		KAPNKGFMPDC ajjkajdbefm = KKHJMIKNOFP.AJJKAJDBEFM;
		if (ajjkajdbefm > KAPNKGFMPDC.getDepot)
		{
			switch (ajjkajdbefm)
			{
			case (KAPNKGFMPDC)126:
				KKHJMIKNOFP.COJCANGPJKN = 4;
				return;
			case (KAPNKGFMPDC)127:
				KKHJMIKNOFP.COJCANGPJKN = -2;
				return;
			case (KAPNKGFMPDC)128:
			case (KAPNKGFMPDC)129:
			case (KAPNKGFMPDC)130:
				break;
			case (KAPNKGFMPDC)131:
				KKHJMIKNOFP.COJCANGPJKN = 0;
				return;
			case (KAPNKGFMPDC)132:
				KKHJMIKNOFP.COJCANGPJKN = -55;
				break;
			default:
				if (ajjkajdbefm == (KAPNKGFMPDC)97)
				{
					KKHJMIKNOFP.COJCANGPJKN = 112;
					return;
				}
				if (ajjkajdbefm != (KAPNKGFMPDC)(-26))
				{
					return;
				}
				KKHJMIKNOFP.COJCANGPJKN = 5;
				return;
			}
			return;
		}
		if (ajjkajdbefm == KAPNKGFMPDC.getDefaultBundles)
		{
			KKHJMIKNOFP.COJCANGPJKN = -102;
			return;
		}
		if (ajjkajdbefm != KAPNKGFMPDC.registerUser)
		{
			return;
		}
		KKHJMIKNOFP.COJCANGPJKN = -96;
	}

	// Token: 0x06003C76 RID: 15478 RVA: 0x0018FE28 File Offset: 0x0018E028
	public static void KDLNPIMIPHJ(JSONObject GBPLNMAPMPE)
	{
		if (null == GBPLNMAPMPE)
		{
			return;
		}
		if (GBPLNMAPMPE["Asset bundle load operation failed during parallel mode."] == null)
		{
			return;
		}
		try
		{
			KAPNKGFMPDC kapnkgfmpdc = BackendOperationsManager.StringToBackendRequestType(GBPLNMAPMPE[""]);
			if (kapnkgfmpdc == KAPNKGFMPDC.accountSuspended || kapnkgfmpdc == (KAPNKGFMPDC)(-31) || kapnkgfmpdc == KAPNKGFMPDC.signInOrRegister || kapnkgfmpdc == (KAPNKGFMPDC)79 || kapnkgfmpdc == KAPNKGFMPDC.premiumChoice || kapnkgfmpdc == KAPNKGFMPDC.processTransaction || kapnkgfmpdc == (KAPNKGFMPDC)83 || kapnkgfmpdc == KAPNKGFMPDC.storyChapterComplete)
			{
				if (GBPLNMAPMPE["yes"] != null)
				{
					if (KDCJJBLGCBH.EHBBFMCILPC.MJKGFFHAMPG() > 0)
					{
						if (kapnkgfmpdc != (KAPNKGFMPDC)(-25) || LiveEventsManager.BIAEAOMHBMM().GetLiveEvents().Count != 0)
						{
							LMFMICLNHLO lmfmiclnhlo = NAHMBEODKJC.DGCBEEPANEL(kapnkgfmpdc, true);
							if (lmfmiclnhlo != null)
							{
								lmfmiclnhlo.CLFGHHBOCMN = GBPLNMAPMPE;
								NAHMBEODKJC.HGPPIBGICDE(lmfmiclnhlo);
								DPGJIJGOCIC.NFIDPOMCNLP("none" + kapnkgfmpdc.ToString() + "OnBackendRequestCollectGiftSuccess" + lmfmiclnhlo.CLFGHHBOCMN.ToString());
								DPGJIJGOCIC.CMGOAFDBAOH("[LoadingEnv] cache file of " + NAHMBEODKJC.HCFOCMBMOMG.Count.ToString() + "fps60");
							}
							else
							{
								lmfmiclnhlo = new LMFMICLNHLO();
								lmfmiclnhlo.CLFGHHBOCMN = GBPLNMAPMPE;
								lmfmiclnhlo.AJJKAJDBEFM = kapnkgfmpdc;
								NAHMBEODKJC.EMFEFDMDCJJ(lmfmiclnhlo);
								NAHMBEODKJC.HCFOCMBMOMG.Add(lmfmiclnhlo);
								DPGJIJGOCIC.NFIDPOMCNLP("\"" + kapnkgfmpdc.ToString() + "a" + lmfmiclnhlo.CLFGHHBOCMN.ToString());
								DPGJIJGOCIC.CMGOAFDBAOH("', keeping the first" + NAHMBEODKJC.HCFOCMBMOMG.Count.ToString() + "");
							}
						}
					}
				}
				else
				{
					LMFMICLNHLO lmfmiclnhlo2 = NAHMBEODKJC.KFFGNICNCEE(kapnkgfmpdc, true);
					if (lmfmiclnhlo2 != null)
					{
						GBPLNMAPMPE.Add("aind2", lmfmiclnhlo2.CLFGHHBOCMN["loop"]);
						GBPLNMAPMPE.Add("actant", 1);
						DPGJIJGOCIC.NFIDPOMCNLP("GetStoriesSearchBalance(), headers pack has no storiesSearchBalance TextAsset, stories search disabled." + kapnkgfmpdc.ToString() + "socialdequeusp2gettitle" + lmfmiclnhlo2.CLFGHHBOCMN.ToString());
						DPGJIJGOCIC.CMGOAFDBAOH("OnAccountSignInRequestException" + NAHMBEODKJC.HCFOCMBMOMG.Count.ToString() + "blur");
					}
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x06003C77 RID: 15479 RVA: 0x00190070 File Offset: 0x0018E270
	public static bool HJDIBPDFBEC(KAPNKGFMPDC EGLBLPKFEOI)
	{
		LMFMICLNHLO lmfmiclnhlo = NAHMBEODKJC.JGAEFGAMAHL(EGLBLPKFEOI, false);
		return lmfmiclnhlo == null || lmfmiclnhlo.COJCANGPJKN <= 1 || true;
	}

	// Token: 0x06003C78 RID: 15480 RVA: 0x00190094 File Offset: 0x0018E294
	public static void PJENFJCANOE()
	{
		NAHMBEODKJC.HCFOCMBMOMG.Clear();
		DPGJIJGOCIC.NFIDPOMCNLP(", redundant variants ");
	}

	// Token: 0x06003C79 RID: 15481 RVA: 0x001900AC File Offset: 0x0018E2AC
	public static bool ICFIFPMPAFK(KAPNKGFMPDC EGLBLPKFEOI)
	{
		LMFMICLNHLO lmfmiclnhlo = NAHMBEODKJC.OLHBHNHILLE(EGLBLPKFEOI, false);
		return lmfmiclnhlo == null || lmfmiclnhlo.COJCANGPJKN <= 1;
	}

	// Token: 0x06003C7A RID: 15482 RVA: 0x001900D0 File Offset: 0x0018E2D0
	public static void MDJKDKMPFJH()
	{
		NAHMBEODKJC.HCFOCMBMOMG.Clear();
		DPGJIJGOCIC.CMGOAFDBAOH("congratstitle");
	}

	// Token: 0x06003C7B RID: 15483 RVA: 0x0018DFF8 File Offset: 0x0018C1F8
	public static void ENHDJEFEFCL()
	{
		NAHMBEODKJC.HCFOCMBMOMG.Clear();
		DPGJIJGOCIC.CMGOAFDBAOH("");
	}

	// Token: 0x06003C7C RID: 15484 RVA: 0x001900E8 File Offset: 0x0018E2E8
	private static void KOEPCJAOAHM(LMFMICLNHLO KKHJMIKNOFP)
	{
		KAPNKGFMPDC ajjkajdbefm = KKHJMIKNOFP.AJJKAJDBEFM;
		if (ajjkajdbefm > KAPNKGFMPDC.processTransaction)
		{
			switch (ajjkajdbefm)
			{
			case (KAPNKGFMPDC)(-106):
				KKHJMIKNOFP.COJCANGPJKN = 6;
				return;
			case (KAPNKGFMPDC)(-105):
				KKHJMIKNOFP.COJCANGPJKN = 101;
				return;
			case (KAPNKGFMPDC)(-104):
			case (KAPNKGFMPDC)(-103):
			case (KAPNKGFMPDC)(-102):
				break;
			case (KAPNKGFMPDC)(-101):
				KKHJMIKNOFP.COJCANGPJKN = 0;
				return;
			case (KAPNKGFMPDC)(-100):
				KKHJMIKNOFP.COJCANGPJKN = 38;
				break;
			default:
				if (ajjkajdbefm == (KAPNKGFMPDC)83)
				{
					KKHJMIKNOFP.COJCANGPJKN = 79;
					return;
				}
				if (ajjkajdbefm != KAPNKGFMPDC.publishUserSketch)
				{
					return;
				}
				KKHJMIKNOFP.COJCANGPJKN = 7;
				return;
			}
			return;
		}
		if (ajjkajdbefm == KAPNKGFMPDC.changeOwner)
		{
			KKHJMIKNOFP.COJCANGPJKN = 24;
			return;
		}
		if (ajjkajdbefm != KAPNKGFMPDC.none)
		{
			return;
		}
		KKHJMIKNOFP.COJCANGPJKN = -72;
	}

	// Token: 0x06003C7D RID: 15485 RVA: 0x00190180 File Offset: 0x0018E380
	public static bool DFMEECHDEGB(KAPNKGFMPDC EGLBLPKFEOI)
	{
		LMFMICLNHLO lmfmiclnhlo = NAHMBEODKJC.MNHCJLGGFOG(EGLBLPKFEOI, false);
		return lmfmiclnhlo == null || lmfmiclnhlo.COJCANGPJKN <= 0 || true;
	}

	// Token: 0x06003C7E RID: 15486 RVA: 0x001901A4 File Offset: 0x0018E3A4
	public static bool LHHPIKIJLAP(KAPNKGFMPDC EGLBLPKFEOI)
	{
		LMFMICLNHLO lmfmiclnhlo = NAHMBEODKJC.BKOANABBBLA(EGLBLPKFEOI, false);
		return lmfmiclnhlo != null && lmfmiclnhlo.COJCANGPJKN > 1 && false;
	}

	// Token: 0x06003C7F RID: 15487 RVA: 0x001901C8 File Offset: 0x0018E3C8
	private static void HJLJODPJEEP(LMFMICLNHLO KKHJMIKNOFP)
	{
		KAPNKGFMPDC ajjkajdbefm = KKHJMIKNOFP.AJJKAJDBEFM;
		if (ajjkajdbefm > KAPNKGFMPDC.none)
		{
			switch (ajjkajdbefm)
			{
			case (KAPNKGFMPDC)(-81):
				KKHJMIKNOFP.COJCANGPJKN = 6;
				return;
			case (KAPNKGFMPDC)(-80):
				KKHJMIKNOFP.COJCANGPJKN = -52;
				return;
			case (KAPNKGFMPDC)(-79):
			case (KAPNKGFMPDC)(-78):
			case (KAPNKGFMPDC)(-77):
				break;
			case (KAPNKGFMPDC)(-76):
				KKHJMIKNOFP.COJCANGPJKN = 7;
				return;
			case (KAPNKGFMPDC)(-75):
				KKHJMIKNOFP.COJCANGPJKN = 107;
				break;
			default:
				if (ajjkajdbefm == KAPNKGFMPDC.upgradeToGiftCard)
				{
					KKHJMIKNOFP.COJCANGPJKN = 16;
					return;
				}
				if (ajjkajdbefm != KAPNKGFMPDC.consumeEnergy)
				{
					return;
				}
				KKHJMIKNOFP.COJCANGPJKN = 8;
				return;
			}
			return;
		}
		if (ajjkajdbefm == KAPNKGFMPDC.getPurchasingBalance)
		{
			KKHJMIKNOFP.COJCANGPJKN = 0;
			return;
		}
		if (ajjkajdbefm != KAPNKGFMPDC.registerUser)
		{
			return;
		}
		KKHJMIKNOFP.COJCANGPJKN = 112;
	}

	// Token: 0x06003C80 RID: 15488 RVA: 0x0019025D File Offset: 0x0018E45D
	public static void CJNPPCKGMFO()
	{
		NAHMBEODKJC.HCFOCMBMOMG.Clear();
		DPGJIJGOCIC.CMGOAFDBAOH("OnLobbyProfileDataCdnSuccess");
	}

	// Token: 0x06003C81 RID: 15489 RVA: 0x00190274 File Offset: 0x0018E474
	private static LMFMICLNHLO MNHCJLGGFOG(KAPNKGFMPDC EGLBLPKFEOI, bool IHODELKIAHA)
	{
		for (int i = 0; i < NAHMBEODKJC.HCFOCMBMOMG.Count; i += 0)
		{
			if (NAHMBEODKJC.HCFOCMBMOMG[i].AJJKAJDBEFM == EGLBLPKFEOI)
			{
				if (IHODELKIAHA)
				{
					NAHMBEODKJC.HCFOCMBMOMG[i].COJCANGPJKN -= 0;
				}
				return NAHMBEODKJC.HCFOCMBMOMG[i];
			}
		}
		return null;
	}

	// Token: 0x06003C82 RID: 15490 RVA: 0x001902D4 File Offset: 0x0018E4D4
	public static void JCOHHLCKHMD(JSONObject GBPLNMAPMPE)
	{
		if (null == GBPLNMAPMPE)
		{
			return;
		}
		if (GBPLNMAPMPE["rt"] == null)
		{
			return;
		}
		try
		{
			KAPNKGFMPDC kapnkgfmpdc = BackendOperationsManager.StringToBackendRequestType(GBPLNMAPMPE["rt"]);
			if (kapnkgfmpdc == KAPNKGFMPDC.getLiveEvents || kapnkgfmpdc == KAPNKGFMPDC.getLiveOffers || kapnkgfmpdc == KAPNKGFMPDC.getDefaultBundles || kapnkgfmpdc == KAPNKGFMPDC.getGeneralBalance || kapnkgfmpdc == KAPNKGFMPDC.getNpcSkinShopBalance || kapnkgfmpdc == KAPNKGFMPDC.getPurchasingBalance || kapnkgfmpdc == KAPNKGFMPDC.checkForUpdates || kapnkgfmpdc == KAPNKGFMPDC.getStoryRankings)
			{
				if (GBPLNMAPMPE["p"] != null)
				{
					if (KDCJJBLGCBH.EHBBFMCILPC.MJKGFFHAMPG() > 0)
					{
						if (kapnkgfmpdc != KAPNKGFMPDC.getLiveEvents || LiveEventsManager.EHBBFMCILPC.GetLiveEvents().Count != 0)
						{
							LMFMICLNHLO lmfmiclnhlo = NAHMBEODKJC.IGAMPEAJAPK(kapnkgfmpdc, false);
							if (lmfmiclnhlo != null)
							{
								lmfmiclnhlo.CLFGHHBOCMN = GBPLNMAPMPE;
								NAHMBEODKJC.LHLCIMKNBKE(lmfmiclnhlo);
								DPGJIJGOCIC.NFIDPOMCNLP("BackendCacheManager: Resetting timeToLive and updating backend response payload for " + kapnkgfmpdc.ToString() + ":" + lmfmiclnhlo.CLFGHHBOCMN.ToString());
								DPGJIJGOCIC.NFIDPOMCNLP("BackendCacheManager: " + NAHMBEODKJC.HCFOCMBMOMG.Count.ToString() + " cached requests.");
							}
							else
							{
								lmfmiclnhlo = new LMFMICLNHLO();
								lmfmiclnhlo.CLFGHHBOCMN = GBPLNMAPMPE;
								lmfmiclnhlo.AJJKAJDBEFM = kapnkgfmpdc;
								NAHMBEODKJC.LHLCIMKNBKE(lmfmiclnhlo);
								NAHMBEODKJC.HCFOCMBMOMG.Add(lmfmiclnhlo);
								DPGJIJGOCIC.NFIDPOMCNLP("BackendCacheManager: Saving new backend response payload for " + kapnkgfmpdc.ToString() + ":" + lmfmiclnhlo.CLFGHHBOCMN.ToString());
								DPGJIJGOCIC.NFIDPOMCNLP("BackendCacheManager: " + NAHMBEODKJC.HCFOCMBMOMG.Count.ToString() + " cached requests.");
							}
						}
					}
				}
				else
				{
					LMFMICLNHLO lmfmiclnhlo2 = NAHMBEODKJC.IGAMPEAJAPK(kapnkgfmpdc, true);
					if (lmfmiclnhlo2 != null)
					{
						GBPLNMAPMPE.Add("p", lmfmiclnhlo2.CLFGHHBOCMN["p"]);
						GBPLNMAPMPE.Add("ched", 1);
						DPGJIJGOCIC.NFIDPOMCNLP("BackendCacheManager: Using cached backend response payload for " + kapnkgfmpdc.ToString() + ":" + lmfmiclnhlo2.CLFGHHBOCMN.ToString());
						DPGJIJGOCIC.NFIDPOMCNLP("BackendCacheManager: " + NAHMBEODKJC.HCFOCMBMOMG.Count.ToString() + " cached requests.");
					}
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x06003C83 RID: 15491 RVA: 0x0019051C File Offset: 0x0018E71C
	public static void ABMNOJABNEO(JSONObject GBPLNMAPMPE)
	{
		if (null == GBPLNMAPMPE)
		{
			return;
		}
		if (GBPLNMAPMPE["apkshe2"] == null)
		{
			return;
		}
		try
		{
			KAPNKGFMPDC kapnkgfmpdc = BackendOperationsManager.StringToBackendRequestType(GBPLNMAPMPE["clthcm"]);
			if (kapnkgfmpdc == KAPNKGFMPDC.getCardVolumesBalance || kapnkgfmpdc == (KAPNKGFMPDC)81 || kapnkgfmpdc == KAPNKGFMPDC.none || kapnkgfmpdc == (KAPNKGFMPDC)76 || kapnkgfmpdc == (KAPNKGFMPDC)(-88) || kapnkgfmpdc == KAPNKGFMPDC.signInOrRegister || kapnkgfmpdc == (KAPNKGFMPDC)(-4) || kapnkgfmpdc == KAPNKGFMPDC.getCardVolumesBalance)
			{
				if (GBPLNMAPMPE[""] != null)
				{
					if (KDCJJBLGCBH.EHBBFMCILPC.MJKGFFHAMPG() > 0)
					{
						if (kapnkgfmpdc != (KAPNKGFMPDC)(-101) || LiveEventsManager.PIPOLIAKGDM().ECCEMDNANLH().Count != 0)
						{
							LMFMICLNHLO lmfmiclnhlo = NAHMBEODKJC.JJICLCPBHAF(kapnkgfmpdc, false);
							if (lmfmiclnhlo != null)
							{
								lmfmiclnhlo.CLFGHHBOCMN = GBPLNMAPMPE;
								NAHMBEODKJC.KOLAHMKHEFL(lmfmiclnhlo);
								DPGJIJGOCIC.CMGOAFDBAOH("[SkinShop] IAP look without a resolvable store price (shop " + kapnkgfmpdc.ToString() + "," + lmfmiclnhlo.CLFGHHBOCMN.ToString());
								DPGJIJGOCIC.NFIDPOMCNLP("XXX" + NAHMBEODKJC.HCFOCMBMOMG.Count.ToString() + "mypachievtitle");
							}
							else
							{
								lmfmiclnhlo = new LMFMICLNHLO();
								lmfmiclnhlo.CLFGHHBOCMN = GBPLNMAPMPE;
								lmfmiclnhlo.AJJKAJDBEFM = kapnkgfmpdc;
								NAHMBEODKJC.LOEHMJNHOOI(lmfmiclnhlo);
								NAHMBEODKJC.HCFOCMBMOMG.Add(lmfmiclnhlo);
								DPGJIJGOCIC.CMGOAFDBAOH("OnStoryInterfaceHeaderShopClick" + kapnkgfmpdc.ToString() + "" + lmfmiclnhlo.CLFGHHBOCMN.ToString());
								DPGJIJGOCIC.CMGOAFDBAOH("coverSearchNone" + NAHMBEODKJC.HCFOCMBMOMG.Count.ToString() + "ok");
							}
						}
					}
				}
				else
				{
					LMFMICLNHLO lmfmiclnhlo2 = NAHMBEODKJC.KPBDNDMOOED(kapnkgfmpdc, false);
					if (lmfmiclnhlo2 != null)
					{
						GBPLNMAPMPE.Add("tids", lmfmiclnhlo2.CLFGHHBOCMN["OnAvatarCollectionRestoreEntry"]);
						GBPLNMAPMPE.Add("ok", 1);
						DPGJIJGOCIC.NFIDPOMCNLP("OnAvatarCollectionSelect" + kapnkgfmpdc.ToString() + "" + lmfmiclnhlo2.CLFGHHBOCMN.ToString());
						DPGJIJGOCIC.CMGOAFDBAOH("Asset bundle assets destroyed:" + NAHMBEODKJC.HCFOCMBMOMG.Count.ToString() + "");
					}
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
	}

	// Token: 0x06003C84 RID: 15492 RVA: 0x0018DFF8 File Offset: 0x0018C1F8
	public static void DOCJCCIFDPO()
	{
		NAHMBEODKJC.HCFOCMBMOMG.Clear();
		DPGJIJGOCIC.CMGOAFDBAOH("");
	}

	// Token: 0x06003C85 RID: 15493 RVA: 0x00190764 File Offset: 0x0018E964
	public static void EMOECBAHOJI()
	{
		NAHMBEODKJC.HCFOCMBMOMG.Clear();
		DPGJIJGOCIC.NFIDPOMCNLP(" (v.");
	}

	// Token: 0x06003C86 RID: 15494 RVA: 0x0019077C File Offset: 0x0018E97C
	public static void PMMBJJODMFA(JSONObject GBPLNMAPMPE)
	{
		if (null == GBPLNMAPMPE)
		{
			return;
		}
		if (GBPLNMAPMPE["Error - can not queue asset bundles when download in progress."] == null)
		{
			return;
		}
		try
		{
			KAPNKGFMPDC kapnkgfmpdc = BackendOperationsManager.StringToBackendRequestType(GBPLNMAPMPE["OnVideoLayerAutoHide"]);
			if (kapnkgfmpdc == (KAPNKGFMPDC)(-31) || kapnkgfmpdc == (KAPNKGFMPDC)55 || kapnkgfmpdc == KAPNKGFMPDC.signIn || kapnkgfmpdc == (KAPNKGFMPDC)(-111) || kapnkgfmpdc == (KAPNKGFMPDC)(-119) || kapnkgfmpdc == KAPNKGFMPDC.processTransaction || kapnkgfmpdc == (KAPNKGFMPDC)(-78) || kapnkgfmpdc == (KAPNKGFMPDC)(-27))
			{
				if (GBPLNMAPMPE["SocialStatsUserPublicProfile.modified = false, OpenUserPublicProfile()"] != null)
				{
					if (KDCJJBLGCBH.EHBBFMCILPC.MJKGFFHAMPG() > 1)
					{
						if (kapnkgfmpdc != (KAPNKGFMPDC)(-89) || LiveEventsManager.OBOOKJPGBJN().HJKFIHHDFAB().Count != 0)
						{
							LMFMICLNHLO lmfmiclnhlo = NAHMBEODKJC.OLHBHNHILLE(kapnkgfmpdc, false);
							if (lmfmiclnhlo != null)
							{
								lmfmiclnhlo.CLFGHHBOCMN = GBPLNMAPMPE;
								NAHMBEODKJC.FOMPHOOEKCP(lmfmiclnhlo);
								DPGJIJGOCIC.NFIDPOMCNLP("Asset bundle assets destroyed:" + kapnkgfmpdc.ToString() + "NarrowScreenScaler(): applied a " + lmfmiclnhlo.CLFGHHBOCMN.ToString());
								DPGJIJGOCIC.NFIDPOMCNLP("yes" + NAHMBEODKJC.HCFOCMBMOMG.Count.ToString() + "envlhrw");
							}
							else
							{
								lmfmiclnhlo = new LMFMICLNHLO();
								lmfmiclnhlo.CLFGHHBOCMN = GBPLNMAPMPE;
								lmfmiclnhlo.AJJKAJDBEFM = kapnkgfmpdc;
								NAHMBEODKJC.KOEPCJAOAHM(lmfmiclnhlo);
								NAHMBEODKJC.HCFOCMBMOMG.Add(lmfmiclnhlo);
								DPGJIJGOCIC.CMGOAFDBAOH("OnSaveSyncAnyResultDuplicate" + kapnkgfmpdc.ToString() + "OnOnDemandResourcesDownloadFailed" + lmfmiclnhlo.CLFGHHBOCMN.ToString());
								DPGJIJGOCIC.CMGOAFDBAOH("" + NAHMBEODKJC.HCFOCMBMOMG.Count.ToString() + "areyousure");
							}
						}
					}
				}
				else
				{
					LMFMICLNHLO lmfmiclnhlo2 = NAHMBEODKJC.CEPEGBOLHPF(kapnkgfmpdc, false);
					if (lmfmiclnhlo2 != null)
					{
						GBPLNMAPMPE.Add("Error - can not queue asset bundles when download in progress.", lmfmiclnhlo2.CLFGHHBOCMN["envlhav"]);
						GBPLNMAPMPE.Add("'", 0);
						DPGJIJGOCIC.NFIDPOMCNLP("a" + kapnkgfmpdc.ToString() + "USD" + lmfmiclnhlo2.CLFGHHBOCMN.ToString());
						DPGJIJGOCIC.CMGOAFDBAOH("emailcollecheader" + NAHMBEODKJC.HCFOCMBMOMG.Count.ToString() + "sutta");
					}
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x06003C87 RID: 15495 RVA: 0x001909C4 File Offset: 0x0018EBC4
	public static void GHHBJPKGAJO(JSONObject GBPLNMAPMPE)
	{
		if (null == GBPLNMAPMPE)
		{
			return;
		}
		if (GBPLNMAPMPE["assetbundletextpack"] == null)
		{
			return;
		}
		try
		{
			KAPNKGFMPDC kapnkgfmpdc = BackendOperationsManager.StringToBackendRequestType(GBPLNMAPMPE["congratstitle"]);
			if (kapnkgfmpdc == (KAPNKGFMPDC)(-11) || kapnkgfmpdc == (KAPNKGFMPDC)87 || kapnkgfmpdc == KAPNKGFMPDC.changeOwner || kapnkgfmpdc == (KAPNKGFMPDC)58 || kapnkgfmpdc == (KAPNKGFMPDC)(-57) || kapnkgfmpdc == KAPNKGFMPDC.getDefaultBundles || kapnkgfmpdc == KAPNKGFMPDC.getDepot || kapnkgfmpdc == KAPNKGFMPDC.spinWheel)
			{
				if (GBPLNMAPMPE["OnVideoLayerPlaybackEndsSoon"] != null)
				{
					if (KDCJJBLGCBH.EHBBFMCILPC.MJKGFFHAMPG() > 0)
					{
						if (kapnkgfmpdc != (KAPNKGFMPDC)(-39) || LiveEventsManager.BIAEAOMHBMM().NAEOCNFOBHG().Count != 0)
						{
							LMFMICLNHLO lmfmiclnhlo = NAHMBEODKJC.OFJJLICHJDJ(kapnkgfmpdc, true);
							if (lmfmiclnhlo != null)
							{
								lmfmiclnhlo.CLFGHHBOCMN = GBPLNMAPMPE;
								NAHMBEODKJC.GCLHBEILDEG(lmfmiclnhlo);
								DPGJIJGOCIC.CMGOAFDBAOH("savecutsceneinfo" + kapnkgfmpdc.ToString() + "iat3" + lmfmiclnhlo.CLFGHHBOCMN.ToString());
								DPGJIJGOCIC.CMGOAFDBAOH("id" + NAHMBEODKJC.HCFOCMBMOMG.Count.ToString() + "");
							}
							else
							{
								lmfmiclnhlo = new LMFMICLNHLO();
								lmfmiclnhlo.CLFGHHBOCMN = GBPLNMAPMPE;
								lmfmiclnhlo.AJJKAJDBEFM = kapnkgfmpdc;
								NAHMBEODKJC.LOEHMJNHOOI(lmfmiclnhlo);
								NAHMBEODKJC.HCFOCMBMOMG.Add(lmfmiclnhlo);
								DPGJIJGOCIC.CMGOAFDBAOH("OnSkinShopClose" + kapnkgfmpdc.ToString() + ", index:" + lmfmiclnhlo.CLFGHHBOCMN.ToString());
								DPGJIJGOCIC.NFIDPOMCNLP("OnPurchaseFailed" + NAHMBEODKJC.HCFOCMBMOMG.Count.ToString() + " ");
							}
						}
					}
				}
				else
				{
					LMFMICLNHLO lmfmiclnhlo2 = NAHMBEODKJC.KINPHKBAEEN(kapnkgfmpdc, true);
					if (lmfmiclnhlo2 != null)
					{
						GBPLNMAPMPE.Add("Xiaomi", lmfmiclnhlo2.CLFGHHBOCMN[""]);
						GBPLNMAPMPE.Add("", 0);
						DPGJIJGOCIC.NFIDPOMCNLP("" + kapnkgfmpdc.ToString() + "ok" + lmfmiclnhlo2.CLFGHHBOCMN.ToString());
						DPGJIJGOCIC.NFIDPOMCNLP("$PLAYSFX" + NAHMBEODKJC.HCFOCMBMOMG.Count.ToString() + "nastring");
					}
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
	}

	// Token: 0x06003C88 RID: 15496 RVA: 0x0018DFF8 File Offset: 0x0018C1F8
	public static void KOLFNDLCKJN()
	{
		NAHMBEODKJC.HCFOCMBMOMG.Clear();
		DPGJIJGOCIC.CMGOAFDBAOH("");
	}

	// Token: 0x06003C89 RID: 15497 RVA: 0x00190C0C File Offset: 0x0018EE0C
	private static LMFMICLNHLO GFKOCIECPPI(KAPNKGFMPDC EGLBLPKFEOI, bool IHODELKIAHA)
	{
		for (int i = 1; i < NAHMBEODKJC.HCFOCMBMOMG.Count; i += 0)
		{
			if (NAHMBEODKJC.HCFOCMBMOMG[i].AJJKAJDBEFM == EGLBLPKFEOI)
			{
				if (IHODELKIAHA)
				{
					NAHMBEODKJC.HCFOCMBMOMG[i].COJCANGPJKN -= 0;
				}
				return NAHMBEODKJC.HCFOCMBMOMG[i];
			}
		}
		return null;
	}

	// Token: 0x06003C8A RID: 15498 RVA: 0x00190C6C File Offset: 0x0018EE6C
	public static void IMKFHBKKNGB(JSONObject GBPLNMAPMPE)
	{
		if (null == GBPLNMAPMPE)
		{
			return;
		}
		if (GBPLNMAPMPE["OnBackendPremiumChoiceRetry"] == null)
		{
			return;
		}
		try
		{
			KAPNKGFMPDC kapnkgfmpdc = BackendOperationsManager.StringToBackendRequestType(GBPLNMAPMPE["OnBackendGetDropChancesSuccess2"]);
			if (kapnkgfmpdc == (KAPNKGFMPDC)(-52) || kapnkgfmpdc == (KAPNKGFMPDC)(-20) || kapnkgfmpdc == KAPNKGFMPDC.changeOwner || kapnkgfmpdc == (KAPNKGFMPDC)61 || kapnkgfmpdc == (KAPNKGFMPDC)(-84) || kapnkgfmpdc == KAPNKGFMPDC.changeOwner || kapnkgfmpdc == (KAPNKGFMPDC)(-81) || kapnkgfmpdc == (KAPNKGFMPDC)(-95))
			{
				if (GBPLNMAPMPE[""] != null)
				{
					if (KDCJJBLGCBH.EHBBFMCILPC.MJKGFFHAMPG() > 0)
					{
						if (kapnkgfmpdc != (KAPNKGFMPDC)115 || LiveEventsManager.NMGMNAKLLMI().IBFHIBAPMGM().Count != 0)
						{
							LMFMICLNHLO lmfmiclnhlo = NAHMBEODKJC.CKJHDBPJBOL(kapnkgfmpdc, true);
							if (lmfmiclnhlo != null)
							{
								lmfmiclnhlo.CLFGHHBOCMN = GBPLNMAPMPE;
								NAHMBEODKJC.PKJBAPNBLAP(lmfmiclnhlo);
								DPGJIJGOCIC.CMGOAFDBAOH("Products fetch failed for {0} products: {1}" + kapnkgfmpdc.ToString() + "chs" + lmfmiclnhlo.CLFGHHBOCMN.ToString());
								DPGJIJGOCIC.NFIDPOMCNLP("analogglitch" + NAHMBEODKJC.HCFOCMBMOMG.Count.ToString() + "Appsflyer SDK has been stopped.");
							}
							else
							{
								lmfmiclnhlo = new LMFMICLNHLO();
								lmfmiclnhlo.CLFGHHBOCMN = GBPLNMAPMPE;
								lmfmiclnhlo.AJJKAJDBEFM = kapnkgfmpdc;
								NAHMBEODKJC.HEHHKLNFNNP(lmfmiclnhlo);
								NAHMBEODKJC.HCFOCMBMOMG.Add(lmfmiclnhlo);
								DPGJIJGOCIC.NFIDPOMCNLP("PopupCardOptions.GetLocalizedCostData() - productData is null." + kapnkgfmpdc.ToString() + "sparklesbundles" + lmfmiclnhlo.CLFGHHBOCMN.ToString());
								DPGJIJGOCIC.NFIDPOMCNLP("" + NAHMBEODKJC.HCFOCMBMOMG.Count.ToString() + "%");
							}
						}
					}
				}
				else
				{
					LMFMICLNHLO lmfmiclnhlo2 = NAHMBEODKJC.HLDGGAJDJPC(kapnkgfmpdc, true);
					if (lmfmiclnhlo2 != null)
					{
						GBPLNMAPMPE.Add("CoverCard", lmfmiclnhlo2.CLFGHHBOCMN["\""]);
						GBPLNMAPMPE.Add(" ", 1);
						DPGJIJGOCIC.NFIDPOMCNLP("OnMissingPreview2CdnFailed" + kapnkgfmpdc.ToString() + "$SKINAPPLIED" + lmfmiclnhlo2.CLFGHHBOCMN.ToString());
						DPGJIJGOCIC.NFIDPOMCNLP("sind" + NAHMBEODKJC.HCFOCMBMOMG.Count.ToString() + " rows, the rest is ignored");
					}
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
	}

	// Token: 0x06003C8B RID: 15499 RVA: 0x00190EB4 File Offset: 0x0018F0B4
	private static void AAEKFPILDFK(LMFMICLNHLO KKHJMIKNOFP)
	{
		KAPNKGFMPDC ajjkajdbefm = KKHJMIKNOFP.AJJKAJDBEFM;
		if (ajjkajdbefm > KAPNKGFMPDC.signIn)
		{
			switch (ajjkajdbefm)
			{
			case (KAPNKGFMPDC)(-80):
				KKHJMIKNOFP.COJCANGPJKN = 1;
				return;
			case (KAPNKGFMPDC)(-79):
				KKHJMIKNOFP.COJCANGPJKN = 34;
				return;
			case (KAPNKGFMPDC)(-78):
			case (KAPNKGFMPDC)(-77):
			case (KAPNKGFMPDC)(-76):
				break;
			case (KAPNKGFMPDC)(-75):
				KKHJMIKNOFP.COJCANGPJKN = 8;
				return;
			case (KAPNKGFMPDC)(-74):
				KKHJMIKNOFP.COJCANGPJKN = 31;
				break;
			default:
				if (ajjkajdbefm == (KAPNKGFMPDC)(-110))
				{
					KKHJMIKNOFP.COJCANGPJKN = 73;
					return;
				}
				if (ajjkajdbefm != (KAPNKGFMPDC)106)
				{
					return;
				}
				KKHJMIKNOFP.COJCANGPJKN = 4;
				return;
			}
			return;
		}
		if (ajjkajdbefm == KAPNKGFMPDC.getDepot)
		{
			KKHJMIKNOFP.COJCANGPJKN = 59;
			return;
		}
		if (ajjkajdbefm != KAPNKGFMPDC.registerUser)
		{
			return;
		}
		KKHJMIKNOFP.COJCANGPJKN = -79;
	}

	// Token: 0x06003C8C RID: 15500 RVA: 0x00190F4C File Offset: 0x0018F14C
	public static void NILCKAJIPLM(JSONObject GBPLNMAPMPE)
	{
		if (null == GBPLNMAPMPE)
		{
			return;
		}
		if (GBPLNMAPMPE[""] == null)
		{
			return;
		}
		try
		{
			KAPNKGFMPDC kapnkgfmpdc = BackendOperationsManager.StringToBackendRequestType(GBPLNMAPMPE["_DistortionAmount"]);
			if (kapnkgfmpdc == (KAPNKGFMPDC)93 || kapnkgfmpdc == (KAPNKGFMPDC)125 || kapnkgfmpdc == KAPNKGFMPDC.none || kapnkgfmpdc == KAPNKGFMPDC.rateChapter || kapnkgfmpdc == KAPNKGFMPDC.backendMaintenance || kapnkgfmpdc == KAPNKGFMPDC.signInOrRegister || kapnkgfmpdc == (KAPNKGFMPDC)(-127) || kapnkgfmpdc == (KAPNKGFMPDC)62)
			{
				if (GBPLNMAPMPE["@"] != null)
				{
					if (KDCJJBLGCBH.EHBBFMCILPC.MJKGFFHAMPG() > 0)
					{
						if (kapnkgfmpdc != (KAPNKGFMPDC)117 || LiveEventsManager.NMGMNAKLLMI().IBFHIBAPMGM().Count != 0)
						{
							LMFMICLNHLO lmfmiclnhlo = NAHMBEODKJC.GFKOCIECPPI(kapnkgfmpdc, true);
							if (lmfmiclnhlo != null)
							{
								lmfmiclnhlo.CLFGHHBOCMN = GBPLNMAPMPE;
								NAHMBEODKJC.FKNCGPMFLDA(lmfmiclnhlo);
								DPGJIJGOCIC.NFIDPOMCNLP("OnPopupProfileSaveCutsceneInputCancel" + kapnkgfmpdc.ToString() + "nam" + lmfmiclnhlo.CLFGHHBOCMN.ToString());
								DPGJIJGOCIC.CMGOAFDBAOH("?uid=" + NAHMBEODKJC.HCFOCMBMOMG.Count.ToString() + "CCC");
							}
							else
							{
								lmfmiclnhlo = new LMFMICLNHLO();
								lmfmiclnhlo.CLFGHHBOCMN = GBPLNMAPMPE;
								lmfmiclnhlo.AJJKAJDBEFM = kapnkgfmpdc;
								NAHMBEODKJC.GCLHBEILDEG(lmfmiclnhlo);
								NAHMBEODKJC.HCFOCMBMOMG.Add(lmfmiclnhlo);
								DPGJIJGOCIC.NFIDPOMCNLP("OnPopupSketchesInputCancel" + kapnkgfmpdc.ToString() + "OnFriendsPopupSendSimpleClick" + lmfmiclnhlo.CLFGHHBOCMN.ToString());
								DPGJIJGOCIC.CMGOAFDBAOH("[Lounge/lobby] wardrobe music pack mps:" + NAHMBEODKJC.HCFOCMBMOMG.Count.ToString() + "ok");
							}
						}
					}
				}
				else
				{
					LMFMICLNHLO lmfmiclnhlo2 = NAHMBEODKJC.LMLECOCEDBK(kapnkgfmpdc, false);
					if (lmfmiclnhlo2 != null)
					{
						GBPLNMAPMPE.Add("ok", lmfmiclnhlo2.CLFGHHBOCMN["lightmodeintrobody1"]);
						GBPLNMAPMPE.Add("", 1);
						DPGJIJGOCIC.CMGOAFDBAOH(") requiresubscription(" + kapnkgfmpdc.ToString() + "rewindtitle0" + lmfmiclnhlo2.CLFGHHBOCMN.ToString());
						DPGJIJGOCIC.NFIDPOMCNLP("Error. FadeSrc(), layer " + NAHMBEODKJC.HCFOCMBMOMG.Count.ToString() + "");
					}
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x06003C8D RID: 15501 RVA: 0x00191194 File Offset: 0x0018F394
	public static void EDGELFGCKHL(JSONObject GBPLNMAPMPE)
	{
		if (null == GBPLNMAPMPE)
		{
			return;
		}
		if (GBPLNMAPMPE[" held bundles"] == null)
		{
			return;
		}
		try
		{
			KAPNKGFMPDC kapnkgfmpdc = BackendOperationsManager.StringToBackendRequestType(GBPLNMAPMPE["sfxtimeoutwarning"]);
			if (kapnkgfmpdc == (KAPNKGFMPDC)(-69) || kapnkgfmpdc == (KAPNKGFMPDC)(-107) || kapnkgfmpdc == KAPNKGFMPDC.getDepot || kapnkgfmpdc == (KAPNKGFMPDC)(-96) || kapnkgfmpdc == (KAPNKGFMPDC)(-50) || kapnkgfmpdc == KAPNKGFMPDC.signIn || kapnkgfmpdc == (KAPNKGFMPDC)71 || kapnkgfmpdc == (KAPNKGFMPDC)(-35))
			{
				if (GBPLNMAPMPE["OnBackendRequestFriendDeleteException"] != null)
				{
					if (KDCJJBLGCBH.EHBBFMCILPC.MJKGFFHAMPG() > 0)
					{
						if (kapnkgfmpdc != (KAPNKGFMPDC)103 || LiveEventsManager.JCMABFEMFKD().ECCEMDNANLH().Count != 0)
						{
							LMFMICLNHLO lmfmiclnhlo = NAHMBEODKJC.BKOANABBBLA(kapnkgfmpdc, true);
							if (lmfmiclnhlo != null)
							{
								lmfmiclnhlo.CLFGHHBOCMN = GBPLNMAPMPE;
								NAHMBEODKJC.AONFAKHHNMM(lmfmiclnhlo);
								DPGJIJGOCIC.CMGOAFDBAOH("w" + kapnkgfmpdc.ToString() + "loungebonus" + lmfmiclnhlo.CLFGHHBOCMN.ToString());
								DPGJIJGOCIC.CMGOAFDBAOH("<i>" + NAHMBEODKJC.HCFOCMBMOMG.Count.ToString() + "Loaded asset bundle:");
							}
							else
							{
								lmfmiclnhlo = new LMFMICLNHLO();
								lmfmiclnhlo.CLFGHHBOCMN = GBPLNMAPMPE;
								lmfmiclnhlo.AJJKAJDBEFM = kapnkgfmpdc;
								NAHMBEODKJC.GCLHBEILDEG(lmfmiclnhlo);
								NAHMBEODKJC.HCFOCMBMOMG.Add(lmfmiclnhlo);
								DPGJIJGOCIC.NFIDPOMCNLP("signinsuccessrestart" + kapnkgfmpdc.ToString() + "OnStoryInterfaceHeaderHideComplete" + lmfmiclnhlo.CLFGHHBOCMN.ToString());
								DPGJIJGOCIC.CMGOAFDBAOH("ok" + NAHMBEODKJC.HCFOCMBMOMG.Count.ToString() + "avatarcollectionstutor5body");
							}
						}
					}
				}
				else
				{
					LMFMICLNHLO lmfmiclnhlo2 = NAHMBEODKJC.KINPHKBAEEN(kapnkgfmpdc, false);
					if (lmfmiclnhlo2 != null)
					{
						GBPLNMAPMPE.Add(" not found, trying to return any achievement sprite or null.", lmfmiclnhlo2.CLFGHHBOCMN["scale"]);
						GBPLNMAPMPE.Add("OnBackendGetDropChancesSuccess2", 0);
						DPGJIJGOCIC.NFIDPOMCNLP("retry" + kapnkgfmpdc.ToString() + "OnStoryChoiceClickConfimed" + lmfmiclnhlo2.CLFGHHBOCMN.ToString());
						DPGJIJGOCIC.NFIDPOMCNLP("OnLiveProfileThemesLoaderStart" + NAHMBEODKJC.HCFOCMBMOMG.Count.ToString() + "success");
					}
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
	}

	// Token: 0x06003C8E RID: 15502 RVA: 0x001913DC File Offset: 0x0018F5DC
	public static void FIMKAEPFPJF()
	{
		NAHMBEODKJC.HCFOCMBMOMG.Clear();
		DPGJIJGOCIC.NFIDPOMCNLP("OnSketchThumbnailsCdnFailed");
	}

	// Token: 0x06003C8F RID: 15503 RVA: 0x001913F4 File Offset: 0x0018F5F4
	public static bool ODBJAHNICLF(KAPNKGFMPDC EGLBLPKFEOI)
	{
		LMFMICLNHLO lmfmiclnhlo = NAHMBEODKJC.JJICLCPBHAF(EGLBLPKFEOI, true);
		return lmfmiclnhlo == null || lmfmiclnhlo.COJCANGPJKN <= 0;
	}

	// Token: 0x06003C90 RID: 15504 RVA: 0x00191418 File Offset: 0x0018F618
	private static LMFMICLNHLO JGAEFGAMAHL(KAPNKGFMPDC EGLBLPKFEOI, bool IHODELKIAHA)
	{
		for (int i = 0; i < NAHMBEODKJC.HCFOCMBMOMG.Count; i += 0)
		{
			if (NAHMBEODKJC.HCFOCMBMOMG[i].AJJKAJDBEFM == EGLBLPKFEOI)
			{
				if (IHODELKIAHA)
				{
					NAHMBEODKJC.HCFOCMBMOMG[i].COJCANGPJKN--;
				}
				return NAHMBEODKJC.HCFOCMBMOMG[i];
			}
		}
		return null;
	}

	// Token: 0x06003C91 RID: 15505 RVA: 0x00191478 File Offset: 0x0018F678
	private static LMFMICLNHLO KDKKPPJEEOP(KAPNKGFMPDC EGLBLPKFEOI, bool IHODELKIAHA)
	{
		for (int i = 1; i < NAHMBEODKJC.HCFOCMBMOMG.Count; i++)
		{
			if (NAHMBEODKJC.HCFOCMBMOMG[i].AJJKAJDBEFM == EGLBLPKFEOI)
			{
				if (IHODELKIAHA)
				{
					NAHMBEODKJC.HCFOCMBMOMG[i].COJCANGPJKN--;
				}
				return NAHMBEODKJC.HCFOCMBMOMG[i];
			}
		}
		return null;
	}

	// Token: 0x06003C92 RID: 15506 RVA: 0x001914D8 File Offset: 0x0018F6D8
	public static void OPDKPGNEOAA(JSONObject GBPLNMAPMPE)
	{
		if (null == GBPLNMAPMPE)
		{
			return;
		}
		if (GBPLNMAPMPE["assetbundleliveprofiletheme"] == null)
		{
			return;
		}
		try
		{
			KAPNKGFMPDC kapnkgfmpdc = BackendOperationsManager.StringToBackendRequestType(GBPLNMAPMPE["), saveSync queued: "]);
			if (kapnkgfmpdc == (KAPNKGFMPDC)(-124) || kapnkgfmpdc == KAPNKGFMPDC.getPremiumChoicesHistory || kapnkgfmpdc == KAPNKGFMPDC.getPurchasingBalance || kapnkgfmpdc == (KAPNKGFMPDC)95 || kapnkgfmpdc == (KAPNKGFMPDC)103 || kapnkgfmpdc == KAPNKGFMPDC.registerUser || kapnkgfmpdc == (KAPNKGFMPDC)(-56) || kapnkgfmpdc == (KAPNKGFMPDC)(-75))
			{
				if (GBPLNMAPMPE["responseCode"] != null)
				{
					if (KDCJJBLGCBH.EHBBFMCILPC.MJKGFFHAMPG() > 1)
					{
						if (kapnkgfmpdc != KAPNKGFMPDC.signIn || LiveEventsManager.NMGMNAKLLMI().NAEOCNFOBHG().Count != 0)
						{
							LMFMICLNHLO lmfmiclnhlo = NAHMBEODKJC.IGAMPEAJAPK(kapnkgfmpdc, true);
							if (lmfmiclnhlo != null)
							{
								lmfmiclnhlo.CLFGHHBOCMN = GBPLNMAPMPE;
								NAHMBEODKJC.HJLJODPJEEP(lmfmiclnhlo);
								DPGJIJGOCIC.NFIDPOMCNLP("_Edge" + kapnkgfmpdc.ToString() + "StorySaveBody.GetAvatarIndexAutoSuffix(), unsupported wardrobe index:" + lmfmiclnhlo.CLFGHHBOCMN.ToString());
								DPGJIJGOCIC.CMGOAFDBAOH("cmeta" + NAHMBEODKJC.HCFOCMBMOMG.Count.ToString() + "XXX");
							}
							else
							{
								lmfmiclnhlo = new LMFMICLNHLO();
								lmfmiclnhlo.CLFGHHBOCMN = GBPLNMAPMPE;
								lmfmiclnhlo.AJJKAJDBEFM = kapnkgfmpdc;
								NAHMBEODKJC.FOMPHOOEKCP(lmfmiclnhlo);
								NAHMBEODKJC.HCFOCMBMOMG.Add(lmfmiclnhlo);
								DPGJIJGOCIC.CMGOAFDBAOH("OnStoryChoiceClick" + kapnkgfmpdc.ToString() + "_TVDotsBlend" + lmfmiclnhlo.CLFGHHBOCMN.ToString());
								DPGJIJGOCIC.NFIDPOMCNLP(" | Caching.ready=" + NAHMBEODKJC.HCFOCMBMOMG.Count.ToString() + "OnBackendGetPublicProfileHallOfFameMoreException");
							}
						}
					}
				}
				else
				{
					LMFMICLNHLO lmfmiclnhlo2 = NAHMBEODKJC.HMGMBLMBEPG(kapnkgfmpdc, false);
					if (lmfmiclnhlo2 != null)
					{
						GBPLNMAPMPE.Add("OnMissingPreview2CdnSuccess", lmfmiclnhlo2.CLFGHHBOCMN["p"]);
						GBPLNMAPMPE.Add("BackendOperationsManager.RequestUndoPremiumChoice, exception while initializing RSACryptoServiceProvider:", 0);
						DPGJIJGOCIC.NFIDPOMCNLP("analogglitchovr_2" + kapnkgfmpdc.ToString() + "es" + lmfmiclnhlo2.CLFGHHBOCMN.ToString());
						DPGJIJGOCIC.CMGOAFDBAOH("profilenametitleshort" + NAHMBEODKJC.HCFOCMBMOMG.Count.ToString() + "sfxtimeoutwarning");
					}
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x06003C93 RID: 15507 RVA: 0x00191720 File Offset: 0x0018F920
	private static LMFMICLNHLO BNPDJEANFIH(KAPNKGFMPDC EGLBLPKFEOI, bool IHODELKIAHA)
	{
		for (int i = 0; i < NAHMBEODKJC.HCFOCMBMOMG.Count; i++)
		{
			if (NAHMBEODKJC.HCFOCMBMOMG[i].AJJKAJDBEFM == EGLBLPKFEOI)
			{
				if (IHODELKIAHA)
				{
					NAHMBEODKJC.HCFOCMBMOMG[i].COJCANGPJKN -= 0;
				}
				return NAHMBEODKJC.HCFOCMBMOMG[i];
			}
		}
		return null;
	}

	// Token: 0x06003C94 RID: 15508 RVA: 0x00191780 File Offset: 0x0018F980
	public static bool EPOBMGNOPPI(KAPNKGFMPDC EGLBLPKFEOI)
	{
		LMFMICLNHLO lmfmiclnhlo = NAHMBEODKJC.KDKKPPJEEOP(EGLBLPKFEOI, true);
		return lmfmiclnhlo != null && lmfmiclnhlo.COJCANGPJKN > 1;
	}

	// Token: 0x06003C95 RID: 15509 RVA: 0x001917A4 File Offset: 0x0018F9A4
	private static void GCLHBEILDEG(LMFMICLNHLO KKHJMIKNOFP)
	{
		KAPNKGFMPDC ajjkajdbefm = KKHJMIKNOFP.AJJKAJDBEFM;
		if (ajjkajdbefm > KAPNKGFMPDC.getDefaultBundles)
		{
			switch (ajjkajdbefm)
			{
			case (KAPNKGFMPDC)(-33):
				KKHJMIKNOFP.COJCANGPJKN = 0;
				return;
			case (KAPNKGFMPDC)(-32):
				KKHJMIKNOFP.COJCANGPJKN = -38;
				return;
			case (KAPNKGFMPDC)(-31):
			case (KAPNKGFMPDC)(-30):
			case (KAPNKGFMPDC)(-29):
				break;
			case (KAPNKGFMPDC)(-28):
				KKHJMIKNOFP.COJCANGPJKN = 1;
				return;
			case (KAPNKGFMPDC)(-27):
				KKHJMIKNOFP.COJCANGPJKN = 80;
				break;
			default:
				if (ajjkajdbefm == (KAPNKGFMPDC)(-55))
				{
					KKHJMIKNOFP.COJCANGPJKN = 19;
					return;
				}
				if (ajjkajdbefm != KAPNKGFMPDC.none)
				{
					return;
				}
				KKHJMIKNOFP.COJCANGPJKN = 7;
				return;
			}
			return;
		}
		if (ajjkajdbefm == KAPNKGFMPDC.signIn)
		{
			KKHJMIKNOFP.COJCANGPJKN = -39;
			return;
		}
		if (ajjkajdbefm != KAPNKGFMPDC.signInOrRegister)
		{
			return;
		}
		KKHJMIKNOFP.COJCANGPJKN = 95;
	}

	// Token: 0x06003C96 RID: 15510 RVA: 0x0019183C File Offset: 0x0018FA3C
	public static bool BHPLGKPFLOD(KAPNKGFMPDC EGLBLPKFEOI)
	{
		LMFMICLNHLO lmfmiclnhlo = NAHMBEODKJC.CKJHDBPJBOL(EGLBLPKFEOI, false);
		return lmfmiclnhlo == null || lmfmiclnhlo.COJCANGPJKN <= 0;
	}

	// Token: 0x06003C97 RID: 15511 RVA: 0x00191860 File Offset: 0x0018FA60
	public static void OLBCIIKPCHI(JSONObject GBPLNMAPMPE)
	{
		if (null == GBPLNMAPMPE)
		{
			return;
		}
		if (GBPLNMAPMPE["OnFriendsPopupManagerAcceptClick"] == null)
		{
			return;
		}
		try
		{
			KAPNKGFMPDC kapnkgfmpdc = BackendOperationsManager.StringToBackendRequestType(GBPLNMAPMPE["OnBackendGetPublicProfileException"]);
			if (kapnkgfmpdc == KAPNKGFMPDC.startPlayChapter || kapnkgfmpdc == (KAPNKGFMPDC)(-62) || kapnkgfmpdc == KAPNKGFMPDC.processTransaction || kapnkgfmpdc == (KAPNKGFMPDC)75 || kapnkgfmpdc == KAPNKGFMPDC.none || kapnkgfmpdc == KAPNKGFMPDC.signInOrRegister || kapnkgfmpdc == (KAPNKGFMPDC)(-99) || kapnkgfmpdc == (KAPNKGFMPDC)(-16))
			{
				if (GBPLNMAPMPE["OnFriendsPopupManagerRejectClick"] != null)
				{
					if (KDCJJBLGCBH.EHBBFMCILPC.MJKGFFHAMPG() > 1)
					{
						if (kapnkgfmpdc != (KAPNKGFMPDC)(-89) || LiveEventsManager.OBOOKJPGBJN().PPEFKABPBIK().Count != 0)
						{
							LMFMICLNHLO lmfmiclnhlo = NAHMBEODKJC.BKOANABBBLA(kapnkgfmpdc, true);
							if (lmfmiclnhlo != null)
							{
								lmfmiclnhlo.CLFGHHBOCMN = GBPLNMAPMPE;
								NAHMBEODKJC.PKJBAPNBLAP(lmfmiclnhlo);
								DPGJIJGOCIC.CMGOAFDBAOH("layervideo" + kapnkgfmpdc.ToString() + "OnSettingsPopupCloseAndNeedToRestartGame" + lmfmiclnhlo.CLFGHHBOCMN.ToString());
								DPGJIJGOCIC.CMGOAFDBAOH("creature" + NAHMBEODKJC.HCFOCMBMOMG.Count.ToString() + "XXX");
							}
							else
							{
								lmfmiclnhlo = new LMFMICLNHLO();
								lmfmiclnhlo.CLFGHHBOCMN = GBPLNMAPMPE;
								lmfmiclnhlo.AJJKAJDBEFM = kapnkgfmpdc;
								NAHMBEODKJC.PDIBHELFJCA(lmfmiclnhlo);
								NAHMBEODKJC.HCFOCMBMOMG.Add(lmfmiclnhlo);
								DPGJIJGOCIC.CMGOAFDBAOH("hist" + kapnkgfmpdc.ToString() + "acli21" + lmfmiclnhlo.CLFGHHBOCMN.ToString());
								DPGJIJGOCIC.NFIDPOMCNLP("\nERR:" + NAHMBEODKJC.HCFOCMBMOMG.Count.ToString() + "mega");
							}
						}
					}
				}
				else
				{
					LMFMICLNHLO lmfmiclnhlo2 = NAHMBEODKJC.JGAEFGAMAHL(kapnkgfmpdc, false);
					if (lmfmiclnhlo2 != null)
					{
						GBPLNMAPMPE.Add("sketchtitles", lmfmiclnhlo2.CLFGHHBOCMN["ok"]);
						GBPLNMAPMPE.Add("exception while starting: ", 0);
						DPGJIJGOCIC.NFIDPOMCNLP("signinsuccessrestart" + kapnkgfmpdc.ToString() + "NonPlayerCharacterManager.Initialize() - npcAsset.bodySprite (" + lmfmiclnhlo2.CLFGHHBOCMN.ToString());
						DPGJIJGOCIC.CMGOAFDBAOH("〉" + NAHMBEODKJC.HCFOCMBMOMG.Count.ToString() + "");
					}
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x06003C98 RID: 15512 RVA: 0x00191AA8 File Offset: 0x0018FCA8
	public static void POEDGMKDCDA(JSONObject GBPLNMAPMPE)
	{
		if (null == GBPLNMAPMPE)
		{
			return;
		}
		if (GBPLNMAPMPE[""] == null)
		{
			return;
		}
		try
		{
			KAPNKGFMPDC kapnkgfmpdc = BackendOperationsManager.StringToBackendRequestType(GBPLNMAPMPE["a"]);
			if (kapnkgfmpdc == (KAPNKGFMPDC)(-110) || kapnkgfmpdc == (KAPNKGFMPDC)91 || kapnkgfmpdc == KAPNKGFMPDC.signIn || kapnkgfmpdc == (KAPNKGFMPDC)(-120) || kapnkgfmpdc == (KAPNKGFMPDC)93 || kapnkgfmpdc == KAPNKGFMPDC.getPurchasingBalance || kapnkgfmpdc == (KAPNKGFMPDC)(-43) || kapnkgfmpdc == KAPNKGFMPDC.unlockNpcSkin)
			{
				if (GBPLNMAPMPE["CameraEnvironmentsFront"] != null)
				{
					if (KDCJJBLGCBH.EHBBFMCILPC.MJKGFFHAMPG() > 1)
					{
						if (kapnkgfmpdc != (KAPNKGFMPDC)80 || LiveEventsManager.NMGMNAKLLMI().NALEBCMPHJF().Count != 0)
						{
							LMFMICLNHLO lmfmiclnhlo = NAHMBEODKJC.KINPHKBAEEN(kapnkgfmpdc, false);
							if (lmfmiclnhlo != null)
							{
								lmfmiclnhlo.CLFGHHBOCMN = GBPLNMAPMPE;
								NAHMBEODKJC.FOMPHOOEKCP(lmfmiclnhlo);
								DPGJIJGOCIC.NFIDPOMCNLP("." + kapnkgfmpdc.ToString() + "cardoptionssendasgift" + lmfmiclnhlo.CLFGHHBOCMN.ToString());
								DPGJIJGOCIC.CMGOAFDBAOH("Invalid npc animation bundle index in story header, skipped:" + NAHMBEODKJC.HCFOCMBMOMG.Count.ToString() + "");
							}
							else
							{
								lmfmiclnhlo = new LMFMICLNHLO();
								lmfmiclnhlo.CLFGHHBOCMN = GBPLNMAPMPE;
								lmfmiclnhlo.AJJKAJDBEFM = kapnkgfmpdc;
								NAHMBEODKJC.OOPCMHNFPKG(lmfmiclnhlo);
								NAHMBEODKJC.HCFOCMBMOMG.Add(lmfmiclnhlo);
								DPGJIJGOCIC.CMGOAFDBAOH("cardcollectcardismissing" + kapnkgfmpdc.ToString() + "ym" + lmfmiclnhlo.CLFGHHBOCMN.ToString());
								DPGJIJGOCIC.NFIDPOMCNLP("" + NAHMBEODKJC.HCFOCMBMOMG.Count.ToString() + "OnAllCollectableCardsDownloadFailedLobby");
							}
						}
					}
				}
				else
				{
					LMFMICLNHLO lmfmiclnhlo2 = NAHMBEODKJC.OLHBHNHILLE(kapnkgfmpdc, true);
					if (lmfmiclnhlo2 != null)
					{
						GBPLNMAPMPE.Add("", lmfmiclnhlo2.CLFGHHBOCMN["Account.SRAGetFullyReleasedAnthologies(), exception:"]);
						GBPLNMAPMPE.Add(" ", 0);
						DPGJIJGOCIC.CMGOAFDBAOH("b" + kapnkgfmpdc.ToString() + "c_web" + lmfmiclnhlo2.CLFGHHBOCMN.ToString());
						DPGJIJGOCIC.NFIDPOMCNLP("ok" + NAHMBEODKJC.HCFOCMBMOMG.Count.ToString() + "c_web");
					}
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
	}

	// Token: 0x06003C99 RID: 15513 RVA: 0x00191CF0 File Offset: 0x0018FEF0
	private static void HGPPIBGICDE(LMFMICLNHLO KKHJMIKNOFP)
	{
		KAPNKGFMPDC ajjkajdbefm = KKHJMIKNOFP.AJJKAJDBEFM;
		if (ajjkajdbefm > KAPNKGFMPDC.signIn)
		{
			switch (ajjkajdbefm)
			{
			case (KAPNKGFMPDC)79:
				KKHJMIKNOFP.COJCANGPJKN = 2;
				return;
			case (KAPNKGFMPDC)80:
				KKHJMIKNOFP.COJCANGPJKN = -13;
				return;
			case (KAPNKGFMPDC)81:
			case (KAPNKGFMPDC)82:
			case (KAPNKGFMPDC)83:
				break;
			case (KAPNKGFMPDC)84:
				KKHJMIKNOFP.COJCANGPJKN = 3;
				return;
			case (KAPNKGFMPDC)85:
				KKHJMIKNOFP.COJCANGPJKN = 10;
				break;
			default:
				if (ajjkajdbefm == (KAPNKGFMPDC)(-104))
				{
					KKHJMIKNOFP.COJCANGPJKN = 119;
					return;
				}
				if (ajjkajdbefm != (KAPNKGFMPDC)58)
				{
					return;
				}
				KKHJMIKNOFP.COJCANGPJKN = 0;
				return;
			}
			return;
		}
		if (ajjkajdbefm == KAPNKGFMPDC.none)
		{
			KKHJMIKNOFP.COJCANGPJKN = 25;
			return;
		}
		if (ajjkajdbefm != KAPNKGFMPDC.changeOwner)
		{
			return;
		}
		KKHJMIKNOFP.COJCANGPJKN = -60;
	}

	// Token: 0x06003C9A RID: 15514 RVA: 0x00191D88 File Offset: 0x0018FF88
	public static void PKCOBABDGPM(JSONObject GBPLNMAPMPE)
	{
		if (null == GBPLNMAPMPE)
		{
			return;
		}
		if (GBPLNMAPMPE["bdid"] == null)
		{
			return;
		}
		try
		{
			KAPNKGFMPDC kapnkgfmpdc = BackendOperationsManager.StringToBackendRequestType(GBPLNMAPMPE["_not_found"]);
			if (kapnkgfmpdc == (KAPNKGFMPDC)(-7) || kapnkgfmpdc == (KAPNKGFMPDC)(-59) || kapnkgfmpdc == KAPNKGFMPDC.processTransaction || kapnkgfmpdc == (KAPNKGFMPDC)(-30) || kapnkgfmpdc == (KAPNKGFMPDC)(-11) || kapnkgfmpdc == KAPNKGFMPDC.signIn || kapnkgfmpdc == KAPNKGFMPDC.storyChapterComplete || kapnkgfmpdc == (KAPNKGFMPDC)90)
			{
				if (GBPLNMAPMPE["[LoadingTheme] update giveaway: +1 free change granted for revision "] != null)
				{
					if (KDCJJBLGCBH.EHBBFMCILPC.MJKGFFHAMPG() > 0)
					{
						if (kapnkgfmpdc != (KAPNKGFMPDC)(-5) || LiveEventsManager.JCMABFEMFKD().FHOBOAMEIDC().Count != 0)
						{
							LMFMICLNHLO lmfmiclnhlo = NAHMBEODKJC.BNPDJEANFIH(kapnkgfmpdc, false);
							if (lmfmiclnhlo != null)
							{
								lmfmiclnhlo.CLFGHHBOCMN = GBPLNMAPMPE;
								NAHMBEODKJC.KOLAHMKHEFL(lmfmiclnhlo);
								DPGJIJGOCIC.CMGOAFDBAOH(" not resolvable" + kapnkgfmpdc.ToString() + "OnSkinShopCardSelected" + lmfmiclnhlo.CLFGHHBOCMN.ToString());
								DPGJIJGOCIC.NFIDPOMCNLP("/" + NAHMBEODKJC.HCFOCMBMOMG.Count.ToString() + "acliffbw22");
							}
							else
							{
								lmfmiclnhlo = new LMFMICLNHLO();
								lmfmiclnhlo.CLFGHHBOCMN = GBPLNMAPMPE;
								lmfmiclnhlo.AJJKAJDBEFM = kapnkgfmpdc;
								NAHMBEODKJC.LHLCIMKNBKE(lmfmiclnhlo);
								NAHMBEODKJC.HCFOCMBMOMG.Add(lmfmiclnhlo);
								DPGJIJGOCIC.NFIDPOMCNLP("aspksk" + kapnkgfmpdc.ToString() + "/" + lmfmiclnhlo.CLFGHHBOCMN.ToString());
								DPGJIJGOCIC.NFIDPOMCNLP("maxr" + NAHMBEODKJC.HCFOCMBMOMG.Count.ToString() + "OnGooglePlayServicesLoginFailed");
							}
						}
					}
				}
				else
				{
					LMFMICLNHLO lmfmiclnhlo2 = NAHMBEODKJC.OLHBHNHILLE(kapnkgfmpdc, false);
					if (lmfmiclnhlo2 != null)
					{
						GBPLNMAPMPE.Add("analogglitch20", lmfmiclnhlo2.CLFGHHBOCMN["OnLanguageChange"]);
						GBPLNMAPMPE.Add("ok", 0);
						DPGJIJGOCIC.NFIDPOMCNLP("" + kapnkgfmpdc.ToString() + "][" + lmfmiclnhlo2.CLFGHHBOCMN.ToString());
						DPGJIJGOCIC.CMGOAFDBAOH("OnPassesItemClose" + NAHMBEODKJC.HCFOCMBMOMG.Count.ToString() + "");
					}
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
	}

	// Token: 0x06003C9B RID: 15515 RVA: 0x00191FD0 File Offset: 0x001901D0
	public static void OBDBLLHBGLE()
	{
		NAHMBEODKJC.HCFOCMBMOMG.Clear();
		DPGJIJGOCIC.NFIDPOMCNLP("BackendCacheManager: Cleaning cache.");
	}

	// Token: 0x06003C9C RID: 15516 RVA: 0x00191FE8 File Offset: 0x001901E8
	public static bool GONHKGLLGAC(KAPNKGFMPDC EGLBLPKFEOI)
	{
		LMFMICLNHLO lmfmiclnhlo = NAHMBEODKJC.KDKKPPJEEOP(EGLBLPKFEOI, false);
		return lmfmiclnhlo != null && lmfmiclnhlo.COJCANGPJKN > 1;
	}

	// Token: 0x06003C9D RID: 15517 RVA: 0x0019200C File Offset: 0x0019020C
	public static void INGADEMJENJ()
	{
		NAHMBEODKJC.HCFOCMBMOMG.Clear();
		DPGJIJGOCIC.NFIDPOMCNLP(" is already loaded elsewhere");
	}

	// Token: 0x06003C9E RID: 15518 RVA: 0x00192024 File Offset: 0x00190224
	private static LMFMICLNHLO KFFGNICNCEE(KAPNKGFMPDC EGLBLPKFEOI, bool IHODELKIAHA)
	{
		for (int i = 1; i < NAHMBEODKJC.HCFOCMBMOMG.Count; i++)
		{
			if (NAHMBEODKJC.HCFOCMBMOMG[i].AJJKAJDBEFM == EGLBLPKFEOI)
			{
				if (IHODELKIAHA)
				{
					NAHMBEODKJC.HCFOCMBMOMG[i].COJCANGPJKN--;
				}
				return NAHMBEODKJC.HCFOCMBMOMG[i];
			}
		}
		return null;
	}

	// Token: 0x06003C9F RID: 15519 RVA: 0x00192084 File Offset: 0x00190284
	private static void NCNLBPAIBBM(LMFMICLNHLO KKHJMIKNOFP)
	{
		KAPNKGFMPDC ajjkajdbefm = KKHJMIKNOFP.AJJKAJDBEFM;
		if (ajjkajdbefm > KAPNKGFMPDC.changeOwner)
		{
			switch (ajjkajdbefm)
			{
			case KAPNKGFMPDC.emailUnsubscribe:
				KKHJMIKNOFP.COJCANGPJKN = 8;
				return;
			case KAPNKGFMPDC.startFreePass:
				KKHJMIKNOFP.COJCANGPJKN = 126;
				return;
			case KAPNKGFMPDC.consumeEnergy:
			case KAPNKGFMPDC.getHallOfFame:
			case KAPNKGFMPDC.getCardsBalance:
				break;
			case KAPNKGFMPDC.getCardVolumesBalance:
				KKHJMIKNOFP.COJCANGPJKN = 2;
				return;
			case KAPNKGFMPDC.getDropChancesBalance:
				KKHJMIKNOFP.COJCANGPJKN = 127;
				break;
			default:
				if (ajjkajdbefm == (KAPNKGFMPDC)90)
				{
					KKHJMIKNOFP.COJCANGPJKN = -73;
					return;
				}
				if (ajjkajdbefm != KAPNKGFMPDC.getPurchasingBalance)
				{
					return;
				}
				KKHJMIKNOFP.COJCANGPJKN = 0;
				return;
			}
			return;
		}
		if (ajjkajdbefm == KAPNKGFMPDC.getDefaultBundles)
		{
			KKHJMIKNOFP.COJCANGPJKN = -128;
			return;
		}
		if (ajjkajdbefm != KAPNKGFMPDC.signIn)
		{
			return;
		}
		KKHJMIKNOFP.COJCANGPJKN = -33;
	}

	// Token: 0x06003CA0 RID: 15520 RVA: 0x0019211C File Offset: 0x0019031C
	private static void HJBKACBBGMH(LMFMICLNHLO KKHJMIKNOFP)
	{
		KAPNKGFMPDC ajjkajdbefm = KKHJMIKNOFP.AJJKAJDBEFM;
		if (ajjkajdbefm > KAPNKGFMPDC.getDepot)
		{
			switch (ajjkajdbefm)
			{
			case (KAPNKGFMPDC)87:
				KKHJMIKNOFP.COJCANGPJKN = 6;
				return;
			case (KAPNKGFMPDC)88:
				KKHJMIKNOFP.COJCANGPJKN = 121;
				return;
			case (KAPNKGFMPDC)89:
			case (KAPNKGFMPDC)90:
			case (KAPNKGFMPDC)91:
				break;
			case (KAPNKGFMPDC)92:
				KKHJMIKNOFP.COJCANGPJKN = 6;
				return;
			case (KAPNKGFMPDC)93:
				KKHJMIKNOFP.COJCANGPJKN = -15;
				break;
			default:
				if (ajjkajdbefm == KAPNKGFMPDC.getMessagingHistory)
				{
					KKHJMIKNOFP.COJCANGPJKN = -120;
					return;
				}
				if (ajjkajdbefm != (KAPNKGFMPDC)(-34))
				{
					return;
				}
				KKHJMIKNOFP.COJCANGPJKN = 7;
				return;
			}
			return;
		}
		if (ajjkajdbefm == KAPNKGFMPDC.processTransaction)
		{
			KKHJMIKNOFP.COJCANGPJKN = 110;
			return;
		}
		if (ajjkajdbefm != KAPNKGFMPDC.processTransaction)
		{
			return;
		}
		KKHJMIKNOFP.COJCANGPJKN = -75;
	}

	// Token: 0x06003CA1 RID: 15521 RVA: 0x001921B4 File Offset: 0x001903B4
	public static bool KPMLLEAIKJG(KAPNKGFMPDC EGLBLPKFEOI)
	{
		LMFMICLNHLO lmfmiclnhlo = NAHMBEODKJC.KDKKPPJEEOP(EGLBLPKFEOI, false);
		return lmfmiclnhlo != null && lmfmiclnhlo.COJCANGPJKN > 0 && false;
	}

	// Token: 0x06003CA2 RID: 15522 RVA: 0x001921D8 File Offset: 0x001903D8
	public static void HCIPPFBLGHH()
	{
		NAHMBEODKJC.HCFOCMBMOMG.Clear();
		DPGJIJGOCIC.NFIDPOMCNLP("p");
	}

	// Token: 0x06003CA3 RID: 15523 RVA: 0x001921F0 File Offset: 0x001903F0
	private static void GANJIAJPBJL(LMFMICLNHLO KKHJMIKNOFP)
	{
		KAPNKGFMPDC ajjkajdbefm = KKHJMIKNOFP.AJJKAJDBEFM;
		if (ajjkajdbefm > KAPNKGFMPDC.processTransaction)
		{
			switch (ajjkajdbefm)
			{
			case (KAPNKGFMPDC)123:
				KKHJMIKNOFP.COJCANGPJKN = 0;
				return;
			case (KAPNKGFMPDC)124:
				KKHJMIKNOFP.COJCANGPJKN = 118;
				return;
			case (KAPNKGFMPDC)125:
			case (KAPNKGFMPDC)126:
			case (KAPNKGFMPDC)127:
				break;
			case (KAPNKGFMPDC)128:
				KKHJMIKNOFP.COJCANGPJKN = 4;
				return;
			case (KAPNKGFMPDC)129:
				KKHJMIKNOFP.COJCANGPJKN = 56;
				break;
			default:
				if (ajjkajdbefm == KAPNKGFMPDC.restartChapterOrStory)
				{
					KKHJMIKNOFP.COJCANGPJKN = -60;
					return;
				}
				if (ajjkajdbefm != (KAPNKGFMPDC)(-114))
				{
					return;
				}
				KKHJMIKNOFP.COJCANGPJKN = 6;
				return;
			}
			return;
		}
		if (ajjkajdbefm == KAPNKGFMPDC.registerUser)
		{
			KKHJMIKNOFP.COJCANGPJKN = 20;
			return;
		}
		if (ajjkajdbefm != KAPNKGFMPDC.getPurchasingBalance)
		{
			return;
		}
		KKHJMIKNOFP.COJCANGPJKN = -32;
	}

	// Token: 0x06003CA4 RID: 15524 RVA: 0x00192288 File Offset: 0x00190488
	private static void PKJBAPNBLAP(LMFMICLNHLO KKHJMIKNOFP)
	{
		KAPNKGFMPDC ajjkajdbefm = KKHJMIKNOFP.AJJKAJDBEFM;
		if (ajjkajdbefm > KAPNKGFMPDC.getDepot)
		{
			switch (ajjkajdbefm)
			{
			case (KAPNKGFMPDC)(-66):
				KKHJMIKNOFP.COJCANGPJKN = 2;
				return;
			case (KAPNKGFMPDC)(-65):
				KKHJMIKNOFP.COJCANGPJKN = 122;
				return;
			case (KAPNKGFMPDC)(-64):
			case (KAPNKGFMPDC)(-63):
			case (KAPNKGFMPDC)(-62):
				break;
			case (KAPNKGFMPDC)(-61):
				KKHJMIKNOFP.COJCANGPJKN = 2;
				return;
			case (KAPNKGFMPDC)(-60):
				KKHJMIKNOFP.COJCANGPJKN = 41;
				break;
			default:
				if (ajjkajdbefm == (KAPNKGFMPDC)57)
				{
					KKHJMIKNOFP.COJCANGPJKN = -79;
					return;
				}
				if (ajjkajdbefm != KAPNKGFMPDC.getUserSketches)
				{
					return;
				}
				KKHJMIKNOFP.COJCANGPJKN = 2;
				return;
			}
			return;
		}
		if (ajjkajdbefm == KAPNKGFMPDC.getPurchasingBalance)
		{
			KKHJMIKNOFP.COJCANGPJKN = 125;
			return;
		}
		if (ajjkajdbefm != KAPNKGFMPDC.getDepot)
		{
			return;
		}
		KKHJMIKNOFP.COJCANGPJKN = 20;
	}

	// Token: 0x06003CA5 RID: 15525 RVA: 0x00192320 File Offset: 0x00190520
	private static LMFMICLNHLO HMGMBLMBEPG(KAPNKGFMPDC EGLBLPKFEOI, bool IHODELKIAHA)
	{
		for (int i = 1; i < NAHMBEODKJC.HCFOCMBMOMG.Count; i++)
		{
			if (NAHMBEODKJC.HCFOCMBMOMG[i].AJJKAJDBEFM == EGLBLPKFEOI)
			{
				if (IHODELKIAHA)
				{
					NAHMBEODKJC.HCFOCMBMOMG[i].COJCANGPJKN -= 0;
				}
				return NAHMBEODKJC.HCFOCMBMOMG[i];
			}
		}
		return null;
	}

	// Token: 0x06003CA6 RID: 15526 RVA: 0x00192380 File Offset: 0x00190580
	private static LMFMICLNHLO OFJJLICHJDJ(KAPNKGFMPDC EGLBLPKFEOI, bool IHODELKIAHA)
	{
		for (int i = 1; i < NAHMBEODKJC.HCFOCMBMOMG.Count; i += 0)
		{
			if (NAHMBEODKJC.HCFOCMBMOMG[i].AJJKAJDBEFM == EGLBLPKFEOI)
			{
				if (IHODELKIAHA)
				{
					NAHMBEODKJC.HCFOCMBMOMG[i].COJCANGPJKN--;
				}
				return NAHMBEODKJC.HCFOCMBMOMG[i];
			}
		}
		return null;
	}

	// Token: 0x06003CA7 RID: 15527 RVA: 0x001923DD File Offset: 0x001905DD
	public static void LINLDPFEAJI()
	{
		NAHMBEODKJC.HCFOCMBMOMG.Clear();
		DPGJIJGOCIC.NFIDPOMCNLP("onwishcardclickbody");
	}

	// Token: 0x06003CA8 RID: 15528 RVA: 0x001923F4 File Offset: 0x001905F4
	public static void IKNFMFAAJNG(JSONObject GBPLNMAPMPE)
	{
		if (null == GBPLNMAPMPE)
		{
			return;
		}
		if (GBPLNMAPMPE["Asset bundle assets destroyed:"] == null)
		{
			return;
		}
		try
		{
			KAPNKGFMPDC kapnkgfmpdc = BackendOperationsManager.StringToBackendRequestType(GBPLNMAPMPE["_1"]);
			if (kapnkgfmpdc == (KAPNKGFMPDC)75 || kapnkgfmpdc == (KAPNKGFMPDC)116 || kapnkgfmpdc == KAPNKGFMPDC.changeOwner || kapnkgfmpdc == (KAPNKGFMPDC)(-15) || kapnkgfmpdc == (KAPNKGFMPDC)(-45) || kapnkgfmpdc == KAPNKGFMPDC.signInOrRegister || kapnkgfmpdc == (KAPNKGFMPDC)83 || kapnkgfmpdc == (KAPNKGFMPDC)95)
			{
				if (GBPLNMAPMPE["OpenPasses"] != null)
				{
					if (KDCJJBLGCBH.EHBBFMCILPC.MJKGFFHAMPG() > 0)
					{
						if (kapnkgfmpdc != KAPNKGFMPDC.emailUnsubscribe || LiveEventsManager.PIPOLIAKGDM().EGBPABJAECL().Count != 0)
						{
							LMFMICLNHLO lmfmiclnhlo = NAHMBEODKJC.BKOANABBBLA(kapnkgfmpdc, false);
							if (lmfmiclnhlo != null)
							{
								lmfmiclnhlo.CLFGHHBOCMN = GBPLNMAPMPE;
								NAHMBEODKJC.AAEKFPILDFK(lmfmiclnhlo);
								DPGJIJGOCIC.NFIDPOMCNLP("_TimeFrac" + kapnkgfmpdc.ToString() + "SceneAvatarManager.AddOrUpdateAvatarCollection(): save not available" + lmfmiclnhlo.CLFGHHBOCMN.ToString());
								DPGJIJGOCIC.NFIDPOMCNLP("JJJ" + NAHMBEODKJC.HCFOCMBMOMG.Count.ToString() + "");
							}
							else
							{
								lmfmiclnhlo = new LMFMICLNHLO();
								lmfmiclnhlo.CLFGHHBOCMN = GBPLNMAPMPE;
								lmfmiclnhlo.AJJKAJDBEFM = kapnkgfmpdc;
								NAHMBEODKJC.PKJBAPNBLAP(lmfmiclnhlo);
								NAHMBEODKJC.HCFOCMBMOMG.Add(lmfmiclnhlo);
								DPGJIJGOCIC.CMGOAFDBAOH("Optional frame container bundle failed to load, continuing without it:" + kapnkgfmpdc.ToString() + "frrjctpid" + lmfmiclnhlo.CLFGHHBOCMN.ToString());
								DPGJIJGOCIC.CMGOAFDBAOH(" entries from the user hidden list (completed) as obsolete." + NAHMBEODKJC.HCFOCMBMOMG.Count.ToString() + "CameraEnvironmentsFront");
							}
						}
					}
				}
				else
				{
					LMFMICLNHLO lmfmiclnhlo2 = NAHMBEODKJC.CEPEGBOLHPF(kapnkgfmpdc, false);
					if (lmfmiclnhlo2 != null)
					{
						GBPLNMAPMPE.Add("bdgsspr", lmfmiclnhlo2.CLFGHHBOCMN[" npc(s) with a player-side dialog offset"]);
						GBPLNMAPMPE.Add("DialogNonPlayerCharacterManager.InputDataIsValid() - step is null.", 0);
						DPGJIJGOCIC.NFIDPOMCNLP("" + kapnkgfmpdc.ToString() + "ant" + lmfmiclnhlo2.CLFGHHBOCMN.ToString());
						DPGJIJGOCIC.NFIDPOMCNLP("OnSaveSlotsExpiredPassSubscribePositive" + NAHMBEODKJC.HCFOCMBMOMG.Count.ToString() + "pipeline start");
					}
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x06003CA9 RID: 15529 RVA: 0x0019263C File Offset: 0x0019083C
	public static bool GAHGLNJEMEL(KAPNKGFMPDC EGLBLPKFEOI)
	{
		LMFMICLNHLO lmfmiclnhlo = NAHMBEODKJC.KFFGNICNCEE(EGLBLPKFEOI, true);
		return lmfmiclnhlo != null && lmfmiclnhlo.COJCANGPJKN > 1;
	}

	// Token: 0x06003CAA RID: 15530 RVA: 0x00192660 File Offset: 0x00190860
	public static bool CKPCOAAGGFJ(KAPNKGFMPDC EGLBLPKFEOI)
	{
		LMFMICLNHLO lmfmiclnhlo = NAHMBEODKJC.CKJHDBPJBOL(EGLBLPKFEOI, true);
		return lmfmiclnhlo == null || lmfmiclnhlo.COJCANGPJKN <= 0 || true;
	}

	// Token: 0x06003CAB RID: 15531 RVA: 0x00192684 File Offset: 0x00190884
	private static LMFMICLNHLO IFAOELOLHLJ(KAPNKGFMPDC EGLBLPKFEOI, bool IHODELKIAHA)
	{
		for (int i = 1; i < NAHMBEODKJC.HCFOCMBMOMG.Count; i += 0)
		{
			if (NAHMBEODKJC.HCFOCMBMOMG[i].AJJKAJDBEFM == EGLBLPKFEOI)
			{
				if (IHODELKIAHA)
				{
					NAHMBEODKJC.HCFOCMBMOMG[i].COJCANGPJKN--;
				}
				return NAHMBEODKJC.HCFOCMBMOMG[i];
			}
		}
		return null;
	}

	// Token: 0x06003CAC RID: 15532 RVA: 0x0018DF69 File Offset: 0x0018C169
	public static void MJEGEFIIHON()
	{
		NAHMBEODKJC.HCFOCMBMOMG.Clear();
		DPGJIJGOCIC.NFIDPOMCNLP("");
	}

	// Token: 0x06003CAD RID: 15533 RVA: 0x001926E4 File Offset: 0x001908E4
	private static LMFMICLNHLO OOEGKELEPDL(KAPNKGFMPDC EGLBLPKFEOI, bool IHODELKIAHA)
	{
		for (int i = 1; i < NAHMBEODKJC.HCFOCMBMOMG.Count; i++)
		{
			if (NAHMBEODKJC.HCFOCMBMOMG[i].AJJKAJDBEFM == EGLBLPKFEOI)
			{
				if (IHODELKIAHA)
				{
					NAHMBEODKJC.HCFOCMBMOMG[i].COJCANGPJKN--;
				}
				return NAHMBEODKJC.HCFOCMBMOMG[i];
			}
		}
		return null;
	}

	// Token: 0x06003CAE RID: 15534 RVA: 0x00192744 File Offset: 0x00190944
	public static void GNMNKICMKBE(JSONObject GBPLNMAPMPE)
	{
		if (null == GBPLNMAPMPE)
		{
			return;
		}
		if (GBPLNMAPMPE["importanttitle"] == null)
		{
			return;
		}
		try
		{
			KAPNKGFMPDC kapnkgfmpdc = BackendOperationsManager.StringToBackendRequestType(GBPLNMAPMPE[""]);
			if (kapnkgfmpdc == (KAPNKGFMPDC)123 || kapnkgfmpdc == (KAPNKGFMPDC)(-10) || kapnkgfmpdc == KAPNKGFMPDC.registerUser || kapnkgfmpdc == (KAPNKGFMPDC)(-21) || kapnkgfmpdc == KAPNKGFMPDC.emailSubscribe || kapnkgfmpdc == KAPNKGFMPDC.getDepot || kapnkgfmpdc == (KAPNKGFMPDC)(-21) || kapnkgfmpdc == (KAPNKGFMPDC)127)
			{
				if (GBPLNMAPMPE["StorySaveBody.GetAvatarSnapshotWithIndexInListWardrobe(), unsupported wardrobe index:"] != null)
				{
					if (KDCJJBLGCBH.EHBBFMCILPC.MJKGFFHAMPG() > 0)
					{
						if (kapnkgfmpdc != (KAPNKGFMPDC)(-101) || LiveEventsManager.OBOOKJPGBJN().HJKFIHHDFAB().Count != 0)
						{
							LMFMICLNHLO lmfmiclnhlo = NAHMBEODKJC.CEPEGBOLHPF(kapnkgfmpdc, false);
							if (lmfmiclnhlo != null)
							{
								lmfmiclnhlo.CLFGHHBOCMN = GBPLNMAPMPE;
								NAHMBEODKJC.DOBCPBKEGGC(lmfmiclnhlo);
								DPGJIJGOCIC.CMGOAFDBAOH("app42error" + kapnkgfmpdc.ToString() + "cdnerror" + lmfmiclnhlo.CLFGHHBOCMN.ToString());
								DPGJIJGOCIC.CMGOAFDBAOH("spinsbodymorespins" + NAHMBEODKJC.HCFOCMBMOMG.Count.ToString() + "clthbr");
							}
							else
							{
								lmfmiclnhlo = new LMFMICLNHLO();
								lmfmiclnhlo.CLFGHHBOCMN = GBPLNMAPMPE;
								lmfmiclnhlo.AJJKAJDBEFM = kapnkgfmpdc;
								NAHMBEODKJC.DOBCPBKEGGC(lmfmiclnhlo);
								NAHMBEODKJC.HCFOCMBMOMG.Add(lmfmiclnhlo);
								DPGJIJGOCIC.CMGOAFDBAOH("envlhrw" + kapnkgfmpdc.ToString() + "" + lmfmiclnhlo.CLFGHHBOCMN.ToString());
								DPGJIJGOCIC.NFIDPOMCNLP("<i>" + NAHMBEODKJC.HCFOCMBMOMG.Count.ToString() + "OnLobbyWheelDataDataCdnFailed");
							}
						}
					}
				}
				else
				{
					LMFMICLNHLO lmfmiclnhlo2 = NAHMBEODKJC.LMLECOCEDBK(kapnkgfmpdc, false);
					if (lmfmiclnhlo2 != null)
					{
						GBPLNMAPMPE.Add("luwid", lmfmiclnhlo2.CLFGHHBOCMN[""]);
						GBPLNMAPMPE.Add("abpv", 0);
						DPGJIJGOCIC.CMGOAFDBAOH("clthm" + kapnkgfmpdc.ToString() + "GeneralBalance.SearchKeyInt() - could not find key:" + lmfmiclnhlo2.CLFGHHBOCMN.ToString());
						DPGJIJGOCIC.CMGOAFDBAOH("_BLEND_ADDITIVE" + NAHMBEODKJC.HCFOCMBMOMG.Count.ToString() + "saveslotstitleempty");
					}
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
	}

	// Token: 0x06003CAF RID: 15535 RVA: 0x0019298C File Offset: 0x00190B8C
	public static bool FPNKNILMILF(KAPNKGFMPDC EGLBLPKFEOI)
	{
		LMFMICLNHLO lmfmiclnhlo = NAHMBEODKJC.MNHCJLGGFOG(EGLBLPKFEOI, false);
		return lmfmiclnhlo == null || lmfmiclnhlo.COJCANGPJKN <= 0;
	}

	// Token: 0x06003CB0 RID: 15536 RVA: 0x001929B0 File Offset: 0x00190BB0
	public static void ICDFHCNFCKE(JSONObject GBPLNMAPMPE)
	{
		if (null == GBPLNMAPMPE)
		{
			return;
		}
		if (GBPLNMAPMPE["common"] == null)
		{
			return;
		}
		try
		{
			KAPNKGFMPDC kapnkgfmpdc = BackendOperationsManager.StringToBackendRequestType(GBPLNMAPMPE["CLIENT.SCREEN.AVATAR."]);
			if (kapnkgfmpdc == (KAPNKGFMPDC)(-123) || kapnkgfmpdc == (KAPNKGFMPDC)66 || kapnkgfmpdc == KAPNKGFMPDC.signIn || kapnkgfmpdc == (KAPNKGFMPDC)(-4) || kapnkgfmpdc == (KAPNKGFMPDC)(-120) || kapnkgfmpdc == KAPNKGFMPDC.signIn || kapnkgfmpdc == (KAPNKGFMPDC)82 || kapnkgfmpdc == KAPNKGFMPDC.startPlayChapter)
			{
				if (GBPLNMAPMPE["yes"] != null)
				{
					if (KDCJJBLGCBH.EHBBFMCILPC.MJKGFFHAMPG() > 1)
					{
						if (kapnkgfmpdc != KAPNKGFMPDC.breakCard || LiveEventsManager.NMGMNAKLLMI().BJPAPGIBJIM().Count != 0)
						{
							LMFMICLNHLO lmfmiclnhlo = NAHMBEODKJC.HLDGGAJDJPC(kapnkgfmpdc, false);
							if (lmfmiclnhlo != null)
							{
								lmfmiclnhlo.CLFGHHBOCMN = GBPLNMAPMPE;
								NAHMBEODKJC.NCOOIJHJCFD(lmfmiclnhlo);
								DPGJIJGOCIC.CMGOAFDBAOH("no" + kapnkgfmpdc.ToString() + "OnStoryInterfaceHeaderAvatarClick" + lmfmiclnhlo.CLFGHHBOCMN.ToString());
								DPGJIJGOCIC.CMGOAFDBAOH("There needs to be one active GooglePlayServicesManager script on a GameObject in your scene." + NAHMBEODKJC.HCFOCMBMOMG.Count.ToString() + "Request type: SESSION_REQUEST");
							}
							else
							{
								lmfmiclnhlo = new LMFMICLNHLO();
								lmfmiclnhlo.CLFGHHBOCMN = GBPLNMAPMPE;
								lmfmiclnhlo.AJJKAJDBEFM = kapnkgfmpdc;
								NAHMBEODKJC.OOPCMHNFPKG(lmfmiclnhlo);
								NAHMBEODKJC.HCFOCMBMOMG.Add(lmfmiclnhlo);
								DPGJIJGOCIC.NFIDPOMCNLP("" + kapnkgfmpdc.ToString() + "Delayed reference for " + lmfmiclnhlo.CLFGHHBOCMN.ToString());
								DPGJIJGOCIC.NFIDPOMCNLP("SceneLobbyManager2.ParkSearchFilterItem() - chip still on after restore (restore target missing?), forcing off" + NAHMBEODKJC.HCFOCMBMOMG.Count.ToString() + " could not be loaded from the cache");
							}
						}
					}
				}
				else
				{
					LMFMICLNHLO lmfmiclnhlo2 = NAHMBEODKJC.KFFGNICNCEE(kapnkgfmpdc, true);
					if (lmfmiclnhlo2 != null)
					{
						GBPLNMAPMPE.Add("sp0", lmfmiclnhlo2.CLFGHHBOCMN["_TintColor"]);
						GBPLNMAPMPE.Add("continue", 0);
						DPGJIJGOCIC.CMGOAFDBAOH("OnPromoCodeConsumeSuccess" + kapnkgfmpdc.ToString() + "p" + lmfmiclnhlo2.CLFGHHBOCMN.ToString());
						DPGJIJGOCIC.CMGOAFDBAOH("Starting parallel download:" + NAHMBEODKJC.HCFOCMBMOMG.Count.ToString() + "");
					}
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
	}

	// Token: 0x06003CB1 RID: 15537 RVA: 0x00192BF8 File Offset: 0x00190DF8
	private static LMFMICLNHLO BKOANABBBLA(KAPNKGFMPDC EGLBLPKFEOI, bool IHODELKIAHA)
	{
		for (int i = 0; i < NAHMBEODKJC.HCFOCMBMOMG.Count; i++)
		{
			if (NAHMBEODKJC.HCFOCMBMOMG[i].AJJKAJDBEFM == EGLBLPKFEOI)
			{
				if (IHODELKIAHA)
				{
					NAHMBEODKJC.HCFOCMBMOMG[i].COJCANGPJKN--;
				}
				return NAHMBEODKJC.HCFOCMBMOMG[i];
			}
		}
		return null;
	}

	// Token: 0x06003CB2 RID: 15538 RVA: 0x00192C55 File Offset: 0x00190E55
	public static void DDDBGPPPDJA()
	{
		NAHMBEODKJC.HCFOCMBMOMG.Clear();
		DPGJIJGOCIC.NFIDPOMCNLP("OnPopupPromoCodesReadInputEndEdit");
	}

	// Token: 0x06003CB3 RID: 15539 RVA: 0x00192C6C File Offset: 0x00190E6C
	private static void EMFEFDMDCJJ(LMFMICLNHLO KKHJMIKNOFP)
	{
		KAPNKGFMPDC ajjkajdbefm = KKHJMIKNOFP.AJJKAJDBEFM;
		if (ajjkajdbefm > KAPNKGFMPDC.signIn)
		{
			switch (ajjkajdbefm)
			{
			case (KAPNKGFMPDC)87:
				KKHJMIKNOFP.COJCANGPJKN = 4;
				return;
			case (KAPNKGFMPDC)88:
				KKHJMIKNOFP.COJCANGPJKN = 42;
				return;
			case (KAPNKGFMPDC)89:
			case (KAPNKGFMPDC)90:
			case (KAPNKGFMPDC)91:
				break;
			case (KAPNKGFMPDC)92:
				KKHJMIKNOFP.COJCANGPJKN = 6;
				return;
			case (KAPNKGFMPDC)93:
				KKHJMIKNOFP.COJCANGPJKN = 41;
				break;
			default:
				if (ajjkajdbefm == (KAPNKGFMPDC)(-41))
				{
					KKHJMIKNOFP.COJCANGPJKN = 83;
					return;
				}
				if (ajjkajdbefm != (KAPNKGFMPDC)(-105))
				{
					return;
				}
				KKHJMIKNOFP.COJCANGPJKN = 4;
				return;
			}
			return;
		}
		if (ajjkajdbefm == KAPNKGFMPDC.registerUser)
		{
			KKHJMIKNOFP.COJCANGPJKN = 65;
			return;
		}
		if (ajjkajdbefm != KAPNKGFMPDC.signIn)
		{
			return;
		}
		KKHJMIKNOFP.COJCANGPJKN = 42;
	}

	// Token: 0x06003CB4 RID: 15540 RVA: 0x00192D04 File Offset: 0x00190F04
	public static bool MIINLEJINBE(KAPNKGFMPDC EGLBLPKFEOI)
	{
		LMFMICLNHLO lmfmiclnhlo = NAHMBEODKJC.KINPHKBAEEN(EGLBLPKFEOI, true);
		return lmfmiclnhlo == null || lmfmiclnhlo.COJCANGPJKN <= 1 || true;
	}

	// Token: 0x06003CB5 RID: 15541 RVA: 0x00192D28 File Offset: 0x00190F28
	public static void NIJNJPFLMKL()
	{
		NAHMBEODKJC.HCFOCMBMOMG.Clear();
		DPGJIJGOCIC.CMGOAFDBAOH(" candidates ");
	}

	// Token: 0x06003CB6 RID: 15542 RVA: 0x00192D40 File Offset: 0x00190F40
	public static void DMOANFBMHDJ(JSONObject GBPLNMAPMPE)
	{
		if (null == GBPLNMAPMPE)
		{
			return;
		}
		if (GBPLNMAPMPE["e"] == null)
		{
			return;
		}
		try
		{
			KAPNKGFMPDC kapnkgfmpdc = BackendOperationsManager.StringToBackendRequestType(GBPLNMAPMPE["OnNeedToHideThumbnailTagObject"]);
			if (kapnkgfmpdc == KAPNKGFMPDC.getUserSketches || kapnkgfmpdc == (KAPNKGFMPDC)117 || kapnkgfmpdc == KAPNKGFMPDC.processTransaction || kapnkgfmpdc == KAPNKGFMPDC.getStoryRankings || kapnkgfmpdc == (KAPNKGFMPDC)118 || kapnkgfmpdc == KAPNKGFMPDC.processTransaction || kapnkgfmpdc == KAPNKGFMPDC.publishUserSketch || kapnkgfmpdc == KAPNKGFMPDC.registerUser)
			{
				if (GBPLNMAPMPE["<i>"] != null)
				{
					if (KDCJJBLGCBH.EHBBFMCILPC.MJKGFFHAMPG() > 0)
					{
						if (kapnkgfmpdc != (KAPNKGFMPDC)(-49) || LiveEventsManager.ONCPHEEJLOP().FHOBOAMEIDC().Count != 0)
						{
							LMFMICLNHLO lmfmiclnhlo = NAHMBEODKJC.HMGMBLMBEPG(kapnkgfmpdc, false);
							if (lmfmiclnhlo != null)
							{
								lmfmiclnhlo.CLFGHHBOCMN = GBPLNMAPMPE;
								NAHMBEODKJC.PKJBAPNBLAP(lmfmiclnhlo);
								DPGJIJGOCIC.NFIDPOMCNLP(") has no cover name, group skipped" + kapnkgfmpdc.ToString() + "p" + lmfmiclnhlo.CLFGHHBOCMN.ToString());
								DPGJIJGOCIC.NFIDPOMCNLP("OnStoryInterfaceHeaderSettingsClick" + NAHMBEODKJC.HCFOCMBMOMG.Count.ToString() + "OnRewardFirstEpisodeClick");
							}
							else
							{
								lmfmiclnhlo = new LMFMICLNHLO();
								lmfmiclnhlo.CLFGHHBOCMN = GBPLNMAPMPE;
								lmfmiclnhlo.AJJKAJDBEFM = kapnkgfmpdc;
								NAHMBEODKJC.GCLHBEILDEG(lmfmiclnhlo);
								NAHMBEODKJC.HCFOCMBMOMG.Add(lmfmiclnhlo);
								DPGJIJGOCIC.CMGOAFDBAOH(", index:" + kapnkgfmpdc.ToString() + "<i>" + lmfmiclnhlo.CLFGHHBOCMN.ToString());
								DPGJIJGOCIC.NFIDPOMCNLP("aind" + NAHMBEODKJC.HCFOCMBMOMG.Count.ToString() + " not found.");
							}
						}
					}
				}
				else
				{
					LMFMICLNHLO lmfmiclnhlo2 = NAHMBEODKJC.HMGMBLMBEPG(kapnkgfmpdc, true);
					if (lmfmiclnhlo2 != null)
					{
						GBPLNMAPMPE.Add("Asset bundle load operation failed during parallel mode.", lmfmiclnhlo2.CLFGHHBOCMN["Account.ResolveSaveSlots(): Slots sharing not needed"]);
						GBPLNMAPMPE.Add("getSketchesBalance", 0);
						DPGJIJGOCIC.NFIDPOMCNLP("," + kapnkgfmpdc.ToString() + "ERROR: ChoiceExtendedManager.Initialize() - finalAvatarComponentAsset is null." + lmfmiclnhlo2.CLFGHHBOCMN.ToString());
						DPGJIJGOCIC.CMGOAFDBAOH("errortitle" + NAHMBEODKJC.HCFOCMBMOMG.Count.ToString() + "msgt");
					}
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
	}

	// Token: 0x04001161 RID: 4449
	private static List<LMFMICLNHLO> HCFOCMBMOMG = new List<LMFMICLNHLO>();
}
