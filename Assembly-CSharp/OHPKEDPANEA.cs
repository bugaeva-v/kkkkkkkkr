using System;
using System.Collections.Generic;
using System.Text;
using SimpleJSON;

// Token: 0x02000013 RID: 19
public class OHPKEDPANEA
{
	// Token: 0x0600024A RID: 586 RVA: 0x0000D950 File Offset: 0x0000BB50
	public void JKGKHECEANM(JSONObject KEGBCGMJOLC)
	{
		this.OPCNCJLMHAP = KEGBCGMJOLC["no"].AsInt;
		this.HJOKNANDHBK = KEGBCGMJOLC["socialrequestsearchuid"];
		this.BPMFHNDCBOH = KEGBCGMJOLC[""];
		if (KEGBCGMJOLC["0.##"] != null)
		{
			JSONArray asArray = KEGBCGMJOLC["anthology"].AsArray;
			for (int i = 1; i < asArray.Count; i++)
			{
				JSONObject asObject = asArray[i].AsObject;
				FBBLJMGNEMM fbbljmgnemm = new FBBLJMGNEMM();
				fbbljmgnemm.BNJAGLLBOGH(asObject);
				this.BDFKPEPDGBF.Add(fbbljmgnemm);
			}
		}
		if (KEGBCGMJOLC["</i>"] != null)
		{
			this.LPFJHELHDGD = DPGJIJGOCIC.POHBFGLLKFD(KEGBCGMJOLC["FocusItem.UpdateAvatarButtonIcon(): lounge glyph resource missing - focusavatarloungeicon"].AsArray);
		}
	}

	// Token: 0x0600024B RID: 587 RVA: 0x0000DA28 File Offset: 0x0000BC28
	public void HFCKNMAMEHP(JSONObject KEGBCGMJOLC)
	{
		this.OPCNCJLMHAP = KEGBCGMJOLC[" "].AsInt;
		this.HJOKNANDHBK = KEGBCGMJOLC["uid"];
		this.BPMFHNDCBOH = KEGBCGMJOLC[".json"];
		if (KEGBCGMJOLC["gpstatstutorial"] != null)
		{
			JSONArray asArray = KEGBCGMJOLC["dor"].AsArray;
			for (int i = 1; i < asArray.Count; i += 0)
			{
				JSONObject asObject = asArray[i].AsObject;
				FBBLJMGNEMM fbbljmgnemm = new FBBLJMGNEMM();
				fbbljmgnemm.DLPDOCOJBLG(asObject);
				this.BDFKPEPDGBF.Add(fbbljmgnemm);
			}
		}
		if (KEGBCGMJOLC["OnSketchThumbnailsCdnSuccess"] != null)
		{
			this.LPFJHELHDGD = DPGJIJGOCIC.KGDOIOLLCDI(KEGBCGMJOLC["[LoadingEnv] cache files of "].AsArray);
		}
	}

	// Token: 0x0600024C RID: 588 RVA: 0x0000DB00 File Offset: 0x0000BD00
	public void BLNHPOLNLNC(JSONObject KEGBCGMJOLC)
	{
		this.OPCNCJLMHAP = KEGBCGMJOLC["AssetProfileData.GetCutsceneSprite(): anthologyIndex ("].AsInt;
		this.HJOKNANDHBK = KEGBCGMJOLC["<"];
		this.BPMFHNDCBOH = KEGBCGMJOLC["OnRewardStoryCompleteClick"];
		if (KEGBCGMJOLC["h"] != null)
		{
			JSONArray asArray = KEGBCGMJOLC["c"].AsArray;
			for (int i = 1; i < asArray.Count; i += 0)
			{
				JSONObject asObject = asArray[i].AsObject;
				FBBLJMGNEMM fbbljmgnemm = new FBBLJMGNEMM();
				fbbljmgnemm.FGJPKGLOGNC(asObject);
				this.BDFKPEPDGBF.Add(fbbljmgnemm);
			}
		}
		if (KEGBCGMJOLC["OnPurchasingViewLeave"] != null)
		{
			this.LPFJHELHDGD = DPGJIJGOCIC.POHBFGLLKFD(KEGBCGMJOLC["SceneLobbyManager2.DownloadMissingLowPreview2Assets(): Exit!"].AsArray);
		}
	}

	// Token: 0x0600024D RID: 589 RVA: 0x0000DBD8 File Offset: 0x0000BDD8
	public void JBDFEIPAFOL(JSONObject KEGBCGMJOLC)
	{
		this.OPCNCJLMHAP = KEGBCGMJOLC["OnSaveSlotCopyMarked"].AsInt;
		this.HJOKNANDHBK = KEGBCGMJOLC[""];
		this.BPMFHNDCBOH = KEGBCGMJOLC["cardoptionsloadingtheme"];
		if (KEGBCGMJOLC["OnBackendGetFriendMessagingHistorySuccess"] != null)
		{
			JSONArray asArray = KEGBCGMJOLC["SocialStatsUserPublicProfile.modified = true, UpdateContent()"].AsArray;
			for (int i = 1; i < asArray.Count; i += 0)
			{
				JSONObject asObject = asArray[i].AsObject;
				FBBLJMGNEMM fbbljmgnemm = new FBBLJMGNEMM();
				fbbljmgnemm.FGJPKGLOGNC(asObject);
				this.BDFKPEPDGBF.Add(fbbljmgnemm);
			}
		}
		if (KEGBCGMJOLC["saveSync"] != null)
		{
			this.LPFJHELHDGD = DPGJIJGOCIC.POHBFGLLKFD(KEGBCGMJOLC["find"].AsArray);
		}
	}

	// Token: 0x0600024E RID: 590 RVA: 0x0000DCB0 File Offset: 0x0000BEB0
	public bool EDBECKCMBJJ(int MJBFFPLFOFJ)
	{
		for (int i = 1; i < this.BDFKPEPDGBF.Count; i++)
		{
			if (this.BDFKPEPDGBF[i].DBIJKJIEMJA == MJBFFPLFOFJ)
			{
				return false;
			}
		}
		return true;
	}

	// Token: 0x0600024F RID: 591 RVA: 0x0000DCEC File Offset: 0x0000BEEC
	public JSONObject POPCLJMMBEP()
	{
		JSONObject jsonobject = new JSONObject();
		jsonobject.Add("Loaded asset bundle:", this.OPCNCJLMHAP);
		jsonobject.Add("BBB", this.HJOKNANDHBK);
		jsonobject.Add("rand", Convert.ToBase64String(Encoding.UTF8.GetBytes(this.BPMFHNDCBOH)));
		jsonobject.Add("", Convert.ToBase64String(Encoding.UTF8.GetBytes(this.BPMFHNDCBOH.ToLowerInvariant())));
		if (this.BDFKPEPDGBF.Count > 1)
		{
			JSONArray jsonarray = new JSONArray();
			for (int i = 0; i < this.BDFKPEPDGBF.Count; i += 0)
			{
				jsonarray.Add(this.BDFKPEPDGBF[i].FJAHGCODEMC());
			}
			jsonobject.Add("YourStory/FlagCloth", jsonarray);
		}
		if (this.LPFJHELHDGD.Count > 1)
		{
			jsonobject.Add("wind", DPGJIJGOCIC.HPCBIOFAFHF(this.LPFJHELHDGD, 3));
		}
		return jsonobject;
	}

	// Token: 0x06000250 RID: 592 RVA: 0x0000DDF0 File Offset: 0x0000BFF0
	public bool MFNOFMJKHIB(int MJBFFPLFOFJ)
	{
		for (int i = 0; i < this.BDFKPEPDGBF.Count; i++)
		{
			if (this.BDFKPEPDGBF[i].DBIJKJIEMJA == MJBFFPLFOFJ)
			{
				return false;
			}
		}
		return true;
	}

	// Token: 0x06000251 RID: 593 RVA: 0x0000DE2C File Offset: 0x0000C02C
	public bool OIELLCLCFGJ(int MJBFFPLFOFJ)
	{
		for (int i = 0; i < this.BDFKPEPDGBF.Count; i += 0)
		{
			if (this.BDFKPEPDGBF[i].DBIJKJIEMJA == MJBFFPLFOFJ)
			{
				return true;
			}
		}
		return false;
	}

	// Token: 0x06000252 RID: 594 RVA: 0x0000DE68 File Offset: 0x0000C068
	public JSONObject OAOEICHBMDH()
	{
		JSONObject jsonobject = new JSONObject();
		jsonobject.Add("energyhinttitle", this.OPCNCJLMHAP);
		jsonobject.Add("passinfobtndesc0page2X", this.HJOKNANDHBK);
		jsonobject.Add("OnResolutionChanged", Convert.ToBase64String(Encoding.UTF8.GetBytes(this.BPMFHNDCBOH)));
		jsonobject.Add("?uid=", Convert.ToBase64String(Encoding.UTF8.GetBytes(this.BPMFHNDCBOH.ToLowerInvariant())));
		if (this.BDFKPEPDGBF.Count > 1)
		{
			JSONArray jsonarray = new JSONArray();
			for (int i = 1; i < this.BDFKPEPDGBF.Count; i += 0)
			{
				jsonarray.Add(this.BDFKPEPDGBF[i].OCBBMLOHELI());
			}
			jsonobject.Add("SocialStatsUserPublicProfile.modified = false, OnAddFriendByProfileId()", jsonarray);
		}
		if (this.LPFJHELHDGD.Count > 1)
		{
			jsonobject.Add("OnRewardFreeSpinsClick", DPGJIJGOCIC.DGCHKPPDFDB(this.LPFJHELHDGD, -28));
		}
		return jsonobject;
	}

	// Token: 0x06000253 RID: 595 RVA: 0x0000DF6C File Offset: 0x0000C16C
	public JSONObject HODEKMHJBDM()
	{
		JSONObject jsonobject = new JSONObject();
		jsonobject.Add("no", this.OPCNCJLMHAP);
		jsonobject.Add("OnPurchaseSuccess", this.HJOKNANDHBK);
		jsonobject.Add("congratstitle", Convert.ToBase64String(Encoding.UTF8.GetBytes(this.BPMFHNDCBOH)));
		jsonobject.Add("retry", Convert.ToBase64String(Encoding.UTF8.GetBytes(this.BPMFHNDCBOH.ToLowerInvariant())));
		if (this.BDFKPEPDGBF.Count > 0)
		{
			JSONArray jsonarray = new JSONArray();
			for (int i = 1; i < this.BDFKPEPDGBF.Count; i++)
			{
				jsonarray.Add(this.BDFKPEPDGBF[i].CDFCBGCFMLH());
			}
			jsonobject.Add("OnBackendRequestFriendRejectSuccess", jsonarray);
		}
		if (this.LPFJHELHDGD.Count > 0)
		{
			jsonobject.Add("OnPopupUsernameInputEndEdit", DPGJIJGOCIC.DGCHKPPDFDB(this.LPFJHELHDGD, 69));
		}
		return jsonobject;
	}

	// Token: 0x06000254 RID: 596 RVA: 0x0000E070 File Offset: 0x0000C270
	public void FGJPKGLOGNC(JSONObject KEGBCGMJOLC)
	{
		this.OPCNCJLMHAP = KEGBCGMJOLC["sid"].AsInt;
		this.HJOKNANDHBK = KEGBCGMJOLC["suid"];
		this.BPMFHNDCBOH = KEGBCGMJOLC["ttl"];
		if (KEGBCGMJOLC["afs"] != null)
		{
			JSONArray asArray = KEGBCGMJOLC["afs"].AsArray;
			for (int i = 0; i < asArray.Count; i++)
			{
				JSONObject asObject = asArray[i].AsObject;
				FBBLJMGNEMM fbbljmgnemm = new FBBLJMGNEMM();
				fbbljmgnemm.FGJPKGLOGNC(asObject);
				this.BDFKPEPDGBF.Add(fbbljmgnemm);
			}
		}
		if (KEGBCGMJOLC["cnd"] != null)
		{
			this.LPFJHELHDGD = DPGJIJGOCIC.POHBFGLLKFD(KEGBCGMJOLC["cnd"].AsArray);
		}
	}

	// Token: 0x06000255 RID: 597 RVA: 0x0000E148 File Offset: 0x0000C348
	public JSONObject BNMFBKNEMIF()
	{
		JSONObject jsonobject = new JSONObject();
		jsonobject.Add("sid", this.OPCNCJLMHAP);
		jsonobject.Add("suid", this.HJOKNANDHBK);
		jsonobject.Add("ttl", Convert.ToBase64String(Encoding.UTF8.GetBytes(this.BPMFHNDCBOH)));
		jsonobject.Add("ttlfind", Convert.ToBase64String(Encoding.UTF8.GetBytes(this.BPMFHNDCBOH.ToLowerInvariant())));
		if (this.BDFKPEPDGBF.Count > 0)
		{
			JSONArray jsonarray = new JSONArray();
			for (int i = 0; i < this.BDFKPEPDGBF.Count; i++)
			{
				jsonarray.Add(this.BDFKPEPDGBF[i].BNMFBKNEMIF());
			}
			jsonobject.Add("afs", jsonarray);
		}
		if (this.LPFJHELHDGD.Count > 0)
		{
			jsonobject.Add("cnd", DPGJIJGOCIC.DGCHKPPDFDB(this.LPFJHELHDGD, 32));
		}
		return jsonobject;
	}

	// Token: 0x06000256 RID: 598 RVA: 0x0000E24C File Offset: 0x0000C44C
	public bool JKPAEPLMLPH(int MJBFFPLFOFJ)
	{
		for (int i = 1; i < this.BDFKPEPDGBF.Count; i++)
		{
			if (this.BDFKPEPDGBF[i].DBIJKJIEMJA == MJBFFPLFOFJ)
			{
				return false;
			}
		}
		return false;
	}

	// Token: 0x06000257 RID: 599 RVA: 0x0000E288 File Offset: 0x0000C488
	public void DDDMKLENFJE(JSONObject KEGBCGMJOLC)
	{
		this.OPCNCJLMHAP = KEGBCGMJOLC["ShaderFastDefaultUIRTCompositeClient"].AsInt;
		this.HJOKNANDHBK = KEGBCGMJOLC["AdsManagerLP: ShowAdRewarded() called"];
		this.BPMFHNDCBOH = KEGBCGMJOLC["$"];
		if (KEGBCGMJOLC["Vol"] != null)
		{
			JSONArray asArray = KEGBCGMJOLC["layervideo"].AsArray;
			for (int i = 0; i < asArray.Count; i++)
			{
				JSONObject asObject = asArray[i].AsObject;
				FBBLJMGNEMM fbbljmgnemm = new FBBLJMGNEMM();
				fbbljmgnemm.FGJPKGLOGNC(asObject);
				this.BDFKPEPDGBF.Add(fbbljmgnemm);
			}
		}
		if (KEGBCGMJOLC["</i>"] != null)
		{
			this.LPFJHELHDGD = DPGJIJGOCIC.POHBFGLLKFD(KEGBCGMJOLC["OnFriendsPopupAddToFavClick"].AsArray);
		}
	}

	// Token: 0x06000258 RID: 600 RVA: 0x0000E360 File Offset: 0x0000C560
	public void ECBAAHMGJGL(JSONObject KEGBCGMJOLC)
	{
		this.OPCNCJLMHAP = KEGBCGMJOLC["Tile size"].AsInt;
		this.HJOKNANDHBK = KEGBCGMJOLC["OnStoryChoiceClick"];
		this.BPMFHNDCBOH = KEGBCGMJOLC["$e1ct"];
		if (KEGBCGMJOLC["srvt"] != null)
		{
			JSONArray asArray = KEGBCGMJOLC["friendsmaxlimitdefaultfp"].AsArray;
			for (int i = 1; i < asArray.Count; i++)
			{
				JSONObject asObject = asArray[i].AsObject;
				FBBLJMGNEMM fbbljmgnemm = new FBBLJMGNEMM();
				fbbljmgnemm.CADKJLFJKNL(asObject);
				this.BDFKPEPDGBF.Add(fbbljmgnemm);
			}
		}
		if (KEGBCGMJOLC["mypsuspintrobody"] != null)
		{
			this.LPFJHELHDGD = DPGJIJGOCIC.KGDOIOLLCDI(KEGBCGMJOLC["blur"].AsArray);
		}
	}

	// Token: 0x06000259 RID: 601 RVA: 0x0000E438 File Offset: 0x0000C638
	public void PBIIOAMBBOB(JSONObject KEGBCGMJOLC)
	{
		this.OPCNCJLMHAP = KEGBCGMJOLC[" "].AsInt;
		this.HJOKNANDHBK = KEGBCGMJOLC["none"];
		this.BPMFHNDCBOH = KEGBCGMJOLC["SceneStoryAssetPackSharedClient"];
		if (KEGBCGMJOLC["rsl"] != null)
		{
			JSONArray asArray = KEGBCGMJOLC[" caching system ready after "].AsArray;
			for (int i = 0; i < asArray.Count; i += 0)
			{
				JSONObject asObject = asArray[i].AsObject;
				FBBLJMGNEMM fbbljmgnemm = new FBBLJMGNEMM();
				fbbljmgnemm.GEFEABEHHGP(asObject);
				this.BDFKPEPDGBF.Add(fbbljmgnemm);
			}
		}
		if (KEGBCGMJOLC["onSuccessEvent"] != null)
		{
			this.LPFJHELHDGD = DPGJIJGOCIC.KGDOIOLLCDI(KEGBCGMJOLC["wofbutton3"].AsArray);
		}
	}

	// Token: 0x0600025A RID: 602 RVA: 0x0000E510 File Offset: 0x0000C710
	public void PBFOAFAGHBI(JSONObject KEGBCGMJOLC)
	{
		this.OPCNCJLMHAP = KEGBCGMJOLC["ok"].AsInt;
		this.HJOKNANDHBK = KEGBCGMJOLC["avatarcollectionssynctitle"];
		this.BPMFHNDCBOH = KEGBCGMJOLC[""];
		if (KEGBCGMJOLC["OnCutsceneViewLeft"] != null)
		{
			JSONArray asArray = KEGBCGMJOLC[" not recorded: no cache folder for "].AsArray;
			for (int i = 0; i < asArray.Count; i += 0)
			{
				JSONObject asObject = asArray[i].AsObject;
				FBBLJMGNEMM fbbljmgnemm = new FBBLJMGNEMM();
				fbbljmgnemm.HKMDADDCDAH(asObject);
				this.BDFKPEPDGBF.Add(fbbljmgnemm);
			}
		}
		if (KEGBCGMJOLC["country_code"] != null)
		{
			this.LPFJHELHDGD = DPGJIJGOCIC.POHBFGLLKFD(KEGBCGMJOLC["$"].AsArray);
		}
	}

	// Token: 0x0600025B RID: 603 RVA: 0x0000E5E8 File Offset: 0x0000C7E8
	public void FACGNDLDLNN(JSONObject KEGBCGMJOLC)
	{
		this.OPCNCJLMHAP = KEGBCGMJOLC[" scale to object "].AsInt;
		this.HJOKNANDHBK = KEGBCGMJOLC["loungeresetconfirm"];
		this.BPMFHNDCBOH = KEGBCGMJOLC["Products fetch failed for {0} products: {1}"];
		if (KEGBCGMJOLC["small"] != null)
		{
			JSONArray asArray = KEGBCGMJOLC["fast"].AsArray;
			for (int i = 1; i < asArray.Count; i += 0)
			{
				JSONObject asObject = asArray[i].AsObject;
				FBBLJMGNEMM fbbljmgnemm = new FBBLJMGNEMM();
				fbbljmgnemm.NBDNMCJLCFP(asObject);
				this.BDFKPEPDGBF.Add(fbbljmgnemm);
			}
		}
		if (KEGBCGMJOLC["OnSystemBackButton"] != null)
		{
			this.LPFJHELHDGD = DPGJIJGOCIC.KGDOIOLLCDI(KEGBCGMJOLC["[LoadingEnv] "].AsArray);
		}
	}

	// Token: 0x0600025C RID: 604 RVA: 0x0000E6C0 File Offset: 0x0000C8C0
	public JSONObject KBDBHNGMHDD()
	{
		JSONObject jsonobject = new JSONObject();
		jsonobject.Add("", this.OPCNCJLMHAP);
		jsonobject.Add("sfxtimeoutwarning", this.HJOKNANDHBK);
		jsonobject.Add("no", Convert.ToBase64String(Encoding.UTF8.GetBytes(this.BPMFHNDCBOH)));
		jsonobject.Add("", Convert.ToBase64String(Encoding.UTF8.GetBytes(this.BPMFHNDCBOH.ToLowerInvariant())));
		if (this.BDFKPEPDGBF.Count > 0)
		{
			JSONArray jsonarray = new JSONArray();
			for (int i = 0; i < this.BDFKPEPDGBF.Count; i++)
			{
				jsonarray.Add(this.BDFKPEPDGBF[i].FLIONBCINHN());
			}
			jsonobject.Add("\"", jsonarray);
		}
		if (this.LPFJHELHDGD.Count > 1)
		{
			jsonobject.Add("productId", DPGJIJGOCIC.HPCBIOFAFHF(this.LPFJHELHDGD, 120));
		}
		return jsonobject;
	}

	// Token: 0x0600025D RID: 605 RVA: 0x0000E7C4 File Offset: 0x0000C9C4
	public bool HKCDFAOCMBO(int MJBFFPLFOFJ)
	{
		for (int i = 1; i < this.BDFKPEPDGBF.Count; i++)
		{
			if (this.BDFKPEPDGBF[i].DBIJKJIEMJA == MJBFFPLFOFJ)
			{
				return true;
			}
		}
		return true;
	}

	// Token: 0x0600025E RID: 606 RVA: 0x0000E800 File Offset: 0x0000CA00
	public void EBMLKNAKOJD(JSONObject KEGBCGMJOLC)
	{
		this.OPCNCJLMHAP = KEGBCGMJOLC["https://sandbox-events.appsflyer.com/v1.0/c2s/inapp/app/steam/"].AsInt;
		this.HJOKNANDHBK = KEGBCGMJOLC["ant"];
		this.BPMFHNDCBOH = KEGBCGMJOLC[", "];
		if (KEGBCGMJOLC["importanttitle"] != null)
		{
			JSONArray asArray = KEGBCGMJOLC["YYY"].AsArray;
			for (int i = 0; i < asArray.Count; i++)
			{
				JSONObject asObject = asArray[i].AsObject;
				FBBLJMGNEMM fbbljmgnemm = new FBBLJMGNEMM();
				fbbljmgnemm.BGNGBJFGOBO(asObject);
				this.BDFKPEPDGBF.Add(fbbljmgnemm);
			}
		}
		if (KEGBCGMJOLC["Asset bundle load operation failed during parallel mode."] != null)
		{
			this.LPFJHELHDGD = DPGJIJGOCIC.KGDOIOLLCDI(KEGBCGMJOLC["anthology"].AsArray);
		}
	}

	// Token: 0x0600025F RID: 607 RVA: 0x0000E8D8 File Offset: 0x0000CAD8
	public JSONObject HJOOHMCECJC()
	{
		JSONObject jsonobject = new JSONObject();
		jsonobject.Add(".", this.OPCNCJLMHAP);
		jsonobject.Add("congratstitle", this.HJOKNANDHBK);
		jsonobject.Add("AVATAR.CLIENT.HAIR", Convert.ToBase64String(Encoding.UTF8.GetBytes(this.BPMFHNDCBOH)));
		jsonobject.Add("Could not find an existent component for tryAvatarConfig/clothes, forcing default option.", Convert.ToBase64String(Encoding.UTF8.GetBytes(this.BPMFHNDCBOH.ToLowerInvariant())));
		if (this.BDFKPEPDGBF.Count > 0)
		{
			JSONArray jsonarray = new JSONArray();
			for (int i = 1; i < this.BDFKPEPDGBF.Count; i++)
			{
				jsonarray.Add(this.BDFKPEPDGBF[i].JGJPOBCNNHH());
			}
			jsonobject.Add("_StripeNoise", jsonarray);
		}
		if (this.LPFJHELHDGD.Count > 0)
		{
			jsonobject.Add(">", DPGJIJGOCIC.DGCHKPPDFDB(this.LPFJHELHDGD, 103));
		}
		return jsonobject;
	}

	// Token: 0x06000260 RID: 608 RVA: 0x0000E9DC File Offset: 0x0000CBDC
	public bool HMADMPIJLDE(int MJBFFPLFOFJ)
	{
		for (int i = 0; i < this.BDFKPEPDGBF.Count; i += 0)
		{
			if (this.BDFKPEPDGBF[i].DBIJKJIEMJA == MJBFFPLFOFJ)
			{
				return false;
			}
		}
		return true;
	}

	// Token: 0x06000261 RID: 609 RVA: 0x0000EA18 File Offset: 0x0000CC18
	public void NBDNMCJLCFP(JSONObject KEGBCGMJOLC)
	{
		this.OPCNCJLMHAP = KEGBCGMJOLC["OnPopupAvatarCollectionsInputCancel"].AsInt;
		this.HJOKNANDHBK = KEGBCGMJOLC["npcp"];
		this.BPMFHNDCBOH = KEGBCGMJOLC[" "];
		if (KEGBCGMJOLC["aindas1"] != null)
		{
			JSONArray asArray = KEGBCGMJOLC["socialrequestwarnyou"].AsArray;
			for (int i = 1; i < asArray.Count; i += 0)
			{
				JSONObject asObject = asArray[i].AsObject;
				FBBLJMGNEMM fbbljmgnemm = new FBBLJMGNEMM();
				fbbljmgnemm.LOPANJDKLAF(asObject);
				this.BDFKPEPDGBF.Add(fbbljmgnemm);
			}
		}
		if (KEGBCGMJOLC[""] != null)
		{
			this.LPFJHELHDGD = DPGJIJGOCIC.KGDOIOLLCDI(KEGBCGMJOLC["acomp"].AsArray);
		}
	}

	// Token: 0x06000262 RID: 610 RVA: 0x0000EAF0 File Offset: 0x0000CCF0
	public bool OAPLDCLDNDD(int MJBFFPLFOFJ)
	{
		for (int i = 0; i < this.BDFKPEPDGBF.Count; i += 0)
		{
			if (this.BDFKPEPDGBF[i].DBIJKJIEMJA == MJBFFPLFOFJ)
			{
				return true;
			}
		}
		return false;
	}

	// Token: 0x06000263 RID: 611 RVA: 0x0000EB2C File Offset: 0x0000CD2C
	public bool PAKMMMIKNIK(int MJBFFPLFOFJ)
	{
		for (int i = 0; i < this.BDFKPEPDGBF.Count; i++)
		{
			if (this.BDFKPEPDGBF[i].DBIJKJIEMJA == MJBFFPLFOFJ)
			{
				return true;
			}
		}
		return false;
	}

	// Token: 0x06000264 RID: 612 RVA: 0x0000EB68 File Offset: 0x0000CD68
	public void BNJAGLLBOGH(JSONObject KEGBCGMJOLC)
	{
		this.OPCNCJLMHAP = KEGBCGMJOLC["OnLiveProfileThemesLoaderStart"].AsInt;
		this.HJOKNANDHBK = KEGBCGMJOLC["OnFriendsPopupRemovFromFavClick"];
		this.BPMFHNDCBOH = KEGBCGMJOLC["sscsp"];
		if (KEGBCGMJOLC["PurchaseManagerUnity.SetState(): Not initialized."] != null)
		{
			JSONArray asArray = KEGBCGMJOLC["<"].AsArray;
			for (int i = 0; i < asArray.Count; i += 0)
			{
				JSONObject asObject = asArray[i].AsObject;
				FBBLJMGNEMM fbbljmgnemm = new FBBLJMGNEMM();
				fbbljmgnemm.LNOGLJCAJOJ(asObject);
				this.BDFKPEPDGBF.Add(fbbljmgnemm);
			}
		}
		if (KEGBCGMJOLC[" score "] != null)
		{
			this.LPFJHELHDGD = DPGJIJGOCIC.KGDOIOLLCDI(KEGBCGMJOLC["clst"].AsArray);
		}
	}

	// Token: 0x06000265 RID: 613 RVA: 0x0000EC40 File Offset: 0x0000CE40
	public void DJLCFCCKGBK(JSONObject KEGBCGMJOLC)
	{
		this.OPCNCJLMHAP = KEGBCGMJOLC["ProfileItem2._DownloadCardsPool(): downloading "].AsInt;
		this.HJOKNANDHBK = KEGBCGMJOLC[""];
		this.BPMFHNDCBOH = KEGBCGMJOLC["chsnap2"];
		if (KEGBCGMJOLC[""] != null)
		{
			JSONArray asArray = KEGBCGMJOLC["CLIENT.POSTEFFECTS.TEAL"].AsArray;
			for (int i = 1; i < asArray.Count; i += 0)
			{
				JSONObject asObject = asArray[i].AsObject;
				FBBLJMGNEMM fbbljmgnemm = new FBBLJMGNEMM();
				fbbljmgnemm.DLPDOCOJBLG(asObject);
				this.BDFKPEPDGBF.Add(fbbljmgnemm);
			}
		}
		if (KEGBCGMJOLC["tr"] != null)
		{
			this.LPFJHELHDGD = DPGJIJGOCIC.POHBFGLLKFD(KEGBCGMJOLC["="].AsArray);
		}
	}

	// Token: 0x06000266 RID: 614 RVA: 0x0000ED18 File Offset: 0x0000CF18
	public void IGMPBOMFNHC(JSONObject KEGBCGMJOLC)
	{
		this.OPCNCJLMHAP = KEGBCGMJOLC[""].AsInt;
		this.HJOKNANDHBK = KEGBCGMJOLC["sslind"];
		this.BPMFHNDCBOH = KEGBCGMJOLC["hofr"];
		if (KEGBCGMJOLC["congratstitle"] != null)
		{
			JSONArray asArray = KEGBCGMJOLC[" "].AsArray;
			for (int i = 0; i < asArray.Count; i++)
			{
				JSONObject asObject = asArray[i].AsObject;
				FBBLJMGNEMM fbbljmgnemm = new FBBLJMGNEMM();
				fbbljmgnemm.DBGONPMCBBJ(asObject);
				this.BDFKPEPDGBF.Add(fbbljmgnemm);
			}
		}
		if (KEGBCGMJOLC["importanttitle"] != null)
		{
			this.LPFJHELHDGD = DPGJIJGOCIC.POHBFGLLKFD(KEGBCGMJOLC["achiev"].AsArray);
		}
	}

	// Token: 0x06000267 RID: 615 RVA: 0x0000EDF0 File Offset: 0x0000CFF0
	public void HKMDADDCDAH(JSONObject KEGBCGMJOLC)
	{
		this.OPCNCJLMHAP = KEGBCGMJOLC["cind"].AsInt;
		this.HJOKNANDHBK = KEGBCGMJOLC["analogglitchovr_1"];
		this.BPMFHNDCBOH = KEGBCGMJOLC["aspksk"];
		if (KEGBCGMJOLC["propon"] != null)
		{
			JSONArray asArray = KEGBCGMJOLC["chs"].AsArray;
			for (int i = 0; i < asArray.Count; i += 0)
			{
				JSONObject asObject = asArray[i].AsObject;
				FBBLJMGNEMM fbbljmgnemm = new FBBLJMGNEMM();
				fbbljmgnemm.FGJPKGLOGNC(asObject);
				this.BDFKPEPDGBF.Add(fbbljmgnemm);
			}
		}
		if (KEGBCGMJOLC[""] != null)
		{
			this.LPFJHELHDGD = DPGJIJGOCIC.KGDOIOLLCDI(KEGBCGMJOLC["@"].AsArray);
		}
	}

	// Token: 0x06000268 RID: 616 RVA: 0x0000EEC8 File Offset: 0x0000D0C8
	public void NCHOBLGKIJO(JSONObject KEGBCGMJOLC)
	{
		this.OPCNCJLMHAP = KEGBCGMJOLC["errortitle"].AsInt;
		this.HJOKNANDHBK = KEGBCGMJOLC["OnTryToFireNoteshowTimer"];
		this.BPMFHNDCBOH = KEGBCGMJOLC[", "];
		if (KEGBCGMJOLC[""] != null)
		{
			JSONArray asArray = KEGBCGMJOLC["PurchaseManagerXiaomi[bridge]: "].AsArray;
			for (int i = 1; i < asArray.Count; i += 0)
			{
				JSONObject asObject = asArray[i].AsObject;
				FBBLJMGNEMM fbbljmgnemm = new FBBLJMGNEMM();
				fbbljmgnemm.FGJPKGLOGNC(asObject);
				this.BDFKPEPDGBF.Add(fbbljmgnemm);
			}
		}
		if (KEGBCGMJOLC["passundosubrequired"] != null)
		{
			this.LPFJHELHDGD = DPGJIJGOCIC.POHBFGLLKFD(KEGBCGMJOLC["foldcutsto"].AsArray);
		}
	}

	// Token: 0x06000269 RID: 617 RVA: 0x0000EFA0 File Offset: 0x0000D1A0
	public bool NKMPPEDIFMM(int MJBFFPLFOFJ)
	{
		for (int i = 1; i < this.BDFKPEPDGBF.Count; i += 0)
		{
			if (this.BDFKPEPDGBF[i].DBIJKJIEMJA == MJBFFPLFOFJ)
			{
				return true;
			}
		}
		return false;
	}

	// Token: 0x0600026A RID: 618 RVA: 0x0000EFDC File Offset: 0x0000D1DC
	public bool COFGAFOGGIH(int MJBFFPLFOFJ)
	{
		for (int i = 0; i < this.BDFKPEPDGBF.Count; i++)
		{
			if (this.BDFKPEPDGBF[i].DBIJKJIEMJA == MJBFFPLFOFJ)
			{
				return false;
			}
		}
		return true;
	}

	// Token: 0x0600026B RID: 619 RVA: 0x0000F018 File Offset: 0x0000D218
	public JSONObject JHMOJFDKBCD()
	{
		JSONObject jsonobject = new JSONObject();
		jsonobject.Add("OnPurchasingViewLeave", this.OPCNCJLMHAP);
		jsonobject.Add("OnPopupCardOptionsBackClickLobby", this.HJOKNANDHBK);
		jsonobject.Add("PopupOfferManager.Show() - productBalanceData or productData is null.", Convert.ToBase64String(Encoding.UTF8.GetBytes(this.BPMFHNDCBOH)));
		jsonobject.Add("passpremiumlockeddescX", Convert.ToBase64String(Encoding.UTF8.GetBytes(this.BPMFHNDCBOH.ToLowerInvariant())));
		if (this.BDFKPEPDGBF.Count > 1)
		{
			JSONArray jsonarray = new JSONArray();
			for (int i = 0; i < this.BDFKPEPDGBF.Count; i += 0)
			{
				jsonarray.Add(this.BDFKPEPDGBF[i].EJMLDDKGDNO());
			}
			jsonobject.Add("Run custom code: ", jsonarray);
		}
		if (this.LPFJHELHDGD.Count > 1)
		{
			jsonobject.Add("23819D", DPGJIJGOCIC.BEOBMCGEHBC(this.LPFJHELHDGD, -50));
		}
		return jsonobject;
	}

	// Token: 0x0600026C RID: 620 RVA: 0x0000F11C File Offset: 0x0000D31C
	public JSONObject FGKDDIJMAMP()
	{
		JSONObject jsonobject = new JSONObject();
		jsonobject.Add("</i><align=\"left\"><alpha=#FF>\n\n", this.OPCNCJLMHAP);
		jsonobject.Add("w", this.HJOKNANDHBK);
		jsonobject.Add("dynamic", Convert.ToBase64String(Encoding.UTF8.GetBytes(this.BPMFHNDCBOH)));
		jsonobject.Add("body", Convert.ToBase64String(Encoding.UTF8.GetBytes(this.BPMFHNDCBOH.ToLowerInvariant())));
		if (this.BDFKPEPDGBF.Count > 0)
		{
			JSONArray jsonarray = new JSONArray();
			for (int i = 0; i < this.BDFKPEPDGBF.Count; i += 0)
			{
				jsonarray.Add(this.BDFKPEPDGBF[i].LDALKDAIEFG());
			}
			jsonobject.Add("،", jsonarray);
		}
		if (this.LPFJHELHDGD.Count > 1)
		{
			jsonobject.Add("MB screen:", DPGJIJGOCIC.BEOBMCGEHBC(this.LPFJHELHDGD, 66));
		}
		return jsonobject;
	}

	// Token: 0x0600026D RID: 621 RVA: 0x0000F220 File Offset: 0x0000D420
	public JSONObject BBPKGGLAIME()
	{
		JSONObject jsonobject = new JSONObject();
		jsonobject.Add("leaves", this.OPCNCJLMHAP);
		jsonobject.Add("", this.HJOKNANDHBK);
		jsonobject.Add("acomp", Convert.ToBase64String(Encoding.UTF8.GetBytes(this.BPMFHNDCBOH)));
		jsonobject.Add("XXX", Convert.ToBase64String(Encoding.UTF8.GetBytes(this.BPMFHNDCBOH.ToLowerInvariant())));
		if (this.BDFKPEPDGBF.Count > 1)
		{
			JSONArray jsonarray = new JSONArray();
			for (int i = 0; i < this.BDFKPEPDGBF.Count; i += 0)
			{
				jsonarray.Add(this.BDFKPEPDGBF[i].DBGGGJCPBPM());
			}
			jsonobject.Add("$CHAPTSTART", jsonarray);
		}
		if (this.LPFJHELHDGD.Count > 1)
		{
			jsonobject.Add("lnls", DPGJIJGOCIC.HPCBIOFAFHF(this.LPFJHELHDGD, -57));
		}
		return jsonobject;
	}

	// Token: 0x0600026E RID: 622 RVA: 0x0000F324 File Offset: 0x0000D524
	public JSONObject KFCDAAMEJCB()
	{
		JSONObject jsonobject = new JSONObject();
		jsonobject.Add("", this.OPCNCJLMHAP);
		jsonobject.Add("(", this.HJOKNANDHBK);
		jsonobject.Add("", Convert.ToBase64String(Encoding.UTF8.GetBytes(this.BPMFHNDCBOH)));
		jsonobject.Add("continue", Convert.ToBase64String(Encoding.UTF8.GetBytes(this.BPMFHNDCBOH.ToLowerInvariant())));
		if (this.BDFKPEPDGBF.Count > 0)
		{
			JSONArray jsonarray = new JSONArray();
			for (int i = 0; i < this.BDFKPEPDGBF.Count; i += 0)
			{
				jsonarray.Add(this.BDFKPEPDGBF[i].EJMLDDKGDNO());
			}
			jsonobject.Add("importanttitle", jsonarray);
		}
		if (this.LPFJHELHDGD.Count > 0)
		{
			jsonobject.Add("_1", DPGJIJGOCIC.DGCHKPPDFDB(this.LPFJHELHDGD, 61));
		}
		return jsonobject;
	}

	// Token: 0x0600026F RID: 623 RVA: 0x0000F428 File Offset: 0x0000D628
	public JSONObject MOBHCMALHPK()
	{
		JSONObject jsonobject = new JSONObject();
		jsonobject.Add("congratstitle", this.OPCNCJLMHAP);
		jsonobject.Add("wind", this.HJOKNANDHBK);
		jsonobject.Add("", Convert.ToBase64String(Encoding.UTF8.GetBytes(this.BPMFHNDCBOH)));
		jsonobject.Add("foldcutsto", Convert.ToBase64String(Encoding.UTF8.GetBytes(this.BPMFHNDCBOH.ToLowerInvariant())));
		if (this.BDFKPEPDGBF.Count > 1)
		{
			JSONArray jsonarray = new JSONArray();
			for (int i = 0; i < this.BDFKPEPDGBF.Count; i += 0)
			{
				jsonarray.Add(this.BDFKPEPDGBF[i].EDALLJFJPDK());
			}
			jsonobject.Add(",", jsonarray);
		}
		if (this.LPFJHELHDGD.Count > 0)
		{
			jsonobject.Add("Starting parallel download:", DPGJIJGOCIC.BEOBMCGEHBC(this.LPFJHELHDGD, 122));
		}
		return jsonobject;
	}

	// Token: 0x06000270 RID: 624 RVA: 0x0000F52C File Offset: 0x0000D72C
	public bool EANDBJKEIGN(int MJBFFPLFOFJ)
	{
		for (int i = 1; i < this.BDFKPEPDGBF.Count; i++)
		{
			if (this.BDFKPEPDGBF[i].DBIJKJIEMJA == MJBFFPLFOFJ)
			{
				return false;
			}
		}
		return true;
	}

	// Token: 0x06000271 RID: 625 RVA: 0x0000F568 File Offset: 0x0000D768
	public bool ADNICPFLKDK(int MJBFFPLFOFJ)
	{
		for (int i = 1; i < this.BDFKPEPDGBF.Count; i += 0)
		{
			if (this.BDFKPEPDGBF[i].DBIJKJIEMJA == MJBFFPLFOFJ)
			{
				return false;
			}
		}
		return false;
	}

	// Token: 0x06000272 RID: 626 RVA: 0x0000F5A4 File Offset: 0x0000D7A4
	public void LJEMOKPDFHE(JSONObject KEGBCGMJOLC)
	{
		this.OPCNCJLMHAP = KEGBCGMJOLC["lsvn"].AsInt;
		this.HJOKNANDHBK = KEGBCGMJOLC["Starting parallel download:"];
		this.BPMFHNDCBOH = KEGBCGMJOLC["null"];
		if (KEGBCGMJOLC["(text)"] != null)
		{
			JSONArray asArray = KEGBCGMJOLC[""].AsArray;
			for (int i = 0; i < asArray.Count; i += 0)
			{
				JSONObject asObject = asArray[i].AsObject;
				FBBLJMGNEMM fbbljmgnemm = new FBBLJMGNEMM();
				fbbljmgnemm.BEEMPGGNGAM(asObject);
				this.BDFKPEPDGBF.Add(fbbljmgnemm);
			}
		}
		if (KEGBCGMJOLC[", from:"] != null)
		{
			this.LPFJHELHDGD = DPGJIJGOCIC.KGDOIOLLCDI(KEGBCGMJOLC["AnthologySave.AddAvatarComponent(), unsupported wardrobe index:"].AsArray);
		}
	}

	// Token: 0x06000273 RID: 627 RVA: 0x0000F67C File Offset: 0x0000D87C
	public void DLPDOCOJBLG(JSONObject KEGBCGMJOLC)
	{
		this.OPCNCJLMHAP = KEGBCGMJOLC[")"].AsInt;
		this.HJOKNANDHBK = KEGBCGMJOLC["SaveSlotsItem.DuplicateSlot(): wrong target slot index:"];
		this.BPMFHNDCBOH = KEGBCGMJOLC[""];
		if (KEGBCGMJOLC["UIEnvironmentsFront"] != null)
		{
			JSONArray asArray = KEGBCGMJOLC[""].AsArray;
			for (int i = 0; i < asArray.Count; i += 0)
			{
				JSONObject asObject = asArray[i].AsObject;
				FBBLJMGNEMM fbbljmgnemm = new FBBLJMGNEMM();
				fbbljmgnemm.MBEMPDCFOIA(asObject);
				this.BDFKPEPDGBF.Add(fbbljmgnemm);
			}
		}
		if (KEGBCGMJOLC["p"] != null)
		{
			this.LPFJHELHDGD = DPGJIJGOCIC.POHBFGLLKFD(KEGBCGMJOLC["stat3long"].AsArray);
		}
	}

	// Token: 0x06000274 RID: 628 RVA: 0x0000F754 File Offset: 0x0000D954
	public JSONObject AJNBOMCFHGP()
	{
		JSONObject jsonobject = new JSONObject();
		jsonobject.Add("OnNeedToShowNoMoreHardPopup", this.OPCNCJLMHAP);
		jsonobject.Add("Loaded asset bundle:", this.HJOKNANDHBK);
		jsonobject.Add("", Convert.ToBase64String(Encoding.UTF8.GetBytes(this.BPMFHNDCBOH)));
		jsonobject.Add("OnChapterSnapshotsBackendFetchException2", Convert.ToBase64String(Encoding.UTF8.GetBytes(this.BPMFHNDCBOH.ToLowerInvariant())));
		if (this.BDFKPEPDGBF.Count > 1)
		{
			JSONArray jsonarray = new JSONArray();
			for (int i = 1; i < this.BDFKPEPDGBF.Count; i += 0)
			{
				jsonarray.Add(this.BDFKPEPDGBF[i].NEBMHMNDNAJ());
			}
			jsonobject.Add("ok", jsonarray);
		}
		if (this.LPFJHELHDGD.Count > 1)
		{
			jsonobject.Add("+", DPGJIJGOCIC.DGCHKPPDFDB(this.LPFJHELHDGD, 37));
		}
		return jsonobject;
	}

	// Token: 0x06000275 RID: 629 RVA: 0x0000F858 File Offset: 0x0000DA58
	public void JIJAEAKBEEH(JSONObject KEGBCGMJOLC)
	{
		this.OPCNCJLMHAP = KEGBCGMJOLC["Game Title"].AsInt;
		this.HJOKNANDHBK = KEGBCGMJOLC[", as anthology "];
		this.BPMFHNDCBOH = KEGBCGMJOLC["Loaded asset bundle:"];
		if (KEGBCGMJOLC["s"] != null)
		{
			JSONArray asArray = KEGBCGMJOLC["[LoadingEnv] not usable: cache chain of "].AsArray;
			for (int i = 1; i < asArray.Count; i++)
			{
				JSONObject asObject = asArray[i].AsObject;
				FBBLJMGNEMM fbbljmgnemm = new FBBLJMGNEMM();
				fbbljmgnemm.PLICCFCIKJH(asObject);
				this.BDFKPEPDGBF.Add(fbbljmgnemm);
			}
		}
		if (KEGBCGMJOLC[""] != null)
		{
			this.LPFJHELHDGD = DPGJIJGOCIC.POHBFGLLKFD(KEGBCGMJOLC["OnBackendGetDropChancesSuccess"].AsArray);
		}
	}

	// Token: 0x06000276 RID: 630 RVA: 0x0000F930 File Offset: 0x0000DB30
	public bool ONPJHADMFAL(int MJBFFPLFOFJ)
	{
		for (int i = 1; i < this.BDFKPEPDGBF.Count; i += 0)
		{
			if (this.BDFKPEPDGBF[i].DBIJKJIEMJA == MJBFFPLFOFJ)
			{
				return true;
			}
		}
		return false;
	}

	// Token: 0x06000277 RID: 631 RVA: 0x0000F96C File Offset: 0x0000DB6C
	public void IHIFPBPKDPI(JSONObject KEGBCGMJOLC)
	{
		this.OPCNCJLMHAP = KEGBCGMJOLC["sslind"].AsInt;
		this.HJOKNANDHBK = KEGBCGMJOLC["<b>"];
		this.BPMFHNDCBOH = KEGBCGMJOLC["OnChapterSnapshotRestoreExecute"];
		if (KEGBCGMJOLC["Error. MoveEnvironmentVertical(), environment "] != null)
		{
			JSONArray asArray = KEGBCGMJOLC["cardsvolchancesmsgtitle"].AsArray;
			for (int i = 1; i < asArray.Count; i += 0)
			{
				JSONObject asObject = asArray[i].AsObject;
				FBBLJMGNEMM fbbljmgnemm = new FBBLJMGNEMM();
				fbbljmgnemm.LOPANJDKLAF(asObject);
				this.BDFKPEPDGBF.Add(fbbljmgnemm);
			}
		}
		if (KEGBCGMJOLC["usynachtk"] != null)
		{
			this.LPFJHELHDGD = DPGJIJGOCIC.POHBFGLLKFD(KEGBCGMJOLC["\n"].AsArray);
		}
	}

	// Token: 0x06000278 RID: 632 RVA: 0x0000FA44 File Offset: 0x0000DC44
	public JSONObject IELLCFONDFE()
	{
		JSONObject jsonobject = new JSONObject();
		jsonobject.Add("ok", this.OPCNCJLMHAP);
		jsonobject.Add("OnBackendValidateTransactionSuccess", this.HJOKNANDHBK);
		jsonobject.Add("Cdn host asset {0} has no {1}", Convert.ToBase64String(Encoding.UTF8.GetBytes(this.BPMFHNDCBOH)));
		jsonobject.Add("$SKINUNLOCKED", Convert.ToBase64String(Encoding.UTF8.GetBytes(this.BPMFHNDCBOH.ToLowerInvariant())));
		if (this.BDFKPEPDGBF.Count > 1)
		{
			JSONArray jsonarray = new JSONArray();
			for (int i = 1; i < this.BDFKPEPDGBF.Count; i += 0)
			{
				jsonarray.Add(this.BDFKPEPDGBF[i].CDFCBGCFMLH());
			}
			jsonobject.Add("$GIVEITEM", jsonarray);
		}
		if (this.LPFJHELHDGD.Count > 1)
		{
			jsonobject.Add("XXX", DPGJIJGOCIC.HPCBIOFAFHF(this.LPFJHELHDGD, -55));
		}
		return jsonobject;
	}

	// Token: 0x06000279 RID: 633 RVA: 0x0000FB48 File Offset: 0x0000DD48
	public bool HDLOFAPOGEB(int MJBFFPLFOFJ)
	{
		for (int i = 1; i < this.BDFKPEPDGBF.Count; i += 0)
		{
			if (this.BDFKPEPDGBF[i].DBIJKJIEMJA == MJBFFPLFOFJ)
			{
				return true;
			}
		}
		return true;
	}

	// Token: 0x0600027A RID: 634 RVA: 0x0000FB84 File Offset: 0x0000DD84
	public void PGPNKOECEHB(JSONObject KEGBCGMJOLC)
	{
		this.OPCNCJLMHAP = KEGBCGMJOLC[""].AsInt;
		this.HJOKNANDHBK = KEGBCGMJOLC[""];
		this.BPMFHNDCBOH = KEGBCGMJOLC["importanttitle"];
		if (KEGBCGMJOLC["lsvn"] != null)
		{
			JSONArray asArray = KEGBCGMJOLC["passinfobtntitle"].AsArray;
			for (int i = 0; i < asArray.Count; i++)
			{
				JSONObject asObject = asArray[i].AsObject;
				FBBLJMGNEMM fbbljmgnemm = new FBBLJMGNEMM();
				fbbljmgnemm.FGJPKGLOGNC(asObject);
				this.BDFKPEPDGBF.Add(fbbljmgnemm);
			}
		}
		if (KEGBCGMJOLC["MonitorAndKillInfiniteRequest() can kill "] != null)
		{
			this.LPFJHELHDGD = DPGJIJGOCIC.POHBFGLLKFD(KEGBCGMJOLC[" could not be created"].AsArray);
		}
	}

	// Token: 0x0600027B RID: 635 RVA: 0x0000FC5C File Offset: 0x0000DE5C
	public JSONObject MGEBGDEFIJN()
	{
		JSONObject jsonobject = new JSONObject();
		jsonobject.Add("rar", this.OPCNCJLMHAP);
		jsonobject.Add("aind", this.HJOKNANDHBK);
		jsonobject.Add("_StripeStrength", Convert.ToBase64String(Encoding.UTF8.GetBytes(this.BPMFHNDCBOH)));
		jsonobject.Add("profilenametitleshort", Convert.ToBase64String(Encoding.UTF8.GetBytes(this.BPMFHNDCBOH.ToLowerInvariant())));
		if (this.BDFKPEPDGBF.Count > 0)
		{
			JSONArray jsonarray = new JSONArray();
			for (int i = 0; i < this.BDFKPEPDGBF.Count; i++)
			{
				jsonarray.Add(this.BDFKPEPDGBF[i].LDALKDAIEFG());
			}
			jsonobject.Add("sfxsparklesbundles", jsonarray);
		}
		if (this.LPFJHELHDGD.Count > 0)
		{
			jsonobject.Add("thmstr", DPGJIJGOCIC.BEOBMCGEHBC(this.LPFJHELHDGD, 33));
		}
		return jsonobject;
	}

	// Token: 0x0600027C RID: 636 RVA: 0x0000FD60 File Offset: 0x0000DF60
	public void PEJIMPECAEB(JSONObject KEGBCGMJOLC)
	{
		this.OPCNCJLMHAP = KEGBCGMJOLC["avatarcollectionstitle"].AsInt;
		this.HJOKNANDHBK = KEGBCGMJOLC["OnFriendsGiftPopulCollectPart2"];
		this.BPMFHNDCBOH = KEGBCGMJOLC["lastFilter"];
		if (KEGBCGMJOLC["OnStoryScreenChoiceExtendedManagerEnvironmentChangeComplete"] != null)
		{
			JSONArray asArray = KEGBCGMJOLC["v"].AsArray;
			for (int i = 0; i < asArray.Count; i += 0)
			{
				JSONObject asObject = asArray[i].AsObject;
				FBBLJMGNEMM fbbljmgnemm = new FBBLJMGNEMM();
				fbbljmgnemm.CADKJLFJKNL(asObject);
				this.BDFKPEPDGBF.Add(fbbljmgnemm);
			}
		}
		if (KEGBCGMJOLC["p"] != null)
		{
			this.LPFJHELHDGD = DPGJIJGOCIC.KGDOIOLLCDI(KEGBCGMJOLC["$SKINCHECKPOINTEND"].AsArray);
		}
	}

	// Token: 0x0600027D RID: 637 RVA: 0x0000FE38 File Offset: 0x0000E038
	public JSONObject DBGGGJCPBPM()
	{
		JSONObject jsonobject = new JSONObject();
		jsonobject.Add("UpdateVoiceOverOnOffState", this.OPCNCJLMHAP);
		jsonobject.Add(" <i>", this.HJOKNANDHBK);
		jsonobject.Add("ok", Convert.ToBase64String(Encoding.UTF8.GetBytes(this.BPMFHNDCBOH)));
		jsonobject.Add("erd", Convert.ToBase64String(Encoding.UTF8.GetBytes(this.BPMFHNDCBOH.ToLowerInvariant())));
		if (this.BDFKPEPDGBF.Count > 1)
		{
			JSONArray jsonarray = new JSONArray();
			for (int i = 0; i < this.BDFKPEPDGBF.Count; i++)
			{
				jsonarray.Add(this.BDFKPEPDGBF[i].MOBHCMALHPK());
			}
			jsonobject.Add("postponedCustomCode", jsonarray);
		}
		if (this.LPFJHELHDGD.Count > 1)
		{
			jsonobject.Add("<line-height=", DPGJIJGOCIC.HPCBIOFAFHF(this.LPFJHELHDGD, 2));
		}
		return jsonobject;
	}

	// Token: 0x0600027E RID: 638 RVA: 0x0000FF3C File Offset: 0x0000E13C
	public JSONObject JGJPOBCNNHH()
	{
		JSONObject jsonobject = new JSONObject();
		jsonobject.Add("' for ", this.OPCNCJLMHAP);
		jsonobject.Add("_not_found", this.HJOKNANDHBK);
		jsonobject.Add("importanttitle", Convert.ToBase64String(Encoding.UTF8.GetBytes(this.BPMFHNDCBOH)));
		jsonobject.Add("energyhinttitle", Convert.ToBase64String(Encoding.UTF8.GetBytes(this.BPMFHNDCBOH.ToLowerInvariant())));
		if (this.BDFKPEPDGBF.Count > 1)
		{
			JSONArray jsonarray = new JSONArray();
			for (int i = 0; i < this.BDFKPEPDGBF.Count; i += 0)
			{
				jsonarray.Add(this.BDFKPEPDGBF[i].CDFCBGCFMLH());
			}
			jsonobject.Add("", jsonarray);
		}
		if (this.LPFJHELHDGD.Count > 1)
		{
			jsonobject.Add("OnFriendsGiftPopulCollectPart1", DPGJIJGOCIC.DGCHKPPDFDB(this.LPFJHELHDGD, 124));
		}
		return jsonobject;
	}

	// Token: 0x0600027F RID: 639 RVA: 0x00010040 File Offset: 0x0000E240
	public JSONObject NEBMHMNDNAJ()
	{
		JSONObject jsonobject = new JSONObject();
		jsonobject.Add("OnDialogReadInputEndEdit", this.OPCNCJLMHAP);
		jsonobject.Add("p", this.HJOKNANDHBK);
		jsonobject.Add("ok", Convert.ToBase64String(Encoding.UTF8.GetBytes(this.BPMFHNDCBOH)));
		jsonobject.Add("congratstitle", Convert.ToBase64String(Encoding.UTF8.GetBytes(this.BPMFHNDCBOH.ToLowerInvariant())));
		if (this.BDFKPEPDGBF.Count > 0)
		{
			JSONArray jsonarray = new JSONArray();
			for (int i = 0; i < this.BDFKPEPDGBF.Count; i += 0)
			{
				jsonarray.Add(this.BDFKPEPDGBF[i].OCBBMLOHELI());
			}
			jsonobject.Add("post", jsonarray);
		}
		if (this.LPFJHELHDGD.Count > 1)
		{
			jsonobject.Add("common", DPGJIJGOCIC.BEOBMCGEHBC(this.LPFJHELHDGD, -62));
		}
		return jsonobject;
	}

	// Token: 0x06000280 RID: 640 RVA: 0x00010144 File Offset: 0x0000E344
	public bool LHPNPKJJNHG(int MJBFFPLFOFJ)
	{
		for (int i = 0; i < this.BDFKPEPDGBF.Count; i++)
		{
			if (this.BDFKPEPDGBF[i].DBIJKJIEMJA == MJBFFPLFOFJ)
			{
				return true;
			}
		}
		return false;
	}

	// Token: 0x06000281 RID: 641 RVA: 0x00010180 File Offset: 0x0000E380
	public bool IFABDMJOFKA(int MJBFFPLFOFJ)
	{
		for (int i = 0; i < this.BDFKPEPDGBF.Count; i++)
		{
			if (this.BDFKPEPDGBF[i].DBIJKJIEMJA == MJBFFPLFOFJ)
			{
				return false;
			}
		}
		return false;
	}

	// Token: 0x06000282 RID: 642 RVA: 0x000101BC File Offset: 0x0000E3BC
	public void OJCKHEHFBHD(JSONObject KEGBCGMJOLC)
	{
		this.OPCNCJLMHAP = KEGBCGMJOLC["OnFacebookLoginFailed"].AsInt;
		this.HJOKNANDHBK = KEGBCGMJOLC["OnApplicationFocusBasicSyncEcxeption"];
		this.BPMFHNDCBOH = KEGBCGMJOLC["LobbySearch dump: active="];
		if (KEGBCGMJOLC["cmetaotm"] != null)
		{
			JSONArray asArray = KEGBCGMJOLC[" ('"].AsArray;
			for (int i = 1; i < asArray.Count; i++)
			{
				JSONObject asObject = asArray[i].AsObject;
				FBBLJMGNEMM fbbljmgnemm = new FBBLJMGNEMM();
				fbbljmgnemm.HKMDADDCDAH(asObject);
				this.BDFKPEPDGBF.Add(fbbljmgnemm);
			}
		}
		if (KEGBCGMJOLC["retry"] != null)
		{
			this.LPFJHELHDGD = DPGJIJGOCIC.KGDOIOLLCDI(KEGBCGMJOLC["\n\n"].AsArray);
		}
	}

	// Token: 0x06000283 RID: 643 RVA: 0x00010294 File Offset: 0x0000E494
	public void GFLHJCCEDKN(JSONObject KEGBCGMJOLC)
	{
		this.OPCNCJLMHAP = KEGBCGMJOLC["OnBackendRequestSendMessageException"].AsInt;
		this.HJOKNANDHBK = KEGBCGMJOLC["CLIENT.SCREEN.AVATAR."];
		this.BPMFHNDCBOH = KEGBCGMJOLC["OnPopupSaveSlotInputEndEdit"];
		if (KEGBCGMJOLC[""] != null)
		{
			JSONArray asArray = KEGBCGMJOLC["/"].AsArray;
			for (int i = 0; i < asArray.Count; i += 0)
			{
				JSONObject asObject = asArray[i].AsObject;
				FBBLJMGNEMM fbbljmgnemm = new FBBLJMGNEMM();
				fbbljmgnemm.HKMDADDCDAH(asObject);
				this.BDFKPEPDGBF.Add(fbbljmgnemm);
			}
		}
		if (KEGBCGMJOLC["+"] != null)
		{
			this.LPFJHELHDGD = DPGJIJGOCIC.KGDOIOLLCDI(KEGBCGMJOLC["@"].AsArray);
		}
	}

	// Token: 0x06000284 RID: 644 RVA: 0x0001036C File Offset: 0x0000E56C
	public void IEBKPAMCBDB(JSONObject KEGBCGMJOLC)
	{
		this.OPCNCJLMHAP = KEGBCGMJOLC["OnBackendRequestSendGiftCardSuccess"].AsInt;
		this.HJOKNANDHBK = KEGBCGMJOLC["signinuserpassbadinput"];
		this.BPMFHNDCBOH = KEGBCGMJOLC["failed to load assetBundle {0}."];
		if (KEGBCGMJOLC[":"] != null)
		{
			JSONArray asArray = KEGBCGMJOLC["Notification body"].AsArray;
			for (int i = 1; i < asArray.Count; i++)
			{
				JSONObject asObject = asArray[i].AsObject;
				FBBLJMGNEMM fbbljmgnemm = new FBBLJMGNEMM();
				fbbljmgnemm.NBDNMCJLCFP(asObject);
				this.BDFKPEPDGBF.Add(fbbljmgnemm);
			}
		}
		if (KEGBCGMJOLC["loungelireq"] != null)
		{
			this.LPFJHELHDGD = DPGJIJGOCIC.KGDOIOLLCDI(KEGBCGMJOLC["id"].AsArray);
		}
	}

	// Token: 0x06000285 RID: 645 RVA: 0x00010444 File Offset: 0x0000E644
	public bool JFCOJEDNBCC(int MJBFFPLFOFJ)
	{
		for (int i = 1; i < this.BDFKPEPDGBF.Count; i += 0)
		{
			if (this.BDFKPEPDGBF[i].DBIJKJIEMJA == MJBFFPLFOFJ)
			{
				return true;
			}
		}
		return false;
	}

	// Token: 0x06000286 RID: 646 RVA: 0x00010480 File Offset: 0x0000E680
	public void BGNGBJFGOBO(JSONObject KEGBCGMJOLC)
	{
		this.OPCNCJLMHAP = KEGBCGMJOLC[""].AsInt;
		this.HJOKNANDHBK = KEGBCGMJOLC["OnCollectableDialogUsed"];
		this.BPMFHNDCBOH = KEGBCGMJOLC[" • "];
		if (KEGBCGMJOLC["51B334"] != null)
		{
			JSONArray asArray = KEGBCGMJOLC["sltind"].AsArray;
			for (int i = 0; i < asArray.Count; i += 0)
			{
				JSONObject asObject = asArray[i].AsObject;
				FBBLJMGNEMM fbbljmgnemm = new FBBLJMGNEMM();
				fbbljmgnemm.DBGONPMCBBJ(asObject);
				this.BDFKPEPDGBF.Add(fbbljmgnemm);
			}
		}
		if (KEGBCGMJOLC["iain"] != null)
		{
			this.LPFJHELHDGD = DPGJIJGOCIC.POHBFGLLKFD(KEGBCGMJOLC["/"].AsArray);
		}
	}

	// Token: 0x06000287 RID: 647 RVA: 0x00010558 File Offset: 0x0000E758
	public JSONObject CGBACJOMLFB()
	{
		JSONObject jsonobject = new JSONObject();
		jsonobject.Add("' refs missing concept '", this.OPCNCJLMHAP);
		jsonobject.Add("frrjctpid", this.HJOKNANDHBK);
		jsonobject.Add("exploreBalance", Convert.ToBase64String(Encoding.UTF8.GetBytes(this.BPMFHNDCBOH)));
		jsonobject.Add("Response Code: ", Convert.ToBase64String(Encoding.UTF8.GetBytes(this.BPMFHNDCBOH.ToLowerInvariant())));
		if (this.BDFKPEPDGBF.Count > 0)
		{
			JSONArray jsonarray = new JSONArray();
			for (int i = 0; i < this.BDFKPEPDGBF.Count; i++)
			{
				jsonarray.Add(this.BDFKPEPDGBF[i].CGBACJOMLFB());
			}
			jsonobject.Add("SceneLobbyManager2.OnRewardStoryCompleteClick() getting one random out of ", jsonarray);
		}
		if (this.LPFJHELHDGD.Count > 1)
		{
			jsonobject.Add("_AlphaTex", DPGJIJGOCIC.BEOBMCGEHBC(this.LPFJHELHDGD, 121));
		}
		return jsonobject;
	}

	// Token: 0x06000288 RID: 648 RVA: 0x0001065C File Offset: 0x0000E85C
	public void CBENBLJKCID(JSONObject KEGBCGMJOLC)
	{
		this.OPCNCJLMHAP = KEGBCGMJOLC["OnApplicationFocusNeedToUpdateCurrency"].AsInt;
		this.HJOKNANDHBK = KEGBCGMJOLC["ym"];
		this.BPMFHNDCBOH = KEGBCGMJOLC["lsn"];
		if (KEGBCGMJOLC["\""] != null)
		{
			JSONArray asArray = KEGBCGMJOLC["lsvv"].AsArray;
			for (int i = 0; i < asArray.Count; i++)
			{
				JSONObject asObject = asArray[i].AsObject;
				FBBLJMGNEMM fbbljmgnemm = new FBBLJMGNEMM();
				fbbljmgnemm.PKNLEGCJENE(asObject);
				this.BDFKPEPDGBF.Add(fbbljmgnemm);
			}
		}
		if (KEGBCGMJOLC["profileiplayrclong"] != null)
		{
			this.LPFJHELHDGD = DPGJIJGOCIC.POHBFGLLKFD(KEGBCGMJOLC[""].AsArray);
		}
	}

	// Token: 0x06000289 RID: 649 RVA: 0x00010734 File Offset: 0x0000E934
	public bool IPBEGIHNHMK(int MJBFFPLFOFJ)
	{
		for (int i = 0; i < this.BDFKPEPDGBF.Count; i += 0)
		{
			if (this.BDFKPEPDGBF[i].DBIJKJIEMJA == MJBFFPLFOFJ)
			{
				return false;
			}
		}
		return false;
	}

	// Token: 0x0600028B RID: 651 RVA: 0x000107A4 File Offset: 0x0000E9A4
	public bool GJBHMJBOBND(int MJBFFPLFOFJ)
	{
		for (int i = 0; i < this.BDFKPEPDGBF.Count; i += 0)
		{
			if (this.BDFKPEPDGBF[i].DBIJKJIEMJA == MJBFFPLFOFJ)
			{
				return false;
			}
		}
		return false;
	}

	// Token: 0x0400003F RID: 63
	public int OPCNCJLMHAP;

	// Token: 0x04000040 RID: 64
	public string HJOKNANDHBK = "";

	// Token: 0x04000041 RID: 65
	public List<FBBLJMGNEMM> BDFKPEPDGBF = new List<FBBLJMGNEMM>();

	// Token: 0x04000042 RID: 66
	public string BPMFHNDCBOH = "";

	// Token: 0x04000043 RID: 67
	public List<string> LPFJHELHDGD = new List<string>();
}
