using System;

// Token: 0x02000312 RID: 786
public class HLIEMKBHHLB : KGLBKJKNPFD
{
	// Token: 0x06005EBA RID: 24250 RVA: 0x0001FBB0 File Offset: 0x0001DDB0
	public override bool PINCOCDOOGH()
	{
		return false;
	}

	// Token: 0x06005EBB RID: 24251 RVA: 0x002AFE23 File Offset: 0x002AE023
	public override void FEHODJMIAJL(int OIMDDBOOAOB = 1)
	{
		if (!this.BBHDMMHCDKO())
		{
			this.BOPJOMGIJIA += OIMDDBOOAOB;
		}
	}

	// Token: 0x06005EBC RID: 24252 RVA: 0x002AFE3B File Offset: 0x002AE03B
	public override bool FMLECLNJAJM()
	{
		return this.BOPJOMGIJIA == (HLIEMKBHHLB.BMHGEBOHLHH)this.KOIINMNNNDJ;
	}

	// Token: 0x06005EBD RID: 24253 RVA: 0x002AFE4C File Offset: 0x002AE04C
	public HLIEMKBHHLB(string OFGJFNLDKGO)
	{
		this.OBKCKGHFMDN = KGLBKJKNPFD.LBFFMOMMAPK.playAmbient;
		this.HCOFJONDHDE = HLDNEMHDEDH.LNLOHDKFDAA(OFGJFNLDKGO, "id(", ')', true);
		if (OFGJFNLDKGO.Contains("time"))
		{
			this.PMMCLCMDNGA = HLDNEMHDEDH.NCIMIEAINEO(OFGJFNLDKGO, "time(", ')', true);
			this.PMMCLCMDNGA *= AppManager.EHBBFMCILPC.debugSettings.OAEBOACHHOG(1f);
		}
	}

	// Token: 0x06005EBE RID: 24254 RVA: 0x002AFED3 File Offset: 0x002AE0D3
	public override bool BBHDMMHCDKO()
	{
		return this.BOPJOMGIJIA == HLIEMKBHHLB.BMHGEBOHLHH.done;
	}

	// Token: 0x06005EBF RID: 24255 RVA: 0x002AFEDE File Offset: 0x002AE0DE
	public override string LDHNPOGPAOB()
	{
		return this.BOPJOMGIJIA.ToString();
	}

	// Token: 0x04001B14 RID: 6932
	public string HCOFJONDHDE = "";

	// Token: 0x04001B15 RID: 6933
	public float PMMCLCMDNGA = -1f;

	// Token: 0x04001B16 RID: 6934
	public HLIEMKBHHLB.BMHGEBOHLHH BOPJOMGIJIA;

	// Token: 0x02000313 RID: 787
	public enum BMHGEBOHLHH
	{
		// Token: 0x04001B18 RID: 6936
		start,
		// Token: 0x04001B19 RID: 6937
		done
	}
}
