using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using SimpleJSON;
using UnityEngine;

// Token: 0x0200046B RID: 1131
public static class MLIBDDCCKBM
{
	// Token: 0x06008991 RID: 35217 RVA: 0x003D5235 File Offset: 0x003D3435
	public static void IJHHMHAEKKE()
	{
		MLIBDDCCKBM.AFNODOLBBKG = null;
		MLIBDDCCKBM.CPPJAOIEJAJ = false;
		MLIBDDCCKBM.GIEMBNKACPK = false;
		MLIBDDCCKBM.AHJJAANBGPH.Clear();
		MLIBDDCCKBM.IDDHDBDPOIK();
		GADABGOBJIM.HHCIJJJDPGB();
	}

	// Token: 0x06008992 RID: 35218 RVA: 0x003D525D File Offset: 0x003D345D
	public static int CIOKHJOOCAC()
	{
		return MLIBDDCCKBM.CHCJFKALAGP;
	}

	// Token: 0x06008993 RID: 35219 RVA: 0x003D5264 File Offset: 0x003D3464
	public static int KBNBLLJIPIJ(int ONFOAHIAKJF)
	{
		if (ONFOAHIAKJF < 0 || ONFOAHIAKJF >= MLIBDDCCKBM.CBIBFJOCFKE.Count)
		{
			return -1;
		}
		return (int)MLIBDDCCKBM.CBIBFJOCFKE[ONFOAHIAKJF].GEMCPMEMNHJ;
	}

	// Token: 0x06008994 RID: 35220 RVA: 0x003D5289 File Offset: 0x003D3489
	public static int NKEGGHAMDME()
	{
		return MLIBDDCCKBM.LELKHIPBJKN;
	}

	// Token: 0x06008995 RID: 35221 RVA: 0x003D5290 File Offset: 0x003D3490
	public static bool FACIFBONANM()
	{
		return null != MLIBDDCCKBM.AFNODOLBBKG;
	}

	// Token: 0x06008996 RID: 35222 RVA: 0x003D529D File Offset: 0x003D349D
	public static int POAKHCIODEK()
	{
		return MLIBDDCCKBM.DLLJFCPCMFL;
	}

	// Token: 0x06008997 RID: 35223 RVA: 0x003D52A4 File Offset: 0x003D34A4
	private static void IDDHDBDPOIK()
	{
		MLIBDDCCKBM.LGMONCCMEDO = null;
		MLIBDDCCKBM.EBHIDIMEBEH.Clear();
		MLIBDDCCKBM.JJMMILPEELE = null;
		MLIBDDCCKBM.LKNIGBBMPMG = null;
		MLIBDDCCKBM.CBIBFJOCFKE.Clear();
		MLIBDDCCKBM.FFAGMKFGMGB.Clear();
		MLIBDDCCKBM.IJFDIMFLCOD.Clear();
		MLIBDDCCKBM.CHCJFKALAGP = 0;
		MLIBDDCCKBM.DLLJFCPCMFL = -1;
		MLIBDDCCKBM.LELKHIPBJKN = 0;
		MLIBDDCCKBM.OOMMEBAFGCK = 0;
		MLIBDDCCKBM.CJBALMBBFCC = 0;
		MLIBDDCCKBM.CFDHJKCALLF = 0;
		MLIBDDCCKBM.JBJKBNOJEGN = 0;
		for (int i = 0; i < MLIBDDCCKBM.JDLOAMKBPBJ.Length; i++)
		{
			MLIBDDCCKBM.JDLOAMKBPBJ[i] = 0;
		}
		MLIBDDCCKBM.FNPGNPHDECH.Clear();
		MLIBDDCCKBM.ANHLJBMIJJC = null;
		MLIBDDCCKBM.FJIBLACMFLP = null;
		MLIBDDCCKBM.AMECIHIEAJH = null;
		MLIBDDCCKBM.BANOOLGHMAB = null;
		MLIBDDCCKBM.DKBLKJFDNGL = null;
		MLIBDDCCKBM.PHEDIGCFIDD = 0;
	}

	// Token: 0x06008998 RID: 35224 RVA: 0x003D5360 File Offset: 0x003D3560
	private static void LGEOMHNPOCL(string[] JPHFBIKDICE)
	{
		if (JPHFBIKDICE == null)
		{
			return;
		}
		foreach (string text in JPHFBIKDICE)
		{
			if (text != null && text.Length != 0)
			{
				string[] array = text.Split(MLIBDDCCKBM.CJAOELFNOJA);
				for (int j = 0; j < array.Length; j++)
				{
					string text2 = array[j].Trim();
					if (0 < text2.Length)
					{
						MLIBDDCCKBM.AHJJAANBGPH.Add(text2);
					}
				}
			}
		}
	}

	// Token: 0x06008999 RID: 35225 RVA: 0x003D53CC File Offset: 0x003D35CC
	private static float IFPMJOPGMID(int MDLMLGIOEJF)
	{
		float kelfhifoibj = MKCHEIHILDB.KELFHIFOIBJ;
		float num = 1f;
		if (0 < MLIBDDCCKBM.CHCJFKALAGP && 0 < MDLMLGIOEJF)
		{
			double num2 = (double)MLIBDDCCKBM.CHCJFKALAGP + 1.0;
			double num3 = Math.Log(num2 / 1.5);
			if (0.0 < num3)
			{
				num = (float)(Math.Log(num2 / ((double)MDLMLGIOEJF + 0.5)) / num3);
			}
		}
		if (num < 0f)
		{
			num = 0f;
		}
		if (num > 1f)
		{
			num = 1f;
		}
		return kelfhifoibj + (1f - kelfhifoibj) * num;
	}

	// Token: 0x0600899A RID: 35226 RVA: 0x003D545D File Offset: 0x003D365D
	public static string PBPGBNOCHKM(int AHCHDJJOOHC)
	{
		if (AHCHDJJOOHC < 0 || AHCHDJJOOHC >= MLIBDDCCKBM.FFAGMKFGMGB.Count)
		{
			return "cat" + AHCHDJJOOHC.ToString();
		}
		return MLIBDDCCKBM.FFAGMKFGMGB[AHCHDJJOOHC].ODGNIFJGEHL;
	}

	// Token: 0x0600899B RID: 35227 RVA: 0x003D5494 File Offset: 0x003D3694
	private static void BMLICBGMCGB()
	{
		int num = MLIBDDCCKBM.DLLJFCPCMFL + 1;
		if (num < 1)
		{
			num = 1;
		}
		int[] array = new int[num];
		bool[] array2 = new bool[num];
		int num2 = 0;
		string[] array3 = new string[MLIBDDCCKBM.EBHIDIMEBEH.Count];
		MLIBDDCCKBM.JJMMILPEELE = new GDAOFOFBLPF[MLIBDDCCKBM.EBHIDIMEBEH.Count];
		for (int i = 0; i < MLIBDDCCKBM.EBHIDIMEBEH.Count; i++)
		{
			GDAOFOFBLPF gdaofofblpf = MLIBDDCCKBM.EBHIDIMEBEH[i];
			gdaofofblpf.OMKOGCBFAJK = gdaofofblpf.DFEHICLDMJD.ToArray();
			gdaofofblpf.DFEHICLDMJD = null;
			num2++;
			int num3 = 0;
			bool jckhebjfpec = true;
			for (int j = 0; j < gdaofofblpf.OMKOGCBFAJK.Length; j++)
			{
				int plmhnbphmkp = (int)gdaofofblpf.OMKOGCBFAJK[j].PLMHNBPHMKP;
				if (array[plmhnbphmkp] != num2)
				{
					array[plmhnbphmkp] = num2;
					num3++;
				}
				array2[plmhnbphmkp] = true;
				if (!gdaofofblpf.OMKOGCBFAJK[j].JCKHEBJFPEC)
				{
					jckhebjfpec = false;
				}
			}
			gdaofofblpf.NINBFOMIAEG = num3;
			gdaofofblpf.JCKHEBJFPEC = jckhebjfpec;
			array3[i] = gdaofofblpf.JKLAKEDMACO;
			MLIBDDCCKBM.JJMMILPEELE[i] = gdaofofblpf;
		}
		MLIBDDCCKBM.EBHIDIMEBEH.Clear();
		MLIBDDCCKBM.CHCJFKALAGP = 0;
		for (int k = 0; k < num; k++)
		{
			if (array2[k])
			{
				MLIBDDCCKBM.CHCJFKALAGP++;
			}
		}
		Array.Sort<string, GDAOFOFBLPF>(array3, MLIBDDCCKBM.JJMMILPEELE, StringComparer.Ordinal);
		MLIBDDCCKBM.PKLLFALOIOF();
		MLIBDDCCKBM.LKNIGBBMPMG = new List<GDAOFOFBLPF>[33];
		for (int l = 0; l < MLIBDDCCKBM.JJMMILPEELE.Length; l++)
		{
			int length = MLIBDDCCKBM.JJMMILPEELE[l].JKLAKEDMACO.Length;
			if (length <= 32)
			{
				if (MLIBDDCCKBM.LKNIGBBMPMG[length] == null)
				{
					MLIBDDCCKBM.LKNIGBBMPMG[length] = new List<GDAOFOFBLPF>(64);
				}
				MLIBDDCCKBM.LKNIGBBMPMG[length].Add(MLIBDDCCKBM.JJMMILPEELE[l]);
			}
		}
		MLIBDDCCKBM.OPACHKBHPMN(MKCHEIHILDB.KCEJOFCMKDO);
	}

	// Token: 0x0600899D RID: 35229 RVA: 0x003D5842 File Offset: 0x003D3A42
	public static void MAAPBEBFHLJ()
	{
		if (!MLIBDDCCKBM.FACIFBONANM())
		{
			return;
		}
		if (!MLIBDDCCKBM.KEDEPEDDNJP())
		{
			MLIBDDCCKBM.DCCLCEAJPFL();
		}
		if (MLIBDDCCKBM.CHCJFKALAGP == 0)
		{
			DPGJIJGOCIC.ANOPFDLPKGC("StoriesSearchBalance.EnsureBuilt() - index has no anthologies (TextAsset not wired, import empty or parse failed)");
		}
	}

	// Token: 0x0600899E RID: 35230 RVA: 0x003D5869 File Offset: 0x003D3A69
	public static string PEHDGMCMBFG(int MEFKFOHCOHK)
	{
		if (MEFKFOHCOHK < 0 || MEFKFOHCOHK >= MLIBDDCCKBM.FNPGNPHDECH.Count)
		{
			return null;
		}
		return MLIBDDCCKBM.FNPGNPHDECH[MEFKFOHCOHK];
	}

	// Token: 0x0600899F RID: 35231 RVA: 0x003D588C File Offset: 0x003D3A8C
	public static string GJJKGNLNNDG(int ONFOAHIAKJF, int EENGLNKNAPF)
	{
		if (ONFOAHIAKJF < 0 || ONFOAHIAKJF >= MLIBDDCCKBM.CBIBFJOCFKE.Count || !GADABGOBJIM.EEPGOBBIIHM(EENGLNKNAPF))
		{
			return null;
		}
		HEGNCPKIFKM hegncpkifkm = MLIBDDCCKBM.CBIBFJOCFKE[ONFOAHIAKJF];
		string[] array = null;
		AGAFMAAGGEK agafmaaggek = null;
		if (hegncpkifkm.IDGFNDBOMNI != null && MLIBDDCCKBM.IJFDIMFLCOD.TryGetValue(hegncpkifkm.IDGFNDBOMNI, out agafmaaggek) && agafmaaggek != null)
		{
			array = agafmaaggek.CBMNCLNCPLN;
		}
		if (array == null)
		{
			array = hegncpkifkm.CBMNCLNCPLN;
		}
		if (array == null || array.Length == 0)
		{
			return null;
		}
		string text = (EENGLNKNAPF < array.Length) ? array[EENGLNKNAPF] : null;
		if ((text == null || text.Trim().Length == 0) && (2 == hegncpkifkm.GEMCPMEMNHJ || 3 == hegncpkifkm.GEMCPMEMNHJ))
		{
			text = ((array.Length != 0) ? array[0] : null);
			int num = 0;
			while ((text == null || text.Trim().Length == 0) && num < array.Length)
			{
				text = array[num];
				num++;
			}
		}
		if (text == null)
		{
			return null;
		}
		int num2 = text.IndexOf('|');
		if (num2 >= 0)
		{
			text = text.Substring(0, num2);
		}
		text = text.Trim();
		if (text.Length != 0)
		{
			return text;
		}
		return null;
	}

	// Token: 0x060089A0 RID: 35232 RVA: 0x003D598E File Offset: 0x003D3B8E
	public static void BAMHPOCKBML(TextAsset CCIAGBPILGF, bool KGJKMCJJMJI)
	{
		MLIBDDCCKBM.BAMHPOCKBML(CCIAGBPILGF, KGJKMCJJMJI, false);
	}

	// Token: 0x060089A1 RID: 35233 RVA: 0x003D5998 File Offset: 0x003D3B98
	public static int MMJFDMDLJMJ(int AHCHDJJOOHC)
	{
		if (AHCHDJJOOHC < 0 || AHCHDJJOOHC >= MLIBDDCCKBM.FFAGMKFGMGB.Count)
		{
			return 0;
		}
		return MLIBDDCCKBM.FFAGMKFGMGB[AHCHDJJOOHC].BFOOIPKJGOM;
	}

	// Token: 0x060089A2 RID: 35234 RVA: 0x003D59BD File Offset: 0x003D3BBD
	public static bool BBIJHBHHGFB(int ONFOAHIAKJF)
	{
		return ONFOAHIAKJF >= 0 && ONFOAHIAKJF < MLIBDDCCKBM.CBIBFJOCFKE.Count && MLIBDDCCKBM.CBIBFJOCFKE[ONFOAHIAKJF].BCHICAKNNJP;
	}

	// Token: 0x060089A3 RID: 35235 RVA: 0x003D59E4 File Offset: 0x003D3BE4
	public static void MCOMGMOACEM(string GOJOGDKCNMO, CEIBHCNNIDC JDKEFOCIIOI, List<int> GFFOPEDMCAP, List<OJPLEKECIFI> IMDMGILBEIG)
	{
		if (IMDMGILBEIG == null)
		{
			return;
		}
		IMDMGILBEIG.Clear();
		try
		{
			MKCHEIHILDB.JANJEMFAEPK(GOJOGDKCNMO, JDKEFOCIIOI, GFFOPEDMCAP, IMDMGILBEIG, false);
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
			IMDMGILBEIG.Clear();
		}
	}

	// Token: 0x060089A4 RID: 35236 RVA: 0x003D5A24 File Offset: 0x003D3C24
	public static void BAMHPOCKBML(TextAsset CCIAGBPILGF, bool KGJKMCJJMJI, bool MJDMMLMCDAL)
	{
		MLIBDDCCKBM.IJHHMHAEKKE();
		MLIBDDCCKBM.CPPJAOIEJAJ = KGJKMCJJMJI;
		MLIBDDCCKBM.GIEMBNKACPK = MJDMMLMCDAL;
		if (null == CCIAGBPILGF)
		{
			DPGJIJGOCIC.ADFCDFHBDAF("StoriesSearchBalance.Initialize() - source is null, search disabled");
			return;
		}
		MLIBDDCCKBM.AFNODOLBBKG = CCIAGBPILGF;
		MLIBDDCCKBM.DCCLCEAJPFL();
	}

	// Token: 0x060089A5 RID: 35237 RVA: 0x003D5A56 File Offset: 0x003D3C56
	internal static bool GLOJJFCHMMN(int AHCHDJJOOHC, int EIABBAKCGNM)
	{
		if (AHCHDJJOOHC < 0 || AHCHDJJOOHC >= MLIBDDCCKBM.FFAGMKFGMGB.Count)
		{
			return false;
		}
		if (1 == EIABBAKCGNM)
		{
			return MLIBDDCCKBM.FFAGMKFGMGB[AHCHDJJOOHC].ODEGGINKMMO;
		}
		return 2 != EIABBAKCGNM || MLIBDDCCKBM.FFAGMKFGMGB[AHCHDJJOOHC].OLJCAAMENPF;
	}

	// Token: 0x060089A6 RID: 35238 RVA: 0x003D5A98 File Offset: 0x003D3C98
	private static void NCIBNOEKIDN()
	{
		for (int i = 0; i < 8; i++)
		{
			EICLEMCHODB eiclemchodb = new EICLEMCHODB();
			eiclemchodb.ODGNIFJGEHL = MLIBDDCCKBM.PBAFCGPNCJI[i];
			eiclemchodb.BFOOIPKJGOM = MLIBDDCCKBM.DAJPKHBCEMG[i];
			eiclemchodb.ODEGGINKMMO = MLIBDDCCKBM.CJLLPKNKPKG[i];
			eiclemchodb.OLJCAAMENPF = MLIBDDCCKBM.CKNMEGDEGHM[i];
			eiclemchodb.ONALOPHEOJM = MLIBDDCCKBM.OGJFMEDLDFJ[i];
			MLIBDDCCKBM.FFAGMKFGMGB.Add(eiclemchodb);
		}
	}

	// Token: 0x060089A7 RID: 35239 RVA: 0x003D5B04 File Offset: 0x003D3D04
	private static void DLMKNONFCHA(JSONNode EAOALLJIGFI)
	{
		JSONArray jsonarray = MLIBDDCCKBM.LPLNBOHFOGJ(EAOALLJIGFI, "storiesSearchDefaults");
		if (jsonarray == null)
		{
			return;
		}
		for (int i = 0; i < jsonarray.Count; i++)
		{
			JSONNode jsonnode = jsonarray[i];
			if (!(jsonnode == null))
			{
				string text = MLIBDDCCKBM.OEAPGFEIINJ(jsonnode, "cat").Trim();
				if (text.Length != 0)
				{
					int num = MLIBDDCCKBM.NBMCFPPJDLN(text);
					EICLEMCHODB eiclemchodb;
					if (num < 0)
					{
						eiclemchodb = new EICLEMCHODB();
						eiclemchodb.ODGNIFJGEHL = text;
						eiclemchodb.BFOOIPKJGOM = 20;
						eiclemchodb.ODEGGINKMMO = true;
						eiclemchodb.OLJCAAMENPF = true;
						eiclemchodb.ONALOPHEOJM = false;
						MLIBDDCCKBM.FFAGMKFGMGB.Add(eiclemchodb);
					}
					else
					{
						eiclemchodb = MLIBDDCCKBM.FFAGMKFGMGB[num];
					}
					int num2;
					if (MLIBDDCCKBM.DGFPMKBDJMK(jsonnode, "w", out num2))
					{
						eiclemchodb.BFOOIPKJGOM = num2;
					}
					if (MLIBDDCCKBM.DGFPMKBDJMK(jsonnode, "prefixEnabled", out num2))
					{
						eiclemchodb.ODEGGINKMMO = (num2 != 0);
					}
					if (MLIBDDCCKBM.DGFPMKBDJMK(jsonnode, "fuzzyEnabled", out num2))
					{
						eiclemchodb.OLJCAAMENPF = (num2 != 0);
					}
					if (MLIBDDCCKBM.DGFPMKBDJMK(jsonnode, "langNeutral", out num2))
					{
						eiclemchodb.ONALOPHEOJM = (num2 != 0);
					}
				}
			}
		}
	}

	// Token: 0x060089A8 RID: 35240 RVA: 0x003D5C30 File Offset: 0x003D3E30
	public static void DCJGMAOFJID(int PLKMJJIIJNO, List<int> PEDCLABFOLK)
	{
		PEDCLABFOLK.Clear();
		if (MLIBDDCCKBM.OKCPCEPJAEK == null || MLIBDDCCKBM.AOOKELMKMKL != MLIBDDCCKBM.CBIBFJOCFKE.Count)
		{
			MLIBDDCCKBM.OKCPCEPJAEK = new Dictionary<int, List<int>>();
			for (int i = 0; i < MLIBDDCCKBM.CBIBFJOCFKE.Count; i++)
			{
				List<int> list = null;
				if (!MLIBDDCCKBM.OKCPCEPJAEK.TryGetValue(MLIBDDCCKBM.CBIBFJOCFKE[i].PLMHNBPHMKP, out list))
				{
					list = new List<int>();
					MLIBDDCCKBM.OKCPCEPJAEK.Add(MLIBDDCCKBM.CBIBFJOCFKE[i].PLMHNBPHMKP, list);
				}
				list.Add(i);
			}
			MLIBDDCCKBM.AOOKELMKMKL = MLIBDDCCKBM.CBIBFJOCFKE.Count;
		}
		List<int> collection = null;
		if (MLIBDDCCKBM.OKCPCEPJAEK.TryGetValue(PLKMJJIIJNO, out collection))
		{
			PEDCLABFOLK.AddRange(collection);
		}
	}

	// Token: 0x060089A9 RID: 35241 RVA: 0x003D5CE9 File Offset: 0x003D3EE9
	public static long HDNLKIFLGKI()
	{
		return MLIBDDCCKBM.HDPODONPGAK;
	}

	// Token: 0x060089AA RID: 35242 RVA: 0x003D5CF0 File Offset: 0x003D3EF0
	private static int HPILHABGIKA(string HJEJJGAFHAM)
	{
		int num = MLIBDDCCKBM.NBMCFPPJDLN(HJEJJGAFHAM);
		if (0 <= num)
		{
			return num;
		}
		if (MLIBDDCCKBM.FFAGMKFGMGB.Count >= 255)
		{
			DPGJIJGOCIC.ANOPFDLPKGC("StoriesSearchBalance - too many categories, '" + HJEJJGAFHAM + "' folded into desc");
			return 7;
		}
		DPGJIJGOCIC.ADFCDFHBDAF("StoriesSearchBalance - unknown category '" + HJEJJGAFHAM + "', using default w " + 20.ToString());
		EICLEMCHODB eiclemchodb = new EICLEMCHODB();
		eiclemchodb.ODGNIFJGEHL = HJEJJGAFHAM;
		eiclemchodb.BFOOIPKJGOM = 20;
		eiclemchodb.ODEGGINKMMO = true;
		eiclemchodb.OLJCAAMENPF = true;
		eiclemchodb.ONALOPHEOJM = false;
		MLIBDDCCKBM.FFAGMKFGMGB.Add(eiclemchodb);
		return MLIBDDCCKBM.FFAGMKFGMGB.Count - 1;
	}

	// Token: 0x060089AB RID: 35243 RVA: 0x003D5D92 File Offset: 0x003D3F92
	public static int IKJDOPANMHF()
	{
		return MLIBDDCCKBM.JBJKBNOJEGN;
	}

	// Token: 0x060089AC RID: 35244 RVA: 0x003D5D9C File Offset: 0x003D3F9C
	public static string DIFPDJMGECC(int ONFOAHIAKJF)
	{
		if (ONFOAHIAKJF < 0 || ONFOAHIAKJF >= MLIBDDCCKBM.CBIBFJOCFKE.Count)
		{
			return "";
		}
		HEGNCPKIFKM hegncpkifkm = MLIBDDCCKBM.CBIBFJOCFKE[ONFOAHIAKJF];
		AGAFMAAGGEK agafmaaggek = null;
		if (hegncpkifkm.IDGFNDBOMNI == null || !MLIBDDCCKBM.IJFDIMFLCOD.TryGetValue(hegncpkifkm.IDGFNDBOMNI, out agafmaaggek) || agafmaaggek == null || agafmaaggek.IODLKFKJIHF == null)
		{
			return "";
		}
		return agafmaaggek.IODLKFKJIHF;
	}

	// Token: 0x060089AD RID: 35245 RVA: 0x003D5E01 File Offset: 0x003D4001
	public static int LOCNPCFEIOF(int EENGLNKNAPF)
	{
		if (!GADABGOBJIM.EEPGOBBIIHM(EENGLNKNAPF))
		{
			return 0;
		}
		return MLIBDDCCKBM.JDLOAMKBPBJ[EENGLNKNAPF];
	}

	// Token: 0x060089AE RID: 35246 RVA: 0x003D5E14 File Offset: 0x003D4014
	private static void AKDLDDCCJJE(HEGNCPKIFKM AIHBCIAHFPD, ushort ONFOAHIAKJF, string[] JPHFBIKDICE)
	{
		if (AIHBCIAHFPD.BFOOIPKJGOM == 0)
		{
			return;
		}
		bool onalopheojm = MLIBDDCCKBM.FFAGMKFGMGB[(int)AIHBCIAHFPD.GEMCPMEMNHJ].ONALOPHEOJM;
		bool pbbjjcilnik = MLIBDDCCKBM.BBNNAIKNMGN(AIHBCIAHFPD.IDGFNDBOMNI);
		if (6 == AIHBCIAHFPD.GEMCPMEMNHJ)
		{
			MLIBDDCCKBM.LGEOMHNPOCL(JPHFBIKDICE);
		}
		for (int i = 0; i < 9; i++)
		{
			string text = JPHFBIKDICE[i];
			if (text != null && text.Length != 0)
			{
				string[] array = text.Split(MLIBDDCCKBM.CJAOELFNOJA);
				for (int j = 0; j < array.Length; j++)
				{
					string text2 = array[j].Trim();
					if (text2.Length != 0)
					{
						if (2 == i)
						{
							text2 = GADABGOBJIM.KFBMINKIPKG(text2);
						}
						int oommebafgck = MLIBDDCCKBM.OOMMEBAFGCK;
						MLIBDDCCKBM.JLPCNFKCCJA(text2, AIHBCIAHFPD, ONFOAHIAKJF, i, onalopheojm, pbbjjcilnik);
						if (GADABGOBJIM.OFMOKLHBMIB(text2))
						{
							MLIBDDCCKBM.JLPCNFKCCJA(GADABGOBJIM.DPLEIOHNNBN(text2), AIHBCIAHFPD, ONFOAHIAKJF, i, onalopheojm, pbbjjcilnik);
						}
						if (0 < j && oommebafgck == MLIBDDCCKBM.OOMMEBAFGCK)
						{
							MLIBDDCCKBM.FNPGNPHDECH.Add(string.Concat(new string[]
							{
								AIHBCIAHFPD.DBHMNECMIAB,
								" ",
								GADABGOBJIM.JPMPIIIBIEN(i),
								" '",
								text2,
								"'"
							}));
						}
					}
				}
			}
		}
	}

	// Token: 0x060089AF RID: 35247 RVA: 0x003D5F50 File Offset: 0x003D4150
	private static string OEAPGFEIINJ(JSONNode AIHBCIAHFPD, string MJHGIIEINOE)
	{
		JSONNode jsonnode = AIHBCIAHFPD[MJHGIIEINOE];
		if (jsonnode == null)
		{
			return "";
		}
		string value = jsonnode.Value;
		if (value == null)
		{
			return "";
		}
		return value;
	}

	// Token: 0x060089B0 RID: 35248 RVA: 0x003D5F85 File Offset: 0x003D4185
	public static bool EHKPJPLEDED(string IOOCOEEGDPG)
	{
		return IOOCOEEGDPG != null && MLIBDDCCKBM.AHJJAANBGPH.Count != 0 && MLIBDDCCKBM.AHJJAANBGPH.Contains(IOOCOEEGDPG.Trim());
	}

	// Token: 0x060089B1 RID: 35249 RVA: 0x003D5FA8 File Offset: 0x003D41A8
	private static void LNPIDDDAEOG()
	{
		MLIBDDCCKBM.CBIBFJOCFKE.Clear();
		MLIBDDCCKBM.IJFDIMFLCOD.Clear();
		MLIBDDCCKBM.LGMONCCMEDO = new Dictionary<string, GDAOFOFBLPF>(StringComparer.Ordinal);
		MLIBDDCCKBM.AHJJAANBGPH.Clear();
		MLIBDDCCKBM.EBHIDIMEBEH.Clear();
		MLIBDDCCKBM.JJMMILPEELE = new GDAOFOFBLPF[0];
		MLIBDDCCKBM.LKNIGBBMPMG = new List<GDAOFOFBLPF>[33];
		MLIBDDCCKBM.CHCJFKALAGP = 0;
		MLIBDDCCKBM.DLLJFCPCMFL = -1;
		MLIBDDCCKBM.LELKHIPBJKN = 0;
		MLIBDDCCKBM.OPACHKBHPMN(MKCHEIHILDB.KCEJOFCMKDO);
	}

	// Token: 0x060089B2 RID: 35250 RVA: 0x003D601F File Offset: 0x003D421F
	public static int AFMEFBJCIAD()
	{
		if (MLIBDDCCKBM.JJMMILPEELE != null)
		{
			return MLIBDDCCKBM.JJMMILPEELE.Length;
		}
		return 0;
	}

	// Token: 0x060089B3 RID: 35251 RVA: 0x003D6031 File Offset: 0x003D4231
	public static int IIBLACMGGEN()
	{
		return MLIBDDCCKBM.FNPGNPHDECH.Count;
	}

	// Token: 0x060089B4 RID: 35252 RVA: 0x003D6040 File Offset: 0x003D4240
	private static void ALLKHHKEDFC(JSONNode EAOALLJIGFI)
	{
		JSONArray jsonarray = MLIBDDCCKBM.LPLNBOHFOGJ(EAOALLJIGFI, "storiesSearchConcepts");
		if (jsonarray == null)
		{
			return;
		}
		for (int i = 0; i < jsonarray.Count; i++)
		{
			JSONNode jsonnode = jsonarray[i];
			if (!(jsonnode == null))
			{
				string text = MLIBDDCCKBM.OEAPGFEIINJ(jsonnode, "concept").Trim();
				if (text.Length == 0)
				{
					MLIBDDCCKBM.JBJKBNOJEGN++;
				}
				else if (MLIBDDCCKBM.IJFDIMFLCOD.ContainsKey(text))
				{
					DPGJIJGOCIC.ADFCDFHBDAF("StoriesSearchBalance - duplicate concept '" + text + "', keeping the first");
					MLIBDDCCKBM.JBJKBNOJEGN++;
				}
				else
				{
					AGAFMAAGGEK agafmaaggek = new AGAFMAAGGEK();
					agafmaaggek.DBHMNECMIAB = text;
					agafmaaggek.GEMCPMEMNHJ = MLIBDDCCKBM.OEAPGFEIINJ(jsonnode, "cat").Trim();
					agafmaaggek.IODLKFKJIHF = MLIBDDCCKBM.OEAPGFEIINJ(jsonnode, "kind").Trim();
					agafmaaggek.HKJLHGDEKNO = (1 == jsonnode["nc"].AsInt);
					agafmaaggek.CBMNCLNCPLN = MLIBDDCCKBM.GIAGCPLKLNH(jsonnode);
					for (int j = 0; j < 9; j++)
					{
						if (agafmaaggek.CBMNCLNCPLN[j].Length == 0)
						{
							MLIBDDCCKBM.JDLOAMKBPBJ[j]++;
						}
					}
					if (string.Equals("author", agafmaaggek.IODLKFKJIHF, StringComparison.Ordinal))
					{
						MLIBDDCCKBM.LGEOMHNPOCL(agafmaaggek.CBMNCLNCPLN);
					}
					MLIBDDCCKBM.IJFDIMFLCOD.Add(text, agafmaaggek);
				}
			}
		}
	}

	// Token: 0x060089B5 RID: 35253 RVA: 0x003D61B0 File Offset: 0x003D43B0
	private static string FMFPGNPGMEL(string DMNJEPLAAKN)
	{
		AGAFMAAGGEK agafmaaggek = null;
		if (DMNJEPLAAKN == null || !MLIBDDCCKBM.IJFDIMFLCOD.TryGetValue(DMNJEPLAAKN, out agafmaaggek) || agafmaaggek == null || agafmaaggek.IODLKFKJIHF == null)
		{
			return "";
		}
		return agafmaaggek.IODLKFKJIHF;
	}

	// Token: 0x060089B6 RID: 35254 RVA: 0x003D61E8 File Offset: 0x003D43E8
	public static bool KEDEPEDDNJP()
	{
		return MLIBDDCCKBM.LGMONCCMEDO != null;
	}

	// Token: 0x060089B7 RID: 35255 RVA: 0x003D61F4 File Offset: 0x003D43F4
	private static JSONArray LPLNBOHFOGJ(JSONNode EAOALLJIGFI, string HJEJJGAFHAM)
	{
		if (EAOALLJIGFI == null)
		{
			DPGJIJGOCIC.ADFCDFHBDAF("StoriesSearchBalance - root key '" + HJEJJGAFHAM + "' is missing");
			return null;
		}
		JSONArray asArray = EAOALLJIGFI.AsArray;
		if (asArray == null)
		{
			DPGJIJGOCIC.ADFCDFHBDAF("StoriesSearchBalance - root key '" + HJEJJGAFHAM + "' is not an array");
			return null;
		}
		return asArray;
	}

	// Token: 0x060089B8 RID: 35256 RVA: 0x003D624C File Offset: 0x003D444C
	public static void HFIAFPGCDOE(List<int> BPNMNMJHOJH)
	{
		BPNMNMJHOJH.Clear();
		if (MLIBDDCCKBM.JJMMILPEELE == null || MLIBDDCCKBM.DLLJFCPCMFL < 0)
		{
			return;
		}
		bool[] array = new bool[MLIBDDCCKBM.DLLJFCPCMFL + 1];
		for (int i = 0; i < MLIBDDCCKBM.JJMMILPEELE.Length; i++)
		{
			DHJPAFCHGHL[] omkogcbfajk = MLIBDDCCKBM.JJMMILPEELE[i].OMKOGCBFAJK;
			for (int j = 0; j < omkogcbfajk.Length; j++)
			{
				array[(int)omkogcbfajk[j].PLMHNBPHMKP] = true;
			}
		}
		for (int k = 0; k <= MLIBDDCCKBM.DLLJFCPCMFL; k++)
		{
			if (array[k])
			{
				BPNMNMJHOJH.Add(k);
			}
		}
	}

	// Token: 0x060089B9 RID: 35257 RVA: 0x003D62DC File Offset: 0x003D44DC
	private static void OONBFOJFOJB(string MJHGIIEINOE, HEGNCPKIFKM AIHBCIAHFPD, ushort ONFOAHIAKJF, int EENGLNKNAPF, bool MFHFINIIONB, bool PBBJJCILNIK, bool DDLJFDLEEKH, bool DENDOFCALHK, bool OHNPIFBHABE, bool AGKGDGKFHPN)
	{
		GDAOFOFBLPF gdaofofblpf;
		if (!MLIBDDCCKBM.LGMONCCMEDO.TryGetValue(MJHGIIEINOE, out gdaofofblpf))
		{
			gdaofofblpf = new GDAOFOFBLPF();
			gdaofofblpf.JKLAKEDMACO = MJHGIIEINOE;
			gdaofofblpf.DFEHICLDMJD = new List<DHJPAFCHGHL>(4);
			gdaofofblpf.OFELEAKFHJH = DDLJFDLEEKH;
			MLIBDDCCKBM.LGMONCCMEDO.Add(MJHGIIEINOE, gdaofofblpf);
			MLIBDDCCKBM.EBHIDIMEBEH.Add(gdaofofblpf);
		}
		ushort num = (ushort)(MFHFINIIONB ? 511 : GADABGOBJIM.IEDAGPCMENK(EENGLNKNAPF));
		if (AIHBCIAHFPD.GEMCPMEMNHJ == 0 || 1 == AIHBCIAHFPD.GEMCPMEMNHJ)
		{
			gdaofofblpf.KMHILDMHJMA = true;
		}
		if (2 == AIHBCIAHFPD.GEMCPMEMNHJ)
		{
			gdaofofblpf.AHGIOFJBEAB = true;
		}
		int num2 = gdaofofblpf.DFEHICLDMJD.Count - 1;
		if (0 <= num2)
		{
			DHJPAFCHGHL dhjpafchghl = gdaofofblpf.DFEHICLDMJD[num2];
			if ((int)dhjpafchghl.PLMHNBPHMKP == AIHBCIAHFPD.PLMHNBPHMKP && dhjpafchghl.OGPKMMOIHLG == ONFOAHIAKJF)
			{
				dhjpafchghl.PPINNBMGMIE |= num;
				if (AIHBCIAHFPD.BFOOIPKJGOM > dhjpafchghl.BFOOIPKJGOM)
				{
					dhjpafchghl.BFOOIPKJGOM = AIHBCIAHFPD.BFOOIPKJGOM;
				}
				dhjpafchghl.AMEAMPOBGEO = (dhjpafchghl.AMEAMPOBGEO && OHNPIFBHABE);
				dhjpafchghl.GDCEBNDONMN = (dhjpafchghl.GDCEBNDONMN && AGKGDGKFHPN);
				dhjpafchghl.JCKHEBJFPEC = (dhjpafchghl.JCKHEBJFPEC && DENDOFCALHK);
				gdaofofblpf.DFEHICLDMJD[num2] = dhjpafchghl;
				return;
			}
		}
		DHJPAFCHGHL item = default(DHJPAFCHGHL);
		item.PLMHNBPHMKP = (short)AIHBCIAHFPD.PLMHNBPHMKP;
		item.GEMCPMEMNHJ = AIHBCIAHFPD.GEMCPMEMNHJ;
		item.BFOOIPKJGOM = AIHBCIAHFPD.BFOOIPKJGOM;
		item.PPINNBMGMIE = num;
		item.OGPKMMOIHLG = ONFOAHIAKJF;
		item.LJOAEJHFHIL = PBBJJCILNIK;
		item.AMEAMPOBGEO = OHNPIFBHABE;
		item.GDCEBNDONMN = AGKGDGKFHPN;
		item.JCKHEBJFPEC = DENDOFCALHK;
		gdaofofblpf.DFEHICLDMJD.Add(item);
		MLIBDDCCKBM.LELKHIPBJKN++;
		MLIBDDCCKBM.OOMMEBAFGCK++;
	}

	// Token: 0x060089BA RID: 35258 RVA: 0x003D64A0 File Offset: 0x003D46A0
	private static int NBMCFPPJDLN(string HJEJJGAFHAM)
	{
		for (int i = 0; i < MLIBDDCCKBM.FFAGMKFGMGB.Count; i++)
		{
			if (string.Equals(MLIBDDCCKBM.FFAGMKFGMGB[i].ODGNIFJGEHL, HJEJJGAFHAM, StringComparison.Ordinal))
			{
				return i;
			}
		}
		return -1;
	}

	// Token: 0x060089BB RID: 35259 RVA: 0x003D64E0 File Offset: 0x003D46E0
	public static void FADIOCIGPML(string GOJOGDKCNMO, CEIBHCNNIDC JDKEFOCIIOI, List<int> GFFOPEDMCAP)
	{
		try
		{
			MKCHEIHILDB.JANJEMFAEPK(GOJOGDKCNMO, JDKEFOCIIOI, GFFOPEDMCAP, MLIBDDCCKBM.LMBIEPILMGK, true);
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
		MLIBDDCCKBM.LMBIEPILMGK.Clear();
	}

	// Token: 0x060089BC RID: 35260 RVA: 0x003D6520 File Offset: 0x003D4720
	private static string[] GIAGCPLKLNH(JSONNode AIHBCIAHFPD)
	{
		string[] array = new string[9];
		for (int i = 0; i < 9; i++)
		{
			array[i] = MLIBDDCCKBM.OEAPGFEIINJ(AIHBCIAHFPD, GADABGOBJIM.JPMPIIIBIEN(i)).Trim();
		}
		return array;
	}

	// Token: 0x060089BD RID: 35261 RVA: 0x003D6557 File Offset: 0x003D4757
	public static bool IHEFHIIOGMM()
	{
		return MLIBDDCCKBM.CPPJAOIEJAJ;
	}

	// Token: 0x060089BE RID: 35262 RVA: 0x003D6560 File Offset: 0x003D4760
	private static bool DGFPMKBDJMK(JSONNode AIHBCIAHFPD, string MJHGIIEINOE, out int KIDHBAMJGDO)
	{
		KIDHBAMJGDO = 0;
		string text = MLIBDDCCKBM.OEAPGFEIINJ(AIHBCIAHFPD, MJHGIIEINOE).Trim();
		return text.Length != 0 && int.TryParse(text, NumberStyles.Integer, CultureInfo.InvariantCulture, out KIDHBAMJGDO);
	}

	// Token: 0x060089BF RID: 35263 RVA: 0x003D6594 File Offset: 0x003D4794
	public static string FJPLILCMLIO(int ONFOAHIAKJF)
	{
		if (ONFOAHIAKJF < 0 || ONFOAHIAKJF >= MLIBDDCCKBM.CBIBFJOCFKE.Count)
		{
			return null;
		}
		return MLIBDDCCKBM.CBIBFJOCFKE[ONFOAHIAKJF].DBHMNECMIAB;
	}

	// Token: 0x060089C0 RID: 35264 RVA: 0x003D65BC File Offset: 0x003D47BC
	private static void EILHDDBIAHK(JSONNode EAOALLJIGFI, bool GDPEEENCGDM)
	{
		JSONArray jsonarray = MLIBDDCCKBM.LPLNBOHFOGJ(EAOALLJIGFI, GDPEEENCGDM ? "storiesSearchDerived" : "storiesSearchBalance");
		if (jsonarray == null)
		{
			return;
		}
		for (int i = 0; i < jsonarray.Count; i++)
		{
			JSONNode jsonnode = jsonarray[i];
			if (jsonnode == null)
			{
				MLIBDDCCKBM.CJBALMBBFCC++;
			}
			else
			{
				string text = MLIBDDCCKBM.OEAPGFEIINJ(jsonnode, "id").Trim();
				int num;
				if (text.Length == 0 || !MLIBDDCCKBM.DGFPMKBDJMK(jsonnode, "aind", out num))
				{
					MLIBDDCCKBM.CJBALMBBFCC++;
				}
				else if (num < 0 || num > 32767)
				{
					DPGJIJGOCIC.ADFCDFHBDAF(string.Concat(new string[]
					{
						"StoriesSearchBalance - row '",
						text,
						"' has an out-of-range aind ",
						num.ToString(),
						", skipped"
					}));
					MLIBDDCCKBM.CJBALMBBFCC++;
				}
				else
				{
					string text2 = MLIBDDCCKBM.OEAPGFEIINJ(jsonnode, "ref").Trim();
					AGAFMAAGGEK agafmaaggek = null;
					if (0 < text2.Length && !MLIBDDCCKBM.IJFDIMFLCOD.TryGetValue(text2, out agafmaaggek))
					{
						DPGJIJGOCIC.ANOPFDLPKGC(string.Concat(new string[]
						{
							"StoriesSearchBalance - row '",
							text,
							"' refs missing concept '",
							text2,
							"', skipped"
						}));
						MLIBDDCCKBM.CJBALMBBFCC++;
					}
					else if (MLIBDDCCKBM.GIEMBNKACPK && MLIBDDCCKBM.BBNNAIKNMGN(text2))
					{
						MLIBDDCCKBM.CFDHJKCALLF++;
					}
					else
					{
						string text3 = MLIBDDCCKBM.OEAPGFEIINJ(jsonnode, "cat").Trim();
						if (text3.Length == 0 && agafmaaggek != null)
						{
							text3 = agafmaaggek.GEMCPMEMNHJ;
						}
						if (text3.Length == 0 && GDPEEENCGDM)
						{
							text3 = MLIBDDCCKBM.PBAFCGPNCJI[7];
						}
						if (text3.Length == 0)
						{
							DPGJIJGOCIC.ADFCDFHBDAF("StoriesSearchBalance - row '" + text + "' has no category, skipped");
							MLIBDDCCKBM.CJBALMBBFCC++;
						}
						else
						{
							int num2 = MLIBDDCCKBM.HPILHABGIKA(text3);
							int num3;
							if (!MLIBDDCCKBM.DGFPMKBDJMK(jsonnode, "w", out num3))
							{
								num3 = MLIBDDCCKBM.FFAGMKFGMGB[num2].BFOOIPKJGOM;
							}
							if (num3 < 0)
							{
								num3 = 0;
							}
							if (num3 > 255)
							{
								num3 = 255;
							}
							if (MLIBDDCCKBM.CBIBFJOCFKE.Count > 65535)
							{
								DPGJIJGOCIC.ANOPFDLPKGC("StoriesSearchBalance - more than " + ushort.MaxValue.ToString() + " rows, the rest is ignored");
								return;
							}
							string[] array = (agafmaaggek != null) ? agafmaaggek.CBMNCLNCPLN : MLIBDDCCKBM.GIAGCPLKLNH(jsonnode);
							HEGNCPKIFKM hegncpkifkm = new HEGNCPKIFKM();
							hegncpkifkm.DBHMNECMIAB = text;
							hegncpkifkm.PLMHNBPHMKP = num;
							hegncpkifkm.GEMCPMEMNHJ = (byte)num2;
							hegncpkifkm.BFOOIPKJGOM = (byte)num3;
							hegncpkifkm.IDGFNDBOMNI = text2;
							hegncpkifkm.MIFCGKNNFAC = GDPEEENCGDM;
							if (2 == num2 || 3 == num2)
							{
								hegncpkifkm.CBMNCLNCPLN = array;
							}
							hegncpkifkm.BCHICAKNNJP = (1 == jsonnode["au"].AsInt);
							hegncpkifkm.HKJLHGDEKNO = (1 == jsonnode["nc"].AsInt);
							MLIBDDCCKBM.CBIBFJOCFKE.Add(hegncpkifkm);
							if (num > MLIBDDCCKBM.DLLJFCPCMFL)
							{
								MLIBDDCCKBM.DLLJFCPCMFL = num;
							}
							MLIBDDCCKBM.AKDLDDCCJJE(hegncpkifkm, (ushort)(MLIBDDCCKBM.CBIBFJOCFKE.Count - 1), array);
						}
					}
				}
			}
		}
	}

	// Token: 0x060089C1 RID: 35265 RVA: 0x003D68F2 File Offset: 0x003D4AF2
	public static bool KDKNDGHKABE(int ONFOAHIAKJF)
	{
		return ONFOAHIAKJF >= 0 && ONFOAHIAKJF < MLIBDDCCKBM.CBIBFJOCFKE.Count && MLIBDDCCKBM.CBIBFJOCFKE[ONFOAHIAKJF].MIFCGKNNFAC;
	}

	// Token: 0x060089C2 RID: 35266 RVA: 0x003D6917 File Offset: 0x003D4B17
	public static int KDGDHJKLCOD(int ONFOAHIAKJF)
	{
		if (ONFOAHIAKJF < 0 || ONFOAHIAKJF >= MLIBDDCCKBM.CBIBFJOCFKE.Count)
		{
			return -1;
		}
		return MLIBDDCCKBM.CBIBFJOCFKE[ONFOAHIAKJF].PLMHNBPHMKP;
	}

	// Token: 0x060089C3 RID: 35267 RVA: 0x003D693C File Offset: 0x003D4B3C
	private static void EKFIPPOCGHO(JSONNode EAOALLJIGFI)
	{
		JSONArray jsonarray = MLIBDDCCKBM.LPLNBOHFOGJ(EAOALLJIGFI, "storiesSearchStopwords");
		if (jsonarray == null)
		{
			return;
		}
		for (int i = 0; i < jsonarray.Count; i++)
		{
			JSONNode jsonnode = jsonarray[i];
			if (!(jsonnode == null))
			{
				string text = MLIBDDCCKBM.OEAPGFEIINJ(jsonnode, "lang").Trim();
				int num = GADABGOBJIM.OEEJJCAFPCF(text);
				if (num < 0)
				{
					DPGJIJGOCIC.ADFCDFHBDAF("StoriesSearchBalance - stopwords row with unknown language '" + text + "'");
				}
				else
				{
					string[] array = MLIBDDCCKBM.OEAPGFEIINJ(jsonnode, "words").Split(MLIBDDCCKBM.PBBHGEANHIF, StringSplitOptions.RemoveEmptyEntries);
					for (int j = 0; j < array.Length; j++)
					{
						array[j] = GADABGOBJIM.MAGFECMLHAJ(array[j]);
					}
					GADABGOBJIM.EHDHPDMDNIF(num, array);
				}
			}
		}
	}

	// Token: 0x060089C4 RID: 35268 RVA: 0x003D69FF File Offset: 0x003D4BFF
	public static int IIGKDHIBFLC()
	{
		return MLIBDDCCKBM.FFAGMKFGMGB.Count;
	}

	// Token: 0x060089C5 RID: 35269 RVA: 0x003D6A0C File Offset: 0x003D4C0C
	private static void JLPCNFKCCJA(string IOOCOEEGDPG, HEGNCPKIFKM AIHBCIAHFPD, ushort ONFOAHIAKJF, int EENGLNKNAPF, bool MFHFINIIONB, bool PBBJJCILNIK)
	{
		GADABGOBJIM.IAAMHNDECNP(IOOCOEEGDPG, MLIBDDCCKBM.ABHKEKJJMEG);
		bool flag = 2 == AIHBCIAHFPD.GEMCPMEMNHJ || 3 == AIHBCIAHFPD.GEMCPMEMNHJ;
		bool flag2 = AIHBCIAHFPD.GEMCPMEMNHJ == 0 || 1 == AIHBCIAHFPD.GEMCPMEMNHJ;
		int num = 0;
		for (int i = 0; i < MLIBDDCCKBM.ABHKEKJJMEG.Count; i++)
		{
			string text = MLIBDDCCKBM.ABHKEKJJMEG[i];
			bool ohnpifbhabe = flag && 0 < num;
			if (GADABGOBJIM.JOMNLCJJOBD(text))
			{
				MLIBDDCCKBM.OONBFOJFOJB(text, AIHBCIAHFPD, ONFOAHIAKJF, EENGLNKNAPF, MFHFINIIONB, PBBJJCILNIK, true, false, ohnpifbhabe, false);
				num++;
			}
			else
			{
				string text2 = GADABGOBJIM.MAGFECMLHAJ(text);
				if (text2.Length >= 2)
				{
					bool flag3 = GADABGOBJIM.LGLGBJOOFJL(EENGLNKNAPF, text2);
					if (!flag3 || flag2)
					{
						string hedgfbgeoph = GADABGOBJIM.ECIBPEJJLJB(text2);
						string text3 = GADABGOBJIM.DKNKPKLMMLN(EENGLNKNAPF, hedgfbgeoph);
						MLIBDDCCKBM.OONBFOJFOJB(text3, AIHBCIAHFPD, ONFOAHIAKJF, EENGLNKNAPF, MFHFINIIONB, PBBJJCILNIK, false, flag3, ohnpifbhabe, false);
						string text4 = GADABGOBJIM.MEGLOMOLHBH(EENGLNKNAPF, hedgfbgeoph);
						if (text4 != null && !string.Equals(text4, text3, StringComparison.Ordinal))
						{
							MLIBDDCCKBM.OONBFOJFOJB(text4, AIHBCIAHFPD, ONFOAHIAKJF, EENGLNKNAPF, MFHFINIIONB, PBBJJCILNIK, false, flag3, ohnpifbhabe, true);
						}
						num++;
					}
				}
			}
		}
	}

	// Token: 0x060089C6 RID: 35270 RVA: 0x003D6B24 File Offset: 0x003D4D24
	private static bool BBNNAIKNMGN(string DMNJEPLAAKN)
	{
		return string.Equals(DMNJEPLAAKN, "genre_lgbtq", StringComparison.Ordinal) || string.Equals("lgbtq", MLIBDDCCKBM.FMFPGNPGMEL(DMNJEPLAAKN), StringComparison.Ordinal);
	}

	// Token: 0x060089C7 RID: 35271 RVA: 0x003D6B48 File Offset: 0x003D4D48
	private static void DCCLCEAJPFL()
	{
		Stopwatch stopwatch = Stopwatch.StartNew();
		MLIBDDCCKBM.IDDHDBDPOIK();
		GADABGOBJIM.HHCIJJJDPGB();
		MLIBDDCCKBM.NCIBNOEKIDN();
		MLIBDDCCKBM.LGMONCCMEDO = new Dictionary<string, GDAOFOFBLPF>(16384, StringComparer.Ordinal);
		MLIBDDCCKBM.AHJJAANBGPH.Clear();
		try
		{
			JSONNode jsonnode = JSON.Parse(MLIBDDCCKBM.AFNODOLBBKG.text);
			if (jsonnode == null)
			{
				DPGJIJGOCIC.ANOPFDLPKGC("StoriesSearchBalance.Build() - JSON root is null");
			}
			else
			{
				MLIBDDCCKBM.DLMKNONFCHA(jsonnode["storiesSearchDefaults"]);
				MLIBDDCCKBM.EKFIPPOCGHO(jsonnode["storiesSearchStopwords"]);
				MLIBDDCCKBM.ALLKHHKEDFC(jsonnode["storiesSearchConcepts"]);
				MLIBDDCCKBM.EILHDDBIAHK(jsonnode["storiesSearchBalance"], false);
				MLIBDDCCKBM.EILHDDBIAHK(jsonnode["storiesSearchDerived"], true);
			}
			MLIBDDCCKBM.BMLICBGMCGB();
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
			MLIBDDCCKBM.LNPIDDDAEOG();
		}
		stopwatch.Stop();
		MLIBDDCCKBM.HDPODONPGAK = stopwatch.ElapsedMilliseconds;
		if (MLIBDDCCKBM.CHCJFKALAGP == 0)
		{
			DPGJIJGOCIC.ANOPFDLPKGC("StoriesSearchBalance.Build() - built index has no anthologies (TextAsset not wired or import empty)");
		}
		DPGJIJGOCIC.NFIDPOMCNLP(string.Concat(new string[]
		{
			"StoriesSearchBalance: parse+build ",
			MLIBDDCCKBM.HDPODONPGAK.ToString(),
			" ms, rows ",
			MLIBDDCCKBM.CBIBFJOCFKE.Count.ToString(),
			" (skipped ",
			MLIBDDCCKBM.CJBALMBBFCC.ToString(),
			", censored ",
			MLIBDDCCKBM.CFDHJKCALLF.ToString(),
			"), concepts ",
			MLIBDDCCKBM.IJFDIMFLCOD.Count.ToString(),
			", keys ",
			MLIBDDCCKBM.AFMEFBJCIAD().ToString(),
			", postings ",
			MLIBDDCCKBM.LELKHIPBJKN.ToString(),
			", anthologies ",
			MLIBDDCCKBM.CHCJFKALAGP.ToString(),
			", maxAind ",
			MLIBDDCCKBM.DLLJFCPCMFL.ToString(),
			", redundant variants ",
			MLIBDDCCKBM.FNPGNPHDECH.Count.ToString()
		}));
	}

	// Token: 0x060089C8 RID: 35272 RVA: 0x003D6D50 File Offset: 0x003D4F50
	public static void PKLLFALOIOF()
	{
		if (MLIBDDCCKBM.JJMMILPEELE == null)
		{
			return;
		}
		for (int i = 0; i < MLIBDDCCKBM.JJMMILPEELE.Length; i++)
		{
			MLIBDDCCKBM.JJMMILPEELE[i].LILFHCLAEEO = MLIBDDCCKBM.IFPMJOPGMID(MLIBDDCCKBM.JJMMILPEELE[i].NINBFOMIAEG);
		}
	}

	// Token: 0x060089C9 RID: 35273 RVA: 0x003D6D94 File Offset: 0x003D4F94
	public static int MLKCJHENBIJ()
	{
		return MLIBDDCCKBM.IJFDIMFLCOD.Count;
	}

	// Token: 0x060089CA RID: 35274 RVA: 0x003D6DA0 File Offset: 0x003D4FA0
	public static bool JAGLHPDCEGF(int ONFOAHIAKJF)
	{
		if (ONFOAHIAKJF < 0 || ONFOAHIAKJF >= MLIBDDCCKBM.CBIBFJOCFKE.Count)
		{
			return false;
		}
		HEGNCPKIFKM hegncpkifkm = MLIBDDCCKBM.CBIBFJOCFKE[ONFOAHIAKJF];
		if (hegncpkifkm.HKJLHGDEKNO)
		{
			return true;
		}
		AGAFMAAGGEK agafmaaggek = null;
		return hegncpkifkm.IDGFNDBOMNI != null && MLIBDDCCKBM.IJFDIMFLCOD.TryGetValue(hegncpkifkm.IDGFNDBOMNI, out agafmaaggek) && agafmaaggek != null && agafmaaggek.HKJLHGDEKNO;
	}

	// Token: 0x060089CB RID: 35275 RVA: 0x003D6DFF File Offset: 0x003D4FFF
	public static string LCNMONKLPIG(int ONFOAHIAKJF)
	{
		if (ONFOAHIAKJF < 0 || ONFOAHIAKJF >= MLIBDDCCKBM.CBIBFJOCFKE.Count)
		{
			return null;
		}
		return MLIBDDCCKBM.CBIBFJOCFKE[ONFOAHIAKJF].IDGFNDBOMNI;
	}

	// Token: 0x060089CC RID: 35276 RVA: 0x003D6E24 File Offset: 0x003D5024
	internal static void OPACHKBHPMN(int OHPGMGMMHLL)
	{
		int num = MKCHEIHILDB.KCEJOFCMKDO;
		if (num < OHPGMGMMHLL)
		{
			num = OHPGMGMMHLL;
		}
		if (num < 1)
		{
			num = 1;
		}
		int num2 = MLIBDDCCKBM.DLLJFCPCMFL + 1;
		if (num2 < 1)
		{
			num2 = 1;
		}
		int num3 = num2 * num;
		if (MLIBDDCCKBM.ANHLJBMIJJC == null || MLIBDDCCKBM.PHEDIGCFIDD < num || MLIBDDCCKBM.ANHLJBMIJJC.Length < num3)
		{
			MLIBDDCCKBM.ANHLJBMIJJC = new float[num3];
			MLIBDDCCKBM.FJIBLACMFLP = new ushort[num3];
			MLIBDDCCKBM.AMECIHIEAJH = new bool[num3];
			MLIBDDCCKBM.BANOOLGHMAB = new float[num3];
			MLIBDDCCKBM.PHEDIGCFIDD = num;
		}
		if (MLIBDDCCKBM.DKBLKJFDNGL == null || MLIBDDCCKBM.DKBLKJFDNGL.Length < num2)
		{
			MLIBDDCCKBM.DKBLKJFDNGL = new bool[num2];
		}
	}

	// Token: 0x060089CD RID: 35277 RVA: 0x003D6EBC File Offset: 0x003D50BC
	public static bool CBMEGOIOBKE()
	{
		return MLIBDDCCKBM.GIEMBNKACPK;
	}

	// Token: 0x060089CE RID: 35278 RVA: 0x003D6EC3 File Offset: 0x003D50C3
	public static int DOODMMCLBHA()
	{
		return MLIBDDCCKBM.CJBALMBBFCC;
	}

	// Token: 0x060089CF RID: 35279 RVA: 0x003D6ECA File Offset: 0x003D50CA
	public static int PEAABLAKMLG(int ONFOAHIAKJF)
	{
		if (ONFOAHIAKJF < 0 || ONFOAHIAKJF >= MLIBDDCCKBM.CBIBFJOCFKE.Count)
		{
			return 0;
		}
		return (int)MLIBDDCCKBM.CBIBFJOCFKE[ONFOAHIAKJF].BFOOIPKJGOM;
	}

	// Token: 0x060089D0 RID: 35280 RVA: 0x003D6EEF File Offset: 0x003D50EF
	public static int GFILDNHIIDI()
	{
		return MLIBDDCCKBM.CBIBFJOCFKE.Count;
	}

	// Token: 0x04002695 RID: 9877
	public const int PAEFMCIPGDP = 0;

	// Token: 0x04002696 RID: 9878
	public const int MJJJBLHCFEB = 1;

	// Token: 0x04002697 RID: 9879
	public const int AGKAGBMIOPG = 2;

	// Token: 0x04002698 RID: 9880
	public const int MPPBPEBJHEB = 3;

	// Token: 0x04002699 RID: 9881
	public const int EAFNDHBIABC = 4;

	// Token: 0x0400269A RID: 9882
	public const int KIPNBEBDCAM = 5;

	// Token: 0x0400269B RID: 9883
	public const int IOLBFLBKGPG = 6;

	// Token: 0x0400269C RID: 9884
	public const int LEKDHDJOOIP = 7;

	// Token: 0x0400269D RID: 9885
	public const int KLDOLHBMIMG = 8;

	// Token: 0x0400269E RID: 9886
	public const int HFJOFMNIBKJ = 20;

	// Token: 0x0400269F RID: 9887
	private static readonly string[] PBAFCGPNCJI = new string[]
	{
		"title",
		"alias",
		"name",
		"char",
		"concept",
		"genre",
		"author",
		"desc"
	};

	// Token: 0x040026A0 RID: 9888
	private static readonly int[] DAJPKHBCEMG = new int[]
	{
		100,
		90,
		80,
		55,
		65,
		45,
		40,
		35
	};

	// Token: 0x040026A1 RID: 9889
	private static readonly bool[] CJLLPKNKPKG = new bool[]
	{
		true,
		true,
		true,
		true,
		true,
		true,
		true,
		true
	};

	// Token: 0x040026A2 RID: 9890
	private static readonly bool[] CKNMEGDEGHM = new bool[]
	{
		true,
		true,
		true,
		true,
		true,
		false,
		true,
		true
	};

	// Token: 0x040026A3 RID: 9891
	private static readonly bool[] OGJFMEDLDFJ = new bool[]
	{
		false,
		true,
		true,
		true,
		false,
		false,
		true,
		false
	};

	// Token: 0x040026A4 RID: 9892
	public const int KHCGKHGHGOI = 0;

	// Token: 0x040026A5 RID: 9893
	public const int MLNNHDNPJKN = 1;

	// Token: 0x040026A6 RID: 9894
	public const int AFIJAAPJAHO = 2;

	// Token: 0x040026A7 RID: 9895
	private const string KPNLMPCIGIC = "storiesSearchBalance";

	// Token: 0x040026A8 RID: 9896
	private const string LLDBECLGKDA = "storiesSearchDerived";

	// Token: 0x040026A9 RID: 9897
	private const string HHBNGPLEPEI = "storiesSearchConcepts";

	// Token: 0x040026AA RID: 9898
	private const string JPMBGBFJOFL = "storiesSearchDefaults";

	// Token: 0x040026AB RID: 9899
	private const string JIELBPEKMPJ = "storiesSearchStopwords";

	// Token: 0x040026AC RID: 9900
	public const string KFLLJMNGPPO = "genre_lgbtq";

	// Token: 0x040026AD RID: 9901
	private const string KMIHJEAJFAK = "author";

	// Token: 0x040026AE RID: 9902
	private const string NIJIKAIDEKE = "lgbtq";

	// Token: 0x040026AF RID: 9903
	private static HashSet<string> AHJJAANBGPH = new HashSet<string>(StringComparer.OrdinalIgnoreCase);

	// Token: 0x040026B0 RID: 9904
	private static TextAsset AFNODOLBBKG = null;

	// Token: 0x040026B1 RID: 9905
	private static bool CPPJAOIEJAJ = false;

	// Token: 0x040026B2 RID: 9906
	private static bool GIEMBNKACPK = false;

	// Token: 0x040026B3 RID: 9907
	internal static Dictionary<string, GDAOFOFBLPF> LGMONCCMEDO = null;

	// Token: 0x040026B4 RID: 9908
	private static readonly List<GDAOFOFBLPF> EBHIDIMEBEH = new List<GDAOFOFBLPF>(16384);

	// Token: 0x040026B5 RID: 9909
	internal static GDAOFOFBLPF[] JJMMILPEELE = null;

	// Token: 0x040026B6 RID: 9910
	internal static List<GDAOFOFBLPF>[] LKNIGBBMPMG = null;

	// Token: 0x040026B7 RID: 9911
	internal static List<HEGNCPKIFKM> CBIBFJOCFKE = new List<HEGNCPKIFKM>();

	// Token: 0x040026B8 RID: 9912
	internal static List<EICLEMCHODB> FFAGMKFGMGB = new List<EICLEMCHODB>();

	// Token: 0x040026B9 RID: 9913
	private static Dictionary<string, AGAFMAAGGEK> IJFDIMFLCOD = new Dictionary<string, AGAFMAAGGEK>(StringComparer.Ordinal);

	// Token: 0x040026BA RID: 9914
	internal static int CHCJFKALAGP = 0;

	// Token: 0x040026BB RID: 9915
	internal static int DLLJFCPCMFL = -1;

	// Token: 0x040026BC RID: 9916
	private static int LELKHIPBJKN = 0;

	// Token: 0x040026BD RID: 9917
	private static int OOMMEBAFGCK = 0;

	// Token: 0x040026BE RID: 9918
	private static int CJBALMBBFCC = 0;

	// Token: 0x040026BF RID: 9919
	private static int CFDHJKCALLF = 0;

	// Token: 0x040026C0 RID: 9920
	private static int JBJKBNOJEGN = 0;

	// Token: 0x040026C1 RID: 9921
	private static int[] JDLOAMKBPBJ = new int[9];

	// Token: 0x040026C2 RID: 9922
	private static List<string> FNPGNPHDECH = new List<string>();

	// Token: 0x040026C3 RID: 9923
	private static long HDPODONPGAK = -1L;

	// Token: 0x040026C4 RID: 9924
	internal static float[] ANHLJBMIJJC = null;

	// Token: 0x040026C5 RID: 9925
	internal static ushort[] FJIBLACMFLP = null;

	// Token: 0x040026C6 RID: 9926
	internal static bool[] AMECIHIEAJH = null;

	// Token: 0x040026C7 RID: 9927
	internal static float[] BANOOLGHMAB = null;

	// Token: 0x040026C8 RID: 9928
	internal static bool[] DKBLKJFDNGL = null;

	// Token: 0x040026C9 RID: 9929
	internal static int PHEDIGCFIDD = 0;

	// Token: 0x040026CA RID: 9930
	private static readonly List<string> ABHKEKJJMEG = new List<string>(16);

	// Token: 0x040026CB RID: 9931
	private static readonly List<OJPLEKECIFI> LMBIEPILMGK = new List<OJPLEKECIFI>(64);

	// Token: 0x040026CC RID: 9932
	private static Dictionary<int, List<int>> OKCPCEPJAEK = null;

	// Token: 0x040026CD RID: 9933
	private static int AOOKELMKMKL = -1;

	// Token: 0x040026CE RID: 9934
	private static readonly char[] PBBHGEANHIF = new char[]
	{
		' ',
		'\t',
		'\r',
		'\n'
	};

	// Token: 0x040026CF RID: 9935
	private static readonly char[] CJAOELFNOJA = new char[]
	{
		'|'
	};
}
