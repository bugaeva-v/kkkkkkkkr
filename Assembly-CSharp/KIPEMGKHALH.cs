using System;

// Token: 0x02000387 RID: 903
public class KIPEMGKHALH : KGLBKJKNPFD
{
	// Token: 0x06006A3F RID: 27199 RVA: 0x0030CA37 File Offset: 0x0030AC37
	public override bool FMLECLNJAJM()
	{
		return this.BOPJOMGIJIA == (KIPEMGKHALH.BMHGEBOHLHH)this.KOIINMNNNDJ;
	}

	// Token: 0x06006A40 RID: 27200 RVA: 0x0030CA47 File Offset: 0x0030AC47
	public override void FEHODJMIAJL(int OIMDDBOOAOB = 1)
	{
		if (!this.BBHDMMHCDKO())
		{
			this.BOPJOMGIJIA += OIMDDBOOAOB;
		}
	}

	// Token: 0x06006A41 RID: 27201 RVA: 0x0030CA60 File Offset: 0x0030AC60
	public KIPEMGKHALH(string OFGJFNLDKGO)
	{
		this.OBKCKGHFMDN = KGLBKJKNPFD.LBFFMOMMAPK.playMusic;
		this.HCOFJONDHDE = HLDNEMHDEDH.LNLOHDKFDAA(OFGJFNLDKGO, "id(", ')', true);
		this.KKMKFJLDDNJ = (HLDNEMHDEDH.OKNGPMCDBFE(OFGJFNLDKGO, "loop(", ')', true) == 1);
		if (OFGJFNLDKGO.Contains("time"))
		{
			this.PMMCLCMDNGA = HLDNEMHDEDH.NCIMIEAINEO(OFGJFNLDKGO, "time(", ')', true);
			this.PMMCLCMDNGA *= AppManager.EHBBFMCILPC.debugSettings.OAEBOACHHOG(1f);
		}
	}

	// Token: 0x06006A42 RID: 27202 RVA: 0x0001FBB0 File Offset: 0x0001DDB0
	public override bool PINCOCDOOGH()
	{
		return false;
	}

	// Token: 0x06006A43 RID: 27203 RVA: 0x0030CAFE File Offset: 0x0030ACFE
	public override string LDHNPOGPAOB()
	{
		return this.BOPJOMGIJIA.ToString();
	}

	// Token: 0x06006A44 RID: 27204 RVA: 0x0030CB11 File Offset: 0x0030AD11
	public override bool BBHDMMHCDKO()
	{
		return this.BOPJOMGIJIA == KIPEMGKHALH.BMHGEBOHLHH.done;
	}

	// Token: 0x04001F19 RID: 7961
	public string HCOFJONDHDE = "";

	// Token: 0x04001F1A RID: 7962
	public bool KKMKFJLDDNJ;

	// Token: 0x04001F1B RID: 7963
	public float PMMCLCMDNGA = -1f;

	// Token: 0x04001F1C RID: 7964
	public KIPEMGKHALH.BMHGEBOHLHH BOPJOMGIJIA;

	// Token: 0x02000388 RID: 904
	public enum BMHGEBOHLHH
	{
		// Token: 0x04001F1E RID: 7966
		start,
		// Token: 0x04001F1F RID: 7967
		done
	}
}
