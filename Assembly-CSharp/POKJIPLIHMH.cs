using System;

// Token: 0x020003C6 RID: 966
public class POKJIPLIHMH : KGLBKJKNPFD
{
	// Token: 0x06007074 RID: 28788 RVA: 0x0032D7B0 File Offset: 0x0032B9B0
	public POKJIPLIHMH(string OFGJFNLDKGO)
	{
		this.OBKCKGHFMDN = KGLBKJKNPFD.LBFFMOMMAPK.emotionLoopEnd;
		if (OFGJFNLDKGO.Contains("id"))
		{
			this.GEODIDKODMB = HLDNEMHDEDH.LNLOHDKFDAA(OFGJFNLDKGO, "id(", ')', true);
		}
	}

	// Token: 0x06007075 RID: 28789 RVA: 0x0032D7EC File Offset: 0x0032B9EC
	public override bool BBHDMMHCDKO()
	{
		return this.BOPJOMGIJIA == POKJIPLIHMH.BMHGEBOHLHH.done;
	}

	// Token: 0x06007076 RID: 28790 RVA: 0x0032D7F7 File Offset: 0x0032B9F7
	public override string LDHNPOGPAOB()
	{
		return this.BOPJOMGIJIA.ToString();
	}

	// Token: 0x06007077 RID: 28791 RVA: 0x0001FBB0 File Offset: 0x0001DDB0
	public override bool PINCOCDOOGH()
	{
		return false;
	}

	// Token: 0x06007078 RID: 28792 RVA: 0x0032D80A File Offset: 0x0032BA0A
	public override void FEHODJMIAJL(int OIMDDBOOAOB = 1)
	{
		if (!this.BBHDMMHCDKO())
		{
			this.BOPJOMGIJIA += OIMDDBOOAOB;
		}
	}

	// Token: 0x06007079 RID: 28793 RVA: 0x0032D822 File Offset: 0x0032BA22
	public override bool FMLECLNJAJM()
	{
		return this.BOPJOMGIJIA == (POKJIPLIHMH.BMHGEBOHLHH)this.KOIINMNNNDJ;
	}

	// Token: 0x04002196 RID: 8598
	public POKJIPLIHMH.BMHGEBOHLHH BOPJOMGIJIA;

	// Token: 0x04002197 RID: 8599
	public string GEODIDKODMB = "";

	// Token: 0x020003C7 RID: 967
	public enum BMHGEBOHLHH
	{
		// Token: 0x04002199 RID: 8601
		End,
		// Token: 0x0400219A RID: 8602
		done
	}
}
