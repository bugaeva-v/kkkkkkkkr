using System;
using System.Collections.Generic;

// Token: 0x02000390 RID: 912
public class ALPHHLOPBLC : KGLBKJKNPFD
{
	// Token: 0x06006B77 RID: 27511 RVA: 0x00311EF0 File Offset: 0x003100F0
	public override string LDHNPOGPAOB()
	{
		return this.BOPJOMGIJIA.ToString();
	}

	// Token: 0x06006B78 RID: 27512 RVA: 0x00311F04 File Offset: 0x00310104
	public ALPHHLOPBLC(string OFGJFNLDKGO)
	{
		this.OBKCKGHFMDN = KGLBKJKNPFD.LBFFMOMMAPK.achievementUnlock;
		if (OFGJFNLDKGO.Contains("id"))
		{
			this.FNAOJFMDPEL = HLDNEMHDEDH.LNLOHDKFDAA(OFGJFNLDKGO, "id(", ')', true);
		}
		if (OFGJFNLDKGO.Contains("token"))
		{
			this.ENBBONPKHBC = HLDNEMHDEDH.LNLOHDKFDAA(OFGJFNLDKGO, "token(", ')', true);
		}
		if (OFGJFNLDKGO.Contains("isbitset"))
		{
			this.ONBBPLAIGDF = HLDNEMHDEDH.NAPCGMAHBBA(OFGJFNLDKGO, "isbitset(", ')', true);
		}
	}

	// Token: 0x06006B79 RID: 27513 RVA: 0x00311FA3 File Offset: 0x003101A3
	public override void FEHODJMIAJL(int OIMDDBOOAOB = 1)
	{
		if (!this.BBHDMMHCDKO())
		{
			this.BOPJOMGIJIA += OIMDDBOOAOB;
		}
	}

	// Token: 0x06006B7A RID: 27514 RVA: 0x00311FBB File Offset: 0x003101BB
	public override bool FMLECLNJAJM()
	{
		return this.BOPJOMGIJIA == (ALPHHLOPBLC.BMHGEBOHLHH)this.KOIINMNNNDJ;
	}

	// Token: 0x06006B7B RID: 27515 RVA: 0x00311FCB File Offset: 0x003101CB
	public override bool BBHDMMHCDKO()
	{
		return this.BOPJOMGIJIA == ALPHHLOPBLC.BMHGEBOHLHH.done;
	}

	// Token: 0x06006B7C RID: 27516 RVA: 0x0001FBB0 File Offset: 0x0001DDB0
	public override bool PINCOCDOOGH()
	{
		return false;
	}

	// Token: 0x04001F6E RID: 8046
	public ALPHHLOPBLC.BMHGEBOHLHH BOPJOMGIJIA;

	// Token: 0x04001F6F RID: 8047
	public string FNAOJFMDPEL = "";

	// Token: 0x04001F70 RID: 8048
	public string ENBBONPKHBC = "";

	// Token: 0x04001F71 RID: 8049
	public List<int> ONBBPLAIGDF = new List<int>();

	// Token: 0x02000391 RID: 913
	public enum BMHGEBOHLHH
	{
		// Token: 0x04001F73 RID: 8051
		start,
		// Token: 0x04001F74 RID: 8052
		delay,
		// Token: 0x04001F75 RID: 8053
		waitingForBackend,
		// Token: 0x04001F76 RID: 8054
		done
	}
}
