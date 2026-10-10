using System;

// Token: 0x020003AB RID: 939
public class GANPAGHHNOD : KGLBKJKNPFD
{
	// Token: 0x06006DB2 RID: 28082 RVA: 0x00323B7D File Offset: 0x00321D7D
	public override bool BBHDMMHCDKO()
	{
		return this.BOPJOMGIJIA == GANPAGHHNOD.BMHGEBOHLHH.done;
	}

	// Token: 0x06006DB3 RID: 28083 RVA: 0x00323B88 File Offset: 0x00321D88
	public override string LDHNPOGPAOB()
	{
		return this.BOPJOMGIJIA.ToString();
	}

	// Token: 0x06006DB4 RID: 28084 RVA: 0x00323B9B File Offset: 0x00321D9B
	public override bool PINCOCDOOGH()
	{
		return this.BOPJOMGIJIA == GANPAGHHNOD.BMHGEBOHLHH.waitForInput;
	}

	// Token: 0x06006DB5 RID: 28085 RVA: 0x00323BA6 File Offset: 0x00321DA6
	public override void FEHODJMIAJL(int OIMDDBOOAOB = 1)
	{
		if (!this.BBHDMMHCDKO())
		{
			this.BOPJOMGIJIA += OIMDDBOOAOB;
		}
	}

	// Token: 0x06006DB6 RID: 28086 RVA: 0x00323BBE File Offset: 0x00321DBE
	public override bool FMLECLNJAJM()
	{
		return this.BOPJOMGIJIA == (GANPAGHHNOD.BMHGEBOHLHH)this.KOIINMNNNDJ;
	}

	// Token: 0x06006DB7 RID: 28087 RVA: 0x00323BD0 File Offset: 0x00321DD0
	public GANPAGHHNOD(string OFGJFNLDKGO)
	{
		this.OBKCKGHFMDN = KGLBKJKNPFD.LBFFMOMMAPK.useItem;
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

	// Token: 0x040020A2 RID: 8354
	public GANPAGHHNOD.BMHGEBOHLHH BOPJOMGIJIA;

	// Token: 0x040020A3 RID: 8355
	public string IDGJMPJDEAO;

	// Token: 0x040020A4 RID: 8356
	public string OHIADAOPIIJ;

	// Token: 0x040020A5 RID: 8357
	public string FNJPKNFEFBM;

	// Token: 0x020003AC RID: 940
	public enum BMHGEBOHLHH
	{
		// Token: 0x040020A7 RID: 8359
		show,
		// Token: 0x040020A8 RID: 8360
		waitForInput,
		// Token: 0x040020A9 RID: 8361
		executeItemUsed,
		// Token: 0x040020AA RID: 8362
		hide,
		// Token: 0x040020AB RID: 8363
		done
	}
}
