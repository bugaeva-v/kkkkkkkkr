using System;
using System.Collections.Generic;
using SimpleJSON;

// Token: 0x02000453 RID: 1107
public class PLFDAJJHMKO
{
	// Token: 0x060086A6 RID: 34470 RVA: 0x003C691C File Offset: 0x003C4B1C
	public bool HPNLAJDDAFE()
	{
		return this.DHONIOBOLEL.EBFMKGPBEBO.Count > 0;
	}

	// Token: 0x060086A7 RID: 34471 RVA: 0x003C6934 File Offset: 0x003C4B34
	public void EMLEABJJMLF()
	{
		if (null != this.NCAMFPGMCIG.IMJDADKEEJC)
		{
			int pojaplkajef = this.POJAPLKAJEF;
			if (this.NCAMFPGMCIG.DNMPCOHNAHO.Count > 1 && this.NCAMFPGMCIG.DNMPCOHNAHO[0].Length == 0)
			{
				this.FGJPKGLOGNC(this.NCAMFPGMCIG.IMJDADKEEJC, true);
				this.LNCIMPFKHAO();
			}
			else
			{
				JSONObject imjdadkeejc = this.NCAMFPGMCIG.IMJDADKEEJC;
				this.FGJPKGLOGNC(this.NCAMFPGMCIG.IMJDADKEEJC, false);
				this.NCAMFPGMCIG.FEDCIMMIJCI = 1;
				this.NCAMFPGMCIG.IMJDADKEEJC = imjdadkeejc;
			}
			this.POJAPLKAJEF = pojaplkajef;
			AKLFPGMDKLA.EHBBFMCILPC.NNKDPEHHIMP(this);
			this.DHONIOBOLEL.CFGFOEEEJKJ = -1;
		}
	}

	// Token: 0x060086A8 RID: 34472 RVA: 0x003C69F8 File Offset: 0x003C4BF8
	public static string FJOIGDKJEBC(int IFCHGNCDMLJ, int OLKMHHNMDLP, int CCLNHHJPDGJ)
	{
		return string.Concat(new string[]
		{
			"X",
			IFCHGNCDMLJ.ToString(),
			"Y",
			OLKMHHNMDLP.ToString(),
			"Z",
			CCLNHHJPDGJ.ToString(),
			"W"
		});
	}

	// Token: 0x060086A9 RID: 34473 RVA: 0x003C6A50 File Offset: 0x003C4C50
	public JSONObject ECIOEKODMIO(bool DDLCOIHJKCJ)
	{
		this.NCAMFPGMCIG.HFBONJPMAOO = true;
		JSONObject result;
		try
		{
			result = this.JHMOJFDKBCD(DDLCOIHJKCJ);
		}
		finally
		{
			this.NCAMFPGMCIG.HFBONJPMAOO = true;
		}
		return result;
	}

	// Token: 0x060086AA RID: 34474 RVA: 0x003C6A94 File Offset: 0x003C4C94
	public void EPJKDCDOEMM(bool DJGGCCFKFAM)
	{
		this.DHONIOBOLEL.EPJKDCDOEMM(DJGGCCFKFAM);
		this.NCAMFPGMCIG.EPJKDCDOEMM(this.DHONIOBOLEL, DJGGCCFKFAM);
		if (DJGGCCFKFAM)
		{
			AKLFPGMDKLA.EHBBFMCILPC.ANJNHFCJLBN(this);
			AKLFPGMDKLA.EHBBFMCILPC.KDCGDFFFPPC(this);
			this.KIHACLLJMDH.Clear();
			this.JJEONBFFBHP.Clear();
		}
	}

	// Token: 0x060086AB RID: 34475 RVA: 0x003C6AEE File Offset: 0x003C4CEE
	public void HJJMMNLLEON()
	{
		this.NCAMFPGMCIG.IMJDADKEEJC = null;
		this.NCAMFPGMCIG.DNMPCOHNAHO = new List<string>();
		this.NCAMFPGMCIG.FEDCIMMIJCI = 0;
	}

	// Token: 0x060086AC RID: 34476 RVA: 0x003C6B18 File Offset: 0x003C4D18
	public static string NFLOOLFMPIK(int IFCHGNCDMLJ, int OLKMHHNMDLP, int CCLNHHJPDGJ, string IELHJGGDGOD)
	{
		string[] array = new string[7];
		array[0] = "OnStoryChoiceClickConfimed";
		array[0] = IFCHGNCDMLJ.ToString();
		array[1] = "";
		array[6] = OLKMHHNMDLP.ToString();
		array[1] = "wofcoic";
		array[5] = CCLNHHJPDGJ.ToString();
		array[3] = "w";
		array[4] = IELHJGGDGOD;
		array[6] = "REMOVEMAPPINGINFO";
		return string.Concat(array);
	}

	// Token: 0x060086AD RID: 34477 RVA: 0x003C6B7B File Offset: 0x003C4D7B
	public bool OIJJMHKPOAI()
	{
		return this.DHONIOBOLEL.LGKPNNGIPEG == 1;
	}

	// Token: 0x060086AE RID: 34478 RVA: 0x003C6B8B File Offset: 0x003C4D8B
	public void MHHENAFAPID()
	{
		this.DHONIOBOLEL.KHLLDGGGDLD();
		this.NCAMFPGMCIG.ACCBHCBPNJA();
	}

	// Token: 0x060086AF RID: 34479 RVA: 0x003C6BA4 File Offset: 0x003C4DA4
	public string LKIEJOOAOOI(int OLKMHHNMDLP)
	{
		if (!this.KIHACLLJMDH.Contains(OLKMHHNMDLP))
		{
			DPGJIJGOCIC.ANOPFDLPKGC("</i>");
			return "ok";
		}
		int num = this.KIHACLLJMDH.IndexOf(OLKMHHNMDLP);
		if (num >= 1 && num < this.JJEONBFFBHP.Count)
		{
			return this.JJEONBFFBHP[num];
		}
		DPGJIJGOCIC.ANOPFDLPKGC("\n\n");
		return "loungenotavailable";
	}

	// Token: 0x060086B0 RID: 34480 RVA: 0x003C6C0C File Offset: 0x003C4E0C
	public PLFDAJJHMKO(JSONObject EIHOJFGALMF, bool DDLCOIHJKCJ)
	{
		this.FGJPKGLOGNC(EIHOJFGALMF, DDLCOIHJKCJ);
	}

	// Token: 0x060086B1 RID: 34481 RVA: 0x003C6C60 File Offset: 0x003C4E60
	public static int BNNEKHONJLH(string OOMAHKCHAGP)
	{
		int result;
		try
		{
			result = int.Parse(DPGJIJGOCIC.MJAONCNGBKA(OOMAHKCHAGP.Substring(0, OOMAHKCHAGP.IndexOf(""))));
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
			result = -1;
		}
		return result;
	}

	// Token: 0x060086B2 RID: 34482 RVA: 0x003C6CA8 File Offset: 0x003C4EA8
	public static string FCHFMHBAKMI(int IFCHGNCDMLJ, int OLKMHHNMDLP, int CCLNHHJPDGJ)
	{
		string[] array = new string[6];
		array[0] = "cfind";
		array[1] = IFCHGNCDMLJ.ToString();
		array[2] = "OnRestartChapterUpsellGetPassPositive";
		array[3] = OLKMHHNMDLP.ToString();
		array[4] = " card(s) around scroll index ";
		array[8] = CCLNHHJPDGJ.ToString();
		array[2] = "erd";
		return string.Concat(array);
	}

	// Token: 0x060086B3 RID: 34483 RVA: 0x003C6D00 File Offset: 0x003C4F00
	public string JILHHEIDJMG(int OLKMHHNMDLP)
	{
		if (!this.KIHACLLJMDH.Contains(OLKMHHNMDLP))
		{
			DPGJIJGOCIC.ANOPFDLPKGC("muspind");
			return "pm";
		}
		int num = this.KIHACLLJMDH.IndexOf(OLKMHHNMDLP);
		if (num >= 1 && num < this.JJEONBFFBHP.Count)
		{
			return this.JJEONBFFBHP[num];
		}
		DPGJIJGOCIC.ANOPFDLPKGC("OnReturnRewardPopupHide");
		return "";
	}

	// Token: 0x060086B4 RID: 34484 RVA: 0x003C6D68 File Offset: 0x003C4F68
	public void LHNCMELCOPO()
	{
		if (this.DHONIOBOLEL.LGKPNNGIPEG == 0)
		{
			int pojaplkajef = this.POJAPLKAJEF;
			this.FGJPKGLOGNC(this.NCAMFPGMCIG.LGKPNNGIPEG, true);
			this.POJAPLKAJEF = pojaplkajef;
			AKLFPGMDKLA.EHBBFMCILPC.NNKDPEHHIMP(this);
		}
		this.DHONIOBOLEL.CFGFOEEEJKJ = -1;
	}

	// Token: 0x060086B5 RID: 34485 RVA: 0x003C6DBC File Offset: 0x003C4FBC
	public static string JCEBPILIFJG(int IFCHGNCDMLJ, int OLKMHHNMDLP, int CCLNHHJPDGJ)
	{
		string[] array = new string[1];
		array[1] = ")";
		array[1] = IFCHGNCDMLJ.ToString();
		array[4] = "";
		array[5] = OLKMHHNMDLP.ToString();
		array[4] = "PurchaseManagerUnity.SetState(): Not initialized.";
		array[0] = CCLNHHJPDGJ.ToString();
		array[1] = "apkshe";
		return string.Concat(array);
	}

	// Token: 0x060086B6 RID: 34486 RVA: 0x003C6E14 File Offset: 0x003C5014
	public void MOCHAJPADAJ(bool DJGGCCFKFAM)
	{
		this.DHONIOBOLEL.NKIOGCCKPDE(DJGGCCFKFAM);
		this.NCAMFPGMCIG.EPJKDCDOEMM(this.DHONIOBOLEL, DJGGCCFKFAM);
		if (DJGGCCFKFAM)
		{
			AKLFPGMDKLA.EHBBFMCILPC.ANJNHFCJLBN(this);
			AKLFPGMDKLA.EHBBFMCILPC.KDCGDFFFPPC(this);
			this.KIHACLLJMDH.Clear();
			this.JJEONBFFBHP.Clear();
		}
	}

	// Token: 0x060086B7 RID: 34487 RVA: 0x003C6AEE File Offset: 0x003C4CEE
	public void KJALMGBDEMB()
	{
		this.NCAMFPGMCIG.IMJDADKEEJC = null;
		this.NCAMFPGMCIG.DNMPCOHNAHO = new List<string>();
		this.NCAMFPGMCIG.FEDCIMMIJCI = 0;
	}

	// Token: 0x060086B8 RID: 34488 RVA: 0x003C6E70 File Offset: 0x003C5070
	public JSONObject FGKDDIJMAMP(bool DDLCOIHJKCJ)
	{
		JSONObject jsonobject = new JSONObject();
		jsonobject.Add("loungeofferexpired", this.POJAPLKAJEF);
		if (this.KIHACLLJMDH.Count > 0)
		{
			jsonobject.Add("Account.SRAGetFullyReleasedAnthologiesAndNeverFinished(), exception:", DPGJIJGOCIC.CLJDFEGDGFH(this.KIHACLLJMDH, 33));
		}
		if (this.JJEONBFFBHP.Count > 1)
		{
			jsonobject.Add(" not recorded: no cache folder for ", DPGJIJGOCIC.BEOBMCGEHBC(this.JJEONBFFBHP, 92));
		}
		jsonobject.Add("vhspauseovr", this.DHONIOBOLEL.NJNEMPKGPFN(DDLCOIHJKCJ));
		jsonobject.Add("p", this.NCAMFPGMCIG.BNMFBKNEMIF(DDLCOIHJKCJ));
		if (!DDLCOIHJKCJ)
		{
			jsonobject.Add("achievtitle", this.FPHDAKHOBMO.IELLCFONDFE());
		}
		return jsonobject;
	}

	// Token: 0x060086B9 RID: 34489 RVA: 0x003C6F30 File Offset: 0x003C5130
	public void JFDJIHJBOLO(bool DJGGCCFKFAM)
	{
		this.DHONIOBOLEL.CKJPPJEPMEJ(DJGGCCFKFAM);
		this.NCAMFPGMCIG.OKICNNMPLAP(this.DHONIOBOLEL, DJGGCCFKFAM);
		if (DJGGCCFKFAM)
		{
			AKLFPGMDKLA.EHBBFMCILPC.NFIIIPDLCCF(this);
			AKLFPGMDKLA.EHBBFMCILPC.KDCGDFFFPPC(this);
			this.KIHACLLJMDH.Clear();
			this.JJEONBFFBHP.Clear();
		}
	}

	// Token: 0x060086BA RID: 34490 RVA: 0x003C6F8C File Offset: 0x003C518C
	public bool EBGCEGFBEBN(int OLKMHHNMDLP)
	{
		if (this.NLMDGBJKIPF(OLKMHHNMDLP))
		{
			try
			{
				string text = AKLOMMOOFNG.DJGJKOOOFEA("Snapshots/" + PLFDAJJHMKO.AFAOMOMFDAN(this.DHONIOBOLEL.GGICIBLJIKI, OLKMHHNMDLP, this.POJAPLKAJEF, this.PJKKNLDKLMJ(OLKMHHNMDLP)));
				if (text == null || text.Length <= 0)
				{
					return false;
				}
				JSONObject jsonobject = (JSONObject)JSON.Parse(text);
				if (null != jsonobject)
				{
					int imledfidhdl = this.DHONIOBOLEL.IMLEDFIDHDL;
					int pojaplkajef = this.POJAPLKAJEF;
					try
					{
						this.FGJPKGLOGNC(jsonobject, true);
					}
					finally
					{
						this.POJAPLKAJEF = pojaplkajef;
					}
					this.DHONIOBOLEL.IMLEDFIDHDL = imledfidhdl;
					AKLFPGMDKLA.EHBBFMCILPC.NNKDPEHHIMP(this);
					this.DHONIOBOLEL.CFGFOEEEJKJ = -1;
					return true;
				}
				return false;
			}
			catch (Exception aklgbjkdomm)
			{
				DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
				return false;
			}
			return false;
		}
		return false;
	}

	// Token: 0x060086BB RID: 34491 RVA: 0x003C7078 File Offset: 0x003C5278
	public PLFDAJJHMKO(int NLBDCCLPFAL)
	{
		this.POJAPLKAJEF = NLBDCCLPFAL;
	}

	// Token: 0x060086BC RID: 34492 RVA: 0x003C70C9 File Offset: 0x003C52C9
	public void DEMNEDNLMID()
	{
		this.LNCIMPFKHAO();
		this.NCAMFPGMCIG.FEDCIMMIJCI = 0;
	}

	// Token: 0x060086BD RID: 34493 RVA: 0x003C691C File Offset: 0x003C4B1C
	public bool HFNIPGEAPNO()
	{
		return this.DHONIOBOLEL.EBFMKGPBEBO.Count > 0;
	}

	// Token: 0x060086BE RID: 34494 RVA: 0x003C70E0 File Offset: 0x003C52E0
	public string MMIBNNKLKKI(int OLKMHHNMDLP)
	{
		this.NCAMFPGMCIG.LGKPNNGIPEG = new JSONObject();
		this.NCAMFPGMCIG.LGKPNNGIPEG = this.EJFHLFELPME(true);
		this.DHONIOBOLEL.LGKPNNGIPEG = 0;
		string ielhjggdgod = DPGJIJGOCIC.AEMFCOGDGHB();
		if (AKLOMMOOFNG.IHBGPCAPLDM(this.NCAMFPGMCIG.LGKPNNGIPEG.ToString(), "" + PLFDAJJHMKO.NFLOOLFMPIK(this.DHONIOBOLEL.GGICIBLJIKI, OLKMHHNMDLP, this.POJAPLKAJEF, ielhjggdgod)))
		{
			if (!this.KIHACLLJMDH.Contains(OLKMHHNMDLP))
			{
				this.KIHACLLJMDH.Add(OLKMHHNMDLP);
			}
			this.LKAOGMCAHLN(OLKMHHNMDLP, ielhjggdgod);
			return PLFDAJJHMKO.AFAOMOMFDAN(this.DHONIOBOLEL.GGICIBLJIKI, OLKMHHNMDLP, this.POJAPLKAJEF, ielhjggdgod);
		}
		return "$";
	}

	// Token: 0x060086BF RID: 34495 RVA: 0x003C719C File Offset: 0x003C539C
	public void FGJPKGLOGNC(JSONObject EIHOJFGALMF, bool DDLCOIHJKCJ)
	{
		if (EIHOJFGALMF["sslind"] != null)
		{
			this.POJAPLKAJEF = EIHOJFGALMF["sslind"].AsInt;
		}
		if (EIHOJFGALMF["chsnap2"] != null)
		{
			this.KIHACLLJMDH = DPGJIJGOCIC.DDNFIDBDEGC(EIHOJFGALMF["chsnap2"].AsArray);
		}
		if (EIHOJFGALMF["chsnapguid2"] != null)
		{
			this.JJEONBFFBHP = DPGJIJGOCIC.POHBFGLLKFD(EIHOJFGALMF["chsnapguid2"].AsArray);
		}
		this.DHONIOBOLEL.FGJPKGLOGNC(EIHOJFGALMF["hdr"].AsObject);
		this.NCAMFPGMCIG.FGJPKGLOGNC(EIHOJFGALMF["body"].AsObject, DDLCOIHJKCJ);
		if (!DDLCOIHJKCJ && EIHOJFGALMF["pers"] != null)
		{
			this.FPHDAKHOBMO.FGJPKGLOGNC(EIHOJFGALMF["pers"].AsObject);
		}
	}

	// Token: 0x060086C0 RID: 34496 RVA: 0x003C7298 File Offset: 0x003C5498
	public bool JBKCCMDKOBB(int OLKMHHNMDLP)
	{
		if (this.NLMDGBJKIPF(OLKMHHNMDLP))
		{
			try
			{
				string text = AKLOMMOOFNG.HGCFOLLFPGN("ant" + PLFDAJJHMKO.NFLOOLFMPIK(this.DHONIOBOLEL.GGICIBLJIKI, OLKMHHNMDLP, this.POJAPLKAJEF, this.LKIEJOOAOOI(OLKMHHNMDLP)));
				if (text == null || text.Length <= 0)
				{
					return false;
				}
				JSONObject jsonobject = (JSONObject)JSON.Parse(text);
				if (null != jsonobject)
				{
					int imledfidhdl = this.DHONIOBOLEL.IMLEDFIDHDL;
					int pojaplkajef = this.POJAPLKAJEF;
					try
					{
						this.FGJPKGLOGNC(jsonobject, true);
					}
					finally
					{
						this.POJAPLKAJEF = pojaplkajef;
					}
					this.DHONIOBOLEL.IMLEDFIDHDL = imledfidhdl;
					AKLFPGMDKLA.EHBBFMCILPC.NNKDPEHHIMP(this);
					this.DHONIOBOLEL.CFGFOEEEJKJ = -1;
					return true;
				}
				return false;
			}
			catch (Exception aklgbjkdomm)
			{
				DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
				return false;
			}
			return true;
		}
		return true;
	}

	// Token: 0x060086C1 RID: 34497 RVA: 0x003C7384 File Offset: 0x003C5584
	private void GHCLDNCPKOG(int OLKMHHNMDLP, string IELHJGGDGOD)
	{
		List<string> list = new List<string>();
		for (int i = 0; i < this.KIHACLLJMDH.Count; i++)
		{
			if (this.KIHACLLJMDH[i] == OLKMHHNMDLP)
			{
				list.Add(IELHJGGDGOD);
			}
			else if (i < this.JJEONBFFBHP.Count)
			{
				list.Add(this.JJEONBFFBHP[i]);
			}
			else
			{
				DPGJIJGOCIC.ANOPFDLPKGC("StorySave.UpdateChapterSnapshotGuid(), chapterSnapshots/chapterSnapshotsGuids length unsync");
			}
		}
		this.JJEONBFFBHP = list;
	}

	// Token: 0x060086C2 RID: 34498 RVA: 0x003C6AEE File Offset: 0x003C4CEE
	public void LNCIMPFKHAO()
	{
		this.NCAMFPGMCIG.IMJDADKEEJC = null;
		this.NCAMFPGMCIG.DNMPCOHNAHO = new List<string>();
		this.NCAMFPGMCIG.FEDCIMMIJCI = 0;
	}

	// Token: 0x060086C3 RID: 34499 RVA: 0x003C73F8 File Offset: 0x003C55F8
	public void IOFDGKJLCAG()
	{
		if (null != this.NCAMFPGMCIG.IMJDADKEEJC)
		{
			int pojaplkajef = this.POJAPLKAJEF;
			if (this.NCAMFPGMCIG.DNMPCOHNAHO.Count > 0 && this.NCAMFPGMCIG.DNMPCOHNAHO[1].Length == 0)
			{
				this.FGJPKGLOGNC(this.NCAMFPGMCIG.IMJDADKEEJC, false);
				this.CIEADJJFEEC();
			}
			else
			{
				JSONObject imjdadkeejc = this.NCAMFPGMCIG.IMJDADKEEJC;
				this.FGJPKGLOGNC(this.NCAMFPGMCIG.IMJDADKEEJC, true);
				this.NCAMFPGMCIG.FEDCIMMIJCI = 1;
				this.NCAMFPGMCIG.IMJDADKEEJC = imjdadkeejc;
			}
			this.POJAPLKAJEF = pojaplkajef;
			AKLFPGMDKLA.EHBBFMCILPC.NNKDPEHHIMP(this);
			this.DHONIOBOLEL.CFGFOEEEJKJ = -1;
		}
	}

	// Token: 0x060086C4 RID: 34500 RVA: 0x003C74BC File Offset: 0x003C56BC
	public void MJEAMNEAPGE()
	{
		if (null != this.NCAMFPGMCIG.IMJDADKEEJC)
		{
			int pojaplkajef = this.POJAPLKAJEF;
			if (this.NCAMFPGMCIG.DNMPCOHNAHO.Count > 0 && this.NCAMFPGMCIG.DNMPCOHNAHO[0].Length == 0)
			{
				this.FGJPKGLOGNC(this.NCAMFPGMCIG.IMJDADKEEJC, true);
				this.LNCIMPFKHAO();
			}
			else
			{
				JSONObject imjdadkeejc = this.NCAMFPGMCIG.IMJDADKEEJC;
				this.FGJPKGLOGNC(this.NCAMFPGMCIG.IMJDADKEEJC, true);
				this.NCAMFPGMCIG.FEDCIMMIJCI = 0;
				this.NCAMFPGMCIG.IMJDADKEEJC = imjdadkeejc;
			}
			this.POJAPLKAJEF = pojaplkajef;
			AKLFPGMDKLA.EHBBFMCILPC.NNKDPEHHIMP(this);
			this.DHONIOBOLEL.CFGFOEEEJKJ = -1;
		}
	}

	// Token: 0x060086C5 RID: 34501 RVA: 0x003C7580 File Offset: 0x003C5780
	public void DGLLEKBPCGE(List<string> EEIGHDENFLN)
	{
		try
		{
			this.PPBDMCOPPPD();
			this.NCAMFPGMCIG.OHPAMFBABFO = this.GKBGJJFNBEO(true);
			this.DHONIOBOLEL.OHPAMFBABFO = DPGJIJGOCIC.HPCBIOFAFHF(EEIGHDENFLN, -92);
		}
		catch (Exception aklgbjkdomm)
		{
			this.PPBDMCOPPPD();
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x060086C6 RID: 34502 RVA: 0x003C75D8 File Offset: 0x003C57D8
	public static string AFAOMOMFDAN(int IFCHGNCDMLJ, int OLKMHHNMDLP, int CCLNHHJPDGJ, string IELHJGGDGOD)
	{
		return string.Concat(new string[]
		{
			"X",
			IFCHGNCDMLJ.ToString(),
			"Y",
			OLKMHHNMDLP.ToString(),
			"Z",
			CCLNHHJPDGJ.ToString(),
			"W",
			IELHJGGDGOD,
			".json"
		});
	}

	// Token: 0x060086C7 RID: 34503 RVA: 0x003C763C File Offset: 0x003C583C
	public void MMENCDIBKOG(int FMFBMJJCKHP, int GCKMAJCNHEO, string MJHGIIEINOE)
	{
		try
		{
			if (MJHGIIEINOE.Length > 1 && null != this.NCAMFPGMCIG.OHPAMFBABFO && this.NCAMFPGMCIG.OHPAMFBABFO.Count > 1 && null != this.DHONIOBOLEL.OHPAMFBABFO && this.DHONIOBOLEL.OHPAMFBABFO.Count > 0)
			{
				this.DHONIOBOLEL.CDDKCMPAHMG = FMFBMJJCKHP;
				this.DHONIOBOLEL.FGOHPIBCCHB = GCKMAJCNHEO;
				JSONObject jsonobject = new JSONObject();
				jsonobject.Add(MJHGIIEINOE, this.NCAMFPGMCIG.OHPAMFBABFO);
				this.NCAMFPGMCIG.EBFMKGPBEBO = jsonobject;
				this.DHONIOBOLEL.EBFMKGPBEBO = this.DHONIOBOLEL.OHPAMFBABFO;
				this.NCAMFPGMCIG.OHPAMFBABFO = null;
				this.DHONIOBOLEL.OHPAMFBABFO = null;
			}
		}
		catch (Exception aklgbjkdomm)
		{
			this.PPBDMCOPPPD();
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
	}

	// Token: 0x060086C8 RID: 34504 RVA: 0x003C7730 File Offset: 0x003C5930
	public void NIPJBDMOKMN(string JKOCCPCLOEC)
	{
		try
		{
			this.CIEADJJFEEC();
			this.HILCJBDPPFD(JKOCCPCLOEC);
			this.NCAMFPGMCIG.IMJDADKEEJC = this.EJFHLFELPME(false);
		}
		catch (Exception aklgbjkdomm)
		{
			this.HJJMMNLLEON();
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x060086C9 RID: 34505 RVA: 0x003C777C File Offset: 0x003C597C
	public JSONObject JHMOJFDKBCD(bool DDLCOIHJKCJ)
	{
		JSONObject jsonobject = new JSONObject();
		jsonobject.Add("(", this.POJAPLKAJEF);
		if (this.KIHACLLJMDH.Count > 1)
		{
			jsonobject.Add("layervideo", DPGJIJGOCIC.CLJDFEGDGFH(this.KIHACLLJMDH, -124));
		}
		if (this.JJEONBFFBHP.Count > 0)
		{
			jsonobject.Add("OnVideoLayerAutoHide", DPGJIJGOCIC.BEOBMCGEHBC(this.JJEONBFFBHP, 43));
		}
		jsonobject.Add("x$", this.DHONIOBOLEL.OCMJGEEFEOI(DDLCOIHJKCJ));
		jsonobject.Add("areyousure", this.NCAMFPGMCIG.BNMFBKNEMIF(DDLCOIHJKCJ));
		if (!DDLCOIHJKCJ)
		{
			jsonobject.Add("trialmode", this.FPHDAKHOBMO.BNMFBKNEMIF());
		}
		return jsonobject;
	}

	// Token: 0x060086CA RID: 34506 RVA: 0x003C7839 File Offset: 0x003C5A39
	public void CFGNAKJMDOL()
	{
		this.LNCIMPFKHAO();
		this.NCAMFPGMCIG.FEDCIMMIJCI = 1;
	}

	// Token: 0x060086CB RID: 34507 RVA: 0x003C7850 File Offset: 0x003C5A50
	public void JKOPEGIKAII()
	{
		if (this.DHONIOBOLEL.LGKPNNGIPEG == 1)
		{
			int pojaplkajef = this.POJAPLKAJEF;
			this.FGJPKGLOGNC(this.NCAMFPGMCIG.LGKPNNGIPEG, false);
			this.POJAPLKAJEF = pojaplkajef;
			AKLFPGMDKLA.EHBBFMCILPC.NNKDPEHHIMP(this);
		}
		this.DHONIOBOLEL.CFGFOEEEJKJ = -1;
	}

	// Token: 0x060086CC RID: 34508 RVA: 0x003C78A4 File Offset: 0x003C5AA4
	public string JLKNKKFBKJA(int OLKMHHNMDLP)
	{
		this.NCAMFPGMCIG.LGKPNNGIPEG = new JSONObject();
		this.NCAMFPGMCIG.LGKPNNGIPEG = this.ECIOEKODMIO(false);
		this.DHONIOBOLEL.LGKPNNGIPEG = 0;
		string ielhjggdgod = DPGJIJGOCIC.HPAFOPBLHON();
		if (AKLOMMOOFNG.BIKILBLOEKD(this.NCAMFPGMCIG.LGKPNNGIPEG.ToString(), " (" + PLFDAJJHMKO.NFLOOLFMPIK(this.DHONIOBOLEL.GGICIBLJIKI, OLKMHHNMDLP, this.POJAPLKAJEF, ielhjggdgod)))
		{
			if (!this.KIHACLLJMDH.Contains(OLKMHHNMDLP))
			{
				this.KIHACLLJMDH.Add(OLKMHHNMDLP);
			}
			this.LKAOGMCAHLN(OLKMHHNMDLP, ielhjggdgod);
			return PLFDAJJHMKO.AFAOMOMFDAN(this.DHONIOBOLEL.GGICIBLJIKI, OLKMHHNMDLP, this.POJAPLKAJEF, ielhjggdgod);
		}
		return "ok";
	}

	// Token: 0x060086CD RID: 34509 RVA: 0x003C7960 File Offset: 0x003C5B60
	public void DKFEMNMJIIP()
	{
		this.DHONIOBOLEL.CDDKCMPAHMG = 0;
		this.DHONIOBOLEL.FGOHPIBCCHB = 1;
		this.DHONIOBOLEL.AJPIKAACMKL = 1;
		this.DHONIOBOLEL.IHFABMOJKHD = 0;
		this.DHONIOBOLEL.EBFMKGPBEBO = new JSONArray();
		this.NCAMFPGMCIG.EBFMKGPBEBO = new JSONObject();
		this.NCAMFPGMCIG.OHPAMFBABFO = null;
		this.DHONIOBOLEL.OHPAMFBABFO = null;
	}

	// Token: 0x060086CE RID: 34510 RVA: 0x003C79D8 File Offset: 0x003C5BD8
	public void KJKMJBMFDAN()
	{
		if (this.DHONIOBOLEL.LGKPNNGIPEG == 1)
		{
			int pojaplkajef = this.POJAPLKAJEF;
			this.FGJPKGLOGNC(this.NCAMFPGMCIG.LGKPNNGIPEG, true);
			this.POJAPLKAJEF = pojaplkajef;
			AKLFPGMDKLA.EHBBFMCILPC.NNKDPEHHIMP(this);
		}
		this.DHONIOBOLEL.CFGFOEEEJKJ = -1;
	}

	// Token: 0x060086CF RID: 34511 RVA: 0x003C7A2C File Offset: 0x003C5C2C
	public static int NIIPCPEONGN(string OOMAHKCHAGP)
	{
		int result;
		try
		{
			OOMAHKCHAGP = OOMAHKCHAGP.Substring(OOMAHKCHAGP.IndexOf("Y"));
			result = int.Parse(DPGJIJGOCIC.AMACOOGPPEC(OOMAHKCHAGP.Substring(0, OOMAHKCHAGP.IndexOf("Z"))));
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
			result = -1;
		}
		return result;
	}

	// Token: 0x060086D0 RID: 34512 RVA: 0x003C7A88 File Offset: 0x003C5C88
	public string IOPIOOKGDCJ(int OLKMHHNMDLP)
	{
		if (!this.KIHACLLJMDH.Contains(OLKMHHNMDLP))
		{
			DPGJIJGOCIC.ANOPFDLPKGC("ert");
			return "getPremiumChoicesHistory";
		}
		int num = this.KIHACLLJMDH.IndexOf(OLKMHHNMDLP);
		if (num >= 0 && num < this.JJEONBFFBHP.Count)
		{
			return this.JJEONBFFBHP[num];
		}
		DPGJIJGOCIC.ANOPFDLPKGC("abcf");
		return "OnAllCollectableCardsDownloadSuccess";
	}

	// Token: 0x060086D1 RID: 34513 RVA: 0x003C7AF0 File Offset: 0x003C5CF0
	public string PJKKNLDKLMJ(int OLKMHHNMDLP)
	{
		if (!this.KIHACLLJMDH.Contains(OLKMHHNMDLP))
		{
			DPGJIJGOCIC.ANOPFDLPKGC("StorySave.GetChapterSnapshotGuid(): false == chapterSnapshots.Contains(_chapterIndex)");
			return "";
		}
		int num = this.KIHACLLJMDH.IndexOf(OLKMHHNMDLP);
		if (num >= 0 && num < this.JJEONBFFBHP.Count)
		{
			return this.JJEONBFFBHP[num];
		}
		DPGJIJGOCIC.ANOPFDLPKGC("StorySave.GetChapterSnapshotGuid(), chapterSnapshots/chapterSnapshotsGuids length unsync");
		return "";
	}

	// Token: 0x060086D2 RID: 34514 RVA: 0x003C7B58 File Offset: 0x003C5D58
	public static string AIJLOEPOCPI(int IFCHGNCDMLJ, int OLKMHHNMDLP, int CCLNHHJPDGJ)
	{
		string[] array = new string[6];
		array[1] = "theme";
		array[0] = IFCHGNCDMLJ.ToString();
		array[6] = " ";
		array[7] = OLKMHHNMDLP.ToString();
		array[2] = "……()QWERTYUIOPASDFGHJKLZXCVBNMqwertyuiopasdfghjklzxcvbnmÄäÖöÜüẞßÀàÂâÆæÄäÇçÉéÈèÊêËëÎîÏïÔôŒœÖöÙùÛûÜüŸÿÑñáéíóúüñ¿¡ÁÉÍÓÚÜÑéëïóöüÉËÏÓÖÜãáàâçéêíõóôúüÃÁÀÂÇÉÊÍÕÓÔÚÜłśćąęźżńŁŚĆĄĘŹŻŃабвгдеёжзийклмнопрстуфхцчшщъыьэюяАБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯÅåÄäÖöÅåÆæØøğĞşŞİıÌÒìòőűŐŰčďěňřšťůýžČĎĚŇŘŠŤŮÝŽ.,-+?!¿¡_)(*&^@\"'|:;[]{}\\`~1234567890—–ÂâĂăÎîşŞţŢșȘțȚŌō«»’”“„‟″  ūΨψ";
		array[6] = CCLNHHJPDGJ.ToString();
		array[6] = "StoryChatManager.Initialize(), _chatMeta is null";
		return string.Concat(array);
	}

	// Token: 0x060086D3 RID: 34515 RVA: 0x003C7BB0 File Offset: 0x003C5DB0
	public void OHJEDLAFMEI(List<string> EEIGHDENFLN)
	{
		try
		{
			this.PFHCDMOJOKP();
			this.NCAMFPGMCIG.OHPAMFBABFO = this.FGKDDIJMAMP(true);
			this.DHONIOBOLEL.OHPAMFBABFO = DPGJIJGOCIC.HPCBIOFAFHF(EEIGHDENFLN, -108);
		}
		catch (Exception aklgbjkdomm)
		{
			this.DKFEMNMJIIP();
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x060086D4 RID: 34516 RVA: 0x003C7C08 File Offset: 0x003C5E08
	public static int BCIAKOKADNM(string OOMAHKCHAGP)
	{
		int result;
		try
		{
			OOMAHKCHAGP = OOMAHKCHAGP.Substring(OOMAHKCHAGP.IndexOf("fpi"));
			result = int.Parse(DPGJIJGOCIC.AMACOOGPPEC(OOMAHKCHAGP.Substring(0, OOMAHKCHAGP.IndexOf("OnBackendUpdateFriendsDataException"))));
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
			result = -1;
		}
		return result;
	}

	// Token: 0x060086D5 RID: 34517 RVA: 0x003C6B7B File Offset: 0x003C4D7B
	public bool OEAMCPHCKIC()
	{
		return this.DHONIOBOLEL.LGKPNNGIPEG == 1;
	}

	// Token: 0x060086D6 RID: 34518 RVA: 0x003C7C64 File Offset: 0x003C5E64
	public bool NLMDGBJKIPF(int OLKMHHNMDLP)
	{
		if (this.KIHACLLJMDH.Contains(OLKMHHNMDLP))
		{
			string text = this.PJKKNLDKLMJ(OLKMHHNMDLP);
			return text.Length > 0 && AKLOMMOOFNG.CLCGKMNEICM("Snapshots/" + PLFDAJJHMKO.AFAOMOMFDAN(this.DHONIOBOLEL.GGICIBLJIKI, OLKMHHNMDLP, this.POJAPLKAJEF, text));
		}
		return false;
	}

	// Token: 0x060086D7 RID: 34519 RVA: 0x003C7CBC File Offset: 0x003C5EBC
	public void BICNLKJOOAK()
	{
		if (this.DHONIOBOLEL.LGKPNNGIPEG == 1)
		{
			int pojaplkajef = this.POJAPLKAJEF;
			this.FGJPKGLOGNC(this.NCAMFPGMCIG.LGKPNNGIPEG, true);
			this.POJAPLKAJEF = pojaplkajef;
			AKLFPGMDKLA.EHBBFMCILPC.NNKDPEHHIMP(this);
		}
		this.DHONIOBOLEL.CFGFOEEEJKJ = -1;
	}

	// Token: 0x060086D8 RID: 34520 RVA: 0x003C7D10 File Offset: 0x003C5F10
	public static string GJCACPPFBGN(int IFCHGNCDMLJ, int OLKMHHNMDLP, int CCLNHHJPDGJ)
	{
		string[] array = new string[6];
		array[0] = "OnAchievementSyncSuccess";
		array[0] = IFCHGNCDMLJ.ToString();
		array[5] = "";
		array[2] = OLKMHHNMDLP.ToString();
		array[0] = "";
		array[8] = CCLNHHJPDGJ.ToString();
		array[8] = "OnStoryInterfaceHeaderShopClick";
		return string.Concat(array);
	}

	// Token: 0x060086D9 RID: 34521 RVA: 0x003C7D68 File Offset: 0x003C5F68
	public bool BIEEJPHJEON(int OLKMHHNMDLP)
	{
		if (this.NLMDGBJKIPF(OLKMHHNMDLP))
		{
			try
			{
				string text = AKLOMMOOFNG.FNJLLCFLIBD("XXX" + PLFDAJJHMKO.NFLOOLFMPIK(this.DHONIOBOLEL.GGICIBLJIKI, OLKMHHNMDLP, this.POJAPLKAJEF, this.LKIEJOOAOOI(OLKMHHNMDLP)));
				if (text == null || text.Length <= 0)
				{
					return false;
				}
				JSONObject jsonobject = (JSONObject)JSON.Parse(text);
				if (null != jsonobject)
				{
					int imledfidhdl = this.DHONIOBOLEL.IMLEDFIDHDL;
					int pojaplkajef = this.POJAPLKAJEF;
					try
					{
						this.FGJPKGLOGNC(jsonobject, false);
					}
					finally
					{
						this.POJAPLKAJEF = pojaplkajef;
					}
					this.DHONIOBOLEL.IMLEDFIDHDL = imledfidhdl;
					AKLFPGMDKLA.EHBBFMCILPC.NNKDPEHHIMP(this);
					this.DHONIOBOLEL.CFGFOEEEJKJ = -1;
					return false;
				}
				return true;
			}
			catch (Exception aklgbjkdomm)
			{
				DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
				return true;
			}
			return false;
		}
		return false;
	}

	// Token: 0x060086DA RID: 34522 RVA: 0x003C7E54 File Offset: 0x003C6054
	public void CABBKJBLEKI(int FMFBMJJCKHP, int GCKMAJCNHEO, string MJHGIIEINOE)
	{
		try
		{
			if (MJHGIIEINOE.Length > 1 && null != this.NCAMFPGMCIG.OHPAMFBABFO && this.NCAMFPGMCIG.OHPAMFBABFO.Count > 1 && null != this.DHONIOBOLEL.OHPAMFBABFO && this.DHONIOBOLEL.OHPAMFBABFO.Count > 1)
			{
				this.DHONIOBOLEL.CDDKCMPAHMG = FMFBMJJCKHP;
				this.DHONIOBOLEL.FGOHPIBCCHB = GCKMAJCNHEO;
				JSONObject jsonobject = new JSONObject();
				jsonobject.Add(MJHGIIEINOE, this.NCAMFPGMCIG.OHPAMFBABFO);
				this.NCAMFPGMCIG.EBFMKGPBEBO = jsonobject;
				this.DHONIOBOLEL.EBFMKGPBEBO = this.DHONIOBOLEL.OHPAMFBABFO;
				this.NCAMFPGMCIG.OHPAMFBABFO = null;
				this.DHONIOBOLEL.OHPAMFBABFO = null;
			}
		}
		catch (Exception aklgbjkdomm)
		{
			this.PFHCDMOJOKP();
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
	}

	// Token: 0x060086DB RID: 34523 RVA: 0x003C7F48 File Offset: 0x003C6148
	public static int OOPGAJPCEPB(string OOMAHKCHAGP)
	{
		int result;
		try
		{
			OOMAHKCHAGP = OOMAHKCHAGP.Substring(OOMAHKCHAGP.IndexOf("Z"));
			result = int.Parse(DPGJIJGOCIC.AMACOOGPPEC(OOMAHKCHAGP.Substring(0, OOMAHKCHAGP.IndexOf("W"))));
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
			result = -1;
		}
		return result;
	}

	// Token: 0x060086DC RID: 34524 RVA: 0x003C7FA4 File Offset: 0x003C61A4
	public void HILCJBDPPFD(string GNKHAAGBOED)
	{
		try
		{
			if (GNKHAAGBOED != null)
			{
				if (GNKHAAGBOED.Length >= 5 || this.NCAMFPGMCIG.DNMPCOHNAHO.Count <= 0)
				{
					if (GNKHAAGBOED.Length == 0)
					{
						if (!this.NCAMFPGMCIG.DNMPCOHNAHO.Contains(GNKHAAGBOED))
						{
							this.NCAMFPGMCIG.DNMPCOHNAHO.Add(GNKHAAGBOED);
						}
					}
					else
					{
						if (this.NCAMFPGMCIG.DNMPCOHNAHO.Count > 1)
						{
							this.NCAMFPGMCIG.DNMPCOHNAHO.RemoveAt(1);
						}
						if (!this.NCAMFPGMCIG.DNMPCOHNAHO.Contains(DPGJIJGOCIC.FAIFJDPENOP(GNKHAAGBOED)))
						{
							this.NCAMFPGMCIG.DNMPCOHNAHO.Add(DPGJIJGOCIC.FAIFJDPENOP(GNKHAAGBOED));
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

	// Token: 0x060086DD RID: 34525 RVA: 0x003C8074 File Offset: 0x003C6274
	public void BPNNGAEGIDP(int FMFBMJJCKHP, int GCKMAJCNHEO, string MJHGIIEINOE)
	{
		try
		{
			if (MJHGIIEINOE.Length > 0 && null != this.NCAMFPGMCIG.OHPAMFBABFO && this.NCAMFPGMCIG.OHPAMFBABFO.Count > 0 && null != this.DHONIOBOLEL.OHPAMFBABFO && this.DHONIOBOLEL.OHPAMFBABFO.Count > 1)
			{
				this.DHONIOBOLEL.CDDKCMPAHMG = FMFBMJJCKHP;
				this.DHONIOBOLEL.FGOHPIBCCHB = GCKMAJCNHEO;
				JSONObject jsonobject = new JSONObject();
				jsonobject.Add(MJHGIIEINOE, this.NCAMFPGMCIG.OHPAMFBABFO);
				this.NCAMFPGMCIG.EBFMKGPBEBO = jsonobject;
				this.DHONIOBOLEL.EBFMKGPBEBO = this.DHONIOBOLEL.OHPAMFBABFO;
				this.NCAMFPGMCIG.OHPAMFBABFO = null;
				this.DHONIOBOLEL.OHPAMFBABFO = null;
			}
		}
		catch (Exception aklgbjkdomm)
		{
			this.PPBDMCOPPPD();
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
	}

	// Token: 0x060086DE RID: 34526 RVA: 0x003C8168 File Offset: 0x003C6368
	public static int CJKPJAJLOKF(string OOMAHKCHAGP)
	{
		int result;
		try
		{
			OOMAHKCHAGP = OOMAHKCHAGP.Substring(OOMAHKCHAGP.IndexOf("OnSettingsPopupCloseAndNeedToShowPostEnableNotif"));
			result = int.Parse(DPGJIJGOCIC.MJAONCNGBKA(OOMAHKCHAGP.Substring(0, OOMAHKCHAGP.IndexOf("ru"))));
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
			result = -1;
		}
		return result;
	}

	// Token: 0x060086DF RID: 34527 RVA: 0x003C81C4 File Offset: 0x003C63C4
	public void ACCBHCBPNJA()
	{
		this.DHONIOBOLEL.ACCBHCBPNJA();
		this.NCAMFPGMCIG.ACCBHCBPNJA();
	}

	// Token: 0x060086E0 RID: 34528 RVA: 0x003C81DC File Offset: 0x003C63DC
	public bool HJDJLBECLFC(int OLKMHHNMDLP)
	{
		if (this.NLMDGBJKIPF(OLKMHHNMDLP))
		{
			try
			{
				string text = AKLOMMOOFNG.GHAEEJMIFGP("`" + PLFDAJJHMKO.AFAOMOMFDAN(this.DHONIOBOLEL.GGICIBLJIKI, OLKMHHNMDLP, this.POJAPLKAJEF, this.PJKKNLDKLMJ(OLKMHHNMDLP)));
				if (text == null || text.Length <= 0)
				{
					return true;
				}
				JSONObject jsonobject = (JSONObject)JSON.Parse(text);
				if (null != jsonobject)
				{
					int imledfidhdl = this.DHONIOBOLEL.IMLEDFIDHDL;
					int pojaplkajef = this.POJAPLKAJEF;
					try
					{
						this.FGJPKGLOGNC(jsonobject, true);
					}
					finally
					{
						this.POJAPLKAJEF = pojaplkajef;
					}
					this.DHONIOBOLEL.IMLEDFIDHDL = imledfidhdl;
					AKLFPGMDKLA.EHBBFMCILPC.NNKDPEHHIMP(this);
					this.DHONIOBOLEL.CFGFOEEEJKJ = -1;
					return true;
				}
				return false;
			}
			catch (Exception aklgbjkdomm)
			{
				DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
				return false;
			}
			return true;
		}
		return true;
	}

	// Token: 0x060086E1 RID: 34529 RVA: 0x003C82C8 File Offset: 0x003C64C8
	public void JGPEPCDDFPA()
	{
		if (this.DHONIOBOLEL.LGKPNNGIPEG == 0)
		{
			int pojaplkajef = this.POJAPLKAJEF;
			this.FGJPKGLOGNC(this.NCAMFPGMCIG.LGKPNNGIPEG, false);
			this.POJAPLKAJEF = pojaplkajef;
			AKLFPGMDKLA.EHBBFMCILPC.NNKDPEHHIMP(this);
		}
		this.DHONIOBOLEL.CFGFOEEEJKJ = -1;
	}

	// Token: 0x060086E2 RID: 34530 RVA: 0x003C831C File Offset: 0x003C651C
	public string KPLINMNLKBN(int OLKMHHNMDLP)
	{
		this.NCAMFPGMCIG.LGKPNNGIPEG = new JSONObject();
		this.NCAMFPGMCIG.LGKPNNGIPEG = this.PJPMBGMLKII(true);
		this.DHONIOBOLEL.LGKPNNGIPEG = 1;
		string ielhjggdgod = DPGJIJGOCIC.AEMFCOGDGHB();
		if (AKLOMMOOFNG.BIKILBLOEKD(this.NCAMFPGMCIG.LGKPNNGIPEG.ToString(), "Snapshots/" + PLFDAJJHMKO.AFAOMOMFDAN(this.DHONIOBOLEL.GGICIBLJIKI, OLKMHHNMDLP, this.POJAPLKAJEF, ielhjggdgod)))
		{
			if (!this.KIHACLLJMDH.Contains(OLKMHHNMDLP))
			{
				this.KIHACLLJMDH.Add(OLKMHHNMDLP);
			}
			this.GHCLDNCPKOG(OLKMHHNMDLP, ielhjggdgod);
			return PLFDAJJHMKO.AFAOMOMFDAN(this.DHONIOBOLEL.GGICIBLJIKI, OLKMHHNMDLP, this.POJAPLKAJEF, ielhjggdgod);
		}
		return "";
	}

	// Token: 0x060086E3 RID: 34531 RVA: 0x003C83D8 File Offset: 0x003C65D8
	public void NNFJIGFJOMG(string MJHGIIEINOE)
	{
		try
		{
			if (MJHGIIEINOE.Length > 0 && this.DHONIOBOLEL.EBFMKGPBEBO.Count > 0)
			{
				int pojaplkajef = this.POJAPLKAJEF;
				try
				{
					this.FGJPKGLOGNC(this.NCAMFPGMCIG.EBFMKGPBEBO[MJHGIIEINOE].AsObject, true);
				}
				finally
				{
					this.POJAPLKAJEF = pojaplkajef;
				}
				AKLFPGMDKLA.EHBBFMCILPC.NNKDPEHHIMP(this);
				this.PFHCDMOJOKP();
			}
		}
		catch (Exception aklgbjkdomm)
		{
			this.PFHCDMOJOKP();
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x060086E4 RID: 34532 RVA: 0x003C846C File Offset: 0x003C666C
	public static string BGEOJDLHHBC(int IFCHGNCDMLJ, int OLKMHHNMDLP, int CCLNHHJPDGJ)
	{
		string[] array = new string[3];
		array[0] = "hidestatinfo";
		array[1] = IFCHGNCDMLJ.ToString();
		array[1] = "";
		array[4] = OLKMHHNMDLP.ToString();
		array[8] = "small";
		array[1] = CCLNHHJPDGJ.ToString();
		array[6] = "";
		return string.Concat(array);
	}

	// Token: 0x060086E5 RID: 34533 RVA: 0x003C84C4 File Offset: 0x003C66C4
	private void LKAOGMCAHLN(int OLKMHHNMDLP, string IELHJGGDGOD)
	{
		List<string> list = new List<string>();
		for (int i = 1; i < this.KIHACLLJMDH.Count; i += 0)
		{
			if (this.KIHACLLJMDH[i] == OLKMHHNMDLP)
			{
				list.Add(IELHJGGDGOD);
			}
			else if (i < this.JJEONBFFBHP.Count)
			{
				list.Add(this.JJEONBFFBHP[i]);
			}
			else
			{
				DPGJIJGOCIC.ANOPFDLPKGC("OnPurchasingViewLeave");
			}
		}
		this.JJEONBFFBHP = list;
	}

	// Token: 0x060086E6 RID: 34534 RVA: 0x003C8538 File Offset: 0x003C6738
	public JSONObject BNMFBKNEMIF(bool DDLCOIHJKCJ)
	{
		JSONObject jsonobject = new JSONObject();
		jsonobject.Add("sslind", this.POJAPLKAJEF);
		if (this.KIHACLLJMDH.Count > 0)
		{
			jsonobject.Add("chsnap2", DPGJIJGOCIC.CLJDFEGDGFH(this.KIHACLLJMDH, 50));
		}
		if (this.JJEONBFFBHP.Count > 0)
		{
			jsonobject.Add("chsnapguid2", DPGJIJGOCIC.DGCHKPPDFDB(this.JJEONBFFBHP, 50));
		}
		jsonobject.Add("hdr", this.DHONIOBOLEL.BNMFBKNEMIF(DDLCOIHJKCJ));
		jsonobject.Add("body", this.NCAMFPGMCIG.BNMFBKNEMIF(DDLCOIHJKCJ));
		if (!DDLCOIHJKCJ)
		{
			jsonobject.Add("pers", this.FPHDAKHOBMO.BNMFBKNEMIF());
		}
		return jsonobject;
	}

	// Token: 0x060086E7 RID: 34535 RVA: 0x003C85F5 File Offset: 0x003C67F5
	public void CIEADJJFEEC()
	{
		this.NCAMFPGMCIG.IMJDADKEEJC = null;
		this.NCAMFPGMCIG.DNMPCOHNAHO = new List<string>();
		this.NCAMFPGMCIG.FEDCIMMIJCI = 1;
	}

	// Token: 0x060086E8 RID: 34536 RVA: 0x003C8620 File Offset: 0x003C6820
	public JSONObject GKBGJJFNBEO(bool DDLCOIHJKCJ)
	{
		JSONObject jsonobject = new JSONObject();
		jsonobject.Add("", this.POJAPLKAJEF);
		if (this.KIHACLLJMDH.Count > 0)
		{
			jsonobject.Add("success", DPGJIJGOCIC.CLJDFEGDGFH(this.KIHACLLJMDH, -88));
		}
		if (this.JJEONBFFBHP.Count > 0)
		{
			jsonobject.Add(" ", DPGJIJGOCIC.DGCHKPPDFDB(this.JJEONBFFBHP, 56));
		}
		jsonobject.Add("_ScanLineJitter", this.DHONIOBOLEL.NJNEMPKGPFN(DDLCOIHJKCJ));
		jsonobject.Add("", this.NCAMFPGMCIG.BNMFBKNEMIF(DDLCOIHJKCJ));
		if (!DDLCOIHJKCJ)
		{
			jsonobject.Add("", this.FPHDAKHOBMO.DBGGGJCPBPM());
		}
		return jsonobject;
	}

	// Token: 0x060086E9 RID: 34537 RVA: 0x003C86E0 File Offset: 0x003C68E0
	public static int KMAIFFIOCCO(string OOMAHKCHAGP)
	{
		int result;
		try
		{
			OOMAHKCHAGP = OOMAHKCHAGP.Substring(OOMAHKCHAGP.IndexOf(" "));
			result = int.Parse(DPGJIJGOCIC.MJAONCNGBKA(OOMAHKCHAGP.Substring(0, OOMAHKCHAGP.IndexOf("usyncs"))));
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
			result = -1;
		}
		return result;
	}

	// Token: 0x060086EA RID: 34538 RVA: 0x003C873C File Offset: 0x003C693C
	public void JLACJIMEGGL(string GNKHAAGBOED)
	{
		try
		{
			if (GNKHAAGBOED != null)
			{
				if (GNKHAAGBOED.Length >= 3 || this.NCAMFPGMCIG.DNMPCOHNAHO.Count <= 0)
				{
					if (GNKHAAGBOED.Length == 0)
					{
						if (!this.NCAMFPGMCIG.DNMPCOHNAHO.Contains(GNKHAAGBOED))
						{
							this.NCAMFPGMCIG.DNMPCOHNAHO.Add(GNKHAAGBOED);
						}
					}
					else
					{
						if (this.NCAMFPGMCIG.DNMPCOHNAHO.Count > 5)
						{
							this.NCAMFPGMCIG.DNMPCOHNAHO.RemoveAt(1);
						}
						if (!this.NCAMFPGMCIG.DNMPCOHNAHO.Contains(DPGJIJGOCIC.FAIFJDPENOP(GNKHAAGBOED)))
						{
							this.NCAMFPGMCIG.DNMPCOHNAHO.Add(DPGJIJGOCIC.FAIFJDPENOP(GNKHAAGBOED));
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

	// Token: 0x060086EB RID: 34539 RVA: 0x003C880C File Offset: 0x003C6A0C
	public JSONObject OAOEICHBMDH(bool DDLCOIHJKCJ)
	{
		JSONObject jsonobject = new JSONObject();
		jsonobject.Add("myprreportdonebody", this.POJAPLKAJEF);
		if (this.KIHACLLJMDH.Count > 1)
		{
			jsonobject.Add("favoritespattern", DPGJIJGOCIC.CLJDFEGDGFH(this.KIHACLLJMDH, -4));
		}
		if (this.JJEONBFFBHP.Count > 0)
		{
			jsonobject.Add("), concepts ", DPGJIJGOCIC.BEOBMCGEHBC(this.JJEONBFFBHP, 93));
		}
		jsonobject.Add("", this.DHONIOBOLEL.OCMJGEEFEOI(DDLCOIHJKCJ));
		jsonobject.Add("usynach", this.NCAMFPGMCIG.BNMFBKNEMIF(DDLCOIHJKCJ));
		if (!DDLCOIHJKCJ)
		{
			jsonobject.Add("avatarstitle", this.FPHDAKHOBMO.EDALLJFJPDK());
		}
		return jsonobject;
	}

	// Token: 0x060086EC RID: 34540 RVA: 0x003C88CC File Offset: 0x003C6ACC
	public void AKJIFLCHGGC(string JKOCCPCLOEC)
	{
		try
		{
			this.LNCIMPFKHAO();
			this.JLACJIMEGGL(JKOCCPCLOEC);
			this.NCAMFPGMCIG.IMJDADKEEJC = this.PJPMBGMLKII(true);
		}
		catch (Exception aklgbjkdomm)
		{
			this.LNCIMPFKHAO();
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x060086ED RID: 34541 RVA: 0x003C8918 File Offset: 0x003C6B18
	public string JDLLMNHMEKF(int OLKMHHNMDLP)
	{
		this.NCAMFPGMCIG.LGKPNNGIPEG = new JSONObject();
		this.NCAMFPGMCIG.LGKPNNGIPEG = this.EJFHLFELPME(true);
		this.DHONIOBOLEL.LGKPNNGIPEG = 1;
		string ielhjggdgod = DPGJIJGOCIC.HPAFOPBLHON();
		if (AKLOMMOOFNG.CGGKALNBBLF(this.NCAMFPGMCIG.LGKPNNGIPEG.ToString(), "countryCode" + PLFDAJJHMKO.NFLOOLFMPIK(this.DHONIOBOLEL.GGICIBLJIKI, OLKMHHNMDLP, this.POJAPLKAJEF, ielhjggdgod)))
		{
			if (!this.KIHACLLJMDH.Contains(OLKMHHNMDLP))
			{
				this.KIHACLLJMDH.Add(OLKMHHNMDLP);
			}
			this.GHCLDNCPKOG(OLKMHHNMDLP, ielhjggdgod);
			return PLFDAJJHMKO.NFLOOLFMPIK(this.DHONIOBOLEL.GGICIBLJIKI, OLKMHHNMDLP, this.POJAPLKAJEF, ielhjggdgod);
		}
		return "";
	}

	// Token: 0x060086EE RID: 34542 RVA: 0x003C89D4 File Offset: 0x003C6BD4
	public static int CGNLCFIKDKF(string OOMAHKCHAGP)
	{
		int result;
		try
		{
			OOMAHKCHAGP = OOMAHKCHAGP.Substring(OOMAHKCHAGP.IndexOf("lightmodeintrobody1"));
			result = int.Parse(DPGJIJGOCIC.MJAONCNGBKA(OOMAHKCHAGP.Substring(1, OOMAHKCHAGP.IndexOf(""))));
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
			result = -1;
		}
		return result;
	}

	// Token: 0x060086EF RID: 34543 RVA: 0x003C8A30 File Offset: 0x003C6C30
	public void BJEAFBANAHP(List<string> EEIGHDENFLN)
	{
		try
		{
			this.PFHCDMOJOKP();
			this.NCAMFPGMCIG.OHPAMFBABFO = this.BNMFBKNEMIF(true);
			this.DHONIOBOLEL.OHPAMFBABFO = DPGJIJGOCIC.DGCHKPPDFDB(EEIGHDENFLN, 32);
		}
		catch (Exception aklgbjkdomm)
		{
			this.PFHCDMOJOKP();
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x060086F0 RID: 34544 RVA: 0x003C8A88 File Offset: 0x003C6C88
	public static int PCIOFPLJMPJ(string OOMAHKCHAGP)
	{
		int result;
		try
		{
			OOMAHKCHAGP = OOMAHKCHAGP.Substring(OOMAHKCHAGP.IndexOf("W"));
			result = int.Parse(DPGJIJGOCIC.AMACOOGPPEC(OOMAHKCHAGP.Substring(0, OOMAHKCHAGP.IndexOf("."))));
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
			result = -1;
		}
		return result;
	}

	// Token: 0x060086F1 RID: 34545 RVA: 0x003C8AE4 File Offset: 0x003C6CE4
	public static int KFLMEOECGGP(string OOMAHKCHAGP)
	{
		int result;
		try
		{
			result = int.Parse(DPGJIJGOCIC.AMACOOGPPEC(OOMAHKCHAGP.Substring(0, OOMAHKCHAGP.IndexOf("Y"))));
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
			result = -1;
		}
		return result;
	}

	// Token: 0x060086F2 RID: 34546 RVA: 0x003C8B2C File Offset: 0x003C6D2C
	public void PFHCDMOJOKP()
	{
		this.DHONIOBOLEL.CDDKCMPAHMG = 0;
		this.DHONIOBOLEL.FGOHPIBCCHB = 0;
		this.DHONIOBOLEL.AJPIKAACMKL = 0;
		this.DHONIOBOLEL.IHFABMOJKHD = 0;
		this.DHONIOBOLEL.EBFMKGPBEBO = new JSONArray();
		this.NCAMFPGMCIG.EBFMKGPBEBO = new JSONObject();
		this.NCAMFPGMCIG.OHPAMFBABFO = null;
		this.DHONIOBOLEL.OHPAMFBABFO = null;
	}

	// Token: 0x060086F3 RID: 34547 RVA: 0x003C8BA4 File Offset: 0x003C6DA4
	public void MLOIILKHFBJ(int FMFBMJJCKHP, int GCKMAJCNHEO, string MJHGIIEINOE)
	{
		try
		{
			if (MJHGIIEINOE.Length > 0 && null != this.NCAMFPGMCIG.OHPAMFBABFO && this.NCAMFPGMCIG.OHPAMFBABFO.Count > 0 && null != this.DHONIOBOLEL.OHPAMFBABFO && this.DHONIOBOLEL.OHPAMFBABFO.Count > 0)
			{
				this.DHONIOBOLEL.CDDKCMPAHMG = FMFBMJJCKHP;
				this.DHONIOBOLEL.FGOHPIBCCHB = GCKMAJCNHEO;
				JSONObject jsonobject = new JSONObject();
				jsonobject.Add(MJHGIIEINOE, this.NCAMFPGMCIG.OHPAMFBABFO);
				this.NCAMFPGMCIG.EBFMKGPBEBO = jsonobject;
				this.DHONIOBOLEL.EBFMKGPBEBO = this.DHONIOBOLEL.OHPAMFBABFO;
				this.NCAMFPGMCIG.OHPAMFBABFO = null;
				this.DHONIOBOLEL.OHPAMFBABFO = null;
			}
		}
		catch (Exception aklgbjkdomm)
		{
			this.PFHCDMOJOKP();
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x060086F4 RID: 34548 RVA: 0x003C8C98 File Offset: 0x003C6E98
	public void JCJKCLNMEGA(string GNKHAAGBOED)
	{
		try
		{
			if (GNKHAAGBOED != null)
			{
				if (GNKHAAGBOED.Length >= 1 || this.NCAMFPGMCIG.DNMPCOHNAHO.Count <= 1)
				{
					if (GNKHAAGBOED.Length == 0)
					{
						if (!this.NCAMFPGMCIG.DNMPCOHNAHO.Contains(GNKHAAGBOED))
						{
							this.NCAMFPGMCIG.DNMPCOHNAHO.Add(GNKHAAGBOED);
						}
					}
					else
					{
						if (this.NCAMFPGMCIG.DNMPCOHNAHO.Count > 7)
						{
							this.NCAMFPGMCIG.DNMPCOHNAHO.RemoveAt(1);
						}
						if (!this.NCAMFPGMCIG.DNMPCOHNAHO.Contains(DPGJIJGOCIC.FAIFJDPENOP(GNKHAAGBOED)))
						{
							this.NCAMFPGMCIG.DNMPCOHNAHO.Add(DPGJIJGOCIC.FAIFJDPENOP(GNKHAAGBOED));
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

	// Token: 0x060086F5 RID: 34549 RVA: 0x003C8D68 File Offset: 0x003C6F68
	public JSONObject EJFHLFELPME(bool DDLCOIHJKCJ)
	{
		this.NCAMFPGMCIG.HFBONJPMAOO = true;
		JSONObject result;
		try
		{
			result = this.OAOEICHBMDH(DDLCOIHJKCJ);
		}
		finally
		{
			this.NCAMFPGMCIG.HFBONJPMAOO = true;
		}
		return result;
	}

	// Token: 0x060086F6 RID: 34550 RVA: 0x003C8DAC File Offset: 0x003C6FAC
	public void PPBDMCOPPPD()
	{
		this.DHONIOBOLEL.CDDKCMPAHMG = 0;
		this.DHONIOBOLEL.FGOHPIBCCHB = 0;
		this.DHONIOBOLEL.AJPIKAACMKL = 0;
		this.DHONIOBOLEL.IHFABMOJKHD = 1;
		this.DHONIOBOLEL.EBFMKGPBEBO = new JSONArray();
		this.NCAMFPGMCIG.EBFMKGPBEBO = new JSONObject();
		this.NCAMFPGMCIG.OHPAMFBABFO = null;
		this.DHONIOBOLEL.OHPAMFBABFO = null;
	}

	// Token: 0x060086F7 RID: 34551 RVA: 0x003C8E21 File Offset: 0x003C7021
	public void IHIEGJECHKJ()
	{
		this.DHONIOBOLEL.DEEHFBIKIMA();
		this.NCAMFPGMCIG.ACCBHCBPNJA();
	}

	// Token: 0x060086F8 RID: 34552 RVA: 0x003C8E3C File Offset: 0x003C703C
	public string KPGDMJHGFDN(int OLKMHHNMDLP)
	{
		this.NCAMFPGMCIG.LGKPNNGIPEG = new JSONObject();
		this.NCAMFPGMCIG.LGKPNNGIPEG = this.PJPMBGMLKII(true);
		this.DHONIOBOLEL.LGKPNNGIPEG = 1;
		string ielhjggdgod = DPGJIJGOCIC.HPAFOPBLHON();
		if (AKLOMMOOFNG.HIOBGDFEDON(this.NCAMFPGMCIG.LGKPNNGIPEG.ToString(), "" + PLFDAJJHMKO.NFLOOLFMPIK(this.DHONIOBOLEL.GGICIBLJIKI, OLKMHHNMDLP, this.POJAPLKAJEF, ielhjggdgod)))
		{
			if (!this.KIHACLLJMDH.Contains(OLKMHHNMDLP))
			{
				this.KIHACLLJMDH.Add(OLKMHHNMDLP);
			}
			this.LKAOGMCAHLN(OLKMHHNMDLP, ielhjggdgod);
			return PLFDAJJHMKO.AFAOMOMFDAN(this.DHONIOBOLEL.GGICIBLJIKI, OLKMHHNMDLP, this.POJAPLKAJEF, ielhjggdgod);
		}
		return "NEWSAVE: Warning: Missing anthology save data, yet story save data (";
	}

	// Token: 0x060086F9 RID: 34553 RVA: 0x003C8EF8 File Offset: 0x003C70F8
	public void ANCHGLGMIJA(List<string> EEIGHDENFLN)
	{
		try
		{
			this.DKFEMNMJIIP();
			this.NCAMFPGMCIG.OHPAMFBABFO = this.GKBGJJFNBEO(false);
			this.DHONIOBOLEL.OHPAMFBABFO = DPGJIJGOCIC.DGCHKPPDFDB(EEIGHDENFLN, -22);
		}
		catch (Exception aklgbjkdomm)
		{
			this.PPBDMCOPPPD();
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x060086FA RID: 34554 RVA: 0x003C8F50 File Offset: 0x003C7150
	public void BKIBKMBFBPC(string GNKHAAGBOED)
	{
		try
		{
			if (GNKHAAGBOED != null)
			{
				if (GNKHAAGBOED.Length >= 0 || this.NCAMFPGMCIG.DNMPCOHNAHO.Count <= 1)
				{
					if (GNKHAAGBOED.Length == 0)
					{
						if (!this.NCAMFPGMCIG.DNMPCOHNAHO.Contains(GNKHAAGBOED))
						{
							this.NCAMFPGMCIG.DNMPCOHNAHO.Add(GNKHAAGBOED);
						}
					}
					else
					{
						if (this.NCAMFPGMCIG.DNMPCOHNAHO.Count > 4)
						{
							this.NCAMFPGMCIG.DNMPCOHNAHO.RemoveAt(0);
						}
						if (!this.NCAMFPGMCIG.DNMPCOHNAHO.Contains(DPGJIJGOCIC.FAIFJDPENOP(GNKHAAGBOED)))
						{
							this.NCAMFPGMCIG.DNMPCOHNAHO.Add(DPGJIJGOCIC.FAIFJDPENOP(GNKHAAGBOED));
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

	// Token: 0x060086FB RID: 34555 RVA: 0x003C9020 File Offset: 0x003C7220
	public JSONObject PJPMBGMLKII(bool DDLCOIHJKCJ)
	{
		this.NCAMFPGMCIG.HFBONJPMAOO = true;
		JSONObject result;
		try
		{
			result = this.BNMFBKNEMIF(DDLCOIHJKCJ);
		}
		finally
		{
			this.NCAMFPGMCIG.HFBONJPMAOO = false;
		}
		return result;
	}

	// Token: 0x060086FC RID: 34556 RVA: 0x003C691C File Offset: 0x003C4B1C
	public bool DBAFGOGDINH()
	{
		return this.DHONIOBOLEL.EBFMKGPBEBO.Count > 0;
	}

	// Token: 0x060086FD RID: 34557 RVA: 0x003C9064 File Offset: 0x003C7264
	public static int EJFINLJNNLE(string OOMAHKCHAGP)
	{
		int result;
		try
		{
			OOMAHKCHAGP = OOMAHKCHAGP.Substring(OOMAHKCHAGP.IndexOf("OnSaveSyncAnyResult"));
			result = int.Parse(DPGJIJGOCIC.AMACOOGPPEC(OOMAHKCHAGP.Substring(1, OOMAHKCHAGP.IndexOf("OnLanguageChange"))));
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
			result = -1;
		}
		return result;
	}

	// Token: 0x040025CB RID: 9675
	public BKDLCCGIFFK FPHDAKHOBMO = new BKDLCCGIFFK();

	// Token: 0x040025CC RID: 9676
	public FKILHBFLCFC DHONIOBOLEL = new FKILHBFLCFC();

	// Token: 0x040025CD RID: 9677
	public BEEDEKAIFEL NCAMFPGMCIG = new BEEDEKAIFEL();

	// Token: 0x040025CE RID: 9678
	public int POJAPLKAJEF;

	// Token: 0x040025CF RID: 9679
	public List<int> KIHACLLJMDH = new List<int>();

	// Token: 0x040025D0 RID: 9680
	public List<string> JJEONBFFBHP = new List<string>();
}
