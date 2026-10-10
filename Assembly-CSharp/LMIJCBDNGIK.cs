using System;
using System.Collections.Generic;

// Token: 0x0200039D RID: 925
public class LMIJCBDNGIK : KGLBKJKNPFD
{
	// Token: 0x06006B95 RID: 27541 RVA: 0x0031270D File Offset: 0x0031090D
	public override string LDHNPOGPAOB()
	{
		return this.BOPJOMGIJIA.ToString();
	}

	// Token: 0x06006B96 RID: 27542 RVA: 0x0001FBB0 File Offset: 0x0001DDB0
	public override bool PINCOCDOOGH()
	{
		return false;
	}

	// Token: 0x06006B97 RID: 27543 RVA: 0x00312720 File Offset: 0x00310920
	public LMIJCBDNGIK(string OFGJFNLDKGO)
	{
		this.OBKCKGHFMDN = KGLBKJKNPFD.LBFFMOMMAPK.tryAvatarConfig;
		this.PLPCLJFJFNG = HLDNEMHDEDH.NNKLPOAODNF(OFGJFNLDKGO, "clothes(", ')', true);
		this.OMGLOJOIOCK = HLDNEMHDEDH.NNKLPOAODNF(OFGJFNLDKGO, "hair(", ')', true);
		this.KGOAGNFNFIJ = HLDNEMHDEDH.NNKLPOAODNF(OFGJFNLDKGO, "face(", ')', true);
		this.PBOKDNDMCDL = HLDNEMHDEDH.NNKLPOAODNF(OFGJFNLDKGO, "trinket(", ')', true);
		this.JHHKEPGLHKD = HLDNEMHDEDH.NNKLPOAODNF(OFGJFNLDKGO, "body(", ')', true);
		this.GHALDHOOFKN = HLDNEMHDEDH.NNKLPOAODNF(OFGJFNLDKGO, "overlay(", ')', true);
		if (KGLBKJKNPFD.AFKAMBFMMOH >= 0)
		{
			string akmibddhadh = "";
			if (KGLBKJKNPFD.AFKAMBFMMOH > 0)
			{
				akmibddhadh = "+" + KGLBKJKNPFD.AFKAMBFMMOH.ToString();
			}
			this.PLPCLJFJFNG = HLDNEMHDEDH.DGNHJHJMHPD(this.PLPCLJFJFNG, akmibddhadh);
			this.OMGLOJOIOCK = HLDNEMHDEDH.DGNHJHJMHPD(this.OMGLOJOIOCK, akmibddhadh);
			this.PBOKDNDMCDL = HLDNEMHDEDH.DGNHJHJMHPD(this.PBOKDNDMCDL, akmibddhadh);
			this.JHHKEPGLHKD = HLDNEMHDEDH.DGNHJHJMHPD(this.JHHKEPGLHKD, akmibddhadh);
			this.GHALDHOOFKN = HLDNEMHDEDH.DGNHJHJMHPD(this.GHALDHOOFKN, akmibddhadh);
			this.KGOAGNFNFIJ = HLDNEMHDEDH.DGNHJHJMHPD(this.KGOAGNFNFIJ, akmibddhadh);
		}
	}

	// Token: 0x06006B98 RID: 27544 RVA: 0x0031288F File Offset: 0x00310A8F
	public override void FEHODJMIAJL(int OIMDDBOOAOB = 1)
	{
		if (!this.BBHDMMHCDKO())
		{
			this.BOPJOMGIJIA += OIMDDBOOAOB;
		}
	}

	// Token: 0x06006B99 RID: 27545 RVA: 0x003128A7 File Offset: 0x00310AA7
	public override bool FMLECLNJAJM()
	{
		return this.BOPJOMGIJIA == (LMIJCBDNGIK.BMHGEBOHLHH)this.KOIINMNNNDJ;
	}

	// Token: 0x06006B9A RID: 27546 RVA: 0x003128B7 File Offset: 0x00310AB7
	public override bool BBHDMMHCDKO()
	{
		return this.BOPJOMGIJIA == LMIJCBDNGIK.BMHGEBOHLHH.done;
	}

	// Token: 0x04001FAF RID: 8111
	public LMIJCBDNGIK.BMHGEBOHLHH BOPJOMGIJIA;

	// Token: 0x04001FB0 RID: 8112
	public List<string> PLPCLJFJFNG = new List<string>();

	// Token: 0x04001FB1 RID: 8113
	public List<string> OMGLOJOIOCK = new List<string>();

	// Token: 0x04001FB2 RID: 8114
	public List<string> JHHKEPGLHKD = new List<string>();

	// Token: 0x04001FB3 RID: 8115
	public List<string> KGOAGNFNFIJ = new List<string>();

	// Token: 0x04001FB4 RID: 8116
	public List<string> PBOKDNDMCDL = new List<string>();

	// Token: 0x04001FB5 RID: 8117
	public List<string> GHALDHOOFKN = new List<string>();

	// Token: 0x0200039E RID: 926
	public enum BMHGEBOHLHH
	{
		// Token: 0x04001FB7 RID: 8119
		start,
		// Token: 0x04001FB8 RID: 8120
		done
	}
}
