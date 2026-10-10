using System;

// Token: 0x020002AE RID: 686
public class IEHFGLEPEJO : KGLBKJKNPFD
{
	// Token: 0x0600569B RID: 22171 RVA: 0x0026A30F File Offset: 0x0026850F
	public override void FEHODJMIAJL(int OIMDDBOOAOB = 1)
	{
		if (!this.BBHDMMHCDKO())
		{
			this.BOPJOMGIJIA += OIMDDBOOAOB;
		}
	}

	// Token: 0x0600569C RID: 22172 RVA: 0x0026A327 File Offset: 0x00268527
	public override bool BBHDMMHCDKO()
	{
		return this.BOPJOMGIJIA == IEHFGLEPEJO.BMHGEBOHLHH.done;
	}

	// Token: 0x0600569D RID: 22173 RVA: 0x0026A332 File Offset: 0x00268532
	public override string LDHNPOGPAOB()
	{
		return this.BOPJOMGIJIA.ToString();
	}

	// Token: 0x0600569E RID: 22174 RVA: 0x0026A345 File Offset: 0x00268545
	public IEHFGLEPEJO(string OFGJFNLDKGO)
	{
		this.OBKCKGHFMDN = KGLBKJKNPFD.LBFFMOMMAPK.importSettings;
	}

	// Token: 0x0600569F RID: 22175 RVA: 0x0026A355 File Offset: 0x00268555
	public override bool FMLECLNJAJM()
	{
		return this.BOPJOMGIJIA == (IEHFGLEPEJO.BMHGEBOHLHH)this.KOIINMNNNDJ;
	}

	// Token: 0x060056A0 RID: 22176 RVA: 0x0001FBB0 File Offset: 0x0001DDB0
	public override bool PINCOCDOOGH()
	{
		return false;
	}

	// Token: 0x04001853 RID: 6227
	public IEHFGLEPEJO.BMHGEBOHLHH BOPJOMGIJIA;

	// Token: 0x020002AF RID: 687
	public enum BMHGEBOHLHH
	{
		// Token: 0x04001855 RID: 6229
		start,
		// Token: 0x04001856 RID: 6230
		done
	}
}
