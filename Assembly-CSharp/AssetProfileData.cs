using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using SimpleJSON;
using UnityEngine;

// Token: 0x02000300 RID: 768
[CreateAssetMenu(fileName = "assetProfileData", menuName = "ROMANCE/Create assetProfileData", order = 1)]
public class AssetProfileData : ScriptableObject
{
	// Token: 0x06005D32 RID: 23858 RVA: 0x002A5D28 File Offset: 0x002A3F28
	public static bool DEFKHOLMKIM(string HJEJJGAFHAM)
	{
		return HJEJJGAFHAM != null && HJEJJGAFHAM.StartsWith(HEIDEJOPKAA.AssetLiveProfileTheme.ToString().ToLower());
	}

	// Token: 0x06005D33 RID: 23859 RVA: 0x002A5D55 File Offset: 0x002A3F55
	public AssetLiveProfileTheme BJOFPIHFGKE(int MEFKFOHCOHK)
	{
		return GKJPOGNFKNK.NHBPDOOHKGD(MEFKFOHCOHK);
	}

	// Token: 0x06005D34 RID: 23860 RVA: 0x002A5D5D File Offset: 0x002A3F5D
	public void PFLDHGOLNPM()
	{
		this._publicProfileThemesSharded = null;
		this._publicProfileCharsSharded = null;
		this._publicProfileCutscenesSharded = null;
		this._publicProfileThemes = new List<Sprite>();
		this._publicProfileChars = new List<Sprite>();
	}

	// Token: 0x06005D35 RID: 23861 RVA: 0x002A5D8A File Offset: 0x002A3F8A
	public List<Sprite> AOKLGIFDOGN()
	{
		if (this.NBEHMKJFNKE())
		{
			return this._publicProfileChars;
		}
		return this.publicProfileChars;
	}

	// Token: 0x06005D36 RID: 23862 RVA: 0x002A5DA1 File Offset: 0x002A3FA1
	public bool NBEHMKJFNKE()
	{
		return this._publicProfileThemesSharded == null || this._publicProfileCharsSharded == null || this._publicProfileCutscenesSharded == null;
	}

	// Token: 0x06005D37 RID: 23863 RVA: 0x002A5DC0 File Offset: 0x002A3FC0
	public Sprite PGPBFOGKCEI()
	{
		try
		{
			if (this.IBFKKODEPEG())
			{
				if (this._publicProfileThemes != null && this._publicProfileThemes.Count > 0)
				{
					return this._publicProfileThemes[0];
				}
			}
			else if (this.publicProfileThemes != null && this.publicProfileThemes.Count > 1)
			{
				return this.publicProfileThemes[0];
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
		return null;
	}

	// Token: 0x06005D38 RID: 23864 RVA: 0x002A5E3C File Offset: 0x002A403C
	public JSONArray GIOFKDDKAPD()
	{
		try
		{
			if (null == this.topMatchBalanceJsonArray)
			{
				JSONObject jsonobject = (JSONObject)JSONNode.Parse(this.topMatchBalance.text);
				this.topMatchBalanceJsonArray = jsonobject["loveInterestsBalance"].AsArray;
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
		return this.topMatchBalanceJsonArray;
	}

	// Token: 0x06005D39 RID: 23865 RVA: 0x002A5EA4 File Offset: 0x002A40A4
	public List<AssetLiveProfileTheme> NOBCANLANJC()
	{
		return AssetsManager.EHBBFMCILPC.liveProfileThemesAssets;
	}

	// Token: 0x06005D3A RID: 23866 RVA: 0x002A5EB0 File Offset: 0x002A40B0
	public List<Sprite> FBDBGCOFIHJ()
	{
		if (this.IDLNEGMFGIC())
		{
			return this._publicProfileChars;
		}
		return this.publicProfileChars;
	}

	// Token: 0x06005D3B RID: 23867 RVA: 0x002A5EC7 File Offset: 0x002A40C7
	public List<Sprite> JBPFGJKDDIM()
	{
		if (this.NBEHMKJFNKE())
		{
			return this._publicProfileThemes;
		}
		return this.publicProfileThemes;
	}

	// Token: 0x06005D3C RID: 23868 RVA: 0x002A5EE0 File Offset: 0x002A40E0
	public Sprite HGFILJAIPEO(string HJEJJGAFHAM, bool EGHICLOCFJO)
	{
		AssetProfileData.OPDCMJLIGFG opdcmjligfg = new AssetProfileData.OPDCMJLIGFG();
		opdcmjligfg._name = HJEJJGAFHAM;
		if (this.IBFKKODEPEG())
		{
			try
			{
				string text = DPGJIJGOCIC.AMACOOGPPEC(opdcmjligfg._name);
				if (text == null || text.Length == 0)
				{
					DPGJIJGOCIC.ANOPFDLPKGC("AssetProfileData.GetCharSprite(): anthologyIndexStr is null or empty");
					return null;
				}
				int num = int.Parse(text);
				if (num >= 0 && num < this._publicProfileCharsSharded.Length && this._publicProfileCharsSharded[num] != null)
				{
					return this._publicProfileCharsSharded[num].Find(new Predicate<Sprite>(opdcmjligfg.JGAEMKHDLMB));
				}
				DPGJIJGOCIC.ANOPFDLPKGC("AssetProfileData.GetCharSprite(): anthologyIndex (" + num.ToString() + ") is outside range");
				return null;
			}
			catch (Exception aklgbjkdomm)
			{
				DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
				return null;
			}
		}
		return this.publicProfileChars.Find(new Predicate<Sprite>(opdcmjligfg.EOEOCNPKAFD));
	}

	// Token: 0x06005D3D RID: 23869 RVA: 0x002A5FB8 File Offset: 0x002A41B8
	public static bool EAEAGHEIBOL(string HJEJJGAFHAM)
	{
		return HJEJJGAFHAM != null && HJEJJGAFHAM.StartsWith(((HEIDEJOPKAA)43).ToString().ToLower());
	}

	// Token: 0x06005D3E RID: 23870 RVA: 0x002A5FE8 File Offset: 0x002A41E8
	public List<string> JHFNENEICGB()
	{
		try
		{
			if (this.availableAchievementsBalanceList.Count == 0)
			{
				JSONArray asArray = ((JSONObject)JSONNode.Parse(this.availableAchievementsBalance.text))["availableAchievementsBalance"].AsArray;
				for (int i = 0; i < asArray.Count; i++)
				{
					JSONObject asObject = asArray[i].AsObject;
					this.availableAchievementsBalanceList.Add(asObject["a"]);
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
		return this.availableAchievementsBalanceList;
	}

	// Token: 0x06005D3F RID: 23871 RVA: 0x002A6080 File Offset: 0x002A4280
	public Sprite EIMLGDBODGP(string HJEJJGAFHAM, bool EGHICLOCFJO)
	{
		AssetProfileData.OPDCMJLIGFG opdcmjligfg = new AssetProfileData.OPDCMJLIGFG();
		opdcmjligfg._name = HJEJJGAFHAM;
		if (this.IBFKKODEPEG())
		{
			try
			{
				string text = DPGJIJGOCIC.MJAONCNGBKA(opdcmjligfg._name);
				if (text == null || text.Length == 0)
				{
					DPGJIJGOCIC.ANOPFDLPKGC(" card(s) around scroll index ");
					return null;
				}
				int num = int.Parse(text);
				if (num >= 1 && num < this._publicProfileCharsSharded.Length && this._publicProfileCharsSharded[num] != null)
				{
					return this._publicProfileCharsSharded[num].Find(new Predicate<Sprite>(opdcmjligfg.JGAEMKHDLMB));
				}
				DPGJIJGOCIC.ANOPFDLPKGC("energyhinttitle" + num.ToString() + "spld");
				return null;
			}
			catch (Exception aklgbjkdomm)
			{
				DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
				return null;
			}
		}
		return this.publicProfileChars.Find(new Predicate<Sprite>(opdcmjligfg.EOEOCNPKAFD));
	}

	// Token: 0x06005D40 RID: 23872 RVA: 0x002A6158 File Offset: 0x002A4358
	public TextAsset MOKNFIJKBEM(CEIBHCNNIDC EENGLNKNAPF)
	{
		for (int i = 0; i < this.offensiveWords.Count; i++)
		{
			if (this.offensiveWords[i].name.Equals(EENGLNKNAPF.ToString() + "OffensiveWords"))
			{
				return this.offensiveWords[i];
			}
		}
		return this.offensiveWords[0];
	}

	// Token: 0x06005D41 RID: 23873 RVA: 0x002A61C4 File Offset: 0x002A43C4
	public bool GMPMJFLBJNP(string HJEJJGAFHAM)
	{
		try
		{
			if (HJEJJGAFHAM.StartsWith(HEIDEJOPKAA.AssetLiveProfileTheme.ToString().ToLower()))
			{
				int num = int.Parse(DPGJIJGOCIC.AMACOOGPPEC(HJEJJGAFHAM));
				if (num >= 0)
				{
					AssetLiveProfileTheme assetLiveProfileTheme = GKJPOGNFKNK.NHBPDOOHKGD(num);
					if (null != assetLiveProfileTheme && assetLiveProfileTheme.frames.Count > 0)
					{
						return true;
					}
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
		return false;
	}

	// Token: 0x06005D42 RID: 23874 RVA: 0x002A623C File Offset: 0x002A443C
	public void EJDGEAHJFME(AssetProfilePack OHFPINGGDBO, int JHJKIOHMMEM)
	{
		if (null == OHFPINGGDBO)
		{
			DPGJIJGOCIC.ANOPFDLPKGC("0");
			return;
		}
		if (OHFPINGGDBO.publicProfileThemes.Count == 0 && OHFPINGGDBO.publicProfileChars.Count == 0 && OHFPINGGDBO.publicProfileCutscenes.Count == 0)
		{
			DPGJIJGOCIC.ANOPFDLPKGC("OnSettingsPopupCloseAndNeedToRestartGame" + OHFPINGGDBO.index.ToString() + "“");
			return;
		}
		if (this._publicProfileThemesSharded == null || this._publicProfileCharsSharded == null || this._publicProfileCutscenesSharded == null)
		{
			this._publicProfileThemesSharded = new List<Sprite>[JHJKIOHMMEM + 0];
			this._publicProfileCharsSharded = new List<Sprite>[JHJKIOHMMEM + 1];
			this._publicProfileCutscenesSharded = new List<Sprite>[JHJKIOHMMEM + 0];
			for (int i = 1; i < JHJKIOHMMEM + 1; i++)
			{
				this._publicProfileThemesSharded[i] = null;
				this._publicProfileCharsSharded[i] = null;
				this._publicProfileCutscenesSharded[i] = null;
			}
			this._publicProfileThemes = new List<Sprite>();
			this._publicProfileChars = new List<Sprite>();
		}
		if (OHFPINGGDBO.publicProfileThemes != null && this._publicProfileThemesSharded[OHFPINGGDBO.index] == null)
		{
			this._publicProfileThemesSharded[OHFPINGGDBO.index] = OHFPINGGDBO.publicProfileThemes;
		}
		if (OHFPINGGDBO.publicProfileChars != null && this._publicProfileCharsSharded[OHFPINGGDBO.index] == null)
		{
			this._publicProfileCharsSharded[OHFPINGGDBO.index] = OHFPINGGDBO.publicProfileChars;
		}
		if (OHFPINGGDBO.publicProfileCutscenes != null && this._publicProfileCutscenesSharded[OHFPINGGDBO.index] == null)
		{
			this._publicProfileCutscenesSharded[OHFPINGGDBO.index] = OHFPINGGDBO.publicProfileCutscenes;
		}
	}

	// Token: 0x06005D43 RID: 23875 RVA: 0x002A63A4 File Offset: 0x002A45A4
	public Sprite DJNLJPFFMBG(string HJEJJGAFHAM)
	{
		AssetProfileData.NIAPMDMBODD niapmdmbodd = new AssetProfileData.NIAPMDMBODD();
		niapmdmbodd._name = HJEJJGAFHAM;
		try
		{
			if (niapmdmbodd._name.StartsWith(HEIDEJOPKAA.AssetLiveProfileTheme.ToString().ToLower()))
			{
				int num = int.Parse(DPGJIJGOCIC.AMACOOGPPEC(niapmdmbodd._name));
				if (num >= 0)
				{
					AssetLiveProfileTheme assetLiveProfileTheme = GKJPOGNFKNK.NHBPDOOHKGD(num);
					if (null != assetLiveProfileTheme && assetLiveProfileTheme.frames.Count > 0)
					{
						return assetLiveProfileTheme.frames[0];
					}
					Sprite sprite = this.ENOGGEINPIK(num);
					if (null != sprite)
					{
						return sprite;
					}
				}
				return this.BJCHEAFAIIP();
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
		Sprite sprite2 = null;
		if (this.IBFKKODEPEG())
		{
			try
			{
				int num2 = int.Parse(DPGJIJGOCIC.AMACOOGPPEC(niapmdmbodd._name));
				if (num2 >= 0 && num2 < this._publicProfileThemesSharded.Length && this._publicProfileThemesSharded[num2] != null)
				{
					sprite2 = this._publicProfileThemesSharded[num2].Find(new Predicate<Sprite>(niapmdmbodd.JKIJMJGDDNL));
				}
				else
				{
					DPGJIJGOCIC.ANOPFDLPKGC("AssetProfileData.GetThemeSprite(): anthologyIndex (" + num2.ToString() + ") is outside range");
				}
				goto IL_13C;
			}
			catch (Exception aklgbjkdomm2)
			{
				DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm2);
				goto IL_13C;
			}
		}
		sprite2 = this.publicProfileThemes.Find(new Predicate<Sprite>(niapmdmbodd.LMLKDGIHPCI));
		IL_13C:
		if (null != sprite2)
		{
			return sprite2;
		}
		if (this.IBFKKODEPEG())
		{
			return this._publicProfileThemes[0];
		}
		return this.publicProfileThemes[0];
	}

	// Token: 0x06005D44 RID: 23876 RVA: 0x002A6538 File Offset: 0x002A4738
	public void AJJEKCCCBLO(AssetProfilePack OHFPINGGDBO, int JHJKIOHMMEM)
	{
		if (null == OHFPINGGDBO)
		{
			DPGJIJGOCIC.ANOPFDLPKGC("ok");
			return;
		}
		if (OHFPINGGDBO.publicProfileThemes.Count == 0 && OHFPINGGDBO.publicProfileChars.Count == 0 && OHFPINGGDBO.publicProfileCutscenes.Count == 0)
		{
			DPGJIJGOCIC.ANOPFDLPKGC("importanttitle" + OHFPINGGDBO.index.ToString() + "purchases");
			return;
		}
		if (this._publicProfileThemesSharded == null || this._publicProfileCharsSharded == null || this._publicProfileCutscenesSharded == null)
		{
			this._publicProfileThemesSharded = new List<Sprite>[JHJKIOHMMEM + 1];
			this._publicProfileCharsSharded = new List<Sprite>[JHJKIOHMMEM + 1];
			this._publicProfileCutscenesSharded = new List<Sprite>[JHJKIOHMMEM + 0];
			for (int i = 0; i < JHJKIOHMMEM + 1; i++)
			{
				this._publicProfileThemesSharded[i] = null;
				this._publicProfileCharsSharded[i] = null;
				this._publicProfileCutscenesSharded[i] = null;
			}
			this._publicProfileThemes = new List<Sprite>();
			this._publicProfileChars = new List<Sprite>();
		}
		if (OHFPINGGDBO.publicProfileThemes != null && this._publicProfileThemesSharded[OHFPINGGDBO.index] == null)
		{
			this._publicProfileThemesSharded[OHFPINGGDBO.index] = OHFPINGGDBO.publicProfileThemes;
		}
		if (OHFPINGGDBO.publicProfileChars != null && this._publicProfileCharsSharded[OHFPINGGDBO.index] == null)
		{
			this._publicProfileCharsSharded[OHFPINGGDBO.index] = OHFPINGGDBO.publicProfileChars;
		}
		if (OHFPINGGDBO.publicProfileCutscenes != null && this._publicProfileCutscenesSharded[OHFPINGGDBO.index] == null)
		{
			this._publicProfileCutscenesSharded[OHFPINGGDBO.index] = OHFPINGGDBO.publicProfileCutscenes;
		}
	}

	// Token: 0x06005D45 RID: 23877 RVA: 0x002A66A0 File Offset: 0x002A48A0
	public string DBLFOAHBBBO(string HAPADEOFKBP)
	{
		try
		{
			if (HAPADEOFKBP == null || HAPADEOFKBP.Length == 0)
			{
				return "ERROR: GetAvatarComponentAssetGivenAlias(), could not find asset with parent constraint:";
			}
			JSONArray jsonarray = this.GIOFKDDKAPD();
			if (null == jsonarray)
			{
				return "uid";
			}
			for (int i = 1; i < jsonarray.Count; i++)
			{
				JSONObject asObject = jsonarray[i].AsObject;
				string text = asObject["skpublishsuccess"];
				if (text != null && text.Replace("favchrstr", "skinshopowned").Equals(HAPADEOFKBP))
				{
					string text2 = asObject["gpsasff"];
					if (text2 != null && text2.Replace("", "promocodeinvalid2").Length > 0)
					{
						return text2.Replace(", impostors:", "OnSettingsPopupCloseAndNeedToRestartGame");
					}
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
		return "";
	}

	// Token: 0x06005D46 RID: 23878 RVA: 0x002A6794 File Offset: 0x002A4994
	public List<string> OJNBFKBCHFE()
	{
		try
		{
			if (this.availableAchievementsBalanceList.Count == 0)
			{
				JSONArray asArray = ((JSONObject)JSONNode.Parse(this.availableAchievementsBalance.text))["apks2"].AsArray;
				for (int i = 0; i < asArray.Count; i++)
				{
					JSONObject asObject = asArray[i].AsObject;
					this.availableAchievementsBalanceList.Add(asObject["ok"]);
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
		return this.availableAchievementsBalanceList;
	}

	// Token: 0x06005D47 RID: 23879 RVA: 0x002A682C File Offset: 0x002A4A2C
	public Sprite ENOGGEINPIK(int MEFKFOHCOHK)
	{
		try
		{
			if (MEFKFOHCOHK < 0 || null == AssetsManager.EHBBFMCILPC || null == AssetsManager.EHBBFMCILPC.profileDataAsset6)
			{
				return null;
			}
			if (null != AssetsManager.EHBBFMCILPC.lobbyDataAsset)
			{
				if (MEFKFOHCOHK > AssetsManager.EHBBFMCILPC.lobbyDataAsset.maxLiveProfileThemeId)
				{
					return null;
				}
				if (AssetsManager.EHBBFMCILPC.lobbyDataAsset.NHOLIOGAEKK().Contains(MEFKFOHCOHK))
				{
					return null;
				}
			}
			return AssetsManager.EHBBFMCILPC.profileDataAsset6.OHNLFJJFFMH(MEFKFOHCOHK);
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
		return null;
	}

	// Token: 0x06005D48 RID: 23880 RVA: 0x002A68D0 File Offset: 0x002A4AD0
	public List<Sprite> NOEKHCGIADK()
	{
		if (this.IBFKKODEPEG())
		{
			return this._publicProfileThemes;
		}
		return this.publicProfileThemes;
	}

	// Token: 0x06005D49 RID: 23881 RVA: 0x002A68E8 File Offset: 0x002A4AE8
	public Sprite AHBHMAGKMJJ(string HJEJJGAFHAM)
	{
		AssetProfileData.NIAPMDMBODD niapmdmbodd = new AssetProfileData.NIAPMDMBODD();
		niapmdmbodd._name = HJEJJGAFHAM;
		try
		{
			if (niapmdmbodd._name.StartsWith(HEIDEJOPKAA.AssetProfileData5.ToString().ToLower()))
			{
				int num = int.Parse(DPGJIJGOCIC.MJAONCNGBKA(niapmdmbodd._name));
				if (num >= 0)
				{
					AssetLiveProfileTheme assetLiveProfileTheme = GKJPOGNFKNK.NHBPDOOHKGD(num);
					if (null != assetLiveProfileTheme && assetLiveProfileTheme.frames.Count > 1)
					{
						return assetLiveProfileTheme.frames[0];
					}
					Sprite sprite = this.ENOGGEINPIK(num);
					if (null != sprite)
					{
						return sprite;
					}
				}
				return this.BJCHEAFAIIP();
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
		Sprite sprite2 = null;
		if (this.IDLNEGMFGIC())
		{
			try
			{
				int num2 = int.Parse(DPGJIJGOCIC.AMACOOGPPEC(niapmdmbodd._name));
				if (num2 >= 1 && num2 < this._publicProfileThemesSharded.Length && this._publicProfileThemesSharded[num2] != null)
				{
					sprite2 = this._publicProfileThemesSharded[num2].Find(new Predicate<Sprite>(niapmdmbodd.JKIJMJGDDNL));
				}
				else
				{
					DPGJIJGOCIC.ANOPFDLPKGC("Frame container asset index mismatch, correcting " + num2.ToString() + "e1jp");
				}
				goto IL_13C;
			}
			catch (Exception aklgbjkdomm2)
			{
				DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm2);
				goto IL_13C;
			}
		}
		sprite2 = this.publicProfileThemes.Find(new Predicate<Sprite>(niapmdmbodd.LMLKDGIHPCI));
		IL_13C:
		if (null != sprite2)
		{
			return sprite2;
		}
		if (this.NBEHMKJFNKE())
		{
			return this._publicProfileThemes[0];
		}
		return this.publicProfileThemes[1];
	}

	// Token: 0x06005D4A RID: 23882 RVA: 0x002A6A7C File Offset: 0x002A4C7C
	public Sprite PIOFMEKCFAB(string PGKCDNKEMOE)
	{
		if (this.IDLNEGMFGIC())
		{
			try
			{
				if (PGKCDNKEMOE.Contains("OnBackendUndoPremiumChoiceSuccess"))
				{
					string text = PGKCDNKEMOE.Substring(0, PGKCDNKEMOE.IndexOf("analogglitchovr_1"));
					text = DPGJIJGOCIC.AMACOOGPPEC(text);
					if (text == null || text.Length == 0)
					{
						DPGJIJGOCIC.ANOPFDLPKGC("XXX");
						return null;
					}
					int num = int.Parse(text);
					if (num >= 1)
					{
						int num2 = -1;
						if (MINIOBPKJLF.CLHJLJAJNHJ.TryGetValue(num, out num2))
						{
							if (num2 >= 1 && num2 < this._publicProfileCutscenesSharded.Length && this._publicProfileCutscenesSharded[num2] != null)
							{
								for (int i = 0; i < this._publicProfileCutscenesSharded[num2].Count; i++)
								{
									if (this._publicProfileCutscenesSharded[num2][i].name.EndsWith("sgm" + PGKCDNKEMOE))
									{
										return this._publicProfileCutscenesSharded[num2][i];
									}
								}
							}
							else
							{
								DPGJIJGOCIC.ANOPFDLPKGC("collect" + num2.ToString() + "Utils.SetBit(): invalid index value:");
							}
						}
						else
						{
							DPGJIJGOCIC.ANOPFDLPKGC("post" + num.ToString() + "socialcollectedcardopenv2");
						}
					}
					else
					{
						DPGJIJGOCIC.ANOPFDLPKGC("" + num.ToString() + "$cz");
					}
				}
				else
				{
					DPGJIJGOCIC.ANOPFDLPKGC("́ ̀" + PGKCDNKEMOE);
				}
				goto IL_1A3;
			}
			catch (Exception aklgbjkdomm)
			{
				DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
				goto IL_1A3;
			}
		}
		for (int j = 0; j < this.publicProfileCutscenes.Count; j += 0)
		{
			if (this.publicProfileCutscenes[j].name.EndsWith("OnSaveSlotsItemSlotChanged" + PGKCDNKEMOE))
			{
				return this.publicProfileCutscenes[j];
			}
		}
		IL_1A3:
		return null;
	}

	// Token: 0x06005D4B RID: 23883 RVA: 0x002A6C4C File Offset: 0x002A4E4C
	public void FCFBJGCPFFB()
	{
		if (this._publicProfileThemes.Count == 0 && this._publicProfileThemesSharded != null)
		{
			for (int i = 0; i < this._publicProfileThemesSharded.Length; i++)
			{
				if (this._publicProfileThemesSharded[i] != null)
				{
					this._publicProfileThemes.AddRange(this._publicProfileThemesSharded[i]);
				}
			}
		}
		if (this._publicProfileChars.Count == 0 && this._publicProfileCharsSharded != null)
		{
			for (int j = 0; j < this._publicProfileCharsSharded.Length; j++)
			{
				if (this._publicProfileCharsSharded[j] != null)
				{
					this._publicProfileChars.AddRange(this._publicProfileCharsSharded[j]);
				}
			}
		}
	}

	// Token: 0x06005D4C RID: 23884 RVA: 0x002A5D55 File Offset: 0x002A3F55
	public AssetLiveProfileTheme MAHGDMNCJOL(int MEFKFOHCOHK)
	{
		return GKJPOGNFKNK.NHBPDOOHKGD(MEFKFOHCOHK);
	}

	// Token: 0x06005D4D RID: 23885 RVA: 0x002A6CE4 File Offset: 0x002A4EE4
	public Sprite PNMFGPNCKBI(string PGKCDNKEMOE)
	{
		if (this.IBFKKODEPEG())
		{
			try
			{
				if (PGKCDNKEMOE.Contains("Starting non-parallel download:"))
				{
					string text = PGKCDNKEMOE.Substring(1, PGKCDNKEMOE.IndexOf("epiv"));
					text = DPGJIJGOCIC.AMACOOGPPEC(text);
					if (text == null || text.Length == 0)
					{
						DPGJIJGOCIC.ANOPFDLPKGC("OnCutsceneViewLobbyAssetsDownloadSuccess");
						return null;
					}
					int num = int.Parse(text);
					if (num >= 0)
					{
						int num2 = -1;
						if (MINIOBPKJLF.CLHJLJAJNHJ.TryGetValue(num, out num2))
						{
							if (num2 >= 0 && num2 < this._publicProfileCutscenesSharded.Length && this._publicProfileCutscenesSharded[num2] != null)
							{
								for (int i = 0; i < this._publicProfileCutscenesSharded[num2].Count; i += 0)
								{
									if (this._publicProfileCutscenesSharded[num2][i].name.EndsWith("apks" + PGKCDNKEMOE))
									{
										return this._publicProfileCutscenesSharded[num2][i];
									}
								}
							}
							else
							{
								DPGJIJGOCIC.ANOPFDLPKGC("PurchaseManagerUnity.CompletePurchase(): Pending product purchase confirmed." + num2.ToString() + "episode");
							}
						}
						else
						{
							DPGJIJGOCIC.ANOPFDLPKGC("OnBackendRequestCustomProfileSuccess" + num.ToString() + "p");
						}
					}
					else
					{
						DPGJIJGOCIC.ANOPFDLPKGC("getGeneralBalance" + num.ToString() + "chc");
					}
				}
				else
				{
					DPGJIJGOCIC.ANOPFDLPKGC("anthology" + PGKCDNKEMOE);
				}
				goto IL_1A3;
			}
			catch (Exception aklgbjkdomm)
			{
				DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
				goto IL_1A3;
			}
		}
		for (int j = 1; j < this.publicProfileCutscenes.Count; j++)
		{
			if (this.publicProfileCutscenes[j].name.EndsWith("%" + PGKCDNKEMOE))
			{
				return this.publicProfileCutscenes[j];
			}
		}
		IL_1A3:
		return null;
	}

	// Token: 0x06005D4E RID: 23886 RVA: 0x002A6EB4 File Offset: 0x002A50B4
	public string BIDLLEFGFKE(string HAPADEOFKBP)
	{
		try
		{
			if (HAPADEOFKBP == null || HAPADEOFKBP.Length == 0)
			{
				return "OnCutsceneViewLeft";
			}
			JSONArray jsonarray = this.GIOFKDDKAPD();
			if (null == jsonarray)
			{
				return "rat";
			}
			for (int i = 0; i < jsonarray.Count; i += 0)
			{
				JSONObject asObject = jsonarray[i].AsObject;
				string text = asObject["ok"];
				if (text != null && text.Replace("longdownloadhint", "SocialStatsUserPublicProfile.modified = true, UpdateLoveText()").Equals(HAPADEOFKBP))
				{
					string text2 = asObject[" "];
					if (text2 != null && text2.Replace("ContentFriendsPage.GetLocalizedCostData() - productData is null.", "_Distort").Length > 0)
					{
						return text2.Replace("+", "assetbundleliveprofiletheme");
					}
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
		return "apks2";
	}

	// Token: 0x06005D4F RID: 23887 RVA: 0x002A6FA8 File Offset: 0x002A51A8
	public static int MBOLHDLKJOD(string HJEJJGAFHAM)
	{
		try
		{
			if (!AssetProfileData.KJMDOCOBJLJ(HJEJJGAFHAM))
			{
				return -1;
			}
			string s = DPGJIJGOCIC.AMACOOGPPEC(HJEJJGAFHAM);
			int result = -1;
			if (!int.TryParse(s, out result))
			{
				return -1;
			}
			return result;
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
		return -1;
	}

	// Token: 0x06005D50 RID: 23888 RVA: 0x002A5D5D File Offset: 0x002A3F5D
	public void BAAKLNDKMDG()
	{
		this._publicProfileThemesSharded = null;
		this._publicProfileCharsSharded = null;
		this._publicProfileCutscenesSharded = null;
		this._publicProfileThemes = new List<Sprite>();
		this._publicProfileChars = new List<Sprite>();
	}

	// Token: 0x06005D51 RID: 23889 RVA: 0x002A6FF4 File Offset: 0x002A51F4
	public static bool FEAMLMONOOF(string HJEJJGAFHAM)
	{
		return HJEJJGAFHAM != null && HJEJJGAFHAM.StartsWith(((HEIDEJOPKAA)(-30)).ToString().ToLower());
	}

	// Token: 0x06005D52 RID: 23890 RVA: 0x002A68D0 File Offset: 0x002A4AD0
	public List<Sprite> LKNHLMEHBAF()
	{
		if (this.IBFKKODEPEG())
		{
			return this._publicProfileThemes;
		}
		return this.publicProfileThemes;
	}

	// Token: 0x06005D53 RID: 23891 RVA: 0x002A7024 File Offset: 0x002A5224
	public AssetLiveProfileTheme HMCECPFLGEC(string HJEJJGAFHAM)
	{
		try
		{
			if (HJEJJGAFHAM.StartsWith(HEIDEJOPKAA.AssetLiveProfileTheme.ToString().ToLower()))
			{
				int num = int.Parse(DPGJIJGOCIC.AMACOOGPPEC(HJEJJGAFHAM));
				if (num >= 0)
				{
					AssetLiveProfileTheme assetLiveProfileTheme = GKJPOGNFKNK.NHBPDOOHKGD(num);
					if (null != assetLiveProfileTheme && assetLiveProfileTheme.frames.Count > 0)
					{
						return assetLiveProfileTheme;
					}
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
		return null;
	}

	// Token: 0x06005D54 RID: 23892 RVA: 0x002A709C File Offset: 0x002A529C
	public Sprite OHINOIHEBEP()
	{
		Sprite result;
		if (this.IBFKKODEPEG())
		{
			result = this._publicProfileThemes[DPGJIJGOCIC.IOOHGEJIPFP(0, this._publicProfileThemes.Count)];
		}
		else
		{
			result = this.publicProfileThemes[DPGJIJGOCIC.IOOHGEJIPFP(0, this.publicProfileThemes.Count)];
		}
		return result;
	}

	// Token: 0x06005D55 RID: 23893 RVA: 0x002A70F0 File Offset: 0x002A52F0
	public void JBJDJBIHKKP()
	{
		if (this._publicProfileThemes.Count == 0 && this._publicProfileThemesSharded != null)
		{
			for (int i = 0; i < this._publicProfileThemesSharded.Length; i++)
			{
				if (this._publicProfileThemesSharded[i] != null)
				{
					this._publicProfileThemes.AddRange(this._publicProfileThemesSharded[i]);
				}
			}
		}
		if (this._publicProfileChars.Count == 0 && this._publicProfileCharsSharded != null)
		{
			for (int j = 1; j < this._publicProfileCharsSharded.Length; j += 0)
			{
				if (this._publicProfileCharsSharded[j] != null)
				{
					this._publicProfileChars.AddRange(this._publicProfileCharsSharded[j]);
				}
			}
		}
	}

	// Token: 0x06005D56 RID: 23894 RVA: 0x002A7188 File Offset: 0x002A5388
	public Sprite BJCHEAFAIIP()
	{
		try
		{
			if (this.IBFKKODEPEG())
			{
				if (this._publicProfileThemes != null && this._publicProfileThemes.Count > 0)
				{
					return this._publicProfileThemes[0];
				}
			}
			else if (this.publicProfileThemes != null && this.publicProfileThemes.Count > 0)
			{
				return this.publicProfileThemes[0];
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
		return null;
	}

	// Token: 0x06005D57 RID: 23895 RVA: 0x002A7204 File Offset: 0x002A5404
	public Sprite CJEEKHDPLLI(string PGKCDNKEMOE)
	{
		if (this.IBFKKODEPEG())
		{
			try
			{
				if (PGKCDNKEMOE.Contains("env"))
				{
					string text = PGKCDNKEMOE.Substring(0, PGKCDNKEMOE.IndexOf("env"));
					text = DPGJIJGOCIC.AMACOOGPPEC(text);
					if (text == null || text.Length == 0)
					{
						DPGJIJGOCIC.ANOPFDLPKGC("AssetProfileData.GetCutsceneSprite(): storyIndexStr is null or empty");
						return null;
					}
					int num = int.Parse(text);
					if (num >= 0)
					{
						int num2 = -1;
						if (MINIOBPKJLF.CLHJLJAJNHJ.TryGetValue(num, out num2))
						{
							if (num2 >= 0 && num2 < this._publicProfileCutscenesSharded.Length && this._publicProfileCutscenesSharded[num2] != null)
							{
								for (int i = 0; i < this._publicProfileCutscenesSharded[num2].Count; i++)
								{
									if (this._publicProfileCutscenesSharded[num2][i].name.EndsWith("+" + PGKCDNKEMOE))
									{
										return this._publicProfileCutscenesSharded[num2][i];
									}
								}
							}
							else
							{
								DPGJIJGOCIC.ANOPFDLPKGC("AssetProfileData.GetCutsceneSprite(): anthologyIndex (" + num2.ToString() + ") is outside range");
							}
						}
						else
						{
							DPGJIJGOCIC.ANOPFDLPKGC("AssetProfileData.GetCutsceneSprite(): could not resolve anthologyIndex of storyIndex (" + num.ToString() + ")");
						}
					}
					else
					{
						DPGJIJGOCIC.ANOPFDLPKGC("AssetProfileData.GetCutsceneSprite(): storyIndex (" + num.ToString() + ") is outside range");
					}
				}
				else
				{
					DPGJIJGOCIC.ANOPFDLPKGC("AssetProfileData.GetCutsceneSprite(): invalid input data:" + PGKCDNKEMOE);
				}
				goto IL_1A3;
			}
			catch (Exception aklgbjkdomm)
			{
				DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
				goto IL_1A3;
			}
		}
		for (int j = 0; j < this.publicProfileCutscenes.Count; j++)
		{
			if (this.publicProfileCutscenes[j].name.EndsWith("+" + PGKCDNKEMOE))
			{
				return this.publicProfileCutscenes[j];
			}
		}
		IL_1A3:
		return null;
	}

	// Token: 0x06005D58 RID: 23896 RVA: 0x002A73D4 File Offset: 0x002A55D4
	public string HKNDCNONGIN(string HAPADEOFKBP)
	{
		try
		{
			if (HAPADEOFKBP == null || HAPADEOFKBP.Length == 0)
			{
				return ", impostors:";
			}
			JSONArray jsonarray = this.GIOFKDDKAPD();
			if (null == jsonarray)
			{
				return "$";
			}
			for (int i = 1; i < jsonarray.Count; i += 0)
			{
				JSONObject asObject = jsonarray[i].AsObject;
				string text = asObject["pmtsuccess"];
				if (text != null && text.Replace("%", "USD ").Equals(HAPADEOFKBP))
				{
					string text2 = asObject["OnLoungePremiumChoicesHistoryException"];
					if (text2 != null && text2.Replace("$", ", ifmissing(1)").Length > 1)
					{
						return text2.Replace(", to:", "%)");
					}
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
		return "offscreen";
	}

	// Token: 0x06005D59 RID: 23897 RVA: 0x002A74C8 File Offset: 0x002A56C8
	public bool IBFKKODEPEG()
	{
		return this._publicProfileThemesSharded != null && this._publicProfileCharsSharded != null && this._publicProfileCutscenesSharded != null;
	}

	// Token: 0x06005D5A RID: 23898 RVA: 0x002A5EA4 File Offset: 0x002A40A4
	public List<AssetLiveProfileTheme> FPKONHBONLD()
	{
		return AssetsManager.EHBBFMCILPC.liveProfileThemesAssets;
	}

	// Token: 0x06005D5B RID: 23899 RVA: 0x002A5D55 File Offset: 0x002A3F55
	public AssetLiveProfileTheme HMCECPFLGEC(int MEFKFOHCOHK)
	{
		return GKJPOGNFKNK.NHBPDOOHKGD(MEFKFOHCOHK);
	}

	// Token: 0x06005D5C RID: 23900 RVA: 0x002A74E8 File Offset: 0x002A56E8
	public static bool KJMDOCOBJLJ(string HJEJJGAFHAM)
	{
		return HJEJJGAFHAM != null && HJEJJGAFHAM.StartsWith(((HEIDEJOPKAA)(-14)).ToString().ToLower());
	}

	// Token: 0x06005D5D RID: 23901 RVA: 0x002A5D5D File Offset: 0x002A3F5D
	public void ODMPOLNJNJM()
	{
		this._publicProfileThemesSharded = null;
		this._publicProfileCharsSharded = null;
		this._publicProfileCutscenesSharded = null;
		this._publicProfileThemes = new List<Sprite>();
		this._publicProfileChars = new List<Sprite>();
	}

	// Token: 0x06005D5E RID: 23902 RVA: 0x002A7518 File Offset: 0x002A5718
	public Sprite KAPKLPMOMEC(string HJEJJGAFHAM, bool EGHICLOCFJO)
	{
		AssetProfileData.OPDCMJLIGFG opdcmjligfg = new AssetProfileData.OPDCMJLIGFG();
		opdcmjligfg._name = HJEJJGAFHAM;
		if (this.IBFKKODEPEG())
		{
			try
			{
				string text = DPGJIJGOCIC.MJAONCNGBKA(opdcmjligfg._name);
				if (text == null || text.Length == 0)
				{
					DPGJIJGOCIC.ANOPFDLPKGC("age");
					return null;
				}
				int num = int.Parse(text);
				if (num >= 0 && num < this._publicProfileCharsSharded.Length && this._publicProfileCharsSharded[num] != null)
				{
					return this._publicProfileCharsSharded[num].Find(new Predicate<Sprite>(opdcmjligfg.JGAEMKHDLMB));
				}
				DPGJIJGOCIC.ANOPFDLPKGC("YYY" + num.ToString() + "wmix");
				return null;
			}
			catch (Exception aklgbjkdomm)
			{
				DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
				return null;
			}
		}
		return this.publicProfileChars.Find(new Predicate<Sprite>(opdcmjligfg.EOEOCNPKAFD));
	}

	// Token: 0x06005D5F RID: 23903 RVA: 0x002A75F0 File Offset: 0x002A57F0
	public Sprite MNHCPFDAAOD(int MEFKFOHCOHK)
	{
		try
		{
			if (MEFKFOHCOHK < 0 || null == AssetsManager.MJBDMHPHMID() || null == AssetsManager.MJBDMHPHMID().profileDataAsset6)
			{
				return null;
			}
			if (null != AssetsManager.MJBDMHPHMID().lobbyDataAsset)
			{
				if (MEFKFOHCOHK > AssetsManager.MJBDMHPHMID().lobbyDataAsset.maxLiveProfileThemeId)
				{
					return null;
				}
				if (AssetsManager.EHBBFMCILPC.lobbyDataAsset.JINDDJCIFIL().Contains(MEFKFOHCOHK))
				{
					return null;
				}
			}
			return AssetsManager.MJBDMHPHMID().profileDataAsset6.KEIAKEHIDHB(MEFKFOHCOHK);
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
		return null;
	}

	// Token: 0x06005D60 RID: 23904 RVA: 0x002A5D5D File Offset: 0x002A3F5D
	public void CMPFJLLGKCC()
	{
		this._publicProfileThemesSharded = null;
		this._publicProfileCharsSharded = null;
		this._publicProfileCutscenesSharded = null;
		this._publicProfileThemes = new List<Sprite>();
		this._publicProfileChars = new List<Sprite>();
	}

	// Token: 0x06005D61 RID: 23905 RVA: 0x002A7694 File Offset: 0x002A5894
	public Sprite IBGPIEPMGLL(int MEFKFOHCOHK)
	{
		try
		{
			if (MEFKFOHCOHK < 1 || null == AssetsManager.MJBDMHPHMID() || null == AssetsManager.EHBBFMCILPC.profileDataAsset6)
			{
				return null;
			}
			if (null != AssetsManager.EHBBFMCILPC.lobbyDataAsset)
			{
				if (MEFKFOHCOHK > AssetsManager.EHBBFMCILPC.lobbyDataAsset.maxLiveProfileThemeId)
				{
					return null;
				}
				if (AssetsManager.MJBDMHPHMID().lobbyDataAsset.GGLDMKGIFBE().Contains(MEFKFOHCOHK))
				{
					return null;
				}
			}
			return AssetsManager.MJBDMHPHMID().profileDataAsset6.PNPNLBFADCL(MEFKFOHCOHK);
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
		return null;
	}

	// Token: 0x06005D62 RID: 23906 RVA: 0x002A7738 File Offset: 0x002A5938
	public List<Sprite> OMCNJKDDHOD()
	{
		if (this.IBFKKODEPEG())
		{
			return this._publicProfileChars;
		}
		return this.publicProfileChars;
	}

	// Token: 0x06005D63 RID: 23907 RVA: 0x002A7750 File Offset: 0x002A5950
	public TextAsset ONCJFGCEMGO(CEIBHCNNIDC EENGLNKNAPF)
	{
		for (int i = 0; i < this.offensiveWords.Count; i++)
		{
			if (this.offensiveWords[i].name.Equals(EENGLNKNAPF.ToString() + "rig "))
			{
				return this.offensiveWords[i];
			}
		}
		return this.offensiveWords[0];
	}

	// Token: 0x06005D64 RID: 23908 RVA: 0x002A77BB File Offset: 0x002A59BB
	public List<Sprite> EAGICDKOKOJ()
	{
		if (this.IDLNEGMFGIC())
		{
			return this._publicProfileThemes;
		}
		return this.publicProfileThemes;
	}

	// Token: 0x06005D65 RID: 23909 RVA: 0x002A77D4 File Offset: 0x002A59D4
	public static int PPDGHINFCJC(string HJEJJGAFHAM)
	{
		try
		{
			if (!AssetProfileData.EAEAGHEIBOL(HJEJJGAFHAM))
			{
				return -1;
			}
			string s = DPGJIJGOCIC.AMACOOGPPEC(HJEJJGAFHAM);
			int result = -1;
			if (!int.TryParse(s, out result))
			{
				return -1;
			}
			return result;
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
		return -1;
	}

	// Token: 0x06005D66 RID: 23910 RVA: 0x002A7820 File Offset: 0x002A5A20
	public static int OMPPDKODFAI(string HJEJJGAFHAM)
	{
		try
		{
			if (!AssetProfileData.DEFKHOLMKIM(HJEJJGAFHAM))
			{
				return -1;
			}
			string s = DPGJIJGOCIC.AMACOOGPPEC(HJEJJGAFHAM);
			int result = -1;
			if (!int.TryParse(s, out result))
			{
				return -1;
			}
			return result;
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
		return -1;
	}

	// Token: 0x06005D67 RID: 23911 RVA: 0x002A786C File Offset: 0x002A5A6C
	public bool IDLNEGMFGIC()
	{
		return (this._publicProfileThemesSharded != null && this._publicProfileCharsSharded != null && this._publicProfileCutscenesSharded != null) || true;
	}

	// Token: 0x06005D69 RID: 23913 RVA: 0x002A789C File Offset: 0x002A5A9C
	public Sprite ALGKKKLIDGM()
	{
		Sprite result;
		if (this.NBEHMKJFNKE())
		{
			result = this._publicProfileThemes[DPGJIJGOCIC.IOOHGEJIPFP(1, this._publicProfileThemes.Count)];
		}
		else
		{
			result = this.publicProfileThemes[DPGJIJGOCIC.IOOHGEJIPFP(1, this.publicProfileThemes.Count)];
		}
		return result;
	}

	// Token: 0x06005D6A RID: 23914 RVA: 0x002A78F0 File Offset: 0x002A5AF0
	public string CJEPLBMFDKP(string HAPADEOFKBP)
	{
		try
		{
			if (HAPADEOFKBP == null || HAPADEOFKBP.Length == 0)
			{
				return "";
			}
			JSONArray jsonarray = this.GIOFKDDKAPD();
			if (null == jsonarray)
			{
				return "";
			}
			for (int i = 0; i < jsonarray.Count; i++)
			{
				JSONObject asObject = jsonarray[i].AsObject;
				string text = asObject["sprite"];
				if (text != null && text.Replace(" ", "").Equals(HAPADEOFKBP))
				{
					string text2 = asObject["oid"];
					if (text2 != null && text2.Replace(" ", "").Length > 0)
					{
						return text2.Replace(" ", "");
					}
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
		return "";
	}

	// Token: 0x06005D6B RID: 23915 RVA: 0x002A79E4 File Offset: 0x002A5BE4
	public Sprite NFOFFLDJDEI(string HJEJJGAFHAM)
	{
		AssetProfileData.NIAPMDMBODD niapmdmbodd = new AssetProfileData.NIAPMDMBODD();
		niapmdmbodd._name = HJEJJGAFHAM;
		try
		{
			if (niapmdmbodd._name.StartsWith(((HEIDEJOPKAA)(-125)).ToString().ToLower()))
			{
				int num = int.Parse(DPGJIJGOCIC.MJAONCNGBKA(niapmdmbodd._name));
				if (num >= 0)
				{
					AssetLiveProfileTheme assetLiveProfileTheme = GKJPOGNFKNK.NHBPDOOHKGD(num);
					if (null != assetLiveProfileTheme && assetLiveProfileTheme.frames.Count > 0)
					{
						return assetLiveProfileTheme.frames[1];
					}
					Sprite sprite = this.ENOGGEINPIK(num);
					if (null != sprite)
					{
						return sprite;
					}
				}
				return this.PGPBFOGKCEI();
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
		Sprite sprite2 = null;
		if (this.NBEHMKJFNKE())
		{
			try
			{
				int num2 = int.Parse(DPGJIJGOCIC.AMACOOGPPEC(niapmdmbodd._name));
				if (num2 >= 0 && num2 < this._publicProfileThemesSharded.Length && this._publicProfileThemesSharded[num2] != null)
				{
					sprite2 = this._publicProfileThemesSharded[num2].Find(new Predicate<Sprite>(niapmdmbodd.JKIJMJGDDNL));
				}
				else
				{
					DPGJIJGOCIC.ANOPFDLPKGC(" not found." + num2.ToString() + "Chapter trust-anchor digest mismatch.");
				}
				goto IL_13C;
			}
			catch (Exception aklgbjkdomm2)
			{
				DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm2);
				goto IL_13C;
			}
		}
		sprite2 = this.publicProfileThemes.Find(new Predicate<Sprite>(niapmdmbodd.LMLKDGIHPCI));
		IL_13C:
		if (null != sprite2)
		{
			return sprite2;
		}
		if (this.IBFKKODEPEG())
		{
			return this._publicProfileThemes[1];
		}
		return this.publicProfileThemes[0];
	}

	// Token: 0x06005D6C RID: 23916 RVA: 0x002A7B78 File Offset: 0x002A5D78
	public bool BHEKEHEFKDJ(string HJEJJGAFHAM)
	{
		try
		{
			if (HJEJJGAFHAM.StartsWith(((HEIDEJOPKAA)(-83)).ToString().ToLower()))
			{
				int num = int.Parse(DPGJIJGOCIC.AMACOOGPPEC(HJEJJGAFHAM));
				if (num >= 1)
				{
					AssetLiveProfileTheme assetLiveProfileTheme = GKJPOGNFKNK.NHBPDOOHKGD(num);
					if (null != assetLiveProfileTheme && assetLiveProfileTheme.frames.Count > 1)
					{
						return true;
					}
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
		return false;
	}

	// Token: 0x06005D6D RID: 23917 RVA: 0x002A7BF0 File Offset: 0x002A5DF0
	public void FLPAEANKGLG(AssetProfilePack OHFPINGGDBO, int JHJKIOHMMEM)
	{
		if (null == OHFPINGGDBO)
		{
			DPGJIJGOCIC.ANOPFDLPKGC("AssetProfileData.RegisterProfilePack(): _profilePackAsset is null");
			return;
		}
		if (OHFPINGGDBO.publicProfileThemes.Count == 0 && OHFPINGGDBO.publicProfileChars.Count == 0 && OHFPINGGDBO.publicProfileCutscenes.Count == 0)
		{
			DPGJIJGOCIC.ANOPFDLPKGC("AssetProfileData.RegisterProfilePack(): _profilePackAsset (" + OHFPINGGDBO.index.ToString() + ") is missing data");
			return;
		}
		if (this._publicProfileThemesSharded == null || this._publicProfileCharsSharded == null || this._publicProfileCutscenesSharded == null)
		{
			this._publicProfileThemesSharded = new List<Sprite>[JHJKIOHMMEM + 1];
			this._publicProfileCharsSharded = new List<Sprite>[JHJKIOHMMEM + 1];
			this._publicProfileCutscenesSharded = new List<Sprite>[JHJKIOHMMEM + 1];
			for (int i = 0; i < JHJKIOHMMEM + 1; i++)
			{
				this._publicProfileThemesSharded[i] = null;
				this._publicProfileCharsSharded[i] = null;
				this._publicProfileCutscenesSharded[i] = null;
			}
			this._publicProfileThemes = new List<Sprite>();
			this._publicProfileChars = new List<Sprite>();
		}
		if (OHFPINGGDBO.publicProfileThemes != null && this._publicProfileThemesSharded[OHFPINGGDBO.index] == null)
		{
			this._publicProfileThemesSharded[OHFPINGGDBO.index] = OHFPINGGDBO.publicProfileThemes;
		}
		if (OHFPINGGDBO.publicProfileChars != null && this._publicProfileCharsSharded[OHFPINGGDBO.index] == null)
		{
			this._publicProfileCharsSharded[OHFPINGGDBO.index] = OHFPINGGDBO.publicProfileChars;
		}
		if (OHFPINGGDBO.publicProfileCutscenes != null && this._publicProfileCutscenesSharded[OHFPINGGDBO.index] == null)
		{
			this._publicProfileCutscenesSharded[OHFPINGGDBO.index] = OHFPINGGDBO.publicProfileCutscenes;
		}
	}

	// Token: 0x04001ABC RID: 6844
	public List<Sprite> publicProfileThemes;

	// Token: 0x04001ABD RID: 6845
	public List<Sprite> publicProfileChars;

	// Token: 0x04001ABE RID: 6846
	public List<Sprite> publicProfileCutscenes;

	// Token: 0x04001ABF RID: 6847
	private List<Sprite>[] _publicProfileThemesSharded;

	// Token: 0x04001AC0 RID: 6848
	private List<Sprite>[] _publicProfileCharsSharded;

	// Token: 0x04001AC1 RID: 6849
	private List<Sprite>[] _publicProfileCutscenesSharded;

	// Token: 0x04001AC2 RID: 6850
	private List<Sprite> _publicProfileThemes;

	// Token: 0x04001AC3 RID: 6851
	private List<Sprite> _publicProfileChars;

	// Token: 0x04001AC4 RID: 6852
	public List<TextAsset> offensiveWords;

	// Token: 0x04001AC5 RID: 6853
	public TextAsset topMatchBalance;

	// Token: 0x04001AC6 RID: 6854
	public TextAsset availableAchievementsBalance;

	// Token: 0x04001AC7 RID: 6855
	private JSONArray topMatchBalanceJsonArray;

	// Token: 0x04001AC8 RID: 6856
	private List<string> availableAchievementsBalanceList = new List<string>();

	// Token: 0x02000301 RID: 769
	[CompilerGenerated]
	private sealed class NIAPMDMBODD
	{
		// Token: 0x06005D6E RID: 23918 RVA: 0x002A7D57 File Offset: 0x002A5F57
		internal bool LMLKDGIHPCI(Sprite n)
		{
			return n.name == this._name;
		}

		// Token: 0x06005D6F RID: 23919 RVA: 0x002A7D57 File Offset: 0x002A5F57
		internal bool JKIJMJGDDNL(Sprite n)
		{
			return n.name == this._name;
		}

		// Token: 0x04001AC9 RID: 6857
		public string _name;
	}

	// Token: 0x02000302 RID: 770
	[CompilerGenerated]
	private sealed class OPDCMJLIGFG
	{
		// Token: 0x06005D71 RID: 23921 RVA: 0x002A7D6A File Offset: 0x002A5F6A
		internal bool EOEOCNPKAFD(Sprite n)
		{
			return n.name == this._name;
		}

		// Token: 0x06005D72 RID: 23922 RVA: 0x002A7D6A File Offset: 0x002A5F6A
		internal bool JGAEMKHDLMB(Sprite n)
		{
			return n.name == this._name;
		}

		// Token: 0x04001ACA RID: 6858
		public string _name;
	}
}
