using System;

// Token: 0x0200037A RID: 890
public class DFFNHBJMFMP : KGLBKJKNPFD
{
	// Token: 0x060068C5 RID: 26821 RVA: 0x00302A1B File Offset: 0x00300C1B
	public override void FEHODJMIAJL(int OIMDDBOOAOB = 1)
	{
		if (!this.BBHDMMHCDKO())
		{
			this.BOPJOMGIJIA += OIMDDBOOAOB;
		}
	}

	// Token: 0x060068C6 RID: 26822 RVA: 0x00302A33 File Offset: 0x00300C33
	public DFFNHBJMFMP(string OFGJFNLDKGO)
	{
		this.OBKCKGHFMDN = KGLBKJKNPFD.LBFFMOMMAPK.useVideoV2;
	}

	// Token: 0x060068C7 RID: 26823 RVA: 0x00302A43 File Offset: 0x00300C43
	public override bool FMLECLNJAJM()
	{
		return this.BOPJOMGIJIA == (DFFNHBJMFMP.BMHGEBOHLHH)this.KOIINMNNNDJ;
	}

	// Token: 0x060068C8 RID: 26824 RVA: 0x00302A53 File Offset: 0x00300C53
	public override string LDHNPOGPAOB()
	{
		return this.BOPJOMGIJIA.ToString();
	}

	// Token: 0x060068C9 RID: 26825 RVA: 0x00302A66 File Offset: 0x00300C66
	public override bool BBHDMMHCDKO()
	{
		return this.BOPJOMGIJIA == DFFNHBJMFMP.BMHGEBOHLHH.done;
	}

	// Token: 0x060068CA RID: 26826 RVA: 0x0001FBB0 File Offset: 0x0001DDB0
	public override bool PINCOCDOOGH()
	{
		return false;
	}

	// Token: 0x04001EEF RID: 7919
	public DFFNHBJMFMP.BMHGEBOHLHH BOPJOMGIJIA;

	// Token: 0x0200037B RID: 891
	public enum BMHGEBOHLHH
	{
		// Token: 0x04001EF1 RID: 7921
		start,
		// Token: 0x04001EF2 RID: 7922
		done
	}
}
