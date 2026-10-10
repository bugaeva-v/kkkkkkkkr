using System;

// Token: 0x02000145 RID: 325
public class BOPBCIBJLAN : KGLBKJKNPFD
{
	// Token: 0x06002BB9 RID: 11193 RVA: 0x0001FBB0 File Offset: 0x0001DDB0
	public override bool PINCOCDOOGH()
	{
		return false;
	}

	// Token: 0x06002BBA RID: 11194 RVA: 0x00135B0E File Offset: 0x00133D0E
	public override string LDHNPOGPAOB()
	{
		return this.BOPJOMGIJIA.ToString();
	}

	// Token: 0x06002BBB RID: 11195 RVA: 0x00135B21 File Offset: 0x00133D21
	public override void FEHODJMIAJL(int OIMDDBOOAOB = 1)
	{
		if (!this.BBHDMMHCDKO())
		{
			this.BOPJOMGIJIA += OIMDDBOOAOB;
		}
	}

	// Token: 0x06002BBC RID: 11196 RVA: 0x00135B3C File Offset: 0x00133D3C
	public BOPBCIBJLAN(string OFGJFNLDKGO)
	{
		this.OBKCKGHFMDN = KGLBKJKNPFD.LBFFMOMMAPK.isBitSet;
		if (OFGJFNLDKGO.Contains("index"))
		{
			this.GGICIBLJIKI = HLDNEMHDEDH.OKNGPMCDBFE(OFGJFNLDKGO, "index(", ')', true);
		}
		if (OFGJFNLDKGO.Contains("set"))
		{
			this.EHELHLOCOGG = HLDNEMHDEDH.LNLOHDKFDAA(OFGJFNLDKGO, "set(", ')', true);
		}
	}

	// Token: 0x06002BBD RID: 11197 RVA: 0x00135BAB File Offset: 0x00133DAB
	public override bool FMLECLNJAJM()
	{
		return this.BOPJOMGIJIA == (BOPBCIBJLAN.BMHGEBOHLHH)this.KOIINMNNNDJ;
	}

	// Token: 0x06002BBE RID: 11198 RVA: 0x00135BBB File Offset: 0x00133DBB
	public override bool BBHDMMHCDKO()
	{
		return this.BOPJOMGIJIA == BOPBCIBJLAN.BMHGEBOHLHH.done;
	}

	// Token: 0x04000D04 RID: 3332
	public BOPBCIBJLAN.BMHGEBOHLHH BOPJOMGIJIA;

	// Token: 0x04000D05 RID: 3333
	public int GGICIBLJIKI = -1;

	// Token: 0x04000D06 RID: 3334
	public string EHELHLOCOGG = "";

	// Token: 0x02000146 RID: 326
	public enum BMHGEBOHLHH
	{
		// Token: 0x04000D08 RID: 3336
		start,
		// Token: 0x04000D09 RID: 3337
		done
	}
}
