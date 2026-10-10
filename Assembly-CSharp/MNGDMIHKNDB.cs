using System;

// Token: 0x02000501 RID: 1281
public class MNGDMIHKNDB : KGLBKJKNPFD
{
	// Token: 0x06009AB6 RID: 39606 RVA: 0x0042BC68 File Offset: 0x00429E68
	public MNGDMIHKNDB(string OFGJFNLDKGO)
	{
		this.OBKCKGHFMDN = KGLBKJKNPFD.LBFFMOMMAPK.saveCutscene;
		if (OFGJFNLDKGO.Contains("id"))
		{
			this.IBFLNCMCKAL = HLDNEMHDEDH.LNLOHDKFDAA(OFGJFNLDKGO, "id(", ')', true);
		}
		if (OFGJFNLDKGO.Contains("mus"))
		{
			this.KPPJINFHMIP = HLDNEMHDEDH.LNLOHDKFDAA(OFGJFNLDKGO, "mus(", ')', true);
		}
		if (OFGJFNLDKGO.Contains("sfx"))
		{
			this.JLEAIJGBGHL = HLDNEMHDEDH.LNLOHDKFDAA(OFGJFNLDKGO, "sfx(", ')', true);
		}
		if (OFGJFNLDKGO.Contains("variant"))
		{
			this.LBINCCHCHII = HLDNEMHDEDH.OKNGPMCDBFE(OFGJFNLDKGO, "variant(", ')', true);
		}
		if (OFGJFNLDKGO.Contains("pos"))
		{
			this.NLAPFLNBDLC = StoryEnvironmentManager.StringToStoryEnvironmentPosition(HLDNEMHDEDH.LNLOHDKFDAA(OFGJFNLDKGO, "pos(", ')', true));
		}
		if (OFGJFNLDKGO.Contains("moveto"))
		{
			this.DBIEKGOEKKH = StoryEnvironmentManager.StringToStoryEnvironmentPosition(HLDNEMHDEDH.LNLOHDKFDAA(OFGJFNLDKGO, "moveto(", ')', true));
		}
		if (OFGJFNLDKGO.Contains("posv"))
		{
			this.BIBACLNGIOD = StoryEnvironmentManager.StringToStoryEnvironmentPositionVertical(HLDNEMHDEDH.LNLOHDKFDAA(OFGJFNLDKGO, "posv(", ')', true));
		}
		if (OFGJFNLDKGO.Contains("movetov"))
		{
			this.OOLMNPHJOFA = StoryEnvironmentManager.StringToStoryEnvironmentPositionVertical(HLDNEMHDEDH.LNLOHDKFDAA(OFGJFNLDKGO, "movetov(", ')', true));
		}
	}

	// Token: 0x06009AB7 RID: 39607 RVA: 0x0042BDE3 File Offset: 0x00429FE3
	public string PAFCNHPGFBH(string ICAHJJBAEHB)
	{
		if (this.LBINCCHCHII >= 1)
		{
			return ICAHJJBAEHB + "</i>" + this.LBINCCHCHII.ToString();
		}
		return ICAHJJBAEHB;
	}

	// Token: 0x06009AB8 RID: 39608 RVA: 0x0001FBB0 File Offset: 0x0001DDB0
	public override bool PINCOCDOOGH()
	{
		return false;
	}

	// Token: 0x06009AB9 RID: 39609 RVA: 0x0042BE06 File Offset: 0x0042A006
	public string HDNANBADJFE(string ICAHJJBAEHB)
	{
		if (this.LBINCCHCHII >= 1)
		{
			return ICAHJJBAEHB + "layer" + this.LBINCCHCHII.ToString();
		}
		return ICAHJJBAEHB;
	}

	// Token: 0x06009ABA RID: 39610 RVA: 0x0042BE29 File Offset: 0x0042A029
	public string CKHELCGFCDF(string ICAHJJBAEHB)
	{
		if (this.LBINCCHCHII >= 1)
		{
			return ICAHJJBAEHB + "x$" + this.LBINCCHCHII.ToString();
		}
		return ICAHJJBAEHB;
	}

	// Token: 0x06009ABB RID: 39611 RVA: 0x0042BE4C File Offset: 0x0042A04C
	public string DMBEDFBELKO(string ICAHJJBAEHB)
	{
		if (this.LBINCCHCHII >= 1)
		{
			return ICAHJJBAEHB + "ok" + this.LBINCCHCHII.ToString();
		}
		return ICAHJJBAEHB;
	}

	// Token: 0x06009ABC RID: 39612 RVA: 0x0042BE6F File Offset: 0x0042A06F
	public override bool BBHDMMHCDKO()
	{
		return this.BOPJOMGIJIA == MNGDMIHKNDB.BMHGEBOHLHH.done;
	}

	// Token: 0x06009ABD RID: 39613 RVA: 0x0042BE7A File Offset: 0x0042A07A
	public string CCBDJEIALKP(string ICAHJJBAEHB)
	{
		if (this.LBINCCHCHII >= 0)
		{
			return ICAHJJBAEHB + "importanttitle" + this.LBINCCHCHII.ToString();
		}
		return ICAHJJBAEHB;
	}

	// Token: 0x06009ABE RID: 39614 RVA: 0x0042BE9D File Offset: 0x0042A09D
	public string GGFEIFCJLCF(string ICAHJJBAEHB)
	{
		if (this.LBINCCHCHII >= 0)
		{
			return ICAHJJBAEHB + "Critical error, could not load asset bundle:" + this.LBINCCHCHII.ToString();
		}
		return ICAHJJBAEHB;
	}

	// Token: 0x06009ABF RID: 39615 RVA: 0x0042BEC0 File Offset: 0x0042A0C0
	public override bool FMLECLNJAJM()
	{
		return this.BOPJOMGIJIA == (MNGDMIHKNDB.BMHGEBOHLHH)this.KOIINMNNNDJ;
	}

	// Token: 0x06009AC0 RID: 39616 RVA: 0x0042BED0 File Offset: 0x0042A0D0
	public string PBCNMHPNALA(string ICAHJJBAEHB)
	{
		if (this.LBINCCHCHII >= 1)
		{
			return ICAHJJBAEHB + ", " + this.LBINCCHCHII.ToString();
		}
		return ICAHJJBAEHB;
	}

	// Token: 0x06009AC1 RID: 39617 RVA: 0x0042BEF3 File Offset: 0x0042A0F3
	public string EFCOEEJBKNF(string ICAHJJBAEHB)
	{
		if (this.LBINCCHCHII >= 1)
		{
			return ICAHJJBAEHB + "PurchaseManagerUnity.OnPurchaseFailed(): Could not find product in failed order." + this.LBINCCHCHII.ToString();
		}
		return ICAHJJBAEHB;
	}

	// Token: 0x06009AC2 RID: 39618 RVA: 0x0042BF16 File Offset: 0x0042A116
	public string LEDCPMOMAJH(string ICAHJJBAEHB)
	{
		if (this.LBINCCHCHII >= 0)
		{
			return ICAHJJBAEHB + "@" + this.LBINCCHCHII.ToString();
		}
		return ICAHJJBAEHB;
	}

	// Token: 0x06009AC3 RID: 39619 RVA: 0x0042BED0 File Offset: 0x0042A0D0
	public string JLACJHCFNAB(string ICAHJJBAEHB)
	{
		if (this.LBINCCHCHII >= 1)
		{
			return ICAHJJBAEHB + ", " + this.LBINCCHCHII.ToString();
		}
		return ICAHJJBAEHB;
	}

	// Token: 0x06009AC4 RID: 39620 RVA: 0x0042BF39 File Offset: 0x0042A139
	public override void FEHODJMIAJL(int OIMDDBOOAOB = 1)
	{
		if (!this.BBHDMMHCDKO())
		{
			this.BOPJOMGIJIA += OIMDDBOOAOB;
		}
	}

	// Token: 0x06009AC5 RID: 39621 RVA: 0x0042BF51 File Offset: 0x0042A151
	public string IONEDCFBEMM(string ICAHJJBAEHB)
	{
		if (this.LBINCCHCHII >= 1)
		{
			return ICAHJJBAEHB + "chaptersnapshotssubrequiredtitle" + this.LBINCCHCHII.ToString();
		}
		return ICAHJJBAEHB;
	}

	// Token: 0x06009AC6 RID: 39622 RVA: 0x0042BF74 File Offset: 0x0042A174
	public string OHFLBJGOAOO(string ICAHJJBAEHB)
	{
		if (this.LBINCCHCHII >= 0)
		{
			return ICAHJJBAEHB + "+" + this.LBINCCHCHII.ToString();
		}
		return ICAHJJBAEHB;
	}

	// Token: 0x06009AC7 RID: 39623 RVA: 0x0042BF97 File Offset: 0x0042A197
	public string JGPKLGBHHEE(string ICAHJJBAEHB)
	{
		if (this.LBINCCHCHII >= 1)
		{
			return ICAHJJBAEHB + "per" + this.LBINCCHCHII.ToString();
		}
		return ICAHJJBAEHB;
	}

	// Token: 0x06009AC8 RID: 39624 RVA: 0x0042BFBA File Offset: 0x0042A1BA
	public override string LDHNPOGPAOB()
	{
		return this.BOPJOMGIJIA.ToString();
	}

	// Token: 0x06009AC9 RID: 39625 RVA: 0x0042BFCD File Offset: 0x0042A1CD
	public string OLHDGGHNCDG(string ICAHJJBAEHB)
	{
		if (this.LBINCCHCHII >= 1)
		{
			return ICAHJJBAEHB + "XXX" + this.LBINCCHCHII.ToString();
		}
		return ICAHJJBAEHB;
	}

	// Token: 0x06009ACA RID: 39626 RVA: 0x0042BFF0 File Offset: 0x0042A1F0
	public string HOBDHFKAACN(string ICAHJJBAEHB)
	{
		if (this.LBINCCHCHII >= 0)
		{
			return ICAHJJBAEHB + "\n\n" + this.LBINCCHCHII.ToString();
		}
		return ICAHJJBAEHB;
	}

	// Token: 0x06009ACB RID: 39627 RVA: 0x0042C013 File Offset: 0x0042A213
	public string PJBFHADJCBL(string ICAHJJBAEHB)
	{
		if (this.LBINCCHCHII >= 0)
		{
			return ICAHJJBAEHB + "AssetProfileData.GetCharSprite(): anthologyIndex (" + this.LBINCCHCHII.ToString();
		}
		return ICAHJJBAEHB;
	}

	// Token: 0x06009ACC RID: 39628 RVA: 0x0042C036 File Offset: 0x0042A236
	public string EHOFIANKFIO(string ICAHJJBAEHB)
	{
		if (this.LBINCCHCHII >= 1)
		{
			return ICAHJJBAEHB + "[STACKTRACE] " + this.LBINCCHCHII.ToString();
		}
		return ICAHJJBAEHB;
	}

	// Token: 0x06009ACD RID: 39629 RVA: 0x0042C059 File Offset: 0x0042A259
	public string JGMCNIIMONM(string ICAHJJBAEHB)
	{
		if (this.LBINCCHCHII >= 1)
		{
			return ICAHJJBAEHB + "" + this.LBINCCHCHII.ToString();
		}
		return ICAHJJBAEHB;
	}

	// Token: 0x06009ACE RID: 39630 RVA: 0x0042C07C File Offset: 0x0042A27C
	public string PDHHENKLGDF(string ICAHJJBAEHB)
	{
		if (this.LBINCCHCHII >= 0)
		{
			return ICAHJJBAEHB + "sslt" + this.LBINCCHCHII.ToString();
		}
		return ICAHJJBAEHB;
	}

	// Token: 0x06009ACF RID: 39631 RVA: 0x0042C09F File Offset: 0x0042A29F
	public string MDNGGBAOJLG(string ICAHJJBAEHB)
	{
		if (this.LBINCCHCHII >= 0)
		{
			return ICAHJJBAEHB + "/" + this.LBINCCHCHII.ToString();
		}
		return ICAHJJBAEHB;
	}

	// Token: 0x06009AD0 RID: 39632 RVA: 0x0042C0C2 File Offset: 0x0042A2C2
	public string AADPJACGFMH(string ICAHJJBAEHB)
	{
		if (this.LBINCCHCHII >= 1)
		{
			return ICAHJJBAEHB + "OnPopupCardOptionsUnlockWithSpSuccessContinue" + this.LBINCCHCHII.ToString();
		}
		return ICAHJJBAEHB;
	}

	// Token: 0x04002AB3 RID: 10931
	public MNGDMIHKNDB.BMHGEBOHLHH BOPJOMGIJIA;

	// Token: 0x04002AB4 RID: 10932
	public string IBFLNCMCKAL = "";

	// Token: 0x04002AB5 RID: 10933
	public string KPPJINFHMIP = "";

	// Token: 0x04002AB6 RID: 10934
	public string JLEAIJGBGHL = "";

	// Token: 0x04002AB7 RID: 10935
	public int LBINCCHCHII = -1;

	// Token: 0x04002AB8 RID: 10936
	public FCABOFEGPGP NLAPFLNBDLC = FCABOFEGPGP.center;

	// Token: 0x04002AB9 RID: 10937
	public FCABOFEGPGP DBIEKGOEKKH = FCABOFEGPGP.center;

	// Token: 0x04002ABA RID: 10938
	public PHALBCMBPPL BIBACLNGIOD = PHALBCMBPPL.center;

	// Token: 0x04002ABB RID: 10939
	public PHALBCMBPPL OOLMNPHJOFA = PHALBCMBPPL.center;

	// Token: 0x04002ABC RID: 10940
	public int APCKKMLICMN;

	// Token: 0x02000502 RID: 1282
	public enum BMHGEBOHLHH
	{
		// Token: 0x04002ABE RID: 10942
		start,
		// Token: 0x04002ABF RID: 10943
		done
	}
}
