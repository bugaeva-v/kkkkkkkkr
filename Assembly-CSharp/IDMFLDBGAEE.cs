using System;
using System.Collections.Generic;

// Token: 0x0200034D RID: 845
public class IDMFLDBGAEE : KGLBKJKNPFD
{
	// Token: 0x0600638B RID: 25483 RVA: 0x002D83B9 File Offset: 0x002D65B9
	public override void FEHODJMIAJL(int OIMDDBOOAOB = 1)
	{
		if (!this.BBHDMMHCDKO())
		{
			this.BOPJOMGIJIA += OIMDDBOOAOB;
		}
	}

	// Token: 0x0600638C RID: 25484 RVA: 0x002D83D4 File Offset: 0x002D65D4
	public IDMFLDBGAEE(string OFGJFNLDKGO)
	{
		this.OBKCKGHFMDN = KGLBKJKNPFD.LBFFMOMMAPK.layerHide;
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

	// Token: 0x0600638D RID: 25485 RVA: 0x0001FBB0 File Offset: 0x0001DDB0
	public override bool PINCOCDOOGH()
	{
		return false;
	}

	// Token: 0x0600638E RID: 25486 RVA: 0x002D8667 File Offset: 0x002D6867
	public override bool BBHDMMHCDKO()
	{
		return this.BOPJOMGIJIA == IDMFLDBGAEE.BMHGEBOHLHH.done;
	}

	// Token: 0x0600638F RID: 25487 RVA: 0x002D8672 File Offset: 0x002D6872
	public override bool FMLECLNJAJM()
	{
		return this.BOPJOMGIJIA == (IDMFLDBGAEE.BMHGEBOHLHH)this.KOIINMNNNDJ;
	}

	// Token: 0x06006390 RID: 25488 RVA: 0x002D8682 File Offset: 0x002D6882
	public override string LDHNPOGPAOB()
	{
		return this.BOPJOMGIJIA.ToString();
	}

	// Token: 0x04001CF3 RID: 7411
	public IDMFLDBGAEE.BMHGEBOHLHH BOPJOMGIJIA;

	// Token: 0x04001CF4 RID: 7412
	public List<string> LOCCINPEPKC = new List<string>();

	// Token: 0x04001CF5 RID: 7413
	public float ABLPJMDMIPB = 1f;

	// Token: 0x04001CF6 RID: 7414
	public float AHHCLMBOCON;

	// Token: 0x04001CF7 RID: 7415
	public float PMMCLCMDNGA;

	// Token: 0x04001CF8 RID: 7416
	public float LJLHCJFDNGL = -1f;

	// Token: 0x04001CF9 RID: 7417
	public string KPPJINFHMIP = "";

	// Token: 0x04001CFA RID: 7418
	public string DKPPAALFKMO = "";

	// Token: 0x04001CFB RID: 7419
	public string JLEAIJGBGHL = "";

	// Token: 0x04001CFC RID: 7420
	public bool MHCAKNHEPDE;

	// Token: 0x04001CFD RID: 7421
	public bool LLODADPOMJB;

	// Token: 0x04001CFE RID: 7422
	public float HABIIFFBHEA = -1f;

	// Token: 0x04001CFF RID: 7423
	public bool FPHDAKHOBMO;

	// Token: 0x0200034E RID: 846
	public enum BMHGEBOHLHH
	{
		// Token: 0x04001D01 RID: 7425
		start,
		// Token: 0x04001D02 RID: 7426
		done
	}
}
