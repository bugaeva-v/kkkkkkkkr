using System;
using System.Collections.Generic;

// Token: 0x020001BD RID: 445
public class OMAAAEFJKJP : KGLBKJKNPFD
{
	// Token: 0x0600378A RID: 14218 RVA: 0x00170440 File Offset: 0x0016E640
	public OMAAAEFJKJP(string OFGJFNLDKGO)
	{
		this.OBKCKGHFMDN = KGLBKJKNPFD.LBFFMOMMAPK.environmentFadeDst;
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

	// Token: 0x0600378B RID: 14219 RVA: 0x0017059F File Offset: 0x0016E79F
	public override void FEHODJMIAJL(int OIMDDBOOAOB = 1)
	{
		if (!this.BBHDMMHCDKO())
		{
			this.BOPJOMGIJIA += OIMDDBOOAOB;
		}
	}

	// Token: 0x0600378C RID: 14220 RVA: 0x0001FBB0 File Offset: 0x0001DDB0
	public override bool PINCOCDOOGH()
	{
		return false;
	}

	// Token: 0x0600378D RID: 14221 RVA: 0x001705B7 File Offset: 0x0016E7B7
	public override bool BBHDMMHCDKO()
	{
		return this.BOPJOMGIJIA == OMAAAEFJKJP.BMHGEBOHLHH.done;
	}

	// Token: 0x0600378E RID: 14222 RVA: 0x001705C2 File Offset: 0x0016E7C2
	public override bool FMLECLNJAJM()
	{
		return this.BOPJOMGIJIA == (OMAAAEFJKJP.BMHGEBOHLHH)this.KOIINMNNNDJ;
	}

	// Token: 0x0600378F RID: 14223 RVA: 0x001705D2 File Offset: 0x0016E7D2
	public override string LDHNPOGPAOB()
	{
		return this.BOPJOMGIJIA.ToString();
	}

	// Token: 0x0400106E RID: 4206
	public OMAAAEFJKJP.BMHGEBOHLHH BOPJOMGIJIA;

	// Token: 0x0400106F RID: 4207
	public float AKCEKJFIGJH = 1f;

	// Token: 0x04001070 RID: 4208
	public string DCPHGFEEHHM = "black";

	// Token: 0x04001071 RID: 4209
	public bool LLODADPOMJB;

	// Token: 0x04001072 RID: 4210
	public string KPPJINFHMIP = "";

	// Token: 0x04001073 RID: 4211
	public string JLEAIJGBGHL = "";

	// Token: 0x04001074 RID: 4212
	public bool MHCAKNHEPDE;

	// Token: 0x020001BE RID: 446
	public enum BMHGEBOHLHH
	{
		// Token: 0x04001076 RID: 4214
		fadeOut,
		// Token: 0x04001077 RID: 4215
		done
	}
}
