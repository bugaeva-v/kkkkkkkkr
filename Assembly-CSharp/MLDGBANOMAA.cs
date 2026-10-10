using System;

// Token: 0x020002C8 RID: 712
public class MLDGBANOMAA : KGLBKJKNPFD
{
	// Token: 0x060058EE RID: 22766 RVA: 0x0028234B File Offset: 0x0028054B
	public MLDGBANOMAA(string OFGJFNLDKGO)
	{
		this.OBKCKGHFMDN = KGLBKJKNPFD.LBFFMOMMAPK.setFaderFx;
		this.AKCAKJMDBBL = HLDNEMHDEDH.OKNGPMCDBFE(OFGJFNLDKGO, "index(", ')', true);
	}

	// Token: 0x060058EF RID: 22767 RVA: 0x00282376 File Offset: 0x00280576
	public override void FEHODJMIAJL(int OIMDDBOOAOB = 1)
	{
		if (!this.BBHDMMHCDKO())
		{
			this.BOPJOMGIJIA += OIMDDBOOAOB;
		}
	}

	// Token: 0x060058F0 RID: 22768 RVA: 0x0001FBB0 File Offset: 0x0001DDB0
	public override bool PINCOCDOOGH()
	{
		return false;
	}

	// Token: 0x060058F1 RID: 22769 RVA: 0x0028238E File Offset: 0x0028058E
	public override bool BBHDMMHCDKO()
	{
		return this.BOPJOMGIJIA == MLDGBANOMAA.BMHGEBOHLHH.done;
	}

	// Token: 0x060058F2 RID: 22770 RVA: 0x00282399 File Offset: 0x00280599
	public override string LDHNPOGPAOB()
	{
		return this.BOPJOMGIJIA.ToString();
	}

	// Token: 0x060058F3 RID: 22771 RVA: 0x002823AC File Offset: 0x002805AC
	public override bool FMLECLNJAJM()
	{
		return this.BOPJOMGIJIA == (MLDGBANOMAA.BMHGEBOHLHH)this.KOIINMNNNDJ;
	}

	// Token: 0x04001915 RID: 6421
	public MLDGBANOMAA.BMHGEBOHLHH BOPJOMGIJIA;

	// Token: 0x04001916 RID: 6422
	public int AKCAKJMDBBL = -1;

	// Token: 0x020002C9 RID: 713
	public enum BMHGEBOHLHH
	{
		// Token: 0x04001918 RID: 6424
		start,
		// Token: 0x04001919 RID: 6425
		done
	}
}
