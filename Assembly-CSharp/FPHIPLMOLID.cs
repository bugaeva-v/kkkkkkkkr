using System;

// Token: 0x02000521 RID: 1313
public class FPHIPLMOLID : KGLBKJKNPFD
{
	// Token: 0x06009F86 RID: 40838 RVA: 0x0045278B File Offset: 0x0045098B
	public override string LDHNPOGPAOB()
	{
		return this.BOPJOMGIJIA.ToString();
	}

	// Token: 0x06009F87 RID: 40839 RVA: 0x0045279E File Offset: 0x0045099E
	public override bool FMLECLNJAJM()
	{
		return this.BOPJOMGIJIA == (FPHIPLMOLID.BMHGEBOHLHH)this.KOIINMNNNDJ;
	}

	// Token: 0x06009F88 RID: 40840 RVA: 0x004527AE File Offset: 0x004509AE
	public FPHIPLMOLID(string OFGJFNLDKGO)
	{
		this.OBKCKGHFMDN = KGLBKJKNPFD.LBFFMOMMAPK.setPov;
		this.IHCMBIBJBJD = HLDNEMHDEDH.LNLOHDKFDAA(OFGJFNLDKGO, "id(", ')', true);
	}

	// Token: 0x06009F89 RID: 40841 RVA: 0x004527DD File Offset: 0x004509DD
	public override bool BBHDMMHCDKO()
	{
		return this.BOPJOMGIJIA == FPHIPLMOLID.BMHGEBOHLHH.done;
	}

	// Token: 0x06009F8A RID: 40842 RVA: 0x0001FBB0 File Offset: 0x0001DDB0
	public override bool PINCOCDOOGH()
	{
		return false;
	}

	// Token: 0x06009F8B RID: 40843 RVA: 0x004527E8 File Offset: 0x004509E8
	public override void FEHODJMIAJL(int OIMDDBOOAOB = 1)
	{
		if (!this.BBHDMMHCDKO())
		{
			this.BOPJOMGIJIA += OIMDDBOOAOB;
		}
	}

	// Token: 0x04002C0B RID: 11275
	public FPHIPLMOLID.BMHGEBOHLHH BOPJOMGIJIA;

	// Token: 0x04002C0C RID: 11276
	public string IHCMBIBJBJD = "";

	// Token: 0x02000522 RID: 1314
	public enum BMHGEBOHLHH
	{
		// Token: 0x04002C0E RID: 11278
		start,
		// Token: 0x04002C0F RID: 11279
		done
	}
}
