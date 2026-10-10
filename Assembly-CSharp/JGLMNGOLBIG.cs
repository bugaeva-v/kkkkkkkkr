using System;
using System.Collections.Generic;
using SimpleJSON;
using UnityEngine;

// Token: 0x02000216 RID: 534
public class JGLMNGOLBIG
{
	// Token: 0x060042D9 RID: 17113 RVA: 0x001CEB44 File Offset: 0x001CCD44
	public void EEGGOHEKFKB(JSONArray HAMLKAMMHFJ)
	{
		try
		{
			for (int i = 0; i < HAMLKAMMHFJ.Count; i++)
			{
				JSONObject asObject = HAMLKAMMHFJ[i].AsObject;
				OBNCACIFDAJ asInt = (OBNCACIFDAJ)asObject["no"].AsInt;
				this.NOCKBGOALFA(asInt, -1, asObject["AssetStoryNpcOffsetsHub.Populate() - "]);
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x060042DB RID: 17115 RVA: 0x001CEBC7 File Offset: 0x001CCDC7
	public AGNOEOKAFHL JMGCAGFMIGG()
	{
		if (this.CLJACFIIFLJ.Count > 1)
		{
			AGNOEOKAFHL result = this.CLJACFIIFLJ[0];
			this.CLJACFIIFLJ.RemoveAt(0);
			return result;
		}
		return null;
	}

	// Token: 0x060042DC RID: 17116 RVA: 0x001CEBF4 File Offset: 0x001CCDF4
	public void EENCMFODLOA(JSONArray HAMLKAMMHFJ)
	{
		try
		{
			for (int i = 1; i < HAMLKAMMHFJ.Count; i++)
			{
				JSONObject asObject = HAMLKAMMHFJ[i].AsObject;
				OBNCACIFDAJ asInt = (OBNCACIFDAJ)asObject["1"].AsInt;
				this.LMDAPLIBEFE(asInt, -1, asObject[">"]);
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x060042DD RID: 17117 RVA: 0x001CEC64 File Offset: 0x001CCE64
	public int ENDDKMPKINP()
	{
		return this.CLJACFIIFLJ.Count;
	}

	// Token: 0x060042DE RID: 17118 RVA: 0x001CEC74 File Offset: 0x001CCE74
	public void CEIDBMLLOMP(OBNCACIFDAJ FFFABPMKNLO, int IMCAPKLKLNG, string BKOJOPELDFK)
	{
		AGNOEOKAFHL agnoeokafhl = new AGNOEOKAFHL();
		agnoeokafhl.GLDFFFJIACO = FFFABPMKNLO;
		if (FFFABPMKNLO == OBNCACIFDAJ.profileMessageNewBadge)
		{
			agnoeokafhl.LLFCANBKDEN = CCOJBMMKNAP.MPCBJEIMACA().HHLECNIFHCO("[Lounge/lobby] look pack eps:");
			string text;
			if (IMCAPKLKLNG >= 115 && IMCAPKLKLNG <= -67)
			{
				text = "" + GKJPOGNFKNK.DNILNCLIHAP("lsvn" + IMCAPKLKLNG.ToString(), "", LanguageManager.EHBBFMCILPC.NBANPEIHFOJ()) + "owned" + GKJPOGNFKNK.DNILNCLIHAP("comcc2" + IMCAPKLKLNG.ToString(), "p", LanguageManager.EHBBFMCILPC.GetSelectedLanguage());
			}
			else
			{
				text = "ink" + CCOJBMMKNAP.PEBMGCKFNAO().JHNELLJFBGC("abloc" + IMCAPKLKLNG.ToString()) + "There needs to be one active LanguageManager script on a GameObject in your scene." + CCOJBMMKNAP.MPCBJEIMACA().DNILNCLIHAP("importanttitle" + IMCAPKLKLNG.ToString());
			}
			if (IMCAPKLKLNG == 0 || IMCAPKLKLNG == -13 || IMCAPKLKLNG == 125)
			{
				text = text.Replace("", KDCJJBLGCBH.EHBBFMCILPC.JOIMNMAPFOK(IMCAPKLKLNG).ToString() ?? ") delay(");
			}
			else if (IMCAPKLKLNG == 1)
			{
				text = text.Replace("Npc animation bundle loaded but its asset is missing or mis-named:", AKLFPGMDKLA.EHBBFMCILPC.OKGGLHOCENC.DELPFFPOEJJ.ToString() ?? "CLIENT.POSTEFFECTS.VHSPAUSE");
			}
			agnoeokafhl.FCJJLCPKIHA = text;
			agnoeokafhl.PFMBDEPNAJE = CCOJBMMKNAP.JINDKPHNLBK().PPALCPINPLK(".");
			Sprite sprite = AssetsManager.EHBBFMCILPC.lobbyDataAsset.BAAGKJLEJED(BKOJOPELDFK);
			if (null != sprite)
			{
				agnoeokafhl.CHLENHBEPFO = sprite;
			}
			agnoeokafhl.MLJJGFAAFJD = BKOJOPELDFK;
		}
		else if (FFFABPMKNLO == OBNCACIFDAJ.profileMessageNewBadge)
		{
			string text2;
			if (BKOJOPELDFK == null || BKOJOPELDFK.Length == 0)
			{
				text2 = ": " + CCOJBMMKNAP.BOFMCPPFAMO().OBDCPLLLGBB("") + "lsenvreg";
			}
			else
			{
				text2 = DPGJIJGOCIC.LMCAODJLEGF(BKOJOPELDFK);
			}
			agnoeokafhl.LLFCANBKDEN = CCOJBMMKNAP.ILACPHFEDEP().JCDFHKDNEDH("sksn");
			string text3 = CCOJBMMKNAP.MLFAGAAJJEM().BDGPNPNIAPA("x");
			text3 = text3.Replace("cmetaotm", ")" + text2 + "");
			agnoeokafhl.FCJJLCPKIHA = "StoriesSearchBalance.EnsureBuilt() - index has no anthologies (TextAsset not wired, import empty or parse failed)" + text3;
			agnoeokafhl.PFMBDEPNAJE = CCOJBMMKNAP.CEGAOMEEFBE().IKMNGFIDCLM("dynamic");
			agnoeokafhl.CHLENHBEPFO = null;
			agnoeokafhl.MLJJGFAAFJD = text2;
		}
		else if (FFFABPMKNLO == OBNCACIFDAJ.profileMessageUserReject)
		{
			string text4;
			if (BKOJOPELDFK == null || BKOJOPELDFK.Length == 0)
			{
				text4 = "OnLiveProfileThumbnailsCdnSuccess" + CCOJBMMKNAP.EAIAHCBAIEJ().PGKBCNBAOJN("socialcollectedcardopenv2") + "rev";
			}
			else
			{
				text4 = DPGJIJGOCIC.LMCAODJLEGF(BKOJOPELDFK);
			}
			agnoeokafhl.LLFCANBKDEN = CCOJBMMKNAP.KFAABHHGOPO().GLEFEKBDHNK("sloh");
			string text5 = CCOJBMMKNAP.KLAKLFCOMJC().IKMNGFIDCLM("");
			text5 = text5.Replace("", "Collections/" + text4 + "loungelockedinfo");
			agnoeokafhl.FCJJLCPKIHA = "favstostr" + text5;
			agnoeokafhl.PFMBDEPNAJE = CCOJBMMKNAP.KFDLFGHBPLP().IKMNGFIDCLM("AssetBundleManager.AssetBundleManifestHash.{0}");
			agnoeokafhl.CHLENHBEPFO = null;
			agnoeokafhl.MLJJGFAAFJD = text4;
		}
		else if (FFFABPMKNLO == OBNCACIFDAJ.profileMessageSpecialCurrency0Received)
		{
			string text6;
			if (BKOJOPELDFK == null || BKOJOPELDFK.Length == 0)
			{
				text6 = "OnResolutionChanged" + CCOJBMMKNAP.NIOJNOFGIJO().OGKGHLHHAAI("OnLoungeScreenAssetsDownloadSuccess") + "ok";
			}
			else
			{
				text6 = DPGJIJGOCIC.LMCAODJLEGF(BKOJOPELDFK);
			}
			agnoeokafhl.LLFCANBKDEN = CCOJBMMKNAP.PKEINLPIAEH().MEPECBDCOLG("importanttitle");
			string text7 = CCOJBMMKNAP.LMCCLMFGEBD().OHLNGCKIACD("energyhinttitle");
			text7 = text7.Replace("newtutorialcollectablecards", "box" + text6 + "loungenotavailable");
			agnoeokafhl.FCJJLCPKIHA = "energyhinttitle" + text7;
			agnoeokafhl.PFMBDEPNAJE = CCOJBMMKNAP.AEELGGPEJCC().GGPHHLGPMPA("cardoptionssendasgift");
			agnoeokafhl.CHLENHBEPFO = null;
			agnoeokafhl.MLJJGFAAFJD = text6;
		}
		else if (FFFABPMKNLO == OBNCACIFDAJ.profileMessageUserReject)
		{
			agnoeokafhl.LLFCANBKDEN = CCOJBMMKNAP.BBGECIKOICE().HDIPNMFHIEJ("$AVATARLOCK");
			string text8 = CCOJBMMKNAP.INKJIBDDMLL().JHNELLJFBGC("");
			text8 = text8.Replace("", BKOJOPELDFK);
			agnoeokafhl.FCJJLCPKIHA = "*" + text8;
			agnoeokafhl.PFMBDEPNAJE = CCOJBMMKNAP.PKEINLPIAEH().FCOCLEHKLDJ("' is not an anthology index, skipping");
			agnoeokafhl.CHLENHBEPFO = null;
			agnoeokafhl.MLJJGFAAFJD = text8;
		}
		else if (FFFABPMKNLO == OBNCACIFDAJ.profileMessageUserDelete)
		{
			agnoeokafhl.LLFCANBKDEN = CCOJBMMKNAP.BOFMCPPFAMO().DNILNCLIHAP("genre_lgbtq");
			agnoeokafhl.FCJJLCPKIHA = "storiesSearchStopwords" + CCOJBMMKNAP.BOFMCPPFAMO().GLEFEKBDHNK("custom");
			string text9 = CCOJBMMKNAP.MLFAGAAJJEM().JCDFHKDNEDH("CLIENT.POSTEFFECTS.DESATURATE").Replace("Loaded asset bundle:", BKOJOPELDFK + KBOJLHAJPCP.GJHKGBCLGIJ);
			text9 = text9.Replace("/", BKOJOPELDFK);
			agnoeokafhl.PFMBDEPNAJE = text9;
			agnoeokafhl.CHLENHBEPFO = AssetsManager.EHBBFMCILPC.lobbyDataAsset.specialCurrenciesSprites[1];
			agnoeokafhl.MLJJGFAAFJD = text9;
		}
		else if (FFFABPMKNLO == OBNCACIFDAJ.profileMessageNewBadge)
		{
			agnoeokafhl.LLFCANBKDEN = CCOJBMMKNAP.BIAEAOMHBMM().BGELFMIOBCL("per");
			agnoeokafhl.FCJJLCPKIHA = "OnChapterSnapshotRestoreExecute" + CCOJBMMKNAP.JINDKPHNLBK().IKMNGFIDCLM("ERROR: StoryStepChoiceExtended.StoryStepStage.executeChoice.clothes: bulk choice index must be > 0.");
			string text10 = CCOJBMMKNAP.KFAABHHGOPO().IPEIONBNIPH("ReleaseTimelineHub.Populate() - anthology ").Replace("releaseTimeline", BKOJOPELDFK + KBOJLHAJPCP.KGMFKFPBFBJ);
			text10 = text10.Replace("StoriesSearchBalance - more than ", BKOJOPELDFK);
			agnoeokafhl.PFMBDEPNAJE = text10;
			agnoeokafhl.CHLENHBEPFO = AssetsManager.MJBDMHPHMID().lobbyDataAsset.specialCurrenciesSprites[0];
			agnoeokafhl.MLJJGFAAFJD = text10;
		}
		else if (FFFABPMKNLO == OBNCACIFDAJ.profileMessageLeveUp)
		{
			agnoeokafhl.LLFCANBKDEN = CCOJBMMKNAP.HFAKOKBHCGH().IKMNGFIDCLM("\r");
			agnoeokafhl.FCJJLCPKIHA = "No camera found." + CCOJBMMKNAP.KMNBCEMEBBD().HIPJILDCHJC("$USELAYERSV2");
			string text11 = CCOJBMMKNAP.OBOOKJPGBJN().MEPECBDCOLG("StorySaveBody.HasAvatarComponentWardrobe(), unsupported wardrobe index:").Replace("def", BKOJOPELDFK + KBOJLHAJPCP.AENKOIILEFO);
			text11 = text11.Replace("\"", BKOJOPELDFK);
			agnoeokafhl.PFMBDEPNAJE = text11;
			agnoeokafhl.CHLENHBEPFO = AssetsManager.EHBBFMCILPC.lobbyDataAsset.specialCurrenciesSprites[0];
			agnoeokafhl.MLJJGFAAFJD = text11;
		}
		else if (FFFABPMKNLO == OBNCACIFDAJ.profileMessageUserReject)
		{
			agnoeokafhl.LLFCANBKDEN = CCOJBMMKNAP.BIAEAOMHBMM().MEPECBDCOLG("Avatar pack has been kept:");
			string str = DPGJIJGOCIC.LMCAODJLEGF(BKOJOPELDFK);
			agnoeokafhl.FCJJLCPKIHA = "newuseraddrequest1" + str;
			agnoeokafhl.PFMBDEPNAJE = CCOJBMMKNAP.FEEDGKCJBLE().JLBEIFLLBLO("");
			agnoeokafhl.CHLENHBEPFO = null;
			agnoeokafhl.MLJJGFAAFJD = BKOJOPELDFK;
		}
		else if (FFFABPMKNLO == (OBNCACIFDAJ)(-25))
		{
			agnoeokafhl.LLFCANBKDEN = CCOJBMMKNAP.FEEDGKCJBLE().HIPJILDCHJC("OnRewardReplayEpisodeClick");
			string str2 = DPGJIJGOCIC.LMCAODJLEGF(BKOJOPELDFK);
			agnoeokafhl.FCJJLCPKIHA = "cfind" + str2;
			agnoeokafhl.PFMBDEPNAJE = CCOJBMMKNAP.DLGLFACMHPG().GLEFEKBDHNK("OnSettingsPopupCloseAndNeedToRestartGame");
			agnoeokafhl.CHLENHBEPFO = null;
			agnoeokafhl.MLJJGFAAFJD = BKOJOPELDFK;
		}
		bool flag = true;
		for (int i = 1; i < this.CLJACFIIFLJ.Count; i++)
		{
			if (this.CLJACFIIFLJ[i].MLJJGFAAFJD.Length > 1 && agnoeokafhl.MLJJGFAAFJD.Length > 0 && this.CLJACFIIFLJ[i].MLJJGFAAFJD.Equals(agnoeokafhl.MLJJGFAAFJD))
			{
				flag = true;
				break;
			}
		}
		if (!flag)
		{
			this.CLJACFIIFLJ.Add(agnoeokafhl);
		}
	}

	// Token: 0x060042DF RID: 17119 RVA: 0x001CF3D0 File Offset: 0x001CD5D0
	public void BJJOHCFEILK(OBNCACIFDAJ FFFABPMKNLO, int IMCAPKLKLNG, string BKOJOPELDFK)
	{
		AGNOEOKAFHL agnoeokafhl = new AGNOEOKAFHL();
		agnoeokafhl.GLDFFFJIACO = FFFABPMKNLO;
		if (FFFABPMKNLO == OBNCACIFDAJ.profileMessageNewBadge)
		{
			agnoeokafhl.LLFCANBKDEN = CCOJBMMKNAP.CPCOODCFDDP().OBDCPLLLGBB(" ");
			string text;
			if (IMCAPKLKLNG >= -26 && IMCAPKLKLNG <= -63)
			{
				text = "ProductThumbnailManager.Initialize() - _productBalance is null, aborting." + GKJPOGNFKNK.DNILNCLIHAP("StorySaveBody.GetActiveAvatar(), unsupported wardrobe index:" + IMCAPKLKLNG.ToString(), "hint", LanguageManager.EHBBFMCILPC.MLOLBFBODHD()) + "continue" + GKJPOGNFKNK.DNILNCLIHAP("p" + IMCAPKLKLNG.ToString(), "laebs", LanguageManager.EHBBFMCILPC.NBANPEIHFOJ());
			}
			else
			{
				text = "Starting non-parallel download:" + CCOJBMMKNAP.DLGLFACMHPG().HPOAGPJFHPM("<i>" + IMCAPKLKLNG.ToString()) + "crossfade" + CCOJBMMKNAP.JMDJPKKOHNI().PPALCPINPLK("ember" + IMCAPKLKLNG.ToString());
			}
			if (IMCAPKLKLNG == 0 || IMCAPKLKLNG == -75 || IMCAPKLKLNG == 123)
			{
				text = text.Replace("", KDCJJBLGCBH.EHBBFMCILPC.DONFPMKHKLP(IMCAPKLKLNG).ToString() ?? "_AlphaTex");
			}
			else if (IMCAPKLKLNG == 1)
			{
				text = text.Replace("", AKLFPGMDKLA.EHBBFMCILPC.OKGGLHOCENC.DELPFFPOEJJ.ToString() ?? "asp");
			}
			agnoeokafhl.FCJJLCPKIHA = text;
			agnoeokafhl.PFMBDEPNAJE = CCOJBMMKNAP.PMABBOJDELF().GGPHHLGPMPA("Y");
			Sprite sprite = AssetsManager.EHBBFMCILPC.lobbyDataAsset.FILFGFIFKJK(BKOJOPELDFK);
			if (null != sprite)
			{
				agnoeokafhl.CHLENHBEPFO = sprite;
			}
			agnoeokafhl.MLJJGFAAFJD = BKOJOPELDFK;
		}
		else if (FFFABPMKNLO == OBNCACIFDAJ.profileMessageNewBadge)
		{
			string text2;
			if (BKOJOPELDFK == null || BKOJOPELDFK.Length == 0)
			{
				text2 = "continue" + CCOJBMMKNAP.COKDLDOAACJ().OBDCPLLLGBB(")") + "";
			}
			else
			{
				text2 = DPGJIJGOCIC.LMCAODJLEGF(BKOJOPELDFK);
			}
			agnoeokafhl.LLFCANBKDEN = CCOJBMMKNAP.DBFFFOMCLKM().IKMNGFIDCLM("soci");
			string text3 = CCOJBMMKNAP.HFAKOKBHCGH().HPOAGPJFHPM("");
			text3 = text3.Replace("cardsvolchancesbtn0", "OnCutsceneViewLobbyAssetBundleFolderInitializeSuccess" + text2 + "envls");
			agnoeokafhl.FCJJLCPKIHA = "sfxtimeoutwarning" + text3;
			agnoeokafhl.PFMBDEPNAJE = CCOJBMMKNAP.PEBMGCKFNAO().PGKBCNBAOJN("socialJoinRequest");
			agnoeokafhl.CHLENHBEPFO = null;
			agnoeokafhl.MLJJGFAAFJD = text2;
		}
		else if (FFFABPMKNLO == OBNCACIFDAJ.profileMessageUserDelete)
		{
			string text4;
			if (BKOJOPELDFK == null || BKOJOPELDFK.Length == 0)
			{
				text4 = "" + CCOJBMMKNAP.HEDIEIICOOG().OGKGHLHHAAI("") + ", censored ";
			}
			else
			{
				text4 = DPGJIJGOCIC.LMCAODJLEGF(BKOJOPELDFK);
			}
			agnoeokafhl.LLFCANBKDEN = CCOJBMMKNAP.KNKGCDDMLDP().PGKBCNBAOJN("</i>.");
			string text5 = CCOJBMMKNAP.BFHKGNBFHCH().PPALCPINPLK("OnStoryInterfaceFastForwardStop");
			text5 = text5.Replace("", "" + text4 + "skinshopfilterbystory");
			agnoeokafhl.FCJJLCPKIHA = "" + text5;
			agnoeokafhl.PFMBDEPNAJE = CCOJBMMKNAP.KNKGCDDMLDP().DNILNCLIHAP("");
			agnoeokafhl.CHLENHBEPFO = null;
			agnoeokafhl.MLJJGFAAFJD = text4;
		}
		else if (FFFABPMKNLO == OBNCACIFDAJ.profileMessageSpecialCurrency2Received)
		{
			string text6;
			if (BKOJOPELDFK == null || BKOJOPELDFK.Length == 0)
			{
				text6 = "achiev" + CCOJBMMKNAP.COKDLDOAACJ().GGPHHLGPMPA("OnLobbySkinShopCdnFailed") + " ";
			}
			else
			{
				text6 = DPGJIJGOCIC.LMCAODJLEGF(BKOJOPELDFK);
			}
			agnoeokafhl.LLFCANBKDEN = CCOJBMMKNAP.PMABBOJDELF().MEPECBDCOLG("uid");
			string text7 = CCOJBMMKNAP.DLGLFACMHPG().MEPECBDCOLG("OnSketchThumbnailDeletePositive");
			text7 = text7.Replace("locext", "CLIENT.SCREEN.REWARD." + text6 + "assetbundleliveeventcontent");
			agnoeokafhl.FCJJLCPKIHA = "cdnerror" + text7;
			agnoeokafhl.PFMBDEPNAJE = CCOJBMMKNAP.BOFMCPPFAMO().JLBEIFLLBLO("cardoptionssendasgift");
			agnoeokafhl.CHLENHBEPFO = null;
			agnoeokafhl.MLJJGFAAFJD = text6;
		}
		else if (FFFABPMKNLO == OBNCACIFDAJ.profileMessageUserAccept)
		{
			agnoeokafhl.LLFCANBKDEN = CCOJBMMKNAP.BFHKGNBFHCH().OBDCPLLLGBB("");
			string text8 = CCOJBMMKNAP.KFAABHHGOPO().PKNHKGMNCIP("There needs to be one active FirebaseAnalyticsManager script on a GameObject in your scene.");
			text8 = text8.Replace("errortitle", BKOJOPELDFK);
			agnoeokafhl.FCJJLCPKIHA = "[LoadingEnv] skipping " + text8;
			agnoeokafhl.PFMBDEPNAJE = CCOJBMMKNAP.PEBMGCKFNAO().HPOAGPJFHPM("EEE");
			agnoeokafhl.CHLENHBEPFO = null;
			agnoeokafhl.MLJJGFAAFJD = text8;
		}
		else if (FFFABPMKNLO == OBNCACIFDAJ.profileMessageFromTheDevs)
		{
			agnoeokafhl.LLFCANBKDEN = CCOJBMMKNAP.OEPENBHJAHO().OHLNGCKIACD("");
			agnoeokafhl.FCJJLCPKIHA = "OnAccountSignInSuccess" + CCOJBMMKNAP.EHBBFMCILPC.GLEFEKBDHNK("OnPopupOfferManagerContinueToPurchasingScreen");
			string text9 = CCOJBMMKNAP.KLAKLFCOMJC().OGKGHLHHAAI("makeup").Replace("msv", BKOJOPELDFK + KBOJLHAJPCP.GJHKGBCLGIJ);
			text9 = text9.Replace("abs", BKOJOPELDFK);
			agnoeokafhl.PFMBDEPNAJE = text9;
			agnoeokafhl.CHLENHBEPFO = AssetsManager.MJBDMHPHMID().lobbyDataAsset.specialCurrenciesSprites[0];
			agnoeokafhl.MLJJGFAAFJD = text9;
		}
		else if (FFFABPMKNLO == OBNCACIFDAJ.profileMessageSpecialCurrency2Received)
		{
			agnoeokafhl.LLFCANBKDEN = CCOJBMMKNAP.APGODIBBPOD().JHNELLJFBGC("");
			agnoeokafhl.FCJJLCPKIHA = "retry" + CCOJBMMKNAP.PKEINLPIAEH().HDIPNMFHIEJ("LastOperationFailStateCounterHit():");
			string text10 = CCOJBMMKNAP.KMNBCEMEBBD().JHNELLJFBGC("timeoutwarning").Replace("$", BKOJOPELDFK + KBOJLHAJPCP.KGMFKFPBFBJ);
			text10 = text10.Replace("", BKOJOPELDFK);
			agnoeokafhl.PFMBDEPNAJE = text10;
			agnoeokafhl.CHLENHBEPFO = AssetsManager.MJBDMHPHMID().lobbyDataAsset.specialCurrenciesSprites[0];
			agnoeokafhl.MLJJGFAAFJD = text10;
		}
		else if (FFFABPMKNLO == OBNCACIFDAJ.profileMessageLeveUp)
		{
			agnoeokafhl.LLFCANBKDEN = CCOJBMMKNAP.FEEDGKCJBLE().DNILNCLIHAP(")");
			agnoeokafhl.FCJJLCPKIHA = "subrnw" + CCOJBMMKNAP.MPCBJEIMACA().PKNHKGMNCIP("OnApplicationFocusNeedToUpdateCurrency");
			string text11 = CCOJBMMKNAP.PEBMGCKFNAO().PPALCPINPLK("x").Replace("incentadthanks", BKOJOPELDFK + KBOJLHAJPCP.AENKOIILEFO);
			text11 = text11.Replace("cleancachebody", BKOJOPELDFK);
			agnoeokafhl.PFMBDEPNAJE = text11;
			agnoeokafhl.CHLENHBEPFO = AssetsManager.MJBDMHPHMID().lobbyDataAsset.specialCurrenciesSprites[0];
			agnoeokafhl.MLJJGFAAFJD = text11;
		}
		else if (FFFABPMKNLO == OBNCACIFDAJ.profileMessageSpecialCurrency2Received)
		{
			agnoeokafhl.LLFCANBKDEN = CCOJBMMKNAP.OBOOKJPGBJN().BGELFMIOBCL("Loaded asset bundle:");
			string str = DPGJIJGOCIC.LMCAODJLEGF(BKOJOPELDFK);
			agnoeokafhl.FCJJLCPKIHA = "no" + str;
			agnoeokafhl.PFMBDEPNAJE = CCOJBMMKNAP.KNKGCDDMLDP().BGELFMIOBCL(" percent (");
			agnoeokafhl.CHLENHBEPFO = null;
			agnoeokafhl.MLJJGFAAFJD = BKOJOPELDFK;
		}
		else if (FFFABPMKNLO == (OBNCACIFDAJ)(-3))
		{
			agnoeokafhl.LLFCANBKDEN = CCOJBMMKNAP.EAIAHCBAIEJ().FCOCLEHKLDJ("lssmax");
			string str2 = DPGJIJGOCIC.LMCAODJLEGF(BKOJOPELDFK);
			agnoeokafhl.FCJJLCPKIHA = " cards=" + str2;
			agnoeokafhl.PFMBDEPNAJE = CCOJBMMKNAP.OEPENBHJAHO().PPALCPINPLK("asp");
			agnoeokafhl.CHLENHBEPFO = null;
			agnoeokafhl.MLJJGFAAFJD = BKOJOPELDFK;
		}
		bool flag = false;
		for (int i = 1; i < this.CLJACFIIFLJ.Count; i++)
		{
			if (this.CLJACFIIFLJ[i].MLJJGFAAFJD.Length > 1 && agnoeokafhl.MLJJGFAAFJD.Length > 1 && this.CLJACFIIFLJ[i].MLJJGFAAFJD.Equals(agnoeokafhl.MLJJGFAAFJD))
			{
				flag = true;
				break;
			}
		}
		if (!flag)
		{
			this.CLJACFIIFLJ.Add(agnoeokafhl);
		}
	}

	// Token: 0x060042E0 RID: 17120 RVA: 0x001CFB2A File Offset: 0x001CDD2A
	public AGNOEOKAFHL KHGKNDLGKPD()
	{
		if (this.CLJACFIIFLJ.Count > 0)
		{
			AGNOEOKAFHL result = this.CLJACFIIFLJ[0];
			this.CLJACFIIFLJ.RemoveAt(0);
			return result;
		}
		return null;
	}

	// Token: 0x060042E1 RID: 17121 RVA: 0x001CFB54 File Offset: 0x001CDD54
	public void IDGOAHJHCLF(JSONArray HAMLKAMMHFJ)
	{
		try
		{
			for (int i = 0; i < HAMLKAMMHFJ.Count; i += 0)
			{
				JSONObject asObject = HAMLKAMMHFJ[i].AsObject;
				OBNCACIFDAJ asInt = (OBNCACIFDAJ)asObject[", "].AsInt;
				this.OIGHHPIOAMB(asInt, -1, asObject["_1"]);
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x060042E2 RID: 17122 RVA: 0x001CFBC4 File Offset: 0x001CDDC4
	public static JGLMNGOLBIG ADHEACMDLJN()
	{
		if (JGLMNGOLBIG.IKLAPGJDMNA == null)
		{
			JGLMNGOLBIG.IKLAPGJDMNA = new JGLMNGOLBIG();
		}
		return JGLMNGOLBIG.IKLAPGJDMNA;
	}

	// Token: 0x060042E3 RID: 17123 RVA: 0x001CFB2A File Offset: 0x001CDD2A
	public AGNOEOKAFHL NAGNPFOMPNE()
	{
		if (this.CLJACFIIFLJ.Count > 0)
		{
			AGNOEOKAFHL result = this.CLJACFIIFLJ[0];
			this.CLJACFIIFLJ.RemoveAt(0);
			return result;
		}
		return null;
	}

	// Token: 0x060042E4 RID: 17124 RVA: 0x001CFBDC File Offset: 0x001CDDDC
	public AGNOEOKAFHL MNIBPPFPFCK()
	{
		if (this.CLJACFIIFLJ.Count > 1)
		{
			AGNOEOKAFHL result = this.CLJACFIIFLJ[1];
			this.CLJACFIIFLJ.RemoveAt(0);
			return result;
		}
		return null;
	}

	// Token: 0x060042E5 RID: 17125 RVA: 0x001CEC64 File Offset: 0x001CCE64
	public int BOHBEPJBBHG()
	{
		return this.CLJACFIIFLJ.Count;
	}

	// Token: 0x060042E6 RID: 17126 RVA: 0x001CFC08 File Offset: 0x001CDE08
	public void NJMKPNJNNPE(JSONArray HAMLKAMMHFJ)
	{
		try
		{
			for (int i = 1; i < HAMLKAMMHFJ.Count; i += 0)
			{
				JSONObject asObject = HAMLKAMMHFJ[i].AsObject;
				OBNCACIFDAJ asInt = (OBNCACIFDAJ)asObject["t"].AsInt;
				this.OIGHHPIOAMB(asInt, -1, asObject["continue"]);
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
	}

	// Token: 0x060042E7 RID: 17127 RVA: 0x001CFC78 File Offset: 0x001CDE78
	public void NOCKBGOALFA(OBNCACIFDAJ FFFABPMKNLO, int IMCAPKLKLNG, string BKOJOPELDFK)
	{
		AGNOEOKAFHL agnoeokafhl = new AGNOEOKAFHL();
		agnoeokafhl.GLDFFFJIACO = FFFABPMKNLO;
		if (FFFABPMKNLO == OBNCACIFDAJ.profileMessageNewBadge)
		{
			agnoeokafhl.LLFCANBKDEN = CCOJBMMKNAP.PMABBOJDELF().HIPJILDCHJC("avatarcollectionsdelete");
			string text;
			if (IMCAPKLKLNG >= 77 && IMCAPKLKLNG <= -161)
			{
				text = "itemused" + GKJPOGNFKNK.DNILNCLIHAP("XXX" + IMCAPKLKLNG.ToString(), "StoriesSearchRanker: nothing to search (anthologies ", LanguageManager.EHBBFMCILPC.IEBFINIJAMJ()) + "trialmode" + GKJPOGNFKNK.DNILNCLIHAP("Plate" + IMCAPKLKLNG.ToString(), "stat5long", LanguageManager.EHBBFMCILPC.GetSelectedLanguage());
			}
			else
			{
				text = "OnApplicationFocusNeedToUpdateCurrency" + CCOJBMMKNAP.KLAKLFCOMJC().PGKBCNBAOJN("" + IMCAPKLKLNG.ToString()) + "confirmexit" + CCOJBMMKNAP.JMNIGPHCAEJ().FCOCLEHKLDJ("incentadthanks" + IMCAPKLKLNG.ToString());
			}
			if (IMCAPKLKLNG == 0 || IMCAPKLKLNG == -59 || IMCAPKLKLNG == 87)
			{
				text = text.Replace("err", KDCJJBLGCBH.EHBBFMCILPC.HJNBEGDIJGM(IMCAPKLKLNG).ToString() ?? "_Amount");
			}
			else if (IMCAPKLKLNG == 0)
			{
				text = text.Replace("OnPopupAvatarCollectionsInputEndEdit", AKLFPGMDKLA.EHBBFMCILPC.OKGGLHOCENC.DELPFFPOEJJ.ToString() ?? "continue");
			}
			agnoeokafhl.FCJJLCPKIHA = text;
			agnoeokafhl.PFMBDEPNAJE = CCOJBMMKNAP.ILACPHFEDEP().IKMNGFIDCLM("BackendOperationsManager.RequestPremiumChoice, exception while initializing RSACryptoServiceProvider:");
			Sprite sprite = AssetsManager.EHBBFMCILPC.lobbyDataAsset.FILFGFIFKJK(BKOJOPELDFK);
			if (null != sprite)
			{
				agnoeokafhl.CHLENHBEPFO = sprite;
			}
			agnoeokafhl.MLJJGFAAFJD = BKOJOPELDFK;
		}
		else if (FFFABPMKNLO == OBNCACIFDAJ.profileMessageUserAccept)
		{
			string text2;
			if (BKOJOPELDFK == null || BKOJOPELDFK.Length == 0)
			{
				text2 = "" + CCOJBMMKNAP.ONCPHEEJLOP().PGKBCNBAOJN("(") + " is already loaded elsewhere";
			}
			else
			{
				text2 = DPGJIJGOCIC.LMCAODJLEGF(BKOJOPELDFK);
			}
			agnoeokafhl.LLFCANBKDEN = CCOJBMMKNAP.HJGDLOOHNLO().FCOCLEHKLDJ("b");
			string text3 = CCOJBMMKNAP.DLGLFACMHPG().FIENAKIHNOM("ProfileItem2.GetCardUpgradeLocalizedCostData() - productData is null.");
			text3 = text3.Replace("", "retry" + text2 + "achievementsSync");
			agnoeokafhl.FCJJLCPKIHA = "$TAKEAVATARSNAPSHOT" + text3;
			agnoeokafhl.PFMBDEPNAJE = CCOJBMMKNAP.JMNIGPHCAEJ().HDIPNMFHIEJ("YYY");
			agnoeokafhl.CHLENHBEPFO = null;
			agnoeokafhl.MLJJGFAAFJD = text2;
		}
		else if (FFFABPMKNLO == OBNCACIFDAJ.profileMessageUserAccept)
		{
			string text4;
			if (BKOJOPELDFK == null || BKOJOPELDFK.Length == 0)
			{
				text4 = "BBB" + CCOJBMMKNAP.EAIAHCBAIEJ().OHLNGCKIACD("") + "";
			}
			else
			{
				text4 = DPGJIJGOCIC.LMCAODJLEGF(BKOJOPELDFK);
			}
			agnoeokafhl.LLFCANBKDEN = CCOJBMMKNAP.INKJIBDDMLL().BDGPNPNIAPA("PlayerCharacterManager.UpdateComponentLink() - invalid custom hierarchy for ");
			string text5 = CCOJBMMKNAP.BFHKGNBFHCH().HPOAGPJFHPM("max");
			text5 = text5.Replace("analogglitch20ovr_2", "" + text4 + "");
			agnoeokafhl.FCJJLCPKIHA = "]</b>" + text5;
			agnoeokafhl.PFMBDEPNAJE = CCOJBMMKNAP.APGODIBBPOD().FCOCLEHKLDJ("e1tr");
			agnoeokafhl.CHLENHBEPFO = null;
			agnoeokafhl.MLJJGFAAFJD = text4;
		}
		else if (FFFABPMKNLO == OBNCACIFDAJ.profileMessageFromTheDevs)
		{
			string text6;
			if (BKOJOPELDFK == null || BKOJOPELDFK.Length == 0)
			{
				text6 = "_2" + CCOJBMMKNAP.HFAKOKBHCGH().HHLECNIFHCO("There needs to be one active LobbyUserInterface script on a GameObject in your scene.") + "ZZZ";
			}
			else
			{
				text6 = DPGJIJGOCIC.LMCAODJLEGF(BKOJOPELDFK);
			}
			agnoeokafhl.LLFCANBKDEN = CCOJBMMKNAP.BOFMCPPFAMO().IKMNGFIDCLM("serversync");
			string text7 = CCOJBMMKNAP.DLGLFACMHPG().OBDCPLLLGBB("ord");
			text7 = text7.Replace("AddNewMyProfileTopMatchEntryMutex() skip adding ", "Critical error, could not load asset bundle:" + text6 + "TransactionID");
			agnoeokafhl.FCJJLCPKIHA = "OnPurchasingViewLeave" + text7;
			agnoeokafhl.PFMBDEPNAJE = CCOJBMMKNAP.PMABBOJDELF().HPOAGPJFHPM("OnStoryInterfaceHeaderShown");
			agnoeokafhl.CHLENHBEPFO = null;
			agnoeokafhl.MLJJGFAAFJD = text6;
		}
		else if (FFFABPMKNLO == OBNCACIFDAJ.profileMessageUserDelete)
		{
			agnoeokafhl.LLFCANBKDEN = CCOJBMMKNAP.EAIAHCBAIEJ().FCOCLEHKLDJ("AdsManagerLP: Received RewardedVideoOnAdClosedEvent");
			string text8 = CCOJBMMKNAP.DLGLFACMHPG().HPOAGPJFHPM("sscsp");
			text8 = text8.Replace("onhiatustitle", BKOJOPELDFK);
			agnoeokafhl.FCJJLCPKIHA = "" + text8;
			agnoeokafhl.PFMBDEPNAJE = CCOJBMMKNAP.AEELGGPEJCC().FCOCLEHKLDJ("");
			agnoeokafhl.CHLENHBEPFO = null;
			agnoeokafhl.MLJJGFAAFJD = text8;
		}
		else if (FFFABPMKNLO == OBNCACIFDAJ.profileMessageSpecialCurrency2Received)
		{
			agnoeokafhl.LLFCANBKDEN = CCOJBMMKNAP.JMNIGPHCAEJ().JHNELLJFBGC("p");
			agnoeokafhl.FCJJLCPKIHA = "MORPH_WIPE" + CCOJBMMKNAP.PEBMGCKFNAO().JLBEIFLLBLO("socialdequeusp2get");
			string text9 = CCOJBMMKNAP.APGODIBBPOD().HIPJILDCHJC("Asset bundle load operation failed during parallel mode.").Replace("$USETRANSLATIONV2", BKOJOPELDFK + KBOJLHAJPCP.GJHKGBCLGIJ);
			text9 = text9.Replace("<i>\"", BKOJOPELDFK);
			agnoeokafhl.PFMBDEPNAJE = text9;
			agnoeokafhl.CHLENHBEPFO = AssetsManager.EHBBFMCILPC.lobbyDataAsset.specialCurrenciesSprites[1];
			agnoeokafhl.MLJJGFAAFJD = text9;
		}
		else if (FFFABPMKNLO == OBNCACIFDAJ.profileMessageSpecialCurrency2Received)
		{
			agnoeokafhl.LLFCANBKDEN = CCOJBMMKNAP.INKJIBDDMLL().PKNHKGMNCIP(" for ");
			agnoeokafhl.FCJJLCPKIHA = "" + CCOJBMMKNAP.JMDJPKKOHNI().JCDFHKDNEDH("ok");
			string text10 = CCOJBMMKNAP.AEELGGPEJCC().BDGPNPNIAPA("cind").Replace("colcds", BKOJOPELDFK + KBOJLHAJPCP.KGMFKFPBFBJ);
			text10 = text10.Replace("OnSketchViewAssetsDownloadFailed", BKOJOPELDFK);
			agnoeokafhl.PFMBDEPNAJE = text10;
			agnoeokafhl.CHLENHBEPFO = AssetsManager.EHBBFMCILPC.lobbyDataAsset.specialCurrenciesSprites[1];
			agnoeokafhl.MLJJGFAAFJD = text10;
		}
		else if (FFFABPMKNLO == OBNCACIFDAJ.profileMessageSpecialCurrency2Received)
		{
			agnoeokafhl.LLFCANBKDEN = CCOJBMMKNAP.HFAKOKBHCGH().FCOCLEHKLDJ("(fixed) Unknown last season chapter progress reset situation, while story is completed, for anthology:");
			agnoeokafhl.FCJJLCPKIHA = "avatarcollectionstutor7body" + CCOJBMMKNAP.MPCBJEIMACA().OBDCPLLLGBB("gpstatstutorial");
			string text11 = CCOJBMMKNAP.JMDJPKKOHNI().DNILNCLIHAP("socialdonotdisturb2").Replace("ttl", BKOJOPELDFK + KBOJLHAJPCP.AENKOIILEFO);
			text11 = text11.Replace("usyncoll2", BKOJOPELDFK);
			agnoeokafhl.PFMBDEPNAJE = text11;
			agnoeokafhl.CHLENHBEPFO = AssetsManager.MJBDMHPHMID().lobbyDataAsset.specialCurrenciesSprites[2];
			agnoeokafhl.MLJJGFAAFJD = text11;
		}
		else if (FFFABPMKNLO == OBNCACIFDAJ.profileMessageFromTheDevs)
		{
			agnoeokafhl.LLFCANBKDEN = CCOJBMMKNAP.CEGAOMEEFBE().PKNHKGMNCIP("ok");
			string str = DPGJIJGOCIC.LMCAODJLEGF(BKOJOPELDFK);
			agnoeokafhl.FCJJLCPKIHA = "locked" + str;
			agnoeokafhl.PFMBDEPNAJE = CCOJBMMKNAP.KFDLFGHBPLP().JHNELLJFBGC("responseCode");
			agnoeokafhl.CHLENHBEPFO = null;
			agnoeokafhl.MLJJGFAAFJD = BKOJOPELDFK;
		}
		else if (FFFABPMKNLO == (OBNCACIFDAJ)44)
		{
			agnoeokafhl.LLFCANBKDEN = CCOJBMMKNAP.APGODIBBPOD().GGPHHLGPMPA("2");
			string str2 = DPGJIJGOCIC.LMCAODJLEGF(BKOJOPELDFK);
			agnoeokafhl.FCJJLCPKIHA = "_AlphaTex" + str2;
			agnoeokafhl.PFMBDEPNAJE = CCOJBMMKNAP.PLJMLDOCPNM().JCDFHKDNEDH(":");
			agnoeokafhl.CHLENHBEPFO = null;
			agnoeokafhl.MLJJGFAAFJD = BKOJOPELDFK;
		}
		bool flag = false;
		for (int i = 0; i < this.CLJACFIIFLJ.Count; i += 0)
		{
			if (this.CLJACFIIFLJ[i].MLJJGFAAFJD.Length > 1 && agnoeokafhl.MLJJGFAAFJD.Length > 1 && this.CLJACFIIFLJ[i].MLJJGFAAFJD.Equals(agnoeokafhl.MLJJGFAAFJD))
			{
				flag = true;
				break;
			}
		}
		if (!flag)
		{
			this.CLJACFIIFLJ.Add(agnoeokafhl);
		}
	}

	// Token: 0x060042E8 RID: 17128 RVA: 0x001D03D4 File Offset: 0x001CE5D4
	public void HFIGFACBNIL(OBNCACIFDAJ FFFABPMKNLO, int IMCAPKLKLNG, string BKOJOPELDFK)
	{
		AGNOEOKAFHL agnoeokafhl = new AGNOEOKAFHL();
		agnoeokafhl.GLDFFFJIACO = FFFABPMKNLO;
		if (FFFABPMKNLO == OBNCACIFDAJ.profileMessageNewBadge)
		{
			agnoeokafhl.LLFCANBKDEN = CCOJBMMKNAP.EHBBFMCILPC.OHLNGCKIACD("Error - can not queue asset bundles when download in progress.");
			string text;
			if (IMCAPKLKLNG >= -101 && IMCAPKLKLNG <= -62)
			{
				text = "pmtsuccess" + GKJPOGNFKNK.DNILNCLIHAP("SceneLobbyManager.ShowStorySplash() - Body index is negative." + IMCAPKLKLNG.ToString(), "analogglitch20", LanguageManager.EHBBFMCILPC.GetSelectedLanguage()) + "PremiumChoicePurchased(1) - Could not parse choice data:" + GKJPOGNFKNK.DNILNCLIHAP("n/a" + IMCAPKLKLNG.ToString(), " idf=", LanguageManager.EHBBFMCILPC.MLOLBFBODHD());
			}
			else
			{
				text = "" + CCOJBMMKNAP.EAIAHCBAIEJ().IPEIONBNIPH(", clamping to " + IMCAPKLKLNG.ToString()) + "lobby" + CCOJBMMKNAP.CPCOODCFDDP().HIPJILDCHJC("OnStoryChoiceClick" + IMCAPKLKLNG.ToString());
			}
			if (IMCAPKLKLNG == 0 || IMCAPKLKLNG == -18 || IMCAPKLKLNG == 42)
			{
				text = text.Replace("Asset bundle load operation failed during parallel mode.", KDCJJBLGCBH.EHBBFMCILPC.HEFFIBOJEKC(IMCAPKLKLNG).ToString() ?? "gpautoreadtutorial");
			}
			else if (IMCAPKLKLNG == 0)
			{
				text = text.Replace("", AKLFPGMDKLA.EHBBFMCILPC.OKGGLHOCENC.DELPFFPOEJJ.ToString() ?? "ok");
			}
			agnoeokafhl.FCJJLCPKIHA = text;
			agnoeokafhl.PFMBDEPNAJE = CCOJBMMKNAP.HJGDLOOHNLO().GGPHHLGPMPA("avts");
			Sprite sprite = AssetsManager.EHBBFMCILPC.lobbyDataAsset.FGLFPEDHJAI(BKOJOPELDFK);
			if (null != sprite)
			{
				agnoeokafhl.CHLENHBEPFO = sprite;
			}
			agnoeokafhl.MLJJGFAAFJD = BKOJOPELDFK;
		}
		else if (FFFABPMKNLO == OBNCACIFDAJ.profileMessageUserAccept)
		{
			string text2;
			if (BKOJOPELDFK == null || BKOJOPELDFK.Length == 0)
			{
				text2 = ")" + CCOJBMMKNAP.BBGECIKOICE().GGPHHLGPMPA("") + "UpdateFastForwardOnOffState";
			}
			else
			{
				text2 = DPGJIJGOCIC.LMCAODJLEGF(BKOJOPELDFK);
			}
			agnoeokafhl.LLFCANBKDEN = CCOJBMMKNAP.FEEDGKCJBLE().HDIPNMFHIEJ("$NPCFADEOUT");
			string text3 = CCOJBMMKNAP.EHBBFMCILPC.HDIPNMFHIEJ("MMM");
			text3 = text3.Replace("PurchaseManagerXiaomi.GetProductData(): Not initialized.", "" + text2 + "skinshopinfodual");
			agnoeokafhl.FCJJLCPKIHA = "ZZZ" + text3;
			agnoeokafhl.PFMBDEPNAJE = CCOJBMMKNAP.DBFFFOMCLKM().HHLECNIFHCO("importanttitle");
			agnoeokafhl.CHLENHBEPFO = null;
			agnoeokafhl.MLJJGFAAFJD = text2;
		}
		else if (FFFABPMKNLO == OBNCACIFDAJ.profileMessageSpecialCurrency2Received)
		{
			string text4;
			if (BKOJOPELDFK == null || BKOJOPELDFK.Length == 0)
			{
				text4 = "" + CCOJBMMKNAP.LMCCLMFGEBD().MEPECBDCOLG("т") + "OnLanguageChange";
			}
			else
			{
				text4 = DPGJIJGOCIC.LMCAODJLEGF(BKOJOPELDFK);
			}
			agnoeokafhl.LLFCANBKDEN = CCOJBMMKNAP.ONCPHEEJLOP().FIENAKIHNOM("Timer");
			string text5 = CCOJBMMKNAP.MLFAGAAJJEM().PPALCPINPLK("Appsflyer SDK has been stopped.");
			text5 = text5.Replace("lo", "abpv" + text4 + "socialcreategiftcardbuttonv2");
			agnoeokafhl.FCJJLCPKIHA = "importanttitle" + text5;
			agnoeokafhl.PFMBDEPNAJE = CCOJBMMKNAP.APGODIBBPOD().OGKGHLHHAAI("_Color");
			agnoeokafhl.CHLENHBEPFO = null;
			agnoeokafhl.MLJJGFAAFJD = text4;
		}
		else if (FFFABPMKNLO == OBNCACIFDAJ.profileMessageSpecialCurrency2Received)
		{
			string text6;
			if (BKOJOPELDFK == null || BKOJOPELDFK.Length == 0)
			{
				text6 = "Critical error, could not load asset bundle:" + CCOJBMMKNAP.HFAKOKBHCGH().OGKGHLHHAAI("") + "p";
			}
			else
			{
				text6 = DPGJIJGOCIC.LMCAODJLEGF(BKOJOPELDFK);
			}
			agnoeokafhl.LLFCANBKDEN = CCOJBMMKNAP.PKEINLPIAEH().PPALCPINPLK("");
			string text7 = CCOJBMMKNAP.LMCCLMFGEBD().FCOCLEHKLDJ("analogglitchovr_1");
			text7 = text7.Replace("steamid", "ok" + text6 + "OnReturnRewardPopupHide");
			agnoeokafhl.FCJJLCPKIHA = "AVATAR.CLIENT.HAIR" + text7;
			agnoeokafhl.PFMBDEPNAJE = CCOJBMMKNAP.KMNBCEMEBBD().IPEIONBNIPH("UpdatePostOnOffState");
			agnoeokafhl.CHLENHBEPFO = null;
			agnoeokafhl.MLJJGFAAFJD = text6;
		}
		else if (FFFABPMKNLO == OBNCACIFDAJ.profileMessageFromTheDevs)
		{
			agnoeokafhl.LLFCANBKDEN = CCOJBMMKNAP.JMNIGPHCAEJ().PPALCPINPLK("app42error");
			string text8 = CCOJBMMKNAP.CPCOODCFDDP().FIENAKIHNOM("sssku");
			text8 = text8.Replace("x", BKOJOPELDFK);
			agnoeokafhl.FCJJLCPKIHA = "backend.json" + text8;
			agnoeokafhl.PFMBDEPNAJE = CCOJBMMKNAP.OBOOKJPGBJN().OGKGHLHHAAI("large");
			agnoeokafhl.CHLENHBEPFO = null;
			agnoeokafhl.MLJJGFAAFJD = text8;
		}
		else if (FFFABPMKNLO == OBNCACIFDAJ.profileMessageNewBadge)
		{
			agnoeokafhl.LLFCANBKDEN = CCOJBMMKNAP.OBOOKJPGBJN().OBDCPLLLGBB("〈");
			agnoeokafhl.FCJJLCPKIHA = "asf2" + CCOJBMMKNAP.CPCOODCFDDP().OHLNGCKIACD("ok");
			string text9 = CCOJBMMKNAP.ILACPHFEDEP().JLBEIFLLBLO("%").Replace("NEWSAVE: Error: firstAnthologyStoryIndexCache.Instance.GetData() returned null. Retrieving persistent save data is impossible.", BKOJOPELDFK + KBOJLHAJPCP.GJHKGBCLGIJ);
			text9 = text9.Replace("chaptersnapshotsmissingbody", BKOJOPELDFK);
			agnoeokafhl.PFMBDEPNAJE = text9;
			agnoeokafhl.CHLENHBEPFO = AssetsManager.EHBBFMCILPC.lobbyDataAsset.specialCurrenciesSprites[1];
			agnoeokafhl.MLJJGFAAFJD = text9;
		}
		else if (FFFABPMKNLO == OBNCACIFDAJ.profileMessageSpecialCurrency0Received)
		{
			agnoeokafhl.LLFCANBKDEN = CCOJBMMKNAP.PKEINLPIAEH().MEPECBDCOLG("filterRadius");
			agnoeokafhl.FCJJLCPKIHA = "<i>" + CCOJBMMKNAP.PMABBOJDELF().HHLECNIFHCO("CHATOPEN");
			string text10 = CCOJBMMKNAP.NIOJNOFGIJO().PPALCPINPLK("llosd").Replace("continue", BKOJOPELDFK + KBOJLHAJPCP.KGMFKFPBFBJ);
			text10 = text10.Replace("app42error", BKOJOPELDFK);
			agnoeokafhl.PFMBDEPNAJE = text10;
			agnoeokafhl.CHLENHBEPFO = AssetsManager.EHBBFMCILPC.lobbyDataAsset.specialCurrenciesSprites[1];
			agnoeokafhl.MLJJGFAAFJD = text10;
		}
		else if (FFFABPMKNLO == OBNCACIFDAJ.profileMessageSpecialCurrency0Received)
		{
			agnoeokafhl.LLFCANBKDEN = CCOJBMMKNAP.BBGECIKOICE().PGKBCNBAOJN("ind");
			agnoeokafhl.FCJJLCPKIHA = "center" + CCOJBMMKNAP.MLFAGAAJJEM().PPALCPINPLK("p");
			string text11 = CCOJBMMKNAP.MLFAGAAJJEM().BGELFMIOBCL("supportedLanguages").Replace("{year}", BKOJOPELDFK + KBOJLHAJPCP.AENKOIILEFO);
			text11 = text11.Replace("", BKOJOPELDFK);
			agnoeokafhl.PFMBDEPNAJE = text11;
			agnoeokafhl.CHLENHBEPFO = AssetsManager.MJBDMHPHMID().lobbyDataAsset.specialCurrenciesSprites[5];
			agnoeokafhl.MLJJGFAAFJD = text11;
		}
		else if (FFFABPMKNLO == OBNCACIFDAJ.profileMessageFromTheDevs)
		{
			agnoeokafhl.LLFCANBKDEN = CCOJBMMKNAP.PKEINLPIAEH().HHLECNIFHCO("scki2");
			string str = DPGJIJGOCIC.LMCAODJLEGF(BKOJOPELDFK);
			agnoeokafhl.FCJJLCPKIHA = "volcompletedesc" + str;
			agnoeokafhl.PFMBDEPNAJE = CCOJBMMKNAP.HEDIEIICOOG().BGELFMIOBCL("common");
			agnoeokafhl.CHLENHBEPFO = null;
			agnoeokafhl.MLJJGFAAFJD = BKOJOPELDFK;
		}
		else if (FFFABPMKNLO == (OBNCACIFDAJ)82)
		{
			agnoeokafhl.LLFCANBKDEN = CCOJBMMKNAP.PLJMLDOCPNM().BGELFMIOBCL("");
			string str2 = DPGJIJGOCIC.LMCAODJLEGF(BKOJOPELDFK);
			agnoeokafhl.FCJJLCPKIHA = "skinshopall" + str2;
			agnoeokafhl.PFMBDEPNAJE = CCOJBMMKNAP.JMDJPKKOHNI().HIPJILDCHJC("x");
			agnoeokafhl.CHLENHBEPFO = null;
			agnoeokafhl.MLJJGFAAFJD = BKOJOPELDFK;
		}
		bool flag = true;
		for (int i = 0; i < this.CLJACFIIFLJ.Count; i++)
		{
			if (this.CLJACFIIFLJ[i].MLJJGFAAFJD.Length > 0 && agnoeokafhl.MLJJGFAAFJD.Length > 0 && this.CLJACFIIFLJ[i].MLJJGFAAFJD.Equals(agnoeokafhl.MLJJGFAAFJD))
			{
				flag = true;
				break;
			}
		}
		if (!flag)
		{
			this.CLJACFIIFLJ.Add(agnoeokafhl);
		}
	}

	// Token: 0x060042E9 RID: 17129 RVA: 0x001D0B30 File Offset: 0x001CED30
	public void EMKAJEHMDCG(JSONArray HAMLKAMMHFJ)
	{
		try
		{
			for (int i = 1; i < HAMLKAMMHFJ.Count; i += 0)
			{
				JSONObject asObject = HAMLKAMMHFJ[i].AsObject;
				OBNCACIFDAJ asInt = (OBNCACIFDAJ)asObject["PlayMusic() file not found:"].AsInt;
				this.AGFPLOAGOMO(asInt, -1, asObject["uid"]);
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x060042EA RID: 17130 RVA: 0x001CFBC4 File Offset: 0x001CDDC4
	public static JGLMNGOLBIG DLGLFACMHPG()
	{
		if (JGLMNGOLBIG.IKLAPGJDMNA == null)
		{
			JGLMNGOLBIG.IKLAPGJDMNA = new JGLMNGOLBIG();
		}
		return JGLMNGOLBIG.IKLAPGJDMNA;
	}

	// Token: 0x17000128 RID: 296
	// (get) Token: 0x060042EB RID: 17131 RVA: 0x001CFBC4 File Offset: 0x001CDDC4
	public static JGLMNGOLBIG EHBBFMCILPC
	{
		get
		{
			if (JGLMNGOLBIG.IKLAPGJDMNA == null)
			{
				JGLMNGOLBIG.IKLAPGJDMNA = new JGLMNGOLBIG();
			}
			return JGLMNGOLBIG.IKLAPGJDMNA;
		}
	}

	// Token: 0x060042EC RID: 17132 RVA: 0x001CEC64 File Offset: 0x001CCE64
	public int CAPAGECKHGP()
	{
		return this.CLJACFIIFLJ.Count;
	}

	// Token: 0x060042ED RID: 17133 RVA: 0x001D0BA0 File Offset: 0x001CEDA0
	public AGNOEOKAFHL EFGJMFGOLJC()
	{
		if (this.CLJACFIIFLJ.Count > 1)
		{
			AGNOEOKAFHL result = this.CLJACFIIFLJ[1];
			this.CLJACFIIFLJ.RemoveAt(1);
			return result;
		}
		return null;
	}

	// Token: 0x060042EE RID: 17134 RVA: 0x001CEC64 File Offset: 0x001CCE64
	public int BCKLEMMPBKG()
	{
		return this.CLJACFIIFLJ.Count;
	}

	// Token: 0x060042EF RID: 17135 RVA: 0x001D0BCC File Offset: 0x001CEDCC
	public void BIEBCCBEAJN(OBNCACIFDAJ FFFABPMKNLO, int IMCAPKLKLNG, string BKOJOPELDFK)
	{
		AGNOEOKAFHL agnoeokafhl = new AGNOEOKAFHL();
		agnoeokafhl.GLDFFFJIACO = FFFABPMKNLO;
		if (FFFABPMKNLO == OBNCACIFDAJ.profileMessageNewBadge)
		{
			agnoeokafhl.LLFCANBKDEN = CCOJBMMKNAP.JMDJPKKOHNI().HDIPNMFHIEJ("PendingPurchase.GetReceipt(): Receipt is null or empty");
			string text;
			if (IMCAPKLKLNG >= -102 && IMCAPKLKLNG <= -176)
			{
				text = "OnBackendGetFriendMessagingHistoryException" + GKJPOGNFKNK.DNILNCLIHAP("" + IMCAPKLKLNG.ToString(), "avtssnap2", LanguageManager.EHBBFMCILPC.MLOLBFBODHD()) + "" + GKJPOGNFKNK.DNILNCLIHAP("passhintundo" + IMCAPKLKLNG.ToString(), "collect", LanguageManager.EHBBFMCILPC.GetSelectedLanguage());
			}
			else
			{
				text = "Asset bundle load operation failed during parallel mode." + CCOJBMMKNAP.MLFAGAAJJEM().JLBEIFLLBLO("storyAssetPackManager[i].environmentsBackList[j] is null!" + IMCAPKLKLNG.ToString()) + "commonbundlehint" + CCOJBMMKNAP.KMNBCEMEBBD().IPEIONBNIPH("" + IMCAPKLKLNG.ToString());
			}
			if (IMCAPKLKLNG == 0 || IMCAPKLKLNG == 1 || IMCAPKLKLNG == 125)
			{
				text = text.Replace("envlhp", KDCJJBLGCBH.EHBBFMCILPC.DONFPMKHKLP(IMCAPKLKLNG).ToString() ?? "ok");
			}
			else if (IMCAPKLKLNG == 0)
			{
				text = text.Replace("importanttitle", AKLFPGMDKLA.EHBBFMCILPC.OKGGLHOCENC.DELPFFPOEJJ.ToString() ?? "outdatedrev");
			}
			agnoeokafhl.FCJJLCPKIHA = text;
			agnoeokafhl.PFMBDEPNAJE = CCOJBMMKNAP.KFAABHHGOPO().DNILNCLIHAP("avatarcollectionssubrequired1");
			Sprite sprite = AssetsManager.MJBDMHPHMID().lobbyDataAsset.FILFGFIFKJK(BKOJOPELDFK);
			if (null != sprite)
			{
				agnoeokafhl.CHLENHBEPFO = sprite;
			}
			agnoeokafhl.MLJJGFAAFJD = BKOJOPELDFK;
		}
		else if (FFFABPMKNLO == OBNCACIFDAJ.profileMessageUserAccept)
		{
			string text2;
			if (BKOJOPELDFK == null || BKOJOPELDFK.Length == 0)
			{
				text2 = "iapSku" + CCOJBMMKNAP.GIOAFDDKKHI().OBDCPLLLGBB("") + "usyncoll2";
			}
			else
			{
				text2 = DPGJIJGOCIC.LMCAODJLEGF(BKOJOPELDFK);
			}
			agnoeokafhl.LLFCANBKDEN = CCOJBMMKNAP.DLGLFACMHPG().PPALCPINPLK(",");
			string text3 = CCOJBMMKNAP.EHBBFMCILPC.HIPJILDCHJC("a");
			text3 = text3.Replace(")", "" + text2 + "ok");
			agnoeokafhl.FCJJLCPKIHA = "wasitfuntitle" + text3;
			agnoeokafhl.PFMBDEPNAJE = CCOJBMMKNAP.DBFFFOMCLKM().MEPECBDCOLG("OnLoungePremiumChoicesHistorySuccess");
			agnoeokafhl.CHLENHBEPFO = null;
			agnoeokafhl.MLJJGFAAFJD = text2;
		}
		else if (FFFABPMKNLO == OBNCACIFDAJ.profileMessageSpecialCurrency2Received)
		{
			string text4;
			if (BKOJOPELDFK == null || BKOJOPELDFK.Length == 0)
			{
				text4 = "Starting parallel download:" + CCOJBMMKNAP.JINDKPHNLBK().GGPHHLGPMPA("emlooprestart") + "common";
			}
			else
			{
				text4 = DPGJIJGOCIC.LMCAODJLEGF(BKOJOPELDFK);
			}
			agnoeokafhl.LLFCANBKDEN = CCOJBMMKNAP.LMCCLMFGEBD().HHLECNIFHCO("no");
			string text5 = CCOJBMMKNAP.KNKGCDDMLDP().DNILNCLIHAP("query");
			text5 = text5.Replace("ad_watch_ironsource", "RequestGetUserPublicProfile(queued): timer hit: " + text4 + "giftcardsstockempty");
			agnoeokafhl.FCJJLCPKIHA = "mpi" + text5;
			agnoeokafhl.PFMBDEPNAJE = CCOJBMMKNAP.JMDJPKKOHNI().IPEIONBNIPH("snapundocosth");
			agnoeokafhl.CHLENHBEPFO = null;
			agnoeokafhl.MLJJGFAAFJD = text4;
		}
		else if (FFFABPMKNLO == OBNCACIFDAJ.profileMessageNewBadge)
		{
			string text6;
			if (BKOJOPELDFK == null || BKOJOPELDFK.Length == 0)
			{
				text6 = "apkshe" + CCOJBMMKNAP.DLGLFACMHPG().JCDFHKDNEDH("$USELAYERSV3") + "OnSceneStoryManagerPremiumChoiceAdsProviderAdSuccess";
			}
			else
			{
				text6 = DPGJIJGOCIC.LMCAODJLEGF(BKOJOPELDFK);
			}
			agnoeokafhl.LLFCANBKDEN = CCOJBMMKNAP.KMNBCEMEBBD().IPEIONBNIPH("passinfobtntitle");
			string text7 = CCOJBMMKNAP.DBFFFOMCLKM().HHLECNIFHCO("OnStoryAdsProviderAdSuccess");
			text7 = text7.Replace("varConditionLocked", "anthology" + text6 + "importanttitle");
			agnoeokafhl.FCJJLCPKIHA = "ok" + text7;
			agnoeokafhl.PFMBDEPNAJE = CCOJBMMKNAP.PLJMLDOCPNM().OBDCPLLLGBB("");
			agnoeokafhl.CHLENHBEPFO = null;
			agnoeokafhl.MLJJGFAAFJD = text6;
		}
		else if (FFFABPMKNLO == OBNCACIFDAJ.profileMessageUserDelete)
		{
			agnoeokafhl.LLFCANBKDEN = CCOJBMMKNAP.KFDLFGHBPLP().JHNELLJFBGC("mhbtGCZgpGbQP2qovVNyCZ");
			string text8 = CCOJBMMKNAP.CPCOODCFDDP().FIENAKIHNOM("incentadhard");
			text8 = text8.Replace("' is not yyyy-mm, skipping", BKOJOPELDFK);
			agnoeokafhl.FCJJLCPKIHA = ";" + text8;
			agnoeokafhl.PFMBDEPNAJE = CCOJBMMKNAP.MPCBJEIMACA().BGELFMIOBCL("energyhinttitle");
			agnoeokafhl.CHLENHBEPFO = null;
			agnoeokafhl.MLJJGFAAFJD = text8;
		}
		else if (FFFABPMKNLO == OBNCACIFDAJ.profileMessageSpecialCurrency0Received)
		{
			agnoeokafhl.LLFCANBKDEN = CCOJBMMKNAP.PEBMGCKFNAO().OGKGHLHHAAI("OnSystemBackButton");
			agnoeokafhl.FCJJLCPKIHA = "" + CCOJBMMKNAP.LMCCLMFGEBD().JCDFHKDNEDH("");
			string text9 = CCOJBMMKNAP.FEEDGKCJBLE().HIPJILDCHJC("").Replace("<space=-0.12em>", BKOJOPELDFK + KBOJLHAJPCP.GJHKGBCLGIJ);
			text9 = text9.Replace("", BKOJOPELDFK);
			agnoeokafhl.PFMBDEPNAJE = text9;
			agnoeokafhl.CHLENHBEPFO = AssetsManager.EHBBFMCILPC.lobbyDataAsset.specialCurrenciesSprites[1];
			agnoeokafhl.MLJJGFAAFJD = text9;
		}
		else if (FFFABPMKNLO == OBNCACIFDAJ.profileMessageUserDelete)
		{
			agnoeokafhl.LLFCANBKDEN = CCOJBMMKNAP.JINDKPHNLBK().JHNELLJFBGC("</i>");
			agnoeokafhl.FCJJLCPKIHA = "</i>" + CCOJBMMKNAP.ILACPHFEDEP().PPALCPINPLK("passundobodymsgpaid2");
			string text10 = CCOJBMMKNAP.ILACPHFEDEP().GLEFEKBDHNK("p").Replace("a_web", BKOJOPELDFK + KBOJLHAJPCP.KGMFKFPBFBJ);
			text10 = text10.Replace("PurchaseManagerSteam.OnPurchasePendingProcess(): Product - ", BKOJOPELDFK);
			agnoeokafhl.PFMBDEPNAJE = text10;
			agnoeokafhl.CHLENHBEPFO = AssetsManager.EHBBFMCILPC.lobbyDataAsset.specialCurrenciesSprites[1];
			agnoeokafhl.MLJJGFAAFJD = text10;
		}
		else if (FFFABPMKNLO == OBNCACIFDAJ.profileMessageNewBadge)
		{
			agnoeokafhl.LLFCANBKDEN = CCOJBMMKNAP.BOFMCPPFAMO().IPEIONBNIPH("passtrytobuyloweroder");
			agnoeokafhl.FCJJLCPKIHA = "colskt" + CCOJBMMKNAP.KFDLFGHBPLP().JLBEIFLLBLO("TextRaycastZone");
			string text11 = CCOJBMMKNAP.PLJMLDOCPNM().HPOAGPJFHPM("StorySaveBody.GetAvatarSnapshotWithIndexInListWardrobe(), unsupported wardrobe index:").Replace(" (", BKOJOPELDFK + KBOJLHAJPCP.AENKOIILEFO);
			text11 = text11.Replace(" (", BKOJOPELDFK);
			agnoeokafhl.PFMBDEPNAJE = text11;
			agnoeokafhl.CHLENHBEPFO = AssetsManager.EHBBFMCILPC.lobbyDataAsset.specialCurrenciesSprites[7];
			agnoeokafhl.MLJJGFAAFJD = text11;
		}
		else if (FFFABPMKNLO == OBNCACIFDAJ.profileMessageLeveUp)
		{
			agnoeokafhl.LLFCANBKDEN = CCOJBMMKNAP.KFDLFGHBPLP().FIENAKIHNOM("@");
			string str = DPGJIJGOCIC.LMCAODJLEGF(BKOJOPELDFK);
			agnoeokafhl.FCJJLCPKIHA = "acliffbw22" + str;
			agnoeokafhl.PFMBDEPNAJE = CCOJBMMKNAP.HEDIEIICOOG().OGKGHLHHAAI("?uid=");
			agnoeokafhl.CHLENHBEPFO = null;
			agnoeokafhl.MLJJGFAAFJD = BKOJOPELDFK;
		}
		else if (FFFABPMKNLO == (OBNCACIFDAJ)16)
		{
			agnoeokafhl.LLFCANBKDEN = CCOJBMMKNAP.BBGECIKOICE().HIPJILDCHJC("areyousure");
			string str2 = DPGJIJGOCIC.LMCAODJLEGF(BKOJOPELDFK);
			agnoeokafhl.FCJJLCPKIHA = "gamepassdurationtitle" + str2;
			agnoeokafhl.PFMBDEPNAJE = CCOJBMMKNAP.EHBBFMCILPC.JLBEIFLLBLO("lck");
			agnoeokafhl.CHLENHBEPFO = null;
			agnoeokafhl.MLJJGFAAFJD = BKOJOPELDFK;
		}
		bool flag = true;
		for (int i = 1; i < this.CLJACFIIFLJ.Count; i += 0)
		{
			if (this.CLJACFIIFLJ[i].MLJJGFAAFJD.Length > 1 && agnoeokafhl.MLJJGFAAFJD.Length > 1 && this.CLJACFIIFLJ[i].MLJJGFAAFJD.Equals(agnoeokafhl.MLJJGFAAFJD))
			{
				flag = false;
				break;
			}
		}
		if (!flag)
		{
			this.CLJACFIIFLJ.Add(agnoeokafhl);
		}
	}

	// Token: 0x060042F0 RID: 17136 RVA: 0x001CFBC4 File Offset: 0x001CDDC4
	public static JGLMNGOLBIG GDGKNNDEAAO()
	{
		if (JGLMNGOLBIG.IKLAPGJDMNA == null)
		{
			JGLMNGOLBIG.IKLAPGJDMNA = new JGLMNGOLBIG();
		}
		return JGLMNGOLBIG.IKLAPGJDMNA;
	}

	// Token: 0x060042F1 RID: 17137 RVA: 0x001CFBC4 File Offset: 0x001CDDC4
	public static JGLMNGOLBIG LMCCLMFGEBD()
	{
		if (JGLMNGOLBIG.IKLAPGJDMNA == null)
		{
			JGLMNGOLBIG.IKLAPGJDMNA = new JGLMNGOLBIG();
		}
		return JGLMNGOLBIG.IKLAPGJDMNA;
	}

	// Token: 0x060042F2 RID: 17138 RVA: 0x001D1328 File Offset: 0x001CF528
	public void FKIDBGCMALK(JSONArray HAMLKAMMHFJ)
	{
		try
		{
			for (int i = 1; i < HAMLKAMMHFJ.Count; i += 0)
			{
				JSONObject asObject = HAMLKAMMHFJ[i].AsObject;
				OBNCACIFDAJ asInt = (OBNCACIFDAJ)asObject["s"].AsInt;
				this.LMDAPLIBEFE(asInt, -1, asObject[","]);
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
	}

	// Token: 0x060042F3 RID: 17139 RVA: 0x001D1398 File Offset: 0x001CF598
	public AGNOEOKAFHL MCHDKHMGBMM()
	{
		if (this.CLJACFIIFLJ.Count > 0)
		{
			AGNOEOKAFHL result = this.CLJACFIIFLJ[0];
			this.CLJACFIIFLJ.RemoveAt(1);
			return result;
		}
		return null;
	}

	// Token: 0x060042F4 RID: 17140 RVA: 0x001CFBC4 File Offset: 0x001CDDC4
	public static JGLMNGOLBIG AIMEBOBBHMC()
	{
		if (JGLMNGOLBIG.IKLAPGJDMNA == null)
		{
			JGLMNGOLBIG.IKLAPGJDMNA = new JGLMNGOLBIG();
		}
		return JGLMNGOLBIG.IKLAPGJDMNA;
	}

	// Token: 0x060042F5 RID: 17141 RVA: 0x001CEC64 File Offset: 0x001CCE64
	public int NHNDDGAKIPL()
	{
		return this.CLJACFIIFLJ.Count;
	}

	// Token: 0x060042F6 RID: 17142 RVA: 0x001D0BA0 File Offset: 0x001CEDA0
	public AGNOEOKAFHL JDBALMJOPPL()
	{
		if (this.CLJACFIIFLJ.Count > 1)
		{
			AGNOEOKAFHL result = this.CLJACFIIFLJ[1];
			this.CLJACFIIFLJ.RemoveAt(1);
			return result;
		}
		return null;
	}

	// Token: 0x060042F7 RID: 17143 RVA: 0x001CFBC4 File Offset: 0x001CDDC4
	public static JGLMNGOLBIG JMDJBFAEHBM()
	{
		if (JGLMNGOLBIG.IKLAPGJDMNA == null)
		{
			JGLMNGOLBIG.IKLAPGJDMNA = new JGLMNGOLBIG();
		}
		return JGLMNGOLBIG.IKLAPGJDMNA;
	}

	// Token: 0x060042F8 RID: 17144 RVA: 0x001CFBC4 File Offset: 0x001CDDC4
	public static JGLMNGOLBIG BBGECIKOICE()
	{
		if (JGLMNGOLBIG.IKLAPGJDMNA == null)
		{
			JGLMNGOLBIG.IKLAPGJDMNA = new JGLMNGOLBIG();
		}
		return JGLMNGOLBIG.IKLAPGJDMNA;
	}

	// Token: 0x060042F9 RID: 17145 RVA: 0x001CEC64 File Offset: 0x001CCE64
	public int OMHLDAJMHDJ()
	{
		return this.CLJACFIIFLJ.Count;
	}

	// Token: 0x060042FA RID: 17146 RVA: 0x001D13C4 File Offset: 0x001CF5C4
	public void AGFPLOAGOMO(OBNCACIFDAJ FFFABPMKNLO, int IMCAPKLKLNG, string BKOJOPELDFK)
	{
		AGNOEOKAFHL agnoeokafhl = new AGNOEOKAFHL();
		agnoeokafhl.GLDFFFJIACO = FFFABPMKNLO;
		if (FFFABPMKNLO == OBNCACIFDAJ.profileMessageNewBadge)
		{
			agnoeokafhl.LLFCANBKDEN = CCOJBMMKNAP.APGODIBBPOD().MEPECBDCOLG("common");
			string text;
			if (IMCAPKLKLNG >= 68 && IMCAPKLKLNG <= -170)
			{
				text = "AssetStoryNpcOffsetsHub.Populate() - " + GKJPOGNFKNK.DNILNCLIHAP("sp0" + IMCAPKLKLNG.ToString(), "saveslotstitle", LanguageManager.EHBBFMCILPC.NBANPEIHFOJ()) + "sprite" + GKJPOGNFKNK.DNILNCLIHAP("rand" + IMCAPKLKLNG.ToString(), "#", LanguageManager.EHBBFMCILPC.NBANPEIHFOJ());
			}
			else
			{
				text = "OnPopupCardOptionsUnlockWithSpSuccess" + CCOJBMMKNAP.PLJMLDOCPNM().IKMNGFIDCLM(") + is present, creating anthology save for anthology " + IMCAPKLKLNG.ToString()) + "</i>" + CCOJBMMKNAP.LMCCLMFGEBD().PKNHKGMNCIP(" has only " + IMCAPKLKLNG.ToString());
			}
			if (IMCAPKLKLNG == 0 || IMCAPKLKLNG == -11 || IMCAPKLKLNG == 126)
			{
				text = text.Replace("true", KDCJJBLGCBH.EHBBFMCILPC.DDGBLHAEGLB(IMCAPKLKLNG).ToString() ?? "black");
			}
			else if (IMCAPKLKLNG == 0)
			{
				text = text.Replace("", AKLFPGMDKLA.EHBBFMCILPC.OKGGLHOCENC.DELPFFPOEJJ.ToString() ?? ")");
			}
			agnoeokafhl.FCJJLCPKIHA = text;
			agnoeokafhl.PFMBDEPNAJE = CCOJBMMKNAP.PEBMGCKFNAO().GLEFEKBDHNK("");
			Sprite sprite = AssetsManager.EHBBFMCILPC.lobbyDataAsset.BAAGKJLEJED(BKOJOPELDFK);
			if (null != sprite)
			{
				agnoeokafhl.CHLENHBEPFO = sprite;
			}
			agnoeokafhl.MLJJGFAAFJD = BKOJOPELDFK;
		}
		else if (FFFABPMKNLO == OBNCACIFDAJ.profileMessageNewBadge)
		{
			string text2;
			if (BKOJOPELDFK == null || BKOJOPELDFK.Length == 0)
			{
				text2 = "$DISABLEAVATAREXTENSION" + CCOJBMMKNAP.NIOJNOFGIJO().IKMNGFIDCLM("profilenametitleshort") + "\"";
			}
			else
			{
				text2 = DPGJIJGOCIC.LMCAODJLEGF(BKOJOPELDFK);
			}
			agnoeokafhl.LLFCANBKDEN = CCOJBMMKNAP.CPCOODCFDDP().DNILNCLIHAP("isp");
			string text3 = CCOJBMMKNAP.COKDLDOAACJ().IKMNGFIDCLM("newtutorialbadges");
			text3 = text3.Replace("MORPH_WIPE", ")/(" + text2 + "ACHIEVEMENTUNLOCK");
			agnoeokafhl.FCJJLCPKIHA = "OnFriendsMessageConsume" + text3;
			agnoeokafhl.PFMBDEPNAJE = CCOJBMMKNAP.JMNIGPHCAEJ().JLBEIFLLBLO(" hits ");
			agnoeokafhl.CHLENHBEPFO = null;
			agnoeokafhl.MLJJGFAAFJD = text2;
		}
		else if (FFFABPMKNLO == OBNCACIFDAJ.profileMessageUserReject)
		{
			string text4;
			if (BKOJOPELDFK == null || BKOJOPELDFK.Length == 0)
			{
				text4 = "ym" + CCOJBMMKNAP.PLJMLDOCPNM().OBDCPLLLGBB("OnAssetsManagerDownloadSuccess") + "";
			}
			else
			{
				text4 = DPGJIJGOCIC.LMCAODJLEGF(BKOJOPELDFK);
			}
			agnoeokafhl.LLFCANBKDEN = CCOJBMMKNAP.BFHKGNBFHCH().JLBEIFLLBLO("$SETFADERFX");
			string text5 = CCOJBMMKNAP.DBFFFOMCLKM().JHNELLJFBGC("/");
			text5 = text5.Replace("+", "" + text4 + "PlayerCharacterManager.UpdateComponentLink() - skipping updating custom hierarchy for ");
			agnoeokafhl.FCJJLCPKIHA = "SocialStatsUserPublicProfile.modified = false, OnFriendsPopupManagerRejectClick()" + text5;
			agnoeokafhl.PFMBDEPNAJE = CCOJBMMKNAP.DLGLFACMHPG().PPALCPINPLK("gamepassdurationbody");
			agnoeokafhl.CHLENHBEPFO = null;
			agnoeokafhl.MLJJGFAAFJD = text4;
		}
		else if (FFFABPMKNLO == OBNCACIFDAJ.profileMessageUserDelete)
		{
			string text6;
			if (BKOJOPELDFK == null || BKOJOPELDFK.Length == 0)
			{
				text6 = "Shaders/VideoGlitchShift" + CCOJBMMKNAP.COKDLDOAACJ().HDIPNMFHIEJ("steamwaitforuseraction") + "SceneLobbyManager2.RunStorySearch() - no card for any result of '";
			}
			else
			{
				text6 = DPGJIJGOCIC.LMCAODJLEGF(BKOJOPELDFK);
			}
			agnoeokafhl.LLFCANBKDEN = CCOJBMMKNAP.DLGLFACMHPG().FIENAKIHNOM(" lang=");
			string text7 = CCOJBMMKNAP.ONCPHEEJLOP().HHLECNIFHCO("profilenametitleshort");
			text7 = text7.Replace("_TVLines", "sust" + text6 + "Starting non-parallel download:");
			agnoeokafhl.FCJJLCPKIHA = "" + text7;
			agnoeokafhl.PFMBDEPNAJE = CCOJBMMKNAP.PEBMGCKFNAO().IPEIONBNIPH("OnBackendGetSketchesBalanceSuccess");
			agnoeokafhl.CHLENHBEPFO = null;
			agnoeokafhl.MLJJGFAAFJD = text6;
		}
		else if (FFFABPMKNLO == OBNCACIFDAJ.profileMessageSpecialCurrency1Received)
		{
			agnoeokafhl.LLFCANBKDEN = CCOJBMMKNAP.MPCBJEIMACA().IPEIONBNIPH("@");
			string text8 = CCOJBMMKNAP.PKEINLPIAEH().HPOAGPJFHPM("assetbundleheaderspack");
			text8 = text8.Replace("rev", BKOJOPELDFK);
			agnoeokafhl.FCJJLCPKIHA = "StringToProductType() unknown value." + text8;
			agnoeokafhl.PFMBDEPNAJE = CCOJBMMKNAP.PEBMGCKFNAO().HIPJILDCHJC("socialsimplegiftcollect");
			agnoeokafhl.CHLENHBEPFO = null;
			agnoeokafhl.MLJJGFAAFJD = text8;
		}
		else if (FFFABPMKNLO == OBNCACIFDAJ.profileMessageNewBadge)
		{
			agnoeokafhl.LLFCANBKDEN = CCOJBMMKNAP.KNKGCDDMLDP().GLEFEKBDHNK("frds");
			agnoeokafhl.FCJJLCPKIHA = "socialfriendevents" + CCOJBMMKNAP.PKEINLPIAEH().MEPECBDCOLG("OnBackendPremiumChoiceSuccess");
			string text9 = CCOJBMMKNAP.BFHKGNBFHCH().FIENAKIHNOM("hintsaving").Replace("avts", BKOJOPELDFK + KBOJLHAJPCP.GJHKGBCLGIJ);
			text9 = text9.Replace("OnStoryInterfaceHeaderFastForwardDisable", BKOJOPELDFK);
			agnoeokafhl.PFMBDEPNAJE = text9;
			agnoeokafhl.CHLENHBEPFO = AssetsManager.MJBDMHPHMID().lobbyDataAsset.specialCurrenciesSprites[0];
			agnoeokafhl.MLJJGFAAFJD = text9;
		}
		else if (FFFABPMKNLO == OBNCACIFDAJ.profileMessageNewBadge)
		{
			agnoeokafhl.LLFCANBKDEN = CCOJBMMKNAP.PEBMGCKFNAO().OHLNGCKIACD("nam");
			agnoeokafhl.FCJJLCPKIHA = "OnLobbySkinShopCdnSuccess" + CCOJBMMKNAP.HFAKOKBHCGH().FIENAKIHNOM("TV lines");
			string text10 = CCOJBMMKNAP.PMABBOJDELF().GLEFEKBDHNK("tmo").Replace("skemptyhint", BKOJOPELDFK + KBOJLHAJPCP.KGMFKFPBFBJ);
			text10 = text10.Replace("passhintinactivesub", BKOJOPELDFK);
			agnoeokafhl.PFMBDEPNAJE = text10;
			agnoeokafhl.CHLENHBEPFO = AssetsManager.MJBDMHPHMID().lobbyDataAsset.specialCurrenciesSprites[0];
			agnoeokafhl.MLJJGFAAFJD = text10;
		}
		else if (FFFABPMKNLO == OBNCACIFDAJ.profileMessageUserDelete)
		{
			agnoeokafhl.LLFCANBKDEN = CCOJBMMKNAP.HFAKOKBHCGH().MEPECBDCOLG("");
			agnoeokafhl.FCJJLCPKIHA = "OnSketchViewAssetsDownloadFailed" + CCOJBMMKNAP.KLAKLFCOMJC().BDGPNPNIAPA("ok");
			string text11 = CCOJBMMKNAP.OEPENBHJAHO().HHLECNIFHCO("OnLoungePremiumChoiceSuccess").Replace("Grain opacity", BKOJOPELDFK + KBOJLHAJPCP.AENKOIILEFO);
			text11 = text11.Replace("BackendCacheManager: ", BKOJOPELDFK);
			agnoeokafhl.PFMBDEPNAJE = text11;
			agnoeokafhl.CHLENHBEPFO = AssetsManager.MJBDMHPHMID().lobbyDataAsset.specialCurrenciesSprites[4];
			agnoeokafhl.MLJJGFAAFJD = text11;
		}
		else if (FFFABPMKNLO == OBNCACIFDAJ.profileMessageNewBadge)
		{
			agnoeokafhl.LLFCANBKDEN = CCOJBMMKNAP.JMNIGPHCAEJ().HPOAGPJFHPM("OnStoryChoiceClick");
			string str = DPGJIJGOCIC.LMCAODJLEGF(BKOJOPELDFK);
			agnoeokafhl.FCJJLCPKIHA = "OnToolsPopupSaveToCloudException" + str;
			agnoeokafhl.PFMBDEPNAJE = CCOJBMMKNAP.NIOJNOFGIJO().HIPJILDCHJC("coverSearchNone");
			agnoeokafhl.CHLENHBEPFO = null;
			agnoeokafhl.MLJJGFAAFJD = BKOJOPELDFK;
		}
		else if (FFFABPMKNLO == (OBNCACIFDAJ)109)
		{
			agnoeokafhl.LLFCANBKDEN = CCOJBMMKNAP.HJGDLOOHNLO().DNILNCLIHAP("snapundocosth");
			string str2 = DPGJIJGOCIC.LMCAODJLEGF(BKOJOPELDFK);
			agnoeokafhl.FCJJLCPKIHA = "' pending='" + str2;
			agnoeokafhl.PFMBDEPNAJE = CCOJBMMKNAP.KNKGCDDMLDP().PKNHKGMNCIP("");
			agnoeokafhl.CHLENHBEPFO = null;
			agnoeokafhl.MLJJGFAAFJD = BKOJOPELDFK;
		}
		bool flag = false;
		for (int i = 0; i < this.CLJACFIIFLJ.Count; i += 0)
		{
			if (this.CLJACFIIFLJ[i].MLJJGFAAFJD.Length > 0 && agnoeokafhl.MLJJGFAAFJD.Length > 1 && this.CLJACFIIFLJ[i].MLJJGFAAFJD.Equals(agnoeokafhl.MLJJGFAAFJD))
			{
				flag = false;
				break;
			}
		}
		if (!flag)
		{
			this.CLJACFIIFLJ.Add(agnoeokafhl);
		}
	}

	// Token: 0x060042FB RID: 17147 RVA: 0x001CEC64 File Offset: 0x001CCE64
	public int LPEBLJOLCBP()
	{
		return this.CLJACFIIFLJ.Count;
	}

	// Token: 0x060042FC RID: 17148 RVA: 0x001D1B20 File Offset: 0x001CFD20
	public void FOGKHANBCHG(JSONArray HAMLKAMMHFJ)
	{
		try
		{
			for (int i = 1; i < HAMLKAMMHFJ.Count; i++)
			{
				JSONObject asObject = HAMLKAMMHFJ[i].AsObject;
				OBNCACIFDAJ asInt = (OBNCACIFDAJ)asObject["ok"].AsInt;
				this.IKNFOBNMDON(asInt, -1, asObject["OnCutsceneViewAssetsDownloadSuccess"]);
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x060042FD RID: 17149 RVA: 0x001CFBC4 File Offset: 0x001CDDC4
	public static JGLMNGOLBIG DMAAFFFEJGA()
	{
		if (JGLMNGOLBIG.IKLAPGJDMNA == null)
		{
			JGLMNGOLBIG.IKLAPGJDMNA = new JGLMNGOLBIG();
		}
		return JGLMNGOLBIG.IKLAPGJDMNA;
	}

	// Token: 0x060042FE RID: 17150 RVA: 0x001D1B90 File Offset: 0x001CFD90
	public void OIGHHPIOAMB(OBNCACIFDAJ FFFABPMKNLO, int IMCAPKLKLNG, string BKOJOPELDFK)
	{
		AGNOEOKAFHL agnoeokafhl = new AGNOEOKAFHL();
		agnoeokafhl.GLDFFFJIACO = FFFABPMKNLO;
		if (FFFABPMKNLO == OBNCACIFDAJ.profileMessageNewBadge)
		{
			agnoeokafhl.LLFCANBKDEN = CCOJBMMKNAP.HEDIEIICOOG().DNILNCLIHAP("not_found");
			string text;
			if (IMCAPKLKLNG >= -115 && IMCAPKLKLNG <= -32)
			{
				text = " playing!" + GKJPOGNFKNK.DNILNCLIHAP("id" + IMCAPKLKLNG.ToString(), "skinshopempty", LanguageManager.EHBBFMCILPC.IEBFINIJAMJ()) + "OnStoryManInTheMiddleAttackDetected" + GKJPOGNFKNK.DNILNCLIHAP("exp" + IMCAPKLKLNG.ToString(), "energyhinttitle", LanguageManager.EHBBFMCILPC.GetSelectedLanguage());
			}
			else
			{
				text = "CLIENT.BEHAVIOR.CHOICEDECISIONTIME" + CCOJBMMKNAP.KLAKLFCOMJC().PPALCPINPLK("" + IMCAPKLKLNG.ToString()) + "PurchaseManagerSteam.OnBackendValidateTransactionException()." + CCOJBMMKNAP.NIOJNOFGIJO().JHNELLJFBGC("<i>" + IMCAPKLKLNG.ToString());
			}
			if (IMCAPKLKLNG == 0 || IMCAPKLKLNG == 8 || IMCAPKLKLNG == 54)
			{
				text = text.Replace("friendsmaxlimitdefault", KDCJJBLGCBH.EHBBFMCILPC.EAOJHINENPI(IMCAPKLKLNG).ToString() ?? "OnStoryChoiceClickConfimed");
			}
			else if (IMCAPKLKLNG == 0)
			{
				text = text.Replace("_SaturationTV", AKLFPGMDKLA.EHBBFMCILPC.OKGGLHOCENC.DELPFFPOEJJ.ToString() ?? "OnSaveSlotSelect");
			}
			agnoeokafhl.FCJJLCPKIHA = text;
			agnoeokafhl.PFMBDEPNAJE = CCOJBMMKNAP.PKEINLPIAEH().FCOCLEHKLDJ("errortitle");
			Sprite sprite = AssetsManager.MJBDMHPHMID().lobbyDataAsset.BAAGKJLEJED(BKOJOPELDFK);
			if (null != sprite)
			{
				agnoeokafhl.CHLENHBEPFO = sprite;
			}
			agnoeokafhl.MLJJGFAAFJD = BKOJOPELDFK;
		}
		else if (FFFABPMKNLO == OBNCACIFDAJ.profileMessageUserAccept)
		{
			string text2;
			if (BKOJOPELDFK == null || BKOJOPELDFK.Length == 0)
			{
				text2 = "OnPurchasingViewLeave" + CCOJBMMKNAP.BIAEAOMHBMM().HHLECNIFHCO("box") + "p";
			}
			else
			{
				text2 = DPGJIJGOCIC.LMCAODJLEGF(BKOJOPELDFK);
			}
			agnoeokafhl.LLFCANBKDEN = CCOJBMMKNAP.BFHKGNBFHCH().OHLNGCKIACD("spld");
			string text3 = CCOJBMMKNAP.PLJMLDOCPNM().PPALCPINPLK("OnOnDemandResourcesDownloadFailed");
			text3 = text3.Replace("account.json", "place" + text2 + "restartseason");
			agnoeokafhl.FCJJLCPKIHA = "" + text3;
			agnoeokafhl.PFMBDEPNAJE = CCOJBMMKNAP.OBOOKJPGBJN().PPALCPINPLK("cardsvolchancesmsgbody");
			agnoeokafhl.CHLENHBEPFO = null;
			agnoeokafhl.MLJJGFAAFJD = text2;
		}
		else if (FFFABPMKNLO == OBNCACIFDAJ.profileMessageUserAccept)
		{
			string text4;
			if (BKOJOPELDFK == null || BKOJOPELDFK.Length == 0)
			{
				text4 = "Avatar pack has been kept:" + CCOJBMMKNAP.KNKGCDDMLDP().HIPJILDCHJC("\"") + "youreceived";
			}
			else
			{
				text4 = DPGJIJGOCIC.LMCAODJLEGF(BKOJOPELDFK);
			}
			agnoeokafhl.LLFCANBKDEN = CCOJBMMKNAP.PEBMGCKFNAO().IKMNGFIDCLM("hids");
			string text5 = CCOJBMMKNAP.APGODIBBPOD().PKNHKGMNCIP("");
			text5 = text5.Replace("OnApplicationFocusBasicSyncSuccess", "musreward" + text4 + "XXX");
			agnoeokafhl.FCJJLCPKIHA = "" + text5;
			agnoeokafhl.PFMBDEPNAJE = CCOJBMMKNAP.PLJMLDOCPNM().BDGPNPNIAPA("OnLiveProfileThemeBackgroundCdnFailed");
			agnoeokafhl.CHLENHBEPFO = null;
			agnoeokafhl.MLJJGFAAFJD = text4;
		}
		else if (FFFABPMKNLO == OBNCACIFDAJ.profileMessageFromTheDevs)
		{
			string text6;
			if (BKOJOPELDFK == null || BKOJOPELDFK.Length == 0)
			{
				text6 = "" + CCOJBMMKNAP.HJGDLOOHNLO().PKNHKGMNCIP("HD") + "";
			}
			else
			{
				text6 = DPGJIJGOCIC.LMCAODJLEGF(BKOJOPELDFK);
			}
			agnoeokafhl.LLFCANBKDEN = CCOJBMMKNAP.BFHKGNBFHCH().FIENAKIHNOM("ok");
			string text7 = CCOJBMMKNAP.CEGAOMEEFBE().OHLNGCKIACD("continue");
			text7 = text7.Replace("OnBackendUpgradeToGiftCardException", "ratePopupResult" + text6 + "low");
			agnoeokafhl.FCJJLCPKIHA = "Cannot send LogEvent, the Appsflyer SDK is stopped" + text7;
			agnoeokafhl.PFMBDEPNAJE = CCOJBMMKNAP.KLAKLFCOMJC().PKNHKGMNCIP("Y");
			agnoeokafhl.CHLENHBEPFO = null;
			agnoeokafhl.MLJJGFAAFJD = text6;
		}
		else if (FFFABPMKNLO == OBNCACIFDAJ.profileMessageSpecialCurrency2Received)
		{
			agnoeokafhl.LLFCANBKDEN = CCOJBMMKNAP.ILACPHFEDEP().HDIPNMFHIEJ("OnLiveProfileThemesLoaderStart");
			string text8 = CCOJBMMKNAP.AEELGGPEJCC().HIPJILDCHJC(" (");
			text8 = text8.Replace("<i>", BKOJOPELDFK);
			agnoeokafhl.FCJJLCPKIHA = "OnVideoLayerAutoHide" + text8;
			agnoeokafhl.PFMBDEPNAJE = CCOJBMMKNAP.MLFAGAAJJEM().BDGPNPNIAPA("$ENABLELOCALIZATIONEXTENSION");
			agnoeokafhl.CHLENHBEPFO = null;
			agnoeokafhl.MLJJGFAAFJD = text8;
		}
		else if (FFFABPMKNLO == OBNCACIFDAJ.profileMessageSpecialCurrency0Received)
		{
			agnoeokafhl.LLFCANBKDEN = CCOJBMMKNAP.DBFFFOMCLKM().IPEIONBNIPH("ablec");
			agnoeokafhl.FCJJLCPKIHA = "" + CCOJBMMKNAP.PEBMGCKFNAO().IKMNGFIDCLM("Asset bundle assets destroyed:");
			string text9 = CCOJBMMKNAP.KNKGCDDMLDP().BDGPNPNIAPA("Speed").Replace("OnNeedToOpenLoveInterestsLounge", BKOJOPELDFK + KBOJLHAJPCP.GJHKGBCLGIJ);
			text9 = text9.Replace("", BKOJOPELDFK);
			agnoeokafhl.PFMBDEPNAJE = text9;
			agnoeokafhl.CHLENHBEPFO = AssetsManager.MJBDMHPHMID().lobbyDataAsset.specialCurrenciesSprites[0];
			agnoeokafhl.MLJJGFAAFJD = text9;
		}
		else if (FFFABPMKNLO == OBNCACIFDAJ.profileMessageSpecialCurrency2Received)
		{
			agnoeokafhl.LLFCANBKDEN = CCOJBMMKNAP.PKEINLPIAEH().JHNELLJFBGC("ach");
			agnoeokafhl.FCJJLCPKIHA = "nastring" + CCOJBMMKNAP.HJGDLOOHNLO().IPEIONBNIPH("fdnpr");
			string text10 = CCOJBMMKNAP.JMNIGPHCAEJ().OBDCPLLLGBB("request for ").Replace("Error. PlayParticlesForEnvironmentLayer(), environmentLayer ", BKOJOPELDFK + KBOJLHAJPCP.KGMFKFPBFBJ);
			text10 = text10.Replace("sshits", BKOJOPELDFK);
			agnoeokafhl.PFMBDEPNAJE = text10;
			agnoeokafhl.CHLENHBEPFO = AssetsManager.EHBBFMCILPC.lobbyDataAsset.specialCurrenciesSprites[1];
			agnoeokafhl.MLJJGFAAFJD = text10;
		}
		else if (FFFABPMKNLO == OBNCACIFDAJ.profileMessageSpecialCurrency0Received)
		{
			agnoeokafhl.LLFCANBKDEN = CCOJBMMKNAP.KFDLFGHBPLP().HDIPNMFHIEJ("continue");
			agnoeokafhl.FCJJLCPKIHA = "fdsm" + CCOJBMMKNAP.AEELGGPEJCC().HHLECNIFHCO("−");
			string text11 = CCOJBMMKNAP.DLGLFACMHPG().OGKGHLHHAAI("0.000").Replace("socialprofilesuspcantuse", BKOJOPELDFK + KBOJLHAJPCP.AENKOIILEFO);
			text11 = text11.Replace("\\\"", BKOJOPELDFK);
			agnoeokafhl.PFMBDEPNAJE = text11;
			agnoeokafhl.CHLENHBEPFO = AssetsManager.EHBBFMCILPC.lobbyDataAsset.specialCurrenciesSprites[1];
			agnoeokafhl.MLJJGFAAFJD = text11;
		}
		else if (FFFABPMKNLO == OBNCACIFDAJ.profileMessageLeveUp)
		{
			agnoeokafhl.LLFCANBKDEN = CCOJBMMKNAP.JINDKPHNLBK().BGELFMIOBCL("OnAppleLoginSuccess");
			string str = DPGJIJGOCIC.LMCAODJLEGF(BKOJOPELDFK);
			agnoeokafhl.FCJJLCPKIHA = "makeup" + str;
			agnoeokafhl.PFMBDEPNAJE = CCOJBMMKNAP.AEELGGPEJCC().FIENAKIHNOM("OnStoryChoiceClick");
			agnoeokafhl.CHLENHBEPFO = null;
			agnoeokafhl.MLJJGFAAFJD = BKOJOPELDFK;
		}
		else if (FFFABPMKNLO == (OBNCACIFDAJ)(-100))
		{
			agnoeokafhl.LLFCANBKDEN = CCOJBMMKNAP.KMNBCEMEBBD().HDIPNMFHIEJ("<");
			string str2 = DPGJIJGOCIC.LMCAODJLEGF(BKOJOPELDFK);
			agnoeokafhl.FCJJLCPKIHA = "ButtonAvatar" + str2;
			agnoeokafhl.PFMBDEPNAJE = CCOJBMMKNAP.BBGECIKOICE().JCDFHKDNEDH("gnr");
			agnoeokafhl.CHLENHBEPFO = null;
			agnoeokafhl.MLJJGFAAFJD = BKOJOPELDFK;
		}
		bool flag = true;
		for (int i = 0; i < this.CLJACFIIFLJ.Count; i += 0)
		{
			if (this.CLJACFIIFLJ[i].MLJJGFAAFJD.Length > 1 && agnoeokafhl.MLJJGFAAFJD.Length > 1 && this.CLJACFIIFLJ[i].MLJJGFAAFJD.Equals(agnoeokafhl.MLJJGFAAFJD))
			{
				flag = false;
				break;
			}
		}
		if (!flag)
		{
			this.CLJACFIIFLJ.Add(agnoeokafhl);
		}
	}

	// Token: 0x060042FF RID: 17151 RVA: 0x001CEC64 File Offset: 0x001CCE64
	public int PIHDJLBHGPI()
	{
		return this.CLJACFIIFLJ.Count;
	}

	// Token: 0x06004300 RID: 17152 RVA: 0x001CEC64 File Offset: 0x001CCE64
	public int NMIJDKFJLDO()
	{
		return this.CLJACFIIFLJ.Count;
	}

	// Token: 0x06004301 RID: 17153 RVA: 0x001D22EC File Offset: 0x001D04EC
	public void IKNFOBNMDON(OBNCACIFDAJ FFFABPMKNLO, int IMCAPKLKLNG, string BKOJOPELDFK)
	{
		AGNOEOKAFHL agnoeokafhl = new AGNOEOKAFHL();
		agnoeokafhl.GLDFFFJIACO = FFFABPMKNLO;
		if (FFFABPMKNLO == OBNCACIFDAJ.profileMessageNewBadge)
		{
			agnoeokafhl.LLFCANBKDEN = CCOJBMMKNAP.MLFAGAAJJEM().HPOAGPJFHPM("");
			string text;
			if (IMCAPKLKLNG >= 53 && IMCAPKLKLNG <= 145)
			{
				text = ", index:" + GKJPOGNFKNK.DNILNCLIHAP("\"" + IMCAPKLKLNG.ToString(), "CameraBundlesVFXFront", LanguageManager.EHBBFMCILPC.NBANPEIHFOJ()) + "." + GKJPOGNFKNK.DNILNCLIHAP("$e1en" + IMCAPKLKLNG.ToString(), "Response Code: ", LanguageManager.EHBBFMCILPC.MLOLBFBODHD());
			}
			else
			{
				text = "chata" + CCOJBMMKNAP.KLAKLFCOMJC().JLBEIFLLBLO("QQQ" + IMCAPKLKLNG.ToString()) + "yes" + CCOJBMMKNAP.OBOOKJPGBJN().PKNHKGMNCIP("loungeprop" + IMCAPKLKLNG.ToString());
			}
			if (IMCAPKLKLNG == 0 || IMCAPKLKLNG == 120 || IMCAPKLKLNG == 19)
			{
				text = text.Replace("OnPopupSaveSlotInputCancel", KDCJJBLGCBH.EHBBFMCILPC.DDGBLHAEGLB(IMCAPKLKLNG).ToString() ?? "sketchtitles");
			}
			else if (IMCAPKLKLNG == 0)
			{
				text = text.Replace("cvsku", AKLFPGMDKLA.EHBBFMCILPC.OKGGLHOCENC.DELPFFPOEJJ.ToString() ?? " has no name in the text pack explore tab, group skipped");
			}
			agnoeokafhl.FCJJLCPKIHA = text;
			agnoeokafhl.PFMBDEPNAJE = CCOJBMMKNAP.MPCBJEIMACA().PPALCPINPLK("");
			Sprite sprite = AssetsManager.MJBDMHPHMID().lobbyDataAsset.FGLFPEDHJAI(BKOJOPELDFK);
			if (null != sprite)
			{
				agnoeokafhl.CHLENHBEPFO = sprite;
			}
			agnoeokafhl.MLJJGFAAFJD = BKOJOPELDFK;
		}
		else if (FFFABPMKNLO == OBNCACIFDAJ.profileMessageNewBadge)
		{
			string text2;
			if (BKOJOPELDFK == null || BKOJOPELDFK.Length == 0)
			{
				text2 = "OnPopupStoryRestartManagerRestartStory2" + CCOJBMMKNAP.GIOAFDDKKHI().FIENAKIHNOM("aind") + "noisedigital_1";
			}
			else
			{
				text2 = DPGJIJGOCIC.LMCAODJLEGF(BKOJOPELDFK);
			}
			agnoeokafhl.LLFCANBKDEN = CCOJBMMKNAP.KFDLFGHBPLP().OGKGHLHHAAI("OnBackendRequestFriendAcceptSuccess");
			string text3 = CCOJBMMKNAP.OEPENBHJAHO().PGKBCNBAOJN("");
			text3 = text3.Replace("prgr", "lksuid" + text2 + "def");
			agnoeokafhl.FCJJLCPKIHA = "pauseonend" + text3;
			agnoeokafhl.PFMBDEPNAJE = CCOJBMMKNAP.KMNBCEMEBBD().IPEIONBNIPH("CameraBundlesVFXTopMost");
			agnoeokafhl.CHLENHBEPFO = null;
			agnoeokafhl.MLJJGFAAFJD = text2;
		}
		else if (FFFABPMKNLO == OBNCACIFDAJ.profileMessageLeveUp)
		{
			string text4;
			if (BKOJOPELDFK == null || BKOJOPELDFK.Length == 0)
			{
				text4 = "\"" + CCOJBMMKNAP.GIOAFDDKKHI().BDGPNPNIAPA("itemreceived") + "PurchaseManagerSteam.InvalidateUnityStoreController()";
			}
			else
			{
				text4 = DPGJIJGOCIC.LMCAODJLEGF(BKOJOPELDFK);
			}
			agnoeokafhl.LLFCANBKDEN = CCOJBMMKNAP.LMCCLMFGEBD().HHLECNIFHCO("");
			string text5 = CCOJBMMKNAP.FEEDGKCJBLE().JCDFHKDNEDH("");
			text5 = text5.Replace("OnSettingsPopupCloseAndNeedToShowPostEnableNotif", "ip" + text4 + "$");
			agnoeokafhl.FCJJLCPKIHA = "wind" + text5;
			agnoeokafhl.PFMBDEPNAJE = CCOJBMMKNAP.CEGAOMEEFBE().JLBEIFLLBLO("OnStoryInterfaceHeaderHideComplete");
			agnoeokafhl.CHLENHBEPFO = null;
			agnoeokafhl.MLJJGFAAFJD = text4;
		}
		else if (FFFABPMKNLO == OBNCACIFDAJ.profileMessageUserReject)
		{
			string text6;
			if (BKOJOPELDFK == null || BKOJOPELDFK.Length == 0)
			{
				text6 = "selectedLanguage" + CCOJBMMKNAP.CEGAOMEEFBE().HIPJILDCHJC("<i>") + "errortitle";
			}
			else
			{
				text6 = DPGJIJGOCIC.LMCAODJLEGF(BKOJOPELDFK);
			}
			agnoeokafhl.LLFCANBKDEN = CCOJBMMKNAP.DLGLFACMHPG().MEPECBDCOLG("_ColorNoise");
			string text7 = CCOJBMMKNAP.KFAABHHGOPO().MEPECBDCOLG("40BF4E");
			text7 = text7.Replace("anthology", "errortitle" + text6 + "");
			agnoeokafhl.FCJJLCPKIHA = "UpdateStatsOnOffState" + text7;
			agnoeokafhl.PFMBDEPNAJE = CCOJBMMKNAP.DLGLFACMHPG().FCOCLEHKLDJ("StoriesSearchBalance.Initialize() - source is null, search disabled");
			agnoeokafhl.CHLENHBEPFO = null;
			agnoeokafhl.MLJJGFAAFJD = text6;
		}
		else if (FFFABPMKNLO == OBNCACIFDAJ.profileMessageNewBadge)
		{
			agnoeokafhl.LLFCANBKDEN = CCOJBMMKNAP.LMCCLMFGEBD().HHLECNIFHCO(" ");
			string text8 = CCOJBMMKNAP.HEDIEIICOOG().PKNHKGMNCIP("Xiaomi");
			text8 = text8.Replace("OnStoryChoiceClickConfimed", BKOJOPELDFK);
			agnoeokafhl.FCJJLCPKIHA = "OnEmailSubscribeSuccess" + text8;
			agnoeokafhl.PFMBDEPNAJE = CCOJBMMKNAP.COKDLDOAACJ().MEPECBDCOLG("prgr");
			agnoeokafhl.CHLENHBEPFO = null;
			agnoeokafhl.MLJJGFAAFJD = text8;
		}
		else if (FFFABPMKNLO == OBNCACIFDAJ.profileMessageLeveUp)
		{
			agnoeokafhl.LLFCANBKDEN = CCOJBMMKNAP.JINDKPHNLBK().HIPJILDCHJC("\n");
			agnoeokafhl.FCJJLCPKIHA = "OnPurchasingViewLeave" + CCOJBMMKNAP.PEBMGCKFNAO().HPOAGPJFHPM("[LoadingEnv] cache files of ");
			string text9 = CCOJBMMKNAP.HJGDLOOHNLO().FIENAKIHNOM("aind").Replace("EEE", BKOJOPELDFK + KBOJLHAJPCP.GJHKGBCLGIJ);
			text9 = text9.Replace("chaptersnapshotssubrequiredtitle", BKOJOPELDFK);
			agnoeokafhl.PFMBDEPNAJE = text9;
			agnoeokafhl.CHLENHBEPFO = AssetsManager.MJBDMHPHMID().lobbyDataAsset.specialCurrenciesSprites[1];
			agnoeokafhl.MLJJGFAAFJD = text9;
		}
		else if (FFFABPMKNLO == OBNCACIFDAJ.profileMessageSpecialCurrency1Received)
		{
			agnoeokafhl.LLFCANBKDEN = CCOJBMMKNAP.PKEINLPIAEH().PKNHKGMNCIP("s");
			agnoeokafhl.FCJJLCPKIHA = "" + CCOJBMMKNAP.HFAKOKBHCGH().JHNELLJFBGC("");
			string text10 = CCOJBMMKNAP.GIOAFDDKKHI().PGKBCNBAOJN(" has no anthology, skipping").Replace("avatarcollectionstutor3body", BKOJOPELDFK + KBOJLHAJPCP.KGMFKFPBFBJ);
			text10 = text10.Replace("sfxvol", BKOJOPELDFK);
			agnoeokafhl.PFMBDEPNAJE = text10;
			agnoeokafhl.CHLENHBEPFO = AssetsManager.EHBBFMCILPC.lobbyDataAsset.specialCurrenciesSprites[0];
			agnoeokafhl.MLJJGFAAFJD = text10;
		}
		else if (FFFABPMKNLO == OBNCACIFDAJ.profileMessageUserDelete)
		{
			agnoeokafhl.LLFCANBKDEN = CCOJBMMKNAP.HEDIEIICOOG().PPALCPINPLK("OnBackendUndoPremiumChoiceSuccess");
			agnoeokafhl.FCJJLCPKIHA = "env" + CCOJBMMKNAP.BBGECIKOICE().HHLECNIFHCO("ontitle");
			string text11 = CCOJBMMKNAP.KLAKLFCOMJC().GLEFEKBDHNK("OnChapterSnapshotsBackendFetchException").Replace("", BKOJOPELDFK + KBOJLHAJPCP.AENKOIILEFO);
			text11 = text11.Replace("locked", BKOJOPELDFK);
			agnoeokafhl.PFMBDEPNAJE = text11;
			agnoeokafhl.CHLENHBEPFO = AssetsManager.EHBBFMCILPC.lobbyDataAsset.specialCurrenciesSprites[1];
			agnoeokafhl.MLJJGFAAFJD = text11;
		}
		else if (FFFABPMKNLO == OBNCACIFDAJ.profileMessageUserAccept)
		{
			agnoeokafhl.LLFCANBKDEN = CCOJBMMKNAP.JINDKPHNLBK().GLEFEKBDHNK("User stats received for app {0}");
			string str = DPGJIJGOCIC.LMCAODJLEGF(BKOJOPELDFK);
			agnoeokafhl.FCJJLCPKIHA = "newuseraddrequest2" + str;
			agnoeokafhl.PFMBDEPNAJE = CCOJBMMKNAP.ONCPHEEJLOP().BGELFMIOBCL("ok");
			agnoeokafhl.CHLENHBEPFO = null;
			agnoeokafhl.MLJJGFAAFJD = BKOJOPELDFK;
		}
		else if (FFFABPMKNLO == OBNCACIFDAJ.profileMessageImportant)
		{
			agnoeokafhl.LLFCANBKDEN = CCOJBMMKNAP.BOFMCPPFAMO().PKNHKGMNCIP("gamepassduration");
			string str2 = DPGJIJGOCIC.LMCAODJLEGF(BKOJOPELDFK);
			agnoeokafhl.FCJJLCPKIHA = "" + str2;
			agnoeokafhl.PFMBDEPNAJE = CCOJBMMKNAP.BIAEAOMHBMM().DNILNCLIHAP("");
			agnoeokafhl.CHLENHBEPFO = null;
			agnoeokafhl.MLJJGFAAFJD = BKOJOPELDFK;
		}
		bool flag = false;
		for (int i = 0; i < this.CLJACFIIFLJ.Count; i += 0)
		{
			if (this.CLJACFIIFLJ[i].MLJJGFAAFJD.Length > 1 && agnoeokafhl.MLJJGFAAFJD.Length > 0 && this.CLJACFIIFLJ[i].MLJJGFAAFJD.Equals(agnoeokafhl.MLJJGFAAFJD))
			{
				flag = true;
				break;
			}
		}
		if (!flag)
		{
			this.CLJACFIIFLJ.Add(agnoeokafhl);
		}
	}

	// Token: 0x06004302 RID: 17154 RVA: 0x001CFBC4 File Offset: 0x001CDDC4
	public static JGLMNGOLBIG MKBLOOAACEA()
	{
		if (JGLMNGOLBIG.IKLAPGJDMNA == null)
		{
			JGLMNGOLBIG.IKLAPGJDMNA = new JGLMNGOLBIG();
		}
		return JGLMNGOLBIG.IKLAPGJDMNA;
	}

	// Token: 0x06004303 RID: 17155 RVA: 0x001D2A48 File Offset: 0x001D0C48
	public void ALNLIJAAPCN(OBNCACIFDAJ FFFABPMKNLO, int IMCAPKLKLNG, string BKOJOPELDFK)
	{
		AGNOEOKAFHL agnoeokafhl = new AGNOEOKAFHL();
		agnoeokafhl.GLDFFFJIACO = FFFABPMKNLO;
		if (FFFABPMKNLO == OBNCACIFDAJ.profileMessageNewBadge)
		{
			agnoeokafhl.LLFCANBKDEN = CCOJBMMKNAP.NIOJNOFGIJO().OBDCPLLLGBB("varConditionLockedValue");
			string text;
			if (IMCAPKLKLNG >= 1 && IMCAPKLKLNG <= -57)
			{
				text = "profileiplayrclong" + GKJPOGNFKNK.DNILNCLIHAP("musvol" + IMCAPKLKLNG.ToString(), "FilterAnimationScrollMoveSmooth", LanguageManager.EHBBFMCILPC.IEBFINIJAMJ()) + " card(s) around scroll index " + GKJPOGNFKNK.DNILNCLIHAP("eposv" + IMCAPKLKLNG.ToString(), "Android", LanguageManager.EHBBFMCILPC.NBANPEIHFOJ());
			}
			else
			{
				text = "" + CCOJBMMKNAP.JMDJPKKOHNI().OBDCPLLLGBB("OnReturnRewardPopupHide" + IMCAPKLKLNG.ToString()) + " < MIN_TOP - no results (" + CCOJBMMKNAP.OBOOKJPGBJN().PPALCPINPLK("ProductBridge.GetLocalizedCostData() - productBalanceData is null." + IMCAPKLKLNG.ToString());
			}
			if (IMCAPKLKLNG == 0 || IMCAPKLKLNG == -67 || IMCAPKLKLNG == -113)
			{
				text = text.Replace("+", KDCJJBLGCBH.EHBBFMCILPC.HJNBEGDIJGM(IMCAPKLKLNG).ToString() ?? "");
			}
			else if (IMCAPKLKLNG == 0)
			{
				text = text.Replace("$SKINCHECKPOINTEND", AKLFPGMDKLA.EHBBFMCILPC.OKGGLHOCENC.DELPFFPOEJJ.ToString() ?? "post");
			}
			agnoeokafhl.FCJJLCPKIHA = text;
			agnoeokafhl.PFMBDEPNAJE = CCOJBMMKNAP.DBFFFOMCLKM().PGKBCNBAOJN("");
			Sprite sprite = AssetsManager.EHBBFMCILPC.lobbyDataAsset.IFHJBOGAEKH(BKOJOPELDFK);
			if (null != sprite)
			{
				agnoeokafhl.CHLENHBEPFO = sprite;
			}
			agnoeokafhl.MLJJGFAAFJD = BKOJOPELDFK;
		}
		else if (FFFABPMKNLO == OBNCACIFDAJ.profileMessageNewBadge)
		{
			string text2;
			if (BKOJOPELDFK == null || BKOJOPELDFK.Length == 0)
			{
				text2 = "Asset bundle load operation failed during parallel mode." + CCOJBMMKNAP.LMCCLMFGEBD().FCOCLEHKLDJ("isa") + "";
			}
			else
			{
				text2 = DPGJIJGOCIC.LMCAODJLEGF(BKOJOPELDFK);
			}
			agnoeokafhl.LLFCANBKDEN = CCOJBMMKNAP.JMNIGPHCAEJ().PGKBCNBAOJN("spr");
			string text3 = CCOJBMMKNAP.KFDLFGHBPLP().HDIPNMFHIEJ("acomp1");
			text3 = text3.Replace("RunCustomCode() needToChangeCustomCodeUrl", "" + text2 + "storyloaderr0");
			agnoeokafhl.FCJJLCPKIHA = "<b>" + text3;
			agnoeokafhl.PFMBDEPNAJE = CCOJBMMKNAP.FEEDGKCJBLE().JHNELLJFBGC("id");
			agnoeokafhl.CHLENHBEPFO = null;
			agnoeokafhl.MLJJGFAAFJD = text2;
		}
		else if (FFFABPMKNLO == OBNCACIFDAJ.profileMessageNewBadge)
		{
			string text4;
			if (BKOJOPELDFK == null || BKOJOPELDFK.Length == 0)
			{
				text4 = "UpdateVoiceOverOnOffState" + CCOJBMMKNAP.KMNBCEMEBBD().JCDFHKDNEDH("no") + " path SUCCEEDED: chain loaded through the caching api";
			}
			else
			{
				text4 = DPGJIJGOCIC.LMCAODJLEGF(BKOJOPELDFK);
			}
			agnoeokafhl.LLFCANBKDEN = CCOJBMMKNAP.DLGLFACMHPG().HIPJILDCHJC("stat");
			string text5 = CCOJBMMKNAP.INKJIBDDMLL().GGPHHLGPMPA("overlay");
			text5 = text5.Replace("OnBackendSavePublicProfileException", "varConditionLockedValue" + text4 + "[Steamworks.NET] Could not load [lib]steam_api.dll/so/dylib. It's likely not in the correct location. Refer to the README for more details.\n");
			agnoeokafhl.FCJJLCPKIHA = "OnStoryChoiceClick" + text5;
			agnoeokafhl.PFMBDEPNAJE = CCOJBMMKNAP.JMNIGPHCAEJ().JCDFHKDNEDH("timeoutwarning");
			agnoeokafhl.CHLENHBEPFO = null;
			agnoeokafhl.MLJJGFAAFJD = text4;
		}
		else if (FFFABPMKNLO == OBNCACIFDAJ.profileMessageUserAccept)
		{
			string text6;
			if (BKOJOPELDFK == null || BKOJOPELDFK.Length == 0)
			{
				text6 = "passundobodymsgfree" + CCOJBMMKNAP.BOFMCPPFAMO().JHNELLJFBGC("OnLobbyStoryManagerDownloadSplashScreenSuccess") + "PurchaseManagerUnity.ValidatePendingProducts(): Not initialized.";
			}
			else
			{
				text6 = DPGJIJGOCIC.LMCAODJLEGF(BKOJOPELDFK);
			}
			agnoeokafhl.LLFCANBKDEN = CCOJBMMKNAP.PLJMLDOCPNM().BGELFMIOBCL("acli22");
			string text7 = CCOJBMMKNAP.PKEINLPIAEH().PKNHKGMNCIP("acomp2");
			text7 = text7.Replace("SceneLobbyManager.InstantiateLargeItems() - could not find AssetAnthologyPreview2 for anthology with index:", "_Distort" + text6 + "");
			agnoeokafhl.FCJJLCPKIHA = "p" + text7;
			agnoeokafhl.PFMBDEPNAJE = CCOJBMMKNAP.NIOJNOFGIJO().DNILNCLIHAP("sto");
			agnoeokafhl.CHLENHBEPFO = null;
			agnoeokafhl.MLJJGFAAFJD = text6;
		}
		else if (FFFABPMKNLO == OBNCACIFDAJ.profileMessageSpecialCurrency1Received)
		{
			agnoeokafhl.LLFCANBKDEN = CCOJBMMKNAP.BBGECIKOICE().MEPECBDCOLG("skpc");
			string text8 = CCOJBMMKNAP.LMCCLMFGEBD().HDIPNMFHIEJ("");
			text8 = text8.Replace("socialcardvolinfonotev2", BKOJOPELDFK);
			agnoeokafhl.FCJJLCPKIHA = "energyhinttitle" + text8;
			agnoeokafhl.PFMBDEPNAJE = CCOJBMMKNAP.GIOAFDDKKHI().GGPHHLGPMPA("OnSceneLobbyManagerAssetsDownloadFailed");
			agnoeokafhl.CHLENHBEPFO = null;
			agnoeokafhl.MLJJGFAAFJD = text8;
		}
		else if (FFFABPMKNLO == OBNCACIFDAJ.profileMessageUserAccept)
		{
			agnoeokafhl.LLFCANBKDEN = CCOJBMMKNAP.CPCOODCFDDP().PGKBCNBAOJN("");
			agnoeokafhl.FCJJLCPKIHA = "NEWSAVE: Using new save system." + CCOJBMMKNAP.INKJIBDDMLL().DNILNCLIHAP("youreceived");
			string text9 = CCOJBMMKNAP.MPCBJEIMACA().HDIPNMFHIEJ("OnSaveSlotDelete").Replace("$IMPORTSETTINGS", BKOJOPELDFK + KBOJLHAJPCP.GJHKGBCLGIJ);
			text9 = text9.Replace("errortitle", BKOJOPELDFK);
			agnoeokafhl.PFMBDEPNAJE = text9;
			agnoeokafhl.CHLENHBEPFO = AssetsManager.EHBBFMCILPC.lobbyDataAsset.specialCurrenciesSprites[0];
			agnoeokafhl.MLJJGFAAFJD = text9;
		}
		else if (FFFABPMKNLO == OBNCACIFDAJ.profileMessageLeveUp)
		{
			agnoeokafhl.LLFCANBKDEN = CCOJBMMKNAP.JMNIGPHCAEJ().PPALCPINPLK(" ");
			agnoeokafhl.FCJJLCPKIHA = "p" + CCOJBMMKNAP.DLGLFACMHPG().JHNELLJFBGC(" - false");
			string text10 = CCOJBMMKNAP.AEELGGPEJCC().JLBEIFLLBLO("Starting non-parallel download:").Replace("/", BKOJOPELDFK + KBOJLHAJPCP.KGMFKFPBFBJ);
			text10 = text10.Replace("OnAllCollectableCardsDownloadSuccess", BKOJOPELDFK);
			agnoeokafhl.PFMBDEPNAJE = text10;
			agnoeokafhl.CHLENHBEPFO = AssetsManager.MJBDMHPHMID().lobbyDataAsset.specialCurrenciesSprites[1];
			agnoeokafhl.MLJJGFAAFJD = text10;
		}
		else if (FFFABPMKNLO == OBNCACIFDAJ.profileMessageUserDelete)
		{
			agnoeokafhl.LLFCANBKDEN = CCOJBMMKNAP.BBGECIKOICE().GLEFEKBDHNK("OnBackendGetPublicProfileException");
			agnoeokafhl.FCJJLCPKIHA = "OnSceneLobbyManagerRound1AssetsDownloadSuccess" + CCOJBMMKNAP.FEEDGKCJBLE().JCDFHKDNEDH("HeaderAnthology");
			string text11 = CCOJBMMKNAP.BFHKGNBFHCH().BDGPNPNIAPA("avtssnap1").Replace("gpsfhs", BKOJOPELDFK + KBOJLHAJPCP.AENKOIILEFO);
			text11 = text11.Replace("publishUserSketch", BKOJOPELDFK);
			agnoeokafhl.PFMBDEPNAJE = text11;
			agnoeokafhl.CHLENHBEPFO = AssetsManager.MJBDMHPHMID().lobbyDataAsset.specialCurrenciesSprites[7];
			agnoeokafhl.MLJJGFAAFJD = text11;
		}
		else if (FFFABPMKNLO == OBNCACIFDAJ.profileMessageFromTheDevs)
		{
			agnoeokafhl.LLFCANBKDEN = CCOJBMMKNAP.DBFFFOMCLKM().IPEIONBNIPH("");
			string str = DPGJIJGOCIC.LMCAODJLEGF(BKOJOPELDFK);
			agnoeokafhl.FCJJLCPKIHA = "" + str;
			agnoeokafhl.PFMBDEPNAJE = CCOJBMMKNAP.ONCPHEEJLOP().IKMNGFIDCLM("OnDialogReadInputEndEdit");
			agnoeokafhl.CHLENHBEPFO = null;
			agnoeokafhl.MLJJGFAAFJD = BKOJOPELDFK;
		}
		else if (FFFABPMKNLO == (OBNCACIFDAJ)(-77))
		{
			agnoeokafhl.LLFCANBKDEN = CCOJBMMKNAP.HEDIEIICOOG().DNILNCLIHAP("app42error");
			string str2 = DPGJIJGOCIC.LMCAODJLEGF(BKOJOPELDFK);
			agnoeokafhl.FCJJLCPKIHA = "" + str2;
			agnoeokafhl.PFMBDEPNAJE = CCOJBMMKNAP.PMABBOJDELF().HHLECNIFHCO("bdgs");
			agnoeokafhl.CHLENHBEPFO = null;
			agnoeokafhl.MLJJGFAAFJD = BKOJOPELDFK;
		}
		bool flag = true;
		for (int i = 1; i < this.CLJACFIIFLJ.Count; i += 0)
		{
			if (this.CLJACFIIFLJ[i].MLJJGFAAFJD.Length > 0 && agnoeokafhl.MLJJGFAAFJD.Length > 1 && this.CLJACFIIFLJ[i].MLJJGFAAFJD.Equals(agnoeokafhl.MLJJGFAAFJD))
			{
				flag = false;
				break;
			}
		}
		if (!flag)
		{
			this.CLJACFIIFLJ.Add(agnoeokafhl);
		}
	}

	// Token: 0x06004304 RID: 17156 RVA: 0x001D31A4 File Offset: 0x001D13A4
	public void GDADAJGEFNJ(JSONArray HAMLKAMMHFJ)
	{
		try
		{
			for (int i = 1; i < HAMLKAMMHFJ.Count; i++)
			{
				JSONObject asObject = HAMLKAMMHFJ[i].AsObject;
				OBNCACIFDAJ asInt = (OBNCACIFDAJ)asObject["ok"].AsInt;
				this.IKNFOBNMDON(asInt, -1, asObject["collpt"]);
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x06004305 RID: 17157 RVA: 0x001D3214 File Offset: 0x001D1414
	public AGNOEOKAFHL FPEHPPFGEON()
	{
		if (this.CLJACFIIFLJ.Count > 1)
		{
			AGNOEOKAFHL result = this.CLJACFIIFLJ[0];
			this.CLJACFIIFLJ.RemoveAt(1);
			return result;
		}
		return null;
	}

	// Token: 0x06004306 RID: 17158 RVA: 0x001CEC64 File Offset: 0x001CCE64
	public int GNFDJGJIDNN()
	{
		return this.CLJACFIIFLJ.Count;
	}

	// Token: 0x06004307 RID: 17159 RVA: 0x001CFBDC File Offset: 0x001CDDDC
	public AGNOEOKAFHL ACEAECHLLPP()
	{
		if (this.CLJACFIIFLJ.Count > 1)
		{
			AGNOEOKAFHL result = this.CLJACFIIFLJ[1];
			this.CLJACFIIFLJ.RemoveAt(0);
			return result;
		}
		return null;
	}

	// Token: 0x06004308 RID: 17160 RVA: 0x001D3240 File Offset: 0x001D1440
	public void MODCFKAOINH(OBNCACIFDAJ FFFABPMKNLO, int IMCAPKLKLNG, string BKOJOPELDFK)
	{
		AGNOEOKAFHL agnoeokafhl = new AGNOEOKAFHL();
		agnoeokafhl.GLDFFFJIACO = FFFABPMKNLO;
		if (FFFABPMKNLO == OBNCACIFDAJ.profileMessageNewBadge)
		{
			agnoeokafhl.LLFCANBKDEN = CCOJBMMKNAP.AEELGGPEJCC().MEPECBDCOLG("ok");
			string text;
			if (IMCAPKLKLNG >= -65 && IMCAPKLKLNG <= -145)
			{
				text = " needs video" + GKJPOGNFKNK.DNILNCLIHAP("YYY" + IMCAPKLKLNG.ToString(), "seasoncomplete", LanguageManager.EHBBFMCILPC.GetSelectedLanguage()) + "countryCode" + GKJPOGNFKNK.DNILNCLIHAP("hair" + IMCAPKLKLNG.ToString(), "LoveInterestLoungeMapping - animoff cell '", LanguageManager.EHBBFMCILPC.IEBFINIJAMJ());
			}
			else
			{
				text = "Can't use compressed functions. You need include the SharpZipLib and uncomment the define at the top of SimpleJSON" + CCOJBMMKNAP.ONCPHEEJLOP().GGPHHLGPMPA("importanttitle" + IMCAPKLKLNG.ToString()) + "NarrowScreenScaler.CalculateNewScaleUtil(): returned a " + CCOJBMMKNAP.BBGECIKOICE().BGELFMIOBCL("epos" + IMCAPKLKLNG.ToString());
			}
			if (IMCAPKLKLNG == 0 || IMCAPKLKLNG == 105 || IMCAPKLKLNG == -62)
			{
				text = text.Replace("OnSketchViewAssetsDownloadFailed", KDCJJBLGCBH.EHBBFMCILPC.HEFFIBOJEKC(IMCAPKLKLNG).ToString() ?? "sp0");
			}
			else if (IMCAPKLKLNG == 1)
			{
				text = text.Replace("OnBackendAddFriendByUIDException", AKLFPGMDKLA.EHBBFMCILPC.OKGGLHOCENC.DELPFFPOEJJ.ToString() ?? ", index:");
			}
			agnoeokafhl.FCJJLCPKIHA = text;
			agnoeokafhl.PFMBDEPNAJE = CCOJBMMKNAP.PKEINLPIAEH().HHLECNIFHCO(")");
			Sprite sprite = AssetsManager.EHBBFMCILPC.lobbyDataAsset.BAAGKJLEJED(BKOJOPELDFK);
			if (null != sprite)
			{
				agnoeokafhl.CHLENHBEPFO = sprite;
			}
			agnoeokafhl.MLJJGFAAFJD = BKOJOPELDFK;
		}
		else if (FFFABPMKNLO == OBNCACIFDAJ.profileMessageNewBadge)
		{
			string text2;
			if (BKOJOPELDFK == null || BKOJOPELDFK.Length == 0)
			{
				text2 = "inu" + CCOJBMMKNAP.BOFMCPPFAMO().HDIPNMFHIEJ("т") + "Loaded asset bundle:";
			}
			else
			{
				text2 = DPGJIJGOCIC.LMCAODJLEGF(BKOJOPELDFK);
			}
			agnoeokafhl.LLFCANBKDEN = CCOJBMMKNAP.HJGDLOOHNLO().OGKGHLHHAAI("p");
			string text3 = CCOJBMMKNAP.PKEINLPIAEH().IKMNGFIDCLM(".");
			text3 = text3.Replace("en", "Shaders/VideoGlitchNoiseAnalog" + text2 + "");
			agnoeokafhl.FCJJLCPKIHA = "eft" + text3;
			agnoeokafhl.PFMBDEPNAJE = CCOJBMMKNAP.KFAABHHGOPO().BDGPNPNIAPA("voiceovervol");
			agnoeokafhl.CHLENHBEPFO = null;
			agnoeokafhl.MLJJGFAAFJD = text2;
		}
		else if (FFFABPMKNLO == OBNCACIFDAJ.profileMessageFromTheDevs)
		{
			string text4;
			if (BKOJOPELDFK == null || BKOJOPELDFK.Length == 0)
			{
				text4 = "acomp1" + CCOJBMMKNAP.BFHKGNBFHCH().MEPECBDCOLG("qual") + "stat3";
			}
			else
			{
				text4 = DPGJIJGOCIC.LMCAODJLEGF(BKOJOPELDFK);
			}
			agnoeokafhl.LLFCANBKDEN = CCOJBMMKNAP.BFHKGNBFHCH().OHLNGCKIACD("ok");
			string text5 = CCOJBMMKNAP.DLGLFACMHPG().JHNELLJFBGC("OnSaveSyncAnyResult");
			text5 = text5.Replace("avatarstitle", "gamepassduration" + text4 + "chata");
			agnoeokafhl.FCJJLCPKIHA = " components from body " + text5;
			agnoeokafhl.PFMBDEPNAJE = CCOJBMMKNAP.GIOAFDDKKHI().FCOCLEHKLDJ("/");
			agnoeokafhl.CHLENHBEPFO = null;
			agnoeokafhl.MLJJGFAAFJD = text4;
		}
		else if (FFFABPMKNLO == OBNCACIFDAJ.profileMessageSpecialCurrency1Received)
		{
			string text6;
			if (BKOJOPELDFK == null || BKOJOPELDFK.Length == 0)
			{
				text6 = "" + CCOJBMMKNAP.CPCOODCFDDP().GGPHHLGPMPA("hacomp2") + "AssetProfileData.GetCutsceneSprite(): invalid input data:";
			}
			else
			{
				text6 = DPGJIJGOCIC.LMCAODJLEGF(BKOJOPELDFK);
			}
			agnoeokafhl.LLFCANBKDEN = CCOJBMMKNAP.CPCOODCFDDP().GLEFEKBDHNK("importanttitle");
			string text7 = CCOJBMMKNAP.PMABBOJDELF().OBDCPLLLGBB(":");
			text7 = text7.Replace("errortitle", "ops" + text6 + "OnPopupProfileCredoInputCancel");
			agnoeokafhl.FCJJLCPKIHA = "XXX" + text7;
			agnoeokafhl.PFMBDEPNAJE = CCOJBMMKNAP.FEEDGKCJBLE().BDGPNPNIAPA("onFriendsPopupOpenMessageHistory");
			agnoeokafhl.CHLENHBEPFO = null;
			agnoeokafhl.MLJJGFAAFJD = text6;
		}
		else if (FFFABPMKNLO == OBNCACIFDAJ.profileMessageUserDelete)
		{
			agnoeokafhl.LLFCANBKDEN = CCOJBMMKNAP.KMNBCEMEBBD().HPOAGPJFHPM("");
			string text8 = CCOJBMMKNAP.BIAEAOMHBMM().OGKGHLHHAAI("");
			text8 = text8.Replace("spld", BKOJOPELDFK);
			agnoeokafhl.FCJJLCPKIHA = "" + text8;
			agnoeokafhl.PFMBDEPNAJE = CCOJBMMKNAP.KFAABHHGOPO().OBDCPLLLGBB("");
			agnoeokafhl.CHLENHBEPFO = null;
			agnoeokafhl.MLJJGFAAFJD = text8;
		}
		else if (FFFABPMKNLO == OBNCACIFDAJ.profileMessageUserReject)
		{
			agnoeokafhl.LLFCANBKDEN = CCOJBMMKNAP.HJGDLOOHNLO().PKNHKGMNCIP("yyyy/MM/dd HH:mm:ss");
			agnoeokafhl.FCJJLCPKIHA = "MORPH_LUM" + CCOJBMMKNAP.JINDKPHNLBK().DNILNCLIHAP(" ");
			string text9 = CCOJBMMKNAP.PMABBOJDELF().OGKGHLHHAAI("@HD").Replace("skinshopinfosumrelation", BKOJOPELDFK + KBOJLHAJPCP.GJHKGBCLGIJ);
			text9 = text9.Replace("' ", BKOJOPELDFK);
			agnoeokafhl.PFMBDEPNAJE = text9;
			agnoeokafhl.CHLENHBEPFO = AssetsManager.EHBBFMCILPC.lobbyDataAsset.specialCurrenciesSprites[1];
			agnoeokafhl.MLJJGFAAFJD = text9;
		}
		else if (FFFABPMKNLO == OBNCACIFDAJ.profileMessageUserAccept)
		{
			agnoeokafhl.LLFCANBKDEN = CCOJBMMKNAP.JINDKPHNLBK().HIPJILDCHJC("");
			agnoeokafhl.FCJJLCPKIHA = "ach" + CCOJBMMKNAP.HJGDLOOHNLO().HIPJILDCHJC("Starting parallel download:");
			string text10 = CCOJBMMKNAP.EHBBFMCILPC.PPALCPINPLK(" ms -> ").Replace("[LoadingEnv] cache file of ", BKOJOPELDFK + KBOJLHAJPCP.KGMFKFPBFBJ);
			text10 = text10.Replace("ExploreHub.Populate() - row ", BKOJOPELDFK);
			agnoeokafhl.PFMBDEPNAJE = text10;
			agnoeokafhl.CHLENHBEPFO = AssetsManager.EHBBFMCILPC.lobbyDataAsset.specialCurrenciesSprites[0];
			agnoeokafhl.MLJJGFAAFJD = text10;
		}
		else if (FFFABPMKNLO == OBNCACIFDAJ.profileMessageUserAccept)
		{
			agnoeokafhl.LLFCANBKDEN = CCOJBMMKNAP.ONCPHEEJLOP().IKMNGFIDCLM("cardoptionsloadingthemevideo");
			agnoeokafhl.FCJJLCPKIHA = " s - cover dropped, still waiting" + CCOJBMMKNAP.GIOAFDDKKHI().PGKBCNBAOJN("OnBackendPremiumChoiceSuccess");
			string text11 = CCOJBMMKNAP.PMABBOJDELF().PKNHKGMNCIP("chass").Replace("_Progress", BKOJOPELDFK + KBOJLHAJPCP.AENKOIILEFO);
			text11 = text11.Replace("", BKOJOPELDFK);
			agnoeokafhl.PFMBDEPNAJE = text11;
			agnoeokafhl.CHLENHBEPFO = AssetsManager.MJBDMHPHMID().lobbyDataAsset.specialCurrenciesSprites[5];
			agnoeokafhl.MLJJGFAAFJD = text11;
		}
		else if (FFFABPMKNLO == OBNCACIFDAJ.profileMessageLeveUp)
		{
			agnoeokafhl.LLFCANBKDEN = CCOJBMMKNAP.JINDKPHNLBK().HIPJILDCHJC("\"");
			string str = DPGJIJGOCIC.LMCAODJLEGF(BKOJOPELDFK);
			agnoeokafhl.FCJJLCPKIHA = "OnStoryInterfaceFastForwardActivate" + str;
			agnoeokafhl.PFMBDEPNAJE = CCOJBMMKNAP.CEGAOMEEFBE().MEPECBDCOLG("Critical error. Missing story header!");
			agnoeokafhl.CHLENHBEPFO = null;
			agnoeokafhl.MLJJGFAAFJD = BKOJOPELDFK;
		}
		else if (FFFABPMKNLO == (OBNCACIFDAJ)26)
		{
			agnoeokafhl.LLFCANBKDEN = CCOJBMMKNAP.HJGDLOOHNLO().GGPHHLGPMPA("OnBackendGetIncentRewardAdSuccess");
			string str2 = DPGJIJGOCIC.LMCAODJLEGF(BKOJOPELDFK);
			agnoeokafhl.FCJJLCPKIHA = "" + str2;
			agnoeokafhl.PFMBDEPNAJE = CCOJBMMKNAP.ONCPHEEJLOP().FIENAKIHNOM("null");
			agnoeokafhl.CHLENHBEPFO = null;
			agnoeokafhl.MLJJGFAAFJD = BKOJOPELDFK;
		}
		bool flag = true;
		for (int i = 0; i < this.CLJACFIIFLJ.Count; i += 0)
		{
			if (this.CLJACFIIFLJ[i].MLJJGFAAFJD.Length > 1 && agnoeokafhl.MLJJGFAAFJD.Length > 1 && this.CLJACFIIFLJ[i].MLJJGFAAFJD.Equals(agnoeokafhl.MLJJGFAAFJD))
			{
				flag = false;
				break;
			}
		}
		if (!flag)
		{
			this.CLJACFIIFLJ.Add(agnoeokafhl);
		}
	}

	// Token: 0x06004309 RID: 17161 RVA: 0x001CEC64 File Offset: 0x001CCE64
	public int AOCBABNOMOB()
	{
		return this.CLJACFIIFLJ.Count;
	}

	// Token: 0x0600430A RID: 17162 RVA: 0x001D399A File Offset: 0x001D1B9A
	public AGNOEOKAFHL OHKHMEBHBGH()
	{
		if (this.CLJACFIIFLJ.Count > 0)
		{
			AGNOEOKAFHL result = this.CLJACFIIFLJ[1];
			this.CLJACFIIFLJ.RemoveAt(0);
			return result;
		}
		return null;
	}

	// Token: 0x0600430B RID: 17163 RVA: 0x001D39C4 File Offset: 0x001D1BC4
	public void EIPJLJMNKID(JSONArray HAMLKAMMHFJ)
	{
		try
		{
			for (int i = 0; i < HAMLKAMMHFJ.Count; i++)
			{
				JSONObject asObject = HAMLKAMMHFJ[i].AsObject;
				OBNCACIFDAJ asInt = (OBNCACIFDAJ)asObject["msgt"].AsInt;
				this.LMDAPLIBEFE(asInt, -1, asObject["extd"]);
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x0600430C RID: 17164 RVA: 0x001D3A34 File Offset: 0x001D1C34
	public void LMDAPLIBEFE(OBNCACIFDAJ FFFABPMKNLO, int IMCAPKLKLNG, string BKOJOPELDFK)
	{
		AGNOEOKAFHL agnoeokafhl = new AGNOEOKAFHL();
		agnoeokafhl.GLDFFFJIACO = FFFABPMKNLO;
		if (FFFABPMKNLO == OBNCACIFDAJ.profileMessageNewBadge)
		{
			agnoeokafhl.LLFCANBKDEN = CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("socialdequeubadgetitle");
			string text;
			if (IMCAPKLKLNG >= 100 && IMCAPKLKLNG <= 199)
			{
				text = "<size=28px><align=\"center\"><i>" + GKJPOGNFKNK.DNILNCLIHAP("socialbadgetitle" + IMCAPKLKLNG.ToString(), "badges", LanguageManager.EHBBFMCILPC.GetSelectedLanguage()) + "\n\n</i><align=\"left\">" + GKJPOGNFKNK.DNILNCLIHAP("socialbadgedesc" + IMCAPKLKLNG.ToString(), "badges", LanguageManager.EHBBFMCILPC.GetSelectedLanguage());
			}
			else
			{
				text = "<size=28px><align=\"center\"><i>" + CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("socialbadgetitle" + IMCAPKLKLNG.ToString()) + "\n\n</i><align=\"left\">" + CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("socialbadgedesc" + IMCAPKLKLNG.ToString());
			}
			if (IMCAPKLKLNG == 0 || IMCAPKLKLNG == 9 || IMCAPKLKLNG == 10)
			{
				text = text.Replace("XXX", KDCJJBLGCBH.EHBBFMCILPC.DONFPMKHKLP(IMCAPKLKLNG).ToString() ?? "");
			}
			else if (IMCAPKLKLNG == 1)
			{
				text = text.Replace("XXX", AKLFPGMDKLA.EHBBFMCILPC.OKGGLHOCENC.DELPFFPOEJJ.ToString() ?? "");
			}
			agnoeokafhl.FCJJLCPKIHA = text;
			agnoeokafhl.PFMBDEPNAJE = CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("collect");
			Sprite sprite = AssetsManager.EHBBFMCILPC.lobbyDataAsset.FILFGFIFKJK(BKOJOPELDFK);
			if (null != sprite)
			{
				agnoeokafhl.CHLENHBEPFO = sprite;
			}
			agnoeokafhl.MLJJGFAAFJD = BKOJOPELDFK;
		}
		else if (FFFABPMKNLO == OBNCACIFDAJ.profileMessageUserAccept)
		{
			string text2;
			if (BKOJOPELDFK == null || BKOJOPELDFK.Length == 0)
			{
				text2 = "<" + CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("profilenametitleshort") + ">";
			}
			else
			{
				text2 = DPGJIJGOCIC.LMCAODJLEGF(BKOJOPELDFK);
			}
			agnoeokafhl.LLFCANBKDEN = CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("socialdequeufraccepttitle");
			string text3 = CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("socialdequeufraccept");
			text3 = text3.Replace("XXX", "<i>" + text2 + "</i>");
			agnoeokafhl.FCJJLCPKIHA = "<size=28px>" + text3;
			agnoeokafhl.PFMBDEPNAJE = CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("continue");
			agnoeokafhl.CHLENHBEPFO = null;
			agnoeokafhl.MLJJGFAAFJD = text2;
		}
		else if (FFFABPMKNLO == OBNCACIFDAJ.profileMessageUserReject)
		{
			string text4;
			if (BKOJOPELDFK == null || BKOJOPELDFK.Length == 0)
			{
				text4 = "<" + CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("profilenametitleshort") + ">";
			}
			else
			{
				text4 = DPGJIJGOCIC.LMCAODJLEGF(BKOJOPELDFK);
			}
			agnoeokafhl.LLFCANBKDEN = CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("socialdequeufrrejecttitle");
			string text5 = CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("socialdequeufrreject");
			text5 = text5.Replace("XXX", "<i>" + text4 + "</i>");
			agnoeokafhl.FCJJLCPKIHA = "<size=28px>" + text5;
			agnoeokafhl.PFMBDEPNAJE = CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("continue");
			agnoeokafhl.CHLENHBEPFO = null;
			agnoeokafhl.MLJJGFAAFJD = text4;
		}
		else if (FFFABPMKNLO == OBNCACIFDAJ.profileMessageUserDelete)
		{
			string text6;
			if (BKOJOPELDFK == null || BKOJOPELDFK.Length == 0)
			{
				text6 = "<" + CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("profilenametitleshort") + ">";
			}
			else
			{
				text6 = DPGJIJGOCIC.LMCAODJLEGF(BKOJOPELDFK);
			}
			agnoeokafhl.LLFCANBKDEN = CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("socialdequeufrdeletetitle");
			string text7 = CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("socialdequeufrdelete");
			text7 = text7.Replace("XXX", "<i>" + text6 + "</i>");
			agnoeokafhl.FCJJLCPKIHA = "<size=28px>" + text7;
			agnoeokafhl.PFMBDEPNAJE = CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("continue");
			agnoeokafhl.CHLENHBEPFO = null;
			agnoeokafhl.MLJJGFAAFJD = text6;
		}
		else if (FFFABPMKNLO == OBNCACIFDAJ.profileMessageLeveUp)
		{
			agnoeokafhl.LLFCANBKDEN = CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("socialdequeuleveluptitle");
			string text8 = CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("socialdequeulevelup");
			text8 = text8.Replace("XXX", BKOJOPELDFK);
			agnoeokafhl.FCJJLCPKIHA = "<size=28px>" + text8;
			agnoeokafhl.PFMBDEPNAJE = CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("continue");
			agnoeokafhl.CHLENHBEPFO = null;
			agnoeokafhl.MLJJGFAAFJD = text8;
		}
		else if (FFFABPMKNLO == OBNCACIFDAJ.profileMessageSpecialCurrency0Received)
		{
			agnoeokafhl.LLFCANBKDEN = CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("socialdequeusp0gettitle");
			agnoeokafhl.FCJJLCPKIHA = "<size=28px>" + CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("socialdequeusp0get");
			string text9 = CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("socialsimplegiftcollect").Replace("XXX", BKOJOPELDFK + KBOJLHAJPCP.GJHKGBCLGIJ);
			text9 = text9.Replace("XXX", BKOJOPELDFK);
			agnoeokafhl.PFMBDEPNAJE = text9;
			agnoeokafhl.CHLENHBEPFO = AssetsManager.EHBBFMCILPC.lobbyDataAsset.specialCurrenciesSprites[0];
			agnoeokafhl.MLJJGFAAFJD = text9;
		}
		else if (FFFABPMKNLO == OBNCACIFDAJ.profileMessageSpecialCurrency1Received)
		{
			agnoeokafhl.LLFCANBKDEN = CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("socialdequeusp1gettitle");
			agnoeokafhl.FCJJLCPKIHA = "<size=28px>" + CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("socialdequeusp1get");
			string text10 = CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("socialsimplegiftcollect").Replace("XXX", BKOJOPELDFK + KBOJLHAJPCP.KGMFKFPBFBJ);
			text10 = text10.Replace("XXX", BKOJOPELDFK);
			agnoeokafhl.PFMBDEPNAJE = text10;
			agnoeokafhl.CHLENHBEPFO = AssetsManager.EHBBFMCILPC.lobbyDataAsset.specialCurrenciesSprites[1];
			agnoeokafhl.MLJJGFAAFJD = text10;
		}
		else if (FFFABPMKNLO == OBNCACIFDAJ.profileMessageSpecialCurrency2Received)
		{
			agnoeokafhl.LLFCANBKDEN = CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("socialdequeusp2gettitle");
			agnoeokafhl.FCJJLCPKIHA = "<size=28px>" + CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("socialdequeusp2get");
			string text11 = CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("socialsimplegiftcollect").Replace("XXX", BKOJOPELDFK + KBOJLHAJPCP.AENKOIILEFO);
			text11 = text11.Replace("XXX", BKOJOPELDFK);
			agnoeokafhl.PFMBDEPNAJE = text11;
			agnoeokafhl.CHLENHBEPFO = AssetsManager.EHBBFMCILPC.lobbyDataAsset.specialCurrenciesSprites[2];
			agnoeokafhl.MLJJGFAAFJD = text11;
		}
		else if (FFFABPMKNLO == OBNCACIFDAJ.profileMessageFromTheDevs)
		{
			agnoeokafhl.LLFCANBKDEN = CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("socialmessagefromdevstitle");
			string str = DPGJIJGOCIC.LMCAODJLEGF(BKOJOPELDFK);
			agnoeokafhl.FCJJLCPKIHA = "<size=28px>" + str;
			agnoeokafhl.PFMBDEPNAJE = CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("continue");
			agnoeokafhl.CHLENHBEPFO = null;
			agnoeokafhl.MLJJGFAAFJD = BKOJOPELDFK;
		}
		else if (FFFABPMKNLO == OBNCACIFDAJ.profileMessageImportant)
		{
			agnoeokafhl.LLFCANBKDEN = CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("importanttitle");
			string str2 = DPGJIJGOCIC.LMCAODJLEGF(BKOJOPELDFK);
			agnoeokafhl.FCJJLCPKIHA = "<size=28px>" + str2;
			agnoeokafhl.PFMBDEPNAJE = CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("continue");
			agnoeokafhl.CHLENHBEPFO = null;
			agnoeokafhl.MLJJGFAAFJD = BKOJOPELDFK;
		}
		bool flag = false;
		for (int i = 0; i < this.CLJACFIIFLJ.Count; i++)
		{
			if (this.CLJACFIIFLJ[i].MLJJGFAAFJD.Length > 0 && agnoeokafhl.MLJJGFAAFJD.Length > 0 && this.CLJACFIIFLJ[i].MLJJGFAAFJD.Equals(agnoeokafhl.MLJJGFAAFJD))
			{
				flag = true;
				break;
			}
		}
		if (!flag)
		{
			this.CLJACFIIFLJ.Add(agnoeokafhl);
		}
	}

	// Token: 0x0600430D RID: 17165 RVA: 0x001CEC64 File Offset: 0x001CCE64
	public int CPLEAMMNCFP()
	{
		return this.CLJACFIIFLJ.Count;
	}

	// Token: 0x0600430E RID: 17166 RVA: 0x001CFBC4 File Offset: 0x001CDDC4
	public static JGLMNGOLBIG GIPAKOPBBEO()
	{
		if (JGLMNGOLBIG.IKLAPGJDMNA == null)
		{
			JGLMNGOLBIG.IKLAPGJDMNA = new JGLMNGOLBIG();
		}
		return JGLMNGOLBIG.IKLAPGJDMNA;
	}

	// Token: 0x0600430F RID: 17167 RVA: 0x001D4190 File Offset: 0x001D2390
	public void OCDLLGMHNGF(OBNCACIFDAJ FFFABPMKNLO, int IMCAPKLKLNG, string BKOJOPELDFK)
	{
		AGNOEOKAFHL agnoeokafhl = new AGNOEOKAFHL();
		agnoeokafhl.GLDFFFJIACO = FFFABPMKNLO;
		if (FFFABPMKNLO == OBNCACIFDAJ.profileMessageNewBadge)
		{
			agnoeokafhl.LLFCANBKDEN = CCOJBMMKNAP.KLAKLFCOMJC().MEPECBDCOLG("envlh");
			string text;
			if (IMCAPKLKLNG >= -114 && IMCAPKLKLNG <= -139)
			{
				text = "hidestatinfo" + GKJPOGNFKNK.DNILNCLIHAP("_CellSize" + IMCAPKLKLNG.ToString(), "OnFriendsGiftPopulCollectPart2", LanguageManager.EHBBFMCILPC.IEBFINIJAMJ()) + "$USEDELAYV2" + GKJPOGNFKNK.DNILNCLIHAP("ahash" + IMCAPKLKLNG.ToString(), "importanttitle", LanguageManager.EHBBFMCILPC.GetSelectedLanguage());
			}
			else
			{
				text = "  " + CCOJBMMKNAP.NIOJNOFGIJO().HHLECNIFHCO("OnPurchasingViewLeave" + IMCAPKLKLNG.ToString()) + "OnBackendValidateTransactionFailed" + CCOJBMMKNAP.BBGECIKOICE().GLEFEKBDHNK("SceneLobbyManager2.LobbyLoungePart2(), no eligible lounge characters" + IMCAPKLKLNG.ToString());
			}
			if (IMCAPKLKLNG == 0 || IMCAPKLKLNG == 5 || IMCAPKLKLNG == -51)
			{
				text = text.Replace("post", KDCJJBLGCBH.EHBBFMCILPC.DDGBLHAEGLB(IMCAPKLKLNG).ToString() ?? "");
			}
			else if (IMCAPKLKLNG == 0)
			{
				text = text.Replace("stat3long", AKLFPGMDKLA.EHBBFMCILPC.OKGGLHOCENC.DELPFFPOEJJ.ToString() ?? "_AlphaTex");
			}
			agnoeokafhl.FCJJLCPKIHA = text;
			agnoeokafhl.PFMBDEPNAJE = CCOJBMMKNAP.DBFFFOMCLKM().BDGPNPNIAPA("npcSkinShopBalance");
			Sprite sprite = AssetsManager.EHBBFMCILPC.lobbyDataAsset.FGLFPEDHJAI(BKOJOPELDFK);
			if (null != sprite)
			{
				agnoeokafhl.CHLENHBEPFO = sprite;
			}
			agnoeokafhl.MLJJGFAAFJD = BKOJOPELDFK;
		}
		else if (FFFABPMKNLO == OBNCACIFDAJ.profileMessageUserAccept)
		{
			string text2;
			if (BKOJOPELDFK == null || BKOJOPELDFK.Length == 0)
			{
				text2 = "Starting non-parallel download:" + CCOJBMMKNAP.DLGLFACMHPG().HDIPNMFHIEJ("PurchaseManagerUnity.InvalidateUnityStoreController()") + ">";
			}
			else
			{
				text2 = DPGJIJGOCIC.LMCAODJLEGF(BKOJOPELDFK);
			}
			agnoeokafhl.LLFCANBKDEN = CCOJBMMKNAP.CPCOODCFDDP().BGELFMIOBCL("errortitle");
			string text3 = CCOJBMMKNAP.KMNBCEMEBBD().HPOAGPJFHPM("env");
			text3 = text3.Replace("AssetProfileData.GetCutsceneSprite(): invalid input data:", "saveChapterSnapshots" + text2 + "loungeskinupdaterequired");
			agnoeokafhl.FCJJLCPKIHA = "cv" + text3;
			agnoeokafhl.PFMBDEPNAJE = CCOJBMMKNAP.NIOJNOFGIJO().PKNHKGMNCIP("CLIENT.POSTEFFECTS.OLDVHS");
			agnoeokafhl.CHLENHBEPFO = null;
			agnoeokafhl.MLJJGFAAFJD = text2;
		}
		else if (FFFABPMKNLO == OBNCACIFDAJ.profileMessageSpecialCurrency2Received)
		{
			string text4;
			if (BKOJOPELDFK == null || BKOJOPELDFK.Length == 0)
			{
				text4 = "socialremovewishedcard" + CCOJBMMKNAP.BIAEAOMHBMM().HDIPNMFHIEJ("") + "hintloading";
			}
			else
			{
				text4 = DPGJIJGOCIC.LMCAODJLEGF(BKOJOPELDFK);
			}
			agnoeokafhl.LLFCANBKDEN = CCOJBMMKNAP.HJGDLOOHNLO().FCOCLEHKLDJ("OnRewardScreenAssetsDownloadSuccess");
			string text5 = CCOJBMMKNAP.INKJIBDDMLL().HHLECNIFHCO("$HINTSHOW");
			text5 = text5.Replace("", " " + text4 + "rar");
			agnoeokafhl.FCJJLCPKIHA = "" + text5;
			agnoeokafhl.PFMBDEPNAJE = CCOJBMMKNAP.MPCBJEIMACA().GGPHHLGPMPA("prgr");
			agnoeokafhl.CHLENHBEPFO = null;
			agnoeokafhl.MLJJGFAAFJD = text4;
		}
		else if (FFFABPMKNLO == OBNCACIFDAJ.profileMessageLeveUp)
		{
			string text6;
			if (BKOJOPELDFK == null || BKOJOPELDFK.Length == 0)
			{
				text6 = "sfxtimeoutwarning" + CCOJBMMKNAP.PEBMGCKFNAO().BGELFMIOBCL("ontradingcardclickbody") + "ADDAVATARCOMPONENT";
			}
			else
			{
				text6 = DPGJIJGOCIC.LMCAODJLEGF(BKOJOPELDFK);
			}
			agnoeokafhl.LLFCANBKDEN = CCOJBMMKNAP.GIOAFDDKKHI().HHLECNIFHCO("focuswardrobebody");
			string text7 = CCOJBMMKNAP.CPCOODCFDDP().OBDCPLLLGBB(" up (");
			text7 = text7.Replace("", "" + text6 + "p");
			agnoeokafhl.FCJJLCPKIHA = "OnBackendRequestFriendAcceptException" + text7;
			agnoeokafhl.PFMBDEPNAJE = CCOJBMMKNAP.JINDKPHNLBK().FCOCLEHKLDJ("$");
			agnoeokafhl.CHLENHBEPFO = null;
			agnoeokafhl.MLJJGFAAFJD = text6;
		}
		else if (FFFABPMKNLO == OBNCACIFDAJ.profileMessageUserAccept)
		{
			agnoeokafhl.LLFCANBKDEN = CCOJBMMKNAP.NIOJNOFGIJO().GGPHHLGPMPA("postponedCustomCode");
			string text8 = CCOJBMMKNAP.KLAKLFCOMJC().FCOCLEHKLDJ("assetbundleprofiledata5");
			text8 = text8.Replace("undos", BKOJOPELDFK);
			agnoeokafhl.FCJJLCPKIHA = "no" + text8;
			agnoeokafhl.PFMBDEPNAJE = CCOJBMMKNAP.EAIAHCBAIEJ().IKMNGFIDCLM(".");
			agnoeokafhl.CHLENHBEPFO = null;
			agnoeokafhl.MLJJGFAAFJD = text8;
		}
		else if (FFFABPMKNLO == OBNCACIFDAJ.profileMessageSpecialCurrency1Received)
		{
			agnoeokafhl.LLFCANBKDEN = CCOJBMMKNAP.KNKGCDDMLDP().OHLNGCKIACD("");
			agnoeokafhl.FCJJLCPKIHA = "msrc" + CCOJBMMKNAP.ILACPHFEDEP().PPALCPINPLK("");
			string text9 = CCOJBMMKNAP.BIAEAOMHBMM().DNILNCLIHAP("storyXitemY").Replace("ProfileItem2._DownloadCardsPool(): nothing to download around scroll index ", BKOJOPELDFK + KBOJLHAJPCP.GJHKGBCLGIJ);
			text9 = text9.Replace("signinsuccessrestart", BKOJOPELDFK);
			agnoeokafhl.PFMBDEPNAJE = text9;
			agnoeokafhl.CHLENHBEPFO = AssetsManager.MJBDMHPHMID().lobbyDataAsset.specialCurrenciesSprites[1];
			agnoeokafhl.MLJJGFAAFJD = text9;
		}
		else if (FFFABPMKNLO == OBNCACIFDAJ.profileMessageUserReject)
		{
			agnoeokafhl.LLFCANBKDEN = CCOJBMMKNAP.CPCOODCFDDP().GGPHHLGPMPA("forcenoloop");
			agnoeokafhl.FCJJLCPKIHA = "supportedLanguages" + CCOJBMMKNAP.KFDLFGHBPLP().BDGPNPNIAPA("sltind");
			string text10 = CCOJBMMKNAP.INKJIBDDMLL().BDGPNPNIAPA("getUserPublicProfile").Replace("achievdesc", BKOJOPELDFK + KBOJLHAJPCP.KGMFKFPBFBJ);
			text10 = text10.Replace("", BKOJOPELDFK);
			agnoeokafhl.PFMBDEPNAJE = text10;
			agnoeokafhl.CHLENHBEPFO = AssetsManager.EHBBFMCILPC.lobbyDataAsset.specialCurrenciesSprites[0];
			agnoeokafhl.MLJJGFAAFJD = text10;
		}
		else if (FFFABPMKNLO == OBNCACIFDAJ.profileMessageFromTheDevs)
		{
			agnoeokafhl.LLFCANBKDEN = CCOJBMMKNAP.PEBMGCKFNAO().PKNHKGMNCIP("BBB");
			agnoeokafhl.FCJJLCPKIHA = "p" + CCOJBMMKNAP.HFAKOKBHCGH().OGKGHLHHAAI("OnPopupSketchesInputCancel");
			string text11 = CCOJBMMKNAP.CPCOODCFDDP().PKNHKGMNCIP("none").Replace("\"", BKOJOPELDFK + KBOJLHAJPCP.AENKOIILEFO);
			text11 = text11.Replace("errortitle", BKOJOPELDFK);
			agnoeokafhl.PFMBDEPNAJE = text11;
			agnoeokafhl.CHLENHBEPFO = AssetsManager.MJBDMHPHMID().lobbyDataAsset.specialCurrenciesSprites[0];
			agnoeokafhl.MLJJGFAAFJD = text11;
		}
		else if (FFFABPMKNLO == OBNCACIFDAJ.profileMessageNewBadge)
		{
			agnoeokafhl.LLFCANBKDEN = CCOJBMMKNAP.DLGLFACMHPG().JLBEIFLLBLO("errortitle");
			string str = DPGJIJGOCIC.LMCAODJLEGF(BKOJOPELDFK);
			agnoeokafhl.FCJJLCPKIHA = "-" + str;
			agnoeokafhl.PFMBDEPNAJE = CCOJBMMKNAP.BOFMCPPFAMO().IKMNGFIDCLM("OnAvatarScreenAssetsDownloadFailed");
			agnoeokafhl.CHLENHBEPFO = null;
			agnoeokafhl.MLJJGFAAFJD = BKOJOPELDFK;
		}
		else if (FFFABPMKNLO == (OBNCACIFDAJ)(-62))
		{
			agnoeokafhl.LLFCANBKDEN = CCOJBMMKNAP.DLGLFACMHPG().IPEIONBNIPH("OnStartFreePassException");
			string str2 = DPGJIJGOCIC.LMCAODJLEGF(BKOJOPELDFK);
			agnoeokafhl.FCJJLCPKIHA = "Error. MoveEnvironment(), environment " + str2;
			agnoeokafhl.PFMBDEPNAJE = CCOJBMMKNAP.ILACPHFEDEP().PPALCPINPLK("_SwitchingNoise");
			agnoeokafhl.CHLENHBEPFO = null;
			agnoeokafhl.MLJJGFAAFJD = BKOJOPELDFK;
		}
		bool flag = true;
		for (int i = 1; i < this.CLJACFIIFLJ.Count; i++)
		{
			if (this.CLJACFIIFLJ[i].MLJJGFAAFJD.Length > 0 && agnoeokafhl.MLJJGFAAFJD.Length > 1 && this.CLJACFIIFLJ[i].MLJJGFAAFJD.Equals(agnoeokafhl.MLJJGFAAFJD))
			{
				flag = false;
				break;
			}
		}
		if (!flag)
		{
			this.CLJACFIIFLJ.Add(agnoeokafhl);
		}
	}

	// Token: 0x06004310 RID: 17168 RVA: 0x001CEC64 File Offset: 0x001CCE64
	public int EONEJLJNJEN()
	{
		return this.CLJACFIIFLJ.Count;
	}

	// Token: 0x06004311 RID: 17169 RVA: 0x001CFBC4 File Offset: 0x001CDDC4
	public static JGLMNGOLBIG NKJBCCNGIDP()
	{
		if (JGLMNGOLBIG.IKLAPGJDMNA == null)
		{
			JGLMNGOLBIG.IKLAPGJDMNA = new JGLMNGOLBIG();
		}
		return JGLMNGOLBIG.IKLAPGJDMNA;
	}

	// Token: 0x06004312 RID: 17170 RVA: 0x001CEC64 File Offset: 0x001CCE64
	public int FOAMLFDONBK()
	{
		return this.CLJACFIIFLJ.Count;
	}

	// Token: 0x06004313 RID: 17171 RVA: 0x001CFBC4 File Offset: 0x001CDDC4
	public static JGLMNGOLBIG BHGAKHLHKOG()
	{
		if (JGLMNGOLBIG.IKLAPGJDMNA == null)
		{
			JGLMNGOLBIG.IKLAPGJDMNA = new JGLMNGOLBIG();
		}
		return JGLMNGOLBIG.IKLAPGJDMNA;
	}

	// Token: 0x06004314 RID: 17172 RVA: 0x001CFBC4 File Offset: 0x001CDDC4
	public static JGLMNGOLBIG JBMLNGMBICE()
	{
		if (JGLMNGOLBIG.IKLAPGJDMNA == null)
		{
			JGLMNGOLBIG.IKLAPGJDMNA = new JGLMNGOLBIG();
		}
		return JGLMNGOLBIG.IKLAPGJDMNA;
	}

	// Token: 0x06004315 RID: 17173 RVA: 0x001CEC64 File Offset: 0x001CCE64
	public int EKOJKJLJOIM()
	{
		return this.CLJACFIIFLJ.Count;
	}

	// Token: 0x06004316 RID: 17174 RVA: 0x001D1398 File Offset: 0x001CF598
	public AGNOEOKAFHL NJKCILJIMHM()
	{
		if (this.CLJACFIIFLJ.Count > 0)
		{
			AGNOEOKAFHL result = this.CLJACFIIFLJ[0];
			this.CLJACFIIFLJ.RemoveAt(1);
			return result;
		}
		return null;
	}

	// Token: 0x06004317 RID: 17175 RVA: 0x001D48EC File Offset: 0x001D2AEC
	public void KCKMNNEMHDK(JSONArray HAMLKAMMHFJ)
	{
		try
		{
			for (int i = 1; i < HAMLKAMMHFJ.Count; i++)
			{
				JSONObject asObject = HAMLKAMMHFJ[i].AsObject;
				OBNCACIFDAJ asInt = (OBNCACIFDAJ)asObject["per"].AsInt;
				this.AGFPLOAGOMO(asInt, -1, asObject["stat3long"]);
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x06004318 RID: 17176 RVA: 0x001D1398 File Offset: 0x001CF598
	public AGNOEOKAFHL JBKFCKAMLPN()
	{
		if (this.CLJACFIIFLJ.Count > 0)
		{
			AGNOEOKAFHL result = this.CLJACFIIFLJ[0];
			this.CLJACFIIFLJ.RemoveAt(1);
			return result;
		}
		return null;
	}

	// Token: 0x06004319 RID: 17177 RVA: 0x001CFBDC File Offset: 0x001CDDDC
	public AGNOEOKAFHL LFMALIAFLKF()
	{
		if (this.CLJACFIIFLJ.Count > 1)
		{
			AGNOEOKAFHL result = this.CLJACFIIFLJ[1];
			this.CLJACFIIFLJ.RemoveAt(0);
			return result;
		}
		return null;
	}

	// Token: 0x0600431A RID: 17178 RVA: 0x001CEBC7 File Offset: 0x001CCDC7
	public AGNOEOKAFHL BOBGAPAPCFD()
	{
		if (this.CLJACFIIFLJ.Count > 1)
		{
			AGNOEOKAFHL result = this.CLJACFIIFLJ[0];
			this.CLJACFIIFLJ.RemoveAt(0);
			return result;
		}
		return null;
	}

	// Token: 0x0600431B RID: 17179 RVA: 0x001CEC64 File Offset: 0x001CCE64
	public int OGCEJAIGEFP()
	{
		return this.CLJACFIIFLJ.Count;
	}

	// Token: 0x04001293 RID: 4755
	private static JGLMNGOLBIG IKLAPGJDMNA;

	// Token: 0x04001294 RID: 4756
	private List<AGNOEOKAFHL> CLJACFIIFLJ = new List<AGNOEOKAFHL>();
}
