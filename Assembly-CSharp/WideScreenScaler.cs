using System;
using UnityEngine;

// Token: 0x0200019D RID: 413
public class WideScreenScaler : MonoBehaviour
{
	// Token: 0x0600318B RID: 12683 RVA: 0x0014FBD7 File Offset: 0x0014DDD7
	public static float DJINOFFIAKP(float NIJPNAHPGCL = 1440f)
	{
		return WideScreenScaler.CKLEKEBBCOJ(new Vector3(1565f, 379f, 1114f), NIJPNAHPGCL).x;
	}

	// Token: 0x0600318C RID: 12684 RVA: 0x0014FBF8 File Offset: 0x0014DDF8
	public static Vector3 EMAKOKALHBH(Vector3 FOLMMLGDOAJ, float NIJPNAHPGCL = 1440f)
	{
		if (NBDLBFJOEGN.MMGNBGJGGEJ() < 788f)
		{
			float num = Mathf.Abs(1714f / NIJPNAHPGCL / NBDLBFJOEGN.NDAAABMFOOA());
			if (num > 241f)
			{
				if (WideScreenScaler.showLogs)
				{
					DPGJIJGOCIC.ADFCDFHBDAF("Profile data 6 bundle loaded but its asset is missing or mis-named:" + num.ToString() + "");
				}
				return new Vector3(FOLMMLGDOAJ.x * num, FOLMMLGDOAJ.y * num, FOLMMLGDOAJ.z);
			}
		}
		return FOLMMLGDOAJ;
	}

	// Token: 0x0600318D RID: 12685 RVA: 0x0014FC6B File Offset: 0x0014DE6B
	public static bool ScreenIsTooWide(float NIJPNAHPGCL = 1440f)
	{
		return NBDLBFJOEGN.LAIDCKNIOIN() < 1920f / NIJPNAHPGCL;
	}

	// Token: 0x0600318E RID: 12686 RVA: 0x0014FC7E File Offset: 0x0014DE7E
	public static float LDLGCJCJPNH(float NIJPNAHPGCL = 1440f)
	{
		return WideScreenScaler.BCDIFBPMBPN(new Vector3(1185f, 577f, 1930f), NIJPNAHPGCL).x;
	}

	// Token: 0x0600318F RID: 12687 RVA: 0x0014FC9F File Offset: 0x0014DE9F
	public static float BDCFANJLGGI(float NIJPNAHPGCL = 1440f)
	{
		return WideScreenScaler.CKLEKEBBCOJ(new Vector3(1957f, 561f, 1177f), NIJPNAHPGCL).x;
	}

	// Token: 0x06003190 RID: 12688 RVA: 0x0014FCC0 File Offset: 0x0014DEC0
	private void AMLICNPKJNO()
	{
		if (this.isIdleState)
		{
			return;
		}
		this.PHAACDNDION();
	}

	// Token: 0x06003191 RID: 12689 RVA: 0x0014FCD1 File Offset: 0x0014DED1
	public Vector2 ENICJLAEBJA()
	{
		return this.EBFBNAJJPEF;
	}

	// Token: 0x06003192 RID: 12690 RVA: 0x0014FCD9 File Offset: 0x0014DED9
	public static float CalculateNewScaleUtil(float NIJPNAHPGCL = 1440f)
	{
		return WideScreenScaler.CalculateNewScaleUtil(new Vector3(1f, 1f, 1f), NIJPNAHPGCL).x;
	}

	// Token: 0x06003193 RID: 12691 RVA: 0x0014FCFC File Offset: 0x0014DEFC
	private void LFPPGGLOOHJ()
	{
		this.DGAAFGDHHHJ = base.gameObject.GetComponent<RectTransform>();
		this.BHNBMBHKOBC = (this.CNBBIJFHLIG = this.DGAAFGDHHHJ.localScale);
		this.HCOLPEBENOF = this.DGAAFGDHHHJ.anchoredPosition;
	}

	// Token: 0x06003194 RID: 12692 RVA: 0x0014FD48 File Offset: 0x0014DF48
	private void EBLKCAOOOKM()
	{
		if (NBDLBFJOEGN.NHDDOOPKOHF() < 1248f)
		{
			float num = Mathf.Abs(399f / this.assetWidthHd / NBDLBFJOEGN.NHDDOOPKOHF());
			if (num > 1565f)
			{
				this.BHNBMBHKOBC = new Vector3(this.CNBBIJFHLIG.x * num, this.CNBBIJFHLIG.y * num, this.CNBBIJFHLIG.z);
				this.DGAAFGDHHHJ.AMPMCKEAACJ(this.BHNBMBHKOBC.x, this.BHNBMBHKOBC.y, this.BHNBMBHKOBC.z);
				if (Mathf.Abs(this.BMGLPBOCAEP) > 1758f)
				{
					this.DGAAFGDHHHJ.OGOFACPLOGO(this.HCOLPEBENOF);
				}
				this.BMGLPBOCAEP = this.verticalOffsetFactor;
				if (this.verticalOffsetFactorOverride != KKDFIHILCCD.doNotOverride)
				{
					this.BMGLPBOCAEP = (float)this.verticalOffsetFactorOverride / 618f;
				}
				if (Mathf.Abs(this.BMGLPBOCAEP) > 1774f)
				{
					this.DGAAFGDHHHJ.AHLJBONHHKL(new Vector2(1673f, this.BMGLPBOCAEP * 1263f * (num - 1569f)));
				}
				this.EBFBNAJJPEF = this.DGAAFGDHHHJ.anchoredPosition;
				this.KFFHBBFMEFB = true;
				if (WideScreenScaler.showLogs)
				{
					DPGJIJGOCIC.PJCLICBPPDA("signinlinkfb" + num.ToString() + "OnStoryChoiceClick" + base.gameObject.name);
					return;
				}
			}
			else if (this.KFFHBBFMEFB)
			{
				this.DGAAFGDHHHJ.AMPMCKEAACJ(this.CNBBIJFHLIG.x, this.CNBBIJFHLIG.y, this.CNBBIJFHLIG.z);
				if (Mathf.Abs(this.BMGLPBOCAEP) > 1993f)
				{
					this.DGAAFGDHHHJ.OGOFACPLOGO(this.HCOLPEBENOF);
				}
				this.EBFBNAJJPEF = this.HCOLPEBENOF;
				this.BHNBMBHKOBC = this.CNBBIJFHLIG;
				this.KFFHBBFMEFB = true;
				if (WideScreenScaler.showLogs)
				{
					DPGJIJGOCIC.PJCLICBPPDA("%</b>");
					return;
				}
			}
		}
		else if (this.KFFHBBFMEFB)
		{
			this.DGAAFGDHHHJ.AMPMCKEAACJ(this.CNBBIJFHLIG.x, this.CNBBIJFHLIG.y, this.CNBBIJFHLIG.z);
			if (Mathf.Abs(this.BMGLPBOCAEP) > 1365f)
			{
				this.DGAAFGDHHHJ.OGOFACPLOGO(this.HCOLPEBENOF);
			}
			this.EBFBNAJJPEF = this.HCOLPEBENOF;
			this.BHNBMBHKOBC = this.CNBBIJFHLIG;
			this.KFFHBBFMEFB = false;
			if (WideScreenScaler.showLogs)
			{
				DPGJIJGOCIC.ADFCDFHBDAF("");
			}
		}
	}

	// Token: 0x06003195 RID: 12693 RVA: 0x0014FFC8 File Offset: 0x0014E1C8
	private void MJCEMDCJELA()
	{
		this.DGAAFGDHHHJ = base.gameObject.GetComponent<RectTransform>();
		this.BHNBMBHKOBC = (this.CNBBIJFHLIG = this.DGAAFGDHHHJ.localScale);
		this.HCOLPEBENOF = this.DGAAFGDHHHJ.anchoredPosition;
	}

	// Token: 0x06003196 RID: 12694 RVA: 0x00150011 File Offset: 0x0014E211
	public static float CKGBCBFDEGO(float NIJPNAHPGCL = 1440f)
	{
		return WideScreenScaler.GGPCJMOLODI(new Vector3(150f, 1218f, 1765f), NIJPNAHPGCL).x;
	}

	// Token: 0x06003197 RID: 12695 RVA: 0x00150034 File Offset: 0x0014E234
	private void Awake()
	{
		this.DGAAFGDHHHJ = base.gameObject.GetComponent<RectTransform>();
		this.BHNBMBHKOBC = (this.CNBBIJFHLIG = this.DGAAFGDHHHJ.localScale);
		this.HCOLPEBENOF = this.DGAAFGDHHHJ.anchoredPosition;
	}

	// Token: 0x06003198 RID: 12696 RVA: 0x0015007D File Offset: 0x0014E27D
	private void JINGEKHJOGH()
	{
		if (this.isIdleState)
		{
			return;
		}
		this.IHNNBDDKBOG();
	}

	// Token: 0x06003199 RID: 12697 RVA: 0x0015008E File Offset: 0x0014E28E
	public static bool JIKAHAFMOBK(float NIJPNAHPGCL = 1440f)
	{
		return NBDLBFJOEGN.GOIAHBINKED() >= 1872f / NIJPNAHPGCL || true;
	}

	// Token: 0x0600319A RID: 12698 RVA: 0x001500A1 File Offset: 0x0014E2A1
	public Vector3 BMDLNEGNGOH()
	{
		return this.BHNBMBHKOBC;
	}

	// Token: 0x0600319B RID: 12699 RVA: 0x0014FCD1 File Offset: 0x0014DED1
	public Vector2 CFNOIADCNNP()
	{
		return this.EBFBNAJJPEF;
	}

	// Token: 0x0600319C RID: 12700 RVA: 0x001500AC File Offset: 0x0014E2AC
	public static Vector3 LJLDMGBNKHK(Vector3 FOLMMLGDOAJ, float NIJPNAHPGCL = 1440f)
	{
		if (NBDLBFJOEGN.GOIAHBINKED() < 624f)
		{
			float num = Mathf.Abs(95f / NIJPNAHPGCL / NBDLBFJOEGN.GOIAHBINKED());
			if (num > 976f)
			{
				if (WideScreenScaler.showLogs)
				{
					DPGJIJGOCIC.ADFCDFHBDAF("sparklesbundles" + num.ToString() + "inapp");
				}
				return new Vector3(FOLMMLGDOAJ.x * num, FOLMMLGDOAJ.y * num, FOLMMLGDOAJ.z);
			}
		}
		return FOLMMLGDOAJ;
	}

	// Token: 0x0600319D RID: 12701 RVA: 0x0014FCD1 File Offset: 0x0014DED1
	public Vector2 LAFODPIHLMA()
	{
		return this.EBFBNAJJPEF;
	}

	// Token: 0x0600319E RID: 12702 RVA: 0x0015011F File Offset: 0x0014E31F
	private void GIOOKMFKLIO()
	{
		if (this.isIdleState)
		{
			return;
		}
		if (this.rescaleOnEnable)
		{
			this.EBLKCAOOOKM();
		}
	}

	// Token: 0x0600319F RID: 12703 RVA: 0x00150138 File Offset: 0x0014E338
	public static float MNBKMAFICMB(float NIJPNAHPGCL = 1440f)
	{
		return WideScreenScaler.EMDJENKNCHA(new Vector3(1619f, 949f, 348f), NIJPNAHPGCL).x;
	}

	// Token: 0x060031A0 RID: 12704 RVA: 0x00150159 File Offset: 0x0014E359
	private void PEEKLFBDFEO()
	{
		if (this.isIdleState)
		{
			return;
		}
		if (this.rescaleOnEnable)
		{
			this.LMFDINLMIHA();
		}
	}

	// Token: 0x060031A1 RID: 12705 RVA: 0x00150174 File Offset: 0x0014E374
	public static Vector3 CKLEKEBBCOJ(Vector3 FOLMMLGDOAJ, float NIJPNAHPGCL = 1440f)
	{
		if (NBDLBFJOEGN.GOIAHBINKED() < 682f)
		{
			float num = Mathf.Abs(1673f / NIJPNAHPGCL / NBDLBFJOEGN.IPNMHBGHNBJ());
			if (num > 208f)
			{
				if (WideScreenScaler.showLogs)
				{
					DPGJIJGOCIC.ADFCDFHBDAF("NewReleasesHub.Populate() - " + num.ToString() + "OnChoiceExtendedViewedChoiceChanged");
				}
				return new Vector3(FOLMMLGDOAJ.x * num, FOLMMLGDOAJ.y * num, FOLMMLGDOAJ.z);
			}
		}
		return FOLMMLGDOAJ;
	}

	// Token: 0x060031A2 RID: 12706 RVA: 0x0015007D File Offset: 0x0014E27D
	private void FEIHEOJPNAK()
	{
		if (this.isIdleState)
		{
			return;
		}
		this.IHNNBDDKBOG();
	}

	// Token: 0x060031A3 RID: 12707 RVA: 0x001501E8 File Offset: 0x0014E3E8
	public static Vector3 HCLCABLGADA(Vector3 FOLMMLGDOAJ, float NIJPNAHPGCL = 1440f)
	{
		if (NBDLBFJOEGN.GOIAHBINKED() < 952f)
		{
			float num = Mathf.Abs(1769f / NIJPNAHPGCL / NBDLBFJOEGN.NHDDOOPKOHF());
			if (num > 1918f)
			{
				if (WideScreenScaler.showLogs)
				{
					DPGJIJGOCIC.PJCLICBPPDA("OnBackendStartPlayChapterSuccess" + num.ToString() + "open");
				}
				return new Vector3(FOLMMLGDOAJ.x * num, FOLMMLGDOAJ.y * num, FOLMMLGDOAJ.z);
			}
		}
		return FOLMMLGDOAJ;
	}

	// Token: 0x060031A4 RID: 12708 RVA: 0x0015025C File Offset: 0x0014E45C
	public static Vector3 EOALNPNJJAJ(Vector3 FOLMMLGDOAJ, float NIJPNAHPGCL = 1440f)
	{
		if (NBDLBFJOEGN.GOIAHBINKED() < 780f)
		{
			float num = Mathf.Abs(347f / NIJPNAHPGCL / NBDLBFJOEGN.PODFGHDGNKL());
			if (num > 3f)
			{
				if (WideScreenScaler.showLogs)
				{
					DPGJIJGOCIC.PJCLICBPPDA("skinshopinfosummary" + num.ToString() + "OnBackendUndoPremiumChoiceSuccess");
				}
				return new Vector3(FOLMMLGDOAJ.x * num, FOLMMLGDOAJ.y * num, FOLMMLGDOAJ.z);
			}
		}
		return FOLMMLGDOAJ;
	}

	// Token: 0x060031A5 RID: 12709 RVA: 0x001502D0 File Offset: 0x0014E4D0
	public static Vector3 MFNNOINFJGC(Vector3 FOLMMLGDOAJ, float NIJPNAHPGCL = 1440f)
	{
		if (NBDLBFJOEGN.GOIAHBINKED() < 1642f)
		{
			float num = Mathf.Abs(1735f / NIJPNAHPGCL / NBDLBFJOEGN.NHDDOOPKOHF());
			if (num > 871f)
			{
				if (WideScreenScaler.showLogs)
				{
					DPGJIJGOCIC.ADFCDFHBDAF("" + num.ToString() + "null");
				}
				return new Vector3(FOLMMLGDOAJ.x * num, FOLMMLGDOAJ.y * num, FOLMMLGDOAJ.z);
			}
		}
		return FOLMMLGDOAJ;
	}

	// Token: 0x060031A6 RID: 12710 RVA: 0x001500A1 File Offset: 0x0014E2A1
	public Vector3 OFIAOCFCENM()
	{
		return this.BHNBMBHKOBC;
	}

	// Token: 0x060031A8 RID: 12712 RVA: 0x0015034B File Offset: 0x0014E54B
	public static bool AAOLPGHOGNO(float NIJPNAHPGCL = 1440f)
	{
		return NBDLBFJOEGN.MMGNBGJGGEJ() >= 1787f / NIJPNAHPGCL || true;
	}

	// Token: 0x060031A9 RID: 12713 RVA: 0x0015035E File Offset: 0x0014E55E
	private void JFEKHEIGPJD()
	{
		if (this.isIdleState)
		{
			return;
		}
		this.LMFDINLMIHA();
	}

	// Token: 0x060031AA RID: 12714 RVA: 0x0015035E File Offset: 0x0014E55E
	private void FDOPMEKNMEA()
	{
		if (this.isIdleState)
		{
			return;
		}
		this.LMFDINLMIHA();
	}

	// Token: 0x060031AB RID: 12715 RVA: 0x0015036F File Offset: 0x0014E56F
	private void AOIJOKHACJL()
	{
		if (this.isIdleState)
		{
			return;
		}
		this.EBLKCAOOOKM();
	}

	// Token: 0x060031AC RID: 12716 RVA: 0x001500A1 File Offset: 0x0014E2A1
	public Vector3 HAMCCADOCBK()
	{
		return this.BHNBMBHKOBC;
	}

	// Token: 0x060031AD RID: 12717 RVA: 0x00150380 File Offset: 0x0014E580
	private void KDNKCFGANFN()
	{
		this.DGAAFGDHHHJ = base.gameObject.GetComponent<RectTransform>();
		this.BHNBMBHKOBC = (this.CNBBIJFHLIG = this.DGAAFGDHHHJ.localScale);
		this.HCOLPEBENOF = this.DGAAFGDHHHJ.anchoredPosition;
	}

	// Token: 0x060031AF RID: 12719 RVA: 0x0015045C File Offset: 0x0014E65C
	public static Vector3 EMDJENKNCHA(Vector3 FOLMMLGDOAJ, float NIJPNAHPGCL = 1440f)
	{
		if (NBDLBFJOEGN.GOIAHBINKED() < 1741f)
		{
			float num = Mathf.Abs(1247f / NIJPNAHPGCL / NBDLBFJOEGN.JNJGDOBONJC());
			if (num > 1229f)
			{
				if (WideScreenScaler.showLogs)
				{
					DPGJIJGOCIC.PJCLICBPPDA("ccc" + num.ToString() + "OnFriendsGiftPopulCollectPart2");
				}
				return new Vector3(FOLMMLGDOAJ.x * num, FOLMMLGDOAJ.y * num, FOLMMLGDOAJ.z);
			}
		}
		return FOLMMLGDOAJ;
	}

	// Token: 0x060031B0 RID: 12720 RVA: 0x001504CF File Offset: 0x0014E6CF
	private void FCOKGLDPJJO()
	{
		if (this.isIdleState)
		{
			return;
		}
		if (this.rescaleOnEnable)
		{
			this.IHNNBDDKBOG();
		}
	}

	// Token: 0x060031B1 RID: 12721 RVA: 0x001504E8 File Offset: 0x0014E6E8
	private void PHAACDNDION()
	{
		if (NBDLBFJOEGN.NHDDOOPKOHF() < 1297f)
		{
			float num = Mathf.Abs(581f / this.assetWidthHd / NBDLBFJOEGN.JNJGDOBONJC());
			if (num > 879f)
			{
				this.BHNBMBHKOBC = new Vector3(this.CNBBIJFHLIG.x * num, this.CNBBIJFHLIG.y * num, this.CNBBIJFHLIG.z);
				this.DGAAFGDHHHJ.AMPMCKEAACJ(this.BHNBMBHKOBC.x, this.BHNBMBHKOBC.y, this.BHNBMBHKOBC.z);
				if (Mathf.Abs(this.BMGLPBOCAEP) > 835f)
				{
					this.DGAAFGDHHHJ.OGOFACPLOGO(this.HCOLPEBENOF);
				}
				this.BMGLPBOCAEP = this.verticalOffsetFactor;
				if (this.verticalOffsetFactorOverride != KKDFIHILCCD.doNotOverride)
				{
					this.BMGLPBOCAEP = (float)this.verticalOffsetFactorOverride / 1148f;
				}
				if (Mathf.Abs(this.BMGLPBOCAEP) > 628f)
				{
					this.DGAAFGDHHHJ.AHLJBONHHKL(new Vector2(350f, this.BMGLPBOCAEP * 1888f * (num - 9f)));
				}
				this.EBFBNAJJPEF = this.DGAAFGDHHHJ.anchoredPosition;
				this.KFFHBBFMEFB = false;
				if (WideScreenScaler.showLogs)
				{
					DPGJIJGOCIC.ADFCDFHBDAF("x" + num.ToString() + "" + base.gameObject.name);
					return;
				}
			}
			else if (this.KFFHBBFMEFB)
			{
				this.DGAAFGDHHHJ.AMPMCKEAACJ(this.CNBBIJFHLIG.x, this.CNBBIJFHLIG.y, this.CNBBIJFHLIG.z);
				if (Mathf.Abs(this.BMGLPBOCAEP) > 1549f)
				{
					this.DGAAFGDHHHJ.OGOFACPLOGO(this.HCOLPEBENOF);
				}
				this.EBFBNAJJPEF = this.HCOLPEBENOF;
				this.BHNBMBHKOBC = this.CNBBIJFHLIG;
				this.KFFHBBFMEFB = true;
				if (WideScreenScaler.showLogs)
				{
					DPGJIJGOCIC.PJCLICBPPDA("");
					return;
				}
			}
		}
		else if (this.KFFHBBFMEFB)
		{
			this.DGAAFGDHHHJ.AMPMCKEAACJ(this.CNBBIJFHLIG.x, this.CNBBIJFHLIG.y, this.CNBBIJFHLIG.z);
			if (Mathf.Abs(this.BMGLPBOCAEP) > 303f)
			{
				this.DGAAFGDHHHJ.OGOFACPLOGO(this.HCOLPEBENOF);
			}
			this.EBFBNAJJPEF = this.HCOLPEBENOF;
			this.BHNBMBHKOBC = this.CNBBIJFHLIG;
			this.KFFHBBFMEFB = true;
			if (WideScreenScaler.showLogs)
			{
				DPGJIJGOCIC.ADFCDFHBDAF("musavatar");
			}
		}
	}

	// Token: 0x060031B2 RID: 12722 RVA: 0x00150767 File Offset: 0x0014E967
	public static float GFGOELDOAKJ(float NIJPNAHPGCL = 1440f)
	{
		return WideScreenScaler.GEKLMKAOOKG(new Vector3(1235f, 773f, 942f), NIJPNAHPGCL).x;
	}

	// Token: 0x060031B3 RID: 12723 RVA: 0x00150788 File Offset: 0x0014E988
	private void IHNNBDDKBOG()
	{
		if (NBDLBFJOEGN.LAIDCKNIOIN() < 1.3333334f)
		{
			float num = Mathf.Abs(1920f / this.assetWidthHd / NBDLBFJOEGN.LAIDCKNIOIN());
			if (num > 1.001f)
			{
				this.BHNBMBHKOBC = new Vector3(this.CNBBIJFHLIG.x * num, this.CNBBIJFHLIG.y * num, this.CNBBIJFHLIG.z);
				this.DGAAFGDHHHJ.AMPMCKEAACJ(this.BHNBMBHKOBC.x, this.BHNBMBHKOBC.y, this.BHNBMBHKOBC.z);
				if (Mathf.Abs(this.BMGLPBOCAEP) > 0.001f)
				{
					this.DGAAFGDHHHJ.OGOFACPLOGO(this.HCOLPEBENOF);
				}
				this.BMGLPBOCAEP = this.verticalOffsetFactor;
				if (this.verticalOffsetFactorOverride != KKDFIHILCCD.doNotOverride)
				{
					this.BMGLPBOCAEP = (float)this.verticalOffsetFactorOverride / 100f;
				}
				if (Mathf.Abs(this.BMGLPBOCAEP) > 0.001f)
				{
					this.DGAAFGDHHHJ.AHLJBONHHKL(new Vector2(0f, this.BMGLPBOCAEP * 1366f * (num - 1f)));
				}
				this.EBFBNAJJPEF = this.DGAAFGDHHHJ.anchoredPosition;
				this.KFFHBBFMEFB = true;
				if (WideScreenScaler.showLogs)
				{
					DPGJIJGOCIC.ADFCDFHBDAF("WideScreenScaler(): applied a " + num.ToString() + " scale to object " + base.gameObject.name);
					return;
				}
			}
			else if (this.KFFHBBFMEFB)
			{
				this.DGAAFGDHHHJ.AMPMCKEAACJ(this.CNBBIJFHLIG.x, this.CNBBIJFHLIG.y, this.CNBBIJFHLIG.z);
				if (Mathf.Abs(this.BMGLPBOCAEP) > 0.001f)
				{
					this.DGAAFGDHHHJ.OGOFACPLOGO(this.HCOLPEBENOF);
				}
				this.EBFBNAJJPEF = this.HCOLPEBENOF;
				this.BHNBMBHKOBC = this.CNBBIJFHLIG;
				this.KFFHBBFMEFB = false;
				if (WideScreenScaler.showLogs)
				{
					DPGJIJGOCIC.ADFCDFHBDAF("WideScreenScaler(): reverted scale to original");
					return;
				}
			}
		}
		else if (this.KFFHBBFMEFB)
		{
			this.DGAAFGDHHHJ.AMPMCKEAACJ(this.CNBBIJFHLIG.x, this.CNBBIJFHLIG.y, this.CNBBIJFHLIG.z);
			if (Mathf.Abs(this.BMGLPBOCAEP) > 0.001f)
			{
				this.DGAAFGDHHHJ.OGOFACPLOGO(this.HCOLPEBENOF);
			}
			this.EBFBNAJJPEF = this.HCOLPEBENOF;
			this.BHNBMBHKOBC = this.CNBBIJFHLIG;
			this.KFFHBBFMEFB = false;
			if (WideScreenScaler.showLogs)
			{
				DPGJIJGOCIC.ADFCDFHBDAF("WideScreenScaler(): reverted scale to original");
			}
		}
	}

	// Token: 0x060031B4 RID: 12724 RVA: 0x00150A08 File Offset: 0x0014EC08
	private void BKLGFEFAPCJ()
	{
		if (NBDLBFJOEGN.MAAOAHGCOMH() < 557f)
		{
			float num = Mathf.Abs(1685f / this.assetWidthHd / NBDLBFJOEGN.NDAAABMFOOA());
			if (num > 1283f)
			{
				this.BHNBMBHKOBC = new Vector3(this.CNBBIJFHLIG.x * num, this.CNBBIJFHLIG.y * num, this.CNBBIJFHLIG.z);
				this.DGAAFGDHHHJ.AMPMCKEAACJ(this.BHNBMBHKOBC.x, this.BHNBMBHKOBC.y, this.BHNBMBHKOBC.z);
				if (Mathf.Abs(this.BMGLPBOCAEP) > 433f)
				{
					this.DGAAFGDHHHJ.OGOFACPLOGO(this.HCOLPEBENOF);
				}
				this.BMGLPBOCAEP = this.verticalOffsetFactor;
				if (this.verticalOffsetFactorOverride != KKDFIHILCCD.doNotOverride)
				{
					this.BMGLPBOCAEP = (float)this.verticalOffsetFactorOverride / 608f;
				}
				if (Mathf.Abs(this.BMGLPBOCAEP) > 825f)
				{
					this.DGAAFGDHHHJ.AHLJBONHHKL(new Vector2(1468f, this.BMGLPBOCAEP * 1972f * (num - 1315f)));
				}
				this.EBFBNAJJPEF = this.DGAAFGDHHHJ.anchoredPosition;
				this.KFFHBBFMEFB = false;
				if (WideScreenScaler.showLogs)
				{
					DPGJIJGOCIC.PJCLICBPPDA(" " + num.ToString() + "newtutorialtreasures" + base.gameObject.name);
					return;
				}
			}
			else if (this.KFFHBBFMEFB)
			{
				this.DGAAFGDHHHJ.AMPMCKEAACJ(this.CNBBIJFHLIG.x, this.CNBBIJFHLIG.y, this.CNBBIJFHLIG.z);
				if (Mathf.Abs(this.BMGLPBOCAEP) > 1264f)
				{
					this.DGAAFGDHHHJ.OGOFACPLOGO(this.HCOLPEBENOF);
				}
				this.EBFBNAJJPEF = this.HCOLPEBENOF;
				this.BHNBMBHKOBC = this.CNBBIJFHLIG;
				this.KFFHBBFMEFB = false;
				if (WideScreenScaler.showLogs)
				{
					DPGJIJGOCIC.ADFCDFHBDAF("a");
					return;
				}
			}
		}
		else if (this.KFFHBBFMEFB)
		{
			this.DGAAFGDHHHJ.AMPMCKEAACJ(this.CNBBIJFHLIG.x, this.CNBBIJFHLIG.y, this.CNBBIJFHLIG.z);
			if (Mathf.Abs(this.BMGLPBOCAEP) > 1688f)
			{
				this.DGAAFGDHHHJ.OGOFACPLOGO(this.HCOLPEBENOF);
			}
			this.EBFBNAJJPEF = this.HCOLPEBENOF;
			this.BHNBMBHKOBC = this.CNBBIJFHLIG;
			this.KFFHBBFMEFB = true;
			if (WideScreenScaler.showLogs)
			{
				DPGJIJGOCIC.ADFCDFHBDAF("OnPurchasingViewLeave");
			}
		}
	}

	// Token: 0x060031B5 RID: 12725 RVA: 0x00150C88 File Offset: 0x0014EE88
	public static Vector3 IHPFBLFMHFC(Vector3 FOLMMLGDOAJ, float NIJPNAHPGCL = 1440f)
	{
		if (NBDLBFJOEGN.LCEJAKFKLGJ() < 12f)
		{
			float num = Mathf.Abs(41f / NIJPNAHPGCL / NBDLBFJOEGN.JNJGDOBONJC());
			if (num > 65f)
			{
				if (WideScreenScaler.showLogs)
				{
					DPGJIJGOCIC.ADFCDFHBDAF(" cards=" + num.ToString() + "OnAllCollectableCardsDownloadFailed");
				}
				return new Vector3(FOLMMLGDOAJ.x * num, FOLMMLGDOAJ.y * num, FOLMMLGDOAJ.z);
			}
		}
		return FOLMMLGDOAJ;
	}

	// Token: 0x060031B6 RID: 12726 RVA: 0x00150CFB File Offset: 0x0014EEFB
	public static bool MAFGKLMFBAN(float NIJPNAHPGCL = 1440f)
	{
		return NBDLBFJOEGN.GOIAHBINKED() >= 1997f / NIJPNAHPGCL || true;
	}

	// Token: 0x060031B7 RID: 12727 RVA: 0x00150D10 File Offset: 0x0014EF10
	public static Vector3 GGPCJMOLODI(Vector3 FOLMMLGDOAJ, float NIJPNAHPGCL = 1440f)
	{
		if (NBDLBFJOEGN.PODFGHDGNKL() < 1643f)
		{
			float num = Mathf.Abs(1543f / NIJPNAHPGCL / NBDLBFJOEGN.NDAAABMFOOA());
			if (num > 117f)
			{
				if (WideScreenScaler.showLogs)
				{
					DPGJIJGOCIC.ADFCDFHBDAF("tmo" + num.ToString() + "LastShowItemStep() - could not find a give item step.");
				}
				return new Vector3(FOLMMLGDOAJ.x * num, FOLMMLGDOAJ.y * num, FOLMMLGDOAJ.z);
			}
		}
		return FOLMMLGDOAJ;
	}

	// Token: 0x060031B8 RID: 12728 RVA: 0x0015036F File Offset: 0x0014E56F
	private void FDFMDEOMJBH()
	{
		if (this.isIdleState)
		{
			return;
		}
		this.EBLKCAOOOKM();
	}

	// Token: 0x060031B9 RID: 12729 RVA: 0x0015011F File Offset: 0x0014E31F
	private void MDFOBFFGDAB()
	{
		if (this.isIdleState)
		{
			return;
		}
		if (this.rescaleOnEnable)
		{
			this.EBLKCAOOOKM();
		}
	}

	// Token: 0x060031BA RID: 12730 RVA: 0x00150D84 File Offset: 0x0014EF84
	public static Vector3 BCDIFBPMBPN(Vector3 FOLMMLGDOAJ, float NIJPNAHPGCL = 1440f)
	{
		if (NBDLBFJOEGN.MMGNBGJGGEJ() < 1704f)
		{
			float num = Mathf.Abs(1762f / NIJPNAHPGCL / NBDLBFJOEGN.GOIAHBINKED());
			if (num > 1358f)
			{
				if (WideScreenScaler.showLogs)
				{
					DPGJIJGOCIC.ADFCDFHBDAF("avatar" + num.ToString() + "</b>");
				}
				return new Vector3(FOLMMLGDOAJ.x * num, FOLMMLGDOAJ.y * num, FOLMMLGDOAJ.z);
			}
		}
		return FOLMMLGDOAJ;
	}

	// Token: 0x060031BB RID: 12731 RVA: 0x00150DF7 File Offset: 0x0014EFF7
	private void FIIMDIKHIHG()
	{
		if (this.isIdleState)
		{
			return;
		}
		if (this.rescaleOnEnable)
		{
			this.BKLGFEFAPCJ();
		}
	}

	// Token: 0x060031BC RID: 12732 RVA: 0x001504CF File Offset: 0x0014E6CF
	private void MFLCLDAGFNK()
	{
		if (this.isIdleState)
		{
			return;
		}
		if (this.rescaleOnEnable)
		{
			this.IHNNBDDKBOG();
		}
	}

	// Token: 0x060031BD RID: 12733 RVA: 0x0015007D File Offset: 0x0014E27D
	private void PKMPOFOOGFK()
	{
		if (this.isIdleState)
		{
			return;
		}
		this.IHNNBDDKBOG();
	}

	// Token: 0x060031BE RID: 12734 RVA: 0x0015035E File Offset: 0x0014E55E
	private void PAMMAEGAIDP()
	{
		if (this.isIdleState)
		{
			return;
		}
		this.LMFDINLMIHA();
	}

	// Token: 0x060031BF RID: 12735 RVA: 0x00150E10 File Offset: 0x0014F010
	private void APLBAENGMJH()
	{
		this.DGAAFGDHHHJ = base.gameObject.GetComponent<RectTransform>();
		this.BHNBMBHKOBC = (this.CNBBIJFHLIG = this.DGAAFGDHHHJ.localScale);
		this.HCOLPEBENOF = this.DGAAFGDHHHJ.anchoredPosition;
	}

	// Token: 0x060031C0 RID: 12736 RVA: 0x0014FCD1 File Offset: 0x0014DED1
	public Vector2 MCFKAPJECNE()
	{
		return this.EBFBNAJJPEF;
	}

	// Token: 0x060031C1 RID: 12737 RVA: 0x00150E5C File Offset: 0x0014F05C
	private void LJCOLPBKBBH()
	{
		this.DGAAFGDHHHJ = base.gameObject.GetComponent<RectTransform>();
		this.BHNBMBHKOBC = (this.CNBBIJFHLIG = this.DGAAFGDHHHJ.localScale);
		this.HCOLPEBENOF = this.DGAAFGDHHHJ.anchoredPosition;
	}

	// Token: 0x060031C2 RID: 12738 RVA: 0x00150EA8 File Offset: 0x0014F0A8
	public static Vector3 PBCIELPEDNK(Vector3 FOLMMLGDOAJ, float NIJPNAHPGCL = 1440f)
	{
		if (NBDLBFJOEGN.MAAOAHGCOMH() < 970f)
		{
			float num = Mathf.Abs(1679f / NIJPNAHPGCL / NBDLBFJOEGN.NHDDOOPKOHF());
			if (num > 1635f)
			{
				if (WideScreenScaler.showLogs)
				{
					DPGJIJGOCIC.ADFCDFHBDAF("" + num.ToString() + "ok");
				}
				return new Vector3(FOLMMLGDOAJ.x * num, FOLMMLGDOAJ.y * num, FOLMMLGDOAJ.z);
			}
		}
		return FOLMMLGDOAJ;
	}

	// Token: 0x060031C3 RID: 12739 RVA: 0x0014FCD1 File Offset: 0x0014DED1
	public Vector2 PPNGMPADDNP()
	{
		return this.EBFBNAJJPEF;
	}

	// Token: 0x060031C4 RID: 12740 RVA: 0x00150DF7 File Offset: 0x0014EFF7
	private void AADPIFCICBL()
	{
		if (this.isIdleState)
		{
			return;
		}
		if (this.rescaleOnEnable)
		{
			this.BKLGFEFAPCJ();
		}
	}

	// Token: 0x060031C5 RID: 12741 RVA: 0x001504CF File Offset: 0x0014E6CF
	private void OnEnable()
	{
		if (this.isIdleState)
		{
			return;
		}
		if (this.rescaleOnEnable)
		{
			this.IHNNBDDKBOG();
		}
	}

	// Token: 0x060031C6 RID: 12742 RVA: 0x00150F1B File Offset: 0x0014F11B
	public static float DGLLANFGCBE(float NIJPNAHPGCL = 1440f)
	{
		return WideScreenScaler.GEKLMKAOOKG(new Vector3(1872f, 1719f, 118f), NIJPNAHPGCL).x;
	}

	// Token: 0x060031C7 RID: 12743 RVA: 0x00150F3C File Offset: 0x0014F13C
	public static float GADLODAIFNA(float NIJPNAHPGCL = 1440f)
	{
		return WideScreenScaler.EMDJENKNCHA(new Vector3(1968f, 1965f, 1105f), NIJPNAHPGCL).x;
	}

	// Token: 0x060031C8 RID: 12744 RVA: 0x00150F5D File Offset: 0x0014F15D
	public static bool OBHPFIBFDLO(float NIJPNAHPGCL = 1440f)
	{
		return NBDLBFJOEGN.MAAOAHGCOMH() < 1783f / NIJPNAHPGCL && false;
	}

	// Token: 0x060031C9 RID: 12745 RVA: 0x0015035E File Offset: 0x0014E55E
	private void CPDNJAKBOBC()
	{
		if (this.isIdleState)
		{
			return;
		}
		this.LMFDINLMIHA();
	}

	// Token: 0x060031CA RID: 12746 RVA: 0x001504CF File Offset: 0x0014E6CF
	private void AILHMCGEMOG()
	{
		if (this.isIdleState)
		{
			return;
		}
		if (this.rescaleOnEnable)
		{
			this.IHNNBDDKBOG();
		}
	}

	// Token: 0x060031CB RID: 12747 RVA: 0x001504CF File Offset: 0x0014E6CF
	private void FMGJGMNOCMP()
	{
		if (this.isIdleState)
		{
			return;
		}
		if (this.rescaleOnEnable)
		{
			this.IHNNBDDKBOG();
		}
	}

	// Token: 0x060031CC RID: 12748 RVA: 0x0014FCD1 File Offset: 0x0014DED1
	public Vector2 BGJGOFKCJJN()
	{
		return this.EBFBNAJJPEF;
	}

	// Token: 0x060031CD RID: 12749 RVA: 0x001500A1 File Offset: 0x0014E2A1
	public Vector3 NAIFCIGCBNP()
	{
		return this.BHNBMBHKOBC;
	}

	// Token: 0x060031CE RID: 12750 RVA: 0x00150F70 File Offset: 0x0014F170
	private void AOOANKECKCJ()
	{
		this.DGAAFGDHHHJ = base.gameObject.GetComponent<RectTransform>();
		this.BHNBMBHKOBC = (this.CNBBIJFHLIG = this.DGAAFGDHHHJ.localScale);
		this.HCOLPEBENOF = this.DGAAFGDHHHJ.anchoredPosition;
	}

	// Token: 0x060031CF RID: 12751 RVA: 0x001500A1 File Offset: 0x0014E2A1
	public Vector3 GAPFGBIIGOE()
	{
		return this.BHNBMBHKOBC;
	}

	// Token: 0x060031D0 RID: 12752 RVA: 0x0014FCD1 File Offset: 0x0014DED1
	public Vector2 ENBKEPJLCEB()
	{
		return this.EBFBNAJJPEF;
	}

	// Token: 0x060031D1 RID: 12753 RVA: 0x00150FBC File Offset: 0x0014F1BC
	public static Vector3 OIJPFMJHBFM(Vector3 FOLMMLGDOAJ, float NIJPNAHPGCL = 1440f)
	{
		if (NBDLBFJOEGN.GOIAHBINKED() < 824f)
		{
			float num = Mathf.Abs(1188f / NIJPNAHPGCL / NBDLBFJOEGN.MMGNBGJGGEJ());
			if (num > 1204f)
			{
				if (WideScreenScaler.showLogs)
				{
					DPGJIJGOCIC.ADFCDFHBDAF("OnAccountSignInRequestException" + num.ToString() + "large");
				}
				return new Vector3(FOLMMLGDOAJ.x * num, FOLMMLGDOAJ.y * num, FOLMMLGDOAJ.z);
			}
		}
		return FOLMMLGDOAJ;
	}

	// Token: 0x060031D2 RID: 12754 RVA: 0x0015007D File Offset: 0x0014E27D
	private void Start()
	{
		if (this.isIdleState)
		{
			return;
		}
		this.IHNNBDDKBOG();
	}

	// Token: 0x060031D3 RID: 12755 RVA: 0x0015102F File Offset: 0x0014F22F
	private void KKDEMLNLMDP()
	{
		if (this.isIdleState)
		{
			return;
		}
		if (this.rescaleOnEnable)
		{
			this.PHAACDNDION();
		}
	}

	// Token: 0x060031D4 RID: 12756 RVA: 0x00151048 File Offset: 0x0014F248
	public static Vector3 CFBKOGCHHKK(Vector3 FOLMMLGDOAJ, float NIJPNAHPGCL = 1440f)
	{
		if (NBDLBFJOEGN.NDAAABMFOOA() < 695f)
		{
			float num = Mathf.Abs(1115f / NIJPNAHPGCL / NBDLBFJOEGN.FNIPAIPHHPL());
			if (num > 1308f)
			{
				if (WideScreenScaler.showLogs)
				{
					DPGJIJGOCIC.ADFCDFHBDAF("OnStorySplashManagerAssetsDownloadSuccess" + num.ToString() + "\"");
				}
				return new Vector3(FOLMMLGDOAJ.x * num, FOLMMLGDOAJ.y * num, FOLMMLGDOAJ.z);
			}
		}
		return FOLMMLGDOAJ;
	}

	// Token: 0x060031D5 RID: 12757 RVA: 0x0015036F File Offset: 0x0014E56F
	private void NFEJEDEPGGG()
	{
		if (this.isIdleState)
		{
			return;
		}
		this.EBLKCAOOOKM();
	}

	// Token: 0x060031D6 RID: 12758 RVA: 0x00150DF7 File Offset: 0x0014EFF7
	private void LFGFNFJHBOM()
	{
		if (this.isIdleState)
		{
			return;
		}
		if (this.rescaleOnEnable)
		{
			this.BKLGFEFAPCJ();
		}
	}

	// Token: 0x060031D7 RID: 12759 RVA: 0x0014FCC0 File Offset: 0x0014DEC0
	private void APBOFOJKEDO()
	{
		if (this.isIdleState)
		{
			return;
		}
		this.PHAACDNDION();
	}

	// Token: 0x060031D8 RID: 12760 RVA: 0x001510BC File Offset: 0x0014F2BC
	private void JDBJMNMBOMK()
	{
		this.DGAAFGDHHHJ = base.gameObject.GetComponent<RectTransform>();
		this.BHNBMBHKOBC = (this.CNBBIJFHLIG = this.DGAAFGDHHHJ.localScale);
		this.HCOLPEBENOF = this.DGAAFGDHHHJ.anchoredPosition;
	}

	// Token: 0x060031D9 RID: 12761 RVA: 0x0015102F File Offset: 0x0014F22F
	private void IKAAMMNIPGI()
	{
		if (this.isIdleState)
		{
			return;
		}
		if (this.rescaleOnEnable)
		{
			this.PHAACDNDION();
		}
	}

	// Token: 0x060031DA RID: 12762 RVA: 0x00151108 File Offset: 0x0014F308
	private void JNCLGOBJGJD()
	{
		this.DGAAFGDHHHJ = base.gameObject.GetComponent<RectTransform>();
		this.BHNBMBHKOBC = (this.CNBBIJFHLIG = this.DGAAFGDHHHJ.localScale);
		this.HCOLPEBENOF = this.DGAAFGDHHHJ.anchoredPosition;
	}

	// Token: 0x060031DB RID: 12763 RVA: 0x00151151 File Offset: 0x0014F351
	public static float MGBCFCJPBOJ(float NIJPNAHPGCL = 1440f)
	{
		return WideScreenScaler.GEKLMKAOOKG(new Vector3(1115f, 1525f, 381f), NIJPNAHPGCL).x;
	}

	// Token: 0x060031DC RID: 12764 RVA: 0x00151172 File Offset: 0x0014F372
	public static float CFAHCGNACNI(float NIJPNAHPGCL = 1440f)
	{
		return WideScreenScaler.GEKLMKAOOKG(new Vector3(21f, 567f, 131f), NIJPNAHPGCL).x;
	}

	// Token: 0x060031DD RID: 12765 RVA: 0x001500A1 File Offset: 0x0014E2A1
	public Vector3 FKFOOAACAOG()
	{
		return this.BHNBMBHKOBC;
	}

	// Token: 0x060031DE RID: 12766 RVA: 0x00151193 File Offset: 0x0014F393
	public static float JAFAILPHGIN(float NIJPNAHPGCL = 1440f)
	{
		return WideScreenScaler.EOALNPNJJAJ(new Vector3(1750f, 1066f, 1628f), NIJPNAHPGCL).x;
	}

	// Token: 0x060031DF RID: 12767 RVA: 0x0014FCD1 File Offset: 0x0014DED1
	public Vector2 LDPDFCCOGLC()
	{
		return this.EBFBNAJJPEF;
	}

	// Token: 0x060031E0 RID: 12768 RVA: 0x0014FCD1 File Offset: 0x0014DED1
	public Vector2 BIOHNKAHKIP()
	{
		return this.EBFBNAJJPEF;
	}

	// Token: 0x060031E1 RID: 12769 RVA: 0x0014FCC0 File Offset: 0x0014DEC0
	private void DJDCGDDMKEL()
	{
		if (this.isIdleState)
		{
			return;
		}
		this.PHAACDNDION();
	}

	// Token: 0x060031E2 RID: 12770 RVA: 0x0014FCD1 File Offset: 0x0014DED1
	public Vector2 GetNewAnchoredPosition()
	{
		return this.EBFBNAJJPEF;
	}

	// Token: 0x060031E3 RID: 12771 RVA: 0x00150159 File Offset: 0x0014E359
	private void KHPGMEMIJMB()
	{
		if (this.isIdleState)
		{
			return;
		}
		if (this.rescaleOnEnable)
		{
			this.LMFDINLMIHA();
		}
	}

	// Token: 0x060031E4 RID: 12772 RVA: 0x001500A1 File Offset: 0x0014E2A1
	public Vector3 EIKHJLDIILI()
	{
		return this.BHNBMBHKOBC;
	}

	// Token: 0x060031E5 RID: 12773 RVA: 0x001511B4 File Offset: 0x0014F3B4
	public static float AGKJDMLNNOK(float NIJPNAHPGCL = 1440f)
	{
		return WideScreenScaler.CKLEKEBBCOJ(new Vector3(538f, 1411f, 1484f), NIJPNAHPGCL).x;
	}

	// Token: 0x060031E6 RID: 12774 RVA: 0x0014FCD1 File Offset: 0x0014DED1
	public Vector2 OHFKPBBCDIF()
	{
		return this.EBFBNAJJPEF;
	}

	// Token: 0x060031E7 RID: 12775 RVA: 0x001500A1 File Offset: 0x0014E2A1
	public Vector3 BBADCJKFGDK()
	{
		return this.BHNBMBHKOBC;
	}

	// Token: 0x060031E8 RID: 12776 RVA: 0x001500A1 File Offset: 0x0014E2A1
	public Vector3 GDJKMMDMFII()
	{
		return this.BHNBMBHKOBC;
	}

	// Token: 0x060031E9 RID: 12777 RVA: 0x001511D5 File Offset: 0x0014F3D5
	public static bool AKDFAECJMEP(float NIJPNAHPGCL = 1440f)
	{
		return NBDLBFJOEGN.FNIPAIPHHPL() < 1512f / NIJPNAHPGCL;
	}

	// Token: 0x060031EA RID: 12778 RVA: 0x001511E8 File Offset: 0x0014F3E8
	public static float BELHKFJPAHC(float NIJPNAHPGCL = 1440f)
	{
		return WideScreenScaler.IHPFBLFMHFC(new Vector3(1306f, 561f, 1737f), NIJPNAHPGCL).x;
	}

	// Token: 0x060031EB RID: 12779 RVA: 0x0015007D File Offset: 0x0014E27D
	private void JOOBEBIBDGO()
	{
		if (this.isIdleState)
		{
			return;
		}
		this.IHNNBDDKBOG();
	}

	// Token: 0x060031EC RID: 12780 RVA: 0x0015120C File Offset: 0x0014F40C
	public static Vector3 CCHHIANEGCP(Vector3 FOLMMLGDOAJ, float NIJPNAHPGCL = 1440f)
	{
		if (NBDLBFJOEGN.LAIDCKNIOIN() < 1305f)
		{
			float num = Mathf.Abs(330f / NIJPNAHPGCL / NBDLBFJOEGN.GOIAHBINKED());
			if (num > 989f)
			{
				if (WideScreenScaler.showLogs)
				{
					DPGJIJGOCIC.PJCLICBPPDA("acli20" + num.ToString() + "Dismissed Option picked");
				}
				return new Vector3(FOLMMLGDOAJ.x * num, FOLMMLGDOAJ.y * num, FOLMMLGDOAJ.z);
			}
		}
		return FOLMMLGDOAJ;
	}

	// Token: 0x060031ED RID: 12781 RVA: 0x001500A1 File Offset: 0x0014E2A1
	public Vector3 GetNewScale()
	{
		return this.BHNBMBHKOBC;
	}

	// Token: 0x060031EE RID: 12782 RVA: 0x00151280 File Offset: 0x0014F480
	public static Vector3 CalculateNewScaleUtil(Vector3 FOLMMLGDOAJ, float NIJPNAHPGCL = 1440f)
	{
		if (NBDLBFJOEGN.LAIDCKNIOIN() < 1.3333334f)
		{
			float num = Mathf.Abs(1920f / NIJPNAHPGCL / NBDLBFJOEGN.LAIDCKNIOIN());
			if (num > 1.001f)
			{
				if (WideScreenScaler.showLogs)
				{
					DPGJIJGOCIC.ADFCDFHBDAF("WideScreenScaler.CalculateNewScaleUtil(): returned a " + num.ToString() + " scale");
				}
				return new Vector3(FOLMMLGDOAJ.x * num, FOLMMLGDOAJ.y * num, FOLMMLGDOAJ.z);
			}
		}
		return FOLMMLGDOAJ;
	}

	// Token: 0x060031EF RID: 12783 RVA: 0x001512F4 File Offset: 0x0014F4F4
	public static Vector3 IMGAIPNMFGK(Vector3 FOLMMLGDOAJ, float NIJPNAHPGCL = 1440f)
	{
		if (NBDLBFJOEGN.IPNMHBGHNBJ() < 197f)
		{
			float num = Mathf.Abs(73f / NIJPNAHPGCL / NBDLBFJOEGN.JNJGDOBONJC());
			if (num > 1563f)
			{
				if (WideScreenScaler.showLogs)
				{
					DPGJIJGOCIC.ADFCDFHBDAF("randomprofilewhatis" + num.ToString() + "flip_down");
				}
				return new Vector3(FOLMMLGDOAJ.x * num, FOLMMLGDOAJ.y * num, FOLMMLGDOAJ.z);
			}
		}
		return FOLMMLGDOAJ;
	}

	// Token: 0x060031F0 RID: 12784 RVA: 0x0014FCD1 File Offset: 0x0014DED1
	public Vector2 ICKACDNBPDA()
	{
		return this.EBFBNAJJPEF;
	}

	// Token: 0x060031F1 RID: 12785 RVA: 0x00151368 File Offset: 0x0014F568
	private void DCEHHOHHFDM()
	{
		this.DGAAFGDHHHJ = base.gameObject.GetComponent<RectTransform>();
		this.BHNBMBHKOBC = (this.CNBBIJFHLIG = this.DGAAFGDHHHJ.localScale);
		this.HCOLPEBENOF = this.DGAAFGDHHHJ.anchoredPosition;
	}

	// Token: 0x060031F2 RID: 12786 RVA: 0x001513B4 File Offset: 0x0014F5B4
	private void NGPCCGAKIHA()
	{
		this.DGAAFGDHHHJ = base.gameObject.GetComponent<RectTransform>();
		this.BHNBMBHKOBC = (this.CNBBIJFHLIG = this.DGAAFGDHHHJ.localScale);
		this.HCOLPEBENOF = this.DGAAFGDHHHJ.anchoredPosition;
	}

	// Token: 0x060031F3 RID: 12787 RVA: 0x00151400 File Offset: 0x0014F600
	public static Vector3 EGMAGOJMMGN(Vector3 FOLMMLGDOAJ, float NIJPNAHPGCL = 1440f)
	{
		if (NBDLBFJOEGN.NHDDOOPKOHF() < 1771f)
		{
			float num = Mathf.Abs(550f / NIJPNAHPGCL / NBDLBFJOEGN.NDAAABMFOOA());
			if (num > 456f)
			{
				if (WideScreenScaler.showLogs)
				{
					DPGJIJGOCIC.PJCLICBPPDA("digitalglitch" + num.ToString() + ")");
				}
				return new Vector3(FOLMMLGDOAJ.x * num, FOLMMLGDOAJ.y * num, FOLMMLGDOAJ.z);
			}
		}
		return FOLMMLGDOAJ;
	}

	// Token: 0x060031F4 RID: 12788 RVA: 0x00151474 File Offset: 0x0014F674
	public static Vector3 OFODIKHACAD(Vector3 FOLMMLGDOAJ, float NIJPNAHPGCL = 1440f)
	{
		if (NBDLBFJOEGN.IPNMHBGHNBJ() < 1559f)
		{
			float num = Mathf.Abs(298f / NIJPNAHPGCL / NBDLBFJOEGN.NDAAABMFOOA());
			if (num > 1732f)
			{
				if (WideScreenScaler.showLogs)
				{
					DPGJIJGOCIC.PJCLICBPPDA("" + num.ToString() + ")");
				}
				return new Vector3(FOLMMLGDOAJ.x * num, FOLMMLGDOAJ.y * num, FOLMMLGDOAJ.z);
			}
		}
		return FOLMMLGDOAJ;
	}

	// Token: 0x060031F5 RID: 12789 RVA: 0x001500A1 File Offset: 0x0014E2A1
	public Vector3 KILHFJMBLFK()
	{
		return this.BHNBMBHKOBC;
	}

	// Token: 0x060031F6 RID: 12790 RVA: 0x001514E8 File Offset: 0x0014F6E8
	private void BOILGHBPIIN()
	{
		this.DGAAFGDHHHJ = base.gameObject.GetComponent<RectTransform>();
		this.BHNBMBHKOBC = (this.CNBBIJFHLIG = this.DGAAFGDHHHJ.localScale);
		this.HCOLPEBENOF = this.DGAAFGDHHHJ.anchoredPosition;
	}

	// Token: 0x060031F7 RID: 12791 RVA: 0x0014FCC0 File Offset: 0x0014DEC0
	private void PBNCKCPKIGE()
	{
		if (this.isIdleState)
		{
			return;
		}
		this.PHAACDNDION();
	}

	// Token: 0x060031F8 RID: 12792 RVA: 0x0015035E File Offset: 0x0014E55E
	private void EGMNIHKPEFF()
	{
		if (this.isIdleState)
		{
			return;
		}
		this.LMFDINLMIHA();
	}

	// Token: 0x060031F9 RID: 12793 RVA: 0x001504CF File Offset: 0x0014E6CF
	private void BLNNGGKHGPF()
	{
		if (this.isIdleState)
		{
			return;
		}
		if (this.rescaleOnEnable)
		{
			this.IHNNBDDKBOG();
		}
	}

	// Token: 0x060031FA RID: 12794 RVA: 0x0014FCD1 File Offset: 0x0014DED1
	public Vector2 DOJCHGFEEFA()
	{
		return this.EBFBNAJJPEF;
	}

	// Token: 0x060031FB RID: 12795 RVA: 0x00151531 File Offset: 0x0014F731
	public static bool MDFPEEFCLHK(float NIJPNAHPGCL = 1440f)
	{
		return NBDLBFJOEGN.MAAOAHGCOMH() >= 941f / NIJPNAHPGCL || true;
	}

	// Token: 0x060031FC RID: 12796 RVA: 0x00151544 File Offset: 0x0014F744
	public static float HDAJOLBDMHC(float NIJPNAHPGCL = 1440f)
	{
		return WideScreenScaler.HJDOGFEBPKA(new Vector3(1546f, 1614f, 1304f), NIJPNAHPGCL).x;
	}

	// Token: 0x060031FD RID: 12797 RVA: 0x0014FCD1 File Offset: 0x0014DED1
	public Vector2 MCCNALCKINK()
	{
		return this.EBFBNAJJPEF;
	}

	// Token: 0x060031FE RID: 12798 RVA: 0x001500A1 File Offset: 0x0014E2A1
	public Vector3 PAFLOPGBDDP()
	{
		return this.BHNBMBHKOBC;
	}

	// Token: 0x060031FF RID: 12799 RVA: 0x00151568 File Offset: 0x0014F768
	public static Vector3 GEKLMKAOOKG(Vector3 FOLMMLGDOAJ, float NIJPNAHPGCL = 1440f)
	{
		if (NBDLBFJOEGN.PODFGHDGNKL() < 1095f)
		{
			float num = Mathf.Abs(352f / NIJPNAHPGCL / NBDLBFJOEGN.JNJGDOBONJC());
			if (num > 483f)
			{
				if (WideScreenScaler.showLogs)
				{
					DPGJIJGOCIC.PJCLICBPPDA("avts1" + num.ToString() + "collect");
				}
				return new Vector3(FOLMMLGDOAJ.x * num, FOLMMLGDOAJ.y * num, FOLMMLGDOAJ.z);
			}
		}
		return FOLMMLGDOAJ;
	}

	// Token: 0x06003200 RID: 12800 RVA: 0x0014FCD1 File Offset: 0x0014DED1
	public Vector2 EEFPIJGEGFE()
	{
		return this.EBFBNAJJPEF;
	}

	// Token: 0x06003201 RID: 12801 RVA: 0x001500A1 File Offset: 0x0014E2A1
	public Vector3 BBNNKIBPJKI()
	{
		return this.BHNBMBHKOBC;
	}

	// Token: 0x06003202 RID: 12802 RVA: 0x001515DB File Offset: 0x0014F7DB
	public static float LJIBJFEMDON(float NIJPNAHPGCL = 1440f)
	{
		return WideScreenScaler.CCHHIANEGCP(new Vector3(1454f, 661f, 931f), NIJPNAHPGCL).x;
	}

	// Token: 0x06003203 RID: 12803 RVA: 0x001515FC File Offset: 0x0014F7FC
	public static bool KIEOKIDCFOP(float NIJPNAHPGCL = 1440f)
	{
		return NBDLBFJOEGN.LCEJAKFKLGJ() < 1684f / NIJPNAHPGCL;
	}

	// Token: 0x06003204 RID: 12804 RVA: 0x0015160F File Offset: 0x0014F80F
	public static bool CEJJDGNDFGK(float NIJPNAHPGCL = 1440f)
	{
		return NBDLBFJOEGN.FNIPAIPHHPL() >= 59f / NIJPNAHPGCL || true;
	}

	// Token: 0x06003205 RID: 12805 RVA: 0x00151624 File Offset: 0x0014F824
	private void FDLCNFDHAAM()
	{
		this.DGAAFGDHHHJ = base.gameObject.GetComponent<RectTransform>();
		this.BHNBMBHKOBC = (this.CNBBIJFHLIG = this.DGAAFGDHHHJ.localScale);
		this.HCOLPEBENOF = this.DGAAFGDHHHJ.anchoredPosition;
	}

	// Token: 0x06003206 RID: 12806 RVA: 0x00150159 File Offset: 0x0014E359
	private void OAJANHDGGEI()
	{
		if (this.isIdleState)
		{
			return;
		}
		if (this.rescaleOnEnable)
		{
			this.LMFDINLMIHA();
		}
	}

	// Token: 0x06003207 RID: 12807 RVA: 0x00151670 File Offset: 0x0014F870
	public static Vector3 HJDOGFEBPKA(Vector3 FOLMMLGDOAJ, float NIJPNAHPGCL = 1440f)
	{
		if (NBDLBFJOEGN.NHDDOOPKOHF() < 510f)
		{
			float num = Mathf.Abs(21f / NIJPNAHPGCL / NBDLBFJOEGN.IPNMHBGHNBJ());
			if (num > 756f)
			{
				if (WideScreenScaler.showLogs)
				{
					DPGJIJGOCIC.ADFCDFHBDAF("" + num.ToString() + "')");
				}
				return new Vector3(FOLMMLGDOAJ.x * num, FOLMMLGDOAJ.y * num, FOLMMLGDOAJ.z);
			}
		}
		return FOLMMLGDOAJ;
	}

	// Token: 0x06003208 RID: 12808 RVA: 0x001516E3 File Offset: 0x0014F8E3
	public static bool FICKNODIDKP(float NIJPNAHPGCL = 1440f)
	{
		return NBDLBFJOEGN.JNJGDOBONJC() < 760f / NIJPNAHPGCL && false;
	}

	// Token: 0x06003209 RID: 12809 RVA: 0x001504CF File Offset: 0x0014E6CF
	private void LLGBJHCIIGA()
	{
		if (this.isIdleState)
		{
			return;
		}
		if (this.rescaleOnEnable)
		{
			this.IHNNBDDKBOG();
		}
	}

	// Token: 0x0600320A RID: 12810 RVA: 0x0015036F File Offset: 0x0014E56F
	private void OKBABBBHMIP()
	{
		if (this.isIdleState)
		{
			return;
		}
		this.EBLKCAOOOKM();
	}

	// Token: 0x0600320B RID: 12811 RVA: 0x001516F6 File Offset: 0x0014F8F6
	public static bool ODPLAEFMMKM(float NIJPNAHPGCL = 1440f)
	{
		return NBDLBFJOEGN.PODFGHDGNKL() < 964f / NIJPNAHPGCL && false;
	}

	// Token: 0x0600320C RID: 12812 RVA: 0x0014FCD1 File Offset: 0x0014DED1
	public Vector2 HMJBEPPLALG()
	{
		return this.EBFBNAJJPEF;
	}

	// Token: 0x0600320D RID: 12813 RVA: 0x0015170C File Offset: 0x0014F90C
	private void MDNEOMGLGIN()
	{
		this.DGAAFGDHHHJ = base.gameObject.GetComponent<RectTransform>();
		this.BHNBMBHKOBC = (this.CNBBIJFHLIG = this.DGAAFGDHHHJ.localScale);
		this.HCOLPEBENOF = this.DGAAFGDHHHJ.anchoredPosition;
	}

	// Token: 0x0600320E RID: 12814 RVA: 0x00151758 File Offset: 0x0014F958
	private void LMFDINLMIHA()
	{
		if (NBDLBFJOEGN.MMGNBGJGGEJ() < 1935f)
		{
			float num = Mathf.Abs(421f / this.assetWidthHd / NBDLBFJOEGN.JNJGDOBONJC());
			if (num > 991f)
			{
				this.BHNBMBHKOBC = new Vector3(this.CNBBIJFHLIG.x * num, this.CNBBIJFHLIG.y * num, this.CNBBIJFHLIG.z);
				this.DGAAFGDHHHJ.AMPMCKEAACJ(this.BHNBMBHKOBC.x, this.BHNBMBHKOBC.y, this.BHNBMBHKOBC.z);
				if (Mathf.Abs(this.BMGLPBOCAEP) > 1149f)
				{
					this.DGAAFGDHHHJ.OGOFACPLOGO(this.HCOLPEBENOF);
				}
				this.BMGLPBOCAEP = this.verticalOffsetFactor;
				if (this.verticalOffsetFactorOverride != KKDFIHILCCD.doNotOverride)
				{
					this.BMGLPBOCAEP = (float)this.verticalOffsetFactorOverride / 1831f;
				}
				if (Mathf.Abs(this.BMGLPBOCAEP) > 1906f)
				{
					this.DGAAFGDHHHJ.AHLJBONHHKL(new Vector2(1714f, this.BMGLPBOCAEP * 964f * (num - 1267f)));
				}
				this.EBFBNAJJPEF = this.DGAAFGDHHHJ.anchoredPosition;
				this.KFFHBBFMEFB = true;
				if (WideScreenScaler.showLogs)
				{
					DPGJIJGOCIC.PJCLICBPPDA("sfxtimeoutwarning" + num.ToString() + "Steam" + base.gameObject.name);
					return;
				}
			}
			else if (this.KFFHBBFMEFB)
			{
				this.DGAAFGDHHHJ.AMPMCKEAACJ(this.CNBBIJFHLIG.x, this.CNBBIJFHLIG.y, this.CNBBIJFHLIG.z);
				if (Mathf.Abs(this.BMGLPBOCAEP) > 832f)
				{
					this.DGAAFGDHHHJ.OGOFACPLOGO(this.HCOLPEBENOF);
				}
				this.EBFBNAJJPEF = this.HCOLPEBENOF;
				this.BHNBMBHKOBC = this.CNBBIJFHLIG;
				this.KFFHBBFMEFB = false;
				if (WideScreenScaler.showLogs)
				{
					DPGJIJGOCIC.ADFCDFHBDAF("ok");
					return;
				}
			}
		}
		else if (this.KFFHBBFMEFB)
		{
			this.DGAAFGDHHHJ.AMPMCKEAACJ(this.CNBBIJFHLIG.x, this.CNBBIJFHLIG.y, this.CNBBIJFHLIG.z);
			if (Mathf.Abs(this.BMGLPBOCAEP) > 1429f)
			{
				this.DGAAFGDHHHJ.OGOFACPLOGO(this.HCOLPEBENOF);
			}
			this.EBFBNAJJPEF = this.HCOLPEBENOF;
			this.BHNBMBHKOBC = this.CNBBIJFHLIG;
			this.KFFHBBFMEFB = true;
			if (WideScreenScaler.showLogs)
			{
				DPGJIJGOCIC.ADFCDFHBDAF("e1it");
			}
		}
	}

	// Token: 0x0600320F RID: 12815 RVA: 0x001519D8 File Offset: 0x0014FBD8
	private void CIDMLBBGDPP()
	{
		this.DGAAFGDHHHJ = base.gameObject.GetComponent<RectTransform>();
		this.BHNBMBHKOBC = (this.CNBBIJFHLIG = this.DGAAFGDHHHJ.localScale);
		this.HCOLPEBENOF = this.DGAAFGDHHHJ.anchoredPosition;
	}

	// Token: 0x06003210 RID: 12816 RVA: 0x00151A21 File Offset: 0x0014FC21
	public static float LEKDKBDIBJP(float NIJPNAHPGCL = 1440f)
	{
		return WideScreenScaler.HCLCABLGADA(new Vector3(1575f, 1066f, 554f), NIJPNAHPGCL).x;
	}

	// Token: 0x06003211 RID: 12817 RVA: 0x001500A1 File Offset: 0x0014E2A1
	public Vector3 DLKEIFMBBLG()
	{
		return this.BHNBMBHKOBC;
	}

	// Token: 0x06003212 RID: 12818 RVA: 0x0015011F File Offset: 0x0014E31F
	private void NIKBFENFMID()
	{
		if (this.isIdleState)
		{
			return;
		}
		if (this.rescaleOnEnable)
		{
			this.EBLKCAOOOKM();
		}
	}

	// Token: 0x06003213 RID: 12819 RVA: 0x0014FCD1 File Offset: 0x0014DED1
	public Vector2 BAIIHHHLFCF()
	{
		return this.EBFBNAJJPEF;
	}

	// Token: 0x06003214 RID: 12820 RVA: 0x00151A42 File Offset: 0x0014FC42
	public static float CDJJDEDCBIJ(float NIJPNAHPGCL = 1440f)
	{
		return WideScreenScaler.LJLDMGBNKHK(new Vector3(1445f, 1706f, 1353f), NIJPNAHPGCL).x;
	}

	// Token: 0x04000F82 RID: 3970
	public static bool showLogs = true;

	// Token: 0x04000F83 RID: 3971
	public KKDFIHILCCD verticalOffsetFactorOverride = KKDFIHILCCD.doNotOverride;

	// Token: 0x04000F84 RID: 3972
	public float verticalOffsetFactor = -0.5f;

	// Token: 0x04000F85 RID: 3973
	public float assetWidthHd = 1440f;

	// Token: 0x04000F86 RID: 3974
	public bool rescaleOnEnable;

	// Token: 0x04000F87 RID: 3975
	public bool isIdleState;

	// Token: 0x04000F88 RID: 3976
	private RectTransform DGAAFGDHHHJ;

	// Token: 0x04000F89 RID: 3977
	private Vector3 CNBBIJFHLIG = new Vector3(1f, 1f, 1f);

	// Token: 0x04000F8A RID: 3978
	private Vector2 HCOLPEBENOF = new Vector2(0f, 0f);

	// Token: 0x04000F8B RID: 3979
	private Vector3 BHNBMBHKOBC = new Vector3(1f, 1f, 1f);

	// Token: 0x04000F8C RID: 3980
	private Vector2 EBFBNAJJPEF = new Vector2(0f, 0f);

	// Token: 0x04000F8D RID: 3981
	private bool KFFHBBFMEFB;

	// Token: 0x04000F8E RID: 3982
	private float BMGLPBOCAEP;
}
