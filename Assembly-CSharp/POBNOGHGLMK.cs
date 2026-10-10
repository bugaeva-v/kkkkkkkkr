using System;
using System.Collections.Generic;

// Token: 0x0200033F RID: 831
public class POBNOGHGLMK : KGLBKJKNPFD
{
	// Token: 0x0600630C RID: 25356 RVA: 0x002D7A67 File Offset: 0x002D5C67
	public override string LDHNPOGPAOB()
	{
		return this.BOPJOMGIJIA.ToString();
	}

	// Token: 0x0600630D RID: 25357 RVA: 0x002D7A7A File Offset: 0x002D5C7A
	public POBNOGHGLMK(string OFGJFNLDKGO)
	{
		this.OBKCKGHFMDN = KGLBKJKNPFD.LBFFMOMMAPK.npcPropIgnore;
		this.OLPMONKMBPO = HLDNEMHDEDH.NNKLPOAODNF(OFGJFNLDKGO, "id(", ')', true);
	}

	// Token: 0x0600630E RID: 25358 RVA: 0x002D7AA9 File Offset: 0x002D5CA9
	public override void FEHODJMIAJL(int OIMDDBOOAOB = 1)
	{
		if (!this.BBHDMMHCDKO())
		{
			this.BOPJOMGIJIA += OIMDDBOOAOB;
		}
	}

	// Token: 0x0600630F RID: 25359 RVA: 0x002D7AC1 File Offset: 0x002D5CC1
	public override bool FMLECLNJAJM()
	{
		return this.BOPJOMGIJIA == (POBNOGHGLMK.BMHGEBOHLHH)this.KOIINMNNNDJ;
	}

	// Token: 0x06006310 RID: 25360 RVA: 0x002D7AD1 File Offset: 0x002D5CD1
	public override bool BBHDMMHCDKO()
	{
		return this.BOPJOMGIJIA == POBNOGHGLMK.BMHGEBOHLHH.done;
	}

	// Token: 0x06006311 RID: 25361 RVA: 0x0001FBB0 File Offset: 0x0001DDB0
	public override bool PINCOCDOOGH()
	{
		return false;
	}

	// Token: 0x04001CA9 RID: 7337
	public POBNOGHGLMK.BMHGEBOHLHH BOPJOMGIJIA;

	// Token: 0x04001CAA RID: 7338
	public List<string> OLPMONKMBPO = new List<string>();

	// Token: 0x02000340 RID: 832
	public enum BMHGEBOHLHH
	{
		// Token: 0x04001CAC RID: 7340
		start,
		// Token: 0x04001CAD RID: 7341
		done
	}
}
