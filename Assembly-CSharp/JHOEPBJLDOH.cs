using System;

// Token: 0x02000487 RID: 1159
public class JHOEPBJLDOH : KGLBKJKNPFD
{
	// Token: 0x06008C3B RID: 35899 RVA: 0x003E1B82 File Offset: 0x003DFD82
	public override bool BBHDMMHCDKO()
	{
		return this.BOPJOMGIJIA == JHOEPBJLDOH.BMHGEBOHLHH.done;
	}

	// Token: 0x06008C3C RID: 35900 RVA: 0x003E1B8D File Offset: 0x003DFD8D
	public override bool PINCOCDOOGH()
	{
		return this.BOPJOMGIJIA == JHOEPBJLDOH.BMHGEBOHLHH.waitForInput;
	}

	// Token: 0x06008C3D RID: 35901 RVA: 0x003E1B98 File Offset: 0x003DFD98
	public JHOEPBJLDOH(string OFGJFNLDKGO)
	{
		this.OBKCKGHFMDN = KGLBKJKNPFD.LBFFMOMMAPK.storyLogo;
		this.JCPJMCKPAFC = HLDNEMHDEDH.LNLOHDKFDAA(OFGJFNLDKGO, "id(", ')', true);
	}

	// Token: 0x06008C3E RID: 35902 RVA: 0x003E1BC7 File Offset: 0x003DFDC7
	public override string LDHNPOGPAOB()
	{
		return this.BOPJOMGIJIA.ToString();
	}

	// Token: 0x06008C3F RID: 35903 RVA: 0x003E1BDA File Offset: 0x003DFDDA
	public override bool FMLECLNJAJM()
	{
		return this.BOPJOMGIJIA == (JHOEPBJLDOH.BMHGEBOHLHH)this.KOIINMNNNDJ;
	}

	// Token: 0x06008C40 RID: 35904 RVA: 0x003E1BEA File Offset: 0x003DFDEA
	public override void FEHODJMIAJL(int OIMDDBOOAOB = 1)
	{
		if (!this.BBHDMMHCDKO())
		{
			this.BOPJOMGIJIA += OIMDDBOOAOB;
		}
	}

	// Token: 0x04002744 RID: 10052
	public JHOEPBJLDOH.BMHGEBOHLHH BOPJOMGIJIA;

	// Token: 0x04002745 RID: 10053
	public string JCPJMCKPAFC = "";

	// Token: 0x02000488 RID: 1160
	public enum BMHGEBOHLHH
	{
		// Token: 0x04002747 RID: 10055
		show,
		// Token: 0x04002748 RID: 10056
		showDialog,
		// Token: 0x04002749 RID: 10057
		waitForInput,
		// Token: 0x0400274A RID: 10058
		hide,
		// Token: 0x0400274B RID: 10059
		done
	}
}
