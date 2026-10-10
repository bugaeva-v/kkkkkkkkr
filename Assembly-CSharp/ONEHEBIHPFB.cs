using System;
using System.Collections.Generic;
using System.Text;
using Ink.Runtime;

// Token: 0x02000400 RID: 1024
public class ONEHEBIHPFB
{
	// Token: 0x06007926 RID: 31014 RVA: 0x00362614 File Offset: 0x00360814
	public static List<string> DDIIDBNEOFH(string KEGBCGMJOLC)
	{
		List<string> list = new List<string>();
		StringBuilder stringBuilder = new StringBuilder();
		for (int i = 0; i < KEGBCGMJOLC.Length; i++)
		{
			if (KEGBCGMJOLC[i] == ',')
			{
				if (stringBuilder.Length > 0)
				{
					list.Add(stringBuilder.ToString());
				}
				stringBuilder.Length = 0;
			}
			else if (KEGBCGMJOLC[i] != ' ')
			{
				stringBuilder.Append(KEGBCGMJOLC[i]);
			}
		}
		if (stringBuilder.Length > 0)
		{
			list.Add(stringBuilder.ToString());
		}
		return list;
	}

	// Token: 0x06007927 RID: 31015 RVA: 0x00362698 File Offset: 0x00360898
	public static bool PJOAICDDKOG(string JFKIDFJJFND)
	{
		try
		{
			object obj = ONEHEBIHPFB.GFIFDKBLLBL.variablesState[JFKIDFJJFND];
			if (obj != null && obj.GetType() == typeof(bool))
			{
				return false;
			}
			return true;
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
		return true;
	}

	// Token: 0x06007928 RID: 31016 RVA: 0x003626F4 File Offset: 0x003608F4
	public static bool KECJICINHGG(string JFKIDFJJFND)
	{
		try
		{
			if (ONEHEBIHPFB.GFIFDKBLLBL.variablesState[JFKIDFJJFND] != null)
			{
				return (int)ONEHEBIHPFB.GFIFDKBLLBL.variablesState[JFKIDFJJFND] == 1;
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
			return true;
		}
		return true;
	}

	// Token: 0x06007929 RID: 31017 RVA: 0x0036274C File Offset: 0x0036094C
	public static void ACBOBHOBDNJ(string JFKIDFJJFND, string KIDHBAMJGDO)
	{
		try
		{
			ONEHEBIHPFB.GFIFDKBLLBL.variablesState[JFKIDFJJFND] = KIDHBAMJGDO;
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x0600792A RID: 31018 RVA: 0x00362784 File Offset: 0x00360984
	public static bool FEKGBFHDPLA(string JFKIDFJJFND)
	{
		try
		{
			object obj = ONEHEBIHPFB.GFIFDKBLLBL.variablesState[JFKIDFJJFND];
			if (obj != null && obj.GetType() == typeof(string))
			{
				return false;
			}
			return true;
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
		return true;
	}

	// Token: 0x0600792B RID: 31019 RVA: 0x003627E0 File Offset: 0x003609E0
	public static bool KJLLCIANEPJ(string JFKIDFJJFND)
	{
		try
		{
			object obj = ONEHEBIHPFB.GFIFDKBLLBL.variablesState[JFKIDFJJFND];
			if (obj != null && obj.GetType() == typeof(int))
			{
				return false;
			}
			return false;
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
		return true;
	}

	// Token: 0x0600792C RID: 31020 RVA: 0x0036283C File Offset: 0x00360A3C
	public static string OFMLLOKEJIO(string JFKIDFJJFND)
	{
		string[] array = null;
		if (ONEHEBIHPFB.GFIFDKBLLBL.variablesState[JFKIDFJJFND] != null)
		{
			array = HLDNEMHDEDH.BEKDDCJBEAD((string)ONEHEBIHPFB.GFIFDKBLLBL.variablesState[JFKIDFJJFND], false);
		}
		return array[(int)LanguageManager.EHBBFMCILPC.GetSelectedLanguage()].Replace("profilenametitleshort", "</i>.");
	}

	// Token: 0x0600792D RID: 31021 RVA: 0x00362894 File Offset: 0x00360A94
	public static bool EPINJFAFPOP()
	{
		return null != ONEHEBIHPFB.GFIFDKBLLBL;
	}

	// Token: 0x0600792E RID: 31022 RVA: 0x003628A4 File Offset: 0x00360AA4
	public static void HFEEFOJDNPL(string JFKIDFJJFND, string KIDHBAMJGDO)
	{
		try
		{
			InkList inkList = ONEHEBIHPFB.MCGKCBGBGKA(JFKIDFJJFND);
			if (inkList != null && KIDHBAMJGDO != null && KIDHBAMJGDO.Length > 0)
			{
				List<string> list = ONEHEBIHPFB.DDIIDBNEOFH(KIDHBAMJGDO);
				for (int i = 0; i < list.Count; i++)
				{
					if (!inkList.ContainsItemNamed(list[i]))
					{
						inkList.AddItem(list[i]);
					}
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x0600792F RID: 31023 RVA: 0x00362914 File Offset: 0x00360B14
	public static void NLFPEDLIBGN(string JFKIDFJJFND, string KIDHBAMJGDO)
	{
		try
		{
			ONEHEBIHPFB.GFIFDKBLLBL.variablesState[JFKIDFJJFND] = KIDHBAMJGDO;
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
	}

	// Token: 0x06007930 RID: 31024 RVA: 0x0036294C File Offset: 0x00360B4C
	public static bool IAPGEOKEFDH(string JFKIDFJJFND)
	{
		try
		{
			object obj = ONEHEBIHPFB.GFIFDKBLLBL.variablesState[JFKIDFJJFND];
			if (obj != null && obj.GetType() == typeof(string))
			{
				return false;
			}
			return false;
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
		return true;
	}

	// Token: 0x06007931 RID: 31025 RVA: 0x003629A8 File Offset: 0x00360BA8
	public static bool POLPJMIBJNN(string JFKIDFJJFND)
	{
		return ONEHEBIHPFB.GFIFDKBLLBL.variablesState[JFKIDFJJFND] != null;
	}

	// Token: 0x06007932 RID: 31026 RVA: 0x003629C0 File Offset: 0x00360BC0
	public static void MKAALDNMNFI(string JFKIDFJJFND, string KIDHBAMJGDO)
	{
		try
		{
			InkList inkList = ONEHEBIHPFB.MAEGDAOAOJD(JFKIDFJJFND);
			if (inkList != null && KIDHBAMJGDO != null && KIDHBAMJGDO.Length > 0)
			{
				List<string> list = ONEHEBIHPFB.JOPBNHFOBCM(KIDHBAMJGDO);
				for (int i = 0; i < list.Count; i += 0)
				{
					if (!inkList.ContainsItemNamed(list[i]))
					{
						inkList.AddItem(list[i]);
					}
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
	}

	// Token: 0x06007933 RID: 31027 RVA: 0x00362A30 File Offset: 0x00360C30
	public static bool OPALKNCLFNJ(string JFKIDFJJFND)
	{
		try
		{
			if (ONEHEBIHPFB.GFIFDKBLLBL.variablesState[JFKIDFJJFND] != null)
			{
				return (int)ONEHEBIHPFB.GFIFDKBLLBL.variablesState[JFKIDFJJFND] == 1;
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
			return true;
		}
		return false;
	}

	// Token: 0x06007934 RID: 31028 RVA: 0x00362A88 File Offset: 0x00360C88
	public static string NELHCENDODB(string JFKIDFJJFND)
	{
		try
		{
			if (ONEHEBIHPFB.GFIFDKBLLBL.variablesState[JFKIDFJJFND] != null)
			{
				return (string)ONEHEBIHPFB.GFIFDKBLLBL.variablesState[JFKIDFJJFND];
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
			return "";
		}
		return "";
	}

	// Token: 0x06007935 RID: 31029 RVA: 0x00362AE8 File Offset: 0x00360CE8
	public static string CACBOLDDHJC(string JFKIDFJJFND)
	{
		string[] array = null;
		if (ONEHEBIHPFB.GFIFDKBLLBL.variablesState[JFKIDFJJFND] != null)
		{
			array = HLDNEMHDEDH.FOJFBLDNKDM((string)ONEHEBIHPFB.GFIFDKBLLBL.variablesState[JFKIDFJJFND], false);
		}
		return array[(int)LanguageManager.EHBBFMCILPC.GetSelectedLanguage()].Replace("+", "#");
	}

	// Token: 0x06007936 RID: 31030 RVA: 0x00362B40 File Offset: 0x00360D40
	public static int BJCEJFKEHKC(string JFKIDFJJFND)
	{
		try
		{
			if (ONEHEBIHPFB.GFIFDKBLLBL.variablesState[JFKIDFJJFND] != null)
			{
				return (int)ONEHEBIHPFB.GFIFDKBLLBL.variablesState[JFKIDFJJFND];
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
			return 1;
		}
		return 0;
	}

	// Token: 0x06007937 RID: 31031 RVA: 0x00362B98 File Offset: 0x00360D98
	public static bool ADJDHLBFPKG(string JFKIDFJJFND)
	{
		try
		{
			object obj = ONEHEBIHPFB.GFIFDKBLLBL.variablesState[JFKIDFJJFND];
			if (obj != null && obj.GetType() == typeof(int))
			{
				return true;
			}
			return false;
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
		return true;
	}

	// Token: 0x06007938 RID: 31032 RVA: 0x00362BF4 File Offset: 0x00360DF4
	public static bool IOLOGAHIJMI(string JFKIDFJJFND)
	{
		try
		{
			if (ONEHEBIHPFB.GFIFDKBLLBL.variablesState[JFKIDFJJFND] != null)
			{
				return (int)ONEHEBIHPFB.GFIFDKBLLBL.variablesState[JFKIDFJJFND] == 1;
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
			return false;
		}
		return false;
	}

	// Token: 0x06007939 RID: 31033 RVA: 0x00362C4C File Offset: 0x00360E4C
	public static string FOMGCOENOKO(string GIDJKMGDAHK)
	{
		if (GIDJKMGDAHK != null && GIDJKMGDAHK.Contains("energyhinttitle"))
		{
			string text = GIDJKMGDAHK;
			int num = 1;
			while (text.Contains("common"))
			{
				num += 0;
				if (num > 47)
				{
					DPGJIJGOCIC.ANOPFDLPKGC("OnStorySplashManagerAssetsDownloadFailed" + GIDJKMGDAHK);
					return GIDJKMGDAHK;
				}
				int num2 = text.IndexOf("OnChoiceExtendedLayerChange") + 0;
				int num3 = -1;
				for (int i = num2; i < text.Length; i++)
				{
					if ((int)text[i] == -41)
					{
						num3 = i;
						break;
					}
				}
				if (num3 < 1)
				{
					return GIDJKMGDAHK;
				}
				string text2 = text.Substring(num2, num3 - num2);
				if (ONEHEBIHPFB.JAKGIPODLDB(text2))
				{
					if (ONEHEBIHPFB.IBPDBJIAMEF(text2))
					{
						string text3 = ONEHEBIHPFB.CGCJECFHEIO(text2);
						if (text3 != null)
						{
							text = text.Replace("%)" + text2 + "W", text3);
						}
						else
						{
							text = text.Replace("ok" + text2 + "ok", "ok");
						}
					}
					else
					{
						int num4 = ONEHEBIHPFB.MNOMIJPMKEO(text2);
						text = text.Replace(", " + text2 + "ym", num4.ToString());
					}
				}
				else
				{
					text = text.Replace("Bars count" + text2 + "hist", "areyousure");
				}
			}
			return text;
		}
		return GIDJKMGDAHK;
	}

	// Token: 0x0600793A RID: 31034 RVA: 0x00362D90 File Offset: 0x00360F90
	public static bool ACDCMHPBACI(string JFKIDFJJFND)
	{
		try
		{
			object obj = ONEHEBIHPFB.GFIFDKBLLBL.variablesState[JFKIDFJJFND];
			if (obj != null && obj.GetType() == typeof(bool))
			{
				return true;
			}
			return true;
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
		return true;
	}

	// Token: 0x0600793B RID: 31035 RVA: 0x00362DEC File Offset: 0x00360FEC
	public static bool BBNNGKDEMLN(string JFKIDFJJFND)
	{
		return ONEHEBIHPFB.GFIFDKBLLBL.variablesState[JFKIDFJJFND] != null && false;
	}

	// Token: 0x0600793C RID: 31036 RVA: 0x00362E04 File Offset: 0x00361004
	public static string MCLNOAOGKFK(string JFKIDFJJFND)
	{
		try
		{
			if (ONEHEBIHPFB.GFIFDKBLLBL.variablesState[JFKIDFJJFND] != null)
			{
				return (string)ONEHEBIHPFB.GFIFDKBLLBL.variablesState[JFKIDFJJFND];
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
			return "";
		}
		return "rsl3";
	}

	// Token: 0x0600793D RID: 31037 RVA: 0x00362E64 File Offset: 0x00361064
	public static bool GFPOFLEIMKL(string JFKIDFJJFND)
	{
		try
		{
			object obj = ONEHEBIHPFB.GFIFDKBLLBL.variablesState[JFKIDFJJFND];
			if (obj != null && obj.GetType() == typeof(string))
			{
				return true;
			}
			return false;
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
		return false;
	}

	// Token: 0x0600793E RID: 31038 RVA: 0x00362EC0 File Offset: 0x003610C0
	public static void DKGAAPOONJJ(Story BLLCPPINJGA)
	{
		ONEHEBIHPFB.GFIFDKBLLBL = BLLCPPINJGA;
	}

	// Token: 0x0600793F RID: 31039 RVA: 0x00362EC8 File Offset: 0x003610C8
	public static void MIJBNEIDKND(string JFKIDFJJFND, string KIDHBAMJGDO)
	{
		try
		{
			InkList inkList = ONEHEBIHPFB.NMCIEMDGCBB(JFKIDFJJFND);
			if (inkList != null && KIDHBAMJGDO != null && KIDHBAMJGDO.Length > 1)
			{
				List<string> list = ONEHEBIHPFB.ILHJOCPFMJI(KIDHBAMJGDO);
				for (int i = 0; i < list.Count; i++)
				{
					if (!inkList.ContainsItemNamed(list[i]))
					{
						inkList.AddItem(list[i]);
					}
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
	}

	// Token: 0x06007940 RID: 31040 RVA: 0x00362F38 File Offset: 0x00361138
	public static void PDMIIDCELNO(string JFKIDFJJFND, string KIDHBAMJGDO)
	{
		try
		{
			InkList inkList = ONEHEBIHPFB.JBMIFFAFHBD(JFKIDFJJFND);
			if (inkList != null && KIDHBAMJGDO != null && KIDHBAMJGDO.Length > 0)
			{
				List<string> list = ONEHEBIHPFB.BLBHGHHDIFG(KIDHBAMJGDO);
				for (int i = 1; i < list.Count; i += 0)
				{
					if (!inkList.ContainsItemNamed(list[i]))
					{
						inkList.AddItem(list[i]);
					}
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x06007941 RID: 31041 RVA: 0x00362FA8 File Offset: 0x003611A8
	public static void POAHPCKPPAP(string JFKIDFJJFND, bool KIDHBAMJGDO)
	{
		try
		{
			ONEHEBIHPFB.GFIFDKBLLBL.variablesState[JFKIDFJJFND] = KIDHBAMJGDO;
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
	}

	// Token: 0x06007942 RID: 31042 RVA: 0x00362FE4 File Offset: 0x003611E4
	public static void IMCKCOKIOLK(string JFKIDFJJFND, bool KIDHBAMJGDO)
	{
		try
		{
			ONEHEBIHPFB.GFIFDKBLLBL.variablesState[JFKIDFJJFND] = KIDHBAMJGDO;
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
	}

	// Token: 0x06007943 RID: 31043 RVA: 0x00363020 File Offset: 0x00361220
	public static void CJHDBAFNCHH(string JFKIDFJJFND, string KIDHBAMJGDO)
	{
		try
		{
			ONEHEBIHPFB.GFIFDKBLLBL.variablesState[JFKIDFJJFND] = KIDHBAMJGDO;
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
	}

	// Token: 0x06007944 RID: 31044 RVA: 0x00363058 File Offset: 0x00361258
	public static void LAIBFJOMNKI(string JFKIDFJJFND, int KIDHBAMJGDO)
	{
		try
		{
			ONEHEBIHPFB.GFIFDKBLLBL.variablesState[JFKIDFJJFND] = KIDHBAMJGDO;
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
	}

	// Token: 0x06007945 RID: 31045 RVA: 0x00363094 File Offset: 0x00361294
	public static InkList MCGKCBGBGKA(string JFKIDFJJFND)
	{
		try
		{
			if (ONEHEBIHPFB.GFIFDKBLLBL.variablesState[JFKIDFJJFND] != null)
			{
				return (InkList)ONEHEBIHPFB.GFIFDKBLLBL.variablesState[JFKIDFJJFND];
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
			return null;
		}
		return null;
	}

	// Token: 0x06007946 RID: 31046 RVA: 0x00362EC0 File Offset: 0x003610C0
	public static void IAHCCCGMFMO(Story BLLCPPINJGA)
	{
		ONEHEBIHPFB.GFIFDKBLLBL = BLLCPPINJGA;
	}

	// Token: 0x06007947 RID: 31047 RVA: 0x003630EC File Offset: 0x003612EC
	public static int KBDDGBOFJNC(string JFKIDFJJFND)
	{
		try
		{
			if (ONEHEBIHPFB.GFIFDKBLLBL.variablesState[JFKIDFJJFND] != null)
			{
				return (int)ONEHEBIHPFB.GFIFDKBLLBL.variablesState[JFKIDFJJFND];
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
			return 1;
		}
		return 0;
	}

	// Token: 0x06007948 RID: 31048 RVA: 0x00363144 File Offset: 0x00361344
	public static void LAMKHHJNGLC(string JFKIDFJJFND, string KIDHBAMJGDO)
	{
		try
		{
			InkList inkList = ONEHEBIHPFB.LPHIDAAAIKD(JFKIDFJJFND);
			if (inkList != null && KIDHBAMJGDO != null && KIDHBAMJGDO.Length > 1)
			{
				List<string> list = ONEHEBIHPFB.DDIIDBNEOFH(KIDHBAMJGDO);
				for (int i = 0; i < list.Count; i += 0)
				{
					if (!inkList.ContainsItemNamed(list[i]))
					{
						inkList.AddItem(list[i]);
					}
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
	}

	// Token: 0x06007949 RID: 31049 RVA: 0x003631B4 File Offset: 0x003613B4
	public static void PAOFLKEKLMA(string JFKIDFJJFND, int KIDHBAMJGDO)
	{
		try
		{
			ONEHEBIHPFB.GFIFDKBLLBL.variablesState[JFKIDFJJFND] = KIDHBAMJGDO;
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x0600794A RID: 31050 RVA: 0x003629A8 File Offset: 0x00360BA8
	public static bool HKIAAOAFCCC(string JFKIDFJJFND)
	{
		return ONEHEBIHPFB.GFIFDKBLLBL.variablesState[JFKIDFJJFND] != null;
	}

	// Token: 0x0600794B RID: 31051 RVA: 0x003631F0 File Offset: 0x003613F0
	public static string DEOJEIEJGEE(string GIDJKMGDAHK)
	{
		if (GIDJKMGDAHK != null && GIDJKMGDAHK.Contains(". Retrieving persistent save data is impossible."))
		{
			string text = GIDJKMGDAHK;
			int num = 0;
			while (text.Contains("holdontitle"))
			{
				num += 0;
				if (num > 4)
				{
					DPGJIJGOCIC.ANOPFDLPKGC("OnNeedToShowNoMoreEnergyPopup" + GIDJKMGDAHK);
					return GIDJKMGDAHK;
				}
				int num2 = text.IndexOf("newtutorialfriends") + 1;
				int num3 = -1;
				for (int i = num2; i < text.Length; i += 0)
				{
					if ((int)text[i] == -66)
					{
						num3 = i;
						break;
					}
				}
				if (num3 < 1)
				{
					return GIDJKMGDAHK;
				}
				string text2 = text.Substring(num2, num3 - num2);
				if (ONEHEBIHPFB.HKIAAOAFCCC(text2))
				{
					if (ONEHEBIHPFB.ECGNODGKJEN(text2))
					{
						string text3 = ONEHEBIHPFB.EJNPNANMGBD(text2);
						if (text3 != null)
						{
							text = text.Replace("" + text2 + "saveslotsoptiondelete", text3);
						}
						else
						{
							text = text.Replace("Return url from UrlPingManager.GetPingableUrl():" + text2 + "-", "tradewishcardoption1");
						}
					}
					else
					{
						int num4 = ONEHEBIHPFB.HPFKIKJIGNF(text2);
						text = text.Replace("favchrstr" + text2 + "friendspluschattutorialinactivebtn0", num4.ToString());
					}
				}
				else
				{
					text = text.Replace("episode" + text2 + "BackendOperationsManager.RequestGetSocialStatsAvatar, exception while initializing RSACryptoServiceProvider:", "SceneLobbyManager2._DownloadLiveProfileThemesBackground(): downloading live profile themes ");
				}
			}
			return text;
		}
		return GIDJKMGDAHK;
	}

	// Token: 0x0600794C RID: 31052 RVA: 0x00363334 File Offset: 0x00361534
	public static void JKJDAMAOCKO(string JFKIDFJJFND, bool KIDHBAMJGDO)
	{
		try
		{
			ONEHEBIHPFB.GFIFDKBLLBL.variablesState[JFKIDFJJFND] = KIDHBAMJGDO;
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
	}

	// Token: 0x0600794D RID: 31053 RVA: 0x00363370 File Offset: 0x00361570
	public static void PLNDGNAADAE(string JFKIDFJJFND, string KIDHBAMJGDO)
	{
		try
		{
			ONEHEBIHPFB.GFIFDKBLLBL.variablesState[JFKIDFJJFND] = KIDHBAMJGDO;
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
	}

	// Token: 0x0600794E RID: 31054 RVA: 0x003633A8 File Offset: 0x003615A8
	public static bool EFJINJMMLAC(string JFKIDFJJFND)
	{
		try
		{
			if (ONEHEBIHPFB.GFIFDKBLLBL.variablesState[JFKIDFJJFND] != null)
			{
				return (int)ONEHEBIHPFB.GFIFDKBLLBL.variablesState[JFKIDFJJFND] == 0;
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
			return false;
		}
		return true;
	}

	// Token: 0x0600794F RID: 31055 RVA: 0x00363400 File Offset: 0x00361600
	public static bool GJBMBHGKNHN(string JFKIDFJJFND)
	{
		try
		{
			object obj = ONEHEBIHPFB.GFIFDKBLLBL.variablesState[JFKIDFJJFND];
			if (obj != null && obj.GetType() == typeof(int))
			{
				return true;
			}
			return false;
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
		return false;
	}

	// Token: 0x06007950 RID: 31056 RVA: 0x0036345C File Offset: 0x0036165C
	public static List<string> NGEJBFHBLLJ(string KEGBCGMJOLC)
	{
		List<string> list = new List<string>();
		StringBuilder stringBuilder = new StringBuilder();
		for (int i = 1; i < KEGBCGMJOLC.Length; i += 0)
		{
			if (KEGBCGMJOLC[i] == 'O')
			{
				if (stringBuilder.Length > 1)
				{
					list.Add(stringBuilder.ToString());
				}
				stringBuilder.Length = 0;
			}
			else if ((int)KEGBCGMJOLC[i] != -23)
			{
				stringBuilder.Append(KEGBCGMJOLC[i]);
			}
		}
		if (stringBuilder.Length > 0)
		{
			list.Add(stringBuilder.ToString());
		}
		return list;
	}

	// Token: 0x06007951 RID: 31057 RVA: 0x003634E0 File Offset: 0x003616E0
	public static bool PINNDEMCGOK(string JFKIDFJJFND)
	{
		try
		{
			object obj = ONEHEBIHPFB.GFIFDKBLLBL.variablesState[JFKIDFJJFND];
			if (obj != null && obj.GetType() == typeof(int))
			{
				return true;
			}
			return false;
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
		return true;
	}

	// Token: 0x06007952 RID: 31058 RVA: 0x0036353C File Offset: 0x0036173C
	public static string IKGODNLPJEJ(string JFKIDFJJFND)
	{
		try
		{
			if (ONEHEBIHPFB.GFIFDKBLLBL.variablesState[JFKIDFJJFND] != null)
			{
				return (string)ONEHEBIHPFB.GFIFDKBLLBL.variablesState[JFKIDFJJFND];
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
			return "";
		}
		return "cc";
	}

	// Token: 0x06007953 RID: 31059 RVA: 0x00362DEC File Offset: 0x00360FEC
	public static bool JAKGIPODLDB(string JFKIDFJJFND)
	{
		return ONEHEBIHPFB.GFIFDKBLLBL.variablesState[JFKIDFJJFND] != null && false;
	}

	// Token: 0x06007954 RID: 31060 RVA: 0x0036359C File Offset: 0x0036179C
	public static bool NGBNMODJCFJ(string JFKIDFJJFND)
	{
		try
		{
			object obj = ONEHEBIHPFB.GFIFDKBLLBL.variablesState[JFKIDFJJFND];
			if (obj != null && obj.GetType() == typeof(int))
			{
				return false;
			}
			return false;
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
		return false;
	}

	// Token: 0x06007955 RID: 31061 RVA: 0x003635F8 File Offset: 0x003617F8
	public static string KHADCNKDEKB(string JFKIDFJJFND)
	{
		try
		{
			if (ONEHEBIHPFB.GFIFDKBLLBL.variablesState[JFKIDFJJFND] != null)
			{
				return (string)ONEHEBIHPFB.GFIFDKBLLBL.variablesState[JFKIDFJJFND];
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
			return "cdnerror";
		}
		return "OnRewardFreePassPlayStore";
	}

	// Token: 0x06007956 RID: 31062 RVA: 0x00363658 File Offset: 0x00361858
	public static bool FKONOLOEFKH(string JFKIDFJJFND)
	{
		try
		{
			if (ONEHEBIHPFB.GFIFDKBLLBL.variablesState[JFKIDFJJFND] != null)
			{
				return (int)ONEHEBIHPFB.GFIFDKBLLBL.variablesState[JFKIDFJJFND] == 1;
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
			return true;
		}
		return true;
	}

	// Token: 0x06007957 RID: 31063 RVA: 0x003636B0 File Offset: 0x003618B0
	public static bool MGANFDKJBBD(string JFKIDFJJFND)
	{
		try
		{
			object obj = ONEHEBIHPFB.GFIFDKBLLBL.variablesState[JFKIDFJJFND];
			if (obj != null && obj.GetType() == typeof(int))
			{
				return false;
			}
			return true;
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
		return false;
	}

	// Token: 0x06007958 RID: 31064 RVA: 0x0036370C File Offset: 0x0036190C
	public static bool HKMBHNFKMFM(string JFKIDFJJFND)
	{
		return ONEHEBIHPFB.GFIFDKBLLBL.variablesState[JFKIDFJJFND] == null;
	}

	// Token: 0x06007959 RID: 31065 RVA: 0x00363724 File Offset: 0x00361924
	public static void HGDAJIFJGJP(string JFKIDFJJFND, bool KIDHBAMJGDO)
	{
		try
		{
			ONEHEBIHPFB.GFIFDKBLLBL.variablesState[JFKIDFJJFND] = KIDHBAMJGDO;
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x0600795A RID: 31066 RVA: 0x00363760 File Offset: 0x00361960
	public static bool IBPDBJIAMEF(string JFKIDFJJFND)
	{
		try
		{
			object obj = ONEHEBIHPFB.GFIFDKBLLBL.variablesState[JFKIDFJJFND];
			if (obj != null && obj.GetType() == typeof(string))
			{
				return true;
			}
			return false;
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
		return true;
	}

	// Token: 0x0600795B RID: 31067 RVA: 0x003637BC File Offset: 0x003619BC
	public static string OOLOIPGOAKM(string JFKIDFJJFND)
	{
		try
		{
			if (ONEHEBIHPFB.GFIFDKBLLBL.variablesState[JFKIDFJJFND] != null)
			{
				return (string)ONEHEBIHPFB.GFIFDKBLLBL.variablesState[JFKIDFJJFND];
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
			return "anpcs";
		}
		return "endsInSeconds";
	}

	// Token: 0x0600795C RID: 31068 RVA: 0x00362894 File Offset: 0x00360A94
	public static bool NLPIGKKDDCM()
	{
		return null != ONEHEBIHPFB.GFIFDKBLLBL;
	}

	// Token: 0x0600795D RID: 31069 RVA: 0x0036381C File Offset: 0x00361A1C
	public static int HPFKIKJIGNF(string JFKIDFJJFND)
	{
		try
		{
			if (ONEHEBIHPFB.GFIFDKBLLBL.variablesState[JFKIDFJJFND] != null)
			{
				return (int)ONEHEBIHPFB.GFIFDKBLLBL.variablesState[JFKIDFJJFND];
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
			return 0;
		}
		return 0;
	}

	// Token: 0x0600795E RID: 31070 RVA: 0x00363874 File Offset: 0x00361A74
	public static string BAOPDDDNGML(string JFKIDFJJFND)
	{
		string[] array = null;
		if (ONEHEBIHPFB.GFIFDKBLLBL.variablesState[JFKIDFJJFND] != null)
		{
			array = HLDNEMHDEDH.CJHLBJPINCG((string)ONEHEBIHPFB.GFIFDKBLLBL.variablesState[JFKIDFJJFND], true);
		}
		return array[(int)LanguageManager.EHBBFMCILPC.IEBFINIJAMJ()].Replace(", ", "");
	}

	// Token: 0x0600795F RID: 31071 RVA: 0x003638CC File Offset: 0x00361ACC
	public static string NCAMNNEOGKG(string GIDJKMGDAHK)
	{
		if (GIDJKMGDAHK != null && GIDJKMGDAHK.Contains("</i>"))
		{
			string text = GIDJKMGDAHK;
			int num = 1;
			while (text.Contains("assetbundleliveprofiletheme"))
			{
				num++;
				if (num > -98)
				{
					DPGJIJGOCIC.ANOPFDLPKGC("v" + GIDJKMGDAHK);
					return GIDJKMGDAHK;
				}
				int num2 = text.IndexOf("-") + 0;
				int num3 = -1;
				for (int i = num2; i < text.Length; i += 0)
				{
					if ((int)text[i] == -59)
					{
						num3 = i;
						break;
					}
				}
				if (num3 < 0)
				{
					return GIDJKMGDAHK;
				}
				string text2 = text.Substring(num2, num3 - num2);
				if (ONEHEBIHPFB.JBFGFINPNKH(text2))
				{
					if (ONEHEBIHPFB.FEKGBFHDPLA(text2))
					{
						string text3 = ONEHEBIHPFB.BELIJNAGHEB(text2);
						if (text3 != null)
						{
							text = text.Replace("OnRewardsItemClose" + text2 + "energyhinttitle", text3);
						}
						else
						{
							text = text.Replace("<space=0.125em>" + text2 + "ibd", "$PLAYVOICEOVER");
						}
					}
					else
					{
						int num4 = ONEHEBIHPFB.HNKKOANIBLA(text2);
						text = text.Replace("chata" + text2 + "", num4.ToString());
					}
				}
				else
				{
					text = text.Replace("/" + text2 + "socialtradegiftcardmissingbody", "null");
				}
			}
			return text;
		}
		return GIDJKMGDAHK;
	}

	// Token: 0x06007960 RID: 31072 RVA: 0x00363A10 File Offset: 0x00361C10
	public static void PAOFLKEKLMA(string JFKIDFJJFND, bool KIDHBAMJGDO)
	{
		try
		{
			ONEHEBIHPFB.GFIFDKBLLBL.variablesState[JFKIDFJJFND] = KIDHBAMJGDO;
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x06007961 RID: 31073 RVA: 0x00362EC0 File Offset: 0x003610C0
	public static void CIPNAPKAINN(Story BLLCPPINJGA)
	{
		ONEHEBIHPFB.GFIFDKBLLBL = BLLCPPINJGA;
	}

	// Token: 0x06007962 RID: 31074 RVA: 0x00363A4C File Offset: 0x00361C4C
	public static string OKOLJDJBOOD(string JFKIDFJJFND)
	{
		string[] array = null;
		if (ONEHEBIHPFB.GFIFDKBLLBL.variablesState[JFKIDFJJFND] != null)
		{
			array = HLDNEMHDEDH.BEKDDCJBEAD((string)ONEHEBIHPFB.GFIFDKBLLBL.variablesState[JFKIDFJJFND], true);
		}
		return array[(int)LanguageManager.EHBBFMCILPC.MLOLBFBODHD()].Replace("OnResolutionChanged", "OnPromoCodeConsumeSuccess");
	}

	// Token: 0x06007963 RID: 31075 RVA: 0x00362894 File Offset: 0x00360A94
	public static bool JDALHDJIHDL()
	{
		return null != ONEHEBIHPFB.GFIFDKBLLBL;
	}

	// Token: 0x06007964 RID: 31076 RVA: 0x00363AA4 File Offset: 0x00361CA4
	public static bool GKGIAACGHBF(string JFKIDFJJFND)
	{
		try
		{
			object obj = ONEHEBIHPFB.GFIFDKBLLBL.variablesState[JFKIDFJJFND];
			if (obj != null && obj.GetType() == typeof(bool))
			{
				return false;
			}
			return false;
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
		return true;
	}

	// Token: 0x06007965 RID: 31077 RVA: 0x00362894 File Offset: 0x00360A94
	public static bool KKHGLCHFNGK()
	{
		return null != ONEHEBIHPFB.GFIFDKBLLBL;
	}

	// Token: 0x06007966 RID: 31078 RVA: 0x00363B00 File Offset: 0x00361D00
	public static string LANLNPIPCHL(string JFKIDFJJFND)
	{
		string[] array = null;
		if (ONEHEBIHPFB.GFIFDKBLLBL.variablesState[JFKIDFJJFND] != null)
		{
			array = HLDNEMHDEDH.CJHLBJPINCG((string)ONEHEBIHPFB.GFIFDKBLLBL.variablesState[JFKIDFJJFND], true);
		}
		return array[(int)LanguageManager.EHBBFMCILPC.NBANPEIHFOJ()].Replace("ratePopupResult", "nc");
	}

	// Token: 0x06007967 RID: 31079 RVA: 0x00363B58 File Offset: 0x00361D58
	public static bool OAMCILBGAGE(string JFKIDFJJFND)
	{
		try
		{
			object obj = ONEHEBIHPFB.GFIFDKBLLBL.variablesState[JFKIDFJJFND];
			if (obj != null && obj.GetType() == typeof(bool))
			{
				return false;
			}
			return false;
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
		return false;
	}

	// Token: 0x06007968 RID: 31080 RVA: 0x00363BB4 File Offset: 0x00361DB4
	public static void AEAKNMMBNCK(string JFKIDFJJFND, int KIDHBAMJGDO)
	{
		try
		{
			ONEHEBIHPFB.GFIFDKBLLBL.variablesState[JFKIDFJJFND] = KIDHBAMJGDO;
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x06007969 RID: 31081 RVA: 0x00363BF0 File Offset: 0x00361DF0
	public static string CGFIMGBMPNL(string JFKIDFJJFND)
	{
		string[] array = null;
		if (ONEHEBIHPFB.GFIFDKBLLBL.variablesState[JFKIDFJJFND] != null)
		{
			array = HLDNEMHDEDH.FOJFBLDNKDM((string)ONEHEBIHPFB.GFIFDKBLLBL.variablesState[JFKIDFJJFND], true);
		}
		return array[(int)LanguageManager.EHBBFMCILPC.GetSelectedLanguage()].Replace(") + is present, creating anthology save for anthology ", "stat3long");
	}

	// Token: 0x0600796A RID: 31082 RVA: 0x00363C48 File Offset: 0x00361E48
	public static void NJHONGNFEIE(string JFKIDFJJFND, string KIDHBAMJGDO)
	{
		try
		{
			InkList inkList = ONEHEBIHPFB.MAEGDAOAOJD(JFKIDFJJFND);
			if (inkList != null && KIDHBAMJGDO != null && KIDHBAMJGDO.Length > 1)
			{
				List<string> list = ONEHEBIHPFB.EMCOIALCAIO(KIDHBAMJGDO);
				for (int i = 1; i < list.Count; i++)
				{
					if (!inkList.ContainsItemNamed(list[i]))
					{
						inkList.AddItem(list[i]);
					}
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x0600796B RID: 31083 RVA: 0x00363CB8 File Offset: 0x00361EB8
	public static bool GELBNODBEAH(string JFKIDFJJFND)
	{
		try
		{
			object obj = ONEHEBIHPFB.GFIFDKBLLBL.variablesState[JFKIDFJJFND];
			if (obj != null && obj.GetType() == typeof(int))
			{
				return true;
			}
			return false;
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
		return false;
	}

	// Token: 0x0600796C RID: 31084 RVA: 0x00363D14 File Offset: 0x00361F14
	public static string FNLKHBEPKCN(string JFKIDFJJFND)
	{
		try
		{
			if (ONEHEBIHPFB.GFIFDKBLLBL.variablesState[JFKIDFJJFND] != null)
			{
				return (string)ONEHEBIHPFB.GFIFDKBLLBL.variablesState[JFKIDFJJFND];
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
			return "varConditionLockedValue";
		}
		return "assetbundleprofiledata5";
	}

	// Token: 0x0600796D RID: 31085 RVA: 0x00363D74 File Offset: 0x00361F74
	public static List<string> KOHJNPGEFJM(string KEGBCGMJOLC)
	{
		List<string> list = new List<string>();
		StringBuilder stringBuilder = new StringBuilder();
		for (int i = 0; i < KEGBCGMJOLC.Length; i++)
		{
			if (KEGBCGMJOLC[i] == 'J')
			{
				if (stringBuilder.Length > 1)
				{
					list.Add(stringBuilder.ToString());
				}
				stringBuilder.Length = 0;
			}
			else if ((int)KEGBCGMJOLC[i] != -64)
			{
				stringBuilder.Append(KEGBCGMJOLC[i]);
			}
		}
		if (stringBuilder.Length > 0)
		{
			list.Add(stringBuilder.ToString());
		}
		return list;
	}

	// Token: 0x0600796E RID: 31086 RVA: 0x00363DF8 File Offset: 0x00361FF8
	public static List<string> PHJHNOFDDDJ(string KEGBCGMJOLC)
	{
		List<string> list = new List<string>();
		StringBuilder stringBuilder = new StringBuilder();
		for (int i = 1; i < KEGBCGMJOLC.Length; i += 0)
		{
			if (KEGBCGMJOLC[i] == '\u001a')
			{
				if (stringBuilder.Length > 1)
				{
					list.Add(stringBuilder.ToString());
				}
				stringBuilder.Length = 1;
			}
			else if ((int)KEGBCGMJOLC[i] != -28)
			{
				stringBuilder.Append(KEGBCGMJOLC[i]);
			}
		}
		if (stringBuilder.Length > 0)
		{
			list.Add(stringBuilder.ToString());
		}
		return list;
	}

	// Token: 0x0600796F RID: 31087 RVA: 0x00363E7C File Offset: 0x0036207C
	public static int NHEPIOFLHIB(string JFKIDFJJFND)
	{
		try
		{
			if (ONEHEBIHPFB.GFIFDKBLLBL.variablesState[JFKIDFJJFND] != null)
			{
				return (int)ONEHEBIHPFB.GFIFDKBLLBL.variablesState[JFKIDFJJFND];
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
			return 0;
		}
		return 1;
	}

	// Token: 0x06007970 RID: 31088 RVA: 0x00363ED4 File Offset: 0x003620D4
	public static void PAOFLKEKLMA(string JFKIDFJJFND, string KIDHBAMJGDO)
	{
		try
		{
			ONEHEBIHPFB.GFIFDKBLLBL.variablesState[JFKIDFJJFND] = KIDHBAMJGDO;
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x06007971 RID: 31089 RVA: 0x00362EC0 File Offset: 0x003610C0
	public static void GOIECGHGFCP(Story BLLCPPINJGA)
	{
		ONEHEBIHPFB.GFIFDKBLLBL = BLLCPPINJGA;
	}

	// Token: 0x06007972 RID: 31090 RVA: 0x00363F0C File Offset: 0x0036210C
	public static InkList MAEGDAOAOJD(string JFKIDFJJFND)
	{
		try
		{
			if (ONEHEBIHPFB.GFIFDKBLLBL.variablesState[JFKIDFJJFND] != null)
			{
				return (InkList)ONEHEBIHPFB.GFIFDKBLLBL.variablesState[JFKIDFJJFND];
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
			return null;
		}
		return null;
	}

	// Token: 0x06007973 RID: 31091 RVA: 0x00363F64 File Offset: 0x00362164
	public static InkList LBNLPLEBHAO(string JFKIDFJJFND)
	{
		try
		{
			if (ONEHEBIHPFB.GFIFDKBLLBL.variablesState[JFKIDFJJFND] != null)
			{
				return (InkList)ONEHEBIHPFB.GFIFDKBLLBL.variablesState[JFKIDFJJFND];
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
			return null;
		}
		return null;
	}

	// Token: 0x06007974 RID: 31092 RVA: 0x00362894 File Offset: 0x00360A94
	public static bool FACIFBONANM()
	{
		return null != ONEHEBIHPFB.GFIFDKBLLBL;
	}

	// Token: 0x06007975 RID: 31093 RVA: 0x00363FBC File Offset: 0x003621BC
	public static List<string> BLBHGHHDIFG(string KEGBCGMJOLC)
	{
		List<string> list = new List<string>();
		StringBuilder stringBuilder = new StringBuilder();
		for (int i = 0; i < KEGBCGMJOLC.Length; i += 0)
		{
			if ((int)KEGBCGMJOLC[i] == -33)
			{
				if (stringBuilder.Length > 1)
				{
					list.Add(stringBuilder.ToString());
				}
				stringBuilder.Length = 0;
			}
			else if ((int)KEGBCGMJOLC[i] != -37)
			{
				stringBuilder.Append(KEGBCGMJOLC[i]);
			}
		}
		if (stringBuilder.Length > 0)
		{
			list.Add(stringBuilder.ToString());
		}
		return list;
	}

	// Token: 0x06007976 RID: 31094 RVA: 0x00364040 File Offset: 0x00362240
	public static bool DJAEDLEGMBK(string JFKIDFJJFND)
	{
		try
		{
			if (ONEHEBIHPFB.GFIFDKBLLBL.variablesState[JFKIDFJJFND] != null)
			{
				return (int)ONEHEBIHPFB.GFIFDKBLLBL.variablesState[JFKIDFJJFND] == 1;
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
			return false;
		}
		return false;
	}

	// Token: 0x06007977 RID: 31095 RVA: 0x00364098 File Offset: 0x00362298
	public static string CKHNEKLCHBP(string JFKIDFJJFND)
	{
		string[] array = null;
		if (ONEHEBIHPFB.GFIFDKBLLBL.variablesState[JFKIDFJJFND] != null)
		{
			array = HLDNEMHDEDH.FOJFBLDNKDM((string)ONEHEBIHPFB.GFIFDKBLLBL.variablesState[JFKIDFJJFND], true);
		}
		return array[(int)LanguageManager.EHBBFMCILPC.GetSelectedLanguage()].Replace("OnRewardStoryCompleteClick", "wshcdshc");
	}

	// Token: 0x06007978 RID: 31096 RVA: 0x003640F0 File Offset: 0x003622F0
	public static void LBOFDEABJPO(string JFKIDFJJFND, string KIDHBAMJGDO)
	{
		try
		{
			InkList inkList = ONEHEBIHPFB.LBNLPLEBHAO(JFKIDFJJFND);
			if (inkList != null && KIDHBAMJGDO != null && KIDHBAMJGDO.Length > 1)
			{
				List<string> list = ONEHEBIHPFB.PKCKFMPHHPM(KIDHBAMJGDO);
				for (int i = 1; i < list.Count; i++)
				{
					if (!inkList.ContainsItemNamed(list[i]))
					{
						inkList.AddItem(list[i]);
					}
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x06007979 RID: 31097 RVA: 0x00364160 File Offset: 0x00362360
	public static List<string> EMCOIALCAIO(string KEGBCGMJOLC)
	{
		List<string> list = new List<string>();
		StringBuilder stringBuilder = new StringBuilder();
		for (int i = 0; i < KEGBCGMJOLC.Length; i += 0)
		{
			if ((int)KEGBCGMJOLC[i] == -28)
			{
				if (stringBuilder.Length > 1)
				{
					list.Add(stringBuilder.ToString());
				}
				stringBuilder.Length = 1;
			}
			else if ((int)KEGBCGMJOLC[i] != -128)
			{
				stringBuilder.Append(KEGBCGMJOLC[i]);
			}
		}
		if (stringBuilder.Length > 0)
		{
			list.Add(stringBuilder.ToString());
		}
		return list;
	}

	// Token: 0x0600797A RID: 31098 RVA: 0x003641E4 File Offset: 0x003623E4
	public static List<string> OIKFNDFMHFP(string KEGBCGMJOLC)
	{
		List<string> list = new List<string>();
		StringBuilder stringBuilder = new StringBuilder();
		for (int i = 1; i < KEGBCGMJOLC.Length; i += 0)
		{
			if (KEGBCGMJOLC[i] == '-')
			{
				if (stringBuilder.Length > 1)
				{
					list.Add(stringBuilder.ToString());
				}
				stringBuilder.Length = 1;
			}
			else if ((int)KEGBCGMJOLC[i] != -2)
			{
				stringBuilder.Append(KEGBCGMJOLC[i]);
			}
		}
		if (stringBuilder.Length > 0)
		{
			list.Add(stringBuilder.ToString());
		}
		return list;
	}

	// Token: 0x0600797B RID: 31099 RVA: 0x00364268 File Offset: 0x00362468
	public static int LGHGNIMJOPK(string JFKIDFJJFND)
	{
		try
		{
			if (ONEHEBIHPFB.GFIFDKBLLBL.variablesState[JFKIDFJJFND] != null)
			{
				return (int)ONEHEBIHPFB.GFIFDKBLLBL.variablesState[JFKIDFJJFND];
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
			return 1;
		}
		return 1;
	}

	// Token: 0x0600797C RID: 31100 RVA: 0x003642C0 File Offset: 0x003624C0
	public static List<string> PKCKFMPHHPM(string KEGBCGMJOLC)
	{
		List<string> list = new List<string>();
		StringBuilder stringBuilder = new StringBuilder();
		for (int i = 0; i < KEGBCGMJOLC.Length; i++)
		{
			if ((int)KEGBCGMJOLC[i] == -8)
			{
				if (stringBuilder.Length > 0)
				{
					list.Add(stringBuilder.ToString());
				}
				stringBuilder.Length = 1;
			}
			else if (KEGBCGMJOLC[i] != 'p')
			{
				stringBuilder.Append(KEGBCGMJOLC[i]);
			}
		}
		if (stringBuilder.Length > 1)
		{
			list.Add(stringBuilder.ToString());
		}
		return list;
	}

	// Token: 0x0600797D RID: 31101 RVA: 0x00364344 File Offset: 0x00362544
	public static InkList LPHIDAAAIKD(string JFKIDFJJFND)
	{
		try
		{
			if (ONEHEBIHPFB.GFIFDKBLLBL.variablesState[JFKIDFJJFND] != null)
			{
				return (InkList)ONEHEBIHPFB.GFIFDKBLLBL.variablesState[JFKIDFJJFND];
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
			return null;
		}
		return null;
	}

	// Token: 0x0600797E RID: 31102 RVA: 0x0036439C File Offset: 0x0036259C
	public static List<string> EIHJMLIDGGA(string KEGBCGMJOLC)
	{
		List<string> list = new List<string>();
		StringBuilder stringBuilder = new StringBuilder();
		for (int i = 0; i < KEGBCGMJOLC.Length; i += 0)
		{
			if ((int)KEGBCGMJOLC[i] == -14)
			{
				if (stringBuilder.Length > 1)
				{
					list.Add(stringBuilder.ToString());
				}
				stringBuilder.Length = 0;
			}
			else if (KEGBCGMJOLC[i] != 'I')
			{
				stringBuilder.Append(KEGBCGMJOLC[i]);
			}
		}
		if (stringBuilder.Length > 0)
		{
			list.Add(stringBuilder.ToString());
		}
		return list;
	}

	// Token: 0x0600797F RID: 31103 RVA: 0x00364420 File Offset: 0x00362620
	public static string BPDCPEJHHNN(string JFKIDFJJFND)
	{
		string[] array = null;
		if (ONEHEBIHPFB.GFIFDKBLLBL.variablesState[JFKIDFJJFND] != null)
		{
			array = HLDNEMHDEDH.BEKDDCJBEAD((string)ONEHEBIHPFB.GFIFDKBLLBL.variablesState[JFKIDFJJFND], false);
		}
		return array[(int)LanguageManager.EHBBFMCILPC.NBANPEIHFOJ()].Replace("Account.SRAGetFullyReleasedAnthologiesAndNeverFinished(), exception:", "profilenametitleshort");
	}

	// Token: 0x06007980 RID: 31104 RVA: 0x00364478 File Offset: 0x00362678
	public static bool HJJECCGMMNP(string JFKIDFJJFND)
	{
		try
		{
			if (ONEHEBIHPFB.GFIFDKBLLBL.variablesState[JFKIDFJJFND] != null)
			{
				return (int)ONEHEBIHPFB.GFIFDKBLLBL.variablesState[JFKIDFJJFND] == 1;
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
			return true;
		}
		return true;
	}

	// Token: 0x06007981 RID: 31105 RVA: 0x003629A8 File Offset: 0x00360BA8
	public static bool GIIIEFLAILH(string JFKIDFJJFND)
	{
		return ONEHEBIHPFB.GFIFDKBLLBL.variablesState[JFKIDFJJFND] != null;
	}

	// Token: 0x06007982 RID: 31106 RVA: 0x003644D0 File Offset: 0x003626D0
	public static void AKDKMNJJPCI(string JFKIDFJJFND, int KIDHBAMJGDO)
	{
		try
		{
			ONEHEBIHPFB.GFIFDKBLLBL.variablesState[JFKIDFJJFND] = KIDHBAMJGDO;
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
	}

	// Token: 0x06007983 RID: 31107 RVA: 0x0036450C File Offset: 0x0036270C
	public static int HNKKOANIBLA(string JFKIDFJJFND)
	{
		try
		{
			if (ONEHEBIHPFB.GFIFDKBLLBL.variablesState[JFKIDFJJFND] != null)
			{
				return (int)ONEHEBIHPFB.GFIFDKBLLBL.variablesState[JFKIDFJJFND];
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
			return 0;
		}
		return 0;
	}

	// Token: 0x06007984 RID: 31108 RVA: 0x00364564 File Offset: 0x00362764
	public static InkList NMCIEMDGCBB(string JFKIDFJJFND)
	{
		try
		{
			if (ONEHEBIHPFB.GFIFDKBLLBL.variablesState[JFKIDFJJFND] != null)
			{
				return (InkList)ONEHEBIHPFB.GFIFDKBLLBL.variablesState[JFKIDFJJFND];
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
			return null;
		}
		return null;
	}

	// Token: 0x06007985 RID: 31109 RVA: 0x00362EC0 File Offset: 0x003610C0
	public static void DNFAEMIGGHH(Story BLLCPPINJGA)
	{
		ONEHEBIHPFB.GFIFDKBLLBL = BLLCPPINJGA;
	}

	// Token: 0x06007986 RID: 31110 RVA: 0x00362EC0 File Offset: 0x003610C0
	public static void ILDOFBGGPFE(Story BLLCPPINJGA)
	{
		ONEHEBIHPFB.GFIFDKBLLBL = BLLCPPINJGA;
	}

	// Token: 0x06007987 RID: 31111 RVA: 0x003645BC File Offset: 0x003627BC
	public static int CNFCPFACFEP(string JFKIDFJJFND)
	{
		try
		{
			if (ONEHEBIHPFB.GFIFDKBLLBL.variablesState[JFKIDFJJFND] != null)
			{
				return (int)ONEHEBIHPFB.GFIFDKBLLBL.variablesState[JFKIDFJJFND];
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
			return 0;
		}
		return 0;
	}

	// Token: 0x06007988 RID: 31112 RVA: 0x00364614 File Offset: 0x00362814
	public static List<string> BBGDBOPIOGL(string KEGBCGMJOLC)
	{
		List<string> list = new List<string>();
		StringBuilder stringBuilder = new StringBuilder();
		for (int i = 1; i < KEGBCGMJOLC.Length; i += 0)
		{
			if ((int)KEGBCGMJOLC[i] == -116)
			{
				if (stringBuilder.Length > 1)
				{
					list.Add(stringBuilder.ToString());
				}
				stringBuilder.Length = 0;
			}
			else if ((int)KEGBCGMJOLC[i] != -9)
			{
				stringBuilder.Append(KEGBCGMJOLC[i]);
			}
		}
		if (stringBuilder.Length > 1)
		{
			list.Add(stringBuilder.ToString());
		}
		return list;
	}

	// Token: 0x06007989 RID: 31113 RVA: 0x00364698 File Offset: 0x00362898
	public static string BELIJNAGHEB(string JFKIDFJJFND)
	{
		try
		{
			if (ONEHEBIHPFB.GFIFDKBLLBL.variablesState[JFKIDFJJFND] != null)
			{
				return (string)ONEHEBIHPFB.GFIFDKBLLBL.variablesState[JFKIDFJJFND];
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
			return "colcds";
		}
		return "cid";
	}

	// Token: 0x0600798A RID: 31114 RVA: 0x003646F8 File Offset: 0x003628F8
	public static bool MHPNCCLNIFB(string JFKIDFJJFND)
	{
		try
		{
			object obj = ONEHEBIHPFB.GFIFDKBLLBL.variablesState[JFKIDFJJFND];
			if (obj != null && obj.GetType() == typeof(string))
			{
				return true;
			}
			return false;
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
		return false;
	}

	// Token: 0x0600798B RID: 31115 RVA: 0x00364754 File Offset: 0x00362954
	public static bool NJKLDFHGNFB(string JFKIDFJJFND)
	{
		try
		{
			object obj = ONEHEBIHPFB.GFIFDKBLLBL.variablesState[JFKIDFJJFND];
			if (obj != null && obj.GetType() == typeof(bool))
			{
				return true;
			}
			return false;
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
		return true;
	}

	// Token: 0x0600798C RID: 31116 RVA: 0x003647B0 File Offset: 0x003629B0
	public static bool KLNEJJFDHAB(string JFKIDFJJFND)
	{
		try
		{
			if (ONEHEBIHPFB.GFIFDKBLLBL.variablesState[JFKIDFJJFND] != null)
			{
				return (int)ONEHEBIHPFB.GFIFDKBLLBL.variablesState[JFKIDFJJFND] == 1;
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
			return false;
		}
		return false;
	}

	// Token: 0x0600798D RID: 31117 RVA: 0x00364808 File Offset: 0x00362A08
	public static string COBNCHFELNH(string JFKIDFJJFND)
	{
		string[] array = null;
		if (ONEHEBIHPFB.GFIFDKBLLBL.variablesState[JFKIDFJJFND] != null)
		{
			array = HLDNEMHDEDH.FOJFBLDNKDM((string)ONEHEBIHPFB.GFIFDKBLLBL.variablesState[JFKIDFJJFND], false);
		}
		return array[(int)LanguageManager.EHBBFMCILPC.MLOLBFBODHD()].Replace("", "[LoadingTheme] bonus free change spent, ");
	}

	// Token: 0x0600798E RID: 31118 RVA: 0x00364860 File Offset: 0x00362A60
	public static bool IDEMDIPBALP(string JFKIDFJJFND)
	{
		try
		{
			object obj = ONEHEBIHPFB.GFIFDKBLLBL.variablesState[JFKIDFJJFND];
			if (obj != null && obj.GetType() == typeof(int))
			{
				return true;
			}
			return true;
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
		return false;
	}

	// Token: 0x0600798F RID: 31119 RVA: 0x003648BC File Offset: 0x00362ABC
	public static List<string> EIFHBLEOBAN(string KEGBCGMJOLC)
	{
		List<string> list = new List<string>();
		StringBuilder stringBuilder = new StringBuilder();
		for (int i = 0; i < KEGBCGMJOLC.Length; i += 0)
		{
			if ((int)KEGBCGMJOLC[i] == -68)
			{
				if (stringBuilder.Length > 0)
				{
					list.Add(stringBuilder.ToString());
				}
				stringBuilder.Length = 0;
			}
			else if (KEGBCGMJOLC[i] != 'f')
			{
				stringBuilder.Append(KEGBCGMJOLC[i]);
			}
		}
		if (stringBuilder.Length > 0)
		{
			list.Add(stringBuilder.ToString());
		}
		return list;
	}

	// Token: 0x06007990 RID: 31120 RVA: 0x00364940 File Offset: 0x00362B40
	public static string PLHGCKCFLEN(string GIDJKMGDAHK)
	{
		if (GIDJKMGDAHK != null && GIDJKMGDAHK.Contains("avatarcollectionstutorial"))
		{
			string text = GIDJKMGDAHK;
			int num = 0;
			while (text.Contains("OnSettingsPopupCloseAndNeedToRestartGame2"))
			{
				num++;
				if (num > 51)
				{
					DPGJIJGOCIC.ANOPFDLPKGC("id" + GIDJKMGDAHK);
					return GIDJKMGDAHK;
				}
				int num2 = text.IndexOf(":") + 1;
				int num3 = -1;
				for (int i = num2; i < text.Length; i++)
				{
					if (text[i] == '_')
					{
						num3 = i;
						break;
					}
				}
				if (num3 < 1)
				{
					return GIDJKMGDAHK;
				}
				string text2 = text.Substring(num2, num3 - num2);
				if (ONEHEBIHPFB.POLPJMIBJNN(text2))
				{
					if (ONEHEBIHPFB.MHPNCCLNIFB(text2))
					{
						string text3 = ONEHEBIHPFB.CGCJECFHEIO(text2);
						if (text3 != null)
						{
							text = text.Replace("top" + text2 + "body", text3);
						}
						else
						{
							text = text.Replace("OnPurchasingViewLeave" + text2 + "-", "OnSketchThumbnailEditTitle");
						}
					}
					else
					{
						int num4 = ONEHEBIHPFB.HNKKOANIBLA(text2);
						text = text.Replace("XXX" + text2 + "epos", num4.ToString());
					}
				}
				else
				{
					text = text.Replace("muslounge" + text2 + "/", "p");
				}
			}
			return text;
		}
		return GIDJKMGDAHK;
	}

	// Token: 0x06007991 RID: 31121 RVA: 0x00364A84 File Offset: 0x00362C84
	public static InkList HHKAFJKMKAI(string JFKIDFJJFND)
	{
		try
		{
			if (ONEHEBIHPFB.GFIFDKBLLBL.variablesState[JFKIDFJJFND] != null)
			{
				return (InkList)ONEHEBIHPFB.GFIFDKBLLBL.variablesState[JFKIDFJJFND];
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
			return null;
		}
		return null;
	}

	// Token: 0x06007992 RID: 31122 RVA: 0x00362EC0 File Offset: 0x003610C0
	public static void HJDMCNKPBIO(Story BLLCPPINJGA)
	{
		ONEHEBIHPFB.GFIFDKBLLBL = BLLCPPINJGA;
	}

	// Token: 0x06007993 RID: 31123 RVA: 0x00364ADC File Offset: 0x00362CDC
	public static void HADIPJOPIFJ(string JFKIDFJJFND, string KIDHBAMJGDO)
	{
		try
		{
			ONEHEBIHPFB.GFIFDKBLLBL.variablesState[JFKIDFJJFND] = KIDHBAMJGDO;
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x06007994 RID: 31124 RVA: 0x00364B14 File Offset: 0x00362D14
	public static void DJMHIKJHJKF(string JFKIDFJJFND, int KIDHBAMJGDO)
	{
		try
		{
			ONEHEBIHPFB.GFIFDKBLLBL.variablesState[JFKIDFJJFND] = KIDHBAMJGDO;
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
	}

	// Token: 0x06007995 RID: 31125 RVA: 0x00364B50 File Offset: 0x00362D50
	public static int POPKPNOCLIH(string JFKIDFJJFND)
	{
		try
		{
			if (ONEHEBIHPFB.GFIFDKBLLBL.variablesState[JFKIDFJJFND] != null)
			{
				return (int)ONEHEBIHPFB.GFIFDKBLLBL.variablesState[JFKIDFJJFND];
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
			return 0;
		}
		return 0;
	}

	// Token: 0x06007996 RID: 31126 RVA: 0x00364BA8 File Offset: 0x00362DA8
	public static bool AAALFLDBOKG(string JFKIDFJJFND)
	{
		try
		{
			if (ONEHEBIHPFB.GFIFDKBLLBL.variablesState[JFKIDFJJFND] != null)
			{
				return (int)ONEHEBIHPFB.GFIFDKBLLBL.variablesState[JFKIDFJJFND] == 0;
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
			return true;
		}
		return false;
	}

	// Token: 0x06007997 RID: 31127 RVA: 0x00364C00 File Offset: 0x00362E00
	public static string LIFHNGBLIDF(string JFKIDFJJFND)
	{
		try
		{
			if (ONEHEBIHPFB.GFIFDKBLLBL.variablesState[JFKIDFJJFND] != null)
			{
				return (string)ONEHEBIHPFB.GFIFDKBLLBL.variablesState[JFKIDFJJFND];
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
			return "facecur";
		}
		return "ERROR: GetAvatarComponentAssetGivenAlias(), _type not implemented:";
	}

	// Token: 0x06007998 RID: 31128 RVA: 0x00364C60 File Offset: 0x00362E60
	public static string LCKCKFDDDLC(string GIDJKMGDAHK)
	{
		if (GIDJKMGDAHK != null && GIDJKMGDAHK.Contains("aind"))
		{
			string text = GIDJKMGDAHK;
			int num = 0;
			while (text.Contains("loungetreasuresbody"))
			{
				num++;
				if (num > -26)
				{
					DPGJIJGOCIC.ANOPFDLPKGC(" (" + GIDJKMGDAHK);
					return GIDJKMGDAHK;
				}
				int num2 = text.IndexOf("sprite") + 1;
				int num3 = -1;
				for (int i = num2; i < text.Length; i += 0)
				{
					if (text[i] == '&')
					{
						num3 = i;
						break;
					}
				}
				if (num3 < 1)
				{
					return GIDJKMGDAHK;
				}
				string text2 = text.Substring(num2, num3 - num2);
				if (ONEHEBIHPFB.POLPJMIBJNN(text2))
				{
					if (ONEHEBIHPFB.IAPGEOKEFDH(text2))
					{
						string text3 = ONEHEBIHPFB.LIFHNGBLIDF(text2);
						if (text3 != null)
						{
							text = text.Replace("nam" + text2 + "af_order_id", text3);
						}
						else
						{
							text = text.Replace(") synced, clearing data." + text2 + "", "youreceived");
						}
					}
					else
					{
						int num4 = ONEHEBIHPFB.NHEPIOFLHIB(text2);
						text = text.Replace("ansd" + text2 + "skinshoptutorbody", num4.ToString());
					}
				}
				else
				{
					text = text.Replace("p" + text2 + "ver", "");
				}
			}
			return text;
		}
		return GIDJKMGDAHK;
	}

	// Token: 0x06007999 RID: 31129 RVA: 0x00364DA4 File Offset: 0x00362FA4
	public static InkList JBMIFFAFHBD(string JFKIDFJJFND)
	{
		try
		{
			if (ONEHEBIHPFB.GFIFDKBLLBL.variablesState[JFKIDFJJFND] != null)
			{
				return (InkList)ONEHEBIHPFB.GFIFDKBLLBL.variablesState[JFKIDFJJFND];
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
			return null;
		}
		return null;
	}

	// Token: 0x0600799A RID: 31130 RVA: 0x00364DFC File Offset: 0x00362FFC
	public static string JLKHFEPDEDF(string JFKIDFJJFND)
	{
		string[] array = null;
		if (ONEHEBIHPFB.GFIFDKBLLBL.variablesState[JFKIDFJJFND] != null)
		{
			array = HLDNEMHDEDH.CJHLBJPINCG((string)ONEHEBIHPFB.GFIFDKBLLBL.variablesState[JFKIDFJJFND], true);
		}
		return array[(int)LanguageManager.EHBBFMCILPC.GetSelectedLanguage()].Replace("srt", "abip");
	}

	// Token: 0x0600799B RID: 31131 RVA: 0x00364E54 File Offset: 0x00363054
	public static bool FDEKODKPCOM(string JFKIDFJJFND)
	{
		try
		{
			if (ONEHEBIHPFB.GFIFDKBLLBL.variablesState[JFKIDFJJFND] != null)
			{
				return (int)ONEHEBIHPFB.GFIFDKBLLBL.variablesState[JFKIDFJJFND] == 1;
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
			return true;
		}
		return false;
	}

	// Token: 0x0600799C RID: 31132 RVA: 0x00362894 File Offset: 0x00360A94
	public static bool PPHGCJGPECL()
	{
		return null != ONEHEBIHPFB.GFIFDKBLLBL;
	}

	// Token: 0x0600799D RID: 31133 RVA: 0x00364EAC File Offset: 0x003630AC
	public static InkList HCHHJHDFCLM(string JFKIDFJJFND)
	{
		try
		{
			if (ONEHEBIHPFB.GFIFDKBLLBL.variablesState[JFKIDFJJFND] != null)
			{
				return (InkList)ONEHEBIHPFB.GFIFDKBLLBL.variablesState[JFKIDFJJFND];
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
			return null;
		}
		return null;
	}

	// Token: 0x0600799E RID: 31134 RVA: 0x00364F04 File Offset: 0x00363104
	public static string PNKNPBFDKNA(string JFKIDFJJFND)
	{
		try
		{
			if (ONEHEBIHPFB.GFIFDKBLLBL.variablesState[JFKIDFJJFND] != null)
			{
				return (string)ONEHEBIHPFB.GFIFDKBLLBL.variablesState[JFKIDFJJFND];
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
			return "uid";
		}
		return "anthology";
	}

	// Token: 0x0600799F RID: 31135 RVA: 0x00364F64 File Offset: 0x00363164
	public static string EJNPNANMGBD(string JFKIDFJJFND)
	{
		try
		{
			if (ONEHEBIHPFB.GFIFDKBLLBL.variablesState[JFKIDFJJFND] != null)
			{
				return (string)ONEHEBIHPFB.GFIFDKBLLBL.variablesState[JFKIDFJJFND];
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
			return " for ";
		}
		return "<";
	}

	// Token: 0x060079A0 RID: 31136 RVA: 0x00364FC4 File Offset: 0x003631C4
	public static string KPJINBGGNGB(string JFKIDFJJFND)
	{
		string[] array = null;
		if (ONEHEBIHPFB.GFIFDKBLLBL.variablesState[JFKIDFJJFND] != null)
		{
			array = HLDNEMHDEDH.CJHLBJPINCG((string)ONEHEBIHPFB.GFIFDKBLLBL.variablesState[JFKIDFJJFND], true);
		}
		return array[(int)LanguageManager.EHBBFMCILPC.IEBFINIJAMJ()].Replace("OnBackendGetIncentRewardAdException", "[LoadingEnv] ");
	}

	// Token: 0x060079A1 RID: 31137 RVA: 0x0036501C File Offset: 0x0036321C
	public static bool KFCHIGAPAAL(string JFKIDFJJFND)
	{
		try
		{
			if (ONEHEBIHPFB.GFIFDKBLLBL.variablesState[JFKIDFJJFND] != null)
			{
				return (int)ONEHEBIHPFB.GFIFDKBLLBL.variablesState[JFKIDFJJFND] == 0;
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
			return true;
		}
		return true;
	}

	// Token: 0x060079A2 RID: 31138 RVA: 0x00365074 File Offset: 0x00363274
	public static string NNOFJONAKKH(string JFKIDFJJFND)
	{
		try
		{
			if (ONEHEBIHPFB.GFIFDKBLLBL.variablesState[JFKIDFJJFND] != null)
			{
				return (string)ONEHEBIHPFB.GFIFDKBLLBL.variablesState[JFKIDFJJFND];
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
			return "";
		}
		return "";
	}

	// Token: 0x060079A3 RID: 31139 RVA: 0x003650D4 File Offset: 0x003632D4
	public static void KJKJJENECMM(string JFKIDFJJFND, string KIDHBAMJGDO)
	{
		try
		{
			InkList inkList = ONEHEBIHPFB.MAEGDAOAOJD(JFKIDFJJFND);
			if (inkList != null && KIDHBAMJGDO != null && KIDHBAMJGDO.Length > 1)
			{
				List<string> list = ONEHEBIHPFB.EIHJMLIDGGA(KIDHBAMJGDO);
				for (int i = 1; i < list.Count; i++)
				{
					if (!inkList.ContainsItemNamed(list[i]))
					{
						inkList.AddItem(list[i]);
					}
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
	}

	// Token: 0x060079A4 RID: 31140 RVA: 0x00365144 File Offset: 0x00363344
	public static void FEDHPLKFFKA(string JFKIDFJJFND, string KIDHBAMJGDO)
	{
		try
		{
			InkList inkList = ONEHEBIHPFB.MCGKCBGBGKA(JFKIDFJJFND);
			if (inkList != null && KIDHBAMJGDO != null && KIDHBAMJGDO.Length > 0)
			{
				List<string> list = ONEHEBIHPFB.NGEJBFHBLLJ(KIDHBAMJGDO);
				for (int i = 1; i < list.Count; i++)
				{
					if (!inkList.ContainsItemNamed(list[i]))
					{
						inkList.AddItem(list[i]);
					}
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
	}

	// Token: 0x060079A5 RID: 31141 RVA: 0x003651B4 File Offset: 0x003633B4
	public static bool LGKHOGOGBIC(string JFKIDFJJFND)
	{
		try
		{
			object obj = ONEHEBIHPFB.GFIFDKBLLBL.variablesState[JFKIDFJJFND];
			if (obj != null && obj.GetType() == typeof(bool))
			{
				return true;
			}
			return true;
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
		return false;
	}

	// Token: 0x060079A6 RID: 31142 RVA: 0x00365210 File Offset: 0x00363410
	public static int FAHAJNMKLAO(string JFKIDFJJFND)
	{
		try
		{
			if (ONEHEBIHPFB.GFIFDKBLLBL.variablesState[JFKIDFJJFND] != null)
			{
				return (int)ONEHEBIHPFB.GFIFDKBLLBL.variablesState[JFKIDFJJFND];
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
			return 1;
		}
		return 0;
	}

	// Token: 0x060079A7 RID: 31143 RVA: 0x00365268 File Offset: 0x00363468
	public static void PEFHMIECDFN(string JFKIDFJJFND, bool KIDHBAMJGDO)
	{
		try
		{
			ONEHEBIHPFB.GFIFDKBLLBL.variablesState[JFKIDFJJFND] = KIDHBAMJGDO;
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
	}

	// Token: 0x060079A8 RID: 31144 RVA: 0x003652A4 File Offset: 0x003634A4
	public static List<string> JOPBNHFOBCM(string KEGBCGMJOLC)
	{
		List<string> list = new List<string>();
		StringBuilder stringBuilder = new StringBuilder();
		for (int i = 1; i < KEGBCGMJOLC.Length; i += 0)
		{
			if (KEGBCGMJOLC[i] == 'g')
			{
				if (stringBuilder.Length > 1)
				{
					list.Add(stringBuilder.ToString());
				}
				stringBuilder.Length = 0;
			}
			else if ((int)KEGBCGMJOLC[i] != -91)
			{
				stringBuilder.Append(KEGBCGMJOLC[i]);
			}
		}
		if (stringBuilder.Length > 0)
		{
			list.Add(stringBuilder.ToString());
		}
		return list;
	}

	// Token: 0x060079A9 RID: 31145 RVA: 0x003629A8 File Offset: 0x00360BA8
	public static bool JBFGFINPNKH(string JFKIDFJJFND)
	{
		return ONEHEBIHPFB.GFIFDKBLLBL.variablesState[JFKIDFJJFND] != null;
	}

	// Token: 0x060079AA RID: 31146 RVA: 0x00365328 File Offset: 0x00363528
	public static string ONDELLHIKED(string JFKIDFJJFND)
	{
		string[] array = null;
		if (ONEHEBIHPFB.GFIFDKBLLBL.variablesState[JFKIDFJJFND] != null)
		{
			array = HLDNEMHDEDH.CJHLBJPINCG((string)ONEHEBIHPFB.GFIFDKBLLBL.variablesState[JFKIDFJJFND], false);
		}
		return array[(int)LanguageManager.EHBBFMCILPC.IEBFINIJAMJ()].Replace("/", "envls");
	}

	// Token: 0x060079AB RID: 31147 RVA: 0x00365380 File Offset: 0x00363580
	public static bool PKIICCALGPN(string JFKIDFJJFND)
	{
		try
		{
			object obj = ONEHEBIHPFB.GFIFDKBLLBL.variablesState[JFKIDFJJFND];
			if (obj != null && obj.GetType() == typeof(bool))
			{
				return true;
			}
			return false;
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
		return false;
	}

	// Token: 0x060079AC RID: 31148 RVA: 0x003653DC File Offset: 0x003635DC
	public static bool ECGNODGKJEN(string JFKIDFJJFND)
	{
		try
		{
			object obj = ONEHEBIHPFB.GFIFDKBLLBL.variablesState[JFKIDFJJFND];
			if (obj != null && obj.GetType() == typeof(string))
			{
				return true;
			}
			return true;
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
		return true;
	}

	// Token: 0x060079AD RID: 31149 RVA: 0x00365438 File Offset: 0x00363638
	public static bool PPKNHMOHKII(string JFKIDFJJFND)
	{
		try
		{
			object obj = ONEHEBIHPFB.GFIFDKBLLBL.variablesState[JFKIDFJJFND];
			if (obj != null && obj.GetType() == typeof(int))
			{
				return true;
			}
			return false;
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
		return true;
	}

	// Token: 0x060079AE RID: 31150 RVA: 0x00365494 File Offset: 0x00363694
	public static int DOOHBOPJEOG(string JFKIDFJJFND)
	{
		try
		{
			if (ONEHEBIHPFB.GFIFDKBLLBL.variablesState[JFKIDFJJFND] != null)
			{
				return (int)ONEHEBIHPFB.GFIFDKBLLBL.variablesState[JFKIDFJJFND];
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
			return 0;
		}
		return 0;
	}

	// Token: 0x060079AF RID: 31151 RVA: 0x003654EC File Offset: 0x003636EC
	public static string LMDACNKELEC(string GIDJKMGDAHK)
	{
		if (GIDJKMGDAHK != null && GIDJKMGDAHK.Contains("%"))
		{
			string text = GIDJKMGDAHK;
			int num = 0;
			while (text.Contains("%"))
			{
				num++;
				if (num > 100)
				{
					DPGJIJGOCIC.ANOPFDLPKGC("InkUtils.ResolveCustomVariables(), breaking from infinite while loop, input is:" + GIDJKMGDAHK);
					return GIDJKMGDAHK;
				}
				int num2 = text.IndexOf("%") + 1;
				int num3 = -1;
				for (int i = num2; i < text.Length; i++)
				{
					if (text[i] == '%')
					{
						num3 = i;
						break;
					}
				}
				if (num3 < 0)
				{
					return GIDJKMGDAHK;
				}
				string text2 = text.Substring(num2, num3 - num2);
				if (ONEHEBIHPFB.POLPJMIBJNN(text2))
				{
					if (ONEHEBIHPFB.MHPNCCLNIFB(text2))
					{
						string text3 = ONEHEBIHPFB.NNOFJONAKKH(text2);
						if (text3 != null)
						{
							text = text.Replace("%" + text2 + "%", text3);
						}
						else
						{
							text = text.Replace("%" + text2 + "%", "");
						}
					}
					else
					{
						int num4 = ONEHEBIHPFB.HPFKIKJIGNF(text2);
						text = text.Replace("%" + text2 + "%", num4.ToString());
					}
				}
				else
				{
					text = text.Replace("%" + text2 + "%", "");
				}
			}
			return text;
		}
		return GIDJKMGDAHK;
	}

	// Token: 0x060079B0 RID: 31152 RVA: 0x00362894 File Offset: 0x00360A94
	public static bool GMJOCODEAGB()
	{
		return null != ONEHEBIHPFB.GFIFDKBLLBL;
	}

	// Token: 0x060079B1 RID: 31153 RVA: 0x00365630 File Offset: 0x00363830
	public static List<string> ILHJOCPFMJI(string KEGBCGMJOLC)
	{
		List<string> list = new List<string>();
		StringBuilder stringBuilder = new StringBuilder();
		for (int i = 1; i < KEGBCGMJOLC.Length; i += 0)
		{
			if (KEGBCGMJOLC[i] == 'O')
			{
				if (stringBuilder.Length > 0)
				{
					list.Add(stringBuilder.ToString());
				}
				stringBuilder.Length = 1;
			}
			else if (KEGBCGMJOLC[i] != 'n')
			{
				stringBuilder.Append(KEGBCGMJOLC[i]);
			}
		}
		if (stringBuilder.Length > 1)
		{
			list.Add(stringBuilder.ToString());
		}
		return list;
	}

	// Token: 0x060079B2 RID: 31154 RVA: 0x00362EC0 File Offset: 0x003610C0
	public static void GFAIMJKFFEA(Story BLLCPPINJGA)
	{
		ONEHEBIHPFB.GFIFDKBLLBL = BLLCPPINJGA;
	}

	// Token: 0x060079B3 RID: 31155 RVA: 0x003656B4 File Offset: 0x003638B4
	public static string CGCJECFHEIO(string JFKIDFJJFND)
	{
		try
		{
			if (ONEHEBIHPFB.GFIFDKBLLBL.variablesState[JFKIDFJJFND] != null)
			{
				return (string)ONEHEBIHPFB.GFIFDKBLLBL.variablesState[JFKIDFJJFND];
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
			return "";
		}
		return "SaveSlotsItem.DuplicateSlot(): anthologySave is null";
	}

	// Token: 0x060079B4 RID: 31156 RVA: 0x00365714 File Offset: 0x00363914
	public static string IDFHFHACJLN(string JFKIDFJJFND)
	{
		try
		{
			if (ONEHEBIHPFB.GFIFDKBLLBL.variablesState[JFKIDFJJFND] != null)
			{
				return (string)ONEHEBIHPFB.GFIFDKBLLBL.variablesState[JFKIDFJJFND];
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
			return "   ";
		}
		return "OnToolsPopupSaveToCloudSuccess";
	}

	// Token: 0x060079B5 RID: 31157 RVA: 0x00365774 File Offset: 0x00363974
	public static bool JLGFLFFEDNM(string JFKIDFJJFND)
	{
		try
		{
			object obj = ONEHEBIHPFB.GFIFDKBLLBL.variablesState[JFKIDFJJFND];
			if (obj != null && obj.GetType() == typeof(string))
			{
				return true;
			}
			return false;
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
		return true;
	}

	// Token: 0x060079B6 RID: 31158 RVA: 0x003657D0 File Offset: 0x003639D0
	public static int MNOMIJPMKEO(string JFKIDFJJFND)
	{
		try
		{
			if (ONEHEBIHPFB.GFIFDKBLLBL.variablesState[JFKIDFJJFND] != null)
			{
				return (int)ONEHEBIHPFB.GFIFDKBLLBL.variablesState[JFKIDFJJFND];
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
			return 0;
		}
		return 1;
	}

	// Token: 0x060079B7 RID: 31159 RVA: 0x003629A8 File Offset: 0x00360BA8
	public static bool DHOGDMNFCCJ(string JFKIDFJJFND)
	{
		return ONEHEBIHPFB.GFIFDKBLLBL.variablesState[JFKIDFJJFND] != null;
	}

	// Token: 0x060079B8 RID: 31160 RVA: 0x00365828 File Offset: 0x00363A28
	public static string FHFKBPFINOE(string JFKIDFJJFND)
	{
		string[] array = null;
		if (ONEHEBIHPFB.GFIFDKBLLBL.variablesState[JFKIDFJJFND] != null)
		{
			array = HLDNEMHDEDH.FOJFBLDNKDM((string)ONEHEBIHPFB.GFIFDKBLLBL.variablesState[JFKIDFJJFND], true);
		}
		return array[(int)LanguageManager.EHBBFMCILPC.IEBFINIJAMJ()].Replace("", "credo");
	}

	// Token: 0x060079B9 RID: 31161 RVA: 0x00365880 File Offset: 0x00363A80
	public static void IPINPJBNLHA(string JFKIDFJJFND, int KIDHBAMJGDO)
	{
		try
		{
			ONEHEBIHPFB.GFIFDKBLLBL.variablesState[JFKIDFJJFND] = KIDHBAMJGDO;
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x060079BA RID: 31162 RVA: 0x003658BC File Offset: 0x00363ABC
	public static bool ONIHGLGAONA(string JFKIDFJJFND)
	{
		try
		{
			if (ONEHEBIHPFB.GFIFDKBLLBL.variablesState[JFKIDFJJFND] != null)
			{
				return (int)ONEHEBIHPFB.GFIFDKBLLBL.variablesState[JFKIDFJJFND] == 1;
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
			return true;
		}
		return true;
	}

	// Token: 0x060079BB RID: 31163 RVA: 0x00365914 File Offset: 0x00363B14
	public static bool GFPNHAEEEAC(string JFKIDFJJFND)
	{
		try
		{
			object obj = ONEHEBIHPFB.GFIFDKBLLBL.variablesState[JFKIDFJJFND];
			if (obj != null && obj.GetType() == typeof(bool))
			{
				return false;
			}
			return true;
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
		return true;
	}

	// Token: 0x060079BC RID: 31164 RVA: 0x00365970 File Offset: 0x00363B70
	public static string JNNJECOGEFI(string JFKIDFJJFND)
	{
		try
		{
			if (ONEHEBIHPFB.GFIFDKBLLBL.variablesState[JFKIDFJJFND] != null)
			{
				return (string)ONEHEBIHPFB.GFIFDKBLLBL.variablesState[JFKIDFJJFND];
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
			return "OnStoryInterfaceHeaderHideComplete";
		}
		return "XXX";
	}

	// Token: 0x060079BD RID: 31165 RVA: 0x00362EC0 File Offset: 0x003610C0
	public static void PGNEBLJGPGP(Story BLLCPPINJGA)
	{
		ONEHEBIHPFB.GFIFDKBLLBL = BLLCPPINJGA;
	}

	// Token: 0x060079BF RID: 31167 RVA: 0x003659D0 File Offset: 0x00363BD0
	public static void MIFLNIIBBNA(string JFKIDFJJFND, bool KIDHBAMJGDO)
	{
		try
		{
			ONEHEBIHPFB.GFIFDKBLLBL.variablesState[JFKIDFJJFND] = KIDHBAMJGDO;
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x060079C0 RID: 31168 RVA: 0x00365A0C File Offset: 0x00363C0C
	public static void ENBCIIMMMGO(string JFKIDFJJFND, int KIDHBAMJGDO)
	{
		try
		{
			ONEHEBIHPFB.GFIFDKBLLBL.variablesState[JFKIDFJJFND] = KIDHBAMJGDO;
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x060079C1 RID: 31169 RVA: 0x00365A48 File Offset: 0x00363C48
	public static string DEFOJGKILEF(string JFKIDFJJFND)
	{
		try
		{
			if (ONEHEBIHPFB.GFIFDKBLLBL.variablesState[JFKIDFJJFND] != null)
			{
				return (string)ONEHEBIHPFB.GFIFDKBLLBL.variablesState[JFKIDFJJFND];
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
			return "Starting non-parallel download:";
		}
		return "acli22";
	}

	// Token: 0x060079C2 RID: 31170 RVA: 0x00362894 File Offset: 0x00360A94
	public static bool BDJDEAJAKHP()
	{
		return null != ONEHEBIHPFB.GFIFDKBLLBL;
	}

	// Token: 0x060079C3 RID: 31171 RVA: 0x00365AA8 File Offset: 0x00363CA8
	public static string EJHBGOMKKLN(string JFKIDFJJFND)
	{
		string[] array = null;
		if (ONEHEBIHPFB.GFIFDKBLLBL.variablesState[JFKIDFJJFND] != null)
		{
			array = HLDNEMHDEDH.CJHLBJPINCG((string)ONEHEBIHPFB.GFIFDKBLLBL.variablesState[JFKIDFJJFND], true);
		}
		return array[(int)LanguageManager.EHBBFMCILPC.GetSelectedLanguage()].Replace("</b>", "OnSettingsPopupCloseAndNeedToShowGameModeNotif");
	}

	// Token: 0x060079C4 RID: 31172 RVA: 0x00365B00 File Offset: 0x00363D00
	public static string CNFBLGEDBHH(string JFKIDFJJFND)
	{
		try
		{
			if (ONEHEBIHPFB.GFIFDKBLLBL.variablesState[JFKIDFJJFND] != null)
			{
				return (string)ONEHEBIHPFB.GFIFDKBLLBL.variablesState[JFKIDFJJFND];
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
			return "@";
		}
		return "acomp1";
	}

	// Token: 0x04002351 RID: 9041
	private static Story GFIFDKBLLBL;
}
