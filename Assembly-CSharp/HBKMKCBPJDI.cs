using System;
using UnityEngine.Events;

// Token: 0x020001A1 RID: 417
public static class HBKMKCBPJDI
{
	// Token: 0x06003258 RID: 12888 RVA: 0x00152FE4 File Offset: 0x001511E4
	public static string MMLPOGKDLMD()
	{
		try
		{
			KIOOJMGLCLC kioojmglclc = ODLJHDIGLGO.MNALIKIMKFC(CLHDENLPOFP.gamePass, true);
			if (kioojmglclc != null && kioojmglclc.LIFPODJAPIA() == KHBLFKIDHPH.premiumGamePass)
			{
				return KBOJLHAJPCP.MJIIKJPAKCB;
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
		return KBOJLHAJPCP.JGLFACJDKAG;
	}

	// Token: 0x06003259 RID: 12889 RVA: 0x0015302C File Offset: 0x0015122C
	public static bool BHJPELGEBBI()
	{
		bool result;
		try
		{
			int revision = AppManager.EHBBFMCILPC.GetRevision();
			if (revision < 59500 || revision > 59600)
			{
				result = false;
			}
			else
			{
				int hencgdhcmie = AKLFPGMDKLA.EHBBFMCILPC.HENCGDHCMIE;
				if (hencgdhcmie >= 59500 && hencgdhcmie <= 59600)
				{
					result = false;
				}
				else
				{
					AKLFPGMDKLA.EHBBFMCILPC.HENCGDHCMIE = revision;
					AKLFPGMDKLA.EHBBFMCILPC.EPIBEOCFEGA = AKLFPGMDKLA.EHBBFMCILPC.EPIBEOCFEGA + 1;
					DPGJIJGOCIC.NFIDPOMCNLP(string.Concat(new string[]
					{
						"[LoadingTheme] update giveaway: +1 free change granted for revision ",
						revision.ToString(),
						" (bonus now ",
						AKLFPGMDKLA.EHBBFMCILPC.EPIBEOCFEGA.ToString(),
						")"
					}));
					result = true;
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
			result = false;
		}
		return result;
	}

	// Token: 0x0600325A RID: 12890 RVA: 0x00153100 File Offset: 0x00151300
	public static bool IJBKGBAJLAA()
	{
		return HBKMKCBPJDI.LFJOBHMBNCM() || HBKMKCBPJDI.JDDPNJNGDHI() < 0;
	}

	// Token: 0x0600325B RID: 12891 RVA: 0x00153114 File Offset: 0x00151314
	public static bool LFJOBHMBNCM()
	{
		try
		{
			return ODLJHDIGLGO.MNALIKIMKFC(CLHDENLPOFP.gamePass, true) != null;
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
		return false;
	}

	// Token: 0x0600325C RID: 12892 RVA: 0x00153148 File Offset: 0x00151348
	public static bool EPCONONIJIF(BNFCLKNDBLO CLNJABMOEBA)
	{
		try
		{
			if (EEIBKLDNBAP.PNHLBGBGFIG(CLNJABMOEBA))
			{
				return true;
			}
			return HBKMKCBPJDI.IJBKGBAJLAA() || HBKMKCBPJDI.LINJPHNBOLL() > 0;
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
		return true;
	}

	// Token: 0x0600325D RID: 12893 RVA: 0x00153190 File Offset: 0x00151390
	public static int KPHAKPANGAE()
	{
		DateTime now = DateTime.Now;
		double num = (new DateTime(now.Year, now.Month, 1).AddMonths(1) - now).TotalSeconds;
		if (num < 0.0)
		{
			num = 0.0;
		}
		return (int)num;
	}

	// Token: 0x0600325E RID: 12894 RVA: 0x001531E8 File Offset: 0x001513E8
	public static bool MCNPBFPFBDA()
	{
		bool result;
		try
		{
			if (HBKMKCBPJDI.IJBKGBAJLAA())
			{
				DPGJIJGOCIC.NFIDPOMCNLP("[LoadingTheme] theme removed against the player's will, changes unlimited - no compensation");
				result = false;
			}
			else
			{
				int num = HBKMKCBPJDI.EHPGKBBDHOK();
				if (AKLFPGMDKLA.EHBBFMCILPC.DANIALBOJNN == num)
				{
					DPGJIJGOCIC.NFIDPOMCNLP("[LoadingTheme] theme removed against the player's will, compensation already granted this month");
					result = false;
				}
				else
				{
					AKLFPGMDKLA.EHBBFMCILPC.DANIALBOJNN = num;
					AKLFPGMDKLA.EHBBFMCILPC.EPIBEOCFEGA = AKLFPGMDKLA.EHBBFMCILPC.EPIBEOCFEGA + 1;
					DPGJIJGOCIC.NFIDPOMCNLP("[LoadingTheme] theme removed against the player's will: +1 free change (bonus now " + AKLFPGMDKLA.EHBBFMCILPC.EPIBEOCFEGA.ToString() + ")");
					result = true;
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
			result = false;
		}
		return result;
	}

	// Token: 0x0600325F RID: 12895 RVA: 0x00153290 File Offset: 0x00151490
	public static void NCCEKKBFOBJ()
	{
		FPFNLJGEIJK.FANFNCNAKEF();
		AOBJLALDBAA.EHBBFMCILPC.EGELHPJBAIC("onLoadingThemeSubscribeRequested", 0f);
	}

	// Token: 0x06003260 RID: 12896 RVA: 0x001532AC File Offset: 0x001514AC
	public static string INPBNGMJOHC()
	{
		string text = CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("cardoptionsloadingthemebody");
		try
		{
			if (!HBKMKCBPJDI.IJBKGBAJLAA())
			{
				int num = HBKMKCBPJDI.LINJPHNBOLL();
				string str = CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("cardoptionsloadingthemefree").Replace("XXX", num.ToString() ?? "");
				text = text + "\n\n" + str;
				if (num == 0)
				{
					string str2 = CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("cardoptionsloadingthemereset").Replace("YYY", DPGJIJGOCIC.LCOMEDGJNMP(HBKMKCBPJDI.KPHAKPANGAE(), true, false));
					text = text + "\n" + str2;
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
		return text;
	}

	// Token: 0x06003261 RID: 12897 RVA: 0x00153360 File Offset: 0x00151560
	public static int LINJPHNBOLL()
	{
		return HBKMKCBPJDI.CNJKBFMPOCJ() + HBKMKCBPJDI.AGJOBEEDANM();
	}

	// Token: 0x06003262 RID: 12898 RVA: 0x00153370 File Offset: 0x00151570
	public static int EHPGKBBDHOK()
	{
		DateTime now = DateTime.Now;
		return now.Year * 100 + now.Month;
	}

	// Token: 0x06003263 RID: 12899 RVA: 0x00153395 File Offset: 0x00151595
	public static int JDDPNJNGDHI()
	{
		return KDCJJBLGCBH.EHBBFMCILPC.BIEOHHJMMCE();
	}

	// Token: 0x06003264 RID: 12900 RVA: 0x001533A4 File Offset: 0x001515A4
	public static void DCNHMFBGFIJ(UnityAction BMNPLMKGMAM, UnityAction BHHPFBGHKHA)
	{
		FPFNLJGEIJK.FIBNFNACDBE(BGHLMGPPCNN.subLdgTheme);
		CommonUserInterface.EHBBFMCILPC.ShowGenericPopupWithTwoButtons(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("importanttitle"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("cardoptionsloadingthemesubonly"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("yes"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("no"), BMNPLMKGMAM, BHHPFBGHKHA, DFGILFBGPLN.popupSignInQuestion, 0.15f, 28);
	}

	// Token: 0x06003265 RID: 12901 RVA: 0x0015340C File Offset: 0x0015160C
	public static int AGJOBEEDANM()
	{
		int num = AKLFPGMDKLA.EHBBFMCILPC.EPIBEOCFEGA;
		if (num < 0)
		{
			num = 0;
		}
		return num;
	}

	// Token: 0x06003266 RID: 12902 RVA: 0x0015342B File Offset: 0x0015162B
	public static int IFPGACLLLDF()
	{
		if (AKLFPGMDKLA.EHBBFMCILPC.EIDLACNLJJP != HBKMKCBPJDI.EHPGKBBDHOK())
		{
			return 0;
		}
		return AKLFPGMDKLA.EHBBFMCILPC.MCAGCFDCJID;
	}

	// Token: 0x06003267 RID: 12903 RVA: 0x0015344C File Offset: 0x0015164C
	public static string JDBMIIKHEMK()
	{
		string text = CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("yes");
		try
		{
			if (HBKMKCBPJDI.LFJOBHMBNCM() || (!HBKMKCBPJDI.IJBKGBAJLAA() && HBKMKCBPJDI.LINJPHNBOLL() == 0))
			{
				return HBKMKCBPJDI.MMLPOGKDLMD() + text;
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
		return text;
	}

	// Token: 0x06003268 RID: 12904 RVA: 0x001534A8 File Offset: 0x001516A8
	public static void LFGGDBICHFB()
	{
		try
		{
			if (!HBKMKCBPJDI.IJBKGBAJLAA())
			{
				int num = HBKMKCBPJDI.EHPGKBBDHOK();
				if (AKLFPGMDKLA.EHBBFMCILPC.EIDLACNLJJP != num)
				{
					AKLFPGMDKLA.EHBBFMCILPC.EIDLACNLJJP = num;
					AKLFPGMDKLA.EHBBFMCILPC.MCAGCFDCJID = 0;
				}
				if (HBKMKCBPJDI.CNJKBFMPOCJ() > 0)
				{
					AKLFPGMDKLA.EHBBFMCILPC.MCAGCFDCJID = AKLFPGMDKLA.EHBBFMCILPC.MCAGCFDCJID + 1;
					DPGJIJGOCIC.NFIDPOMCNLP(string.Concat(new string[]
					{
						"[LoadingTheme] free change spent: ",
						AKLFPGMDKLA.EHBBFMCILPC.MCAGCFDCJID.ToString(),
						"/",
						HBKMKCBPJDI.JDDPNJNGDHI().ToString(),
						" for month ",
						num.ToString()
					}));
				}
				else if (HBKMKCBPJDI.AGJOBEEDANM() > 0)
				{
					AKLFPGMDKLA.EHBBFMCILPC.EPIBEOCFEGA = AKLFPGMDKLA.EHBBFMCILPC.EPIBEOCFEGA - 1;
					DPGJIJGOCIC.NFIDPOMCNLP("[LoadingTheme] bonus free change spent, " + AKLFPGMDKLA.EHBBFMCILPC.EPIBEOCFEGA.ToString() + " left");
				}
				else
				{
					AKLFPGMDKLA.EHBBFMCILPC.MCAGCFDCJID = AKLFPGMDKLA.EHBBFMCILPC.MCAGCFDCJID + 1;
					DPGJIJGOCIC.ADFCDFHBDAF(string.Concat(new string[]
					{
						"[LoadingTheme] free change spent with none left: ",
						AKLFPGMDKLA.EHBBFMCILPC.MCAGCFDCJID.ToString(),
						"/",
						HBKMKCBPJDI.JDDPNJNGDHI().ToString(),
						" for month ",
						num.ToString()
					}));
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x06003269 RID: 12905 RVA: 0x00153634 File Offset: 0x00151834
	public static int CNJKBFMPOCJ()
	{
		int num = HBKMKCBPJDI.JDDPNJNGDHI() - HBKMKCBPJDI.IFPGACLLLDF();
		if (num < 0)
		{
			num = 0;
		}
		return num;
	}

	// Token: 0x04000F96 RID: 3990
	private const string KJEPDBDDOKF = "[LoadingTheme] ";

	// Token: 0x04000F97 RID: 3991
	public const string MKOGNDEFHFK = "onLoadingThemeSubscribeRequested";

	// Token: 0x04000F98 RID: 3992
	public static bool NBLBPEJOFPC;

	// Token: 0x04000F99 RID: 3993
	public const int LDCFJNHNELD = 59500;

	// Token: 0x04000F9A RID: 3994
	public const int DPCOAAHLCPO = 59600;
}
