using System;

// Token: 0x02000512 RID: 1298
public class HMGFCPHOIKO : KGLBKJKNPFD
{
	// Token: 0x06009CAB RID: 40107 RVA: 0x00439A85 File Offset: 0x00437C85
	public override void FEHODJMIAJL(int OIMDDBOOAOB = 1)
	{
		if (!this.BBHDMMHCDKO())
		{
			this.BOPJOMGIJIA += OIMDDBOOAOB;
		}
	}

	// Token: 0x06009CAC RID: 40108 RVA: 0x0001FBB0 File Offset: 0x0001DDB0
	public override bool PINCOCDOOGH()
	{
		return false;
	}

	// Token: 0x06009CAD RID: 40109 RVA: 0x00439A9D File Offset: 0x00437C9D
	public override bool BBHDMMHCDKO()
	{
		return this.BOPJOMGIJIA == HMGFCPHOIKO.BMHGEBOHLHH.done;
	}

	// Token: 0x06009CAE RID: 40110 RVA: 0x00439AA8 File Offset: 0x00437CA8
	public override bool FMLECLNJAJM()
	{
		return this.BOPJOMGIJIA == (HMGFCPHOIKO.BMHGEBOHLHH)this.KOIINMNNNDJ;
	}

	// Token: 0x06009CAF RID: 40111 RVA: 0x00439AB8 File Offset: 0x00437CB8
	public HMGFCPHOIKO(string OFGJFNLDKGO)
	{
		this.OBKCKGHFMDN = KGLBKJKNPFD.LBFFMOMMAPK.showAds;
	}

	// Token: 0x06009CB0 RID: 40112 RVA: 0x00439AC8 File Offset: 0x00437CC8
	public override string LDHNPOGPAOB()
	{
		return this.BOPJOMGIJIA.ToString();
	}

	// Token: 0x04002B8E RID: 11150
	public HMGFCPHOIKO.BMHGEBOHLHH BOPJOMGIJIA;

	// Token: 0x02000513 RID: 1299
	public enum BMHGEBOHLHH
	{
		// Token: 0x04002B90 RID: 11152
		start,
		// Token: 0x04002B91 RID: 11153
		done
	}
}
