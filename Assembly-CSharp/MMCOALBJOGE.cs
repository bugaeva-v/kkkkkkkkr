using System;

// Token: 0x020002A3 RID: 675
public class MMCOALBJOGE : KGLBKJKNPFD
{
	// Token: 0x06005558 RID: 21848 RVA: 0x0025B9B4 File Offset: 0x00259BB4
	public override bool BBHDMMHCDKO()
	{
		return this.BOPJOMGIJIA == MMCOALBJOGE.BMHGEBOHLHH.done;
	}

	// Token: 0x06005559 RID: 21849 RVA: 0x0025B9BF File Offset: 0x00259BBF
	public MMCOALBJOGE(string OFGJFNLDKGO)
	{
		this.OBKCKGHFMDN = KGLBKJKNPFD.LBFFMOMMAPK.restoreEnvSnapshot;
	}

	// Token: 0x0600555A RID: 21850 RVA: 0x0001FBB0 File Offset: 0x0001DDB0
	public override bool PINCOCDOOGH()
	{
		return false;
	}

	// Token: 0x0600555B RID: 21851 RVA: 0x0025B9CF File Offset: 0x00259BCF
	public override void FEHODJMIAJL(int OIMDDBOOAOB = 1)
	{
		if (!this.BBHDMMHCDKO())
		{
			this.BOPJOMGIJIA += OIMDDBOOAOB;
		}
	}

	// Token: 0x0600555C RID: 21852 RVA: 0x0025B9E7 File Offset: 0x00259BE7
	public override bool FMLECLNJAJM()
	{
		return this.BOPJOMGIJIA == (MMCOALBJOGE.BMHGEBOHLHH)this.KOIINMNNNDJ;
	}

	// Token: 0x0600555D RID: 21853 RVA: 0x0025B9F7 File Offset: 0x00259BF7
	public override string LDHNPOGPAOB()
	{
		return this.BOPJOMGIJIA.ToString();
	}

	// Token: 0x040017C2 RID: 6082
	public MMCOALBJOGE.BMHGEBOHLHH BOPJOMGIJIA;

	// Token: 0x020002A4 RID: 676
	public enum BMHGEBOHLHH
	{
		// Token: 0x040017C4 RID: 6084
		start,
		// Token: 0x040017C5 RID: 6085
		done
	}
}
