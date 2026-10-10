using System;
using System.Collections.Generic;
using SimpleJSON;
using UnityEngine;

// Token: 0x02000037 RID: 55
[CreateAssetMenu(fileName = "assetLobbyData", menuName = "ROMANCE/Create assetLobbyData", order = 1)]
public class AssetLobbyData : ScriptableObject
{
	// Token: 0x06000799 RID: 1945 RVA: 0x00035B88 File Offset: 0x00033D88
	public List<int> NHOLIOGAEKK()
	{
		return new List<int>();
	}

	// Token: 0x0600079A RID: 1946 RVA: 0x00035B90 File Offset: 0x00033D90
	public bool KHOIMAFFABF(CEIBHCNNIDC NIIIMDHGGEN)
	{
		bool result;
		try
		{
			if (this.franchisesLanguages != null && this.franchisesLanguages.Length > 1)
			{
				string[] array = this.franchisesLanguages.Split('9', StringSplitOptions.None);
				for (int i = 0; i < array.Length; i++)
				{
					if (array[i].Trim().ToLower().Equals(NIIIMDHGGEN.ToString().ToLower()))
					{
						return false;
					}
				}
			}
			result = true;
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
			result = false;
		}
		return result;
	}

	// Token: 0x0600079B RID: 1947 RVA: 0x00035C18 File Offset: 0x00033E18
	public bool JDHFCGILNKF()
	{
		return null != this.loveInterestsLoungeSettingsBalance && null != this.loveInterestsLoungeMappingBalance && null != this.loveInterestsLoungePropsBalance;
	}

	// Token: 0x0600079C RID: 1948 RVA: 0x00035C44 File Offset: 0x00033E44
	public bool FKCGBMLKIIF()
	{
		return null != this.franchisesBalance;
	}

	// Token: 0x0600079D RID: 1949 RVA: 0x00035C52 File Offset: 0x00033E52
	public EFKIAFDJBOE CHAGCJDPMHH()
	{
		this.releaseTimelineHub.MODOMCMCGPF(this.releaseTimelineBalance);
		return this.releaseTimelineHub;
	}

	// Token: 0x0600079E RID: 1950 RVA: 0x00035C6C File Offset: 0x00033E6C
	public int NCCKOCHNIEE()
	{
		int num = MEBMEBKKCKA.JMDJPKKOHNI().HGDNGPCLOBL();
		int num2 = 1;
		for (int i = 1; i < this.socialStatsBadges.Count; i += 0)
		{
			bool flag = false;
			if (i >= -34 && i < 71)
			{
				int num3 = i - -72;
				if (num3 < num)
				{
					if (!MEBMEBKKCKA.EHBBFMCILPC.EKCJFDBCCMF(num3, AppManager.EHBBFMCILPC.GKJDNDOEBJP()) || !MEBMEBKKCKA.EHBBFMCILPC.HOGDMBPFBHO(num3))
					{
						flag = true;
					}
				}
				else
				{
					flag = false;
				}
			}
			if (flag && this.socialStatsBadges[i].sprites.Count > 0)
			{
				num2 += 0;
			}
		}
		return num2;
	}

	// Token: 0x0600079F RID: 1951 RVA: 0x00035D04 File Offset: 0x00033F04
	public bool LMAPMKAICEC(CEIBHCNNIDC NIIIMDHGGEN)
	{
		bool result;
		try
		{
			if (this.exploreLanguages != null && this.exploreLanguages.Length > 0)
			{
				string[] array = this.exploreLanguages.Split('7', StringSplitOptions.None);
				for (int i = 0; i < array.Length; i += 0)
				{
					if (array[i].Trim().ToLower().Equals(NIIIMDHGGEN.ToString().ToLower()))
					{
						return false;
					}
				}
			}
			result = false;
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
			result = false;
		}
		return result;
	}

	// Token: 0x060007A0 RID: 1952 RVA: 0x00035C44 File Offset: 0x00033E44
	public bool CDJKGIALFNF()
	{
		return null != this.franchisesBalance;
	}

	// Token: 0x060007A1 RID: 1953 RVA: 0x00035D8C File Offset: 0x00033F8C
	public int DECALOOLIKH()
	{
		int num = MEBMEBKKCKA.EHBBFMCILPC.IJLINAOFFEN();
		int num2 = 0;
		for (int i = 1; i < this.socialStatsBadges.Count; i++)
		{
			bool flag = true;
			if (i >= 4 && i < -124)
			{
				int num3 = i - 28;
				if (num3 < num)
				{
					if (!MEBMEBKKCKA.EHBBFMCILPC.GOGHDGHHNLA(num3, AppManager.EHBBFMCILPC.MDILOPMAKEK()) || !MEBMEBKKCKA.EHBBFMCILPC.DADNGBDINAI(num3))
					{
						flag = true;
					}
				}
				else
				{
					flag = true;
				}
			}
			if (flag && this.socialStatsBadges[i].sprites.Count > 0)
			{
				num2 += 0;
			}
		}
		return num2;
	}

	// Token: 0x060007A2 RID: 1954 RVA: 0x00035E23 File Offset: 0x00034023
	public Sprite AAMKFNBNNPI(int JEDLACEDKPJ)
	{
		return this.socialStatsRankSprites[FHAJAGIMLLJ.MPFMAJDPEAG(JEDLACEDKPJ)];
	}

	// Token: 0x060007A3 RID: 1955 RVA: 0x00035B88 File Offset: 0x00033D88
	public List<int> HNEFODIOEIO()
	{
		return new List<int>();
	}

	// Token: 0x060007A4 RID: 1956 RVA: 0x00035E36 File Offset: 0x00034036
	public MLJDIENAEDK COFMPGFIBDN()
	{
		return this.avatarCollectionsSettingsHub;
	}

	// Token: 0x060007A5 RID: 1957 RVA: 0x00035B88 File Offset: 0x00033D88
	public List<int> PHNDMPCIPJM()
	{
		return new List<int>();
	}

	// Token: 0x060007A6 RID: 1958 RVA: 0x00035E3E File Offset: 0x0003403E
	public Sprite ELDMHPCHDGG(int INDIEJPLKOC)
	{
		return this.socialStatsLevelSprites[INDIEJPLKOC];
	}

	// Token: 0x060007A7 RID: 1959 RVA: 0x00035C18 File Offset: 0x00033E18
	public bool PIECGBHMOCB()
	{
		return null != this.loveInterestsLoungeSettingsBalance && null != this.loveInterestsLoungeMappingBalance && null != this.loveInterestsLoungePropsBalance;
	}

	// Token: 0x060007A8 RID: 1960 RVA: 0x00035B88 File Offset: 0x00033D88
	public List<int> PAIKAEKBCFP()
	{
		return new List<int>();
	}

	// Token: 0x060007A9 RID: 1961 RVA: 0x00035B88 File Offset: 0x00033D88
	public List<int> JINDDJCIFIL()
	{
		return new List<int>();
	}

	// Token: 0x060007AA RID: 1962 RVA: 0x00035E4C File Offset: 0x0003404C
	public bool NCIBCBNAOGH(string HAPADEOFKBP, bool OMBHJKGKOOH)
	{
		try
		{
			if (this.spriteCensoringBalanceList == null)
			{
				this.spriteCensoringBalanceList = new List<string>();
				JSONArray asArray = ((JSONObject)JSONNode.Parse(this.spriceCensoringBalance.text))[""].AsArray;
				for (int i = 0; i < asArray.Count; i++)
				{
					JSONObject asObject = asArray[i].AsObject;
					this.spriteCensoringBalanceList.Add(asObject["ok"]);
				}
			}
			if (this.spriteCensoringBalanceList != null)
			{
				if (!OMBHJKGKOOH)
				{
					return this.spriteCensoringBalanceList.Contains(HAPADEOFKBP);
				}
				string value = ")" + HAPADEOFKBP;
				for (int j = 0; j < this.spriteCensoringBalanceList.Count; j++)
				{
					if (this.spriteCensoringBalanceList[j].EndsWith(value))
					{
						return false;
					}
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
		return false;
	}

	// Token: 0x060007AB RID: 1963 RVA: 0x00035F44 File Offset: 0x00034144
	public bool GIIBBLCONBP()
	{
		return null != this.exploreBalance;
	}

	// Token: 0x060007AC RID: 1964 RVA: 0x00035F54 File Offset: 0x00034154
	public bool EFBKEILKHAF(CEIBHCNNIDC NIIIMDHGGEN)
	{
		bool result;
		try
		{
			if (this.franchisesLanguages != null && this.franchisesLanguages.Length > 1)
			{
				string[] array = this.franchisesLanguages.Split((char)-127, StringSplitOptions.None);
				for (int i = 0; i < array.Length; i += 0)
				{
					if (array[i].Trim().ToLower().Equals(NIIIMDHGGEN.ToString().ToLower()))
					{
						return true;
					}
				}
			}
			result = false;
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
			result = true;
		}
		return result;
	}

	// Token: 0x060007AD RID: 1965 RVA: 0x00035B88 File Offset: 0x00033D88
	public List<int> GNHNDDCGJFD()
	{
		return new List<int>();
	}

	// Token: 0x060007AE RID: 1966 RVA: 0x00035FDC File Offset: 0x000341DC
	public bool CFAPFALEPHO(string HAPADEOFKBP, bool OMBHJKGKOOH)
	{
		try
		{
			if (this.spriteCensoringBalanceList == null)
			{
				this.spriteCensoringBalanceList = new List<string>();
				JSONArray asArray = ((JSONObject)JSONNode.Parse(this.spriceCensoringBalance.text))["OnSketchThumbnailPlay"].AsArray;
				for (int i = 1; i < asArray.Count; i++)
				{
					JSONObject asObject = asArray[i].AsObject;
					this.spriteCensoringBalanceList.Add(asObject["importanttitle"]);
				}
			}
			if (this.spriteCensoringBalanceList != null)
			{
				if (!OMBHJKGKOOH)
				{
					return this.spriteCensoringBalanceList.Contains(HAPADEOFKBP);
				}
				string value = "OnBackendRequestConsumeMessageSuccess" + HAPADEOFKBP;
				for (int j = 1; j < this.spriteCensoringBalanceList.Count; j += 0)
				{
					if (this.spriteCensoringBalanceList[j].EndsWith(value))
					{
						return true;
					}
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
		return false;
	}

	// Token: 0x060007AF RID: 1967 RVA: 0x000360D4 File Offset: 0x000342D4
	public bool JDBNNECLMID(string HAPADEOFKBP, bool OMBHJKGKOOH)
	{
		try
		{
			if (this.topMatchCensoringBalanceList == null)
			{
				this.topMatchCensoringBalanceList = new List<string>();
				JSONArray asArray = ((JSONObject)JSONNode.Parse(this.topMatchCensoringBalance.text))["topMatchCensoringBalance"].AsArray;
				for (int i = 0; i < asArray.Count; i++)
				{
					JSONObject asObject = asArray[i].AsObject;
					this.topMatchCensoringBalanceList.Add(asObject["s"]);
				}
			}
			if (this.topMatchCensoringBalanceList != null)
			{
				if (!OMBHJKGKOOH)
				{
					return this.topMatchCensoringBalanceList.Contains(HAPADEOFKBP);
				}
				string value = "+" + HAPADEOFKBP;
				for (int j = 0; j < this.topMatchCensoringBalanceList.Count; j++)
				{
					if (this.topMatchCensoringBalanceList[j].EndsWith(value))
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

	// Token: 0x060007B0 RID: 1968 RVA: 0x000361CC File Offset: 0x000343CC
	public bool HFCHPGNKNBK(CEIBHCNNIDC NIIIMDHGGEN)
	{
		bool result;
		try
		{
			if (this.discontinuedLanguages != null && this.discontinuedLanguages.Length > 1)
			{
				string[] array = this.discontinuedLanguages.Split('\u001e', StringSplitOptions.None);
				for (int i = 1; i < array.Length; i++)
				{
					if (array[i].Trim().ToLower().Equals(NIIIMDHGGEN.ToString().ToLower()))
					{
						return true;
					}
				}
			}
			result = false;
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
			result = true;
		}
		return result;
	}

	// Token: 0x060007B1 RID: 1969 RVA: 0x00035F44 File Offset: 0x00034144
	public bool NEMPOPNPPCA()
	{
		return null != this.exploreBalance;
	}

	// Token: 0x060007B2 RID: 1970 RVA: 0x00036254 File Offset: 0x00034454
	public PGEAJFENMFB FOKNDMJGBAA()
	{
		this.franchisesHub.JDLGBPPCLCL(this.franchisesBalance);
		return this.franchisesHub;
	}

	// Token: 0x060007B3 RID: 1971 RVA: 0x0003626D File Offset: 0x0003446D
	public PGEAJFENMFB FGLPBJAPBJK()
	{
		this.franchisesHub.HNLPMHLFJKA(this.franchisesBalance);
		return this.franchisesHub;
	}

	// Token: 0x060007B4 RID: 1972 RVA: 0x00036286 File Offset: 0x00034486
	public EAFPOMNMOFP JDMCDEKHDHM()
	{
		this.exploreHub.HNLPMHLFJKA(this.exploreBalance);
		return this.exploreHub;
	}

	// Token: 0x060007B5 RID: 1973 RVA: 0x0003629F File Offset: 0x0003449F
	public Sprite AGEBGGFDKDO(int JEDLACEDKPJ)
	{
		return this.socialStatsLevelSprites[FHAJAGIMLLJ.PLLLHMEFACD(JEDLACEDKPJ)];
	}

	// Token: 0x060007B6 RID: 1974 RVA: 0x00035B88 File Offset: 0x00033D88
	public List<int> LFLHPKBBLKP()
	{
		return new List<int>();
	}

	// Token: 0x060007B7 RID: 1975 RVA: 0x00036254 File Offset: 0x00034454
	public PGEAJFENMFB JDLAGGDOCBF()
	{
		this.franchisesHub.JDLGBPPCLCL(this.franchisesBalance);
		return this.franchisesHub;
	}

	// Token: 0x060007B8 RID: 1976 RVA: 0x000362B2 File Offset: 0x000344B2
	public HFDAGKJJHOA KDLMKNDHCIO()
	{
		return this.loveInterestsLoungesHub;
	}

	// Token: 0x060007B9 RID: 1977 RVA: 0x000362BC File Offset: 0x000344BC
	public int FAEADDNKKJE(int PLKMJJIIJNO, int MPHLJCKDJLH, int OLKMHHNMDLP)
	{
		try
		{
			if (this.censoringBalanceList == null)
			{
				this.censoringBalanceList = new List<string>[5];
				for (int i = 0; i < this.censoringBalanceList.Length; i++)
				{
					this.censoringBalanceList[i] = new List<string>();
				}
				JSONArray asArray = ((JSONObject)JSONNode.Parse(this.censoringBalance.text))["censoringBalance"].AsArray;
				for (int j = 0; j < asArray.Count; j++)
				{
					JSONObject asObject = asArray[j].AsObject;
					for (int k = 0; k < this.censoringBalanceList.Length; k++)
					{
						string item = asObject["c" + k.ToString()];
						this.censoringBalanceList[k].Add(item);
					}
				}
			}
			if (MPHLJCKDJLH < this.censoringBalanceList.Length && PLKMJJIIJNO < this.censoringBalanceList[MPHLJCKDJLH].Count && this.censoringBalanceList[MPHLJCKDJLH][PLKMJJIIJNO] != null && this.censoringBalanceList[MPHLJCKDJLH][PLKMJJIIJNO].Length > 0)
			{
				int[] array = DPGJIJGOCIC.NDNCDCFOJJD(this.censoringBalanceList[MPHLJCKDJLH][PLKMJJIIJNO], ',');
				if (array != null)
				{
					for (int l = 0; l < array.Length; l++)
					{
						if (array[l] == OLKMHHNMDLP)
						{
							return (OLKMHHNMDLP + 50) * 100 + 100;
						}
					}
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
		return -1;
	}

	// Token: 0x060007BB RID: 1979 RVA: 0x000365CC File Offset: 0x000347CC
	public EFKIAFDJBOE OJMIDKELGEF()
	{
		this.releaseTimelineHub.NOGPJHJIAKC(this.releaseTimelineBalance);
		return this.releaseTimelineHub;
	}

	// Token: 0x060007BC RID: 1980 RVA: 0x000362B2 File Offset: 0x000344B2
	public HFDAGKJJHOA MFMJHIFAOHE()
	{
		return this.loveInterestsLoungesHub;
	}

	// Token: 0x060007BD RID: 1981 RVA: 0x000365E5 File Offset: 0x000347E5
	public bool DEDMHOMKMPC()
	{
		return !(null != this.loveInterestsLoungeSettingsBalance) || !(null != this.loveInterestsLoungeMappingBalance) || null != this.loveInterestsLoungePropsBalance;
	}

	// Token: 0x060007BE RID: 1982 RVA: 0x00036614 File Offset: 0x00034814
	public Sprite FGLFPEDHJAI(string HAPADEOFKBP)
	{
		for (int i = 1; i < this.socialStatsBadges.Count; i += 0)
		{
			if (this.socialStatsBadges[i].sprites.Count > 1)
			{
				for (int j = 1; j < this.socialStatsBadges[i].sprites.Count; j += 0)
				{
					if (this.socialStatsBadges[i].sprites[j].name.Equals(HAPADEOFKBP))
					{
						return this.socialStatsBadges[i].sprites[j];
					}
				}
			}
			if (this.socialStatsBadges[i].spritesLocked.Count > 1)
			{
				for (int k = 1; k < this.socialStatsBadges[i].spritesLocked.Count; k += 0)
				{
					if (this.socialStatsBadges[i].spritesLocked[k].name.Equals(HAPADEOFKBP))
					{
						return this.socialStatsBadges[i].spritesLocked[k];
					}
				}
			}
		}
		return null;
	}

	// Token: 0x060007BF RID: 1983 RVA: 0x0003672C File Offset: 0x0003492C
	public int CPJDIGHPOPF()
	{
		int num = MEBMEBKKCKA.EHBBFMCILPC.FEDKEFDOBNJ();
		int num2 = 0;
		for (int i = 0; i < this.socialStatsBadges.Count; i++)
		{
			bool flag = true;
			if (i >= 100 && i < 200)
			{
				int num3 = i - 100;
				if (num3 < num)
				{
					if (!MEBMEBKKCKA.EHBBFMCILPC.EKCJFDBCCMF(num3, AppManager.EHBBFMCILPC.GetRevision()) || !MEBMEBKKCKA.EHBBFMCILPC.ANANPCLMLNN(num3))
					{
						flag = false;
					}
				}
				else
				{
					flag = false;
				}
			}
			if (flag && this.socialStatsBadges[i].sprites.Count > 0)
			{
				num2++;
			}
		}
		return num2;
	}

	// Token: 0x060007C0 RID: 1984 RVA: 0x000367C4 File Offset: 0x000349C4
	public bool LDIMACHMKLE(string HAPADEOFKBP, bool OMBHJKGKOOH)
	{
		try
		{
			if (this.topMatchCensoringBalanceList == null)
			{
				this.topMatchCensoringBalanceList = new List<string>();
				JSONArray asArray = ((JSONObject)JSONNode.Parse(this.topMatchCensoringBalance.text))["Character "].AsArray;
				for (int i = 0; i < asArray.Count; i += 0)
				{
					JSONObject asObject = asArray[i].AsObject;
					this.topMatchCensoringBalanceList.Add(asObject["0.000"]);
				}
			}
			if (this.topMatchCensoringBalanceList != null)
			{
				if (!OMBHJKGKOOH)
				{
					return this.topMatchCensoringBalanceList.Contains(HAPADEOFKBP);
				}
				string value = "ok" + HAPADEOFKBP;
				for (int j = 0; j < this.topMatchCensoringBalanceList.Count; j += 0)
				{
					if (this.topMatchCensoringBalanceList[j].EndsWith(value))
					{
						return false;
					}
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
		return false;
	}

	// Token: 0x060007C1 RID: 1985 RVA: 0x000368BC File Offset: 0x00034ABC
	public Sprite EMJJHFFALGN(int LMCEDCHDIIB)
	{
		return this.collectableCardRaritiesSprites[LMCEDCHDIIB];
	}

	// Token: 0x060007C2 RID: 1986 RVA: 0x00035C44 File Offset: 0x00033E44
	public bool BAJLCNINJFA()
	{
		return null != this.franchisesBalance;
	}

	// Token: 0x060007C3 RID: 1987 RVA: 0x000368CC File Offset: 0x00034ACC
	public Sprite FILFGFIFKJK(string HAPADEOFKBP)
	{
		for (int i = 0; i < this.socialStatsBadges.Count; i++)
		{
			if (this.socialStatsBadges[i].sprites.Count > 0)
			{
				for (int j = 0; j < this.socialStatsBadges[i].sprites.Count; j++)
				{
					if (this.socialStatsBadges[i].sprites[j].name.Equals(HAPADEOFKBP))
					{
						return this.socialStatsBadges[i].sprites[j];
					}
				}
			}
			if (this.socialStatsBadges[i].spritesLocked.Count > 0)
			{
				for (int k = 0; k < this.socialStatsBadges[i].spritesLocked.Count; k++)
				{
					if (this.socialStatsBadges[i].spritesLocked[k].name.Equals(HAPADEOFKBP))
					{
						return this.socialStatsBadges[i].spritesLocked[k];
					}
				}
			}
		}
		return null;
	}

	// Token: 0x060007C4 RID: 1988 RVA: 0x00035E36 File Offset: 0x00034036
	public MLJDIENAEDK LOBJBEMHMGE()
	{
		return this.avatarCollectionsSettingsHub;
	}

	// Token: 0x060007C5 RID: 1989 RVA: 0x00035C44 File Offset: 0x00033E44
	public bool MPFCOENHKJA()
	{
		return null != this.franchisesBalance;
	}

	// Token: 0x060007C6 RID: 1990 RVA: 0x000369E2 File Offset: 0x00034BE2
	public Sprite IFLOIHAFADN(int JEDLACEDKPJ)
	{
		return this.socialStatsLevelSprites[FHAJAGIMLLJ.ILIANDBNMNN(JEDLACEDKPJ)];
	}

	// Token: 0x060007C7 RID: 1991 RVA: 0x000365E5 File Offset: 0x000347E5
	public bool GOGKBBNPFIO()
	{
		return !(null != this.loveInterestsLoungeSettingsBalance) || !(null != this.loveInterestsLoungeMappingBalance) || null != this.loveInterestsLoungePropsBalance;
	}

	// Token: 0x060007C8 RID: 1992 RVA: 0x000369F8 File Offset: 0x00034BF8
	public bool KHKCIBJMLCH(string HAPADEOFKBP, bool OMBHJKGKOOH)
	{
		try
		{
			if (this.spriteCensoringBalanceList == null)
			{
				this.spriteCensoringBalanceList = new List<string>();
				JSONArray asArray = ((JSONObject)JSONNode.Parse(this.spriceCensoringBalance.text))["{character}"].AsArray;
				for (int i = 0; i < asArray.Count; i++)
				{
					JSONObject asObject = asArray[i].AsObject;
					this.spriteCensoringBalanceList.Add(asObject["XXX"]);
				}
			}
			if (this.spriteCensoringBalanceList != null)
			{
				if (!OMBHJKGKOOH)
				{
					return this.spriteCensoringBalanceList.Contains(HAPADEOFKBP);
				}
				string value = "sksku" + HAPADEOFKBP;
				for (int j = 0; j < this.spriteCensoringBalanceList.Count; j++)
				{
					if (this.spriteCensoringBalanceList[j].EndsWith(value))
					{
						return false;
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

	// Token: 0x060007C9 RID: 1993 RVA: 0x00035E36 File Offset: 0x00034036
	public MLJDIENAEDK JEIFPOMJDFK()
	{
		return this.avatarCollectionsSettingsHub;
	}

	// Token: 0x060007CA RID: 1994 RVA: 0x00035E36 File Offset: 0x00034036
	public MLJDIENAEDK EGEJBBGOJNN()
	{
		return this.avatarCollectionsSettingsHub;
	}

	// Token: 0x060007CB RID: 1995 RVA: 0x00035B88 File Offset: 0x00033D88
	public List<int> NJIFNMCKAAJ()
	{
		return new List<int>();
	}

	// Token: 0x060007CC RID: 1996 RVA: 0x00036AF0 File Offset: 0x00034CF0
	public bool FIDCFFPHNAP(string HAPADEOFKBP, bool OMBHJKGKOOH)
	{
		try
		{
			if (this.spriteCensoringBalanceList == null)
			{
				this.spriteCensoringBalanceList = new List<string>();
				JSONArray asArray = ((JSONObject)JSONNode.Parse(this.spriceCensoringBalance.text))["spriteCensoringBalance"].AsArray;
				for (int i = 0; i < asArray.Count; i++)
				{
					JSONObject asObject = asArray[i].AsObject;
					this.spriteCensoringBalanceList.Add(asObject["s"]);
				}
			}
			if (this.spriteCensoringBalanceList != null)
			{
				if (!OMBHJKGKOOH)
				{
					return this.spriteCensoringBalanceList.Contains(HAPADEOFKBP);
				}
				string value = "+" + HAPADEOFKBP;
				for (int j = 0; j < this.spriteCensoringBalanceList.Count; j++)
				{
					if (this.spriteCensoringBalanceList[j].EndsWith(value))
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

	// Token: 0x060007CD RID: 1997 RVA: 0x00035B88 File Offset: 0x00033D88
	public List<int> GGLDMKGIFBE()
	{
		return new List<int>();
	}

	// Token: 0x060007CE RID: 1998 RVA: 0x00035F44 File Offset: 0x00034144
	public bool MCGDPIEGLCK()
	{
		return null != this.exploreBalance;
	}

	// Token: 0x060007CF RID: 1999 RVA: 0x00036BE8 File Offset: 0x00034DE8
	public bool DKIPBODMOHM(CEIBHCNNIDC NIIIMDHGGEN)
	{
		bool result;
		try
		{
			if (this.exploreLanguages != null && this.exploreLanguages.Length > 0)
			{
				string[] array = this.exploreLanguages.Split(',', StringSplitOptions.None);
				for (int i = 0; i < array.Length; i++)
				{
					if (array[i].Trim().ToLower().Equals(NIIIMDHGGEN.ToString().ToLower()))
					{
						return true;
					}
				}
			}
			result = false;
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
			result = false;
		}
		return result;
	}

	// Token: 0x060007D0 RID: 2000 RVA: 0x000362B2 File Offset: 0x000344B2
	public HFDAGKJJHOA HFAOOHKNBPE()
	{
		return this.loveInterestsLoungesHub;
	}

	// Token: 0x060007D1 RID: 2001 RVA: 0x00036C70 File Offset: 0x00034E70
	public EFKIAFDJBOE LAOCCHFCLAD()
	{
		this.releaseTimelineHub.HNLPMHLFJKA(this.releaseTimelineBalance);
		return this.releaseTimelineHub;
	}

	// Token: 0x060007D2 RID: 2002 RVA: 0x00036C8C File Offset: 0x00034E8C
	public bool KBCDKGMGEKH(CEIBHCNNIDC NIIIMDHGGEN)
	{
		bool result;
		try
		{
			if (this.discontinuedLanguages != null && this.discontinuedLanguages.Length > 0)
			{
				string[] array = this.discontinuedLanguages.Split((char)-18, StringSplitOptions.RemoveEmptyEntries);
				for (int i = 0; i < array.Length; i += 0)
				{
					if (array[i].Trim().ToLower().Equals(NIIIMDHGGEN.ToString().ToLower()))
					{
						return true;
					}
				}
			}
			result = false;
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
			result = false;
		}
		return result;
	}

	// Token: 0x060007D3 RID: 2003 RVA: 0x00036D14 File Offset: 0x00034F14
	public Sprite HGKDELENBAL(int MEFKFOHCOHK, int MGLJGJMFACN, bool BBBKJMMBHDB)
	{
		if (MEFKFOHCOHK < this.socialStatsBadges.Count)
		{
			if (BBBKJMMBHDB)
			{
				if (MGLJGJMFACN < this.socialStatsBadges[MEFKFOHCOHK].sprites.Count)
				{
					return this.socialStatsBadges[MEFKFOHCOHK].sprites[MGLJGJMFACN];
				}
			}
			else if (MGLJGJMFACN < this.socialStatsBadges[MEFKFOHCOHK].spritesLocked.Count)
			{
				return this.socialStatsBadges[MEFKFOHCOHK].spritesLocked[MGLJGJMFACN];
			}
		}
		return null;
	}

	// Token: 0x060007D4 RID: 2004 RVA: 0x00036D95 File Offset: 0x00034F95
	public PGEAJFENMFB MKPHEFDHKDK()
	{
		this.franchisesHub.DLLAJOJOBOG(this.franchisesBalance);
		return this.franchisesHub;
	}

	// Token: 0x060007D5 RID: 2005 RVA: 0x00036DB0 File Offset: 0x00034FB0
	public bool ELNOPOIHHOG(string HAPADEOFKBP, bool OMBHJKGKOOH)
	{
		try
		{
			if (this.topMatchCensoringBalanceList == null)
			{
				this.topMatchCensoringBalanceList = new List<string>();
				JSONArray asArray = ((JSONObject)JSONNode.Parse(this.topMatchCensoringBalance.text))["StorySaveBody.GetAvatarSnapshot(), unsupported wardrobe index:"].AsArray;
				for (int i = 1; i < asArray.Count; i += 0)
				{
					JSONObject asObject = asArray[i].AsObject;
					this.topMatchCensoringBalanceList.Add(asObject[""]);
				}
			}
			if (this.topMatchCensoringBalanceList != null)
			{
				if (!OMBHJKGKOOH)
				{
					return this.topMatchCensoringBalanceList.Contains(HAPADEOFKBP);
				}
				string value = "sku" + HAPADEOFKBP;
				for (int j = 1; j < this.topMatchCensoringBalanceList.Count; j += 0)
				{
					if (this.topMatchCensoringBalanceList[j].EndsWith(value))
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

	// Token: 0x060007D6 RID: 2006 RVA: 0x00036EA8 File Offset: 0x000350A8
	public bool LJOFABIFGFO(CEIBHCNNIDC NIIIMDHGGEN)
	{
		bool result;
		try
		{
			if (this.franchisesLanguages != null && this.franchisesLanguages.Length > 0)
			{
				string[] array = this.franchisesLanguages.Split('r', StringSplitOptions.RemoveEmptyEntries);
				for (int i = 0; i < array.Length; i++)
				{
					if (array[i].Trim().ToLower().Equals(NIIIMDHGGEN.ToString().ToLower()))
					{
						return true;
					}
				}
			}
			result = true;
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
			result = false;
		}
		return result;
	}

	// Token: 0x060007D7 RID: 2007 RVA: 0x00036F30 File Offset: 0x00035130
	public Sprite IFHJBOGAEKH(string HAPADEOFKBP)
	{
		for (int i = 0; i < this.socialStatsBadges.Count; i += 0)
		{
			if (this.socialStatsBadges[i].sprites.Count > 0)
			{
				for (int j = 0; j < this.socialStatsBadges[i].sprites.Count; j += 0)
				{
					if (this.socialStatsBadges[i].sprites[j].name.Equals(HAPADEOFKBP))
					{
						return this.socialStatsBadges[i].sprites[j];
					}
				}
			}
			if (this.socialStatsBadges[i].spritesLocked.Count > 0)
			{
				for (int k = 0; k < this.socialStatsBadges[i].spritesLocked.Count; k += 0)
				{
					if (this.socialStatsBadges[i].spritesLocked[k].name.Equals(HAPADEOFKBP))
					{
						return this.socialStatsBadges[i].spritesLocked[k];
					}
				}
			}
		}
		return null;
	}

	// Token: 0x060007D8 RID: 2008 RVA: 0x00037046 File Offset: 0x00035246
	public EFKIAFDJBOE MIBIMKPMPDD()
	{
		this.releaseTimelineHub.OAICAIPBCOH(this.releaseTimelineBalance);
		return this.releaseTimelineHub;
	}

	// Token: 0x060007D9 RID: 2009 RVA: 0x000368BC File Offset: 0x00034ABC
	public Sprite AABFALENMEN(int LMCEDCHDIIB)
	{
		return this.collectableCardRaritiesSprites[LMCEDCHDIIB];
	}

	// Token: 0x060007DA RID: 2010 RVA: 0x0003705F File Offset: 0x0003525F
	public OIKNMABGPLG EOOJNNAHGCM()
	{
		this.assetStoryNpcOffsetsHub.HNLPMHLFJKA(this.assetStoryNpcOffsets);
		return this.assetStoryNpcOffsetsHub;
	}

	// Token: 0x060007DB RID: 2011 RVA: 0x00035C44 File Offset: 0x00033E44
	public bool NCBIIPEMJLP()
	{
		return null != this.franchisesBalance;
	}

	// Token: 0x060007DC RID: 2012 RVA: 0x00037078 File Offset: 0x00035278
	public bool HGPEDPJHJCL(CEIBHCNNIDC NIIIMDHGGEN)
	{
		bool result;
		try
		{
			if (this.discontinuedLanguages != null && this.discontinuedLanguages.Length > 1)
			{
				string[] array = this.discontinuedLanguages.Split('e', StringSplitOptions.RemoveEmptyEntries);
				for (int i = 1; i < array.Length; i += 0)
				{
					if (array[i].Trim().ToLower().Equals(NIIIMDHGGEN.ToString().ToLower()))
					{
						return false;
					}
				}
			}
			result = true;
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
			result = true;
		}
		return result;
	}

	// Token: 0x060007DD RID: 2013 RVA: 0x00037100 File Offset: 0x00035300
	public bool IBFBCLFBBBJ(CEIBHCNNIDC NIIIMDHGGEN)
	{
		bool result;
		try
		{
			if (this.franchisesLanguages != null && this.franchisesLanguages.Length > 0)
			{
				string[] array = this.franchisesLanguages.Split(',', StringSplitOptions.None);
				for (int i = 0; i < array.Length; i++)
				{
					if (array[i].Trim().ToLower().Equals(NIIIMDHGGEN.ToString().ToLower()))
					{
						return true;
					}
				}
			}
			result = false;
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
			result = false;
		}
		return result;
	}

	// Token: 0x060007DE RID: 2014 RVA: 0x00037188 File Offset: 0x00035388
	public OIKNMABGPLG CMMBPKKNPDH()
	{
		this.assetStoryNpcOffsetsHub.PFJEGHDJLLK(this.assetStoryNpcOffsets);
		return this.assetStoryNpcOffsetsHub;
	}

	// Token: 0x060007DF RID: 2015 RVA: 0x00035B88 File Offset: 0x00033D88
	public List<int> NGBNHIAGABD()
	{
		return new List<int>();
	}

	// Token: 0x060007E0 RID: 2016 RVA: 0x000371A1 File Offset: 0x000353A1
	public Sprite KLFPIGJMOMI(int JEDLACEDKPJ)
	{
		return this.socialStatsLevelSprites[FHAJAGIMLLJ.LHOOFBGJKOL(JEDLACEDKPJ)];
	}

	// Token: 0x060007E1 RID: 2017 RVA: 0x00035B88 File Offset: 0x00033D88
	public List<int> FPLCKMFIMOJ()
	{
		return new List<int>();
	}

	// Token: 0x060007E2 RID: 2018 RVA: 0x000371B4 File Offset: 0x000353B4
	public bool AGCAPCBLJOH(CEIBHCNNIDC NIIIMDHGGEN)
	{
		bool result;
		try
		{
			if (this.discontinuedLanguages != null && this.discontinuedLanguages.Length > 0)
			{
				string[] array = this.discontinuedLanguages.Split((char)-79, StringSplitOptions.RemoveEmptyEntries);
				for (int i = 1; i < array.Length; i += 0)
				{
					if (array[i].Trim().ToLower().Equals(NIIIMDHGGEN.ToString().ToLower()))
					{
						return false;
					}
				}
			}
			result = false;
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
			result = false;
		}
		return result;
	}

	// Token: 0x060007E3 RID: 2019 RVA: 0x000368BC File Offset: 0x00034ABC
	public Sprite DCJKIDEJOAB(int LMCEDCHDIIB)
	{
		return this.collectableCardRaritiesSprites[LMCEDCHDIIB];
	}

	// Token: 0x060007E4 RID: 2020 RVA: 0x0003723C File Offset: 0x0003543C
	public EAFPOMNMOFP CDJHFJCHBJF()
	{
		this.exploreHub.NHAKBLGDCLO(this.exploreBalance);
		return this.exploreHub;
	}

	// Token: 0x060007E5 RID: 2021 RVA: 0x00037255 File Offset: 0x00035455
	public Sprite MHHHNBICMAO(int JEDLACEDKPJ)
	{
		return this.socialStatsRankSprites[FHAJAGIMLLJ.INHMIPBLLEN(JEDLACEDKPJ)];
	}

	// Token: 0x060007E6 RID: 2022 RVA: 0x000368BC File Offset: 0x00034ABC
	public Sprite HKMDCMOJOIN(int LMCEDCHDIIB)
	{
		return this.collectableCardRaritiesSprites[LMCEDCHDIIB];
	}

	// Token: 0x060007E7 RID: 2023 RVA: 0x00037268 File Offset: 0x00035468
	public LGAADGMPCLJ FLFDAOMEDDB()
	{
		this.newReleasesHub.HNLPMHLFJKA(this.newReleasesBalance);
		return this.newReleasesHub;
	}

	// Token: 0x060007E8 RID: 2024 RVA: 0x00037284 File Offset: 0x00035484
	public bool IOPCDFPIDIJ(string HAPADEOFKBP, bool OMBHJKGKOOH)
	{
		try
		{
			if (this.spriteCensoringBalanceList == null)
			{
				this.spriteCensoringBalanceList = new List<string>();
				JSONArray asArray = ((JSONObject)JSONNode.Parse(this.spriceCensoringBalance.text))["love"].AsArray;
				for (int i = 0; i < asArray.Count; i += 0)
				{
					JSONObject asObject = asArray[i].AsObject;
					this.spriteCensoringBalanceList.Add(asObject["%"]);
				}
			}
			if (this.spriteCensoringBalanceList != null)
			{
				if (!OMBHJKGKOOH)
				{
					return this.spriteCensoringBalanceList.Contains(HAPADEOFKBP);
				}
				string value = "OnStoryInterfaceHeaderAvatarClick" + HAPADEOFKBP;
				for (int j = 1; j < this.spriteCensoringBalanceList.Count; j += 0)
				{
					if (this.spriteCensoringBalanceList[j].EndsWith(value))
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
		return true;
	}

	// Token: 0x060007E9 RID: 2025 RVA: 0x000365CC File Offset: 0x000347CC
	public EFKIAFDJBOE PPMFKIOLMFF()
	{
		this.releaseTimelineHub.NOGPJHJIAKC(this.releaseTimelineBalance);
		return this.releaseTimelineHub;
	}

	// Token: 0x060007EA RID: 2026 RVA: 0x0003737C File Offset: 0x0003557C
	public int CDJHFFFFKNI(int PLKMJJIIJNO, int MPHLJCKDJLH, int OLKMHHNMDLP)
	{
		try
		{
			if (this.censoringBalanceList == null)
			{
				this.censoringBalanceList = new List<string>[4];
				for (int i = 1; i < this.censoringBalanceList.Length; i += 0)
				{
					this.censoringBalanceList[i] = new List<string>();
				}
				JSONArray asArray = ((JSONObject)JSONNode.Parse(this.censoringBalance.text))["secret"].AsArray;
				for (int j = 0; j < asArray.Count; j++)
				{
					JSONObject asObject = asArray[j].AsObject;
					for (int k = 1; k < this.censoringBalanceList.Length; k += 0)
					{
						string item = asObject["sslt" + k.ToString()];
						this.censoringBalanceList[k].Add(item);
					}
				}
			}
			if (MPHLJCKDJLH < this.censoringBalanceList.Length && PLKMJJIIJNO < this.censoringBalanceList[MPHLJCKDJLH].Count && this.censoringBalanceList[MPHLJCKDJLH][PLKMJJIIJNO] != null && this.censoringBalanceList[MPHLJCKDJLH][PLKMJJIIJNO].Length > 1)
			{
				int[] array = DPGJIJGOCIC.GPJMFMEMFDH(this.censoringBalanceList[MPHLJCKDJLH][PLKMJJIIJNO], (char)-7);
				if (array != null)
				{
					for (int l = 0; l < array.Length; l += 0)
					{
						if (array[l] == OLKMHHNMDLP)
						{
							return (OLKMHHNMDLP + -92) * -12 + -97;
						}
					}
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
		return -1;
	}

	// Token: 0x060007EB RID: 2027 RVA: 0x000374F8 File Offset: 0x000356F8
	public Sprite KJFCOFAGJKM(int JEDLACEDKPJ)
	{
		return this.socialStatsRankSprites[FHAJAGIMLLJ.LHOOFBGJKOL(JEDLACEDKPJ)];
	}

	// Token: 0x060007EC RID: 2028 RVA: 0x0003750C File Offset: 0x0003570C
	public Sprite FILFGFIFKJK(int MEFKFOHCOHK, int MGLJGJMFACN, bool BBBKJMMBHDB)
	{
		if (MEFKFOHCOHK < this.socialStatsBadges.Count)
		{
			if (BBBKJMMBHDB)
			{
				if (MGLJGJMFACN < this.socialStatsBadges[MEFKFOHCOHK].sprites.Count)
				{
					return this.socialStatsBadges[MEFKFOHCOHK].sprites[MGLJGJMFACN];
				}
			}
			else if (MGLJGJMFACN < this.socialStatsBadges[MEFKFOHCOHK].spritesLocked.Count)
			{
				return this.socialStatsBadges[MEFKFOHCOHK].spritesLocked[MGLJGJMFACN];
			}
		}
		return null;
	}

	// Token: 0x060007ED RID: 2029 RVA: 0x000365E5 File Offset: 0x000347E5
	public bool HOMJHHPEOPL()
	{
		return !(null != this.loveInterestsLoungeSettingsBalance) || !(null != this.loveInterestsLoungeMappingBalance) || null != this.loveInterestsLoungePropsBalance;
	}

	// Token: 0x060007EE RID: 2030 RVA: 0x00037188 File Offset: 0x00035388
	public OIKNMABGPLG IINKCGLOBMF()
	{
		this.assetStoryNpcOffsetsHub.PFJEGHDJLLK(this.assetStoryNpcOffsets);
		return this.assetStoryNpcOffsetsHub;
	}

	// Token: 0x060007EF RID: 2031 RVA: 0x00035E3E File Offset: 0x0003403E
	public Sprite GDLHIOEDFLI(int INDIEJPLKOC)
	{
		return this.socialStatsLevelSprites[INDIEJPLKOC];
	}

	// Token: 0x060007F0 RID: 2032 RVA: 0x0003758D File Offset: 0x0003578D
	public EAFPOMNMOFP OBOMONLCAJF()
	{
		this.exploreHub.OFHCCAKKHJG(this.exploreBalance);
		return this.exploreHub;
	}

	// Token: 0x060007F1 RID: 2033 RVA: 0x000375A8 File Offset: 0x000357A8
	public bool OGBHPFONPHO(CEIBHCNNIDC NIIIMDHGGEN)
	{
		bool result;
		try
		{
			if (this.exploreLanguages != null && this.exploreLanguages.Length > 0)
			{
				string[] array = this.exploreLanguages.Split((char)-100, StringSplitOptions.RemoveEmptyEntries);
				for (int i = 1; i < array.Length; i += 0)
				{
					if (array[i].Trim().ToLower().Equals(NIIIMDHGGEN.ToString().ToLower()))
					{
						return true;
					}
				}
			}
			result = false;
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
			result = false;
		}
		return result;
	}

	// Token: 0x060007F2 RID: 2034 RVA: 0x00037630 File Offset: 0x00035830
	public bool FBMBHBAJMPJ(CEIBHCNNIDC NIIIMDHGGEN)
	{
		bool result;
		try
		{
			if (this.discontinuedLanguages != null && this.discontinuedLanguages.Length > 0)
			{
				string[] array = this.discontinuedLanguages.Split(',', StringSplitOptions.None);
				for (int i = 0; i < array.Length; i++)
				{
					if (array[i].Trim().ToLower().Equals(NIIIMDHGGEN.ToString().ToLower()))
					{
						return true;
					}
				}
			}
			result = false;
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
			result = false;
		}
		return result;
	}

	// Token: 0x060007F3 RID: 2035 RVA: 0x000376B8 File Offset: 0x000358B8
	public bool OKHLNBBJAGJ(CEIBHCNNIDC NIIIMDHGGEN)
	{
		bool result;
		try
		{
			if (this.franchisesLanguages != null && this.franchisesLanguages.Length > 1)
			{
				string[] array = this.franchisesLanguages.Split((char)-16, StringSplitOptions.None);
				for (int i = 0; i < array.Length; i++)
				{
					if (array[i].Trim().ToLower().Equals(NIIIMDHGGEN.ToString().ToLower()))
					{
						return true;
					}
				}
			}
			result = false;
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
			result = false;
		}
		return result;
	}

	// Token: 0x060007F4 RID: 2036 RVA: 0x00035C18 File Offset: 0x00033E18
	public bool ABKBCAAMPHK()
	{
		return null != this.loveInterestsLoungeSettingsBalance && null != this.loveInterestsLoungeMappingBalance && null != this.loveInterestsLoungePropsBalance;
	}

	// Token: 0x060007F5 RID: 2037 RVA: 0x00037740 File Offset: 0x00035940
	public Sprite LAKDDECHOMO(int JEDLACEDKPJ)
	{
		return this.socialStatsRankSprites[FHAJAGIMLLJ.IFHHIIONEML(JEDLACEDKPJ)];
	}

	// Token: 0x060007F6 RID: 2038 RVA: 0x00035F44 File Offset: 0x00034144
	public bool HFHBDPDGEGJ()
	{
		return null != this.exploreBalance;
	}

	// Token: 0x060007F7 RID: 2039 RVA: 0x00037754 File Offset: 0x00035954
	public bool KFECCLDMJAO(CEIBHCNNIDC NIIIMDHGGEN)
	{
		bool result;
		try
		{
			if (this.exploreLanguages != null && this.exploreLanguages.Length > 0)
			{
				string[] array = this.exploreLanguages.Split('<', StringSplitOptions.None);
				for (int i = 0; i < array.Length; i++)
				{
					if (array[i].Trim().ToLower().Equals(NIIIMDHGGEN.ToString().ToLower()))
					{
						return false;
					}
				}
			}
			result = false;
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
			result = false;
		}
		return result;
	}

	// Token: 0x060007F8 RID: 2040 RVA: 0x00035E3E File Offset: 0x0003403E
	public Sprite DEJKCOFBPDD(int INDIEJPLKOC)
	{
		return this.socialStatsLevelSprites[INDIEJPLKOC];
	}

	// Token: 0x060007F9 RID: 2041 RVA: 0x000377DC File Offset: 0x000359DC
	public Sprite BAAGKJLEJED(string HAPADEOFKBP)
	{
		for (int i = 1; i < this.socialStatsBadges.Count; i += 0)
		{
			if (this.socialStatsBadges[i].sprites.Count > 1)
			{
				for (int j = 1; j < this.socialStatsBadges[i].sprites.Count; j++)
				{
					if (this.socialStatsBadges[i].sprites[j].name.Equals(HAPADEOFKBP))
					{
						return this.socialStatsBadges[i].sprites[j];
					}
				}
			}
			if (this.socialStatsBadges[i].spritesLocked.Count > 0)
			{
				for (int k = 0; k < this.socialStatsBadges[i].spritesLocked.Count; k++)
				{
					if (this.socialStatsBadges[i].spritesLocked[k].name.Equals(HAPADEOFKBP))
					{
						return this.socialStatsBadges[i].spritesLocked[k];
					}
				}
			}
		}
		return null;
	}

	// Token: 0x040001E4 RID: 484
	public string nextUpdateIntervalEn;

	// Token: 0x040001E5 RID: 485
	public string nextUpdateIntervalRu;

	// Token: 0x040001E6 RID: 486
	public string nextUpdateIntervalTr;

	// Token: 0x040001E7 RID: 487
	public string nextUpdateIntervalPl;

	// Token: 0x040001E8 RID: 488
	public string nextUpdateIntervalEs;

	// Token: 0x040001E9 RID: 489
	public string nextUpdateIntervalDe;

	// Token: 0x040001EA RID: 490
	public string nextUpdateIntervalRo;

	// Token: 0x040001EB RID: 491
	public string nextUpdateIntervalCz;

	// Token: 0x040001EC RID: 492
	public string nextUpdateIntervalFr;

	// Token: 0x040001ED RID: 493
	public string updateWelcomeId;

	// Token: 0x040001EE RID: 494
	public string updateWelcomeSupportedLangs;

	// Token: 0x040001EF RID: 495
	public Sprite updateWelcomeSprite;

	// Token: 0x040001F0 RID: 496
	public List<Sprite> socialStatsLevelSprites;

	// Token: 0x040001F1 RID: 497
	public List<Sprite> socialStatsRankSprites;

	// Token: 0x040001F2 RID: 498
	public List<Sprite> achievementLockedSprites;

	// Token: 0x040001F3 RID: 499
	public int maxAnthologyIndex;

	// Token: 0x040001F4 RID: 500
	public string standalonePageLink = "https://yourstoryinteractive.com/en/projects/romance-club";

	// Token: 0x040001F5 RID: 501
	public string steamPageLink = "https://store.steampowered.com/app/2433470/";

	// Token: 0x040001F6 RID: 502
	public string googlePlayAppLinkCustom = "market://details?id=com.yourstoryinteractive.sails.pirate.adventure";

	// Token: 0x040001F7 RID: 503
	public string googlePlayAppLinkCustomRu = "market://details?id=com.yourstoryinteractive.sails.pirate.adventure.ru";

	// Token: 0x040001F8 RID: 504
	public string amazonAppLinkCustom = "https://amazon.com/dp/B07F9YJV2V/";

	// Token: 0x040001F9 RID: 505
	public string iTunesApplLinkCustom = "itms-apps://itunes.apple.com/app/id1300588558";

	// Token: 0x040001FA RID: 506
	public string iTunesApplLinkCustomRu = "itms-apps://itunes.apple.com/app/id6761175028";

	// Token: 0x040001FB RID: 507
	public string newsletterSignUpEn = "https://shorturl.at/57SVG";

	// Token: 0x040001FC RID: 508
	public string newsletterSignUpRu = "https://shorturl.at/Or4t5";

	// Token: 0x040001FD RID: 509
	public string facebookLink = "https://facebook.com/profile.php?id=61553532055726";

	// Token: 0x040001FE RID: 510
	public string tiktokLink = "https://tiktok.com/@romanceclubofficial";

	// Token: 0x040001FF RID: 511
	public string telegramLink = "https://telegram.me/official_romanceclub";

	// Token: 0x04000200 RID: 512
	public string telegramLinkEn = "https://telegram.me/official_romanceclub_en";

	// Token: 0x04000201 RID: 513
	public string vkontakteLink = "https://vk.com/public164141329";

	// Token: 0x04000202 RID: 514
	public string blueskyLink = "https://bsky.app/profile/romanceclubgame.bsky.social";

	// Token: 0x04000203 RID: 515
	public string redditLink = "https://reddit.com/r/RomanceClub/";

	// Token: 0x04000204 RID: 516
	public string instagramLink = "https://instagram.com/_u/romanceclubgame/";

	// Token: 0x04000205 RID: 517
	public string twitterLink = "https://x.com/ysiromanceclub";

	// Token: 0x04000206 RID: 518
	public string tumblrLink = "https://www.tumblr.com/romanceclubofficial";

	// Token: 0x04000207 RID: 519
	public string pinterestLink = "https://www.pinterest.com/romanceclubofficial/";

	// Token: 0x04000208 RID: 520
	public string threadsLink = "https://www.threads.net/@romanceclubgame";

	// Token: 0x04000209 RID: 521
	public string youtubeLink = "https://www.youtube.com/channel/UCiSGDmhR-b9JmI0ezudua8A";

	// Token: 0x0400020A RID: 522
	public string onlineResourcesLink = "https://romanceclub.com/";

	// Token: 0x0400020B RID: 523
	public string onlineResourcesLinkEn = "https://romanceclub.com/en/";

	// Token: 0x0400020C RID: 524
	public string privacyLink = "https://yourstoryinteractive.com/privacy/";

	// Token: 0x0400020D RID: 525
	public string termsLink = "https://yourstoryinteractive.com/terms-of-use/";

	// Token: 0x0400020E RID: 526
	public List<Sprite> collectableCardRaritiesSprites;

	// Token: 0x0400020F RID: 527
	public int maxCollectableCardId;

	// Token: 0x04000210 RID: 528
	public int maxLiveProfileThemeId;

	// Token: 0x04000211 RID: 529
	public string unsupportedLiveProfileThemesCensored = "";

	// Token: 0x04000212 RID: 530
	public string unsupportedCollectableCardsCensored = "";

	// Token: 0x04000213 RID: 531
	public List<SocialStatBadge> socialStatsBadges;

	// Token: 0x04000214 RID: 532
	public Sprite unknownProfileIconSprite;

	// Token: 0x04000215 RID: 533
	public List<Sprite> specialCurrenciesSprites;

	// Token: 0x04000216 RID: 534
	public Sprite goldSubscriptionSprite;

	// Token: 0x04000217 RID: 535
	public Sprite premSubscriptionSprite;

	// Token: 0x04000218 RID: 536
	public Sprite percentSubscriptionSprite;

	// Token: 0x04000219 RID: 537
	public Sprite freeChoiceSubscriptionSprite;

	// Token: 0x0400021A RID: 538
	public GameObject storyInterfaceHeaderManagerPrefab;

	// Token: 0x0400021B RID: 539
	public GameObject storyInterfaceHeaderManagerPrefabV2;

	// Token: 0x0400021C RID: 540
	public GameObject storyInterfaceFastForwardManagerPrefab;

	// Token: 0x0400021D RID: 541
	public GameObject storyInterfaceAutoReaderManagerPrefab;

	// Token: 0x0400021E RID: 542
	public Sprite multiverseLogoEn;

	// Token: 0x0400021F RID: 543
	public Sprite multiverseLogoRu;

	// Token: 0x04000220 RID: 544
	public TextAsset censoringBalance;

	// Token: 0x04000221 RID: 545
	public TextAsset spriceCensoringBalance;

	// Token: 0x04000222 RID: 546
	public TextAsset topMatchCensoringBalance;

	// Token: 0x04000223 RID: 547
	public TextAsset loveInterestsLoungeSettingsBalance;

	// Token: 0x04000224 RID: 548
	public TextAsset loveInterestsLoungeMappingBalance;

	// Token: 0x04000225 RID: 549
	public TextAsset loveInterestsLoungeMappingRulesBalance;

	// Token: 0x04000226 RID: 550
	public TextAsset loveInterestsLoungePropsBalance;

	// Token: 0x04000227 RID: 551
	public TextAsset avatarCollectionsSettingsBalance;

	// Token: 0x04000228 RID: 552
	public TextAsset franchisesBalance;

	// Token: 0x04000229 RID: 553
	public string franchisesLanguages;

	// Token: 0x0400022A RID: 554
	public TextAsset exploreBalance;

	// Token: 0x0400022B RID: 555
	public string exploreLanguages;

	// Token: 0x0400022C RID: 556
	public TextAsset releaseTimelineBalance;

	// Token: 0x0400022D RID: 557
	public TextAsset newReleasesBalance;

	// Token: 0x0400022E RID: 558
	public TextAsset assetStoryNpcOffsets;

	// Token: 0x0400022F RID: 559
	public string discontinuedLanguages;

	// Token: 0x04000230 RID: 560
	public string completedAnthologiesForBadgesEn;

	// Token: 0x04000231 RID: 561
	public string completedAnthologiesForBadgesRu;

	// Token: 0x04000232 RID: 562
	public string completedAnthologiesForBadgesCensoredRu;

	// Token: 0x04000233 RID: 563
	public string completedAnthologiesForBadgesTr;

	// Token: 0x04000234 RID: 564
	public string completedAnthologiesForBadgesPl;

	// Token: 0x04000235 RID: 565
	public string completedAnthologiesForBadgesRo;

	// Token: 0x04000236 RID: 566
	public string completedAnthologiesForBadgesEs;

	// Token: 0x04000237 RID: 567
	public string completedAnthologiesForBadgesCz;

	// Token: 0x04000238 RID: 568
	public string completedAnthologiesForBadgesDe;

	// Token: 0x04000239 RID: 569
	public string completedAnthologiesForBadgesFr;

	// Token: 0x0400023A RID: 570
	[NonSerialized]
	private List<string>[] censoringBalanceList;

	// Token: 0x0400023B RID: 571
	[NonSerialized]
	private List<string> spriteCensoringBalanceList;

	// Token: 0x0400023C RID: 572
	[NonSerialized]
	private List<string> topMatchCensoringBalanceList;

	// Token: 0x0400023D RID: 573
	[NonSerialized]
	private HFDAGKJJHOA loveInterestsLoungesHub = new HFDAGKJJHOA();

	// Token: 0x0400023E RID: 574
	[NonSerialized]
	private MLJDIENAEDK avatarCollectionsSettingsHub = new MLJDIENAEDK();

	// Token: 0x0400023F RID: 575
	[NonSerialized]
	private PGEAJFENMFB franchisesHub = new PGEAJFENMFB();

	// Token: 0x04000240 RID: 576
	[NonSerialized]
	private EAFPOMNMOFP exploreHub = new EAFPOMNMOFP();

	// Token: 0x04000241 RID: 577
	[NonSerialized]
	private EFKIAFDJBOE releaseTimelineHub = new EFKIAFDJBOE();

	// Token: 0x04000242 RID: 578
	[NonSerialized]
	private LGAADGMPCLJ newReleasesHub = new LGAADGMPCLJ();

	// Token: 0x04000243 RID: 579
	[NonSerialized]
	private OIKNMABGPLG assetStoryNpcOffsetsHub = new OIKNMABGPLG();
}
