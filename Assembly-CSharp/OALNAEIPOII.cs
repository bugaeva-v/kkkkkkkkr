using System;

// Token: 0x020004D4 RID: 1236
public class OALNAEIPOII : KGLBKJKNPFD
{
	// Token: 0x0600954D RID: 38221 RVA: 0x00418BEA File Offset: 0x00416DEA
	public override bool BBHDMMHCDKO()
	{
		return this.BOPJOMGIJIA == OALNAEIPOII.BMHGEBOHLHH.done;
	}

	// Token: 0x0600954E RID: 38222 RVA: 0x00418BF5 File Offset: 0x00416DF5
	public override bool FMLECLNJAJM()
	{
		return this.BOPJOMGIJIA == (OALNAEIPOII.BMHGEBOHLHH)this.KOIINMNNNDJ;
	}

	// Token: 0x0600954F RID: 38223 RVA: 0x00418C05 File Offset: 0x00416E05
	public override string LDHNPOGPAOB()
	{
		return this.BOPJOMGIJIA.ToString();
	}

	// Token: 0x06009550 RID: 38224 RVA: 0x0001FBB0 File Offset: 0x0001DDB0
	public override bool PINCOCDOOGH()
	{
		return false;
	}

	// Token: 0x06009551 RID: 38225 RVA: 0x00418C18 File Offset: 0x00416E18
	public OALNAEIPOII(string OFGJFNLDKGO)
	{
		this.OBKCKGHFMDN = KGLBKJKNPFD.LBFFMOMMAPK.removeMappingInfo;
		this.PNAKACGNLGL = HLDNEMHDEDH.LNLOHDKFDAA(OFGJFNLDKGO, "src(", ')', true);
		if (OFGJFNLDKGO.Contains("from("))
		{
			this.PNAKACGNLGL = HLDNEMHDEDH.LNLOHDKFDAA(OFGJFNLDKGO, "from(", ')', true);
		}
	}

	// Token: 0x06009552 RID: 38226 RVA: 0x00418C73 File Offset: 0x00416E73
	public override void FEHODJMIAJL(int OIMDDBOOAOB = 1)
	{
		if (!this.BBHDMMHCDKO())
		{
			this.BOPJOMGIJIA += OIMDDBOOAOB;
		}
	}

	// Token: 0x0400296D RID: 10605
	public string PNAKACGNLGL = "";

	// Token: 0x0400296E RID: 10606
	public OALNAEIPOII.BMHGEBOHLHH BOPJOMGIJIA;

	// Token: 0x020004D5 RID: 1237
	public enum BMHGEBOHLHH
	{
		// Token: 0x04002970 RID: 10608
		start,
		// Token: 0x04002971 RID: 10609
		done
	}
}
