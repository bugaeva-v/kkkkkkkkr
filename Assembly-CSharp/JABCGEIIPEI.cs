using System;
using System.Collections.Generic;

// Token: 0x020001C3 RID: 451
public class JABCGEIIPEI : KGLBKJKNPFD
{
	// Token: 0x060037D4 RID: 14292 RVA: 0x0001FBB0 File Offset: 0x0001DDB0
	public override bool PINCOCDOOGH()
	{
		return false;
	}

	// Token: 0x060037D5 RID: 14293 RVA: 0x00171B17 File Offset: 0x0016FD17
	public override bool BBHDMMHCDKO()
	{
		return this.BOPJOMGIJIA == JABCGEIIPEI.BMHGEBOHLHH.done;
	}

	// Token: 0x060037D6 RID: 14294 RVA: 0x00171B22 File Offset: 0x0016FD22
	public override bool FMLECLNJAJM()
	{
		return this.BOPJOMGIJIA == (JABCGEIIPEI.BMHGEBOHLHH)this.KOIINMNNNDJ;
	}

	// Token: 0x060037D7 RID: 14295 RVA: 0x00171B32 File Offset: 0x0016FD32
	public override string LDHNPOGPAOB()
	{
		return this.BOPJOMGIJIA.ToString();
	}

	// Token: 0x060037D8 RID: 14296 RVA: 0x00171B48 File Offset: 0x0016FD48
	public JABCGEIIPEI(string OFGJFNLDKGO)
	{
		this.OBKCKGHFMDN = KGLBKJKNPFD.LBFFMOMMAPK.layerShow;
		if (OFGJFNLDKGO.Contains("id("))
		{
			this.LOCCINPEPKC = HLDNEMHDEDH.NNKLPOAODNF(OFGJFNLDKGO, "id(", ')', true);
		}
		if (OFGJFNLDKGO.Contains("alpha"))
		{
			List<string> list = HLDNEMHDEDH.NNKLPOAODNF(OFGJFNLDKGO, "alpha(", ')', true);
			if (list.Count > 0)
			{
				this.ABLPJMDMIPB = float.Parse(list[0]);
			}
			if (list.Count > 1)
			{
				this.AHHCLMBOCON = float.Parse(list[1]);
			}
		}
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
		else if (OFGJFNLDKGO.Contains("wait"))
		{
			this.LJLHCJFDNGL = HLDNEMHDEDH.NCIMIEAINEO(OFGJFNLDKGO, "wait(", ')', true);
			this.LJLHCJFDNGL *= AppManager.EHBBFMCILPC.debugSettings.OAEBOACHHOG(1f);
		}
		if (OFGJFNLDKGO.Contains("amb"))
		{
			this.DKPPAALFKMO = HLDNEMHDEDH.LNLOHDKFDAA(OFGJFNLDKGO, "amb(", ')', true);
		}
		if (OFGJFNLDKGO.Contains("mus"))
		{
			this.KPPJINFHMIP = HLDNEMHDEDH.LNLOHDKFDAA(OFGJFNLDKGO, "mus(", ')', true);
		}
		if (OFGJFNLDKGO.Contains("musloop"))
		{
			this.LLODADPOMJB = (HLDNEMHDEDH.OKNGPMCDBFE(OFGJFNLDKGO, "musloop(", ')', true) == 1);
		}
		if (OFGJFNLDKGO.Contains("shakescreen"))
		{
			this.HABIIFFBHEA = HLDNEMHDEDH.NCIMIEAINEO(OFGJFNLDKGO, "shakescreen(", ')', true);
		}
		if (OFGJFNLDKGO.Contains("persistent"))
		{
			this.FPHDAKHOBMO = (HLDNEMHDEDH.OKNGPMCDBFE(OFGJFNLDKGO, "persistent(", ')', true) == 1);
		}
		if (OFGJFNLDKGO.Contains("sfx"))
		{
			this.JLEAIJGBGHL = HLDNEMHDEDH.LNLOHDKFDAA(OFGJFNLDKGO, "sfx(", ')', true);
		}
		if (OFGJFNLDKGO.Contains("sfxloop"))
		{
			this.MHCAKNHEPDE = (HLDNEMHDEDH.OKNGPMCDBFE(OFGJFNLDKGO, "sfxloop(", ')', true) == 1);
		}
	}

	// Token: 0x060037D9 RID: 14297 RVA: 0x00171DDB File Offset: 0x0016FFDB
	public override void FEHODJMIAJL(int OIMDDBOOAOB = 1)
	{
		if (!this.BBHDMMHCDKO())
		{
			this.BOPJOMGIJIA += OIMDDBOOAOB;
		}
	}

	// Token: 0x0400108E RID: 4238
	public JABCGEIIPEI.BMHGEBOHLHH BOPJOMGIJIA;

	// Token: 0x0400108F RID: 4239
	public List<string> LOCCINPEPKC = new List<string>();

	// Token: 0x04001090 RID: 4240
	public float ABLPJMDMIPB;

	// Token: 0x04001091 RID: 4241
	public float AHHCLMBOCON = 1f;

	// Token: 0x04001092 RID: 4242
	public float PMMCLCMDNGA;

	// Token: 0x04001093 RID: 4243
	public float LJLHCJFDNGL = -1f;

	// Token: 0x04001094 RID: 4244
	public string KPPJINFHMIP = "";

	// Token: 0x04001095 RID: 4245
	public string DKPPAALFKMO = "";

	// Token: 0x04001096 RID: 4246
	public string JLEAIJGBGHL = "";

	// Token: 0x04001097 RID: 4247
	public bool MHCAKNHEPDE;

	// Token: 0x04001098 RID: 4248
	public bool LLODADPOMJB;

	// Token: 0x04001099 RID: 4249
	public float HABIIFFBHEA = -1f;

	// Token: 0x0400109A RID: 4250
	public bool FPHDAKHOBMO;

	// Token: 0x020001C4 RID: 452
	public enum BMHGEBOHLHH
	{
		// Token: 0x0400109C RID: 4252
		start,
		// Token: 0x0400109D RID: 4253
		done
	}
}
