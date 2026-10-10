using System;

// Token: 0x0200000D RID: 13
public class CPFJIACDGEP : KGLBKJKNPFD
{
	// Token: 0x060001B7 RID: 439 RVA: 0x0000A65E File Offset: 0x0000885E
	public override bool PINCOCDOOGH()
	{
		return this.BOPJOMGIJIA == CPFJIACDGEP.BMHGEBOHLHH.waitForInput;
	}

	// Token: 0x060001B8 RID: 440 RVA: 0x0000A669 File Offset: 0x00008869
	public CPFJIACDGEP(string OFGJFNLDKGO)
	{
		this.OBKCKGHFMDN = KGLBKJKNPFD.LBFFMOMMAPK.emptyStep;
	}

	// Token: 0x060001B9 RID: 441 RVA: 0x0000A679 File Offset: 0x00008879
	public override string LDHNPOGPAOB()
	{
		return this.BOPJOMGIJIA.ToString();
	}

	// Token: 0x060001BA RID: 442 RVA: 0x0000A68C File Offset: 0x0000888C
	public override bool FMLECLNJAJM()
	{
		return this.BOPJOMGIJIA == (CPFJIACDGEP.BMHGEBOHLHH)this.KOIINMNNNDJ;
	}

	// Token: 0x060001BB RID: 443 RVA: 0x0000A69C File Offset: 0x0000889C
	public override bool BBHDMMHCDKO()
	{
		return this.BOPJOMGIJIA == CPFJIACDGEP.BMHGEBOHLHH.done;
	}

	// Token: 0x060001BC RID: 444 RVA: 0x0000A6A7 File Offset: 0x000088A7
	public override void FEHODJMIAJL(int OIMDDBOOAOB = 1)
	{
		if (!this.BBHDMMHCDKO())
		{
			this.BOPJOMGIJIA += OIMDDBOOAOB;
		}
	}

	// Token: 0x0400002C RID: 44
	public CPFJIACDGEP.BMHGEBOHLHH BOPJOMGIJIA;

	// Token: 0x0200000E RID: 14
	public enum BMHGEBOHLHH
	{
		// Token: 0x0400002E RID: 46
		start,
		// Token: 0x0400002F RID: 47
		waitForInput,
		// Token: 0x04000030 RID: 48
		done
	}
}
