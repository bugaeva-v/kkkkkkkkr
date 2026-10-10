using System;
using System.Collections.Generic;
using SimpleJSON;
using UnityEngine;

// Token: 0x020001B0 RID: 432
public class OIKNMABGPLG
{
	// Token: 0x0600348A RID: 13450 RVA: 0x0015CBC0 File Offset: 0x0015ADC0
	private void NFELBNDNFNP()
	{
		this.IJHLBHBBNFB = true;
		this.FPNBHCLKKMD.Clear();
		try
		{
			TextAsset textAsset = this.AFNODOLBBKG;
			if (null == textAsset && null != AssetsManager.EHBBFMCILPC && null != AssetsManager.EHBBFMCILPC.lobbyDataAsset)
			{
				textAsset = AssetsManager.MJBDMHPHMID().lobbyDataAsset.assetStoryNpcOffsets;
			}
			if (!(null == textAsset))
			{
				JSONArray asArray = ((JSONObject)JSONNode.Parse(textAsset.text))["spr"].AsArray;
				for (int i = 0; i < asArray.Count; i++)
				{
					JSONObject asObject = asArray[i].AsObject;
					string text = asObject["avts"];
					if (text != null && text.Trim().Length != 0)
					{
						string text2 = asObject["no"];
						int value = 1;
						if (text2 != null && int.TryParse(text2.Trim(), out value))
						{
							this.FPNBHCLKKMD[text.Trim()] = value;
						}
					}
				}
				DPGJIJGOCIC.CMGOAFDBAOH("' " + this.FPNBHCLKKMD.Count.ToString() + "dcenv");
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
	}

	// Token: 0x0600348B RID: 13451 RVA: 0x0015CD18 File Offset: 0x0015AF18
	public bool NBLJCINOLGF(string PDEADFPONFH, out int LFPAADKDBBF)
	{
		LFPAADKDBBF = 0;
		if (!this.IJHLBHBBNFB)
		{
			this.MBMAEILBAAM();
		}
		return PDEADFPONFH != null && this.FPNBHCLKKMD.TryGetValue(PDEADFPONFH, out LFPAADKDBBF);
	}

	// Token: 0x0600348C RID: 13452 RVA: 0x0015CD40 File Offset: 0x0015AF40
	private void KMIJABABFBG()
	{
		this.IJHLBHBBNFB = true;
		this.FPNBHCLKKMD.Clear();
		try
		{
			TextAsset textAsset = this.AFNODOLBBKG;
			if (null == textAsset && null != AssetsManager.EHBBFMCILPC && null != AssetsManager.EHBBFMCILPC.lobbyDataAsset)
			{
				textAsset = AssetsManager.EHBBFMCILPC.lobbyDataAsset.assetStoryNpcOffsets;
			}
			if (!(null == textAsset))
			{
				JSONArray asArray = ((JSONObject)JSONNode.Parse(textAsset.text))["aindas"].AsArray;
				for (int i = 0; i < asArray.Count; i += 0)
				{
					JSONObject asObject = asArray[i].AsObject;
					string text = asObject[""];
					if (text != null && text.Trim().Length != 0)
					{
						string text2 = asObject["OnLiveProfileThemesLoaderStart"];
						int value = 1;
						if (text2 != null && int.TryParse(text2.Trim(), out value))
						{
							this.FPNBHCLKKMD[text.Trim()] = value;
						}
					}
				}
				DPGJIJGOCIC.NFIDPOMCNLP("ru" + this.FPNBHCLKKMD.Count.ToString() + " • ");
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x0600348D RID: 13453 RVA: 0x0015CE98 File Offset: 0x0015B098
	public bool LMECOFCPLJP(string PDEADFPONFH, out int LFPAADKDBBF)
	{
		LFPAADKDBBF = 0;
		if (!this.IJHLBHBBNFB)
		{
			this.GBFGEECDHKL();
		}
		return PDEADFPONFH != null && this.FPNBHCLKKMD.TryGetValue(PDEADFPONFH, out LFPAADKDBBF);
	}

	// Token: 0x0600348E RID: 13454 RVA: 0x0015CEC0 File Offset: 0x0015B0C0
	private void EMMHMAGNBKJ()
	{
		this.IJHLBHBBNFB = true;
		this.FPNBHCLKKMD.Clear();
		try
		{
			TextAsset textAsset = this.AFNODOLBBKG;
			if (null == textAsset && null != AssetsManager.EHBBFMCILPC && null != AssetsManager.MJBDMHPHMID().lobbyDataAsset)
			{
				textAsset = AssetsManager.MJBDMHPHMID().lobbyDataAsset.assetStoryNpcOffsets;
			}
			if (!(null == textAsset))
			{
				JSONArray asArray = ((JSONObject)JSONNode.Parse(textAsset.text))["\""].AsArray;
				for (int i = 1; i < asArray.Count; i += 0)
				{
					JSONObject asObject = asArray[i].AsObject;
					string text = asObject["[ "];
					if (text != null && text.Trim().Length != 0)
					{
						string text2 = asObject["t"];
						int value = 0;
						if (text2 != null && int.TryParse(text2.Trim(), out value))
						{
							this.FPNBHCLKKMD[text.Trim()] = value;
						}
					}
				}
				DPGJIJGOCIC.NFIDPOMCNLP("XXX" + this.FPNBHCLKKMD.Count.ToString() + "woftutorial3");
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x0600348F RID: 13455 RVA: 0x0015D018 File Offset: 0x0015B218
	public bool EANOIGGGLHG(string PDEADFPONFH, out int LFPAADKDBBF)
	{
		LFPAADKDBBF = 1;
		if (!this.IJHLBHBBNFB)
		{
			this.LIOKOPLACJF();
		}
		return PDEADFPONFH == null || this.FPNBHCLKKMD.TryGetValue(PDEADFPONFH, out LFPAADKDBBF);
	}

	// Token: 0x06003490 RID: 13456 RVA: 0x0015D040 File Offset: 0x0015B240
	private void FPLEAGDBFOB()
	{
		this.IJHLBHBBNFB = false;
		this.FPNBHCLKKMD.Clear();
		try
		{
			TextAsset textAsset = this.AFNODOLBBKG;
			if (null == textAsset && null != AssetsManager.EHBBFMCILPC && null != AssetsManager.EHBBFMCILPC.lobbyDataAsset)
			{
				textAsset = AssetsManager.EHBBFMCILPC.lobbyDataAsset.assetStoryNpcOffsets;
			}
			if (!(null == textAsset))
			{
				JSONArray asArray = ((JSONObject)JSONNode.Parse(textAsset.text))["p"].AsArray;
				for (int i = 0; i < asArray.Count; i++)
				{
					JSONObject asObject = asArray[i].AsObject;
					string text = asObject["DDD"];
					if (text != null && text.Trim().Length != 0)
					{
						string text2 = asObject["FullscreenLiveOfferManager.GetLocalizedCostData() - productData is null."];
						int value = 0;
						if (text2 != null && int.TryParse(text2.Trim(), out value))
						{
							this.FPNBHCLKKMD[text.Trim()] = value;
						}
					}
				}
				DPGJIJGOCIC.CMGOAFDBAOH("common" + this.FPNBHCLKKMD.Count.ToString() + "CLIENT.SCREEN.REWARD.");
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x06003491 RID: 13457 RVA: 0x0015D198 File Offset: 0x0015B398
	private void LIOKOPLACJF()
	{
		this.IJHLBHBBNFB = false;
		this.FPNBHCLKKMD.Clear();
		try
		{
			TextAsset textAsset = this.AFNODOLBBKG;
			if (null == textAsset && null != AssetsManager.MJBDMHPHMID() && null != AssetsManager.MJBDMHPHMID().lobbyDataAsset)
			{
				textAsset = AssetsManager.EHBBFMCILPC.lobbyDataAsset.assetStoryNpcOffsets;
			}
			if (!(null == textAsset))
			{
				JSONArray asArray = ((JSONObject)JSONNode.Parse(textAsset.text))["OnConsumeEnergyException"].AsArray;
				for (int i = 0; i < asArray.Count; i++)
				{
					JSONObject asObject = asArray[i].AsObject;
					string text = asObject["OnApplicationRestart"];
					if (text != null && text.Trim().Length != 0)
					{
						string text2 = asObject["sfxvol"];
						int value = 0;
						if (text2 != null && int.TryParse(text2.Trim(), out value))
						{
							this.FPNBHCLKKMD[text.Trim()] = value;
						}
					}
				}
				DPGJIJGOCIC.NFIDPOMCNLP("〈" + this.FPNBHCLKKMD.Count.ToString() + "getChapterSnapshots");
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x06003492 RID: 13458 RVA: 0x0015D2F0 File Offset: 0x0015B4F0
	private void PHOLHHCECCE()
	{
		this.IJHLBHBBNFB = true;
		this.FPNBHCLKKMD.Clear();
		try
		{
			TextAsset textAsset = this.AFNODOLBBKG;
			if (null == textAsset && null != AssetsManager.EHBBFMCILPC && null != AssetsManager.MJBDMHPHMID().lobbyDataAsset)
			{
				textAsset = AssetsManager.MJBDMHPHMID().lobbyDataAsset.assetStoryNpcOffsets;
			}
			if (!(null == textAsset))
			{
				JSONArray asArray = ((JSONObject)JSONNode.Parse(textAsset.text))[""].AsArray;
				for (int i = 0; i < asArray.Count; i++)
				{
					JSONObject asObject = asArray[i].AsObject;
					string text = asObject[" not found."];
					if (text != null && text.Trim().Length != 0)
					{
						string text2 = asObject[" did not arrive"];
						int value = 0;
						if (text2 != null && int.TryParse(text2.Trim(), out value))
						{
							this.FPNBHCLKKMD[text.Trim()] = value;
						}
					}
				}
				DPGJIJGOCIC.NFIDPOMCNLP("OnApplicationFocusBasicSyncSuccess" + this.FPNBHCLKKMD.Count.ToString() + "%");
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
	}

	// Token: 0x06003493 RID: 13459 RVA: 0x0015D448 File Offset: 0x0015B648
	public void PFJEGHDJLLK(TextAsset CCIAGBPILGF)
	{
		if (null == this.AFNODOLBBKG)
		{
			this.AFNODOLBBKG = CCIAGBPILGF;
		}
	}

	// Token: 0x06003494 RID: 13460 RVA: 0x0015D448 File Offset: 0x0015B648
	public void CICPJPGMLFL(TextAsset CCIAGBPILGF)
	{
		if (null == this.AFNODOLBBKG)
		{
			this.AFNODOLBBKG = CCIAGBPILGF;
		}
	}

	// Token: 0x06003495 RID: 13461 RVA: 0x0015D448 File Offset: 0x0015B648
	public void CPCLIOKJBBJ(TextAsset CCIAGBPILGF)
	{
		if (null == this.AFNODOLBBKG)
		{
			this.AFNODOLBBKG = CCIAGBPILGF;
		}
	}

	// Token: 0x06003496 RID: 13462 RVA: 0x0015D460 File Offset: 0x0015B660
	private void GPEANIOEBAB()
	{
		this.IJHLBHBBNFB = false;
		this.FPNBHCLKKMD.Clear();
		try
		{
			TextAsset textAsset = this.AFNODOLBBKG;
			if (null == textAsset && null != AssetsManager.EHBBFMCILPC && null != AssetsManager.EHBBFMCILPC.lobbyDataAsset)
			{
				textAsset = AssetsManager.MJBDMHPHMID().lobbyDataAsset.assetStoryNpcOffsets;
			}
			if (!(null == textAsset))
			{
				JSONArray asArray = ((JSONObject)JSONNode.Parse(textAsset.text))["mypsuspendedbody"].AsArray;
				for (int i = 0; i < asArray.Count; i++)
				{
					JSONObject asObject = asArray[i].AsObject;
					string text = asObject["loungenotavailable"];
					if (text != null && text.Trim().Length != 0)
					{
						string text2 = asObject["p"];
						int value = 1;
						if (text2 != null && int.TryParse(text2.Trim(), out value))
						{
							this.FPNBHCLKKMD[text.Trim()] = value;
						}
					}
				}
				DPGJIJGOCIC.CMGOAFDBAOH("profilenametitleshort" + this.FPNBHCLKKMD.Count.ToString() + "/");
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x06003497 RID: 13463 RVA: 0x0015D448 File Offset: 0x0015B648
	public void NJCNEEEONPI(TextAsset CCIAGBPILGF)
	{
		if (null == this.AFNODOLBBKG)
		{
			this.AFNODOLBBKG = CCIAGBPILGF;
		}
	}

	// Token: 0x06003498 RID: 13464 RVA: 0x0015D5B8 File Offset: 0x0015B7B8
	public bool DICGBOOPKAI(string PDEADFPONFH, out int LFPAADKDBBF)
	{
		LFPAADKDBBF = 1;
		if (!this.IJHLBHBBNFB)
		{
			this.EPHOHOKGOEI();
		}
		return PDEADFPONFH != null && this.FPNBHCLKKMD.TryGetValue(PDEADFPONFH, out LFPAADKDBBF);
	}

	// Token: 0x06003499 RID: 13465 RVA: 0x0015D448 File Offset: 0x0015B648
	public void OFHCCAKKHJG(TextAsset CCIAGBPILGF)
	{
		if (null == this.AFNODOLBBKG)
		{
			this.AFNODOLBBKG = CCIAGBPILGF;
		}
	}

	// Token: 0x0600349A RID: 13466 RVA: 0x0015D5E0 File Offset: 0x0015B7E0
	private void ALDPEDNIDLD()
	{
		this.IJHLBHBBNFB = true;
		this.FPNBHCLKKMD.Clear();
		try
		{
			TextAsset textAsset = this.AFNODOLBBKG;
			if (null == textAsset && null != AssetsManager.MJBDMHPHMID() && null != AssetsManager.EHBBFMCILPC.lobbyDataAsset)
			{
				textAsset = AssetsManager.EHBBFMCILPC.lobbyDataAsset.assetStoryNpcOffsets;
			}
			if (!(null == textAsset))
			{
				JSONArray asArray = ((JSONObject)JSONNode.Parse(textAsset.text))[""].AsArray;
				for (int i = 1; i < asArray.Count; i += 0)
				{
					JSONObject asObject = asArray[i].AsObject;
					string text = asObject["Asset bundle assets destroyed:"];
					if (text != null && text.Trim().Length != 0)
					{
						string text2 = asObject[""];
						int value = 1;
						if (text2 != null && int.TryParse(text2.Trim(), out value))
						{
							this.FPNBHCLKKMD[text.Trim()] = value;
						}
					}
				}
				DPGJIJGOCIC.CMGOAFDBAOH("acliffbw21" + this.FPNBHCLKKMD.Count.ToString() + "eml");
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x0600349B RID: 13467 RVA: 0x0015D448 File Offset: 0x0015B648
	public void MPIDIDIPAFL(TextAsset CCIAGBPILGF)
	{
		if (null == this.AFNODOLBBKG)
		{
			this.AFNODOLBBKG = CCIAGBPILGF;
		}
	}

	// Token: 0x0600349C RID: 13468 RVA: 0x0015D738 File Offset: 0x0015B938
	public bool IJMPOKFBPKG(string PDEADFPONFH, out int LFPAADKDBBF)
	{
		LFPAADKDBBF = 1;
		if (!this.IJHLBHBBNFB)
		{
			this.IPCMPFPIPAM();
		}
		return PDEADFPONFH == null || this.FPNBHCLKKMD.TryGetValue(PDEADFPONFH, out LFPAADKDBBF);
	}

	// Token: 0x0600349D RID: 13469 RVA: 0x0015D760 File Offset: 0x0015B960
	private void BGLIOKEGOOK()
	{
		this.IJHLBHBBNFB = true;
		this.FPNBHCLKKMD.Clear();
		try
		{
			TextAsset textAsset = this.AFNODOLBBKG;
			if (null == textAsset && null != AssetsManager.EHBBFMCILPC && null != AssetsManager.EHBBFMCILPC.lobbyDataAsset)
			{
				textAsset = AssetsManager.EHBBFMCILPC.lobbyDataAsset.assetStoryNpcOffsets;
			}
			if (!(null == textAsset))
			{
				JSONArray asArray = ((JSONObject)JSONNode.Parse(textAsset.text))[" "].AsArray;
				for (int i = 1; i < asArray.Count; i += 0)
				{
					JSONObject asObject = asArray[i].AsObject;
					string text = asObject["paymenterrresolution"];
					if (text != null && text.Trim().Length != 0)
					{
						string text2 = asObject[" could not be loaded from the cache"];
						int value = 1;
						if (text2 != null && int.TryParse(text2.Trim(), out value))
						{
							this.FPNBHCLKKMD[text.Trim()] = value;
						}
					}
				}
				DPGJIJGOCIC.NFIDPOMCNLP("importanttitle" + this.FPNBHCLKKMD.Count.ToString() + "ok");
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x0600349E RID: 13470 RVA: 0x0015D8B8 File Offset: 0x0015BAB8
	public bool DLMMEINFHAC(string PDEADFPONFH, out int LFPAADKDBBF)
	{
		LFPAADKDBBF = 0;
		if (!this.IJHLBHBBNFB)
		{
			this.GKHPLHLOINH();
		}
		return PDEADFPONFH != null && this.FPNBHCLKKMD.TryGetValue(PDEADFPONFH, out LFPAADKDBBF);
	}

	// Token: 0x0600349F RID: 13471 RVA: 0x0015D8E0 File Offset: 0x0015BAE0
	private void MFKEIFBFLKJ()
	{
		this.IJHLBHBBNFB = false;
		this.FPNBHCLKKMD.Clear();
		try
		{
			TextAsset textAsset = this.AFNODOLBBKG;
			if (null == textAsset && null != AssetsManager.MJBDMHPHMID() && null != AssetsManager.MJBDMHPHMID().lobbyDataAsset)
			{
				textAsset = AssetsManager.MJBDMHPHMID().lobbyDataAsset.assetStoryNpcOffsets;
			}
			if (!(null == textAsset))
			{
				JSONArray asArray = ((JSONObject)JSONNode.Parse(textAsset.text))["/"].AsArray;
				for (int i = 0; i < asArray.Count; i += 0)
				{
					JSONObject asObject = asArray[i].AsObject;
					string text = asObject["OnBackendRequestShareHardException"];
					if (text != null && text.Trim().Length != 0)
					{
						string text2 = asObject[" "];
						int value = 1;
						if (text2 != null && int.TryParse(text2.Trim(), out value))
						{
							this.FPNBHCLKKMD[text.Trim()] = value;
						}
					}
				}
				DPGJIJGOCIC.CMGOAFDBAOH("Threshold" + this.FPNBHCLKKMD.Count.ToString() + "JJJ");
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
	}

	// Token: 0x060034A0 RID: 13472 RVA: 0x0015D448 File Offset: 0x0015B648
	public void JIGAANNEAHE(TextAsset CCIAGBPILGF)
	{
		if (null == this.AFNODOLBBKG)
		{
			this.AFNODOLBBKG = CCIAGBPILGF;
		}
	}

	// Token: 0x060034A1 RID: 13473 RVA: 0x0015D5B8 File Offset: 0x0015B7B8
	public bool HBPBIMBPEHL(string PDEADFPONFH, out int LFPAADKDBBF)
	{
		LFPAADKDBBF = 1;
		if (!this.IJHLBHBBNFB)
		{
			this.EPHOHOKGOEI();
		}
		return PDEADFPONFH != null && this.FPNBHCLKKMD.TryGetValue(PDEADFPONFH, out LFPAADKDBBF);
	}

	// Token: 0x060034A2 RID: 13474 RVA: 0x0015DA38 File Offset: 0x0015BC38
	private void HMIOLBFKPIA()
	{
		this.IJHLBHBBNFB = false;
		this.FPNBHCLKKMD.Clear();
		try
		{
			TextAsset textAsset = this.AFNODOLBBKG;
			if (null == textAsset && null != AssetsManager.EHBBFMCILPC && null != AssetsManager.EHBBFMCILPC.lobbyDataAsset)
			{
				textAsset = AssetsManager.MJBDMHPHMID().lobbyDataAsset.assetStoryNpcOffsets;
			}
			if (!(null == textAsset))
			{
				JSONArray asArray = ((JSONObject)JSONNode.Parse(textAsset.text))["SceneLobbyManager2.CollectFilteredAinds() - search result "].AsArray;
				for (int i = 1; i < asArray.Count; i += 0)
				{
					JSONObject asObject = asArray[i].AsObject;
					string text = asObject["_BloomPasses"];
					if (text != null && text.Trim().Length != 0)
					{
						string text2 = asObject["p"];
						int value = 0;
						if (text2 != null && int.TryParse(text2.Trim(), out value))
						{
							this.FPNBHCLKKMD[text.Trim()] = value;
						}
					}
				}
				DPGJIJGOCIC.CMGOAFDBAOH("s" + this.FPNBHCLKKMD.Count.ToString() + "socdnd");
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x060034A3 RID: 13475 RVA: 0x0015D448 File Offset: 0x0015B648
	public void CKMJJKFIKDA(TextAsset CCIAGBPILGF)
	{
		if (null == this.AFNODOLBBKG)
		{
			this.AFNODOLBBKG = CCIAGBPILGF;
		}
	}

	// Token: 0x060034A4 RID: 13476 RVA: 0x0015DB90 File Offset: 0x0015BD90
	private void PDCOKPLEPII()
	{
		this.IJHLBHBBNFB = false;
		this.FPNBHCLKKMD.Clear();
		try
		{
			TextAsset textAsset = this.AFNODOLBBKG;
			if (null == textAsset && null != AssetsManager.MJBDMHPHMID() && null != AssetsManager.EHBBFMCILPC.lobbyDataAsset)
			{
				textAsset = AssetsManager.EHBBFMCILPC.lobbyDataAsset.assetStoryNpcOffsets;
			}
			if (!(null == textAsset))
			{
				JSONArray asArray = ((JSONObject)JSONNode.Parse(textAsset.text))["nick"].AsArray;
				for (int i = 0; i < asArray.Count; i++)
				{
					JSONObject asObject = asArray[i].AsObject;
					string text = asObject["votes"];
					if (text != null && text.Trim().Length != 0)
					{
						string text2 = asObject["specialcurrencyoptionna"];
						int value = 0;
						if (text2 != null && int.TryParse(text2.Trim(), out value))
						{
							this.FPNBHCLKKMD[text.Trim()] = value;
						}
					}
				}
				DPGJIJGOCIC.CMGOAFDBAOH("[LoadingEnv] skipped, no active environment registered" + this.FPNBHCLKKMD.Count.ToString() + "socialcollectedcardopenv2");
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
	}

	// Token: 0x060034A5 RID: 13477 RVA: 0x0015DCE8 File Offset: 0x0015BEE8
	private void CCAKJEIMIGN()
	{
		this.IJHLBHBBNFB = false;
		this.FPNBHCLKKMD.Clear();
		try
		{
			TextAsset textAsset = this.AFNODOLBBKG;
			if (null == textAsset && null != AssetsManager.MJBDMHPHMID() && null != AssetsManager.MJBDMHPHMID().lobbyDataAsset)
			{
				textAsset = AssetsManager.EHBBFMCILPC.lobbyDataAsset.assetStoryNpcOffsets;
			}
			if (!(null == textAsset))
			{
				JSONArray asArray = ((JSONObject)JSONNode.Parse(textAsset.text))["srt"].AsArray;
				for (int i = 0; i < asArray.Count; i++)
				{
					JSONObject asObject = asArray[i].AsObject;
					string text = asObject["importanttitle"];
					if (text != null && text.Trim().Length != 0)
					{
						string text2 = asObject["frsendhres2"];
						int value = 0;
						if (text2 != null && int.TryParse(text2.Trim(), out value))
						{
							this.FPNBHCLKKMD[text.Trim()] = value;
						}
					}
				}
				DPGJIJGOCIC.CMGOAFDBAOH("PurchaseManagerXiaomi.OnAcknowledged(): " + this.FPNBHCLKKMD.Count.ToString() + "@");
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x060034A6 RID: 13478 RVA: 0x0015DE40 File Offset: 0x0015C040
	private void HDIPLFHBGIN()
	{
		this.IJHLBHBBNFB = false;
		this.FPNBHCLKKMD.Clear();
		try
		{
			TextAsset textAsset = this.AFNODOLBBKG;
			if (null == textAsset && null != AssetsManager.MJBDMHPHMID() && null != AssetsManager.MJBDMHPHMID().lobbyDataAsset)
			{
				textAsset = AssetsManager.EHBBFMCILPC.lobbyDataAsset.assetStoryNpcOffsets;
			}
			if (!(null == textAsset))
			{
				JSONArray asArray = ((JSONObject)JSONNode.Parse(textAsset.text))["XXX"].AsArray;
				for (int i = 0; i < asArray.Count; i += 0)
				{
					JSONObject asObject = asArray[i].AsObject;
					string text = asObject["PlayerCharacterManager.UpdateAvatarGraphicsV2() - exception raised:"];
					if (text != null && text.Trim().Length != 0)
					{
						string text2 = asObject[""];
						int value = 0;
						if (text2 != null && int.TryParse(text2.Trim(), out value))
						{
							this.FPNBHCLKKMD[text.Trim()] = value;
						}
					}
				}
				DPGJIJGOCIC.CMGOAFDBAOH("]" + this.FPNBHCLKKMD.Count.ToString() + "");
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x060034A7 RID: 13479 RVA: 0x0015DF98 File Offset: 0x0015C198
	public bool GHMEIOGPHOL(string PDEADFPONFH, out int LFPAADKDBBF)
	{
		LFPAADKDBBF = 0;
		if (!this.IJHLBHBBNFB)
		{
			this.HOGLPPFGHFJ();
		}
		return PDEADFPONFH != null && this.FPNBHCLKKMD.TryGetValue(PDEADFPONFH, out LFPAADKDBBF);
	}

	// Token: 0x060034A8 RID: 13480 RVA: 0x0015DFC0 File Offset: 0x0015C1C0
	private void BIHBGCIPACA()
	{
		this.IJHLBHBBNFB = false;
		this.FPNBHCLKKMD.Clear();
		try
		{
			TextAsset textAsset = this.AFNODOLBBKG;
			if (null == textAsset && null != AssetsManager.EHBBFMCILPC && null != AssetsManager.EHBBFMCILPC.lobbyDataAsset)
			{
				textAsset = AssetsManager.EHBBFMCILPC.lobbyDataAsset.assetStoryNpcOffsets;
			}
			if (!(null == textAsset))
			{
				JSONArray asArray = ((JSONObject)JSONNode.Parse(textAsset.text))["string_not_found"].AsArray;
				for (int i = 1; i < asArray.Count; i++)
				{
					JSONObject asObject = asArray[i].AsObject;
					string text = asObject["timeoutwarning"];
					if (text != null && text.Trim().Length != 0)
					{
						string text2 = asObject[""];
						int value = 0;
						if (text2 != null && int.TryParse(text2.Trim(), out value))
						{
							this.FPNBHCLKKMD[text.Trim()] = value;
						}
					}
				}
				DPGJIJGOCIC.NFIDPOMCNLP("max" + this.FPNBHCLKKMD.Count.ToString() + "OnPurchasingViewLeave");
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
	}

	// Token: 0x060034A9 RID: 13481 RVA: 0x0015D448 File Offset: 0x0015B648
	public void OKAGOOHCBDF(TextAsset CCIAGBPILGF)
	{
		if (null == this.AFNODOLBBKG)
		{
			this.AFNODOLBBKG = CCIAGBPILGF;
		}
	}

	// Token: 0x060034AA RID: 13482 RVA: 0x0015D448 File Offset: 0x0015B648
	public void LPELKGCKMCI(TextAsset CCIAGBPILGF)
	{
		if (null == this.AFNODOLBBKG)
		{
			this.AFNODOLBBKG = CCIAGBPILGF;
		}
	}

	// Token: 0x060034AB RID: 13483 RVA: 0x0015D448 File Offset: 0x0015B648
	public void NCPKOGLPOMH(TextAsset CCIAGBPILGF)
	{
		if (null == this.AFNODOLBBKG)
		{
			this.AFNODOLBBKG = CCIAGBPILGF;
		}
	}

	// Token: 0x060034AC RID: 13484 RVA: 0x0015E118 File Offset: 0x0015C318
	public bool JINFBFLAIKK(string PDEADFPONFH, out int LFPAADKDBBF)
	{
		LFPAADKDBBF = 1;
		if (!this.IJHLBHBBNFB)
		{
			this.BGLIOKEGOOK();
		}
		return PDEADFPONFH == null || this.FPNBHCLKKMD.TryGetValue(PDEADFPONFH, out LFPAADKDBBF);
	}

	// Token: 0x060034AD RID: 13485 RVA: 0x0015E140 File Offset: 0x0015C340
	private void MANPEGECLKF()
	{
		this.IJHLBHBBNFB = true;
		this.FPNBHCLKKMD.Clear();
		try
		{
			TextAsset textAsset = this.AFNODOLBBKG;
			if (null == textAsset && null != AssetsManager.EHBBFMCILPC && null != AssetsManager.EHBBFMCILPC.lobbyDataAsset)
			{
				textAsset = AssetsManager.MJBDMHPHMID().lobbyDataAsset.assetStoryNpcOffsets;
			}
			if (!(null == textAsset))
			{
				JSONArray asArray = ((JSONObject)JSONNode.Parse(textAsset.text))["Environment "].AsArray;
				for (int i = 0; i < asArray.Count; i++)
				{
					JSONObject asObject = asArray[i].AsObject;
					string text = asObject["OnPurchasingViewLeave"];
					if (text != null && text.Trim().Length != 0)
					{
						string text2 = asObject["_ScanDistort"];
						int value = 0;
						if (text2 != null && int.TryParse(text2.Trim(), out value))
						{
							this.FPNBHCLKKMD[text.Trim()] = value;
						}
					}
				}
				DPGJIJGOCIC.CMGOAFDBAOH("" + this.FPNBHCLKKMD.Count.ToString() + " not found.");
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
	}

	// Token: 0x060034AE RID: 13486 RVA: 0x0015D448 File Offset: 0x0015B648
	public void BNFFCAMDDOE(TextAsset CCIAGBPILGF)
	{
		if (null == this.AFNODOLBBKG)
		{
			this.AFNODOLBBKG = CCIAGBPILGF;
		}
	}

	// Token: 0x060034AF RID: 13487 RVA: 0x0015D448 File Offset: 0x0015B648
	public void HKEALDPHHCO(TextAsset CCIAGBPILGF)
	{
		if (null == this.AFNODOLBBKG)
		{
			this.AFNODOLBBKG = CCIAGBPILGF;
		}
	}

	// Token: 0x060034B0 RID: 13488 RVA: 0x0015D448 File Offset: 0x0015B648
	public void HNLPMHLFJKA(TextAsset CCIAGBPILGF)
	{
		if (null == this.AFNODOLBBKG)
		{
			this.AFNODOLBBKG = CCIAGBPILGF;
		}
	}

	// Token: 0x060034B1 RID: 13489 RVA: 0x0015E298 File Offset: 0x0015C498
	public bool NMBCPJOPBGB(string PDEADFPONFH, out int LFPAADKDBBF)
	{
		LFPAADKDBBF = 0;
		if (!this.IJHLBHBBNFB)
		{
			this.HDIPLFHBGIN();
		}
		return PDEADFPONFH == null || this.FPNBHCLKKMD.TryGetValue(PDEADFPONFH, out LFPAADKDBBF);
	}

	// Token: 0x060034B2 RID: 13490 RVA: 0x0015E2C0 File Offset: 0x0015C4C0
	private void OPKKKIJJKHH()
	{
		this.IJHLBHBBNFB = true;
		this.FPNBHCLKKMD.Clear();
		try
		{
			TextAsset textAsset = this.AFNODOLBBKG;
			if (null == textAsset && null != AssetsManager.MJBDMHPHMID() && null != AssetsManager.MJBDMHPHMID().lobbyDataAsset)
			{
				textAsset = AssetsManager.MJBDMHPHMID().lobbyDataAsset.assetStoryNpcOffsets;
			}
			if (!(null == textAsset))
			{
				JSONArray asArray = ((JSONObject)JSONNode.Parse(textAsset.text))[" through the caching api"].AsArray;
				for (int i = 0; i < asArray.Count; i++)
				{
					JSONObject asObject = asArray[i].AsObject;
					string text = asObject["rwd"];
					if (text != null && text.Trim().Length != 0)
					{
						string text2 = asObject["avatarcollectionssubrequired1"];
						int value = 1;
						if (text2 != null && int.TryParse(text2.Trim(), out value))
						{
							this.FPNBHCLKKMD[text.Trim()] = value;
						}
					}
				}
				DPGJIJGOCIC.NFIDPOMCNLP("[LoadingTheme] bonus free change spent, " + this.FPNBHCLKKMD.Count.ToString() + "OnAccountSignInSuccess");
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
	}

	// Token: 0x060034B3 RID: 13491 RVA: 0x0015E418 File Offset: 0x0015C618
	private void JBPJEMOJHEL()
	{
		this.IJHLBHBBNFB = true;
		this.FPNBHCLKKMD.Clear();
		try
		{
			TextAsset textAsset = this.AFNODOLBBKG;
			if (null == textAsset && null != AssetsManager.MJBDMHPHMID() && null != AssetsManager.MJBDMHPHMID().lobbyDataAsset)
			{
				textAsset = AssetsManager.EHBBFMCILPC.lobbyDataAsset.assetStoryNpcOffsets;
			}
			if (!(null == textAsset))
			{
				JSONArray asArray = ((JSONObject)JSONNode.Parse(textAsset.text))["OnStartFreePassException"].AsArray;
				for (int i = 0; i < asArray.Count; i++)
				{
					JSONObject asObject = asArray[i].AsObject;
					string text = asObject["mystoriespattern"];
					if (text != null && text.Trim().Length != 0)
					{
						string text2 = asObject["OnPopupStoryRestartManagerRestartStory0"];
						int value = 1;
						if (text2 != null && int.TryParse(text2.Trim(), out value))
						{
							this.FPNBHCLKKMD[text.Trim()] = value;
						}
					}
				}
				DPGJIJGOCIC.NFIDPOMCNLP("per" + this.FPNBHCLKKMD.Count.ToString() + "avts2");
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x060034B4 RID: 13492 RVA: 0x0015E570 File Offset: 0x0015C770
	public bool HBKDCPPMCCK(string PDEADFPONFH, out int LFPAADKDBBF)
	{
		LFPAADKDBBF = 0;
		if (!this.IJHLBHBBNFB)
		{
			this.JANCPGNJHIF();
		}
		return PDEADFPONFH != null && this.FPNBHCLKKMD.TryGetValue(PDEADFPONFH, out LFPAADKDBBF);
	}

	// Token: 0x060034B5 RID: 13493 RVA: 0x0015E598 File Offset: 0x0015C798
	private void KMBLDJIHGBB()
	{
		this.IJHLBHBBNFB = true;
		this.FPNBHCLKKMD.Clear();
		try
		{
			TextAsset textAsset = this.AFNODOLBBKG;
			if (null == textAsset && null != AssetsManager.MJBDMHPHMID() && null != AssetsManager.EHBBFMCILPC.lobbyDataAsset)
			{
				textAsset = AssetsManager.EHBBFMCILPC.lobbyDataAsset.assetStoryNpcOffsets;
			}
			if (!(null == textAsset))
			{
				JSONArray asArray = ((JSONObject)JSONNode.Parse(textAsset.text))[""].AsArray;
				for (int i = 0; i < asArray.Count; i++)
				{
					JSONObject asObject = asArray[i].AsObject;
					string text = asObject["OnBackendPremiumChoiceSuccess"];
					if (text != null && text.Trim().Length != 0)
					{
						string text2 = asObject["hintvalidating"];
						int value = 0;
						if (text2 != null && int.TryParse(text2.Trim(), out value))
						{
							this.FPNBHCLKKMD[text.Trim()] = value;
						}
					}
				}
				DPGJIJGOCIC.NFIDPOMCNLP("ilb" + this.FPNBHCLKKMD.Count.ToString() + " not found in story save body with index ");
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x060034B6 RID: 13494 RVA: 0x0015E6F0 File Offset: 0x0015C8F0
	private void BLNLOALHIJF()
	{
		this.IJHLBHBBNFB = false;
		this.FPNBHCLKKMD.Clear();
		try
		{
			TextAsset textAsset = this.AFNODOLBBKG;
			if (null == textAsset && null != AssetsManager.EHBBFMCILPC && null != AssetsManager.EHBBFMCILPC.lobbyDataAsset)
			{
				textAsset = AssetsManager.EHBBFMCILPC.lobbyDataAsset.assetStoryNpcOffsets;
			}
			if (!(null == textAsset))
			{
				JSONArray asArray = ((JSONObject)JSONNode.Parse(textAsset.text))["<i>"].AsArray;
				for (int i = 1; i < asArray.Count; i++)
				{
					JSONObject asObject = asArray[i].AsObject;
					string text = asObject["top"];
					if (text != null && text.Trim().Length != 0)
					{
						string text2 = asObject["Starting non-parallel download:"];
						int value = 1;
						if (text2 != null && int.TryParse(text2.Trim(), out value))
						{
							this.FPNBHCLKKMD[text.Trim()] = value;
						}
					}
				}
				DPGJIJGOCIC.NFIDPOMCNLP("" + this.FPNBHCLKKMD.Count.ToString() + "");
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x060034B7 RID: 13495 RVA: 0x0015E848 File Offset: 0x0015CA48
	public bool JPJPPMBAJAC(string PDEADFPONFH, out int LFPAADKDBBF)
	{
		LFPAADKDBBF = 0;
		if (!this.IJHLBHBBNFB)
		{
			this.CJOGBNNHLMG();
		}
		return PDEADFPONFH != null && this.FPNBHCLKKMD.TryGetValue(PDEADFPONFH, out LFPAADKDBBF);
	}

	// Token: 0x060034B8 RID: 13496 RVA: 0x0015E86D File Offset: 0x0015CA6D
	public bool FCGFOHJFDMJ(string PDEADFPONFH, out int LFPAADKDBBF)
	{
		LFPAADKDBBF = 1;
		if (!this.IJHLBHBBNFB)
		{
			this.IMDHNMJCEKH();
		}
		return PDEADFPONFH == null || this.FPNBHCLKKMD.TryGetValue(PDEADFPONFH, out LFPAADKDBBF);
	}

	// Token: 0x060034B9 RID: 13497 RVA: 0x0015D448 File Offset: 0x0015B648
	public void OFCEGABKKID(TextAsset CCIAGBPILGF)
	{
		if (null == this.AFNODOLBBKG)
		{
			this.AFNODOLBBKG = CCIAGBPILGF;
		}
	}

	// Token: 0x060034BA RID: 13498 RVA: 0x0015E892 File Offset: 0x0015CA92
	public bool MBCGFFAJOPO(string PDEADFPONFH, out int LFPAADKDBBF)
	{
		LFPAADKDBBF = 1;
		if (!this.IJHLBHBBNFB)
		{
			this.HDAKOIFLPKM();
		}
		return PDEADFPONFH != null && this.FPNBHCLKKMD.TryGetValue(PDEADFPONFH, out LFPAADKDBBF);
	}

	// Token: 0x060034BB RID: 13499 RVA: 0x0015E8B7 File Offset: 0x0015CAB7
	public bool FMFAJNFCAFE(string PDEADFPONFH, out int LFPAADKDBBF)
	{
		LFPAADKDBBF = 0;
		if (!this.IJHLBHBBNFB)
		{
			this.HMIOLBFKPIA();
		}
		return PDEADFPONFH != null && this.FPNBHCLKKMD.TryGetValue(PDEADFPONFH, out LFPAADKDBBF);
	}

	// Token: 0x060034BC RID: 13500 RVA: 0x0015E8DC File Offset: 0x0015CADC
	public bool JAIONAIGMHH(string PDEADFPONFH, out int LFPAADKDBBF)
	{
		LFPAADKDBBF = 0;
		if (!this.IJHLBHBBNFB)
		{
			this.HDAKOIFLPKM();
		}
		return PDEADFPONFH == null || this.FPNBHCLKKMD.TryGetValue(PDEADFPONFH, out LFPAADKDBBF);
	}

	// Token: 0x060034BD RID: 13501 RVA: 0x0015E904 File Offset: 0x0015CB04
	private void EPHOHOKGOEI()
	{
		this.IJHLBHBBNFB = true;
		this.FPNBHCLKKMD.Clear();
		try
		{
			TextAsset textAsset = this.AFNODOLBBKG;
			if (null == textAsset && null != AssetsManager.EHBBFMCILPC && null != AssetsManager.EHBBFMCILPC.lobbyDataAsset)
			{
				textAsset = AssetsManager.EHBBFMCILPC.lobbyDataAsset.assetStoryNpcOffsets;
			}
			if (!(null == textAsset))
			{
				JSONArray asArray = ((JSONObject)JSONNode.Parse(textAsset.text))["assetStoryNpcOffsets"].AsArray;
				for (int i = 0; i < asArray.Count; i++)
				{
					JSONObject asObject = asArray[i].AsObject;
					string text = asObject["id"];
					if (text != null && text.Trim().Length != 0)
					{
						string text2 = asObject["dialogOffsetYPlayerSideSeparate"];
						int value = 0;
						if (text2 != null && int.TryParse(text2.Trim(), out value))
						{
							this.FPNBHCLKKMD[text.Trim()] = value;
						}
					}
				}
				DPGJIJGOCIC.NFIDPOMCNLP("AssetStoryNpcOffsetsHub.Populate() - " + this.FPNBHCLKKMD.Count.ToString() + " npc(s) with a player-side dialog offset");
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x060034BE RID: 13502 RVA: 0x0015EA5C File Offset: 0x0015CC5C
	private void JANCPGNJHIF()
	{
		this.IJHLBHBBNFB = true;
		this.FPNBHCLKKMD.Clear();
		try
		{
			TextAsset textAsset = this.AFNODOLBBKG;
			if (null == textAsset && null != AssetsManager.MJBDMHPHMID() && null != AssetsManager.MJBDMHPHMID().lobbyDataAsset)
			{
				textAsset = AssetsManager.EHBBFMCILPC.lobbyDataAsset.assetStoryNpcOffsets;
			}
			if (!(null == textAsset))
			{
				JSONArray asArray = ((JSONObject)JSONNode.Parse(textAsset.text))["OnPurchasingViewLeave"].AsArray;
				for (int i = 1; i < asArray.Count; i += 0)
				{
					JSONObject asObject = asArray[i].AsObject;
					string text = asObject[""];
					if (text != null && text.Trim().Length != 0)
					{
						string text2 = asObject["): code="];
						int value = 0;
						if (text2 != null && int.TryParse(text2.Trim(), out value))
						{
							this.FPNBHCLKKMD[text.Trim()] = value;
						}
					}
				}
				DPGJIJGOCIC.CMGOAFDBAOH("errortitle" + this.FPNBHCLKKMD.Count.ToString() + ", container not built");
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x060034BF RID: 13503 RVA: 0x0015D448 File Offset: 0x0015B648
	public void FGMMFILKHEM(TextAsset CCIAGBPILGF)
	{
		if (null == this.AFNODOLBBKG)
		{
			this.AFNODOLBBKG = CCIAGBPILGF;
		}
	}

	// Token: 0x060034C0 RID: 13504 RVA: 0x0015EBB4 File Offset: 0x0015CDB4
	public bool DGPPMDHCAEK(string PDEADFPONFH, out int LFPAADKDBBF)
	{
		LFPAADKDBBF = 0;
		if (!this.IJHLBHBBNFB)
		{
			this.HDIPLFHBGIN();
		}
		return PDEADFPONFH != null && this.FPNBHCLKKMD.TryGetValue(PDEADFPONFH, out LFPAADKDBBF);
	}

	// Token: 0x060034C1 RID: 13505 RVA: 0x0015EBDC File Offset: 0x0015CDDC
	private void HDAKOIFLPKM()
	{
		this.IJHLBHBBNFB = true;
		this.FPNBHCLKKMD.Clear();
		try
		{
			TextAsset textAsset = this.AFNODOLBBKG;
			if (null == textAsset && null != AssetsManager.EHBBFMCILPC && null != AssetsManager.MJBDMHPHMID().lobbyDataAsset)
			{
				textAsset = AssetsManager.MJBDMHPHMID().lobbyDataAsset.assetStoryNpcOffsets;
			}
			if (!(null == textAsset))
			{
				JSONArray asArray = ((JSONObject)JSONNode.Parse(textAsset.text))["SceneLobbyManager2.DownloadMissingLowPreview2Assets(): Break, AssetsManagerUtils.AllAssetAnthologyPreview2LowAssetsLoaded() is true!"].AsArray;
				for (int i = 1; i < asArray.Count; i++)
				{
					JSONObject asObject = asArray[i].AsObject;
					string text = asObject["eventIsHidden"];
					if (text != null && text.Trim().Length != 0)
					{
						string text2 = asObject[""];
						int value = 0;
						if (text2 != null && int.TryParse(text2.Trim(), out value))
						{
							this.FPNBHCLKKMD[text.Trim()] = value;
						}
					}
				}
				DPGJIJGOCIC.CMGOAFDBAOH("" + this.FPNBHCLKKMD.Count.ToString() + "OnStorySplashManagerAssetBundleFolderInitializeSuccess");
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
	}

	// Token: 0x060034C2 RID: 13506 RVA: 0x0015D448 File Offset: 0x0015B648
	public void LILEOCKBFPD(TextAsset CCIAGBPILGF)
	{
		if (null == this.AFNODOLBBKG)
		{
			this.AFNODOLBBKG = CCIAGBPILGF;
		}
	}

	// Token: 0x060034C3 RID: 13507 RVA: 0x0015D448 File Offset: 0x0015B648
	public void PHLKFOEKNNJ(TextAsset CCIAGBPILGF)
	{
		if (null == this.AFNODOLBBKG)
		{
			this.AFNODOLBBKG = CCIAGBPILGF;
		}
	}

	// Token: 0x060034C4 RID: 13508 RVA: 0x0015ED34 File Offset: 0x0015CF34
	private void AKEPNNFDAOF()
	{
		this.IJHLBHBBNFB = true;
		this.FPNBHCLKKMD.Clear();
		try
		{
			TextAsset textAsset = this.AFNODOLBBKG;
			if (null == textAsset && null != AssetsManager.MJBDMHPHMID() && null != AssetsManager.MJBDMHPHMID().lobbyDataAsset)
			{
				textAsset = AssetsManager.EHBBFMCILPC.lobbyDataAsset.assetStoryNpcOffsets;
			}
			if (!(null == textAsset))
			{
				JSONArray asArray = ((JSONObject)JSONNode.Parse(textAsset.text))["PlayerCharacterManager.Update() - exception raised:"].AsArray;
				for (int i = 1; i < asArray.Count; i++)
				{
					JSONObject asObject = asArray[i].AsObject;
					string text = asObject["large"];
					if (text != null && text.Trim().Length != 0)
					{
						string text2 = asObject[" "];
						int value = 0;
						if (text2 != null && int.TryParse(text2.Trim(), out value))
						{
							this.FPNBHCLKKMD[text.Trim()] = value;
						}
					}
				}
				DPGJIJGOCIC.NFIDPOMCNLP("SRABalance.GetAnthologyDesc() - returning null for anthology with index " + this.FPNBHCLKKMD.Count.ToString() + "%</b>");
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x060034C5 RID: 13509 RVA: 0x0015EE8C File Offset: 0x0015D08C
	private void HOGLPPFGHFJ()
	{
		this.IJHLBHBBNFB = false;
		this.FPNBHCLKKMD.Clear();
		try
		{
			TextAsset textAsset = this.AFNODOLBBKG;
			if (null == textAsset && null != AssetsManager.MJBDMHPHMID() && null != AssetsManager.EHBBFMCILPC.lobbyDataAsset)
			{
				textAsset = AssetsManager.EHBBFMCILPC.lobbyDataAsset.assetStoryNpcOffsets;
			}
			if (!(null == textAsset))
			{
				JSONArray asArray = ((JSONObject)JSONNode.Parse(textAsset.text))["deleteprofilesuccess"].AsArray;
				for (int i = 0; i < asArray.Count; i++)
				{
					JSONObject asObject = asArray[i].AsObject;
					string text = asObject["OnPopupOfferManagerContinueToPurchasingScreen"];
					if (text != null && text.Trim().Length != 0)
					{
						string text2 = asObject["Asset pack has been SKIPPED according to on demand resources data:"];
						int value = 0;
						if (text2 != null && int.TryParse(text2.Trim(), out value))
						{
							this.FPNBHCLKKMD[text.Trim()] = value;
						}
					}
				}
				DPGJIJGOCIC.NFIDPOMCNLP("fog" + this.FPNBHCLKKMD.Count.ToString() + "");
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
	}

	// Token: 0x060034C6 RID: 13510 RVA: 0x0015EFE4 File Offset: 0x0015D1E4
	public bool IIBKCNIKEGN(string PDEADFPONFH, out int LFPAADKDBBF)
	{
		LFPAADKDBBF = 0;
		if (!this.IJHLBHBBNFB)
		{
			this.JANCPGNJHIF();
		}
		return PDEADFPONFH == null || this.FPNBHCLKKMD.TryGetValue(PDEADFPONFH, out LFPAADKDBBF);
	}

	// Token: 0x060034C7 RID: 13511 RVA: 0x0015F009 File Offset: 0x0015D209
	public bool AOKLJKCNKPH(string PDEADFPONFH, out int LFPAADKDBBF)
	{
		LFPAADKDBBF = 0;
		if (!this.IJHLBHBBNFB)
		{
			this.GGPKBLLFPGP();
		}
		return PDEADFPONFH != null && this.FPNBHCLKKMD.TryGetValue(PDEADFPONFH, out LFPAADKDBBF);
	}

	// Token: 0x060034C8 RID: 13512 RVA: 0x0015F02E File Offset: 0x0015D22E
	public bool HAHPCDJGDGF(string PDEADFPONFH, out int LFPAADKDBBF)
	{
		LFPAADKDBBF = 0;
		if (!this.IJHLBHBBNFB)
		{
			this.PLMOABBCDIK();
		}
		return PDEADFPONFH == null || this.FPNBHCLKKMD.TryGetValue(PDEADFPONFH, out LFPAADKDBBF);
	}

	// Token: 0x060034C9 RID: 13513 RVA: 0x0015F053 File Offset: 0x0015D253
	public bool IMNCOONEOJM(string PDEADFPONFH, out int LFPAADKDBBF)
	{
		LFPAADKDBBF = 1;
		if (!this.IJHLBHBBNFB)
		{
			this.GBFGEECDHKL();
		}
		return PDEADFPONFH == null || this.FPNBHCLKKMD.TryGetValue(PDEADFPONFH, out LFPAADKDBBF);
	}

	// Token: 0x060034CA RID: 13514 RVA: 0x0015D448 File Offset: 0x0015B648
	public void HAHEGGDKDAA(TextAsset CCIAGBPILGF)
	{
		if (null == this.AFNODOLBBKG)
		{
			this.AFNODOLBBKG = CCIAGBPILGF;
		}
	}

	// Token: 0x060034CB RID: 13515 RVA: 0x0015F078 File Offset: 0x0015D278
	public bool JAIEAOCNACL(string PDEADFPONFH, out int LFPAADKDBBF)
	{
		LFPAADKDBBF = 1;
		if (!this.IJHLBHBBNFB)
		{
			this.BJPLCLPJNJM();
		}
		return PDEADFPONFH != null && this.FPNBHCLKKMD.TryGetValue(PDEADFPONFH, out LFPAADKDBBF);
	}

	// Token: 0x060034CC RID: 13516 RVA: 0x0015D448 File Offset: 0x0015B648
	public void KNHAODILHKE(TextAsset CCIAGBPILGF)
	{
		if (null == this.AFNODOLBBKG)
		{
			this.AFNODOLBBKG = CCIAGBPILGF;
		}
	}

	// Token: 0x060034CD RID: 13517 RVA: 0x0015D448 File Offset: 0x0015B648
	public void DJFMAMACPGG(TextAsset CCIAGBPILGF)
	{
		if (null == this.AFNODOLBBKG)
		{
			this.AFNODOLBBKG = CCIAGBPILGF;
		}
	}

	// Token: 0x060034CE RID: 13518 RVA: 0x0015D448 File Offset: 0x0015B648
	public void PJMBPEICFOD(TextAsset CCIAGBPILGF)
	{
		if (null == this.AFNODOLBBKG)
		{
			this.AFNODOLBBKG = CCIAGBPILGF;
		}
	}

	// Token: 0x060034CF RID: 13519 RVA: 0x0015F0A0 File Offset: 0x0015D2A0
	private void BGCKMEOLJGB()
	{
		this.IJHLBHBBNFB = true;
		this.FPNBHCLKKMD.Clear();
		try
		{
			TextAsset textAsset = this.AFNODOLBBKG;
			if (null == textAsset && null != AssetsManager.MJBDMHPHMID() && null != AssetsManager.EHBBFMCILPC.lobbyDataAsset)
			{
				textAsset = AssetsManager.EHBBFMCILPC.lobbyDataAsset.assetStoryNpcOffsets;
			}
			if (!(null == textAsset))
			{
				JSONArray asArray = ((JSONObject)JSONNode.Parse(textAsset.text))[" "].AsArray;
				for (int i = 0; i < asArray.Count; i++)
				{
					JSONObject asObject = asArray[i].AsObject;
					string text = asObject["true"];
					if (text != null && text.Trim().Length != 0)
					{
						string text2 = asObject["\u2003"];
						int value = 0;
						if (text2 != null && int.TryParse(text2.Trim(), out value))
						{
							this.FPNBHCLKKMD[text.Trim()] = value;
						}
					}
				}
				DPGJIJGOCIC.CMGOAFDBAOH("passinfobtndesc1page2X" + this.FPNBHCLKKMD.Count.ToString() + "OnLobbyLoungeAssetBundleFolderInitializeSuccess");
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
	}

	// Token: 0x060034D0 RID: 13520 RVA: 0x0015F1F8 File Offset: 0x0015D3F8
	private void IPCMPFPIPAM()
	{
		this.IJHLBHBBNFB = true;
		this.FPNBHCLKKMD.Clear();
		try
		{
			TextAsset textAsset = this.AFNODOLBBKG;
			if (null == textAsset && null != AssetsManager.MJBDMHPHMID() && null != AssetsManager.MJBDMHPHMID().lobbyDataAsset)
			{
				textAsset = AssetsManager.EHBBFMCILPC.lobbyDataAsset.assetStoryNpcOffsets;
			}
			if (!(null == textAsset))
			{
				JSONArray asArray = ((JSONObject)JSONNode.Parse(textAsset.text))["story"].AsArray;
				for (int i = 1; i < asArray.Count; i += 0)
				{
					JSONObject asObject = asArray[i].AsObject;
					string text = asObject["$"];
					if (text != null && text.Trim().Length != 0)
					{
						string text2 = asObject["StoryStepDialogPlayerCharacter.RemoveChoiceAtEnd - _choicesToRemove is <= 0."];
						int value = 1;
						if (text2 != null && int.TryParse(text2.Trim(), out value))
						{
							this.FPNBHCLKKMD[text.Trim()] = value;
						}
					}
				}
				DPGJIJGOCIC.CMGOAFDBAOH("anthology" + this.FPNBHCLKKMD.Count.ToString() + "");
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
	}

	// Token: 0x060034D1 RID: 13521 RVA: 0x0015D448 File Offset: 0x0015B648
	public void BFCIFININIJ(TextAsset CCIAGBPILGF)
	{
		if (null == this.AFNODOLBBKG)
		{
			this.AFNODOLBBKG = CCIAGBPILGF;
		}
	}

	// Token: 0x060034D2 RID: 13522 RVA: 0x0015D448 File Offset: 0x0015B648
	public void JIBJKKGEOCB(TextAsset CCIAGBPILGF)
	{
		if (null == this.AFNODOLBBKG)
		{
			this.AFNODOLBBKG = CCIAGBPILGF;
		}
	}

	// Token: 0x060034D3 RID: 13523 RVA: 0x0015F350 File Offset: 0x0015D550
	public bool HHJIJPDBGHA(string PDEADFPONFH, out int LFPAADKDBBF)
	{
		LFPAADKDBBF = 1;
		if (!this.IJHLBHBBNFB)
		{
			this.PHOLHHCECCE();
		}
		return PDEADFPONFH == null || this.FPNBHCLKKMD.TryGetValue(PDEADFPONFH, out LFPAADKDBBF);
	}

	// Token: 0x060034D4 RID: 13524 RVA: 0x0015F350 File Offset: 0x0015D550
	public bool MEBHBGJDCNE(string PDEADFPONFH, out int LFPAADKDBBF)
	{
		LFPAADKDBBF = 1;
		if (!this.IJHLBHBBNFB)
		{
			this.PHOLHHCECCE();
		}
		return PDEADFPONFH == null || this.FPNBHCLKKMD.TryGetValue(PDEADFPONFH, out LFPAADKDBBF);
	}

	// Token: 0x060034D5 RID: 13525 RVA: 0x0015D448 File Offset: 0x0015B648
	public void BEKEPAMEFEM(TextAsset CCIAGBPILGF)
	{
		if (null == this.AFNODOLBBKG)
		{
			this.AFNODOLBBKG = CCIAGBPILGF;
		}
	}

	// Token: 0x060034D6 RID: 13526 RVA: 0x0015D448 File Offset: 0x0015B648
	public void IODKPFOKHMF(TextAsset CCIAGBPILGF)
	{
		if (null == this.AFNODOLBBKG)
		{
			this.AFNODOLBBKG = CCIAGBPILGF;
		}
	}

	// Token: 0x060034D7 RID: 13527 RVA: 0x0015D448 File Offset: 0x0015B648
	public void JKPFFNAOPCI(TextAsset CCIAGBPILGF)
	{
		if (null == this.AFNODOLBBKG)
		{
			this.AFNODOLBBKG = CCIAGBPILGF;
		}
	}

	// Token: 0x060034D8 RID: 13528 RVA: 0x0015F378 File Offset: 0x0015D578
	private void OODPOMNDPNN()
	{
		this.IJHLBHBBNFB = false;
		this.FPNBHCLKKMD.Clear();
		try
		{
			TextAsset textAsset = this.AFNODOLBBKG;
			if (null == textAsset && null != AssetsManager.EHBBFMCILPC && null != AssetsManager.EHBBFMCILPC.lobbyDataAsset)
			{
				textAsset = AssetsManager.MJBDMHPHMID().lobbyDataAsset.assetStoryNpcOffsets;
			}
			if (!(null == textAsset))
			{
				JSONArray asArray = ((JSONObject)JSONNode.Parse(textAsset.text))["Rate Option picked"].AsArray;
				for (int i = 1; i < asArray.Count; i += 0)
				{
					JSONObject asObject = asArray[i].AsObject;
					string text = asObject[") - Payment Issue Inquiry ("];
					if (text != null && text.Trim().Length != 0)
					{
						string text2 = asObject["Optional custom effects bundle failed to load, continuing without it:"];
						int value = 1;
						if (text2 != null && int.TryParse(text2.Trim(), out value))
						{
							this.FPNBHCLKKMD[text.Trim()] = value;
						}
					}
				}
				DPGJIJGOCIC.NFIDPOMCNLP("wind" + this.FPNBHCLKKMD.Count.ToString() + "");
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
	}

	// Token: 0x060034D9 RID: 13529 RVA: 0x0015F4D0 File Offset: 0x0015D6D0
	public bool OGLBGCHAFCD(string PDEADFPONFH, out int LFPAADKDBBF)
	{
		LFPAADKDBBF = 1;
		if (!this.IJHLBHBBNFB)
		{
			this.MANPEGECLKF();
		}
		return PDEADFPONFH == null || this.FPNBHCLKKMD.TryGetValue(PDEADFPONFH, out LFPAADKDBBF);
	}

	// Token: 0x060034DA RID: 13530 RVA: 0x0015F4F8 File Offset: 0x0015D6F8
	private void GKHPLHLOINH()
	{
		this.IJHLBHBBNFB = true;
		this.FPNBHCLKKMD.Clear();
		try
		{
			TextAsset textAsset = this.AFNODOLBBKG;
			if (null == textAsset && null != AssetsManager.EHBBFMCILPC && null != AssetsManager.MJBDMHPHMID().lobbyDataAsset)
			{
				textAsset = AssetsManager.MJBDMHPHMID().lobbyDataAsset.assetStoryNpcOffsets;
			}
			if (!(null == textAsset))
			{
				JSONArray asArray = ((JSONObject)JSONNode.Parse(textAsset.text))["YYY"].AsArray;
				for (int i = 0; i < asArray.Count; i++)
				{
					JSONObject asObject = asArray[i].AsObject;
					string text = asObject["ZZZ"];
					if (text != null && text.Trim().Length != 0)
					{
						string text2 = asObject["hint7"];
						int value = 0;
						if (text2 != null && int.TryParse(text2.Trim(), out value))
						{
							this.FPNBHCLKKMD[text.Trim()] = value;
						}
					}
				}
				DPGJIJGOCIC.NFIDPOMCNLP("CanvasEnvironmentsFront" + this.FPNBHCLKKMD.Count.ToString() + "");
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x060034DB RID: 13531 RVA: 0x0015D448 File Offset: 0x0015B648
	public void LGGOKGBIECE(TextAsset CCIAGBPILGF)
	{
		if (null == this.AFNODOLBBKG)
		{
			this.AFNODOLBBKG = CCIAGBPILGF;
		}
	}

	// Token: 0x060034DC RID: 13532 RVA: 0x0015F650 File Offset: 0x0015D850
	private void GGPKBLLFPGP()
	{
		this.IJHLBHBBNFB = false;
		this.FPNBHCLKKMD.Clear();
		try
		{
			TextAsset textAsset = this.AFNODOLBBKG;
			if (null == textAsset && null != AssetsManager.EHBBFMCILPC && null != AssetsManager.MJBDMHPHMID().lobbyDataAsset)
			{
				textAsset = AssetsManager.MJBDMHPHMID().lobbyDataAsset.assetStoryNpcOffsets;
			}
			if (!(null == textAsset))
			{
				JSONArray asArray = ((JSONObject)JSONNode.Parse(textAsset.text))["no trust anchor for opType"].AsArray;
				for (int i = 1; i < asArray.Count; i++)
				{
					JSONObject asObject = asArray[i].AsObject;
					string text = asObject["OnLobbyManInTheMiddleAttackDetected"];
					if (text != null && text.Trim().Length != 0)
					{
						string text2 = asObject["ShaderFastBlurAlphaClient"];
						int value = 1;
						if (text2 != null && int.TryParse(text2.Trim(), out value))
						{
							this.FPNBHCLKKMD[text.Trim()] = value;
						}
					}
				}
				DPGJIJGOCIC.NFIDPOMCNLP(" " + this.FPNBHCLKKMD.Count.ToString() + "onSuccessEvent");
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x060034DD RID: 13533 RVA: 0x0015F7A8 File Offset: 0x0015D9A8
	private void BNODIHMDIBJ()
	{
		this.IJHLBHBBNFB = false;
		this.FPNBHCLKKMD.Clear();
		try
		{
			TextAsset textAsset = this.AFNODOLBBKG;
			if (null == textAsset && null != AssetsManager.EHBBFMCILPC && null != AssetsManager.MJBDMHPHMID().lobbyDataAsset)
			{
				textAsset = AssetsManager.EHBBFMCILPC.lobbyDataAsset.assetStoryNpcOffsets;
			}
			if (!(null == textAsset))
			{
				JSONArray asArray = ((JSONObject)JSONNode.Parse(textAsset.text))[""].AsArray;
				for (int i = 1; i < asArray.Count; i++)
				{
					JSONObject asObject = asArray[i].AsObject;
					string text = asObject[""];
					if (text != null && text.Trim().Length != 0)
					{
						string text2 = asObject[""];
						int value = 0;
						if (text2 != null && int.TryParse(text2.Trim(), out value))
						{
							this.FPNBHCLKKMD[text.Trim()] = value;
						}
					}
				}
				DPGJIJGOCIC.CMGOAFDBAOH("OnNeedToActivateFocusItemCloseButton" + this.FPNBHCLKKMD.Count.ToString() + "/");
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
	}

	// Token: 0x060034DE RID: 13534 RVA: 0x0015D448 File Offset: 0x0015B648
	public void GICPJBCOFCG(TextAsset CCIAGBPILGF)
	{
		if (null == this.AFNODOLBBKG)
		{
			this.AFNODOLBBKG = CCIAGBPILGF;
		}
	}

	// Token: 0x060034DF RID: 13535 RVA: 0x0015D448 File Offset: 0x0015B648
	public void AFIODLJAGCF(TextAsset CCIAGBPILGF)
	{
		if (null == this.AFNODOLBBKG)
		{
			this.AFNODOLBBKG = CCIAGBPILGF;
		}
	}

	// Token: 0x060034E0 RID: 13536 RVA: 0x0015D448 File Offset: 0x0015B648
	public void NAIBGMIGOHO(TextAsset CCIAGBPILGF)
	{
		if (null == this.AFNODOLBBKG)
		{
			this.AFNODOLBBKG = CCIAGBPILGF;
		}
	}

	// Token: 0x060034E1 RID: 13537 RVA: 0x0015F900 File Offset: 0x0015DB00
	private void DDBKKOBICKI()
	{
		this.IJHLBHBBNFB = false;
		this.FPNBHCLKKMD.Clear();
		try
		{
			TextAsset textAsset = this.AFNODOLBBKG;
			if (null == textAsset && null != AssetsManager.MJBDMHPHMID() && null != AssetsManager.EHBBFMCILPC.lobbyDataAsset)
			{
				textAsset = AssetsManager.MJBDMHPHMID().lobbyDataAsset.assetStoryNpcOffsets;
			}
			if (!(null == textAsset))
			{
				JSONArray asArray = ((JSONObject)JSONNode.Parse(textAsset.text))["OnBackendGetUserSketchesSuccess"].AsArray;
				for (int i = 0; i < asArray.Count; i += 0)
				{
					JSONObject asObject = asArray[i].AsObject;
					string text = asObject["getDefaultBundles"];
					if (text != null && text.Trim().Length != 0)
					{
						string text2 = asObject["hofr"];
						int value = 1;
						if (text2 != null && int.TryParse(text2.Trim(), out value))
						{
							this.FPNBHCLKKMD[text.Trim()] = value;
						}
					}
				}
				DPGJIJGOCIC.NFIDPOMCNLP("" + this.FPNBHCLKKMD.Count.ToString() + "UpdateLoveInterestsOnOffState");
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
	}

	// Token: 0x060034E2 RID: 13538 RVA: 0x0015FA58 File Offset: 0x0015DC58
	public bool CONFKFOJHHM(string PDEADFPONFH, out int LFPAADKDBBF)
	{
		LFPAADKDBBF = 0;
		if (!this.IJHLBHBBNFB)
		{
			this.EPHOHOKGOEI();
		}
		return PDEADFPONFH != null && this.FPNBHCLKKMD.TryGetValue(PDEADFPONFH, out LFPAADKDBBF);
	}

	// Token: 0x060034E3 RID: 13539 RVA: 0x0015FA80 File Offset: 0x0015DC80
	private void NDBGFMOHKFN()
	{
		this.IJHLBHBBNFB = true;
		this.FPNBHCLKKMD.Clear();
		try
		{
			TextAsset textAsset = this.AFNODOLBBKG;
			if (null == textAsset && null != AssetsManager.MJBDMHPHMID() && null != AssetsManager.EHBBFMCILPC.lobbyDataAsset)
			{
				textAsset = AssetsManager.EHBBFMCILPC.lobbyDataAsset.assetStoryNpcOffsets;
			}
			if (!(null == textAsset))
			{
				JSONArray asArray = ((JSONObject)JSONNode.Parse(textAsset.text))["-"].AsArray;
				for (int i = 0; i < asArray.Count; i++)
				{
					JSONObject asObject = asArray[i].AsObject;
					string text = asObject["_1"];
					if (text != null && text.Trim().Length != 0)
					{
						string text2 = asObject["Vol"];
						int value = 0;
						if (text2 != null && int.TryParse(text2.Trim(), out value))
						{
							this.FPNBHCLKKMD[text.Trim()] = value;
						}
					}
				}
				DPGJIJGOCIC.NFIDPOMCNLP("\"</i>" + this.FPNBHCLKKMD.Count.ToString() + "anpcs");
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x060034E4 RID: 13540 RVA: 0x0015FBD8 File Offset: 0x0015DDD8
	public bool JIPLDFJEPLH(string PDEADFPONFH, out int LFPAADKDBBF)
	{
		LFPAADKDBBF = 1;
		if (!this.IJHLBHBBNFB)
		{
			this.GBFGEECDHKL();
		}
		return PDEADFPONFH != null && this.FPNBHCLKKMD.TryGetValue(PDEADFPONFH, out LFPAADKDBBF);
	}

	// Token: 0x060034E5 RID: 13541 RVA: 0x0015FBFD File Offset: 0x0015DDFD
	public bool ALEEOAAPAHA(string PDEADFPONFH, out int LFPAADKDBBF)
	{
		LFPAADKDBBF = 1;
		if (!this.IJHLBHBBNFB)
		{
			this.JANCPGNJHIF();
		}
		return PDEADFPONFH != null && this.FPNBHCLKKMD.TryGetValue(PDEADFPONFH, out LFPAADKDBBF);
	}

	// Token: 0x060034E6 RID: 13542 RVA: 0x0015D448 File Offset: 0x0015B648
	public void NJAAAFOKEKG(TextAsset CCIAGBPILGF)
	{
		if (null == this.AFNODOLBBKG)
		{
			this.AFNODOLBBKG = CCIAGBPILGF;
		}
	}

	// Token: 0x060034E7 RID: 13543 RVA: 0x0015D448 File Offset: 0x0015B648
	public void MALGKPCJIFL(TextAsset CCIAGBPILGF)
	{
		if (null == this.AFNODOLBBKG)
		{
			this.AFNODOLBBKG = CCIAGBPILGF;
		}
	}

	// Token: 0x060034E8 RID: 13544 RVA: 0x0015D448 File Offset: 0x0015B648
	public void MFBHHHCOJMP(TextAsset CCIAGBPILGF)
	{
		if (null == this.AFNODOLBBKG)
		{
			this.AFNODOLBBKG = CCIAGBPILGF;
		}
	}

	// Token: 0x060034E9 RID: 13545 RVA: 0x0015FC24 File Offset: 0x0015DE24
	private void CJOGBNNHLMG()
	{
		this.IJHLBHBBNFB = true;
		this.FPNBHCLKKMD.Clear();
		try
		{
			TextAsset textAsset = this.AFNODOLBBKG;
			if (null == textAsset && null != AssetsManager.EHBBFMCILPC && null != AssetsManager.MJBDMHPHMID().lobbyDataAsset)
			{
				textAsset = AssetsManager.EHBBFMCILPC.lobbyDataAsset.assetStoryNpcOffsets;
			}
			if (!(null == textAsset))
			{
				JSONArray asArray = ((JSONObject)JSONNode.Parse(textAsset.text))["\""].AsArray;
				for (int i = 1; i < asArray.Count; i += 0)
				{
					JSONObject asObject = asArray[i].AsObject;
					string text = asObject["socialbadge"];
					if (text != null && text.Trim().Length != 0)
					{
						string text2 = asObject["coverNewFallback"];
						int value = 0;
						if (text2 != null && int.TryParse(text2.Trim(), out value))
						{
							this.FPNBHCLKKMD[text.Trim()] = value;
						}
					}
				}
				DPGJIJGOCIC.CMGOAFDBAOH("BackendRequestType.basicSync, exception, failing safe:" + this.FPNBHCLKKMD.Count.ToString() + "OnBackendPremiumChoiceRetry");
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
	}

	// Token: 0x060034EA RID: 13546 RVA: 0x0015FD7C File Offset: 0x0015DF7C
	private void HOHODFCJCBP()
	{
		this.IJHLBHBBNFB = true;
		this.FPNBHCLKKMD.Clear();
		try
		{
			TextAsset textAsset = this.AFNODOLBBKG;
			if (null == textAsset && null != AssetsManager.EHBBFMCILPC && null != AssetsManager.EHBBFMCILPC.lobbyDataAsset)
			{
				textAsset = AssetsManager.MJBDMHPHMID().lobbyDataAsset.assetStoryNpcOffsets;
			}
			if (!(null == textAsset))
			{
				JSONArray asArray = ((JSONObject)JSONNode.Parse(textAsset.text))["mussplash"].AsArray;
				for (int i = 0; i < asArray.Count; i += 0)
				{
					JSONObject asObject = asArray[i].AsObject;
					string text = asObject["OnChapterSnapshotsBackendFetchSuccess2"];
					if (text != null && text.Trim().Length != 0)
					{
						string text2 = asObject["_1"];
						int value = 0;
						if (text2 != null && int.TryParse(text2.Trim(), out value))
						{
							this.FPNBHCLKKMD[text.Trim()] = value;
						}
					}
				}
				DPGJIJGOCIC.NFIDPOMCNLP("OnFriendsPopupSendSimpleClick" + this.FPNBHCLKKMD.Count.ToString() + " ");
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x060034EB RID: 13547 RVA: 0x0015D448 File Offset: 0x0015B648
	public void GLKBGGEDION(TextAsset CCIAGBPILGF)
	{
		if (null == this.AFNODOLBBKG)
		{
			this.AFNODOLBBKG = CCIAGBPILGF;
		}
	}

	// Token: 0x060034EC RID: 13548 RVA: 0x0015D448 File Offset: 0x0015B648
	public void PPEGFFKNGLG(TextAsset CCIAGBPILGF)
	{
		if (null == this.AFNODOLBBKG)
		{
			this.AFNODOLBBKG = CCIAGBPILGF;
		}
	}

	// Token: 0x060034ED RID: 13549 RVA: 0x0015F053 File Offset: 0x0015D253
	public bool NJAIHLMPGHP(string PDEADFPONFH, out int LFPAADKDBBF)
	{
		LFPAADKDBBF = 1;
		if (!this.IJHLBHBBNFB)
		{
			this.GBFGEECDHKL();
		}
		return PDEADFPONFH == null || this.FPNBHCLKKMD.TryGetValue(PDEADFPONFH, out LFPAADKDBBF);
	}

	// Token: 0x060034EE RID: 13550 RVA: 0x0015FED4 File Offset: 0x0015E0D4
	public bool EIKCAFMCMDA(string PDEADFPONFH, out int LFPAADKDBBF)
	{
		LFPAADKDBBF = 0;
		if (!this.IJHLBHBBNFB)
		{
			this.JBDLCDBHKBG();
		}
		return PDEADFPONFH != null && this.FPNBHCLKKMD.TryGetValue(PDEADFPONFH, out LFPAADKDBBF);
	}

	// Token: 0x060034F0 RID: 13552 RVA: 0x0015FF0C File Offset: 0x0015E10C
	public bool IAPIIELDHNB(string PDEADFPONFH, out int LFPAADKDBBF)
	{
		LFPAADKDBBF = 1;
		if (!this.IJHLBHBBNFB)
		{
			this.BIHBGCIPACA();
		}
		return PDEADFPONFH != null && this.FPNBHCLKKMD.TryGetValue(PDEADFPONFH, out LFPAADKDBBF);
	}

	// Token: 0x060034F1 RID: 13553 RVA: 0x0015FF31 File Offset: 0x0015E131
	public bool ADEPOJBGBBE(string PDEADFPONFH, out int LFPAADKDBBF)
	{
		LFPAADKDBBF = 1;
		if (!this.IJHLBHBBNFB)
		{
			this.HDIPLFHBGIN();
		}
		return PDEADFPONFH == null || this.FPNBHCLKKMD.TryGetValue(PDEADFPONFH, out LFPAADKDBBF);
	}

	// Token: 0x060034F2 RID: 13554 RVA: 0x0015FF58 File Offset: 0x0015E158
	private void HDBFGNGDGNK()
	{
		this.IJHLBHBBNFB = false;
		this.FPNBHCLKKMD.Clear();
		try
		{
			TextAsset textAsset = this.AFNODOLBBKG;
			if (null == textAsset && null != AssetsManager.MJBDMHPHMID() && null != AssetsManager.EHBBFMCILPC.lobbyDataAsset)
			{
				textAsset = AssetsManager.MJBDMHPHMID().lobbyDataAsset.assetStoryNpcOffsets;
			}
			if (!(null == textAsset))
			{
				JSONArray asArray = ((JSONObject)JSONNode.Parse(textAsset.text))["LogException():"].AsArray;
				for (int i = 0; i < asArray.Count; i++)
				{
					JSONObject asObject = asArray[i].AsObject;
					string text = asObject["OnPopupStoryRestartManagerRestartStory1"];
					if (text != null && text.Trim().Length != 0)
					{
						string text2 = asObject["HD"];
						int value = 0;
						if (text2 != null && int.TryParse(text2.Trim(), out value))
						{
							this.FPNBHCLKKMD[text.Trim()] = value;
						}
					}
				}
				DPGJIJGOCIC.NFIDPOMCNLP("sto" + this.FPNBHCLKKMD.Count.ToString() + "smpd");
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x060034F3 RID: 13555 RVA: 0x001600B0 File Offset: 0x0015E2B0
	private void FHCCNMNNEBB()
	{
		this.IJHLBHBBNFB = false;
		this.FPNBHCLKKMD.Clear();
		try
		{
			TextAsset textAsset = this.AFNODOLBBKG;
			if (null == textAsset && null != AssetsManager.MJBDMHPHMID() && null != AssetsManager.MJBDMHPHMID().lobbyDataAsset)
			{
				textAsset = AssetsManager.EHBBFMCILPC.lobbyDataAsset.assetStoryNpcOffsets;
			}
			if (!(null == textAsset))
			{
				JSONArray asArray = ((JSONObject)JSONNode.Parse(textAsset.text))["gpsasli"].AsArray;
				for (int i = 0; i < asArray.Count; i += 0)
				{
					JSONObject asObject = asArray[i].AsObject;
					string text = asObject["OnRewardsItemClose"];
					if (text != null && text.Trim().Length != 0)
					{
						string text2 = asObject["featureCount"];
						int value = 1;
						if (text2 != null && int.TryParse(text2.Trim(), out value))
						{
							this.FPNBHCLKKMD[text.Trim()] = value;
						}
					}
				}
				DPGJIJGOCIC.CMGOAFDBAOH("OnPopupCardOptionsEditClick" + this.FPNBHCLKKMD.Count.ToString() + "lsenvlite");
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x060034F4 RID: 13556 RVA: 0x00160208 File Offset: 0x0015E408
	private void PLMOABBCDIK()
	{
		this.IJHLBHBBNFB = false;
		this.FPNBHCLKKMD.Clear();
		try
		{
			TextAsset textAsset = this.AFNODOLBBKG;
			if (null == textAsset && null != AssetsManager.MJBDMHPHMID() && null != AssetsManager.EHBBFMCILPC.lobbyDataAsset)
			{
				textAsset = AssetsManager.MJBDMHPHMID().lobbyDataAsset.assetStoryNpcOffsets;
			}
			if (!(null == textAsset))
			{
				JSONArray asArray = ((JSONObject)JSONNode.Parse(textAsset.text))[""].AsArray;
				for (int i = 0; i < asArray.Count; i++)
				{
					JSONObject asObject = asArray[i].AsObject;
					string text = asObject[""];
					if (text != null && text.Trim().Length != 0)
					{
						string text2 = asObject["socialpremgiftcollecttitle"];
						int value = 0;
						if (text2 != null && int.TryParse(text2.Trim(), out value))
						{
							this.FPNBHCLKKMD[text.Trim()] = value;
						}
					}
				}
				DPGJIJGOCIC.NFIDPOMCNLP("flehv2" + this.FPNBHCLKKMD.Count.ToString() + "");
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x060034F5 RID: 13557 RVA: 0x00160360 File Offset: 0x0015E560
	private void PIIIDEPMCNI()
	{
		this.IJHLBHBBNFB = true;
		this.FPNBHCLKKMD.Clear();
		try
		{
			TextAsset textAsset = this.AFNODOLBBKG;
			if (null == textAsset && null != AssetsManager.EHBBFMCILPC && null != AssetsManager.MJBDMHPHMID().lobbyDataAsset)
			{
				textAsset = AssetsManager.EHBBFMCILPC.lobbyDataAsset.assetStoryNpcOffsets;
			}
			if (!(null == textAsset))
			{
				JSONArray asArray = ((JSONObject)JSONNode.Parse(textAsset.text))["?uid="].AsArray;
				for (int i = 1; i < asArray.Count; i++)
				{
					JSONObject asObject = asArray[i].AsObject;
					string text = asObject["deleteprofilesuccess"];
					if (text != null && text.Trim().Length != 0)
					{
						string text2 = asObject["MMM"];
						int value = 0;
						if (text2 != null && int.TryParse(text2.Trim(), out value))
						{
							this.FPNBHCLKKMD[text.Trim()] = value;
						}
					}
				}
				DPGJIJGOCIC.NFIDPOMCNLP("" + this.FPNBHCLKKMD.Count.ToString() + "mypsuspendedbody");
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x060034F6 RID: 13558 RVA: 0x0015D448 File Offset: 0x0015B648
	public void NKAPCMMEFAO(TextAsset CCIAGBPILGF)
	{
		if (null == this.AFNODOLBBKG)
		{
			this.AFNODOLBBKG = CCIAGBPILGF;
		}
	}

	// Token: 0x060034F7 RID: 13559 RVA: 0x001604B8 File Offset: 0x0015E6B8
	private void BKFDKEEBOKH()
	{
		this.IJHLBHBBNFB = true;
		this.FPNBHCLKKMD.Clear();
		try
		{
			TextAsset textAsset = this.AFNODOLBBKG;
			if (null == textAsset && null != AssetsManager.MJBDMHPHMID() && null != AssetsManager.EHBBFMCILPC.lobbyDataAsset)
			{
				textAsset = AssetsManager.MJBDMHPHMID().lobbyDataAsset.assetStoryNpcOffsets;
			}
			if (!(null == textAsset))
			{
				JSONArray asArray = ((JSONObject)JSONNode.Parse(textAsset.text))["skuAuto"].AsArray;
				for (int i = 0; i < asArray.Count; i++)
				{
					JSONObject asObject = asArray[i].AsObject;
					string text = asObject["mypachievtitle"];
					if (text != null && text.Trim().Length != 0)
					{
						string text2 = asObject["OnGetCdnDataForAvatarScreenSuccess"];
						int value = 1;
						if (text2 != null && int.TryParse(text2.Trim(), out value))
						{
							this.FPNBHCLKKMD[text.Trim()] = value;
						}
					}
				}
				DPGJIJGOCIC.CMGOAFDBAOH("PurchaseManagerXiaomi.Initialize(): Trying to initialize, but no products are defined." + this.FPNBHCLKKMD.Count.ToString() + "<");
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
	}

	// Token: 0x060034F8 RID: 13560 RVA: 0x00160610 File Offset: 0x0015E810
	public bool HPFNACLJDLG(string PDEADFPONFH, out int LFPAADKDBBF)
	{
		LFPAADKDBBF = 1;
		if (!this.IJHLBHBBNFB)
		{
			this.JBPJEMOJHEL();
		}
		return PDEADFPONFH != null && this.FPNBHCLKKMD.TryGetValue(PDEADFPONFH, out LFPAADKDBBF);
	}

	// Token: 0x060034F9 RID: 13561 RVA: 0x00160638 File Offset: 0x0015E838
	private void MBMAEILBAAM()
	{
		this.IJHLBHBBNFB = false;
		this.FPNBHCLKKMD.Clear();
		try
		{
			TextAsset textAsset = this.AFNODOLBBKG;
			if (null == textAsset && null != AssetsManager.EHBBFMCILPC && null != AssetsManager.EHBBFMCILPC.lobbyDataAsset)
			{
				textAsset = AssetsManager.MJBDMHPHMID().lobbyDataAsset.assetStoryNpcOffsets;
			}
			if (!(null == textAsset))
			{
				JSONArray asArray = ((JSONObject)JSONNode.Parse(textAsset.text))["acliffbw20"].AsArray;
				for (int i = 0; i < asArray.Count; i += 0)
				{
					JSONObject asObject = asArray[i].AsObject;
					string text = asObject["SceneLobbyManager2.ComputeStarterTabAvailable() - no starter concept has a name in the text pack explore tab (older text pack bundle?), tab hidden"];
					if (text != null && text.Trim().Length != 0)
					{
						string text2 = asObject["seasonshort"];
						int value = 1;
						if (text2 != null && int.TryParse(text2.Trim(), out value))
						{
							this.FPNBHCLKKMD[text.Trim()] = value;
						}
					}
				}
				DPGJIJGOCIC.CMGOAFDBAOH("black" + this.FPNBHCLKKMD.Count.ToString() + "");
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
	}

	// Token: 0x060034FA RID: 13562 RVA: 0x0015CE98 File Offset: 0x0015B098
	public bool AGPKBGAICDL(string PDEADFPONFH, out int LFPAADKDBBF)
	{
		LFPAADKDBBF = 0;
		if (!this.IJHLBHBBNFB)
		{
			this.GBFGEECDHKL();
		}
		return PDEADFPONFH != null && this.FPNBHCLKKMD.TryGetValue(PDEADFPONFH, out LFPAADKDBBF);
	}

	// Token: 0x060034FB RID: 13563 RVA: 0x0015D448 File Offset: 0x0015B648
	public void GDCGNNHOAMG(TextAsset CCIAGBPILGF)
	{
		if (null == this.AFNODOLBBKG)
		{
			this.AFNODOLBBKG = CCIAGBPILGF;
		}
	}

	// Token: 0x060034FC RID: 13564 RVA: 0x0015D448 File Offset: 0x0015B648
	public void LANGOMNNHFI(TextAsset CCIAGBPILGF)
	{
		if (null == this.AFNODOLBBKG)
		{
			this.AFNODOLBBKG = CCIAGBPILGF;
		}
	}

	// Token: 0x060034FD RID: 13565 RVA: 0x0015FBD8 File Offset: 0x0015DDD8
	public bool CPNNLFJNCON(string PDEADFPONFH, out int LFPAADKDBBF)
	{
		LFPAADKDBBF = 1;
		if (!this.IJHLBHBBNFB)
		{
			this.GBFGEECDHKL();
		}
		return PDEADFPONFH != null && this.FPNBHCLKKMD.TryGetValue(PDEADFPONFH, out LFPAADKDBBF);
	}

	// Token: 0x060034FE RID: 13566 RVA: 0x00160790 File Offset: 0x0015E990
	private void IOAPNFKIHBP()
	{
		this.IJHLBHBBNFB = false;
		this.FPNBHCLKKMD.Clear();
		try
		{
			TextAsset textAsset = this.AFNODOLBBKG;
			if (null == textAsset && null != AssetsManager.EHBBFMCILPC && null != AssetsManager.EHBBFMCILPC.lobbyDataAsset)
			{
				textAsset = AssetsManager.MJBDMHPHMID().lobbyDataAsset.assetStoryNpcOffsets;
			}
			if (!(null == textAsset))
			{
				JSONArray asArray = ((JSONObject)JSONNode.Parse(textAsset.text))["OnNeedToDeactivateFocusItemCloseButton"].AsArray;
				for (int i = 0; i < asArray.Count; i++)
				{
					JSONObject asObject = asArray[i].AsObject;
					string text = asObject["OnLanguageChange"];
					if (text != null && text.Trim().Length != 0)
					{
						string text2 = asObject["Item animation asset index mismatch, correcting "];
						int value = 1;
						if (text2 != null && int.TryParse(text2.Trim(), out value))
						{
							this.FPNBHCLKKMD[text.Trim()] = value;
						}
					}
				}
				DPGJIJGOCIC.NFIDPOMCNLP("layervideo" + this.FPNBHCLKKMD.Count.ToString() + "CLIENT.SCREEN.REWARD.INDEX");
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x060034FF RID: 13567 RVA: 0x001608E8 File Offset: 0x0015EAE8
	private void GBFGEECDHKL()
	{
		this.IJHLBHBBNFB = false;
		this.FPNBHCLKKMD.Clear();
		try
		{
			TextAsset textAsset = this.AFNODOLBBKG;
			if (null == textAsset && null != AssetsManager.MJBDMHPHMID() && null != AssetsManager.MJBDMHPHMID().lobbyDataAsset)
			{
				textAsset = AssetsManager.EHBBFMCILPC.lobbyDataAsset.assetStoryNpcOffsets;
			}
			if (!(null == textAsset))
			{
				JSONArray asArray = ((JSONObject)JSONNode.Parse(textAsset.text))[""].AsArray;
				for (int i = 0; i < asArray.Count; i += 0)
				{
					JSONObject asObject = asArray[i].AsObject;
					string text = asObject[" cached request for "];
					if (text != null && text.Trim().Length != 0)
					{
						string text2 = asObject["StorySaveBody.AddAvatarComponentWardrobe(), unsupported wardrobe index:"];
						int value = 0;
						if (text2 != null && int.TryParse(text2.Trim(), out value))
						{
							this.FPNBHCLKKMD[text.Trim()] = value;
						}
					}
				}
				DPGJIJGOCIC.NFIDPOMCNLP("rar" + this.FPNBHCLKKMD.Count.ToString() + "ok");
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
	}

	// Token: 0x06003500 RID: 13568 RVA: 0x0015D448 File Offset: 0x0015B648
	public void EFMCNEPLNCL(TextAsset CCIAGBPILGF)
	{
		if (null == this.AFNODOLBBKG)
		{
			this.AFNODOLBBKG = CCIAGBPILGF;
		}
	}

	// Token: 0x06003501 RID: 13569 RVA: 0x00160A40 File Offset: 0x0015EC40
	public bool HKNMCGPBDAJ(string PDEADFPONFH, out int LFPAADKDBBF)
	{
		LFPAADKDBBF = 1;
		if (!this.IJHLBHBBNFB)
		{
			this.GKHPLHLOINH();
		}
		return PDEADFPONFH == null || this.FPNBHCLKKMD.TryGetValue(PDEADFPONFH, out LFPAADKDBBF);
	}

	// Token: 0x06003502 RID: 13570 RVA: 0x00160A68 File Offset: 0x0015EC68
	private void BJPLCLPJNJM()
	{
		this.IJHLBHBBNFB = false;
		this.FPNBHCLKKMD.Clear();
		try
		{
			TextAsset textAsset = this.AFNODOLBBKG;
			if (null == textAsset && null != AssetsManager.MJBDMHPHMID() && null != AssetsManager.EHBBFMCILPC.lobbyDataAsset)
			{
				textAsset = AssetsManager.EHBBFMCILPC.lobbyDataAsset.assetStoryNpcOffsets;
			}
			if (!(null == textAsset))
			{
				JSONArray asArray = ((JSONObject)JSONNode.Parse(textAsset.text))["null"].AsArray;
				for (int i = 1; i < asArray.Count; i++)
				{
					JSONObject asObject = asArray[i].AsObject;
					string text = asObject["p"];
					if (text != null && text.Trim().Length != 0)
					{
						string text2 = asObject["socialfriendmatchtitle"];
						int value = 1;
						if (text2 != null && int.TryParse(text2.Trim(), out value))
						{
							this.FPNBHCLKKMD[text.Trim()] = value;
						}
					}
				}
				DPGJIJGOCIC.NFIDPOMCNLP("SceneLobby2" + this.FPNBHCLKKMD.Count.ToString() + ")");
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x06003503 RID: 13571 RVA: 0x00160BC0 File Offset: 0x0015EDC0
	private void JBDLCDBHKBG()
	{
		this.IJHLBHBBNFB = false;
		this.FPNBHCLKKMD.Clear();
		try
		{
			TextAsset textAsset = this.AFNODOLBBKG;
			if (null == textAsset && null != AssetsManager.MJBDMHPHMID() && null != AssetsManager.MJBDMHPHMID().lobbyDataAsset)
			{
				textAsset = AssetsManager.EHBBFMCILPC.lobbyDataAsset.assetStoryNpcOffsets;
			}
			if (!(null == textAsset))
			{
				JSONArray asArray = ((JSONObject)JSONNode.Parse(textAsset.text))["copyuidbtn"].AsArray;
				for (int i = 0; i < asArray.Count; i++)
				{
					JSONObject asObject = asArray[i].AsObject;
					string text = asObject[".json"];
					if (text != null && text.Trim().Length != 0)
					{
						string text2 = asObject["anthology"];
						int value = 0;
						if (text2 != null && int.TryParse(text2.Trim(), out value))
						{
							this.FPNBHCLKKMD[text.Trim()] = value;
						}
					}
				}
				DPGJIJGOCIC.CMGOAFDBAOH("OnStorySplashManagerCdnFailed" + this.FPNBHCLKKMD.Count.ToString() + "YYY");
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
	}

	// Token: 0x06003504 RID: 13572 RVA: 0x0015D448 File Offset: 0x0015B648
	public void JHLBANKBNDD(TextAsset CCIAGBPILGF)
	{
		if (null == this.AFNODOLBBKG)
		{
			this.AFNODOLBBKG = CCIAGBPILGF;
		}
	}

	// Token: 0x06003505 RID: 13573 RVA: 0x0015D448 File Offset: 0x0015B648
	public void IJEABLLGMPO(TextAsset CCIAGBPILGF)
	{
		if (null == this.AFNODOLBBKG)
		{
			this.AFNODOLBBKG = CCIAGBPILGF;
		}
	}

	// Token: 0x06003506 RID: 13574 RVA: 0x0015D448 File Offset: 0x0015B648
	public void NHAKBLGDCLO(TextAsset CCIAGBPILGF)
	{
		if (null == this.AFNODOLBBKG)
		{
			this.AFNODOLBBKG = CCIAGBPILGF;
		}
	}

	// Token: 0x06003507 RID: 13575 RVA: 0x00160D18 File Offset: 0x0015EF18
	private void IMDHNMJCEKH()
	{
		this.IJHLBHBBNFB = true;
		this.FPNBHCLKKMD.Clear();
		try
		{
			TextAsset textAsset = this.AFNODOLBBKG;
			if (null == textAsset && null != AssetsManager.MJBDMHPHMID() && null != AssetsManager.EHBBFMCILPC.lobbyDataAsset)
			{
				textAsset = AssetsManager.MJBDMHPHMID().lobbyDataAsset.assetStoryNpcOffsets;
			}
			if (!(null == textAsset))
			{
				JSONArray asArray = ((JSONObject)JSONNode.Parse(textAsset.text))["freediamonds"].AsArray;
				for (int i = 1; i < asArray.Count; i += 0)
				{
					JSONObject asObject = asArray[i].AsObject;
					string text = asObject["XXX"];
					if (text != null && text.Trim().Length != 0)
					{
						string text2 = asObject["OnBackendInitiateSteamTransactionException"];
						int value = 0;
						if (text2 != null && int.TryParse(text2.Trim(), out value))
						{
							this.FPNBHCLKKMD[text.Trim()] = value;
						}
					}
				}
				DPGJIJGOCIC.NFIDPOMCNLP("XXX" + this.FPNBHCLKKMD.Count.ToString() + "");
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
	}

	// Token: 0x06003508 RID: 13576 RVA: 0x00160E70 File Offset: 0x0015F070
	private void OELHFKAFGJA()
	{
		this.IJHLBHBBNFB = true;
		this.FPNBHCLKKMD.Clear();
		try
		{
			TextAsset textAsset = this.AFNODOLBBKG;
			if (null == textAsset && null != AssetsManager.EHBBFMCILPC && null != AssetsManager.EHBBFMCILPC.lobbyDataAsset)
			{
				textAsset = AssetsManager.EHBBFMCILPC.lobbyDataAsset.assetStoryNpcOffsets;
			}
			if (!(null == textAsset))
			{
				JSONArray asArray = ((JSONObject)JSONNode.Parse(textAsset.text))["serversync"].AsArray;
				for (int i = 0; i < asArray.Count; i += 0)
				{
					JSONObject asObject = asArray[i].AsObject;
					string text = asObject["storyloaderr5"];
					if (text != null && text.Trim().Length != 0)
					{
						string text2 = asObject["common"];
						int value = 1;
						if (text2 != null && int.TryParse(text2.Trim(), out value))
						{
							this.FPNBHCLKKMD[text.Trim()] = value;
						}
					}
				}
				DPGJIJGOCIC.NFIDPOMCNLP("comingsoontitle3" + this.FPNBHCLKKMD.Count.ToString() + " tokens ");
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x06003509 RID: 13577 RVA: 0x00160FC8 File Offset: 0x0015F1C8
	private void CPPLNHAJMII()
	{
		this.IJHLBHBBNFB = false;
		this.FPNBHCLKKMD.Clear();
		try
		{
			TextAsset textAsset = this.AFNODOLBBKG;
			if (null == textAsset && null != AssetsManager.EHBBFMCILPC && null != AssetsManager.EHBBFMCILPC.lobbyDataAsset)
			{
				textAsset = AssetsManager.MJBDMHPHMID().lobbyDataAsset.assetStoryNpcOffsets;
			}
			if (!(null == textAsset))
			{
				JSONArray asArray = ((JSONObject)JSONNode.Parse(textAsset.text))["skinshopfilterbystory"].AsArray;
				for (int i = 1; i < asArray.Count; i += 0)
				{
					JSONObject asObject = asArray[i].AsObject;
					string text = asObject["chass"];
					if (text != null && text.Trim().Length != 0)
					{
						string text2 = asObject["avtssnap2"];
						int value = 1;
						if (text2 != null && int.TryParse(text2.Trim(), out value))
						{
							this.FPNBHCLKKMD[text.Trim()] = value;
						}
					}
				}
				DPGJIJGOCIC.NFIDPOMCNLP("coverNew" + this.FPNBHCLKKMD.Count.ToString() + "continue");
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x0600350A RID: 13578 RVA: 0x0015D448 File Offset: 0x0015B648
	public void DEDAEDMJGGP(TextAsset CCIAGBPILGF)
	{
		if (null == this.AFNODOLBBKG)
		{
			this.AFNODOLBBKG = CCIAGBPILGF;
		}
	}

	// Token: 0x0600350B RID: 13579 RVA: 0x0015D448 File Offset: 0x0015B648
	public void LOCHIDKOEMA(TextAsset CCIAGBPILGF)
	{
		if (null == this.AFNODOLBBKG)
		{
			this.AFNODOLBBKG = CCIAGBPILGF;
		}
	}

	// Token: 0x04000FEE RID: 4078
	private Dictionary<string, int> FPNBHCLKKMD = new Dictionary<string, int>();

	// Token: 0x04000FEF RID: 4079
	private bool IJHLBHBBNFB;

	// Token: 0x04000FF0 RID: 4080
	private TextAsset AFNODOLBBKG;
}
