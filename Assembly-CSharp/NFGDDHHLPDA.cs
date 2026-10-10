using System;

// Token: 0x02000484 RID: 1156
public class NFGDDHHLPDA : KGLBKJKNPFD
{
	// Token: 0x06008BF4 RID: 35828 RVA: 0x003DF9A6 File Offset: 0x003DDBA6
	public override bool FMLECLNJAJM()
	{
		return this.BOPJOMGIJIA == (NFGDDHHLPDA.BMHGEBOHLHH)this.KOIINMNNNDJ;
	}

	// Token: 0x06008BF5 RID: 35829 RVA: 0x003DF9B6 File Offset: 0x003DDBB6
	public override string LDHNPOGPAOB()
	{
		return this.BOPJOMGIJIA.ToString();
	}

	// Token: 0x06008BF6 RID: 35830 RVA: 0x003DF9C9 File Offset: 0x003DDBC9
	public override bool BBHDMMHCDKO()
	{
		return this.BOPJOMGIJIA == NFGDDHHLPDA.BMHGEBOHLHH.done;
	}

	// Token: 0x06008BF7 RID: 35831 RVA: 0x003DF9D4 File Offset: 0x003DDBD4
	public override void FEHODJMIAJL(int OIMDDBOOAOB = 1)
	{
		if (!this.BBHDMMHCDKO())
		{
			this.BOPJOMGIJIA += OIMDDBOOAOB;
		}
	}

	// Token: 0x06008BF8 RID: 35832 RVA: 0x0001FBB0 File Offset: 0x0001DDB0
	public override bool PINCOCDOOGH()
	{
		return false;
	}

	// Token: 0x06008BF9 RID: 35833 RVA: 0x003DF9EC File Offset: 0x003DDBEC
	public NFGDDHHLPDA(string OFGJFNLDKGO)
	{
		this.OBKCKGHFMDN = KGLBKJKNPFD.LBFFMOMMAPK.fadeMusic;
		if (OFGJFNLDKGO.Contains("time"))
		{
			this.PMMCLCMDNGA = HLDNEMHDEDH.NCIMIEAINEO(OFGJFNLDKGO, "time(", ')', true);
		}
		this.PMMCLCMDNGA *= AppManager.EHBBFMCILPC.debugSettings.OAEBOACHHOG(1f);
		if (OFGJFNLDKGO.Contains("volume"))
		{
			this.GAMOMEFNKML = HLDNEMHDEDH.NCIMIEAINEO(OFGJFNLDKGO, "volume(", ')', true);
		}
	}

	// Token: 0x0400273D RID: 10045
	public float PMMCLCMDNGA = 2f;

	// Token: 0x0400273E RID: 10046
	public float GAMOMEFNKML = 1f;

	// Token: 0x0400273F RID: 10047
	public NFGDDHHLPDA.BMHGEBOHLHH BOPJOMGIJIA;

	// Token: 0x02000485 RID: 1157
	public enum BMHGEBOHLHH
	{
		// Token: 0x04002741 RID: 10049
		start,
		// Token: 0x04002742 RID: 10050
		done
	}
}
