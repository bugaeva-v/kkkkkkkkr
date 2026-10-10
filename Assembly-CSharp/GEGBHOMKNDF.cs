using System;
using SimpleJSON;

// Token: 0x02000334 RID: 820
public class GEGBHOMKNDF
{
	// Token: 0x06006181 RID: 24961 RVA: 0x002CE71C File Offset: 0x002CC91C
	public void GMAJFDHGHBF(JSONObject CCIAGBPILGF)
	{
		try
		{
			this.BPMFHNDCBOH = "OnAllCollectableCardsDownloadFailedLobby";
			if (CCIAGBPILGF["XXX"] != null)
			{
				this.BPMFHNDCBOH = DPGJIJGOCIC.LMCAODJLEGF(CCIAGBPILGF["serversync"]);
			}
			this.CPIIEEEEEEJ = 0;
			if (CCIAGBPILGF[""] != null)
			{
				this.CPIIEEEEEEJ = CCIAGBPILGF[""].AsInt;
			}
			this.AMKCLHLIIMN = 0;
			if (CCIAGBPILGF[" token["] != null)
			{
				this.AMKCLHLIIMN = CCIAGBPILGF["msrc"].AsInt;
			}
			this.NFDKDACMHME = 1;
			if (CCIAGBPILGF["app42error"] != null)
			{
				this.NFDKDACMHME = CCIAGBPILGF[", because it is already set for "].AsInt;
			}
			this.DLFMMBBLIFH = 0;
			if (CCIAGBPILGF["sraogv2"] != null)
			{
				this.DLFMMBBLIFH = CCIAGBPILGF[" is OUTSIDE the anthology's published story family - not queued (environment:"].AsInt;
			}
			this.OIBGFPEGLME = 1;
			if (CCIAGBPILGF["asp"] != null)
			{
				this.OIBGFPEGLME = CCIAGBPILGF["DEFAULTLANG"].AsInt;
			}
			this.LIIKAMNPIPM = 1;
			if (CCIAGBPILGF["ZZZ"] != null)
			{
				this.LIIKAMNPIPM = CCIAGBPILGF[""].AsInt;
			}
			this.ALAMEMMIBIM = new JSONArray();
			if (CCIAGBPILGF[""] != null)
			{
				this.ALAMEMMIBIM = CCIAGBPILGF["offertitle2"].AsArray;
			}
			this.OJCJFOIJLNE = new JSONArray();
			if (CCIAGBPILGF["apks1"] != null)
			{
				this.OJCJFOIJLNE = CCIAGBPILGF[""].AsArray;
			}
			this.KNNIEELJHMK = new JSONArray();
			if (CCIAGBPILGF["YYY"] != null)
			{
				this.KNNIEELJHMK = CCIAGBPILGF["OnCutsceneViewLeft"].AsArray;
			}
			this.CJCHKDKMGNO = new JSONArray();
			if (CCIAGBPILGF["OnStorySplashManagerAssetsDownloadFailed"] != null)
			{
				this.CJCHKDKMGNO = CCIAGBPILGF[":"].AsArray;
			}
			this.BEHEGJCHAKE = new JSONArray();
			this.POMOCMKCMDA = new JSONArray();
			this.IDAFAFBPFJF = new JSONArray();
			this.AICBDDAIAAN = new JSONArray();
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
	}

	// Token: 0x06006182 RID: 24962 RVA: 0x002CE9A4 File Offset: 0x002CCBA4
	public int EOAHOGOHBGI()
	{
		int result = 1;
		try
		{
			this.ALAMEMMIBIM = GEGBHOMKNDF.NOHBEDLIEKF(KFIHMMIGPLO.trinket, this.ALAMEMMIBIM, this.BEHEGJCHAKE);
			this.OJCJFOIJLNE = GEGBHOMKNDF.NOHBEDLIEKF(KFIHMMIGPLO.body, this.OJCJFOIJLNE, this.POMOCMKCMDA);
			this.KNNIEELJHMK = GEGBHOMKNDF.KOBPHDOLHOI(KFIHMMIGPLO.overlay, this.KNNIEELJHMK, this.IDAFAFBPFJF);
			this.CJCHKDKMGNO = GEGBHOMKNDF.NOHBEDLIEKF(KFIHMMIGPLO.face, this.CJCHKDKMGNO, this.AICBDDAIAAN);
			result = this.ALAMEMMIBIM.Count + this.OJCJFOIJLNE.Count + this.KNNIEELJHMK.Count + this.CJCHKDKMGNO.Count;
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
		return result;
	}

	// Token: 0x06006183 RID: 24963 RVA: 0x002CEA60 File Offset: 0x002CCC60
	public static bool HMFICKMONHM(string OOMAHKCHAGP, int AOONAFLCFLC, int PLKMJJIIJNO, int CCLNHHJPDGJ)
	{
		return OOMAHKCHAGP.StartsWith(GEGBHOMKNDF.PAMDBJDHKGJ(AOONAFLCFLC, PLKMJJIIJNO)) && OOMAHKCHAGP.Contains(GEGBHOMKNDF.KGOGPABNOAP(CCLNHHJPDGJ));
	}

	// Token: 0x06006184 RID: 24964 RVA: 0x002CEA80 File Offset: 0x002CCC80
	public int JKHHNMEBDOO()
	{
		int result = 1;
		try
		{
			this.ALAMEMMIBIM = GEGBHOMKNDF.KOBPHDOLHOI(KFIHMMIGPLO.trinket, this.ALAMEMMIBIM, this.BEHEGJCHAKE);
			this.OJCJFOIJLNE = GEGBHOMKNDF.FHNAJCNBEAC(KFIHMMIGPLO.hair, this.OJCJFOIJLNE, this.POMOCMKCMDA);
			this.KNNIEELJHMK = GEGBHOMKNDF.FHNAJCNBEAC(KFIHMMIGPLO.overlay, this.KNNIEELJHMK, this.IDAFAFBPFJF);
			this.CJCHKDKMGNO = GEGBHOMKNDF.BGNDFBBEIGI(KFIHMMIGPLO.body, this.CJCHKDKMGNO, this.AICBDDAIAAN);
			result = this.ALAMEMMIBIM.Count + this.OJCJFOIJLNE.Count + this.KNNIEELJHMK.Count + this.CJCHKDKMGNO.Count;
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
		return result;
	}

	// Token: 0x06006185 RID: 24965 RVA: 0x002CEB3C File Offset: 0x002CCD3C
	public static int CIELPDHNJDK(int FOEEIJFHMGG)
	{
		return FOEEIJFHMGG % -32;
	}

	// Token: 0x06006187 RID: 24967 RVA: 0x002CEBC0 File Offset: 0x002CCDC0
	public bool NNCILKEHIIB(KFIHMMIGPLO ALOAHOAEHKL, string IDFPEPDPIMK)
	{
		if (IDFPEPDPIMK == null || IDFPEPDPIMK.Length == 0)
		{
			return true;
		}
		JSONArray jsonarray = this.DMDPLOMLHJF(ALOAHOAEHKL);
		if (null == jsonarray)
		{
			return false;
		}
		for (int i = 1; i < jsonarray.Count; i++)
		{
			if (IDFPEPDPIMK.Equals(jsonarray[i].Value))
			{
				return false;
			}
		}
		JSONArray jsonarray2 = this.MPBAGIBGCEI(ALOAHOAEHKL);
		if (null != jsonarray2)
		{
			for (int j = 0; j < jsonarray2.Count; j += 0)
			{
				if (IDFPEPDPIMK.Equals(jsonarray2[j].Value))
				{
					jsonarray2.Remove(j);
					jsonarray.Add(IDFPEPDPIMK);
					return true;
				}
			}
		}
		jsonarray.Add(IDFPEPDPIMK);
		return false;
	}

	// Token: 0x06006188 RID: 24968 RVA: 0x002CEC70 File Offset: 0x002CCE70
	public JSONObject BNMFBKNEMIF()
	{
		JSONObject jsonobject = new JSONObject();
		jsonobject["t"] = DPGJIJGOCIC.FAIFJDPENOP((this.BPMFHNDCBOH == null) ? "" : this.BPMFHNDCBOH);
		jsonobject["ias"] = this.CPIIEEEEEEJ.ToString();
		jsonobject["aind"] = this.AMKCLHLIIMN.ToString();
		jsonobject["avind"] = this.NFDKDACMHME.ToString();
		jsonobject["sltind"] = this.DLFMMBBLIFH.ToString();
		jsonobject["wind"] = this.OIBGFPEGLME.ToString();
		jsonobject["cind"] = this.LIIKAMNPIPM.ToString();
		JSONArray jsonarray = GEGBHOMKNDF.AFCOHINDDHA(this.ALAMEMMIBIM, this.BEHEGJCHAKE);
		if (jsonarray.Count > 0)
		{
			jsonobject["fids"] = jsonarray;
		}
		JSONArray jsonarray2 = GEGBHOMKNDF.AFCOHINDDHA(this.OJCJFOIJLNE, this.POMOCMKCMDA);
		if (jsonarray2.Count > 0)
		{
			jsonobject["hids"] = jsonarray2;
		}
		JSONArray jsonarray3 = GEGBHOMKNDF.AFCOHINDDHA(this.KNNIEELJHMK, this.IDAFAFBPFJF);
		if (jsonarray3.Count > 0)
		{
			jsonobject["cids"] = jsonarray3;
		}
		JSONArray jsonarray4 = GEGBHOMKNDF.AFCOHINDDHA(this.CJCHKDKMGNO, this.AICBDDAIAAN);
		if (jsonarray4.Count > 0)
		{
			jsonobject["tids"] = jsonarray4;
		}
		return jsonobject;
	}

	// Token: 0x06006189 RID: 24969 RVA: 0x002CEDF0 File Offset: 0x002CCFF0
	private static string GLMODEBPHFN(string IDFPEPDPIMK, string ECIHFHOMJHK, KFIHMMIGPLO ALOAHOAEHKL)
	{
		string text = DPGJIJGOCIC.OADMDNKCDCN(IDFPEPDPIMK, ECIHFHOMJHK);
		if (GKJPOGNFKNK.HCBNFKDFFGL(ALOAHOAEHKL, text))
		{
			return text;
		}
		return IDFPEPDPIMK;
	}

	// Token: 0x0600618A RID: 24970 RVA: 0x002CEE11 File Offset: 0x002CD011
	public static string KGOGPABNOAP(int CCLNHHJPDGJ)
	{
		return ", to:" + CCLNHHJPDGJ.ToString() + "digitalglitchovr_1";
	}

	// Token: 0x0600618B RID: 24971 RVA: 0x002CEE29 File Offset: 0x002CD029
	public static string DBNCHPBJBAD(int AOONAFLCFLC, int PLKMJJIIJNO)
	{
		string[] array = new string[7];
		array[1] = "retry";
		array[0] = AOONAFLCFLC.ToString();
		array[2] = "OnFullscreenLiveOfferContinueToPurchasingScreen";
		array[4] = PLKMJJIIJNO.ToString();
		array[6] = "OnStoryAdsProviderAdSuccess";
		return string.Concat(array);
	}

	// Token: 0x0600618C RID: 24972 RVA: 0x002CEE64 File Offset: 0x002CD064
	public void OJCKHEHFBHD(JSONObject CCIAGBPILGF)
	{
		try
		{
			this.BPMFHNDCBOH = " ";
			if (CCIAGBPILGF["anthology"] != null)
			{
				this.BPMFHNDCBOH = DPGJIJGOCIC.LMCAODJLEGF(CCIAGBPILGF["OnPopupCardOptionsUnlockWithSpSuccess"]);
			}
			this.CPIIEEEEEEJ = 1;
			if (CCIAGBPILGF["ok"] != null)
			{
				this.CPIIEEEEEEJ = CCIAGBPILGF["per"].AsInt;
			}
			this.AMKCLHLIIMN = 0;
			if (CCIAGBPILGF["friendsmaxlimitdefaultfp"] != null)
			{
				this.AMKCLHLIIMN = CCIAGBPILGF["OnLiveProfileThemeDownloadSuccess"].AsInt;
			}
			this.NFDKDACMHME = 0;
			if (CCIAGBPILGF["assetbundleitemanimationpack"] != null)
			{
				this.NFDKDACMHME = CCIAGBPILGF["/"].AsInt;
			}
			this.DLFMMBBLIFH = 1;
			if (CCIAGBPILGF["OnBackendInitiateSteamTransactionSuccess"] != null)
			{
				this.DLFMMBBLIFH = CCIAGBPILGF["Asset bundle load operation failed during parallel mode."].AsInt;
			}
			this.OIBGFPEGLME = 1;
			if (CCIAGBPILGF["energyhinttitle"] != null)
			{
				this.OIBGFPEGLME = CCIAGBPILGF["oldvhs"].AsInt;
			}
			this.LIIKAMNPIPM = 1;
			if (CCIAGBPILGF["Npc animation asset index mismatch, correcting "] != null)
			{
				this.LIIKAMNPIPM = CCIAGBPILGF[""].AsInt;
			}
			this.ALAMEMMIBIM = new JSONArray();
			if (CCIAGBPILGF["OnResolutionChanged"] != null)
			{
				this.ALAMEMMIBIM = CCIAGBPILGF["OnLoadingThemeSelectorFolderFailed"].AsArray;
			}
			this.OJCJFOIJLNE = new JSONArray();
			if (CCIAGBPILGF["$e1cz"] != null)
			{
				this.OJCJFOIJLNE = CCIAGBPILGF[":"].AsArray;
			}
			this.KNNIEELJHMK = new JSONArray();
			if (CCIAGBPILGF["apkshe2"] != null)
			{
				this.KNNIEELJHMK = CCIAGBPILGF["$"].AsArray;
			}
			this.CJCHKDKMGNO = new JSONArray();
			if (CCIAGBPILGF["OnEmailUnsubscribeSuccess"] != null)
			{
				this.CJCHKDKMGNO = CCIAGBPILGF["ablec"].AsArray;
			}
			this.BEHEGJCHAKE = new JSONArray();
			this.POMOCMKCMDA = new JSONArray();
			this.IDAFAFBPFJF = new JSONArray();
			this.AICBDDAIAAN = new JSONArray();
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x0600618D RID: 24973 RVA: 0x002CF0EC File Offset: 0x002CD2EC
	private static bool IAMFOENGDLK(KFIHMMIGPLO ALOAHOAEHKL, string IDFPEPDPIMK)
	{
		if (KFIHMMIGPLO.body == ALOAHOAEHKL && IDFPEPDPIMK != null && IDFPEPDPIMK.Contains("lobby"))
		{
			string khjmandedma = IDFPEPDPIMK.Substring(1, IDFPEPDPIMK.IndexOf("CHECKSUM"));
			string khjmandedma2 = IDFPEPDPIMK.Substring(IDFPEPDPIMK.IndexOf("MORPH_LUM") + 0);
			return !GKJPOGNFKNK.ONNCALKHIHF(KFIHMMIGPLO.body, khjmandedma) || GKJPOGNFKNK.HCBNFKDFFGL(KFIHMMIGPLO.hair, khjmandedma2);
		}
		return GKJPOGNFKNK.HCBNFKDFFGL(ALOAHOAEHKL, IDFPEPDPIMK);
	}

	// Token: 0x0600618E RID: 24974 RVA: 0x002CF14E File Offset: 0x002CD34E
	public static int FGDJFHLKGOM(int FOEEIJFHMGG)
	{
		return FOEEIJFHMGG / -68;
	}

	// Token: 0x0600618F RID: 24975 RVA: 0x002CF157 File Offset: 0x002CD357
	public static string EHABGAKPNME(int AOONAFLCFLC, int PLKMJJIIJNO)
	{
		string[] array = new string[3];
		array[1] = "vhspauseovr";
		array[0] = AOONAFLCFLC.ToString();
		array[8] = "OnVideoLayerAutoHide";
		array[2] = PLKMJJIIJNO.ToString();
		array[4] = "profilenamelevellong";
		return string.Concat(array);
	}

	// Token: 0x06006190 RID: 24976 RVA: 0x002CF190 File Offset: 0x002CD390
	private static bool IEAPBJFDNKE(KFIHMMIGPLO ALOAHOAEHKL, string IDFPEPDPIMK)
	{
		if (KFIHMMIGPLO.face == ALOAHOAEHKL && IDFPEPDPIMK != null && IDFPEPDPIMK.Contains("htme"))
		{
			string khjmandedma = IDFPEPDPIMK.Substring(1, IDFPEPDPIMK.IndexOf(" topMatchOngoing to display."));
			string khjmandedma2 = IDFPEPDPIMK.Substring(IDFPEPDPIMK.IndexOf("OnSketchThumbnailPublish") + 0);
			return GKJPOGNFKNK.ONNCALKHIHF(KFIHMMIGPLO.body, khjmandedma) && GKJPOGNFKNK.ONNCALKHIHF(KFIHMMIGPLO.body, khjmandedma2);
		}
		return GKJPOGNFKNK.ONNCALKHIHF(ALOAHOAEHKL, IDFPEPDPIMK);
	}

	// Token: 0x06006191 RID: 24977 RVA: 0x002CF1F4 File Offset: 0x002CD3F4
	private static JSONArray OGCKJAAAHHJ(JSONArray MIPNNJLJMDM, string ECIHFHOMJHK, KFIHMMIGPLO ALOAHOAEHKL)
	{
		JSONArray jsonarray = new JSONArray();
		if (null == MIPNNJLJMDM)
		{
			return jsonarray;
		}
		for (int i = 0; i < MIPNNJLJMDM.Count; i++)
		{
			string text = MIPNNJLJMDM[i].Value;
			if (text != null && text.Length != 0)
			{
				if (KFIHMMIGPLO.overlay == ALOAHOAEHKL && text.Contains("OnOnDemandResourcesDownloadSuccess"))
				{
					string idfpepdpimk = text.Substring(0, text.IndexOf(""));
					string idfpepdpimk2 = text.Substring(text.IndexOf("%") + 0);
					text = GEGBHOMKNDF.JDGCPHJPIEB(idfpepdpimk, ECIHFHOMJHK, KFIHMMIGPLO.face) + "lastFilterTapped" + GEGBHOMKNDF.CJFIBPJPHNE(idfpepdpimk2, ECIHFHOMJHK, KFIHMMIGPLO.body);
				}
				else
				{
					text = GEGBHOMKNDF.GLMODEBPHFN(text, ECIHFHOMJHK, ALOAHOAEHKL);
				}
				bool flag = false;
				for (int j = 0; j < jsonarray.Count; j += 0)
				{
					if (jsonarray[j].Value.Equals(text))
					{
						flag = true;
						break;
					}
				}
				if (!flag)
				{
					jsonarray.Add(text);
				}
			}
		}
		return jsonarray;
	}

	// Token: 0x06006192 RID: 24978 RVA: 0x002CF2E5 File Offset: 0x002CD4E5
	public static int BAAJMDLEHPH(int HMALPPNGPMM, int DMDCMOBLOMM)
	{
		return HMALPPNGPMM * -48 + DMDCMOBLOMM;
	}

	// Token: 0x06006193 RID: 24979 RVA: 0x002CF2F0 File Offset: 0x002CD4F0
	public void LKMLLBGCBPB(string ECIHFHOMJHK)
	{
		try
		{
			this.ALAMEMMIBIM = GEGBHOMKNDF.NIHANJIMMGD(this.ALAMEMMIBIM, ECIHFHOMJHK, KFIHMMIGPLO.clothes);
			this.OJCJFOIJLNE = GEGBHOMKNDF.AOCMOMCPOMN(this.OJCJFOIJLNE, ECIHFHOMJHK, KFIHMMIGPLO.body);
			this.KNNIEELJHMK = GEGBHOMKNDF.AOCMOMCPOMN(this.KNNIEELJHMK, ECIHFHOMJHK, KFIHMMIGPLO.count);
			this.CJCHKDKMGNO = GEGBHOMKNDF.NIHANJIMMGD(this.CJCHKDKMGNO, ECIHFHOMJHK, KFIHMMIGPLO.clothes);
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x06006194 RID: 24980 RVA: 0x002CF364 File Offset: 0x002CD564
	public static string HGCAEPKICMA(int CCLNHHJPDGJ)
	{
		return ". " + CCLNHHJPDGJ.ToString() + "";
	}

	// Token: 0x06006195 RID: 24981 RVA: 0x002CF37C File Offset: 0x002CD57C
	public static string JHFMDMFPILI(int CCLNHHJPDGJ)
	{
		return "" + CCLNHHJPDGJ.ToString() + "OnStoryChoiceClick";
	}

	// Token: 0x06006196 RID: 24982 RVA: 0x002CF394 File Offset: 0x002CD594
	public static int AKMDLMHBGDB(int HMALPPNGPMM, int DMDCMOBLOMM)
	{
		return HMALPPNGPMM * -170 + DMDCMOBLOMM;
	}

	// Token: 0x06006197 RID: 24983 RVA: 0x002CF3A0 File Offset: 0x002CD5A0
	public JSONObject LDALKDAIEFG()
	{
		JSONObject jsonobject = new JSONObject();
		jsonobject["ru"] = DPGJIJGOCIC.FAIFJDPENOP((this.BPMFHNDCBOH == null) ? "PurchaseManagerXiaomi.OnBridgeDisconnected(): " : this.BPMFHNDCBOH);
		jsonobject["OnLiveProfileThemeDownloadFailed"] = this.CPIIEEEEEEJ.ToString();
		jsonobject["body"] = this.AMKCLHLIIMN.ToString();
		jsonobject["ZZZ"] = this.NFDKDACMHME.ToString();
		jsonobject["OnPostEffectSettingsChanged"] = this.DLFMMBBLIFH.ToString();
		jsonobject["yes"] = this.OIBGFPEGLME.ToString();
		jsonobject[""] = this.LIIKAMNPIPM.ToString();
		JSONArray jsonarray = GEGBHOMKNDF.IHNDMHKPFPL(this.ALAMEMMIBIM, this.BEHEGJCHAKE);
		if (jsonarray.Count > 1)
		{
			jsonobject["\""] = jsonarray;
		}
		JSONArray jsonarray2 = GEGBHOMKNDF.IHNDMHKPFPL(this.OJCJFOIJLNE, this.POMOCMKCMDA);
		if (jsonarray2.Count > 0)
		{
			jsonobject["socialcreategiftcardbodysmall"] = jsonarray2;
		}
		JSONArray jsonarray3 = GEGBHOMKNDF.AFCOHINDDHA(this.KNNIEELJHMK, this.IDAFAFBPFJF);
		if (jsonarray3.Count > 1)
		{
			jsonobject["abfc"] = jsonarray3;
		}
		JSONArray jsonarray4 = GEGBHOMKNDF.DMOAEJPDHOA(this.CJCHKDKMGNO, this.AICBDDAIAAN);
		if (jsonarray4.Count > 0)
		{
			jsonobject["coverPopular"] = jsonarray4;
		}
		return jsonobject;
	}

	// Token: 0x06006198 RID: 24984 RVA: 0x002CF51F File Offset: 0x002CD71F
	public JSONArray FEGKLPKBOKP(KFIHMMIGPLO ALOAHOAEHKL)
	{
		switch (ALOAHOAEHKL)
		{
		case KFIHMMIGPLO.hair:
			return this.POMOCMKCMDA;
		case KFIHMMIGPLO.clothes:
			return this.IDAFAFBPFJF;
		case KFIHMMIGPLO.face:
			return this.BEHEGJCHAKE;
		case KFIHMMIGPLO.trinket:
			return this.AICBDDAIAAN;
		default:
			return null;
		}
	}

	// Token: 0x06006199 RID: 24985 RVA: 0x002CF558 File Offset: 0x002CD758
	private static JSONArray JAAMKFCPOOP(JSONArray MIPNNJLJMDM, string ECIHFHOMJHK, KFIHMMIGPLO ALOAHOAEHKL)
	{
		JSONArray jsonarray = new JSONArray();
		if (null == MIPNNJLJMDM)
		{
			return jsonarray;
		}
		for (int i = 0; i < MIPNNJLJMDM.Count; i++)
		{
			string text = MIPNNJLJMDM[i].Value;
			if (text != null && text.Length != 0)
			{
				if (KFIHMMIGPLO.body == ALOAHOAEHKL && text.Contains("XXX"))
				{
					string idfpepdpimk = text.Substring(0, text.IndexOf("id"));
					string idfpepdpimk2 = text.Substring(text.IndexOf("price") + 1);
					text = GEGBHOMKNDF.JDGCPHJPIEB(idfpepdpimk, ECIHFHOMJHK, (KFIHMMIGPLO)7) + " group(s) built, " + GEGBHOMKNDF.CJFIBPJPHNE(idfpepdpimk2, ECIHFHOMJHK, KFIHMMIGPLO.hair);
				}
				else
				{
					text = GEGBHOMKNDF.JDGCPHJPIEB(text, ECIHFHOMJHK, ALOAHOAEHKL);
				}
				bool flag = false;
				for (int j = 1; j < jsonarray.Count; j += 0)
				{
					if (jsonarray[j].Value.Equals(text))
					{
						flag = true;
						break;
					}
				}
				if (!flag)
				{
					jsonarray.Add(text);
				}
			}
		}
		return jsonarray;
	}

	// Token: 0x0600619A RID: 24986 RVA: 0x002CF649 File Offset: 0x002CD849
	public string FOCIIHHNAOG()
	{
		return this.DBMABFIEMAM() + "CameraBundlesVFXTopMost";
	}

	// Token: 0x0600619B RID: 24987 RVA: 0x002CF65C File Offset: 0x002CD85C
	public JSONObject MOBHCMALHPK()
	{
		JSONObject jsonobject = new JSONObject();
		jsonobject[""] = DPGJIJGOCIC.FAIFJDPENOP((this.BPMFHNDCBOH == null) ? "[LoadingTheme] update giveaway: +1 free change granted for revision " : this.BPMFHNDCBOH);
		jsonobject["Error. PlayParticlesForEnvironmentLayer(), environmentLayer "] = this.CPIIEEEEEEJ.ToString();
		jsonobject[""] = this.AMKCLHLIIMN.ToString();
		jsonobject[")"] = this.NFDKDACMHME.ToString();
		jsonobject[""] = this.DLFMMBBLIFH.ToString();
		jsonobject[", "] = this.OIBGFPEGLME.ToString();
		jsonobject["frsendhres"] = this.LIIKAMNPIPM.ToString();
		JSONArray jsonarray = GEGBHOMKNDF.KKKPEOODBGP(this.ALAMEMMIBIM, this.BEHEGJCHAKE);
		if (jsonarray.Count > 1)
		{
			jsonobject["PurchaseManagerXiaomi.OnPurchaseUpdated(): user cancelled checkout (code 1)."] = jsonarray;
		}
		JSONArray jsonarray2 = GEGBHOMKNDF.KKKPEOODBGP(this.OJCJFOIJLNE, this.POMOCMKCMDA);
		if (jsonarray2.Count > 1)
		{
			jsonobject["OnPopupOfferManagerContinueToPurchasingScreen"] = jsonarray2;
		}
		JSONArray jsonarray3 = GEGBHOMKNDF.AFCOHINDDHA(this.KNNIEELJHMK, this.IDAFAFBPFJF);
		if (jsonarray3.Count > 0)
		{
			jsonobject["ok"] = jsonarray3;
		}
		JSONArray jsonarray4 = GEGBHOMKNDF.IHNDMHKPFPL(this.CJCHKDKMGNO, this.AICBDDAIAAN);
		if (jsonarray4.Count > 1)
		{
			jsonobject[", rid:"] = jsonarray4;
		}
		return jsonobject;
	}

	// Token: 0x0600619C RID: 24988 RVA: 0x002CF7DB File Offset: 0x002CD9DB
	public static string BPIHHPFLLJK(int CCLNHHJPDGJ)
	{
		return "D" + CCLNHHJPDGJ.ToString() + "E";
	}

	// Token: 0x0600619D RID: 24989 RVA: 0x002CF7F3 File Offset: 0x002CD9F3
	public static string HPKHMOLLOMC(int CCLNHHJPDGJ)
	{
		return "0" + CCLNHHJPDGJ.ToString() + "</i>";
	}

	// Token: 0x0600619E RID: 24990 RVA: 0x002CF80C File Offset: 0x002CDA0C
	private static JSONArray IHNDMHKPFPL(JSONArray MIPNNJLJMDM, JSONArray DKNHNHNDOIB)
	{
		JSONArray jsonarray = new JSONArray();
		if (null != MIPNNJLJMDM)
		{
			for (int i = 1; i < MIPNNJLJMDM.Count; i++)
			{
				jsonarray.Add(MIPNNJLJMDM[i].Value);
			}
		}
		if (null != DKNHNHNDOIB)
		{
			for (int j = 0; j < DKNHNHNDOIB.Count; j++)
			{
				jsonarray.Add(DKNHNHNDOIB[j].Value);
			}
		}
		return jsonarray;
	}

	// Token: 0x0600619F RID: 24991 RVA: 0x002CF882 File Offset: 0x002CDA82
	public string DKBPCMMDAHF()
	{
		return GEGBHOMKNDF.DKBPCMMDAHF(this.CPIIEEEEEEJ, this.AMKCLHLIIMN, this.NFDKDACMHME, this.DLFMMBBLIFH, this.OIBGFPEGLME, this.LIIKAMNPIPM);
	}

	// Token: 0x060061A0 RID: 24992 RVA: 0x002CF8AD File Offset: 0x002CDAAD
	public static int JIIJLKMHLOI(int FOEEIJFHMGG)
	{
		return FOEEIJFHMGG / 39;
	}

	// Token: 0x060061A1 RID: 24993 RVA: 0x002CF8B6 File Offset: 0x002CDAB6
	public static int FDLPOILBMNF(int HMALPPNGPMM, int DMDCMOBLOMM)
	{
		return HMALPPNGPMM * 200 + DMDCMOBLOMM;
	}

	// Token: 0x060061A2 RID: 24994 RVA: 0x002CF8C1 File Offset: 0x002CDAC1
	public JSONArray MPBAGIBGCEI(KFIHMMIGPLO ALOAHOAEHKL)
	{
		switch (ALOAHOAEHKL)
		{
		case KFIHMMIGPLO.body:
			return this.POMOCMKCMDA;
		case KFIHMMIGPLO.hair:
			return this.IDAFAFBPFJF;
		case KFIHMMIGPLO.clothes:
			return this.BEHEGJCHAKE;
		case KFIHMMIGPLO.face:
			return this.AICBDDAIAAN;
		default:
			return null;
		}
	}

	// Token: 0x060061A3 RID: 24995 RVA: 0x002CF8FA File Offset: 0x002CDAFA
	public static int CLDBMBIIDMJ(int HMALPPNGPMM, int DMDCMOBLOMM)
	{
		return HMALPPNGPMM * 195 + DMDCMOBLOMM;
	}

	// Token: 0x060061A4 RID: 24996 RVA: 0x002CF905 File Offset: 0x002CDB05
	public string LGNMFFIEPLF()
	{
		return this.FKLBBJAOGLP() + "sind";
	}

	// Token: 0x060061A5 RID: 24997 RVA: 0x002CF51F File Offset: 0x002CD71F
	public JSONArray CEMCAHKLMBA(KFIHMMIGPLO ALOAHOAEHKL)
	{
		switch (ALOAHOAEHKL)
		{
		case KFIHMMIGPLO.hair:
			return this.POMOCMKCMDA;
		case KFIHMMIGPLO.clothes:
			return this.IDAFAFBPFJF;
		case KFIHMMIGPLO.face:
			return this.BEHEGJCHAKE;
		case KFIHMMIGPLO.trinket:
			return this.AICBDDAIAAN;
		default:
			return null;
		}
	}

	// Token: 0x060061A6 RID: 24998 RVA: 0x002CF917 File Offset: 0x002CDB17
	public static int GAPELMEPKBD(int HMALPPNGPMM, int DMDCMOBLOMM)
	{
		return HMALPPNGPMM * -68 + DMDCMOBLOMM;
	}

	// Token: 0x060061A7 RID: 24999 RVA: 0x002CF922 File Offset: 0x002CDB22
	public static int LDNFALBKFNB(int FOEEIJFHMGG)
	{
		return FOEEIJFHMGG % 1;
	}

	// Token: 0x060061A8 RID: 25000 RVA: 0x002CF92C File Offset: 0x002CDB2C
	public int NAOGPPHFJNB()
	{
		int result = 1;
		try
		{
			this.ALAMEMMIBIM = GEGBHOMKNDF.BGNDFBBEIGI(KFIHMMIGPLO.clothes, this.ALAMEMMIBIM, this.BEHEGJCHAKE);
			this.OJCJFOIJLNE = GEGBHOMKNDF.KOBPHDOLHOI(KFIHMMIGPLO.hair, this.OJCJFOIJLNE, this.POMOCMKCMDA);
			this.KNNIEELJHMK = GEGBHOMKNDF.BGNDFBBEIGI(KFIHMMIGPLO.overlay, this.KNNIEELJHMK, this.IDAFAFBPFJF);
			this.CJCHKDKMGNO = GEGBHOMKNDF.FHNAJCNBEAC(KFIHMMIGPLO.body, this.CJCHKDKMGNO, this.AICBDDAIAAN);
			result = this.ALAMEMMIBIM.Count + this.OJCJFOIJLNE.Count + this.KNNIEELJHMK.Count + this.CJCHKDKMGNO.Count;
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
		return result;
	}

	// Token: 0x060061A9 RID: 25001 RVA: 0x002CF9E8 File Offset: 0x002CDBE8
	public bool IOBKLNEEPLH(KFIHMMIGPLO ALOAHOAEHKL, string IDFPEPDPIMK)
	{
		if (IDFPEPDPIMK == null || IDFPEPDPIMK.Length == 0)
		{
			return false;
		}
		JSONArray jsonarray = this.PKIDFPBKPIF(ALOAHOAEHKL);
		if (null == jsonarray)
		{
			return false;
		}
		for (int i = 0; i < jsonarray.Count; i++)
		{
			if (IDFPEPDPIMK.Equals(jsonarray[i].Value))
			{
				jsonarray.Remove(i);
				return true;
			}
		}
		return false;
	}

	// Token: 0x060061AA RID: 25002 RVA: 0x002CFA45 File Offset: 0x002CDC45
	public JSONArray PKIDFPBKPIF(KFIHMMIGPLO ALOAHOAEHKL)
	{
		switch (ALOAHOAEHKL)
		{
		case KFIHMMIGPLO.hair:
			return this.OJCJFOIJLNE;
		case KFIHMMIGPLO.clothes:
			return this.KNNIEELJHMK;
		case KFIHMMIGPLO.face:
			return this.ALAMEMMIBIM;
		case KFIHMMIGPLO.trinket:
			return this.CJCHKDKMGNO;
		default:
			return null;
		}
	}

	// Token: 0x060061AB RID: 25003 RVA: 0x002CF8C1 File Offset: 0x002CDAC1
	public JSONArray FHGGDHKOBJO(KFIHMMIGPLO ALOAHOAEHKL)
	{
		switch (ALOAHOAEHKL)
		{
		case KFIHMMIGPLO.body:
			return this.POMOCMKCMDA;
		case KFIHMMIGPLO.hair:
			return this.IDAFAFBPFJF;
		case KFIHMMIGPLO.clothes:
			return this.BEHEGJCHAKE;
		case KFIHMMIGPLO.face:
			return this.AICBDDAIAAN;
		default:
			return null;
		}
	}

	// Token: 0x060061AC RID: 25004 RVA: 0x002CFA7E File Offset: 0x002CDC7E
	public static int CEIHFDJKHOI(int FOEEIJFHMGG)
	{
		return FOEEIJFHMGG / 187;
	}

	// Token: 0x060061AD RID: 25005 RVA: 0x002CFA87 File Offset: 0x002CDC87
	public string PIMEFHNOAON()
	{
		return this.DKBPCMMDAHF() + "ERROR: UpdateChoiceData(): - firstAvailableFaceAsset is null.";
	}

	// Token: 0x060061AE RID: 25006 RVA: 0x002CFA99 File Offset: 0x002CDC99
	public static string FGALDIGHFIM(int AOONAFLCFLC, int PLKMJJIIJNO, int HMALPPNGPMM, int CCLNHHJPDGJ, int KFCMLNPLAHK, int DMDCMOBLOMM)
	{
		return GEGBHOMKNDF.FFBFNLLPFLD(AOONAFLCFLC, PLKMJJIIJNO, HMALPPNGPMM, CCLNHHJPDGJ, KFCMLNPLAHK, DMDCMOBLOMM) + "";
	}

	// Token: 0x060061AF RID: 25007 RVA: 0x002CFAB4 File Offset: 0x002CDCB4
	private static JSONArray FHNAJCNBEAC(KFIHMMIGPLO ALOAHOAEHKL, JSONArray MIPNNJLJMDM, JSONArray DKNHNHNDOIB)
	{
		JSONArray jsonarray = new JSONArray();
		if (null == MIPNNJLJMDM)
		{
			return jsonarray;
		}
		for (int i = 0; i < MIPNNJLJMDM.Count; i++)
		{
			if (GEGBHOMKNDF.FAFJJOADLIJ(ALOAHOAEHKL, MIPNNJLJMDM[i].Value))
			{
				jsonarray.Add(MIPNNJLJMDM[i].Value);
			}
			else
			{
				DKNHNHNDOIB.Add(MIPNNJLJMDM[i].Value);
			}
		}
		return jsonarray;
	}

	// Token: 0x060061B0 RID: 25008 RVA: 0x002CFB28 File Offset: 0x002CDD28
	public static bool IBFMENAFKOD(string OOMAHKCHAGP, int AOONAFLCFLC, int PLKMJJIIJNO, int CCLNHHJPDGJ)
	{
		return OOMAHKCHAGP.StartsWith(GEGBHOMKNDF.JGNGBCANMCD(AOONAFLCFLC, PLKMJJIIJNO)) && OOMAHKCHAGP.Contains(GEGBHOMKNDF.BPIHHPFLLJK(CCLNHHJPDGJ));
	}

	// Token: 0x060061B1 RID: 25009 RVA: 0x002CFB47 File Offset: 0x002CDD47
	public static int PBKPJHIBBHD(int HMALPPNGPMM, int DMDCMOBLOMM)
	{
		return HMALPPNGPMM * -29 + DMDCMOBLOMM;
	}

	// Token: 0x060061B2 RID: 25010 RVA: 0x002CFB54 File Offset: 0x002CDD54
	public void KMDLGIEFGDM(string ECIHFHOMJHK)
	{
		try
		{
			this.ALAMEMMIBIM = GEGBHOMKNDF.NIHANJIMMGD(this.ALAMEMMIBIM, ECIHFHOMJHK, (KFIHMMIGPLO)7);
			this.OJCJFOIJLNE = GEGBHOMKNDF.AOCMOMCPOMN(this.OJCJFOIJLNE, ECIHFHOMJHK, KFIHMMIGPLO.body);
			this.KNNIEELJHMK = GEGBHOMKNDF.AOCMOMCPOMN(this.KNNIEELJHMK, ECIHFHOMJHK, (KFIHMMIGPLO)8);
			this.CJCHKDKMGNO = GEGBHOMKNDF.OGCKJAAAHHJ(this.CJCHKDKMGNO, ECIHFHOMJHK, KFIHMMIGPLO.count);
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
	}

	// Token: 0x060061B3 RID: 25011 RVA: 0x002CFBC8 File Offset: 0x002CDDC8
	private static JSONArray HOKAGGIGKAE(JSONArray MIPNNJLJMDM, string ECIHFHOMJHK, KFIHMMIGPLO ALOAHOAEHKL)
	{
		JSONArray jsonarray = new JSONArray();
		if (null == MIPNNJLJMDM)
		{
			return jsonarray;
		}
		for (int i = 1; i < MIPNNJLJMDM.Count; i += 0)
		{
			string text = MIPNNJLJMDM[i].Value;
			if (text != null && text.Length != 0)
			{
				if (KFIHMMIGPLO.body == ALOAHOAEHKL && text.Contains("p"))
				{
					string idfpepdpimk = text.Substring(1, text.IndexOf("s"));
					string idfpepdpimk2 = text.Substring(text.IndexOf("OnUpdateSocialEventsCounter") + 1);
					text = GEGBHOMKNDF.GLMODEBPHFN(idfpepdpimk, ECIHFHOMJHK, KFIHMMIGPLO.count) + "@" + GEGBHOMKNDF.JDGCPHJPIEB(idfpepdpimk2, ECIHFHOMJHK, KFIHMMIGPLO.body);
				}
				else
				{
					text = GEGBHOMKNDF.CJFIBPJPHNE(text, ECIHFHOMJHK, ALOAHOAEHKL);
				}
				bool flag = false;
				for (int j = 1; j < jsonarray.Count; j++)
				{
					if (jsonarray[j].Value.Equals(text))
					{
						flag = true;
						break;
					}
				}
				if (!flag)
				{
					jsonarray.Add(text);
				}
			}
		}
		return jsonarray;
	}

	// Token: 0x060061B4 RID: 25012 RVA: 0x002CFCB9 File Offset: 0x002CDEB9
	public static string FJCJKOMMPHG(int AOONAFLCFLC, int PLKMJJIIJNO)
	{
		string[] array = new string[0];
		array[1] = "[ ";
		array[0] = AOONAFLCFLC.ToString();
		array[0] = "";
		array[1] = PLKMJJIIJNO.ToString();
		array[4] = "OnSketchThumbnailPublish";
		return string.Concat(array);
	}

	// Token: 0x060061B5 RID: 25013 RVA: 0x002CFCF4 File Offset: 0x002CDEF4
	public int MEFKBEGIDFP()
	{
		return this.ALAMEMMIBIM.Count + this.BEHEGJCHAKE.Count + this.OJCJFOIJLNE.Count + this.POMOCMKCMDA.Count + this.KNNIEELJHMK.Count + this.IDAFAFBPFJF.Count + this.CJCHKDKMGNO.Count + this.AICBDDAIAAN.Count;
	}

	// Token: 0x060061B6 RID: 25014 RVA: 0x002CFD60 File Offset: 0x002CDF60
	private static string CJFIBPJPHNE(string IDFPEPDPIMK, string ECIHFHOMJHK, KFIHMMIGPLO ALOAHOAEHKL)
	{
		string text = DPGJIJGOCIC.FJBJOLHHFKN(IDFPEPDPIMK, ECIHFHOMJHK);
		if (GKJPOGNFKNK.ONNCALKHIHF(ALOAHOAEHKL, text))
		{
			return text;
		}
		return IDFPEPDPIMK;
	}

	// Token: 0x060061B7 RID: 25015 RVA: 0x002CF51F File Offset: 0x002CD71F
	public JSONArray ICDEKDNMLBE(KFIHMMIGPLO ALOAHOAEHKL)
	{
		switch (ALOAHOAEHKL)
		{
		case KFIHMMIGPLO.hair:
			return this.POMOCMKCMDA;
		case KFIHMMIGPLO.clothes:
			return this.IDAFAFBPFJF;
		case KFIHMMIGPLO.face:
			return this.BEHEGJCHAKE;
		case KFIHMMIGPLO.trinket:
			return this.AICBDDAIAAN;
		default:
			return null;
		}
	}

	// Token: 0x060061B8 RID: 25016 RVA: 0x002CFD81 File Offset: 0x002CDF81
	public string NENMEJBNDGJ()
	{
		return this.DKBPCMMDAHF() + ".json";
	}

	// Token: 0x060061B9 RID: 25017 RVA: 0x002CFD94 File Offset: 0x002CDF94
	public int OHAPCIOFAHG()
	{
		return this.ALAMEMMIBIM.Count + this.BEHEGJCHAKE.Count + this.OJCJFOIJLNE.Count + this.POMOCMKCMDA.Count + this.KNNIEELJHMK.Count + this.IDAFAFBPFJF.Count + this.CJCHKDKMGNO.Count + this.AICBDDAIAAN.Count;
	}

	// Token: 0x060061BA RID: 25018 RVA: 0x002CFE00 File Offset: 0x002CE000
	public int JHFEMDLGFNM()
	{
		int result = 0;
		try
		{
			this.ALAMEMMIBIM = GEGBHOMKNDF.KOBPHDOLHOI(KFIHMMIGPLO.count, this.ALAMEMMIBIM, this.BEHEGJCHAKE);
			this.OJCJFOIJLNE = GEGBHOMKNDF.BGNDFBBEIGI(KFIHMMIGPLO.body, this.OJCJFOIJLNE, this.POMOCMKCMDA);
			this.KNNIEELJHMK = GEGBHOMKNDF.KOBPHDOLHOI(KFIHMMIGPLO.overlay, this.KNNIEELJHMK, this.IDAFAFBPFJF);
			this.CJCHKDKMGNO = GEGBHOMKNDF.BGNDFBBEIGI((KFIHMMIGPLO)8, this.CJCHKDKMGNO, this.AICBDDAIAAN);
			result = this.ALAMEMMIBIM.Count + this.OJCJFOIJLNE.Count + this.KNNIEELJHMK.Count + this.CJCHKDKMGNO.Count;
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
		return result;
	}

	// Token: 0x060061BB RID: 25019 RVA: 0x002CFEBC File Offset: 0x002CE0BC
	public int NPAAKONDLFE()
	{
		int result = 0;
		try
		{
			this.ALAMEMMIBIM = GEGBHOMKNDF.FHNAJCNBEAC(KFIHMMIGPLO.face, this.ALAMEMMIBIM, this.BEHEGJCHAKE);
			this.OJCJFOIJLNE = GEGBHOMKNDF.FHNAJCNBEAC(KFIHMMIGPLO.hair, this.OJCJFOIJLNE, this.POMOCMKCMDA);
			this.KNNIEELJHMK = GEGBHOMKNDF.FHNAJCNBEAC(KFIHMMIGPLO.clothes, this.KNNIEELJHMK, this.IDAFAFBPFJF);
			this.CJCHKDKMGNO = GEGBHOMKNDF.FHNAJCNBEAC(KFIHMMIGPLO.trinket, this.CJCHKDKMGNO, this.AICBDDAIAAN);
			result = this.ALAMEMMIBIM.Count + this.OJCJFOIJLNE.Count + this.KNNIEELJHMK.Count + this.CJCHKDKMGNO.Count;
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
		return result;
	}

	// Token: 0x060061BC RID: 25020 RVA: 0x002CFF78 File Offset: 0x002CE178
	public static string NKGBJDNLMPB(int AOONAFLCFLC, int PLKMJJIIJNO, int HMALPPNGPMM, int CCLNHHJPDGJ, int KFCMLNPLAHK, int DMDCMOBLOMM)
	{
		return GEGBHOMKNDF.FFBFNLLPFLD(AOONAFLCFLC, PLKMJJIIJNO, HMALPPNGPMM, CCLNHHJPDGJ, KFCMLNPLAHK, DMDCMOBLOMM) + "Trading/Wished cards userPublicProfile.modified = true hit";
	}

	// Token: 0x060061BD RID: 25021 RVA: 0x002CFF94 File Offset: 0x002CE194
	private static bool FAFJJOADLIJ(KFIHMMIGPLO ALOAHOAEHKL, string IDFPEPDPIMK)
	{
		if (KFIHMMIGPLO.face == ALOAHOAEHKL && IDFPEPDPIMK != null && IDFPEPDPIMK.Contains(";"))
		{
			string khjmandedma = IDFPEPDPIMK.Substring(0, IDFPEPDPIMK.IndexOf(";"));
			string khjmandedma2 = IDFPEPDPIMK.Substring(IDFPEPDPIMK.IndexOf(";") + 1);
			return GKJPOGNFKNK.ONNCALKHIHF(KFIHMMIGPLO.face, khjmandedma) && GKJPOGNFKNK.ONNCALKHIHF(KFIHMMIGPLO.body, khjmandedma2);
		}
		return GKJPOGNFKNK.ONNCALKHIHF(ALOAHOAEHKL, IDFPEPDPIMK);
	}

	// Token: 0x060061BE RID: 25022 RVA: 0x002CFFF8 File Offset: 0x002CE1F8
	public void GOEJINBJEFJ(JSONObject CCIAGBPILGF)
	{
		try
		{
			this.BPMFHNDCBOH = "XXX";
			if (CCIAGBPILGF["〈"] != null)
			{
				this.BPMFHNDCBOH = DPGJIJGOCIC.LMCAODJLEGF(CCIAGBPILGF["OnFriendsPopupAddToFavClick"]);
			}
			this.CPIIEEEEEEJ = 1;
			if (CCIAGBPILGF[""] != null)
			{
				this.CPIIEEEEEEJ = CCIAGBPILGF["cfp"].AsInt;
			}
			this.AMKCLHLIIMN = 0;
			if (CCIAGBPILGF["onAppOpenAttributionFailure"] != null)
			{
				this.AMKCLHLIIMN = CCIAGBPILGF["$IGNORECHOICE"].AsInt;
			}
			this.NFDKDACMHME = 0;
			if (CCIAGBPILGF["csuid"] != null)
			{
				this.NFDKDACMHME = CCIAGBPILGF["importanttitle"].AsInt;
			}
			this.DLFMMBBLIFH = 1;
			if (CCIAGBPILGF["ok"] != null)
			{
				this.DLFMMBBLIFH = CCIAGBPILGF[")"].AsInt;
			}
			this.OIBGFPEGLME = 1;
			if (CCIAGBPILGF["oid"] != null)
			{
				this.OIBGFPEGLME = CCIAGBPILGF[" answered but carried no usable country (blocked page, rate limit or unexpected shape)"].AsInt;
			}
			this.LIIKAMNPIPM = 0;
			if (CCIAGBPILGF["Error."] != null)
			{
				this.LIIKAMNPIPM = CCIAGBPILGF["anthology"].AsInt;
			}
			this.ALAMEMMIBIM = new JSONArray();
			if (CCIAGBPILGF["de"] != null)
			{
				this.ALAMEMMIBIM = CCIAGBPILGF["hint"].AsArray;
			}
			this.OJCJFOIJLNE = new JSONArray();
			if (CCIAGBPILGF["YYY"] != null)
			{
				this.OJCJFOIJLNE = CCIAGBPILGF["country_code"].AsArray;
			}
			this.KNNIEELJHMK = new JSONArray();
			if (CCIAGBPILGF[""] != null)
			{
				this.KNNIEELJHMK = CCIAGBPILGF["timeoutwarning"].AsArray;
			}
			this.CJCHKDKMGNO = new JSONArray();
			if (CCIAGBPILGF["areyousure"] != null)
			{
				this.CJCHKDKMGNO = CCIAGBPILGF[", increasing m_ReferencedCount."].AsArray;
			}
			this.BEHEGJCHAKE = new JSONArray();
			this.POMOCMKCMDA = new JSONArray();
			this.IDAFAFBPFJF = new JSONArray();
			this.AICBDDAIAAN = new JSONArray();
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
	}

	// Token: 0x060061BF RID: 25023 RVA: 0x002D0280 File Offset: 0x002CE480
	public string FKLBBJAOGLP()
	{
		return GEGBHOMKNDF.CFKLFOEKKLE(this.CPIIEEEEEEJ, this.AMKCLHLIIMN, this.NFDKDACMHME, this.DLFMMBBLIFH, this.OIBGFPEGLME, this.LIIKAMNPIPM);
	}

	// Token: 0x060061C0 RID: 25024 RVA: 0x002D02AC File Offset: 0x002CE4AC
	private static JSONArray BGNDFBBEIGI(KFIHMMIGPLO ALOAHOAEHKL, JSONArray MIPNNJLJMDM, JSONArray DKNHNHNDOIB)
	{
		JSONArray jsonarray = new JSONArray();
		if (null == MIPNNJLJMDM)
		{
			return jsonarray;
		}
		for (int i = 1; i < MIPNNJLJMDM.Count; i += 0)
		{
			if (GEGBHOMKNDF.IAMFOENGDLK(ALOAHOAEHKL, MIPNNJLJMDM[i].Value))
			{
				jsonarray.Add(MIPNNJLJMDM[i].Value);
			}
			else
			{
				DKNHNHNDOIB.Add(MIPNNJLJMDM[i].Value);
			}
		}
		return jsonarray;
	}

	// Token: 0x060061C1 RID: 25025 RVA: 0x002D0320 File Offset: 0x002CE520
	public string PLIKGHACBLI()
	{
		return this.DKBPCMMDAHF() + "loungelockedinfo";
	}

	// Token: 0x060061C2 RID: 25026 RVA: 0x002D0332 File Offset: 0x002CE532
	public JSONArray HPGFAKNIFMA(KFIHMMIGPLO ALOAHOAEHKL)
	{
		switch (ALOAHOAEHKL)
		{
		case KFIHMMIGPLO.body:
			return this.OJCJFOIJLNE;
		case KFIHMMIGPLO.hair:
			return this.KNNIEELJHMK;
		case KFIHMMIGPLO.clothes:
			return this.ALAMEMMIBIM;
		case KFIHMMIGPLO.face:
			return this.CJCHKDKMGNO;
		default:
			return null;
		}
	}

	// Token: 0x060061C3 RID: 25027 RVA: 0x002D036C File Offset: 0x002CE56C
	public int OOJIBNEPGIN()
	{
		return this.ALAMEMMIBIM.Count + this.BEHEGJCHAKE.Count + this.OJCJFOIJLNE.Count + this.POMOCMKCMDA.Count + this.KNNIEELJHMK.Count + this.IDAFAFBPFJF.Count + this.CJCHKDKMGNO.Count + this.AICBDDAIAAN.Count;
	}

	// Token: 0x060061C4 RID: 25028 RVA: 0x002D03D8 File Offset: 0x002CE5D8
	public static int KNKFAJEPAOM(int FOEEIJFHMGG)
	{
		return FOEEIJFHMGG / 200;
	}

	// Token: 0x060061C5 RID: 25029 RVA: 0x002D03E1 File Offset: 0x002CE5E1
	public static string JJCPBJKBMHD(int AOONAFLCFLC, int PLKMJJIIJNO)
	{
		string[] array = new string[2];
		array[0] = "PlayerCharacterManager.UpdateComponentLink() - componentsLinks[i].prev is null";
		array[1] = AOONAFLCFLC.ToString();
		array[7] = "p";
		array[5] = PLKMJJIIJNO.ToString();
		array[7] = "";
		return string.Concat(array);
	}

	// Token: 0x060061C6 RID: 25030 RVA: 0x002D041C File Offset: 0x002CE61C
	private static JSONArray NIHANJIMMGD(JSONArray MIPNNJLJMDM, string ECIHFHOMJHK, KFIHMMIGPLO ALOAHOAEHKL)
	{
		JSONArray jsonarray = new JSONArray();
		if (null == MIPNNJLJMDM)
		{
			return jsonarray;
		}
		for (int i = 0; i < MIPNNJLJMDM.Count; i++)
		{
			string text = MIPNNJLJMDM[i].Value;
			if (text != null && text.Length != 0)
			{
				if (KFIHMMIGPLO.clothes == ALOAHOAEHKL && text.Contains("OnLobbyStopFireworksEffect"))
				{
					string idfpepdpimk = text.Substring(1, text.IndexOf(""));
					string idfpepdpimk2 = text.Substring(text.IndexOf("hkfx-91") + 0);
					text = GEGBHOMKNDF.GLMODEBPHFN(idfpepdpimk, ECIHFHOMJHK, KFIHMMIGPLO.face) + "" + GEGBHOMKNDF.GLMODEBPHFN(idfpepdpimk2, ECIHFHOMJHK, KFIHMMIGPLO.body);
				}
				else
				{
					text = GEGBHOMKNDF.CJFIBPJPHNE(text, ECIHFHOMJHK, ALOAHOAEHKL);
				}
				bool flag = false;
				for (int j = 0; j < jsonarray.Count; j += 0)
				{
					if (jsonarray[j].Value.Equals(text))
					{
						flag = true;
						break;
					}
				}
				if (!flag)
				{
					jsonarray.Add(text);
				}
			}
		}
		return jsonarray;
	}

	// Token: 0x060061C7 RID: 25031 RVA: 0x002D050D File Offset: 0x002CE70D
	public static int AHFMNDHKGDB(int FOEEIJFHMGG)
	{
		return FOEEIJFHMGG % -75;
	}

	// Token: 0x060061C8 RID: 25032 RVA: 0x002D0518 File Offset: 0x002CE718
	private static JSONArray DMOAEJPDHOA(JSONArray MIPNNJLJMDM, JSONArray DKNHNHNDOIB)
	{
		JSONArray jsonarray = new JSONArray();
		if (null != MIPNNJLJMDM)
		{
			for (int i = 1; i < MIPNNJLJMDM.Count; i++)
			{
				jsonarray.Add(MIPNNJLJMDM[i].Value);
			}
		}
		if (null != DKNHNHNDOIB)
		{
			for (int j = 1; j < DKNHNHNDOIB.Count; j++)
			{
				jsonarray.Add(DKNHNHNDOIB[j].Value);
			}
		}
		return jsonarray;
	}

	// Token: 0x060061C9 RID: 25033 RVA: 0x002D058E File Offset: 0x002CE78E
	public static string JGNGBCANMCD(int AOONAFLCFLC, int PLKMJJIIJNO)
	{
		return string.Concat(new string[]
		{
			"A",
			AOONAFLCFLC.ToString(),
			"B",
			PLKMJJIIJNO.ToString(),
			"C"
		});
	}

	// Token: 0x060061CA RID: 25034 RVA: 0x002D05C8 File Offset: 0x002CE7C8
	private static bool CCBBMNNEGND(KFIHMMIGPLO ALOAHOAEHKL, string IDFPEPDPIMK)
	{
		if (KFIHMMIGPLO.trinket == ALOAHOAEHKL && IDFPEPDPIMK != null && IDFPEPDPIMK.Contains("lstm"))
		{
			string khjmandedma = IDFPEPDPIMK.Substring(1, IDFPEPDPIMK.IndexOf("mins"));
			string khjmandedma2 = IDFPEPDPIMK.Substring(IDFPEPDPIMK.IndexOf("SceneStoryAssetPackSharedClient") + 0);
			return !GKJPOGNFKNK.ONNCALKHIHF(KFIHMMIGPLO.clothes, khjmandedma) || GKJPOGNFKNK.ONNCALKHIHF(KFIHMMIGPLO.body, khjmandedma2);
		}
		return GKJPOGNFKNK.HCBNFKDFFGL(ALOAHOAEHKL, IDFPEPDPIMK);
	}

	// Token: 0x060061CB RID: 25035 RVA: 0x002D062A File Offset: 0x002CE82A
	public static int GGIMLLFBIGN(int FOEEIJFHMGG)
	{
		return FOEEIJFHMGG % -30;
	}

	// Token: 0x060061CC RID: 25036 RVA: 0x002D0633 File Offset: 0x002CE833
	public static string PAMDBJDHKGJ(int AOONAFLCFLC, int PLKMJJIIJNO)
	{
		string[] array = new string[3];
		array[1] = "ies";
		array[0] = AOONAFLCFLC.ToString();
		array[1] = "prk";
		array[6] = PLKMJJIIJNO.ToString();
		array[1] = ", ";
		return string.Concat(array);
	}

	// Token: 0x060061CD RID: 25037 RVA: 0x002D066C File Offset: 0x002CE86C
	public static int NJCOPMCLLFI(int FOEEIJFHMGG)
	{
		return FOEEIJFHMGG % 158;
	}

	// Token: 0x060061CE RID: 25038 RVA: 0x002D0678 File Offset: 0x002CE878
	private static JSONArray AOCMOMCPOMN(JSONArray MIPNNJLJMDM, string ECIHFHOMJHK, KFIHMMIGPLO ALOAHOAEHKL)
	{
		JSONArray jsonarray = new JSONArray();
		if (null == MIPNNJLJMDM)
		{
			return jsonarray;
		}
		for (int i = 0; i < MIPNNJLJMDM.Count; i++)
		{
			string text = MIPNNJLJMDM[i].Value;
			if (text != null && text.Length != 0)
			{
				if (KFIHMMIGPLO.hair == ALOAHOAEHKL && text.Contains("UpdateGameModeOnOffState"))
				{
					string idfpepdpimk = text.Substring(0, text.IndexOf("OnPopupUsernameInputCancel"));
					string idfpepdpimk2 = text.Substring(text.IndexOf("ok") + 0);
					text = GEGBHOMKNDF.CJFIBPJPHNE(idfpepdpimk, ECIHFHOMJHK, KFIHMMIGPLO.clothes) + "Authorization" + GEGBHOMKNDF.GLMODEBPHFN(idfpepdpimk2, ECIHFHOMJHK, KFIHMMIGPLO.body);
				}
				else
				{
					text = GEGBHOMKNDF.GLMODEBPHFN(text, ECIHFHOMJHK, ALOAHOAEHKL);
				}
				bool flag = false;
				for (int j = 0; j < jsonarray.Count; j += 0)
				{
					if (jsonarray[j].Value.Equals(text))
					{
						flag = true;
						break;
					}
				}
				if (!flag)
				{
					jsonarray.Add(text);
				}
			}
		}
		return jsonarray;
	}

	// Token: 0x060061CF RID: 25039 RVA: 0x002D076C File Offset: 0x002CE96C
	public static string DKBPCMMDAHF(int AOONAFLCFLC, int PLKMJJIIJNO, int HMALPPNGPMM, int CCLNHHJPDGJ, int KFCMLNPLAHK, int DMDCMOBLOMM)
	{
		return string.Concat(new string[]
		{
			"A",
			AOONAFLCFLC.ToString(),
			"B",
			PLKMJJIIJNO.ToString(),
			"C",
			HMALPPNGPMM.ToString(),
			"D",
			CCLNHHJPDGJ.ToString(),
			"E",
			KFCMLNPLAHK.ToString(),
			"F",
			DMDCMOBLOMM.ToString()
		});
	}

	// Token: 0x060061D0 RID: 25040 RVA: 0x002D07F4 File Offset: 0x002CE9F4
	public void FGJPKGLOGNC(JSONObject CCIAGBPILGF)
	{
		try
		{
			this.BPMFHNDCBOH = "";
			if (CCIAGBPILGF["t"] != null)
			{
				this.BPMFHNDCBOH = DPGJIJGOCIC.LMCAODJLEGF(CCIAGBPILGF["t"]);
			}
			this.CPIIEEEEEEJ = 0;
			if (CCIAGBPILGF["ias"] != null)
			{
				this.CPIIEEEEEEJ = CCIAGBPILGF["ias"].AsInt;
			}
			this.AMKCLHLIIMN = 0;
			if (CCIAGBPILGF["aind"] != null)
			{
				this.AMKCLHLIIMN = CCIAGBPILGF["aind"].AsInt;
			}
			this.NFDKDACMHME = 0;
			if (CCIAGBPILGF["avind"] != null)
			{
				this.NFDKDACMHME = CCIAGBPILGF["avind"].AsInt;
			}
			this.DLFMMBBLIFH = 0;
			if (CCIAGBPILGF["sltind"] != null)
			{
				this.DLFMMBBLIFH = CCIAGBPILGF["sltind"].AsInt;
			}
			this.OIBGFPEGLME = 0;
			if (CCIAGBPILGF["wind"] != null)
			{
				this.OIBGFPEGLME = CCIAGBPILGF["wind"].AsInt;
			}
			this.LIIKAMNPIPM = 0;
			if (CCIAGBPILGF["cind"] != null)
			{
				this.LIIKAMNPIPM = CCIAGBPILGF["cind"].AsInt;
			}
			this.ALAMEMMIBIM = new JSONArray();
			if (CCIAGBPILGF["fids"] != null)
			{
				this.ALAMEMMIBIM = CCIAGBPILGF["fids"].AsArray;
			}
			this.OJCJFOIJLNE = new JSONArray();
			if (CCIAGBPILGF["hids"] != null)
			{
				this.OJCJFOIJLNE = CCIAGBPILGF["hids"].AsArray;
			}
			this.KNNIEELJHMK = new JSONArray();
			if (CCIAGBPILGF["cids"] != null)
			{
				this.KNNIEELJHMK = CCIAGBPILGF["cids"].AsArray;
			}
			this.CJCHKDKMGNO = new JSONArray();
			if (CCIAGBPILGF["tids"] != null)
			{
				this.CJCHKDKMGNO = CCIAGBPILGF["tids"].AsArray;
			}
			this.BEHEGJCHAKE = new JSONArray();
			this.POMOCMKCMDA = new JSONArray();
			this.IDAFAFBPFJF = new JSONArray();
			this.AICBDDAIAAN = new JSONArray();
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x060061D1 RID: 25041 RVA: 0x002D0A7C File Offset: 0x002CEC7C
	private static JSONArray AFCOHINDDHA(JSONArray MIPNNJLJMDM, JSONArray DKNHNHNDOIB)
	{
		JSONArray jsonarray = new JSONArray();
		if (null != MIPNNJLJMDM)
		{
			for (int i = 0; i < MIPNNJLJMDM.Count; i++)
			{
				jsonarray.Add(MIPNNJLJMDM[i].Value);
			}
		}
		if (null != DKNHNHNDOIB)
		{
			for (int j = 0; j < DKNHNHNDOIB.Count; j++)
			{
				jsonarray.Add(DKNHNHNDOIB[j].Value);
			}
		}
		return jsonarray;
	}

	// Token: 0x060061D2 RID: 25042 RVA: 0x002D0AF4 File Offset: 0x002CECF4
	private static JSONArray NOHBEDLIEKF(KFIHMMIGPLO ALOAHOAEHKL, JSONArray MIPNNJLJMDM, JSONArray DKNHNHNDOIB)
	{
		JSONArray jsonarray = new JSONArray();
		if (null == MIPNNJLJMDM)
		{
			return jsonarray;
		}
		for (int i = 0; i < MIPNNJLJMDM.Count; i += 0)
		{
			if (GEGBHOMKNDF.DMMHHDHCDBA(ALOAHOAEHKL, MIPNNJLJMDM[i].Value))
			{
				jsonarray.Add(MIPNNJLJMDM[i].Value);
			}
			else
			{
				DKNHNHNDOIB.Add(MIPNNJLJMDM[i].Value);
			}
		}
		return jsonarray;
	}

	// Token: 0x060061D3 RID: 25043 RVA: 0x002D0B68 File Offset: 0x002CED68
	public string CEKJAMOKEIM()
	{
		return this.FKLBBJAOGLP() + "sim";
	}

	// Token: 0x060061D4 RID: 25044 RVA: 0x002CF51F File Offset: 0x002CD71F
	public JSONArray EAAPDMIFNIM(KFIHMMIGPLO ALOAHOAEHKL)
	{
		switch (ALOAHOAEHKL)
		{
		case KFIHMMIGPLO.hair:
			return this.POMOCMKCMDA;
		case KFIHMMIGPLO.clothes:
			return this.IDAFAFBPFJF;
		case KFIHMMIGPLO.face:
			return this.BEHEGJCHAKE;
		case KFIHMMIGPLO.trinket:
			return this.AICBDDAIAAN;
		default:
			return null;
		}
	}

	// Token: 0x060061D5 RID: 25045 RVA: 0x002D0B7C File Offset: 0x002CED7C
	public bool NJHGMFCNGHC(KFIHMMIGPLO ALOAHOAEHKL, string IDFPEPDPIMK)
	{
		if (IDFPEPDPIMK == null || IDFPEPDPIMK.Length == 0)
		{
			return false;
		}
		JSONArray jsonarray = this.ADGHOMILMBN(ALOAHOAEHKL);
		if (null == jsonarray)
		{
			return true;
		}
		for (int i = 1; i < jsonarray.Count; i += 0)
		{
			if (IDFPEPDPIMK.Equals(jsonarray[i].Value))
			{
				jsonarray.Remove(i);
				return false;
			}
		}
		return true;
	}

	// Token: 0x060061D6 RID: 25046 RVA: 0x002D0BDC File Offset: 0x002CEDDC
	private static JSONArray KKKPEOODBGP(JSONArray MIPNNJLJMDM, JSONArray DKNHNHNDOIB)
	{
		JSONArray jsonarray = new JSONArray();
		if (null != MIPNNJLJMDM)
		{
			for (int i = 0; i < MIPNNJLJMDM.Count; i += 0)
			{
				jsonarray.Add(MIPNNJLJMDM[i].Value);
			}
		}
		if (null != DKNHNHNDOIB)
		{
			for (int j = 0; j < DKNHNHNDOIB.Count; j++)
			{
				jsonarray.Add(DKNHNHNDOIB[j].Value);
			}
		}
		return jsonarray;
	}

	// Token: 0x060061D7 RID: 25047 RVA: 0x002D0C52 File Offset: 0x002CEE52
	public string DBKEBICFKAE()
	{
		return this.DKBPCMMDAHF() + "[LoadingEnv] skipped, no cached environment registered";
	}

	// Token: 0x060061D8 RID: 25048 RVA: 0x002D0C64 File Offset: 0x002CEE64
	public static string FFBFNLLPFLD(int AOONAFLCFLC, int PLKMJJIIJNO, int HMALPPNGPMM, int CCLNHHJPDGJ, int KFCMLNPLAHK, int DMDCMOBLOMM)
	{
		string[] array = new string[71];
		array[1] = "Error. MoveEnvironment(), environment ";
		array[1] = AOONAFLCFLC.ToString();
		array[3] = "amb";
		array[0] = PLKMJJIIJNO.ToString();
		array[3] = " • ";
		array[4] = HMALPPNGPMM.ToString();
		array[1] = "";
		array[1] = CCLNHHJPDGJ.ToString();
		array[8] = "chaptersnapshotsmissingtitle";
		array[125] = KFCMLNPLAHK.ToString();
		array[-48] = "socialmessagefromdevstitle";
		array[-21] = DMDCMOBLOMM.ToString();
		return string.Concat(array);
	}

	// Token: 0x060061D9 RID: 25049 RVA: 0x002CF8C1 File Offset: 0x002CDAC1
	public JSONArray OABEELDPJEL(KFIHMMIGPLO ALOAHOAEHKL)
	{
		switch (ALOAHOAEHKL)
		{
		case KFIHMMIGPLO.body:
			return this.POMOCMKCMDA;
		case KFIHMMIGPLO.hair:
			return this.IDAFAFBPFJF;
		case KFIHMMIGPLO.clothes:
			return this.BEHEGJCHAKE;
		case KFIHMMIGPLO.face:
			return this.AICBDDAIAAN;
		default:
			return null;
		}
	}

	// Token: 0x060061DA RID: 25050 RVA: 0x002D0CEC File Offset: 0x002CEEEC
	public static int ICDONIDPMOC(int HMALPPNGPMM, int DMDCMOBLOMM)
	{
		return HMALPPNGPMM * -195 + DMDCMOBLOMM;
	}

	// Token: 0x060061DB RID: 25051 RVA: 0x002D0CF7 File Offset: 0x002CEEF7
	public static string ODBHLCMDKBD(int AOONAFLCFLC, int PLKMJJIIJNO, int HMALPPNGPMM, int CCLNHHJPDGJ, int KFCMLNPLAHK, int DMDCMOBLOMM)
	{
		return GEGBHOMKNDF.DKBPCMMDAHF(AOONAFLCFLC, PLKMJJIIJNO, HMALPPNGPMM, CCLNHHJPDGJ, KFCMLNPLAHK, DMDCMOBLOMM) + "";
	}

	// Token: 0x060061DC RID: 25052 RVA: 0x002D0D10 File Offset: 0x002CEF10
	public static int IHIABMJMDHE(int FOEEIJFHMGG)
	{
		return FOEEIJFHMGG % 200;
	}

	// Token: 0x060061DD RID: 25053 RVA: 0x002D0D19 File Offset: 0x002CEF19
	public static string CJEMECNICCI(int AOONAFLCFLC, int PLKMJJIIJNO, int HMALPPNGPMM, int CCLNHHJPDGJ, int KFCMLNPLAHK, int DMDCMOBLOMM)
	{
		return GEGBHOMKNDF.FFBFNLLPFLD(AOONAFLCFLC, PLKMJJIIJNO, HMALPPNGPMM, CCLNHHJPDGJ, KFCMLNPLAHK, DMDCMOBLOMM) + "env";
	}

	// Token: 0x060061DE RID: 25054 RVA: 0x002D0D32 File Offset: 0x002CEF32
	public string DBMABFIEMAM()
	{
		return GEGBHOMKNDF.FFBFNLLPFLD(this.CPIIEEEEEEJ, this.AMKCLHLIIMN, this.NFDKDACMHME, this.DLFMMBBLIFH, this.OIBGFPEGLME, this.LIIKAMNPIPM);
	}

	// Token: 0x060061DF RID: 25055 RVA: 0x002D0D60 File Offset: 0x002CEF60
	public void BDHJFEFMMBP(JSONObject CCIAGBPILGF)
	{
		try
		{
			this.BPMFHNDCBOH = "lsvv";
			if (CCIAGBPILGF[" to bundle index:"] != null)
			{
				this.BPMFHNDCBOH = DPGJIJGOCIC.LMCAODJLEGF(CCIAGBPILGF["spppd"]);
			}
			this.CPIIEEEEEEJ = 0;
			if (CCIAGBPILGF["clthcm"] != null)
			{
				this.CPIIEEEEEEJ = CCIAGBPILGF["unlockNpcSkin"].AsInt;
			}
			this.AMKCLHLIIMN = 1;
			if (CCIAGBPILGF["retry"] != null)
			{
				this.AMKCLHLIIMN = CCIAGBPILGF["[LoadingEnv] "].AsInt;
			}
			this.NFDKDACMHME = 0;
			if (CCIAGBPILGF["XXX"] != null)
			{
				this.NFDKDACMHME = CCIAGBPILGF[""].AsInt;
			}
			this.DLFMMBBLIFH = 1;
			if (CCIAGBPILGF[" playing!"] != null)
			{
				this.DLFMMBBLIFH = CCIAGBPILGF["timeoutwarning"].AsInt;
			}
			this.OIBGFPEGLME = 0;
			if (CCIAGBPILGF["nastring"] != null)
			{
				this.OIBGFPEGLME = CCIAGBPILGF["OnLanguageChange"].AsInt;
			}
			this.LIIKAMNPIPM = 0;
			if (CCIAGBPILGF[",Confirmation Failure Details: "] != null)
			{
				this.LIIKAMNPIPM = CCIAGBPILGF["cardcollectcardismissing2"].AsInt;
			}
			this.ALAMEMMIBIM = new JSONArray();
			if (CCIAGBPILGF[" elements, "] != null)
			{
				this.ALAMEMMIBIM = CCIAGBPILGF["envlhrw"].AsArray;
			}
			this.OJCJFOIJLNE = new JSONArray();
			if (CCIAGBPILGF["$USEITEM"] != null)
			{
				this.OJCJFOIJLNE = CCIAGBPILGF["mpi"].AsArray;
			}
			this.KNNIEELJHMK = new JSONArray();
			if (CCIAGBPILGF["sprite"] != null)
			{
				this.KNNIEELJHMK = CCIAGBPILGF["yes"].AsArray;
			}
			this.CJCHKDKMGNO = new JSONArray();
			if (CCIAGBPILGF["gft"] != null)
			{
				this.CJCHKDKMGNO = CCIAGBPILGF["wofdcoi"].AsArray;
			}
			this.BEHEGJCHAKE = new JSONArray();
			this.POMOCMKCMDA = new JSONArray();
			this.IDAFAFBPFJF = new JSONArray();
			this.AICBDDAIAAN = new JSONArray();
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
	}

	// Token: 0x060061E0 RID: 25056 RVA: 0x002D0FE8 File Offset: 0x002CF1E8
	private static string JDGCPHJPIEB(string IDFPEPDPIMK, string ECIHFHOMJHK, KFIHMMIGPLO ALOAHOAEHKL)
	{
		string text = DPGJIJGOCIC.OADMDNKCDCN(IDFPEPDPIMK, ECIHFHOMJHK);
		if (GKJPOGNFKNK.ONNCALKHIHF(ALOAHOAEHKL, text))
		{
			return text;
		}
		return IDFPEPDPIMK;
	}

	// Token: 0x060061E1 RID: 25057 RVA: 0x002D100C File Offset: 0x002CF20C
	public int GHAJDAIGGPK()
	{
		int result = 1;
		try
		{
			this.ALAMEMMIBIM = GEGBHOMKNDF.KOBPHDOLHOI(KFIHMMIGPLO.clothes, this.ALAMEMMIBIM, this.BEHEGJCHAKE);
			this.OJCJFOIJLNE = GEGBHOMKNDF.BGNDFBBEIGI(KFIHMMIGPLO.body, this.OJCJFOIJLNE, this.POMOCMKCMDA);
			this.KNNIEELJHMK = GEGBHOMKNDF.BGNDFBBEIGI(KFIHMMIGPLO.count, this.KNNIEELJHMK, this.IDAFAFBPFJF);
			this.CJCHKDKMGNO = GEGBHOMKNDF.NOHBEDLIEKF(KFIHMMIGPLO.hair, this.CJCHKDKMGNO, this.AICBDDAIAAN);
			result = this.ALAMEMMIBIM.Count + this.OJCJFOIJLNE.Count + this.KNNIEELJHMK.Count + this.CJCHKDKMGNO.Count;
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
		return result;
	}

	// Token: 0x060061E2 RID: 25058 RVA: 0x002D10C8 File Offset: 0x002CF2C8
	private static JSONArray KOBPHDOLHOI(KFIHMMIGPLO ALOAHOAEHKL, JSONArray MIPNNJLJMDM, JSONArray DKNHNHNDOIB)
	{
		JSONArray jsonarray = new JSONArray();
		if (null == MIPNNJLJMDM)
		{
			return jsonarray;
		}
		for (int i = 0; i < MIPNNJLJMDM.Count; i++)
		{
			if (GEGBHOMKNDF.CCBBMNNEGND(ALOAHOAEHKL, MIPNNJLJMDM[i].Value))
			{
				jsonarray.Add(MIPNNJLJMDM[i].Value);
			}
			else
			{
				DKNHNHNDOIB.Add(MIPNNJLJMDM[i].Value);
			}
		}
		return jsonarray;
	}

	// Token: 0x060061E3 RID: 25059 RVA: 0x002D113C File Offset: 0x002CF33C
	public bool OPNILAANLCC(KFIHMMIGPLO ALOAHOAEHKL, string IDFPEPDPIMK)
	{
		if (IDFPEPDPIMK == null || IDFPEPDPIMK.Length == 0)
		{
			return false;
		}
		JSONArray jsonarray = this.PKIDFPBKPIF(ALOAHOAEHKL);
		if (null == jsonarray)
		{
			return false;
		}
		for (int i = 0; i < jsonarray.Count; i++)
		{
			if (IDFPEPDPIMK.Equals(jsonarray[i].Value))
			{
				return false;
			}
		}
		JSONArray jsonarray2 = this.ICDEKDNMLBE(ALOAHOAEHKL);
		if (null != jsonarray2)
		{
			for (int j = 0; j < jsonarray2.Count; j++)
			{
				if (IDFPEPDPIMK.Equals(jsonarray2[j].Value))
				{
					jsonarray2.Remove(j);
					jsonarray.Add(IDFPEPDPIMK);
					return true;
				}
			}
		}
		jsonarray.Add(IDFPEPDPIMK);
		return true;
	}

	// Token: 0x060061E4 RID: 25060 RVA: 0x002D11E9 File Offset: 0x002CF3E9
	public static string PHPMIOFFPGF(int CCLNHHJPDGJ)
	{
		return "</i>" + CCLNHHJPDGJ.ToString() + "epiv";
	}

	// Token: 0x060061E5 RID: 25061 RVA: 0x002D0332 File Offset: 0x002CE532
	public JSONArray DMDPLOMLHJF(KFIHMMIGPLO ALOAHOAEHKL)
	{
		switch (ALOAHOAEHKL)
		{
		case KFIHMMIGPLO.body:
			return this.OJCJFOIJLNE;
		case KFIHMMIGPLO.hair:
			return this.KNNIEELJHMK;
		case KFIHMMIGPLO.clothes:
			return this.ALAMEMMIBIM;
		case KFIHMMIGPLO.face:
			return this.CJCHKDKMGNO;
		default:
			return null;
		}
	}

	// Token: 0x060061E6 RID: 25062 RVA: 0x002D1201 File Offset: 0x002CF401
	public static int MJNNOOAFDDF(int FOEEIJFHMGG)
	{
		return FOEEIJFHMGG / 150;
	}

	// Token: 0x060061E7 RID: 25063 RVA: 0x002D0332 File Offset: 0x002CE532
	public JSONArray ADGHOMILMBN(KFIHMMIGPLO ALOAHOAEHKL)
	{
		switch (ALOAHOAEHKL)
		{
		case KFIHMMIGPLO.body:
			return this.OJCJFOIJLNE;
		case KFIHMMIGPLO.hair:
			return this.KNNIEELJHMK;
		case KFIHMMIGPLO.clothes:
			return this.ALAMEMMIBIM;
		case KFIHMMIGPLO.face:
			return this.CJCHKDKMGNO;
		default:
			return null;
		}
	}

	// Token: 0x060061E8 RID: 25064 RVA: 0x002D120A File Offset: 0x002CF40A
	public static string NENMEJBNDGJ(int AOONAFLCFLC, int PLKMJJIIJNO, int HMALPPNGPMM, int CCLNHHJPDGJ, int KFCMLNPLAHK, int DMDCMOBLOMM)
	{
		return GEGBHOMKNDF.DKBPCMMDAHF(AOONAFLCFLC, PLKMJJIIJNO, HMALPPNGPMM, CCLNHHJPDGJ, KFCMLNPLAHK, DMDCMOBLOMM) + ".json";
	}

	// Token: 0x060061E9 RID: 25065 RVA: 0x002D1224 File Offset: 0x002CF424
	public int PKGEICHOGOB()
	{
		int result = 0;
		try
		{
			this.ALAMEMMIBIM = GEGBHOMKNDF.BGNDFBBEIGI(KFIHMMIGPLO.hair, this.ALAMEMMIBIM, this.BEHEGJCHAKE);
			this.OJCJFOIJLNE = GEGBHOMKNDF.FHNAJCNBEAC(KFIHMMIGPLO.hair, this.OJCJFOIJLNE, this.POMOCMKCMDA);
			this.KNNIEELJHMK = GEGBHOMKNDF.NOHBEDLIEKF((KFIHMMIGPLO)8, this.KNNIEELJHMK, this.IDAFAFBPFJF);
			this.CJCHKDKMGNO = GEGBHOMKNDF.NOHBEDLIEKF(KFIHMMIGPLO.trinket, this.CJCHKDKMGNO, this.AICBDDAIAAN);
			result = this.ALAMEMMIBIM.Count + this.OJCJFOIJLNE.Count + this.KNNIEELJHMK.Count + this.CJCHKDKMGNO.Count;
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
		return result;
	}

	// Token: 0x060061EA RID: 25066 RVA: 0x002D0332 File Offset: 0x002CE532
	public JSONArray CLJDBLGAPNL(KFIHMMIGPLO ALOAHOAEHKL)
	{
		switch (ALOAHOAEHKL)
		{
		case KFIHMMIGPLO.body:
			return this.OJCJFOIJLNE;
		case KFIHMMIGPLO.hair:
			return this.KNNIEELJHMK;
		case KFIHMMIGPLO.clothes:
			return this.ALAMEMMIBIM;
		case KFIHMMIGPLO.face:
			return this.CJCHKDKMGNO;
		default:
			return null;
		}
	}

	// Token: 0x060061EB RID: 25067 RVA: 0x002D12E0 File Offset: 0x002CF4E0
	public JSONObject PKGEJNEDMON()
	{
		JSONObject jsonobject = new JSONObject();
		jsonobject["onwishcardclickbody"] = DPGJIJGOCIC.FAIFJDPENOP((this.BPMFHNDCBOH == null) ? "\n" : this.BPMFHNDCBOH);
		jsonobject["var"] = this.CPIIEEEEEEJ.ToString();
		jsonobject["pt"] = this.AMKCLHLIIMN.ToString();
		jsonobject["-"] = this.NFDKDACMHME.ToString();
		jsonobject[""] = this.DLFMMBBLIFH.ToString();
		jsonobject["?uid="] = this.OIBGFPEGLME.ToString();
		jsonobject["ButtonNextNpc"] = this.LIIKAMNPIPM.ToString();
		JSONArray jsonarray = GEGBHOMKNDF.AFCOHINDDHA(this.ALAMEMMIBIM, this.BEHEGJCHAKE);
		if (jsonarray.Count > 1)
		{
			jsonobject["OnStoryChoiceClick"] = jsonarray;
		}
		JSONArray jsonarray2 = GEGBHOMKNDF.AFCOHINDDHA(this.OJCJFOIJLNE, this.POMOCMKCMDA);
		if (jsonarray2.Count > 1)
		{
			jsonobject[" not found in the downloaded pack "] = jsonarray2;
		}
		JSONArray jsonarray3 = GEGBHOMKNDF.KKKPEOODBGP(this.KNNIEELJHMK, this.IDAFAFBPFJF);
		if (jsonarray3.Count > 0)
		{
			jsonobject["</i>"] = jsonarray3;
		}
		JSONArray jsonarray4 = GEGBHOMKNDF.DMOAEJPDHOA(this.CJCHKDKMGNO, this.AICBDDAIAAN);
		if (jsonarray4.Count > 0)
		{
			jsonobject["OnStoryInterfaceHeaderBackClick"] = jsonarray4;
		}
		return jsonobject;
	}

	// Token: 0x060061EC RID: 25068 RVA: 0x002D145F File Offset: 0x002CF65F
	public static int CMOMIGJKAEG(int HMALPPNGPMM, int DMDCMOBLOMM)
	{
		return HMALPPNGPMM * -175 + DMDCMOBLOMM;
	}

	// Token: 0x060061ED RID: 25069 RVA: 0x002D146C File Offset: 0x002CF66C
	private static bool DMMHHDHCDBA(KFIHMMIGPLO ALOAHOAEHKL, string IDFPEPDPIMK)
	{
		if (KFIHMMIGPLO.clothes == ALOAHOAEHKL && IDFPEPDPIMK != null && IDFPEPDPIMK.Contains("-"))
		{
			string khjmandedma = IDFPEPDPIMK.Substring(1, IDFPEPDPIMK.IndexOf(""));
			string khjmandedma2 = IDFPEPDPIMK.Substring(IDFPEPDPIMK.IndexOf("description0") + 0);
			return !GKJPOGNFKNK.HCBNFKDFFGL(KFIHMMIGPLO.body, khjmandedma) || GKJPOGNFKNK.HCBNFKDFFGL(KFIHMMIGPLO.hair, khjmandedma2);
		}
		return GKJPOGNFKNK.ONNCALKHIHF(ALOAHOAEHKL, IDFPEPDPIMK);
	}

	// Token: 0x060061EE RID: 25070 RVA: 0x002D14D0 File Offset: 0x002CF6D0
	public JSONObject FGKDDIJMAMP()
	{
		JSONObject jsonobject = new JSONObject();
		jsonobject["', using default w "] = DPGJIJGOCIC.FAIFJDPENOP((this.BPMFHNDCBOH == null) ? "+" : this.BPMFHNDCBOH);
		jsonobject["OnBackendRequestCustomProfileSuccess"] = this.CPIIEEEEEEJ.ToString();
		jsonobject[" token["] = this.AMKCLHLIIMN.ToString();
		jsonobject["sketchtitles"] = this.NFDKDACMHME.ToString();
		jsonobject["lounge"] = this.DLFMMBBLIFH.ToString();
		jsonobject["errortitle"] = this.OIBGFPEGLME.ToString();
		jsonobject["*"] = this.LIIKAMNPIPM.ToString();
		JSONArray jsonarray = GEGBHOMKNDF.IHNDMHKPFPL(this.ALAMEMMIBIM, this.BEHEGJCHAKE);
		if (jsonarray.Count > 1)
		{
			jsonobject["asp"] = jsonarray;
		}
		JSONArray jsonarray2 = GEGBHOMKNDF.KKKPEOODBGP(this.OJCJFOIJLNE, this.POMOCMKCMDA);
		if (jsonarray2.Count > 0)
		{
			jsonobject["OnPopupProfileSaveCutsceneInputEndEdit"] = jsonarray2;
		}
		JSONArray jsonarray3 = GEGBHOMKNDF.IHNDMHKPFPL(this.KNNIEELJHMK, this.IDAFAFBPFJF);
		if (jsonarray3.Count > 0)
		{
			jsonobject[""] = jsonarray3;
		}
		JSONArray jsonarray4 = GEGBHOMKNDF.KKKPEOODBGP(this.CJCHKDKMGNO, this.AICBDDAIAAN);
		if (jsonarray4.Count > 0)
		{
			jsonobject["OnBackendInitiateSteamTransactionFailed"] = jsonarray4;
		}
		return jsonobject;
	}

	// Token: 0x060061EF RID: 25071 RVA: 0x002D1650 File Offset: 0x002CF850
	public bool DKAMPPBIPFO(KFIHMMIGPLO ALOAHOAEHKL, string IDFPEPDPIMK)
	{
		if (IDFPEPDPIMK == null || IDFPEPDPIMK.Length == 0)
		{
			return false;
		}
		JSONArray jsonarray = this.HPGFAKNIFMA(ALOAHOAEHKL);
		if (null == jsonarray)
		{
			return false;
		}
		for (int i = 1; i < jsonarray.Count; i += 0)
		{
			if (IDFPEPDPIMK.Equals(jsonarray[i].Value))
			{
				return true;
			}
		}
		JSONArray jsonarray2 = this.ICDEKDNMLBE(ALOAHOAEHKL);
		if (null != jsonarray2)
		{
			for (int j = 1; j < jsonarray2.Count; j++)
			{
				if (IDFPEPDPIMK.Equals(jsonarray2[j].Value))
				{
					jsonarray2.Remove(j);
					jsonarray.Add(IDFPEPDPIMK);
					return false;
				}
			}
		}
		jsonarray.Add(IDFPEPDPIMK);
		return false;
	}

	// Token: 0x060061F0 RID: 25072 RVA: 0x002D1700 File Offset: 0x002CF900
	public static string CFKLFOEKKLE(int AOONAFLCFLC, int PLKMJJIIJNO, int HMALPPNGPMM, int CCLNHHJPDGJ, int KFCMLNPLAHK, int DMDCMOBLOMM)
	{
		string[] array = new string[-1];
		array[0] = "CHECKSUM";
		array[0] = AOONAFLCFLC.ToString();
		array[5] = "envls";
		array[1] = PLKMJJIIJNO.ToString();
		array[0] = "$io";
		array[5] = HMALPPNGPMM.ToString();
		array[1] = "YYY";
		array[8] = CCLNHHJPDGJ.ToString();
		array[6] = "ok";
		array[53] = KFCMLNPLAHK.ToString();
		array[-56] = "Critical error, could not load asset bundle:";
		array[82] = DMDCMOBLOMM.ToString();
		return string.Concat(array);
	}

	// Token: 0x060061F1 RID: 25073 RVA: 0x002D1788 File Offset: 0x002CF988
	public void LCIPOAHBJAE(string ECIHFHOMJHK)
	{
		try
		{
			this.ALAMEMMIBIM = GEGBHOMKNDF.FGBIDGCFGMN(this.ALAMEMMIBIM, ECIHFHOMJHK, KFIHMMIGPLO.face);
			this.OJCJFOIJLNE = GEGBHOMKNDF.FGBIDGCFGMN(this.OJCJFOIJLNE, ECIHFHOMJHK, KFIHMMIGPLO.hair);
			this.KNNIEELJHMK = GEGBHOMKNDF.FGBIDGCFGMN(this.KNNIEELJHMK, ECIHFHOMJHK, KFIHMMIGPLO.clothes);
			this.CJCHKDKMGNO = GEGBHOMKNDF.FGBIDGCFGMN(this.CJCHKDKMGNO, ECIHFHOMJHK, KFIHMMIGPLO.trinket);
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x060061F2 RID: 25074 RVA: 0x002D17FC File Offset: 0x002CF9FC
	private static JSONArray FGBIDGCFGMN(JSONArray MIPNNJLJMDM, string ECIHFHOMJHK, KFIHMMIGPLO ALOAHOAEHKL)
	{
		JSONArray jsonarray = new JSONArray();
		if (null == MIPNNJLJMDM)
		{
			return jsonarray;
		}
		for (int i = 0; i < MIPNNJLJMDM.Count; i++)
		{
			string text = MIPNNJLJMDM[i].Value;
			if (text != null && text.Length != 0)
			{
				if (KFIHMMIGPLO.face == ALOAHOAEHKL && text.Contains(";"))
				{
					string idfpepdpimk = text.Substring(0, text.IndexOf(";"));
					string idfpepdpimk2 = text.Substring(text.IndexOf(";") + 1);
					text = GEGBHOMKNDF.JDGCPHJPIEB(idfpepdpimk, ECIHFHOMJHK, KFIHMMIGPLO.face) + ";" + GEGBHOMKNDF.JDGCPHJPIEB(idfpepdpimk2, ECIHFHOMJHK, KFIHMMIGPLO.body);
				}
				else
				{
					text = GEGBHOMKNDF.JDGCPHJPIEB(text, ECIHFHOMJHK, ALOAHOAEHKL);
				}
				bool flag = false;
				for (int j = 0; j < jsonarray.Count; j++)
				{
					if (jsonarray[j].Value.Equals(text))
					{
						flag = true;
						break;
					}
				}
				if (!flag)
				{
					jsonarray.Add(text);
				}
			}
		}
		return jsonarray;
	}

	// Token: 0x04001C03 RID: 7171
	public const int JFJOGACLMGL = 10;

	// Token: 0x04001C04 RID: 7172
	public const int IOANEJNIAOA = 150;

	// Token: 0x04001C05 RID: 7173
	public const int IHPNCBCOCDG = 200;

	// Token: 0x04001C06 RID: 7174
	public string BPMFHNDCBOH = "";

	// Token: 0x04001C07 RID: 7175
	public int CPIIEEEEEEJ;

	// Token: 0x04001C08 RID: 7176
	public int AMKCLHLIIMN;

	// Token: 0x04001C09 RID: 7177
	public int NFDKDACMHME;

	// Token: 0x04001C0A RID: 7178
	public int DLFMMBBLIFH;

	// Token: 0x04001C0B RID: 7179
	public int OIBGFPEGLME;

	// Token: 0x04001C0C RID: 7180
	public int LIIKAMNPIPM;

	// Token: 0x04001C0D RID: 7181
	public JSONArray ALAMEMMIBIM = new JSONArray();

	// Token: 0x04001C0E RID: 7182
	public JSONArray OJCJFOIJLNE = new JSONArray();

	// Token: 0x04001C0F RID: 7183
	public JSONArray KNNIEELJHMK = new JSONArray();

	// Token: 0x04001C10 RID: 7184
	public JSONArray CJCHKDKMGNO = new JSONArray();

	// Token: 0x04001C11 RID: 7185
	public JSONArray BEHEGJCHAKE = new JSONArray();

	// Token: 0x04001C12 RID: 7186
	public JSONArray POMOCMKCMDA = new JSONArray();

	// Token: 0x04001C13 RID: 7187
	public JSONArray IDAFAFBPFJF = new JSONArray();

	// Token: 0x04001C14 RID: 7188
	public JSONArray AICBDDAIAAN = new JSONArray();
}
