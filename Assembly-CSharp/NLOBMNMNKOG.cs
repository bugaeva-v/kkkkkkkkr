using System;

// Token: 0x0200037F RID: 895
public class NLOBMNMNKOG : KGLBKJKNPFD
{
	// Token: 0x060068CD RID: 26829 RVA: 0x0001FBB0 File Offset: 0x0001DDB0
	public override bool PINCOCDOOGH()
	{
		return false;
	}

	// Token: 0x060068CE RID: 26830 RVA: 0x00302A71 File Offset: 0x00300C71
	public override string LDHNPOGPAOB()
	{
		return this.BOPJOMGIJIA.ToString();
	}

	// Token: 0x060068CF RID: 26831 RVA: 0x00302A84 File Offset: 0x00300C84
	public override bool FMLECLNJAJM()
	{
		return this.BOPJOMGIJIA == (NLOBMNMNKOG.BMHGEBOHLHH)this.KOIINMNNNDJ;
	}

	// Token: 0x060068D0 RID: 26832 RVA: 0x00302A94 File Offset: 0x00300C94
	public override void FEHODJMIAJL(int OIMDDBOOAOB = 1)
	{
		if (!this.BBHDMMHCDKO())
		{
			this.BOPJOMGIJIA += OIMDDBOOAOB;
		}
	}

	// Token: 0x060068D1 RID: 26833 RVA: 0x00302AAC File Offset: 0x00300CAC
	public NLOBMNMNKOG(string OFGJFNLDKGO)
	{
		this.OBKCKGHFMDN = KGLBKJKNPFD.LBFFMOMMAPK.avatarLock;
	}

	// Token: 0x060068D2 RID: 26834 RVA: 0x00302ABC File Offset: 0x00300CBC
	public override bool BBHDMMHCDKO()
	{
		return this.BOPJOMGIJIA == NLOBMNMNKOG.BMHGEBOHLHH.done;
	}

	// Token: 0x04001EFC RID: 7932
	public NLOBMNMNKOG.BMHGEBOHLHH BOPJOMGIJIA;

	// Token: 0x02000380 RID: 896
	public enum BMHGEBOHLHH
	{
		// Token: 0x04001EFE RID: 7934
		start,
		// Token: 0x04001EFF RID: 7935
		done
	}
}
