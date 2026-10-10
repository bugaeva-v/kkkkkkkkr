using System;
using System.Collections.Generic;

// Token: 0x020004F6 RID: 1270
public class LPFFPEPIPAL : KGLBKJKNPFD
{
	// Token: 0x06009993 RID: 39315 RVA: 0x0001FBB0 File Offset: 0x0001DDB0
	public override bool PINCOCDOOGH()
	{
		return false;
	}

	// Token: 0x06009994 RID: 39316 RVA: 0x0042889F File Offset: 0x00426A9F
	public override bool BBHDMMHCDKO()
	{
		return this.BOPJOMGIJIA == LPFFPEPIPAL.BMHGEBOHLHH.done;
	}

	// Token: 0x06009995 RID: 39317 RVA: 0x004288AA File Offset: 0x00426AAA
	public LPFFPEPIPAL(string OFGJFNLDKGO)
	{
		this.OBKCKGHFMDN = KGLBKJKNPFD.LBFFMOMMAPK.prepareVideo;
		this.LOCCINPEPKC = HLDNEMHDEDH.NNKLPOAODNF(OFGJFNLDKGO, "id(", ')', true);
	}

	// Token: 0x06009996 RID: 39318 RVA: 0x004288D9 File Offset: 0x00426AD9
	public override bool FMLECLNJAJM()
	{
		return this.BOPJOMGIJIA == (LPFFPEPIPAL.BMHGEBOHLHH)this.KOIINMNNNDJ;
	}

	// Token: 0x06009997 RID: 39319 RVA: 0x004288E9 File Offset: 0x00426AE9
	public override void FEHODJMIAJL(int OIMDDBOOAOB = 1)
	{
		if (!this.BBHDMMHCDKO())
		{
			this.BOPJOMGIJIA += OIMDDBOOAOB;
		}
	}

	// Token: 0x06009998 RID: 39320 RVA: 0x00428901 File Offset: 0x00426B01
	public override string LDHNPOGPAOB()
	{
		return this.BOPJOMGIJIA.ToString();
	}

	// Token: 0x04002A57 RID: 10839
	public LPFFPEPIPAL.BMHGEBOHLHH BOPJOMGIJIA;

	// Token: 0x04002A58 RID: 10840
	public List<string> LOCCINPEPKC = new List<string>();

	// Token: 0x020004F7 RID: 1271
	public enum BMHGEBOHLHH
	{
		// Token: 0x04002A5A RID: 10842
		start,
		// Token: 0x04002A5B RID: 10843
		done
	}
}
