using System;
using System.Collections.Generic;

// Token: 0x020000A3 RID: 163
public class GCHKBABPNFC : KGLBKJKNPFD
{
	// Token: 0x0600166A RID: 5738 RVA: 0x000AA3D2 File Offset: 0x000A85D2
	public override void FEHODJMIAJL(int OIMDDBOOAOB = 1)
	{
		if (!this.BBHDMMHCDKO())
		{
			this.BOPJOMGIJIA += OIMDDBOOAOB;
		}
	}

	// Token: 0x0600166B RID: 5739 RVA: 0x000AA3EC File Offset: 0x000A85EC
	public GCHKBABPNFC(string OFGJFNLDKGO)
	{
		this.OBKCKGHFMDN = KGLBKJKNPFD.LBFFMOMMAPK.hideAvatarComponent;
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

	// Token: 0x0600166C RID: 5740 RVA: 0x000AA55B File Offset: 0x000A875B
	public override bool BBHDMMHCDKO()
	{
		return this.BOPJOMGIJIA == GCHKBABPNFC.BMHGEBOHLHH.done;
	}

	// Token: 0x0600166D RID: 5741 RVA: 0x0001FBB0 File Offset: 0x0001DDB0
	public override bool PINCOCDOOGH()
	{
		return false;
	}

	// Token: 0x0600166E RID: 5742 RVA: 0x000AA566 File Offset: 0x000A8766
	public override bool FMLECLNJAJM()
	{
		return this.BOPJOMGIJIA == (GCHKBABPNFC.BMHGEBOHLHH)this.KOIINMNNNDJ;
	}

	// Token: 0x0600166F RID: 5743 RVA: 0x000AA576 File Offset: 0x000A8776
	public override string LDHNPOGPAOB()
	{
		return this.BOPJOMGIJIA.ToString();
	}

	// Token: 0x040006D3 RID: 1747
	public GCHKBABPNFC.BMHGEBOHLHH BOPJOMGIJIA;

	// Token: 0x040006D4 RID: 1748
	public List<string> PLPCLJFJFNG = new List<string>();

	// Token: 0x040006D5 RID: 1749
	public List<string> OMGLOJOIOCK = new List<string>();

	// Token: 0x040006D6 RID: 1750
	public List<string> JHHKEPGLHKD = new List<string>();

	// Token: 0x040006D7 RID: 1751
	public List<string> KGOAGNFNFIJ = new List<string>();

	// Token: 0x040006D8 RID: 1752
	public List<string> PBOKDNDMCDL = new List<string>();

	// Token: 0x040006D9 RID: 1753
	public List<string> GHALDHOOFKN = new List<string>();

	// Token: 0x020000A4 RID: 164
	public enum BMHGEBOHLHH
	{
		// Token: 0x040006DB RID: 1755
		start,
		// Token: 0x040006DC RID: 1756
		done
	}
}
