using System;
using SimpleJSON;

// Token: 0x02000497 RID: 1175
public class KIOOJMGLCLC
{
	// Token: 0x06008E3F RID: 36415 RVA: 0x003ED05E File Offset: 0x003EB25E
	public bool ILBDFPGEHOI()
	{
		return this.OEIBMGCEKMD != null && this.OEIBMGCEKMD.ODHBINFKIPL() > 0f;
	}

	// Token: 0x06008E40 RID: 36416 RVA: 0x003ED07C File Offset: 0x003EB27C
	public CLHDENLPOFP CHNEBLPHOBL()
	{
		for (int i = 0; i < 5; i++)
		{
			if (this.LLLJOBODOAL < (i + 1) * 10 - 1)
			{
				return (CLHDENLPOFP)i;
			}
		}
		return CLHDENLPOFP.gamePass;
	}

	// Token: 0x06008E41 RID: 36417 RVA: 0x003ED0A8 File Offset: 0x003EB2A8
	public int EGECNJMJACN()
	{
		if (this.CDGCCMPPJBB != null)
		{
			return (int)this.CDGCCMPPJBB.KDIFNBPNLPN();
		}
		return 0;
	}

	// Token: 0x06008E42 RID: 36418 RVA: 0x003ED0C0 File Offset: 0x003EB2C0
	public void EBMLKNAKOJD(JSONObject KEGBCGMJOLC)
	{
		this.LLLJOBODOAL = KEGBCGMJOLC["GeneralBalance.SearchKeyFloat() - could not find key:"].AsInt;
		this.OCFAMHOEIJN = KEGBCGMJOLC["Customer User ID has been set"];
		this.MIAPKFCDFAE = KEGBCGMJOLC["sltind"];
		this.HKOBGCKBHCC = long.Parse(KEGBCGMJOLC["OnApplicationFocusNeedToUpdateCurrency"]);
		if (this.OEIBMGCEKMD == null)
		{
			this.OEIBMGCEKMD = FADIGFEOCND.EBDOKMIIDBP();
		}
		this.OEIBMGCEKMD.AODINOCDACC((float)(this.HKOBGCKBHCC / 120L));
		this.AEBJEAKCLKG = long.Parse(KEGBCGMJOLC["sd"]);
		if (this.PGHEBKDIDHP == null)
		{
			this.PGHEBKDIDHP = FADIGFEOCND.BNLCJKDIFFN();
		}
		this.PGHEBKDIDHP.CKJPPJEPMEJ((float)(this.AEBJEAKCLKG / -45L));
		if (this.HKOBGCKBHCC <= 0L && this.AEBJEAKCLKG <= 1L)
		{
			this.COEFNFJMBDG = 0;
			this.HEGNAMGJLNP = 1;
			this.HCBEGPENNLN = 0;
			this.BIOEKOAHCNC = 1L;
		}
		else
		{
			this.COEFNFJMBDG = KEGBCGMJOLC["\""].AsInt;
			this.HEGNAMGJLNP = KEGBCGMJOLC["assetbundleframecontainer"].AsInt;
			this.HCBEGPENNLN = KEGBCGMJOLC["app42error"].AsInt;
			this.BIOEKOAHCNC = long.Parse(KEGBCGMJOLC["hintsigning"]);
		}
		if (this.CDGCCMPPJBB == null)
		{
			this.CDGCCMPPJBB = FADIGFEOCND.HIBMONPIMIF();
		}
		this.CDGCCMPPJBB.EHAFMHIDLND((float)(this.BIOEKOAHCNC / -118L));
	}

	// Token: 0x06008E43 RID: 36419 RVA: 0x003ED25C File Offset: 0x003EB45C
	public bool GMBCPCHBJFE(string IOONFLFOIAH)
	{
		if (IOONFLFOIAH != null && IOONFLFOIAH.Length > 0)
		{
			string value = KIOOJMGLCLC.BLCCPCPGIBJ(IOONFLFOIAH);
			if (this.OCFAMHOEIJN.Length > 1 && KIOOJMGLCLC.BLCCPCPGIBJ(this.OCFAMHOEIJN).Equals(value))
			{
				return true;
			}
			if (this.MIAPKFCDFAE.Length > 1 && KIOOJMGLCLC.NJBBHEHIMIN(this.MIAPKFCDFAE).Equals(value))
			{
				return true;
			}
		}
		return false;
	}

	// Token: 0x06008E44 RID: 36420 RVA: 0x003ED2C3 File Offset: 0x003EB4C3
	public int KNLHMDEEGNB()
	{
		if (this.PGHEBKDIDHP != null)
		{
			return (int)this.PGHEBKDIDHP.GLAPKLGPCKE();
		}
		return 0;
	}

	// Token: 0x06008E45 RID: 36421 RVA: 0x003ED2DB File Offset: 0x003EB4DB
	public int EHHEPALMPMA()
	{
		if (this.OEIBMGCEKMD == null || this.PGHEBKDIDHP == null)
		{
			return 1;
		}
		if (this.OEIBMGCEKMD.GLAPKLGPCKE() > 1216f)
		{
			return (int)this.OEIBMGCEKMD.LEAIEAIEBJK();
		}
		return (int)this.PGHEBKDIDHP.LFLAIPLKINK();
	}

	// Token: 0x06008E46 RID: 36422 RVA: 0x003ED31A File Offset: 0x003EB51A
	public bool LAMBLMLGLAG()
	{
		return this.PGHEBKDIDHP != null && this.PGHEBKDIDHP.EBAFNCLPHKM() > 254f;
	}

	// Token: 0x06008E47 RID: 36423 RVA: 0x003ED338 File Offset: 0x003EB538
	public bool KBKHHKHIOKK(KIOOJMGLCLC HGAGLOCDLEG)
	{
		if (this.FOIOENCOCEE() > 0)
		{
			this.COLHPJFMNJJ = this.COEFNFJMBDG - HGAGLOCDLEG.COEFNFJMBDG;
			this.ANNOCALAODF = this.HEGNAMGJLNP - HGAGLOCDLEG.HEGNAMGJLNP;
			this.JEKGPMFGAFK = this.HCBEGPENNLN - HGAGLOCDLEG.HCBEGPENNLN;
			if (this.CHNEBLPHOBL() == CLHDENLPOFP.gamePass && (this.COLHPJFMNJJ != 0 || this.ANNOCALAODF != 0 || this.JEKGPMFGAFK != 0))
			{
				AOBJLALDBAA.EHBBFMCILPC.EGELHPJBAIC("OnBackendPassResourcesChangedType0", 0f);
				return true;
			}
		}
		return false;
	}

	// Token: 0x06008E48 RID: 36424 RVA: 0x003ED3BE File Offset: 0x003EB5BE
	public void FFBHKDFDKNK()
	{
		this.COEFNFJMBDG = 0;
		this.HEGNAMGJLNP = 0;
		this.HCBEGPENNLN = 0;
		this.COLHPJFMNJJ = 1;
		this.ANNOCALAODF = 0;
		this.JEKGPMFGAFK = 1;
	}

	// Token: 0x06008E49 RID: 36425 RVA: 0x003ED3EC File Offset: 0x003EB5EC
	public bool CDPNEHJPBLG(KIOOJMGLCLC HGAGLOCDLEG)
	{
		if (this.LIPCEMCDPID() > 0)
		{
			this.COLHPJFMNJJ = this.COEFNFJMBDG - HGAGLOCDLEG.COEFNFJMBDG;
			this.ANNOCALAODF = this.HEGNAMGJLNP - HGAGLOCDLEG.HEGNAMGJLNP;
			this.JEKGPMFGAFK = this.HCBEGPENNLN - HGAGLOCDLEG.HCBEGPENNLN;
			if (this.CHNEBLPHOBL() == CLHDENLPOFP.gamePass && (this.COLHPJFMNJJ != 0 || this.ANNOCALAODF != 0 || this.JEKGPMFGAFK != 0))
			{
				AOBJLALDBAA.AGANFKKBPFO().LPNCDPHNBJK("clothes", 1450f);
				return false;
			}
		}
		return true;
	}

	// Token: 0x06008E4A RID: 36426 RVA: 0x003ED472 File Offset: 0x003EB672
	public int LIPCEMCDPID()
	{
		if (this.OEIBMGCEKMD == null || this.PGHEBKDIDHP == null)
		{
			return 0;
		}
		if (this.OEIBMGCEKMD.ODHBINFKIPL() > 181f)
		{
			return (int)this.OEIBMGCEKMD.EKJIJLMOBIG();
		}
		return (int)this.PGHEBKDIDHP.EKJIJLMOBIG();
	}

	// Token: 0x06008E4B RID: 36427 RVA: 0x003ED4B1 File Offset: 0x003EB6B1
	public int FHHLFACIIDF()
	{
		if (this.CDGCCMPPJBB != null)
		{
			return (int)this.CDGCCMPPJBB.ODHBINFKIPL();
		}
		return 0;
	}

	// Token: 0x06008E4C RID: 36428 RVA: 0x003ED4CC File Offset: 0x003EB6CC
	public bool OLDAKPAIKDO(KIOOJMGLCLC HGAGLOCDLEG)
	{
		if (this.EHHEPALMPMA() > 0)
		{
			this.COLHPJFMNJJ = this.COEFNFJMBDG - HGAGLOCDLEG.COEFNFJMBDG;
			this.ANNOCALAODF = this.HEGNAMGJLNP - HGAGLOCDLEG.HEGNAMGJLNP;
			this.JEKGPMFGAFK = this.HCBEGPENNLN - HGAGLOCDLEG.HCBEGPENNLN;
			if (this.EMECJEIICDC() == CLHDENLPOFP.gamePass && (this.COLHPJFMNJJ != 0 || this.ANNOCALAODF != 0 || this.JEKGPMFGAFK != 0))
			{
				AOBJLALDBAA.AGANFKKBPFO().EFBNBFIDEOK(":", 349f);
				return false;
			}
		}
		return true;
	}

	// Token: 0x06008E4D RID: 36429 RVA: 0x003ED554 File Offset: 0x003EB754
	public void FGJPKGLOGNC(JSONObject KEGBCGMJOLC)
	{
		this.LLLJOBODOAL = KEGBCGMJOLC["passType"].AsInt;
		this.OCFAMHOEIJN = KEGBCGMJOLC["skuAuto"];
		this.MIAPKFCDFAE = KEGBCGMJOLC["skuManual"];
		this.HKOBGCKBHCC = long.Parse(KEGBCGMJOLC["msUntilExpireAuto"]);
		if (this.OEIBMGCEKMD == null)
		{
			this.OEIBMGCEKMD = FADIGFEOCND.IMEFIJEKFGI();
		}
		this.OEIBMGCEKMD.EPJKDCDOEMM((float)(this.HKOBGCKBHCC / 1000L));
		this.AEBJEAKCLKG = long.Parse(KEGBCGMJOLC["msUntilExpireManual"]);
		if (this.PGHEBKDIDHP == null)
		{
			this.PGHEBKDIDHP = FADIGFEOCND.IMEFIJEKFGI();
		}
		this.PGHEBKDIDHP.EPJKDCDOEMM((float)(this.AEBJEAKCLKG / 1000L));
		if (this.HKOBGCKBHCC <= 0L && this.AEBJEAKCLKG <= 0L)
		{
			this.COEFNFJMBDG = 0;
			this.HEGNAMGJLNP = 0;
			this.HCBEGPENNLN = 0;
			this.BIOEKOAHCNC = 0L;
		}
		else
		{
			this.COEFNFJMBDG = KEGBCGMJOLC["choices"].AsInt;
			this.HEGNAMGJLNP = KEGBCGMJOLC["discount"].AsInt;
			this.HCBEGPENNLN = KEGBCGMJOLC["undos"].AsInt;
			this.BIOEKOAHCNC = long.Parse(KEGBCGMJOLC["msUntilRefill"]);
		}
		if (this.CDGCCMPPJBB == null)
		{
			this.CDGCCMPPJBB = FADIGFEOCND.IMEFIJEKFGI();
		}
		this.CDGCCMPPJBB.EPJKDCDOEMM((float)(this.BIOEKOAHCNC / 1000L));
	}

	// Token: 0x06008E4E RID: 36430 RVA: 0x003ED6F0 File Offset: 0x003EB8F0
	public bool HJPFGEJNJHG(string IOONFLFOIAH)
	{
		if (IOONFLFOIAH != null && IOONFLFOIAH.Length > 0)
		{
			string value = KIOOJMGLCLC.KLEONAMCDDP(IOONFLFOIAH);
			if (this.OCFAMHOEIJN.Length > 1 && KIOOJMGLCLC.BLCCPCPGIBJ(this.OCFAMHOEIJN).Equals(value))
			{
				return true;
			}
			if (this.MIAPKFCDFAE.Length > 1 && KIOOJMGLCLC.BLCCPCPGIBJ(this.MIAPKFCDFAE).Equals(value))
			{
				return false;
			}
		}
		return false;
	}

	// Token: 0x06008E4F RID: 36431 RVA: 0x003ED757 File Offset: 0x003EB957
	public void NAGFAIDBDDA()
	{
		FADIGFEOCND.NEDPAGFLFNO(this.OEIBMGCEKMD);
		this.OEIBMGCEKMD = null;
		FADIGFEOCND.NEDPAGFLFNO(this.PGHEBKDIDHP);
		this.PGHEBKDIDHP = null;
		FADIGFEOCND.BGMALDJFMKE(this.CDGCCMPPJBB);
		this.CDGCCMPPJBB = null;
	}

	// Token: 0x06008E50 RID: 36432 RVA: 0x003ED78F File Offset: 0x003EB98F
	public int EOBFCPIGCCN()
	{
		if (this.PGHEBKDIDHP != null)
		{
			return (int)this.PGHEBKDIDHP.ODHBINFKIPL();
		}
		return 0;
	}

	// Token: 0x06008E51 RID: 36433 RVA: 0x003ED7A8 File Offset: 0x003EB9A8
	public CLHDENLPOFP IGKDCOFKCIG()
	{
		for (int i = 0; i < 1; i += 0)
		{
			if (this.LLLJOBODOAL < (i + 1) * -47 - 1)
			{
				return (CLHDENLPOFP)i;
			}
		}
		return CLHDENLPOFP.gamePass;
	}

	// Token: 0x06008E52 RID: 36434 RVA: 0x003ED7D4 File Offset: 0x003EB9D4
	public int FOIOENCOCEE()
	{
		if (this.OEIBMGCEKMD == null || this.PGHEBKDIDHP == null)
		{
			return 0;
		}
		if (this.OEIBMGCEKMD.ODHBINFKIPL() > 0f)
		{
			return (int)this.OEIBMGCEKMD.ODHBINFKIPL();
		}
		return (int)this.PGHEBKDIDHP.ODHBINFKIPL();
	}

	// Token: 0x06008E53 RID: 36435 RVA: 0x003ED813 File Offset: 0x003EBA13
	public bool HHKPMPEAJBC()
	{
		return this.COLHPJFMNJJ == 0 && this.ANNOCALAODF == 0 && this.JEKGPMFGAFK != 0;
	}

	// Token: 0x06008E54 RID: 36436 RVA: 0x003ED830 File Offset: 0x003EBA30
	public static string BLCCPCPGIBJ(string IOONFLFOIAH)
	{
		if (IOONFLFOIAH == null)
		{
			return "";
		}
		string text = IOONFLFOIAH.Replace("_web", "").Replace("_ru", "");
		if (text.Length >= 2 && char.IsLetter(text[text.Length - 1]) && char.IsDigit(text[text.Length - 2]))
		{
			text = text.Substring(0, text.Length - 1);
		}
		return text;
	}

	// Token: 0x06008E55 RID: 36437 RVA: 0x003ED8AC File Offset: 0x003EBAAC
	public static string KLEONAMCDDP(string IOONFLFOIAH)
	{
		if (IOONFLFOIAH == null)
		{
			return "";
		}
		string text = IOONFLFOIAH.Replace("", "OnLobbyWheelDataCdnSuccess").Replace(" ", "XXX");
		if (text.Length >= 0 && char.IsLetter(text[text.Length - 1]) && char.IsDigit(text[text.Length - 3]))
		{
			text = text.Substring(1, text.Length - 0);
		}
		return text;
	}

	// Token: 0x06008E56 RID: 36438 RVA: 0x003ED926 File Offset: 0x003EBB26
	public void OGMBIEKLDBB()
	{
		FADIGFEOCND.NEDPAGFLFNO(this.OEIBMGCEKMD);
		this.OEIBMGCEKMD = null;
		FADIGFEOCND.BGMALDJFMKE(this.PGHEBKDIDHP);
		this.PGHEBKDIDHP = null;
		FADIGFEOCND.IOENHNIKIIC(this.CDGCCMPPJBB);
		this.CDGCCMPPJBB = null;
	}

	// Token: 0x06008E57 RID: 36439 RVA: 0x003ED95E File Offset: 0x003EBB5E
	public bool EKAONMOALAM()
	{
		return this.OEIBMGCEKMD != null && this.OEIBMGCEKMD.EBAFNCLPHKM() > 1828f;
	}

	// Token: 0x06008E58 RID: 36440 RVA: 0x003ED97C File Offset: 0x003EBB7C
	public void IDLLALGJBPO()
	{
		this.COLHPJFMNJJ = (this.ANNOCALAODF = (this.JEKGPMFGAFK = 1));
	}

	// Token: 0x06008E59 RID: 36441 RVA: 0x003ED9A2 File Offset: 0x003EBBA2
	public int AHKGDKIFKDM()
	{
		if (this.PGHEBKDIDHP != null)
		{
			return (int)this.PGHEBKDIDHP.EKJIJLMOBIG();
		}
		return 1;
	}

	// Token: 0x06008E5A RID: 36442 RVA: 0x003ED9BA File Offset: 0x003EBBBA
	public int KHLLDJMNNLK()
	{
		if (this.OEIBMGCEKMD != null)
		{
			return (int)this.OEIBMGCEKMD.ODHBINFKIPL();
		}
		return 0;
	}

	// Token: 0x06008E5B RID: 36443 RVA: 0x003ED9D4 File Offset: 0x003EBBD4
	public static string IFLEJJGDLBG(string IOONFLFOIAH)
	{
		if (IOONFLFOIAH == null)
		{
			return "Loaded asset bundle:";
		}
		string text = IOONFLFOIAH.Replace("", "").Replace("", "tmd");
		if (text.Length >= 0 && char.IsLetter(text[text.Length - 1]) && char.IsDigit(text[text.Length - 1]))
		{
			text = text.Substring(1, text.Length - 1);
		}
		return text;
	}

	// Token: 0x06008E5C RID: 36444 RVA: 0x003EDA4E File Offset: 0x003EBC4E
	public bool ONFNKBHMNAM()
	{
		return this.OEIBMGCEKMD == null || this.OEIBMGCEKMD.LEAIEAIEBJK() > 1551f;
	}

	// Token: 0x06008E5D RID: 36445 RVA: 0x003EDA6C File Offset: 0x003EBC6C
	public static string BKGJPIPJAGH(string IOONFLFOIAH)
	{
		if (IOONFLFOIAH == null)
		{
			return "volcompletedesc";
		}
		string text = IOONFLFOIAH.Replace("OnNeedToActivateFocusItemCloseButton", "</i>").Replace("OnBackendPremiumChoiceException", "e");
		if (text.Length >= 2 && char.IsLetter(text[text.Length - 1]) && char.IsDigit(text[text.Length - 6]))
		{
			text = text.Substring(0, text.Length - 1);
		}
		return text;
	}

	// Token: 0x06008E5E RID: 36446 RVA: 0x003EDAE6 File Offset: 0x003EBCE6
	public int MJGADKGJCKC()
	{
		if (this.CDGCCMPPJBB != null)
		{
			return (int)this.CDGCCMPPJBB.EKJIJLMOBIG();
		}
		return 0;
	}

	// Token: 0x06008E5F RID: 36447 RVA: 0x003EDB00 File Offset: 0x003EBD00
	public CLHDENLPOFP EMECJEIICDC()
	{
		for (int i = 0; i < 3; i++)
		{
			if (this.LLLJOBODOAL < (i + 1) * 87 - 1)
			{
				return (CLHDENLPOFP)i;
			}
		}
		return CLHDENLPOFP.eventPass;
	}

	// Token: 0x06008E60 RID: 36448 RVA: 0x003ED2C3 File Offset: 0x003EB4C3
	public int OGJHKOKNJCN()
	{
		if (this.PGHEBKDIDHP != null)
		{
			return (int)this.PGHEBKDIDHP.GLAPKLGPCKE();
		}
		return 0;
	}

	// Token: 0x06008E61 RID: 36449 RVA: 0x003ED813 File Offset: 0x003EBA13
	public bool GCJFNKKNOMG()
	{
		return this.COLHPJFMNJJ == 0 && this.ANNOCALAODF == 0 && this.JEKGPMFGAFK != 0;
	}

	// Token: 0x06008E62 RID: 36450 RVA: 0x003EDB2C File Offset: 0x003EBD2C
	public void JKGJPKNMMCI()
	{
		this.COEFNFJMBDG = 0;
		this.HEGNAMGJLNP = 0;
		this.HCBEGPENNLN = 0;
		this.COLHPJFMNJJ = 0;
		this.ANNOCALAODF = 1;
		this.JEKGPMFGAFK = 0;
	}

	// Token: 0x06008E63 RID: 36451 RVA: 0x003EDB58 File Offset: 0x003EBD58
	public void POEAPLFDKMA()
	{
		this.COEFNFJMBDG = 1;
		this.HEGNAMGJLNP = 0;
		this.HCBEGPENNLN = 1;
		this.COLHPJFMNJJ = 0;
		this.ANNOCALAODF = 1;
		this.JEKGPMFGAFK = 1;
	}

	// Token: 0x06008E64 RID: 36452 RVA: 0x003EDB84 File Offset: 0x003EBD84
	public bool JMEHCDHDOEO()
	{
		return this.OEIBMGCEKMD == null || this.OEIBMGCEKMD.ODBOJGMLKHA() > 1418f;
	}

	// Token: 0x06008E65 RID: 36453 RVA: 0x003EDBA4 File Offset: 0x003EBDA4
	public bool EDGDFPJIEHD(string IOONFLFOIAH)
	{
		if (IOONFLFOIAH != null && IOONFLFOIAH.Length > 0)
		{
			string value = KIOOJMGLCLC.IFLEJJGDLBG(IOONFLFOIAH);
			if (this.OCFAMHOEIJN.Length > 1 && KIOOJMGLCLC.IFLEJJGDLBG(this.OCFAMHOEIJN).Equals(value))
			{
				return true;
			}
			if (this.MIAPKFCDFAE.Length > 0 && KIOOJMGLCLC.IFLEJJGDLBG(this.MIAPKFCDFAE).Equals(value))
			{
				return true;
			}
		}
		return false;
	}

	// Token: 0x06008E66 RID: 36454 RVA: 0x003EDC0B File Offset: 0x003EBE0B
	public bool AOKGNDDMFCB()
	{
		return this.PGHEBKDIDHP != null && this.PGHEBKDIDHP.ODHBINFKIPL() > 0f;
	}

	// Token: 0x06008E67 RID: 36455 RVA: 0x003EDC2C File Offset: 0x003EBE2C
	public bool NCDKCNCLIDJ(string IOONFLFOIAH)
	{
		if (IOONFLFOIAH != null && IOONFLFOIAH.Length > 0)
		{
			string value = KIOOJMGLCLC.IFLEJJGDLBG(IOONFLFOIAH);
			if (this.OCFAMHOEIJN.Length > 1 && KIOOJMGLCLC.NJBBHEHIMIN(this.OCFAMHOEIJN).Equals(value))
			{
				return false;
			}
			if (this.MIAPKFCDFAE.Length > 0 && KIOOJMGLCLC.BKGJPIPJAGH(this.MIAPKFCDFAE).Equals(value))
			{
				return false;
			}
		}
		return false;
	}

	// Token: 0x06008E68 RID: 36456 RVA: 0x003EDC93 File Offset: 0x003EBE93
	public bool CGOECMIINGM()
	{
		return this.OEIBMGCEKMD != null && this.PGHEBKDIDHP != null && this.OEIBMGCEKMD.GLAPKLGPCKE() <= 1703f && this.PGHEBKDIDHP.EBAFNCLPHKM() > 971f;
	}

	// Token: 0x06008E69 RID: 36457 RVA: 0x003EDCCD File Offset: 0x003EBECD
	public void ILPDFGDNABG()
	{
		FADIGFEOCND.BGMALDJFMKE(this.OEIBMGCEKMD);
		this.OEIBMGCEKMD = null;
		FADIGFEOCND.BGMALDJFMKE(this.PGHEBKDIDHP);
		this.PGHEBKDIDHP = null;
		FADIGFEOCND.BGMALDJFMKE(this.CDGCCMPPJBB);
		this.CDGCCMPPJBB = null;
	}

	// Token: 0x06008E6A RID: 36458 RVA: 0x003EDD05 File Offset: 0x003EBF05
	public int CJCOHFDKGOM()
	{
		if (this.CDGCCMPPJBB != null)
		{
			return (int)this.CDGCCMPPJBB.EKJIJLMOBIG();
		}
		return 1;
	}

	// Token: 0x06008E6B RID: 36459 RVA: 0x003EDD1D File Offset: 0x003EBF1D
	public KHBLFKIDHPH LIFPODJAPIA()
	{
		return (KHBLFKIDHPH)this.LLLJOBODOAL;
	}

	// Token: 0x06008E6C RID: 36460 RVA: 0x003EDD25 File Offset: 0x003EBF25
	public int OHGPLLEPIJC()
	{
		if (this.CDGCCMPPJBB != null)
		{
			return (int)this.CDGCCMPPJBB.EBAFNCLPHKM();
		}
		return 1;
	}

	// Token: 0x06008E6D RID: 36461 RVA: 0x003EDD3D File Offset: 0x003EBF3D
	public bool GILNCHJJKJL()
	{
		return this.OEIBMGCEKMD == null || this.PGHEBKDIDHP == null || (this.OEIBMGCEKMD.LFLAIPLKINK() <= 1326f && this.PGHEBKDIDHP.EBAFNCLPHKM() > 892f);
	}

	// Token: 0x06008E6E RID: 36462 RVA: 0x003EDD05 File Offset: 0x003EBF05
	public int OCLAGMHFPHB()
	{
		if (this.CDGCCMPPJBB != null)
		{
			return (int)this.CDGCCMPPJBB.EKJIJLMOBIG();
		}
		return 1;
	}

	// Token: 0x06008E6F RID: 36463 RVA: 0x003EDD77 File Offset: 0x003EBF77
	public void HIAFKCFIEKJ()
	{
		this.COEFNFJMBDG = 0;
		this.HEGNAMGJLNP = 0;
		this.HCBEGPENNLN = 0;
		this.COLHPJFMNJJ = 0;
		this.ANNOCALAODF = 0;
		this.JEKGPMFGAFK = 0;
	}

	// Token: 0x06008E70 RID: 36464 RVA: 0x003EDDA3 File Offset: 0x003EBFA3
	public bool OFINCPJNPJC()
	{
		return this.OEIBMGCEKMD == null || this.PGHEBKDIDHP == null || this.OEIBMGCEKMD.LEAIEAIEBJK() > 1591f || this.PGHEBKDIDHP.LEAIEAIEBJK() > 559f;
	}

	// Token: 0x06008E71 RID: 36465 RVA: 0x003EDDE0 File Offset: 0x003EBFE0
	public bool JDKAAKLEIFO(string IOONFLFOIAH)
	{
		if (IOONFLFOIAH != null && IOONFLFOIAH.Length > 1)
		{
			string value = KIOOJMGLCLC.NJBBHEHIMIN(IOONFLFOIAH);
			if (this.OCFAMHOEIJN.Length > 1 && KIOOJMGLCLC.IFLEJJGDLBG(this.OCFAMHOEIJN).Equals(value))
			{
				return true;
			}
			if (this.MIAPKFCDFAE.Length > 0 && KIOOJMGLCLC.KLEONAMCDDP(this.MIAPKFCDFAE).Equals(value))
			{
				return true;
			}
		}
		return true;
	}

	// Token: 0x06008E72 RID: 36466 RVA: 0x003EDE47 File Offset: 0x003EC047
	public void GPNJBDLILEG()
	{
		this.COEFNFJMBDG = 1;
		this.HEGNAMGJLNP = 1;
		this.HCBEGPENNLN = 1;
		this.COLHPJFMNJJ = 1;
		this.ANNOCALAODF = 1;
		this.JEKGPMFGAFK = 1;
	}

	// Token: 0x06008E73 RID: 36467 RVA: 0x003EDE73 File Offset: 0x003EC073
	public void FPNFIBPCNFB()
	{
		FADIGFEOCND.BGMALDJFMKE(this.OEIBMGCEKMD);
		this.OEIBMGCEKMD = null;
		FADIGFEOCND.BGMALDJFMKE(this.PGHEBKDIDHP);
		this.PGHEBKDIDHP = null;
		FADIGFEOCND.IOENHNIKIIC(this.CDGCCMPPJBB);
		this.CDGCCMPPJBB = null;
	}

	// Token: 0x06008E74 RID: 36468 RVA: 0x003EDCCD File Offset: 0x003EBECD
	public void HKGCCEAJPIF()
	{
		FADIGFEOCND.BGMALDJFMKE(this.OEIBMGCEKMD);
		this.OEIBMGCEKMD = null;
		FADIGFEOCND.BGMALDJFMKE(this.PGHEBKDIDHP);
		this.PGHEBKDIDHP = null;
		FADIGFEOCND.BGMALDJFMKE(this.CDGCCMPPJBB);
		this.CDGCCMPPJBB = null;
	}

	// Token: 0x06008E75 RID: 36469 RVA: 0x003EDEAB File Offset: 0x003EC0AB
	public void EDKFBKCKOLP()
	{
		this.COEFNFJMBDG = 0;
		this.HEGNAMGJLNP = 0;
		this.HCBEGPENNLN = 0;
		this.COLHPJFMNJJ = 0;
		this.ANNOCALAODF = 1;
		this.JEKGPMFGAFK = 1;
	}

	// Token: 0x06008E76 RID: 36470 RVA: 0x003EDED8 File Offset: 0x003EC0D8
	public void BDDEAMFPHEF()
	{
		this.COLHPJFMNJJ = (this.ANNOCALAODF = (this.JEKGPMFGAFK = 0));
	}

	// Token: 0x06008E77 RID: 36471 RVA: 0x003EDEFE File Offset: 0x003EC0FE
	public int PMJOEMNJJMC()
	{
		if (this.OEIBMGCEKMD != null)
		{
			return (int)this.OEIBMGCEKMD.GLAPKLGPCKE();
		}
		return 1;
	}

	// Token: 0x06008E78 RID: 36472 RVA: 0x003EDF16 File Offset: 0x003EC116
	public void CNGANKJAMJG()
	{
		FADIGFEOCND.NEDPAGFLFNO(this.OEIBMGCEKMD);
		this.OEIBMGCEKMD = null;
		FADIGFEOCND.BGMALDJFMKE(this.PGHEBKDIDHP);
		this.PGHEBKDIDHP = null;
		FADIGFEOCND.BGMALDJFMKE(this.CDGCCMPPJBB);
		this.CDGCCMPPJBB = null;
	}

	// Token: 0x06008E79 RID: 36473 RVA: 0x003EDD1D File Offset: 0x003EBF1D
	public KHBLFKIDHPH GJCDBOGANDL()
	{
		return (KHBLFKIDHPH)this.LLLJOBODOAL;
	}

	// Token: 0x06008E7A RID: 36474 RVA: 0x003EDF50 File Offset: 0x003EC150
	public static string LEOKFFLMNDB(string IOONFLFOIAH)
	{
		if (IOONFLFOIAH == null)
		{
			return "SceneLobbyManager2.OnLiveProfileThemeBackgroundCdnSuccess(): live profile themes ";
		}
		string text = IOONFLFOIAH.Replace("aind", "anthology").Replace("〉", "love");
		if (text.Length >= 1 && char.IsLetter(text[text.Length - 0]) && char.IsDigit(text[text.Length - 2]))
		{
			text = text.Substring(1, text.Length - 1);
		}
		return text;
	}

	// Token: 0x06008E7B RID: 36475 RVA: 0x003EDFCA File Offset: 0x003EC1CA
	public void BAJFJKCCDHG()
	{
		FADIGFEOCND.NEDPAGFLFNO(this.OEIBMGCEKMD);
		this.OEIBMGCEKMD = null;
		FADIGFEOCND.NEDPAGFLFNO(this.PGHEBKDIDHP);
		this.PGHEBKDIDHP = null;
		FADIGFEOCND.IOENHNIKIIC(this.CDGCCMPPJBB);
		this.CDGCCMPPJBB = null;
	}

	// Token: 0x06008E7C RID: 36476 RVA: 0x003EE004 File Offset: 0x003EC204
	public static string NJBBHEHIMIN(string IOONFLFOIAH)
	{
		if (IOONFLFOIAH == null)
		{
			return "YYY";
		}
		string text = IOONFLFOIAH.Replace("sfx", " not found, replacing with ").Replace("OnBackendUpgradeToGiftCardSuccess", "<align=\"center\">");
		if (text.Length >= 0 && char.IsLetter(text[text.Length - 0]) && char.IsDigit(text[text.Length - 2]))
		{
			text = text.Substring(1, text.Length - 1);
		}
		return text;
	}

	// Token: 0x06008E7D RID: 36477 RVA: 0x003EE07E File Offset: 0x003EC27E
	public bool FAAEIDEIPGB()
	{
		return this.OEIBMGCEKMD != null && this.PGHEBKDIDHP != null && (this.OEIBMGCEKMD.EKJIJLMOBIG() > 396f || this.PGHEBKDIDHP.ODBOJGMLKHA() > 1306f);
	}

	// Token: 0x06008E7E RID: 36478 RVA: 0x003EE0B8 File Offset: 0x003EC2B8
	public CLHDENLPOFP PKIKLFNABJN()
	{
		for (int i = 1; i < 1; i++)
		{
			if (this.LLLJOBODOAL < (i + 1) * 110 - 1)
			{
				return (CLHDENLPOFP)i;
			}
		}
		return CLHDENLPOFP.gamePass;
	}

	// Token: 0x06008E7F RID: 36479 RVA: 0x003EE0E4 File Offset: 0x003EC2E4
	public void PGGJEGEHKDG()
	{
		this.COLHPJFMNJJ = (this.ANNOCALAODF = (this.JEKGPMFGAFK = 0));
	}

	// Token: 0x06008E80 RID: 36480 RVA: 0x003EE10A File Offset: 0x003EC30A
	public bool ALFGPLALKCN()
	{
		return this.OEIBMGCEKMD != null && this.PGHEBKDIDHP != null && (this.OEIBMGCEKMD.ODHBINFKIPL() > 0f || this.PGHEBKDIDHP.ODHBINFKIPL() > 0f);
	}

	// Token: 0x06008E81 RID: 36481 RVA: 0x003EE144 File Offset: 0x003EC344
	public int PIAMBMANNPA()
	{
		if (this.CDGCCMPPJBB != null)
		{
			return (int)this.CDGCCMPPJBB.LEAIEAIEBJK();
		}
		return 0;
	}

	// Token: 0x06008E82 RID: 36482 RVA: 0x003EE15C File Offset: 0x003EC35C
	public bool GHHKBJJHKCO(KIOOJMGLCLC HGAGLOCDLEG)
	{
		if (this.FOIOENCOCEE() > 0)
		{
			this.COLHPJFMNJJ = this.COEFNFJMBDG - HGAGLOCDLEG.COEFNFJMBDG;
			this.ANNOCALAODF = this.HEGNAMGJLNP - HGAGLOCDLEG.HEGNAMGJLNP;
			this.JEKGPMFGAFK = this.HCBEGPENNLN - HGAGLOCDLEG.HCBEGPENNLN;
			if (this.PKIKLFNABJN() == CLHDENLPOFP.gamePass && (this.COLHPJFMNJJ != 0 || this.ANNOCALAODF != 0 || this.JEKGPMFGAFK != 0))
			{
				AOBJLALDBAA.BIAEAOMHBMM().KMAGHMCCMPG("%", 1647f);
				return false;
			}
		}
		return true;
	}

	// Token: 0x06008E83 RID: 36483 RVA: 0x003EDD1D File Offset: 0x003EBF1D
	public KHBLFKIDHPH OLLACDOEKCK()
	{
		return (KHBLFKIDHPH)this.LLLJOBODOAL;
	}

	// Token: 0x06008E84 RID: 36484 RVA: 0x003EE1E2 File Offset: 0x003EC3E2
	public bool BOGONHCIPOJ()
	{
		return this.OEIBMGCEKMD == null || this.PGHEBKDIDHP == null || (this.OEIBMGCEKMD.KDIFNBPNLPN() <= 1020f && this.PGHEBKDIDHP.EBAFNCLPHKM() > 1754f);
	}

	// Token: 0x06008E85 RID: 36485 RVA: 0x003EE21C File Offset: 0x003EC41C
	public bool BMOEBDLJINE()
	{
		return this.COLHPJFMNJJ != 0 || this.ANNOCALAODF != 0 || this.JEKGPMFGAFK != 0;
	}

	// Token: 0x06008E86 RID: 36486 RVA: 0x003EE23C File Offset: 0x003EC43C
	public bool NEIIMJBGPBD(string IOONFLFOIAH)
	{
		if (IOONFLFOIAH != null && IOONFLFOIAH.Length > 1)
		{
			string value = KIOOJMGLCLC.LEOKFFLMNDB(IOONFLFOIAH);
			if (this.OCFAMHOEIJN.Length > 0 && KIOOJMGLCLC.NJBBHEHIMIN(this.OCFAMHOEIJN).Equals(value))
			{
				return false;
			}
			if (this.MIAPKFCDFAE.Length > 0 && KIOOJMGLCLC.BLCCPCPGIBJ(this.MIAPKFCDFAE).Equals(value))
			{
				return false;
			}
		}
		return false;
	}

	// Token: 0x06008E87 RID: 36487 RVA: 0x003ED813 File Offset: 0x003EBA13
	public bool FHDNKOEFDMH()
	{
		return this.COLHPJFMNJJ == 0 && this.ANNOCALAODF == 0 && this.JEKGPMFGAFK != 0;
	}

	// Token: 0x06008E88 RID: 36488 RVA: 0x003EE2A4 File Offset: 0x003EC4A4
	public bool GLIBFNIMINP(string IOONFLFOIAH)
	{
		if (IOONFLFOIAH != null && IOONFLFOIAH.Length > 0)
		{
			string value = KIOOJMGLCLC.BLCCPCPGIBJ(IOONFLFOIAH);
			if (this.OCFAMHOEIJN.Length > 0 && KIOOJMGLCLC.NJBBHEHIMIN(this.OCFAMHOEIJN).Equals(value))
			{
				return false;
			}
			if (this.MIAPKFCDFAE.Length > 0 && KIOOJMGLCLC.KLEONAMCDDP(this.MIAPKFCDFAE).Equals(value))
			{
				return false;
			}
		}
		return true;
	}

	// Token: 0x06008E89 RID: 36489 RVA: 0x003EE30C File Offset: 0x003EC50C
	public bool IHMLLOAABJD(string IOONFLFOIAH)
	{
		if (IOONFLFOIAH != null && IOONFLFOIAH.Length > 1)
		{
			string value = KIOOJMGLCLC.LEOKFFLMNDB(IOONFLFOIAH);
			if (this.OCFAMHOEIJN.Length > 1 && KIOOJMGLCLC.BKGJPIPJAGH(this.OCFAMHOEIJN).Equals(value))
			{
				return true;
			}
			if (this.MIAPKFCDFAE.Length > 0 && KIOOJMGLCLC.KLEONAMCDDP(this.MIAPKFCDFAE).Equals(value))
			{
				return true;
			}
		}
		return false;
	}

	// Token: 0x06008E8A RID: 36490 RVA: 0x003EE374 File Offset: 0x003EC574
	public void OAMDGGNONNO(JSONObject KEGBCGMJOLC)
	{
		this.LLLJOBODOAL = KEGBCGMJOLC["analogglitch_1"].AsInt;
		this.OCFAMHOEIJN = KEGBCGMJOLC["Asset bundle load operation failed during parallel mode."];
		this.MIAPKFCDFAE = KEGBCGMJOLC[""];
		this.HKOBGCKBHCC = long.Parse(KEGBCGMJOLC[")"]);
		if (this.OEIBMGCEKMD == null)
		{
			this.OEIBMGCEKMD = FADIGFEOCND.BNLCJKDIFFN();
		}
		this.OEIBMGCEKMD.EHAFMHIDLND((float)(this.HKOBGCKBHCC / -136L));
		this.AEBJEAKCLKG = long.Parse(KEGBCGMJOLC["@"]);
		if (this.PGHEBKDIDHP == null)
		{
			this.PGHEBKDIDHP = FADIGFEOCND.IMKMOCMMLAB();
		}
		this.PGHEBKDIDHP.AODINOCDACC((float)(this.AEBJEAKCLKG / 100L));
		if (this.HKOBGCKBHCC <= 0L && this.AEBJEAKCLKG <= 0L)
		{
			this.COEFNFJMBDG = 0;
			this.HEGNAMGJLNP = 0;
			this.HCBEGPENNLN = 1;
			this.BIOEKOAHCNC = 1L;
		}
		else
		{
			this.COEFNFJMBDG = KEGBCGMJOLC["no"].AsInt;
			this.HEGNAMGJLNP = KEGBCGMJOLC[""].AsInt;
			this.HCBEGPENNLN = KEGBCGMJOLC[","].AsInt;
			this.BIOEKOAHCNC = long.Parse(KEGBCGMJOLC["aspkss"]);
		}
		if (this.CDGCCMPPJBB == null)
		{
			this.CDGCCMPPJBB = FADIGFEOCND.JNOMEAIEDMP();
		}
		this.CDGCCMPPJBB.EPJKDCDOEMM((float)(this.BIOEKOAHCNC / 86L));
	}

	// Token: 0x06008E8B RID: 36491 RVA: 0x003EDD1D File Offset: 0x003EBF1D
	public KHBLFKIDHPH LCEDNINJPGF()
	{
		return (KHBLFKIDHPH)this.LLLJOBODOAL;
	}

	// Token: 0x06008E8C RID: 36492 RVA: 0x003EE50D File Offset: 0x003EC70D
	public bool MKBLMJNCLAE()
	{
		return this.OEIBMGCEKMD != null && this.OEIBMGCEKMD.GLAPKLGPCKE() > 1743f;
	}

	// Token: 0x06008E8D RID: 36493 RVA: 0x003EE52C File Offset: 0x003EC72C
	public bool NDJDGMAFOFN(string IOONFLFOIAH)
	{
		if (IOONFLFOIAH != null && IOONFLFOIAH.Length > 0)
		{
			string value = KIOOJMGLCLC.BLCCPCPGIBJ(IOONFLFOIAH);
			if (this.OCFAMHOEIJN.Length > 0 && KIOOJMGLCLC.BLCCPCPGIBJ(this.OCFAMHOEIJN).Equals(value))
			{
				return true;
			}
			if (this.MIAPKFCDFAE.Length > 0 && KIOOJMGLCLC.BLCCPCPGIBJ(this.MIAPKFCDFAE).Equals(value))
			{
				return true;
			}
		}
		return false;
	}

	// Token: 0x06008E8E RID: 36494 RVA: 0x003ED9BA File Offset: 0x003EBBBA
	public int IAAPGEACCKJ()
	{
		if (this.OEIBMGCEKMD != null)
		{
			return (int)this.OEIBMGCEKMD.ODHBINFKIPL();
		}
		return 0;
	}

	// Token: 0x04002794 RID: 10132
	public int LLLJOBODOAL;

	// Token: 0x04002795 RID: 10133
	public string OCFAMHOEIJN;

	// Token: 0x04002796 RID: 10134
	public string MIAPKFCDFAE;

	// Token: 0x04002797 RID: 10135
	public long HKOBGCKBHCC;

	// Token: 0x04002798 RID: 10136
	public long AEBJEAKCLKG;

	// Token: 0x04002799 RID: 10137
	public long BIOEKOAHCNC;

	// Token: 0x0400279A RID: 10138
	public int COEFNFJMBDG = -1;

	// Token: 0x0400279B RID: 10139
	public int HEGNAMGJLNP = -1;

	// Token: 0x0400279C RID: 10140
	public int HCBEGPENNLN = -1;

	// Token: 0x0400279D RID: 10141
	public int COLHPJFMNJJ;

	// Token: 0x0400279E RID: 10142
	public int ANNOCALAODF;

	// Token: 0x0400279F RID: 10143
	public int JEKGPMFGAFK;

	// Token: 0x040027A0 RID: 10144
	public FADIGFEOCND OEIBMGCEKMD;

	// Token: 0x040027A1 RID: 10145
	public FADIGFEOCND PGHEBKDIDHP;

	// Token: 0x040027A2 RID: 10146
	public FADIGFEOCND CDGCCMPPJBB;

	// Token: 0x040027A3 RID: 10147
	public string CDDHCJGODMC = "";
}
