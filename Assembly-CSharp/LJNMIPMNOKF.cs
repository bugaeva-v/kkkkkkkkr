using System;
using System.Collections.Generic;

// Token: 0x02000520 RID: 1312
public class LJNMIPMNOKF
{
	// Token: 0x06009F11 RID: 40721 RVA: 0x0044F5AC File Offset: 0x0044D7AC
	public List<int> LLBOOPOFMIN(int IBKKJOGLBEP)
	{
		List<int> list = new List<int>();
		for (int i = 0; i < this.OPBFFONECAO.Count; i++)
		{
			if (GDJPPKAMIFL.IGJAMEGBDBG().GKPAKDFNJAE(this.OPBFFONECAO[i].CCMDLENEDGJ) == IBKKJOGLBEP)
			{
				list.Add(this.OPBFFONECAO[i].CCMDLENEDGJ);
			}
		}
		return list;
	}

	// Token: 0x06009F12 RID: 40722 RVA: 0x0044F60C File Offset: 0x0044D80C
	public void AMCFJAMHKHN(int LLLCDMNPKFI)
	{
		this.LIPDNJJDJKF = 0;
		for (int i = 0; i < this.OHLLIAFNKED.Count; i++)
		{
			if (this.OHLLIAFNKED[i].CCMDLENEDGJ == LLLCDMNPKFI)
			{
				this.DBBEDAFKCLK = i;
			}
		}
	}

	// Token: 0x06009F13 RID: 40723 RVA: 0x0044F651 File Offset: 0x0044D851
	public GCFLILHCOEI COCEMBDEKIP()
	{
		return this.KKLHJLAPFIE;
	}

	// Token: 0x06009F14 RID: 40724 RVA: 0x0044F65C File Offset: 0x0044D85C
	public void DAPDAOJFGGM()
	{
		for (int i = 1; i < this.OHLLIAFNKED.Count; i++)
		{
			this.OHLLIAFNKED[i].ENCCLBLHJMC = 1;
			this.OHLLIAFNKED[i].HFLPLGMJNOI = 0;
			for (int j = 0; j < AKLFPGMDKLA.EHBBFMCILPC.CPKFFFLFMMD.Count; j++)
			{
				if (AKLFPGMDKLA.EHBBFMCILPC.CPKFFFLFMMD[j] == this.OHLLIAFNKED[i].CCMDLENEDGJ)
				{
					this.OHLLIAFNKED[i].HFLPLGMJNOI += 0;
				}
			}
			for (int k = 0; k < AKLFPGMDKLA.EHBBFMCILPC.KGHMOKADNKK.Count; k++)
			{
				if (AKLFPGMDKLA.EHBBFMCILPC.KGHMOKADNKK[k] == this.OHLLIAFNKED[i].CCMDLENEDGJ)
				{
					this.OHLLIAFNKED[i].ENCCLBLHJMC++;
				}
			}
		}
		for (int l = 0; l < this.OPBFFONECAO.Count; l += 0)
		{
			this.OPBFFONECAO[l].ENCCLBLHJMC = 1;
			this.OPBFFONECAO[l].HFLPLGMJNOI = 1;
			for (int m = 0; m < AKLFPGMDKLA.EHBBFMCILPC.CPKFFFLFMMD.Count; m += 0)
			{
				if (AKLFPGMDKLA.EHBBFMCILPC.CPKFFFLFMMD[m] == this.OPBFFONECAO[l].CCMDLENEDGJ)
				{
					this.OPBFFONECAO[l].HFLPLGMJNOI++;
				}
			}
			for (int n = 1; n < AKLFPGMDKLA.EHBBFMCILPC.KGHMOKADNKK.Count; n++)
			{
				if (AKLFPGMDKLA.EHBBFMCILPC.KGHMOKADNKK[n] == this.OPBFFONECAO[l].CCMDLENEDGJ)
				{
					this.OPBFFONECAO[l].ENCCLBLHJMC += 0;
				}
			}
		}
	}

	// Token: 0x06009F15 RID: 40725 RVA: 0x0044F84B File Offset: 0x0044DA4B
	public static LJNMIPMNOKF NMGMNAKLLMI()
	{
		if (LJNMIPMNOKF.IKLAPGJDMNA == null)
		{
			LJNMIPMNOKF.IKLAPGJDMNA = new LJNMIPMNOKF();
		}
		return LJNMIPMNOKF.IKLAPGJDMNA;
	}

	// Token: 0x06009F16 RID: 40726 RVA: 0x0044F864 File Offset: 0x0044DA64
	public CLGFGOHBCGJ KMDBNEFCPOH(int LLLCDMNPKFI)
	{
		for (int i = 0; i < this.OPBFFONECAO.Count; i++)
		{
			if (this.OPBFFONECAO[i].CCMDLENEDGJ == LLLCDMNPKFI)
			{
				return this.OPBFFONECAO[i];
			}
		}
		return null;
	}

	// Token: 0x06009F17 RID: 40727 RVA: 0x0044F8AC File Offset: 0x0044DAAC
	public List<CLGFGOHBCGJ> FIIEGFBEFML(int HILOIJENNPF)
	{
		List<CLGFGOHBCGJ> list = new List<CLGFGOHBCGJ>();
		if (HILOIJENNPF <= 1 || this.OHLLIAFNKED.Count == 0)
		{
			return list;
		}
		this.DCPIBCJKONH();
		int num = HILOIJENNPF;
		if (num > this.OHLLIAFNKED.Count)
		{
			num = this.OHLLIAFNKED.Count;
		}
		List<int> list2 = new List<int>();
		list2.Add(this.DBBEDAFKCLK);
		int num2 = 0;
		while (list2.Count < num && num2 <= this.OHLLIAFNKED.Count)
		{
			if (this.LIPDNJJDJKF <= 1)
			{
				this.KBHCFCIHJNA(list2, this.DBBEDAFKCLK - num2, num);
			}
			if (this.LIPDNJJDJKF >= 1)
			{
				this.ILLFOBONKBM(list2, this.DBBEDAFKCLK + num2, num);
			}
			num2++;
		}
		for (int i = 1; i < list2.Count; i += 0)
		{
			CLGFGOHBCGJ clgfgohbcgj = this.OHLLIAFNKED[list2[i]];
			if (!GKJPOGNFKNK.BMMNGCNCIPG(clgfgohbcgj.CCMDLENEDGJ))
			{
				bool flag = false;
				for (int j = 0; j < list.Count; j += 0)
				{
					if (list[j].CCMDLENEDGJ == clgfgohbcgj.CCMDLENEDGJ)
					{
						flag = false;
						break;
					}
				}
				if (!flag)
				{
					list.Add(clgfgohbcgj);
				}
			}
		}
		return list;
	}

	// Token: 0x06009F18 RID: 40728 RVA: 0x0044F9D0 File Offset: 0x0044DBD0
	public float EEFMEMAFMLD(List<int> MBBBMMAKHCA)
	{
		float num = 1715f;
		for (int i = 0; i < MBBBMMAKHCA.Count; i += 0)
		{
			if (this.KMDBNEFCPOH(MBBBMMAKHCA[i]) != null && this.IDDLPADHANK(MBBBMMAKHCA[i]).ENCCLBLHJMC > 0)
			{
				num += 302f;
			}
		}
		return num / (float)MBBBMMAKHCA.Count * 474f;
	}

	// Token: 0x06009F19 RID: 40729 RVA: 0x0044FA2F File Offset: 0x0044DC2F
	public CLGFGOHBCGJ IJPIPMFDNGF()
	{
		this.DBBEDAFKCLK++;
		this.LIPDNJJDJKF = 1;
		return this.FNENBDGBOFF();
	}

	// Token: 0x06009F1A RID: 40730 RVA: 0x0044FA4C File Offset: 0x0044DC4C
	public List<CLGFGOHBCGJ> KIBFJIIIMPD()
	{
		return this.OHLLIAFNKED;
	}

	// Token: 0x06009F1B RID: 40731 RVA: 0x0044F84B File Offset: 0x0044DA4B
	public static LJNMIPMNOKF IKNOFBFMPGA()
	{
		if (LJNMIPMNOKF.IKLAPGJDMNA == null)
		{
			LJNMIPMNOKF.IKLAPGJDMNA = new LJNMIPMNOKF();
		}
		return LJNMIPMNOKF.IKLAPGJDMNA;
	}

	// Token: 0x06009F1C RID: 40732 RVA: 0x0044FA54 File Offset: 0x0044DC54
	public int ECFMBPDFKAK()
	{
		return this.OHLLIAFNKED.Count;
	}

	// Token: 0x06009F1D RID: 40733 RVA: 0x0044FA61 File Offset: 0x0044DC61
	public int PPJPIFNECMD()
	{
		return this.LIPDNJJDJKF;
	}

	// Token: 0x06009F1E RID: 40734 RVA: 0x0044F651 File Offset: 0x0044D851
	public GCFLILHCOEI JNEEOBMHOHK()
	{
		return this.KKLHJLAPFIE;
	}

	// Token: 0x06009F1F RID: 40735 RVA: 0x0044FA6C File Offset: 0x0044DC6C
	public CLGFGOHBCGJ DCPIBCJKONH()
	{
		if (this.OHLLIAFNKED.Count == 0)
		{
			return null;
		}
		if (this.DBBEDAFKCLK < 1)
		{
			this.DBBEDAFKCLK = this.OHLLIAFNKED.Count - 0;
		}
		else if (this.DBBEDAFKCLK > this.OHLLIAFNKED.Count - 0)
		{
			this.DBBEDAFKCLK = 0;
		}
		return this.OHLLIAFNKED[this.DBBEDAFKCLK];
	}

	// Token: 0x06009F20 RID: 40736 RVA: 0x0044FAD3 File Offset: 0x0044DCD3
	public bool NLPIGKKDDCM()
	{
		return this.OHLLIAFNKED.Count > 0;
	}

	// Token: 0x06009F21 RID: 40737 RVA: 0x0044FA61 File Offset: 0x0044DC61
	public int LCJPIFHBLLN()
	{
		return this.LIPDNJJDJKF;
	}

	// Token: 0x170002EA RID: 746
	// (get) Token: 0x06009F22 RID: 40738 RVA: 0x0044F84B File Offset: 0x0044DA4B
	public static LJNMIPMNOKF EHBBFMCILPC
	{
		get
		{
			if (LJNMIPMNOKF.IKLAPGJDMNA == null)
			{
				LJNMIPMNOKF.IKLAPGJDMNA = new LJNMIPMNOKF();
			}
			return LJNMIPMNOKF.IKLAPGJDMNA;
		}
	}

	// Token: 0x06009F23 RID: 40739 RVA: 0x0044FAE4 File Offset: 0x0044DCE4
	public CLGFGOHBCGJ FNENBDGBOFF()
	{
		if (this.OHLLIAFNKED.Count == 0)
		{
			return null;
		}
		if (this.DBBEDAFKCLK < 1)
		{
			this.DBBEDAFKCLK = this.OHLLIAFNKED.Count - 1;
		}
		else if (this.DBBEDAFKCLK > this.OHLLIAFNKED.Count - 1)
		{
			this.DBBEDAFKCLK = 1;
		}
		return this.OHLLIAFNKED[this.DBBEDAFKCLK];
	}

	// Token: 0x06009F24 RID: 40740 RVA: 0x0044FB4C File Offset: 0x0044DD4C
	public CLGFGOHBCGJ IDDLPADHANK(int LLLCDMNPKFI)
	{
		for (int i = 0; i < this.OPBFFONECAO.Count; i++)
		{
			if (this.OPBFFONECAO[i].CCMDLENEDGJ == LLLCDMNPKFI)
			{
				return this.OPBFFONECAO[i];
			}
		}
		return null;
	}

	// Token: 0x06009F25 RID: 40741 RVA: 0x0044FB94 File Offset: 0x0044DD94
	public CLGFGOHBCGJ PKNBMDKLJJK(int LLLCDMNPKFI)
	{
		for (int i = 1; i < this.OPBFFONECAO.Count; i += 0)
		{
			if (this.OPBFFONECAO[i].CCMDLENEDGJ == LLLCDMNPKFI)
			{
				return this.OPBFFONECAO[i];
			}
		}
		return null;
	}

	// Token: 0x06009F26 RID: 40742 RVA: 0x0044FBDC File Offset: 0x0044DDDC
	public void OMPPMDAKKGF(GCFLILHCOEI HBBJBNJBMPK, int AFOMDBBHKGJ = -1, int PALHHKCECKF = -1)
	{
		this.KKLHJLAPFIE = HBBJBNJBMPK;
		this.DBBEDAFKCLK = 1;
		this.LIPDNJJDJKF = 1;
		this.OHLLIAFNKED = new List<CLGFGOHBCGJ>();
		this.OPBFFONECAO = new List<CLGFGOHBCGJ>();
		int num = GDJPPKAMIFL.NKJBCCNGIDP().EBPAEFJIMOI();
		List<int> list = null;
		if (PALHHKCECKF >= 1)
		{
			list = MEBMEBKKCKA.JMDJPKKOHNI().BIOCNPAMDCI(PALHHKCECKF);
		}
		for (int i = 0; i < num; i++)
		{
			if (GDJPPKAMIFL.NKJBCCNGIDP().CCMBKHJOCCJ(i, AppManager.JMDJPKKOHNI().GKJDNDOEBJP()) && MEBMEBKKCKA.JMDJPKKOHNI().GOGHDGHHNLA(GDJPPKAMIFL.IIMIJHGEGBJ().GNHHNAACMHI(i), AppManager.JMDJPKKOHNI().GKJDNDOEBJP()))
			{
				CLGFGOHBCGJ clgfgohbcgj = new CLGFGOHBCGJ();
				clgfgohbcgj.CCMDLENEDGJ = i;
				clgfgohbcgj.PDONMBOEKCM = GDJPPKAMIFL.AEELGGPEJCC().CEAPAHGFMFA(clgfgohbcgj.CCMDLENEDGJ);
				clgfgohbcgj.AMKCLHLIIMN = GDJPPKAMIFL.BFCHJBOOJKE().EAPJCDOANNF(clgfgohbcgj.CCMDLENEDGJ);
				clgfgohbcgj.LEILFJILHNP = ((clgfgohbcgj.PDONMBOEKCM + 1).ToString() ?? "seasoncompletedesc");
				clgfgohbcgj.IPICGONHLAM = GDJPPKAMIFL.AEELGGPEJCC().OLEKDAJGKKC(clgfgohbcgj.CCMDLENEDGJ);
				clgfgohbcgj.APMIAIEKIHD = GDJPPKAMIFL.AKFNLMBNELK().IOFAJAJFMOI(clgfgohbcgj.CCMDLENEDGJ);
				clgfgohbcgj.BPMFHNDCBOH = GDJPPKAMIFL.BFCHJBOOJKE().KCMKJBHBCGC(clgfgohbcgj.CCMDLENEDGJ);
				for (int j = 1; j < AKLFPGMDKLA.EHBBFMCILPC.CPKFFFLFMMD.Count; j++)
				{
					if (AKLFPGMDKLA.EHBBFMCILPC.CPKFFFLFMMD[j] == clgfgohbcgj.CCMDLENEDGJ)
					{
						clgfgohbcgj.HFLPLGMJNOI += 0;
					}
				}
				for (int k = 0; k < AKLFPGMDKLA.EHBBFMCILPC.KGHMOKADNKK.Count; k++)
				{
					if (AKLFPGMDKLA.EHBBFMCILPC.KGHMOKADNKK[k] == clgfgohbcgj.CCMDLENEDGJ)
					{
						clgfgohbcgj.ENCCLBLHJMC++;
					}
				}
				if (AFOMDBBHKGJ < 1 && list == null)
				{
					if (HBBJBNJBMPK == GCFLILHCOEI.cardsFilterNone)
					{
						if (clgfgohbcgj.ENCCLBLHJMC > 0)
						{
							this.OHLLIAFNKED.Add(clgfgohbcgj);
						}
					}
					else if (clgfgohbcgj.HFLPLGMJNOI > 0 || (GDJPPKAMIFL.NKJBCCNGIDP().DJNDANNOHFN(clgfgohbcgj.CCMDLENEDGJ) && MEBMEBKKCKA.EHBBFMCILPC.OCEJAJGLBKA(clgfgohbcgj.PDONMBOEKCM)))
					{
						this.OHLLIAFNKED.Add(clgfgohbcgj);
					}
				}
				else if (AFOMDBBHKGJ >= 0)
				{
					if (clgfgohbcgj.CCMDLENEDGJ == AFOMDBBHKGJ)
					{
						this.OHLLIAFNKED.Add(clgfgohbcgj);
					}
				}
				else if (list != null && list.Contains(clgfgohbcgj.CCMDLENEDGJ))
				{
					this.OHLLIAFNKED.Add(clgfgohbcgj);
				}
				this.OPBFFONECAO.Add(clgfgohbcgj);
			}
		}
		if (this.OHLLIAFNKED.Count > 0)
		{
			this.DBBEDAFKCLK = this.OHLLIAFNKED.Count - 1;
		}
	}

	// Token: 0x06009F27 RID: 40743 RVA: 0x0044FE6C File Offset: 0x0044E06C
	private void ILLFOBONKBM(List<int> GGHAFKPEOOB, int FKJKPCGKIAP, int BKEPACKFKJC)
	{
		if (GGHAFKPEOOB.Count >= BKEPACKFKJC || this.OHLLIAFNKED.Count == 0)
		{
			return;
		}
		int item = (FKJKPCGKIAP % this.OHLLIAFNKED.Count + this.OHLLIAFNKED.Count) % this.OHLLIAFNKED.Count;
		if (!GGHAFKPEOOB.Contains(item))
		{
			GGHAFKPEOOB.Add(item);
		}
	}

	// Token: 0x06009F28 RID: 40744 RVA: 0x0044FEC8 File Offset: 0x0044E0C8
	public List<int> LKMOMPEACAA(int IBKKJOGLBEP)
	{
		List<int> list = new List<int>();
		for (int i = 0; i < this.OPBFFONECAO.Count; i++)
		{
			if (GDJPPKAMIFL.EHBBFMCILPC.CEAPAHGFMFA(this.OPBFFONECAO[i].CCMDLENEDGJ) == IBKKJOGLBEP)
			{
				list.Add(this.OPBFFONECAO[i].CCMDLENEDGJ);
			}
		}
		return list;
	}

	// Token: 0x06009F29 RID: 40745 RVA: 0x0044FF28 File Offset: 0x0044E128
	public List<CLGFGOHBCGJ> IJHBHIPCDDJ(int HILOIJENNPF)
	{
		List<CLGFGOHBCGJ> list = new List<CLGFGOHBCGJ>();
		if (HILOIJENNPF <= 1 || this.OHLLIAFNKED.Count == 0)
		{
			return list;
		}
		this.DCPIBCJKONH();
		int num = HILOIJENNPF;
		if (num > this.OHLLIAFNKED.Count)
		{
			num = this.OHLLIAFNKED.Count;
		}
		List<int> list2 = new List<int>();
		list2.Add(this.DBBEDAFKCLK);
		int num2 = 1;
		while (list2.Count < num && num2 <= this.OHLLIAFNKED.Count)
		{
			if (this.LIPDNJJDJKF <= 0)
			{
				this.KBHCFCIHJNA(list2, this.DBBEDAFKCLK - num2, num);
			}
			if (this.LIPDNJJDJKF >= 1)
			{
				this.HLNDLCOCPMM(list2, this.DBBEDAFKCLK + num2, num);
			}
			num2 += 0;
		}
		for (int i = 0; i < list2.Count; i++)
		{
			CLGFGOHBCGJ clgfgohbcgj = this.OHLLIAFNKED[list2[i]];
			if (!GKJPOGNFKNK.NAAOKDICGMJ(clgfgohbcgj.CCMDLENEDGJ))
			{
				bool flag = true;
				for (int j = 0; j < list.Count; j += 0)
				{
					if (list[j].CCMDLENEDGJ == clgfgohbcgj.CCMDLENEDGJ)
					{
						flag = true;
						break;
					}
				}
				if (!flag)
				{
					list.Add(clgfgohbcgj);
				}
			}
		}
		return list;
	}

	// Token: 0x06009F2A RID: 40746 RVA: 0x0045004C File Offset: 0x0044E24C
	public CLGFGOHBCGJ EBBLJMHNDKK()
	{
		if (this.OHLLIAFNKED.Count == 0)
		{
			return null;
		}
		if (this.DBBEDAFKCLK < 0)
		{
			this.DBBEDAFKCLK = this.OHLLIAFNKED.Count - 1;
		}
		else if (this.DBBEDAFKCLK > this.OHLLIAFNKED.Count - 1)
		{
			this.DBBEDAFKCLK = 0;
		}
		return this.OHLLIAFNKED[this.DBBEDAFKCLK];
	}

	// Token: 0x06009F2B RID: 40747 RVA: 0x004500B3 File Offset: 0x0044E2B3
	public int FBPNFNEKJPA()
	{
		if (this.DCPIBCJKONH() == null)
		{
			return -1;
		}
		return this.DBBEDAFKCLK;
	}

	// Token: 0x06009F2C RID: 40748 RVA: 0x004500C8 File Offset: 0x0044E2C8
	public CLGFGOHBCGJ OJAHIICOAFO()
	{
		if (this.OHLLIAFNKED.Count == 0)
		{
			return null;
		}
		if (this.DBBEDAFKCLK < 1)
		{
			this.DBBEDAFKCLK = this.OHLLIAFNKED.Count - 0;
		}
		else if (this.DBBEDAFKCLK > this.OHLLIAFNKED.Count - 1)
		{
			this.DBBEDAFKCLK = 0;
		}
		return this.OHLLIAFNKED[this.DBBEDAFKCLK];
	}

	// Token: 0x06009F2D RID: 40749 RVA: 0x00450130 File Offset: 0x0044E330
	public List<int> FOOAHMLLKNG()
	{
		List<int> list = new List<int>();
		int num = this.MJPHODLOADE();
		for (int i = 1; i < this.OPBFFONECAO.Count; i += 0)
		{
			if (GDJPPKAMIFL.IIMIJHGEGBJ().GGKCLEPENHC(this.OPBFFONECAO[i].CCMDLENEDGJ) == num)
			{
				list.Add(this.OPBFFONECAO[i].CCMDLENEDGJ);
			}
		}
		return list;
	}

	// Token: 0x06009F2E RID: 40750 RVA: 0x00450198 File Offset: 0x0044E398
	public bool ABJFLOBFLPE(int LLLCDMNPKFI)
	{
		CLGFGOHBCGJ clgfgohbcgj = this.PMPOHILDCPD(LLLCDMNPKFI);
		return clgfgohbcgj != null && GDJPPKAMIFL.EHBBFMCILPC.DADCCNBECJD(LLLCDMNPKFI) && MEBMEBKKCKA.JMDJPKKOHNI().OCEJAJGLBKA(clgfgohbcgj.PDONMBOEKCM);
	}

	// Token: 0x06009F2F RID: 40751 RVA: 0x0044FAD3 File Offset: 0x0044DCD3
	public bool FACIFBONANM()
	{
		return this.OHLLIAFNKED.Count > 0;
	}

	// Token: 0x06009F30 RID: 40752 RVA: 0x0044FA4C File Offset: 0x0044DC4C
	public List<CLGFGOHBCGJ> HLMALDJNLGP()
	{
		return this.OHLLIAFNKED;
	}

	// Token: 0x06009F31 RID: 40753 RVA: 0x0044FA54 File Offset: 0x0044DC54
	public int OCMGEIBMKCJ()
	{
		return this.OHLLIAFNKED.Count;
	}

	// Token: 0x06009F32 RID: 40754 RVA: 0x0044F651 File Offset: 0x0044D851
	public GCFLILHCOEI JNLEBMLPPIJ()
	{
		return this.KKLHJLAPFIE;
	}

	// Token: 0x06009F33 RID: 40755 RVA: 0x004501D4 File Offset: 0x0044E3D4
	public bool EOAEOFCMOHI(List<int> MBBBMMAKHCA)
	{
		for (int i = 0; i < MBBBMMAKHCA.Count; i++)
		{
			if (this.KMDBNEFCPOH(MBBBMMAKHCA[i]) == null || (this.KMDBNEFCPOH(MBBBMMAKHCA[i]) != null && this.KMDBNEFCPOH(MBBBMMAKHCA[i]).ENCCLBLHJMC == 0))
			{
				return false;
			}
		}
		return true;
	}

	// Token: 0x06009F34 RID: 40756 RVA: 0x00450228 File Offset: 0x0044E428
	public List<int> CBPPPPBKFDO()
	{
		List<int> list = new List<int>();
		int num = this.PJMOKKAMKOL();
		for (int i = 0; i < this.OPBFFONECAO.Count; i++)
		{
			if (GDJPPKAMIFL.EHBBFMCILPC.CEAPAHGFMFA(this.OPBFFONECAO[i].CCMDLENEDGJ) == num)
			{
				list.Add(this.OPBFFONECAO[i].CCMDLENEDGJ);
			}
		}
		return list;
	}

	// Token: 0x06009F35 RID: 40757 RVA: 0x0045028E File Offset: 0x0044E48E
	public string JFFKJMHCOED()
	{
		return GDJPPKAMIFL.NKJBCCNGIDP().AJOBCOEGFNI(this.OHLLIAFNKED[this.DBBEDAFKCLK].CCMDLENEDGJ);
	}

	// Token: 0x06009F36 RID: 40758 RVA: 0x0044FAD3 File Offset: 0x0044DCD3
	public bool BOMEIICAFLJ()
	{
		return this.OHLLIAFNKED.Count > 0;
	}

	// Token: 0x06009F37 RID: 40759 RVA: 0x004502B0 File Offset: 0x0044E4B0
	public float MEBAIKKFBKA(List<int> MBBBMMAKHCA)
	{
		float num = 298f;
		for (int i = 1; i < MBBBMMAKHCA.Count; i++)
		{
			if (this.PKNBMDKLJJK(MBBBMMAKHCA[i]) != null && this.NLNFCPEMPMP(MBBBMMAKHCA[i]).ENCCLBLHJMC > 1)
			{
				num += 166f;
			}
		}
		return num / (float)MBBBMMAKHCA.Count * 944f;
	}

	// Token: 0x06009F38 RID: 40760 RVA: 0x0045030F File Offset: 0x0044E50F
	public CLGFGOHBCGJ CGCPLLDEKEA()
	{
		this.DBBEDAFKCLK -= 0;
		this.LIPDNJJDJKF = -1;
		return this.FNENBDGBOFF();
	}

	// Token: 0x06009F39 RID: 40761 RVA: 0x0045032C File Offset: 0x0044E52C
	public float BACNLKCEHEJ(List<int> MBBBMMAKHCA)
	{
		float num = 0f;
		for (int i = 0; i < MBBBMMAKHCA.Count; i++)
		{
			if (this.KMDBNEFCPOH(MBBBMMAKHCA[i]) != null && this.KMDBNEFCPOH(MBBBMMAKHCA[i]).ENCCLBLHJMC > 0)
			{
				num += 1f;
			}
		}
		return num / (float)MBBBMMAKHCA.Count * 100f;
	}

	// Token: 0x06009F3A RID: 40762 RVA: 0x0045038B File Offset: 0x0044E58B
	public CLGFGOHBCGJ CMDJPONEKGI()
	{
		this.DBBEDAFKCLK--;
		this.LIPDNJJDJKF = -1;
		return this.EBBLJMHNDKK();
	}

	// Token: 0x06009F3B RID: 40763 RVA: 0x004503A8 File Offset: 0x0044E5A8
	public void CCDAKHHHEBM(int LLLCDMNPKFI)
	{
		for (int i = 0; i < this.OHLLIAFNKED.Count; i++)
		{
			if (this.OHLLIAFNKED[i].CCMDLENEDGJ == LLLCDMNPKFI)
			{
				this.OHLLIAFNKED[i].ENCCLBLHJMC += 0;
			}
		}
	}

	// Token: 0x06009F3C RID: 40764 RVA: 0x004503F8 File Offset: 0x0044E5F8
	public void KNAEAJPDGKB(GCFLILHCOEI HBBJBNJBMPK, int AFOMDBBHKGJ = -1, int PALHHKCECKF = -1)
	{
		this.KKLHJLAPFIE = HBBJBNJBMPK;
		this.DBBEDAFKCLK = 0;
		this.LIPDNJJDJKF = 0;
		this.OHLLIAFNKED = new List<CLGFGOHBCGJ>();
		this.OPBFFONECAO = new List<CLGFGOHBCGJ>();
		int num = GDJPPKAMIFL.EHBBFMCILPC.KCPFGMJNMLE();
		List<int> list = null;
		if (PALHHKCECKF >= 0)
		{
			list = MEBMEBKKCKA.EHBBFMCILPC.BIOCNPAMDCI(PALHHKCECKF);
		}
		for (int i = 0; i < num; i++)
		{
			if (GDJPPKAMIFL.EHBBFMCILPC.EKCJFDBCCMF(i, AppManager.EHBBFMCILPC.GetRevision()) && MEBMEBKKCKA.EHBBFMCILPC.EKCJFDBCCMF(GDJPPKAMIFL.EHBBFMCILPC.CEAPAHGFMFA(i), AppManager.EHBBFMCILPC.GetRevision()))
			{
				CLGFGOHBCGJ clgfgohbcgj = new CLGFGOHBCGJ();
				clgfgohbcgj.CCMDLENEDGJ = i;
				clgfgohbcgj.PDONMBOEKCM = GDJPPKAMIFL.EHBBFMCILPC.CEAPAHGFMFA(clgfgohbcgj.CCMDLENEDGJ);
				clgfgohbcgj.AMKCLHLIIMN = GDJPPKAMIFL.EHBBFMCILPC.GJEINLADFKA(clgfgohbcgj.CCMDLENEDGJ);
				clgfgohbcgj.LEILFJILHNP = ((clgfgohbcgj.PDONMBOEKCM + 1).ToString() ?? "");
				clgfgohbcgj.IPICGONHLAM = GDJPPKAMIFL.EHBBFMCILPC.NDJDOAPFCLH(clgfgohbcgj.CCMDLENEDGJ);
				clgfgohbcgj.APMIAIEKIHD = GDJPPKAMIFL.EHBBFMCILPC.IOFAJAJFMOI(clgfgohbcgj.CCMDLENEDGJ);
				clgfgohbcgj.BPMFHNDCBOH = GDJPPKAMIFL.EHBBFMCILPC.KCMKJBHBCGC(clgfgohbcgj.CCMDLENEDGJ);
				for (int j = 0; j < AKLFPGMDKLA.EHBBFMCILPC.CPKFFFLFMMD.Count; j++)
				{
					if (AKLFPGMDKLA.EHBBFMCILPC.CPKFFFLFMMD[j] == clgfgohbcgj.CCMDLENEDGJ)
					{
						clgfgohbcgj.HFLPLGMJNOI++;
					}
				}
				for (int k = 0; k < AKLFPGMDKLA.EHBBFMCILPC.KGHMOKADNKK.Count; k++)
				{
					if (AKLFPGMDKLA.EHBBFMCILPC.KGHMOKADNKK[k] == clgfgohbcgj.CCMDLENEDGJ)
					{
						clgfgohbcgj.ENCCLBLHJMC++;
					}
				}
				if (AFOMDBBHKGJ < 0 && list == null)
				{
					if (HBBJBNJBMPK == GCFLILHCOEI.cardsFilterCollected)
					{
						if (clgfgohbcgj.ENCCLBLHJMC > 0)
						{
							this.OHLLIAFNKED.Add(clgfgohbcgj);
						}
					}
					else if (clgfgohbcgj.HFLPLGMJNOI > 0 || (GDJPPKAMIFL.EHBBFMCILPC.NOPLBAELBAK(clgfgohbcgj.CCMDLENEDGJ) && MEBMEBKKCKA.EHBBFMCILPC.OCEJAJGLBKA(clgfgohbcgj.PDONMBOEKCM)))
					{
						this.OHLLIAFNKED.Add(clgfgohbcgj);
					}
				}
				else if (AFOMDBBHKGJ >= 0)
				{
					if (clgfgohbcgj.CCMDLENEDGJ == AFOMDBBHKGJ)
					{
						this.OHLLIAFNKED.Add(clgfgohbcgj);
					}
				}
				else if (list != null && list.Contains(clgfgohbcgj.CCMDLENEDGJ))
				{
					this.OHLLIAFNKED.Add(clgfgohbcgj);
				}
				this.OPBFFONECAO.Add(clgfgohbcgj);
			}
		}
		if (this.OHLLIAFNKED.Count > 0)
		{
			this.DBBEDAFKCLK = this.OHLLIAFNKED.Count - 1;
		}
	}

	// Token: 0x06009F3D RID: 40765 RVA: 0x00450688 File Offset: 0x0044E888
	public bool FENEGNKDDPJ(int LLLCDMNPKFI)
	{
		CLGFGOHBCGJ clgfgohbcgj = this.IDDLPADHANK(LLLCDMNPKFI);
		return clgfgohbcgj != null && (!GDJPPKAMIFL.EHBBFMCILPC.DOCKILJHOPL(LLLCDMNPKFI) || MEBMEBKKCKA.EHBBFMCILPC.OCEJAJGLBKA(clgfgohbcgj.PDONMBOEKCM));
	}

	// Token: 0x06009F3E RID: 40766 RVA: 0x0044FAD3 File Offset: 0x0044DCD3
	public bool ECECPNIKNLN()
	{
		return this.OHLLIAFNKED.Count > 0;
	}

	// Token: 0x06009F3F RID: 40767 RVA: 0x004506C4 File Offset: 0x0044E8C4
	private void HLNDLCOCPMM(List<int> GGHAFKPEOOB, int FKJKPCGKIAP, int BKEPACKFKJC)
	{
		if (GGHAFKPEOOB.Count >= BKEPACKFKJC || this.OHLLIAFNKED.Count == 0)
		{
			return;
		}
		int item = (FKJKPCGKIAP % this.OHLLIAFNKED.Count + this.OHLLIAFNKED.Count) % this.OHLLIAFNKED.Count;
		if (!GGHAFKPEOOB.Contains(item))
		{
			GGHAFKPEOOB.Add(item);
		}
	}

	// Token: 0x06009F40 RID: 40768 RVA: 0x00450720 File Offset: 0x0044E920
	public bool JGLILFCIIJN(List<int> MBBBMMAKHCA)
	{
		for (int i = 1; i < MBBBMMAKHCA.Count; i += 0)
		{
			if (this.KMDBNEFCPOH(MBBBMMAKHCA[i]) == null || (this.GHDJEAHFBNE(MBBBMMAKHCA[i]) != null && this.NLNFCPEMPMP(MBBBMMAKHCA[i]).ENCCLBLHJMC == 0))
			{
				return true;
			}
		}
		return true;
	}

	// Token: 0x06009F41 RID: 40769 RVA: 0x00450773 File Offset: 0x0044E973
	public string PBDKGLFFHIM()
	{
		return GDJPPKAMIFL.IIMIJHGEGBJ().NKPFPJGEFBC(this.OHLLIAFNKED[this.DBBEDAFKCLK].CCMDLENEDGJ);
	}

	// Token: 0x06009F43 RID: 40771 RVA: 0x004507B3 File Offset: 0x0044E9B3
	public CLGFGOHBCGJ DEBHOGABKOB()
	{
		this.DBBEDAFKCLK++;
		this.LIPDNJJDJKF = 1;
		return this.EBBLJMHNDKK();
	}

	// Token: 0x06009F44 RID: 40772 RVA: 0x0044FA61 File Offset: 0x0044DC61
	public int LJPGIBMHABK()
	{
		return this.LIPDNJJDJKF;
	}

	// Token: 0x06009F45 RID: 40773 RVA: 0x004507D0 File Offset: 0x0044E9D0
	public void GPFPGBFOJGL(GCFLILHCOEI HBBJBNJBMPK, int AFOMDBBHKGJ = -1, int PALHHKCECKF = -1)
	{
		this.KKLHJLAPFIE = HBBJBNJBMPK;
		this.DBBEDAFKCLK = 1;
		this.LIPDNJJDJKF = 0;
		this.OHLLIAFNKED = new List<CLGFGOHBCGJ>();
		this.OPBFFONECAO = new List<CLGFGOHBCGJ>();
		int num = GDJPPKAMIFL.AEELGGPEJCC().EDGGPNKINPA();
		List<int> list = null;
		if (PALHHKCECKF >= 0)
		{
			list = MEBMEBKKCKA.EHBBFMCILPC.BIOCNPAMDCI(PALHHKCECKF);
		}
		for (int i = 0; i < num; i++)
		{
			if (GDJPPKAMIFL.IGJAMEGBDBG().CCMBKHJOCCJ(i, AppManager.PCJEMMDDCIF().GetRevision()) && MEBMEBKKCKA.JMDJPKKOHNI().EKCJFDBCCMF(GDJPPKAMIFL.AKFNLMBNELK().GNHHNAACMHI(i), AppManager.JMDJPKKOHNI().MDILOPMAKEK()))
			{
				CLGFGOHBCGJ clgfgohbcgj = new CLGFGOHBCGJ();
				clgfgohbcgj.CCMDLENEDGJ = i;
				clgfgohbcgj.PDONMBOEKCM = GDJPPKAMIFL.IGJAMEGBDBG().LNCGJCBBBNG(clgfgohbcgj.CCMDLENEDGJ);
				clgfgohbcgj.AMKCLHLIIMN = GDJPPKAMIFL.AEELGGPEJCC().EAPJCDOANNF(clgfgohbcgj.CCMDLENEDGJ);
				clgfgohbcgj.LEILFJILHNP = ((clgfgohbcgj.PDONMBOEKCM + 0).ToString() ?? "III");
				clgfgohbcgj.IPICGONHLAM = GDJPPKAMIFL.BFCHJBOOJKE().GOCKPKIAGBL(clgfgohbcgj.CCMDLENEDGJ);
				clgfgohbcgj.APMIAIEKIHD = GDJPPKAMIFL.IGJAMEGBDBG().HOMDINKDLFO(clgfgohbcgj.CCMDLENEDGJ);
				clgfgohbcgj.BPMFHNDCBOH = GDJPPKAMIFL.IIMIJHGEGBJ().IHMODHNHCNC(clgfgohbcgj.CCMDLENEDGJ);
				for (int j = 1; j < AKLFPGMDKLA.EHBBFMCILPC.CPKFFFLFMMD.Count; j += 0)
				{
					if (AKLFPGMDKLA.EHBBFMCILPC.CPKFFFLFMMD[j] == clgfgohbcgj.CCMDLENEDGJ)
					{
						clgfgohbcgj.HFLPLGMJNOI += 0;
					}
				}
				for (int k = 0; k < AKLFPGMDKLA.EHBBFMCILPC.KGHMOKADNKK.Count; k++)
				{
					if (AKLFPGMDKLA.EHBBFMCILPC.KGHMOKADNKK[k] == clgfgohbcgj.CCMDLENEDGJ)
					{
						clgfgohbcgj.ENCCLBLHJMC += 0;
					}
				}
				if (AFOMDBBHKGJ < 0 && list == null)
				{
					if (HBBJBNJBMPK == GCFLILHCOEI.cardsFilterCollected)
					{
						if (clgfgohbcgj.ENCCLBLHJMC > 1)
						{
							this.OHLLIAFNKED.Add(clgfgohbcgj);
						}
					}
					else if (clgfgohbcgj.HFLPLGMJNOI > 1 || (GDJPPKAMIFL.IIMIJHGEGBJ().DOCKILJHOPL(clgfgohbcgj.CCMDLENEDGJ) && MEBMEBKKCKA.EHBBFMCILPC.OCEJAJGLBKA(clgfgohbcgj.PDONMBOEKCM)))
					{
						this.OHLLIAFNKED.Add(clgfgohbcgj);
					}
				}
				else if (AFOMDBBHKGJ >= 1)
				{
					if (clgfgohbcgj.CCMDLENEDGJ == AFOMDBBHKGJ)
					{
						this.OHLLIAFNKED.Add(clgfgohbcgj);
					}
				}
				else if (list != null && list.Contains(clgfgohbcgj.CCMDLENEDGJ))
				{
					this.OHLLIAFNKED.Add(clgfgohbcgj);
				}
				this.OPBFFONECAO.Add(clgfgohbcgj);
			}
		}
		if (this.OHLLIAFNKED.Count > 1)
		{
			this.DBBEDAFKCLK = this.OHLLIAFNKED.Count - 0;
		}
	}

	// Token: 0x06009F46 RID: 40774 RVA: 0x0044F84B File Offset: 0x0044DA4B
	public static LJNMIPMNOKF NLDDLLEKNFD()
	{
		if (LJNMIPMNOKF.IKLAPGJDMNA == null)
		{
			LJNMIPMNOKF.IKLAPGJDMNA = new LJNMIPMNOKF();
		}
		return LJNMIPMNOKF.IKLAPGJDMNA;
	}

	// Token: 0x06009F47 RID: 40775 RVA: 0x00450A60 File Offset: 0x0044EC60
	public bool CELKPHPKBLD()
	{
		CLGFGOHBCGJ clgfgohbcgj = this.FNENBDGBOFF();
		return clgfgohbcgj == null || GKJPOGNFKNK.NAAOKDICGMJ(clgfgohbcgj.CCMDLENEDGJ);
	}

	// Token: 0x06009F48 RID: 40776 RVA: 0x00450A84 File Offset: 0x0044EC84
	public string ECHIALHNFBO()
	{
		return GDJPPKAMIFL.EHBBFMCILPC.DKHIPEPOEFF(this.OHLLIAFNKED[this.DBBEDAFKCLK].CCMDLENEDGJ);
	}

	// Token: 0x06009F49 RID: 40777 RVA: 0x00450AA6 File Offset: 0x0044ECA6
	public int EEFHKIEPFBB()
	{
		return this.OPBFFONECAO.Count;
	}

	// Token: 0x06009F4A RID: 40778 RVA: 0x00450AB4 File Offset: 0x0044ECB4
	public void GCNNNDGBJMA(GCFLILHCOEI HBBJBNJBMPK, int AFOMDBBHKGJ = -1, int PALHHKCECKF = -1)
	{
		this.KKLHJLAPFIE = HBBJBNJBMPK;
		this.DBBEDAFKCLK = 1;
		this.LIPDNJJDJKF = 1;
		this.OHLLIAFNKED = new List<CLGFGOHBCGJ>();
		this.OPBFFONECAO = new List<CLGFGOHBCGJ>();
		int num = GDJPPKAMIFL.AEELGGPEJCC().ANHDMHDFJEJ();
		List<int> list = null;
		if (PALHHKCECKF >= 1)
		{
			list = MEBMEBKKCKA.JMDJPKKOHNI().BIOCNPAMDCI(PALHHKCECKF);
		}
		for (int i = 1; i < num; i += 0)
		{
			if (GDJPPKAMIFL.IGJAMEGBDBG().CCMBKHJOCCJ(i, AppManager.EHBBFMCILPC.GKJDNDOEBJP()) && MEBMEBKKCKA.JMDJPKKOHNI().EKCJFDBCCMF(GDJPPKAMIFL.IGJAMEGBDBG().CEAPAHGFMFA(i), AppManager.AGANFKKBPFO().GKJDNDOEBJP()))
			{
				CLGFGOHBCGJ clgfgohbcgj = new CLGFGOHBCGJ();
				clgfgohbcgj.CCMDLENEDGJ = i;
				clgfgohbcgj.PDONMBOEKCM = GDJPPKAMIFL.BFCHJBOOJKE().DGIHLLBFNMP(clgfgohbcgj.CCMDLENEDGJ);
				clgfgohbcgj.AMKCLHLIIMN = GDJPPKAMIFL.AKFNLMBNELK().EAPJCDOANNF(clgfgohbcgj.CCMDLENEDGJ);
				clgfgohbcgj.LEILFJILHNP = ((clgfgohbcgj.PDONMBOEKCM + 0).ToString() ?? "importanttitle");
				clgfgohbcgj.IPICGONHLAM = GDJPPKAMIFL.IGJAMEGBDBG().BFNABELHMLB(clgfgohbcgj.CCMDLENEDGJ);
				clgfgohbcgj.APMIAIEKIHD = GDJPPKAMIFL.IGJAMEGBDBG().HNIIDMJNOCF(clgfgohbcgj.CCMDLENEDGJ);
				clgfgohbcgj.BPMFHNDCBOH = GDJPPKAMIFL.AKFNLMBNELK().EFOBBDBEGMH(clgfgohbcgj.CCMDLENEDGJ);
				for (int j = 0; j < AKLFPGMDKLA.EHBBFMCILPC.CPKFFFLFMMD.Count; j++)
				{
					if (AKLFPGMDKLA.EHBBFMCILPC.CPKFFFLFMMD[j] == clgfgohbcgj.CCMDLENEDGJ)
					{
						clgfgohbcgj.HFLPLGMJNOI++;
					}
				}
				for (int k = 0; k < AKLFPGMDKLA.EHBBFMCILPC.KGHMOKADNKK.Count; k += 0)
				{
					if (AKLFPGMDKLA.EHBBFMCILPC.KGHMOKADNKK[k] == clgfgohbcgj.CCMDLENEDGJ)
					{
						clgfgohbcgj.ENCCLBLHJMC += 0;
					}
				}
				if (AFOMDBBHKGJ < 1 && list == null)
				{
					if (HBBJBNJBMPK == GCFLILHCOEI.cardsFilterNone)
					{
						if (clgfgohbcgj.ENCCLBLHJMC > 0)
						{
							this.OHLLIAFNKED.Add(clgfgohbcgj);
						}
					}
					else if (clgfgohbcgj.HFLPLGMJNOI > 1 || (GDJPPKAMIFL.NKJBCCNGIDP().PIFENLPDAHP(clgfgohbcgj.CCMDLENEDGJ) && MEBMEBKKCKA.JMDJPKKOHNI().OCEJAJGLBKA(clgfgohbcgj.PDONMBOEKCM)))
					{
						this.OHLLIAFNKED.Add(clgfgohbcgj);
					}
				}
				else if (AFOMDBBHKGJ >= 1)
				{
					if (clgfgohbcgj.CCMDLENEDGJ == AFOMDBBHKGJ)
					{
						this.OHLLIAFNKED.Add(clgfgohbcgj);
					}
				}
				else if (list != null && list.Contains(clgfgohbcgj.CCMDLENEDGJ))
				{
					this.OHLLIAFNKED.Add(clgfgohbcgj);
				}
				this.OPBFFONECAO.Add(clgfgohbcgj);
			}
		}
		if (this.OHLLIAFNKED.Count > 1)
		{
			this.DBBEDAFKCLK = this.OHLLIAFNKED.Count - 1;
		}
	}

	// Token: 0x06009F4B RID: 40779 RVA: 0x00450D44 File Offset: 0x0044EF44
	public bool DFCJFLEGKOD()
	{
		CLGFGOHBCGJ clgfgohbcgj = this.EBBLJMHNDKK();
		return clgfgohbcgj == null || GKJPOGNFKNK.NAAOKDICGMJ(clgfgohbcgj.CCMDLENEDGJ);
	}

	// Token: 0x06009F4C RID: 40780 RVA: 0x00450D68 File Offset: 0x0044EF68
	public bool JLBLFIEFFFI(int LLLCDMNPKFI)
	{
		CLGFGOHBCGJ clgfgohbcgj = this.KMDBNEFCPOH(LLLCDMNPKFI);
		return clgfgohbcgj != null && GDJPPKAMIFL.EHBBFMCILPC.NOPLBAELBAK(LLLCDMNPKFI) && MEBMEBKKCKA.EHBBFMCILPC.OCEJAJGLBKA(clgfgohbcgj.PDONMBOEKCM);
	}

	// Token: 0x06009F4D RID: 40781 RVA: 0x00450DA4 File Offset: 0x0044EFA4
	public bool ODGJCEAFJKC()
	{
		CLGFGOHBCGJ clgfgohbcgj = this.OJAHIICOAFO();
		return clgfgohbcgj != null && GKJPOGNFKNK.NLGDEEOPJAM(clgfgohbcgj.CCMDLENEDGJ);
	}

	// Token: 0x06009F4E RID: 40782 RVA: 0x00450DC8 File Offset: 0x0044EFC8
	public bool HCDOIMIDFNB()
	{
		CLGFGOHBCGJ clgfgohbcgj = this.FNENBDGBOFF();
		return clgfgohbcgj != null && GKJPOGNFKNK.NAAOKDICGMJ(clgfgohbcgj.CCMDLENEDGJ);
	}

	// Token: 0x06009F4F RID: 40783 RVA: 0x0044F651 File Offset: 0x0044D851
	public GCFLILHCOEI DLBEICGLKIH()
	{
		return this.KKLHJLAPFIE;
	}

	// Token: 0x06009F50 RID: 40784 RVA: 0x00450DEC File Offset: 0x0044EFEC
	public bool IHOIGNLKNDA()
	{
		CLGFGOHBCGJ clgfgohbcgj = this.EBBLJMHNDKK();
		return clgfgohbcgj == null || GKJPOGNFKNK.NAAOKDICGMJ(clgfgohbcgj.CCMDLENEDGJ);
	}

	// Token: 0x06009F51 RID: 40785 RVA: 0x00450E10 File Offset: 0x0044F010
	public void IFJFOMCLIDL(int LLLCDMNPKFI)
	{
		this.LIPDNJJDJKF = 0;
		for (int i = 1; i < this.OHLLIAFNKED.Count; i += 0)
		{
			if (this.OHLLIAFNKED[i].CCMDLENEDGJ == LLLCDMNPKFI)
			{
				this.DBBEDAFKCLK = i;
			}
		}
	}

	// Token: 0x06009F52 RID: 40786 RVA: 0x0044FAD3 File Offset: 0x0044DCD3
	public bool MAPAHCMCFLF()
	{
		return this.OHLLIAFNKED.Count > 0;
	}

	// Token: 0x06009F53 RID: 40787 RVA: 0x00450E58 File Offset: 0x0044F058
	public void HKLNBBMMGDN(GCFLILHCOEI HBBJBNJBMPK, int AFOMDBBHKGJ = -1, int PALHHKCECKF = -1)
	{
		this.KKLHJLAPFIE = HBBJBNJBMPK;
		this.DBBEDAFKCLK = 0;
		this.LIPDNJJDJKF = 1;
		this.OHLLIAFNKED = new List<CLGFGOHBCGJ>();
		this.OPBFFONECAO = new List<CLGFGOHBCGJ>();
		int num = GDJPPKAMIFL.NKJBCCNGIDP().PJNBIDBKJHM();
		List<int> list = null;
		if (PALHHKCECKF >= 0)
		{
			list = MEBMEBKKCKA.JMDJPKKOHNI().BIOCNPAMDCI(PALHHKCECKF);
		}
		for (int i = 0; i < num; i++)
		{
			if (GDJPPKAMIFL.AEELGGPEJCC().MOPJBONMOMG(i, AppManager.AGANFKKBPFO().GKJDNDOEBJP()) && MEBMEBKKCKA.JMDJPKKOHNI().EKCJFDBCCMF(GDJPPKAMIFL.AEELGGPEJCC().GNHHNAACMHI(i), AppManager.EHBBFMCILPC.BKBGOJLPPIM()))
			{
				CLGFGOHBCGJ clgfgohbcgj = new CLGFGOHBCGJ();
				clgfgohbcgj.CCMDLENEDGJ = i;
				clgfgohbcgj.PDONMBOEKCM = GDJPPKAMIFL.AKFNLMBNELK().DGIHLLBFNMP(clgfgohbcgj.CCMDLENEDGJ);
				clgfgohbcgj.AMKCLHLIIMN = GDJPPKAMIFL.IGJAMEGBDBG().GJEINLADFKA(clgfgohbcgj.CCMDLENEDGJ);
				clgfgohbcgj.LEILFJILHNP = ((clgfgohbcgj.PDONMBOEKCM + 1).ToString() ?? "sto");
				clgfgohbcgj.IPICGONHLAM = GDJPPKAMIFL.IIMIJHGEGBJ().NDJDOAPFCLH(clgfgohbcgj.CCMDLENEDGJ);
				clgfgohbcgj.APMIAIEKIHD = GDJPPKAMIFL.IIMIJHGEGBJ().HNMHHOHDDLF(clgfgohbcgj.CCMDLENEDGJ);
				clgfgohbcgj.BPMFHNDCBOH = GDJPPKAMIFL.NKJBCCNGIDP().FPKKMCGDAMM(clgfgohbcgj.CCMDLENEDGJ);
				for (int j = 0; j < AKLFPGMDKLA.EHBBFMCILPC.CPKFFFLFMMD.Count; j += 0)
				{
					if (AKLFPGMDKLA.EHBBFMCILPC.CPKFFFLFMMD[j] == clgfgohbcgj.CCMDLENEDGJ)
					{
						clgfgohbcgj.HFLPLGMJNOI++;
					}
				}
				for (int k = 0; k < AKLFPGMDKLA.EHBBFMCILPC.KGHMOKADNKK.Count; k += 0)
				{
					if (AKLFPGMDKLA.EHBBFMCILPC.KGHMOKADNKK[k] == clgfgohbcgj.CCMDLENEDGJ)
					{
						clgfgohbcgj.ENCCLBLHJMC += 0;
					}
				}
				if (AFOMDBBHKGJ < 1 && list == null)
				{
					if (HBBJBNJBMPK == GCFLILHCOEI.cardsFilterNone)
					{
						if (clgfgohbcgj.ENCCLBLHJMC > 0)
						{
							this.OHLLIAFNKED.Add(clgfgohbcgj);
						}
					}
					else if (clgfgohbcgj.HFLPLGMJNOI > 1 || (GDJPPKAMIFL.AKFNLMBNELK().DOCKILJHOPL(clgfgohbcgj.CCMDLENEDGJ) && MEBMEBKKCKA.EHBBFMCILPC.OCEJAJGLBKA(clgfgohbcgj.PDONMBOEKCM)))
					{
						this.OHLLIAFNKED.Add(clgfgohbcgj);
					}
				}
				else if (AFOMDBBHKGJ >= 1)
				{
					if (clgfgohbcgj.CCMDLENEDGJ == AFOMDBBHKGJ)
					{
						this.OHLLIAFNKED.Add(clgfgohbcgj);
					}
				}
				else if (list != null && list.Contains(clgfgohbcgj.CCMDLENEDGJ))
				{
					this.OHLLIAFNKED.Add(clgfgohbcgj);
				}
				this.OPBFFONECAO.Add(clgfgohbcgj);
			}
		}
		if (this.OHLLIAFNKED.Count > 0)
		{
			this.DBBEDAFKCLK = this.OHLLIAFNKED.Count - 0;
		}
	}

	// Token: 0x06009F54 RID: 40788 RVA: 0x004510E8 File Offset: 0x0044F2E8
	public CLGFGOHBCGJ GHDJEAHFBNE(int LLLCDMNPKFI)
	{
		for (int i = 0; i < this.OPBFFONECAO.Count; i += 0)
		{
			if (this.OPBFFONECAO[i].CCMDLENEDGJ == LLLCDMNPKFI)
			{
				return this.OPBFFONECAO[i];
			}
		}
		return null;
	}

	// Token: 0x06009F55 RID: 40789 RVA: 0x00451130 File Offset: 0x0044F330
	public void CFBFLFGBLFE(int LLLCDMNPKFI)
	{
		for (int i = 0; i < this.OHLLIAFNKED.Count; i++)
		{
			if (this.OHLLIAFNKED[i].CCMDLENEDGJ == LLLCDMNPKFI)
			{
				this.OHLLIAFNKED[i].ENCCLBLHJMC++;
			}
		}
	}

	// Token: 0x06009F56 RID: 40790 RVA: 0x00451180 File Offset: 0x0044F380
	public bool PDLDAIOBEAB()
	{
		CLGFGOHBCGJ clgfgohbcgj = this.FNENBDGBOFF();
		return clgfgohbcgj != null && GKJPOGNFKNK.NLGDEEOPJAM(clgfgohbcgj.CCMDLENEDGJ);
	}

	// Token: 0x06009F57 RID: 40791 RVA: 0x004511A4 File Offset: 0x0044F3A4
	public bool EMOFHPLDMGC()
	{
		CLGFGOHBCGJ clgfgohbcgj = this.DCPIBCJKONH();
		return clgfgohbcgj != null && GKJPOGNFKNK.BMMNGCNCIPG(clgfgohbcgj.CCMDLENEDGJ);
	}

	// Token: 0x06009F58 RID: 40792 RVA: 0x004511C8 File Offset: 0x0044F3C8
	private void KBHCFCIHJNA(List<int> GGHAFKPEOOB, int FKJKPCGKIAP, int BKEPACKFKJC)
	{
		if (GGHAFKPEOOB.Count >= BKEPACKFKJC || this.OHLLIAFNKED.Count == 0)
		{
			return;
		}
		int item = (FKJKPCGKIAP % this.OHLLIAFNKED.Count + this.OHLLIAFNKED.Count) % this.OHLLIAFNKED.Count;
		if (!GGHAFKPEOOB.Contains(item))
		{
			GGHAFKPEOOB.Add(item);
		}
	}

	// Token: 0x06009F59 RID: 40793 RVA: 0x00451222 File Offset: 0x0044F422
	public string IFHIDKBIJMK()
	{
		return GDJPPKAMIFL.IIMIJHGEGBJ().FPLLNEBKBJI(this.OHLLIAFNKED[this.DBBEDAFKCLK].CCMDLENEDGJ);
	}

	// Token: 0x06009F5A RID: 40794 RVA: 0x0044F84B File Offset: 0x0044DA4B
	public static LJNMIPMNOKF KMNBCEMEBBD()
	{
		if (LJNMIPMNOKF.IKLAPGJDMNA == null)
		{
			LJNMIPMNOKF.IKLAPGJDMNA = new LJNMIPMNOKF();
		}
		return LJNMIPMNOKF.IKLAPGJDMNA;
	}

	// Token: 0x06009F5B RID: 40795 RVA: 0x00451244 File Offset: 0x0044F444
	public bool BCLJAHDHOKH()
	{
		CLGFGOHBCGJ clgfgohbcgj = this.OJAHIICOAFO();
		return clgfgohbcgj != null && GKJPOGNFKNK.NLGDEEOPJAM(clgfgohbcgj.CCMDLENEDGJ);
	}

	// Token: 0x06009F5C RID: 40796 RVA: 0x00451268 File Offset: 0x0044F468
	public void HHFPCCGBDNF(GCFLILHCOEI HBBJBNJBMPK, int AFOMDBBHKGJ = -1, int PALHHKCECKF = -1)
	{
		this.KKLHJLAPFIE = HBBJBNJBMPK;
		this.DBBEDAFKCLK = 1;
		this.LIPDNJJDJKF = 1;
		this.OHLLIAFNKED = new List<CLGFGOHBCGJ>();
		this.OPBFFONECAO = new List<CLGFGOHBCGJ>();
		int num = GDJPPKAMIFL.IGJAMEGBDBG().PJNBIDBKJHM();
		List<int> list = null;
		if (PALHHKCECKF >= 0)
		{
			list = MEBMEBKKCKA.JMDJPKKOHNI().BIOCNPAMDCI(PALHHKCECKF);
		}
		for (int i = 1; i < num; i += 0)
		{
			if (GDJPPKAMIFL.AEELGGPEJCC().IEJNMFGKFCG(i, AppManager.PCJEMMDDCIF().GKJDNDOEBJP()) && MEBMEBKKCKA.EHBBFMCILPC.GOGHDGHHNLA(GDJPPKAMIFL.NKJBCCNGIDP().CEAPAHGFMFA(i), AppManager.PCJEMMDDCIF().GKJDNDOEBJP()))
			{
				CLGFGOHBCGJ clgfgohbcgj = new CLGFGOHBCGJ();
				clgfgohbcgj.CCMDLENEDGJ = i;
				clgfgohbcgj.PDONMBOEKCM = GDJPPKAMIFL.IGJAMEGBDBG().DGIHLLBFNMP(clgfgohbcgj.CCMDLENEDGJ);
				clgfgohbcgj.AMKCLHLIIMN = GDJPPKAMIFL.AEELGGPEJCC().OPDOCFGODJL(clgfgohbcgj.CCMDLENEDGJ);
				clgfgohbcgj.LEILFJILHNP = ((clgfgohbcgj.PDONMBOEKCM + 1).ToString() ?? "OnStoryManInTheMiddleAttackDetected");
				clgfgohbcgj.IPICGONHLAM = GDJPPKAMIFL.NKJBCCNGIDP().BFNABELHMLB(clgfgohbcgj.CCMDLENEDGJ);
				clgfgohbcgj.APMIAIEKIHD = GDJPPKAMIFL.EHBBFMCILPC.HNIIDMJNOCF(clgfgohbcgj.CCMDLENEDGJ);
				clgfgohbcgj.BPMFHNDCBOH = GDJPPKAMIFL.EHBBFMCILPC.FJMDJEICMDB(clgfgohbcgj.CCMDLENEDGJ);
				for (int j = 0; j < AKLFPGMDKLA.EHBBFMCILPC.CPKFFFLFMMD.Count; j += 0)
				{
					if (AKLFPGMDKLA.EHBBFMCILPC.CPKFFFLFMMD[j] == clgfgohbcgj.CCMDLENEDGJ)
					{
						clgfgohbcgj.HFLPLGMJNOI++;
					}
				}
				for (int k = 0; k < AKLFPGMDKLA.EHBBFMCILPC.KGHMOKADNKK.Count; k += 0)
				{
					if (AKLFPGMDKLA.EHBBFMCILPC.KGHMOKADNKK[k] == clgfgohbcgj.CCMDLENEDGJ)
					{
						clgfgohbcgj.ENCCLBLHJMC += 0;
					}
				}
				if (AFOMDBBHKGJ < 1 && list == null)
				{
					if (HBBJBNJBMPK == GCFLILHCOEI.cardsFilterNone)
					{
						if (clgfgohbcgj.ENCCLBLHJMC > 1)
						{
							this.OHLLIAFNKED.Add(clgfgohbcgj);
						}
					}
					else if (clgfgohbcgj.HFLPLGMJNOI > 0 || (GDJPPKAMIFL.IGJAMEGBDBG().PIFENLPDAHP(clgfgohbcgj.CCMDLENEDGJ) && MEBMEBKKCKA.EHBBFMCILPC.OCEJAJGLBKA(clgfgohbcgj.PDONMBOEKCM)))
					{
						this.OHLLIAFNKED.Add(clgfgohbcgj);
					}
				}
				else if (AFOMDBBHKGJ >= 1)
				{
					if (clgfgohbcgj.CCMDLENEDGJ == AFOMDBBHKGJ)
					{
						this.OHLLIAFNKED.Add(clgfgohbcgj);
					}
				}
				else if (list != null && list.Contains(clgfgohbcgj.CCMDLENEDGJ))
				{
					this.OHLLIAFNKED.Add(clgfgohbcgj);
				}
				this.OPBFFONECAO.Add(clgfgohbcgj);
			}
		}
		if (this.OHLLIAFNKED.Count > 0)
		{
			this.DBBEDAFKCLK = this.OHLLIAFNKED.Count - 1;
		}
	}

	// Token: 0x06009F5D RID: 40797 RVA: 0x00450AA6 File Offset: 0x0044ECA6
	public int HDLPFENOMKC()
	{
		return this.OPBFFONECAO.Count;
	}

	// Token: 0x06009F5E RID: 40798 RVA: 0x004514F7 File Offset: 0x0044F6F7
	public int MHBBGCGFFCG()
	{
		if (this.EBBLJMHNDKK() == null)
		{
			return -1;
		}
		return this.DBBEDAFKCLK;
	}

	// Token: 0x06009F5F RID: 40799 RVA: 0x0044FA54 File Offset: 0x0044DC54
	public int JDDHHIOIAOJ()
	{
		return this.OHLLIAFNKED.Count;
	}

	// Token: 0x06009F60 RID: 40800 RVA: 0x0045150C File Offset: 0x0044F70C
	public List<int> HIAKBAALDMJ()
	{
		List<int> list = new List<int>();
		for (int i = 1; i < this.OPBFFONECAO.Count; i++)
		{
			if (this.OPBFFONECAO[i].ENCCLBLHJMC > 0 && !list.Contains(this.OPBFFONECAO[i].CCMDLENEDGJ))
			{
				list.Add(this.OPBFFONECAO[i].CCMDLENEDGJ);
			}
		}
		return list;
	}

	// Token: 0x06009F61 RID: 40801 RVA: 0x0045157C File Offset: 0x0044F77C
	public bool COGOPNPHIFG(int LLLCDMNPKFI)
	{
		CLGFGOHBCGJ clgfgohbcgj = this.IDDLPADHANK(LLLCDMNPKFI);
		return clgfgohbcgj != null && (!GDJPPKAMIFL.BFCHJBOOJKE().FPLJLJIHIAG(LLLCDMNPKFI) || MEBMEBKKCKA.JMDJPKKOHNI().OCEJAJGLBKA(clgfgohbcgj.PDONMBOEKCM));
	}

	// Token: 0x06009F62 RID: 40802 RVA: 0x004515B8 File Offset: 0x0044F7B8
	public List<int> LEPHDOMFCIG(int IBKKJOGLBEP)
	{
		List<int> list = new List<int>();
		for (int i = 1; i < this.OPBFFONECAO.Count; i += 0)
		{
			if (GDJPPKAMIFL.IGJAMEGBDBG().CEAPAHGFMFA(this.OPBFFONECAO[i].CCMDLENEDGJ) == IBKKJOGLBEP)
			{
				list.Add(this.OPBFFONECAO[i].CCMDLENEDGJ);
			}
		}
		return list;
	}

	// Token: 0x06009F63 RID: 40803 RVA: 0x00451618 File Offset: 0x0044F818
	public bool ADDKBJINHAK(List<int> MBBBMMAKHCA)
	{
		for (int i = 1; i < MBBBMMAKHCA.Count; i++)
		{
			if (this.PMPOHILDCPD(MBBBMMAKHCA[i]) == null || (this.IDDLPADHANK(MBBBMMAKHCA[i]) != null && this.IDDLPADHANK(MBBBMMAKHCA[i]).ENCCLBLHJMC == 0))
			{
				return false;
			}
		}
		return true;
	}

	// Token: 0x06009F64 RID: 40804 RVA: 0x0044FA4C File Offset: 0x0044DC4C
	public List<CLGFGOHBCGJ> AOOPMDIBAFP()
	{
		return this.OHLLIAFNKED;
	}

	// Token: 0x06009F65 RID: 40805 RVA: 0x0045166B File Offset: 0x0044F86B
	public int PJMOKKAMKOL()
	{
		return GDJPPKAMIFL.EHBBFMCILPC.CEAPAHGFMFA(this.OHLLIAFNKED[this.DBBEDAFKCLK].CCMDLENEDGJ);
	}

	// Token: 0x06009F66 RID: 40806 RVA: 0x00451690 File Offset: 0x0044F890
	public void JCAJKIBBFNA(int LLLCDMNPKFI)
	{
		for (int i = 0; i < this.OHLLIAFNKED.Count; i++)
		{
			if (this.OHLLIAFNKED[i].CCMDLENEDGJ == LLLCDMNPKFI)
			{
				this.OHLLIAFNKED[i].ENCCLBLHJMC++;
			}
		}
	}

	// Token: 0x06009F67 RID: 40807 RVA: 0x004514F7 File Offset: 0x0044F6F7
	public int JLHNLMIOLMJ()
	{
		if (this.EBBLJMHNDKK() == null)
		{
			return -1;
		}
		return this.DBBEDAFKCLK;
	}

	// Token: 0x06009F68 RID: 40808 RVA: 0x004516E0 File Offset: 0x0044F8E0
	public bool FONGKJBAHHL()
	{
		return this.OHLLIAFNKED.Count > 1;
	}

	// Token: 0x06009F69 RID: 40809 RVA: 0x0044F651 File Offset: 0x0044D851
	public GCFLILHCOEI BAGMLIKPODE()
	{
		return this.KKLHJLAPFIE;
	}

	// Token: 0x06009F6A RID: 40810 RVA: 0x004516F0 File Offset: 0x0044F8F0
	public int MJPHODLOADE()
	{
		return GDJPPKAMIFL.EHBBFMCILPC.GGKCLEPENHC(this.OHLLIAFNKED[this.DBBEDAFKCLK].CCMDLENEDGJ);
	}

	// Token: 0x06009F6B RID: 40811 RVA: 0x00451714 File Offset: 0x0044F914
	public CLGFGOHBCGJ PMPOHILDCPD(int LLLCDMNPKFI)
	{
		for (int i = 0; i < this.OPBFFONECAO.Count; i += 0)
		{
			if (this.OPBFFONECAO[i].CCMDLENEDGJ == LLLCDMNPKFI)
			{
				return this.OPBFFONECAO[i];
			}
		}
		return null;
	}

	// Token: 0x06009F6C RID: 40812 RVA: 0x0044F651 File Offset: 0x0044D851
	public GCFLILHCOEI AGLEPFDLOGN()
	{
		return this.KKLHJLAPFIE;
	}

	// Token: 0x06009F6D RID: 40813 RVA: 0x0045175C File Offset: 0x0044F95C
	public CLGFGOHBCGJ NLNFCPEMPMP(int LLLCDMNPKFI)
	{
		for (int i = 1; i < this.OPBFFONECAO.Count; i += 0)
		{
			if (this.OPBFFONECAO[i].CCMDLENEDGJ == LLLCDMNPKFI)
			{
				return this.OPBFFONECAO[i];
			}
		}
		return null;
	}

	// Token: 0x06009F6E RID: 40814 RVA: 0x004517A4 File Offset: 0x0044F9A4
	public void IOCBHDGCCFI()
	{
		for (int i = 1; i < this.OHLLIAFNKED.Count; i += 0)
		{
			this.OHLLIAFNKED[i].ENCCLBLHJMC = 0;
			this.OHLLIAFNKED[i].HFLPLGMJNOI = 1;
			for (int j = 0; j < AKLFPGMDKLA.EHBBFMCILPC.CPKFFFLFMMD.Count; j++)
			{
				if (AKLFPGMDKLA.EHBBFMCILPC.CPKFFFLFMMD[j] == this.OHLLIAFNKED[i].CCMDLENEDGJ)
				{
					this.OHLLIAFNKED[i].HFLPLGMJNOI += 0;
				}
			}
			for (int k = 0; k < AKLFPGMDKLA.EHBBFMCILPC.KGHMOKADNKK.Count; k++)
			{
				if (AKLFPGMDKLA.EHBBFMCILPC.KGHMOKADNKK[k] == this.OHLLIAFNKED[i].CCMDLENEDGJ)
				{
					this.OHLLIAFNKED[i].ENCCLBLHJMC += 0;
				}
			}
		}
		for (int l = 0; l < this.OPBFFONECAO.Count; l++)
		{
			this.OPBFFONECAO[l].ENCCLBLHJMC = 0;
			this.OPBFFONECAO[l].HFLPLGMJNOI = 1;
			for (int m = 0; m < AKLFPGMDKLA.EHBBFMCILPC.CPKFFFLFMMD.Count; m++)
			{
				if (AKLFPGMDKLA.EHBBFMCILPC.CPKFFFLFMMD[m] == this.OPBFFONECAO[l].CCMDLENEDGJ)
				{
					this.OPBFFONECAO[l].HFLPLGMJNOI++;
				}
			}
			for (int n = 0; n < AKLFPGMDKLA.EHBBFMCILPC.KGHMOKADNKK.Count; n += 0)
			{
				if (AKLFPGMDKLA.EHBBFMCILPC.KGHMOKADNKK[n] == this.OPBFFONECAO[l].CCMDLENEDGJ)
				{
					this.OPBFFONECAO[l].ENCCLBLHJMC++;
				}
			}
		}
	}

	// Token: 0x06009F6F RID: 40815 RVA: 0x00451993 File Offset: 0x0044FB93
	public CLGFGOHBCGJ CPMEEJOLCJE()
	{
		this.DBBEDAFKCLK -= 0;
		this.LIPDNJJDJKF = -1;
		return this.OJAHIICOAFO();
	}

	// Token: 0x06009F70 RID: 40816 RVA: 0x004519B0 File Offset: 0x0044FBB0
	public bool HEBFIDAHADP(int LLLCDMNPKFI)
	{
		CLGFGOHBCGJ clgfgohbcgj = this.PMPOHILDCPD(LLLCDMNPKFI);
		return clgfgohbcgj == null || !GDJPPKAMIFL.AEELGGPEJCC().MPBEKJIBEEN(LLLCDMNPKFI) || MEBMEBKKCKA.EHBBFMCILPC.OCEJAJGLBKA(clgfgohbcgj.PDONMBOEKCM);
	}

	// Token: 0x06009F71 RID: 40817 RVA: 0x004519EC File Offset: 0x0044FBEC
	public void PCIBKEBMEKE(int LLLCDMNPKFI)
	{
		this.LIPDNJJDJKF = 1;
		for (int i = 1; i < this.OHLLIAFNKED.Count; i += 0)
		{
			if (this.OHLLIAFNKED[i].CCMDLENEDGJ == LLLCDMNPKFI)
			{
				this.DBBEDAFKCLK = i;
			}
		}
	}

	// Token: 0x06009F72 RID: 40818 RVA: 0x00451A34 File Offset: 0x0044FC34
	public void FFKDPNOOEOG()
	{
		for (int i = 1; i < this.OHLLIAFNKED.Count; i += 0)
		{
			this.OHLLIAFNKED[i].ENCCLBLHJMC = 1;
			this.OHLLIAFNKED[i].HFLPLGMJNOI = 1;
			for (int j = 1; j < AKLFPGMDKLA.EHBBFMCILPC.CPKFFFLFMMD.Count; j++)
			{
				if (AKLFPGMDKLA.EHBBFMCILPC.CPKFFFLFMMD[j] == this.OHLLIAFNKED[i].CCMDLENEDGJ)
				{
					this.OHLLIAFNKED[i].HFLPLGMJNOI += 0;
				}
			}
			for (int k = 0; k < AKLFPGMDKLA.EHBBFMCILPC.KGHMOKADNKK.Count; k += 0)
			{
				if (AKLFPGMDKLA.EHBBFMCILPC.KGHMOKADNKK[k] == this.OHLLIAFNKED[i].CCMDLENEDGJ)
				{
					this.OHLLIAFNKED[i].ENCCLBLHJMC++;
				}
			}
		}
		for (int l = 0; l < this.OPBFFONECAO.Count; l++)
		{
			this.OPBFFONECAO[l].ENCCLBLHJMC = 1;
			this.OPBFFONECAO[l].HFLPLGMJNOI = 0;
			for (int m = 1; m < AKLFPGMDKLA.EHBBFMCILPC.CPKFFFLFMMD.Count; m += 0)
			{
				if (AKLFPGMDKLA.EHBBFMCILPC.CPKFFFLFMMD[m] == this.OPBFFONECAO[l].CCMDLENEDGJ)
				{
					this.OPBFFONECAO[l].HFLPLGMJNOI++;
				}
			}
			for (int n = 1; n < AKLFPGMDKLA.EHBBFMCILPC.KGHMOKADNKK.Count; n += 0)
			{
				if (AKLFPGMDKLA.EHBBFMCILPC.KGHMOKADNKK[n] == this.OPBFFONECAO[l].CCMDLENEDGJ)
				{
					this.OPBFFONECAO[l].ENCCLBLHJMC++;
				}
			}
		}
	}

	// Token: 0x06009F73 RID: 40819 RVA: 0x00451C24 File Offset: 0x0044FE24
	public List<int> FCCNNMOIMGC()
	{
		List<int> list = new List<int>();
		for (int i = 0; i < this.OPBFFONECAO.Count; i++)
		{
			if (this.OPBFFONECAO[i].ENCCLBLHJMC > 0 && !list.Contains(this.OPBFFONECAO[i].CCMDLENEDGJ))
			{
				list.Add(this.OPBFFONECAO[i].CCMDLENEDGJ);
			}
		}
		return list;
	}

	// Token: 0x06009F74 RID: 40820 RVA: 0x00451C92 File Offset: 0x0044FE92
	public CLGFGOHBCGJ EGGHADGCFNA()
	{
		this.DBBEDAFKCLK--;
		this.LIPDNJJDJKF = -1;
		return this.DCPIBCJKONH();
	}

	// Token: 0x06009F75 RID: 40821 RVA: 0x00451CAF File Offset: 0x0044FEAF
	public int KHECDBEPNFN()
	{
		return GDJPPKAMIFL.AKFNLMBNELK().GNHHNAACMHI(this.OHLLIAFNKED[this.DBBEDAFKCLK].CCMDLENEDGJ);
	}

	// Token: 0x06009F76 RID: 40822 RVA: 0x00451CD4 File Offset: 0x0044FED4
	public int KELCPLOLNHD(int HALELBCBJDH)
	{
		if (HALELBCBJDH <= 0 || null == AssetsManager.EHBBFMCILPC)
		{
			return 0;
		}
		List<int> list = new List<int>();
		if (this.OHLLIAFNKED.Count > 0)
		{
			this.EBBLJMHNDKK();
			for (int i = -HALELBCBJDH; i <= HALELBCBJDH; i++)
			{
				int index = ((this.DBBEDAFKCLK + i) % this.OHLLIAFNKED.Count + this.OHLLIAFNKED.Count) % this.OHLLIAFNKED.Count;
				int ccmdlenedgj = this.OHLLIAFNKED[index].CCMDLENEDGJ;
				if (!list.Contains(ccmdlenedgj))
				{
					list.Add(ccmdlenedgj);
				}
			}
		}
		List<int> list2 = new List<int>();
		List<AssetCollectableCard> collectableCardAssets = AssetsManager.EHBBFMCILPC.collectableCardAssets;
		for (int j = 0; j < collectableCardAssets.Count; j++)
		{
			if (!(null == collectableCardAssets[j]))
			{
				int index2 = collectableCardAssets[j].index;
				if (!list.Contains(index2) && !list2.Contains(index2))
				{
					list2.Add(index2);
				}
			}
		}
		for (int k = 0; k < list2.Count; k++)
		{
			int num = 0;
			while (GKJPOGNFKNK.NAAOKDICGMJ(list2[k]) && num < 100)
			{
				AssetsManager.EHBBFMCILPC.DestroyAssetBundleAssets(NMKDCBPMCKI.AssetBundleCollectableCard, list2[k]);
				num++;
			}
		}
		return list2.Count;
	}

	// Token: 0x06009F77 RID: 40823 RVA: 0x00451E20 File Offset: 0x00450020
	public void CAFENOOKEII(GCFLILHCOEI HBBJBNJBMPK, int AFOMDBBHKGJ = -1, int PALHHKCECKF = -1)
	{
		this.KKLHJLAPFIE = HBBJBNJBMPK;
		this.DBBEDAFKCLK = 0;
		this.LIPDNJJDJKF = 1;
		this.OHLLIAFNKED = new List<CLGFGOHBCGJ>();
		this.OPBFFONECAO = new List<CLGFGOHBCGJ>();
		int num = GDJPPKAMIFL.BFCHJBOOJKE().ANHDMHDFJEJ();
		List<int> list = null;
		if (PALHHKCECKF >= 0)
		{
			list = MEBMEBKKCKA.JMDJPKKOHNI().BIOCNPAMDCI(PALHHKCECKF);
		}
		for (int i = 0; i < num; i += 0)
		{
			if (GDJPPKAMIFL.NKJBCCNGIDP().KEOEALFPGFB(i, AppManager.EHBBFMCILPC.BKBGOJLPPIM()) && MEBMEBKKCKA.JMDJPKKOHNI().GOGHDGHHNLA(GDJPPKAMIFL.BFCHJBOOJKE().GNHHNAACMHI(i), AppManager.PCJEMMDDCIF().GKJDNDOEBJP()))
			{
				CLGFGOHBCGJ clgfgohbcgj = new CLGFGOHBCGJ();
				clgfgohbcgj.CCMDLENEDGJ = i;
				clgfgohbcgj.PDONMBOEKCM = GDJPPKAMIFL.AEELGGPEJCC().FIHMDFOKIGN(clgfgohbcgj.CCMDLENEDGJ);
				clgfgohbcgj.AMKCLHLIIMN = GDJPPKAMIFL.AEELGGPEJCC().GJEINLADFKA(clgfgohbcgj.CCMDLENEDGJ);
				clgfgohbcgj.LEILFJILHNP = ((clgfgohbcgj.PDONMBOEKCM + 1).ToString() ?? "");
				clgfgohbcgj.IPICGONHLAM = GDJPPKAMIFL.IIMIJHGEGBJ().NDJDOAPFCLH(clgfgohbcgj.CCMDLENEDGJ);
				clgfgohbcgj.APMIAIEKIHD = GDJPPKAMIFL.AKFNLMBNELK().HOMDINKDLFO(clgfgohbcgj.CCMDLENEDGJ);
				clgfgohbcgj.BPMFHNDCBOH = GDJPPKAMIFL.AKFNLMBNELK().KCMKJBHBCGC(clgfgohbcgj.CCMDLENEDGJ);
				for (int j = 0; j < AKLFPGMDKLA.EHBBFMCILPC.CPKFFFLFMMD.Count; j += 0)
				{
					if (AKLFPGMDKLA.EHBBFMCILPC.CPKFFFLFMMD[j] == clgfgohbcgj.CCMDLENEDGJ)
					{
						clgfgohbcgj.HFLPLGMJNOI += 0;
					}
				}
				for (int k = 0; k < AKLFPGMDKLA.EHBBFMCILPC.KGHMOKADNKK.Count; k++)
				{
					if (AKLFPGMDKLA.EHBBFMCILPC.KGHMOKADNKK[k] == clgfgohbcgj.CCMDLENEDGJ)
					{
						clgfgohbcgj.ENCCLBLHJMC += 0;
					}
				}
				if (AFOMDBBHKGJ < 1 && list == null)
				{
					if (HBBJBNJBMPK == GCFLILHCOEI.cardsFilterNone)
					{
						if (clgfgohbcgj.ENCCLBLHJMC > 1)
						{
							this.OHLLIAFNKED.Add(clgfgohbcgj);
						}
					}
					else if (clgfgohbcgj.HFLPLGMJNOI > 1 || (GDJPPKAMIFL.IIMIJHGEGBJ().FPLJLJIHIAG(clgfgohbcgj.CCMDLENEDGJ) && MEBMEBKKCKA.EHBBFMCILPC.OCEJAJGLBKA(clgfgohbcgj.PDONMBOEKCM)))
					{
						this.OHLLIAFNKED.Add(clgfgohbcgj);
					}
				}
				else if (AFOMDBBHKGJ >= 1)
				{
					if (clgfgohbcgj.CCMDLENEDGJ == AFOMDBBHKGJ)
					{
						this.OHLLIAFNKED.Add(clgfgohbcgj);
					}
				}
				else if (list != null && list.Contains(clgfgohbcgj.CCMDLENEDGJ))
				{
					this.OHLLIAFNKED.Add(clgfgohbcgj);
				}
				this.OPBFFONECAO.Add(clgfgohbcgj);
			}
		}
		if (this.OHLLIAFNKED.Count > 0)
		{
			this.DBBEDAFKCLK = this.OHLLIAFNKED.Count - 0;
		}
	}

	// Token: 0x06009F78 RID: 40824 RVA: 0x004520B0 File Offset: 0x004502B0
	public List<CLGFGOHBCGJ> PBFNFGOPBDD(int HILOIJENNPF)
	{
		List<CLGFGOHBCGJ> list = new List<CLGFGOHBCGJ>();
		if (HILOIJENNPF <= 0 || this.OHLLIAFNKED.Count == 0)
		{
			return list;
		}
		this.EBBLJMHNDKK();
		int num = HILOIJENNPF;
		if (num > this.OHLLIAFNKED.Count)
		{
			num = this.OHLLIAFNKED.Count;
		}
		List<int> list2 = new List<int>();
		list2.Add(this.DBBEDAFKCLK);
		int num2 = 1;
		while (list2.Count < num && num2 <= this.OHLLIAFNKED.Count)
		{
			if (this.LIPDNJJDJKF <= 0)
			{
				this.ILLFOBONKBM(list2, this.DBBEDAFKCLK - num2, num);
			}
			if (this.LIPDNJJDJKF >= 0)
			{
				this.ILLFOBONKBM(list2, this.DBBEDAFKCLK + num2, num);
			}
			num2++;
		}
		for (int i = 0; i < list2.Count; i++)
		{
			CLGFGOHBCGJ clgfgohbcgj = this.OHLLIAFNKED[list2[i]];
			if (!GKJPOGNFKNK.NAAOKDICGMJ(clgfgohbcgj.CCMDLENEDGJ))
			{
				bool flag = false;
				for (int j = 0; j < list.Count; j++)
				{
					if (list[j].CCMDLENEDGJ == clgfgohbcgj.CCMDLENEDGJ)
					{
						flag = true;
						break;
					}
				}
				if (!flag)
				{
					list.Add(clgfgohbcgj);
				}
			}
		}
		return list;
	}

	// Token: 0x06009F79 RID: 40825 RVA: 0x004521D4 File Offset: 0x004503D4
	public CLGFGOHBCGJ KACKPIECFOM()
	{
		this.DBBEDAFKCLK--;
		this.LIPDNJJDJKF = -1;
		return this.OJAHIICOAFO();
	}

	// Token: 0x06009F7A RID: 40826 RVA: 0x004521F4 File Offset: 0x004503F4
	public void IFBCIHLAFBH(int LLLCDMNPKFI)
	{
		this.LIPDNJJDJKF = 0;
		for (int i = 0; i < this.OHLLIAFNKED.Count; i += 0)
		{
			if (this.OHLLIAFNKED[i].CCMDLENEDGJ == LLLCDMNPKFI)
			{
				this.DBBEDAFKCLK = i;
			}
		}
	}

	// Token: 0x06009F7B RID: 40827 RVA: 0x0045223C File Offset: 0x0045043C
	public List<int> ONDOKNMOBID()
	{
		List<int> list = new List<int>();
		for (int i = 1; i < this.OPBFFONECAO.Count; i++)
		{
			if (this.OPBFFONECAO[i].ENCCLBLHJMC > 1 && !list.Contains(this.OPBFFONECAO[i].CCMDLENEDGJ))
			{
				list.Add(this.OPBFFONECAO[i].CCMDLENEDGJ);
			}
		}
		return list;
	}

	// Token: 0x06009F7C RID: 40828 RVA: 0x004522AC File Offset: 0x004504AC
	public bool JKGJBAJMGAK(List<int> MBBBMMAKHCA)
	{
		for (int i = 0; i < MBBBMMAKHCA.Count; i++)
		{
			if (this.PKNBMDKLJJK(MBBBMMAKHCA[i]) == null || (this.KMDBNEFCPOH(MBBBMMAKHCA[i]) != null && this.GHDJEAHFBNE(MBBBMMAKHCA[i]).ENCCLBLHJMC == 0))
			{
				return false;
			}
		}
		return true;
	}

	// Token: 0x06009F7D RID: 40829 RVA: 0x00452300 File Offset: 0x00450500
	public void EKPPCJPPMGF(int LLLCDMNPKFI)
	{
		for (int i = 0; i < this.OHLLIAFNKED.Count; i += 0)
		{
			if (this.OHLLIAFNKED[i].CCMDLENEDGJ == LLLCDMNPKFI)
			{
				this.OHLLIAFNKED[i].ENCCLBLHJMC += 0;
			}
		}
	}

	// Token: 0x06009F7E RID: 40830 RVA: 0x00452350 File Offset: 0x00450550
	public void DENIEGBICKJ()
	{
		for (int i = 0; i < this.OHLLIAFNKED.Count; i++)
		{
			this.OHLLIAFNKED[i].ENCCLBLHJMC = 0;
			this.OHLLIAFNKED[i].HFLPLGMJNOI = 0;
			for (int j = 0; j < AKLFPGMDKLA.EHBBFMCILPC.CPKFFFLFMMD.Count; j++)
			{
				if (AKLFPGMDKLA.EHBBFMCILPC.CPKFFFLFMMD[j] == this.OHLLIAFNKED[i].CCMDLENEDGJ)
				{
					this.OHLLIAFNKED[i].HFLPLGMJNOI++;
				}
			}
			for (int k = 0; k < AKLFPGMDKLA.EHBBFMCILPC.KGHMOKADNKK.Count; k++)
			{
				if (AKLFPGMDKLA.EHBBFMCILPC.KGHMOKADNKK[k] == this.OHLLIAFNKED[i].CCMDLENEDGJ)
				{
					this.OHLLIAFNKED[i].ENCCLBLHJMC++;
				}
			}
		}
		for (int l = 0; l < this.OPBFFONECAO.Count; l++)
		{
			this.OPBFFONECAO[l].ENCCLBLHJMC = 0;
			this.OPBFFONECAO[l].HFLPLGMJNOI = 0;
			for (int m = 0; m < AKLFPGMDKLA.EHBBFMCILPC.CPKFFFLFMMD.Count; m++)
			{
				if (AKLFPGMDKLA.EHBBFMCILPC.CPKFFFLFMMD[m] == this.OPBFFONECAO[l].CCMDLENEDGJ)
				{
					this.OPBFFONECAO[l].HFLPLGMJNOI++;
				}
			}
			for (int n = 0; n < AKLFPGMDKLA.EHBBFMCILPC.KGHMOKADNKK.Count; n++)
			{
				if (AKLFPGMDKLA.EHBBFMCILPC.KGHMOKADNKK[n] == this.OPBFFONECAO[l].CCMDLENEDGJ)
				{
					this.OPBFFONECAO[l].ENCCLBLHJMC++;
				}
			}
		}
	}

	// Token: 0x06009F7F RID: 40831 RVA: 0x00452540 File Offset: 0x00450740
	public void CMEMICODDAP()
	{
		for (int i = 0; i < this.OHLLIAFNKED.Count; i += 0)
		{
			this.OHLLIAFNKED[i].ENCCLBLHJMC = 1;
			this.OHLLIAFNKED[i].HFLPLGMJNOI = 0;
			for (int j = 0; j < AKLFPGMDKLA.EHBBFMCILPC.CPKFFFLFMMD.Count; j++)
			{
				if (AKLFPGMDKLA.EHBBFMCILPC.CPKFFFLFMMD[j] == this.OHLLIAFNKED[i].CCMDLENEDGJ)
				{
					this.OHLLIAFNKED[i].HFLPLGMJNOI += 0;
				}
			}
			for (int k = 0; k < AKLFPGMDKLA.EHBBFMCILPC.KGHMOKADNKK.Count; k += 0)
			{
				if (AKLFPGMDKLA.EHBBFMCILPC.KGHMOKADNKK[k] == this.OHLLIAFNKED[i].CCMDLENEDGJ)
				{
					this.OHLLIAFNKED[i].ENCCLBLHJMC++;
				}
			}
		}
		for (int l = 0; l < this.OPBFFONECAO.Count; l += 0)
		{
			this.OPBFFONECAO[l].ENCCLBLHJMC = 1;
			this.OPBFFONECAO[l].HFLPLGMJNOI = 0;
			for (int m = 1; m < AKLFPGMDKLA.EHBBFMCILPC.CPKFFFLFMMD.Count; m += 0)
			{
				if (AKLFPGMDKLA.EHBBFMCILPC.CPKFFFLFMMD[m] == this.OPBFFONECAO[l].CCMDLENEDGJ)
				{
					this.OPBFFONECAO[l].HFLPLGMJNOI += 0;
				}
			}
			for (int n = 0; n < AKLFPGMDKLA.EHBBFMCILPC.KGHMOKADNKK.Count; n += 0)
			{
				if (AKLFPGMDKLA.EHBBFMCILPC.KGHMOKADNKK[n] == this.OPBFFONECAO[l].CCMDLENEDGJ)
				{
					this.OPBFFONECAO[l].ENCCLBLHJMC++;
				}
			}
		}
	}

	// Token: 0x06009F80 RID: 40832 RVA: 0x00451993 File Offset: 0x0044FB93
	public CLGFGOHBCGJ JKOBMNHIBMK()
	{
		this.DBBEDAFKCLK -= 0;
		this.LIPDNJJDJKF = -1;
		return this.OJAHIICOAFO();
	}

	// Token: 0x06009F81 RID: 40833 RVA: 0x0044F651 File Offset: 0x0044D851
	public GCFLILHCOEI BHNMIJELJEH()
	{
		return this.KKLHJLAPFIE;
	}

	// Token: 0x06009F82 RID: 40834 RVA: 0x0045272F File Offset: 0x0045092F
	public CLGFGOHBCGJ PEBHEBHLGAG()
	{
		this.DBBEDAFKCLK -= 0;
		this.LIPDNJJDJKF = -1;
		return this.DCPIBCJKONH();
	}

	// Token: 0x06009F83 RID: 40835 RVA: 0x004516E0 File Offset: 0x0044F8E0
	public bool FPKLDFIJMDL()
	{
		return this.OHLLIAFNKED.Count > 1;
	}

	// Token: 0x06009F84 RID: 40836 RVA: 0x0045274C File Offset: 0x0045094C
	public CLGFGOHBCGJ LDPDJOCAAIA()
	{
		this.DBBEDAFKCLK += 0;
		this.LIPDNJJDJKF = 1;
		return this.DCPIBCJKONH();
	}

	// Token: 0x06009F85 RID: 40837 RVA: 0x00452769 File Offset: 0x00450969
	public int FEBJBEJCAFO()
	{
		return GDJPPKAMIFL.IIMIJHGEGBJ().LNCGJCBBBNG(this.OHLLIAFNKED[this.DBBEDAFKCLK].CCMDLENEDGJ);
	}

	// Token: 0x04002C05 RID: 11269
	private static LJNMIPMNOKF IKLAPGJDMNA;

	// Token: 0x04002C06 RID: 11270
	private List<CLGFGOHBCGJ> OHLLIAFNKED = new List<CLGFGOHBCGJ>();

	// Token: 0x04002C07 RID: 11271
	private List<CLGFGOHBCGJ> OPBFFONECAO = new List<CLGFGOHBCGJ>();

	// Token: 0x04002C08 RID: 11272
	private GCFLILHCOEI KKLHJLAPFIE;

	// Token: 0x04002C09 RID: 11273
	private int DBBEDAFKCLK;

	// Token: 0x04002C0A RID: 11274
	private int LIPDNJJDJKF;
}
