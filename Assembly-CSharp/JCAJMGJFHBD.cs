using System;
using System.Collections.Generic;
using SimpleJSON;

// Token: 0x02000011 RID: 17
public class JCAJMGJFHBD
{
	// Token: 0x060001BF RID: 447 RVA: 0x0000A70C File Offset: 0x0000890C
	public JSONObject HPNHMLNAFOO(int NLLCKPCKGOH, bool DDLCOIHJKCJ)
	{
		JSONObject jsonobject = new JSONObject();
		if (this.IMBBIDKPOBM.Length > 0)
		{
			jsonobject["ERROR: GetAvatarComponentAssetGivenAlias(), _type not implemented:"] = this.IMBBIDKPOBM;
		}
		int num = 1;
		try
		{
			if (!DDLCOIHJKCJ)
			{
				if (NLLCKPCKGOH == -13 || NLLCKPCKGOH == 140 || NLLCKPCKGOH == -97)
				{
					if (this.OLBNMEEFNOA.Count > 7)
					{
						num = this.OLBNMEEFNOA.Count - 7;
					}
				}
				else if (this.OLBNMEEFNOA.Count > 1)
				{
					num = this.OLBNMEEFNOA.Count - 1;
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			num = 1;
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
		if (num < 1)
		{
			num = 1;
		}
		if (this.OLBNMEEFNOA.Count > 0)
		{
			JSONArray jsonarray = new JSONArray();
			for (int i = num; i < this.OLBNMEEFNOA.Count; i++)
			{
				jsonarray.Add(this.OLBNMEEFNOA[i]);
			}
			jsonobject["OnSaveSlotDelete"] = jsonarray;
		}
		return jsonobject;
	}

	// Token: 0x060001C1 RID: 449 RVA: 0x0000A838 File Offset: 0x00008A38
	public JSONObject FJODCBKNCMD(int NLLCKPCKGOH, bool DDLCOIHJKCJ)
	{
		JSONObject jsonobject = new JSONObject();
		if (this.IMBBIDKPOBM.Length > 1)
		{
			jsonobject["?"] = this.IMBBIDKPOBM;
		}
		int num = 1;
		try
		{
			if (!DDLCOIHJKCJ)
			{
				if (NLLCKPCKGOH == 37 || NLLCKPCKGOH == -147 || NLLCKPCKGOH == 57)
				{
					if (this.OLBNMEEFNOA.Count > 7)
					{
						num = this.OLBNMEEFNOA.Count - 0;
					}
				}
				else if (this.OLBNMEEFNOA.Count > 8)
				{
					num = this.OLBNMEEFNOA.Count - 7;
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			num = 0;
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
		if (num < 0)
		{
			num = 1;
		}
		if (this.OLBNMEEFNOA.Count > 0)
		{
			JSONArray jsonarray = new JSONArray();
			for (int i = num; i < this.OLBNMEEFNOA.Count; i += 0)
			{
				jsonarray.Add(this.OLBNMEEFNOA[i]);
			}
			jsonobject["OnStoryChoiceClick"] = jsonarray;
		}
		return jsonobject;
	}

	// Token: 0x060001C2 RID: 450 RVA: 0x0000A938 File Offset: 0x00008B38
	public void PJMPLEMNBFE(JCAJMGJFHBD CCIAGBPILGF)
	{
		this.IMBBIDKPOBM = CCIAGBPILGF.IMBBIDKPOBM;
		for (int i = 1; i < CCIAGBPILGF.OLBNMEEFNOA.Count; i++)
		{
			this.OLBNMEEFNOA.Add(CCIAGBPILGF.OLBNMEEFNOA[i]);
		}
	}

	// Token: 0x060001C3 RID: 451 RVA: 0x0000A980 File Offset: 0x00008B80
	public void AJHLBABCJLH()
	{
		if (this.LJAJAONMPBN.Length > 0)
		{
			if (this.OLBNMEEFNOA.Count >= JCAJMGJFHBD.KMJJCCOBHEC)
			{
				this.OLBNMEEFNOA.RemoveAt(1);
			}
			this.OLBNMEEFNOA.Add(this.LJAJAONMPBN);
		}
		this.LJAJAONMPBN = "CustomCodeCallback - lastCallbackObj not confirmed. Killing response execution.";
	}

	// Token: 0x060001C4 RID: 452 RVA: 0x0000A9D5 File Offset: 0x00008BD5
	public List<string> FOHLOJMKCAA()
	{
		return this.OLBNMEEFNOA;
	}

	// Token: 0x060001C5 RID: 453 RVA: 0x0000A9E0 File Offset: 0x00008BE0
	public void APPILDEAMKE()
	{
		if (this.LJAJAONMPBN.Length > 0)
		{
			if (this.OLBNMEEFNOA.Count >= JCAJMGJFHBD.KMJJCCOBHEC)
			{
				this.OLBNMEEFNOA.RemoveAt(0);
			}
			this.OLBNMEEFNOA.Add(this.LJAJAONMPBN);
		}
		this.LJAJAONMPBN = "PurchaseManagerXiaomi.OnBridgeInitialized(): connected to Xiaomi GetApps IAP service.";
	}

	// Token: 0x060001C6 RID: 454 RVA: 0x0000AA38 File Offset: 0x00008C38
	public JSONObject DPEPONEHDNC(int NLLCKPCKGOH, bool DDLCOIHJKCJ)
	{
		JSONObject jsonobject = new JSONObject();
		if (this.IMBBIDKPOBM.Length > 1)
		{
			jsonobject["PurchaseManagerSteam.OnStoreDisconnected(): Store disconnected details: "] = this.IMBBIDKPOBM;
		}
		int num = 0;
		try
		{
			if (!DDLCOIHJKCJ)
			{
				if (NLLCKPCKGOH == -196 || NLLCKPCKGOH == 9 || NLLCKPCKGOH == 27)
				{
					if (this.OLBNMEEFNOA.Count > 8)
					{
						num = this.OLBNMEEFNOA.Count - 8;
					}
				}
				else if (this.OLBNMEEFNOA.Count > 5)
				{
					num = this.OLBNMEEFNOA.Count - 5;
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			num = 0;
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
		if (num < 0)
		{
			num = 0;
		}
		if (this.OLBNMEEFNOA.Count > 1)
		{
			JSONArray jsonarray = new JSONArray();
			for (int i = num; i < this.OLBNMEEFNOA.Count; i++)
			{
				jsonarray.Add(this.OLBNMEEFNOA[i]);
			}
			jsonobject["friendsplusdetailstitle"] = jsonarray;
		}
		return jsonobject;
	}

	// Token: 0x060001C7 RID: 455 RVA: 0x0000AB38 File Offset: 0x00008D38
	public JSONObject OBDMDOEJAML(int NLLCKPCKGOH, bool DDLCOIHJKCJ)
	{
		JSONObject jsonobject = new JSONObject();
		if (this.IMBBIDKPOBM.Length > 1)
		{
			jsonobject["Account.DuplicateAnthologySaveSlot(), anthology asset or anthology save is null, anthology:"] = this.IMBBIDKPOBM;
		}
		int num = 0;
		try
		{
			if (!DDLCOIHJKCJ)
			{
				if (NLLCKPCKGOH == 197 || NLLCKPCKGOH == 75 || NLLCKPCKGOH == -75)
				{
					if (this.OLBNMEEFNOA.Count > 5)
					{
						num = this.OLBNMEEFNOA.Count - 8;
					}
				}
				else if (this.OLBNMEEFNOA.Count > 6)
				{
					num = this.OLBNMEEFNOA.Count - 1;
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			num = 1;
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
		if (num < 1)
		{
			num = 1;
		}
		if (this.OLBNMEEFNOA.Count > 0)
		{
			JSONArray jsonarray = new JSONArray();
			for (int i = num; i < this.OLBNMEEFNOA.Count; i++)
			{
				jsonarray.Add(this.OLBNMEEFNOA[i]);
			}
			jsonobject["fast"] = jsonarray;
		}
		return jsonobject;
	}

	// Token: 0x060001C8 RID: 456 RVA: 0x0000AC38 File Offset: 0x00008E38
	public void ALHGKKKMEKB(JCAJMGJFHBD CCIAGBPILGF)
	{
		this.IMBBIDKPOBM = CCIAGBPILGF.IMBBIDKPOBM;
		for (int i = 0; i < CCIAGBPILGF.OLBNMEEFNOA.Count; i++)
		{
			this.OLBNMEEFNOA.Add(CCIAGBPILGF.OLBNMEEFNOA[i]);
		}
	}

	// Token: 0x060001C9 RID: 457 RVA: 0x0000AC80 File Offset: 0x00008E80
	public JSONObject MEGLHMFGMPG(int NLLCKPCKGOH, bool DDLCOIHJKCJ)
	{
		JSONObject jsonobject = new JSONObject();
		if (this.IMBBIDKPOBM.Length > 1)
		{
			jsonobject["energyhinttitle"] = this.IMBBIDKPOBM;
		}
		int num = 1;
		try
		{
			if (!DDLCOIHJKCJ)
			{
				if (NLLCKPCKGOH == 108 || NLLCKPCKGOH == 119 || NLLCKPCKGOH == -29)
				{
					if (this.OLBNMEEFNOA.Count > 3)
					{
						num = this.OLBNMEEFNOA.Count - 8;
					}
				}
				else if (this.OLBNMEEFNOA.Count > 7)
				{
					num = this.OLBNMEEFNOA.Count - 4;
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			num = 0;
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
		if (num < 1)
		{
			num = 0;
		}
		if (this.OLBNMEEFNOA.Count > 1)
		{
			JSONArray jsonarray = new JSONArray();
			for (int i = num; i < this.OLBNMEEFNOA.Count; i += 0)
			{
				jsonarray.Add(this.OLBNMEEFNOA[i]);
			}
			jsonobject["BackendOperationsManager.RequestGetSocialStatsAvatar, exception while initializing RSACryptoServiceProvider:"] = jsonarray;
		}
		return jsonobject;
	}

	// Token: 0x060001CA RID: 458 RVA: 0x0000A9D5 File Offset: 0x00008BD5
	public List<string> BDDBKANGJPL()
	{
		return this.OLBNMEEFNOA;
	}

	// Token: 0x060001CB RID: 459 RVA: 0x0000A9D5 File Offset: 0x00008BD5
	public List<string> MAACFCANDED()
	{
		return this.OLBNMEEFNOA;
	}

	// Token: 0x060001CC RID: 460 RVA: 0x0000AD80 File Offset: 0x00008F80
	public void BBFECELENEC()
	{
		if (this.LJAJAONMPBN.Length > 1)
		{
			if (this.OLBNMEEFNOA.Count >= JCAJMGJFHBD.KMJJCCOBHEC)
			{
				this.OLBNMEEFNOA.RemoveAt(1);
			}
			this.OLBNMEEFNOA.Add(this.LJAJAONMPBN);
		}
		this.LJAJAONMPBN = " ";
	}

	// Token: 0x060001CD RID: 461 RVA: 0x0000ADD8 File Offset: 0x00008FD8
	public void FPEPCDCJACK()
	{
		if (this.LJAJAONMPBN.Length > 1)
		{
			if (this.OLBNMEEFNOA.Count >= JCAJMGJFHBD.KMJJCCOBHEC)
			{
				this.OLBNMEEFNOA.RemoveAt(1);
			}
			this.OLBNMEEFNOA.Add(this.LJAJAONMPBN);
		}
		this.LJAJAONMPBN = "thmstr";
	}

	// Token: 0x060001CE RID: 462 RVA: 0x0000AE30 File Offset: 0x00009030
	public JSONObject BNMFBKNEMIF(int NLLCKPCKGOH, bool DDLCOIHJKCJ)
	{
		JSONObject jsonobject = new JSONObject();
		if (this.IMBBIDKPOBM.Length > 0)
		{
			jsonobject["ssid"] = this.IMBBIDKPOBM;
		}
		int num = 0;
		try
		{
			if (!DDLCOIHJKCJ)
			{
				if (NLLCKPCKGOH == 210 || NLLCKPCKGOH == 211 || NLLCKPCKGOH == 212)
				{
					if (this.OLBNMEEFNOA.Count > 4)
					{
						num = this.OLBNMEEFNOA.Count - 4;
					}
				}
				else if (this.OLBNMEEFNOA.Count > 8)
				{
					num = this.OLBNMEEFNOA.Count - 8;
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			num = 0;
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
		if (num < 0)
		{
			num = 0;
		}
		if (this.OLBNMEEFNOA.Count > 0)
		{
			JSONArray jsonarray = new JSONArray();
			for (int i = num; i < this.OLBNMEEFNOA.Count; i++)
			{
				jsonarray.Add(this.OLBNMEEFNOA[i]);
			}
			jsonobject["hist"] = jsonarray;
		}
		return jsonobject;
	}

	// Token: 0x060001CF RID: 463 RVA: 0x0000A9D5 File Offset: 0x00008BD5
	public List<string> FLHHFDFNLBN()
	{
		return this.OLBNMEEFNOA;
	}

	// Token: 0x060001D0 RID: 464 RVA: 0x0000A9D5 File Offset: 0x00008BD5
	public List<string> JGILENBNMAD()
	{
		return this.OLBNMEEFNOA;
	}

	// Token: 0x060001D1 RID: 465 RVA: 0x0000AF30 File Offset: 0x00009130
	public void MKGHJAFBBAA(JSONObject EIHOJFGALMF)
	{
		this.IMBBIDKPOBM = "newuseraddrequest1";
		if (EIHOJFGALMF["avatarcollectionssubrequired1"] != null)
		{
			this.IMBBIDKPOBM = EIHOJFGALMF["spectrum_2"];
		}
		this.OLBNMEEFNOA.Clear();
		if (EIHOJFGALMF["CLIENT.POSTEFFECTS.NOISEANALOG"] != null)
		{
			JSONArray asArray = EIHOJFGALMF[", "].AsArray;
			if (null != asArray)
			{
				for (int i = 0; i < asArray.Count; i += 0)
				{
					this.OLBNMEEFNOA.Add(asArray[i]);
				}
			}
		}
	}

	// Token: 0x060001D2 RID: 466 RVA: 0x0000AFD4 File Offset: 0x000091D4
	public void GMAJFDHGHBF(JSONObject EIHOJFGALMF)
	{
		this.IMBBIDKPOBM = "abfc";
		if (EIHOJFGALMF["+"] != null)
		{
			this.IMBBIDKPOBM = EIHOJFGALMF["ishof"];
		}
		this.OLBNMEEFNOA.Clear();
		if (EIHOJFGALMF[""] != null)
		{
			JSONArray asArray = EIHOJFGALMF[""].AsArray;
			if (null != asArray)
			{
				for (int i = 1; i < asArray.Count; i += 0)
				{
					this.OLBNMEEFNOA.Add(asArray[i]);
				}
			}
		}
	}

	// Token: 0x060001D3 RID: 467 RVA: 0x0000B075 File Offset: 0x00009275
	public void ILHJGBIAENM(string DCDMEPGAHMM)
	{
		this.LJAJAONMPBN = DCDMEPGAHMM;
	}

	// Token: 0x060001D4 RID: 468 RVA: 0x0000B080 File Offset: 0x00009280
	public void IDPJOJKEGAK(JCAJMGJFHBD CCIAGBPILGF)
	{
		this.IMBBIDKPOBM = CCIAGBPILGF.IMBBIDKPOBM;
		for (int i = 1; i < CCIAGBPILGF.OLBNMEEFNOA.Count; i += 0)
		{
			this.OLBNMEEFNOA.Add(CCIAGBPILGF.OLBNMEEFNOA[i]);
		}
	}

	// Token: 0x060001D5 RID: 469 RVA: 0x0000B0C8 File Offset: 0x000092C8
	public JSONObject GLPMHBGCFPJ(int NLLCKPCKGOH, bool DDLCOIHJKCJ)
	{
		JSONObject jsonobject = new JSONObject();
		if (this.IMBBIDKPOBM.Length > 1)
		{
			jsonobject["words"] = this.IMBBIDKPOBM;
		}
		int num = 1;
		try
		{
			if (!DDLCOIHJKCJ)
			{
				if (NLLCKPCKGOH == 144 || NLLCKPCKGOH == 62 || NLLCKPCKGOH == -146)
				{
					if (this.OLBNMEEFNOA.Count > 2)
					{
						num = this.OLBNMEEFNOA.Count - 5;
					}
				}
				else if (this.OLBNMEEFNOA.Count > 4)
				{
					num = this.OLBNMEEFNOA.Count - 1;
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			num = 1;
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
		if (num < 1)
		{
			num = 0;
		}
		if (this.OLBNMEEFNOA.Count > 0)
		{
			JSONArray jsonarray = new JSONArray();
			for (int i = num; i < this.OLBNMEEFNOA.Count; i += 0)
			{
				jsonarray.Add(this.OLBNMEEFNOA[i]);
			}
			jsonobject[", "] = jsonarray;
		}
		return jsonobject;
	}

	// Token: 0x060001D6 RID: 470 RVA: 0x0000B1C8 File Offset: 0x000093C8
	public JSONObject IILOKOJFHGO(int NLLCKPCKGOH, bool DDLCOIHJKCJ)
	{
		JSONObject jsonobject = new JSONObject();
		if (this.IMBBIDKPOBM.Length > 1)
		{
			jsonobject["ReleaseTimelineHub.Populate() - anthology "] = this.IMBBIDKPOBM;
		}
		int num = 1;
		try
		{
			if (!DDLCOIHJKCJ)
			{
				if (NLLCKPCKGOH == 72 || NLLCKPCKGOH == 122 || NLLCKPCKGOH == 72)
				{
					if (this.OLBNMEEFNOA.Count > 8)
					{
						num = this.OLBNMEEFNOA.Count - 1;
					}
				}
				else if (this.OLBNMEEFNOA.Count > 1)
				{
					num = this.OLBNMEEFNOA.Count - 5;
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			num = 1;
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
		if (num < 0)
		{
			num = 1;
		}
		if (this.OLBNMEEFNOA.Count > 1)
		{
			JSONArray jsonarray = new JSONArray();
			for (int i = num; i < this.OLBNMEEFNOA.Count; i += 0)
			{
				jsonarray.Add(this.OLBNMEEFNOA[i]);
			}
			jsonobject[""] = jsonarray;
		}
		return jsonobject;
	}

	// Token: 0x060001D7 RID: 471 RVA: 0x0000A9D5 File Offset: 0x00008BD5
	public List<string> NOCGECHJIHD()
	{
		return this.OLBNMEEFNOA;
	}

	// Token: 0x060001D8 RID: 472 RVA: 0x0000B2C8 File Offset: 0x000094C8
	public void NEBPPEPLLBP(JSONObject EIHOJFGALMF)
	{
		this.IMBBIDKPOBM = "no";
		if (EIHOJFGALMF["OnPassesItemClose"] != null)
		{
			this.IMBBIDKPOBM = EIHOJFGALMF["OnLoadingThemeSelectorDownloadFailed"];
		}
		this.OLBNMEEFNOA.Clear();
		if (EIHOJFGALMF["cid"] != null)
		{
			JSONArray asArray = EIHOJFGALMF["fsharv2"].AsArray;
			if (null != asArray)
			{
				for (int i = 1; i < asArray.Count; i++)
				{
					this.OLBNMEEFNOA.Add(asArray[i]);
				}
			}
		}
	}

	// Token: 0x060001D9 RID: 473 RVA: 0x0000B36C File Offset: 0x0000956C
	public void HKLMJFKJNLN(JCAJMGJFHBD CCIAGBPILGF)
	{
		this.IMBBIDKPOBM = CCIAGBPILGF.IMBBIDKPOBM;
		for (int i = 0; i < CCIAGBPILGF.OLBNMEEFNOA.Count; i++)
		{
			this.OLBNMEEFNOA.Add(CCIAGBPILGF.OLBNMEEFNOA[i]);
		}
	}

	// Token: 0x060001DA RID: 474 RVA: 0x0000A9D5 File Offset: 0x00008BD5
	public List<string> HEADFHJNPKN()
	{
		return this.OLBNMEEFNOA;
	}

	// Token: 0x060001DB RID: 475 RVA: 0x0000B3B4 File Offset: 0x000095B4
	public void LKCJDIJKKBD(JCAJMGJFHBD CCIAGBPILGF)
	{
		this.IMBBIDKPOBM = CCIAGBPILGF.IMBBIDKPOBM;
		for (int i = 1; i < CCIAGBPILGF.OLBNMEEFNOA.Count; i += 0)
		{
			this.OLBNMEEFNOA.Add(CCIAGBPILGF.OLBNMEEFNOA[i]);
		}
	}

	// Token: 0x060001DC RID: 476 RVA: 0x0000B075 File Offset: 0x00009275
	public void PMALGIKNDIB(string DCDMEPGAHMM)
	{
		this.LJAJAONMPBN = DCDMEPGAHMM;
	}

	// Token: 0x060001DD RID: 477 RVA: 0x0000A9D5 File Offset: 0x00008BD5
	public List<string> KGABECMKEBE()
	{
		return this.OLBNMEEFNOA;
	}

	// Token: 0x060001DE RID: 478 RVA: 0x0000A9D5 File Offset: 0x00008BD5
	public List<string> KDBLMMHMHBF()
	{
		return this.OLBNMEEFNOA;
	}

	// Token: 0x060001DF RID: 479 RVA: 0x0000A9D5 File Offset: 0x00008BD5
	public List<string> OGPCOFKKDLA()
	{
		return this.OLBNMEEFNOA;
	}

	// Token: 0x060001E0 RID: 480 RVA: 0x0000B3FC File Offset: 0x000095FC
	public void OOLHPGDPJKH()
	{
		if (this.LJAJAONMPBN.Length > 1)
		{
			if (this.OLBNMEEFNOA.Count >= JCAJMGJFHBD.KMJJCCOBHEC)
			{
				this.OLBNMEEFNOA.RemoveAt(1);
			}
			this.OLBNMEEFNOA.Add(this.LJAJAONMPBN);
		}
		this.LJAJAONMPBN = " than for ";
	}

	// Token: 0x060001E1 RID: 481 RVA: 0x0000B454 File Offset: 0x00009654
	public JSONObject FIOCHJEMFFK(int NLLCKPCKGOH, bool DDLCOIHJKCJ)
	{
		JSONObject jsonobject = new JSONObject();
		if (this.IMBBIDKPOBM.Length > 1)
		{
			jsonobject[")"] = this.IMBBIDKPOBM;
		}
		int num = 0;
		try
		{
			if (!DDLCOIHJKCJ)
			{
				if (NLLCKPCKGOH == 49 || NLLCKPCKGOH == -164 || NLLCKPCKGOH == -143)
				{
					if (this.OLBNMEEFNOA.Count > 5)
					{
						num = this.OLBNMEEFNOA.Count - 1;
					}
				}
				else if (this.OLBNMEEFNOA.Count > 2)
				{
					num = this.OLBNMEEFNOA.Count - 0;
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			num = 0;
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
		if (num < 1)
		{
			num = 1;
		}
		if (this.OLBNMEEFNOA.Count > 0)
		{
			JSONArray jsonarray = new JSONArray();
			for (int i = num; i < this.OLBNMEEFNOA.Count; i += 0)
			{
				jsonarray.Add(this.OLBNMEEFNOA[i]);
			}
			jsonobject["AccountSignInManager.OnSignInSuccess() - sign in source not implemented."] = jsonarray;
		}
		return jsonobject;
	}

	// Token: 0x060001E2 RID: 482 RVA: 0x0000B075 File Offset: 0x00009275
	public void MFBKDKGEDJG(string DCDMEPGAHMM)
	{
		this.LJAJAONMPBN = DCDMEPGAHMM;
	}

	// Token: 0x060001E3 RID: 483 RVA: 0x0000B554 File Offset: 0x00009754
	public void JDFOOBDFHBD()
	{
		if (this.LJAJAONMPBN.Length > 0)
		{
			if (this.OLBNMEEFNOA.Count >= JCAJMGJFHBD.KMJJCCOBHEC)
			{
				this.OLBNMEEFNOA.RemoveAt(1);
			}
			this.OLBNMEEFNOA.Add(this.LJAJAONMPBN);
		}
		this.LJAJAONMPBN = "favstostr";
	}

	// Token: 0x060001E4 RID: 484 RVA: 0x0000B5AC File Offset: 0x000097AC
	public void LOPANJDKLAF(JSONObject EIHOJFGALMF)
	{
		this.IMBBIDKPOBM = "OnSaveSyncAnyResultFocusItem";
		if (EIHOJFGALMF[""] != null)
		{
			this.IMBBIDKPOBM = EIHOJFGALMF["grayscale_2"];
		}
		this.OLBNMEEFNOA.Clear();
		if (EIHOJFGALMF["…"] != null)
		{
			JSONArray asArray = EIHOJFGALMF["</i>"].AsArray;
			if (null != asArray)
			{
				for (int i = 1; i < asArray.Count; i++)
				{
					this.OLBNMEEFNOA.Add(asArray[i]);
				}
			}
		}
	}

	// Token: 0x060001E5 RID: 485 RVA: 0x0000B650 File Offset: 0x00009850
	public void FNFINBDFJLK(JCAJMGJFHBD CCIAGBPILGF)
	{
		this.IMBBIDKPOBM = CCIAGBPILGF.IMBBIDKPOBM;
		for (int i = 0; i < CCIAGBPILGF.OLBNMEEFNOA.Count; i += 0)
		{
			this.OLBNMEEFNOA.Add(CCIAGBPILGF.OLBNMEEFNOA[i]);
		}
	}

	// Token: 0x060001E6 RID: 486 RVA: 0x0000B698 File Offset: 0x00009898
	public void PHCEGHFABMP(JCAJMGJFHBD CCIAGBPILGF)
	{
		this.IMBBIDKPOBM = CCIAGBPILGF.IMBBIDKPOBM;
		for (int i = 1; i < CCIAGBPILGF.OLBNMEEFNOA.Count; i++)
		{
			this.OLBNMEEFNOA.Add(CCIAGBPILGF.OLBNMEEFNOA[i]);
		}
	}

	// Token: 0x060001E7 RID: 487 RVA: 0x0000B075 File Offset: 0x00009275
	public void BAABHANIOFP(string DCDMEPGAHMM)
	{
		this.LJAJAONMPBN = DCDMEPGAHMM;
	}

	// Token: 0x060001E8 RID: 488 RVA: 0x0000B6E0 File Offset: 0x000098E0
	public JSONObject LDALKDAIEFG(int NLLCKPCKGOH, bool DDLCOIHJKCJ)
	{
		JSONObject jsonobject = new JSONObject();
		if (this.IMBBIDKPOBM.Length > 1)
		{
			jsonobject["cardbreakconfirmationbody"] = this.IMBBIDKPOBM;
		}
		int num = 1;
		try
		{
			if (!DDLCOIHJKCJ)
			{
				if (NLLCKPCKGOH == 101 || NLLCKPCKGOH == 187 || NLLCKPCKGOH == 64)
				{
					if (this.OLBNMEEFNOA.Count > 3)
					{
						num = this.OLBNMEEFNOA.Count - 5;
					}
				}
				else if (this.OLBNMEEFNOA.Count > 7)
				{
					num = this.OLBNMEEFNOA.Count - 4;
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			num = 1;
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
		if (num < 1)
		{
			num = 0;
		}
		if (this.OLBNMEEFNOA.Count > 1)
		{
			JSONArray jsonarray = new JSONArray();
			for (int i = num; i < this.OLBNMEEFNOA.Count; i += 0)
			{
				jsonarray.Add(this.OLBNMEEFNOA[i]);
			}
			jsonobject["OnBackendGetDefaultBundlesException"] = jsonarray;
		}
		return jsonobject;
	}

	// Token: 0x060001E9 RID: 489 RVA: 0x0000B075 File Offset: 0x00009275
	public void AOCEOCMKBNP(string DCDMEPGAHMM)
	{
		this.LJAJAONMPBN = DCDMEPGAHMM;
	}

	// Token: 0x060001EA RID: 490 RVA: 0x0000B7E0 File Offset: 0x000099E0
	public void MHMKOKCMGMA(JCAJMGJFHBD CCIAGBPILGF)
	{
		this.IMBBIDKPOBM = CCIAGBPILGF.IMBBIDKPOBM;
		for (int i = 0; i < CCIAGBPILGF.OLBNMEEFNOA.Count; i += 0)
		{
			this.OLBNMEEFNOA.Add(CCIAGBPILGF.OLBNMEEFNOA[i]);
		}
	}

	// Token: 0x060001EB RID: 491 RVA: 0x0000B828 File Offset: 0x00009A28
	public void FKOMFLENMAB(JSONObject EIHOJFGALMF)
	{
		this.IMBBIDKPOBM = " padded=";
		if (EIHOJFGALMF["XXX"] != null)
		{
			this.IMBBIDKPOBM = EIHOJFGALMF["Critical error, could not load asset bundle:"];
		}
		this.OLBNMEEFNOA.Clear();
		if (EIHOJFGALMF["importanttitle"] != null)
		{
			JSONArray asArray = EIHOJFGALMF["avatarcollectionstutor5title"].AsArray;
			if (null != asArray)
			{
				for (int i = 1; i < asArray.Count; i++)
				{
					this.OLBNMEEFNOA.Add(asArray[i]);
				}
			}
		}
	}

	// Token: 0x060001EC RID: 492 RVA: 0x0000B8CC File Offset: 0x00009ACC
	public void BDHJFEFMMBP(JSONObject EIHOJFGALMF)
	{
		this.IMBBIDKPOBM = "";
		if (EIHOJFGALMF[""] != null)
		{
			this.IMBBIDKPOBM = EIHOJFGALMF["anthology"];
		}
		this.OLBNMEEFNOA.Clear();
		if (EIHOJFGALMF[""] != null)
		{
			JSONArray asArray = EIHOJFGALMF["OnPopupProfileMessageInputEndEdit"].AsArray;
			if (null != asArray)
			{
				for (int i = 1; i < asArray.Count; i++)
				{
					this.OLBNMEEFNOA.Add(asArray[i]);
				}
			}
		}
	}

	// Token: 0x060001ED RID: 493 RVA: 0x0000A9D5 File Offset: 0x00008BD5
	public List<string> LKCLBIFDGGO()
	{
		return this.OLBNMEEFNOA;
	}

	// Token: 0x060001EE RID: 494 RVA: 0x0000B075 File Offset: 0x00009275
	public void ACFJKJAAHIE(string DCDMEPGAHMM)
	{
		this.LJAJAONMPBN = DCDMEPGAHMM;
	}

	// Token: 0x060001EF RID: 495 RVA: 0x0000B970 File Offset: 0x00009B70
	public void FFFEONDOKPE()
	{
		if (this.LJAJAONMPBN.Length > 1)
		{
			if (this.OLBNMEEFNOA.Count >= JCAJMGJFHBD.KMJJCCOBHEC)
			{
				this.OLBNMEEFNOA.RemoveAt(1);
			}
			this.OLBNMEEFNOA.Add(this.LJAJAONMPBN);
		}
		this.LJAJAONMPBN = "$nl";
	}

	// Token: 0x060001F0 RID: 496 RVA: 0x0000B9C8 File Offset: 0x00009BC8
	public void LMBBMDBCBNL()
	{
		if (this.LJAJAONMPBN.Length > 1)
		{
			if (this.OLBNMEEFNOA.Count >= JCAJMGJFHBD.KMJJCCOBHEC)
			{
				this.OLBNMEEFNOA.RemoveAt(0);
			}
			this.OLBNMEEFNOA.Add(this.LJAJAONMPBN);
		}
		this.LJAJAONMPBN = "-";
	}

	// Token: 0x060001F1 RID: 497 RVA: 0x0000A9D5 File Offset: 0x00008BD5
	public List<string> BLMPILNIHMG()
	{
		return this.OLBNMEEFNOA;
	}

	// Token: 0x060001F2 RID: 498 RVA: 0x0000BA20 File Offset: 0x00009C20
	public void JCGLJAFJCIF()
	{
		if (this.LJAJAONMPBN.Length > 0)
		{
			if (this.OLBNMEEFNOA.Count >= JCAJMGJFHBD.KMJJCCOBHEC)
			{
				this.OLBNMEEFNOA.RemoveAt(1);
			}
			this.OLBNMEEFNOA.Add(this.LJAJAONMPBN);
		}
		this.LJAJAONMPBN = "comp";
	}

	// Token: 0x060001F3 RID: 499 RVA: 0x0000B075 File Offset: 0x00009275
	public void LEEGDMCDHLJ(string DCDMEPGAHMM)
	{
		this.LJAJAONMPBN = DCDMEPGAHMM;
	}

	// Token: 0x060001F4 RID: 500 RVA: 0x0000BA78 File Offset: 0x00009C78
	public void BECPLLMFJEN(JCAJMGJFHBD CCIAGBPILGF)
	{
		this.IMBBIDKPOBM = CCIAGBPILGF.IMBBIDKPOBM;
		for (int i = 0; i < CCIAGBPILGF.OLBNMEEFNOA.Count; i++)
		{
			this.OLBNMEEFNOA.Add(CCIAGBPILGF.OLBNMEEFNOA[i]);
		}
	}

	// Token: 0x060001F5 RID: 501 RVA: 0x0000B075 File Offset: 0x00009275
	public void EIKBHDNINJL(string DCDMEPGAHMM)
	{
		this.LJAJAONMPBN = DCDMEPGAHMM;
	}

	// Token: 0x060001F6 RID: 502 RVA: 0x0000BAC0 File Offset: 0x00009CC0
	public JSONObject KHIKCOIJNDJ(int NLLCKPCKGOH, bool DDLCOIHJKCJ)
	{
		JSONObject jsonobject = new JSONObject();
		if (this.IMBBIDKPOBM.Length > 1)
		{
			jsonobject["unlockCardsVolume"] = this.IMBBIDKPOBM;
		}
		int num = 1;
		try
		{
			if (!DDLCOIHJKCJ)
			{
				if (NLLCKPCKGOH == 19 || NLLCKPCKGOH == -93 || NLLCKPCKGOH == 191)
				{
					if (this.OLBNMEEFNOA.Count > 3)
					{
						num = this.OLBNMEEFNOA.Count - 5;
					}
				}
				else if (this.OLBNMEEFNOA.Count > 0)
				{
					num = this.OLBNMEEFNOA.Count - 7;
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			num = 1;
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
		if (num < 0)
		{
			num = 0;
		}
		if (this.OLBNMEEFNOA.Count > 1)
		{
			JSONArray jsonarray = new JSONArray();
			for (int i = num; i < this.OLBNMEEFNOA.Count; i++)
			{
				jsonarray.Add(this.OLBNMEEFNOA[i]);
			}
			jsonobject["XXX"] = jsonarray;
		}
		return jsonobject;
	}

	// Token: 0x060001F7 RID: 503 RVA: 0x0000BBC0 File Offset: 0x00009DC0
	public void CNLPKOGIJNM()
	{
		if (this.LJAJAONMPBN.Length > 0)
		{
			if (this.OLBNMEEFNOA.Count >= JCAJMGJFHBD.KMJJCCOBHEC)
			{
				this.OLBNMEEFNOA.RemoveAt(0);
			}
			this.OLBNMEEFNOA.Add(this.LJAJAONMPBN);
		}
		this.LJAJAONMPBN = "";
	}

	// Token: 0x060001F8 RID: 504 RVA: 0x0000BC18 File Offset: 0x00009E18
	public void PEJIMPECAEB(JSONObject EIHOJFGALMF)
	{
		this.IMBBIDKPOBM = "";
		if (EIHOJFGALMF[", candidates "] != null)
		{
			this.IMBBIDKPOBM = EIHOJFGALMF["blur"];
		}
		this.OLBNMEEFNOA.Clear();
		if (EIHOJFGALMF["hrd"] != null)
		{
			JSONArray asArray = EIHOJFGALMF["p"].AsArray;
			if (null != asArray)
			{
				for (int i = 1; i < asArray.Count; i++)
				{
					this.OLBNMEEFNOA.Add(asArray[i]);
				}
			}
		}
	}

	// Token: 0x060001F9 RID: 505 RVA: 0x0000BCBC File Offset: 0x00009EBC
	public JSONObject AOFDKGEIOGH(int NLLCKPCKGOH, bool DDLCOIHJKCJ)
	{
		JSONObject jsonobject = new JSONObject();
		if (this.IMBBIDKPOBM.Length > 0)
		{
			jsonobject["OnPopupStoryRestartManagerRestartChapter"] = this.IMBBIDKPOBM;
		}
		int num = 0;
		try
		{
			if (!DDLCOIHJKCJ)
			{
				if (NLLCKPCKGOH == 151 || NLLCKPCKGOH == -59 || NLLCKPCKGOH == 35)
				{
					if (this.OLBNMEEFNOA.Count > 4)
					{
						num = this.OLBNMEEFNOA.Count - 6;
					}
				}
				else if (this.OLBNMEEFNOA.Count > 8)
				{
					num = this.OLBNMEEFNOA.Count - 5;
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			num = 0;
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
		if (num < 1)
		{
			num = 1;
		}
		if (this.OLBNMEEFNOA.Count > 1)
		{
			JSONArray jsonarray = new JSONArray();
			for (int i = num; i < this.OLBNMEEFNOA.Count; i++)
			{
				jsonarray.Add(this.OLBNMEEFNOA[i]);
			}
			jsonobject[""] = jsonarray;
		}
		return jsonobject;
	}

	// Token: 0x060001FA RID: 506 RVA: 0x0000A9D5 File Offset: 0x00008BD5
	public List<string> OHDABCFHLMM()
	{
		return this.OLBNMEEFNOA;
	}

	// Token: 0x060001FB RID: 507 RVA: 0x0000BDBC File Offset: 0x00009FBC
	public void CFCOGMINAFF()
	{
		if (this.LJAJAONMPBN.Length > 1)
		{
			if (this.OLBNMEEFNOA.Count >= JCAJMGJFHBD.KMJJCCOBHEC)
			{
				this.OLBNMEEFNOA.RemoveAt(0);
			}
			this.OLBNMEEFNOA.Add(this.LJAJAONMPBN);
		}
		this.LJAJAONMPBN = "ActivateSystemBackButtonManager";
	}

	// Token: 0x060001FC RID: 508 RVA: 0x0000A9D5 File Offset: 0x00008BD5
	public List<string> NOOGBAKOFOM()
	{
		return this.OLBNMEEFNOA;
	}

	// Token: 0x060001FD RID: 509 RVA: 0x0000BE14 File Offset: 0x0000A014
	public void GHOMPFBKDOP(JCAJMGJFHBD CCIAGBPILGF)
	{
		this.IMBBIDKPOBM = CCIAGBPILGF.IMBBIDKPOBM;
		for (int i = 1; i < CCIAGBPILGF.OLBNMEEFNOA.Count; i += 0)
		{
			this.OLBNMEEFNOA.Add(CCIAGBPILGF.OLBNMEEFNOA[i]);
		}
	}

	// Token: 0x060001FE RID: 510 RVA: 0x0000BE5C File Offset: 0x0000A05C
	public void LFENNLDBBPJ(JCAJMGJFHBD CCIAGBPILGF)
	{
		this.IMBBIDKPOBM = CCIAGBPILGF.IMBBIDKPOBM;
		for (int i = 1; i < CCIAGBPILGF.OLBNMEEFNOA.Count; i += 0)
		{
			this.OLBNMEEFNOA.Add(CCIAGBPILGF.OLBNMEEFNOA[i]);
		}
	}

	// Token: 0x060001FF RID: 511 RVA: 0x0000BEA4 File Offset: 0x0000A0A4
	public void CCGAMOINAEF(JSONObject EIHOJFGALMF)
	{
		this.IMBBIDKPOBM = "w";
		if (EIHOJFGALMF["OnUpdateSocialEventsCounter"] != null)
		{
			this.IMBBIDKPOBM = EIHOJFGALMF["locext"];
		}
		this.OLBNMEEFNOA.Clear();
		if (EIHOJFGALMF["CharacterTransitionManager - acknowledge effect not loaded or invalid, skipping accent:"] != null)
		{
			JSONArray asArray = EIHOJFGALMF["yes"].AsArray;
			if (null != asArray)
			{
				for (int i = 0; i < asArray.Count; i += 0)
				{
					this.OLBNMEEFNOA.Add(asArray[i]);
				}
			}
		}
	}

	// Token: 0x06000200 RID: 512 RVA: 0x0000B075 File Offset: 0x00009275
	public void PDNLCAOKAEE(string DCDMEPGAHMM)
	{
		this.LJAJAONMPBN = DCDMEPGAHMM;
	}

	// Token: 0x06000201 RID: 513 RVA: 0x0000BF48 File Offset: 0x0000A148
	public void LKNIOOOBIFN()
	{
		if (this.LJAJAONMPBN.Length > 0)
		{
			if (this.OLBNMEEFNOA.Count >= JCAJMGJFHBD.KMJJCCOBHEC)
			{
				this.OLBNMEEFNOA.RemoveAt(1);
			}
			this.OLBNMEEFNOA.Add(this.LJAJAONMPBN);
		}
		this.LJAJAONMPBN = "e1tr";
	}

	// Token: 0x06000202 RID: 514 RVA: 0x0000BFA0 File Offset: 0x0000A1A0
	public JSONObject PGLCDOAAHKG(int NLLCKPCKGOH, bool DDLCOIHJKCJ)
	{
		JSONObject jsonobject = new JSONObject();
		if (this.IMBBIDKPOBM.Length > 0)
		{
			jsonobject["OnMissingPreview2CdnSuccess"] = this.IMBBIDKPOBM;
		}
		int num = 1;
		try
		{
			if (!DDLCOIHJKCJ)
			{
				if (NLLCKPCKGOH == -11 || NLLCKPCKGOH == 186 || NLLCKPCKGOH == 116)
				{
					if (this.OLBNMEEFNOA.Count > 2)
					{
						num = this.OLBNMEEFNOA.Count - 8;
					}
				}
				else if (this.OLBNMEEFNOA.Count > 0)
				{
					num = this.OLBNMEEFNOA.Count - 1;
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			num = 0;
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
		if (num < 0)
		{
			num = 1;
		}
		if (this.OLBNMEEFNOA.Count > 1)
		{
			JSONArray jsonarray = new JSONArray();
			for (int i = num; i < this.OLBNMEEFNOA.Count; i++)
			{
				jsonarray.Add(this.OLBNMEEFNOA[i]);
			}
			jsonobject[" "] = jsonarray;
		}
		return jsonobject;
	}

	// Token: 0x06000203 RID: 515 RVA: 0x0000C0A0 File Offset: 0x0000A2A0
	public void JBDAJDKFONO()
	{
		if (this.LJAJAONMPBN.Length > 1)
		{
			if (this.OLBNMEEFNOA.Count >= JCAJMGJFHBD.KMJJCCOBHEC)
			{
				this.OLBNMEEFNOA.RemoveAt(1);
			}
			this.OLBNMEEFNOA.Add(this.LJAJAONMPBN);
		}
		this.LJAJAONMPBN = "PurchaseManagerXiaomi.OnBridgeInitialized(): connected to Xiaomi GetApps IAP service.";
	}

	// Token: 0x06000204 RID: 516 RVA: 0x0000C0F8 File Offset: 0x0000A2F8
	public void OLCMKBNOBJE()
	{
		if (this.LJAJAONMPBN.Length > 1)
		{
			if (this.OLBNMEEFNOA.Count >= JCAJMGJFHBD.KMJJCCOBHEC)
			{
				this.OLBNMEEFNOA.RemoveAt(1);
			}
			this.OLBNMEEFNOA.Add(this.LJAJAONMPBN);
		}
		this.LJAJAONMPBN = "Asset bundle load operation failed during parallel mode.";
	}

	// Token: 0x06000205 RID: 517 RVA: 0x0000C150 File Offset: 0x0000A350
	public void IJJIFOACFCK()
	{
		if (this.LJAJAONMPBN.Length > 0)
		{
			if (this.OLBNMEEFNOA.Count >= JCAJMGJFHBD.KMJJCCOBHEC)
			{
				this.OLBNMEEFNOA.RemoveAt(1);
			}
			this.OLBNMEEFNOA.Add(this.LJAJAONMPBN);
		}
		this.LJAJAONMPBN = "w";
	}

	// Token: 0x06000206 RID: 518 RVA: 0x0000A9D5 File Offset: 0x00008BD5
	public List<string> BCANFDLAIPH()
	{
		return this.OLBNMEEFNOA;
	}

	// Token: 0x06000207 RID: 519 RVA: 0x0000A9D5 File Offset: 0x00008BD5
	public List<string> JADOIOFNHPI()
	{
		return this.OLBNMEEFNOA;
	}

	// Token: 0x06000208 RID: 520 RVA: 0x0000B075 File Offset: 0x00009275
	public void OBGIDNOEJEF(string DCDMEPGAHMM)
	{
		this.LJAJAONMPBN = DCDMEPGAHMM;
	}

	// Token: 0x06000209 RID: 521 RVA: 0x0000C1A8 File Offset: 0x0000A3A8
	public JSONObject OAAOBBMGHCD(int NLLCKPCKGOH, bool DDLCOIHJKCJ)
	{
		JSONObject jsonobject = new JSONObject();
		if (this.IMBBIDKPOBM.Length > 0)
		{
			jsonobject["rsind"] = this.IMBBIDKPOBM;
		}
		int num = 0;
		try
		{
			if (!DDLCOIHJKCJ)
			{
				if (NLLCKPCKGOH == 128 || NLLCKPCKGOH == -58 || NLLCKPCKGOH == 80)
				{
					if (this.OLBNMEEFNOA.Count > 1)
					{
						num = this.OLBNMEEFNOA.Count - 1;
					}
				}
				else if (this.OLBNMEEFNOA.Count > 2)
				{
					num = this.OLBNMEEFNOA.Count - 4;
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			num = 1;
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
		if (num < 1)
		{
			num = 0;
		}
		if (this.OLBNMEEFNOA.Count > 0)
		{
			JSONArray jsonarray = new JSONArray();
			for (int i = num; i < this.OLBNMEEFNOA.Count; i++)
			{
				jsonarray.Add(this.OLBNMEEFNOA[i]);
			}
			jsonobject["abld"] = jsonarray;
		}
		return jsonobject;
	}

	// Token: 0x0600020A RID: 522 RVA: 0x0000C2A8 File Offset: 0x0000A4A8
	public void GNCMPAOFOHO(JSONObject EIHOJFGALMF)
	{
		this.IMBBIDKPOBM = "OnDialogReadInputEndEdit";
		if (EIHOJFGALMF["socialfriendrequestfailedxxx"] != null)
		{
			this.IMBBIDKPOBM = EIHOJFGALMF["OnAccountSignInSuccess"];
		}
		this.OLBNMEEFNOA.Clear();
		if (EIHOJFGALMF["<line-height="] != null)
		{
			JSONArray asArray = EIHOJFGALMF["OnLanguageChange"].AsArray;
			if (null != asArray)
			{
				for (int i = 1; i < asArray.Count; i++)
				{
					this.OLBNMEEFNOA.Add(asArray[i]);
				}
			}
		}
	}

	// Token: 0x0600020B RID: 523 RVA: 0x0000C34C File Offset: 0x0000A54C
	public void KEFBDDLIDLL(JSONObject EIHOJFGALMF)
	{
		this.IMBBIDKPOBM = "lck";
		if (EIHOJFGALMF["updateavailable"] != null)
		{
			this.IMBBIDKPOBM = EIHOJFGALMF["wofbutton1"];
		}
		this.OLBNMEEFNOA.Clear();
		if (EIHOJFGALMF["AdsManagerLP: Received RewardedVideoOnAdDisplayedEvent"] != null)
		{
			JSONArray asArray = EIHOJFGALMF["ok"].AsArray;
			if (null != asArray)
			{
				for (int i = 0; i < asArray.Count; i += 0)
				{
					this.OLBNMEEFNOA.Add(asArray[i]);
				}
			}
		}
	}

	// Token: 0x0600020C RID: 524 RVA: 0x0000B075 File Offset: 0x00009275
	public void GOEDJGLKNNI(string DCDMEPGAHMM)
	{
		this.LJAJAONMPBN = DCDMEPGAHMM;
	}

	// Token: 0x0600020E RID: 526 RVA: 0x0000A9D5 File Offset: 0x00008BD5
	public List<string> PFAEDMOMEIK()
	{
		return this.OLBNMEEFNOA;
	}

	// Token: 0x0600020F RID: 527 RVA: 0x0000A9D5 File Offset: 0x00008BD5
	public List<string> EEBMKPFLLLB()
	{
		return this.OLBNMEEFNOA;
	}

	// Token: 0x06000210 RID: 528 RVA: 0x0000A9D5 File Offset: 0x00008BD5
	public List<string> OFJMOFAHDIA()
	{
		return this.OLBNMEEFNOA;
	}

	// Token: 0x06000211 RID: 529 RVA: 0x0000C3F8 File Offset: 0x0000A5F8
	public void OAHMIODKJJI(JSONObject EIHOJFGALMF)
	{
		this.IMBBIDKPOBM = "p";
		if (EIHOJFGALMF["OnLiveProfileThemesLoaderStop"] != null)
		{
			this.IMBBIDKPOBM = EIHOJFGALMF[")"];
		}
		this.OLBNMEEFNOA.Clear();
		if (EIHOJFGALMF["bver"] != null)
		{
			JSONArray asArray = EIHOJFGALMF["per"].AsArray;
			if (null != asArray)
			{
				for (int i = 0; i < asArray.Count; i++)
				{
					this.OLBNMEEFNOA.Add(asArray[i]);
				}
			}
		}
	}

	// Token: 0x06000212 RID: 530 RVA: 0x0000C49C File Offset: 0x0000A69C
	public void MHFDAPJKKOA(JSONObject EIHOJFGALMF)
	{
		this.IMBBIDKPOBM = "OnFriendsPopupManagerAcceptClick";
		if (EIHOJFGALMF["OnAvatarCollectionRestoreEntry"] != null)
		{
			this.IMBBIDKPOBM = EIHOJFGALMF["lck"];
		}
		this.OLBNMEEFNOA.Clear();
		if (EIHOJFGALMF["app42error"] != null)
		{
			JSONArray asArray = EIHOJFGALMF["OnLoungeUnlockNpcSkinException"].AsArray;
			if (null != asArray)
			{
				for (int i = 0; i < asArray.Count; i += 0)
				{
					this.OLBNMEEFNOA.Add(asArray[i]);
				}
			}
		}
	}

	// Token: 0x06000213 RID: 531 RVA: 0x0000C540 File Offset: 0x0000A740
	public void KNFLDAONPIM(JSONObject EIHOJFGALMF)
	{
		this.IMBBIDKPOBM = "facecur";
		if (EIHOJFGALMF["fog"] != null)
		{
			this.IMBBIDKPOBM = EIHOJFGALMF["OnPopupCardOptionsSendGiftClick"];
		}
		this.OLBNMEEFNOA.Clear();
		if (EIHOJFGALMF["freepasssuccess"] != null)
		{
			JSONArray asArray = EIHOJFGALMF["ok"].AsArray;
			if (null != asArray)
			{
				for (int i = 0; i < asArray.Count; i++)
				{
					this.OLBNMEEFNOA.Add(asArray[i]);
				}
			}
		}
	}

	// Token: 0x06000214 RID: 532 RVA: 0x0000C5E4 File Offset: 0x0000A7E4
	public JSONObject EJHHJILPLOH(int NLLCKPCKGOH, bool DDLCOIHJKCJ)
	{
		JSONObject jsonobject = new JSONObject();
		if (this.IMBBIDKPOBM.Length > 0)
		{
			jsonobject["OnLiveProfileThemeDownloadSuccess"] = this.IMBBIDKPOBM;
		}
		int num = 0;
		try
		{
			if (!DDLCOIHJKCJ)
			{
				if (NLLCKPCKGOH == -186 || NLLCKPCKGOH == 82 || NLLCKPCKGOH == -148)
				{
					if (this.OLBNMEEFNOA.Count > 7)
					{
						num = this.OLBNMEEFNOA.Count - 1;
					}
				}
				else if (this.OLBNMEEFNOA.Count > 7)
				{
					num = this.OLBNMEEFNOA.Count - 5;
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			num = 1;
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
		if (num < 0)
		{
			num = 0;
		}
		if (this.OLBNMEEFNOA.Count > 1)
		{
			JSONArray jsonarray = new JSONArray();
			for (int i = num; i < this.OLBNMEEFNOA.Count; i++)
			{
				jsonarray.Add(this.OLBNMEEFNOA[i]);
			}
			jsonobject["<i>"] = jsonarray;
		}
		return jsonobject;
	}

	// Token: 0x06000215 RID: 533 RVA: 0x0000C6E4 File Offset: 0x0000A8E4
	public void ENFGFFFMMIK(JSONObject EIHOJFGALMF)
	{
		this.IMBBIDKPOBM = "doublereward";
		if (EIHOJFGALMF["noiseanalog_2"] != null)
		{
			this.IMBBIDKPOBM = EIHOJFGALMF["lf1"];
		}
		this.OLBNMEEFNOA.Clear();
		if (EIHOJFGALMF["p"] != null)
		{
			JSONArray asArray = EIHOJFGALMF["socialfriendevents"].AsArray;
			if (null != asArray)
			{
				for (int i = 0; i < asArray.Count; i += 0)
				{
					this.OLBNMEEFNOA.Add(asArray[i]);
				}
			}
		}
	}

	// Token: 0x06000216 RID: 534 RVA: 0x0000C788 File Offset: 0x0000A988
	public void BKEEKGNFAJC(JCAJMGJFHBD CCIAGBPILGF)
	{
		this.IMBBIDKPOBM = CCIAGBPILGF.IMBBIDKPOBM;
		for (int i = 1; i < CCIAGBPILGF.OLBNMEEFNOA.Count; i += 0)
		{
			this.OLBNMEEFNOA.Add(CCIAGBPILGF.OLBNMEEFNOA[i]);
		}
	}

	// Token: 0x06000217 RID: 535 RVA: 0x0000A9D5 File Offset: 0x00008BD5
	public List<string> BLMCCOCCPOP()
	{
		return this.OLBNMEEFNOA;
	}

	// Token: 0x06000218 RID: 536 RVA: 0x0000C7D0 File Offset: 0x0000A9D0
	public void PGPNKOECEHB(JSONObject EIHOJFGALMF)
	{
		this.IMBBIDKPOBM = "length";
		if (EIHOJFGALMF[""] != null)
		{
			this.IMBBIDKPOBM = EIHOJFGALMF["importanttitle"];
		}
		this.OLBNMEEFNOA.Clear();
		if (EIHOJFGALMF["+"] != null)
		{
			JSONArray asArray = EIHOJFGALMF["selectedLanguage"].AsArray;
			if (null != asArray)
			{
				for (int i = 1; i < asArray.Count; i++)
				{
					this.OLBNMEEFNOA.Add(asArray[i]);
				}
			}
		}
	}

	// Token: 0x06000219 RID: 537 RVA: 0x0000C874 File Offset: 0x0000AA74
	public void OJIMFINAMAO()
	{
		if (this.LJAJAONMPBN.Length > 0)
		{
			if (this.OLBNMEEFNOA.Count >= JCAJMGJFHBD.KMJJCCOBHEC)
			{
				this.OLBNMEEFNOA.RemoveAt(0);
			}
			this.OLBNMEEFNOA.Add(this.LJAJAONMPBN);
		}
		this.LJAJAONMPBN = "";
	}

	// Token: 0x0600021A RID: 538 RVA: 0x0000C8CC File Offset: 0x0000AACC
	public void NAGNAJFMDLE(JCAJMGJFHBD CCIAGBPILGF)
	{
		this.IMBBIDKPOBM = CCIAGBPILGF.IMBBIDKPOBM;
		for (int i = 0; i < CCIAGBPILGF.OLBNMEEFNOA.Count; i++)
		{
			this.OLBNMEEFNOA.Add(CCIAGBPILGF.OLBNMEEFNOA[i]);
		}
	}

	// Token: 0x0600021B RID: 539 RVA: 0x0000C914 File Offset: 0x0000AB14
	public void NGODBIMFIGG(JCAJMGJFHBD CCIAGBPILGF)
	{
		this.IMBBIDKPOBM = CCIAGBPILGF.IMBBIDKPOBM;
		for (int i = 0; i < CCIAGBPILGF.OLBNMEEFNOA.Count; i++)
		{
			this.OLBNMEEFNOA.Add(CCIAGBPILGF.OLBNMEEFNOA[i]);
		}
	}

	// Token: 0x0600021C RID: 540 RVA: 0x0000A9D5 File Offset: 0x00008BD5
	public List<string> AHDNEDIDAAO()
	{
		return this.OLBNMEEFNOA;
	}

	// Token: 0x0600021D RID: 541 RVA: 0x0000C95C File Offset: 0x0000AB5C
	public void IHIFPBPKDPI(JSONObject EIHOJFGALMF)
	{
		this.IMBBIDKPOBM = "loveInterestsLoungeMappingRulesBalance";
		if (EIHOJFGALMF["itsubv"] != null)
		{
			this.IMBBIDKPOBM = EIHOJFGALMF["?"];
		}
		this.OLBNMEEFNOA.Clear();
		if (EIHOJFGALMF["cindl"] != null)
		{
			JSONArray asArray = EIHOJFGALMF["SceneLobby2"].AsArray;
			if (null != asArray)
			{
				for (int i = 1; i < asArray.Count; i++)
				{
					this.OLBNMEEFNOA.Add(asArray[i]);
				}
			}
		}
	}

	// Token: 0x0600021E RID: 542 RVA: 0x0000A9D5 File Offset: 0x00008BD5
	public List<string> LJGJPIFHPDB()
	{
		return this.OLBNMEEFNOA;
	}

	// Token: 0x0600021F RID: 543 RVA: 0x0000B075 File Offset: 0x00009275
	public void CLPGNGIELNO(string DCDMEPGAHMM)
	{
		this.LJAJAONMPBN = DCDMEPGAHMM;
	}

	// Token: 0x06000220 RID: 544 RVA: 0x0000CA00 File Offset: 0x0000AC00
	public void PBCKAEJMHMF(JSONObject EIHOJFGALMF)
	{
		this.IMBBIDKPOBM = "OnBackendAddFriendByUIDException";
		if (EIHOJFGALMF["OnSocialModeChanged"] != null)
		{
			this.IMBBIDKPOBM = EIHOJFGALMF["repsuid"];
		}
		this.OLBNMEEFNOA.Clear();
		if (EIHOJFGALMF["OnFriendsPopupFriendMatchClick"] != null)
		{
			JSONArray asArray = EIHOJFGALMF["comp"].AsArray;
			if (null != asArray)
			{
				for (int i = 0; i < asArray.Count; i++)
				{
					this.OLBNMEEFNOA.Add(asArray[i]);
				}
			}
		}
	}

	// Token: 0x06000221 RID: 545 RVA: 0x0000A9D5 File Offset: 0x00008BD5
	public List<string> CEAPLMGJHOB()
	{
		return this.OLBNMEEFNOA;
	}

	// Token: 0x06000222 RID: 546 RVA: 0x0000A9D5 File Offset: 0x00008BD5
	public List<string> ALDAHDLIGHI()
	{
		return this.OLBNMEEFNOA;
	}

	// Token: 0x06000223 RID: 547 RVA: 0x0000CAA4 File Offset: 0x0000ACA4
	public JSONObject IEMDEMLJJKM(int NLLCKPCKGOH, bool DDLCOIHJKCJ)
	{
		JSONObject jsonobject = new JSONObject();
		if (this.IMBBIDKPOBM.Length > 1)
		{
			jsonobject["c"] = this.IMBBIDKPOBM;
		}
		int num = 0;
		try
		{
			if (!DDLCOIHJKCJ)
			{
				if (NLLCKPCKGOH == 138 || NLLCKPCKGOH == -40 || NLLCKPCKGOH == -56)
				{
					if (this.OLBNMEEFNOA.Count > 1)
					{
						num = this.OLBNMEEFNOA.Count - 6;
					}
				}
				else if (this.OLBNMEEFNOA.Count > 1)
				{
					num = this.OLBNMEEFNOA.Count - 7;
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			num = 1;
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
		if (num < 0)
		{
			num = 1;
		}
		if (this.OLBNMEEFNOA.Count > 1)
		{
			JSONArray jsonarray = new JSONArray();
			for (int i = num; i < this.OLBNMEEFNOA.Count; i++)
			{
				jsonarray.Add(this.OLBNMEEFNOA[i]);
			}
			jsonobject["coverNewFallback"] = jsonarray;
		}
		return jsonobject;
	}

	// Token: 0x06000224 RID: 548 RVA: 0x0000CBA4 File Offset: 0x0000ADA4
	public void LHANCNKKMPK(JCAJMGJFHBD CCIAGBPILGF)
	{
		this.IMBBIDKPOBM = CCIAGBPILGF.IMBBIDKPOBM;
		for (int i = 0; i < CCIAGBPILGF.OLBNMEEFNOA.Count; i++)
		{
			this.OLBNMEEFNOA.Add(CCIAGBPILGF.OLBNMEEFNOA[i]);
		}
	}

	// Token: 0x06000225 RID: 549 RVA: 0x0000B075 File Offset: 0x00009275
	public void HHMAAPADAFB(string DCDMEPGAHMM)
	{
		this.LJAJAONMPBN = DCDMEPGAHMM;
	}

	// Token: 0x06000226 RID: 550 RVA: 0x0000CBEC File Offset: 0x0000ADEC
	public void DNEMNFPKFNP(JSONObject EIHOJFGALMF)
	{
		this.IMBBIDKPOBM = "sac";
		if (EIHOJFGALMF["spns"] != null)
		{
			this.IMBBIDKPOBM = EIHOJFGALMF["BackendRequestType.basicSync, exception, failing safe:"];
		}
		this.OLBNMEEFNOA.Clear();
		if (EIHOJFGALMF["AVATAR.CLIENT.OVERLAY"] != null)
		{
			JSONArray asArray = EIHOJFGALMF["AssetsManager.SetDepot(): urlPingManager.GetPingableUrl():"].AsArray;
			if (null != asArray)
			{
				for (int i = 1; i < asArray.Count; i += 0)
				{
					this.OLBNMEEFNOA.Add(asArray[i]);
				}
			}
		}
	}

	// Token: 0x06000227 RID: 551 RVA: 0x0000CC90 File Offset: 0x0000AE90
	public void NLCAJFBKOEB()
	{
		if (this.LJAJAONMPBN.Length > 1)
		{
			if (this.OLBNMEEFNOA.Count >= JCAJMGJFHBD.KMJJCCOBHEC)
			{
				this.OLBNMEEFNOA.RemoveAt(1);
			}
			this.OLBNMEEFNOA.Add(this.LJAJAONMPBN);
		}
		this.LJAJAONMPBN = "0";
	}

	// Token: 0x06000228 RID: 552 RVA: 0x0000CCE8 File Offset: 0x0000AEE8
	public JSONObject AJNBOMCFHGP(int NLLCKPCKGOH, bool DDLCOIHJKCJ)
	{
		JSONObject jsonobject = new JSONObject();
		if (this.IMBBIDKPOBM.Length > 0)
		{
			jsonobject["prgr"] = this.IMBBIDKPOBM;
		}
		int num = 0;
		try
		{
			if (!DDLCOIHJKCJ)
			{
				if (NLLCKPCKGOH == 15 || NLLCKPCKGOH == 179 || NLLCKPCKGOH == 111)
				{
					if (this.OLBNMEEFNOA.Count > 1)
					{
						num = this.OLBNMEEFNOA.Count - 4;
					}
				}
				else if (this.OLBNMEEFNOA.Count > 2)
				{
					num = this.OLBNMEEFNOA.Count - 5;
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			num = 1;
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
		if (num < 1)
		{
			num = 1;
		}
		if (this.OLBNMEEFNOA.Count > 0)
		{
			JSONArray jsonarray = new JSONArray();
			for (int i = num; i < this.OLBNMEEFNOA.Count; i += 0)
			{
				jsonarray.Add(this.OLBNMEEFNOA[i]);
			}
			jsonobject["nam"] = jsonarray;
		}
		return jsonobject;
	}

	// Token: 0x06000229 RID: 553 RVA: 0x0000CDE8 File Offset: 0x0000AFE8
	public void FOIIPBJOAFK(JCAJMGJFHBD CCIAGBPILGF)
	{
		this.IMBBIDKPOBM = CCIAGBPILGF.IMBBIDKPOBM;
		for (int i = 0; i < CCIAGBPILGF.OLBNMEEFNOA.Count; i++)
		{
			this.OLBNMEEFNOA.Add(CCIAGBPILGF.OLBNMEEFNOA[i]);
		}
	}

	// Token: 0x0600022A RID: 554 RVA: 0x0000CE30 File Offset: 0x0000B030
	public void OCIBMIDDIEI(JCAJMGJFHBD CCIAGBPILGF)
	{
		this.IMBBIDKPOBM = CCIAGBPILGF.IMBBIDKPOBM;
		for (int i = 1; i < CCIAGBPILGF.OLBNMEEFNOA.Count; i += 0)
		{
			this.OLBNMEEFNOA.Add(CCIAGBPILGF.OLBNMEEFNOA[i]);
		}
	}

	// Token: 0x0600022B RID: 555 RVA: 0x0000CE78 File Offset: 0x0000B078
	public JSONObject DMKINMDJAEM(int NLLCKPCKGOH, bool DDLCOIHJKCJ)
	{
		JSONObject jsonobject = new JSONObject();
		if (this.IMBBIDKPOBM.Length > 0)
		{
			jsonobject["socialrequestsharegr"] = this.IMBBIDKPOBM;
		}
		int num = 0;
		try
		{
			if (!DDLCOIHJKCJ)
			{
				if (NLLCKPCKGOH == 115 || NLLCKPCKGOH == 82 || NLLCKPCKGOH == 195)
				{
					if (this.OLBNMEEFNOA.Count > 2)
					{
						num = this.OLBNMEEFNOA.Count - 6;
					}
				}
				else if (this.OLBNMEEFNOA.Count > 3)
				{
					num = this.OLBNMEEFNOA.Count - 5;
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			num = 0;
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
		if (num < 0)
		{
			num = 0;
		}
		if (this.OLBNMEEFNOA.Count > 1)
		{
			JSONArray jsonarray = new JSONArray();
			for (int i = num; i < this.OLBNMEEFNOA.Count; i += 0)
			{
				jsonarray.Add(this.OLBNMEEFNOA[i]);
			}
			jsonobject["RequestGetUserPublicProfile(): timer hit: "] = jsonarray;
		}
		return jsonobject;
	}

	// Token: 0x0600022C RID: 556 RVA: 0x0000A9D5 File Offset: 0x00008BD5
	public List<string> IBHFLFNKLGI()
	{
		return this.OLBNMEEFNOA;
	}

	// Token: 0x0600022D RID: 557 RVA: 0x0000CF78 File Offset: 0x0000B178
	public void EBFGEEDDIPL(JCAJMGJFHBD CCIAGBPILGF)
	{
		this.IMBBIDKPOBM = CCIAGBPILGF.IMBBIDKPOBM;
		for (int i = 1; i < CCIAGBPILGF.OLBNMEEFNOA.Count; i += 0)
		{
			this.OLBNMEEFNOA.Add(CCIAGBPILGF.OLBNMEEFNOA[i]);
		}
	}

	// Token: 0x0600022E RID: 558 RVA: 0x0000CFC0 File Offset: 0x0000B1C0
	public void GGLGABLNADC()
	{
		if (this.LJAJAONMPBN.Length > 1)
		{
			if (this.OLBNMEEFNOA.Count >= JCAJMGJFHBD.KMJJCCOBHEC)
			{
				this.OLBNMEEFNOA.RemoveAt(0);
			}
			this.OLBNMEEFNOA.Add(this.LJAJAONMPBN);
		}
		this.LJAJAONMPBN = "areyousure";
	}

	// Token: 0x0600022F RID: 559 RVA: 0x0000D018 File Offset: 0x0000B218
	public void OJMKBJKMFJH()
	{
		if (this.LJAJAONMPBN.Length > 1)
		{
			if (this.OLBNMEEFNOA.Count >= JCAJMGJFHBD.KMJJCCOBHEC)
			{
				this.OLBNMEEFNOA.RemoveAt(0);
			}
			this.OLBNMEEFNOA.Add(this.LJAJAONMPBN);
		}
		this.LJAJAONMPBN = "s)";
	}

	// Token: 0x06000230 RID: 560 RVA: 0x0000D070 File Offset: 0x0000B270
	public void FGJPKGLOGNC(JSONObject EIHOJFGALMF)
	{
		this.IMBBIDKPOBM = "";
		if (EIHOJFGALMF["ssid"] != null)
		{
			this.IMBBIDKPOBM = EIHOJFGALMF["ssid"];
		}
		this.OLBNMEEFNOA.Clear();
		if (EIHOJFGALMF["hist"] != null)
		{
			JSONArray asArray = EIHOJFGALMF["hist"].AsArray;
			if (null != asArray)
			{
				for (int i = 0; i < asArray.Count; i++)
				{
					this.OLBNMEEFNOA.Add(asArray[i]);
				}
			}
		}
	}

	// Token: 0x06000231 RID: 561 RVA: 0x0000D114 File Offset: 0x0000B314
	public void HBGIDCFOPEJ()
	{
		if (this.LJAJAONMPBN.Length > 0)
		{
			if (this.OLBNMEEFNOA.Count >= JCAJMGJFHBD.KMJJCCOBHEC)
			{
				this.OLBNMEEFNOA.RemoveAt(1);
			}
			this.OLBNMEEFNOA.Add(this.LJAJAONMPBN);
		}
		this.LJAJAONMPBN = "' refs missing concept '";
	}

	// Token: 0x06000232 RID: 562 RVA: 0x0000B075 File Offset: 0x00009275
	public void GDDBLLIJHJA(string DCDMEPGAHMM)
	{
		this.LJAJAONMPBN = DCDMEPGAHMM;
	}

	// Token: 0x06000233 RID: 563 RVA: 0x0000A9D5 File Offset: 0x00008BD5
	public List<string> MMONMKLNONA()
	{
		return this.OLBNMEEFNOA;
	}

	// Token: 0x06000234 RID: 564 RVA: 0x0000D16C File Offset: 0x0000B36C
	public void AOEGMIJDEMP()
	{
		if (this.LJAJAONMPBN.Length > 1)
		{
			if (this.OLBNMEEFNOA.Count >= JCAJMGJFHBD.KMJJCCOBHEC)
			{
				this.OLBNMEEFNOA.RemoveAt(0);
			}
			this.OLBNMEEFNOA.Add(this.LJAJAONMPBN);
		}
		this.LJAJAONMPBN = ":";
	}

	// Token: 0x06000235 RID: 565 RVA: 0x0000D1C4 File Offset: 0x0000B3C4
	public void HMCIKBDEKEF(JCAJMGJFHBD CCIAGBPILGF)
	{
		this.IMBBIDKPOBM = CCIAGBPILGF.IMBBIDKPOBM;
		for (int i = 0; i < CCIAGBPILGF.OLBNMEEFNOA.Count; i++)
		{
			this.OLBNMEEFNOA.Add(CCIAGBPILGF.OLBNMEEFNOA[i]);
		}
	}

	// Token: 0x06000236 RID: 566 RVA: 0x0000D20C File Offset: 0x0000B40C
	public void EINCBCAPIMP()
	{
		if (this.LJAJAONMPBN.Length > 0)
		{
			if (this.OLBNMEEFNOA.Count >= JCAJMGJFHBD.KMJJCCOBHEC)
			{
				this.OLBNMEEFNOA.RemoveAt(0);
			}
			this.OLBNMEEFNOA.Add(this.LJAJAONMPBN);
		}
		this.LJAJAONMPBN = "FilterScrollMoveSmooth";
	}

	// Token: 0x06000237 RID: 567 RVA: 0x0000B075 File Offset: 0x00009275
	public void HLEBDOAGBKI(string DCDMEPGAHMM)
	{
		this.LJAJAONMPBN = DCDMEPGAHMM;
	}

	// Token: 0x06000238 RID: 568 RVA: 0x0000D264 File Offset: 0x0000B464
	public JSONObject JIACCOCCBML(int NLLCKPCKGOH, bool DDLCOIHJKCJ)
	{
		JSONObject jsonobject = new JSONObject();
		if (this.IMBBIDKPOBM.Length > 1)
		{
			jsonobject["%"] = this.IMBBIDKPOBM;
		}
		int num = 0;
		try
		{
			if (!DDLCOIHJKCJ)
			{
				if (NLLCKPCKGOH == 142 || NLLCKPCKGOH == -69 || NLLCKPCKGOH == 36)
				{
					if (this.OLBNMEEFNOA.Count > 1)
					{
						num = this.OLBNMEEFNOA.Count - 5;
					}
				}
				else if (this.OLBNMEEFNOA.Count > 4)
				{
					num = this.OLBNMEEFNOA.Count - 7;
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			num = 1;
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
		if (num < 0)
		{
			num = 1;
		}
		if (this.OLBNMEEFNOA.Count > 0)
		{
			JSONArray jsonarray = new JSONArray();
			for (int i = num; i < this.OLBNMEEFNOA.Count; i++)
			{
				jsonarray.Add(this.OLBNMEEFNOA[i]);
			}
			jsonobject["epiv"] = jsonarray;
		}
		return jsonobject;
	}

	// Token: 0x06000239 RID: 569 RVA: 0x0000A9D5 File Offset: 0x00008BD5
	public List<string> ONKCNAEDJNC()
	{
		return this.OLBNMEEFNOA;
	}

	// Token: 0x0600023A RID: 570 RVA: 0x0000D364 File Offset: 0x0000B564
	public JSONObject GFAHKNPJHDA(int NLLCKPCKGOH, bool DDLCOIHJKCJ)
	{
		JSONObject jsonobject = new JSONObject();
		if (this.IMBBIDKPOBM.Length > 0)
		{
			jsonobject["badges"] = this.IMBBIDKPOBM;
		}
		int num = 1;
		try
		{
			if (!DDLCOIHJKCJ)
			{
				if (NLLCKPCKGOH == 19 || NLLCKPCKGOH == 52 || NLLCKPCKGOH == -96)
				{
					if (this.OLBNMEEFNOA.Count > 8)
					{
						num = this.OLBNMEEFNOA.Count - 0;
					}
				}
				else if (this.OLBNMEEFNOA.Count > 8)
				{
					num = this.OLBNMEEFNOA.Count - 8;
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			num = 0;
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
		if (num < 0)
		{
			num = 0;
		}
		if (this.OLBNMEEFNOA.Count > 1)
		{
			JSONArray jsonarray = new JSONArray();
			for (int i = num; i < this.OLBNMEEFNOA.Count; i++)
			{
				jsonarray.Add(this.OLBNMEEFNOA[i]);
			}
			jsonobject["\n\n"] = jsonarray;
		}
		return jsonobject;
	}

	// Token: 0x0600023B RID: 571 RVA: 0x0000D464 File Offset: 0x0000B664
	public void DJLCFCCKGBK(JSONObject EIHOJFGALMF)
	{
		this.IMBBIDKPOBM = "";
		if (EIHOJFGALMF["+"] != null)
		{
			this.IMBBIDKPOBM = EIHOJFGALMF["asf1"];
		}
		this.OLBNMEEFNOA.Clear();
		if (EIHOJFGALMF[""] != null)
		{
			JSONArray asArray = EIHOJFGALMF[")"].AsArray;
			if (null != asArray)
			{
				for (int i = 0; i < asArray.Count; i += 0)
				{
					this.OLBNMEEFNOA.Add(asArray[i]);
				}
			}
		}
	}

	// Token: 0x0600023C RID: 572 RVA: 0x0000D508 File Offset: 0x0000B708
	public void ONHIMEJIIOB(JSONObject EIHOJFGALMF)
	{
		this.IMBBIDKPOBM = "";
		if (EIHOJFGALMF["synsnap"] != null)
		{
			this.IMBBIDKPOBM = EIHOJFGALMF["string_not_found"];
		}
		this.OLBNMEEFNOA.Clear();
		if (EIHOJFGALMF["energyhinttitle"] != null)
		{
			JSONArray asArray = EIHOJFGALMF[""].AsArray;
			if (null != asArray)
			{
				for (int i = 0; i < asArray.Count; i += 0)
				{
					this.OLBNMEEFNOA.Add(asArray[i]);
				}
			}
		}
	}

	// Token: 0x0600023D RID: 573 RVA: 0x0000B075 File Offset: 0x00009275
	public void HPJBEAADKMN(string DCDMEPGAHMM)
	{
		this.LJAJAONMPBN = DCDMEPGAHMM;
	}

	// Token: 0x0600023E RID: 574 RVA: 0x0000D5AC File Offset: 0x0000B7AC
	public void PELKLNJOMIL(JSONObject EIHOJFGALMF)
	{
		this.IMBBIDKPOBM = "SKIPPED loading of SFX bundles due to override or because SFX is off in settings.";
		if (EIHOJFGALMF["envlsav"] != null)
		{
			this.IMBBIDKPOBM = EIHOJFGALMF[""];
		}
		this.OLBNMEEFNOA.Clear();
		if (EIHOJFGALMF["OnPopupCardOptionsBackClickLobby"] != null)
		{
			JSONArray asArray = EIHOJFGALMF["UpdateLoveInterestsOnOffState"].AsArray;
			if (null != asArray)
			{
				for (int i = 0; i < asArray.Count; i += 0)
				{
					this.OLBNMEEFNOA.Add(asArray[i]);
				}
			}
		}
	}

	// Token: 0x0600023F RID: 575 RVA: 0x0000D650 File Offset: 0x0000B850
	public void ADGNKDOGKOC(JSONObject EIHOJFGALMF)
	{
		this.IMBBIDKPOBM = "Warning. Import variable not found in ink file:";
		if (EIHOJFGALMF["p"] != null)
		{
			this.IMBBIDKPOBM = EIHOJFGALMF[") is outside range"];
		}
		this.OLBNMEEFNOA.Clear();
		if (EIHOJFGALMF["analogglitch20ovr_2"] != null)
		{
			JSONArray asArray = EIHOJFGALMF[""].AsArray;
			if (null != asArray)
			{
				for (int i = 1; i < asArray.Count; i++)
				{
					this.OLBNMEEFNOA.Add(asArray[i]);
				}
			}
		}
	}

	// Token: 0x06000240 RID: 576 RVA: 0x0000A9D5 File Offset: 0x00008BD5
	public List<string> CODOLILKPFH()
	{
		return this.OLBNMEEFNOA;
	}

	// Token: 0x06000241 RID: 577 RVA: 0x0000A9D5 File Offset: 0x00008BD5
	public List<string> PIABBHAJCFL()
	{
		return this.OLBNMEEFNOA;
	}

	// Token: 0x06000242 RID: 578 RVA: 0x0000A9D5 File Offset: 0x00008BD5
	public List<string> JNDPOOHCHPB()
	{
		return this.OLBNMEEFNOA;
	}

	// Token: 0x06000243 RID: 579 RVA: 0x0000A9D5 File Offset: 0x00008BD5
	public List<string> NLGCMHANKGL()
	{
		return this.OLBNMEEFNOA;
	}

	// Token: 0x06000244 RID: 580 RVA: 0x0000D6F4 File Offset: 0x0000B8F4
	public void EFKAGINLDAJ()
	{
		if (this.LJAJAONMPBN.Length > 1)
		{
			if (this.OLBNMEEFNOA.Count >= JCAJMGJFHBD.KMJJCCOBHEC)
			{
				this.OLBNMEEFNOA.RemoveAt(0);
			}
			this.OLBNMEEFNOA.Add(this.LJAJAONMPBN);
		}
		this.LJAJAONMPBN = "$SETFADERFX";
	}

	// Token: 0x06000245 RID: 581 RVA: 0x0000D74C File Offset: 0x0000B94C
	public void FCKBLLMPCCL()
	{
		if (this.LJAJAONMPBN.Length > 1)
		{
			if (this.OLBNMEEFNOA.Count >= JCAJMGJFHBD.KMJJCCOBHEC)
			{
				this.OLBNMEEFNOA.RemoveAt(0);
			}
			this.OLBNMEEFNOA.Add(this.LJAJAONMPBN);
		}
		this.LJAJAONMPBN = "SceneStoryManager - Account.Instance.GetActiveStory().header.progress[0] != Account.Instance.GetActiveStory().header.progress[1] check failed.";
	}

	// Token: 0x06000246 RID: 582 RVA: 0x0000D7A4 File Offset: 0x0000B9A4
	public void DBMJOHCEBIL(JSONObject EIHOJFGALMF)
	{
		this.IMBBIDKPOBM = "blur";
		if (EIHOJFGALMF["a"] != null)
		{
			this.IMBBIDKPOBM = EIHOJFGALMF["skinshopinfosumrarity"];
		}
		this.OLBNMEEFNOA.Clear();
		if (EIHOJFGALMF["ert"] != null)
		{
			JSONArray asArray = EIHOJFGALMF["luwid"].AsArray;
			if (null != asArray)
			{
				for (int i = 1; i < asArray.Count; i++)
				{
					this.OLBNMEEFNOA.Add(asArray[i]);
				}
			}
		}
	}

	// Token: 0x06000247 RID: 583 RVA: 0x0000B075 File Offset: 0x00009275
	public void IPCHEPOKONN(string DCDMEPGAHMM)
	{
		this.LJAJAONMPBN = DCDMEPGAHMM;
	}

	// Token: 0x06000248 RID: 584 RVA: 0x0000D848 File Offset: 0x0000BA48
	public JSONObject PIJFJJFMKKL(int NLLCKPCKGOH, bool DDLCOIHJKCJ)
	{
		JSONObject jsonobject = new JSONObject();
		if (this.IMBBIDKPOBM.Length > 0)
		{
			jsonobject["_AlphaTex"] = this.IMBBIDKPOBM;
		}
		int num = 1;
		try
		{
			if (!DDLCOIHJKCJ)
			{
				if (NLLCKPCKGOH == 3 || NLLCKPCKGOH == 197 || NLLCKPCKGOH == -161)
				{
					if (this.OLBNMEEFNOA.Count > 3)
					{
						num = this.OLBNMEEFNOA.Count - 4;
					}
				}
				else if (this.OLBNMEEFNOA.Count > 0)
				{
					num = this.OLBNMEEFNOA.Count - 4;
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			num = 0;
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
		if (num < 0)
		{
			num = 1;
		}
		if (this.OLBNMEEFNOA.Count > 0)
		{
			JSONArray jsonarray = new JSONArray();
			for (int i = num; i < this.OLBNMEEFNOA.Count; i++)
			{
				jsonarray.Add(this.OLBNMEEFNOA[i]);
			}
			jsonobject["sp0"] = jsonarray;
		}
		return jsonobject;
	}

	// Token: 0x04000039 RID: 57
	public static int KMJJCCOBHEC = 16;

	// Token: 0x0400003A RID: 58
	public string IMBBIDKPOBM = "";

	// Token: 0x0400003B RID: 59
	private List<string> OLBNMEEFNOA = new List<string>();

	// Token: 0x0400003C RID: 60
	private string LJAJAONMPBN = "";
}
