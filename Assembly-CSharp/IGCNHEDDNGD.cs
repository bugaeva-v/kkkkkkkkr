using System;
using System.Collections.Generic;

// Token: 0x0200021A RID: 538
public class IGCNHEDDNGD : KGLBKJKNPFD
{
	// Token: 0x0600434E RID: 17230 RVA: 0x001D5C64 File Offset: 0x001D3E64
	public override bool FMLECLNJAJM()
	{
		return this.BOPJOMGIJIA == (IGCNHEDDNGD.BMHGEBOHLHH)this.KOIINMNNNDJ;
	}

	// Token: 0x0600434F RID: 17231 RVA: 0x001D5C74 File Offset: 0x001D3E74
	public override bool BBHDMMHCDKO()
	{
		return this.BOPJOMGIJIA == IGCNHEDDNGD.BMHGEBOHLHH.done;
	}

	// Token: 0x06004350 RID: 17232 RVA: 0x001D5C7F File Offset: 0x001D3E7F
	public override void FEHODJMIAJL(int OIMDDBOOAOB = 1)
	{
		if (!this.BBHDMMHCDKO())
		{
			this.BOPJOMGIJIA += OIMDDBOOAOB;
		}
	}

	// Token: 0x06004351 RID: 17233 RVA: 0x0001FBB0 File Offset: 0x0001DDB0
	public override bool PINCOCDOOGH()
	{
		return false;
	}

	// Token: 0x06004352 RID: 17234 RVA: 0x001D5C98 File Offset: 0x001D3E98
	public IGCNHEDDNGD(string OFGJFNLDKGO)
	{
		this.OBKCKGHFMDN = KGLBKJKNPFD.LBFFMOMMAPK.hasAvatarComponent;
		if (OFGJFNLDKGO.Contains("get("))
		{
			this.LOLCBCKJODA = HLDNEMHDEDH.LNLOHDKFDAA(OFGJFNLDKGO, "get(", ')', true);
		}
		this.EHELHLOCOGG = HLDNEMHDEDH.LNLOHDKFDAA(OFGJFNLDKGO, "set(", ')', true);
		if (OFGJFNLDKGO.Contains("getany("))
		{
			this.KAGAHEIHFBP = HLDNEMHDEDH.NNKLPOAODNF(OFGJFNLDKGO, "getany(", ')', true);
		}
		if (OFGJFNLDKGO.Contains("getall("))
		{
			this.JFPBFKIADPK = HLDNEMHDEDH.NNKLPOAODNF(OFGJFNLDKGO, "getall(", ')', true);
		}
		if (KGLBKJKNPFD.AFKAMBFMMOH >= 0)
		{
			string akmibddhadh = "";
			if (KGLBKJKNPFD.AFKAMBFMMOH > 0)
			{
				akmibddhadh = "+" + KGLBKJKNPFD.AFKAMBFMMOH.ToString();
			}
			this.KAGAHEIHFBP = HLDNEMHDEDH.DGNHJHJMHPD(this.KAGAHEIHFBP, akmibddhadh);
			this.JFPBFKIADPK = HLDNEMHDEDH.DGNHJHJMHPD(this.JFPBFKIADPK, akmibddhadh);
			this.LOLCBCKJODA = HLDNEMHDEDH.DGNHJHJMHPD(this.LOLCBCKJODA, akmibddhadh);
		}
	}

	// Token: 0x06004353 RID: 17235 RVA: 0x001D5DB7 File Offset: 0x001D3FB7
	public override string LDHNPOGPAOB()
	{
		return this.BOPJOMGIJIA.ToString();
	}

	// Token: 0x040012A7 RID: 4775
	public string LOLCBCKJODA = "";

	// Token: 0x040012A8 RID: 4776
	public List<string> KAGAHEIHFBP = new List<string>();

	// Token: 0x040012A9 RID: 4777
	public List<string> JFPBFKIADPK = new List<string>();

	// Token: 0x040012AA RID: 4778
	public string EHELHLOCOGG = "";

	// Token: 0x040012AB RID: 4779
	public IGCNHEDDNGD.BMHGEBOHLHH BOPJOMGIJIA;

	// Token: 0x0200021B RID: 539
	public enum BMHGEBOHLHH
	{
		// Token: 0x040012AD RID: 4781
		start,
		// Token: 0x040012AE RID: 4782
		done
	}
}
