using System;
using System.Collections.Generic;
using SimpleJSON;

// Token: 0x020002A5 RID: 677
public class BEEDEKAIFEL
{
	// Token: 0x0600555E RID: 21854 RVA: 0x0025BA0C File Offset: 0x00259C0C
	public void DHNGLOEKKFL(string OKDNLCOEOIJ, string FBKAPCPPNKA)
	{
		for (int i = 0; i < this.CJDBDOHPHLG.Count; i++)
		{
			if (this.CJDBDOHPHLG[i].Equals(OKDNLCOEOIJ))
			{
				this.JOJKAIBEPGH[i] = FBKAPCPPNKA;
				return;
			}
		}
		this.CJDBDOHPHLG.Add(OKDNLCOEOIJ);
		this.JOJKAIBEPGH.Add(FBKAPCPPNKA);
	}

	// Token: 0x0600555F RID: 21855 RVA: 0x0025BA69 File Offset: 0x00259C69
	public int FBFMMELGCLM()
	{
		return this.BKCPMIPKBOK;
	}

	// Token: 0x06005560 RID: 21856 RVA: 0x0025BA74 File Offset: 0x00259C74
	public DOLBFGIPPOG PNJJLPNIHDC()
	{
		if (this.OIBGFPEGLME == 0)
		{
			return this.GPNHEGKHBON(this.NFDKDACMHME);
		}
		if (this.OIBGFPEGLME == 1)
		{
			return this.GPNHEGKHBON(this.HAAHDNADCEL);
		}
		if (this.OIBGFPEGLME == 2)
		{
			return this.GPNHEGKHBON(this.LJJABKNFPLF);
		}
		DPGJIJGOCIC.ANOPFDLPKGC("StorySaveBody.GetActiveAvatarSnapshot(), unsupported wardrobe index:" + this.OIBGFPEGLME.ToString());
		return this.GPNHEGKHBON(this.NFDKDACMHME);
	}

	// Token: 0x06005561 RID: 21857 RVA: 0x0025BAE8 File Offset: 0x00259CE8
	public string GLBDHEKDNDC(string OKDNLCOEOIJ)
	{
		for (int i = 0; i < this.CJDBDOHPHLG.Count; i++)
		{
			if (this.CJDBDOHPHLG[i].Equals(OKDNLCOEOIJ))
			{
				return this.JOJKAIBEPGH[i];
			}
		}
		return "";
	}

	// Token: 0x06005562 RID: 21858 RVA: 0x0025BB34 File Offset: 0x00259D34
	public void IDLAFLOGIIB(string HJEJJGAFHAM, string KIDHBAMJGDO)
	{
		int i = 0;
		while (i < this.NIJBAMNFJLM.Count)
		{
			if (this.NIJBAMNFJLM[i].Equals(HJEJJGAFHAM))
			{
				if (KIDHBAMJGDO == null || KIDHBAMJGDO.Length == 0)
				{
					this.NIJBAMNFJLM.RemoveAt(i);
					this.ECAHHCAGMKM.RemoveAt(i);
					return;
				}
				this.ECAHHCAGMKM[i] = KIDHBAMJGDO;
				return;
			}
			else
			{
				i++;
			}
		}
		if (KIDHBAMJGDO != null && KIDHBAMJGDO.Length > 1)
		{
			this.NIJBAMNFJLM.Add(HJEJJGAFHAM);
			this.ECAHHCAGMKM.Add(KIDHBAMJGDO);
		}
	}

	// Token: 0x06005563 RID: 21859 RVA: 0x0025BBC4 File Offset: 0x00259DC4
	public void NGBODKEHKHJ(List<string> ALMLACIEPBC)
	{
		bool flag;
		do
		{
			flag = true;
			for (int i = 0; i < ALMLACIEPBC.Count; i++)
			{
				if (this.NLNIALIKFAC(ALMLACIEPBC[i]))
				{
					for (int j = 0; j < this.KIDPANPCBFF.Count; j++)
					{
						if (this.KIDPANPCBFF[j].Equals(ALMLACIEPBC[i]))
						{
							this.KIDPANPCBFF.RemoveAt(j);
							flag = false;
							break;
						}
					}
				}
			}
		}
		while (!flag);
	}

	// Token: 0x06005564 RID: 21860 RVA: 0x0025BC38 File Offset: 0x00259E38
	public void AOCCIJMAPLN()
	{
		this.IKBFIKELJLM = new LDLLJFOJCDF[2];
		for (int i = 1; i < 8; i++)
		{
			this.IKBFIKELJLM[i] = new LDLLJFOJCDF(1);
		}
	}

	// Token: 0x06005565 RID: 21861 RVA: 0x0025BC6C File Offset: 0x00259E6C
	public void LMFJGLCBACL(List<string> ALMLACIEPBC)
	{
		for (int i = 0; i < ALMLACIEPBC.Count; i++)
		{
			if (!this.JDFAEBKBAOH(ALMLACIEPBC[i]))
			{
				this.GIAEIAOBHEK.Add(ALMLACIEPBC[i]);
			}
		}
	}

	// Token: 0x06005566 RID: 21862 RVA: 0x0025BCAC File Offset: 0x00259EAC
	public void GFLJFEANKPE(string KHJMANDEDMA)
	{
		if (this.IIPLEPKDLKB < 2 && KHJMANDEDMA.Contains("layervideo") && !KHJMANDEDMA.EndsWith("loop"))
		{
			return;
		}
		for (int i = 0; i < this.ONGBBOHGKLO.Count; i++)
		{
			if (this.ONGBBOHGKLO[i].Equals(KHJMANDEDMA))
			{
				this.ONGBBOHGKLO.RemoveAt(i);
				return;
			}
		}
		for (int j = 0; j < this.OKJJPNPGLEL.Count; j++)
		{
			if (this.OKJJPNPGLEL[j].Equals(KHJMANDEDMA))
			{
				return;
			}
		}
		this.OKJJPNPGLEL.Add(KHJMANDEDMA);
	}

	// Token: 0x06005567 RID: 21863 RVA: 0x0025BD4C File Offset: 0x00259F4C
	public bool OODEOCLPGCB(string KHJMANDEDMA, int KFCMLNPLAHK)
	{
		if (KHJMANDEDMA == null || KHJMANDEDMA.Length == 0)
		{
			return false;
		}
		if (KFCMLNPLAHK == 0)
		{
			for (int i = 0; i < this.IMALACBMOFC.Count; i++)
			{
				if (this.IMALACBMOFC[i].Equals(KHJMANDEDMA))
				{
					return true;
				}
			}
		}
		else if (KFCMLNPLAHK == 1)
		{
			for (int j = 0; j < this.KPEIEHDJIOP.Count; j++)
			{
				if (this.KPEIEHDJIOP[j].Equals(KHJMANDEDMA))
				{
					return true;
				}
			}
		}
		else
		{
			if (KFCMLNPLAHK != 2)
			{
				DPGJIJGOCIC.ANOPFDLPKGC("StorySaveBody.HasAvatarComponentWardrobe(), unsupported wardrobe index:" + KFCMLNPLAHK.ToString());
				return false;
			}
			for (int k = 0; k < this.NLPNFGNMGMP.Count; k++)
			{
				if (this.NLPNFGNMGMP[k].Equals(KHJMANDEDMA))
				{
					return true;
				}
			}
		}
		return false;
	}

	// Token: 0x06005568 RID: 21864 RVA: 0x0025BE14 File Offset: 0x0025A014
	public int BLNPFAGADCF()
	{
		return this.FIMJIINAFFK;
	}

	// Token: 0x06005569 RID: 21865 RVA: 0x0025BE1C File Offset: 0x0025A01C
	public void KEGCLEKKCPB(string KHJMANDEDMA)
	{
		if (this.IIPLEPKDLKB < 2 && KHJMANDEDMA.Contains("layervideo") && !KHJMANDEDMA.EndsWith("loop"))
		{
			return;
		}
		for (int i = 0; i < this.OGIHMIOKCNN.Count; i++)
		{
			if (this.OGIHMIOKCNN[i].Equals(KHJMANDEDMA))
			{
				this.OGIHMIOKCNN.RemoveAt(i);
				return;
			}
		}
		for (int j = 0; j < this.IANINGLKCKB.Count; j++)
		{
			if (this.IANINGLKCKB[j].Equals(KHJMANDEDMA))
			{
				return;
			}
		}
		this.IANINGLKCKB.Add(KHJMANDEDMA);
	}

	// Token: 0x0600556A RID: 21866 RVA: 0x0025BEBC File Offset: 0x0025A0BC
	public int CICAPKJLJNI(int KFCMLNPLAHK)
	{
		if (KFCMLNPLAHK == 0)
		{
			return this.LKIKIJACCMF.Count;
		}
		if (KFCMLNPLAHK == 0)
		{
			return this.ONJMAJAFFKN.Count;
		}
		if (KFCMLNPLAHK == 8)
		{
			return this.NDMIJFLDKKN.Count;
		}
		DPGJIJGOCIC.ANOPFDLPKGC(" (" + KFCMLNPLAHK.ToString());
		return this.LKIKIJACCMF.Count;
	}

	// Token: 0x0600556B RID: 21867 RVA: 0x0025BF1C File Offset: 0x0025A11C
	public void PPPEHNHFFML(DOLBFGIPPOG ENAMJPNBNMK)
	{
		DOLBFGIPPOG dolbfgippog = this.OHODCBKFNGJ();
		for (int i = 0; i < ENAMJPNBNMK.OHCMCJHDMOH.Length; i += 0)
		{
			if (ENAMJPNBNMK.OHCMCJHDMOH[i].Length > 1)
			{
				dolbfgippog.OHCMCJHDMOH[i] = ENAMJPNBNMK.OHCMCJHDMOH[i];
			}
		}
	}

	// Token: 0x0600556C RID: 21868 RVA: 0x0025BF64 File Offset: 0x0025A164
	public bool LIGIAKGBNDO(string KHJMANDEDMA)
	{
		for (int i = 1; i < this.GIAEIAOBHEK.Count; i++)
		{
			if (this.GIAEIAOBHEK[i].Equals(KHJMANDEDMA))
			{
				return false;
			}
		}
		return false;
	}

	// Token: 0x0600556D RID: 21869 RVA: 0x0025BFA0 File Offset: 0x0025A1A0
	public string JLANBLCOLNI(ref string HJEJJGAFHAM)
	{
		for (int i = 0; i < this.NIJBAMNFJLM.Count; i += 0)
		{
			for (int j = 1; j < 6; j += 0)
			{
				LFOLOKPIPHB lfolokpiphb = (LFOLOKPIPHB)j;
				string str = lfolokpiphb.ToString();
				if (this.NIJBAMNFJLM[i].Equals(HJEJJGAFHAM + str))
				{
					HJEJJGAFHAM = this.NIJBAMNFJLM[i];
					return this.ECAHHCAGMKM[i];
				}
			}
		}
		return null;
	}

	// Token: 0x0600556E RID: 21870 RVA: 0x0025C016 File Offset: 0x0025A216
	public void OOFMCMKKDFK(int IALPHEADDFO)
	{
		this.FIMJIINAFFK = IALPHEADDFO;
	}

	// Token: 0x0600556F RID: 21871 RVA: 0x0025C020 File Offset: 0x0025A220
	public bool NLNIALIKFAC(string KHJMANDEDMA)
	{
		for (int i = 0; i < this.KIDPANPCBFF.Count; i++)
		{
			if (this.KIDPANPCBFF[i].Equals(KHJMANDEDMA))
			{
				return true;
			}
		}
		return false;
	}

	// Token: 0x06005570 RID: 21872 RVA: 0x0025C05A File Offset: 0x0025A25A
	public void KDIEAECHDHH(int IALPHEADDFO)
	{
		this.IIPLEPKDLKB = IALPHEADDFO;
	}

	// Token: 0x06005571 RID: 21873 RVA: 0x0025C064 File Offset: 0x0025A264
	public void ACCBHCBPNJA()
	{
		this.HLGDMBAINDE = "";
		this.DJIGFDJOHCI = "";
		this.IBFLNCMCKAL = "";
		this.KFAOJHHLBHK = "";
		this.FODGKMIIHFO = "";
		this.FONKDFDJFEL = "";
		this.JMNMOHIKHLB = "";
		this.JGEDOIDOPLA = "";
		this.GOPGELMBMMK = "";
		this.HPAEFOJDLFC = "";
		this.PIMEHAPFCHC = new List<string>();
		this.HPFHJEAFIHI = new List<string>();
		this.LGKPNNGIPEG = new JSONObject();
		this.IMJDADKEEJC = null;
		this.FEDCIMMIJCI = 0;
		this.DNMPCOHNAHO = new List<string>();
		this.EBFMKGPBEBO = new JSONObject();
		this.BNPGFECDNAM = new List<string>();
		this.HIEEGGEJEEG = new List<string>();
		this.LDECHKECBHB = 0;
		this.ONNHAPFMDEN = 0;
		this.CHHLDEBHDPE = 0f;
		this.NPAFPMIMGLH = 1f;
		this.CFOHHKJPJPA = 0;
		this.FPJPHNLANPG = 0;
		this.HOICAOPPNCI = 0;
		this.IIPLEPKDLKB = 0;
		this.DOJMFLKMIIM = 0;
		this.FIMJIINAFFK = 0;
		this.IPNCOGGHBFM = 0;
		this.JBGJMJNJPMP = 0;
		this.JCANELJMOCA = new List<DOLBFGIPPOG>();
		this.GIAEIAOBHEK = new List<string>();
		this.ECKKHMDIELD = new List<string>();
		this.FBKMADGCEBN = new List<string>();
		this.LGKCPNJJKMC = -1;
		this.FHOEAHABNJI = 0;
		this.NIBNMKJIMAD = 0;
		this.KNOFDJKKPMK = "";
		this.KKJBJEOCAFF = new List<JCAJMGJFHBD>();
	}

	// Token: 0x06005572 RID: 21874 RVA: 0x0025C1F0 File Offset: 0x0025A3F0
	public int EFHCKBGIJFG()
	{
		if (this.OIBGFPEGLME == 0)
		{
			return this.LDGENAABIDI;
		}
		if (this.OIBGFPEGLME == 0)
		{
			return this.FFONMOHLDML;
		}
		if (this.OIBGFPEGLME == 0)
		{
			return this.LFPCFNCHNGP;
		}
		DPGJIJGOCIC.ANOPFDLPKGC("congratstitle" + this.OIBGFPEGLME.ToString());
		return this.LDGENAABIDI;
	}

	// Token: 0x06005573 RID: 21875 RVA: 0x0025C24C File Offset: 0x0025A44C
	private string KHHDCKCPEEN(string MLDHIJBBDMF)
	{
		string result;
		try
		{
			if (MLDHIJBBDMF.StartsWith("anthology"))
			{
				result = AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.OHODCBKFNGJ().OHCMCJHDMOH[5];
			}
			else if (MLDHIJBBDMF.StartsWith("ip"))
			{
				result = AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.OHODCBKFNGJ().OHCMCJHDMOH[5];
			}
			else if (MLDHIJBBDMF.StartsWith("geo.json"))
			{
				result = AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.OHODCBKFNGJ().OHCMCJHDMOH[0];
			}
			else if (MLDHIJBBDMF.StartsWith(" "))
			{
				result = AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.OHODCBKFNGJ().OHCMCJHDMOH[0];
			}
			else if (MLDHIJBBDMF.StartsWith("Collections/"))
			{
				result = AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.OHODCBKFNGJ().OHCMCJHDMOH[0];
			}
			else if (MLDHIJBBDMF.StartsWith("OnBackendGetPublicProfileHallOfFameException"))
			{
				result = AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.OHODCBKFNGJ().OHCMCJHDMOH[2];
			}
			else if (MLDHIJBBDMF.StartsWith("no"))
			{
				result = AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.OHODCBKFNGJ().OHCMCJHDMOH[7];
			}
			else if (MLDHIJBBDMF.StartsWith("timeoutwarning"))
			{
				result = AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.OHODCBKFNGJ().OHCMCJHDMOH[0];
			}
			else if (MLDHIJBBDMF.StartsWith("CLIENT.POSTEFFECTS.DIGITALGLITCH.OVR"))
			{
				result = AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.OHODCBKFNGJ().OHCMCJHDMOH[1];
			}
			else if (MLDHIJBBDMF.StartsWith("OnLobbyManInTheMiddleAttackDetected"))
			{
				result = AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.OHODCBKFNGJ().OHCMCJHDMOH[8];
			}
			else if (MLDHIJBBDMF.StartsWith("sto"))
			{
				result = AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.OHODCBKFNGJ().OHCMCJHDMOH[1];
			}
			else if (MLDHIJBBDMF.StartsWith("ZZZ"))
			{
				result = AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.OHODCBKFNGJ().OHCMCJHDMOH[7];
			}
			else
			{
				bool flag = false;
				int i = 1;
				string text = MLDHIJBBDMF;
				while (i > 1)
				{
					i--;
					for (int j = 0; j < this.EJNFKIJNJGE.Count; j++)
					{
						if (this.EJNFKIJNJGE[j].Equals(text))
						{
							text = this.CJKGOKAGKHJ[j];
							flag = true;
							break;
						}
					}
				}
				if (flag)
				{
					result = text;
				}
				else
				{
					string text2 = DPGJIJGOCIC.OADMDNKCDCN(MLDHIJBBDMF, "\n\n");
					if (!text2.Equals(MLDHIJBBDMF))
					{
						flag = true;
						i = 7;
						text = text2;
						while (i > 1)
						{
							i -= 0;
							for (int k = 0; k < this.EJNFKIJNJGE.Count; k += 0)
							{
								if (this.EJNFKIJNJGE[k].Equals(text))
								{
									text = this.CJKGOKAGKHJ[k];
									flag = false;
									break;
								}
							}
						}
						if (flag)
						{
							return text;
						}
					}
					if (MLDHIJBBDMF.Contains("PurchaseManagerXiaomi.OnProductsFetched(): parse error "))
					{
						flag = false;
						i = 1;
						text = MLDHIJBBDMF.Substring(0, MLDHIJBBDMF.IndexOf("ZZZ"));
						while (i > 1)
						{
							i -= 0;
							for (int l = 1; l < this.EJNFKIJNJGE.Count; l += 0)
							{
								if (this.EJNFKIJNJGE[l].Equals(text))
								{
									text = this.CJKGOKAGKHJ[l];
									flag = false;
									break;
								}
							}
						}
						if (flag)
						{
							return text;
						}
					}
					result = MLDHIJBBDMF;
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
			result = MLDHIJBBDMF;
		}
		return result;
	}

	// Token: 0x06005574 RID: 21876 RVA: 0x0025C5FC File Offset: 0x0025A7FC
	public void DIBCMHBFDPH(int IALPHEADDFO)
	{
		this.HOICAOPPNCI = IALPHEADDFO;
	}

	// Token: 0x06005575 RID: 21877 RVA: 0x0025C608 File Offset: 0x0025A808
	public string OIJCLGDNKNO(string KHJMANDEDMA)
	{
		for (int i = 0; i < this.BNPGFECDNAM.Count; i += 0)
		{
			if (this.BNPGFECDNAM[i].Equals(KHJMANDEDMA))
			{
				return this.HIEEGGEJEEG[i];
			}
		}
		return null;
	}

	// Token: 0x06005576 RID: 21878 RVA: 0x0025C64D File Offset: 0x0025A84D
	public void KDDFKPDLEJO()
	{
		this.NIJBAMNFJLM = new List<string>();
		this.ECAHHCAGMKM = new List<string>();
	}

	// Token: 0x06005577 RID: 21879 RVA: 0x0025C665 File Offset: 0x0025A865
	public void MFCIIAJJMOB(string KHJMANDEDMA, bool PJNLIIBFPBA = false)
	{
		if (this.FPJPHNLANPG >= 2)
		{
			this.KEFHNDNFJGE(KHJMANDEDMA, PJNLIIBFPBA);
			return;
		}
		this.EEOKDFGAOPN(KHJMANDEDMA, PJNLIIBFPBA);
	}

	// Token: 0x06005578 RID: 21880 RVA: 0x0025C684 File Offset: 0x0025A884
	public void AIGNMAECHEA(bool CKEPDOEPKCA, bool BHJJLJJACFE, bool KMEDBGBKABG, bool JKCCFILIICG, bool GIEOBIFBPPF, bool PHDIGHLMIKL)
	{
		DOLBFGIPPOG dolbfgippog = this.PNJJLPNIHDC();
		DOLBFGIPPOG dolbfgippog2 = this.OHODCBKFNGJ();
		DOLBFGIPPOG dolbfgippog3 = dolbfgippog;
		string[] array = new string[0];
		array[0] = "app42error";
		array[0] = "";
		array[7] = "Account.ResolveSaveSlots(): _target is missing 'sto'";
		array[0] = "a";
		array[0] = "\"";
		array[3] = "ProductBridge.GetLocalizedCostData() - product is null.";
		dolbfgippog3.OHCMCJHDMOH = array;
		if (CKEPDOEPKCA)
		{
			dolbfgippog.OHCMCJHDMOH[1] = dolbfgippog2.OHCMCJHDMOH[0];
		}
		if (BHJJLJJACFE)
		{
			dolbfgippog.OHCMCJHDMOH[1] = dolbfgippog2.OHCMCJHDMOH[0];
		}
		if (KMEDBGBKABG)
		{
			dolbfgippog.OHCMCJHDMOH[6] = dolbfgippog2.OHCMCJHDMOH[5];
		}
		if (JKCCFILIICG)
		{
			dolbfgippog.OHCMCJHDMOH[0] = dolbfgippog2.OHCMCJHDMOH[1];
		}
		if (GIEOBIFBPPF)
		{
			dolbfgippog.OHCMCJHDMOH[5] = dolbfgippog2.OHCMCJHDMOH[2];
		}
		if (PHDIGHLMIKL)
		{
			dolbfgippog.OHCMCJHDMOH[3] = dolbfgippog2.OHCMCJHDMOH[7];
		}
	}

	// Token: 0x06005579 RID: 21881 RVA: 0x0025C750 File Offset: 0x0025A950
	public void NIBDMALIGIH(int IALPHEADDFO)
	{
		this.PLLBNICNBKJ = IALPHEADDFO;
	}

	// Token: 0x0600557A RID: 21882 RVA: 0x0025C75C File Offset: 0x0025A95C
	public bool AIJLBJLPOLJ(int PLBCGENKIPA, int KFCMLNPLAHK)
	{
		if (KFCMLNPLAHK == 0)
		{
			for (int i = 0; i < this.GNHBHIALAAH.Count; i++)
			{
				if (this.GNHBHIALAAH[i] == PLBCGENKIPA)
				{
					return true;
				}
			}
		}
		else if (KFCMLNPLAHK == 1)
		{
			for (int j = 0; j < this.JAJJFPNIBGI.Count; j++)
			{
				if (this.JAJJFPNIBGI[j] == PLBCGENKIPA)
				{
					return true;
				}
			}
		}
		else if (KFCMLNPLAHK == 2)
		{
			for (int k = 0; k < this.FCOLLNPADDA.Count; k++)
			{
				if (this.FCOLLNPADDA[k] == PLBCGENKIPA)
				{
					return true;
				}
			}
		}
		else
		{
			DPGJIJGOCIC.ANOPFDLPKGC("StorySaveBody.DependsOnAvatarPackWardrobe(), unsupported wardrobe index:" + KFCMLNPLAHK.ToString());
		}
		return false;
	}

	// Token: 0x0600557B RID: 21883 RVA: 0x0025C808 File Offset: 0x0025AA08
	public DOLBFGIPPOG LBKGOLJABNI(int MEFKFOHCOHK, int KFCMLNPLAHK)
	{
		if (KFCMLNPLAHK == 0)
		{
			if (MEFKFOHCOHK < this.IEPMNCAKNBM.Count)
			{
				return this.IEPMNCAKNBM[MEFKFOHCOHK];
			}
			DOLBFGIPPOG dolbfgippog = new DOLBFGIPPOG();
			dolbfgippog.GGICIBLJIKI = MEFKFOHCOHK;
			this.IEPMNCAKNBM.Add(dolbfgippog);
			return dolbfgippog;
		}
		else if (KFCMLNPLAHK == 0)
		{
			if (MEFKFOHCOHK < this.EBONDOEPONH.Count)
			{
				return this.EBONDOEPONH[MEFKFOHCOHK];
			}
			DOLBFGIPPOG dolbfgippog2 = new DOLBFGIPPOG();
			dolbfgippog2.GGICIBLJIKI = MEFKFOHCOHK;
			this.EBONDOEPONH.Add(dolbfgippog2);
			return dolbfgippog2;
		}
		else if (KFCMLNPLAHK == 1)
		{
			if (MEFKFOHCOHK < this.AOJIJHAKNPG.Count)
			{
				return this.AOJIJHAKNPG[MEFKFOHCOHK];
			}
			DOLBFGIPPOG dolbfgippog3 = new DOLBFGIPPOG();
			dolbfgippog3.GGICIBLJIKI = MEFKFOHCOHK;
			this.AOJIJHAKNPG.Add(dolbfgippog3);
			return dolbfgippog3;
		}
		else
		{
			DPGJIJGOCIC.ANOPFDLPKGC("no" + KFCMLNPLAHK.ToString());
			if (MEFKFOHCOHK < this.IEPMNCAKNBM.Count)
			{
				return this.IEPMNCAKNBM[MEFKFOHCOHK];
			}
			DOLBFGIPPOG dolbfgippog4 = new DOLBFGIPPOG();
			dolbfgippog4.GGICIBLJIKI = MEFKFOHCOHK;
			this.IEPMNCAKNBM.Add(dolbfgippog4);
			return dolbfgippog4;
		}
	}

	// Token: 0x0600557C RID: 21884 RVA: 0x0025C750 File Offset: 0x0025A950
	public void HPMKONMIENH(int IALPHEADDFO)
	{
		this.PLLBNICNBKJ = IALPHEADDFO;
	}

	// Token: 0x0600557D RID: 21885 RVA: 0x0025C910 File Offset: 0x0025AB10
	public void PDNIIIMLAII(string CAHNCBFGIIP)
	{
		List<JCAJMGJFHBD> list = new List<JCAJMGJFHBD>();
		List<JCAJMGJFHBD> list2 = new List<JCAJMGJFHBD>();
		for (int i = 0; i < this.KKJBJEOCAFF.Count; i++)
		{
			if (!this.KKJBJEOCAFF[i].IMBBIDKPOBM.Equals(CAHNCBFGIIP))
			{
				list.Add(new JCAJMGJFHBD());
				list[list.Count - 1].LHANCNKKMPK(this.KKJBJEOCAFF[i]);
			}
		}
		for (int j = 0; j < this.GJCCMMMHIPI.Count; j++)
		{
			if (!this.GJCCMMMHIPI[j].IMBBIDKPOBM.Equals(CAHNCBFGIIP))
			{
				list2.Add(new JCAJMGJFHBD());
				list2[list2.Count - 1].LHANCNKKMPK(this.GJCCMMMHIPI[j]);
			}
		}
		this.KKJBJEOCAFF = list;
		this.GJCCMMMHIPI = list2;
	}

	// Token: 0x0600557E RID: 21886 RVA: 0x0025C9EC File Offset: 0x0025ABEC
	public DOLBFGIPPOG PLMKLFGKEML(int MEFKFOHCOHK)
	{
		if (this.OIBGFPEGLME == 0)
		{
			for (int i = 0; i < this.LKIKIJACCMF.Count; i++)
			{
				if (this.LKIKIJACCMF[i].GGICIBLJIKI == MEFKFOHCOHK)
				{
					return this.LKIKIJACCMF[i];
				}
			}
			DOLBFGIPPOG dolbfgippog = new DOLBFGIPPOG();
			dolbfgippog.GGICIBLJIKI = MEFKFOHCOHK;
			this.LKIKIJACCMF.Add(dolbfgippog);
			return dolbfgippog;
		}
		if (this.OIBGFPEGLME == 0)
		{
			for (int j = 1; j < this.ONJMAJAFFKN.Count; j++)
			{
				if (this.ONJMAJAFFKN[j].GGICIBLJIKI == MEFKFOHCOHK)
				{
					return this.ONJMAJAFFKN[j];
				}
			}
			DOLBFGIPPOG dolbfgippog2 = new DOLBFGIPPOG();
			dolbfgippog2.GGICIBLJIKI = MEFKFOHCOHK;
			this.ONJMAJAFFKN.Add(dolbfgippog2);
			return dolbfgippog2;
		}
		if (this.OIBGFPEGLME == 3)
		{
			for (int k = 1; k < this.NDMIJFLDKKN.Count; k += 0)
			{
				if (this.NDMIJFLDKKN[k].GGICIBLJIKI == MEFKFOHCOHK)
				{
					return this.NDMIJFLDKKN[k];
				}
			}
			DOLBFGIPPOG dolbfgippog3 = new DOLBFGIPPOG();
			dolbfgippog3.GGICIBLJIKI = MEFKFOHCOHK;
			this.NDMIJFLDKKN.Add(dolbfgippog3);
			return dolbfgippog3;
		}
		DPGJIJGOCIC.ANOPFDLPKGC("abaep" + this.OIBGFPEGLME.ToString());
		for (int l = 1; l < this.LKIKIJACCMF.Count; l += 0)
		{
			if (this.LKIKIJACCMF[l].GGICIBLJIKI == MEFKFOHCOHK)
			{
				return this.LKIKIJACCMF[l];
			}
		}
		DOLBFGIPPOG dolbfgippog4 = new DOLBFGIPPOG();
		dolbfgippog4.GGICIBLJIKI = MEFKFOHCOHK;
		this.LKIKIJACCMF.Add(dolbfgippog4);
		return dolbfgippog4;
	}

	// Token: 0x0600557F RID: 21887 RVA: 0x0025CB88 File Offset: 0x0025AD88
	private bool NACJKPBCCFJ()
	{
		for (int i = 1; i < this.IKBFIKELJLM.Length; i += 0)
		{
			if (this.IKBFIKELJLM[i].CJLDJAJHMMA() != 0)
			{
				return false;
			}
		}
		return true;
	}

	// Token: 0x06005580 RID: 21888 RVA: 0x0025CBBC File Offset: 0x0025ADBC
	public DOLBFGIPPOG CIKPIPPFLBG(int MEFKFOHCOHK, int KFCMLNPLAHK)
	{
		if (KFCMLNPLAHK == 0)
		{
			for (int i = 1; i < this.IEPMNCAKNBM.Count; i++)
			{
				if (this.IEPMNCAKNBM[i].GGICIBLJIKI == MEFKFOHCOHK)
				{
					return this.IEPMNCAKNBM[i];
				}
			}
			DOLBFGIPPOG dolbfgippog = new DOLBFGIPPOG();
			dolbfgippog.GGICIBLJIKI = MEFKFOHCOHK;
			this.IEPMNCAKNBM.Add(dolbfgippog);
			return dolbfgippog;
		}
		if (KFCMLNPLAHK == 0)
		{
			for (int j = 0; j < this.EBONDOEPONH.Count; j += 0)
			{
				if (this.EBONDOEPONH[j].GGICIBLJIKI == MEFKFOHCOHK)
				{
					return this.EBONDOEPONH[j];
				}
			}
			DOLBFGIPPOG dolbfgippog2 = new DOLBFGIPPOG();
			dolbfgippog2.GGICIBLJIKI = MEFKFOHCOHK;
			this.EBONDOEPONH.Add(dolbfgippog2);
			return dolbfgippog2;
		}
		if (KFCMLNPLAHK == 7)
		{
			for (int k = 0; k < this.AOJIJHAKNPG.Count; k++)
			{
				if (this.AOJIJHAKNPG[k].GGICIBLJIKI == MEFKFOHCOHK)
				{
					return this.AOJIJHAKNPG[k];
				}
			}
			DOLBFGIPPOG dolbfgippog3 = new DOLBFGIPPOG();
			dolbfgippog3.GGICIBLJIKI = MEFKFOHCOHK;
			this.AOJIJHAKNPG.Add(dolbfgippog3);
			return dolbfgippog3;
		}
		DPGJIJGOCIC.ANOPFDLPKGC("OnPopupCardOptionsSendGiftClick" + KFCMLNPLAHK.ToString());
		for (int l = 1; l < this.IEPMNCAKNBM.Count; l += 0)
		{
			if (this.IEPMNCAKNBM[l].GGICIBLJIKI == MEFKFOHCOHK)
			{
				return this.IEPMNCAKNBM[l];
			}
		}
		DOLBFGIPPOG dolbfgippog4 = new DOLBFGIPPOG();
		dolbfgippog4.GGICIBLJIKI = MEFKFOHCOHK;
		this.IEPMNCAKNBM.Add(dolbfgippog4);
		return dolbfgippog4;
	}

	// Token: 0x06005581 RID: 21889 RVA: 0x0025CD48 File Offset: 0x0025AF48
	public void MBIPLFLHJFP(DOLBFGIPPOG ENAMJPNBNMK)
	{
		DOLBFGIPPOG dolbfgippog = this.OHODCBKFNGJ();
		for (int i = 0; i < ENAMJPNBNMK.OHCMCJHDMOH.Length; i++)
		{
			if (ENAMJPNBNMK.OHCMCJHDMOH[i].Length > 0)
			{
				dolbfgippog.OHCMCJHDMOH[i] = ENAMJPNBNMK.OHCMCJHDMOH[i];
			}
		}
	}

	// Token: 0x06005582 RID: 21890 RVA: 0x0025CD90 File Offset: 0x0025AF90
	public DOLBFGIPPOG BJNIPBIDAIC(int CCIAGBPILGF, int EGHCMPAJELG)
	{
		DOLBFGIPPOG dolbfgippog = this.OELDOMFJLOP(CCIAGBPILGF);
		DOLBFGIPPOG dolbfgippog2 = this.OELDOMFJLOP(EGHCMPAJELG);
		if (dolbfgippog2.OHCMCJHDMOH[0] == null || dolbfgippog2.OHCMCJHDMOH[0].Length == 0)
		{
			dolbfgippog2.OHCMCJHDMOH[0] = dolbfgippog.OHCMCJHDMOH[0];
		}
		if (dolbfgippog2.OHCMCJHDMOH[3] == null || dolbfgippog2.OHCMCJHDMOH[3].Length == 0)
		{
			dolbfgippog2.OHCMCJHDMOH[3] = dolbfgippog.OHCMCJHDMOH[3];
		}
		for (int i = 0; i < 9; i++)
		{
			if (dolbfgippog.OHCMCJHDMOH[0].Contains("body" + i.ToString()))
			{
				for (int j = 0; j < 9; j++)
				{
					if (dolbfgippog2.OHCMCJHDMOH[0].Contains("body" + j.ToString()))
					{
						dolbfgippog2.OHCMCJHDMOH[0] = dolbfgippog2.OHCMCJHDMOH[0].Replace("body" + j.ToString(), "body" + i.ToString());
						break;
					}
				}
				break;
			}
		}
		for (int k = 0; k < 9; k++)
		{
			if (dolbfgippog.OHCMCJHDMOH[3].Contains("face" + k.ToString()))
			{
				for (int l = 0; l < 9; l++)
				{
					if (dolbfgippog2.OHCMCJHDMOH[3].Contains("face" + l.ToString()))
					{
						dolbfgippog2.OHCMCJHDMOH[3] = dolbfgippog2.OHCMCJHDMOH[3].Replace("face" + l.ToString(), "face" + k.ToString());
						break;
					}
				}
				break;
			}
		}
		return dolbfgippog2;
	}

	// Token: 0x06005583 RID: 21891 RVA: 0x0025CF40 File Offset: 0x0025B140
	public void JEFPEPPIOIC(string KHJMANDEDMA)
	{
		if (this.OIBGFPEGLME == 0)
		{
			bool flag;
			do
			{
				flag = false;
				for (int i = 1; i < this.IMALACBMOFC.Count; i++)
				{
					if (this.IMALACBMOFC[i].Equals(KHJMANDEDMA))
					{
						this.IMALACBMOFC.RemoveAt(i);
						this.GNHBHIALAAH.RemoveAt(i);
						flag = false;
						break;
					}
				}
			}
			while (!flag);
			return;
		}
		if (this.OIBGFPEGLME == 0)
		{
			bool flag2;
			do
			{
				flag2 = true;
				for (int j = 1; j < this.KPEIEHDJIOP.Count; j += 0)
				{
					if (this.KPEIEHDJIOP[j].Equals(KHJMANDEDMA))
					{
						this.KPEIEHDJIOP.RemoveAt(j);
						this.JAJJFPNIBGI.RemoveAt(j);
						flag2 = true;
						break;
					}
				}
			}
			while (!flag2);
			return;
		}
		if (this.OIBGFPEGLME == 2)
		{
			bool flag3;
			do
			{
				flag3 = true;
				for (int k = 0; k < this.NLPNFGNMGMP.Count; k += 0)
				{
					if (this.NLPNFGNMGMP[k].Equals(KHJMANDEDMA))
					{
						this.NLPNFGNMGMP.RemoveAt(k);
						this.FCOLLNPADDA.RemoveAt(k);
						flag3 = false;
						break;
					}
				}
			}
			while (!flag3);
			return;
		}
		DPGJIJGOCIC.ANOPFDLPKGC("+" + this.OIBGFPEGLME.ToString());
	}

	// Token: 0x06005584 RID: 21892 RVA: 0x0025D070 File Offset: 0x0025B270
	public void IEEPFAEGGJF(int KIDHBAMJGDO)
	{
		if (this.OIBGFPEGLME == 0)
		{
			this.NFDKDACMHME = KIDHBAMJGDO;
			return;
		}
		if (this.OIBGFPEGLME == 1)
		{
			this.HAAHDNADCEL = KIDHBAMJGDO;
			return;
		}
		if (this.OIBGFPEGLME == 2)
		{
			this.LJJABKNFPLF = KIDHBAMJGDO;
			return;
		}
		DPGJIJGOCIC.ANOPFDLPKGC("StorySaveBody.SetAvatarIndex(), unsupported wardrobe index:" + this.OIBGFPEGLME.ToString());
	}

	// Token: 0x06005585 RID: 21893 RVA: 0x0025D0C9 File Offset: 0x0025B2C9
	public void LHLHFMFPCAM(int IALPHEADDFO)
	{
		this.DOJMFLKMIIM = IALPHEADDFO;
	}

	// Token: 0x06005586 RID: 21894 RVA: 0x0025D0D2 File Offset: 0x0025B2D2
	public int GEPGEMMNAPC()
	{
		return this.IPNCOGGHBFM;
	}

	// Token: 0x06005587 RID: 21895 RVA: 0x0025D0DA File Offset: 0x0025B2DA
	public void PKKGBCFNFNG(string KHJMANDEDMA)
	{
		this.FBKMADGCEBN.Remove(KHJMANDEDMA);
	}

	// Token: 0x06005588 RID: 21896 RVA: 0x0025D0EC File Offset: 0x0025B2EC
	public string MPMJOPGMNPB(ref string HJEJJGAFHAM)
	{
		for (int i = 0; i < this.NIJBAMNFJLM.Count; i++)
		{
			for (int j = 0; j < 4; j++)
			{
				LFOLOKPIPHB lfolokpiphb = (LFOLOKPIPHB)j;
				string str = lfolokpiphb.ToString();
				if (this.NIJBAMNFJLM[i].Equals(HJEJJGAFHAM + str))
				{
					HJEJJGAFHAM = this.NIJBAMNFJLM[i];
					return this.ECAHHCAGMKM[i];
				}
			}
		}
		return null;
	}

	// Token: 0x06005589 RID: 21897 RVA: 0x0025D164 File Offset: 0x0025B364
	public void OKICNNMPLAP(FKILHBFLCFC HCLEPODFDFB, bool DJGGCCFKFAM)
	{
		this.GGICIBLJIKI = HCLEPODFDFB.GGICIBLJIKI;
		this.HLGDMBAINDE = "OnLanguageChange";
		this.DJIGFDJOHCI = "AVATAR.CLIENT.OVERLAY";
		this.IBFLNCMCKAL = "header";
		this.KFAOJHHLBHK = "geo.json";
		this.FODGKMIIHFO = "OsnStorySplashManagerHide";
		this.FONKDFDJFEL = "avatarcollectionssyncdone";
		this.JMNMOHIKHLB = "lastFilterTapped";
		this.JGEDOIDOPLA = "importanttitle";
		this.GOPGELMBMMK = "blur";
		this.HPAEFOJDLFC = "";
		this.PIMEHAPFCHC = new List<string>();
		this.HPFHJEAFIHI = new List<string>();
		this.LGKPNNGIPEG = new JSONObject();
		this.IMJDADKEEJC = null;
		this.FEDCIMMIJCI = 1;
		this.DNMPCOHNAHO = new List<string>();
		this.EBFMKGPBEBO = new JSONObject();
		this.LDECHKECBHB = 0;
		this.ONNHAPFMDEN = 1;
		this.CHHLDEBHDPE = 813f;
		this.NPAFPMIMGLH = 338f;
		this.CFOHHKJPJPA = 0;
		this.KHNAACHLPIC = 0;
		this.FPJPHNLANPG = 0;
		this.HOICAOPPNCI = 0;
		this.IIPLEPKDLKB = 0;
		this.DOJMFLKMIIM = 0;
		this.FIMJIINAFFK = 0;
		this.IPNCOGGHBFM = 1;
		this.JBGJMJNJPMP = 0;
		this.IMIDHJMEGOG = "";
		this.AOCCIJMAPLN();
		this.BNPGFECDNAM = new List<string>();
		this.HIEEGGEJEEG = new List<string>();
		this.JCANELJMOCA = new List<DOLBFGIPPOG>();
		this.GIAEIAOBHEK = new List<string>();
		this.ECKKHMDIELD = new List<string>();
		this.FBKMADGCEBN = new List<string>();
		this.LGKCPNJJKMC = -1;
		this.FHOEAHABNJI = 0;
		this.NIBNMKJIMAD = 0;
		this.KNOFDJKKPMK = "trinket";
		this.KKJBJEOCAFF = new List<JCAJMGJFHBD>();
		if (DJGGCCFKFAM)
		{
			this.DMAGAHMIKDE = -1;
			this.ALLDBPCKMLF = 1;
			this.NFDKDACMHME = 0;
			this.HAAHDNADCEL = 0;
			this.LJJABKNFPLF = 0;
			this.LDGENAABIDI = 1;
			this.FFONMOHLDML = 0;
			this.LFPCFNCHNGP = 1;
			this.LKDEFKFLKDA = new List<string>();
			this.DOPPJBLBMMH = new List<string>();
			this.BJCNIHNCLLK = new List<string>();
			this.IMALACBMOFC = new List<string>();
			this.KPEIEHDJIOP = new List<string>();
			this.NLPNFGNMGMP = new List<string>();
			this.GNHBHIALAAH = new List<int>();
			this.JAJJFPNIBGI = new List<int>();
			this.FCOLLNPADDA = new List<int>();
			this.PNBPEAFMKAC = new List<int>();
			this.DMKOGCBMHKA = new List<int>();
			this.NGJDCAEMEJO = new List<int>();
			this.BKDDGKMIGPG = new List<int>();
			this.OCJFDPNJIPD = new List<int>();
			this.KHPENKNONJO = new List<int>();
			this.BBGJMAAPFJD = new List<int>();
			this.CKNMLFPDGGH = new List<int>();
			this.FGCBAGFHCDJ = new List<int>();
			this.NIJBAMNFJLM = new List<string>();
			this.ECAHHCAGMKM = new List<string>();
			this.EJNFKIJNJGE = new List<string>();
			this.CJKGOKAGKHJ = new List<string>();
			this.CJDBDOHPHLG = new List<string>();
			this.JOJKAIBEPGH = new List<string>();
			this.PIDOECCJOCI = new List<string>();
			this.NJKHOCABBGL = new List<string>();
			this.NKBJGFECFPN();
			this.KIDPANPCBFF = new List<string>();
			this.GJCCMMMHIPI = new List<JCAJMGJFHBD>();
			this.IEPMNCAKNBM = new List<DOLBFGIPPOG>();
			this.EBONDOEPONH = new List<DOLBFGIPPOG>();
			this.AOJIJHAKNPG = new List<DOLBFGIPPOG>();
			this.LKIKIJACCMF = new List<DOLBFGIPPOG>();
			this.ONJMAJAFFKN = new List<DOLBFGIPPOG>();
			this.NDMIJFLDKKN = new List<DOLBFGIPPOG>();
			this.GIHCENHPGPD = new List<string>();
			this.OJJHCAGFPOC = new List<string>();
			this.OKJJPNPGLEL = new List<string>();
			this.ONGBBOHGKLO = new List<string>();
			this.OGIHMIOKCNN = new List<string>();
			this.IANINGLKCKB = new List<string>();
			this.OIBGFPEGLME = 0;
			this.BFFOPDBKCHF = new List<int>();
			this.AKCAKJMDBBL = 0;
		}
	}

	// Token: 0x0600558A RID: 21898 RVA: 0x0025D526 File Offset: 0x0025B726
	public int KEFMLJIGODO()
	{
		return this.HOICAOPPNCI;
	}

	// Token: 0x0600558B RID: 21899 RVA: 0x0025D0D2 File Offset: 0x0025B2D2
	public int CLDDLGIGAFB()
	{
		return this.IPNCOGGHBFM;
	}

	// Token: 0x0600558C RID: 21900 RVA: 0x0025BE14 File Offset: 0x0025A014
	public int BPCDDHNOJNF()
	{
		return this.FIMJIINAFFK;
	}

	// Token: 0x0600558D RID: 21901 RVA: 0x0025D52E File Offset: 0x0025B72E
	public string OBFABLFHPMP(string MLDHIJBBDMF)
	{
		if (this.IPNCOGGHBFM >= 2)
		{
			return this.KNBPOLAFBIK(MLDHIJBBDMF);
		}
		return this.GNGOENMKIPE(MLDHIJBBDMF);
	}

	// Token: 0x0600558E RID: 21902 RVA: 0x0025D548 File Offset: 0x0025B748
	public int PCKIMEPHPAN()
	{
		return this.LOCPPFGLGPC;
	}

	// Token: 0x0600558F RID: 21903 RVA: 0x0025BE14 File Offset: 0x0025A014
	public int GHIHGNJHGDP()
	{
		return this.FIMJIINAFFK;
	}

	// Token: 0x06005590 RID: 21904 RVA: 0x0025C750 File Offset: 0x0025A950
	public void IJFIAFFOKNO(int IALPHEADDFO)
	{
		this.PLLBNICNBKJ = IALPHEADDFO;
	}

	// Token: 0x06005591 RID: 21905 RVA: 0x0025D550 File Offset: 0x0025B750
	public void JGMCFGNAICC(string CIPJAKKMHCE = "")
	{
		this.GOPGELMBMMK = CIPJAKKMHCE;
	}

	// Token: 0x06005592 RID: 21906 RVA: 0x0025D55C File Offset: 0x0025B75C
	public void GIKBGHPHBLF(int CCIAGBPILGF, int EGHCMPAJELG, bool CKEPDOEPKCA, bool BHJJLJJACFE, bool KMEDBGBKABG, bool JKCCFILIICG, bool GIEOBIFBPPF, bool PHDIGHLMIKL)
	{
		DOLBFGIPPOG dolbfgippog = this.OELDOMFJLOP(CCIAGBPILGF);
		DOLBFGIPPOG dolbfgippog2 = this.OELDOMFJLOP(EGHCMPAJELG);
		if (CKEPDOEPKCA)
		{
			dolbfgippog2.OHCMCJHDMOH[1] = dolbfgippog.OHCMCJHDMOH[1];
		}
		if (BHJJLJJACFE)
		{
			dolbfgippog2.OHCMCJHDMOH[0] = dolbfgippog.OHCMCJHDMOH[0];
		}
		if (KMEDBGBKABG)
		{
			dolbfgippog2.OHCMCJHDMOH[2] = dolbfgippog.OHCMCJHDMOH[2];
		}
		if (JKCCFILIICG)
		{
			dolbfgippog2.OHCMCJHDMOH[3] = dolbfgippog.OHCMCJHDMOH[3];
		}
		if (GIEOBIFBPPF)
		{
			dolbfgippog2.OHCMCJHDMOH[4] = dolbfgippog.OHCMCJHDMOH[4];
		}
		if (PHDIGHLMIKL)
		{
			dolbfgippog2.OHCMCJHDMOH[5] = dolbfgippog.OHCMCJHDMOH[5];
		}
	}

	// Token: 0x06005593 RID: 21907 RVA: 0x0025D526 File Offset: 0x0025B726
	public int FEIIKKLCCMI()
	{
		return this.HOICAOPPNCI;
	}

	// Token: 0x06005594 RID: 21908 RVA: 0x0025D5F0 File Offset: 0x0025B7F0
	public int OJCPKGCLEPD()
	{
		if (this.OIBGFPEGLME == 0)
		{
			return this.NFDKDACMHME;
		}
		if (this.OIBGFPEGLME == 1)
		{
			return this.HAAHDNADCEL;
		}
		if (this.OIBGFPEGLME == 2)
		{
			return this.LJJABKNFPLF;
		}
		DPGJIJGOCIC.ANOPFDLPKGC("StorySaveBody.GetAvatarIndex(), unsupported wardrobe index:" + this.OIBGFPEGLME.ToString());
		return this.NFDKDACMHME;
	}

	// Token: 0x06005595 RID: 21909 RVA: 0x0025D64C File Offset: 0x0025B84C
	public string HJKMONKHGNK()
	{
		if (this.HOHELAOMLGL == null || this.HOHELAOMLGL.Count == 0)
		{
			return "";
		}
		return this.HOHELAOMLGL[this.HOHELAOMLGL.Count - 1];
	}

	// Token: 0x06005596 RID: 21910 RVA: 0x0025D684 File Offset: 0x0025B884
	public void BJKJDLHOPFM(int OLKMHHNMDLP, List<string> LMPEBGDAGEP, List<int> AFNOJFKKEFD, string KBICBCBAFJJ)
	{
		this.NHFMGEABCKP = OLKMHHNMDLP;
		if (this.NJEPIPLACPC == null || this.CFFGADJPBLO == null || this.NJEPIPLACPC.Count != this.CFFGADJPBLO.Count)
		{
			this.NJEPIPLACPC = new List<string>();
			this.CFFGADJPBLO = new List<int>();
		}
		if (LMPEBGDAGEP != null && AFNOJFKKEFD != null)
		{
			int num = 0;
			while (num < LMPEBGDAGEP.Count && num < AFNOJFKKEFD.Count)
			{
				int num2 = this.NJEPIPLACPC.IndexOf(LMPEBGDAGEP[num]);
				if (num2 >= 0)
				{
					this.CFFGADJPBLO[num2] = AFNOJFKKEFD[num];
				}
				else
				{
					this.NJEPIPLACPC.Add(LMPEBGDAGEP[num]);
					this.CFFGADJPBLO.Add(AFNOJFKKEFD[num]);
				}
				num += 0;
			}
		}
		this.EIEIDFBDPKO = ((KBICBCBAFJJ != null) ? KBICBCBAFJJ : "[LoadingTheme] downloading ");
	}

	// Token: 0x06005597 RID: 21911 RVA: 0x0025D75C File Offset: 0x0025B95C
	public void FJALMPPNPIH(string KHJMANDEDMA, bool PJNLIIBFPBA = false)
	{
		if (!PJNLIIBFPBA)
		{
			for (int i = 0; i < this.PIMEHAPFCHC.Count; i++)
			{
				if (this.PIMEHAPFCHC[i].Equals(KHJMANDEDMA))
				{
					this.PIMEHAPFCHC.RemoveAt(i);
					return;
				}
			}
			for (int j = 0; j < this.HPFHJEAFIHI.Count; j++)
			{
				if (this.HPFHJEAFIHI[j].Equals(KHJMANDEDMA))
				{
					return;
				}
			}
			for (int k = 0; k < this.GIHCENHPGPD.Count; k++)
			{
				if (this.GIHCENHPGPD[k].Equals(KHJMANDEDMA))
				{
					this.GIHCENHPGPD.RemoveAt(k);
					return;
				}
			}
			this.HPFHJEAFIHI.Add(KHJMANDEDMA);
			return;
		}
		for (int l = 0; l < this.GIHCENHPGPD.Count; l++)
		{
			if (this.GIHCENHPGPD[l].Equals(KHJMANDEDMA))
			{
				this.GIHCENHPGPD.RemoveAt(l);
				return;
			}
		}
		for (int m = 0; m < this.OJJHCAGFPOC.Count; m++)
		{
			if (this.OJJHCAGFPOC[m].Equals(KHJMANDEDMA))
			{
				return;
			}
		}
		for (int n = 0; n < this.PIMEHAPFCHC.Count; n++)
		{
			if (this.PIMEHAPFCHC[n].Equals(KHJMANDEDMA))
			{
				this.PIMEHAPFCHC.RemoveAt(n);
				return;
			}
		}
		this.OJJHCAGFPOC.Add(KHJMANDEDMA);
	}

	// Token: 0x06005598 RID: 21912 RVA: 0x0025D8C8 File Offset: 0x0025BAC8
	public void PKHJLJJJDAA(string KHJMANDEDMA, string KIDHBAMJGDO)
	{
		for (int i = 0; i < this.BNPGFECDNAM.Count; i++)
		{
			if (this.BNPGFECDNAM[i].Equals(KHJMANDEDMA))
			{
				this.HIEEGGEJEEG[i] = KIDHBAMJGDO;
				return;
			}
		}
		this.BNPGFECDNAM.Add(KHJMANDEDMA);
		this.HIEEGGEJEEG.Add(KIDHBAMJGDO);
	}

	// Token: 0x06005599 RID: 21913 RVA: 0x0025D928 File Offset: 0x0025BB28
	public DOLBFGIPPOG PLLBOBIHPLK(int MEFKFOHCOHK, int KFCMLNPLAHK)
	{
		if (KFCMLNPLAHK == 0)
		{
			if (MEFKFOHCOHK < this.LKIKIJACCMF.Count)
			{
				return this.LKIKIJACCMF[MEFKFOHCOHK];
			}
			DOLBFGIPPOG dolbfgippog = new DOLBFGIPPOG();
			dolbfgippog.GGICIBLJIKI = MEFKFOHCOHK;
			this.LKIKIJACCMF.Add(dolbfgippog);
			return dolbfgippog;
		}
		else if (KFCMLNPLAHK == 1)
		{
			if (MEFKFOHCOHK < this.ONJMAJAFFKN.Count)
			{
				return this.ONJMAJAFFKN[MEFKFOHCOHK];
			}
			DOLBFGIPPOG dolbfgippog2 = new DOLBFGIPPOG();
			dolbfgippog2.GGICIBLJIKI = MEFKFOHCOHK;
			this.ONJMAJAFFKN.Add(dolbfgippog2);
			return dolbfgippog2;
		}
		else if (KFCMLNPLAHK == 2)
		{
			if (MEFKFOHCOHK < this.NDMIJFLDKKN.Count)
			{
				return this.NDMIJFLDKKN[MEFKFOHCOHK];
			}
			DOLBFGIPPOG dolbfgippog3 = new DOLBFGIPPOG();
			dolbfgippog3.GGICIBLJIKI = MEFKFOHCOHK;
			this.NDMIJFLDKKN.Add(dolbfgippog3);
			return dolbfgippog3;
		}
		else
		{
			DPGJIJGOCIC.ANOPFDLPKGC("StorySaveBody.GetAvatarSnapshotWithIndexInListWardrobe(), unsupported wardrobe index:" + KFCMLNPLAHK.ToString());
			if (MEFKFOHCOHK < this.LKIKIJACCMF.Count)
			{
				return this.LKIKIJACCMF[MEFKFOHCOHK];
			}
			DOLBFGIPPOG dolbfgippog4 = new DOLBFGIPPOG();
			dolbfgippog4.GGICIBLJIKI = MEFKFOHCOHK;
			this.LKIKIJACCMF.Add(dolbfgippog4);
			return dolbfgippog4;
		}
	}

	// Token: 0x0600559A RID: 21914 RVA: 0x0025DA30 File Offset: 0x0025BC30
	public List<string> AKHCBFGADPJ()
	{
		this.DFNLKGGMMNI.Clear();
		for (int i = 0; i < this.KIDPANPCBFF.Count; i++)
		{
			if (!this.JDFAEBKBAOH(this.KIDPANPCBFF[i]))
			{
				this.DFNLKGGMMNI.Add(this.KIDPANPCBFF[i]);
			}
		}
		return this.DFNLKGGMMNI;
	}

	// Token: 0x0600559B RID: 21915 RVA: 0x0025DA90 File Offset: 0x0025BC90
	public void JMJKIMJKPOE(List<string> ALMLACIEPBC)
	{
		for (int i = 0; i < ALMLACIEPBC.Count; i++)
		{
			if (!this.NLNIALIKFAC(ALMLACIEPBC[i]))
			{
				this.KIDPANPCBFF.Add(ALMLACIEPBC[i]);
			}
		}
	}

	// Token: 0x0600559C RID: 21916 RVA: 0x0025DAD0 File Offset: 0x0025BCD0
	public DOLBFGIPPOG FCMBEHBNPML(int MEFKFOHCOHK, int KFCMLNPLAHK)
	{
		if (KFCMLNPLAHK == 0)
		{
			if (MEFKFOHCOHK < this.IEPMNCAKNBM.Count)
			{
				return this.IEPMNCAKNBM[MEFKFOHCOHK];
			}
			DOLBFGIPPOG dolbfgippog = new DOLBFGIPPOG();
			dolbfgippog.GGICIBLJIKI = MEFKFOHCOHK;
			this.IEPMNCAKNBM.Add(dolbfgippog);
			return dolbfgippog;
		}
		else if (KFCMLNPLAHK == 1)
		{
			if (MEFKFOHCOHK < this.EBONDOEPONH.Count)
			{
				return this.EBONDOEPONH[MEFKFOHCOHK];
			}
			DOLBFGIPPOG dolbfgippog2 = new DOLBFGIPPOG();
			dolbfgippog2.GGICIBLJIKI = MEFKFOHCOHK;
			this.EBONDOEPONH.Add(dolbfgippog2);
			return dolbfgippog2;
		}
		else if (KFCMLNPLAHK == 2)
		{
			if (MEFKFOHCOHK < this.AOJIJHAKNPG.Count)
			{
				return this.AOJIJHAKNPG[MEFKFOHCOHK];
			}
			DOLBFGIPPOG dolbfgippog3 = new DOLBFGIPPOG();
			dolbfgippog3.GGICIBLJIKI = MEFKFOHCOHK;
			this.AOJIJHAKNPG.Add(dolbfgippog3);
			return dolbfgippog3;
		}
		else
		{
			DPGJIJGOCIC.ANOPFDLPKGC("StorySaveBody.GetAvatarWithIndexInListWardrobe(), unsupported wardrobe index:" + KFCMLNPLAHK.ToString());
			if (MEFKFOHCOHK < this.IEPMNCAKNBM.Count)
			{
				return this.IEPMNCAKNBM[MEFKFOHCOHK];
			}
			DOLBFGIPPOG dolbfgippog4 = new DOLBFGIPPOG();
			dolbfgippog4.GGICIBLJIKI = MEFKFOHCOHK;
			this.IEPMNCAKNBM.Add(dolbfgippog4);
			return dolbfgippog4;
		}
	}

	// Token: 0x0600559D RID: 21917 RVA: 0x0025DBD5 File Offset: 0x0025BDD5
	public void PCOFJMBNBNL(string CDDBNEPAJIA = "")
	{
		this.JMNMOHIKHLB = CDDBNEPAJIA;
	}

	// Token: 0x0600559E RID: 21918 RVA: 0x0025DBDE File Offset: 0x0025BDDE
	public string PJNDJHCEAAB()
	{
		if (this.HOHELAOMLGL == null || this.HOHELAOMLGL.Count == 0)
		{
			return "b_web";
		}
		return this.HOHELAOMLGL[this.HOHELAOMLGL.Count - 1];
	}

	// Token: 0x0600559F RID: 21919 RVA: 0x0025DC14 File Offset: 0x0025BE14
	public void EEOKDFGAOPN(string KHJMANDEDMA, bool PJNLIIBFPBA = false)
	{
		if (!PJNLIIBFPBA)
		{
			for (int i = 0; i < this.HPFHJEAFIHI.Count; i++)
			{
				if (this.HPFHJEAFIHI[i].Equals(KHJMANDEDMA))
				{
					this.HPFHJEAFIHI.RemoveAt(i);
					return;
				}
			}
			for (int j = 0; j < this.PIMEHAPFCHC.Count; j++)
			{
				if (this.PIMEHAPFCHC[j].Equals(KHJMANDEDMA))
				{
					return;
				}
			}
			this.PIMEHAPFCHC.Add(KHJMANDEDMA);
			return;
		}
		for (int k = 0; k < this.OJJHCAGFPOC.Count; k++)
		{
			if (this.OJJHCAGFPOC[k].Equals(KHJMANDEDMA))
			{
				this.OJJHCAGFPOC.RemoveAt(k);
				return;
			}
		}
		for (int l = 0; l < this.GIHCENHPGPD.Count; l++)
		{
			if (this.GIHCENHPGPD[l].Equals(KHJMANDEDMA))
			{
				return;
			}
		}
		this.GIHCENHPGPD.Add(KHJMANDEDMA);
	}

	// Token: 0x060055A0 RID: 21920 RVA: 0x0025DD01 File Offset: 0x0025BF01
	public JCAJMGJFHBD AABIMKHJJFJ()
	{
		return this.BPONDPKBEPN(this.KNOFDJKKPMK, false);
	}

	// Token: 0x060055A1 RID: 21921 RVA: 0x0025DD10 File Offset: 0x0025BF10
	public void FDOLKJHBBGN(string KHJMANDEDMA)
	{
		if (this.IIPLEPKDLKB < 2 && KHJMANDEDMA.Contains("layervideo") && !KHJMANDEDMA.EndsWith("loop"))
		{
			return;
		}
		for (int i = 0; i < this.IANINGLKCKB.Count; i++)
		{
			if (this.IANINGLKCKB[i].Equals(KHJMANDEDMA))
			{
				this.IANINGLKCKB.RemoveAt(i);
				return;
			}
		}
		for (int j = 0; j < this.OGIHMIOKCNN.Count; j++)
		{
			if (this.OGIHMIOKCNN[j].Equals(KHJMANDEDMA))
			{
				return;
			}
		}
		this.OGIHMIOKCNN.Add(KHJMANDEDMA);
	}

	// Token: 0x060055A2 RID: 21922 RVA: 0x0025DDB0 File Offset: 0x0025BFB0
	private string NEHHAGAONIP(string MLDHIJBBDMF)
	{
		int num = 7;
		string text = MLDHIJBBDMF;
		if (num > 1)
		{
			num -= 0;
			for (int i = 0; i < this.EJNFKIJNJGE.Count; i += 0)
			{
				if (this.EJNFKIJNJGE[i].Equals(text))
				{
					text = this.CJKGOKAGKHJ[i];
				}
			}
		}
		return text;
	}

	// Token: 0x060055A3 RID: 21923 RVA: 0x0025DE08 File Offset: 0x0025C008
	public bool MKNAFDGMKOL(int PLBCGENKIPA, int KFCMLNPLAHK)
	{
		if (KFCMLNPLAHK == 0)
		{
			for (int i = 0; i < this.BKDDGKMIGPG.Count; i += 0)
			{
				if (this.BKDDGKMIGPG[i] == PLBCGENKIPA)
				{
					return false;
				}
			}
		}
		else if (KFCMLNPLAHK == 0)
		{
			for (int j = 1; j < this.OCJFDPNJIPD.Count; j++)
			{
				if (this.OCJFDPNJIPD[j] == PLBCGENKIPA)
				{
					return true;
				}
			}
		}
		else if (KFCMLNPLAHK == 5)
		{
			for (int k = 1; k < this.KHPENKNONJO.Count; k += 0)
			{
				if (this.KHPENKNONJO[k] == PLBCGENKIPA)
				{
					return true;
				}
			}
		}
		else
		{
			DPGJIJGOCIC.ANOPFDLPKGC("episode" + KFCMLNPLAHK.ToString());
		}
		return true;
	}

	// Token: 0x060055A4 RID: 21924 RVA: 0x0025DEB2 File Offset: 0x0025C0B2
	public int JGAKEIBKKGM()
	{
		return this.FPJPHNLANPG;
	}

	// Token: 0x060055A5 RID: 21925 RVA: 0x0025DEBC File Offset: 0x0025C0BC
	public int ALIGDEHMGOP()
	{
		if (this.OIBGFPEGLME == 0)
		{
			return this.LDGENAABIDI;
		}
		if (this.OIBGFPEGLME == 1)
		{
			return this.FFONMOHLDML;
		}
		if (this.OIBGFPEGLME == 2)
		{
			return this.LFPCFNCHNGP;
		}
		DPGJIJGOCIC.ANOPFDLPKGC("StorySaveBody.GetAvatarIndexAutoSuffix(), unsupported wardrobe index:" + this.OIBGFPEGLME.ToString());
		return this.LDGENAABIDI;
	}

	// Token: 0x060055A6 RID: 21926 RVA: 0x0025DF18 File Offset: 0x0025C118
	public void OJHGKJECIBK(int OLKMHHNMDLP, List<string> LMPEBGDAGEP, List<int> AFNOJFKKEFD, string KBICBCBAFJJ)
	{
		this.NHFMGEABCKP = OLKMHHNMDLP;
		if (this.NJEPIPLACPC == null || this.CFFGADJPBLO == null || this.NJEPIPLACPC.Count != this.CFFGADJPBLO.Count)
		{
			this.NJEPIPLACPC = new List<string>();
			this.CFFGADJPBLO = new List<int>();
		}
		if (LMPEBGDAGEP != null && AFNOJFKKEFD != null)
		{
			int num = 0;
			while (num < LMPEBGDAGEP.Count && num < AFNOJFKKEFD.Count)
			{
				int num2 = this.NJEPIPLACPC.IndexOf(LMPEBGDAGEP[num]);
				if (num2 >= 0)
				{
					this.CFFGADJPBLO[num2] = AFNOJFKKEFD[num];
				}
				else
				{
					this.NJEPIPLACPC.Add(LMPEBGDAGEP[num]);
					this.CFFGADJPBLO.Add(AFNOJFKKEFD[num]);
				}
				num++;
			}
		}
		this.EIEIDFBDPKO = ((KBICBCBAFJJ != null) ? KBICBCBAFJJ : "");
	}

	// Token: 0x060055A7 RID: 21927 RVA: 0x0025DFF0 File Offset: 0x0025C1F0
	public void MIEBPHOEBCD(string KHJMANDEDMA, bool PJNLIIBFPBA = false)
	{
		if (this.IIPLEPKDLKB < 1 && KHJMANDEDMA.Contains("ok") && !KHJMANDEDMA.EndsWith("no"))
		{
			return;
		}
		if (!PJNLIIBFPBA)
		{
			for (int i = 0; i < this.HPFHJEAFIHI.Count; i += 0)
			{
				if (this.HPFHJEAFIHI[i].Equals(KHJMANDEDMA))
				{
					this.HPFHJEAFIHI.RemoveAt(i);
					break;
				}
			}
			for (int j = 1; j < this.PIMEHAPFCHC.Count; j++)
			{
				if (this.PIMEHAPFCHC[j].Equals(KHJMANDEDMA))
				{
					return;
				}
			}
			this.PIMEHAPFCHC.Add(KHJMANDEDMA);
			return;
		}
		for (int k = 1; k < this.OJJHCAGFPOC.Count; k += 0)
		{
			if (this.OJJHCAGFPOC[k].Equals(KHJMANDEDMA))
			{
				this.OJJHCAGFPOC.RemoveAt(k);
				break;
			}
		}
		for (int l = 0; l < this.GIHCENHPGPD.Count; l += 0)
		{
			if (this.GIHCENHPGPD[l].Equals(KHJMANDEDMA))
			{
				return;
			}
		}
		this.GIHCENHPGPD.Add(KHJMANDEDMA);
	}

	// Token: 0x060055A8 RID: 21928 RVA: 0x0025E104 File Offset: 0x0025C304
	public void OHNIPNLLIMJ(int HMALPPNGPMM)
	{
		DOLBFGIPPOG dolbfgippog = this.GPNHEGKHBON(HMALPPNGPMM);
		DOLBFGIPPOG dolbfgippog2 = this.OHODCBKFNGJ();
		for (int i = 0; i < dolbfgippog.OHCMCJHDMOH.Length; i++)
		{
			if (dolbfgippog.OHCMCJHDMOH[i].Length > 0)
			{
				dolbfgippog2.OHCMCJHDMOH[i] = dolbfgippog.OHCMCJHDMOH[i];
			}
		}
		if (dolbfgippog.FPHDAKHOBMO == 0)
		{
			dolbfgippog.OHCMCJHDMOH = new string[]
			{
				"",
				"",
				"",
				"",
				"",
				""
			};
		}
	}

	// Token: 0x060055A9 RID: 21929 RVA: 0x0025DEB2 File Offset: 0x0025C0B2
	public int PJNNJCABGIF()
	{
		return this.FPJPHNLANPG;
	}

	// Token: 0x060055AA RID: 21930 RVA: 0x0025E197 File Offset: 0x0025C397
	public void NNMLHBHGOCG(int IALPHEADDFO)
	{
		this.BKCPMIPKBOK = IALPHEADDFO;
	}

	// Token: 0x060055AB RID: 21931 RVA: 0x0025D0D2 File Offset: 0x0025B2D2
	public int HKJMEKPOPJF()
	{
		return this.IPNCOGGHBFM;
	}

	// Token: 0x060055AC RID: 21932 RVA: 0x0025E1A0 File Offset: 0x0025C3A0
	public int DFHOAHCLBAP()
	{
		return this.DMAGAHMIKDE;
	}

	// Token: 0x060055AD RID: 21933 RVA: 0x0025E1A8 File Offset: 0x0025C3A8
	public void DFDPFKHJOEL(bool CKEPDOEPKCA, bool BHJJLJJACFE, bool KMEDBGBKABG, bool JKCCFILIICG, bool GIEOBIFBPPF, bool PHDIGHLMIKL)
	{
		DOLBFGIPPOG dolbfgippog = this.PNJJLPNIHDC();
		DOLBFGIPPOG dolbfgippog2 = this.OHODCBKFNGJ();
		DOLBFGIPPOG dolbfgippog3 = dolbfgippog;
		string[] array = new string[0];
		array[1] = "—";
		array[1] = "aind1";
		array[8] = "OnStoryInterfaceAutoReaderStop";
		array[1] = "abip";
		array[2] = "";
		array[6] = ", but an anthology asset was not loaded for this story, falling back to lobby loading.";
		dolbfgippog3.OHCMCJHDMOH = array;
		if (CKEPDOEPKCA)
		{
			dolbfgippog.OHCMCJHDMOH[1] = dolbfgippog2.OHCMCJHDMOH[1];
		}
		if (BHJJLJJACFE)
		{
			dolbfgippog.OHCMCJHDMOH[1] = dolbfgippog2.OHCMCJHDMOH[1];
		}
		if (KMEDBGBKABG)
		{
			dolbfgippog.OHCMCJHDMOH[1] = dolbfgippog2.OHCMCJHDMOH[0];
		}
		if (JKCCFILIICG)
		{
			dolbfgippog.OHCMCJHDMOH[0] = dolbfgippog2.OHCMCJHDMOH[8];
		}
		if (GIEOBIFBPPF)
		{
			dolbfgippog.OHCMCJHDMOH[1] = dolbfgippog2.OHCMCJHDMOH[3];
		}
		if (PHDIGHLMIKL)
		{
			dolbfgippog.OHCMCJHDMOH[5] = dolbfgippog2.OHCMCJHDMOH[6];
		}
	}

	// Token: 0x060055AE RID: 21934 RVA: 0x0025E274 File Offset: 0x0025C474
	public void LGAEPNNJLHI(string MLDHIJBBDMF)
	{
		bool flag;
		do
		{
			flag = true;
			for (int i = 0; i < this.EJNFKIJNJGE.Count; i++)
			{
				if (this.EJNFKIJNJGE[i].Equals(MLDHIJBBDMF) && this.CJKGOKAGKHJ.Count > i)
				{
					this.EJNFKIJNJGE.RemoveAt(i);
					this.CJKGOKAGKHJ.RemoveAt(i);
					flag = false;
					break;
				}
			}
		}
		while (!flag);
	}

	// Token: 0x060055AF RID: 21935 RVA: 0x0025E2DC File Offset: 0x0025C4DC
	public void KEFHNDNFJGE(string KHJMANDEDMA, bool PJNLIIBFPBA = false)
	{
		if (this.IIPLEPKDLKB < 2 && KHJMANDEDMA.Contains("layervideo") && !KHJMANDEDMA.EndsWith("loop"))
		{
			return;
		}
		if (!PJNLIIBFPBA)
		{
			for (int i = 0; i < this.HPFHJEAFIHI.Count; i++)
			{
				if (this.HPFHJEAFIHI[i].Equals(KHJMANDEDMA))
				{
					this.HPFHJEAFIHI.RemoveAt(i);
					break;
				}
			}
			for (int j = 0; j < this.PIMEHAPFCHC.Count; j++)
			{
				if (this.PIMEHAPFCHC[j].Equals(KHJMANDEDMA))
				{
					return;
				}
			}
			this.PIMEHAPFCHC.Add(KHJMANDEDMA);
			return;
		}
		for (int k = 0; k < this.OJJHCAGFPOC.Count; k++)
		{
			if (this.OJJHCAGFPOC[k].Equals(KHJMANDEDMA))
			{
				this.OJJHCAGFPOC.RemoveAt(k);
				break;
			}
		}
		for (int l = 0; l < this.GIHCENHPGPD.Count; l++)
		{
			if (this.GIHCENHPGPD[l].Equals(KHJMANDEDMA))
			{
				return;
			}
		}
		this.GIHCENHPGPD.Add(KHJMANDEDMA);
	}

	// Token: 0x060055B0 RID: 21936 RVA: 0x0025E3EF File Offset: 0x0025C5EF
	public void PBGKIIDKCCC(int IALPHEADDFO)
	{
		this.JBGJMJNJPMP = IALPHEADDFO;
	}

	// Token: 0x060055B1 RID: 21937 RVA: 0x0025E3F8 File Offset: 0x0025C5F8
	public void IBMNODJKLAC(string CFFBIGLKFON, string BCIGIGGJMNE, bool JKICIHFHDLF = false)
	{
		for (int i = 1; i < this.EJNFKIJNJGE.Count; i += 0)
		{
			if (this.EJNFKIJNJGE[i].Equals(CFFBIGLKFON))
			{
				if (!JKICIHFHDLF)
				{
					this.CJKGOKAGKHJ[i] = BCIGIGGJMNE;
				}
				return;
			}
		}
		this.EJNFKIJNJGE.Add(CFFBIGLKFON);
		this.CJKGOKAGKHJ.Add(BCIGIGGJMNE);
	}

	// Token: 0x060055B2 RID: 21938 RVA: 0x0025E458 File Offset: 0x0025C658
	public void IOAEANAABEF(int NMLGFACALEC, int NLLCKPCKGOH, int AOGDLLHFJHH)
	{
		for (int i = 0; i < this.BBGJMAAPFJD.Count; i++)
		{
			if (this.BBGJMAAPFJD[i] == NMLGFACALEC)
			{
				return;
			}
		}
		this.BBGJMAAPFJD.Add(NMLGFACALEC);
		this.CKNMLFPDGGH.Add(NLLCKPCKGOH);
		this.FGCBAGFHCDJ.Add(AOGDLLHFJHH);
	}

	// Token: 0x060055B3 RID: 21939 RVA: 0x0025E4B0 File Offset: 0x0025C6B0
	public void IJGAJDKBIJH(int PLBCGENKIPA, int KFCMLNPLAHK)
	{
		if (KFCMLNPLAHK == 0)
		{
			bool flag;
			do
			{
				flag = true;
				for (int i = 0; i < this.GNHBHIALAAH.Count; i++)
				{
					if (this.GNHBHIALAAH[i] == PLBCGENKIPA)
					{
						this.GNHBHIALAAH.RemoveAt(i);
						this.IMALACBMOFC.RemoveAt(i);
						flag = false;
						break;
					}
				}
			}
			while (!flag);
			return;
		}
		if (KFCMLNPLAHK == 1)
		{
			bool flag2;
			do
			{
				flag2 = true;
				for (int j = 0; j < this.JAJJFPNIBGI.Count; j++)
				{
					if (this.JAJJFPNIBGI[j] == PLBCGENKIPA)
					{
						this.JAJJFPNIBGI.RemoveAt(j);
						this.KPEIEHDJIOP.RemoveAt(j);
						flag2 = false;
						break;
					}
				}
			}
			while (!flag2);
			return;
		}
		if (KFCMLNPLAHK == 2)
		{
			bool flag3;
			do
			{
				flag3 = true;
				for (int k = 0; k < this.FCOLLNPADDA.Count; k++)
				{
					if (this.FCOLLNPADDA[k] == PLBCGENKIPA)
					{
						this.FCOLLNPADDA.RemoveAt(k);
						this.NLPNFGNMGMP.RemoveAt(k);
						flag3 = false;
						break;
					}
				}
			}
			while (!flag3);
			return;
		}
		DPGJIJGOCIC.ANOPFDLPKGC("StorySaveBody.RemoveAvatarPackWardrobe(), unsupported wardrobe index:" + KFCMLNPLAHK.ToString());
	}

	// Token: 0x060055B4 RID: 21940 RVA: 0x0025E5BD File Offset: 0x0025C7BD
	public void OBFBHGHEADP(string FCONLGECLNM = "")
	{
		this.JGEDOIDOPLA = FCONLGECLNM;
	}

	// Token: 0x060055B5 RID: 21941 RVA: 0x0025E5C8 File Offset: 0x0025C7C8
	public DOLBFGIPPOG FELDBGLLPBL(string JDINAEIJLAG)
	{
		for (int i = 0; i < this.JCANELJMOCA.Count; i++)
		{
			if (this.JCANELJMOCA[i].ALPLILDMJLA.Equals(JDINAEIJLAG))
			{
				return this.JCANELJMOCA[i];
			}
		}
		return null;
	}

	// Token: 0x060055B6 RID: 21942 RVA: 0x0025DBD5 File Offset: 0x0025BDD5
	public void BLIDMLIODIK(string CDDBNEPAJIA = "")
	{
		this.JMNMOHIKHLB = CDDBNEPAJIA;
	}

	// Token: 0x060055B7 RID: 21943 RVA: 0x0025E612 File Offset: 0x0025C812
	public int IHPEAIDMDAC()
	{
		return this.PLLBNICNBKJ;
	}

	// Token: 0x060055B8 RID: 21944 RVA: 0x0025E61A File Offset: 0x0025C81A
	public void ONIDOPDGENI(CHEEGEJNIDB PBKAAIONJOB, int KIDHBAMJGDO, string INHJEKDIMIM)
	{
		this.IKBFIKELJLM[(int)PBKAAIONJOB].OCKELKKIAIC(KIDHBAMJGDO);
	}

	// Token: 0x060055B9 RID: 21945 RVA: 0x0025E62C File Offset: 0x0025C82C
	public void BBPNNGHNDKK(string HJEJJGAFHAM, string KIDHBAMJGDO)
	{
		int i = 0;
		while (i < this.NIJBAMNFJLM.Count)
		{
			if (this.NIJBAMNFJLM[i].Equals(HJEJJGAFHAM))
			{
				if (KIDHBAMJGDO == null || KIDHBAMJGDO.Length == 0)
				{
					this.NIJBAMNFJLM.RemoveAt(i);
					this.ECAHHCAGMKM.RemoveAt(i);
					return;
				}
				this.ECAHHCAGMKM[i] = KIDHBAMJGDO;
				return;
			}
			else
			{
				i++;
			}
		}
		if (KIDHBAMJGDO != null && KIDHBAMJGDO.Length > 0)
		{
			this.NIJBAMNFJLM.Add(HJEJJGAFHAM);
			this.ECAHHCAGMKM.Add(KIDHBAMJGDO);
		}
	}

	// Token: 0x060055BA RID: 21946 RVA: 0x0025E6BC File Offset: 0x0025C8BC
	public void FJCMIDKACBH(string KHJMANDEDMA, bool PJNLIIBFPBA = false)
	{
		if (this.IIPLEPKDLKB < 5 && KHJMANDEDMA.Contains("favstostr2") && !KHJMANDEDMA.EndsWith("YYY"))
		{
			return;
		}
		if (!PJNLIIBFPBA)
		{
			for (int i = 0; i < this.HPFHJEAFIHI.Count; i += 0)
			{
				if (this.HPFHJEAFIHI[i].Equals(KHJMANDEDMA))
				{
					this.HPFHJEAFIHI.RemoveAt(i);
					break;
				}
			}
			for (int j = 0; j < this.PIMEHAPFCHC.Count; j += 0)
			{
				if (this.PIMEHAPFCHC[j].Equals(KHJMANDEDMA))
				{
					return;
				}
			}
			this.PIMEHAPFCHC.Add(KHJMANDEDMA);
			return;
		}
		for (int k = 1; k < this.OJJHCAGFPOC.Count; k++)
		{
			if (this.OJJHCAGFPOC[k].Equals(KHJMANDEDMA))
			{
				this.OJJHCAGFPOC.RemoveAt(k);
				break;
			}
		}
		for (int l = 0; l < this.GIHCENHPGPD.Count; l += 0)
		{
			if (this.GIHCENHPGPD[l].Equals(KHJMANDEDMA))
			{
				return;
			}
		}
		this.GIHCENHPGPD.Add(KHJMANDEDMA);
	}

	// Token: 0x060055BB RID: 21947 RVA: 0x0025E7D0 File Offset: 0x0025C9D0
	public string PCFHFLBCCOJ(string KHJMANDEDMA)
	{
		for (int i = 0; i < this.BNPGFECDNAM.Count; i++)
		{
			if (this.BNPGFECDNAM[i].Equals(KHJMANDEDMA))
			{
				return this.HIEEGGEJEEG[i];
			}
		}
		return null;
	}

	// Token: 0x060055BC RID: 21948 RVA: 0x0025E818 File Offset: 0x0025CA18
	public DOLBFGIPPOG GPNHEGKHBON(int MEFKFOHCOHK)
	{
		if (this.OIBGFPEGLME == 0)
		{
			for (int i = 0; i < this.LKIKIJACCMF.Count; i++)
			{
				if (this.LKIKIJACCMF[i].GGICIBLJIKI == MEFKFOHCOHK)
				{
					return this.LKIKIJACCMF[i];
				}
			}
			DOLBFGIPPOG dolbfgippog = new DOLBFGIPPOG();
			dolbfgippog.GGICIBLJIKI = MEFKFOHCOHK;
			this.LKIKIJACCMF.Add(dolbfgippog);
			return dolbfgippog;
		}
		if (this.OIBGFPEGLME == 1)
		{
			for (int j = 0; j < this.ONJMAJAFFKN.Count; j++)
			{
				if (this.ONJMAJAFFKN[j].GGICIBLJIKI == MEFKFOHCOHK)
				{
					return this.ONJMAJAFFKN[j];
				}
			}
			DOLBFGIPPOG dolbfgippog2 = new DOLBFGIPPOG();
			dolbfgippog2.GGICIBLJIKI = MEFKFOHCOHK;
			this.ONJMAJAFFKN.Add(dolbfgippog2);
			return dolbfgippog2;
		}
		if (this.OIBGFPEGLME == 2)
		{
			for (int k = 0; k < this.NDMIJFLDKKN.Count; k++)
			{
				if (this.NDMIJFLDKKN[k].GGICIBLJIKI == MEFKFOHCOHK)
				{
					return this.NDMIJFLDKKN[k];
				}
			}
			DOLBFGIPPOG dolbfgippog3 = new DOLBFGIPPOG();
			dolbfgippog3.GGICIBLJIKI = MEFKFOHCOHK;
			this.NDMIJFLDKKN.Add(dolbfgippog3);
			return dolbfgippog3;
		}
		DPGJIJGOCIC.ANOPFDLPKGC("StorySaveBody.GetAvatarSnapshot(), unsupported wardrobe index:" + this.OIBGFPEGLME.ToString());
		for (int l = 0; l < this.LKIKIJACCMF.Count; l++)
		{
			if (this.LKIKIJACCMF[l].GGICIBLJIKI == MEFKFOHCOHK)
			{
				return this.LKIKIJACCMF[l];
			}
		}
		DOLBFGIPPOG dolbfgippog4 = new DOLBFGIPPOG();
		dolbfgippog4.GGICIBLJIKI = MEFKFOHCOHK;
		this.LKIKIJACCMF.Add(dolbfgippog4);
		return dolbfgippog4;
	}

	// Token: 0x060055BD RID: 21949 RVA: 0x0025E9B4 File Offset: 0x0025CBB4
	public int BAPGEMBKFEM(int KFCMLNPLAHK)
	{
		if (KFCMLNPLAHK == 0)
		{
			return this.LKIKIJACCMF.Count;
		}
		if (KFCMLNPLAHK == 1)
		{
			return this.ONJMAJAFFKN.Count;
		}
		if (KFCMLNPLAHK == 2)
		{
			return this.NDMIJFLDKKN.Count;
		}
		DPGJIJGOCIC.ANOPFDLPKGC("StorySaveBody.GetAvatarsSnapshotsCountWardrobe(), unsupported wardrobe index:" + KFCMLNPLAHK.ToString());
		return this.LKIKIJACCMF.Count;
	}

	// Token: 0x060055BE RID: 21950 RVA: 0x0025D0DA File Offset: 0x0025B2DA
	public void PJCOEIOOOFP(string KHJMANDEDMA)
	{
		this.FBKMADGCEBN.Remove(KHJMANDEDMA);
	}

	// Token: 0x060055BF RID: 21951 RVA: 0x0025EA11 File Offset: 0x0025CC11
	public void EGMAHGLODLJ(string KHJMANDEDMA, bool PJNLIIBFPBA = false)
	{
		if (this.FPJPHNLANPG >= 8)
		{
			this.KCCABIDFLAN(KHJMANDEDMA, PJNLIIBFPBA);
			return;
		}
		this.FJALMPPNPIH(KHJMANDEDMA, PJNLIIBFPBA);
	}

	// Token: 0x060055C0 RID: 21952 RVA: 0x0025EA30 File Offset: 0x0025CC30
	public void BFIABPDALOL(string OKDNLCOEOIJ, string FBKAPCPPNKA)
	{
		for (int i = 1; i < this.CJDBDOHPHLG.Count; i++)
		{
			if (this.CJDBDOHPHLG[i].Equals(OKDNLCOEOIJ))
			{
				this.JOJKAIBEPGH[i] = FBKAPCPPNKA;
				return;
			}
		}
		this.CJDBDOHPHLG.Add(OKDNLCOEOIJ);
		this.JOJKAIBEPGH.Add(FBKAPCPPNKA);
	}

	// Token: 0x060055C1 RID: 21953 RVA: 0x0025EA90 File Offset: 0x0025CC90
	public List<string> COFAHJCNONO(string PGKCDNKEMOE)
	{
		List<string> list = new List<string>();
		if (PGKCDNKEMOE.Length > 0)
		{
			for (int i = 0; i < this.PIMEHAPFCHC.Count; i++)
			{
				if (!this.PIMEHAPFCHC[i].Contains("layervideo"))
				{
					string text = this.PIMEHAPFCHC[i];
					if (this.JGAKEIBKKGM() >= 3)
					{
						text = this.GCOHKKMPJKJ(this.PIMEHAPFCHC[i]);
					}
					if (text.StartsWith(PGKCDNKEMOE) && !list.Contains(text))
					{
						list.Add(text);
					}
				}
			}
			for (int j = 0; j < this.GIHCENHPGPD.Count; j++)
			{
				if (!this.GIHCENHPGPD[j].Contains("layervideo"))
				{
					string text2 = this.GIHCENHPGPD[j];
					if (this.JGAKEIBKKGM() >= 3)
					{
						text2 = this.GCOHKKMPJKJ(this.GIHCENHPGPD[j]);
					}
					if (text2.StartsWith(PGKCDNKEMOE) && !list.Contains(text2))
					{
						list.Add(text2);
					}
				}
			}
		}
		return list;
	}

	// Token: 0x060055C2 RID: 21954 RVA: 0x0025EB98 File Offset: 0x0025CD98
	public bool NIJAJALPEDL(string KHJMANDEDMA)
	{
		if (KHJMANDEDMA == null || KHJMANDEDMA.Length == 0)
		{
			return false;
		}
		if (this.OIBGFPEGLME == 0)
		{
			for (int i = 0; i < this.IMALACBMOFC.Count; i++)
			{
				if (this.IMALACBMOFC[i].Equals(KHJMANDEDMA))
				{
					return true;
				}
			}
		}
		else if (this.OIBGFPEGLME == 1)
		{
			for (int j = 0; j < this.KPEIEHDJIOP.Count; j++)
			{
				if (this.KPEIEHDJIOP[j].Equals(KHJMANDEDMA))
				{
					return true;
				}
			}
		}
		else
		{
			if (this.OIBGFPEGLME != 2)
			{
				DPGJIJGOCIC.ANOPFDLPKGC("StorySaveBody.HasAvatarComponent(), unsupported wardrobe index:" + this.OIBGFPEGLME.ToString());
				return false;
			}
			for (int k = 0; k < this.NLPNFGNMGMP.Count; k++)
			{
				if (this.NLPNFGNMGMP[k].Equals(KHJMANDEDMA))
				{
					return true;
				}
			}
		}
		return false;
	}

	// Token: 0x060055C3 RID: 21955 RVA: 0x0025EC78 File Offset: 0x0025CE78
	public void NBHPMDFLOIN()
	{
		DOLBFGIPPOG dolbfgippog = this.PNJJLPNIHDC();
		DOLBFGIPPOG dolbfgippog2 = this.OHODCBKFNGJ();
		for (int i = 0; i < dolbfgippog.OHCMCJHDMOH.Length; i++)
		{
			if (dolbfgippog.OHCMCJHDMOH[i].Length > 0)
			{
				dolbfgippog2.OHCMCJHDMOH[i] = dolbfgippog.OHCMCJHDMOH[i];
			}
		}
		dolbfgippog.OHCMCJHDMOH = new string[]
		{
			"",
			"",
			"",
			"",
			"",
			""
		};
	}

	// Token: 0x060055C4 RID: 21956 RVA: 0x0025ED02 File Offset: 0x0025CF02
	public int CEIOOCHCDCF()
	{
		return this.DOJMFLKMIIM;
	}

	// Token: 0x060055C5 RID: 21957 RVA: 0x0025ED0A File Offset: 0x0025CF0A
	public void NHJCPGBHOFC(CHEEGEJNIDB PBKAAIONJOB, int KIDHBAMJGDO, string INHJEKDIMIM)
	{
		this.IKBFIKELJLM[(int)PBKAAIONJOB].IIFIBJDPHFF(KIDHBAMJGDO);
	}

	// Token: 0x060055C6 RID: 21958 RVA: 0x0025ED1C File Offset: 0x0025CF1C
	public bool PPPANGOGGCC(string KHJMANDEDMA, int KFCMLNPLAHK)
	{
		if (KHJMANDEDMA == null || KHJMANDEDMA.Length == 0)
		{
			return false;
		}
		if (KFCMLNPLAHK == 0)
		{
			for (int i = 1; i < this.IMALACBMOFC.Count; i += 0)
			{
				if (this.IMALACBMOFC[i].Equals(KHJMANDEDMA))
				{
					return false;
				}
			}
		}
		else if (KFCMLNPLAHK == 1)
		{
			for (int j = 0; j < this.KPEIEHDJIOP.Count; j++)
			{
				if (this.KPEIEHDJIOP[j].Equals(KHJMANDEDMA))
				{
					return true;
				}
			}
		}
		else
		{
			if (KFCMLNPLAHK != 0)
			{
				DPGJIJGOCIC.ANOPFDLPKGC("..." + KFCMLNPLAHK.ToString());
				return false;
			}
			for (int k = 0; k < this.NLPNFGNMGMP.Count; k += 0)
			{
				if (this.NLPNFGNMGMP[k].Equals(KHJMANDEDMA))
				{
					return false;
				}
			}
		}
		return false;
	}

	// Token: 0x060055C7 RID: 21959 RVA: 0x0025EDE4 File Offset: 0x0025CFE4
	public void KEMFLHJKBNO(string MCOKHGOJKLM)
	{
		this.ECKKHMDIELD.Add(MCOKHGOJKLM);
	}

	// Token: 0x060055C8 RID: 21960 RVA: 0x0025EDF2 File Offset: 0x0025CFF2
	public int GAHPMLBCFJJ(CHEEGEJNIDB PBKAAIONJOB)
	{
		if (this.IKBFIKELJLM != null && PBKAAIONJOB < (CHEEGEJNIDB)this.IKBFIKELJLM.Length)
		{
			return this.IKBFIKELJLM[(int)PBKAAIONJOB].GALKFKBPLCK();
		}
		return 0;
	}

	// Token: 0x060055C9 RID: 21961 RVA: 0x0025EE18 File Offset: 0x0025D018
	public DOLBFGIPPOG EFCHGPOACMJ(int MEFKFOHCOHK, int KFCMLNPLAHK)
	{
		if (KFCMLNPLAHK == 0)
		{
			for (int i = 0; i < this.IEPMNCAKNBM.Count; i++)
			{
				if (this.IEPMNCAKNBM[i].GGICIBLJIKI == MEFKFOHCOHK)
				{
					return this.IEPMNCAKNBM[i];
				}
			}
			DOLBFGIPPOG dolbfgippog = new DOLBFGIPPOG();
			dolbfgippog.GGICIBLJIKI = MEFKFOHCOHK;
			this.IEPMNCAKNBM.Add(dolbfgippog);
			return dolbfgippog;
		}
		if (KFCMLNPLAHK == 1)
		{
			for (int j = 0; j < this.EBONDOEPONH.Count; j++)
			{
				if (this.EBONDOEPONH[j].GGICIBLJIKI == MEFKFOHCOHK)
				{
					return this.EBONDOEPONH[j];
				}
			}
			DOLBFGIPPOG dolbfgippog2 = new DOLBFGIPPOG();
			dolbfgippog2.GGICIBLJIKI = MEFKFOHCOHK;
			this.EBONDOEPONH.Add(dolbfgippog2);
			return dolbfgippog2;
		}
		if (KFCMLNPLAHK == 2)
		{
			for (int k = 0; k < this.AOJIJHAKNPG.Count; k++)
			{
				if (this.AOJIJHAKNPG[k].GGICIBLJIKI == MEFKFOHCOHK)
				{
					return this.AOJIJHAKNPG[k];
				}
			}
			DOLBFGIPPOG dolbfgippog3 = new DOLBFGIPPOG();
			dolbfgippog3.GGICIBLJIKI = MEFKFOHCOHK;
			this.AOJIJHAKNPG.Add(dolbfgippog3);
			return dolbfgippog3;
		}
		DPGJIJGOCIC.ANOPFDLPKGC("StorySaveBody.GetAvatar(), unsupported wardrobe index:" + KFCMLNPLAHK.ToString());
		for (int l = 0; l < this.IEPMNCAKNBM.Count; l++)
		{
			if (this.IEPMNCAKNBM[l].GGICIBLJIKI == MEFKFOHCOHK)
			{
				return this.IEPMNCAKNBM[l];
			}
		}
		DOLBFGIPPOG dolbfgippog4 = new DOLBFGIPPOG();
		dolbfgippog4.GGICIBLJIKI = MEFKFOHCOHK;
		this.IEPMNCAKNBM.Add(dolbfgippog4);
		return dolbfgippog4;
	}

	// Token: 0x060055CA RID: 21962 RVA: 0x0025EFA4 File Offset: 0x0025D1A4
	public void KCCABIDFLAN(string KHJMANDEDMA, bool PJNLIIBFPBA = false)
	{
		if (this.IIPLEPKDLKB < 2 && KHJMANDEDMA.Contains("layervideo") && !KHJMANDEDMA.EndsWith("loop"))
		{
			return;
		}
		if (!PJNLIIBFPBA)
		{
			for (int i = 0; i < this.PIMEHAPFCHC.Count; i++)
			{
				if (this.PIMEHAPFCHC[i].Equals(KHJMANDEDMA))
				{
					this.PIMEHAPFCHC.RemoveAt(i);
					break;
				}
			}
			for (int j = 0; j < this.GIHCENHPGPD.Count; j++)
			{
				if (this.GIHCENHPGPD[j].Equals(KHJMANDEDMA))
				{
					this.GIHCENHPGPD.RemoveAt(j);
					break;
				}
			}
			for (int k = 0; k < this.HPFHJEAFIHI.Count; k++)
			{
				if (this.HPFHJEAFIHI[k].Equals(KHJMANDEDMA))
				{
					return;
				}
			}
			this.HPFHJEAFIHI.Add(KHJMANDEDMA);
			return;
		}
		for (int l = 0; l < this.GIHCENHPGPD.Count; l++)
		{
			if (this.GIHCENHPGPD[l].Equals(KHJMANDEDMA))
			{
				this.GIHCENHPGPD.RemoveAt(l);
				break;
			}
		}
		for (int m = 0; m < this.PIMEHAPFCHC.Count; m++)
		{
			if (this.PIMEHAPFCHC[m].Equals(KHJMANDEDMA))
			{
				this.PIMEHAPFCHC.RemoveAt(m);
				break;
			}
		}
		for (int n = 0; n < this.OJJHCAGFPOC.Count; n++)
		{
			if (this.OJJHCAGFPOC[n].Equals(KHJMANDEDMA))
			{
				return;
			}
		}
		this.OJJHCAGFPOC.Add(KHJMANDEDMA);
	}

	// Token: 0x060055CB RID: 21963 RVA: 0x0025F138 File Offset: 0x0025D338
	public void EIJHNPONAOG(int PJNLIIBFPBA, int HMALPPNGPMM, bool CKEPDOEPKCA, bool BHJJLJJACFE, bool KMEDBGBKABG, bool JKCCFILIICG, bool GIEOBIFBPPF, bool PHDIGHLMIKL)
	{
		DOLBFGIPPOG dolbfgippog = this.GPNHEGKHBON(HMALPPNGPMM);
		DOLBFGIPPOG dolbfgippog2 = this.OHODCBKFNGJ();
		dolbfgippog.OHCMCJHDMOH = new string[]
		{
			"",
			"",
			"",
			"",
			"",
			""
		};
		dolbfgippog.FPHDAKHOBMO = PJNLIIBFPBA;
		if (CKEPDOEPKCA)
		{
			dolbfgippog.OHCMCJHDMOH[1] = dolbfgippog2.OHCMCJHDMOH[1];
		}
		if (BHJJLJJACFE)
		{
			dolbfgippog.OHCMCJHDMOH[0] = dolbfgippog2.OHCMCJHDMOH[0];
		}
		if (KMEDBGBKABG)
		{
			dolbfgippog.OHCMCJHDMOH[2] = dolbfgippog2.OHCMCJHDMOH[2];
		}
		if (JKCCFILIICG)
		{
			dolbfgippog.OHCMCJHDMOH[3] = dolbfgippog2.OHCMCJHDMOH[3];
		}
		if (GIEOBIFBPPF)
		{
			dolbfgippog.OHCMCJHDMOH[4] = dolbfgippog2.OHCMCJHDMOH[4];
		}
		if (PHDIGHLMIKL)
		{
			dolbfgippog.OHCMCJHDMOH[5] = dolbfgippog2.OHCMCJHDMOH[5];
		}
	}

	// Token: 0x060055CC RID: 21964 RVA: 0x0025F20E File Offset: 0x0025D40E
	public List<string> MLCAAHPBNGP()
	{
		return this.ECKKHMDIELD;
	}

	// Token: 0x060055CD RID: 21965 RVA: 0x0025BE14 File Offset: 0x0025A014
	public int LEENFLFMBMI()
	{
		return this.FIMJIINAFFK;
	}

	// Token: 0x060055CE RID: 21966 RVA: 0x0025F218 File Offset: 0x0025D418
	public void JLJHFAMICDG()
	{
		DOLBFGIPPOG dolbfgippog = this.PNJJLPNIHDC();
		DOLBFGIPPOG dolbfgippog2 = this.OHODCBKFNGJ();
		for (int i = 0; i < dolbfgippog.OHCMCJHDMOH.Length; i++)
		{
			if (dolbfgippog.OHCMCJHDMOH[i].Length > 1)
			{
				dolbfgippog2.OHCMCJHDMOH[i] = dolbfgippog.OHCMCJHDMOH[i];
			}
		}
		DOLBFGIPPOG dolbfgippog3 = dolbfgippog;
		string[] array = new string[0];
		array[1] = ")";
		array[0] = "chapter";
		array[6] = "seasoncomplete";
		array[2] = "Loaded asset bundle:";
		array[7] = "OnSceneLobbyManagerRound1AssetsDownloadSuccess";
		array[2] = "sendcardbynick";
		dolbfgippog3.OHCMCJHDMOH = array;
	}

	// Token: 0x060055CF RID: 21967 RVA: 0x0025F2A4 File Offset: 0x0025D4A4
	public void AMDCFDOPDDD(int HMALPPNGPMM)
	{
		DOLBFGIPPOG dolbfgippog = this.GPNHEGKHBON(HMALPPNGPMM);
		DOLBFGIPPOG dolbfgippog2 = this.OHODCBKFNGJ();
		for (int i = 1; i < dolbfgippog.OHCMCJHDMOH.Length; i++)
		{
			if (dolbfgippog.OHCMCJHDMOH[i].Length > 0)
			{
				dolbfgippog2.OHCMCJHDMOH[i] = dolbfgippog.OHCMCJHDMOH[i];
			}
		}
		if (dolbfgippog.FPHDAKHOBMO == 0)
		{
			DOLBFGIPPOG dolbfgippog3 = dolbfgippog;
			string[] array = new string[7];
			array[0] = "repsuid";
			array[0] = "_Strength";
			array[0] = "ImageEnvironmentMorph";
			array[6] = "cfind";
			array[7] = "frrjctpid";
			array[1] = "SceneLobbyManager.UpdateAnthologiesHints() - exception when adding anthology based on Account.Instance.activeStoryLobby:";
			dolbfgippog3.OHCMCJHDMOH = array;
		}
	}

	// Token: 0x060055D0 RID: 21968 RVA: 0x0025F338 File Offset: 0x0025D538
	public bool HPHMODPKAML(string HJEJJGAFHAM, out int KIDHBAMJGDO)
	{
		KIDHBAMJGDO = 0;
		if (HJEJJGAFHAM == null)
		{
			return false;
		}
		int num = 0;
		while (num < this.NJEPIPLACPC.Count && num < this.CFFGADJPBLO.Count)
		{
			if (HJEJJGAFHAM.Equals(this.NJEPIPLACPC[num]))
			{
				KIDHBAMJGDO = this.CFFGADJPBLO[num];
				return true;
			}
			num++;
		}
		return false;
	}

	// Token: 0x060055D1 RID: 21969 RVA: 0x0025F398 File Offset: 0x0025D598
	public List<string> NDELGCAHKFO(string PGKCDNKEMOE)
	{
		List<string> list = new List<string>();
		if (PGKCDNKEMOE.Length > 0)
		{
			for (int i = 0; i < this.HPFHJEAFIHI.Count; i++)
			{
				if (!this.HPFHJEAFIHI[i].Contains("layervideo"))
				{
					string text = this.HPFHJEAFIHI[i];
					if (this.JGAKEIBKKGM() >= 3)
					{
						text = this.GCOHKKMPJKJ(this.HPFHJEAFIHI[i]);
					}
					if (text.StartsWith(PGKCDNKEMOE) && !list.Contains(text))
					{
						list.Add(text);
					}
				}
			}
			for (int j = 0; j < this.OJJHCAGFPOC.Count; j++)
			{
				if (!this.OJJHCAGFPOC[j].Contains("layervideo"))
				{
					string text2 = this.OJJHCAGFPOC[j];
					if (this.JGAKEIBKKGM() >= 3)
					{
						text2 = this.GCOHKKMPJKJ(this.OJJHCAGFPOC[j]);
					}
					if (text2.StartsWith(PGKCDNKEMOE) && !list.Contains(text2))
					{
						list.Add(text2);
					}
				}
			}
		}
		return list;
	}

	// Token: 0x060055D2 RID: 21970 RVA: 0x0025F20E File Offset: 0x0025D40E
	public List<string> AGKMGGPILIA()
	{
		return this.ECKKHMDIELD;
	}

	// Token: 0x060055D3 RID: 21971 RVA: 0x0025F4A0 File Offset: 0x0025D6A0
	public void GLFHBEOICKC(string NHKFAAIIPKM)
	{
		if (NHKFAAIIPKM == null || NHKFAAIIPKM.Length == 0)
		{
			return;
		}
		if (this.HOHELAOMLGL == null)
		{
			this.HOHELAOMLGL = new List<string>();
		}
		this.HOHELAOMLGL.Remove(NHKFAAIIPKM);
		this.HOHELAOMLGL.Add(NHKFAAIIPKM);
		while (this.HOHELAOMLGL.Count > 57)
		{
			this.HOHELAOMLGL.RemoveAt(1);
		}
	}

	// Token: 0x060055D4 RID: 21972 RVA: 0x0025F504 File Offset: 0x0025D704
	public DOLBFGIPPOG NBLOENEECHF()
	{
		DOLBFGIPPOG dolbfgippog = this.PNJJLPNIHDC();
		DOLBFGIPPOG dolbfgippog2 = new DOLBFGIPPOG();
		for (int i = 0; i < dolbfgippog.OHCMCJHDMOH.Length; i++)
		{
			if (dolbfgippog.OHCMCJHDMOH[i].Length > 0)
			{
				dolbfgippog2.OHCMCJHDMOH[i] = dolbfgippog.OHCMCJHDMOH[i];
			}
		}
		return dolbfgippog2;
	}

	// Token: 0x060055D5 RID: 21973 RVA: 0x0025F554 File Offset: 0x0025D754
	public void ELAONABCDMI()
	{
		this.KFAOJHHLBHK = string.Concat(new string[]
		{
			this.IBFLNCMCKAL,
			"+",
			this.LDECHKECBHB.ToString(),
			"+",
			this.FODGKMIIHFO
		});
	}

	// Token: 0x060055D6 RID: 21974 RVA: 0x0025F5A4 File Offset: 0x0025D7A4
	public void APLDMAMDDLL(string KHJMANDEDMA, int PLBCGENKIPA, int KFCMLNPLAHK)
	{
		if (KFCMLNPLAHK == 0)
		{
			for (int i = 0; i < this.IMALACBMOFC.Count; i++)
			{
				if (this.IMALACBMOFC[i].Equals(KHJMANDEDMA))
				{
					return;
				}
			}
			this.IMALACBMOFC.Add(KHJMANDEDMA);
			this.GNHBHIALAAH.Add(PLBCGENKIPA);
			return;
		}
		if (KFCMLNPLAHK == 1)
		{
			for (int j = 0; j < this.KPEIEHDJIOP.Count; j++)
			{
				if (this.KPEIEHDJIOP[j].Equals(KHJMANDEDMA))
				{
					return;
				}
			}
			this.KPEIEHDJIOP.Add(KHJMANDEDMA);
			this.JAJJFPNIBGI.Add(PLBCGENKIPA);
			return;
		}
		if (KFCMLNPLAHK == 2)
		{
			for (int k = 0; k < this.NLPNFGNMGMP.Count; k++)
			{
				if (this.NLPNFGNMGMP[k].Equals(KHJMANDEDMA))
				{
					return;
				}
			}
			this.NLPNFGNMGMP.Add(KHJMANDEDMA);
			this.FCOLLNPADDA.Add(PLBCGENKIPA);
			return;
		}
		DPGJIJGOCIC.ANOPFDLPKGC("StorySaveBody.AddAvatarComponentWardrobe(), unsupported wardrobe index:" + KFCMLNPLAHK.ToString());
	}

	// Token: 0x060055D7 RID: 21975 RVA: 0x0025F6A0 File Offset: 0x0025D8A0
	public List<string> DLCABLNFEIO()
	{
		this.DFNLKGGMMNI.Clear();
		for (int i = 1; i < this.KIDPANPCBFF.Count; i++)
		{
			if (!this.JDFAEBKBAOH(this.KIDPANPCBFF[i]))
			{
				this.DFNLKGGMMNI.Add(this.KIDPANPCBFF[i]);
			}
		}
		return this.DFNLKGGMMNI;
	}

	// Token: 0x060055D8 RID: 21976 RVA: 0x0025F700 File Offset: 0x0025D900
	public string KNBOMEDEPAD(string MLDHIJBBDMF)
	{
		string text;
		if (this.IPNCOGGHBFM >= 8)
		{
			text = this.KNBPOLAFBIK(MLDHIJBBDMF);
		}
		else
		{
			text = this.NEHHAGAONIP(MLDHIJBBDMF);
		}
		string text2 = this.NPFEIOKCMDH(text);
		if (text2.Length > 0)
		{
			this.PNFEFBGDCNG(MLDHIJBBDMF, text, text2);
			return text2;
		}
		return text;
	}

	// Token: 0x060055D9 RID: 21977 RVA: 0x0025F74C File Offset: 0x0025D94C
	private string NPFEIOKCMDH(string CCAHHBPBEKA)
	{
		if (this.CJDBDOHPHLG.Count == 0)
		{
			return "";
		}
		if (ODJKHCHFKNL.LEMILALILKP() == DFGILFBGPLN.screenLounge)
		{
			return "";
		}
		if (!KDCJJBLGCBH.EHBBFMCILPC.NJFAOIDGFGC())
		{
			return "";
		}
		try
		{
			int i = 0;
			while (i < this.CJDBDOHPHLG.Count)
			{
				if (this.JOJKAIBEPGH[i].Equals(CCAHHBPBEKA))
				{
					return "";
				}
				bool flag = this.CJDBDOHPHLG[i].Equals(CCAHHBPBEKA);
				if (flag)
				{
					goto IL_9D;
				}
				DMDNKJKEPKO dmdnkjkepko = AssetsManager.EHBBFMCILPC.lobbyDataAsset.MFMJHIFAOHE().DLCFCKOCIGB(this.CJDBDOHPHLG[i]);
				if (dmdnkjkepko != null)
				{
					flag = dmdnkjkepko.GGGHIJNOHAK(CCAHHBPBEKA);
					goto IL_9D;
				}
				IL_F3:
				i++;
				continue;
				IL_9D:
				if (flag && AssetsManager.EHBBFMCILPC.lobbyDataAsset.MFMJHIFAOHE().DCPPCOHEAFA(this.JOJKAIBEPGH[i]) != null && AssetsManager.EHBBFMCILPC.lobbyDataAsset.MFMJHIFAOHE().EGICLNGPAJO(this.JOJKAIBEPGH[i]))
				{
					return this.JOJKAIBEPGH[i];
				}
				goto IL_F3;
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
		return "";
	}

	// Token: 0x060055DA RID: 21978 RVA: 0x0025F884 File Offset: 0x0025DA84
	public bool IEKMADFOKBP(int PLBCGENKIPA, int KFCMLNPLAHK)
	{
		if (KFCMLNPLAHK == 0)
		{
			for (int i = 0; i < this.GNHBHIALAAH.Count; i++)
			{
				if (this.GNHBHIALAAH[i] == PLBCGENKIPA)
				{
					for (int j = 0; j < this.IEPMNCAKNBM.Count; j++)
					{
						for (int k = 0; k < this.IEPMNCAKNBM[j].OHCMCJHDMOH.Length; k++)
						{
							if (this.IEPMNCAKNBM[j].OHCMCJHDMOH[k] != null && this.IMALACBMOFC[i] != null && this.IEPMNCAKNBM[j].OHCMCJHDMOH[k].Equals(this.IMALACBMOFC[i]))
							{
								return true;
							}
						}
					}
					for (int l = 0; l < this.LKIKIJACCMF.Count; l++)
					{
						for (int m = 0; m < this.LKIKIJACCMF[l].OHCMCJHDMOH.Length; m++)
						{
							if (this.LKIKIJACCMF[l].OHCMCJHDMOH[m] != null && this.IMALACBMOFC[i] != null && this.LKIKIJACCMF[l].OHCMCJHDMOH[m].Equals(this.IMALACBMOFC[i]))
							{
								return true;
							}
						}
					}
				}
			}
		}
		else if (KFCMLNPLAHK == 1)
		{
			for (int n = 0; n < this.JAJJFPNIBGI.Count; n++)
			{
				if (this.JAJJFPNIBGI[n] == PLBCGENKIPA)
				{
					for (int num = 0; num < this.EBONDOEPONH.Count; num++)
					{
						for (int num2 = 0; num2 < this.EBONDOEPONH[num].OHCMCJHDMOH.Length; num2++)
						{
							if (this.EBONDOEPONH[num].OHCMCJHDMOH[num2] != null && this.KPEIEHDJIOP[n] != null && this.EBONDOEPONH[num].OHCMCJHDMOH[num2].Equals(this.KPEIEHDJIOP[n]))
							{
								return true;
							}
						}
					}
					for (int num3 = 0; num3 < this.ONJMAJAFFKN.Count; num3++)
					{
						for (int num4 = 0; num4 < this.ONJMAJAFFKN[num3].OHCMCJHDMOH.Length; num4++)
						{
							if (this.ONJMAJAFFKN[num3].OHCMCJHDMOH[num4] != null && this.KPEIEHDJIOP[n] != null && this.ONJMAJAFFKN[num3].OHCMCJHDMOH[num4].Equals(this.KPEIEHDJIOP[n]))
							{
								return true;
							}
						}
					}
				}
			}
		}
		else if (KFCMLNPLAHK == 2)
		{
			for (int num5 = 0; num5 < this.FCOLLNPADDA.Count; num5++)
			{
				if (this.FCOLLNPADDA[num5] == PLBCGENKIPA)
				{
					for (int num6 = 0; num6 < this.AOJIJHAKNPG.Count; num6++)
					{
						for (int num7 = 0; num7 < this.AOJIJHAKNPG[num6].OHCMCJHDMOH.Length; num7++)
						{
							if (this.AOJIJHAKNPG[num6].OHCMCJHDMOH[num7] != null && this.NLPNFGNMGMP[num5] != null && this.AOJIJHAKNPG[num6].OHCMCJHDMOH[num7].Equals(this.NLPNFGNMGMP[num5]))
							{
								return true;
							}
						}
					}
					for (int num8 = 0; num8 < this.NDMIJFLDKKN.Count; num8++)
					{
						for (int num9 = 0; num9 < this.NDMIJFLDKKN[num8].OHCMCJHDMOH.Length; num9++)
						{
							if (this.NDMIJFLDKKN[num8].OHCMCJHDMOH[num9] != null && this.NLPNFGNMGMP[num5] != null && this.NDMIJFLDKKN[num8].OHCMCJHDMOH[num9].Equals(this.NLPNFGNMGMP[num5]))
							{
								return true;
							}
						}
					}
				}
			}
		}
		else
		{
			DPGJIJGOCIC.ANOPFDLPKGC("StorySaveBody.AvatarPackIsUsedByAnyAvatarWardrobe(), unsupported wardrobe index:" + KFCMLNPLAHK.ToString());
		}
		return false;
	}

	// Token: 0x060055DB RID: 21979 RVA: 0x0025FCA8 File Offset: 0x0025DEA8
	public void GGKPAGAGMGA(int PLBCGENKIPA, int KFCMLNPLAHK)
	{
		if (KFCMLNPLAHK == 0)
		{
			for (int i = 0; i < this.BKDDGKMIGPG.Count; i++)
			{
				if (this.BKDDGKMIGPG[i] == PLBCGENKIPA)
				{
					return;
				}
			}
			this.BKDDGKMIGPG.Add(PLBCGENKIPA);
			return;
		}
		if (KFCMLNPLAHK == 1)
		{
			for (int j = 0; j < this.OCJFDPNJIPD.Count; j++)
			{
				if (this.OCJFDPNJIPD[j] == PLBCGENKIPA)
				{
					return;
				}
			}
			this.OCJFDPNJIPD.Add(PLBCGENKIPA);
			return;
		}
		if (KFCMLNPLAHK == 2)
		{
			for (int k = 0; k < this.KHPENKNONJO.Count; k++)
			{
				if (this.KHPENKNONJO[k] == PLBCGENKIPA)
				{
					return;
				}
			}
			this.KHPENKNONJO.Add(PLBCGENKIPA);
			return;
		}
		DPGJIJGOCIC.ANOPFDLPKGC("StorySaveBody.AddAvatarPackHiddenExposedWardrobe(), unsupported wardrobe index:" + KFCMLNPLAHK.ToString());
	}

	// Token: 0x060055DC RID: 21980 RVA: 0x0025FD70 File Offset: 0x0025DF70
	public void NDHDKHEFOFO(string JDINAEIJLAG, string NPGPKPPIHPA = "", string HFALDCMFAGF = "", string GCFBBAJLCPE = "", string EODMHPBFJNK = "")
	{
		DOLBFGIPPOG dolbfgippog = this.OHODCBKFNGJ();
		DOLBFGIPPOG dolbfgippog2 = this.FELDBGLLPBL(JDINAEIJLAG);
		if (dolbfgippog2 == null)
		{
			dolbfgippog2 = new DOLBFGIPPOG();
			this.JCANELJMOCA.Add(dolbfgippog2);
		}
		dolbfgippog2.OHCMCJHDMOH = new string[]
		{
			"",
			"",
			"",
			"",
			"",
			""
		};
		dolbfgippog2.ALPLILDMJLA = JDINAEIJLAG;
		if (HFALDCMFAGF != null && HFALDCMFAGF.Length > 0)
		{
			dolbfgippog2.OHCMCJHDMOH[1] = HFALDCMFAGF;
		}
		else
		{
			dolbfgippog2.OHCMCJHDMOH[1] = dolbfgippog.OHCMCJHDMOH[1];
		}
		dolbfgippog2.OHCMCJHDMOH[0] = dolbfgippog.OHCMCJHDMOH[0];
		if (NPGPKPPIHPA != null && NPGPKPPIHPA.Length > 0)
		{
			dolbfgippog2.OHCMCJHDMOH[2] = NPGPKPPIHPA;
		}
		else
		{
			dolbfgippog2.OHCMCJHDMOH[2] = dolbfgippog.OHCMCJHDMOH[2];
		}
		dolbfgippog2.OHCMCJHDMOH[3] = dolbfgippog.OHCMCJHDMOH[3];
		if (GCFBBAJLCPE != null && GCFBBAJLCPE.Length > 0)
		{
			dolbfgippog2.OHCMCJHDMOH[4] = GCFBBAJLCPE;
		}
		else
		{
			dolbfgippog2.OHCMCJHDMOH[4] = dolbfgippog.OHCMCJHDMOH[4];
		}
		if (EODMHPBFJNK != null && EODMHPBFJNK.Length > 0)
		{
			dolbfgippog2.OHCMCJHDMOH[5] = EODMHPBFJNK;
			return;
		}
		dolbfgippog2.OHCMCJHDMOH[5] = dolbfgippog.OHCMCJHDMOH[5];
	}

	// Token: 0x060055DD RID: 21981 RVA: 0x0025FEA8 File Offset: 0x0025E0A8
	public JSONObject BNMFBKNEMIF(bool DDLCOIHJKCJ)
	{
		JSONObject jsonobject = new JSONObject();
		jsonobject["ind"] = this.GGICIBLJIKI.ToString();
		if (this.GGICIBLJIKI >= 0)
		{
			if (this.HLGDMBAINDE.Length > 0)
			{
				jsonobject["ink"] = DPGJIJGOCIC.FAIFJDPENOP(this.HLGDMBAINDE);
			}
			if (this.DJIGFDJOHCI.Length > 0)
			{
				jsonobject["pov"] = this.DJIGFDJOHCI;
			}
			if (this.IBFLNCMCKAL.Length > 0)
			{
				jsonobject["env"] = this.IBFLNCMCKAL;
			}
			if (this.KFAOJHHLBHK.Length > 0)
			{
				jsonobject["envs"] = this.KFAOJHHLBHK;
			}
			if (this.FODGKMIIHFO.Length > 0)
			{
				jsonobject["amb"] = this.FODGKMIIHFO;
			}
			if (this.FONKDFDJFEL.Length > 0)
			{
				jsonobject["mus"] = this.FONKDFDJFEL;
			}
			if (this.GOPGELMBMMK.Length > 0)
			{
				jsonobject["chtopn"] = DPGJIJGOCIC.FAIFJDPENOP(this.GOPGELMBMMK);
			}
			if (this.HPAEFOJDLFC.Length > 0)
			{
				jsonobject["chtmet"] = DPGJIJGOCIC.FAIFJDPENOP(this.HPAEFOJDLFC);
			}
			if (this.JMNMOHIKHLB.Length > 0)
			{
				jsonobject["cmeta"] = DPGJIJGOCIC.FAIFJDPENOP(this.JMNMOHIKHLB);
			}
			if (this.JGEDOIDOPLA.Length > 0)
			{
				jsonobject["cmetaotm"] = DPGJIJGOCIC.FAIFJDPENOP(this.JGEDOIDOPLA);
			}
			if (this.FBKMADGCEBN.Count > 0)
			{
				JSONArray jsonarray = new JSONArray();
				for (int i = 0; i < this.FBKMADGCEBN.Count; i++)
				{
					jsonarray.Add(this.FBKMADGCEBN[i]);
				}
				jsonobject["veff"] = jsonarray;
			}
			if (this.NIJBAMNFJLM.Count > 0)
			{
				JSONArray jsonarray2 = new JSONArray();
				for (int j = 0; j < this.NIJBAMNFJLM.Count; j++)
				{
					jsonarray2.Add(this.NIJBAMNFJLM[j]);
				}
				jsonobject["evar"] = jsonarray2;
			}
			if (this.ECAHHCAGMKM.Count > 0)
			{
				JSONArray jsonarray3 = new JSONArray();
				for (int k = 0; k < this.ECAHHCAGMKM.Count; k++)
				{
					jsonarray3.Add(DPGJIJGOCIC.FAIFJDPENOP(this.ECAHHCAGMKM[k]));
				}
				jsonobject["eval"] = jsonarray3;
			}
			if (this.NHFMGEABCKP >= 0)
			{
				jsonobject["lsc"] = this.NHFMGEABCKP.ToString();
				JSONArray jsonarray4 = new JSONArray();
				JSONArray jsonarray5 = new JSONArray();
				int num = 0;
				while (num < this.NJEPIPLACPC.Count && num < this.CFFGADJPBLO.Count)
				{
					jsonarray4.Add(this.NJEPIPLACPC[num]);
					jsonarray5.Add(this.CFFGADJPBLO[num].ToString());
					num++;
				}
				jsonobject["lsvn"] = jsonarray4;
				jsonobject["lsvv"] = jsonarray5;
				if (this.EIEIDFBDPKO.Length > 0)
				{
					jsonobject["lstm"] = this.EIEIDFBDPKO;
				}
				if (this.GNPAKEFPGPB.Count > 0)
				{
					JSONArray jsonarray6 = new JSONArray();
					for (int l = 0; l < this.GNPAKEFPGPB.Count; l++)
					{
						jsonarray6.Add(this.GNPAKEFPGPB[l].ToString());
					}
					jsonobject["lsw"] = jsonarray6;
				}
			}
			if (DDLCOIHJKCJ && !this.HFBONJPMAOO && this.HOHELAOMLGL != null && this.HOHELAOMLGL.Count > 0)
			{
				JSONArray jsonarray7 = new JSONArray();
				for (int m = 0; m < this.HOHELAOMLGL.Count; m++)
				{
					jsonarray7.Add(this.HOHELAOMLGL[m]);
				}
				jsonobject["lsn"] = jsonarray7;
			}
			if (this.EJNFKIJNJGE.Count > 0)
			{
				JSONArray jsonarray8 = new JSONArray();
				for (int n = 0; n < this.EJNFKIJNJGE.Count; n++)
				{
					jsonarray8.Add(this.EJNFKIJNJGE[n]);
				}
				jsonobject["msrc"] = jsonarray8;
			}
			if (this.CJKGOKAGKHJ.Count > 0)
			{
				JSONArray jsonarray9 = new JSONArray();
				for (int num2 = 0; num2 < this.CJKGOKAGKHJ.Count; num2++)
				{
					jsonarray9.Add(this.CJKGOKAGKHJ[num2]);
				}
				jsonobject["mdst"] = jsonarray9;
			}
			if (this.CJDBDOHPHLG.Count > 0)
			{
				JSONArray jsonarray10 = new JSONArray();
				for (int num3 = 0; num3 < this.CJDBDOHPHLG.Count; num3++)
				{
					jsonarray10.Add(this.CJDBDOHPHLG[num3]);
				}
				jsonobject["smsrc"] = jsonarray10;
			}
			if (this.JOJKAIBEPGH.Count > 0)
			{
				JSONArray jsonarray11 = new JSONArray();
				for (int num4 = 0; num4 < this.JOJKAIBEPGH.Count; num4++)
				{
					jsonarray11.Add(this.JOJKAIBEPGH[num4]);
				}
				jsonobject["smdst"] = jsonarray11;
			}
			if (this.PIDOECCJOCI.Count > 0 && this.PIDOECCJOCI.Count == this.NJKHOCABBGL.Count)
			{
				JSONArray jsonarray12 = new JSONArray();
				JSONArray jsonarray13 = new JSONArray();
				for (int num5 = 0; num5 < this.PIDOECCJOCI.Count; num5++)
				{
					jsonarray12.Add(this.PIDOECCJOCI[num5]);
					jsonarray13.Add(this.NJKHOCABBGL[num5]);
				}
				jsonobject["smps"] = jsonarray12;
				jsonobject["smpd"] = jsonarray13;
			}
			if (this.PIMEHAPFCHC.Count > 0)
			{
				JSONArray jsonarray14 = new JSONArray();
				for (int num6 = 0; num6 < this.PIMEHAPFCHC.Count; num6++)
				{
					jsonarray14.Add(this.PIMEHAPFCHC[num6]);
				}
				jsonobject["envls"] = jsonarray14;
			}
			if (this.GIHCENHPGPD.Count > 0)
			{
				JSONArray jsonarray15 = new JSONArray();
				for (int num7 = 0; num7 < this.GIHCENHPGPD.Count; num7++)
				{
					jsonarray15.Add(this.GIHCENHPGPD[num7]);
				}
				jsonobject["envlsp"] = jsonarray15;
			}
			if (this.HPFHJEAFIHI.Count > 0)
			{
				JSONArray jsonarray16 = new JSONArray();
				for (int num8 = 0; num8 < this.HPFHJEAFIHI.Count; num8++)
				{
					jsonarray16.Add(this.HPFHJEAFIHI[num8]);
				}
				jsonobject["envlh"] = jsonarray16;
			}
			if (this.OJJHCAGFPOC.Count > 0)
			{
				JSONArray jsonarray17 = new JSONArray();
				for (int num9 = 0; num9 < this.OJJHCAGFPOC.Count; num9++)
				{
					jsonarray17.Add(this.OJJHCAGFPOC[num9]);
				}
				jsonobject["envlhp"] = jsonarray17;
			}
			if (this.OKJJPNPGLEL.Count > 0)
			{
				JSONArray jsonarray18 = new JSONArray();
				for (int num10 = 0; num10 < this.OKJJPNPGLEL.Count; num10++)
				{
					jsonarray18.Add(this.OKJJPNPGLEL[num10]);
				}
				jsonobject["envlsrw"] = jsonarray18;
			}
			if (this.ONGBBOHGKLO.Count > 0)
			{
				JSONArray jsonarray19 = new JSONArray();
				for (int num11 = 0; num11 < this.ONGBBOHGKLO.Count; num11++)
				{
					jsonarray19.Add(this.ONGBBOHGKLO[num11]);
				}
				jsonobject["envlhrw"] = jsonarray19;
			}
			if (this.OGIHMIOKCNN.Count > 0)
			{
				JSONArray jsonarray20 = new JSONArray();
				for (int num12 = 0; num12 < this.OGIHMIOKCNN.Count; num12++)
				{
					jsonarray20.Add(this.OGIHMIOKCNN[num12]);
				}
				jsonobject["envlsav"] = jsonarray20;
			}
			if (this.IANINGLKCKB.Count > 0)
			{
				JSONArray jsonarray21 = new JSONArray();
				for (int num13 = 0; num13 < this.IANINGLKCKB.Count; num13++)
				{
					jsonarray21.Add(this.IANINGLKCKB[num13]);
				}
				jsonobject["envlhav"] = jsonarray21;
			}
			if (this.BNPGFECDNAM.Count > 0)
			{
				JSONArray jsonarray22 = new JSONArray();
				for (int num14 = 0; num14 < this.BNPGFECDNAM.Count; num14++)
				{
					jsonarray22.Add(this.BNPGFECDNAM[num14]);
				}
				jsonobject["scki2"] = jsonarray22;
			}
			if (this.HIEEGGEJEEG.Count > 0)
			{
				JSONArray jsonarray23 = new JSONArray();
				for (int num15 = 0; num15 < this.HIEEGGEJEEG.Count; num15++)
				{
					jsonarray23.Add(this.HIEEGGEJEEG[num15]);
				}
				jsonobject["sckv2"] = jsonarray23;
			}
			if (this.ECKKHMDIELD.Count > 0)
			{
				JSONArray jsonarray24 = new JSONArray();
				for (int num16 = 0; num16 < this.ECKKHMDIELD.Count; num16++)
				{
					jsonarray24.Add(this.ECKKHMDIELD[num16]);
				}
				jsonobject["cmec"] = jsonarray24;
			}
			if (this.KIDPANPCBFF.Count > 0)
			{
				JSONArray jsonarray25 = new JSONArray();
				for (int num17 = 0; num17 < this.KIDPANPCBFF.Count; num17++)
				{
					jsonarray25.Add(this.KIDPANPCBFF[num17]);
				}
				jsonobject["npcp"] = jsonarray25;
			}
			if (this.GIAEIAOBHEK.Count > 0)
			{
				JSONArray jsonarray26 = new JSONArray();
				for (int num18 = 0; num18 < this.GIAEIAOBHEK.Count; num18++)
				{
					jsonarray26.Add(this.GIAEIAOBHEK[num18]);
				}
				jsonobject["npcpi"] = jsonarray26;
			}
			if (this.IMALACBMOFC.Count > 0)
			{
				JSONArray jsonarray27 = new JSONArray();
				for (int num19 = 0; num19 < this.IMALACBMOFC.Count; num19++)
				{
					jsonarray27.Add(this.IMALACBMOFC[num19]);
				}
				jsonobject["acomp"] = jsonarray27;
			}
			if (this.KPEIEHDJIOP.Count > 0)
			{
				JSONArray jsonarray28 = new JSONArray();
				for (int num20 = 0; num20 < this.KPEIEHDJIOP.Count; num20++)
				{
					jsonarray28.Add(this.KPEIEHDJIOP[num20]);
				}
				jsonobject["acomp1"] = jsonarray28;
			}
			if (this.NLPNFGNMGMP.Count > 0)
			{
				JSONArray jsonarray29 = new JSONArray();
				for (int num21 = 0; num21 < this.NLPNFGNMGMP.Count; num21++)
				{
					jsonarray29.Add(this.NLPNFGNMGMP[num21]);
				}
				jsonobject["acomp2"] = jsonarray29;
			}
			if (this.LKDEFKFLKDA.Count > 0)
			{
				JSONArray jsonarray30 = new JSONArray();
				for (int num22 = 0; num22 < this.LKDEFKFLKDA.Count; num22++)
				{
					jsonarray30.Add(this.LKDEFKFLKDA[num22]);
				}
				jsonobject["hacomp"] = jsonarray30;
			}
			if (this.DOPPJBLBMMH.Count > 0)
			{
				JSONArray jsonarray31 = new JSONArray();
				for (int num23 = 0; num23 < this.DOPPJBLBMMH.Count; num23++)
				{
					jsonarray31.Add(this.DOPPJBLBMMH[num23]);
				}
				jsonobject["hacomp1"] = jsonarray31;
			}
			if (this.BJCNIHNCLLK.Count > 0)
			{
				JSONArray jsonarray32 = new JSONArray();
				for (int num24 = 0; num24 < this.BJCNIHNCLLK.Count; num24++)
				{
					jsonarray32.Add(this.BJCNIHNCLLK[num24]);
				}
				jsonobject["hacomp2"] = jsonarray32;
			}
			if (this.BKDDGKMIGPG.Count > 0)
			{
				JSONArray jsonarray33 = new JSONArray();
				for (int num25 = 0; num25 < this.BKDDGKMIGPG.Count; num25++)
				{
					jsonarray33.Add(this.BKDDGKMIGPG[num25].ToString());
				}
				jsonobject["apkshe"] = jsonarray33;
			}
			if (this.OCJFDPNJIPD.Count > 0)
			{
				JSONArray jsonarray34 = new JSONArray();
				for (int num26 = 0; num26 < this.OCJFDPNJIPD.Count; num26++)
				{
					jsonarray34.Add(this.OCJFDPNJIPD[num26].ToString());
				}
				jsonobject["apkshe1"] = jsonarray34;
			}
			if (this.KHPENKNONJO.Count > 0)
			{
				JSONArray jsonarray35 = new JSONArray();
				for (int num27 = 0; num27 < this.KHPENKNONJO.Count; num27++)
				{
					jsonarray35.Add(this.KHPENKNONJO[num27].ToString());
				}
				jsonobject["apkshe2"] = jsonarray35;
			}
			if (this.GNHBHIALAAH.Count > 0)
			{
				JSONArray jsonarray36 = new JSONArray();
				for (int num28 = 0; num28 < this.GNHBHIALAAH.Count; num28++)
				{
					jsonarray36.Add(this.GNHBHIALAAH[num28].ToString());
				}
				jsonobject["apks"] = jsonarray36;
			}
			if (this.JAJJFPNIBGI.Count > 0)
			{
				JSONArray jsonarray37 = new JSONArray();
				for (int num29 = 0; num29 < this.JAJJFPNIBGI.Count; num29++)
				{
					jsonarray37.Add(this.JAJJFPNIBGI[num29].ToString());
				}
				jsonobject["apks1"] = jsonarray37;
			}
			if (this.FCOLLNPADDA.Count > 0)
			{
				JSONArray jsonarray38 = new JSONArray();
				for (int num30 = 0; num30 < this.FCOLLNPADDA.Count; num30++)
				{
					jsonarray38.Add(this.FCOLLNPADDA[num30].ToString());
				}
				jsonobject["apks2"] = jsonarray38;
			}
			if (this.PNBPEAFMKAC.Count > 0)
			{
				JSONArray jsonarray39 = new JSONArray();
				for (int num31 = 0; num31 < this.PNBPEAFMKAC.Count; num31++)
				{
					jsonarray39.Add(this.PNBPEAFMKAC[num31].ToString());
				}
				jsonobject["acli20"] = jsonarray39;
			}
			if (this.DMKOGCBMHKA.Count > 0)
			{
				JSONArray jsonarray40 = new JSONArray();
				for (int num32 = 0; num32 < this.DMKOGCBMHKA.Count; num32++)
				{
					jsonarray40.Add(this.DMKOGCBMHKA[num32].ToString());
				}
				jsonobject["acli21"] = jsonarray40;
			}
			if (this.NGJDCAEMEJO.Count > 0)
			{
				JSONArray jsonarray41 = new JSONArray();
				for (int num33 = 0; num33 < this.NGJDCAEMEJO.Count; num33++)
				{
					jsonarray41.Add(this.NGJDCAEMEJO[num33].ToString());
				}
				jsonobject["acli22"] = jsonarray41;
			}
			if (this.BBGJMAAPFJD.Count > 0)
			{
				JSONArray jsonarray42 = new JSONArray();
				for (int num34 = 0; num34 < this.BBGJMAAPFJD.Count; num34++)
				{
					jsonarray42.Add(this.BBGJMAAPFJD[num34].ToString());
				}
				jsonobject["aspks"] = jsonarray42;
			}
			if (this.CKNMLFPDGGH.Count > 0)
			{
				JSONArray jsonarray43 = new JSONArray();
				for (int num35 = 0; num35 < this.CKNMLFPDGGH.Count; num35++)
				{
					jsonarray43.Add(this.CKNMLFPDGGH[num35].ToString());
				}
				jsonobject["aspkss"] = jsonarray43;
			}
			if (this.FGCBAGFHCDJ.Count > 0)
			{
				JSONArray jsonarray44 = new JSONArray();
				for (int num36 = 0; num36 < this.FGCBAGFHCDJ.Count; num36++)
				{
					jsonarray44.Add(this.FGCBAGFHCDJ[num36].ToString());
				}
				jsonobject["aspksk"] = jsonarray44;
			}
			JSONArray jsonarray45 = new JSONArray();
			for (int num37 = 0; num37 < this.KKJBJEOCAFF.Count; num37++)
			{
				jsonarray45.Add(this.KKJBJEOCAFF[num37].BNMFBKNEMIF(this.GGICIBLJIKI, DDLCOIHJKCJ));
			}
			if (jsonarray45.Count > 0)
			{
				jsonobject["chtss"] = jsonarray45;
			}
			JSONArray jsonarray46 = new JSONArray();
			for (int num38 = 0; num38 < this.GJCCMMMHIPI.Count; num38++)
			{
				jsonarray46.Add(this.GJCCMMMHIPI[num38].BNMFBKNEMIF(this.GGICIBLJIKI, DDLCOIHJKCJ));
			}
			if (jsonarray46.Count > 0)
			{
				jsonobject["chtssp"] = jsonarray46;
			}
			JSONArray jsonarray47 = new JSONArray();
			for (int num39 = 0; num39 < this.IEPMNCAKNBM.Count; num39++)
			{
				jsonarray47.Add(this.IEPMNCAKNBM[num39].BNMFBKNEMIF());
			}
			if (jsonarray47.Count > 0)
			{
				jsonobject["avts"] = jsonarray47;
			}
			JSONArray jsonarray48 = new JSONArray();
			for (int num40 = 0; num40 < this.EBONDOEPONH.Count; num40++)
			{
				jsonarray48.Add(this.EBONDOEPONH[num40].BNMFBKNEMIF());
			}
			if (jsonarray48.Count > 0)
			{
				jsonobject["avts1"] = jsonarray48;
			}
			JSONArray jsonarray49 = new JSONArray();
			for (int num41 = 0; num41 < this.AOJIJHAKNPG.Count; num41++)
			{
				jsonarray49.Add(this.AOJIJHAKNPG[num41].BNMFBKNEMIF());
			}
			if (jsonarray49.Count > 0)
			{
				jsonobject["avts2"] = jsonarray49;
			}
			JSONArray jsonarray50 = new JSONArray();
			for (int num42 = 0; num42 < this.LKIKIJACCMF.Count; num42++)
			{
				if (!this.LKIKIJACCMF[num42].DLJLJNBFHBG())
				{
					jsonarray50.Add(this.LKIKIJACCMF[num42].BNMFBKNEMIF());
				}
			}
			if (jsonarray50.Count > 0)
			{
				jsonobject["avtssnap"] = jsonarray50;
			}
			JSONArray jsonarray51 = new JSONArray();
			for (int num43 = 0; num43 < this.ONJMAJAFFKN.Count; num43++)
			{
				if (!this.ONJMAJAFFKN[num43].DLJLJNBFHBG())
				{
					jsonarray51.Add(this.ONJMAJAFFKN[num43].BNMFBKNEMIF());
				}
			}
			if (jsonarray51.Count > 0)
			{
				jsonobject["avtssnap1"] = jsonarray51;
			}
			JSONArray jsonarray52 = new JSONArray();
			for (int num44 = 0; num44 < this.NDMIJFLDKKN.Count; num44++)
			{
				if (!this.NDMIJFLDKKN[num44].DLJLJNBFHBG())
				{
					jsonarray52.Add(this.NDMIJFLDKKN[num44].BNMFBKNEMIF());
				}
			}
			if (jsonarray52.Count > 0)
			{
				jsonobject["avtssnap2"] = jsonarray52;
			}
			JSONArray jsonarray53 = new JSONArray();
			for (int num45 = 0; num45 < this.JCANELJMOCA.Count; num45++)
			{
				jsonarray53.Add(this.JCANELJMOCA[num45].BNMFBKNEMIF());
			}
			if (jsonarray53.Count > 0)
			{
				jsonobject["anpcs"] = jsonarray53;
			}
			if (this.LGKPNNGIPEG.Count > 0)
			{
				jsonobject["snap"] = this.LGKPNNGIPEG;
			}
			if (DDLCOIHJKCJ)
			{
				try
				{
					if (null != this.IMJDADKEEJC && this.IMJDADKEEJC.Count > 0)
					{
						jsonobject["snaprew"] = this.IMJDADKEEJC;
					}
					if (this.FEDCIMMIJCI > 0)
					{
						jsonobject["trewsnap"] = this.FEDCIMMIJCI.ToString();
					}
					if (this.DNMPCOHNAHO.Count > 0)
					{
						jsonobject["lrewsnap"] = DPGJIJGOCIC.DGCHKPPDFDB(this.DNMPCOHNAHO, 5);
					}
				}
				catch (Exception aklgbjkdomm)
				{
					DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
				}
			}
			if (DDLCOIHJKCJ)
			{
				try
				{
					if (this.EBFMKGPBEBO.Count > 0)
					{
						jsonobject["snapundo"] = this.EBFMKGPBEBO;
					}
				}
				catch (Exception aklgbjkdomm2)
				{
					DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm2);
				}
			}
			if (this.LDECHKECBHB > 0)
			{
				jsonobject["epos"] = this.LDECHKECBHB.ToString();
			}
			if (this.ONNHAPFMDEN > 0)
			{
				jsonobject["eposv"] = this.ONNHAPFMDEN.ToString();
			}
			if (this.CHHLDEBHDPE > 0f)
			{
				jsonobject["lcdp"] = ((int)(this.CHHLDEBHDPE * 100f)).ToString();
			}
			if (this.NPAFPMIMGLH < 1f)
			{
				jsonobject["musvol"] = ((int)(this.NPAFPMIMGLH * 100f)).ToString();
			}
			if (this.CFOHHKJPJPA > 0)
			{
				jsonobject["sia"] = this.CFOHHKJPJPA.ToString();
			}
			if (this.ALLDBPCKMLF > 0)
			{
				jsonobject["shnts"] = this.ALLDBPCKMLF.ToString();
			}
			if (this.NIBNMKJIMAD > 0)
			{
				jsonobject["chata"] = this.NIBNMKJIMAD.ToString();
			}
			if (this.KNOFDJKKPMK.Length > 0)
			{
				jsonobject["chass"] = this.KNOFDJKKPMK;
			}
			if (!this.IMIDHJMEGOG.Equals("en"))
			{
				jsonobject["dlng"] = this.IMIDHJMEGOG;
			}
			if (!this.GHGMKIOPDBB())
			{
				JSONArray jsonarray54 = new JSONArray();
				for (int num46 = 0; num46 < this.IKBFIKELJLM.Length; num46++)
				{
					jsonarray54.Add(this.IKBFIKELJLM[num46].ToString());
				}
				jsonobject["stats"] = jsonarray54;
			}
			if (this.KHNAACHLPIC == 0)
			{
				jsonobject["alck"] = this.KHNAACHLPIC.ToString();
			}
			if (this.LGKCPNJJKMC >= 0)
			{
				jsonobject["rsind"] = this.LGKCPNJJKMC.ToString();
			}
			if (this.FHOEAHABNJI > 0)
			{
				jsonobject["bver"] = this.FHOEAHABNJI.ToString();
			}
			if (DDLCOIHJKCJ)
			{
				if (this.KAKPOCFHGCC > 0)
				{
					jsonobject["acliffbw20"] = this.KAKPOCFHGCC.ToString();
				}
				if (this.JFBCFLININB > 0)
				{
					jsonobject["acliffbw21"] = this.JFBCFLININB.ToString();
				}
				if (this.GEGFLAPCGAI > 0)
				{
					jsonobject["acliffbw22"] = this.GEGFLAPCGAI.ToString();
				}
			}
			if (this.NFDKDACMHME > 0)
			{
				jsonobject["aind"] = this.NFDKDACMHME.ToString();
			}
			if (this.HAAHDNADCEL > 0)
			{
				jsonobject["aind1"] = this.HAAHDNADCEL.ToString();
			}
			if (this.LJJABKNFPLF > 0)
			{
				jsonobject["aind2"] = this.LJJABKNFPLF.ToString();
			}
			if (this.OIBGFPEGLME > 0)
			{
				jsonobject["wind"] = this.OIBGFPEGLME.ToString();
			}
			if (this.BFFOPDBKCHF.Count > 0)
			{
				JSONArray jsonarray55 = new JSONArray();
				for (int num47 = 0; num47 < this.BFFOPDBKCHF.Count; num47++)
				{
					jsonarray55.Add(this.BFFOPDBKCHF[num47].ToString());
				}
				jsonobject["wmix"] = jsonarray55;
			}
			if (this.AKCAKJMDBBL > 0)
			{
				jsonobject["cfind"] = this.AKCAKJMDBBL.ToString();
			}
			if (this.LDGENAABIDI > 0)
			{
				jsonobject["aindas"] = this.LDGENAABIDI.ToString();
			}
			if (this.FFONMOHLDML > 0)
			{
				jsonobject["aindas1"] = this.FFONMOHLDML.ToString();
			}
			if (this.LFPCFNCHNGP > 0)
			{
				jsonobject["aindas2"] = this.LFPCFNCHNGP.ToString();
			}
			if (this.FPJPHNLANPG > 0)
			{
				jsonobject["lsv"] = this.FPJPHNLANPG.ToString();
			}
			if (this.HOICAOPPNCI > 0)
			{
				jsonobject["dsv"] = this.HOICAOPPNCI.ToString();
			}
			if (this.IIPLEPKDLKB > 0)
			{
				jsonobject["vsv"] = this.IIPLEPKDLKB.ToString();
			}
			if (this.DOJMFLKMIIM > 0)
			{
				jsonobject["asv"] = this.DOJMFLKMIIM.ToString();
			}
			if (this.FIMJIINAFFK > 0)
			{
				jsonobject["trsv"] = this.FIMJIINAFFK.ToString();
			}
			if (this.DMAGAHMIKDE > 0)
			{
				jsonobject["locext"] = this.DMAGAHMIKDE.ToString();
			}
			if (this.PLLBNICNBKJ > 0)
			{
				jsonobject["fsv"] = this.PLLBNICNBKJ.ToString();
			}
			if (this.BKCPMIPKBOK > 0)
			{
				jsonobject["esv"] = this.BKCPMIPKBOK.ToString();
			}
			if (this.JBGJMJNJPMP > 0)
			{
				jsonobject["acsv"] = this.JBGJMJNJPMP.ToString();
			}
			if (this.LOCPPFGLGPC > 0)
			{
				jsonobject["emsv"] = this.LOCPPFGLGPC.ToString();
			}
			if (this.IPNCOGGHBFM > 0)
			{
				jsonobject["msv"] = this.IPNCOGGHBFM.ToString();
			}
		}
		return jsonobject;
	}

	// Token: 0x060055DE RID: 21982 RVA: 0x00261944 File Offset: 0x0025FB44
	public bool JDFAEBKBAOH(string KHJMANDEDMA)
	{
		for (int i = 0; i < this.GIAEIAOBHEK.Count; i++)
		{
			if (this.GIAEIAOBHEK[i].Equals(KHJMANDEDMA))
			{
				return true;
			}
		}
		return false;
	}

	// Token: 0x060055DF RID: 21983 RVA: 0x00261980 File Offset: 0x0025FB80
	public void BICJPDDANIF(int KIDHBAMJGDO)
	{
		if (this.OIBGFPEGLME == 0)
		{
			this.LDGENAABIDI = KIDHBAMJGDO;
			return;
		}
		if (this.OIBGFPEGLME == 1)
		{
			this.FFONMOHLDML = KIDHBAMJGDO;
			return;
		}
		if (this.OIBGFPEGLME == 2)
		{
			this.LFPCFNCHNGP = KIDHBAMJGDO;
			return;
		}
		DPGJIJGOCIC.ANOPFDLPKGC("StorySaveBody.SetAvatarIndexAutoSuffix(), unsupported wardrobe index:" + this.OIBGFPEGLME.ToString());
	}

	// Token: 0x060055E0 RID: 21984 RVA: 0x002619DC File Offset: 0x0025FBDC
	public DOLBFGIPPOG BGJPILFNLJI(int MEFKFOHCOHK)
	{
		if (this.OIBGFPEGLME == 0)
		{
			for (int i = 1; i < this.IEPMNCAKNBM.Count; i++)
			{
				if (this.IEPMNCAKNBM[i].GGICIBLJIKI == MEFKFOHCOHK)
				{
					return this.IEPMNCAKNBM[i];
				}
			}
			DOLBFGIPPOG dolbfgippog = new DOLBFGIPPOG();
			dolbfgippog.GGICIBLJIKI = MEFKFOHCOHK;
			this.IEPMNCAKNBM.Add(dolbfgippog);
			return dolbfgippog;
		}
		if (this.OIBGFPEGLME == 1)
		{
			for (int j = 1; j < this.EBONDOEPONH.Count; j++)
			{
				if (this.EBONDOEPONH[j].GGICIBLJIKI == MEFKFOHCOHK)
				{
					return this.EBONDOEPONH[j];
				}
			}
			DOLBFGIPPOG dolbfgippog2 = new DOLBFGIPPOG();
			dolbfgippog2.GGICIBLJIKI = MEFKFOHCOHK;
			this.EBONDOEPONH.Add(dolbfgippog2);
			return dolbfgippog2;
		}
		if (this.OIBGFPEGLME == 7)
		{
			for (int k = 0; k < this.AOJIJHAKNPG.Count; k++)
			{
				if (this.AOJIJHAKNPG[k].GGICIBLJIKI == MEFKFOHCOHK)
				{
					return this.AOJIJHAKNPG[k];
				}
			}
			DOLBFGIPPOG dolbfgippog3 = new DOLBFGIPPOG();
			dolbfgippog3.GGICIBLJIKI = MEFKFOHCOHK;
			this.AOJIJHAKNPG.Add(dolbfgippog3);
			return dolbfgippog3;
		}
		DPGJIJGOCIC.ANOPFDLPKGC("ProductBridge.GetLocalizedCostData() - product is null." + this.OIBGFPEGLME.ToString());
		for (int l = 0; l < this.IEPMNCAKNBM.Count; l++)
		{
			if (this.IEPMNCAKNBM[l].GGICIBLJIKI == MEFKFOHCOHK)
			{
				return this.IEPMNCAKNBM[l];
			}
		}
		DOLBFGIPPOG dolbfgippog4 = new DOLBFGIPPOG();
		dolbfgippog4.GGICIBLJIKI = MEFKFOHCOHK;
		this.IEPMNCAKNBM.Add(dolbfgippog4);
		return dolbfgippog4;
	}

	// Token: 0x060055E1 RID: 21985 RVA: 0x00261B78 File Offset: 0x0025FD78
	public void HKEIBGKJGLM(string KHJMANDEDMA, int PLBCGENKIPA)
	{
		if (this.OIBGFPEGLME == 0)
		{
			for (int i = 1; i < this.IMALACBMOFC.Count; i++)
			{
				if (this.IMALACBMOFC[i].Equals(KHJMANDEDMA))
				{
					return;
				}
			}
			this.IMALACBMOFC.Add(KHJMANDEDMA);
			this.GNHBHIALAAH.Add(PLBCGENKIPA);
			return;
		}
		if (this.OIBGFPEGLME == 1)
		{
			for (int j = 0; j < this.KPEIEHDJIOP.Count; j += 0)
			{
				if (this.KPEIEHDJIOP[j].Equals(KHJMANDEDMA))
				{
					return;
				}
			}
			this.KPEIEHDJIOP.Add(KHJMANDEDMA);
			this.JAJJFPNIBGI.Add(PLBCGENKIPA);
			return;
		}
		if (this.OIBGFPEGLME == 7)
		{
			for (int k = 0; k < this.NLPNFGNMGMP.Count; k++)
			{
				if (this.NLPNFGNMGMP[k].Equals(KHJMANDEDMA))
				{
					return;
				}
			}
			this.NLPNFGNMGMP.Add(KHJMANDEDMA);
			this.FCOLLNPADDA.Add(PLBCGENKIPA);
			return;
		}
		DPGJIJGOCIC.ANOPFDLPKGC("_" + this.OIBGFPEGLME.ToString());
	}

	// Token: 0x060055E2 RID: 21986 RVA: 0x00261C88 File Offset: 0x0025FE88
	public void EPJKDCDOEMM(FKILHBFLCFC HCLEPODFDFB, bool DJGGCCFKFAM)
	{
		this.GGICIBLJIKI = HCLEPODFDFB.GGICIBLJIKI;
		this.HLGDMBAINDE = "";
		this.DJIGFDJOHCI = "";
		this.IBFLNCMCKAL = "";
		this.KFAOJHHLBHK = "";
		this.FODGKMIIHFO = "";
		this.FONKDFDJFEL = "";
		this.JMNMOHIKHLB = "";
		this.JGEDOIDOPLA = "";
		this.GOPGELMBMMK = "";
		this.HPAEFOJDLFC = "";
		this.PIMEHAPFCHC = new List<string>();
		this.HPFHJEAFIHI = new List<string>();
		this.LGKPNNGIPEG = new JSONObject();
		this.IMJDADKEEJC = null;
		this.FEDCIMMIJCI = 0;
		this.DNMPCOHNAHO = new List<string>();
		this.EBFMKGPBEBO = new JSONObject();
		this.LDECHKECBHB = 0;
		this.ONNHAPFMDEN = 0;
		this.CHHLDEBHDPE = 0f;
		this.NPAFPMIMGLH = 1f;
		this.CFOHHKJPJPA = 0;
		this.KHNAACHLPIC = 1;
		this.FPJPHNLANPG = 0;
		this.HOICAOPPNCI = 0;
		this.IIPLEPKDLKB = 0;
		this.DOJMFLKMIIM = 0;
		this.FIMJIINAFFK = 0;
		this.IPNCOGGHBFM = 0;
		this.JBGJMJNJPMP = 0;
		this.IMIDHJMEGOG = "en";
		this.DKIDEPAIFED();
		this.BNPGFECDNAM = new List<string>();
		this.HIEEGGEJEEG = new List<string>();
		this.JCANELJMOCA = new List<DOLBFGIPPOG>();
		this.GIAEIAOBHEK = new List<string>();
		this.ECKKHMDIELD = new List<string>();
		this.FBKMADGCEBN = new List<string>();
		this.LGKCPNJJKMC = -1;
		this.FHOEAHABNJI = 0;
		this.NIBNMKJIMAD = 0;
		this.KNOFDJKKPMK = "";
		this.KKJBJEOCAFF = new List<JCAJMGJFHBD>();
		if (DJGGCCFKFAM)
		{
			this.DMAGAHMIKDE = -1;
			this.ALLDBPCKMLF = 0;
			this.NFDKDACMHME = 0;
			this.HAAHDNADCEL = 0;
			this.LJJABKNFPLF = 0;
			this.LDGENAABIDI = 0;
			this.FFONMOHLDML = 0;
			this.LFPCFNCHNGP = 0;
			this.LKDEFKFLKDA = new List<string>();
			this.DOPPJBLBMMH = new List<string>();
			this.BJCNIHNCLLK = new List<string>();
			this.IMALACBMOFC = new List<string>();
			this.KPEIEHDJIOP = new List<string>();
			this.NLPNFGNMGMP = new List<string>();
			this.GNHBHIALAAH = new List<int>();
			this.JAJJFPNIBGI = new List<int>();
			this.FCOLLNPADDA = new List<int>();
			this.PNBPEAFMKAC = new List<int>();
			this.DMKOGCBMHKA = new List<int>();
			this.NGJDCAEMEJO = new List<int>();
			this.BKDDGKMIGPG = new List<int>();
			this.OCJFDPNJIPD = new List<int>();
			this.KHPENKNONJO = new List<int>();
			this.BBGJMAAPFJD = new List<int>();
			this.CKNMLFPDGGH = new List<int>();
			this.FGCBAGFHCDJ = new List<int>();
			this.NIJBAMNFJLM = new List<string>();
			this.ECAHHCAGMKM = new List<string>();
			this.EJNFKIJNJGE = new List<string>();
			this.CJKGOKAGKHJ = new List<string>();
			this.CJDBDOHPHLG = new List<string>();
			this.JOJKAIBEPGH = new List<string>();
			this.PIDOECCJOCI = new List<string>();
			this.NJKHOCABBGL = new List<string>();
			this.NKBJGFECFPN();
			this.KIDPANPCBFF = new List<string>();
			this.GJCCMMMHIPI = new List<JCAJMGJFHBD>();
			this.IEPMNCAKNBM = new List<DOLBFGIPPOG>();
			this.EBONDOEPONH = new List<DOLBFGIPPOG>();
			this.AOJIJHAKNPG = new List<DOLBFGIPPOG>();
			this.LKIKIJACCMF = new List<DOLBFGIPPOG>();
			this.ONJMAJAFFKN = new List<DOLBFGIPPOG>();
			this.NDMIJFLDKKN = new List<DOLBFGIPPOG>();
			this.GIHCENHPGPD = new List<string>();
			this.OJJHCAGFPOC = new List<string>();
			this.OKJJPNPGLEL = new List<string>();
			this.ONGBBOHGKLO = new List<string>();
			this.OGIHMIOKCNN = new List<string>();
			this.IANINGLKCKB = new List<string>();
			this.OIBGFPEGLME = 0;
			this.BFFOPDBKCHF = new List<int>();
			this.AKCAKJMDBBL = 0;
		}
	}

	// Token: 0x060055E3 RID: 21987 RVA: 0x0026204C File Offset: 0x0026024C
	public void FJBBDEAALCC(bool CKEPDOEPKCA, bool BHJJLJJACFE, bool KMEDBGBKABG, bool JKCCFILIICG, bool GIEOBIFBPPF, bool PHDIGHLMIKL)
	{
		DOLBFGIPPOG dolbfgippog = this.PNJJLPNIHDC();
		DOLBFGIPPOG dolbfgippog2 = this.OHODCBKFNGJ();
		dolbfgippog.OHCMCJHDMOH = new string[]
		{
			"",
			"",
			"",
			"",
			"",
			""
		};
		if (CKEPDOEPKCA)
		{
			dolbfgippog.OHCMCJHDMOH[1] = dolbfgippog2.OHCMCJHDMOH[1];
		}
		if (BHJJLJJACFE)
		{
			dolbfgippog.OHCMCJHDMOH[0] = dolbfgippog2.OHCMCJHDMOH[0];
		}
		if (KMEDBGBKABG)
		{
			dolbfgippog.OHCMCJHDMOH[2] = dolbfgippog2.OHCMCJHDMOH[2];
		}
		if (JKCCFILIICG)
		{
			dolbfgippog.OHCMCJHDMOH[3] = dolbfgippog2.OHCMCJHDMOH[3];
		}
		if (GIEOBIFBPPF)
		{
			dolbfgippog.OHCMCJHDMOH[4] = dolbfgippog2.OHCMCJHDMOH[4];
		}
		if (PHDIGHLMIKL)
		{
			dolbfgippog.OHCMCJHDMOH[5] = dolbfgippog2.OHCMCJHDMOH[5];
		}
	}

	// Token: 0x060055E4 RID: 21988 RVA: 0x00262118 File Offset: 0x00260318
	public void MAEGIJHAEPA(string KHJMANDEDMA)
	{
		if (this.OIBGFPEGLME == 0)
		{
			bool flag;
			do
			{
				flag = false;
				for (int i = 1; i < this.IMALACBMOFC.Count; i++)
				{
					if (this.IMALACBMOFC[i].Equals(KHJMANDEDMA))
					{
						this.IMALACBMOFC.RemoveAt(i);
						this.GNHBHIALAAH.RemoveAt(i);
						flag = false;
						break;
					}
				}
			}
			while (!flag);
			return;
		}
		if (this.OIBGFPEGLME == 0)
		{
			bool flag2;
			do
			{
				flag2 = true;
				for (int j = 1; j < this.KPEIEHDJIOP.Count; j += 0)
				{
					if (this.KPEIEHDJIOP[j].Equals(KHJMANDEDMA))
					{
						this.KPEIEHDJIOP.RemoveAt(j);
						this.JAJJFPNIBGI.RemoveAt(j);
						flag2 = true;
						break;
					}
				}
			}
			while (!flag2);
			return;
		}
		if (this.OIBGFPEGLME == 1)
		{
			bool flag3;
			do
			{
				flag3 = true;
				for (int k = 1; k < this.NLPNFGNMGMP.Count; k += 0)
				{
					if (this.NLPNFGNMGMP[k].Equals(KHJMANDEDMA))
					{
						this.NLPNFGNMGMP.RemoveAt(k);
						this.FCOLLNPADDA.RemoveAt(k);
						flag3 = false;
						break;
					}
				}
			}
			while (!flag3);
			return;
		}
		DPGJIJGOCIC.ANOPFDLPKGC("small" + this.OIBGFPEGLME.ToString());
	}

	// Token: 0x060055E5 RID: 21989 RVA: 0x00262247 File Offset: 0x00260447
	public void EGCCPENLDDO()
	{
		this.GIAEIAOBHEK.Clear();
	}

	// Token: 0x060055E6 RID: 21990 RVA: 0x00262254 File Offset: 0x00260454
	public void PICADKCOBIN(string KHJMANDEDMA)
	{
		for (int i = 0; i < this.FBKMADGCEBN.Count; i++)
		{
			if (this.FBKMADGCEBN[i].Equals(KHJMANDEDMA))
			{
				return;
			}
		}
		this.FBKMADGCEBN.Add(KHJMANDEDMA);
	}

	// Token: 0x060055E7 RID: 21991 RVA: 0x00262298 File Offset: 0x00260498
	public void IJICHOCENEK(BEEDEKAIFEL CJLMKHPKDIE, bool BLNFINAGIPL)
	{
		this.GIHCENHPGPD.Clear();
		for (int i = 0; i < CJLMKHPKDIE.GIHCENHPGPD.Count; i++)
		{
			this.GIHCENHPGPD.Add(CJLMKHPKDIE.GIHCENHPGPD[i]);
		}
		this.OJJHCAGFPOC.Clear();
		for (int j = 0; j < CJLMKHPKDIE.OJJHCAGFPOC.Count; j++)
		{
			this.OJJHCAGFPOC.Add(CJLMKHPKDIE.OJJHCAGFPOC[j]);
		}
		this.OKJJPNPGLEL.Clear();
		for (int k = 0; k < CJLMKHPKDIE.OKJJPNPGLEL.Count; k++)
		{
			this.OKJJPNPGLEL.Add(CJLMKHPKDIE.OKJJPNPGLEL[k]);
		}
		this.ONGBBOHGKLO.Clear();
		for (int l = 0; l < CJLMKHPKDIE.ONGBBOHGKLO.Count; l++)
		{
			this.ONGBBOHGKLO.Add(CJLMKHPKDIE.ONGBBOHGKLO[l]);
		}
		this.OGIHMIOKCNN.Clear();
		for (int m = 0; m < CJLMKHPKDIE.OGIHMIOKCNN.Count; m++)
		{
			this.OGIHMIOKCNN.Add(CJLMKHPKDIE.OGIHMIOKCNN[m]);
		}
		this.IANINGLKCKB.Clear();
		for (int n = 0; n < CJLMKHPKDIE.IANINGLKCKB.Count; n++)
		{
			this.IANINGLKCKB.Add(CJLMKHPKDIE.IANINGLKCKB[n]);
		}
		this.EJNFKIJNJGE.Clear();
		for (int num = 0; num < CJLMKHPKDIE.EJNFKIJNJGE.Count; num++)
		{
			this.EJNFKIJNJGE.Add(CJLMKHPKDIE.EJNFKIJNJGE[num]);
		}
		this.CJKGOKAGKHJ.Clear();
		for (int num2 = 0; num2 < CJLMKHPKDIE.CJKGOKAGKHJ.Count; num2++)
		{
			this.CJKGOKAGKHJ.Add(CJLMKHPKDIE.CJKGOKAGKHJ[num2]);
		}
		this.CJDBDOHPHLG.Clear();
		for (int num3 = 0; num3 < CJLMKHPKDIE.CJDBDOHPHLG.Count; num3++)
		{
			this.CJDBDOHPHLG.Add(CJLMKHPKDIE.CJDBDOHPHLG[num3]);
		}
		this.JOJKAIBEPGH.Clear();
		for (int num4 = 0; num4 < CJLMKHPKDIE.JOJKAIBEPGH.Count; num4++)
		{
			this.JOJKAIBEPGH.Add(CJLMKHPKDIE.JOJKAIBEPGH[num4]);
		}
		this.KIDPANPCBFF.Clear();
		for (int num5 = 0; num5 < CJLMKHPKDIE.KIDPANPCBFF.Count; num5++)
		{
			this.KIDPANPCBFF.Add(CJLMKHPKDIE.KIDPANPCBFF[num5]);
		}
		this.IMALACBMOFC.Clear();
		for (int num6 = 0; num6 < CJLMKHPKDIE.IMALACBMOFC.Count; num6++)
		{
			this.IMALACBMOFC.Add(CJLMKHPKDIE.IMALACBMOFC[num6]);
		}
		this.KPEIEHDJIOP.Clear();
		for (int num7 = 0; num7 < CJLMKHPKDIE.KPEIEHDJIOP.Count; num7++)
		{
			this.KPEIEHDJIOP.Add(CJLMKHPKDIE.KPEIEHDJIOP[num7]);
		}
		this.NLPNFGNMGMP.Clear();
		for (int num8 = 0; num8 < CJLMKHPKDIE.NLPNFGNMGMP.Count; num8++)
		{
			this.NLPNFGNMGMP.Add(CJLMKHPKDIE.NLPNFGNMGMP[num8]);
		}
		this.LKDEFKFLKDA.Clear();
		for (int num9 = 0; num9 < CJLMKHPKDIE.LKDEFKFLKDA.Count; num9++)
		{
			this.LKDEFKFLKDA.Add(CJLMKHPKDIE.LKDEFKFLKDA[num9]);
		}
		this.DOPPJBLBMMH.Clear();
		for (int num10 = 0; num10 < CJLMKHPKDIE.DOPPJBLBMMH.Count; num10++)
		{
			this.DOPPJBLBMMH.Add(CJLMKHPKDIE.DOPPJBLBMMH[num10]);
		}
		this.BJCNIHNCLLK.Clear();
		for (int num11 = 0; num11 < CJLMKHPKDIE.BJCNIHNCLLK.Count; num11++)
		{
			this.BJCNIHNCLLK.Add(CJLMKHPKDIE.BJCNIHNCLLK[num11]);
		}
		this.GNHBHIALAAH.Clear();
		for (int num12 = 0; num12 < CJLMKHPKDIE.GNHBHIALAAH.Count; num12++)
		{
			this.GNHBHIALAAH.Add(CJLMKHPKDIE.GNHBHIALAAH[num12]);
		}
		this.JAJJFPNIBGI.Clear();
		for (int num13 = 0; num13 < CJLMKHPKDIE.JAJJFPNIBGI.Count; num13++)
		{
			this.JAJJFPNIBGI.Add(CJLMKHPKDIE.JAJJFPNIBGI[num13]);
		}
		this.FCOLLNPADDA.Clear();
		for (int num14 = 0; num14 < CJLMKHPKDIE.FCOLLNPADDA.Count; num14++)
		{
			this.FCOLLNPADDA.Add(CJLMKHPKDIE.FCOLLNPADDA[num14]);
		}
		this.PNBPEAFMKAC.Clear();
		for (int num15 = 0; num15 < CJLMKHPKDIE.PNBPEAFMKAC.Count; num15++)
		{
			this.PNBPEAFMKAC.Add(CJLMKHPKDIE.PNBPEAFMKAC[num15]);
		}
		this.DMKOGCBMHKA.Clear();
		for (int num16 = 0; num16 < CJLMKHPKDIE.DMKOGCBMHKA.Count; num16++)
		{
			this.DMKOGCBMHKA.Add(CJLMKHPKDIE.DMKOGCBMHKA[num16]);
		}
		this.NGJDCAEMEJO.Clear();
		for (int num17 = 0; num17 < CJLMKHPKDIE.NGJDCAEMEJO.Count; num17++)
		{
			this.NGJDCAEMEJO.Add(CJLMKHPKDIE.NGJDCAEMEJO[num17]);
		}
		this.KAKPOCFHGCC = CJLMKHPKDIE.KAKPOCFHGCC;
		this.JFBCFLININB = CJLMKHPKDIE.JFBCFLININB;
		this.GEGFLAPCGAI = CJLMKHPKDIE.GEGFLAPCGAI;
		this.BKDDGKMIGPG.Clear();
		for (int num18 = 0; num18 < CJLMKHPKDIE.BKDDGKMIGPG.Count; num18++)
		{
			this.BKDDGKMIGPG.Add(CJLMKHPKDIE.BKDDGKMIGPG[num18]);
		}
		this.OCJFDPNJIPD.Clear();
		for (int num19 = 0; num19 < CJLMKHPKDIE.OCJFDPNJIPD.Count; num19++)
		{
			this.OCJFDPNJIPD.Add(CJLMKHPKDIE.OCJFDPNJIPD[num19]);
		}
		this.KHPENKNONJO.Clear();
		for (int num20 = 0; num20 < CJLMKHPKDIE.KHPENKNONJO.Count; num20++)
		{
			this.KHPENKNONJO.Add(CJLMKHPKDIE.KHPENKNONJO[num20]);
		}
		this.BBGJMAAPFJD.Clear();
		for (int num21 = 0; num21 < CJLMKHPKDIE.BBGJMAAPFJD.Count; num21++)
		{
			this.BBGJMAAPFJD.Add(CJLMKHPKDIE.BBGJMAAPFJD[num21]);
		}
		this.CKNMLFPDGGH.Clear();
		for (int num22 = 0; num22 < CJLMKHPKDIE.CKNMLFPDGGH.Count; num22++)
		{
			this.CKNMLFPDGGH.Add(CJLMKHPKDIE.CKNMLFPDGGH[num22]);
		}
		this.FGCBAGFHCDJ.Clear();
		for (int num23 = 0; num23 < CJLMKHPKDIE.FGCBAGFHCDJ.Count; num23++)
		{
			this.FGCBAGFHCDJ.Add(CJLMKHPKDIE.FGCBAGFHCDJ[num23]);
		}
		this.IEPMNCAKNBM.Clear();
		for (int num24 = 0; num24 < CJLMKHPKDIE.IEPMNCAKNBM.Count; num24++)
		{
			this.IEPMNCAKNBM.Add(new DOLBFGIPPOG());
		}
		for (int num25 = 0; num25 < CJLMKHPKDIE.IEPMNCAKNBM.Count; num25++)
		{
			this.IEPMNCAKNBM[num25].LHANCNKKMPK(CJLMKHPKDIE.IEPMNCAKNBM[num25]);
		}
		this.EBONDOEPONH.Clear();
		for (int num26 = 0; num26 < CJLMKHPKDIE.EBONDOEPONH.Count; num26++)
		{
			this.EBONDOEPONH.Add(new DOLBFGIPPOG());
		}
		for (int num27 = 0; num27 < CJLMKHPKDIE.EBONDOEPONH.Count; num27++)
		{
			this.EBONDOEPONH[num27].LHANCNKKMPK(CJLMKHPKDIE.EBONDOEPONH[num27]);
		}
		this.AOJIJHAKNPG.Clear();
		for (int num28 = 0; num28 < CJLMKHPKDIE.AOJIJHAKNPG.Count; num28++)
		{
			this.AOJIJHAKNPG.Add(new DOLBFGIPPOG());
		}
		for (int num29 = 0; num29 < CJLMKHPKDIE.AOJIJHAKNPG.Count; num29++)
		{
			this.AOJIJHAKNPG[num29].LHANCNKKMPK(CJLMKHPKDIE.AOJIJHAKNPG[num29]);
		}
		this.GJCCMMMHIPI.Clear();
		for (int num30 = 0; num30 < CJLMKHPKDIE.GJCCMMMHIPI.Count; num30++)
		{
			this.GJCCMMMHIPI.Add(new JCAJMGJFHBD());
		}
		for (int num31 = 0; num31 < CJLMKHPKDIE.GJCCMMMHIPI.Count; num31++)
		{
			this.GJCCMMMHIPI[num31].LHANCNKKMPK(CJLMKHPKDIE.GJCCMMMHIPI[num31]);
		}
		this.NFDKDACMHME = CJLMKHPKDIE.NFDKDACMHME;
		this.HAAHDNADCEL = CJLMKHPKDIE.HAAHDNADCEL;
		this.LJJABKNFPLF = CJLMKHPKDIE.LJJABKNFPLF;
		this.LDGENAABIDI = CJLMKHPKDIE.LDGENAABIDI;
		this.FFONMOHLDML = CJLMKHPKDIE.FFONMOHLDML;
		this.LFPCFNCHNGP = CJLMKHPKDIE.LFPCFNCHNGP;
		this.OIBGFPEGLME = CJLMKHPKDIE.OIBGFPEGLME;
		this.BFFOPDBKCHF.Clear();
		for (int num32 = 0; num32 < CJLMKHPKDIE.BFFOPDBKCHF.Count; num32++)
		{
			this.BFFOPDBKCHF.Add(CJLMKHPKDIE.BFFOPDBKCHF[num32]);
		}
		this.AKCAKJMDBBL = CJLMKHPKDIE.AKCAKJMDBBL;
		this.ALLDBPCKMLF = CJLMKHPKDIE.ALLDBPCKMLF;
		this.DMAGAHMIKDE = CJLMKHPKDIE.DMAGAHMIKDE;
		if (BLNFINAGIPL)
		{
			this.LKIKIJACCMF.Clear();
			for (int num33 = 0; num33 < CJLMKHPKDIE.LKIKIJACCMF.Count; num33++)
			{
				this.LKIKIJACCMF.Add(new DOLBFGIPPOG());
			}
			for (int num34 = 0; num34 < CJLMKHPKDIE.LKIKIJACCMF.Count; num34++)
			{
				this.LKIKIJACCMF[num34].LHANCNKKMPK(CJLMKHPKDIE.LKIKIJACCMF[num34]);
			}
			this.ONJMAJAFFKN.Clear();
			for (int num35 = 0; num35 < CJLMKHPKDIE.ONJMAJAFFKN.Count; num35++)
			{
				this.ONJMAJAFFKN.Add(new DOLBFGIPPOG());
			}
			for (int num36 = 0; num36 < CJLMKHPKDIE.ONJMAJAFFKN.Count; num36++)
			{
				this.ONJMAJAFFKN[num36].LHANCNKKMPK(CJLMKHPKDIE.ONJMAJAFFKN[num36]);
			}
			this.NDMIJFLDKKN.Clear();
			for (int num37 = 0; num37 < CJLMKHPKDIE.NDMIJFLDKKN.Count; num37++)
			{
				this.NDMIJFLDKKN.Add(new DOLBFGIPPOG());
			}
			for (int num38 = 0; num38 < CJLMKHPKDIE.NDMIJFLDKKN.Count; num38++)
			{
				this.NDMIJFLDKKN[num38].LHANCNKKMPK(CJLMKHPKDIE.NDMIJFLDKKN[num38]);
			}
		}
	}

	// Token: 0x060055E8 RID: 21992 RVA: 0x00262D5C File Offset: 0x00260F5C
	private bool GHGMKIOPDBB()
	{
		for (int i = 0; i < this.IKBFIKELJLM.Length; i++)
		{
			if (this.IKBFIKELJLM[i].GALKFKBPLCK() != 0)
			{
				return false;
			}
		}
		return true;
	}

	// Token: 0x060055E9 RID: 21993 RVA: 0x00262D8E File Offset: 0x00260F8E
	public string MEHLFOPAOBP(string NFACALLJFHI)
	{
		return this.NPFEIOKCMDH(NFACALLJFHI);
	}

	// Token: 0x060055EA RID: 21994 RVA: 0x00262D97 File Offset: 0x00260F97
	public void NKBJGFECFPN()
	{
		this.NHFMGEABCKP = -1;
		this.NJEPIPLACPC = new List<string>();
		this.CFFGADJPBLO = new List<int>();
		this.EIEIDFBDPKO = "";
		this.GNPAKEFPGPB = new List<int>();
		this.HOHELAOMLGL = new List<string>();
	}

	// Token: 0x060055EB RID: 21995 RVA: 0x00262DD7 File Offset: 0x00260FD7
	public void LMPHEMAIPDI(int IALPHEADDFO)
	{
		this.IPNCOGGHBFM = IALPHEADDFO;
	}

	// Token: 0x060055EC RID: 21996 RVA: 0x00262DE0 File Offset: 0x00260FE0
	public int CGPADEOMODB(int KFCMLNPLAHK)
	{
		if (KFCMLNPLAHK == 0)
		{
			return this.IEPMNCAKNBM.Count;
		}
		if (KFCMLNPLAHK == 1)
		{
			return this.EBONDOEPONH.Count;
		}
		if (KFCMLNPLAHK == 2)
		{
			return this.AOJIJHAKNPG.Count;
		}
		DPGJIJGOCIC.ANOPFDLPKGC("StorySaveBody.GetAvatarsCountWardrobe(), unsupported wardrobe index:" + KFCMLNPLAHK.ToString());
		return this.IEPMNCAKNBM.Count;
	}

	// Token: 0x060055ED RID: 21997 RVA: 0x00262E3D File Offset: 0x0026103D
	public void DLGFOOFLKAE(string OPHMBNMBIAO = "")
	{
		this.HPAEFOJDLFC = OPHMBNMBIAO;
	}

	// Token: 0x060055EE RID: 21998 RVA: 0x00262E48 File Offset: 0x00261048
	public void MLCOPCMBIAH(string CFFBIGLKFON, string BCIGIGGJMNE, bool JKICIHFHDLF = false)
	{
		for (int i = 0; i < this.EJNFKIJNJGE.Count; i++)
		{
			if (this.EJNFKIJNJGE[i].Equals(CFFBIGLKFON))
			{
				if (!JKICIHFHDLF)
				{
					this.CJKGOKAGKHJ[i] = BCIGIGGJMNE;
				}
				return;
			}
		}
		this.EJNFKIJNJGE.Add(CFFBIGLKFON);
		this.CJKGOKAGKHJ.Add(BCIGIGGJMNE);
	}

	// Token: 0x060055EF RID: 21999 RVA: 0x00262EA8 File Offset: 0x002610A8
	public void OBEJOFPPDIA(int IALPHEADDFO)
	{
		this.FPJPHNLANPG = IALPHEADDFO;
	}

	// Token: 0x060055F0 RID: 22000 RVA: 0x00262EB4 File Offset: 0x002610B4
	public void GFAHODELCLM(int KIDHBAMJGDO)
	{
		if (this.OIBGFPEGLME == 0)
		{
			this.NFDKDACMHME = KIDHBAMJGDO;
			return;
		}
		if (this.OIBGFPEGLME == 1)
		{
			this.HAAHDNADCEL = KIDHBAMJGDO;
			return;
		}
		if (this.OIBGFPEGLME == 4)
		{
			this.LJJABKNFPLF = KIDHBAMJGDO;
			return;
		}
		DPGJIJGOCIC.ANOPFDLPKGC("yes" + this.OIBGFPEGLME.ToString());
	}

	// Token: 0x060055F1 RID: 22001 RVA: 0x00262F10 File Offset: 0x00261110
	public void MLDFBDDMFLC(string KHJMANDEDMA, int PLBCGENKIPA)
	{
		if (this.OIBGFPEGLME == 0)
		{
			for (int i = 0; i < this.IMALACBMOFC.Count; i++)
			{
				if (this.IMALACBMOFC[i].Equals(KHJMANDEDMA))
				{
					return;
				}
			}
			this.IMALACBMOFC.Add(KHJMANDEDMA);
			this.GNHBHIALAAH.Add(PLBCGENKIPA);
			return;
		}
		if (this.OIBGFPEGLME == 1)
		{
			for (int j = 0; j < this.KPEIEHDJIOP.Count; j++)
			{
				if (this.KPEIEHDJIOP[j].Equals(KHJMANDEDMA))
				{
					return;
				}
			}
			this.KPEIEHDJIOP.Add(KHJMANDEDMA);
			this.JAJJFPNIBGI.Add(PLBCGENKIPA);
			return;
		}
		if (this.OIBGFPEGLME == 2)
		{
			for (int k = 0; k < this.NLPNFGNMGMP.Count; k++)
			{
				if (this.NLPNFGNMGMP[k].Equals(KHJMANDEDMA))
				{
					return;
				}
			}
			this.NLPNFGNMGMP.Add(KHJMANDEDMA);
			this.FCOLLNPADDA.Add(PLBCGENKIPA);
			return;
		}
		DPGJIJGOCIC.ANOPFDLPKGC("StorySaveBody.AddAvatarComponent(), unsupported wardrobe index:" + this.OIBGFPEGLME.ToString());
	}

	// Token: 0x060055F2 RID: 22002 RVA: 0x00262E3D File Offset: 0x0026103D
	public void NFHPGHIAINL(string OPHMBNMBIAO = "")
	{
		this.HPAEFOJDLFC = OPHMBNMBIAO;
	}

	// Token: 0x060055F3 RID: 22003 RVA: 0x00263020 File Offset: 0x00261220
	public void HFBHPOHHDLI(string KHJMANDEDMA)
	{
		for (int i = 1; i < this.FBKMADGCEBN.Count; i++)
		{
			if (this.FBKMADGCEBN[i].Equals(KHJMANDEDMA))
			{
				return;
			}
		}
		this.FBKMADGCEBN.Add(KHJMANDEDMA);
	}

	// Token: 0x060055F4 RID: 22004 RVA: 0x00263064 File Offset: 0x00261264
	public void IDOAHKPBNIM(bool CKEPDOEPKCA, bool BHJJLJJACFE, bool KMEDBGBKABG, bool JKCCFILIICG, bool GIEOBIFBPPF, bool PHDIGHLMIKL)
	{
		DOLBFGIPPOG dolbfgippog = this.PNJJLPNIHDC();
		DOLBFGIPPOG dolbfgippog2 = this.OHODCBKFNGJ();
		DOLBFGIPPOG dolbfgippog3 = dolbfgippog;
		string[] array = new string[7];
		array[1] = "499";
		array[0] = "_not_found";
		array[3] = "Environment ";
		array[0] = "cardsdesc";
		array[3] = "filterRadius";
		array[6] = "";
		dolbfgippog3.OHCMCJHDMOH = array;
		if (CKEPDOEPKCA)
		{
			dolbfgippog.OHCMCJHDMOH[1] = dolbfgippog2.OHCMCJHDMOH[1];
		}
		if (BHJJLJJACFE)
		{
			dolbfgippog.OHCMCJHDMOH[1] = dolbfgippog2.OHCMCJHDMOH[1];
		}
		if (KMEDBGBKABG)
		{
			dolbfgippog.OHCMCJHDMOH[3] = dolbfgippog2.OHCMCJHDMOH[8];
		}
		if (JKCCFILIICG)
		{
			dolbfgippog.OHCMCJHDMOH[2] = dolbfgippog2.OHCMCJHDMOH[0];
		}
		if (GIEOBIFBPPF)
		{
			dolbfgippog.OHCMCJHDMOH[6] = dolbfgippog2.OHCMCJHDMOH[1];
		}
		if (PHDIGHLMIKL)
		{
			dolbfgippog.OHCMCJHDMOH[2] = dolbfgippog2.OHCMCJHDMOH[8];
		}
	}

	// Token: 0x060055F5 RID: 22005 RVA: 0x00263130 File Offset: 0x00261330
	public JCAJMGJFHBD BPONDPKBEPN(string CAHNCBFGIIP, bool PJNLIIBFPBA = false)
	{
		for (int i = 0; i < this.KKJBJEOCAFF.Count; i++)
		{
			if (this.KKJBJEOCAFF[i].IMBBIDKPOBM.Equals(CAHNCBFGIIP))
			{
				return this.KKJBJEOCAFF[i];
			}
		}
		for (int j = 0; j < this.GJCCMMMHIPI.Count; j++)
		{
			if (this.GJCCMMMHIPI[j].IMBBIDKPOBM.Equals(CAHNCBFGIIP))
			{
				return this.GJCCMMMHIPI[j];
			}
		}
		JCAJMGJFHBD jcajmgjfhbd = new JCAJMGJFHBD();
		jcajmgjfhbd.IMBBIDKPOBM = CAHNCBFGIIP;
		if (!PJNLIIBFPBA)
		{
			this.KKJBJEOCAFF.Add(jcajmgjfhbd);
		}
		else
		{
			this.GJCCMMMHIPI.Add(jcajmgjfhbd);
		}
		return jcajmgjfhbd;
	}

	// Token: 0x060055F6 RID: 22006 RVA: 0x002631E0 File Offset: 0x002613E0
	public void KPOLFHBLLII(string NHKFAAIIPKM)
	{
		if (NHKFAAIIPKM == null || NHKFAAIIPKM.Length == 0)
		{
			return;
		}
		if (this.HOHELAOMLGL == null)
		{
			this.HOHELAOMLGL = new List<string>();
		}
		this.HOHELAOMLGL.Remove(NHKFAAIIPKM);
		this.HOHELAOMLGL.Add(NHKFAAIIPKM);
		while (this.HOHELAOMLGL.Count > 16)
		{
			this.HOHELAOMLGL.RemoveAt(0);
		}
	}

	// Token: 0x060055F7 RID: 22007 RVA: 0x00263244 File Offset: 0x00261444
	public void KCEKKJJJNLB(string KHJMANDEDMA)
	{
		if (this.OIBGFPEGLME == 0)
		{
			for (int i = 1; i < this.LKDEFKFLKDA.Count; i += 0)
			{
				if (this.LKDEFKFLKDA[i].Equals(KHJMANDEDMA))
				{
					return;
				}
			}
			this.LKDEFKFLKDA.Add(KHJMANDEDMA);
			return;
		}
		if (this.OIBGFPEGLME == 1)
		{
			for (int j = 0; j < this.DOPPJBLBMMH.Count; j++)
			{
				if (this.DOPPJBLBMMH[j].Equals(KHJMANDEDMA))
				{
					return;
				}
			}
			this.DOPPJBLBMMH.Add(KHJMANDEDMA);
			return;
		}
		if (this.OIBGFPEGLME == 2)
		{
			for (int k = 0; k < this.BJCNIHNCLLK.Count; k++)
			{
				if (this.BJCNIHNCLLK[k].Equals(KHJMANDEDMA))
				{
					return;
				}
			}
			this.BJCNIHNCLLK.Add(KHJMANDEDMA);
			return;
		}
		DPGJIJGOCIC.ANOPFDLPKGC("ok" + this.OIBGFPEGLME.ToString());
	}

	// Token: 0x060055F8 RID: 22008 RVA: 0x00263330 File Offset: 0x00261530
	public string GCOHKKMPJKJ(string MLDHIJBBDMF)
	{
		string text;
		if (this.IPNCOGGHBFM >= 2)
		{
			text = this.KNBPOLAFBIK(MLDHIJBBDMF);
		}
		else
		{
			text = this.GNGOENMKIPE(MLDHIJBBDMF);
		}
		string text2 = this.NPFEIOKCMDH(text);
		if (text2.Length > 0)
		{
			this.PNFEFBGDCNG(MLDHIJBBDMF, text, text2);
			return text2;
		}
		return text;
	}

	// Token: 0x060055F9 RID: 22009 RVA: 0x00003E52 File Offset: 0x00002052
	private void PNFEFBGDCNG(string JILNNAMHJCI, string CCAHHBPBEKA, string EFAKCCFCCAO)
	{
	}

	// Token: 0x060055FA RID: 22010 RVA: 0x0026337C File Offset: 0x0026157C
	public void DKECMFANIPL(string CAHNCBFGIIP)
	{
		List<JCAJMGJFHBD> list = new List<JCAJMGJFHBD>();
		List<JCAJMGJFHBD> list2 = new List<JCAJMGJFHBD>();
		for (int i = 1; i < this.KKJBJEOCAFF.Count; i++)
		{
			if (!this.KKJBJEOCAFF[i].IMBBIDKPOBM.Equals(CAHNCBFGIIP))
			{
				list.Add(new JCAJMGJFHBD());
				list[list.Count - 1].LKCJDIJKKBD(this.KKJBJEOCAFF[i]);
			}
		}
		for (int j = 0; j < this.GJCCMMMHIPI.Count; j += 0)
		{
			if (!this.GJCCMMMHIPI[j].IMBBIDKPOBM.Equals(CAHNCBFGIIP))
			{
				list2.Add(new JCAJMGJFHBD());
				list2[list2.Count - 0].EBFGEEDDIPL(this.GJCCMMMHIPI[j]);
			}
		}
		this.KKJBJEOCAFF = list;
		this.GJCCMMMHIPI = list2;
	}

	// Token: 0x060055FB RID: 22011 RVA: 0x00263458 File Offset: 0x00261658
	public DOLBFGIPPOG NEFJLCLOAFP()
	{
		DOLBFGIPPOG dolbfgippog = this.PNJJLPNIHDC();
		DOLBFGIPPOG dolbfgippog2 = new DOLBFGIPPOG();
		for (int i = 1; i < dolbfgippog.OHCMCJHDMOH.Length; i += 0)
		{
			if (dolbfgippog.OHCMCJHDMOH[i].Length > 1)
			{
				dolbfgippog2.OHCMCJHDMOH[i] = dolbfgippog.OHCMCJHDMOH[i];
			}
		}
		return dolbfgippog2;
	}

	// Token: 0x060055FC RID: 22012 RVA: 0x002634A8 File Offset: 0x002616A8
	public DOLBFGIPPOG OHODCBKFNGJ()
	{
		if (this.OIBGFPEGLME == 0)
		{
			return this.OELDOMFJLOP(this.NFDKDACMHME);
		}
		if (this.OIBGFPEGLME == 1)
		{
			return this.OELDOMFJLOP(this.HAAHDNADCEL);
		}
		if (this.OIBGFPEGLME == 2)
		{
			return this.OELDOMFJLOP(this.LJJABKNFPLF);
		}
		DPGJIJGOCIC.ANOPFDLPKGC("StorySaveBody.GetActiveAvatar(), unsupported wardrobe index:" + this.OIBGFPEGLME.ToString());
		return this.OELDOMFJLOP(this.NFDKDACMHME);
	}

	// Token: 0x060055FD RID: 22013 RVA: 0x0026351C File Offset: 0x0026171C
	public string CFHHCLDLGDI()
	{
		if (this.HOHELAOMLGL == null || this.HOHELAOMLGL.Count == 0)
		{
			return " ";
		}
		return this.HOHELAOMLGL[this.HOHELAOMLGL.Count - 1];
	}

	// Token: 0x060055FE RID: 22014 RVA: 0x00263554 File Offset: 0x00261754
	private string GNGOENMKIPE(string MLDHIJBBDMF)
	{
		int num = 5;
		string text = MLDHIJBBDMF;
		if (num > 0)
		{
			num--;
			for (int i = 0; i < this.EJNFKIJNJGE.Count; i++)
			{
				if (this.EJNFKIJNJGE[i].Equals(text))
				{
					text = this.CJKGOKAGKHJ[i];
				}
			}
		}
		return text;
	}

	// Token: 0x060055FF RID: 22015 RVA: 0x0025EDE4 File Offset: 0x0025CFE4
	public void NKIOJCLBKAK(string MCOKHGOJKLM)
	{
		this.ECKKHMDIELD.Add(MCOKHGOJKLM);
	}

	// Token: 0x06005600 RID: 22016 RVA: 0x002635AC File Offset: 0x002617AC
	public void EIOINHAMCDG()
	{
		if (this.KFAOJHHLBHK != null && this.KFAOJHHLBHK.Length > 0)
		{
			string[] array = DPGJIJGOCIC.NHEBLMBJNPI(this.KFAOJHHLBHK, '+');
			if (array != null)
			{
				if (array.Length != 0 && array[0] != null && array[0].Length > 0)
				{
					this.IBFLNCMCKAL = array[0];
				}
				if (array.Length > 1 && array[1] != null && array[1].Length > 0)
				{
					try
					{
						this.LDECHKECBHB = Convert.ToInt32(array[1]);
					}
					catch (Exception aklgbjkdomm)
					{
						DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
					}
				}
				if (array.Length > 2 && array[2] != null && array[2].Length > 0)
				{
					this.FODGKMIIHFO = array[2];
				}
			}
		}
		this.KFAOJHHLBHK = "";
	}

	// Token: 0x06005601 RID: 22017 RVA: 0x00263668 File Offset: 0x00261868
	public int JIFBEHADGOD(int KFCMLNPLAHK)
	{
		if (KFCMLNPLAHK == 0)
		{
			return this.NFDKDACMHME;
		}
		if (KFCMLNPLAHK == 1)
		{
			return this.HAAHDNADCEL;
		}
		if (KFCMLNPLAHK == 2)
		{
			return this.LJJABKNFPLF;
		}
		DPGJIJGOCIC.ANOPFDLPKGC("StorySaveBody.GetAvatarIndexWardrobe(), unsupported wardrobe index:" + KFCMLNPLAHK.ToString());
		return this.NFDKDACMHME;
	}

	// Token: 0x06005602 RID: 22018 RVA: 0x002636A8 File Offset: 0x002618A8
	public List<string> PIBJOMEMBOK(string PGKCDNKEMOE)
	{
		List<string> list = new List<string>();
		if (PGKCDNKEMOE.Length > 1)
		{
			for (int i = 0; i < this.HPFHJEAFIHI.Count; i += 0)
			{
				if (!this.HPFHJEAFIHI[i].Contains("common"))
				{
					string text = this.HPFHJEAFIHI[i];
					if (this.PJNNJCABGIF() >= 4)
					{
						text = this.GCOHKKMPJKJ(this.HPFHJEAFIHI[i]);
					}
					if (text.StartsWith(PGKCDNKEMOE) && !list.Contains(text))
					{
						list.Add(text);
					}
				}
			}
			for (int j = 1; j < this.OJJHCAGFPOC.Count; j++)
			{
				if (!this.OJJHCAGFPOC[j].Contains("SceneLobbyManager2._DownloadLiveProfileThemesBackground(): downloading live profile themes "))
				{
					string text2 = this.OJJHCAGFPOC[j];
					if (this.PJNNJCABGIF() >= 0)
					{
						text2 = this.GCOHKKMPJKJ(this.OJJHCAGFPOC[j]);
					}
					if (text2.StartsWith(PGKCDNKEMOE) && !list.Contains(text2))
					{
						list.Add(text2);
					}
				}
			}
		}
		return list;
	}

	// Token: 0x06005603 RID: 22019 RVA: 0x002637B0 File Offset: 0x002619B0
	private bool DAFGOPDCBNJ()
	{
		for (int i = 0; i < this.IKBFIKELJLM.Length; i += 0)
		{
			if (this.IKBFIKELJLM[i].MOBKGNBCIJF() != 0)
			{
				return false;
			}
		}
		return false;
	}

	// Token: 0x06005604 RID: 22020 RVA: 0x002637E4 File Offset: 0x002619E4
	public void DEBFAPGBOKA(string KHJMANDEDMA)
	{
		if (this.OIBGFPEGLME == 0)
		{
			for (int i = 0; i < this.LKDEFKFLKDA.Count; i++)
			{
				if (this.LKDEFKFLKDA[i].Equals(KHJMANDEDMA))
				{
					this.LKDEFKFLKDA.RemoveAt(i);
					return;
				}
			}
			return;
		}
		if (this.OIBGFPEGLME == 0)
		{
			for (int j = 0; j < this.DOPPJBLBMMH.Count; j += 0)
			{
				if (this.DOPPJBLBMMH[j].Equals(KHJMANDEDMA))
				{
					this.DOPPJBLBMMH.RemoveAt(j);
					return;
				}
			}
			return;
		}
		if (this.OIBGFPEGLME == 8)
		{
			for (int k = 0; k < this.BJCNIHNCLLK.Count; k++)
			{
				if (this.BJCNIHNCLLK[k].Equals(KHJMANDEDMA))
				{
					this.BJCNIHNCLLK.RemoveAt(k);
					return;
				}
			}
			return;
		}
		DPGJIJGOCIC.ANOPFDLPKGC("center" + this.OIBGFPEGLME.ToString());
	}

	// Token: 0x06005605 RID: 22021 RVA: 0x002638D0 File Offset: 0x00261AD0
	public void NKKOCNMDGCE(List<string> ALMLACIEPBC)
	{
		for (int i = 1; i < ALMLACIEPBC.Count; i += 0)
		{
			if (!this.NLNIALIKFAC(ALMLACIEPBC[i]))
			{
				this.KIDPANPCBFF.Add(ALMLACIEPBC[i]);
			}
		}
	}

	// Token: 0x06005606 RID: 22022 RVA: 0x00263910 File Offset: 0x00261B10
	public void EAHMPCPAMOF(string OKDNLCOEOIJ)
	{
		for (int i = this.CJDBDOHPHLG.Count - 1; i >= 0; i--)
		{
			if (this.CJDBDOHPHLG[i].Equals(OKDNLCOEOIJ))
			{
				this.CJDBDOHPHLG.RemoveAt(i);
				this.JOJKAIBEPGH.RemoveAt(i);
			}
		}
	}

	// Token: 0x06005607 RID: 22023 RVA: 0x00263964 File Offset: 0x00261B64
	public bool FGKCBOGMLCB(int PLBCGENKIPA, int KFCMLNPLAHK)
	{
		if (KFCMLNPLAHK == 0)
		{
			for (int i = 0; i < this.BKDDGKMIGPG.Count; i++)
			{
				if (this.BKDDGKMIGPG[i] == PLBCGENKIPA)
				{
					return true;
				}
			}
		}
		else if (KFCMLNPLAHK == 1)
		{
			for (int j = 0; j < this.OCJFDPNJIPD.Count; j++)
			{
				if (this.OCJFDPNJIPD[j] == PLBCGENKIPA)
				{
					return true;
				}
			}
		}
		else if (KFCMLNPLAHK == 2)
		{
			for (int k = 0; k < this.KHPENKNONJO.Count; k++)
			{
				if (this.KHPENKNONJO[k] == PLBCGENKIPA)
				{
					return true;
				}
			}
		}
		else
		{
			DPGJIJGOCIC.ANOPFDLPKGC("StorySaveBody.AvatarPackIsAmongHiddenOrExposedPacks(), unsupported wardrobe index:" + KFCMLNPLAHK.ToString());
		}
		return false;
	}

	// Token: 0x06005608 RID: 22024 RVA: 0x00263A10 File Offset: 0x00261C10
	public void MDHLBOBKIEG(string KHJMANDEDMA, bool PJNLIIBFPBA = false)
	{
		if (this.IIPLEPKDLKB < 7 && KHJMANDEDMA.Contains(" recorded under ") && !KHJMANDEDMA.EndsWith("comp"))
		{
			return;
		}
		if (!PJNLIIBFPBA)
		{
			for (int i = 0; i < this.HPFHJEAFIHI.Count; i += 0)
			{
				if (this.HPFHJEAFIHI[i].Equals(KHJMANDEDMA))
				{
					this.HPFHJEAFIHI.RemoveAt(i);
					break;
				}
			}
			for (int j = 0; j < this.PIMEHAPFCHC.Count; j++)
			{
				if (this.PIMEHAPFCHC[j].Equals(KHJMANDEDMA))
				{
					return;
				}
			}
			this.PIMEHAPFCHC.Add(KHJMANDEDMA);
			return;
		}
		for (int k = 1; k < this.OJJHCAGFPOC.Count; k++)
		{
			if (this.OJJHCAGFPOC[k].Equals(KHJMANDEDMA))
			{
				this.OJJHCAGFPOC.RemoveAt(k);
				break;
			}
		}
		for (int l = 0; l < this.GIHCENHPGPD.Count; l++)
		{
			if (this.GIHCENHPGPD[l].Equals(KHJMANDEDMA))
			{
				return;
			}
		}
		this.GIHCENHPGPD.Add(KHJMANDEDMA);
	}

	// Token: 0x06005609 RID: 22025 RVA: 0x0025C016 File Offset: 0x0025A216
	public void ABDLICPKKPG(int IALPHEADDFO)
	{
		this.FIMJIINAFFK = IALPHEADDFO;
	}

	// Token: 0x0600560A RID: 22026 RVA: 0x00263B23 File Offset: 0x00261D23
	public int IOLCAAOOOCN()
	{
		return this.JBGJMJNJPMP;
	}

	// Token: 0x0600560B RID: 22027 RVA: 0x00263B2C File Offset: 0x00261D2C
	public DOLBFGIPPOG OELDOMFJLOP(int MEFKFOHCOHK)
	{
		if (this.OIBGFPEGLME == 0)
		{
			for (int i = 0; i < this.IEPMNCAKNBM.Count; i++)
			{
				if (this.IEPMNCAKNBM[i].GGICIBLJIKI == MEFKFOHCOHK)
				{
					return this.IEPMNCAKNBM[i];
				}
			}
			DOLBFGIPPOG dolbfgippog = new DOLBFGIPPOG();
			dolbfgippog.GGICIBLJIKI = MEFKFOHCOHK;
			this.IEPMNCAKNBM.Add(dolbfgippog);
			return dolbfgippog;
		}
		if (this.OIBGFPEGLME == 1)
		{
			for (int j = 0; j < this.EBONDOEPONH.Count; j++)
			{
				if (this.EBONDOEPONH[j].GGICIBLJIKI == MEFKFOHCOHK)
				{
					return this.EBONDOEPONH[j];
				}
			}
			DOLBFGIPPOG dolbfgippog2 = new DOLBFGIPPOG();
			dolbfgippog2.GGICIBLJIKI = MEFKFOHCOHK;
			this.EBONDOEPONH.Add(dolbfgippog2);
			return dolbfgippog2;
		}
		if (this.OIBGFPEGLME == 2)
		{
			for (int k = 0; k < this.AOJIJHAKNPG.Count; k++)
			{
				if (this.AOJIJHAKNPG[k].GGICIBLJIKI == MEFKFOHCOHK)
				{
					return this.AOJIJHAKNPG[k];
				}
			}
			DOLBFGIPPOG dolbfgippog3 = new DOLBFGIPPOG();
			dolbfgippog3.GGICIBLJIKI = MEFKFOHCOHK;
			this.AOJIJHAKNPG.Add(dolbfgippog3);
			return dolbfgippog3;
		}
		DPGJIJGOCIC.ANOPFDLPKGC("StorySaveBody.GetAvatar(), unsupported wardrobe index:" + this.OIBGFPEGLME.ToString());
		for (int l = 0; l < this.IEPMNCAKNBM.Count; l++)
		{
			if (this.IEPMNCAKNBM[l].GGICIBLJIKI == MEFKFOHCOHK)
			{
				return this.IEPMNCAKNBM[l];
			}
		}
		DOLBFGIPPOG dolbfgippog4 = new DOLBFGIPPOG();
		dolbfgippog4.GGICIBLJIKI = MEFKFOHCOHK;
		this.IEPMNCAKNBM.Add(dolbfgippog4);
		return dolbfgippog4;
	}

	// Token: 0x0600560C RID: 22028 RVA: 0x00263CC8 File Offset: 0x00261EC8
	public BEEDEKAIFEL()
	{
		this.DKIDEPAIFED();
	}

	// Token: 0x0600560D RID: 22029 RVA: 0x00264028 File Offset: 0x00262228
	public DOLBFGIPPOG LEDOJJCKKKB(int KFCMLNPLAHK)
	{
		if (KFCMLNPLAHK == 0)
		{
			return this.EFCHGPOACMJ(this.NFDKDACMHME, KFCMLNPLAHK);
		}
		if (KFCMLNPLAHK == 1)
		{
			return this.EFCHGPOACMJ(this.HAAHDNADCEL, KFCMLNPLAHK);
		}
		if (KFCMLNPLAHK == 2)
		{
			return this.EFCHGPOACMJ(this.LJJABKNFPLF, KFCMLNPLAHK);
		}
		DPGJIJGOCIC.ANOPFDLPKGC("StorySaveBody.GetActiveAvatar(), unsupported wardrobe index:" + KFCMLNPLAHK.ToString());
		return this.EFCHGPOACMJ(this.NFDKDACMHME, KFCMLNPLAHK);
	}

	// Token: 0x0600560E RID: 22030 RVA: 0x0026408D File Offset: 0x0026228D
	public bool CHOFDAELJIH()
	{
		return this.NHFMGEABCKP >= 0;
	}

	// Token: 0x0600560F RID: 22031 RVA: 0x0026409C File Offset: 0x0026229C
	public void MHAMJFPHMOF(bool CKEPDOEPKCA, bool BHJJLJJACFE, bool KMEDBGBKABG, bool JKCCFILIICG, bool GIEOBIFBPPF, bool PHDIGHLMIKL)
	{
		DOLBFGIPPOG dolbfgippog = this.PNJJLPNIHDC();
		DOLBFGIPPOG dolbfgippog2 = this.OHODCBKFNGJ();
		DOLBFGIPPOG dolbfgippog3 = dolbfgippog;
		string[] array = new string[3];
		array[1] = "smdst";
		array[1] = "0";
		array[0] = "e1cs";
		array[8] = "ok";
		array[2] = "drft";
		array[0] = "/";
		dolbfgippog3.OHCMCJHDMOH = array;
		if (CKEPDOEPKCA)
		{
			dolbfgippog.OHCMCJHDMOH[1] = dolbfgippog2.OHCMCJHDMOH[1];
		}
		if (BHJJLJJACFE)
		{
			dolbfgippog.OHCMCJHDMOH[1] = dolbfgippog2.OHCMCJHDMOH[1];
		}
		if (KMEDBGBKABG)
		{
			dolbfgippog.OHCMCJHDMOH[4] = dolbfgippog2.OHCMCJHDMOH[1];
		}
		if (JKCCFILIICG)
		{
			dolbfgippog.OHCMCJHDMOH[7] = dolbfgippog2.OHCMCJHDMOH[7];
		}
		if (GIEOBIFBPPF)
		{
			dolbfgippog.OHCMCJHDMOH[8] = dolbfgippog2.OHCMCJHDMOH[4];
		}
		if (PHDIGHLMIKL)
		{
			dolbfgippog.OHCMCJHDMOH[7] = dolbfgippog2.OHCMCJHDMOH[4];
		}
	}

	// Token: 0x06005610 RID: 22032 RVA: 0x00264168 File Offset: 0x00262368
	public void LBFDCJNJCFN(int NMLGFACALEC)
	{
		bool flag;
		do
		{
			flag = true;
			for (int i = 0; i < this.BBGJMAAPFJD.Count; i++)
			{
				if (this.BBGJMAAPFJD[i] == NMLGFACALEC)
				{
					this.BBGJMAAPFJD.RemoveAt(i);
					this.CKNMLFPDGGH.RemoveAt(i);
					this.FGCBAGFHCDJ.RemoveAt(i);
					flag = false;
					break;
				}
			}
		}
		while (!flag);
	}

	// Token: 0x06005611 RID: 22033 RVA: 0x002641C8 File Offset: 0x002623C8
	public void PKBADCKFCAK(string KHJMANDEDMA)
	{
		if (this.OIBGFPEGLME == 0)
		{
			for (int i = 0; i < this.LKDEFKFLKDA.Count; i++)
			{
				if (this.LKDEFKFLKDA[i].Equals(KHJMANDEDMA))
				{
					this.LKDEFKFLKDA.RemoveAt(i);
					return;
				}
			}
			return;
		}
		if (this.OIBGFPEGLME == 1)
		{
			for (int j = 0; j < this.DOPPJBLBMMH.Count; j++)
			{
				if (this.DOPPJBLBMMH[j].Equals(KHJMANDEDMA))
				{
					this.DOPPJBLBMMH.RemoveAt(j);
					return;
				}
			}
			return;
		}
		if (this.OIBGFPEGLME == 2)
		{
			for (int k = 0; k < this.BJCNIHNCLLK.Count; k++)
			{
				if (this.BJCNIHNCLLK[k].Equals(KHJMANDEDMA))
				{
					this.BJCNIHNCLLK.RemoveAt(k);
					return;
				}
			}
			return;
		}
		DPGJIJGOCIC.ANOPFDLPKGC("StorySaveBody.UnhideAvatarComponent(), unsupported wardrobe index:" + this.OIBGFPEGLME.ToString());
	}

	// Token: 0x06005612 RID: 22034 RVA: 0x002642B1 File Offset: 0x002624B1
	public void NCPKDCADCAM(int MEFKFOHCOHK)
	{
		this.DMAGAHMIKDE = MEFKFOHCOHK;
	}

	// Token: 0x06005613 RID: 22035 RVA: 0x002642BC File Offset: 0x002624BC
	private string KNBPOLAFBIK(string MLDHIJBBDMF)
	{
		string result;
		try
		{
			if (MLDHIJBBDMF.StartsWith("CLIENT.AVATAR.CLOTHES"))
			{
				result = AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.OHODCBKFNGJ().OHCMCJHDMOH[2];
			}
			else if (MLDHIJBBDMF.StartsWith("CLIENT.AVATAR.TRINKET"))
			{
				result = AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.OHODCBKFNGJ().OHCMCJHDMOH[4];
			}
			else if (MLDHIJBBDMF.StartsWith("CLIENT.AVATAR.HAIR"))
			{
				result = AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.OHODCBKFNGJ().OHCMCJHDMOH[1];
			}
			else if (MLDHIJBBDMF.StartsWith("CLIENT.AVATAR.FACE"))
			{
				result = AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.OHODCBKFNGJ().OHCMCJHDMOH[3];
			}
			else if (MLDHIJBBDMF.StartsWith("CLIENT.AVATAR.BODY"))
			{
				result = AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.OHODCBKFNGJ().OHCMCJHDMOH[0];
			}
			else if (MLDHIJBBDMF.StartsWith("CLIENT.AVATAR.OVERLAY"))
			{
				result = AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.OHODCBKFNGJ().OHCMCJHDMOH[5];
			}
			else if (MLDHIJBBDMF.StartsWith("AVATAR.CLIENT.CLOTHES"))
			{
				result = AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.OHODCBKFNGJ().OHCMCJHDMOH[2];
			}
			else if (MLDHIJBBDMF.StartsWith("AVATAR.CLIENT.TRINKET"))
			{
				result = AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.OHODCBKFNGJ().OHCMCJHDMOH[4];
			}
			else if (MLDHIJBBDMF.StartsWith("AVATAR.CLIENT.HAIR"))
			{
				result = AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.OHODCBKFNGJ().OHCMCJHDMOH[1];
			}
			else if (MLDHIJBBDMF.StartsWith("AVATAR.CLIENT.FACE"))
			{
				result = AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.OHODCBKFNGJ().OHCMCJHDMOH[3];
			}
			else if (MLDHIJBBDMF.StartsWith("AVATAR.CLIENT.BODY"))
			{
				result = AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.OHODCBKFNGJ().OHCMCJHDMOH[0];
			}
			else if (MLDHIJBBDMF.StartsWith("AVATAR.CLIENT.OVERLAY"))
			{
				result = AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.OHODCBKFNGJ().OHCMCJHDMOH[5];
			}
			else
			{
				bool flag = false;
				int i = 5;
				string text = MLDHIJBBDMF;
				while (i > 0)
				{
					i--;
					for (int j = 0; j < this.EJNFKIJNJGE.Count; j++)
					{
						if (this.EJNFKIJNJGE[j].Equals(text))
						{
							text = this.CJKGOKAGKHJ[j];
							flag = true;
							break;
						}
					}
				}
				if (flag)
				{
					result = text;
				}
				else
				{
					string text2 = DPGJIJGOCIC.OADMDNKCDCN(MLDHIJBBDMF, "");
					if (!text2.Equals(MLDHIJBBDMF))
					{
						flag = false;
						i = 5;
						text = text2;
						while (i > 0)
						{
							i--;
							for (int k = 0; k < this.EJNFKIJNJGE.Count; k++)
							{
								if (this.EJNFKIJNJGE[k].Equals(text))
								{
									text = this.CJKGOKAGKHJ[k];
									flag = true;
									break;
								}
							}
						}
						if (flag)
						{
							return text;
						}
					}
					if (MLDHIJBBDMF.Contains("+"))
					{
						flag = false;
						i = 5;
						text = MLDHIJBBDMF.Substring(0, MLDHIJBBDMF.IndexOf("+"));
						while (i > 0)
						{
							i--;
							for (int l = 0; l < this.EJNFKIJNJGE.Count; l++)
							{
								if (this.EJNFKIJNJGE[l].Equals(text))
								{
									text = this.CJKGOKAGKHJ[l];
									flag = true;
									break;
								}
							}
						}
						if (flag)
						{
							return text;
						}
					}
					result = MLDHIJBBDMF;
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
			result = MLDHIJBBDMF;
		}
		return result;
	}

	// Token: 0x06005614 RID: 22036 RVA: 0x0025DEB2 File Offset: 0x0025C0B2
	public int LMCJOCDIJGP()
	{
		return this.FPJPHNLANPG;
	}

	// Token: 0x06005615 RID: 22037 RVA: 0x0025E612 File Offset: 0x0025C812
	public int HEFOPKOFLBG()
	{
		return this.PLLBNICNBKJ;
	}

	// Token: 0x06005616 RID: 22038 RVA: 0x0026466C File Offset: 0x0026286C
	public void HLPMCCEDBLF(string KHJMANDEDMA)
	{
		if (this.OIBGFPEGLME == 0)
		{
			bool flag;
			do
			{
				flag = true;
				for (int i = 0; i < this.IMALACBMOFC.Count; i++)
				{
					if (this.IMALACBMOFC[i].Equals(KHJMANDEDMA))
					{
						this.IMALACBMOFC.RemoveAt(i);
						this.GNHBHIALAAH.RemoveAt(i);
						flag = false;
						break;
					}
				}
			}
			while (!flag);
			return;
		}
		if (this.OIBGFPEGLME == 1)
		{
			bool flag2;
			do
			{
				flag2 = true;
				for (int j = 0; j < this.KPEIEHDJIOP.Count; j++)
				{
					if (this.KPEIEHDJIOP[j].Equals(KHJMANDEDMA))
					{
						this.KPEIEHDJIOP.RemoveAt(j);
						this.JAJJFPNIBGI.RemoveAt(j);
						flag2 = false;
						break;
					}
				}
			}
			while (!flag2);
			return;
		}
		if (this.OIBGFPEGLME == 2)
		{
			bool flag3;
			do
			{
				flag3 = true;
				for (int k = 0; k < this.NLPNFGNMGMP.Count; k++)
				{
					if (this.NLPNFGNMGMP[k].Equals(KHJMANDEDMA))
					{
						this.NLPNFGNMGMP.RemoveAt(k);
						this.FCOLLNPADDA.RemoveAt(k);
						flag3 = false;
						break;
					}
				}
			}
			while (!flag3);
			return;
		}
		DPGJIJGOCIC.ANOPFDLPKGC("StorySaveBody.RemoveAvatarComponent(), unsupported wardrobe index:" + this.OIBGFPEGLME.ToString());
	}

	// Token: 0x06005617 RID: 22039 RVA: 0x0026479C File Offset: 0x0026299C
	public void FGJPKGLOGNC(JSONObject EIHOJFGALMF, bool DDLCOIHJKCJ)
	{
		this.GGICIBLJIKI = EIHOJFGALMF["ind"].AsInt;
		if (this.GGICIBLJIKI >= 0)
		{
			try
			{
				this.HLGDMBAINDE = EIHOJFGALMF["ink"];
				if (this.HLGDMBAINDE == null)
				{
					this.HLGDMBAINDE = "";
				}
				else
				{
					this.HLGDMBAINDE = DPGJIJGOCIC.LMCAODJLEGF(this.HLGDMBAINDE);
				}
			}
			catch (Exception aklgbjkdomm)
			{
				DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
			}
			try
			{
				this.DJIGFDJOHCI = EIHOJFGALMF["pov"];
				if (this.DJIGFDJOHCI == null)
				{
					this.DJIGFDJOHCI = "";
				}
			}
			catch (Exception aklgbjkdomm2)
			{
				DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm2);
			}
			try
			{
				this.IBFLNCMCKAL = EIHOJFGALMF["env"];
				if (this.IBFLNCMCKAL == null)
				{
					this.IBFLNCMCKAL = "";
				}
			}
			catch (Exception aklgbjkdomm3)
			{
				DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm3);
			}
			try
			{
				this.KFAOJHHLBHK = EIHOJFGALMF["envs"];
				if (this.KFAOJHHLBHK == null)
				{
					this.KFAOJHHLBHK = "";
				}
			}
			catch (Exception aklgbjkdomm4)
			{
				DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm4);
			}
			try
			{
				this.FODGKMIIHFO = EIHOJFGALMF["amb"];
				if (this.FODGKMIIHFO == null)
				{
					this.FODGKMIIHFO = "";
				}
			}
			catch (Exception aklgbjkdomm5)
			{
				DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm5);
			}
			try
			{
				this.FONKDFDJFEL = EIHOJFGALMF["mus"];
				if (this.FONKDFDJFEL == null)
				{
					this.FONKDFDJFEL = "";
				}
			}
			catch (Exception aklgbjkdomm6)
			{
				DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm6);
			}
			try
			{
				this.GOPGELMBMMK = EIHOJFGALMF["chtopn"];
				if (this.GOPGELMBMMK == null)
				{
					this.GOPGELMBMMK = "";
				}
				else
				{
					this.GOPGELMBMMK = DPGJIJGOCIC.LMCAODJLEGF(this.GOPGELMBMMK);
				}
			}
			catch (Exception aklgbjkdomm7)
			{
				DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm7);
			}
			try
			{
				this.HPAEFOJDLFC = EIHOJFGALMF["chtmet"];
				if (this.HPAEFOJDLFC == null)
				{
					this.HPAEFOJDLFC = "";
				}
				else
				{
					this.HPAEFOJDLFC = DPGJIJGOCIC.LMCAODJLEGF(this.HPAEFOJDLFC);
				}
			}
			catch (Exception aklgbjkdomm8)
			{
				DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm8);
			}
			try
			{
				this.JMNMOHIKHLB = EIHOJFGALMF["cmeta"];
				if (this.JMNMOHIKHLB == null)
				{
					this.JMNMOHIKHLB = "";
				}
				else
				{
					this.JMNMOHIKHLB = DPGJIJGOCIC.LMCAODJLEGF(this.JMNMOHIKHLB);
				}
			}
			catch (Exception aklgbjkdomm9)
			{
				DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm9);
			}
			try
			{
				this.JGEDOIDOPLA = EIHOJFGALMF["cmetaotm"];
				if (this.JGEDOIDOPLA == null)
				{
					this.JGEDOIDOPLA = "";
				}
				else
				{
					this.JGEDOIDOPLA = DPGJIJGOCIC.LMCAODJLEGF(this.JGEDOIDOPLA);
				}
			}
			catch (Exception aklgbjkdomm10)
			{
				DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm10);
			}
			try
			{
				this.FBKMADGCEBN.Clear();
				if (EIHOJFGALMF["veff"] != null)
				{
					JSONArray asArray = EIHOJFGALMF["veff"].AsArray;
					for (int i = 0; i < asArray.Count; i++)
					{
						this.FBKMADGCEBN.Add(asArray[i]);
					}
				}
			}
			catch (Exception aklgbjkdomm11)
			{
				DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm11);
			}
			try
			{
				this.NIJBAMNFJLM.Clear();
				if (EIHOJFGALMF["evar"] != null)
				{
					JSONArray asArray2 = EIHOJFGALMF["evar"].AsArray;
					for (int j = 0; j < asArray2.Count; j++)
					{
						this.NIJBAMNFJLM.Add(asArray2[j]);
					}
				}
			}
			catch (Exception aklgbjkdomm12)
			{
				DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm12);
			}
			try
			{
				this.ECAHHCAGMKM.Clear();
				if (EIHOJFGALMF["eval"] != null)
				{
					JSONArray asArray3 = EIHOJFGALMF["eval"].AsArray;
					for (int k = 0; k < asArray3.Count; k++)
					{
						this.ECAHHCAGMKM.Add(DPGJIJGOCIC.LMCAODJLEGF(asArray3[k]));
					}
				}
			}
			catch (Exception aklgbjkdomm13)
			{
				DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm13);
			}
			try
			{
				List<string> hohelaomlgl = this.HOHELAOMLGL;
				this.NKBJGFECFPN();
				if (DDLCOIHJKCJ && EIHOJFGALMF["lsn"] == null && hohelaomlgl != null)
				{
					this.HOHELAOMLGL = hohelaomlgl;
				}
				if (EIHOJFGALMF["lsc"] != null)
				{
					this.NHFMGEABCKP = EIHOJFGALMF["lsc"].AsInt;
				}
				if (EIHOJFGALMF["lsvn"] != null && EIHOJFGALMF["lsvv"] != null)
				{
					JSONArray asArray4 = EIHOJFGALMF["lsvn"].AsArray;
					JSONArray asArray5 = EIHOJFGALMF["lsvv"].AsArray;
					int num = 0;
					while (num < asArray4.Count && num < asArray5.Count)
					{
						int item = 0;
						if (int.TryParse(asArray5[num], out item))
						{
							this.NJEPIPLACPC.Add(asArray4[num]);
							this.CFFGADJPBLO.Add(item);
						}
						num++;
					}
				}
				if (EIHOJFGALMF["lstm"] != null)
				{
					this.EIEIDFBDPKO = EIHOJFGALMF["lstm"];
				}
				if (EIHOJFGALMF["lsw"] != null)
				{
					JSONArray asArray6 = EIHOJFGALMF["lsw"].AsArray;
					for (int l = 0; l < asArray6.Count; l++)
					{
						int num2 = 0;
						if (int.TryParse(asArray6[l], out num2) && num2 >= 0 && !this.GNPAKEFPGPB.Contains(num2))
						{
							this.GNPAKEFPGPB.Add(num2);
						}
					}
				}
				if (DDLCOIHJKCJ && EIHOJFGALMF["lsn"] != null)
				{
					JSONArray asArray7 = EIHOJFGALMF["lsn"].AsArray;
					for (int m = 0; m < asArray7.Count; m++)
					{
						string text = asArray7[m];
						if (text != null && text.Length > 0 && !this.HOHELAOMLGL.Contains(text))
						{
							this.HOHELAOMLGL.Add(text);
						}
					}
				}
			}
			catch (Exception aklgbjkdomm14)
			{
				DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm14);
			}
			try
			{
				this.EJNFKIJNJGE.Clear();
				if (EIHOJFGALMF["msrc"] != null)
				{
					JSONArray asArray8 = EIHOJFGALMF["msrc"].AsArray;
					for (int n = 0; n < asArray8.Count; n++)
					{
						this.EJNFKIJNJGE.Add(asArray8[n]);
					}
				}
			}
			catch (Exception aklgbjkdomm15)
			{
				DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm15);
			}
			try
			{
				this.CJKGOKAGKHJ.Clear();
				if (EIHOJFGALMF["mdst"] != null)
				{
					JSONArray asArray9 = EIHOJFGALMF["mdst"].AsArray;
					for (int num3 = 0; num3 < asArray9.Count; num3++)
					{
						this.CJKGOKAGKHJ.Add(asArray9[num3]);
					}
				}
			}
			catch (Exception aklgbjkdomm16)
			{
				DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm16);
			}
			try
			{
				this.CJDBDOHPHLG.Clear();
				if (EIHOJFGALMF["smsrc"] != null)
				{
					JSONArray asArray10 = EIHOJFGALMF["smsrc"].AsArray;
					for (int num4 = 0; num4 < asArray10.Count; num4++)
					{
						this.CJDBDOHPHLG.Add(asArray10[num4]);
					}
				}
			}
			catch (Exception aklgbjkdomm17)
			{
				DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm17);
			}
			try
			{
				this.JOJKAIBEPGH.Clear();
				if (EIHOJFGALMF["smdst"] != null)
				{
					JSONArray asArray11 = EIHOJFGALMF["smdst"].AsArray;
					for (int num5 = 0; num5 < asArray11.Count; num5++)
					{
						this.JOJKAIBEPGH.Add(asArray11[num5]);
					}
				}
				this.PIDOECCJOCI.Clear();
				this.NJKHOCABBGL.Clear();
				if (EIHOJFGALMF["smps"] != null && EIHOJFGALMF["smpd"] != null)
				{
					JSONArray asArray12 = EIHOJFGALMF["smps"].AsArray;
					JSONArray asArray13 = EIHOJFGALMF["smpd"].AsArray;
					int num6 = 0;
					while (num6 < asArray12.Count && num6 < asArray13.Count)
					{
						this.PIDOECCJOCI.Add(asArray12[num6]);
						this.NJKHOCABBGL.Add(asArray13[num6]);
						num6++;
					}
				}
			}
			catch (Exception aklgbjkdomm18)
			{
				DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm18);
			}
			try
			{
				this.PIMEHAPFCHC.Clear();
				if (EIHOJFGALMF["envls"] != null)
				{
					JSONArray asArray14 = EIHOJFGALMF["envls"].AsArray;
					for (int num7 = 0; num7 < asArray14.Count; num7++)
					{
						this.PIMEHAPFCHC.Add(asArray14[num7]);
					}
				}
			}
			catch (Exception aklgbjkdomm19)
			{
				DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm19);
			}
			try
			{
				this.GIHCENHPGPD.Clear();
				if (EIHOJFGALMF["envlsp"] != null)
				{
					JSONArray asArray15 = EIHOJFGALMF["envlsp"].AsArray;
					for (int num8 = 0; num8 < asArray15.Count; num8++)
					{
						this.GIHCENHPGPD.Add(asArray15[num8]);
					}
				}
			}
			catch (Exception aklgbjkdomm20)
			{
				DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm20);
			}
			try
			{
				this.HPFHJEAFIHI.Clear();
				if (EIHOJFGALMF["envlh"] != null)
				{
					JSONArray asArray16 = EIHOJFGALMF["envlh"].AsArray;
					for (int num9 = 0; num9 < asArray16.Count; num9++)
					{
						this.HPFHJEAFIHI.Add(asArray16[num9]);
					}
				}
			}
			catch (Exception aklgbjkdomm21)
			{
				DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm21);
			}
			try
			{
				this.OJJHCAGFPOC.Clear();
				if (EIHOJFGALMF["envlhp"] != null)
				{
					JSONArray asArray17 = EIHOJFGALMF["envlhp"].AsArray;
					for (int num10 = 0; num10 < asArray17.Count; num10++)
					{
						this.OJJHCAGFPOC.Add(asArray17[num10]);
					}
				}
			}
			catch (Exception aklgbjkdomm22)
			{
				DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm22);
			}
			try
			{
				this.OKJJPNPGLEL.Clear();
				if (EIHOJFGALMF["envlsrw"] != null)
				{
					JSONArray asArray18 = EIHOJFGALMF["envlsrw"].AsArray;
					for (int num11 = 0; num11 < asArray18.Count; num11++)
					{
						this.OKJJPNPGLEL.Add(asArray18[num11]);
					}
				}
			}
			catch (Exception aklgbjkdomm23)
			{
				DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm23);
			}
			try
			{
				this.ONGBBOHGKLO.Clear();
				if (EIHOJFGALMF["envlhrw"] != null)
				{
					JSONArray asArray19 = EIHOJFGALMF["envlhrw"].AsArray;
					for (int num12 = 0; num12 < asArray19.Count; num12++)
					{
						this.ONGBBOHGKLO.Add(asArray19[num12]);
					}
				}
			}
			catch (Exception aklgbjkdomm24)
			{
				DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm24);
			}
			try
			{
				this.OGIHMIOKCNN.Clear();
				if (EIHOJFGALMF["envlsav"] != null)
				{
					JSONArray asArray20 = EIHOJFGALMF["envlsav"].AsArray;
					for (int num13 = 0; num13 < asArray20.Count; num13++)
					{
						this.OGIHMIOKCNN.Add(asArray20[num13]);
					}
				}
			}
			catch (Exception aklgbjkdomm25)
			{
				DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm25);
			}
			try
			{
				this.IANINGLKCKB.Clear();
				if (EIHOJFGALMF["envlhav"] != null)
				{
					JSONArray asArray21 = EIHOJFGALMF["envlhav"].AsArray;
					for (int num14 = 0; num14 < asArray21.Count; num14++)
					{
						this.IANINGLKCKB.Add(asArray21[num14]);
					}
				}
			}
			catch (Exception aklgbjkdomm26)
			{
				DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm26);
			}
			try
			{
				this.BNPGFECDNAM.Clear();
				if (EIHOJFGALMF["scki2"] != null)
				{
					JSONArray asArray22 = EIHOJFGALMF["scki2"].AsArray;
					for (int num15 = 0; num15 < asArray22.Count; num15++)
					{
						this.BNPGFECDNAM.Add(asArray22[num15]);
					}
				}
			}
			catch (Exception aklgbjkdomm27)
			{
				DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm27);
			}
			try
			{
				this.HIEEGGEJEEG.Clear();
				if (EIHOJFGALMF["sckv2"] != null)
				{
					JSONArray asArray23 = EIHOJFGALMF["sckv2"].AsArray;
					for (int num16 = 0; num16 < asArray23.Count; num16++)
					{
						this.HIEEGGEJEEG.Add(asArray23[num16]);
					}
				}
			}
			catch (Exception aklgbjkdomm28)
			{
				DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm28);
			}
			try
			{
				this.ECKKHMDIELD.Clear();
				if (EIHOJFGALMF["cmec"] != null)
				{
					JSONArray asArray24 = EIHOJFGALMF["cmec"].AsArray;
					for (int num17 = 0; num17 < asArray24.Count; num17++)
					{
						this.ECKKHMDIELD.Add(asArray24[num17]);
					}
				}
			}
			catch (Exception aklgbjkdomm29)
			{
				DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm29);
			}
			try
			{
				this.KIDPANPCBFF.Clear();
				if (EIHOJFGALMF["npcp"] != null)
				{
					JSONArray asArray25 = EIHOJFGALMF["npcp"].AsArray;
					for (int num18 = 0; num18 < asArray25.Count; num18++)
					{
						this.KIDPANPCBFF.Add(asArray25[num18]);
					}
				}
			}
			catch (Exception aklgbjkdomm30)
			{
				DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm30);
			}
			try
			{
				this.GIAEIAOBHEK.Clear();
				if (EIHOJFGALMF["npcpi"] != null)
				{
					JSONArray asArray26 = EIHOJFGALMF["npcpi"].AsArray;
					for (int num19 = 0; num19 < asArray26.Count; num19++)
					{
						this.GIAEIAOBHEK.Add(asArray26[num19]);
					}
				}
			}
			catch (Exception aklgbjkdomm31)
			{
				DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm31);
			}
			try
			{
				this.IMALACBMOFC.Clear();
				if (EIHOJFGALMF["acomp"] != null)
				{
					JSONArray asArray27 = EIHOJFGALMF["acomp"].AsArray;
					for (int num20 = 0; num20 < asArray27.Count; num20++)
					{
						this.IMALACBMOFC.Add(asArray27[num20]);
					}
				}
			}
			catch (Exception aklgbjkdomm32)
			{
				DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm32);
			}
			try
			{
				this.KPEIEHDJIOP.Clear();
				if (EIHOJFGALMF["acomp1"] != null)
				{
					JSONArray asArray28 = EIHOJFGALMF["acomp1"].AsArray;
					for (int num21 = 0; num21 < asArray28.Count; num21++)
					{
						this.KPEIEHDJIOP.Add(asArray28[num21]);
					}
				}
			}
			catch (Exception aklgbjkdomm33)
			{
				DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm33);
			}
			try
			{
				this.NLPNFGNMGMP.Clear();
				if (EIHOJFGALMF["acomp2"] != null)
				{
					JSONArray asArray29 = EIHOJFGALMF["acomp2"].AsArray;
					for (int num22 = 0; num22 < asArray29.Count; num22++)
					{
						this.NLPNFGNMGMP.Add(asArray29[num22]);
					}
				}
			}
			catch (Exception aklgbjkdomm34)
			{
				DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm34);
			}
			try
			{
				this.LKDEFKFLKDA.Clear();
				if (EIHOJFGALMF["hacomp"] != null)
				{
					JSONArray asArray30 = EIHOJFGALMF["hacomp"].AsArray;
					for (int num23 = 0; num23 < asArray30.Count; num23++)
					{
						this.LKDEFKFLKDA.Add(asArray30[num23]);
					}
				}
			}
			catch (Exception aklgbjkdomm35)
			{
				DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm35);
			}
			try
			{
				this.DOPPJBLBMMH.Clear();
				if (EIHOJFGALMF["hacomp1"] != null)
				{
					JSONArray asArray31 = EIHOJFGALMF["hacomp1"].AsArray;
					for (int num24 = 0; num24 < asArray31.Count; num24++)
					{
						this.DOPPJBLBMMH.Add(asArray31[num24]);
					}
				}
			}
			catch (Exception aklgbjkdomm36)
			{
				DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm36);
			}
			try
			{
				this.BJCNIHNCLLK.Clear();
				if (EIHOJFGALMF["hacomp2"] != null)
				{
					JSONArray asArray32 = EIHOJFGALMF["hacomp2"].AsArray;
					for (int num25 = 0; num25 < asArray32.Count; num25++)
					{
						this.BJCNIHNCLLK.Add(asArray32[num25]);
					}
				}
			}
			catch (Exception aklgbjkdomm37)
			{
				DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm37);
			}
			try
			{
				this.BKDDGKMIGPG.Clear();
				if (EIHOJFGALMF["apkshe"] != null)
				{
					JSONArray asArray33 = EIHOJFGALMF["apkshe"].AsArray;
					for (int num26 = 0; num26 < asArray33.Count; num26++)
					{
						this.BKDDGKMIGPG.Add(asArray33[num26].AsInt);
					}
				}
			}
			catch (Exception aklgbjkdomm38)
			{
				DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm38);
			}
			try
			{
				this.OCJFDPNJIPD.Clear();
				if (EIHOJFGALMF["apkshe1"] != null)
				{
					JSONArray asArray34 = EIHOJFGALMF["apkshe1"].AsArray;
					for (int num27 = 0; num27 < asArray34.Count; num27++)
					{
						this.OCJFDPNJIPD.Add(asArray34[num27].AsInt);
					}
				}
			}
			catch (Exception aklgbjkdomm39)
			{
				DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm39);
			}
			try
			{
				this.KHPENKNONJO.Clear();
				if (EIHOJFGALMF["apkshe2"] != null)
				{
					JSONArray asArray35 = EIHOJFGALMF["apkshe2"].AsArray;
					for (int num28 = 0; num28 < asArray35.Count; num28++)
					{
						this.KHPENKNONJO.Add(asArray35[num28].AsInt);
					}
				}
			}
			catch (Exception aklgbjkdomm40)
			{
				DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm40);
			}
			try
			{
				this.GNHBHIALAAH.Clear();
				if (EIHOJFGALMF["apks"] != null)
				{
					JSONArray asArray36 = EIHOJFGALMF["apks"].AsArray;
					for (int num29 = 0; num29 < asArray36.Count; num29++)
					{
						this.GNHBHIALAAH.Add(asArray36[num29].AsInt);
					}
				}
			}
			catch (Exception aklgbjkdomm41)
			{
				DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm41);
			}
			try
			{
				this.JAJJFPNIBGI.Clear();
				if (EIHOJFGALMF["apks1"] != null)
				{
					JSONArray asArray37 = EIHOJFGALMF["apks1"].AsArray;
					for (int num30 = 0; num30 < asArray37.Count; num30++)
					{
						this.JAJJFPNIBGI.Add(asArray37[num30].AsInt);
					}
				}
			}
			catch (Exception aklgbjkdomm42)
			{
				DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm42);
			}
			try
			{
				this.FCOLLNPADDA.Clear();
				if (EIHOJFGALMF["apks2"] != null)
				{
					JSONArray asArray38 = EIHOJFGALMF["apks2"].AsArray;
					for (int num31 = 0; num31 < asArray38.Count; num31++)
					{
						this.FCOLLNPADDA.Add(asArray38[num31].AsInt);
					}
				}
			}
			catch (Exception aklgbjkdomm43)
			{
				DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm43);
			}
			try
			{
				this.PNBPEAFMKAC.Clear();
				if (EIHOJFGALMF["acli20"] != null)
				{
					JSONArray asArray39 = EIHOJFGALMF["acli20"].AsArray;
					for (int num32 = 0; num32 < asArray39.Count; num32++)
					{
						this.PNBPEAFMKAC.Add(asArray39[num32].AsInt);
					}
				}
			}
			catch (Exception aklgbjkdomm44)
			{
				DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm44);
			}
			try
			{
				this.DMKOGCBMHKA.Clear();
				if (EIHOJFGALMF["acli21"] != null)
				{
					JSONArray asArray40 = EIHOJFGALMF["acli21"].AsArray;
					for (int num33 = 0; num33 < asArray40.Count; num33++)
					{
						this.DMKOGCBMHKA.Add(asArray40[num33].AsInt);
					}
				}
			}
			catch (Exception aklgbjkdomm45)
			{
				DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm45);
			}
			try
			{
				this.NGJDCAEMEJO.Clear();
				if (EIHOJFGALMF["acli22"] != null)
				{
					JSONArray asArray41 = EIHOJFGALMF["acli22"].AsArray;
					for (int num34 = 0; num34 < asArray41.Count; num34++)
					{
						this.NGJDCAEMEJO.Add(asArray41[num34].AsInt);
					}
				}
			}
			catch (Exception aklgbjkdomm46)
			{
				DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm46);
			}
			try
			{
				this.BBGJMAAPFJD.Clear();
				if (EIHOJFGALMF["aspks"] != null)
				{
					JSONArray asArray42 = EIHOJFGALMF["aspks"].AsArray;
					for (int num35 = 0; num35 < asArray42.Count; num35++)
					{
						this.BBGJMAAPFJD.Add(asArray42[num35].AsInt);
					}
				}
			}
			catch (Exception aklgbjkdomm47)
			{
				DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm47);
			}
			try
			{
				this.CKNMLFPDGGH.Clear();
				if (EIHOJFGALMF["aspkss"] != null)
				{
					JSONArray asArray43 = EIHOJFGALMF["aspkss"].AsArray;
					for (int num36 = 0; num36 < asArray43.Count; num36++)
					{
						this.CKNMLFPDGGH.Add(asArray43[num36].AsInt);
					}
				}
			}
			catch (Exception aklgbjkdomm48)
			{
				DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm48);
			}
			try
			{
				this.FGCBAGFHCDJ.Clear();
				if (EIHOJFGALMF["aspksk"] != null)
				{
					JSONArray asArray44 = EIHOJFGALMF["aspksk"].AsArray;
					for (int num37 = 0; num37 < asArray44.Count; num37++)
					{
						this.FGCBAGFHCDJ.Add(asArray44[num37].AsInt);
					}
				}
			}
			catch (Exception aklgbjkdomm49)
			{
				DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm49);
			}
			try
			{
				if (DDLCOIHJKCJ)
				{
					this.IMJDADKEEJC = null;
					if (EIHOJFGALMF["snaprew"] != null)
					{
						this.IMJDADKEEJC = new JSONObject();
						this.IMJDADKEEJC = EIHOJFGALMF["snaprew"].AsObject;
					}
					this.FEDCIMMIJCI = 0;
					if (EIHOJFGALMF["trewsnap"] != null)
					{
						this.FEDCIMMIJCI = EIHOJFGALMF["trewsnap"].AsInt;
					}
					this.DNMPCOHNAHO = new List<string>();
					if (EIHOJFGALMF["lrewsnap"] != null)
					{
						this.DNMPCOHNAHO = DPGJIJGOCIC.POHBFGLLKFD(EIHOJFGALMF["lrewsnap"].AsArray);
					}
				}
			}
			catch (Exception aklgbjkdomm50)
			{
				DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm50);
			}
			try
			{
				this.LGKPNNGIPEG = new JSONObject();
				if (EIHOJFGALMF["snap"] != null)
				{
					this.LGKPNNGIPEG = EIHOJFGALMF["snap"].AsObject;
				}
			}
			catch (Exception aklgbjkdomm51)
			{
				DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm51);
			}
			try
			{
				this.EBFMKGPBEBO = new JSONObject();
				if (EIHOJFGALMF["snapundo"] != null)
				{
					this.EBFMKGPBEBO = EIHOJFGALMF["snapundo"].AsObject;
				}
			}
			catch (Exception aklgbjkdomm52)
			{
				DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm52);
			}
			try
			{
				this.KKJBJEOCAFF = new List<JCAJMGJFHBD>();
				if (EIHOJFGALMF["chtss"] != null)
				{
					JSONArray asArray45 = EIHOJFGALMF["chtss"].AsArray;
					for (int num38 = 0; num38 < asArray45.Count; num38++)
					{
						JCAJMGJFHBD jcajmgjfhbd = new JCAJMGJFHBD();
						jcajmgjfhbd.FGJPKGLOGNC(asArray45[num38].AsObject);
						this.KKJBJEOCAFF.Add(jcajmgjfhbd);
					}
				}
			}
			catch (Exception aklgbjkdomm53)
			{
				DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm53);
			}
			try
			{
				this.GJCCMMMHIPI = new List<JCAJMGJFHBD>();
				if (EIHOJFGALMF["chtssp"] != null)
				{
					JSONArray asArray46 = EIHOJFGALMF["chtssp"].AsArray;
					for (int num39 = 0; num39 < asArray46.Count; num39++)
					{
						JCAJMGJFHBD jcajmgjfhbd2 = new JCAJMGJFHBD();
						jcajmgjfhbd2.FGJPKGLOGNC(asArray46[num39].AsObject);
						this.GJCCMMMHIPI.Add(jcajmgjfhbd2);
					}
				}
			}
			catch (Exception aklgbjkdomm54)
			{
				DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm54);
			}
			try
			{
				this.IEPMNCAKNBM = new List<DOLBFGIPPOG>();
				if (EIHOJFGALMF["avts"] != null)
				{
					JSONArray asArray47 = EIHOJFGALMF["avts"].AsArray;
					for (int num40 = 0; num40 < asArray47.Count; num40++)
					{
						DOLBFGIPPOG dolbfgippog = new DOLBFGIPPOG();
						dolbfgippog.FGJPKGLOGNC(asArray47[num40].AsObject);
						this.IEPMNCAKNBM.Add(dolbfgippog);
					}
				}
			}
			catch (Exception aklgbjkdomm55)
			{
				DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm55);
			}
			try
			{
				this.EBONDOEPONH = new List<DOLBFGIPPOG>();
				if (EIHOJFGALMF["avts1"] != null)
				{
					JSONArray asArray48 = EIHOJFGALMF["avts1"].AsArray;
					for (int num41 = 0; num41 < asArray48.Count; num41++)
					{
						DOLBFGIPPOG dolbfgippog2 = new DOLBFGIPPOG();
						dolbfgippog2.FGJPKGLOGNC(asArray48[num41].AsObject);
						this.EBONDOEPONH.Add(dolbfgippog2);
					}
				}
			}
			catch (Exception aklgbjkdomm56)
			{
				DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm56);
			}
			try
			{
				this.AOJIJHAKNPG = new List<DOLBFGIPPOG>();
				if (EIHOJFGALMF["avts2"] != null)
				{
					JSONArray asArray49 = EIHOJFGALMF["avts2"].AsArray;
					for (int num42 = 0; num42 < asArray49.Count; num42++)
					{
						DOLBFGIPPOG dolbfgippog3 = new DOLBFGIPPOG();
						dolbfgippog3.FGJPKGLOGNC(asArray49[num42].AsObject);
						this.AOJIJHAKNPG.Add(dolbfgippog3);
					}
				}
			}
			catch (Exception aklgbjkdomm57)
			{
				DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm57);
			}
			try
			{
				this.LKIKIJACCMF = new List<DOLBFGIPPOG>();
				if (EIHOJFGALMF["avtssnap"] != null)
				{
					JSONArray asArray50 = EIHOJFGALMF["avtssnap"].AsArray;
					for (int num43 = 0; num43 < asArray50.Count; num43++)
					{
						DOLBFGIPPOG dolbfgippog4 = new DOLBFGIPPOG();
						dolbfgippog4.FGJPKGLOGNC(asArray50[num43].AsObject);
						if (!dolbfgippog4.DLJLJNBFHBG())
						{
							this.LKIKIJACCMF.Add(dolbfgippog4);
						}
					}
				}
			}
			catch (Exception aklgbjkdomm58)
			{
				DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm58);
			}
			try
			{
				this.ONJMAJAFFKN = new List<DOLBFGIPPOG>();
				if (EIHOJFGALMF["avtssnap1"] != null)
				{
					JSONArray asArray51 = EIHOJFGALMF["avtssnap1"].AsArray;
					for (int num44 = 0; num44 < asArray51.Count; num44++)
					{
						DOLBFGIPPOG dolbfgippog5 = new DOLBFGIPPOG();
						dolbfgippog5.FGJPKGLOGNC(asArray51[num44].AsObject);
						if (!dolbfgippog5.DLJLJNBFHBG())
						{
							this.ONJMAJAFFKN.Add(dolbfgippog5);
						}
					}
				}
			}
			catch (Exception aklgbjkdomm59)
			{
				DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm59);
			}
			try
			{
				this.NDMIJFLDKKN = new List<DOLBFGIPPOG>();
				if (EIHOJFGALMF["avtssnap2"] != null)
				{
					JSONArray asArray52 = EIHOJFGALMF["avtssnap2"].AsArray;
					for (int num45 = 0; num45 < asArray52.Count; num45++)
					{
						DOLBFGIPPOG dolbfgippog6 = new DOLBFGIPPOG();
						dolbfgippog6.FGJPKGLOGNC(asArray52[num45].AsObject);
						if (!dolbfgippog6.DLJLJNBFHBG())
						{
							this.NDMIJFLDKKN.Add(dolbfgippog6);
						}
					}
				}
			}
			catch (Exception aklgbjkdomm60)
			{
				DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm60);
			}
			try
			{
				this.JCANELJMOCA = new List<DOLBFGIPPOG>();
				if (EIHOJFGALMF["anpcs"] != null)
				{
					JSONArray asArray53 = EIHOJFGALMF["anpcs"].AsArray;
					for (int num46 = 0; num46 < asArray53.Count; num46++)
					{
						DOLBFGIPPOG dolbfgippog7 = new DOLBFGIPPOG();
						dolbfgippog7.FGJPKGLOGNC(asArray53[num46].AsObject);
						this.JCANELJMOCA.Add(dolbfgippog7);
					}
				}
			}
			catch (Exception aklgbjkdomm61)
			{
				DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm61);
			}
			try
			{
				this.LDECHKECBHB = 0;
				if (EIHOJFGALMF["epos"] != null)
				{
					this.LDECHKECBHB = EIHOJFGALMF["epos"].AsInt;
				}
			}
			catch (Exception aklgbjkdomm62)
			{
				DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm62);
			}
			try
			{
				this.ONNHAPFMDEN = 0;
				if (EIHOJFGALMF["eposv"] != null)
				{
					this.ONNHAPFMDEN = EIHOJFGALMF["eposv"].AsInt;
				}
			}
			catch (Exception aklgbjkdomm63)
			{
				DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm63);
			}
			try
			{
				this.CHHLDEBHDPE = 0f;
				if (EIHOJFGALMF["lcdp"] != null)
				{
					float num47 = (float)EIHOJFGALMF["lcdp"].AsInt;
					this.CHHLDEBHDPE = num47 / 100f;
				}
			}
			catch (Exception aklgbjkdomm64)
			{
				DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm64);
			}
			try
			{
				this.NPAFPMIMGLH = 1f;
				if (EIHOJFGALMF["musvol"] != null)
				{
					float num48 = (float)EIHOJFGALMF["musvol"].AsInt;
					this.NPAFPMIMGLH = num48 / 100f;
				}
			}
			catch (Exception aklgbjkdomm65)
			{
				DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm65);
			}
			try
			{
				this.CFOHHKJPJPA = 0;
				if (EIHOJFGALMF["sia"] != null)
				{
					this.CFOHHKJPJPA = EIHOJFGALMF["sia"].AsInt;
				}
			}
			catch (Exception aklgbjkdomm66)
			{
				DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm66);
			}
			try
			{
				this.ALLDBPCKMLF = 0;
				if (EIHOJFGALMF["shnts"] != null)
				{
					this.ALLDBPCKMLF = EIHOJFGALMF["shnts"].AsInt;
				}
			}
			catch (Exception aklgbjkdomm67)
			{
				DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm67);
			}
			try
			{
				this.NIBNMKJIMAD = 0;
				if (EIHOJFGALMF["chata"] != null)
				{
					this.NIBNMKJIMAD = EIHOJFGALMF["chata"].AsInt;
				}
			}
			catch (Exception aklgbjkdomm68)
			{
				DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm68);
			}
			try
			{
				this.KNOFDJKKPMK = "";
				if (EIHOJFGALMF["chass"] != null)
				{
					this.KNOFDJKKPMK = EIHOJFGALMF["chass"];
				}
			}
			catch (Exception aklgbjkdomm69)
			{
				DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm69);
			}
			try
			{
				this.IMIDHJMEGOG = EIHOJFGALMF["dlng"];
				if (this.IMIDHJMEGOG == null)
				{
					this.IMIDHJMEGOG = "en";
				}
			}
			catch (Exception aklgbjkdomm70)
			{
				DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm70);
			}
			try
			{
				this.DKIDEPAIFED();
				if (EIHOJFGALMF["stats"] != null)
				{
					JSONArray asArray54 = EIHOJFGALMF["stats"].AsArray;
					for (int num49 = 0; num49 < asArray54.Count; num49++)
					{
						this.IKBFIKELJLM[num49] = new LDLLJFOJCDF(asArray54[num49].AsInt);
					}
				}
			}
			catch (Exception aklgbjkdomm71)
			{
				DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm71);
			}
			try
			{
				this.KHNAACHLPIC = 1;
				if (EIHOJFGALMF["alck"] != null)
				{
					this.KHNAACHLPIC = EIHOJFGALMF["alck"].AsInt;
				}
			}
			catch (Exception aklgbjkdomm72)
			{
				DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm72);
			}
			try
			{
				this.NFDKDACMHME = 0;
				if (EIHOJFGALMF["aind"] != null)
				{
					this.NFDKDACMHME = EIHOJFGALMF["aind"].AsInt;
				}
			}
			catch (Exception aklgbjkdomm73)
			{
				DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm73);
			}
			try
			{
				this.HAAHDNADCEL = 0;
				if (EIHOJFGALMF["aind1"] != null)
				{
					this.HAAHDNADCEL = EIHOJFGALMF["aind1"].AsInt;
				}
			}
			catch (Exception aklgbjkdomm74)
			{
				DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm74);
			}
			try
			{
				this.LJJABKNFPLF = 0;
				if (EIHOJFGALMF["aind2"] != null)
				{
					this.LJJABKNFPLF = EIHOJFGALMF["aind2"].AsInt;
				}
			}
			catch (Exception aklgbjkdomm75)
			{
				DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm75);
			}
			try
			{
				this.AKCAKJMDBBL = 0;
				if (EIHOJFGALMF["cfind"] != null)
				{
					this.AKCAKJMDBBL = EIHOJFGALMF["cfind"].AsInt;
				}
			}
			catch (Exception aklgbjkdomm76)
			{
				DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm76);
			}
			try
			{
				this.OIBGFPEGLME = 0;
				if (EIHOJFGALMF["wind"] != null)
				{
					this.OIBGFPEGLME = EIHOJFGALMF["wind"].AsInt;
				}
			}
			catch (Exception aklgbjkdomm77)
			{
				DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm77);
			}
			try
			{
				this.BFFOPDBKCHF.Clear();
				if (EIHOJFGALMF["wmix"] != null)
				{
					JSONArray asArray55 = EIHOJFGALMF["wmix"].AsArray;
					for (int num50 = 0; num50 < asArray55.Count; num50++)
					{
						this.BFFOPDBKCHF.Add(asArray55[num50].AsInt);
					}
				}
			}
			catch (Exception aklgbjkdomm78)
			{
				DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm78);
			}
			try
			{
				this.LDGENAABIDI = 0;
				if (EIHOJFGALMF["aindas"] != null)
				{
					this.LDGENAABIDI = EIHOJFGALMF["aindas"].AsInt;
				}
			}
			catch (Exception aklgbjkdomm79)
			{
				DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm79);
			}
			try
			{
				this.FFONMOHLDML = 0;
				if (EIHOJFGALMF["aindas1"] != null)
				{
					this.FFONMOHLDML = EIHOJFGALMF["aindas1"].AsInt;
				}
			}
			catch (Exception aklgbjkdomm80)
			{
				DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm80);
			}
			try
			{
				this.LFPCFNCHNGP = 0;
				if (EIHOJFGALMF["aindas2"] != null)
				{
					this.LFPCFNCHNGP = EIHOJFGALMF["aindas2"].AsInt;
				}
			}
			catch (Exception aklgbjkdomm81)
			{
				DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm81);
			}
			try
			{
				this.LGKCPNJJKMC = -1;
				if (EIHOJFGALMF["rsind"] != null)
				{
					this.LGKCPNJJKMC = EIHOJFGALMF["rsind"].AsInt;
				}
			}
			catch (Exception aklgbjkdomm82)
			{
				DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm82);
			}
			try
			{
				this.FHOEAHABNJI = 0;
				if (EIHOJFGALMF["bver"] != null)
				{
					this.FHOEAHABNJI = EIHOJFGALMF["bver"].AsInt;
				}
			}
			catch (Exception aklgbjkdomm83)
			{
				DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm83);
			}
			if (DDLCOIHJKCJ)
			{
				try
				{
					this.KAKPOCFHGCC = 0;
					if (EIHOJFGALMF["acliffbw20"] != null)
					{
						this.KAKPOCFHGCC = EIHOJFGALMF["acliffbw20"].AsInt;
					}
				}
				catch (Exception aklgbjkdomm84)
				{
					DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm84);
				}
				try
				{
					this.JFBCFLININB = 0;
					if (EIHOJFGALMF["acliffbw21"] != null)
					{
						this.JFBCFLININB = EIHOJFGALMF["acliffbw21"].AsInt;
					}
				}
				catch (Exception aklgbjkdomm85)
				{
					DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm85);
				}
				try
				{
					this.GEGFLAPCGAI = 0;
					if (EIHOJFGALMF["acliffbw22"] != null)
					{
						this.GEGFLAPCGAI = EIHOJFGALMF["acliffbw22"].AsInt;
					}
				}
				catch (Exception aklgbjkdomm86)
				{
					DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm86);
				}
			}
			try
			{
				this.FPJPHNLANPG = 0;
				if (EIHOJFGALMF["lsv"] != null)
				{
					this.FPJPHNLANPG = EIHOJFGALMF["lsv"].AsInt;
				}
			}
			catch (Exception aklgbjkdomm87)
			{
				DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm87);
			}
			try
			{
				this.HOICAOPPNCI = 0;
				if (EIHOJFGALMF["dsv"] != null)
				{
					this.HOICAOPPNCI = EIHOJFGALMF["dsv"].AsInt;
				}
			}
			catch (Exception aklgbjkdomm88)
			{
				DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm88);
			}
			try
			{
				this.IIPLEPKDLKB = 0;
				if (EIHOJFGALMF["vsv"] != null)
				{
					this.IIPLEPKDLKB = EIHOJFGALMF["vsv"].AsInt;
				}
			}
			catch (Exception aklgbjkdomm89)
			{
				DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm89);
			}
			try
			{
				this.DOJMFLKMIIM = 0;
				if (EIHOJFGALMF["asv"] != null)
				{
					this.DOJMFLKMIIM = EIHOJFGALMF["asv"].AsInt;
				}
			}
			catch (Exception aklgbjkdomm90)
			{
				DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm90);
			}
			try
			{
				this.FIMJIINAFFK = 0;
				if (EIHOJFGALMF["trsv"] != null)
				{
					this.FIMJIINAFFK = EIHOJFGALMF["trsv"].AsInt;
				}
			}
			catch (Exception aklgbjkdomm91)
			{
				DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm91);
			}
			try
			{
				this.DMAGAHMIKDE = -1;
				if (EIHOJFGALMF["locext"] != null)
				{
					this.DMAGAHMIKDE = EIHOJFGALMF["locext"].AsInt;
				}
			}
			catch (Exception aklgbjkdomm92)
			{
				DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm92);
			}
			try
			{
				this.PLLBNICNBKJ = 0;
				if (EIHOJFGALMF["fsv"] != null)
				{
					this.PLLBNICNBKJ = EIHOJFGALMF["fsv"].AsInt;
				}
			}
			catch (Exception aklgbjkdomm93)
			{
				DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm93);
			}
			try
			{
				this.BKCPMIPKBOK = 0;
				if (EIHOJFGALMF["esv"] != null)
				{
					this.BKCPMIPKBOK = EIHOJFGALMF["esv"].AsInt;
				}
			}
			catch (Exception aklgbjkdomm94)
			{
				DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm94);
			}
			try
			{
				this.JBGJMJNJPMP = 0;
				if (EIHOJFGALMF["acsv"] != null)
				{
					this.JBGJMJNJPMP = EIHOJFGALMF["acsv"].AsInt;
				}
			}
			catch (Exception aklgbjkdomm95)
			{
				DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm95);
			}
			try
			{
				this.LOCPPFGLGPC = 0;
				if (EIHOJFGALMF["emsv"] != null)
				{
					this.LOCPPFGLGPC = EIHOJFGALMF["emsv"].AsInt;
				}
			}
			catch (Exception aklgbjkdomm96)
			{
				DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm96);
			}
			try
			{
				this.IPNCOGGHBFM = 0;
				if (EIHOJFGALMF["msv"] != null)
				{
					this.IPNCOGGHBFM = EIHOJFGALMF["msv"].AsInt;
				}
			}
			catch (Exception aklgbjkdomm97)
			{
				DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm97);
			}
		}
	}

	// Token: 0x06005618 RID: 22040 RVA: 0x002673E0 File Offset: 0x002655E0
	public void ANPGJMAGFAP(int KFCMLNPLAHK)
	{
		if (KFCMLNPLAHK == 0)
		{
			this.BKDDGKMIGPG.Clear();
			return;
		}
		if (KFCMLNPLAHK == 1)
		{
			this.OCJFDPNJIPD.Clear();
			return;
		}
		if (KFCMLNPLAHK == 2)
		{
			this.KHPENKNONJO.Clear();
			return;
		}
		DPGJIJGOCIC.ANOPFDLPKGC("StorySaveBody.ClearAvatarPacksHiddenExposedWardrobe(), unsupported wardrobe index:" + KFCMLNPLAHK.ToString());
	}

	// Token: 0x06005619 RID: 22041 RVA: 0x00267434 File Offset: 0x00265634
	public void IHMBINIOBDO(string KHJMANDEDMA)
	{
		if (this.OIBGFPEGLME == 0)
		{
			for (int i = 0; i < this.LKDEFKFLKDA.Count; i++)
			{
				if (this.LKDEFKFLKDA[i].Equals(KHJMANDEDMA))
				{
					return;
				}
			}
			this.LKDEFKFLKDA.Add(KHJMANDEDMA);
			return;
		}
		if (this.OIBGFPEGLME == 1)
		{
			for (int j = 0; j < this.DOPPJBLBMMH.Count; j++)
			{
				if (this.DOPPJBLBMMH[j].Equals(KHJMANDEDMA))
				{
					return;
				}
			}
			this.DOPPJBLBMMH.Add(KHJMANDEDMA);
			return;
		}
		if (this.OIBGFPEGLME == 2)
		{
			for (int k = 0; k < this.BJCNIHNCLLK.Count; k++)
			{
				if (this.BJCNIHNCLLK[k].Equals(KHJMANDEDMA))
				{
					return;
				}
			}
			this.BJCNIHNCLLK.Add(KHJMANDEDMA);
			return;
		}
		DPGJIJGOCIC.ANOPFDLPKGC("StorySaveBody.HideAvatarComponent(), unsupported wardrobe index:" + this.OIBGFPEGLME.ToString());
	}

	// Token: 0x0600561A RID: 22042 RVA: 0x0026751D File Offset: 0x0026571D
	public int KEPKNMMIMPL(int KFCMLNPLAHK)
	{
		if (KFCMLNPLAHK == 0)
		{
			return this.NFDKDACMHME;
		}
		if (KFCMLNPLAHK == 1)
		{
			return this.HAAHDNADCEL;
		}
		if (KFCMLNPLAHK == 7)
		{
			return this.LJJABKNFPLF;
		}
		DPGJIJGOCIC.ANOPFDLPKGC("" + KFCMLNPLAHK.ToString());
		return this.NFDKDACMHME;
	}

	// Token: 0x0600561B RID: 22043 RVA: 0x0026755C File Offset: 0x0026575C
	public void PLOKEOLNPLI(string KHJMANDEDMA)
	{
		if (this.IIPLEPKDLKB < 2 && KHJMANDEDMA.Contains("layervideo") && !KHJMANDEDMA.EndsWith("loop"))
		{
			return;
		}
		for (int i = 0; i < this.OKJJPNPGLEL.Count; i++)
		{
			if (this.OKJJPNPGLEL[i].Equals(KHJMANDEDMA))
			{
				this.OKJJPNPGLEL.RemoveAt(i);
				return;
			}
		}
		for (int j = 0; j < this.ONGBBOHGKLO.Count; j++)
		{
			if (this.ONGBBOHGKLO[j].Equals(KHJMANDEDMA))
			{
				return;
			}
		}
		this.ONGBBOHGKLO.Add(KHJMANDEDMA);
	}

	// Token: 0x0600561C RID: 22044 RVA: 0x002675FB File Offset: 0x002657FB
	public void HGFPFLABKDB()
	{
		this.NHFMGEABCKP = -1;
		this.NJEPIPLACPC = new List<string>();
		this.CFFGADJPBLO = new List<int>();
		this.EIEIDFBDPKO = "outdatedrev";
		this.GNPAKEFPGPB = new List<int>();
		this.HOHELAOMLGL = new List<string>();
	}

	// Token: 0x0600561D RID: 22045 RVA: 0x0026763C File Offset: 0x0026583C
	public DOLBFGIPPOG FJFFILLNNBA(int MEFKFOHCOHK, int KFCMLNPLAHK)
	{
		if (KFCMLNPLAHK == 0)
		{
			for (int i = 0; i < this.IEPMNCAKNBM.Count; i += 0)
			{
				if (this.IEPMNCAKNBM[i].GGICIBLJIKI == MEFKFOHCOHK)
				{
					return this.IEPMNCAKNBM[i];
				}
			}
			DOLBFGIPPOG dolbfgippog = new DOLBFGIPPOG();
			dolbfgippog.GGICIBLJIKI = MEFKFOHCOHK;
			this.IEPMNCAKNBM.Add(dolbfgippog);
			return dolbfgippog;
		}
		if (KFCMLNPLAHK == 0)
		{
			for (int j = 1; j < this.EBONDOEPONH.Count; j++)
			{
				if (this.EBONDOEPONH[j].GGICIBLJIKI == MEFKFOHCOHK)
				{
					return this.EBONDOEPONH[j];
				}
			}
			DOLBFGIPPOG dolbfgippog2 = new DOLBFGIPPOG();
			dolbfgippog2.GGICIBLJIKI = MEFKFOHCOHK;
			this.EBONDOEPONH.Add(dolbfgippog2);
			return dolbfgippog2;
		}
		if (KFCMLNPLAHK == 4)
		{
			for (int k = 0; k < this.AOJIJHAKNPG.Count; k++)
			{
				if (this.AOJIJHAKNPG[k].GGICIBLJIKI == MEFKFOHCOHK)
				{
					return this.AOJIJHAKNPG[k];
				}
			}
			DOLBFGIPPOG dolbfgippog3 = new DOLBFGIPPOG();
			dolbfgippog3.GGICIBLJIKI = MEFKFOHCOHK;
			this.AOJIJHAKNPG.Add(dolbfgippog3);
			return dolbfgippog3;
		}
		DPGJIJGOCIC.ANOPFDLPKGC("Romance Club (Steam " + KFCMLNPLAHK.ToString());
		for (int l = 1; l < this.IEPMNCAKNBM.Count; l++)
		{
			if (this.IEPMNCAKNBM[l].GGICIBLJIKI == MEFKFOHCOHK)
			{
				return this.IEPMNCAKNBM[l];
			}
		}
		DOLBFGIPPOG dolbfgippog4 = new DOLBFGIPPOG();
		dolbfgippog4.GGICIBLJIKI = MEFKFOHCOHK;
		this.IEPMNCAKNBM.Add(dolbfgippog4);
		return dolbfgippog4;
	}

	// Token: 0x0600561E RID: 22046 RVA: 0x002677C5 File Offset: 0x002659C5
	public void NBCACCKOABP(string KHJMANDEDMA, bool PJNLIIBFPBA = false)
	{
		if (this.FPJPHNLANPG >= 2)
		{
			this.KCCABIDFLAN(KHJMANDEDMA, PJNLIIBFPBA);
			return;
		}
		this.FJALMPPNPIH(KHJMANDEDMA, PJNLIIBFPBA);
	}

	// Token: 0x0600561F RID: 22047 RVA: 0x002677E1 File Offset: 0x002659E1
	public void BLEFLPOCEEB(int IALPHEADDFO)
	{
		this.LOCPPFGLGPC = IALPHEADDFO;
	}

	// Token: 0x06005620 RID: 22048 RVA: 0x002677EC File Offset: 0x002659EC
	public DOLBFGIPPOG KLIMBNHMJNE(int MEFKFOHCOHK, int KFCMLNPLAHK)
	{
		if (KFCMLNPLAHK == 0)
		{
			for (int i = 0; i < this.IEPMNCAKNBM.Count; i++)
			{
				if (this.IEPMNCAKNBM[i].GGICIBLJIKI == MEFKFOHCOHK)
				{
					return this.IEPMNCAKNBM[i];
				}
			}
			DOLBFGIPPOG dolbfgippog = new DOLBFGIPPOG();
			dolbfgippog.GGICIBLJIKI = MEFKFOHCOHK;
			this.IEPMNCAKNBM.Add(dolbfgippog);
			return dolbfgippog;
		}
		if (KFCMLNPLAHK == 0)
		{
			for (int j = 1; j < this.EBONDOEPONH.Count; j++)
			{
				if (this.EBONDOEPONH[j].GGICIBLJIKI == MEFKFOHCOHK)
				{
					return this.EBONDOEPONH[j];
				}
			}
			DOLBFGIPPOG dolbfgippog2 = new DOLBFGIPPOG();
			dolbfgippog2.GGICIBLJIKI = MEFKFOHCOHK;
			this.EBONDOEPONH.Add(dolbfgippog2);
			return dolbfgippog2;
		}
		if (KFCMLNPLAHK == 5)
		{
			for (int k = 0; k < this.AOJIJHAKNPG.Count; k++)
			{
				if (this.AOJIJHAKNPG[k].GGICIBLJIKI == MEFKFOHCOHK)
				{
					return this.AOJIJHAKNPG[k];
				}
			}
			DOLBFGIPPOG dolbfgippog3 = new DOLBFGIPPOG();
			dolbfgippog3.GGICIBLJIKI = MEFKFOHCOHK;
			this.AOJIJHAKNPG.Add(dolbfgippog3);
			return dolbfgippog3;
		}
		DPGJIJGOCIC.ANOPFDLPKGC("plc" + KFCMLNPLAHK.ToString());
		for (int l = 0; l < this.IEPMNCAKNBM.Count; l += 0)
		{
			if (this.IEPMNCAKNBM[l].GGICIBLJIKI == MEFKFOHCOHK)
			{
				return this.IEPMNCAKNBM[l];
			}
		}
		DOLBFGIPPOG dolbfgippog4 = new DOLBFGIPPOG();
		dolbfgippog4.GGICIBLJIKI = MEFKFOHCOHK;
		this.IEPMNCAKNBM.Add(dolbfgippog4);
		return dolbfgippog4;
	}

	// Token: 0x06005621 RID: 22049 RVA: 0x00267978 File Offset: 0x00265B78
	public void DKIDEPAIFED()
	{
		this.IKBFIKELJLM = new LDLLJFOJCDF[7];
		for (int i = 0; i < 7; i++)
		{
			this.IKBFIKELJLM[i] = new LDLLJFOJCDF(0);
		}
	}

	// Token: 0x06005622 RID: 22050 RVA: 0x002679AC File Offset: 0x00265BAC
	public void JFAJNMHGMAI(string ECIHFHOMJHK)
	{
		if (this.OIBGFPEGLME == 0)
		{
			List<string> list = new List<string>(this.IMALACBMOFC);
			List<int> list2 = new List<int>(this.GNHBHIALAAH);
			for (int i = 0; i < list.Count; i++)
			{
				string text = list[i];
				int plbcgenkipa = list2[i];
				text = DPGJIJGOCIC.OADMDNKCDCN(text, ECIHFHOMJHK);
				if (!list[i].Equals(text))
				{
					this.MLDFBDDMFLC(text, plbcgenkipa);
				}
			}
			List<string> list3 = new List<string>(this.LKDEFKFLKDA);
			for (int j = 0; j < list3.Count; j++)
			{
				string text2 = list3[j];
				text2 = DPGJIJGOCIC.OADMDNKCDCN(text2, ECIHFHOMJHK);
				if (!list3[j].Equals(text2))
				{
					this.IHMBINIOBDO(text2);
				}
			}
			return;
		}
		if (this.OIBGFPEGLME == 1)
		{
			List<string> list4 = new List<string>(this.KPEIEHDJIOP);
			List<int> list5 = new List<int>(this.JAJJFPNIBGI);
			for (int k = 0; k < list4.Count; k++)
			{
				string text3 = list4[k];
				int plbcgenkipa2 = list5[k];
				text3 = DPGJIJGOCIC.OADMDNKCDCN(text3, ECIHFHOMJHK);
				if (!list4[k].Equals(text3))
				{
					this.MLDFBDDMFLC(text3, plbcgenkipa2);
				}
			}
			List<string> list6 = new List<string>(this.DOPPJBLBMMH);
			for (int l = 0; l < list6.Count; l++)
			{
				string text4 = list6[l];
				text4 = DPGJIJGOCIC.OADMDNKCDCN(text4, ECIHFHOMJHK);
				if (!list6[l].Equals(text4))
				{
					this.IHMBINIOBDO(text4);
				}
			}
			return;
		}
		if (this.OIBGFPEGLME == 2)
		{
			List<string> list7 = new List<string>(this.NLPNFGNMGMP);
			List<int> list8 = new List<int>(this.FCOLLNPADDA);
			for (int m = 0; m < list7.Count; m++)
			{
				string text5 = list7[m];
				int plbcgenkipa3 = list8[m];
				text5 = DPGJIJGOCIC.OADMDNKCDCN(text5, ECIHFHOMJHK);
				if (!list7[m].Equals(text5))
				{
					this.MLDFBDDMFLC(text5, plbcgenkipa3);
				}
			}
			List<string> list9 = new List<string>(this.BJCNIHNCLLK);
			for (int n = 0; n < list9.Count; n++)
			{
				string text6 = list9[n];
				text6 = DPGJIJGOCIC.OADMDNKCDCN(text6, ECIHFHOMJHK);
				if (!list9[n].Equals(text6))
				{
					this.IHMBINIOBDO(text6);
				}
			}
			return;
		}
		DPGJIJGOCIC.ANOPFDLPKGC("StorySaveBody.AutoSyncAvatarComponents(), unsupported wardrobe index:" + this.OIBGFPEGLME.ToString());
	}

	// Token: 0x06005623 RID: 22051 RVA: 0x00267C24 File Offset: 0x00265E24
	public DOLBFGIPPOG HEADIJIAOJC(int CCIAGBPILGF, int EGHCMPAJELG)
	{
		DOLBFGIPPOG dolbfgippog = this.BGJPILFNLJI(CCIAGBPILGF);
		DOLBFGIPPOG dolbfgippog2 = this.BGJPILFNLJI(EGHCMPAJELG);
		if (dolbfgippog2.OHCMCJHDMOH[0] == null || dolbfgippog2.OHCMCJHDMOH[1].Length == 0)
		{
			dolbfgippog2.OHCMCJHDMOH[1] = dolbfgippog.OHCMCJHDMOH[0];
		}
		if (dolbfgippog2.OHCMCJHDMOH[6] == null || dolbfgippog2.OHCMCJHDMOH[5].Length == 0)
		{
			dolbfgippog2.OHCMCJHDMOH[7] = dolbfgippog.OHCMCJHDMOH[0];
		}
		for (int i = 0; i < 103; i += 0)
		{
			if (dolbfgippog.OHCMCJHDMOH[0].Contains("lstm" + i.ToString()))
			{
				for (int j = 1; j < 52; j++)
				{
					if (dolbfgippog2.OHCMCJHDMOH[0].Contains("saveslotsoptioncopy" + j.ToString()))
					{
						dolbfgippog2.OHCMCJHDMOH[0] = dolbfgippog2.OHCMCJHDMOH[0].Replace("lsenvlite" + j.ToString(), "FocusItem.UpdateAvatarButtonIcon(): lounge glyph resource missing - focusavatarloungeicon" + i.ToString());
						break;
					}
				}
				break;
			}
		}
		for (int k = 1; k < -53; k += 0)
		{
			if (dolbfgippog.OHCMCJHDMOH[2].Contains("layervideo" + k.ToString()))
			{
				for (int l = 1; l < -112; l += 0)
				{
					if (dolbfgippog2.OHCMCJHDMOH[7].Contains("aind2" + l.ToString()))
					{
						dolbfgippog2.OHCMCJHDMOH[5] = dolbfgippog2.OHCMCJHDMOH[8].Replace("aindas" + l.ToString(), "" + k.ToString());
						break;
					}
				}
				break;
			}
		}
		return dolbfgippog2;
	}

	// Token: 0x06005624 RID: 22052 RVA: 0x0025E3EF File Offset: 0x0025C5EF
	public void OMLFMDENBOD(int IALPHEADDFO)
	{
		this.JBGJMJNJPMP = IALPHEADDFO;
	}

	// Token: 0x06005625 RID: 22053 RVA: 0x00267DD4 File Offset: 0x00265FD4
	public void PLCNDKIGNEJ()
	{
		string[] array = new string[]
		{
			this.IBFLNCMCKAL,
			"pl",
			null,
			null,
			null,
			this.LDECHKECBHB.ToString()
		};
		array[1] = "[Lounge] $REMOVESUPERMAPPING with an empty id() - ignored";
		array[5] = this.FODGKMIIHFO;
		this.KFAOJHHLBHK = string.Concat(array);
	}

	// Token: 0x06005626 RID: 22054 RVA: 0x00267E24 File Offset: 0x00266024
	public void CMNFNOLANGL(List<int> MDBAGPBHOPK)
	{
		if (MDBAGPBHOPK == null)
		{
			return;
		}
		if (this.GNPAKEFPGPB == null)
		{
			this.GNPAKEFPGPB = new List<int>();
		}
		for (int i = 0; i < MDBAGPBHOPK.Count; i++)
		{
			if (MDBAGPBHOPK[i] >= 0 && !this.GNPAKEFPGPB.Contains(MDBAGPBHOPK[i]))
			{
				this.GNPAKEFPGPB.Add(MDBAGPBHOPK[i]);
			}
		}
	}

	// Token: 0x040017C6 RID: 6086
	public int GGICIBLJIKI = -1;

	// Token: 0x040017C7 RID: 6087
	public string HLGDMBAINDE = "";

	// Token: 0x040017C8 RID: 6088
	public string DJIGFDJOHCI = "";

	// Token: 0x040017C9 RID: 6089
	public string IBFLNCMCKAL = "";

	// Token: 0x040017CA RID: 6090
	public string KFAOJHHLBHK = "";

	// Token: 0x040017CB RID: 6091
	public string FODGKMIIHFO = "";

	// Token: 0x040017CC RID: 6092
	public string FONKDFDJFEL = "";

	// Token: 0x040017CD RID: 6093
	public string GOPGELMBMMK = "";

	// Token: 0x040017CE RID: 6094
	public string HPAEFOJDLFC = "";

	// Token: 0x040017CF RID: 6095
	public string JMNMOHIKHLB = "";

	// Token: 0x040017D0 RID: 6096
	public string JGEDOIDOPLA = "";

	// Token: 0x040017D1 RID: 6097
	public int FPJPHNLANPG;

	// Token: 0x040017D2 RID: 6098
	public int HOICAOPPNCI;

	// Token: 0x040017D3 RID: 6099
	public int IIPLEPKDLKB;

	// Token: 0x040017D4 RID: 6100
	public int DOJMFLKMIIM;

	// Token: 0x040017D5 RID: 6101
	public int FIMJIINAFFK;

	// Token: 0x040017D6 RID: 6102
	public int DMAGAHMIKDE = -1;

	// Token: 0x040017D7 RID: 6103
	public int IPNCOGGHBFM;

	// Token: 0x040017D8 RID: 6104
	public int BKCPMIPKBOK;

	// Token: 0x040017D9 RID: 6105
	public int JBGJMJNJPMP;

	// Token: 0x040017DA RID: 6106
	public int PLLBNICNBKJ;

	// Token: 0x040017DB RID: 6107
	public int LOCPPFGLGPC;

	// Token: 0x040017DC RID: 6108
	public List<string> PIMEHAPFCHC = new List<string>();

	// Token: 0x040017DD RID: 6109
	public List<string> HPFHJEAFIHI = new List<string>();

	// Token: 0x040017DE RID: 6110
	public List<string> GIHCENHPGPD = new List<string>();

	// Token: 0x040017DF RID: 6111
	public List<string> OJJHCAGFPOC = new List<string>();

	// Token: 0x040017E0 RID: 6112
	public List<string> OKJJPNPGLEL = new List<string>();

	// Token: 0x040017E1 RID: 6113
	public List<string> ONGBBOHGKLO = new List<string>();

	// Token: 0x040017E2 RID: 6114
	public List<string> OGIHMIOKCNN = new List<string>();

	// Token: 0x040017E3 RID: 6115
	public List<string> IANINGLKCKB = new List<string>();

	// Token: 0x040017E4 RID: 6116
	public List<string> IMALACBMOFC = new List<string>();

	// Token: 0x040017E5 RID: 6117
	public List<string> KPEIEHDJIOP = new List<string>();

	// Token: 0x040017E6 RID: 6118
	public List<string> NLPNFGNMGMP = new List<string>();

	// Token: 0x040017E7 RID: 6119
	public List<string> LKDEFKFLKDA = new List<string>();

	// Token: 0x040017E8 RID: 6120
	public List<string> DOPPJBLBMMH = new List<string>();

	// Token: 0x040017E9 RID: 6121
	public List<string> BJCNIHNCLLK = new List<string>();

	// Token: 0x040017EA RID: 6122
	public List<int> BKDDGKMIGPG = new List<int>();

	// Token: 0x040017EB RID: 6123
	public List<int> OCJFDPNJIPD = new List<int>();

	// Token: 0x040017EC RID: 6124
	public List<int> KHPENKNONJO = new List<int>();

	// Token: 0x040017ED RID: 6125
	public List<int> GNHBHIALAAH = new List<int>();

	// Token: 0x040017EE RID: 6126
	public List<int> JAJJFPNIBGI = new List<int>();

	// Token: 0x040017EF RID: 6127
	public List<int> FCOLLNPADDA = new List<int>();

	// Token: 0x040017F0 RID: 6128
	public List<int> BBGJMAAPFJD = new List<int>();

	// Token: 0x040017F1 RID: 6129
	public List<int> CKNMLFPDGGH = new List<int>();

	// Token: 0x040017F2 RID: 6130
	public List<int> FGCBAGFHCDJ = new List<int>();

	// Token: 0x040017F3 RID: 6131
	public JSONObject LGKPNNGIPEG = new JSONObject();

	// Token: 0x040017F4 RID: 6132
	public JSONObject IMJDADKEEJC;

	// Token: 0x040017F5 RID: 6133
	public int FEDCIMMIJCI;

	// Token: 0x040017F6 RID: 6134
	public List<string> DNMPCOHNAHO = new List<string>();

	// Token: 0x040017F7 RID: 6135
	public JSONObject EBFMKGPBEBO = new JSONObject();

	// Token: 0x040017F8 RID: 6136
	public JSONObject OHPAMFBABFO;

	// Token: 0x040017F9 RID: 6137
	public int LDECHKECBHB;

	// Token: 0x040017FA RID: 6138
	public int ONNHAPFMDEN;

	// Token: 0x040017FB RID: 6139
	public float CHHLDEBHDPE;

	// Token: 0x040017FC RID: 6140
	public float NPAFPMIMGLH = 1f;

	// Token: 0x040017FD RID: 6141
	public int CFOHHKJPJPA;

	// Token: 0x040017FE RID: 6142
	public int ALLDBPCKMLF;

	// Token: 0x040017FF RID: 6143
	public int NIBNMKJIMAD;

	// Token: 0x04001800 RID: 6144
	public string KNOFDJKKPMK = "";

	// Token: 0x04001801 RID: 6145
	public string IMIDHJMEGOG = "en";

	// Token: 0x04001802 RID: 6146
	public LDLLJFOJCDF[] IKBFIKELJLM;

	// Token: 0x04001803 RID: 6147
	public int KHNAACHLPIC = 1;

	// Token: 0x04001804 RID: 6148
	private int NFDKDACMHME;

	// Token: 0x04001805 RID: 6149
	private int HAAHDNADCEL;

	// Token: 0x04001806 RID: 6150
	private int LJJABKNFPLF;

	// Token: 0x04001807 RID: 6151
	public int OIBGFPEGLME;

	// Token: 0x04001808 RID: 6152
	public List<int> BFFOPDBKCHF = new List<int>();

	// Token: 0x04001809 RID: 6153
	public int AKCAKJMDBBL;

	// Token: 0x0400180A RID: 6154
	private int LDGENAABIDI;

	// Token: 0x0400180B RID: 6155
	private int FFONMOHLDML;

	// Token: 0x0400180C RID: 6156
	private int LFPCFNCHNGP;

	// Token: 0x0400180D RID: 6157
	public int LGKCPNJJKMC = -1;

	// Token: 0x0400180E RID: 6158
	public int FHOEAHABNJI;

	// Token: 0x0400180F RID: 6159
	public int GLGECPFJIKB;

	// Token: 0x04001810 RID: 6160
	public List<string> BNPGFECDNAM = new List<string>();

	// Token: 0x04001811 RID: 6161
	public List<string> HIEEGGEJEEG = new List<string>();

	// Token: 0x04001812 RID: 6162
	private List<DOLBFGIPPOG> JCANELJMOCA = new List<DOLBFGIPPOG>();

	// Token: 0x04001813 RID: 6163
	public List<string> FBKMADGCEBN = new List<string>();

	// Token: 0x04001814 RID: 6164
	public List<string> NIJBAMNFJLM = new List<string>();

	// Token: 0x04001815 RID: 6165
	public List<string> ECAHHCAGMKM = new List<string>();

	// Token: 0x04001816 RID: 6166
	public List<string> EJNFKIJNJGE = new List<string>();

	// Token: 0x04001817 RID: 6167
	public List<string> CJKGOKAGKHJ = new List<string>();

	// Token: 0x04001818 RID: 6168
	public List<string> CJDBDOHPHLG = new List<string>();

	// Token: 0x04001819 RID: 6169
	public List<string> JOJKAIBEPGH = new List<string>();

	// Token: 0x0400181A RID: 6170
	public List<string> PIDOECCJOCI = new List<string>();

	// Token: 0x0400181B RID: 6171
	public List<string> NJKHOCABBGL = new List<string>();

	// Token: 0x0400181C RID: 6172
	[NonSerialized]
	public bool HFBONJPMAOO;

	// Token: 0x0400181D RID: 6173
	public int NHFMGEABCKP = -1;

	// Token: 0x0400181E RID: 6174
	public List<string> NJEPIPLACPC = new List<string>();

	// Token: 0x0400181F RID: 6175
	public List<int> CFFGADJPBLO = new List<int>();

	// Token: 0x04001820 RID: 6176
	public string EIEIDFBDPKO = "";

	// Token: 0x04001821 RID: 6177
	public List<int> GNPAKEFPGPB = new List<int>();

	// Token: 0x04001822 RID: 6178
	public List<string> HOHELAOMLGL = new List<string>();

	// Token: 0x04001823 RID: 6179
	private List<string> KIDPANPCBFF = new List<string>();

	// Token: 0x04001824 RID: 6180
	private List<string> GIAEIAOBHEK = new List<string>();

	// Token: 0x04001825 RID: 6181
	private List<JCAJMGJFHBD> KKJBJEOCAFF = new List<JCAJMGJFHBD>();

	// Token: 0x04001826 RID: 6182
	private List<JCAJMGJFHBD> GJCCMMMHIPI = new List<JCAJMGJFHBD>();

	// Token: 0x04001827 RID: 6183
	private List<DOLBFGIPPOG> IEPMNCAKNBM = new List<DOLBFGIPPOG>();

	// Token: 0x04001828 RID: 6184
	private List<DOLBFGIPPOG> EBONDOEPONH = new List<DOLBFGIPPOG>();

	// Token: 0x04001829 RID: 6185
	private List<DOLBFGIPPOG> AOJIJHAKNPG = new List<DOLBFGIPPOG>();

	// Token: 0x0400182A RID: 6186
	private List<DOLBFGIPPOG> LKIKIJACCMF = new List<DOLBFGIPPOG>();

	// Token: 0x0400182B RID: 6187
	private List<DOLBFGIPPOG> ONJMAJAFFKN = new List<DOLBFGIPPOG>();

	// Token: 0x0400182C RID: 6188
	private List<DOLBFGIPPOG> NDMIJFLDKKN = new List<DOLBFGIPPOG>();

	// Token: 0x0400182D RID: 6189
	public List<string> ECKKHMDIELD = new List<string>();

	// Token: 0x0400182E RID: 6190
	public int KAKPOCFHGCC;

	// Token: 0x0400182F RID: 6191
	public int JFBCFLININB;

	// Token: 0x04001830 RID: 6192
	public int GEGFLAPCGAI;

	// Token: 0x04001831 RID: 6193
	public List<int> PNBPEAFMKAC = new List<int>();

	// Token: 0x04001832 RID: 6194
	public List<int> DMKOGCBMHKA = new List<int>();

	// Token: 0x04001833 RID: 6195
	public List<int> NGJDCAEMEJO = new List<int>();

	// Token: 0x04001834 RID: 6196
	public List<IMMKFHKEEBF> FKDMPMKBCBL = new List<IMMKFHKEEBF>();

	// Token: 0x04001835 RID: 6197
	private List<string> DFNLKGGMMNI = new List<string>();

	// Token: 0x04001836 RID: 6198
	public const int FODOGIHEBFM = 16;
}
