using System;

// Token: 0x020003B0 RID: 944
public class EPAGGJIALMP : KGLBKJKNPFD
{
	// Token: 0x06006E6B RID: 28267 RVA: 0x003265A7 File Offset: 0x003247A7
	public override bool BBHDMMHCDKO()
	{
		return this.BOPJOMGIJIA == EPAGGJIALMP.BMHGEBOHLHH.done;
	}

	// Token: 0x06006E6C RID: 28268 RVA: 0x0001FBB0 File Offset: 0x0001DDB0
	public override bool PINCOCDOOGH()
	{
		return false;
	}

	// Token: 0x06006E6D RID: 28269 RVA: 0x003265B2 File Offset: 0x003247B2
	public override void FEHODJMIAJL(int OIMDDBOOAOB = 1)
	{
		if (!this.BBHDMMHCDKO())
		{
			this.BOPJOMGIJIA += OIMDDBOOAOB;
		}
	}

	// Token: 0x06006E6E RID: 28270 RVA: 0x003265CA File Offset: 0x003247CA
	public override bool FMLECLNJAJM()
	{
		return this.BOPJOMGIJIA == (EPAGGJIALMP.BMHGEBOHLHH)this.KOIINMNNNDJ;
	}

	// Token: 0x06006E6F RID: 28271 RVA: 0x003265DA File Offset: 0x003247DA
	public override string LDHNPOGPAOB()
	{
		return this.BOPJOMGIJIA.ToString();
	}

	// Token: 0x06006E70 RID: 28272 RVA: 0x003265F0 File Offset: 0x003247F0
	public EPAGGJIALMP(string OFGJFNLDKGO)
	{
		this.OBKCKGHFMDN = KGLBKJKNPFD.LBFFMOMMAPK.chatDelay;
		this.JCIAOPBKNCH = HLDNEMHDEDH.NCIMIEAINEO(OFGJFNLDKGO, "time(", ')', true);
		this.JCIAOPBKNCH *= AppManager.EHBBFMCILPC.debugSettings.OAEBOACHHOG(1f);
	}

	// Token: 0x040020B5 RID: 8373
	public EPAGGJIALMP.BMHGEBOHLHH BOPJOMGIJIA;

	// Token: 0x040020B6 RID: 8374
	public float JCIAOPBKNCH;

	// Token: 0x020003B1 RID: 945
	public enum BMHGEBOHLHH
	{
		// Token: 0x040020B8 RID: 8376
		start,
		// Token: 0x040020B9 RID: 8377
		done
	}
}
