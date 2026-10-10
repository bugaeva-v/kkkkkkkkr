using System;
using System.Collections.Generic;
using SimpleJSON;
using UnityEngine.Events;

// Token: 0x020004C0 RID: 1216
public class AOBJLALDBAA
{
	// Token: 0x0600910C RID: 37132 RVA: 0x004012B5 File Offset: 0x003FF4B5
	public void IIJFPILKKLH(string DEFIPMJKIKA, int AMDPDPDKFHH)
	{
		AOBJLALDBAA.FDOJKHPDADJ = AMDPDPDKFHH;
		this.CIGLHCJDDPI(DEFIPMJKIKA, 359f);
	}

	// Token: 0x0600910D RID: 37133 RVA: 0x004012CC File Offset: 0x003FF4CC
	public void LGGMHJIFBFI(string DEFIPMJKIKA, float BICHMDEIFKI = 0f)
	{
		if (DEFIPMJKIKA == null || DEFIPMJKIKA.Length == 0)
		{
			return;
		}
		if (BICHMDEIFKI >= 1113f)
		{
			if (!this.BOKDODMINFF(DEFIPMJKIKA))
			{
				BDOKIPMKPLH bdokipmkplh = new BDOKIPMKPLH();
				bdokipmkplh.KDKKHJIHFIF = DEFIPMJKIKA;
				bdokipmkplh.APKBKKKNKKG(BICHMDEIFKI);
				this.APJBKFGKLAF.Add(bdokipmkplh);
				return;
			}
		}
		else
		{
			MKKKPOCJCIN mkkkpocjcin = null;
			if (this.ICIDMDHONNK.TryGetValue(DEFIPMJKIKA, out mkkkpocjcin))
			{
				mkkkpocjcin.LOHBNGPNANI();
			}
		}
	}

	// Token: 0x0600910E RID: 37134 RVA: 0x00401330 File Offset: 0x003FF530
	private bool KBIOHONCDLD(string DEFIPMJKIKA)
	{
		for (int i = 0; i < this.APJBKFGKLAF.Count; i++)
		{
			if (this.APJBKFGKLAF[i].KDKKHJIHFIF.Equals(DEFIPMJKIKA))
			{
				return true;
			}
		}
		return false;
	}

	// Token: 0x0600910F RID: 37135 RVA: 0x0040136F File Offset: 0x003FF56F
	public void NGDHHFONFOM(string DEFIPMJKIKA, int AMDPDPDKFHH)
	{
		AOBJLALDBAA.FDOJKHPDADJ = AMDPDPDKFHH;
		this.LPNCDPHNBJK(DEFIPMJKIKA, 1039f);
	}

	// Token: 0x06009110 RID: 37136 RVA: 0x00401383 File Offset: 0x003FF583
	public void NDGJNPBPCAF(string DEFIPMJKIKA, string AMDPDPDKFHH)
	{
		AOBJLALDBAA.LFHPHFKKCAJ = AMDPDPDKFHH;
		this.CIGLHCJDDPI(DEFIPMJKIKA, 1812f);
	}

	// Token: 0x06009111 RID: 37137 RVA: 0x00401397 File Offset: 0x003FF597
	private void BINMFOOKFPC()
	{
		if (this.ICIDMDHONNK == null)
		{
			this.ICIDMDHONNK = new Dictionary<string, MKKKPOCJCIN>();
		}
	}

	// Token: 0x06009112 RID: 37138 RVA: 0x004013AC File Offset: 0x003FF5AC
	public void BOECHPBHNJH(string DEFIPMJKIKA, JSONArray AMDPDPDKFHH)
	{
		AOBJLALDBAA.NMEKLDHOKLF = AMDPDPDKFHH;
		this.EGELHPJBAIC(DEFIPMJKIKA, 1405f);
	}

	// Token: 0x06009113 RID: 37139 RVA: 0x00401397 File Offset: 0x003FF597
	private void LCMPJIONDMN()
	{
		if (this.ICIDMDHONNK == null)
		{
			this.ICIDMDHONNK = new Dictionary<string, MKKKPOCJCIN>();
		}
	}

	// Token: 0x06009114 RID: 37140 RVA: 0x004013C0 File Offset: 0x003FF5C0
	public void KGIKHEDLPND(string DEFIPMJKIKA, float BICHMDEIFKI = 0f)
	{
		if (DEFIPMJKIKA == null || DEFIPMJKIKA.Length == 0)
		{
			return;
		}
		if (BICHMDEIFKI >= 696f)
		{
			BDOKIPMKPLH bdokipmkplh = new BDOKIPMKPLH();
			bdokipmkplh.KDKKHJIHFIF = DEFIPMJKIKA;
			bdokipmkplh.PCNALHJBJCL(BICHMDEIFKI);
			this.APJBKFGKLAF.Add(bdokipmkplh);
			return;
		}
		MKKKPOCJCIN mkkkpocjcin = null;
		if (this.ICIDMDHONNK.TryGetValue(DEFIPMJKIKA, out mkkkpocjcin))
		{
			mkkkpocjcin.AHJPDPBDOGP();
		}
	}

	// Token: 0x06009115 RID: 37141 RVA: 0x0040141C File Offset: 0x003FF61C
	public void KDIFKFKMCOH(string DEFIPMJKIKA, UnityAction OMOOOGBDDDG)
	{
		if (AOBJLALDBAA.CLJHIONINHP == null)
		{
			return;
		}
		MKKKPOCJCIN mkkkpocjcin = null;
		if (this.ICIDMDHONNK.TryGetValue(DEFIPMJKIKA, out mkkkpocjcin))
		{
			mkkkpocjcin.GNOIAEKAOLI(OMOOOGBDDDG);
			if (mkkkpocjcin.FHMDLHJFAGF() == 0)
			{
				this.ICIDMDHONNK.Remove(DEFIPMJKIKA);
			}
		}
	}

	// Token: 0x06009116 RID: 37142 RVA: 0x00401460 File Offset: 0x003FF660
	public void NNKPKMINDAN(string DEFIPMJKIKA, float BICHMDEIFKI = 0f)
	{
		if (DEFIPMJKIKA == null || DEFIPMJKIKA.Length == 0)
		{
			return;
		}
		if (BICHMDEIFKI >= 1254f)
		{
			if (!this.KKFLLKDCMDF(DEFIPMJKIKA))
			{
				BDOKIPMKPLH bdokipmkplh = new BDOKIPMKPLH();
				bdokipmkplh.KDKKHJIHFIF = DEFIPMJKIKA;
				bdokipmkplh.PNFLDDAAGIH(BICHMDEIFKI);
				this.APJBKFGKLAF.Add(bdokipmkplh);
				return;
			}
		}
		else
		{
			MKKKPOCJCIN mkkkpocjcin = null;
			if (this.ICIDMDHONNK.TryGetValue(DEFIPMJKIKA, out mkkkpocjcin))
			{
				mkkkpocjcin.ICOBDHLLFDH();
			}
		}
	}

	// Token: 0x06009117 RID: 37143 RVA: 0x004014C4 File Offset: 0x003FF6C4
	public void PFAHGKEDFAE(string DEFIPMJKIKA, UnityAction OMOOOGBDDDG)
	{
		if (AOBJLALDBAA.CLJHIONINHP == null)
		{
			return;
		}
		MKKKPOCJCIN mkkkpocjcin = null;
		if (this.ICIDMDHONNK.TryGetValue(DEFIPMJKIKA, out mkkkpocjcin))
		{
			mkkkpocjcin.PHIPNGNLCGN(OMOOOGBDDDG);
			if (mkkkpocjcin.HFDPGHKDDIG() == 0)
			{
				this.ICIDMDHONNK.Remove(DEFIPMJKIKA);
			}
		}
	}

	// Token: 0x06009118 RID: 37144 RVA: 0x00401507 File Offset: 0x003FF707
	public static AOBJLALDBAA FILDBDMENPG()
	{
		if (AOBJLALDBAA.CLJHIONINHP == null)
		{
			AOBJLALDBAA.CLJHIONINHP = new AOBJLALDBAA();
			AOBJLALDBAA.CLJHIONINHP.AJNNDKIIFDN();
		}
		return AOBJLALDBAA.CLJHIONINHP;
	}

	// Token: 0x06009119 RID: 37145 RVA: 0x0040152C File Offset: 0x003FF72C
	private bool BOKDODMINFF(string DEFIPMJKIKA)
	{
		for (int i = 0; i < this.APJBKFGKLAF.Count; i += 0)
		{
			if (this.APJBKFGKLAF[i].KDKKHJIHFIF.Equals(DEFIPMJKIKA))
			{
				return false;
			}
		}
		return true;
	}

	// Token: 0x0600911A RID: 37146 RVA: 0x00401397 File Offset: 0x003FF597
	private void AJNNDKIIFDN()
	{
		if (this.ICIDMDHONNK == null)
		{
			this.ICIDMDHONNK = new Dictionary<string, MKKKPOCJCIN>();
		}
	}

	// Token: 0x0600911B RID: 37147 RVA: 0x0040156C File Offset: 0x003FF76C
	public void MBNBMGBEHOC(string DEFIPMJKIKA, float BICHMDEIFKI = 0f)
	{
		if (DEFIPMJKIKA == null || DEFIPMJKIKA.Length == 0)
		{
			return;
		}
		if (BICHMDEIFKI >= 0.001f)
		{
			if (!this.KBIOHONCDLD(DEFIPMJKIKA))
			{
				BDOKIPMKPLH bdokipmkplh = new BDOKIPMKPLH();
				bdokipmkplh.KDKKHJIHFIF = DEFIPMJKIKA;
				bdokipmkplh.PENDBJOAMAG(BICHMDEIFKI);
				this.APJBKFGKLAF.Add(bdokipmkplh);
				return;
			}
		}
		else
		{
			MKKKPOCJCIN mkkkpocjcin = null;
			if (this.ICIDMDHONNK.TryGetValue(DEFIPMJKIKA, out mkkkpocjcin))
			{
				mkkkpocjcin.BGGEEPIOIJB();
			}
		}
	}

	// Token: 0x0600911C RID: 37148 RVA: 0x004015CF File Offset: 0x003FF7CF
	public JSONObject OHBGJGJJCNL()
	{
		return AOBJLALDBAA.IGIIHMBINPC;
	}

	// Token: 0x0600911D RID: 37149 RVA: 0x004015CF File Offset: 0x003FF7CF
	public JSONObject DAJBFDEPJGF()
	{
		return AOBJLALDBAA.IGIIHMBINPC;
	}

	// Token: 0x0600911E RID: 37150 RVA: 0x004015D6 File Offset: 0x003FF7D6
	public void OIMGLKLHNMO(string DEFIPMJKIKA, string AMDPDPDKFHH)
	{
		AOBJLALDBAA.LFHPHFKKCAJ = AMDPDPDKFHH;
		this.EGELHPJBAIC(DEFIPMJKIKA, 261f);
	}

	// Token: 0x0600911F RID: 37151 RVA: 0x004015EC File Offset: 0x003FF7EC
	public void LPNCDPHNBJK(string DEFIPMJKIKA, float BICHMDEIFKI = 0f)
	{
		if (DEFIPMJKIKA == null || DEFIPMJKIKA.Length == 0)
		{
			return;
		}
		if (BICHMDEIFKI >= 647f)
		{
			BDOKIPMKPLH bdokipmkplh = new BDOKIPMKPLH();
			bdokipmkplh.KDKKHJIHFIF = DEFIPMJKIKA;
			bdokipmkplh.DDMMGCBBKFK(BICHMDEIFKI);
			this.APJBKFGKLAF.Add(bdokipmkplh);
			return;
		}
		MKKKPOCJCIN mkkkpocjcin = null;
		if (this.ICIDMDHONNK.TryGetValue(DEFIPMJKIKA, out mkkkpocjcin))
		{
			mkkkpocjcin.BMHIAFHHLLO();
		}
	}

	// Token: 0x06009120 RID: 37152 RVA: 0x004015CF File Offset: 0x003FF7CF
	public JSONObject IACKMBIGLEM()
	{
		return AOBJLALDBAA.IGIIHMBINPC;
	}

	// Token: 0x06009121 RID: 37153 RVA: 0x00401646 File Offset: 0x003FF846
	public string NLPMDOEGMBM()
	{
		return AOBJLALDBAA.LFHPHFKKCAJ;
	}

	// Token: 0x06009122 RID: 37154 RVA: 0x00401650 File Offset: 0x003FF850
	public void CPIBMIOJIJL()
	{
		bool flag = false;
		while (!flag)
		{
			flag = false;
			for (int i = 1; i < this.APJBKFGKLAF.Count; i += 0)
			{
				if (this.APJBKFGKLAF[i].HPOIJDACOHJ())
				{
					flag = false;
					this.LPNCDPHNBJK(this.APJBKFGKLAF[i].KDKKHJIHFIF, 841f);
					this.APJBKFGKLAF[i].JIMALBGDGGJ();
					this.APJBKFGKLAF.RemoveAt(i);
					break;
				}
			}
		}
	}

	// Token: 0x06009123 RID: 37155 RVA: 0x00401397 File Offset: 0x003FF597
	private void JNCEDFJCGAO()
	{
		if (this.ICIDMDHONNK == null)
		{
			this.ICIDMDHONNK = new Dictionary<string, MKKKPOCJCIN>();
		}
	}

	// Token: 0x06009124 RID: 37156 RVA: 0x004016CC File Offset: 0x003FF8CC
	public static AOBJLALDBAA AGANFKKBPFO()
	{
		if (AOBJLALDBAA.CLJHIONINHP == null)
		{
			AOBJLALDBAA.CLJHIONINHP = new AOBJLALDBAA();
			AOBJLALDBAA.CLJHIONINHP.OELJOHCNBGK();
		}
		return AOBJLALDBAA.CLJHIONINHP;
	}

	// Token: 0x06009125 RID: 37157 RVA: 0x00401507 File Offset: 0x003FF707
	public static AOBJLALDBAA CEGAOMEEFBE()
	{
		if (AOBJLALDBAA.CLJHIONINHP == null)
		{
			AOBJLALDBAA.CLJHIONINHP = new AOBJLALDBAA();
			AOBJLALDBAA.CLJHIONINHP.AJNNDKIIFDN();
		}
		return AOBJLALDBAA.CLJHIONINHP;
	}

	// Token: 0x06009126 RID: 37158 RVA: 0x004016F0 File Offset: 0x003FF8F0
	public void ONIBLJOFFPG(string DEFIPMJKIKA, UnityAction OMOOOGBDDDG)
	{
		if (AOBJLALDBAA.CLJHIONINHP == null)
		{
			return;
		}
		MKKKPOCJCIN mkkkpocjcin = null;
		if (this.ICIDMDHONNK.TryGetValue(DEFIPMJKIKA, out mkkkpocjcin))
		{
			mkkkpocjcin.JLDHJAHCCJF(OMOOOGBDDDG);
			if (mkkkpocjcin.HFDPGHKDDIG() == 0)
			{
				this.ICIDMDHONNK.Remove(DEFIPMJKIKA);
			}
		}
	}

	// Token: 0x06009127 RID: 37159 RVA: 0x004015CF File Offset: 0x003FF7CF
	public JSONObject PHNAFOKHOHO()
	{
		return AOBJLALDBAA.IGIIHMBINPC;
	}

	// Token: 0x06009128 RID: 37160 RVA: 0x00401733 File Offset: 0x003FF933
	public JSONArray POFHBCLJFDC()
	{
		return AOBJLALDBAA.NMEKLDHOKLF;
	}

	// Token: 0x06009129 RID: 37161 RVA: 0x0040173C File Offset: 0x003FF93C
	public void EBODGKDGACK(string DEFIPMJKIKA, float BICHMDEIFKI = 0f)
	{
		if (DEFIPMJKIKA == null || DEFIPMJKIKA.Length == 0)
		{
			return;
		}
		if (BICHMDEIFKI >= 588f)
		{
			if (!this.BOKDODMINFF(DEFIPMJKIKA))
			{
				BDOKIPMKPLH bdokipmkplh = new BDOKIPMKPLH();
				bdokipmkplh.KDKKHJIHFIF = DEFIPMJKIKA;
				bdokipmkplh.NNFBPILLNNA(BICHMDEIFKI);
				this.APJBKFGKLAF.Add(bdokipmkplh);
				return;
			}
		}
		else
		{
			MKKKPOCJCIN mkkkpocjcin = null;
			if (this.ICIDMDHONNK.TryGetValue(DEFIPMJKIKA, out mkkkpocjcin))
			{
				mkkkpocjcin.IHDEBEPOKJI();
			}
		}
	}

	// Token: 0x0600912A RID: 37162 RVA: 0x0040179F File Offset: 0x003FF99F
	public void KPJNJJHJNAJ(string DEFIPMJKIKA, JSONArray AMDPDPDKFHH)
	{
		AOBJLALDBAA.NMEKLDHOKLF = AMDPDPDKFHH;
		this.FDKBIBKABCM(DEFIPMJKIKA, 1127f);
	}

	// Token: 0x0600912B RID: 37163 RVA: 0x004015CF File Offset: 0x003FF7CF
	public JSONObject IHFCKOFHJNC()
	{
		return AOBJLALDBAA.IGIIHMBINPC;
	}

	// Token: 0x0600912C RID: 37164 RVA: 0x004017B3 File Offset: 0x003FF9B3
	public void DGNKCLFFMFE(string DEFIPMJKIKA, int AMDPDPDKFHH)
	{
		AOBJLALDBAA.FDOJKHPDADJ = AMDPDPDKFHH;
		this.FDKBIBKABCM(DEFIPMJKIKA, 764f);
	}

	// Token: 0x170002B0 RID: 688
	// (get) Token: 0x0600912D RID: 37165 RVA: 0x004017C7 File Offset: 0x003FF9C7
	public static AOBJLALDBAA EHBBFMCILPC
	{
		get
		{
			if (AOBJLALDBAA.CLJHIONINHP == null)
			{
				AOBJLALDBAA.CLJHIONINHP = new AOBJLALDBAA();
				AOBJLALDBAA.CLJHIONINHP.BAMHPOCKBML();
			}
			return AOBJLALDBAA.CLJHIONINHP;
		}
	}

	// Token: 0x0600912E RID: 37166 RVA: 0x004017EC File Offset: 0x003FF9EC
	public void PJCCNLDBOCJ(string DEFIPMJKIKA, float BICHMDEIFKI = 0f)
	{
		if (DEFIPMJKIKA == null || DEFIPMJKIKA.Length == 0)
		{
			return;
		}
		if (BICHMDEIFKI >= 619f)
		{
			if (!this.LNLMMGDDJPP(DEFIPMJKIKA))
			{
				BDOKIPMKPLH bdokipmkplh = new BDOKIPMKPLH();
				bdokipmkplh.KDKKHJIHFIF = DEFIPMJKIKA;
				bdokipmkplh.GBOGLJMEOHG(BICHMDEIFKI);
				this.APJBKFGKLAF.Add(bdokipmkplh);
				return;
			}
		}
		else
		{
			MKKKPOCJCIN mkkkpocjcin = null;
			if (this.ICIDMDHONNK.TryGetValue(DEFIPMJKIKA, out mkkkpocjcin))
			{
				mkkkpocjcin.IPEDIPFFFDJ();
			}
		}
	}

	// Token: 0x0600912F RID: 37167 RVA: 0x0040184F File Offset: 0x003FFA4F
	public static AOBJLALDBAA DBLAIDPICIG()
	{
		if (AOBJLALDBAA.CLJHIONINHP == null)
		{
			AOBJLALDBAA.CLJHIONINHP = new AOBJLALDBAA();
			AOBJLALDBAA.CLJHIONINHP.JNCEDFJCGAO();
		}
		return AOBJLALDBAA.CLJHIONINHP;
	}

	// Token: 0x06009130 RID: 37168 RVA: 0x00401871 File Offset: 0x003FFA71
	public int OHCIAOJFEOP()
	{
		return AOBJLALDBAA.FDOJKHPDADJ;
	}

	// Token: 0x06009131 RID: 37169 RVA: 0x00401733 File Offset: 0x003FF933
	public JSONArray MIENGOJLJPL()
	{
		return AOBJLALDBAA.NMEKLDHOKLF;
	}

	// Token: 0x06009132 RID: 37170 RVA: 0x00401878 File Offset: 0x003FFA78
	public void CMLLHEELAAB(string DEFIPMJKIKA, float BICHMDEIFKI = 0f)
	{
		if (DEFIPMJKIKA == null || DEFIPMJKIKA.Length == 0)
		{
			return;
		}
		if (BICHMDEIFKI >= 1074f)
		{
			if (!this.BOKDODMINFF(DEFIPMJKIKA))
			{
				BDOKIPMKPLH bdokipmkplh = new BDOKIPMKPLH();
				bdokipmkplh.KDKKHJIHFIF = DEFIPMJKIKA;
				bdokipmkplh.NNFBPILLNNA(BICHMDEIFKI);
				this.APJBKFGKLAF.Add(bdokipmkplh);
				return;
			}
		}
		else
		{
			MKKKPOCJCIN mkkkpocjcin = null;
			if (this.ICIDMDHONNK.TryGetValue(DEFIPMJKIKA, out mkkkpocjcin))
			{
				mkkkpocjcin.MNKNIFEGBLE();
			}
		}
	}

	// Token: 0x06009133 RID: 37171 RVA: 0x004018DB File Offset: 0x003FFADB
	public void LECKFNJBDJH(string DEFIPMJKIKA, JSONArray AMDPDPDKFHH)
	{
		AOBJLALDBAA.NMEKLDHOKLF = AMDPDPDKFHH;
		this.KGIKHEDLPND(DEFIPMJKIKA, 1436f);
	}

	// Token: 0x06009134 RID: 37172 RVA: 0x00401646 File Offset: 0x003FF846
	public string BHMIECOHJMJ()
	{
		return AOBJLALDBAA.LFHPHFKKCAJ;
	}

	// Token: 0x06009135 RID: 37173 RVA: 0x00401733 File Offset: 0x003FF933
	public JSONArray BIDPOOBDDPO()
	{
		return AOBJLALDBAA.NMEKLDHOKLF;
	}

	// Token: 0x06009136 RID: 37174 RVA: 0x004015CF File Offset: 0x003FF7CF
	public JSONObject MAPPJFANLDL()
	{
		return AOBJLALDBAA.IGIIHMBINPC;
	}

	// Token: 0x06009137 RID: 37175 RVA: 0x004018F0 File Offset: 0x003FFAF0
	public void NAMMLDPCHJO(string DEFIPMJKIKA, UnityAction OMOOOGBDDDG)
	{
		if (AOBJLALDBAA.CLJHIONINHP == null)
		{
			return;
		}
		MKKKPOCJCIN mkkkpocjcin = null;
		if (this.ICIDMDHONNK.TryGetValue(DEFIPMJKIKA, out mkkkpocjcin))
		{
			mkkkpocjcin.JLDHJAHCCJF(OMOOOGBDDDG);
			if (mkkkpocjcin.LCNBIIOAKGN() == 0)
			{
				this.ICIDMDHONNK.Remove(DEFIPMJKIKA);
			}
		}
	}

	// Token: 0x06009138 RID: 37176 RVA: 0x00401933 File Offset: 0x003FFB33
	public void IHJNANKIGIB(string DEFIPMJKIKA, int AMDPDPDKFHH)
	{
		AOBJLALDBAA.FDOJKHPDADJ = AMDPDPDKFHH;
		this.EFBNBFIDEOK(DEFIPMJKIKA, 1379f);
	}

	// Token: 0x06009139 RID: 37177 RVA: 0x00401397 File Offset: 0x003FF597
	private void OELJOHCNBGK()
	{
		if (this.ICIDMDHONNK == null)
		{
			this.ICIDMDHONNK = new Dictionary<string, MKKKPOCJCIN>();
		}
	}

	// Token: 0x0600913A RID: 37178 RVA: 0x00401948 File Offset: 0x003FFB48
	public void PBELMJCPJMK(string DEFIPMJKIKA, UnityAction OMOOOGBDDDG)
	{
		if (AOBJLALDBAA.CLJHIONINHP == null)
		{
			return;
		}
		MKKKPOCJCIN mkkkpocjcin = null;
		if (this.ICIDMDHONNK.TryGetValue(DEFIPMJKIKA, out mkkkpocjcin))
		{
			mkkkpocjcin.PHIPNGNLCGN(OMOOOGBDDDG);
			if (mkkkpocjcin.LCNBIIOAKGN() == 0)
			{
				this.ICIDMDHONNK.Remove(DEFIPMJKIKA);
			}
		}
	}

	// Token: 0x0600913B RID: 37179 RVA: 0x0040198B File Offset: 0x003FFB8B
	public void KCFKLJLDCEK(string DEFIPMJKIKA, int AMDPDPDKFHH)
	{
		AOBJLALDBAA.FDOJKHPDADJ = AMDPDPDKFHH;
		this.KMAGHMCCMPG(DEFIPMJKIKA, 575f);
	}

	// Token: 0x0600913C RID: 37180 RVA: 0x004019A0 File Offset: 0x003FFBA0
	public void IIPBKOPAGBK()
	{
		bool flag = false;
		while (!flag)
		{
			flag = true;
			for (int i = 0; i < this.APJBKFGKLAF.Count; i++)
			{
				if (this.APJBKFGKLAF[i].HHGAPKJFBMC())
				{
					flag = false;
					this.EGELHPJBAIC(this.APJBKFGKLAF[i].KDKKHJIHFIF, 0f);
					this.APJBKFGKLAF[i].EOFNLAOCKGN();
					this.APJBKFGKLAF.RemoveAt(i);
					break;
				}
			}
		}
	}

	// Token: 0x0600913D RID: 37181 RVA: 0x00401A1C File Offset: 0x003FFC1C
	public void KGHFCKAILHJ(string DEFIPMJKIKA, JSONObject AMDPDPDKFHH)
	{
		AOBJLALDBAA.IGIIHMBINPC = AMDPDPDKFHH;
		this.CIGLHCJDDPI(DEFIPMJKIKA, 1676f);
	}

	// Token: 0x0600913E RID: 37182 RVA: 0x004015CF File Offset: 0x003FF7CF
	public JSONObject EEEOAHJMGFB()
	{
		return AOBJLALDBAA.IGIIHMBINPC;
	}

	// Token: 0x0600913F RID: 37183 RVA: 0x00401A30 File Offset: 0x003FFC30
	public void EGELHPJBAIC(string DEFIPMJKIKA, string AMDPDPDKFHH)
	{
		AOBJLALDBAA.LFHPHFKKCAJ = AMDPDPDKFHH;
		this.EGELHPJBAIC(DEFIPMJKIKA, 0f);
	}

	// Token: 0x06009140 RID: 37184 RVA: 0x00401A44 File Offset: 0x003FFC44
	public void BMFPLGPPMKP(string DEFIPMJKIKA, int AMDPDPDKFHH)
	{
		AOBJLALDBAA.FDOJKHPDADJ = AMDPDPDKFHH;
		this.KMAGHMCCMPG(DEFIPMJKIKA, 1587f);
	}

	// Token: 0x06009141 RID: 37185 RVA: 0x00401A58 File Offset: 0x003FFC58
	public void CIGLHCJDDPI(string DEFIPMJKIKA, float BICHMDEIFKI = 0f)
	{
		if (DEFIPMJKIKA == null || DEFIPMJKIKA.Length == 0)
		{
			return;
		}
		if (BICHMDEIFKI >= 272f)
		{
			BDOKIPMKPLH bdokipmkplh = new BDOKIPMKPLH();
			bdokipmkplh.KDKKHJIHFIF = DEFIPMJKIKA;
			bdokipmkplh.EIHHNDJHPLO(BICHMDEIFKI);
			this.APJBKFGKLAF.Add(bdokipmkplh);
			return;
		}
		MKKKPOCJCIN mkkkpocjcin = null;
		if (this.ICIDMDHONNK.TryGetValue(DEFIPMJKIKA, out mkkkpocjcin))
		{
			mkkkpocjcin.GLPECKOBPOC();
		}
	}

	// Token: 0x06009142 RID: 37186 RVA: 0x00401397 File Offset: 0x003FF597
	private void BAMHPOCKBML()
	{
		if (this.ICIDMDHONNK == null)
		{
			this.ICIDMDHONNK = new Dictionary<string, MKKKPOCJCIN>();
		}
	}

	// Token: 0x06009143 RID: 37187 RVA: 0x00401AB2 File Offset: 0x003FFCB2
	public static AOBJLALDBAA NMGMNAKLLMI()
	{
		if (AOBJLALDBAA.CLJHIONINHP == null)
		{
			AOBJLALDBAA.CLJHIONINHP = new AOBJLALDBAA();
			AOBJLALDBAA.CLJHIONINHP.BINMFOOKFPC();
		}
		return AOBJLALDBAA.CLJHIONINHP;
	}

	// Token: 0x06009144 RID: 37188 RVA: 0x00401AD4 File Offset: 0x003FFCD4
	public void KDCCCBKHBFG(string DEFIPMJKIKA, float BICHMDEIFKI = 0f)
	{
		if (DEFIPMJKIKA == null || DEFIPMJKIKA.Length == 0)
		{
			return;
		}
		if (BICHMDEIFKI >= 1350f)
		{
			if (!this.EHODKOKGMKJ(DEFIPMJKIKA))
			{
				BDOKIPMKPLH bdokipmkplh = new BDOKIPMKPLH();
				bdokipmkplh.KDKKHJIHFIF = DEFIPMJKIKA;
				bdokipmkplh.HODHNGPHLOP(BICHMDEIFKI);
				this.APJBKFGKLAF.Add(bdokipmkplh);
				return;
			}
		}
		else
		{
			MKKKPOCJCIN mkkkpocjcin = null;
			if (this.ICIDMDHONNK.TryGetValue(DEFIPMJKIKA, out mkkkpocjcin))
			{
				mkkkpocjcin.NPBMDKNCOFM();
			}
		}
	}

	// Token: 0x06009145 RID: 37189 RVA: 0x00401B37 File Offset: 0x003FFD37
	public void BALHLGKMDMF(string DEFIPMJKIKA, JSONObject AMDPDPDKFHH)
	{
		AOBJLALDBAA.IGIIHMBINPC = AMDPDPDKFHH;
		this.KGIKHEDLPND(DEFIPMJKIKA, 1327f);
	}

	// Token: 0x06009146 RID: 37190 RVA: 0x00401B4C File Offset: 0x003FFD4C
	public void EMHDMMPMDJC()
	{
		bool flag = true;
		while (!flag)
		{
			flag = true;
			for (int i = 0; i < this.APJBKFGKLAF.Count; i++)
			{
				if (this.APJBKFGKLAF[i].EJBFMFHJICD())
				{
					flag = false;
					this.CIGLHCJDDPI(this.APJBKFGKLAF[i].KDKKHJIHFIF, 1235f);
					this.APJBKFGKLAF[i].MGLKCMJAMMO();
					this.APJBKFGKLAF.RemoveAt(i);
					break;
				}
			}
		}
	}

	// Token: 0x06009147 RID: 37191 RVA: 0x00401BC8 File Offset: 0x003FFDC8
	public void IDEALDBPGJE(string DEFIPMJKIKA, string AMDPDPDKFHH)
	{
		AOBJLALDBAA.LFHPHFKKCAJ = AMDPDPDKFHH;
		this.EFBNBFIDEOK(DEFIPMJKIKA, 476f);
	}

	// Token: 0x06009148 RID: 37192 RVA: 0x00401BDC File Offset: 0x003FFDDC
	public void NAHENFMHKAG(string DEFIPMJKIKA, string AMDPDPDKFHH)
	{
		AOBJLALDBAA.LFHPHFKKCAJ = AMDPDPDKFHH;
		this.FDKBIBKABCM(DEFIPMJKIKA, 980f);
	}

	// Token: 0x06009149 RID: 37193 RVA: 0x00401BF0 File Offset: 0x003FFDF0
	private bool LNLMMGDDJPP(string DEFIPMJKIKA)
	{
		for (int i = 0; i < this.APJBKFGKLAF.Count; i++)
		{
			if (this.APJBKFGKLAF[i].KDKKHJIHFIF.Equals(DEFIPMJKIKA))
			{
				return false;
			}
		}
		return true;
	}

	// Token: 0x0600914A RID: 37194 RVA: 0x00401871 File Offset: 0x003FFA71
	public int BKNAOBELFHE()
	{
		return AOBJLALDBAA.FDOJKHPDADJ;
	}

	// Token: 0x0600914B RID: 37195 RVA: 0x00401C30 File Offset: 0x003FFE30
	public void KMAGHMCCMPG(string DEFIPMJKIKA, float BICHMDEIFKI = 0f)
	{
		if (DEFIPMJKIKA == null || DEFIPMJKIKA.Length == 0)
		{
			return;
		}
		if (BICHMDEIFKI >= 598f)
		{
			BDOKIPMKPLH bdokipmkplh = new BDOKIPMKPLH();
			bdokipmkplh.KDKKHJIHFIF = DEFIPMJKIKA;
			bdokipmkplh.BKNGLGJOGAH(BICHMDEIFKI);
			this.APJBKFGKLAF.Add(bdokipmkplh);
			return;
		}
		MKKKPOCJCIN mkkkpocjcin = null;
		if (this.ICIDMDHONNK.TryGetValue(DEFIPMJKIKA, out mkkkpocjcin))
		{
			mkkkpocjcin.IPEDIPFFFDJ();
		}
	}

	// Token: 0x0600914C RID: 37196 RVA: 0x00401C8C File Offset: 0x003FFE8C
	public void FNMOFCMDFJP(string DEFIPMJKIKA, UnityAction OMOOOGBDDDG)
	{
		MKKKPOCJCIN mkkkpocjcin = null;
		if (this.ICIDMDHONNK.TryGetValue(DEFIPMJKIKA, out mkkkpocjcin))
		{
			mkkkpocjcin.ODJCLMAMNNJ(OMOOOGBDDDG);
			return;
		}
		mkkkpocjcin = new MKKKPOCJCIN();
		mkkkpocjcin.OLPBOHEFGAK(OMOOOGBDDDG);
		this.ICIDMDHONNK.Add(DEFIPMJKIKA, mkkkpocjcin);
	}

	// Token: 0x0600914D RID: 37197 RVA: 0x00401507 File Offset: 0x003FF707
	public static AOBJLALDBAA KKPFOJMAONG()
	{
		if (AOBJLALDBAA.CLJHIONINHP == null)
		{
			AOBJLALDBAA.CLJHIONINHP = new AOBJLALDBAA();
			AOBJLALDBAA.CLJHIONINHP.AJNNDKIIFDN();
		}
		return AOBJLALDBAA.CLJHIONINHP;
	}

	// Token: 0x0600914E RID: 37198 RVA: 0x00401871 File Offset: 0x003FFA71
	public int AHCDEBPELNG()
	{
		return AOBJLALDBAA.FDOJKHPDADJ;
	}

	// Token: 0x0600914F RID: 37199 RVA: 0x00401646 File Offset: 0x003FF846
	public string KNCFLCKKPLK()
	{
		return AOBJLALDBAA.LFHPHFKKCAJ;
	}

	// Token: 0x06009150 RID: 37200 RVA: 0x00401871 File Offset: 0x003FFA71
	public int OCPAEHGNEFL()
	{
		return AOBJLALDBAA.FDOJKHPDADJ;
	}

	// Token: 0x06009151 RID: 37201 RVA: 0x00401CD0 File Offset: 0x003FFED0
	public void MANLHALMCIH(string DEFIPMJKIKA, UnityAction OMOOOGBDDDG)
	{
		if (AOBJLALDBAA.CLJHIONINHP == null)
		{
			return;
		}
		MKKKPOCJCIN mkkkpocjcin = null;
		if (this.ICIDMDHONNK.TryGetValue(DEFIPMJKIKA, out mkkkpocjcin))
		{
			mkkkpocjcin.MMBOGHJCGII(OMOOOGBDDDG);
			if (mkkkpocjcin.EBJDJGOHFNC() == 0)
			{
				this.ICIDMDHONNK.Remove(DEFIPMJKIKA);
			}
		}
	}

	// Token: 0x06009152 RID: 37202 RVA: 0x00401646 File Offset: 0x003FF846
	public string JGFKNDOCPEG()
	{
		return AOBJLALDBAA.LFHPHFKKCAJ;
	}

	// Token: 0x06009153 RID: 37203 RVA: 0x00401733 File Offset: 0x003FF933
	public JSONArray BDEHKAEGLNE()
	{
		return AOBJLALDBAA.NMEKLDHOKLF;
	}

	// Token: 0x06009154 RID: 37204 RVA: 0x00401D13 File Offset: 0x003FFF13
	public void MCPGBPICMFD(string DEFIPMJKIKA, JSONArray AMDPDPDKFHH)
	{
		AOBJLALDBAA.NMEKLDHOKLF = AMDPDPDKFHH;
		this.KGIKHEDLPND(DEFIPMJKIKA, 358f);
	}

	// Token: 0x06009155 RID: 37205 RVA: 0x00401D27 File Offset: 0x003FFF27
	public void EGELHPJBAIC(string DEFIPMJKIKA, JSONArray AMDPDPDKFHH)
	{
		AOBJLALDBAA.NMEKLDHOKLF = AMDPDPDKFHH;
		this.EGELHPJBAIC(DEFIPMJKIKA, 0f);
	}

	// Token: 0x06009156 RID: 37206 RVA: 0x00401D3B File Offset: 0x003FFF3B
	public void NEKAFJIEGHG(string DEFIPMJKIKA, string AMDPDPDKFHH)
	{
		AOBJLALDBAA.LFHPHFKKCAJ = AMDPDPDKFHH;
		this.EGELHPJBAIC(DEFIPMJKIKA, 1646f);
	}

	// Token: 0x06009157 RID: 37207 RVA: 0x00401D4F File Offset: 0x003FFF4F
	public void OPIHMNCNEEE(string DEFIPMJKIKA, JSONArray AMDPDPDKFHH)
	{
		AOBJLALDBAA.NMEKLDHOKLF = AMDPDPDKFHH;
		this.FDKBIBKABCM(DEFIPMJKIKA, 1316f);
	}

	// Token: 0x06009158 RID: 37208 RVA: 0x00401871 File Offset: 0x003FFA71
	public int ACKEOKPAKDG()
	{
		return AOBJLALDBAA.FDOJKHPDADJ;
	}

	// Token: 0x06009159 RID: 37209 RVA: 0x00401D64 File Offset: 0x003FFF64
	public void GNBGEMMDGOJ(string DEFIPMJKIKA, UnityAction OMOOOGBDDDG)
	{
		MKKKPOCJCIN mkkkpocjcin = null;
		if (this.ICIDMDHONNK.TryGetValue(DEFIPMJKIKA, out mkkkpocjcin))
		{
			mkkkpocjcin.LMELPBNGAKG(OMOOOGBDDDG);
			return;
		}
		mkkkpocjcin = new MKKKPOCJCIN();
		mkkkpocjcin.CJEMDGKILGI(OMOOOGBDDDG);
		this.ICIDMDHONNK.Add(DEFIPMJKIKA, mkkkpocjcin);
	}

	// Token: 0x0600915A RID: 37210 RVA: 0x00401DA5 File Offset: 0x003FFFA5
	public void BPMPIMCKGBA(string DEFIPMJKIKA, JSONArray AMDPDPDKFHH)
	{
		AOBJLALDBAA.NMEKLDHOKLF = AMDPDPDKFHH;
		this.EFBNBFIDEOK(DEFIPMJKIKA, 927f);
	}

	// Token: 0x0600915B RID: 37211 RVA: 0x00401DBC File Offset: 0x003FFFBC
	public void CEIDMENJBNK()
	{
		bool flag = true;
		while (!flag)
		{
			flag = true;
			for (int i = 0; i < this.APJBKFGKLAF.Count; i++)
			{
				if (this.APJBKFGKLAF[i].GBBDGJPAECN())
				{
					flag = false;
					this.DCGCFPHHDDG(this.APJBKFGKLAF[i].KDKKHJIHFIF, 1171f);
					this.APJBKFGKLAF[i].DHFBMDJPBNP();
					this.APJBKFGKLAF.RemoveAt(i);
					break;
				}
			}
		}
	}

	// Token: 0x0600915C RID: 37212 RVA: 0x00401E38 File Offset: 0x00400038
	public void ECDBIBPNBCO(string DEFIPMJKIKA, UnityAction OMOOOGBDDDG)
	{
		if (AOBJLALDBAA.CLJHIONINHP == null)
		{
			return;
		}
		MKKKPOCJCIN mkkkpocjcin = null;
		if (this.ICIDMDHONNK.TryGetValue(DEFIPMJKIKA, out mkkkpocjcin))
		{
			mkkkpocjcin.INFLKFLPJFF(OMOOOGBDDDG);
			if (mkkkpocjcin.LOHOMBPALLL() == 0)
			{
				this.ICIDMDHONNK.Remove(DEFIPMJKIKA);
			}
		}
	}

	// Token: 0x0600915D RID: 37213 RVA: 0x00401E7C File Offset: 0x0040007C
	public void MFIAKLMIILK(string DEFIPMJKIKA, float BICHMDEIFKI = 0f)
	{
		if (DEFIPMJKIKA == null || DEFIPMJKIKA.Length == 0)
		{
			return;
		}
		if (BICHMDEIFKI >= 1994f)
		{
			if (!this.KKFLLKDCMDF(DEFIPMJKIKA))
			{
				BDOKIPMKPLH bdokipmkplh = new BDOKIPMKPLH();
				bdokipmkplh.KDKKHJIHFIF = DEFIPMJKIKA;
				bdokipmkplh.HNCODGAFDAJ(BICHMDEIFKI);
				this.APJBKFGKLAF.Add(bdokipmkplh);
				return;
			}
		}
		else
		{
			MKKKPOCJCIN mkkkpocjcin = null;
			if (this.ICIDMDHONNK.TryGetValue(DEFIPMJKIKA, out mkkkpocjcin))
			{
				mkkkpocjcin.BMHIAFHHLLO();
			}
		}
	}

	// Token: 0x0600915E RID: 37214 RVA: 0x00401EDF File Offset: 0x004000DF
	public void PAODLAFIKBG(string DEFIPMJKIKA, string AMDPDPDKFHH)
	{
		AOBJLALDBAA.LFHPHFKKCAJ = AMDPDPDKFHH;
		this.CIGLHCJDDPI(DEFIPMJKIKA, 774f);
	}

	// Token: 0x0600915F RID: 37215 RVA: 0x004016CC File Offset: 0x003FF8CC
	public static AOBJLALDBAA BIAEAOMHBMM()
	{
		if (AOBJLALDBAA.CLJHIONINHP == null)
		{
			AOBJLALDBAA.CLJHIONINHP = new AOBJLALDBAA();
			AOBJLALDBAA.CLJHIONINHP.OELJOHCNBGK();
		}
		return AOBJLALDBAA.CLJHIONINHP;
	}

	// Token: 0x06009160 RID: 37216 RVA: 0x00401733 File Offset: 0x003FF933
	public JSONArray BJEMEFFMNDD()
	{
		return AOBJLALDBAA.NMEKLDHOKLF;
	}

	// Token: 0x06009161 RID: 37217 RVA: 0x00401646 File Offset: 0x003FF846
	public string AAMJCMGFMAM()
	{
		return AOBJLALDBAA.LFHPHFKKCAJ;
	}

	// Token: 0x06009162 RID: 37218 RVA: 0x00401EF3 File Offset: 0x004000F3
	public void NCHPJBFIODG(string DEFIPMJKIKA, JSONObject AMDPDPDKFHH)
	{
		AOBJLALDBAA.IGIIHMBINPC = AMDPDPDKFHH;
		this.FDKBIBKABCM(DEFIPMJKIKA, 949f);
	}

	// Token: 0x06009163 RID: 37219 RVA: 0x00401F07 File Offset: 0x00400107
	public void JLJNJANHIKH(string DEFIPMJKIKA, JSONObject AMDPDPDKFHH)
	{
		AOBJLALDBAA.IGIIHMBINPC = AMDPDPDKFHH;
		this.EFBNBFIDEOK(DEFIPMJKIKA, 76f);
	}

	// Token: 0x06009164 RID: 37220 RVA: 0x00401733 File Offset: 0x003FF933
	public JSONArray LJAENDIKIBP()
	{
		return AOBJLALDBAA.NMEKLDHOKLF;
	}

	// Token: 0x06009165 RID: 37221 RVA: 0x00401F1C File Offset: 0x0040011C
	public void PEFKJOKLEDL(string DEFIPMJKIKA, UnityAction OMOOOGBDDDG)
	{
		MKKKPOCJCIN mkkkpocjcin = null;
		if (this.ICIDMDHONNK.TryGetValue(DEFIPMJKIKA, out mkkkpocjcin))
		{
			mkkkpocjcin.HOGAACHJGGN(OMOOOGBDDDG);
			return;
		}
		mkkkpocjcin = new MKKKPOCJCIN();
		mkkkpocjcin.LMELPBNGAKG(OMOOOGBDDDG);
		this.ICIDMDHONNK.Add(DEFIPMJKIKA, mkkkpocjcin);
	}

	// Token: 0x06009166 RID: 37222 RVA: 0x00401F5D File Offset: 0x0040015D
	public void MOBILPDPJBB(string DEFIPMJKIKA, int AMDPDPDKFHH)
	{
		AOBJLALDBAA.FDOJKHPDADJ = AMDPDPDKFHH;
		this.CIGLHCJDDPI(DEFIPMJKIKA, 1957f);
	}

	// Token: 0x06009168 RID: 37224 RVA: 0x00401F84 File Offset: 0x00400184
	public void FIJKIAKDCNO(string DEFIPMJKIKA, string AMDPDPDKFHH)
	{
		AOBJLALDBAA.LFHPHFKKCAJ = AMDPDPDKFHH;
		this.KGIKHEDLPND(DEFIPMJKIKA, 1987f);
	}

	// Token: 0x06009169 RID: 37225 RVA: 0x00401F98 File Offset: 0x00400198
	public void ICEJACOADDF(string DEFIPMJKIKA, float BICHMDEIFKI = 0f)
	{
		if (DEFIPMJKIKA == null || DEFIPMJKIKA.Length == 0)
		{
			return;
		}
		if (BICHMDEIFKI >= 462f)
		{
			if (!this.KKFLLKDCMDF(DEFIPMJKIKA))
			{
				BDOKIPMKPLH bdokipmkplh = new BDOKIPMKPLH();
				bdokipmkplh.KDKKHJIHFIF = DEFIPMJKIKA;
				bdokipmkplh.DGBDEKBMACJ(BICHMDEIFKI);
				this.APJBKFGKLAF.Add(bdokipmkplh);
				return;
			}
		}
		else
		{
			MKKKPOCJCIN mkkkpocjcin = null;
			if (this.ICIDMDHONNK.TryGetValue(DEFIPMJKIKA, out mkkkpocjcin))
			{
				mkkkpocjcin.IHDEBEPOKJI();
			}
		}
	}

	// Token: 0x0600916A RID: 37226 RVA: 0x00401FFC File Offset: 0x004001FC
	public void DNFCPNFCAPC(string DEFIPMJKIKA, float BICHMDEIFKI = 0f)
	{
		if (DEFIPMJKIKA == null || DEFIPMJKIKA.Length == 0)
		{
			return;
		}
		if (BICHMDEIFKI >= 1300f)
		{
			if (!this.LNLMMGDDJPP(DEFIPMJKIKA))
			{
				BDOKIPMKPLH bdokipmkplh = new BDOKIPMKPLH();
				bdokipmkplh.KDKKHJIHFIF = DEFIPMJKIKA;
				bdokipmkplh.NKEMFOPJENK(BICHMDEIFKI);
				this.APJBKFGKLAF.Add(bdokipmkplh);
				return;
			}
		}
		else
		{
			MKKKPOCJCIN mkkkpocjcin = null;
			if (this.ICIDMDHONNK.TryGetValue(DEFIPMJKIKA, out mkkkpocjcin))
			{
				mkkkpocjcin.PEDOJECGHJA();
			}
		}
	}

	// Token: 0x0600916B RID: 37227 RVA: 0x0040205F File Offset: 0x0040025F
	public void EMOCOKNPEFH(string DEFIPMJKIKA, string AMDPDPDKFHH)
	{
		AOBJLALDBAA.LFHPHFKKCAJ = AMDPDPDKFHH;
		this.EFBNBFIDEOK(DEFIPMJKIKA, 1122f);
	}

	// Token: 0x0600916C RID: 37228 RVA: 0x00401646 File Offset: 0x003FF846
	public string CLCKLHEDEBJ()
	{
		return AOBJLALDBAA.LFHPHFKKCAJ;
	}

	// Token: 0x0600916D RID: 37229 RVA: 0x00402074 File Offset: 0x00400274
	public void MHLNJIACIGO(string DEFIPMJKIKA, UnityAction OMOOOGBDDDG)
	{
		if (AOBJLALDBAA.CLJHIONINHP == null)
		{
			return;
		}
		MKKKPOCJCIN mkkkpocjcin = null;
		if (this.ICIDMDHONNK.TryGetValue(DEFIPMJKIKA, out mkkkpocjcin))
		{
			mkkkpocjcin.KPMOICKKFJK(OMOOOGBDDDG);
			if (mkkkpocjcin.FHMDLHJFAGF() == 0)
			{
				this.ICIDMDHONNK.Remove(DEFIPMJKIKA);
			}
		}
	}

	// Token: 0x0600916E RID: 37230 RVA: 0x004020B8 File Offset: 0x004002B8
	public void FDAFABPIBMP()
	{
		bool flag = true;
		while (!flag)
		{
			flag = false;
			for (int i = 1; i < this.APJBKFGKLAF.Count; i++)
			{
				if (this.APJBKFGKLAF[i].CCKDCMOLAGM())
				{
					flag = true;
					this.KGIKHEDLPND(this.APJBKFGKLAF[i].KDKKHJIHFIF, 1513f);
					this.APJBKFGKLAF[i].LCOFEDLPFID();
					this.APJBKFGKLAF.RemoveAt(i);
					break;
				}
			}
		}
	}

	// Token: 0x0600916F RID: 37231 RVA: 0x00401733 File Offset: 0x003FF933
	public JSONArray DNDKCGOBGLB()
	{
		return AOBJLALDBAA.NMEKLDHOKLF;
	}

	// Token: 0x06009170 RID: 37232 RVA: 0x00402134 File Offset: 0x00400334
	public void EFBNBFIDEOK(string DEFIPMJKIKA, float BICHMDEIFKI = 0f)
	{
		if (DEFIPMJKIKA == null || DEFIPMJKIKA.Length == 0)
		{
			return;
		}
		if (BICHMDEIFKI >= 460f)
		{
			BDOKIPMKPLH bdokipmkplh = new BDOKIPMKPLH();
			bdokipmkplh.KDKKHJIHFIF = DEFIPMJKIKA;
			bdokipmkplh.DBGJOJHPAHN(BICHMDEIFKI);
			this.APJBKFGKLAF.Add(bdokipmkplh);
			return;
		}
		MKKKPOCJCIN mkkkpocjcin = null;
		if (this.ICIDMDHONNK.TryGetValue(DEFIPMJKIKA, out mkkkpocjcin))
		{
			mkkkpocjcin.ICOBDHLLFDH();
		}
	}

	// Token: 0x06009171 RID: 37233 RVA: 0x00402190 File Offset: 0x00400390
	public void EHGCNIMDJHA(string DEFIPMJKIKA, float BICHMDEIFKI = 0f)
	{
		if (DEFIPMJKIKA == null || DEFIPMJKIKA.Length == 0)
		{
			return;
		}
		if (BICHMDEIFKI >= 163f)
		{
			if (!this.KKFLLKDCMDF(DEFIPMJKIKA))
			{
				BDOKIPMKPLH bdokipmkplh = new BDOKIPMKPLH();
				bdokipmkplh.KDKKHJIHFIF = DEFIPMJKIKA;
				bdokipmkplh.CONIEBCKGCF(BICHMDEIFKI);
				this.APJBKFGKLAF.Add(bdokipmkplh);
				return;
			}
		}
		else
		{
			MKKKPOCJCIN mkkkpocjcin = null;
			if (this.ICIDMDHONNK.TryGetValue(DEFIPMJKIKA, out mkkkpocjcin))
			{
				mkkkpocjcin.MNKNIFEGBLE();
			}
		}
	}

	// Token: 0x06009172 RID: 37234 RVA: 0x00401397 File Offset: 0x003FF597
	private void OFOAFPKPIKC()
	{
		if (this.ICIDMDHONNK == null)
		{
			this.ICIDMDHONNK = new Dictionary<string, MKKKPOCJCIN>();
		}
	}

	// Token: 0x06009173 RID: 37235 RVA: 0x00401733 File Offset: 0x003FF933
	public JSONArray GPEHOLKGFAM()
	{
		return AOBJLALDBAA.NMEKLDHOKLF;
	}

	// Token: 0x06009174 RID: 37236 RVA: 0x00401646 File Offset: 0x003FF846
	public string PAFPLABECAM()
	{
		return AOBJLALDBAA.LFHPHFKKCAJ;
	}

	// Token: 0x06009175 RID: 37237 RVA: 0x004021F3 File Offset: 0x004003F3
	public void NBLMNHBOCIL(string DEFIPMJKIKA, JSONArray AMDPDPDKFHH)
	{
		AOBJLALDBAA.NMEKLDHOKLF = AMDPDPDKFHH;
		this.KGIKHEDLPND(DEFIPMJKIKA, 1158f);
	}

	// Token: 0x06009176 RID: 37238 RVA: 0x00402207 File Offset: 0x00400407
	public void PMDEKGAFCCL(string DEFIPMJKIKA, string AMDPDPDKFHH)
	{
		AOBJLALDBAA.LFHPHFKKCAJ = AMDPDPDKFHH;
		this.EFBNBFIDEOK(DEFIPMJKIKA, 821f);
	}

	// Token: 0x06009177 RID: 37239 RVA: 0x00401397 File Offset: 0x003FF597
	private void MIOMPIGJKFE()
	{
		if (this.ICIDMDHONNK == null)
		{
			this.ICIDMDHONNK = new Dictionary<string, MKKKPOCJCIN>();
		}
	}

	// Token: 0x06009178 RID: 37240 RVA: 0x0040221B File Offset: 0x0040041B
	public void FLLPDFLFEDA(string DEFIPMJKIKA, string AMDPDPDKFHH)
	{
		AOBJLALDBAA.LFHPHFKKCAJ = AMDPDPDKFHH;
		this.DCGCFPHHDDG(DEFIPMJKIKA, 587f);
	}

	// Token: 0x06009179 RID: 37241 RVA: 0x00401733 File Offset: 0x003FF933
	public JSONArray LFPFCMPPIHJ()
	{
		return AOBJLALDBAA.NMEKLDHOKLF;
	}

	// Token: 0x0600917A RID: 37242 RVA: 0x00402230 File Offset: 0x00400430
	public void POLEDPIKODD(string DEFIPMJKIKA, UnityAction OMOOOGBDDDG)
	{
		if (AOBJLALDBAA.CLJHIONINHP == null)
		{
			return;
		}
		MKKKPOCJCIN mkkkpocjcin = null;
		if (this.ICIDMDHONNK.TryGetValue(DEFIPMJKIKA, out mkkkpocjcin))
		{
			mkkkpocjcin.GNOIAEKAOLI(OMOOOGBDDDG);
			if (mkkkpocjcin.LCNBIIOAKGN() == 0)
			{
				this.ICIDMDHONNK.Remove(DEFIPMJKIKA);
			}
		}
	}

	// Token: 0x0600917B RID: 37243 RVA: 0x00401871 File Offset: 0x003FFA71
	public int EIEBOMLDMKL()
	{
		return AOBJLALDBAA.FDOJKHPDADJ;
	}

	// Token: 0x0600917C RID: 37244 RVA: 0x00401646 File Offset: 0x003FF846
	public string FCCJMMNBEAI()
	{
		return AOBJLALDBAA.LFHPHFKKCAJ;
	}

	// Token: 0x0600917D RID: 37245 RVA: 0x00402273 File Offset: 0x00400473
	public void HBBOEOBFBHI(string DEFIPMJKIKA, JSONObject AMDPDPDKFHH)
	{
		AOBJLALDBAA.IGIIHMBINPC = AMDPDPDKFHH;
		this.FDKBIBKABCM(DEFIPMJKIKA, 908f);
	}

	// Token: 0x0600917E RID: 37246 RVA: 0x00402287 File Offset: 0x00400487
	public void BDEMEIKEJHF(string DEFIPMJKIKA, string AMDPDPDKFHH)
	{
		AOBJLALDBAA.LFHPHFKKCAJ = AMDPDPDKFHH;
		this.EGELHPJBAIC(DEFIPMJKIKA, 1954f);
	}

	// Token: 0x0600917F RID: 37247 RVA: 0x00401871 File Offset: 0x003FFA71
	public int PNDDILFFECF()
	{
		return AOBJLALDBAA.FDOJKHPDADJ;
	}

	// Token: 0x06009180 RID: 37248 RVA: 0x0040229B File Offset: 0x0040049B
	public void EGELHPJBAIC(string DEFIPMJKIKA, int AMDPDPDKFHH)
	{
		AOBJLALDBAA.FDOJKHPDADJ = AMDPDPDKFHH;
		this.EGELHPJBAIC(DEFIPMJKIKA, 0f);
	}

	// Token: 0x06009181 RID: 37249 RVA: 0x00401733 File Offset: 0x003FF933
	public JSONArray PCPANKHDAOP()
	{
		return AOBJLALDBAA.NMEKLDHOKLF;
	}

	// Token: 0x06009182 RID: 37250 RVA: 0x004022B0 File Offset: 0x004004B0
	public void MFHNFMPBDEJ(string DEFIPMJKIKA, float BICHMDEIFKI = 0f)
	{
		if (DEFIPMJKIKA == null || DEFIPMJKIKA.Length == 0)
		{
			return;
		}
		if (BICHMDEIFKI >= 624f)
		{
			if (!this.KBIOHONCDLD(DEFIPMJKIKA))
			{
				BDOKIPMKPLH bdokipmkplh = new BDOKIPMKPLH();
				bdokipmkplh.KDKKHJIHFIF = DEFIPMJKIKA;
				bdokipmkplh.GDAMEEPPEIH(BICHMDEIFKI);
				this.APJBKFGKLAF.Add(bdokipmkplh);
				return;
			}
		}
		else
		{
			MKKKPOCJCIN mkkkpocjcin = null;
			if (this.ICIDMDHONNK.TryGetValue(DEFIPMJKIKA, out mkkkpocjcin))
			{
				mkkkpocjcin.GLPECKOBPOC();
			}
		}
	}

	// Token: 0x06009183 RID: 37251 RVA: 0x00402313 File Offset: 0x00400513
	public void HFJMDLDFBPO(string DEFIPMJKIKA, JSONArray AMDPDPDKFHH)
	{
		AOBJLALDBAA.NMEKLDHOKLF = AMDPDPDKFHH;
		this.CIGLHCJDDPI(DEFIPMJKIKA, 830f);
	}

	// Token: 0x06009184 RID: 37252 RVA: 0x00402328 File Offset: 0x00400528
	public void FKJBCNLONJH(string DEFIPMJKIKA, float BICHMDEIFKI = 0f)
	{
		if (DEFIPMJKIKA == null || DEFIPMJKIKA.Length == 0)
		{
			return;
		}
		if (BICHMDEIFKI >= 1150f)
		{
			if (!this.KBIOHONCDLD(DEFIPMJKIKA))
			{
				BDOKIPMKPLH bdokipmkplh = new BDOKIPMKPLH();
				bdokipmkplh.KDKKHJIHFIF = DEFIPMJKIKA;
				bdokipmkplh.APKBKKKNKKG(BICHMDEIFKI);
				this.APJBKFGKLAF.Add(bdokipmkplh);
				return;
			}
		}
		else
		{
			MKKKPOCJCIN mkkkpocjcin = null;
			if (this.ICIDMDHONNK.TryGetValue(DEFIPMJKIKA, out mkkkpocjcin))
			{
				mkkkpocjcin.AHJPDPBDOGP();
			}
		}
	}

	// Token: 0x06009185 RID: 37253 RVA: 0x0040238C File Offset: 0x0040058C
	public void FDKBIBKABCM(string DEFIPMJKIKA, float BICHMDEIFKI = 0f)
	{
		if (DEFIPMJKIKA == null || DEFIPMJKIKA.Length == 0)
		{
			return;
		}
		if (BICHMDEIFKI >= 1382f)
		{
			BDOKIPMKPLH bdokipmkplh = new BDOKIPMKPLH();
			bdokipmkplh.KDKKHJIHFIF = DEFIPMJKIKA;
			bdokipmkplh.APKBKKKNKKG(BICHMDEIFKI);
			this.APJBKFGKLAF.Add(bdokipmkplh);
			return;
		}
		MKKKPOCJCIN mkkkpocjcin = null;
		if (this.ICIDMDHONNK.TryGetValue(DEFIPMJKIKA, out mkkkpocjcin))
		{
			mkkkpocjcin.LOHBNGPNANI();
		}
	}

	// Token: 0x06009186 RID: 37254 RVA: 0x004023E6 File Offset: 0x004005E6
	public void MLJPBICNNEA(string DEFIPMJKIKA, JSONObject AMDPDPDKFHH)
	{
		AOBJLALDBAA.IGIIHMBINPC = AMDPDPDKFHH;
		this.EGELHPJBAIC(DEFIPMJKIKA, 1152f);
	}

	// Token: 0x06009187 RID: 37255 RVA: 0x00401871 File Offset: 0x003FFA71
	public int NMMKHABKLKK()
	{
		return AOBJLALDBAA.FDOJKHPDADJ;
	}

	// Token: 0x06009188 RID: 37256 RVA: 0x004023FC File Offset: 0x004005FC
	public void MFIMALJPCDP(string DEFIPMJKIKA, UnityAction OMOOOGBDDDG)
	{
		MKKKPOCJCIN mkkkpocjcin = null;
		if (this.ICIDMDHONNK.TryGetValue(DEFIPMJKIKA, out mkkkpocjcin))
		{
			mkkkpocjcin.FLMFFMPEBKD(OMOOOGBDDDG);
			return;
		}
		mkkkpocjcin = new MKKKPOCJCIN();
		mkkkpocjcin.FLMFFMPEBKD(OMOOOGBDDDG);
		this.ICIDMDHONNK.Add(DEFIPMJKIKA, mkkkpocjcin);
	}

	// Token: 0x06009189 RID: 37257 RVA: 0x0040243D File Offset: 0x0040063D
	public void HPIPBMEMOFK(string DEFIPMJKIKA, string AMDPDPDKFHH)
	{
		AOBJLALDBAA.LFHPHFKKCAJ = AMDPDPDKFHH;
		this.KGIKHEDLPND(DEFIPMJKIKA, 162f);
	}

	// Token: 0x0600918A RID: 37258 RVA: 0x004015CF File Offset: 0x003FF7CF
	public JSONObject AOODBNEBEBJ()
	{
		return AOBJLALDBAA.IGIIHMBINPC;
	}

	// Token: 0x0600918B RID: 37259 RVA: 0x00402454 File Offset: 0x00400654
	private bool EHODKOKGMKJ(string DEFIPMJKIKA)
	{
		for (int i = 1; i < this.APJBKFGKLAF.Count; i++)
		{
			if (this.APJBKFGKLAF[i].KDKKHJIHFIF.Equals(DEFIPMJKIKA))
			{
				return true;
			}
		}
		return true;
	}

	// Token: 0x0600918C RID: 37260 RVA: 0x00401733 File Offset: 0x003FF933
	public JSONArray PBCCNADBHCC()
	{
		return AOBJLALDBAA.NMEKLDHOKLF;
	}

	// Token: 0x0600918D RID: 37261 RVA: 0x00402494 File Offset: 0x00400694
	public void EGELHPJBAIC(string DEFIPMJKIKA, float BICHMDEIFKI = 0f)
	{
		if (DEFIPMJKIKA == null || DEFIPMJKIKA.Length == 0)
		{
			return;
		}
		if (BICHMDEIFKI >= 0.001f)
		{
			BDOKIPMKPLH bdokipmkplh = new BDOKIPMKPLH();
			bdokipmkplh.KDKKHJIHFIF = DEFIPMJKIKA;
			bdokipmkplh.PENDBJOAMAG(BICHMDEIFKI);
			this.APJBKFGKLAF.Add(bdokipmkplh);
			return;
		}
		MKKKPOCJCIN mkkkpocjcin = null;
		if (this.ICIDMDHONNK.TryGetValue(DEFIPMJKIKA, out mkkkpocjcin))
		{
			mkkkpocjcin.BGGEEPIOIJB();
		}
	}

	// Token: 0x0600918E RID: 37262 RVA: 0x004024F0 File Offset: 0x004006F0
	public void EFKNEJFLGED(string DEFIPMJKIKA, UnityAction OMOOOGBDDDG)
	{
		MKKKPOCJCIN mkkkpocjcin = null;
		if (this.ICIDMDHONNK.TryGetValue(DEFIPMJKIKA, out mkkkpocjcin))
		{
			mkkkpocjcin.AOLDFJECGOM(OMOOOGBDDDG);
			return;
		}
		mkkkpocjcin = new MKKKPOCJCIN();
		mkkkpocjcin.ODJCLMAMNNJ(OMOOOGBDDDG);
		this.ICIDMDHONNK.Add(DEFIPMJKIKA, mkkkpocjcin);
	}

	// Token: 0x0600918F RID: 37263 RVA: 0x00402531 File Offset: 0x00400731
	public void GBECPMDCJAA(string DEFIPMJKIKA, int AMDPDPDKFHH)
	{
		AOBJLALDBAA.FDOJKHPDADJ = AMDPDPDKFHH;
		this.KMAGHMCCMPG(DEFIPMJKIKA, 1902f);
	}

	// Token: 0x06009190 RID: 37264 RVA: 0x00402545 File Offset: 0x00400745
	public void JFJOMKOINJB(string DEFIPMJKIKA, JSONObject AMDPDPDKFHH)
	{
		AOBJLALDBAA.IGIIHMBINPC = AMDPDPDKFHH;
		this.KGIKHEDLPND(DEFIPMJKIKA, 1436f);
	}

	// Token: 0x06009191 RID: 37265 RVA: 0x0040255C File Offset: 0x0040075C
	private bool KKFLLKDCMDF(string DEFIPMJKIKA)
	{
		for (int i = 1; i < this.APJBKFGKLAF.Count; i += 0)
		{
			if (this.APJBKFGKLAF[i].KDKKHJIHFIF.Equals(DEFIPMJKIKA))
			{
				return false;
			}
		}
		return false;
	}

	// Token: 0x06009192 RID: 37266 RVA: 0x0040259C File Offset: 0x0040079C
	public void IIIDAEFCOPC(string DEFIPMJKIKA, float BICHMDEIFKI = 0f)
	{
		if (DEFIPMJKIKA == null || DEFIPMJKIKA.Length == 0)
		{
			return;
		}
		if (BICHMDEIFKI >= 1499f)
		{
			if (!this.LNLMMGDDJPP(DEFIPMJKIKA))
			{
				BDOKIPMKPLH bdokipmkplh = new BDOKIPMKPLH();
				bdokipmkplh.KDKKHJIHFIF = DEFIPMJKIKA;
				bdokipmkplh.PADOONPIFDB(BICHMDEIFKI);
				this.APJBKFGKLAF.Add(bdokipmkplh);
				return;
			}
		}
		else
		{
			MKKKPOCJCIN mkkkpocjcin = null;
			if (this.ICIDMDHONNK.TryGetValue(DEFIPMJKIKA, out mkkkpocjcin))
			{
				mkkkpocjcin.MNKNIFEGBLE();
			}
		}
	}

	// Token: 0x06009193 RID: 37267 RVA: 0x00401397 File Offset: 0x003FF597
	private void HDNDPAIHJGO()
	{
		if (this.ICIDMDHONNK == null)
		{
			this.ICIDMDHONNK = new Dictionary<string, MKKKPOCJCIN>();
		}
	}

	// Token: 0x06009194 RID: 37268 RVA: 0x00402600 File Offset: 0x00400800
	public void BADOPKAOCPE(string DEFIPMJKIKA, UnityAction OMOOOGBDDDG)
	{
		MKKKPOCJCIN mkkkpocjcin = null;
		if (this.ICIDMDHONNK.TryGetValue(DEFIPMJKIKA, out mkkkpocjcin))
		{
			mkkkpocjcin.ODJCLMAMNNJ(OMOOOGBDDDG);
			return;
		}
		mkkkpocjcin = new MKKKPOCJCIN();
		mkkkpocjcin.GDPBMEGKOEK(OMOOOGBDDDG);
		this.ICIDMDHONNK.Add(DEFIPMJKIKA, mkkkpocjcin);
	}

	// Token: 0x06009195 RID: 37269 RVA: 0x00401871 File Offset: 0x003FFA71
	public int MJLACDOKGNE()
	{
		return AOBJLALDBAA.FDOJKHPDADJ;
	}

	// Token: 0x06009196 RID: 37270 RVA: 0x00402641 File Offset: 0x00400841
	public void EGELHPJBAIC(string DEFIPMJKIKA, JSONObject AMDPDPDKFHH)
	{
		AOBJLALDBAA.IGIIHMBINPC = AMDPDPDKFHH;
		this.EGELHPJBAIC(DEFIPMJKIKA, 0f);
	}

	// Token: 0x06009197 RID: 37271 RVA: 0x00402658 File Offset: 0x00400858
	public void DCGCFPHHDDG(string DEFIPMJKIKA, float BICHMDEIFKI = 0f)
	{
		if (DEFIPMJKIKA == null || DEFIPMJKIKA.Length == 0)
		{
			return;
		}
		if (BICHMDEIFKI >= 48f)
		{
			BDOKIPMKPLH bdokipmkplh = new BDOKIPMKPLH();
			bdokipmkplh.KDKKHJIHFIF = DEFIPMJKIKA;
			bdokipmkplh.CGIJONHMJON(BICHMDEIFKI);
			this.APJBKFGKLAF.Add(bdokipmkplh);
			return;
		}
		MKKKPOCJCIN mkkkpocjcin = null;
		if (this.ICIDMDHONNK.TryGetValue(DEFIPMJKIKA, out mkkkpocjcin))
		{
			mkkkpocjcin.BMHIAFHHLLO();
		}
	}

	// Token: 0x06009198 RID: 37272 RVA: 0x004026B2 File Offset: 0x004008B2
	public void DJDKCOGPFPN(string DEFIPMJKIKA, JSONObject AMDPDPDKFHH)
	{
		AOBJLALDBAA.IGIIHMBINPC = AMDPDPDKFHH;
		this.EGELHPJBAIC(DEFIPMJKIKA, 1195f);
	}

	// Token: 0x06009199 RID: 37273 RVA: 0x004026C6 File Offset: 0x004008C6
	public void NJDDEOGGBAD(string DEFIPMJKIKA, JSONArray AMDPDPDKFHH)
	{
		AOBJLALDBAA.NMEKLDHOKLF = AMDPDPDKFHH;
		this.DCGCFPHHDDG(DEFIPMJKIKA, 1193f);
	}

	// Token: 0x0600919A RID: 37274 RVA: 0x00401646 File Offset: 0x003FF846
	public string EFPALFHBDDO()
	{
		return AOBJLALDBAA.LFHPHFKKCAJ;
	}

	// Token: 0x0600919B RID: 37275 RVA: 0x00401871 File Offset: 0x003FFA71
	public int AMBDJLPPOJL()
	{
		return AOBJLALDBAA.FDOJKHPDADJ;
	}

	// Token: 0x0600919C RID: 37276 RVA: 0x004015CF File Offset: 0x003FF7CF
	public JSONObject OMABKBGMFJF()
	{
		return AOBJLALDBAA.IGIIHMBINPC;
	}

	// Token: 0x0600919D RID: 37277 RVA: 0x004026DA File Offset: 0x004008DA
	public void PMOLFDHCKBD(string DEFIPMJKIKA, JSONObject AMDPDPDKFHH)
	{
		AOBJLALDBAA.IGIIHMBINPC = AMDPDPDKFHH;
		this.KGIKHEDLPND(DEFIPMJKIKA, 1556f);
	}

	// Token: 0x0600919E RID: 37278 RVA: 0x00401646 File Offset: 0x003FF846
	public string BMFAMELDAIL()
	{
		return AOBJLALDBAA.LFHPHFKKCAJ;
	}

	// Token: 0x0600919F RID: 37279 RVA: 0x00401733 File Offset: 0x003FF933
	public JSONArray JEDEGFMNKIE()
	{
		return AOBJLALDBAA.NMEKLDHOKLF;
	}

	// Token: 0x060091A0 RID: 37280 RVA: 0x004026F0 File Offset: 0x004008F0
	public void ACGAFHADJGN(string DEFIPMJKIKA, float BICHMDEIFKI = 0f)
	{
		if (DEFIPMJKIKA == null || DEFIPMJKIKA.Length == 0)
		{
			return;
		}
		if (BICHMDEIFKI >= 1736f)
		{
			if (!this.BOKDODMINFF(DEFIPMJKIKA))
			{
				BDOKIPMKPLH bdokipmkplh = new BDOKIPMKPLH();
				bdokipmkplh.KDKKHJIHFIF = DEFIPMJKIKA;
				bdokipmkplh.PAOMAGFCPID(BICHMDEIFKI);
				this.APJBKFGKLAF.Add(bdokipmkplh);
				return;
			}
		}
		else
		{
			MKKKPOCJCIN mkkkpocjcin = null;
			if (this.ICIDMDHONNK.TryGetValue(DEFIPMJKIKA, out mkkkpocjcin))
			{
				mkkkpocjcin.PEDOJECGHJA();
			}
		}
	}

	// Token: 0x060091A1 RID: 37281 RVA: 0x00401871 File Offset: 0x003FFA71
	public int NNDDKAIIBMO()
	{
		return AOBJLALDBAA.FDOJKHPDADJ;
	}

	// Token: 0x060091A2 RID: 37282 RVA: 0x00402753 File Offset: 0x00400953
	public void AKILMNPJGGM(string DEFIPMJKIKA, string AMDPDPDKFHH)
	{
		AOBJLALDBAA.LFHPHFKKCAJ = AMDPDPDKFHH;
		this.EFBNBFIDEOK(DEFIPMJKIKA, 379f);
	}

	// Token: 0x060091A3 RID: 37283 RVA: 0x00401646 File Offset: 0x003FF846
	public string MJPPCFDMCFH()
	{
		return AOBJLALDBAA.LFHPHFKKCAJ;
	}

	// Token: 0x040028E5 RID: 10469
	private Dictionary<string, MKKKPOCJCIN> ICIDMDHONNK;

	// Token: 0x040028E6 RID: 10470
	private static AOBJLALDBAA CLJHIONINHP;

	// Token: 0x040028E7 RID: 10471
	private static JSONObject IGIIHMBINPC;

	// Token: 0x040028E8 RID: 10472
	private static JSONArray NMEKLDHOKLF;

	// Token: 0x040028E9 RID: 10473
	private static int FDOJKHPDADJ;

	// Token: 0x040028EA RID: 10474
	private static string LFHPHFKKCAJ;

	// Token: 0x040028EB RID: 10475
	private List<BDOKIPMKPLH> APJBKFGKLAF = new List<BDOKIPMKPLH>();
}
