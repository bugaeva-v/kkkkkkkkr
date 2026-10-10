using System;

// Token: 0x02000201 RID: 513
public class OCBGFGNOHPF : KGLBKJKNPFD
{
	// Token: 0x06004078 RID: 16504 RVA: 0x001B2D48 File Offset: 0x001B0F48
	public OCBGFGNOHPF(string OFGJFNLDKGO)
	{
		this.OBKCKGHFMDN = KGLBKJKNPFD.LBFFMOMMAPK.npcPropIgnoreClear;
	}

	// Token: 0x06004079 RID: 16505 RVA: 0x0001FBB0 File Offset: 0x0001DDB0
	public override bool PINCOCDOOGH()
	{
		return false;
	}

	// Token: 0x0600407A RID: 16506 RVA: 0x001B2D58 File Offset: 0x001B0F58
	public override void FEHODJMIAJL(int OIMDDBOOAOB = 1)
	{
		if (!this.BBHDMMHCDKO())
		{
			this.BOPJOMGIJIA += OIMDDBOOAOB;
		}
	}

	// Token: 0x0600407B RID: 16507 RVA: 0x001B2D70 File Offset: 0x001B0F70
	public override bool FMLECLNJAJM()
	{
		return this.BOPJOMGIJIA == (OCBGFGNOHPF.BMHGEBOHLHH)this.KOIINMNNNDJ;
	}

	// Token: 0x0600407C RID: 16508 RVA: 0x001B2D80 File Offset: 0x001B0F80
	public override string LDHNPOGPAOB()
	{
		return this.BOPJOMGIJIA.ToString();
	}

	// Token: 0x0600407D RID: 16509 RVA: 0x001B2D93 File Offset: 0x001B0F93
	public override bool BBHDMMHCDKO()
	{
		return this.BOPJOMGIJIA == OCBGFGNOHPF.BMHGEBOHLHH.done;
	}

	// Token: 0x04001228 RID: 4648
	public OCBGFGNOHPF.BMHGEBOHLHH BOPJOMGIJIA;

	// Token: 0x02000202 RID: 514
	public enum BMHGEBOHLHH
	{
		// Token: 0x0400122A RID: 4650
		start,
		// Token: 0x0400122B RID: 4651
		done
	}
}
