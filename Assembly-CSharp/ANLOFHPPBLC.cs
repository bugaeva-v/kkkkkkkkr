using System;

// Token: 0x0200041B RID: 1051
public class ANLOFHPPBLC : KGLBKJKNPFD
{
	// Token: 0x06007DB0 RID: 32176 RVA: 0x0037B644 File Offset: 0x00379844
	public override string LDHNPOGPAOB()
	{
		return this.BOPJOMGIJIA.ToString();
	}

	// Token: 0x06007DB1 RID: 32177 RVA: 0x0037B657 File Offset: 0x00379857
	public override bool BBHDMMHCDKO()
	{
		return this.BOPJOMGIJIA == ANLOFHPPBLC.BMHGEBOHLHH.done;
	}

	// Token: 0x06007DB2 RID: 32178 RVA: 0x0037B662 File Offset: 0x00379862
	public ANLOFHPPBLC(string OFGJFNLDKGO)
	{
		this.OBKCKGHFMDN = KGLBKJKNPFD.LBFFMOMMAPK.enableLocalizationExtension;
		if (OFGJFNLDKGO.Contains("index"))
		{
			this.GGICIBLJIKI = HLDNEMHDEDH.OKNGPMCDBFE(OFGJFNLDKGO, "index(", ')', true);
		}
	}

	// Token: 0x06007DB3 RID: 32179 RVA: 0x0037B69A File Offset: 0x0037989A
	public override bool FMLECLNJAJM()
	{
		return this.BOPJOMGIJIA == (ANLOFHPPBLC.BMHGEBOHLHH)this.KOIINMNNNDJ;
	}

	// Token: 0x06007DB4 RID: 32180 RVA: 0x0001FBB0 File Offset: 0x0001DDB0
	public override bool PINCOCDOOGH()
	{
		return false;
	}

	// Token: 0x06007DB5 RID: 32181 RVA: 0x0037B6AA File Offset: 0x003798AA
	public override void FEHODJMIAJL(int OIMDDBOOAOB = 1)
	{
		if (!this.BBHDMMHCDKO())
		{
			this.BOPJOMGIJIA += OIMDDBOOAOB;
		}
	}

	// Token: 0x0400245F RID: 9311
	public int GGICIBLJIKI = -1;

	// Token: 0x04002460 RID: 9312
	public ANLOFHPPBLC.BMHGEBOHLHH BOPJOMGIJIA;

	// Token: 0x0200041C RID: 1052
	public enum BMHGEBOHLHH
	{
		// Token: 0x04002462 RID: 9314
		start,
		// Token: 0x04002463 RID: 9315
		done
	}
}
