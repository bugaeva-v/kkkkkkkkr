using System;

// Token: 0x020002AC RID: 684
public class LPGHIPDCAAA : KGLBKJKNPFD
{
	// Token: 0x06005695 RID: 22165 RVA: 0x0026A145 File Offset: 0x00268345
	public override bool FMLECLNJAJM()
	{
		return this.BOPJOMGIJIA == (LPGHIPDCAAA.BMHGEBOHLHH)this.KOIINMNNNDJ;
	}

	// Token: 0x06005696 RID: 22166 RVA: 0x0026A155 File Offset: 0x00268355
	public override void FEHODJMIAJL(int OIMDDBOOAOB = 1)
	{
		if (!this.BBHDMMHCDKO())
		{
			this.BOPJOMGIJIA += OIMDDBOOAOB;
		}
	}

	// Token: 0x06005697 RID: 22167 RVA: 0x0026A16D File Offset: 0x0026836D
	public override string LDHNPOGPAOB()
	{
		return this.BOPJOMGIJIA.ToString();
	}

	// Token: 0x06005698 RID: 22168 RVA: 0x0026A180 File Offset: 0x00268380
	public LPGHIPDCAAA(string OFGJFNLDKGO)
	{
		this.OBKCKGHFMDN = KGLBKJKNPFD.LBFFMOMMAPK.environmentMoveVertical;
		this.NLAPFLNBDLC = StoryEnvironmentManager.StringToStoryEnvironmentPositionVertical(HLDNEMHDEDH.LNLOHDKFDAA(OFGJFNLDKGO, "pos(", ')', true));
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

	// Token: 0x06005699 RID: 22169 RVA: 0x0001FBB0 File Offset: 0x0001DDB0
	public override bool PINCOCDOOGH()
	{
		return false;
	}

	// Token: 0x0600569A RID: 22170 RVA: 0x0026A304 File Offset: 0x00268504
	public override bool BBHDMMHCDKO()
	{
		return this.BOPJOMGIJIA == LPGHIPDCAAA.BMHGEBOHLHH.done;
	}

	// Token: 0x04001847 RID: 6215
	public LPGHIPDCAAA.BMHGEBOHLHH BOPJOMGIJIA;

	// Token: 0x04001848 RID: 6216
	public PHALBCMBPPL NLAPFLNBDLC;

	// Token: 0x04001849 RID: 6217
	public DBONHDHEKDG GDBFCDHEMKI = DBONHDHEKDG.normal;

	// Token: 0x0400184A RID: 6218
	public FFHLPKAFOKH BPOGNJJFAJH;

	// Token: 0x0400184B RID: 6219
	public float LJLHCJFDNGL = -1f;

	// Token: 0x0400184C RID: 6220
	public string KPPJINFHMIP = "";

	// Token: 0x0400184D RID: 6221
	public string JLEAIJGBGHL = "";

	// Token: 0x0400184E RID: 6222
	public bool MHCAKNHEPDE;

	// Token: 0x0400184F RID: 6223
	public bool LLODADPOMJB;

	// Token: 0x020002AD RID: 685
	public enum BMHGEBOHLHH
	{
		// Token: 0x04001851 RID: 6225
		startMove,
		// Token: 0x04001852 RID: 6226
		done
	}
}
