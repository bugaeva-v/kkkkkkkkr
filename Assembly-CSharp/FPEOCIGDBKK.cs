using System;

// Token: 0x020004C6 RID: 1222
public class FPEOCIGDBKK : KGLBKJKNPFD
{
	// Token: 0x06009315 RID: 37653 RVA: 0x0040F37F File Offset: 0x0040D57F
	public override bool FMLECLNJAJM()
	{
		return this.BOPJOMGIJIA == (FPEOCIGDBKK.BMHGEBOHLHH)this.KOIINMNNNDJ;
	}

	// Token: 0x06009316 RID: 37654 RVA: 0x0040F38F File Offset: 0x0040D58F
	public override string LDHNPOGPAOB()
	{
		return this.BOPJOMGIJIA.ToString();
	}

	// Token: 0x06009317 RID: 37655 RVA: 0x0040F3A2 File Offset: 0x0040D5A2
	public FPEOCIGDBKK(string OFGJFNLDKGO)
	{
		this.OBKCKGHFMDN = KGLBKJKNPFD.LBFFMOMMAPK.preloadAsset;
	}

	// Token: 0x06009318 RID: 37656 RVA: 0x0040F3B2 File Offset: 0x0040D5B2
	public override void FEHODJMIAJL(int OIMDDBOOAOB = 1)
	{
		if (!this.BBHDMMHCDKO())
		{
			this.BOPJOMGIJIA += OIMDDBOOAOB;
		}
	}

	// Token: 0x06009319 RID: 37657 RVA: 0x0001FBB0 File Offset: 0x0001DDB0
	public override bool PINCOCDOOGH()
	{
		return false;
	}

	// Token: 0x0600931A RID: 37658 RVA: 0x0040F3CA File Offset: 0x0040D5CA
	public override bool BBHDMMHCDKO()
	{
		return this.BOPJOMGIJIA == FPEOCIGDBKK.BMHGEBOHLHH.done;
	}

	// Token: 0x04002914 RID: 10516
	public FPEOCIGDBKK.BMHGEBOHLHH BOPJOMGIJIA;

	// Token: 0x020004C7 RID: 1223
	public enum BMHGEBOHLHH
	{
		// Token: 0x04002916 RID: 10518
		start,
		// Token: 0x04002917 RID: 10519
		done
	}
}
