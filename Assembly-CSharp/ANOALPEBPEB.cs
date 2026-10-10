using System;

// Token: 0x02000323 RID: 803
public class ANOALPEBPEB : KGLBKJKNPFD
{
	// Token: 0x06006039 RID: 24633 RVA: 0x002BC418 File Offset: 0x002BA618
	public ANOALPEBPEB(string OFGJFNLDKGO)
	{
		this.OBKCKGHFMDN = KGLBKJKNPFD.LBFFMOMMAPK.environmentFlip;
		this.FLPGNPNHJNK = HLDNEMHDEDH.LNLOHDKFDAA(OFGJFNLDKGO, "id(", ')', true);
		if (OFGJFNLDKGO.Contains("scale"))
		{
			this.CBANOPDMNEI = HLDNEMHDEDH.NCIMIEAINEO(OFGJFNLDKGO, "scale(", ')', true);
		}
	}

	// Token: 0x0600603A RID: 24634 RVA: 0x0001FBB0 File Offset: 0x0001DDB0
	public override bool PINCOCDOOGH()
	{
		return false;
	}

	// Token: 0x0600603B RID: 24635 RVA: 0x002BC47D File Offset: 0x002BA67D
	public override void FEHODJMIAJL(int OIMDDBOOAOB = 1)
	{
		if (!this.BBHDMMHCDKO())
		{
			this.BOPJOMGIJIA += OIMDDBOOAOB;
		}
	}

	// Token: 0x0600603C RID: 24636 RVA: 0x002BC495 File Offset: 0x002BA695
	public override bool BBHDMMHCDKO()
	{
		return this.BOPJOMGIJIA == ANOALPEBPEB.BMHGEBOHLHH.done;
	}

	// Token: 0x0600603D RID: 24637 RVA: 0x002BC4A0 File Offset: 0x002BA6A0
	public override bool FMLECLNJAJM()
	{
		return this.BOPJOMGIJIA == (ANOALPEBPEB.BMHGEBOHLHH)this.KOIINMNNNDJ;
	}

	// Token: 0x0600603E RID: 24638 RVA: 0x002BC4B0 File Offset: 0x002BA6B0
	public override string LDHNPOGPAOB()
	{
		return this.BOPJOMGIJIA.ToString();
	}

	// Token: 0x04001B70 RID: 7024
	public ANOALPEBPEB.BMHGEBOHLHH BOPJOMGIJIA;

	// Token: 0x04001B71 RID: 7025
	public float CBANOPDMNEI = -1f;

	// Token: 0x04001B72 RID: 7026
	public string FLPGNPNHJNK = "";

	// Token: 0x02000324 RID: 804
	public enum BMHGEBOHLHH
	{
		// Token: 0x04001B74 RID: 7028
		start,
		// Token: 0x04001B75 RID: 7029
		done
	}
}
