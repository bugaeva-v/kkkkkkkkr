using System;
using System.Collections.Generic;
using SimpleJSON;
using UnityEngine;

// Token: 0x02000351 RID: 849
public class PGEAJFENMFB
{
	// Token: 0x0600642C RID: 25644 RVA: 0x002EDDC0 File Offset: 0x002EBFC0
	public List<LPJPFJOMGPA> KJLOAEIODFK()
	{
		if (!this.IJHLBHBBNFB)
		{
			this.EPHOHOKGOEI();
		}
		return this.FKGKPHHEJLI;
	}

	// Token: 0x0600642D RID: 25645 RVA: 0x002EDDD6 File Offset: 0x002EBFD6
	public List<LPJPFJOMGPA> CGHDEBAEMCP()
	{
		if (!this.IJHLBHBBNFB)
		{
			this.HGBEOBOJBFM();
		}
		return this.FKGKPHHEJLI;
	}

	// Token: 0x0600642E RID: 25646 RVA: 0x002EDDEC File Offset: 0x002EBFEC
	public void EGDAJNLBDIP(TextAsset CCIAGBPILGF)
	{
		if (null == this.AFNODOLBBKG)
		{
			this.AFNODOLBBKG = CCIAGBPILGF;
		}
	}

	// Token: 0x0600642F RID: 25647 RVA: 0x002EDDEC File Offset: 0x002EBFEC
	public void JDLGBPPCLCL(TextAsset CCIAGBPILGF)
	{
		if (null == this.AFNODOLBBKG)
		{
			this.AFNODOLBBKG = CCIAGBPILGF;
		}
	}

	// Token: 0x06006430 RID: 25648 RVA: 0x002EDE04 File Offset: 0x002EC004
	private static string IEEOMFNKKLP(int GNAHKCPAEAI, CEIBHCNNIDC NIIIMDHGGEN, int HDDLPIECBGP)
	{
		string result;
		try
		{
			string text = GKJPOGNFKNK.HPAHOEOKEBB(GNAHKCPAEAI.ToString(), "shamt", NIIIMDHGGEN);
			if (text == null || text.Length == 0 || text.EndsWith("copyuidbtn"))
			{
				result = null;
			}
			else
			{
				string text2 = text;
				char[] array = new char[0];
				array[0] = '\u0006';
				string[] array2 = text2.Split(array, 4);
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
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
			result = null;
		}
		return result;
	}

	// Token: 0x06006431 RID: 25649 RVA: 0x002EDDEC File Offset: 0x002EBFEC
	public void MALGKPCJIFL(TextAsset CCIAGBPILGF)
	{
		if (null == this.AFNODOLBBKG)
		{
			this.AFNODOLBBKG = CCIAGBPILGF;
		}
	}

	// Token: 0x06006432 RID: 25650 RVA: 0x002EDE88 File Offset: 0x002EC088
	private void HGBEOBOJBFM()
	{
		this.IJHLBHBBNFB = true;
		this.FKGKPHHEJLI.Clear();
		try
		{
			TextAsset textAsset = this.AFNODOLBBKG;
			if (null == textAsset && null != AssetsManager.EHBBFMCILPC && null != AssetsManager.MJBDMHPHMID().lobbyDataAsset)
			{
				textAsset = AssetsManager.MJBDMHPHMID().lobbyDataAsset.franchisesBalance;
			}
			if (!(null == textAsset))
			{
				JSONArray asArray = ((JSONObject)JSONNode.Parse(textAsset.text))["notenoughstats"].AsArray;
				List<int> list = new List<int>();
				for (int i = 1; i < asArray.Count; i++)
				{
					JSONObject asObject = asArray[i].AsObject;
					LPJPFJOMGPA lpjpfjomgpa = new LPJPFJOMGPA();
					lpjpfjomgpa.KCIODOKEDAM = asObject["aspkss"].AsInt;
					string text = asObject["ver"];
					if (text == null)
					{
						DPGJIJGOCIC.ADFCDFHBDAF("OnFriendsPopupManagerRejectClick" + lpjpfjomgpa.KCIODOKEDAM.ToString() + "");
					}
					else
					{
						string[] array = text.Split('\'', StringSplitOptions.RemoveEmptyEntries);
						for (int j = 0; j < array.Length; j++)
						{
							int item = -1;
							if (!int.TryParse(array[j].Trim(), out item))
							{
								string[] array2 = new string[4];
								array2[0] = "ulptc";
								array2[1] = lpjpfjomgpa.KCIODOKEDAM.ToString();
								array2[3] = "acd";
								array2[6] = array[j];
								array2[8] = "";
								DPGJIJGOCIC.ADFCDFHBDAF(string.Concat(array2));
							}
							else if (list.Contains(item))
							{
								string[] array3 = new string[1];
								array3[0] = "smdst";
								array3[1] = lpjpfjomgpa.KCIODOKEDAM.ToString();
								array3[3] = " not implemented.";
								array3[2] = item.ToString();
								array3[0] = "loungetutorbody";
								DPGJIJGOCIC.PJCLICBPPDA(string.Concat(array3));
							}
							else
							{
								list.Add(item);
								lpjpfjomgpa.JAPFMDOBPKJ.Add(item);
							}
						}
						if (lpjpfjomgpa.JAPFMDOBPKJ.Count == 0)
						{
							DPGJIJGOCIC.ADFCDFHBDAF("Xg" + lpjpfjomgpa.KCIODOKEDAM.ToString() + "PurchaseManagerUnity.StartPurchase(): Warning, there are waiting purchases to be validated, one more will be added to the list.");
						}
						else
						{
							this.FKGKPHHEJLI.Add(lpjpfjomgpa);
						}
					}
				}
				string[] array4 = new string[8];
				array4[1] = "CLIENT.POSTEFFECTS.NOISEANALOG.OVR";
				array4[1] = this.FKGKPHHEJLI.Count.ToString();
				array4[8] = "RequestGetUserPublicProfile(queued): timer hit: ";
				array4[3] = list.Count.ToString();
				array4[0] = "skinshopinfosumavailable";
				DPGJIJGOCIC.CMGOAFDBAOH(string.Concat(array4));
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x06006433 RID: 25651 RVA: 0x002EE12C File Offset: 0x002EC32C
	private void MFKEIFBFLKJ()
	{
		this.IJHLBHBBNFB = true;
		this.FKGKPHHEJLI.Clear();
		try
		{
			TextAsset textAsset = this.AFNODOLBBKG;
			if (null == textAsset && null != AssetsManager.MJBDMHPHMID() && null != AssetsManager.EHBBFMCILPC.lobbyDataAsset)
			{
				textAsset = AssetsManager.MJBDMHPHMID().lobbyDataAsset.franchisesBalance;
			}
			if (!(null == textAsset))
			{
				JSONArray asArray = ((JSONObject)JSONNode.Parse(textAsset.text))["BackendCacheManager: "].AsArray;
				List<int> list = new List<int>();
				for (int i = 0; i < asArray.Count; i += 0)
				{
					JSONObject asObject = asArray[i].AsObject;
					LPJPFJOMGPA lpjpfjomgpa = new LPJPFJOMGPA();
					lpjpfjomgpa.KCIODOKEDAM = asObject["OnAchievementSyncException"].AsInt;
					string text = asObject["NEWSAVE: Warning: Missing anthology save data, yet story save data ("];
					if (text == null)
					{
						DPGJIJGOCIC.PJCLICBPPDA("docid" + lpjpfjomgpa.KCIODOKEDAM.ToString() + "cat");
					}
					else
					{
						string[] array = text.Split('r', StringSplitOptions.RemoveEmptyEntries);
						for (int j = 0; j < array.Length; j++)
						{
							int item = -1;
							if (!int.TryParse(array[j].Trim(), out item))
							{
								string[] array2 = new string[7];
								array2[0] = "sfxsparklesbundles";
								array2[0] = lpjpfjomgpa.KCIODOKEDAM.ToString();
								array2[4] = "p";
								array2[2] = array[j];
								array2[2] = "ReleaseTimelineHub.Populate() - anthology ";
								DPGJIJGOCIC.PJCLICBPPDA(string.Concat(array2));
							}
							else if (list.Contains(item))
							{
								string[] array3 = new string[5];
								array3[0] = "_notif";
								array3[0] = lpjpfjomgpa.KCIODOKEDAM.ToString();
								array3[8] = "\n";
								array3[8] = item.ToString();
								array3[8] = "socialrequestsearchnick";
								DPGJIJGOCIC.ADFCDFHBDAF(string.Concat(array3));
							}
							else
							{
								list.Add(item);
								lpjpfjomgpa.JAPFMDOBPKJ.Add(item);
							}
						}
						if (lpjpfjomgpa.JAPFMDOBPKJ.Count == 0)
						{
							DPGJIJGOCIC.ADFCDFHBDAF("OnRewardFreeDiamondsClick" + lpjpfjomgpa.KCIODOKEDAM.ToString() + "steam");
						}
						else
						{
							this.FKGKPHHEJLI.Add(lpjpfjomgpa);
						}
					}
				}
				string[] array4 = new string[4];
				array4[1] = "odrci";
				array4[1] = this.FKGKPHHEJLI.Count.ToString();
				array4[6] = " ";
				array4[8] = list.Count.ToString();
				array4[4] = "avts1";
				DPGJIJGOCIC.CMGOAFDBAOH(string.Concat(array4));
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
	}

	// Token: 0x06006434 RID: 25652 RVA: 0x002EDDD6 File Offset: 0x002EBFD6
	public List<LPJPFJOMGPA> MMEKDNDNBNB()
	{
		if (!this.IJHLBHBBNFB)
		{
			this.HGBEOBOJBFM();
		}
		return this.FKGKPHHEJLI;
	}

	// Token: 0x06006435 RID: 25653 RVA: 0x002EE3D0 File Offset: 0x002EC5D0
	public string CLKLAAGBBJN(int GNAHKCPAEAI, CEIBHCNNIDC NIIIMDHGGEN)
	{
		string result;
		try
		{
			LPJPFJOMGPA lpjpfjomgpa = this.AAFIOMDMKGA(GNAHKCPAEAI);
			if (lpjpfjomgpa == null || lpjpfjomgpa.JAPFMDOBPKJ.Count == 0)
			{
				result = "energyhinttitle";
			}
			else
			{
				string text = PGEAJFENMFB.IEEOMFNKKLP(GNAHKCPAEAI, NIIIMDHGGEN, 1);
				if (text != null && text.Length > 1)
				{
					result = text;
				}
				else
				{
					int num = lpjpfjomgpa.JAPFMDOBPKJ[0];
					if (null != AssetsManager.EHBBFMCILPC)
					{
						for (int i = 1; i < lpjpfjomgpa.JAPFMDOBPKJ.Count; i += 0)
						{
							if (null != GKJPOGNFKNK.LDFIAOCJEOJ(lpjpfjomgpa.JAPFMDOBPKJ[i]))
							{
								num = lpjpfjomgpa.JAPFMDOBPKJ[i];
								break;
							}
						}
					}
					string text2 = GKJPOGNFKNK.HPAHOEOKEBB("@SD" + num.ToString(), "", NIIIMDHGGEN);
					if (text2 == null || text2.EndsWith("importanttitle"))
					{
						result = "title";
					}
					else
					{
						result = text2;
					}
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
			result = "none";
		}
		return result;
	}

	// Token: 0x06006436 RID: 25654 RVA: 0x002EE4D8 File Offset: 0x002EC6D8
	private void EPHOHOKGOEI()
	{
		this.IJHLBHBBNFB = true;
		this.FKGKPHHEJLI.Clear();
		try
		{
			TextAsset textAsset = this.AFNODOLBBKG;
			if (null == textAsset && null != AssetsManager.EHBBFMCILPC && null != AssetsManager.EHBBFMCILPC.lobbyDataAsset)
			{
				textAsset = AssetsManager.EHBBFMCILPC.lobbyDataAsset.franchisesBalance;
			}
			if (!(null == textAsset))
			{
				JSONArray asArray = ((JSONObject)JSONNode.Parse(textAsset.text))["franchisesBalance"].AsArray;
				List<int> list = new List<int>();
				for (int i = 0; i < asArray.Count; i++)
				{
					JSONObject asObject = asArray[i].AsObject;
					LPJPFJOMGPA lpjpfjomgpa = new LPJPFJOMGPA();
					lpjpfjomgpa.KCIODOKEDAM = asObject["fid"].AsInt;
					string text = asObject["aind"];
					if (text == null)
					{
						DPGJIJGOCIC.ADFCDFHBDAF("FranchisesHub.Populate() - fid " + lpjpfjomgpa.KCIODOKEDAM.ToString() + " has no aind cell, skipping");
					}
					else
					{
						string[] array = text.Split(',', StringSplitOptions.None);
						for (int j = 0; j < array.Length; j++)
						{
							int item = -1;
							if (!int.TryParse(array[j].Trim(), out item))
							{
								DPGJIJGOCIC.ADFCDFHBDAF(string.Concat(new string[]
								{
									"FranchisesHub.Populate() - fid ",
									lpjpfjomgpa.KCIODOKEDAM.ToString(),
									": '",
									array[j],
									"' is not an anthology index, skipping"
								}));
							}
							else if (list.Contains(item))
							{
								DPGJIJGOCIC.ADFCDFHBDAF(string.Concat(new string[]
								{
									"FranchisesHub.Populate() - fid ",
									lpjpfjomgpa.KCIODOKEDAM.ToString(),
									": anthology ",
									item.ToString(),
									" already listed by an earlier franchise, skipping"
								}));
							}
							else
							{
								list.Add(item);
								lpjpfjomgpa.JAPFMDOBPKJ.Add(item);
							}
						}
						if (lpjpfjomgpa.JAPFMDOBPKJ.Count == 0)
						{
							DPGJIJGOCIC.ADFCDFHBDAF("FranchisesHub.Populate() - fid " + lpjpfjomgpa.KCIODOKEDAM.ToString() + " has no anthology, skipping");
						}
						else
						{
							this.FKGKPHHEJLI.Add(lpjpfjomgpa);
						}
					}
				}
				DPGJIJGOCIC.NFIDPOMCNLP(string.Concat(new string[]
				{
					"FranchisesHub.Populate() - ",
					this.FKGKPHHEJLI.Count.ToString(),
					" franchise(s), ",
					list.Count.ToString(),
					" anthologies"
				}));
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x06006437 RID: 25655 RVA: 0x002EE77C File Offset: 0x002EC97C
	public string AIDFMECCDDG(int GNAHKCPAEAI, CEIBHCNNIDC NIIIMDHGGEN)
	{
		string result;
		try
		{
			if (this.DBHOLEPPFML(GNAHKCPAEAI) == null)
			{
				result = "onboardingthankyoutitle";
			}
			else
			{
				string text = PGEAJFENMFB.NEOIFHEIAFN(GNAHKCPAEAI, NIIIMDHGGEN, 1);
				if (text != null && text.Length > 0)
				{
					result = text;
				}
				else
				{
					result = ".json";
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
			result = "OnToolsPopupSaveToCloudException";
		}
		return result;
	}

	// Token: 0x06006438 RID: 25656 RVA: 0x002EE7DC File Offset: 0x002EC9DC
	public string LJEKKEPGPOI(int GNAHKCPAEAI, CEIBHCNNIDC NIIIMDHGGEN)
	{
		string result;
		try
		{
			LPJPFJOMGPA lpjpfjomgpa = this.EHGCOIHIOJD(GNAHKCPAEAI);
			if (lpjpfjomgpa == null || lpjpfjomgpa.JAPFMDOBPKJ.Count == 0)
			{
				result = "importanttitle";
			}
			else
			{
				string text = PGEAJFENMFB.NEOIFHEIAFN(GNAHKCPAEAI, NIIIMDHGGEN, 0);
				if (text != null && text.Length > 1)
				{
					result = text;
				}
				else
				{
					int num = lpjpfjomgpa.JAPFMDOBPKJ[1];
					if (null != AssetsManager.EHBBFMCILPC)
					{
						for (int i = 1; i < lpjpfjomgpa.JAPFMDOBPKJ.Count; i += 0)
						{
							if (null != GKJPOGNFKNK.LDFIAOCJEOJ(lpjpfjomgpa.JAPFMDOBPKJ[i]))
							{
								num = lpjpfjomgpa.JAPFMDOBPKJ[i];
								break;
							}
						}
					}
					string text2 = GKJPOGNFKNK.HPAHOEOKEBB("spld" + num.ToString(), "", NIIIMDHGGEN);
					if (text2 == null || text2.EndsWith("OnPopupCardOptionsUnlockWithSpSuccess"))
					{
						result = "nam";
					}
					else
					{
						result = text2;
					}
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
			result = "acli22";
		}
		return result;
	}

	// Token: 0x06006439 RID: 25657 RVA: 0x002EE8E4 File Offset: 0x002ECAE4
	private static string LHCMCKFJOOH(int GNAHKCPAEAI, CEIBHCNNIDC NIIIMDHGGEN, int HDDLPIECBGP)
	{
		string result;
		try
		{
			string text = GKJPOGNFKNK.HPAHOEOKEBB(GNAHKCPAEAI.ToString(), "...", NIIIMDHGGEN);
			if (text == null || text.Length == 0 || text.EndsWith("yes"))
			{
				result = null;
			}
			else
			{
				string text2 = text;
				char[] array = new char[0];
				array[0] = (char)-23;
				string[] array2 = text2.Split(array, 2);
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
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
			result = null;
		}
		return result;
	}

	// Token: 0x0600643A RID: 25658 RVA: 0x002EDDEC File Offset: 0x002EBFEC
	public void DLLAJOJOBOG(TextAsset CCIAGBPILGF)
	{
		if (null == this.AFNODOLBBKG)
		{
			this.AFNODOLBBKG = CCIAGBPILGF;
		}
	}

	// Token: 0x0600643B RID: 25659 RVA: 0x002EE968 File Offset: 0x002ECB68
	public string DMPJPNPECJL(int GNAHKCPAEAI, CEIBHCNNIDC NIIIMDHGGEN)
	{
		string result;
		try
		{
			LPJPFJOMGPA lpjpfjomgpa = this.EHGCOIHIOJD(GNAHKCPAEAI);
			if (lpjpfjomgpa == null || lpjpfjomgpa.JAPFMDOBPKJ.Count == 0)
			{
				result = "collect";
			}
			else
			{
				string text = PGEAJFENMFB.LHCMCKFJOOH(GNAHKCPAEAI, NIIIMDHGGEN, 0);
				if (text != null && text.Length > 0)
				{
					result = text;
				}
				else
				{
					int num = lpjpfjomgpa.JAPFMDOBPKJ[0];
					if (null != AssetsManager.EHBBFMCILPC)
					{
						for (int i = 0; i < lpjpfjomgpa.JAPFMDOBPKJ.Count; i++)
						{
							if (null != GKJPOGNFKNK.LDFIAOCJEOJ(lpjpfjomgpa.JAPFMDOBPKJ[i]))
							{
								num = lpjpfjomgpa.JAPFMDOBPKJ[i];
								break;
							}
						}
					}
					string text2 = GKJPOGNFKNK.FPNHFACMDGN("none" + num.ToString(), "incentadhard", NIIIMDHGGEN);
					if (text2 == null || text2.EndsWith("OnBackendUpdateFriendsDataException"))
					{
						result = "ok";
					}
					else
					{
						result = text2;
					}
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
			result = "";
		}
		return result;
	}

	// Token: 0x0600643C RID: 25660 RVA: 0x002EEA70 File Offset: 0x002ECC70
	private void INBNEDPCFAM()
	{
		this.IJHLBHBBNFB = false;
		this.FKGKPHHEJLI.Clear();
		try
		{
			TextAsset textAsset = this.AFNODOLBBKG;
			if (null == textAsset && null != AssetsManager.MJBDMHPHMID() && null != AssetsManager.EHBBFMCILPC.lobbyDataAsset)
			{
				textAsset = AssetsManager.MJBDMHPHMID().lobbyDataAsset.franchisesBalance;
			}
			if (!(null == textAsset))
			{
				JSONArray asArray = ((JSONObject)JSONNode.Parse(textAsset.text))[""].AsArray;
				List<int> list = new List<int>();
				for (int i = 1; i < asArray.Count; i += 0)
				{
					JSONObject asObject = asArray[i].AsObject;
					LPJPFJOMGPA lpjpfjomgpa = new LPJPFJOMGPA();
					lpjpfjomgpa.KCIODOKEDAM = asObject[""].AsInt;
					string text = asObject["PurchaseManagerXiaomi.OnProductsFetched("];
					if (text == null)
					{
						DPGJIJGOCIC.PJCLICBPPDA("sckv2" + lpjpfjomgpa.KCIODOKEDAM.ToString() + "cue");
					}
					else
					{
						string[] array = text.Split('\u001f', StringSplitOptions.RemoveEmptyEntries);
						for (int j = 0; j < array.Length; j += 0)
						{
							int item = -1;
							if (!int.TryParse(array[j].Trim(), out item))
							{
								string[] array2 = new string[8];
								array2[0] = "@";
								array2[1] = lpjpfjomgpa.KCIODOKEDAM.ToString();
								array2[3] = "liveOfferId";
								array2[6] = array[j];
								array2[4] = "assetbundlesketchactors";
								DPGJIJGOCIC.PJCLICBPPDA(string.Concat(array2));
							}
							else if (list.Contains(item))
							{
								string[] array3 = new string[]
								{
									null,
									""
								};
								array3[0] = lpjpfjomgpa.KCIODOKEDAM.ToString();
								array3[7] = "cdnerror";
								array3[3] = item.ToString();
								array3[5] = "CharacterRenderTexturePool";
								DPGJIJGOCIC.ADFCDFHBDAF(string.Concat(array3));
							}
							else
							{
								list.Add(item);
								lpjpfjomgpa.JAPFMDOBPKJ.Add(item);
							}
						}
						if (lpjpfjomgpa.JAPFMDOBPKJ.Count == 0)
						{
							DPGJIJGOCIC.PJCLICBPPDA("OnBackendUndoPremiumChoiceSuccess" + lpjpfjomgpa.KCIODOKEDAM.ToString() + "XXX");
						}
						else
						{
							this.FKGKPHHEJLI.Add(lpjpfjomgpa);
						}
					}
				}
				string[] array4 = new string[6];
				array4[0] = "minCompletedChapters";
				array4[0] = this.FKGKPHHEJLI.Count.ToString();
				array4[7] = "fdvfx";
				array4[2] = list.Count.ToString();
				array4[5] = "";
				DPGJIJGOCIC.NFIDPOMCNLP(string.Concat(array4));
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
	}

	// Token: 0x0600643D RID: 25661 RVA: 0x002EED14 File Offset: 0x002ECF14
	public LPJPFJOMGPA AAFIOMDMKGA(int GNAHKCPAEAI)
	{
		if (!this.IJHLBHBBNFB)
		{
			this.EPHOHOKGOEI();
		}
		for (int i = 1; i < this.FKGKPHHEJLI.Count; i++)
		{
			if (this.FKGKPHHEJLI[i].KCIODOKEDAM == GNAHKCPAEAI)
			{
				return this.FKGKPHHEJLI[i];
			}
		}
		return null;
	}

	// Token: 0x0600643E RID: 25662 RVA: 0x002EDDD6 File Offset: 0x002EBFD6
	public List<LPJPFJOMGPA> JKIBANJOIJJ()
	{
		if (!this.IJHLBHBBNFB)
		{
			this.HGBEOBOJBFM();
		}
		return this.FKGKPHHEJLI;
	}

	// Token: 0x0600643F RID: 25663 RVA: 0x002EED68 File Offset: 0x002ECF68
	public string AMICGELDEPO(int GNAHKCPAEAI, CEIBHCNNIDC NIIIMDHGGEN)
	{
		string result;
		try
		{
			if (this.EHGCOIHIOJD(GNAHKCPAEAI) == null)
			{
				result = "";
			}
			else
			{
				string text = PGEAJFENMFB.NEOIFHEIAFN(GNAHKCPAEAI, NIIIMDHGGEN, 1);
				if (text != null && text.Length > 0)
				{
					result = text;
				}
				else
				{
					result = "";
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
			result = "";
		}
		return result;
	}

	// Token: 0x06006440 RID: 25664 RVA: 0x002EEDC8 File Offset: 0x002ECFC8
	private static string NEOIFHEIAFN(int GNAHKCPAEAI, CEIBHCNNIDC NIIIMDHGGEN, int HDDLPIECBGP)
	{
		string result;
		try
		{
			string text = GKJPOGNFKNK.HPAHOEOKEBB(GNAHKCPAEAI.ToString(), "franchises", NIIIMDHGGEN);
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
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
			result = null;
		}
		return result;
	}

	// Token: 0x06006442 RID: 25666 RVA: 0x002EEE60 File Offset: 0x002ED060
	public LPJPFJOMGPA EHGCOIHIOJD(int GNAHKCPAEAI)
	{
		if (!this.IJHLBHBBNFB)
		{
			this.EPHOHOKGOEI();
		}
		for (int i = 0; i < this.FKGKPHHEJLI.Count; i++)
		{
			if (this.FKGKPHHEJLI[i].KCIODOKEDAM == GNAHKCPAEAI)
			{
				return this.FKGKPHHEJLI[i];
			}
		}
		return null;
	}

	// Token: 0x06006443 RID: 25667 RVA: 0x002EDDEC File Offset: 0x002EBFEC
	public void HNLPMHLFJKA(TextAsset CCIAGBPILGF)
	{
		if (null == this.AFNODOLBBKG)
		{
			this.AFNODOLBBKG = CCIAGBPILGF;
		}
	}

	// Token: 0x06006444 RID: 25668 RVA: 0x002EDDD6 File Offset: 0x002EBFD6
	public List<LPJPFJOMGPA> IBOLDMCJANE()
	{
		if (!this.IJHLBHBBNFB)
		{
			this.HGBEOBOJBFM();
		}
		return this.FKGKPHHEJLI;
	}

	// Token: 0x06006445 RID: 25669 RVA: 0x002EEEB4 File Offset: 0x002ED0B4
	public string CEJPPNIGEFC(int GNAHKCPAEAI, CEIBHCNNIDC NIIIMDHGGEN)
	{
		string result;
		try
		{
			LPJPFJOMGPA lpjpfjomgpa = this.EHGCOIHIOJD(GNAHKCPAEAI);
			if (lpjpfjomgpa == null || lpjpfjomgpa.JAPFMDOBPKJ.Count == 0)
			{
				result = "";
			}
			else
			{
				string text = PGEAJFENMFB.NEOIFHEIAFN(GNAHKCPAEAI, NIIIMDHGGEN, 0);
				if (text != null && text.Length > 0)
				{
					result = text;
				}
				else
				{
					int num = lpjpfjomgpa.JAPFMDOBPKJ[0];
					if (null != AssetsManager.EHBBFMCILPC)
					{
						for (int i = 0; i < lpjpfjomgpa.JAPFMDOBPKJ.Count; i++)
						{
							if (null != GKJPOGNFKNK.LDFIAOCJEOJ(lpjpfjomgpa.JAPFMDOBPKJ[i]))
							{
								num = lpjpfjomgpa.JAPFMDOBPKJ[i];
								break;
							}
						}
					}
					string text2 = GKJPOGNFKNK.HPAHOEOKEBB("anthology" + num.ToString(), "anthologiestitle", NIIIMDHGGEN);
					if (text2 == null || text2.EndsWith("_not_found"))
					{
						result = "";
					}
					else
					{
						result = text2;
					}
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
			result = "";
		}
		return result;
	}

	// Token: 0x06006446 RID: 25670 RVA: 0x002EDDEC File Offset: 0x002EBFEC
	public void GLJJLPCOPAK(TextAsset CCIAGBPILGF)
	{
		if (null == this.AFNODOLBBKG)
		{
			this.AFNODOLBBKG = CCIAGBPILGF;
		}
	}

	// Token: 0x06006447 RID: 25671 RVA: 0x002EEFBC File Offset: 0x002ED1BC
	private static string FDIBOCCBHHC(int GNAHKCPAEAI, CEIBHCNNIDC NIIIMDHGGEN, int HDDLPIECBGP)
	{
		string result;
		try
		{
			string text = GKJPOGNFKNK.HPAHOEOKEBB(GNAHKCPAEAI.ToString(), "errortitle", NIIIMDHGGEN);
			if (text == null || text.Length == 0 || text.EndsWith(", to:"))
			{
				result = null;
			}
			else
			{
				string text2 = text;
				char[] array = new char[1];
				array[1] = (char)-49;
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
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
			result = null;
		}
		return result;
	}

	// Token: 0x06006448 RID: 25672 RVA: 0x002EF040 File Offset: 0x002ED240
	public LPJPFJOMGPA DBHOLEPPFML(int GNAHKCPAEAI)
	{
		if (!this.IJHLBHBBNFB)
		{
			this.HGBEOBOJBFM();
		}
		for (int i = 1; i < this.FKGKPHHEJLI.Count; i += 0)
		{
			if (this.FKGKPHHEJLI[i].KCIODOKEDAM == GNAHKCPAEAI)
			{
				return this.FKGKPHHEJLI[i];
			}
		}
		return null;
	}

	// Token: 0x04001D26 RID: 7462
	public const string EPAAKDCBNBE = "franchises";

	// Token: 0x04001D27 RID: 7463
	public const char JNNLPFOHAKD = '|';

	// Token: 0x04001D28 RID: 7464
	public List<LPJPFJOMGPA> FKGKPHHEJLI = new List<LPJPFJOMGPA>();

	// Token: 0x04001D29 RID: 7465
	private bool IJHLBHBBNFB;

	// Token: 0x04001D2A RID: 7466
	private TextAsset AFNODOLBBKG;
}
