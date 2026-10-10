using System;

// Token: 0x020004D6 RID: 1238
public class IPJEBHDFOKM : KGLBKJKNPFD
{
	// Token: 0x06009553 RID: 38227 RVA: 0x00418C8B File Offset: 0x00416E8B
	public override void FEHODJMIAJL(int OIMDDBOOAOB = 1)
	{
		if (!this.BBHDMMHCDKO())
		{
			this.BOPJOMGIJIA += OIMDDBOOAOB;
		}
	}

	// Token: 0x06009554 RID: 38228 RVA: 0x00418CA4 File Offset: 0x00416EA4
	public IPJEBHDFOKM(string OFGJFNLDKGO)
	{
		this.OBKCKGHFMDN = KGLBKJKNPFD.LBFFMOMMAPK.showItem;
		this.IDGJMPJDEAO = HLDNEMHDEDH.LNLOHDKFDAA(OFGJFNLDKGO, "id(", ')', true);
		if (OFGJFNLDKGO.Contains("title"))
		{
			this.OHIADAOPIIJ = HLDNEMHDEDH.LNLOHDKFDAA(OFGJFNLDKGO, "title(", ')', true);
		}
		if (OFGJFNLDKGO.Contains("action"))
		{
			this.FNJPKNFEFBM = HLDNEMHDEDH.LNLOHDKFDAA(OFGJFNLDKGO, "action(", ')', true);
		}
		if (OFGJFNLDKGO.Contains("fullscreen"))
		{
			this.JHOBDDLPIBD = (HLDNEMHDEDH.OKNGPMCDBFE(OFGJFNLDKGO, "fullscreen(", ')', true) == 1);
		}
	}

	// Token: 0x06009555 RID: 38229 RVA: 0x00418D39 File Offset: 0x00416F39
	public override bool FMLECLNJAJM()
	{
		return this.BOPJOMGIJIA == (IPJEBHDFOKM.BMHGEBOHLHH)this.KOIINMNNNDJ;
	}

	// Token: 0x06009556 RID: 38230 RVA: 0x00418D49 File Offset: 0x00416F49
	public override bool PINCOCDOOGH()
	{
		return this.BOPJOMGIJIA == IPJEBHDFOKM.BMHGEBOHLHH.waitForInput;
	}

	// Token: 0x06009557 RID: 38231 RVA: 0x00418D54 File Offset: 0x00416F54
	public override bool BBHDMMHCDKO()
	{
		return this.BOPJOMGIJIA == IPJEBHDFOKM.BMHGEBOHLHH.done;
	}

	// Token: 0x06009558 RID: 38232 RVA: 0x00418D5F File Offset: 0x00416F5F
	public override string LDHNPOGPAOB()
	{
		return this.BOPJOMGIJIA.ToString();
	}

	// Token: 0x04002972 RID: 10610
	public IPJEBHDFOKM.BMHGEBOHLHH BOPJOMGIJIA;

	// Token: 0x04002973 RID: 10611
	public string IDGJMPJDEAO;

	// Token: 0x04002974 RID: 10612
	public string OHIADAOPIIJ;

	// Token: 0x04002975 RID: 10613
	public string FNJPKNFEFBM;

	// Token: 0x04002976 RID: 10614
	public bool JHOBDDLPIBD;

	// Token: 0x020004D7 RID: 1239
	public enum BMHGEBOHLHH
	{
		// Token: 0x04002978 RID: 10616
		show,
		// Token: 0x04002979 RID: 10617
		waitForInput,
		// Token: 0x0400297A RID: 10618
		executeItemShown,
		// Token: 0x0400297B RID: 10619
		hide,
		// Token: 0x0400297C RID: 10620
		done
	}
}
