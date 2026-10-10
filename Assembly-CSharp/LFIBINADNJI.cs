using System;

// Token: 0x02000399 RID: 921
public class LFIBINADNJI : KGLBKJKNPFD
{
	// Token: 0x06006B89 RID: 27529 RVA: 0x00312324 File Offset: 0x00310524
	public override void FEHODJMIAJL(int OIMDDBOOAOB = 1)
	{
		if (!this.BBHDMMHCDKO())
		{
			this.BOPJOMGIJIA += OIMDDBOOAOB;
		}
	}

	// Token: 0x06006B8A RID: 27530 RVA: 0x0031233C File Offset: 0x0031053C
	public override bool FMLECLNJAJM()
	{
		return this.BOPJOMGIJIA == (LFIBINADNJI.BMHGEBOHLHH)this.KOIINMNNNDJ;
	}

	// Token: 0x06006B8B RID: 27531 RVA: 0x0031234C File Offset: 0x0031054C
	public override string LDHNPOGPAOB()
	{
		return this.BOPJOMGIJIA.ToString();
	}

	// Token: 0x06006B8C RID: 27532 RVA: 0x0001FBB0 File Offset: 0x0001DDB0
	public override bool PINCOCDOOGH()
	{
		return false;
	}

	// Token: 0x06006B8D RID: 27533 RVA: 0x00312360 File Offset: 0x00310560
	public LFIBINADNJI(string OFGJFNLDKGO)
	{
		this.OBKCKGHFMDN = KGLBKJKNPFD.LBFFMOMMAPK.playSfx;
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
		if (OFGJFNLDKGO.Contains("loop"))
		{
			this.KKMKFJLDDNJ = (HLDNEMHDEDH.OKNGPMCDBFE(OFGJFNLDKGO, "loop(", ')', true) == 1);
		}
	}

	// Token: 0x06006B8E RID: 27534 RVA: 0x00312458 File Offset: 0x00310658
	public override bool BBHDMMHCDKO()
	{
		return this.BOPJOMGIJIA == LFIBINADNJI.BMHGEBOHLHH.done;
	}

	// Token: 0x04001F98 RID: 8088
	public string HCOFJONDHDE = "";

	// Token: 0x04001F99 RID: 8089
	public float PMMCLCMDNGA = -1f;

	// Token: 0x04001F9A RID: 8090
	public float LJLHCJFDNGL = -1f;

	// Token: 0x04001F9B RID: 8091
	public bool KKMKFJLDDNJ;

	// Token: 0x04001F9C RID: 8092
	public LFIBINADNJI.BMHGEBOHLHH BOPJOMGIJIA;

	// Token: 0x0200039A RID: 922
	public enum BMHGEBOHLHH
	{
		// Token: 0x04001F9E RID: 8094
		start,
		// Token: 0x04001F9F RID: 8095
		done
	}
}
