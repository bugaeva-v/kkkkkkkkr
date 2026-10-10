using System;

// Token: 0x02000262 RID: 610
public class MLICLNDBCHP : KGLBKJKNPFD
{
	// Token: 0x06004B17 RID: 19223 RVA: 0x002187DE File Offset: 0x002169DE
	public override bool FMLECLNJAJM()
	{
		return this.BOPJOMGIJIA == (MLICLNDBCHP.BMHGEBOHLHH)this.KOIINMNNNDJ;
	}

	// Token: 0x06004B18 RID: 19224 RVA: 0x002187EE File Offset: 0x002169EE
	public override bool BBHDMMHCDKO()
	{
		return this.BOPJOMGIJIA == MLICLNDBCHP.BMHGEBOHLHH.done;
	}

	// Token: 0x06004B19 RID: 19225 RVA: 0x0001FBB0 File Offset: 0x0001DDB0
	public override bool PINCOCDOOGH()
	{
		return false;
	}

	// Token: 0x06004B1A RID: 19226 RVA: 0x002187F9 File Offset: 0x002169F9
	public MLICLNDBCHP(string OFGJFNLDKGO)
	{
		this.OBKCKGHFMDN = KGLBKJKNPFD.LBFFMOMMAPK.useEmotionsV2;
	}

	// Token: 0x06004B1B RID: 19227 RVA: 0x00218809 File Offset: 0x00216A09
	public override void FEHODJMIAJL(int OIMDDBOOAOB = 1)
	{
		if (!this.BBHDMMHCDKO())
		{
			this.BOPJOMGIJIA += OIMDDBOOAOB;
		}
	}

	// Token: 0x06004B1C RID: 19228 RVA: 0x00218821 File Offset: 0x00216A21
	public override string LDHNPOGPAOB()
	{
		return this.BOPJOMGIJIA.ToString();
	}

	// Token: 0x0400158F RID: 5519
	public MLICLNDBCHP.BMHGEBOHLHH BOPJOMGIJIA;

	// Token: 0x02000263 RID: 611
	public enum BMHGEBOHLHH
	{
		// Token: 0x04001591 RID: 5521
		start,
		// Token: 0x04001592 RID: 5522
		done
	}
}
