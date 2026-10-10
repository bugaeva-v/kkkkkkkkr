using System;

// Token: 0x02000397 RID: 919
public class IKICLNCOBMC : KGLBKJKNPFD
{
	// Token: 0x06006B83 RID: 27523 RVA: 0x00312150 File Offset: 0x00310350
	public IKICLNCOBMC(string OFGJFNLDKGO)
	{
		this.OBKCKGHFMDN = KGLBKJKNPFD.LBFFMOMMAPK.avatarConfig;
		this.PLPCLJFJFNG = HLDNEMHDEDH.LNLOHDKFDAA(OFGJFNLDKGO, "clothes(", ')', true);
		this.OMGLOJOIOCK = HLDNEMHDEDH.LNLOHDKFDAA(OFGJFNLDKGO, "hair(", ')', true);
		this.KGOAGNFNFIJ = HLDNEMHDEDH.LNLOHDKFDAA(OFGJFNLDKGO, "face(", ')', true);
		this.PBOKDNDMCDL = HLDNEMHDEDH.LNLOHDKFDAA(OFGJFNLDKGO, "trinket(", ')', true);
		this.JHHKEPGLHKD = HLDNEMHDEDH.LNLOHDKFDAA(OFGJFNLDKGO, "body(", ')', true);
		this.GHALDHOOFKN = HLDNEMHDEDH.LNLOHDKFDAA(OFGJFNLDKGO, "overlay(", ')', true);
		this.DIGBLIJOKJE = HLDNEMHDEDH.LNLOHDKFDAA(OFGJFNLDKGO, "fallback(", ')', true);
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

	// Token: 0x06006B84 RID: 27524 RVA: 0x003122DE File Offset: 0x003104DE
	public override void FEHODJMIAJL(int OIMDDBOOAOB = 1)
	{
		if (!this.BBHDMMHCDKO())
		{
			this.BOPJOMGIJIA += OIMDDBOOAOB;
		}
	}

	// Token: 0x06006B85 RID: 27525 RVA: 0x003122F6 File Offset: 0x003104F6
	public override string LDHNPOGPAOB()
	{
		return this.BOPJOMGIJIA.ToString();
	}

	// Token: 0x06006B86 RID: 27526 RVA: 0x0001FBB0 File Offset: 0x0001DDB0
	public override bool PINCOCDOOGH()
	{
		return false;
	}

	// Token: 0x06006B87 RID: 27527 RVA: 0x00312309 File Offset: 0x00310509
	public override bool BBHDMMHCDKO()
	{
		return this.BOPJOMGIJIA == IKICLNCOBMC.BMHGEBOHLHH.done;
	}

	// Token: 0x06006B88 RID: 27528 RVA: 0x00312314 File Offset: 0x00310514
	public override bool FMLECLNJAJM()
	{
		return this.BOPJOMGIJIA == (IKICLNCOBMC.BMHGEBOHLHH)this.KOIINMNNNDJ;
	}

	// Token: 0x04001F8D RID: 8077
	public IKICLNCOBMC.BMHGEBOHLHH BOPJOMGIJIA;

	// Token: 0x04001F8E RID: 8078
	public string PLPCLJFJFNG = "";

	// Token: 0x04001F8F RID: 8079
	public string OMGLOJOIOCK = "";

	// Token: 0x04001F90 RID: 8080
	public string JHHKEPGLHKD = "";

	// Token: 0x04001F91 RID: 8081
	public string KGOAGNFNFIJ = "";

	// Token: 0x04001F92 RID: 8082
	public string PBOKDNDMCDL = "";

	// Token: 0x04001F93 RID: 8083
	public string GHALDHOOFKN = "";

	// Token: 0x04001F94 RID: 8084
	public string DIGBLIJOKJE = "";

	// Token: 0x02000398 RID: 920
	public enum BMHGEBOHLHH
	{
		// Token: 0x04001F96 RID: 8086
		start,
		// Token: 0x04001F97 RID: 8087
		done
	}
}
