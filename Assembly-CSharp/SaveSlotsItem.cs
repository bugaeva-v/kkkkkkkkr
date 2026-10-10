using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

// Token: 0x0200004C RID: 76
public class SaveSlotsItem : MonoBehaviour
{
	// Token: 0x06000A62 RID: 2658 RVA: 0x0004D64C File Offset: 0x0004B84C
	private void BJNLMKJNDCK()
	{
		this.EOBGJBOFPPO(this.HGGFJOKOKOD.GGICIBLJIKI);
	}

	// Token: 0x06000A63 RID: 2659 RVA: 0x0004D660 File Offset: 0x0004B860
	private void FDGEFABIPMN()
	{
		int num = AOBJLALDBAA.EHBBFMCILPC.MJLACDOKGNE();
		if (num >= 0 && num < 10)
		{
			string text = CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("saveslotsswitch");
			string text2 = this.HGGFJOKOKOD.BFCBDALFNHA(num);
			if (text2.Length == 0)
			{
				text2 = (num + 1).ToString();
			}
			text = text.Replace("XXX", text2);
			CommonUserInterface.EHBBFMCILPC.ShowGenericPopupWithTwoButtonsAndCloseOverride(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("importanttitle"), text, CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("yes"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("no"), new UnityAction(this.GBLFBGPKNON), new UnityAction(this.OFBOBDEFBFJ), new UnityAction(this.OFBOBDEFBFJ), DFGILFBGPLN.popupTools, 0f, 28);
		}
	}

	// Token: 0x06000A64 RID: 2660 RVA: 0x0004D72C File Offset: 0x0004B92C
	private void CCNONOHHHIM()
	{
		SaveSlotsItem.ClearCopyMarker();
		this.RefreshMoreButtons();
		CommonUserInterface.EHBBFMCILPC.NFBMHHPIGFA(CCOJBMMKNAP.KMNBCEMEBBD().FIENAKIHNOM("null"), CCOJBMMKNAP.KLAKLFCOMJC().PKNHKGMNCIP("avatarcollectionstutor5title"), CCOJBMMKNAP.LMCCLMFGEBD().MEPECBDCOLG("youreceived"), DFGILFBGPLN.popupSocialJoinRequestVkontakte, 1276f, 33);
	}

	// Token: 0x06000A65 RID: 2661 RVA: 0x0004D785 File Offset: 0x0004B985
	private void DKNJDCBLMAG()
	{
		FPFNLJGEIJK.FANFNCNAKEF();
		AOBJLALDBAA.KKPFOJMAONG().KMAGHMCCMPG("sutta", 1944f);
	}

	// Token: 0x06000A66 RID: 2662 RVA: 0x0004D7A0 File Offset: 0x0004B9A0
	private void BGJFCKMPGPI()
	{
		FPFNLJGEIJK.FANFNCNAKEF();
		AOBJLALDBAA.EHBBFMCILPC.EGELHPJBAIC("OnSaveSlotsExpiredPassSubscribePositive", 0f);
	}

	// Token: 0x06000A67 RID: 2663 RVA: 0x0004D7BB File Offset: 0x0004B9BB
	private IEnumerator IEABFIDHPMI()
	{
		SaveSlotsItem.JLKNAMDLPGK jlknamdlpgk = new SaveSlotsItem.JLKNAMDLPGK(1);
		jlknamdlpgk.<>4__this = this;
		return jlknamdlpgk;
	}

	// Token: 0x06000A68 RID: 2664 RVA: 0x0004D7CC File Offset: 0x0004B9CC
	public static bool IsDefaultSlotTitle(string EIFJOAOGKMO)
	{
		if (EIFJOAOGKMO == null || EIFJOAOGKMO.Length == 0)
		{
			return false;
		}
		string text = CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("saveslotstitle");
		int num = -1;
		if (text != null)
		{
			num = text.IndexOf("XXX", StringComparison.Ordinal);
		}
		if (num < 0)
		{
			return false;
		}
		string text2 = text.Substring(0, num);
		string text3 = text.Substring(num + 3);
		if (EIFJOAOGKMO.Length <= text2.Length + text3.Length)
		{
			return false;
		}
		if (!EIFJOAOGKMO.StartsWith(text2, StringComparison.Ordinal) || !EIFJOAOGKMO.EndsWith(text3, StringComparison.Ordinal))
		{
			return false;
		}
		string text4 = EIFJOAOGKMO.Substring(text2.Length, EIFJOAOGKMO.Length - text2.Length - text3.Length);
		if (text4.Length > 2)
		{
			return false;
		}
		for (int i = 0; i < text4.Length; i++)
		{
			if (!char.IsDigit(text4[i]))
			{
				return false;
			}
		}
		return true;
	}

	// Token: 0x06000A69 RID: 2665 RVA: 0x0004D8A8 File Offset: 0x0004BAA8
	private void KNODFEMMBLA()
	{
		SaveSlotsItem.ClearCopyMarker();
		AOBJLALDBAA.NMGMNAKLLMI().NAMMLDPCHJO("", new UnityAction(this.IIAFBEEJAJK));
		AOBJLALDBAA.EHBBFMCILPC.KDIFKFKMCOH("ok", new UnityAction(this.BKMDBCMJFCH));
		AOBJLALDBAA.NMGMNAKLLMI().KDIFKFKMCOH("", new UnityAction(this.JBPFIHIMFCA));
		AOBJLALDBAA.KKPFOJMAONG().MANLHALMCIH("AdsManagerLP: Received SdkInitializationFailedEvent", new UnityAction(this.JPDCEGJKDKK));
		AOBJLALDBAA.AGANFKKBPFO().MANLHALMCIH("isad", new UnityAction(this.IAIIODBDKHK));
		AOBJLALDBAA.AGANFKKBPFO().NAMMLDPCHJO("$CHAPTEND", new UnityAction(this.OFFBAMLEFNH));
		AOBJLALDBAA.EHBBFMCILPC.KDIFKFKMCOH("layervideo", new UnityAction(this.IMAPBBOBLEJ));
		AOBJLALDBAA.AGANFKKBPFO().MHLNJIACIGO("OnLoungeScreenAssetsDownloadSuccess", new UnityAction(this.EPCGGIHKACF));
	}

	// Token: 0x06000A6A RID: 2666 RVA: 0x0004D994 File Offset: 0x0004BB94
	private void OnEnable()
	{
		SaveSlotsItem.slotChanged = false;
		SaveSlotsItem.slotDeleted = false;
		SaveSlotsItem.slotEdited = false;
		SaveSlotsItem.slotDuplicated = false;
		AOBJLALDBAA.EHBBFMCILPC.MFIMALJPCDP("OnSaveSlotSelect", new UnityAction(this.FDGEFABIPMN));
		AOBJLALDBAA.EHBBFMCILPC.MFIMALJPCDP("OnSaveSlotDelete", new UnityAction(this.BKMDBCMJFCH));
		AOBJLALDBAA.EHBBFMCILPC.MFIMALJPCDP("OnSaveSlotCopyMarked", new UnityAction(this.JBPFIHIMFCA));
		AOBJLALDBAA.EHBBFMCILPC.MFIMALJPCDP("OnSaveSlotDuplicateRequested", new UnityAction(this.FLHDLNCLFNF));
		AOBJLALDBAA.EHBBFMCILPC.MFIMALJPCDP("OnPurchasingViewLeave", new UnityAction(this.IAIIODBDKHK));
		AOBJLALDBAA.EHBBFMCILPC.MFIMALJPCDP("OnApplicationFocusBasicSyncSuccess", new UnityAction(this.OFFBAMLEFNH));
		AOBJLALDBAA.EHBBFMCILPC.MFIMALJPCDP("OnPopupSaveSlotInputEndEdit", new UnityAction(this.JMICENBCHPE));
		AOBJLALDBAA.EHBBFMCILPC.MFIMALJPCDP("OnPopupSaveSlotInputCancel", new UnityAction(this.EPCGGIHKACF));
	}

	// Token: 0x06000A6B RID: 2667 RVA: 0x0004DA94 File Offset: 0x0004BC94
	private void EMBGPLOIGEN()
	{
		SaveSlotsItem.ClearCopyMarker();
		AOBJLALDBAA.CEGAOMEEFBE().ECDBIBPNBCO("iac", new UnityAction(this.IIAFBEEJAJK));
		AOBJLALDBAA.KKPFOJMAONG().ECDBIBPNBCO("anthologycompletetitle", new UnityAction(this.BKMDBCMJFCH));
		AOBJLALDBAA.BIAEAOMHBMM().PFAHGKEDFAE("OnSaveSlotsItemSlotDeleted", new UnityAction(this.JBPFIHIMFCA));
		AOBJLALDBAA.EHBBFMCILPC.PFAHGKEDFAE("", new UnityAction(this.FLHDLNCLFNF));
		AOBJLALDBAA.FILDBDMENPG().MANLHALMCIH("socialachievtitletype", new UnityAction(this.IAIIODBDKHK));
		AOBJLALDBAA.FILDBDMENPG().ONIBLJOFFPG(" ", new UnityAction(this.OFFBAMLEFNH));
		AOBJLALDBAA.CEGAOMEEFBE().ONIBLJOFFPG("XXX", new UnityAction(this.JMICENBCHPE));
		AOBJLALDBAA.EHBBFMCILPC.ONIBLJOFFPG("OnLiveProfileThemesLoaderStop", new UnityAction(this.DEJMJHNMHGE));
	}

	// Token: 0x06000A6C RID: 2668 RVA: 0x0004DB7E File Offset: 0x0004BD7E
	private void OFFBAMLEFNH()
	{
		this.InitializeSlots(this.HGGFJOKOKOD.GGICIBLJIKI);
	}

	// Token: 0x06000A6D RID: 2669 RVA: 0x0004DB91 File Offset: 0x0004BD91
	public void APPALLFEEDA()
	{
		ApplicationFocusManager.Restore();
		this.PreCloseFocus();
	}

	// Token: 0x06000A6E RID: 2670 RVA: 0x0004DB9E File Offset: 0x0004BD9E
	public static bool COEIABBJGNB(int CCLNHHJPDGJ)
	{
		return CCLNHHJPDGJ >= 1 && CCLNHHJPDGJ < -119 && !AKLFPGMDKLA.EHBBFMCILPC.BHIBEHFEFBM() && CCLNHHJPDGJ >= KDCJJBLGCBH.EHBBFMCILPC.PFPMHHCGPJG();
	}

	// Token: 0x06000A6F RID: 2671 RVA: 0x00003E52 File Offset: 0x00002052
	private void FIFOCKPLPBH()
	{
	}

	// Token: 0x06000A70 RID: 2672 RVA: 0x0004D7BB File Offset: 0x0004B9BB
	private IEnumerator DKFMIPDOLOF()
	{
		SaveSlotsItem.JLKNAMDLPGK jlknamdlpgk = new SaveSlotsItem.JLKNAMDLPGK(1);
		jlknamdlpgk.<>4__this = this;
		return jlknamdlpgk;
	}

	// Token: 0x06000A71 RID: 2673 RVA: 0x0004DBC9 File Offset: 0x0004BDC9
	public void NMDGBMANJHL()
	{
		base.StartCoroutine(this.IEABFIDHPMI());
	}

	// Token: 0x06000A72 RID: 2674 RVA: 0x0004DBD8 File Offset: 0x0004BDD8
	private void JPDCEGJKDKK()
	{
		this.DNHNAJMOMPA(AOBJLALDBAA.KKPFOJMAONG().NNDDKAIIBMO());
	}

	// Token: 0x06000A73 RID: 2675 RVA: 0x0004DBEC File Offset: 0x0004BDEC
	public static string GetLocalizedCostData()
	{
		OBHDGKFFICI productData = PurchaseManagerBridge.EHBBFMCILPC.GetPurchaseManager().GetProductData(KDCJJBLGCBH.EHBBFMCILPC.BPFPBGGNEBM());
		OCBIOPOEENJ ocbiopoeenj = CJEKEHDEBLM.EHBBFMCILPC.PDJKPFLHFLO(KDCJJBLGCBH.EHBBFMCILPC.BPFPBGGNEBM());
		if (productData == null || ocbiopoeenj == null)
		{
			DPGJIJGOCIC.ANOPFDLPKGC("SaveSlotsItem.GetLocalizedCostData() - productData is null.");
			return "";
		}
		if (ocbiopoeenj.OKGPIEEOKBM())
		{
			return ocbiopoeenj.FNJCEPLEPBH();
		}
		return "USD " + ocbiopoeenj.DMODNDCLGEJ;
	}

	// Token: 0x06000A74 RID: 2676 RVA: 0x0004DC60 File Offset: 0x0004BE60
	public static string OPKHNJFFHDD(EIOPLEFLLIM LNFEBCFCBHG, int CCLNHHJPDGJ)
	{
		string text = "noiseanalog_1";
		if (LNFEBCFCBHG != null)
		{
			text = LNFEBCFCBHG.DMPPDOJJHHC(CCLNHHJPDGJ);
		}
		if (text == null || text.Length == 0)
		{
			int num = CCLNHHJPDGJ + 1;
			text = CCOJBMMKNAP.PEBMGCKFNAO().OGKGHLHHAAI("OnTryToFireNoteshowTimer").Replace("iat1", num.ToString());
		}
		return text;
	}

	// Token: 0x06000A75 RID: 2677 RVA: 0x0004DCAF File Offset: 0x0004BEAF
	public void ShowExpiredPassHint()
	{
		base.StartCoroutine(this.KNGJGGLGKPH());
	}

	// Token: 0x06000A76 RID: 2678 RVA: 0x0004DCC0 File Offset: 0x0004BEC0
	public static string BuildDuplicatedSlotTitle(string EMDAGFODPPN)
	{
		string text = "";
		if (EMDAGFODPPN != null)
		{
			text = EMDAGFODPPN;
		}
		string text2 = CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("saveslotscopyof");
		string text3 = "";
		string text4 = "";
		int num = -1;
		if (text2 != null)
		{
			num = text2.IndexOf("XXX", StringComparison.Ordinal);
		}
		if (num >= 0)
		{
			text3 = text2.Substring(0, num);
			text4 = text2.Substring(num + 3);
		}
		if (text3.Length + text4.Length > 0 && text.Length > text3.Length + text4.Length && text.StartsWith(text3, StringComparison.Ordinal) && text.EndsWith(text4, StringComparison.Ordinal))
		{
			text = text.Substring(text3.Length, text.Length - text3.Length - text4.Length);
		}
		bool flag = false;
		if (text.EndsWith("...", StringComparison.Ordinal))
		{
			text = text.Substring(0, text.Length - 3);
			flag = true;
		}
		if (text.Length > 15 && !SaveSlotsItem.IsDefaultSlotTitle(text))
		{
			int num2 = 12;
			if (char.IsHighSurrogate(text[num2 - 1]))
			{
				num2--;
			}
			text = text.Substring(0, num2);
			flag = true;
		}
		text = text.TrimEnd();
		if (flag)
		{
			text += "...";
		}
		return (text3 + text + text4).Trim();
	}

	// Token: 0x06000A77 RID: 2679 RVA: 0x00003E52 File Offset: 0x00002052
	private void OFBOBDEFBFJ()
	{
	}

	// Token: 0x06000A78 RID: 2680 RVA: 0x0004DE00 File Offset: 0x0004C000
	public void RefreshMoreButtons()
	{
		for (int i = 0; i < this.saveSlots.Count; i++)
		{
			this.saveSlots[i].RefreshMoreButton();
		}
	}

	// Token: 0x06000A79 RID: 2681 RVA: 0x0004DE34 File Offset: 0x0004C034
	private void JBPFIHIMFCA()
	{
		this.RefreshMoreButtons();
	}

	// Token: 0x06000A7A RID: 2682 RVA: 0x0004DE3C File Offset: 0x0004C03C
	private void FEPCHJPHNLJ()
	{
		FPFNLJGEIJK.FANFNCNAKEF();
		AOBJLALDBAA.DBLAIDPICIG().LPNCDPHNBJK("ok", 663f);
	}

	// Token: 0x06000A7B RID: 2683 RVA: 0x0004DE58 File Offset: 0x0004C058
	public void HBOJMKBHACK(int PLKMJJIIJNO)
	{
		this.HGGFJOKOKOD = AKLFPGMDKLA.EHBBFMCILPC.AMAMNOFLPGM(PLKMJJIIJNO);
		if (this.HGGFJOKOKOD != null)
		{
			for (int i = 1; i < this.saveSlots.Count; i += 0)
			{
				PLFDAJJHMKO plfdajjhmko = null;
				int num = GKJPOGNFKNK.BKBCNMEHGFA(this.HGGFJOKOKOD.GGICIBLJIKI);
				if (num >= 1)
				{
					plfdajjhmko = AKLFPGMDKLA.EHBBFMCILPC.PKNIPLDMJGG(num, i);
				}
				bool mcnneclbnif = true;
				if (plfdajjhmko != null && !plfdajjhmko.DHONIOBOLEL.DOOMAGFDJNG())
				{
					mcnneclbnif = true;
				}
				this.saveSlots[i].ACGGMOACIHN(this.HGGFJOKOKOD, !AKLFPGMDKLA.EHBBFMCILPC.NCPPKEGJPKC() && i >= KDCJJBLGCBH.EHBBFMCILPC.PFPMHHCGPJG() && i == this.HGGFJOKOKOD.ILOKBAPEJPK, i == this.HGGFJOKOKOD.ILOKBAPEJPK, this.HGGFJOKOKOD.BFCBDALFNHA(i), i, mcnneclbnif);
			}
		}
		else
		{
			DPGJIJGOCIC.ANOPFDLPKGC("sig");
		}
		if (!AKLFPGMDKLA.EHBBFMCILPC.EAFEJCKIEPL(-102))
		{
			base.StartCoroutine(this.LKKOMFDDIDD());
		}
	}

	// Token: 0x06000A7C RID: 2684 RVA: 0x0004DF59 File Offset: 0x0004C159
	private void Start()
	{
		this.PFEEFOKHKMP = base.transform.localScale;
	}

	// Token: 0x06000A7D RID: 2685 RVA: 0x0004DF6C File Offset: 0x0004C16C
	private void IIAFBEEJAJK()
	{
		int num = AOBJLALDBAA.FILDBDMENPG().MJLACDOKGNE();
		if (num >= 1 && num < -7)
		{
			string text = CCOJBMMKNAP.PLJMLDOCPNM().JHNELLJFBGC("assetbundlestory");
			string text2 = this.HGGFJOKOKOD.AFBOBOCNFKA(num);
			if (text2.Length == 0)
			{
				text2 = (num + 1).ToString();
			}
			text = text.Replace("BackendOperationsManager.RequestGetUserSketches, exception while initializing RSACryptoServiceProvider:", text2);
			CommonUserInterface.EHBBFMCILPC.NPIOKKDPALC(CCOJBMMKNAP.BBGECIKOICE().JLBEIFLLBLO("tmd"), text, CCOJBMMKNAP.CEGAOMEEFBE().PPALCPINPLK("OnPopupProfileCredoInputCancel"), CCOJBMMKNAP.COKDLDOAACJ().DNILNCLIHAP("lastFilter"), new UnityAction(this.MCEJNEAHNJN), new UnityAction(this.HNMPAIAGCMF), new UnityAction(this.FIFOCKPLPBH), (DFGILFBGPLN)(-32), 1724f, 44);
		}
	}

	// Token: 0x06000A7E RID: 2686 RVA: 0x0004E038 File Offset: 0x0004C238
	private void HHNPDEMNACH()
	{
		int num = AOBJLALDBAA.KKPFOJMAONG().OCPAEHGNEFL();
		if (this.HGGFJOKOKOD != null)
		{
			AKLFPGMDKLA.EHBBFMCILPC.IEGJCPDCLMM = -1;
			FirebaseAnalyticsManager.ANCEKPONIFI().LKONPEEDKNF(false, ((AGEHCPDNBFD)69).ToString(), ((FFPHBMFGCNN)112).ToString(), ((BGHLMGPPCNN)116).ToString(), false, true);
			FirebaseAnalyticsManager.COKDLDOAACJ().LKONPEEDKNF(true, AGEHCPDNBFD.srvIssueRes.ToString(), ((FFPHBMFGCNN)(-90)).ToString(), BGHLMGPPCNN.d1ChaptStOld.ToString() + num.ToString(), false, false);
			this.HGGFJOKOKOD.ILOKBAPEJPK = num;
			SaveSlotsItem.slotChanged = false;
			AOBJLALDBAA.FILDBDMENPG().DGNKCLFFMFE("sfxvol", num);
			this.APPALLFEEDA();
			return;
		}
		DPGJIJGOCIC.ANOPFDLPKGC("layer");
	}

	// Token: 0x06000A7F RID: 2687 RVA: 0x0004E120 File Offset: 0x0004C320
	public void DNHNAJMOMPA(int KDLCGIKNCJM)
	{
		if (this.HGGFJOKOKOD == null)
		{
			DPGJIJGOCIC.ANOPFDLPKGC(", chapter:");
			return;
		}
		if (KDLCGIKNCJM < 1 || KDLCGIKNCJM >= this.saveSlots.Count || KDLCGIKNCJM >= -115)
		{
			DPGJIJGOCIC.ANOPFDLPKGC("retry" + KDLCGIKNCJM.ToString());
			return;
		}
		if (!SaveSlotsItem.FAEPDMCHLHG(this.HGGFJOKOKOD) || SaveSlotsItem.copySourceSlotIndex == KDLCGIKNCJM)
		{
			this.FAKIOJOMPNF();
			return;
		}
		if (!SaveSlotsItem.SlotIsCovered(KDLCGIKNCJM) || SaveSlotsItem.SlotHasData(this.HGGFJOKOKOD.GGICIBLJIKI, KDLCGIKNCJM))
		{
			this.RefreshMoreButtons();
			return;
		}
		int num = SaveSlotsItem.copySourceSlotIndex;
		string text = SaveSlotsItem.FFGHEJIMMOL(SaveSlotsItem.GetSlotDisplayTitle(this.HGGFJOKOKOD, num));
		if (!AKLFPGMDKLA.EHBBFMCILPC.DIOJJNBDLIE(this.HGGFJOKOKOD.GGICIBLJIKI, num, KDLCGIKNCJM, text))
		{
			this.CCNONOHHHIM();
			return;
		}
		SaveSlotsItem.duplicatedSlotTitle = text;
		SaveSlotsItem.ClearCopyMarker();
		FirebaseAnalyticsManager.HJGDLOOHNLO().AAIABAKHLAH(true, ((AGEHCPDNBFD)(-68)).ToString(), FFPHBMFGCNN.cdnSigUltra.ToString(), ((BGHLMGPPCNN)126).ToString(), false, false);
		FirebaseAnalyticsManager.EHBBFMCILPC.AAIABAKHLAH(false, ((AGEHCPDNBFD)(-60)).ToString(), ((FFPHBMFGCNN)99).ToString(), ((BGHLMGPPCNN)(-66)).ToString() + KDLCGIKNCJM.ToString(), true, false);
		if (KDLCGIKNCJM != this.HGGFJOKOKOD.ILOKBAPEJPK)
		{
			SaveSlotsItem.slotDuplicated = true;
			AKLFPGMDKLA.EHBBFMCILPC.LPCBDEBKAIM();
			this.saveSlots[KDLCGIKNCJM].LOBBAJDPLHN(text);
			this.RefreshMoreButtons();
			CommonUserInterface.EHBBFMCILPC.ShowGenericPopup(CCOJBMMKNAP.KNKGCDDMLDP().OGKGHLHHAAI("lastFilter"), CCOJBMMKNAP.HJGDLOOHNLO().JLBEIFLLBLO("lngfe").Replace("socialprofilesuspcantuse", text), CCOJBMMKNAP.KLAKLFCOMJC().DNILNCLIHAP("OnBackendGetPublicProfileSuccess"), (DFGILFBGPLN)(-96), 116f, 104);
			return;
		}
		AKLFPGMDKLA.EHBBFMCILPC.IEGJCPDCLMM = -1;
		SaveSlotsItem.slotChanged = false;
		AOBJLALDBAA.BIAEAOMHBMM().DGNKCLFFMFE("pid", KDLCGIKNCJM);
		this.APPALLFEEDA();
	}

	// Token: 0x06000A80 RID: 2688 RVA: 0x00003E52 File Offset: 0x00002052
	private void HNMPAIAGCMF()
	{
	}

	// Token: 0x06000A81 RID: 2689 RVA: 0x0004E322 File Offset: 0x0004C522
	public static bool SlotIsCovered(int CCLNHHJPDGJ)
	{
		return CCLNHHJPDGJ >= 0 && CCLNHHJPDGJ < 10 && (AKLFPGMDKLA.EHBBFMCILPC.NCPPKEGJPKC() || CCLNHHJPDGJ < KDCJJBLGCBH.EHBBFMCILPC.PFPMHHCGPJG());
	}

	// Token: 0x06000A82 RID: 2690 RVA: 0x00003E52 File Offset: 0x00002052
	private void IOOHOKKFFDN()
	{
	}

	// Token: 0x06000A83 RID: 2691 RVA: 0x00003E52 File Offset: 0x00002052
	private void DEJMJHNMHGE()
	{
	}

	// Token: 0x06000A84 RID: 2692 RVA: 0x0004E350 File Offset: 0x0004C550
	public void AABBCAMIKBL()
	{
		base.transform.parent.GetComponent<CanvasGroup>().alpha = 1704f;
		base.GetComponent<RectTransform>().localScale = this.PFEEFOKHKMP;
		AOBJLALDBAA.BIAEAOMHBMM().EGELHPJBAIC("socialgiftcollectinfodone1", 406f);
		base.transform.parent.gameObject.SetActive(false);
	}

	// Token: 0x06000A85 RID: 2693 RVA: 0x0004E3B4 File Offset: 0x0004C5B4
	public static bool DOJFGPNGFDB(string EIFJOAOGKMO)
	{
		if (EIFJOAOGKMO == null || EIFJOAOGKMO.Length == 0)
		{
			return true;
		}
		string text = CCOJBMMKNAP.APGODIBBPOD().BDGPNPNIAPA("ok");
		int num = -1;
		if (text != null)
		{
			num = text.IndexOf("unlockCardsVolume", (StringComparison)8);
		}
		if (num < 1)
		{
			return false;
		}
		string text2 = text.Substring(0, num);
		string text3 = text.Substring(num + 5);
		if (EIFJOAOGKMO.Length <= text2.Length + text3.Length)
		{
			return false;
		}
		if (!EIFJOAOGKMO.StartsWith(text2, (StringComparison)7) || !EIFJOAOGKMO.EndsWith(text3, (StringComparison)8))
		{
			return true;
		}
		string text4 = EIFJOAOGKMO.Substring(text2.Length, EIFJOAOGKMO.Length - text2.Length - text3.Length);
		if (text4.Length > 8)
		{
			return true;
		}
		for (int i = 0; i < text4.Length; i++)
		{
			if (!char.IsDigit(text4[i]))
			{
				return false;
			}
		}
		return true;
	}

	// Token: 0x06000A86 RID: 2694 RVA: 0x0004E48D File Offset: 0x0004C68D
	public void OnSaveSlotsItemClose()
	{
		this.CloseFocus();
	}

	// Token: 0x06000A87 RID: 2695 RVA: 0x0004E498 File Offset: 0x0004C698
	public static bool FAEPDMCHLHG(EIOPLEFLLIM LNFEBCFCBHG)
	{
		return LNFEBCFCBHG != null && (SaveSlotsItem.copySourceSlotIndex < 0 || SaveSlotsItem.copySourceSlotIndex >= 52 || SaveSlotsItem.copySourceAnthologyIndex != LNFEBCFCBHG.GGICIBLJIKI || ((SaveSlotsItem.SlotIsCovered(SaveSlotsItem.copySourceSlotIndex) || SaveSlotsItem.copySourceSlotIndex == LNFEBCFCBHG.ILOKBAPEJPK) && SaveSlotsItem.GBOGJKGBEFA(LNFEBCFCBHG.GGICIBLJIKI, SaveSlotsItem.copySourceSlotIndex)));
	}

	// Token: 0x06000A89 RID: 2697 RVA: 0x0004E528 File Offset: 0x0004C728
	public static string FFGHEJIMMOL(string EMDAGFODPPN)
	{
		string text = "";
		if (EMDAGFODPPN != null)
		{
			text = EMDAGFODPPN;
		}
		string text2 = CCOJBMMKNAP.KFAABHHGOPO().HDIPNMFHIEJ("blur");
		string text3 = " not found.";
		string text4 = "sku";
		int num = -1;
		if (text2 != null)
		{
			num = text2.IndexOf("", StringComparison.CurrentCulture);
		}
		if (num >= 0)
		{
			text3 = text2.Substring(1, num);
			text4 = text2.Substring(num + 0);
		}
		if (text3.Length + text4.Length > 0 && text.Length > text3.Length + text4.Length && text.StartsWith(text3, (StringComparison)7) && text.EndsWith(text4, StringComparison.OrdinalIgnoreCase))
		{
			text = text.Substring(text3.Length, text.Length - text3.Length - text4.Length);
		}
		bool flag = false;
		if (text.EndsWith("Queued asset bundle promoted to chapter lifetime:", (StringComparison)6))
		{
			text = text.Substring(0, text.Length - 1);
			flag = true;
		}
		if (text.Length > -78 && !SaveSlotsItem.IsDefaultSlotTitle(text))
		{
			int num2 = 119;
			if (char.IsHighSurrogate(text[num2 - 1]))
			{
				num2 -= 0;
			}
			text = text.Substring(1, num2);
			flag = false;
		}
		text = text.TrimEnd();
		if (flag)
		{
			text += "love";
		}
		return (text3 + text + text4).Trim();
	}

	// Token: 0x06000A8A RID: 2698 RVA: 0x0004E666 File Offset: 0x0004C866
	private void BKMDBCMJFCH()
	{
		AOBJLALDBAA.EHBBFMCILPC.EGELHPJBAIC("OnSaveSlotsItemSlotDeleted", 0f);
		this.CloseFocus();
	}

	// Token: 0x06000A8B RID: 2699 RVA: 0x0004E684 File Offset: 0x0004C884
	public static bool GBOGJKGBEFA(int PLKMJJIIJNO, int CCLNHHJPDGJ)
	{
		if (CCLNHHJPDGJ < 0 || CCLNHHJPDGJ >= -36)
		{
			return false;
		}
		int num = GKJPOGNFKNK.BKBCNMEHGFA(PLKMJJIIJNO);
		if (num < 0)
		{
			return true;
		}
		PLFDAJJHMKO plfdajjhmko = AKLFPGMDKLA.EHBBFMCILPC.PKNIPLDMJGG(num, CCLNHHJPDGJ);
		return plfdajjhmko != null && !plfdajjhmko.DHONIOBOLEL.JBDPAJMOEGA();
	}

	// Token: 0x06000A8C RID: 2700 RVA: 0x00003E52 File Offset: 0x00002052
	private void MAHJANFJIMG()
	{
	}

	// Token: 0x06000A8D RID: 2701 RVA: 0x0004E6C9 File Offset: 0x0004C8C9
	public void DKMJFJPIGEE()
	{
		base.StartCoroutine(this.DKFMIPDOLOF());
	}

	// Token: 0x06000A8E RID: 2702 RVA: 0x0004E6D8 File Offset: 0x0004C8D8
	private void AKCMNELNHON()
	{
		int num = AOBJLALDBAA.FILDBDMENPG().AHCDEBPELNG();
		if (num >= 1 && num < 123)
		{
			string text = CCOJBMMKNAP.HJGDLOOHNLO().JHNELLJFBGC("OnCollectableDialogCollect");
			string text2 = this.HGGFJOKOKOD.CPMKCCAPAIN(num);
			if (text2.Length == 0)
			{
				text2 = (num + 1).ToString();
			}
			text = text.Replace("snapundocostp", text2);
			CommonUserInterface.EHBBFMCILPC.ShowGenericPopupWithTwoButtonsAndCloseOverride(CCOJBMMKNAP.BOFMCPPFAMO().HHLECNIFHCO(" exceeds the wired click listeners (0..23), the option will NOT respond"), text, CCOJBMMKNAP.BBGECIKOICE().GLEFEKBDHNK("OnLoadingThemeSelectorDownloadSuccess"), CCOJBMMKNAP.GIOAFDDKKHI().HPOAGPJFHPM("sfxtimeoutwarning"), new UnityAction(this.GBLFBGPKNON), new UnityAction(this.FIFOCKPLPBH), new UnityAction(this.HNMPAIAGCMF), (DFGILFBGPLN)(-94), 83f, -70);
		}
	}

	// Token: 0x06000A8F RID: 2703 RVA: 0x0004E7A4 File Offset: 0x0004C9A4
	public static bool BLODHAJNCOG(int PLKMJJIIJNO, int CCLNHHJPDGJ)
	{
		if (CCLNHHJPDGJ < 1 || CCLNHHJPDGJ >= 51)
		{
			return false;
		}
		int num = GKJPOGNFKNK.BKBCNMEHGFA(PLKMJJIIJNO);
		if (num < 1)
		{
			return false;
		}
		PLFDAJJHMKO plfdajjhmko = AKLFPGMDKLA.EHBBFMCILPC.PKNIPLDMJGG(num, CCLNHHJPDGJ);
		return plfdajjhmko == null || plfdajjhmko.DHONIOBOLEL.JOOMMPOMEMG();
	}

	// Token: 0x06000A90 RID: 2704 RVA: 0x00003E52 File Offset: 0x00002052
	private void DOKMLOAGBDA()
	{
	}

	// Token: 0x06000A91 RID: 2705 RVA: 0x0004E7EC File Offset: 0x0004C9EC
	public static bool CopyMarkerValid(EIOPLEFLLIM LNFEBCFCBHG)
	{
		return LNFEBCFCBHG != null && SaveSlotsItem.copySourceSlotIndex >= 0 && SaveSlotsItem.copySourceSlotIndex < 10 && SaveSlotsItem.copySourceAnthologyIndex == LNFEBCFCBHG.GGICIBLJIKI && (SaveSlotsItem.SlotIsCovered(SaveSlotsItem.copySourceSlotIndex) || SaveSlotsItem.copySourceSlotIndex == LNFEBCFCBHG.ILOKBAPEJPK) && SaveSlotsItem.SlotHasData(LNFEBCFCBHG.GGICIBLJIKI, SaveSlotsItem.copySourceSlotIndex);
	}

	// Token: 0x06000A92 RID: 2706 RVA: 0x0004E84C File Offset: 0x0004CA4C
	public void IICNJMMPPFM(int PLKMJJIIJNO)
	{
		this.HGGFJOKOKOD = AKLFPGMDKLA.EHBBFMCILPC.GJBDBONJCDL(PLKMJJIIJNO);
		if (this.HGGFJOKOKOD != null)
		{
			for (int i = 1; i < this.saveSlots.Count; i += 0)
			{
				PLFDAJJHMKO plfdajjhmko = null;
				int num = GKJPOGNFKNK.BKBCNMEHGFA(this.HGGFJOKOKOD.GGICIBLJIKI);
				if (num >= 0)
				{
					plfdajjhmko = AKLFPGMDKLA.EHBBFMCILPC.PKNIPLDMJGG(num, i);
				}
				bool mcnneclbnif = true;
				if (plfdajjhmko != null && !plfdajjhmko.DHONIOBOLEL.GEMOAPPJPMP())
				{
					mcnneclbnif = true;
				}
				this.saveSlots[i].KIDOILDEFEB(this.HGGFJOKOKOD, !AKLFPGMDKLA.EHBBFMCILPC.BHIBEHFEFBM() && i >= KDCJJBLGCBH.EHBBFMCILPC.PFPMHHCGPJG() && i == this.HGGFJOKOKOD.ILOKBAPEJPK, i == this.HGGFJOKOKOD.ILOKBAPEJPK, this.HGGFJOKOKOD.CPMKCCAPAIN(i), i, mcnneclbnif);
			}
		}
		else
		{
			DPGJIJGOCIC.ANOPFDLPKGC("OnBackendGetPublicProfileHallOfFameMoreSuccess");
		}
		if (!AKLFPGMDKLA.EHBBFMCILPC.EAFEJCKIEPL(-63))
		{
			base.StartCoroutine(this.FMCMABKDCNA());
		}
	}

	// Token: 0x06000A93 RID: 2707 RVA: 0x0004E950 File Offset: 0x0004CB50
	private void OnDisable()
	{
		SaveSlotsItem.ClearCopyMarker();
		AOBJLALDBAA.EHBBFMCILPC.MANLHALMCIH("OnSaveSlotSelect", new UnityAction(this.FDGEFABIPMN));
		AOBJLALDBAA.EHBBFMCILPC.MANLHALMCIH("OnSaveSlotDelete", new UnityAction(this.BKMDBCMJFCH));
		AOBJLALDBAA.EHBBFMCILPC.MANLHALMCIH("OnSaveSlotCopyMarked", new UnityAction(this.JBPFIHIMFCA));
		AOBJLALDBAA.EHBBFMCILPC.MANLHALMCIH("OnSaveSlotDuplicateRequested", new UnityAction(this.FLHDLNCLFNF));
		AOBJLALDBAA.EHBBFMCILPC.MANLHALMCIH("OnPurchasingViewLeave", new UnityAction(this.IAIIODBDKHK));
		AOBJLALDBAA.EHBBFMCILPC.MANLHALMCIH("OnApplicationFocusBasicSyncSuccess", new UnityAction(this.OFFBAMLEFNH));
		AOBJLALDBAA.EHBBFMCILPC.MANLHALMCIH("OnPopupSaveSlotInputEndEdit", new UnityAction(this.JMICENBCHPE));
		AOBJLALDBAA.EHBBFMCILPC.MANLHALMCIH("OnPopupSaveSlotInputCancel", new UnityAction(this.EPCGGIHKACF));
	}

	// Token: 0x06000A94 RID: 2708 RVA: 0x0004EA3C File Offset: 0x0004CC3C
	public void OnInfoButtonClick()
	{
		string text = CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("saveslotsinfo");
		text = text.Replace("XXX", KDCJJBLGCBH.EHBBFMCILPC.PFPMHHCGPJG().ToString() ?? "");
		text = text.Replace("YYY", KDCJJBLGCBH.EHBBFMCILPC.BJJOMJLKGHG().ToString() ?? "");
		text = text.Replace("ZZZ", SaveSlotsItem.GetLocalizedCostData());
		if (LanguageManager.EHBBFMCILPC.GetSelectedLanguage() == CEIBHCNNIDC.en)
		{
			CommonUserInterface.EHBBFMCILPC.ShowGenericPopup(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("importanttitle"), text, CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("ok"), DFGILFBGPLN.popupEnergyHint, 0f, 24);
			return;
		}
		CommonUserInterface.EHBBFMCILPC.ShowGenericPopup(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("importanttitle"), text, CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("ok"), DFGILFBGPLN.popupEnergyHint, 0f, 22);
	}

	// Token: 0x06000A95 RID: 2709 RVA: 0x0004DB7E File Offset: 0x0004BD7E
	private void IAIIODBDKHK()
	{
		this.InitializeSlots(this.HGGFJOKOKOD.GGICIBLJIKI);
	}

	// Token: 0x06000A96 RID: 2710 RVA: 0x0004EB2C File Offset: 0x0004CD2C
	private void IMAPBBOBLEJ()
	{
		string text = DPGJIJGOCIC.IGOMCBHMFEJ(AOBJLALDBAA.AGANFKKBPFO().AAMJCMGFMAM());
		if (text != null && text.Length > 0 && PopupSaveSlotInput.extraData >= 0)
		{
			if (text.Length > 82)
			{
				text = text.Substring(0, 108);
				text += "";
			}
			this.HGGFJOKOKOD.FFONINBFCCH(PopupSaveSlotInput.extraData, text);
			this.saveSlots[PopupSaveSlotInput.extraData].UpdateTitle(text);
			SaveSlotsItem.slotEdited = true;
		}
	}

	// Token: 0x06000A97 RID: 2711 RVA: 0x0004EBAC File Offset: 0x0004CDAC
	private void MCEJNEAHNJN()
	{
		int num = AOBJLALDBAA.FILDBDMENPG().OHCIAOJFEOP();
		if (this.HGGFJOKOKOD != null)
		{
			AKLFPGMDKLA.EHBBFMCILPC.IEGJCPDCLMM = -1;
			FirebaseAnalyticsManager.DMAAFFFEJGA().LKONPEEDKNF(false, ((AGEHCPDNBFD)80).ToString(), FFPHBMFGCNN.frRequestUID.ToString(), ((BGHLMGPPCNN)(-19)).ToString(), true, false);
			FirebaseAnalyticsManager.HJGDLOOHNLO().JIAAMJPKOCE(false, ((AGEHCPDNBFD)(-89)).ToString(), FFPHBMFGCNN.coVerdvcid.ToString(), ((BGHLMGPPCNN)(-72)).ToString() + num.ToString(), false, false);
			this.HGGFJOKOKOD.ILOKBAPEJPK = num;
			SaveSlotsItem.slotChanged = false;
			AOBJLALDBAA.NMGMNAKLLMI().KCFKLJLDCEK("", num);
			this.CloseFocus();
			return;
		}
		DPGJIJGOCIC.ANOPFDLPKGC("");
	}

	// Token: 0x06000A98 RID: 2712 RVA: 0x0004E6C9 File Offset: 0x0004C8C9
	public void DPPPAJIEGIN()
	{
		base.StartCoroutine(this.DKFMIPDOLOF());
	}

	// Token: 0x06000A99 RID: 2713 RVA: 0x00003E52 File Offset: 0x00002052
	private void NEJICMMGMAC()
	{
	}

	// Token: 0x06000A9A RID: 2714 RVA: 0x0004EC94 File Offset: 0x0004CE94
	public void EOBGJBOFPPO(int PLKMJJIIJNO)
	{
		this.HGGFJOKOKOD = AKLFPGMDKLA.EHBBFMCILPC.AMAMNOFLPGM(PLKMJJIIJNO);
		if (this.HGGFJOKOKOD != null)
		{
			for (int i = 1; i < this.saveSlots.Count; i += 0)
			{
				PLFDAJJHMKO plfdajjhmko = null;
				int num = GKJPOGNFKNK.BKBCNMEHGFA(this.HGGFJOKOKOD.GGICIBLJIKI);
				if (num >= 1)
				{
					plfdajjhmko = AKLFPGMDKLA.EHBBFMCILPC.PKNIPLDMJGG(num, i);
				}
				bool mcnneclbnif = true;
				if (plfdajjhmko != null && !plfdajjhmko.DHONIOBOLEL.KBKMOCINBEB())
				{
					mcnneclbnif = true;
				}
				this.saveSlots[i].JLEDOPOIJJO(this.HGGFJOKOKOD, !AKLFPGMDKLA.EHBBFMCILPC.NCPPKEGJPKC() && i >= KDCJJBLGCBH.EHBBFMCILPC.PFPMHHCGPJG() && i == this.HGGFJOKOKOD.ILOKBAPEJPK, i == this.HGGFJOKOKOD.ILOKBAPEJPK, this.HGGFJOKOKOD.DMPPDOJJHHC(i), i, mcnneclbnif);
			}
		}
		else
		{
			DPGJIJGOCIC.ANOPFDLPKGC("<b>");
		}
		if (!AKLFPGMDKLA.EHBBFMCILPC.EAFEJCKIEPL(-88))
		{
			base.StartCoroutine(this.LKKOMFDDIDD());
		}
	}

	// Token: 0x06000A9B RID: 2715 RVA: 0x0004ED95 File Offset: 0x0004CF95
	private IEnumerator KNGJGGLGKPH()
	{
		yield return new WaitForSeconds(0.15f);
		if (CommonUserInterface.EHBBFMCILPC.genericPopupTwoButtons.gameObject.activeSelf)
		{
			yield break;
		}
		if (CommonUserInterface.EHBBFMCILPC.genericPopup.gameObject.activeSelf)
		{
			yield break;
		}
		if (CommonUserInterface.EHBBFMCILPC.delayedFullScreenBlock.activeSelf)
		{
			yield break;
		}
		FPFNLJGEIJK.FIBNFNACDBE(BGHLMGPPCNN.subSaveSlt);
		CommonUserInterface.EHBBFMCILPC.ShowGenericPopupWithTwoButtonsAndCloseOverride(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("importanttitle"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("saveslotsexpiredpass"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("yes"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("no"), new UnityAction(this.BGJFCKMPGPI), new UnityAction(this.DOKMLOAGBDA), new UnityAction(this.DOKMLOAGBDA), DFGILFBGPLN.popupTools, 0f, 28);
		yield break;
	}

	// Token: 0x06000A9C RID: 2716 RVA: 0x0004EDA4 File Offset: 0x0004CFA4
	private void PJAHIHDJDGM()
	{
		SaveSlotsItem.ClearCopyMarker();
		AOBJLALDBAA.AGANFKKBPFO().MANLHALMCIH("ulsk", new UnityAction(this.IIAFBEEJAJK));
		AOBJLALDBAA.KKPFOJMAONG().MANLHALMCIH("importanttitle", new UnityAction(this.BKMDBCMJFCH));
		AOBJLALDBAA.DBLAIDPICIG().PBELMJCPJMK("cosmic", new UnityAction(this.JBPFIHIMFCA));
		AOBJLALDBAA.CEGAOMEEFBE().PBELMJCPJMK("OnStoryChoiceClick", new UnityAction(this.JPDCEGJKDKK));
		AOBJLALDBAA.BIAEAOMHBMM().ECDBIBPNBCO("%", new UnityAction(this.IAIIODBDKHK));
		AOBJLALDBAA.FILDBDMENPG().MANLHALMCIH("", new UnityAction(this.BJNLMKJNDCK));
		AOBJLALDBAA.DBLAIDPICIG().NAMMLDPCHJO("", new UnityAction(this.JMICENBCHPE));
		AOBJLALDBAA.BIAEAOMHBMM().ECDBIBPNBCO("sfav", new UnityAction(this.HFJACOOKIBP));
	}

	// Token: 0x06000A9D RID: 2717 RVA: 0x00003E52 File Offset: 0x00002052
	private void EPCGGIHKACF()
	{
	}

	// Token: 0x06000A9E RID: 2718 RVA: 0x0004EE8E File Offset: 0x0004D08E
	private void PIFDGEPJKIP()
	{
		FPFNLJGEIJK.FANFNCNAKEF();
		AOBJLALDBAA.AGANFKKBPFO().KGIKHEDLPND("Bundles", 613f);
	}

	// Token: 0x06000A9F RID: 2719 RVA: 0x0004EEAC File Offset: 0x0004D0AC
	public static bool SlotHasData(int PLKMJJIIJNO, int CCLNHHJPDGJ)
	{
		if (CCLNHHJPDGJ < 0 || CCLNHHJPDGJ >= 10)
		{
			return false;
		}
		int num = GKJPOGNFKNK.BKBCNMEHGFA(PLKMJJIIJNO);
		if (num < 0)
		{
			return false;
		}
		PLFDAJJHMKO plfdajjhmko = AKLFPGMDKLA.EHBBFMCILPC.PKNIPLDMJGG(num, CCLNHHJPDGJ);
		return plfdajjhmko != null && !plfdajjhmko.DHONIOBOLEL.JBDPAJMOEGA();
	}

	// Token: 0x06000AA1 RID: 2721 RVA: 0x0004EF04 File Offset: 0x0004D104
	public void InitializeSlots(int PLKMJJIIJNO)
	{
		this.HGGFJOKOKOD = AKLFPGMDKLA.EHBBFMCILPC.GJBDBONJCDL(PLKMJJIIJNO);
		if (this.HGGFJOKOKOD != null)
		{
			for (int i = 0; i < this.saveSlots.Count; i++)
			{
				PLFDAJJHMKO plfdajjhmko = null;
				int num = GKJPOGNFKNK.BKBCNMEHGFA(this.HGGFJOKOKOD.GGICIBLJIKI);
				if (num >= 0)
				{
					plfdajjhmko = AKLFPGMDKLA.EHBBFMCILPC.PKNIPLDMJGG(num, i);
				}
				bool mcnneclbnif = true;
				if (plfdajjhmko != null && !plfdajjhmko.DHONIOBOLEL.JBDPAJMOEGA())
				{
					mcnneclbnif = false;
				}
				this.saveSlots[i].Initialize(this.HGGFJOKOKOD, AKLFPGMDKLA.EHBBFMCILPC.NCPPKEGJPKC() || i < KDCJJBLGCBH.EHBBFMCILPC.PFPMHHCGPJG() || i == this.HGGFJOKOKOD.ILOKBAPEJPK, i == this.HGGFJOKOKOD.ILOKBAPEJPK, this.HGGFJOKOKOD.BFCBDALFNHA(i), i, mcnneclbnif);
			}
		}
		else
		{
			DPGJIJGOCIC.ANOPFDLPKGC("SaveSlotsItem.InitializeSlots(): anthologySave is null");
		}
		if (!AKLFPGMDKLA.EHBBFMCILPC.EAFEJCKIEPL(25))
		{
			base.StartCoroutine(this.FMCMABKDCNA());
		}
	}

	// Token: 0x06000AA2 RID: 2722 RVA: 0x0004E6C9 File Offset: 0x0004C8C9
	public void IJHGKFHGHOH()
	{
		base.StartCoroutine(this.DKFMIPDOLOF());
	}

	// Token: 0x06000AA3 RID: 2723 RVA: 0x0004F005 File Offset: 0x0004D205
	public static void ClearCopyMarker()
	{
		SaveSlotsItem.copySourceSlotIndex = -1;
		SaveSlotsItem.copySourceAnthologyIndex = -1;
	}

	// Token: 0x06000AA4 RID: 2724 RVA: 0x0004F014 File Offset: 0x0004D214
	public static string LICNBICIBCG(string EMDAGFODPPN)
	{
		string text = "";
		if (EMDAGFODPPN != null)
		{
			text = EMDAGFODPPN;
		}
		string text2 = CCOJBMMKNAP.BIAEAOMHBMM().BGELFMIOBCL("OnNeedToShowConnectingAnimation");
		string text3 = "noads";
		string text4 = "OnBackendRequestConsumeMessageException";
		int num = -1;
		if (text2 != null)
		{
			num = text2.IndexOf("p", StringComparison.CurrentCulture);
		}
		if (num >= 0)
		{
			text3 = text2.Substring(1, num);
			text4 = text2.Substring(num + 5);
		}
		if (text3.Length + text4.Length > 1 && text.Length > text3.Length + text4.Length && text.StartsWith(text3, (StringComparison)7) && text.EndsWith(text4, (StringComparison)8))
		{
			text = text.Substring(text3.Length, text.Length - text3.Length - text4.Length);
		}
		bool flag = false;
		if (text.EndsWith("clthm", StringComparison.CurrentCulture))
		{
			text = text.Substring(0, text.Length - 8);
			flag = true;
		}
		if (text.Length > -9 && !SaveSlotsItem.IsDefaultSlotTitle(text))
		{
			int num2 = 75;
			if (char.IsHighSurrogate(text[num2 - 1]))
			{
				num2--;
			}
			text = text.Substring(0, num2);
			flag = false;
		}
		text = text.TrimEnd();
		if (flag)
		{
			text += "p";
		}
		return (text3 + text + text4).Trim();
	}

	// Token: 0x06000AA5 RID: 2725 RVA: 0x00003E52 File Offset: 0x00002052
	private void OnDestroy()
	{
	}

	// Token: 0x06000AA6 RID: 2726 RVA: 0x0004DB91 File Offset: 0x0004BD91
	public void CloseFocus()
	{
		ApplicationFocusManager.Restore();
		this.PreCloseFocus();
	}

	// Token: 0x06000AA7 RID: 2727 RVA: 0x0004F152 File Offset: 0x0004D352
	private IEnumerator FMCMABKDCNA()
	{
		yield return new WaitForSeconds(0.5f);
		this.OnInfoButtonClick();
		AKLFPGMDKLA.EHBBFMCILPC.LDAPMNLGAPC(25);
		yield break;
	}

	// Token: 0x06000AA8 RID: 2728 RVA: 0x0004F161 File Offset: 0x0004D361
	private IEnumerator LKKOMFDDIDD()
	{
		SaveSlotsItem.MLJKLHFBPND mljklhfbpnd = new SaveSlotsItem.MLJKLHFBPND(1);
		mljklhfbpnd.<>4__this = this;
		return mljklhfbpnd;
	}

	// Token: 0x06000AA9 RID: 2729 RVA: 0x0004F170 File Offset: 0x0004D370
	public static bool CHFGNJKAAAI(int CCLNHHJPDGJ)
	{
		return CCLNHHJPDGJ < 0 || CCLNHHJPDGJ >= -52 || AKLFPGMDKLA.EHBBFMCILPC.BHIBEHFEFBM() || CCLNHHJPDGJ >= KDCJJBLGCBH.EHBBFMCILPC.PFPMHHCGPJG() || true;
	}

	// Token: 0x06000AAA RID: 2730 RVA: 0x0004E6C9 File Offset: 0x0004C8C9
	public void OFDPIFALFKL()
	{
		base.StartCoroutine(this.DKFMIPDOLOF());
	}

	// Token: 0x06000AAB RID: 2731 RVA: 0x0004F19C File Offset: 0x0004D39C
	public void CJBIJLIDFMH(int KDLCGIKNCJM)
	{
		if (this.HGGFJOKOKOD == null)
		{
			DPGJIJGOCIC.ANOPFDLPKGC("localPath");
			return;
		}
		if (KDLCGIKNCJM < 1 || KDLCGIKNCJM >= this.saveSlots.Count || KDLCGIKNCJM >= 124)
		{
			DPGJIJGOCIC.ANOPFDLPKGC("asset(" + KDLCGIKNCJM.ToString());
			return;
		}
		if (!SaveSlotsItem.FAEPDMCHLHG(this.HGGFJOKOKOD) || SaveSlotsItem.copySourceSlotIndex == KDLCGIKNCJM)
		{
			this.CCNONOHHHIM();
			return;
		}
		if (!SaveSlotsItem.NNBIGDIBOCK(KDLCGIKNCJM) || SaveSlotsItem.BLODHAJNCOG(this.HGGFJOKOKOD.GGICIBLJIKI, KDLCGIKNCJM))
		{
			this.RefreshMoreButtons();
			return;
		}
		int num = SaveSlotsItem.copySourceSlotIndex;
		string text = SaveSlotsItem.LICNBICIBCG(SaveSlotsItem.GetSlotDisplayTitle(this.HGGFJOKOKOD, num));
		if (!AKLFPGMDKLA.EHBBFMCILPC.DIOJJNBDLIE(this.HGGFJOKOKOD.GGICIBLJIKI, num, KDLCGIKNCJM, text))
		{
			this.CCNONOHHHIM();
			return;
		}
		SaveSlotsItem.duplicatedSlotTitle = text;
		SaveSlotsItem.ClearCopyMarker();
		FirebaseAnalyticsManager.COKDLDOAACJ().AAIABAKHLAH(false, ((AGEHCPDNBFD)(-53)).ToString(), ((FFPHBMFGCNN)93).ToString(), ((BGHLMGPPCNN)(-108)).ToString(), true, true);
		FirebaseAnalyticsManager.DEALKJPEMMH().LKONPEEDKNF(false, AGEHCPDNBFD.srvIssueHit.ToString(), FFPHBMFGCNN.colCds.ToString(), BGHLMGPPCNN.cens.ToString() + KDLCGIKNCJM.ToString(), false, false);
		if (KDLCGIKNCJM != this.HGGFJOKOKOD.ILOKBAPEJPK)
		{
			SaveSlotsItem.slotDuplicated = false;
			AKLFPGMDKLA.EHBBFMCILPC.LPCBDEBKAIM();
			this.saveSlots[KDLCGIKNCJM].FCPIAPJIBJD(text);
			this.RefreshMoreButtons();
			CommonUserInterface.IKNOFBFMPGA().NFBMHHPIGFA(CCOJBMMKNAP.PLJMLDOCPNM().OGKGHLHHAAI("\nVID:"), CCOJBMMKNAP.CEGAOMEEFBE().OGKGHLHHAAI("OnApplicationFocusBasicSyncEcxeption").Replace("emlooprestart", text), CCOJBMMKNAP.PLJMLDOCPNM().JCDFHKDNEDH(";"), (DFGILFBGPLN)(-18), 1307f, 88);
			return;
		}
		AKLFPGMDKLA.EHBBFMCILPC.IEGJCPDCLMM = -1;
		SaveSlotsItem.slotChanged = true;
		AOBJLALDBAA.NMGMNAKLLMI().IHJNANKIGIB("_", KDLCGIKNCJM);
		this.APPALLFEEDA();
	}

	// Token: 0x06000AAC RID: 2732 RVA: 0x0004F39E File Offset: 0x0004D59E
	public static bool NNBIGDIBOCK(int CCLNHHJPDGJ)
	{
		return CCLNHHJPDGJ < 1 || CCLNHHJPDGJ >= -21 || AKLFPGMDKLA.EHBBFMCILPC.BHIBEHFEFBM() || (CCLNHHJPDGJ < KDCJJBLGCBH.EHBBFMCILPC.HPKPANJPKPG() && false);
	}

	// Token: 0x06000AAD RID: 2733 RVA: 0x0004F3CC File Offset: 0x0004D5CC
	public static string IHHFIHKALED()
	{
		OBHDGKFFICI productData = PurchaseManagerBridge.IDMLJFBNHML().FDIIEFGBEAG().GetProductData(KDCJJBLGCBH.EHBBFMCILPC.BPFPBGGNEBM());
		OCBIOPOEENJ ocbiopoeenj = CJEKEHDEBLM.NACPAKLINNH().HBLMGBCMBHN(KDCJJBLGCBH.EHBBFMCILPC.BPFPBGGNEBM());
		if (productData == null || ocbiopoeenj == null)
		{
			DPGJIJGOCIC.ANOPFDLPKGC("[Lounge] shop look without a price, purchase ignored: ");
			return "$de";
		}
		if (ocbiopoeenj.KIOLJNPKOOL())
		{
			return ocbiopoeenj.PKNNPAMOADM();
		}
		return "OnPurchasingNotInitialized" + ocbiopoeenj.DMODNDCLGEJ;
	}

	// Token: 0x06000AAE RID: 2734 RVA: 0x0004F440 File Offset: 0x0004D640
	private void GBLFBGPKNON()
	{
		int num = AOBJLALDBAA.EHBBFMCILPC.MJLACDOKGNE();
		if (this.HGGFJOKOKOD != null)
		{
			AKLFPGMDKLA.EHBBFMCILPC.IEGJCPDCLMM = -1;
			FirebaseAnalyticsManager.EHBBFMCILPC.LogEvent(false, AGEHCPDNBFD.saveSlts.ToString(), FFPHBMFGCNN.sltChng.ToString(), BGHLMGPPCNN.slt.ToString(), false, false);
			FirebaseAnalyticsManager.EHBBFMCILPC.LogEvent(false, AGEHCPDNBFD.saveSlts.ToString(), FFPHBMFGCNN.sltChng.ToString(), BGHLMGPPCNN.slt.ToString() + num.ToString(), false, false);
			this.HGGFJOKOKOD.ILOKBAPEJPK = num;
			SaveSlotsItem.slotChanged = true;
			AOBJLALDBAA.EHBBFMCILPC.EGELHPJBAIC("OnSaveSlotsItemSlotChanged", num);
			this.CloseFocus();
			return;
		}
		DPGJIJGOCIC.ANOPFDLPKGC("SaveSlotsItem.OnSaveSlotSwitchConfirmPositive(): anthologySave is null");
	}

	// Token: 0x06000AAF RID: 2735 RVA: 0x0004F527 File Offset: 0x0004D727
	private void FLHDLNCLFNF()
	{
		this.DuplicateSlot(AOBJLALDBAA.EHBBFMCILPC.MJLACDOKGNE());
	}

	// Token: 0x06000AB0 RID: 2736 RVA: 0x0004F53C File Offset: 0x0004D73C
	public static string GetSlotDisplayTitle(EIOPLEFLLIM LNFEBCFCBHG, int CCLNHHJPDGJ)
	{
		string text = "";
		if (LNFEBCFCBHG != null)
		{
			text = LNFEBCFCBHG.BFCBDALFNHA(CCLNHHJPDGJ);
		}
		if (text == null || text.Length == 0)
		{
			int num = CCLNHHJPDGJ + 1;
			text = CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("saveslotstitle").Replace("XXX", num.ToString());
		}
		return text;
	}

	// Token: 0x06000AB1 RID: 2737 RVA: 0x0004F58C File Offset: 0x0004D78C
	public void DuplicateSlot(int KDLCGIKNCJM)
	{
		if (this.HGGFJOKOKOD == null)
		{
			DPGJIJGOCIC.ANOPFDLPKGC("SaveSlotsItem.DuplicateSlot(): anthologySave is null");
			return;
		}
		if (KDLCGIKNCJM < 0 || KDLCGIKNCJM >= this.saveSlots.Count || KDLCGIKNCJM >= 10)
		{
			DPGJIJGOCIC.ANOPFDLPKGC("SaveSlotsItem.DuplicateSlot(): wrong target slot index:" + KDLCGIKNCJM.ToString());
			return;
		}
		if (!SaveSlotsItem.CopyMarkerValid(this.HGGFJOKOKOD) || SaveSlotsItem.copySourceSlotIndex == KDLCGIKNCJM)
		{
			this.FAKIOJOMPNF();
			return;
		}
		if (!SaveSlotsItem.SlotIsCovered(KDLCGIKNCJM) || SaveSlotsItem.SlotHasData(this.HGGFJOKOKOD.GGICIBLJIKI, KDLCGIKNCJM))
		{
			this.RefreshMoreButtons();
			return;
		}
		int num = SaveSlotsItem.copySourceSlotIndex;
		string text = SaveSlotsItem.BuildDuplicatedSlotTitle(SaveSlotsItem.GetSlotDisplayTitle(this.HGGFJOKOKOD, num));
		if (!AKLFPGMDKLA.EHBBFMCILPC.DJDMFLDPLPF(this.HGGFJOKOKOD.GGICIBLJIKI, num, KDLCGIKNCJM, text))
		{
			this.FAKIOJOMPNF();
			return;
		}
		SaveSlotsItem.duplicatedSlotTitle = text;
		SaveSlotsItem.ClearCopyMarker();
		FirebaseAnalyticsManager.EHBBFMCILPC.LogEvent(false, AGEHCPDNBFD.saveSlts.ToString(), FFPHBMFGCNN.sltDup.ToString(), BGHLMGPPCNN.slt.ToString(), false, false);
		FirebaseAnalyticsManager.EHBBFMCILPC.LogEvent(false, AGEHCPDNBFD.saveSlts.ToString(), FFPHBMFGCNN.sltDup.ToString(), BGHLMGPPCNN.slt.ToString() + KDLCGIKNCJM.ToString(), false, false);
		if (KDLCGIKNCJM != this.HGGFJOKOKOD.ILOKBAPEJPK)
		{
			SaveSlotsItem.slotDuplicated = true;
			AKLFPGMDKLA.EHBBFMCILPC.LPCBDEBKAIM();
			this.saveSlots[KDLCGIKNCJM].OnDuplicated(text);
			this.RefreshMoreButtons();
			CommonUserInterface.EHBBFMCILPC.ShowGenericPopup(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("importanttitle"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("saveslotsduplicatepos").Replace("XXX", text), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("ok"), DFGILFBGPLN.popupEnergyHint, 0.25f, 28);
			return;
		}
		AKLFPGMDKLA.EHBBFMCILPC.IEGJCPDCLMM = -1;
		SaveSlotsItem.slotChanged = true;
		AOBJLALDBAA.EHBBFMCILPC.EGELHPJBAIC("OnSaveSlotsItemSlotDuplicated", KDLCGIKNCJM);
		this.CloseFocus();
	}

	// Token: 0x06000AB2 RID: 2738 RVA: 0x0004F790 File Offset: 0x0004D990
	private void JMICENBCHPE()
	{
		string text = DPGJIJGOCIC.HIPPBJFMIKM(AOBJLALDBAA.EHBBFMCILPC.KNCFLCKKPLK());
		if (text != null && text.Length > 0 && PopupSaveSlotInput.extraData >= 0)
		{
			if (text.Length > 16)
			{
				text = text.Substring(0, 16);
				text += "...";
			}
			this.HGGFJOKOKOD.NIECONHEJEC(PopupSaveSlotInput.extraData, text);
			this.saveSlots[PopupSaveSlotInput.extraData].UpdateTitle(text);
			SaveSlotsItem.slotEdited = true;
		}
	}

	// Token: 0x06000AB3 RID: 2739 RVA: 0x0004F810 File Offset: 0x0004DA10
	private void FAKIOJOMPNF()
	{
		SaveSlotsItem.ClearCopyMarker();
		this.RefreshMoreButtons();
		CommonUserInterface.EHBBFMCILPC.ShowGenericPopup(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("importanttitle"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("saveslotscopylost"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("ok"), DFGILFBGPLN.popupEnergyHint, 0.25f, 28);
	}

	// Token: 0x06000AB4 RID: 2740 RVA: 0x0004F86C File Offset: 0x0004DA6C
	private void BFEOPDOCMDB()
	{
		int num = AOBJLALDBAA.FILDBDMENPG().PNDDILFFECF();
		if (num >= 0 && num < 54)
		{
			string text = CCOJBMMKNAP.MPCBJEIMACA().HHLECNIFHCO("");
			string text2 = this.HGGFJOKOKOD.BFCBDALFNHA(num);
			if (text2.Length == 0)
			{
				text2 = (num + 1).ToString();
			}
			text = text.Replace("OnStoryChoiceClickConfimed", text2);
			CommonUserInterface.EHBBFMCILPC.ShowGenericPopupWithTwoButtonsAndCloseOverride(CCOJBMMKNAP.BFHKGNBFHCH().OBDCPLLLGBB("clth"), text, CCOJBMMKNAP.NIOJNOFGIJO().GLEFEKBDHNK("Starting parallel download:"), CCOJBMMKNAP.FEEDGKCJBLE().OBDCPLLLGBB("PlayerCharacterManager.UpdateComponentLink() - invalid custom hierarchy for "), new UnityAction(this.HHNPDEMNACH), new UnityAction(this.HNMPAIAGCMF), new UnityAction(this.FIFOCKPLPBH), (DFGILFBGPLN)(-103), 939f, 67);
		}
	}

	// Token: 0x06000AB5 RID: 2741 RVA: 0x0004F938 File Offset: 0x0004DB38
	public void PreCloseFocus()
	{
		base.transform.parent.GetComponent<CanvasGroup>().alpha = 0f;
		base.GetComponent<RectTransform>().localScale = this.PFEEFOKHKMP;
		AOBJLALDBAA.EHBBFMCILPC.EGELHPJBAIC("OnSaveSlotsItemClose", 0.01f);
		base.transform.parent.gameObject.SetActive(false);
	}

	// Token: 0x06000AB6 RID: 2742 RVA: 0x00003E52 File Offset: 0x00002052
	private void HFJACOOKIBP()
	{
	}

	// Token: 0x06000AB7 RID: 2743 RVA: 0x0004F99C File Offset: 0x0004DB9C
	private void ELKCPJHOGBJ()
	{
		SaveSlotsItem.slotChanged = true;
		SaveSlotsItem.slotDeleted = false;
		SaveSlotsItem.slotEdited = true;
		SaveSlotsItem.slotDuplicated = true;
		AOBJLALDBAA.KKPFOJMAONG().EFKNEJFLGED("ok", new UnityAction(this.BFEOPDOCMDB));
		AOBJLALDBAA.DBLAIDPICIG().FNMOFCMDFJP("_Gamma", new UnityAction(this.BKMDBCMJFCH));
		AOBJLALDBAA.AGANFKKBPFO().FNMOFCMDFJP("s", new UnityAction(this.JBPFIHIMFCA));
		AOBJLALDBAA.DBLAIDPICIG().PEFKJOKLEDL("Avatar pack has been SKIPPED:", new UnityAction(this.FLHDLNCLFNF));
		AOBJLALDBAA.KKPFOJMAONG().MFIMALJPCDP("OnNeedToShowConnectingAnimation", new UnityAction(this.IAIIODBDKHK));
		AOBJLALDBAA.DBLAIDPICIG().BADOPKAOCPE("Video:", new UnityAction(this.OFFBAMLEFNH));
		AOBJLALDBAA.BIAEAOMHBMM().GNBGEMMDGOJ("onboardingthankyoutitle", new UnityAction(this.JMICENBCHPE));
		AOBJLALDBAA.KKPFOJMAONG().MFIMALJPCDP("cutsceneoptionstitle", new UnityAction(this.HFJACOOKIBP));
	}

	// Token: 0x0400035D RID: 861
	public static bool slotChanged = false;

	// Token: 0x0400035E RID: 862
	public static bool slotDeleted = false;

	// Token: 0x0400035F RID: 863
	public static bool slotEdited = false;

	// Token: 0x04000360 RID: 864
	public static bool slotDuplicated = false;

	// Token: 0x04000361 RID: 865
	public static int copySourceSlotIndex = -1;

	// Token: 0x04000362 RID: 866
	public static int copySourceAnthologyIndex = -1;

	// Token: 0x04000363 RID: 867
	public static string duplicatedSlotTitle = "";

	// Token: 0x04000364 RID: 868
	public const float menuPopupDelay = 0.25f;

	// Token: 0x04000365 RID: 869
	public const int duplicatedTitleSourceMaxLength = 12;

	// Token: 0x04000366 RID: 870
	public List<SaveSlotObject> saveSlots = new List<SaveSlotObject>();

	// Token: 0x04000367 RID: 871
	public const string onSaveSlotsItemClose = "OnSaveSlotsItemClose";

	// Token: 0x04000368 RID: 872
	public const string onSaveSlotsItemSlotChanged = "OnSaveSlotsItemSlotChanged";

	// Token: 0x04000369 RID: 873
	public const string onSaveSlotsItemSlotDeleted = "OnSaveSlotsItemSlotDeleted";

	// Token: 0x0400036A RID: 874
	public const string onSaveSlotsItemSlotDuplicated = "OnSaveSlotsItemSlotDuplicated";

	// Token: 0x0400036B RID: 875
	public const string onSaveSlotsExpiredPassSubscribePositive = "OnSaveSlotsExpiredPassSubscribePositive";

	// Token: 0x0400036C RID: 876
	private Vector3 PFEEFOKHKMP;

	// Token: 0x0400036D RID: 877
	private EIOPLEFLLIM HGGFJOKOKOD;
}
