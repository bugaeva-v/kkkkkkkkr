using System;
using System.Collections.Generic;

// Token: 0x0200028F RID: 655
public class CKJNHELNAFB : KGLBKJKNPFD
{
	// Token: 0x060051F9 RID: 20985 RVA: 0x0001FBB0 File Offset: 0x0001DDB0
	public override bool PINCOCDOOGH()
	{
		return false;
	}

	// Token: 0x060051FA RID: 20986 RVA: 0x0023F981 File Offset: 0x0023DB81
	public override bool FMLECLNJAJM()
	{
		return this.BOPJOMGIJIA == (CKJNHELNAFB.BMHGEBOHLHH)this.KOIINMNNNDJ;
	}

	// Token: 0x060051FB RID: 20987 RVA: 0x0023F994 File Offset: 0x0023DB94
	public CKJNHELNAFB(string OFGJFNLDKGO)
	{
		this.OBKCKGHFMDN = KGLBKJKNPFD.LBFFMOMMAPK.setAvatar;
		this.NFDKDACMHME = HLDNEMHDEDH.OKNGPMCDBFE(OFGJFNLDKGO, "id(", ')', true);
		if (OFGJFNLDKGO.Contains("autosync("))
		{
			this.ICOCHNCELHL = (HLDNEMHDEDH.OKNGPMCDBFE(OFGJFNLDKGO, "autosync(", ')', true) == 1);
		}
		if (OFGJFNLDKGO.Contains("autosuffix("))
		{
			this.PFCEGDBAGHC = (HLDNEMHDEDH.OKNGPMCDBFE(OFGJFNLDKGO, "autosuffix(", ')', true) == 1);
		}
		if (OFGJFNLDKGO.Contains("syncbodyface("))
		{
			this.AIDFMFOBLNC = (HLDNEMHDEDH.OKNGPMCDBFE(OFGJFNLDKGO, "syncbodyface(", ')', true) == 1);
		}
		List<string> list = HLDNEMHDEDH.NNKLPOAODNF(OFGJFNLDKGO, "copy(", ')', true);
		for (int i = 0; i < list.Count; i++)
		{
			if (list[i].Contains("hair"))
			{
				this.LFEPCGFNMFJ = true;
			}
			else if (list[i].Contains("body"))
			{
				this.NCAMFPGMCIG = true;
			}
			else if (list[i].Contains("clothes"))
			{
				this.KEANPACAICH = true;
			}
			else if (list[i].Contains("face"))
			{
				this.FCHPMLBDPKJ = true;
			}
			else if (list[i].Contains("trinket"))
			{
				this.GOJKOJGKMHI = true;
			}
			else if (list[i].Contains("overlay"))
			{
				this.EBCKBKHBNKH = true;
			}
		}
		if (this.FCHPMLBDPKJ || this.NCAMFPGMCIG)
		{
			this.FCHPMLBDPKJ = (this.NCAMFPGMCIG = true);
		}
		if (OFGJFNLDKGO.Contains("updatelobbyindex("))
		{
			this.GNNDOOOJHCK = (HLDNEMHDEDH.OKNGPMCDBFE(OFGJFNLDKGO, "updatelobbyindex(", ')', true) == 1);
		}
	}

	// Token: 0x060051FC RID: 20988 RVA: 0x0023FB42 File Offset: 0x0023DD42
	public override void FEHODJMIAJL(int OIMDDBOOAOB = 1)
	{
		if (!this.BBHDMMHCDKO())
		{
			this.BOPJOMGIJIA += OIMDDBOOAOB;
		}
	}

	// Token: 0x060051FD RID: 20989 RVA: 0x0023FB5A File Offset: 0x0023DD5A
	public override string LDHNPOGPAOB()
	{
		return this.BOPJOMGIJIA.ToString();
	}

	// Token: 0x060051FE RID: 20990 RVA: 0x0023FB6D File Offset: 0x0023DD6D
	public override bool BBHDMMHCDKO()
	{
		return this.BOPJOMGIJIA == CKJNHELNAFB.BMHGEBOHLHH.done;
	}

	// Token: 0x0400170F RID: 5903
	public CKJNHELNAFB.BMHGEBOHLHH BOPJOMGIJIA;

	// Token: 0x04001710 RID: 5904
	public int NFDKDACMHME;

	// Token: 0x04001711 RID: 5905
	public bool ICOCHNCELHL;

	// Token: 0x04001712 RID: 5906
	public bool PFCEGDBAGHC;

	// Token: 0x04001713 RID: 5907
	public bool AIDFMFOBLNC;

	// Token: 0x04001714 RID: 5908
	public bool GNNDOOOJHCK;

	// Token: 0x04001715 RID: 5909
	public bool LFEPCGFNMFJ;

	// Token: 0x04001716 RID: 5910
	public bool FCHPMLBDPKJ;

	// Token: 0x04001717 RID: 5911
	public bool NCAMFPGMCIG;

	// Token: 0x04001718 RID: 5912
	public bool KEANPACAICH;

	// Token: 0x04001719 RID: 5913
	public bool GOJKOJGKMHI;

	// Token: 0x0400171A RID: 5914
	public bool EBCKBKHBNKH;

	// Token: 0x02000290 RID: 656
	public enum BMHGEBOHLHH
	{
		// Token: 0x0400171C RID: 5916
		start,
		// Token: 0x0400171D RID: 5917
		done
	}
}
