using System;

// Token: 0x020002F9 RID: 761
public class DNFBGCGNLKA : KGLBKJKNPFD
{
	// Token: 0x06005CFA RID: 23802 RVA: 0x002A571B File Offset: 0x002A391B
	public override bool BBHDMMHCDKO()
	{
		return this.BOPJOMGIJIA == DNFBGCGNLKA.BMHGEBOHLHH.done;
	}

	// Token: 0x06005CFB RID: 23803 RVA: 0x002A5726 File Offset: 0x002A3926
	public override string LDHNPOGPAOB()
	{
		return this.BOPJOMGIJIA.ToString();
	}

	// Token: 0x06005CFC RID: 23804 RVA: 0x002A573C File Offset: 0x002A393C
	public DNFBGCGNLKA(string OFGJFNLDKGO)
	{
		this.OBKCKGHFMDN = KGLBKJKNPFD.LBFFMOMMAPK.giveItem;
		this.IDGJMPJDEAO = HLDNEMHDEDH.LNLOHDKFDAA(OFGJFNLDKGO, "id(", ')', true);
		if (OFGJFNLDKGO.Contains("title"))
		{
			this.OHIADAOPIIJ = HLDNEMHDEDH.LNLOHDKFDAA(OFGJFNLDKGO, "title(", ')', true);
		}
		if (OFGJFNLDKGO.Contains("action"))
		{
			this.FNJPKNFEFBM = HLDNEMHDEDH.LNLOHDKFDAA(OFGJFNLDKGO, "action(", ')', true);
		}
	}

	// Token: 0x06005CFD RID: 23805 RVA: 0x002A57AD File Offset: 0x002A39AD
	public override void FEHODJMIAJL(int OIMDDBOOAOB = 1)
	{
		if (!this.BBHDMMHCDKO())
		{
			this.BOPJOMGIJIA += OIMDDBOOAOB;
		}
	}

	// Token: 0x06005CFE RID: 23806 RVA: 0x002A57C5 File Offset: 0x002A39C5
	public override bool PINCOCDOOGH()
	{
		return this.BOPJOMGIJIA == DNFBGCGNLKA.BMHGEBOHLHH.waitForInput;
	}

	// Token: 0x06005CFF RID: 23807 RVA: 0x002A57D0 File Offset: 0x002A39D0
	public override bool FMLECLNJAJM()
	{
		return this.BOPJOMGIJIA == (DNFBGCGNLKA.BMHGEBOHLHH)this.KOIINMNNNDJ;
	}

	// Token: 0x04001AA0 RID: 6816
	public DNFBGCGNLKA.BMHGEBOHLHH BOPJOMGIJIA;

	// Token: 0x04001AA1 RID: 6817
	public string IDGJMPJDEAO;

	// Token: 0x04001AA2 RID: 6818
	public string OHIADAOPIIJ;

	// Token: 0x04001AA3 RID: 6819
	public string FNJPKNFEFBM;

	// Token: 0x020002FA RID: 762
	public enum BMHGEBOHLHH
	{
		// Token: 0x04001AA5 RID: 6821
		show,
		// Token: 0x04001AA6 RID: 6822
		showNote,
		// Token: 0x04001AA7 RID: 6823
		waitForInput,
		// Token: 0x04001AA8 RID: 6824
		executeItemCollected,
		// Token: 0x04001AA9 RID: 6825
		hide,
		// Token: 0x04001AAA RID: 6826
		done
	}
}
