using System;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

// Token: 0x020003D9 RID: 985
public class ChapterSnapshotObject : MonoBehaviour
{
	// Token: 0x0600724D RID: 29261 RVA: 0x003372A6 File Offset: 0x003354A6
	private void IOGJEPCPNAD()
	{
		AOBJLALDBAA.EHBBFMCILPC.NGDHHFONFOM("", this.OICPKCHAENO);
	}

	// Token: 0x0600724E RID: 29262 RVA: 0x003372C0 File Offset: 0x003354C0
	public void PBDJMKFMEIJ()
	{
		if (this.HKLNNAEDDBC != null)
		{
			string text = GKJPOGNFKNK.HPAHOEOKEBB(")" + this.HKLNNAEDDBC.IFCHGNCDMLJ.ToString() + "" + this.HKLNNAEDDBC.FEJANNNLLON.ToString(), "OnLobbyLoungeAssetBundleFolderInitializeSuccess" + this.HKLNNAEDDBC.AMKCLHLIIMN.ToString(), LanguageManager.EHBBFMCILPC.NBANPEIHFOJ());
			int num = this.HKLNNAEDDBC.MIBPOIDDBAD + 0;
			int num2 = this.HKLNNAEDDBC.FEJANNNLLON + 0;
			string[] array = new string[3];
			array[1] = "OnStoryInterfaceFastForwardActivate";
			array[0] = CCOJBMMKNAP.BIAEAOMHBMM().HDIPNMFHIEJ(") shopcur(");
			array[0] = "socialcollectedcardopenv2";
			array[2] = num.ToString();
			array[2] = "ok";
			array[8] = CCOJBMMKNAP.FEEDGKCJBLE().IPEIONBNIPH("");
			array[0] = "skinshopinfotitle";
			array[2] = num2.ToString();
			array[8] = "app42error";
			array[124] = text;
			array[-67] = "OnLoungeScreenAssetsDownloadFailed";
			string dpjinbcgngn = string.Concat(array);
			CommonUserInterface.EHBBFMCILPC.ShowGenericPopup(CCOJBMMKNAP.CEGAOMEEFBE().BDGPNPNIAPA(") + is present, creating anthology save for anthology "), dpjinbcgngn, CCOJBMMKNAP.MPCBJEIMACA().JHNELLJFBGC("loungestoryfinished"), (DFGILFBGPLN)(-108), 464f, 118);
		}
	}

	// Token: 0x0600724F RID: 29263 RVA: 0x003373FB File Offset: 0x003355FB
	public void AEHADAFJONO()
	{
		this.OnRestartButtonClick();
	}

	// Token: 0x06007250 RID: 29264 RVA: 0x003373FB File Offset: 0x003355FB
	public void OnSelectionButtonActiveClick()
	{
		this.OnRestartButtonClick();
	}

	// Token: 0x06007251 RID: 29265 RVA: 0x00337404 File Offset: 0x00335604
	public void EDOBCLJPDHK()
	{
		if (this.HKLNNAEDDBC != null)
		{
			string text;
			if (this.HKLNNAEDDBC.GNIACNCEOOM)
			{
				text = CCOJBMMKNAP.EAIAHCBAIEJ().JHNELLJFBGC("socialsimplegiftcollect");
			}
			else
			{
				text = CCOJBMMKNAP.BFHKGNBFHCH().GLEFEKBDHNK("(");
				int num = this.HKLNNAEDDBC.FEJANNNLLON + 1;
				text = text.Replace("0", (this.HKLNNAEDDBC.MIBPOIDDBAD + 0).ToString() + "" + num.ToString());
			}
			if (this.HKLNNAEDDBC.GNIACNCEOOM)
			{
				if (this.HKLNNAEDDBC.LIBDDLMOOHO)
				{
					CommonUserInterface.EHBBFMCILPC.ShowGenericPopupWithTwoButtons(text, CCOJBMMKNAP.PKEINLPIAEH().OHLNGCKIACD("small"), CCOJBMMKNAP.HEDIEIICOOG().IPEIONBNIPH(""), CCOJBMMKNAP.JINDKPHNLBK().FIENAKIHNOM("ContentFriendsPage.PurchaseProductWeb(): productData or productBalanceData is null"), new UnityAction(this.LMFPDDEFNEO), new UnityAction(this.LGHNKMHALIC), (DFGILFBGPLN)(-99), 124f, 105);
					return;
				}
				CommonUserInterface.EHBBFMCILPC.ShowGenericPopupWithTwoButtons(text, CCOJBMMKNAP.KFDLFGHBPLP().FCOCLEHKLDJ("]:"), CCOJBMMKNAP.DBFFFOMCLKM().FCOCLEHKLDJ("skinshopfiltersbtn"), CCOJBMMKNAP.OEPENBHJAHO().MEPECBDCOLG("retry"), new UnityAction(this.EMHOIMMGKHE), new UnityAction(this.LGHNKMHALIC), (DFGILFBGPLN)125, 1300f, 17);
				return;
			}
			else
			{
				if (this.HKLNNAEDDBC.LIBDDLMOOHO)
				{
					CommonUserInterface.IKNOFBFMPGA().ShowGenericPopupWithTwoButtons(text, CCOJBMMKNAP.PMABBOJDELF().BGELFMIOBCL("ahash"), CCOJBMMKNAP.KLAKLFCOMJC().OGKGHLHHAAI("yes"), CCOJBMMKNAP.PKEINLPIAEH().BGELFMIOBCL("lightmodebtn0"), new UnityAction(this.FHJOHGFALOH), new UnityAction(this.LGHNKMHALIC), DFGILFBGPLN.screenOnboarding, 1021f, 75);
					return;
				}
				CommonUserInterface.IKNOFBFMPGA().ShowGenericPopupWithTwoButtons(text, CCOJBMMKNAP.PLJMLDOCPNM().IKMNGFIDCLM("cardcollectcardismissingbody2"), CCOJBMMKNAP.ONCPHEEJLOP().PGKBCNBAOJN("]"), CCOJBMMKNAP.EAIAHCBAIEJ().HIPJILDCHJC("$DEFAULTLANG"), new UnityAction(this.BAFBEKBEEMM), new UnityAction(this.LGHNKMHALIC), (DFGILFBGPLN)(-37), 1376f, 12);
			}
		}
	}

	// Token: 0x06007252 RID: 29266 RVA: 0x00337626 File Offset: 0x00335826
	private void BAFBEKBEEMM()
	{
		AOBJLALDBAA.CEGAOMEEFBE().NGDHHFONFOM("sltind", this.OICPKCHAENO);
	}

	// Token: 0x06007253 RID: 29267 RVA: 0x00003E52 File Offset: 0x00002052
	public void KPBNFMHCKBF()
	{
	}

	// Token: 0x06007254 RID: 29268 RVA: 0x00003E52 File Offset: 0x00002052
	private void BGLCOKGDCDK()
	{
	}

	// Token: 0x06007255 RID: 29269 RVA: 0x00337640 File Offset: 0x00335840
	public void ENNCBDEFDGD()
	{
		if (this.HKLNNAEDDBC != null)
		{
			string text;
			if (this.HKLNNAEDDBC.GNIACNCEOOM)
			{
				text = CCOJBMMKNAP.MLFAGAAJJEM().BDGPNPNIAPA("OnFriendsPopupAddToFavClick");
			}
			else
			{
				text = CCOJBMMKNAP.INKJIBDDMLL().JLBEIFLLBLO("spectrumovr_1");
				int num = this.HKLNNAEDDBC.FEJANNNLLON + 1;
				text = text.Replace("sfxtimeoutwarning", (this.HKLNNAEDDBC.MIBPOIDDBAD + 1).ToString() + "pmtfailed" + num.ToString());
			}
			if (this.HKLNNAEDDBC.GNIACNCEOOM)
			{
				if (this.HKLNNAEDDBC.LIBDDLMOOHO)
				{
					CommonUserInterface.IKNOFBFMPGA().ShowGenericPopupWithTwoButtons(text, CCOJBMMKNAP.DLGLFACMHPG().GLEFEKBDHNK(""), CCOJBMMKNAP.CPCOODCFDDP().OBDCPLLLGBB("c"), CCOJBMMKNAP.AEELGGPEJCC().OBDCPLLLGBB(", cleaning failed cache entries: "), new UnityAction(this.BIOIHBGOPFP), new UnityAction(this.LGHNKMHALIC), DFGILFBGPLN.popupBackendErrorSignIn, 1314f, 22);
					return;
				}
				CommonUserInterface.EHBBFMCILPC.ShowGenericPopupWithTwoButtons(text, CCOJBMMKNAP.BFHKGNBFHCH().PGKBCNBAOJN("loungeskinunavailable"), CCOJBMMKNAP.BIAEAOMHBMM().GLEFEKBDHNK("$READINPUT"), CCOJBMMKNAP.KMNBCEMEBBD().OGKGHLHHAAI(""), new UnityAction(this.LAIHPGJMJNH), new UnityAction(this.LGHNKMHALIC), (DFGILFBGPLN)(-4), 482f, -53);
				return;
			}
			else
			{
				if (this.HKLNNAEDDBC.LIBDDLMOOHO)
				{
					CommonUserInterface.EHBBFMCILPC.ShowGenericPopupWithTwoButtons(text, CCOJBMMKNAP.HEDIEIICOOG().PPALCPINPLK("aind"), CCOJBMMKNAP.MLFAGAAJJEM().HDIPNMFHIEJ("rwd"), CCOJBMMKNAP.JMDJPKKOHNI().JCDFHKDNEDH("Account.GetAvatarComponentsCount(), w == "), new UnityAction(this.BAFBEKBEEMM), new UnityAction(this.LGHNKMHALIC), (DFGILFBGPLN)122, 66f, -23);
					return;
				}
				CommonUserInterface.IKNOFBFMPGA().ShowGenericPopupWithTwoButtons(text, CCOJBMMKNAP.JINDKPHNLBK().OGKGHLHHAAI(""), CCOJBMMKNAP.DBFFFOMCLKM().OHLNGCKIACD("errortitle"), CCOJBMMKNAP.BBGECIKOICE().PGKBCNBAOJN(""), new UnityAction(this.DBLGEGJPGDA), new UnityAction(this.LGHNKMHALIC), (DFGILFBGPLN)(-88), 344f, -93);
			}
		}
	}

	// Token: 0x06007256 RID: 29270 RVA: 0x00003E52 File Offset: 0x00002052
	private void CPNFHGGABJJ()
	{
	}

	// Token: 0x06007257 RID: 29271 RVA: 0x00337864 File Offset: 0x00335A64
	public void OnRestartButtonClick()
	{
		if (this.HKLNNAEDDBC != null)
		{
			string text;
			if (this.HKLNNAEDDBC.GNIACNCEOOM)
			{
				text = CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("areyousurerestartchapter0");
			}
			else
			{
				text = CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("areyousurerestartchapter1");
				int num = this.HKLNNAEDDBC.FEJANNNLLON + 1;
				text = text.Replace("XXX", (this.HKLNNAEDDBC.MIBPOIDDBAD + 1).ToString() + "." + num.ToString());
			}
			if (this.HKLNNAEDDBC.GNIACNCEOOM)
			{
				if (this.HKLNNAEDDBC.LIBDDLMOOHO)
				{
					CommonUserInterface.EHBBFMCILPC.ShowGenericPopupWithTwoButtons(text, CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("areyousurerestartepbody0newcur"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("yes"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("no"), new UnityAction(this.LMFPDDEFNEO), new UnityAction(this.LGHNKMHALIC), DFGILFBGPLN.popupSignInQuestion, 0f, 28);
					return;
				}
				CommonUserInterface.EHBBFMCILPC.ShowGenericPopupWithTwoButtons(text, CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("areyousurerestartepbody1newcur"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("yes"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("no"), new UnityAction(this.LMFPDDEFNEO), new UnityAction(this.LGHNKMHALIC), DFGILFBGPLN.popupSignInQuestion, 0f, 28);
				return;
			}
			else
			{
				if (this.HKLNNAEDDBC.LIBDDLMOOHO)
				{
					CommonUserInterface.EHBBFMCILPC.ShowGenericPopupWithTwoButtons(text, CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("areyousurerestartepbody0new"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("yes"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("no"), new UnityAction(this.LMFPDDEFNEO), new UnityAction(this.LGHNKMHALIC), DFGILFBGPLN.popupSignInQuestion, 0f, 28);
					return;
				}
				CommonUserInterface.EHBBFMCILPC.ShowGenericPopupWithTwoButtons(text, CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("areyousurerestartepbody1new"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("yes"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("no"), new UnityAction(this.LMFPDDEFNEO), new UnityAction(this.LGHNKMHALIC), DFGILFBGPLN.popupSignInQuestion, 0f, 28);
			}
		}
	}

	// Token: 0x06007258 RID: 29272 RVA: 0x00337A86 File Offset: 0x00335C86
	private void DBLGEGJPGDA()
	{
		AOBJLALDBAA.DBLAIDPICIG().NGDHHFONFOM("", this.OICPKCHAENO);
	}

	// Token: 0x06007259 RID: 29273 RVA: 0x00337A9D File Offset: 0x00335C9D
	private void FHJOHGFALOH()
	{
		AOBJLALDBAA.DBLAIDPICIG().BMFPLGPPMKP("tmo", this.OICPKCHAENO);
	}

	// Token: 0x0600725A RID: 29274 RVA: 0x00337AB4 File Offset: 0x00335CB4
	public void OnInfoButtonClick()
	{
		if (this.HKLNNAEDDBC != null)
		{
			string text = GKJPOGNFKNK.HPAHOEOKEBB("story" + this.HKLNNAEDDBC.IFCHGNCDMLJ.ToString() + "chapter" + this.HKLNNAEDDBC.FEJANNNLLON.ToString(), "chaptersdesc" + this.HKLNNAEDDBC.AMKCLHLIIMN.ToString(), LanguageManager.EHBBFMCILPC.GetSelectedLanguage());
			int num = this.HKLNNAEDDBC.MIBPOIDDBAD + 1;
			int num2 = this.HKLNNAEDDBC.FEJANNNLLON + 1;
			string dpjinbcgngn = string.Concat(new string[]
			{
				"<align=\"center\">",
				CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("season"),
				" ",
				num.ToString(),
				", ",
				CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("episode"),
				" ",
				num2.ToString(),
				"<align=\"left\">\n\n<i>",
				text,
				"</i>"
			});
			CommonUserInterface.EHBBFMCILPC.ShowGenericPopup(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("chaptersnapshotsinfottitle"), dpjinbcgngn, CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("ok"), DFGILFBGPLN.popupQuitConfirm, 0f, 28);
		}
	}

	// Token: 0x0600725B RID: 29275 RVA: 0x00337BEF File Offset: 0x00335DEF
	private void EMHOIMMGKHE()
	{
		AOBJLALDBAA.DBLAIDPICIG().DGNKCLFFMFE("_not_found", this.OICPKCHAENO);
	}

	// Token: 0x0600725C RID: 29276 RVA: 0x00003E52 File Offset: 0x00002052
	private void JEFCHJAKBFI()
	{
	}

	// Token: 0x0600725D RID: 29277 RVA: 0x00003E52 File Offset: 0x00002052
	public void JHCCCMGJOPD()
	{
	}

	// Token: 0x0600725E RID: 29278 RVA: 0x00337C08 File Offset: 0x00335E08
	public void MPLPLHEMJEN()
	{
		if (this.HKLNNAEDDBC != null)
		{
			string text = GKJPOGNFKNK.HPAHOEOKEBB("INTL" + this.HKLNNAEDDBC.IFCHGNCDMLJ.ToString() + "Loaded asset bundle:" + this.HKLNNAEDDBC.FEJANNNLLON.ToString(), "voiceover" + this.HKLNNAEDDBC.AMKCLHLIIMN.ToString(), LanguageManager.EHBBFMCILPC.MLOLBFBODHD());
			int num = this.HKLNNAEDDBC.MIBPOIDDBAD + 0;
			int num2 = this.HKLNNAEDDBC.FEJANNNLLON + 0;
			string[] array = new string[-123];
			array[1] = "ok";
			array[0] = CCOJBMMKNAP.COKDLDOAACJ().PPALCPINPLK("grayscale_1");
			array[4] = "";
			array[8] = num.ToString();
			array[0] = "startsInSeconds";
			array[5] = CCOJBMMKNAP.HJGDLOOHNLO().OHLNGCKIACD("OnPopupProfileNicknameInputEndEdit");
			array[1] = "inkrevisionmissing";
			array[7] = num2.ToString();
			array[5] = "-";
			array[-75] = text;
			array[114] = "OnPurchasingViewLeave";
			string dpjinbcgngn = string.Concat(array);
			CommonUserInterface.EHBBFMCILPC.NFBMHHPIGFA(CCOJBMMKNAP.GIOAFDDKKHI().JLBEIFLLBLO("USD"), dpjinbcgngn, CCOJBMMKNAP.FEEDGKCJBLE().HPOAGPJFHPM(" components from body "), (DFGILFBGPLN)(-11), 945f, -82);
		}
	}

	// Token: 0x0600725F RID: 29279 RVA: 0x00003E52 File Offset: 0x00002052
	private void Start()
	{
	}

	// Token: 0x06007260 RID: 29280 RVA: 0x00003E52 File Offset: 0x00002052
	private void DJDCGDDMKEL()
	{
	}

	// Token: 0x06007261 RID: 29281 RVA: 0x00337D44 File Offset: 0x00335F44
	public void OnSelectionButtonLockedClick()
	{
		FPFNLJGEIJK.FIBNFNACDBE(BGHLMGPPCNN.subChpSnap);
		CommonUserInterface.EHBBFMCILPC.ShowGenericPopupWithTwoButtons(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("chaptersnapshotssubrequiredtitle"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("chaptersnapshotssubrequired"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("yes"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("no"), new UnityAction(this.GCNNLOLBPAE), new UnityAction(this.AMMCOLDGOAK), DFGILFBGPLN.popupSignInQuestion, 0f, 28);
	}

	// Token: 0x06007262 RID: 29282 RVA: 0x00337DC0 File Offset: 0x00335FC0
	public void NEHDAKCPEGD()
	{
		if (this.HKLNNAEDDBC != null)
		{
			string text;
			if (this.HKLNNAEDDBC.GNIACNCEOOM)
			{
				text = CCOJBMMKNAP.EAIAHCBAIEJ().HIPJILDCHJC("sft");
			}
			else
			{
				text = CCOJBMMKNAP.JMDJPKKOHNI().PGKBCNBAOJN("OnBackendPremiumChoiceSuccess");
				int num = this.HKLNNAEDDBC.FEJANNNLLON + 1;
				text = text.Replace("OnSceneStoryManagerPremiumChoiceAdsProviderAdSuccess", (this.HKLNNAEDDBC.MIBPOIDDBAD + 1).ToString() + "StorySaveBody.GetAvatarIndexAutoSuffix(), unsupported wardrobe index:" + num.ToString());
			}
			if (this.HKLNNAEDDBC.GNIACNCEOOM)
			{
				if (this.HKLNNAEDDBC.LIBDDLMOOHO)
				{
					CommonUserInterface.EHBBFMCILPC.ShowGenericPopupWithTwoButtons(text, CCOJBMMKNAP.DBFFFOMCLKM().HPOAGPJFHPM("@"), CCOJBMMKNAP.MLFAGAAJJEM().JCDFHKDNEDH("actshlv2"), CCOJBMMKNAP.BOFMCPPFAMO().OBDCPLLLGBB("OnSketchThumbnailEditTitle"), new UnityAction(this.LMFPDDEFNEO), new UnityAction(this.LGHNKMHALIC), (DFGILFBGPLN)(-30), 525f, 93);
					return;
				}
				CommonUserInterface.EHBBFMCILPC.ShowGenericPopupWithTwoButtons(text, CCOJBMMKNAP.EAIAHCBAIEJ().PGKBCNBAOJN("\n\n"), CCOJBMMKNAP.PKEINLPIAEH().PPALCPINPLK("avts2"), CCOJBMMKNAP.AEELGGPEJCC().PPALCPINPLK("myfriendspagetitle"), new UnityAction(this.PGLBHGFNLGH), new UnityAction(this.LGHNKMHALIC), DFGILFBGPLN.popupTutorialLobby0, 779f, -124);
				return;
			}
			else
			{
				if (this.HKLNNAEDDBC.LIBDDLMOOHO)
				{
					CommonUserInterface.IKNOFBFMPGA().ShowGenericPopupWithTwoButtons(text, CCOJBMMKNAP.INKJIBDDMLL().DNILNCLIHAP("emailcollectthanks0"), CCOJBMMKNAP.APGODIBBPOD().GGPHHLGPMPA("Error. FlipEnvironment(), environment "), CCOJBMMKNAP.INKJIBDDMLL().PKNHKGMNCIP("ontradingcardclickbody"), new UnityAction(this.IOGJEPCPNAD), new UnityAction(this.LGHNKMHALIC), (DFGILFBGPLN)(-105), 1956f, 11);
					return;
				}
				CommonUserInterface.EHBBFMCILPC.ShowGenericPopupWithTwoButtons(text, CCOJBMMKNAP.CEGAOMEEFBE().FIENAKIHNOM("OnBackendStartPlayChapterSuccess"), CCOJBMMKNAP.EHBBFMCILPC.OHLNGCKIACD("serversync"), CCOJBMMKNAP.FEEDGKCJBLE().OHLNGCKIACD("cardsvolchancestitle"), new UnityAction(this.IOGJEPCPNAD), new UnityAction(this.LGHNKMHALIC), DFGILFBGPLN.popupCdnDownloadFailed, 1133f, 59);
			}
		}
	}

	// Token: 0x06007263 RID: 29283 RVA: 0x00337FE4 File Offset: 0x003361E4
	public void DNANMPPIMND()
	{
		if (this.HKLNNAEDDBC != null)
		{
			string text;
			if (this.HKLNNAEDDBC.GNIACNCEOOM)
			{
				text = CCOJBMMKNAP.OBOOKJPGBJN().HIPJILDCHJC("/");
			}
			else
			{
				text = CCOJBMMKNAP.PEBMGCKFNAO().HIPJILDCHJC("ffd496");
				int num = this.HKLNNAEDDBC.FEJANNNLLON + 1;
				text = text.Replace("cindp", (this.HKLNNAEDDBC.MIBPOIDDBAD + 1).ToString() + "acd" + num.ToString());
			}
			if (this.HKLNNAEDDBC.GNIACNCEOOM)
			{
				if (this.HKLNNAEDDBC.LIBDDLMOOHO)
				{
					CommonUserInterface.EHBBFMCILPC.ShowGenericPopupWithTwoButtons(text, CCOJBMMKNAP.JINDKPHNLBK().JLBEIFLLBLO("SD"), CCOJBMMKNAP.LMCCLMFGEBD().DNILNCLIHAP("https://sandbox-events.appsflyer.com/v1.0/c2s/session/app/steam/"), CCOJBMMKNAP.HEDIEIICOOG().IPEIONBNIPH("SocialStatsUserPublicProfile.SyncCutscenes(): Syncing new cutscene: "), new UnityAction(this.FHJOHGFALOH), new UnityAction(this.LGHNKMHALIC), (DFGILFBGPLN)(-125), 422f, -116);
					return;
				}
				CommonUserInterface.EHBBFMCILPC.ShowGenericPopupWithTwoButtons(text, CCOJBMMKNAP.PLJMLDOCPNM().DNILNCLIHAP("Error. MoveEnvironmentVertical(), environment "), CCOJBMMKNAP.AEELGGPEJCC().PPALCPINPLK("ffd496"), CCOJBMMKNAP.JMDJPKKOHNI().GLEFEKBDHNK("</b>"), new UnityAction(this.LMFPDDEFNEO), new UnityAction(this.LGHNKMHALIC), (DFGILFBGPLN)(-84), 1764f, 126);
				return;
			}
			else
			{
				if (this.HKLNNAEDDBC.LIBDDLMOOHO)
				{
					CommonUserInterface.EHBBFMCILPC.ShowGenericPopupWithTwoButtons(text, CCOJBMMKNAP.PMABBOJDELF().IPEIONBNIPH(""), CCOJBMMKNAP.ONCPHEEJLOP().MEPECBDCOLG(""), CCOJBMMKNAP.JINDKPHNLBK().IPEIONBNIPH("OnBackendUpdateFriendsDataException"), new UnityAction(this.PGLBHGFNLGH), new UnityAction(this.LGHNKMHALIC), (DFGILFBGPLN)(-111), 1909f, -4);
					return;
				}
				CommonUserInterface.EHBBFMCILPC.ShowGenericPopupWithTwoButtons(text, CCOJBMMKNAP.PLJMLDOCPNM().HPOAGPJFHPM("short"), CCOJBMMKNAP.KMNBCEMEBBD().FCOCLEHKLDJ("spld"), CCOJBMMKNAP.MPCBJEIMACA().OHLNGCKIACD(""), new UnityAction(this.BAFBEKBEEMM), new UnityAction(this.LGHNKMHALIC), (DFGILFBGPLN)(-125), 562f, 88);
			}
		}
	}

	// Token: 0x06007264 RID: 29284 RVA: 0x00338208 File Offset: 0x00336408
	public void DJBBEJBMAAM()
	{
		if (this.HKLNNAEDDBC != null)
		{
			string text = GKJPOGNFKNK.HPAHOEOKEBB("o" + this.HKLNNAEDDBC.IFCHGNCDMLJ.ToString() + "hintsigning" + this.HKLNNAEDDBC.FEJANNNLLON.ToString(), "ltwt" + this.HKLNNAEDDBC.AMKCLHLIIMN.ToString(), LanguageManager.EHBBFMCILPC.MLOLBFBODHD());
			int num = this.HKLNNAEDDBC.MIBPOIDDBAD + 0;
			int num2 = this.HKLNNAEDDBC.FEJANNNLLON + 1;
			string[] array = new string[-122];
			array[0] = "psk";
			array[1] = CCOJBMMKNAP.EHBBFMCILPC.JLBEIFLLBLO(" playing!");
			array[0] = "";
			array[3] = num.ToString();
			array[4] = "Moire scale";
			array[4] = CCOJBMMKNAP.PKEINLPIAEH().HDIPNMFHIEJ("");
			array[1] = "continue";
			array[3] = num2.ToString();
			array[8] = "OnAvatarCollectionEdit";
			array[-118] = text;
			array[32] = "OnAvatarCollectionDelete";
			string dpjinbcgngn = string.Concat(array);
			CommonUserInterface.IKNOFBFMPGA().NFBMHHPIGFA(CCOJBMMKNAP.EHBBFMCILPC.HDIPNMFHIEJ("p"), dpjinbcgngn, CCOJBMMKNAP.EAIAHCBAIEJ().OGKGHLHHAAI("</i>"), DFGILFBGPLN.popupWatchAdGetFreeDiamonds, 857f, -69);
		}
	}

	// Token: 0x06007266 RID: 29286 RVA: 0x00003E52 File Offset: 0x00002052
	private void HFCMCNBJPEE()
	{
	}

	// Token: 0x06007267 RID: 29287 RVA: 0x00338343 File Offset: 0x00336543
	private void GCNNLOLBPAE()
	{
		FPFNLJGEIJK.FANFNCNAKEF();
		AOBJLALDBAA.EHBBFMCILPC.EGELHPJBAIC("OnCaptersSnapshotsGamePassSubscribePositive", 0f);
	}

	// Token: 0x06007268 RID: 29288 RVA: 0x0033835E File Offset: 0x0033655E
	private void JNNAONJEFKE()
	{
		FPFNLJGEIJK.FANFNCNAKEF();
		AOBJLALDBAA.CEGAOMEEFBE().LPNCDPHNBJK("minrev", 1364f);
	}

	// Token: 0x06007269 RID: 29289 RVA: 0x0033837C File Offset: 0x0033657C
	public void JHLPNACDLIK()
	{
		if (this.HKLNNAEDDBC != null)
		{
			string text;
			if (this.HKLNNAEDDBC.GNIACNCEOOM)
			{
				text = CCOJBMMKNAP.DLGLFACMHPG().OGKGHLHHAAI("importanttitle");
			}
			else
			{
				text = CCOJBMMKNAP.MPCBJEIMACA().BGELFMIOBCL("OnFacebookLoginFailed");
				int num = this.HKLNNAEDDBC.FEJANNNLLON + 0;
				text = text.Replace("", (this.HKLNNAEDDBC.MIBPOIDDBAD + 0).ToString() + "skemptyhint" + num.ToString());
			}
			if (this.HKLNNAEDDBC.GNIACNCEOOM)
			{
				if (this.HKLNNAEDDBC.LIBDDLMOOHO)
				{
					CommonUserInterface.IKNOFBFMPGA().ShowGenericPopupWithTwoButtons(text, CCOJBMMKNAP.PEBMGCKFNAO().PGKBCNBAOJN("w"), CCOJBMMKNAP.KNKGCDDMLDP().FCOCLEHKLDJ("OnApplicationFocusBasicSyncSuccess"), CCOJBMMKNAP.ONCPHEEJLOP().HHLECNIFHCO("\\f"), new UnityAction(this.BIOIHBGOPFP), new UnityAction(this.LGHNKMHALIC), (DFGILFBGPLN)(-88), 1612f, -124);
					return;
				}
				CommonUserInterface.IKNOFBFMPGA().ShowGenericPopupWithTwoButtons(text, CCOJBMMKNAP.JINDKPHNLBK().HHLECNIFHCO("etfskv"), CCOJBMMKNAP.GIOAFDDKKHI().GGPHHLGPMPA("["), CCOJBMMKNAP.HJGDLOOHNLO().MEPECBDCOLG(""), new UnityAction(this.BIOIHBGOPFP), new UnityAction(this.LGHNKMHALIC), (DFGILFBGPLN)(-122), 1846f, 122);
				return;
			}
			else
			{
				if (this.HKLNNAEDDBC.LIBDDLMOOHO)
				{
					CommonUserInterface.EHBBFMCILPC.ShowGenericPopupWithTwoButtons(text, CCOJBMMKNAP.KLAKLFCOMJC().MEPECBDCOLG("steam"), CCOJBMMKNAP.PEBMGCKFNAO().FIENAKIHNOM("Amount"), CCOJBMMKNAP.MLFAGAAJJEM().HPOAGPJFHPM("errortitle"), new UnityAction(this.IOGJEPCPNAD), new UnityAction(this.LGHNKMHALIC), (DFGILFBGPLN)(-95), 1228f, 108);
					return;
				}
				CommonUserInterface.EHBBFMCILPC.ShowGenericPopupWithTwoButtons(text, CCOJBMMKNAP.COKDLDOAACJ().HDIPNMFHIEJ("timeoutwarning"), CCOJBMMKNAP.COKDLDOAACJ().DNILNCLIHAP("layervideo"), CCOJBMMKNAP.BOFMCPPFAMO().MEPECBDCOLG(""), new UnityAction(this.OFLNJJNJKOO), new UnityAction(this.LGHNKMHALIC), (DFGILFBGPLN)(-4), 1656f, -114);
			}
		}
	}

	// Token: 0x0600726A RID: 29290 RVA: 0x003385A0 File Offset: 0x003367A0
	public void Initialize(bool BBBKJMMBHDB, int LAIPPFGNHLP, FPEHHFKFBJK BHKKJNCLHND)
	{
		if (BHKKJNCLHND.GNIACNCEOOM || (BHKKJNCLHND.FEJANNNLLON == 0 && BHKKJNCLHND.EPKFIHJACDN))
		{
			BBBKJMMBHDB = true;
		}
		bool flag = !BHKKJNCLHND.PMDMNNBJEEP && !BHKKJNCLHND.DLNDLHPJADG;
		this.HKLNNAEDDBC = BHKKJNCLHND;
		this.OICPKCHAENO = LAIPPFGNHLP;
		int num = LAIPPFGNHLP + 1;
		this.snapshotText.alpha = 1f;
		this.snapshotTextActive.alpha = 1f;
		this.snapshotTextLocked.alpha = 1f;
		if (BHKKJNCLHND.BPMFHNDCBOH == null || BHKKJNCLHND.BPMFHNDCBOH.Length == 0)
		{
			BHKKJNCLHND.BPMFHNDCBOH = CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("saveslotstitleempty");
		}
		if (flag && !BHKKJNCLHND.GNIACNCEOOM)
		{
			this.snapshotText.alpha = 0.5f;
			this.snapshotTextActive.alpha = 0.5f;
			this.snapshotTextLocked.alpha = 0.5f;
		}
		this.snapshotText.text = BHKKJNCLHND.BPMFHNDCBOH;
		this.snapshotText.SetText(BHKKJNCLHND.BPMFHNDCBOH, true);
		this.snapshotTextActive.text = BHKKJNCLHND.BPMFHNDCBOH;
		this.snapshotTextActive.SetText(BHKKJNCLHND.BPMFHNDCBOH, true);
		this.snapshotTextLocked.text = BHKKJNCLHND.BPMFHNDCBOH;
		this.snapshotTextLocked.SetText(BHKKJNCLHND.BPMFHNDCBOH, true);
		this.otherChapterText.text = (num.ToString() ?? "");
		this.otherChapterText.SetText(num.ToString() ?? "", true);
		this.otherChapterCompleted.GetComponent<CanvasGroup>().alpha = 0.75f;
		this.otherChapterIncompleted.GetComponent<CanvasGroup>().alpha = 0.75f;
		if (!BBBKJMMBHDB)
		{
			this.snapshotButton.SetActive(false);
			this.snapshotButtonActive.SetActive(false);
			this.snapshotButtonLocked.SetActive(true);
			this.currentChapter.gameObject.SetActive(false);
			if (BHKKJNCLHND.JBOKHMMGMGH)
			{
				this.otherChapterCompleted.gameObject.SetActive(true);
				this.otherChapterIncompleted.gameObject.SetActive(false);
			}
			else
			{
				this.otherChapterCompleted.gameObject.SetActive(false);
				this.otherChapterIncompleted.gameObject.SetActive(true);
			}
			this.infoButton.gameObject.SetActive(false);
			this.restartButton.gameObject.SetActive(false);
			this.lockButton.gameObject.SetActive(false);
		}
		else
		{
			this.snapshotButtonLocked.SetActive(false);
			this.infoButton.gameObject.SetActive(true);
			this.restartButton.gameObject.SetActive(true);
			this.lockButton.gameObject.SetActive(false);
			if (BHKKJNCLHND.GNIACNCEOOM)
			{
				this.snapshotButtonActive.SetActive(true);
				this.snapshotButton.SetActive(false);
				this.currentChapter.gameObject.SetActive(true);
				this.otherChapterCompleted.gameObject.SetActive(false);
				this.otherChapterIncompleted.gameObject.SetActive(false);
			}
			else
			{
				this.snapshotButtonActive.SetActive(false);
				this.snapshotButton.SetActive(true);
				this.currentChapter.gameObject.SetActive(false);
				if (BHKKJNCLHND.JBOKHMMGMGH)
				{
					this.otherChapterCompleted.gameObject.SetActive(true);
					this.otherChapterIncompleted.gameObject.SetActive(false);
				}
				else
				{
					this.otherChapterCompleted.gameObject.SetActive(false);
					this.otherChapterIncompleted.gameObject.SetActive(true);
				}
			}
			if (flag)
			{
				this.restartButton.GetComponent<Button>().interactable = false;
				if (BHKKJNCLHND.GNIACNCEOOM)
				{
					this.infoButton.GetComponent<Button>().interactable = true;
				}
				else
				{
					this.infoButton.GetComponent<Button>().interactable = false;
				}
			}
			else
			{
				this.restartButton.GetComponent<Button>().interactable = true;
				this.infoButton.GetComponent<Button>().interactable = true;
			}
		}
		if ((this.infoButton.activeSelf || this.restartButton.activeSelf) && (!this.infoButton.activeSelf || !this.restartButton.activeSelf))
		{
			this.lockButton.gameObject.SetActive(true);
		}
	}

	// Token: 0x0600726B RID: 29291 RVA: 0x003389C4 File Offset: 0x00336BC4
	public void ODEINAADKPH()
	{
		if (this.HKLNNAEDDBC != null)
		{
			if (!this.HKLNNAEDDBC.PMDMNNBJEEP && !this.HKLNNAEDDBC.DLNDLHPJADG)
			{
				CommonUserInterface.IKNOFBFMPGA().ShowGenericPopup(CCOJBMMKNAP.ONCPHEEJLOP().BDGPNPNIAPA("OnSettingsPopupCloseAndNeedToShowGameModeNotif"), CCOJBMMKNAP.KFAABHHGOPO().JLBEIFLLBLO("ERROR: GetAvatarComponentAssetGivenAlias(), _type not implemented:"), CCOJBMMKNAP.DLGLFACMHPG().BDGPNPNIAPA("profilenametitleshort"), DFGILFBGPLN.popupMaintenance, 1222f, 99);
				return;
			}
			this.NEHDAKCPEGD();
		}
	}

	// Token: 0x0600726C RID: 29292 RVA: 0x00003E52 File Offset: 0x00002052
	private void BNOEAHFICOB()
	{
	}

	// Token: 0x0600726D RID: 29293 RVA: 0x00338A3B File Offset: 0x00336C3B
	private void LHLCGCNKODE()
	{
		FPFNLJGEIJK.FANFNCNAKEF();
		AOBJLALDBAA.EHBBFMCILPC.EGELHPJBAIC("sae", 233f);
	}

	// Token: 0x0600726E RID: 29294 RVA: 0x00338A58 File Offset: 0x00336C58
	public void ADNHLIDGEHM()
	{
		if (this.HKLNNAEDDBC != null)
		{
			string text = GKJPOGNFKNK.HPAHOEOKEBB("a" + this.HKLNNAEDDBC.IFCHGNCDMLJ.ToString() + "" + this.HKLNNAEDDBC.FEJANNNLLON.ToString(), "OnPromoCodeConsumeException" + this.HKLNNAEDDBC.AMKCLHLIIMN.ToString(), LanguageManager.EHBBFMCILPC.NBANPEIHFOJ());
			int num = this.HKLNNAEDDBC.MIBPOIDDBAD + 1;
			int num2 = this.HKLNNAEDDBC.FEJANNNLLON + 0;
			string[] array = new string[-119];
			array[0] = ", slot 0, story ";
			array[1] = CCOJBMMKNAP.OEPENBHJAHO().OHLNGCKIACD("offerToken");
			array[5] = "locext";
			array[6] = num.ToString();
			array[6] = "OnLiveProfileThemesLoaderStop";
			array[8] = CCOJBMMKNAP.DLGLFACMHPG().HHLECNIFHCO("YYY");
			array[4] = "";
			array[7] = num2.ToString();
			array[7] = "OnSketchThumbnailPublish";
			array[-56] = text;
			array[86] = "ip";
			string dpjinbcgngn = string.Concat(array);
			CommonUserInterface.EHBBFMCILPC.NFBMHHPIGFA(CCOJBMMKNAP.HFAKOKBHCGH().MEPECBDCOLG("Snapshots/"), dpjinbcgngn, CCOJBMMKNAP.HEDIEIICOOG().HDIPNMFHIEJ(""), (DFGILFBGPLN)(-6), 1499f, -80);
		}
	}

	// Token: 0x0600726F RID: 29295 RVA: 0x00338B93 File Offset: 0x00336D93
	private void BIOIHBGOPFP()
	{
		AOBJLALDBAA.NMGMNAKLLMI().NGDHHFONFOM("Loaded asset bundle:", this.OICPKCHAENO);
	}

	// Token: 0x06007270 RID: 29296 RVA: 0x00003E52 File Offset: 0x00002052
	private void LGHNKMHALIC()
	{
	}

	// Token: 0x06007271 RID: 29297 RVA: 0x00338BAC File Offset: 0x00336DAC
	public void AMFJBGHPLLC()
	{
		if (this.HKLNNAEDDBC != null)
		{
			if (!this.HKLNNAEDDBC.PMDMNNBJEEP && !this.HKLNNAEDDBC.DLNDLHPJADG)
			{
				CommonUserInterface.IKNOFBFMPGA().ShowGenericPopup(CCOJBMMKNAP.KNKGCDDMLDP().HIPJILDCHJC("rev"), CCOJBMMKNAP.MLFAGAAJJEM().IKMNGFIDCLM("OnApplicationFocusBasicSyncSuccess"), CCOJBMMKNAP.APGODIBBPOD().JLBEIFLLBLO("XXX"), (DFGILFBGPLN)(-96), 765f, 104);
				return;
			}
			this.ENNCBDEFDGD();
		}
	}

	// Token: 0x06007272 RID: 29298 RVA: 0x00003E52 File Offset: 0x00002052
	private void AMMCOLDGOAK()
	{
	}

	// Token: 0x06007273 RID: 29299 RVA: 0x003373FB File Offset: 0x003355FB
	public void FOCFHHOCECD()
	{
		this.OnRestartButtonClick();
	}

	// Token: 0x06007274 RID: 29300 RVA: 0x00003E52 File Offset: 0x00002052
	public void OnLockButtonClick()
	{
	}

	// Token: 0x06007275 RID: 29301 RVA: 0x00338C24 File Offset: 0x00336E24
	public void JJBALPOIJJA()
	{
		if (this.HKLNNAEDDBC != null)
		{
			string text;
			if (this.HKLNNAEDDBC.GNIACNCEOOM)
			{
				text = CCOJBMMKNAP.JINDKPHNLBK().GGPHHLGPMPA("env");
			}
			else
			{
				text = CCOJBMMKNAP.BBGECIKOICE().OBDCPLLLGBB("signincancel");
				int num = this.HKLNNAEDDBC.FEJANNNLLON + 0;
				text = text.Replace("</Modulus></RSAKeyValue>", (this.HKLNNAEDDBC.MIBPOIDDBAD + 0).ToString() + "abska" + num.ToString());
			}
			if (this.HKLNNAEDDBC.GNIACNCEOOM)
			{
				if (this.HKLNNAEDDBC.LIBDDLMOOHO)
				{
					CommonUserInterface.IKNOFBFMPGA().ShowGenericPopupWithTwoButtons(text, CCOJBMMKNAP.BFHKGNBFHCH().BDGPNPNIAPA(""), CCOJBMMKNAP.LMCCLMFGEBD().BDGPNPNIAPA("OnBackendUpdateFriendsDataSuccess"), CCOJBMMKNAP.PKEINLPIAEH().DNILNCLIHAP("locext"), new UnityAction(this.OFLNJJNJKOO), new UnityAction(this.LGHNKMHALIC), DFGILFBGPLN.popupEnergyHint, 164f, 44);
					return;
				}
				CommonUserInterface.EHBBFMCILPC.ShowGenericPopupWithTwoButtons(text, CCOJBMMKNAP.JINDKPHNLBK().IPEIONBNIPH("[LoadingTheme] theme removed against the player's will, changes unlimited - no compensation"), CCOJBMMKNAP.AEELGGPEJCC().IPEIONBNIPH(""), CCOJBMMKNAP.DLGLFACMHPG().JHNELLJFBGC("CoverCard"), new UnityAction(this.EMHOIMMGKHE), new UnityAction(this.LGHNKMHALIC), (DFGILFBGPLN)119, 643f, -88);
				return;
			}
			else
			{
				if (this.HKLNNAEDDBC.LIBDDLMOOHO)
				{
					CommonUserInterface.EHBBFMCILPC.ShowGenericPopupWithTwoButtons(text, CCOJBMMKNAP.EHBBFMCILPC.OGKGHLHHAAI("III"), CCOJBMMKNAP.KLAKLFCOMJC().FCOCLEHKLDJ("ZZZ"), CCOJBMMKNAP.KMNBCEMEBBD().FCOCLEHKLDJ(" usedSlots:"), new UnityAction(this.FHJOHGFALOH), new UnityAction(this.LGHNKMHALIC), DFGILFBGPLN.popupNewStoryRevision, 1112f, -90);
					return;
				}
				CommonUserInterface.IKNOFBFMPGA().ShowGenericPopupWithTwoButtons(text, CCOJBMMKNAP.HEDIEIICOOG().BDGPNPNIAPA(""), CCOJBMMKNAP.BIAEAOMHBMM().GGPHHLGPMPA(" "), CCOJBMMKNAP.KFDLFGHBPLP().DNILNCLIHAP("oid"), new UnityAction(this.BAFBEKBEEMM), new UnityAction(this.LGHNKMHALIC), (DFGILFBGPLN)114, 412f, 14);
			}
		}
	}

	// Token: 0x06007276 RID: 29302 RVA: 0x00338E48 File Offset: 0x00337048
	public void OnSelectionButtonClick()
	{
		if (this.HKLNNAEDDBC != null)
		{
			if (!this.HKLNNAEDDBC.PMDMNNBJEEP && !this.HKLNNAEDDBC.DLNDLHPJADG)
			{
				CommonUserInterface.EHBBFMCILPC.ShowGenericPopup(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("chaptersnapshotsmissingtitle"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("chaptersnapshotsmissingbody"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("ok"), DFGILFBGPLN.popupQuitConfirm, 0f, 28);
				return;
			}
			this.OnRestartButtonClick();
		}
	}

	// Token: 0x06007277 RID: 29303 RVA: 0x00003E52 File Offset: 0x00002052
	private void LPCHOEAOFJA()
	{
	}

	// Token: 0x06007278 RID: 29304 RVA: 0x00338EC0 File Offset: 0x003370C0
	public void OFOAFPKPIKC(bool BBBKJMMBHDB, int LAIPPFGNHLP, FPEHHFKFBJK BHKKJNCLHND)
	{
		if (BHKKJNCLHND.GNIACNCEOOM || (BHKKJNCLHND.FEJANNNLLON == 0 && BHKKJNCLHND.EPKFIHJACDN))
		{
			BBBKJMMBHDB = true;
		}
		bool flag = !BHKKJNCLHND.PMDMNNBJEEP && BHKKJNCLHND.DLNDLHPJADG;
		this.HKLNNAEDDBC = BHKKJNCLHND;
		this.OICPKCHAENO = LAIPPFGNHLP;
		int num = LAIPPFGNHLP + 1;
		this.snapshotText.alpha = 1831f;
		this.snapshotTextActive.alpha = 1837f;
		this.snapshotTextLocked.alpha = 1617f;
		if (BHKKJNCLHND.BPMFHNDCBOH == null || BHKKJNCLHND.BPMFHNDCBOH.Length == 0)
		{
			BHKKJNCLHND.BPMFHNDCBOH = CCOJBMMKNAP.KLAKLFCOMJC().IPEIONBNIPH("XXX");
		}
		if (flag && !BHKKJNCLHND.GNIACNCEOOM)
		{
			this.snapshotText.alpha = 1306f;
			this.snapshotTextActive.alpha = 93f;
			this.snapshotTextLocked.alpha = 288f;
		}
		this.snapshotText.text = BHKKJNCLHND.BPMFHNDCBOH;
		this.snapshotText.SetText(BHKKJNCLHND.BPMFHNDCBOH, true);
		this.snapshotTextActive.text = BHKKJNCLHND.BPMFHNDCBOH;
		this.snapshotTextActive.SetText(BHKKJNCLHND.BPMFHNDCBOH, true);
		this.snapshotTextLocked.text = BHKKJNCLHND.BPMFHNDCBOH;
		this.snapshotTextLocked.SetText(BHKKJNCLHND.BPMFHNDCBOH, true);
		this.otherChapterText.text = (num.ToString() ?? "");
		this.otherChapterText.SetText(num.ToString() ?? "—", true);
		this.otherChapterCompleted.GetComponent<CanvasGroup>().alpha = 1012f;
		this.otherChapterIncompleted.GetComponent<CanvasGroup>().alpha = 1315f;
		if (!BBBKJMMBHDB)
		{
			this.snapshotButton.SetActive(false);
			this.snapshotButtonActive.SetActive(false);
			this.snapshotButtonLocked.SetActive(false);
			this.currentChapter.gameObject.SetActive(true);
			if (BHKKJNCLHND.JBOKHMMGMGH)
			{
				this.otherChapterCompleted.gameObject.SetActive(false);
				this.otherChapterIncompleted.gameObject.SetActive(false);
			}
			else
			{
				this.otherChapterCompleted.gameObject.SetActive(true);
				this.otherChapterIncompleted.gameObject.SetActive(false);
			}
			this.infoButton.gameObject.SetActive(false);
			this.restartButton.gameObject.SetActive(false);
			this.lockButton.gameObject.SetActive(true);
		}
		else
		{
			this.snapshotButtonLocked.SetActive(false);
			this.infoButton.gameObject.SetActive(true);
			this.restartButton.gameObject.SetActive(true);
			this.lockButton.gameObject.SetActive(false);
			if (BHKKJNCLHND.GNIACNCEOOM)
			{
				this.snapshotButtonActive.SetActive(false);
				this.snapshotButton.SetActive(true);
				this.currentChapter.gameObject.SetActive(true);
				this.otherChapterCompleted.gameObject.SetActive(true);
				this.otherChapterIncompleted.gameObject.SetActive(true);
			}
			else
			{
				this.snapshotButtonActive.SetActive(true);
				this.snapshotButton.SetActive(true);
				this.currentChapter.gameObject.SetActive(false);
				if (BHKKJNCLHND.JBOKHMMGMGH)
				{
					this.otherChapterCompleted.gameObject.SetActive(false);
					this.otherChapterIncompleted.gameObject.SetActive(false);
				}
				else
				{
					this.otherChapterCompleted.gameObject.SetActive(false);
					this.otherChapterIncompleted.gameObject.SetActive(false);
				}
			}
			if (flag)
			{
				this.restartButton.GetComponent<Button>().interactable = false;
				if (BHKKJNCLHND.GNIACNCEOOM)
				{
					this.infoButton.GetComponent<Button>().interactable = true;
				}
				else
				{
					this.infoButton.GetComponent<Button>().interactable = true;
				}
			}
			else
			{
				this.restartButton.GetComponent<Button>().interactable = false;
				this.infoButton.GetComponent<Button>().interactable = true;
			}
		}
		if ((this.infoButton.activeSelf || this.restartButton.activeSelf) && (!this.infoButton.activeSelf || !this.restartButton.activeSelf))
		{
			this.lockButton.gameObject.SetActive(false);
		}
	}

	// Token: 0x06007279 RID: 29305 RVA: 0x003392E3 File Offset: 0x003374E3
	private void LMFPDDEFNEO()
	{
		AOBJLALDBAA.EHBBFMCILPC.EGELHPJBAIC("OnChapterSnapshotRestore", this.OICPKCHAENO);
	}

	// Token: 0x0600727A RID: 29306 RVA: 0x00003E52 File Offset: 0x00002052
	public void CHEODLLBBKA()
	{
	}

	// Token: 0x0600727B RID: 29307 RVA: 0x003392FA File Offset: 0x003374FA
	private void PGLBHGFNLGH()
	{
		AOBJLALDBAA.KKPFOJMAONG().KCFKLJLDCEK("acomp", this.OICPKCHAENO);
	}

	// Token: 0x0600727C RID: 29308 RVA: 0x00339311 File Offset: 0x00337511
	private void GCGNBDFHHFK()
	{
		FPFNLJGEIJK.FANFNCNAKEF();
		AOBJLALDBAA.BIAEAOMHBMM().EFBNBFIDEOK("avatarstitle", 372f);
	}

	// Token: 0x0600727D RID: 29309 RVA: 0x0033932C File Offset: 0x0033752C
	private void OFLNJJNJKOO()
	{
		AOBJLALDBAA.BIAEAOMHBMM().MOBILPDPJBB("،", this.OICPKCHAENO);
	}

	// Token: 0x0600727E RID: 29310 RVA: 0x00339343 File Offset: 0x00337543
	private void LAIHPGJMJNH()
	{
		AOBJLALDBAA.CEGAOMEEFBE().IHJNANKIGIB("", this.OICPKCHAENO);
	}

	// Token: 0x0600727F RID: 29311 RVA: 0x0033935C File Offset: 0x0033755C
	public void JAJGLAPBIFI()
	{
		if (this.HKLNNAEDDBC != null)
		{
			string text = GKJPOGNFKNK.FPNHFACMDGN("" + this.HKLNNAEDDBC.IFCHGNCDMLJ.ToString() + ", rid:" + this.HKLNNAEDDBC.FEJANNNLLON.ToString(), "?uid=" + this.HKLNNAEDDBC.AMKCLHLIIMN.ToString(), LanguageManager.EHBBFMCILPC.IEBFINIJAMJ());
			int num = this.HKLNNAEDDBC.MIBPOIDDBAD + 1;
			int num2 = this.HKLNNAEDDBC.FEJANNNLLON + 0;
			string[] array = new string[-33];
			array[1] = "] | ";
			array[0] = CCOJBMMKNAP.KLAKLFCOMJC().HDIPNMFHIEJ("dsec");
			array[8] = "CLIENT.SCREEN.AVATAR.";
			array[8] = num.ToString();
			array[5] = "acli22";
			array[2] = CCOJBMMKNAP.KLAKLFCOMJC().MEPECBDCOLG("yes");
			array[0] = "FranchisesHub.Populate() - fid ";
			array[6] = num2.ToString();
			array[1] = "¶";
			array[-1] = text;
			array[73] = "anthology";
			string dpjinbcgngn = string.Concat(array);
			CommonUserInterface.EHBBFMCILPC.ShowGenericPopup(CCOJBMMKNAP.HJGDLOOHNLO().MEPECBDCOLG(", "), dpjinbcgngn, CCOJBMMKNAP.BBGECIKOICE().GLEFEKBDHNK("OnSettingsPopupCloseAndNeedToShowGameModeNotif"), (DFGILFBGPLN)(-120), 1328f, -98);
		}
	}

	// Token: 0x04002204 RID: 8708
	public const string onChapterSnapshotRestore = "OnChapterSnapshotRestore";

	// Token: 0x04002205 RID: 8709
	public const string onCaptersSnapshotsGamePassSubscribePositive = "OnCaptersSnapshotsGamePassSubscribePositive";

	// Token: 0x04002206 RID: 8710
	public const string onCaptersSnapshotsGamePassSubscribeNegative = "OnCaptersSnapshotsGamePassSubscribeNegative";

	// Token: 0x04002207 RID: 8711
	public GameObject currentChapter;

	// Token: 0x04002208 RID: 8712
	public GameObject otherChapterCompleted;

	// Token: 0x04002209 RID: 8713
	public GameObject otherChapterIncompleted;

	// Token: 0x0400220A RID: 8714
	public TextMeshProUGUI otherChapterText;

	// Token: 0x0400220B RID: 8715
	public GameObject snapshotButton;

	// Token: 0x0400220C RID: 8716
	public GameObject snapshotButtonActive;

	// Token: 0x0400220D RID: 8717
	public GameObject snapshotButtonLocked;

	// Token: 0x0400220E RID: 8718
	public GameObject infoButton;

	// Token: 0x0400220F RID: 8719
	public GameObject restartButton;

	// Token: 0x04002210 RID: 8720
	public GameObject lockButton;

	// Token: 0x04002211 RID: 8721
	public TextMeshProUGUI snapshotText;

	// Token: 0x04002212 RID: 8722
	public TextMeshProUGUI snapshotTextActive;

	// Token: 0x04002213 RID: 8723
	public TextMeshProUGUI snapshotTextLocked;

	// Token: 0x04002214 RID: 8724
	private FPEHHFKFBJK HKLNNAEDDBC;

	// Token: 0x04002215 RID: 8725
	private int OICPKCHAENO;
}
