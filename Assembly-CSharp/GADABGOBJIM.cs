using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

// Token: 0x02000298 RID: 664
public static class GADABGOBJIM
{
	// Token: 0x0600533A RID: 21306 RVA: 0x002488A6 File Offset: 0x00246AA6
	public static string JPMPIIIBIEN(int MEFKFOHCOHK)
	{
		if (!GADABGOBJIM.EEPGOBBIIHM(MEFKFOHCOHK))
		{
			return null;
		}
		return GADABGOBJIM.KHONHAFKADP[MEFKFOHCOHK];
	}

	// Token: 0x0600533B RID: 21307 RVA: 0x002488BC File Offset: 0x00246ABC
	private static bool MEFBNCLFNFL(string MLPEBEOHEGK, string AKMIBDDHADH)
	{
		int num = MLPEBEOHEGK.Length - AKMIBDDHADH.Length;
		if (2 != AKMIBDDHADH.Length || 'e' != AKMIBDDHADH[0] || 's' != AKMIBDDHADH[1])
		{
			return 1 != AKMIBDDHADH.Length || 's' != AKMIBDDHADH[0] || num < 1 || 's' != MLPEBEOHEGK[num - 1];
		}
		char c = MLPEBEOHEGK[num - 1];
		if ('x' == c || 'z' == c || 'o' == c)
		{
			return true;
		}
		if ('h' == c && num >= 2)
		{
			char c2 = MLPEBEOHEGK[num - 2];
			return 'c' == c2 || 's' == c2;
		}
		return false;
	}

	// Token: 0x0600533C RID: 21308 RVA: 0x00248960 File Offset: 0x00246B60
	private static Dictionary<char, string> GLLFLGBPEAE()
	{
		Dictionary<char, string> dictionary = new Dictionary<char, string>(200);
		try
		{
			string[] array = "a=ÀÁÂÃÄÅĀĂĄàáâãäåāăą;c=ÇĆĈĊČçćĉċč;d=ĎĐďđ;e=ÈÉÊËĒĔĖĘĚèéêëēĕėęě;g=ĜĞĠĢĝğġģ;h=ĤĦĥħ;i=ÌÍÎÏĨĪĬĮİìíîïĩīĭįı;j=Ĵĵ;k=Ķķ;l=ĹĻĽĿŁĺļľŀł;n=ÑŃŅŇñńņň;o=ÒÓÔÕÖØŌŎŐòóôõöøōŏő;r=ŔŖŘŕŗř;s=ŚŜŞŠȘśŝşšș;t=ŢŤŦȚţťŧț;u=ÙÚÛÜŨŪŬŮŰŲùúûüũūŭůűų;w=Ŵŵ;y=ÝŶŸýÿŷ;z=ŹŻŽźżž;ss=ß;ae=ÆæǢǣ;oe=Œœ;th=Þþ;ij=Ĳĳ;е=Ёё;и=ІіЇї;е=Єє;г=Ґґ;psi=Ψψ".Split(';', StringSplitOptions.None);
			for (int i = 0; i < array.Length; i++)
			{
				int num = array[i].IndexOf('=');
				if (num > 0)
				{
					string value = array[i].Substring(0, num);
					string text = array[i].Substring(num + 1);
					for (int j = 0; j < text.Length; j++)
					{
						dictionary[text[j]] = value;
					}
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
		return dictionary;
	}

	// Token: 0x0600533D RID: 21309 RVA: 0x00248A00 File Offset: 0x00246C00
	public static bool MINONHBBPFA(char ONPHDBKMBBH)
	{
		return '-' == ONPHDBKMBBH || '‐' == ONPHDBKMBBH || '‑' == ONPHDBKMBBH || '‒' == ONPHDBKMBBH || '–' == ONPHDBKMBBH || '—' == ONPHDBKMBBH;
	}

	// Token: 0x0600533E RID: 21310 RVA: 0x00248A34 File Offset: 0x00246C34
	public static void EHDHPDMDNIF(int EENGLNKNAPF, string[] KCFNBPIBDDF)
	{
		if (!GADABGOBJIM.EEPGOBBIIHM(EENGLNKNAPF))
		{
			DPGJIJGOCIC.ADFCDFHBDAF("StoriesSearchNormalizer.SetStopwords() - invalid lobby language index " + EENGLNKNAPF.ToString());
			return;
		}
		if (KCFNBPIBDDF == null)
		{
			GADABGOBJIM.KBABLOJBAKO[EENGLNKNAPF] = null;
			return;
		}
		string[] array = new string[KCFNBPIBDDF.Length];
		Array.Copy(KCFNBPIBDDF, array, KCFNBPIBDDF.Length);
		Array.Sort<string>(array, StringComparer.Ordinal);
		GADABGOBJIM.KBABLOJBAKO[EENGLNKNAPF] = array;
	}

	// Token: 0x0600533F RID: 21311 RVA: 0x00248A94 File Offset: 0x00246C94
	private static int KBDNHNAAPMG(string DIMBCOBNMAM, int PGBPMOHJDLD)
	{
		if (0 < PGBPMOHJDLD && !GADABGOBJIM.EPHMKCINEFD(DIMBCOBNMAM[PGBPMOHJDLD - 1]))
		{
			return -1;
		}
		int num = PGBPMOHJDLD;
		int num2 = 0;
		while (num < DIMBCOBNMAM.Length && char.IsLetter(DIMBCOBNMAM[num]))
		{
			int num3 = num + 1;
			if (num3 < DIMBCOBNMAM.Length && '.' == DIMBCOBNMAM[num3])
			{
				num2++;
				num = num3 + 1;
			}
			else
			{
				if (num3 >= DIMBCOBNMAM.Length || GADABGOBJIM.EPHMKCINEFD(DIMBCOBNMAM[num3]))
				{
					num2++;
					num = num3;
					break;
				}
				return -1;
			}
		}
		if (num2 < 2)
		{
			return -1;
		}
		return num;
	}

	// Token: 0x06005340 RID: 21312 RVA: 0x00248B20 File Offset: 0x00246D20
	public static string MEGLOMOLHBH(int EENGLNKNAPF, string HEDGFBGEOPH)
	{
		if (HEDGFBGEOPH == null)
		{
			return null;
		}
		if (1 != EENGLNKNAPF && 4 != EENGLNKNAPF && 5 != EENGLNKNAPF && 2 != EENGLNKNAPF && 8 != EENGLNKNAPF && 3 != EENGLNKNAPF)
		{
			return null;
		}
		if (HEDGFBGEOPH.Length < 4 || HEDGFBGEOPH.Length > 5)
		{
			return null;
		}
		int num = HEDGFBGEOPH.Length;
		while (num > 3 && GADABGOBJIM.BAKANOBFLCI(EENGLNKNAPF, HEDGFBGEOPH[num - 1]))
		{
			num--;
		}
		if (2 == EENGLNKNAPF && num > 3 && HEDGFBGEOPH[num - 1] == HEDGFBGEOPH[num - 2] && !GADABGOBJIM.BAKANOBFLCI(EENGLNKNAPF, HEDGFBGEOPH[num - 1]))
		{
			num--;
		}
		if (num == HEDGFBGEOPH.Length)
		{
			return null;
		}
		return HEDGFBGEOPH.Substring(0, num);
	}

	// Token: 0x06005341 RID: 21313 RVA: 0x00248BC8 File Offset: 0x00246DC8
	public static int IBPKEOLJLKP(char ONPHDBKMBBH)
	{
		if (GADABGOBJIM.LAPLCGBMMGP(ONPHDBKMBBH))
		{
			return 4;
		}
		if (ONPHDBKMBBH >= 'Ѐ' && ONPHDBKMBBH <= 'ӿ')
		{
			return 2;
		}
		if (ONPHDBKMBBH >= 'Ͱ' && ONPHDBKMBBH <= 'Ͽ')
		{
			return 3;
		}
		if (ONPHDBKMBBH < 'ɐ' && char.IsLetter(ONPHDBKMBBH))
		{
			return 1;
		}
		return 0;
	}

	// Token: 0x06005342 RID: 21314 RVA: 0x00248C18 File Offset: 0x00246E18
	public static string DPLEIOHNNBN(string DIMBCOBNMAM)
	{
		if (!GADABGOBJIM.OFMOKLHBMIB(DIMBCOBNMAM))
		{
			return DIMBCOBNMAM;
		}
		StringBuilder stringBuilder = new StringBuilder(DIMBCOBNMAM.Length);
		for (int i = 0; i < DIMBCOBNMAM.Length; i++)
		{
			if (!GADABGOBJIM.MINONHBBPFA(DIMBCOBNMAM[i]))
			{
				stringBuilder.Append(DIMBCOBNMAM[i]);
			}
		}
		return stringBuilder.ToString();
	}

	// Token: 0x06005343 RID: 21315 RVA: 0x00248C6E File Offset: 0x00246E6E
	public static string DKNKPKLMMLN(int EENGLNKNAPF, string HEDGFBGEOPH)
	{
		if (HEDGFBGEOPH == null)
		{
			return "";
		}
		if (HEDGFBGEOPH.Length >= 4)
		{
			return GADABGOBJIM.LFHDACDCILH(EENGLNKNAPF, HEDGFBGEOPH);
		}
		return HEDGFBGEOPH;
	}

	// Token: 0x06005344 RID: 21316 RVA: 0x00248C8C File Offset: 0x00246E8C
	public static char MLNJHLLHCNH(char ONPHDBKMBBH)
	{
		if (ONPHDBKMBBH < '\u0080')
		{
			if (ONPHDBKMBBH >= 'A' && ONPHDBKMBBH <= 'Z')
			{
				return ONPHDBKMBBH + ' ';
			}
			return ONPHDBKMBBH;
		}
		else
		{
			if (ONPHDBKMBBH >= 'À' && ONPHDBKMBBH <= 'Þ' && '×' != ONPHDBKMBBH)
			{
				return ONPHDBKMBBH + ' ';
			}
			if (ONPHDBKMBBH >= 'Ā' && ONPHDBKMBBH <= 'į')
			{
				if ((ONPHDBKMBBH & '\u0001') != '\0')
				{
					return ONPHDBKMBBH;
				}
				return ONPHDBKMBBH + '\u0001';
			}
			else
			{
				if ('İ' == ONPHDBKMBBH)
				{
					return 'i';
				}
				if (ONPHDBKMBBH >= 'Ĳ' && ONPHDBKMBBH <= 'ķ')
				{
					if ((ONPHDBKMBBH & '\u0001') != '\0')
					{
						return ONPHDBKMBBH;
					}
					return ONPHDBKMBBH + '\u0001';
				}
				else if (ONPHDBKMBBH >= 'Ĺ' && ONPHDBKMBBH <= 'ň')
				{
					if ('\u0001' != (ONPHDBKMBBH & '\u0001'))
					{
						return ONPHDBKMBBH;
					}
					return ONPHDBKMBBH + '\u0001';
				}
				else if (ONPHDBKMBBH >= 'Ŋ' && ONPHDBKMBBH <= 'ŷ')
				{
					if ((ONPHDBKMBBH & '\u0001') != '\0')
					{
						return ONPHDBKMBBH;
					}
					return ONPHDBKMBBH + '\u0001';
				}
				else
				{
					if ('Ÿ' == ONPHDBKMBBH)
					{
						return 'ÿ';
					}
					if (ONPHDBKMBBH >= 'Ź' && ONPHDBKMBBH <= 'ž')
					{
						if ('\u0001' != (ONPHDBKMBBH & '\u0001'))
						{
							return ONPHDBKMBBH;
						}
						return ONPHDBKMBBH + '\u0001';
					}
					else
					{
						if ('Ǣ' == ONPHDBKMBBH)
						{
							return 'ǣ';
						}
						if ('Ș' == ONPHDBKMBBH || 'Ț' == ONPHDBKMBBH)
						{
							return ONPHDBKMBBH + '\u0001';
						}
						if ('Ψ' == ONPHDBKMBBH)
						{
							return 'ψ';
						}
						if (ONPHDBKMBBH >= 'А' && ONPHDBKMBBH <= 'Я')
						{
							return ONPHDBKMBBH + ' ';
						}
						if (ONPHDBKMBBH >= 'Ѐ' && ONPHDBKMBBH <= 'Џ')
						{
							return ONPHDBKMBBH + 'P';
						}
						if ('Ґ' == ONPHDBKMBBH)
						{
							return 'ґ';
						}
						return ONPHDBKMBBH;
					}
				}
			}
		}
	}

	// Token: 0x06005345 RID: 21317 RVA: 0x00248DE4 File Offset: 0x00246FE4
	public static string LFHDACDCILH(int EENGLNKNAPF, string HEDGFBGEOPH)
	{
		if (HEDGFBGEOPH == null || !GADABGOBJIM.EEPGOBBIIHM(EENGLNKNAPF))
		{
			return HEDGFBGEOPH;
		}
		string text = HEDGFBGEOPH;
		string[] array = GADABGOBJIM.JCHFOCANBKN[EENGLNKNAPF];
		int num = GADABGOBJIM.AMAIPOFNHMH[EENGLNKNAPF];
		bool flag = 3 == EENGLNKNAPF || 8 == EENGLNKNAPF;
		for (int i = 0; i < num; i++)
		{
			bool flag2 = false;
			foreach (string text2 in array)
			{
				int num2 = (flag && 1 == text2.Length) ? 5 : 4;
				if (text.Length - text2.Length >= num2 && GADABGOBJIM.PHKIECGMBND(text, text2))
				{
					if (EENGLNKNAPF == 0)
					{
						if (!GADABGOBJIM.MEFBNCLFNFL(text, text2))
						{
							goto IL_103;
						}
						if (string.CompareOrdinal(text2, "ies") == 0)
						{
							text = text.Substring(0, text.Length - 3) + "y";
						}
						else if (string.CompareOrdinal(text2, "sses") == 0)
						{
							text = text.Substring(0, text.Length - 2);
						}
						else
						{
							text = text.Substring(0, text.Length - text2.Length);
						}
					}
					else
					{
						text = text.Substring(0, text.Length - text2.Length);
					}
					flag2 = true;
					break;
				}
				IL_103:;
			}
			if (!flag2)
			{
				break;
			}
		}
		return text;
	}

	// Token: 0x06005346 RID: 21318 RVA: 0x00248F17 File Offset: 0x00247117
	public static int BDMIDHLJCIK(int EENGLNKNAPF)
	{
		if (!GADABGOBJIM.KEOMFJMNFJL(EENGLNKNAPF))
		{
			return 0;
		}
		return GADABGOBJIM.KBABLOJBAKO[EENGLNKNAPF].Length;
	}

	// Token: 0x06005347 RID: 21319 RVA: 0x00248F2C File Offset: 0x0024712C
	public static bool LGLGBJOOFJL(int EENGLNKNAPF, string PADJJGIGOEM)
	{
		return PADJJGIGOEM != null && GADABGOBJIM.KEOMFJMNFJL(EENGLNKNAPF) && 0 <= Array.BinarySearch<string>(GADABGOBJIM.KBABLOJBAKO[EENGLNKNAPF], PADJJGIGOEM, StringComparer.Ordinal);
	}

	// Token: 0x06005348 RID: 21320 RVA: 0x00248F53 File Offset: 0x00247153
	public static bool BENDHLBOJMA(string MIDLEBAGDMN, string DFNFPEMFNPN)
	{
		return MIDLEBAGDMN != null && DFNFPEMFNPN != null && MIDLEBAGDMN.Length != 0 && DFNFPEMFNPN.Length != 0 && GADABGOBJIM.IBPKEOLJLKP(MIDLEBAGDMN[0]) == GADABGOBJIM.IBPKEOLJLKP(DFNFPEMFNPN[0]);
	}

	// Token: 0x06005349 RID: 21321 RVA: 0x00248F88 File Offset: 0x00247188
	public static int IJBHNMOOIJF(CEIBHCNNIDC EENGLNKNAPF)
	{
		switch (EENGLNKNAPF)
		{
		case CEIBHCNNIDC.en:
			return 0;
		case CEIBHCNNIDC.ru:
			return 1;
		case CEIBHCNNIDC.fr:
			return 8;
		case CEIBHCNNIDC.es:
			return 3;
		case CEIBHCNNIDC.pl:
			return 4;
		case CEIBHCNNIDC.tr:
			return 2;
		case CEIBHCNNIDC.ro:
			return 6;
		case CEIBHCNNIDC.cz:
			return 5;
		case CEIBHCNNIDC.de:
			return 7;
		}
		return -1;
	}

	// Token: 0x0600534A RID: 21322 RVA: 0x00248FEC File Offset: 0x002471EC
	public static string ECIBPEJJLJB(string DEMDOALCEGL)
	{
		if (DEMDOALCEGL == null)
		{
			return "";
		}
		bool flag = false;
		foreach (char c in DEMDOALCEGL)
		{
			if (c < '\u0080')
			{
				if (c >= 'A' && c <= 'Z')
				{
					flag = true;
					break;
				}
			}
			else
			{
				char c2 = GADABGOBJIM.MLNJHLLHCNH(c);
				if (c2 != c || GADABGOBJIM.FHIBMONHIGM.ContainsKey(c2) || GADABGOBJIM.NDIPEBFIOLM(c2))
				{
					flag = true;
					break;
				}
			}
		}
		if (!flag)
		{
			return DEMDOALCEGL;
		}
		GADABGOBJIM.IMCDHJBPNIG.Length = 0;
		for (int j = 0; j < DEMDOALCEGL.Length; j++)
		{
			char c3 = GADABGOBJIM.MLNJHLLHCNH(DEMDOALCEGL[j]);
			string value;
			if (GADABGOBJIM.FHIBMONHIGM.TryGetValue(c3, out value))
			{
				GADABGOBJIM.IMCDHJBPNIG.Append(value);
			}
			else if (!GADABGOBJIM.NDIPEBFIOLM(c3))
			{
				GADABGOBJIM.IMCDHJBPNIG.Append(c3);
			}
		}
		return GADABGOBJIM.IMCDHJBPNIG.ToString();
	}

	// Token: 0x0600534B RID: 21323 RVA: 0x002490CA File Offset: 0x002472CA
	private static bool NDIPEBFIOLM(char ONPHDBKMBBH)
	{
		return ONPHDBKMBBH >= '̀' && UnicodeCategory.NonSpacingMark == CharUnicodeInfo.GetUnicodeCategory(ONPHDBKMBBH);
	}

	// Token: 0x0600534C RID: 21324 RVA: 0x002490E0 File Offset: 0x002472E0
	private static bool PHKIECGMBND(string MLPEBEOHEGK, string AKMIBDDHADH)
	{
		int num = MLPEBEOHEGK.Length - AKMIBDDHADH.Length;
		if (num < 0)
		{
			return false;
		}
		for (int i = 0; i < AKMIBDDHADH.Length; i++)
		{
			if (MLPEBEOHEGK[num + i] != AKMIBDDHADH[i])
			{
				return false;
			}
		}
		return true;
	}

	// Token: 0x0600534D RID: 21325 RVA: 0x00249128 File Offset: 0x00247328
	public static int OEEJJCAFPCF(string ELLMMFEBFKB)
	{
		if (ELLMMFEBFKB == null)
		{
			return -1;
		}
		for (int i = 0; i < 9; i++)
		{
			if (string.CompareOrdinal(GADABGOBJIM.KHONHAFKADP[i], ELLMMFEBFKB) == 0)
			{
				return i;
			}
		}
		return -1;
	}

	// Token: 0x0600534E RID: 21326 RVA: 0x00249159 File Offset: 0x00247359
	public static CEIBHCNNIDC MBLIAECCLGO(int MEFKFOHCOHK)
	{
		if (!GADABGOBJIM.EEPGOBBIIHM(MEFKFOHCOHK))
		{
			return CEIBHCNNIDC.en;
		}
		return GADABGOBJIM.PLLJOOJAOKD[MEFKFOHCOHK];
	}

	// Token: 0x0600534F RID: 21327 RVA: 0x0024916C File Offset: 0x0024736C
	public static int IEDAGPCMENK(int MEFKFOHCOHK)
	{
		if (!GADABGOBJIM.EEPGOBBIIHM(MEFKFOHCOHK))
		{
			return 0;
		}
		return 1 << MEFKFOHCOHK;
	}

	// Token: 0x06005350 RID: 21328 RVA: 0x00249180 File Offset: 0x00247380
	public static string EMDGODMGDKL(string DIMBCOBNMAM)
	{
		if (DIMBCOBNMAM == null)
		{
			return "";
		}
		if (DIMBCOBNMAM.IndexOf('.') < 0)
		{
			return DIMBCOBNMAM;
		}
		GADABGOBJIM.MDGMCIIIABA.Length = 0;
		int i = 0;
		while (i < DIMBCOBNMAM.Length)
		{
			int num = GADABGOBJIM.KBDNHNAAPMG(DIMBCOBNMAM, i);
			if (num < 0)
			{
				GADABGOBJIM.MDGMCIIIABA.Append(DIMBCOBNMAM[i]);
				i++;
			}
			else
			{
				for (int j = i; j < num; j++)
				{
					if ('.' != DIMBCOBNMAM[j])
					{
						GADABGOBJIM.MDGMCIIIABA.Append(DIMBCOBNMAM[j]);
					}
				}
				i = num;
			}
		}
		return GADABGOBJIM.MDGMCIIIABA.ToString();
	}

	// Token: 0x06005351 RID: 21329 RVA: 0x00249214 File Offset: 0x00247414
	public static string KFBMINKIPKG(string IDNDNADDJIO)
	{
		if (IDNDNADDJIO == null)
		{
			return "";
		}
		bool flag = false;
		for (int i = 0; i < IDNDNADDJIO.Length; i++)
		{
			if (GADABGOBJIM.KOGMDFOCCLJ(IDNDNADDJIO[i]))
			{
				flag = true;
				break;
			}
		}
		if (!flag)
		{
			return IDNDNADDJIO;
		}
		StringBuilder stringBuilder = new StringBuilder(IDNDNADDJIO.Length);
		int j = 0;
		while (j < IDNDNADDJIO.Length)
		{
			char c = IDNDNADDJIO[j];
			if (GADABGOBJIM.KOGMDFOCCLJ(c))
			{
				for (j++; j < IDNDNADDJIO.Length; j++)
				{
					if (!char.IsLetter(IDNDNADDJIO[j]) && !GADABGOBJIM.NDIPEBFIOLM(IDNDNADDJIO[j]))
					{
						break;
					}
				}
			}
			else
			{
				stringBuilder.Append(c);
				j++;
			}
		}
		return stringBuilder.ToString();
	}

	// Token: 0x06005352 RID: 21330 RVA: 0x002492C4 File Offset: 0x002474C4
	public static bool OFMOKLHBMIB(string DIMBCOBNMAM)
	{
		if (DIMBCOBNMAM == null)
		{
			return false;
		}
		for (int i = 0; i < DIMBCOBNMAM.Length; i++)
		{
			if (GADABGOBJIM.MINONHBBPFA(DIMBCOBNMAM[i]))
			{
				return true;
			}
		}
		return false;
	}

	// Token: 0x06005353 RID: 21331 RVA: 0x002492F8 File Offset: 0x002474F8
	public static void IAAMHNDECNP(string DIMBCOBNMAM, List<string> BPNMNMJHOJH)
	{
		BPNMNMJHOJH.Clear();
		string text = GADABGOBJIM.CBGFJALLOAF(DIMBCOBNMAM);
		text = GADABGOBJIM.EMDGODMGDKL(text);
		int num = -1;
		int num2 = 0;
		for (int i = 0; i <= text.Length; i++)
		{
			int num3 = 0;
			if (i < text.Length)
			{
				char c = text[i];
				if (GADABGOBJIM.LAPLCGBMMGP(c))
				{
					num3 = 2;
				}
				else if (char.IsLetter(c))
				{
					num3 = 1;
				}
				else if (1 == num2 && GADABGOBJIM.NDIPEBFIOLM(c))
				{
					num3 = 1;
				}
			}
			if (num3 != num2)
			{
				if (num2 != 0 && i - num <= 32)
				{
					BPNMNMJHOJH.Add(text.Substring(num, i - num));
				}
				num = i;
				num2 = num3;
			}
		}
	}

	// Token: 0x06005354 RID: 21332 RVA: 0x00249394 File Offset: 0x00247594
	public static int HACOKLOMEIN(string MIDLEBAGDMN, string DFNFPEMFNPN, int GILDODOFLKC)
	{
		if (GILDODOFLKC < 0)
		{
			GILDODOFLKC = 0;
		}
		if (MIDLEBAGDMN == null || DFNFPEMFNPN == null)
		{
			return GILDODOFLKC + 1;
		}
		int length = MIDLEBAGDMN.Length;
		int length2 = DFNFPEMFNPN.Length;
		if (length > 32 || length2 > 32)
		{
			return GILDODOFLKC + 1;
		}
		int num = length - length2;
		if (num > GILDODOFLKC || num < -GILDODOFLKC)
		{
			return GILDODOFLKC + 1;
		}
		int[] array = GADABGOBJIM.DIAGOLNGBLE;
		int[] array2 = GADABGOBJIM.EMENOBALHFB;
		int[] array3 = GADABGOBJIM.BINAMGAJKAL;
		for (int i = 0; i <= length2; i++)
		{
			array2[i] = i;
		}
		for (int j = 1; j <= length; j++)
		{
			array3[0] = j;
			int num2 = j;
			int num3 = (j - GILDODOFLKC < 1) ? 1 : (j - GILDODOFLKC);
			int num4 = (j + GILDODOFLKC > length2) ? length2 : (j + GILDODOFLKC);
			if (num3 > 1)
			{
				array3[num3 - 1] = GILDODOFLKC + 1;
			}
			for (int k = num3; k <= num4; k++)
			{
				int num5 = (MIDLEBAGDMN[j - 1] == DFNFPEMFNPN[k - 1]) ? 0 : 1;
				int num6 = array2[k] + 1;
				if (array3[k - 1] + 1 < num6)
				{
					num6 = array3[k - 1] + 1;
				}
				if (array2[k - 1] + num5 < num6)
				{
					num6 = array2[k - 1] + num5;
				}
				if (j > 1 && k > 1 && MIDLEBAGDMN[j - 1] == DFNFPEMFNPN[k - 2] && MIDLEBAGDMN[j - 2] == DFNFPEMFNPN[k - 1] && array[k - 2] + 1 < num6)
				{
					num6 = array[k - 2] + 1;
				}
				array3[k] = num6;
				if (num6 < num2)
				{
					num2 = num6;
				}
			}
			if (num4 < length2)
			{
				array3[num4 + 1] = GILDODOFLKC + 1;
			}
			if (num2 > GILDODOFLKC)
			{
				return GILDODOFLKC + 1;
			}
			int[] array4 = array;
			array = array2;
			array2 = array3;
			array3 = array4;
		}
		if (array2[length2] > GILDODOFLKC)
		{
			return GILDODOFLKC + 1;
		}
		return array2[length2];
	}

	// Token: 0x06005355 RID: 21333 RVA: 0x00249556 File Offset: 0x00247756
	private static bool LAPLCGBMMGP(char ONPHDBKMBBH)
	{
		return ONPHDBKMBBH >= '0' && ONPHDBKMBBH <= '9';
	}

	// Token: 0x06005356 RID: 21334 RVA: 0x00249568 File Offset: 0x00247768
	public static bool JOMNLCJJOBD(string DEMDOALCEGL)
	{
		if (DEMDOALCEGL == null || DEMDOALCEGL.Length == 0)
		{
			return false;
		}
		for (int i = 0; i < DEMDOALCEGL.Length; i++)
		{
			if (!GADABGOBJIM.LAPLCGBMMGP(DEMDOALCEGL[i]))
			{
				return false;
			}
		}
		return true;
	}

	// Token: 0x06005357 RID: 21335 RVA: 0x002495A4 File Offset: 0x002477A4
	public static bool OJFKHOJBCBJ(string MIDLEBAGDMN, string DFNFPEMFNPN)
	{
		if (MIDLEBAGDMN == null || DFNFPEMFNPN == null || MIDLEBAGDMN.Length < 2 || DFNFPEMFNPN.Length < 2)
		{
			return false;
		}
		int num = MIDLEBAGDMN.Length - DFNFPEMFNPN.Length;
		return num <= 2 && num >= -2 && (MIDLEBAGDMN[0] == DFNFPEMFNPN[0] || MIDLEBAGDMN[1] == DFNFPEMFNPN[1] || MIDLEBAGDMN[0] == DFNFPEMFNPN[1] || MIDLEBAGDMN[1] == DFNFPEMFNPN[0]);
	}

	// Token: 0x06005359 RID: 21337 RVA: 0x00249E30 File Offset: 0x00248030
	public static string MAGFECMLHAJ(string DEMDOALCEGL)
	{
		if (DEMDOALCEGL == null)
		{
			return "";
		}
		bool flag = false;
		for (int i = 0; i < DEMDOALCEGL.Length; i++)
		{
			if (GADABGOBJIM.MLNJHLLHCNH(DEMDOALCEGL[i]) != DEMDOALCEGL[i])
			{
				flag = true;
				break;
			}
		}
		if (!flag)
		{
			return DEMDOALCEGL;
		}
		GADABGOBJIM.IMCDHJBPNIG.Length = 0;
		for (int j = 0; j < DEMDOALCEGL.Length; j++)
		{
			GADABGOBJIM.IMCDHJBPNIG.Append(GADABGOBJIM.MLNJHLLHCNH(DEMDOALCEGL[j]));
		}
		return GADABGOBJIM.IMCDHJBPNIG.ToString();
	}

	// Token: 0x0600535A RID: 21338 RVA: 0x00249EB4 File Offset: 0x002480B4
	public static bool KEOMFJMNFJL(int EENGLNKNAPF)
	{
		return GADABGOBJIM.EEPGOBBIIHM(EENGLNKNAPF) && GADABGOBJIM.KBABLOJBAKO[EENGLNKNAPF] != null && GADABGOBJIM.KBABLOJBAKO[EENGLNKNAPF].Length != 0;
	}

	// Token: 0x0600535B RID: 21339 RVA: 0x00249ED4 File Offset: 0x002480D4
	public static List<string> IAAMHNDECNP(string DIMBCOBNMAM)
	{
		List<string> list = new List<string>(8);
		GADABGOBJIM.IAAMHNDECNP(DIMBCOBNMAM, list);
		return list;
	}

	// Token: 0x0600535C RID: 21340 RVA: 0x00249EF0 File Offset: 0x002480F0
	public static void HHCIJJJDPGB()
	{
		for (int i = 0; i < 9; i++)
		{
			GADABGOBJIM.KBABLOJBAKO[i] = null;
		}
	}

	// Token: 0x0600535D RID: 21341 RVA: 0x00249F12 File Offset: 0x00248112
	public static bool EEPGOBBIIHM(int MEFKFOHCOHK)
	{
		return 0 <= MEFKFOHCOHK && MEFKFOHCOHK < 9;
	}

	// Token: 0x0600535E RID: 21342 RVA: 0x00249F1F File Offset: 0x0024811F
	public static bool KOGMDFOCCLJ(char ONPHDBKMBBH)
	{
		return '\'' == ONPHDBKMBBH || '’' == ONPHDBKMBBH || '‘' == ONPHDBKMBBH || 'ʼ' == ONPHDBKMBBH || '`' == ONPHDBKMBBH || '´' == ONPHDBKMBBH;
	}

	// Token: 0x0600535F RID: 21343 RVA: 0x00249F50 File Offset: 0x00248150
	public static string CBGFJALLOAF(string DIMBCOBNMAM)
	{
		if (DIMBCOBNMAM == null)
		{
			return "";
		}
		bool flag = false;
		foreach (char c in DIMBCOBNMAM)
		{
			if ('Ψ' == c || 'ψ' == c || '&' == c || '+' == c)
			{
				flag = true;
				break;
			}
		}
		if (!flag)
		{
			return DIMBCOBNMAM;
		}
		GADABGOBJIM.IMCDHJBPNIG.Length = 0;
		foreach (char c2 in DIMBCOBNMAM)
		{
			if ('Ψ' == c2 || 'ψ' == c2)
			{
				GADABGOBJIM.IMCDHJBPNIG.Append(" psi ");
			}
			else if ('&' == c2 || '+' == c2)
			{
				GADABGOBJIM.IMCDHJBPNIG.Append(' ');
			}
			else
			{
				GADABGOBJIM.IMCDHJBPNIG.Append(c2);
			}
		}
		return GADABGOBJIM.IMCDHJBPNIG.ToString();
	}

	// Token: 0x06005360 RID: 21344 RVA: 0x0024A020 File Offset: 0x00248220
	private static bool BAKANOBFLCI(int EENGLNKNAPF, char ONPHDBKMBBH)
	{
		string text;
		if (1 == EENGLNKNAPF)
		{
			text = "аеиоуыэюяьъ";
		}
		else if (2 == EENGLNKNAPF)
		{
			text = "aeiou";
		}
		else
		{
			text = "aeiouy";
		}
		for (int i = 0; i < text.Length; i++)
		{
			if (text[i] == ONPHDBKMBBH)
			{
				return true;
			}
		}
		return false;
	}

	// Token: 0x06005361 RID: 21345 RVA: 0x0024A069 File Offset: 0x00248269
	public static bool EPHMKCINEFD(char ONPHDBKMBBH)
	{
		return !GADABGOBJIM.LAPLCGBMMGP(ONPHDBKMBBH) && !char.IsLetter(ONPHDBKMBBH) && !GADABGOBJIM.NDIPEBFIOLM(ONPHDBKMBBH);
	}

	// Token: 0x04001742 RID: 5954
	public const int GIOMMKMIAJA = 9;

	// Token: 0x04001743 RID: 5955
	public const int BDNLEHLKCNO = 0;

	// Token: 0x04001744 RID: 5956
	public const int DJPNIJFCPNB = 1;

	// Token: 0x04001745 RID: 5957
	public const int FIJOGPCCGPP = 2;

	// Token: 0x04001746 RID: 5958
	public const int NMCGCMFFGCH = 3;

	// Token: 0x04001747 RID: 5959
	public const int BCJOGOIAJKB = 4;

	// Token: 0x04001748 RID: 5960
	public const int HAGPAMGNDKL = 5;

	// Token: 0x04001749 RID: 5961
	public const int OMNCNKJLCKM = 6;

	// Token: 0x0400174A RID: 5962
	public const int NNFPHFMCBEE = 7;

	// Token: 0x0400174B RID: 5963
	public const int HLBCEMGKALP = 8;

	// Token: 0x0400174C RID: 5964
	public const int LOCLKLNGCMC = 511;

	// Token: 0x0400174D RID: 5965
	public const int DINGKIIBPNN = 32;

	// Token: 0x0400174E RID: 5966
	public const int BOCKLOHKCAK = 2;

	// Token: 0x0400174F RID: 5967
	public const int IHLLKKCCPIB = 4;

	// Token: 0x04001750 RID: 5968
	public const int KFFDMHIGFFL = 5;

	// Token: 0x04001751 RID: 5969
	public const int LNDFFCNOLBG = 5;

	// Token: 0x04001752 RID: 5970
	public const int LGHLDJODHPK = 8;

	// Token: 0x04001753 RID: 5971
	public const int LAAPPNFFAOH = 4;

	// Token: 0x04001754 RID: 5972
	public const int DFEBKOJBCBA = 5;

	// Token: 0x04001755 RID: 5973
	public const int LNBKLJLGJND = 4;

	// Token: 0x04001756 RID: 5974
	public const int KCIOHKBLAAM = 5;

	// Token: 0x04001757 RID: 5975
	public const int MDLGLNHHDKD = 3;

	// Token: 0x04001758 RID: 5976
	private static readonly CEIBHCNNIDC[] PLLJOOJAOKD = new CEIBHCNNIDC[]
	{
		CEIBHCNNIDC.en,
		CEIBHCNNIDC.ru,
		CEIBHCNNIDC.tr,
		CEIBHCNNIDC.es,
		CEIBHCNNIDC.pl,
		CEIBHCNNIDC.cz,
		CEIBHCNNIDC.ro,
		CEIBHCNNIDC.de,
		CEIBHCNNIDC.fr
	};

	// Token: 0x04001759 RID: 5977
	private static readonly string[] KHONHAFKADP = new string[]
	{
		"en",
		"ru",
		"tr",
		"es",
		"pl",
		"cz",
		"ro",
		"de",
		"fr"
	};

	// Token: 0x0400175A RID: 5978
	private static readonly StringBuilder IMCDHJBPNIG = new StringBuilder(64);

	// Token: 0x0400175B RID: 5979
	private static readonly StringBuilder MDGMCIIIABA = new StringBuilder(64);

	// Token: 0x0400175C RID: 5980
	private const string EMEJKIAJGLP = "a=ÀÁÂÃÄÅĀĂĄàáâãäåāăą;c=ÇĆĈĊČçćĉċč;d=ĎĐďđ;e=ÈÉÊËĒĔĖĘĚèéêëēĕėęě;g=ĜĞĠĢĝğġģ;h=ĤĦĥħ;i=ÌÍÎÏĨĪĬĮİìíîïĩīĭįı;j=Ĵĵ;k=Ķķ;l=ĹĻĽĿŁĺļľŀł;n=ÑŃŅŇñńņň;o=ÒÓÔÕÖØŌŎŐòóôõöøōŏő;r=ŔŖŘŕŗř;s=ŚŜŞŠȘśŝşšș;t=ŢŤŦȚţťŧț;u=ÙÚÛÜŨŪŬŮŰŲùúûüũūŭůűų;w=Ŵŵ;y=ÝŶŸýÿŷ;z=ŹŻŽźżž;ss=ß;ae=ÆæǢǣ;oe=Œœ;th=Þþ;ij=Ĳĳ;е=Ёё;и=ІіЇї;е=Єє;г=Ґґ;psi=Ψψ";

	// Token: 0x0400175D RID: 5981
	private static readonly Dictionary<char, string> FHIBMONHIGM = GADABGOBJIM.GLLFLGBPEAE();

	// Token: 0x0400175E RID: 5982
	private static string[][] KBABLOJBAKO = new string[9][];

	// Token: 0x0400175F RID: 5983
	private static readonly string[] FEHFJNPMDLF = new string[]
	{
		"ies",
		"sses",
		"ing",
		"ed",
		"es",
		"s"
	};

	// Token: 0x04001760 RID: 5984
	private static readonly string[] CMFEMIEACNI = new string[]
	{
		"иями",
		"ями",
		"ами",
		"ого",
		"его",
		"ому",
		"ему",
		"ыми",
		"ими",
		"ах",
		"ях",
		"ам",
		"ям",
		"ов",
		"ев",
		"ей",
		"ой",
		"ый",
		"ий",
		"ая",
		"яя",
		"ое",
		"ее",
		"ые",
		"ие",
		"ых",
		"их",
		"ым",
		"им",
		"ом",
		"ем",
		"а",
		"я",
		"ы",
		"и",
		"у",
		"ю",
		"е",
		"о",
		"ь",
		"й"
	};

	// Token: 0x04001761 RID: 5985
	private static readonly string[] FKJHCPCKIAB = new string[]
	{
		"lerinden",
		"larindan",
		"lerinin",
		"larinin",
		"lerine",
		"larina",
		"lerini",
		"larini",
		"lerin",
		"larin",
		"leri",
		"lari",
		"lerde",
		"larda",
		"lerden",
		"lardan",
		"lere",
		"lara",
		"ler",
		"lar",
		"inden",
		"undan",
		"indan",
		"inin",
		"unun",
		"ini",
		"unu",
		"nin",
		"nun",
		"sin",
		"sun",
		"daki",
		"deki",
		"taki",
		"teki",
		"den",
		"dan",
		"ten",
		"tan",
		"yle",
		"yla",
		"lik",
		"luk",
		"de",
		"da",
		"te",
		"ta",
		"le",
		"la",
		"ye",
		"ya",
		"in",
		"un",
		"im",
		"um",
		"si",
		"su",
		"ki",
		"i",
		"u",
		"a",
		"e"
	};

	// Token: 0x04001762 RID: 5986
	private static readonly string[] PIELPPOKPBB = new string[]
	{
		"es",
		"s",
		"o",
		"a",
		"e"
	};

	// Token: 0x04001763 RID: 5987
	private static readonly string[] PMGLJACLIIH = new string[]
	{
		"es",
		"s",
		"x",
		"e"
	};

	// Token: 0x04001764 RID: 5988
	private static readonly string[] DBEKAECCHNH = new string[]
	{
		"innen",
		"ern",
		"en",
		"er",
		"es",
		"em",
		"in",
		"e",
		"s"
	};

	// Token: 0x04001765 RID: 5989
	private static readonly string[] CCDMEHJBHFN = new string[]
	{
		"ami",
		"ach",
		"owie",
		"owi",
		"ego",
		"emu",
		"ych",
		"ymi",
		"ich",
		"imi",
		"om",
		"ow",
		"em",
		"ie",
		"iu",
		"ej",
		"ym",
		"im",
		"a",
		"u",
		"y",
		"i",
		"e",
		"o"
	};

	// Token: 0x04001766 RID: 5990
	private static readonly string[] PBOPINDNFEF = new string[]
	{
		"ove",
		"ovi",
		"ech",
		"ich",
		"ami",
		"emi",
		"ach",
		"eho",
		"emu",
		"ych",
		"ymi",
		"am",
		"um",
		"em",
		"mi",
		"ov",
		"ym",
		"u",
		"a",
		"y",
		"i",
		"e",
		"o"
	};

	// Token: 0x04001767 RID: 5991
	private static readonly string[] GHKLOKMNLKN = new string[]
	{
		"urilor",
		"urile",
		"ilor",
		"elor",
		"ului",
		"uri",
		"ele",
		"ile",
		"lor",
		"lui",
		"ul",
		"ii",
		"le",
		"i",
		"e",
		"a"
	};

	// Token: 0x04001768 RID: 5992
	private static readonly string[][] JCHFOCANBKN = new string[][]
	{
		GADABGOBJIM.FEHFJNPMDLF,
		GADABGOBJIM.CMFEMIEACNI,
		GADABGOBJIM.FKJHCPCKIAB,
		GADABGOBJIM.PIELPPOKPBB,
		GADABGOBJIM.CCDMEHJBHFN,
		GADABGOBJIM.PBOPINDNFEF,
		GADABGOBJIM.GHKLOKMNLKN,
		GADABGOBJIM.DBEKAECCHNH,
		GADABGOBJIM.PMGLJACLIIH
	};

	// Token: 0x04001769 RID: 5993
	private static readonly int[] AMAIPOFNHMH = new int[]
	{
		1,
		1,
		3,
		3,
		1,
		1,
		2,
		3,
		2
	};

	// Token: 0x0400176A RID: 5994
	private const string CNLIICBAIJI = "аеиоуыэюяьъ";

	// Token: 0x0400176B RID: 5995
	private const string DCDDBJHMPCC = "aeiouy";

	// Token: 0x0400176C RID: 5996
	private const string MJIIAEEJKBB = "aeiou";

	// Token: 0x0400176D RID: 5997
	private static readonly int[] DIAGOLNGBLE = new int[34];

	// Token: 0x0400176E RID: 5998
	private static readonly int[] EMENOBALHFB = new int[34];

	// Token: 0x0400176F RID: 5999
	private static readonly int[] BINAMGAJKAL = new int[34];
}
