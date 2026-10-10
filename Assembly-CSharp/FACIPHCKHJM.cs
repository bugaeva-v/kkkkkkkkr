using System;

// Token: 0x02000266 RID: 614
public class FACIPHCKHJM : KGLBKJKNPFD
{
	// Token: 0x06004B2D RID: 19245 RVA: 0x002189BA File Offset: 0x00216BBA
	public override bool FMLECLNJAJM()
	{
		return this.BOPJOMGIJIA == (FACIPHCKHJM.BMHGEBOHLHH)this.KOIINMNNNDJ;
	}

	// Token: 0x06004B2E RID: 19246 RVA: 0x002189CA File Offset: 0x00216BCA
	public override void FEHODJMIAJL(int OIMDDBOOAOB = 1)
	{
		if (!this.BBHDMMHCDKO())
		{
			this.BOPJOMGIJIA += OIMDDBOOAOB;
		}
	}

	// Token: 0x06004B2F RID: 19247 RVA: 0x0001FBB0 File Offset: 0x0001DDB0
	public override bool PINCOCDOOGH()
	{
		return false;
	}

	// Token: 0x06004B30 RID: 19248 RVA: 0x002189E2 File Offset: 0x00216BE2
	public FACIPHCKHJM(string OFGJFNLDKGO)
	{
		this.OBKCKGHFMDN = KGLBKJKNPFD.LBFFMOMMAPK.useDynamicMeta;
	}

	// Token: 0x06004B31 RID: 19249 RVA: 0x002189F2 File Offset: 0x00216BF2
	public override string LDHNPOGPAOB()
	{
		return this.BOPJOMGIJIA.ToString();
	}

	// Token: 0x06004B32 RID: 19250 RVA: 0x00218A05 File Offset: 0x00216C05
	public override bool BBHDMMHCDKO()
	{
		return this.BOPJOMGIJIA == FACIPHCKHJM.BMHGEBOHLHH.done;
	}

	// Token: 0x0400159B RID: 5531
	public FACIPHCKHJM.BMHGEBOHLHH BOPJOMGIJIA;

	// Token: 0x02000267 RID: 615
	public enum BMHGEBOHLHH
	{
		// Token: 0x0400159D RID: 5533
		start,
		// Token: 0x0400159E RID: 5534
		done
	}
}
