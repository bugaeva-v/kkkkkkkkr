using System;

// Token: 0x020002CA RID: 714
public class CKBCHMOAKLK : KGLBKJKNPFD
{
	// Token: 0x060058F4 RID: 22772 RVA: 0x002823BC File Offset: 0x002805BC
	public override void FEHODJMIAJL(int OIMDDBOOAOB = 1)
	{
		if (!this.BBHDMMHCDKO())
		{
			this.BOPJOMGIJIA += OIMDDBOOAOB;
		}
	}

	// Token: 0x060058F5 RID: 22773 RVA: 0x0001FBB0 File Offset: 0x0001DDB0
	public override bool PINCOCDOOGH()
	{
		return false;
	}

	// Token: 0x060058F6 RID: 22774 RVA: 0x002823D4 File Offset: 0x002805D4
	public override string LDHNPOGPAOB()
	{
		return this.BOPJOMGIJIA.ToString();
	}

	// Token: 0x060058F7 RID: 22775 RVA: 0x002823E7 File Offset: 0x002805E7
	public override bool BBHDMMHCDKO()
	{
		return this.BOPJOMGIJIA == CKBCHMOAKLK.BMHGEBOHLHH.done;
	}

	// Token: 0x060058F8 RID: 22776 RVA: 0x002823F2 File Offset: 0x002805F2
	public override bool FMLECLNJAJM()
	{
		return this.BOPJOMGIJIA == (CKBCHMOAKLK.BMHGEBOHLHH)this.KOIINMNNNDJ;
	}

	// Token: 0x060058F9 RID: 22777 RVA: 0x00282404 File Offset: 0x00280604
	public CKBCHMOAKLK(string OFGJFNLDKGO)
	{
		this.OBKCKGHFMDN = KGLBKJKNPFD.LBFFMOMMAPK.chatOpen;
		this.APJLHOCPOEO = OFGJFNLDKGO;
		if (OFGJFNLDKGO.Contains("session"))
		{
			this.IMBBIDKPOBM = HLDNEMHDEDH.LNLOHDKFDAA(OFGJFNLDKGO, "session(", ')', true);
		}
		if (this.IMBBIDKPOBM.Length == 0)
		{
			this.IMBBIDKPOBM = DPGJIJGOCIC.IJNFOHCDGKD(5);
			return;
		}
		if (OFGJFNLDKGO.Contains("persistent"))
		{
			this.FPHDAKHOBMO = (HLDNEMHDEDH.OKNGPMCDBFE(OFGJFNLDKGO, "persistent(", ')', true) == 1);
		}
	}

	// Token: 0x0400191A RID: 6426
	public CKBCHMOAKLK.BMHGEBOHLHH BOPJOMGIJIA;

	// Token: 0x0400191B RID: 6427
	public string IMBBIDKPOBM = "";

	// Token: 0x0400191C RID: 6428
	public bool FPHDAKHOBMO;

	// Token: 0x0400191D RID: 6429
	public string APJLHOCPOEO = "";

	// Token: 0x020002CB RID: 715
	public enum BMHGEBOHLHH
	{
		// Token: 0x0400191F RID: 6431
		start,
		// Token: 0x04001920 RID: 6432
		done
	}
}
