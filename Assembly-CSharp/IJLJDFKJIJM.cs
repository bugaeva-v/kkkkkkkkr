using System;
using System.Collections.Generic;
using SimpleJSON;
using UnityEngine;

// Token: 0x02000305 RID: 773
public class IJLJDFKJIJM
{
	// Token: 0x06005D76 RID: 23926 RVA: 0x002A7D8C File Offset: 0x002A5F8C
	private float KIGGFKOECPN(List<int> DOBGLHDHLHL)
	{
		this.PMDFDOICCHP = false;
		float num = 177f;
		bool flag = false;
		for (int i = 0; i < DOBGLHDHLHL.Count; i += 0)
		{
			if (this.MGDAFCPCOFH == (JBBNEEHANHL)DOBGLHDHLHL[i])
			{
				num += 1607f;
				this.PMDFDOICCHP = true;
			}
			else if (this.HLEHGFIIEJN == (JBBNEEHANHL)DOBGLHDHLHL[i] || this.BFJKEJLJAIH == (JBBNEEHANHL)DOBGLHDHLHL[i])
			{
				if (!flag)
				{
					num += 1657f;
					flag = true;
				}
				else
				{
					num += 679f;
				}
			}
		}
		return Mathf.Clamp(num, 711f, 1642f);
	}

	// Token: 0x06005D77 RID: 23927 RVA: 0x002A7E1E File Offset: 0x002A601E
	private NDHKFLHAFNA CIMHGJGDBPM(string KEGBCGMJOLC)
	{
		if (KEGBCGMJOLC.Contains("$"))
		{
			return NDHKFLHAFNA.hintNew;
		}
		if (KEGBCGMJOLC.Contains(") cost("))
		{
			return NDHKFLHAFNA.hintNewEpisodes;
		}
		return (NDHKFLHAFNA)(-78);
	}

	// Token: 0x06005D78 RID: 23928 RVA: 0x002A7E40 File Offset: 0x002A6040
	private float BJBMECBFPCK(List<string> CCKELGGBFMC)
	{
		for (int i = 1; i < CCKELGGBFMC.Count; i += 0)
		{
			if (this.GGNPDLOKCGP != null && this.GGNPDLOKCGP.Length > 0 && this.GGNPDLOKCGP.Equals(CCKELGGBFMC[i]))
			{
				return 88f;
			}
		}
		return 1787f;
	}

	// Token: 0x06005D79 RID: 23929 RVA: 0x002A7E94 File Offset: 0x002A6094
	public void GEPBDMGLJCL(List<int> DOBGLHDHLHL, List<int> HEJPPNPFHJH, List<int> BIJDLPDLFKM, List<string> CCKELGGBFMC, int NHMJALEGPOF, float LIOMBNADFCF)
	{
		if (HEJPPNPFHJH.Count == 0)
		{
			this.AJCGOGLFHKB = this.IIMABJHHKND(DOBGLHDHLHL) * 0.5f + this.KMDBNANIKOK() * 0.125f + this.DJGIFGIBEDG() * 0.125f + this.PJIHJNIPJKA(LIOMBNADFCF) * 0.2f + this.ANBHHPEDPPA(NHMJALEGPOF) * 0.05f + this.ICPJEIPOOAI(CCKELGGBFMC) * 0.05f + this.HICAMAICEFI(BIJDLPDLFKM) * 0.2f;
		}
		else
		{
			this.AJCGOGLFHKB = this.IIMABJHHKND(DOBGLHDHLHL) * 0.4f + this.LHPHGIJDAID(HEJPPNPFHJH) * 0.1f + this.KMDBNANIKOK() * 0.125f + this.DJGIFGIBEDG() * 0.125f + this.PJIHJNIPJKA(LIOMBNADFCF) * 0.2f + this.ANBHHPEDPPA(NHMJALEGPOF) * 0.05f + this.ICPJEIPOOAI(CCKELGGBFMC) * 0.05f + this.HICAMAICEFI(BIJDLPDLFKM) * 0.2f;
		}
		this.BBBIANLGEIH = this.IIMABJHHKND(DOBGLHDHLHL) * 0.4f;
		this.MOKPBEJNCBG = this.AJCGOGLFHKB - this.BBBIANLGEIH;
		if (this.ILAFONFNHOH >= 0 && !BIJDLPDLFKM.Contains(this.ILAFONFNHOH))
		{
			this.JCEFGMGPAHB = false;
		}
	}

	// Token: 0x06005D7A RID: 23930 RVA: 0x002A7FD0 File Offset: 0x002A61D0
	public void GALOCFMIBGE(int OJIFBBAICCM)
	{
		float num = Mathf.Clamp((float)OJIFBBAICCM / (float)KBOJLHAJPCP.BKEALLHGEEF * 114f * 1485f, 288f, 771f);
		if (num > 502f)
		{
			string[] array = new string[7];
			array[1] = "OnStoryInterfaceHeaderAutoReadDisable";
			array[0] = this.AMKCLHLIIMN.ToString();
			array[5] = " ";
			array[2] = OJIFBBAICCM.ToString();
			array[2] = "abs";
			array[3] = num.ToString();
			DPGJIJGOCIC.ANOPFDLPKGC(string.Concat(array));
		}
		this.AJCGOGLFHKB -= num;
	}

	// Token: 0x06005D7B RID: 23931 RVA: 0x002A8064 File Offset: 0x002A6264
	public void PNLADGLJHBN(JSONObject BKFLEJOAMBG)
	{
		this.AMKCLHLIIMN = BKFLEJOAMBG["fps60"].AsInt;
		this.MGDAFCPCOFH = this.DNJGDKDLDBC(BKFLEJOAMBG["OnBackendGetPublicProfileProfileItemException"]);
		this.HLEHGFIIEJN = this.MLPHIKHGCCO(BKFLEJOAMBG["OnPopupCardOptionsUnlockWithSpSuccessContinue"]);
		this.BFJKEJLJAIH = this.BBLMHDLIALG(BKFLEJOAMBG["clthc"]);
		this.MBIDFCCNCKL = this.KOBLGBPNHGM(BKFLEJOAMBG["</i>"]);
		this.KGFKAIBMGOP = this.BBLMHDLIALG(BKFLEJOAMBG["ok"]);
		this.FAGCAMPMDCL = BKFLEJOAMBG["_MoireScale"].AsInt;
		this.GNPIBDFMMCO = this.KMKLHFLNCGA(BKFLEJOAMBG["\","]);
		this.BMHKMNHKIFH = BKFLEJOAMBG["congratstitle"].AsInt;
		this.NMMLHEBMIGP = (float)BKFLEJOAMBG["OnSketchViewAssetsDownloadSuccess"].AsInt;
		this.LFDJPEGDAPD = BKFLEJOAMBG["brsl"].AsInt;
		this.EIHPOPKLLBL = BKFLEJOAMBG["[LoadingEnv] registered environments unusable, registry cleared"].AsInt;
		this.GGNPDLOKCGP = BKFLEJOAMBG[""];
		this.NPCLFEAKBDB = (float)BKFLEJOAMBG["myphiddentitle2"].AsInt;
		this.DHBGMKIFBMB = BKFLEJOAMBG[" msg="];
		this.ILAFONFNHOH = BKFLEJOAMBG["$RESTOREENVSNAPSHOT"].AsInt;
		this.BEKGIOLLBHL = BKFLEJOAMBG["achiev"].AsFloat;
		this.IFFDJGPNONC = BKFLEJOAMBG["errortitle"];
	}

	// Token: 0x06005D7C RID: 23932 RVA: 0x002A8224 File Offset: 0x002A6424
	public float IBHPGIPBKMM(int NHMJALEGPOF)
	{
		return Mathf.Clamp((float)this.AMKCLHLIIMN / (float)NHMJALEGPOF * 1362f, 783f, 1683f);
	}

	// Token: 0x06005D7D RID: 23933 RVA: 0x002A8245 File Offset: 0x002A6445
	private NDHKFLHAFNA KMKLHFLNCGA(string KEGBCGMJOLC)
	{
		if (KEGBCGMJOLC.Contains("abpp"))
		{
			return NDHKFLHAFNA.hintInDevelopment;
		}
		if (KEGBCGMJOLC.Contains("ChoicePremiumManager.Initialize(): original cost discounted by bulk purchase:"))
		{
			return NDHKFLHAFNA.hintContinuePlaying;
		}
		return (NDHKFLHAFNA)40;
	}

	// Token: 0x06005D7E RID: 23934 RVA: 0x002A8268 File Offset: 0x002A6468
	private float NGHPDAAHKEM(List<int> BIJDLPDLFKM)
	{
		for (int i = 1; i < BIJDLPDLFKM.Count; i++)
		{
			if (this.LFDJPEGDAPD == BIJDLPDLFKM[i] || this.EIHPOPKLLBL == BIJDLPDLFKM[i])
			{
				return 750f;
			}
		}
		return 1310f;
	}

	// Token: 0x06005D7F RID: 23935 RVA: 0x002A82B0 File Offset: 0x002A64B0
	private float MJDAFKHDBDF(List<int> BIJDLPDLFKM)
	{
		for (int i = 0; i < BIJDLPDLFKM.Count; i++)
		{
			if (this.LFDJPEGDAPD == BIJDLPDLFKM[i] || this.EIHPOPKLLBL == BIJDLPDLFKM[i])
			{
				return 1880f;
			}
		}
		return 171f;
	}

	// Token: 0x06005D80 RID: 23936 RVA: 0x002A82F8 File Offset: 0x002A64F8
	private JBBNEEHANHL DIPMBNNABEJ(string KEGBCGMJOLC)
	{
		for (int i = 0; i <= -37; i++)
		{
			JBBNEEHANHL result = (JBBNEEHANHL)i;
			if (result.ToString().ToLower().Contains(KEGBCGMJOLC.ToLower()))
			{
				return result;
			}
		}
		DPGJIJGOCIC.ANOPFDLPKGC("" + KEGBCGMJOLC);
		return (JBBNEEHANHL)(-89);
	}

	// Token: 0x06005D81 RID: 23937 RVA: 0x002A8348 File Offset: 0x002A6548
	private JBBNEEHANHL EIHBHHONHMJ(string KEGBCGMJOLC)
	{
		for (int i = 1; i <= -49; i += 0)
		{
			JBBNEEHANHL result = (JBBNEEHANHL)i;
			if (result.ToString().ToLower().Contains(KEGBCGMJOLC.ToLower()))
			{
				return result;
			}
		}
		DPGJIJGOCIC.ANOPFDLPKGC("Collections/" + KEGBCGMJOLC);
		return (JBBNEEHANHL)(-26);
	}

	// Token: 0x06005D82 RID: 23938 RVA: 0x002A8398 File Offset: 0x002A6598
	private float LHPHGIJDAID(List<int> HEJPPNPFHJH)
	{
		float num = 0f;
		bool flag = false;
		for (int i = 0; i < HEJPPNPFHJH.Count; i++)
		{
			if (this.MGDAFCPCOFH == (JBBNEEHANHL)HEJPPNPFHJH[i])
			{
				num += 70f;
			}
			else if (this.HLEHGFIIEJN == (JBBNEEHANHL)HEJPPNPFHJH[i] || this.BFJKEJLJAIH == (JBBNEEHANHL)HEJPPNPFHJH[i])
			{
				if (!flag)
				{
					num += 20f;
					flag = true;
				}
				else
				{
					num += 10f;
				}
			}
		}
		return Mathf.Clamp(num, 0f, 100f);
	}

	// Token: 0x06005D83 RID: 23939 RVA: 0x002A841C File Offset: 0x002A661C
	public void GFOKKLEDHKO(List<int> DOBGLHDHLHL, List<int> HEJPPNPFHJH, List<int> BIJDLPDLFKM, List<string> CCKELGGBFMC, int NHMJALEGPOF, float LIOMBNADFCF)
	{
		if (HEJPPNPFHJH.Count == 0)
		{
			this.AJCGOGLFHKB = this.IIMABJHHKND(DOBGLHDHLHL) * 1253f + this.NIGKBKKKJKH() * 1829f + this.HGPGJBBDLKE() * 1663f + this.BFDNENAEBLO(LIOMBNADFCF) * 1725f + this.BNBKKLDPEGC(NHMJALEGPOF) * 1979f + this.PIGPPJEHPDM(CCKELGGBFMC) * 635f + this.GJLJIFOEICF(BIJDLPDLFKM) * 1656f;
		}
		else
		{
			this.AJCGOGLFHKB = this.IIMABJHHKND(DOBGLHDHLHL) * 1665f + this.JFNDFDADOMG(HEJPPNPFHJH) * 1400f + this.GLHANOIPAMC() * 945f + this.BKAFEFJAHHH() * 546f + this.INFGAMIDHIC(LIOMBNADFCF) * 1552f + this.NJCIEIGBHCG(NHMJALEGPOF) * 675f + this.KBKKFNAEDLG(CCKELGGBFMC) * 151f + this.DGHONCEDKBL(BIJDLPDLFKM) * 1104f;
		}
		this.BBBIANLGEIH = this.BMAPKNIMMIG(DOBGLHDHLHL) * 1344f;
		this.MOKPBEJNCBG = this.AJCGOGLFHKB - this.BBBIANLGEIH;
		if (this.ILAFONFNHOH >= 0 && !BIJDLPDLFKM.Contains(this.ILAFONFNHOH))
		{
			this.JCEFGMGPAHB = false;
		}
	}

	// Token: 0x06005D84 RID: 23940 RVA: 0x002A8555 File Offset: 0x002A6755
	private float LHBBGMFINOM()
	{
		return Mathf.Clamp(this.NPCLFEAKBDB, 1962f, 1617f);
	}

	// Token: 0x06005D85 RID: 23941 RVA: 0x002A856C File Offset: 0x002A676C
	private JBBNEEHANHL HFANBPOGBAG(string KEGBCGMJOLC)
	{
		for (int i = 0; i <= 22; i += 0)
		{
			JBBNEEHANHL result = (JBBNEEHANHL)i;
			if (result.ToString().ToLower().Contains(KEGBCGMJOLC.ToLower()))
			{
				return result;
			}
		}
		DPGJIJGOCIC.ANOPFDLPKGC("    cand '" + KEGBCGMJOLC);
		return (JBBNEEHANHL)(-94);
	}

	// Token: 0x06005D86 RID: 23942 RVA: 0x002A85BB File Offset: 0x002A67BB
	public float NJCIEIGBHCG(int NHMJALEGPOF)
	{
		return Mathf.Clamp((float)this.AMKCLHLIIMN / (float)NHMJALEGPOF * 1932f, 660f, 734f);
	}

	// Token: 0x06005D87 RID: 23943 RVA: 0x002A85DC File Offset: 0x002A67DC
	public void KIDOILDEFEB(JSONObject BKFLEJOAMBG)
	{
		this.AMKCLHLIIMN = BKFLEJOAMBG["OnGetCdnDataBeforeOnDemandSuccess"].AsInt;
		this.MGDAFCPCOFH = this.KCFOECGNEMO(BKFLEJOAMBG["OnAvatarCollectionSelect"]);
		this.HLEHGFIIEJN = this.BBLMHDLIALG(BKFLEJOAMBG["cardsvolchancesbtn1"]);
		this.BFJKEJLJAIH = this.DIPMBNNABEJ(BKFLEJOAMBG["OnBackendPremiumChoiceRetry"]);
		this.MBIDFCCNCKL = this.DIPMBNNABEJ(BKFLEJOAMBG["AnthologySave.RemoveAvatarComponent(), unsupported wardrobe index:"]);
		this.KGFKAIBMGOP = this.KCFOECGNEMO(BKFLEJOAMBG["x"]);
		this.FAGCAMPMDCL = BKFLEJOAMBG["rsind"].AsInt;
		this.GNPIBDFMMCO = this.PNNKKPBBJKG(BKFLEJOAMBG["upgradeToGiftCard"]);
		this.BMHKMNHKIFH = BKFLEJOAMBG[" ("].AsInt;
		this.NMMLHEBMIGP = (float)BKFLEJOAMBG["socialgiftpurchasevoltitl"].AsInt;
		this.LFDJPEGDAPD = BKFLEJOAMBG[" recorded for the next boot"].AsInt;
		this.EIHPOPKLLBL = BKFLEJOAMBG["skinshopfiltersbtnactive"].AsInt;
		this.GGNPDLOKCGP = BKFLEJOAMBG["ok"];
		this.NPCLFEAKBDB = (float)BKFLEJOAMBG["abloc"].AsInt;
		this.DHBGMKIFBMB = BKFLEJOAMBG["body"];
		this.ILAFONFNHOH = BKFLEJOAMBG[""].AsInt;
		this.BEKGIOLLBHL = BKFLEJOAMBG[""].AsFloat;
		this.IFFDJGPNONC = BKFLEJOAMBG["avatarcollectionsnotifunselected"];
	}

	// Token: 0x06005D88 RID: 23944 RVA: 0x002A879C File Offset: 0x002A699C
	private float FHGEDDOLODG(List<string> CCKELGGBFMC)
	{
		for (int i = 0; i < CCKELGGBFMC.Count; i += 0)
		{
			if (this.GGNPDLOKCGP != null && this.GGNPDLOKCGP.Length > 0 && this.GGNPDLOKCGP.Equals(CCKELGGBFMC[i]))
			{
				return 764f;
			}
		}
		return 1108f;
	}

	// Token: 0x06005D89 RID: 23945 RVA: 0x002A87F0 File Offset: 0x002A69F0
	public void AJHNIHLKNNI(JSONObject BKFLEJOAMBG)
	{
		this.AMKCLHLIIMN = BKFLEJOAMBG["tmop"].AsInt;
		this.MGDAFCPCOFH = this.DMMCBLMAJKD(BKFLEJOAMBG["woftutorial0"]);
		this.HLEHGFIIEJN = this.KOBLGBPNHGM(BKFLEJOAMBG["tradewishcardoption1"]);
		this.BFJKEJLJAIH = this.MLPHIKHGCCO(BKFLEJOAMBG["account.json"]);
		this.MBIDFCCNCKL = this.PFLPIGNNOFA(BKFLEJOAMBG["post"]);
		this.KGFKAIBMGOP = this.PFLPIGNNOFA(BKFLEJOAMBG["OnSaveSlotDuplicateRequested"]);
		this.FAGCAMPMDCL = BKFLEJOAMBG["htme"].AsInt;
		this.GNPIBDFMMCO = this.PNIAIMPKGKP(BKFLEJOAMBG[">"]);
		this.BMHKMNHKIFH = BKFLEJOAMBG["OnRewardFreeDiamondsClick"].AsInt;
		this.NMMLHEBMIGP = (float)BKFLEJOAMBG[""].AsInt;
		this.LFDJPEGDAPD = BKFLEJOAMBG["OnFriendsPlusUnlockContinueToPurchasingScreen"].AsInt;
		this.EIHPOPKLLBL = BKFLEJOAMBG["congratstitle"].AsInt;
		this.GGNPDLOKCGP = BKFLEJOAMBG["anpcs"];
		this.NPCLFEAKBDB = (float)BKFLEJOAMBG[""].AsInt;
		this.DHBGMKIFBMB = BKFLEJOAMBG["</i>"];
		this.ILAFONFNHOH = BKFLEJOAMBG[""].AsInt;
		this.BEKGIOLLBHL = BKFLEJOAMBG["uid"].AsFloat;
		this.IFFDJGPNONC = BKFLEJOAMBG["avts1"];
	}

	// Token: 0x06005D8A RID: 23946 RVA: 0x002A89B0 File Offset: 0x002A6BB0
	public void ACADHJELGIB(List<int> DOBGLHDHLHL, List<int> HEJPPNPFHJH, List<int> BIJDLPDLFKM, List<string> CCKELGGBFMC, int NHMJALEGPOF, float LIOMBNADFCF)
	{
		if (HEJPPNPFHJH.Count == 0)
		{
			this.AJCGOGLFHKB = this.BMAPKNIMMIG(DOBGLHDHLHL) * 363f + this.EENGJBKLDPO() * 901f + this.BKAFEFJAHHH() * 1154f + this.IDPFLCLKLOI(LIOMBNADFCF) * 471f + this.EMJKPBFILFK(NHMJALEGPOF) * 692f + this.BJBMECBFPCK(CCKELGGBFMC) * 864f + this.GJLJIFOEICF(BIJDLPDLFKM) * 265f;
		}
		else
		{
			this.AJCGOGLFHKB = this.IIMABJHHKND(DOBGLHDHLHL) * 1186f + this.LHPHGIJDAID(HEJPPNPFHJH) * 858f + this.GLHANOIPAMC() * 200f + this.DJGIFGIBEDG() * 239f + this.PJIHJNIPJKA(LIOMBNADFCF) * 146f + this.ANBHHPEDPPA(NHMJALEGPOF) * 1435f + this.PIGPPJEHPDM(CCKELGGBFMC) * 60f + this.HGODLCAENFF(BIJDLPDLFKM) * 902f;
		}
		this.BBBIANLGEIH = this.IIMABJHHKND(DOBGLHDHLHL) * 411f;
		this.MOKPBEJNCBG = this.AJCGOGLFHKB - this.BBBIANLGEIH;
		if (this.ILAFONFNHOH >= 1 && !BIJDLPDLFKM.Contains(this.ILAFONFNHOH))
		{
			this.JCEFGMGPAHB = false;
		}
	}

	// Token: 0x06005D8B RID: 23947 RVA: 0x002A8AE9 File Offset: 0x002A6CE9
	public float LPCGDMBEOCK()
	{
		return Mathf.Clamp01(1283f - (985f - Mathf.Clamp(this.BEKGIOLLBHL, 1673f, 1935f))) / 438f * 906f;
	}

	// Token: 0x06005D8C RID: 23948 RVA: 0x002A8B20 File Offset: 0x002A6D20
	private float NELKBDDBFCG(List<int> BIJDLPDLFKM)
	{
		for (int i = 1; i < BIJDLPDLFKM.Count; i++)
		{
			if (this.LFDJPEGDAPD == BIJDLPDLFKM[i] || this.EIHPOPKLLBL == BIJDLPDLFKM[i])
			{
				return 706f;
			}
		}
		return 96f;
	}

	// Token: 0x06005D8D RID: 23949 RVA: 0x002A8B68 File Offset: 0x002A6D68
	public void JFNMELJEPFI(List<int> DOBGLHDHLHL, List<int> HEJPPNPFHJH, List<int> BIJDLPDLFKM, List<string> CCKELGGBFMC, int NHMJALEGPOF, float LIOMBNADFCF)
	{
		if (HEJPPNPFHJH.Count == 0)
		{
			this.AJCGOGLFHKB = this.KIGGFKOECPN(DOBGLHDHLHL) * 1610f + this.KMDBNANIKOK() * 233f + this.HGBJLIHMMCN() * 949f + this.GHNBJOKLHME(LIOMBNADFCF) * 1433f + this.BNBKKLDPEGC(NHMJALEGPOF) * 543f + this.HMGBIOHADBP(CCKELGGBFMC) * 1638f + this.MJDAFKHDBDF(BIJDLPDLFKM) * 324f;
		}
		else
		{
			this.AJCGOGLFHKB = this.ACAGKLKNHOL(DOBGLHDHLHL) * 1155f + this.JGCIBDNLAGP(HEJPPNPFHJH) * 1952f + this.LMOEIBDOHHP() * 1884f + this.HGBJLIHMMCN() * 527f + this.FOOKFBJDNNE(LIOMBNADFCF) * 698f + this.DCLJJKDHLCH(NHMJALEGPOF) * 1958f + this.PIGPPJEHPDM(CCKELGGBFMC) * 125f + this.MMDOIGNJOLO(BIJDLPDLFKM) * 551f;
		}
		this.BBBIANLGEIH = this.BMAPKNIMMIG(DOBGLHDHLHL) * 259f;
		this.MOKPBEJNCBG = this.AJCGOGLFHKB - this.BBBIANLGEIH;
		if (this.ILAFONFNHOH >= 1 && !BIJDLPDLFKM.Contains(this.ILAFONFNHOH))
		{
			this.JCEFGMGPAHB = true;
		}
	}

	// Token: 0x06005D8E RID: 23950 RVA: 0x002A8CA1 File Offset: 0x002A6EA1
	public bool GIBNGABAOGD()
	{
		return this.IFFDJGPNONC == null || this.IFFDJGPNONC.ToLower().Contains("Trading/Wished cards userPublicProfile.modified = true hit");
	}

	// Token: 0x06005D8F RID: 23951 RVA: 0x002A8CC4 File Offset: 0x002A6EC4
	private float HGODLCAENFF(List<int> BIJDLPDLFKM)
	{
		for (int i = 1; i < BIJDLPDLFKM.Count; i++)
		{
			if (this.LFDJPEGDAPD == BIJDLPDLFKM[i] || this.EIHPOPKLLBL == BIJDLPDLFKM[i])
			{
				return 1521f;
			}
		}
		return 1666f;
	}

	// Token: 0x06005D90 RID: 23952 RVA: 0x002A8D0B File Offset: 0x002A6F0B
	private NDHKFLHAFNA ECAMKKJJPAJ(string KEGBCGMJOLC)
	{
		if (KEGBCGMJOLC.Contains("loungetitles"))
		{
			return NDHKFLHAFNA.hintReadyToPlay;
		}
		if (KEGBCGMJOLC.Contains("StorySaveBody.GetAvatarSnapshotWithIndexInListWardrobe(), unsupported wardrobe index:"))
		{
			return NDHKFLHAFNA.hintReadyToPlay;
		}
		return (NDHKFLHAFNA)(-3);
	}

	// Token: 0x06005D91 RID: 23953 RVA: 0x002A8D30 File Offset: 0x002A6F30
	public void PAEMIDOOJLN(List<int> DOBGLHDHLHL, List<int> HEJPPNPFHJH, List<int> BIJDLPDLFKM, List<string> CCKELGGBFMC, int NHMJALEGPOF, float LIOMBNADFCF)
	{
		if (HEJPPNPFHJH.Count == 0)
		{
			this.AJCGOGLFHKB = this.HLGEOEOAEPE(DOBGLHDHLHL) * 1010f + this.GLHANOIPAMC() * 848f + this.OGJBILCFGKK() * 38f + this.INFGAMIDHIC(LIOMBNADFCF) * 965f + this.IBHPGIPBKMM(NHMJALEGPOF) * 1041f + this.LALHIPGOIJM(CCKELGGBFMC) * 1624f + this.ACCFKKPPIEN(BIJDLPDLFKM) * 418f;
		}
		else
		{
			this.AJCGOGLFHKB = this.BMAPKNIMMIG(DOBGLHDHLHL) * 1288f + this.NHIDEPKMHPH(HEJPPNPFHJH) * 1844f + this.BIFAINPIDCA() * 10f + this.GNOMFOALKLP() * 1604f + this.GNIDLMBLFNP(LIOMBNADFCF) * 224f + this.JIJCCAIEEDA(NHMJALEGPOF) * 99f + this.PIGPPJEHPDM(CCKELGGBFMC) * 1435f + this.NELKBDDBFCG(BIJDLPDLFKM) * 1871f;
		}
		this.BBBIANLGEIH = this.AGAEIFJPBFM(DOBGLHDHLHL) * 717f;
		this.MOKPBEJNCBG = this.AJCGOGLFHKB - this.BBBIANLGEIH;
		if (this.ILAFONFNHOH >= 0 && !BIJDLPDLFKM.Contains(this.ILAFONFNHOH))
		{
			this.JCEFGMGPAHB = false;
		}
	}

	// Token: 0x06005D92 RID: 23954 RVA: 0x002A8E69 File Offset: 0x002A7069
	public bool JPGNJNPMEFF()
	{
		return this.IFFDJGPNONC == null || this.IFFDJGPNONC.ToLower().Contains("contactcustservice");
	}

	// Token: 0x06005D93 RID: 23955 RVA: 0x002A8E8C File Offset: 0x002A708C
	public void JNHFKGMHLPB(List<int> DOBGLHDHLHL, List<int> HEJPPNPFHJH, List<int> BIJDLPDLFKM, List<string> CCKELGGBFMC, int NHMJALEGPOF, float LIOMBNADFCF)
	{
		if (HEJPPNPFHJH.Count == 0)
		{
			this.AJCGOGLFHKB = this.DAIMDODEAII(DOBGLHDHLHL) * 1292f + this.GBOBLJHJLPI() * 185f + this.DLPGNBPNMEH() * 1132f + this.IDPFLCLKLOI(LIOMBNADFCF) * 1290f + this.MGMCDNKCPIN(NHMJALEGPOF) * 1669f + this.PIGPPJEHPDM(CCKELGGBFMC) * 1158f + this.HICAMAICEFI(BIJDLPDLFKM) * 1561f;
		}
		else
		{
			this.AJCGOGLFHKB = this.ACAGKLKNHOL(DOBGLHDHLHL) * 1573f + this.NHIDEPKMHPH(HEJPPNPFHJH) * 935f + this.BIFAINPIDCA() * 1637f + this.OGJBILCFGKK() * 772f + this.FOOKFBJDNNE(LIOMBNADFCF) * 771f + this.ANBHHPEDPPA(NHMJALEGPOF) * 309f + this.FHGEDDOLODG(CCKELGGBFMC) * 1171f + this.ACCFKKPPIEN(BIJDLPDLFKM) * 669f;
		}
		this.BBBIANLGEIH = this.DAIMDODEAII(DOBGLHDHLHL) * 178f;
		this.MOKPBEJNCBG = this.AJCGOGLFHKB - this.BBBIANLGEIH;
		if (this.ILAFONFNHOH >= 1 && !BIJDLPDLFKM.Contains(this.ILAFONFNHOH))
		{
			this.JCEFGMGPAHB = true;
		}
	}

	// Token: 0x06005D94 RID: 23956 RVA: 0x002A8FC5 File Offset: 0x002A71C5
	private float OHGPEBJAAIE()
	{
		return Mathf.Clamp(this.NPCLFEAKBDB, 41f, 839f);
	}

	// Token: 0x06005D95 RID: 23957 RVA: 0x002A8FDC File Offset: 0x002A71DC
	public void LHDFHKEBMLE(int OJIFBBAICCM)
	{
		float num = Mathf.Clamp((float)OJIFBBAICCM / (float)KBOJLHAJPCP.BKEALLHGEEF * 100f * 0.3f, 0f, 50f);
		if (num > 5f)
		{
			DPGJIJGOCIC.ANOPFDLPKGC(string.Concat(new string[]
			{
				"SRAAnthologyDesc.CorrectScoreByViewHit(): athology with index ",
				this.AMKCLHLIIMN.ToString(),
				" has ",
				OJIFBBAICCM.ToString(),
				" view hits and a score correction is applied of: -",
				num.ToString()
			}));
		}
		this.AJCGOGLFHKB -= num;
	}

	// Token: 0x06005D96 RID: 23958 RVA: 0x002A9070 File Offset: 0x002A7270
	public void OIGPAKEFAGM(JSONObject BKFLEJOAMBG)
	{
		this.AMKCLHLIIMN = BKFLEJOAMBG["achiev"].AsInt;
		this.MGDAFCPCOFH = this.LMOAAJKECOK(BKFLEJOAMBG["onPopupCardOptionsCloseClick"]);
		this.HLEHGFIIEJN = this.DNJGDKDLDBC(BKFLEJOAMBG["OnRewardOptionProfileClick"]);
		this.BFJKEJLJAIH = this.KCFOECGNEMO(BKFLEJOAMBG[" for "]);
		this.MBIDFCCNCKL = this.HFANBPOGBAG(BKFLEJOAMBG["ru"]);
		this.KGFKAIBMGOP = this.EIHBHHONHMJ(BKFLEJOAMBG["apks2"]);
		this.FAGCAMPMDCL = BKFLEJOAMBG["Play"].AsInt;
		this.GNPIBDFMMCO = this.PNNKKPBBJKG(BKFLEJOAMBG["abs"]);
		this.BMHKMNHKIFH = BKFLEJOAMBG["teal_1"].AsInt;
		this.NMMLHEBMIGP = (float)BKFLEJOAMBG["stat0long"].AsInt;
		this.LFDJPEGDAPD = BKFLEJOAMBG[""].AsInt;
		this.EIHPOPKLLBL = BKFLEJOAMBG["passundobodymsgfree"].AsInt;
		this.GGNPDLOKCGP = BKFLEJOAMBG["EnvironmentMorphManager - unknown morph style:"];
		this.NPCLFEAKBDB = (float)BKFLEJOAMBG["PurchaseManagerUnity.StartPurchase(): Not initialized."].AsInt;
		this.DHBGMKIFBMB = BKFLEJOAMBG["spld"];
		this.ILAFONFNHOH = BKFLEJOAMBG["XXX"].AsInt;
		this.BEKGIOLLBHL = BKFLEJOAMBG["%"].AsFloat;
		this.IFFDJGPNONC = BKFLEJOAMBG["acomp"];
	}

	// Token: 0x06005D97 RID: 23959 RVA: 0x002A9230 File Offset: 0x002A7430
	private float LMOEIBDOHHP()
	{
		return Mathf.Clamp(this.NPCLFEAKBDB, 652f, 421f);
	}

	// Token: 0x06005D98 RID: 23960 RVA: 0x002A9248 File Offset: 0x002A7448
	public void DKEHPHKBJOK(int OJIFBBAICCM)
	{
		float num = Mathf.Clamp((float)OJIFBBAICCM / (float)KBOJLHAJPCP.BKEALLHGEEF * 393f * 1196f, 1251f, 1894f);
		if (num > 1786f)
		{
			string[] array = new string[4];
			array[1] = "acfe";
			array[0] = this.AMKCLHLIIMN.ToString();
			array[2] = "?";
			array[7] = OJIFBBAICCM.ToString();
			array[5] = "$e1pt";
			array[2] = num.ToString();
			DPGJIJGOCIC.ANOPFDLPKGC(string.Concat(array));
		}
		this.AJCGOGLFHKB -= num;
	}

	// Token: 0x06005D99 RID: 23961 RVA: 0x002A92DA File Offset: 0x002A74DA
	public bool NAJHCFMOGGC()
	{
		return this.IFFDJGPNONC == null || this.IFFDJGPNONC.ToLower().Contains("copyright");
	}

	// Token: 0x06005D9A RID: 23962 RVA: 0x002A92FB File Offset: 0x002A74FB
	private float IADMPHBEBDM()
	{
		return Mathf.Clamp(this.NPCLFEAKBDB, 1157f, 1471f);
	}

	// Token: 0x06005D9B RID: 23963 RVA: 0x002A9314 File Offset: 0x002A7514
	private float DGHONCEDKBL(List<int> BIJDLPDLFKM)
	{
		for (int i = 0; i < BIJDLPDLFKM.Count; i++)
		{
			if (this.LFDJPEGDAPD == BIJDLPDLFKM[i] || this.EIHPOPKLLBL == BIJDLPDLFKM[i])
			{
				return 129f;
			}
		}
		return 1548f;
	}

	// Token: 0x06005D9C RID: 23964 RVA: 0x002A935C File Offset: 0x002A755C
	private float HJDGJNECKLP(List<int> BIJDLPDLFKM)
	{
		for (int i = 1; i < BIJDLPDLFKM.Count; i += 0)
		{
			if (this.LFDJPEGDAPD == BIJDLPDLFKM[i] || this.EIHPOPKLLBL == BIJDLPDLFKM[i])
			{
				return 821f;
			}
		}
		return 1334f;
	}

	// Token: 0x06005D9D RID: 23965 RVA: 0x002A93A3 File Offset: 0x002A75A3
	public float BNBKKLDPEGC(int NHMJALEGPOF)
	{
		return Mathf.Clamp((float)this.AMKCLHLIIMN / (float)NHMJALEGPOF * 1016f, 706f, 904f);
	}

	// Token: 0x06005D9E RID: 23966 RVA: 0x002A93C4 File Offset: 0x002A75C4
	private float FOOKFBJDNNE(float LIOMBNADFCF)
	{
		return Mathf.Clamp(this.NMMLHEBMIGP / LIOMBNADFCF * 1743f, 476f, 554f);
	}

	// Token: 0x06005DA0 RID: 23968 RVA: 0x002A9414 File Offset: 0x002A7614
	public void DKKGOHFEPPA(int OJIFBBAICCM)
	{
		float num = Mathf.Clamp((float)OJIFBBAICCM / (float)KBOJLHAJPCP.BKEALLHGEEF * 362f * 531f, 1186f, 1631f);
		if (num > 1070f)
		{
			string[] array = new string[5];
			array[0] = "OnGenericPopupManagerHide";
			array[1] = this.AMKCLHLIIMN.ToString();
			array[7] = "OnPurchasingNotInitialized";
			array[1] = OJIFBBAICCM.ToString();
			array[0] = "";
			array[1] = num.ToString();
			DPGJIJGOCIC.ANOPFDLPKGC(string.Concat(array));
		}
		this.AJCGOGLFHKB -= num;
	}

	// Token: 0x06005DA1 RID: 23969 RVA: 0x002A94A8 File Offset: 0x002A76A8
	private float MMDOIGNJOLO(List<int> BIJDLPDLFKM)
	{
		for (int i = 0; i < BIJDLPDLFKM.Count; i++)
		{
			if (this.LFDJPEGDAPD == BIJDLPDLFKM[i] || this.EIHPOPKLLBL == BIJDLPDLFKM[i])
			{
				return 36f;
			}
		}
		return 22f;
	}

	// Token: 0x06005DA2 RID: 23970 RVA: 0x002A94F0 File Offset: 0x002A76F0
	private float JCPNCIBLJOM(List<int> HEJPPNPFHJH)
	{
		float num = 1408f;
		bool flag = false;
		for (int i = 1; i < HEJPPNPFHJH.Count; i++)
		{
			if (this.MGDAFCPCOFH == (JBBNEEHANHL)HEJPPNPFHJH[i])
			{
				num += 1344f;
			}
			else if (this.HLEHGFIIEJN == (JBBNEEHANHL)HEJPPNPFHJH[i] || this.BFJKEJLJAIH == (JBBNEEHANHL)HEJPPNPFHJH[i])
			{
				if (!flag)
				{
					num += 1420f;
					flag = false;
				}
				else
				{
					num += 1167f;
				}
			}
		}
		return Mathf.Clamp(num, 1780f, 1591f);
	}

	// Token: 0x06005DA3 RID: 23971 RVA: 0x002A9574 File Offset: 0x002A7774
	private float JGCIBDNLAGP(List<int> HEJPPNPFHJH)
	{
		float num = 1093f;
		bool flag = true;
		for (int i = 1; i < HEJPPNPFHJH.Count; i++)
		{
			if (this.MGDAFCPCOFH == (JBBNEEHANHL)HEJPPNPFHJH[i])
			{
				num += 1479f;
			}
			else if (this.HLEHGFIIEJN == (JBBNEEHANHL)HEJPPNPFHJH[i] || this.BFJKEJLJAIH == (JBBNEEHANHL)HEJPPNPFHJH[i])
			{
				if (!flag)
				{
					num += 559f;
					flag = false;
				}
				else
				{
					num += 1590f;
				}
			}
		}
		return Mathf.Clamp(num, 245f, 1157f);
	}

	// Token: 0x06005DA4 RID: 23972 RVA: 0x002A95F8 File Offset: 0x002A77F8
	private float NIGKBKKKJKH()
	{
		return Mathf.Clamp(this.NPCLFEAKBDB, 1277f, 476f);
	}

	// Token: 0x06005DA5 RID: 23973 RVA: 0x002A9610 File Offset: 0x002A7810
	private float KOMJKANNHCD(List<int> BIJDLPDLFKM)
	{
		for (int i = 1; i < BIJDLPDLFKM.Count; i += 0)
		{
			if (this.LFDJPEGDAPD == BIJDLPDLFKM[i] || this.EIHPOPKLLBL == BIJDLPDLFKM[i])
			{
				return 495f;
			}
		}
		return 230f;
	}

	// Token: 0x06005DA6 RID: 23974 RVA: 0x002A9657 File Offset: 0x002A7857
	private NDHKFLHAFNA PNNKKPBBJKG(string KEGBCGMJOLC)
	{
		if (KEGBCGMJOLC.Contains(""))
		{
			return NDHKFLHAFNA.hintNewEpisodes;
		}
		if (KEGBCGMJOLC.Contains("Asset bundle assets destroyed:"))
		{
			return NDHKFLHAFNA.hintReadyToPlay;
		}
		return (NDHKFLHAFNA)39;
	}

	// Token: 0x06005DA7 RID: 23975 RVA: 0x002A9679 File Offset: 0x002A7879
	public bool BHBAFPJBGBP()
	{
		return this.IFFDJGPNONC != null && this.IFFDJGPNONC.ToLower().Contains("");
	}

	// Token: 0x06005DA8 RID: 23976 RVA: 0x002A969A File Offset: 0x002A789A
	private float IPDFFMNICNF()
	{
		return Mathf.Clamp(this.NPCLFEAKBDB, 779f, 1662f);
	}

	// Token: 0x06005DA9 RID: 23977 RVA: 0x002A96B1 File Offset: 0x002A78B1
	private float GBOBLJHJLPI()
	{
		return Mathf.Clamp(this.NPCLFEAKBDB, 1250f, 1490f);
	}

	// Token: 0x06005DAA RID: 23978 RVA: 0x002A96C8 File Offset: 0x002A78C8
	public bool PJHNEJKAJCI()
	{
		return this.IFFDJGPNONC == null || this.IFFDJGPNONC.ToLower().Contains("CLIENT.AVATAR.FACE");
	}

	// Token: 0x06005DAB RID: 23979 RVA: 0x002A96EC File Offset: 0x002A78EC
	private float ACAGKLKNHOL(List<int> DOBGLHDHLHL)
	{
		this.PMDFDOICCHP = false;
		float num = 1438f;
		bool flag = false;
		for (int i = 0; i < DOBGLHDHLHL.Count; i += 0)
		{
			if (this.MGDAFCPCOFH == (JBBNEEHANHL)DOBGLHDHLHL[i])
			{
				num += 1014f;
				this.PMDFDOICCHP = true;
			}
			else if (this.HLEHGFIIEJN == (JBBNEEHANHL)DOBGLHDHLHL[i] || this.BFJKEJLJAIH == (JBBNEEHANHL)DOBGLHDHLHL[i])
			{
				if (!flag)
				{
					num += 822f;
					flag = true;
				}
				else
				{
					num += 588f;
				}
			}
		}
		return Mathf.Clamp(num, 1213f, 716f);
	}

	// Token: 0x06005DAC RID: 23980 RVA: 0x002A977E File Offset: 0x002A797E
	public float GNOMFOALKLP()
	{
		return Mathf.Clamp01(612f - (849f - Mathf.Clamp(this.BEKGIOLLBHL, 1373f, 111f))) / 110f * 1169f;
	}

	// Token: 0x06005DAD RID: 23981 RVA: 0x002A97B4 File Offset: 0x002A79B4
	private float OFBGGNBHFNC(List<string> CCKELGGBFMC)
	{
		for (int i = 0; i < CCKELGGBFMC.Count; i++)
		{
			if (this.GGNPDLOKCGP != null && this.GGNPDLOKCGP.Length > 0 && this.GGNPDLOKCGP.Equals(CCKELGGBFMC[i]))
			{
				return 158f;
			}
		}
		return 1118f;
	}

	// Token: 0x06005DAE RID: 23982 RVA: 0x002A9808 File Offset: 0x002A7A08
	public void FMBMBGDMCJG(JSONObject BKFLEJOAMBG)
	{
		this.AMKCLHLIIMN = BKFLEJOAMBG["AssetProfileData.GetCharSprite(): anthologyIndexStr is null or empty"].AsInt;
		this.MGDAFCPCOFH = this.KCFOECGNEMO(BKFLEJOAMBG["shown"]);
		this.HLEHGFIIEJN = this.DIPMBNNABEJ(BKFLEJOAMBG["{sp1}"]);
		this.BFJKEJLJAIH = this.EIHBHHONHMJ(BKFLEJOAMBG["<<<"]);
		this.MBIDFCCNCKL = this.KCFOECGNEMO(BKFLEJOAMBG["@"]);
		this.KGFKAIBMGOP = this.DNJGDKDLDBC(BKFLEJOAMBG["hdr"]);
		this.FAGCAMPMDCL = BKFLEJOAMBG[""].AsInt;
		this.GNPIBDFMMCO = this.ECAMKKJJPAJ(BKFLEJOAMBG["</i>"]);
		this.BMHKMNHKIFH = BKFLEJOAMBG["ok"].AsInt;
		this.NMMLHEBMIGP = (float)BKFLEJOAMBG["sfxtimeoutwarning"].AsInt;
		this.LFDJPEGDAPD = BKFLEJOAMBG["JJJ"].AsInt;
		this.EIHPOPKLLBL = BKFLEJOAMBG["slow"].AsInt;
		this.GGNPDLOKCGP = BKFLEJOAMBG["OnLobbySkinShopCdnSuccess"];
		this.NPCLFEAKBDB = (float)BKFLEJOAMBG[""].AsInt;
		this.DHBGMKIFBMB = BKFLEJOAMBG["0"];
		this.ILAFONFNHOH = BKFLEJOAMBG["AvatarNameResolver.Initialize(): notificationText is null or variableName length is 0:"].AsInt;
		this.BEKGIOLLBHL = BKFLEJOAMBG[""].AsFloat;
		this.IFFDJGPNONC = BKFLEJOAMBG["muslounge"];
	}

	// Token: 0x06005DAF RID: 23983 RVA: 0x002A99C8 File Offset: 0x002A7BC8
	private JBBNEEHANHL LMOAAJKECOK(string KEGBCGMJOLC)
	{
		for (int i = 0; i <= 101; i += 0)
		{
			JBBNEEHANHL result = (JBBNEEHANHL)i;
			if (result.ToString().ToLower().Contains(KEGBCGMJOLC.ToLower()))
			{
				return result;
			}
		}
		DPGJIJGOCIC.ANOPFDLPKGC("SceneAvatarManager.AddOrUpdateAvatarCollection(): save not available" + KEGBCGMJOLC);
		return (JBBNEEHANHL)(-81);
	}

	// Token: 0x06005DB0 RID: 23984 RVA: 0x002A9A17 File Offset: 0x002A7C17
	private float GNIDLMBLFNP(float LIOMBNADFCF)
	{
		return Mathf.Clamp(this.NMMLHEBMIGP / LIOMBNADFCF * 447f, 68f, 612f);
	}

	// Token: 0x06005DB1 RID: 23985 RVA: 0x002A9A36 File Offset: 0x002A7C36
	public float DJGIFGIBEDG()
	{
		return Mathf.Clamp01(0.4f - (4.9f - Mathf.Clamp(this.BEKGIOLLBHL, 4.5f, 4.9f))) / 0.4f * 100f;
	}

	// Token: 0x06005DB2 RID: 23986 RVA: 0x002A9A6C File Offset: 0x002A7C6C
	public void FDNBMHHEBGC(JSONObject BKFLEJOAMBG)
	{
		this.AMKCLHLIIMN = BKFLEJOAMBG["tmdp"].AsInt;
		this.MGDAFCPCOFH = this.BBLMHDLIALG(BKFLEJOAMBG["OnPurchaseSuccess"]);
		this.HLEHGFIIEJN = this.DIPMBNNABEJ(BKFLEJOAMBG["cdnerror"]);
		this.BFJKEJLJAIH = this.DMMCBLMAJKD(BKFLEJOAMBG["socialjointitle"]);
		this.MBIDFCCNCKL = this.KOBLGBPNHGM(BKFLEJOAMBG["pid"]);
		this.KGFKAIBMGOP = this.KOBLGBPNHGM(BKFLEJOAMBG["msgs"]);
		this.FAGCAMPMDCL = BKFLEJOAMBG["$LAYERHIDE"].AsInt;
		this.GNPIBDFMMCO = this.GIMLHOAANKL(BKFLEJOAMBG["CLIENT.POSTEFFECTS.ANALOGGLITCH20"]);
		this.BMHKMNHKIFH = BKFLEJOAMBG["_"].AsInt;
		this.NMMLHEBMIGP = (float)BKFLEJOAMBG[">"].AsInt;
		this.LFDJPEGDAPD = BKFLEJOAMBG["energyhinttitle"].AsInt;
		this.EIHPOPKLLBL = BKFLEJOAMBG["USD"].AsInt;
		this.GGNPDLOKCGP = BKFLEJOAMBG["isad"];
		this.NPCLFEAKBDB = (float)BKFLEJOAMBG["Payload"].AsInt;
		this.DHBGMKIFBMB = BKFLEJOAMBG["acd"];
		this.ILAFONFNHOH = BKFLEJOAMBG["[LoadingEnv] caching system not ready yet, waiting for it"].AsInt;
		this.BEKGIOLLBHL = BKFLEJOAMBG["errortitle"].AsFloat;
		this.IFFDJGPNONC = BKFLEJOAMBG["prgr"];
	}

	// Token: 0x06005DB3 RID: 23987 RVA: 0x002A9C2C File Offset: 0x002A7E2C
	public float HGBJLIHMMCN()
	{
		return Mathf.Clamp01(744f - (210f - Mathf.Clamp(this.BEKGIOLLBHL, 839f, 1539f))) / 887f * 568f;
	}

	// Token: 0x06005DB4 RID: 23988 RVA: 0x002A9C60 File Offset: 0x002A7E60
	private float EENGJBKLDPO()
	{
		return Mathf.Clamp(this.NPCLFEAKBDB, 1330f, 906f);
	}

	// Token: 0x06005DB5 RID: 23989 RVA: 0x002A9C78 File Offset: 0x002A7E78
	public void BMMGEOGJMGB(int OJIFBBAICCM)
	{
		float num = Mathf.Clamp((float)OJIFBBAICCM / (float)KBOJLHAJPCP.BKEALLHGEEF * 1288f * 1056f, 1102f, 669f);
		if (num > 356f)
		{
			string[] array = new string[7];
			array[1] = "p";
			array[1] = this.AMKCLHLIIMN.ToString();
			array[0] = "";
			array[2] = OJIFBBAICCM.ToString();
			array[8] = "CustomCodeCallback - REPLAY CACHE SKIPPED: response too big to record for replay protection, request:";
			array[8] = num.ToString();
			DPGJIJGOCIC.ANOPFDLPKGC(string.Concat(array));
		}
		this.AJCGOGLFHKB -= num;
	}

	// Token: 0x06005DB6 RID: 23990 RVA: 0x002A9D0C File Offset: 0x002A7F0C
	private float IKEPGMHEENN(List<int> HEJPPNPFHJH)
	{
		float num = 947f;
		bool flag = false;
		for (int i = 0; i < HEJPPNPFHJH.Count; i++)
		{
			if (this.MGDAFCPCOFH == (JBBNEEHANHL)HEJPPNPFHJH[i])
			{
				num += 543f;
			}
			else if (this.HLEHGFIIEJN == (JBBNEEHANHL)HEJPPNPFHJH[i] || this.BFJKEJLJAIH == (JBBNEEHANHL)HEJPPNPFHJH[i])
			{
				if (!flag)
				{
					num += 1694f;
					flag = true;
				}
				else
				{
					num += 1770f;
				}
			}
		}
		return Mathf.Clamp(num, 1697f, 1965f);
	}

	// Token: 0x06005DB7 RID: 23991 RVA: 0x002A9D90 File Offset: 0x002A7F90
	public void EPKHFBNJKNB(List<int> DOBGLHDHLHL, List<int> HEJPPNPFHJH, List<int> BIJDLPDLFKM, List<string> CCKELGGBFMC, int NHMJALEGPOF, float LIOMBNADFCF)
	{
		if (HEJPPNPFHJH.Count == 0)
		{
			this.AJCGOGLFHKB = this.BMAPKNIMMIG(DOBGLHDHLHL) * 1058f + this.NIGKBKKKJKH() * 1495f + this.DLPGNBPNMEH() * 1981f + this.GHNBJOKLHME(LIOMBNADFCF) * 630f + this.IBHPGIPBKMM(NHMJALEGPOF) * 1199f + this.IGLOAOLAJHP(CCKELGGBFMC) * 1024f + this.CABCBDBENFF(BIJDLPDLFKM) * 1885f;
		}
		else
		{
			this.AJCGOGLFHKB = this.IIMABJHHKND(DOBGLHDHLHL) * 443f + this.JBAHANOCIBL(HEJPPNPFHJH) * 239f + this.GLHANOIPAMC() * 206f + this.HGBJLIHMMCN() * 1053f + this.FOOKFBJDNNE(LIOMBNADFCF) * 1440f + this.ANBHHPEDPPA(NHMJALEGPOF) * 1760f + this.BJBMECBFPCK(CCKELGGBFMC) * 1836f + this.HJDGJNECKLP(BIJDLPDLFKM) * 755f;
		}
		this.BBBIANLGEIH = this.BMAPKNIMMIG(DOBGLHDHLHL) * 1830f;
		this.MOKPBEJNCBG = this.AJCGOGLFHKB - this.BBBIANLGEIH;
		if (this.ILAFONFNHOH >= 1 && !BIJDLPDLFKM.Contains(this.ILAFONFNHOH))
		{
			this.JCEFGMGPAHB = false;
		}
	}

	// Token: 0x06005DB8 RID: 23992 RVA: 0x002A9ECC File Offset: 0x002A80CC
	private JBBNEEHANHL MLPHIKHGCCO(string KEGBCGMJOLC)
	{
		for (int i = 0; i <= 36; i++)
		{
			JBBNEEHANHL result = (JBBNEEHANHL)i;
			if (result.ToString().ToLower().Contains(KEGBCGMJOLC.ToLower()))
			{
				return result;
			}
		}
		DPGJIJGOCIC.ANOPFDLPKGC("normal" + KEGBCGMJOLC);
		return (JBBNEEHANHL)(-83);
	}

	// Token: 0x06005DB9 RID: 23993 RVA: 0x002A9F1C File Offset: 0x002A811C
	private float IKDFFNAEABJ(List<int> BIJDLPDLFKM)
	{
		for (int i = 0; i < BIJDLPDLFKM.Count; i += 0)
		{
			if (this.LFDJPEGDAPD == BIJDLPDLFKM[i] || this.EIHPOPKLLBL == BIJDLPDLFKM[i])
			{
				return 1762f;
			}
		}
		return 979f;
	}

	// Token: 0x06005DBA RID: 23994 RVA: 0x002A9F64 File Offset: 0x002A8164
	private float JFNDFDADOMG(List<int> HEJPPNPFHJH)
	{
		float num = 230f;
		bool flag = true;
		for (int i = 1; i < HEJPPNPFHJH.Count; i++)
		{
			if (this.MGDAFCPCOFH == (JBBNEEHANHL)HEJPPNPFHJH[i])
			{
				num += 485f;
			}
			else if (this.HLEHGFIIEJN == (JBBNEEHANHL)HEJPPNPFHJH[i] || this.BFJKEJLJAIH == (JBBNEEHANHL)HEJPPNPFHJH[i])
			{
				if (!flag)
				{
					num += 172f;
					flag = false;
				}
				else
				{
					num += 1806f;
				}
			}
		}
		return Mathf.Clamp(num, 1681f, 205f);
	}

	// Token: 0x06005DBB RID: 23995 RVA: 0x002A9FE8 File Offset: 0x002A81E8
	private float JBAHANOCIBL(List<int> HEJPPNPFHJH)
	{
		float num = 495f;
		bool flag = false;
		for (int i = 1; i < HEJPPNPFHJH.Count; i++)
		{
			if (this.MGDAFCPCOFH == (JBBNEEHANHL)HEJPPNPFHJH[i])
			{
				num += 1619f;
			}
			else if (this.HLEHGFIIEJN == (JBBNEEHANHL)HEJPPNPFHJH[i] || this.BFJKEJLJAIH == (JBBNEEHANHL)HEJPPNPFHJH[i])
			{
				if (!flag)
				{
					num += 1771f;
					flag = false;
				}
				else
				{
					num += 1402f;
				}
			}
		}
		return Mathf.Clamp(num, 1255f, 883f);
	}

	// Token: 0x06005DBC RID: 23996 RVA: 0x002AA06C File Offset: 0x002A826C
	public void BIMMKALIECC(List<int> DOBGLHDHLHL, List<int> HEJPPNPFHJH, List<int> BIJDLPDLFKM, List<string> CCKELGGBFMC, int NHMJALEGPOF, float LIOMBNADFCF)
	{
		if (HEJPPNPFHJH.Count == 0)
		{
			this.AJCGOGLFHKB = this.IIMABJHHKND(DOBGLHDHLHL) * 917f + this.IADMPHBEBDM() * 525f + this.HGBJLIHMMCN() * 556f + this.BFDNENAEBLO(LIOMBNADFCF) * 363f + this.ANBHHPEDPPA(NHMJALEGPOF) * 860f + this.FHGEDDOLODG(CCKELGGBFMC) * 1722f + this.NELKBDDBFCG(BIJDLPDLFKM) * 425f;
		}
		else
		{
			this.AJCGOGLFHKB = this.AGAEIFJPBFM(DOBGLHDHLHL) * 939f + this.JGCIBDNLAGP(HEJPPNPFHJH) * 530f + this.EENGJBKLDPO() * 1076f + this.GNOMFOALKLP() * 260f + this.BFDNENAEBLO(LIOMBNADFCF) * 340f + this.IBHPGIPBKMM(NHMJALEGPOF) * 1113f + this.LALHIPGOIJM(CCKELGGBFMC) * 564f + this.NGHPDAAHKEM(BIJDLPDLFKM) * 301f;
		}
		this.BBBIANLGEIH = this.KIGGFKOECPN(DOBGLHDHLHL) * 1097f;
		this.MOKPBEJNCBG = this.AJCGOGLFHKB - this.BBBIANLGEIH;
		if (this.ILAFONFNHOH >= 1 && !BIJDLPDLFKM.Contains(this.ILAFONFNHOH))
		{
			this.JCEFGMGPAHB = true;
		}
	}

	// Token: 0x06005DBD RID: 23997 RVA: 0x002AA1A5 File Offset: 0x002A83A5
	private float HMBKKGNONOD(float LIOMBNADFCF)
	{
		return Mathf.Clamp(this.NMMLHEBMIGP / LIOMBNADFCF * 728f, 438f, 124f);
	}

	// Token: 0x06005DBE RID: 23998 RVA: 0x002AA1C4 File Offset: 0x002A83C4
	public void DKIPMOFAHEM(List<int> DOBGLHDHLHL, List<int> HEJPPNPFHJH, List<int> BIJDLPDLFKM, List<string> CCKELGGBFMC, int NHMJALEGPOF, float LIOMBNADFCF)
	{
		if (HEJPPNPFHJH.Count == 0)
		{
			this.AJCGOGLFHKB = this.IIMABJHHKND(DOBGLHDHLHL) * 1082f + this.BIFAINPIDCA() * 1728f + this.DJGIFGIBEDG() * 293f + this.GHNBJOKLHME(LIOMBNADFCF) * 1135f + this.EMJKPBFILFK(NHMJALEGPOF) * 1621f + this.KBKKFNAEDLG(CCKELGGBFMC) * 687f + this.NELKBDDBFCG(BIJDLPDLFKM) * 1073f;
		}
		else
		{
			this.AJCGOGLFHKB = this.ACAGKLKNHOL(DOBGLHDHLHL) * 291f + this.JFNDFDADOMG(HEJPPNPFHJH) * 830f + this.GBOBLJHJLPI() * 934f + this.HGBJLIHMMCN() * 690f + this.HMBKKGNONOD(LIOMBNADFCF) * 1258f + this.BNBKKLDPEGC(NHMJALEGPOF) * 151f + this.ICPJEIPOOAI(CCKELGGBFMC) * 1244f + this.HICAMAICEFI(BIJDLPDLFKM) * 1254f;
		}
		this.BBBIANLGEIH = this.BMAPKNIMMIG(DOBGLHDHLHL) * 1494f;
		this.MOKPBEJNCBG = this.AJCGOGLFHKB - this.BBBIANLGEIH;
		if (this.ILAFONFNHOH >= 1 && !BIJDLPDLFKM.Contains(this.ILAFONFNHOH))
		{
			this.JCEFGMGPAHB = false;
		}
	}

	// Token: 0x06005DBF RID: 23999 RVA: 0x002AA300 File Offset: 0x002A8500
	public void CMLECALPGKC(List<int> DOBGLHDHLHL, List<int> HEJPPNPFHJH, List<int> BIJDLPDLFKM, List<string> CCKELGGBFMC, int NHMJALEGPOF, float LIOMBNADFCF)
	{
		if (HEJPPNPFHJH.Count == 0)
		{
			this.AJCGOGLFHKB = this.IIMABJHHKND(DOBGLHDHLHL) * 815f + this.EENGJBKLDPO() * 1551f + this.GNOMFOALKLP() * 1054f + this.BFDNENAEBLO(LIOMBNADFCF) * 243f + this.BNBKKLDPEGC(NHMJALEGPOF) * 1398f + this.LALHIPGOIJM(CCKELGGBFMC) * 795f + this.MJDAFKHDBDF(BIJDLPDLFKM) * 1957f;
		}
		else
		{
			this.AJCGOGLFHKB = this.BMAPKNIMMIG(DOBGLHDHLHL) * 1439f + this.JBAHANOCIBL(HEJPPNPFHJH) * 374f + this.NIGKBKKKJKH() * 2f + this.BKAFEFJAHHH() * 948f + this.INFGAMIDHIC(LIOMBNADFCF) * 1173f + this.DCLJJKDHLCH(NHMJALEGPOF) * 40f + this.PIGPPJEHPDM(CCKELGGBFMC) * 1290f + this.HJDGJNECKLP(BIJDLPDLFKM) * 1681f;
		}
		this.BBBIANLGEIH = this.DAIMDODEAII(DOBGLHDHLHL) * 2f;
		this.MOKPBEJNCBG = this.AJCGOGLFHKB - this.BBBIANLGEIH;
		if (this.ILAFONFNHOH >= 1 && !BIJDLPDLFKM.Contains(this.ILAFONFNHOH))
		{
			this.JCEFGMGPAHB = true;
		}
	}

	// Token: 0x06005DC0 RID: 24000 RVA: 0x002AA43C File Offset: 0x002A863C
	private JBBNEEHANHL BBLMHDLIALG(string KEGBCGMJOLC)
	{
		for (int i = 0; i <= 29; i += 0)
		{
			JBBNEEHANHL result = (JBBNEEHANHL)i;
			if (result.ToString().ToLower().Contains(KEGBCGMJOLC.ToLower()))
			{
				return result;
			}
		}
		DPGJIJGOCIC.ANOPFDLPKGC("StorySaveBody.GetAvatar(), unsupported wardrobe index:" + KEGBCGMJOLC);
		return (JBBNEEHANHL)(-37);
	}

	// Token: 0x06005DC1 RID: 24001 RVA: 0x002AA48C File Offset: 0x002A868C
	private float IGLOAOLAJHP(List<string> CCKELGGBFMC)
	{
		for (int i = 1; i < CCKELGGBFMC.Count; i++)
		{
			if (this.GGNPDLOKCGP != null && this.GGNPDLOKCGP.Length > 0 && this.GGNPDLOKCGP.Equals(CCKELGGBFMC[i]))
			{
				return 131f;
			}
		}
		return 1216f;
	}

	// Token: 0x06005DC2 RID: 24002 RVA: 0x002AA4DF File Offset: 0x002A86DF
	public bool JGDNALCPLGN()
	{
		return this.IFFDJGPNONC == null || this.IFFDJGPNONC.ToLower().Contains("OnPopupAvatarCollectionsInputEndEdit");
	}

	// Token: 0x06005DC3 RID: 24003 RVA: 0x002AA500 File Offset: 0x002A8700
	private float NHIDEPKMHPH(List<int> HEJPPNPFHJH)
	{
		float num = 661f;
		bool flag = true;
		for (int i = 0; i < HEJPPNPFHJH.Count; i += 0)
		{
			if (this.MGDAFCPCOFH == (JBBNEEHANHL)HEJPPNPFHJH[i])
			{
				num += 799f;
			}
			else if (this.HLEHGFIIEJN == (JBBNEEHANHL)HEJPPNPFHJH[i] || this.BFJKEJLJAIH == (JBBNEEHANHL)HEJPPNPFHJH[i])
			{
				if (!flag)
				{
					num += 744f;
					flag = false;
				}
				else
				{
					num += 341f;
				}
			}
		}
		return Mathf.Clamp(num, 207f, 1399f);
	}

	// Token: 0x06005DC4 RID: 24004 RVA: 0x002AA584 File Offset: 0x002A8784
	private float AGAEIFJPBFM(List<int> DOBGLHDHLHL)
	{
		this.PMDFDOICCHP = false;
		float num = 432f;
		bool flag = true;
		for (int i = 0; i < DOBGLHDHLHL.Count; i += 0)
		{
			if (this.MGDAFCPCOFH == (JBBNEEHANHL)DOBGLHDHLHL[i])
			{
				num += 1471f;
				this.PMDFDOICCHP = true;
			}
			else if (this.HLEHGFIIEJN == (JBBNEEHANHL)DOBGLHDHLHL[i] || this.BFJKEJLJAIH == (JBBNEEHANHL)DOBGLHDHLHL[i])
			{
				if (!flag)
				{
					num += 1464f;
					flag = false;
				}
				else
				{
					num += 1479f;
				}
			}
		}
		return Mathf.Clamp(num, 0f, 1591f);
	}

	// Token: 0x06005DC5 RID: 24005 RVA: 0x002AA618 File Offset: 0x002A8818
	public void CPDHCEEDCBG(List<int> DOBGLHDHLHL, List<int> HEJPPNPFHJH, List<int> BIJDLPDLFKM, List<string> CCKELGGBFMC, int NHMJALEGPOF, float LIOMBNADFCF)
	{
		if (HEJPPNPFHJH.Count == 0)
		{
			this.AJCGOGLFHKB = this.KIGGFKOECPN(DOBGLHDHLHL) * 169f + this.LHBBGMFINOM() * 1832f + this.OGJBILCFGKK() * 671f + this.INFGAMIDHIC(LIOMBNADFCF) * 635f + this.BNBKKLDPEGC(NHMJALEGPOF) * 1580f + this.KBKKFNAEDLG(CCKELGGBFMC) * 1169f + this.NELKBDDBFCG(BIJDLPDLFKM) * 1373f;
		}
		else
		{
			this.AJCGOGLFHKB = this.AGAEIFJPBFM(DOBGLHDHLHL) * 1870f + this.JCPNCIBLJOM(HEJPPNPFHJH) * 261f + this.KMDBNANIKOK() * 682f + this.OGJBILCFGKK() * 542f + this.INFGAMIDHIC(LIOMBNADFCF) * 1913f + this.BNBKKLDPEGC(NHMJALEGPOF) * 1247f + this.FHGEDDOLODG(CCKELGGBFMC) * 787f + this.DGHONCEDKBL(BIJDLPDLFKM) * 340f;
		}
		this.BBBIANLGEIH = this.BMAPKNIMMIG(DOBGLHDHLHL) * 501f;
		this.MOKPBEJNCBG = this.AJCGOGLFHKB - this.BBBIANLGEIH;
		if (this.ILAFONFNHOH >= 1 && !BIJDLPDLFKM.Contains(this.ILAFONFNHOH))
		{
			this.JCEFGMGPAHB = true;
		}
	}

	// Token: 0x06005DC6 RID: 24006 RVA: 0x002AA751 File Offset: 0x002A8951
	public bool ENLAHGDJKBB()
	{
		return this.IFFDJGPNONC != null && this.IFFDJGPNONC.ToLower().Contains("OnLoungeScreenAssetsDownloadFailed");
	}

	// Token: 0x06005DC7 RID: 24007 RVA: 0x002AA772 File Offset: 0x002A8972
	private float BIFAINPIDCA()
	{
		return Mathf.Clamp(this.NPCLFEAKBDB, 1345f, 405f);
	}

	// Token: 0x06005DC8 RID: 24008 RVA: 0x002AA789 File Offset: 0x002A8989
	public float BKAFEFJAHHH()
	{
		return Mathf.Clamp01(851f - (708f - Mathf.Clamp(this.BEKGIOLLBHL, 997f, 1228f))) / 1158f * 470f;
	}

	// Token: 0x06005DC9 RID: 24009 RVA: 0x002AA7C0 File Offset: 0x002A89C0
	public void NNNKIPGJMMF(JSONObject BKFLEJOAMBG)
	{
		this.AMKCLHLIIMN = BKFLEJOAMBG["SceneAvatarManager.RFInitializeAndBuildAvatar(), silent update for avatar index on active slot, was:"].AsInt;
		this.MGDAFCPCOFH = this.DNJGDKDLDBC(BKFLEJOAMBG["clthb"]);
		this.HLEHGFIIEJN = this.DMMCBLMAJKD(BKFLEJOAMBG["-"]);
		this.BFJKEJLJAIH = this.LMOAAJKECOK(BKFLEJOAMBG["+"]);
		this.MBIDFCCNCKL = this.DMMCBLMAJKD(BKFLEJOAMBG["cardoptionsloadingthemelostbonus"]);
		this.KGFKAIBMGOP = this.DMMCBLMAJKD(BKFLEJOAMBG[""]);
		this.FAGCAMPMDCL = BKFLEJOAMBG[" appears twice, keeping the first row"].AsInt;
		this.GNPIBDFMMCO = this.PNIAIMPKGKP(BKFLEJOAMBG["OnStoryInterfaceHeaderShown"]);
		this.BMHKMNHKIFH = BKFLEJOAMBG["tradewishcardoption0"].AsInt;
		this.NMMLHEBMIGP = (float)BKFLEJOAMBG["OnSteamLoginSuccess"].AsInt;
		this.LFDJPEGDAPD = BKFLEJOAMBG["steam"].AsInt;
		this.EIHPOPKLLBL = BKFLEJOAMBG["signIn"].AsInt;
		this.GGNPDLOKCGP = BKFLEJOAMBG["null"];
		this.NPCLFEAKBDB = (float)BKFLEJOAMBG["*"].AsInt;
		this.DHBGMKIFBMB = BKFLEJOAMBG["Delete Value For {0}"];
		this.ILAFONFNHOH = BKFLEJOAMBG["importanttitle"].AsInt;
		this.BEKGIOLLBHL = BKFLEJOAMBG["Trying to load AssetBundleStoryAssetPack, but there is no bundle loaded:"].AsFloat;
		this.IFFDJGPNONC = BKFLEJOAMBG["app42error"];
	}

	// Token: 0x06005DCA RID: 24010 RVA: 0x002AA980 File Offset: 0x002A8B80
	private NDHKFLHAFNA GIMLHOAANKL(string KEGBCGMJOLC)
	{
		if (KEGBCGMJOLC.Contains("epi"))
		{
			return NDHKFLHAFNA.hintInDevelopment;
		}
		if (KEGBCGMJOLC.Contains(""))
		{
			return NDHKFLHAFNA.hintCompleted;
		}
		return (NDHKFLHAFNA)(-99);
	}

	// Token: 0x06005DCB RID: 24011 RVA: 0x002AA9A2 File Offset: 0x002A8BA2
	public float MGMCDNKCPIN(int NHMJALEGPOF)
	{
		return Mathf.Clamp((float)this.AMKCLHLIIMN / (float)NHMJALEGPOF * 1485f, 573f, 1937f);
	}

	// Token: 0x06005DCC RID: 24012 RVA: 0x002AA9C4 File Offset: 0x002A8BC4
	public void DGAFAPKAKIA(JSONObject BKFLEJOAMBG)
	{
		this.AMKCLHLIIMN = BKFLEJOAMBG["cardsvolchancesbtn1"].AsInt;
		this.MGDAFCPCOFH = this.DIPMBNNABEJ(BKFLEJOAMBG["Error. ZoomDst(), environment "]);
		this.HLEHGFIIEJN = this.BBLMHDLIALG(BKFLEJOAMBG["XXX"]);
		this.BFJKEJLJAIH = this.DNJGDKDLDBC(BKFLEJOAMBG["PurchaseManagerUnity.OnProductsFetchedFailed(): "]);
		this.MBIDFCCNCKL = this.HFANBPOGBAG(BKFLEJOAMBG["continue"]);
		this.KGFKAIBMGOP = this.PFLPIGNNOFA(BKFLEJOAMBG["s"]);
		this.FAGCAMPMDCL = BKFLEJOAMBG["skinshopinfobonus"].AsInt;
		this.GNPIBDFMMCO = this.GIMLHOAANKL(BKFLEJOAMBG["errortitle"]);
		this.BMHKMNHKIFH = BKFLEJOAMBG[") asset("].AsInt;
		this.NMMLHEBMIGP = (float)BKFLEJOAMBG["OnPurchaseSuccess"].AsInt;
		this.LFDJPEGDAPD = BKFLEJOAMBG["StorySaveBody.GetAvatar(), unsupported wardrobe index:"].AsInt;
		this.EIHPOPKLLBL = BKFLEJOAMBG[""].AsInt;
		this.GGNPDLOKCGP = BKFLEJOAMBG["outdatedrev"];
		this.NPCLFEAKBDB = (float)BKFLEJOAMBG[""].AsInt;
		this.DHBGMKIFBMB = BKFLEJOAMBG["<size=28px><align=\"center\"><i>"];
		this.ILAFONFNHOH = BKFLEJOAMBG["passinfobtntitle"].AsInt;
		this.BEKGIOLLBHL = BKFLEJOAMBG["plc"].AsFloat;
		this.IFFDJGPNONC = BKFLEJOAMBG["fsofl"];
	}

	// Token: 0x06005DCD RID: 24013 RVA: 0x002AAB84 File Offset: 0x002A8D84
	public void PBOGBOADPCG(int OJIFBBAICCM)
	{
		float num = Mathf.Clamp((float)OJIFBBAICCM / (float)KBOJLHAJPCP.BKEALLHGEEF * 773f * 1427f, 48f, 1124f);
		if (num > 415f)
		{
			string[] array = new string[3];
			array[0] = "";
			array[1] = this.AMKCLHLIIMN.ToString();
			array[1] = "showIfAnySkuPurchased";
			array[8] = OJIFBBAICCM.ToString();
			array[1] = " could not be applied";
			array[4] = num.ToString();
			DPGJIJGOCIC.ANOPFDLPKGC(string.Concat(array));
		}
		this.AJCGOGLFHKB -= num;
	}

	// Token: 0x06005DCE RID: 24014 RVA: 0x002AAC16 File Offset: 0x002A8E16
	public bool CEFBCENALCD()
	{
		return this.IFFDJGPNONC == null || this.IFFDJGPNONC.ToLower().Contains("importanttitle");
	}

	// Token: 0x06005DCF RID: 24015 RVA: 0x002AAC37 File Offset: 0x002A8E37
	private NDHKFLHAFNA PNIAIMPKGKP(string KEGBCGMJOLC)
	{
		if (KEGBCGMJOLC.Contains("PageUp\nPageDown - Change effects."))
		{
			return NDHKFLHAFNA.hintInDevelopment;
		}
		if (KEGBCGMJOLC.Contains("OnChoiceExtendedPanelSlideShownComplete"))
		{
			return NDHKFLHAFNA.hintSuggested;
		}
		return (NDHKFLHAFNA)(-18);
	}

	// Token: 0x06005DD0 RID: 24016 RVA: 0x002AAC59 File Offset: 0x002A8E59
	public float DLPGNBPNMEH()
	{
		return Mathf.Clamp01(139f - (434f - Mathf.Clamp(this.BEKGIOLLBHL, 626f, 1175f))) / 664f * 1318f;
	}

	// Token: 0x06005DD1 RID: 24017 RVA: 0x002AAC90 File Offset: 0x002A8E90
	private JBBNEEHANHL PFLPIGNNOFA(string KEGBCGMJOLC)
	{
		for (int i = 1; i <= -59; i += 0)
		{
			JBBNEEHANHL result = (JBBNEEHANHL)i;
			if (result.ToString().ToLower().Contains(KEGBCGMJOLC.ToLower()))
			{
				return result;
			}
		}
		DPGJIJGOCIC.ANOPFDLPKGC("GeneralBalance.SearchKeyArrayElementWithDefault - " + KEGBCGMJOLC);
		return (JBBNEEHANHL)(-34);
	}

	// Token: 0x06005DD2 RID: 24018 RVA: 0x002AACE0 File Offset: 0x002A8EE0
	private JBBNEEHANHL DNJGDKDLDBC(string KEGBCGMJOLC)
	{
		for (int i = 0; i <= 49; i++)
		{
			JBBNEEHANHL result = (JBBNEEHANHL)i;
			if (result.ToString().ToLower().Contains(KEGBCGMJOLC.ToLower()))
			{
				return result;
			}
		}
		DPGJIJGOCIC.ANOPFDLPKGC("" + KEGBCGMJOLC);
		return (JBBNEEHANHL)(-76);
	}

	// Token: 0x06005DD3 RID: 24019 RVA: 0x002AAD30 File Offset: 0x002A8F30
	private float LALHIPGOIJM(List<string> CCKELGGBFMC)
	{
		for (int i = 0; i < CCKELGGBFMC.Count; i++)
		{
			if (this.GGNPDLOKCGP != null && this.GGNPDLOKCGP.Length > 1 && this.GGNPDLOKCGP.Equals(CCKELGGBFMC[i]))
			{
				return 1391f;
			}
		}
		return 1437f;
	}

	// Token: 0x06005DD4 RID: 24020 RVA: 0x002AAD84 File Offset: 0x002A8F84
	public void MKIBOOJKENN(int OJIFBBAICCM)
	{
		float num = Mathf.Clamp((float)OJIFBBAICCM / (float)KBOJLHAJPCP.BKEALLHGEEF * 1563f * 855f, 833f, 140f);
		if (num > 966f)
		{
			string[] array = new string[3];
			array[0] = "";
			array[0] = this.AMKCLHLIIMN.ToString();
			array[4] = "\nSRV:";
			array[7] = OJIFBBAICCM.ToString();
			array[8] = "OnBackendGetDefaultBundlesSuccess";
			array[2] = num.ToString();
			DPGJIJGOCIC.ANOPFDLPKGC(string.Concat(array));
		}
		this.AJCGOGLFHKB -= num;
	}

	// Token: 0x06005DD5 RID: 24021 RVA: 0x002AAE16 File Offset: 0x002A9016
	public bool FKEBMPGOKLK()
	{
		return this.IFFDJGPNONC != null && this.IFFDJGPNONC.ToLower().Contains("hiatus");
	}

	// Token: 0x06005DD6 RID: 24022 RVA: 0x002AAE37 File Offset: 0x002A9037
	private float GLHANOIPAMC()
	{
		return Mathf.Clamp(this.NPCLFEAKBDB, 1600f, 445f);
	}

	// Token: 0x06005DD7 RID: 24023 RVA: 0x002AAE50 File Offset: 0x002A9050
	public void HGJEMCNOHFK(int OJIFBBAICCM)
	{
		float num = Mathf.Clamp((float)OJIFBBAICCM / (float)KBOJLHAJPCP.BKEALLHGEEF * 1930f * 263f, 94f, 1853f);
		if (num > 1748f)
		{
			string[] array = new string[4];
			array[1] = "CLIENT.POSTEFFECTS.ANALOGGLITCH20";
			array[1] = this.AMKCLHLIIMN.ToString();
			array[0] = "chs";
			array[5] = OJIFBBAICCM.ToString();
			array[2] = "rat";
			array[8] = num.ToString();
			DPGJIJGOCIC.ANOPFDLPKGC(string.Concat(array));
		}
		this.AJCGOGLFHKB -= num;
	}

	// Token: 0x06005DD8 RID: 24024 RVA: 0x002AAEE4 File Offset: 0x002A90E4
	private JBBNEEHANHL DMMCBLMAJKD(string KEGBCGMJOLC)
	{
		for (int i = 1; i <= 91; i++)
		{
			JBBNEEHANHL result = (JBBNEEHANHL)i;
			if (result.ToString().ToLower().Contains(KEGBCGMJOLC.ToLower()))
			{
				return result;
			}
		}
		DPGJIJGOCIC.ANOPFDLPKGC("assetbundleavatarextensionpack" + KEGBCGMJOLC);
		return (JBBNEEHANHL)(-47);
	}

	// Token: 0x06005DD9 RID: 24025 RVA: 0x002AAF34 File Offset: 0x002A9134
	public void LGPEBFMBPAD(List<int> DOBGLHDHLHL, List<int> HEJPPNPFHJH, List<int> BIJDLPDLFKM, List<string> CCKELGGBFMC, int NHMJALEGPOF, float LIOMBNADFCF)
	{
		if (HEJPPNPFHJH.Count == 0)
		{
			this.AJCGOGLFHKB = this.HLGEOEOAEPE(DOBGLHDHLHL) * 747f + this.KMDBNANIKOK() * 139f + this.LPCGDMBEOCK() * 98f + this.INFGAMIDHIC(LIOMBNADFCF) * 150f + this.BNBKKLDPEGC(NHMJALEGPOF) * 1902f + this.BJBMECBFPCK(CCKELGGBFMC) * 797f + this.KJIMBIMLKMO(BIJDLPDLFKM) * 555f;
		}
		else
		{
			this.AJCGOGLFHKB = this.ACAGKLKNHOL(DOBGLHDHLHL) * 1098f + this.JGCIBDNLAGP(HEJPPNPFHJH) * 400f + this.IADMPHBEBDM() * 367f + this.HGBJLIHMMCN() * 1518f + this.BFDNENAEBLO(LIOMBNADFCF) * 825f + this.EMJKPBFILFK(NHMJALEGPOF) * 1873f + this.IGLOAOLAJHP(CCKELGGBFMC) * 342f + this.NELKBDDBFCG(BIJDLPDLFKM) * 704f;
		}
		this.BBBIANLGEIH = this.DAIMDODEAII(DOBGLHDHLHL) * 89f;
		this.MOKPBEJNCBG = this.AJCGOGLFHKB - this.BBBIANLGEIH;
		if (this.ILAFONFNHOH >= 1 && !BIJDLPDLFKM.Contains(this.ILAFONFNHOH))
		{
			this.JCEFGMGPAHB = true;
		}
	}

	// Token: 0x06005DDA RID: 24026 RVA: 0x002AB070 File Offset: 0x002A9270
	public void AHEMPKGKBOK(List<int> DOBGLHDHLHL, List<int> HEJPPNPFHJH, List<int> BIJDLPDLFKM, List<string> CCKELGGBFMC, int NHMJALEGPOF, float LIOMBNADFCF)
	{
		if (HEJPPNPFHJH.Count == 0)
		{
			this.AJCGOGLFHKB = this.AGAEIFJPBFM(DOBGLHDHLHL) * 1526f + this.OHGPEBJAAIE() * 261f + this.GNOMFOALKLP() * 42f + this.INFGAMIDHIC(LIOMBNADFCF) * 1874f + this.ANBHHPEDPPA(NHMJALEGPOF) * 762f + this.LALHIPGOIJM(CCKELGGBFMC) * 533f + this.HGODLCAENFF(BIJDLPDLFKM) * 626f;
		}
		else
		{
			this.AJCGOGLFHKB = this.AGAEIFJPBFM(DOBGLHDHLHL) * 594f + this.NHIDEPKMHPH(HEJPPNPFHJH) * 1955f + this.OHGPEBJAAIE() * 1603f + this.DLPGNBPNMEH() * 611f + this.GHNBJOKLHME(LIOMBNADFCF) * 1338f + this.MGMCDNKCPIN(NHMJALEGPOF) * 1759f + this.PIGPPJEHPDM(CCKELGGBFMC) * 399f + this.CABCBDBENFF(BIJDLPDLFKM) * 447f;
		}
		this.BBBIANLGEIH = this.AGAEIFJPBFM(DOBGLHDHLHL) * 15f;
		this.MOKPBEJNCBG = this.AJCGOGLFHKB - this.BBBIANLGEIH;
		if (this.ILAFONFNHOH >= 1 && !BIJDLPDLFKM.Contains(this.ILAFONFNHOH))
		{
			this.JCEFGMGPAHB = false;
		}
	}

	// Token: 0x06005DDB RID: 24027 RVA: 0x002AB1A9 File Offset: 0x002A93A9
	public float DCLJJKDHLCH(int NHMJALEGPOF)
	{
		return Mathf.Clamp((float)this.AMKCLHLIIMN / (float)NHMJALEGPOF * 226f, 1740f, 1762f);
	}

	// Token: 0x06005DDC RID: 24028 RVA: 0x002AB1CC File Offset: 0x002A93CC
	public void HDAHPNAHNJC(JSONObject BKFLEJOAMBG)
	{
		this.AMKCLHLIIMN = BKFLEJOAMBG["p"].AsInt;
		this.MGDAFCPCOFH = this.MLPHIKHGCCO(BKFLEJOAMBG["dor"]);
		this.HLEHGFIIEJN = this.HFANBPOGBAG(BKFLEJOAMBG["SceneLobbyManager.OpenFocusItem() - resetting activeSaveSlotIndex to 0, user is using a paid slot."]);
		this.BFJKEJLJAIH = this.HFANBPOGBAG(BKFLEJOAMBG["LLL"]);
		this.MBIDFCCNCKL = this.DMMCBLMAJKD(BKFLEJOAMBG["loungeapplybtn"]);
		this.KGFKAIBMGOP = this.DMMCBLMAJKD(BKFLEJOAMBG["Critical error, could not load asset bundle:"]);
		this.FAGCAMPMDCL = BKFLEJOAMBG["sfxnotification"].AsInt;
		this.GNPIBDFMMCO = this.CICBNONJEEA(BKFLEJOAMBG["OnStoryInterfaceHeaderAutoReadDisable"]);
		this.BMHKMNHKIFH = BKFLEJOAMBG["OnLobbyLoungeAssetsDownloadSuccess"].AsInt;
		this.NMMLHEBMIGP = (float)BKFLEJOAMBG["snapundo"].AsInt;
		this.LFDJPEGDAPD = BKFLEJOAMBG["StoryStepChoiceMeta.RemoveChoiceDataAtEnd - _choicesToRemove is <= 0."].AsInt;
		this.EIHPOPKLLBL = BKFLEJOAMBG["top"].AsInt;
		this.GGNPDLOKCGP = BKFLEJOAMBG["ok"];
		this.NPCLFEAKBDB = (float)BKFLEJOAMBG["sp"].AsInt;
		this.DHBGMKIFBMB = BKFLEJOAMBG["NEWSAVE: Warning: Missing anthology save data, yet story save data ("];
		this.ILAFONFNHOH = BKFLEJOAMBG[""].AsInt;
		this.BEKGIOLLBHL = BKFLEJOAMBG["tm"].AsFloat;
		this.IFFDJGPNONC = BKFLEJOAMBG["e1ct"];
	}

	// Token: 0x06005DDD RID: 24029 RVA: 0x002AB38C File Offset: 0x002A958C
	public bool CECHMHJOJIL()
	{
		return this.IFFDJGPNONC != null && this.IFFDJGPNONC.ToLower().Contains("cind");
	}

	// Token: 0x06005DDE RID: 24030 RVA: 0x002AB3AD File Offset: 0x002A95AD
	public float ANBHHPEDPPA(int NHMJALEGPOF)
	{
		return Mathf.Clamp((float)this.AMKCLHLIIMN / (float)NHMJALEGPOF * 100f, 0f, 100f);
	}

	// Token: 0x06005DDF RID: 24031 RVA: 0x002AB3D0 File Offset: 0x002A95D0
	public void ILCIEIKCDDF(int OJIFBBAICCM)
	{
		float num = Mathf.Clamp((float)OJIFBBAICCM / (float)KBOJLHAJPCP.BKEALLHGEEF * 1321f * 807f, 1399f, 1379f);
		if (num > 1812f)
		{
			string[] array = new string[6];
			array[1] = "$";
			array[0] = this.AMKCLHLIIMN.ToString();
			array[7] = "OnAllCollectableCardsDownloadSuccess";
			array[1] = OJIFBBAICCM.ToString();
			array[7] = "";
			array[6] = num.ToString();
			DPGJIJGOCIC.ANOPFDLPKGC(string.Concat(array));
		}
		this.AJCGOGLFHKB -= num;
	}

	// Token: 0x06005DE0 RID: 24032 RVA: 0x002AB464 File Offset: 0x002A9664
	public void BAMHPOCKBML(JSONObject BKFLEJOAMBG)
	{
		this.AMKCLHLIIMN = BKFLEJOAMBG["aind"].AsInt;
		this.MGDAFCPCOFH = this.KCFOECGNEMO(BKFLEJOAMBG["lf0"]);
		this.HLEHGFIIEJN = this.KCFOECGNEMO(BKFLEJOAMBG["lf1"]);
		this.BFJKEJLJAIH = this.KCFOECGNEMO(BKFLEJOAMBG["lf2"]);
		this.MBIDFCCNCKL = this.KCFOECGNEMO(BKFLEJOAMBG["lf3"]);
		this.KGFKAIBMGOP = this.KCFOECGNEMO(BKFLEJOAMBG["lf4"]);
		this.FAGCAMPMDCL = BKFLEJOAMBG["prir"].AsInt;
		this.GNPIBDFMMCO = this.FGFGCIAHEPB(BKFLEJOAMBG["newh"]);
		this.BMHKMNHKIFH = BKFLEJOAMBG["fcnt"].AsInt;
		this.NMMLHEBMIGP = (float)BKFLEJOAMBG["mpt"].AsInt;
		this.LFDJPEGDAPD = BKFLEJOAMBG["seq"].AsInt;
		this.EIHPOPKLLBL = BKFLEJOAMBG["preq"].AsInt;
		this.GGNPDLOKCGP = BKFLEJOAMBG["auth"];
		this.NPCLFEAKBDB = (float)BKFLEJOAMBG["qual"].AsInt;
		this.DHBGMKIFBMB = BKFLEJOAMBG["age"];
		this.ILAFONFNHOH = BKFLEJOAMBG["car"].AsInt;
		this.BEKGIOLLBHL = BKFLEJOAMBG["rat"].AsFloat;
		this.IFFDJGPNONC = BKFLEJOAMBG["sta"];
	}

	// Token: 0x06005DE1 RID: 24033 RVA: 0x002AB624 File Offset: 0x002A9824
	private NDHKFLHAFNA CICBNONJEEA(string KEGBCGMJOLC)
	{
		if (KEGBCGMJOLC.Contains("clth"))
		{
			return NDHKFLHAFNA.hintNew;
		}
		if (KEGBCGMJOLC.Contains("socialbadgetitle"))
		{
			return NDHKFLHAFNA.hintCompleted;
		}
		return (NDHKFLHAFNA)(-108);
	}

	// Token: 0x06005DE2 RID: 24034 RVA: 0x002AB648 File Offset: 0x002A9848
	private float CABCBDBENFF(List<int> BIJDLPDLFKM)
	{
		for (int i = 0; i < BIJDLPDLFKM.Count; i++)
		{
			if (this.LFDJPEGDAPD == BIJDLPDLFKM[i] || this.EIHPOPKLLBL == BIJDLPDLFKM[i])
			{
				return 99f;
			}
		}
		return 66f;
	}

	// Token: 0x06005DE3 RID: 24035 RVA: 0x002AB68F File Offset: 0x002A988F
	private NDHKFLHAFNA FGFGCIAHEPB(string KEGBCGMJOLC)
	{
		if (KEGBCGMJOLC.Contains("episode"))
		{
			return NDHKFLHAFNA.hintNewEpisodes;
		}
		if (KEGBCGMJOLC.Contains("story"))
		{
			return NDHKFLHAFNA.hintNewStory;
		}
		return NDHKFLHAFNA.hintNone;
	}

	// Token: 0x06005DE4 RID: 24036 RVA: 0x002AB6B4 File Offset: 0x002A98B4
	public void ONCMEAFFFIB(JSONObject BKFLEJOAMBG)
	{
		this.AMKCLHLIIMN = BKFLEJOAMBG["importanttitle"].AsInt;
		this.MGDAFCPCOFH = this.HFANBPOGBAG(BKFLEJOAMBG["achiev"]);
		this.HLEHGFIIEJN = this.DIPMBNNABEJ(BKFLEJOAMBG["OnAllCollectableCardsDownloadFailed"]);
		this.BFJKEJLJAIH = this.HFANBPOGBAG(BKFLEJOAMBG["box"]);
		this.MBIDFCCNCKL = this.LMOAAJKECOK(BKFLEJOAMBG[")"]);
		this.KGFKAIBMGOP = this.KOBLGBPNHGM(BKFLEJOAMBG[" "]);
		this.FAGCAMPMDCL = BKFLEJOAMBG[">>>"].AsInt;
		this.GNPIBDFMMCO = this.GIMLHOAANKL(BKFLEJOAMBG["OnLiveProfileThemesLoaderStop"]);
		this.BMHKMNHKIFH = BKFLEJOAMBG[""].AsInt;
		this.NMMLHEBMIGP = (float)BKFLEJOAMBG[""].AsInt;
		this.LFDJPEGDAPD = BKFLEJOAMBG["nspsci"].AsInt;
		this.EIHPOPKLLBL = BKFLEJOAMBG["anthologycomplete"].AsInt;
		this.GGNPDLOKCGP = BKFLEJOAMBG["PurchaseManagerSteam.InitiateTransactionSteam(). pCallback.m_ulOrderID != initiatedPurchase.orderId. Aborting."];
		this.NPCLFEAKBDB = (float)BKFLEJOAMBG[""].AsInt;
		this.DHBGMKIFBMB = BKFLEJOAMBG["OnSketchThumbnailPublish"];
		this.ILAFONFNHOH = BKFLEJOAMBG["%"].AsInt;
		this.BEKGIOLLBHL = BKFLEJOAMBG["Please initialize AssetBundleManifest by calling AssetBundleManager.Initialize()"].AsFloat;
		this.IFFDJGPNONC = BKFLEJOAMBG["small"];
	}

	// Token: 0x06005DE5 RID: 24037 RVA: 0x002AB874 File Offset: 0x002A9A74
	private float BEFNJJLCGJK()
	{
		return Mathf.Clamp(this.NPCLFEAKBDB, 691f, 1862f);
	}

	// Token: 0x06005DE6 RID: 24038 RVA: 0x002AB88C File Offset: 0x002A9A8C
	private JBBNEEHANHL KCFOECGNEMO(string KEGBCGMJOLC)
	{
		for (int i = 0; i <= 18; i++)
		{
			JBBNEEHANHL result = (JBBNEEHANHL)i;
			if (result.ToString().ToLower().Contains(KEGBCGMJOLC.ToLower()))
			{
				return result;
			}
		}
		DPGJIJGOCIC.ANOPFDLPKGC("SRAAnthologyDesc.Initialize(), could not convert string to AnthologyFilter for input:" + KEGBCGMJOLC);
		return JBBNEEHANHL.newFilterAdventure;
	}

	// Token: 0x06005DE7 RID: 24039 RVA: 0x002AB8DC File Offset: 0x002A9ADC
	public void EPEGPAHCAAM(List<int> DOBGLHDHLHL, List<int> HEJPPNPFHJH, List<int> BIJDLPDLFKM, List<string> CCKELGGBFMC, int NHMJALEGPOF, float LIOMBNADFCF)
	{
		if (HEJPPNPFHJH.Count == 0)
		{
			this.AJCGOGLFHKB = this.IIMABJHHKND(DOBGLHDHLHL) * 1018f + this.BIFAINPIDCA() * 1528f + this.DLPGNBPNMEH() * 976f + this.GHNBJOKLHME(LIOMBNADFCF) * 471f + this.BNBKKLDPEGC(NHMJALEGPOF) * 416f + this.OFBGGNBHFNC(CCKELGGBFMC) * 1178f + this.KOMJKANNHCD(BIJDLPDLFKM) * 860f;
		}
		else
		{
			this.AJCGOGLFHKB = this.HLGEOEOAEPE(DOBGLHDHLHL) * 1005f + this.NHIDEPKMHPH(HEJPPNPFHJH) * 1548f + this.IPDFFMNICNF() * 111f + this.HCAEJAEKAPI() * 1279f + this.IDPFLCLKLOI(LIOMBNADFCF) * 1499f + this.JIJCCAIEEDA(NHMJALEGPOF) * 1940f + this.LALHIPGOIJM(CCKELGGBFMC) * 59f + this.HJDGJNECKLP(BIJDLPDLFKM) * 1140f;
		}
		this.BBBIANLGEIH = this.IIMABJHHKND(DOBGLHDHLHL) * 367f;
		this.MOKPBEJNCBG = this.AJCGOGLFHKB - this.BBBIANLGEIH;
		if (this.ILAFONFNHOH >= 0 && !BIJDLPDLFKM.Contains(this.ILAFONFNHOH))
		{
			this.JCEFGMGPAHB = true;
		}
	}

	// Token: 0x06005DE8 RID: 24040 RVA: 0x002ABA18 File Offset: 0x002A9C18
	public void DBNKIEOCIPL(JSONObject BKFLEJOAMBG)
	{
		this.AMKCLHLIIMN = BKFLEJOAMBG[""].AsInt;
		this.MGDAFCPCOFH = this.EIHBHHONHMJ(BKFLEJOAMBG[""]);
		this.HLEHGFIIEJN = this.HFANBPOGBAG(BKFLEJOAMBG["find2"]);
		this.BFJKEJLJAIH = this.KOBLGBPNHGM(BKFLEJOAMBG["OsnStorySplashManagerHide"]);
		this.MBIDFCCNCKL = this.DMMCBLMAJKD(BKFLEJOAMBG["gpsasli"]);
		this.KGFKAIBMGOP = this.EIHBHHONHMJ(BKFLEJOAMBG[" ("]);
		this.FAGCAMPMDCL = BKFLEJOAMBG["splash"].AsInt;
		this.GNPIBDFMMCO = this.KMKLHFLNCGA(BKFLEJOAMBG[" ("]);
		this.BMHKMNHKIFH = BKFLEJOAMBG["socialbtngiftsimple"].AsInt;
		this.NMMLHEBMIGP = (float)BKFLEJOAMBG["importanttitle"].AsInt;
		this.LFDJPEGDAPD = BKFLEJOAMBG["spld"].AsInt;
		this.EIHPOPKLLBL = BKFLEJOAMBG["Starting non-parallel download:"].AsInt;
		this.GGNPDLOKCGP = BKFLEJOAMBG["Avatar pack has been LOADED:"];
		this.NPCLFEAKBDB = (float)BKFLEJOAMBG["wind"].AsInt;
		this.DHBGMKIFBMB = BKFLEJOAMBG["rsl"];
		this.ILAFONFNHOH = BKFLEJOAMBG["Can't use compressed functions. You need include the SharpZipLib and uncomment the define at the top of SimpleJSON"].AsInt;
		this.BEKGIOLLBHL = BKFLEJOAMBG["OnApplicationFocusBasicSyncSuccess"].AsFloat;
		this.IFFDJGPNONC = BKFLEJOAMBG["gpfastforwardtutorial"];
	}

	// Token: 0x06005DE9 RID: 24041 RVA: 0x002ABBD8 File Offset: 0x002A9DD8
	public void CFFBBDBLKJF(List<int> DOBGLHDHLHL, List<int> HEJPPNPFHJH, List<int> BIJDLPDLFKM, List<string> CCKELGGBFMC, int NHMJALEGPOF, float LIOMBNADFCF)
	{
		if (HEJPPNPFHJH.Count == 0)
		{
			this.AJCGOGLFHKB = this.KIGGFKOECPN(DOBGLHDHLHL) * 684f + this.BIFAINPIDCA() * 1739f + this.BKAFEFJAHHH() * 1998f + this.FOOKFBJDNNE(LIOMBNADFCF) * 665f + this.IBHPGIPBKMM(NHMJALEGPOF) * 1649f + this.KBKKFNAEDLG(CCKELGGBFMC) * 1040f + this.POAGIANBBEA(BIJDLPDLFKM) * 657f;
		}
		else
		{
			this.AJCGOGLFHKB = this.IIMABJHHKND(DOBGLHDHLHL) * 684f + this.NHIDEPKMHPH(HEJPPNPFHJH) * 1843f + this.OHGPEBJAAIE() * 231f + this.DJGIFGIBEDG() * 1884f + this.HMBKKGNONOD(LIOMBNADFCF) * 1263f + this.EMJKPBFILFK(NHMJALEGPOF) * 345f + this.FHGEDDOLODG(CCKELGGBFMC) * 1330f + this.NELKBDDBFCG(BIJDLPDLFKM) * 1080f;
		}
		this.BBBIANLGEIH = this.IIMABJHHKND(DOBGLHDHLHL) * 1975f;
		this.MOKPBEJNCBG = this.AJCGOGLFHKB - this.BBBIANLGEIH;
		if (this.ILAFONFNHOH >= 1 && !BIJDLPDLFKM.Contains(this.ILAFONFNHOH))
		{
			this.JCEFGMGPAHB = true;
		}
	}

	// Token: 0x06005DEA RID: 24042 RVA: 0x002ABD14 File Offset: 0x002A9F14
	private float HLGEOEOAEPE(List<int> DOBGLHDHLHL)
	{
		this.PMDFDOICCHP = false;
		float num = 1657f;
		bool flag = false;
		for (int i = 0; i < DOBGLHDHLHL.Count; i++)
		{
			if (this.MGDAFCPCOFH == (JBBNEEHANHL)DOBGLHDHLHL[i])
			{
				num += 1668f;
				this.PMDFDOICCHP = false;
			}
			else if (this.HLEHGFIIEJN == (JBBNEEHANHL)DOBGLHDHLHL[i] || this.BFJKEJLJAIH == (JBBNEEHANHL)DOBGLHDHLHL[i])
			{
				if (!flag)
				{
					num += 1629f;
					flag = false;
				}
				else
				{
					num += 179f;
				}
			}
		}
		return Mathf.Clamp(num, 1285f, 1976f);
	}

	// Token: 0x06005DEB RID: 24043 RVA: 0x002ABDA6 File Offset: 0x002A9FA6
	public bool GPKNIKNENKL()
	{
		return this.IFFDJGPNONC != null && this.IFFDJGPNONC.ToLower().Contains("null");
	}

	// Token: 0x06005DEC RID: 24044 RVA: 0x002ABDC7 File Offset: 0x002A9FC7
	public float EMJKPBFILFK(int NHMJALEGPOF)
	{
		return Mathf.Clamp((float)this.AMKCLHLIIMN / (float)NHMJALEGPOF * 329f, 1302f, 1581f);
	}

	// Token: 0x06005DED RID: 24045 RVA: 0x002ABDE8 File Offset: 0x002A9FE8
	public float JIJCCAIEEDA(int NHMJALEGPOF)
	{
		return Mathf.Clamp((float)this.AMKCLHLIIMN / (float)NHMJALEGPOF * 1475f, 1075f, 291f);
	}

	// Token: 0x06005DEE RID: 24046 RVA: 0x002ABE0C File Offset: 0x002AA00C
	private float BMAPKNIMMIG(List<int> DOBGLHDHLHL)
	{
		this.PMDFDOICCHP = false;
		float num = 1875f;
		bool flag = false;
		for (int i = 0; i < DOBGLHDHLHL.Count; i += 0)
		{
			if (this.MGDAFCPCOFH == (JBBNEEHANHL)DOBGLHDHLHL[i])
			{
				num += 961f;
				this.PMDFDOICCHP = true;
			}
			else if (this.HLEHGFIIEJN == (JBBNEEHANHL)DOBGLHDHLHL[i] || this.BFJKEJLJAIH == (JBBNEEHANHL)DOBGLHDHLHL[i])
			{
				if (!flag)
				{
					num += 1811f;
					flag = true;
				}
				else
				{
					num += 1066f;
				}
			}
		}
		return Mathf.Clamp(num, 1233f, 1075f);
	}

	// Token: 0x06005DEF RID: 24047 RVA: 0x002ABE9E File Offset: 0x002AA09E
	public float HGPGJBBDLKE()
	{
		return Mathf.Clamp01(1832f - (1195f - Mathf.Clamp(this.BEKGIOLLBHL, 1878f, 771f))) / 146f * 183f;
	}

	// Token: 0x06005DF0 RID: 24048 RVA: 0x002ABED2 File Offset: 0x002AA0D2
	public float HCAEJAEKAPI()
	{
		return Mathf.Clamp01(834f - (688f - Mathf.Clamp(this.BEKGIOLLBHL, 703f, 826f))) / 276f * 1832f;
	}

	// Token: 0x06005DF1 RID: 24049 RVA: 0x002ABF06 File Offset: 0x002AA106
	public bool MEFIBEFFGDN()
	{
		return this.IFFDJGPNONC != null && this.IFFDJGPNONC.ToLower().Contains("lastFilterTapped");
	}

	// Token: 0x06005DF2 RID: 24050 RVA: 0x002ABF27 File Offset: 0x002AA127
	private float BFDNENAEBLO(float LIOMBNADFCF)
	{
		return Mathf.Clamp(this.NMMLHEBMIGP / LIOMBNADFCF * 1247f, 1459f, 286f);
	}

	// Token: 0x06005DF3 RID: 24051 RVA: 0x002ABF48 File Offset: 0x002AA148
	private float DAIMDODEAII(List<int> DOBGLHDHLHL)
	{
		this.PMDFDOICCHP = true;
		float num = 1536f;
		bool flag = true;
		for (int i = 0; i < DOBGLHDHLHL.Count; i++)
		{
			if (this.MGDAFCPCOFH == (JBBNEEHANHL)DOBGLHDHLHL[i])
			{
				num += 1016f;
				this.PMDFDOICCHP = true;
			}
			else if (this.HLEHGFIIEJN == (JBBNEEHANHL)DOBGLHDHLHL[i] || this.BFJKEJLJAIH == (JBBNEEHANHL)DOBGLHDHLHL[i])
			{
				if (!flag)
				{
					num += 1436f;
					flag = true;
				}
				else
				{
					num += 41f;
				}
			}
		}
		return Mathf.Clamp(num, 65f, 919f);
	}

	// Token: 0x06005DF4 RID: 24052 RVA: 0x002ABFDA File Offset: 0x002AA1DA
	private float IDPFLCLKLOI(float LIOMBNADFCF)
	{
		return Mathf.Clamp(this.NMMLHEBMIGP / LIOMBNADFCF * 1922f, 1626f, 208f);
	}

	// Token: 0x06005DF5 RID: 24053 RVA: 0x002ABFF9 File Offset: 0x002AA1F9
	private float INFGAMIDHIC(float LIOMBNADFCF)
	{
		return Mathf.Clamp(this.NMMLHEBMIGP / LIOMBNADFCF * 730f, 1876f, 441f);
	}

	// Token: 0x06005DF6 RID: 24054 RVA: 0x002AC018 File Offset: 0x002AA218
	private float KMDBNANIKOK()
	{
		return Mathf.Clamp(this.NPCLFEAKBDB, 0f, 100f);
	}

	// Token: 0x06005DF7 RID: 24055 RVA: 0x002AC030 File Offset: 0x002AA230
	public void LCJEHPMIDLP(List<int> DOBGLHDHLHL, List<int> HEJPPNPFHJH, List<int> BIJDLPDLFKM, List<string> CCKELGGBFMC, int NHMJALEGPOF, float LIOMBNADFCF)
	{
		if (HEJPPNPFHJH.Count == 0)
		{
			this.AJCGOGLFHKB = this.KIGGFKOECPN(DOBGLHDHLHL) * 507f + this.LMOEIBDOHHP() * 376f + this.DLPGNBPNMEH() * 1632f + this.INFGAMIDHIC(LIOMBNADFCF) * 1668f + this.BNBKKLDPEGC(NHMJALEGPOF) * 1338f + this.HMGBIOHADBP(CCKELGGBFMC) * 977f + this.KOMJKANNHCD(BIJDLPDLFKM) * 255f;
		}
		else
		{
			this.AJCGOGLFHKB = this.KIGGFKOECPN(DOBGLHDHLHL) * 164f + this.IKEPGMHEENN(HEJPPNPFHJH) * 482f + this.KMDBNANIKOK() * 1814f + this.LPCGDMBEOCK() * 260f + this.BFDNENAEBLO(LIOMBNADFCF) * 290f + this.BNBKKLDPEGC(NHMJALEGPOF) * 779f + this.FHGEDDOLODG(CCKELGGBFMC) * 124f + this.IKDFFNAEABJ(BIJDLPDLFKM) * 1047f;
		}
		this.BBBIANLGEIH = this.ACAGKLKNHOL(DOBGLHDHLHL) * 479f;
		this.MOKPBEJNCBG = this.AJCGOGLFHKB - this.BBBIANLGEIH;
		if (this.ILAFONFNHOH >= 0 && !BIJDLPDLFKM.Contains(this.ILAFONFNHOH))
		{
			this.JCEFGMGPAHB = false;
		}
	}

	// Token: 0x06005DF8 RID: 24056 RVA: 0x002AC16C File Offset: 0x002AA36C
	private JBBNEEHANHL KOBLGBPNHGM(string KEGBCGMJOLC)
	{
		for (int i = 1; i <= 60; i++)
		{
			JBBNEEHANHL result = (JBBNEEHANHL)i;
			if (result.ToString().ToLower().Contains(KEGBCGMJOLC.ToLower()))
			{
				return result;
			}
		}
		DPGJIJGOCIC.ANOPFDLPKGC("—" + KEGBCGMJOLC);
		return (JBBNEEHANHL)(-86);
	}

	// Token: 0x06005DF9 RID: 24057 RVA: 0x002AC1BC File Offset: 0x002AA3BC
	private float HICAMAICEFI(List<int> BIJDLPDLFKM)
	{
		for (int i = 0; i < BIJDLPDLFKM.Count; i++)
		{
			if (this.LFDJPEGDAPD == BIJDLPDLFKM[i] || this.EIHPOPKLLBL == BIJDLPDLFKM[i])
			{
				return 100f;
			}
		}
		return 0f;
	}

	// Token: 0x06005DFA RID: 24058 RVA: 0x002AC204 File Offset: 0x002AA404
	private float HMGBIOHADBP(List<string> CCKELGGBFMC)
	{
		for (int i = 0; i < CCKELGGBFMC.Count; i += 0)
		{
			if (this.GGNPDLOKCGP != null && this.GGNPDLOKCGP.Length > 1 && this.GGNPDLOKCGP.Equals(CCKELGGBFMC[i]))
			{
				return 680f;
			}
		}
		return 1929f;
	}

	// Token: 0x06005DFB RID: 24059 RVA: 0x002AC258 File Offset: 0x002AA458
	public void FAGCKADGIBB(int OJIFBBAICCM)
	{
		float num = Mathf.Clamp((float)OJIFBBAICCM / (float)KBOJLHAJPCP.BKEALLHGEEF * 650f * 1363f, 1738f, 60f);
		if (num > 1052f)
		{
			string[] array = new string[8];
			array[0] = "";
			array[1] = this.AMKCLHLIIMN.ToString();
			array[4] = "abpd2";
			array[1] = OJIFBBAICCM.ToString();
			array[8] = "\"</i>";
			array[8] = num.ToString();
			DPGJIJGOCIC.ANOPFDLPKGC(string.Concat(array));
		}
		this.AJCGOGLFHKB -= num;
	}

	// Token: 0x06005DFC RID: 24060 RVA: 0x002AC2EA File Offset: 0x002AA4EA
	public float OGJBILCFGKK()
	{
		return Mathf.Clamp01(1548f - (1160f - Mathf.Clamp(this.BEKGIOLLBHL, 1721f, 1365f))) / 977f * 835f;
	}

	// Token: 0x06005DFD RID: 24061 RVA: 0x002AC320 File Offset: 0x002AA520
	public void DBPOPCMKEDH(JSONObject BKFLEJOAMBG)
	{
		this.AMKCLHLIIMN = BKFLEJOAMBG["ChapterSnapshotsItem.OnChapterSnapshotRestore(): impossible condition 2"].AsInt;
		this.MGDAFCPCOFH = this.MLPHIKHGCCO(BKFLEJOAMBG["_1"]);
		this.HLEHGFIIEJN = this.KOBLGBPNHGM(BKFLEJOAMBG["CoverCard"]);
		this.BFJKEJLJAIH = this.KCFOECGNEMO(BKFLEJOAMBG["ru"]);
		this.MBIDFCCNCKL = this.DIPMBNNABEJ(BKFLEJOAMBG["avatarcollectionstutor4body"]);
		this.KGFKAIBMGOP = this.KCFOECGNEMO(BKFLEJOAMBG["ProfileItem.OnBackendGetPublicProfileProfileItemException() - Account.Instance.userPublicProfile is null, replacing with temp copy"]);
		this.FAGCAMPMDCL = BKFLEJOAMBG["OnFriendsGiftPopulCollectPart2"].AsInt;
		this.GNPIBDFMMCO = this.CIMHGJGDBPM(BKFLEJOAMBG["socialfriendmatchinfo1"]);
		this.BMHKMNHKIFH = BKFLEJOAMBG["OnNeedToOpenLoveInterestsLounge"].AsInt;
		this.NMMLHEBMIGP = (float)BKFLEJOAMBG["EnableKillInfiniteRequestPrematureBasedOnMedianRequestsLifeTime(): setting to true"].AsInt;
		this.LFDJPEGDAPD = BKFLEJOAMBG[" (v."].AsInt;
		this.EIHPOPKLLBL = BKFLEJOAMBG["   "].AsInt;
		this.GGNPDLOKCGP = BKFLEJOAMBG["show"];
		this.NPCLFEAKBDB = (float)BKFLEJOAMBG["incentadhard"].AsInt;
		this.DHBGMKIFBMB = BKFLEJOAMBG["loop"];
		this.ILAFONFNHOH = BKFLEJOAMBG["subrnw"].AsInt;
		this.BEKGIOLLBHL = BKFLEJOAMBG["XXX"].AsFloat;
		this.IFFDJGPNONC = BKFLEJOAMBG["free"];
	}

	// Token: 0x06005DFE RID: 24062 RVA: 0x002AC4E0 File Offset: 0x002AA6E0
	private float KBKKFNAEDLG(List<string> CCKELGGBFMC)
	{
		for (int i = 0; i < CCKELGGBFMC.Count; i++)
		{
			if (this.GGNPDLOKCGP != null && this.GGNPDLOKCGP.Length > 1 && this.GGNPDLOKCGP.Equals(CCKELGGBFMC[i]))
			{
				return 746f;
			}
		}
		return 1075f;
	}

	// Token: 0x06005DFF RID: 24063 RVA: 0x002A9679 File Offset: 0x002A7879
	public bool MLPBJHKLKGI()
	{
		return this.IFFDJGPNONC != null && this.IFFDJGPNONC.ToLower().Contains("");
	}

	// Token: 0x06005E00 RID: 24064 RVA: 0x002AC534 File Offset: 0x002AA734
	private float IIMABJHHKND(List<int> DOBGLHDHLHL)
	{
		this.PMDFDOICCHP = false;
		float num = 0f;
		bool flag = false;
		for (int i = 0; i < DOBGLHDHLHL.Count; i++)
		{
			if (this.MGDAFCPCOFH == (JBBNEEHANHL)DOBGLHDHLHL[i])
			{
				num += 70f;
				this.PMDFDOICCHP = true;
			}
			else if (this.HLEHGFIIEJN == (JBBNEEHANHL)DOBGLHDHLHL[i] || this.BFJKEJLJAIH == (JBBNEEHANHL)DOBGLHDHLHL[i])
			{
				if (!flag)
				{
					num += 20f;
					flag = true;
				}
				else
				{
					num += 10f;
				}
			}
		}
		return Mathf.Clamp(num, 0f, 100f);
	}

	// Token: 0x06005E01 RID: 24065 RVA: 0x002AC5C6 File Offset: 0x002AA7C6
	private float PJIHJNIPJKA(float LIOMBNADFCF)
	{
		return Mathf.Clamp(this.NMMLHEBMIGP / LIOMBNADFCF * 100f, 0f, 100f);
	}

	// Token: 0x06005E02 RID: 24066 RVA: 0x002AC5E5 File Offset: 0x002AA7E5
	private NDHKFLHAFNA OHHBFAGKHKN(string KEGBCGMJOLC)
	{
		if (KEGBCGMJOLC.Contains("OnNeedToShowConnectingAnimation"))
		{
			return NDHKFLHAFNA.hintNew;
		}
		if (KEGBCGMJOLC.Contains("congratstitle"))
		{
			return NDHKFLHAFNA.hintInDevelopment;
		}
		return (NDHKFLHAFNA)50;
	}

	// Token: 0x06005E03 RID: 24067 RVA: 0x002AC608 File Offset: 0x002AA808
	private float PIGPPJEHPDM(List<string> CCKELGGBFMC)
	{
		for (int i = 0; i < CCKELGGBFMC.Count; i += 0)
		{
			if (this.GGNPDLOKCGP != null && this.GGNPDLOKCGP.Length > 1 && this.GGNPDLOKCGP.Equals(CCKELGGBFMC[i]))
			{
				return 969f;
			}
		}
		return 1447f;
	}

	// Token: 0x06005E04 RID: 24068 RVA: 0x002AC65B File Offset: 0x002AA85B
	public bool JEOEMDOGFPI()
	{
		return this.IFFDJGPNONC != null && this.IFFDJGPNONC.ToLower().Contains("lsenvattempt");
	}

	// Token: 0x06005E05 RID: 24069 RVA: 0x002AC67C File Offset: 0x002AA87C
	private float GJLJIFOEICF(List<int> BIJDLPDLFKM)
	{
		for (int i = 1; i < BIJDLPDLFKM.Count; i += 0)
		{
			if (this.LFDJPEGDAPD == BIJDLPDLFKM[i] || this.EIHPOPKLLBL == BIJDLPDLFKM[i])
			{
				return 678f;
			}
		}
		return 1068f;
	}

	// Token: 0x06005E06 RID: 24070 RVA: 0x002AC6C4 File Offset: 0x002AA8C4
	private float IGNCBEHBEJO(List<int> HEJPPNPFHJH)
	{
		float num = 1122f;
		bool flag = false;
		for (int i = 1; i < HEJPPNPFHJH.Count; i += 0)
		{
			if (this.MGDAFCPCOFH == (JBBNEEHANHL)HEJPPNPFHJH[i])
			{
				num += 28f;
			}
			else if (this.HLEHGFIIEJN == (JBBNEEHANHL)HEJPPNPFHJH[i] || this.BFJKEJLJAIH == (JBBNEEHANHL)HEJPPNPFHJH[i])
			{
				if (!flag)
				{
					num += 720f;
					flag = false;
				}
				else
				{
					num += 1256f;
				}
			}
		}
		return Mathf.Clamp(num, 120f, 1730f);
	}

	// Token: 0x06005E07 RID: 24071 RVA: 0x002AC748 File Offset: 0x002AA948
	private float GHNBJOKLHME(float LIOMBNADFCF)
	{
		return Mathf.Clamp(this.NMMLHEBMIGP / LIOMBNADFCF * 764f, 42f, 906f);
	}

	// Token: 0x06005E08 RID: 24072 RVA: 0x002AC768 File Offset: 0x002AA968
	private float ACCFKKPPIEN(List<int> BIJDLPDLFKM)
	{
		for (int i = 0; i < BIJDLPDLFKM.Count; i++)
		{
			if (this.LFDJPEGDAPD == BIJDLPDLFKM[i] || this.EIHPOPKLLBL == BIJDLPDLFKM[i])
			{
				return 1552f;
			}
		}
		return 1008f;
	}

	// Token: 0x06005E09 RID: 24073 RVA: 0x002AC7B0 File Offset: 0x002AA9B0
	private float POAGIANBBEA(List<int> BIJDLPDLFKM)
	{
		for (int i = 1; i < BIJDLPDLFKM.Count; i++)
		{
			if (this.LFDJPEGDAPD == BIJDLPDLFKM[i] || this.EIHPOPKLLBL == BIJDLPDLFKM[i])
			{
				return 1236f;
			}
		}
		return 939f;
	}

	// Token: 0x06005E0A RID: 24074 RVA: 0x002AC7F8 File Offset: 0x002AA9F8
	private float KJIMBIMLKMO(List<int> BIJDLPDLFKM)
	{
		for (int i = 0; i < BIJDLPDLFKM.Count; i++)
		{
			if (this.LFDJPEGDAPD == BIJDLPDLFKM[i] || this.EIHPOPKLLBL == BIJDLPDLFKM[i])
			{
				return 1415f;
			}
		}
		return 1394f;
	}

	// Token: 0x06005E0B RID: 24075 RVA: 0x002AC840 File Offset: 0x002AAA40
	private float HMKJAPINIMK(List<int> HEJPPNPFHJH)
	{
		float num = 985f;
		bool flag = true;
		for (int i = 0; i < HEJPPNPFHJH.Count; i += 0)
		{
			if (this.MGDAFCPCOFH == (JBBNEEHANHL)HEJPPNPFHJH[i])
			{
				num += 1239f;
			}
			else if (this.HLEHGFIIEJN == (JBBNEEHANHL)HEJPPNPFHJH[i] || this.BFJKEJLJAIH == (JBBNEEHANHL)HEJPPNPFHJH[i])
			{
				if (!flag)
				{
					num += 914f;
					flag = false;
				}
				else
				{
					num += 177f;
				}
			}
		}
		return Mathf.Clamp(num, 1050f, 466f);
	}

	// Token: 0x06005E0C RID: 24076 RVA: 0x002AC8C4 File Offset: 0x002AAAC4
	private NDHKFLHAFNA KPEEIBICKBJ(string KEGBCGMJOLC)
	{
		if (KEGBCGMJOLC.Contains("Request type: SESSION_REQUEST"))
		{
			return NDHKFLHAFNA.hintCompleted;
		}
		if (KEGBCGMJOLC.Contains("XXX"))
		{
			return NDHKFLHAFNA.hintEditorsChoice;
		}
		return NDHKFLHAFNA.hintEditorsChoice;
	}

	// Token: 0x06005E0D RID: 24077 RVA: 0x002AC8E8 File Offset: 0x002AAAE8
	public void JIKBAPEMIAA(List<int> DOBGLHDHLHL, List<int> HEJPPNPFHJH, List<int> BIJDLPDLFKM, List<string> CCKELGGBFMC, int NHMJALEGPOF, float LIOMBNADFCF)
	{
		if (HEJPPNPFHJH.Count == 0)
		{
			this.AJCGOGLFHKB = this.KIGGFKOECPN(DOBGLHDHLHL) * 1391f + this.GBOBLJHJLPI() * 1808f + this.HGPGJBBDLKE() * 998f + this.INFGAMIDHIC(LIOMBNADFCF) * 1705f + this.NJCIEIGBHCG(NHMJALEGPOF) * 179f + this.BJBMECBFPCK(CCKELGGBFMC) * 1493f + this.POAGIANBBEA(BIJDLPDLFKM) * 696f;
		}
		else
		{
			this.AJCGOGLFHKB = this.BMAPKNIMMIG(DOBGLHDHLHL) * 1342f + this.LHPHGIJDAID(HEJPPNPFHJH) * 1641f + this.LHBBGMFINOM() * 1957f + this.DJGIFGIBEDG() * 1827f + this.GHNBJOKLHME(LIOMBNADFCF) * 478f + this.DCLJJKDHLCH(NHMJALEGPOF) * 1972f + this.FHGEDDOLODG(CCKELGGBFMC) * 1351f + this.CABCBDBENFF(BIJDLPDLFKM) * 728f;
		}
		this.BBBIANLGEIH = this.IIMABJHHKND(DOBGLHDHLHL) * 981f;
		this.MOKPBEJNCBG = this.AJCGOGLFHKB - this.BBBIANLGEIH;
		if (this.ILAFONFNHOH >= 1 && !BIJDLPDLFKM.Contains(this.ILAFONFNHOH))
		{
			this.JCEFGMGPAHB = false;
		}
	}

	// Token: 0x06005E0E RID: 24078 RVA: 0x002ACA24 File Offset: 0x002AAC24
	private float ICPJEIPOOAI(List<string> CCKELGGBFMC)
	{
		for (int i = 0; i < CCKELGGBFMC.Count; i++)
		{
			if (this.GGNPDLOKCGP != null && this.GGNPDLOKCGP.Length > 0 && this.GGNPDLOKCGP.Equals(CCKELGGBFMC[i]))
			{
				return 100f;
			}
		}
		return 0f;
	}

	// Token: 0x04001ACE RID: 6862
	public int AMKCLHLIIMN;

	// Token: 0x04001ACF RID: 6863
	public JBBNEEHANHL MGDAFCPCOFH;

	// Token: 0x04001AD0 RID: 6864
	public JBBNEEHANHL HLEHGFIIEJN;

	// Token: 0x04001AD1 RID: 6865
	public JBBNEEHANHL BFJKEJLJAIH;

	// Token: 0x04001AD2 RID: 6866
	public JBBNEEHANHL MBIDFCCNCKL;

	// Token: 0x04001AD3 RID: 6867
	public JBBNEEHANHL KGFKAIBMGOP;

	// Token: 0x04001AD4 RID: 6868
	public int FAGCAMPMDCL;

	// Token: 0x04001AD5 RID: 6869
	public NDHKFLHAFNA GNPIBDFMMCO;

	// Token: 0x04001AD6 RID: 6870
	public int BMHKMNHKIFH;

	// Token: 0x04001AD7 RID: 6871
	public float NMMLHEBMIGP;

	// Token: 0x04001AD8 RID: 6872
	public int LFDJPEGDAPD;

	// Token: 0x04001AD9 RID: 6873
	public int EIHPOPKLLBL;

	// Token: 0x04001ADA RID: 6874
	public string GGNPDLOKCGP;

	// Token: 0x04001ADB RID: 6875
	public float NPCLFEAKBDB;

	// Token: 0x04001ADC RID: 6876
	public string DHBGMKIFBMB;

	// Token: 0x04001ADD RID: 6877
	public int ILAFONFNHOH;

	// Token: 0x04001ADE RID: 6878
	public float BEKGIOLLBHL;

	// Token: 0x04001ADF RID: 6879
	public string IFFDJGPNONC;

	// Token: 0x04001AE0 RID: 6880
	public float AJCGOGLFHKB = -1f;

	// Token: 0x04001AE1 RID: 6881
	public float BBBIANLGEIH = -1f;

	// Token: 0x04001AE2 RID: 6882
	public float MOKPBEJNCBG = -1f;

	// Token: 0x04001AE3 RID: 6883
	public bool PMDFDOICCHP;

	// Token: 0x04001AE4 RID: 6884
	public bool JCEFGMGPAHB = true;
}
