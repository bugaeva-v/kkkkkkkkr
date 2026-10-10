using System;
using System.Collections.Generic;

// Token: 0x020000A6 RID: 166
public class IGMOFFJDEAK : KGLBKJKNPFD
{
	// Token: 0x06001697 RID: 5783 RVA: 0x000ABD2C File Offset: 0x000A9F2C
	public override string LDHNPOGPAOB()
	{
		return this.BOPJOMGIJIA.ToString();
	}

	// Token: 0x06001698 RID: 5784 RVA: 0x000ABD3F File Offset: 0x000A9F3F
	public override void FEHODJMIAJL(int OIMDDBOOAOB = 1)
	{
		if (!this.BBHDMMHCDKO())
		{
			this.BOPJOMGIJIA += OIMDDBOOAOB;
		}
	}

	// Token: 0x06001699 RID: 5785 RVA: 0x000ABD57 File Offset: 0x000A9F57
	public IGMOFFJDEAK(string OFGJFNLDKGO)
	{
		this.OBKCKGHFMDN = KGLBKJKNPFD.LBFFMOMMAPK.npcPropDisable;
		this.OLPMONKMBPO = HLDNEMHDEDH.NNKLPOAODNF(OFGJFNLDKGO, "id(", ')', true);
	}

	// Token: 0x0600169A RID: 5786 RVA: 0x000ABD86 File Offset: 0x000A9F86
	public override bool BBHDMMHCDKO()
	{
		return this.BOPJOMGIJIA == IGMOFFJDEAK.BMHGEBOHLHH.done;
	}

	// Token: 0x0600169B RID: 5787 RVA: 0x0001FBB0 File Offset: 0x0001DDB0
	public override bool PINCOCDOOGH()
	{
		return false;
	}

	// Token: 0x0600169C RID: 5788 RVA: 0x000ABD91 File Offset: 0x000A9F91
	public override bool FMLECLNJAJM()
	{
		return this.BOPJOMGIJIA == (IGMOFFJDEAK.BMHGEBOHLHH)this.KOIINMNNNDJ;
	}

	// Token: 0x040006E0 RID: 1760
	public IGMOFFJDEAK.BMHGEBOHLHH BOPJOMGIJIA;

	// Token: 0x040006E1 RID: 1761
	public List<string> OLPMONKMBPO = new List<string>();

	// Token: 0x020000A7 RID: 167
	public enum BMHGEBOHLHH
	{
		// Token: 0x040006E3 RID: 1763
		start,
		// Token: 0x040006E4 RID: 1764
		done
	}
}
