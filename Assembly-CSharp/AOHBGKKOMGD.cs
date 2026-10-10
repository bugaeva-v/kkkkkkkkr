using System;

// Token: 0x020002C3 RID: 707
public class AOHBGKKOMGD : KGLBKJKNPFD
{
	// Token: 0x060058E2 RID: 22754 RVA: 0x0028219C File Offset: 0x0028039C
	public AOHBGKKOMGD(string OFGJFNLDKGO)
	{
		this.OBKCKGHFMDN = KGLBKJKNPFD.LBFFMOMMAPK.skinUnlocked;
		string text = HLDNEMHDEDH.LNLOHDKFDAA(OFGJFNLDKGO, "id(", ')', true);
		if (text == null || !int.TryParse(text, out this.OBLBNLBFBNI) || this.OBLBNLBFBNI < 0)
		{
			DPGJIJGOCIC.ADFCDFHBDAF("StoryStepSkinUnlocked - id() is not a shop index (" + text + "), the variable will be set to false: " + OFGJFNLDKGO);
			this.OBLBNLBFBNI = -1;
		}
		this.EHELHLOCOGG = HLDNEMHDEDH.LNLOHDKFDAA(OFGJFNLDKGO, "set(", ')', true);
	}

	// Token: 0x060058E3 RID: 22755 RVA: 0x00282223 File Offset: 0x00280423
	public override bool BBHDMMHCDKO()
	{
		return this.BOPJOMGIJIA == AOHBGKKOMGD.BMHGEBOHLHH.done;
	}

	// Token: 0x060058E4 RID: 22756 RVA: 0x0028222E File Offset: 0x0028042E
	public override bool FMLECLNJAJM()
	{
		return this.BOPJOMGIJIA == (AOHBGKKOMGD.BMHGEBOHLHH)this.KOIINMNNNDJ;
	}

	// Token: 0x060058E5 RID: 22757 RVA: 0x0028223E File Offset: 0x0028043E
	public override void FEHODJMIAJL(int OIMDDBOOAOB = 1)
	{
		if (!this.BBHDMMHCDKO())
		{
			this.BOPJOMGIJIA += OIMDDBOOAOB;
		}
	}

	// Token: 0x060058E6 RID: 22758 RVA: 0x0001FBB0 File Offset: 0x0001DDB0
	public override bool PINCOCDOOGH()
	{
		return false;
	}

	// Token: 0x060058E7 RID: 22759 RVA: 0x00282256 File Offset: 0x00280456
	public override string LDHNPOGPAOB()
	{
		return this.BOPJOMGIJIA.ToString();
	}

	// Token: 0x040018FB RID: 6395
	public int OBLBNLBFBNI = -1;

	// Token: 0x040018FC RID: 6396
	public string EHELHLOCOGG = "";

	// Token: 0x040018FD RID: 6397
	public AOHBGKKOMGD.BMHGEBOHLHH BOPJOMGIJIA;

	// Token: 0x020002C4 RID: 708
	public enum BMHGEBOHLHH
	{
		// Token: 0x040018FF RID: 6399
		start,
		// Token: 0x04001900 RID: 6400
		done
	}
}
