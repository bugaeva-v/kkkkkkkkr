using System;

// Token: 0x02000131 RID: 305
public class LDPKIDKFDKG : KGLBKJKNPFD
{
	// Token: 0x0600284C RID: 10316 RVA: 0x00123D96 File Offset: 0x00121F96
	public override bool BBHDMMHCDKO()
	{
		return this.BOPJOMGIJIA == LDPKIDKFDKG.BMHGEBOHLHH.done;
	}

	// Token: 0x0600284D RID: 10317 RVA: 0x0001FBB0 File Offset: 0x0001DDB0
	public override bool PINCOCDOOGH()
	{
		return false;
	}

	// Token: 0x0600284E RID: 10318 RVA: 0x00123DA4 File Offset: 0x00121FA4
	public LDPKIDKFDKG(string OFGJFNLDKGO)
	{
		this.OBKCKGHFMDN = KGLBKJKNPFD.LBFFMOMMAPK.delay;
		this.JCIAOPBKNCH = HLDNEMHDEDH.NCIMIEAINEO(OFGJFNLDKGO, "time(", ')', true);
		this.JCIAOPBKNCH *= AppManager.EHBBFMCILPC.debugSettings.OAEBOACHHOG(1f);
	}

	// Token: 0x0600284F RID: 10319 RVA: 0x00123DF4 File Offset: 0x00121FF4
	public override string LDHNPOGPAOB()
	{
		return this.BOPJOMGIJIA.ToString();
	}

	// Token: 0x06002850 RID: 10320 RVA: 0x00123E07 File Offset: 0x00122007
	public override void FEHODJMIAJL(int OIMDDBOOAOB = 1)
	{
		if (!this.BBHDMMHCDKO())
		{
			this.BOPJOMGIJIA += OIMDDBOOAOB;
		}
	}

	// Token: 0x06002851 RID: 10321 RVA: 0x00123E1F File Offset: 0x0012201F
	public override bool FMLECLNJAJM()
	{
		return this.BOPJOMGIJIA == (LDPKIDKFDKG.BMHGEBOHLHH)this.KOIINMNNNDJ;
	}

	// Token: 0x04000C72 RID: 3186
	public LDPKIDKFDKG.BMHGEBOHLHH BOPJOMGIJIA;

	// Token: 0x04000C73 RID: 3187
	public float JCIAOPBKNCH;

	// Token: 0x02000132 RID: 306
	public enum BMHGEBOHLHH
	{
		// Token: 0x04000C75 RID: 3189
		start,
		// Token: 0x04000C76 RID: 3190
		done
	}
}
