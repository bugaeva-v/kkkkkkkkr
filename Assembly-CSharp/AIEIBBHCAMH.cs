using System;
using System.Collections.Generic;

// Token: 0x020003BD RID: 957
public class AIEIBBHCAMH : KGLBKJKNPFD
{
	// Token: 0x06006FFA RID: 28666 RVA: 0x0032CF3B File Offset: 0x0032B13B
	public override string LDHNPOGPAOB()
	{
		return this.BOPJOMGIJIA.ToString();
	}

	// Token: 0x06006FFB RID: 28667 RVA: 0x0001FBB0 File Offset: 0x0001DDB0
	public override bool PINCOCDOOGH()
	{
		return false;
	}

	// Token: 0x06006FFC RID: 28668 RVA: 0x0032CF4E File Offset: 0x0032B14E
	public override bool FMLECLNJAJM()
	{
		return this.BOPJOMGIJIA == (AIEIBBHCAMH.BMHGEBOHLHH)this.KOIINMNNNDJ;
	}

	// Token: 0x06006FFD RID: 28669 RVA: 0x0032CF5E File Offset: 0x0032B15E
	public override bool BBHDMMHCDKO()
	{
		return this.BOPJOMGIJIA == AIEIBBHCAMH.BMHGEBOHLHH.done;
	}

	// Token: 0x06006FFE RID: 28670 RVA: 0x0032CF69 File Offset: 0x0032B169
	public AIEIBBHCAMH(string OFGJFNLDKGO)
	{
		this.OBKCKGHFMDN = KGLBKJKNPFD.LBFFMOMMAPK.importVars;
		this.CHKCLEEFHHI = HLDNEMHDEDH.NNKLPOAODNF(OFGJFNLDKGO, "name(", ')', true);
	}

	// Token: 0x06006FFF RID: 28671 RVA: 0x0032CF98 File Offset: 0x0032B198
	public override void FEHODJMIAJL(int OIMDDBOOAOB = 1)
	{
		if (!this.BBHDMMHCDKO())
		{
			this.BOPJOMGIJIA += OIMDDBOOAOB;
		}
	}

	// Token: 0x040020F6 RID: 8438
	public AIEIBBHCAMH.BMHGEBOHLHH BOPJOMGIJIA;

	// Token: 0x040020F7 RID: 8439
	public List<string> CHKCLEEFHHI = new List<string>();

	// Token: 0x020003BE RID: 958
	public enum BMHGEBOHLHH
	{
		// Token: 0x040020F9 RID: 8441
		start,
		// Token: 0x040020FA RID: 8442
		done
	}
}
