using System;

// Token: 0x02000154 RID: 340
public class OMIAPOKBELK : KGLBKJKNPFD
{
	// Token: 0x06002CB6 RID: 11446 RVA: 0x001392C0 File Offset: 0x001374C0
	public override string LDHNPOGPAOB()
	{
		return this.BOPJOMGIJIA.ToString();
	}

	// Token: 0x06002CB7 RID: 11447 RVA: 0x001392D3 File Offset: 0x001374D3
	public override bool FMLECLNJAJM()
	{
		return this.BOPJOMGIJIA == (OMIAPOKBELK.BMHGEBOHLHH)this.KOIINMNNNDJ;
	}

	// Token: 0x06002CB8 RID: 11448 RVA: 0x001392E3 File Offset: 0x001374E3
	public override void FEHODJMIAJL(int OIMDDBOOAOB = 1)
	{
		if (!this.BBHDMMHCDKO())
		{
			this.BOPJOMGIJIA += OIMDDBOOAOB;
		}
	}

	// Token: 0x06002CB9 RID: 11449 RVA: 0x0001FBB0 File Offset: 0x0001DDB0
	public override bool PINCOCDOOGH()
	{
		return false;
	}

	// Token: 0x06002CBA RID: 11450 RVA: 0x001392FB File Offset: 0x001374FB
	public override bool BBHDMMHCDKO()
	{
		return this.BOPJOMGIJIA == OMIAPOKBELK.BMHGEBOHLHH.done;
	}

	// Token: 0x06002CBB RID: 11451 RVA: 0x00139306 File Offset: 0x00137506
	public OMIAPOKBELK(string OFGJFNLDKGO)
	{
		this.OBKCKGHFMDN = KGLBKJKNPFD.LBFFMOMMAPK.skinCheckpointStart;
		this.OBLBNLBFBNI = HLDNEMHDEDH.OKNGPMCDBFE(OFGJFNLDKGO, "id(", ')', true);
	}

	// Token: 0x04000D3F RID: 3391
	public int OBLBNLBFBNI = -1;

	// Token: 0x04000D40 RID: 3392
	public OMIAPOKBELK.BMHGEBOHLHH BOPJOMGIJIA;

	// Token: 0x02000155 RID: 341
	public enum BMHGEBOHLHH
	{
		// Token: 0x04000D42 RID: 3394
		start,
		// Token: 0x04000D43 RID: 3395
		done
	}
}
