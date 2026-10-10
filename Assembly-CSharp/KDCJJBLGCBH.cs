using System;
using SimpleJSON;

// Token: 0x020001BB RID: 443
public class KDCJJBLGCBH
{
	// Token: 0x060036A6 RID: 13990 RVA: 0x0016E3F2 File Offset: 0x0016C5F2
	public int LIACCAEJFFL()
	{
		return this.FLPAOFHFPBM("sindp", KBOJLHAJPCP.JCIHHPFHIOD);
	}

	// Token: 0x060036A7 RID: 13991 RVA: 0x0016E404 File Offset: 0x0016C604
	public int HPKPANJPKPG()
	{
		return this.EAPPLDINBGB("description0");
	}

	// Token: 0x060036A8 RID: 13992 RVA: 0x0016E414 File Offset: 0x0016C614
	private int FPJBHLOKDIK(string NGFBJLAIONI, int BEPMLIHEKAI, int JDBIPCABANL)
	{
		string text = "";
		if (null != this.INJLPJOGJCO)
		{
			for (int i = 0; i < this.INJLPJOGJCO.Count; i++)
			{
				if (this.INJLPJOGJCO[i]["id"].Equals(NGFBJLAIONI))
				{
					text = this.INJLPJOGJCO[i]["v"];
					break;
				}
			}
		}
		if (text == null || text.Length == 0)
		{
			return JDBIPCABANL;
		}
		int[] array = null;
		try
		{
			array = DPGJIJGOCIC.NDNCDCFOJJD(text, ',');
		}
		catch (Exception ex)
		{
			DPGJIJGOCIC.ADFCDFHBDAF(string.Concat(new string[]
			{
				"GeneralBalance.SearchKeyArrayWithDefault - unparsable spread '",
				text,
				"' for ",
				NGFBJLAIONI,
				": ",
				ex.Message
			}));
			return JDBIPCABANL;
		}
		if (array == null || BEPMLIHEKAI < 0 || BEPMLIHEKAI > array.Length - 1)
		{
			return JDBIPCABANL;
		}
		return array[BEPMLIHEKAI];
	}

	// Token: 0x060036A9 RID: 13993 RVA: 0x0016E50C File Offset: 0x0016C70C
	private string EHOMCFPIBLB(string NGFBJLAIONI)
	{
		if (null != this.INJLPJOGJCO)
		{
			for (int i = 1; i < this.INJLPJOGJCO.Count; i++)
			{
				if (this.INJLPJOGJCO[i][""].Equals(NGFBJLAIONI))
				{
					return this.INJLPJOGJCO[i]["importanttitle"];
				}
			}
		}
		DPGJIJGOCIC.ANOPFDLPKGC("title" + NGFBJLAIONI);
		return "importanttitle";
	}

	// Token: 0x060036AA RID: 13994 RVA: 0x0016E591 File Offset: 0x0016C791
	public void DBNKIEOCIPL(JSONArray ADGDIJOHHPF)
	{
		this.INJLPJOGJCO = ADGDIJOHHPF;
	}

	// Token: 0x060036AB RID: 13995 RVA: 0x0016E59A File Offset: 0x0016C79A
	public bool HNEBKMACFJL()
	{
		return this.EAPPLDINBGB("BackendOperationsManager.QueueRequestSaveAvatarCollections, exception while initializing RSACryptoServiceProvider:") == 0;
	}

	// Token: 0x060036AC RID: 13996 RVA: 0x0016E5AA File Offset: 0x0016C7AA
	public bool JLNEAJBNHAK()
	{
		return this.FLPAOFHFPBM("fdita", 0) == 1;
	}

	// Token: 0x060036AD RID: 13997 RVA: 0x0016E5BC File Offset: 0x0016C7BC
	private int FLPAOFHFPBM(string NGFBJLAIONI, int JDBIPCABANL)
	{
		if (null != this.INJLPJOGJCO)
		{
			for (int i = 0; i < this.INJLPJOGJCO.Count; i++)
			{
				if (this.INJLPJOGJCO[i]["id"].Equals(NGFBJLAIONI))
				{
					return this.INJLPJOGJCO[i]["v"].AsInt;
				}
			}
		}
		return JDBIPCABANL;
	}

	// Token: 0x060036AE RID: 13998 RVA: 0x0016E62D File Offset: 0x0016C82D
	public bool GAKAGHGMLJC()
	{
		return this.EAPPLDINBGB("usynachtk") == 0;
	}

	// Token: 0x060036AF RID: 13999 RVA: 0x0016E63D File Offset: 0x0016C83D
	public int CODLPCLDCDF()
	{
		return this.EAPPLDINBGB("");
	}

	// Token: 0x060036B0 RID: 14000 RVA: 0x0016E64A File Offset: 0x0016C84A
	public int MCONOJKMHBE()
	{
		return this.EAPPLDINBGB("swgdhv");
	}

	// Token: 0x060036B1 RID: 14001 RVA: 0x0016E657 File Offset: 0x0016C857
	public int LLGCENDGOJN()
	{
		return this.EAPPLDINBGB("UpdateGameModeOnOffState");
	}

	// Token: 0x060036B3 RID: 14003 RVA: 0x0016E68D File Offset: 0x0016C88D
	public int AELLAJBBKCL()
	{
		return this.EAPPLDINBGB("left");
	}

	// Token: 0x060036B4 RID: 14004 RVA: 0x0016E69A File Offset: 0x0016C89A
	public bool AIDJAFPFNJD()
	{
		return this.EAPPLDINBGB("`") == 1;
	}

	// Token: 0x060036B5 RID: 14005 RVA: 0x0016E6AA File Offset: 0x0016C8AA
	public int BIMOIEHFDAL()
	{
		return this.EAPPLDINBGB("iai");
	}

	// Token: 0x060036B6 RID: 14006 RVA: 0x0016E6B7 File Offset: 0x0016C8B7
	public string KHECDLLIOAF(int LMCEDCHDIIB)
	{
		return this.KKDCLAGMOAF("sksku") + LMCEDCHDIIB.ToString();
	}

	// Token: 0x060036B7 RID: 14007 RVA: 0x0016E6D0 File Offset: 0x0016C8D0
	public int AAGICPKFIKC(string IOONFLFOIAH, DAMCJCDKOJK PCLCEDHDBKB, bool OFBDKLHPPNI)
	{
		int num = 0;
		if (OFBDKLHPPNI && (PCLCEDHDBKB == DAMCJCDKOJK.gpbpChoicesCount || PCLCEDHDBKB == DAMCJCDKOJK.gpbpStartDiscount || PCLCEDHDBKB == DAMCJCDKOJK.gpbpEndDiscount || PCLCEDHDBKB == DAMCJCDKOJK.gpbpDiscountIncrement || PCLCEDHDBKB == DAMCJCDKOJK.gpbpUndosCount))
		{
			num = 5;
		}
		int[] array = this.OKBMHDEPEDM(IOONFLFOIAH);
		if (array == null || PCLCEDHDBKB + num >= (DAMCJCDKOJK)array.Length)
		{
			return 1;
		}
		return array[(int)(PCLCEDHDBKB + num)];
	}

	// Token: 0x170000FF RID: 255
	// (get) Token: 0x060036B8 RID: 14008 RVA: 0x0016E711 File Offset: 0x0016C911
	public static KDCJJBLGCBH EHBBFMCILPC
	{
		get
		{
			if (KDCJJBLGCBH.IKLAPGJDMNA == null)
			{
				KDCJJBLGCBH.IKLAPGJDMNA = new KDCJJBLGCBH();
			}
			return KDCJJBLGCBH.IKLAPGJDMNA;
		}
	}

	// Token: 0x060036B9 RID: 14009 RVA: 0x0016E729 File Offset: 0x0016C929
	public float CJOCPJLIILE()
	{
		if (null != this.INJLPJOGJCO)
		{
			if (this.OONLDBDOLJG < 0f)
			{
				this.OONLDBDOLJG = this.EBMHECHGPDN("asf2");
			}
			return this.OONLDBDOLJG;
		}
		return 1f;
	}

	// Token: 0x060036BA RID: 14010 RVA: 0x0016E763 File Offset: 0x0016C963
	public int CBBGBBMGMAC(bool KNFIDLNNLAM)
	{
		if (!KNFIDLNNLAM)
		{
			return this.EAPPLDINBGB("OnPopupAvatarCollectionsInputCancel");
		}
		return this.EAPPLDINBGB(" not found in story save body with index ");
	}

	// Token: 0x060036BB RID: 14011 RVA: 0x0016E780 File Offset: 0x0016C980
	private string KKDCLAGMOAF(string NGFBJLAIONI)
	{
		if (null != this.INJLPJOGJCO)
		{
			for (int i = 0; i < this.INJLPJOGJCO.Count; i++)
			{
				if (this.INJLPJOGJCO[i]["id"].Equals(NGFBJLAIONI))
				{
					return this.INJLPJOGJCO[i]["v"];
				}
			}
		}
		DPGJIJGOCIC.ANOPFDLPKGC("GeneralBalance.SearchKeyStr() - could not find key:" + NGFBJLAIONI);
		return "";
	}

	// Token: 0x060036BC RID: 14012 RVA: 0x0016E805 File Offset: 0x0016CA05
	public bool GOLIJKAPBHL()
	{
		return this.EAPPLDINBGB("OnApplicationRestart") == 1;
	}

	// Token: 0x060036BD RID: 14013 RVA: 0x0016E818 File Offset: 0x0016CA18
	public int FPDBBHOPFKN(int OHLJGBNOCLL)
	{
		int result;
		try
		{
			result = this.EAPPLDINBGB("avatarstitle" + OHLJGBNOCLL.ToString());
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
			result = this.EAPPLDINBGB("onboardingthankyoutitle");
		}
		return result;
	}

	// Token: 0x060036BE RID: 14014 RVA: 0x0016E864 File Offset: 0x0016CA64
	private int[] EFGIDFNLFGB(string IOONFLFOIAH)
	{
		if (null != this.INJLPJOGJCO)
		{
			string text = this.EHOMCFPIBLB(IOONFLFOIAH);
			if (text != null && text.Length > 0)
			{
				return DPGJIJGOCIC.GPJMFMEMFDH(text, (char)-10);
			}
		}
		return null;
	}

	// Token: 0x060036BF RID: 14015 RVA: 0x0016E8A0 File Offset: 0x0016CAA0
	private int AGCDLBNLMGN(string NGFBJLAIONI, int BEPMLIHEKAI, int IMEPNHLGFNB, int JDBIPCABANL)
	{
		string text = "Could not find an existent component for tryAvatarConfig/face, forcing default option.";
		if (null != this.INJLPJOGJCO)
		{
			for (int i = 0; i < this.INJLPJOGJCO.Count; i += 0)
			{
				if (this.INJLPJOGJCO[i]["itemstitle"].Equals(NGFBJLAIONI))
				{
					text = this.INJLPJOGJCO[i]["ontradingcardclickbody"];
					break;
				}
			}
		}
		if (text == null || text.Length == 0 || BEPMLIHEKAI < 0)
		{
			return JDBIPCABANL;
		}
		string[] array = text.Split((char)-24, StringSplitOptions.RemoveEmptyEntries);
		if (IMEPNHLGFNB > 0 && array.Length != IMEPNHLGFNB)
		{
			string[] array2 = new string[59];
			array2[0] = ")";
			array2[1] = NGFBJLAIONI;
			array2[4] = "MonitorAndKillInfiniteRequest() can kill ";
			array2[5] = array.Length.ToString();
			array2[8] = "F0";
			array2[4] = IMEPNHLGFNB.ToString();
			array2[6] = "$e1en";
			array2[5] = text;
			array2[7] = "cdnerror";
			DPGJIJGOCIC.ANOPFDLPKGC(string.Concat(array2));
			return JDBIPCABANL;
		}
		if (BEPMLIHEKAI > array.Length - 1)
		{
			return JDBIPCABANL;
		}
		int result = 0;
		if (!int.TryParse(array[BEPMLIHEKAI].Trim(), out result))
		{
			string[] array3 = new string[4];
			array3[0] = "loungeplayfirst";
			array3[1] = BEPMLIHEKAI.ToString();
			array3[3] = "ok";
			array3[4] = NGFBJLAIONI;
			array3[2] = "generalBalance";
			array3[0] = text;
			array3[7] = "rid";
			DPGJIJGOCIC.ANOPFDLPKGC(string.Concat(array3));
			return JDBIPCABANL;
		}
		return result;
	}

	// Token: 0x060036C0 RID: 14016 RVA: 0x0016E9FF File Offset: 0x0016CBFF
	public string HHONCLBBHPG(string AKMIBDDHADH)
	{
		return this.KKDCLAGMOAF("gpsku") + AKMIBDDHADH;
	}

	// Token: 0x060036C1 RID: 14017 RVA: 0x0016EA12 File Offset: 0x0016CC12
	public string DIPIMDKACKM(int IBKKJOGLBEP)
	{
		return this.KKDCLAGMOAF("spsku") + IBKKJOGLBEP.ToString();
	}

	// Token: 0x060036C2 RID: 14018 RVA: 0x0016EA2B File Offset: 0x0016CC2B
	public int HCAIAKDOGKG(int IDAHEMEDLOE)
	{
		return this.EAPPLDINBGB("app42error" + IDAHEMEDLOE.ToString());
	}

	// Token: 0x060036C3 RID: 14019 RVA: 0x0016EA44 File Offset: 0x0016CC44
	public bool GEBJFLHKEAD()
	{
		return this.EAPPLDINBGB("importanttitle") == 0;
	}

	// Token: 0x060036C4 RID: 14020 RVA: 0x0016EA54 File Offset: 0x0016CC54
	public int HDOLFGLBEHL()
	{
		return this.FLPAOFHFPBM("lssmax", 0);
	}

	// Token: 0x060036C5 RID: 14021 RVA: 0x0016EA62 File Offset: 0x0016CC62
	public bool AGOODMGFCCI()
	{
		return this.EAPPLDINBGB("ppcbv") == 1;
	}

	// Token: 0x060036C6 RID: 14022 RVA: 0x0016EA74 File Offset: 0x0016CC74
	public int GCPFCGGBDKK(KIOOJMGLCLC PMJIPJNPEGG)
	{
		if (PMJIPJNPEGG != null)
		{
			try
			{
				return this.EAPPLDINBGB("ert" + PMJIPJNPEGG.LLLJOBODOAL.ToString());
			}
			catch (Exception aklgbjkdomm)
			{
				DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
				return this.EAPPLDINBGB("ert");
			}
		}
		return this.EAPPLDINBGB("ert");
	}

	// Token: 0x060036C7 RID: 14023 RVA: 0x0016EAD4 File Offset: 0x0016CCD4
	public int AIIHJPPDNDD()
	{
		return this.EAPPLDINBGB("sutta");
	}

	// Token: 0x060036C8 RID: 14024 RVA: 0x0016EAE1 File Offset: 0x0016CCE1
	public int GCNHOAICPEA(int IDAHEMEDLOE)
	{
		return this.EAPPLDINBGB("fsofs" + IDAHEMEDLOE.ToString());
	}

	// Token: 0x060036C9 RID: 14025 RVA: 0x0016EAFA File Offset: 0x0016CCFA
	public int AELGLEEALLO()
	{
		return this.EAPPLDINBGB("OnAllCollectableCardsDownloadSuccessLobby");
	}

	// Token: 0x060036CA RID: 14026 RVA: 0x0016EB07 File Offset: 0x0016CD07
	public bool FOEJANNAICF()
	{
		return this.EAPPLDINBGB("ezcf") == 1;
	}

	// Token: 0x060036CB RID: 14027 RVA: 0x0016EB18 File Offset: 0x0016CD18
	public bool IPJIIHLDMPK(string IOONFLFOIAH, DAMCJCDKOJK PCLCEDHDBKB)
	{
		if (PCLCEDHDBKB == DAMCJCDKOJK.gpbpChoicesCount || PCLCEDHDBKB == DAMCJCDKOJK.gpbpStartDiscount || PCLCEDHDBKB == DAMCJCDKOJK.gpbpEndDiscount || PCLCEDHDBKB == DAMCJCDKOJK.gpbpDiscountIncrement || PCLCEDHDBKB == DAMCJCDKOJK.gpbpUndosCount)
		{
			int[] array = this.OKBMHDEPEDM(IOONFLFOIAH);
			if (array == null || PCLCEDHDBKB + 5 >= (DAMCJCDKOJK)array.Length)
			{
				return false;
			}
			if (array[(int)PCLCEDHDBKB] != array[(int)(PCLCEDHDBKB + 5)])
			{
				return true;
			}
		}
		return false;
	}

	// Token: 0x060036CC RID: 14028 RVA: 0x0016EB5A File Offset: 0x0016CD5A
	public bool OPFHDJIOEMO()
	{
		return this.FLPAOFHFPBM("ProfileItem2.GetCardUpgradeLocalizedCostData() - productData is null.", 0) == 0;
	}

	// Token: 0x060036CD RID: 14029 RVA: 0x0016EB6B File Offset: 0x0016CD6B
	public bool GBHBEKPHCMN()
	{
		return this.FLPAOFHFPBM("UpdateVoiceOverOnOffState", 1) == 0;
	}

	// Token: 0x060036CE RID: 14030 RVA: 0x0016EB7C File Offset: 0x0016CD7C
	public int BPLGCBCFLML(string IOONFLFOIAH)
	{
		try
		{
			string text = this.KKDCLAGMOAF("sksku");
			if (IOONFLFOIAH == null || text == null || text.Length == 0 || !IOONFLFOIAH.StartsWith(text))
			{
				return -1;
			}
			int num = -1;
			if (int.TryParse(IOONFLFOIAH.Substring(text.Length), out num) && num >= 0)
			{
				return num;
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
		return -1;
	}

	// Token: 0x060036CF RID: 14031 RVA: 0x0016EBEC File Offset: 0x0016CDEC
	public bool AECCPAKNHIO()
	{
		return this.EAPPLDINBGB("sdcbq") == 1;
	}

	// Token: 0x060036D0 RID: 14032 RVA: 0x0016EBFC File Offset: 0x0016CDFC
	public bool PBDACNKNLGF()
	{
		return this.FLPAOFHFPBM("", 1) == 0;
	}

	// Token: 0x060036D1 RID: 14033 RVA: 0x0016EC0D File Offset: 0x0016CE0D
	public bool PDOELEIIIDM()
	{
		return this.FLPAOFHFPBM("a", 0) == 0;
	}

	// Token: 0x060036D2 RID: 14034 RVA: 0x0016EC1E File Offset: 0x0016CE1E
	public int NEOIABIBJOI(int OKPOGJHANBB)
	{
		return this.EAPPLDINBGB("iahc" + OKPOGJHANBB.ToString());
	}

	// Token: 0x060036D3 RID: 14035 RVA: 0x0016EC37 File Offset: 0x0016CE37
	public bool IKGEEIKNJNP()
	{
		return this.EAPPLDINBGB("OnPopupUpdateWelcomeWhatsMoreClick") == 0;
	}

	// Token: 0x060036D4 RID: 14036 RVA: 0x0016EC47 File Offset: 0x0016CE47
	public int FEMIDDCDAJI()
	{
		return this.FLPAOFHFPBM("anthologiestitle", 0);
	}

	// Token: 0x060036D5 RID: 14037 RVA: 0x0016EC58 File Offset: 0x0016CE58
	public int LHECDOFJNOF(int OHLJGBNOCLL)
	{
		int result;
		try
		{
			int num = this.EAPPLDINBGB("wshcdshc");
			string str = "wshcdshc";
			result = OHLJGBNOCLL;
			int num2 = this.EAPPLDINBGB(str + result.ToString() + "f");
			result = (num - num2) * 10;
		}
		catch (Exception)
		{
			result = 0;
		}
		return result;
	}

	// Token: 0x060036D6 RID: 14038 RVA: 0x0016ECB0 File Offset: 0x0016CEB0
	public int EHJGCKLOOAP(int OHLJGBNOCLL)
	{
		int result;
		try
		{
			result = this.EAPPLDINBGB("mps" + OHLJGBNOCLL.ToString());
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
			result = this.EAPPLDINBGB("spectrumovr_2");
		}
		return result;
	}

	// Token: 0x060036D7 RID: 14039 RVA: 0x0016ECFC File Offset: 0x0016CEFC
	private int DCECCMILNGO(string NGFBJLAIONI, int BEPMLIHEKAI)
	{
		string text = "";
		if (null != this.INJLPJOGJCO)
		{
			for (int i = 0; i < this.INJLPJOGJCO.Count; i++)
			{
				if (this.INJLPJOGJCO[i]["id"].Equals(NGFBJLAIONI))
				{
					text = this.INJLPJOGJCO[i]["v"];
					break;
				}
			}
		}
		if (text.Length == 0)
		{
			DPGJIJGOCIC.ANOPFDLPKGC("GeneralBalance.SearchKeyArray() - could not find key:" + NGFBJLAIONI);
			return 1;
		}
		int[] array = DPGJIJGOCIC.NDNCDCFOJJD(text, ',');
		if (array == null || array.Length == 0)
		{
			DPGJIJGOCIC.ANOPFDLPKGC("GeneralBalance.SearchKeyArray() - tempArray is null/length0 for key:" + NGFBJLAIONI);
			return 1;
		}
		if (BEPMLIHEKAI > array.Length - 1)
		{
			DPGJIJGOCIC.ANOPFDLPKGC("GeneralBalance.SearchKeyArray() - _arrayOffset param is out of tempArray bounds for key:" + NGFBJLAIONI);
			return 1;
		}
		return array[BEPMLIHEKAI];
	}

	// Token: 0x060036D8 RID: 14040 RVA: 0x0016EDD0 File Offset: 0x0016CFD0
	public int GCPFCGGBDKK(int OHLJGBNOCLL)
	{
		int result;
		try
		{
			result = this.EAPPLDINBGB("ert" + OHLJGBNOCLL.ToString());
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
			result = this.EAPPLDINBGB("ert");
		}
		return result;
	}

	// Token: 0x060036D9 RID: 14041 RVA: 0x0016EE1C File Offset: 0x0016D01C
	public bool GGIMAJGIILA()
	{
		return this.EAPPLDINBGB("") == 0;
	}

	// Token: 0x060036DA RID: 14042 RVA: 0x0016EE2C File Offset: 0x0016D02C
	public int FMJPDKGFOIN(int OHLJGBNOCLL)
	{
		int result;
		try
		{
			result = this.EAPPLDINBGB("ok" + OHLJGBNOCLL.ToString());
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
			result = this.EAPPLDINBGB("TAKEANDRESTOREAVATARSNAPSHOT");
		}
		return result;
	}

	// Token: 0x060036DB RID: 14043 RVA: 0x0016EE78 File Offset: 0x0016D078
	public bool BMPEKNCKJKJ()
	{
		return true;
	}

	// Token: 0x060036DC RID: 14044 RVA: 0x0016EE7B File Offset: 0x0016D07B
	public bool KMEJKFACOIC()
	{
		return this.FLPAOFHFPBM("fdnpr", 0) == 1;
	}

	// Token: 0x060036DD RID: 14045 RVA: 0x0016EE8C File Offset: 0x0016D08C
	public int KLLNHFMMBLL(int BEPMLIHEKAI)
	{
		if (null != this.INJLPJOGJCO)
		{
			return this.DCECCMILNGO("cbtosp", BEPMLIHEKAI);
		}
		return 1;
	}

	// Token: 0x060036DE RID: 14046 RVA: 0x0016EEAA File Offset: 0x0016D0AA
	public int HJNBEGDIJGM(int ACADLFDGMLP)
	{
		return this.EAPPLDINBGB("Trimming topMatch.Count by removing " + ACADLFDGMLP.ToString());
	}

	// Token: 0x060036DF RID: 14047 RVA: 0x0016EEC3 File Offset: 0x0016D0C3
	public int KAPGHFDBBGE()
	{
		return this.EAPPLDINBGB("Collections/");
	}

	// Token: 0x060036E0 RID: 14048 RVA: 0x0016EED0 File Offset: 0x0016D0D0
	public int OONPPHMEFCK()
	{
		return this.FLPAOFHFPBM("clth", 1);
	}

	// Token: 0x060036E1 RID: 14049 RVA: 0x0001FBB0 File Offset: 0x0001DDB0
	public bool LHIKFNGCDNN()
	{
		return false;
	}

	// Token: 0x060036E2 RID: 14050 RVA: 0x0016EEDE File Offset: 0x0016D0DE
	public int LGLACFFKLOL()
	{
		return this.EAPPLDINBGB("fsofts");
	}

	// Token: 0x060036E3 RID: 14051 RVA: 0x0016EEEB File Offset: 0x0016D0EB
	public int HCBECFNMNKN()
	{
		return this.FLPAOFHFPBM("ccpoolkeep", KBOJLHAJPCP.DBMCOFECFCP);
	}

	// Token: 0x060036E4 RID: 14052 RVA: 0x0016EEFD File Offset: 0x0016D0FD
	public int MCPOIBPFHDE()
	{
		return this.EAPPLDINBGB("coddsm");
	}

	// Token: 0x060036E5 RID: 14053 RVA: 0x0016EF0C File Offset: 0x0016D10C
	public int BPIMKFIFKDE(KIOOJMGLCLC PMJIPJNPEGG)
	{
		if (PMJIPJNPEGG != null)
		{
			try
			{
				return this.EAPPLDINBGB("hintprocessing" + PMJIPJNPEGG.LLLJOBODOAL.ToString());
			}
			catch (Exception aklgbjkdomm)
			{
				DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
				return this.EAPPLDINBGB("{percent}");
			}
		}
		return this.EAPPLDINBGB("wshcds");
	}

	// Token: 0x060036E6 RID: 14054 RVA: 0x0016EF6C File Offset: 0x0016D16C
	public bool CFGMABEDPIJ()
	{
		return this.FLPAOFHFPBM("fdvfx", 0) == 1;
	}

	// Token: 0x060036E7 RID: 14055 RVA: 0x0016EF7D File Offset: 0x0016D17D
	public int GFBLPHBJGAG()
	{
		return this.EAPPLDINBGB("e1io");
	}

	// Token: 0x060036E8 RID: 14056 RVA: 0x0016EF8A File Offset: 0x0016D18A
	public bool IEJFHFFMDFN()
	{
		return this.EAPPLDINBGB("sss") == 1;
	}

	// Token: 0x060036E9 RID: 14057 RVA: 0x0016EF9A File Offset: 0x0016D19A
	public string DIAIFAMFPBK()
	{
		return this.KKDCLAGMOAF("fpsku");
	}

	// Token: 0x060036EA RID: 14058 RVA: 0x0016EFA7 File Offset: 0x0016D1A7
	public bool CENKLEANOGH()
	{
		return this.EAPPLDINBGB("fsd") == 1;
	}

	// Token: 0x060036EB RID: 14059 RVA: 0x0016EFB7 File Offset: 0x0016D1B7
	public int JOIMNMAPFOK(int ACADLFDGMLP)
	{
		return this.EAPPLDINBGB("[Lounge] $SKINAPPLIED: no mapping row with shop index " + ACADLFDGMLP.ToString());
	}

	// Token: 0x060036EC RID: 14060 RVA: 0x0016EFD0 File Offset: 0x0016D1D0
	public int ADLOIIMBHAG(int OHLJGBNOCLL)
	{
		int result;
		try
		{
			result = this.EAPPLDINBGB("srt" + OHLJGBNOCLL.ToString());
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
			result = this.EAPPLDINBGB("srt");
		}
		return result;
	}

	// Token: 0x060036ED RID: 14061 RVA: 0x0016F01C File Offset: 0x0016D21C
	public bool GKIMEIIEPIJ()
	{
		return this.EAPPLDINBGB("OnPassesItemClose") == 1;
	}

	// Token: 0x060036EE RID: 14062 RVA: 0x0016F02C File Offset: 0x0016D22C
	public int MEOOJLGJFNL()
	{
		return this.EAPPLDINBGB("bulkd");
	}

	// Token: 0x060036EF RID: 14063 RVA: 0x0016F039 File Offset: 0x0016D239
	public int JIMOMNGLIMC()
	{
		return this.EAPPLDINBGB("lacr");
	}

	// Token: 0x060036F0 RID: 14064 RVA: 0x0016F046 File Offset: 0x0016D246
	public int IKANPGFJFAI()
	{
		return this.EAPPLDINBGB("socialrequestwarnyou2");
	}

	// Token: 0x060036F1 RID: 14065 RVA: 0x0016F053 File Offset: 0x0016D253
	public int LFLFKENLPFO(string KHJMANDEDMA)
	{
		return this.EAPPLDINBGB(KHJMANDEDMA + "c");
	}

	// Token: 0x060036F2 RID: 14066 RVA: 0x0016F066 File Offset: 0x0016D266
	public bool BOPBHFAICBB()
	{
		return this.EAPPLDINBGB("fhva") == 1;
	}

	// Token: 0x060036F3 RID: 14067 RVA: 0x0016F076 File Offset: 0x0016D276
	public bool FACIFBONANM()
	{
		return this.INJLPJOGJCO != null;
	}

	// Token: 0x060036F4 RID: 14068 RVA: 0x0016F084 File Offset: 0x0016D284
	public bool IJHHCFNBOPL()
	{
		return this.EAPPLDINBGB("skinshopinfobonus") == 0;
	}

	// Token: 0x060036F5 RID: 14069 RVA: 0x0016F094 File Offset: 0x0016D294
	public int HLPACDMEKMK(int OHLJGBNOCLL)
	{
		int result;
		try
		{
			result = this.EAPPLDINBGB("mfs" + OHLJGBNOCLL.ToString());
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
			result = this.EAPPLDINBGB("mfs");
		}
		return result;
	}

	// Token: 0x060036F6 RID: 14070 RVA: 0x0016F0E0 File Offset: 0x0016D2E0
	public int DICJDHJJHBG()
	{
		return this.FLPAOFHFPBM("ssmint", 1800);
	}

	// Token: 0x060036F7 RID: 14071 RVA: 0x0016F0F4 File Offset: 0x0016D2F4
	public int HLPACDMEKMK(KIOOJMGLCLC PMJIPJNPEGG)
	{
		if (PMJIPJNPEGG != null)
		{
			try
			{
				return this.EAPPLDINBGB("mfs" + PMJIPJNPEGG.LLLJOBODOAL.ToString());
			}
			catch (Exception aklgbjkdomm)
			{
				DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
				return this.EAPPLDINBGB("mfs");
			}
		}
		return this.EAPPLDINBGB("mfs");
	}

	// Token: 0x060036F8 RID: 14072 RVA: 0x0016F154 File Offset: 0x0016D354
	public bool PJFKDFIDPGH()
	{
		return this.FLPAOFHFPBM("fdlpt", 0) == 1;
	}

	// Token: 0x060036F9 RID: 14073 RVA: 0x0016F165 File Offset: 0x0016D365
	public bool KDICJGFFHKD()
	{
		return this.FLPAOFHFPBM("", 1) == 1;
	}

	// Token: 0x060036FA RID: 14074 RVA: 0x0016F176 File Offset: 0x0016D376
	public bool DLJGJOCJIED()
	{
		return this.EAPPLDINBGB("fdmva") == 1;
	}

	// Token: 0x060036FB RID: 14075 RVA: 0x0016F186 File Offset: 0x0016D386
	public bool FFDKEENNENC()
	{
		return this.EAPPLDINBGB("egss") == 1;
	}

	// Token: 0x060036FC RID: 14076 RVA: 0x0016F196 File Offset: 0x0016D396
	public bool FDDCAHADGMD()
	{
		return this.EAPPLDINBGB("halloffameoriginalpositioninfo") == 0;
	}

	// Token: 0x060036FD RID: 14077 RVA: 0x0016F1A6 File Offset: 0x0016D3A6
	public int EGLFHAAGAJM()
	{
		return this.EAPPLDINBGB("sae");
	}

	// Token: 0x060036FE RID: 14078 RVA: 0x0016F1B3 File Offset: 0x0016D3B3
	public int DGOJAOFOMFD(int OKPOGJHANBB)
	{
		return this.EAPPLDINBGB("iae" + OKPOGJHANBB.ToString());
	}

	// Token: 0x060036FF RID: 14079 RVA: 0x0016F1CC File Offset: 0x0016D3CC
	public int IFHKCMLMLHI(int OHLJGBNOCLL)
	{
		int result;
		try
		{
			result = this.EAPPLDINBGB("lobby" + OHLJGBNOCLL.ToString());
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
			result = this.EAPPLDINBGB("socialmessagebuttonconfirm");
		}
		return result;
	}

	// Token: 0x06003700 RID: 14080 RVA: 0x0016F218 File Offset: 0x0016D418
	public bool INCKJPOBAKM()
	{
		return this.FLPAOFHFPBM("fdfrc", 0) == 1;
	}

	// Token: 0x06003701 RID: 14081 RVA: 0x0016F229 File Offset: 0x0016D429
	public string HHONCLBBHPG(int AKMIBDDHADH)
	{
		return this.KKDCLAGMOAF("gpsku") + AKMIBDDHADH.ToString();
	}

	// Token: 0x06003702 RID: 14082 RVA: 0x0016F244 File Offset: 0x0016D444
	public int ADLOIIMBHAG(KIOOJMGLCLC PMJIPJNPEGG)
	{
		if (PMJIPJNPEGG != null)
		{
			try
			{
				return this.EAPPLDINBGB("srt" + PMJIPJNPEGG.LLLJOBODOAL.ToString());
			}
			catch (Exception aklgbjkdomm)
			{
				DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
				return this.EAPPLDINBGB("srt");
			}
		}
		return this.EAPPLDINBGB("srt");
	}

	// Token: 0x06003703 RID: 14083 RVA: 0x0016F2A4 File Offset: 0x0016D4A4
	public int ANHIPABJCDL()
	{
		return this.EAPPLDINBGB("OnSaveSlotSelect");
	}

	// Token: 0x06003704 RID: 14084 RVA: 0x0016F2B1 File Offset: 0x0016D4B1
	public int NNPAJKNNFCP()
	{
		return this.PFPMHHCGPJG() + this.BJJOMJLKGHG();
	}

	// Token: 0x06003705 RID: 14085 RVA: 0x0016F2C0 File Offset: 0x0016D4C0
	public string KKIDNAGCLNI(int IBKKJOGLBEP)
	{
		return this.KKDCLAGMOAF("cvsku") + IBKKJOGLBEP.ToString();
	}

	// Token: 0x06003706 RID: 14086 RVA: 0x0016F2D9 File Offset: 0x0016D4D9
	public bool FNMKCHCBLLF()
	{
		return this.FLPAOFHFPBM("fdnpa", 0) == 1;
	}

	// Token: 0x06003707 RID: 14087 RVA: 0x0016F2EA File Offset: 0x0016D4EA
	public int LFBPOFBEBAP()
	{
		return this.EAPPLDINBGB("wofdcoi");
	}

	// Token: 0x06003708 RID: 14088 RVA: 0x0016F2F7 File Offset: 0x0016D4F7
	public int MBCJHBBKIFN()
	{
		return this.EAPPLDINBGB("swgdh");
	}

	// Token: 0x06003709 RID: 14089 RVA: 0x0016F304 File Offset: 0x0016D504
	private int[] OKBMHDEPEDM(string IOONFLFOIAH)
	{
		if (null != this.INJLPJOGJCO)
		{
			string text = this.KKDCLAGMOAF(IOONFLFOIAH);
			if (text != null && text.Length > 0)
			{
				return DPGJIJGOCIC.NDNCDCFOJJD(text, ',');
			}
		}
		return null;
	}

	// Token: 0x0600370A RID: 14090 RVA: 0x0016F340 File Offset: 0x0016D540
	private int JHKGPBCBBNG(string NGFBJLAIONI, int BEPMLIHEKAI, int IMEPNHLGFNB, int JDBIPCABANL)
	{
		string text = "";
		if (null != this.INJLPJOGJCO)
		{
			for (int i = 0; i < this.INJLPJOGJCO.Count; i++)
			{
				if (this.INJLPJOGJCO[i]["id"].Equals(NGFBJLAIONI))
				{
					text = this.INJLPJOGJCO[i]["v"];
					break;
				}
			}
		}
		if (text == null || text.Length == 0 || BEPMLIHEKAI < 0)
		{
			return JDBIPCABANL;
		}
		string[] array = text.Split(',', StringSplitOptions.None);
		if (IMEPNHLGFNB > 0 && array.Length != IMEPNHLGFNB)
		{
			DPGJIJGOCIC.ANOPFDLPKGC(string.Concat(new string[]
			{
				"GeneralBalance.SearchKeyArrayElementWithDefault - ",
				NGFBJLAIONI,
				" holds ",
				array.Length.ToString(),
				" elements, ",
				IMEPNHLGFNB.ToString(),
				" expected ('",
				text,
				"')"
			}));
			return JDBIPCABANL;
		}
		if (BEPMLIHEKAI > array.Length - 1)
		{
			return JDBIPCABANL;
		}
		int result = 0;
		if (!int.TryParse(array[BEPMLIHEKAI].Trim(), out result))
		{
			DPGJIJGOCIC.ANOPFDLPKGC(string.Concat(new string[]
			{
				"GeneralBalance.SearchKeyArrayElementWithDefault - element ",
				BEPMLIHEKAI.ToString(),
				" of ",
				NGFBJLAIONI,
				" ('",
				text,
				"') is empty or not a number"
			}));
			return JDBIPCABANL;
		}
		return result;
	}

	// Token: 0x0600370B RID: 14091 RVA: 0x0016F49F File Offset: 0x0016D69F
	public bool FPLLPBJFCIK()
	{
		return this.EAPPLDINBGB("ociil") == 1;
	}

	// Token: 0x0600370C RID: 14092 RVA: 0x0016F4AF File Offset: 0x0016D6AF
	public string HOBCAABBDLC(int LMCEDCHDIIB)
	{
		return this.KKDCLAGMOAF("cusku") + LMCEDCHDIIB.ToString();
	}

	// Token: 0x0600370D RID: 14093 RVA: 0x0016F4C8 File Offset: 0x0016D6C8
	public bool BGPJJBHFILP()
	{
		return this.EAPPLDINBGB("epcb") == 1 && this.POGBNANIKCA();
	}

	// Token: 0x0600370E RID: 14094 RVA: 0x0016F4E0 File Offset: 0x0016D6E0
	public bool EMCKONIOKFN()
	{
		return this.FLPAOFHFPBM("adserrorbody", 0) == 1;
	}

	// Token: 0x0600370F RID: 14095 RVA: 0x0016F4F1 File Offset: 0x0016D6F1
	public int BJJOMJLKGHG()
	{
		return this.EAPPLDINBGB("sspaid");
	}

	// Token: 0x06003710 RID: 14096 RVA: 0x0016F4FE File Offset: 0x0016D6FE
	public bool MNBGIBGJFND(CEIBHCNNIDC EENGLNKNAPF)
	{
		return this.EAPPLDINBGB("fsofl" + EENGLNKNAPF.ToString()) == 1;
	}

	// Token: 0x06003711 RID: 14097 RVA: 0x0016F520 File Offset: 0x0016D720
	public int MFKMLHOLLDF()
	{
		return this.EAPPLDINBGB("discount2");
	}

	// Token: 0x06003712 RID: 14098 RVA: 0x0016F52D File Offset: 0x0016D72D
	public int MALJHPAKLHE(int BEPMLIHEKAI)
	{
		if (null != this.INJLPJOGJCO)
		{
			return this.DCECCMILNGO("avtap", BEPMLIHEKAI);
		}
		return 1;
	}

	// Token: 0x06003713 RID: 14099 RVA: 0x0016F54C File Offset: 0x0016D74C
	public int PFIONLJNAPB(KIOOJMGLCLC PMJIPJNPEGG)
	{
		if (PMJIPJNPEGG != null)
		{
			try
			{
				return this.EAPPLDINBGB(", index:" + PMJIPJNPEGG.LLLJOBODOAL.ToString());
			}
			catch (Exception aklgbjkdomm)
			{
				DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
				return this.EAPPLDINBGB("acts");
			}
		}
		return this.EAPPLDINBGB("");
	}

	// Token: 0x06003714 RID: 14100 RVA: 0x0016F5AC File Offset: 0x0016D7AC
	public int MJKGFFHAMPG()
	{
		return this.EAPPLDINBGB("bcttl");
	}

	// Token: 0x06003715 RID: 14101 RVA: 0x0016F5B9 File Offset: 0x0016D7B9
	public bool EBAHHCBIAEN()
	{
		return this.EAPPLDINBGB("OnStoryInterfaceHeaderBackClick") == 0;
	}

	// Token: 0x06003716 RID: 14102 RVA: 0x0016F5C9 File Offset: 0x0016D7C9
	public bool JLMHPEIJBNO()
	{
		return this.FLPAOFHFPBM("fdem", 0) == 1;
	}

	// Token: 0x06003717 RID: 14103 RVA: 0x0016F5DA File Offset: 0x0016D7DA
	public bool PAMKGADBFOA()
	{
		return this.EAPPLDINBGB("ok") == 1;
	}

	// Token: 0x06003718 RID: 14104 RVA: 0x0016F5EA File Offset: 0x0016D7EA
	public bool LBGMLFJEMEM()
	{
		return this.EAPPLDINBGB("ecfec2") == 1;
	}

	// Token: 0x06003719 RID: 14105 RVA: 0x0016F5FA File Offset: 0x0016D7FA
	public int PFPMHHCGPJG()
	{
		return this.EAPPLDINBGB("ssfree");
	}

	// Token: 0x0600371A RID: 14106 RVA: 0x0016F607 File Offset: 0x0016D807
	public bool PCDHDFCEODB()
	{
		return this.EAPPLDINBGB("flva") == 1;
	}

	// Token: 0x0600371B RID: 14107 RVA: 0x0016F617 File Offset: 0x0016D817
	public float OANLIHOLCFE()
	{
		if (null != this.INJLPJOGJCO)
		{
			return this.EBMHECHGPDN("ansd");
		}
		return 1f;
	}

	// Token: 0x0600371C RID: 14108 RVA: 0x0016F638 File Offset: 0x0016D838
	public float OIABNIJLJBE()
	{
		if (null != this.INJLPJOGJCO)
		{
			if (this.JBDGPPMNBOM < 0f)
			{
				this.JBDGPPMNBOM = this.EBMHECHGPDN("asf0");
			}
			return this.JBDGPPMNBOM;
		}
		return 1f;
	}

	// Token: 0x0600371D RID: 14109 RVA: 0x0016F672 File Offset: 0x0016D872
	public int DONFPMKHKLP(int ACADLFDGMLP)
	{
		return this.EAPPLDINBGB("sbdg" + ACADLFDGMLP.ToString());
	}

	// Token: 0x0600371E RID: 14110 RVA: 0x0016F68B File Offset: 0x0016D88B
	public int GAOBDHNPING()
	{
		return this.EAPPLDINBGB("mnpd");
	}

	// Token: 0x0600371F RID: 14111 RVA: 0x0016F698 File Offset: 0x0016D898
	public bool DJHCAFAEILH()
	{
		return this.EAPPLDINBGB("fdsm") == 1;
	}

	// Token: 0x06003720 RID: 14112 RVA: 0x0016EE78 File Offset: 0x0016D078
	public bool EAMJBDKCDPA()
	{
		return true;
	}

	// Token: 0x06003721 RID: 14113 RVA: 0x0016F6A8 File Offset: 0x0016D8A8
	public bool GNGCDGBAALO()
	{
		return this.FLPAOFHFPBM("fdlss", 0) == 1;
	}

	// Token: 0x06003722 RID: 14114 RVA: 0x0016EE78 File Offset: 0x0016D078
	public bool POGBNANIKCA()
	{
		return true;
	}

	// Token: 0x06003723 RID: 14115 RVA: 0x0016F6BC File Offset: 0x0016D8BC
	public int ODDPKODCIBB(string IOONFLFOIAH, DAMCJCDKOJK PCLCEDHDBKB, bool OFBDKLHPPNI)
	{
		int num = 1;
		if (OFBDKLHPPNI && (PCLCEDHDBKB == DAMCJCDKOJK.gpbpChoicesCount || PCLCEDHDBKB == DAMCJCDKOJK.gpbpStartDiscount || PCLCEDHDBKB == DAMCJCDKOJK.gpbpDiscountIncrement || PCLCEDHDBKB == DAMCJCDKOJK.gpbpChoicesCountHof || PCLCEDHDBKB == DAMCJCDKOJK.gpbpStartDiscount))
		{
			num = 4;
		}
		int[] array = this.OKBMHDEPEDM(IOONFLFOIAH);
		if (array == null || PCLCEDHDBKB + num >= (DAMCJCDKOJK)array.Length)
		{
			return 1;
		}
		return array[(int)(PCLCEDHDBKB + num)];
	}

	// Token: 0x06003724 RID: 14116 RVA: 0x0016F6FD File Offset: 0x0016D8FD
	public int HEFFIBOJEKC(int ACADLFDGMLP)
	{
		return this.EAPPLDINBGB("cardcollectcardismissing2" + ACADLFDGMLP.ToString());
	}

	// Token: 0x06003725 RID: 14117 RVA: 0x0016F716 File Offset: 0x0016D916
	public float LIKMBLFBEIA()
	{
		if (null != this.INJLPJOGJCO)
		{
			if (this.BDECCAHLOHD < 0f)
			{
				this.BDECCAHLOHD = this.EBMHECHGPDN("asf1");
			}
			return this.BDECCAHLOHD;
		}
		return 1f;
	}

	// Token: 0x06003726 RID: 14118 RVA: 0x0016F750 File Offset: 0x0016D950
	public int BIOBEJEIMND()
	{
		return this.EAPPLDINBGB("sai");
	}

	// Token: 0x06003727 RID: 14119 RVA: 0x0016E591 File Offset: 0x0016C791
	public void BAMHPOCKBML(JSONArray ADGDIJOHHPF)
	{
		this.INJLPJOGJCO = ADGDIJOHHPF;
	}

	// Token: 0x06003728 RID: 14120 RVA: 0x0016F75D File Offset: 0x0016D95D
	public int LDBLDNKPNEN()
	{
		return this.EAPPLDINBGB("Xiaomi");
	}

	// Token: 0x06003729 RID: 14121 RVA: 0x0016F76C File Offset: 0x0016D96C
	public int PLOMCENKKFD(int IFIPOGCCPNF)
	{
		int result;
		try
		{
			result = this.EAPPLDINBGB("hcfc" + IFIPOGCCPNF.ToString());
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
			result = this.EAPPLDINBGB("hcfc");
		}
		return result;
	}

	// Token: 0x0600372A RID: 14122 RVA: 0x0016F7B8 File Offset: 0x0016D9B8
	public int BBLEKILNPOL()
	{
		return this.EAPPLDINBGB("skpc");
	}

	// Token: 0x0600372B RID: 14123 RVA: 0x0016F7C8 File Offset: 0x0016D9C8
	public int PLOMCENKKFD(KIOOJMGLCLC PMJIPJNPEGG)
	{
		if (PMJIPJNPEGG != null)
		{
			try
			{
				return this.EAPPLDINBGB("hcfc" + PMJIPJNPEGG.LLLJOBODOAL.ToString());
			}
			catch (Exception aklgbjkdomm)
			{
				DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
				return this.EAPPLDINBGB("hcfc");
			}
		}
		return this.EAPPLDINBGB("hcfc");
	}

	// Token: 0x0600372C RID: 14124 RVA: 0x0016F828 File Offset: 0x0016DA28
	public int FNDKJAJPMFO()
	{
		return this.EAPPLDINBGB("etfskv");
	}

	// Token: 0x0600372D RID: 14125 RVA: 0x0016F835 File Offset: 0x0016DA35
	public bool NJFAOIDGFGC()
	{
		return this.FLPAOFHFPBM("lngfe", 1) == 1;
	}

	// Token: 0x0600372E RID: 14126 RVA: 0x0016F848 File Offset: 0x0016DA48
	private float EBMHECHGPDN(string NGFBJLAIONI)
	{
		if (null != this.INJLPJOGJCO)
		{
			for (int i = 0; i < this.INJLPJOGJCO.Count; i++)
			{
				if (this.INJLPJOGJCO[i]["id"].Equals(NGFBJLAIONI))
				{
					return this.INJLPJOGJCO[i]["v"].AsFloat;
				}
			}
		}
		DPGJIJGOCIC.ANOPFDLPKGC("GeneralBalance.SearchKeyFloat() - could not find key:" + NGFBJLAIONI);
		return 1f;
	}

	// Token: 0x0600372F RID: 14127 RVA: 0x0016F8CD File Offset: 0x0016DACD
	public int GEHDMLJDLHK(int OKPOGJHANBB)
	{
		return this.EAPPLDINBGB("Account.FixCompletedChaptersIssue() forwards, setting bit to 1 for 'completedChapters[" + OKPOGJHANBB.ToString());
	}

	// Token: 0x06003730 RID: 14128 RVA: 0x0016F8E6 File Offset: 0x0016DAE6
	public bool JPFNDAHKPIK(CEIBHCNNIDC EENGLNKNAPF)
	{
		return this.EAPPLDINBGB("ok" + EENGLNKNAPF.ToString()) == 1;
	}

	// Token: 0x06003731 RID: 14129 RVA: 0x0016F908 File Offset: 0x0016DB08
	public int MNPDCPDPICO(bool KNFIDLNNLAM)
	{
		if (!KNFIDLNNLAM)
		{
			return this.EAPPLDINBGB("shamt");
		}
		return this.EAPPLDINBGB("shamtfp");
	}

	// Token: 0x06003732 RID: 14130 RVA: 0x0016F924 File Offset: 0x0016DB24
	public bool AMHJKMPIPGK()
	{
		return this.FLPAOFHFPBM("fdlse", 0) == 1;
	}

	// Token: 0x06003733 RID: 14131 RVA: 0x0016F935 File Offset: 0x0016DB35
	public bool LJECLABKOLF()
	{
		return this.EAPPLDINBGB("yes") == 1;
	}

	// Token: 0x06003734 RID: 14132 RVA: 0x0016F948 File Offset: 0x0016DB48
	private int AAEMAHFLCBB(string NGFBJLAIONI, int BEPMLIHEKAI)
	{
		string text = "profilenamelevellong";
		if (null != this.INJLPJOGJCO)
		{
			for (int i = 0; i < this.INJLPJOGJCO.Count; i += 0)
			{
				if (this.INJLPJOGJCO[i]["p"].Equals(NGFBJLAIONI))
				{
					text = this.INJLPJOGJCO[i]["ok"];
					break;
				}
			}
		}
		if (text.Length == 0)
		{
			DPGJIJGOCIC.ANOPFDLPKGC("/" + NGFBJLAIONI);
			return 1;
		}
		int[] array = DPGJIJGOCIC.GPJMFMEMFDH(text, '\u0010');
		if (array == null || array.Length == 0)
		{
			DPGJIJGOCIC.ANOPFDLPKGC("clthcm" + NGFBJLAIONI);
			return 0;
		}
		if (BEPMLIHEKAI > array.Length - 1)
		{
			DPGJIJGOCIC.ANOPFDLPKGC("UIEnvironmentsFront" + NGFBJLAIONI);
			return 1;
		}
		return array[BEPMLIHEKAI];
	}

	// Token: 0x06003735 RID: 14133 RVA: 0x0016FA19 File Offset: 0x0016DC19
	public int KLEBNDJIOPB(bool KNFIDLNNLAM)
	{
		if (!KNFIDLNNLAM)
		{
			return this.EAPPLDINBGB("frdsmax");
		}
		return this.EAPPLDINBGB("frdsmaxfp");
	}

	// Token: 0x06003736 RID: 14134 RVA: 0x0016FA38 File Offset: 0x0016DC38
	public int IMPIECOIAHN()
	{
		return this.EAPPLDINBGB("sust" + LanguageManager.EHBBFMCILPC.GetSelectedLanguage().ToString());
	}

	// Token: 0x06003737 RID: 14135 RVA: 0x0016FA6D File Offset: 0x0016DC6D
	public int BIEOHHJMMCE()
	{
		return this.FLPAOFHFPBM("ltfcm", 1);
	}

	// Token: 0x06003738 RID: 14136 RVA: 0x0016FA7B File Offset: 0x0016DC7B
	public string GFKCIAENGEJ(int LMCEDCHDIIB)
	{
		return this.EHOMCFPIBLB("OnApplicationRestart") + LMCEDCHDIIB.ToString();
	}

	// Token: 0x06003739 RID: 14137 RVA: 0x0016FA94 File Offset: 0x0016DC94
	public bool KACCIOPAEMI()
	{
		return this.EAPPLDINBGB("fdvp") == 1;
	}

	// Token: 0x0600373A RID: 14138 RVA: 0x0016FAA4 File Offset: 0x0016DCA4
	public int AIKGPBEOMDM()
	{
		return this.FLPAOFHFPBM("energyhinttitle", 0);
	}

	// Token: 0x0600373B RID: 14139 RVA: 0x0016FAB2 File Offset: 0x0016DCB2
	public int OAFFGDFMHHC()
	{
		return this.EAPPLDINBGB("socialprivatenogiftcardsend");
	}

	// Token: 0x0600373C RID: 14140 RVA: 0x0016FABF File Offset: 0x0016DCBF
	public bool LNKFGOFELAN()
	{
		return this.FLPAOFHFPBM("\r", 1) == 0;
	}

	// Token: 0x0600373D RID: 14141 RVA: 0x0016FAD0 File Offset: 0x0016DCD0
	public bool KNEHCPMJJBE()
	{
		return this.FLPAOFHFPBM("acfe", 1) == 1;
	}

	// Token: 0x0600373E RID: 14142 RVA: 0x0016FAE1 File Offset: 0x0016DCE1
	public bool FMDHKDIEKHF()
	{
		return this.FLPAOFHFPBM("img", 1) == 1;
	}

	// Token: 0x0600373F RID: 14143 RVA: 0x0016FAF2 File Offset: 0x0016DCF2
	public bool AJNJENAFLPP()
	{
		return this.FLPAOFHFPBM("avatarstitle", 0) == 1;
	}

	// Token: 0x06003740 RID: 14144 RVA: 0x0016FB03 File Offset: 0x0016DD03
	public bool DKEMKFOINFO()
	{
		return this.EAPPLDINBGB("<b>") == 0;
	}

	// Token: 0x06003741 RID: 14145 RVA: 0x0016FB13 File Offset: 0x0016DD13
	public float KNMPOFPJKPC()
	{
		if (null != this.INJLPJOGJCO)
		{
			if (this.BDECCAHLOHD < 953f)
			{
				this.BDECCAHLOHD = this.EBMHECHGPDN("lgbtq");
			}
			return this.BDECCAHLOHD;
		}
		return 1158f;
	}

	// Token: 0x06003742 RID: 14146 RVA: 0x0016FB4D File Offset: 0x0016DD4D
	public int IEBEBBNMEIN()
	{
		return this.EAPPLDINBGB("/");
	}

	// Token: 0x06003743 RID: 14147 RVA: 0x0016FB5A File Offset: 0x0016DD5A
	public int BCJPLCIFNIF()
	{
		return this.EAPPLDINBGB("spppi");
	}

	// Token: 0x06003744 RID: 14148 RVA: 0x0016FB67 File Offset: 0x0016DD67
	public int BNPAHACBFGO()
	{
		return this.EAPPLDINBGB(">");
	}

	// Token: 0x06003745 RID: 14149 RVA: 0x0016FB74 File Offset: 0x0016DD74
	public int IHNLEBBKGBC(HOMHOEOKIOB NOGLFFOMDBN)
	{
		if (NOGLFFOMDBN == HOMHOEOKIOB.none)
		{
			return -1;
		}
		return this.JHKGPBCBBNG("sscsp", (int)NOGLFFOMDBN, 5, -1);
	}

	// Token: 0x06003746 RID: 14150 RVA: 0x0016FB8A File Offset: 0x0016DD8A
	public int PPKDBCLAGOG()
	{
		return this.EAPPLDINBGB("facr");
	}

	// Token: 0x06003747 RID: 14151 RVA: 0x0016FB97 File Offset: 0x0016DD97
	public int MPABHPNCPFI(bool KNFIDLNNLAM)
	{
		if (!KNFIDLNNLAM)
		{
			return this.EAPPLDINBGB("energyhinttitle");
		}
		return this.EAPPLDINBGB("isv");
	}

	// Token: 0x06003748 RID: 14152 RVA: 0x0016FBB3 File Offset: 0x0016DDB3
	public int NCOBNDHONEM()
	{
		return this.EAPPLDINBGB("restartrequiredbody");
	}

	// Token: 0x06003749 RID: 14153 RVA: 0x0016FBC0 File Offset: 0x0016DDC0
	public int OFKOCAGJLMP()
	{
		return this.FLPAOFHFPBM("ccpool", KBOJLHAJPCP.JCIHHPFHIOD);
	}

	// Token: 0x0600374A RID: 14154 RVA: 0x0016FBD2 File Offset: 0x0016DDD2
	public int EAOJHINENPI(int ACADLFDGMLP)
	{
		return this.EAPPLDINBGB("avatarcollectionstitle" + ACADLFDGMLP.ToString());
	}

	// Token: 0x0600374B RID: 14155 RVA: 0x0016FBEC File Offset: 0x0016DDEC
	private int EAPPLDINBGB(string NGFBJLAIONI)
	{
		if (null != this.INJLPJOGJCO)
		{
			for (int i = 0; i < this.INJLPJOGJCO.Count; i++)
			{
				if (this.INJLPJOGJCO[i]["id"].Equals(NGFBJLAIONI))
				{
					return this.INJLPJOGJCO[i]["v"].AsInt;
				}
			}
		}
		DPGJIJGOCIC.ANOPFDLPKGC("GeneralBalance.SearchKeyInt() - could not find key:" + NGFBJLAIONI);
		return 0;
	}

	// Token: 0x0600374C RID: 14156 RVA: 0x0016FC6D File Offset: 0x0016DE6D
	public int PBBHBCFAICK()
	{
		return this.EAPPLDINBGB("afs");
	}

	// Token: 0x0600374D RID: 14157 RVA: 0x0016FC7A File Offset: 0x0016DE7A
	public int FKBONEFEDCC()
	{
		return this.EAPPLDINBGB("fubs");
	}

	// Token: 0x0600374E RID: 14158 RVA: 0x0016FC87 File Offset: 0x0016DE87
	public int DDGBLHAEGLB(int ACADLFDGMLP)
	{
		return this.EAPPLDINBGB("\n\n</i><align=\"left\">" + ACADLFDGMLP.ToString());
	}

	// Token: 0x0600374F RID: 14159 RVA: 0x0016FCA0 File Offset: 0x0016DEA0
	public int HHCMJBBEAKO()
	{
		return this.EAPPLDINBGB("hcfc3");
	}

	// Token: 0x06003750 RID: 14160 RVA: 0x0016EE1C File Offset: 0x0016D01C
	public bool LCECDEBOJLM()
	{
		return this.EAPPLDINBGB("") == 0;
	}

	// Token: 0x06003751 RID: 14161 RVA: 0x0016FCAD File Offset: 0x0016DEAD
	public string ABGPKNDPNCD(int LMCEDCHDIIB)
	{
		return this.KKDCLAGMOAF("\"") + LMCEDCHDIIB.ToString();
	}

	// Token: 0x06003752 RID: 14162 RVA: 0x0016FCC6 File Offset: 0x0016DEC6
	public int KJCFGPMBDJL()
	{
		return this.EAPPLDINBGB("wofcoic");
	}

	// Token: 0x06003753 RID: 14163 RVA: 0x0016FCD3 File Offset: 0x0016DED3
	public string BPFPBGGNEBM()
	{
		return this.KKDCLAGMOAF("sssku");
	}

	// Token: 0x06003754 RID: 14164 RVA: 0x0016FCE0 File Offset: 0x0016DEE0
	public bool NDNDKJDIHKA()
	{
		return this.EAPPLDINBGB("encst") == 1;
	}

	// Token: 0x04001069 RID: 4201
	private float JBDGPPMNBOM = -1f;

	// Token: 0x0400106A RID: 4202
	private float BDECCAHLOHD = -1f;

	// Token: 0x0400106B RID: 4203
	private float OONLDBDOLJG = -1f;

	// Token: 0x0400106C RID: 4204
	private JSONArray INJLPJOGJCO;

	// Token: 0x0400106D RID: 4205
	private static KDCJJBLGCBH IKLAPGJDMNA;
}
