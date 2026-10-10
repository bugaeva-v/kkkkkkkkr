using System;
using System.Collections.Generic;

// Token: 0x0200031C RID: 796
public class IGBLCIEDOBE : KGLBKJKNPFD
{
	// Token: 0x06005FA0 RID: 24480 RVA: 0x0001FBB0 File Offset: 0x0001DDB0
	public override bool PINCOCDOOGH()
	{
		return false;
	}

	// Token: 0x06005FA1 RID: 24481 RVA: 0x002B3E60 File Offset: 0x002B2060
	public override void FEHODJMIAJL(int OIMDDBOOAOB = 1)
	{
		if (!this.BBHDMMHCDKO())
		{
			this.BOPJOMGIJIA += OIMDDBOOAOB;
		}
	}

	// Token: 0x06005FA2 RID: 24482 RVA: 0x002B3E78 File Offset: 0x002B2078
	public override bool BBHDMMHCDKO()
	{
		return this.BOPJOMGIJIA == IGBLCIEDOBE.BMHGEBOHLHH.done;
	}

	// Token: 0x06005FA3 RID: 24483 RVA: 0x002B3E83 File Offset: 0x002B2083
	public override bool FMLECLNJAJM()
	{
		return this.BOPJOMGIJIA == (IGBLCIEDOBE.BMHGEBOHLHH)this.KOIINMNNNDJ;
	}

	// Token: 0x06005FA4 RID: 24484 RVA: 0x002B3E93 File Offset: 0x002B2093
	public IGBLCIEDOBE(string OFGJFNLDKGO)
	{
		this.OBKCKGHFMDN = KGLBKJKNPFD.LBFFMOMMAPK.npcPropEnable;
		this.OLPMONKMBPO = HLDNEMHDEDH.NNKLPOAODNF(OFGJFNLDKGO, "id(", ')', true);
	}

	// Token: 0x06005FA5 RID: 24485 RVA: 0x002B3EC2 File Offset: 0x002B20C2
	public override string LDHNPOGPAOB()
	{
		return this.BOPJOMGIJIA.ToString();
	}

	// Token: 0x04001B56 RID: 6998
	public IGBLCIEDOBE.BMHGEBOHLHH BOPJOMGIJIA;

	// Token: 0x04001B57 RID: 6999
	public List<string> OLPMONKMBPO = new List<string>();

	// Token: 0x0200031D RID: 797
	public enum BMHGEBOHLHH
	{
		// Token: 0x04001B59 RID: 7001
		start,
		// Token: 0x04001B5A RID: 7002
		done
	}
}
