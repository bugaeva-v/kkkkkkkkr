using System;

// Token: 0x02000451 RID: 1105
public class NDBPNOABBCL : KGLBKJKNPFD
{
	// Token: 0x060086A0 RID: 34464 RVA: 0x003C6874 File Offset: 0x003C4A74
	public NDBPNOABBCL(string OFGJFNLDKGO)
	{
		this.OBKCKGHFMDN = KGLBKJKNPFD.LBFFMOMMAPK.getRandomInt;
		this.IMOFIGHOIFM = HLDNEMHDEDH.OKNGPMCDBFE(OFGJFNLDKGO, "min(", ')', true);
		this.DNHFLKKAHHH = HLDNEMHDEDH.OKNGPMCDBFE(OFGJFNLDKGO, "max(", ')', true);
		this.EHELHLOCOGG = HLDNEMHDEDH.LNLOHDKFDAA(OFGJFNLDKGO, "set(", ')', true);
	}

	// Token: 0x060086A1 RID: 34465 RVA: 0x0001FBB0 File Offset: 0x0001DDB0
	public override bool PINCOCDOOGH()
	{
		return false;
	}

	// Token: 0x060086A2 RID: 34466 RVA: 0x003C68D6 File Offset: 0x003C4AD6
	public override string LDHNPOGPAOB()
	{
		return this.BOPJOMGIJIA.ToString();
	}

	// Token: 0x060086A3 RID: 34467 RVA: 0x003C68E9 File Offset: 0x003C4AE9
	public override bool BBHDMMHCDKO()
	{
		return this.BOPJOMGIJIA == NDBPNOABBCL.BMHGEBOHLHH.done;
	}

	// Token: 0x060086A4 RID: 34468 RVA: 0x003C68F4 File Offset: 0x003C4AF4
	public override void FEHODJMIAJL(int OIMDDBOOAOB = 1)
	{
		if (!this.BBHDMMHCDKO())
		{
			this.BOPJOMGIJIA += OIMDDBOOAOB;
		}
	}

	// Token: 0x060086A5 RID: 34469 RVA: 0x003C690C File Offset: 0x003C4B0C
	public override bool FMLECLNJAJM()
	{
		return this.BOPJOMGIJIA == (NDBPNOABBCL.BMHGEBOHLHH)this.KOIINMNNNDJ;
	}

	// Token: 0x040025C4 RID: 9668
	public int IMOFIGHOIFM;

	// Token: 0x040025C5 RID: 9669
	public int DNHFLKKAHHH;

	// Token: 0x040025C6 RID: 9670
	public string EHELHLOCOGG = "";

	// Token: 0x040025C7 RID: 9671
	public NDBPNOABBCL.BMHGEBOHLHH BOPJOMGIJIA;

	// Token: 0x02000452 RID: 1106
	public enum BMHGEBOHLHH
	{
		// Token: 0x040025C9 RID: 9673
		start,
		// Token: 0x040025CA RID: 9674
		done
	}
}
