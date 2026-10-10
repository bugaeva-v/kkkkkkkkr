using System;

// Token: 0x02000020 RID: 32
public class LLNGEIMFHBB : KGLBKJKNPFD
{
	// Token: 0x060004CB RID: 1227 RVA: 0x0001FBB0 File Offset: 0x0001DDB0
	public override bool PINCOCDOOGH()
	{
		return false;
	}

	// Token: 0x060004CC RID: 1228 RVA: 0x0001FD74 File Offset: 0x0001DF74
	public LLNGEIMFHBB(string OFGJFNLDKGO)
	{
		this.OBKCKGHFMDN = KGLBKJKNPFD.LBFFMOMMAPK.playVoiceOver;
		this.HCOFJONDHDE = HLDNEMHDEDH.LNLOHDKFDAA(OFGJFNLDKGO, "id(", ')', true);
		if (OFGJFNLDKGO.Contains("time"))
		{
			this.PMMCLCMDNGA = HLDNEMHDEDH.NCIMIEAINEO(OFGJFNLDKGO, "time(", ')', true);
			this.PMMCLCMDNGA *= AppManager.EHBBFMCILPC.debugSettings.OAEBOACHHOG(1f);
		}
		if (OFGJFNLDKGO.Contains("delay"))
		{
			this.LJLHCJFDNGL = HLDNEMHDEDH.NCIMIEAINEO(OFGJFNLDKGO, "delay(", ')', true);
			this.LJLHCJFDNGL *= AppManager.EHBBFMCILPC.debugSettings.OAEBOACHHOG(1f);
		}
	}

	// Token: 0x060004CD RID: 1229 RVA: 0x0001FE48 File Offset: 0x0001E048
	public override bool FMLECLNJAJM()
	{
		return this.BOPJOMGIJIA == (LLNGEIMFHBB.BMHGEBOHLHH)this.KOIINMNNNDJ;
	}

	// Token: 0x060004CE RID: 1230 RVA: 0x0001FE58 File Offset: 0x0001E058
	public override void FEHODJMIAJL(int OIMDDBOOAOB = 1)
	{
		if (!this.BBHDMMHCDKO())
		{
			this.BOPJOMGIJIA += OIMDDBOOAOB;
		}
	}

	// Token: 0x060004CF RID: 1231 RVA: 0x0001FE70 File Offset: 0x0001E070
	public override string LDHNPOGPAOB()
	{
		return this.BOPJOMGIJIA.ToString();
	}

	// Token: 0x060004D0 RID: 1232 RVA: 0x0001FE83 File Offset: 0x0001E083
	public override bool BBHDMMHCDKO()
	{
		return this.BOPJOMGIJIA == LLNGEIMFHBB.BMHGEBOHLHH.done;
	}

	// Token: 0x04000133 RID: 307
	public string HCOFJONDHDE = "";

	// Token: 0x04000134 RID: 308
	public float PMMCLCMDNGA = -1f;

	// Token: 0x04000135 RID: 309
	public float LJLHCJFDNGL = -1f;

	// Token: 0x04000136 RID: 310
	public LLNGEIMFHBB.BMHGEBOHLHH BOPJOMGIJIA;

	// Token: 0x02000021 RID: 33
	public enum BMHGEBOHLHH
	{
		// Token: 0x04000138 RID: 312
		start,
		// Token: 0x04000139 RID: 313
		done
	}
}
