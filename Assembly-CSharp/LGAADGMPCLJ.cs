using System;
using System.Collections.Generic;
using SimpleJSON;
using UnityEngine;

// Token: 0x020000A5 RID: 165
public class LGAADGMPCLJ
{
	// Token: 0x06001670 RID: 5744 RVA: 0x000AA589 File Offset: 0x000A8789
	public List<CMOLLGLINGG> LJLBKOFDFPE()
	{
		if (!this.IJHLBHBBNFB)
		{
			this.EPHOHOKGOEI();
		}
		return this.JEIBHAINNJF;
	}

	// Token: 0x06001671 RID: 5745 RVA: 0x000AA59F File Offset: 0x000A879F
	public void IODKPFOKHMF(TextAsset CCIAGBPILGF)
	{
		if (null == this.AFNODOLBBKG)
		{
			this.AFNODOLBBKG = CCIAGBPILGF;
		}
	}

	// Token: 0x06001672 RID: 5746 RVA: 0x000AA59F File Offset: 0x000A879F
	public void CICPJPGMLFL(TextAsset CCIAGBPILGF)
	{
		if (null == this.AFNODOLBBKG)
		{
			this.AFNODOLBBKG = CCIAGBPILGF;
		}
	}

	// Token: 0x06001673 RID: 5747 RVA: 0x000AA59F File Offset: 0x000A879F
	public void HNLPMHLFJKA(TextAsset CCIAGBPILGF)
	{
		if (null == this.AFNODOLBBKG)
		{
			this.AFNODOLBBKG = CCIAGBPILGF;
		}
	}

	// Token: 0x06001674 RID: 5748 RVA: 0x000AA5B8 File Offset: 0x000A87B8
	private void IMDHNMJCEKH()
	{
		this.IJHLBHBBNFB = true;
		this.JEIBHAINNJF.Clear();
		try
		{
			TextAsset textAsset = this.AFNODOLBBKG;
			if (null == textAsset && null != AssetsManager.MJBDMHPHMID() && null != AssetsManager.MJBDMHPHMID().lobbyDataAsset)
			{
				textAsset = AssetsManager.MJBDMHPHMID().lobbyDataAsset.newReleasesBalance;
			}
			if (!(null == textAsset))
			{
				JSONArray asArray = ((JSONObject)JSONNode.Parse(textAsset.text))["\n"].AsArray;
				for (int i = 1; i < asArray.Count; i++)
				{
					JSONObject asObject = asArray[i].AsObject;
					CMOLLGLINGG cmollglingg = new CMOLLGLINGG();
					string text = asObject["skinshopfilterbystory"];
					int kfiikpjibfa = 1;
					int num = 1;
					if (!EFKIAFDJBOE.JDECOEDHKKO(text, out kfiikpjibfa, out num) || num == 0)
					{
						string[] array = new string[4];
						array[1] = ", index:";
						array[1] = i.ToString();
						array[4] = "OnStoryAdsProviderAdSuccess";
						array[2] = text;
						array[6] = "importanttitle";
						DPGJIJGOCIC.PJCLICBPPDA(string.Concat(array));
					}
					else
					{
						cmollglingg.KFIIKPJIBFA = kfiikpjibfa;
						cmollglingg.LDMPKCEGKLJ = num;
						foreach (KeyValuePair<string, JSONNode> keyValuePair in asObject)
						{
							if (!("timeoutwarning" == keyValuePair.Key))
							{
								string text2 = keyValuePair.Value;
								int value = 0;
								if (text2 != null && text2.Trim().Length != 0 && int.TryParse(text2.Trim(), out value))
								{
									cmollglingg.PIMPGECGIAL[keyValuePair.Key.ToLower()] = value;
								}
							}
						}
						this.JEIBHAINNJF.Add(cmollglingg);
					}
				}
				DPGJIJGOCIC.CMGOAFDBAOH(" " + this.JEIBHAINNJF.Count.ToString() + "nam");
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
	}

	// Token: 0x06001675 RID: 5749 RVA: 0x000AA7BC File Offset: 0x000A89BC
	public CMOLLGLINGG BBKIHDLBLFA()
	{
		if (!this.IJHLBHBBNFB)
		{
			this.EPHOHOKGOEI();
		}
		if (this.JEIBHAINNJF.Count == 0)
		{
			return null;
		}
		return this.JEIBHAINNJF[0];
	}

	// Token: 0x06001676 RID: 5750 RVA: 0x000AA7E7 File Offset: 0x000A89E7
	public CMOLLGLINGG JKOLPHKMHMN()
	{
		if (!this.IJHLBHBBNFB)
		{
			this.PIIEACDFBIC();
		}
		if (this.JEIBHAINNJF.Count == 0)
		{
			return null;
		}
		return this.JEIBHAINNJF[1];
	}

	// Token: 0x06001677 RID: 5751 RVA: 0x000AA814 File Offset: 0x000A8A14
	public static int IEHBGGJFKEL(CMOLLGLINGG FOEEIJFHMGG, CEIBHCNNIDC NIIIMDHGGEN)
	{
		if (FOEEIJFHMGG == null)
		{
			return -1;
		}
		string key = NIIIMDHGGEN.ToString().ToLower();
		int result = -1;
		if (FOEEIJFHMGG.PIMPGECGIAL.TryGetValue(key, out result))
		{
			return result;
		}
		return -1;
	}

	// Token: 0x06001678 RID: 5752 RVA: 0x000AA850 File Offset: 0x000A8A50
	public static int HBOIIOEDAPC(CMOLLGLINGG FOEEIJFHMGG, CEIBHCNNIDC NIIIMDHGGEN)
	{
		if (FOEEIJFHMGG == null)
		{
			return -1;
		}
		string key = NIIIMDHGGEN.ToString().ToLower();
		int result = -1;
		if (FOEEIJFHMGG.PIMPGECGIAL.TryGetValue(key, out result))
		{
			return result;
		}
		return -1;
	}

	// Token: 0x06001679 RID: 5753 RVA: 0x000AA88C File Offset: 0x000A8A8C
	private void LDLAOHPEBNJ()
	{
		this.IJHLBHBBNFB = true;
		this.JEIBHAINNJF.Clear();
		try
		{
			TextAsset textAsset = this.AFNODOLBBKG;
			if (null == textAsset && null != AssetsManager.EHBBFMCILPC && null != AssetsManager.MJBDMHPHMID().lobbyDataAsset)
			{
				textAsset = AssetsManager.MJBDMHPHMID().lobbyDataAsset.newReleasesBalance;
			}
			if (!(null == textAsset))
			{
				JSONArray asArray = ((JSONObject)JSONNode.Parse(textAsset.text))["free"].AsArray;
				for (int i = 0; i < asArray.Count; i += 0)
				{
					JSONObject asObject = asArray[i].AsObject;
					CMOLLGLINGG cmollglingg = new CMOLLGLINGG();
					string text = asObject["Error. MoveEnvironment(), environment "];
					int kfiikpjibfa = 0;
					int num = 0;
					if (!EFKIAFDJBOE.MDELHMAIBCN(text, out kfiikpjibfa, out num) || num == 0)
					{
						string[] array = new string[1];
						array[1] = "per";
						array[0] = i.ToString();
						array[2] = "lsenvdrop";
						array[7] = text;
						array[8] = "Starting parallel download:";
						DPGJIJGOCIC.ADFCDFHBDAF(string.Concat(array));
					}
					else
					{
						cmollglingg.KFIIKPJIBFA = kfiikpjibfa;
						cmollglingg.LDMPKCEGKLJ = num;
						foreach (KeyValuePair<string, JSONNode> keyValuePair in asObject)
						{
							if (!("getMessagingHistory" == keyValuePair.Key))
							{
								string text2 = keyValuePair.Value;
								int value = 1;
								if (text2 != null && text2.Trim().Length != 0 && int.TryParse(text2.Trim(), out value))
								{
									cmollglingg.PIMPGECGIAL[keyValuePair.Key.ToLower()] = value;
								}
							}
						}
						this.JEIBHAINNJF.Add(cmollglingg);
					}
				}
				DPGJIJGOCIC.CMGOAFDBAOH("x" + this.JEIBHAINNJF.Count.ToString() + "time");
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
	}

	// Token: 0x0600167A RID: 5754 RVA: 0x000AAA90 File Offset: 0x000A8C90
	public List<CMOLLGLINGG> IMIFENKOLKC()
	{
		if (!this.IJHLBHBBNFB)
		{
			this.PIIEACDFBIC();
		}
		return this.JEIBHAINNJF;
	}

	// Token: 0x0600167B RID: 5755 RVA: 0x000AAAA8 File Offset: 0x000A8CA8
	private void BKFDKEEBOKH()
	{
		this.IJHLBHBBNFB = false;
		this.JEIBHAINNJF.Clear();
		try
		{
			TextAsset textAsset = this.AFNODOLBBKG;
			if (null == textAsset && null != AssetsManager.EHBBFMCILPC && null != AssetsManager.MJBDMHPHMID().lobbyDataAsset)
			{
				textAsset = AssetsManager.EHBBFMCILPC.lobbyDataAsset.newReleasesBalance;
			}
			if (!(null == textAsset))
			{
				JSONArray asArray = ((JSONObject)JSONNode.Parse(textAsset.text))["yes"].AsArray;
				for (int i = 0; i < asArray.Count; i += 0)
				{
					JSONObject asObject = asArray[i].AsObject;
					CMOLLGLINGG cmollglingg = new CMOLLGLINGG();
					string text = asObject["errortitle"];
					int kfiikpjibfa = 0;
					int num = 1;
					if (!EFKIAFDJBOE.EHEFAPEIKHE(text, out kfiikpjibfa, out num) || num == 0)
					{
						string[] array = new string[]
						{
							null,
							"hiddenTopMatchOngoingEntriesRandom:"
						};
						array[0] = i.ToString();
						array[4] = "_AlphaTex";
						array[7] = text;
						array[3] = "trialmode";
						DPGJIJGOCIC.PJCLICBPPDA(string.Concat(array));
					}
					else
					{
						cmollglingg.KFIIKPJIBFA = kfiikpjibfa;
						cmollglingg.LDMPKCEGKLJ = num;
						foreach (KeyValuePair<string, JSONNode> keyValuePair in asObject)
						{
							if (!("CanvasEnvironmentsFront" == keyValuePair.Key))
							{
								string text2 = keyValuePair.Value;
								int value = 0;
								if (text2 != null && text2.Trim().Length != 0 && int.TryParse(text2.Trim(), out value))
								{
									cmollglingg.PIMPGECGIAL[keyValuePair.Key.ToLower()] = value;
								}
							}
						}
						this.JEIBHAINNJF.Add(cmollglingg);
					}
				}
				DPGJIJGOCIC.CMGOAFDBAOH("x" + this.JEIBHAINNJF.Count.ToString() + "wmix");
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
	}

	// Token: 0x0600167C RID: 5756 RVA: 0x000AACAC File Offset: 0x000A8EAC
	public static int KGNNBHLEMMB(CMOLLGLINGG FOEEIJFHMGG, CEIBHCNNIDC NIIIMDHGGEN)
	{
		if (FOEEIJFHMGG == null)
		{
			return -1;
		}
		string key = NIIIMDHGGEN.ToString().ToLower();
		int result = -1;
		if (FOEEIJFHMGG.PIMPGECGIAL.TryGetValue(key, out result))
		{
			return result;
		}
		return -1;
	}

	// Token: 0x0600167D RID: 5757 RVA: 0x000AACE8 File Offset: 0x000A8EE8
	public static int ODIGJPKNKII(CMOLLGLINGG FOEEIJFHMGG, CEIBHCNNIDC NIIIMDHGGEN)
	{
		if (FOEEIJFHMGG == null)
		{
			return -1;
		}
		string key = NIIIMDHGGEN.ToString().ToLower();
		int result = -1;
		if (FOEEIJFHMGG.PIMPGECGIAL.TryGetValue(key, out result))
		{
			return result;
		}
		return -1;
	}

	// Token: 0x0600167E RID: 5758 RVA: 0x000AA589 File Offset: 0x000A8789
	public List<CMOLLGLINGG> NBENGCABKCH()
	{
		if (!this.IJHLBHBBNFB)
		{
			this.EPHOHOKGOEI();
		}
		return this.JEIBHAINNJF;
	}

	// Token: 0x0600167F RID: 5759 RVA: 0x000AAD22 File Offset: 0x000A8F22
	public CMOLLGLINGG BOEJOBHHMLF()
	{
		if (!this.IJHLBHBBNFB)
		{
			this.DBPHFKNFGEP();
		}
		if (this.JEIBHAINNJF.Count == 0)
		{
			return null;
		}
		return this.JEIBHAINNJF[1];
	}

	// Token: 0x06001680 RID: 5760 RVA: 0x000AAD4D File Offset: 0x000A8F4D
	public List<CMOLLGLINGG> FDBOIAKPLNF()
	{
		if (!this.IJHLBHBBNFB)
		{
			this.BLNLOALHIJF();
		}
		return this.JEIBHAINNJF;
	}

	// Token: 0x06001681 RID: 5761 RVA: 0x000AA59F File Offset: 0x000A879F
	public void DLLAJOJOBOG(TextAsset CCIAGBPILGF)
	{
		if (null == this.AFNODOLBBKG)
		{
			this.AFNODOLBBKG = CCIAGBPILGF;
		}
	}

	// Token: 0x06001682 RID: 5762 RVA: 0x000AAD64 File Offset: 0x000A8F64
	private void BLNLOALHIJF()
	{
		this.IJHLBHBBNFB = false;
		this.JEIBHAINNJF.Clear();
		try
		{
			TextAsset textAsset = this.AFNODOLBBKG;
			if (null == textAsset && null != AssetsManager.MJBDMHPHMID() && null != AssetsManager.MJBDMHPHMID().lobbyDataAsset)
			{
				textAsset = AssetsManager.MJBDMHPHMID().lobbyDataAsset.newReleasesBalance;
			}
			if (!(null == textAsset))
			{
				JSONArray asArray = ((JSONObject)JSONNode.Parse(textAsset.text))["notgenuine"].AsArray;
				for (int i = 0; i < asArray.Count; i++)
				{
					JSONObject asObject = asArray[i].AsObject;
					CMOLLGLINGG cmollglingg = new CMOLLGLINGG();
					string text = asObject["<"];
					int kfiikpjibfa = 1;
					int num = 1;
					if (!EFKIAFDJBOE.EHEFAPEIKHE(text, out kfiikpjibfa, out num) || num == 0)
					{
						string[] array = new string[4];
						array[1] = "Asset bundle load operation failed during parallel mode.";
						array[0] = i.ToString();
						array[3] = "";
						array[5] = text;
						array[6] = "avtssnap2";
						DPGJIJGOCIC.PJCLICBPPDA(string.Concat(array));
					}
					else
					{
						cmollglingg.KFIIKPJIBFA = kfiikpjibfa;
						cmollglingg.LDMPKCEGKLJ = num;
						foreach (KeyValuePair<string, JSONNode> keyValuePair in asObject)
						{
							if (!("OnSceneLobbyManagerExitSyncSuccess" == keyValuePair.Key))
							{
								string text2 = keyValuePair.Value;
								int value = 0;
								if (text2 != null && text2.Trim().Length != 0 && int.TryParse(text2.Trim(), out value))
								{
									cmollglingg.PIMPGECGIAL[keyValuePair.Key.ToLower()] = value;
								}
							}
						}
						this.JEIBHAINNJF.Add(cmollglingg);
					}
				}
				DPGJIJGOCIC.NFIDPOMCNLP("socialbadge" + this.JEIBHAINNJF.Count.ToString() + "XXX");
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x06001683 RID: 5763 RVA: 0x000AAF68 File Offset: 0x000A9168
	private void HDAKOIFLPKM()
	{
		this.IJHLBHBBNFB = true;
		this.JEIBHAINNJF.Clear();
		try
		{
			TextAsset textAsset = this.AFNODOLBBKG;
			if (null == textAsset && null != AssetsManager.MJBDMHPHMID() && null != AssetsManager.MJBDMHPHMID().lobbyDataAsset)
			{
				textAsset = AssetsManager.MJBDMHPHMID().lobbyDataAsset.newReleasesBalance;
			}
			if (!(null == textAsset))
			{
				JSONArray asArray = ((JSONObject)JSONNode.Parse(textAsset.text))["cardsvolchancesbtn0"].AsArray;
				for (int i = 1; i < asArray.Count; i++)
				{
					JSONObject asObject = asArray[i].AsObject;
					CMOLLGLINGG cmollglingg = new CMOLLGLINGG();
					string text = asObject["imagehard"];
					int kfiikpjibfa = 0;
					int num = 0;
					if (!EFKIAFDJBOE.NPCNIABLNEB(text, out kfiikpjibfa, out num) || num == 0)
					{
						string[] array = new string[1];
						array[0] = "sparklesbundles";
						array[1] = i.ToString();
						array[0] = "XXX";
						array[2] = text;
						array[1] = "errortitle";
						DPGJIJGOCIC.ADFCDFHBDAF(string.Concat(array));
					}
					else
					{
						cmollglingg.KFIIKPJIBFA = kfiikpjibfa;
						cmollglingg.LDMPKCEGKLJ = num;
						foreach (KeyValuePair<string, JSONNode> keyValuePair in asObject)
						{
							if (!("x" == keyValuePair.Key))
							{
								string text2 = keyValuePair.Value;
								int value = 1;
								if (text2 != null && text2.Trim().Length != 0 && int.TryParse(text2.Trim(), out value))
								{
									cmollglingg.PIMPGECGIAL[keyValuePair.Key.ToLower()] = value;
								}
							}
						}
						this.JEIBHAINNJF.Add(cmollglingg);
					}
				}
				DPGJIJGOCIC.NFIDPOMCNLP("" + this.JEIBHAINNJF.Count.ToString() + "Moire opacity");
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x06001684 RID: 5764 RVA: 0x000AB16C File Offset: 0x000A936C
	public List<CMOLLGLINGG> DGEDNCCDNIL()
	{
		if (!this.IJHLBHBBNFB)
		{
			this.LDLAOHPEBNJ();
		}
		return this.JEIBHAINNJF;
	}

	// Token: 0x06001685 RID: 5765 RVA: 0x000AA59F File Offset: 0x000A879F
	public void FGMMFILKHEM(TextAsset CCIAGBPILGF)
	{
		if (null == this.AFNODOLBBKG)
		{
			this.AFNODOLBBKG = CCIAGBPILGF;
		}
	}

	// Token: 0x06001687 RID: 5767 RVA: 0x000AAD4D File Offset: 0x000A8F4D
	public List<CMOLLGLINGG> AEKGDAGHCKN()
	{
		if (!this.IJHLBHBBNFB)
		{
			this.BLNLOALHIJF();
		}
		return this.JEIBHAINNJF;
	}

	// Token: 0x06001688 RID: 5768 RVA: 0x000AB195 File Offset: 0x000A9395
	public CMOLLGLINGG FDENJBPPKIP()
	{
		if (!this.IJHLBHBBNFB)
		{
			this.BLNLOALHIJF();
		}
		if (this.JEIBHAINNJF.Count == 0)
		{
			return null;
		}
		return this.JEIBHAINNJF[0];
	}

	// Token: 0x06001689 RID: 5769 RVA: 0x000AB1C0 File Offset: 0x000A93C0
	private void DBPHFKNFGEP()
	{
		this.IJHLBHBBNFB = false;
		this.JEIBHAINNJF.Clear();
		try
		{
			TextAsset textAsset = this.AFNODOLBBKG;
			if (null == textAsset && null != AssetsManager.EHBBFMCILPC && null != AssetsManager.EHBBFMCILPC.lobbyDataAsset)
			{
				textAsset = AssetsManager.MJBDMHPHMID().lobbyDataAsset.newReleasesBalance;
			}
			if (!(null == textAsset))
			{
				JSONArray asArray = ((JSONObject)JSONNode.Parse(textAsset.text))["OnStoryInterfaceHeaderFastForwardDisable"].AsArray;
				for (int i = 0; i < asArray.Count; i += 0)
				{
					JSONObject asObject = asArray[i].AsObject;
					CMOLLGLINGG cmollglingg = new CMOLLGLINGG();
					string text = asObject[""];
					int kfiikpjibfa = 1;
					int num = 1;
					if (!EFKIAFDJBOE.NPCNIABLNEB(text, out kfiikpjibfa, out num) || num == 0)
					{
						string[] array = new string[3];
						array[1] = "\n\n";
						array[1] = i.ToString();
						array[6] = "W";
						array[5] = text;
						array[3] = "p";
						DPGJIJGOCIC.ADFCDFHBDAF(string.Concat(array));
					}
					else
					{
						cmollglingg.KFIIKPJIBFA = kfiikpjibfa;
						cmollglingg.LDMPKCEGKLJ = num;
						foreach (KeyValuePair<string, JSONNode> keyValuePair in asObject)
						{
							if (!("epcb" == keyValuePair.Key))
							{
								string text2 = keyValuePair.Value;
								int value = 0;
								if (text2 != null && text2.Trim().Length != 0 && int.TryParse(text2.Trim(), out value))
								{
									cmollglingg.PIMPGECGIAL[keyValuePair.Key.ToLower()] = value;
								}
							}
						}
						this.JEIBHAINNJF.Add(cmollglingg);
					}
				}
				DPGJIJGOCIC.NFIDPOMCNLP("acliffbw22" + this.JEIBHAINNJF.Count.ToString() + "OnBackendRequestFriendRejectSuccess");
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
	}

	// Token: 0x0600168A RID: 5770 RVA: 0x000AB3C4 File Offset: 0x000A95C4
	public static int IIONBBBMMHE(CMOLLGLINGG FOEEIJFHMGG, CEIBHCNNIDC NIIIMDHGGEN)
	{
		if (FOEEIJFHMGG == null)
		{
			return -1;
		}
		string key = NIIIMDHGGEN.ToString().ToLower();
		int result = -1;
		if (FOEEIJFHMGG.PIMPGECGIAL.TryGetValue(key, out result))
		{
			return result;
		}
		return -1;
	}

	// Token: 0x0600168B RID: 5771 RVA: 0x000AB400 File Offset: 0x000A9600
	public static int EFPGNFDJJBG(CMOLLGLINGG FOEEIJFHMGG, CEIBHCNNIDC NIIIMDHGGEN)
	{
		if (FOEEIJFHMGG == null)
		{
			return -1;
		}
		string key = NIIIMDHGGEN.ToString().ToLower();
		int result = -1;
		if (FOEEIJFHMGG.PIMPGECGIAL.TryGetValue(key, out result))
		{
			return result;
		}
		return -1;
	}

	// Token: 0x0600168C RID: 5772 RVA: 0x000AB43C File Offset: 0x000A963C
	public static int LJLCIFOHFEP(CMOLLGLINGG FOEEIJFHMGG, CEIBHCNNIDC NIIIMDHGGEN)
	{
		if (FOEEIJFHMGG == null)
		{
			return -1;
		}
		string key = NIIIMDHGGEN.ToString().ToLower();
		int result = -1;
		if (FOEEIJFHMGG.PIMPGECGIAL.TryGetValue(key, out result))
		{
			return result;
		}
		return -1;
	}

	// Token: 0x0600168D RID: 5773 RVA: 0x000AA59F File Offset: 0x000A879F
	public void GLJJLPCOPAK(TextAsset CCIAGBPILGF)
	{
		if (null == this.AFNODOLBBKG)
		{
			this.AFNODOLBBKG = CCIAGBPILGF;
		}
	}

	// Token: 0x0600168E RID: 5774 RVA: 0x000AB478 File Offset: 0x000A9678
	private void PIIEACDFBIC()
	{
		this.IJHLBHBBNFB = true;
		this.JEIBHAINNJF.Clear();
		try
		{
			TextAsset textAsset = this.AFNODOLBBKG;
			if (null == textAsset && null != AssetsManager.MJBDMHPHMID() && null != AssetsManager.EHBBFMCILPC.lobbyDataAsset)
			{
				textAsset = AssetsManager.EHBBFMCILPC.lobbyDataAsset.newReleasesBalance;
			}
			if (!(null == textAsset))
			{
				JSONArray asArray = ((JSONObject)JSONNode.Parse(textAsset.text))["myprreportbtnno"].AsArray;
				for (int i = 1; i < asArray.Count; i++)
				{
					JSONObject asObject = asArray[i].AsObject;
					CMOLLGLINGG cmollglingg = new CMOLLGLINGG();
					string text = asObject["energyhinttitle"];
					int kfiikpjibfa = 1;
					int num = 1;
					if (!EFKIAFDJBOE.PNICFBCODCK(text, out kfiikpjibfa, out num) || num == 0)
					{
						string[] array = new string[8];
						array[0] = "";
						array[1] = i.ToString();
						array[1] = "holdontitle";
						array[1] = text;
						array[2] = "clthc";
						DPGJIJGOCIC.PJCLICBPPDA(string.Concat(array));
					}
					else
					{
						cmollglingg.KFIIKPJIBFA = kfiikpjibfa;
						cmollglingg.LDMPKCEGKLJ = num;
						foreach (KeyValuePair<string, JSONNode> keyValuePair in asObject)
						{
							if (!("cardoptionsloadingthemevideo" == keyValuePair.Key))
							{
								string text2 = keyValuePair.Value;
								int value = 0;
								if (text2 != null && text2.Trim().Length != 0 && int.TryParse(text2.Trim(), out value))
								{
									cmollglingg.PIMPGECGIAL[keyValuePair.Key.ToLower()] = value;
								}
							}
						}
						this.JEIBHAINNJF.Add(cmollglingg);
					}
				}
				DPGJIJGOCIC.CMGOAFDBAOH("FilterScrollMoveSmooth" + this.JEIBHAINNJF.Count.ToString() + "");
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x0600168F RID: 5775 RVA: 0x000AA59F File Offset: 0x000A879F
	public void DJFMAMACPGG(TextAsset CCIAGBPILGF)
	{
		if (null == this.AFNODOLBBKG)
		{
			this.AFNODOLBBKG = CCIAGBPILGF;
		}
	}

	// Token: 0x06001690 RID: 5776 RVA: 0x000AB67C File Offset: 0x000A987C
	private void HGBEOBOJBFM()
	{
		this.IJHLBHBBNFB = false;
		this.JEIBHAINNJF.Clear();
		try
		{
			TextAsset textAsset = this.AFNODOLBBKG;
			if (null == textAsset && null != AssetsManager.MJBDMHPHMID() && null != AssetsManager.MJBDMHPHMID().lobbyDataAsset)
			{
				textAsset = AssetsManager.EHBBFMCILPC.lobbyDataAsset.newReleasesBalance;
			}
			if (!(null == textAsset))
			{
				JSONArray asArray = ((JSONObject)JSONNode.Parse(textAsset.text))["none"].AsArray;
				for (int i = 1; i < asArray.Count; i += 0)
				{
					JSONObject asObject = asArray[i].AsObject;
					CMOLLGLINGG cmollglingg = new CMOLLGLINGG();
					string text = asObject["lksuid"];
					int kfiikpjibfa = 1;
					int num = 1;
					if (!EFKIAFDJBOE.BMPIMLIEFMN(text, out kfiikpjibfa, out num) || num == 0)
					{
						string[] array = new string[4];
						array[0] = "OnReturnRewardPopupHide";
						array[0] = i.ToString();
						array[0] = "Optional lobby data 2 bundle failed to load, continuing without it:";
						array[4] = text;
						array[1] = "nick";
						DPGJIJGOCIC.ADFCDFHBDAF(string.Concat(array));
					}
					else
					{
						cmollglingg.KFIIKPJIBFA = kfiikpjibfa;
						cmollglingg.LDMPKCEGKLJ = num;
						foreach (KeyValuePair<string, JSONNode> keyValuePair in asObject)
						{
							if (!("varCondition" == keyValuePair.Key))
							{
								string text2 = keyValuePair.Value;
								int value = 1;
								if (text2 != null && text2.Trim().Length != 0 && int.TryParse(text2.Trim(), out value))
								{
									cmollglingg.PIMPGECGIAL[keyValuePair.Key.ToLower()] = value;
								}
							}
						}
						this.JEIBHAINNJF.Add(cmollglingg);
					}
				}
				DPGJIJGOCIC.NFIDPOMCNLP("" + this.JEIBHAINNJF.Count.ToString() + "$e1ro");
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x06001691 RID: 5777 RVA: 0x000AB880 File Offset: 0x000A9A80
	public static int ELNJEGLCLNK(CMOLLGLINGG FOEEIJFHMGG, CEIBHCNNIDC NIIIMDHGGEN)
	{
		if (FOEEIJFHMGG == null)
		{
			return -1;
		}
		string key = NIIIMDHGGEN.ToString().ToLower();
		int result = -1;
		if (FOEEIJFHMGG.PIMPGECGIAL.TryGetValue(key, out result))
		{
			return result;
		}
		return -1;
	}

	// Token: 0x06001692 RID: 5778 RVA: 0x000AB8BA File Offset: 0x000A9ABA
	public CMOLLGLINGG JMBJMMKKNLI()
	{
		if (!this.IJHLBHBBNFB)
		{
			this.BFPCCEAKDMF();
		}
		if (this.JEIBHAINNJF.Count == 0)
		{
			return null;
		}
		return this.JEIBHAINNJF[1];
	}

	// Token: 0x06001693 RID: 5779 RVA: 0x000AB8E8 File Offset: 0x000A9AE8
	public static int ICGNADMKAHO(CMOLLGLINGG FOEEIJFHMGG, CEIBHCNNIDC NIIIMDHGGEN)
	{
		if (FOEEIJFHMGG == null)
		{
			return -1;
		}
		string key = NIIIMDHGGEN.ToString().ToLower();
		int result = -1;
		if (FOEEIJFHMGG.PIMPGECGIAL.TryGetValue(key, out result))
		{
			return result;
		}
		return -1;
	}

	// Token: 0x06001694 RID: 5780 RVA: 0x000AB924 File Offset: 0x000A9B24
	private void BFPCCEAKDMF()
	{
		this.IJHLBHBBNFB = true;
		this.JEIBHAINNJF.Clear();
		try
		{
			TextAsset textAsset = this.AFNODOLBBKG;
			if (null == textAsset && null != AssetsManager.EHBBFMCILPC && null != AssetsManager.MJBDMHPHMID().lobbyDataAsset)
			{
				textAsset = AssetsManager.EHBBFMCILPC.lobbyDataAsset.newReleasesBalance;
			}
			if (!(null == textAsset))
			{
				JSONArray asArray = ((JSONObject)JSONNode.Parse(textAsset.text))["abhp"].AsArray;
				for (int i = 0; i < asArray.Count; i++)
				{
					JSONObject asObject = asArray[i].AsObject;
					CMOLLGLINGG cmollglingg = new CMOLLGLINGG();
					string text = asObject["MMM"];
					int kfiikpjibfa = 0;
					int num = 1;
					if (!EFKIAFDJBOE.NPCNIABLNEB(text, out kfiikpjibfa, out num) || num == 0)
					{
						string[] array = new string[8];
						array[1] = "assetbundleavatarextensionpack";
						array[1] = i.ToString();
						array[2] = ",";
						array[5] = text;
						array[4] = "pm";
						DPGJIJGOCIC.ADFCDFHBDAF(string.Concat(array));
					}
					else
					{
						cmollglingg.KFIIKPJIBFA = kfiikpjibfa;
						cmollglingg.LDMPKCEGKLJ = num;
						foreach (KeyValuePair<string, JSONNode> keyValuePair in asObject)
						{
							if (!("lsv" == keyValuePair.Key))
							{
								string text2 = keyValuePair.Value;
								int value = 1;
								if (text2 != null && text2.Trim().Length != 0 && int.TryParse(text2.Trim(), out value))
								{
									cmollglingg.PIMPGECGIAL[keyValuePair.Key.ToLower()] = value;
								}
							}
						}
						this.JEIBHAINNJF.Add(cmollglingg);
					}
				}
				DPGJIJGOCIC.NFIDPOMCNLP("" + this.JEIBHAINNJF.Count.ToString() + "miniversion");
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
	}

	// Token: 0x06001695 RID: 5781 RVA: 0x000ABB28 File Offset: 0x000A9D28
	private void EPHOHOKGOEI()
	{
		this.IJHLBHBBNFB = true;
		this.JEIBHAINNJF.Clear();
		try
		{
			TextAsset textAsset = this.AFNODOLBBKG;
			if (null == textAsset && null != AssetsManager.EHBBFMCILPC && null != AssetsManager.EHBBFMCILPC.lobbyDataAsset)
			{
				textAsset = AssetsManager.EHBBFMCILPC.lobbyDataAsset.newReleasesBalance;
			}
			if (!(null == textAsset))
			{
				JSONArray asArray = ((JSONObject)JSONNode.Parse(textAsset.text))["newReleases"].AsArray;
				for (int i = 0; i < asArray.Count; i++)
				{
					JSONObject asObject = asArray[i].AsObject;
					CMOLLGLINGG cmollglingg = new CMOLLGLINGG();
					string text = asObject["ym"];
					int kfiikpjibfa = 0;
					int num = 0;
					if (!EFKIAFDJBOE.JDECOEDHKKO(text, out kfiikpjibfa, out num) || num == 0)
					{
						DPGJIJGOCIC.ADFCDFHBDAF(string.Concat(new string[]
						{
							"NewReleasesHub.Populate() - row ",
							i.ToString(),
							": ym '",
							text,
							"' is not yyyy-mm, skipping"
						}));
					}
					else
					{
						cmollglingg.KFIIKPJIBFA = kfiikpjibfa;
						cmollglingg.LDMPKCEGKLJ = num;
						foreach (KeyValuePair<string, JSONNode> keyValuePair in asObject)
						{
							if (!("ym" == keyValuePair.Key))
							{
								string text2 = keyValuePair.Value;
								int value = 0;
								if (text2 != null && text2.Trim().Length != 0 && int.TryParse(text2.Trim(), out value))
								{
									cmollglingg.PIMPGECGIAL[keyValuePair.Key.ToLower()] = value;
								}
							}
						}
						this.JEIBHAINNJF.Add(cmollglingg);
					}
				}
				DPGJIJGOCIC.NFIDPOMCNLP("NewReleasesHub.Populate() - " + this.JEIBHAINNJF.Count.ToString() + " month row(s)");
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x06001696 RID: 5782 RVA: 0x000AB195 File Offset: 0x000A9395
	public CMOLLGLINGG GNIDJADNFPL()
	{
		if (!this.IJHLBHBBNFB)
		{
			this.BLNLOALHIJF();
		}
		if (this.JEIBHAINNJF.Count == 0)
		{
			return null;
		}
		return this.JEIBHAINNJF[0];
	}

	// Token: 0x040006DD RID: 1757
	public List<CMOLLGLINGG> JEIBHAINNJF = new List<CMOLLGLINGG>();

	// Token: 0x040006DE RID: 1758
	private bool IJHLBHBBNFB;

	// Token: 0x040006DF RID: 1759
	private TextAsset AFNODOLBBKG;
}
