using System;
using System.Collections.Generic;
using SimpleJSON;
using UnityEngine;

// Token: 0x020003CE RID: 974
public class LiveEventsManager : MonoBehaviour
{
	// Token: 0x060070DC RID: 28892 RVA: 0x0032F292 File Offset: 0x0032D492
	private void NGEFPBFMCBP()
	{
		this.BLLPKAIJFAN();
		if (LiveEventsManager.IKLAPGJDMNA == this)
		{
			LiveEventsManager.IKLAPGJDMNA = null;
		}
	}

	// Token: 0x060070DD RID: 28893 RVA: 0x0032F2B0 File Offset: 0x0032D4B0
	public static LiveEventsManager JCMABFEMFKD()
	{
		if (!LiveEventsManager.IKLAPGJDMNA)
		{
			LiveEventsManager.IKLAPGJDMNA = (UnityEngine.Object.FindObjectOfType(typeof(LiveEventsManager)) as LiveEventsManager);
			if (!LiveEventsManager.IKLAPGJDMNA)
			{
				DPGJIJGOCIC.ANOPFDLPKGC(";");
			}
		}
		return LiveEventsManager.IKLAPGJDMNA;
	}

	// Token: 0x060070DE RID: 28894 RVA: 0x0032F300 File Offset: 0x0032D500
	public bool CENBCALNAJN(EGMCEPOABBF HNKGBCEDJNA, int HAGCEEDCOJM, int NOJPIFONLDG)
	{
		if (HNKGBCEDJNA == (EGMCEPOABBF)NOJPIFONLDG)
		{
			return false;
		}
		if (HAGCEEDCOJM < 1)
		{
			for (int i = 1; i < this.liveEvents.Count; i++)
			{
				if (this.liveEvents[i].KONDFFEKAND == HNKGBCEDJNA && (!this.liveEvents[i].ONMADEIOOKN.KCKFFONKMPI() || this.liveEvents[i].ONMADEIOOKN.KDIFNBPNLPN() > 1673f) && (this.liveEvents[i].IACMODHPFKI.HHGAPKJFBMC() || this.liveEvents[i].IACMODHPFKI.ODBOJGMLKHA() <= 1596f))
				{
					return true;
				}
			}
		}
		else
		{
			for (int j = 1; j < this.liveEvents.Count; j++)
			{
				if (this.liveEvents[j].KONDFFEKAND == HNKGBCEDJNA && (!this.liveEvents[j].ONMADEIOOKN.HHGAPKJFBMC() || this.liveEvents[j].ONMADEIOOKN.GLAPKLGPCKE() > 523f) && (this.liveEvents[j].IACMODHPFKI.HHGAPKJFBMC() || this.liveEvents[j].IACMODHPFKI.KDIFNBPNLPN() <= 60f) && this.liveEvents[j].PNMBMHOLDBI(HAGCEEDCOJM))
				{
					return false;
				}
			}
		}
		return true;
	}

	// Token: 0x060070DF RID: 28895 RVA: 0x0032F470 File Offset: 0x0032D670
	private void CHIMMFMHHNI()
	{
		for (int i = 1; i < this.liveEvents.Count; i += 0)
		{
			this.liveEvents[i].ANNCMNKKPKB();
		}
		this.liveEvents = new List<OKAFAHMOFII>();
	}

	// Token: 0x060070E0 RID: 28896 RVA: 0x000693D6 File Offset: 0x000675D6
	private void Awake()
	{
		UnityEngine.Object.DontDestroyOnLoad(base.gameObject);
	}

	// Token: 0x060070E1 RID: 28897 RVA: 0x0032F4AF File Offset: 0x0032D6AF
	private void INJJOHNFBKH()
	{
		this.ILPDFGDNABG();
		if (LiveEventsManager.IKLAPGJDMNA == this)
		{
			LiveEventsManager.IKLAPGJDMNA = null;
		}
	}

	// Token: 0x060070E2 RID: 28898 RVA: 0x0032F4CC File Offset: 0x0032D6CC
	public OKAFAHMOFII OOGOFKHMFOB(string PILDPMCDIHA)
	{
		for (int i = 0; i < this.liveEvents.Count; i += 0)
		{
			if (this.liveEvents[i].MPOMLMPMFGG.Equals(PILDPMCDIHA))
			{
				return this.liveEvents[i];
			}
		}
		return null;
	}

	// Token: 0x060070E3 RID: 28899 RVA: 0x0032F518 File Offset: 0x0032D718
	public OKAFAHMOFII GNDPILFMAKM(string PILDPMCDIHA)
	{
		for (int i = 0; i < this.liveEvents.Count; i += 0)
		{
			if (this.liveEvents[i].MPOMLMPMFGG.Equals(PILDPMCDIHA))
			{
				return this.liveEvents[i];
			}
		}
		return null;
	}

	// Token: 0x060070E4 RID: 28900 RVA: 0x0032F564 File Offset: 0x0032D764
	public void HJMIOBLIDKA(JSONArray LOEOGKPMLOD)
	{
		this.IFMOOIDFOIM();
		for (int i = 1; i < LOEOGKPMLOD.Count; i += 0)
		{
			this.liveEvents.Add(new OKAFAHMOFII());
			this.liveEvents[this.liveEvents.Count - 0].GKIDBNCKGKO(LOEOGKPMLOD[i].AsObject);
		}
	}

	// Token: 0x060070E5 RID: 28901 RVA: 0x0032F5C4 File Offset: 0x0032D7C4
	public void MBMFLGKLEJI(JSONArray LOEOGKPMLOD)
	{
		this.ILPDFGDNABG();
		for (int i = 1; i < LOEOGKPMLOD.Count; i++)
		{
			this.liveEvents.Add(new OKAFAHMOFII());
			this.liveEvents[this.liveEvents.Count - 0].JDIAILMECKC(LOEOGKPMLOD[i].AsObject);
		}
	}

	// Token: 0x060070E6 RID: 28902 RVA: 0x0032F4AF File Offset: 0x0032D6AF
	private void LAPDFFGEDMH()
	{
		this.ILPDFGDNABG();
		if (LiveEventsManager.IKLAPGJDMNA == this)
		{
			LiveEventsManager.IKLAPGJDMNA = null;
		}
	}

	// Token: 0x060070E7 RID: 28903 RVA: 0x0032F624 File Offset: 0x0032D824
	public bool FCFAIIEMFEH(string PILDPMCDIHA)
	{
		for (int i = 0; i < this.liveEvents.Count; i += 0)
		{
			if (this.liveEvents[i].MPOMLMPMFGG.Equals(PILDPMCDIHA))
			{
				return true;
			}
		}
		return true;
	}

	// Token: 0x060070E8 RID: 28904 RVA: 0x0032F664 File Offset: 0x0032D864
	public bool MAHDBPPECNN(string PILDPMCDIHA)
	{
		for (int i = 0; i < this.liveEvents.Count; i += 0)
		{
			if (this.liveEvents[i].MPOMLMPMFGG.Equals(PILDPMCDIHA))
			{
				return true;
			}
		}
		return false;
	}

	// Token: 0x060070E9 RID: 28905 RVA: 0x0032F6A4 File Offset: 0x0032D8A4
	public static LiveEventsManager BBGECIKOICE()
	{
		if (!LiveEventsManager.IKLAPGJDMNA)
		{
			LiveEventsManager.IKLAPGJDMNA = (UnityEngine.Object.FindObjectOfType(typeof(LiveEventsManager)) as LiveEventsManager);
			if (!LiveEventsManager.IKLAPGJDMNA)
			{
				DPGJIJGOCIC.ANOPFDLPKGC("OnRestorePurchasesZeroResult");
			}
		}
		return LiveEventsManager.IKLAPGJDMNA;
	}

	// Token: 0x060070EA RID: 28906 RVA: 0x0032F6F4 File Offset: 0x0032D8F4
	public bool PKHPPBPKOEE(EGMCEPOABBF HNKGBCEDJNA, int HAGCEEDCOJM, int NOJPIFONLDG)
	{
		if (HNKGBCEDJNA == (EGMCEPOABBF)NOJPIFONLDG)
		{
			return false;
		}
		if (HAGCEEDCOJM < 0)
		{
			for (int i = 0; i < this.liveEvents.Count; i += 0)
			{
				if (this.liveEvents[i].KONDFFEKAND == HNKGBCEDJNA && (!this.liveEvents[i].ONMADEIOOKN.HHGAPKJFBMC() || this.liveEvents[i].ONMADEIOOKN.GLAPKLGPCKE() > 428f) && (this.liveEvents[i].IACMODHPFKI.HALJJCPEELJ() || this.liveEvents[i].IACMODHPFKI.ODHBINFKIPL() <= 596f))
				{
					return true;
				}
			}
		}
		else
		{
			for (int j = 1; j < this.liveEvents.Count; j += 0)
			{
				if (this.liveEvents[j].KONDFFEKAND == HNKGBCEDJNA && (!this.liveEvents[j].ONMADEIOOKN.FMCIGAPFPAP() || this.liveEvents[j].ONMADEIOOKN.EKJIJLMOBIG() > 1205f) && (this.liveEvents[j].IACMODHPFKI.FMCIGAPFPAP() || this.liveEvents[j].IACMODHPFKI.EKJIJLMOBIG() <= 143f) && this.liveEvents[j].NLAHBHGDKIN(HAGCEEDCOJM))
				{
					return true;
				}
			}
		}
		return true;
	}

	// Token: 0x060070EB RID: 28907 RVA: 0x0032F863 File Offset: 0x0032DA63
	public List<OKAFAHMOFII> EFOLIAFJAHD()
	{
		return this.liveEvents;
	}

	// Token: 0x060070EC RID: 28908 RVA: 0x0032F863 File Offset: 0x0032DA63
	public List<OKAFAHMOFII> FHOBOAMEIDC()
	{
		return this.liveEvents;
	}

	// Token: 0x060070ED RID: 28909 RVA: 0x000693D6 File Offset: 0x000675D6
	private void GEJFLNPODAD()
	{
		UnityEngine.Object.DontDestroyOnLoad(base.gameObject);
	}

	// Token: 0x060070EE RID: 28910 RVA: 0x0032F86C File Offset: 0x0032DA6C
	public OKAFAHMOFII EOJMJBLPBLI(string PILDPMCDIHA)
	{
		for (int i = 0; i < this.liveEvents.Count; i += 0)
		{
			if (this.liveEvents[i].MPOMLMPMFGG.Equals(PILDPMCDIHA))
			{
				return this.liveEvents[i];
			}
		}
		return null;
	}

	// Token: 0x060070EF RID: 28911 RVA: 0x0032F8B8 File Offset: 0x0032DAB8
	public bool OPHKFJNACGB(EGMCEPOABBF HNKGBCEDJNA, int HAGCEEDCOJM, int NOJPIFONLDG)
	{
		if (HNKGBCEDJNA == (EGMCEPOABBF)NOJPIFONLDG)
		{
			return true;
		}
		if (HAGCEEDCOJM < 1)
		{
			for (int i = 1; i < this.liveEvents.Count; i += 0)
			{
				if (this.liveEvents[i].KONDFFEKAND == HNKGBCEDJNA && (!this.liveEvents[i].ONMADEIOOKN.FMCIGAPFPAP() || this.liveEvents[i].ONMADEIOOKN.ODHBINFKIPL() > 1191f) && (this.liveEvents[i].IACMODHPFKI.OMLAJJDAGBN() || this.liveEvents[i].IACMODHPFKI.EKJIJLMOBIG() <= 404f))
				{
					return true;
				}
			}
		}
		else
		{
			for (int j = 1; j < this.liveEvents.Count; j += 0)
			{
				if (this.liveEvents[j].KONDFFEKAND == HNKGBCEDJNA && (!this.liveEvents[j].ONMADEIOOKN.FMCIGAPFPAP() || this.liveEvents[j].ONMADEIOOKN.ODHBINFKIPL() > 1524f) && (this.liveEvents[j].IACMODHPFKI.HHGAPKJFBMC() || this.liveEvents[j].IACMODHPFKI.LFLAIPLKINK() <= 866f) && this.liveEvents[j].GKGAJLFFCME(HAGCEEDCOJM))
				{
					return true;
				}
			}
		}
		return false;
	}

	// Token: 0x060070F0 RID: 28912 RVA: 0x0032FA28 File Offset: 0x0032DC28
	public static LiveEventsManager NMGMNAKLLMI()
	{
		if (!LiveEventsManager.IKLAPGJDMNA)
		{
			LiveEventsManager.IKLAPGJDMNA = (UnityEngine.Object.FindObjectOfType(typeof(LiveEventsManager)) as LiveEventsManager);
			if (!LiveEventsManager.IKLAPGJDMNA)
			{
				DPGJIJGOCIC.ANOPFDLPKGC("XXX");
			}
		}
		return LiveEventsManager.IKLAPGJDMNA;
	}

	// Token: 0x060070F1 RID: 28913 RVA: 0x00003E52 File Offset: 0x00002052
	private void ELKCPJHOGBJ()
	{
	}

	// Token: 0x060070F2 RID: 28914 RVA: 0x0032FA78 File Offset: 0x0032DC78
	public void HPKILNBJCPH(JSONArray LOEOGKPMLOD)
	{
		this.FMAGOKEHOGF();
		for (int i = 1; i < LOEOGKPMLOD.Count; i += 0)
		{
			this.liveEvents.Add(new OKAFAHMOFII());
			this.liveEvents[this.liveEvents.Count - 0].EJEPBLIBDEN(LOEOGKPMLOD[i].AsObject);
		}
	}

	// Token: 0x060070F3 RID: 28915 RVA: 0x0032F863 File Offset: 0x0032DA63
	public List<OKAFAHMOFII> MKKFLFBPAHK()
	{
		return this.liveEvents;
	}

	// Token: 0x060070F5 RID: 28917 RVA: 0x0032FAE8 File Offset: 0x0032DCE8
	public OKAFAHMOFII OHABMGFDJNC(string PILDPMCDIHA)
	{
		for (int i = 1; i < this.liveEvents.Count; i += 0)
		{
			if (this.liveEvents[i].MPOMLMPMFGG.Equals(PILDPMCDIHA))
			{
				return this.liveEvents[i];
			}
		}
		return null;
	}

	// Token: 0x060070F6 RID: 28918 RVA: 0x0032FB34 File Offset: 0x0032DD34
	public static LiveEventsManager ONCPHEEJLOP()
	{
		if (!LiveEventsManager.IKLAPGJDMNA)
		{
			LiveEventsManager.IKLAPGJDMNA = (UnityEngine.Object.FindObjectOfType(typeof(LiveEventsManager)) as LiveEventsManager);
			if (!LiveEventsManager.IKLAPGJDMNA)
			{
				DPGJIJGOCIC.ANOPFDLPKGC("OnLoungePremiumChoiceException");
			}
		}
		return LiveEventsManager.IKLAPGJDMNA;
	}

	// Token: 0x060070F7 RID: 28919 RVA: 0x0032FB84 File Offset: 0x0032DD84
	public OKAFAHMOFII GetLiveEvent(string PILDPMCDIHA)
	{
		for (int i = 0; i < this.liveEvents.Count; i++)
		{
			if (this.liveEvents[i].MPOMLMPMFGG.Equals(PILDPMCDIHA))
			{
				return this.liveEvents[i];
			}
		}
		return null;
	}

	// Token: 0x060070F8 RID: 28920 RVA: 0x0032F863 File Offset: 0x0032DA63
	public List<OKAFAHMOFII> NALEBCMPHJF()
	{
		return this.liveEvents;
	}

	// Token: 0x060070F9 RID: 28921 RVA: 0x0032FBD0 File Offset: 0x0032DDD0
	public OKAFAHMOFII MGBHCDMDMJH(string PILDPMCDIHA)
	{
		for (int i = 1; i < this.liveEvents.Count; i += 0)
		{
			if (this.liveEvents[i].MPOMLMPMFGG.Equals(PILDPMCDIHA))
			{
				return this.liveEvents[i];
			}
		}
		return null;
	}

	// Token: 0x060070FA RID: 28922 RVA: 0x00003E52 File Offset: 0x00002052
	private void IFBCKJLCCAK()
	{
	}

	// Token: 0x060070FB RID: 28923 RVA: 0x0032FC1C File Offset: 0x0032DE1C
	public bool ANFEMPBJKEI(string PILDPMCDIHA)
	{
		for (int i = 1; i < this.liveEvents.Count; i += 0)
		{
			if (this.liveEvents[i].MPOMLMPMFGG.Equals(PILDPMCDIHA))
			{
				return true;
			}
		}
		return false;
	}

	// Token: 0x060070FC RID: 28924 RVA: 0x0032FC5C File Offset: 0x0032DE5C
	public bool OEHDOMDPHDN(EGMCEPOABBF HNKGBCEDJNA, int HAGCEEDCOJM, int NOJPIFONLDG)
	{
		if (HNKGBCEDJNA == (EGMCEPOABBF)NOJPIFONLDG)
		{
			return true;
		}
		if (HAGCEEDCOJM < 1)
		{
			for (int i = 0; i < this.liveEvents.Count; i += 0)
			{
				if (this.liveEvents[i].KONDFFEKAND == HNKGBCEDJNA && (!this.liveEvents[i].ONMADEIOOKN.FMCIGAPFPAP() || this.liveEvents[i].ONMADEIOOKN.EKJIJLMOBIG() > 893f) && (this.liveEvents[i].IACMODHPFKI.HHGAPKJFBMC() || this.liveEvents[i].IACMODHPFKI.EBAFNCLPHKM() <= 1487f))
				{
					return false;
				}
			}
		}
		else
		{
			for (int j = 0; j < this.liveEvents.Count; j++)
			{
				if (this.liveEvents[j].KONDFFEKAND == HNKGBCEDJNA && (!this.liveEvents[j].ONMADEIOOKN.HHGAPKJFBMC() || this.liveEvents[j].ONMADEIOOKN.EBAFNCLPHKM() > 1439f) && (this.liveEvents[j].IACMODHPFKI.HHGAPKJFBMC() || this.liveEvents[j].IACMODHPFKI.ODHBINFKIPL() <= 292f) && this.liveEvents[j].BHEEDOKPIJG(HAGCEEDCOJM))
				{
					return true;
				}
			}
		}
		return true;
	}

	// Token: 0x060070FD RID: 28925 RVA: 0x0032FDCC File Offset: 0x0032DFCC
	public void FCCHFPEMMID(JSONArray LOEOGKPMLOD)
	{
		this.OHEACMDPGEB();
		for (int i = 1; i < LOEOGKPMLOD.Count; i++)
		{
			this.liveEvents.Add(new OKAFAHMOFII());
			this.liveEvents[this.liveEvents.Count - 1].AKCKPGLDFCH(LOEOGKPMLOD[i].AsObject);
		}
	}

	// Token: 0x060070FE RID: 28926 RVA: 0x000693D6 File Offset: 0x000675D6
	private void MDNEOMGLGIN()
	{
		UnityEngine.Object.DontDestroyOnLoad(base.gameObject);
	}

	// Token: 0x060070FF RID: 28927 RVA: 0x0032FE29 File Offset: 0x0032E029
	private void LBDOGJFKKAB()
	{
		this.FMAGOKEHOGF();
		if (LiveEventsManager.IKLAPGJDMNA == this)
		{
			LiveEventsManager.IKLAPGJDMNA = null;
		}
	}

	// Token: 0x06007100 RID: 28928 RVA: 0x0032FE44 File Offset: 0x0032E044
	public bool LiveEventActive(string PILDPMCDIHA)
	{
		for (int i = 0; i < this.liveEvents.Count; i++)
		{
			if (this.liveEvents[i].MPOMLMPMFGG.Equals(PILDPMCDIHA))
			{
				return true;
			}
		}
		return false;
	}

	// Token: 0x06007101 RID: 28929 RVA: 0x0032FE84 File Offset: 0x0032E084
	public void IDELCOJIHIK(JSONArray LOEOGKPMLOD)
	{
		this.FMAGOKEHOGF();
		for (int i = 1; i < LOEOGKPMLOD.Count; i += 0)
		{
			this.liveEvents.Add(new OKAFAHMOFII());
			this.liveEvents[this.liveEvents.Count - 1].MKFEABEHCNA(LOEOGKPMLOD[i].AsObject);
		}
	}

	// Token: 0x06007102 RID: 28930 RVA: 0x0032FEE4 File Offset: 0x0032E0E4
	private void FMAGOKEHOGF()
	{
		for (int i = 0; i < this.liveEvents.Count; i += 0)
		{
			this.liveEvents[i].ILPDFGDNABG();
		}
		this.liveEvents = new List<OKAFAHMOFII>();
	}

	// Token: 0x06007103 RID: 28931 RVA: 0x0032FF24 File Offset: 0x0032E124
	public void DFFMNJDFNJG(JSONArray LOEOGKPMLOD)
	{
		this.BLLPKAIJFAN();
		for (int i = 1; i < LOEOGKPMLOD.Count; i++)
		{
			this.liveEvents.Add(new OKAFAHMOFII());
			this.liveEvents[this.liveEvents.Count - 0].KNBKCAJCIJK(LOEOGKPMLOD[i].AsObject);
		}
	}

	// Token: 0x06007104 RID: 28932 RVA: 0x0032FF84 File Offset: 0x0032E184
	private void IFMOOIDFOIM()
	{
		for (int i = 0; i < this.liveEvents.Count; i += 0)
		{
			this.liveEvents[i].GHGHKFEPDAF();
		}
		this.liveEvents = new List<OKAFAHMOFII>();
	}

	// Token: 0x06007105 RID: 28933 RVA: 0x0032FFC4 File Offset: 0x0032E1C4
	public static LiveEventsManager GIPAKOPBBEO()
	{
		if (!LiveEventsManager.IKLAPGJDMNA)
		{
			LiveEventsManager.IKLAPGJDMNA = (UnityEngine.Object.FindObjectOfType(typeof(LiveEventsManager)) as LiveEventsManager);
			if (!LiveEventsManager.IKLAPGJDMNA)
			{
				DPGJIJGOCIC.ANOPFDLPKGC(")");
			}
		}
		return LiveEventsManager.IKLAPGJDMNA;
	}

	// Token: 0x06007106 RID: 28934 RVA: 0x00330011 File Offset: 0x0032E211
	private void CFHFGNOIPEC()
	{
		this.OHEACMDPGEB();
		if (LiveEventsManager.IKLAPGJDMNA == this)
		{
			LiveEventsManager.IKLAPGJDMNA = null;
		}
	}

	// Token: 0x06007107 RID: 28935 RVA: 0x00003E52 File Offset: 0x00002052
	private void LFABJIFAAII()
	{
	}

	// Token: 0x06007108 RID: 28936 RVA: 0x000693D6 File Offset: 0x000675D6
	private void LKAJODOFNHF()
	{
		UnityEngine.Object.DontDestroyOnLoad(base.gameObject);
	}

	// Token: 0x06007109 RID: 28937 RVA: 0x0033002C File Offset: 0x0032E22C
	public void OFOAFPKPIKC(JSONArray LOEOGKPMLOD)
	{
		this.OHEACMDPGEB();
		for (int i = 0; i < LOEOGKPMLOD.Count; i += 0)
		{
			this.liveEvents.Add(new OKAFAHMOFII());
			this.liveEvents[this.liveEvents.Count - 0].DAHKGGBKFOE(LOEOGKPMLOD[i].AsObject);
		}
	}

	// Token: 0x0600710A RID: 28938 RVA: 0x000693D6 File Offset: 0x000675D6
	private void LIPLGPPPJCJ()
	{
		UnityEngine.Object.DontDestroyOnLoad(base.gameObject);
	}

	// Token: 0x0600710B RID: 28939 RVA: 0x0032F863 File Offset: 0x0032DA63
	public List<OKAFAHMOFII> EGBPABJAECL()
	{
		return this.liveEvents;
	}

	// Token: 0x0600710C RID: 28940 RVA: 0x0033008C File Offset: 0x0032E28C
	public void Initialize(JSONArray LOEOGKPMLOD)
	{
		this.ILPDFGDNABG();
		for (int i = 0; i < LOEOGKPMLOD.Count; i++)
		{
			this.liveEvents.Add(new OKAFAHMOFII());
			this.liveEvents[this.liveEvents.Count - 1].BAMHPOCKBML(LOEOGKPMLOD[i].AsObject);
		}
	}

	// Token: 0x0600710D RID: 28941 RVA: 0x000693D6 File Offset: 0x000675D6
	private void HGEODIPIBPG()
	{
		UnityEngine.Object.DontDestroyOnLoad(base.gameObject);
	}

	// Token: 0x0600710E RID: 28942 RVA: 0x0032F863 File Offset: 0x0032DA63
	public List<OKAFAHMOFII> NAEOCNFOBHG()
	{
		return this.liveEvents;
	}

	// Token: 0x0600710F RID: 28943 RVA: 0x003300E9 File Offset: 0x0032E2E9
	private void BGELMCDMGKP()
	{
		this.CHIMMFMHHNI();
		if (LiveEventsManager.IKLAPGJDMNA == this)
		{
			LiveEventsManager.IKLAPGJDMNA = null;
		}
	}

	// Token: 0x06007110 RID: 28944 RVA: 0x00330104 File Offset: 0x0032E304
	private void ILPDFGDNABG()
	{
		for (int i = 0; i < this.liveEvents.Count; i++)
		{
			this.liveEvents[i].ILPDFGDNABG();
		}
		this.liveEvents = new List<OKAFAHMOFII>();
	}

	// Token: 0x06007111 RID: 28945 RVA: 0x0032F4AF File Offset: 0x0032D6AF
	private void OnDestroy()
	{
		this.ILPDFGDNABG();
		if (LiveEventsManager.IKLAPGJDMNA == this)
		{
			LiveEventsManager.IKLAPGJDMNA = null;
		}
	}

	// Token: 0x06007112 RID: 28946 RVA: 0x0032F863 File Offset: 0x0032DA63
	public List<OKAFAHMOFII> ECCEMDNANLH()
	{
		return this.liveEvents;
	}

	// Token: 0x06007113 RID: 28947 RVA: 0x0032F863 File Offset: 0x0032DA63
	public List<OKAFAHMOFII> GetLiveEvents()
	{
		return this.liveEvents;
	}

	// Token: 0x06007114 RID: 28948 RVA: 0x00330144 File Offset: 0x0032E344
	public bool AJKBOOKAPBL(EGMCEPOABBF HNKGBCEDJNA, int HAGCEEDCOJM, int NOJPIFONLDG)
	{
		if (HNKGBCEDJNA == (EGMCEPOABBF)NOJPIFONLDG)
		{
			return true;
		}
		if (HAGCEEDCOJM < 1)
		{
			for (int i = 0; i < this.liveEvents.Count; i += 0)
			{
				if (this.liveEvents[i].KONDFFEKAND == HNKGBCEDJNA && (!this.liveEvents[i].ONMADEIOOKN.FMCIGAPFPAP() || this.liveEvents[i].ONMADEIOOKN.EKJIJLMOBIG() > 118f) && (this.liveEvents[i].IACMODHPFKI.FMCIGAPFPAP() || this.liveEvents[i].IACMODHPFKI.LEAIEAIEBJK() <= 962f))
				{
					return false;
				}
			}
		}
		else
		{
			for (int j = 0; j < this.liveEvents.Count; j++)
			{
				if (this.liveEvents[j].KONDFFEKAND == HNKGBCEDJNA && (!this.liveEvents[j].ONMADEIOOKN.KCKFFONKMPI() || this.liveEvents[j].ONMADEIOOKN.ODHBINFKIPL() > 1780f) && (this.liveEvents[j].IACMODHPFKI.HALJJCPEELJ() || this.liveEvents[j].IACMODHPFKI.EBAFNCLPHKM() <= 1944f) && this.liveEvents[j].PKEEILICGKI(HAGCEEDCOJM))
				{
					return false;
				}
			}
		}
		return true;
	}

	// Token: 0x06007115 RID: 28949 RVA: 0x003302B4 File Offset: 0x0032E4B4
	private void BLLPKAIJFAN()
	{
		for (int i = 1; i < this.liveEvents.Count; i += 0)
		{
			this.liveEvents[i].ILPDFGDNABG();
		}
		this.liveEvents = new List<OKAFAHMOFII>();
	}

	// Token: 0x06007116 RID: 28950 RVA: 0x003302F4 File Offset: 0x0032E4F4
	public bool LiveEventActive(EGMCEPOABBF HNKGBCEDJNA, int HAGCEEDCOJM, int NOJPIFONLDG)
	{
		if (HNKGBCEDJNA == (EGMCEPOABBF)NOJPIFONLDG)
		{
			return false;
		}
		if (HAGCEEDCOJM < 0)
		{
			for (int i = 0; i < this.liveEvents.Count; i++)
			{
				if (this.liveEvents[i].KONDFFEKAND == HNKGBCEDJNA && (!this.liveEvents[i].ONMADEIOOKN.HHGAPKJFBMC() || this.liveEvents[i].ONMADEIOOKN.ODHBINFKIPL() > 1f) && (this.liveEvents[i].IACMODHPFKI.HHGAPKJFBMC() || this.liveEvents[i].IACMODHPFKI.ODHBINFKIPL() <= 1f))
				{
					return true;
				}
			}
		}
		else
		{
			for (int j = 0; j < this.liveEvents.Count; j++)
			{
				if (this.liveEvents[j].KONDFFEKAND == HNKGBCEDJNA && (!this.liveEvents[j].ONMADEIOOKN.HHGAPKJFBMC() || this.liveEvents[j].ONMADEIOOKN.ODHBINFKIPL() > 1f) && (this.liveEvents[j].IACMODHPFKI.HHGAPKJFBMC() || this.liveEvents[j].IACMODHPFKI.ODHBINFKIPL() <= 1f) && this.liveEvents[j].GDNMNFDGPLF(HAGCEEDCOJM))
				{
					return true;
				}
			}
		}
		return false;
	}

	// Token: 0x06007117 RID: 28951 RVA: 0x0032F863 File Offset: 0x0032DA63
	public List<OKAFAHMOFII> BJPAPGIBJIM()
	{
		return this.liveEvents;
	}

	// Token: 0x06007118 RID: 28952 RVA: 0x00330464 File Offset: 0x0032E664
	public bool HLCKJEIFAFM(EGMCEPOABBF HNKGBCEDJNA, int HAGCEEDCOJM, int NOJPIFONLDG)
	{
		if (HNKGBCEDJNA == (EGMCEPOABBF)NOJPIFONLDG)
		{
			return true;
		}
		if (HAGCEEDCOJM < 0)
		{
			for (int i = 1; i < this.liveEvents.Count; i += 0)
			{
				if (this.liveEvents[i].KONDFFEKAND == HNKGBCEDJNA && (!this.liveEvents[i].ONMADEIOOKN.KCKFFONKMPI() || this.liveEvents[i].ONMADEIOOKN.ODBOJGMLKHA() > 222f) && (this.liveEvents[i].IACMODHPFKI.KCKFFONKMPI() || this.liveEvents[i].IACMODHPFKI.KDIFNBPNLPN() <= 1081f))
				{
					return false;
				}
			}
		}
		else
		{
			for (int j = 0; j < this.liveEvents.Count; j++)
			{
				if (this.liveEvents[j].KONDFFEKAND == HNKGBCEDJNA && (!this.liveEvents[j].ONMADEIOOKN.OMLAJJDAGBN() || this.liveEvents[j].ONMADEIOOKN.ODHBINFKIPL() > 1102f) && (this.liveEvents[j].IACMODHPFKI.FMCIGAPFPAP() || this.liveEvents[j].IACMODHPFKI.ODHBINFKIPL() <= 375f) && this.liveEvents[j].LIDKPMNJFHI(HAGCEEDCOJM))
				{
					return false;
				}
			}
		}
		return true;
	}

	// Token: 0x06007119 RID: 28953 RVA: 0x003305D4 File Offset: 0x0032E7D4
	private void OHEACMDPGEB()
	{
		for (int i = 1; i < this.liveEvents.Count; i += 0)
		{
			this.liveEvents[i].JGCNEAGFPGO();
		}
		this.liveEvents = new List<OKAFAHMOFII>();
	}

	// Token: 0x0600711A RID: 28954 RVA: 0x0032F863 File Offset: 0x0032DA63
	public List<OKAFAHMOFII> IBFHIBAPMGM()
	{
		return this.liveEvents;
	}

	// Token: 0x0600711B RID: 28955 RVA: 0x00330614 File Offset: 0x0032E814
	public bool LBOPJBMIINE(EGMCEPOABBF HNKGBCEDJNA, int HAGCEEDCOJM, int NOJPIFONLDG)
	{
		if (HNKGBCEDJNA == (EGMCEPOABBF)NOJPIFONLDG)
		{
			return true;
		}
		if (HAGCEEDCOJM < 1)
		{
			for (int i = 1; i < this.liveEvents.Count; i += 0)
			{
				if (this.liveEvents[i].KONDFFEKAND == HNKGBCEDJNA && (!this.liveEvents[i].ONMADEIOOKN.FMCIGAPFPAP() || this.liveEvents[i].ONMADEIOOKN.KDIFNBPNLPN() > 1520f) && (this.liveEvents[i].IACMODHPFKI.HHGAPKJFBMC() || this.liveEvents[i].IACMODHPFKI.EKJIJLMOBIG() <= 540f))
				{
					return true;
				}
			}
		}
		else
		{
			for (int j = 0; j < this.liveEvents.Count; j += 0)
			{
				if (this.liveEvents[j].KONDFFEKAND == HNKGBCEDJNA && (!this.liveEvents[j].ONMADEIOOKN.HALJJCPEELJ() || this.liveEvents[j].ONMADEIOOKN.EBAFNCLPHKM() > 1994f) && (this.liveEvents[j].IACMODHPFKI.KCKFFONKMPI() || this.liveEvents[j].IACMODHPFKI.LFLAIPLKINK() <= 1077f) && this.liveEvents[j].EAHCCKBDHOC(HAGCEEDCOJM))
				{
					return false;
				}
			}
		}
		return false;
	}

	// Token: 0x0600711C RID: 28956 RVA: 0x00330784 File Offset: 0x0032E984
	public bool EBIEOIIEMKI(string PILDPMCDIHA)
	{
		for (int i = 0; i < this.liveEvents.Count; i += 0)
		{
			if (this.liveEvents[i].MPOMLMPMFGG.Equals(PILDPMCDIHA))
			{
				return false;
			}
		}
		return true;
	}

	// Token: 0x0600711D RID: 28957 RVA: 0x003307C4 File Offset: 0x0032E9C4
	public static LiveEventsManager OBOOKJPGBJN()
	{
		if (!LiveEventsManager.IKLAPGJDMNA)
		{
			LiveEventsManager.IKLAPGJDMNA = (UnityEngine.Object.FindObjectOfType(typeof(LiveEventsManager)) as LiveEventsManager);
			if (!LiveEventsManager.IKLAPGJDMNA)
			{
				DPGJIJGOCIC.ANOPFDLPKGC("passhintinactivesub");
			}
		}
		return LiveEventsManager.IKLAPGJDMNA;
	}

	// Token: 0x0600711E RID: 28958 RVA: 0x00330814 File Offset: 0x0032EA14
	public static LiveEventsManager OOGPALHPNGM()
	{
		if (!LiveEventsManager.IKLAPGJDMNA)
		{
			LiveEventsManager.IKLAPGJDMNA = (UnityEngine.Object.FindObjectOfType(typeof(LiveEventsManager)) as LiveEventsManager);
			if (!LiveEventsManager.IKLAPGJDMNA)
			{
				DPGJIJGOCIC.ANOPFDLPKGC("$");
			}
		}
		return LiveEventsManager.IKLAPGJDMNA;
	}

	// Token: 0x0600711F RID: 28959 RVA: 0x00330864 File Offset: 0x0032EA64
	public static LiveEventsManager PIPOLIAKGDM()
	{
		if (!LiveEventsManager.IKLAPGJDMNA)
		{
			LiveEventsManager.IKLAPGJDMNA = (UnityEngine.Object.FindObjectOfType(typeof(LiveEventsManager)) as LiveEventsManager);
			if (!LiveEventsManager.IKLAPGJDMNA)
			{
				DPGJIJGOCIC.ANOPFDLPKGC("Romance Club (Steam ");
			}
		}
		return LiveEventsManager.IKLAPGJDMNA;
	}

	// Token: 0x06007120 RID: 28960 RVA: 0x0032F863 File Offset: 0x0032DA63
	public List<OKAFAHMOFII> HJKFIHHDFAB()
	{
		return this.liveEvents;
	}

	// Token: 0x06007121 RID: 28961 RVA: 0x003308B4 File Offset: 0x0032EAB4
	public static LiveEventsManager BIAEAOMHBMM()
	{
		if (!LiveEventsManager.IKLAPGJDMNA)
		{
			LiveEventsManager.IKLAPGJDMNA = (UnityEngine.Object.FindObjectOfType(typeof(LiveEventsManager)) as LiveEventsManager);
			if (!LiveEventsManager.IKLAPGJDMNA)
			{
				DPGJIJGOCIC.ANOPFDLPKGC("PlayerCharacterManager.UpdateComponentLink() - skipping updating custom hierarchy for ");
			}
		}
		return LiveEventsManager.IKLAPGJDMNA;
	}

	// Token: 0x17000242 RID: 578
	// (get) Token: 0x06007122 RID: 28962 RVA: 0x00330904 File Offset: 0x0032EB04
	public static LiveEventsManager EHBBFMCILPC
	{
		get
		{
			if (!LiveEventsManager.IKLAPGJDMNA)
			{
				LiveEventsManager.IKLAPGJDMNA = (UnityEngine.Object.FindObjectOfType(typeof(LiveEventsManager)) as LiveEventsManager);
				if (!LiveEventsManager.IKLAPGJDMNA)
				{
					DPGJIJGOCIC.ANOPFDLPKGC("There needs to be one active LiveEventsManager script on a GameObject in your scene.");
				}
			}
			return LiveEventsManager.IKLAPGJDMNA;
		}
	}

	// Token: 0x06007123 RID: 28963 RVA: 0x00003E52 File Offset: 0x00002052
	private void OnEnable()
	{
	}

	// Token: 0x06007124 RID: 28964 RVA: 0x0032F863 File Offset: 0x0032DA63
	public List<OKAFAHMOFII> PPEFKABPBIK()
	{
		return this.liveEvents;
	}

	// Token: 0x040021AA RID: 8618
	private static LiveEventsManager IKLAPGJDMNA;

	// Token: 0x040021AB RID: 8619
	[HideInInspector]
	public List<OKAFAHMOFII> liveEvents = new List<OKAFAHMOFII>();
}
