using System;

// Token: 0x02000254 RID: 596
public class KGLMPKPMPDN : KGLBKJKNPFD
{
	// Token: 0x06004969 RID: 18793 RVA: 0x0021215D File Offset: 0x0021035D
	public override bool FMLECLNJAJM()
	{
		return this.BOPJOMGIJIA == (KGLMPKPMPDN.BMHGEBOHLHH)this.KOIINMNNNDJ;
	}

	// Token: 0x0600496A RID: 18794 RVA: 0x0021216D File Offset: 0x0021036D
	public override bool BBHDMMHCDKO()
	{
		return this.BOPJOMGIJIA == KGLMPKPMPDN.BMHGEBOHLHH.done;
	}

	// Token: 0x0600496B RID: 18795 RVA: 0x00212178 File Offset: 0x00210378
	public KGLMPKPMPDN(string OFGJFNLDKGO)
	{
		this.OBKCKGHFMDN = KGLBKJKNPFD.LBFFMOMMAPK.onDemandResoucesCheckpointHit;
		this.GGICIBLJIKI = HLDNEMHDEDH.OKNGPMCDBFE(OFGJFNLDKGO, "index(", ')', true);
	}

	// Token: 0x0600496C RID: 18796 RVA: 0x0021219C File Offset: 0x0021039C
	public override void FEHODJMIAJL(int OIMDDBOOAOB = 1)
	{
		if (!this.BBHDMMHCDKO())
		{
			this.BOPJOMGIJIA += OIMDDBOOAOB;
		}
	}

	// Token: 0x0600496D RID: 18797 RVA: 0x002121B4 File Offset: 0x002103B4
	public override string LDHNPOGPAOB()
	{
		return this.BOPJOMGIJIA.ToString();
	}

	// Token: 0x0600496E RID: 18798 RVA: 0x0001FBB0 File Offset: 0x0001DDB0
	public override bool PINCOCDOOGH()
	{
		return false;
	}

	// Token: 0x0400151F RID: 5407
	public int GGICIBLJIKI;

	// Token: 0x04001520 RID: 5408
	public KGLMPKPMPDN.BMHGEBOHLHH BOPJOMGIJIA;

	// Token: 0x02000255 RID: 597
	public enum BMHGEBOHLHH
	{
		// Token: 0x04001522 RID: 5410
		start,
		// Token: 0x04001523 RID: 5411
		destroyAssets,
		// Token: 0x04001524 RID: 5412
		cleanMemory,
		// Token: 0x04001525 RID: 5413
		downloadAssets,
		// Token: 0x04001526 RID: 5414
		saveCheckpoint,
		// Token: 0x04001527 RID: 5415
		done
	}
}
