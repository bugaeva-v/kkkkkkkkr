using System;

// Token: 0x0200009B RID: 155
public class DHADKGOGGOK : KGLBKJKNPFD
{
	// Token: 0x060015B3 RID: 5555 RVA: 0x0001FBB0 File Offset: 0x0001DDB0
	public override bool PINCOCDOOGH()
	{
		return false;
	}

	// Token: 0x060015B4 RID: 5556 RVA: 0x000A6A65 File Offset: 0x000A4C65
	public override void FEHODJMIAJL(int OIMDDBOOAOB = 1)
	{
		if (!this.BBHDMMHCDKO())
		{
			this.BOPJOMGIJIA += OIMDDBOOAOB;
		}
	}

	// Token: 0x060015B5 RID: 5557 RVA: 0x000A6A80 File Offset: 0x000A4C80
	public DHADKGOGGOK(string OFGJFNLDKGO)
	{
		this.OBKCKGHFMDN = KGLBKJKNPFD.LBFFMOMMAPK.stopVoiceOver;
		if (OFGJFNLDKGO.Contains("id"))
		{
			this.HCOFJONDHDE = HLDNEMHDEDH.LNLOHDKFDAA(OFGJFNLDKGO, "id(", ')', true);
		}
		if (OFGJFNLDKGO.Contains("time"))
		{
			this.PMMCLCMDNGA = HLDNEMHDEDH.NCIMIEAINEO(OFGJFNLDKGO, "time(", ')', true);
		}
		this.PMMCLCMDNGA *= AppManager.EHBBFMCILPC.debugSettings.OAEBOACHHOG(1f);
	}

	// Token: 0x060015B6 RID: 5558 RVA: 0x000A6B14 File Offset: 0x000A4D14
	public override string LDHNPOGPAOB()
	{
		return this.BOPJOMGIJIA.ToString();
	}

	// Token: 0x060015B7 RID: 5559 RVA: 0x000A6B27 File Offset: 0x000A4D27
	public override bool FMLECLNJAJM()
	{
		return this.BOPJOMGIJIA == (DHADKGOGGOK.BMHGEBOHLHH)this.KOIINMNNNDJ;
	}

	// Token: 0x060015B8 RID: 5560 RVA: 0x000A6B37 File Offset: 0x000A4D37
	public override bool BBHDMMHCDKO()
	{
		return this.BOPJOMGIJIA == DHADKGOGGOK.BMHGEBOHLHH.done;
	}

	// Token: 0x040006BA RID: 1722
	public string HCOFJONDHDE = "";

	// Token: 0x040006BB RID: 1723
	public float PMMCLCMDNGA = 1f;

	// Token: 0x040006BC RID: 1724
	public DHADKGOGGOK.BMHGEBOHLHH BOPJOMGIJIA;

	// Token: 0x0200009C RID: 156
	public enum BMHGEBOHLHH
	{
		// Token: 0x040006BE RID: 1726
		start,
		// Token: 0x040006BF RID: 1727
		done
	}
}
