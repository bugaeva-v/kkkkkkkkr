using System;

// Token: 0x0200014D RID: 333
public class MDNBCCCEJBF : KGLBKJKNPFD
{
	// Token: 0x06002C7A RID: 11386 RVA: 0x00138BF8 File Offset: 0x00136DF8
	public MDNBCCCEJBF(string OFGJFNLDKGO)
	{
		this.OBKCKGHFMDN = KGLBKJKNPFD.LBFFMOMMAPK.npcFadeOut;
		this.PMMCLCMDNGA = HLDNEMHDEDH.NCIMIEAINEO(OFGJFNLDKGO, "time(", ')', true);
		this.PMMCLCMDNGA *= AppManager.EHBBFMCILPC.debugSettings.OAEBOACHHOG(1f);
		if (OFGJFNLDKGO.Contains("delay"))
		{
			this.EBMMGNEEBIC = HLDNEMHDEDH.NCIMIEAINEO(OFGJFNLDKGO, "delay(", ')', true);
			this.EBMMGNEEBIC *= AppManager.EHBBFMCILPC.debugSettings.OAEBOACHHOG(1f);
		}
	}

	// Token: 0x06002C7B RID: 11387 RVA: 0x00138C95 File Offset: 0x00136E95
	public override bool FMLECLNJAJM()
	{
		return this.BOPJOMGIJIA == (MDNBCCCEJBF.BMHGEBOHLHH)this.KOIINMNNNDJ;
	}

	// Token: 0x06002C7C RID: 11388 RVA: 0x00138CA5 File Offset: 0x00136EA5
	public override bool BBHDMMHCDKO()
	{
		return this.BOPJOMGIJIA == MDNBCCCEJBF.BMHGEBOHLHH.done;
	}

	// Token: 0x06002C7D RID: 11389 RVA: 0x0001FBB0 File Offset: 0x0001DDB0
	public override bool PINCOCDOOGH()
	{
		return false;
	}

	// Token: 0x06002C7E RID: 11390 RVA: 0x00138CB0 File Offset: 0x00136EB0
	public override string LDHNPOGPAOB()
	{
		return this.BOPJOMGIJIA.ToString();
	}

	// Token: 0x06002C7F RID: 11391 RVA: 0x00138CC3 File Offset: 0x00136EC3
	public override void FEHODJMIAJL(int OIMDDBOOAOB = 1)
	{
		if (!this.BBHDMMHCDKO())
		{
			this.BOPJOMGIJIA += OIMDDBOOAOB;
		}
	}

	// Token: 0x04000D22 RID: 3362
	public MDNBCCCEJBF.BMHGEBOHLHH BOPJOMGIJIA;

	// Token: 0x04000D23 RID: 3363
	public float PMMCLCMDNGA = 1f;

	// Token: 0x04000D24 RID: 3364
	public float EBMMGNEEBIC;

	// Token: 0x0200014E RID: 334
	public enum BMHGEBOHLHH
	{
		// Token: 0x04000D26 RID: 3366
		start,
		// Token: 0x04000D27 RID: 3367
		fadeOutDone,
		// Token: 0x04000D28 RID: 3368
		delayBeforeDone,
		// Token: 0x04000D29 RID: 3369
		done
	}
}
