using System;

// Token: 0x02000341 RID: 833
public class JBONAGNDJGI : KGLBKJKNPFD
{
	// Token: 0x06006312 RID: 25362 RVA: 0x002D7ADC File Offset: 0x002D5CDC
	public override bool FMLECLNJAJM()
	{
		return this.BOPJOMGIJIA == (JBONAGNDJGI.BMHGEBOHLHH)this.KOIINMNNNDJ;
	}

	// Token: 0x06006313 RID: 25363 RVA: 0x0001FBB0 File Offset: 0x0001DDB0
	public override bool PINCOCDOOGH()
	{
		return false;
	}

	// Token: 0x06006314 RID: 25364 RVA: 0x002D7AEC File Offset: 0x002D5CEC
	public override string LDHNPOGPAOB()
	{
		return this.BOPJOMGIJIA.ToString();
	}

	// Token: 0x06006315 RID: 25365 RVA: 0x002D7AFF File Offset: 0x002D5CFF
	public override bool BBHDMMHCDKO()
	{
		return this.BOPJOMGIJIA == JBONAGNDJGI.BMHGEBOHLHH.done;
	}

	// Token: 0x06006316 RID: 25366 RVA: 0x002D7B0A File Offset: 0x002D5D0A
	public override void FEHODJMIAJL(int OIMDDBOOAOB = 1)
	{
		if (!this.BBHDMMHCDKO())
		{
			this.BOPJOMGIJIA += OIMDDBOOAOB;
		}
	}

	// Token: 0x06006317 RID: 25367 RVA: 0x002D7B24 File Offset: 0x002D5D24
	public JBONAGNDJGI(string OFGJFNLDKGO)
	{
		this.OBKCKGHFMDN = KGLBKJKNPFD.LBFFMOMMAPK.stopAmbient;
		if (OFGJFNLDKGO.Contains("time"))
		{
			this.PMMCLCMDNGA = HLDNEMHDEDH.NCIMIEAINEO(OFGJFNLDKGO, "time(", ')', true);
			this.PMMCLCMDNGA *= AppManager.EHBBFMCILPC.debugSettings.OAEBOACHHOG(1f);
		}
	}

	// Token: 0x04001CAE RID: 7342
	public JBONAGNDJGI.BMHGEBOHLHH BOPJOMGIJIA;

	// Token: 0x04001CAF RID: 7343
	public float PMMCLCMDNGA = -1f;

	// Token: 0x02000342 RID: 834
	public enum BMHGEBOHLHH
	{
		// Token: 0x04001CB1 RID: 7345
		start,
		// Token: 0x04001CB2 RID: 7346
		done
	}
}
