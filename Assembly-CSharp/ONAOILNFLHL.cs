using System;

// Token: 0x020001B4 RID: 436
public class ONAOILNFLHL : KGLBKJKNPFD
{
	// Token: 0x060035C6 RID: 13766 RVA: 0x001664C4 File Offset: 0x001646C4
	public override string LDHNPOGPAOB()
	{
		return this.BOPJOMGIJIA.ToString();
	}

	// Token: 0x060035C7 RID: 13767 RVA: 0x001664D8 File Offset: 0x001646D8
	public ONAOILNFLHL(string OFGJFNLDKGO)
	{
		this.OBKCKGHFMDN = KGLBKJKNPFD.LBFFMOMMAPK.stopMusic;
		if (OFGJFNLDKGO.Contains("id"))
		{
			this.HCOFJONDHDE = HLDNEMHDEDH.LNLOHDKFDAA(OFGJFNLDKGO, "id(", ')', true);
		}
		if (OFGJFNLDKGO.Contains("time"))
		{
			this.PMMCLCMDNGA = HLDNEMHDEDH.NCIMIEAINEO(OFGJFNLDKGO, "time(", ')', true);
		}
		this.PMMCLCMDNGA *= AppManager.EHBBFMCILPC.debugSettings.OAEBOACHHOG(1f);
	}

	// Token: 0x060035C8 RID: 13768 RVA: 0x0016656C File Offset: 0x0016476C
	public override bool FMLECLNJAJM()
	{
		return this.BOPJOMGIJIA == (ONAOILNFLHL.BMHGEBOHLHH)this.KOIINMNNNDJ;
	}

	// Token: 0x060035C9 RID: 13769 RVA: 0x0001FBB0 File Offset: 0x0001DDB0
	public override bool PINCOCDOOGH()
	{
		return false;
	}

	// Token: 0x060035CA RID: 13770 RVA: 0x0016657C File Offset: 0x0016477C
	public override bool BBHDMMHCDKO()
	{
		return this.BOPJOMGIJIA == ONAOILNFLHL.BMHGEBOHLHH.done;
	}

	// Token: 0x060035CB RID: 13771 RVA: 0x00166587 File Offset: 0x00164787
	public override void FEHODJMIAJL(int OIMDDBOOAOB = 1)
	{
		if (!this.BBHDMMHCDKO())
		{
			this.BOPJOMGIJIA += OIMDDBOOAOB;
		}
	}

	// Token: 0x04000FFC RID: 4092
	public string HCOFJONDHDE = "";

	// Token: 0x04000FFD RID: 4093
	public float PMMCLCMDNGA = 2f;

	// Token: 0x04000FFE RID: 4094
	public ONAOILNFLHL.BMHGEBOHLHH BOPJOMGIJIA;

	// Token: 0x020001B5 RID: 437
	public enum BMHGEBOHLHH
	{
		// Token: 0x04001000 RID: 4096
		start,
		// Token: 0x04001001 RID: 4097
		done
	}
}
