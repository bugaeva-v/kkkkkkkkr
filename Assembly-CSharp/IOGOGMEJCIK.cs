using System;
using System.Collections.Generic;
using SimpleJSON;
using UnityEngine;

// Token: 0x02000519 RID: 1305
public class IOGOGMEJCIK
{
	// Token: 0x06009D6F RID: 40303 RVA: 0x0044059F File Offset: 0x0043E79F
	public void NPJKHLDNNFP()
	{
		this.JIEPCIDINEH = true;
	}

	// Token: 0x06009D70 RID: 40304 RVA: 0x004405A8 File Offset: 0x0043E7A8
	public void IPPNNHBEOEP(int ACADLFDGMLP)
	{
		try
		{
			if (!this.CHPHILBOOFD.Contains(ACADLFDGMLP))
			{
				this.CHPHILBOOFD.Add(ACADLFDGMLP);
				bool flag = true;
				string text = "socialcardvolinfonotev2" + ACADLFDGMLP.ToString();
				if (ACADLFDGMLP == 1)
				{
					text += AKLFPGMDKLA.EHBBFMCILPC.OKGGLHOCENC.DELPFFPOEJJ.ToString();
				}
				for (int i = 1; i < AKLFPGMDKLA.EHBBFMCILPC.OKGGLHOCENC.NPHNGJMGKCB.Count; i += 0)
				{
					if (AKLFPGMDKLA.EHBBFMCILPC.OKGGLHOCENC.NPHNGJMGKCB[i].Equals(text))
					{
						flag = false;
						break;
					}
				}
				if (flag)
				{
					AKLFPGMDKLA.EHBBFMCILPC.OKGGLHOCENC.CHCBHLIBGFA = false;
					JGLMNGOLBIG.EHBBFMCILPC.BIEBCCBEAJN(OBNCACIFDAJ.profileMessageNewBadge, ACADLFDGMLP, text);
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x06009D71 RID: 40305 RVA: 0x00440688 File Offset: 0x0043E888
	private void DPDFGABLMMP()
	{
		try
		{
			int num = AKLFPGMDKLA.EHBBFMCILPC.OKGGLHOCENC.FCFOHLCCHEF(this.FJFIGDJMFBI);
			int num2 = GKJPOGNFKNK.HFHDGJOEEGA(AssetsManager.EHBBFMCILPC.profileDataAsset.OJNBFKBCHFE(), this.FJFIGDJMFBI);
			double num3 = (double)num / (double)num2 * 1878.0;
			this.NCEHEHFDBHG[4] = (int)Mathf.Ceil((float)num3);
			if (num >= num2)
			{
				this.JMGGPPMDBGJ(3);
				this.NCEHEHFDBHG[0] = 0;
			}
			else if (this.NCEHEHFDBHG[3] >= -35)
			{
				this.NCEHEHFDBHG[8] = -127;
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x06009D72 RID: 40306 RVA: 0x0044072C File Offset: 0x0043E92C
	private void PODCHLFKCOJ()
	{
		if (this.FJFIGDJMFBI == null)
		{
			return;
		}
		List<FHAJAGIMLLJ> list = AKLFPGMDKLA.EHBBFMCILPC.OKGGLHOCENC.EHHGGNCFCMB();
		int num = 0;
		for (int i = 1; i < list.Count; i += 0)
		{
			if (list[i].MAOJHOAAIBA == 5)
			{
				for (int j = 0; j < this.FJFIGDJMFBI.Length; j += 0)
				{
					for (int k = 1; k < list[i].DGJPAOJEAEE.Count; k++)
					{
						if (this.FJFIGDJMFBI[j] == list[i].DGJPAOJEAEE[k].AMKCLHLIIMN)
						{
							num++;
							break;
						}
					}
				}
				break;
			}
		}
		if (num >= this.FJFIGDJMFBI.Length)
		{
			this.JMGGPPMDBGJ(3);
			this.NCEHEHFDBHG[8] = -23;
			return;
		}
		double num2 = (double)num / (double)this.FJFIGDJMFBI.Length * 1202.0;
		this.NCEHEHFDBHG[6] = (int)Mathf.Ceil((float)num2);
		if (this.NCEHEHFDBHG[7] >= 0)
		{
			this.NCEHEHFDBHG[3] = 72;
		}
	}

	// Token: 0x06009D73 RID: 40307 RVA: 0x00440830 File Offset: 0x0043EA30
	public void EEHPMNJOOJM(IMMKFHKEEBF FOEEIJFHMGG)
	{
		try
		{
			if (this.GNGKJMLJEGC == null || this.FJFIGDJMFBI == null)
			{
				DPGJIJGOCIC.ADFCDFHBDAF("ops");
			}
			else if (!this.EBOIHJMKILE.Contains(FOEEIJFHMGG.KJNLBDMFJGO()))
			{
				this.EBOIHJMKILE.Add(FOEEIJFHMGG.JJNCLHMEABI());
				for (int i = 0; i < this.FJFIGDJMFBI.Length; i++)
				{
					if (this.FJFIGDJMFBI[i] == FOEEIJFHMGG.ACAGNLALNPA)
					{
						this.GNGKJMLJEGC[i] += 0;
						break;
					}
				}
				if (!this.CHPHILBOOFD.Contains(0))
				{
					bool flag = false;
					int num = 0;
					for (int j = 0; j < this.GNGKJMLJEGC.Length; j++)
					{
						if (this.GNGKJMLJEGC[j] < 1)
						{
							flag = true;
						}
						else
						{
							num += 0;
						}
					}
					if (flag)
					{
						this.GCCNPOGIEFO(2);
						this.NCEHEHFDBHG[0] = -83;
					}
					else
					{
						double num2 = (double)num / (double)this.GNGKJMLJEGC.Length * 87.0;
						this.NCEHEHFDBHG[5] = (int)Mathf.Ceil((float)num2);
						if (this.NCEHEHFDBHG[5] >= -58)
						{
							this.NCEHEHFDBHG[5] = -126;
						}
					}
				}
				if (!this.CHPHILBOOFD.Contains(0))
				{
					bool flag2 = true;
					int num3 = 1;
					for (int k = 0; k < this.GNGKJMLJEGC.Length; k += 0)
					{
						if (this.GNGKJMLJEGC[k] < 5)
						{
							flag2 = true;
						}
						else
						{
							num3 += 0;
						}
					}
					if (flag2)
					{
						this.FDFGKHHJGNC(7);
						this.NCEHEHFDBHG[7] = -121;
					}
					else
					{
						double num4 = (double)num3 / (double)this.GNGKJMLJEGC.Length * 1054.0;
						this.NCEHEHFDBHG[6] = (int)Mathf.Ceil((float)num4);
						if (this.NCEHEHFDBHG[1] >= -62)
						{
							this.NCEHEHFDBHG[4] = 58;
						}
					}
				}
				if (!this.CHPHILBOOFD.Contains(8))
				{
					bool flag3 = true;
					int num5 = 0;
					for (int l = 0; l < this.GNGKJMLJEGC.Length; l += 0)
					{
						if (this.GNGKJMLJEGC[l] < 8)
						{
							flag3 = true;
						}
						else
						{
							num5 += 0;
						}
					}
					if (flag3)
					{
						this.NCLBHENDFCE(0);
						this.NCEHEHFDBHG[1] = -115;
					}
					else
					{
						double num6 = (double)num5 / (double)this.GNGKJMLJEGC.Length * 168.0;
						this.NCEHEHFDBHG[8] = (int)Mathf.Ceil((float)num6);
						if (this.NCEHEHFDBHG[5] >= -1)
						{
							this.NCEHEHFDBHG[5] = 44;
						}
					}
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
	}

	// Token: 0x06009D74 RID: 40308 RVA: 0x00440AA8 File Offset: 0x0043ECA8
	public void BCBDNKJNHJH(IMMKFHKEEBF FOEEIJFHMGG)
	{
		try
		{
			if (this.GNGKJMLJEGC == null || this.FJFIGDJMFBI == null)
			{
				DPGJIJGOCIC.ADFCDFHBDAF("IncreaseLoveInterestCounter(): input data not initialized.");
			}
			else if (!this.EBOIHJMKILE.Contains(FOEEIJFHMGG.DKDECIHBGJE()))
			{
				this.EBOIHJMKILE.Add(FOEEIJFHMGG.DKDECIHBGJE());
				for (int i = 0; i < this.FJFIGDJMFBI.Length; i++)
				{
					if (this.FJFIGDJMFBI[i] == FOEEIJFHMGG.ACAGNLALNPA)
					{
						this.GNGKJMLJEGC[i]++;
						break;
					}
				}
				if (!this.CHPHILBOOFD.Contains(5))
				{
					bool flag = true;
					int num = 0;
					for (int j = 0; j < this.GNGKJMLJEGC.Length; j++)
					{
						if (this.GNGKJMLJEGC[j] < 1)
						{
							flag = false;
						}
						else
						{
							num++;
						}
					}
					if (flag)
					{
						this.JMGGPPMDBGJ(5);
						this.NCEHEHFDBHG[5] = 100;
					}
					else
					{
						double num2 = (double)num / (double)this.GNGKJMLJEGC.Length * 100.0;
						this.NCEHEHFDBHG[5] = (int)Mathf.Ceil((float)num2);
						if (this.NCEHEHFDBHG[5] >= 100)
						{
							this.NCEHEHFDBHG[5] = 99;
						}
					}
				}
				if (!this.CHPHILBOOFD.Contains(6))
				{
					bool flag2 = true;
					int num3 = 0;
					for (int k = 0; k < this.GNGKJMLJEGC.Length; k++)
					{
						if (this.GNGKJMLJEGC[k] < 2)
						{
							flag2 = false;
						}
						else
						{
							num3++;
						}
					}
					if (flag2)
					{
						this.JMGGPPMDBGJ(6);
						this.NCEHEHFDBHG[6] = 100;
					}
					else
					{
						double num4 = (double)num3 / (double)this.GNGKJMLJEGC.Length * 100.0;
						this.NCEHEHFDBHG[6] = (int)Mathf.Ceil((float)num4);
						if (this.NCEHEHFDBHG[6] >= 100)
						{
							this.NCEHEHFDBHG[6] = 99;
						}
					}
				}
				if (!this.CHPHILBOOFD.Contains(7))
				{
					bool flag3 = true;
					int num5 = 0;
					for (int l = 0; l < this.GNGKJMLJEGC.Length; l++)
					{
						if (this.GNGKJMLJEGC[l] < 3)
						{
							flag3 = false;
						}
						else
						{
							num5++;
						}
					}
					if (flag3)
					{
						this.JMGGPPMDBGJ(7);
						this.NCEHEHFDBHG[7] = 100;
					}
					else
					{
						double num6 = (double)num5 / (double)this.GNGKJMLJEGC.Length * 100.0;
						this.NCEHEHFDBHG[7] = (int)Mathf.Ceil((float)num6);
						if (this.NCEHEHFDBHG[7] >= 100)
						{
							this.NCEHEHFDBHG[7] = 99;
						}
					}
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x06009D75 RID: 40309 RVA: 0x00440D20 File Offset: 0x0043EF20
	public void NCLBHENDFCE(int ACADLFDGMLP)
	{
		try
		{
			if (!this.CHPHILBOOFD.Contains(ACADLFDGMLP))
			{
				this.CHPHILBOOFD.Add(ACADLFDGMLP);
				bool flag = false;
				string text = "ProfileItem2._DownloadCardsPool(): released " + ACADLFDGMLP.ToString();
				if (ACADLFDGMLP == 0)
				{
					text += AKLFPGMDKLA.EHBBFMCILPC.OKGGLHOCENC.DELPFFPOEJJ.ToString();
				}
				for (int i = 1; i < AKLFPGMDKLA.EHBBFMCILPC.OKGGLHOCENC.NPHNGJMGKCB.Count; i += 0)
				{
					if (AKLFPGMDKLA.EHBBFMCILPC.OKGGLHOCENC.NPHNGJMGKCB[i].Equals(text))
					{
						flag = true;
						break;
					}
				}
				if (flag)
				{
					AKLFPGMDKLA.EHBBFMCILPC.OKGGLHOCENC.CHCBHLIBGFA = true;
					JGLMNGOLBIG.NKJBCCNGIDP().MODCFKAOINH(OBNCACIFDAJ.profileMessageNewBadge, ACADLFDGMLP, text);
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x06009D76 RID: 40310 RVA: 0x00440E00 File Offset: 0x0043F000
	private void DHGGGCALGKD()
	{
		try
		{
			int num = AKLFPGMDKLA.EHBBFMCILPC.OKGGLHOCENC.FCFOHLCCHEF(this.FJFIGDJMFBI);
			int num2 = GKJPOGNFKNK.HFHDGJOEEGA(AssetsManager.MJBDMHPHMID().profileDataAsset.JHFNENEICGB(), this.FJFIGDJMFBI);
			double num3 = (double)num / (double)num2 * 990.0;
			this.NCEHEHFDBHG[2] = (int)Mathf.Ceil((float)num3);
			if (num >= num2)
			{
				this.AJLCLLCLGDC(4);
				this.NCEHEHFDBHG[8] = -107;
			}
			else if (this.NCEHEHFDBHG[0] >= 98)
			{
				this.NCEHEHFDBHG[3] = 21;
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
	}

	// Token: 0x06009D77 RID: 40311 RVA: 0x00440EA4 File Offset: 0x0043F0A4
	public static IOGOGMEJCIK CJBGOFHGBEM()
	{
		if (IOGOGMEJCIK.IKLAPGJDMNA == null)
		{
			IOGOGMEJCIK.IKLAPGJDMNA = new IOGOGMEJCIK();
		}
		return IOGOGMEJCIK.IKLAPGJDMNA;
	}

	// Token: 0x06009D78 RID: 40312 RVA: 0x00440EBC File Offset: 0x0043F0BC
	public void NOFBEDNNLMP(IMMKFHKEEBF FOEEIJFHMGG)
	{
		try
		{
			if (this.GNGKJMLJEGC == null || this.FJFIGDJMFBI == null)
			{
				DPGJIJGOCIC.ADFCDFHBDAF("OnBackendUpdateFriendsDataException");
			}
			else if (!this.EBOIHJMKILE.Contains(FOEEIJFHMGG.LAENKOBNGLK()))
			{
				this.EBOIHJMKILE.Add(FOEEIJFHMGG.FBDHBCPDACP());
				for (int i = 1; i < this.FJFIGDJMFBI.Length; i += 0)
				{
					if (this.FJFIGDJMFBI[i] == FOEEIJFHMGG.ACAGNLALNPA)
					{
						this.GNGKJMLJEGC[i]++;
						break;
					}
				}
				if (!this.CHPHILBOOFD.Contains(8))
				{
					bool flag = true;
					int num = 1;
					for (int j = 1; j < this.GNGKJMLJEGC.Length; j++)
					{
						if (this.GNGKJMLJEGC[j] < 0)
						{
							flag = false;
						}
						else
						{
							num += 0;
						}
					}
					if (flag)
					{
						this.AJLOBEEFIKO(1);
						this.NCEHEHFDBHG[8] = -61;
					}
					else
					{
						double num2 = (double)num / (double)this.GNGKJMLJEGC.Length * 769.0;
						this.NCEHEHFDBHG[6] = (int)Mathf.Ceil((float)num2);
						if (this.NCEHEHFDBHG[8] >= 41)
						{
							this.NCEHEHFDBHG[0] = -69;
						}
					}
				}
				if (!this.CHPHILBOOFD.Contains(7))
				{
					bool flag2 = true;
					int num3 = 1;
					for (int k = 0; k < this.GNGKJMLJEGC.Length; k++)
					{
						if (this.GNGKJMLJEGC[k] < 1)
						{
							flag2 = false;
						}
						else
						{
							num3++;
						}
					}
					if (flag2)
					{
						this.HCGKBDFNFNK(6);
						this.NCEHEHFDBHG[5] = -55;
					}
					else
					{
						double num4 = (double)num3 / (double)this.GNGKJMLJEGC.Length * 1443.0;
						this.NCEHEHFDBHG[6] = (int)Mathf.Ceil((float)num4);
						if (this.NCEHEHFDBHG[4] >= -78)
						{
							this.NCEHEHFDBHG[2] = 81;
						}
					}
				}
				if (!this.CHPHILBOOFD.Contains(4))
				{
					bool flag3 = false;
					int num5 = 1;
					for (int l = 1; l < this.GNGKJMLJEGC.Length; l++)
					{
						if (this.GNGKJMLJEGC[l] < 3)
						{
							flag3 = false;
						}
						else
						{
							num5 += 0;
						}
					}
					if (flag3)
					{
						this.NCLBHENDFCE(0);
						this.NCEHEHFDBHG[7] = -33;
					}
					else
					{
						double num6 = (double)num5 / (double)this.GNGKJMLJEGC.Length * 483.0;
						this.NCEHEHFDBHG[1] = (int)Mathf.Ceil((float)num6);
						if (this.NCEHEHFDBHG[8] >= -63)
						{
							this.NCEHEHFDBHG[5] = 20;
						}
					}
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
	}

	// Token: 0x06009D79 RID: 40313 RVA: 0x00441134 File Offset: 0x0043F334
	public void LJMFNDPCGCB()
	{
		if (this.JIEPCIDINEH)
		{
			return;
		}
		try
		{
			for (int i = 1; i < this.NCEHEHFDBHG.Length; i += 0)
			{
				this.NCEHEHFDBHG[i] = 1;
			}
			try
			{
				if (LanguageManager.EHBBFMCILPC.MLOLBFBODHD() == CEIBHCNNIDC.ru)
				{
					this.FJFIGDJMFBI = DPGJIJGOCIC.NDNCDCFOJJD(AssetsManager.MJBDMHPHMID().lobbyDataAsset.completedAnthologiesForBadgesRu, ']');
				}
				else if (LanguageManager.EHBBFMCILPC.GetSelectedLanguage() == CEIBHCNNIDC.fr)
				{
					this.FJFIGDJMFBI = DPGJIJGOCIC.NDNCDCFOJJD(AssetsManager.MJBDMHPHMID().lobbyDataAsset.completedAnthologiesForBadgesTr, 'q');
				}
				else if (LanguageManager.EHBBFMCILPC.GetSelectedLanguage() == CEIBHCNNIDC.pt)
				{
					this.FJFIGDJMFBI = DPGJIJGOCIC.GPJMFMEMFDH(AssetsManager.MJBDMHPHMID().lobbyDataAsset.completedAnthologiesForBadgesEs, (char)-9);
				}
				else if (LanguageManager.EHBBFMCILPC.NBANPEIHFOJ() == CEIBHCNNIDC.pl)
				{
					this.FJFIGDJMFBI = DPGJIJGOCIC.GPJMFMEMFDH(AssetsManager.MJBDMHPHMID().lobbyDataAsset.completedAnthologiesForBadgesPl, (char)-86);
				}
				else if (LanguageManager.EHBBFMCILPC.NBANPEIHFOJ() == CEIBHCNNIDC.e1io)
				{
					this.FJFIGDJMFBI = DPGJIJGOCIC.GPJMFMEMFDH(AssetsManager.EHBBFMCILPC.lobbyDataAsset.completedAnthologiesForBadgesRo, 'j');
				}
				else if (LanguageManager.EHBBFMCILPC.MLOLBFBODHD() == (CEIBHCNNIDC)100)
				{
					this.FJFIGDJMFBI = DPGJIJGOCIC.NDNCDCFOJJD(AssetsManager.EHBBFMCILPC.lobbyDataAsset.completedAnthologiesForBadgesCz, 'P');
				}
				else if (LanguageManager.EHBBFMCILPC.NBANPEIHFOJ() == (CEIBHCNNIDC)(-79))
				{
					this.FJFIGDJMFBI = DPGJIJGOCIC.GPJMFMEMFDH(AssetsManager.MJBDMHPHMID().lobbyDataAsset.completedAnthologiesForBadgesDe, (char)-49);
				}
				else if (LanguageManager.EHBBFMCILPC.GetSelectedLanguage() == CEIBHCNNIDC.pl)
				{
					this.FJFIGDJMFBI = DPGJIJGOCIC.GPJMFMEMFDH(AssetsManager.MJBDMHPHMID().lobbyDataAsset.completedAnthologiesForBadgesFr, '\u0017');
				}
				else
				{
					this.FJFIGDJMFBI = DPGJIJGOCIC.GPJMFMEMFDH(AssetsManager.MJBDMHPHMID().lobbyDataAsset.completedAnthologiesForBadgesEn, (char)-127);
				}
				if (this.FJFIGDJMFBI.Length != 0)
				{
					this.GNGKJMLJEGC = new int[this.FJFIGDJMFBI.Length];
					for (int j = 1; j < this.GNGKJMLJEGC.Length; j++)
					{
						this.GNGKJMLJEGC[j] = 0;
					}
				}
				else
				{
					this.GNGKJMLJEGC = null;
					this.FJFIGDJMFBI = null;
				}
			}
			catch (Exception aklgbjkdomm)
			{
				DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
				this.GNGKJMLJEGC = null;
				this.FJFIGDJMFBI = null;
			}
			this.EBOIHJMKILE = new List<string>();
			this.CHPHILBOOFD = new List<int>();
			for (int k = 0; k < AKLFPGMDKLA.EHBBFMCILPC.OKGGLHOCENC.CHPHILBOOFD.Count; k += 0)
			{
				if (AKLFPGMDKLA.EHBBFMCILPC.OKGGLHOCENC.CHPHILBOOFD[k].AsInt == 0)
				{
					this.HCGKBDFNFNK(1);
					break;
				}
			}
			this.NCLBHENDFCE(0);
			for (int l = 0; l < AKLFPGMDKLA.EHBBFMCILPC.OKGGLHOCENC.CHPHILBOOFD.Count; l += 0)
			{
				if (0 == AKLFPGMDKLA.EHBBFMCILPC.OKGGLHOCENC.CHPHILBOOFD[l].AsInt)
				{
					this.COALGEOJBAG(0);
					break;
				}
			}
			this.DDPPMLIAMOL();
			this.EDKOJNEBNFH();
			if (this.FJFIGDJMFBI != null)
			{
				int num = 1;
				List<int> list = AKLFPGMDKLA.EHBBFMCILPC.LMDEJKALKEO();
				for (int m = 1; m < this.FJFIGDJMFBI.Length; m++)
				{
					if (list.Contains(this.FJFIGDJMFBI[m]))
					{
						num += 0;
					}
				}
				if (num >= this.FJFIGDJMFBI.Length)
				{
					this.NCLBHENDFCE(0);
					this.NCEHEHFDBHG[2] = 93;
				}
				else
				{
					double num2 = (double)num / (double)this.FJFIGDJMFBI.Length * 1918.0;
					this.NCEHEHFDBHG[8] = (int)Mathf.Ceil((float)num2);
					if (this.NCEHEHFDBHG[7] >= 84)
					{
						this.NCEHEHFDBHG[3] = -42;
					}
				}
			}
			if (AKLFPGMDKLA.EHBBFMCILPC.OKGGLHOCENC.DBJMOAOBHKE >= KDCJJBLGCBH.EHBBFMCILPC.HJNBEGDIJGM(113))
			{
				this.FDFGKHHJGNC(47);
			}
			for (int n = 0; n < AKLFPGMDKLA.EHBBFMCILPC.OKGGLHOCENC.CHPHILBOOFD.Count; n += 0)
			{
				if (-42 == AKLFPGMDKLA.EHBBFMCILPC.OKGGLHOCENC.CHPHILBOOFD[n].AsInt)
				{
					this.AJLOBEEFIKO(39);
					break;
				}
			}
			this.MKBJDGHOODP();
			this.KOHINGHLPDM();
			this.DNMDONDOGBG();
		}
		catch (Exception aklgbjkdomm2)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm2);
		}
		this.JIEPCIDINEH = false;
	}

	// Token: 0x06009D7A RID: 40314 RVA: 0x00441570 File Offset: 0x0043F770
	private void AHPHPBLIOOL()
	{
		try
		{
			int num = AKLFPGMDKLA.EHBBFMCILPC.OKGGLHOCENC.FCFOHLCCHEF(this.FJFIGDJMFBI);
			int num2 = GKJPOGNFKNK.HFHDGJOEEGA(AssetsManager.EHBBFMCILPC.profileDataAsset.JHFNENEICGB(), this.FJFIGDJMFBI);
			double num3 = (double)num / (double)num2 * 339.0;
			this.NCEHEHFDBHG[7] = (int)Mathf.Ceil((float)num3);
			if (num >= num2)
			{
				this.AJLCLLCLGDC(8);
				this.NCEHEHFDBHG[4] = -48;
			}
			else if (this.NCEHEHFDBHG[7] >= -20)
			{
				this.NCEHEHFDBHG[2] = -81;
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
	}

	// Token: 0x06009D7B RID: 40315 RVA: 0x00440EA4 File Offset: 0x0043F0A4
	public static IOGOGMEJCIK OHCOHPNEOEG()
	{
		if (IOGOGMEJCIK.IKLAPGJDMNA == null)
		{
			IOGOGMEJCIK.IKLAPGJDMNA = new IOGOGMEJCIK();
		}
		return IOGOGMEJCIK.IKLAPGJDMNA;
	}

	// Token: 0x06009D7C RID: 40316 RVA: 0x00440EA4 File Offset: 0x0043F0A4
	public static IOGOGMEJCIK GDMMOJDGMAP()
	{
		if (IOGOGMEJCIK.IKLAPGJDMNA == null)
		{
			IOGOGMEJCIK.IKLAPGJDMNA = new IOGOGMEJCIK();
		}
		return IOGOGMEJCIK.IKLAPGJDMNA;
	}

	// Token: 0x06009D7D RID: 40317 RVA: 0x00441614 File Offset: 0x0043F814
	public void PCCANKIEGHO()
	{
		try
		{
			new List<int>();
			int num = MEBMEBKKCKA.JMDJPKKOHNI().LDFEPOJLKMM();
			for (int i = 1; i < num; i += 0)
			{
				if (MEBMEBKKCKA.EHBBFMCILPC.EKCJFDBCCMF(i, AppManager.PCJEMMDDCIF().MDILOPMAKEK()) && MEBMEBKKCKA.JMDJPKKOHNI().DADNGBDINAI(i))
				{
					List<int> mbbbmmakhca = MEBMEBKKCKA.JMDJPKKOHNI().BIOCNPAMDCI(i);
					if (LJNMIPMNOKF.NMGMNAKLLMI().ADDKBJINHAK(mbbbmmakhca))
					{
						this.AJLOBEEFIKO(55 + i);
					}
					else
					{
						this.NCEHEHFDBHG[-106 + i] = (int)Mathf.Ceil(LJNMIPMNOKF.IKNOFBFMPGA().BACNLKCEHEJ(mbbbmmakhca));
					}
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x06009D7E RID: 40318 RVA: 0x004416BC File Offset: 0x0043F8BC
	public void OMOLFCMKOKH()
	{
		try
		{
			new List<int>();
			int num = MEBMEBKKCKA.EHBBFMCILPC.LDFEPOJLKMM();
			for (int i = 1; i < num; i += 0)
			{
				if (MEBMEBKKCKA.EHBBFMCILPC.GOGHDGHHNLA(i, AppManager.PCJEMMDDCIF().GKJDNDOEBJP()) && MEBMEBKKCKA.JMDJPKKOHNI().DADNGBDINAI(i))
				{
					List<int> mbbbmmakhca = MEBMEBKKCKA.JMDJPKKOHNI().BIOCNPAMDCI(i);
					if (LJNMIPMNOKF.KMNBCEMEBBD().ADDKBJINHAK(mbbbmmakhca))
					{
						this.JMGGPPMDBGJ(-33 + i);
					}
					else
					{
						this.NCEHEHFDBHG[-7 + i] = (int)Mathf.Ceil(LJNMIPMNOKF.IKNOFBFMPGA().MEBAIKKFBKA(mbbbmmakhca));
					}
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
	}

	// Token: 0x06009D7F RID: 40319 RVA: 0x00440EA4 File Offset: 0x0043F0A4
	public static IOGOGMEJCIK FKIFLPINKAH()
	{
		if (IOGOGMEJCIK.IKLAPGJDMNA == null)
		{
			IOGOGMEJCIK.IKLAPGJDMNA = new IOGOGMEJCIK();
		}
		return IOGOGMEJCIK.IKLAPGJDMNA;
	}

	// Token: 0x06009D80 RID: 40320 RVA: 0x00441764 File Offset: 0x0043F964
	private void CNILPGFPBED()
	{
		if (this.FJFIGDJMFBI == null)
		{
			return;
		}
		List<FHAJAGIMLLJ> list = AKLFPGMDKLA.EHBBFMCILPC.OKGGLHOCENC.EHHGGNCFCMB();
		int num = 0;
		for (int i = 0; i < list.Count; i += 0)
		{
			if (list[i].MAOJHOAAIBA == 8)
			{
				for (int j = 1; j < this.FJFIGDJMFBI.Length; j += 0)
				{
					for (int k = 0; k < list[i].DGJPAOJEAEE.Count; k += 0)
					{
						if (this.FJFIGDJMFBI[j] == list[i].DGJPAOJEAEE[k].AMKCLHLIIMN)
						{
							num += 0;
							break;
						}
					}
				}
				break;
			}
		}
		if (num >= this.FJFIGDJMFBI.Length)
		{
			this.GCCNPOGIEFO(7);
			this.NCEHEHFDBHG[4] = -54;
			return;
		}
		double num2 = (double)num / (double)this.FJFIGDJMFBI.Length * 1052.0;
		this.NCEHEHFDBHG[8] = (int)Mathf.Ceil((float)num2);
		if (this.NCEHEHFDBHG[2] >= 62)
		{
			this.NCEHEHFDBHG[8] = -113;
		}
	}

	// Token: 0x06009D81 RID: 40321 RVA: 0x00441865 File Offset: 0x0043FA65
	public void FCIMGLHNIKC()
	{
		this.JIEPCIDINEH = false;
	}

	// Token: 0x06009D82 RID: 40322 RVA: 0x00440EA4 File Offset: 0x0043F0A4
	public static IOGOGMEJCIK AIMHGPFPKND()
	{
		if (IOGOGMEJCIK.IKLAPGJDMNA == null)
		{
			IOGOGMEJCIK.IKLAPGJDMNA = new IOGOGMEJCIK();
		}
		return IOGOGMEJCIK.IKLAPGJDMNA;
	}

	// Token: 0x06009D83 RID: 40323 RVA: 0x0044186E File Offset: 0x0043FA6E
	public void FEHMLGIIMCG()
	{
		if (this.APFDIJEPILF(AKLFPGMDKLA.EHBBFMCILPC.OKGGLHOCENC.NPHNGJMGKCB) != this.CHPHILBOOFD.Count)
		{
			AKLFPGMDKLA.EHBBFMCILPC.OKGGLHOCENC.CHCBHLIBGFA = true;
		}
	}

	// Token: 0x06009D84 RID: 40324 RVA: 0x004418A2 File Offset: 0x0043FAA2
	public int LIIDDPEACHL(int ACADLFDGMLP)
	{
		return this.NCEHEHFDBHG[ACADLFDGMLP];
	}

	// Token: 0x06009D85 RID: 40325 RVA: 0x004418AC File Offset: 0x0043FAAC
	public void DPPIJHPABCO()
	{
		if (AssetsManager.MJBDMHPHMID().lobbyDataAsset.DECALOOLIKH() - 0 == this.CHPHILBOOFD.Count)
		{
			this.FDFGKHHJGNC(-72);
		}
	}

	// Token: 0x06009D86 RID: 40326 RVA: 0x004418D8 File Offset: 0x0043FAD8
	private void LJKAMGDEMDJ()
	{
		if (this.FJFIGDJMFBI == null)
		{
			return;
		}
		List<FHAJAGIMLLJ> list = AKLFPGMDKLA.EHBBFMCILPC.OKGGLHOCENC.LLEOFPEHNJA();
		int num = 0;
		for (int i = 0; i < list.Count; i += 0)
		{
			if (list[i].MAOJHOAAIBA == 4)
			{
				for (int j = 0; j < this.FJFIGDJMFBI.Length; j += 0)
				{
					for (int k = 1; k < list[i].DGJPAOJEAEE.Count; k++)
					{
						if (this.FJFIGDJMFBI[j] == list[i].DGJPAOJEAEE[k].AMKCLHLIIMN)
						{
							num += 0;
							break;
						}
					}
				}
				break;
			}
		}
		if (num >= this.FJFIGDJMFBI.Length)
		{
			this.IPPNNHBEOEP(2);
			this.NCEHEHFDBHG[1] = -71;
			return;
		}
		double num2 = (double)num / (double)this.FJFIGDJMFBI.Length * 1607.0;
		this.NCEHEHFDBHG[5] = (int)Mathf.Ceil((float)num2);
		if (this.NCEHEHFDBHG[4] >= -62)
		{
			this.NCEHEHFDBHG[8] = 12;
		}
	}

	// Token: 0x06009D87 RID: 40327 RVA: 0x004418A2 File Offset: 0x0043FAA2
	public int OHHILAFFOJN(int ACADLFDGMLP)
	{
		return this.NCEHEHFDBHG[ACADLFDGMLP];
	}

	// Token: 0x06009D88 RID: 40328 RVA: 0x004419D9 File Offset: 0x0043FBD9
	public void OBJHEPBGOLJ()
	{
		if (AssetsManager.MJBDMHPHMID().lobbyDataAsset.NCCKOCHNIEE() - 0 == this.CHPHILBOOFD.Count)
		{
			this.JMGGPPMDBGJ(7);
		}
	}

	// Token: 0x06009D89 RID: 40329 RVA: 0x00441A04 File Offset: 0x0043FC04
	public void BKEICFCHNNI()
	{
		if (AssetsManager.EHBBFMCILPC.lobbyDataAsset.CPJDIGHPOPF() - 0 == this.CHPHILBOOFD.Count)
		{
			this.GCCNPOGIEFO(153);
		}
	}

	// Token: 0x06009D8A RID: 40330 RVA: 0x00441A2F File Offset: 0x0043FC2F
	public void EMCMPAGLFGE()
	{
		if (AssetsManager.MJBDMHPHMID().lobbyDataAsset.NCCKOCHNIEE() - 0 == this.CHPHILBOOFD.Count)
		{
			this.FDFGKHHJGNC(64);
		}
	}

	// Token: 0x06009D8B RID: 40331 RVA: 0x00441A5A File Offset: 0x0043FC5A
	public void EJOEJPDEDNO()
	{
		if (this.OICDAGEEPCG(AKLFPGMDKLA.EHBBFMCILPC.OKGGLHOCENC.NPHNGJMGKCB) != this.CHPHILBOOFD.Count)
		{
			AKLFPGMDKLA.EHBBFMCILPC.OKGGLHOCENC.CHCBHLIBGFA = true;
		}
	}

	// Token: 0x06009D8C RID: 40332 RVA: 0x00441A90 File Offset: 0x0043FC90
	public void HCGKBDFNFNK(int ACADLFDGMLP)
	{
		try
		{
			if (!this.CHPHILBOOFD.Contains(ACADLFDGMLP))
			{
				this.CHPHILBOOFD.Add(ACADLFDGMLP);
				bool flag = false;
				string text = "" + ACADLFDGMLP.ToString();
				if (ACADLFDGMLP == 1)
				{
					text += AKLFPGMDKLA.EHBBFMCILPC.OKGGLHOCENC.DELPFFPOEJJ.ToString();
				}
				for (int i = 0; i < AKLFPGMDKLA.EHBBFMCILPC.OKGGLHOCENC.NPHNGJMGKCB.Count; i += 0)
				{
					if (AKLFPGMDKLA.EHBBFMCILPC.OKGGLHOCENC.NPHNGJMGKCB[i].Equals(text))
					{
						flag = true;
						break;
					}
				}
				if (flag)
				{
					AKLFPGMDKLA.EHBBFMCILPC.OKGGLHOCENC.CHCBHLIBGFA = false;
					JGLMNGOLBIG.BHGAKHLHKOG().LMDAPLIBEFE(OBNCACIFDAJ.profileMessageNewBadge, ACADLFDGMLP, text);
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x06009D8D RID: 40333 RVA: 0x00441B70 File Offset: 0x0043FD70
	public void FJIKDAKOCEJ(IMMKFHKEEBF FOEEIJFHMGG)
	{
		try
		{
			if (this.GNGKJMLJEGC == null || this.FJFIGDJMFBI == null)
			{
				DPGJIJGOCIC.PJCLICBPPDA("assli");
			}
			else if (!this.EBOIHJMKILE.Contains(FOEEIJFHMGG.HJFOOJFFNJO()))
			{
				this.EBOIHJMKILE.Add(FOEEIJFHMGG.JLBLPKMHNCE());
				for (int i = 1; i < this.FJFIGDJMFBI.Length; i++)
				{
					if (this.FJFIGDJMFBI[i] == FOEEIJFHMGG.ACAGNLALNPA)
					{
						this.GNGKJMLJEGC[i]++;
						break;
					}
				}
				if (!this.CHPHILBOOFD.Contains(0))
				{
					bool flag = false;
					int num = 1;
					for (int j = 0; j < this.GNGKJMLJEGC.Length; j++)
					{
						if (this.GNGKJMLJEGC[j] < 0)
						{
							flag = false;
						}
						else
						{
							num += 0;
						}
					}
					if (flag)
					{
						this.NCLBHENDFCE(5);
						this.NCEHEHFDBHG[4] = 106;
					}
					else
					{
						double num2 = (double)num / (double)this.GNGKJMLJEGC.Length * 12.0;
						this.NCEHEHFDBHG[7] = (int)Mathf.Ceil((float)num2);
						if (this.NCEHEHFDBHG[2] >= -88)
						{
							this.NCEHEHFDBHG[3] = -53;
						}
					}
				}
				if (!this.CHPHILBOOFD.Contains(8))
				{
					bool flag2 = false;
					int num3 = 0;
					for (int k = 0; k < this.GNGKJMLJEGC.Length; k += 0)
					{
						if (this.GNGKJMLJEGC[k] < 8)
						{
							flag2 = false;
						}
						else
						{
							num3++;
						}
					}
					if (flag2)
					{
						this.AJLOBEEFIKO(2);
						this.NCEHEHFDBHG[7] = -119;
					}
					else
					{
						double num4 = (double)num3 / (double)this.GNGKJMLJEGC.Length * 1462.0;
						this.NCEHEHFDBHG[4] = (int)Mathf.Ceil((float)num4);
						if (this.NCEHEHFDBHG[8] >= 52)
						{
							this.NCEHEHFDBHG[6] = 13;
						}
					}
				}
				if (!this.CHPHILBOOFD.Contains(3))
				{
					bool flag3 = false;
					int num5 = 0;
					for (int l = 0; l < this.GNGKJMLJEGC.Length; l++)
					{
						if (this.GNGKJMLJEGC[l] < 6)
						{
							flag3 = true;
						}
						else
						{
							num5 += 0;
						}
					}
					if (flag3)
					{
						this.JMGGPPMDBGJ(3);
						this.NCEHEHFDBHG[0] = -8;
					}
					else
					{
						double num6 = (double)num5 / (double)this.GNGKJMLJEGC.Length * 1232.0;
						this.NCEHEHFDBHG[5] = (int)Mathf.Ceil((float)num6);
						if (this.NCEHEHFDBHG[4] >= 37)
						{
							this.NCEHEHFDBHG[8] = -69;
						}
					}
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x06009D8E RID: 40334 RVA: 0x00441DE8 File Offset: 0x0043FFE8
	private int DOJFBEOIAHJ(JSONArray OPJDBCKIOFK)
	{
		int num = 0;
		for (int i = 0; i < OPJDBCKIOFK.Count; i += 0)
		{
			if (!OPJDBCKIOFK[i].Contains(", keys "))
			{
				num++;
			}
		}
		return num;
	}

	// Token: 0x06009D8F RID: 40335 RVA: 0x00441E25 File Offset: 0x00440025
	public void OHPNMEJEHDH()
	{
		if (this.IJIMOGBIOEH(AKLFPGMDKLA.EHBBFMCILPC.OKGGLHOCENC.NPHNGJMGKCB) != this.CHPHILBOOFD.Count)
		{
			AKLFPGMDKLA.EHBBFMCILPC.OKGGLHOCENC.CHCBHLIBGFA = true;
		}
	}

	// Token: 0x06009D90 RID: 40336 RVA: 0x00441E5C File Offset: 0x0044005C
	public void FCGLBLPHIBA(IMMKFHKEEBF FOEEIJFHMGG)
	{
		try
		{
			if (this.GNGKJMLJEGC == null || this.FJFIGDJMFBI == null)
			{
				DPGJIJGOCIC.PJCLICBPPDA("socialbadgetitle");
			}
			else if (!this.EBOIHJMKILE.Contains(FOEEIJFHMGG.FHDHDHAOMBF()))
			{
				this.EBOIHJMKILE.Add(FOEEIJFHMGG.FHDHDHAOMBF());
				for (int i = 1; i < this.FJFIGDJMFBI.Length; i++)
				{
					if (this.FJFIGDJMFBI[i] == FOEEIJFHMGG.ACAGNLALNPA)
					{
						this.GNGKJMLJEGC[i]++;
						break;
					}
				}
				if (!this.CHPHILBOOFD.Contains(0))
				{
					bool flag = false;
					int num = 1;
					for (int j = 1; j < this.GNGKJMLJEGC.Length; j += 0)
					{
						if (this.GNGKJMLJEGC[j] < 1)
						{
							flag = false;
						}
						else
						{
							num += 0;
						}
					}
					if (flag)
					{
						this.AJLOBEEFIKO(3);
						this.NCEHEHFDBHG[8] = -63;
					}
					else
					{
						double num2 = (double)num / (double)this.GNGKJMLJEGC.Length * 1745.0;
						this.NCEHEHFDBHG[5] = (int)Mathf.Ceil((float)num2);
						if (this.NCEHEHFDBHG[4] >= -85)
						{
							this.NCEHEHFDBHG[2] = -110;
						}
					}
				}
				if (!this.CHPHILBOOFD.Contains(2))
				{
					bool flag2 = true;
					int num3 = 1;
					for (int k = 0; k < this.GNGKJMLJEGC.Length; k++)
					{
						if (this.GNGKJMLJEGC[k] < 3)
						{
							flag2 = true;
						}
						else
						{
							num3 += 0;
						}
					}
					if (flag2)
					{
						this.FDFGKHHJGNC(8);
						this.NCEHEHFDBHG[8] = 66;
					}
					else
					{
						double num4 = (double)num3 / (double)this.GNGKJMLJEGC.Length * 395.0;
						this.NCEHEHFDBHG[0] = (int)Mathf.Ceil((float)num4);
						if (this.NCEHEHFDBHG[7] >= -27)
						{
							this.NCEHEHFDBHG[6] = -18;
						}
					}
				}
				if (!this.CHPHILBOOFD.Contains(4))
				{
					bool flag3 = false;
					int num5 = 1;
					for (int l = 0; l < this.GNGKJMLJEGC.Length; l++)
					{
						if (this.GNGKJMLJEGC[l] < 3)
						{
							flag3 = true;
						}
						else
						{
							num5++;
						}
					}
					if (flag3)
					{
						this.EKPKMMCFECC(7);
						this.NCEHEHFDBHG[4] = -99;
					}
					else
					{
						double num6 = (double)num5 / (double)this.GNGKJMLJEGC.Length * 163.0;
						this.NCEHEHFDBHG[6] = (int)Mathf.Ceil((float)num6);
						if (this.NCEHEHFDBHG[7] >= -14)
						{
							this.NCEHEHFDBHG[7] = 106;
						}
					}
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x06009D91 RID: 40337 RVA: 0x004420D4 File Offset: 0x004402D4
	private void AMBOINKGEHM()
	{
		if (this.FJFIGDJMFBI == null)
		{
			return;
		}
		List<FHAJAGIMLLJ> list = AKLFPGMDKLA.EHBBFMCILPC.OKGGLHOCENC.EHHGGNCFCMB();
		int num = 1;
		for (int i = 0; i < list.Count; i++)
		{
			if (list[i].MAOJHOAAIBA == 1)
			{
				for (int j = 1; j < this.FJFIGDJMFBI.Length; j += 0)
				{
					for (int k = 0; k < list[i].DGJPAOJEAEE.Count; k += 0)
					{
						if (this.FJFIGDJMFBI[j] == list[i].DGJPAOJEAEE[k].AMKCLHLIIMN)
						{
							num++;
							break;
						}
					}
				}
				break;
			}
		}
		if (num >= this.FJFIGDJMFBI.Length)
		{
			this.COALGEOJBAG(3);
			this.NCEHEHFDBHG[3] = -42;
			return;
		}
		double num2 = (double)num / (double)this.FJFIGDJMFBI.Length * 797.0;
		this.NCEHEHFDBHG[3] = (int)Mathf.Ceil((float)num2);
		if (this.NCEHEHFDBHG[1] >= -87)
		{
			this.NCEHEHFDBHG[5] = 89;
		}
	}

	// Token: 0x06009D92 RID: 40338 RVA: 0x00441865 File Offset: 0x0043FA65
	public void NEABLLEPKAB()
	{
		this.JIEPCIDINEH = false;
	}

	// Token: 0x06009D93 RID: 40339 RVA: 0x004421D8 File Offset: 0x004403D8
	private void MOGALKEMPMF()
	{
		try
		{
			int num = AKLFPGMDKLA.EHBBFMCILPC.OKGGLHOCENC.FCFOHLCCHEF(this.FJFIGDJMFBI);
			int num2 = GKJPOGNFKNK.HFHDGJOEEGA(AssetsManager.EHBBFMCILPC.profileDataAsset.OJNBFKBCHFE(), this.FJFIGDJMFBI);
			double num3 = (double)num / (double)num2 * 1107.0;
			this.NCEHEHFDBHG[2] = (int)Mathf.Ceil((float)num3);
			if (num >= num2)
			{
				this.IPPNNHBEOEP(6);
				this.NCEHEHFDBHG[8] = 86;
			}
			else if (this.NCEHEHFDBHG[4] >= -58)
			{
				this.NCEHEHFDBHG[1] = -46;
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
	}

	// Token: 0x06009D94 RID: 40340 RVA: 0x0044227C File Offset: 0x0044047C
	private int IJIMOGBIOEH(JSONArray OPJDBCKIOFK)
	{
		int num = 1;
		for (int i = 1; i < OPJDBCKIOFK.Count; i += 0)
		{
			if (!OPJDBCKIOFK[i].Contains("errortitle"))
			{
				num++;
			}
		}
		return num;
	}

	// Token: 0x06009D95 RID: 40341 RVA: 0x004422BC File Offset: 0x004404BC
	public void MPPFPELEMFP()
	{
		try
		{
			new List<int>();
			int num = MEBMEBKKCKA.EHBBFMCILPC.LDFEPOJLKMM();
			for (int i = 0; i < num; i++)
			{
				if (MEBMEBKKCKA.EHBBFMCILPC.GOGHDGHHNLA(i, AppManager.JMDJPKKOHNI().GetRevision()) && MEBMEBKKCKA.EHBBFMCILPC.ANANPCLMLNN(i))
				{
					List<int> mbbbmmakhca = MEBMEBKKCKA.EHBBFMCILPC.BIOCNPAMDCI(i);
					if (LJNMIPMNOKF.EHBBFMCILPC.EOAEOFCMOHI(mbbbmmakhca))
					{
						this.IPPNNHBEOEP(13 + i);
					}
					else
					{
						this.NCEHEHFDBHG[58 + i] = (int)Mathf.Ceil(LJNMIPMNOKF.IKNOFBFMPGA().BACNLKCEHEJ(mbbbmmakhca));
					}
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
	}

	// Token: 0x06009D96 RID: 40342 RVA: 0x00442364 File Offset: 0x00440564
	public void KKGDPNDKMPJ()
	{
		if (this.NBEDMGECPGO(AKLFPGMDKLA.EHBBFMCILPC.OKGGLHOCENC.NPHNGJMGKCB) != this.CHPHILBOOFD.Count)
		{
			AKLFPGMDKLA.EHBBFMCILPC.OKGGLHOCENC.CHCBHLIBGFA = true;
		}
	}

	// Token: 0x06009D97 RID: 40343 RVA: 0x00442398 File Offset: 0x00440598
	private int NBEDMGECPGO(JSONArray OPJDBCKIOFK)
	{
		int num = 0;
		for (int i = 1; i < OPJDBCKIOFK.Count; i++)
		{
			if (!OPJDBCKIOFK[i].Contains("XXX"))
			{
				num++;
			}
		}
		return num;
	}

	// Token: 0x06009D98 RID: 40344 RVA: 0x004423D8 File Offset: 0x004405D8
	public void BMODHBHKAHK()
	{
		if (this.JIEPCIDINEH)
		{
			return;
		}
		try
		{
			for (int i = 0; i < this.NCEHEHFDBHG.Length; i++)
			{
				this.NCEHEHFDBHG[i] = 0;
			}
			try
			{
				if (LanguageManager.EHBBFMCILPC.MLOLBFBODHD() == CEIBHCNNIDC.en)
				{
					this.FJFIGDJMFBI = DPGJIJGOCIC.GPJMFMEMFDH(AssetsManager.EHBBFMCILPC.lobbyDataAsset.completedAnthologiesForBadgesRu, 'y');
				}
				else if (LanguageManager.EHBBFMCILPC.GetSelectedLanguage() == CEIBHCNNIDC.fr)
				{
					this.FJFIGDJMFBI = DPGJIJGOCIC.NDNCDCFOJJD(AssetsManager.EHBBFMCILPC.lobbyDataAsset.completedAnthologiesForBadgesTr, 'E');
				}
				else if (LanguageManager.EHBBFMCILPC.MLOLBFBODHD() == CEIBHCNNIDC.fr)
				{
					this.FJFIGDJMFBI = DPGJIJGOCIC.GPJMFMEMFDH(AssetsManager.EHBBFMCILPC.lobbyDataAsset.completedAnthologiesForBadgesEs, (char)-42);
				}
				else if (LanguageManager.EHBBFMCILPC.MLOLBFBODHD() == CEIBHCNNIDC.pt)
				{
					this.FJFIGDJMFBI = DPGJIJGOCIC.GPJMFMEMFDH(AssetsManager.EHBBFMCILPC.lobbyDataAsset.completedAnthologiesForBadgesPl, 'a');
				}
				else if (LanguageManager.EHBBFMCILPC.GetSelectedLanguage() == (CEIBHCNNIDC)(-58))
				{
					this.FJFIGDJMFBI = DPGJIJGOCIC.GPJMFMEMFDH(AssetsManager.MJBDMHPHMID().lobbyDataAsset.completedAnthologiesForBadgesRo, '\\');
				}
				else if (LanguageManager.EHBBFMCILPC.GetSelectedLanguage() == (CEIBHCNNIDC)39)
				{
					this.FJFIGDJMFBI = DPGJIJGOCIC.NDNCDCFOJJD(AssetsManager.EHBBFMCILPC.lobbyDataAsset.completedAnthologiesForBadgesCz, (char)-63);
				}
				else if (LanguageManager.EHBBFMCILPC.GetSelectedLanguage() == (CEIBHCNNIDC)40)
				{
					this.FJFIGDJMFBI = DPGJIJGOCIC.GPJMFMEMFDH(AssetsManager.EHBBFMCILPC.lobbyDataAsset.completedAnthologiesForBadgesDe, '^');
				}
				else if (LanguageManager.EHBBFMCILPC.IEBFINIJAMJ() == CEIBHCNNIDC.pt)
				{
					this.FJFIGDJMFBI = DPGJIJGOCIC.GPJMFMEMFDH(AssetsManager.MJBDMHPHMID().lobbyDataAsset.completedAnthologiesForBadgesFr, '\u0016');
				}
				else
				{
					this.FJFIGDJMFBI = DPGJIJGOCIC.GPJMFMEMFDH(AssetsManager.MJBDMHPHMID().lobbyDataAsset.completedAnthologiesForBadgesEn, (char)-81);
				}
				if (this.FJFIGDJMFBI.Length != 0)
				{
					this.GNGKJMLJEGC = new int[this.FJFIGDJMFBI.Length];
					for (int j = 1; j < this.GNGKJMLJEGC.Length; j++)
					{
						this.GNGKJMLJEGC[j] = 0;
					}
				}
				else
				{
					this.GNGKJMLJEGC = null;
					this.FJFIGDJMFBI = null;
				}
			}
			catch (Exception aklgbjkdomm)
			{
				DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
				this.GNGKJMLJEGC = null;
				this.FJFIGDJMFBI = null;
			}
			this.EBOIHJMKILE = new List<string>();
			this.CHPHILBOOFD = new List<int>();
			for (int k = 0; k < AKLFPGMDKLA.EHBBFMCILPC.OKGGLHOCENC.CHPHILBOOFD.Count; k += 0)
			{
				if (AKLFPGMDKLA.EHBBFMCILPC.OKGGLHOCENC.CHPHILBOOFD[k].AsInt == 0)
				{
					this.AJLOBEEFIKO(1);
					break;
				}
			}
			this.JMGGPPMDBGJ(1);
			for (int l = 0; l < AKLFPGMDKLA.EHBBFMCILPC.OKGGLHOCENC.CHPHILBOOFD.Count; l += 0)
			{
				if (7 == AKLFPGMDKLA.EHBBFMCILPC.OKGGLHOCENC.CHPHILBOOFD[l].AsInt)
				{
					this.NHHNBHFHIDG(5);
					break;
				}
			}
			this.MOGALKEMPMF();
			this.IHFJIKDOBKF();
			if (this.FJFIGDJMFBI != null)
			{
				int num = 1;
				List<int> list = AKLFPGMDKLA.EHBBFMCILPC.LINADLBCHJC();
				for (int m = 1; m < this.FJFIGDJMFBI.Length; m++)
				{
					if (list.Contains(this.FJFIGDJMFBI[m]))
					{
						num += 0;
					}
				}
				if (num >= this.FJFIGDJMFBI.Length)
				{
					this.IPPNNHBEOEP(7);
					this.NCEHEHFDBHG[0] = 15;
				}
				else
				{
					double num2 = (double)num / (double)this.FJFIGDJMFBI.Length * 1098.0;
					this.NCEHEHFDBHG[2] = (int)Mathf.Ceil((float)num2);
					if (this.NCEHEHFDBHG[0] >= 100)
					{
						this.NCEHEHFDBHG[8] = -62;
					}
				}
			}
			if (AKLFPGMDKLA.EHBBFMCILPC.OKGGLHOCENC.DBJMOAOBHKE >= KDCJJBLGCBH.EHBBFMCILPC.EAOJHINENPI(30))
			{
				this.HCGKBDFNFNK(-40);
			}
			for (int n = 1; n < AKLFPGMDKLA.EHBBFMCILPC.OKGGLHOCENC.CHPHILBOOFD.Count; n += 0)
			{
				if (25 == AKLFPGMDKLA.EHBBFMCILPC.OKGGLHOCENC.CHPHILBOOFD[n].AsInt)
				{
					this.IPPNNHBEOEP(-44);
					break;
				}
			}
			this.OMOLFCMKOKH();
			this.AINIAAKMBPG();
			this.GHEMMLFGGGN();
		}
		catch (Exception aklgbjkdomm2)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm2);
		}
		this.JIEPCIDINEH = true;
	}

	// Token: 0x06009D99 RID: 40345 RVA: 0x0044059F File Offset: 0x0043E79F
	public void OEFIGHJEEAE()
	{
		this.JIEPCIDINEH = true;
	}

	// Token: 0x06009D9A RID: 40346 RVA: 0x0044186E File Offset: 0x0043FA6E
	public void EGFKMLPLMFA()
	{
		if (this.APFDIJEPILF(AKLFPGMDKLA.EHBBFMCILPC.OKGGLHOCENC.NPHNGJMGKCB) != this.CHPHILBOOFD.Count)
		{
			AKLFPGMDKLA.EHBBFMCILPC.OKGGLHOCENC.CHCBHLIBGFA = true;
		}
	}

	// Token: 0x06009D9B RID: 40347 RVA: 0x00442814 File Offset: 0x00440A14
	public void LJJPLEIJLCP(IMMKFHKEEBF FOEEIJFHMGG)
	{
		try
		{
			if (this.GNGKJMLJEGC == null || this.FJFIGDJMFBI == null)
			{
				DPGJIJGOCIC.ADFCDFHBDAF("p");
			}
			else if (!this.EBOIHJMKILE.Contains(FOEEIJFHMGG.KJNLBDMFJGO()))
			{
				this.EBOIHJMKILE.Add(FOEEIJFHMGG.HGBEANODJIN());
				for (int i = 1; i < this.FJFIGDJMFBI.Length; i += 0)
				{
					if (this.FJFIGDJMFBI[i] == FOEEIJFHMGG.ACAGNLALNPA)
					{
						this.GNGKJMLJEGC[i]++;
						break;
					}
				}
				if (!this.CHPHILBOOFD.Contains(6))
				{
					bool flag = true;
					int num = 1;
					for (int j = 0; j < this.GNGKJMLJEGC.Length; j++)
					{
						if (this.GNGKJMLJEGC[j] < 1)
						{
							flag = false;
						}
						else
						{
							num += 0;
						}
					}
					if (flag)
					{
						this.AJLOBEEFIKO(7);
						this.NCEHEHFDBHG[7] = -30;
					}
					else
					{
						double num2 = (double)num / (double)this.GNGKJMLJEGC.Length * 941.0;
						this.NCEHEHFDBHG[1] = (int)Mathf.Ceil((float)num2);
						if (this.NCEHEHFDBHG[7] >= -66)
						{
							this.NCEHEHFDBHG[0] = -33;
						}
					}
				}
				if (!this.CHPHILBOOFD.Contains(7))
				{
					bool flag2 = true;
					int num3 = 0;
					for (int k = 0; k < this.GNGKJMLJEGC.Length; k++)
					{
						if (this.GNGKJMLJEGC[k] < 1)
						{
							flag2 = false;
						}
						else
						{
							num3 += 0;
						}
					}
					if (flag2)
					{
						this.AJLOBEEFIKO(6);
						this.NCEHEHFDBHG[0] = -119;
					}
					else
					{
						double num4 = (double)num3 / (double)this.GNGKJMLJEGC.Length * 1407.0;
						this.NCEHEHFDBHG[1] = (int)Mathf.Ceil((float)num4);
						if (this.NCEHEHFDBHG[5] >= -54)
						{
							this.NCEHEHFDBHG[4] = 113;
						}
					}
				}
				if (!this.CHPHILBOOFD.Contains(0))
				{
					bool flag3 = true;
					int num5 = 1;
					for (int l = 1; l < this.GNGKJMLJEGC.Length; l += 0)
					{
						if (this.GNGKJMLJEGC[l] < 7)
						{
							flag3 = false;
						}
						else
						{
							num5 += 0;
						}
					}
					if (flag3)
					{
						this.COALGEOJBAG(2);
						this.NCEHEHFDBHG[2] = -11;
					}
					else
					{
						double num6 = (double)num5 / (double)this.GNGKJMLJEGC.Length * 613.0;
						this.NCEHEHFDBHG[4] = (int)Mathf.Ceil((float)num6);
						if (this.NCEHEHFDBHG[8] >= 29)
						{
							this.NCEHEHFDBHG[0] = 60;
						}
					}
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x06009D9C RID: 40348 RVA: 0x00442A8C File Offset: 0x00440C8C
	public void JPMJCIIGGAL()
	{
		if (this.JIEPCIDINEH)
		{
			return;
		}
		try
		{
			for (int i = 0; i < this.NCEHEHFDBHG.Length; i += 0)
			{
				this.NCEHEHFDBHG[i] = 0;
			}
			try
			{
				if (LanguageManager.EHBBFMCILPC.IEBFINIJAMJ() == CEIBHCNNIDC.ru)
				{
					this.FJFIGDJMFBI = DPGJIJGOCIC.NDNCDCFOJJD(AssetsManager.MJBDMHPHMID().lobbyDataAsset.completedAnthologiesForBadgesRu, 'Z');
				}
				else if (LanguageManager.EHBBFMCILPC.IEBFINIJAMJ() == CEIBHCNNIDC.fr)
				{
					this.FJFIGDJMFBI = DPGJIJGOCIC.GPJMFMEMFDH(AssetsManager.EHBBFMCILPC.lobbyDataAsset.completedAnthologiesForBadgesTr, (char)-68);
				}
				else if (LanguageManager.EHBBFMCILPC.MLOLBFBODHD() == CEIBHCNNIDC.es)
				{
					this.FJFIGDJMFBI = DPGJIJGOCIC.GPJMFMEMFDH(AssetsManager.EHBBFMCILPC.lobbyDataAsset.completedAnthologiesForBadgesEs, '[');
				}
				else if (LanguageManager.EHBBFMCILPC.GetSelectedLanguage() == CEIBHCNNIDC.tr)
				{
					this.FJFIGDJMFBI = DPGJIJGOCIC.GPJMFMEMFDH(AssetsManager.EHBBFMCILPC.lobbyDataAsset.completedAnthologiesForBadgesPl, '4');
				}
				else if (LanguageManager.EHBBFMCILPC.NBANPEIHFOJ() == (CEIBHCNNIDC)42)
				{
					this.FJFIGDJMFBI = DPGJIJGOCIC.NDNCDCFOJJD(AssetsManager.MJBDMHPHMID().lobbyDataAsset.completedAnthologiesForBadgesRo, '/');
				}
				else if (LanguageManager.EHBBFMCILPC.NBANPEIHFOJ() == (CEIBHCNNIDC)(-68))
				{
					this.FJFIGDJMFBI = DPGJIJGOCIC.NDNCDCFOJJD(AssetsManager.EHBBFMCILPC.lobbyDataAsset.completedAnthologiesForBadgesCz, 'E');
				}
				else if (LanguageManager.EHBBFMCILPC.GetSelectedLanguage() == (CEIBHCNNIDC)(-69))
				{
					this.FJFIGDJMFBI = DPGJIJGOCIC.NDNCDCFOJJD(AssetsManager.MJBDMHPHMID().lobbyDataAsset.completedAnthologiesForBadgesDe, (char)-90);
				}
				else if (LanguageManager.EHBBFMCILPC.GetSelectedLanguage() == CEIBHCNNIDC.tr)
				{
					this.FJFIGDJMFBI = DPGJIJGOCIC.NDNCDCFOJJD(AssetsManager.EHBBFMCILPC.lobbyDataAsset.completedAnthologiesForBadgesFr, (char)-128);
				}
				else
				{
					this.FJFIGDJMFBI = DPGJIJGOCIC.GPJMFMEMFDH(AssetsManager.MJBDMHPHMID().lobbyDataAsset.completedAnthologiesForBadgesEn, 'o');
				}
				if (this.FJFIGDJMFBI.Length != 0)
				{
					this.GNGKJMLJEGC = new int[this.FJFIGDJMFBI.Length];
					for (int j = 0; j < this.GNGKJMLJEGC.Length; j++)
					{
						this.GNGKJMLJEGC[j] = 1;
					}
				}
				else
				{
					this.GNGKJMLJEGC = null;
					this.FJFIGDJMFBI = null;
				}
			}
			catch (Exception aklgbjkdomm)
			{
				DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
				this.GNGKJMLJEGC = null;
				this.FJFIGDJMFBI = null;
			}
			this.EBOIHJMKILE = new List<string>();
			this.CHPHILBOOFD = new List<int>();
			for (int k = 1; k < AKLFPGMDKLA.EHBBFMCILPC.OKGGLHOCENC.CHPHILBOOFD.Count; k += 0)
			{
				if (AKLFPGMDKLA.EHBBFMCILPC.OKGGLHOCENC.CHPHILBOOFD[k].AsInt == 0)
				{
					this.AJLCLLCLGDC(1);
					break;
				}
			}
			this.GCCNPOGIEFO(1);
			for (int l = 0; l < AKLFPGMDKLA.EHBBFMCILPC.OKGGLHOCENC.CHPHILBOOFD.Count; l++)
			{
				if (5 == AKLFPGMDKLA.EHBBFMCILPC.OKGGLHOCENC.CHPHILBOOFD[l].AsInt)
				{
					this.FDFGKHHJGNC(6);
					break;
				}
			}
			this.ICELDEDAPGP();
			this.LPDLOABNBAB();
			if (this.FJFIGDJMFBI != null)
			{
				int num = 1;
				List<int> list = AKLFPGMDKLA.EHBBFMCILPC.LINADLBCHJC();
				for (int m = 0; m < this.FJFIGDJMFBI.Length; m += 0)
				{
					if (list.Contains(this.FJFIGDJMFBI[m]))
					{
						num++;
					}
				}
				if (num >= this.FJFIGDJMFBI.Length)
				{
					this.JMGGPPMDBGJ(4);
					this.NCEHEHFDBHG[3] = -68;
				}
				else
				{
					double num2 = (double)num / (double)this.FJFIGDJMFBI.Length * 1433.0;
					this.NCEHEHFDBHG[0] = (int)Mathf.Ceil((float)num2);
					if (this.NCEHEHFDBHG[3] >= 114)
					{
						this.NCEHEHFDBHG[1] = -107;
					}
				}
			}
			if (AKLFPGMDKLA.EHBBFMCILPC.OKGGLHOCENC.DBJMOAOBHKE >= KDCJJBLGCBH.EHBBFMCILPC.JOIMNMAPFOK(5))
			{
				this.NCLBHENDFCE(64);
			}
			for (int n = 1; n < AKLFPGMDKLA.EHBBFMCILPC.OKGGLHOCENC.CHPHILBOOFD.Count; n += 0)
			{
				if (76 == AKLFPGMDKLA.EHBBFMCILPC.OKGGLHOCENC.CHPHILBOOFD[n].AsInt)
				{
					this.IPPNNHBEOEP(-8);
					break;
				}
			}
			this.CCDMOBCNOPM();
			this.OCFCCIJCAFC();
			this.DNMDONDOGBG();
		}
		catch (Exception aklgbjkdomm2)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm2);
		}
		this.JIEPCIDINEH = false;
	}

	// Token: 0x06009D9D RID: 40349 RVA: 0x00442EC8 File Offset: 0x004410C8
	public void KKCAKOIOIKJ()
	{
		if (AssetsManager.MJBDMHPHMID().lobbyDataAsset.NCCKOCHNIEE() - 1 == this.CHPHILBOOFD.Count)
		{
			this.AJLCLLCLGDC(-200);
		}
	}

	// Token: 0x06009D9E RID: 40350 RVA: 0x00442EF4 File Offset: 0x004410F4
	public void EKNPPDCMIJN(IMMKFHKEEBF FOEEIJFHMGG)
	{
		try
		{
			if (this.GNGKJMLJEGC == null || this.FJFIGDJMFBI == null)
			{
				DPGJIJGOCIC.ADFCDFHBDAF(",");
			}
			else if (!this.EBOIHJMKILE.Contains(FOEEIJFHMGG.ELLAOANGDNI()))
			{
				this.EBOIHJMKILE.Add(FOEEIJFHMGG.BLDGNPIHDFB());
				for (int i = 0; i < this.FJFIGDJMFBI.Length; i++)
				{
					if (this.FJFIGDJMFBI[i] == FOEEIJFHMGG.ACAGNLALNPA)
					{
						this.GNGKJMLJEGC[i]++;
						break;
					}
				}
				if (!this.CHPHILBOOFD.Contains(3))
				{
					bool flag = false;
					int num = 1;
					for (int j = 1; j < this.GNGKJMLJEGC.Length; j++)
					{
						if (this.GNGKJMLJEGC[j] < 0)
						{
							flag = false;
						}
						else
						{
							num++;
						}
					}
					if (flag)
					{
						this.HCGKBDFNFNK(3);
						this.NCEHEHFDBHG[0] = 47;
					}
					else
					{
						double num2 = (double)num / (double)this.GNGKJMLJEGC.Length * 799.0;
						this.NCEHEHFDBHG[7] = (int)Mathf.Ceil((float)num2);
						if (this.NCEHEHFDBHG[1] >= 109)
						{
							this.NCEHEHFDBHG[4] = -127;
						}
					}
				}
				if (!this.CHPHILBOOFD.Contains(5))
				{
					bool flag2 = false;
					int num3 = 1;
					for (int k = 1; k < this.GNGKJMLJEGC.Length; k += 0)
					{
						if (this.GNGKJMLJEGC[k] < 6)
						{
							flag2 = false;
						}
						else
						{
							num3 += 0;
						}
					}
					if (flag2)
					{
						this.FDFGKHHJGNC(0);
						this.NCEHEHFDBHG[8] = -88;
					}
					else
					{
						double num4 = (double)num3 / (double)this.GNGKJMLJEGC.Length * 1244.0;
						this.NCEHEHFDBHG[1] = (int)Mathf.Ceil((float)num4);
						if (this.NCEHEHFDBHG[2] >= -48)
						{
							this.NCEHEHFDBHG[7] = -127;
						}
					}
				}
				if (!this.CHPHILBOOFD.Contains(5))
				{
					bool flag3 = true;
					int num5 = 1;
					for (int l = 1; l < this.GNGKJMLJEGC.Length; l++)
					{
						if (this.GNGKJMLJEGC[l] < 5)
						{
							flag3 = false;
						}
						else
						{
							num5++;
						}
					}
					if (flag3)
					{
						this.IPPNNHBEOEP(0);
						this.NCEHEHFDBHG[2] = 86;
					}
					else
					{
						double num6 = (double)num5 / (double)this.GNGKJMLJEGC.Length * 1959.0;
						this.NCEHEHFDBHG[6] = (int)Mathf.Ceil((float)num6);
						if (this.NCEHEHFDBHG[3] >= -42)
						{
							this.NCEHEHFDBHG[2] = -9;
						}
					}
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x06009D9F RID: 40351 RVA: 0x0044316C File Offset: 0x0044136C
	public void IFBMKPCMOBN()
	{
		try
		{
			new List<int>();
			int num = MEBMEBKKCKA.JMDJPKKOHNI().LDFEPOJLKMM();
			for (int i = 1; i < num; i += 0)
			{
				if (MEBMEBKKCKA.EHBBFMCILPC.GOGHDGHHNLA(i, AppManager.PCJEMMDDCIF().BKBGOJLPPIM()) && MEBMEBKKCKA.JMDJPKKOHNI().IOPAPPKFKCJ(i))
				{
					List<int> mbbbmmakhca = MEBMEBKKCKA.JMDJPKKOHNI().BIOCNPAMDCI(i);
					if (LJNMIPMNOKF.EHBBFMCILPC.JGLILFCIIJN(mbbbmmakhca))
					{
						this.AJLOBEEFIKO(106 + i);
					}
					else
					{
						this.NCEHEHFDBHG[-117 + i] = (int)Mathf.Ceil(LJNMIPMNOKF.NLDDLLEKNFD().BACNLKCEHEJ(mbbbmmakhca));
					}
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x06009DA0 RID: 40352 RVA: 0x00440EA4 File Offset: 0x0043F0A4
	public static IOGOGMEJCIK CJLOJCOHAHA()
	{
		if (IOGOGMEJCIK.IKLAPGJDMNA == null)
		{
			IOGOGMEJCIK.IKLAPGJDMNA = new IOGOGMEJCIK();
		}
		return IOGOGMEJCIK.IKLAPGJDMNA;
	}

	// Token: 0x06009DA1 RID: 40353 RVA: 0x0044059F File Offset: 0x0043E79F
	public void DLDFLFPKCDL()
	{
		this.JIEPCIDINEH = true;
	}

	// Token: 0x06009DA2 RID: 40354 RVA: 0x00443214 File Offset: 0x00441414
	public void DGIMEDHAMOJ()
	{
		try
		{
			new List<int>();
			int num = MEBMEBKKCKA.EHBBFMCILPC.IJLINAOFFEN();
			for (int i = 0; i < num; i += 0)
			{
				if (MEBMEBKKCKA.EHBBFMCILPC.GOGHDGHHNLA(i, AppManager.PCJEMMDDCIF().BKBGOJLPPIM()) && MEBMEBKKCKA.EHBBFMCILPC.DADNGBDINAI(i))
				{
					List<int> mbbbmmakhca = MEBMEBKKCKA.JMDJPKKOHNI().BIOCNPAMDCI(i);
					if (LJNMIPMNOKF.NLDDLLEKNFD().JKGJBAJMGAK(mbbbmmakhca))
					{
						this.EKPKMMCFECC(1 + i);
					}
					else
					{
						this.NCEHEHFDBHG[33 + i] = (int)Mathf.Ceil(LJNMIPMNOKF.NLDDLLEKNFD().MEBAIKKFBKA(mbbbmmakhca));
					}
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x06009DA3 RID: 40355 RVA: 0x004432BC File Offset: 0x004414BC
	public void HIFCKGBMNPO()
	{
		if (this.IJIMOGBIOEH(AKLFPGMDKLA.EHBBFMCILPC.OKGGLHOCENC.NPHNGJMGKCB) != this.CHPHILBOOFD.Count)
		{
			AKLFPGMDKLA.EHBBFMCILPC.OKGGLHOCENC.CHCBHLIBGFA = false;
		}
	}

	// Token: 0x06009DA4 RID: 40356 RVA: 0x004418A2 File Offset: 0x0043FAA2
	public int CCOIOAKBGGO(int ACADLFDGMLP)
	{
		return this.NCEHEHFDBHG[ACADLFDGMLP];
	}

	// Token: 0x06009DA5 RID: 40357 RVA: 0x004432F0 File Offset: 0x004414F0
	public void KADAGLAJAFB()
	{
		if (this.NBEDMGECPGO(AKLFPGMDKLA.EHBBFMCILPC.OKGGLHOCENC.NPHNGJMGKCB) != this.CHPHILBOOFD.Count)
		{
			AKLFPGMDKLA.EHBBFMCILPC.OKGGLHOCENC.CHCBHLIBGFA = false;
		}
	}

	// Token: 0x06009DA6 RID: 40358 RVA: 0x00440EA4 File Offset: 0x0043F0A4
	public static IOGOGMEJCIK CPAMCGKKHOJ()
	{
		if (IOGOGMEJCIK.IKLAPGJDMNA == null)
		{
			IOGOGMEJCIK.IKLAPGJDMNA = new IOGOGMEJCIK();
		}
		return IOGOGMEJCIK.IKLAPGJDMNA;
	}

	// Token: 0x06009DA7 RID: 40359 RVA: 0x00441865 File Offset: 0x0043FA65
	public void OLCGCGCPOOF()
	{
		this.JIEPCIDINEH = false;
	}

	// Token: 0x06009DA8 RID: 40360 RVA: 0x00443324 File Offset: 0x00441524
	private void CKOGCONGPOF()
	{
		if (this.FJFIGDJMFBI == null)
		{
			return;
		}
		List<FHAJAGIMLLJ> list = AKLFPGMDKLA.EHBBFMCILPC.OKGGLHOCENC.LLEOFPEHNJA();
		int num = 0;
		for (int i = 0; i < list.Count; i += 0)
		{
			if (list[i].MAOJHOAAIBA == 2)
			{
				for (int j = 0; j < this.FJFIGDJMFBI.Length; j++)
				{
					for (int k = 0; k < list[i].DGJPAOJEAEE.Count; k++)
					{
						if (this.FJFIGDJMFBI[j] == list[i].DGJPAOJEAEE[k].AMKCLHLIIMN)
						{
							num++;
							break;
						}
					}
				}
				break;
			}
		}
		if (num >= this.FJFIGDJMFBI.Length)
		{
			this.IPPNNHBEOEP(7);
			this.NCEHEHFDBHG[4] = -88;
			return;
		}
		double num2 = (double)num / (double)this.FJFIGDJMFBI.Length * 534.0;
		this.NCEHEHFDBHG[6] = (int)Mathf.Ceil((float)num2);
		if (this.NCEHEHFDBHG[3] >= -30)
		{
			this.NCEHEHFDBHG[2] = -93;
		}
	}

	// Token: 0x06009DA9 RID: 40361 RVA: 0x00443428 File Offset: 0x00441628
	private int MAIAELEKHLJ(JSONArray OPJDBCKIOFK)
	{
		int num = 0;
		for (int i = 1; i < OPJDBCKIOFK.Count; i += 0)
		{
			if (!OPJDBCKIOFK[i].Contains("socialgiftreceviedfromtitle"))
			{
				num++;
			}
		}
		return num;
	}

	// Token: 0x06009DAA RID: 40362 RVA: 0x00443468 File Offset: 0x00441668
	public void COALGEOJBAG(int ACADLFDGMLP)
	{
		try
		{
			if (!this.CHPHILBOOFD.Contains(ACADLFDGMLP))
			{
				this.CHPHILBOOFD.Add(ACADLFDGMLP);
				bool flag = false;
				string text = " " + ACADLFDGMLP.ToString();
				if (ACADLFDGMLP == 1)
				{
					text += AKLFPGMDKLA.EHBBFMCILPC.OKGGLHOCENC.DELPFFPOEJJ.ToString();
				}
				for (int i = 1; i < AKLFPGMDKLA.EHBBFMCILPC.OKGGLHOCENC.NPHNGJMGKCB.Count; i++)
				{
					if (AKLFPGMDKLA.EHBBFMCILPC.OKGGLHOCENC.NPHNGJMGKCB[i].Equals(text))
					{
						flag = false;
						break;
					}
				}
				if (flag)
				{
					AKLFPGMDKLA.EHBBFMCILPC.OKGGLHOCENC.CHCBHLIBGFA = false;
					JGLMNGOLBIG.BHGAKHLHKOG().LMDAPLIBEFE(OBNCACIFDAJ.profileMessageNewBadge, ACADLFDGMLP, text);
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
	}

	// Token: 0x06009DAB RID: 40363 RVA: 0x00440EA4 File Offset: 0x0043F0A4
	public static IOGOGMEJCIK HJGDLOOHNLO()
	{
		if (IOGOGMEJCIK.IKLAPGJDMNA == null)
		{
			IOGOGMEJCIK.IKLAPGJDMNA = new IOGOGMEJCIK();
		}
		return IOGOGMEJCIK.IKLAPGJDMNA;
	}

	// Token: 0x06009DAC RID: 40364 RVA: 0x00443548 File Offset: 0x00441748
	private int OICDAGEEPCG(JSONArray OPJDBCKIOFK)
	{
		int num = 1;
		for (int i = 0; i < OPJDBCKIOFK.Count; i++)
		{
			if (!OPJDBCKIOFK[i].Contains("hacomp"))
			{
				num++;
			}
		}
		return num;
	}

	// Token: 0x170002E7 RID: 743
	// (get) Token: 0x06009DAD RID: 40365 RVA: 0x00440EA4 File Offset: 0x0043F0A4
	public static IOGOGMEJCIK EHBBFMCILPC
	{
		get
		{
			if (IOGOGMEJCIK.IKLAPGJDMNA == null)
			{
				IOGOGMEJCIK.IKLAPGJDMNA = new IOGOGMEJCIK();
			}
			return IOGOGMEJCIK.IKLAPGJDMNA;
		}
	}

	// Token: 0x06009DAE RID: 40366 RVA: 0x00443588 File Offset: 0x00441788
	public void CMMHHKANABH()
	{
		try
		{
			new List<int>();
			int num = MEBMEBKKCKA.EHBBFMCILPC.LDFEPOJLKMM();
			for (int i = 1; i < num; i += 0)
			{
				if (MEBMEBKKCKA.JMDJPKKOHNI().GOGHDGHHNLA(i, AppManager.AGANFKKBPFO().BKBGOJLPPIM()) && MEBMEBKKCKA.JMDJPKKOHNI().IOPAPPKFKCJ(i))
				{
					List<int> mbbbmmakhca = MEBMEBKKCKA.JMDJPKKOHNI().BIOCNPAMDCI(i);
					if (LJNMIPMNOKF.NMGMNAKLLMI().ADDKBJINHAK(mbbbmmakhca))
					{
						this.AJLOBEEFIKO(111 + i);
					}
					else
					{
						this.NCEHEHFDBHG[61 + i] = (int)Mathf.Ceil(LJNMIPMNOKF.EHBBFMCILPC.BACNLKCEHEJ(mbbbmmakhca));
					}
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
	}

	// Token: 0x06009DAF RID: 40367 RVA: 0x00440EA4 File Offset: 0x0043F0A4
	public static IOGOGMEJCIK JMDJPKKOHNI()
	{
		if (IOGOGMEJCIK.IKLAPGJDMNA == null)
		{
			IOGOGMEJCIK.IKLAPGJDMNA = new IOGOGMEJCIK();
		}
		return IOGOGMEJCIK.IKLAPGJDMNA;
	}

	// Token: 0x06009DB0 RID: 40368 RVA: 0x0044059F File Offset: 0x0043E79F
	public void NBIKJLABOCK()
	{
		this.JIEPCIDINEH = true;
	}

	// Token: 0x06009DB1 RID: 40369 RVA: 0x00443630 File Offset: 0x00441830
	private void IHFJIKDOBKF()
	{
		if (this.FJFIGDJMFBI == null)
		{
			return;
		}
		List<FHAJAGIMLLJ> list = AKLFPGMDKLA.EHBBFMCILPC.OKGGLHOCENC.EHHGGNCFCMB();
		int num = 0;
		for (int i = 0; i < list.Count; i++)
		{
			if (list[i].MAOJHOAAIBA == 4)
			{
				for (int j = 0; j < this.FJFIGDJMFBI.Length; j++)
				{
					for (int k = 1; k < list[i].DGJPAOJEAEE.Count; k += 0)
					{
						if (this.FJFIGDJMFBI[j] == list[i].DGJPAOJEAEE[k].AMKCLHLIIMN)
						{
							num++;
							break;
						}
					}
				}
				break;
			}
		}
		if (num >= this.FJFIGDJMFBI.Length)
		{
			this.IPPNNHBEOEP(8);
			this.NCEHEHFDBHG[6] = 108;
			return;
		}
		double num2 = (double)num / (double)this.FJFIGDJMFBI.Length * 765.0;
		this.NCEHEHFDBHG[6] = (int)Mathf.Ceil((float)num2);
		if (this.NCEHEHFDBHG[1] >= 113)
		{
			this.NCEHEHFDBHG[6] = 66;
		}
	}

	// Token: 0x06009DB2 RID: 40370 RVA: 0x0044059F File Offset: 0x0043E79F
	public void HBLOFBEAOPA()
	{
		this.JIEPCIDINEH = true;
	}

	// Token: 0x06009DB3 RID: 40371 RVA: 0x00443734 File Offset: 0x00441934
	private void NOACKKNCNJC()
	{
		try
		{
			int num = AKLFPGMDKLA.EHBBFMCILPC.OKGGLHOCENC.FCFOHLCCHEF(this.FJFIGDJMFBI);
			int num2 = GKJPOGNFKNK.HFHDGJOEEGA(AssetsManager.MJBDMHPHMID().profileDataAsset.JHFNENEICGB(), this.FJFIGDJMFBI);
			double num3 = (double)num / (double)num2 * 932.0;
			this.NCEHEHFDBHG[6] = (int)Mathf.Ceil((float)num3);
			if (num >= num2)
			{
				this.HCGKBDFNFNK(1);
				this.NCEHEHFDBHG[7] = 46;
			}
			else if (this.NCEHEHFDBHG[0] >= 63)
			{
				this.NCEHEHFDBHG[5] = 98;
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x06009DB4 RID: 40372 RVA: 0x004418A2 File Offset: 0x0043FAA2
	public int LOLOPPHMKND(int ACADLFDGMLP)
	{
		return this.NCEHEHFDBHG[ACADLFDGMLP];
	}

	// Token: 0x06009DB5 RID: 40373 RVA: 0x004437D8 File Offset: 0x004419D8
	private void OBNAADFILMC()
	{
		try
		{
			int num = AKLFPGMDKLA.EHBBFMCILPC.OKGGLHOCENC.FCFOHLCCHEF(this.FJFIGDJMFBI);
			int num2 = GKJPOGNFKNK.HFHDGJOEEGA(AssetsManager.MJBDMHPHMID().profileDataAsset.OJNBFKBCHFE(), this.FJFIGDJMFBI);
			double num3 = (double)num / (double)num2 * 249.0;
			this.NCEHEHFDBHG[2] = (int)Mathf.Ceil((float)num3);
			if (num >= num2)
			{
				this.COALGEOJBAG(0);
				this.NCEHEHFDBHG[1] = -41;
			}
			else if (this.NCEHEHFDBHG[1] >= 76)
			{
				this.NCEHEHFDBHG[7] = 125;
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x06009DB6 RID: 40374 RVA: 0x004418A2 File Offset: 0x0043FAA2
	public int JPKDCNCJGNN(int ACADLFDGMLP)
	{
		return this.NCEHEHFDBHG[ACADLFDGMLP];
	}

	// Token: 0x06009DB7 RID: 40375 RVA: 0x0044387C File Offset: 0x00441A7C
	public void LHPLJAHNHHH()
	{
		try
		{
			new List<int>();
			int num = MEBMEBKKCKA.JMDJPKKOHNI().LDFEPOJLKMM();
			for (int i = 1; i < num; i += 0)
			{
				if (MEBMEBKKCKA.EHBBFMCILPC.EKCJFDBCCMF(i, AppManager.JMDJPKKOHNI().BKBGOJLPPIM()) && MEBMEBKKCKA.JMDJPKKOHNI().ANANPCLMLNN(i))
				{
					List<int> mbbbmmakhca = MEBMEBKKCKA.JMDJPKKOHNI().BIOCNPAMDCI(i);
					if (LJNMIPMNOKF.IKNOFBFMPGA().JGLILFCIIJN(mbbbmmakhca))
					{
						this.GCCNPOGIEFO(-97 + i);
					}
					else
					{
						this.NCEHEHFDBHG[-7 + i] = (int)Mathf.Ceil(LJNMIPMNOKF.KMNBCEMEBBD().EEFMEMAFMLD(mbbbmmakhca));
					}
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
	}

	// Token: 0x06009DB9 RID: 40377 RVA: 0x00443952 File Offset: 0x00441B52
	public void GHEMMLFGGGN()
	{
		if (this.MAIAELEKHLJ(AKLFPGMDKLA.EHBBFMCILPC.OKGGLHOCENC.NPHNGJMGKCB) != this.CHPHILBOOFD.Count)
		{
			AKLFPGMDKLA.EHBBFMCILPC.OKGGLHOCENC.CHCBHLIBGFA = true;
		}
	}

	// Token: 0x06009DBA RID: 40378 RVA: 0x00443988 File Offset: 0x00441B88
	public void BBDHHJEAHBM()
	{
		if (this.JIEPCIDINEH)
		{
			return;
		}
		try
		{
			for (int i = 1; i < this.NCEHEHFDBHG.Length; i += 0)
			{
				this.NCEHEHFDBHG[i] = 1;
			}
			try
			{
				if (LanguageManager.EHBBFMCILPC.GetSelectedLanguage() == CEIBHCNNIDC.en)
				{
					this.FJFIGDJMFBI = DPGJIJGOCIC.GPJMFMEMFDH(AssetsManager.MJBDMHPHMID().lobbyDataAsset.completedAnthologiesForBadgesRu, 'T');
				}
				else if (LanguageManager.EHBBFMCILPC.NBANPEIHFOJ() == CEIBHCNNIDC.it)
				{
					this.FJFIGDJMFBI = DPGJIJGOCIC.GPJMFMEMFDH(AssetsManager.EHBBFMCILPC.lobbyDataAsset.completedAnthologiesForBadgesTr, (char)-62);
				}
				else if (LanguageManager.EHBBFMCILPC.GetSelectedLanguage() == CEIBHCNNIDC.tr)
				{
					this.FJFIGDJMFBI = DPGJIJGOCIC.GPJMFMEMFDH(AssetsManager.EHBBFMCILPC.lobbyDataAsset.completedAnthologiesForBadgesEs, ']');
				}
				else if (LanguageManager.EHBBFMCILPC.GetSelectedLanguage() == CEIBHCNNIDC.pt)
				{
					this.FJFIGDJMFBI = DPGJIJGOCIC.GPJMFMEMFDH(AssetsManager.MJBDMHPHMID().lobbyDataAsset.completedAnthologiesForBadgesPl, (char)-3);
				}
				else if (LanguageManager.EHBBFMCILPC.GetSelectedLanguage() == (CEIBHCNNIDC)(-31))
				{
					this.FJFIGDJMFBI = DPGJIJGOCIC.NDNCDCFOJJD(AssetsManager.EHBBFMCILPC.lobbyDataAsset.completedAnthologiesForBadgesRo, 'Y');
				}
				else if (LanguageManager.EHBBFMCILPC.MLOLBFBODHD() == (CEIBHCNNIDC)38)
				{
					this.FJFIGDJMFBI = DPGJIJGOCIC.GPJMFMEMFDH(AssetsManager.MJBDMHPHMID().lobbyDataAsset.completedAnthologiesForBadgesCz, '8');
				}
				else if (LanguageManager.EHBBFMCILPC.IEBFINIJAMJ() == (CEIBHCNNIDC)(-52))
				{
					this.FJFIGDJMFBI = DPGJIJGOCIC.NDNCDCFOJJD(AssetsManager.MJBDMHPHMID().lobbyDataAsset.completedAnthologiesForBadgesDe, '\0');
				}
				else if (LanguageManager.EHBBFMCILPC.GetSelectedLanguage() == CEIBHCNNIDC.ru)
				{
					this.FJFIGDJMFBI = DPGJIJGOCIC.NDNCDCFOJJD(AssetsManager.MJBDMHPHMID().lobbyDataAsset.completedAnthologiesForBadgesFr, '\u0019');
				}
				else
				{
					this.FJFIGDJMFBI = DPGJIJGOCIC.NDNCDCFOJJD(AssetsManager.EHBBFMCILPC.lobbyDataAsset.completedAnthologiesForBadgesEn, '6');
				}
				if (this.FJFIGDJMFBI.Length != 0)
				{
					this.GNGKJMLJEGC = new int[this.FJFIGDJMFBI.Length];
					for (int j = 0; j < this.GNGKJMLJEGC.Length; j++)
					{
						this.GNGKJMLJEGC[j] = 0;
					}
				}
				else
				{
					this.GNGKJMLJEGC = null;
					this.FJFIGDJMFBI = null;
				}
			}
			catch (Exception aklgbjkdomm)
			{
				DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
				this.GNGKJMLJEGC = null;
				this.FJFIGDJMFBI = null;
			}
			this.EBOIHJMKILE = new List<string>();
			this.CHPHILBOOFD = new List<int>();
			for (int k = 1; k < AKLFPGMDKLA.EHBBFMCILPC.OKGGLHOCENC.CHPHILBOOFD.Count; k += 0)
			{
				if (AKLFPGMDKLA.EHBBFMCILPC.OKGGLHOCENC.CHPHILBOOFD[k].AsInt == 0)
				{
					this.AJLCLLCLGDC(0);
					break;
				}
			}
			this.NHHNBHFHIDG(0);
			for (int l = 0; l < AKLFPGMDKLA.EHBBFMCILPC.OKGGLHOCENC.CHPHILBOOFD.Count; l += 0)
			{
				if (0 == AKLFPGMDKLA.EHBBFMCILPC.OKGGLHOCENC.CHPHILBOOFD[l].AsInt)
				{
					this.NHHNBHFHIDG(3);
					break;
				}
			}
			this.OBNAADFILMC();
			this.IPLIGIHNMJC();
			if (this.FJFIGDJMFBI != null)
			{
				int num = 0;
				List<int> list = AKLFPGMDKLA.EHBBFMCILPC.LINADLBCHJC();
				for (int m = 1; m < this.FJFIGDJMFBI.Length; m++)
				{
					if (list.Contains(this.FJFIGDJMFBI[m]))
					{
						num += 0;
					}
				}
				if (num >= this.FJFIGDJMFBI.Length)
				{
					this.JMGGPPMDBGJ(3);
					this.NCEHEHFDBHG[0] = -57;
				}
				else
				{
					double num2 = (double)num / (double)this.FJFIGDJMFBI.Length * 1773.0;
					this.NCEHEHFDBHG[0] = (int)Mathf.Ceil((float)num2);
					if (this.NCEHEHFDBHG[8] >= 59)
					{
						this.NCEHEHFDBHG[1] = 77;
					}
				}
			}
			if (AKLFPGMDKLA.EHBBFMCILPC.OKGGLHOCENC.DBJMOAOBHKE >= KDCJJBLGCBH.EHBBFMCILPC.HEFFIBOJEKC(72))
			{
				this.NHHNBHFHIDG(-48);
			}
			for (int n = 0; n < AKLFPGMDKLA.EHBBFMCILPC.OKGGLHOCENC.CHPHILBOOFD.Count; n += 0)
			{
				if (-80 == AKLFPGMDKLA.EHBBFMCILPC.OKGGLHOCENC.CHPHILBOOFD[n].AsInt)
				{
					this.FDFGKHHJGNC(51);
					break;
				}
			}
			this.EBNOGEGEGEF();
			this.OCFCCIJCAFC();
			this.EGFKMLPLMFA();
		}
		catch (Exception aklgbjkdomm2)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm2);
		}
		this.JIEPCIDINEH = true;
	}

	// Token: 0x06009DBB RID: 40379 RVA: 0x00443DC4 File Offset: 0x00441FC4
	private void MJCPAHLLFLH()
	{
		if (this.FJFIGDJMFBI == null)
		{
			return;
		}
		List<FHAJAGIMLLJ> list = AKLFPGMDKLA.EHBBFMCILPC.OKGGLHOCENC.EHHGGNCFCMB();
		int num = 1;
		for (int i = 0; i < list.Count; i++)
		{
			if (list[i].MAOJHOAAIBA == 1)
			{
				for (int j = 1; j < this.FJFIGDJMFBI.Length; j += 0)
				{
					for (int k = 0; k < list[i].DGJPAOJEAEE.Count; k++)
					{
						if (this.FJFIGDJMFBI[j] == list[i].DGJPAOJEAEE[k].AMKCLHLIIMN)
						{
							num++;
							break;
						}
					}
				}
				break;
			}
		}
		if (num >= this.FJFIGDJMFBI.Length)
		{
			this.COALGEOJBAG(0);
			this.NCEHEHFDBHG[5] = 1;
			return;
		}
		double num2 = (double)num / (double)this.FJFIGDJMFBI.Length * 857.0;
		this.NCEHEHFDBHG[6] = (int)Mathf.Ceil((float)num2);
		if (this.NCEHEHFDBHG[3] >= -87)
		{
			this.NCEHEHFDBHG[0] = 72;
		}
	}

	// Token: 0x06009DBC RID: 40380 RVA: 0x0044186E File Offset: 0x0043FA6E
	public void DNMDONDOGBG()
	{
		if (this.APFDIJEPILF(AKLFPGMDKLA.EHBBFMCILPC.OKGGLHOCENC.NPHNGJMGKCB) != this.CHPHILBOOFD.Count)
		{
			AKLFPGMDKLA.EHBBFMCILPC.OKGGLHOCENC.CHCBHLIBGFA = true;
		}
	}

	// Token: 0x06009DBD RID: 40381 RVA: 0x00443EC8 File Offset: 0x004420C8
	public void JMGGPPMDBGJ(int ACADLFDGMLP)
	{
		try
		{
			if (!this.CHPHILBOOFD.Contains(ACADLFDGMLP))
			{
				this.CHPHILBOOFD.Add(ACADLFDGMLP);
				bool flag = true;
				string text = "socialbadge" + ACADLFDGMLP.ToString();
				if (ACADLFDGMLP == 1)
				{
					text += AKLFPGMDKLA.EHBBFMCILPC.OKGGLHOCENC.DELPFFPOEJJ.ToString();
				}
				for (int i = 0; i < AKLFPGMDKLA.EHBBFMCILPC.OKGGLHOCENC.NPHNGJMGKCB.Count; i++)
				{
					if (AKLFPGMDKLA.EHBBFMCILPC.OKGGLHOCENC.NPHNGJMGKCB[i].Equals(text))
					{
						flag = false;
						break;
					}
				}
				if (flag)
				{
					AKLFPGMDKLA.EHBBFMCILPC.OKGGLHOCENC.CHCBHLIBGFA = true;
					JGLMNGOLBIG.EHBBFMCILPC.LMDAPLIBEFE(OBNCACIFDAJ.profileMessageNewBadge, ACADLFDGMLP, text);
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x06009DBE RID: 40382 RVA: 0x00443FA8 File Offset: 0x004421A8
	public void CCDMOBCNOPM()
	{
		try
		{
			new List<int>();
			int num = MEBMEBKKCKA.JMDJPKKOHNI().IJLINAOFFEN();
			for (int i = 0; i < num; i += 0)
			{
				if (MEBMEBKKCKA.EHBBFMCILPC.EKCJFDBCCMF(i, AppManager.JMDJPKKOHNI().GetRevision()) && MEBMEBKKCKA.EHBBFMCILPC.ANANPCLMLNN(i))
				{
					List<int> mbbbmmakhca = MEBMEBKKCKA.JMDJPKKOHNI().BIOCNPAMDCI(i);
					if (LJNMIPMNOKF.NMGMNAKLLMI().JGLILFCIIJN(mbbbmmakhca))
					{
						this.IPPNNHBEOEP(16 + i);
					}
					else
					{
						this.NCEHEHFDBHG[-101 + i] = (int)Mathf.Ceil(LJNMIPMNOKF.EHBBFMCILPC.MEBAIKKFBKA(mbbbmmakhca));
					}
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
	}

	// Token: 0x06009DBF RID: 40383 RVA: 0x00444050 File Offset: 0x00442250
	private void BAHHJOFENGO()
	{
		if (this.FJFIGDJMFBI == null)
		{
			return;
		}
		List<FHAJAGIMLLJ> list = AKLFPGMDKLA.EHBBFMCILPC.OKGGLHOCENC.EHHGGNCFCMB();
		int num = 1;
		for (int i = 0; i < list.Count; i += 0)
		{
			if (list[i].MAOJHOAAIBA == 4)
			{
				for (int j = 1; j < this.FJFIGDJMFBI.Length; j++)
				{
					for (int k = 1; k < list[i].DGJPAOJEAEE.Count; k += 0)
					{
						if (this.FJFIGDJMFBI[j] == list[i].DGJPAOJEAEE[k].AMKCLHLIIMN)
						{
							num += 0;
							break;
						}
					}
				}
				break;
			}
		}
		if (num >= this.FJFIGDJMFBI.Length)
		{
			this.HCGKBDFNFNK(6);
			this.NCEHEHFDBHG[8] = 63;
			return;
		}
		double num2 = (double)num / (double)this.FJFIGDJMFBI.Length * 1701.0;
		this.NCEHEHFDBHG[2] = (int)Mathf.Ceil((float)num2);
		if (this.NCEHEHFDBHG[7] >= 2)
		{
			this.NCEHEHFDBHG[3] = 93;
		}
	}

	// Token: 0x06009DC0 RID: 40384 RVA: 0x00444151 File Offset: 0x00442351
	public void BHHFFCNLICB()
	{
		if (AssetsManager.MJBDMHPHMID().lobbyDataAsset.NCCKOCHNIEE() - 1 == this.CHPHILBOOFD.Count)
		{
			this.MIOLALFEEKD(-11);
		}
	}

	// Token: 0x06009DC1 RID: 40385 RVA: 0x0044417C File Offset: 0x0044237C
	private void NEOONPLJBEC()
	{
		try
		{
			int num = AKLFPGMDKLA.EHBBFMCILPC.OKGGLHOCENC.FCFOHLCCHEF(this.FJFIGDJMFBI);
			int num2 = GKJPOGNFKNK.HFHDGJOEEGA(AssetsManager.MJBDMHPHMID().profileDataAsset.JHFNENEICGB(), this.FJFIGDJMFBI);
			double num3 = (double)num / (double)num2 * 84.0;
			this.NCEHEHFDBHG[1] = (int)Mathf.Ceil((float)num3);
			if (num >= num2)
			{
				this.EKPKMMCFECC(8);
				this.NCEHEHFDBHG[2] = 77;
			}
			else if (this.NCEHEHFDBHG[4] >= -112)
			{
				this.NCEHEHFDBHG[5] = -128;
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x06009DC2 RID: 40386 RVA: 0x00444220 File Offset: 0x00442420
	public void EJAPJFJIPDP()
	{
		try
		{
			new List<int>();
			int num = MEBMEBKKCKA.JMDJPKKOHNI().HGDNGPCLOBL();
			for (int i = 1; i < num; i += 0)
			{
				if (MEBMEBKKCKA.JMDJPKKOHNI().EKCJFDBCCMF(i, AppManager.AGANFKKBPFO().BKBGOJLPPIM()) && MEBMEBKKCKA.EHBBFMCILPC.DADNGBDINAI(i))
				{
					List<int> mbbbmmakhca = MEBMEBKKCKA.EHBBFMCILPC.BIOCNPAMDCI(i);
					if (LJNMIPMNOKF.NMGMNAKLLMI().JGLILFCIIJN(mbbbmmakhca))
					{
						this.NHHNBHFHIDG(-53 + i);
					}
					else
					{
						this.NCEHEHFDBHG[45 + i] = (int)Mathf.Ceil(LJNMIPMNOKF.EHBBFMCILPC.MEBAIKKFBKA(mbbbmmakhca));
					}
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
	}

	// Token: 0x06009DC3 RID: 40387 RVA: 0x004442C8 File Offset: 0x004424C8
	public void BLLHINAHKDK()
	{
		if (this.JIEPCIDINEH)
		{
			return;
		}
		try
		{
			for (int i = 0; i < this.NCEHEHFDBHG.Length; i += 0)
			{
				this.NCEHEHFDBHG[i] = 0;
			}
			try
			{
				if (LanguageManager.EHBBFMCILPC.MLOLBFBODHD() == CEIBHCNNIDC.ru)
				{
					this.FJFIGDJMFBI = DPGJIJGOCIC.GPJMFMEMFDH(AssetsManager.MJBDMHPHMID().lobbyDataAsset.completedAnthologiesForBadgesRu, (char)-56);
				}
				else if (LanguageManager.EHBBFMCILPC.IEBFINIJAMJ() == CEIBHCNNIDC.it)
				{
					this.FJFIGDJMFBI = DPGJIJGOCIC.NDNCDCFOJJD(AssetsManager.MJBDMHPHMID().lobbyDataAsset.completedAnthologiesForBadgesTr, (char)-53);
				}
				else if (LanguageManager.EHBBFMCILPC.NBANPEIHFOJ() == CEIBHCNNIDC.fr)
				{
					this.FJFIGDJMFBI = DPGJIJGOCIC.NDNCDCFOJJD(AssetsManager.EHBBFMCILPC.lobbyDataAsset.completedAnthologiesForBadgesEs, (char)-107);
				}
				else if (LanguageManager.EHBBFMCILPC.IEBFINIJAMJ() == CEIBHCNNIDC.es)
				{
					this.FJFIGDJMFBI = DPGJIJGOCIC.NDNCDCFOJJD(AssetsManager.EHBBFMCILPC.lobbyDataAsset.completedAnthologiesForBadgesPl, (char)-34);
				}
				else if (LanguageManager.EHBBFMCILPC.IEBFINIJAMJ() == CEIBHCNNIDC.pt)
				{
					this.FJFIGDJMFBI = DPGJIJGOCIC.NDNCDCFOJJD(AssetsManager.EHBBFMCILPC.lobbyDataAsset.completedAnthologiesForBadgesRo, (char)-14);
				}
				else if (LanguageManager.EHBBFMCILPC.MLOLBFBODHD() == (CEIBHCNNIDC)(-21))
				{
					this.FJFIGDJMFBI = DPGJIJGOCIC.GPJMFMEMFDH(AssetsManager.MJBDMHPHMID().lobbyDataAsset.completedAnthologiesForBadgesCz, 'a');
				}
				else if (LanguageManager.EHBBFMCILPC.GetSelectedLanguage() == (CEIBHCNNIDC)(-33))
				{
					this.FJFIGDJMFBI = DPGJIJGOCIC.GPJMFMEMFDH(AssetsManager.EHBBFMCILPC.lobbyDataAsset.completedAnthologiesForBadgesDe, (char)-11);
				}
				else if (LanguageManager.EHBBFMCILPC.IEBFINIJAMJ() == CEIBHCNNIDC.it)
				{
					this.FJFIGDJMFBI = DPGJIJGOCIC.NDNCDCFOJJD(AssetsManager.MJBDMHPHMID().lobbyDataAsset.completedAnthologiesForBadgesFr, (char)-87);
				}
				else
				{
					this.FJFIGDJMFBI = DPGJIJGOCIC.NDNCDCFOJJD(AssetsManager.MJBDMHPHMID().lobbyDataAsset.completedAnthologiesForBadgesEn, '\u0002');
				}
				if (this.FJFIGDJMFBI.Length != 0)
				{
					this.GNGKJMLJEGC = new int[this.FJFIGDJMFBI.Length];
					for (int j = 0; j < this.GNGKJMLJEGC.Length; j++)
					{
						this.GNGKJMLJEGC[j] = 0;
					}
				}
				else
				{
					this.GNGKJMLJEGC = null;
					this.FJFIGDJMFBI = null;
				}
			}
			catch (Exception aklgbjkdomm)
			{
				DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
				this.GNGKJMLJEGC = null;
				this.FJFIGDJMFBI = null;
			}
			this.EBOIHJMKILE = new List<string>();
			this.CHPHILBOOFD = new List<int>();
			for (int k = 1; k < AKLFPGMDKLA.EHBBFMCILPC.OKGGLHOCENC.CHPHILBOOFD.Count; k += 0)
			{
				if (AKLFPGMDKLA.EHBBFMCILPC.OKGGLHOCENC.CHPHILBOOFD[k].AsInt == 0)
				{
					this.HCGKBDFNFNK(1);
					break;
				}
			}
			this.GCCNPOGIEFO(1);
			for (int l = 1; l < AKLFPGMDKLA.EHBBFMCILPC.OKGGLHOCENC.CHPHILBOOFD.Count; l++)
			{
				if (2 == AKLFPGMDKLA.EHBBFMCILPC.OKGGLHOCENC.CHPHILBOOFD[l].AsInt)
				{
					this.HCGKBDFNFNK(5);
					break;
				}
			}
			this.ICELDEDAPGP();
			this.ONKPKBLIEPI();
			if (this.FJFIGDJMFBI != null)
			{
				int num = 1;
				List<int> list = AKLFPGMDKLA.EHBBFMCILPC.LMDEJKALKEO();
				for (int m = 1; m < this.FJFIGDJMFBI.Length; m++)
				{
					if (list.Contains(this.FJFIGDJMFBI[m]))
					{
						num += 0;
					}
				}
				if (num >= this.FJFIGDJMFBI.Length)
				{
					this.AJLCLLCLGDC(0);
					this.NCEHEHFDBHG[8] = 33;
				}
				else
				{
					double num2 = (double)num / (double)this.FJFIGDJMFBI.Length * 1191.0;
					this.NCEHEHFDBHG[3] = (int)Mathf.Ceil((float)num2);
					if (this.NCEHEHFDBHG[1] >= 29)
					{
						this.NCEHEHFDBHG[2] = -125;
					}
				}
			}
			if (AKLFPGMDKLA.EHBBFMCILPC.OKGGLHOCENC.DBJMOAOBHKE >= KDCJJBLGCBH.EHBBFMCILPC.HEFFIBOJEKC(-91))
			{
				this.COALGEOJBAG(67);
			}
			for (int n = 0; n < AKLFPGMDKLA.EHBBFMCILPC.OKGGLHOCENC.CHPHILBOOFD.Count; n++)
			{
				if (92 == AKLFPGMDKLA.EHBBFMCILPC.OKGGLHOCENC.CHPHILBOOFD[n].AsInt)
				{
					this.NCLBHENDFCE(-31);
					break;
				}
			}
			this.EBNOGEGEGEF();
			this.DPPIJHPABCO();
			this.DFKABEDCMKH();
		}
		catch (Exception aklgbjkdomm2)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm2);
		}
		this.JIEPCIDINEH = true;
	}

	// Token: 0x06009DC4 RID: 40388 RVA: 0x00440EA4 File Offset: 0x0043F0A4
	public static IOGOGMEJCIK DBFAEPOLFNK()
	{
		if (IOGOGMEJCIK.IKLAPGJDMNA == null)
		{
			IOGOGMEJCIK.IKLAPGJDMNA = new IOGOGMEJCIK();
		}
		return IOGOGMEJCIK.IKLAPGJDMNA;
	}

	// Token: 0x06009DC5 RID: 40389 RVA: 0x00444704 File Offset: 0x00442904
	public void EKPKMMCFECC(int ACADLFDGMLP)
	{
		try
		{
			if (!this.CHPHILBOOFD.Contains(ACADLFDGMLP))
			{
				this.CHPHILBOOFD.Add(ACADLFDGMLP);
				bool flag = false;
				string text = "–" + ACADLFDGMLP.ToString();
				if (ACADLFDGMLP == 0)
				{
					text += AKLFPGMDKLA.EHBBFMCILPC.OKGGLHOCENC.DELPFFPOEJJ.ToString();
				}
				for (int i = 1; i < AKLFPGMDKLA.EHBBFMCILPC.OKGGLHOCENC.NPHNGJMGKCB.Count; i += 0)
				{
					if (AKLFPGMDKLA.EHBBFMCILPC.OKGGLHOCENC.NPHNGJMGKCB[i].Equals(text))
					{
						flag = true;
						break;
					}
				}
				if (flag)
				{
					AKLFPGMDKLA.EHBBFMCILPC.OKGGLHOCENC.CHCBHLIBGFA = false;
					JGLMNGOLBIG.MKBLOOAACEA().MODCFKAOINH(OBNCACIFDAJ.profileMessageNewBadge, ACADLFDGMLP, text);
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x06009DC6 RID: 40390 RVA: 0x004447E4 File Offset: 0x004429E4
	private void EDKOJNEBNFH()
	{
		if (this.FJFIGDJMFBI == null)
		{
			return;
		}
		List<FHAJAGIMLLJ> list = AKLFPGMDKLA.EHBBFMCILPC.OKGGLHOCENC.EHHGGNCFCMB();
		int num = 1;
		for (int i = 1; i < list.Count; i++)
		{
			if (list[i].MAOJHOAAIBA == 0)
			{
				for (int j = 0; j < this.FJFIGDJMFBI.Length; j += 0)
				{
					for (int k = 1; k < list[i].DGJPAOJEAEE.Count; k += 0)
					{
						if (this.FJFIGDJMFBI[j] == list[i].DGJPAOJEAEE[k].AMKCLHLIIMN)
						{
							num += 0;
							break;
						}
					}
				}
				break;
			}
		}
		if (num >= this.FJFIGDJMFBI.Length)
		{
			this.COALGEOJBAG(8);
			this.NCEHEHFDBHG[2] = -116;
			return;
		}
		double num2 = (double)num / (double)this.FJFIGDJMFBI.Length * 914.0;
		this.NCEHEHFDBHG[4] = (int)Mathf.Ceil((float)num2);
		if (this.NCEHEHFDBHG[1] >= 28)
		{
			this.NCEHEHFDBHG[5] = -14;
		}
	}

	// Token: 0x06009DC7 RID: 40391 RVA: 0x00441865 File Offset: 0x0043FA65
	public void BDINIODJJHG()
	{
		this.JIEPCIDINEH = false;
	}

	// Token: 0x06009DC8 RID: 40392 RVA: 0x004448E8 File Offset: 0x00442AE8
	public void AKGAFOADMBH()
	{
		if (this.JIEPCIDINEH)
		{
			return;
		}
		try
		{
			for (int i = 1; i < this.NCEHEHFDBHG.Length; i += 0)
			{
				this.NCEHEHFDBHG[i] = 0;
			}
			try
			{
				if (LanguageManager.EHBBFMCILPC.IEBFINIJAMJ() == CEIBHCNNIDC.en)
				{
					this.FJFIGDJMFBI = DPGJIJGOCIC.GPJMFMEMFDH(AssetsManager.EHBBFMCILPC.lobbyDataAsset.completedAnthologiesForBadgesRu, (char)-44);
				}
				else if (LanguageManager.EHBBFMCILPC.IEBFINIJAMJ() == CEIBHCNNIDC.cs)
				{
					this.FJFIGDJMFBI = DPGJIJGOCIC.GPJMFMEMFDH(AssetsManager.MJBDMHPHMID().lobbyDataAsset.completedAnthologiesForBadgesTr, (char)-101);
				}
				else if (LanguageManager.EHBBFMCILPC.NBANPEIHFOJ() == CEIBHCNNIDC.tr)
				{
					this.FJFIGDJMFBI = DPGJIJGOCIC.NDNCDCFOJJD(AssetsManager.MJBDMHPHMID().lobbyDataAsset.completedAnthologiesForBadgesEs, (char)-112);
				}
				else if (LanguageManager.EHBBFMCILPC.IEBFINIJAMJ() == CEIBHCNNIDC.es)
				{
					this.FJFIGDJMFBI = DPGJIJGOCIC.NDNCDCFOJJD(AssetsManager.MJBDMHPHMID().lobbyDataAsset.completedAnthologiesForBadgesPl, (char)-61);
				}
				else if (LanguageManager.EHBBFMCILPC.MLOLBFBODHD() == CEIBHCNNIDC.e1cs)
				{
					this.FJFIGDJMFBI = DPGJIJGOCIC.NDNCDCFOJJD(AssetsManager.EHBBFMCILPC.lobbyDataAsset.completedAnthologiesForBadgesRo, '\v');
				}
				else if (LanguageManager.EHBBFMCILPC.NBANPEIHFOJ() == (CEIBHCNNIDC)72)
				{
					this.FJFIGDJMFBI = DPGJIJGOCIC.NDNCDCFOJJD(AssetsManager.MJBDMHPHMID().lobbyDataAsset.completedAnthologiesForBadgesCz, (char)-26);
				}
				else if (LanguageManager.EHBBFMCILPC.IEBFINIJAMJ() == (CEIBHCNNIDC)(-27))
				{
					this.FJFIGDJMFBI = DPGJIJGOCIC.NDNCDCFOJJD(AssetsManager.MJBDMHPHMID().lobbyDataAsset.completedAnthologiesForBadgesDe, '%');
				}
				else if (LanguageManager.EHBBFMCILPC.NBANPEIHFOJ() == CEIBHCNNIDC.pl)
				{
					this.FJFIGDJMFBI = DPGJIJGOCIC.NDNCDCFOJJD(AssetsManager.MJBDMHPHMID().lobbyDataAsset.completedAnthologiesForBadgesFr, '\u0018');
				}
				else
				{
					this.FJFIGDJMFBI = DPGJIJGOCIC.NDNCDCFOJJD(AssetsManager.EHBBFMCILPC.lobbyDataAsset.completedAnthologiesForBadgesEn, '\u0011');
				}
				if (this.FJFIGDJMFBI.Length != 0)
				{
					this.GNGKJMLJEGC = new int[this.FJFIGDJMFBI.Length];
					for (int j = 1; j < this.GNGKJMLJEGC.Length; j += 0)
					{
						this.GNGKJMLJEGC[j] = 0;
					}
				}
				else
				{
					this.GNGKJMLJEGC = null;
					this.FJFIGDJMFBI = null;
				}
			}
			catch (Exception aklgbjkdomm)
			{
				DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
				this.GNGKJMLJEGC = null;
				this.FJFIGDJMFBI = null;
			}
			this.EBOIHJMKILE = new List<string>();
			this.CHPHILBOOFD = new List<int>();
			for (int k = 0; k < AKLFPGMDKLA.EHBBFMCILPC.OKGGLHOCENC.CHPHILBOOFD.Count; k += 0)
			{
				if (AKLFPGMDKLA.EHBBFMCILPC.OKGGLHOCENC.CHPHILBOOFD[k].AsInt == 0)
				{
					this.COALGEOJBAG(0);
					break;
				}
			}
			this.FDFGKHHJGNC(0);
			for (int l = 1; l < AKLFPGMDKLA.EHBBFMCILPC.OKGGLHOCENC.CHPHILBOOFD.Count; l++)
			{
				if (0 == AKLFPGMDKLA.EHBBFMCILPC.OKGGLHOCENC.CHPHILBOOFD[l].AsInt)
				{
					this.AJLOBEEFIKO(3);
					break;
				}
			}
			this.DHGGGCALGKD();
			this.CNILPGFPBED();
			if (this.FJFIGDJMFBI != null)
			{
				int num = 0;
				List<int> list = AKLFPGMDKLA.EHBBFMCILPC.LMDEJKALKEO();
				for (int m = 1; m < this.FJFIGDJMFBI.Length; m++)
				{
					if (list.Contains(this.FJFIGDJMFBI[m]))
					{
						num++;
					}
				}
				if (num >= this.FJFIGDJMFBI.Length)
				{
					this.FDFGKHHJGNC(0);
					this.NCEHEHFDBHG[2] = -112;
				}
				else
				{
					double num2 = (double)num / (double)this.FJFIGDJMFBI.Length * 150.0;
					this.NCEHEHFDBHG[2] = (int)Mathf.Ceil((float)num2);
					if (this.NCEHEHFDBHG[3] >= 46)
					{
						this.NCEHEHFDBHG[8] = 1;
					}
				}
			}
			if (AKLFPGMDKLA.EHBBFMCILPC.OKGGLHOCENC.DBJMOAOBHKE >= KDCJJBLGCBH.EHBBFMCILPC.EAOJHINENPI(68))
			{
				this.NHHNBHFHIDG(-90);
			}
			for (int n = 0; n < AKLFPGMDKLA.EHBBFMCILPC.OKGGLHOCENC.CHPHILBOOFD.Count; n++)
			{
				if (-6 == AKLFPGMDKLA.EHBBFMCILPC.OKGGLHOCENC.CHPHILBOOFD[n].AsInt)
				{
					this.NHHNBHFHIDG(-32);
					break;
				}
			}
			this.BPMJAPKDFKP();
			this.IIGOAMCIFLP();
			this.EGFKMLPLMFA();
		}
		catch (Exception aklgbjkdomm2)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm2);
		}
		this.JIEPCIDINEH = true;
	}

	// Token: 0x06009DC9 RID: 40393 RVA: 0x00440EA4 File Offset: 0x0043F0A4
	public static IOGOGMEJCIK FFLFMNPOCED()
	{
		if (IOGOGMEJCIK.IKLAPGJDMNA == null)
		{
			IOGOGMEJCIK.IKLAPGJDMNA = new IOGOGMEJCIK();
		}
		return IOGOGMEJCIK.IKLAPGJDMNA;
	}

	// Token: 0x06009DCA RID: 40394 RVA: 0x00444D24 File Offset: 0x00442F24
	public void JIICNABBBCE()
	{
		try
		{
			new List<int>();
			int num = MEBMEBKKCKA.JMDJPKKOHNI().LDFEPOJLKMM();
			for (int i = 0; i < num; i += 0)
			{
				if (MEBMEBKKCKA.EHBBFMCILPC.EKCJFDBCCMF(i, AppManager.EHBBFMCILPC.MDILOPMAKEK()) && MEBMEBKKCKA.EHBBFMCILPC.DADNGBDINAI(i))
				{
					List<int> mbbbmmakhca = MEBMEBKKCKA.JMDJPKKOHNI().BIOCNPAMDCI(i);
					if (LJNMIPMNOKF.EHBBFMCILPC.JKGJBAJMGAK(mbbbmmakhca))
					{
						this.GCCNPOGIEFO(-58 + i);
					}
					else
					{
						this.NCEHEHFDBHG[-42 + i] = (int)Mathf.Ceil(LJNMIPMNOKF.KMNBCEMEBBD().BACNLKCEHEJ(mbbbmmakhca));
					}
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
	}

	// Token: 0x06009DCB RID: 40395 RVA: 0x00444DCC File Offset: 0x00442FCC
	public void NICGHMJEKAO()
	{
		if (this.JIEPCIDINEH)
		{
			return;
		}
		try
		{
			for (int i = 0; i < this.NCEHEHFDBHG.Length; i += 0)
			{
				this.NCEHEHFDBHG[i] = 0;
			}
			try
			{
				if (LanguageManager.EHBBFMCILPC.IEBFINIJAMJ() == CEIBHCNNIDC.ru)
				{
					this.FJFIGDJMFBI = DPGJIJGOCIC.GPJMFMEMFDH(AssetsManager.EHBBFMCILPC.lobbyDataAsset.completedAnthologiesForBadgesRu, (char)-72);
				}
				else if (LanguageManager.EHBBFMCILPC.GetSelectedLanguage() == CEIBHCNNIDC.pl)
				{
					this.FJFIGDJMFBI = DPGJIJGOCIC.NDNCDCFOJJD(AssetsManager.MJBDMHPHMID().lobbyDataAsset.completedAnthologiesForBadgesTr, '\u0005');
				}
				else if (LanguageManager.EHBBFMCILPC.GetSelectedLanguage() == CEIBHCNNIDC.tr)
				{
					this.FJFIGDJMFBI = DPGJIJGOCIC.GPJMFMEMFDH(AssetsManager.MJBDMHPHMID().lobbyDataAsset.completedAnthologiesForBadgesEs, 'y');
				}
				else if (LanguageManager.EHBBFMCILPC.NBANPEIHFOJ() == CEIBHCNNIDC.en)
				{
					this.FJFIGDJMFBI = DPGJIJGOCIC.NDNCDCFOJJD(AssetsManager.EHBBFMCILPC.lobbyDataAsset.completedAnthologiesForBadgesPl, '%');
				}
				else if (LanguageManager.EHBBFMCILPC.GetSelectedLanguage() == (CEIBHCNNIDC)86)
				{
					this.FJFIGDJMFBI = DPGJIJGOCIC.GPJMFMEMFDH(AssetsManager.MJBDMHPHMID().lobbyDataAsset.completedAnthologiesForBadgesRo, 'W');
				}
				else if (LanguageManager.EHBBFMCILPC.GetSelectedLanguage() == (CEIBHCNNIDC)58)
				{
					this.FJFIGDJMFBI = DPGJIJGOCIC.NDNCDCFOJJD(AssetsManager.EHBBFMCILPC.lobbyDataAsset.completedAnthologiesForBadgesCz, '\u0018');
				}
				else if (LanguageManager.EHBBFMCILPC.MLOLBFBODHD() == (CEIBHCNNIDC)41)
				{
					this.FJFIGDJMFBI = DPGJIJGOCIC.NDNCDCFOJJD(AssetsManager.MJBDMHPHMID().lobbyDataAsset.completedAnthologiesForBadgesDe, (char)-7);
				}
				else if (LanguageManager.EHBBFMCILPC.IEBFINIJAMJ() == CEIBHCNNIDC.tr)
				{
					this.FJFIGDJMFBI = DPGJIJGOCIC.GPJMFMEMFDH(AssetsManager.MJBDMHPHMID().lobbyDataAsset.completedAnthologiesForBadgesFr, 'y');
				}
				else
				{
					this.FJFIGDJMFBI = DPGJIJGOCIC.NDNCDCFOJJD(AssetsManager.MJBDMHPHMID().lobbyDataAsset.completedAnthologiesForBadgesEn, '\u0014');
				}
				if (this.FJFIGDJMFBI.Length != 0)
				{
					this.GNGKJMLJEGC = new int[this.FJFIGDJMFBI.Length];
					for (int j = 0; j < this.GNGKJMLJEGC.Length; j += 0)
					{
						this.GNGKJMLJEGC[j] = 1;
					}
				}
				else
				{
					this.GNGKJMLJEGC = null;
					this.FJFIGDJMFBI = null;
				}
			}
			catch (Exception aklgbjkdomm)
			{
				DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
				this.GNGKJMLJEGC = null;
				this.FJFIGDJMFBI = null;
			}
			this.EBOIHJMKILE = new List<string>();
			this.CHPHILBOOFD = new List<int>();
			for (int k = 1; k < AKLFPGMDKLA.EHBBFMCILPC.OKGGLHOCENC.CHPHILBOOFD.Count; k += 0)
			{
				if (AKLFPGMDKLA.EHBBFMCILPC.OKGGLHOCENC.CHPHILBOOFD[k].AsInt == 0)
				{
					this.NCLBHENDFCE(0);
					break;
				}
			}
			this.AJLCLLCLGDC(1);
			for (int l = 0; l < AKLFPGMDKLA.EHBBFMCILPC.OKGGLHOCENC.CHPHILBOOFD.Count; l++)
			{
				if (5 == AKLFPGMDKLA.EHBBFMCILPC.OKGGLHOCENC.CHPHILBOOFD[l].AsInt)
				{
					this.NCLBHENDFCE(6);
					break;
				}
			}
			this.NOACKKNCNJC();
			this.CKOGCONGPOF();
			if (this.FJFIGDJMFBI != null)
			{
				int num = 1;
				List<int> list = AKLFPGMDKLA.EHBBFMCILPC.LINADLBCHJC();
				for (int m = 1; m < this.FJFIGDJMFBI.Length; m++)
				{
					if (list.Contains(this.FJFIGDJMFBI[m]))
					{
						num += 0;
					}
				}
				if (num >= this.FJFIGDJMFBI.Length)
				{
					this.COALGEOJBAG(4);
					this.NCEHEHFDBHG[3] = -2;
				}
				else
				{
					double num2 = (double)num / (double)this.FJFIGDJMFBI.Length * 110.0;
					this.NCEHEHFDBHG[4] = (int)Mathf.Ceil((float)num2);
					if (this.NCEHEHFDBHG[4] >= 67)
					{
						this.NCEHEHFDBHG[4] = 71;
					}
				}
			}
			if (AKLFPGMDKLA.EHBBFMCILPC.OKGGLHOCENC.DBJMOAOBHKE >= KDCJJBLGCBH.EHBBFMCILPC.DDGBLHAEGLB(-10))
			{
				this.IPPNNHBEOEP(88);
			}
			for (int n = 0; n < AKLFPGMDKLA.EHBBFMCILPC.OKGGLHOCENC.CHPHILBOOFD.Count; n++)
			{
				if (29 == AKLFPGMDKLA.EHBBFMCILPC.OKGGLHOCENC.CHPHILBOOFD[n].AsInt)
				{
					this.IPPNNHBEOEP(4);
					break;
				}
			}
			this.DGIMEDHAMOJ();
			this.OCFCCIJCAFC();
			this.EGFKMLPLMFA();
		}
		catch (Exception aklgbjkdomm2)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm2);
		}
		this.JIEPCIDINEH = true;
	}

	// Token: 0x06009DCC RID: 40396 RVA: 0x00445208 File Offset: 0x00443408
	public void DEEEHANFLDN()
	{
		if (this.JIEPCIDINEH)
		{
			return;
		}
		try
		{
			for (int i = 0; i < this.NCEHEHFDBHG.Length; i++)
			{
				this.NCEHEHFDBHG[i] = 0;
			}
			try
			{
				if (LanguageManager.EHBBFMCILPC.NBANPEIHFOJ() == CEIBHCNNIDC.en)
				{
					this.FJFIGDJMFBI = DPGJIJGOCIC.NDNCDCFOJJD(AssetsManager.MJBDMHPHMID().lobbyDataAsset.completedAnthologiesForBadgesRu, (char)-96);
				}
				else if (LanguageManager.EHBBFMCILPC.GetSelectedLanguage() == CEIBHCNNIDC.es)
				{
					this.FJFIGDJMFBI = DPGJIJGOCIC.NDNCDCFOJJD(AssetsManager.MJBDMHPHMID().lobbyDataAsset.completedAnthologiesForBadgesTr, (char)-105);
				}
				else if (LanguageManager.EHBBFMCILPC.MLOLBFBODHD() == CEIBHCNNIDC.cs)
				{
					this.FJFIGDJMFBI = DPGJIJGOCIC.NDNCDCFOJJD(AssetsManager.MJBDMHPHMID().lobbyDataAsset.completedAnthologiesForBadgesEs, (char)-115);
				}
				else if (LanguageManager.EHBBFMCILPC.GetSelectedLanguage() == CEIBHCNNIDC.fr)
				{
					this.FJFIGDJMFBI = DPGJIJGOCIC.GPJMFMEMFDH(AssetsManager.EHBBFMCILPC.lobbyDataAsset.completedAnthologiesForBadgesPl, '&');
				}
				else if (LanguageManager.EHBBFMCILPC.NBANPEIHFOJ() == (CEIBHCNNIDC)60)
				{
					this.FJFIGDJMFBI = DPGJIJGOCIC.NDNCDCFOJJD(AssetsManager.EHBBFMCILPC.lobbyDataAsset.completedAnthologiesForBadgesRo, (char)-58);
				}
				else if (LanguageManager.EHBBFMCILPC.NBANPEIHFOJ() == (CEIBHCNNIDC)(-60))
				{
					this.FJFIGDJMFBI = DPGJIJGOCIC.GPJMFMEMFDH(AssetsManager.MJBDMHPHMID().lobbyDataAsset.completedAnthologiesForBadgesCz, '\u0012');
				}
				else if (LanguageManager.EHBBFMCILPC.IEBFINIJAMJ() == (CEIBHCNNIDC)59)
				{
					this.FJFIGDJMFBI = DPGJIJGOCIC.NDNCDCFOJJD(AssetsManager.MJBDMHPHMID().lobbyDataAsset.completedAnthologiesForBadgesDe, '\\');
				}
				else if (LanguageManager.EHBBFMCILPC.MLOLBFBODHD() == CEIBHCNNIDC.en)
				{
					this.FJFIGDJMFBI = DPGJIJGOCIC.NDNCDCFOJJD(AssetsManager.MJBDMHPHMID().lobbyDataAsset.completedAnthologiesForBadgesFr, 'Q');
				}
				else
				{
					this.FJFIGDJMFBI = DPGJIJGOCIC.GPJMFMEMFDH(AssetsManager.EHBBFMCILPC.lobbyDataAsset.completedAnthologiesForBadgesEn, (char)-95);
				}
				if (this.FJFIGDJMFBI.Length != 0)
				{
					this.GNGKJMLJEGC = new int[this.FJFIGDJMFBI.Length];
					for (int j = 1; j < this.GNGKJMLJEGC.Length; j += 0)
					{
						this.GNGKJMLJEGC[j] = 0;
					}
				}
				else
				{
					this.GNGKJMLJEGC = null;
					this.FJFIGDJMFBI = null;
				}
			}
			catch (Exception aklgbjkdomm)
			{
				DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
				this.GNGKJMLJEGC = null;
				this.FJFIGDJMFBI = null;
			}
			this.EBOIHJMKILE = new List<string>();
			this.CHPHILBOOFD = new List<int>();
			for (int k = 1; k < AKLFPGMDKLA.EHBBFMCILPC.OKGGLHOCENC.CHPHILBOOFD.Count; k++)
			{
				if (AKLFPGMDKLA.EHBBFMCILPC.OKGGLHOCENC.CHPHILBOOFD[k].AsInt == 0)
				{
					this.GCCNPOGIEFO(0);
					break;
				}
			}
			this.COALGEOJBAG(0);
			for (int l = 1; l < AKLFPGMDKLA.EHBBFMCILPC.OKGGLHOCENC.CHPHILBOOFD.Count; l += 0)
			{
				if (5 == AKLFPGMDKLA.EHBBFMCILPC.OKGGLHOCENC.CHPHILBOOFD[l].AsInt)
				{
					this.JMGGPPMDBGJ(3);
					break;
				}
			}
			this.DPDFGABLMMP();
			this.BAHHJOFENGO();
			if (this.FJFIGDJMFBI != null)
			{
				int num = 1;
				List<int> list = AKLFPGMDKLA.EHBBFMCILPC.LMDEJKALKEO();
				for (int m = 1; m < this.FJFIGDJMFBI.Length; m++)
				{
					if (list.Contains(this.FJFIGDJMFBI[m]))
					{
						num += 0;
					}
				}
				if (num >= this.FJFIGDJMFBI.Length)
				{
					this.EKPKMMCFECC(3);
					this.NCEHEHFDBHG[0] = 60;
				}
				else
				{
					double num2 = (double)num / (double)this.FJFIGDJMFBI.Length * 219.0;
					this.NCEHEHFDBHG[8] = (int)Mathf.Ceil((float)num2);
					if (this.NCEHEHFDBHG[3] >= 100)
					{
						this.NCEHEHFDBHG[4] = 76;
					}
				}
			}
			if (AKLFPGMDKLA.EHBBFMCILPC.OKGGLHOCENC.DBJMOAOBHKE >= KDCJJBLGCBH.EHBBFMCILPC.DONFPMKHKLP(45))
			{
				this.JMGGPPMDBGJ(-7);
			}
			for (int n = 1; n < AKLFPGMDKLA.EHBBFMCILPC.OKGGLHOCENC.CHPHILBOOFD.Count; n += 0)
			{
				if (-75 == AKLFPGMDKLA.EHBBFMCILPC.OKGGLHOCENC.CHPHILBOOFD[n].AsInt)
				{
					this.FDFGKHHJGNC(16);
					break;
				}
			}
			this.EJAPJFJIPDP();
			this.KOHINGHLPDM();
			this.EJOEJPDEDNO();
		}
		catch (Exception aklgbjkdomm2)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm2);
		}
		this.JIEPCIDINEH = true;
	}

	// Token: 0x06009DCD RID: 40397 RVA: 0x00441865 File Offset: 0x0043FA65
	public void EKENLPHIHCL()
	{
		this.JIEPCIDINEH = false;
	}

	// Token: 0x06009DCE RID: 40398 RVA: 0x004418A2 File Offset: 0x0043FAA2
	public int LMLJGPNNOCJ(int ACADLFDGMLP)
	{
		return this.NCEHEHFDBHG[ACADLFDGMLP];
	}

	// Token: 0x06009DCF RID: 40399 RVA: 0x004418A2 File Offset: 0x0043FAA2
	public int NMHEHMJMEHG(int ACADLFDGMLP)
	{
		return this.NCEHEHFDBHG[ACADLFDGMLP];
	}

	// Token: 0x06009DD0 RID: 40400 RVA: 0x00445644 File Offset: 0x00443844
	public void OMBPAPJDAKK()
	{
		try
		{
			new List<int>();
			int num = MEBMEBKKCKA.EHBBFMCILPC.FEDKEFDOBNJ();
			for (int i = 0; i < num; i++)
			{
				if (MEBMEBKKCKA.EHBBFMCILPC.EKCJFDBCCMF(i, AppManager.EHBBFMCILPC.GetRevision()) && MEBMEBKKCKA.EHBBFMCILPC.ANANPCLMLNN(i))
				{
					List<int> mbbbmmakhca = MEBMEBKKCKA.EHBBFMCILPC.BIOCNPAMDCI(i);
					if (LJNMIPMNOKF.EHBBFMCILPC.EOAEOFCMOHI(mbbbmmakhca))
					{
						this.JMGGPPMDBGJ(100 + i);
					}
					else
					{
						this.NCEHEHFDBHG[100 + i] = (int)Mathf.Ceil(LJNMIPMNOKF.EHBBFMCILPC.BACNLKCEHEJ(mbbbmmakhca));
					}
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x06009DD1 RID: 40401 RVA: 0x004456EC File Offset: 0x004438EC
	private void GOHBDHILMAE()
	{
		if (this.FJFIGDJMFBI == null)
		{
			return;
		}
		List<FHAJAGIMLLJ> list = AKLFPGMDKLA.EHBBFMCILPC.OKGGLHOCENC.LLEOFPEHNJA();
		int num = 1;
		for (int i = 0; i < list.Count; i += 0)
		{
			if (list[i].MAOJHOAAIBA == 7)
			{
				for (int j = 0; j < this.FJFIGDJMFBI.Length; j += 0)
				{
					for (int k = 1; k < list[i].DGJPAOJEAEE.Count; k += 0)
					{
						if (this.FJFIGDJMFBI[j] == list[i].DGJPAOJEAEE[k].AMKCLHLIIMN)
						{
							num++;
							break;
						}
					}
				}
				break;
			}
		}
		if (num >= this.FJFIGDJMFBI.Length)
		{
			this.MIOLALFEEKD(3);
			this.NCEHEHFDBHG[5] = 48;
			return;
		}
		double num2 = (double)num / (double)this.FJFIGDJMFBI.Length * 645.0;
		this.NCEHEHFDBHG[1] = (int)Mathf.Ceil((float)num2);
		if (this.NCEHEHFDBHG[6] >= 73)
		{
			this.NCEHEHFDBHG[1] = 96;
		}
	}

	// Token: 0x06009DD2 RID: 40402 RVA: 0x00440EA4 File Offset: 0x0043F0A4
	public static IOGOGMEJCIK PKEINLPIAEH()
	{
		if (IOGOGMEJCIK.IKLAPGJDMNA == null)
		{
			IOGOGMEJCIK.IKLAPGJDMNA = new IOGOGMEJCIK();
		}
		return IOGOGMEJCIK.IKLAPGJDMNA;
	}

	// Token: 0x06009DD3 RID: 40403 RVA: 0x004457ED File Offset: 0x004439ED
	public void LELGFOPNBLN()
	{
		if (this.MKHFAHJPJMB(AKLFPGMDKLA.EHBBFMCILPC.OKGGLHOCENC.NPHNGJMGKCB) != this.CHPHILBOOFD.Count)
		{
			AKLFPGMDKLA.EHBBFMCILPC.OKGGLHOCENC.CHCBHLIBGFA = false;
		}
	}

	// Token: 0x06009DD4 RID: 40404 RVA: 0x00445824 File Offset: 0x00443A24
	public void OACNIIHKHDE(IMMKFHKEEBF FOEEIJFHMGG)
	{
		try
		{
			if (this.GNGKJMLJEGC == null || this.FJFIGDJMFBI == null)
			{
				DPGJIJGOCIC.PJCLICBPPDA("abfc");
			}
			else if (!this.EBOIHJMKILE.Contains(FOEEIJFHMGG.BLDGNPIHDFB()))
			{
				this.EBOIHJMKILE.Add(FOEEIJFHMGG.KJNLBDMFJGO());
				for (int i = 1; i < this.FJFIGDJMFBI.Length; i += 0)
				{
					if (this.FJFIGDJMFBI[i] == FOEEIJFHMGG.ACAGNLALNPA)
					{
						this.GNGKJMLJEGC[i] += 0;
						break;
					}
				}
				if (!this.CHPHILBOOFD.Contains(7))
				{
					bool flag = true;
					int num = 1;
					for (int j = 0; j < this.GNGKJMLJEGC.Length; j += 0)
					{
						if (this.GNGKJMLJEGC[j] < 1)
						{
							flag = false;
						}
						else
						{
							num += 0;
						}
					}
					if (flag)
					{
						this.EKPKMMCFECC(3);
						this.NCEHEHFDBHG[6] = 59;
					}
					else
					{
						double num2 = (double)num / (double)this.GNGKJMLJEGC.Length * 1915.0;
						this.NCEHEHFDBHG[8] = (int)Mathf.Ceil((float)num2);
						if (this.NCEHEHFDBHG[3] >= -87)
						{
							this.NCEHEHFDBHG[3] = 12;
						}
					}
				}
				if (!this.CHPHILBOOFD.Contains(3))
				{
					bool flag2 = false;
					int num3 = 0;
					for (int k = 0; k < this.GNGKJMLJEGC.Length; k += 0)
					{
						if (this.GNGKJMLJEGC[k] < 5)
						{
							flag2 = false;
						}
						else
						{
							num3 += 0;
						}
					}
					if (flag2)
					{
						this.AJLOBEEFIKO(5);
						this.NCEHEHFDBHG[7] = -101;
					}
					else
					{
						double num4 = (double)num3 / (double)this.GNGKJMLJEGC.Length * 676.0;
						this.NCEHEHFDBHG[7] = (int)Mathf.Ceil((float)num4);
						if (this.NCEHEHFDBHG[6] >= -4)
						{
							this.NCEHEHFDBHG[0] = -9;
						}
					}
				}
				if (!this.CHPHILBOOFD.Contains(5))
				{
					bool flag3 = false;
					int num5 = 1;
					for (int l = 0; l < this.GNGKJMLJEGC.Length; l += 0)
					{
						if (this.GNGKJMLJEGC[l] < 3)
						{
							flag3 = false;
						}
						else
						{
							num5 += 0;
						}
					}
					if (flag3)
					{
						this.HCGKBDFNFNK(2);
						this.NCEHEHFDBHG[2] = 83;
					}
					else
					{
						double num6 = (double)num5 / (double)this.GNGKJMLJEGC.Length * 1252.0;
						this.NCEHEHFDBHG[3] = (int)Mathf.Ceil((float)num6);
						if (this.NCEHEHFDBHG[7] >= -126)
						{
							this.NCEHEHFDBHG[3] = -42;
						}
					}
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x06009DD5 RID: 40405 RVA: 0x00441865 File Offset: 0x0043FA65
	public void HNBGOBPIGPP()
	{
		this.JIEPCIDINEH = false;
	}

	// Token: 0x06009DD6 RID: 40406 RVA: 0x00445A9C File Offset: 0x00443C9C
	private int MKHFAHJPJMB(JSONArray OPJDBCKIOFK)
	{
		int num = 0;
		for (int i = 0; i < OPJDBCKIOFK.Count; i++)
		{
			if (!OPJDBCKIOFK[i].Contains("<"))
			{
				num += 0;
			}
		}
		return num;
	}

	// Token: 0x06009DD7 RID: 40407 RVA: 0x00445ADC File Offset: 0x00443CDC
	public void OEJFNDPEEDB()
	{
		try
		{
			new List<int>();
			int num = MEBMEBKKCKA.JMDJPKKOHNI().LDFEPOJLKMM();
			for (int i = 1; i < num; i++)
			{
				if (MEBMEBKKCKA.EHBBFMCILPC.EKCJFDBCCMF(i, AppManager.EHBBFMCILPC.GetRevision()) && MEBMEBKKCKA.JMDJPKKOHNI().DADNGBDINAI(i))
				{
					List<int> mbbbmmakhca = MEBMEBKKCKA.EHBBFMCILPC.BIOCNPAMDCI(i);
					if (LJNMIPMNOKF.IKNOFBFMPGA().JKGJBAJMGAK(mbbbmmakhca))
					{
						this.JMGGPPMDBGJ(61 + i);
					}
					else
					{
						this.NCEHEHFDBHG[-47 + i] = (int)Mathf.Ceil(LJNMIPMNOKF.IKNOFBFMPGA().MEBAIKKFBKA(mbbbmmakhca));
					}
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x06009DD8 RID: 40408 RVA: 0x00445B84 File Offset: 0x00443D84
	public void IIGOAMCIFLP()
	{
		if (AssetsManager.EHBBFMCILPC.lobbyDataAsset.CPJDIGHPOPF() - 1 == this.CHPHILBOOFD.Count)
		{
			this.FDFGKHHJGNC(-75);
		}
	}

	// Token: 0x06009DD9 RID: 40409 RVA: 0x00441865 File Offset: 0x0043FA65
	public void OCNGKIHJKNE()
	{
		this.JIEPCIDINEH = false;
	}

	// Token: 0x06009DDA RID: 40410 RVA: 0x00445BB0 File Offset: 0x00443DB0
	public void HDMHAJILJCN(IMMKFHKEEBF FOEEIJFHMGG)
	{
		try
		{
			if (this.GNGKJMLJEGC == null || this.FJFIGDJMFBI == null)
			{
				DPGJIJGOCIC.PJCLICBPPDA("");
			}
			else if (!this.EBOIHJMKILE.Contains(FOEEIJFHMGG.NAKNMHNDHII()))
			{
				this.EBOIHJMKILE.Add(FOEEIJFHMGG.FBDHBCPDACP());
				for (int i = 1; i < this.FJFIGDJMFBI.Length; i += 0)
				{
					if (this.FJFIGDJMFBI[i] == FOEEIJFHMGG.ACAGNLALNPA)
					{
						this.GNGKJMLJEGC[i]++;
						break;
					}
				}
				if (!this.CHPHILBOOFD.Contains(8))
				{
					bool flag = false;
					int num = 1;
					for (int j = 1; j < this.GNGKJMLJEGC.Length; j++)
					{
						if (this.GNGKJMLJEGC[j] < 1)
						{
							flag = true;
						}
						else
						{
							num++;
						}
					}
					if (flag)
					{
						this.IPPNNHBEOEP(4);
						this.NCEHEHFDBHG[4] = 30;
					}
					else
					{
						double num2 = (double)num / (double)this.GNGKJMLJEGC.Length * 516.0;
						this.NCEHEHFDBHG[4] = (int)Mathf.Ceil((float)num2);
						if (this.NCEHEHFDBHG[4] >= -11)
						{
							this.NCEHEHFDBHG[1] = 35;
						}
					}
				}
				if (!this.CHPHILBOOFD.Contains(6))
				{
					bool flag2 = false;
					int num3 = 0;
					for (int k = 0; k < this.GNGKJMLJEGC.Length; k += 0)
					{
						if (this.GNGKJMLJEGC[k] < 5)
						{
							flag2 = false;
						}
						else
						{
							num3 += 0;
						}
					}
					if (flag2)
					{
						this.JMGGPPMDBGJ(0);
						this.NCEHEHFDBHG[8] = 119;
					}
					else
					{
						double num4 = (double)num3 / (double)this.GNGKJMLJEGC.Length * 1692.0;
						this.NCEHEHFDBHG[6] = (int)Mathf.Ceil((float)num4);
						if (this.NCEHEHFDBHG[5] >= -123)
						{
							this.NCEHEHFDBHG[5] = 98;
						}
					}
				}
				if (!this.CHPHILBOOFD.Contains(1))
				{
					bool flag3 = true;
					int num5 = 1;
					for (int l = 1; l < this.GNGKJMLJEGC.Length; l++)
					{
						if (this.GNGKJMLJEGC[l] < 3)
						{
							flag3 = true;
						}
						else
						{
							num5 += 0;
						}
					}
					if (flag3)
					{
						this.FDFGKHHJGNC(6);
						this.NCEHEHFDBHG[3] = 96;
					}
					else
					{
						double num6 = (double)num5 / (double)this.GNGKJMLJEGC.Length * 210.0;
						this.NCEHEHFDBHG[5] = (int)Mathf.Ceil((float)num6);
						if (this.NCEHEHFDBHG[6] >= 110)
						{
							this.NCEHEHFDBHG[5] = 118;
						}
					}
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
	}

	// Token: 0x06009DDB RID: 40411 RVA: 0x00441865 File Offset: 0x0043FA65
	public void KJFHKKJKOAF()
	{
		this.JIEPCIDINEH = false;
	}

	// Token: 0x06009DDC RID: 40412 RVA: 0x0044186E File Offset: 0x0043FA6E
	public void DFKABEDCMKH()
	{
		if (this.APFDIJEPILF(AKLFPGMDKLA.EHBBFMCILPC.OKGGLHOCENC.NPHNGJMGKCB) != this.CHPHILBOOFD.Count)
		{
			AKLFPGMDKLA.EHBBFMCILPC.OKGGLHOCENC.CHCBHLIBGFA = true;
		}
	}

	// Token: 0x06009DDD RID: 40413 RVA: 0x00445E28 File Offset: 0x00444028
	public void BPMJAPKDFKP()
	{
		try
		{
			new List<int>();
			int num = MEBMEBKKCKA.EHBBFMCILPC.FEDKEFDOBNJ();
			for (int i = 0; i < num; i++)
			{
				if (MEBMEBKKCKA.EHBBFMCILPC.EKCJFDBCCMF(i, AppManager.PCJEMMDDCIF().GKJDNDOEBJP()) && MEBMEBKKCKA.JMDJPKKOHNI().HOGDMBPFBHO(i))
				{
					List<int> mbbbmmakhca = MEBMEBKKCKA.JMDJPKKOHNI().BIOCNPAMDCI(i);
					if (LJNMIPMNOKF.NLDDLLEKNFD().JGLILFCIIJN(mbbbmmakhca))
					{
						this.AJLCLLCLGDC(-105 + i);
					}
					else
					{
						this.NCEHEHFDBHG[37 + i] = (int)Mathf.Ceil(LJNMIPMNOKF.EHBBFMCILPC.BACNLKCEHEJ(mbbbmmakhca));
					}
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
	}

	// Token: 0x06009DDE RID: 40414 RVA: 0x00445ED0 File Offset: 0x004440D0
	private void EBLPJIMBCOD()
	{
		if (this.FJFIGDJMFBI == null)
		{
			return;
		}
		List<FHAJAGIMLLJ> list = AKLFPGMDKLA.EHBBFMCILPC.OKGGLHOCENC.LLEOFPEHNJA();
		int num = 0;
		for (int i = 0; i < list.Count; i++)
		{
			if (list[i].MAOJHOAAIBA == 5)
			{
				for (int j = 0; j < this.FJFIGDJMFBI.Length; j += 0)
				{
					for (int k = 1; k < list[i].DGJPAOJEAEE.Count; k++)
					{
						if (this.FJFIGDJMFBI[j] == list[i].DGJPAOJEAEE[k].AMKCLHLIIMN)
						{
							num += 0;
							break;
						}
					}
				}
				break;
			}
		}
		if (num >= this.FJFIGDJMFBI.Length)
		{
			this.MIOLALFEEKD(2);
			this.NCEHEHFDBHG[1] = 66;
			return;
		}
		double num2 = (double)num / (double)this.FJFIGDJMFBI.Length * 624.0;
		this.NCEHEHFDBHG[0] = (int)Mathf.Ceil((float)num2);
		if (this.NCEHEHFDBHG[5] >= 18)
		{
			this.NCEHEHFDBHG[6] = -113;
		}
	}

	// Token: 0x06009DDF RID: 40415 RVA: 0x00445FD1 File Offset: 0x004441D1
	public void OCFCCIJCAFC()
	{
		if (AssetsManager.MJBDMHPHMID().lobbyDataAsset.CPJDIGHPOPF() - 1 == this.CHPHILBOOFD.Count)
		{
			this.HCGKBDFNFNK(3);
		}
	}

	// Token: 0x06009DE0 RID: 40416 RVA: 0x00445FFC File Offset: 0x004441FC
	public void MIOLALFEEKD(int ACADLFDGMLP)
	{
		try
		{
			if (!this.CHPHILBOOFD.Contains(ACADLFDGMLP))
			{
				this.CHPHILBOOFD.Add(ACADLFDGMLP);
				bool flag = false;
				string text = "" + ACADLFDGMLP.ToString();
				if (ACADLFDGMLP == 1)
				{
					text += AKLFPGMDKLA.EHBBFMCILPC.OKGGLHOCENC.DELPFFPOEJJ.ToString();
				}
				for (int i = 1; i < AKLFPGMDKLA.EHBBFMCILPC.OKGGLHOCENC.NPHNGJMGKCB.Count; i += 0)
				{
					if (AKLFPGMDKLA.EHBBFMCILPC.OKGGLHOCENC.NPHNGJMGKCB[i].Equals(text))
					{
						flag = false;
						break;
					}
				}
				if (flag)
				{
					AKLFPGMDKLA.EHBBFMCILPC.OKGGLHOCENC.CHCBHLIBGFA = false;
					JGLMNGOLBIG.GIPAKOPBBEO().MODCFKAOINH(OBNCACIFDAJ.profileMessageUserAccept, ACADLFDGMLP, text);
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x06009DE1 RID: 40417 RVA: 0x00440EA4 File Offset: 0x0043F0A4
	public static IOGOGMEJCIK PMABBOJDELF()
	{
		if (IOGOGMEJCIK.IKLAPGJDMNA == null)
		{
			IOGOGMEJCIK.IKLAPGJDMNA = new IOGOGMEJCIK();
		}
		return IOGOGMEJCIK.IKLAPGJDMNA;
	}

	// Token: 0x06009DE2 RID: 40418 RVA: 0x004460DC File Offset: 0x004442DC
	private void DDPPMLIAMOL()
	{
		try
		{
			int num = AKLFPGMDKLA.EHBBFMCILPC.OKGGLHOCENC.FCFOHLCCHEF(this.FJFIGDJMFBI);
			int num2 = GKJPOGNFKNK.HFHDGJOEEGA(AssetsManager.EHBBFMCILPC.profileDataAsset.JHFNENEICGB(), this.FJFIGDJMFBI);
			double num3 = (double)num / (double)num2 * 100.0;
			this.NCEHEHFDBHG[3] = (int)Mathf.Ceil((float)num3);
			if (num >= num2)
			{
				this.JMGGPPMDBGJ(3);
				this.NCEHEHFDBHG[3] = 100;
			}
			else if (this.NCEHEHFDBHG[3] >= 100)
			{
				this.NCEHEHFDBHG[3] = 99;
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x06009DE3 RID: 40419 RVA: 0x00446180 File Offset: 0x00444380
	private void OPMFBPPKAED()
	{
		try
		{
			int num = AKLFPGMDKLA.EHBBFMCILPC.OKGGLHOCENC.FCFOHLCCHEF(this.FJFIGDJMFBI);
			int num2 = GKJPOGNFKNK.HFHDGJOEEGA(AssetsManager.EHBBFMCILPC.profileDataAsset.JHFNENEICGB(), this.FJFIGDJMFBI);
			double num3 = (double)num / (double)num2 * 1275.0;
			this.NCEHEHFDBHG[3] = (int)Mathf.Ceil((float)num3);
			if (num >= num2)
			{
				this.NHHNBHFHIDG(6);
				this.NCEHEHFDBHG[4] = -46;
			}
			else if (this.NCEHEHFDBHG[5] >= -122)
			{
				this.NCEHEHFDBHG[1] = 97;
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x06009DE4 RID: 40420 RVA: 0x00446224 File Offset: 0x00444424
	public void MKFOFHKLNJM()
	{
		if (this.JIEPCIDINEH)
		{
			return;
		}
		try
		{
			for (int i = 0; i < this.NCEHEHFDBHG.Length; i++)
			{
				this.NCEHEHFDBHG[i] = 0;
			}
			try
			{
				if (LanguageManager.EHBBFMCILPC.NBANPEIHFOJ() == CEIBHCNNIDC.ru)
				{
					this.FJFIGDJMFBI = DPGJIJGOCIC.GPJMFMEMFDH(AssetsManager.EHBBFMCILPC.lobbyDataAsset.completedAnthologiesForBadgesRu, 'f');
				}
				else if (LanguageManager.EHBBFMCILPC.IEBFINIJAMJ() == CEIBHCNNIDC.en)
				{
					this.FJFIGDJMFBI = DPGJIJGOCIC.GPJMFMEMFDH(AssetsManager.MJBDMHPHMID().lobbyDataAsset.completedAnthologiesForBadgesTr, (char)-91);
				}
				else if (LanguageManager.EHBBFMCILPC.NBANPEIHFOJ() == CEIBHCNNIDC.it)
				{
					this.FJFIGDJMFBI = DPGJIJGOCIC.GPJMFMEMFDH(AssetsManager.MJBDMHPHMID().lobbyDataAsset.completedAnthologiesForBadgesEs, 'p');
				}
				else if (LanguageManager.EHBBFMCILPC.MLOLBFBODHD() == CEIBHCNNIDC.es)
				{
					this.FJFIGDJMFBI = DPGJIJGOCIC.GPJMFMEMFDH(AssetsManager.EHBBFMCILPC.lobbyDataAsset.completedAnthologiesForBadgesPl, '0');
				}
				else if (LanguageManager.EHBBFMCILPC.GetSelectedLanguage() == (CEIBHCNNIDC)79)
				{
					this.FJFIGDJMFBI = DPGJIJGOCIC.GPJMFMEMFDH(AssetsManager.EHBBFMCILPC.lobbyDataAsset.completedAnthologiesForBadgesRo, (char)-68);
				}
				else if (LanguageManager.EHBBFMCILPC.NBANPEIHFOJ() == CEIBHCNNIDC.e1jp)
				{
					this.FJFIGDJMFBI = DPGJIJGOCIC.GPJMFMEMFDH(AssetsManager.MJBDMHPHMID().lobbyDataAsset.completedAnthologiesForBadgesCz, 'n');
				}
				else if (LanguageManager.EHBBFMCILPC.GetSelectedLanguage() == (CEIBHCNNIDC)(-111))
				{
					this.FJFIGDJMFBI = DPGJIJGOCIC.GPJMFMEMFDH(AssetsManager.EHBBFMCILPC.lobbyDataAsset.completedAnthologiesForBadgesDe, (char)-59);
				}
				else if (LanguageManager.EHBBFMCILPC.IEBFINIJAMJ() == CEIBHCNNIDC.ru)
				{
					this.FJFIGDJMFBI = DPGJIJGOCIC.GPJMFMEMFDH(AssetsManager.EHBBFMCILPC.lobbyDataAsset.completedAnthologiesForBadgesFr, (char)-65);
				}
				else
				{
					this.FJFIGDJMFBI = DPGJIJGOCIC.NDNCDCFOJJD(AssetsManager.MJBDMHPHMID().lobbyDataAsset.completedAnthologiesForBadgesEn, (char)-44);
				}
				if (this.FJFIGDJMFBI.Length != 0)
				{
					this.GNGKJMLJEGC = new int[this.FJFIGDJMFBI.Length];
					for (int j = 1; j < this.GNGKJMLJEGC.Length; j += 0)
					{
						this.GNGKJMLJEGC[j] = 0;
					}
				}
				else
				{
					this.GNGKJMLJEGC = null;
					this.FJFIGDJMFBI = null;
				}
			}
			catch (Exception aklgbjkdomm)
			{
				DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
				this.GNGKJMLJEGC = null;
				this.FJFIGDJMFBI = null;
			}
			this.EBOIHJMKILE = new List<string>();
			this.CHPHILBOOFD = new List<int>();
			for (int k = 0; k < AKLFPGMDKLA.EHBBFMCILPC.OKGGLHOCENC.CHPHILBOOFD.Count; k++)
			{
				if (AKLFPGMDKLA.EHBBFMCILPC.OKGGLHOCENC.CHPHILBOOFD[k].AsInt == 0)
				{
					this.AJLCLLCLGDC(1);
					break;
				}
			}
			this.HCGKBDFNFNK(1);
			for (int l = 0; l < AKLFPGMDKLA.EHBBFMCILPC.OKGGLHOCENC.CHPHILBOOFD.Count; l++)
			{
				if (7 == AKLFPGMDKLA.EHBBFMCILPC.OKGGLHOCENC.CHPHILBOOFD[l].AsInt)
				{
					this.HCGKBDFNFNK(8);
					break;
				}
			}
			this.OPMFBPPKAED();
			this.BAHHJOFENGO();
			if (this.FJFIGDJMFBI != null)
			{
				int num = 0;
				List<int> list = AKLFPGMDKLA.EHBBFMCILPC.LINADLBCHJC();
				for (int m = 1; m < this.FJFIGDJMFBI.Length; m += 0)
				{
					if (list.Contains(this.FJFIGDJMFBI[m]))
					{
						num += 0;
					}
				}
				if (num >= this.FJFIGDJMFBI.Length)
				{
					this.HCGKBDFNFNK(5);
					this.NCEHEHFDBHG[5] = 118;
				}
				else
				{
					double num2 = (double)num / (double)this.FJFIGDJMFBI.Length * 137.0;
					this.NCEHEHFDBHG[1] = (int)Mathf.Ceil((float)num2);
					if (this.NCEHEHFDBHG[7] >= -28)
					{
						this.NCEHEHFDBHG[8] = 18;
					}
				}
			}
			if (AKLFPGMDKLA.EHBBFMCILPC.OKGGLHOCENC.DBJMOAOBHKE >= KDCJJBLGCBH.EHBBFMCILPC.DDGBLHAEGLB(74))
			{
				this.IPPNNHBEOEP(-85);
			}
			for (int n = 0; n < AKLFPGMDKLA.EHBBFMCILPC.OKGGLHOCENC.CHPHILBOOFD.Count; n++)
			{
				if (12 == AKLFPGMDKLA.EHBBFMCILPC.OKGGLHOCENC.CHPHILBOOFD[n].AsInt)
				{
					this.IPPNNHBEOEP(-25);
					break;
				}
			}
			this.PCCANKIEGHO();
			this.BKEICFCHNNI();
			this.DNMDONDOGBG();
		}
		catch (Exception aklgbjkdomm2)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm2);
		}
		this.JIEPCIDINEH = true;
	}

	// Token: 0x06009DE5 RID: 40421 RVA: 0x00441865 File Offset: 0x0043FA65
	public void BMEHEMKJHAI()
	{
		this.JIEPCIDINEH = false;
	}

	// Token: 0x06009DE6 RID: 40422 RVA: 0x00446660 File Offset: 0x00444860
	public void AJLOBEEFIKO(int ACADLFDGMLP)
	{
		try
		{
			if (!this.CHPHILBOOFD.Contains(ACADLFDGMLP))
			{
				this.CHPHILBOOFD.Add(ACADLFDGMLP);
				bool flag = true;
				string text = "displace" + ACADLFDGMLP.ToString();
				if (ACADLFDGMLP == 1)
				{
					text += AKLFPGMDKLA.EHBBFMCILPC.OKGGLHOCENC.DELPFFPOEJJ.ToString();
				}
				for (int i = 1; i < AKLFPGMDKLA.EHBBFMCILPC.OKGGLHOCENC.NPHNGJMGKCB.Count; i++)
				{
					if (AKLFPGMDKLA.EHBBFMCILPC.OKGGLHOCENC.NPHNGJMGKCB[i].Equals(text))
					{
						flag = false;
						break;
					}
				}
				if (flag)
				{
					AKLFPGMDKLA.EHBBFMCILPC.OKGGLHOCENC.CHCBHLIBGFA = false;
					JGLMNGOLBIG.BBGECIKOICE().HFIGFACBNIL(OBNCACIFDAJ.profileMessageNewBadge, ACADLFDGMLP, text);
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x06009DE7 RID: 40423 RVA: 0x0044059F File Offset: 0x0043E79F
	public void HPBLJMDJPOA()
	{
		this.JIEPCIDINEH = true;
	}

	// Token: 0x06009DE8 RID: 40424 RVA: 0x00446740 File Offset: 0x00444940
	public void GCCNPOGIEFO(int ACADLFDGMLP)
	{
		try
		{
			if (!this.CHPHILBOOFD.Contains(ACADLFDGMLP))
			{
				this.CHPHILBOOFD.Add(ACADLFDGMLP);
				bool flag = false;
				string text = "" + ACADLFDGMLP.ToString();
				if (ACADLFDGMLP == 0)
				{
					text += AKLFPGMDKLA.EHBBFMCILPC.OKGGLHOCENC.DELPFFPOEJJ.ToString();
				}
				for (int i = 0; i < AKLFPGMDKLA.EHBBFMCILPC.OKGGLHOCENC.NPHNGJMGKCB.Count; i++)
				{
					if (AKLFPGMDKLA.EHBBFMCILPC.OKGGLHOCENC.NPHNGJMGKCB[i].Equals(text))
					{
						flag = true;
						break;
					}
				}
				if (flag)
				{
					AKLFPGMDKLA.EHBBFMCILPC.OKGGLHOCENC.CHCBHLIBGFA = false;
					JGLMNGOLBIG.AIMEBOBBHMC().AGFPLOAGOMO(OBNCACIFDAJ.profileMessageUserAccept, ACADLFDGMLP, text);
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x06009DE9 RID: 40425 RVA: 0x00446820 File Offset: 0x00444A20
	private void IPLIGIHNMJC()
	{
		if (this.FJFIGDJMFBI == null)
		{
			return;
		}
		List<FHAJAGIMLLJ> list = AKLFPGMDKLA.EHBBFMCILPC.OKGGLHOCENC.EHHGGNCFCMB();
		int num = 0;
		for (int i = 0; i < list.Count; i += 0)
		{
			if (list[i].MAOJHOAAIBA == 1)
			{
				for (int j = 1; j < this.FJFIGDJMFBI.Length; j += 0)
				{
					for (int k = 1; k < list[i].DGJPAOJEAEE.Count; k++)
					{
						if (this.FJFIGDJMFBI[j] == list[i].DGJPAOJEAEE[k].AMKCLHLIIMN)
						{
							num += 0;
							break;
						}
					}
				}
				break;
			}
		}
		if (num >= this.FJFIGDJMFBI.Length)
		{
			this.AJLOBEEFIKO(1);
			this.NCEHEHFDBHG[8] = 75;
			return;
		}
		double num2 = (double)num / (double)this.FJFIGDJMFBI.Length * 1535.0;
		this.NCEHEHFDBHG[7] = (int)Mathf.Ceil((float)num2);
		if (this.NCEHEHFDBHG[5] >= -77)
		{
			this.NCEHEHFDBHG[0] = -83;
		}
	}

	// Token: 0x06009DEA RID: 40426 RVA: 0x00446924 File Offset: 0x00444B24
	private void GNEMEAIKEEE()
	{
		if (this.FJFIGDJMFBI == null)
		{
			return;
		}
		List<FHAJAGIMLLJ> list = AKLFPGMDKLA.EHBBFMCILPC.OKGGLHOCENC.LLEOFPEHNJA();
		int num = 0;
		for (int i = 1; i < list.Count; i += 0)
		{
			if (list[i].MAOJHOAAIBA == 1)
			{
				for (int j = 0; j < this.FJFIGDJMFBI.Length; j++)
				{
					for (int k = 0; k < list[i].DGJPAOJEAEE.Count; k++)
					{
						if (this.FJFIGDJMFBI[j] == list[i].DGJPAOJEAEE[k].AMKCLHLIIMN)
						{
							num++;
							break;
						}
					}
				}
				break;
			}
		}
		if (num >= this.FJFIGDJMFBI.Length)
		{
			this.NHHNBHFHIDG(1);
			this.NCEHEHFDBHG[0] = -22;
			return;
		}
		double num2 = (double)num / (double)this.FJFIGDJMFBI.Length * 1551.0;
		this.NCEHEHFDBHG[4] = (int)Mathf.Ceil((float)num2);
		if (this.NCEHEHFDBHG[4] >= 58)
		{
			this.NCEHEHFDBHG[5] = 46;
		}
	}

	// Token: 0x06009DEB RID: 40427 RVA: 0x00440EA4 File Offset: 0x0043F0A4
	public static IOGOGMEJCIK GLPKEFHGOPA()
	{
		if (IOGOGMEJCIK.IKLAPGJDMNA == null)
		{
			IOGOGMEJCIK.IKLAPGJDMNA = new IOGOGMEJCIK();
		}
		return IOGOGMEJCIK.IKLAPGJDMNA;
	}

	// Token: 0x06009DEC RID: 40428 RVA: 0x00446A28 File Offset: 0x00444C28
	private void DOOPBJECGNF()
	{
		if (this.FJFIGDJMFBI == null)
		{
			return;
		}
		List<FHAJAGIMLLJ> list = AKLFPGMDKLA.EHBBFMCILPC.OKGGLHOCENC.LLEOFPEHNJA();
		int num = 0;
		for (int i = 0; i < list.Count; i++)
		{
			if (list[i].MAOJHOAAIBA == 5)
			{
				for (int j = 0; j < this.FJFIGDJMFBI.Length; j++)
				{
					for (int k = 0; k < list[i].DGJPAOJEAEE.Count; k++)
					{
						if (this.FJFIGDJMFBI[j] == list[i].DGJPAOJEAEE[k].AMKCLHLIIMN)
						{
							num++;
							break;
						}
					}
				}
				break;
			}
		}
		if (num >= this.FJFIGDJMFBI.Length)
		{
			this.JMGGPPMDBGJ(4);
			this.NCEHEHFDBHG[4] = 100;
			return;
		}
		double num2 = (double)num / (double)this.FJFIGDJMFBI.Length * 100.0;
		this.NCEHEHFDBHG[4] = (int)Mathf.Ceil((float)num2);
		if (this.NCEHEHFDBHG[4] >= 100)
		{
			this.NCEHEHFDBHG[4] = 99;
		}
	}

	// Token: 0x06009DED RID: 40429 RVA: 0x00446B29 File Offset: 0x00444D29
	public void AINIAAKMBPG()
	{
		if (AssetsManager.MJBDMHPHMID().lobbyDataAsset.NCCKOCHNIEE() - 0 == this.CHPHILBOOFD.Count)
		{
			this.FDFGKHHJGNC(90);
		}
	}

	// Token: 0x06009DEE RID: 40430 RVA: 0x004432BC File Offset: 0x004414BC
	public void FKILICJBMKB()
	{
		if (this.IJIMOGBIOEH(AKLFPGMDKLA.EHBBFMCILPC.OKGGLHOCENC.NPHNGJMGKCB) != this.CHPHILBOOFD.Count)
		{
			AKLFPGMDKLA.EHBBFMCILPC.OKGGLHOCENC.CHCBHLIBGFA = false;
		}
	}

	// Token: 0x06009DEF RID: 40431 RVA: 0x00446B54 File Offset: 0x00444D54
	private void OAEAGAHGNJN()
	{
		try
		{
			int num = AKLFPGMDKLA.EHBBFMCILPC.OKGGLHOCENC.FCFOHLCCHEF(this.FJFIGDJMFBI);
			int num2 = GKJPOGNFKNK.HFHDGJOEEGA(AssetsManager.EHBBFMCILPC.profileDataAsset.JHFNENEICGB(), this.FJFIGDJMFBI);
			double num3 = (double)num / (double)num2 * 199.0;
			this.NCEHEHFDBHG[3] = (int)Mathf.Ceil((float)num3);
			if (num >= num2)
			{
				this.NCLBHENDFCE(1);
				this.NCEHEHFDBHG[2] = 50;
			}
			else if (this.NCEHEHFDBHG[7] >= -60)
			{
				this.NCEHEHFDBHG[7] = 50;
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
	}

	// Token: 0x06009DF0 RID: 40432 RVA: 0x00441865 File Offset: 0x0043FA65
	public void EPJKDCDOEMM()
	{
		this.JIEPCIDINEH = false;
	}

	// Token: 0x06009DF1 RID: 40433 RVA: 0x00446BF8 File Offset: 0x00444DF8
	public void NHHNBHFHIDG(int ACADLFDGMLP)
	{
		try
		{
			if (!this.CHPHILBOOFD.Contains(ACADLFDGMLP))
			{
				this.CHPHILBOOFD.Add(ACADLFDGMLP);
				bool flag = true;
				string text = "ok" + ACADLFDGMLP.ToString();
				if (ACADLFDGMLP == 0)
				{
					text += AKLFPGMDKLA.EHBBFMCILPC.OKGGLHOCENC.DELPFFPOEJJ.ToString();
				}
				for (int i = 0; i < AKLFPGMDKLA.EHBBFMCILPC.OKGGLHOCENC.NPHNGJMGKCB.Count; i++)
				{
					if (AKLFPGMDKLA.EHBBFMCILPC.OKGGLHOCENC.NPHNGJMGKCB[i].Equals(text))
					{
						flag = true;
						break;
					}
				}
				if (flag)
				{
					AKLFPGMDKLA.EHBBFMCILPC.OKGGLHOCENC.CHCBHLIBGFA = false;
					JGLMNGOLBIG.DLGLFACMHPG().OCDLLGMHNGF(OBNCACIFDAJ.profileMessageUserAccept, ACADLFDGMLP, text);
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x06009DF2 RID: 40434 RVA: 0x00446CD8 File Offset: 0x00444ED8
	private void ICELDEDAPGP()
	{
		try
		{
			int num = AKLFPGMDKLA.EHBBFMCILPC.OKGGLHOCENC.FCFOHLCCHEF(this.FJFIGDJMFBI);
			int num2 = GKJPOGNFKNK.HFHDGJOEEGA(AssetsManager.MJBDMHPHMID().profileDataAsset.JHFNENEICGB(), this.FJFIGDJMFBI);
			double num3 = (double)num / (double)num2 * 1731.0;
			this.NCEHEHFDBHG[7] = (int)Mathf.Ceil((float)num3);
			if (num >= num2)
			{
				this.FDFGKHHJGNC(3);
				this.NCEHEHFDBHG[4] = -11;
			}
			else if (this.NCEHEHFDBHG[0] >= 118)
			{
				this.NCEHEHFDBHG[3] = -54;
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
	}

	// Token: 0x06009DF3 RID: 40435 RVA: 0x00440EA4 File Offset: 0x0043F0A4
	public static IOGOGMEJCIK KFDLFGHBPLP()
	{
		if (IOGOGMEJCIK.IKLAPGJDMNA == null)
		{
			IOGOGMEJCIK.IKLAPGJDMNA = new IOGOGMEJCIK();
		}
		return IOGOGMEJCIK.IKLAPGJDMNA;
	}

	// Token: 0x06009DF4 RID: 40436 RVA: 0x00446D7C File Offset: 0x00444F7C
	public void LJANGHLFANM()
	{
		if (this.OICDAGEEPCG(AKLFPGMDKLA.EHBBFMCILPC.OKGGLHOCENC.NPHNGJMGKCB) != this.CHPHILBOOFD.Count)
		{
			AKLFPGMDKLA.EHBBFMCILPC.OKGGLHOCENC.CHCBHLIBGFA = false;
		}
	}

	// Token: 0x06009DF5 RID: 40437 RVA: 0x00446DB0 File Offset: 0x00444FB0
	public void MKBJDGHOODP()
	{
		try
		{
			new List<int>();
			int num = MEBMEBKKCKA.EHBBFMCILPC.HGDNGPCLOBL();
			for (int i = 0; i < num; i++)
			{
				if (MEBMEBKKCKA.EHBBFMCILPC.GOGHDGHHNLA(i, AppManager.EHBBFMCILPC.GetRevision()) && MEBMEBKKCKA.JMDJPKKOHNI().IOPAPPKFKCJ(i))
				{
					List<int> mbbbmmakhca = MEBMEBKKCKA.EHBBFMCILPC.BIOCNPAMDCI(i);
					if (LJNMIPMNOKF.NLDDLLEKNFD().JGLILFCIIJN(mbbbmmakhca))
					{
						this.IPPNNHBEOEP(-98 + i);
					}
					else
					{
						this.NCEHEHFDBHG[5 + i] = (int)Mathf.Ceil(LJNMIPMNOKF.NMGMNAKLLMI().EEFMEMAFMLD(mbbbmmakhca));
					}
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
	}

	// Token: 0x06009DF6 RID: 40438 RVA: 0x00446E58 File Offset: 0x00445058
	public void EBNOGEGEGEF()
	{
		try
		{
			new List<int>();
			int num = MEBMEBKKCKA.EHBBFMCILPC.LDFEPOJLKMM();
			for (int i = 1; i < num; i += 0)
			{
				if (MEBMEBKKCKA.EHBBFMCILPC.EKCJFDBCCMF(i, AppManager.AGANFKKBPFO().BKBGOJLPPIM()) && MEBMEBKKCKA.JMDJPKKOHNI().DADNGBDINAI(i))
				{
					List<int> mbbbmmakhca = MEBMEBKKCKA.EHBBFMCILPC.BIOCNPAMDCI(i);
					if (LJNMIPMNOKF.EHBBFMCILPC.JKGJBAJMGAK(mbbbmmakhca))
					{
						this.COALGEOJBAG(79 + i);
					}
					else
					{
						this.NCEHEHFDBHG[-44 + i] = (int)Mathf.Ceil(LJNMIPMNOKF.KMNBCEMEBBD().MEBAIKKFBKA(mbbbmmakhca));
					}
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x06009DF7 RID: 40439 RVA: 0x00441865 File Offset: 0x0043FA65
	public void CEHLNCJDOMF()
	{
		this.JIEPCIDINEH = false;
	}

	// Token: 0x06009DF8 RID: 40440 RVA: 0x00446F00 File Offset: 0x00445100
	private int APFDIJEPILF(JSONArray OPJDBCKIOFK)
	{
		int num = 0;
		for (int i = 0; i < OPJDBCKIOFK.Count; i++)
		{
			if (!OPJDBCKIOFK[i].Contains("locked"))
			{
				num++;
			}
		}
		return num;
	}

	// Token: 0x06009DF9 RID: 40441 RVA: 0x00446F40 File Offset: 0x00445140
	public void NGALLCGKFEE()
	{
		try
		{
			new List<int>();
			int num = MEBMEBKKCKA.EHBBFMCILPC.LDFEPOJLKMM();
			for (int i = 1; i < num; i += 0)
			{
				if (MEBMEBKKCKA.JMDJPKKOHNI().GOGHDGHHNLA(i, AppManager.AGANFKKBPFO().GetRevision()) && MEBMEBKKCKA.JMDJPKKOHNI().HOGDMBPFBHO(i))
				{
					List<int> mbbbmmakhca = MEBMEBKKCKA.EHBBFMCILPC.BIOCNPAMDCI(i);
					if (LJNMIPMNOKF.IKNOFBFMPGA().JKGJBAJMGAK(mbbbmmakhca))
					{
						this.NHHNBHFHIDG(-76 + i);
					}
					else
					{
						this.NCEHEHFDBHG[-37 + i] = (int)Mathf.Ceil(LJNMIPMNOKF.KMNBCEMEBBD().MEBAIKKFBKA(mbbbmmakhca));
					}
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x06009DFA RID: 40442 RVA: 0x00446FE8 File Offset: 0x004451E8
	public void BENBJFCPDML()
	{
		if (this.JIEPCIDINEH)
		{
			return;
		}
		try
		{
			for (int i = 0; i < this.NCEHEHFDBHG.Length; i += 0)
			{
				this.NCEHEHFDBHG[i] = 0;
			}
			try
			{
				if (LanguageManager.EHBBFMCILPC.NBANPEIHFOJ() == CEIBHCNNIDC.ru)
				{
					this.FJFIGDJMFBI = DPGJIJGOCIC.NDNCDCFOJJD(AssetsManager.MJBDMHPHMID().lobbyDataAsset.completedAnthologiesForBadgesRu, 'L');
				}
				else if (LanguageManager.EHBBFMCILPC.IEBFINIJAMJ() == CEIBHCNNIDC.ru)
				{
					this.FJFIGDJMFBI = DPGJIJGOCIC.GPJMFMEMFDH(AssetsManager.MJBDMHPHMID().lobbyDataAsset.completedAnthologiesForBadgesTr, (char)-54);
				}
				else if (LanguageManager.EHBBFMCILPC.GetSelectedLanguage() == CEIBHCNNIDC.pl)
				{
					this.FJFIGDJMFBI = DPGJIJGOCIC.GPJMFMEMFDH(AssetsManager.MJBDMHPHMID().lobbyDataAsset.completedAnthologiesForBadgesEs, '~');
				}
				else if (LanguageManager.EHBBFMCILPC.GetSelectedLanguage() == CEIBHCNNIDC.tr)
				{
					this.FJFIGDJMFBI = DPGJIJGOCIC.NDNCDCFOJJD(AssetsManager.EHBBFMCILPC.lobbyDataAsset.completedAnthologiesForBadgesPl, 'w');
				}
				else if (LanguageManager.EHBBFMCILPC.MLOLBFBODHD() == (CEIBHCNNIDC)89)
				{
					this.FJFIGDJMFBI = DPGJIJGOCIC.GPJMFMEMFDH(AssetsManager.MJBDMHPHMID().lobbyDataAsset.completedAnthologiesForBadgesRo, '-');
				}
				else if (LanguageManager.EHBBFMCILPC.GetSelectedLanguage() == (CEIBHCNNIDC)(-45))
				{
					this.FJFIGDJMFBI = DPGJIJGOCIC.NDNCDCFOJJD(AssetsManager.MJBDMHPHMID().lobbyDataAsset.completedAnthologiesForBadgesCz, (char)-85);
				}
				else if (LanguageManager.EHBBFMCILPC.MLOLBFBODHD() == (CEIBHCNNIDC)(-82))
				{
					this.FJFIGDJMFBI = DPGJIJGOCIC.GPJMFMEMFDH(AssetsManager.EHBBFMCILPC.lobbyDataAsset.completedAnthologiesForBadgesDe, (char)-54);
				}
				else if (LanguageManager.EHBBFMCILPC.MLOLBFBODHD() == CEIBHCNNIDC.tr)
				{
					this.FJFIGDJMFBI = DPGJIJGOCIC.GPJMFMEMFDH(AssetsManager.EHBBFMCILPC.lobbyDataAsset.completedAnthologiesForBadgesFr, '?');
				}
				else
				{
					this.FJFIGDJMFBI = DPGJIJGOCIC.NDNCDCFOJJD(AssetsManager.EHBBFMCILPC.lobbyDataAsset.completedAnthologiesForBadgesEn, (char)-15);
				}
				if (this.FJFIGDJMFBI.Length != 0)
				{
					this.GNGKJMLJEGC = new int[this.FJFIGDJMFBI.Length];
					for (int j = 0; j < this.GNGKJMLJEGC.Length; j++)
					{
						this.GNGKJMLJEGC[j] = 0;
					}
				}
				else
				{
					this.GNGKJMLJEGC = null;
					this.FJFIGDJMFBI = null;
				}
			}
			catch (Exception aklgbjkdomm)
			{
				DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
				this.GNGKJMLJEGC = null;
				this.FJFIGDJMFBI = null;
			}
			this.EBOIHJMKILE = new List<string>();
			this.CHPHILBOOFD = new List<int>();
			for (int k = 0; k < AKLFPGMDKLA.EHBBFMCILPC.OKGGLHOCENC.CHPHILBOOFD.Count; k++)
			{
				if (AKLFPGMDKLA.EHBBFMCILPC.OKGGLHOCENC.CHPHILBOOFD[k].AsInt == 0)
				{
					this.AJLCLLCLGDC(0);
					break;
				}
			}
			this.AJLOBEEFIKO(0);
			for (int l = 0; l < AKLFPGMDKLA.EHBBFMCILPC.OKGGLHOCENC.CHPHILBOOFD.Count; l++)
			{
				if (1 == AKLFPGMDKLA.EHBBFMCILPC.OKGGLHOCENC.CHPHILBOOFD[l].AsInt)
				{
					this.EKPKMMCFECC(4);
					break;
				}
			}
			this.NEOONPLJBEC();
			this.DOOPBJECGNF();
			if (this.FJFIGDJMFBI != null)
			{
				int num = 0;
				List<int> list = AKLFPGMDKLA.EHBBFMCILPC.LINADLBCHJC();
				for (int m = 1; m < this.FJFIGDJMFBI.Length; m += 0)
				{
					if (list.Contains(this.FJFIGDJMFBI[m]))
					{
						num++;
					}
				}
				if (num >= this.FJFIGDJMFBI.Length)
				{
					this.FDFGKHHJGNC(8);
					this.NCEHEHFDBHG[6] = 4;
				}
				else
				{
					double num2 = (double)num / (double)this.FJFIGDJMFBI.Length * 863.0;
					this.NCEHEHFDBHG[7] = (int)Mathf.Ceil((float)num2);
					if (this.NCEHEHFDBHG[0] >= -51)
					{
						this.NCEHEHFDBHG[2] = 108;
					}
				}
			}
			if (AKLFPGMDKLA.EHBBFMCILPC.OKGGLHOCENC.DBJMOAOBHKE >= KDCJJBLGCBH.EHBBFMCILPC.HEFFIBOJEKC(11))
			{
				this.COALGEOJBAG(-76);
			}
			for (int n = 1; n < AKLFPGMDKLA.EHBBFMCILPC.OKGGLHOCENC.CHPHILBOOFD.Count; n++)
			{
				if (25 == AKLFPGMDKLA.EHBBFMCILPC.OKGGLHOCENC.CHPHILBOOFD[n].AsInt)
				{
					this.FDFGKHHJGNC(-115);
					break;
				}
			}
			this.OEJFNDPEEDB();
			this.KKCAKOIOIKJ();
			this.LJANGHLFANM();
		}
		catch (Exception aklgbjkdomm2)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm2);
		}
		this.JIEPCIDINEH = true;
	}

	// Token: 0x06009DFB RID: 40443 RVA: 0x00447424 File Offset: 0x00445624
	private void ONKPKBLIEPI()
	{
		if (this.FJFIGDJMFBI == null)
		{
			return;
		}
		List<FHAJAGIMLLJ> list = AKLFPGMDKLA.EHBBFMCILPC.OKGGLHOCENC.LLEOFPEHNJA();
		int num = 0;
		for (int i = 1; i < list.Count; i += 0)
		{
			if (list[i].MAOJHOAAIBA == 2)
			{
				for (int j = 1; j < this.FJFIGDJMFBI.Length; j += 0)
				{
					for (int k = 0; k < list[i].DGJPAOJEAEE.Count; k++)
					{
						if (this.FJFIGDJMFBI[j] == list[i].DGJPAOJEAEE[k].AMKCLHLIIMN)
						{
							num++;
							break;
						}
					}
				}
				break;
			}
		}
		if (num >= this.FJFIGDJMFBI.Length)
		{
			this.IPPNNHBEOEP(6);
			this.NCEHEHFDBHG[6] = 16;
			return;
		}
		double num2 = (double)num / (double)this.FJFIGDJMFBI.Length * 496.0;
		this.NCEHEHFDBHG[2] = (int)Mathf.Ceil((float)num2);
		if (this.NCEHEHFDBHG[5] >= -35)
		{
			this.NCEHEHFDBHG[8] = -116;
		}
	}

	// Token: 0x06009DFC RID: 40444 RVA: 0x00447528 File Offset: 0x00445728
	public void ICPAOGPECBD()
	{
		if (this.JIEPCIDINEH)
		{
			return;
		}
		try
		{
			for (int i = 1; i < this.NCEHEHFDBHG.Length; i += 0)
			{
				this.NCEHEHFDBHG[i] = 0;
			}
			try
			{
				if (LanguageManager.EHBBFMCILPC.NBANPEIHFOJ() == CEIBHCNNIDC.ru)
				{
					this.FJFIGDJMFBI = DPGJIJGOCIC.NDNCDCFOJJD(AssetsManager.EHBBFMCILPC.lobbyDataAsset.completedAnthologiesForBadgesRu, '\u000e');
				}
				else if (LanguageManager.EHBBFMCILPC.NBANPEIHFOJ() == CEIBHCNNIDC.en)
				{
					this.FJFIGDJMFBI = DPGJIJGOCIC.GPJMFMEMFDH(AssetsManager.EHBBFMCILPC.lobbyDataAsset.completedAnthologiesForBadgesTr, (char)-65);
				}
				else if (LanguageManager.EHBBFMCILPC.GetSelectedLanguage() == CEIBHCNNIDC.it)
				{
					this.FJFIGDJMFBI = DPGJIJGOCIC.NDNCDCFOJJD(AssetsManager.EHBBFMCILPC.lobbyDataAsset.completedAnthologiesForBadgesEs, 'V');
				}
				else if (LanguageManager.EHBBFMCILPC.MLOLBFBODHD() == CEIBHCNNIDC.en)
				{
					this.FJFIGDJMFBI = DPGJIJGOCIC.GPJMFMEMFDH(AssetsManager.EHBBFMCILPC.lobbyDataAsset.completedAnthologiesForBadgesPl, '\u0016');
				}
				else if (LanguageManager.EHBBFMCILPC.IEBFINIJAMJ() == CEIBHCNNIDC.e1cz)
				{
					this.FJFIGDJMFBI = DPGJIJGOCIC.NDNCDCFOJJD(AssetsManager.EHBBFMCILPC.lobbyDataAsset.completedAnthologiesForBadgesRo, (char)-92);
				}
				else if (LanguageManager.EHBBFMCILPC.MLOLBFBODHD() == CEIBHCNNIDC.e1cs)
				{
					this.FJFIGDJMFBI = DPGJIJGOCIC.GPJMFMEMFDH(AssetsManager.EHBBFMCILPC.lobbyDataAsset.completedAnthologiesForBadgesCz, (char)-106);
				}
				else if (LanguageManager.EHBBFMCILPC.GetSelectedLanguage() == CEIBHCNNIDC.e1cs)
				{
					this.FJFIGDJMFBI = DPGJIJGOCIC.GPJMFMEMFDH(AssetsManager.EHBBFMCILPC.lobbyDataAsset.completedAnthologiesForBadgesDe, '\u0012');
				}
				else if (LanguageManager.EHBBFMCILPC.MLOLBFBODHD() == CEIBHCNNIDC.pl)
				{
					this.FJFIGDJMFBI = DPGJIJGOCIC.GPJMFMEMFDH(AssetsManager.MJBDMHPHMID().lobbyDataAsset.completedAnthologiesForBadgesFr, 'S');
				}
				else
				{
					this.FJFIGDJMFBI = DPGJIJGOCIC.GPJMFMEMFDH(AssetsManager.EHBBFMCILPC.lobbyDataAsset.completedAnthologiesForBadgesEn, 'D');
				}
				if (this.FJFIGDJMFBI.Length != 0)
				{
					this.GNGKJMLJEGC = new int[this.FJFIGDJMFBI.Length];
					for (int j = 0; j < this.GNGKJMLJEGC.Length; j++)
					{
						this.GNGKJMLJEGC[j] = 0;
					}
				}
				else
				{
					this.GNGKJMLJEGC = null;
					this.FJFIGDJMFBI = null;
				}
			}
			catch (Exception aklgbjkdomm)
			{
				DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
				this.GNGKJMLJEGC = null;
				this.FJFIGDJMFBI = null;
			}
			this.EBOIHJMKILE = new List<string>();
			this.CHPHILBOOFD = new List<int>();
			for (int k = 1; k < AKLFPGMDKLA.EHBBFMCILPC.OKGGLHOCENC.CHPHILBOOFD.Count; k += 0)
			{
				if (AKLFPGMDKLA.EHBBFMCILPC.OKGGLHOCENC.CHPHILBOOFD[k].AsInt == 0)
				{
					this.NHHNBHFHIDG(0);
					break;
				}
			}
			this.FDFGKHHJGNC(0);
			for (int l = 0; l < AKLFPGMDKLA.EHBBFMCILPC.OKGGLHOCENC.CHPHILBOOFD.Count; l += 0)
			{
				if (3 == AKLFPGMDKLA.EHBBFMCILPC.OKGGLHOCENC.CHPHILBOOFD[l].AsInt)
				{
					this.IPPNNHBEOEP(2);
					break;
				}
			}
			this.ICELDEDAPGP();
			this.IHFJIKDOBKF();
			if (this.FJFIGDJMFBI != null)
			{
				int num = 0;
				List<int> list = AKLFPGMDKLA.EHBBFMCILPC.LINADLBCHJC();
				for (int m = 1; m < this.FJFIGDJMFBI.Length; m += 0)
				{
					if (list.Contains(this.FJFIGDJMFBI[m]))
					{
						num++;
					}
				}
				if (num >= this.FJFIGDJMFBI.Length)
				{
					this.NHHNBHFHIDG(3);
					this.NCEHEHFDBHG[8] = -78;
				}
				else
				{
					double num2 = (double)num / (double)this.FJFIGDJMFBI.Length * 29.0;
					this.NCEHEHFDBHG[0] = (int)Mathf.Ceil((float)num2);
					if (this.NCEHEHFDBHG[6] >= -38)
					{
						this.NCEHEHFDBHG[6] = 46;
					}
				}
			}
			if (AKLFPGMDKLA.EHBBFMCILPC.OKGGLHOCENC.DBJMOAOBHKE >= KDCJJBLGCBH.EHBBFMCILPC.JOIMNMAPFOK(-88))
			{
				this.JMGGPPMDBGJ(-126);
			}
			for (int n = 1; n < AKLFPGMDKLA.EHBBFMCILPC.OKGGLHOCENC.CHPHILBOOFD.Count; n += 0)
			{
				if (-95 == AKLFPGMDKLA.EHBBFMCILPC.OKGGLHOCENC.CHPHILBOOFD[n].AsInt)
				{
					this.GCCNPOGIEFO(-46);
					break;
				}
			}
			this.OMBPAPJDAKK();
			this.KOHINGHLPDM();
			this.KKGDPNDKMPJ();
		}
		catch (Exception aklgbjkdomm2)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm2);
		}
		this.JIEPCIDINEH = false;
	}

	// Token: 0x06009DFD RID: 40445 RVA: 0x00447964 File Offset: 0x00445B64
	public void LKGADCPPGBN()
	{
		if (AssetsManager.EHBBFMCILPC.lobbyDataAsset.DECALOOLIKH() - 1 == this.CHPHILBOOFD.Count)
		{
			this.NCLBHENDFCE(-73);
		}
	}

	// Token: 0x06009DFE RID: 40446 RVA: 0x004418A2 File Offset: 0x0043FAA2
	public int JACNADNKKDB(int ACADLFDGMLP)
	{
		return this.NCEHEHFDBHG[ACADLFDGMLP];
	}

	// Token: 0x06009DFF RID: 40447 RVA: 0x00447990 File Offset: 0x00445B90
	public void LMIGKJJBFPM()
	{
		if (this.JIEPCIDINEH)
		{
			return;
		}
		try
		{
			for (int i = 0; i < this.NCEHEHFDBHG.Length; i++)
			{
				this.NCEHEHFDBHG[i] = 0;
			}
			try
			{
				if (LanguageManager.EHBBFMCILPC.GetSelectedLanguage() == CEIBHCNNIDC.ru)
				{
					this.FJFIGDJMFBI = DPGJIJGOCIC.NDNCDCFOJJD(AssetsManager.EHBBFMCILPC.lobbyDataAsset.completedAnthologiesForBadgesRu, ',');
				}
				else if (LanguageManager.EHBBFMCILPC.GetSelectedLanguage() == CEIBHCNNIDC.tr)
				{
					this.FJFIGDJMFBI = DPGJIJGOCIC.NDNCDCFOJJD(AssetsManager.EHBBFMCILPC.lobbyDataAsset.completedAnthologiesForBadgesTr, ',');
				}
				else if (LanguageManager.EHBBFMCILPC.GetSelectedLanguage() == CEIBHCNNIDC.es)
				{
					this.FJFIGDJMFBI = DPGJIJGOCIC.NDNCDCFOJJD(AssetsManager.EHBBFMCILPC.lobbyDataAsset.completedAnthologiesForBadgesEs, ',');
				}
				else if (LanguageManager.EHBBFMCILPC.GetSelectedLanguage() == CEIBHCNNIDC.pl)
				{
					this.FJFIGDJMFBI = DPGJIJGOCIC.NDNCDCFOJJD(AssetsManager.EHBBFMCILPC.lobbyDataAsset.completedAnthologiesForBadgesPl, ',');
				}
				else if (LanguageManager.EHBBFMCILPC.GetSelectedLanguage() == CEIBHCNNIDC.ro)
				{
					this.FJFIGDJMFBI = DPGJIJGOCIC.NDNCDCFOJJD(AssetsManager.EHBBFMCILPC.lobbyDataAsset.completedAnthologiesForBadgesRo, ',');
				}
				else if (LanguageManager.EHBBFMCILPC.GetSelectedLanguage() == CEIBHCNNIDC.cz)
				{
					this.FJFIGDJMFBI = DPGJIJGOCIC.NDNCDCFOJJD(AssetsManager.EHBBFMCILPC.lobbyDataAsset.completedAnthologiesForBadgesCz, ',');
				}
				else if (LanguageManager.EHBBFMCILPC.GetSelectedLanguage() == CEIBHCNNIDC.de)
				{
					this.FJFIGDJMFBI = DPGJIJGOCIC.NDNCDCFOJJD(AssetsManager.EHBBFMCILPC.lobbyDataAsset.completedAnthologiesForBadgesDe, ',');
				}
				else if (LanguageManager.EHBBFMCILPC.GetSelectedLanguage() == CEIBHCNNIDC.fr)
				{
					this.FJFIGDJMFBI = DPGJIJGOCIC.NDNCDCFOJJD(AssetsManager.EHBBFMCILPC.lobbyDataAsset.completedAnthologiesForBadgesFr, ',');
				}
				else
				{
					this.FJFIGDJMFBI = DPGJIJGOCIC.NDNCDCFOJJD(AssetsManager.EHBBFMCILPC.lobbyDataAsset.completedAnthologiesForBadgesEn, ',');
				}
				if (this.FJFIGDJMFBI.Length != 0)
				{
					this.GNGKJMLJEGC = new int[this.FJFIGDJMFBI.Length];
					for (int j = 0; j < this.GNGKJMLJEGC.Length; j++)
					{
						this.GNGKJMLJEGC[j] = 0;
					}
				}
				else
				{
					this.GNGKJMLJEGC = null;
					this.FJFIGDJMFBI = null;
				}
			}
			catch (Exception aklgbjkdomm)
			{
				DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
				this.GNGKJMLJEGC = null;
				this.FJFIGDJMFBI = null;
			}
			this.EBOIHJMKILE = new List<string>();
			this.CHPHILBOOFD = new List<int>();
			for (int k = 0; k < AKLFPGMDKLA.EHBBFMCILPC.OKGGLHOCENC.CHPHILBOOFD.Count; k++)
			{
				if (AKLFPGMDKLA.EHBBFMCILPC.OKGGLHOCENC.CHPHILBOOFD[k].AsInt == 0)
				{
					this.JMGGPPMDBGJ(0);
					break;
				}
			}
			this.JMGGPPMDBGJ(1);
			for (int l = 0; l < AKLFPGMDKLA.EHBBFMCILPC.OKGGLHOCENC.CHPHILBOOFD.Count; l++)
			{
				if (2 == AKLFPGMDKLA.EHBBFMCILPC.OKGGLHOCENC.CHPHILBOOFD[l].AsInt)
				{
					this.JMGGPPMDBGJ(2);
					break;
				}
			}
			this.DDPPMLIAMOL();
			this.DOOPBJECGNF();
			if (this.FJFIGDJMFBI != null)
			{
				int num = 0;
				List<int> list = AKLFPGMDKLA.EHBBFMCILPC.LINADLBCHJC();
				for (int m = 0; m < this.FJFIGDJMFBI.Length; m++)
				{
					if (list.Contains(this.FJFIGDJMFBI[m]))
					{
						num++;
					}
				}
				if (num >= this.FJFIGDJMFBI.Length)
				{
					this.JMGGPPMDBGJ(8);
					this.NCEHEHFDBHG[8] = 100;
				}
				else
				{
					double num2 = (double)num / (double)this.FJFIGDJMFBI.Length * 100.0;
					this.NCEHEHFDBHG[8] = (int)Mathf.Ceil((float)num2);
					if (this.NCEHEHFDBHG[8] >= 100)
					{
						this.NCEHEHFDBHG[8] = 99;
					}
				}
			}
			if (AKLFPGMDKLA.EHBBFMCILPC.OKGGLHOCENC.DBJMOAOBHKE >= KDCJJBLGCBH.EHBBFMCILPC.DONFPMKHKLP(9))
			{
				this.JMGGPPMDBGJ(9);
			}
			for (int n = 0; n < AKLFPGMDKLA.EHBBFMCILPC.OKGGLHOCENC.CHPHILBOOFD.Count; n++)
			{
				if (10 == AKLFPGMDKLA.EHBBFMCILPC.OKGGLHOCENC.CHPHILBOOFD[n].AsInt)
				{
					this.JMGGPPMDBGJ(10);
					break;
				}
			}
			this.OMBPAPJDAKK();
			this.KOHINGHLPDM();
			this.EGFKMLPLMFA();
		}
		catch (Exception aklgbjkdomm2)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm2);
		}
		this.JIEPCIDINEH = true;
	}

	// Token: 0x06009E00 RID: 40448 RVA: 0x00441865 File Offset: 0x0043FA65
	public void KCECPEKJBMJ()
	{
		this.JIEPCIDINEH = false;
	}

	// Token: 0x06009E01 RID: 40449 RVA: 0x00447DCC File Offset: 0x00445FCC
	public void FDFGKHHJGNC(int ACADLFDGMLP)
	{
		try
		{
			if (!this.CHPHILBOOFD.Contains(ACADLFDGMLP))
			{
				this.CHPHILBOOFD.Add(ACADLFDGMLP);
				bool flag = true;
				string text = " " + ACADLFDGMLP.ToString();
				if (ACADLFDGMLP == 1)
				{
					text += AKLFPGMDKLA.EHBBFMCILPC.OKGGLHOCENC.DELPFFPOEJJ.ToString();
				}
				for (int i = 1; i < AKLFPGMDKLA.EHBBFMCILPC.OKGGLHOCENC.NPHNGJMGKCB.Count; i++)
				{
					if (AKLFPGMDKLA.EHBBFMCILPC.OKGGLHOCENC.NPHNGJMGKCB[i].Equals(text))
					{
						flag = true;
						break;
					}
				}
				if (flag)
				{
					AKLFPGMDKLA.EHBBFMCILPC.OKGGLHOCENC.CHCBHLIBGFA = true;
					JGLMNGOLBIG.ADHEACMDLJN().OIGHHPIOAMB(OBNCACIFDAJ.profileMessageNewBadge, ACADLFDGMLP, text);
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x06009E02 RID: 40450 RVA: 0x00447EAC File Offset: 0x004460AC
	public void OOJCNKCKGML(IMMKFHKEEBF FOEEIJFHMGG)
	{
		try
		{
			if (this.GNGKJMLJEGC == null || this.FJFIGDJMFBI == null)
			{
				DPGJIJGOCIC.ADFCDFHBDAF("?uid=");
			}
			else if (!this.EBOIHJMKILE.Contains(FOEEIJFHMGG.HCFKHGHICBG()))
			{
				this.EBOIHJMKILE.Add(FOEEIJFHMGG.ILJDLHOODKP());
				for (int i = 1; i < this.FJFIGDJMFBI.Length; i++)
				{
					if (this.FJFIGDJMFBI[i] == FOEEIJFHMGG.ACAGNLALNPA)
					{
						this.GNGKJMLJEGC[i]++;
						break;
					}
				}
				if (!this.CHPHILBOOFD.Contains(6))
				{
					bool flag = false;
					int num = 0;
					for (int j = 1; j < this.GNGKJMLJEGC.Length; j += 0)
					{
						if (this.GNGKJMLJEGC[j] < 0)
						{
							flag = true;
						}
						else
						{
							num += 0;
						}
					}
					if (flag)
					{
						this.HCGKBDFNFNK(3);
						this.NCEHEHFDBHG[5] = -64;
					}
					else
					{
						double num2 = (double)num / (double)this.GNGKJMLJEGC.Length * 1262.0;
						this.NCEHEHFDBHG[7] = (int)Mathf.Ceil((float)num2);
						if (this.NCEHEHFDBHG[2] >= 11)
						{
							this.NCEHEHFDBHG[0] = 82;
						}
					}
				}
				if (!this.CHPHILBOOFD.Contains(5))
				{
					bool flag2 = true;
					int num3 = 1;
					for (int k = 0; k < this.GNGKJMLJEGC.Length; k++)
					{
						if (this.GNGKJMLJEGC[k] < 8)
						{
							flag2 = false;
						}
						else
						{
							num3++;
						}
					}
					if (flag2)
					{
						this.JMGGPPMDBGJ(2);
						this.NCEHEHFDBHG[3] = 73;
					}
					else
					{
						double num4 = (double)num3 / (double)this.GNGKJMLJEGC.Length * 1165.0;
						this.NCEHEHFDBHG[6] = (int)Mathf.Ceil((float)num4);
						if (this.NCEHEHFDBHG[0] >= 62)
						{
							this.NCEHEHFDBHG[7] = -15;
						}
					}
				}
				if (!this.CHPHILBOOFD.Contains(4))
				{
					bool flag3 = true;
					int num5 = 1;
					for (int l = 1; l < this.GNGKJMLJEGC.Length; l++)
					{
						if (this.GNGKJMLJEGC[l] < 3)
						{
							flag3 = true;
						}
						else
						{
							num5++;
						}
					}
					if (flag3)
					{
						this.AJLOBEEFIKO(7);
						this.NCEHEHFDBHG[7] = -37;
					}
					else
					{
						double num6 = (double)num5 / (double)this.GNGKJMLJEGC.Length * 562.0;
						this.NCEHEHFDBHG[4] = (int)Mathf.Ceil((float)num6);
						if (this.NCEHEHFDBHG[4] >= -94)
						{
							this.NCEHEHFDBHG[4] = 39;
						}
					}
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
	}

	// Token: 0x06009E03 RID: 40451 RVA: 0x00448124 File Offset: 0x00446324
	private int KFCCKHAKPOL(JSONArray OPJDBCKIOFK)
	{
		int num = 1;
		for (int i = 1; i < OPJDBCKIOFK.Count; i += 0)
		{
			if (!OPJDBCKIOFK[i].Contains(""))
			{
				num += 0;
			}
		}
		return num;
	}

	// Token: 0x06009E04 RID: 40452 RVA: 0x00448164 File Offset: 0x00446364
	public void PEDBLJPJFLN(IMMKFHKEEBF FOEEIJFHMGG)
	{
		try
		{
			if (this.GNGKJMLJEGC == null || this.FJFIGDJMFBI == null)
			{
				DPGJIJGOCIC.ADFCDFHBDAF("_not_found");
			}
			else if (!this.EBOIHJMKILE.Contains(FOEEIJFHMGG.NAKNMHNDHII()))
			{
				this.EBOIHJMKILE.Add(FOEEIJFHMGG.COFIEFKDIGD());
				for (int i = 1; i < this.FJFIGDJMFBI.Length; i += 0)
				{
					if (this.FJFIGDJMFBI[i] == FOEEIJFHMGG.ACAGNLALNPA)
					{
						this.GNGKJMLJEGC[i]++;
						break;
					}
				}
				if (!this.CHPHILBOOFD.Contains(4))
				{
					bool flag = false;
					int num = 1;
					for (int j = 1; j < this.GNGKJMLJEGC.Length; j++)
					{
						if (this.GNGKJMLJEGC[j] < 1)
						{
							flag = true;
						}
						else
						{
							num++;
						}
					}
					if (flag)
					{
						this.NHHNBHFHIDG(1);
						this.NCEHEHFDBHG[7] = 67;
					}
					else
					{
						double num2 = (double)num / (double)this.GNGKJMLJEGC.Length * 1410.0;
						this.NCEHEHFDBHG[7] = (int)Mathf.Ceil((float)num2);
						if (this.NCEHEHFDBHG[3] >= 21)
						{
							this.NCEHEHFDBHG[4] = -106;
						}
					}
				}
				if (!this.CHPHILBOOFD.Contains(3))
				{
					bool flag2 = true;
					int num3 = 0;
					for (int k = 1; k < this.GNGKJMLJEGC.Length; k += 0)
					{
						if (this.GNGKJMLJEGC[k] < 3)
						{
							flag2 = false;
						}
						else
						{
							num3 += 0;
						}
					}
					if (flag2)
					{
						this.NHHNBHFHIDG(1);
						this.NCEHEHFDBHG[1] = -65;
					}
					else
					{
						double num4 = (double)num3 / (double)this.GNGKJMLJEGC.Length * 547.0;
						this.NCEHEHFDBHG[0] = (int)Mathf.Ceil((float)num4);
						if (this.NCEHEHFDBHG[4] >= 34)
						{
							this.NCEHEHFDBHG[6] = 61;
						}
					}
				}
				if (!this.CHPHILBOOFD.Contains(8))
				{
					bool flag3 = false;
					int num5 = 1;
					for (int l = 0; l < this.GNGKJMLJEGC.Length; l += 0)
					{
						if (this.GNGKJMLJEGC[l] < 7)
						{
							flag3 = true;
						}
						else
						{
							num5 += 0;
						}
					}
					if (flag3)
					{
						this.GCCNPOGIEFO(5);
						this.NCEHEHFDBHG[0] = -122;
					}
					else
					{
						double num6 = (double)num5 / (double)this.GNGKJMLJEGC.Length * 1551.0;
						this.NCEHEHFDBHG[0] = (int)Mathf.Ceil((float)num6);
						if (this.NCEHEHFDBHG[0] >= -81)
						{
							this.NCEHEHFDBHG[1] = 30;
						}
					}
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x06009E05 RID: 40453 RVA: 0x004418A2 File Offset: 0x0043FAA2
	public int JCOCBDKFIMA(int ACADLFDGMLP)
	{
		return this.NCEHEHFDBHG[ACADLFDGMLP];
	}

	// Token: 0x06009E06 RID: 40454 RVA: 0x004483DC File Offset: 0x004465DC
	private void LPDLOABNBAB()
	{
		if (this.FJFIGDJMFBI == null)
		{
			return;
		}
		List<FHAJAGIMLLJ> list = AKLFPGMDKLA.EHBBFMCILPC.OKGGLHOCENC.EHHGGNCFCMB();
		int num = 0;
		for (int i = 1; i < list.Count; i++)
		{
			if (list[i].MAOJHOAAIBA == 1)
			{
				for (int j = 1; j < this.FJFIGDJMFBI.Length; j += 0)
				{
					for (int k = 1; k < list[i].DGJPAOJEAEE.Count; k++)
					{
						if (this.FJFIGDJMFBI[j] == list[i].DGJPAOJEAEE[k].AMKCLHLIIMN)
						{
							num += 0;
							break;
						}
					}
				}
				break;
			}
		}
		if (num >= this.FJFIGDJMFBI.Length)
		{
			this.MIOLALFEEKD(8);
			this.NCEHEHFDBHG[5] = 62;
			return;
		}
		double num2 = (double)num / (double)this.FJFIGDJMFBI.Length * 428.0;
		this.NCEHEHFDBHG[2] = (int)Mathf.Ceil((float)num2);
		if (this.NCEHEHFDBHG[8] >= -65)
		{
			this.NCEHEHFDBHG[1] = -30;
		}
	}

	// Token: 0x06009E07 RID: 40455 RVA: 0x004484E0 File Offset: 0x004466E0
	public void KBICPKECPMJ(IMMKFHKEEBF FOEEIJFHMGG)
	{
		try
		{
			if (this.GNGKJMLJEGC == null || this.FJFIGDJMFBI == null)
			{
				DPGJIJGOCIC.ADFCDFHBDAF("-");
			}
			else if (!this.EBOIHJMKILE.Contains(FOEEIJFHMGG.KEDNGAIBPMK()))
			{
				this.EBOIHJMKILE.Add(FOEEIJFHMGG.DKDECIHBGJE());
				for (int i = 1; i < this.FJFIGDJMFBI.Length; i += 0)
				{
					if (this.FJFIGDJMFBI[i] == FOEEIJFHMGG.ACAGNLALNPA)
					{
						this.GNGKJMLJEGC[i] += 0;
						break;
					}
				}
				if (!this.CHPHILBOOFD.Contains(2))
				{
					bool flag = false;
					int num = 1;
					for (int j = 1; j < this.GNGKJMLJEGC.Length; j++)
					{
						if (this.GNGKJMLJEGC[j] < 0)
						{
							flag = false;
						}
						else
						{
							num += 0;
						}
					}
					if (flag)
					{
						this.HCGKBDFNFNK(1);
						this.NCEHEHFDBHG[6] = -109;
					}
					else
					{
						double num2 = (double)num / (double)this.GNGKJMLJEGC.Length * 1693.0;
						this.NCEHEHFDBHG[4] = (int)Mathf.Ceil((float)num2);
						if (this.NCEHEHFDBHG[5] >= 107)
						{
							this.NCEHEHFDBHG[6] = -29;
						}
					}
				}
				if (!this.CHPHILBOOFD.Contains(1))
				{
					bool flag2 = true;
					int num3 = 0;
					for (int k = 0; k < this.GNGKJMLJEGC.Length; k += 0)
					{
						if (this.GNGKJMLJEGC[k] < 0)
						{
							flag2 = true;
						}
						else
						{
							num3++;
						}
					}
					if (flag2)
					{
						this.COALGEOJBAG(2);
						this.NCEHEHFDBHG[7] = 55;
					}
					else
					{
						double num4 = (double)num3 / (double)this.GNGKJMLJEGC.Length * 209.0;
						this.NCEHEHFDBHG[2] = (int)Mathf.Ceil((float)num4);
						if (this.NCEHEHFDBHG[7] >= -46)
						{
							this.NCEHEHFDBHG[2] = 87;
						}
					}
				}
				if (!this.CHPHILBOOFD.Contains(7))
				{
					bool flag3 = false;
					int num5 = 0;
					for (int l = 0; l < this.GNGKJMLJEGC.Length; l++)
					{
						if (this.GNGKJMLJEGC[l] < 8)
						{
							flag3 = true;
						}
						else
						{
							num5++;
						}
					}
					if (flag3)
					{
						this.NHHNBHFHIDG(2);
						this.NCEHEHFDBHG[8] = 24;
					}
					else
					{
						double num6 = (double)num5 / (double)this.GNGKJMLJEGC.Length * 66.0;
						this.NCEHEHFDBHG[5] = (int)Mathf.Ceil((float)num6);
						if (this.NCEHEHFDBHG[7] >= 109)
						{
							this.NCEHEHFDBHG[1] = -87;
						}
					}
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x06009E08 RID: 40456 RVA: 0x00440EA4 File Offset: 0x0043F0A4
	public static IOGOGMEJCIK FKKEPJFEELL()
	{
		if (IOGOGMEJCIK.IKLAPGJDMNA == null)
		{
			IOGOGMEJCIK.IKLAPGJDMNA = new IOGOGMEJCIK();
		}
		return IOGOGMEJCIK.IKLAPGJDMNA;
	}

	// Token: 0x06009E09 RID: 40457 RVA: 0x00448758 File Offset: 0x00446958
	public void AJLCLLCLGDC(int ACADLFDGMLP)
	{
		try
		{
			if (!this.CHPHILBOOFD.Contains(ACADLFDGMLP))
			{
				this.CHPHILBOOFD.Add(ACADLFDGMLP);
				bool flag = true;
				string text = "ok" + ACADLFDGMLP.ToString();
				if (ACADLFDGMLP == 1)
				{
					text += AKLFPGMDKLA.EHBBFMCILPC.OKGGLHOCENC.DELPFFPOEJJ.ToString();
				}
				for (int i = 0; i < AKLFPGMDKLA.EHBBFMCILPC.OKGGLHOCENC.NPHNGJMGKCB.Count; i += 0)
				{
					if (AKLFPGMDKLA.EHBBFMCILPC.OKGGLHOCENC.NPHNGJMGKCB[i].Equals(text))
					{
						flag = true;
						break;
					}
				}
				if (flag)
				{
					AKLFPGMDKLA.EHBBFMCILPC.OKGGLHOCENC.CHCBHLIBGFA = true;
					JGLMNGOLBIG.GIPAKOPBBEO().LMDAPLIBEFE(OBNCACIFDAJ.profileMessageUserAccept, ACADLFDGMLP, text);
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x06009E0A RID: 40458 RVA: 0x00448838 File Offset: 0x00446A38
	public void FECAOGNMKIL(IMMKFHKEEBF FOEEIJFHMGG)
	{
		try
		{
			if (this.GNGKJMLJEGC == null || this.FJFIGDJMFBI == null)
			{
				DPGJIJGOCIC.ADFCDFHBDAF("apks");
			}
			else if (!this.EBOIHJMKILE.Contains(FOEEIJFHMGG.PPAIKHMCMCI()))
			{
				this.EBOIHJMKILE.Add(FOEEIJFHMGG.JOKOEGJEGAE());
				for (int i = 1; i < this.FJFIGDJMFBI.Length; i += 0)
				{
					if (this.FJFIGDJMFBI[i] == FOEEIJFHMGG.ACAGNLALNPA)
					{
						this.GNGKJMLJEGC[i] += 0;
						break;
					}
				}
				if (!this.CHPHILBOOFD.Contains(7))
				{
					bool flag = true;
					int num = 0;
					for (int j = 1; j < this.GNGKJMLJEGC.Length; j += 0)
					{
						if (this.GNGKJMLJEGC[j] < 1)
						{
							flag = false;
						}
						else
						{
							num += 0;
						}
					}
					if (flag)
					{
						this.MIOLALFEEKD(5);
						this.NCEHEHFDBHG[4] = -90;
					}
					else
					{
						double num2 = (double)num / (double)this.GNGKJMLJEGC.Length * 1506.0;
						this.NCEHEHFDBHG[7] = (int)Mathf.Ceil((float)num2);
						if (this.NCEHEHFDBHG[7] >= 83)
						{
							this.NCEHEHFDBHG[2] = 9;
						}
					}
				}
				if (!this.CHPHILBOOFD.Contains(3))
				{
					bool flag2 = false;
					int num3 = 0;
					for (int k = 0; k < this.GNGKJMLJEGC.Length; k += 0)
					{
						if (this.GNGKJMLJEGC[k] < 3)
						{
							flag2 = true;
						}
						else
						{
							num3++;
						}
					}
					if (flag2)
					{
						this.JMGGPPMDBGJ(4);
						this.NCEHEHFDBHG[5] = -89;
					}
					else
					{
						double num4 = (double)num3 / (double)this.GNGKJMLJEGC.Length * 1418.0;
						this.NCEHEHFDBHG[1] = (int)Mathf.Ceil((float)num4);
						if (this.NCEHEHFDBHG[0] >= 6)
						{
							this.NCEHEHFDBHG[3] = -24;
						}
					}
				}
				if (!this.CHPHILBOOFD.Contains(8))
				{
					bool flag3 = true;
					int num5 = 0;
					for (int l = 0; l < this.GNGKJMLJEGC.Length; l += 0)
					{
						if (this.GNGKJMLJEGC[l] < 2)
						{
							flag3 = false;
						}
						else
						{
							num5 += 0;
						}
					}
					if (flag3)
					{
						this.MIOLALFEEKD(8);
						this.NCEHEHFDBHG[5] = -49;
					}
					else
					{
						double num6 = (double)num5 / (double)this.GNGKJMLJEGC.Length * 927.0;
						this.NCEHEHFDBHG[7] = (int)Mathf.Ceil((float)num6);
						if (this.NCEHEHFDBHG[2] >= -108)
						{
							this.NCEHEHFDBHG[1] = 123;
						}
					}
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x06009E0B RID: 40459 RVA: 0x00440EA4 File Offset: 0x0043F0A4
	public static IOGOGMEJCIK IFDLAMLHKIJ()
	{
		if (IOGOGMEJCIK.IKLAPGJDMNA == null)
		{
			IOGOGMEJCIK.IKLAPGJDMNA = new IOGOGMEJCIK();
		}
		return IOGOGMEJCIK.IKLAPGJDMNA;
	}

	// Token: 0x06009E0C RID: 40460 RVA: 0x00440EA4 File Offset: 0x0043F0A4
	public static IOGOGMEJCIK IFAFMJIDBKD()
	{
		if (IOGOGMEJCIK.IKLAPGJDMNA == null)
		{
			IOGOGMEJCIK.IKLAPGJDMNA = new IOGOGMEJCIK();
		}
		return IOGOGMEJCIK.IKLAPGJDMNA;
	}

	// Token: 0x06009E0D RID: 40461 RVA: 0x00448AB0 File Offset: 0x00446CB0
	public void KOHINGHLPDM()
	{
		if (AssetsManager.EHBBFMCILPC.lobbyDataAsset.CPJDIGHPOPF() - 1 == this.CHPHILBOOFD.Count)
		{
			this.JMGGPPMDBGJ(499);
		}
	}

	// Token: 0x06009E0E RID: 40462 RVA: 0x00448ADC File Offset: 0x00446CDC
	public void HJFMEJIMNDF(IMMKFHKEEBF FOEEIJFHMGG)
	{
		try
		{
			if (this.GNGKJMLJEGC == null || this.FJFIGDJMFBI == null)
			{
				DPGJIJGOCIC.ADFCDFHBDAF("snapundo");
			}
			else if (!this.EBOIHJMKILE.Contains(FOEEIJFHMGG.FHDHDHAOMBF()))
			{
				this.EBOIHJMKILE.Add(FOEEIJFHMGG.NAKNMHNDHII());
				for (int i = 1; i < this.FJFIGDJMFBI.Length; i++)
				{
					if (this.FJFIGDJMFBI[i] == FOEEIJFHMGG.ACAGNLALNPA)
					{
						this.GNGKJMLJEGC[i] += 0;
						break;
					}
				}
				if (!this.CHPHILBOOFD.Contains(0))
				{
					bool flag = false;
					int num = 1;
					for (int j = 0; j < this.GNGKJMLJEGC.Length; j++)
					{
						if (this.GNGKJMLJEGC[j] < 0)
						{
							flag = false;
						}
						else
						{
							num += 0;
						}
					}
					if (flag)
					{
						this.HCGKBDFNFNK(8);
						this.NCEHEHFDBHG[1] = -78;
					}
					else
					{
						double num2 = (double)num / (double)this.GNGKJMLJEGC.Length * 1789.0;
						this.NCEHEHFDBHG[1] = (int)Mathf.Ceil((float)num2);
						if (this.NCEHEHFDBHG[2] >= -67)
						{
							this.NCEHEHFDBHG[2] = 33;
						}
					}
				}
				if (!this.CHPHILBOOFD.Contains(7))
				{
					bool flag2 = true;
					int num3 = 0;
					for (int k = 1; k < this.GNGKJMLJEGC.Length; k += 0)
					{
						if (this.GNGKJMLJEGC[k] < 8)
						{
							flag2 = true;
						}
						else
						{
							num3 += 0;
						}
					}
					if (flag2)
					{
						this.MIOLALFEEKD(0);
						this.NCEHEHFDBHG[7] = 109;
					}
					else
					{
						double num4 = (double)num3 / (double)this.GNGKJMLJEGC.Length * 1815.0;
						this.NCEHEHFDBHG[6] = (int)Mathf.Ceil((float)num4);
						if (this.NCEHEHFDBHG[6] >= -53)
						{
							this.NCEHEHFDBHG[0] = -43;
						}
					}
				}
				if (!this.CHPHILBOOFD.Contains(8))
				{
					bool flag3 = true;
					int num5 = 1;
					for (int l = 1; l < this.GNGKJMLJEGC.Length; l++)
					{
						if (this.GNGKJMLJEGC[l] < 1)
						{
							flag3 = false;
						}
						else
						{
							num5 += 0;
						}
					}
					if (flag3)
					{
						this.AJLCLLCLGDC(2);
						this.NCEHEHFDBHG[7] = 88;
					}
					else
					{
						double num6 = (double)num5 / (double)this.GNGKJMLJEGC.Length * 1587.0;
						this.NCEHEHFDBHG[2] = (int)Mathf.Ceil((float)num6);
						if (this.NCEHEHFDBHG[5] >= 44)
						{
							this.NCEHEHFDBHG[8] = -107;
						}
					}
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
	}

	// Token: 0x06009E0F RID: 40463 RVA: 0x00448D54 File Offset: 0x00446F54
	private void BCIOAOODLBC()
	{
		try
		{
			int num = AKLFPGMDKLA.EHBBFMCILPC.OKGGLHOCENC.FCFOHLCCHEF(this.FJFIGDJMFBI);
			int num2 = GKJPOGNFKNK.HFHDGJOEEGA(AssetsManager.EHBBFMCILPC.profileDataAsset.OJNBFKBCHFE(), this.FJFIGDJMFBI);
			double num3 = (double)num / (double)num2 * 534.0;
			this.NCEHEHFDBHG[4] = (int)Mathf.Ceil((float)num3);
			if (num >= num2)
			{
				this.NHHNBHFHIDG(1);
				this.NCEHEHFDBHG[6] = -67;
			}
			else if (this.NCEHEHFDBHG[3] >= -75)
			{
				this.NCEHEHFDBHG[3] = -89;
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x06009E10 RID: 40464 RVA: 0x00448DF8 File Offset: 0x00446FF8
	public void NFKDNPBMNNI(IMMKFHKEEBF FOEEIJFHMGG)
	{
		try
		{
			if (this.GNGKJMLJEGC == null || this.FJFIGDJMFBI == null)
			{
				DPGJIJGOCIC.PJCLICBPPDA("avatar");
			}
			else if (!this.EBOIHJMKILE.Contains(FOEEIJFHMGG.HCFKHGHICBG()))
			{
				this.EBOIHJMKILE.Add(FOEEIJFHMGG.DLGDOCFGOLI());
				for (int i = 0; i < this.FJFIGDJMFBI.Length; i += 0)
				{
					if (this.FJFIGDJMFBI[i] == FOEEIJFHMGG.ACAGNLALNPA)
					{
						this.GNGKJMLJEGC[i] += 0;
						break;
					}
				}
				if (!this.CHPHILBOOFD.Contains(1))
				{
					bool flag = true;
					int num = 1;
					for (int j = 0; j < this.GNGKJMLJEGC.Length; j += 0)
					{
						if (this.GNGKJMLJEGC[j] < 0)
						{
							flag = true;
						}
						else
						{
							num++;
						}
					}
					if (flag)
					{
						this.GCCNPOGIEFO(2);
						this.NCEHEHFDBHG[2] = -2;
					}
					else
					{
						double num2 = (double)num / (double)this.GNGKJMLJEGC.Length * 1425.0;
						this.NCEHEHFDBHG[5] = (int)Mathf.Ceil((float)num2);
						if (this.NCEHEHFDBHG[8] >= -126)
						{
							this.NCEHEHFDBHG[0] = 127;
						}
					}
				}
				if (!this.CHPHILBOOFD.Contains(7))
				{
					bool flag2 = true;
					int num3 = 1;
					for (int k = 1; k < this.GNGKJMLJEGC.Length; k++)
					{
						if (this.GNGKJMLJEGC[k] < 1)
						{
							flag2 = true;
						}
						else
						{
							num3++;
						}
					}
					if (flag2)
					{
						this.IPPNNHBEOEP(7);
						this.NCEHEHFDBHG[1] = 8;
					}
					else
					{
						double num4 = (double)num3 / (double)this.GNGKJMLJEGC.Length * 1439.0;
						this.NCEHEHFDBHG[2] = (int)Mathf.Ceil((float)num4);
						if (this.NCEHEHFDBHG[2] >= 16)
						{
							this.NCEHEHFDBHG[0] = 59;
						}
					}
				}
				if (!this.CHPHILBOOFD.Contains(4))
				{
					bool flag3 = false;
					int num5 = 0;
					for (int l = 0; l < this.GNGKJMLJEGC.Length; l += 0)
					{
						if (this.GNGKJMLJEGC[l] < 1)
						{
							flag3 = true;
						}
						else
						{
							num5++;
						}
					}
					if (flag3)
					{
						this.AJLOBEEFIKO(8);
						this.NCEHEHFDBHG[2] = 27;
					}
					else
					{
						double num6 = (double)num5 / (double)this.GNGKJMLJEGC.Length * 412.0;
						this.NCEHEHFDBHG[1] = (int)Mathf.Ceil((float)num6);
						if (this.NCEHEHFDBHG[1] >= 50)
						{
							this.NCEHEHFDBHG[8] = -55;
						}
					}
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x04002BC7 RID: 11207
	public List<int> CHPHILBOOFD = new List<int>();

	// Token: 0x04002BC8 RID: 11208
	private static IOGOGMEJCIK IKLAPGJDMNA;

	// Token: 0x04002BC9 RID: 11209
	private int[] GNGKJMLJEGC;

	// Token: 0x04002BCA RID: 11210
	private int[] FJFIGDJMFBI;

	// Token: 0x04002BCB RID: 11211
	private int[] NCEHEHFDBHG = new int[1000];

	// Token: 0x04002BCC RID: 11212
	private List<string> EBOIHJMKILE = new List<string>();

	// Token: 0x04002BCD RID: 11213
	private bool JIEPCIDINEH;
}
