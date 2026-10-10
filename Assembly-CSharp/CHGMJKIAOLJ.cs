using System;

// Token: 0x0200052F RID: 1327
public class CHGMJKIAOLJ : KGLBKJKNPFD
{
	// Token: 0x0600A1FC RID: 41468 RVA: 0x00461534 File Offset: 0x0045F734
	public override bool FMLECLNJAJM()
	{
		return this.BOPJOMGIJIA == (CHGMJKIAOLJ.BMHGEBOHLHH)this.KOIINMNNNDJ;
	}

	// Token: 0x0600A1FD RID: 41469 RVA: 0x0001FBB0 File Offset: 0x0001DDB0
	public override bool PINCOCDOOGH()
	{
		return false;
	}

	// Token: 0x0600A1FE RID: 41470 RVA: 0x00461544 File Offset: 0x0045F744
	public CHGMJKIAOLJ(string OFGJFNLDKGO)
	{
		this.OBKCKGHFMDN = KGLBKJKNPFD.LBFFMOMMAPK.uncacheAssetPack;
		this.KIMBCEKMBNG = HLDNEMHDEDH.OKNGPMCDBFE(OFGJFNLDKGO, "id(", ')', true);
	}

	// Token: 0x0600A1FF RID: 41471 RVA: 0x0046156F File Offset: 0x0045F76F
	public override void FEHODJMIAJL(int OIMDDBOOAOB = 1)
	{
		if (!this.BBHDMMHCDKO())
		{
			this.BOPJOMGIJIA += OIMDDBOOAOB;
		}
	}

	// Token: 0x0600A200 RID: 41472 RVA: 0x00461587 File Offset: 0x0045F787
	public override string LDHNPOGPAOB()
	{
		return this.BOPJOMGIJIA.ToString();
	}

	// Token: 0x0600A201 RID: 41473 RVA: 0x0046159A File Offset: 0x0045F79A
	public override bool BBHDMMHCDKO()
	{
		return this.BOPJOMGIJIA == CHGMJKIAOLJ.BMHGEBOHLHH.done;
	}

	// Token: 0x04002C47 RID: 11335
	public CHGMJKIAOLJ.BMHGEBOHLHH BOPJOMGIJIA;

	// Token: 0x04002C48 RID: 11336
	public int KIMBCEKMBNG = -1;

	// Token: 0x02000530 RID: 1328
	public enum BMHGEBOHLHH
	{
		// Token: 0x04002C4A RID: 11338
		start,
		// Token: 0x04002C4B RID: 11339
		done
	}
}
