using System;

// Token: 0x02000027 RID: 39
public class FLODDPAJCAP : KGLBKJKNPFD
{
	// Token: 0x060005D6 RID: 1494 RVA: 0x0002C4A1 File Offset: 0x0002A6A1
	public override bool BBHDMMHCDKO()
	{
		return this.BOPJOMGIJIA == FLODDPAJCAP.BMHGEBOHLHH.done;
	}

	// Token: 0x060005D7 RID: 1495 RVA: 0x0001FBB0 File Offset: 0x0001DDB0
	public override bool PINCOCDOOGH()
	{
		return false;
	}

	// Token: 0x060005D8 RID: 1496 RVA: 0x0002C4AC File Offset: 0x0002A6AC
	public FLODDPAJCAP(string OFGJFNLDKGO)
	{
		this.OBKCKGHFMDN = KGLBKJKNPFD.LBFFMOMMAPK.shakeScreen;
		this.PMMCLCMDNGA = HLDNEMHDEDH.NCIMIEAINEO(OFGJFNLDKGO, "time(", ')', true);
		this.PMMCLCMDNGA *= AppManager.EHBBFMCILPC.debugSettings.OAEBOACHHOG(1f);
		if (OFGJFNLDKGO.Contains("sfx"))
		{
			this.JLEAIJGBGHL = HLDNEMHDEDH.LNLOHDKFDAA(OFGJFNLDKGO, "sfx(", ')', true);
		}
		if (OFGJFNLDKGO.Contains("sfxloop"))
		{
			this.MHCAKNHEPDE = (HLDNEMHDEDH.OKNGPMCDBFE(OFGJFNLDKGO, "sfxloop(", ')', true) == 1);
		}
	}

	// Token: 0x060005D9 RID: 1497 RVA: 0x0002C557 File Offset: 0x0002A757
	public override bool FMLECLNJAJM()
	{
		return this.BOPJOMGIJIA == (FLODDPAJCAP.BMHGEBOHLHH)this.KOIINMNNNDJ;
	}

	// Token: 0x060005DA RID: 1498 RVA: 0x0002C567 File Offset: 0x0002A767
	public override string LDHNPOGPAOB()
	{
		return this.BOPJOMGIJIA.ToString();
	}

	// Token: 0x060005DB RID: 1499 RVA: 0x0002C57A File Offset: 0x0002A77A
	public override void FEHODJMIAJL(int OIMDDBOOAOB = 1)
	{
		if (!this.BBHDMMHCDKO())
		{
			this.BOPJOMGIJIA += OIMDDBOOAOB;
		}
	}

	// Token: 0x04000187 RID: 391
	public FLODDPAJCAP.BMHGEBOHLHH BOPJOMGIJIA;

	// Token: 0x04000188 RID: 392
	public float PMMCLCMDNGA = 1f;

	// Token: 0x04000189 RID: 393
	public string JLEAIJGBGHL = "";

	// Token: 0x0400018A RID: 394
	public bool MHCAKNHEPDE;

	// Token: 0x02000028 RID: 40
	public enum BMHGEBOHLHH
	{
		// Token: 0x0400018C RID: 396
		start,
		// Token: 0x0400018D RID: 397
		done
	}
}
