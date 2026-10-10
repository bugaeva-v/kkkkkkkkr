using System;

// Token: 0x020004FC RID: 1276
public class GBGJNJIPNNL : KGLBKJKNPFD
{
	// Token: 0x06009AAF RID: 39599 RVA: 0x0001FBB0 File Offset: 0x0001DDB0
	public override bool PINCOCDOOGH()
	{
		return false;
	}

	// Token: 0x06009AB0 RID: 39600 RVA: 0x0042BAAE File Offset: 0x00429CAE
	public override bool BBHDMMHCDKO()
	{
		return this.BOPJOMGIJIA == GBGJNJIPNNL.BMHGEBOHLHH.done;
	}

	// Token: 0x06009AB1 RID: 39601 RVA: 0x0042BABC File Offset: 0x00429CBC
	public GBGJNJIPNNL(string OFGJFNLDKGO)
	{
		this.OBKCKGHFMDN = KGLBKJKNPFD.LBFFMOMMAPK.removeAvatarComponent;
		this.PLPCLJFJFNG = HLDNEMHDEDH.LNLOHDKFDAA(OFGJFNLDKGO, "clothes(", ')', true);
		this.OMGLOJOIOCK = HLDNEMHDEDH.LNLOHDKFDAA(OFGJFNLDKGO, "hair(", ')', true);
		this.KGOAGNFNFIJ = HLDNEMHDEDH.LNLOHDKFDAA(OFGJFNLDKGO, "face(", ')', true);
		this.PBOKDNDMCDL = HLDNEMHDEDH.LNLOHDKFDAA(OFGJFNLDKGO, "trinket(", ')', true);
		this.JHHKEPGLHKD = HLDNEMHDEDH.LNLOHDKFDAA(OFGJFNLDKGO, "body(", ')', true);
		this.GHALDHOOFKN = HLDNEMHDEDH.LNLOHDKFDAA(OFGJFNLDKGO, "overlay(", ')', true);
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

	// Token: 0x06009AB2 RID: 39602 RVA: 0x0042BC2B File Offset: 0x00429E2B
	public override void FEHODJMIAJL(int OIMDDBOOAOB = 1)
	{
		if (!this.BBHDMMHCDKO())
		{
			this.BOPJOMGIJIA += OIMDDBOOAOB;
		}
	}

	// Token: 0x06009AB3 RID: 39603 RVA: 0x0042BC43 File Offset: 0x00429E43
	public override string LDHNPOGPAOB()
	{
		return this.BOPJOMGIJIA.ToString();
	}

	// Token: 0x06009AB4 RID: 39604 RVA: 0x0042BC56 File Offset: 0x00429E56
	public override bool FMLECLNJAJM()
	{
		return this.BOPJOMGIJIA == (GBGJNJIPNNL.BMHGEBOHLHH)this.KOIINMNNNDJ;
	}

	// Token: 0x04002A94 RID: 10900
	public GBGJNJIPNNL.BMHGEBOHLHH BOPJOMGIJIA;

	// Token: 0x04002A95 RID: 10901
	public string PLPCLJFJFNG = "";

	// Token: 0x04002A96 RID: 10902
	public string OMGLOJOIOCK = "";

	// Token: 0x04002A97 RID: 10903
	public string JHHKEPGLHKD = "";

	// Token: 0x04002A98 RID: 10904
	public string KGOAGNFNFIJ = "";

	// Token: 0x04002A99 RID: 10905
	public string PBOKDNDMCDL = "";

	// Token: 0x04002A9A RID: 10906
	public string GHALDHOOFKN = "";

	// Token: 0x020004FD RID: 1277
	public enum BMHGEBOHLHH
	{
		// Token: 0x04002A9C RID: 10908
		start,
		// Token: 0x04002A9D RID: 10909
		done
	}
}
