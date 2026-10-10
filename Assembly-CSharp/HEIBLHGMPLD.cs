using System;

// Token: 0x020002FB RID: 763
public class HEIBLHGMPLD : KGLBKJKNPFD
{
	// Token: 0x06005D00 RID: 23808 RVA: 0x002A57E0 File Offset: 0x002A39E0
	public HEIBLHGMPLD(string OFGJFNLDKGO)
	{
		this.OBKCKGHFMDN = KGLBKJKNPFD.LBFFMOMMAPK.npcFromAvatar;
		this.IHCMBIBJBJD = HLDNEMHDEDH.LNLOHDKFDAA(OFGJFNLDKGO, "id(", ')', true);
		this.PLPCLJFJFNG = HLDNEMHDEDH.LNLOHDKFDAA(OFGJFNLDKGO, "clothes(", ')', true);
		this.OMGLOJOIOCK = HLDNEMHDEDH.LNLOHDKFDAA(OFGJFNLDKGO, "hair(", ')', true);
		this.PBOKDNDMCDL = HLDNEMHDEDH.LNLOHDKFDAA(OFGJFNLDKGO, "trinket(", ')', true);
		this.GHALDHOOFKN = HLDNEMHDEDH.LNLOHDKFDAA(OFGJFNLDKGO, "overlay(", ')', true);
		if (KGLBKJKNPFD.AFKAMBFMMOH >= 0)
		{
			string akmibddhadh = "";
			if (KGLBKJKNPFD.AFKAMBFMMOH > 0)
			{
				akmibddhadh = "+" + KGLBKJKNPFD.AFKAMBFMMOH.ToString();
			}
			this.PLPCLJFJFNG = HLDNEMHDEDH.DGNHJHJMHPD(this.PLPCLJFJFNG, akmibddhadh);
			this.OMGLOJOIOCK = HLDNEMHDEDH.DGNHJHJMHPD(this.OMGLOJOIOCK, akmibddhadh);
			this.PBOKDNDMCDL = HLDNEMHDEDH.DGNHJHJMHPD(this.PBOKDNDMCDL, akmibddhadh);
			this.GHALDHOOFKN = HLDNEMHDEDH.DGNHJHJMHPD(this.GHALDHOOFKN, akmibddhadh);
		}
	}

	// Token: 0x06005D01 RID: 23809 RVA: 0x002A5909 File Offset: 0x002A3B09
	public override string LDHNPOGPAOB()
	{
		return this.BOPJOMGIJIA.ToString();
	}

	// Token: 0x06005D02 RID: 23810 RVA: 0x002A591C File Offset: 0x002A3B1C
	public override bool BBHDMMHCDKO()
	{
		return this.BOPJOMGIJIA == HEIBLHGMPLD.BMHGEBOHLHH.done;
	}

	// Token: 0x06005D03 RID: 23811 RVA: 0x002A5927 File Offset: 0x002A3B27
	public override void FEHODJMIAJL(int OIMDDBOOAOB = 1)
	{
		if (!this.BBHDMMHCDKO())
		{
			this.BOPJOMGIJIA += OIMDDBOOAOB;
		}
	}

	// Token: 0x06005D04 RID: 23812 RVA: 0x0001FBB0 File Offset: 0x0001DDB0
	public override bool PINCOCDOOGH()
	{
		return false;
	}

	// Token: 0x06005D05 RID: 23813 RVA: 0x002A593F File Offset: 0x002A3B3F
	public override bool FMLECLNJAJM()
	{
		return this.BOPJOMGIJIA == (HEIBLHGMPLD.BMHGEBOHLHH)this.KOIINMNNNDJ;
	}

	// Token: 0x04001AAB RID: 6827
	public HEIBLHGMPLD.BMHGEBOHLHH BOPJOMGIJIA;

	// Token: 0x04001AAC RID: 6828
	public string PLPCLJFJFNG = "";

	// Token: 0x04001AAD RID: 6829
	public string OMGLOJOIOCK = "";

	// Token: 0x04001AAE RID: 6830
	public string PBOKDNDMCDL = "";

	// Token: 0x04001AAF RID: 6831
	public string GHALDHOOFKN = "";

	// Token: 0x04001AB0 RID: 6832
	public string IHCMBIBJBJD = "";

	// Token: 0x020002FC RID: 764
	public enum BMHGEBOHLHH
	{
		// Token: 0x04001AB2 RID: 6834
		start,
		// Token: 0x04001AB3 RID: 6835
		done
	}
}
