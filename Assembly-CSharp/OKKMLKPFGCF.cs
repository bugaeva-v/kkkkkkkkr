using System;
using System.Collections.Generic;

// Token: 0x020002BF RID: 703
public class OKKMLKPFGCF : KGLBKJKNPFD
{
	// Token: 0x060058B9 RID: 22713 RVA: 0x0001FBB0 File Offset: 0x0001DDB0
	public override bool PINCOCDOOGH()
	{
		return false;
	}

	// Token: 0x060058BA RID: 22714 RVA: 0x002815B5 File Offset: 0x0027F7B5
	public override string LDHNPOGPAOB()
	{
		return this.BOPJOMGIJIA.ToString();
	}

	// Token: 0x060058BB RID: 22715 RVA: 0x002815C8 File Offset: 0x0027F7C8
	public override bool BBHDMMHCDKO()
	{
		return this.BOPJOMGIJIA == OKKMLKPFGCF.BMHGEBOHLHH.done;
	}

	// Token: 0x060058BC RID: 22716 RVA: 0x002815D3 File Offset: 0x0027F7D3
	public override void FEHODJMIAJL(int OIMDDBOOAOB = 1)
	{
		if (!this.BBHDMMHCDKO())
		{
			this.BOPJOMGIJIA += OIMDDBOOAOB;
		}
	}

	// Token: 0x060058BD RID: 22717 RVA: 0x002815EB File Offset: 0x0027F7EB
	public override bool FMLECLNJAJM()
	{
		return this.BOPJOMGIJIA == (OKKMLKPFGCF.BMHGEBOHLHH)this.KOIINMNNNDJ;
	}

	// Token: 0x060058BE RID: 22718 RVA: 0x002815FC File Offset: 0x0027F7FC
	public OKKMLKPFGCF(string OFGJFNLDKGO)
	{
		this.OBKCKGHFMDN = KGLBKJKNPFD.LBFFMOMMAPK.syncAvatar;
		this.PNAKACGNLGL = HLDNEMHDEDH.OKNGPMCDBFE(OFGJFNLDKGO, "src(", ')', true);
		this.NEOFEIFAGLF = HLDNEMHDEDH.OKNGPMCDBFE(OFGJFNLDKGO, "dst(", ')', true);
		if (OFGJFNLDKGO.Contains("from("))
		{
			this.PNAKACGNLGL = HLDNEMHDEDH.OKNGPMCDBFE(OFGJFNLDKGO, "from(", ')', true);
		}
		if (OFGJFNLDKGO.Contains("to("))
		{
			this.NEOFEIFAGLF = HLDNEMHDEDH.OKNGPMCDBFE(OFGJFNLDKGO, "to(", ')', true);
		}
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
	}

	// Token: 0x040018DE RID: 6366
	public int PNAKACGNLGL;

	// Token: 0x040018DF RID: 6367
	public int NEOFEIFAGLF;

	// Token: 0x040018E0 RID: 6368
	public bool LFEPCGFNMFJ;

	// Token: 0x040018E1 RID: 6369
	public bool FCHPMLBDPKJ;

	// Token: 0x040018E2 RID: 6370
	public bool NCAMFPGMCIG;

	// Token: 0x040018E3 RID: 6371
	public bool KEANPACAICH;

	// Token: 0x040018E4 RID: 6372
	public bool GOJKOJGKMHI;

	// Token: 0x040018E5 RID: 6373
	public bool EBCKBKHBNKH;

	// Token: 0x040018E6 RID: 6374
	public OKKMLKPFGCF.BMHGEBOHLHH BOPJOMGIJIA;

	// Token: 0x020002C0 RID: 704
	public enum BMHGEBOHLHH
	{
		// Token: 0x040018E8 RID: 6376
		start,
		// Token: 0x040018E9 RID: 6377
		done
	}
}
