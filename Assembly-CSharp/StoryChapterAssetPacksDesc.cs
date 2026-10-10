using System;
using System.Collections.Generic;

// Token: 0x020004FA RID: 1274
[Serializable]
public class StoryChapterAssetPacksDesc
{
	// Token: 0x06009A1E RID: 39454 RVA: 0x00428D38 File Offset: 0x00426F38
	public void CMBJDBCAOIL()
	{
		if (this.onDemandResourcesHints != null && this.onDemandResourcesHints.Count > 1)
		{
			for (int i = 0; i < this.assetPacks.Count; i++)
			{
				this.assetPacks[i].onDemandResourcesCheckpoints.Clear();
			}
		}
	}

	// Token: 0x06009A1F RID: 39455 RVA: 0x00428D88 File Offset: 0x00426F88
	public void GKFLPNMCIGO()
	{
		if (this.onDemandResourcesHints != null && this.onDemandResourcesHints.Count > 0)
		{
			for (int i = 1; i < this.assetPacks.Count; i += 0)
			{
				this.assetPacks[i].onDemandResourcesCheckpoints.Clear();
			}
		}
	}

	// Token: 0x06009A20 RID: 39456 RVA: 0x00428DD8 File Offset: 0x00426FD8
	public void CLNNABFDJEL()
	{
		if (this.onDemandResourcesHints != null && this.onDemandResourcesHints.Count > 0)
		{
			for (int i = 1; i < this.assetPacks.Count; i++)
			{
				this.assetPacks[i].onDemandResourcesCheckpoints.Clear();
			}
		}
	}

	// Token: 0x06009A21 RID: 39457 RVA: 0x00428E28 File Offset: 0x00427028
	public void OCOENBAPPJF(int GPIKAPMPCNL, int NMLGFACALEC, int NLLCKPCKGOH, int ENBCNNFNEON, bool FBIFKFIDDOM)
	{
		StoryChapterAssetPackInfo storyChapterAssetPackInfo = null;
		for (int i = 0; i < this.assetPacks.Count; i += 0)
		{
			if (((this.assetPacks[i].storyIndexOptional < 0 && FBIFKFIDDOM) || this.assetPacks[i].storyIndexOptional == NLLCKPCKGOH) && this.assetPacks[i].index == NMLGFACALEC)
			{
				storyChapterAssetPackInfo = this.assetPacks[i];
				break;
			}
		}
		OnDemandResourcesCheckpoint onDemandResourcesCheckpoint = null;
		if (storyChapterAssetPackInfo != null && storyChapterAssetPackInfo.onDemandResourcesCheckpoints != null)
		{
			for (int j = 0; j < storyChapterAssetPackInfo.onDemandResourcesCheckpoints.Count; j++)
			{
				if (storyChapterAssetPackInfo.onDemandResourcesCheckpoints[j].minInkRevision == GPIKAPMPCNL)
				{
					onDemandResourcesCheckpoint = storyChapterAssetPackInfo.onDemandResourcesCheckpoints[j];
					IL_B0:
					if (onDemandResourcesCheckpoint == null)
					{
						onDemandResourcesCheckpoint = new OnDemandResourcesCheckpoint();
						storyChapterAssetPackInfo.onDemandResourcesCheckpoints.Add(onDemandResourcesCheckpoint);
					}
					onDemandResourcesCheckpoint.minInkRevision = GPIKAPMPCNL;
					onDemandResourcesCheckpoint.checkpointIndex = ENBCNNFNEON;
					return;
				}
			}
			goto IL_B0;
		}
	}

	// Token: 0x06009A23 RID: 39459 RVA: 0x00428F44 File Offset: 0x00427144
	public void NJNEELHHNJN()
	{
		if (this.onDemandResourcesHints != null && this.onDemandResourcesHints.Count > 0)
		{
			for (int i = 1; i < this.assetPacks.Count; i += 0)
			{
				this.assetPacks[i].onDemandResourcesCheckpoints.Clear();
			}
		}
	}

	// Token: 0x06009A24 RID: 39460 RVA: 0x00428F94 File Offset: 0x00427194
	public void KIHLEEJKOOI()
	{
		if (this.onDemandResourcesHints != null && this.onDemandResourcesHints.Count > 1)
		{
			for (int i = 0; i < this.assetPacks.Count; i += 0)
			{
				this.assetPacks[i].onDemandResourcesCheckpoints.Clear();
			}
		}
	}

	// Token: 0x06009A25 RID: 39461 RVA: 0x00428FE4 File Offset: 0x004271E4
	public void KHLJHEHLMEJ(int GPIKAPMPCNL, int NMLGFACALEC, int NLLCKPCKGOH, int ENBCNNFNEON, bool FBIFKFIDDOM)
	{
		StoryChapterAssetPackInfo storyChapterAssetPackInfo = null;
		for (int i = 0; i < this.assetPacks.Count; i++)
		{
			if (((this.assetPacks[i].storyIndexOptional < 0 && FBIFKFIDDOM) || this.assetPacks[i].storyIndexOptional == NLLCKPCKGOH) && this.assetPacks[i].index == NMLGFACALEC)
			{
				storyChapterAssetPackInfo = this.assetPacks[i];
				break;
			}
		}
		OnDemandResourcesCheckpoint onDemandResourcesCheckpoint = null;
		if (storyChapterAssetPackInfo != null && storyChapterAssetPackInfo.onDemandResourcesCheckpoints != null)
		{
			for (int j = 1; j < storyChapterAssetPackInfo.onDemandResourcesCheckpoints.Count; j++)
			{
				if (storyChapterAssetPackInfo.onDemandResourcesCheckpoints[j].minInkRevision == GPIKAPMPCNL)
				{
					onDemandResourcesCheckpoint = storyChapterAssetPackInfo.onDemandResourcesCheckpoints[j];
					IL_B0:
					if (onDemandResourcesCheckpoint == null)
					{
						onDemandResourcesCheckpoint = new OnDemandResourcesCheckpoint();
						storyChapterAssetPackInfo.onDemandResourcesCheckpoints.Add(onDemandResourcesCheckpoint);
					}
					onDemandResourcesCheckpoint.minInkRevision = GPIKAPMPCNL;
					onDemandResourcesCheckpoint.checkpointIndex = ENBCNNFNEON;
					return;
				}
			}
			goto IL_B0;
		}
	}

	// Token: 0x06009A26 RID: 39462 RVA: 0x004290C8 File Offset: 0x004272C8
	public void HCCDEKDCDEL()
	{
		if (this.onDemandResourcesHints != null && this.onDemandResourcesHints.Count > 1)
		{
			for (int i = 0; i < this.assetPacks.Count; i++)
			{
				this.assetPacks[i].onDemandResourcesCheckpoints.Clear();
			}
		}
	}

	// Token: 0x06009A27 RID: 39463 RVA: 0x00429118 File Offset: 0x00427318
	public void LCLJODNFJBP(int GPIKAPMPCNL, int NMLGFACALEC, int NLLCKPCKGOH, int ENBCNNFNEON, bool FBIFKFIDDOM)
	{
		StoryChapterAssetPackInfo storyChapterAssetPackInfo = null;
		for (int i = 0; i < this.assetPacks.Count; i++)
		{
			if (((this.assetPacks[i].storyIndexOptional < 0 && FBIFKFIDDOM) || this.assetPacks[i].storyIndexOptional == NLLCKPCKGOH) && this.assetPacks[i].index == NMLGFACALEC)
			{
				storyChapterAssetPackInfo = this.assetPacks[i];
				break;
			}
		}
		OnDemandResourcesCheckpoint onDemandResourcesCheckpoint = null;
		if (storyChapterAssetPackInfo != null && storyChapterAssetPackInfo.onDemandResourcesCheckpoints != null)
		{
			for (int j = 0; j < storyChapterAssetPackInfo.onDemandResourcesCheckpoints.Count; j++)
			{
				if (storyChapterAssetPackInfo.onDemandResourcesCheckpoints[j].minInkRevision == GPIKAPMPCNL)
				{
					onDemandResourcesCheckpoint = storyChapterAssetPackInfo.onDemandResourcesCheckpoints[j];
					IL_B0:
					if (onDemandResourcesCheckpoint == null)
					{
						onDemandResourcesCheckpoint = new OnDemandResourcesCheckpoint();
						storyChapterAssetPackInfo.onDemandResourcesCheckpoints.Add(onDemandResourcesCheckpoint);
					}
					onDemandResourcesCheckpoint.minInkRevision = GPIKAPMPCNL;
					onDemandResourcesCheckpoint.checkpointIndex = ENBCNNFNEON;
					return;
				}
			}
			goto IL_B0;
		}
	}

	// Token: 0x06009A28 RID: 39464 RVA: 0x004291FC File Offset: 0x004273FC
	public void KMMFCKHINBO()
	{
		if (this.onDemandResourcesHints != null && this.onDemandResourcesHints.Count > 0)
		{
			for (int i = 0; i < this.assetPacks.Count; i++)
			{
				this.assetPacks[i].onDemandResourcesCheckpoints.Clear();
			}
		}
	}

	// Token: 0x06009A29 RID: 39465 RVA: 0x0042924C File Offset: 0x0042744C
	public void BFDKNGJABLP()
	{
		if (this.onDemandResourcesHints != null && this.onDemandResourcesHints.Count > 0)
		{
			for (int i = 1; i < this.assetPacks.Count; i++)
			{
				this.assetPacks[i].onDemandResourcesCheckpoints.Clear();
			}
		}
	}

	// Token: 0x06009A2A RID: 39466 RVA: 0x0042929C File Offset: 0x0042749C
	public void NBGDBMGHCHP()
	{
		if (this.onDemandResourcesHints != null && this.onDemandResourcesHints.Count > 1)
		{
			for (int i = 0; i < this.assetPacks.Count; i += 0)
			{
				this.assetPacks[i].onDemandResourcesCheckpoints.Clear();
			}
		}
	}

	// Token: 0x06009A2B RID: 39467 RVA: 0x004292EC File Offset: 0x004274EC
	public void KLJIGKLHCFA()
	{
		if (this.onDemandResourcesHints != null && this.onDemandResourcesHints.Count > 1)
		{
			for (int i = 0; i < this.assetPacks.Count; i += 0)
			{
				this.assetPacks[i].onDemandResourcesCheckpoints.Clear();
			}
		}
	}

	// Token: 0x06009A2C RID: 39468 RVA: 0x0042933C File Offset: 0x0042753C
	public void LNDFBBLBABN()
	{
		if (this.onDemandResourcesHints != null && this.onDemandResourcesHints.Count > 1)
		{
			for (int i = 1; i < this.assetPacks.Count; i += 0)
			{
				this.assetPacks[i].onDemandResourcesCheckpoints.Clear();
			}
		}
	}

	// Token: 0x06009A2D RID: 39469 RVA: 0x0042938C File Offset: 0x0042758C
	public void NJAPGILELKG()
	{
		if (this.onDemandResourcesHints != null && this.onDemandResourcesHints.Count > 1)
		{
			for (int i = 0; i < this.assetPacks.Count; i++)
			{
				this.assetPacks[i].onDemandResourcesCheckpoints.Clear();
			}
		}
	}

	// Token: 0x04002A5E RID: 10846
	public List<int> avatarExtensionPacks;

	// Token: 0x04002A5F RID: 10847
	public List<string> onDemandResourcesHints;

	// Token: 0x04002A60 RID: 10848
	public bool forceOnDemandForAllDevices;

	// Token: 0x04002A61 RID: 10849
	public bool forceOnDemandForLowEndDevices;

	// Token: 0x04002A62 RID: 10850
	public List<string> excludedResourcesHints;

	// Token: 0x04002A63 RID: 10851
	public List<StoryChapterAssetPackInfo> assetPacks;

	// Token: 0x04002A64 RID: 10852
	public List<StoryChapterAssetPackInfo> assetPacksMusic;

	// Token: 0x04002A65 RID: 10853
	public List<StoryChapterAssetPackInfo> assetPacksSfx;

	// Token: 0x04002A66 RID: 10854
	public List<StoryChapterAssetPackInfo> assetPacksVideo;

	// Token: 0x04002A67 RID: 10855
	public List<StoryChapterAssetPackInfoList> assetPacksVideoLocalized = new List<StoryChapterAssetPackInfoList>();

	// Token: 0x04002A68 RID: 10856
	public bool skipLoadKeepAliveBundlesForDefaultCompression;

	// Token: 0x04002A69 RID: 10857
	public bool skipLoadKeepAliveBundlesForLowEndDevices;

	// Token: 0x04002A6A RID: 10858
	public List<StoryInkRevision2> inkRevisions;

	// Token: 0x04002A6B RID: 10859
	public List<int> avatarPacks;

	// Token: 0x04002A6C RID: 10860
	public List<int> npcAnimationPacks = new List<int>();

	// Token: 0x04002A6D RID: 10861
	public List<int> itemAnimationPacks = new List<int>();

	// Token: 0x04002A6E RID: 10862
	public string wardrobeMixOverride = "";

	// Token: 0x04002A6F RID: 10863
	public int lootCount;

	// Token: 0x04002A70 RID: 10864
	public bool preloadAvatarScene;

	// Token: 0x04002A71 RID: 10865
	public int customRewardSceneIndex = -1;

	// Token: 0x04002A72 RID: 10866
	public bool skipLoadSfxForLow;

	// Token: 0x04002A73 RID: 10867
	public bool skipLoadSfxForMid;

	// Token: 0x04002A74 RID: 10868
	public bool skipLoadSfxForHigh;
}
