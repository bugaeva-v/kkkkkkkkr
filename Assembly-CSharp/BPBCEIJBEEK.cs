using System;

// Token: 0x020001E2 RID: 482
public class BPBCEIJBEEK : KGLBKJKNPFD
{
	// Token: 0x06003BA5 RID: 15269 RVA: 0x0018B948 File Offset: 0x00189B48
	public BPBCEIJBEEK(string OFGJFNLDKGO)
	{
		this.OBKCKGHFMDN = KGLBKJKNPFD.LBFFMOMMAPK.chatClose;
	}

	// Token: 0x06003BA6 RID: 15270 RVA: 0x0018B963 File Offset: 0x00189B63
	public override void FEHODJMIAJL(int OIMDDBOOAOB = 1)
	{
		if (!this.BBHDMMHCDKO())
		{
			this.BOPJOMGIJIA += OIMDDBOOAOB;
		}
	}

	// Token: 0x06003BA7 RID: 15271 RVA: 0x0018B97B File Offset: 0x00189B7B
	public override bool BBHDMMHCDKO()
	{
		return this.BOPJOMGIJIA == BPBCEIJBEEK.BMHGEBOHLHH.done;
	}

	// Token: 0x06003BA8 RID: 15272 RVA: 0x0018B986 File Offset: 0x00189B86
	public override bool FMLECLNJAJM()
	{
		return this.BOPJOMGIJIA == (BPBCEIJBEEK.BMHGEBOHLHH)this.KOIINMNNNDJ;
	}

	// Token: 0x06003BA9 RID: 15273 RVA: 0x0018B996 File Offset: 0x00189B96
	public override bool PINCOCDOOGH()
	{
		return this.BOPJOMGIJIA == BPBCEIJBEEK.BMHGEBOHLHH.waitForInput;
	}

	// Token: 0x06003BAA RID: 15274 RVA: 0x0018B9A1 File Offset: 0x00189BA1
	public override string LDHNPOGPAOB()
	{
		return this.BOPJOMGIJIA.ToString();
	}

	// Token: 0x0400114A RID: 4426
	public string IMBBIDKPOBM = "";

	// Token: 0x0400114B RID: 4427
	public BPBCEIJBEEK.BMHGEBOHLHH BOPJOMGIJIA;

	// Token: 0x020001E3 RID: 483
	public enum BMHGEBOHLHH
	{
		// Token: 0x0400114D RID: 4429
		start,
		// Token: 0x0400114E RID: 4430
		waitForInput,
		// Token: 0x0400114F RID: 4431
		delay,
		// Token: 0x04001150 RID: 4432
		destroy,
		// Token: 0x04001151 RID: 4433
		done
	}
}
