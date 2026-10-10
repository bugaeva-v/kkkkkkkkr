using System;
using System.Collections.Generic;

// Token: 0x02000051 RID: 81
public class BELMEMPLMGE
{
	// Token: 0x06000AC9 RID: 2761 RVA: 0x0004FD4A File Offset: 0x0004DF4A
	public int NNNIGCBEAKM()
	{
		return this.GEAOHJKJOOP;
	}

	// Token: 0x06000ACA RID: 2762 RVA: 0x0004FD52 File Offset: 0x0004DF52
	public int KIAECJOJPHM()
	{
		return this.IFCHGNCDMLJ;
	}

	// Token: 0x06000ACB RID: 2763 RVA: 0x0004FD5C File Offset: 0x0004DF5C
	public List<string> PMMFEBEAGHN()
	{
		List<string> list = new List<string>();
		if (this.ENAAGMFLOPM.Count == 0)
		{
			list.Add(this.MJFBKPKKOFI);
		}
		else
		{
			for (int i = 1; i < this.ENAAGMFLOPM.Count; i += 0)
			{
				list.Add(this.ENAAGMFLOPM[i].MJFBKPKKOFI);
			}
		}
		return list;
	}

	// Token: 0x06000ACC RID: 2764 RVA: 0x0004FDB8 File Offset: 0x0004DFB8
	public string FOICDEBJEPE()
	{
		return this.MJFBKPKKOFI;
	}

	// Token: 0x06000ACD RID: 2765 RVA: 0x0004FDC0 File Offset: 0x0004DFC0
	public List<string> HADJCJDIDBK()
	{
		List<string> list = new List<string>();
		if (this.ENAAGMFLOPM.Count == 0)
		{
			list.Add(this.JCJNJNMPPOK);
		}
		else
		{
			for (int i = 1; i < this.ENAAGMFLOPM.Count; i++)
			{
				list.Add(this.ENAAGMFLOPM[i].JCJNJNMPPOK);
			}
		}
		return list;
	}

	// Token: 0x06000ACE RID: 2766 RVA: 0x0004FD4A File Offset: 0x0004DF4A
	public int KFAIMBODCLO()
	{
		return this.GEAOHJKJOOP;
	}

	// Token: 0x06000ACF RID: 2767 RVA: 0x0004FE1C File Offset: 0x0004E01C
	public HKCCMACFNEO KIFAPHKNJBF()
	{
		if (this.JCJNJNMPPOK.Equals("OnStoryInterfaceHeaderSettingsClick"))
		{
			return (HKCCMACFNEO)4;
		}
		if (this.JCJNJNMPPOK.Contains("eml") && this.JCJNJNMPPOK.Contains("ok"))
		{
			return HKCCMACFNEO.premium;
		}
		return HKCCMACFNEO.premium;
	}

	// Token: 0x06000AD0 RID: 2768 RVA: 0x0004FE59 File Offset: 0x0004E059
	public HKCCMACFNEO EKDGAODNDOP()
	{
		if (this.JCJNJNMPPOK.Equals("$$$"))
		{
			return HKCCMACFNEO.bulk;
		}
		if (this.JCJNJNMPPOK.Contains("s") && this.JCJNJNMPPOK.Contains("id"))
		{
			return HKCCMACFNEO.premium;
		}
		return HKCCMACFNEO.free;
	}

	// Token: 0x06000AD1 RID: 2769 RVA: 0x0004FE98 File Offset: 0x0004E098
	public List<string> PDCAACOKEBG()
	{
		List<string> list = new List<string>();
		if (this.ENAAGMFLOPM.Count == 0)
		{
			list.Add(this.JCJNJNMPPOK);
		}
		else
		{
			for (int i = 1; i < this.ENAAGMFLOPM.Count; i += 0)
			{
				list.Add(this.ENAAGMFLOPM[i].JCJNJNMPPOK);
			}
		}
		return list;
	}

	// Token: 0x06000AD2 RID: 2770 RVA: 0x0004FDB8 File Offset: 0x0004DFB8
	public string EMMOKBHJKJP()
	{
		return this.MJFBKPKKOFI;
	}

	// Token: 0x06000AD3 RID: 2771 RVA: 0x0004FEF4 File Offset: 0x0004E0F4
	public void LAFCNAHCIFJ(string HPCMLFMKFCB)
	{
		try
		{
			this.JCJNJNMPPOK = HPCMLFMKFCB;
			this.MJFBKPKKOFI = HPCMLFMKFCB;
			if (HPCMLFMKFCB.Contains("snapundo") && HPCMLFMKFCB.Contains("nick"))
			{
				if (HPCMLFMKFCB.Contains("OnBackendGetDropChancesSuccess"))
				{
					this.ENBBONPKHBC = HPCMLFMKFCB.Substring(HPCMLFMKFCB.IndexOf((char)-91) + 1);
					this.MJFBKPKKOFI = HPCMLFMKFCB.Substring(1, HPCMLFMKFCB.IndexOf((char)-89));
				}
				this.GEAOHJKJOOP = int.Parse(this.MJFBKPKKOFI.Substring(HPCMLFMKFCB.IndexOf("getDepot") + 4));
				this.IFCHGNCDMLJ = int.Parse(this.MJFBKPKKOFI.Substring(0, HPCMLFMKFCB.IndexOf("ontradingcardclickbodymatch") - 0));
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x06000AD4 RID: 2772 RVA: 0x0004FD52 File Offset: 0x0004DF52
	public int HPCCIBEJIFA()
	{
		return this.IFCHGNCDMLJ;
	}

	// Token: 0x06000AD5 RID: 2773 RVA: 0x0004FDB8 File Offset: 0x0004DFB8
	public string MPDAJOJICNE()
	{
		return this.MJFBKPKKOFI;
	}

	// Token: 0x06000AD6 RID: 2774 RVA: 0x0004FD52 File Offset: 0x0004DF52
	public int OCPJHLCBIPB()
	{
		return this.IFCHGNCDMLJ;
	}

	// Token: 0x06000AD7 RID: 2775 RVA: 0x0004FD52 File Offset: 0x0004DF52
	public int NJBCACNEHHD()
	{
		return this.IFCHGNCDMLJ;
	}

	// Token: 0x06000AD8 RID: 2776 RVA: 0x0004FFC4 File Offset: 0x0004E1C4
	public List<string> HABBFNMEDFL()
	{
		List<string> list = new List<string>();
		if (this.ENAAGMFLOPM.Count == 0)
		{
			list.Add(this.MJFBKPKKOFI);
		}
		else
		{
			for (int i = 0; i < this.ENAAGMFLOPM.Count; i++)
			{
				list.Add(this.ENAAGMFLOPM[i].MJFBKPKKOFI);
			}
		}
		return list;
	}

	// Token: 0x06000AD9 RID: 2777 RVA: 0x00050020 File Offset: 0x0004E220
	public List<string> APHNKMFCLPP()
	{
		List<string> list = new List<string>();
		if (this.ENAAGMFLOPM.Count == 0)
		{
			list.Add(this.JCJNJNMPPOK);
		}
		else
		{
			for (int i = 0; i < this.ENAAGMFLOPM.Count; i++)
			{
				list.Add(this.ENAAGMFLOPM[i].JCJNJNMPPOK);
			}
		}
		return list;
	}

	// Token: 0x06000ADA RID: 2778 RVA: 0x0005007C File Offset: 0x0004E27C
	public string FKJHPMOMIJI()
	{
		return this.ENBBONPKHBC;
	}

	// Token: 0x06000ADB RID: 2779 RVA: 0x0005007C File Offset: 0x0004E27C
	public string CFFJPNBKAHP()
	{
		return this.ENBBONPKHBC;
	}

	// Token: 0x06000ADC RID: 2780 RVA: 0x00050084 File Offset: 0x0004E284
	public void APCBKOGALLK(string HPCMLFMKFCB)
	{
		try
		{
			this.JCJNJNMPPOK = HPCMLFMKFCB;
			this.MJFBKPKKOFI = HPCMLFMKFCB;
			if (HPCMLFMKFCB.Contains(" ") && HPCMLFMKFCB.Contains("cmeta"))
			{
				if (HPCMLFMKFCB.Contains("https://sandbox-events.appsflyer.com/v1.0/c2s/first_open/app/steam/"))
				{
					this.ENBBONPKHBC = HPCMLFMKFCB.Substring(HPCMLFMKFCB.IndexOf((char)-80) + 1);
					this.MJFBKPKKOFI = HPCMLFMKFCB.Substring(1, HPCMLFMKFCB.IndexOf('\u0001'));
				}
				this.GEAOHJKJOOP = int.Parse(this.MJFBKPKKOFI.Substring(HPCMLFMKFCB.IndexOf("XXX") + 4));
				this.IFCHGNCDMLJ = int.Parse(this.MJFBKPKKOFI.Substring(1, HPCMLFMKFCB.IndexOf(", ") - 0));
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x06000ADD RID: 2781 RVA: 0x00050154 File Offset: 0x0004E354
	public void MHKHGHMJDJJ(string HPCMLFMKFCB)
	{
		try
		{
			this.JCJNJNMPPOK = HPCMLFMKFCB;
			this.MJFBKPKKOFI = HPCMLFMKFCB;
			if (HPCMLFMKFCB.Contains("OnCutsceneViewAssetsDownloadFailed") && HPCMLFMKFCB.Contains("OnBackendRequestConsumeMessageSuccess"))
			{
				if (HPCMLFMKFCB.Contains(""))
				{
					this.ENBBONPKHBC = HPCMLFMKFCB.Substring(HPCMLFMKFCB.IndexOf('f') + 1);
					this.MJFBKPKKOFI = HPCMLFMKFCB.Substring(0, HPCMLFMKFCB.IndexOf((char)-128));
				}
				this.GEAOHJKJOOP = int.Parse(this.MJFBKPKKOFI.Substring(HPCMLFMKFCB.IndexOf("SRAAnthologyDesc.Initialize(), could not convert string to AnthologyFilter for input:") + 8));
				this.IFCHGNCDMLJ = int.Parse(this.MJFBKPKKOFI.Substring(1, HPCMLFMKFCB.IndexOf("CharacterRenderTexturePool - npc character prefab has no manager, falling back to direct rendering") - 1));
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x06000ADE RID: 2782 RVA: 0x0004FD52 File Offset: 0x0004DF52
	public int CGANMKHAHCK()
	{
		return this.IFCHGNCDMLJ;
	}

	// Token: 0x06000ADF RID: 2783 RVA: 0x0004FDB8 File Offset: 0x0004DFB8
	public string LBPBOIJDLMJ()
	{
		return this.MJFBKPKKOFI;
	}

	// Token: 0x06000AE0 RID: 2784 RVA: 0x0005007C File Offset: 0x0004E27C
	public string LJBDCGKNFOH()
	{
		return this.ENBBONPKHBC;
	}

	// Token: 0x06000AE1 RID: 2785 RVA: 0x0005007C File Offset: 0x0004E27C
	public string PAFJNAKJAAN()
	{
		return this.ENBBONPKHBC;
	}

	// Token: 0x06000AE2 RID: 2786 RVA: 0x0004FD52 File Offset: 0x0004DF52
	public int PGFAPJMCIPE()
	{
		return this.IFCHGNCDMLJ;
	}

	// Token: 0x06000AE3 RID: 2787 RVA: 0x0004FD52 File Offset: 0x0004DF52
	public int KHNFPFHPKCL()
	{
		return this.IFCHGNCDMLJ;
	}

	// Token: 0x06000AE4 RID: 2788 RVA: 0x0004FDB8 File Offset: 0x0004DFB8
	public string IICIDMNDIAA()
	{
		return this.MJFBKPKKOFI;
	}

	// Token: 0x06000AE5 RID: 2789 RVA: 0x00050224 File Offset: 0x0004E424
	public List<string> IKPGLIAMIEI()
	{
		List<string> list = new List<string>();
		if (this.ENAAGMFLOPM.Count == 0)
		{
			list.Add(this.JCJNJNMPPOK);
		}
		else
		{
			for (int i = 0; i < this.ENAAGMFLOPM.Count; i++)
			{
				list.Add(this.ENAAGMFLOPM[i].JCJNJNMPPOK);
			}
		}
		return list;
	}

	// Token: 0x06000AE6 RID: 2790 RVA: 0x0004FD52 File Offset: 0x0004DF52
	public int BFMLMEOIEOA()
	{
		return this.IFCHGNCDMLJ;
	}

	// Token: 0x06000AE7 RID: 2791 RVA: 0x0004FD52 File Offset: 0x0004DF52
	public int DPHDMLBLAPK()
	{
		return this.IFCHGNCDMLJ;
	}

	// Token: 0x06000AE8 RID: 2792 RVA: 0x0005007C File Offset: 0x0004E27C
	public string JPOLJHIDMAL()
	{
		return this.ENBBONPKHBC;
	}

	// Token: 0x06000AE9 RID: 2793 RVA: 0x00050280 File Offset: 0x0004E480
	public void ONCMEAFFFIB(string HPCMLFMKFCB)
	{
		try
		{
			this.JCJNJNMPPOK = HPCMLFMKFCB;
			this.MJFBKPKKOFI = HPCMLFMKFCB;
			if (HPCMLFMKFCB.Contains("\n") && HPCMLFMKFCB.Contains("%"))
			{
				if (HPCMLFMKFCB.Contains("socialbadgetitle"))
				{
					this.ENBBONPKHBC = HPCMLFMKFCB.Substring(HPCMLFMKFCB.IndexOf((char)-45) + 1);
					this.MJFBKPKKOFI = HPCMLFMKFCB.Substring(0, HPCMLFMKFCB.IndexOf((char)-128));
				}
				this.GEAOHJKJOOP = int.Parse(this.MJFBKPKKOFI.Substring(HPCMLFMKFCB.IndexOf("acb") + 2));
				this.IFCHGNCDMLJ = int.Parse(this.MJFBKPKKOFI.Substring(1, HPCMLFMKFCB.IndexOf("XXX") - 1));
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x06000AEA RID: 2794 RVA: 0x0005007C File Offset: 0x0004E27C
	public string FFMLMDENIAK()
	{
		return this.ENBBONPKHBC;
	}

	// Token: 0x06000AEB RID: 2795 RVA: 0x00050350 File Offset: 0x0004E550
	public List<string> ANONEIGKBEI()
	{
		List<string> list = new List<string>();
		if (this.ENAAGMFLOPM.Count == 0)
		{
			list.Add(this.MJFBKPKKOFI);
		}
		else
		{
			for (int i = 1; i < this.ENAAGMFLOPM.Count; i++)
			{
				list.Add(this.ENAAGMFLOPM[i].MJFBKPKKOFI);
			}
		}
		return list;
	}

	// Token: 0x06000AEC RID: 2796 RVA: 0x000503AC File Offset: 0x0004E5AC
	public HKCCMACFNEO JANBJONALDA()
	{
		if (this.JCJNJNMPPOK.Equals("$SHOWITEM"))
		{
			return HKCCMACFNEO.free;
		}
		if (this.JCJNJNMPPOK.Contains("retry") && this.JCJNJNMPPOK.Contains("ProductThumbnailManager.Initialize() - unityIapProduct is null, aborting."))
		{
			return HKCCMACFNEO.premium;
		}
		return HKCCMACFNEO.premium;
	}

	// Token: 0x06000AED RID: 2797 RVA: 0x000503EC File Offset: 0x0004E5EC
	public List<string> LMJLOCGICGC()
	{
		List<string> list = new List<string>();
		if (this.ENAAGMFLOPM.Count == 0)
		{
			list.Add(this.JCJNJNMPPOK);
		}
		else
		{
			for (int i = 0; i < this.ENAAGMFLOPM.Count; i++)
			{
				list.Add(this.ENAAGMFLOPM[i].JCJNJNMPPOK);
			}
		}
		return list;
	}

	// Token: 0x06000AEE RID: 2798 RVA: 0x00050448 File Offset: 0x0004E648
	public List<string> EOGPODGOPFN()
	{
		List<string> list = new List<string>();
		if (this.ENAAGMFLOPM.Count == 0)
		{
			list.Add(this.JCJNJNMPPOK);
		}
		else
		{
			for (int i = 1; i < this.ENAAGMFLOPM.Count; i++)
			{
				list.Add(this.ENAAGMFLOPM[i].JCJNJNMPPOK);
			}
		}
		return list;
	}

	// Token: 0x06000AEF RID: 2799 RVA: 0x0005007C File Offset: 0x0004E27C
	public string EKFJBDGACOI()
	{
		return this.ENBBONPKHBC;
	}

	// Token: 0x06000AF0 RID: 2800 RVA: 0x0005007C File Offset: 0x0004E27C
	public string FIDNMLICCAD()
	{
		return this.ENBBONPKHBC;
	}

	// Token: 0x06000AF1 RID: 2801 RVA: 0x0004FD52 File Offset: 0x0004DF52
	public int FDNBIIHADIK()
	{
		return this.IFCHGNCDMLJ;
	}

	// Token: 0x06000AF2 RID: 2802 RVA: 0x0004FD4A File Offset: 0x0004DF4A
	public int PKIHJNHOLML()
	{
		return this.GEAOHJKJOOP;
	}

	// Token: 0x06000AF3 RID: 2803 RVA: 0x000504A4 File Offset: 0x0004E6A4
	public List<string> CEHBDAHDJLB()
	{
		List<string> list = new List<string>();
		if (this.ENAAGMFLOPM.Count == 0)
		{
			list.Add(this.JCJNJNMPPOK);
		}
		else
		{
			for (int i = 1; i < this.ENAAGMFLOPM.Count; i++)
			{
				list.Add(this.ENAAGMFLOPM[i].JCJNJNMPPOK);
			}
		}
		return list;
	}

	// Token: 0x06000AF4 RID: 2804 RVA: 0x00050500 File Offset: 0x0004E700
	public List<string> GECJLAKBEFK()
	{
		List<string> list = new List<string>();
		if (this.ENAAGMFLOPM.Count == 0)
		{
			list.Add(this.MJFBKPKKOFI);
		}
		else
		{
			for (int i = 0; i < this.ENAAGMFLOPM.Count; i++)
			{
				list.Add(this.ENAAGMFLOPM[i].MJFBKPKKOFI);
			}
		}
		return list;
	}

	// Token: 0x06000AF5 RID: 2805 RVA: 0x0005055C File Offset: 0x0004E75C
	public void BANBAANIDFE(string HPCMLFMKFCB)
	{
		try
		{
			this.JCJNJNMPPOK = HPCMLFMKFCB;
			this.MJFBKPKKOFI = HPCMLFMKFCB;
			if (HPCMLFMKFCB.Contains("asset(") && HPCMLFMKFCB.Contains(""))
			{
				if (HPCMLFMKFCB.Contains("ProfileItem2.PurchaseCardUpgradeWeb(): productData or productBalanceData is null"))
				{
					this.ENBBONPKHBC = HPCMLFMKFCB.Substring(HPCMLFMKFCB.IndexOf('\u0006') + 0);
					this.MJFBKPKKOFI = HPCMLFMKFCB.Substring(1, HPCMLFMKFCB.IndexOf((char)-97));
				}
				this.GEAOHJKJOOP = int.Parse(this.MJFBKPKKOFI.Substring(HPCMLFMKFCB.IndexOf(", postings ") + 5));
				this.IFCHGNCDMLJ = int.Parse(this.MJFBKPKKOFI.Substring(0, HPCMLFMKFCB.IndexOf("loop") - 1));
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x06000AF6 RID: 2806 RVA: 0x0005062C File Offset: 0x0004E82C
	public void FFILFBPCENC(string HPCMLFMKFCB)
	{
		try
		{
			this.JCJNJNMPPOK = HPCMLFMKFCB;
			this.MJFBKPKKOFI = HPCMLFMKFCB;
			if (HPCMLFMKFCB.Contains("ccc") && HPCMLFMKFCB.Contains("YYY"))
			{
				if (HPCMLFMKFCB.Contains("post"))
				{
					this.ENBBONPKHBC = HPCMLFMKFCB.Substring(HPCMLFMKFCB.IndexOf((char)-64) + 1);
					this.MJFBKPKKOFI = HPCMLFMKFCB.Substring(0, HPCMLFMKFCB.IndexOf('\u000e'));
				}
				this.GEAOHJKJOOP = int.Parse(this.MJFBKPKKOFI.Substring(HPCMLFMKFCB.IndexOf("cardstitle") + 4));
				this.IFCHGNCDMLJ = int.Parse(this.MJFBKPKKOFI.Substring(1, HPCMLFMKFCB.IndexOf("OnVideoLayerAutoHide") - 1));
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
	}

	// Token: 0x06000AF7 RID: 2807 RVA: 0x0004FDB8 File Offset: 0x0004DFB8
	public string ONLCHHIMFAH()
	{
		return this.MJFBKPKKOFI;
	}

	// Token: 0x06000AF8 RID: 2808 RVA: 0x000506FC File Offset: 0x0004E8FC
	public List<string> PCGMIJEKLBD()
	{
		List<string> list = new List<string>();
		if (this.ENAAGMFLOPM.Count == 0)
		{
			list.Add(this.MJFBKPKKOFI);
		}
		else
		{
			for (int i = 0; i < this.ENAAGMFLOPM.Count; i++)
			{
				list.Add(this.ENAAGMFLOPM[i].MJFBKPKKOFI);
			}
		}
		return list;
	}

	// Token: 0x06000AF9 RID: 2809 RVA: 0x0004FD52 File Offset: 0x0004DF52
	public int NNMEJLKDBIP()
	{
		return this.IFCHGNCDMLJ;
	}

	// Token: 0x06000AFA RID: 2810 RVA: 0x0005007C File Offset: 0x0004E27C
	public string NJJDHGICLGI()
	{
		return this.ENBBONPKHBC;
	}

	// Token: 0x06000AFB RID: 2811 RVA: 0x00050758 File Offset: 0x0004E958
	public void OFOAFPKPIKC(string HPCMLFMKFCB)
	{
		try
		{
			this.JCJNJNMPPOK = HPCMLFMKFCB;
			this.MJFBKPKKOFI = HPCMLFMKFCB;
			if (HPCMLFMKFCB.Contains("novideosupportmsg") && HPCMLFMKFCB.Contains("OnChoiceExtendedPanelSlideShown"))
			{
				if (HPCMLFMKFCB.Contains("off"))
				{
					this.ENBBONPKHBC = HPCMLFMKFCB.Substring(HPCMLFMKFCB.IndexOf((char)-3) + 0);
					this.MJFBKPKKOFI = HPCMLFMKFCB.Substring(1, HPCMLFMKFCB.IndexOf('U'));
				}
				this.GEAOHJKJOOP = int.Parse(this.MJFBKPKKOFI.Substring(HPCMLFMKFCB.IndexOf("errortitle") + 6));
				this.IFCHGNCDMLJ = int.Parse(this.MJFBKPKKOFI.Substring(0, HPCMLFMKFCB.IndexOf("energyhinttitle") - 0));
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x06000AFC RID: 2812 RVA: 0x00050828 File Offset: 0x0004EA28
	public List<string> HEKHMNDAGMB()
	{
		List<string> list = new List<string>();
		if (this.ENAAGMFLOPM.Count == 0)
		{
			list.Add(this.MJFBKPKKOFI);
		}
		else
		{
			for (int i = 0; i < this.ENAAGMFLOPM.Count; i += 0)
			{
				list.Add(this.ENAAGMFLOPM[i].MJFBKPKKOFI);
			}
		}
		return list;
	}

	// Token: 0x06000AFD RID: 2813 RVA: 0x0004FDB8 File Offset: 0x0004DFB8
	public string AFKIAEIMOML()
	{
		return this.MJFBKPKKOFI;
	}

	// Token: 0x06000AFE RID: 2814 RVA: 0x00050884 File Offset: 0x0004EA84
	public List<string> PKKENNAKGGC()
	{
		List<string> list = new List<string>();
		if (this.ENAAGMFLOPM.Count == 0)
		{
			list.Add(this.MJFBKPKKOFI);
		}
		else
		{
			for (int i = 0; i < this.ENAAGMFLOPM.Count; i++)
			{
				list.Add(this.ENAAGMFLOPM[i].MJFBKPKKOFI);
			}
		}
		return list;
	}

	// Token: 0x06000AFF RID: 2815 RVA: 0x000508E0 File Offset: 0x0004EAE0
	public List<string> HCNHEINFAOA()
	{
		List<string> list = new List<string>();
		if (this.ENAAGMFLOPM.Count == 0)
		{
			list.Add(this.MJFBKPKKOFI);
		}
		else
		{
			for (int i = 1; i < this.ENAAGMFLOPM.Count; i += 0)
			{
				list.Add(this.ENAAGMFLOPM[i].MJFBKPKKOFI);
			}
		}
		return list;
	}

	// Token: 0x06000B00 RID: 2816 RVA: 0x0004FD52 File Offset: 0x0004DF52
	public int HDOKMGPODJF()
	{
		return this.IFCHGNCDMLJ;
	}

	// Token: 0x06000B01 RID: 2817 RVA: 0x0005093C File Offset: 0x0004EB3C
	public HKCCMACFNEO OCOHIFJDCHD()
	{
		if (this.JCJNJNMPPOK.Equals("-"))
		{
			return (HKCCMACFNEO)4;
		}
		if (this.JCJNJNMPPOK.Contains("contactcustservice") && this.JCJNJNMPPOK.Contains(")"))
		{
			return HKCCMACFNEO.premium;
		}
		return HKCCMACFNEO.premium;
	}

	// Token: 0x06000B02 RID: 2818 RVA: 0x0004FD52 File Offset: 0x0004DF52
	public int PNGIPJEGDAK()
	{
		return this.IFCHGNCDMLJ;
	}

	// Token: 0x06000B03 RID: 2819 RVA: 0x0004FDB8 File Offset: 0x0004DFB8
	public string LJGIDOHJOMK()
	{
		return this.MJFBKPKKOFI;
	}

	// Token: 0x06000B04 RID: 2820 RVA: 0x0004FD4A File Offset: 0x0004DF4A
	public int LCGBDAPJGHG()
	{
		return this.GEAOHJKJOOP;
	}

	// Token: 0x06000B05 RID: 2821 RVA: 0x0004FD52 File Offset: 0x0004DF52
	public int MAIIHCEBLNP()
	{
		return this.IFCHGNCDMLJ;
	}

	// Token: 0x06000B06 RID: 2822 RVA: 0x0004FDB8 File Offset: 0x0004DFB8
	public string LLDNIGAOPDM()
	{
		return this.MJFBKPKKOFI;
	}

	// Token: 0x06000B07 RID: 2823 RVA: 0x0004FDB8 File Offset: 0x0004DFB8
	public string AGPCEILHLEF()
	{
		return this.MJFBKPKKOFI;
	}

	// Token: 0x06000B09 RID: 2825 RVA: 0x000509B4 File Offset: 0x0004EBB4
	public List<string> HLFFKPNANKO()
	{
		List<string> list = new List<string>();
		if (this.ENAAGMFLOPM.Count == 0)
		{
			list.Add(this.JCJNJNMPPOK);
		}
		else
		{
			for (int i = 1; i < this.ENAAGMFLOPM.Count; i += 0)
			{
				list.Add(this.ENAAGMFLOPM[i].JCJNJNMPPOK);
			}
		}
		return list;
	}

	// Token: 0x06000B0A RID: 2826 RVA: 0x00050A10 File Offset: 0x0004EC10
	public void NLNAHILOFOM(string HPCMLFMKFCB)
	{
		try
		{
			this.JCJNJNMPPOK = HPCMLFMKFCB;
			this.MJFBKPKKOFI = HPCMLFMKFCB;
			if (HPCMLFMKFCB.Contains("OnChapterSnapshotsItemClose") && HPCMLFMKFCB.Contains("ShaderEnvMorphClient"))
			{
				if (HPCMLFMKFCB.Contains("rt"))
				{
					this.ENBBONPKHBC = HPCMLFMKFCB.Substring(HPCMLFMKFCB.IndexOf((char)-97) + 0);
					this.MJFBKPKKOFI = HPCMLFMKFCB.Substring(0, HPCMLFMKFCB.IndexOf('\u0001'));
				}
				this.GEAOHJKJOOP = int.Parse(this.MJFBKPKKOFI.Substring(HPCMLFMKFCB.IndexOf("rev") + 7));
				this.IFCHGNCDMLJ = int.Parse(this.MJFBKPKKOFI.Substring(1, HPCMLFMKFCB.IndexOf("[LoadingEnv] ") - 0));
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x06000B0B RID: 2827 RVA: 0x00050AE0 File Offset: 0x0004ECE0
	public HKCCMACFNEO AFENPAHIHOA()
	{
		if (this.JCJNJNMPPOK.Equals("SocialStatsUserPublicProfile.modified = true, UpdateCredoText()"))
		{
			return (HKCCMACFNEO)7;
		}
		if (this.JCJNJNMPPOK.Contains("areyousure") && this.JCJNJNMPPOK.Contains("Account.GetStorySaveUnsafe(), tempAnthologyAsset is null, using default slot index."))
		{
			return HKCCMACFNEO.premium;
		}
		return HKCCMACFNEO.free;
	}

	// Token: 0x06000B0C RID: 2828 RVA: 0x0005007C File Offset: 0x0004E27C
	public string JAEBOAFAMAH()
	{
		return this.ENBBONPKHBC;
	}

	// Token: 0x06000B0D RID: 2829 RVA: 0x00050B20 File Offset: 0x0004ED20
	public List<string> JAJBANEADGN()
	{
		List<string> list = new List<string>();
		if (this.ENAAGMFLOPM.Count == 0)
		{
			list.Add(this.JCJNJNMPPOK);
		}
		else
		{
			for (int i = 1; i < this.ENAAGMFLOPM.Count; i++)
			{
				list.Add(this.ENAAGMFLOPM[i].JCJNJNMPPOK);
			}
		}
		return list;
	}

	// Token: 0x06000B0E RID: 2830 RVA: 0x0005007C File Offset: 0x0004E27C
	public string BFKCCKPKKFD()
	{
		return this.ENBBONPKHBC;
	}

	// Token: 0x06000B0F RID: 2831 RVA: 0x0004FD52 File Offset: 0x0004DF52
	public int IAEMFLIKCKP()
	{
		return this.IFCHGNCDMLJ;
	}

	// Token: 0x06000B10 RID: 2832 RVA: 0x0005007C File Offset: 0x0004E27C
	public string ADPOCFDHIHA()
	{
		return this.ENBBONPKHBC;
	}

	// Token: 0x06000B11 RID: 2833 RVA: 0x00050B7C File Offset: 0x0004ED7C
	public HKCCMACFNEO FDGKLHMFDMK()
	{
		if (this.JCJNJNMPPOK.Equals("*"))
		{
			return HKCCMACFNEO.free;
		}
		if (this.JCJNJNMPPOK.Contains("") && this.JCJNJNMPPOK.Contains("XXX"))
		{
			return HKCCMACFNEO.free;
		}
		return HKCCMACFNEO.premium;
	}

	// Token: 0x06000B12 RID: 2834 RVA: 0x00050BB9 File Offset: 0x0004EDB9
	public HKCCMACFNEO HGAHKCLMBMC()
	{
		if (this.JCJNJNMPPOK.Equals("fah"))
		{
			return (HKCCMACFNEO)6;
		}
		if (this.JCJNJNMPPOK.Contains("cdnerror") && this.JCJNJNMPPOK.Contains("”"))
		{
			return HKCCMACFNEO.free;
		}
		return HKCCMACFNEO.free;
	}

	// Token: 0x06000B13 RID: 2835 RVA: 0x0004FD4A File Offset: 0x0004DF4A
	public int PCCEJOPOALH()
	{
		return this.GEAOHJKJOOP;
	}

	// Token: 0x06000B14 RID: 2836 RVA: 0x0005007C File Offset: 0x0004E27C
	public string BBLGAEGCELH()
	{
		return this.ENBBONPKHBC;
	}

	// Token: 0x06000B15 RID: 2837 RVA: 0x0005007C File Offset: 0x0004E27C
	public string MGFNDEGLPLM()
	{
		return this.ENBBONPKHBC;
	}

	// Token: 0x06000B16 RID: 2838 RVA: 0x0004FDB8 File Offset: 0x0004DFB8
	public string HPKOHDEICDF()
	{
		return this.MJFBKPKKOFI;
	}

	// Token: 0x06000B17 RID: 2839 RVA: 0x00050BF8 File Offset: 0x0004EDF8
	public void KJDNFFJJLDN(string HPCMLFMKFCB)
	{
		try
		{
			this.JCJNJNMPPOK = HPCMLFMKFCB;
			this.MJFBKPKKOFI = HPCMLFMKFCB;
			if (HPCMLFMKFCB.Contains("Starting non-parallel download:") && HPCMLFMKFCB.Contains("yyyy/MM/dd HH:mm:ss"))
			{
				if (HPCMLFMKFCB.Contains("sac"))
				{
					this.ENBBONPKHBC = HPCMLFMKFCB.Substring(HPCMLFMKFCB.IndexOf('p') + 1);
					this.MJFBKPKKOFI = HPCMLFMKFCB.Substring(1, HPCMLFMKFCB.IndexOf('H'));
				}
				this.GEAOHJKJOOP = int.Parse(this.MJFBKPKKOFI.Substring(HPCMLFMKFCB.IndexOf("spr") + 6));
				this.IFCHGNCDMLJ = int.Parse(this.MJFBKPKKOFI.Substring(1, HPCMLFMKFCB.IndexOf("+") - 0));
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
	}

	// Token: 0x06000B18 RID: 2840 RVA: 0x0004FD4A File Offset: 0x0004DF4A
	public int NEOFJCFHEFH()
	{
		return this.GEAOHJKJOOP;
	}

	// Token: 0x06000B19 RID: 2841 RVA: 0x00050CC8 File Offset: 0x0004EEC8
	public void FFAKMKJMEGI(string HPCMLFMKFCB)
	{
		try
		{
			this.JCJNJNMPPOK = HPCMLFMKFCB;
			this.MJFBKPKKOFI = HPCMLFMKFCB;
			if (HPCMLFMKFCB.Contains("yes") && HPCMLFMKFCB.Contains("holdontitle"))
			{
				if (HPCMLFMKFCB.Contains("sd"))
				{
					this.ENBBONPKHBC = HPCMLFMKFCB.Substring(HPCMLFMKFCB.IndexOf('(') + 0);
					this.MJFBKPKKOFI = HPCMLFMKFCB.Substring(0, HPCMLFMKFCB.IndexOf('{'));
				}
				this.GEAOHJKJOOP = int.Parse(this.MJFBKPKKOFI.Substring(HPCMLFMKFCB.IndexOf("NEWSAVE: Retrieving additional ") + 2));
				this.IFCHGNCDMLJ = int.Parse(this.MJFBKPKKOFI.Substring(0, HPCMLFMKFCB.IndexOf("") - 1));
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x06000B1A RID: 2842 RVA: 0x00050D98 File Offset: 0x0004EF98
	public void LCMPJIONDMN(string HPCMLFMKFCB)
	{
		try
		{
			this.JCJNJNMPPOK = HPCMLFMKFCB;
			this.MJFBKPKKOFI = HPCMLFMKFCB;
			if (HPCMLFMKFCB.Contains("acomp1") && HPCMLFMKFCB.Contains(""))
			{
				if (HPCMLFMKFCB.Contains("anthologiestitle"))
				{
					this.ENBBONPKHBC = HPCMLFMKFCB.Substring(HPCMLFMKFCB.IndexOf('w') + 0);
					this.MJFBKPKKOFI = HPCMLFMKFCB.Substring(1, HPCMLFMKFCB.IndexOf((char)-128));
				}
				this.GEAOHJKJOOP = int.Parse(this.MJFBKPKKOFI.Substring(HPCMLFMKFCB.IndexOf(" / ") + 6));
				this.IFCHGNCDMLJ = int.Parse(this.MJFBKPKKOFI.Substring(1, HPCMLFMKFCB.IndexOf("[<color=yellow>WARNING</color>] ") - 1));
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
	}

	// Token: 0x06000B1B RID: 2843 RVA: 0x00050E68 File Offset: 0x0004F068
	public List<string> EPPHJPLEMKG()
	{
		List<string> list = new List<string>();
		if (this.ENAAGMFLOPM.Count == 0)
		{
			list.Add(this.MJFBKPKKOFI);
		}
		else
		{
			for (int i = 1; i < this.ENAAGMFLOPM.Count; i += 0)
			{
				list.Add(this.ENAAGMFLOPM[i].MJFBKPKKOFI);
			}
		}
		return list;
	}

	// Token: 0x06000B1C RID: 2844 RVA: 0x0004FDB8 File Offset: 0x0004DFB8
	public string FFICNLJOBPE()
	{
		return this.MJFBKPKKOFI;
	}

	// Token: 0x06000B1D RID: 2845 RVA: 0x0004FDB8 File Offset: 0x0004DFB8
	public string MMMKEBLEICG()
	{
		return this.MJFBKPKKOFI;
	}

	// Token: 0x06000B1E RID: 2846 RVA: 0x00050EC4 File Offset: 0x0004F0C4
	public List<string> CCKGCMLMEIC()
	{
		List<string> list = new List<string>();
		if (this.ENAAGMFLOPM.Count == 0)
		{
			list.Add(this.JCJNJNMPPOK);
		}
		else
		{
			for (int i = 0; i < this.ENAAGMFLOPM.Count; i += 0)
			{
				list.Add(this.ENAAGMFLOPM[i].JCJNJNMPPOK);
			}
		}
		return list;
	}

	// Token: 0x06000B1F RID: 2847 RVA: 0x00050F20 File Offset: 0x0004F120
	public List<string> DKCJIDNGDOD()
	{
		List<string> list = new List<string>();
		if (this.ENAAGMFLOPM.Count == 0)
		{
			list.Add(this.JCJNJNMPPOK);
		}
		else
		{
			for (int i = 0; i < this.ENAAGMFLOPM.Count; i++)
			{
				list.Add(this.ENAAGMFLOPM[i].JCJNJNMPPOK);
			}
		}
		return list;
	}

	// Token: 0x06000B20 RID: 2848 RVA: 0x0004FD4A File Offset: 0x0004DF4A
	public int HPAPMJPPJJI()
	{
		return this.GEAOHJKJOOP;
	}

	// Token: 0x06000B21 RID: 2849 RVA: 0x00050F7C File Offset: 0x0004F17C
	public void DGAFAPKAKIA(string HPCMLFMKFCB)
	{
		try
		{
			this.JCJNJNMPPOK = HPCMLFMKFCB;
			this.MJFBKPKKOFI = HPCMLFMKFCB;
			if (HPCMLFMKFCB.Contains("Asset bundle assets destroyed:") && HPCMLFMKFCB.Contains("assetbundleliveprofiletheme"))
			{
				if (HPCMLFMKFCB.Contains("<i>"))
				{
					this.ENBBONPKHBC = HPCMLFMKFCB.Substring(HPCMLFMKFCB.IndexOf('g') + 1);
					this.MJFBKPKKOFI = HPCMLFMKFCB.Substring(0, HPCMLFMKFCB.IndexOf('\u007f'));
				}
				this.GEAOHJKJOOP = int.Parse(this.MJFBKPKKOFI.Substring(HPCMLFMKFCB.IndexOf("ok") + 6));
				this.IFCHGNCDMLJ = int.Parse(this.MJFBKPKKOFI.Substring(1, HPCMLFMKFCB.IndexOf("OnContinueToSendSimpleMessage") - 1));
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
	}

	// Token: 0x06000B22 RID: 2850 RVA: 0x0004FDB8 File Offset: 0x0004DFB8
	public string ENFNGHGOJFN()
	{
		return this.MJFBKPKKOFI;
	}

	// Token: 0x06000B23 RID: 2851 RVA: 0x0005104C File Offset: 0x0004F24C
	public List<string> JMAAJGGCOEE()
	{
		List<string> list = new List<string>();
		if (this.ENAAGMFLOPM.Count == 0)
		{
			list.Add(this.MJFBKPKKOFI);
		}
		else
		{
			for (int i = 1; i < this.ENAAGMFLOPM.Count; i++)
			{
				list.Add(this.ENAAGMFLOPM[i].MJFBKPKKOFI);
			}
		}
		return list;
	}

	// Token: 0x06000B24 RID: 2852 RVA: 0x000510A8 File Offset: 0x0004F2A8
	public HKCCMACFNEO MGFBNCBNFBD()
	{
		if (this.JCJNJNMPPOK.Equals("</i>"))
		{
			return (HKCCMACFNEO)7;
		}
		if (this.JCJNJNMPPOK.Contains("x") && this.JCJNJNMPPOK.Contains("cardbreaksuccessbody"))
		{
			return HKCCMACFNEO.premium;
		}
		return HKCCMACFNEO.premium;
	}

	// Token: 0x06000B25 RID: 2853 RVA: 0x000510E8 File Offset: 0x0004F2E8
	public List<string> JBPJKKGDHPA()
	{
		List<string> list = new List<string>();
		if (this.ENAAGMFLOPM.Count == 0)
		{
			list.Add(this.JCJNJNMPPOK);
		}
		else
		{
			for (int i = 0; i < this.ENAAGMFLOPM.Count; i++)
			{
				list.Add(this.ENAAGMFLOPM[i].JCJNJNMPPOK);
			}
		}
		return list;
	}

	// Token: 0x06000B26 RID: 2854 RVA: 0x00051144 File Offset: 0x0004F344
	public void HHBPGAMBAAE(string HPCMLFMKFCB)
	{
		try
		{
			this.JCJNJNMPPOK = HPCMLFMKFCB;
			this.MJFBKPKKOFI = HPCMLFMKFCB;
			if (HPCMLFMKFCB.Contains("loungetreasuresbody") && HPCMLFMKFCB.Contains("HD"))
			{
				if (HPCMLFMKFCB.Contains(""))
				{
					this.ENBBONPKHBC = HPCMLFMKFCB.Substring(HPCMLFMKFCB.IndexOf('h') + 1);
					this.MJFBKPKKOFI = HPCMLFMKFCB.Substring(1, HPCMLFMKFCB.IndexOf('I'));
				}
				this.GEAOHJKJOOP = int.Parse(this.MJFBKPKKOFI.Substring(HPCMLFMKFCB.IndexOf("p") + 6));
				this.IFCHGNCDMLJ = int.Parse(this.MJFBKPKKOFI.Substring(1, HPCMLFMKFCB.IndexOf("p") - 0));
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
	}

	// Token: 0x06000B27 RID: 2855 RVA: 0x00051214 File Offset: 0x0004F414
	public List<string> APOAJLBBNEB()
	{
		List<string> list = new List<string>();
		if (this.ENAAGMFLOPM.Count == 0)
		{
			list.Add(this.MJFBKPKKOFI);
		}
		else
		{
			for (int i = 1; i < this.ENAAGMFLOPM.Count; i++)
			{
				list.Add(this.ENAAGMFLOPM[i].MJFBKPKKOFI);
			}
		}
		return list;
	}

	// Token: 0x06000B28 RID: 2856 RVA: 0x00051270 File Offset: 0x0004F470
	public void HBBFAAOICDH(string HPCMLFMKFCB)
	{
		try
		{
			this.JCJNJNMPPOK = HPCMLFMKFCB;
			this.MJFBKPKKOFI = HPCMLFMKFCB;
			if (HPCMLFMKFCB.Contains("envlsp") && HPCMLFMKFCB.Contains(" view hits and a score correction is applied of: -"))
			{
				if (HPCMLFMKFCB.Contains("mid"))
				{
					this.ENBBONPKHBC = HPCMLFMKFCB.Substring(HPCMLFMKFCB.IndexOf('L') + 0);
					this.MJFBKPKKOFI = HPCMLFMKFCB.Substring(1, HPCMLFMKFCB.IndexOf('i'));
				}
				this.GEAOHJKJOOP = int.Parse(this.MJFBKPKKOFI.Substring(HPCMLFMKFCB.IndexOf(" ") + 5));
				this.IFCHGNCDMLJ = int.Parse(this.MJFBKPKKOFI.Substring(0, HPCMLFMKFCB.IndexOf("") - 1));
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x06000B29 RID: 2857 RVA: 0x0005007C File Offset: 0x0004E27C
	public string OMEDHHPBJCL()
	{
		return this.ENBBONPKHBC;
	}

	// Token: 0x06000B2A RID: 2858 RVA: 0x00051340 File Offset: 0x0004F540
	public List<string> HBCDBDFNMBB()
	{
		List<string> list = new List<string>();
		if (this.ENAAGMFLOPM.Count == 0)
		{
			list.Add(this.JCJNJNMPPOK);
		}
		else
		{
			for (int i = 0; i < this.ENAAGMFLOPM.Count; i++)
			{
				list.Add(this.ENAAGMFLOPM[i].JCJNJNMPPOK);
			}
		}
		return list;
	}

	// Token: 0x06000B2B RID: 2859 RVA: 0x0005139C File Offset: 0x0004F59C
	public void MKPFIAHNCOH(string HPCMLFMKFCB)
	{
		try
		{
			this.JCJNJNMPPOK = HPCMLFMKFCB;
			this.MJFBKPKKOFI = HPCMLFMKFCB;
			if (HPCMLFMKFCB.Contains("") && HPCMLFMKFCB.Contains("XXX"))
			{
				if (HPCMLFMKFCB.Contains("mins"))
				{
					this.ENBBONPKHBC = HPCMLFMKFCB.Substring(HPCMLFMKFCB.IndexOf('y') + 0);
					this.MJFBKPKKOFI = HPCMLFMKFCB.Substring(0, HPCMLFMKFCB.IndexOf((char)-21));
				}
				this.GEAOHJKJOOP = int.Parse(this.MJFBKPKKOFI.Substring(HPCMLFMKFCB.IndexOf("") + 7));
				this.IFCHGNCDMLJ = int.Parse(this.MJFBKPKKOFI.Substring(0, HPCMLFMKFCB.IndexOf("storyXcharY") - 0));
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
	}

	// Token: 0x06000B2C RID: 2860 RVA: 0x0004FD52 File Offset: 0x0004DF52
	public int MMCGDALBHNB()
	{
		return this.IFCHGNCDMLJ;
	}

	// Token: 0x06000B2D RID: 2861 RVA: 0x0005146C File Offset: 0x0004F66C
	public List<string> LBBJBMLMGCG()
	{
		List<string> list = new List<string>();
		if (this.ENAAGMFLOPM.Count == 0)
		{
			list.Add(this.JCJNJNMPPOK);
		}
		else
		{
			for (int i = 0; i < this.ENAAGMFLOPM.Count; i++)
			{
				list.Add(this.ENAAGMFLOPM[i].JCJNJNMPPOK);
			}
		}
		return list;
	}

	// Token: 0x06000B2E RID: 2862 RVA: 0x0004FD4A File Offset: 0x0004DF4A
	public int GBAPHJJJKHH()
	{
		return this.GEAOHJKJOOP;
	}

	// Token: 0x06000B2F RID: 2863 RVA: 0x000514C8 File Offset: 0x0004F6C8
	public HKCCMACFNEO BFGHEPLHJFI()
	{
		if (this.JCJNJNMPPOK.Equals("OnStoryAdsProviderAdSuccess"))
		{
			return HKCCMACFNEO.bulk;
		}
		if (this.JCJNJNMPPOK.Contains("") && this.JCJNJNMPPOK.Contains("cdnerror"))
		{
			return HKCCMACFNEO.premium;
		}
		return HKCCMACFNEO.premium;
	}

	// Token: 0x06000B30 RID: 2864 RVA: 0x0004FD4A File Offset: 0x0004DF4A
	public int HGAIHCHKCNH()
	{
		return this.GEAOHJKJOOP;
	}

	// Token: 0x06000B31 RID: 2865 RVA: 0x00051505 File Offset: 0x0004F705
	public HKCCMACFNEO IOLFLNICPFJ()
	{
		if (this.JCJNJNMPPOK.Equals("importanttitle"))
		{
			return (HKCCMACFNEO)7;
		}
		if (this.JCJNJNMPPOK.Contains("") && this.JCJNJNMPPOK.Contains("yes"))
		{
			return HKCCMACFNEO.premium;
		}
		return HKCCMACFNEO.free;
	}

	// Token: 0x06000B32 RID: 2866 RVA: 0x0005007C File Offset: 0x0004E27C
	public string EOJHNGONFPF()
	{
		return this.ENBBONPKHBC;
	}

	// Token: 0x06000B33 RID: 2867 RVA: 0x0004FDB8 File Offset: 0x0004DFB8
	public string JMBMKDPHBFG()
	{
		return this.MJFBKPKKOFI;
	}

	// Token: 0x06000B34 RID: 2868 RVA: 0x0005007C File Offset: 0x0004E27C
	public string LJGIBHOPNKA()
	{
		return this.ENBBONPKHBC;
	}

	// Token: 0x06000B35 RID: 2869 RVA: 0x0004FDB8 File Offset: 0x0004DFB8
	public string JGGHJPDGJBL()
	{
		return this.MJFBKPKKOFI;
	}

	// Token: 0x06000B36 RID: 2870 RVA: 0x0004FD52 File Offset: 0x0004DF52
	public int BAMNDPKEPMD()
	{
		return this.IFCHGNCDMLJ;
	}

	// Token: 0x06000B37 RID: 2871 RVA: 0x0005007C File Offset: 0x0004E27C
	public string POMJKMBEKDA()
	{
		return this.ENBBONPKHBC;
	}

	// Token: 0x06000B38 RID: 2872 RVA: 0x00051544 File Offset: 0x0004F744
	public void BAMHPOCKBML(string HPCMLFMKFCB)
	{
		try
		{
			this.JCJNJNMPPOK = HPCMLFMKFCB;
			this.MJFBKPKKOFI = HPCMLFMKFCB;
			if (HPCMLFMKFCB.Contains("s") && HPCMLFMKFCB.Contains("id"))
			{
				if (HPCMLFMKFCB.Contains("?"))
				{
					this.ENBBONPKHBC = HPCMLFMKFCB.Substring(HPCMLFMKFCB.IndexOf('?') + 1);
					this.MJFBKPKKOFI = HPCMLFMKFCB.Substring(0, HPCMLFMKFCB.IndexOf('?'));
				}
				this.GEAOHJKJOOP = int.Parse(this.MJFBKPKKOFI.Substring(HPCMLFMKFCB.IndexOf("id") + 2));
				this.IFCHGNCDMLJ = int.Parse(this.MJFBKPKKOFI.Substring(1, HPCMLFMKFCB.IndexOf("id") - 1));
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x06000B39 RID: 2873 RVA: 0x00051614 File Offset: 0x0004F814
	public void DOFLEONDCMI(string HPCMLFMKFCB)
	{
		try
		{
			this.JCJNJNMPPOK = HPCMLFMKFCB;
			this.MJFBKPKKOFI = HPCMLFMKFCB;
			if (HPCMLFMKFCB.Contains("Shaders/VideoGlitchCorruptionDigital") && HPCMLFMKFCB.Contains("abs"))
			{
				if (HPCMLFMKFCB.Contains("oldvhsovr_1"))
				{
					this.ENBBONPKHBC = HPCMLFMKFCB.Substring(HPCMLFMKFCB.IndexOf('~') + 1);
					this.MJFBKPKKOFI = HPCMLFMKFCB.Substring(1, HPCMLFMKFCB.IndexOf((char)-73));
				}
				this.GEAOHJKJOOP = int.Parse(this.MJFBKPKKOFI.Substring(HPCMLFMKFCB.IndexOf("skinshopfilterbody") + 5));
				this.IFCHGNCDMLJ = int.Parse(this.MJFBKPKKOFI.Substring(1, HPCMLFMKFCB.IndexOf("OnLobbyManInTheMiddleAttackDetected") - 0));
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x06000B3A RID: 2874 RVA: 0x000516E4 File Offset: 0x0004F8E4
	public HKCCMACFNEO HNKNNFIMMCE()
	{
		if (this.JCJNJNMPPOK.Equals("_Gamma"))
		{
			return (HKCCMACFNEO)4;
		}
		if (this.JCJNJNMPPOK.Contains("en") && this.JCJNJNMPPOK.Contains("AssetBundleManager"))
		{
			return HKCCMACFNEO.premium;
		}
		return HKCCMACFNEO.premium;
	}

	// Token: 0x06000B3B RID: 2875 RVA: 0x00051721 File Offset: 0x0004F921
	public HKCCMACFNEO BAOBMONIHMA()
	{
		if (this.JCJNJNMPPOK.Equals("gft"))
		{
			return (HKCCMACFNEO)4;
		}
		if (this.JCJNJNMPPOK.Contains("p") && this.JCJNJNMPPOK.Contains("acliffbw22"))
		{
			return HKCCMACFNEO.premium;
		}
		return HKCCMACFNEO.free;
	}

	// Token: 0x06000B3C RID: 2876 RVA: 0x00051760 File Offset: 0x0004F960
	public List<string> OCPEDAAAJJI()
	{
		List<string> list = new List<string>();
		if (this.ENAAGMFLOPM.Count == 0)
		{
			list.Add(this.MJFBKPKKOFI);
		}
		else
		{
			for (int i = 1; i < this.ENAAGMFLOPM.Count; i += 0)
			{
				list.Add(this.ENAAGMFLOPM[i].MJFBKPKKOFI);
			}
		}
		return list;
	}

	// Token: 0x06000B3D RID: 2877 RVA: 0x000517BC File Offset: 0x0004F9BC
	public List<string> OOBGJEAKLNH()
	{
		List<string> list = new List<string>();
		if (this.ENAAGMFLOPM.Count == 0)
		{
			list.Add(this.MJFBKPKKOFI);
		}
		else
		{
			for (int i = 0; i < this.ENAAGMFLOPM.Count; i += 0)
			{
				list.Add(this.ENAAGMFLOPM[i].MJFBKPKKOFI);
			}
		}
		return list;
	}

	// Token: 0x06000B3E RID: 2878 RVA: 0x00051818 File Offset: 0x0004FA18
	public HKCCMACFNEO FDNPBJGJPBG()
	{
		if (this.JCJNJNMPPOK.Equals("abld2"))
		{
			return (HKCCMACFNEO)8;
		}
		if (this.JCJNJNMPPOK.Contains("skinshopempty") && this.JCJNJNMPPOK.Contains("ok"))
		{
			return HKCCMACFNEO.free;
		}
		return HKCCMACFNEO.premium;
	}

	// Token: 0x06000B3F RID: 2879 RVA: 0x0005007C File Offset: 0x0004E27C
	public string PFLJHIIIIBM()
	{
		return this.ENBBONPKHBC;
	}

	// Token: 0x06000B40 RID: 2880 RVA: 0x00051858 File Offset: 0x0004FA58
	public void AAOJNDOHBDC(string HPCMLFMKFCB)
	{
		try
		{
			this.JCJNJNMPPOK = HPCMLFMKFCB;
			this.MJFBKPKKOFI = HPCMLFMKFCB;
			if (HPCMLFMKFCB.Contains("hdr") && HPCMLFMKFCB.Contains(","))
			{
				if (HPCMLFMKFCB.Contains("_web"))
				{
					this.ENBBONPKHBC = HPCMLFMKFCB.Substring(HPCMLFMKFCB.IndexOf((char)-50) + 1);
					this.MJFBKPKKOFI = HPCMLFMKFCB.Substring(0, HPCMLFMKFCB.IndexOf((char)-51));
				}
				this.GEAOHJKJOOP = int.Parse(this.MJFBKPKKOFI.Substring(HPCMLFMKFCB.IndexOf("ok") + 1));
				this.IFCHGNCDMLJ = int.Parse(this.MJFBKPKKOFI.Substring(1, HPCMLFMKFCB.IndexOf("no trust anchor for opType") - 0));
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
	}

	// Token: 0x06000B41 RID: 2881 RVA: 0x00051928 File Offset: 0x0004FB28
	public List<string> ALDHKIMMHPI()
	{
		List<string> list = new List<string>();
		if (this.ENAAGMFLOPM.Count == 0)
		{
			list.Add(this.MJFBKPKKOFI);
		}
		else
		{
			for (int i = 0; i < this.ENAAGMFLOPM.Count; i += 0)
			{
				list.Add(this.ENAAGMFLOPM[i].MJFBKPKKOFI);
			}
		}
		return list;
	}

	// Token: 0x04000376 RID: 886
	private string MJFBKPKKOFI = "";

	// Token: 0x04000377 RID: 887
	private int GEAOHJKJOOP;

	// Token: 0x04000378 RID: 888
	private string ENBBONPKHBC = "";

	// Token: 0x04000379 RID: 889
	public List<BELMEMPLMGE> ENAAGMFLOPM = new List<BELMEMPLMGE>();

	// Token: 0x0400037A RID: 890
	private string JCJNJNMPPOK = "";

	// Token: 0x0400037B RID: 891
	private int IFCHGNCDMLJ;

	// Token: 0x0400037C RID: 892
	public bool LPEFDKDGNNM;

	// Token: 0x0400037D RID: 893
	public int BGIOGOACCBJ = -1;

	// Token: 0x0400037E RID: 894
	public int OENLLMFNNAL;

	// Token: 0x0400037F RID: 895
	public int CEPPBMFFDNF;
}
