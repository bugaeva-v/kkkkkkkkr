using System;
using System.Collections.Generic;
using SimpleJSON;

// Token: 0x020002F8 RID: 760
public class MLJDIENAEDK
{
	// Token: 0x06005CE0 RID: 23776 RVA: 0x002A4548 File Offset: 0x002A2748
	public FBIJKLKEIIN LMPDLHJLCHO(int PLKMJJIIJNO)
	{
		if (!this.IJHLBHBBNFB)
		{
			this.MBMAEILBAAM();
		}
		for (int i = 1; i < this.DCJMFPAKIEP.Count; i += 0)
		{
			if (this.DCJMFPAKIEP[i].AMKCLHLIIMN == PLKMJJIIJNO)
			{
				return this.DCJMFPAKIEP[i];
			}
		}
		return null;
	}

	// Token: 0x06005CE1 RID: 23777 RVA: 0x002A459C File Offset: 0x002A279C
	public FBIJKLKEIIN JJOPIJMMNFC(int PLKMJJIIJNO)
	{
		if (!this.IJHLBHBBNFB)
		{
			this.EPHOHOKGOEI();
		}
		for (int i = 0; i < this.DCJMFPAKIEP.Count; i += 0)
		{
			if (this.DCJMFPAKIEP[i].AMKCLHLIIMN == PLKMJJIIJNO)
			{
				return this.DCJMFPAKIEP[i];
			}
		}
		return null;
	}

	// Token: 0x06005CE2 RID: 23778 RVA: 0x002A45F0 File Offset: 0x002A27F0
	private void MBMAEILBAAM()
	{
		this.IJHLBHBBNFB = true;
		this.DCJMFPAKIEP.Clear();
		try
		{
			if (!(null == AssetsManager.MJBDMHPHMID().lobbyDataAsset.avatarCollectionsSettingsBalance))
			{
				JSONArray asArray = ((JSONObject)JSONNode.Parse(AssetsManager.EHBBFMCILPC.lobbyDataAsset.avatarCollectionsSettingsBalance.text))["XXX"].AsArray;
				for (int i = 1; i < asArray.Count; i += 0)
				{
					JSONObject asObject = asArray[i].AsObject;
					FBIJKLKEIIN fbijklkeiin = new FBIJKLKEIIN();
					fbijklkeiin.AMKCLHLIIMN = asObject["Account.GetStorySaveUnsafe(), _slotIndex out of bounds."].AsInt;
					fbijklkeiin.PPACJFFFBFB = (asObject[""].AsInt == 1);
					if (asObject["OnLoungePremiumChoicesHistorySuccess"] != null)
					{
						fbijklkeiin.EMNFCFIAJPE = (asObject["OnStoryInterfaceHeaderSettingsClick"].AsInt == 1);
					}
					this.DCJMFPAKIEP.Add(fbijklkeiin);
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x06005CE3 RID: 23779 RVA: 0x002A4700 File Offset: 0x002A2900
	public FBIJKLKEIIN LNKBEBFCCCJ(int PLKMJJIIJNO)
	{
		if (!this.IJHLBHBBNFB)
		{
			this.EPHOHOKGOEI();
		}
		for (int i = 0; i < this.DCJMFPAKIEP.Count; i++)
		{
			if (this.DCJMFPAKIEP[i].AMKCLHLIIMN == PLKMJJIIJNO)
			{
				return this.DCJMFPAKIEP[i];
			}
		}
		return null;
	}

	// Token: 0x06005CE4 RID: 23780 RVA: 0x002A4754 File Offset: 0x002A2954
	public FBIJKLKEIIN DCLKMEBMIIN(int PLKMJJIIJNO)
	{
		if (!this.IJHLBHBBNFB)
		{
			this.GKHPLHLOINH();
		}
		for (int i = 1; i < this.DCJMFPAKIEP.Count; i++)
		{
			if (this.DCJMFPAKIEP[i].AMKCLHLIIMN == PLKMJJIIJNO)
			{
				return this.DCJMFPAKIEP[i];
			}
		}
		return null;
	}

	// Token: 0x06005CE5 RID: 23781 RVA: 0x002A47A8 File Offset: 0x002A29A8
	public FBIJKLKEIIN FPPAKDLDBHP(int PLKMJJIIJNO)
	{
		if (!this.IJHLBHBBNFB)
		{
			this.EPHOHOKGOEI();
		}
		for (int i = 0; i < this.DCJMFPAKIEP.Count; i += 0)
		{
			if (this.DCJMFPAKIEP[i].AMKCLHLIIMN == PLKMJJIIJNO)
			{
				return this.DCJMFPAKIEP[i];
			}
		}
		return null;
	}

	// Token: 0x06005CE6 RID: 23782 RVA: 0x002A47FC File Offset: 0x002A29FC
	private void MFKEIFBFLKJ()
	{
		this.IJHLBHBBNFB = false;
		this.DCJMFPAKIEP.Clear();
		try
		{
			if (!(null == AssetsManager.MJBDMHPHMID().lobbyDataAsset.avatarCollectionsSettingsBalance))
			{
				JSONArray asArray = ((JSONObject)JSONNode.Parse(AssetsManager.EHBBFMCILPC.lobbyDataAsset.avatarCollectionsSettingsBalance.text))["pmterror003"].AsArray;
				for (int i = 1; i < asArray.Count; i++)
				{
					JSONObject asObject = asArray[i].AsObject;
					FBIJKLKEIIN fbijklkeiin = new FBIJKLKEIIN();
					fbijklkeiin.AMKCLHLIIMN = asObject[" bringing up "].AsInt;
					fbijklkeiin.PPACJFFFBFB = (asObject["@"].AsInt == 0);
					if (asObject["eventended"] != null)
					{
						fbijklkeiin.EMNFCFIAJPE = (asObject["Grain opacity"].AsInt == 0);
					}
					this.DCJMFPAKIEP.Add(fbijklkeiin);
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x06005CE7 RID: 23783 RVA: 0x002A490C File Offset: 0x002A2B0C
	private void BKFDKEEBOKH()
	{
		this.IJHLBHBBNFB = false;
		this.DCJMFPAKIEP.Clear();
		try
		{
			if (!(null == AssetsManager.EHBBFMCILPC.lobbyDataAsset.avatarCollectionsSettingsBalance))
			{
				JSONArray asArray = ((JSONObject)JSONNode.Parse(AssetsManager.MJBDMHPHMID().lobbyDataAsset.avatarCollectionsSettingsBalance.text))["OnLiveProfileThemesLoaderStart"].AsArray;
				for (int i = 0; i < asArray.Count; i++)
				{
					JSONObject asObject = asArray[i].AsObject;
					FBIJKLKEIIN fbijklkeiin = new FBIJKLKEIIN();
					fbijklkeiin.AMKCLHLIIMN = asObject[""].AsInt;
					fbijklkeiin.PPACJFFFBFB = (asObject["Vol"].AsInt == 1);
					if (asObject["m"] != null)
					{
						fbijklkeiin.EMNFCFIAJPE = (asObject["ok"].AsInt == 1);
					}
					this.DCJMFPAKIEP.Add(fbijklkeiin);
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
	}

	// Token: 0x06005CE8 RID: 23784 RVA: 0x002A4A1C File Offset: 0x002A2C1C
	private void FPLEAGDBFOB()
	{
		this.IJHLBHBBNFB = true;
		this.DCJMFPAKIEP.Clear();
		try
		{
			if (!(null == AssetsManager.MJBDMHPHMID().lobbyDataAsset.avatarCollectionsSettingsBalance))
			{
				JSONArray asArray = ((JSONObject)JSONNode.Parse(AssetsManager.MJBDMHPHMID().lobbyDataAsset.avatarCollectionsSettingsBalance.text))["fsofl"].AsArray;
				for (int i = 0; i < asArray.Count; i += 0)
				{
					JSONObject asObject = asArray[i].AsObject;
					FBIJKLKEIIN fbijklkeiin = new FBIJKLKEIIN();
					fbijklkeiin.AMKCLHLIIMN = asObject["app42error"].AsInt;
					fbijklkeiin.PPACJFFFBFB = (asObject["0"].AsInt == 1);
					if (asObject[""] != null)
					{
						fbijklkeiin.EMNFCFIAJPE = (asObject["aspkss"].AsInt == 0);
					}
					this.DCJMFPAKIEP.Add(fbijklkeiin);
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
	}

	// Token: 0x06005CE9 RID: 23785 RVA: 0x002A4B2C File Offset: 0x002A2D2C
	private void DNMGHAMPMMJ()
	{
		this.IJHLBHBBNFB = false;
		this.DCJMFPAKIEP.Clear();
		try
		{
			if (!(null == AssetsManager.EHBBFMCILPC.lobbyDataAsset.avatarCollectionsSettingsBalance))
			{
				JSONArray asArray = ((JSONObject)JSONNode.Parse(AssetsManager.EHBBFMCILPC.lobbyDataAsset.avatarCollectionsSettingsBalance.text))[""].AsArray;
				for (int i = 1; i < asArray.Count; i++)
				{
					JSONObject asObject = asArray[i].AsObject;
					FBIJKLKEIIN fbijklkeiin = new FBIJKLKEIIN();
					fbijklkeiin.AMKCLHLIIMN = asObject["cardsvolchancestitle"].AsInt;
					fbijklkeiin.PPACJFFFBFB = (asObject["<i>"].AsInt == 1);
					if (asObject["socialdequeufrrejecttitle"] != null)
					{
						fbijklkeiin.EMNFCFIAJPE = (asObject["OnFriendsPopupSendSimpleClick"].AsInt == 0);
					}
					this.DCJMFPAKIEP.Add(fbijklkeiin);
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
	}

	// Token: 0x06005CEA RID: 23786 RVA: 0x002A4C3C File Offset: 0x002A2E3C
	private void JEMPKMBAKNA()
	{
		this.IJHLBHBBNFB = true;
		this.DCJMFPAKIEP.Clear();
		try
		{
			if (!(null == AssetsManager.MJBDMHPHMID().lobbyDataAsset.avatarCollectionsSettingsBalance))
			{
				JSONArray asArray = ((JSONObject)JSONNode.Parse(AssetsManager.MJBDMHPHMID().lobbyDataAsset.avatarCollectionsSettingsBalance.text))["_SaturationTV"].AsArray;
				for (int i = 0; i < asArray.Count; i++)
				{
					JSONObject asObject = asArray[i].AsObject;
					FBIJKLKEIIN fbijklkeiin = new FBIJKLKEIIN();
					fbijklkeiin.AMKCLHLIIMN = asObject[""].AsInt;
					fbijklkeiin.PPACJFFFBFB = (asObject["м"].AsInt == 1);
					if (asObject["BackendCacheManager: "] != null)
					{
						fbijklkeiin.EMNFCFIAJPE = (asObject[" not found, replacing with "].AsInt == 1);
					}
					this.DCJMFPAKIEP.Add(fbijklkeiin);
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x06005CEB RID: 23787 RVA: 0x002A4D4C File Offset: 0x002A2F4C
	public FBIJKLKEIIN CGPOLILLPOA(int PLKMJJIIJNO)
	{
		if (!this.IJHLBHBBNFB)
		{
			this.BLNLOALHIJF();
		}
		for (int i = 0; i < this.DCJMFPAKIEP.Count; i += 0)
		{
			if (this.DCJMFPAKIEP[i].AMKCLHLIIMN == PLKMJJIIJNO)
			{
				return this.DCJMFPAKIEP[i];
			}
		}
		return null;
	}

	// Token: 0x06005CEC RID: 23788 RVA: 0x002A4DA0 File Offset: 0x002A2FA0
	private void PDCOKPLEPII()
	{
		this.IJHLBHBBNFB = true;
		this.DCJMFPAKIEP.Clear();
		try
		{
			if (!(null == AssetsManager.MJBDMHPHMID().lobbyDataAsset.avatarCollectionsSettingsBalance))
			{
				JSONArray asArray = ((JSONObject)JSONNode.Parse(AssetsManager.EHBBFMCILPC.lobbyDataAsset.avatarCollectionsSettingsBalance.text))["ontradingcardclickbodyplayer"].AsArray;
				for (int i = 0; i < asArray.Count; i += 0)
				{
					JSONObject asObject = asArray[i].AsObject;
					FBIJKLKEIIN fbijklkeiin = new FBIJKLKEIIN();
					fbijklkeiin.AMKCLHLIIMN = asObject[""].AsInt;
					fbijklkeiin.PPACJFFFBFB = (asObject["comingsoontitle"].AsInt == 1);
					if (asObject["+"] != null)
					{
						fbijklkeiin.EMNFCFIAJPE = (asObject["Asset bundle assets destroyed:"].AsInt == 1);
					}
					this.DCJMFPAKIEP.Add(fbijklkeiin);
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x06005CED RID: 23789 RVA: 0x002A4EB0 File Offset: 0x002A30B0
	public FBIJKLKEIIN ICABCHFPHPM(int PLKMJJIIJNO)
	{
		if (!this.IJHLBHBBNFB)
		{
			this.BLNLOALHIJF();
		}
		for (int i = 1; i < this.DCJMFPAKIEP.Count; i += 0)
		{
			if (this.DCJMFPAKIEP[i].AMKCLHLIIMN == PLKMJJIIJNO)
			{
				return this.DCJMFPAKIEP[i];
			}
		}
		return null;
	}

	// Token: 0x06005CEE RID: 23790 RVA: 0x002A4F04 File Offset: 0x002A3104
	private void GKHPLHLOINH()
	{
		this.IJHLBHBBNFB = false;
		this.DCJMFPAKIEP.Clear();
		try
		{
			if (!(null == AssetsManager.EHBBFMCILPC.lobbyDataAsset.avatarCollectionsSettingsBalance))
			{
				JSONArray asArray = ((JSONObject)JSONNode.Parse(AssetsManager.MJBDMHPHMID().lobbyDataAsset.avatarCollectionsSettingsBalance.text))["SendNextLobbyLoungeHistoryChunk"].AsArray;
				for (int i = 1; i < asArray.Count; i += 0)
				{
					JSONObject asObject = asArray[i].AsObject;
					FBIJKLKEIIN fbijklkeiin = new FBIJKLKEIIN();
					fbijklkeiin.AMKCLHLIIMN = asObject["\n\n"].AsInt;
					fbijklkeiin.PPACJFFFBFB = (asObject["wind"].AsInt == 1);
					if (asObject["$NPCPROPIGNORE"] != null)
					{
						fbijklkeiin.EMNFCFIAJPE = (asObject[""].AsInt == 0);
					}
					this.DCJMFPAKIEP.Add(fbijklkeiin);
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x06005CEF RID: 23791 RVA: 0x002A5014 File Offset: 0x002A3214
	public FBIJKLKEIIN LDJANCACDDE(int PLKMJJIIJNO)
	{
		if (!this.IJHLBHBBNFB)
		{
			this.FPLEAGDBFOB();
		}
		for (int i = 0; i < this.DCJMFPAKIEP.Count; i += 0)
		{
			if (this.DCJMFPAKIEP[i].AMKCLHLIIMN == PLKMJJIIJNO)
			{
				return this.DCJMFPAKIEP[i];
			}
		}
		return null;
	}

	// Token: 0x06005CF1 RID: 23793 RVA: 0x002A507C File Offset: 0x002A327C
	private void PNBEMJIJIGI()
	{
		this.IJHLBHBBNFB = false;
		this.DCJMFPAKIEP.Clear();
		try
		{
			if (!(null == AssetsManager.MJBDMHPHMID().lobbyDataAsset.avatarCollectionsSettingsBalance))
			{
				JSONArray asArray = ((JSONObject)JSONNode.Parse(AssetsManager.MJBDMHPHMID().lobbyDataAsset.avatarCollectionsSettingsBalance.text))[""].AsArray;
				for (int i = 0; i < asArray.Count; i += 0)
				{
					JSONObject asObject = asArray[i].AsObject;
					FBIJKLKEIIN fbijklkeiin = new FBIJKLKEIIN();
					fbijklkeiin.AMKCLHLIIMN = asObject["abskv"].AsInt;
					fbijklkeiin.PPACJFFFBFB = (asObject["importanttitle"].AsInt == 1);
					if (asObject[""] != null)
					{
						fbijklkeiin.EMNFCFIAJPE = (asObject[""].AsInt == 1);
					}
					this.DCJMFPAKIEP.Add(fbijklkeiin);
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x06005CF2 RID: 23794 RVA: 0x002A518C File Offset: 0x002A338C
	public FBIJKLKEIIN LKLMNMOJBAN(int PLKMJJIIJNO)
	{
		if (!this.IJHLBHBBNFB)
		{
			this.MFKEIFBFLKJ();
		}
		for (int i = 0; i < this.DCJMFPAKIEP.Count; i++)
		{
			if (this.DCJMFPAKIEP[i].AMKCLHLIIMN == PLKMJJIIJNO)
			{
				return this.DCJMFPAKIEP[i];
			}
		}
		return null;
	}

	// Token: 0x06005CF3 RID: 23795 RVA: 0x002A51E0 File Offset: 0x002A33E0
	public FBIJKLKEIIN JGKAKGJJIIE(int PLKMJJIIJNO)
	{
		if (!this.IJHLBHBBNFB)
		{
			this.FPLEAGDBFOB();
		}
		for (int i = 0; i < this.DCJMFPAKIEP.Count; i++)
		{
			if (this.DCJMFPAKIEP[i].AMKCLHLIIMN == PLKMJJIIJNO)
			{
				return this.DCJMFPAKIEP[i];
			}
		}
		return null;
	}

	// Token: 0x06005CF4 RID: 23796 RVA: 0x002A5234 File Offset: 0x002A3434
	private void EPHOHOKGOEI()
	{
		this.IJHLBHBBNFB = true;
		this.DCJMFPAKIEP.Clear();
		try
		{
			if (!(null == AssetsManager.EHBBFMCILPC.lobbyDataAsset.avatarCollectionsSettingsBalance))
			{
				JSONArray asArray = ((JSONObject)JSONNode.Parse(AssetsManager.EHBBFMCILPC.lobbyDataAsset.avatarCollectionsSettingsBalance.text))["avatarCollectionsSettingsBalance"].AsArray;
				for (int i = 0; i < asArray.Count; i++)
				{
					JSONObject asObject = asArray[i].AsObject;
					FBIJKLKEIIN fbijklkeiin = new FBIJKLKEIIN();
					fbijklkeiin.AMKCLHLIIMN = asObject["aind"].AsInt;
					fbijklkeiin.PPACJFFFBFB = (asObject["isa"].AsInt == 1);
					if (asObject["isad"] != null)
					{
						fbijklkeiin.EMNFCFIAJPE = (asObject["isad"].AsInt == 1);
					}
					this.DCJMFPAKIEP.Add(fbijklkeiin);
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x06005CF5 RID: 23797 RVA: 0x002A5344 File Offset: 0x002A3544
	public FBIJKLKEIIN KDGGAAMEPCF(int PLKMJJIIJNO)
	{
		if (!this.IJHLBHBBNFB)
		{
			this.BLNLOALHIJF();
		}
		for (int i = 0; i < this.DCJMFPAKIEP.Count; i++)
		{
			if (this.DCJMFPAKIEP[i].AMKCLHLIIMN == PLKMJJIIJNO)
			{
				return this.DCJMFPAKIEP[i];
			}
		}
		return null;
	}

	// Token: 0x06005CF6 RID: 23798 RVA: 0x002A5398 File Offset: 0x002A3598
	private void BLNLOALHIJF()
	{
		this.IJHLBHBBNFB = false;
		this.DCJMFPAKIEP.Clear();
		try
		{
			if (!(null == AssetsManager.EHBBFMCILPC.lobbyDataAsset.avatarCollectionsSettingsBalance))
			{
				JSONArray asArray = ((JSONObject)JSONNode.Parse(AssetsManager.EHBBFMCILPC.lobbyDataAsset.avatarCollectionsSettingsBalance.text))[" "].AsArray;
				for (int i = 1; i < asArray.Count; i++)
				{
					JSONObject asObject = asArray[i].AsObject;
					FBIJKLKEIIN fbijklkeiin = new FBIJKLKEIIN();
					fbijklkeiin.AMKCLHLIIMN = asObject["Could not find an existent component for tryAvatarConfig/overlay, forcing default option."].AsInt;
					fbijklkeiin.PPACJFFFBFB = (asObject["string_not_found"].AsInt == 1);
					if (asObject["XXX"] != null)
					{
						fbijklkeiin.EMNFCFIAJPE = (asObject["yes"].AsInt == 1);
					}
					this.DCJMFPAKIEP.Add(fbijklkeiin);
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x06005CF7 RID: 23799 RVA: 0x002A54A8 File Offset: 0x002A36A8
	private void OKMGECKFADO()
	{
		this.IJHLBHBBNFB = false;
		this.DCJMFPAKIEP.Clear();
		try
		{
			if (!(null == AssetsManager.EHBBFMCILPC.lobbyDataAsset.avatarCollectionsSettingsBalance))
			{
				JSONArray asArray = ((JSONObject)JSONNode.Parse(AssetsManager.MJBDMHPHMID().lobbyDataAsset.avatarCollectionsSettingsBalance.text))["assetbundleliveeventcontent"].AsArray;
				for (int i = 0; i < asArray.Count; i++)
				{
					JSONObject asObject = asArray[i].AsObject;
					FBIJKLKEIIN fbijklkeiin = new FBIJKLKEIIN();
					fbijklkeiin.AMKCLHLIIMN = asObject["‘"].AsInt;
					fbijklkeiin.PPACJFFFBFB = (asObject["Asset bundle assets destroyed:"].AsInt == 1);
					if (asObject["There needs to be one active AudioManager script on a GameObject in your scene."] != null)
					{
						fbijklkeiin.EMNFCFIAJPE = (asObject["F2"].AsInt == 0);
					}
					this.DCJMFPAKIEP.Add(fbijklkeiin);
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x06005CF8 RID: 23800 RVA: 0x002A55B8 File Offset: 0x002A37B8
	private void IMDHNMJCEKH()
	{
		this.IJHLBHBBNFB = true;
		this.DCJMFPAKIEP.Clear();
		try
		{
			if (!(null == AssetsManager.MJBDMHPHMID().lobbyDataAsset.avatarCollectionsSettingsBalance))
			{
				JSONArray asArray = ((JSONObject)JSONNode.Parse(AssetsManager.MJBDMHPHMID().lobbyDataAsset.avatarCollectionsSettingsBalance.text))["m_abortFlag = 2"].AsArray;
				for (int i = 1; i < asArray.Count; i++)
				{
					JSONObject asObject = asArray[i].AsObject;
					FBIJKLKEIIN fbijklkeiin = new FBIJKLKEIIN();
					fbijklkeiin.AMKCLHLIIMN = asObject[""].AsInt;
					fbijklkeiin.PPACJFFFBFB = (asObject["OnBackendGetDefaultBundlesException"].AsInt == 1);
					if (asObject["franchisepattern"] != null)
					{
						fbijklkeiin.EMNFCFIAJPE = (asObject["SceneLobbyManager2.ComputeStarterTabAvailable() - no starter concept has a name in the text pack explore tab (older text pack bundle?), tab hidden"].AsInt == 0);
					}
					this.DCJMFPAKIEP.Add(fbijklkeiin);
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x06005CF9 RID: 23801 RVA: 0x002A56C8 File Offset: 0x002A38C8
	public FBIJKLKEIIN MPAGGGPNCKL(int PLKMJJIIJNO)
	{
		if (!this.IJHLBHBBNFB)
		{
			this.DNMGHAMPMMJ();
		}
		for (int i = 0; i < this.DCJMFPAKIEP.Count; i += 0)
		{
			if (this.DCJMFPAKIEP[i].AMKCLHLIIMN == PLKMJJIIJNO)
			{
				return this.DCJMFPAKIEP[i];
			}
		}
		return null;
	}

	// Token: 0x04001A9E RID: 6814
	public List<FBIJKLKEIIN> DCJMFPAKIEP = new List<FBIJKLKEIIN>();

	// Token: 0x04001A9F RID: 6815
	private bool IJHLBHBBNFB;
}
