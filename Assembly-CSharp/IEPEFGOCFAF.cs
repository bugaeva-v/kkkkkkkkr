using System;
using System.Collections.Generic;

// Token: 0x020000B0 RID: 176
public class IEPEFGOCFAF : KGLBKJKNPFD
{
	// Token: 0x0600187D RID: 6269 RVA: 0x0001FBB0 File Offset: 0x0001DDB0
	public override bool PINCOCDOOGH()
	{
		return false;
	}

	// Token: 0x0600187E RID: 6270 RVA: 0x000B0A64 File Offset: 0x000AEC64
	public IEPEFGOCFAF(string OFGJFNLDKGO)
	{
		this.OBKCKGHFMDN = KGLBKJKNPFD.LBFFMOMMAPK.chatDiscard;
		this.BFJIAPJJLDD = HLDNEMHDEDH.NNKLPOAODNF(OFGJFNLDKGO, "session(", ')', true);
	}

	// Token: 0x0600187F RID: 6271 RVA: 0x000B0A93 File Offset: 0x000AEC93
	public override bool FMLECLNJAJM()
	{
		return this.BOPJOMGIJIA == (IEPEFGOCFAF.BMHGEBOHLHH)this.KOIINMNNNDJ;
	}

	// Token: 0x06001880 RID: 6272 RVA: 0x000B0AA3 File Offset: 0x000AECA3
	public override string LDHNPOGPAOB()
	{
		return this.BOPJOMGIJIA.ToString();
	}

	// Token: 0x06001881 RID: 6273 RVA: 0x000B0AB6 File Offset: 0x000AECB6
	public override bool BBHDMMHCDKO()
	{
		return this.BOPJOMGIJIA == IEPEFGOCFAF.BMHGEBOHLHH.done;
	}

	// Token: 0x06001882 RID: 6274 RVA: 0x000B0AC1 File Offset: 0x000AECC1
	public override void FEHODJMIAJL(int OIMDDBOOAOB = 1)
	{
		if (!this.BBHDMMHCDKO())
		{
			this.BOPJOMGIJIA += OIMDDBOOAOB;
		}
	}

	// Token: 0x0400071E RID: 1822
	public IEPEFGOCFAF.BMHGEBOHLHH BOPJOMGIJIA;

	// Token: 0x0400071F RID: 1823
	public List<string> BFJIAPJJLDD = new List<string>();

	// Token: 0x020000B1 RID: 177
	public enum BMHGEBOHLHH
	{
		// Token: 0x04000721 RID: 1825
		start,
		// Token: 0x04000722 RID: 1826
		done
	}
}
