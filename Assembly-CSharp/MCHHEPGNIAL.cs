using System;

// Token: 0x02000307 RID: 775
public class MCHHEPGNIAL : KGLBKJKNPFD
{
	// Token: 0x06005E1D RID: 24093 RVA: 0x002ACBA8 File Offset: 0x002AADA8
	public MCHHEPGNIAL(string OFGJFNLDKGO)
	{
		this.OBKCKGHFMDN = KGLBKJKNPFD.LBFFMOMMAPK.invokeAvatarExtension;
		this.OOIOCDOGCNE = HLDNEMHDEDH.LNLOHDKFDAA(OFGJFNLDKGO, "id(", ')', true);
		if (OFGJFNLDKGO.Contains("time"))
		{
			this.AKCEKJFIGJH = HLDNEMHDEDH.NCIMIEAINEO(OFGJFNLDKGO, "time(", ')', true);
		}
	}

	// Token: 0x06005E1E RID: 24094 RVA: 0x002ACC03 File Offset: 0x002AAE03
	public override void FEHODJMIAJL(int OIMDDBOOAOB = 1)
	{
		if (!this.BBHDMMHCDKO())
		{
			this.BOPJOMGIJIA += OIMDDBOOAOB;
		}
	}

	// Token: 0x06005E1F RID: 24095 RVA: 0x002ACC1B File Offset: 0x002AAE1B
	public override bool BBHDMMHCDKO()
	{
		return this.BOPJOMGIJIA == MCHHEPGNIAL.BMHGEBOHLHH.done;
	}

	// Token: 0x06005E20 RID: 24096 RVA: 0x002ACC26 File Offset: 0x002AAE26
	public override bool FMLECLNJAJM()
	{
		return this.BOPJOMGIJIA == (MCHHEPGNIAL.BMHGEBOHLHH)this.KOIINMNNNDJ;
	}

	// Token: 0x06005E21 RID: 24097 RVA: 0x0001FBB0 File Offset: 0x0001DDB0
	public override bool PINCOCDOOGH()
	{
		return false;
	}

	// Token: 0x06005E22 RID: 24098 RVA: 0x002ACC36 File Offset: 0x002AAE36
	public override string LDHNPOGPAOB()
	{
		return this.BOPJOMGIJIA.ToString();
	}

	// Token: 0x04001AFC RID: 6908
	public MCHHEPGNIAL.BMHGEBOHLHH BOPJOMGIJIA;

	// Token: 0x04001AFD RID: 6909
	public string OOIOCDOGCNE = "";

	// Token: 0x04001AFE RID: 6910
	public float AKCEKJFIGJH;

	// Token: 0x02000308 RID: 776
	public enum BMHGEBOHLHH
	{
		// Token: 0x04001B00 RID: 6912
		start,
		// Token: 0x04001B01 RID: 6913
		done
	}
}
