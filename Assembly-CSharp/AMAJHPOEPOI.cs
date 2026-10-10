using System;
using System.Collections.Generic;

// Token: 0x02000099 RID: 153
public class AMAJHPOEPOI : KGLBKJKNPFD
{
	// Token: 0x060015AD RID: 5549 RVA: 0x000A68B0 File Offset: 0x000A4AB0
	public AMAJHPOEPOI(string OFGJFNLDKGO)
	{
		this.OBKCKGHFMDN = KGLBKJKNPFD.LBFFMOMMAPK.unhideAvatarComponent;
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

	// Token: 0x060015AE RID: 5550 RVA: 0x0001FBB0 File Offset: 0x0001DDB0
	public override bool PINCOCDOOGH()
	{
		return false;
	}

	// Token: 0x060015AF RID: 5551 RVA: 0x000A6A1F File Offset: 0x000A4C1F
	public override bool FMLECLNJAJM()
	{
		return this.BOPJOMGIJIA == (AMAJHPOEPOI.BMHGEBOHLHH)this.KOIINMNNNDJ;
	}

	// Token: 0x060015B0 RID: 5552 RVA: 0x000A6A2F File Offset: 0x000A4C2F
	public override void FEHODJMIAJL(int OIMDDBOOAOB = 1)
	{
		if (!this.BBHDMMHCDKO())
		{
			this.BOPJOMGIJIA += OIMDDBOOAOB;
		}
	}

	// Token: 0x060015B1 RID: 5553 RVA: 0x000A6A47 File Offset: 0x000A4C47
	public override bool BBHDMMHCDKO()
	{
		return this.BOPJOMGIJIA == AMAJHPOEPOI.BMHGEBOHLHH.done;
	}

	// Token: 0x060015B2 RID: 5554 RVA: 0x000A6A52 File Offset: 0x000A4C52
	public override string LDHNPOGPAOB()
	{
		return this.BOPJOMGIJIA.ToString();
	}

	// Token: 0x040006B0 RID: 1712
	public AMAJHPOEPOI.BMHGEBOHLHH BOPJOMGIJIA;

	// Token: 0x040006B1 RID: 1713
	public List<string> PLPCLJFJFNG = new List<string>();

	// Token: 0x040006B2 RID: 1714
	public List<string> OMGLOJOIOCK = new List<string>();

	// Token: 0x040006B3 RID: 1715
	public List<string> JHHKEPGLHKD = new List<string>();

	// Token: 0x040006B4 RID: 1716
	public List<string> KGOAGNFNFIJ = new List<string>();

	// Token: 0x040006B5 RID: 1717
	public List<string> PBOKDNDMCDL = new List<string>();

	// Token: 0x040006B6 RID: 1718
	public List<string> GHALDHOOFKN = new List<string>();

	// Token: 0x0200009A RID: 154
	public enum BMHGEBOHLHH
	{
		// Token: 0x040006B8 RID: 1720
		start,
		// Token: 0x040006B9 RID: 1721
		done
	}
}
