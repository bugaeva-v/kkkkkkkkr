using System;
using System.Collections.Generic;

// Token: 0x0200001C RID: 28
public class KAKODAHAJKD : KGLBKJKNPFD
{
	// Token: 0x060004C1 RID: 1217 RVA: 0x0001FBA0 File Offset: 0x0001DDA0
	public override bool FMLECLNJAJM()
	{
		return this.BOPJOMGIJIA == (KAKODAHAJKD.BMHGEBOHLHH)this.KOIINMNNNDJ;
	}

	// Token: 0x060004C2 RID: 1218 RVA: 0x0001FBB0 File Offset: 0x0001DDB0
	public override bool PINCOCDOOGH()
	{
		return false;
	}

	// Token: 0x060004C3 RID: 1219 RVA: 0x0001FBB3 File Offset: 0x0001DDB3
	public override bool BBHDMMHCDKO()
	{
		return this.BOPJOMGIJIA == KAKODAHAJKD.BMHGEBOHLHH.done;
	}

	// Token: 0x060004C4 RID: 1220 RVA: 0x0001FBBE File Offset: 0x0001DDBE
	public override string LDHNPOGPAOB()
	{
		return this.BOPJOMGIJIA.ToString();
	}

	// Token: 0x060004C5 RID: 1221 RVA: 0x0001FBD4 File Offset: 0x0001DDD4
	public KAKODAHAJKD(string OFGJFNLDKGO)
	{
		this.OBKCKGHFMDN = KGLBKJKNPFD.LBFFMOMMAPK.exportVars;
		this.CHKCLEEFHHI = HLDNEMHDEDH.NNKLPOAODNF(OFGJFNLDKGO, "name(", ')', true);
		this.NJPHDOPOFHD = HLDNEMHDEDH.NNKLPOAODNF(OFGJFNLDKGO, "type(", ')', true);
		if (this.CHKCLEEFHHI.Count != this.NJPHDOPOFHD.Count)
		{
			DPGJIJGOCIC.ANOPFDLPKGC("StoryStepExportVars - variable name and type count is different.");
		}
	}

	// Token: 0x060004C6 RID: 1222 RVA: 0x0001FC4F File Offset: 0x0001DE4F
	public override void FEHODJMIAJL(int OIMDDBOOAOB = 1)
	{
		if (!this.BBHDMMHCDKO())
		{
			this.BOPJOMGIJIA += OIMDDBOOAOB;
		}
	}

	// Token: 0x0400011F RID: 287
	public KAKODAHAJKD.BMHGEBOHLHH BOPJOMGIJIA;

	// Token: 0x04000120 RID: 288
	public List<string> CHKCLEEFHHI = new List<string>();

	// Token: 0x04000121 RID: 289
	public List<string> NJPHDOPOFHD = new List<string>();

	// Token: 0x0200001D RID: 29
	public enum BMHGEBOHLHH
	{
		// Token: 0x04000123 RID: 291
		start,
		// Token: 0x04000124 RID: 292
		export,
		// Token: 0x04000125 RID: 293
		done
	}
}
