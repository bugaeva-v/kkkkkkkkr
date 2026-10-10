using System;

// Token: 0x0200020A RID: 522
public class JIMEADEBKFF : KGLBKJKNPFD
{
	// Token: 0x06004194 RID: 16788 RVA: 0x001CAC91 File Offset: 0x001C8E91
	public override bool BBHDMMHCDKO()
	{
		return this.BOPJOMGIJIA == JIMEADEBKFF.BMHGEBOHLHH.done;
	}

	// Token: 0x06004195 RID: 16789 RVA: 0x0001FBB0 File Offset: 0x0001DDB0
	public override bool PINCOCDOOGH()
	{
		return false;
	}

	// Token: 0x06004196 RID: 16790 RVA: 0x001CAC9C File Offset: 0x001C8E9C
	public JIMEADEBKFF(string OFGJFNLDKGO)
	{
		this.OBKCKGHFMDN = KGLBKJKNPFD.LBFFMOMMAPK.removeSuperMapping;
		this.KALBADOPCDN = HLDNEMHDEDH.LNLOHDKFDAA(OFGJFNLDKGO, "id(", ')', true);
	}

	// Token: 0x06004197 RID: 16791 RVA: 0x001CACCB File Offset: 0x001C8ECB
	public override void FEHODJMIAJL(int OIMDDBOOAOB = 1)
	{
		if (!this.BBHDMMHCDKO())
		{
			this.BOPJOMGIJIA += OIMDDBOOAOB;
		}
	}

	// Token: 0x06004198 RID: 16792 RVA: 0x001CACE3 File Offset: 0x001C8EE3
	public override string LDHNPOGPAOB()
	{
		return this.BOPJOMGIJIA.ToString();
	}

	// Token: 0x06004199 RID: 16793 RVA: 0x001CACF6 File Offset: 0x001C8EF6
	public override bool FMLECLNJAJM()
	{
		return this.BOPJOMGIJIA == (JIMEADEBKFF.BMHGEBOHLHH)this.KOIINMNNNDJ;
	}

	// Token: 0x0400125A RID: 4698
	public JIMEADEBKFF.BMHGEBOHLHH BOPJOMGIJIA;

	// Token: 0x0400125B RID: 4699
	public string KALBADOPCDN = "";

	// Token: 0x0200020B RID: 523
	public enum BMHGEBOHLHH
	{
		// Token: 0x0400125D RID: 4701
		start,
		// Token: 0x0400125E RID: 4702
		done
	}
}
