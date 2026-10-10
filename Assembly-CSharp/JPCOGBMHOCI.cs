using System;
using System.Collections.Generic;

// Token: 0x02000533 RID: 1331
public class JPCOGBMHOCI : KGLBKJKNPFD
{
	// Token: 0x0600A208 RID: 41480 RVA: 0x00461680 File Offset: 0x0045F880
	public override string LDHNPOGPAOB()
	{
		return this.BOPJOMGIJIA.ToString();
	}

	// Token: 0x0600A209 RID: 41481 RVA: 0x0001FBB0 File Offset: 0x0001DDB0
	public override bool PINCOCDOOGH()
	{
		return false;
	}

	// Token: 0x0600A20A RID: 41482 RVA: 0x00461693 File Offset: 0x0045F893
	public override bool FMLECLNJAJM()
	{
		return this.BOPJOMGIJIA == (JPCOGBMHOCI.BMHGEBOHLHH)this.KOIINMNNNDJ;
	}

	// Token: 0x0600A20B RID: 41483 RVA: 0x004616A4 File Offset: 0x0045F8A4
	public JPCOGBMHOCI(string OFGJFNLDKGO)
	{
		this.OBKCKGHFMDN = KGLBKJKNPFD.LBFFMOMMAPK.environmentFade;
		if (OFGJFNLDKGO.Contains("time"))
		{
			this.AKCEKJFIGJH = HLDNEMHDEDH.NCIMIEAINEO(OFGJFNLDKGO, "time(", ')', true);
		}
		this.AKCEKJFIGJH *= AppManager.EHBBFMCILPC.debugSettings.OAEBOACHHOG(1f);
		if (OFGJFNLDKGO.Contains("sfx"))
		{
			this.JLEAIJGBGHL = HLDNEMHDEDH.LNLOHDKFDAA(OFGJFNLDKGO, "sfx(", ')', true);
		}
		if (OFGJFNLDKGO.Contains("sfxloop"))
		{
			this.MHCAKNHEPDE = (HLDNEMHDEDH.OKNGPMCDBFE(OFGJFNLDKGO, "sfxloop(", ')', true) == 1);
		}
		if (OFGJFNLDKGO.Contains("mus"))
		{
			this.KPPJINFHMIP = HLDNEMHDEDH.LNLOHDKFDAA(OFGJFNLDKGO, "mus(", ')', true);
		}
		if (OFGJFNLDKGO.Contains("fade"))
		{
			List<string> list = HLDNEMHDEDH.NNKLPOAODNF(OFGJFNLDKGO, "fade(", ')', true);
			if (list.Count > 0)
			{
				this.DCPHGFEEHHM = list[0];
				return;
			}
		}
		else if (OFGJFNLDKGO.Contains("color"))
		{
			List<string> list2 = HLDNEMHDEDH.NNKLPOAODNF(OFGJFNLDKGO, "color(", ')', true);
			if (list2.Count > 0)
			{
				this.DCPHGFEEHHM = list2[0];
				return;
			}
		}
		else
		{
			this.DCPHGFEEHHM = "black";
		}
	}

	// Token: 0x0600A20C RID: 41484 RVA: 0x00461803 File Offset: 0x0045FA03
	public override bool BBHDMMHCDKO()
	{
		return this.BOPJOMGIJIA == JPCOGBMHOCI.BMHGEBOHLHH.done;
	}

	// Token: 0x0600A20D RID: 41485 RVA: 0x0046180E File Offset: 0x0045FA0E
	public override void FEHODJMIAJL(int OIMDDBOOAOB = 1)
	{
		if (!this.BBHDMMHCDKO())
		{
			this.BOPJOMGIJIA += OIMDDBOOAOB;
		}
	}

	// Token: 0x04002C52 RID: 11346
	public JPCOGBMHOCI.BMHGEBOHLHH BOPJOMGIJIA;

	// Token: 0x04002C53 RID: 11347
	public float AKCEKJFIGJH = 1f;

	// Token: 0x04002C54 RID: 11348
	public string DCPHGFEEHHM = "black";

	// Token: 0x04002C55 RID: 11349
	public bool LLODADPOMJB;

	// Token: 0x04002C56 RID: 11350
	public string KPPJINFHMIP = "";

	// Token: 0x04002C57 RID: 11351
	public string JLEAIJGBGHL = "";

	// Token: 0x04002C58 RID: 11352
	public bool MHCAKNHEPDE;

	// Token: 0x02000534 RID: 1332
	public enum BMHGEBOHLHH
	{
		// Token: 0x04002C5A RID: 11354
		fadeIn,
		// Token: 0x04002C5B RID: 11355
		fadeOut,
		// Token: 0x04002C5C RID: 11356
		done
	}
}
