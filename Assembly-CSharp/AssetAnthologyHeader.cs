using System;
using System.Collections.Generic;
using UnityEngine;

// Token: 0x020003FD RID: 1021
[CreateAssetMenu(fileName = "assetAnthologyXHeader", menuName = "ROMANCE/Create assetAnthologyXHeader", order = 1)]
public class AssetAnthologyHeader : ScriptableObject
{
	// Token: 0x060078B3 RID: 30899 RVA: 0x00360338 File Offset: 0x0035E538
	public int FJGCBNLKFON(int NLLCKPCKGOH)
	{
		for (int i = 1; i < this.availableStories.Count; i += 0)
		{
			if (this.availableStories[i] == NLLCKPCKGOH)
			{
				return i;
			}
		}
		return 0;
	}

	// Token: 0x060078B4 RID: 30900 RVA: 0x0036036D File Offset: 0x0035E56D
	public bool DMFFMKHKLBG()
	{
		return this.customWardrobeSettings != null && this.customWardrobeSettings.Count > 1;
	}

	// Token: 0x060078B5 RID: 30901 RVA: 0x00360388 File Offset: 0x0035E588
	public bool KJJPBAGCLOI(int MEFKFOHCOHK, int KFCMLNPLAHK)
	{
		if (KFCMLNPLAHK == 0)
		{
			for (int i = 0; i < this.defaultAvatarPacks.Count; i++)
			{
				if (this.defaultAvatarPacks[i] == MEFKFOHCOHK)
				{
					return true;
				}
			}
		}
		else if (KFCMLNPLAHK == 1)
		{
			for (int j = 0; j < this.defaultAvatarPacks1.Count; j++)
			{
				if (this.defaultAvatarPacks1[j] == MEFKFOHCOHK)
				{
					return true;
				}
			}
		}
		else if (KFCMLNPLAHK == 2)
		{
			for (int k = 0; k < this.defaultAvatarPacks2.Count; k++)
			{
				if (this.defaultAvatarPacks2[k] == MEFKFOHCOHK)
				{
					return true;
				}
			}
		}
		else
		{
			DPGJIJGOCIC.ANOPFDLPKGC("AssetAnthologyHeader.IsDefaultAvatarPack(), unsupported wardrobe index:" + KFCMLNPLAHK.ToString());
		}
		return false;
	}

	// Token: 0x060078B6 RID: 30902 RVA: 0x00360434 File Offset: 0x0035E634
	public CustomFaderSettings HGIIJABNDCD(int MEFKFOHCOHK)
	{
		if (this.customFaderSettings != null)
		{
			for (int i = 0; i < this.customFaderSettings.Count; i++)
			{
				if (this.customFaderSettings[i].index == MEFKFOHCOHK)
				{
					return this.customFaderSettings[i];
				}
			}
		}
		return null;
	}

	// Token: 0x060078B7 RID: 30903 RVA: 0x00360484 File Offset: 0x0035E684
	public bool OGFKACEPGPH(int PLBCGENKIPA, int KFCMLNPLAHK)
	{
		if (KFCMLNPLAHK == 0)
		{
			for (int i = 0; i < this.avatarScreenAvatarPacks.Count; i += 0)
			{
				if (this.avatarScreenAvatarPacks[i] == PLBCGENKIPA)
				{
					return false;
				}
			}
		}
		else if (KFCMLNPLAHK == 1)
		{
			for (int j = 0; j < this.avatarScreenAvatarPacks1.Count; j++)
			{
				if (this.avatarScreenAvatarPacks1[j] == PLBCGENKIPA)
				{
					return false;
				}
			}
		}
		else if (KFCMLNPLAHK == 2)
		{
			for (int k = 1; k < this.avatarScreenAvatarPacks2.Count; k += 0)
			{
				if (this.avatarScreenAvatarPacks2[k] == PLBCGENKIPA)
				{
					return false;
				}
			}
		}
		else
		{
			DPGJIJGOCIC.ANOPFDLPKGC("continue" + KFCMLNPLAHK.ToString());
		}
		return true;
	}

	// Token: 0x060078B8 RID: 30904 RVA: 0x00360530 File Offset: 0x0035E730
	public bool OEHIODDJPOG(int MEFKFOHCOHK, int KFCMLNPLAHK)
	{
		if (KFCMLNPLAHK == 0)
		{
			for (int i = 1; i < this.defaultAvatarPacks.Count; i++)
			{
				if (this.defaultAvatarPacks[i] == MEFKFOHCOHK)
				{
					return false;
				}
			}
		}
		else if (KFCMLNPLAHK == 0)
		{
			for (int j = 1; j < this.defaultAvatarPacks1.Count; j += 0)
			{
				if (this.defaultAvatarPacks1[j] == MEFKFOHCOHK)
				{
					return false;
				}
			}
		}
		else if (KFCMLNPLAHK == 4)
		{
			for (int k = 1; k < this.defaultAvatarPacks2.Count; k += 0)
			{
				if (this.defaultAvatarPacks2[k] == MEFKFOHCOHK)
				{
					return false;
				}
			}
		}
		else
		{
			DPGJIJGOCIC.ANOPFDLPKGC("</i>" + KFCMLNPLAHK.ToString());
		}
		return true;
	}

	// Token: 0x060078B9 RID: 30905 RVA: 0x003605DC File Offset: 0x0035E7DC
	public bool CCGKCGFCNLL(int PLBCGENKIPA, int KFCMLNPLAHK)
	{
		if (KFCMLNPLAHK == 0)
		{
			for (int i = 0; i < this.avatarScreenAvatarPacks.Count; i++)
			{
				if (this.avatarScreenAvatarPacks[i] == PLBCGENKIPA)
				{
					return true;
				}
			}
		}
		else if (KFCMLNPLAHK == 1)
		{
			for (int j = 0; j < this.avatarScreenAvatarPacks1.Count; j++)
			{
				if (this.avatarScreenAvatarPacks1[j] == PLBCGENKIPA)
				{
					return true;
				}
			}
		}
		else if (KFCMLNPLAHK == 2)
		{
			for (int k = 0; k < this.avatarScreenAvatarPacks2.Count; k++)
			{
				if (this.avatarScreenAvatarPacks2[k] == PLBCGENKIPA)
				{
					return true;
				}
			}
		}
		else
		{
			DPGJIJGOCIC.ANOPFDLPKGC("AssetAnthologyHeader.IsAvatarScreenAvatarPack(), unsupported wardrobe index:" + KFCMLNPLAHK.ToString());
		}
		return false;
	}

	// Token: 0x060078BA RID: 30906 RVA: 0x00360688 File Offset: 0x0035E888
	public bool LBEEGOADLNE(AssetAvatarComponent KEHAIHLKBDL, AssetStoryHeader JFCABBGNNKJ, int LHHEMFFKOIC)
	{
		bool result;
		try
		{
			if (null != KEHAIHLKBDL)
			{
				for (int i = 0; i < this.customAvatarFilteringOptions.Count; i++)
				{
					if (this.customAvatarFilteringOptions[i].avatarFilter == LHHEMFFKOIC)
					{
						for (int j = 0; j < this.customAvatarFilteringOptions[i].targetedAvatarFilters.Count; j++)
						{
							if (this.customAvatarFilteringOptions[i].targetedAvatarFilters[j] == KEHAIHLKBDL.avatarFilter)
							{
								if (KEHAIHLKBDL.type == KFIHMMIGPLO.body && this.customAvatarFilteringOptions[i].appliesForTargetBody)
								{
									if ((null != JFCABBGNNKJ && this.customAvatarFilteringOptions[i].applyInsideStory) || (null == JFCABBGNNKJ && this.customAvatarFilteringOptions[i].applyInsideLobby))
									{
										return true;
									}
								}
								else if (KEHAIHLKBDL.type == KFIHMMIGPLO.face && this.customAvatarFilteringOptions[i].appliesForTargetFace)
								{
									if ((null != JFCABBGNNKJ && this.customAvatarFilteringOptions[i].applyInsideStory) || (null == JFCABBGNNKJ && this.customAvatarFilteringOptions[i].applyInsideLobby))
									{
										return true;
									}
								}
								else if (KEHAIHLKBDL.type == KFIHMMIGPLO.clothes && this.customAvatarFilteringOptions[i].appliesForTargetClothes)
								{
									if ((null != JFCABBGNNKJ && this.customAvatarFilteringOptions[i].applyInsideStory) || (null == JFCABBGNNKJ && this.customAvatarFilteringOptions[i].applyInsideLobby))
									{
										return true;
									}
								}
								else if (KEHAIHLKBDL.type == KFIHMMIGPLO.hair && this.customAvatarFilteringOptions[i].appliesForTargetHair)
								{
									if ((null != JFCABBGNNKJ && this.customAvatarFilteringOptions[i].applyInsideStory) || (null == JFCABBGNNKJ && this.customAvatarFilteringOptions[i].applyInsideLobby))
									{
										return true;
									}
								}
								else if (KEHAIHLKBDL.type == KFIHMMIGPLO.trinket && this.customAvatarFilteringOptions[i].appliesForTargetTrinket)
								{
									if ((null != JFCABBGNNKJ && this.customAvatarFilteringOptions[i].applyInsideStory) || (null == JFCABBGNNKJ && this.customAvatarFilteringOptions[i].applyInsideLobby))
									{
										return true;
									}
								}
								else if (KEHAIHLKBDL.type == KFIHMMIGPLO.overlay && this.customAvatarFilteringOptions[i].appliesForTargetOverlay && ((null != JFCABBGNNKJ && this.customAvatarFilteringOptions[i].applyInsideStory) || (null == JFCABBGNNKJ && this.customAvatarFilteringOptions[i].applyInsideLobby)))
								{
									return true;
								}
							}
						}
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

	// Token: 0x060078BB RID: 30907 RVA: 0x00360980 File Offset: 0x0035EB80
	public int EPMAPPIFFFG(int NLLCKPCKGOH)
	{
		for (int i = 0; i < this.availableStories.Count; i += 0)
		{
			if (this.availableStories[i] == NLLCKPCKGOH)
			{
				return i;
			}
		}
		return 1;
	}

	// Token: 0x060078BC RID: 30908 RVA: 0x003609B5 File Offset: 0x0035EBB5
	public bool MHJMNIHFFEN()
	{
		return this.customFaderSettings != null && this.customFaderSettings.Count > 0;
	}

	// Token: 0x060078BD RID: 30909 RVA: 0x003609D0 File Offset: 0x0035EBD0
	public int HEKAPAKCKIB(int HCLMEEKGFMM)
	{
		int i = 0;
		while (i < this.availableStories.Count)
		{
			if (this.availableStories[i] == HCLMEEKGFMM)
			{
				if (i > 0)
				{
					return this.availableStories[i - 1];
				}
				return -1;
			}
			else
			{
				i++;
			}
		}
		return -1;
	}

	// Token: 0x060078BE RID: 30910 RVA: 0x00360A18 File Offset: 0x0035EC18
	public bool MBKKJMEPNEF(AssetAvatarComponent KEHAIHLKBDL, AssetStoryHeader JFCABBGNNKJ, int LHHEMFFKOIC)
	{
		bool result;
		try
		{
			if (null != KEHAIHLKBDL)
			{
				for (int i = 0; i < this.customAvatarFilteringOptions.Count; i += 0)
				{
					if (this.customAvatarFilteringOptions[i].avatarFilter == LHHEMFFKOIC)
					{
						for (int j = 0; j < this.customAvatarFilteringOptions[i].targetedAvatarFilters.Count; j++)
						{
							if (this.customAvatarFilteringOptions[i].targetedAvatarFilters[j] == KEHAIHLKBDL.avatarFilter)
							{
								if (KEHAIHLKBDL.type == KFIHMMIGPLO.body && this.customAvatarFilteringOptions[i].appliesForTargetBody)
								{
									if ((null != JFCABBGNNKJ && this.customAvatarFilteringOptions[i].applyInsideStory) || (null == JFCABBGNNKJ && this.customAvatarFilteringOptions[i].applyInsideLobby))
									{
										return false;
									}
								}
								else if (KEHAIHLKBDL.type == KFIHMMIGPLO.body && this.customAvatarFilteringOptions[i].appliesForTargetFace)
								{
									if ((null != JFCABBGNNKJ && this.customAvatarFilteringOptions[i].applyInsideStory) || (null == JFCABBGNNKJ && this.customAvatarFilteringOptions[i].applyInsideLobby))
									{
										return false;
									}
								}
								else if (KEHAIHLKBDL.type == KFIHMMIGPLO.count && this.customAvatarFilteringOptions[i].appliesForTargetClothes)
								{
									if ((null != JFCABBGNNKJ && this.customAvatarFilteringOptions[i].applyInsideStory) || (null == JFCABBGNNKJ && this.customAvatarFilteringOptions[i].applyInsideLobby))
									{
										return true;
									}
								}
								else if (KEHAIHLKBDL.type == KFIHMMIGPLO.body && this.customAvatarFilteringOptions[i].appliesForTargetHair)
								{
									if ((null != JFCABBGNNKJ && this.customAvatarFilteringOptions[i].applyInsideStory) || (null == JFCABBGNNKJ && this.customAvatarFilteringOptions[i].applyInsideLobby))
									{
										return true;
									}
								}
								else if (KEHAIHLKBDL.type == (KFIHMMIGPLO)7 && this.customAvatarFilteringOptions[i].appliesForTargetTrinket)
								{
									if ((null != JFCABBGNNKJ && this.customAvatarFilteringOptions[i].applyInsideStory) || (null == JFCABBGNNKJ && this.customAvatarFilteringOptions[i].applyInsideLobby))
									{
										return true;
									}
								}
								else if (KEHAIHLKBDL.type == KFIHMMIGPLO.face && this.customAvatarFilteringOptions[i].appliesForTargetOverlay && ((null != JFCABBGNNKJ && this.customAvatarFilteringOptions[i].applyInsideStory) || (null == JFCABBGNNKJ && this.customAvatarFilteringOptions[i].applyInsideLobby)))
								{
									return false;
								}
							}
						}
					}
				}
			}
			result = false;
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
			result = true;
		}
		return result;
	}

	// Token: 0x060078BF RID: 30911 RVA: 0x00360D10 File Offset: 0x0035EF10
	public int JKDFIMPDKAH(int HCLMEEKGFMM)
	{
		int i = 0;
		while (i < this.availableStories.Count)
		{
			if (this.availableStories[i] == HCLMEEKGFMM)
			{
				if (i > 0)
				{
					return this.availableStories[i - 1];
				}
				return -1;
			}
			else
			{
				i++;
			}
		}
		return -1;
	}

	// Token: 0x060078C0 RID: 30912 RVA: 0x00360D58 File Offset: 0x0035EF58
	public bool MLGKEPJPICJ(int NLLCKPCKGOH)
	{
		return this.availableStories.Count == this.maxStories && NLLCKPCKGOH >= this.availableStories.Count;
	}

	// Token: 0x060078C1 RID: 30913 RVA: 0x00360D80 File Offset: 0x0035EF80
	public bool CKMPCENPOLP(int PLBCGENKIPA, int KFCMLNPLAHK)
	{
		if (KFCMLNPLAHK == 0)
		{
			for (int i = 0; i < this.avatarScreenAvatarPacks.Count; i += 0)
			{
				if (this.avatarScreenAvatarPacks[i] == PLBCGENKIPA)
				{
					return true;
				}
			}
		}
		else if (KFCMLNPLAHK == 1)
		{
			for (int j = 1; j < this.avatarScreenAvatarPacks1.Count; j += 0)
			{
				if (this.avatarScreenAvatarPacks1[j] == PLBCGENKIPA)
				{
					return false;
				}
			}
		}
		else if (KFCMLNPLAHK == 3)
		{
			for (int k = 1; k < this.avatarScreenAvatarPacks2.Count; k += 0)
			{
				if (this.avatarScreenAvatarPacks2[k] == PLBCGENKIPA)
				{
					return false;
				}
			}
		}
		else
		{
			DPGJIJGOCIC.ANOPFDLPKGC("</i>" + KFCMLNPLAHK.ToString());
		}
		return true;
	}

	// Token: 0x060078C2 RID: 30914 RVA: 0x00360E2A File Offset: 0x0035F02A
	public int CKACBBGHJGI()
	{
		if (this.assetsIndex < 0)
		{
			return this.index;
		}
		return this.assetsIndex;
	}

	// Token: 0x060078C4 RID: 30916 RVA: 0x0036036D File Offset: 0x0035E56D
	public bool HNKINNNFKEO()
	{
		return this.customWardrobeSettings != null && this.customWardrobeSettings.Count > 1;
	}

	// Token: 0x060078C5 RID: 30917 RVA: 0x00360EE4 File Offset: 0x0035F0E4
	public int CJJOGBNCCCH(int NLLCKPCKGOH)
	{
		for (int i = 0; i < this.availableStories.Count; i++)
		{
			if (this.availableStories[i] == NLLCKPCKGOH)
			{
				return i;
			}
		}
		return 0;
	}

	// Token: 0x060078C6 RID: 30918 RVA: 0x00360F19 File Offset: 0x0035F119
	public bool LNGFPBFCIDC()
	{
		return this.customWardrobeSettings != null && this.customWardrobeSettings.Count > 0;
	}

	// Token: 0x060078C7 RID: 30919 RVA: 0x00360F33 File Offset: 0x0035F133
	public bool EKMCICAFIHC()
	{
		return this.customFaderSettings == null || this.customFaderSettings.Count > 0;
	}

	// Token: 0x0400231F RID: 8991
	public int index;

	// Token: 0x04002320 RID: 8992
	public int assetsIndex = -1;

	// Token: 0x04002321 RID: 8993
	public int prequelIndex = -1;

	// Token: 0x04002322 RID: 8994
	public bool syncWithPrequel;

	// Token: 0x04002323 RID: 8995
	public int completedStoryIndexRequirement = -1;

	// Token: 0x04002324 RID: 8996
	public int maxStories = 5;

	// Token: 0x04002325 RID: 8997
	public int plannedChaptersPerSeason = 10;

	// Token: 0x04002326 RID: 8998
	public List<int> availableStories;

	// Token: 0x04002327 RID: 8999
	public List<int> defaultAvatarPacks;

	// Token: 0x04002328 RID: 9000
	public List<int> defaultAvatarPacks1;

	// Token: 0x04002329 RID: 9001
	public List<int> defaultAvatarPacks2;

	// Token: 0x0400232A RID: 9002
	public List<int> avatarScreenAvatarPacks;

	// Token: 0x0400232B RID: 9003
	public List<int> avatarScreenAvatarPacks1;

	// Token: 0x0400232C RID: 9004
	public List<int> avatarScreenAvatarPacks2;

	// Token: 0x0400232D RID: 9005
	public List<int> avatarScreenAvatarExtensionPacks;

	// Token: 0x0400232E RID: 9006
	public List<string> inkStatVariables;

	// Token: 0x0400232F RID: 9007
	public List<int> inkStatVariablesDefaultValues;

	// Token: 0x04002330 RID: 9008
	public List<int> inkStatVariablesMinChapter;

	// Token: 0x04002331 RID: 9009
	public List<int> inkStatVariablesMinStory;

	// Token: 0x04002332 RID: 9010
	public List<int> rewardSceneIndices;

	// Token: 0x04002333 RID: 9011
	public bool ambientFreeAudio;

	// Token: 0x04002334 RID: 9012
	public bool enablePostEffects;

	// Token: 0x04002335 RID: 9013
	public bool ignoreAvatarFilterForLobby;

	// Token: 0x04002336 RID: 9014
	public bool enableSplashScreenAudio;

	// Token: 0x04002337 RID: 9015
	public List<CustomAvatarFilteringOptions> customAvatarFilteringOptions = new List<CustomAvatarFilteringOptions>();

	// Token: 0x04002338 RID: 9016
	public bool enableIconsPack;

	// Token: 0x04002339 RID: 9017
	public GKDCPMFMPMO avatarCustomizationType;

	// Token: 0x0400233A RID: 9018
	public int autoSuffixAndSyncAvatarsCount;

	// Token: 0x0400233B RID: 9019
	public int maxPersistentChatHistorySize = 16;

	// Token: 0x0400233C RID: 9020
	public bool syncWithPrequelAvatarSnapshots;

	// Token: 0x0400233D RID: 9021
	public List<CustomWardrobeSettings> customWardrobeSettings = new List<CustomWardrobeSettings>();

	// Token: 0x0400233E RID: 9022
	public List<CustomFaderSettings> customFaderSettings = new List<CustomFaderSettings>();

	// Token: 0x0400233F RID: 9023
	public List<int> customEffectsLoad = new List<int>();

	// Token: 0x04002340 RID: 9024
	[EAALFDOPIAF(EOJDHDECPFO.characterTransition)]
	public string defaultChoiceTransition = "";

	// Token: 0x04002341 RID: 9025
	[EAALFDOPIAF(EOJDHDECPFO.characterTransition)]
	public string defaultLoungeChoiceTransition = "";

	// Token: 0x04002342 RID: 9026
	[EAALFDOPIAF(EOJDHDECPFO.characterAcknowledge)]
	public string defaultAcknowledgeEffect = "";

	// Token: 0x04002343 RID: 9027
	[EAALFDOPIAF(EOJDHDECPFO.characterAcknowledge)]
	public string defaultLoungeAcknowledgeEffect = "";

	// Token: 0x04002344 RID: 9028
	public bool enableVoiceOverOptionInSettigs;

	// Token: 0x04002345 RID: 9029
	public bool shortGemsNumberFormat;

	// Token: 0x04002346 RID: 9030
	public bool addSpaceBeforeStatTitle = true;
}
