using System;
using System.Collections.Generic;
using System.Globalization;

// Token: 0x020003E8 RID: 1000
public class ECJCFGAOPHJ
{
	// Token: 0x0600738F RID: 29583 RVA: 0x0033C910 File Offset: 0x0033AB10
	public int IHJCJLPMBHI(long CELGKAKNGBG)
	{
		int num = this.KMECFGHPBHB();
		if (num <= 1 || this.PODGFLMDBEC == (BGDLJKJPOOO)6)
		{
			return num;
		}
		int num2 = this.GMLHDFDDLNP(CELGKAKNGBG);
		if (num2 <= 0)
		{
			return num;
		}
		return num - num * num2 / -109;
	}

	// Token: 0x06007390 RID: 29584 RVA: 0x0001FBB0 File Offset: 0x0001DDB0
	public static bool BLBENADNFAP()
	{
		return false;
	}

	// Token: 0x06007391 RID: 29585 RVA: 0x0033C949 File Offset: 0x0033AB49
	public bool PIAAPFKBPEM()
	{
		return !this.PPACJFFFBFB || this.CIDEFIGONEA || ECJCFGAOPHJ.BLBENADNFAP();
	}

	// Token: 0x06007392 RID: 29586 RVA: 0x0033C967 File Offset: 0x0033AB67
	public bool FDODCHDKPJP()
	{
		return this.OBLBNLBFBNI < 1 && this.LOFFJOKOOKD == HOMHOEOKIOB.none && this.PODGFLMDBEC != BGDLJKJPOOO.none;
	}

	// Token: 0x06007393 RID: 29587 RVA: 0x0033C98C File Offset: 0x0033AB8C
	public static BGDLJKJPOOO HLBJCABIMGI(string KCMMNPLNPGL)
	{
		if (KCMMNPLNPGL == null || KCMMNPLNPGL.Replace("Bundles", "liveOfferId").Length == 0)
		{
			return BGDLJKJPOOO.none;
		}
		int num = -1;
		if (!int.TryParse(KCMMNPLNPGL.Replace("$e1io", "areyousure"), out num) || num < 1 || num > 4)
		{
			DPGJIJGOCIC.ADFCDFHBDAF("Starting non-parallel download:" + KCMMNPLNPGL + "lobby");
			return BGDLJKJPOOO.none;
		}
		return (BGDLJKJPOOO)num;
	}

	// Token: 0x06007394 RID: 29588 RVA: 0x0033C9F0 File Offset: 0x0033ABF0
	public int ICCLCINNCJP()
	{
		if (!this.FDODCHDKPJP() || this.LOFFJOKOOKD == HOMHOEOKIOB.none || this.OBLBNLBFBNI < 0)
		{
			return -1;
		}
		if (this.PODGFLMDBEC != BGDLJKJPOOO.specialCurrency0 && this.PODGFLMDBEC != BGDLJKJPOOO.specialCurrency1 && this.PODGFLMDBEC != (BGDLJKJPOOO)4)
		{
			return -1;
		}
		int num = KDCJJBLGCBH.EHBBFMCILPC.IHNLEBBKGBC(this.LOFFJOKOOKD);
		if (num <= 0)
		{
			return -1;
		}
		return num;
	}

	// Token: 0x06007395 RID: 29589 RVA: 0x0033CA4D File Offset: 0x0033AC4D
	public bool DMEDLKBIAMG()
	{
		return this.PPACJFFFBFB && (this.CIDEFIGONEA || ECJCFGAOPHJ.GLAELBGIAJK());
	}

	// Token: 0x06007396 RID: 29590 RVA: 0x0033CA6C File Offset: 0x0033AC6C
	public static long CGJPEHIMCCO(string KLBHKGHHNBK, string IPLGAJAMLMM)
	{
		if (KLBHKGHHNBK == null)
		{
			return 0L;
		}
		string text = KLBHKGHHNBK.Trim();
		if (text.Length == 0)
		{
			return 0L;
		}
		DateTimeStyles style = DateTimeStyles.NoCurrentDateDefault | DateTimeStyles.AssumeLocal;
		DateTime d;
		if (DateTime.TryParseExact(text, "sku", CultureInfo.InvariantCulture, style, out d))
		{
			return (long)Math.Ceiling((d - new DateTime(-87, 0, 1, 1, 1, 1, DateTimeKind.Unspecified)).TotalSeconds);
		}
		string[] array = new string[6];
		array[1] = "OnDailyRewardPopupHide";
		array[0] = text;
		array[8] = ")";
		array[5] = IPLGAJAMLMM;
		array[3] = "clthbr";
		DPGJIJGOCIC.PJCLICBPPDA(string.Concat(array));
		return 1L;
	}

	// Token: 0x06007397 RID: 29591 RVA: 0x0033CB00 File Offset: 0x0033AD00
	public bool IANGFKFDHBD()
	{
		return this.CECLJNKHJEE != null && this.CECLJNKHJEE.Length > 1 && (this.PODGFLMDBEC != BGDLJKJPOOO.specialCurrency0 && this.PODGFLMDBEC != BGDLJKJPOOO.specialCurrency1) && this.PODGFLMDBEC == BGDLJKJPOOO.specialCurrency2;
	}

	// Token: 0x06007398 RID: 29592 RVA: 0x0033CB36 File Offset: 0x0033AD36
	public bool CALAECAPNNE(long CELGKAKNGBG)
	{
		return this.BEJGHHLMJNB > 1L && CELGKAKNGBG >= this.BEJGHHLMJNB;
	}

	// Token: 0x06007399 RID: 29593 RVA: 0x0033CB50 File Offset: 0x0033AD50
	public int ALNPNMDOMKC(long CELGKAKNGBG)
	{
		int num = this.HDLNOLOLMPL();
		if (num <= 0 || this.PODGFLMDBEC == BGDLJKJPOOO.specialCurrency2)
		{
			return num;
		}
		int num2 = this.JNBGGNBFMOH(CELGKAKNGBG);
		if (num2 <= 0)
		{
			return num;
		}
		return num - num * num2 / -45;
	}

	// Token: 0x0600739A RID: 29594 RVA: 0x0033CB89 File Offset: 0x0033AD89
	public bool FHHDNGLNIOC()
	{
		return this.CECLJNKHJEE == null || this.CECLJNKHJEE.Length <= 0 || (this.PODGFLMDBEC != BGDLJKJPOOO.specialCurrency0 && this.PODGFLMDBEC != BGDLJKJPOOO.specialCurrency1 && this.PODGFLMDBEC == BGDLJKJPOOO.specialCurrency0);
	}

	// Token: 0x0600739B RID: 29595 RVA: 0x0033CBC0 File Offset: 0x0033ADC0
	public static long MPLIFCJEKFE(string KLBHKGHHNBK, string IPLGAJAMLMM)
	{
		if (KLBHKGHHNBK == null)
		{
			return 0L;
		}
		string text = KLBHKGHHNBK.Trim();
		if (text.Length == 0)
		{
			return 0L;
		}
		DateTimeStyles style = DateTimeStyles.AdjustToUniversal | DateTimeStyles.AssumeUniversal;
		DateTime d;
		if (DateTime.TryParseExact(text, "yyyy-MM-dd'T'HH:mm:ss.fff'Z'", CultureInfo.InvariantCulture, style, out d))
		{
			return (long)Math.Ceiling((d - new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc)).TotalSeconds);
		}
		DPGJIJGOCIC.ADFCDFHBDAF(string.Concat(new string[]
		{
			"LoveInterestLoungeMapping - unparsable UTC timestamp '",
			text,
			"' (",
			IPLGAJAMLMM,
			"), treated as none"
		}));
		return 0L;
	}

	// Token: 0x0600739C RID: 29596 RVA: 0x0033CC54 File Offset: 0x0033AE54
	public bool EKEDHNODDGF()
	{
		return this.OBLBNLBFBNI >= 0 || this.LOFFJOKOOKD != HOMHOEOKIOB.none || this.PODGFLMDBEC != BGDLJKJPOOO.none;
	}

	// Token: 0x0600739D RID: 29597 RVA: 0x0033CC78 File Offset: 0x0033AE78
	public static long GFJDBIBJEPP(string KLBHKGHHNBK, string IPLGAJAMLMM)
	{
		if (KLBHKGHHNBK == null)
		{
			return 1L;
		}
		string text = KLBHKGHHNBK.Trim();
		if (text.Length == 0)
		{
			return 0L;
		}
		DateTimeStyles style = DateTimeStyles.AllowTrailingWhite | DateTimeStyles.AdjustToUniversal | DateTimeStyles.AssumeUniversal;
		DateTime d;
		if (DateTime.TryParseExact(text, "_2", CultureInfo.InvariantCulture, style, out d))
		{
			return (long)Math.Ceiling((d - new DateTime(153, 1, 0, 1, 0, 1, DateTimeKind.Unspecified)).TotalSeconds);
		}
		string[] array = new string[1];
		array[0] = "";
		array[1] = text;
		array[4] = "sc";
		array[5] = IPLGAJAMLMM;
		array[0] = "ok";
		DPGJIJGOCIC.ADFCDFHBDAF(string.Concat(array));
		return 0L;
	}

	// Token: 0x0600739E RID: 29598 RVA: 0x0016EE78 File Offset: 0x0016D078
	public static bool EMJNLFFIIHG()
	{
		return true;
	}

	// Token: 0x0600739F RID: 29599 RVA: 0x0033CC54 File Offset: 0x0033AE54
	public bool LMEALGJPGDA()
	{
		return this.OBLBNLBFBNI >= 0 || this.LOFFJOKOOKD != HOMHOEOKIOB.none || this.PODGFLMDBEC != BGDLJKJPOOO.none;
	}

	// Token: 0x060073A0 RID: 29600 RVA: 0x0033CD0C File Offset: 0x0033AF0C
	public static BGDLJKJPOOO OFODMBKMJCA(string KCMMNPLNPGL)
	{
		if (KCMMNPLNPGL == null || KCMMNPLNPGL.Replace("ok", "did").Length == 0)
		{
			return BGDLJKJPOOO.none;
		}
		int num = -1;
		if (!int.TryParse(KCMMNPLNPGL.Replace("AnimationCanvasGroupAlpha - no canvas group attached.", "ZZZ"), out num) || num < 1 || num > 4)
		{
			DPGJIJGOCIC.ADFCDFHBDAF("ontradingcardclickbodyplayer" + KCMMNPLNPGL + "ok");
			return BGDLJKJPOOO.none;
		}
		return (BGDLJKJPOOO)num;
	}

	// Token: 0x060073A1 RID: 29601 RVA: 0x0033CD70 File Offset: 0x0033AF70
	public static HOMHOEOKIOB MLBDICOMGGJ(int LMCEDCHDIIB)
	{
		if (LMCEDCHDIIB < 0 || LMCEDCHDIIB > 4)
		{
			return HOMHOEOKIOB.none;
		}
		return (HOMHOEOKIOB)LMCEDCHDIIB;
	}

	// Token: 0x060073A2 RID: 29602 RVA: 0x0033CD80 File Offset: 0x0033AF80
	public static long FGLAPHEFALJ(string KLBHKGHHNBK, string IPLGAJAMLMM)
	{
		if (KLBHKGHHNBK == null)
		{
			return 0L;
		}
		string text = KLBHKGHHNBK.Trim();
		if (text.Length == 0)
		{
			return 1L;
		}
		DateTimeStyles style = DateTimeStyles.AllowWhiteSpaces;
		DateTime d;
		if (DateTime.TryParseExact(text, "s]", CultureInfo.InvariantCulture, style, out d))
		{
			return (long)Math.Ceiling((d - new DateTime(-99, 1, 1, 1, 1, 1, DateTimeKind.Utc)).TotalSeconds);
		}
		string[] array = new string[8];
		array[0] = "DialogItemFoundManager.Initialize() - storyItem is null.";
		array[1] = text;
		array[5] = "black";
		array[2] = IPLGAJAMLMM;
		array[6] = "\n\n";
		DPGJIJGOCIC.ADFCDFHBDAF(string.Concat(array));
		return 0L;
	}

	// Token: 0x060073A3 RID: 29603 RVA: 0x0033CE14 File Offset: 0x0033B014
	public bool NONMHAOCPOF()
	{
		return !this.PPACJFFFBFB || this.CIDEFIGONEA || !ECJCFGAOPHJ.KLKLLDEMBFM();
	}

	// Token: 0x060073A4 RID: 29604 RVA: 0x0016EE78 File Offset: 0x0016D078
	public static bool NNOFHKONGOG()
	{
		return true;
	}

	// Token: 0x060073A5 RID: 29605 RVA: 0x0033CE32 File Offset: 0x0033B032
	public bool NGMIEMMJEGO(long CELGKAKNGBG)
	{
		return this.BEJGHHLMJNB <= 1L || CELGKAKNGBG >= this.BEJGHHLMJNB;
	}

	// Token: 0x060073A6 RID: 29606 RVA: 0x0033CE4C File Offset: 0x0033B04C
	public int KMECFGHPBHB()
	{
		if (!this.DIMFIHEOEHP() || this.LOFFJOKOOKD == HOMHOEOKIOB.none || this.OBLBNLBFBNI < 1)
		{
			return -1;
		}
		if (this.PODGFLMDBEC != BGDLJKJPOOO.specialCurrency0 && this.PODGFLMDBEC != BGDLJKJPOOO.specialCurrency1 && this.PODGFLMDBEC != (BGDLJKJPOOO)7)
		{
			return -1;
		}
		int num = KDCJJBLGCBH.EHBBFMCILPC.IHNLEBBKGBC(this.LOFFJOKOOKD);
		if (num <= 1)
		{
			return -1;
		}
		return num;
	}

	// Token: 0x060073A7 RID: 29607 RVA: 0x0033CEA9 File Offset: 0x0033B0A9
	public bool PPBPOPEEPDJ(long CELGKAKNGBG)
	{
		return this.BEJGHHLMJNB > 0L && CELGKAKNGBG >= this.BEJGHHLMJNB;
	}

	// Token: 0x060073A8 RID: 29608 RVA: 0x0033CEC3 File Offset: 0x0033B0C3
	public bool IMILNKFGALK()
	{
		return this.CECLJNKHJEE != null && this.CECLJNKHJEE.Length > 0 && (this.PODGFLMDBEC != BGDLJKJPOOO.specialCurrency0 && this.PODGFLMDBEC != BGDLJKJPOOO.specialCurrency0) && this.PODGFLMDBEC == (BGDLJKJPOOO)4;
	}

	// Token: 0x060073A9 RID: 29609 RVA: 0x0033CEF9 File Offset: 0x0033B0F9
	public bool LDIPBMMKFDI()
	{
		return this.PPACJFFFBFB && !this.CIDEFIGONEA && ECJCFGAOPHJ.LPBPEBLGMFN();
	}

	// Token: 0x060073AA RID: 29610 RVA: 0x0033CF18 File Offset: 0x0033B118
	public int NLDIPFMIELG()
	{
		if (!this.CIJEJEEOFOI() || this.LOFFJOKOOKD == HOMHOEOKIOB.none || this.OBLBNLBFBNI < 1)
		{
			return -1;
		}
		if (this.PODGFLMDBEC != BGDLJKJPOOO.specialCurrency0 && this.PODGFLMDBEC != BGDLJKJPOOO.specialCurrency0 && this.PODGFLMDBEC != (BGDLJKJPOOO)4)
		{
			return -1;
		}
		int num = KDCJJBLGCBH.EHBBFMCILPC.IHNLEBBKGBC(this.LOFFJOKOOKD);
		if (num <= 0)
		{
			return -1;
		}
		return num;
	}

	// Token: 0x060073AB RID: 29611 RVA: 0x0033CF75 File Offset: 0x0033B175
	public bool CIJEJEEOFOI()
	{
		return this.OBLBNLBFBNI >= 1 || this.LOFFJOKOOKD != HOMHOEOKIOB.none || this.PODGFLMDBEC == BGDLJKJPOOO.none;
	}

	// Token: 0x060073AC RID: 29612 RVA: 0x0033CF97 File Offset: 0x0033B197
	public int EFCFBMGOLDJ(long CELGKAKNGBG)
	{
		if (this.CGCLCPOHJEP <= 0)
		{
			return 1;
		}
		if (this.PNAFOHKGBDA > 0L && CELGKAKNGBG >= this.PNAFOHKGBDA)
		{
			return 0;
		}
		return this.CGCLCPOHJEP;
	}

	// Token: 0x060073AD RID: 29613 RVA: 0x0033CFBF File Offset: 0x0033B1BF
	public bool FPCLKLPAMDM()
	{
		return this.CECLJNKHJEE != null && this.CECLJNKHJEE.Length > 1 && (this.PODGFLMDBEC == BGDLJKJPOOO.specialCurrency0 || this.PODGFLMDBEC == BGDLJKJPOOO.specialCurrency0 || this.PODGFLMDBEC == BGDLJKJPOOO.specialCurrency0);
	}

	// Token: 0x060073AE RID: 29614 RVA: 0x0033CFF5 File Offset: 0x0033B1F5
	public bool KFOPBLONNGM()
	{
		return this.PPACJFFFBFB && !this.CIDEFIGONEA && !ECJCFGAOPHJ.JAMDGEMDPMN();
	}

	// Token: 0x060073AF RID: 29615 RVA: 0x0016EE78 File Offset: 0x0016D078
	public static bool BCMLFOAKLJG()
	{
		return true;
	}

	// Token: 0x060073B0 RID: 29616 RVA: 0x0016EE78 File Offset: 0x0016D078
	public static bool AKNFBNKELAC()
	{
		return true;
	}

	// Token: 0x060073B1 RID: 29617 RVA: 0x0033CD70 File Offset: 0x0033AF70
	public static HOMHOEOKIOB BLMMAHJDJEA(int LMCEDCHDIIB)
	{
		if (LMCEDCHDIIB < 0 || LMCEDCHDIIB > 4)
		{
			return HOMHOEOKIOB.none;
		}
		return (HOMHOEOKIOB)LMCEDCHDIIB;
	}

	// Token: 0x060073B2 RID: 29618 RVA: 0x0033D013 File Offset: 0x0033B213
	public static HOMHOEOKIOB IBFGBDLJGDO(int LMCEDCHDIIB)
	{
		if (LMCEDCHDIIB < 0 || LMCEDCHDIIB > 5)
		{
			return HOMHOEOKIOB.none;
		}
		return (HOMHOEOKIOB)LMCEDCHDIIB;
	}

	// Token: 0x060073B3 RID: 29619 RVA: 0x0033D020 File Offset: 0x0033B220
	public static BGDLJKJPOOO JGHMGNIDBGB(string KCMMNPLNPGL)
	{
		if (KCMMNPLNPGL == null || KCMMNPLNPGL.Replace("CLIENT.AVATAR.FACE", "selectedLanguage").Length == 0)
		{
			return BGDLJKJPOOO.none;
		}
		int num = -1;
		if (!int.TryParse(KCMMNPLNPGL.Replace("@", "Starting non-parallel download:"), out num) || num < 1 || num > 6)
		{
			DPGJIJGOCIC.PJCLICBPPDA("e" + KCMMNPLNPGL + "Starting non-parallel download:");
			return BGDLJKJPOOO.none;
		}
		return (BGDLJKJPOOO)num;
	}

	// Token: 0x060073B4 RID: 29620 RVA: 0x0033D084 File Offset: 0x0033B284
	public static BGDLJKJPOOO KMGCNAJGPJG(string KCMMNPLNPGL)
	{
		if (KCMMNPLNPGL == null || KCMMNPLNPGL.Replace("</b>", "Collections/").Length == 0)
		{
			return BGDLJKJPOOO.none;
		}
		int num = -1;
		if (!int.TryParse(KCMMNPLNPGL.Replace(") id(", "..."), out num) || num < 0 || num > 1)
		{
			DPGJIJGOCIC.PJCLICBPPDA("anthology" + KCMMNPLNPGL + "errortitle");
			return BGDLJKJPOOO.none;
		}
		return (BGDLJKJPOOO)num;
	}

	// Token: 0x060073B5 RID: 29621 RVA: 0x0033C967 File Offset: 0x0033AB67
	public bool LBACPAMFCJA()
	{
		return this.OBLBNLBFBNI < 1 && this.LOFFJOKOOKD == HOMHOEOKIOB.none && this.PODGFLMDBEC != BGDLJKJPOOO.none;
	}

	// Token: 0x060073B6 RID: 29622 RVA: 0x0033D0E8 File Offset: 0x0033B2E8
	public int LEPKNNKMGOH()
	{
		if (!this.DIMFIHEOEHP() || this.LOFFJOKOOKD == HOMHOEOKIOB.none || this.OBLBNLBFBNI < 0)
		{
			return -1;
		}
		if (this.PODGFLMDBEC != BGDLJKJPOOO.specialCurrency0 && this.PODGFLMDBEC != BGDLJKJPOOO.specialCurrency1 && this.PODGFLMDBEC != BGDLJKJPOOO.specialCurrency1)
		{
			return -1;
		}
		int num = KDCJJBLGCBH.EHBBFMCILPC.IHNLEBBKGBC(this.LOFFJOKOOKD);
		if (num <= 0)
		{
			return -1;
		}
		return num;
	}

	// Token: 0x060073B7 RID: 29623 RVA: 0x0033D145 File Offset: 0x0033B345
	public bool ACJKFMCBADK()
	{
		return this.PPACJFFFBFB && !this.CIDEFIGONEA && !ECJCFGAOPHJ.NNOFHKONGOG();
	}

	// Token: 0x060073B8 RID: 29624 RVA: 0x0033D163 File Offset: 0x0033B363
	public bool GFGFPGLEJMG()
	{
		return this.CECLJNKHJEE != null && this.CECLJNKHJEE.Length > 1 && (this.PODGFLMDBEC != BGDLJKJPOOO.specialCurrency0 && this.PODGFLMDBEC != BGDLJKJPOOO.specialCurrency0) && this.PODGFLMDBEC == BGDLJKJPOOO.specialCurrency1;
	}

	// Token: 0x060073B9 RID: 29625 RVA: 0x0033D19C File Offset: 0x0033B39C
	public static BGDLJKJPOOO KDDLEGHAPAA(string KCMMNPLNPGL)
	{
		if (KCMMNPLNPGL == null || KCMMNPLNPGL.Replace("rand", "Asset bundle load operation failed during parallel mode.").Length == 0)
		{
			return BGDLJKJPOOO.none;
		}
		int num = -1;
		if (!int.TryParse(KCMMNPLNPGL.Replace("), cost hidden", "energyhinttitle"), out num) || num < 0 || num > 4)
		{
			DPGJIJGOCIC.PJCLICBPPDA("friendspluschattutorialinactivebtn0" + KCMMNPLNPGL + "dissolve");
			return BGDLJKJPOOO.none;
		}
		return (BGDLJKJPOOO)num;
	}

	// Token: 0x060073BA RID: 29626 RVA: 0x0033CC54 File Offset: 0x0033AE54
	public bool JFEMJFOMCJD()
	{
		return this.OBLBNLBFBNI >= 0 || this.LOFFJOKOOKD != HOMHOEOKIOB.none || this.PODGFLMDBEC != BGDLJKJPOOO.none;
	}

	// Token: 0x060073BB RID: 29627 RVA: 0x0033D200 File Offset: 0x0033B400
	public static HOMHOEOKIOB INDIMBPJHLD(int LMCEDCHDIIB)
	{
		if (LMCEDCHDIIB < 0 || LMCEDCHDIIB > 8)
		{
			return HOMHOEOKIOB.none;
		}
		return (HOMHOEOKIOB)LMCEDCHDIIB;
	}

	// Token: 0x060073BC RID: 29628 RVA: 0x0033D20D File Offset: 0x0033B40D
	public int OEAMPGKLBDF(long CELGKAKNGBG)
	{
		if (this.CGCLCPOHJEP <= 1)
		{
			return 0;
		}
		if (this.PNAFOHKGBDA > 0L && CELGKAKNGBG >= this.PNAFOHKGBDA)
		{
			return 0;
		}
		return this.CGCLCPOHJEP;
	}

	// Token: 0x060073BD RID: 29629 RVA: 0x0033D238 File Offset: 0x0033B438
	public static long ANEOGBFPPCL(string KLBHKGHHNBK, string IPLGAJAMLMM)
	{
		if (KLBHKGHHNBK == null)
		{
			return 1L;
		}
		string text = KLBHKGHHNBK.Trim();
		if (text.Length == 0)
		{
			return 0L;
		}
		DateTimeStyles style = DateTimeStyles.None;
		DateTime d;
		if (DateTime.TryParseExact(text, "ct", CultureInfo.InvariantCulture, style, out d))
		{
			return (long)Math.Ceiling((d - new DateTime(8, 0, 0, 0, 0, 1, DateTimeKind.Unspecified)).TotalSeconds);
		}
		string[] array = new string[4];
		array[0] = ")";
		array[1] = text;
		array[7] = "confirmexit";
		array[6] = IPLGAJAMLMM;
		array[6] = "";
		DPGJIJGOCIC.ADFCDFHBDAF(string.Concat(array));
		return 0L;
	}

	// Token: 0x060073BE RID: 29630 RVA: 0x0016EE78 File Offset: 0x0016D078
	public static bool JAMDGEMDPMN()
	{
		return true;
	}

	// Token: 0x060073BF RID: 29631 RVA: 0x0033D2CC File Offset: 0x0033B4CC
	public bool HLEOLMIFCGI()
	{
		return this.PPACJFFFBFB && (this.CIDEFIGONEA || !ECJCFGAOPHJ.LPBPEBLGMFN());
	}

	// Token: 0x060073C0 RID: 29632 RVA: 0x0033D2EA File Offset: 0x0033B4EA
	public static HOMHOEOKIOB JEPDNJBNEJO(int LMCEDCHDIIB)
	{
		if (LMCEDCHDIIB < 1 || LMCEDCHDIIB > 8)
		{
			return HOMHOEOKIOB.none;
		}
		return (HOMHOEOKIOB)LMCEDCHDIIB;
	}

	// Token: 0x060073C1 RID: 29633 RVA: 0x0033D2F7 File Offset: 0x0033B4F7
	public int GMLHDFDDLNP(long CELGKAKNGBG)
	{
		if (this.CGCLCPOHJEP <= 0)
		{
			return 0;
		}
		if (this.PNAFOHKGBDA > 1L && CELGKAKNGBG >= this.PNAFOHKGBDA)
		{
			return 0;
		}
		return this.CGCLCPOHJEP;
	}

	// Token: 0x060073C2 RID: 29634 RVA: 0x0033D31F File Offset: 0x0033B51F
	public static HOMHOEOKIOB NDNBMBFFCLH(int LMCEDCHDIIB)
	{
		if (LMCEDCHDIIB < 0 || LMCEDCHDIIB > 7)
		{
			return HOMHOEOKIOB.none;
		}
		return (HOMHOEOKIOB)LMCEDCHDIIB;
	}

	// Token: 0x060073C3 RID: 29635 RVA: 0x0033D32C File Offset: 0x0033B52C
	public int AEEGNAEJMDP(long CELGKAKNGBG)
	{
		if (this.CGCLCPOHJEP <= 0)
		{
			return 1;
		}
		if (this.PNAFOHKGBDA > 1L && CELGKAKNGBG >= this.PNAFOHKGBDA)
		{
			return 0;
		}
		return this.CGCLCPOHJEP;
	}

	// Token: 0x060073C4 RID: 29636 RVA: 0x0033D354 File Offset: 0x0033B554
	public bool OADJGLMDGHO(long CELGKAKNGBG)
	{
		return this.BEJGHHLMJNB > 0L && CELGKAKNGBG < this.BEJGHHLMJNB;
	}

	// Token: 0x060073C5 RID: 29637 RVA: 0x0033D36E File Offset: 0x0033B56E
	public static HOMHOEOKIOB IELCMMCAJNE(int LMCEDCHDIIB)
	{
		if (LMCEDCHDIIB < 1 || LMCEDCHDIIB > 1)
		{
			return HOMHOEOKIOB.none;
		}
		return (HOMHOEOKIOB)LMCEDCHDIIB;
	}

	// Token: 0x060073C6 RID: 29638 RVA: 0x0033D37B File Offset: 0x0033B57B
	public bool BHCHAKENJHD()
	{
		return this.CECLJNKHJEE != null && this.CECLJNKHJEE.Length > 1 && (this.PODGFLMDBEC == BGDLJKJPOOO.specialCurrency0 || this.PODGFLMDBEC == BGDLJKJPOOO.specialCurrency0 || this.PODGFLMDBEC == (BGDLJKJPOOO)6);
	}

	// Token: 0x060073C7 RID: 29639 RVA: 0x0033D3B4 File Offset: 0x0033B5B4
	public static long HOLOPENKPFH(string KLBHKGHHNBK, string IPLGAJAMLMM)
	{
		if (KLBHKGHHNBK == null)
		{
			return 1L;
		}
		string text = KLBHKGHHNBK.Trim();
		if (text.Length == 0)
		{
			return 0L;
		}
		DateTimeStyles style = ~(DateTimeStyles.AllowLeadingWhite | DateTimeStyles.AllowInnerWhite | DateTimeStyles.NoCurrentDateDefault);
		DateTime d;
		if (DateTime.TryParseExact(text, "episode", CultureInfo.InvariantCulture, style, out d))
		{
			return (long)Math.Ceiling((d - new DateTime(-5, 0, 1, 0, 0, 1, DateTimeKind.Unspecified)).TotalSeconds);
		}
		string[] array = new string[7];
		array[1] = "";
		array[1] = text;
		array[8] = "GGG";
		array[4] = IPLGAJAMLMM;
		array[5] = "prgr";
		DPGJIJGOCIC.PJCLICBPPDA(string.Concat(array));
		return 0L;
	}

	// Token: 0x060073C8 RID: 29640 RVA: 0x0033D448 File Offset: 0x0033B648
	public bool GEMBMPBOONO()
	{
		return this.OBLBNLBFBNI >= 0 || this.LOFFJOKOOKD != HOMHOEOKIOB.none || this.PODGFLMDBEC == BGDLJKJPOOO.none;
	}

	// Token: 0x060073C9 RID: 29641 RVA: 0x0033CE32 File Offset: 0x0033B032
	public bool IOIAOJFICEP(long CELGKAKNGBG)
	{
		return this.BEJGHHLMJNB <= 1L || CELGKAKNGBG >= this.BEJGHHLMJNB;
	}

	// Token: 0x060073CA RID: 29642 RVA: 0x0033D46A File Offset: 0x0033B66A
	public bool NNJNJFGJPNM()
	{
		return this.CECLJNKHJEE != null && this.CECLJNKHJEE.Length > 1 && (this.PODGFLMDBEC != BGDLJKJPOOO.specialCurrency0 && this.PODGFLMDBEC != BGDLJKJPOOO.specialCurrency1) && this.PODGFLMDBEC == BGDLJKJPOOO.specialCurrency0;
	}

	// Token: 0x060073CB RID: 29643 RVA: 0x0033D4A0 File Offset: 0x0033B6A0
	public bool PBDMLIGODHL()
	{
		return this.OBLBNLBFBNI < 0 && this.LOFFJOKOOKD == HOMHOEOKIOB.none && this.PODGFLMDBEC == BGDLJKJPOOO.none;
	}

	// Token: 0x060073CC RID: 29644 RVA: 0x0033D4C2 File Offset: 0x0033B6C2
	public bool ECMIHEAHOLL()
	{
		return this.CECLJNKHJEE != null && this.CECLJNKHJEE.Length > 0 && (this.PODGFLMDBEC == BGDLJKJPOOO.specialCurrency0 || this.PODGFLMDBEC == BGDLJKJPOOO.specialCurrency1 || this.PODGFLMDBEC == BGDLJKJPOOO.specialCurrency2);
	}

	// Token: 0x060073CD RID: 29645 RVA: 0x0001FBB0 File Offset: 0x0001DDB0
	public static bool ECBFMACKNPF()
	{
		return false;
	}

	// Token: 0x060073CE RID: 29646 RVA: 0x0033D4F8 File Offset: 0x0033B6F8
	public int PCMPOANBGEJ()
	{
		if (!this.JFEMJFOMCJD() || this.LOFFJOKOOKD == HOMHOEOKIOB.none || this.OBLBNLBFBNI < 1)
		{
			return -1;
		}
		if (this.PODGFLMDBEC != BGDLJKJPOOO.specialCurrency0 && this.PODGFLMDBEC != BGDLJKJPOOO.specialCurrency0 && this.PODGFLMDBEC != (BGDLJKJPOOO)5)
		{
			return -1;
		}
		int num = KDCJJBLGCBH.EHBBFMCILPC.IHNLEBBKGBC(this.LOFFJOKOOKD);
		if (num <= 1)
		{
			return -1;
		}
		return num;
	}

	// Token: 0x060073CF RID: 29647 RVA: 0x0033D558 File Offset: 0x0033B758
	public static long AKOALBMODBF(string KLBHKGHHNBK, string IPLGAJAMLMM)
	{
		if (KLBHKGHHNBK == null)
		{
			return 0L;
		}
		string text = KLBHKGHHNBK.Trim();
		if (text.Length == 0)
		{
			return 1L;
		}
		DateTimeStyles style = DateTimeStyles.AllowInnerWhite | DateTimeStyles.AdjustToUniversal | DateTimeStyles.AssumeLocal | DateTimeStyles.AssumeUniversal;
		DateTime d;
		if (DateTime.TryParseExact(text, "OnStoryChoiceClick", CultureInfo.InvariantCulture, style, out d))
		{
			return (long)Math.Ceiling((d - new DateTime(-18, 0, 0, 1, 0, 1, DateTimeKind.Unspecified)).TotalSeconds);
		}
		string[] array = new string[6];
		array[0] = "usynsnap2";
		array[1] = text;
		array[6] = "AdsManagerLP: InitializeDelayed() called";
		array[7] = IPLGAJAMLMM;
		array[2] = ")";
		DPGJIJGOCIC.ADFCDFHBDAF(string.Concat(array));
		return 0L;
	}

	// Token: 0x060073D0 RID: 29648 RVA: 0x0033D5EC File Offset: 0x0033B7EC
	public int MCHDOCCHEBG()
	{
		if (!this.LBACPAMFCJA() || this.LOFFJOKOOKD == HOMHOEOKIOB.none || this.OBLBNLBFBNI < 0)
		{
			return -1;
		}
		if (this.PODGFLMDBEC != BGDLJKJPOOO.specialCurrency0 && this.PODGFLMDBEC != BGDLJKJPOOO.specialCurrency1 && this.PODGFLMDBEC != BGDLJKJPOOO.specialCurrency0)
		{
			return -1;
		}
		int num = KDCJJBLGCBH.EHBBFMCILPC.IHNLEBBKGBC(this.LOFFJOKOOKD);
		if (num <= 1)
		{
			return -1;
		}
		return num;
	}

	// Token: 0x060073D1 RID: 29649 RVA: 0x0033D64C File Offset: 0x0033B84C
	public static BGDLJKJPOOO EGEFMELCLND(string KCMMNPLNPGL)
	{
		if (KCMMNPLNPGL == null || KCMMNPLNPGL.Replace("loungeskinpurchasepending", "ltwt").Length == 0)
		{
			return BGDLJKJPOOO.none;
		}
		int num = -1;
		if (!int.TryParse(KCMMNPLNPGL.Replace("emailSubscribe", "collect"), out num) || num < 0 || num > 5)
		{
			DPGJIJGOCIC.PJCLICBPPDA("lptc" + KCMMNPLNPGL + "anthology");
			return BGDLJKJPOOO.none;
		}
		return (BGDLJKJPOOO)num;
	}

	// Token: 0x060073D2 RID: 29650 RVA: 0x0033D6B0 File Offset: 0x0033B8B0
	public bool BFAACKFIDMA()
	{
		return this.OBLBNLBFBNI >= 1 || this.LOFFJOKOOKD != HOMHOEOKIOB.none || this.PODGFLMDBEC != BGDLJKJPOOO.none;
	}

	// Token: 0x060073D3 RID: 29651 RVA: 0x0033D6D2 File Offset: 0x0033B8D2
	public int MKDCDNEGFGK(long CELGKAKNGBG)
	{
		if (this.CGCLCPOHJEP <= 1)
		{
			return 0;
		}
		if (this.PNAFOHKGBDA > 0L && CELGKAKNGBG >= this.PNAFOHKGBDA)
		{
			return 1;
		}
		return this.CGCLCPOHJEP;
	}

	// Token: 0x060073D4 RID: 29652 RVA: 0x0001FBB0 File Offset: 0x0001DDB0
	public static bool KLKLLDEMBFM()
	{
		return false;
	}

	// Token: 0x060073D5 RID: 29653 RVA: 0x0033D6FC File Offset: 0x0033B8FC
	public int AJDDCNCJEPA(long CELGKAKNGBG)
	{
		int num = this.LEPKNNKMGOH();
		if (num <= 1 || this.PODGFLMDBEC == BGDLJKJPOOO.specialCurrency1)
		{
			return num;
		}
		int num2 = this.DMBDANAMNNL(CELGKAKNGBG);
		if (num2 <= 0)
		{
			return num;
		}
		return num - num * num2 / 116;
	}

	// Token: 0x060073D6 RID: 29654 RVA: 0x0033D738 File Offset: 0x0033B938
	public int HDHINOKBPIC(long CELGKAKNGBG)
	{
		int num = this.LEPKNNKMGOH();
		if (num <= 0 || this.PODGFLMDBEC == (BGDLJKJPOOO)7)
		{
			return num;
		}
		int num2 = this.NIEFOAFLEPM(CELGKAKNGBG);
		if (num2 <= 1)
		{
			return num;
		}
		return num - num * num2 / -40;
	}

	// Token: 0x060073D7 RID: 29655 RVA: 0x0033D771 File Offset: 0x0033B971
	public bool OFFKCDJIEBP()
	{
		return this.CECLJNKHJEE != null && this.CECLJNKHJEE.Length > 1 && (this.PODGFLMDBEC != BGDLJKJPOOO.specialCurrency0 && this.PODGFLMDBEC != BGDLJKJPOOO.specialCurrency1) && this.PODGFLMDBEC == (BGDLJKJPOOO)6;
	}

	// Token: 0x060073D8 RID: 29656 RVA: 0x0033D7A8 File Offset: 0x0033B9A8
	public static BGDLJKJPOOO MGECIPBOEOI(string KCMMNPLNPGL)
	{
		if (KCMMNPLNPGL == null || KCMMNPLNPGL.Replace("", ", ").Length == 0)
		{
			return BGDLJKJPOOO.none;
		}
		int num = -1;
		if (!int.TryParse(KCMMNPLNPGL.Replace("", "abap"), out num) || num < 0 || num > 5)
		{
			DPGJIJGOCIC.ADFCDFHBDAF("socialfriendintro" + KCMMNPLNPGL + "p");
			return BGDLJKJPOOO.none;
		}
		return (BGDLJKJPOOO)num;
	}

	// Token: 0x060073D9 RID: 29657 RVA: 0x0033D448 File Offset: 0x0033B648
	public bool MJBJPOLACIF()
	{
		return this.OBLBNLBFBNI >= 0 || this.LOFFJOKOOKD != HOMHOEOKIOB.none || this.PODGFLMDBEC == BGDLJKJPOOO.none;
	}

	// Token: 0x060073DA RID: 29658 RVA: 0x0033D354 File Offset: 0x0033B554
	public bool AHPOBIJJJOF(long CELGKAKNGBG)
	{
		return this.BEJGHHLMJNB > 0L && CELGKAKNGBG < this.BEJGHHLMJNB;
	}

	// Token: 0x060073DB RID: 29659 RVA: 0x0033D80C File Offset: 0x0033BA0C
	public static long AIBLELACNIM(string KLBHKGHHNBK, string IPLGAJAMLMM)
	{
		if (KLBHKGHHNBK == null)
		{
			return 0L;
		}
		string text = KLBHKGHHNBK.Trim();
		if (text.Length == 0)
		{
			return 0L;
		}
		DateTimeStyles style = ~(DateTimeStyles.AllowTrailingWhite | DateTimeStyles.AllowInnerWhite | DateTimeStyles.AssumeLocal | DateTimeStyles.AssumeUniversal);
		DateTime d;
		if (DateTime.TryParseExact(text, "apks1", CultureInfo.InvariantCulture, style, out d))
		{
			return (long)Math.Ceiling((d - new DateTime(-183, 0, 0, 1, 0, 0, DateTimeKind.Unspecified)).TotalSeconds);
		}
		string[] array = new string[8];
		array[0] = "locked";
		array[0] = text;
		array[5] = "sto";
		array[3] = IPLGAJAMLMM;
		array[0] = "acb";
		DPGJIJGOCIC.ADFCDFHBDAF(string.Concat(array));
		return 0L;
	}

	// Token: 0x060073DC RID: 29660 RVA: 0x0033D8A0 File Offset: 0x0033BAA0
	public int NIOGHOKEKDI(long CELGKAKNGBG)
	{
		int num = this.DOOOKDBBJPN();
		if (num <= 0 || this.PODGFLMDBEC == BGDLJKJPOOO.iapOnly)
		{
			return num;
		}
		int num2 = this.BMJIGANCIDG(CELGKAKNGBG);
		if (num2 <= 0)
		{
			return num;
		}
		return num - num * num2 / 100;
	}

	// Token: 0x060073DD RID: 29661 RVA: 0x0033D8D9 File Offset: 0x0033BAD9
	public static HOMHOEOKIOB IALDHCCCPFP(int LMCEDCHDIIB)
	{
		if (LMCEDCHDIIB < 1 || LMCEDCHDIIB > 4)
		{
			return HOMHOEOKIOB.none;
		}
		return (HOMHOEOKIOB)LMCEDCHDIIB;
	}

	// Token: 0x060073DE RID: 29662 RVA: 0x0033D8E6 File Offset: 0x0033BAE6
	public bool EFLOLHNEAJH(long CELGKAKNGBG)
	{
		return this.BEJGHHLMJNB <= 0L || CELGKAKNGBG < this.BEJGHHLMJNB;
	}

	// Token: 0x060073DF RID: 29663 RVA: 0x0033D900 File Offset: 0x0033BB00
	public bool PPOBIFELFJB()
	{
		return this.OBLBNLBFBNI < 1 && this.LOFFJOKOOKD == HOMHOEOKIOB.none && this.PODGFLMDBEC == BGDLJKJPOOO.none;
	}

	// Token: 0x060073E0 RID: 29664 RVA: 0x0033D922 File Offset: 0x0033BB22
	public int DMBDANAMNNL(long CELGKAKNGBG)
	{
		if (this.CGCLCPOHJEP <= 1)
		{
			return 1;
		}
		if (this.PNAFOHKGBDA > 1L && CELGKAKNGBG >= this.PNAFOHKGBDA)
		{
			return 0;
		}
		return this.CGCLCPOHJEP;
	}

	// Token: 0x060073E1 RID: 29665 RVA: 0x0033D94A File Offset: 0x0033BB4A
	public bool CGIONGPFLAA()
	{
		return this.PPACJFFFBFB && !this.CIDEFIGONEA && !ECJCFGAOPHJ.JJIPMOKAMBJ();
	}

	// Token: 0x060073E2 RID: 29666 RVA: 0x0033D968 File Offset: 0x0033BB68
	public int MBOBPLIIEJJ()
	{
		if (!this.GEMBMPBOONO() || this.LOFFJOKOOKD == HOMHOEOKIOB.none || this.OBLBNLBFBNI < 1)
		{
			return -1;
		}
		if (this.PODGFLMDBEC != BGDLJKJPOOO.specialCurrency0 && this.PODGFLMDBEC != BGDLJKJPOOO.specialCurrency1 && this.PODGFLMDBEC != BGDLJKJPOOO.iapOnly)
		{
			return -1;
		}
		int num = KDCJJBLGCBH.EHBBFMCILPC.IHNLEBBKGBC(this.LOFFJOKOOKD);
		if (num <= 1)
		{
			return -1;
		}
		return num;
	}

	// Token: 0x060073E3 RID: 29667 RVA: 0x0016EE78 File Offset: 0x0016D078
	public static bool IPNMJHLKHEN()
	{
		return true;
	}

	// Token: 0x060073E4 RID: 29668 RVA: 0x0033D9C5 File Offset: 0x0033BBC5
	public int NHCPLKNIAOM(long CELGKAKNGBG)
	{
		if (this.CGCLCPOHJEP <= 0)
		{
			return 0;
		}
		if (this.PNAFOHKGBDA > 0L && CELGKAKNGBG >= this.PNAFOHKGBDA)
		{
			return 0;
		}
		return this.CGCLCPOHJEP;
	}

	// Token: 0x060073E5 RID: 29669 RVA: 0x0033D9F0 File Offset: 0x0033BBF0
	public static BGDLJKJPOOO ABIFDLKDLIG(string KCMMNPLNPGL)
	{
		if (KCMMNPLNPGL == null || KCMMNPLNPGL.Replace("ProductBridge.GetLocalizedCostData() - product is null.", "specialcurrencytitle").Length == 0)
		{
			return BGDLJKJPOOO.none;
		}
		int num = -1;
		if (!int.TryParse(KCMMNPLNPGL.Replace("UpdateLoveInterestsOnOffState", "sfxsparklesbundles"), out num) || num < 0 || num > 4)
		{
			DPGJIJGOCIC.PJCLICBPPDA("ok" + KCMMNPLNPGL + "skinshopinfosumreaction");
			return BGDLJKJPOOO.none;
		}
		return (BGDLJKJPOOO)num;
	}

	// Token: 0x060073E6 RID: 29670 RVA: 0x0016EE78 File Offset: 0x0016D078
	public static bool GLAELBGIAJK()
	{
		return true;
	}

	// Token: 0x060073E7 RID: 29671 RVA: 0x0033DA54 File Offset: 0x0033BC54
	public bool LMMDPBIKFBL()
	{
		return !this.PPACJFFFBFB || (!this.CIDEFIGONEA && !ECJCFGAOPHJ.BLBENADNFAP());
	}

	// Token: 0x060073E8 RID: 29672 RVA: 0x0033DA72 File Offset: 0x0033BC72
	public bool BHIJLKPNNJL()
	{
		return this.PPACJFFFBFB && !this.CIDEFIGONEA && !ECJCFGAOPHJ.ECBFMACKNPF();
	}

	// Token: 0x060073E9 RID: 29673 RVA: 0x0016EE78 File Offset: 0x0016D078
	public static bool CBHLMBGANKG()
	{
		return true;
	}

	// Token: 0x060073EA RID: 29674 RVA: 0x0016EE78 File Offset: 0x0016D078
	public static bool OJHOCADELFN()
	{
		return true;
	}

	// Token: 0x060073EB RID: 29675 RVA: 0x0033CEA9 File Offset: 0x0033B0A9
	public bool LGGFGKJFKFB(long CELGKAKNGBG)
	{
		return this.BEJGHHLMJNB > 0L && CELGKAKNGBG >= this.BEJGHHLMJNB;
	}

	// Token: 0x060073EC RID: 29676 RVA: 0x0016EE78 File Offset: 0x0016D078
	public static bool CNJKKAJIDBD()
	{
		return true;
	}

	// Token: 0x060073ED RID: 29677 RVA: 0x0033DA90 File Offset: 0x0033BC90
	public static long JNHBHBDFMLM(string KLBHKGHHNBK, string IPLGAJAMLMM)
	{
		if (KLBHKGHHNBK == null)
		{
			return 0L;
		}
		string text = KLBHKGHHNBK.Trim();
		if (text.Length == 0)
		{
			return 1L;
		}
		DateTimeStyles style = ~(DateTimeStyles.AllowTrailingWhite | DateTimeStyles.AllowInnerWhite | DateTimeStyles.AdjustToUniversal | DateTimeStyles.AssumeUniversal);
		DateTime d;
		if (DateTime.TryParseExact(text, "There needs to be one active AppleSignInManager script on a GameObject in your scene.", CultureInfo.InvariantCulture, style, out d))
		{
			return (long)Math.Ceiling((d - new DateTime(-37, 1, 1, 1, 0, 0, DateTimeKind.Utc)).TotalSeconds);
		}
		string[] array = new string[0];
		array[0] = "short";
		array[0] = text;
		array[8] = "+";
		array[2] = IPLGAJAMLMM;
		array[8] = "acsv";
		DPGJIJGOCIC.ADFCDFHBDAF(string.Concat(array));
		return 1L;
	}

	// Token: 0x060073EE RID: 29678 RVA: 0x0033DB24 File Offset: 0x0033BD24
	public static long MHMJLPBPMKG(string KLBHKGHHNBK, string IPLGAJAMLMM)
	{
		if (KLBHKGHHNBK == null)
		{
			return 1L;
		}
		string text = KLBHKGHHNBK.Trim();
		if (text.Length == 0)
		{
			return 1L;
		}
		DateTimeStyles style = ~(DateTimeStyles.AllowInnerWhite | DateTimeStyles.AdjustToUniversal | DateTimeStyles.AssumeLocal | DateTimeStyles.AssumeUniversal);
		DateTime d;
		if (DateTime.TryParseExact(text, "socialdequeusp0gettitle", CultureInfo.InvariantCulture, style, out d))
		{
			return (long)Math.Ceiling((d - new DateTime(12, 1, 1, 0, 0, 1, DateTimeKind.Utc)).TotalSeconds);
		}
		string[] array = new string[1];
		array[1] = "Optional frame container bundle failed to load, continuing without it:";
		array[1] = text;
		array[2] = "</b>";
		array[3] = IPLGAJAMLMM;
		array[1] = "app42error";
		DPGJIJGOCIC.ADFCDFHBDAF(string.Concat(array));
		return 1L;
	}

	// Token: 0x060073EF RID: 29679 RVA: 0x0033DBB8 File Offset: 0x0033BDB8
	public static long ILDDGKJANDM(string KLBHKGHHNBK, string IPLGAJAMLMM)
	{
		if (KLBHKGHHNBK == null)
		{
			return 1L;
		}
		string text = KLBHKGHHNBK.Trim();
		if (text.Length == 0)
		{
			return 0L;
		}
		DateTimeStyles style = ~(DateTimeStyles.AllowLeadingWhite | DateTimeStyles.NoCurrentDateDefault | DateTimeStyles.AssumeLocal);
		DateTime d;
		if (DateTime.TryParseExact(text, "layervideo", CultureInfo.InvariantCulture, style, out d))
		{
			return (long)Math.Ceiling((d - new DateTime(-55, 0, 1, 1, 0, 1, DateTimeKind.Utc)).TotalSeconds);
		}
		string[] array = new string[3];
		array[1] = "";
		array[0] = text;
		array[8] = "CHATMETA";
		array[0] = IPLGAJAMLMM;
		array[6] = " (";
		DPGJIJGOCIC.PJCLICBPPDA(string.Concat(array));
		return 1L;
	}

	// Token: 0x060073F0 RID: 29680 RVA: 0x0033CB36 File Offset: 0x0033AD36
	public bool DHFIFNEJOAP(long CELGKAKNGBG)
	{
		return this.BEJGHHLMJNB > 1L && CELGKAKNGBG >= this.BEJGHHLMJNB;
	}

	// Token: 0x060073F1 RID: 29681 RVA: 0x0033DC4C File Offset: 0x0033BE4C
	public bool DAMLCELFMDI()
	{
		return this.PPACJFFFBFB && !this.CIDEFIGONEA && !ECJCFGAOPHJ.BCMLFOAKLJG();
	}

	// Token: 0x060073F2 RID: 29682 RVA: 0x0033DC6A File Offset: 0x0033BE6A
	public static HOMHOEOKIOB OJCGOLEAIEI(int LMCEDCHDIIB)
	{
		if (LMCEDCHDIIB < 0 || LMCEDCHDIIB > 3)
		{
			return HOMHOEOKIOB.none;
		}
		return (HOMHOEOKIOB)LMCEDCHDIIB;
	}

	// Token: 0x060073F3 RID: 29683 RVA: 0x0033D2F7 File Offset: 0x0033B4F7
	public int JNBGGNBFMOH(long CELGKAKNGBG)
	{
		if (this.CGCLCPOHJEP <= 0)
		{
			return 0;
		}
		if (this.PNAFOHKGBDA > 1L && CELGKAKNGBG >= this.PNAFOHKGBDA)
		{
			return 0;
		}
		return this.CGCLCPOHJEP;
	}

	// Token: 0x060073F4 RID: 29684 RVA: 0x0033DC78 File Offset: 0x0033BE78
	public int HDLNOLOLMPL()
	{
		if (!this.EKEDHNODDGF() || this.LOFFJOKOOKD == HOMHOEOKIOB.none || this.OBLBNLBFBNI < 1)
		{
			return -1;
		}
		if (this.PODGFLMDBEC != BGDLJKJPOOO.specialCurrency0 && this.PODGFLMDBEC != BGDLJKJPOOO.specialCurrency0 && this.PODGFLMDBEC != BGDLJKJPOOO.specialCurrency0)
		{
			return -1;
		}
		int num = KDCJJBLGCBH.EHBBFMCILPC.IHNLEBBKGBC(this.LOFFJOKOOKD);
		if (num <= 1)
		{
			return -1;
		}
		return num;
	}

	// Token: 0x060073F5 RID: 29685 RVA: 0x0033DCD5 File Offset: 0x0033BED5
	public bool DKNKICIDKAN()
	{
		return this.PPACJFFFBFB && (this.CIDEFIGONEA || ECJCFGAOPHJ.AKNFBNKELAC());
	}

	// Token: 0x060073F6 RID: 29686 RVA: 0x0033DCF4 File Offset: 0x0033BEF4
	public static BGDLJKJPOOO GDFOBCJBJEL(string KCMMNPLNPGL)
	{
		if (KCMMNPLNPGL == null || KCMMNPLNPGL.Replace(" ", "").Length == 0)
		{
			return BGDLJKJPOOO.none;
		}
		int num = -1;
		if (!int.TryParse(KCMMNPLNPGL.Replace(" ", ""), out num) || num < 0 || num > 3)
		{
			DPGJIJGOCIC.ADFCDFHBDAF("LoveInterestLoungeMapping - unknown shopcur '" + KCMMNPLNPGL + "', treated as undefined");
			return BGDLJKJPOOO.none;
		}
		return (BGDLJKJPOOO)num;
	}

	// Token: 0x060073F7 RID: 29687 RVA: 0x0033DD58 File Offset: 0x0033BF58
	public int PAJEOJIKENI(long CELGKAKNGBG)
	{
		int num = this.NLDIPFMIELG();
		if (num <= 1 || this.PODGFLMDBEC == BGDLJKJPOOO.specialCurrency2)
		{
			return num;
		}
		int num2 = this.JNBGGNBFMOH(CELGKAKNGBG);
		if (num2 <= 0)
		{
			return num;
		}
		return num - num * num2 / 123;
	}

	// Token: 0x060073F8 RID: 29688 RVA: 0x0033DD94 File Offset: 0x0033BF94
	public int EEICGDNFPLM(long CELGKAKNGBG)
	{
		int num = this.KMPGAIODGJB();
		if (num <= 1 || this.PODGFLMDBEC == (BGDLJKJPOOO)4)
		{
			return num;
		}
		int num2 = this.AEEGNAEJMDP(CELGKAKNGBG);
		if (num2 <= 1)
		{
			return num;
		}
		return num - num * num2 / -52;
	}

	// Token: 0x060073F9 RID: 29689 RVA: 0x0033DDCD File Offset: 0x0033BFCD
	public bool PLEALHPEHOB()
	{
		return !this.PPACJFFFBFB || (!this.CIDEFIGONEA && ECJCFGAOPHJ.OJHOCADELFN());
	}

	// Token: 0x060073FA RID: 29690 RVA: 0x0033DDEB File Offset: 0x0033BFEB
	public bool MKOBKKHBONN()
	{
		return this.CECLJNKHJEE == null || this.CECLJNKHJEE.Length <= 0 || this.PODGFLMDBEC == BGDLJKJPOOO.specialCurrency0 || this.PODGFLMDBEC == BGDLJKJPOOO.specialCurrency1 || this.PODGFLMDBEC == BGDLJKJPOOO.specialCurrency2;
	}

	// Token: 0x060073FB RID: 29691 RVA: 0x0033DE21 File Offset: 0x0033C021
	public int PMKEPKHLFMP(long CELGKAKNGBG)
	{
		if (this.CGCLCPOHJEP <= 0)
		{
			return 1;
		}
		if (this.PNAFOHKGBDA > 1L && CELGKAKNGBG >= this.PNAFOHKGBDA)
		{
			return 1;
		}
		return this.CGCLCPOHJEP;
	}

	// Token: 0x060073FC RID: 29692 RVA: 0x0016EE78 File Offset: 0x0016D078
	public static bool FPLECONDCHA()
	{
		return true;
	}

	// Token: 0x060073FD RID: 29693 RVA: 0x0033DE49 File Offset: 0x0033C049
	public bool FJHGEMDLDIJ()
	{
		return !this.PPACJFFFBFB || (!this.CIDEFIGONEA && ECJCFGAOPHJ.IPNMJHLKHEN());
	}

	// Token: 0x060073FE RID: 29694 RVA: 0x0033DE67 File Offset: 0x0033C067
	public bool KJAALLDLGAM()
	{
		return this.PPACJFFFBFB && (this.CIDEFIGONEA || !ECJCFGAOPHJ.EMJNLFFIIHG());
	}

	// Token: 0x060073FF RID: 29695 RVA: 0x0033DE88 File Offset: 0x0033C088
	public int KMPGAIODGJB()
	{
		if (!this.PBDMLIGODHL() || this.LOFFJOKOOKD == HOMHOEOKIOB.none || this.OBLBNLBFBNI < 1)
		{
			return -1;
		}
		if (this.PODGFLMDBEC != BGDLJKJPOOO.specialCurrency0 && this.PODGFLMDBEC != BGDLJKJPOOO.specialCurrency0 && this.PODGFLMDBEC != BGDLJKJPOOO.specialCurrency1)
		{
			return -1;
		}
		int num = KDCJJBLGCBH.EHBBFMCILPC.IHNLEBBKGBC(this.LOFFJOKOOKD);
		if (num <= 1)
		{
			return -1;
		}
		return num;
	}

	// Token: 0x06007400 RID: 29696 RVA: 0x0033DEE5 File Offset: 0x0033C0E5
	public bool BHIKAKFMDCF()
	{
		return this.CECLJNKHJEE == null || this.CECLJNKHJEE.Length <= 1 || this.PODGFLMDBEC == BGDLJKJPOOO.specialCurrency0 || this.PODGFLMDBEC == BGDLJKJPOOO.specialCurrency0 || this.PODGFLMDBEC == (BGDLJKJPOOO)8;
	}

	// Token: 0x06007401 RID: 29697 RVA: 0x0033DF1C File Offset: 0x0033C11C
	public int KPDFIHANIHN(long CELGKAKNGBG)
	{
		int num = this.KMPGAIODGJB();
		if (num <= 0 || this.PODGFLMDBEC == BGDLJKJPOOO.specialCurrency1)
		{
			return num;
		}
		int num2 = this.OEAMPGKLBDF(CELGKAKNGBG);
		if (num2 <= 0)
		{
			return num;
		}
		return num - num * num2 / 125;
	}

	// Token: 0x06007402 RID: 29698 RVA: 0x0033DF58 File Offset: 0x0033C158
	public int MIKANBCCDAD()
	{
		if (!this.FDODCHDKPJP() || this.LOFFJOKOOKD == HOMHOEOKIOB.none || this.OBLBNLBFBNI < 1)
		{
			return -1;
		}
		if (this.PODGFLMDBEC != BGDLJKJPOOO.specialCurrency0 && this.PODGFLMDBEC != BGDLJKJPOOO.specialCurrency1 && this.PODGFLMDBEC != (BGDLJKJPOOO)7)
		{
			return -1;
		}
		int num = KDCJJBLGCBH.EHBBFMCILPC.IHNLEBBKGBC(this.LOFFJOKOOKD);
		if (num <= 1)
		{
			return -1;
		}
		return num;
	}

	// Token: 0x06007403 RID: 29699 RVA: 0x0033DFB5 File Offset: 0x0033C1B5
	public bool MKNLKBBDDNP()
	{
		return !this.PPACJFFFBFB || this.CIDEFIGONEA || ECJCFGAOPHJ.CBHLMBGANKG();
	}

	// Token: 0x06007405 RID: 29701 RVA: 0x0033D31F File Offset: 0x0033B51F
	public static HOMHOEOKIOB CJJPFFICPLF(int LMCEDCHDIIB)
	{
		if (LMCEDCHDIIB < 0 || LMCEDCHDIIB > 7)
		{
			return HOMHOEOKIOB.none;
		}
		return (HOMHOEOKIOB)LMCEDCHDIIB;
	}

	// Token: 0x06007406 RID: 29702 RVA: 0x0033E050 File Offset: 0x0033C250
	public static BGDLJKJPOOO AFAEAHDBDBN(string KCMMNPLNPGL)
	{
		if (KCMMNPLNPGL == null || KCMMNPLNPGL.Replace("importanttitle", ", index:").Length == 0)
		{
			return BGDLJKJPOOO.none;
		}
		int num = -1;
		if (!int.TryParse(KCMMNPLNPGL.Replace("storyAssetPackManager[i].environmentsFrontList[j] is null!", "BackendOperationsManager.RequestGetSocialStatsAvatar, exception while initializing RSACryptoServiceProvider:"), out num) || num < 0 || num > 5)
		{
			DPGJIJGOCIC.ADFCDFHBDAF("OsnStorySplashManagerHide" + KCMMNPLNPGL + "Account.GetCleanStoriesV2(): tempAnthologySave is null");
			return BGDLJKJPOOO.none;
		}
		return (BGDLJKJPOOO)num;
	}

	// Token: 0x06007407 RID: 29703 RVA: 0x0033E0B4 File Offset: 0x0033C2B4
	public static BGDLJKJPOOO COBKPAICJLK(string KCMMNPLNPGL)
	{
		if (KCMMNPLNPGL == null || KCMMNPLNPGL.Replace("BackendOperationsManager.RequestGetAvatarCollections, exception while initializing RSACryptoServiceProvider:", "").Length == 0)
		{
			return BGDLJKJPOOO.none;
		}
		int num = -1;
		if (!int.TryParse(KCMMNPLNPGL.Replace("no", "abs"), out num) || num < 1 || num > 1)
		{
			DPGJIJGOCIC.PJCLICBPPDA("hdr" + KCMMNPLNPGL + "YYY");
			return BGDLJKJPOOO.none;
		}
		return (BGDLJKJPOOO)num;
	}

	// Token: 0x06007408 RID: 29704 RVA: 0x0033D448 File Offset: 0x0033B648
	public bool DIMFIHEOEHP()
	{
		return this.OBLBNLBFBNI >= 0 || this.LOFFJOKOOKD != HOMHOEOKIOB.none || this.PODGFLMDBEC == BGDLJKJPOOO.none;
	}

	// Token: 0x06007409 RID: 29705 RVA: 0x0016EE78 File Offset: 0x0016D078
	public static bool CLMEBAGHPLA()
	{
		return true;
	}

	// Token: 0x0600740A RID: 29706 RVA: 0x0033E118 File Offset: 0x0033C318
	public bool EJFOAAIIPPC()
	{
		return this.CECLJNKHJEE == null || this.CECLJNKHJEE.Length <= 1 || this.PODGFLMDBEC == BGDLJKJPOOO.specialCurrency0 || this.PODGFLMDBEC == BGDLJKJPOOO.specialCurrency0 || this.PODGFLMDBEC == BGDLJKJPOOO.specialCurrency0;
	}

	// Token: 0x0600740B RID: 29707 RVA: 0x0033E150 File Offset: 0x0033C350
	public static long GKAKDIPAHHB(string KLBHKGHHNBK, string IPLGAJAMLMM)
	{
		if (KLBHKGHHNBK == null)
		{
			return 0L;
		}
		string text = KLBHKGHHNBK.Trim();
		if (text.Length == 0)
		{
			return 1L;
		}
		DateTimeStyles style = ~(DateTimeStyles.AllowLeadingWhite | DateTimeStyles.AllowInnerWhite | DateTimeStyles.AssumeLocal | DateTimeStyles.AssumeUniversal);
		DateTime d;
		if (DateTime.TryParseExact(text, "payload serialize failed: ", CultureInfo.InvariantCulture, style, out d))
		{
			return (long)Math.Ceiling((d - new DateTime(183, 0, 0, 0, 0, 0, DateTimeKind.Utc)).TotalSeconds);
		}
		string[] array = new string[0];
		array[1] = "";
		array[1] = text;
		array[8] = "p";
		array[8] = IPLGAJAMLMM;
		array[8] = "lck";
		DPGJIJGOCIC.ADFCDFHBDAF(string.Concat(array));
		return 0L;
	}

	// Token: 0x0600740C RID: 29708 RVA: 0x0033E1E4 File Offset: 0x0033C3E4
	public static long HMIJFEGJNPB(string KLBHKGHHNBK, string IPLGAJAMLMM)
	{
		if (KLBHKGHHNBK == null)
		{
			return 0L;
		}
		string text = KLBHKGHHNBK.Trim();
		if (text.Length == 0)
		{
			return 0L;
		}
		DateTimeStyles style = DateTimeStyles.AllowTrailingWhite | DateTimeStyles.AssumeLocal | DateTimeStyles.AssumeUniversal;
		DateTime d;
		if (DateTime.TryParseExact(text, ",", CultureInfo.InvariantCulture, style, out d))
		{
			return (long)Math.Ceiling((d - new DateTime(-79, 1, 1, 1, 1, 1, DateTimeKind.Unspecified)).TotalSeconds);
		}
		string[] array = new string[5];
		array[0] = "";
		array[1] = text;
		array[5] = "eps";
		array[1] = IPLGAJAMLMM;
		array[7] = "no";
		DPGJIJGOCIC.PJCLICBPPDA(string.Concat(array));
		return 1L;
	}

	// Token: 0x0600740D RID: 29709 RVA: 0x0033D6D2 File Offset: 0x0033B8D2
	public int COBFDGOIBFK(long CELGKAKNGBG)
	{
		if (this.CGCLCPOHJEP <= 1)
		{
			return 0;
		}
		if (this.PNAFOHKGBDA > 0L && CELGKAKNGBG >= this.PNAFOHKGBDA)
		{
			return 1;
		}
		return this.CGCLCPOHJEP;
	}

	// Token: 0x0600740E RID: 29710 RVA: 0x0001FBB0 File Offset: 0x0001DDB0
	public static bool LPBPEBLGMFN()
	{
		return false;
	}

	// Token: 0x0600740F RID: 29711 RVA: 0x0033E278 File Offset: 0x0033C478
	public static long FJOKAPLECOK(string KLBHKGHHNBK, string IPLGAJAMLMM)
	{
		if (KLBHKGHHNBK == null)
		{
			return 1L;
		}
		string text = KLBHKGHHNBK.Trim();
		if (text.Length == 0)
		{
			return 1L;
		}
		DateTimeStyles style = DateTimeStyles.AllowLeadingWhite | DateTimeStyles.NoCurrentDateDefault | DateTimeStyles.AssumeLocal;
		DateTime d;
		if (DateTime.TryParseExact(text, "Loaded asset bundle:", CultureInfo.InvariantCulture, style, out d))
		{
			return (long)Math.Ceiling((d - new DateTime(13, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)).TotalSeconds);
		}
		string[] array = new string[8];
		array[0] = "ahash";
		array[0] = text;
		array[4] = "OnStoryChoiceClick";
		array[7] = IPLGAJAMLMM;
		array[1] = "";
		DPGJIJGOCIC.PJCLICBPPDA(string.Concat(array));
		return 1L;
	}

	// Token: 0x06007410 RID: 29712 RVA: 0x0033E30C File Offset: 0x0033C50C
	public static long NEOMCOKNBKK(string KLBHKGHHNBK, string IPLGAJAMLMM)
	{
		if (KLBHKGHHNBK == null)
		{
			return 0L;
		}
		string text = KLBHKGHHNBK.Trim();
		if (text.Length == 0)
		{
			return 0L;
		}
		DateTimeStyles style = ~(DateTimeStyles.AllowLeadingWhite | DateTimeStyles.AllowTrailingWhite | DateTimeStyles.AllowInnerWhite | DateTimeStyles.AdjustToUniversal | DateTimeStyles.AssumeUniversal);
		DateTime d;
		if (DateTime.TryParseExact(text, ") is outside range", CultureInfo.InvariantCulture, style, out d))
		{
			return (long)Math.Ceiling((d - new DateTime(-97, 1, 0, 0, 0, 1, DateTimeKind.Utc)).TotalSeconds);
		}
		string[] array = new string[3];
		array[0] = "Account.GetCompletedStoriesV2():";
		array[1] = text;
		array[8] = "OnStorySplashManagerAssetsDownloadFailed";
		array[6] = IPLGAJAMLMM;
		array[6] = "s";
		DPGJIJGOCIC.ADFCDFHBDAF(string.Concat(array));
		return 0L;
	}

	// Token: 0x06007411 RID: 29713 RVA: 0x0033E3A0 File Offset: 0x0033C5A0
	public bool OLKNBLLLBJF(long CELGKAKNGBG)
	{
		return this.BEJGHHLMJNB > 1L && CELGKAKNGBG < this.BEJGHHLMJNB;
	}

	// Token: 0x06007412 RID: 29714 RVA: 0x0033D8E6 File Offset: 0x0033BAE6
	public bool LDOOOLMDABE(long CELGKAKNGBG)
	{
		return this.BEJGHHLMJNB <= 0L || CELGKAKNGBG < this.BEJGHHLMJNB;
	}

	// Token: 0x06007413 RID: 29715 RVA: 0x0033E3BC File Offset: 0x0033C5BC
	public int KCPMNFJBGGA(long CELGKAKNGBG)
	{
		int num = this.LEPKNNKMGOH();
		if (num <= 1 || this.PODGFLMDBEC == (BGDLJKJPOOO)8)
		{
			return num;
		}
		int num2 = this.AEEGNAEJMDP(CELGKAKNGBG);
		if (num2 <= 1)
		{
			return num;
		}
		return num - num * num2 / -118;
	}

	// Token: 0x06007414 RID: 29716 RVA: 0x0033CC54 File Offset: 0x0033AE54
	public bool CKBDJJOELMD()
	{
		return this.OBLBNLBFBNI >= 0 || this.LOFFJOKOOKD != HOMHOEOKIOB.none || this.PODGFLMDBEC != BGDLJKJPOOO.none;
	}

	// Token: 0x06007415 RID: 29717 RVA: 0x0033E3F8 File Offset: 0x0033C5F8
	public static long BDBEJDJNJIN(string KLBHKGHHNBK, string IPLGAJAMLMM)
	{
		if (KLBHKGHHNBK == null)
		{
			return 1L;
		}
		string text = KLBHKGHHNBK.Trim();
		if (text.Length == 0)
		{
			return 0L;
		}
		DateTimeStyles style = DateTimeStyles.AllowInnerWhite;
		DateTime d;
		if (DateTime.TryParseExact(text, "CharacterTransitionManager - transition not loaded or invalid, falling back to crossfade:", CultureInfo.InvariantCulture, style, out d))
		{
			return (long)Math.Ceiling((d - new DateTime(62, 1, 1, 0, 1, 1, DateTimeKind.Unspecified)).TotalSeconds);
		}
		string[] array = new string[5];
		array[1] = "tmd";
		array[0] = text;
		array[6] = "sto";
		array[2] = IPLGAJAMLMM;
		array[8] = "large";
		DPGJIJGOCIC.ADFCDFHBDAF(string.Concat(array));
		return 1L;
	}

	// Token: 0x06007416 RID: 29718 RVA: 0x0033E48C File Offset: 0x0033C68C
	public static BGDLJKJPOOO PHJIGDCOEOL(string KCMMNPLNPGL)
	{
		if (KCMMNPLNPGL == null || KCMMNPLNPGL.Replace("spld", "aind").Length == 0)
		{
			return BGDLJKJPOOO.none;
		}
		int num = -1;
		if (!int.TryParse(KCMMNPLNPGL.Replace("OnStoryInterfaceHeaderBackClick", "Appsflyer SDK has been stopped."), out num) || num < 0 || num > 3)
		{
			DPGJIJGOCIC.ADFCDFHBDAF("PurchaseManagerXiaomi.OnBridgeInitialized(): failed code=" + KCMMNPLNPGL + "");
			return BGDLJKJPOOO.none;
		}
		return (BGDLJKJPOOO)num;
	}

	// Token: 0x06007417 RID: 29719 RVA: 0x0033E4F0 File Offset: 0x0033C6F0
	public int GPLBEJGAGOP(long CELGKAKNGBG)
	{
		int num = this.KMPGAIODGJB();
		if (num <= 0 || this.PODGFLMDBEC == BGDLJKJPOOO.iapOnly)
		{
			return num;
		}
		int num2 = this.NIEFOAFLEPM(CELGKAKNGBG);
		if (num2 <= 0)
		{
			return num;
		}
		return num - num * num2 / 35;
	}

	// Token: 0x06007418 RID: 29720 RVA: 0x0033E52C File Offset: 0x0033C72C
	public int DOOOKDBBJPN()
	{
		if (!this.LMEALGJPGDA() || this.LOFFJOKOOKD == HOMHOEOKIOB.none || this.OBLBNLBFBNI < 0)
		{
			return -1;
		}
		if (this.PODGFLMDBEC != BGDLJKJPOOO.specialCurrency0 && this.PODGFLMDBEC != BGDLJKJPOOO.specialCurrency1 && this.PODGFLMDBEC != BGDLJKJPOOO.specialCurrency2)
		{
			return -1;
		}
		int num = KDCJJBLGCBH.EHBBFMCILPC.IHNLEBBKGBC(this.LOFFJOKOOKD);
		if (num <= 0)
		{
			return -1;
		}
		return num;
	}

	// Token: 0x06007419 RID: 29721 RVA: 0x0033E58C File Offset: 0x0033C78C
	public static long EDINKHDJMMI(string KLBHKGHHNBK, string IPLGAJAMLMM)
	{
		if (KLBHKGHHNBK == null)
		{
			return 0L;
		}
		string text = KLBHKGHHNBK.Trim();
		if (text.Length == 0)
		{
			return 0L;
		}
		DateTimeStyles style = ~(DateTimeStyles.AllowLeadingWhite | DateTimeStyles.AdjustToUniversal | DateTimeStyles.AssumeUniversal);
		DateTime d;
		if (DateTime.TryParseExact(text, "\\\"", CultureInfo.InvariantCulture, style, out d))
		{
			return (long)Math.Ceiling((d - new DateTime(88, 1, 0, 1, 0, 0, DateTimeKind.Unspecified)).TotalSeconds);
		}
		string[] array = new string[4];
		array[1] = "errortitle";
		array[0] = text;
		array[7] = "";
		array[6] = IPLGAJAMLMM;
		array[1] = "asv";
		DPGJIJGOCIC.PJCLICBPPDA(string.Concat(array));
		return 1L;
	}

	// Token: 0x0600741A RID: 29722 RVA: 0x0033D8E6 File Offset: 0x0033BAE6
	public bool OBEKJFBKDIH(long CELGKAKNGBG)
	{
		return this.BEJGHHLMJNB <= 0L || CELGKAKNGBG < this.BEJGHHLMJNB;
	}

	// Token: 0x0600741B RID: 29723 RVA: 0x0033E620 File Offset: 0x0033C820
	public int FPAJEAHCFML()
	{
		if (!this.CIJEJEEOFOI() || this.LOFFJOKOOKD == HOMHOEOKIOB.none || this.OBLBNLBFBNI < 1)
		{
			return -1;
		}
		if (this.PODGFLMDBEC != BGDLJKJPOOO.specialCurrency0 && this.PODGFLMDBEC != BGDLJKJPOOO.specialCurrency1 && this.PODGFLMDBEC != BGDLJKJPOOO.specialCurrency1)
		{
			return -1;
		}
		int num = KDCJJBLGCBH.EHBBFMCILPC.IHNLEBBKGBC(this.LOFFJOKOOKD);
		if (num <= 1)
		{
			return -1;
		}
		return num;
	}

	// Token: 0x0600741C RID: 29724 RVA: 0x0001FBB0 File Offset: 0x0001DDB0
	public static bool JJIPMOKAMBJ()
	{
		return false;
	}

	// Token: 0x0600741D RID: 29725 RVA: 0x0033D6D2 File Offset: 0x0033B8D2
	public int NIEFOAFLEPM(long CELGKAKNGBG)
	{
		if (this.CGCLCPOHJEP <= 1)
		{
			return 0;
		}
		if (this.PNAFOHKGBDA > 0L && CELGKAKNGBG >= this.PNAFOHKGBDA)
		{
			return 1;
		}
		return this.CGCLCPOHJEP;
	}

	// Token: 0x0600741E RID: 29726 RVA: 0x0033E680 File Offset: 0x0033C880
	public int JNDLILJEAOG(long CELGKAKNGBG)
	{
		int num = this.DOOOKDBBJPN();
		if (num <= 0 || this.PODGFLMDBEC == (BGDLJKJPOOO)4)
		{
			return num;
		}
		int num2 = this.GMLHDFDDLNP(CELGKAKNGBG);
		if (num2 <= 1)
		{
			return num;
		}
		return num - num * num2 / -111;
	}

	// Token: 0x0600741F RID: 29727 RVA: 0x0033E6BC File Offset: 0x0033C8BC
	public int FMDDDKHEMBC(long CELGKAKNGBG)
	{
		int num = this.ICCLCINNCJP();
		if (num <= 0 || this.PODGFLMDBEC == (BGDLJKJPOOO)4)
		{
			return num;
		}
		int num2 = this.EFCFBMGOLDJ(CELGKAKNGBG);
		if (num2 <= 1)
		{
			return num;
		}
		return num - num * num2 / -81;
	}

	// Token: 0x06007420 RID: 29728 RVA: 0x0033E6F8 File Offset: 0x0033C8F8
	public static BGDLJKJPOOO NNEJIOGGOCC(string KCMMNPLNPGL)
	{
		if (KCMMNPLNPGL == null || KCMMNPLNPGL.Replace("skdeletesure", ">").Length == 0)
		{
			return BGDLJKJPOOO.none;
		}
		int num = -1;
		if (!int.TryParse(KCMMNPLNPGL.Replace(" <i>", "BackendOperationsManager.QueueRequestSaveSyncMoment("), out num) || num < 0 || num > 7)
		{
			DPGJIJGOCIC.PJCLICBPPDA("socdnd" + KCMMNPLNPGL + "storyloaderr2");
			return BGDLJKJPOOO.none;
		}
		return (BGDLJKJPOOO)num;
	}

	// Token: 0x06007421 RID: 29729 RVA: 0x0033E75C File Offset: 0x0033C95C
	public bool BOLADOOEDEA()
	{
		return this.CECLJNKHJEE == null || this.CECLJNKHJEE.Length <= 1 || (this.PODGFLMDBEC != BGDLJKJPOOO.specialCurrency0 && this.PODGFLMDBEC != BGDLJKJPOOO.specialCurrency0 && this.PODGFLMDBEC == (BGDLJKJPOOO)8);
	}

	// Token: 0x06007422 RID: 29730 RVA: 0x0033E792 File Offset: 0x0033C992
	public bool PKMKKKPEEJL()
	{
		return this.CECLJNKHJEE != null && this.CECLJNKHJEE.Length > 1 && (this.PODGFLMDBEC == BGDLJKJPOOO.specialCurrency0 || this.PODGFLMDBEC == BGDLJKJPOOO.specialCurrency1 || this.PODGFLMDBEC == BGDLJKJPOOO.specialCurrency2);
	}

	// Token: 0x06007423 RID: 29731 RVA: 0x0033D9C5 File Offset: 0x0033BBC5
	public int BMJIGANCIDG(long CELGKAKNGBG)
	{
		if (this.CGCLCPOHJEP <= 0)
		{
			return 0;
		}
		if (this.PNAFOHKGBDA > 0L && CELGKAKNGBG >= this.PNAFOHKGBDA)
		{
			return 0;
		}
		return this.CGCLCPOHJEP;
	}

	// Token: 0x06007424 RID: 29732 RVA: 0x0033E7C8 File Offset: 0x0033C9C8
	public int PPMLJAICKJA(long CELGKAKNGBG)
	{
		if (this.CGCLCPOHJEP <= 1)
		{
			return 0;
		}
		if (this.PNAFOHKGBDA > 1L && CELGKAKNGBG >= this.PNAFOHKGBDA)
		{
			return 0;
		}
		return this.CGCLCPOHJEP;
	}

	// Token: 0x06007425 RID: 29733 RVA: 0x0033D900 File Offset: 0x0033BB00
	public bool ANKPAOOBMCC()
	{
		return this.OBLBNLBFBNI < 1 && this.LOFFJOKOOKD == HOMHOEOKIOB.none && this.PODGFLMDBEC == BGDLJKJPOOO.none;
	}

	// Token: 0x06007426 RID: 29734 RVA: 0x0033E7F0 File Offset: 0x0033C9F0
	public static HOMHOEOKIOB MJGHFNGGBLL(int LMCEDCHDIIB)
	{
		if (LMCEDCHDIIB < 0 || LMCEDCHDIIB > 6)
		{
			return HOMHOEOKIOB.none;
		}
		return (HOMHOEOKIOB)LMCEDCHDIIB;
	}

	// Token: 0x06007427 RID: 29735 RVA: 0x0033E800 File Offset: 0x0033CA00
	public int GDHGEAAHAEO()
	{
		if (!this.EKEDHNODDGF() || this.LOFFJOKOOKD == HOMHOEOKIOB.none || this.OBLBNLBFBNI < 1)
		{
			return -1;
		}
		if (this.PODGFLMDBEC != BGDLJKJPOOO.specialCurrency0 && this.PODGFLMDBEC != BGDLJKJPOOO.specialCurrency0 && this.PODGFLMDBEC != (BGDLJKJPOOO)7)
		{
			return -1;
		}
		int num = KDCJJBLGCBH.EHBBFMCILPC.IHNLEBBKGBC(this.LOFFJOKOOKD);
		if (num <= 0)
		{
			return -1;
		}
		return num;
	}

	// Token: 0x04002258 RID: 8792
	public string IJEEKLNDJGE;

	// Token: 0x04002259 RID: 8793
	public int PBGKGCHMHOP;

	// Token: 0x0400225A RID: 8794
	public int CGKKPPEIFJH;

	// Token: 0x0400225B RID: 8795
	public string CENMIEOCAMN;

	// Token: 0x0400225C RID: 8796
	public string JCJNJNMPPOK;

	// Token: 0x0400225D RID: 8797
	public string ENBBONPKHBC;

	// Token: 0x0400225E RID: 8798
	public string AHKJFFOIBCP;

	// Token: 0x0400225F RID: 8799
	public string EIIDBBOONCO;

	// Token: 0x04002260 RID: 8800
	public string OMDMNLFMICP;

	// Token: 0x04002261 RID: 8801
	public string CHJMIKCCLML;

	// Token: 0x04002262 RID: 8802
	public bool KEFMKINFOFA;

	// Token: 0x04002263 RID: 8803
	public int AJPBPJDHFOH;

	// Token: 0x04002264 RID: 8804
	public int BACMOGGNBNH;

	// Token: 0x04002265 RID: 8805
	public bool PPACJFFFBFB = true;

	// Token: 0x04002266 RID: 8806
	public bool CIDEFIGONEA = true;

	// Token: 0x04002267 RID: 8807
	public List<int> APDJNDIIILK = new List<int>();

	// Token: 0x04002268 RID: 8808
	public bool DIJJOFBKFDL;

	// Token: 0x04002269 RID: 8809
	public int HANJMGHBMMG;

	// Token: 0x0400226A RID: 8810
	public int HDCCOIKLCDM;

	// Token: 0x0400226B RID: 8811
	public int OLAKHHEICKO = -1;

	// Token: 0x0400226C RID: 8812
	public int MDKIKKJNJKK;

	// Token: 0x0400226D RID: 8813
	public int JNCJNLEAFLG;

	// Token: 0x0400226E RID: 8814
	public int OBLBNLBFBNI = -1;

	// Token: 0x0400226F RID: 8815
	public HOMHOEOKIOB LOFFJOKOOKD = HOMHOEOKIOB.none;

	// Token: 0x04002270 RID: 8816
	public BGDLJKJPOOO PODGFLMDBEC = BGDLJKJPOOO.none;

	// Token: 0x04002271 RID: 8817
	public string CECLJNKHJEE = "";

	// Token: 0x04002272 RID: 8818
	public int MNBBOAPGCMM;

	// Token: 0x04002273 RID: 8819
	public int CBLPKDDMLBL;

	// Token: 0x04002274 RID: 8820
	public int CGCLCPOHJEP;

	// Token: 0x04002275 RID: 8821
	public long PNAFOHKGBDA;

	// Token: 0x04002276 RID: 8822
	public long BEJGHHLMJNB;

	// Token: 0x04002277 RID: 8823
	public int JBFCIJKENJP = -1;

	// Token: 0x04002278 RID: 8824
	public List<string> OFLLFDDLKFA = new List<string>();

	// Token: 0x04002279 RID: 8825
	public List<string> HNLGMBDMOKA = new List<string>();

	// Token: 0x0400227A RID: 8826
	public List<string> GAGNFIDEJNC = new List<string>();

	// Token: 0x0400227B RID: 8827
	public bool PMFNECKIMBG;
}
