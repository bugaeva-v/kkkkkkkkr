using System;

// Token: 0x02000031 RID: 49
public class BFNCOLBCJCP : KGLBKJKNPFD
{
	// Token: 0x0600071E RID: 1822 RVA: 0x00031C08 File Offset: 0x0002FE08
	public BFNCOLBCJCP(string OFGJFNLDKGO)
	{
		this.OBKCKGHFMDN = KGLBKJKNPFD.LBFFMOMMAPK.choiceExecuted;
		this.JCJNJNMPPOK = HLDNEMHDEDH.LNLOHDKFDAA(OFGJFNLDKGO, "id(", ')', true);
		this.EHELHLOCOGG = HLDNEMHDEDH.LNLOHDKFDAA(OFGJFNLDKGO, "set(", ')', true);
	}

	// Token: 0x0600071F RID: 1823 RVA: 0x0001FBB0 File Offset: 0x0001DDB0
	public override bool PINCOCDOOGH()
	{
		return false;
	}

	// Token: 0x06000720 RID: 1824 RVA: 0x00031C61 File Offset: 0x0002FE61
	public override bool BBHDMMHCDKO()
	{
		return this.BOPJOMGIJIA == BFNCOLBCJCP.BMHGEBOHLHH.done;
	}

	// Token: 0x06000721 RID: 1825 RVA: 0x00031C6C File Offset: 0x0002FE6C
	public override string LDHNPOGPAOB()
	{
		return this.BOPJOMGIJIA.ToString();
	}

	// Token: 0x06000722 RID: 1826 RVA: 0x00031C7F File Offset: 0x0002FE7F
	public override void FEHODJMIAJL(int OIMDDBOOAOB = 1)
	{
		if (!this.BBHDMMHCDKO())
		{
			this.BOPJOMGIJIA += OIMDDBOOAOB;
		}
	}

	// Token: 0x06000723 RID: 1827 RVA: 0x00031C97 File Offset: 0x0002FE97
	public override bool FMLECLNJAJM()
	{
		return this.BOPJOMGIJIA == (BFNCOLBCJCP.BMHGEBOHLHH)this.KOIINMNNNDJ;
	}

	// Token: 0x040001B4 RID: 436
	public string JCJNJNMPPOK = "";

	// Token: 0x040001B5 RID: 437
	public string EHELHLOCOGG = "";

	// Token: 0x040001B6 RID: 438
	public BFNCOLBCJCP.BMHGEBOHLHH BOPJOMGIJIA;

	// Token: 0x02000032 RID: 50
	public enum BMHGEBOHLHH
	{
		// Token: 0x040001B8 RID: 440
		start,
		// Token: 0x040001B9 RID: 441
		done
	}
}
