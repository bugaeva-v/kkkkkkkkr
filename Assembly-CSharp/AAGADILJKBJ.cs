using System;

// Token: 0x02000473 RID: 1139
public class AAGADILJKBJ : KGLBKJKNPFD
{
	// Token: 0x06008AB1 RID: 35505 RVA: 0x003DA454 File Offset: 0x003D8654
	public override string LDHNPOGPAOB()
	{
		return this.BOPJOMGIJIA.ToString();
	}

	// Token: 0x06008AB2 RID: 35506 RVA: 0x0001FBB0 File Offset: 0x0001DDB0
	public override bool PINCOCDOOGH()
	{
		return false;
	}

	// Token: 0x06008AB3 RID: 35507 RVA: 0x003DA467 File Offset: 0x003D8667
	public override bool BBHDMMHCDKO()
	{
		return this.BOPJOMGIJIA == AAGADILJKBJ.BMHGEBOHLHH.done;
	}

	// Token: 0x06008AB4 RID: 35508 RVA: 0x003DA474 File Offset: 0x003D8674
	public AAGADILJKBJ(string OFGJFNLDKGO)
	{
		this.OBKCKGHFMDN = KGLBKJKNPFD.LBFFMOMMAPK.addMappingInfo;
		this.PNAKACGNLGL = HLDNEMHDEDH.LNLOHDKFDAA(OFGJFNLDKGO, "src(", ')', true);
		this.NEOFEIFAGLF = HLDNEMHDEDH.LNLOHDKFDAA(OFGJFNLDKGO, "dst(", ')', true);
		if (OFGJFNLDKGO.Contains("from("))
		{
			this.PNAKACGNLGL = HLDNEMHDEDH.LNLOHDKFDAA(OFGJFNLDKGO, "from(", ')', true);
		}
		if (OFGJFNLDKGO.Contains("to("))
		{
			this.NEOFEIFAGLF = HLDNEMHDEDH.LNLOHDKFDAA(OFGJFNLDKGO, "to(", ')', true);
		}
		if (OFGJFNLDKGO.Contains("ifmissing"))
		{
			this.HKFCEIJMLCI = (HLDNEMHDEDH.OKNGPMCDBFE(OFGJFNLDKGO, "ifmissing(", ')', true) == 1);
		}
		if (!this.NEOFEIFAGLF.Contains("char") && (this.NEOFEIFAGLF.Contains("overlay") || this.NEOFEIFAGLF.Contains("face") || this.NEOFEIFAGLF.Contains("makeup") || this.NEOFEIFAGLF.Contains("trinket") || this.NEOFEIFAGLF.Contains("hair") || this.NEOFEIFAGLF.Contains("body") || this.NEOFEIFAGLF.Contains("clothes")) && KGLBKJKNPFD.AFKAMBFMMOH >= 0)
		{
			string akmibddhadh = "";
			if (KGLBKJKNPFD.AFKAMBFMMOH > 0)
			{
				akmibddhadh = "+" + KGLBKJKNPFD.AFKAMBFMMOH.ToString();
			}
			this.NEOFEIFAGLF = HLDNEMHDEDH.DGNHJHJMHPD(this.NEOFEIFAGLF, akmibddhadh);
		}
	}

	// Token: 0x06008AB5 RID: 35509 RVA: 0x003DA603 File Offset: 0x003D8803
	public override bool FMLECLNJAJM()
	{
		return this.BOPJOMGIJIA == (AAGADILJKBJ.BMHGEBOHLHH)this.KOIINMNNNDJ;
	}

	// Token: 0x06008AB6 RID: 35510 RVA: 0x003DA613 File Offset: 0x003D8813
	public override void FEHODJMIAJL(int OIMDDBOOAOB = 1)
	{
		if (!this.BBHDMMHCDKO())
		{
			this.BOPJOMGIJIA += OIMDDBOOAOB;
		}
	}

	// Token: 0x040026EC RID: 9964
	public string PNAKACGNLGL = "";

	// Token: 0x040026ED RID: 9965
	public string NEOFEIFAGLF = "";

	// Token: 0x040026EE RID: 9966
	public bool HKFCEIJMLCI;

	// Token: 0x040026EF RID: 9967
	public AAGADILJKBJ.BMHGEBOHLHH BOPJOMGIJIA;

	// Token: 0x02000474 RID: 1140
	public enum BMHGEBOHLHH
	{
		// Token: 0x040026F1 RID: 9969
		start,
		// Token: 0x040026F2 RID: 9970
		done
	}
}
