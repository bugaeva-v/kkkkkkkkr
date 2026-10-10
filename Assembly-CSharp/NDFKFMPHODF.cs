using System;

// Token: 0x02000280 RID: 640
public class NDFKFMPHODF : KGLBKJKNPFD
{
	// Token: 0x06004FDB RID: 20443 RVA: 0x002306F9 File Offset: 0x0022E8F9
	public override string LDHNPOGPAOB()
	{
		return this.BOPJOMGIJIA.ToString();
	}

	// Token: 0x06004FDC RID: 20444 RVA: 0x0001FBB0 File Offset: 0x0001DDB0
	public override bool PINCOCDOOGH()
	{
		return false;
	}

	// Token: 0x06004FDD RID: 20445 RVA: 0x0023070C File Offset: 0x0022E90C
	public NDFKFMPHODF(string OFGJFNLDKGO)
	{
		this.OBKCKGHFMDN = KGLBKJKNPFD.LBFFMOMMAPK.cacheAssetPack;
		this.KIMBCEKMBNG = HLDNEMHDEDH.OKNGPMCDBFE(OFGJFNLDKGO, "id(", ')', true);
		this.IFCHGNCDMLJ = HLDNEMHDEDH.OKNGPMCDBFE(OFGJFNLDKGO, "story(", ')', true);
		this.KKJNKAFMANA = HLDNEMHDEDH.OKNGPMCDBFE(OFGJFNLDKGO, "keepalive(", ')', true);
	}

	// Token: 0x06004FDE RID: 20446 RVA: 0x00230763 File Offset: 0x0022E963
	public override void FEHODJMIAJL(int OIMDDBOOAOB = 1)
	{
		if (!this.BBHDMMHCDKO())
		{
			this.BOPJOMGIJIA += OIMDDBOOAOB;
		}
	}

	// Token: 0x06004FDF RID: 20447 RVA: 0x0023077B File Offset: 0x0022E97B
	public override bool FMLECLNJAJM()
	{
		return this.BOPJOMGIJIA == (NDFKFMPHODF.BMHGEBOHLHH)this.KOIINMNNNDJ;
	}

	// Token: 0x06004FE0 RID: 20448 RVA: 0x0023078B File Offset: 0x0022E98B
	public override bool BBHDMMHCDKO()
	{
		return this.BOPJOMGIJIA == NDFKFMPHODF.BMHGEBOHLHH.done;
	}

	// Token: 0x0400166B RID: 5739
	public NDFKFMPHODF.BMHGEBOHLHH BOPJOMGIJIA;

	// Token: 0x0400166C RID: 5740
	public int KIMBCEKMBNG;

	// Token: 0x0400166D RID: 5741
	public int IFCHGNCDMLJ;

	// Token: 0x0400166E RID: 5742
	public int KKJNKAFMANA;

	// Token: 0x02000281 RID: 641
	public enum BMHGEBOHLHH
	{
		// Token: 0x04001670 RID: 5744
		start,
		// Token: 0x04001671 RID: 5745
		done
	}
}
