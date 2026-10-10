using System;
using System.Collections.Generic;

// Token: 0x02000395 RID: 917
public class CFAMJFEPAAG : KGLBKJKNPFD
{
	// Token: 0x06006B7D RID: 27517 RVA: 0x00311FD6 File Offset: 0x003101D6
	public override bool FMLECLNJAJM()
	{
		return this.BOPJOMGIJIA == (CFAMJFEPAAG.BMHGEBOHLHH)this.KOIINMNNNDJ;
	}

	// Token: 0x06006B7E RID: 27518 RVA: 0x00311FE6 File Offset: 0x003101E6
	public override string LDHNPOGPAOB()
	{
		return this.BOPJOMGIJIA.ToString();
	}

	// Token: 0x06006B7F RID: 27519 RVA: 0x00311FF9 File Offset: 0x003101F9
	public override bool BBHDMMHCDKO()
	{
		return this.BOPJOMGIJIA == CFAMJFEPAAG.BMHGEBOHLHH.done;
	}

	// Token: 0x06006B80 RID: 27520 RVA: 0x00312004 File Offset: 0x00310204
	public CFAMJFEPAAG(string OFGJFNLDKGO)
	{
		this.OBKCKGHFMDN = KGLBKJKNPFD.LBFFMOMMAPK.emotionLoopStart;
		List<string> list = new List<string>();
		if (OFGJFNLDKGO.Contains("emotion("))
		{
			list = HLDNEMHDEDH.NNKLPOAODNF(OFGJFNLDKGO, "emotion(", ')', true);
		}
		else if (OFGJFNLDKGO.Contains("emotions("))
		{
			list = HLDNEMHDEDH.NNKLPOAODNF(OFGJFNLDKGO, "emotions(", ')', true);
		}
		for (int i = 0; i < list.Count; i++)
		{
			this.PPMGNKCCIPG.Add(AssetAvatarComponent.EIGIDJLDCLH(list[i]));
		}
		if (OFGJFNLDKGO.Contains("time"))
		{
			this.MIIILPBNHHA = HLDNEMHDEDH.KKCGKPNINIJ(OFGJFNLDKGO, "time(", ')', true);
		}
		if (this.PPMGNKCCIPG.Count != this.MIIILPBNHHA.Count)
		{
			DPGJIJGOCIC.ANOPFDLPKGC("StoryStepEmotionLoopStart(): emotionList.Count != timingList.Count.");
		}
		if (OFGJFNLDKGO.Contains("id"))
		{
			this.GEODIDKODMB = HLDNEMHDEDH.LNLOHDKFDAA(OFGJFNLDKGO, "id(", ')', true);
		}
		if (OFGJFNLDKGO.Contains("flags("))
		{
			this.NGNDOALIKAK = HLDNEMHDEDH.NNKLPOAODNF(OFGJFNLDKGO, "flags(", ')', true);
		}
	}

	// Token: 0x06006B81 RID: 27521 RVA: 0x0001FBB0 File Offset: 0x0001DDB0
	public override bool PINCOCDOOGH()
	{
		return false;
	}

	// Token: 0x06006B82 RID: 27522 RVA: 0x00312138 File Offset: 0x00310338
	public override void FEHODJMIAJL(int OIMDDBOOAOB = 1)
	{
		if (!this.BBHDMMHCDKO())
		{
			this.BOPJOMGIJIA += OIMDDBOOAOB;
		}
	}

	// Token: 0x04001F85 RID: 8069
	public CFAMJFEPAAG.BMHGEBOHLHH BOPJOMGIJIA;

	// Token: 0x04001F86 RID: 8070
	public List<FLNOFHCNJDM> PPMGNKCCIPG = new List<FLNOFHCNJDM>();

	// Token: 0x04001F87 RID: 8071
	public List<float> MIIILPBNHHA = new List<float>();

	// Token: 0x04001F88 RID: 8072
	public string GEODIDKODMB = "";

	// Token: 0x04001F89 RID: 8073
	public List<string> NGNDOALIKAK = new List<string>();

	// Token: 0x02000396 RID: 918
	public enum BMHGEBOHLHH
	{
		// Token: 0x04001F8B RID: 8075
		start,
		// Token: 0x04001F8C RID: 8076
		done
	}
}
