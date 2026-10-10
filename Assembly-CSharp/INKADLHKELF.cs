using System;

// Token: 0x0200014B RID: 331
public class INKADLHKELF : KGLBKJKNPFD
{
	// Token: 0x06002C74 RID: 11380 RVA: 0x00138B7A File Offset: 0x00136D7A
	public INKADLHKELF(string OFGJFNLDKGO)
	{
		this.OBKCKGHFMDN = KGLBKJKNPFD.LBFFMOMMAPK.restoreAvatarSnapshot;
		if (OFGJFNLDKGO.Contains("index("))
		{
			this.NFDKDACMHME = HLDNEMHDEDH.OKNGPMCDBFE(OFGJFNLDKGO, "index(", ')', true);
		}
	}

	// Token: 0x06002C75 RID: 11381 RVA: 0x00138BB2 File Offset: 0x00136DB2
	public override string LDHNPOGPAOB()
	{
		return this.BOPJOMGIJIA.ToString();
	}

	// Token: 0x06002C76 RID: 11382 RVA: 0x00138BC5 File Offset: 0x00136DC5
	public override void FEHODJMIAJL(int OIMDDBOOAOB = 1)
	{
		if (!this.BBHDMMHCDKO())
		{
			this.BOPJOMGIJIA += OIMDDBOOAOB;
		}
	}

	// Token: 0x06002C77 RID: 11383 RVA: 0x00138BDD File Offset: 0x00136DDD
	public override bool BBHDMMHCDKO()
	{
		return this.BOPJOMGIJIA == INKADLHKELF.BMHGEBOHLHH.done;
	}

	// Token: 0x06002C78 RID: 11384 RVA: 0x0001FBB0 File Offset: 0x0001DDB0
	public override bool PINCOCDOOGH()
	{
		return false;
	}

	// Token: 0x06002C79 RID: 11385 RVA: 0x00138BE8 File Offset: 0x00136DE8
	public override bool FMLECLNJAJM()
	{
		return this.BOPJOMGIJIA == (INKADLHKELF.BMHGEBOHLHH)this.KOIINMNNNDJ;
	}

	// Token: 0x04000D1D RID: 3357
	public int NFDKDACMHME = -1;

	// Token: 0x04000D1E RID: 3358
	public INKADLHKELF.BMHGEBOHLHH BOPJOMGIJIA;

	// Token: 0x0200014C RID: 332
	public enum BMHGEBOHLHH
	{
		// Token: 0x04000D20 RID: 3360
		start,
		// Token: 0x04000D21 RID: 3361
		done
	}
}
