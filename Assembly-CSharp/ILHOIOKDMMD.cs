using System;

// Token: 0x020002A7 RID: 679
public class ILHOIOKDMMD : KGLBKJKNPFD
{
	// Token: 0x06005627 RID: 22055 RVA: 0x00267E89 File Offset: 0x00266089
	public override bool FMLECLNJAJM()
	{
		return this.BOPJOMGIJIA == (ILHOIOKDMMD.BMHGEBOHLHH)this.KOIINMNNNDJ;
	}

	// Token: 0x06005628 RID: 22056 RVA: 0x00267E99 File Offset: 0x00266099
	public override void FEHODJMIAJL(int OIMDDBOOAOB = 1)
	{
		if (!this.BBHDMMHCDKO())
		{
			this.BOPJOMGIJIA += OIMDDBOOAOB;
		}
	}

	// Token: 0x06005629 RID: 22057 RVA: 0x00267EB1 File Offset: 0x002660B1
	public override string LDHNPOGPAOB()
	{
		return this.BOPJOMGIJIA.ToString();
	}

	// Token: 0x0600562A RID: 22058 RVA: 0x0001FBB0 File Offset: 0x0001DDB0
	public override bool PINCOCDOOGH()
	{
		return false;
	}

	// Token: 0x0600562B RID: 22059 RVA: 0x00267EC4 File Offset: 0x002660C4
	public override bool BBHDMMHCDKO()
	{
		return this.BOPJOMGIJIA == ILHOIOKDMMD.BMHGEBOHLHH.done;
	}

	// Token: 0x0600562C RID: 22060 RVA: 0x00267ECF File Offset: 0x002660CF
	public ILHOIOKDMMD(string OFGJFNLDKGO)
	{
		this.OBKCKGHFMDN = KGLBKJKNPFD.LBFFMOMMAPK.disableAvatarExtension;
		this.OOIOCDOGCNE = HLDNEMHDEDH.LNLOHDKFDAA(OFGJFNLDKGO, "id(", ')', true);
	}

	// Token: 0x0400183B RID: 6203
	public ILHOIOKDMMD.BMHGEBOHLHH BOPJOMGIJIA;

	// Token: 0x0400183C RID: 6204
	public string OOIOCDOGCNE = "";

	// Token: 0x020002A8 RID: 680
	public enum BMHGEBOHLHH
	{
		// Token: 0x0400183E RID: 6206
		start,
		// Token: 0x0400183F RID: 6207
		done
	}
}
