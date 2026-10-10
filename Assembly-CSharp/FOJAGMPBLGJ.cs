using System;
using System.Collections.Generic;

// Token: 0x020001F7 RID: 503
public class FOJAGMPBLGJ : KGLBKJKNPFD
{
	// Token: 0x06003F19 RID: 16153 RVA: 0x001A85EC File Offset: 0x001A67EC
	public override bool BBHDMMHCDKO()
	{
		return this.BOPJOMGIJIA == FOJAGMPBLGJ.BMHGEBOHLHH.done;
	}

	// Token: 0x06003F1A RID: 16154 RVA: 0x001A85F8 File Offset: 0x001A67F8
	public FOJAGMPBLGJ(string OFGJFNLDKGO)
	{
		this.OBKCKGHFMDN = KGLBKJKNPFD.LBFFMOMMAPK.addAvatarComponent;
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

	// Token: 0x06003F1B RID: 16155 RVA: 0x001A8767 File Offset: 0x001A6967
	public override void FEHODJMIAJL(int OIMDDBOOAOB = 1)
	{
		if (!this.BBHDMMHCDKO())
		{
			this.BOPJOMGIJIA += OIMDDBOOAOB;
		}
	}

	// Token: 0x06003F1C RID: 16156 RVA: 0x0001FBB0 File Offset: 0x0001DDB0
	public override bool PINCOCDOOGH()
	{
		return false;
	}

	// Token: 0x06003F1D RID: 16157 RVA: 0x001A877F File Offset: 0x001A697F
	public override string LDHNPOGPAOB()
	{
		return this.BOPJOMGIJIA.ToString();
	}

	// Token: 0x06003F1E RID: 16158 RVA: 0x001A8792 File Offset: 0x001A6992
	public override bool FMLECLNJAJM()
	{
		return this.BOPJOMGIJIA == (FOJAGMPBLGJ.BMHGEBOHLHH)this.KOIINMNNNDJ;
	}

	// Token: 0x040011A8 RID: 4520
	public FOJAGMPBLGJ.BMHGEBOHLHH BOPJOMGIJIA;

	// Token: 0x040011A9 RID: 4521
	public List<string> PLPCLJFJFNG = new List<string>();

	// Token: 0x040011AA RID: 4522
	public List<string> OMGLOJOIOCK = new List<string>();

	// Token: 0x040011AB RID: 4523
	public List<string> JHHKEPGLHKD = new List<string>();

	// Token: 0x040011AC RID: 4524
	public List<string> KGOAGNFNFIJ = new List<string>();

	// Token: 0x040011AD RID: 4525
	public List<string> PBOKDNDMCDL = new List<string>();

	// Token: 0x040011AE RID: 4526
	public List<string> GHALDHOOFKN = new List<string>();

	// Token: 0x020001F8 RID: 504
	public enum BMHGEBOHLHH
	{
		// Token: 0x040011B0 RID: 4528
		start,
		// Token: 0x040011B1 RID: 4529
		done
	}
}
