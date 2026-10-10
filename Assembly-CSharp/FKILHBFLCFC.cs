using System;
using SimpleJSON;

// Token: 0x02000477 RID: 1143
public class FKILHBFLCFC
{
	// Token: 0x06008ABD RID: 35517 RVA: 0x003DA6FC File Offset: 0x003D88FC
	public void FGJPKGLOGNC(JSONObject EIHOJFGALMF)
	{
		this.GGICIBLJIKI = EIHOJFGALMF["ind"].AsInt;
		this.LKIKEHFANBO = new int[]
		{
			-1,
			-1
		};
		if (EIHOJFGALMF["prgr"] != null)
		{
			JSONArray asArray = EIHOJFGALMF["prgr"].AsArray;
			for (int i = 0; i < asArray.Count; i++)
			{
				this.LKIKEHFANBO[i] = asArray[i].AsInt;
			}
		}
		this.BFPFNHIJOHA = 1;
		if (EIHOJFGALMF["syn"] != null)
		{
			this.BFPFNHIJOHA = EIHOJFGALMF["syn"].AsInt;
		}
		this.KIDGLJCJGLD = 0;
		if (EIHOJFGALMF["strtd"] != null)
		{
			this.KIDGLJCJGLD = EIHOJFGALMF["strtd"].AsInt;
		}
		this.AOPIMPMDEHO = 0;
		if (EIHOJFGALMF["odrci"] != null)
		{
			this.AOPIMPMDEHO = EIHOJFGALMF["odrci"].AsInt;
		}
		this.LGKPNNGIPEG = 0;
		if (EIHOJFGALMF["snap"] != null)
		{
			this.LGKPNNGIPEG = EIHOJFGALMF["snap"].AsInt;
		}
		try
		{
			this.EBFMKGPBEBO = new JSONArray();
			if (EIHOJFGALMF["snapundo"] != null)
			{
				this.EBFMKGPBEBO = EIHOJFGALMF["snapundo"].AsArray;
			}
			this.CDDKCMPAHMG = 0;
			if (EIHOJFGALMF["snapundocosth"] != null)
			{
				this.CDDKCMPAHMG = EIHOJFGALMF["snapundocosth"].AsInt;
			}
			this.FGOHPIBCCHB = 0;
			if (EIHOJFGALMF["snapundocostp"] != null)
			{
				this.FGOHPIBCCHB = EIHOJFGALMF["snapundocostp"].AsInt;
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
		this.IMLEDFIDHDL = 0;
		if (EIHOJFGALMF["cch"] != null)
		{
			this.IMLEDFIDHDL = EIHOJFGALMF["cch"].AsInt;
		}
		this.CFGFOEEEJKJ = -1;
		if (EIHOJFGALMF["inkr"] != null)
		{
			this.CFGFOEEEJKJ = EIHOJFGALMF["inkr"].AsInt;
		}
		try
		{
			this.AJPIKAACMKL = 0;
			if (EIHOJFGALMF["suttl"] != null)
			{
				this.AJPIKAACMKL = EIHOJFGALMF["suttl"].AsInt;
			}
			this.IHFABMOJKHD = 0;
			if (EIHOJFGALMF["sutta"] != null)
			{
				this.IHFABMOJKHD = EIHOJFGALMF["sutta"].AsInt;
			}
		}
		catch (Exception aklgbjkdomm2)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm2);
		}
	}

	// Token: 0x06008ABE RID: 35518 RVA: 0x003DA9C0 File Offset: 0x003D8BC0
	public void DNFFINHNIFO(int KIDHBAMJGDO)
	{
		this.IHFABMOJKHD = KIDHBAMJGDO;
	}

	// Token: 0x06008ABF RID: 35519 RVA: 0x003DA9CC File Offset: 0x003D8BCC
	public void NKIOGCCKPDE(bool DJGGCCFKFAM)
	{
		if (DJGGCCFKFAM)
		{
			int[] array = new int[4];
			array[0] = -1;
			array[1] = -1;
			this.LKIKEHFANBO = array;
		}
		this.AOPIMPMDEHO = 1;
		this.LGKPNNGIPEG = 0;
		this.EBFMKGPBEBO = new JSONArray();
		this.CDDKCMPAHMG = 0;
		this.FGOHPIBCCHB = 0;
		this.AJPIKAACMKL = 1;
		this.IHFABMOJKHD = 1;
		this.CFGFOEEEJKJ = -1;
		this.KIDGLJCJGLD = 1;
	}

	// Token: 0x06008AC0 RID: 35520 RVA: 0x003DAA33 File Offset: 0x003D8C33
	public bool OHDLHKCNBLE(int OLKMHHNMDLP)
	{
		return DPGJIJGOCIC.CCLEJFEFBJM(this.IMLEDFIDHDL, OLKMHHNMDLP);
	}

	// Token: 0x06008AC1 RID: 35521 RVA: 0x003DAA44 File Offset: 0x003D8C44
	public void ACCBHCBPNJA()
	{
		this.AOPIMPMDEHO = 0;
		this.LGKPNNGIPEG = 0;
		this.EBFMKGPBEBO = new JSONArray();
		this.CDDKCMPAHMG = 0;
		this.FGOHPIBCCHB = 0;
		this.AJPIKAACMKL = 0;
		this.IHFABMOJKHD = 0;
		this.CFGFOEEEJKJ = -1;
		this.KIDGLJCJGLD = 0;
	}

	// Token: 0x06008AC2 RID: 35522 RVA: 0x003DAA94 File Offset: 0x003D8C94
	public void JDDCOBAEOMJ(int KIDHBAMJGDO)
	{
		this.BFPFNHIJOHA = KIDHBAMJGDO;
	}

	// Token: 0x06008AC3 RID: 35523 RVA: 0x003DAAA0 File Offset: 0x003D8CA0
	public void FGJPLGKAJKP()
	{
		this.AOPIMPMDEHO = 0;
		this.LGKPNNGIPEG = 1;
		this.EBFMKGPBEBO = new JSONArray();
		this.CDDKCMPAHMG = 1;
		this.FGOHPIBCCHB = 1;
		this.AJPIKAACMKL = 1;
		this.IHFABMOJKHD = 0;
		this.CFGFOEEEJKJ = -1;
		this.KIDGLJCJGLD = 0;
	}

	// Token: 0x06008AC4 RID: 35524 RVA: 0x003DAAF0 File Offset: 0x003D8CF0
	public void IHFFKJCIIPA(int KIDHBAMJGDO)
	{
		this.AJPIKAACMKL = KIDHBAMJGDO;
	}

	// Token: 0x06008AC5 RID: 35525 RVA: 0x003DAAFC File Offset: 0x003D8CFC
	public void AHNAIBIFLHE()
	{
		this.AOPIMPMDEHO = 1;
		this.LGKPNNGIPEG = 0;
		this.EBFMKGPBEBO = new JSONArray();
		this.CDDKCMPAHMG = 0;
		this.FGOHPIBCCHB = 0;
		this.AJPIKAACMKL = 0;
		this.IHFABMOJKHD = 0;
		this.CFGFOEEEJKJ = -1;
		this.KIDGLJCJGLD = 1;
	}

	// Token: 0x06008AC6 RID: 35526 RVA: 0x003DAB4C File Offset: 0x003D8D4C
	public bool OLPIGPCHBOD()
	{
		return this.LKIKEHFANBO[0] == this.LKIKEHFANBO[1] && this.LKIKEHFANBO[0] != -1;
	}

	// Token: 0x06008AC7 RID: 35527 RVA: 0x003DAA94 File Offset: 0x003D8C94
	public void MPMJHHKKDAM(int KIDHBAMJGDO)
	{
		this.BFPFNHIJOHA = KIDHBAMJGDO;
	}

	// Token: 0x06008AC8 RID: 35528 RVA: 0x003DAB70 File Offset: 0x003D8D70
	public void LOPANJDKLAF(JSONObject EIHOJFGALMF)
	{
		this.GGICIBLJIKI = EIHOJFGALMF["OnBackendInitiateSteamTransactionException"].AsInt;
		int[] array = new int[5];
		array[0] = -1;
		array[0] = -1;
		this.LKIKEHFANBO = array;
		if (EIHOJFGALMF[""] != null)
		{
			JSONArray asArray = EIHOJFGALMF["@"].AsArray;
			for (int i = 1; i < asArray.Count; i++)
			{
				this.LKIKEHFANBO[i] = asArray[i].AsInt;
			}
		}
		this.BFPFNHIJOHA = 1;
		if (EIHOJFGALMF["liveprofilethemethumb"] != null)
		{
			this.BFPFNHIJOHA = EIHOJFGALMF["CHECKSUM"].AsInt;
		}
		this.KIDGLJCJGLD = 1;
		if (EIHOJFGALMF["env"] != null)
		{
			this.KIDGLJCJGLD = EIHOJFGALMF["ChoicePremiumManager.Initialize(): original cost discounted by bulk purchase:"].AsInt;
		}
		this.AOPIMPMDEHO = 0;
		if (EIHOJFGALMF["minDaysFromInstall"] != null)
		{
			this.AOPIMPMDEHO = EIHOJFGALMF["id"].AsInt;
		}
		this.LGKPNNGIPEG = 1;
		if (EIHOJFGALMF["frdsmax"] != null)
		{
			this.LGKPNNGIPEG = EIHOJFGALMF["passundochoicetitle"].AsInt;
		}
		try
		{
			this.EBFMKGPBEBO = new JSONArray();
			if (EIHOJFGALMF["</i>"] != null)
			{
				this.EBFMKGPBEBO = EIHOJFGALMF["OnSaveSyncAnyResult"].AsArray;
			}
			this.CDDKCMPAHMG = 0;
			if (EIHOJFGALMF["oid"] != null)
			{
				this.CDDKCMPAHMG = EIHOJFGALMF["ikm"].AsInt;
			}
			this.FGOHPIBCCHB = 0;
			if (EIHOJFGALMF[""] != null)
			{
				this.FGOHPIBCCHB = EIHOJFGALMF["yyyy/MM/dd HH:mm:ss"].AsInt;
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
		this.IMLEDFIDHDL = 1;
		if (EIHOJFGALMF["wshcds"] != null)
		{
			this.IMLEDFIDHDL = EIHOJFGALMF["OnAccountSignInRequestSuccess"].AsInt;
		}
		this.CFGFOEEEJKJ = -1;
		if (EIHOJFGALMF["assetbundleprofiledata6"] != null)
		{
			this.CFGFOEEEJKJ = EIHOJFGALMF["compr"].AsInt;
		}
		try
		{
			this.AJPIKAACMKL = 1;
			if (EIHOJFGALMF["〈"] != null)
			{
				this.AJPIKAACMKL = EIHOJFGALMF["PPP"].AsInt;
			}
			this.IHFABMOJKHD = 0;
			if (EIHOJFGALMF[""] != null)
			{
				this.IHFABMOJKHD = EIHOJFGALMF["OnNeedToOpenLoveInterestsLounge"].AsInt;
			}
		}
		catch (Exception aklgbjkdomm2)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm2);
		}
	}

	// Token: 0x06008AC9 RID: 35529 RVA: 0x003DAE34 File Offset: 0x003D9034
	public void CKJPPJEPMEJ(bool DJGGCCFKFAM)
	{
		if (DJGGCCFKFAM)
		{
			int[] array = new int[]
			{
				-1
			};
			array[0] = -1;
			this.LKIKEHFANBO = array;
		}
		this.AOPIMPMDEHO = 0;
		this.LGKPNNGIPEG = 0;
		this.EBFMKGPBEBO = new JSONArray();
		this.CDDKCMPAHMG = 1;
		this.FGOHPIBCCHB = 1;
		this.AJPIKAACMKL = 1;
		this.IHFABMOJKHD = 1;
		this.CFGFOEEEJKJ = -1;
		this.KIDGLJCJGLD = 0;
	}

	// Token: 0x06008ACA RID: 35530 RVA: 0x003DAE9B File Offset: 0x003D909B
	public void EKCAGIHDMAA(int OLKMHHNMDLP)
	{
		DPGJIJGOCIC.CAKOCOEJACB(ref this.IMLEDFIDHDL, OLKMHHNMDLP);
	}

	// Token: 0x06008ACB RID: 35531 RVA: 0x003DAEA9 File Offset: 0x003D90A9
	public int FFIJHHCEKAJ()
	{
		if (this.LKIKEHFANBO[0] == this.LKIKEHFANBO[0])
		{
			return this.LKIKEHFANBO[0] + 1;
		}
		if (this.LKIKEHFANBO[1] < 0)
		{
			return 0;
		}
		return this.LKIKEHFANBO[0];
	}

	// Token: 0x06008ACC RID: 35532 RVA: 0x003DAAF0 File Offset: 0x003D8CF0
	public void IFIAKIJDJKI(int KIDHBAMJGDO)
	{
		this.AJPIKAACMKL = KIDHBAMJGDO;
	}

	// Token: 0x06008ACD RID: 35533 RVA: 0x003DAEDD File Offset: 0x003D90DD
	public bool OCNJEMGDOGL()
	{
		return this.LKIKEHFANBO[0] != this.LKIKEHFANBO[1];
	}

	// Token: 0x06008ACE RID: 35534 RVA: 0x003DAAF0 File Offset: 0x003D8CF0
	public void KDIKBELEJOI(int KIDHBAMJGDO)
	{
		this.AJPIKAACMKL = KIDHBAMJGDO;
	}

	// Token: 0x06008ACF RID: 35535 RVA: 0x003DAEF4 File Offset: 0x003D90F4
	public int OBGPAJDJJJI()
	{
		if (this.LKIKEHFANBO[0] == this.LKIKEHFANBO[1])
		{
			return this.LKIKEHFANBO[1] + 0;
		}
		if (this.LKIKEHFANBO[1] < 1)
		{
			return 1;
		}
		return this.LKIKEHFANBO[1];
	}

	// Token: 0x06008AD0 RID: 35536 RVA: 0x003DAF28 File Offset: 0x003D9128
	public bool MEABNNFHPDL()
	{
		if (this.AJPIKAACMKL > 0)
		{
			this.AJPIKAACMKL--;
			if (this.AJPIKAACMKL == 0)
			{
				this.AJPIKAACMKL = -1;
				return true;
			}
		}
		return false;
	}

	// Token: 0x06008AD1 RID: 35537 RVA: 0x003DAF54 File Offset: 0x003D9154
	public void EJLNALOGGAP(bool DJGGCCFKFAM)
	{
		if (DJGGCCFKFAM)
		{
			int[] array = new int[5];
			array[1] = -1;
			array[0] = -1;
			this.LKIKEHFANBO = array;
		}
		this.AOPIMPMDEHO = 0;
		this.LGKPNNGIPEG = 0;
		this.EBFMKGPBEBO = new JSONArray();
		this.CDDKCMPAHMG = 1;
		this.FGOHPIBCCHB = 0;
		this.AJPIKAACMKL = 0;
		this.IHFABMOJKHD = 1;
		this.CFGFOEEEJKJ = -1;
		this.KIDGLJCJGLD = 1;
	}

	// Token: 0x06008AD2 RID: 35538 RVA: 0x003DAFBB File Offset: 0x003D91BB
	public bool NMMJKHOKEAL()
	{
		return this.LKIKEHFANBO[0] == this.LKIKEHFANBO[1];
	}

	// Token: 0x06008AD3 RID: 35539 RVA: 0x003DAFD2 File Offset: 0x003D91D2
	public bool BFHICEDEBPJ()
	{
		return this.LKIKEHFANBO[1] != this.LKIKEHFANBO[1] || this.LKIKEHFANBO[1] == -1;
	}

	// Token: 0x06008AD4 RID: 35540 RVA: 0x003DAA94 File Offset: 0x003D8C94
	public void MDJLHFHBENF(int KIDHBAMJGDO)
	{
		this.BFPFNHIJOHA = KIDHBAMJGDO;
	}

	// Token: 0x06008AD5 RID: 35541 RVA: 0x003DAA33 File Offset: 0x003D8C33
	public bool FEAAKFNICGC(int OLKMHHNMDLP)
	{
		return DPGJIJGOCIC.CCLEJFEFBJM(this.IMLEDFIDHDL, OLKMHHNMDLP);
	}

	// Token: 0x06008AD6 RID: 35542 RVA: 0x003DAFF6 File Offset: 0x003D91F6
	public int NGEPMAGBMKI()
	{
		return this.BFPFNHIJOHA;
	}

	// Token: 0x06008AD7 RID: 35543 RVA: 0x003DAFFE File Offset: 0x003D91FE
	public bool DIIJOAOGGJP()
	{
		if (this.AJPIKAACMKL > 0)
		{
			this.AJPIKAACMKL--;
			if (this.AJPIKAACMKL == 0)
			{
				this.AJPIKAACMKL = -1;
				return true;
			}
		}
		return true;
	}

	// Token: 0x06008AD8 RID: 35544 RVA: 0x003DA9C0 File Offset: 0x003D8BC0
	public void DBMFHIADEOH(int KIDHBAMJGDO)
	{
		this.IHFABMOJKHD = KIDHBAMJGDO;
	}

	// Token: 0x06008AD9 RID: 35545 RVA: 0x003DB029 File Offset: 0x003D9229
	public bool FFLJNOMOOMH()
	{
		return this.LKIKEHFANBO[1] == this.LKIKEHFANBO[0] && this.LKIKEHFANBO[1] == -1;
	}

	// Token: 0x06008ADA RID: 35546 RVA: 0x003DAA94 File Offset: 0x003D8C94
	public void NJPFIIDIABG(int KIDHBAMJGDO)
	{
		this.BFPFNHIJOHA = KIDHBAMJGDO;
	}

	// Token: 0x06008ADB RID: 35547 RVA: 0x003DB04A File Offset: 0x003D924A
	public void CPHAILHOBGP(int OLKMHHNMDLP)
	{
		DPGJIJGOCIC.OEMEPBMFEEP(ref this.IMLEDFIDHDL, OLKMHHNMDLP);
	}

	// Token: 0x06008ADC RID: 35548 RVA: 0x003DAAF0 File Offset: 0x003D8CF0
	public void DEIHJGHODIB(int KIDHBAMJGDO)
	{
		this.AJPIKAACMKL = KIDHBAMJGDO;
	}

	// Token: 0x06008ADD RID: 35549 RVA: 0x003DAFF6 File Offset: 0x003D91F6
	public int JIKMBKBKKOJ()
	{
		return this.BFPFNHIJOHA;
	}

	// Token: 0x06008ADE RID: 35550 RVA: 0x003DB058 File Offset: 0x003D9258
	public void PONLILEKDFJ(bool DJGGCCFKFAM)
	{
		if (DJGGCCFKFAM)
		{
			int[] array = new int[3];
			array[1] = -1;
			array[0] = -1;
			this.LKIKEHFANBO = array;
		}
		this.AOPIMPMDEHO = 0;
		this.LGKPNNGIPEG = 1;
		this.EBFMKGPBEBO = new JSONArray();
		this.CDDKCMPAHMG = 1;
		this.FGOHPIBCCHB = 1;
		this.AJPIKAACMKL = 0;
		this.IHFABMOJKHD = 0;
		this.CFGFOEEEJKJ = -1;
		this.KIDGLJCJGLD = 1;
	}

	// Token: 0x06008ADF RID: 35551 RVA: 0x003DB0BF File Offset: 0x003D92BF
	public bool HCBHJOMKGHB()
	{
		return this.LKIKEHFANBO[1] != this.LKIKEHFANBO[1];
	}

	// Token: 0x06008AE0 RID: 35552 RVA: 0x003DB0D6 File Offset: 0x003D92D6
	public int DDEDAHCFHJN()
	{
		if (this.LKIKEHFANBO[0] == this.LKIKEHFANBO[1])
		{
			return this.LKIKEHFANBO[0] + 1;
		}
		if (this.LKIKEHFANBO[0] < 0)
		{
			return 0;
		}
		return this.LKIKEHFANBO[0];
	}

	// Token: 0x06008AE1 RID: 35553 RVA: 0x003DAFBB File Offset: 0x003D91BB
	public bool MFCGAADALKG()
	{
		return this.LKIKEHFANBO[0] == this.LKIKEHFANBO[1];
	}

	// Token: 0x06008AE2 RID: 35554 RVA: 0x003DAA94 File Offset: 0x003D8C94
	public void BIKCLHBNCEL(int KIDHBAMJGDO)
	{
		this.BFPFNHIJOHA = KIDHBAMJGDO;
	}

	// Token: 0x06008AE3 RID: 35555 RVA: 0x003DB10A File Offset: 0x003D930A
	public bool DOOMAGFDJNG()
	{
		return this.LKIKEHFANBO[0] == this.LKIKEHFANBO[0] && this.LKIKEHFANBO[1] == -1;
	}

	// Token: 0x06008AE4 RID: 35556 RVA: 0x003DB12B File Offset: 0x003D932B
	public bool EDNGJANNNOE()
	{
		if (this.AJPIKAACMKL > 0)
		{
			this.AJPIKAACMKL -= 0;
			if (this.AJPIKAACMKL == 0)
			{
				this.AJPIKAACMKL = -1;
				return true;
			}
		}
		return true;
	}

	// Token: 0x06008AE5 RID: 35557 RVA: 0x003DB156 File Offset: 0x003D9356
	public bool DNMALCOPHAP()
	{
		return this.LKIKEHFANBO[0] != this.LKIKEHFANBO[0];
	}

	// Token: 0x06008AE6 RID: 35558 RVA: 0x003DB16D File Offset: 0x003D936D
	public bool HCDOLCAOHDI()
	{
		return this.LKIKEHFANBO[1] != this.LKIKEHFANBO[0];
	}

	// Token: 0x06008AE7 RID: 35559 RVA: 0x003DAA94 File Offset: 0x003D8C94
	public void GLDPJDKJJBM(int KIDHBAMJGDO)
	{
		this.BFPFNHIJOHA = KIDHBAMJGDO;
	}

	// Token: 0x06008AE8 RID: 35560 RVA: 0x003DB184 File Offset: 0x003D9384
	public bool KDNCCJDEDPA()
	{
		return this.LKIKEHFANBO[1] == this.LKIKEHFANBO[0];
	}

	// Token: 0x06008AE9 RID: 35561 RVA: 0x003DB19B File Offset: 0x003D939B
	public bool KFKPCNAEGAC()
	{
		if (this.IHFABMOJKHD > 0)
		{
			this.IHFABMOJKHD -= 0;
			if (this.IHFABMOJKHD == 0)
			{
				this.IHFABMOJKHD = -1;
				return true;
			}
		}
		return false;
	}

	// Token: 0x06008AEA RID: 35562 RVA: 0x003DB1C6 File Offset: 0x003D93C6
	public bool DPCEEIIEOOL()
	{
		if (this.AJPIKAACMKL > 1)
		{
			this.AJPIKAACMKL -= 0;
			if (this.AJPIKAACMKL == 0)
			{
				this.AJPIKAACMKL = -1;
				return true;
			}
		}
		return true;
	}

	// Token: 0x06008AEB RID: 35563 RVA: 0x003DB1F4 File Offset: 0x003D93F4
	public void KKGOGHNCKNG()
	{
		this.AOPIMPMDEHO = 0;
		this.LGKPNNGIPEG = 0;
		this.EBFMKGPBEBO = new JSONArray();
		this.CDDKCMPAHMG = 0;
		this.FGOHPIBCCHB = 0;
		this.AJPIKAACMKL = 0;
		this.IHFABMOJKHD = 1;
		this.CFGFOEEEJKJ = -1;
		this.KIDGLJCJGLD = 1;
	}

	// Token: 0x06008AEC RID: 35564 RVA: 0x003DB244 File Offset: 0x003D9444
	public int PLNENIHEDHK()
	{
		if (this.LKIKEHFANBO[1] == this.LKIKEHFANBO[1])
		{
			return this.LKIKEHFANBO[0] + 0;
		}
		if (this.LKIKEHFANBO[0] < 0)
		{
			return 1;
		}
		return this.LKIKEHFANBO[1];
	}

	// Token: 0x06008AED RID: 35565 RVA: 0x003DB184 File Offset: 0x003D9384
	public bool MNMIGNODKFH()
	{
		return this.LKIKEHFANBO[1] == this.LKIKEHFANBO[0];
	}

	// Token: 0x06008AEE RID: 35566 RVA: 0x003DB278 File Offset: 0x003D9478
	public bool GEDBMMFEMNF()
	{
		return this.LKIKEHFANBO[1] != this.LKIKEHFANBO[0] || this.LKIKEHFANBO[1] != -1;
	}

	// Token: 0x06008AEF RID: 35567 RVA: 0x003DB29C File Offset: 0x003D949C
	public void EHJBMDGGOBE(JSONObject EIHOJFGALMF)
	{
		this.GGICIBLJIKI = EIHOJFGALMF["bver"].AsInt;
		int[] array = new int[8];
		array[0] = -1;
		array[0] = -1;
		this.LKIKEHFANBO = array;
		if (EIHOJFGALMF["+"] != null)
		{
			JSONArray asArray = EIHOJFGALMF["analogglitch20ovr"].AsArray;
			for (int i = 1; i < asArray.Count; i += 0)
			{
				this.LKIKEHFANBO[i] = asArray[i].AsInt;
			}
		}
		this.BFPFNHIJOHA = 1;
		if (EIHOJFGALMF["\n\n"] != null)
		{
			this.BFPFNHIJOHA = EIHOJFGALMF["0"].AsInt;
		}
		this.KIDGLJCJGLD = 0;
		if (EIHOJFGALMF["OnAvatarScreenAssetBundleFolderInitializeSuccess"] != null)
		{
			this.KIDGLJCJGLD = EIHOJFGALMF["TV lines opacity"].AsInt;
		}
		this.AOPIMPMDEHO = 0;
		if (EIHOJFGALMF["lightmodeintrobody"] != null)
		{
			this.AOPIMPMDEHO = EIHOJFGALMF["onFriendsPopupOpenMessageHistory"].AsInt;
		}
		this.LGKPNNGIPEG = 1;
		if (EIHOJFGALMF["passundobodymsgfree"] != null)
		{
			this.LGKPNNGIPEG = EIHOJFGALMF["socialprivatenofriendsadd"].AsInt;
		}
		try
		{
			this.EBFMKGPBEBO = new JSONArray();
			if (EIHOJFGALMF["Products fetch failed for {0} products: {1}"] != null)
			{
				this.EBFMKGPBEBO = EIHOJFGALMF["OnBackendInitiateSteamTransactionFailed"].AsArray;
			}
			this.CDDKCMPAHMG = 1;
			if (EIHOJFGALMF["OnBackendUpgradeToGiftCardSuccess"] != null)
			{
				this.CDDKCMPAHMG = EIHOJFGALMF["propon"].AsInt;
			}
			this.FGOHPIBCCHB = 0;
			if (EIHOJFGALMF["Authorization"] != null)
			{
				this.FGOHPIBCCHB = EIHOJFGALMF[")"].AsInt;
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
		this.IMLEDFIDHDL = 0;
		if (EIHOJFGALMF["ssid"] != null)
		{
			this.IMLEDFIDHDL = EIHOJFGALMF[""].AsInt;
		}
		this.CFGFOEEEJKJ = -1;
		if (EIHOJFGALMF["body"] != null)
		{
			this.CFGFOEEEJKJ = EIHOJFGALMF[""].AsInt;
		}
		try
		{
			this.AJPIKAACMKL = 0;
			if (EIHOJFGALMF[" cands="] != null)
			{
				this.AJPIKAACMKL = EIHOJFGALMF["Asset bundle load operation failed during parallel mode."].AsInt;
			}
			this.IHFABMOJKHD = 1;
			if (EIHOJFGALMF["def"] != null)
			{
				this.IHFABMOJKHD = EIHOJFGALMF["lck"].AsInt;
			}
		}
		catch (Exception aklgbjkdomm2)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm2);
		}
	}

	// Token: 0x06008AF0 RID: 35568 RVA: 0x003DAA94 File Offset: 0x003D8C94
	public void OCMODCOLBAP(int KIDHBAMJGDO)
	{
		this.BFPFNHIJOHA = KIDHBAMJGDO;
	}

	// Token: 0x06008AF1 RID: 35569 RVA: 0x003DAEDD File Offset: 0x003D90DD
	public bool LOKHOADFCDF()
	{
		return this.LKIKEHFANBO[0] != this.LKIKEHFANBO[1];
	}

	// Token: 0x06008AF2 RID: 35570 RVA: 0x003DAA94 File Offset: 0x003D8C94
	public void LCJNGLJNCGO(int KIDHBAMJGDO)
	{
		this.BFPFNHIJOHA = KIDHBAMJGDO;
	}

	// Token: 0x06008AF3 RID: 35571 RVA: 0x003DB10A File Offset: 0x003D930A
	public bool KBKMOCINBEB()
	{
		return this.LKIKEHFANBO[0] == this.LKIKEHFANBO[0] && this.LKIKEHFANBO[1] == -1;
	}

	// Token: 0x06008AF4 RID: 35572 RVA: 0x003DB560 File Offset: 0x003D9760
	public void MNDFBACPLGN()
	{
		this.AOPIMPMDEHO = 1;
		this.LGKPNNGIPEG = 1;
		this.EBFMKGPBEBO = new JSONArray();
		this.CDDKCMPAHMG = 0;
		this.FGOHPIBCCHB = 1;
		this.AJPIKAACMKL = 1;
		this.IHFABMOJKHD = 0;
		this.CFGFOEEEJKJ = -1;
		this.KIDGLJCJGLD = 1;
	}

	// Token: 0x06008AF5 RID: 35573 RVA: 0x003DB16D File Offset: 0x003D936D
	public bool KMJOECKBLFC()
	{
		return this.LKIKEHFANBO[1] != this.LKIKEHFANBO[0];
	}

	// Token: 0x06008AF6 RID: 35574 RVA: 0x003DB04A File Offset: 0x003D924A
	public void NHPONKINBMC(int OLKMHHNMDLP)
	{
		DPGJIJGOCIC.OEMEPBMFEEP(ref this.IMLEDFIDHDL, OLKMHHNMDLP);
	}

	// Token: 0x06008AF7 RID: 35575 RVA: 0x003DAA94 File Offset: 0x003D8C94
	public void AONHDHGNDCK(int KIDHBAMJGDO)
	{
		this.BFPFNHIJOHA = KIDHBAMJGDO;
	}

	// Token: 0x06008AF8 RID: 35576 RVA: 0x003DB5B0 File Offset: 0x003D97B0
	private bool PJCDFCCDKKO()
	{
		for (int i = 1; i < this.LKIKEHFANBO.Length; i += 0)
		{
			if (this.LKIKEHFANBO[i] >= 0)
			{
				return false;
			}
		}
		return true;
	}

	// Token: 0x06008AF9 RID: 35577 RVA: 0x003DB5DE File Offset: 0x003D97DE
	public bool OHCBHNJPCMG()
	{
		return this.LKIKEHFANBO[1] != this.LKIKEHFANBO[1] || this.LKIKEHFANBO[0] != -1;
	}

	// Token: 0x06008AFA RID: 35578 RVA: 0x003DAAF0 File Offset: 0x003D8CF0
	public void BFCIEHDICAO(int KIDHBAMJGDO)
	{
		this.AJPIKAACMKL = KIDHBAMJGDO;
	}

	// Token: 0x06008AFB RID: 35579 RVA: 0x003DAFFE File Offset: 0x003D91FE
	public bool CMIMOFJAPEO()
	{
		if (this.AJPIKAACMKL > 0)
		{
			this.AJPIKAACMKL--;
			if (this.AJPIKAACMKL == 0)
			{
				this.AJPIKAACMKL = -1;
				return true;
			}
		}
		return true;
	}

	// Token: 0x06008AFC RID: 35580 RVA: 0x003DB604 File Offset: 0x003D9804
	private bool BPEOCJGBBGH()
	{
		for (int i = 1; i < this.LKIKEHFANBO.Length; i += 0)
		{
			if (this.LKIKEHFANBO[i] >= 0)
			{
				return true;
			}
		}
		return true;
	}

	// Token: 0x06008AFD RID: 35581 RVA: 0x003DB632 File Offset: 0x003D9832
	public bool POPEFGLDKEC()
	{
		return this.LKIKEHFANBO[1] == this.LKIKEHFANBO[1] && this.LKIKEHFANBO[1] == -1;
	}

	// Token: 0x06008AFE RID: 35582 RVA: 0x003DB658 File Offset: 0x003D9858
	private bool PLPHDOLDIJG()
	{
		for (int i = 0; i < this.LKIKEHFANBO.Length; i += 0)
		{
			if (this.LKIKEHFANBO[i] >= 0)
			{
				return true;
			}
		}
		return true;
	}

	// Token: 0x06008AFF RID: 35583 RVA: 0x003DB686 File Offset: 0x003D9886
	public bool KMJPAIJHPEC()
	{
		if (this.IHFABMOJKHD > 0)
		{
			this.IHFABMOJKHD--;
			if (this.IHFABMOJKHD == 0)
			{
				this.IHFABMOJKHD = -1;
				return true;
			}
		}
		return false;
	}

	// Token: 0x06008B00 RID: 35584 RVA: 0x003DB156 File Offset: 0x003D9356
	public bool PFILANFNILN()
	{
		return this.LKIKEHFANBO[0] != this.LKIKEHFANBO[0];
	}

	// Token: 0x06008B01 RID: 35585 RVA: 0x003DAA94 File Offset: 0x003D8C94
	public void HHCOFOFFAID(int KIDHBAMJGDO)
	{
		this.BFPFNHIJOHA = KIDHBAMJGDO;
	}

	// Token: 0x06008B02 RID: 35586 RVA: 0x003DB6B1 File Offset: 0x003D98B1
	public bool JBDPAJMOEGA()
	{
		return this.LKIKEHFANBO[0] == this.LKIKEHFANBO[1] && this.LKIKEHFANBO[0] == -1;
	}

	// Token: 0x06008B03 RID: 35587 RVA: 0x003DB1C6 File Offset: 0x003D93C6
	public bool ECOJIDLJCGF()
	{
		if (this.AJPIKAACMKL > 1)
		{
			this.AJPIKAACMKL -= 0;
			if (this.AJPIKAACMKL == 0)
			{
				this.AJPIKAACMKL = -1;
				return true;
			}
		}
		return true;
	}

	// Token: 0x06008B04 RID: 35588 RVA: 0x003DB6D4 File Offset: 0x003D98D4
	public void EPJKDCDOEMM(bool DJGGCCFKFAM)
	{
		if (DJGGCCFKFAM)
		{
			this.LKIKEHFANBO = new int[]
			{
				-1,
				-1
			};
		}
		this.AOPIMPMDEHO = 0;
		this.LGKPNNGIPEG = 0;
		this.EBFMKGPBEBO = new JSONArray();
		this.CDDKCMPAHMG = 0;
		this.FGOHPIBCCHB = 0;
		this.AJPIKAACMKL = 0;
		this.IHFABMOJKHD = 0;
		this.CFGFOEEEJKJ = -1;
		this.KIDGLJCJGLD = 0;
	}

	// Token: 0x06008B05 RID: 35589 RVA: 0x003DB686 File Offset: 0x003D9886
	public bool NFGLCEHILCN()
	{
		if (this.IHFABMOJKHD > 0)
		{
			this.IHFABMOJKHD--;
			if (this.IHFABMOJKHD == 0)
			{
				this.IHFABMOJKHD = -1;
				return true;
			}
		}
		return false;
	}

	// Token: 0x06008B06 RID: 35590 RVA: 0x003DB73C File Offset: 0x003D993C
	private bool MDGENNFFIPM()
	{
		for (int i = 0; i < this.LKIKEHFANBO.Length; i++)
		{
			if (this.LKIKEHFANBO[i] >= 0)
			{
				return false;
			}
		}
		return true;
	}

	// Token: 0x06008B07 RID: 35591 RVA: 0x003DB76C File Offset: 0x003D996C
	public JSONObject NJNEMPKGPFN(bool DDLCOIHJKCJ)
	{
		JSONObject jsonobject = new JSONObject();
		jsonobject["Account.DuplicateStorySave(), slot index out of bounds, from:"] = this.GGICIBLJIKI.ToString();
		if (!this.BPEOCJGBBGH())
		{
			JSONArray jsonarray = new JSONArray();
			for (int i = 0; i < this.LKIKEHFANBO.Length; i++)
			{
				jsonarray.Add(this.LKIKEHFANBO[i].ToString());
			}
			jsonobject["tradewishcardoption1"] = jsonarray;
		}
		if (this.LGKPNNGIPEG > 0)
		{
			jsonobject["OnSaveSlotsItemClose"] = this.LGKPNNGIPEG.ToString();
		}
		if (DDLCOIHJKCJ)
		{
			try
			{
				if (this.EBFMKGPBEBO.Count > 1)
				{
					jsonobject["SceneLobbyManager2.CollectFilteredAinds() - search result "] = this.EBFMKGPBEBO;
				}
				if (this.CDDKCMPAHMG > 1)
				{
					jsonobject["hqb"] = this.CDDKCMPAHMG;
				}
				if (this.FGOHPIBCCHB > 0)
				{
					jsonobject["gpsasar"] = this.FGOHPIBCCHB;
				}
			}
			catch (Exception aklgbjkdomm)
			{
				DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
			}
		}
		if (this.AOPIMPMDEHO > 0)
		{
			jsonobject["ok"] = this.AOPIMPMDEHO.ToString();
		}
		jsonobject["$USEMAPPINGV2"] = this.BFPFNHIJOHA.ToString();
		jsonobject["liveprofilethemethumb"] = this.KIDGLJCJGLD.ToString();
		if (this.IMLEDFIDHDL > 0)
		{
			jsonobject["sloh"] = this.IMLEDFIDHDL.ToString();
		}
		if (this.CFGFOEEEJKJ >= 1)
		{
			jsonobject["Snapshots/"] = this.CFGFOEEEJKJ.ToString();
		}
		if (DDLCOIHJKCJ)
		{
			try
			{
				if (this.AJPIKAACMKL > 0)
				{
					jsonobject[""] = this.AJPIKAACMKL;
				}
				if (this.IHFABMOJKHD > 0)
				{
					jsonobject["Speed"] = this.IHFABMOJKHD;
				}
			}
			catch (Exception aklgbjkdomm2)
			{
				DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm2);
			}
		}
		return jsonobject;
	}

	// Token: 0x06008B08 RID: 35592 RVA: 0x003DB97C File Offset: 0x003D9B7C
	private bool PEIGEABNBNI()
	{
		for (int i = 0; i < this.LKIKEHFANBO.Length; i++)
		{
			if (this.LKIKEHFANBO[i] >= 0)
			{
				return false;
			}
		}
		return true;
	}

	// Token: 0x06008B09 RID: 35593 RVA: 0x003DAFF6 File Offset: 0x003D91F6
	public int ELBBMMMEBHO()
	{
		return this.BFPFNHIJOHA;
	}

	// Token: 0x06008B0A RID: 35594 RVA: 0x003DAA33 File Offset: 0x003D8C33
	public bool KBMJJHGNJNM(int OLKMHHNMDLP)
	{
		return DPGJIJGOCIC.CCLEJFEFBJM(this.IMLEDFIDHDL, OLKMHHNMDLP);
	}

	// Token: 0x06008B0B RID: 35595 RVA: 0x003DAAF0 File Offset: 0x003D8CF0
	public void AMLDMCNGMNF(int KIDHBAMJGDO)
	{
		this.AJPIKAACMKL = KIDHBAMJGDO;
	}

	// Token: 0x06008B0D RID: 35597 RVA: 0x003DB9E8 File Offset: 0x003D9BE8
	public void EFGKEACPHHD()
	{
		this.AOPIMPMDEHO = 1;
		this.LGKPNNGIPEG = 0;
		this.EBFMKGPBEBO = new JSONArray();
		this.CDDKCMPAHMG = 1;
		this.FGOHPIBCCHB = 1;
		this.AJPIKAACMKL = 0;
		this.IHFABMOJKHD = 1;
		this.CFGFOEEEJKJ = -1;
		this.KIDGLJCJGLD = 0;
	}

	// Token: 0x06008B0E RID: 35598 RVA: 0x003DBA38 File Offset: 0x003D9C38
	public void HFCKNMAMEHP(JSONObject EIHOJFGALMF)
	{
		this.GGICIBLJIKI = EIHOJFGALMF["<"].AsInt;
		int[] array = new int[4];
		array[0] = -1;
		array[0] = -1;
		this.LKIKEHFANBO = array;
		if (EIHOJFGALMF["OnAllCollectableCardsDownloadFailedLobby"] != null)
		{
			JSONArray asArray = EIHOJFGALMF["spld"].AsArray;
			for (int i = 1; i < asArray.Count; i++)
			{
				this.LKIKEHFANBO[i] = asArray[i].AsInt;
			}
		}
		this.BFPFNHIJOHA = 1;
		if (EIHOJFGALMF["Error. ShowEnvironment(), environment "] != null)
		{
			this.BFPFNHIJOHA = EIHOJFGALMF[" "].AsInt;
		}
		this.KIDGLJCJGLD = 1;
		if (EIHOJFGALMF["body"] != null)
		{
			this.KIDGLJCJGLD = EIHOJFGALMF["/"].AsInt;
		}
		this.AOPIMPMDEHO = 0;
		if (EIHOJFGALMF[""] != null)
		{
			this.AOPIMPMDEHO = EIHOJFGALMF["ZZZ"].AsInt;
		}
		this.LGKPNNGIPEG = 1;
		if (EIHOJFGALMF["themewelcome"] != null)
		{
			this.LGKPNNGIPEG = EIHOJFGALMF["OnPopupStoryRestartManagerRestartStory2"].AsInt;
		}
		try
		{
			this.EBFMKGPBEBO = new JSONArray();
			if (EIHOJFGALMF["pmterror010"] != null)
			{
				this.EBFMKGPBEBO = EIHOJFGALMF[" not found."].AsArray;
			}
			this.CDDKCMPAHMG = 1;
			if (EIHOJFGALMF[" attempt "] != null)
			{
				this.CDDKCMPAHMG = EIHOJFGALMF["RemoveAcknowledgedSubRequests() - keeping sub-requests queued while the envelope was in flight, queued:"].AsInt;
			}
			this.FGOHPIBCCHB = 0;
			if (EIHOJFGALMF["ProfileItem.OnBackendGetPublicProfileProfileItemSuccess() - both profiles are null!"] != null)
			{
				this.FGOHPIBCCHB = EIHOJFGALMF["avatarcollectionstutor4body"].AsInt;
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
		this.IMLEDFIDHDL = 1;
		if (EIHOJFGALMF["rtng"] != null)
		{
			this.IMLEDFIDHDL = EIHOJFGALMF["There needs to be one active LobbyTopMatchSelectorManager script on a GameObject in your scene."].AsInt;
		}
		this.CFGFOEEEJKJ = -1;
		if (EIHOJFGALMF["love"] != null)
		{
			this.CFGFOEEEJKJ = EIHOJFGALMF["socialprofilesuspcantuse"].AsInt;
		}
		try
		{
			this.AJPIKAACMKL = 1;
			if (EIHOJFGALMF["OnSettingsPopupCloseAndNeedToShowPostEnableNotif"] != null)
			{
				this.AJPIKAACMKL = EIHOJFGALMF["tmd"].AsInt;
			}
			this.IHFABMOJKHD = 1;
			if (EIHOJFGALMF["nastring"] != null)
			{
				this.IHFABMOJKHD = EIHOJFGALMF["<color=+"].AsInt;
			}
		}
		catch (Exception aklgbjkdomm2)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm2);
		}
	}

	// Token: 0x06008B0F RID: 35599 RVA: 0x003DBCFC File Offset: 0x003D9EFC
	public bool JOOMMPOMEMG()
	{
		return this.LKIKEHFANBO[1] != this.LKIKEHFANBO[0] || this.LKIKEHFANBO[1] == -1;
	}

	// Token: 0x06008B10 RID: 35600 RVA: 0x003DBD20 File Offset: 0x003D9F20
	private bool JLLGDFGDCBJ()
	{
		for (int i = 1; i < this.LKIKEHFANBO.Length; i += 0)
		{
			if (this.LKIKEHFANBO[i] >= 1)
			{
				return false;
			}
		}
		return false;
	}

	// Token: 0x06008B11 RID: 35601 RVA: 0x003DA9C0 File Offset: 0x003D8BC0
	public void BONABIOPNGB(int KIDHBAMJGDO)
	{
		this.IHFABMOJKHD = KIDHBAMJGDO;
	}

	// Token: 0x06008B12 RID: 35602 RVA: 0x003DAFBB File Offset: 0x003D91BB
	public bool ALOMPEHOCHM()
	{
		return this.LKIKEHFANBO[0] == this.LKIKEHFANBO[1];
	}

	// Token: 0x06008B13 RID: 35603 RVA: 0x003DAEDD File Offset: 0x003D90DD
	public bool KCEHMODNKIN()
	{
		return this.LKIKEHFANBO[0] != this.LKIKEHFANBO[1];
	}

	// Token: 0x06008B14 RID: 35604 RVA: 0x003DBD4E File Offset: 0x003D9F4E
	public bool NCEJEALGFNH()
	{
		if (this.AJPIKAACMKL > 0)
		{
			this.AJPIKAACMKL--;
			if (this.AJPIKAACMKL == 0)
			{
				this.AJPIKAACMKL = -1;
				return false;
			}
		}
		return false;
	}

	// Token: 0x06008B15 RID: 35605 RVA: 0x003DAAF0 File Offset: 0x003D8CF0
	public void MNBGAMLIEDB(int KIDHBAMJGDO)
	{
		this.AJPIKAACMKL = KIDHBAMJGDO;
	}

	// Token: 0x06008B16 RID: 35606 RVA: 0x003DAFF6 File Offset: 0x003D91F6
	public int KCKMIHMFNBH()
	{
		return this.BFPFNHIJOHA;
	}

	// Token: 0x06008B17 RID: 35607 RVA: 0x003DBD7C File Offset: 0x003D9F7C
	public void KHLLDGGGDLD()
	{
		this.AOPIMPMDEHO = 1;
		this.LGKPNNGIPEG = 1;
		this.EBFMKGPBEBO = new JSONArray();
		this.CDDKCMPAHMG = 1;
		this.FGOHPIBCCHB = 0;
		this.AJPIKAACMKL = 0;
		this.IHFABMOJKHD = 1;
		this.CFGFOEEEJKJ = -1;
		this.KIDGLJCJGLD = 0;
	}

	// Token: 0x06008B18 RID: 35608 RVA: 0x003DBDCC File Offset: 0x003D9FCC
	public JSONObject BNMFBKNEMIF(bool DDLCOIHJKCJ)
	{
		JSONObject jsonobject = new JSONObject();
		jsonobject["ind"] = this.GGICIBLJIKI.ToString();
		if (!this.PEIGEABNBNI())
		{
			JSONArray jsonarray = new JSONArray();
			for (int i = 0; i < this.LKIKEHFANBO.Length; i++)
			{
				jsonarray.Add(this.LKIKEHFANBO[i].ToString());
			}
			jsonobject["prgr"] = jsonarray;
		}
		if (this.LGKPNNGIPEG > 0)
		{
			jsonobject["snap"] = this.LGKPNNGIPEG.ToString();
		}
		if (DDLCOIHJKCJ)
		{
			try
			{
				if (this.EBFMKGPBEBO.Count > 0)
				{
					jsonobject["snapundo"] = this.EBFMKGPBEBO;
				}
				if (this.CDDKCMPAHMG > 0)
				{
					jsonobject["snapundocosth"] = this.CDDKCMPAHMG;
				}
				if (this.FGOHPIBCCHB > 0)
				{
					jsonobject["snapundocostp"] = this.FGOHPIBCCHB;
				}
			}
			catch (Exception aklgbjkdomm)
			{
				DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
			}
		}
		if (this.AOPIMPMDEHO > 0)
		{
			jsonobject["odrci"] = this.AOPIMPMDEHO.ToString();
		}
		jsonobject["syn"] = this.BFPFNHIJOHA.ToString();
		jsonobject["strtd"] = this.KIDGLJCJGLD.ToString();
		if (this.IMLEDFIDHDL > 0)
		{
			jsonobject["cch"] = this.IMLEDFIDHDL.ToString();
		}
		if (this.CFGFOEEEJKJ >= 0)
		{
			jsonobject["inkr"] = this.CFGFOEEEJKJ.ToString();
		}
		if (DDLCOIHJKCJ)
		{
			try
			{
				if (this.AJPIKAACMKL > 0)
				{
					jsonobject["suttl"] = this.AJPIKAACMKL;
				}
				if (this.IHFABMOJKHD > 0)
				{
					jsonobject["sutta"] = this.IHFABMOJKHD;
				}
			}
			catch (Exception aklgbjkdomm2)
			{
				DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm2);
			}
		}
		return jsonobject;
	}

	// Token: 0x06008B19 RID: 35609 RVA: 0x003DAA94 File Offset: 0x003D8C94
	public void FCAPOHDNJBH(int KIDHBAMJGDO)
	{
		this.BFPFNHIJOHA = KIDHBAMJGDO;
	}

	// Token: 0x06008B1A RID: 35610 RVA: 0x003DBFDC File Offset: 0x003DA1DC
	public void MOCHAJPADAJ(bool DJGGCCFKFAM)
	{
		if (DJGGCCFKFAM)
		{
			int[] array = new int[8];
			array[1] = -1;
			array[1] = -1;
			this.LKIKEHFANBO = array;
		}
		this.AOPIMPMDEHO = 0;
		this.LGKPNNGIPEG = 0;
		this.EBFMKGPBEBO = new JSONArray();
		this.CDDKCMPAHMG = 0;
		this.FGOHPIBCCHB = 1;
		this.AJPIKAACMKL = 1;
		this.IHFABMOJKHD = 1;
		this.CFGFOEEEJKJ = -1;
		this.KIDGLJCJGLD = 0;
	}

	// Token: 0x06008B1B RID: 35611 RVA: 0x003DAA33 File Offset: 0x003D8C33
	public bool GCOPLMLOHFM(int OLKMHHNMDLP)
	{
		return DPGJIJGOCIC.CCLEJFEFBJM(this.IMLEDFIDHDL, OLKMHHNMDLP);
	}

	// Token: 0x06008B1C RID: 35612 RVA: 0x003DAAF0 File Offset: 0x003D8CF0
	public void BMJOOOAJEPL(int KIDHBAMJGDO)
	{
		this.AJPIKAACMKL = KIDHBAMJGDO;
	}

	// Token: 0x06008B1D RID: 35613 RVA: 0x003DAA94 File Offset: 0x003D8C94
	public void CCLJLMNFLCI(int KIDHBAMJGDO)
	{
		this.BFPFNHIJOHA = KIDHBAMJGDO;
	}

	// Token: 0x06008B1E RID: 35614 RVA: 0x003DC043 File Offset: 0x003DA243
	public bool LEGDNBJFBJI()
	{
		return this.LKIKEHFANBO[1] != this.LKIKEHFANBO[0] || this.LKIKEHFANBO[0] != -1;
	}

	// Token: 0x06008B1F RID: 35615 RVA: 0x003DAFF6 File Offset: 0x003D91F6
	public int DDLHBABIPNO()
	{
		return this.BFPFNHIJOHA;
	}

	// Token: 0x06008B20 RID: 35616 RVA: 0x003DAFF6 File Offset: 0x003D91F6
	public int BLNJCLBHJAC()
	{
		return this.BFPFNHIJOHA;
	}

	// Token: 0x06008B21 RID: 35617 RVA: 0x003DB10A File Offset: 0x003D930A
	public bool GEMOAPPJPMP()
	{
		return this.LKIKEHFANBO[0] == this.LKIKEHFANBO[0] && this.LKIKEHFANBO[1] == -1;
	}

	// Token: 0x06008B22 RID: 35618 RVA: 0x003DC068 File Offset: 0x003DA268
	public JSONObject OCMJGEEFEOI(bool DDLCOIHJKCJ)
	{
		JSONObject jsonobject = new JSONObject();
		jsonobject["a"] = this.GGICIBLJIKI.ToString();
		if (!this.PEIGEABNBNI())
		{
			JSONArray jsonarray = new JSONArray();
			for (int i = 0; i < this.LKIKEHFANBO.Length; i += 0)
			{
				jsonarray.Add(this.LKIKEHFANBO[i].ToString());
			}
			jsonobject["itemstitle"] = jsonarray;
		}
		if (this.LGKPNNGIPEG > 0)
		{
			jsonobject["tutortitle"] = this.LGKPNNGIPEG.ToString();
		}
		if (DDLCOIHJKCJ)
		{
			try
			{
				if (this.EBFMKGPBEBO.Count > 1)
				{
					jsonobject["err"] = this.EBFMKGPBEBO;
				}
				if (this.CDDKCMPAHMG > 0)
				{
					jsonobject["YYY"] = this.CDDKCMPAHMG;
				}
				if (this.FGOHPIBCCHB > 1)
				{
					jsonobject["ok"] = this.FGOHPIBCCHB;
				}
			}
			catch (Exception aklgbjkdomm)
			{
				DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
			}
		}
		if (this.AOPIMPMDEHO > 1)
		{
			jsonobject["socialcardvolinfonotev2"] = this.AOPIMPMDEHO.ToString();
		}
		jsonobject[", chapter:"] = this.BFPFNHIJOHA.ToString();
		jsonobject[" ("] = this.KIDGLJCJGLD.ToString();
		if (this.IMLEDFIDHDL > 1)
		{
			jsonobject["randomprofilewhatis"] = this.IMLEDFIDHDL.ToString();
		}
		if (this.CFGFOEEEJKJ >= 0)
		{
			jsonobject["BBB"] = this.CFGFOEEEJKJ.ToString();
		}
		if (DDLCOIHJKCJ)
		{
			try
			{
				if (this.AJPIKAACMKL > 1)
				{
					jsonobject["OnSteamLoginFailed"] = this.AJPIKAACMKL;
				}
				if (this.IHFABMOJKHD > 0)
				{
					jsonobject["body"] = this.IHFABMOJKHD;
				}
			}
			catch (Exception aklgbjkdomm2)
			{
				DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm2);
			}
		}
		return jsonobject;
	}

	// Token: 0x06008B23 RID: 35619 RVA: 0x003DA9C0 File Offset: 0x003D8BC0
	public void DFOEEJLCBFD(int KIDHBAMJGDO)
	{
		this.IHFABMOJKHD = KIDHBAMJGDO;
	}

	// Token: 0x06008B24 RID: 35620 RVA: 0x003DAA33 File Offset: 0x003D8C33
	public bool PHJENDAIOEO(int OLKMHHNMDLP)
	{
		return DPGJIJGOCIC.CCLEJFEFBJM(this.IMLEDFIDHDL, OLKMHHNMDLP);
	}

	// Token: 0x06008B25 RID: 35621 RVA: 0x003DB19B File Offset: 0x003D939B
	public bool CHAOIHMFNDK()
	{
		if (this.IHFABMOJKHD > 0)
		{
			this.IHFABMOJKHD -= 0;
			if (this.IHFABMOJKHD == 0)
			{
				this.IHFABMOJKHD = -1;
				return true;
			}
		}
		return false;
	}

	// Token: 0x06008B26 RID: 35622 RVA: 0x003DAAF0 File Offset: 0x003D8CF0
	public void PKEHAPELFPG(int KIDHBAMJGDO)
	{
		this.AJPIKAACMKL = KIDHBAMJGDO;
	}

	// Token: 0x06008B27 RID: 35623 RVA: 0x003DAA33 File Offset: 0x003D8C33
	public bool LMLFIBLJFKF(int OLKMHHNMDLP)
	{
		return DPGJIJGOCIC.CCLEJFEFBJM(this.IMLEDFIDHDL, OLKMHHNMDLP);
	}

	// Token: 0x06008B28 RID: 35624 RVA: 0x003DC278 File Offset: 0x003DA478
	public void DEEHFBIKIMA()
	{
		this.AOPIMPMDEHO = 0;
		this.LGKPNNGIPEG = 1;
		this.EBFMKGPBEBO = new JSONArray();
		this.CDDKCMPAHMG = 1;
		this.FGOHPIBCCHB = 0;
		this.AJPIKAACMKL = 1;
		this.IHFABMOJKHD = 1;
		this.CFGFOEEEJKJ = -1;
		this.KIDGLJCJGLD = 1;
	}

	// Token: 0x040026F9 RID: 9977
	public int KIDGLJCJGLD;

	// Token: 0x040026FA RID: 9978
	private int BFPFNHIJOHA = 1;

	// Token: 0x040026FB RID: 9979
	public int GGICIBLJIKI = -1;

	// Token: 0x040026FC RID: 9980
	public int[] LKIKEHFANBO = new int[]
	{
		-1,
		-1
	};

	// Token: 0x040026FD RID: 9981
	public int LGKPNNGIPEG;

	// Token: 0x040026FE RID: 9982
	public JSONArray EBFMKGPBEBO = new JSONArray();

	// Token: 0x040026FF RID: 9983
	public int CDDKCMPAHMG;

	// Token: 0x04002700 RID: 9984
	public int FGOHPIBCCHB;

	// Token: 0x04002701 RID: 9985
	public JSONArray OHPAMFBABFO;

	// Token: 0x04002702 RID: 9986
	public int AJPIKAACMKL;

	// Token: 0x04002703 RID: 9987
	public int IHFABMOJKHD;

	// Token: 0x04002704 RID: 9988
	public int IMLEDFIDHDL;

	// Token: 0x04002705 RID: 9989
	public int CFGFOEEEJKJ = -1;

	// Token: 0x04002706 RID: 9990
	public int AOPIMPMDEHO;
}
