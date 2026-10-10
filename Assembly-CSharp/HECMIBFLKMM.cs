using System;

// Token: 0x020002FE RID: 766
public class HECMIBFLKMM : KGLBKJKNPFD
{
	// Token: 0x06005D2C RID: 23852 RVA: 0x002A5CD1 File Offset: 0x002A3ED1
	public override void FEHODJMIAJL(int OIMDDBOOAOB = 1)
	{
		if (!this.BBHDMMHCDKO())
		{
			this.BOPJOMGIJIA += OIMDDBOOAOB;
		}
	}

	// Token: 0x06005D2D RID: 23853 RVA: 0x002A5CE9 File Offset: 0x002A3EE9
	public override bool FMLECLNJAJM()
	{
		return this.BOPJOMGIJIA == (HECMIBFLKMM.BMHGEBOHLHH)this.KOIINMNNNDJ;
	}

	// Token: 0x06005D2E RID: 23854 RVA: 0x002A5CF9 File Offset: 0x002A3EF9
	public HECMIBFLKMM(string OFGJFNLDKGO)
	{
		this.OBKCKGHFMDN = KGLBKJKNPFD.LBFFMOMMAPK.useAnimV2;
	}

	// Token: 0x06005D2F RID: 23855 RVA: 0x002A5D09 File Offset: 0x002A3F09
	public override bool BBHDMMHCDKO()
	{
		return this.BOPJOMGIJIA == HECMIBFLKMM.BMHGEBOHLHH.done;
	}

	// Token: 0x06005D30 RID: 23856 RVA: 0x002A5D14 File Offset: 0x002A3F14
	public override string LDHNPOGPAOB()
	{
		return this.BOPJOMGIJIA.ToString();
	}

	// Token: 0x06005D31 RID: 23857 RVA: 0x0001FBB0 File Offset: 0x0001DDB0
	public override bool PINCOCDOOGH()
	{
		return false;
	}

	// Token: 0x04001AB8 RID: 6840
	public HECMIBFLKMM.BMHGEBOHLHH BOPJOMGIJIA;

	// Token: 0x020002FF RID: 767
	public enum BMHGEBOHLHH
	{
		// Token: 0x04001ABA RID: 6842
		start,
		// Token: 0x04001ABB RID: 6843
		done
	}
}
