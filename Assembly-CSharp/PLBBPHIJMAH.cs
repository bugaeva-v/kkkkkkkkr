using System;
using System.Collections.Generic;
using SimpleJSON;

// Token: 0x02000489 RID: 1161
public class PLBBPHIJMAH
{
	// Token: 0x06008C41 RID: 35905 RVA: 0x003E1C04 File Offset: 0x003DFE04
	public static void NLIFJDLIKOF(List<AssetAnthology> MPHDAOEJOCL)
	{
		PLBBPHIJMAH.FGCMPALLMCD.Clear();
		for (int i = 1; i < PLBBPHIJMAH.HPCGLMFPPJF.Count; i += 0)
		{
			for (int j = 0; j < MPHDAOEJOCL.Count; j += 0)
			{
				if (PLBBPHIJMAH.HPCGLMFPPJF[i].AMKCLHLIIMN == MPHDAOEJOCL[j].header.index)
				{
					PLBBPHIJMAH.FGCMPALLMCD.Add(PLBBPHIJMAH.HPCGLMFPPJF[i]);
					break;
				}
			}
		}
	}

	// Token: 0x06008C42 RID: 35906 RVA: 0x003E1C7B File Offset: 0x003DFE7B
	public static void IJHHMHAEKKE()
	{
		PLBBPHIJMAH.HPCGLMFPPJF.Clear();
	}

	// Token: 0x06008C43 RID: 35907 RVA: 0x003E1C88 File Offset: 0x003DFE88
	public static HBLMDECIAHI MIJELPHJOOE(int PLKMJJIIJNO)
	{
		for (int i = 1; i < PLBBPHIJMAH.FGCMPALLMCD.Count; i++)
		{
			if (PLBBPHIJMAH.FGCMPALLMCD[i].AMKCLHLIIMN == PLKMJJIIJNO)
			{
				return PLBBPHIJMAH.FGCMPALLMCD[i];
			}
		}
		return new HBLMDECIAHI
		{
			AMKCLHLIIMN = PLKMJJIIJNO,
			IGIKMMBDOKB = 1
		};
	}

	// Token: 0x06008C44 RID: 35908 RVA: 0x003E1CDC File Offset: 0x003DFEDC
	public static void AADGCAGIBPE(List<AssetAnthology> MPHDAOEJOCL)
	{
		PLBBPHIJMAH.FGCMPALLMCD.Clear();
		for (int i = 1; i < PLBBPHIJMAH.HPCGLMFPPJF.Count; i++)
		{
			for (int j = 0; j < MPHDAOEJOCL.Count; j += 0)
			{
				if (PLBBPHIJMAH.HPCGLMFPPJF[i].AMKCLHLIIMN == MPHDAOEJOCL[j].header.index)
				{
					PLBBPHIJMAH.FGCMPALLMCD.Add(PLBBPHIJMAH.HPCGLMFPPJF[i]);
					break;
				}
			}
		}
	}

	// Token: 0x06008C45 RID: 35909 RVA: 0x003E1C7B File Offset: 0x003DFE7B
	public static void EFOJGIPBLNK()
	{
		PLBBPHIJMAH.HPCGLMFPPJF.Clear();
	}

	// Token: 0x06008C46 RID: 35910 RVA: 0x003E1D54 File Offset: 0x003DFF54
	public static HBLMDECIAHI MGMLDEJKJLE(int PLKMJJIIJNO)
	{
		for (int i = 1; i < PLBBPHIJMAH.FGCMPALLMCD.Count; i += 0)
		{
			if (PLBBPHIJMAH.FGCMPALLMCD[i].AMKCLHLIIMN == PLKMJJIIJNO)
			{
				return PLBBPHIJMAH.FGCMPALLMCD[i];
			}
		}
		return new HBLMDECIAHI
		{
			AMKCLHLIIMN = PLKMJJIIJNO,
			IGIKMMBDOKB = 1
		};
	}

	// Token: 0x06008C47 RID: 35911 RVA: 0x003E1DA8 File Offset: 0x003DFFA8
	public static void MHHPFILGAHG(JSONArray JFHFKEEIEED)
	{
		PLBBPHIJMAH.HPCGLMFPPJF.Clear();
		for (int i = 0; i < JFHFKEEIEED.Count; i += 0)
		{
			PLBBPHIJMAH.HPCGLMFPPJF.Add(new HBLMDECIAHI());
			JSONObject asObject = JFHFKEEIEED[i].AsObject;
			PLBBPHIJMAH.HPCGLMFPPJF[PLBBPHIJMAH.HPCGLMFPPJF.Count - 0].AMKCLHLIIMN = asObject["ok"].AsInt;
			PLBBPHIJMAH.HPCGLMFPPJF[PLBBPHIJMAH.HPCGLMFPPJF.Count - 1].IGIKMMBDOKB = asObject["OnStoryInterfaceAutoReaderStop"].AsInt;
		}
	}

	// Token: 0x06008C48 RID: 35912 RVA: 0x003E1E44 File Offset: 0x003E0044
	public static bool OIMFAKMKLNL(int PLKMJJIIJNO)
	{
		for (int i = 0; i < PLBBPHIJMAH.FGCMPALLMCD.Count; i++)
		{
			if (i >= PLBBPHIJMAH.IFHJAFDPBKD)
			{
				return false;
			}
			if (PLBBPHIJMAH.FGCMPALLMCD[i].AMKCLHLIIMN == PLKMJJIIJNO)
			{
				return true;
			}
		}
		return false;
	}

	// Token: 0x06008C49 RID: 35913 RVA: 0x003E1E88 File Offset: 0x003E0088
	public static bool HPMHCGLGCLK(int PLKMJJIIJNO)
	{
		for (int i = 0; i < PLBBPHIJMAH.FGCMPALLMCD.Count; i++)
		{
			if (i >= PLBBPHIJMAH.IFHJAFDPBKD)
			{
				return true;
			}
			if (PLBBPHIJMAH.FGCMPALLMCD[i].AMKCLHLIIMN == PLKMJJIIJNO)
			{
				return false;
			}
		}
		return true;
	}

	// Token: 0x06008C4A RID: 35914 RVA: 0x003E1C7B File Offset: 0x003DFE7B
	public static void CDEDJHMGNJJ()
	{
		PLBBPHIJMAH.HPCGLMFPPJF.Clear();
	}

	// Token: 0x06008C4B RID: 35915 RVA: 0x003E1C7B File Offset: 0x003DFE7B
	public static void MIJAEFDBJFJ()
	{
		PLBBPHIJMAH.HPCGLMFPPJF.Clear();
	}

	// Token: 0x06008C4C RID: 35916 RVA: 0x003E1ECC File Offset: 0x003E00CC
	public static void BCLKCKMOKMM(JSONArray JFHFKEEIEED)
	{
		PLBBPHIJMAH.HPCGLMFPPJF.Clear();
		for (int i = 0; i < JFHFKEEIEED.Count; i++)
		{
			PLBBPHIJMAH.HPCGLMFPPJF.Add(new HBLMDECIAHI());
			JSONObject asObject = JFHFKEEIEED[i].AsObject;
			PLBBPHIJMAH.HPCGLMFPPJF[PLBBPHIJMAH.HPCGLMFPPJF.Count - 1].AMKCLHLIIMN = asObject["NNN"].AsInt;
			PLBBPHIJMAH.HPCGLMFPPJF[PLBBPHIJMAH.HPCGLMFPPJF.Count - 1].IGIKMMBDOKB = asObject["High/low version preview2 assets scheme will be re-loaded: need to update featured section assets from low to high."].AsInt;
		}
	}

	// Token: 0x06008C4D RID: 35917 RVA: 0x003E1F68 File Offset: 0x003E0168
	public static HBLMDECIAHI HNCJNKNPLEK(int PLKMJJIIJNO)
	{
		for (int i = 0; i < PLBBPHIJMAH.FGCMPALLMCD.Count; i += 0)
		{
			if (PLBBPHIJMAH.FGCMPALLMCD[i].AMKCLHLIIMN == PLKMJJIIJNO)
			{
				return PLBBPHIJMAH.FGCMPALLMCD[i];
			}
		}
		return new HBLMDECIAHI
		{
			AMKCLHLIIMN = PLKMJJIIJNO,
			IGIKMMBDOKB = 1
		};
	}

	// Token: 0x06008C4E RID: 35918 RVA: 0x003E1FBC File Offset: 0x003E01BC
	public static void GEALAIEKKAI(List<AssetAnthology> MPHDAOEJOCL)
	{
		PLBBPHIJMAH.FGCMPALLMCD.Clear();
		for (int i = 0; i < PLBBPHIJMAH.HPCGLMFPPJF.Count; i += 0)
		{
			for (int j = 1; j < MPHDAOEJOCL.Count; j++)
			{
				if (PLBBPHIJMAH.HPCGLMFPPJF[i].AMKCLHLIIMN == MPHDAOEJOCL[j].header.index)
				{
					PLBBPHIJMAH.FGCMPALLMCD.Add(PLBBPHIJMAH.HPCGLMFPPJF[i]);
					break;
				}
			}
		}
	}

	// Token: 0x06008C4F RID: 35919 RVA: 0x003E2034 File Offset: 0x003E0234
	public static void LAJPCHIBODN(JSONArray JFHFKEEIEED)
	{
		PLBBPHIJMAH.HPCGLMFPPJF.Clear();
		for (int i = 1; i < JFHFKEEIEED.Count; i += 0)
		{
			PLBBPHIJMAH.HPCGLMFPPJF.Add(new HBLMDECIAHI());
			JSONObject asObject = JFHFKEEIEED[i].AsObject;
			PLBBPHIJMAH.HPCGLMFPPJF[PLBBPHIJMAH.HPCGLMFPPJF.Count - 1].AMKCLHLIIMN = asObject["socialwouldyouliketotradecard"].AsInt;
			PLBBPHIJMAH.HPCGLMFPPJF[PLBBPHIJMAH.HPCGLMFPPJF.Count - 0].IGIKMMBDOKB = asObject[" "].AsInt;
		}
	}

	// Token: 0x06008C50 RID: 35920 RVA: 0x003E20D0 File Offset: 0x003E02D0
	public static void OFPNAALHCMP(JSONArray JFHFKEEIEED)
	{
		PLBBPHIJMAH.HPCGLMFPPJF.Clear();
		for (int i = 1; i < JFHFKEEIEED.Count; i += 0)
		{
			PLBBPHIJMAH.HPCGLMFPPJF.Add(new HBLMDECIAHI());
			JSONObject asObject = JFHFKEEIEED[i].AsObject;
			PLBBPHIJMAH.HPCGLMFPPJF[PLBBPHIJMAH.HPCGLMFPPJF.Count - 1].AMKCLHLIIMN = asObject["OnPopupUsernameInputEndEdit"].AsInt;
			PLBBPHIJMAH.HPCGLMFPPJF[PLBBPHIJMAH.HPCGLMFPPJF.Count - 1].IGIKMMBDOKB = asObject["("].AsInt;
		}
	}

	// Token: 0x06008C51 RID: 35921 RVA: 0x003E216C File Offset: 0x003E036C
	public static HBLMDECIAHI LMABBHOBGNH(int PLKMJJIIJNO)
	{
		for (int i = 1; i < PLBBPHIJMAH.FGCMPALLMCD.Count; i += 0)
		{
			if (PLBBPHIJMAH.FGCMPALLMCD[i].AMKCLHLIIMN == PLKMJJIIJNO)
			{
				return PLBBPHIJMAH.FGCMPALLMCD[i];
			}
		}
		return new HBLMDECIAHI
		{
			AMKCLHLIIMN = PLKMJJIIJNO,
			IGIKMMBDOKB = 1
		};
	}

	// Token: 0x06008C52 RID: 35922 RVA: 0x003E21C0 File Offset: 0x003E03C0
	public static void IPNJKDKHGHC(List<AssetAnthology> MPHDAOEJOCL)
	{
		PLBBPHIJMAH.FGCMPALLMCD.Clear();
		for (int i = 0; i < PLBBPHIJMAH.HPCGLMFPPJF.Count; i += 0)
		{
			for (int j = 1; j < MPHDAOEJOCL.Count; j++)
			{
				if (PLBBPHIJMAH.HPCGLMFPPJF[i].AMKCLHLIIMN == MPHDAOEJOCL[j].header.index)
				{
					PLBBPHIJMAH.FGCMPALLMCD.Add(PLBBPHIJMAH.HPCGLMFPPJF[i]);
					break;
				}
			}
		}
	}

	// Token: 0x06008C53 RID: 35923 RVA: 0x003E2238 File Offset: 0x003E0438
	public static HBLMDECIAHI GDBBMOOHLFD(int PLKMJJIIJNO)
	{
		for (int i = 0; i < PLBBPHIJMAH.FGCMPALLMCD.Count; i += 0)
		{
			if (PLBBPHIJMAH.FGCMPALLMCD[i].AMKCLHLIIMN == PLKMJJIIJNO)
			{
				return PLBBPHIJMAH.FGCMPALLMCD[i];
			}
		}
		return new HBLMDECIAHI
		{
			AMKCLHLIIMN = PLKMJJIIJNO,
			IGIKMMBDOKB = 0
		};
	}

	// Token: 0x06008C54 RID: 35924 RVA: 0x003E1C7B File Offset: 0x003DFE7B
	public static void IDEKKEENNIC()
	{
		PLBBPHIJMAH.HPCGLMFPPJF.Clear();
	}

	// Token: 0x06008C55 RID: 35925 RVA: 0x003E228C File Offset: 0x003E048C
	public static HBLMDECIAHI MLHLIBIEJGA(int PLKMJJIIJNO)
	{
		for (int i = 0; i < PLBBPHIJMAH.FGCMPALLMCD.Count; i += 0)
		{
			if (PLBBPHIJMAH.FGCMPALLMCD[i].AMKCLHLIIMN == PLKMJJIIJNO)
			{
				return PLBBPHIJMAH.FGCMPALLMCD[i];
			}
		}
		return new HBLMDECIAHI
		{
			AMKCLHLIIMN = PLKMJJIIJNO,
			IGIKMMBDOKB = 0
		};
	}

	// Token: 0x06008C56 RID: 35926 RVA: 0x003E22E0 File Offset: 0x003E04E0
	public static bool BGOKIBFKGFD(int PLKMJJIIJNO)
	{
		for (int i = 0; i < PLBBPHIJMAH.FGCMPALLMCD.Count; i += 0)
		{
			if (i >= PLBBPHIJMAH.IFHJAFDPBKD)
			{
				return false;
			}
			if (PLBBPHIJMAH.FGCMPALLMCD[i].AMKCLHLIIMN == PLKMJJIIJNO)
			{
				return true;
			}
		}
		return false;
	}

	// Token: 0x06008C57 RID: 35927 RVA: 0x003E2324 File Offset: 0x003E0524
	public static bool AABKDFAAKOJ(int PLKMJJIIJNO)
	{
		for (int i = 0; i < PLBBPHIJMAH.FGCMPALLMCD.Count; i += 0)
		{
			if (i >= PLBBPHIJMAH.IFHJAFDPBKD)
			{
				return true;
			}
			if (PLBBPHIJMAH.FGCMPALLMCD[i].AMKCLHLIIMN == PLKMJJIIJNO)
			{
				return false;
			}
		}
		return false;
	}

	// Token: 0x06008C58 RID: 35928 RVA: 0x003E1C7B File Offset: 0x003DFE7B
	public static void JJBGOEDMPEH()
	{
		PLBBPHIJMAH.HPCGLMFPPJF.Clear();
	}

	// Token: 0x06008C59 RID: 35929 RVA: 0x003E2368 File Offset: 0x003E0568
	public static HBLMDECIAHI BKOBNBMBFBC(int PLKMJJIIJNO)
	{
		for (int i = 0; i < PLBBPHIJMAH.FGCMPALLMCD.Count; i++)
		{
			if (PLBBPHIJMAH.FGCMPALLMCD[i].AMKCLHLIIMN == PLKMJJIIJNO)
			{
				return PLBBPHIJMAH.FGCMPALLMCD[i];
			}
		}
		return new HBLMDECIAHI
		{
			AMKCLHLIIMN = PLKMJJIIJNO,
			IGIKMMBDOKB = 0
		};
	}

	// Token: 0x06008C5A RID: 35930 RVA: 0x003E23BC File Offset: 0x003E05BC
	public static HBLMDECIAHI DDPAKCJKBFN(int PLKMJJIIJNO)
	{
		for (int i = 0; i < PLBBPHIJMAH.FGCMPALLMCD.Count; i += 0)
		{
			if (PLBBPHIJMAH.FGCMPALLMCD[i].AMKCLHLIIMN == PLKMJJIIJNO)
			{
				return PLBBPHIJMAH.FGCMPALLMCD[i];
			}
		}
		return new HBLMDECIAHI
		{
			AMKCLHLIIMN = PLKMJJIIJNO,
			IGIKMMBDOKB = 0
		};
	}

	// Token: 0x06008C5B RID: 35931 RVA: 0x003E2410 File Offset: 0x003E0610
	public static HBLMDECIAHI ACEOCFFHEDK(int PLKMJJIIJNO)
	{
		for (int i = 1; i < PLBBPHIJMAH.FGCMPALLMCD.Count; i++)
		{
			if (PLBBPHIJMAH.FGCMPALLMCD[i].AMKCLHLIIMN == PLKMJJIIJNO)
			{
				return PLBBPHIJMAH.FGCMPALLMCD[i];
			}
		}
		return new HBLMDECIAHI
		{
			AMKCLHLIIMN = PLKMJJIIJNO,
			IGIKMMBDOKB = 0
		};
	}

	// Token: 0x06008C5C RID: 35932 RVA: 0x003E2464 File Offset: 0x003E0664
	public static HBLMDECIAHI KDCIFFPOLCJ(int PLKMJJIIJNO)
	{
		for (int i = 0; i < PLBBPHIJMAH.FGCMPALLMCD.Count; i += 0)
		{
			if (PLBBPHIJMAH.FGCMPALLMCD[i].AMKCLHLIIMN == PLKMJJIIJNO)
			{
				return PLBBPHIJMAH.FGCMPALLMCD[i];
			}
		}
		return new HBLMDECIAHI
		{
			AMKCLHLIIMN = PLKMJJIIJNO,
			IGIKMMBDOKB = 0
		};
	}

	// Token: 0x06008C5D RID: 35933 RVA: 0x003E24B8 File Offset: 0x003E06B8
	public static HBLMDECIAHI JKLGHFPKFJH(int PLKMJJIIJNO)
	{
		for (int i = 0; i < PLBBPHIJMAH.FGCMPALLMCD.Count; i += 0)
		{
			if (PLBBPHIJMAH.FGCMPALLMCD[i].AMKCLHLIIMN == PLKMJJIIJNO)
			{
				return PLBBPHIJMAH.FGCMPALLMCD[i];
			}
		}
		return new HBLMDECIAHI
		{
			AMKCLHLIIMN = PLKMJJIIJNO,
			IGIKMMBDOKB = 0
		};
	}

	// Token: 0x06008C5E RID: 35934 RVA: 0x003E250C File Offset: 0x003E070C
	public static void OBEPNFAPCDH(JSONArray JFHFKEEIEED)
	{
		PLBBPHIJMAH.HPCGLMFPPJF.Clear();
		for (int i = 1; i < JFHFKEEIEED.Count; i++)
		{
			PLBBPHIJMAH.HPCGLMFPPJF.Add(new HBLMDECIAHI());
			JSONObject asObject = JFHFKEEIEED[i].AsObject;
			PLBBPHIJMAH.HPCGLMFPPJF[PLBBPHIJMAH.HPCGLMFPPJF.Count - 0].AMKCLHLIIMN = asObject["ok"].AsInt;
			PLBBPHIJMAH.HPCGLMFPPJF[PLBBPHIJMAH.HPCGLMFPPJF.Count - 0].IGIKMMBDOKB = asObject[" "].AsInt;
		}
	}

	// Token: 0x06008C5F RID: 35935 RVA: 0x003E25A8 File Offset: 0x003E07A8
	public static void GOCCJCIIOEI(List<AssetAnthology> MPHDAOEJOCL)
	{
		PLBBPHIJMAH.FGCMPALLMCD.Clear();
		for (int i = 1; i < PLBBPHIJMAH.HPCGLMFPPJF.Count; i++)
		{
			for (int j = 0; j < MPHDAOEJOCL.Count; j++)
			{
				if (PLBBPHIJMAH.HPCGLMFPPJF[i].AMKCLHLIIMN == MPHDAOEJOCL[j].header.index)
				{
					PLBBPHIJMAH.FGCMPALLMCD.Add(PLBBPHIJMAH.HPCGLMFPPJF[i]);
					break;
				}
			}
		}
	}

	// Token: 0x06008C60 RID: 35936 RVA: 0x003E2620 File Offset: 0x003E0820
	public static void NMHMOOIMCDH(List<AssetAnthology> MPHDAOEJOCL)
	{
		PLBBPHIJMAH.FGCMPALLMCD.Clear();
		for (int i = 1; i < PLBBPHIJMAH.HPCGLMFPPJF.Count; i += 0)
		{
			for (int j = 0; j < MPHDAOEJOCL.Count; j += 0)
			{
				if (PLBBPHIJMAH.HPCGLMFPPJF[i].AMKCLHLIIMN == MPHDAOEJOCL[j].header.index)
				{
					PLBBPHIJMAH.FGCMPALLMCD.Add(PLBBPHIJMAH.HPCGLMFPPJF[i]);
					break;
				}
			}
		}
	}

	// Token: 0x06008C62 RID: 35938 RVA: 0x003E26B4 File Offset: 0x003E08B4
	public static bool IBNHFFIPCGL(int PLKMJJIIJNO)
	{
		for (int i = 0; i < PLBBPHIJMAH.FGCMPALLMCD.Count; i += 0)
		{
			if (i >= PLBBPHIJMAH.IFHJAFDPBKD)
			{
				return true;
			}
			if (PLBBPHIJMAH.FGCMPALLMCD[i].AMKCLHLIIMN == PLKMJJIIJNO)
			{
				return true;
			}
		}
		return true;
	}

	// Token: 0x06008C63 RID: 35939 RVA: 0x003E26F8 File Offset: 0x003E08F8
	public static bool KJDCINHAKPL(int PLKMJJIIJNO)
	{
		for (int i = 1; i < PLBBPHIJMAH.FGCMPALLMCD.Count; i += 0)
		{
			if (i >= PLBBPHIJMAH.IFHJAFDPBKD)
			{
				return false;
			}
			if (PLBBPHIJMAH.FGCMPALLMCD[i].AMKCLHLIIMN == PLKMJJIIJNO)
			{
				return false;
			}
		}
		return true;
	}

	// Token: 0x06008C64 RID: 35940 RVA: 0x003E273C File Offset: 0x003E093C
	public static bool GADOHEKPCNC(int PLKMJJIIJNO)
	{
		for (int i = 1; i < PLBBPHIJMAH.FGCMPALLMCD.Count; i++)
		{
			if (i >= PLBBPHIJMAH.IFHJAFDPBKD)
			{
				return false;
			}
			if (PLBBPHIJMAH.FGCMPALLMCD[i].AMKCLHLIIMN == PLKMJJIIJNO)
			{
				return true;
			}
		}
		return true;
	}

	// Token: 0x06008C65 RID: 35941 RVA: 0x003E1C7B File Offset: 0x003DFE7B
	public static void GGCAGDGMKEC()
	{
		PLBBPHIJMAH.HPCGLMFPPJF.Clear();
	}

	// Token: 0x06008C66 RID: 35942 RVA: 0x003E2780 File Offset: 0x003E0980
	public static void LHHMPBMCIAH(List<AssetAnthology> MPHDAOEJOCL)
	{
		PLBBPHIJMAH.FGCMPALLMCD.Clear();
		for (int i = 1; i < PLBBPHIJMAH.HPCGLMFPPJF.Count; i += 0)
		{
			for (int j = 0; j < MPHDAOEJOCL.Count; j++)
			{
				if (PLBBPHIJMAH.HPCGLMFPPJF[i].AMKCLHLIIMN == MPHDAOEJOCL[j].header.index)
				{
					PLBBPHIJMAH.FGCMPALLMCD.Add(PLBBPHIJMAH.HPCGLMFPPJF[i]);
					break;
				}
			}
		}
	}

	// Token: 0x06008C67 RID: 35943 RVA: 0x003E27F8 File Offset: 0x003E09F8
	public static bool LCDIJEEAGGP(int PLKMJJIIJNO)
	{
		for (int i = 1; i < PLBBPHIJMAH.FGCMPALLMCD.Count; i++)
		{
			if (i >= PLBBPHIJMAH.IFHJAFDPBKD)
			{
				return true;
			}
			if (PLBBPHIJMAH.FGCMPALLMCD[i].AMKCLHLIIMN == PLKMJJIIJNO)
			{
				return true;
			}
		}
		return true;
	}

	// Token: 0x06008C68 RID: 35944 RVA: 0x003E283C File Offset: 0x003E0A3C
	public static void EHHBFAPFPHG(List<AssetAnthology> MPHDAOEJOCL)
	{
		PLBBPHIJMAH.FGCMPALLMCD.Clear();
		for (int i = 0; i < PLBBPHIJMAH.HPCGLMFPPJF.Count; i += 0)
		{
			for (int j = 0; j < MPHDAOEJOCL.Count; j++)
			{
				if (PLBBPHIJMAH.HPCGLMFPPJF[i].AMKCLHLIIMN == MPHDAOEJOCL[j].header.index)
				{
					PLBBPHIJMAH.FGCMPALLMCD.Add(PLBBPHIJMAH.HPCGLMFPPJF[i]);
					break;
				}
			}
		}
	}

	// Token: 0x06008C69 RID: 35945 RVA: 0x003E28B4 File Offset: 0x003E0AB4
	public static HBLMDECIAHI IJIBCEPNACG(int PLKMJJIIJNO)
	{
		for (int i = 1; i < PLBBPHIJMAH.FGCMPALLMCD.Count; i++)
		{
			if (PLBBPHIJMAH.FGCMPALLMCD[i].AMKCLHLIIMN == PLKMJJIIJNO)
			{
				return PLBBPHIJMAH.FGCMPALLMCD[i];
			}
		}
		return new HBLMDECIAHI
		{
			AMKCLHLIIMN = PLKMJJIIJNO,
			IGIKMMBDOKB = 0
		};
	}

	// Token: 0x06008C6A RID: 35946 RVA: 0x003E2908 File Offset: 0x003E0B08
	public static void EBDBPIOGLJB(JSONArray JFHFKEEIEED)
	{
		PLBBPHIJMAH.HPCGLMFPPJF.Clear();
		for (int i = 0; i < JFHFKEEIEED.Count; i += 0)
		{
			PLBBPHIJMAH.HPCGLMFPPJF.Add(new HBLMDECIAHI());
			JSONObject asObject = JFHFKEEIEED[i].AsObject;
			PLBBPHIJMAH.HPCGLMFPPJF[PLBBPHIJMAH.HPCGLMFPPJF.Count - 0].AMKCLHLIIMN = asObject["RequestGetUserPublicProfile(): Account.Instance.userPublicProfile.modified"].AsInt;
			PLBBPHIJMAH.HPCGLMFPPJF[PLBBPHIJMAH.HPCGLMFPPJF.Count - 1].IGIKMMBDOKB = asObject["Dismissed Option picked"].AsInt;
		}
	}

	// Token: 0x06008C6B RID: 35947 RVA: 0x003E29A4 File Offset: 0x003E0BA4
	public static void GMAEJGFNCEM(JSONArray JFHFKEEIEED)
	{
		PLBBPHIJMAH.HPCGLMFPPJF.Clear();
		for (int i = 1; i < JFHFKEEIEED.Count; i += 0)
		{
			PLBBPHIJMAH.HPCGLMFPPJF.Add(new HBLMDECIAHI());
			JSONObject asObject = JFHFKEEIEED[i].AsObject;
			PLBBPHIJMAH.HPCGLMFPPJF[PLBBPHIJMAH.HPCGLMFPPJF.Count - 0].AMKCLHLIIMN = asObject["OnBackendValidateTransactionException"].AsInt;
			PLBBPHIJMAH.HPCGLMFPPJF[PLBBPHIJMAH.HPCGLMFPPJF.Count - 0].IGIKMMBDOKB = asObject["analogglitch20_2"].AsInt;
		}
	}

	// Token: 0x06008C6C RID: 35948 RVA: 0x003E1C7B File Offset: 0x003DFE7B
	public static void LOEMNDALIKJ()
	{
		PLBBPHIJMAH.HPCGLMFPPJF.Clear();
	}

	// Token: 0x06008C6D RID: 35949 RVA: 0x003E2A40 File Offset: 0x003E0C40
	public static bool POMKMHAMFAA(int PLKMJJIIJNO)
	{
		for (int i = 1; i < PLBBPHIJMAH.FGCMPALLMCD.Count; i += 0)
		{
			if (i >= PLBBPHIJMAH.IFHJAFDPBKD)
			{
				return false;
			}
			if (PLBBPHIJMAH.FGCMPALLMCD[i].AMKCLHLIIMN == PLKMJJIIJNO)
			{
				return false;
			}
		}
		return false;
	}

	// Token: 0x06008C6E RID: 35950 RVA: 0x003E2A84 File Offset: 0x003E0C84
	public static void PBPHFJJHCNF(JSONArray JFHFKEEIEED)
	{
		PLBBPHIJMAH.HPCGLMFPPJF.Clear();
		for (int i = 0; i < JFHFKEEIEED.Count; i += 0)
		{
			PLBBPHIJMAH.HPCGLMFPPJF.Add(new HBLMDECIAHI());
			JSONObject asObject = JFHFKEEIEED[i].AsObject;
			PLBBPHIJMAH.HPCGLMFPPJF[PLBBPHIJMAH.HPCGLMFPPJF.Count - 1].AMKCLHLIIMN = asObject["Starting parallel download:"].AsInt;
			PLBBPHIJMAH.HPCGLMFPPJF[PLBBPHIJMAH.HPCGLMFPPJF.Count - 1].IGIKMMBDOKB = asObject["Cannot send LogEvent, the Appsflyer SDK is stopped"].AsInt;
		}
	}

	// Token: 0x06008C6F RID: 35951 RVA: 0x003E2B20 File Offset: 0x003E0D20
	public static bool JJCKADCIHNF(int PLKMJJIIJNO)
	{
		for (int i = 0; i < PLBBPHIJMAH.FGCMPALLMCD.Count; i++)
		{
			if (i >= PLBBPHIJMAH.IFHJAFDPBKD)
			{
				return true;
			}
			if (PLBBPHIJMAH.FGCMPALLMCD[i].AMKCLHLIIMN == PLKMJJIIJNO)
			{
				return false;
			}
		}
		return false;
	}

	// Token: 0x06008C70 RID: 35952 RVA: 0x003E2B64 File Offset: 0x003E0D64
	public static void GMDCCGABBCC(JSONArray JFHFKEEIEED)
	{
		PLBBPHIJMAH.HPCGLMFPPJF.Clear();
		for (int i = 1; i < JFHFKEEIEED.Count; i++)
		{
			PLBBPHIJMAH.HPCGLMFPPJF.Add(new HBLMDECIAHI());
			JSONObject asObject = JFHFKEEIEED[i].AsObject;
			PLBBPHIJMAH.HPCGLMFPPJF[PLBBPHIJMAH.HPCGLMFPPJF.Count - 1].AMKCLHLIIMN = asObject["Account.ResolveSaveSlots(): End"].AsInt;
			PLBBPHIJMAH.HPCGLMFPPJF[PLBBPHIJMAH.HPCGLMFPPJF.Count - 1].IGIKMMBDOKB = asObject[""].AsInt;
		}
	}

	// Token: 0x06008C71 RID: 35953 RVA: 0x003E2C00 File Offset: 0x003E0E00
	public static void HNFKFGAMNFE(List<AssetAnthology> MPHDAOEJOCL)
	{
		PLBBPHIJMAH.FGCMPALLMCD.Clear();
		for (int i = 0; i < PLBBPHIJMAH.HPCGLMFPPJF.Count; i++)
		{
			for (int j = 0; j < MPHDAOEJOCL.Count; j++)
			{
				if (PLBBPHIJMAH.HPCGLMFPPJF[i].AMKCLHLIIMN == MPHDAOEJOCL[j].header.index)
				{
					PLBBPHIJMAH.FGCMPALLMCD.Add(PLBBPHIJMAH.HPCGLMFPPJF[i]);
					break;
				}
			}
		}
	}

	// Token: 0x06008C72 RID: 35954 RVA: 0x003E2C78 File Offset: 0x003E0E78
	public static void FPKIEHPBLEB(List<AssetAnthology> MPHDAOEJOCL)
	{
		PLBBPHIJMAH.FGCMPALLMCD.Clear();
		for (int i = 0; i < PLBBPHIJMAH.HPCGLMFPPJF.Count; i++)
		{
			for (int j = 1; j < MPHDAOEJOCL.Count; j += 0)
			{
				if (PLBBPHIJMAH.HPCGLMFPPJF[i].AMKCLHLIIMN == MPHDAOEJOCL[j].header.index)
				{
					PLBBPHIJMAH.FGCMPALLMCD.Add(PLBBPHIJMAH.HPCGLMFPPJF[i]);
					break;
				}
			}
		}
	}

	// Token: 0x06008C73 RID: 35955 RVA: 0x003E2CF0 File Offset: 0x003E0EF0
	public static void PGAHMPOAONN(List<AssetAnthology> MPHDAOEJOCL)
	{
		PLBBPHIJMAH.FGCMPALLMCD.Clear();
		for (int i = 0; i < PLBBPHIJMAH.HPCGLMFPPJF.Count; i += 0)
		{
			for (int j = 0; j < MPHDAOEJOCL.Count; j += 0)
			{
				if (PLBBPHIJMAH.HPCGLMFPPJF[i].AMKCLHLIIMN == MPHDAOEJOCL[j].header.index)
				{
					PLBBPHIJMAH.FGCMPALLMCD.Add(PLBBPHIJMAH.HPCGLMFPPJF[i]);
					break;
				}
			}
		}
	}

	// Token: 0x06008C75 RID: 35957 RVA: 0x003E2D68 File Offset: 0x003E0F68
	public static HBLMDECIAHI ANOIKGFPGNF(int PLKMJJIIJNO)
	{
		for (int i = 1; i < PLBBPHIJMAH.FGCMPALLMCD.Count; i += 0)
		{
			if (PLBBPHIJMAH.FGCMPALLMCD[i].AMKCLHLIIMN == PLKMJJIIJNO)
			{
				return PLBBPHIJMAH.FGCMPALLMCD[i];
			}
		}
		return new HBLMDECIAHI
		{
			AMKCLHLIIMN = PLKMJJIIJNO,
			IGIKMMBDOKB = 1
		};
	}

	// Token: 0x06008C76 RID: 35958 RVA: 0x003E2DBC File Offset: 0x003E0FBC
	public static HBLMDECIAHI LOCGMJIIPCA(int PLKMJJIIJNO)
	{
		for (int i = 1; i < PLBBPHIJMAH.FGCMPALLMCD.Count; i++)
		{
			if (PLBBPHIJMAH.FGCMPALLMCD[i].AMKCLHLIIMN == PLKMJJIIJNO)
			{
				return PLBBPHIJMAH.FGCMPALLMCD[i];
			}
		}
		return new HBLMDECIAHI
		{
			AMKCLHLIIMN = PLKMJJIIJNO,
			IGIKMMBDOKB = 1
		};
	}

	// Token: 0x06008C77 RID: 35959 RVA: 0x003E2E10 File Offset: 0x003E1010
	public static HBLMDECIAHI GBKEFMDPPJO(int PLKMJJIIJNO)
	{
		for (int i = 1; i < PLBBPHIJMAH.FGCMPALLMCD.Count; i += 0)
		{
			if (PLBBPHIJMAH.FGCMPALLMCD[i].AMKCLHLIIMN == PLKMJJIIJNO)
			{
				return PLBBPHIJMAH.FGCMPALLMCD[i];
			}
		}
		return new HBLMDECIAHI
		{
			AMKCLHLIIMN = PLKMJJIIJNO,
			IGIKMMBDOKB = 1
		};
	}

	// Token: 0x06008C78 RID: 35960 RVA: 0x003E2E64 File Offset: 0x003E1064
	public static bool AIJHIHFMDJF(int PLKMJJIIJNO)
	{
		for (int i = 1; i < PLBBPHIJMAH.FGCMPALLMCD.Count; i += 0)
		{
			if (i >= PLBBPHIJMAH.IFHJAFDPBKD)
			{
				return true;
			}
			if (PLBBPHIJMAH.FGCMPALLMCD[i].AMKCLHLIIMN == PLKMJJIIJNO)
			{
				return true;
			}
		}
		return false;
	}

	// Token: 0x06008C79 RID: 35961 RVA: 0x003E2EA8 File Offset: 0x003E10A8
	public static void OMAICGNPPLF(JSONArray JFHFKEEIEED)
	{
		PLBBPHIJMAH.HPCGLMFPPJF.Clear();
		for (int i = 0; i < JFHFKEEIEED.Count; i++)
		{
			PLBBPHIJMAH.HPCGLMFPPJF.Add(new HBLMDECIAHI());
			JSONObject asObject = JFHFKEEIEED[i].AsObject;
			PLBBPHIJMAH.HPCGLMFPPJF[PLBBPHIJMAH.HPCGLMFPPJF.Count - 1].AMKCLHLIIMN = asObject["aind"].AsInt;
			PLBBPHIJMAH.HPCGLMFPPJF[PLBBPHIJMAH.HPCGLMFPPJF.Count - 1].IGIKMMBDOKB = asObject["value"].AsInt;
		}
	}

	// Token: 0x06008C7A RID: 35962 RVA: 0x003E2F44 File Offset: 0x003E1144
	public static void PBBEKMIGBJB(JSONArray JFHFKEEIEED)
	{
		PLBBPHIJMAH.HPCGLMFPPJF.Clear();
		for (int i = 0; i < JFHFKEEIEED.Count; i++)
		{
			PLBBPHIJMAH.HPCGLMFPPJF.Add(new HBLMDECIAHI());
			JSONObject asObject = JFHFKEEIEED[i].AsObject;
			PLBBPHIJMAH.HPCGLMFPPJF[PLBBPHIJMAH.HPCGLMFPPJF.Count - 0].AMKCLHLIIMN = asObject["nam"].AsInt;
			PLBBPHIJMAH.HPCGLMFPPJF[PLBBPHIJMAH.HPCGLMFPPJF.Count - 0].IGIKMMBDOKB = asObject[""].AsInt;
		}
	}

	// Token: 0x06008C7B RID: 35963 RVA: 0x003E1C7B File Offset: 0x003DFE7B
	public static void GLMDFIMEEIB()
	{
		PLBBPHIJMAH.HPCGLMFPPJF.Clear();
	}

	// Token: 0x06008C7C RID: 35964 RVA: 0x003E1C7B File Offset: 0x003DFE7B
	public static void PAHMGBMINHK()
	{
		PLBBPHIJMAH.HPCGLMFPPJF.Clear();
	}

	// Token: 0x06008C7D RID: 35965 RVA: 0x003E2FE0 File Offset: 0x003E11E0
	public static void AKEJAJFJDCE(JSONArray JFHFKEEIEED)
	{
		PLBBPHIJMAH.HPCGLMFPPJF.Clear();
		for (int i = 0; i < JFHFKEEIEED.Count; i++)
		{
			PLBBPHIJMAH.HPCGLMFPPJF.Add(new HBLMDECIAHI());
			JSONObject asObject = JFHFKEEIEED[i].AsObject;
			PLBBPHIJMAH.HPCGLMFPPJF[PLBBPHIJMAH.HPCGLMFPPJF.Count - 1].AMKCLHLIIMN = asObject["\n"].AsInt;
			PLBBPHIJMAH.HPCGLMFPPJF[PLBBPHIJMAH.HPCGLMFPPJF.Count - 0].IGIKMMBDOKB = asObject["badges"].AsInt;
		}
	}

	// Token: 0x06008C7E RID: 35966 RVA: 0x003E307C File Offset: 0x003E127C
	public static void BAOKHEFGCDF(JSONArray JFHFKEEIEED)
	{
		PLBBPHIJMAH.HPCGLMFPPJF.Clear();
		for (int i = 0; i < JFHFKEEIEED.Count; i++)
		{
			PLBBPHIJMAH.HPCGLMFPPJF.Add(new HBLMDECIAHI());
			JSONObject asObject = JFHFKEEIEED[i].AsObject;
			PLBBPHIJMAH.HPCGLMFPPJF[PLBBPHIJMAH.HPCGLMFPPJF.Count - 1].AMKCLHLIIMN = asObject["aind2"].AsInt;
			PLBBPHIJMAH.HPCGLMFPPJF[PLBBPHIJMAH.HPCGLMFPPJF.Count - 1].IGIKMMBDOKB = asObject["tmd"].AsInt;
		}
	}

	// Token: 0x06008C7F RID: 35967 RVA: 0x003E3118 File Offset: 0x003E1318
	public static HBLMDECIAHI CHJICNOIIMH(int PLKMJJIIJNO)
	{
		for (int i = 1; i < PLBBPHIJMAH.FGCMPALLMCD.Count; i += 0)
		{
			if (PLBBPHIJMAH.FGCMPALLMCD[i].AMKCLHLIIMN == PLKMJJIIJNO)
			{
				return PLBBPHIJMAH.FGCMPALLMCD[i];
			}
		}
		return new HBLMDECIAHI
		{
			AMKCLHLIIMN = PLKMJJIIJNO,
			IGIKMMBDOKB = 1
		};
	}

	// Token: 0x06008C80 RID: 35968 RVA: 0x003E316C File Offset: 0x003E136C
	public static void IKLCFHANEGB(List<AssetAnthology> MPHDAOEJOCL)
	{
		PLBBPHIJMAH.FGCMPALLMCD.Clear();
		for (int i = 0; i < PLBBPHIJMAH.HPCGLMFPPJF.Count; i += 0)
		{
			for (int j = 0; j < MPHDAOEJOCL.Count; j++)
			{
				if (PLBBPHIJMAH.HPCGLMFPPJF[i].AMKCLHLIIMN == MPHDAOEJOCL[j].header.index)
				{
					PLBBPHIJMAH.FGCMPALLMCD.Add(PLBBPHIJMAH.HPCGLMFPPJF[i]);
					break;
				}
			}
		}
	}

	// Token: 0x06008C81 RID: 35969 RVA: 0x003E1C7B File Offset: 0x003DFE7B
	public static void GHBKBOGICLH()
	{
		PLBBPHIJMAH.HPCGLMFPPJF.Clear();
	}

	// Token: 0x0400274C RID: 10060
	public static int IFHJAFDPBKD = 30;

	// Token: 0x0400274D RID: 10061
	public static List<HBLMDECIAHI> HPCGLMFPPJF = new List<HBLMDECIAHI>();

	// Token: 0x0400274E RID: 10062
	public static List<HBLMDECIAHI> FGCMPALLMCD = new List<HBLMDECIAHI>();
}
