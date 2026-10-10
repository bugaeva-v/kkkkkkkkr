using System;

// Token: 0x02000156 RID: 342
public class ELFBAKJMBOA : KGLBKJKNPFD
{
	// Token: 0x06002CBC RID: 11452 RVA: 0x0001FBB0 File Offset: 0x0001DDB0
	public override bool PINCOCDOOGH()
	{
		return false;
	}

	// Token: 0x06002CBD RID: 11453 RVA: 0x00139334 File Offset: 0x00137534
	public ELFBAKJMBOA(string OFGJFNLDKGO)
	{
		this.OBKCKGHFMDN = KGLBKJKNPFD.LBFFMOMMAPK.getVar;
		this.LOLCBCKJODA = HLDNEMHDEDH.LNLOHDKFDAA(OFGJFNLDKGO, "get(", ')', true);
		this.EHELHLOCOGG = HLDNEMHDEDH.LNLOHDKFDAA(OFGJFNLDKGO, "set(", ')', true);
		if (OFGJFNLDKGO.Contains("story("))
		{
			this.IFCHGNCDMLJ = HLDNEMHDEDH.OKNGPMCDBFE(OFGJFNLDKGO, "story(", ')', true);
		}
		if (OFGJFNLDKGO.Contains("anthology("))
		{
			this.AMKCLHLIIMN = HLDNEMHDEDH.OKNGPMCDBFE(OFGJFNLDKGO, "anthology(", ')', true);
		}
	}

	// Token: 0x06002CBE RID: 11454 RVA: 0x001393DD File Offset: 0x001375DD
	public override bool BBHDMMHCDKO()
	{
		return this.BOPJOMGIJIA == ELFBAKJMBOA.BMHGEBOHLHH.done;
	}

	// Token: 0x06002CBF RID: 11455 RVA: 0x001393E8 File Offset: 0x001375E8
	public override bool FMLECLNJAJM()
	{
		return this.BOPJOMGIJIA == (ELFBAKJMBOA.BMHGEBOHLHH)this.KOIINMNNNDJ;
	}

	// Token: 0x06002CC0 RID: 11456 RVA: 0x001393F8 File Offset: 0x001375F8
	public override string LDHNPOGPAOB()
	{
		return this.BOPJOMGIJIA.ToString();
	}

	// Token: 0x06002CC1 RID: 11457 RVA: 0x0013940B File Offset: 0x0013760B
	public override void FEHODJMIAJL(int OIMDDBOOAOB = 1)
	{
		if (!this.BBHDMMHCDKO())
		{
			this.BOPJOMGIJIA += OIMDDBOOAOB;
		}
	}

	// Token: 0x04000D44 RID: 3396
	public string LOLCBCKJODA = "";

	// Token: 0x04000D45 RID: 3397
	public string EHELHLOCOGG = "";

	// Token: 0x04000D46 RID: 3398
	public int IFCHGNCDMLJ = -1;

	// Token: 0x04000D47 RID: 3399
	public int AMKCLHLIIMN = -1;

	// Token: 0x04000D48 RID: 3400
	public ELFBAKJMBOA.BMHGEBOHLHH BOPJOMGIJIA;

	// Token: 0x02000157 RID: 343
	public enum BMHGEBOHLHH
	{
		// Token: 0x04000D4A RID: 3402
		start,
		// Token: 0x04000D4B RID: 3403
		done
	}
}
