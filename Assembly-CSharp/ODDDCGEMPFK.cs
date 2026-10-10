using System;

// Token: 0x02000409 RID: 1033
public class ODDDCGEMPFK : KGLBKJKNPFD
{
	// Token: 0x06007B43 RID: 31555 RVA: 0x0036FA3F File Offset: 0x0036DC3F
	public override void FEHODJMIAJL(int OIMDDBOOAOB = 1)
	{
		if (!this.BBHDMMHCDKO())
		{
			this.BOPJOMGIJIA += OIMDDBOOAOB;
		}
	}

	// Token: 0x06007B44 RID: 31556 RVA: 0x0036FA57 File Offset: 0x0036DC57
	public override bool FMLECLNJAJM()
	{
		return this.BOPJOMGIJIA == (ODDDCGEMPFK.BMHGEBOHLHH)this.KOIINMNNNDJ;
	}

	// Token: 0x06007B45 RID: 31557 RVA: 0x0036FA67 File Offset: 0x0036DC67
	public ODDDCGEMPFK(string OFGJFNLDKGO)
	{
		this.OBKCKGHFMDN = KGLBKJKNPFD.LBFFMOMMAPK.dummy;
	}

	// Token: 0x06007B46 RID: 31558 RVA: 0x0036FA77 File Offset: 0x0036DC77
	public override string LDHNPOGPAOB()
	{
		return this.BOPJOMGIJIA.ToString();
	}

	// Token: 0x06007B47 RID: 31559 RVA: 0x0036FA8A File Offset: 0x0036DC8A
	public override bool BBHDMMHCDKO()
	{
		return this.BOPJOMGIJIA == ODDDCGEMPFK.BMHGEBOHLHH.done;
	}

	// Token: 0x06007B48 RID: 31560 RVA: 0x0001FBB0 File Offset: 0x0001DDB0
	public override bool PINCOCDOOGH()
	{
		return false;
	}

	// Token: 0x040023A3 RID: 9123
	public ODDDCGEMPFK.BMHGEBOHLHH BOPJOMGIJIA;

	// Token: 0x0200040A RID: 1034
	public enum BMHGEBOHLHH
	{
		// Token: 0x040023A5 RID: 9125
		start,
		// Token: 0x040023A6 RID: 9126
		done
	}
}
