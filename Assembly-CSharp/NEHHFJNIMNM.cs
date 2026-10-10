using System;

// Token: 0x020001BF RID: 447
public class NEHHFJNIMNM : KGLBKJKNPFD
{
	// Token: 0x06003790 RID: 14224 RVA: 0x001705E5 File Offset: 0x0016E7E5
	public override bool FMLECLNJAJM()
	{
		return this.BOPJOMGIJIA == (NEHHFJNIMNM.BMHGEBOHLHH)this.KOIINMNNNDJ;
	}

	// Token: 0x06003791 RID: 14225 RVA: 0x001705F5 File Offset: 0x0016E7F5
	public NEHHFJNIMNM(string OFGJFNLDKGO)
	{
		this.OBKCKGHFMDN = KGLBKJKNPFD.LBFFMOMMAPK.enableAvatarExtension;
		this.OOIOCDOGCNE = HLDNEMHDEDH.LNLOHDKFDAA(OFGJFNLDKGO, "id(", ')', true);
	}

	// Token: 0x06003792 RID: 14226 RVA: 0x00170624 File Offset: 0x0016E824
	public override bool BBHDMMHCDKO()
	{
		return this.BOPJOMGIJIA == NEHHFJNIMNM.BMHGEBOHLHH.done;
	}

	// Token: 0x06003793 RID: 14227 RVA: 0x0017062F File Offset: 0x0016E82F
	public override void FEHODJMIAJL(int OIMDDBOOAOB = 1)
	{
		if (!this.BBHDMMHCDKO())
		{
			this.BOPJOMGIJIA += OIMDDBOOAOB;
		}
	}

	// Token: 0x06003794 RID: 14228 RVA: 0x00170647 File Offset: 0x0016E847
	public override string LDHNPOGPAOB()
	{
		return this.BOPJOMGIJIA.ToString();
	}

	// Token: 0x06003795 RID: 14229 RVA: 0x0001FBB0 File Offset: 0x0001DDB0
	public override bool PINCOCDOOGH()
	{
		return false;
	}

	// Token: 0x04001078 RID: 4216
	public NEHHFJNIMNM.BMHGEBOHLHH BOPJOMGIJIA;

	// Token: 0x04001079 RID: 4217
	public string OOIOCDOGCNE = "";

	// Token: 0x020001C0 RID: 448
	public enum BMHGEBOHLHH
	{
		// Token: 0x0400107B RID: 4219
		start,
		// Token: 0x0400107C RID: 4220
		done
	}
}
