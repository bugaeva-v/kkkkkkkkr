using System;

// Token: 0x020002CF RID: 719
public class ALAELCDLPCP : KGLBKJKNPFD
{
	// Token: 0x06005915 RID: 22805 RVA: 0x0028304A File Offset: 0x0028124A
	public override bool FMLECLNJAJM()
	{
		return this.BOPJOMGIJIA == (ALAELCDLPCP.BMHGEBOHLHH)this.KOIINMNNNDJ;
	}

	// Token: 0x06005916 RID: 22806 RVA: 0x0028305A File Offset: 0x0028125A
	public ALAELCDLPCP(string OFGJFNLDKGO)
	{
		this.OBKCKGHFMDN = KGLBKJKNPFD.LBFFMOMMAPK.useTranslationV2;
	}

	// Token: 0x06005917 RID: 22807 RVA: 0x0028306A File Offset: 0x0028126A
	public override void FEHODJMIAJL(int OIMDDBOOAOB = 1)
	{
		if (!this.BBHDMMHCDKO())
		{
			this.BOPJOMGIJIA += OIMDDBOOAOB;
		}
	}

	// Token: 0x06005918 RID: 22808 RVA: 0x0001FBB0 File Offset: 0x0001DDB0
	public override bool PINCOCDOOGH()
	{
		return false;
	}

	// Token: 0x06005919 RID: 22809 RVA: 0x00283082 File Offset: 0x00281282
	public override string LDHNPOGPAOB()
	{
		return this.BOPJOMGIJIA.ToString();
	}

	// Token: 0x0600591A RID: 22810 RVA: 0x00283095 File Offset: 0x00281295
	public override bool BBHDMMHCDKO()
	{
		return this.BOPJOMGIJIA == ALAELCDLPCP.BMHGEBOHLHH.done;
	}

	// Token: 0x04001943 RID: 6467
	public ALAELCDLPCP.BMHGEBOHLHH BOPJOMGIJIA;

	// Token: 0x020002D0 RID: 720
	public enum BMHGEBOHLHH
	{
		// Token: 0x04001945 RID: 6469
		start,
		// Token: 0x04001946 RID: 6470
		done
	}
}
