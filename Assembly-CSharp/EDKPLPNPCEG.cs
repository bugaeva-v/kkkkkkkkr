using System;

// Token: 0x0200017B RID: 379
public class EDKPLPNPCEG : KGLBKJKNPFD
{
	// Token: 0x06002F3E RID: 12094 RVA: 0x001454B2 File Offset: 0x001436B2
	public override bool FMLECLNJAJM()
	{
		return this.BOPJOMGIJIA == (EDKPLPNPCEG.BMHGEBOHLHH)this.KOIINMNNNDJ;
	}

	// Token: 0x06002F3F RID: 12095 RVA: 0x001454C2 File Offset: 0x001436C2
	public override bool BBHDMMHCDKO()
	{
		return this.BOPJOMGIJIA == EDKPLPNPCEG.BMHGEBOHLHH.done;
	}

	// Token: 0x06002F40 RID: 12096 RVA: 0x001454CD File Offset: 0x001436CD
	public override void FEHODJMIAJL(int OIMDDBOOAOB = 1)
	{
		if (!this.BBHDMMHCDKO())
		{
			this.BOPJOMGIJIA += OIMDDBOOAOB;
		}
	}

	// Token: 0x06002F41 RID: 12097 RVA: 0x001454E5 File Offset: 0x001436E5
	public override string LDHNPOGPAOB()
	{
		return this.BOPJOMGIJIA.ToString();
	}

	// Token: 0x06002F42 RID: 12098 RVA: 0x001454F8 File Offset: 0x001436F8
	public EDKPLPNPCEG(string OFGJFNLDKGO)
	{
		this.OBKCKGHFMDN = KGLBKJKNPFD.LBFFMOMMAPK.npcFadeIn;
		this.PMMCLCMDNGA = HLDNEMHDEDH.NCIMIEAINEO(OFGJFNLDKGO, "time(", ')', true);
		this.PMMCLCMDNGA *= AppManager.EHBBFMCILPC.debugSettings.OAEBOACHHOG(1f);
	}

	// Token: 0x06002F43 RID: 12099 RVA: 0x0001FBB0 File Offset: 0x0001DDB0
	public override bool PINCOCDOOGH()
	{
		return false;
	}

	// Token: 0x04000EBA RID: 3770
	public EDKPLPNPCEG.BMHGEBOHLHH BOPJOMGIJIA;

	// Token: 0x04000EBB RID: 3771
	public float PMMCLCMDNGA = 1f;

	// Token: 0x0200017C RID: 380
	public enum BMHGEBOHLHH
	{
		// Token: 0x04000EBD RID: 3773
		start,
		// Token: 0x04000EBE RID: 3774
		done
	}
}
