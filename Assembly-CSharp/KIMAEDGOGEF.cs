using System;
using System.Collections.Generic;

// Token: 0x02000491 RID: 1169
public class KIMAEDGOGEF : KGLBKJKNPFD
{
	// Token: 0x06008DFE RID: 36350 RVA: 0x003ECBD6 File Offset: 0x003EADD6
	public override bool BBHDMMHCDKO()
	{
		return this.BOPJOMGIJIA == KIMAEDGOGEF.BMHGEBOHLHH.done;
	}

	// Token: 0x06008DFF RID: 36351 RVA: 0x003ECBE4 File Offset: 0x003EADE4
	public KIMAEDGOGEF(string OFGJFNLDKGO)
	{
		this.OBKCKGHFMDN = KGLBKJKNPFD.LBFFMOMMAPK.takeAvatarSnapshot;
		List<string> list = HLDNEMHDEDH.NNKLPOAODNF(OFGJFNLDKGO, "target(", ')', true);
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
		if (!this.LFEPCGFNMFJ && !this.FCHPMLBDPKJ && !this.NCAMFPGMCIG && !this.KEANPACAICH && !this.GOJKOJGKMHI && !this.EBCKBKHBNKH)
		{
			this.FCHPMLBDPKJ = (this.NCAMFPGMCIG = (this.LFEPCGFNMFJ = (this.KEANPACAICH = (this.GOJKOJGKMHI = (this.EBCKBKHBNKH = true)))));
		}
		if (OFGJFNLDKGO.Contains("index("))
		{
			this.NFDKDACMHME = HLDNEMHDEDH.OKNGPMCDBFE(OFGJFNLDKGO, "index(", ')', true);
		}
		if (OFGJFNLDKGO.Contains("persistent("))
		{
			this.FPHDAKHOBMO = HLDNEMHDEDH.OKNGPMCDBFE(OFGJFNLDKGO, "persistent(", ')', true);
		}
	}

	// Token: 0x06008E00 RID: 36352 RVA: 0x003ECD9B File Offset: 0x003EAF9B
	public override string LDHNPOGPAOB()
	{
		return this.BOPJOMGIJIA.ToString();
	}

	// Token: 0x06008E01 RID: 36353 RVA: 0x0001FBB0 File Offset: 0x0001DDB0
	public override bool PINCOCDOOGH()
	{
		return false;
	}

	// Token: 0x06008E02 RID: 36354 RVA: 0x003ECDAE File Offset: 0x003EAFAE
	public override void FEHODJMIAJL(int OIMDDBOOAOB = 1)
	{
		if (!this.BBHDMMHCDKO())
		{
			this.BOPJOMGIJIA += OIMDDBOOAOB;
		}
	}

	// Token: 0x06008E03 RID: 36355 RVA: 0x003ECDC6 File Offset: 0x003EAFC6
	public override bool FMLECLNJAJM()
	{
		return this.BOPJOMGIJIA == (KIMAEDGOGEF.BMHGEBOHLHH)this.KOIINMNNNDJ;
	}

	// Token: 0x04002778 RID: 10104
	public KIMAEDGOGEF.BMHGEBOHLHH BOPJOMGIJIA;

	// Token: 0x04002779 RID: 10105
	public bool LFEPCGFNMFJ;

	// Token: 0x0400277A RID: 10106
	public bool FCHPMLBDPKJ;

	// Token: 0x0400277B RID: 10107
	public bool NCAMFPGMCIG;

	// Token: 0x0400277C RID: 10108
	public bool KEANPACAICH;

	// Token: 0x0400277D RID: 10109
	public bool GOJKOJGKMHI;

	// Token: 0x0400277E RID: 10110
	public bool EBCKBKHBNKH;

	// Token: 0x0400277F RID: 10111
	public int NFDKDACMHME = -1;

	// Token: 0x04002780 RID: 10112
	public int FPHDAKHOBMO;

	// Token: 0x02000492 RID: 1170
	public enum BMHGEBOHLHH
	{
		// Token: 0x04002782 RID: 10114
		start,
		// Token: 0x04002783 RID: 10115
		done
	}
}
