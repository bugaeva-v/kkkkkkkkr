using System;
using System.Collections.Generic;

// Token: 0x0200039B RID: 923
public class JLHBIPMDLNH : KGLBKJKNPFD
{
	// Token: 0x06006B8F RID: 27535 RVA: 0x00312463 File Offset: 0x00310663
	public override bool BBHDMMHCDKO()
	{
		return this.BOPJOMGIJIA == JLHBIPMDLNH.BMHGEBOHLHH.done;
	}

	// Token: 0x06006B90 RID: 27536 RVA: 0x0001FBB0 File Offset: 0x0001DDB0
	public override bool PINCOCDOOGH()
	{
		return false;
	}

	// Token: 0x06006B91 RID: 27537 RVA: 0x0031246E File Offset: 0x0031066E
	public override void FEHODJMIAJL(int OIMDDBOOAOB = 1)
	{
		if (!this.BBHDMMHCDKO())
		{
			this.BOPJOMGIJIA += OIMDDBOOAOB;
		}
	}

	// Token: 0x06006B92 RID: 27538 RVA: 0x00312488 File Offset: 0x00310688
	public JLHBIPMDLNH(string OFGJFNLDKGO)
	{
		this.OBKCKGHFMDN = KGLBKJKNPFD.LBFFMOMMAPK.layerUtil;
		if (OFGJFNLDKGO.Contains("show("))
		{
			this.MCMOGGKILMF = HLDNEMHDEDH.NNKLPOAODNF(OFGJFNLDKGO, "show(", ')', true);
		}
		if (OFGJFNLDKGO.Contains("hide("))
		{
			this.BNDPGIPOGOH = HLDNEMHDEDH.NNKLPOAODNF(OFGJFNLDKGO, "hide(", ')', true);
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

	// Token: 0x06006B93 RID: 27539 RVA: 0x003126EA File Offset: 0x003108EA
	public override string LDHNPOGPAOB()
	{
		return this.BOPJOMGIJIA.ToString();
	}

	// Token: 0x06006B94 RID: 27540 RVA: 0x003126FD File Offset: 0x003108FD
	public override bool FMLECLNJAJM()
	{
		return this.BOPJOMGIJIA == (JLHBIPMDLNH.BMHGEBOHLHH)this.KOIINMNNNDJ;
	}

	// Token: 0x04001FA0 RID: 8096
	public JLHBIPMDLNH.BMHGEBOHLHH BOPJOMGIJIA;

	// Token: 0x04001FA1 RID: 8097
	public List<string> MCMOGGKILMF = new List<string>();

	// Token: 0x04001FA2 RID: 8098
	public List<string> BNDPGIPOGOH = new List<string>();

	// Token: 0x04001FA3 RID: 8099
	public float PMMCLCMDNGA;

	// Token: 0x04001FA4 RID: 8100
	public float LJLHCJFDNGL = -1f;

	// Token: 0x04001FA5 RID: 8101
	public string KPPJINFHMIP = "";

	// Token: 0x04001FA6 RID: 8102
	public string DKPPAALFKMO = "";

	// Token: 0x04001FA7 RID: 8103
	public string JLEAIJGBGHL = "";

	// Token: 0x04001FA8 RID: 8104
	public bool MHCAKNHEPDE;

	// Token: 0x04001FA9 RID: 8105
	public bool LLODADPOMJB;

	// Token: 0x04001FAA RID: 8106
	public float HABIIFFBHEA = -1f;

	// Token: 0x04001FAB RID: 8107
	public bool FPHDAKHOBMO;

	// Token: 0x0200039C RID: 924
	public enum BMHGEBOHLHH
	{
		// Token: 0x04001FAD RID: 8109
		start,
		// Token: 0x04001FAE RID: 8110
		done
	}
}
