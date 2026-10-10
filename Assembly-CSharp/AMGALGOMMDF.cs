using System;

// Token: 0x020003F8 RID: 1016
public class AMGALGOMMDF : KGLBKJKNPFD
{
	// Token: 0x0600783F RID: 30783 RVA: 0x0001FBB0 File Offset: 0x0001DDB0
	public override bool PINCOCDOOGH()
	{
		return false;
	}

	// Token: 0x06007840 RID: 30784 RVA: 0x0035F15C File Offset: 0x0035D35C
	public override void FEHODJMIAJL(int OIMDDBOOAOB = 1)
	{
		if (!this.BBHDMMHCDKO())
		{
			this.BOPJOMGIJIA += OIMDDBOOAOB;
		}
	}

	// Token: 0x06007841 RID: 30785 RVA: 0x0035F174 File Offset: 0x0035D374
	public AMGALGOMMDF(string OFGJFNLDKGO)
	{
		this.OBKCKGHFMDN = KGLBKJKNPFD.LBFFMOMMAPK.setBit;
		if (OFGJFNLDKGO.Contains("index"))
		{
			this.GGICIBLJIKI = HLDNEMHDEDH.OKNGPMCDBFE(OFGJFNLDKGO, "index(", ')', true);
		}
	}

	// Token: 0x06007842 RID: 30786 RVA: 0x0035F1AC File Offset: 0x0035D3AC
	public override bool BBHDMMHCDKO()
	{
		return this.BOPJOMGIJIA == AMGALGOMMDF.BMHGEBOHLHH.done;
	}

	// Token: 0x06007843 RID: 30787 RVA: 0x0035F1B7 File Offset: 0x0035D3B7
	public override bool FMLECLNJAJM()
	{
		return this.BOPJOMGIJIA == (AMGALGOMMDF.BMHGEBOHLHH)this.KOIINMNNNDJ;
	}

	// Token: 0x06007844 RID: 30788 RVA: 0x0035F1C7 File Offset: 0x0035D3C7
	public override string LDHNPOGPAOB()
	{
		return this.BOPJOMGIJIA.ToString();
	}

	// Token: 0x04002317 RID: 8983
	public AMGALGOMMDF.BMHGEBOHLHH BOPJOMGIJIA;

	// Token: 0x04002318 RID: 8984
	public int GGICIBLJIKI = -1;

	// Token: 0x020003F9 RID: 1017
	public enum BMHGEBOHLHH
	{
		// Token: 0x0400231A RID: 8986
		start,
		// Token: 0x0400231B RID: 8987
		done
	}
}
