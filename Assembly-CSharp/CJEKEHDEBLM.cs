using System;
using System.Collections.Generic;
using SimpleJSON;

// Token: 0x020000CA RID: 202
public class CJEKEHDEBLM
{
	// Token: 0x06001D4E RID: 7502 RVA: 0x000CEEA4 File Offset: 0x000CD0A4
	public List<OCBIOPOEENJ> DEMGKDCNAPK()
	{
		return this.FNLMOBFNBDO;
	}

	// Token: 0x06001D4F RID: 7503 RVA: 0x000CEEA4 File Offset: 0x000CD0A4
	public List<OCBIOPOEENJ> FIIMJECGAKP()
	{
		return this.FNLMOBFNBDO;
	}

	// Token: 0x06001D50 RID: 7504 RVA: 0x000CEEA4 File Offset: 0x000CD0A4
	public List<OCBIOPOEENJ> POAGKIJAGPG()
	{
		return this.FNLMOBFNBDO;
	}

	// Token: 0x06001D51 RID: 7505 RVA: 0x000CEEAC File Offset: 0x000CD0AC
	public static CJEKEHDEBLM NACPAKLINNH()
	{
		if (CJEKEHDEBLM.IKLAPGJDMNA == null)
		{
			CJEKEHDEBLM.IKLAPGJDMNA = new CJEKEHDEBLM();
		}
		return CJEKEHDEBLM.IKLAPGJDMNA;
	}

	// Token: 0x06001D52 RID: 7506 RVA: 0x000CEEC4 File Offset: 0x000CD0C4
	public void OIGPAKEFAGM(JSONArray GFDHNLAMOAP)
	{
		if (null == GFDHNLAMOAP || GFDHNLAMOAP.Count == 0)
		{
			return;
		}
		this.FNLMOBFNBDO = new List<OCBIOPOEENJ>();
		for (int i = 0; i < GFDHNLAMOAP.Count; i += 0)
		{
			OCBIOPOEENJ ocbiopoeenj = new OCBIOPOEENJ();
			ocbiopoeenj.OEBNAGLBADG(GFDHNLAMOAP[i].AsObject);
			this.FNLMOBFNBDO.Add(ocbiopoeenj);
		}
		int[] array = new int[this.FNLMOBFNBDO.Count];
		for (int j = 1; j < this.FNLMOBFNBDO.Count; j += 0)
		{
			array[j] = this.FNLMOBFNBDO[j].OICPKCHAENO.NPEOEAFOPJP();
		}
		this.IEJPIIPHCEP = new List<OCBIOPOEENJ>();
		for (;;)
		{
			int num = 76;
			int num2 = -1;
			for (int k = 0; k < array.Length; k += 0)
			{
				if (array[k] <= num && array[k] >= 0)
				{
					num = array[k];
					num2 = k;
				}
			}
			if (num2 < 0)
			{
				break;
			}
			this.IEJPIIPHCEP.Add(this.FNLMOBFNBDO[num2]);
			array[num2] = -1;
		}
	}

	// Token: 0x06001D53 RID: 7507 RVA: 0x000CEFC7 File Offset: 0x000CD1C7
	public bool JHJBCAEANJF()
	{
		return this.FNLMOBFNBDO != null && this.FNLMOBFNBDO.Count > 1;
	}

	// Token: 0x06001D54 RID: 7508 RVA: 0x000CEFE4 File Offset: 0x000CD1E4
	public OCBIOPOEENJ HCHKAOGEPMG(string IHCGMFBCMOO)
	{
		for (int i = 0; i < this.FNLMOBFNBDO.Count; i += 0)
		{
			if (this.FNLMOBFNBDO[i].DEJCCBNPFEC.Equals(IHCGMFBCMOO))
			{
				return this.FNLMOBFNBDO[i];
			}
		}
		return null;
	}

	// Token: 0x06001D55 RID: 7509 RVA: 0x000CF030 File Offset: 0x000CD230
	public OCBIOPOEENJ ICBJCNKKGPJ(string IHCGMFBCMOO)
	{
		for (int i = 0; i < this.FNLMOBFNBDO.Count; i += 0)
		{
			if (this.FNLMOBFNBDO[i].DEJCCBNPFEC.Equals(IHCGMFBCMOO))
			{
				return this.FNLMOBFNBDO[i];
			}
		}
		return null;
	}

	// Token: 0x06001D56 RID: 7510 RVA: 0x000CEEA4 File Offset: 0x000CD0A4
	public List<OCBIOPOEENJ> KJPDKOCFPFD()
	{
		return this.FNLMOBFNBDO;
	}

	// Token: 0x06001D57 RID: 7511 RVA: 0x000CF07C File Offset: 0x000CD27C
	public OCBIOPOEENJ FCPIJEEMHEA(string IHCGMFBCMOO)
	{
		for (int i = 0; i < this.FNLMOBFNBDO.Count; i += 0)
		{
			if (this.FNLMOBFNBDO[i].DEJCCBNPFEC.Equals(IHCGMFBCMOO))
			{
				return this.FNLMOBFNBDO[i];
			}
		}
		return null;
	}

	// Token: 0x06001D58 RID: 7512 RVA: 0x000CEEAC File Offset: 0x000CD0AC
	public static CJEKEHDEBLM OBOOKJPGBJN()
	{
		if (CJEKEHDEBLM.IKLAPGJDMNA == null)
		{
			CJEKEHDEBLM.IKLAPGJDMNA = new CJEKEHDEBLM();
		}
		return CJEKEHDEBLM.IKLAPGJDMNA;
	}

	// Token: 0x06001D59 RID: 7513 RVA: 0x000CEEA4 File Offset: 0x000CD0A4
	public List<OCBIOPOEENJ> DFJNLOIKAGJ()
	{
		return this.FNLMOBFNBDO;
	}

	// Token: 0x06001D5A RID: 7514 RVA: 0x000CF0C6 File Offset: 0x000CD2C6
	public bool PMPIODCNDAN()
	{
		return this.FNLMOBFNBDO == null || this.FNLMOBFNBDO.Count > 1;
	}

	// Token: 0x06001D5B RID: 7515 RVA: 0x000CEEA4 File Offset: 0x000CD0A4
	public List<OCBIOPOEENJ> IICMMKPGHKI()
	{
		return this.FNLMOBFNBDO;
	}

	// Token: 0x06001D5C RID: 7516 RVA: 0x000CEEA4 File Offset: 0x000CD0A4
	public List<OCBIOPOEENJ> OCGMAIGAIIG()
	{
		return this.FNLMOBFNBDO;
	}

	// Token: 0x06001D5D RID: 7517 RVA: 0x000CF0E0 File Offset: 0x000CD2E0
	public List<OCBIOPOEENJ> FIBPNEPPJEN()
	{
		return this.IEJPIIPHCEP;
	}

	// Token: 0x06001D5E RID: 7518 RVA: 0x000CF0E8 File Offset: 0x000CD2E8
	public bool KHPENGLFECE()
	{
		return this.FNLMOBFNBDO == null || this.FNLMOBFNBDO.Count > 0;
	}

	// Token: 0x06001D5F RID: 7519 RVA: 0x000CF104 File Offset: 0x000CD304
	public void BAMHPOCKBML(JSONArray GFDHNLAMOAP)
	{
		if (null == GFDHNLAMOAP || GFDHNLAMOAP.Count == 0)
		{
			return;
		}
		this.FNLMOBFNBDO = new List<OCBIOPOEENJ>();
		for (int i = 0; i < GFDHNLAMOAP.Count; i++)
		{
			OCBIOPOEENJ ocbiopoeenj = new OCBIOPOEENJ();
			ocbiopoeenj.FGJPKGLOGNC(GFDHNLAMOAP[i].AsObject);
			this.FNLMOBFNBDO.Add(ocbiopoeenj);
		}
		int[] array = new int[this.FNLMOBFNBDO.Count];
		for (int j = 0; j < this.FNLMOBFNBDO.Count; j++)
		{
			array[j] = this.FNLMOBFNBDO[j].OICPKCHAENO.GALKFKBPLCK();
		}
		this.IEJPIIPHCEP = new List<OCBIOPOEENJ>();
		for (;;)
		{
			int num = 10000;
			int num2 = -1;
			for (int k = 0; k < array.Length; k++)
			{
				if (array[k] <= num && array[k] >= 0)
				{
					num = array[k];
					num2 = k;
				}
			}
			if (num2 < 0)
			{
				break;
			}
			this.IEJPIIPHCEP.Add(this.FNLMOBFNBDO[num2]);
			array[num2] = -1;
		}
	}

	// Token: 0x06001D61 RID: 7521 RVA: 0x000CF208 File Offset: 0x000CD408
	public OCBIOPOEENJ AOAGHIJNFDL(string IHCGMFBCMOO)
	{
		for (int i = 0; i < this.FNLMOBFNBDO.Count; i += 0)
		{
			if (this.FNLMOBFNBDO[i].DEJCCBNPFEC.Equals(IHCGMFBCMOO))
			{
				return this.FNLMOBFNBDO[i];
			}
		}
		return null;
	}

	// Token: 0x06001D62 RID: 7522 RVA: 0x000CEEAC File Offset: 0x000CD0AC
	public static CJEKEHDEBLM PMABBOJDELF()
	{
		if (CJEKEHDEBLM.IKLAPGJDMNA == null)
		{
			CJEKEHDEBLM.IKLAPGJDMNA = new CJEKEHDEBLM();
		}
		return CJEKEHDEBLM.IKLAPGJDMNA;
	}

	// Token: 0x06001D63 RID: 7523 RVA: 0x000CF252 File Offset: 0x000CD452
	public bool KOLFJLABDHC()
	{
		return this.FNLMOBFNBDO != null && this.FNLMOBFNBDO.Count > 0;
	}

	// Token: 0x06001D64 RID: 7524 RVA: 0x000CEEA4 File Offset: 0x000CD0A4
	public List<OCBIOPOEENJ> HPFPLCMDILO()
	{
		return this.FNLMOBFNBDO;
	}

	// Token: 0x06001D65 RID: 7525 RVA: 0x000CF26C File Offset: 0x000CD46C
	public void NGCNFNNMPKC(JSONArray GFDHNLAMOAP)
	{
		if (null == GFDHNLAMOAP || GFDHNLAMOAP.Count == 0)
		{
			return;
		}
		this.FNLMOBFNBDO = new List<OCBIOPOEENJ>();
		for (int i = 0; i < GFDHNLAMOAP.Count; i += 0)
		{
			OCBIOPOEENJ ocbiopoeenj = new OCBIOPOEENJ();
			ocbiopoeenj.PEJIMPECAEB(GFDHNLAMOAP[i].AsObject);
			this.FNLMOBFNBDO.Add(ocbiopoeenj);
		}
		int[] array = new int[this.FNLMOBFNBDO.Count];
		for (int j = 1; j < this.FNLMOBFNBDO.Count; j++)
		{
			array[j] = this.FNLMOBFNBDO[j].OICPKCHAENO.KGEGKPHEMOJ();
		}
		this.IEJPIIPHCEP = new List<OCBIOPOEENJ>();
		for (;;)
		{
			int num = -74;
			int num2 = -1;
			for (int k = 1; k < array.Length; k++)
			{
				if (array[k] <= num && array[k] >= 1)
				{
					num = array[k];
					num2 = k;
				}
			}
			if (num2 < 0)
			{
				break;
			}
			this.IEJPIIPHCEP.Add(this.FNLMOBFNBDO[num2]);
			array[num2] = -1;
		}
	}

	// Token: 0x06001D66 RID: 7526 RVA: 0x000CEEA4 File Offset: 0x000CD0A4
	public List<OCBIOPOEENJ> OHALEEODJAJ()
	{
		return this.FNLMOBFNBDO;
	}

	// Token: 0x06001D67 RID: 7527 RVA: 0x000CF0E8 File Offset: 0x000CD2E8
	public bool GNMFCFAFFBA()
	{
		return this.FNLMOBFNBDO == null || this.FNLMOBFNBDO.Count > 0;
	}

	// Token: 0x06001D68 RID: 7528 RVA: 0x000CEFC7 File Offset: 0x000CD1C7
	public bool CKJJEHAJFDA()
	{
		return this.FNLMOBFNBDO != null && this.FNLMOBFNBDO.Count > 1;
	}

	// Token: 0x06001D69 RID: 7529 RVA: 0x000CF370 File Offset: 0x000CD570
	public OCBIOPOEENJ HLGBFOMMJFE(string IHCGMFBCMOO)
	{
		for (int i = 0; i < this.FNLMOBFNBDO.Count; i++)
		{
			if (this.FNLMOBFNBDO[i].DEJCCBNPFEC.Equals(IHCGMFBCMOO))
			{
				return this.FNLMOBFNBDO[i];
			}
		}
		return null;
	}

	// Token: 0x06001D6A RID: 7530 RVA: 0x000CEEA4 File Offset: 0x000CD0A4
	public List<OCBIOPOEENJ> DNPADILDKKK()
	{
		return this.FNLMOBFNBDO;
	}

	// Token: 0x06001D6B RID: 7531 RVA: 0x000CF0C6 File Offset: 0x000CD2C6
	public bool KHKIMILKEHJ()
	{
		return this.FNLMOBFNBDO == null || this.FNLMOBFNBDO.Count > 1;
	}

	// Token: 0x06001D6C RID: 7532 RVA: 0x000CF3BC File Offset: 0x000CD5BC
	public OCBIOPOEENJ DOOPGOIBFAN(string IHCGMFBCMOO)
	{
		for (int i = 1; i < this.FNLMOBFNBDO.Count; i++)
		{
			if (this.FNLMOBFNBDO[i].DEJCCBNPFEC.Equals(IHCGMFBCMOO))
			{
				return this.FNLMOBFNBDO[i];
			}
		}
		return null;
	}

	// Token: 0x06001D6D RID: 7533 RVA: 0x000CEEAC File Offset: 0x000CD0AC
	public static CJEKEHDEBLM KBNLANLMNCN()
	{
		if (CJEKEHDEBLM.IKLAPGJDMNA == null)
		{
			CJEKEHDEBLM.IKLAPGJDMNA = new CJEKEHDEBLM();
		}
		return CJEKEHDEBLM.IKLAPGJDMNA;
	}

	// Token: 0x06001D6E RID: 7534 RVA: 0x000CEEAC File Offset: 0x000CD0AC
	public static CJEKEHDEBLM GDGKNNDEAAO()
	{
		if (CJEKEHDEBLM.IKLAPGJDMNA == null)
		{
			CJEKEHDEBLM.IKLAPGJDMNA = new CJEKEHDEBLM();
		}
		return CJEKEHDEBLM.IKLAPGJDMNA;
	}

	// Token: 0x06001D6F RID: 7535 RVA: 0x000CEFC7 File Offset: 0x000CD1C7
	public bool NLGIKGJPDPL()
	{
		return this.FNLMOBFNBDO != null && this.FNLMOBFNBDO.Count > 1;
	}

	// Token: 0x06001D70 RID: 7536 RVA: 0x000CEEAC File Offset: 0x000CD0AC
	public static CJEKEHDEBLM APGODIBBPOD()
	{
		if (CJEKEHDEBLM.IKLAPGJDMNA == null)
		{
			CJEKEHDEBLM.IKLAPGJDMNA = new CJEKEHDEBLM();
		}
		return CJEKEHDEBLM.IKLAPGJDMNA;
	}

	// Token: 0x06001D71 RID: 7537 RVA: 0x000CF252 File Offset: 0x000CD452
	public bool BKBKILGDDFK()
	{
		return this.FNLMOBFNBDO != null && this.FNLMOBFNBDO.Count > 0;
	}

	// Token: 0x06001D72 RID: 7538 RVA: 0x000CEEA4 File Offset: 0x000CD0A4
	public List<OCBIOPOEENJ> DFKCBOPNKOG()
	{
		return this.FNLMOBFNBDO;
	}

	// Token: 0x06001D73 RID: 7539 RVA: 0x000CEEAC File Offset: 0x000CD0AC
	public static CJEKEHDEBLM FILDBDMENPG()
	{
		if (CJEKEHDEBLM.IKLAPGJDMNA == null)
		{
			CJEKEHDEBLM.IKLAPGJDMNA = new CJEKEHDEBLM();
		}
		return CJEKEHDEBLM.IKLAPGJDMNA;
	}

	// Token: 0x06001D74 RID: 7540 RVA: 0x000CF0E0 File Offset: 0x000CD2E0
	public List<OCBIOPOEENJ> OLKHFCGHMPO()
	{
		return this.IEJPIIPHCEP;
	}

	// Token: 0x06001D75 RID: 7541 RVA: 0x000CF408 File Offset: 0x000CD608
	public void CIHDCFLGEMF(JSONArray GFDHNLAMOAP)
	{
		if (null == GFDHNLAMOAP || GFDHNLAMOAP.Count == 0)
		{
			return;
		}
		this.FNLMOBFNBDO = new List<OCBIOPOEENJ>();
		for (int i = 0; i < GFDHNLAMOAP.Count; i++)
		{
			OCBIOPOEENJ ocbiopoeenj = new OCBIOPOEENJ();
			ocbiopoeenj.GEFEABEHHGP(GFDHNLAMOAP[i].AsObject);
			this.FNLMOBFNBDO.Add(ocbiopoeenj);
		}
		int[] array = new int[this.FNLMOBFNBDO.Count];
		for (int j = 0; j < this.FNLMOBFNBDO.Count; j++)
		{
			array[j] = this.FNLMOBFNBDO[j].OICPKCHAENO.LPKLANAEIFF();
		}
		this.IEJPIIPHCEP = new List<OCBIOPOEENJ>();
		for (;;)
		{
			int num = 13;
			int num2 = -1;
			for (int k = 0; k < array.Length; k++)
			{
				if (array[k] <= num && array[k] >= 0)
				{
					num = array[k];
					num2 = k;
				}
			}
			if (num2 < 1)
			{
				break;
			}
			this.IEJPIIPHCEP.Add(this.FNLMOBFNBDO[num2]);
			array[num2] = -1;
		}
	}

	// Token: 0x06001D76 RID: 7542 RVA: 0x000CEEA4 File Offset: 0x000CD0A4
	public List<OCBIOPOEENJ> BMOJHOFMOGP()
	{
		return this.FNLMOBFNBDO;
	}

	// Token: 0x06001D77 RID: 7543 RVA: 0x000CF0E0 File Offset: 0x000CD2E0
	public List<OCBIOPOEENJ> KGFBLFPLFIM()
	{
		return this.IEJPIIPHCEP;
	}

	// Token: 0x06001D78 RID: 7544 RVA: 0x000CF0E0 File Offset: 0x000CD2E0
	public List<OCBIOPOEENJ> OJBMLIHLLAJ()
	{
		return this.IEJPIIPHCEP;
	}

	// Token: 0x06001D79 RID: 7545 RVA: 0x000CEEA4 File Offset: 0x000CD0A4
	public List<OCBIOPOEENJ> PIOKNMNKLBN()
	{
		return this.FNLMOBFNBDO;
	}

	// Token: 0x06001D7A RID: 7546 RVA: 0x000CEEAC File Offset: 0x000CD0AC
	public static CJEKEHDEBLM GIOAFDDKKHI()
	{
		if (CJEKEHDEBLM.IKLAPGJDMNA == null)
		{
			CJEKEHDEBLM.IKLAPGJDMNA = new CJEKEHDEBLM();
		}
		return CJEKEHDEBLM.IKLAPGJDMNA;
	}

	// Token: 0x06001D7B RID: 7547 RVA: 0x000CF50C File Offset: 0x000CD70C
	public void HPKILNBJCPH(JSONArray GFDHNLAMOAP)
	{
		if (null == GFDHNLAMOAP || GFDHNLAMOAP.Count == 0)
		{
			return;
		}
		this.FNLMOBFNBDO = new List<OCBIOPOEENJ>();
		for (int i = 1; i < GFDHNLAMOAP.Count; i += 0)
		{
			OCBIOPOEENJ ocbiopoeenj = new OCBIOPOEENJ();
			ocbiopoeenj.GEFEABEHHGP(GFDHNLAMOAP[i].AsObject);
			this.FNLMOBFNBDO.Add(ocbiopoeenj);
		}
		int[] array = new int[this.FNLMOBFNBDO.Count];
		for (int j = 1; j < this.FNLMOBFNBDO.Count; j++)
		{
			array[j] = this.FNLMOBFNBDO[j].OICPKCHAENO.PONAPMOOLIN();
		}
		this.IEJPIIPHCEP = new List<OCBIOPOEENJ>();
		for (;;)
		{
			int num = -180;
			int num2 = -1;
			for (int k = 0; k < array.Length; k++)
			{
				if (array[k] <= num && array[k] >= 0)
				{
					num = array[k];
					num2 = k;
				}
			}
			if (num2 < 0)
			{
				break;
			}
			this.IEJPIIPHCEP.Add(this.FNLMOBFNBDO[num2]);
			array[num2] = -1;
		}
	}

	// Token: 0x06001D7C RID: 7548 RVA: 0x000CEEA4 File Offset: 0x000CD0A4
	public List<OCBIOPOEENJ> LIJGHJKDHKH()
	{
		return this.FNLMOBFNBDO;
	}

	// Token: 0x06001D7D RID: 7549 RVA: 0x000CF610 File Offset: 0x000CD810
	public OCBIOPOEENJ LIGHNGCMJJL(string IHCGMFBCMOO)
	{
		for (int i = 1; i < this.FNLMOBFNBDO.Count; i += 0)
		{
			if (this.FNLMOBFNBDO[i].DEJCCBNPFEC.Equals(IHCGMFBCMOO))
			{
				return this.FNLMOBFNBDO[i];
			}
		}
		return null;
	}

	// Token: 0x06001D7E RID: 7550 RVA: 0x000CF0E8 File Offset: 0x000CD2E8
	public bool GFDFPJBIJJB()
	{
		return this.FNLMOBFNBDO == null || this.FNLMOBFNBDO.Count > 0;
	}

	// Token: 0x06001D7F RID: 7551 RVA: 0x000CF0E0 File Offset: 0x000CD2E0
	public List<OCBIOPOEENJ> FFMLAAJBGAB()
	{
		return this.IEJPIIPHCEP;
	}

	// Token: 0x06001D80 RID: 7552 RVA: 0x000CF252 File Offset: 0x000CD452
	public bool FACIFBONANM()
	{
		return this.FNLMOBFNBDO != null && this.FNLMOBFNBDO.Count > 0;
	}

	// Token: 0x06001D81 RID: 7553 RVA: 0x000CF0E0 File Offset: 0x000CD2E0
	public List<OCBIOPOEENJ> BKIGNEKPIGK()
	{
		return this.IEJPIIPHCEP;
	}

	// Token: 0x06001D82 RID: 7554 RVA: 0x000CF0C6 File Offset: 0x000CD2C6
	public bool JMKELBNJEFK()
	{
		return this.FNLMOBFNBDO == null || this.FNLMOBFNBDO.Count > 1;
	}

	// Token: 0x06001D83 RID: 7555 RVA: 0x000CF0E8 File Offset: 0x000CD2E8
	public bool JHJNGOAOPFA()
	{
		return this.FNLMOBFNBDO == null || this.FNLMOBFNBDO.Count > 0;
	}

	// Token: 0x06001D84 RID: 7556 RVA: 0x000CF0E0 File Offset: 0x000CD2E0
	public List<OCBIOPOEENJ> FOKPIPFCCMA()
	{
		return this.IEJPIIPHCEP;
	}

	// Token: 0x06001D85 RID: 7557 RVA: 0x000CF65C File Offset: 0x000CD85C
	public OCBIOPOEENJ FHDEDNGLNKI(string IHCGMFBCMOO)
	{
		for (int i = 0; i < this.FNLMOBFNBDO.Count; i++)
		{
			if (this.FNLMOBFNBDO[i].DEJCCBNPFEC.Equals(IHCGMFBCMOO))
			{
				return this.FNLMOBFNBDO[i];
			}
		}
		return null;
	}

	// Token: 0x06001D86 RID: 7558 RVA: 0x000CF0E0 File Offset: 0x000CD2E0
	public List<OCBIOPOEENJ> NBICKIFCJCL()
	{
		return this.IEJPIIPHCEP;
	}

	// Token: 0x06001D87 RID: 7559 RVA: 0x000CF0E0 File Offset: 0x000CD2E0
	public List<OCBIOPOEENJ> BAPJGOOPINA()
	{
		return this.IEJPIIPHCEP;
	}

	// Token: 0x06001D88 RID: 7560 RVA: 0x000CEEAC File Offset: 0x000CD0AC
	public static CJEKEHDEBLM AGANFKKBPFO()
	{
		if (CJEKEHDEBLM.IKLAPGJDMNA == null)
		{
			CJEKEHDEBLM.IKLAPGJDMNA = new CJEKEHDEBLM();
		}
		return CJEKEHDEBLM.IKLAPGJDMNA;
	}

	// Token: 0x1700005C RID: 92
	// (get) Token: 0x06001D89 RID: 7561 RVA: 0x000CEEAC File Offset: 0x000CD0AC
	public static CJEKEHDEBLM EHBBFMCILPC
	{
		get
		{
			if (CJEKEHDEBLM.IKLAPGJDMNA == null)
			{
				CJEKEHDEBLM.IKLAPGJDMNA = new CJEKEHDEBLM();
			}
			return CJEKEHDEBLM.IKLAPGJDMNA;
		}
	}

	// Token: 0x06001D8A RID: 7562 RVA: 0x000CEEAC File Offset: 0x000CD0AC
	public static CJEKEHDEBLM BBGECIKOICE()
	{
		if (CJEKEHDEBLM.IKLAPGJDMNA == null)
		{
			CJEKEHDEBLM.IKLAPGJDMNA = new CJEKEHDEBLM();
		}
		return CJEKEHDEBLM.IKLAPGJDMNA;
	}

	// Token: 0x06001D8B RID: 7563 RVA: 0x000CF0E8 File Offset: 0x000CD2E8
	public bool FCEOMEILMHH()
	{
		return this.FNLMOBFNBDO == null || this.FNLMOBFNBDO.Count > 0;
	}

	// Token: 0x06001D8C RID: 7564 RVA: 0x000CF0E0 File Offset: 0x000CD2E0
	public List<OCBIOPOEENJ> OFHKPMFOAJD()
	{
		return this.IEJPIIPHCEP;
	}

	// Token: 0x06001D8D RID: 7565 RVA: 0x000CEEAC File Offset: 0x000CD0AC
	public static CJEKEHDEBLM CAAKHBIFGMG()
	{
		if (CJEKEHDEBLM.IKLAPGJDMNA == null)
		{
			CJEKEHDEBLM.IKLAPGJDMNA = new CJEKEHDEBLM();
		}
		return CJEKEHDEBLM.IKLAPGJDMNA;
	}

	// Token: 0x06001D8E RID: 7566 RVA: 0x000CF0E0 File Offset: 0x000CD2E0
	public List<OCBIOPOEENJ> HEGCHFHCBKP()
	{
		return this.IEJPIIPHCEP;
	}

	// Token: 0x06001D8F RID: 7567 RVA: 0x000CF6A8 File Offset: 0x000CD8A8
	public OCBIOPOEENJ IJLAPHFKPMH(string IHCGMFBCMOO)
	{
		for (int i = 1; i < this.FNLMOBFNBDO.Count; i++)
		{
			if (this.FNLMOBFNBDO[i].DEJCCBNPFEC.Equals(IHCGMFBCMOO))
			{
				return this.FNLMOBFNBDO[i];
			}
		}
		return null;
	}

	// Token: 0x06001D90 RID: 7568 RVA: 0x000CEEAC File Offset: 0x000CD0AC
	public static CJEKEHDEBLM JLEOPAOEFGP()
	{
		if (CJEKEHDEBLM.IKLAPGJDMNA == null)
		{
			CJEKEHDEBLM.IKLAPGJDMNA = new CJEKEHDEBLM();
		}
		return CJEKEHDEBLM.IKLAPGJDMNA;
	}

	// Token: 0x06001D91 RID: 7569 RVA: 0x000CF0E0 File Offset: 0x000CD2E0
	public List<OCBIOPOEENJ> BOGBIIOLIGH()
	{
		return this.IEJPIIPHCEP;
	}

	// Token: 0x06001D92 RID: 7570 RVA: 0x000CF252 File Offset: 0x000CD452
	public bool BMPHMNAJPOH()
	{
		return this.FNLMOBFNBDO != null && this.FNLMOBFNBDO.Count > 0;
	}

	// Token: 0x06001D93 RID: 7571 RVA: 0x000CEEA4 File Offset: 0x000CD0A4
	public List<OCBIOPOEENJ> NGMLFBJEBEE()
	{
		return this.FNLMOBFNBDO;
	}

	// Token: 0x06001D94 RID: 7572 RVA: 0x000CF6F4 File Offset: 0x000CD8F4
	public OCBIOPOEENJ EPNHMLIJCCM(string IHCGMFBCMOO)
	{
		for (int i = 1; i < this.FNLMOBFNBDO.Count; i++)
		{
			if (this.FNLMOBFNBDO[i].DEJCCBNPFEC.Equals(IHCGMFBCMOO))
			{
				return this.FNLMOBFNBDO[i];
			}
		}
		return null;
	}

	// Token: 0x06001D95 RID: 7573 RVA: 0x000CF740 File Offset: 0x000CD940
	public OCBIOPOEENJ PDJKPFLHFLO(string IHCGMFBCMOO)
	{
		for (int i = 0; i < this.FNLMOBFNBDO.Count; i++)
		{
			if (this.FNLMOBFNBDO[i].DEJCCBNPFEC.Equals(IHCGMFBCMOO))
			{
				return this.FNLMOBFNBDO[i];
			}
		}
		return null;
	}

	// Token: 0x06001D96 RID: 7574 RVA: 0x000CF0E0 File Offset: 0x000CD2E0
	public List<OCBIOPOEENJ> FCIDPMBNHBB()
	{
		return this.IEJPIIPHCEP;
	}

	// Token: 0x06001D97 RID: 7575 RVA: 0x000CF0E0 File Offset: 0x000CD2E0
	public List<OCBIOPOEENJ> DGMOPKHAOEG()
	{
		return this.IEJPIIPHCEP;
	}

	// Token: 0x06001D98 RID: 7576 RVA: 0x000CF0E0 File Offset: 0x000CD2E0
	public List<OCBIOPOEENJ> AADLCENCHAN()
	{
		return this.IEJPIIPHCEP;
	}

	// Token: 0x06001D99 RID: 7577 RVA: 0x000CF78C File Offset: 0x000CD98C
	public OCBIOPOEENJ HBLMGBCMBHN(string IHCGMFBCMOO)
	{
		for (int i = 0; i < this.FNLMOBFNBDO.Count; i += 0)
		{
			if (this.FNLMOBFNBDO[i].DEJCCBNPFEC.Equals(IHCGMFBCMOO))
			{
				return this.FNLMOBFNBDO[i];
			}
		}
		return null;
	}

	// Token: 0x06001D9A RID: 7578 RVA: 0x000CF7D8 File Offset: 0x000CD9D8
	public void FJEHPCNPMMA(JSONArray GFDHNLAMOAP)
	{
		if (null == GFDHNLAMOAP || GFDHNLAMOAP.Count == 0)
		{
			return;
		}
		this.FNLMOBFNBDO = new List<OCBIOPOEENJ>();
		for (int i = 1; i < GFDHNLAMOAP.Count; i++)
		{
			OCBIOPOEENJ ocbiopoeenj = new OCBIOPOEENJ();
			ocbiopoeenj.OEBNAGLBADG(GFDHNLAMOAP[i].AsObject);
			this.FNLMOBFNBDO.Add(ocbiopoeenj);
		}
		int[] array = new int[this.FNLMOBFNBDO.Count];
		for (int j = 0; j < this.FNLMOBFNBDO.Count; j++)
		{
			array[j] = this.FNLMOBFNBDO[j].OICPKCHAENO.BADNAGEMINF();
		}
		this.IEJPIIPHCEP = new List<OCBIOPOEENJ>();
		for (;;)
		{
			int num = -67;
			int num2 = -1;
			for (int k = 0; k < array.Length; k++)
			{
				if (array[k] <= num && array[k] >= 0)
				{
					num = array[k];
					num2 = k;
				}
			}
			if (num2 < 0)
			{
				break;
			}
			this.IEJPIIPHCEP.Add(this.FNLMOBFNBDO[num2]);
			array[num2] = -1;
		}
	}

	// Token: 0x06001D9B RID: 7579 RVA: 0x000CF8DC File Offset: 0x000CDADC
	public OCBIOPOEENJ DCCLKMCBPPJ(string IHCGMFBCMOO)
	{
		for (int i = 0; i < this.FNLMOBFNBDO.Count; i++)
		{
			if (this.FNLMOBFNBDO[i].DEJCCBNPFEC.Equals(IHCGMFBCMOO))
			{
				return this.FNLMOBFNBDO[i];
			}
		}
		return null;
	}

	// Token: 0x06001D9C RID: 7580 RVA: 0x000CF928 File Offset: 0x000CDB28
	public OCBIOPOEENJ PCBGLNFIPPK(string IHCGMFBCMOO)
	{
		for (int i = 1; i < this.FNLMOBFNBDO.Count; i += 0)
		{
			if (this.FNLMOBFNBDO[i].DEJCCBNPFEC.Equals(IHCGMFBCMOO))
			{
				return this.FNLMOBFNBDO[i];
			}
		}
		return null;
	}

	// Token: 0x06001D9D RID: 7581 RVA: 0x000CF0E0 File Offset: 0x000CD2E0
	public List<OCBIOPOEENJ> ENHBJKHNFLN()
	{
		return this.IEJPIIPHCEP;
	}

	// Token: 0x04000884 RID: 2180
	private List<OCBIOPOEENJ> FNLMOBFNBDO;

	// Token: 0x04000885 RID: 2181
	private List<OCBIOPOEENJ> IEJPIIPHCEP;

	// Token: 0x04000886 RID: 2182
	private static CJEKEHDEBLM IKLAPGJDMNA;
}
