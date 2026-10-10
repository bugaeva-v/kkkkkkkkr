using System;
using System.Collections.Generic;

// Token: 0x02000372 RID: 882
public class INPPHKFPFLO : KGLBKJKNPFD
{
	// Token: 0x0600682C RID: 26668 RVA: 0x002FEDC7 File Offset: 0x002FCFC7
	public override string LDHNPOGPAOB()
	{
		return this.BOPJOMGIJIA.ToString();
	}

	// Token: 0x0600682D RID: 26669 RVA: 0x002FEDDC File Offset: 0x002FCFDC
	public INPPHKFPFLO(string OFGJFNLDKGO)
	{
		this.OBKCKGHFMDN = KGLBKJKNPFD.LBFFMOMMAPK.avatarSetup;
		if (OFGJFNLDKGO.Contains("clothes"))
		{
			this.NENOCECJMIJ = HLDNEMHDEDH.NNKLPOAODNF(OFGJFNLDKGO, "clothes(", ')', true);
		}
		if (OFGJFNLDKGO.Contains("hair"))
		{
			this.PILOOLIIPBN = HLDNEMHDEDH.NNKLPOAODNF(OFGJFNLDKGO, "hair(", ')', true);
		}
		if (OFGJFNLDKGO.Contains("trinket"))
		{
			this.BHKEBHFKFNG = HLDNEMHDEDH.NNKLPOAODNF(OFGJFNLDKGO, "trinket(", ')', true);
		}
		if (OFGJFNLDKGO.Contains("overlay"))
		{
			this.IMBPFPKLLCK = HLDNEMHDEDH.NNKLPOAODNF(OFGJFNLDKGO, "overlay(", ')', true);
		}
		if (OFGJFNLDKGO.Contains("env"))
		{
			this.FLPGNPNHJNK = HLDNEMHDEDH.LNLOHDKFDAA(OFGJFNLDKGO, "env(", ')', true);
		}
		if (KGLBKJKNPFD.AFKAMBFMMOH >= 0)
		{
			string akmibddhadh = "";
			if (KGLBKJKNPFD.AFKAMBFMMOH > 0)
			{
				akmibddhadh = "+" + KGLBKJKNPFD.AFKAMBFMMOH.ToString();
			}
			this.NENOCECJMIJ = HLDNEMHDEDH.DGNHJHJMHPD(this.NENOCECJMIJ, akmibddhadh);
			this.PILOOLIIPBN = HLDNEMHDEDH.DGNHJHJMHPD(this.PILOOLIIPBN, akmibddhadh);
			this.BHKEBHFKFNG = HLDNEMHDEDH.DGNHJHJMHPD(this.BHKEBHFKFNG, akmibddhadh);
			this.IMBPFPKLLCK = HLDNEMHDEDH.DGNHJHJMHPD(this.IMBPFPKLLCK, akmibddhadh);
		}
	}

	// Token: 0x0600682E RID: 26670 RVA: 0x0001FBB0 File Offset: 0x0001DDB0
	public override bool PINCOCDOOGH()
	{
		return false;
	}

	// Token: 0x0600682F RID: 26671 RVA: 0x002FEF46 File Offset: 0x002FD146
	public override void FEHODJMIAJL(int OIMDDBOOAOB = 1)
	{
		if (!this.BBHDMMHCDKO())
		{
			this.BOPJOMGIJIA += OIMDDBOOAOB;
		}
	}

	// Token: 0x06006830 RID: 26672 RVA: 0x002FEF5E File Offset: 0x002FD15E
	public override bool FMLECLNJAJM()
	{
		return this.BOPJOMGIJIA == (INPPHKFPFLO.BMHGEBOHLHH)this.KOIINMNNNDJ;
	}

	// Token: 0x06006831 RID: 26673 RVA: 0x002FEF6E File Offset: 0x002FD16E
	public override bool BBHDMMHCDKO()
	{
		return this.BOPJOMGIJIA == INPPHKFPFLO.BMHGEBOHLHH.done;
	}

	// Token: 0x04001E9A RID: 7834
	public INPPHKFPFLO.BMHGEBOHLHH BOPJOMGIJIA;

	// Token: 0x04001E9B RID: 7835
	public string FLPGNPNHJNK = "";

	// Token: 0x04001E9C RID: 7836
	public List<string> NENOCECJMIJ = new List<string>();

	// Token: 0x04001E9D RID: 7837
	public List<string> PILOOLIIPBN = new List<string>();

	// Token: 0x04001E9E RID: 7838
	public List<string> BHKEBHFKFNG = new List<string>();

	// Token: 0x04001E9F RID: 7839
	public List<string> IMBPFPKLLCK = new List<string>();

	// Token: 0x02000373 RID: 883
	public enum BMHGEBOHLHH
	{
		// Token: 0x04001EA1 RID: 7841
		start,
		// Token: 0x04001EA2 RID: 7842
		avatarConfig,
		// Token: 0x04001EA3 RID: 7843
		done
	}
}
