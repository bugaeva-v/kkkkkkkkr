using System;

// Token: 0x02000531 RID: 1329
public class FBFJEIPLFIP : KGLBKJKNPFD
{
	// Token: 0x0600A202 RID: 41474 RVA: 0x004615A5 File Offset: 0x0045F7A5
	public override string LDHNPOGPAOB()
	{
		return this.BOPJOMGIJIA.ToString();
	}

	// Token: 0x0600A203 RID: 41475 RVA: 0x004615B8 File Offset: 0x0045F7B8
	public override bool BBHDMMHCDKO()
	{
		return this.BOPJOMGIJIA == FBFJEIPLFIP.BMHGEBOHLHH.done;
	}

	// Token: 0x0600A204 RID: 41476 RVA: 0x004615C3 File Offset: 0x0045F7C3
	public override bool FMLECLNJAJM()
	{
		return this.BOPJOMGIJIA == (FBFJEIPLFIP.BMHGEBOHLHH)this.KOIINMNNNDJ;
	}

	// Token: 0x0600A205 RID: 41477 RVA: 0x004615D3 File Offset: 0x0045F7D3
	public override void FEHODJMIAJL(int OIMDDBOOAOB = 1)
	{
		if (!this.BBHDMMHCDKO())
		{
			this.BOPJOMGIJIA += OIMDDBOOAOB;
		}
	}

	// Token: 0x0600A206 RID: 41478 RVA: 0x0001FBB0 File Offset: 0x0001DDB0
	public override bool PINCOCDOOGH()
	{
		return false;
	}

	// Token: 0x0600A207 RID: 41479 RVA: 0x004615EC File Offset: 0x0045F7EC
	public FBFJEIPLFIP(string OFGJFNLDKGO)
	{
		this.OBKCKGHFMDN = KGLBKJKNPFD.LBFFMOMMAPK.stopSfx;
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

	// Token: 0x04002C4C RID: 11340
	public string HCOFJONDHDE = "";

	// Token: 0x04002C4D RID: 11341
	public float PMMCLCMDNGA = 2f;

	// Token: 0x04002C4E RID: 11342
	public FBFJEIPLFIP.BMHGEBOHLHH BOPJOMGIJIA;

	// Token: 0x02000532 RID: 1330
	public enum BMHGEBOHLHH
	{
		// Token: 0x04002C50 RID: 11344
		start,
		// Token: 0x04002C51 RID: 11345
		done
	}
}
