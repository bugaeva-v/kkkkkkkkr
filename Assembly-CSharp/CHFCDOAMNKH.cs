using System;
using System.Collections.Generic;

// Token: 0x0200002D RID: 45
public class CHFCDOAMNKH : KGLBKJKNPFD
{
	// Token: 0x0600067F RID: 1663 RVA: 0x0002EEB8 File Offset: 0x0002D0B8
	public CHFCDOAMNKH(string OFGJFNLDKGO)
	{
		this.OBKCKGHFMDN = KGLBKJKNPFD.LBFFMOMMAPK.environmentFadeSrc;
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

	// Token: 0x06000680 RID: 1664 RVA: 0x0001FBB0 File Offset: 0x0001DDB0
	public override bool PINCOCDOOGH()
	{
		return false;
	}

	// Token: 0x06000681 RID: 1665 RVA: 0x0002F017 File Offset: 0x0002D217
	public override bool FMLECLNJAJM()
	{
		return this.BOPJOMGIJIA == (CHFCDOAMNKH.BMHGEBOHLHH)this.KOIINMNNNDJ;
	}

	// Token: 0x06000682 RID: 1666 RVA: 0x0002F027 File Offset: 0x0002D227
	public override void FEHODJMIAJL(int OIMDDBOOAOB = 1)
	{
		if (!this.BBHDMMHCDKO())
		{
			this.BOPJOMGIJIA += OIMDDBOOAOB;
		}
	}

	// Token: 0x06000683 RID: 1667 RVA: 0x0002F03F File Offset: 0x0002D23F
	public override string LDHNPOGPAOB()
	{
		return this.BOPJOMGIJIA.ToString();
	}

	// Token: 0x06000684 RID: 1668 RVA: 0x0002F052 File Offset: 0x0002D252
	public override bool BBHDMMHCDKO()
	{
		return this.BOPJOMGIJIA == CHFCDOAMNKH.BMHGEBOHLHH.done;
	}

	// Token: 0x040001A6 RID: 422
	public CHFCDOAMNKH.BMHGEBOHLHH BOPJOMGIJIA;

	// Token: 0x040001A7 RID: 423
	public float AKCEKJFIGJH = 1f;

	// Token: 0x040001A8 RID: 424
	public bool LLODADPOMJB;

	// Token: 0x040001A9 RID: 425
	public string KPPJINFHMIP = "";

	// Token: 0x040001AA RID: 426
	public string JLEAIJGBGHL = "";

	// Token: 0x040001AB RID: 427
	public bool MHCAKNHEPDE;

	// Token: 0x040001AC RID: 428
	public string DCPHGFEEHHM = "black";

	// Token: 0x0200002E RID: 46
	public enum BMHGEBOHLHH
	{
		// Token: 0x040001AE RID: 430
		fadeIn,
		// Token: 0x040001AF RID: 431
		done
	}
}
