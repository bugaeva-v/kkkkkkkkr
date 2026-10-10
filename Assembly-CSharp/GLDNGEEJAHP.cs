using System;

// Token: 0x0200046E RID: 1134
public class GLDNGEEJAHP : KGLBKJKNPFD
{
	// Token: 0x060089FA RID: 35322 RVA: 0x003D7FF8 File Offset: 0x003D61F8
	public override bool FMLECLNJAJM()
	{
		return this.BOPJOMGIJIA == (GLDNGEEJAHP.BMHGEBOHLHH)this.KOIINMNNNDJ;
	}

	// Token: 0x060089FB RID: 35323 RVA: 0x003D8008 File Offset: 0x003D6208
	public override string LDHNPOGPAOB()
	{
		return this.BOPJOMGIJIA.ToString();
	}

	// Token: 0x060089FC RID: 35324 RVA: 0x003D801C File Offset: 0x003D621C
	public GLDNGEEJAHP(string OFGJFNLDKGO)
	{
		this.OBKCKGHFMDN = KGLBKJKNPFD.LBFFMOMMAPK.achievementIsUnlocked;
		if (OFGJFNLDKGO.Contains("id"))
		{
			this.FNAOJFMDPEL = HLDNEMHDEDH.LNLOHDKFDAA(OFGJFNLDKGO, "id(", ')', true);
		}
		if (OFGJFNLDKGO.Contains("set"))
		{
			this.EHELHLOCOGG = HLDNEMHDEDH.LNLOHDKFDAA(OFGJFNLDKGO, "set(", ')', true);
		}
	}

	// Token: 0x060089FD RID: 35325 RVA: 0x0001FBB0 File Offset: 0x0001DDB0
	public override bool PINCOCDOOGH()
	{
		return false;
	}

	// Token: 0x060089FE RID: 35326 RVA: 0x003D808F File Offset: 0x003D628F
	public override bool BBHDMMHCDKO()
	{
		return this.BOPJOMGIJIA == GLDNGEEJAHP.BMHGEBOHLHH.done;
	}

	// Token: 0x060089FF RID: 35327 RVA: 0x003D809A File Offset: 0x003D629A
	public override void FEHODJMIAJL(int OIMDDBOOAOB = 1)
	{
		if (!this.BBHDMMHCDKO())
		{
			this.BOPJOMGIJIA += OIMDDBOOAOB;
		}
	}

	// Token: 0x040026D5 RID: 9941
	public GLDNGEEJAHP.BMHGEBOHLHH BOPJOMGIJIA;

	// Token: 0x040026D6 RID: 9942
	public string FNAOJFMDPEL = "";

	// Token: 0x040026D7 RID: 9943
	public string EHELHLOCOGG = "";

	// Token: 0x0200046F RID: 1135
	public enum BMHGEBOHLHH
	{
		// Token: 0x040026D9 RID: 9945
		start,
		// Token: 0x040026DA RID: 9946
		done
	}
}
