using System;
using System.Collections.Generic;

// Token: 0x02000056 RID: 86
public class MFJOEANDAPH : KGLBKJKNPFD
{
	// Token: 0x06000C65 RID: 3173 RVA: 0x00058D28 File Offset: 0x00056F28
	public MFJOEANDAPH(string OFGJFNLDKGO)
	{
		this.OBKCKGHFMDN = KGLBKJKNPFD.LBFFMOMMAPK.takeAndRestoreAvatarSnapshot;
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

	// Token: 0x06000C66 RID: 3174 RVA: 0x00058E96 File Offset: 0x00057096
	public override bool FMLECLNJAJM()
	{
		return this.BOPJOMGIJIA == (MFJOEANDAPH.BMHGEBOHLHH)this.KOIINMNNNDJ;
	}

	// Token: 0x06000C67 RID: 3175 RVA: 0x0001FBB0 File Offset: 0x0001DDB0
	public override bool PINCOCDOOGH()
	{
		return false;
	}

	// Token: 0x06000C68 RID: 3176 RVA: 0x00058EA6 File Offset: 0x000570A6
	public override void FEHODJMIAJL(int OIMDDBOOAOB = 1)
	{
		if (!this.BBHDMMHCDKO())
		{
			this.BOPJOMGIJIA += OIMDDBOOAOB;
		}
	}

	// Token: 0x06000C69 RID: 3177 RVA: 0x00058EBE File Offset: 0x000570BE
	public override bool BBHDMMHCDKO()
	{
		return this.BOPJOMGIJIA == MFJOEANDAPH.BMHGEBOHLHH.done;
	}

	// Token: 0x06000C6A RID: 3178 RVA: 0x00058EC9 File Offset: 0x000570C9
	public override string LDHNPOGPAOB()
	{
		return this.BOPJOMGIJIA.ToString();
	}

	// Token: 0x040003AB RID: 939
	public MFJOEANDAPH.BMHGEBOHLHH BOPJOMGIJIA;

	// Token: 0x040003AC RID: 940
	public bool LFEPCGFNMFJ;

	// Token: 0x040003AD RID: 941
	public bool FCHPMLBDPKJ;

	// Token: 0x040003AE RID: 942
	public bool NCAMFPGMCIG;

	// Token: 0x040003AF RID: 943
	public bool KEANPACAICH;

	// Token: 0x040003B0 RID: 944
	public bool GOJKOJGKMHI;

	// Token: 0x040003B1 RID: 945
	public bool EBCKBKHBNKH;

	// Token: 0x02000057 RID: 87
	public enum BMHGEBOHLHH
	{
		// Token: 0x040003B3 RID: 947
		start,
		// Token: 0x040003B4 RID: 948
		done
	}
}
