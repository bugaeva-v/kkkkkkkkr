using System;

// Token: 0x020003EE RID: 1006
public class OLHOPDNIDLB : KGLBKJKNPFD
{
	// Token: 0x060074F7 RID: 29943 RVA: 0x00349472 File Offset: 0x00347672
	public override string LDHNPOGPAOB()
	{
		return this.BOPJOMGIJIA.ToString();
	}

	// Token: 0x060074F8 RID: 29944 RVA: 0x0001FBB0 File Offset: 0x0001DDB0
	public override bool PINCOCDOOGH()
	{
		return false;
	}

	// Token: 0x060074F9 RID: 29945 RVA: 0x00349485 File Offset: 0x00347685
	public override void FEHODJMIAJL(int OIMDDBOOAOB = 1)
	{
		if (!this.BBHDMMHCDKO())
		{
			this.BOPJOMGIJIA += OIMDDBOOAOB;
		}
	}

	// Token: 0x060074FA RID: 29946 RVA: 0x0034949D File Offset: 0x0034769D
	public override bool BBHDMMHCDKO()
	{
		return this.BOPJOMGIJIA == OLHOPDNIDLB.BMHGEBOHLHH.done;
	}

	// Token: 0x060074FB RID: 29947 RVA: 0x003494A8 File Offset: 0x003476A8
	public override bool FMLECLNJAJM()
	{
		return this.BOPJOMGIJIA == (OLHOPDNIDLB.BMHGEBOHLHH)this.KOIINMNNNDJ;
	}

	// Token: 0x060074FC RID: 29948 RVA: 0x003494B8 File Offset: 0x003476B8
	public OLHOPDNIDLB(string OFGJFNLDKGO)
	{
		this.OBKCKGHFMDN = KGLBKJKNPFD.LBFFMOMMAPK.npcHideDialog;
		if (OFGJFNLDKGO.Contains("delay"))
		{
			this.EBMMGNEEBIC = HLDNEMHDEDH.NCIMIEAINEO(OFGJFNLDKGO, "delay(", ')', true);
		}
	}

	// Token: 0x040022AB RID: 8875
	public OLHOPDNIDLB.BMHGEBOHLHH BOPJOMGIJIA;

	// Token: 0x040022AC RID: 8876
	public float EBMMGNEEBIC;

	// Token: 0x020003EF RID: 1007
	public enum BMHGEBOHLHH
	{
		// Token: 0x040022AE RID: 8878
		start,
		// Token: 0x040022AF RID: 8879
		done
	}
}
