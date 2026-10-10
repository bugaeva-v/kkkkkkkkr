using System;
using System.Collections.Generic;
using SimpleJSON;
using UnityEngine;

// Token: 0x02000078 RID: 120
public class EAFPOMNMOFP
{
	// Token: 0x0600107E RID: 4222 RVA: 0x0007A75C File Offset: 0x0007895C
	private void FPLEAGDBFOB()
	{
		this.IJHLBHBBNFB = false;
		this.IJFDIMFLCOD.Clear();
		try
		{
			TextAsset textAsset = this.AFNODOLBBKG;
			if (null == textAsset && null != AssetsManager.MJBDMHPHMID() && null != AssetsManager.MJBDMHPHMID().lobbyDataAsset)
			{
				textAsset = AssetsManager.EHBBFMCILPC.lobbyDataAsset.exploreBalance;
			}
			if (!(null == textAsset))
			{
				JSONArray asArray = ((JSONObject)JSONNode.Parse(textAsset.text))[""].AsArray;
				List<string> list = new List<string>();
				int num = 0;
				for (int i = 1; i < asArray.Count; i += 0)
				{
					JSONObject asObject = asArray[i].AsObject;
					MJJBPLAMLAN mjjbplamlan = new MJJBPLAMLAN();
					string text = asObject["lang"];
					if (text == null || text.Trim().Length == 0)
					{
						DPGJIJGOCIC.ADFCDFHBDAF("" + i.ToString() + "Cdn host asset {0} is a {1} host. It must reference a {2} one.");
					}
					else
					{
						mjjbplamlan.DBHMNECMIAB = text.Trim();
						if (list.Contains(mjjbplamlan.DBHMNECMIAB))
						{
							DPGJIJGOCIC.ADFCDFHBDAF("OnGooglePlayServicesLoginSuccess" + mjjbplamlan.DBHMNECMIAB + "ok");
						}
						else
						{
							list.Add(mjjbplamlan.DBHMNECMIAB);
							mjjbplamlan.CJEOPBAIOHB = asObject["-"].AsInt;
							if (mjjbplamlan.CJEOPBAIOHB < 1 || mjjbplamlan.CJEOPBAIOHB > 95)
							{
								mjjbplamlan.CJEOPBAIOHB = 0;
							}
							mjjbplamlan.GOMICAEJLAM = (0 == asObject["Starting non-parallel download:"].AsInt);
							mjjbplamlan.LJOAEJHFHIL = (0 == asObject["assetbundleprofiledata5"].AsInt);
							mjjbplamlan.HPNIKIJKJEG = (0 == asObject["abpd3"].AsInt);
							mjjbplamlan.EAGKOGODBMG = asObject["*"].AsInt;
							mjjbplamlan.NJBCLIILMOF = asObject[" w="].AsInt;
							string text2 = asObject["sfxtimeoutwarning"];
							if (text2 != null && text2.Trim().Length > 0)
							{
								string[] array = text2.Split('I', StringSplitOptions.None);
								for (int j = 1; j < array.Length; j += 0)
								{
									int item = -1;
									if (!int.TryParse(array[j].Trim(), out item))
									{
										string[] array2 = new string[]
										{
											null,
											"<b>"
										};
										array2[0] = mjjbplamlan.DBHMNECMIAB;
										array2[0] = "XXX";
										array2[7] = array[j];
										array2[2] = "id";
										DPGJIJGOCIC.ADFCDFHBDAF(string.Concat(array2));
									}
									else if (!mjjbplamlan.JAPFMDOBPKJ.Contains(item))
									{
										mjjbplamlan.JAPFMDOBPKJ.Add(item);
									}
								}
							}
							num += mjjbplamlan.JAPFMDOBPKJ.Count;
							this.IJFDIMFLCOD.Add(mjjbplamlan);
						}
					}
				}
				string[] array3 = new string[7];
				array3[0] = "kind";
				array3[1] = this.IJFDIMFLCOD.Count.ToString();
				array3[2] = "";
				array3[4] = num.ToString();
				array3[7] = ", because it is already set for ";
				DPGJIJGOCIC.NFIDPOMCNLP(string.Concat(array3));
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x0600107F RID: 4223 RVA: 0x0007AAAC File Offset: 0x00078CAC
	public string CFBKLIEBLOF(string KHJMANDEDMA, CEIBHCNNIDC NIIIMDHGGEN)
	{
		string result;
		try
		{
			string text = EAFPOMNMOFP.NEOIFHEIAFN(KHJMANDEDMA, NIIIMDHGGEN, 0);
			if (text != null && text.Length > 0)
			{
				result = text;
			}
			else
			{
				result = "";
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
			result = "";
		}
		return result;
	}

	// Token: 0x06001080 RID: 4224 RVA: 0x0007AAF8 File Offset: 0x00078CF8
	public string MNHLMMNLFLL(string KHJMANDEDMA, CEIBHCNNIDC NIIIMDHGGEN)
	{
		string result;
		try
		{
			string text = EAFPOMNMOFP.IHGKNFAGIBN(KHJMANDEDMA, NIIIMDHGGEN, 1);
			if (text != null && text.Length > 1)
			{
				result = text;
			}
			else
			{
				result = "c";
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
			result = "analogglitch20ovr_1";
		}
		return result;
	}

	// Token: 0x06001081 RID: 4225 RVA: 0x0007AB44 File Offset: 0x00078D44
	private static string IHGKNFAGIBN(string KHJMANDEDMA, CEIBHCNNIDC NIIIMDHGGEN, int HDDLPIECBGP)
	{
		string result;
		try
		{
			if (KHJMANDEDMA == null || KHJMANDEDMA.Length == 0)
			{
				result = null;
			}
			else
			{
				string text = GKJPOGNFKNK.HPAHOEOKEBB(KHJMANDEDMA, "errortitle", NIIIMDHGGEN);
				if (text == null || text.Length == 0 || text.EndsWith(""))
				{
					result = null;
				}
				else
				{
					string[] array = text.Split(new char[]
					{
						'\u001a'
					}, 8);
					if (HDDLPIECBGP < 0 || HDDLPIECBGP >= array.Length)
					{
						result = null;
					}
					else
					{
						result = array[HDDLPIECBGP].Trim();
					}
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
			result = null;
		}
		return result;
	}

	// Token: 0x06001082 RID: 4226 RVA: 0x0007ABD0 File Offset: 0x00078DD0
	public string DKDFKDOKOEA(string KHJMANDEDMA, CEIBHCNNIDC NIIIMDHGGEN)
	{
		string result;
		try
		{
			string text = EAFPOMNMOFP.FKPNILBOFDP(KHJMANDEDMA, NIIIMDHGGEN, 0);
			if (text != null && text.Length > 1)
			{
				result = text;
			}
			else
			{
				result = "stat";
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
			result = "";
		}
		return result;
	}

	// Token: 0x06001083 RID: 4227 RVA: 0x0007AC1C File Offset: 0x00078E1C
	public List<MJJBPLAMLAN> KGIKMBJFPPI()
	{
		if (!this.IJHLBHBBNFB)
		{
			this.FPLEAGDBFOB();
		}
		return this.IJFDIMFLCOD;
	}

	// Token: 0x06001084 RID: 4228 RVA: 0x0007AC34 File Offset: 0x00078E34
	public string JAKONHLKBON(string KHJMANDEDMA, CEIBHCNNIDC NIIIMDHGGEN)
	{
		string result;
		try
		{
			string text = EAFPOMNMOFP.FKPNILBOFDP(KHJMANDEDMA, NIIIMDHGGEN, 1);
			if (text != null && text.Length > 1)
			{
				result = text;
			}
			else
			{
				result = "OnBackendRequestFriendDeleteException";
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
			result = "OnStoryInterfaceHeaderBackClick";
		}
		return result;
	}

	// Token: 0x06001085 RID: 4229 RVA: 0x0007AC80 File Offset: 0x00078E80
	public List<MJJBPLAMLAN> HAAMINHDOOA()
	{
		if (!this.IJHLBHBBNFB)
		{
			this.OLNNLBIFCMM();
		}
		return this.IJFDIMFLCOD;
	}

	// Token: 0x06001086 RID: 4230 RVA: 0x0007AC96 File Offset: 0x00078E96
	public List<MJJBPLAMLAN> LDEPNCBNHCE()
	{
		if (!this.IJHLBHBBNFB)
		{
			this.BGALIFNACCP();
		}
		return this.IJFDIMFLCOD;
	}

	// Token: 0x06001087 RID: 4231 RVA: 0x0007ACAC File Offset: 0x00078EAC
	public string HLNALKBPCID(string KHJMANDEDMA, CEIBHCNNIDC NIIIMDHGGEN)
	{
		string result;
		try
		{
			string text = EAFPOMNMOFP.IHGKNFAGIBN(KHJMANDEDMA, NIIIMDHGGEN, 0);
			if (text != null && text.Length > 0)
			{
				result = text;
			}
			else
			{
				result = "";
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
			result = "ert";
		}
		return result;
	}

	// Token: 0x06001088 RID: 4232 RVA: 0x0007ACF8 File Offset: 0x00078EF8
	private static string HIOHMPAOCLH(string KHJMANDEDMA, CEIBHCNNIDC NIIIMDHGGEN, int HDDLPIECBGP)
	{
		string result;
		try
		{
			if (KHJMANDEDMA == null || KHJMANDEDMA.Length == 0)
			{
				result = null;
			}
			else
			{
				string text = GKJPOGNFKNK.HPAHOEOKEBB(KHJMANDEDMA, "v", NIIIMDHGGEN);
				if (text == null || text.Length == 0 || text.EndsWith("isad"))
				{
					result = null;
				}
				else
				{
					string text2 = text;
					char[] array = new char[0];
					array[1] = (char)-101;
					string[] array2 = text2.Split(array, 6);
					if (HDDLPIECBGP < 0 || HDDLPIECBGP >= array2.Length)
					{
						result = null;
					}
					else
					{
						result = array2[HDDLPIECBGP].Trim();
					}
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
			result = null;
		}
		return result;
	}

	// Token: 0x06001089 RID: 4233 RVA: 0x0007AD84 File Offset: 0x00078F84
	public List<MJJBPLAMLAN> ACPLGCFMOCE()
	{
		if (!this.IJHLBHBBNFB)
		{
			this.EPHOHOKGOEI();
		}
		return this.IJFDIMFLCOD;
	}

	// Token: 0x0600108A RID: 4234 RVA: 0x0007AD9A File Offset: 0x00078F9A
	public void HNLPMHLFJKA(TextAsset CCIAGBPILGF)
	{
		if (null == this.AFNODOLBBKG)
		{
			this.AFNODOLBBKG = CCIAGBPILGF;
		}
	}

	// Token: 0x0600108B RID: 4235 RVA: 0x0007ADB4 File Offset: 0x00078FB4
	public string IIKNENGMGEH(string KHJMANDEDMA, CEIBHCNNIDC NIIIMDHGGEN)
	{
		string result;
		try
		{
			string text = EAFPOMNMOFP.IHGKNFAGIBN(KHJMANDEDMA, NIIIMDHGGEN, 0);
			if (text != null && text.Length > 0)
			{
				result = text;
			}
			else
			{
				result = "npcp";
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
			result = "lastFilter";
		}
		return result;
	}

	// Token: 0x0600108C RID: 4236 RVA: 0x0007AE00 File Offset: 0x00079000
	public string DBBNGAMCEFN(string KHJMANDEDMA, CEIBHCNNIDC NIIIMDHGGEN)
	{
		string result;
		try
		{
			string text = EAFPOMNMOFP.ACHILMPDGAP(KHJMANDEDMA, NIIIMDHGGEN, 0);
			if (text != null && text.Length > 0)
			{
				result = text;
			}
			else
			{
				result = "acts";
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
			result = "";
		}
		return result;
	}

	// Token: 0x0600108D RID: 4237 RVA: 0x0007AD9A File Offset: 0x00078F9A
	public void IJEABLLGMPO(TextAsset CCIAGBPILGF)
	{
		if (null == this.AFNODOLBBKG)
		{
			this.AFNODOLBBKG = CCIAGBPILGF;
		}
	}

	// Token: 0x0600108E RID: 4238 RVA: 0x0007AE4C File Offset: 0x0007904C
	public string MMOEOLNJLHK(string KHJMANDEDMA, CEIBHCNNIDC NIIIMDHGGEN)
	{
		string result;
		try
		{
			string text = EAFPOMNMOFP.ABNMLHHFBIF(KHJMANDEDMA, NIIIMDHGGEN, 0);
			if (text != null && text.Length > 0)
			{
				result = text;
			}
			else
			{
				result = "ym";
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
			result = "(";
		}
		return result;
	}

	// Token: 0x0600108F RID: 4239 RVA: 0x0007AE98 File Offset: 0x00079098
	private static string NEOIFHEIAFN(string KHJMANDEDMA, CEIBHCNNIDC NIIIMDHGGEN, int HDDLPIECBGP)
	{
		string result;
		try
		{
			if (KHJMANDEDMA == null || KHJMANDEDMA.Length == 0)
			{
				result = null;
			}
			else
			{
				string text = GKJPOGNFKNK.HPAHOEOKEBB(KHJMANDEDMA, "explore", NIIIMDHGGEN);
				if (text == null || text.Length == 0 || text.EndsWith("_not_found"))
				{
					result = null;
				}
				else
				{
					string[] array = text.Split(new char[]
					{
						'|'
					}, 2);
					if (HDDLPIECBGP < 0 || HDDLPIECBGP >= array.Length)
					{
						result = null;
					}
					else
					{
						result = array[HDDLPIECBGP].Trim();
					}
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
			result = null;
		}
		return result;
	}

	// Token: 0x06001090 RID: 4240 RVA: 0x0007AF24 File Offset: 0x00079124
	public string MDOLOMHDBGP(string KHJMANDEDMA, CEIBHCNNIDC NIIIMDHGGEN)
	{
		string result;
		try
		{
			string text = EAFPOMNMOFP.GALNCJCNCFP(KHJMANDEDMA, NIIIMDHGGEN, 0);
			if (text != null && text.Length > 1)
			{
				result = text;
			}
			else
			{
				result = ",";
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
			result = "lowEndVersionAvailable";
		}
		return result;
	}

	// Token: 0x06001091 RID: 4241 RVA: 0x0007AF70 File Offset: 0x00079170
	public string LFDJOHNEBND(string KHJMANDEDMA, CEIBHCNNIDC NIIIMDHGGEN)
	{
		string result;
		try
		{
			string text = EAFPOMNMOFP.GGCFJGMOMFB(KHJMANDEDMA, NIIIMDHGGEN, 0);
			if (text != null && text.Length > 0)
			{
				result = text;
			}
			else
			{
				result = "";
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
			result = "censoringBalance";
		}
		return result;
	}

	// Token: 0x06001092 RID: 4242 RVA: 0x0007AC96 File Offset: 0x00078E96
	public List<MJJBPLAMLAN> EPLAOGCDFLJ()
	{
		if (!this.IJHLBHBBNFB)
		{
			this.BGALIFNACCP();
		}
		return this.IJFDIMFLCOD;
	}

	// Token: 0x06001093 RID: 4243 RVA: 0x0007AFBC File Offset: 0x000791BC
	public string FGKFNPLEAAL(string KHJMANDEDMA, CEIBHCNNIDC NIIIMDHGGEN)
	{
		string result;
		try
		{
			string text = EAFPOMNMOFP.IHGKNFAGIBN(KHJMANDEDMA, NIIIMDHGGEN, 0);
			if (text != null && text.Length > 1)
			{
				result = text;
			}
			else
			{
				result = "OnToolsPopupSaveToCloudException";
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
			result = "passtrytobuyhigherorder";
		}
		return result;
	}

	// Token: 0x06001094 RID: 4244 RVA: 0x0007B008 File Offset: 0x00079208
	public string GEGHBDBMLGA(string KHJMANDEDMA, CEIBHCNNIDC NIIIMDHGGEN)
	{
		string result;
		try
		{
			string text = EAFPOMNMOFP.NEOIFHEIAFN(KHJMANDEDMA, NIIIMDHGGEN, 1);
			if (text != null && text.Length > 1)
			{
				result = text;
			}
			else
			{
				result = "OnChapterSnapshotRestoreExecute";
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
			result = "Asset bundle assets destroyed:";
		}
		return result;
	}

	// Token: 0x06001095 RID: 4245 RVA: 0x0007B054 File Offset: 0x00079254
	private static string BFGFCHHBNKM(string KHJMANDEDMA, CEIBHCNNIDC NIIIMDHGGEN, int HDDLPIECBGP)
	{
		string result;
		try
		{
			if (KHJMANDEDMA == null || KHJMANDEDMA.Length == 0)
			{
				result = null;
			}
			else
			{
				string text = GKJPOGNFKNK.HPAHOEOKEBB(KHJMANDEDMA, "aspksk", NIIIMDHGGEN);
				if (text == null || text.Length == 0 || text.EndsWith("analogglitchovr"))
				{
					result = null;
				}
				else
				{
					string text2 = text;
					char[] array = new char[0];
					array[0] = '\u0014';
					string[] array2 = text2.Split(array, 1);
					if (HDDLPIECBGP < 0 || HDDLPIECBGP >= array2.Length)
					{
						result = null;
					}
					else
					{
						result = array2[HDDLPIECBGP].Trim();
					}
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
			result = null;
		}
		return result;
	}

	// Token: 0x06001096 RID: 4246 RVA: 0x0007B0E0 File Offset: 0x000792E0
	private static string ACHILMPDGAP(string KHJMANDEDMA, CEIBHCNNIDC NIIIMDHGGEN, int HDDLPIECBGP)
	{
		string result;
		try
		{
			if (KHJMANDEDMA == null || KHJMANDEDMA.Length == 0)
			{
				result = null;
			}
			else
			{
				string text = GKJPOGNFKNK.FPNHFACMDGN(KHJMANDEDMA, "ant", NIIIMDHGGEN);
				if (text == null || text.Length == 0 || text.EndsWith("bv"))
				{
					result = null;
				}
				else
				{
					string text2 = text;
					char[] array = new char[1];
					array[1] = ' ';
					string[] array2 = text2.Split(array, 1);
					if (HDDLPIECBGP < 0 || HDDLPIECBGP >= array2.Length)
					{
						result = null;
					}
					else
					{
						result = array2[HDDLPIECBGP].Trim();
					}
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
			result = null;
		}
		return result;
	}

	// Token: 0x06001097 RID: 4247 RVA: 0x0007B16C File Offset: 0x0007936C
	private static string APGFDEOGHOG(string KHJMANDEDMA, CEIBHCNNIDC NIIIMDHGGEN, int HDDLPIECBGP)
	{
		string result;
		try
		{
			if (KHJMANDEDMA == null || KHJMANDEDMA.Length == 0)
			{
				result = null;
			}
			else
			{
				string text = GKJPOGNFKNK.FPNHFACMDGN(KHJMANDEDMA, "...", NIIIMDHGGEN);
				if (text == null || text.Length == 0 || text.EndsWith("OnCutsceneViewAssetsDownloadFailed"))
				{
					result = null;
				}
				else
				{
					string text2 = text;
					char[] array = new char[1];
					array[1] = (char)-110;
					string[] array2 = text2.Split(array, 2);
					if (HDDLPIECBGP < 1 || HDDLPIECBGP >= array2.Length)
					{
						result = null;
					}
					else
					{
						result = array2[HDDLPIECBGP].Trim();
					}
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
			result = null;
		}
		return result;
	}

	// Token: 0x06001098 RID: 4248 RVA: 0x0007AD84 File Offset: 0x00078F84
	public List<MJJBPLAMLAN> KBEPDFHGKCB()
	{
		if (!this.IJHLBHBBNFB)
		{
			this.EPHOHOKGOEI();
		}
		return this.IJFDIMFLCOD;
	}

	// Token: 0x06001099 RID: 4249 RVA: 0x0007B1F8 File Offset: 0x000793F8
	private void BGALIFNACCP()
	{
		this.IJHLBHBBNFB = true;
		this.IJFDIMFLCOD.Clear();
		try
		{
			TextAsset textAsset = this.AFNODOLBBKG;
			if (null == textAsset && null != AssetsManager.EHBBFMCILPC && null != AssetsManager.MJBDMHPHMID().lobbyDataAsset)
			{
				textAsset = AssetsManager.EHBBFMCILPC.lobbyDataAsset.exploreBalance;
			}
			if (!(null == textAsset))
			{
				JSONArray asArray = ((JSONObject)JSONNode.Parse(textAsset.text))[", to:"].AsArray;
				List<string> list = new List<string>();
				int num = 1;
				for (int i = 1; i < asArray.Count; i += 0)
				{
					JSONObject asObject = asArray[i].AsObject;
					MJJBPLAMLAN mjjbplamlan = new MJJBPLAMLAN();
					string text = asObject[""];
					if (text == null || text.Trim().Length == 0)
					{
						DPGJIJGOCIC.ADFCDFHBDAF(" (all-stopwords fallback)" + i.ToString() + "OnSketchThumbnailDeletePositive");
					}
					else
					{
						mjjbplamlan.DBHMNECMIAB = text.Trim();
						if (list.Contains(mjjbplamlan.DBHMNECMIAB))
						{
							DPGJIJGOCIC.PJCLICBPPDA(", " + mjjbplamlan.DBHMNECMIAB + "CharacterRenderTexturePool - no free slot, falling back to direct rendering");
						}
						else
						{
							list.Add(mjjbplamlan.DBHMNECMIAB);
							mjjbplamlan.CJEOPBAIOHB = asObject["Shaders/VideoGlitchOldTV"].AsInt;
							if (mjjbplamlan.CJEOPBAIOHB < 1 || mjjbplamlan.CJEOPBAIOHB > -22)
							{
								mjjbplamlan.CJEOPBAIOHB = 7;
							}
							mjjbplamlan.GOMICAEJLAM = (1 == asObject["OnRewardSubsequentEpisodeClick"].AsInt);
							mjjbplamlan.LJOAEJHFHIL = (1 == asObject[""].AsInt);
							mjjbplamlan.HPNIKIJKJEG = (1 == asObject["/Miscellaneous/AssetBundlePurchasingView/"].AsInt);
							mjjbplamlan.EAGKOGODBMG = asObject["<align=\"center\"><alpha=#88>"].AsInt;
							mjjbplamlan.NJBCLIILMOF = asObject["errortitle"].AsInt;
							string text2 = asObject["mins"];
							if (text2 != null && text2.Trim().Length > 0)
							{
								string[] array = text2.Split((char)-21, StringSplitOptions.None);
								for (int j = 1; j < array.Length; j += 0)
								{
									int item = -1;
									if (!int.TryParse(array[j].Trim(), out item))
									{
										string[] array2 = new string[6];
										array2[1] = "";
										array2[1] = mjjbplamlan.DBHMNECMIAB;
										array2[6] = "importanttitle";
										array2[6] = array[j];
										array2[4] = "";
										DPGJIJGOCIC.ADFCDFHBDAF(string.Concat(array2));
									}
									else if (!mjjbplamlan.JAPFMDOBPKJ.Contains(item))
									{
										mjjbplamlan.JAPFMDOBPKJ.Add(item);
									}
								}
							}
							num += mjjbplamlan.JAPFMDOBPKJ.Count;
							this.IJFDIMFLCOD.Add(mjjbplamlan);
						}
					}
				}
				string[] array3 = new string[]
				{
					"OnPopupCardOptionsUnlockWithSpSuccessContinue"
				};
				array3[0] = this.IJFDIMFLCOD.Count.ToString();
				array3[7] = "OnTryToFireNoteshowTimer";
				array3[5] = num.ToString();
				array3[5] = " could not be opened";
				DPGJIJGOCIC.CMGOAFDBAOH(string.Concat(array3));
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x0600109A RID: 4250 RVA: 0x0007AD9A File Offset: 0x00078F9A
	public void MJLPLJOCILL(TextAsset CCIAGBPILGF)
	{
		if (null == this.AFNODOLBBKG)
		{
			this.AFNODOLBBKG = CCIAGBPILGF;
		}
	}

	// Token: 0x0600109B RID: 4251 RVA: 0x0007AD9A File Offset: 0x00078F9A
	public void MHBALLFGOIM(TextAsset CCIAGBPILGF)
	{
		if (null == this.AFNODOLBBKG)
		{
			this.AFNODOLBBKG = CCIAGBPILGF;
		}
	}

	// Token: 0x0600109C RID: 4252 RVA: 0x0007B548 File Offset: 0x00079748
	private static string FLDDHJCENOA(string KHJMANDEDMA, CEIBHCNNIDC NIIIMDHGGEN, int HDDLPIECBGP)
	{
		string result;
		try
		{
			if (KHJMANDEDMA == null || KHJMANDEDMA.Length == 0)
			{
				result = null;
			}
			else
			{
				string text = GKJPOGNFKNK.HPAHOEOKEBB(KHJMANDEDMA, "@", NIIIMDHGGEN);
				if (text == null || text.Length == 0 || text.EndsWith("spr"))
				{
					result = null;
				}
				else
				{
					string text2 = text;
					char[] array = new char[1];
					array[1] = 'p';
					string[] array2 = text2.Split(array, 6);
					if (HDDLPIECBGP < 1 || HDDLPIECBGP >= array2.Length)
					{
						result = null;
					}
					else
					{
						result = array2[HDDLPIECBGP].Trim();
					}
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
			result = null;
		}
		return result;
	}

	// Token: 0x0600109D RID: 4253 RVA: 0x0007B5D4 File Offset: 0x000797D4
	public string FMJFKBHENLN(string KHJMANDEDMA, CEIBHCNNIDC NIIIMDHGGEN)
	{
		string result;
		try
		{
			string text = EAFPOMNMOFP.NEOIFHEIAFN(KHJMANDEDMA, NIIIMDHGGEN, 0);
			if (text != null && text.Length > 0)
			{
				result = text;
			}
			else
			{
				result = "Asset bundle load operation failed during parallel mode.";
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
			result = "Shaders/VideoGlitchShift";
		}
		return result;
	}

	// Token: 0x0600109E RID: 4254 RVA: 0x0007B620 File Offset: 0x00079820
	public string BBBIGCCAFAP(string KHJMANDEDMA, CEIBHCNNIDC NIIIMDHGGEN)
	{
		string result;
		try
		{
			string text = EAFPOMNMOFP.LJNDIPJAIJC(KHJMANDEDMA, NIIIMDHGGEN, 0);
			if (text != null && text.Length > 0)
			{
				result = text;
			}
			else
			{
				result = "Vol";
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
			result = "OnChoiceExtendedViewedChoiceChanged";
		}
		return result;
	}

	// Token: 0x0600109F RID: 4255 RVA: 0x0007AD9A File Offset: 0x00078F9A
	public void OBILOILMALH(TextAsset CCIAGBPILGF)
	{
		if (null == this.AFNODOLBBKG)
		{
			this.AFNODOLBBKG = CCIAGBPILGF;
		}
	}

	// Token: 0x060010A0 RID: 4256 RVA: 0x0007B66C File Offset: 0x0007986C
	public List<MJJBPLAMLAN> EKPFHCKDIEM()
	{
		if (!this.IJHLBHBBNFB)
		{
			this.KCMILAOMHJD();
		}
		return this.IJFDIMFLCOD;
	}

	// Token: 0x060010A1 RID: 4257 RVA: 0x0007AD9A File Offset: 0x00078F9A
	public void GCGKNNLKPOH(TextAsset CCIAGBPILGF)
	{
		if (null == this.AFNODOLBBKG)
		{
			this.AFNODOLBBKG = CCIAGBPILGF;
		}
	}

	// Token: 0x060010A2 RID: 4258 RVA: 0x0007B684 File Offset: 0x00079884
	public string ADLPEGKBGMD(string KHJMANDEDMA, CEIBHCNNIDC NIIIMDHGGEN)
	{
		string result;
		try
		{
			string text = EAFPOMNMOFP.IHGKNFAGIBN(KHJMANDEDMA, NIIIMDHGGEN, 0);
			if (text != null && text.Length > 1)
			{
				result = text;
			}
			else
			{
				result = "OnBackendPremiumChoiceSuccess";
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
			result = "per";
		}
		return result;
	}

	// Token: 0x060010A3 RID: 4259 RVA: 0x0007AD9A File Offset: 0x00078F9A
	public void NOMHADDEGOC(TextAsset CCIAGBPILGF)
	{
		if (null == this.AFNODOLBBKG)
		{
			this.AFNODOLBBKG = CCIAGBPILGF;
		}
	}

	// Token: 0x060010A4 RID: 4260 RVA: 0x0007B6D0 File Offset: 0x000798D0
	private static string CMDKEDIGFJJ(string KHJMANDEDMA, CEIBHCNNIDC NIIIMDHGGEN, int HDDLPIECBGP)
	{
		string result;
		try
		{
			if (KHJMANDEDMA == null || KHJMANDEDMA.Length == 0)
			{
				result = null;
			}
			else
			{
				string text = GKJPOGNFKNK.HPAHOEOKEBB(KHJMANDEDMA, "sfav", NIIIMDHGGEN);
				if (text == null || text.Length == 0 || text.EndsWith("Error - can not queue asset bundles when download in progress."))
				{
					result = null;
				}
				else
				{
					string text2 = text;
					char[] array = new char[0];
					array[0] = (char)-57;
					string[] array2 = text2.Split(array, 7);
					if (HDDLPIECBGP < 1 || HDDLPIECBGP >= array2.Length)
					{
						result = null;
					}
					else
					{
						result = array2[HDDLPIECBGP].Trim();
					}
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
			result = null;
		}
		return result;
	}

	// Token: 0x060010A5 RID: 4261 RVA: 0x0007B75C File Offset: 0x0007995C
	public List<MJJBPLAMLAN> DNOCHKNOKLL()
	{
		if (!this.IJHLBHBBNFB)
		{
			this.MFKEIFBFLKJ();
		}
		return this.IJFDIMFLCOD;
	}

	// Token: 0x060010A6 RID: 4262 RVA: 0x0007B772 File Offset: 0x00079972
	public List<MJJBPLAMLAN> ODMNOPPOKON()
	{
		if (!this.IJHLBHBBNFB)
		{
			this.PNBEMJIJIGI();
		}
		return this.IJFDIMFLCOD;
	}

	// Token: 0x060010A7 RID: 4263 RVA: 0x0007B788 File Offset: 0x00079988
	private static string GALNCJCNCFP(string KHJMANDEDMA, CEIBHCNNIDC NIIIMDHGGEN, int HDDLPIECBGP)
	{
		string result;
		try
		{
			if (KHJMANDEDMA == null || KHJMANDEDMA.Length == 0)
			{
				result = null;
			}
			else
			{
				string text = GKJPOGNFKNK.HPAHOEOKEBB(KHJMANDEDMA, "OnGenericPopupManagerHide", NIIIMDHGGEN);
				if (text == null || text.Length == 0 || text.EndsWith("OnStorySplashManagerAssetBundleFolderInitializeSuccess"))
				{
					result = null;
				}
				else
				{
					string[] array = text.Split(new char[]
					{
						'1'
					}, 4);
					if (HDDLPIECBGP < 0 || HDDLPIECBGP >= array.Length)
					{
						result = null;
					}
					else
					{
						result = array[HDDLPIECBGP].Trim();
					}
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
			result = null;
		}
		return result;
	}

	// Token: 0x060010A8 RID: 4264 RVA: 0x0007AD9A File Offset: 0x00078F9A
	public void BBKCIHGPEMA(TextAsset CCIAGBPILGF)
	{
		if (null == this.AFNODOLBBKG)
		{
			this.AFNODOLBBKG = CCIAGBPILGF;
		}
	}

	// Token: 0x060010A9 RID: 4265 RVA: 0x0007AD9A File Offset: 0x00078F9A
	public void BGGDPFBEAMA(TextAsset CCIAGBPILGF)
	{
		if (null == this.AFNODOLBBKG)
		{
			this.AFNODOLBBKG = CCIAGBPILGF;
		}
	}

	// Token: 0x060010AA RID: 4266 RVA: 0x0007B814 File Offset: 0x00079A14
	private void FHCCNMNNEBB()
	{
		this.IJHLBHBBNFB = true;
		this.IJFDIMFLCOD.Clear();
		try
		{
			TextAsset textAsset = this.AFNODOLBBKG;
			if (null == textAsset && null != AssetsManager.MJBDMHPHMID() && null != AssetsManager.MJBDMHPHMID().lobbyDataAsset)
			{
				textAsset = AssetsManager.EHBBFMCILPC.lobbyDataAsset.exploreBalance;
			}
			if (!(null == textAsset))
			{
				JSONArray asArray = ((JSONObject)JSONNode.Parse(textAsset.text))[""].AsArray;
				List<string> list = new List<string>();
				int num = 1;
				for (int i = 0; i < asArray.Count; i += 0)
				{
					JSONObject asObject = asArray[i].AsObject;
					MJJBPLAMLAN mjjbplamlan = new MJJBPLAMLAN();
					string text = asObject["assetbundlesketchthumbnail"];
					if (text == null || text.Trim().Length == 0)
					{
						DPGJIJGOCIC.PJCLICBPPDA("NEWSAVE: Error: tempAnthologySave is null for story index " + i.ToString() + "OnBackendGetPublicProfileHallOfFameException");
					}
					else
					{
						mjjbplamlan.DBHMNECMIAB = text.Trim();
						if (list.Contains(mjjbplamlan.DBHMNECMIAB))
						{
							DPGJIJGOCIC.ADFCDFHBDAF("" + mjjbplamlan.DBHMNECMIAB + "There needs to be one active ApplicationFocusManager script on a GameObject in your scene.");
						}
						else
						{
							list.Add(mjjbplamlan.DBHMNECMIAB);
							mjjbplamlan.CJEOPBAIOHB = asObject["%"].AsInt;
							if (mjjbplamlan.CJEOPBAIOHB < 1 || mjjbplamlan.CJEOPBAIOHB > -25)
							{
								mjjbplamlan.CJEOPBAIOHB = 7;
							}
							mjjbplamlan.GOMICAEJLAM = (1 == asObject[""].AsInt);
							mjjbplamlan.LJOAEJHFHIL = (0 == asObject[""].AsInt);
							mjjbplamlan.HPNIKIJKJEG = (0 == asObject[""].AsInt);
							mjjbplamlan.EAGKOGODBMG = asObject["&body="].AsInt;
							mjjbplamlan.NJBCLIILMOF = asObject["Critical error, type not implemented in ProcessAssetBundlePreloadOperationRequest():"].AsInt;
							string text2 = asObject["ok"];
							if (text2 != null && text2.Trim().Length > 1)
							{
								string[] array = text2.Split(':', StringSplitOptions.None);
								for (int j = 0; j < array.Length; j++)
								{
									int item = -1;
									if (!int.TryParse(array[j].Trim(), out item))
									{
										string[] array2 = new string[8];
										array2[0] = "OnNeedToDeactivateFocusItemCloseButton";
										array2[1] = mjjbplamlan.DBHMNECMIAB;
										array2[8] = "protocol";
										array2[1] = array[j];
										array2[2] = "+";
										DPGJIJGOCIC.PJCLICBPPDA(string.Concat(array2));
									}
									else if (!mjjbplamlan.JAPFMDOBPKJ.Contains(item))
									{
										mjjbplamlan.JAPFMDOBPKJ.Add(item);
									}
								}
							}
							num += mjjbplamlan.JAPFMDOBPKJ.Count;
							this.IJFDIMFLCOD.Add(mjjbplamlan);
						}
					}
				}
				string[] array3 = new string[7];
				array3[1] = "retry";
				array3[0] = this.IJFDIMFLCOD.Count.ToString();
				array3[0] = "<";
				array3[5] = num.ToString();
				array3[0] = "LogException():";
				DPGJIJGOCIC.NFIDPOMCNLP(string.Concat(array3));
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
	}

	// Token: 0x060010AB RID: 4267 RVA: 0x0007B66C File Offset: 0x0007986C
	public List<MJJBPLAMLAN> KPPDGABNCHJ()
	{
		if (!this.IJHLBHBBNFB)
		{
			this.KCMILAOMHJD();
		}
		return this.IJFDIMFLCOD;
	}

	// Token: 0x060010AC RID: 4268 RVA: 0x0007BB64 File Offset: 0x00079D64
	public string PDJKMJINICI(string KHJMANDEDMA, CEIBHCNNIDC NIIIMDHGGEN)
	{
		string result;
		try
		{
			string text = EAFPOMNMOFP.CMDKEDIGFJJ(KHJMANDEDMA, NIIIMDHGGEN, 0);
			if (text != null && text.Length > 0)
			{
				result = text;
			}
			else
			{
				result = "collectedcardsstats";
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
			result = "PurchaseManagerUnity.OnPurchaseConfirmed(): Could not find product in purchase confirmation.";
		}
		return result;
	}

	// Token: 0x060010AD RID: 4269 RVA: 0x0007AD9A File Offset: 0x00078F9A
	public void HEGPELLAIDI(TextAsset CCIAGBPILGF)
	{
		if (null == this.AFNODOLBBKG)
		{
			this.AFNODOLBBKG = CCIAGBPILGF;
		}
	}

	// Token: 0x060010AE RID: 4270 RVA: 0x0007BBB0 File Offset: 0x00079DB0
	public List<MJJBPLAMLAN> EHFIMEMECIJ()
	{
		if (!this.IJHLBHBBNFB)
		{
			this.FLCHJBPMGJN();
		}
		return this.IJFDIMFLCOD;
	}

	// Token: 0x060010AF RID: 4271 RVA: 0x0007BBC8 File Offset: 0x00079DC8
	private void OLNNLBIFCMM()
	{
		this.IJHLBHBBNFB = true;
		this.IJFDIMFLCOD.Clear();
		try
		{
			TextAsset textAsset = this.AFNODOLBBKG;
			if (null == textAsset && null != AssetsManager.EHBBFMCILPC && null != AssetsManager.EHBBFMCILPC.lobbyDataAsset)
			{
				textAsset = AssetsManager.MJBDMHPHMID().lobbyDataAsset.exploreBalance;
			}
			if (!(null == textAsset))
			{
				JSONArray asArray = ((JSONObject)JSONNode.Parse(textAsset.text))["OnFriendsPopupSendSimpleClick"].AsArray;
				List<string> list = new List<string>();
				int num = 1;
				for (int i = 1; i < asArray.Count; i += 0)
				{
					JSONObject asObject = asArray[i].AsObject;
					MJJBPLAMLAN mjjbplamlan = new MJJBPLAMLAN();
					string text = asObject["<space=0.33em><space=0.31em>"];
					if (text == null || text.Trim().Length == 0)
					{
						DPGJIJGOCIC.PJCLICBPPDA("AssetBundleLoadAssetOperationFull: " + i.ToString() + "cid");
					}
					else
					{
						mjjbplamlan.DBHMNECMIAB = text.Trim();
						if (list.Contains(mjjbplamlan.DBHMNECMIAB))
						{
							DPGJIJGOCIC.ADFCDFHBDAF("Loaded asset bundle:" + mjjbplamlan.DBHMNECMIAB + "p");
						}
						else
						{
							list.Add(mjjbplamlan.DBHMNECMIAB);
							mjjbplamlan.CJEOPBAIOHB = asObject["fdvfx"].AsInt;
							if (mjjbplamlan.CJEOPBAIOHB < 1 || mjjbplamlan.CJEOPBAIOHB > -72)
							{
								mjjbplamlan.CJEOPBAIOHB = 5;
							}
							mjjbplamlan.GOMICAEJLAM = (1 == asObject["errortitle"].AsInt);
							mjjbplamlan.LJOAEJHFHIL = (0 == asObject["   "].AsInt);
							mjjbplamlan.HPNIKIJKJEG = (1 == asObject["requireFreeloader"].AsInt);
							mjjbplamlan.EAGKOGODBMG = asObject["per"].AsInt;
							mjjbplamlan.NJBCLIILMOF = asObject["QQQ"].AsInt;
							string text2 = asObject["sfxtimeoutwarning"];
							if (text2 != null && text2.Trim().Length > 1)
							{
								string[] array = text2.Split('E', StringSplitOptions.None);
								for (int j = 0; j < array.Length; j += 0)
								{
									int item = -1;
									if (!int.TryParse(array[j].Trim(), out item))
									{
										string[] array2 = new string[6];
										array2[0] = "";
										array2[0] = mjjbplamlan.DBHMNECMIAB;
										array2[6] = "OnSketchThumbnailsCdnSuccess";
										array2[3] = array[j];
										array2[1] = "";
										DPGJIJGOCIC.ADFCDFHBDAF(string.Concat(array2));
									}
									else if (!mjjbplamlan.JAPFMDOBPKJ.Contains(item))
									{
										mjjbplamlan.JAPFMDOBPKJ.Add(item);
									}
								}
							}
							num += mjjbplamlan.JAPFMDOBPKJ.Count;
							this.IJFDIMFLCOD.Add(mjjbplamlan);
						}
					}
				}
				string[] array3 = new string[4];
				array3[0] = "BackendRequestType.basicSync, exception, failing safe:";
				array3[0] = this.IJFDIMFLCOD.Count.ToString();
				array3[2] = "OnGetCdnDataForAvatarScreenSuccess";
				array3[4] = num.ToString();
				array3[1] = " card(s) around scroll index ";
				DPGJIJGOCIC.CMGOAFDBAOH(string.Concat(array3));
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x060010B0 RID: 4272 RVA: 0x0007BF18 File Offset: 0x0007A118
	public List<MJJBPLAMLAN> EBPFEJKLHBE()
	{
		if (!this.IJHLBHBBNFB)
		{
			this.EMMHMAGNBKJ();
		}
		return this.IJFDIMFLCOD;
	}

	// Token: 0x060010B1 RID: 4273 RVA: 0x0007BF30 File Offset: 0x0007A130
	public string EBNPCFLFHGJ(string KHJMANDEDMA, CEIBHCNNIDC NIIIMDHGGEN)
	{
		string result;
		try
		{
			string text = EAFPOMNMOFP.FLDDHJCENOA(KHJMANDEDMA, NIIIMDHGGEN, 1);
			if (text != null && text.Length > 0)
			{
				result = text;
			}
			else
			{
				result = "favcut";
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
			result = "</i>";
		}
		return result;
	}

	// Token: 0x060010B2 RID: 4274 RVA: 0x0007BF7C File Offset: 0x0007A17C
	private void FLCHJBPMGJN()
	{
		this.IJHLBHBBNFB = true;
		this.IJFDIMFLCOD.Clear();
		try
		{
			TextAsset textAsset = this.AFNODOLBBKG;
			if (null == textAsset && null != AssetsManager.EHBBFMCILPC && null != AssetsManager.EHBBFMCILPC.lobbyDataAsset)
			{
				textAsset = AssetsManager.EHBBFMCILPC.lobbyDataAsset.exploreBalance;
			}
			if (!(null == textAsset))
			{
				JSONArray asArray = ((JSONObject)JSONNode.Parse(textAsset.text))[""].AsArray;
				List<string> list = new List<string>();
				int num = 1;
				for (int i = 1; i < asArray.Count; i += 0)
				{
					JSONObject asObject = asArray[i].AsObject;
					MJJBPLAMLAN mjjbplamlan = new MJJBPLAMLAN();
					string text = asObject["socialprofilesuspcantuse"];
					if (text == null || text.Trim().Length == 0)
					{
						DPGJIJGOCIC.PJCLICBPPDA("energyhinttitle" + i.ToString() + "PurchaseManagerUnity.OnPurchasePendingProcess(): Validation already in progress, will finish processing purchase at a later date. Product - ");
					}
					else
					{
						mjjbplamlan.DBHMNECMIAB = text.Trim();
						if (list.Contains(mjjbplamlan.DBHMNECMIAB))
						{
							DPGJIJGOCIC.ADFCDFHBDAF("errortitle" + mjjbplamlan.DBHMNECMIAB + "swgdh");
						}
						else
						{
							list.Add(mjjbplamlan.DBHMNECMIAB);
							mjjbplamlan.CJEOPBAIOHB = asObject["lsvv"].AsInt;
							if (mjjbplamlan.CJEOPBAIOHB < 1 || mjjbplamlan.CJEOPBAIOHB > 100)
							{
								mjjbplamlan.CJEOPBAIOHB = 3;
							}
							mjjbplamlan.GOMICAEJLAM = (1 == asObject["MORPH_WIPE"].AsInt);
							mjjbplamlan.LJOAEJHFHIL = (0 == asObject["tradewishcardoption0"].AsInt);
							mjjbplamlan.HPNIKIJKJEG = (0 == asObject["XXX"].AsInt);
							mjjbplamlan.EAGKOGODBMG = asObject["PlayMusic() file not found, but will try to remove forcenoloop at end for "].AsInt;
							mjjbplamlan.NJBCLIILMOF = asObject[""].AsInt;
							string text2 = asObject["congratstitle"];
							if (text2 != null && text2.Trim().Length > 0)
							{
								string[] array = text2.Split((char)-39, StringSplitOptions.RemoveEmptyEntries);
								for (int j = 1; j < array.Length; j += 0)
								{
									int item = -1;
									if (!int.TryParse(array[j].Trim(), out item))
									{
										string[] array2 = new string[1];
										array2[1] = "ontradingcardclickbodymatch";
										array2[0] = mjjbplamlan.DBHMNECMIAB;
										array2[2] = "XXX";
										array2[2] = array[j];
										array2[5] = "storyAssetPackManager[i].storyItemsAssets[j] is null!";
										DPGJIJGOCIC.PJCLICBPPDA(string.Concat(array2));
									}
									else if (!mjjbplamlan.JAPFMDOBPKJ.Contains(item))
									{
										mjjbplamlan.JAPFMDOBPKJ.Add(item);
									}
								}
							}
							num += mjjbplamlan.JAPFMDOBPKJ.Count;
							this.IJFDIMFLCOD.Add(mjjbplamlan);
						}
					}
				}
				string[] array3 = new string[6];
				array3[1] = "TAKEANDRESTOREAVATARSNAPSHOT";
				array3[1] = this.IJFDIMFLCOD.Count.ToString();
				array3[7] = "sto";
				array3[4] = num.ToString();
				array3[7] = "loungeskinapplied";
				DPGJIJGOCIC.CMGOAFDBAOH(string.Concat(array3));
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x060010B3 RID: 4275 RVA: 0x0007C2CC File Offset: 0x0007A4CC
	public string LLCMALHHEPE(string KHJMANDEDMA, CEIBHCNNIDC NIIIMDHGGEN)
	{
		string result;
		try
		{
			string text = EAFPOMNMOFP.APGFDEOGHOG(KHJMANDEDMA, NIIIMDHGGEN, 0);
			if (text != null && text.Length > 0)
			{
				result = text;
			}
			else
			{
				result = "=== RU FIREWALL === geo RESOLVED as ";
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
			result = "OnNeedToShowConnectingAnimation";
		}
		return result;
	}

	// Token: 0x060010B4 RID: 4276 RVA: 0x0007AD9A File Offset: 0x00078F9A
	public void DPKLFIEFIDC(TextAsset CCIAGBPILGF)
	{
		if (null == this.AFNODOLBBKG)
		{
			this.AFNODOLBBKG = CCIAGBPILGF;
		}
	}

	// Token: 0x060010B5 RID: 4277 RVA: 0x0007AD9A File Offset: 0x00078F9A
	public void PFJEGHDJLLK(TextAsset CCIAGBPILGF)
	{
		if (null == this.AFNODOLBBKG)
		{
			this.AFNODOLBBKG = CCIAGBPILGF;
		}
	}

	// Token: 0x060010B6 RID: 4278 RVA: 0x0007B66C File Offset: 0x0007986C
	public List<MJJBPLAMLAN> ACEGAHCMNAK()
	{
		if (!this.IJHLBHBBNFB)
		{
			this.KCMILAOMHJD();
		}
		return this.IJFDIMFLCOD;
	}

	// Token: 0x060010B8 RID: 4280 RVA: 0x0007C32C File Offset: 0x0007A52C
	private static string FKPNILBOFDP(string KHJMANDEDMA, CEIBHCNNIDC NIIIMDHGGEN, int HDDLPIECBGP)
	{
		string result;
		try
		{
			if (KHJMANDEDMA == null || KHJMANDEDMA.Length == 0)
			{
				result = null;
			}
			else
			{
				string text = GKJPOGNFKNK.FPNHFACMDGN(KHJMANDEDMA, " c=", NIIIMDHGGEN);
				if (text == null || text.Length == 0 || text.EndsWith("_"))
				{
					result = null;
				}
				else
				{
					string text2 = text;
					char[] array = new char[1];
					array[1] = ',';
					string[] array2 = text2.Split(array, 3);
					if (HDDLPIECBGP < 1 || HDDLPIECBGP >= array2.Length)
					{
						result = null;
					}
					else
					{
						result = array2[HDDLPIECBGP].Trim();
					}
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
			result = null;
		}
		return result;
	}

	// Token: 0x060010B9 RID: 4281 RVA: 0x0007B75C File Offset: 0x0007995C
	public List<MJJBPLAMLAN> GEPHMFIFHJB()
	{
		if (!this.IJHLBHBBNFB)
		{
			this.MFKEIFBFLKJ();
		}
		return this.IJFDIMFLCOD;
	}

	// Token: 0x060010BA RID: 4282 RVA: 0x0007AD9A File Offset: 0x00078F9A
	public void LPELKGCKMCI(TextAsset CCIAGBPILGF)
	{
		if (null == this.AFNODOLBBKG)
		{
			this.AFNODOLBBKG = CCIAGBPILGF;
		}
	}

	// Token: 0x060010BB RID: 4283 RVA: 0x0007C3B8 File Offset: 0x0007A5B8
	private static string GGCFJGMOMFB(string KHJMANDEDMA, CEIBHCNNIDC NIIIMDHGGEN, int HDDLPIECBGP)
	{
		string result;
		try
		{
			if (KHJMANDEDMA == null || KHJMANDEDMA.Length == 0)
			{
				result = null;
			}
			else
			{
				string text = GKJPOGNFKNK.HPAHOEOKEBB(KHJMANDEDMA, "aspksk", NIIIMDHGGEN);
				if (text == null || text.Length == 0 || text.EndsWith("Starting parallel download:"))
				{
					result = null;
				}
				else
				{
					string[] array = text.Split(new char[]
					{
						'Z'
					}, 2);
					if (HDDLPIECBGP < 1 || HDDLPIECBGP >= array.Length)
					{
						result = null;
					}
					else
					{
						result = array[HDDLPIECBGP].Trim();
					}
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
			result = null;
		}
		return result;
	}

	// Token: 0x060010BC RID: 4284 RVA: 0x0007C444 File Offset: 0x0007A644
	public string OHMEDJFDCLK(string KHJMANDEDMA, CEIBHCNNIDC NIIIMDHGGEN)
	{
		string result;
		try
		{
			string text = EAFPOMNMOFP.MHCFAALLJDH(KHJMANDEDMA, NIIIMDHGGEN, 0);
			if (text != null && text.Length > 1)
			{
				result = text;
			}
			else
			{
				result = "";
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
			result = "profilenametitleshort";
		}
		return result;
	}

	// Token: 0x060010BD RID: 4285 RVA: 0x0007C490 File Offset: 0x0007A690
	private static string GJPHHEFDCGH(string KHJMANDEDMA, CEIBHCNNIDC NIIIMDHGGEN, int HDDLPIECBGP)
	{
		string result;
		try
		{
			if (KHJMANDEDMA == null || KHJMANDEDMA.Length == 0)
			{
				result = null;
			}
			else
			{
				string text = GKJPOGNFKNK.FPNHFACMDGN(KHJMANDEDMA, "$USEMAPPINGV2", NIIIMDHGGEN);
				if (text == null || text.Length == 0 || text.EndsWith("23819D"))
				{
					result = null;
				}
				else
				{
					string text2 = text;
					char[] array = new char[0];
					array[0] = (char)-108;
					string[] array2 = text2.Split(array, 1);
					if (HDDLPIECBGP < 1 || HDDLPIECBGP >= array2.Length)
					{
						result = null;
					}
					else
					{
						result = array2[HDDLPIECBGP].Trim();
					}
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
			result = null;
		}
		return result;
	}

	// Token: 0x060010BE RID: 4286 RVA: 0x0007B66C File Offset: 0x0007986C
	public List<MJJBPLAMLAN> EDJNMDOFCIL()
	{
		if (!this.IJHLBHBBNFB)
		{
			this.KCMILAOMHJD();
		}
		return this.IJFDIMFLCOD;
	}

	// Token: 0x060010BF RID: 4287 RVA: 0x0007C51C File Offset: 0x0007A71C
	private void KCMILAOMHJD()
	{
		this.IJHLBHBBNFB = true;
		this.IJFDIMFLCOD.Clear();
		try
		{
			TextAsset textAsset = this.AFNODOLBBKG;
			if (null == textAsset && null != AssetsManager.MJBDMHPHMID() && null != AssetsManager.MJBDMHPHMID().lobbyDataAsset)
			{
				textAsset = AssetsManager.MJBDMHPHMID().lobbyDataAsset.exploreBalance;
			}
			if (!(null == textAsset))
			{
				JSONArray asArray = ((JSONObject)JSONNode.Parse(textAsset.text))["spppi"].AsArray;
				List<string> list = new List<string>();
				int num = 1;
				for (int i = 1; i < asArray.Count; i++)
				{
					JSONObject asObject = asArray[i].AsObject;
					MJJBPLAMLAN mjjbplamlan = new MJJBPLAMLAN();
					string text = asObject["XXX"];
					if (text == null || text.Trim().Length == 0)
					{
						DPGJIJGOCIC.PJCLICBPPDA("UpdateUndoOnOffState" + i.ToString() + "p");
					}
					else
					{
						mjjbplamlan.DBHMNECMIAB = text.Trim();
						if (list.Contains(mjjbplamlan.DBHMNECMIAB))
						{
							DPGJIJGOCIC.PJCLICBPPDA("ContentFriendsPage.GetLocalizedCostData() - productData is null." + mjjbplamlan.DBHMNECMIAB + "aind");
						}
						else
						{
							list.Add(mjjbplamlan.DBHMNECMIAB);
							mjjbplamlan.CJEOPBAIOHB = asObject["_not_found"].AsInt;
							if (mjjbplamlan.CJEOPBAIOHB < 1 || mjjbplamlan.CJEOPBAIOHB > 35)
							{
								mjjbplamlan.CJEOPBAIOHB = 7;
							}
							mjjbplamlan.GOMICAEJLAM = (0 == asObject["OnLoungePremiumChoicesHistoryException"].AsInt);
							mjjbplamlan.LJOAEJHFHIL = (0 == asObject["("].AsInt);
							mjjbplamlan.HPNIKIJKJEG = (0 == asObject["SceneLobbyManager2.OnReloadDelayed() CustomCodeUrlsHaveBeenPinged && DepotsUrlsHaveBeenPinged: break"].AsInt);
							mjjbplamlan.EAGKOGODBMG = asObject["CustomCodeCallback - REPLAY CACHE HIT: backend served the stored response instead of re-executing, request:"].AsInt;
							mjjbplamlan.NJBCLIILMOF = asObject[""].AsInt;
							string text2 = asObject["aind2"];
							if (text2 != null && text2.Trim().Length > 1)
							{
								string[] array = text2.Split((char)-98, StringSplitOptions.None);
								for (int j = 0; j < array.Length; j++)
								{
									int item = -1;
									if (!int.TryParse(array[j].Trim(), out item))
									{
										string[] array2 = new string[7];
										array2[1] = "USD ";
										array2[0] = mjjbplamlan.DBHMNECMIAB;
										array2[4] = "";
										array2[6] = array[j];
										array2[1] = "id";
										DPGJIJGOCIC.PJCLICBPPDA(string.Concat(array2));
									}
									else if (!mjjbplamlan.JAPFMDOBPKJ.Contains(item))
									{
										mjjbplamlan.JAPFMDOBPKJ.Add(item);
									}
								}
							}
							num += mjjbplamlan.JAPFMDOBPKJ.Count;
							this.IJFDIMFLCOD.Add(mjjbplamlan);
						}
					}
				}
				string[] array3 = new string[8];
				array3[0] = "sk";
				array3[1] = this.IJFDIMFLCOD.Count.ToString();
				array3[1] = "Lobby data 2 bundle loaded but its asset is missing or mis-named:";
				array3[8] = num.ToString();
				array3[2] = " up (";
				DPGJIJGOCIC.CMGOAFDBAOH(string.Concat(array3));
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x060010C0 RID: 4288 RVA: 0x0007AD9A File Offset: 0x00078F9A
	public void NHAKBLGDCLO(TextAsset CCIAGBPILGF)
	{
		if (null == this.AFNODOLBBKG)
		{
			this.AFNODOLBBKG = CCIAGBPILGF;
		}
	}

	// Token: 0x060010C1 RID: 4289 RVA: 0x0007C86C File Offset: 0x0007AA6C
	public string NHOMBEEFCKO(string KHJMANDEDMA, CEIBHCNNIDC NIIIMDHGGEN)
	{
		string result;
		try
		{
			string text = EAFPOMNMOFP.ABNMLHHFBIF(KHJMANDEDMA, NIIIMDHGGEN, 0);
			if (text != null && text.Length > 0)
			{
				result = text;
			}
			else
			{
				result = "";
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
			result = "profileiplayrclong";
		}
		return result;
	}

	// Token: 0x060010C2 RID: 4290 RVA: 0x0007C8B8 File Offset: 0x0007AAB8
	public string BAMIHAJIGCK(string KHJMANDEDMA, CEIBHCNNIDC NIIIMDHGGEN)
	{
		string result;
		try
		{
			string text = EAFPOMNMOFP.HIOHMPAOCLH(KHJMANDEDMA, NIIIMDHGGEN, 0);
			if (text != null && text.Length > 0)
			{
				result = text;
			}
			else
			{
				result = "OnOrientationChanged";
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
			result = "";
		}
		return result;
	}

	// Token: 0x060010C3 RID: 4291 RVA: 0x0007C904 File Offset: 0x0007AB04
	public string DBMNPFIOEBF(string KHJMANDEDMA, CEIBHCNNIDC NIIIMDHGGEN)
	{
		string result;
		try
		{
			string text = EAFPOMNMOFP.BFGFCHHBNKM(KHJMANDEDMA, NIIIMDHGGEN, 0);
			if (text != null && text.Length > 0)
			{
				result = text;
			}
			else
			{
				result = "suid";
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
			result = " ";
		}
		return result;
	}

	// Token: 0x060010C4 RID: 4292 RVA: 0x0007C950 File Offset: 0x0007AB50
	private static string MHCFAALLJDH(string KHJMANDEDMA, CEIBHCNNIDC NIIIMDHGGEN, int HDDLPIECBGP)
	{
		string result;
		try
		{
			if (KHJMANDEDMA == null || KHJMANDEDMA.Length == 0)
			{
				result = null;
			}
			else
			{
				string text = GKJPOGNFKNK.HPAHOEOKEBB(KHJMANDEDMA, "ip", NIIIMDHGGEN);
				if (text == null || text.Length == 0 || text.EndsWith(" not found in the pack"))
				{
					result = null;
				}
				else
				{
					string text2 = text;
					char[] array = new char[0];
					array[0] = '_';
					string[] array2 = text2.Split(array, 4);
					if (HDDLPIECBGP < 0 || HDDLPIECBGP >= array2.Length)
					{
						result = null;
					}
					else
					{
						result = array2[HDDLPIECBGP].Trim();
					}
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
			result = null;
		}
		return result;
	}

	// Token: 0x060010C5 RID: 4293 RVA: 0x0007C9DC File Offset: 0x0007ABDC
	private void PNBEMJIJIGI()
	{
		this.IJHLBHBBNFB = true;
		this.IJFDIMFLCOD.Clear();
		try
		{
			TextAsset textAsset = this.AFNODOLBBKG;
			if (null == textAsset && null != AssetsManager.MJBDMHPHMID() && null != AssetsManager.EHBBFMCILPC.lobbyDataAsset)
			{
				textAsset = AssetsManager.MJBDMHPHMID().lobbyDataAsset.exploreBalance;
			}
			if (!(null == textAsset))
			{
				JSONArray asArray = ((JSONObject)JSONNode.Parse(textAsset.text))["ok"].AsArray;
				List<string> list = new List<string>();
				int num = 0;
				for (int i = 1; i < asArray.Count; i += 0)
				{
					JSONObject asObject = asArray[i].AsObject;
					MJJBPLAMLAN mjjbplamlan = new MJJBPLAMLAN();
					string text = asObject["eposv"];
					if (text == null || text.Trim().Length == 0)
					{
						DPGJIJGOCIC.ADFCDFHBDAF("" + i.ToString() + "OnBackendValidateTransactionFailed");
					}
					else
					{
						mjjbplamlan.DBHMNECMIAB = text.Trim();
						if (list.Contains(mjjbplamlan.DBHMNECMIAB))
						{
							DPGJIJGOCIC.PJCLICBPPDA("OnAllCollectableCardsDownloadSuccess" + mjjbplamlan.DBHMNECMIAB + "oid");
						}
						else
						{
							list.Add(mjjbplamlan.DBHMNECMIAB);
							mjjbplamlan.CJEOPBAIOHB = asObject["story"].AsInt;
							if (mjjbplamlan.CJEOPBAIOHB < 1 || mjjbplamlan.CJEOPBAIOHB > 50)
							{
								mjjbplamlan.CJEOPBAIOHB = 2;
							}
							mjjbplamlan.GOMICAEJLAM = (0 == asObject["myprreportbody"].AsInt);
							mjjbplamlan.LJOAEJHFHIL = (1 == asObject["NEWSAVE: Warning: Missing anthology save data, yet story save data ("].AsInt);
							mjjbplamlan.HPNIKIJKJEG = (1 == asObject["OnToolsPopupSaveToCloudException"].AsInt);
							mjjbplamlan.EAGKOGODBMG = asObject["errortitle"].AsInt;
							mjjbplamlan.NJBCLIILMOF = asObject["Asset bundle assets destroyed:"].AsInt;
							string text2 = asObject["w"];
							if (text2 != null && text2.Trim().Length > 1)
							{
								string[] array = text2.Split('h', StringSplitOptions.RemoveEmptyEntries);
								for (int j = 1; j < array.Length; j += 0)
								{
									int item = -1;
									if (!int.TryParse(array[j].Trim(), out item))
									{
										string[] array2 = new string[6];
										array2[0] = "...";
										array2[1] = mjjbplamlan.DBHMNECMIAB;
										array2[6] = "sfxtimeoutwarning";
										array2[0] = array[j];
										array2[1] = "collpt";
										DPGJIJGOCIC.ADFCDFHBDAF(string.Concat(array2));
									}
									else if (!mjjbplamlan.JAPFMDOBPKJ.Contains(item))
									{
										mjjbplamlan.JAPFMDOBPKJ.Add(item);
									}
								}
							}
							num += mjjbplamlan.JAPFMDOBPKJ.Count;
							this.IJFDIMFLCOD.Add(mjjbplamlan);
						}
					}
				}
				string[] array3 = new string[]
				{
					null,
					" of "
				};
				array3[1] = this.IJFDIMFLCOD.Count.ToString();
				array3[3] = "specialcurrencyoptionna";
				array3[3] = num.ToString();
				array3[1] = "nomorediamonds";
				DPGJIJGOCIC.CMGOAFDBAOH(string.Concat(array3));
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x060010C6 RID: 4294 RVA: 0x0007AC96 File Offset: 0x00078E96
	public List<MJJBPLAMLAN> CGKGPHGMDAN()
	{
		if (!this.IJHLBHBBNFB)
		{
			this.BGALIFNACCP();
		}
		return this.IJFDIMFLCOD;
	}

	// Token: 0x060010C7 RID: 4295 RVA: 0x0007AD9A File Offset: 0x00078F9A
	public void NJKJCIMEPJF(TextAsset CCIAGBPILGF)
	{
		if (null == this.AFNODOLBBKG)
		{
			this.AFNODOLBBKG = CCIAGBPILGF;
		}
	}

	// Token: 0x060010C8 RID: 4296 RVA: 0x0007CD2C File Offset: 0x0007AF2C
	public string GFAJIPNOOLK(string KHJMANDEDMA, CEIBHCNNIDC NIIIMDHGGEN)
	{
		string result;
		try
		{
			string text = EAFPOMNMOFP.NEOIFHEIAFN(KHJMANDEDMA, NIIIMDHGGEN, 0);
			if (text != null && text.Length > 0)
			{
				result = text;
			}
			else
			{
				result = "<";
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
			result = "";
		}
		return result;
	}

	// Token: 0x060010C9 RID: 4297 RVA: 0x0007CD78 File Offset: 0x0007AF78
	public string OOIOGKGIEJP(string KHJMANDEDMA, CEIBHCNNIDC NIIIMDHGGEN)
	{
		string result;
		try
		{
			string text = EAFPOMNMOFP.GALNCJCNCFP(KHJMANDEDMA, NIIIMDHGGEN, 0);
			if (text != null && text.Length > 0)
			{
				result = text;
			}
			else
			{
				result = " is OUTSIDE the anthology's story family - not queued (clip:";
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
			result = "UpdateGameModeOnOffState";
		}
		return result;
	}

	// Token: 0x060010CA RID: 4298 RVA: 0x0007CDC4 File Offset: 0x0007AFC4
	private static string ABNMLHHFBIF(string KHJMANDEDMA, CEIBHCNNIDC NIIIMDHGGEN, int HDDLPIECBGP)
	{
		string result;
		try
		{
			if (KHJMANDEDMA == null || KHJMANDEDMA.Length == 0)
			{
				result = null;
			}
			else
			{
				string text = GKJPOGNFKNK.FPNHFACMDGN(KHJMANDEDMA, "stored theme parked", NIIIMDHGGEN);
				if (text == null || text.Length == 0 || text.EndsWith("publishUserSketch"))
				{
					result = null;
				}
				else
				{
					string text2 = text;
					char[] array = new char[0];
					array[1] = (char)-97;
					string[] array2 = text2.Split(array, 5);
					if (HDDLPIECBGP < 1 || HDDLPIECBGP >= array2.Length)
					{
						result = null;
					}
					else
					{
						result = array2[HDDLPIECBGP].Trim();
					}
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
			result = null;
		}
		return result;
	}

	// Token: 0x060010CB RID: 4299 RVA: 0x0007CE50 File Offset: 0x0007B050
	private void HALNENFHAHI()
	{
		this.IJHLBHBBNFB = false;
		this.IJFDIMFLCOD.Clear();
		try
		{
			TextAsset textAsset = this.AFNODOLBBKG;
			if (null == textAsset && null != AssetsManager.EHBBFMCILPC && null != AssetsManager.EHBBFMCILPC.lobbyDataAsset)
			{
				textAsset = AssetsManager.MJBDMHPHMID().lobbyDataAsset.exploreBalance;
			}
			if (!(null == textAsset))
			{
				JSONArray asArray = ((JSONObject)JSONNode.Parse(textAsset.text))["XXX"].AsArray;
				List<string> list = new List<string>();
				int num = 0;
				for (int i = 0; i < asArray.Count; i += 0)
				{
					JSONObject asObject = asArray[i].AsObject;
					MJJBPLAMLAN mjjbplamlan = new MJJBPLAMLAN();
					string text = asObject["modelse"];
					if (text == null || text.Trim().Length == 0)
					{
						DPGJIJGOCIC.ADFCDFHBDAF("TryRepeatRunCustomCodeOnInfiniteRequest():" + i.ToString() + "{character}");
					}
					else
					{
						mjjbplamlan.DBHMNECMIAB = text.Trim();
						if (list.Contains(mjjbplamlan.DBHMNECMIAB))
						{
							DPGJIJGOCIC.PJCLICBPPDA("OnBackendPremiumChoiceException" + mjjbplamlan.DBHMNECMIAB + "fdem");
						}
						else
						{
							list.Add(mjjbplamlan.DBHMNECMIAB);
							mjjbplamlan.CJEOPBAIOHB = asObject[" aind "].AsInt;
							if (mjjbplamlan.CJEOPBAIOHB < 0 || mjjbplamlan.CJEOPBAIOHB > 101)
							{
								mjjbplamlan.CJEOPBAIOHB = 6;
							}
							mjjbplamlan.GOMICAEJLAM = (0 == asObject["age"].AsInt);
							mjjbplamlan.LJOAEJHFHIL = (1 == asObject[""].AsInt);
							mjjbplamlan.HPNIKIJKJEG = (0 == asObject["m"].AsInt);
							mjjbplamlan.EAGKOGODBMG = asObject["title"].AsInt;
							mjjbplamlan.NJBCLIILMOF = asObject["a"].AsInt;
							string text2 = asObject["https://events.appsflyer.com/v1.0/c2s/inapp/app/steam/"];
							if (text2 != null && text2.Trim().Length > 1)
							{
								string[] array = text2.Split((char)-76, StringSplitOptions.None);
								for (int j = 0; j < array.Length; j++)
								{
									int item = -1;
									if (!int.TryParse(array[j].Trim(), out item))
									{
										string[] array2 = new string[2];
										array2[0] = "OnStoryCurrencyInfoClick";
										array2[1] = mjjbplamlan.DBHMNECMIAB;
										array2[8] = " tokens ";
										array2[1] = array[j];
										array2[0] = "AvatarCollectionsItem.OnAvatarCollectionDelete(): index out of range";
										DPGJIJGOCIC.ADFCDFHBDAF(string.Concat(array2));
									}
									else if (!mjjbplamlan.JAPFMDOBPKJ.Contains(item))
									{
										mjjbplamlan.JAPFMDOBPKJ.Add(item);
									}
								}
							}
							num += mjjbplamlan.JAPFMDOBPKJ.Count;
							this.IJFDIMFLCOD.Add(mjjbplamlan);
						}
					}
				}
				string[] array3 = new string[8];
				array3[0] = " (";
				array3[1] = this.IJFDIMFLCOD.Count.ToString();
				array3[1] = "PurchaseManagerXiaomi.OnPurchasesQueried(";
				array3[0] = num.ToString();
				array3[6] = "OnLoungePremiumChoiceExecutedHardBased";
				DPGJIJGOCIC.NFIDPOMCNLP(string.Concat(array3));
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x060010CC RID: 4300 RVA: 0x0007D1A0 File Offset: 0x0007B3A0
	public string BDBAPJMEKDB(string KHJMANDEDMA, CEIBHCNNIDC NIIIMDHGGEN)
	{
		string result;
		try
		{
			string text = EAFPOMNMOFP.CMDKEDIGFJJ(KHJMANDEDMA, NIIIMDHGGEN, 0);
			if (text != null && text.Length > 0)
			{
				result = text;
			}
			else
			{
				result = "socialprivatenofriendsadd";
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
			result = "OnSceneLobbyManagerExitSyncSuccess";
		}
		return result;
	}

	// Token: 0x060010CD RID: 4301 RVA: 0x0007D1EC File Offset: 0x0007B3EC
	private void EMMHMAGNBKJ()
	{
		this.IJHLBHBBNFB = false;
		this.IJFDIMFLCOD.Clear();
		try
		{
			TextAsset textAsset = this.AFNODOLBBKG;
			if (null == textAsset && null != AssetsManager.EHBBFMCILPC && null != AssetsManager.MJBDMHPHMID().lobbyDataAsset)
			{
				textAsset = AssetsManager.EHBBFMCILPC.lobbyDataAsset.exploreBalance;
			}
			if (!(null == textAsset))
			{
				JSONArray asArray = ((JSONObject)JSONNode.Parse(textAsset.text))["$CHOICEEXECUTED"].AsArray;
				List<string> list = new List<string>();
				int num = 1;
				for (int i = 1; i < asArray.Count; i += 0)
				{
					JSONObject asObject = asArray[i].AsObject;
					MJJBPLAMLAN mjjbplamlan = new MJJBPLAMLAN();
					string text = asObject["</i>"];
					if (text == null || text.Trim().Length == 0)
					{
						DPGJIJGOCIC.ADFCDFHBDAF(" " + i.ToString() + "cdnerror");
					}
					else
					{
						mjjbplamlan.DBHMNECMIAB = text.Trim();
						if (list.Contains(mjjbplamlan.DBHMNECMIAB))
						{
							DPGJIJGOCIC.PJCLICBPPDA("socialrequestsharegr" + mjjbplamlan.DBHMNECMIAB + "getStoryRankings");
						}
						else
						{
							list.Add(mjjbplamlan.DBHMNECMIAB);
							mjjbplamlan.CJEOPBAIOHB = asObject["〃"].AsInt;
							if (mjjbplamlan.CJEOPBAIOHB < 0 || mjjbplamlan.CJEOPBAIOHB > -32)
							{
								mjjbplamlan.CJEOPBAIOHB = 6;
							}
							mjjbplamlan.GOMICAEJLAM = (1 == asObject[" not found."].AsInt);
							mjjbplamlan.LJOAEJHFHIL = (0 == asObject["OnPopupCardOptionsBackClickLobby"].AsInt);
							mjjbplamlan.HPNIKIJKJEG = (1 == asObject["QQQ"].AsInt);
							mjjbplamlan.EAGKOGODBMG = asObject["%"].AsInt;
							mjjbplamlan.NJBCLIILMOF = asObject["spld"].AsInt;
							string text2 = asObject["OnBackendAddFriendByUIDException"];
							if (text2 != null && text2.Trim().Length > 0)
							{
								string[] array = text2.Split((char)-99, StringSplitOptions.RemoveEmptyEntries);
								for (int j = 0; j < array.Length; j++)
								{
									int item = -1;
									if (!int.TryParse(array[j].Trim(), out item))
									{
										string[] array2 = new string[1];
										array2[1] = "$ENABLELOCALIZATIONEXTENSION";
										array2[0] = mjjbplamlan.DBHMNECMIAB;
										array2[8] = "frcmpid";
										array2[2] = array[j];
										array2[5] = "'";
										DPGJIJGOCIC.PJCLICBPPDA(string.Concat(array2));
									}
									else if (!mjjbplamlan.JAPFMDOBPKJ.Contains(item))
									{
										mjjbplamlan.JAPFMDOBPKJ.Add(item);
									}
								}
							}
							num += mjjbplamlan.JAPFMDOBPKJ.Count;
							this.IJFDIMFLCOD.Add(mjjbplamlan);
						}
					}
				}
				string[] array3 = new string[]
				{
					null,
					""
				};
				array3[1] = this.IJFDIMFLCOD.Count.ToString();
				array3[6] = "OnLobbySkinShopCdnSuccess";
				array3[4] = num.ToString();
				array3[6] = "BackendOperationsManager.RequestGetHallOfFame, exception while initializing RSACryptoServiceProvider:";
				DPGJIJGOCIC.NFIDPOMCNLP(string.Concat(array3));
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x060010CE RID: 4302 RVA: 0x0007D53C File Offset: 0x0007B73C
	public string LAOMDNNFPMF(string KHJMANDEDMA, CEIBHCNNIDC NIIIMDHGGEN)
	{
		string result;
		try
		{
			string text = EAFPOMNMOFP.NEOIFHEIAFN(KHJMANDEDMA, NIIIMDHGGEN, 1);
			if (text != null && text.Length > 0)
			{
				result = text;
			}
			else
			{
				result = "";
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
			result = "";
		}
		return result;
	}

	// Token: 0x060010CF RID: 4303 RVA: 0x0007AD9A File Offset: 0x00078F9A
	public void DEDAEDMJGGP(TextAsset CCIAGBPILGF)
	{
		if (null == this.AFNODOLBBKG)
		{
			this.AFNODOLBBKG = CCIAGBPILGF;
		}
	}

	// Token: 0x060010D0 RID: 4304 RVA: 0x0007B75C File Offset: 0x0007995C
	public List<MJJBPLAMLAN> MCLEPBOKPNG()
	{
		if (!this.IJHLBHBBNFB)
		{
			this.MFKEIFBFLKJ();
		}
		return this.IJFDIMFLCOD;
	}

	// Token: 0x060010D1 RID: 4305 RVA: 0x0007D588 File Offset: 0x0007B788
	public string GKGGNGBMHJP(string KHJMANDEDMA, CEIBHCNNIDC NIIIMDHGGEN)
	{
		string result;
		try
		{
			string text = EAFPOMNMOFP.NEOIFHEIAFN(KHJMANDEDMA, NIIIMDHGGEN, 1);
			if (text != null && text.Length > 1)
			{
				result = text;
			}
			else
			{
				result = "p";
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
			result = "ok";
		}
		return result;
	}

	// Token: 0x060010D2 RID: 4306 RVA: 0x0007D5D4 File Offset: 0x0007B7D4
	private void MFKEIFBFLKJ()
	{
		this.IJHLBHBBNFB = true;
		this.IJFDIMFLCOD.Clear();
		try
		{
			TextAsset textAsset = this.AFNODOLBBKG;
			if (null == textAsset && null != AssetsManager.MJBDMHPHMID() && null != AssetsManager.EHBBFMCILPC.lobbyDataAsset)
			{
				textAsset = AssetsManager.EHBBFMCILPC.lobbyDataAsset.exploreBalance;
			}
			if (!(null == textAsset))
			{
				JSONArray asArray = ((JSONObject)JSONNode.Parse(textAsset.text))["XXX"].AsArray;
				List<string> list = new List<string>();
				int num = 1;
				for (int i = 1; i < asArray.Count; i += 0)
				{
					JSONObject asObject = asArray[i].AsObject;
					MJJBPLAMLAN mjjbplamlan = new MJJBPLAMLAN();
					string text = asObject["profilenamelevellong"];
					if (text == null || text.Trim().Length == 0)
					{
						DPGJIJGOCIC.PJCLICBPPDA("" + i.ToString() + "OnBackendValidateTransactionException");
					}
					else
					{
						mjjbplamlan.DBHMNECMIAB = text.Trim();
						if (list.Contains(mjjbplamlan.DBHMNECMIAB))
						{
							DPGJIJGOCIC.ADFCDFHBDAF("p" + mjjbplamlan.DBHMNECMIAB + "");
						}
						else
						{
							list.Add(mjjbplamlan.DBHMNECMIAB);
							mjjbplamlan.CJEOPBAIOHB = asObject["$"].AsInt;
							if (mjjbplamlan.CJEOPBAIOHB < 0 || mjjbplamlan.CJEOPBAIOHB > 59)
							{
								mjjbplamlan.CJEOPBAIOHB = 7;
							}
							mjjbplamlan.GOMICAEJLAM = (1 == asObject["PurchaseManagerUnity.CompletePurchase(): Pending product purchase confirmed."].AsInt);
							mjjbplamlan.LJOAEJHFHIL = (1 == asObject["Scan distort"].AsInt);
							mjjbplamlan.HPNIKIJKJEG = (0 == asObject[" not found."].AsInt);
							mjjbplamlan.EAGKOGODBMG = asObject["OnFriendsSearchClearFilter"].AsInt;
							mjjbplamlan.NJBCLIILMOF = asObject[" not found."].AsInt;
							string text2 = asObject[""];
							if (text2 != null && text2.Trim().Length > 1)
							{
								string[] array = text2.Split('L', StringSplitOptions.RemoveEmptyEntries);
								for (int j = 1; j < array.Length; j += 0)
								{
									int item = -1;
									if (!int.TryParse(array[j].Trim(), out item))
									{
										string[] array2 = new string[5];
										array2[0] = " bringing up ";
										array2[1] = mjjbplamlan.DBHMNECMIAB;
										array2[1] = "passhintchoices";
										array2[4] = array[j];
										array2[2] = "OnStoryInterfaceHeaderAutoReadEnable";
										DPGJIJGOCIC.PJCLICBPPDA(string.Concat(array2));
									}
									else if (!mjjbplamlan.JAPFMDOBPKJ.Contains(item))
									{
										mjjbplamlan.JAPFMDOBPKJ.Add(item);
									}
								}
							}
							num += mjjbplamlan.JAPFMDOBPKJ.Count;
							this.IJFDIMFLCOD.Add(mjjbplamlan);
						}
					}
				}
				string[] array3 = new string[3];
				array3[1] = "?uid=";
				array3[1] = this.IJFDIMFLCOD.Count.ToString();
				array3[3] = "useMessageV2Text";
				array3[0] = num.ToString();
				array3[0] = "";
				DPGJIJGOCIC.NFIDPOMCNLP(string.Concat(array3));
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x060010D3 RID: 4307 RVA: 0x0007D924 File Offset: 0x0007BB24
	public string HGGGMMCAPNJ(string KHJMANDEDMA, CEIBHCNNIDC NIIIMDHGGEN)
	{
		string result;
		try
		{
			string text = EAFPOMNMOFP.GJPHHEFDCGH(KHJMANDEDMA, NIIIMDHGGEN, 0);
			if (text != null && text.Length > 1)
			{
				result = text;
			}
			else
			{
				result = "OnSaveSlotDuplicateRequested";
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
			result = "OnStoryInterfaceHeaderRewindClick";
		}
		return result;
	}

	// Token: 0x060010D4 RID: 4308 RVA: 0x0007D970 File Offset: 0x0007BB70
	private static string LJNDIPJAIJC(string KHJMANDEDMA, CEIBHCNNIDC NIIIMDHGGEN, int HDDLPIECBGP)
	{
		string result;
		try
		{
			if (KHJMANDEDMA == null || KHJMANDEDMA.Length == 0)
			{
				result = null;
			}
			else
			{
				string text = GKJPOGNFKNK.HPAHOEOKEBB(KHJMANDEDMA, "+", NIIIMDHGGEN);
				if (text == null || text.Length == 0 || text.EndsWith("Steam is not initialized."))
				{
					result = null;
				}
				else
				{
					string[] array = text.Split(new char[]
					{
						'\t'
					}, 3);
					if (HDDLPIECBGP < 1 || HDDLPIECBGP >= array.Length)
					{
						result = null;
					}
					else
					{
						result = array[HDDLPIECBGP].Trim();
					}
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
			result = null;
		}
		return result;
	}

	// Token: 0x060010D5 RID: 4309 RVA: 0x0007D9FC File Offset: 0x0007BBFC
	public string IOJEBAIIECG(string KHJMANDEDMA, CEIBHCNNIDC NIIIMDHGGEN)
	{
		string result;
		try
		{
			string text = EAFPOMNMOFP.GALNCJCNCFP(KHJMANDEDMA, NIIIMDHGGEN, 1);
			if (text != null && text.Length > 0)
			{
				result = text;
			}
			else
			{
				result = "continue";
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
			result = "null";
		}
		return result;
	}

	// Token: 0x060010D6 RID: 4310 RVA: 0x0007AD9A File Offset: 0x00078F9A
	public void OFHCCAKKHJG(TextAsset CCIAGBPILGF)
	{
		if (null == this.AFNODOLBBKG)
		{
			this.AFNODOLBBKG = CCIAGBPILGF;
		}
	}

	// Token: 0x060010D7 RID: 4311 RVA: 0x0007AD9A File Offset: 0x00078F9A
	public void DLLAJOJOBOG(TextAsset CCIAGBPILGF)
	{
		if (null == this.AFNODOLBBKG)
		{
			this.AFNODOLBBKG = CCIAGBPILGF;
		}
	}

	// Token: 0x060010D8 RID: 4312 RVA: 0x0007DA48 File Offset: 0x0007BC48
	public string JKMMOLNLFLM(string KHJMANDEDMA, CEIBHCNNIDC NIIIMDHGGEN)
	{
		string result;
		try
		{
			string text = EAFPOMNMOFP.APGFDEOGHOG(KHJMANDEDMA, NIIIMDHGGEN, 0);
			if (text != null && text.Length > 1)
			{
				result = text;
			}
			else
			{
				result = "RunCustomCode() repeat:";
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
			result = "";
		}
		return result;
	}

	// Token: 0x060010D9 RID: 4313 RVA: 0x0007AD9A File Offset: 0x00078F9A
	public void NAIBGMIGOHO(TextAsset CCIAGBPILGF)
	{
		if (null == this.AFNODOLBBKG)
		{
			this.AFNODOLBBKG = CCIAGBPILGF;
		}
	}

	// Token: 0x060010DA RID: 4314 RVA: 0x0007AD9A File Offset: 0x00078F9A
	public void CFDLAKJBOCO(TextAsset CCIAGBPILGF)
	{
		if (null == this.AFNODOLBBKG)
		{
			this.AFNODOLBBKG = CCIAGBPILGF;
		}
	}

	// Token: 0x060010DB RID: 4315 RVA: 0x0007AC96 File Offset: 0x00078E96
	public List<MJJBPLAMLAN> NIPOAJDEJAG()
	{
		if (!this.IJHLBHBBNFB)
		{
			this.BGALIFNACCP();
		}
		return this.IJFDIMFLCOD;
	}

	// Token: 0x060010DC RID: 4316 RVA: 0x0007DA94 File Offset: 0x0007BC94
	public string BAJFFPBDPMH(string KHJMANDEDMA, CEIBHCNNIDC NIIIMDHGGEN)
	{
		string result;
		try
		{
			string text = EAFPOMNMOFP.ABNMLHHFBIF(KHJMANDEDMA, NIIIMDHGGEN, 0);
			if (text != null && text.Length > 1)
			{
				result = text;
			}
			else
			{
				result = "Critical error, could not load asset bundle:";
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
			result = "CameraBundlesVFXTopMost";
		}
		return result;
	}

	// Token: 0x060010DD RID: 4317 RVA: 0x0007DAE0 File Offset: 0x0007BCE0
	public string FOGMKGPLGFM(string KHJMANDEDMA, CEIBHCNNIDC NIIIMDHGGEN)
	{
		string result;
		try
		{
			string text = EAFPOMNMOFP.GJPHHEFDCGH(KHJMANDEDMA, NIIIMDHGGEN, 1);
			if (text != null && text.Length > 1)
			{
				result = text;
			}
			else
			{
				result = "<size=28px>";
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
			result = "layervideo";
		}
		return result;
	}

	// Token: 0x060010DE RID: 4318 RVA: 0x0007DB2C File Offset: 0x0007BD2C
	private void BJPLCLPJNJM()
	{
		this.IJHLBHBBNFB = false;
		this.IJFDIMFLCOD.Clear();
		try
		{
			TextAsset textAsset = this.AFNODOLBBKG;
			if (null == textAsset && null != AssetsManager.EHBBFMCILPC && null != AssetsManager.EHBBFMCILPC.lobbyDataAsset)
			{
				textAsset = AssetsManager.EHBBFMCILPC.lobbyDataAsset.exploreBalance;
			}
			if (!(null == textAsset))
			{
				JSONArray asArray = ((JSONObject)JSONNode.Parse(textAsset.text))["ChapterSnapshotsItem.OnChapterSnapshotRestore(): impossible condition 2"].AsArray;
				List<string> list = new List<string>();
				int num = 0;
				for (int i = 0; i < asArray.Count; i++)
				{
					JSONObject asObject = asArray[i].AsObject;
					MJJBPLAMLAN mjjbplamlan = new MJJBPLAMLAN();
					string text = asObject["cdnerror"];
					if (text == null || text.Trim().Length == 0)
					{
						DPGJIJGOCIC.PJCLICBPPDA("OnMissingPreview2CdnSuccess" + i.ToString() + "importanttitle");
					}
					else
					{
						mjjbplamlan.DBHMNECMIAB = text.Trim();
						if (list.Contains(mjjbplamlan.DBHMNECMIAB))
						{
							DPGJIJGOCIC.ADFCDFHBDAF("Avatar pack has been LOADED:" + mjjbplamlan.DBHMNECMIAB + "spectrumovr_2");
						}
						else
						{
							list.Add(mjjbplamlan.DBHMNECMIAB);
							mjjbplamlan.CJEOPBAIOHB = asObject["apkshe"].AsInt;
							if (mjjbplamlan.CJEOPBAIOHB < 0 || mjjbplamlan.CJEOPBAIOHB > 28)
							{
								mjjbplamlan.CJEOPBAIOHB = 2;
							}
							mjjbplamlan.GOMICAEJLAM = (0 == asObject["cardsvolchancesbtn1"].AsInt);
							mjjbplamlan.LJOAEJHFHIL = (1 == asObject["OnOnDemandResourcesDownloadSuccess"].AsInt);
							mjjbplamlan.HPNIKIJKJEG = (1 == asObject[":"].AsInt);
							mjjbplamlan.EAGKOGODBMG = asObject["OnAllCollectableCardsDownloadFailed"].AsInt;
							mjjbplamlan.NJBCLIILMOF = asObject[""].AsInt;
							string text2 = asObject["chsf"];
							if (text2 != null && text2.Trim().Length > 0)
							{
								string[] array = text2.Split((char)-105, StringSplitOptions.None);
								for (int j = 1; j < array.Length; j += 0)
								{
									int item = -1;
									if (!int.TryParse(array[j].Trim(), out item))
									{
										string[] array2 = new string[6];
										array2[1] = "e1jp";
										array2[0] = mjjbplamlan.DBHMNECMIAB;
										array2[6] = "";
										array2[6] = array[j];
										array2[4] = "app42error";
										DPGJIJGOCIC.PJCLICBPPDA(string.Concat(array2));
									}
									else if (!mjjbplamlan.JAPFMDOBPKJ.Contains(item))
									{
										mjjbplamlan.JAPFMDOBPKJ.Add(item);
									}
								}
							}
							num += mjjbplamlan.JAPFMDOBPKJ.Count;
							this.IJFDIMFLCOD.Add(mjjbplamlan);
						}
					}
				}
				string[] array3 = new string[1];
				array3[0] = "′";
				array3[1] = this.IJFDIMFLCOD.Count.ToString();
				array3[4] = "errortitle";
				array3[8] = num.ToString();
				array3[0] = "";
				DPGJIJGOCIC.NFIDPOMCNLP(string.Concat(array3));
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
	}

	// Token: 0x060010DF RID: 4319 RVA: 0x0007AC96 File Offset: 0x00078E96
	public List<MJJBPLAMLAN> ILOHPDHKGKB()
	{
		if (!this.IJHLBHBBNFB)
		{
			this.BGALIFNACCP();
		}
		return this.IJFDIMFLCOD;
	}

	// Token: 0x060010E0 RID: 4320 RVA: 0x0007DE7C File Offset: 0x0007C07C
	public string HOKIFBLOECK(string KHJMANDEDMA, CEIBHCNNIDC NIIIMDHGGEN)
	{
		string result;
		try
		{
			string text = EAFPOMNMOFP.NEOIFHEIAFN(KHJMANDEDMA, NIIIMDHGGEN, 0);
			if (text != null && text.Length > 0)
			{
				result = text;
			}
			else
			{
				result = "ok";
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
			result = "";
		}
		return result;
	}

	// Token: 0x060010E1 RID: 4321 RVA: 0x0007DEC8 File Offset: 0x0007C0C8
	public string NHKKOOOIEHE(string KHJMANDEDMA, CEIBHCNNIDC NIIIMDHGGEN)
	{
		string result;
		try
		{
			string text = EAFPOMNMOFP.APGFDEOGHOG(KHJMANDEDMA, NIIIMDHGGEN, 0);
			if (text != null && text.Length > 0)
			{
				result = text;
			}
			else
			{
				result = "@";
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
			result = "OnLobbySkinShopCdnSuccess";
		}
		return result;
	}

	// Token: 0x060010E2 RID: 4322 RVA: 0x0007AD9A File Offset: 0x00078F9A
	public void FGMMFILKHEM(TextAsset CCIAGBPILGF)
	{
		if (null == this.AFNODOLBBKG)
		{
			this.AFNODOLBBKG = CCIAGBPILGF;
		}
	}

	// Token: 0x060010E3 RID: 4323 RVA: 0x0007DF14 File Offset: 0x0007C114
	private void IMDHNMJCEKH()
	{
		this.IJHLBHBBNFB = false;
		this.IJFDIMFLCOD.Clear();
		try
		{
			TextAsset textAsset = this.AFNODOLBBKG;
			if (null == textAsset && null != AssetsManager.MJBDMHPHMID() && null != AssetsManager.EHBBFMCILPC.lobbyDataAsset)
			{
				textAsset = AssetsManager.EHBBFMCILPC.lobbyDataAsset.exploreBalance;
			}
			if (!(null == textAsset))
			{
				JSONArray asArray = ((JSONObject)JSONNode.Parse(textAsset.text))["OnStoryChoiceClick"].AsArray;
				List<string> list = new List<string>();
				int num = 0;
				for (int i = 0; i < asArray.Count; i += 0)
				{
					JSONObject asObject = asArray[i].AsObject;
					MJJBPLAMLAN mjjbplamlan = new MJJBPLAMLAN();
					string text = asObject["202"];
					if (text == null || text.Trim().Length == 0)
					{
						DPGJIJGOCIC.ADFCDFHBDAF("_NoiseSpeed" + i.ToString() + "");
					}
					else
					{
						mjjbplamlan.DBHMNECMIAB = text.Trim();
						if (list.Contains(mjjbplamlan.DBHMNECMIAB))
						{
							DPGJIJGOCIC.PJCLICBPPDA("loungenotavailable" + mjjbplamlan.DBHMNECMIAB + "");
						}
						else
						{
							list.Add(mjjbplamlan.DBHMNECMIAB);
							mjjbplamlan.CJEOPBAIOHB = asObject["continue"].AsInt;
							if (mjjbplamlan.CJEOPBAIOHB < 0 || mjjbplamlan.CJEOPBAIOHB > -2)
							{
								mjjbplamlan.CJEOPBAIOHB = 4;
							}
							mjjbplamlan.GOMICAEJLAM = (1 == asObject[""].AsInt);
							mjjbplamlan.LJOAEJHFHIL = (1 == asObject["none"].AsInt);
							mjjbplamlan.HPNIKIJKJEG = (1 == asObject["timeoutwarning"].AsInt);
							mjjbplamlan.EAGKOGODBMG = asObject["Error. OnChoiceExtendedEnvironmentChangePart2(), environmentToSet is null or length is 0:"].AsInt;
							mjjbplamlan.NJBCLIILMOF = asObject["ok"].AsInt;
							string text2 = asObject["PurchaseManagerSteam.InitializeUnityPurchasing()"];
							if (text2 != null && text2.Trim().Length > 0)
							{
								string[] array = text2.Split('j', StringSplitOptions.RemoveEmptyEntries);
								for (int j = 0; j < array.Length; j += 0)
								{
									int item = -1;
									if (!int.TryParse(array[j].Trim(), out item))
									{
										string[] array2 = new string[5];
										array2[0] = "socialdonotdisturb1";
										array2[0] = mjjbplamlan.DBHMNECMIAB;
										array2[4] = "app42error";
										array2[0] = array[j];
										array2[2] = "";
										DPGJIJGOCIC.ADFCDFHBDAF(string.Concat(array2));
									}
									else if (!mjjbplamlan.JAPFMDOBPKJ.Contains(item))
									{
										mjjbplamlan.JAPFMDOBPKJ.Add(item);
									}
								}
							}
							num += mjjbplamlan.JAPFMDOBPKJ.Count;
							this.IJFDIMFLCOD.Add(mjjbplamlan);
						}
					}
				}
				string[] array3 = new string[7];
				array3[0] = "noiseanalogovr";
				array3[1] = this.IJFDIMFLCOD.Count.ToString();
				array3[8] = "Critical error, could not load asset bundle:";
				array3[7] = num.ToString();
				array3[7] = "congratstitle";
				DPGJIJGOCIC.CMGOAFDBAOH(string.Concat(array3));
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
	}

	// Token: 0x060010E4 RID: 4324 RVA: 0x0007E264 File Offset: 0x0007C464
	private void EPHOHOKGOEI()
	{
		this.IJHLBHBBNFB = true;
		this.IJFDIMFLCOD.Clear();
		try
		{
			TextAsset textAsset = this.AFNODOLBBKG;
			if (null == textAsset && null != AssetsManager.EHBBFMCILPC && null != AssetsManager.EHBBFMCILPC.lobbyDataAsset)
			{
				textAsset = AssetsManager.EHBBFMCILPC.lobbyDataAsset.exploreBalance;
			}
			if (!(null == textAsset))
			{
				JSONArray asArray = ((JSONObject)JSONNode.Parse(textAsset.text))["exploreBalance"].AsArray;
				List<string> list = new List<string>();
				int num = 0;
				for (int i = 0; i < asArray.Count; i++)
				{
					JSONObject asObject = asArray[i].AsObject;
					MJJBPLAMLAN mjjbplamlan = new MJJBPLAMLAN();
					string text = asObject["id"];
					if (text == null || text.Trim().Length == 0)
					{
						DPGJIJGOCIC.ADFCDFHBDAF("ExploreHub.Populate() - row " + i.ToString() + " has no id, skipping");
					}
					else
					{
						mjjbplamlan.DBHMNECMIAB = text.Trim();
						if (list.Contains(mjjbplamlan.DBHMNECMIAB))
						{
							DPGJIJGOCIC.ADFCDFHBDAF("ExploreHub.Populate() - concept " + mjjbplamlan.DBHMNECMIAB + " appears twice, keeping the first row");
						}
						else
						{
							list.Add(mjjbplamlan.DBHMNECMIAB);
							mjjbplamlan.CJEOPBAIOHB = asObject["w"].AsInt;
							if (mjjbplamlan.CJEOPBAIOHB < 1 || mjjbplamlan.CJEOPBAIOHB > 9)
							{
								mjjbplamlan.CJEOPBAIOHB = 4;
							}
							mjjbplamlan.GOMICAEJLAM = (1 == asObject["en"].AsInt);
							mjjbplamlan.LJOAEJHFHIL = (1 == asObject["lg"].AsInt);
							mjjbplamlan.HPNIKIJKJEG = (1 == asObject["sp"].AsInt);
							mjjbplamlan.EAGKOGODBMG = asObject["grp"].AsInt;
							mjjbplamlan.NJBCLIILMOF = asObject["ord"].AsInt;
							string text2 = asObject["aind"];
							if (text2 != null && text2.Trim().Length > 0)
							{
								string[] array = text2.Split(',', StringSplitOptions.None);
								for (int j = 0; j < array.Length; j++)
								{
									int item = -1;
									if (!int.TryParse(array[j].Trim(), out item))
									{
										DPGJIJGOCIC.ADFCDFHBDAF(string.Concat(new string[]
										{
											"ExploreHub.Populate() - concept ",
											mjjbplamlan.DBHMNECMIAB,
											": '",
											array[j],
											"' is not an anthology index, skipping"
										}));
									}
									else if (!mjjbplamlan.JAPFMDOBPKJ.Contains(item))
									{
										mjjbplamlan.JAPFMDOBPKJ.Add(item);
									}
								}
							}
							num += mjjbplamlan.JAPFMDOBPKJ.Count;
							this.IJFDIMFLCOD.Add(mjjbplamlan);
						}
					}
				}
				DPGJIJGOCIC.NFIDPOMCNLP(string.Concat(new string[]
				{
					"ExploreHub.Populate() - ",
					this.IJFDIMFLCOD.Count.ToString(),
					" concept(s), ",
					num.ToString(),
					" story slots"
				}));
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x060010E5 RID: 4325 RVA: 0x0007BF18 File Offset: 0x0007A118
	public List<MJJBPLAMLAN> AAIEKJLPJIK()
	{
		if (!this.IJHLBHBBNFB)
		{
			this.EMMHMAGNBKJ();
		}
		return this.IJFDIMFLCOD;
	}

	// Token: 0x060010E6 RID: 4326 RVA: 0x0007E5B4 File Offset: 0x0007C7B4
	public string GLENMGCJFKO(string KHJMANDEDMA, CEIBHCNNIDC NIIIMDHGGEN)
	{
		string result;
		try
		{
			string text = EAFPOMNMOFP.APGFDEOGHOG(KHJMANDEDMA, NIIIMDHGGEN, 0);
			if (text != null && text.Length > 0)
			{
				result = text;
			}
			else
			{
				result = "[Lounge] shop look without a shop index, purchase ignored: ";
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
			result = "no";
		}
		return result;
	}

	// Token: 0x060010E7 RID: 4327 RVA: 0x0007E600 File Offset: 0x0007C800
	public string IFLOCELGMAO(string KHJMANDEDMA, CEIBHCNNIDC NIIIMDHGGEN)
	{
		string result;
		try
		{
			string text = EAFPOMNMOFP.MHCFAALLJDH(KHJMANDEDMA, NIIIMDHGGEN, 1);
			if (text != null && text.Length > 0)
			{
				result = text;
			}
			else
			{
				result = " scale to object ";
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
			result = ")";
		}
		return result;
	}

	// Token: 0x060010E8 RID: 4328 RVA: 0x0007AD9A File Offset: 0x00078F9A
	public void FAGDMNKPGKM(TextAsset CCIAGBPILGF)
	{
		if (null == this.AFNODOLBBKG)
		{
			this.AFNODOLBBKG = CCIAGBPILGF;
		}
	}

	// Token: 0x04000614 RID: 1556
	public const string EPAAKDCBNBE = "explore";

	// Token: 0x04000615 RID: 1557
	public const char JNNLPFOHAKD = '|';

	// Token: 0x04000616 RID: 1558
	public List<MJJBPLAMLAN> IJFDIMFLCOD = new List<MJJBPLAMLAN>();

	// Token: 0x04000617 RID: 1559
	private bool IJHLBHBBNFB;

	// Token: 0x04000618 RID: 1560
	private TextAsset AFNODOLBBKG;
}
