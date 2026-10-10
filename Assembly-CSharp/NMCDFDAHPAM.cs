using System;

// Token: 0x02000460 RID: 1120
public class NMCDFDAHPAM : KGLBKJKNPFD
{
	// Token: 0x06008812 RID: 34834 RVA: 0x003CDC2C File Offset: 0x003CBE2C
	public NMCDFDAHPAM(string OFGJFNLDKGO)
	{
		this.OBKCKGHFMDN = KGLBKJKNPFD.LBFFMOMMAPK.environmentMove;
		this.NLAPFLNBDLC = StoryEnvironmentManager.StringToStoryEnvironmentPosition(HLDNEMHDEDH.LNLOHDKFDAA(OFGJFNLDKGO, "pos(", ')', true));
		if (OFGJFNLDKGO.Contains("speed"))
		{
			this.GDBFCDHEMKI = StoryEnvironmentManager.StringToStoryEnvironmentMoveSpeed(HLDNEMHDEDH.LNLOHDKFDAA(OFGJFNLDKGO, "speed(", ')', true));
		}
		if (OFGJFNLDKGO.Contains("next"))
		{
			string text = HLDNEMHDEDH.LNLOHDKFDAA(OFGJFNLDKGO, "next(", ')', true);
			if (text.Equals(FFHLPKAFOKH.player.ToString()))
			{
				this.BPOGNJJFAJH = FFHLPKAFOKH.player;
			}
			else if (text.Equals(FFHLPKAFOKH.npc.ToString()))
			{
				this.BPOGNJJFAJH = FFHLPKAFOKH.npc;
			}
		}
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
		if (OFGJFNLDKGO.Contains("wait"))
		{
			this.LJLHCJFDNGL = HLDNEMHDEDH.NCIMIEAINEO(OFGJFNLDKGO, "wait(", ')', true);
			this.LJLHCJFDNGL *= AppManager.EHBBFMCILPC.debugSettings.OAEBOACHHOG(1f);
		}
	}

	// Token: 0x06008813 RID: 34835 RVA: 0x003CDDB0 File Offset: 0x003CBFB0
	public override string LDHNPOGPAOB()
	{
		return this.BOPJOMGIJIA.ToString();
	}

	// Token: 0x06008814 RID: 34836 RVA: 0x003CDDC3 File Offset: 0x003CBFC3
	public override bool BBHDMMHCDKO()
	{
		return this.BOPJOMGIJIA == NMCDFDAHPAM.BMHGEBOHLHH.done;
	}

	// Token: 0x06008815 RID: 34837 RVA: 0x003CDDCE File Offset: 0x003CBFCE
	public override void FEHODJMIAJL(int OIMDDBOOAOB = 1)
	{
		if (!this.BBHDMMHCDKO())
		{
			this.BOPJOMGIJIA += OIMDDBOOAOB;
		}
	}

	// Token: 0x06008816 RID: 34838 RVA: 0x003CDDE6 File Offset: 0x003CBFE6
	public override bool FMLECLNJAJM()
	{
		return this.BOPJOMGIJIA == (NMCDFDAHPAM.BMHGEBOHLHH)this.KOIINMNNNDJ;
	}

	// Token: 0x06008817 RID: 34839 RVA: 0x0001FBB0 File Offset: 0x0001DDB0
	public override bool PINCOCDOOGH()
	{
		return false;
	}

	// Token: 0x0400260B RID: 9739
	public NMCDFDAHPAM.BMHGEBOHLHH BOPJOMGIJIA;

	// Token: 0x0400260C RID: 9740
	public FCABOFEGPGP NLAPFLNBDLC;

	// Token: 0x0400260D RID: 9741
	public DBONHDHEKDG GDBFCDHEMKI = DBONHDHEKDG.normal;

	// Token: 0x0400260E RID: 9742
	public FFHLPKAFOKH BPOGNJJFAJH;

	// Token: 0x0400260F RID: 9743
	public float LJLHCJFDNGL = -1f;

	// Token: 0x04002610 RID: 9744
	public string KPPJINFHMIP = "";

	// Token: 0x04002611 RID: 9745
	public string JLEAIJGBGHL = "";

	// Token: 0x04002612 RID: 9746
	public bool MHCAKNHEPDE;

	// Token: 0x04002613 RID: 9747
	public bool LLODADPOMJB;

	// Token: 0x02000461 RID: 1121
	public enum BMHGEBOHLHH
	{
		// Token: 0x04002615 RID: 9749
		startMove,
		// Token: 0x04002616 RID: 9750
		done
	}
}
