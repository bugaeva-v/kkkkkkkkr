using System;

// Token: 0x02000475 RID: 1141
public class EAFFJFDFDOM : KGLBKJKNPFD
{
	// Token: 0x06008AB7 RID: 35511 RVA: 0x003DA62C File Offset: 0x003D882C
	public EAFFJFDFDOM(string OFGJFNLDKGO)
	{
		this.OBKCKGHFMDN = KGLBKJKNPFD.LBFFMOMMAPK.skinApplied;
		this.BIKHKADNPLO = HLDNEMHDEDH.LNLOHDKFDAA(OFGJFNLDKGO, "id(", ')', true);
		if (this.BIKHKADNPLO == null || this.BIKHKADNPLO.Length == 0)
		{
			DPGJIJGOCIC.ADFCDFHBDAF("StoryStepSkinApplied - empty id(), the variable will be set to false: " + OFGJFNLDKGO);
			this.BIKHKADNPLO = "";
		}
		this.EHELHLOCOGG = HLDNEMHDEDH.LNLOHDKFDAA(OFGJFNLDKGO, "set(", ')', true);
	}

	// Token: 0x06008AB8 RID: 35512 RVA: 0x003DA6B5 File Offset: 0x003D88B5
	public override void FEHODJMIAJL(int OIMDDBOOAOB = 1)
	{
		if (!this.BBHDMMHCDKO())
		{
			this.BOPJOMGIJIA += OIMDDBOOAOB;
		}
	}

	// Token: 0x06008AB9 RID: 35513 RVA: 0x003DA6CD File Offset: 0x003D88CD
	public override bool FMLECLNJAJM()
	{
		return this.BOPJOMGIJIA == (EAFFJFDFDOM.BMHGEBOHLHH)this.KOIINMNNNDJ;
	}

	// Token: 0x06008ABA RID: 35514 RVA: 0x003DA6DD File Offset: 0x003D88DD
	public override string LDHNPOGPAOB()
	{
		return this.BOPJOMGIJIA.ToString();
	}

	// Token: 0x06008ABB RID: 35515 RVA: 0x0001FBB0 File Offset: 0x0001DDB0
	public override bool PINCOCDOOGH()
	{
		return false;
	}

	// Token: 0x06008ABC RID: 35516 RVA: 0x003DA6F0 File Offset: 0x003D88F0
	public override bool BBHDMMHCDKO()
	{
		return this.BOPJOMGIJIA == EAFFJFDFDOM.BMHGEBOHLHH.done;
	}

	// Token: 0x040026F3 RID: 9971
	public string BIKHKADNPLO = "";

	// Token: 0x040026F4 RID: 9972
	public string EHELHLOCOGG = "";

	// Token: 0x040026F5 RID: 9973
	public EAFFJFDFDOM.BMHGEBOHLHH BOPJOMGIJIA;

	// Token: 0x02000476 RID: 1142
	public enum BMHGEBOHLHH
	{
		// Token: 0x040026F7 RID: 9975
		start,
		// Token: 0x040026F8 RID: 9976
		done
	}
}
