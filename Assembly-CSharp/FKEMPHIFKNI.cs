using System;

// Token: 0x020004E7 RID: 1255
public class FKEMPHIFKNI : KGLBKJKNPFD
{
	// Token: 0x060097AA RID: 38826 RVA: 0x00420F95 File Offset: 0x0041F195
	public override bool BBHDMMHCDKO()
	{
		return this.BOPJOMGIJIA == FKEMPHIFKNI.BMHGEBOHLHH.done;
	}

	// Token: 0x060097AB RID: 38827 RVA: 0x00420FA0 File Offset: 0x0041F1A0
	public override void FEHODJMIAJL(int OIMDDBOOAOB = 1)
	{
		if (!this.BBHDMMHCDKO())
		{
			this.BOPJOMGIJIA += OIMDDBOOAOB;
		}
	}

	// Token: 0x060097AC RID: 38828 RVA: 0x00420FB8 File Offset: 0x0041F1B8
	public FKEMPHIFKNI(string OFGJFNLDKGO)
	{
		this.OBKCKGHFMDN = KGLBKJKNPFD.LBFFMOMMAPK.incStat;
		this.JONCLHNEMIO = HLDNEMHDEDH.FBEENKPOEFM(HLDNEMHDEDH.LNLOHDKFDAA(OFGJFNLDKGO, "type(", ')', true));
		this.IHMKJMPEPHK = HLDNEMHDEDH.LNLOHDKFDAA(OFGJFNLDKGO, "value(", ')', true);
		this.AJLPALFJHCC = 0;
		if (this.IHMKJMPEPHK != null && this.IHMKJMPEPHK.Length > 0)
		{
			if (DPGJIJGOCIC.EHHONNJHMLO(this.IHMKJMPEPHK))
			{
				this.AJLPALFJHCC = HLDNEMHDEDH.OKNGPMCDBFE(OFGJFNLDKGO, "value(", ')', true);
				this.IHMKJMPEPHK = "";
			}
		}
		else
		{
			this.IHMKJMPEPHK = "";
		}
		if (OFGJFNLDKGO.Contains("id"))
		{
			this.HNIFEKBNNDB = HLDNEMHDEDH.LNLOHDKFDAA(OFGJFNLDKGO, "id(", ')', true);
		}
	}

	// Token: 0x060097AD RID: 38829 RVA: 0x00421082 File Offset: 0x0041F282
	public override bool FMLECLNJAJM()
	{
		return this.BOPJOMGIJIA == (FKEMPHIFKNI.BMHGEBOHLHH)this.KOIINMNNNDJ;
	}

	// Token: 0x060097AE RID: 38830 RVA: 0x00421092 File Offset: 0x0041F292
	public override string LDHNPOGPAOB()
	{
		return this.BOPJOMGIJIA.ToString();
	}

	// Token: 0x060097AF RID: 38831 RVA: 0x0001FBB0 File Offset: 0x0001DDB0
	public override bool PINCOCDOOGH()
	{
		return false;
	}

	// Token: 0x040029D4 RID: 10708
	public CHEEGEJNIDB JONCLHNEMIO;

	// Token: 0x040029D5 RID: 10709
	public int AJLPALFJHCC;

	// Token: 0x040029D6 RID: 10710
	public string IHMKJMPEPHK;

	// Token: 0x040029D7 RID: 10711
	public string HNIFEKBNNDB = "";

	// Token: 0x040029D8 RID: 10712
	public FKEMPHIFKNI.BMHGEBOHLHH BOPJOMGIJIA;

	// Token: 0x020004E8 RID: 1256
	public enum BMHGEBOHLHH
	{
		// Token: 0x040029DA RID: 10714
		show,
		// Token: 0x040029DB RID: 10715
		instantiateDelay,
		// Token: 0x040029DC RID: 10716
		instantiate,
		// Token: 0x040029DD RID: 10717
		delayBeforeHide,
		// Token: 0x040029DE RID: 10718
		hide,
		// Token: 0x040029DF RID: 10719
		done
	}
}
