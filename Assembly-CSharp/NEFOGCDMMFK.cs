using System;

// Token: 0x02000178 RID: 376
public class NEFOGCDMMFK : KGLBKJKNPFD
{
	// Token: 0x06002F38 RID: 12088 RVA: 0x0014545C File Offset: 0x0014365C
	public override bool FMLECLNJAJM()
	{
		return this.BOPJOMGIJIA == (NEFOGCDMMFK.BMHGEBOHLHH)this.KOIINMNNNDJ;
	}

	// Token: 0x06002F39 RID: 12089 RVA: 0x0014546C File Offset: 0x0014366C
	public override void FEHODJMIAJL(int OIMDDBOOAOB = 1)
	{
		if (!this.BBHDMMHCDKO())
		{
			this.BOPJOMGIJIA += OIMDDBOOAOB;
		}
	}

	// Token: 0x06002F3A RID: 12090 RVA: 0x00145484 File Offset: 0x00143684
	public override string LDHNPOGPAOB()
	{
		return this.BOPJOMGIJIA.ToString();
	}

	// Token: 0x06002F3B RID: 12091 RVA: 0x00145497 File Offset: 0x00143697
	public NEFOGCDMMFK(string OFGJFNLDKGO)
	{
		this.OBKCKGHFMDN = KGLBKJKNPFD.LBFFMOMMAPK.skinCheckpointEnd;
	}

	// Token: 0x06002F3C RID: 12092 RVA: 0x0001FBB0 File Offset: 0x0001DDB0
	public override bool PINCOCDOOGH()
	{
		return false;
	}

	// Token: 0x06002F3D RID: 12093 RVA: 0x001454A7 File Offset: 0x001436A7
	public override bool BBHDMMHCDKO()
	{
		return this.BOPJOMGIJIA == NEFOGCDMMFK.BMHGEBOHLHH.done;
	}

	// Token: 0x04000EB3 RID: 3763
	public NEFOGCDMMFK.BMHGEBOHLHH BOPJOMGIJIA;

	// Token: 0x02000179 RID: 377
	public enum BMHGEBOHLHH
	{
		// Token: 0x04000EB5 RID: 3765
		start,
		// Token: 0x04000EB6 RID: 3766
		done
	}
}
