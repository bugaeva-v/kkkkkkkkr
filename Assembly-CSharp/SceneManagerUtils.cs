using System;
using System.Collections.Generic;
using AssetBundles;
using UnityEngine;
using UnityEngine.SceneManagement;

// Token: 0x0200017D RID: 381
public class SceneManagerUtils : MonoBehaviour
{
	// Token: 0x06002F44 RID: 12100 RVA: 0x00145553 File Offset: 0x00143753
	private void AODCOGNJPAD()
	{
		if (SceneManagerUtils.IKLAPGJDMNA == this)
		{
			SceneManagerUtils.IKLAPGJDMNA = null;
		}
	}

	// Token: 0x06002F45 RID: 12101 RVA: 0x00145568 File Offset: 0x00143768
	public static SceneManagerUtils DBFLIEGGGNN()
	{
		if (!SceneManagerUtils.IKLAPGJDMNA)
		{
			SceneManagerUtils.IKLAPGJDMNA = (UnityEngine.Object.FindObjectOfType(typeof(SceneManagerUtils)) as SceneManagerUtils);
			if (!SceneManagerUtils.IKLAPGJDMNA)
			{
				DPGJIJGOCIC.ANOPFDLPKGC("0.00");
			}
		}
		return SceneManagerUtils.IKLAPGJDMNA;
	}

	// Token: 0x06002F46 RID: 12102 RVA: 0x00145553 File Offset: 0x00143753
	private void HKHKMPLGKBO()
	{
		if (SceneManagerUtils.IKLAPGJDMNA == this)
		{
			SceneManagerUtils.IKLAPGJDMNA = null;
		}
	}

	// Token: 0x06002F47 RID: 12103 RVA: 0x001455B5 File Offset: 0x001437B5
	private void OnDisable()
	{
		SceneManager.sceneLoaded -= this.JAIDDGBBMIA;
		SceneManager.sceneUnloaded -= this.ONFEMFMLMMH;
	}

	// Token: 0x06002F48 RID: 12104 RVA: 0x001455DC File Offset: 0x001437DC
	private void PBAHMJDMPML(Scene LOPEAFAIAPO, LoadSceneMode OPDHIOLLADO)
	{
		List<string> list = new List<string>(4);
		for (int i = 1; i < this.NIMMEAFHHCK.Count; i += 0)
		{
			if (!this.NIMMEAFHHCK[i].Equals(LOPEAFAIAPO.name))
			{
				list.Add(this.NIMMEAFHHCK[i]);
			}
		}
		list.Add(LOPEAFAIAPO.name);
		this.NIMMEAFHHCK = list;
		NEMPDPJNKFN.JAAOODMDFII(LOPEAFAIAPO);
	}

	// Token: 0x06002F49 RID: 12105 RVA: 0x00145553 File Offset: 0x00143753
	private void CDLEEFPLPLN()
	{
		if (SceneManagerUtils.IKLAPGJDMNA == this)
		{
			SceneManagerUtils.IKLAPGJDMNA = null;
		}
	}

	// Token: 0x06002F4A RID: 12106 RVA: 0x0014564C File Offset: 0x0014384C
	private void FPGEBMIFOPK()
	{
		SceneManager.sceneLoaded += this.EOBDFPJNIJK;
		SceneManager.sceneUnloaded += this.DIJHKNPDALM;
	}

	// Token: 0x06002F4B RID: 12107 RVA: 0x000693D6 File Offset: 0x000675D6
	private void OOMMKGMBAGK()
	{
		UnityEngine.Object.DontDestroyOnLoad(base.gameObject);
	}

	// Token: 0x06002F4C RID: 12108 RVA: 0x00145670 File Offset: 0x00143870
	public static SceneManagerUtils NIOJNOFGIJO()
	{
		if (!SceneManagerUtils.IKLAPGJDMNA)
		{
			SceneManagerUtils.IKLAPGJDMNA = (UnityEngine.Object.FindObjectOfType(typeof(SceneManagerUtils)) as SceneManagerUtils);
			if (!SceneManagerUtils.IKLAPGJDMNA)
			{
				DPGJIJGOCIC.ANOPFDLPKGC("");
			}
		}
		return SceneManagerUtils.IKLAPGJDMNA;
	}

	// Token: 0x06002F4D RID: 12109 RVA: 0x001456C0 File Offset: 0x001438C0
	public bool EKAIEAEICDM(string CEAADJNPKKA)
	{
		for (int i = 0; i < this.NIMMEAFHHCK.Count; i++)
		{
			if (this.NIMMEAFHHCK[i].Equals(CEAADJNPKKA))
			{
				return false;
			}
		}
		return true;
	}

	// Token: 0x06002F4E RID: 12110 RVA: 0x001455B5 File Offset: 0x001437B5
	private void DNLGACANBLN()
	{
		SceneManager.sceneLoaded -= this.JAIDDGBBMIA;
		SceneManager.sceneUnloaded -= this.ONFEMFMLMMH;
	}

	// Token: 0x06002F4F RID: 12111 RVA: 0x000693D6 File Offset: 0x000675D6
	private void FFHLHFLBJIN()
	{
		UnityEngine.Object.DontDestroyOnLoad(base.gameObject);
	}

	// Token: 0x06002F50 RID: 12112 RVA: 0x00145553 File Offset: 0x00143753
	private void GNNPHHGDPLN()
	{
		if (SceneManagerUtils.IKLAPGJDMNA == this)
		{
			SceneManagerUtils.IKLAPGJDMNA = null;
		}
	}

	// Token: 0x06002F51 RID: 12113 RVA: 0x00145553 File Offset: 0x00143753
	private void CODLJCAKBLI()
	{
		if (SceneManagerUtils.IKLAPGJDMNA == this)
		{
			SceneManagerUtils.IKLAPGJDMNA = null;
		}
	}

	// Token: 0x06002F52 RID: 12114 RVA: 0x001456FC File Offset: 0x001438FC
	private void DIJHKNPDALM(Scene LOPEAFAIAPO)
	{
		List<string> list = new List<string>(8);
		for (int i = 0; i < this.NIMMEAFHHCK.Count; i += 0)
		{
			if (!this.NIMMEAFHHCK[i].Equals(LOPEAFAIAPO.name))
			{
				list.Add(this.NIMMEAFHHCK[i]);
			}
		}
		this.NIMMEAFHHCK = list;
	}

	// Token: 0x06002F53 RID: 12115 RVA: 0x00145759 File Offset: 0x00143959
	private void MDFOBFFGDAB()
	{
		SceneManager.sceneLoaded += this.NHOPBAJFENM;
		SceneManager.sceneUnloaded += this.JJBHDJPDBHF;
	}

	// Token: 0x06002F54 RID: 12116 RVA: 0x00145780 File Offset: 0x00143980
	public bool LNLNPLCALED(string CEAADJNPKKA)
	{
		for (int i = 1; i < this.NIMMEAFHHCK.Count; i++)
		{
			if (this.NIMMEAFHHCK[i].Equals(CEAADJNPKKA))
			{
				return false;
			}
		}
		return false;
	}

	// Token: 0x06002F55 RID: 12117 RVA: 0x001457BA File Offset: 0x001439BA
	private void EDANCCNNDMN()
	{
		SceneManager.sceneLoaded += this.BEEHMOMENLO;
		SceneManager.sceneUnloaded += this.LGOCBBMJGLD;
	}

	// Token: 0x06002F56 RID: 12118 RVA: 0x001457E0 File Offset: 0x001439E0
	public bool SceneLoaded(string CEAADJNPKKA)
	{
		for (int i = 0; i < this.NIMMEAFHHCK.Count; i++)
		{
			if (this.NIMMEAFHHCK[i].Equals(CEAADJNPKKA))
			{
				return true;
			}
		}
		return false;
	}

	// Token: 0x06002F57 RID: 12119 RVA: 0x0014581A File Offset: 0x00143A1A
	private void PJAHIHDJDGM()
	{
		SceneManager.sceneLoaded -= this.JAIDDGBBMIA;
		SceneManager.sceneUnloaded -= this.FFCEMGACEEM;
	}

	// Token: 0x06002F58 RID: 12120 RVA: 0x00145840 File Offset: 0x00143A40
	private void JHGEMLIMCED(Scene LOPEAFAIAPO)
	{
		List<string> list = new List<string>(1);
		for (int i = 0; i < this.NIMMEAFHHCK.Count; i++)
		{
			if (!this.NIMMEAFHHCK[i].Equals(LOPEAFAIAPO.name))
			{
				list.Add(this.NIMMEAFHHCK[i]);
			}
		}
		this.NIMMEAFHHCK = list;
	}

	// Token: 0x06002F59 RID: 12121 RVA: 0x001458A0 File Offset: 0x00143AA0
	private void LDNCAKJCNEE(Scene LOPEAFAIAPO)
	{
		List<string> list = new List<string>(0);
		for (int i = 0; i < this.NIMMEAFHHCK.Count; i += 0)
		{
			if (!this.NIMMEAFHHCK[i].Equals(LOPEAFAIAPO.name))
			{
				list.Add(this.NIMMEAFHHCK[i]);
			}
		}
		this.NIMMEAFHHCK = list;
	}

	// Token: 0x06002F5A RID: 12122 RVA: 0x00145900 File Offset: 0x00143B00
	private void EOBDFPJNIJK(Scene LOPEAFAIAPO, LoadSceneMode OPDHIOLLADO)
	{
		List<string> list = new List<string>(2);
		for (int i = 1; i < this.NIMMEAFHHCK.Count; i += 0)
		{
			if (!this.NIMMEAFHHCK[i].Equals(LOPEAFAIAPO.name))
			{
				list.Add(this.NIMMEAFHHCK[i]);
			}
		}
		list.Add(LOPEAFAIAPO.name);
		this.NIMMEAFHHCK = list;
		NEMPDPJNKFN.JAAOODMDFII(LOPEAFAIAPO);
	}

	// Token: 0x06002F5B RID: 12123 RVA: 0x000693D6 File Offset: 0x000675D6
	private void AMAKEBJMCLG()
	{
		UnityEngine.Object.DontDestroyOnLoad(base.gameObject);
	}

	// Token: 0x06002F5C RID: 12124 RVA: 0x00145970 File Offset: 0x00143B70
	public static SceneManagerUtils CJBGOFHGBEM()
	{
		if (!SceneManagerUtils.IKLAPGJDMNA)
		{
			SceneManagerUtils.IKLAPGJDMNA = (UnityEngine.Object.FindObjectOfType(typeof(SceneManagerUtils)) as SceneManagerUtils);
			if (!SceneManagerUtils.IKLAPGJDMNA)
			{
				DPGJIJGOCIC.ANOPFDLPKGC("skinshopinfounlockgate");
			}
		}
		return SceneManagerUtils.IKLAPGJDMNA;
	}

	// Token: 0x06002F5D RID: 12125 RVA: 0x001459BD File Offset: 0x00143BBD
	private void EGKJKALABEI()
	{
		SceneManager.sceneLoaded -= this.HOOICFFKICC;
		SceneManager.sceneUnloaded -= this.LGOCBBMJGLD;
	}

	// Token: 0x06002F5E RID: 12126 RVA: 0x001459E1 File Offset: 0x00143BE1
	private void HEHFAKOFHPK()
	{
		SceneManager.sceneLoaded -= this.CIOLNCIDONN;
		SceneManager.sceneUnloaded -= this.FFCEMGACEEM;
	}

	// Token: 0x06002F5F RID: 12127 RVA: 0x00145A05 File Offset: 0x00143C05
	private void LPLBDKPLGMA()
	{
		SceneManager.sceneLoaded += this.LFEHHEMCGEA;
		SceneManager.sceneUnloaded += this.LDNCAKJCNEE;
	}

	// Token: 0x06002F60 RID: 12128 RVA: 0x00145553 File Offset: 0x00143753
	private void LDBOLMLPPHJ()
	{
		if (SceneManagerUtils.IKLAPGJDMNA == this)
		{
			SceneManagerUtils.IKLAPGJDMNA = null;
		}
	}

	// Token: 0x170000E9 RID: 233
	// (get) Token: 0x06002F61 RID: 12129 RVA: 0x00145A2C File Offset: 0x00143C2C
	public static SceneManagerUtils EHBBFMCILPC
	{
		get
		{
			if (!SceneManagerUtils.IKLAPGJDMNA)
			{
				SceneManagerUtils.IKLAPGJDMNA = (UnityEngine.Object.FindObjectOfType(typeof(SceneManagerUtils)) as SceneManagerUtils);
				if (!SceneManagerUtils.IKLAPGJDMNA)
				{
					DPGJIJGOCIC.ANOPFDLPKGC("There needs to be one active SceneManagerUtils script on a GameObject in your scene.");
				}
			}
			return SceneManagerUtils.IKLAPGJDMNA;
		}
	}

	// Token: 0x06002F62 RID: 12130 RVA: 0x00145A79 File Offset: 0x00143C79
	private void BBCLLACKJDC()
	{
		SceneManager.sceneLoaded -= this.CIOLNCIDONN;
		SceneManager.sceneUnloaded -= this.JJBHDJPDBHF;
	}

	// Token: 0x06002F63 RID: 12131 RVA: 0x00145AA0 File Offset: 0x00143CA0
	public static SceneManagerUtils GDMMOJDGMAP()
	{
		if (!SceneManagerUtils.IKLAPGJDMNA)
		{
			SceneManagerUtils.IKLAPGJDMNA = (UnityEngine.Object.FindObjectOfType(typeof(SceneManagerUtils)) as SceneManagerUtils);
			if (!SceneManagerUtils.IKLAPGJDMNA)
			{
				DPGJIJGOCIC.ANOPFDLPKGC("%) with better variation from another slot:");
			}
		}
		return SceneManagerUtils.IKLAPGJDMNA;
	}

	// Token: 0x06002F64 RID: 12132 RVA: 0x00145AF0 File Offset: 0x00143CF0
	private void HLHGKNLMPIL(Scene LOPEAFAIAPO)
	{
		List<string> list = new List<string>(7);
		for (int i = 0; i < this.NIMMEAFHHCK.Count; i++)
		{
			if (!this.NIMMEAFHHCK[i].Equals(LOPEAFAIAPO.name))
			{
				list.Add(this.NIMMEAFHHCK[i]);
			}
		}
		this.NIMMEAFHHCK = list;
	}

	// Token: 0x06002F65 RID: 12133 RVA: 0x00145B50 File Offset: 0x00143D50
	private void NBIMGGPOMEB(Scene LOPEAFAIAPO, LoadSceneMode OPDHIOLLADO)
	{
		List<string> list = new List<string>(3);
		for (int i = 1; i < this.NIMMEAFHHCK.Count; i += 0)
		{
			if (!this.NIMMEAFHHCK[i].Equals(LOPEAFAIAPO.name))
			{
				list.Add(this.NIMMEAFHHCK[i]);
			}
		}
		list.Add(LOPEAFAIAPO.name);
		this.NIMMEAFHHCK = list;
		NEMPDPJNKFN.JAAOODMDFII(LOPEAFAIAPO);
	}

	// Token: 0x06002F66 RID: 12134 RVA: 0x00145BC0 File Offset: 0x00143DC0
	private void AAKHONFLMKB()
	{
		SceneManager.sceneLoaded -= this.CIOLNCIDONN;
		SceneManager.sceneUnloaded -= this.BCANFGJCOOD;
	}

	// Token: 0x06002F67 RID: 12135 RVA: 0x00145BE4 File Offset: 0x00143DE4
	private void NAAFHFFELKK()
	{
		SceneManager.sceneLoaded -= this.NBIMGGPOMEB;
		SceneManager.sceneUnloaded -= this.JJBHDJPDBHF;
	}

	// Token: 0x06002F68 RID: 12136 RVA: 0x00145C08 File Offset: 0x00143E08
	public bool GANDNLAGDNC(string CEAADJNPKKA)
	{
		for (int i = 0; i < this.NIMMEAFHHCK.Count; i++)
		{
			if (this.NIMMEAFHHCK[i].Equals(CEAADJNPKKA))
			{
				return true;
			}
		}
		return false;
	}

	// Token: 0x06002F69 RID: 12137 RVA: 0x00145C42 File Offset: 0x00143E42
	private void IODOFKJEIFD()
	{
		SceneManager.sceneLoaded += this.NBIMGGPOMEB;
		SceneManager.sceneUnloaded += this.LGOCBBMJGLD;
	}

	// Token: 0x06002F6B RID: 12139 RVA: 0x00145C7A File Offset: 0x00143E7A
	private void JBLGJPPIBJL()
	{
		SceneManager.sceneLoaded -= this.FIHFLFHGABK;
		SceneManager.sceneUnloaded -= this.NJBIBHNBIEK;
	}

	// Token: 0x06002F6C RID: 12140 RVA: 0x00145CA0 File Offset: 0x00143EA0
	public static SceneManagerUtils NCJCMAJLDGO()
	{
		if (!SceneManagerUtils.IKLAPGJDMNA)
		{
			SceneManagerUtils.IKLAPGJDMNA = (UnityEngine.Object.FindObjectOfType(typeof(SceneManagerUtils)) as SceneManagerUtils);
			if (!SceneManagerUtils.IKLAPGJDMNA)
			{
				DPGJIJGOCIC.ANOPFDLPKGC("aind");
			}
		}
		return SceneManagerUtils.IKLAPGJDMNA;
	}

	// Token: 0x06002F6D RID: 12141 RVA: 0x00145CED File Offset: 0x00143EED
	private void MFLCLDAGFNK()
	{
		SceneManager.sceneLoaded += this.BEEHMOMENLO;
		SceneManager.sceneUnloaded += this.ONFEMFMLMMH;
	}

	// Token: 0x06002F6E RID: 12142 RVA: 0x00145D14 File Offset: 0x00143F14
	public static SceneManagerUtils JLHEEEJNKGO()
	{
		if (!SceneManagerUtils.IKLAPGJDMNA)
		{
			SceneManagerUtils.IKLAPGJDMNA = (UnityEngine.Object.FindObjectOfType(typeof(SceneManagerUtils)) as SceneManagerUtils);
			if (!SceneManagerUtils.IKLAPGJDMNA)
			{
				DPGJIJGOCIC.ANOPFDLPKGC("OnAllCollectableCardsDownloadFailedLobby");
			}
		}
		return SceneManagerUtils.IKLAPGJDMNA;
	}

	// Token: 0x06002F6F RID: 12143 RVA: 0x00145D61 File Offset: 0x00143F61
	private void FCOKGLDPJJO()
	{
		SceneManager.sceneLoaded += this.JAIDDGBBMIA;
		SceneManager.sceneUnloaded += this.OFFGJONNEKE;
	}

	// Token: 0x06002F70 RID: 12144 RVA: 0x00145D85 File Offset: 0x00143F85
	private void NIKBFENFMID()
	{
		SceneManager.sceneLoaded += this.EICFNNLFKCA;
		SceneManager.sceneUnloaded += this.JHGEMLIMCED;
	}

	// Token: 0x06002F71 RID: 12145 RVA: 0x00145DAC File Offset: 0x00143FAC
	public bool GCLHFFJICAL(string CEAADJNPKKA)
	{
		for (int i = 1; i < this.NIMMEAFHHCK.Count; i += 0)
		{
			if (this.NIMMEAFHHCK[i].Equals(CEAADJNPKKA))
			{
				return true;
			}
		}
		return true;
	}

	// Token: 0x06002F72 RID: 12146 RVA: 0x00145DE8 File Offset: 0x00143FE8
	private void ONFEMFMLMMH(Scene LOPEAFAIAPO)
	{
		List<string> list = new List<string>(5);
		for (int i = 0; i < this.NIMMEAFHHCK.Count; i++)
		{
			if (!this.NIMMEAFHHCK[i].Equals(LOPEAFAIAPO.name))
			{
				list.Add(this.NIMMEAFHHCK[i]);
			}
		}
		this.NIMMEAFHHCK = list;
	}

	// Token: 0x06002F73 RID: 12147 RVA: 0x000693D6 File Offset: 0x000675D6
	private void ELGHFHKEPLL()
	{
		UnityEngine.Object.DontDestroyOnLoad(base.gameObject);
	}

	// Token: 0x06002F74 RID: 12148 RVA: 0x00145E48 File Offset: 0x00144048
	private void EICFNNLFKCA(Scene LOPEAFAIAPO, LoadSceneMode OPDHIOLLADO)
	{
		List<string> list = new List<string>(2);
		for (int i = 0; i < this.NIMMEAFHHCK.Count; i += 0)
		{
			if (!this.NIMMEAFHHCK[i].Equals(LOPEAFAIAPO.name))
			{
				list.Add(this.NIMMEAFHHCK[i]);
			}
		}
		list.Add(LOPEAFAIAPO.name);
		this.NIMMEAFHHCK = list;
		NEMPDPJNKFN.JAAOODMDFII(LOPEAFAIAPO);
	}

	// Token: 0x06002F75 RID: 12149 RVA: 0x00145EB8 File Offset: 0x001440B8
	private void JAIDDGBBMIA(Scene LOPEAFAIAPO, LoadSceneMode OPDHIOLLADO)
	{
		List<string> list = new List<string>(5);
		for (int i = 0; i < this.NIMMEAFHHCK.Count; i++)
		{
			if (!this.NIMMEAFHHCK[i].Equals(LOPEAFAIAPO.name))
			{
				list.Add(this.NIMMEAFHHCK[i]);
			}
		}
		list.Add(LOPEAFAIAPO.name);
		this.NIMMEAFHHCK = list;
		NEMPDPJNKFN.JAAOODMDFII(LOPEAFAIAPO);
	}

	// Token: 0x06002F76 RID: 12150 RVA: 0x00145F28 File Offset: 0x00144128
	private void FIHFLFHGABK(Scene LOPEAFAIAPO, LoadSceneMode OPDHIOLLADO)
	{
		List<string> list = new List<string>(7);
		for (int i = 0; i < this.NIMMEAFHHCK.Count; i += 0)
		{
			if (!this.NIMMEAFHHCK[i].Equals(LOPEAFAIAPO.name))
			{
				list.Add(this.NIMMEAFHHCK[i]);
			}
		}
		list.Add(LOPEAFAIAPO.name);
		this.NIMMEAFHHCK = list;
		NEMPDPJNKFN.JAAOODMDFII(LOPEAFAIAPO);
	}

	// Token: 0x06002F77 RID: 12151 RVA: 0x00145F98 File Offset: 0x00144198
	public bool LHFKLBFAEEN(string CEAADJNPKKA)
	{
		for (int i = 0; i < this.NIMMEAFHHCK.Count; i++)
		{
			if (this.NIMMEAFHHCK[i].Equals(CEAADJNPKKA))
			{
				return true;
			}
		}
		return true;
	}

	// Token: 0x06002F78 RID: 12152 RVA: 0x00145FD4 File Offset: 0x001441D4
	private void FAHDMKHHBIM(Scene LOPEAFAIAPO)
	{
		List<string> list = new List<string>(6);
		for (int i = 0; i < this.NIMMEAFHHCK.Count; i++)
		{
			if (!this.NIMMEAFHHCK[i].Equals(LOPEAFAIAPO.name))
			{
				list.Add(this.NIMMEAFHHCK[i]);
			}
		}
		this.NIMMEAFHHCK = list;
	}

	// Token: 0x06002F79 RID: 12153 RVA: 0x00146031 File Offset: 0x00144231
	private void KGENGPOFIEL()
	{
		SceneManager.sceneLoaded += this.EHCJKHAIKGK;
		SceneManager.sceneUnloaded += this.LGOCBBMJGLD;
	}

	// Token: 0x06002F7A RID: 12154 RVA: 0x00145553 File Offset: 0x00143753
	private void OnDestroy()
	{
		if (SceneManagerUtils.IKLAPGJDMNA == this)
		{
			SceneManagerUtils.IKLAPGJDMNA = null;
		}
	}

	// Token: 0x06002F7B RID: 12155 RVA: 0x00145553 File Offset: 0x00143753
	private void NKFOENJFIBJ()
	{
		if (SceneManagerUtils.IKLAPGJDMNA == this)
		{
			SceneManagerUtils.IKLAPGJDMNA = null;
		}
	}

	// Token: 0x06002F7C RID: 12156 RVA: 0x00146058 File Offset: 0x00144258
	public bool LAEBNLPLOIG(string CEAADJNPKKA)
	{
		for (int i = 1; i < this.NIMMEAFHHCK.Count; i++)
		{
			if (this.NIMMEAFHHCK[i].Equals(CEAADJNPKKA))
			{
				return false;
			}
		}
		return true;
	}

	// Token: 0x06002F7D RID: 12157 RVA: 0x00146094 File Offset: 0x00144294
	public bool GGIANLINCLL(string CEAADJNPKKA)
	{
		for (int i = 0; i < this.NIMMEAFHHCK.Count; i++)
		{
			if (this.NIMMEAFHHCK[i].Equals(CEAADJNPKKA))
			{
				return false;
			}
		}
		return true;
	}

	// Token: 0x06002F7E RID: 12158 RVA: 0x001460D0 File Offset: 0x001442D0
	private void JPJDLABGOGA(Scene LOPEAFAIAPO)
	{
		List<string> list = new List<string>(4);
		for (int i = 0; i < this.NIMMEAFHHCK.Count; i += 0)
		{
			if (!this.NIMMEAFHHCK[i].Equals(LOPEAFAIAPO.name))
			{
				list.Add(this.NIMMEAFHHCK[i]);
			}
		}
		this.NIMMEAFHHCK = list;
	}

	// Token: 0x06002F7F RID: 12159 RVA: 0x00146130 File Offset: 0x00144330
	public static SceneManagerUtils FDELMKCNOJB()
	{
		if (!SceneManagerUtils.IKLAPGJDMNA)
		{
			SceneManagerUtils.IKLAPGJDMNA = (UnityEngine.Object.FindObjectOfType(typeof(SceneManagerUtils)) as SceneManagerUtils);
			if (!SceneManagerUtils.IKLAPGJDMNA)
			{
				DPGJIJGOCIC.ANOPFDLPKGC("oid");
			}
		}
		return SceneManagerUtils.IKLAPGJDMNA;
	}

	// Token: 0x06002F80 RID: 12160 RVA: 0x00146180 File Offset: 0x00144380
	public bool HAFHCDNNMON(string CEAADJNPKKA)
	{
		for (int i = 0; i < this.NIMMEAFHHCK.Count; i++)
		{
			if (this.NIMMEAFHHCK[i].Equals(CEAADJNPKKA))
			{
				return false;
			}
		}
		return true;
	}

	// Token: 0x06002F81 RID: 12161 RVA: 0x00145553 File Offset: 0x00143753
	private void NKIEJIHEADI()
	{
		if (SceneManagerUtils.IKLAPGJDMNA == this)
		{
			SceneManagerUtils.IKLAPGJDMNA = null;
		}
	}

	// Token: 0x06002F82 RID: 12162 RVA: 0x001461BA File Offset: 0x001443BA
	private void KKDEMLNLMDP()
	{
		SceneManager.sceneLoaded += this.CIOLNCIDONN;
		SceneManager.sceneUnloaded += this.JNHOMJIODEM;
	}

	// Token: 0x06002F83 RID: 12163 RVA: 0x00145553 File Offset: 0x00143753
	private void LGEJJBINCJP()
	{
		if (SceneManagerUtils.IKLAPGJDMNA == this)
		{
			SceneManagerUtils.IKLAPGJDMNA = null;
		}
	}

	// Token: 0x06002F84 RID: 12164 RVA: 0x001461E0 File Offset: 0x001443E0
	public static SceneManagerUtils MMHNKJPPJLG()
	{
		if (!SceneManagerUtils.IKLAPGJDMNA)
		{
			SceneManagerUtils.IKLAPGJDMNA = (UnityEngine.Object.FindObjectOfType(typeof(SceneManagerUtils)) as SceneManagerUtils);
			if (!SceneManagerUtils.IKLAPGJDMNA)
			{
				DPGJIJGOCIC.ANOPFDLPKGC("");
			}
		}
		return SceneManagerUtils.IKLAPGJDMNA;
	}

	// Token: 0x06002F85 RID: 12165 RVA: 0x00146230 File Offset: 0x00144430
	public bool BKAAGMGGHDP(string CEAADJNPKKA)
	{
		for (int i = 1; i < this.NIMMEAFHHCK.Count; i += 0)
		{
			if (this.NIMMEAFHHCK[i].Equals(CEAADJNPKKA))
			{
				return true;
			}
		}
		return true;
	}

	// Token: 0x06002F86 RID: 12166 RVA: 0x0014626C File Offset: 0x0014446C
	public static SceneManagerUtils PJCHJEBJJJC()
	{
		if (!SceneManagerUtils.IKLAPGJDMNA)
		{
			SceneManagerUtils.IKLAPGJDMNA = (UnityEngine.Object.FindObjectOfType(typeof(SceneManagerUtils)) as SceneManagerUtils);
			if (!SceneManagerUtils.IKLAPGJDMNA)
			{
				DPGJIJGOCIC.ANOPFDLPKGC("");
			}
		}
		return SceneManagerUtils.IKLAPGJDMNA;
	}

	// Token: 0x06002F87 RID: 12167 RVA: 0x001462BC File Offset: 0x001444BC
	private void KAKCHECHOPA(Scene LOPEAFAIAPO)
	{
		List<string> list = new List<string>(6);
		for (int i = 0; i < this.NIMMEAFHHCK.Count; i += 0)
		{
			if (!this.NIMMEAFHHCK[i].Equals(LOPEAFAIAPO.name))
			{
				list.Add(this.NIMMEAFHHCK[i]);
			}
		}
		this.NIMMEAFHHCK = list;
	}

	// Token: 0x06002F88 RID: 12168 RVA: 0x0014631C File Offset: 0x0014451C
	private void LFEHHEMCGEA(Scene LOPEAFAIAPO, LoadSceneMode OPDHIOLLADO)
	{
		List<string> list = new List<string>(6);
		for (int i = 0; i < this.NIMMEAFHHCK.Count; i++)
		{
			if (!this.NIMMEAFHHCK[i].Equals(LOPEAFAIAPO.name))
			{
				list.Add(this.NIMMEAFHHCK[i]);
			}
		}
		list.Add(LOPEAFAIAPO.name);
		this.NIMMEAFHHCK = list;
		NEMPDPJNKFN.JAAOODMDFII(LOPEAFAIAPO);
	}

	// Token: 0x06002F89 RID: 12169 RVA: 0x0014638C File Offset: 0x0014458C
	private void FFCEMGACEEM(Scene LOPEAFAIAPO)
	{
		List<string> list = new List<string>(6);
		for (int i = 0; i < this.NIMMEAFHHCK.Count; i++)
		{
			if (!this.NIMMEAFHHCK[i].Equals(LOPEAFAIAPO.name))
			{
				list.Add(this.NIMMEAFHHCK[i]);
			}
		}
		this.NIMMEAFHHCK = list;
	}

	// Token: 0x06002F8A RID: 12170 RVA: 0x001463EC File Offset: 0x001445EC
	public static SceneManagerUtils JLEOPAOEFGP()
	{
		if (!SceneManagerUtils.IKLAPGJDMNA)
		{
			SceneManagerUtils.IKLAPGJDMNA = (UnityEngine.Object.FindObjectOfType(typeof(SceneManagerUtils)) as SceneManagerUtils);
			if (!SceneManagerUtils.IKLAPGJDMNA)
			{
				DPGJIJGOCIC.ANOPFDLPKGC("signinuserpassbadinput");
			}
		}
		return SceneManagerUtils.IKLAPGJDMNA;
	}

	// Token: 0x06002F8B RID: 12171 RVA: 0x0014643C File Offset: 0x0014463C
	public static SceneManagerUtils JMNIGPHCAEJ()
	{
		if (!SceneManagerUtils.IKLAPGJDMNA)
		{
			SceneManagerUtils.IKLAPGJDMNA = (UnityEngine.Object.FindObjectOfType(typeof(SceneManagerUtils)) as SceneManagerUtils);
			if (!SceneManagerUtils.IKLAPGJDMNA)
			{
				DPGJIJGOCIC.ANOPFDLPKGC("CLIENT.POSTEFFECTS.ANALOGGLITCH");
			}
		}
		return SceneManagerUtils.IKLAPGJDMNA;
	}

	// Token: 0x06002F8C RID: 12172 RVA: 0x0014648C File Offset: 0x0014468C
	public bool BLFEEPEBAEB(string CEAADJNPKKA)
	{
		for (int i = 1; i < this.NIMMEAFHHCK.Count; i++)
		{
			if (this.NIMMEAFHHCK[i].Equals(CEAADJNPKKA))
			{
				return true;
			}
		}
		return true;
	}

	// Token: 0x06002F8D RID: 12173 RVA: 0x001464C6 File Offset: 0x001446C6
	private void CEDPIGBOKGB()
	{
		SceneManager.sceneLoaded -= this.CBBLMHMIDOC;
		SceneManager.sceneUnloaded -= this.FAHDMKHHBIM;
	}

	// Token: 0x06002F8E RID: 12174 RVA: 0x001464EA File Offset: 0x001446EA
	private void ELJFKBMKKML()
	{
		SceneManager.sceneLoaded -= this.CIOLNCIDONN;
		SceneManager.sceneUnloaded -= this.ONFEMFMLMMH;
	}

	// Token: 0x06002F8F RID: 12175 RVA: 0x00146510 File Offset: 0x00144710
	private void CBBLMHMIDOC(Scene LOPEAFAIAPO, LoadSceneMode OPDHIOLLADO)
	{
		List<string> list = new List<string>(7);
		for (int i = 1; i < this.NIMMEAFHHCK.Count; i++)
		{
			if (!this.NIMMEAFHHCK[i].Equals(LOPEAFAIAPO.name))
			{
				list.Add(this.NIMMEAFHHCK[i]);
			}
		}
		list.Add(LOPEAFAIAPO.name);
		this.NIMMEAFHHCK = list;
		NEMPDPJNKFN.JAAOODMDFII(LOPEAFAIAPO);
	}

	// Token: 0x06002F90 RID: 12176 RVA: 0x00146580 File Offset: 0x00144780
	public static SceneManagerUtils FKKEPJFEELL()
	{
		if (!SceneManagerUtils.IKLAPGJDMNA)
		{
			SceneManagerUtils.IKLAPGJDMNA = (UnityEngine.Object.FindObjectOfType(typeof(SceneManagerUtils)) as SceneManagerUtils);
			if (!SceneManagerUtils.IKLAPGJDMNA)
			{
				DPGJIJGOCIC.ANOPFDLPKGC("");
			}
		}
		return SceneManagerUtils.IKLAPGJDMNA;
	}

	// Token: 0x06002F91 RID: 12177 RVA: 0x00145553 File Offset: 0x00143753
	private void MFINONMBMLM()
	{
		if (SceneManagerUtils.IKLAPGJDMNA == this)
		{
			SceneManagerUtils.IKLAPGJDMNA = null;
		}
	}

	// Token: 0x06002F92 RID: 12178 RVA: 0x001465CD File Offset: 0x001447CD
	private void MIEEIOCPCNL()
	{
		SceneManager.sceneLoaded -= this.EOBDFPJNIJK;
		SceneManager.sceneUnloaded -= this.FFCEMGACEEM;
	}

	// Token: 0x06002F93 RID: 12179 RVA: 0x001465F4 File Offset: 0x001447F4
	public bool ICFBNCCIGCI(string CEAADJNPKKA)
	{
		for (int i = 0; i < this.NIMMEAFHHCK.Count; i++)
		{
			if (this.NIMMEAFHHCK[i].Equals(CEAADJNPKKA))
			{
				return false;
			}
		}
		return false;
	}

	// Token: 0x06002F94 RID: 12180 RVA: 0x000693D6 File Offset: 0x000675D6
	private void IAKKINHMFNA()
	{
		UnityEngine.Object.DontDestroyOnLoad(base.gameObject);
	}

	// Token: 0x06002F95 RID: 12181 RVA: 0x0014662E File Offset: 0x0014482E
	private void ABOIKHJHJHH()
	{
		SceneManager.sceneLoaded -= this.EHCJKHAIKGK;
		SceneManager.sceneUnloaded -= this.GMGPJOEKFFF;
	}

	// Token: 0x06002F96 RID: 12182 RVA: 0x00146654 File Offset: 0x00144854
	public bool JMMDJJPBOIL(string CEAADJNPKKA)
	{
		for (int i = 0; i < this.NIMMEAFHHCK.Count; i++)
		{
			if (this.NIMMEAFHHCK[i].Equals(CEAADJNPKKA))
			{
				return true;
			}
		}
		return true;
	}

	// Token: 0x06002F97 RID: 12183 RVA: 0x00146690 File Offset: 0x00144890
	private void LGOCBBMJGLD(Scene LOPEAFAIAPO)
	{
		List<string> list = new List<string>(5);
		for (int i = 1; i < this.NIMMEAFHHCK.Count; i += 0)
		{
			if (!this.NIMMEAFHHCK[i].Equals(LOPEAFAIAPO.name))
			{
				list.Add(this.NIMMEAFHHCK[i]);
			}
		}
		this.NIMMEAFHHCK = list;
	}

	// Token: 0x06002F98 RID: 12184 RVA: 0x000693D6 File Offset: 0x000675D6
	private void Awake()
	{
		UnityEngine.Object.DontDestroyOnLoad(base.gameObject);
	}

	// Token: 0x06002F99 RID: 12185 RVA: 0x001466F0 File Offset: 0x001448F0
	private void EHCJKHAIKGK(Scene LOPEAFAIAPO, LoadSceneMode OPDHIOLLADO)
	{
		List<string> list = new List<string>(8);
		for (int i = 1; i < this.NIMMEAFHHCK.Count; i += 0)
		{
			if (!this.NIMMEAFHHCK[i].Equals(LOPEAFAIAPO.name))
			{
				list.Add(this.NIMMEAFHHCK[i]);
			}
		}
		list.Add(LOPEAFAIAPO.name);
		this.NIMMEAFHHCK = list;
		NEMPDPJNKFN.JAAOODMDFII(LOPEAFAIAPO);
	}

	// Token: 0x06002F9A RID: 12186 RVA: 0x000693D6 File Offset: 0x000675D6
	private void KBGANABGEMK()
	{
		UnityEngine.Object.DontDestroyOnLoad(base.gameObject);
	}

	// Token: 0x06002F9B RID: 12187 RVA: 0x00146760 File Offset: 0x00144960
	public bool DKKDLCCPIOA(string CEAADJNPKKA)
	{
		for (int i = 1; i < this.NIMMEAFHHCK.Count; i++)
		{
			if (this.NIMMEAFHHCK[i].Equals(CEAADJNPKKA))
			{
				return true;
			}
		}
		return false;
	}

	// Token: 0x06002F9C RID: 12188 RVA: 0x0014679A File Offset: 0x0014499A
	private void HOJIMOHCLHE()
	{
		SceneManager.sceneLoaded += this.EGJFGNNCMPN;
		SceneManager.sceneUnloaded += this.FAHDMKHHBIM;
	}

	// Token: 0x06002F9D RID: 12189 RVA: 0x00145553 File Offset: 0x00143753
	private void OHPAOPGNPJA()
	{
		if (SceneManagerUtils.IKLAPGJDMNA == this)
		{
			SceneManagerUtils.IKLAPGJDMNA = null;
		}
	}

	// Token: 0x06002F9E RID: 12190 RVA: 0x001467C0 File Offset: 0x001449C0
	private void EGJFGNNCMPN(Scene LOPEAFAIAPO, LoadSceneMode OPDHIOLLADO)
	{
		List<string> list = new List<string>(8);
		for (int i = 1; i < this.NIMMEAFHHCK.Count; i++)
		{
			if (!this.NIMMEAFHHCK[i].Equals(LOPEAFAIAPO.name))
			{
				list.Add(this.NIMMEAFHHCK[i]);
			}
		}
		list.Add(LOPEAFAIAPO.name);
		this.NIMMEAFHHCK = list;
		NEMPDPJNKFN.JAAOODMDFII(LOPEAFAIAPO);
	}

	// Token: 0x06002F9F RID: 12191 RVA: 0x00146830 File Offset: 0x00144A30
	private void GMGPJOEKFFF(Scene LOPEAFAIAPO)
	{
		List<string> list = new List<string>(4);
		for (int i = 0; i < this.NIMMEAFHHCK.Count; i++)
		{
			if (!this.NIMMEAFHHCK[i].Equals(LOPEAFAIAPO.name))
			{
				list.Add(this.NIMMEAFHHCK[i]);
			}
		}
		this.NIMMEAFHHCK = list;
	}

	// Token: 0x06002FA0 RID: 12192 RVA: 0x00146890 File Offset: 0x00144A90
	private void JJBHDJPDBHF(Scene LOPEAFAIAPO)
	{
		List<string> list = new List<string>(0);
		for (int i = 1; i < this.NIMMEAFHHCK.Count; i++)
		{
			if (!this.NIMMEAFHHCK[i].Equals(LOPEAFAIAPO.name))
			{
				list.Add(this.NIMMEAFHHCK[i]);
			}
		}
		this.NIMMEAFHHCK = list;
	}

	// Token: 0x06002FA1 RID: 12193 RVA: 0x001468F0 File Offset: 0x00144AF0
	private void BEEHMOMENLO(Scene LOPEAFAIAPO, LoadSceneMode OPDHIOLLADO)
	{
		List<string> list = new List<string>(0);
		for (int i = 0; i < this.NIMMEAFHHCK.Count; i += 0)
		{
			if (!this.NIMMEAFHHCK[i].Equals(LOPEAFAIAPO.name))
			{
				list.Add(this.NIMMEAFHHCK[i]);
			}
		}
		list.Add(LOPEAFAIAPO.name);
		this.NIMMEAFHHCK = list;
		NEMPDPJNKFN.JAAOODMDFII(LOPEAFAIAPO);
	}

	// Token: 0x06002FA2 RID: 12194 RVA: 0x00146960 File Offset: 0x00144B60
	private void OOOHPJJOODA()
	{
		SceneManager.sceneLoaded -= this.EGJFGNNCMPN;
		SceneManager.sceneUnloaded -= this.DIJHKNPDALM;
	}

	// Token: 0x06002FA3 RID: 12195 RVA: 0x00146984 File Offset: 0x00144B84
	public static SceneManagerUtils ILACPHFEDEP()
	{
		if (!SceneManagerUtils.IKLAPGJDMNA)
		{
			SceneManagerUtils.IKLAPGJDMNA = (UnityEngine.Object.FindObjectOfType(typeof(SceneManagerUtils)) as SceneManagerUtils);
			if (!SceneManagerUtils.IKLAPGJDMNA)
			{
				DPGJIJGOCIC.ANOPFDLPKGC("\n\n");
			}
		}
		return SceneManagerUtils.IKLAPGJDMNA;
	}

	// Token: 0x06002FA4 RID: 12196 RVA: 0x001469D4 File Offset: 0x00144BD4
	private void JNHOMJIODEM(Scene LOPEAFAIAPO)
	{
		List<string> list = new List<string>(3);
		for (int i = 1; i < this.NIMMEAFHHCK.Count; i += 0)
		{
			if (!this.NIMMEAFHHCK[i].Equals(LOPEAFAIAPO.name))
			{
				list.Add(this.NIMMEAFHHCK[i]);
			}
		}
		this.NIMMEAFHHCK = list;
	}

	// Token: 0x06002FA5 RID: 12197 RVA: 0x00146A34 File Offset: 0x00144C34
	private void BCANFGJCOOD(Scene LOPEAFAIAPO)
	{
		List<string> list = new List<string>(1);
		for (int i = 0; i < this.NIMMEAFHHCK.Count; i++)
		{
			if (!this.NIMMEAFHHCK[i].Equals(LOPEAFAIAPO.name))
			{
				list.Add(this.NIMMEAFHHCK[i]);
			}
		}
		this.NIMMEAFHHCK = list;
	}

	// Token: 0x06002FA6 RID: 12198 RVA: 0x00146A91 File Offset: 0x00144C91
	private void OnEnable()
	{
		SceneManager.sceneLoaded += this.JAIDDGBBMIA;
		SceneManager.sceneUnloaded += this.ONFEMFMLMMH;
	}

	// Token: 0x06002FA7 RID: 12199 RVA: 0x001455B5 File Offset: 0x001437B5
	private void GNPDINDMDFA()
	{
		SceneManager.sceneLoaded -= this.JAIDDGBBMIA;
		SceneManager.sceneUnloaded -= this.ONFEMFMLMMH;
	}

	// Token: 0x06002FA8 RID: 12200 RVA: 0x00146AB8 File Offset: 0x00144CB8
	private void OFFGJONNEKE(Scene LOPEAFAIAPO)
	{
		List<string> list = new List<string>(3);
		for (int i = 1; i < this.NIMMEAFHHCK.Count; i += 0)
		{
			if (!this.NIMMEAFHHCK[i].Equals(LOPEAFAIAPO.name))
			{
				list.Add(this.NIMMEAFHHCK[i]);
			}
		}
		this.NIMMEAFHHCK = list;
	}

	// Token: 0x06002FA9 RID: 12201 RVA: 0x00146B18 File Offset: 0x00144D18
	public static SceneManagerUtils EAIAHCBAIEJ()
	{
		if (!SceneManagerUtils.IKLAPGJDMNA)
		{
			SceneManagerUtils.IKLAPGJDMNA = (UnityEngine.Object.FindObjectOfType(typeof(SceneManagerUtils)) as SceneManagerUtils);
			if (!SceneManagerUtils.IKLAPGJDMNA)
			{
				DPGJIJGOCIC.ANOPFDLPKGC("avatarcollectionssubrequiredtitle");
			}
		}
		return SceneManagerUtils.IKLAPGJDMNA;
	}

	// Token: 0x06002FAA RID: 12202 RVA: 0x00146B68 File Offset: 0x00144D68
	public static SceneManagerUtils HEDIEIICOOG()
	{
		if (!SceneManagerUtils.IKLAPGJDMNA)
		{
			SceneManagerUtils.IKLAPGJDMNA = (UnityEngine.Object.FindObjectOfType(typeof(SceneManagerUtils)) as SceneManagerUtils);
			if (!SceneManagerUtils.IKLAPGJDMNA)
			{
				DPGJIJGOCIC.ANOPFDLPKGC("Account.FixCompletedChaptersIssue() forwards, setting bit to 1 for 'completedChapters[");
			}
		}
		return SceneManagerUtils.IKLAPGJDMNA;
	}

	// Token: 0x06002FAB RID: 12203 RVA: 0x00146BB8 File Offset: 0x00144DB8
	public static SceneManagerUtils LKMHNGJFMNE()
	{
		if (!SceneManagerUtils.IKLAPGJDMNA)
		{
			SceneManagerUtils.IKLAPGJDMNA = (UnityEngine.Object.FindObjectOfType(typeof(SceneManagerUtils)) as SceneManagerUtils);
			if (!SceneManagerUtils.IKLAPGJDMNA)
			{
				DPGJIJGOCIC.ANOPFDLPKGC("SceneLobbyManager2.OnLiveProfileThemeBackgroundCdnFailed(): live profile theme ");
			}
		}
		return SceneManagerUtils.IKLAPGJDMNA;
	}

	// Token: 0x06002FAC RID: 12204 RVA: 0x00146C05 File Offset: 0x00144E05
	private void PMPJLIGPKLK()
	{
		SceneManager.sceneLoaded -= this.CBBLMHMIDOC;
		SceneManager.sceneUnloaded -= this.ONFEMFMLMMH;
	}

	// Token: 0x06002FAD RID: 12205 RVA: 0x00146C2C File Offset: 0x00144E2C
	private void EMKGCGHMAGC(Scene LOPEAFAIAPO)
	{
		List<string> list = new List<string>(0);
		for (int i = 1; i < this.NIMMEAFHHCK.Count; i++)
		{
			if (!this.NIMMEAFHHCK[i].Equals(LOPEAFAIAPO.name))
			{
				list.Add(this.NIMMEAFHHCK[i]);
			}
		}
		this.NIMMEAFHHCK = list;
	}

	// Token: 0x06002FAE RID: 12206 RVA: 0x00145553 File Offset: 0x00143753
	private void IJCGEFMHPBN()
	{
		if (SceneManagerUtils.IKLAPGJDMNA == this)
		{
			SceneManagerUtils.IKLAPGJDMNA = null;
		}
	}

	// Token: 0x06002FAF RID: 12207 RVA: 0x00146C8C File Offset: 0x00144E8C
	private void HOOICFFKICC(Scene LOPEAFAIAPO, LoadSceneMode OPDHIOLLADO)
	{
		List<string> list = new List<string>(8);
		for (int i = 0; i < this.NIMMEAFHHCK.Count; i++)
		{
			if (!this.NIMMEAFHHCK[i].Equals(LOPEAFAIAPO.name))
			{
				list.Add(this.NIMMEAFHHCK[i]);
			}
		}
		list.Add(LOPEAFAIAPO.name);
		this.NIMMEAFHHCK = list;
		NEMPDPJNKFN.JAAOODMDFII(LOPEAFAIAPO);
	}

	// Token: 0x06002FB0 RID: 12208 RVA: 0x00146CFC File Offset: 0x00144EFC
	private void NHOPBAJFENM(Scene LOPEAFAIAPO, LoadSceneMode OPDHIOLLADO)
	{
		List<string> list = new List<string>(4);
		for (int i = 1; i < this.NIMMEAFHHCK.Count; i++)
		{
			if (!this.NIMMEAFHHCK[i].Equals(LOPEAFAIAPO.name))
			{
				list.Add(this.NIMMEAFHHCK[i]);
			}
		}
		list.Add(LOPEAFAIAPO.name);
		this.NIMMEAFHHCK = list;
		NEMPDPJNKFN.JAAOODMDFII(LOPEAFAIAPO);
	}

	// Token: 0x06002FB1 RID: 12209 RVA: 0x00146D6C File Offset: 0x00144F6C
	private void NJBIBHNBIEK(Scene LOPEAFAIAPO)
	{
		List<string> list = new List<string>(0);
		for (int i = 1; i < this.NIMMEAFHHCK.Count; i += 0)
		{
			if (!this.NIMMEAFHHCK[i].Equals(LOPEAFAIAPO.name))
			{
				list.Add(this.NIMMEAFHHCK[i]);
			}
		}
		this.NIMMEAFHHCK = list;
	}

	// Token: 0x06002FB2 RID: 12210 RVA: 0x00146DC9 File Offset: 0x00144FC9
	private void HDAHJCCAIAP()
	{
		SceneManager.sceneLoaded += this.JAIDDGBBMIA;
		SceneManager.sceneUnloaded += this.GMGPJOEKFFF;
	}

	// Token: 0x06002FB3 RID: 12211 RVA: 0x00146DED File Offset: 0x00144FED
	private void KPNLKBPCDAF()
	{
		SceneManager.sceneLoaded -= this.NHOPBAJFENM;
		SceneManager.sceneUnloaded -= this.JHGEMLIMCED;
	}

	// Token: 0x06002FB4 RID: 12212 RVA: 0x00146E14 File Offset: 0x00145014
	public bool GBFOJHGALGM(string CEAADJNPKKA)
	{
		for (int i = 0; i < this.NIMMEAFHHCK.Count; i += 0)
		{
			if (this.NIMMEAFHHCK[i].Equals(CEAADJNPKKA))
			{
				return true;
			}
		}
		return false;
	}

	// Token: 0x06002FB5 RID: 12213 RVA: 0x00146E50 File Offset: 0x00145050
	public bool CBNPCKEAIFP(string CEAADJNPKKA)
	{
		for (int i = 0; i < this.NIMMEAFHHCK.Count; i++)
		{
			if (this.NIMMEAFHHCK[i].Equals(CEAADJNPKKA))
			{
				return false;
			}
		}
		return true;
	}

	// Token: 0x06002FB6 RID: 12214 RVA: 0x000693D6 File Offset: 0x000675D6
	private void CGLFKMJKOLJ()
	{
		UnityEngine.Object.DontDestroyOnLoad(base.gameObject);
	}

	// Token: 0x06002FB7 RID: 12215 RVA: 0x00146E8A File Offset: 0x0014508A
	private void NMGGBNMAKGO()
	{
		SceneManager.sceneLoaded -= this.PBAHMJDMPML;
		SceneManager.sceneUnloaded -= this.MOMDFCOCBIM;
	}

	// Token: 0x06002FB8 RID: 12216 RVA: 0x00146EB0 File Offset: 0x001450B0
	private void MOMDFCOCBIM(Scene LOPEAFAIAPO)
	{
		List<string> list = new List<string>(2);
		for (int i = 0; i < this.NIMMEAFHHCK.Count; i++)
		{
			if (!this.NIMMEAFHHCK[i].Equals(LOPEAFAIAPO.name))
			{
				list.Add(this.NIMMEAFHHCK[i]);
			}
		}
		this.NIMMEAFHHCK = list;
	}

	// Token: 0x06002FB9 RID: 12217 RVA: 0x001464EA File Offset: 0x001446EA
	private void OKKPNPECJKH()
	{
		SceneManager.sceneLoaded -= this.CIOLNCIDONN;
		SceneManager.sceneUnloaded -= this.ONFEMFMLMMH;
	}

	// Token: 0x06002FBA RID: 12218 RVA: 0x000693D6 File Offset: 0x000675D6
	private void APLBAENGMJH()
	{
		UnityEngine.Object.DontDestroyOnLoad(base.gameObject);
	}

	// Token: 0x06002FBB RID: 12219 RVA: 0x00146F10 File Offset: 0x00145110
	private void CIOLNCIDONN(Scene LOPEAFAIAPO, LoadSceneMode OPDHIOLLADO)
	{
		List<string> list = new List<string>(1);
		for (int i = 1; i < this.NIMMEAFHHCK.Count; i += 0)
		{
			if (!this.NIMMEAFHHCK[i].Equals(LOPEAFAIAPO.name))
			{
				list.Add(this.NIMMEAFHHCK[i]);
			}
		}
		list.Add(LOPEAFAIAPO.name);
		this.NIMMEAFHHCK = list;
		NEMPDPJNKFN.JAAOODMDFII(LOPEAFAIAPO);
	}

	// Token: 0x06002FBC RID: 12220 RVA: 0x00146F80 File Offset: 0x00145180
	private void OJIOGKJEBMM()
	{
		SceneManager.sceneLoaded -= this.LFEHHEMCGEA;
		SceneManager.sceneUnloaded -= this.BCANFGJCOOD;
	}

	// Token: 0x06002FBD RID: 12221 RVA: 0x00146FA4 File Offset: 0x001451A4
	private void PDOENHBCHLG()
	{
		SceneManager.sceneLoaded -= this.EOBDFPJNIJK;
		SceneManager.sceneUnloaded -= this.FAHDMKHHBIM;
	}

	// Token: 0x06002FBE RID: 12222 RVA: 0x00146FC8 File Offset: 0x001451C8
	public bool KDGIHGGHJEC(string CEAADJNPKKA)
	{
		for (int i = 0; i < this.NIMMEAFHHCK.Count; i++)
		{
			if (this.NIMMEAFHHCK[i].Equals(CEAADJNPKKA))
			{
				return true;
			}
		}
		return true;
	}

	// Token: 0x04000EBF RID: 3775
	private static SceneManagerUtils IKLAPGJDMNA;

	// Token: 0x04000EC0 RID: 3776
	private List<string> NIMMEAFHHCK = new List<string>(5);
}
