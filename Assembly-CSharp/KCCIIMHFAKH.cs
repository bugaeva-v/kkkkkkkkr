using System;

// Token: 0x020001A4 RID: 420
public static class KCCIIMHFAKH
{
	// Token: 0x06003270 RID: 12912 RVA: 0x001536AC File Offset: 0x001518AC
	public static string HGIJAIEJCPM(CEIBHCNNIDC NIIIMDHGGEN, int HHKIAICFCKC)
	{
		int num = Math.Abs(HHKIAICFCKC);
		int num2 = num % 10;
		int num3 = num % 100;
		if (NIIIMDHGGEN != CEIBHCNNIDC.ru)
		{
			if (NIIIMDHGGEN != CEIBHCNNIDC.fr)
			{
				switch (NIIIMDHGGEN)
				{
				case CEIBHCNNIDC.pl:
					if (1 == num)
					{
						return "_1";
					}
					if (num2 >= 2 && num2 <= 4 && (num3 < 12 || num3 > 14))
					{
						return "_2";
					}
					return "";
				case CEIBHCNNIDC.tr:
					return "";
				case CEIBHCNNIDC.ro:
					if (1 == num)
					{
						return "_1";
					}
					if (num == 0 || (num3 >= 1 && num3 <= 19))
					{
						return "_2";
					}
					return "";
				case CEIBHCNNIDC.cz:
					if (1 == num)
					{
						return "_1";
					}
					if (num >= 2 && num <= 4)
					{
						return "_2";
					}
					return "";
				}
				if (1 == num)
				{
					return "_1";
				}
				return "";
			}
			else
			{
				if (num <= 1)
				{
					return "_1";
				}
				return "";
			}
		}
		else
		{
			if (1 == num2 && 11 != num3)
			{
				return "_1";
			}
			if (num2 >= 2 && num2 <= 4 && (num3 < 12 || num3 > 14))
			{
				return "_2";
			}
			return "";
		}
	}

	// Token: 0x06003271 RID: 12913 RVA: 0x001537B8 File Offset: 0x001519B8
	private static string HCHJMHNGMLG(string KHJMANDEDMA, int HHKIAICFCKC)
	{
		string text = KCCIIMHFAKH.HGIJAIEJCPM(LanguageManager.EHBBFMCILPC.GetSelectedLanguage(), HHKIAICFCKC);
		if (text.Length > 0)
		{
			string text2 = KCCIIMHFAKH.BEIPHDMGKNF(KHJMANDEDMA + text);
			if (text2 != null)
			{
				return text2;
			}
		}
		return KCCIIMHFAKH.BEIPHDMGKNF(KHJMANDEDMA);
	}

	// Token: 0x06003272 RID: 12914 RVA: 0x001537F8 File Offset: 0x001519F8
	private static string BEIPHDMGKNF(string KHJMANDEDMA)
	{
		if (KHJMANDEDMA == null || KHJMANDEDMA.Length == 0 || CCOJBMMKNAP.EHBBFMCILPC == null)
		{
			return null;
		}
		string text = CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP(KHJMANDEDMA);
		if (text == null || text.Length == 0 || text.EndsWith("_not_found"))
		{
			return null;
		}
		return text;
	}

	// Token: 0x06003273 RID: 12915 RVA: 0x00153840 File Offset: 0x00151A40
	public static string KDGEMEPJPBC(int CNGAINAIGBB)
	{
		if (CNGAINAIGBB < 1 || CNGAINAIGBB > 12)
		{
			return "";
		}
		string text = KCCIIMHFAKH.BEIPHDMGKNF("month" + CNGAINAIGBB.ToString());
		if (text == null)
		{
			return "";
		}
		return text;
	}

	// Token: 0x06003274 RID: 12916 RVA: 0x00153880 File Offset: 0x00151A80
	public static bool GGMIMFBKLMP(string KHJMANDEDMA, int HHKIAICFCKC, int ENONNLDGGIN, int CNGAINAIGBB, string GOJOGDKCNMO, out string HJEJJGAFHAM, out string MCHOOEHCANP)
	{
		HJEJJGAFHAM = "";
		MCHOOEHCANP = "";
		bool result;
		try
		{
			string text = KCCIIMHFAKH.HCHJMHNGMLG(KHJMANDEDMA, HHKIAICFCKC);
			if (text == null)
			{
				result = false;
			}
			else
			{
				string text2 = GOJOGDKCNMO;
				if (text2 == null)
				{
					text2 = "";
				}
				text = text.Replace("{n}", HHKIAICFCKC.ToString());
				text = text.Replace("{year}", ENONNLDGGIN.ToString());
				text = text.Replace("{month}", KCCIIMHFAKH.KDGEMEPJPBC(CNGAINAIGBB));
				text = text.Replace("{q}", text2);
				string[] array = text.Split(new char[]
				{
					'|'
				}, 2);
				HJEJJGAFHAM = array[0].Trim();
				if (array.Length > 1)
				{
					MCHOOEHCANP = array[1].Trim();
				}
				result = (HJEJJGAFHAM.Length > 0);
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
			result = false;
		}
		return result;
	}

	// Token: 0x04000F9F RID: 3999
	public const char LMLPECINJJG = '|';

	// Token: 0x04000FA0 RID: 4000
	public const string HOILKBLDEIO = "{n}";

	// Token: 0x04000FA1 RID: 4001
	public const string IEMDIPCDKHK = "{month}";

	// Token: 0x04000FA2 RID: 4002
	public const string BDBCONICEPO = "{year}";

	// Token: 0x04000FA3 RID: 4003
	public const string GKCMHDAIIFK = "{q}";

	// Token: 0x04000FA4 RID: 4004
	public const string ONKKEBPNEPA = "_1";

	// Token: 0x04000FA5 RID: 4005
	public const string NOHJCLLIFEO = "_2";

	// Token: 0x04000FA6 RID: 4006
	public const string KLGIOBJDIBC = "month";
}
