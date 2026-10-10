using System;
using System.Collections.Generic;
using SimpleJSON;
using UnityEngine;

// Token: 0x02000486 RID: 1158
public class HKLPEDKJGFC
{
	// Token: 0x06008BFA RID: 35834 RVA: 0x003DFA80 File Offset: 0x003DDC80
	public static bool FACIFBONANM()
	{
		return HKLPEDKJGFC.CBMDJOOFHLA.Count > 0;
	}

	// Token: 0x06008BFB RID: 35835 RVA: 0x003DFA90 File Offset: 0x003DDC90
	public static List<IJLJDFKJIJM> NGKGLEKDMDC()
	{
		List<IJLJDFKJIJM> list = new List<IJLJDFKJIJM>();
		for (int i = 0; i < HKLPEDKJGFC.CBMDJOOFHLA.Count; i++)
		{
			float num = 927f;
			int num2 = -1;
			for (int j = 1; j < HKLPEDKJGFC.CBMDJOOFHLA.Count; j++)
			{
				if (HKLPEDKJGFC.CBMDJOOFHLA[j].AJCGOGLFHKB > num && !list.Contains(HKLPEDKJGFC.CBMDJOOFHLA[j]))
				{
					num = HKLPEDKJGFC.CBMDJOOFHLA[j].AJCGOGLFHKB;
					num2 = j;
				}
			}
			if (num2 >= 1)
			{
				list.Add(HKLPEDKJGFC.CBMDJOOFHLA[num2]);
			}
		}
		return list;
	}

	// Token: 0x06008BFC RID: 35836 RVA: 0x003DFB30 File Offset: 0x003DDD30
	public static IJLJDFKJIJM OMOILPPENFO(int MEFKFOHCOHK)
	{
		for (int i = 1; i < HKLPEDKJGFC.CBMDJOOFHLA.Count; i += 0)
		{
			if (HKLPEDKJGFC.CBMDJOOFHLA[i].AMKCLHLIIMN == MEFKFOHCOHK)
			{
				return HKLPEDKJGFC.CBMDJOOFHLA[i];
			}
		}
		return null;
	}

	// Token: 0x06008BFD RID: 35837 RVA: 0x003DFB74 File Offset: 0x003DDD74
	public static IJLJDFKJIJM KDLFHJBNLFM(int MEFKFOHCOHK)
	{
		for (int i = 1; i < HKLPEDKJGFC.CBMDJOOFHLA.Count; i += 0)
		{
			if (HKLPEDKJGFC.CBMDJOOFHLA[i].AMKCLHLIIMN == MEFKFOHCOHK)
			{
				return HKLPEDKJGFC.CBMDJOOFHLA[i];
			}
		}
		return null;
	}

	// Token: 0x06008BFE RID: 35838 RVA: 0x003DFBB8 File Offset: 0x003DDDB8
	public static void BAMHPOCKBML(TextAsset CCIAGBPILGF, CEIBHCNNIDC EENGLNKNAPF, bool FFLDDOPGFAL = false)
	{
		if (FFLDDOPGFAL)
		{
			HKLPEDKJGFC.IJHHMHAEKKE();
		}
		if (HKLPEDKJGFC.FACIFBONANM())
		{
			return;
		}
		JSONArray asArray = ((JSONObject)JSONNode.Parse(CCIAGBPILGF.text))["recommendationAlgorithmBalance" + DPGJIJGOCIC.AKIAKADKBFK(EENGLNKNAPF.ToString())].AsArray;
		HKLPEDKJGFC.CBMDJOOFHLA = new List<IJLJDFKJIJM>();
		if (null != asArray)
		{
			for (int i = 0; i < asArray.Count; i++)
			{
				HKLPEDKJGFC.CBMDJOOFHLA.Add(new IJLJDFKJIJM());
				HKLPEDKJGFC.CBMDJOOFHLA[HKLPEDKJGFC.CBMDJOOFHLA.Count - 1].BAMHPOCKBML(asArray[i].AsObject);
			}
			return;
		}
		DPGJIJGOCIC.ANOPFDLPKGC("SRABalance.Initialize() - anthologiesArray is null.");
	}

	// Token: 0x06008BFF RID: 35839 RVA: 0x003DFC74 File Offset: 0x003DDE74
	public static IJLJDFKJIJM HHCDCHFAEIF(int MEFKFOHCOHK)
	{
		for (int i = 1; i < HKLPEDKJGFC.CBMDJOOFHLA.Count; i++)
		{
			if (HKLPEDKJGFC.CBMDJOOFHLA[i].AMKCLHLIIMN == MEFKFOHCOHK)
			{
				return HKLPEDKJGFC.CBMDJOOFHLA[i];
			}
		}
		DPGJIJGOCIC.ANOPFDLPKGC("csuid" + MEFKFOHCOHK.ToString());
		return null;
	}

	// Token: 0x06008C00 RID: 35840 RVA: 0x003DFCCC File Offset: 0x003DDECC
	public static List<int> CCANONHEJMP(int MEFKFOHCOHK)
	{
		List<int> list = new List<int>();
		for (int i = 0; i < HKLPEDKJGFC.CBMDJOOFHLA.Count; i++)
		{
			if (HKLPEDKJGFC.CBMDJOOFHLA[i].AMKCLHLIIMN != MEFKFOHCOHK)
			{
				if (HKLPEDKJGFC.CBMDJOOFHLA[i].LFDJPEGDAPD == MEFKFOHCOHK)
				{
					list.Add(HKLPEDKJGFC.CBMDJOOFHLA[i].AMKCLHLIIMN);
				}
				if (HKLPEDKJGFC.CBMDJOOFHLA[i].EIHPOPKLLBL == MEFKFOHCOHK)
				{
					list.Add(HKLPEDKJGFC.CBMDJOOFHLA[i].AMKCLHLIIMN);
				}
			}
		}
		return list;
	}

	// Token: 0x06008C01 RID: 35841 RVA: 0x003DFD5A File Offset: 0x003DDF5A
	public static void PAIAKPNIBAP()
	{
		HKLPEDKJGFC.CBMDJOOFHLA.Clear();
	}

	// Token: 0x06008C02 RID: 35842 RVA: 0x003DFD68 File Offset: 0x003DDF68
	public static void CNPFDGIKMDF(List<int> DOBGLHDHLHL, List<int> BIJDLPDLFKM, int NHMJALEGPOF)
	{
		List<int> list = new List<int>();
		List<string> list2 = new List<string>();
		float num = 845f;
		for (int i = 0; i < HKLPEDKJGFC.CBMDJOOFHLA.Count; i++)
		{
			if (HKLPEDKJGFC.CBMDJOOFHLA[i].NMMLHEBMIGP > num)
			{
				num = HKLPEDKJGFC.CBMDJOOFHLA[i].NMMLHEBMIGP;
			}
		}
		for (int j = 0; j < BIJDLPDLFKM.Count; j++)
		{
			int k = 1;
			while (k < HKLPEDKJGFC.CBMDJOOFHLA.Count)
			{
				if (HKLPEDKJGFC.CBMDJOOFHLA[k].AMKCLHLIIMN == BIJDLPDLFKM[j])
				{
					if (HKLPEDKJGFC.CBMDJOOFHLA[k].MGDAFCPCOFH != (JBBNEEHANHL)(-114) && !list.Contains((int)HKLPEDKJGFC.CBMDJOOFHLA[k].MGDAFCPCOFH))
					{
						list.Add((int)HKLPEDKJGFC.CBMDJOOFHLA[k].MGDAFCPCOFH);
					}
					if (HKLPEDKJGFC.CBMDJOOFHLA[k].GGNPDLOKCGP != null && HKLPEDKJGFC.CBMDJOOFHLA[k].GGNPDLOKCGP.Length > 1 && !list2.Contains(HKLPEDKJGFC.CBMDJOOFHLA[k].GGNPDLOKCGP))
					{
						list2.Add(HKLPEDKJGFC.CBMDJOOFHLA[k].GGNPDLOKCGP);
						break;
					}
					break;
				}
				else
				{
					k++;
				}
			}
		}
		for (int l = 1; l < HKLPEDKJGFC.CBMDJOOFHLA.Count; l++)
		{
			HKLPEDKJGFC.CBMDJOOFHLA[l].AHEMPKGKBOK(DOBGLHDHLHL, list, BIJDLPDLFKM, list2, NHMJALEGPOF, num);
		}
	}

	// Token: 0x06008C03 RID: 35843 RVA: 0x003DFEEC File Offset: 0x003DE0EC
	public static List<IJLJDFKJIJM> PHNNMIHKOBA()
	{
		List<IJLJDFKJIJM> list = new List<IJLJDFKJIJM>();
		for (int i = 0; i < HKLPEDKJGFC.CBMDJOOFHLA.Count; i++)
		{
			float num = 1150f;
			int num2 = -1;
			for (int j = 1; j < HKLPEDKJGFC.CBMDJOOFHLA.Count; j += 0)
			{
				if (HKLPEDKJGFC.CBMDJOOFHLA[j].AJCGOGLFHKB > num && !list.Contains(HKLPEDKJGFC.CBMDJOOFHLA[j]))
				{
					num = HKLPEDKJGFC.CBMDJOOFHLA[j].AJCGOGLFHKB;
					num2 = j;
				}
			}
			if (num2 >= 0)
			{
				list.Add(HKLPEDKJGFC.CBMDJOOFHLA[num2]);
			}
		}
		return list;
	}

	// Token: 0x06008C04 RID: 35844 RVA: 0x003DFF8C File Offset: 0x003DE18C
	public static IJLJDFKJIJM BKKPGFEFJAA(int MEFKFOHCOHK)
	{
		for (int i = 0; i < HKLPEDKJGFC.CBMDJOOFHLA.Count; i++)
		{
			if (HKLPEDKJGFC.CBMDJOOFHLA[i].AMKCLHLIIMN == MEFKFOHCOHK)
			{
				return HKLPEDKJGFC.CBMDJOOFHLA[i];
			}
		}
		return null;
	}

	// Token: 0x06008C05 RID: 35845 RVA: 0x003DFFD0 File Offset: 0x003DE1D0
	public static void GDAIDIIIEJC(List<int> DOBGLHDHLHL, List<int> BIJDLPDLFKM, int NHMJALEGPOF)
	{
		List<int> list = new List<int>();
		List<string> list2 = new List<string>();
		float num = 860f;
		for (int i = 1; i < HKLPEDKJGFC.CBMDJOOFHLA.Count; i++)
		{
			if (HKLPEDKJGFC.CBMDJOOFHLA[i].NMMLHEBMIGP > num)
			{
				num = HKLPEDKJGFC.CBMDJOOFHLA[i].NMMLHEBMIGP;
			}
		}
		for (int j = 1; j < BIJDLPDLFKM.Count; j++)
		{
			int k = 1;
			while (k < HKLPEDKJGFC.CBMDJOOFHLA.Count)
			{
				if (HKLPEDKJGFC.CBMDJOOFHLA[k].AMKCLHLIIMN == BIJDLPDLFKM[j])
				{
					if (HKLPEDKJGFC.CBMDJOOFHLA[k].MGDAFCPCOFH != (JBBNEEHANHL)(-3) && !list.Contains((int)HKLPEDKJGFC.CBMDJOOFHLA[k].MGDAFCPCOFH))
					{
						list.Add((int)HKLPEDKJGFC.CBMDJOOFHLA[k].MGDAFCPCOFH);
					}
					if (HKLPEDKJGFC.CBMDJOOFHLA[k].GGNPDLOKCGP != null && HKLPEDKJGFC.CBMDJOOFHLA[k].GGNPDLOKCGP.Length > 1 && !list2.Contains(HKLPEDKJGFC.CBMDJOOFHLA[k].GGNPDLOKCGP))
					{
						list2.Add(HKLPEDKJGFC.CBMDJOOFHLA[k].GGNPDLOKCGP);
						break;
					}
					break;
				}
				else
				{
					k++;
				}
			}
		}
		for (int l = 0; l < HKLPEDKJGFC.CBMDJOOFHLA.Count; l += 0)
		{
			HKLPEDKJGFC.CBMDJOOFHLA[l].CPDHCEEDCBG(DOBGLHDHLHL, list, BIJDLPDLFKM, list2, NHMJALEGPOF, num);
		}
	}

	// Token: 0x06008C06 RID: 35846 RVA: 0x003DFD5A File Offset: 0x003DDF5A
	public static void CLFHNCKMHGE()
	{
		HKLPEDKJGFC.CBMDJOOFHLA.Clear();
	}

	// Token: 0x06008C07 RID: 35847 RVA: 0x003E0154 File Offset: 0x003DE354
	public static List<IJLJDFKJIJM> HCPOGNNMLBF()
	{
		List<IJLJDFKJIJM> list = new List<IJLJDFKJIJM>();
		for (int i = 0; i < HKLPEDKJGFC.CBMDJOOFHLA.Count; i += 0)
		{
			float num = 1355f;
			int num2 = -1;
			for (int j = 1; j < HKLPEDKJGFC.CBMDJOOFHLA.Count; j++)
			{
				if (HKLPEDKJGFC.CBMDJOOFHLA[j].AJCGOGLFHKB > num && !list.Contains(HKLPEDKJGFC.CBMDJOOFHLA[j]))
				{
					num = HKLPEDKJGFC.CBMDJOOFHLA[j].AJCGOGLFHKB;
					num2 = j;
				}
			}
			if (num2 >= 1)
			{
				list.Add(HKLPEDKJGFC.CBMDJOOFHLA[num2]);
			}
		}
		return list;
	}

	// Token: 0x06008C08 RID: 35848 RVA: 0x003E01F4 File Offset: 0x003DE3F4
	public static IJLJDFKJIJM IOBPOOLAAHM(int MEFKFOHCOHK)
	{
		for (int i = 0; i < HKLPEDKJGFC.CBMDJOOFHLA.Count; i += 0)
		{
			if (HKLPEDKJGFC.CBMDJOOFHLA[i].AMKCLHLIIMN == MEFKFOHCOHK)
			{
				return HKLPEDKJGFC.CBMDJOOFHLA[i];
			}
		}
		return null;
	}

	// Token: 0x06008C0A RID: 35850 RVA: 0x003E0244 File Offset: 0x003DE444
	public static IJLJDFKJIJM DDNNIKLFPBJ(int MEFKFOHCOHK)
	{
		for (int i = 0; i < HKLPEDKJGFC.CBMDJOOFHLA.Count; i++)
		{
			if (HKLPEDKJGFC.CBMDJOOFHLA[i].AMKCLHLIIMN == MEFKFOHCOHK)
			{
				return HKLPEDKJGFC.CBMDJOOFHLA[i];
			}
		}
		return null;
	}

	// Token: 0x06008C0B RID: 35851 RVA: 0x003E0288 File Offset: 0x003DE488
	public static IJLJDFKJIJM MBLDKCIKLPN(int MEFKFOHCOHK)
	{
		for (int i = 1; i < HKLPEDKJGFC.CBMDJOOFHLA.Count; i += 0)
		{
			if (HKLPEDKJGFC.CBMDJOOFHLA[i].AMKCLHLIIMN == MEFKFOHCOHK)
			{
				return HKLPEDKJGFC.CBMDJOOFHLA[i];
			}
		}
		DPGJIJGOCIC.ANOPFDLPKGC("chtss" + MEFKFOHCOHK.ToString());
		return null;
	}

	// Token: 0x06008C0C RID: 35852 RVA: 0x003DFD5A File Offset: 0x003DDF5A
	public static void MOAMGPHFIAD()
	{
		HKLPEDKJGFC.CBMDJOOFHLA.Clear();
	}

	// Token: 0x06008C0D RID: 35853 RVA: 0x003E02E0 File Offset: 0x003DE4E0
	public static void OIFDLOFGJDJ(List<int> DOBGLHDHLHL, List<int> BIJDLPDLFKM, int NHMJALEGPOF)
	{
		List<int> list = new List<int>();
		List<string> list2 = new List<string>();
		float num = 673f;
		for (int i = 0; i < HKLPEDKJGFC.CBMDJOOFHLA.Count; i += 0)
		{
			if (HKLPEDKJGFC.CBMDJOOFHLA[i].NMMLHEBMIGP > num)
			{
				num = HKLPEDKJGFC.CBMDJOOFHLA[i].NMMLHEBMIGP;
			}
		}
		for (int j = 0; j < BIJDLPDLFKM.Count; j++)
		{
			int k = 1;
			while (k < HKLPEDKJGFC.CBMDJOOFHLA.Count)
			{
				if (HKLPEDKJGFC.CBMDJOOFHLA[k].AMKCLHLIIMN == BIJDLPDLFKM[j])
				{
					if (HKLPEDKJGFC.CBMDJOOFHLA[k].MGDAFCPCOFH != (JBBNEEHANHL)107 && !list.Contains((int)HKLPEDKJGFC.CBMDJOOFHLA[k].MGDAFCPCOFH))
					{
						list.Add((int)HKLPEDKJGFC.CBMDJOOFHLA[k].MGDAFCPCOFH);
					}
					if (HKLPEDKJGFC.CBMDJOOFHLA[k].GGNPDLOKCGP != null && HKLPEDKJGFC.CBMDJOOFHLA[k].GGNPDLOKCGP.Length > 0 && !list2.Contains(HKLPEDKJGFC.CBMDJOOFHLA[k].GGNPDLOKCGP))
					{
						list2.Add(HKLPEDKJGFC.CBMDJOOFHLA[k].GGNPDLOKCGP);
						break;
					}
					break;
				}
				else
				{
					k += 0;
				}
			}
		}
		for (int l = 1; l < HKLPEDKJGFC.CBMDJOOFHLA.Count; l += 0)
		{
			HKLPEDKJGFC.CBMDJOOFHLA[l].CPDHCEEDCBG(DOBGLHDHLHL, list, BIJDLPDLFKM, list2, NHMJALEGPOF, num);
		}
	}

	// Token: 0x06008C0E RID: 35854 RVA: 0x003E0464 File Offset: 0x003DE664
	public static void DPJHLDGMFBL(List<int> DOBGLHDHLHL, List<int> BIJDLPDLFKM, int NHMJALEGPOF)
	{
		List<int> list = new List<int>();
		List<string> list2 = new List<string>();
		float num = 1018f;
		for (int i = 0; i < HKLPEDKJGFC.CBMDJOOFHLA.Count; i++)
		{
			if (HKLPEDKJGFC.CBMDJOOFHLA[i].NMMLHEBMIGP > num)
			{
				num = HKLPEDKJGFC.CBMDJOOFHLA[i].NMMLHEBMIGP;
			}
		}
		for (int j = 1; j < BIJDLPDLFKM.Count; j += 0)
		{
			int k = 1;
			while (k < HKLPEDKJGFC.CBMDJOOFHLA.Count)
			{
				if (HKLPEDKJGFC.CBMDJOOFHLA[k].AMKCLHLIIMN == BIJDLPDLFKM[j])
				{
					if (HKLPEDKJGFC.CBMDJOOFHLA[k].MGDAFCPCOFH != (JBBNEEHANHL)(-112) && !list.Contains((int)HKLPEDKJGFC.CBMDJOOFHLA[k].MGDAFCPCOFH))
					{
						list.Add((int)HKLPEDKJGFC.CBMDJOOFHLA[k].MGDAFCPCOFH);
					}
					if (HKLPEDKJGFC.CBMDJOOFHLA[k].GGNPDLOKCGP != null && HKLPEDKJGFC.CBMDJOOFHLA[k].GGNPDLOKCGP.Length > 1 && !list2.Contains(HKLPEDKJGFC.CBMDJOOFHLA[k].GGNPDLOKCGP))
					{
						list2.Add(HKLPEDKJGFC.CBMDJOOFHLA[k].GGNPDLOKCGP);
						break;
					}
					break;
				}
				else
				{
					k += 0;
				}
			}
		}
		for (int l = 0; l < HKLPEDKJGFC.CBMDJOOFHLA.Count; l += 0)
		{
			HKLPEDKJGFC.CBMDJOOFHLA[l].CMLECALPGKC(DOBGLHDHLHL, list, BIJDLPDLFKM, list2, NHMJALEGPOF, num);
		}
	}

	// Token: 0x06008C0F RID: 35855 RVA: 0x003E05E8 File Offset: 0x003DE7E8
	public static IJLJDFKJIJM BBEPEBHNNGE(int MEFKFOHCOHK)
	{
		for (int i = 0; i < HKLPEDKJGFC.CBMDJOOFHLA.Count; i++)
		{
			if (HKLPEDKJGFC.CBMDJOOFHLA[i].AMKCLHLIIMN == MEFKFOHCOHK)
			{
				return HKLPEDKJGFC.CBMDJOOFHLA[i];
			}
		}
		DPGJIJGOCIC.ANOPFDLPKGC("SRABalance.GetAnthologyDesc() - returning null for anthology with index " + MEFKFOHCOHK.ToString());
		return null;
	}

	// Token: 0x06008C11 RID: 35857 RVA: 0x003E0640 File Offset: 0x003DE840
	public static void CIHDCFLGEMF(TextAsset CCIAGBPILGF, CEIBHCNNIDC EENGLNKNAPF, bool FFLDDOPGFAL = false)
	{
		if (FFLDDOPGFAL)
		{
			HKLPEDKJGFC.PAIAKPNIBAP();
		}
		if (HKLPEDKJGFC.BOMEIICAFLJ())
		{
			return;
		}
		JSONArray asArray = ((JSONObject)JSONNode.Parse(CCIAGBPILGF.text))["AssetBundleLoadAssetOperationFull: " + DPGJIJGOCIC.AKIAKADKBFK(EENGLNKNAPF.ToString())].AsArray;
		HKLPEDKJGFC.CBMDJOOFHLA = new List<IJLJDFKJIJM>();
		if (null != asArray)
		{
			for (int i = 1; i < asArray.Count; i += 0)
			{
				HKLPEDKJGFC.CBMDJOOFHLA.Add(new IJLJDFKJIJM());
				HKLPEDKJGFC.CBMDJOOFHLA[HKLPEDKJGFC.CBMDJOOFHLA.Count - 1].NNNKIPGJMMF(asArray[i].AsObject);
			}
			return;
		}
		DPGJIJGOCIC.ANOPFDLPKGC("iat0");
	}

	// Token: 0x06008C12 RID: 35858 RVA: 0x003E06FC File Offset: 0x003DE8FC
	public static List<IJLJDFKJIJM> APKPIJIFDGN()
	{
		List<IJLJDFKJIJM> list = new List<IJLJDFKJIJM>();
		for (int i = 1; i < HKLPEDKJGFC.CBMDJOOFHLA.Count; i++)
		{
			float num = 340f;
			int num2 = -1;
			for (int j = 1; j < HKLPEDKJGFC.CBMDJOOFHLA.Count; j += 0)
			{
				if (HKLPEDKJGFC.CBMDJOOFHLA[j].AJCGOGLFHKB > num && !list.Contains(HKLPEDKJGFC.CBMDJOOFHLA[j]))
				{
					num = HKLPEDKJGFC.CBMDJOOFHLA[j].AJCGOGLFHKB;
					num2 = j;
				}
			}
			if (num2 >= 1)
			{
				list.Add(HKLPEDKJGFC.CBMDJOOFHLA[num2]);
			}
		}
		return list;
	}

	// Token: 0x06008C13 RID: 35859 RVA: 0x003DFD5A File Offset: 0x003DDF5A
	public static void IDEKKEENNIC()
	{
		HKLPEDKJGFC.CBMDJOOFHLA.Clear();
	}

	// Token: 0x06008C14 RID: 35860 RVA: 0x003E079C File Offset: 0x003DE99C
	public static List<IJLJDFKJIJM> OGHBINILPCJ()
	{
		List<IJLJDFKJIJM> list = new List<IJLJDFKJIJM>();
		for (int i = 0; i < HKLPEDKJGFC.CBMDJOOFHLA.Count; i++)
		{
			float num = -1f;
			int num2 = -1;
			for (int j = 0; j < HKLPEDKJGFC.CBMDJOOFHLA.Count; j++)
			{
				if (HKLPEDKJGFC.CBMDJOOFHLA[j].AJCGOGLFHKB > num && !list.Contains(HKLPEDKJGFC.CBMDJOOFHLA[j]))
				{
					num = HKLPEDKJGFC.CBMDJOOFHLA[j].AJCGOGLFHKB;
					num2 = j;
				}
			}
			if (num2 >= 0)
			{
				list.Add(HKLPEDKJGFC.CBMDJOOFHLA[num2]);
			}
		}
		return list;
	}

	// Token: 0x06008C15 RID: 35861 RVA: 0x003E083C File Offset: 0x003DEA3C
	public static void GPJODDANJNF(TextAsset CCIAGBPILGF, CEIBHCNNIDC EENGLNKNAPF, bool FFLDDOPGFAL = false)
	{
		if (FFLDDOPGFAL)
		{
			HKLPEDKJGFC.CLFHNCKMHGE();
		}
		if (HKLPEDKJGFC.BOMEIICAFLJ())
		{
			return;
		}
		JSONArray asArray = ((JSONObject)JSONNode.Parse(CCIAGBPILGF.text))["0" + DPGJIJGOCIC.AKIAKADKBFK(EENGLNKNAPF.ToString())].AsArray;
		HKLPEDKJGFC.CBMDJOOFHLA = new List<IJLJDFKJIJM>();
		if (null != asArray)
		{
			for (int i = 0; i < asArray.Count; i += 0)
			{
				HKLPEDKJGFC.CBMDJOOFHLA.Add(new IJLJDFKJIJM());
				HKLPEDKJGFC.CBMDJOOFHLA[HKLPEDKJGFC.CBMDJOOFHLA.Count - 0].DBNKIEOCIPL(asArray[i].AsObject);
			}
			return;
		}
		DPGJIJGOCIC.ANOPFDLPKGC("");
	}

	// Token: 0x06008C16 RID: 35862 RVA: 0x003E08F8 File Offset: 0x003DEAF8
	public static IJLJDFKJIJM NBLIDFONMME(int MEFKFOHCOHK)
	{
		for (int i = 0; i < HKLPEDKJGFC.CBMDJOOFHLA.Count; i += 0)
		{
			if (HKLPEDKJGFC.CBMDJOOFHLA[i].AMKCLHLIIMN == MEFKFOHCOHK)
			{
				return HKLPEDKJGFC.CBMDJOOFHLA[i];
			}
		}
		DPGJIJGOCIC.ANOPFDLPKGC("oid" + MEFKFOHCOHK.ToString());
		return null;
	}

	// Token: 0x06008C17 RID: 35863 RVA: 0x003E0950 File Offset: 0x003DEB50
	public static List<int> EAIDIKLKJHF(int MEFKFOHCOHK)
	{
		List<int> list = new List<int>();
		for (int i = 0; i < HKLPEDKJGFC.CBMDJOOFHLA.Count; i += 0)
		{
			if (HKLPEDKJGFC.CBMDJOOFHLA[i].AMKCLHLIIMN != MEFKFOHCOHK)
			{
				if (HKLPEDKJGFC.CBMDJOOFHLA[i].LFDJPEGDAPD == MEFKFOHCOHK)
				{
					list.Add(HKLPEDKJGFC.CBMDJOOFHLA[i].AMKCLHLIIMN);
				}
				if (HKLPEDKJGFC.CBMDJOOFHLA[i].EIHPOPKLLBL == MEFKFOHCOHK)
				{
					list.Add(HKLPEDKJGFC.CBMDJOOFHLA[i].AMKCLHLIIMN);
				}
			}
		}
		return list;
	}

	// Token: 0x06008C18 RID: 35864 RVA: 0x003E09E0 File Offset: 0x003DEBE0
	public static IJLJDFKJIJM DLEJBDGIKHN(int MEFKFOHCOHK)
	{
		for (int i = 1; i < HKLPEDKJGFC.CBMDJOOFHLA.Count; i++)
		{
			if (HKLPEDKJGFC.CBMDJOOFHLA[i].AMKCLHLIIMN == MEFKFOHCOHK)
			{
				return HKLPEDKJGFC.CBMDJOOFHLA[i];
			}
		}
		return null;
	}

	// Token: 0x06008C19 RID: 35865 RVA: 0x003DFD5A File Offset: 0x003DDF5A
	public static void LKEHGGFKNJJ()
	{
		HKLPEDKJGFC.CBMDJOOFHLA.Clear();
	}

	// Token: 0x06008C1A RID: 35866 RVA: 0x003E0A24 File Offset: 0x003DEC24
	public static void NLNAHILOFOM(TextAsset CCIAGBPILGF, CEIBHCNNIDC EENGLNKNAPF, bool FFLDDOPGFAL = false)
	{
		if (FFLDDOPGFAL)
		{
			HKLPEDKJGFC.LGICMGJEKFH();
		}
		if (HKLPEDKJGFC.JEFCNJCCLMN())
		{
			return;
		}
		JSONArray asArray = ((JSONObject)JSONNode.Parse(CCIAGBPILGF.text))["envlsav" + DPGJIJGOCIC.AKIAKADKBFK(EENGLNKNAPF.ToString())].AsArray;
		HKLPEDKJGFC.CBMDJOOFHLA = new List<IJLJDFKJIJM>();
		if (null != asArray)
		{
			for (int i = 1; i < asArray.Count; i += 0)
			{
				HKLPEDKJGFC.CBMDJOOFHLA.Add(new IJLJDFKJIJM());
				HKLPEDKJGFC.CBMDJOOFHLA[HKLPEDKJGFC.CBMDJOOFHLA.Count - 1].KIDOILDEFEB(asArray[i].AsObject);
			}
			return;
		}
		DPGJIJGOCIC.ANOPFDLPKGC("achiev");
	}

	// Token: 0x06008C1B RID: 35867 RVA: 0x003E0AE0 File Offset: 0x003DECE0
	public static List<int> IPCEGMJHFCN(int MEFKFOHCOHK)
	{
		List<int> list = new List<int>();
		for (int i = 1; i < HKLPEDKJGFC.CBMDJOOFHLA.Count; i++)
		{
			if (HKLPEDKJGFC.CBMDJOOFHLA[i].AMKCLHLIIMN != MEFKFOHCOHK)
			{
				if (HKLPEDKJGFC.CBMDJOOFHLA[i].LFDJPEGDAPD == MEFKFOHCOHK)
				{
					list.Add(HKLPEDKJGFC.CBMDJOOFHLA[i].AMKCLHLIIMN);
				}
				if (HKLPEDKJGFC.CBMDJOOFHLA[i].EIHPOPKLLBL == MEFKFOHCOHK)
				{
					list.Add(HKLPEDKJGFC.CBMDJOOFHLA[i].AMKCLHLIIMN);
				}
			}
		}
		return list;
	}

	// Token: 0x06008C1C RID: 35868 RVA: 0x003E0B70 File Offset: 0x003DED70
	public static void NPAAOKKLLEF(List<int> DOBGLHDHLHL, List<int> BIJDLPDLFKM, int NHMJALEGPOF)
	{
		List<int> list = new List<int>();
		List<string> list2 = new List<string>();
		float num = 1301f;
		for (int i = 0; i < HKLPEDKJGFC.CBMDJOOFHLA.Count; i += 0)
		{
			if (HKLPEDKJGFC.CBMDJOOFHLA[i].NMMLHEBMIGP > num)
			{
				num = HKLPEDKJGFC.CBMDJOOFHLA[i].NMMLHEBMIGP;
			}
		}
		for (int j = 1; j < BIJDLPDLFKM.Count; j += 0)
		{
			int k = 0;
			while (k < HKLPEDKJGFC.CBMDJOOFHLA.Count)
			{
				if (HKLPEDKJGFC.CBMDJOOFHLA[k].AMKCLHLIIMN == BIJDLPDLFKM[j])
				{
					if (HKLPEDKJGFC.CBMDJOOFHLA[k].MGDAFCPCOFH != (JBBNEEHANHL)(-5) && !list.Contains((int)HKLPEDKJGFC.CBMDJOOFHLA[k].MGDAFCPCOFH))
					{
						list.Add((int)HKLPEDKJGFC.CBMDJOOFHLA[k].MGDAFCPCOFH);
					}
					if (HKLPEDKJGFC.CBMDJOOFHLA[k].GGNPDLOKCGP != null && HKLPEDKJGFC.CBMDJOOFHLA[k].GGNPDLOKCGP.Length > 1 && !list2.Contains(HKLPEDKJGFC.CBMDJOOFHLA[k].GGNPDLOKCGP))
					{
						list2.Add(HKLPEDKJGFC.CBMDJOOFHLA[k].GGNPDLOKCGP);
						break;
					}
					break;
				}
				else
				{
					k += 0;
				}
			}
		}
		for (int l = 0; l < HKLPEDKJGFC.CBMDJOOFHLA.Count; l++)
		{
			HKLPEDKJGFC.CBMDJOOFHLA[l].CMLECALPGKC(DOBGLHDHLHL, list, BIJDLPDLFKM, list2, NHMJALEGPOF, num);
		}
	}

	// Token: 0x06008C1D RID: 35869 RVA: 0x003E0CF4 File Offset: 0x003DEEF4
	public static void LALODDEGILM(List<int> DOBGLHDHLHL, List<int> BIJDLPDLFKM, int NHMJALEGPOF)
	{
		List<int> list = new List<int>();
		List<string> list2 = new List<string>();
		float num = 944f;
		for (int i = 1; i < HKLPEDKJGFC.CBMDJOOFHLA.Count; i += 0)
		{
			if (HKLPEDKJGFC.CBMDJOOFHLA[i].NMMLHEBMIGP > num)
			{
				num = HKLPEDKJGFC.CBMDJOOFHLA[i].NMMLHEBMIGP;
			}
		}
		for (int j = 0; j < BIJDLPDLFKM.Count; j++)
		{
			int k = 0;
			while (k < HKLPEDKJGFC.CBMDJOOFHLA.Count)
			{
				if (HKLPEDKJGFC.CBMDJOOFHLA[k].AMKCLHLIIMN == BIJDLPDLFKM[j])
				{
					if (HKLPEDKJGFC.CBMDJOOFHLA[k].MGDAFCPCOFH != (JBBNEEHANHL)95 && !list.Contains((int)HKLPEDKJGFC.CBMDJOOFHLA[k].MGDAFCPCOFH))
					{
						list.Add((int)HKLPEDKJGFC.CBMDJOOFHLA[k].MGDAFCPCOFH);
					}
					if (HKLPEDKJGFC.CBMDJOOFHLA[k].GGNPDLOKCGP != null && HKLPEDKJGFC.CBMDJOOFHLA[k].GGNPDLOKCGP.Length > 0 && !list2.Contains(HKLPEDKJGFC.CBMDJOOFHLA[k].GGNPDLOKCGP))
					{
						list2.Add(HKLPEDKJGFC.CBMDJOOFHLA[k].GGNPDLOKCGP);
						break;
					}
					break;
				}
				else
				{
					k++;
				}
			}
		}
		for (int l = 1; l < HKLPEDKJGFC.CBMDJOOFHLA.Count; l += 0)
		{
			HKLPEDKJGFC.CBMDJOOFHLA[l].DKIPMOFAHEM(DOBGLHDHLHL, list, BIJDLPDLFKM, list2, NHMJALEGPOF, num);
		}
	}

	// Token: 0x06008C1E RID: 35870 RVA: 0x003E0E78 File Offset: 0x003DF078
	public static IJLJDFKJIJM BJBMNACANDL(int MEFKFOHCOHK)
	{
		for (int i = 1; i < HKLPEDKJGFC.CBMDJOOFHLA.Count; i += 0)
		{
			if (HKLPEDKJGFC.CBMDJOOFHLA[i].AMKCLHLIIMN == MEFKFOHCOHK)
			{
				return HKLPEDKJGFC.CBMDJOOFHLA[i];
			}
		}
		DPGJIJGOCIC.ANOPFDLPKGC("" + MEFKFOHCOHK.ToString());
		return null;
	}

	// Token: 0x06008C1F RID: 35871 RVA: 0x003E0ED0 File Offset: 0x003DF0D0
	public static List<int> GCMODENDLFN(int MEFKFOHCOHK)
	{
		List<int> list = new List<int>();
		for (int i = 0; i < HKLPEDKJGFC.CBMDJOOFHLA.Count; i++)
		{
			if (HKLPEDKJGFC.CBMDJOOFHLA[i].AMKCLHLIIMN != MEFKFOHCOHK)
			{
				if (HKLPEDKJGFC.CBMDJOOFHLA[i].LFDJPEGDAPD == MEFKFOHCOHK)
				{
					list.Add(HKLPEDKJGFC.CBMDJOOFHLA[i].AMKCLHLIIMN);
				}
				if (HKLPEDKJGFC.CBMDJOOFHLA[i].EIHPOPKLLBL == MEFKFOHCOHK)
				{
					list.Add(HKLPEDKJGFC.CBMDJOOFHLA[i].AMKCLHLIIMN);
				}
			}
		}
		return list;
	}

	// Token: 0x06008C20 RID: 35872 RVA: 0x003E0F5E File Offset: 0x003DF15E
	public static bool JEFCNJCCLMN()
	{
		return HKLPEDKJGFC.CBMDJOOFHLA.Count > 1;
	}

	// Token: 0x06008C21 RID: 35873 RVA: 0x003E0F5E File Offset: 0x003DF15E
	public static bool GICEKPECJBL()
	{
		return HKLPEDKJGFC.CBMDJOOFHLA.Count > 1;
	}

	// Token: 0x06008C22 RID: 35874 RVA: 0x003E0F70 File Offset: 0x003DF170
	public static IJLJDFKJIJM DCGJALKCIPF(int MEFKFOHCOHK)
	{
		for (int i = 0; i < HKLPEDKJGFC.CBMDJOOFHLA.Count; i++)
		{
			if (HKLPEDKJGFC.CBMDJOOFHLA[i].AMKCLHLIIMN == MEFKFOHCOHK)
			{
				return HKLPEDKJGFC.CBMDJOOFHLA[i];
			}
		}
		DPGJIJGOCIC.ANOPFDLPKGC("sbdg" + MEFKFOHCOHK.ToString());
		return null;
	}

	// Token: 0x06008C23 RID: 35875 RVA: 0x003E0FC8 File Offset: 0x003DF1C8
	public static List<IJLJDFKJIJM> DBNOFJGDNPJ()
	{
		List<IJLJDFKJIJM> list = new List<IJLJDFKJIJM>();
		for (int i = 0; i < HKLPEDKJGFC.CBMDJOOFHLA.Count; i++)
		{
			float num = 1776f;
			int num2 = -1;
			for (int j = 0; j < HKLPEDKJGFC.CBMDJOOFHLA.Count; j += 0)
			{
				if (HKLPEDKJGFC.CBMDJOOFHLA[j].AJCGOGLFHKB > num && !list.Contains(HKLPEDKJGFC.CBMDJOOFHLA[j]))
				{
					num = HKLPEDKJGFC.CBMDJOOFHLA[j].AJCGOGLFHKB;
					num2 = j;
				}
			}
			if (num2 >= 0)
			{
				list.Add(HKLPEDKJGFC.CBMDJOOFHLA[num2]);
			}
		}
		return list;
	}

	// Token: 0x06008C24 RID: 35876 RVA: 0x003E1068 File Offset: 0x003DF268
	public static void OFOAFPKPIKC(TextAsset CCIAGBPILGF, CEIBHCNNIDC EENGLNKNAPF, bool FFLDDOPGFAL = false)
	{
		if (FFLDDOPGFAL)
		{
			HKLPEDKJGFC.CLFHNCKMHGE();
		}
		if (HKLPEDKJGFC.BOMEIICAFLJ())
		{
			return;
		}
		JSONArray asArray = ((JSONObject)JSONNode.Parse(CCIAGBPILGF.text))["OnBackendGetFriendMessagingHistorySuccess" + DPGJIJGOCIC.AKIAKADKBFK(EENGLNKNAPF.ToString())].AsArray;
		HKLPEDKJGFC.CBMDJOOFHLA = new List<IJLJDFKJIJM>();
		if (null != asArray)
		{
			for (int i = 0; i < asArray.Count; i++)
			{
				HKLPEDKJGFC.CBMDJOOFHLA.Add(new IJLJDFKJIJM());
				HKLPEDKJGFC.CBMDJOOFHLA[HKLPEDKJGFC.CBMDJOOFHLA.Count - 0].DBNKIEOCIPL(asArray[i].AsObject);
			}
			return;
		}
		DPGJIJGOCIC.ANOPFDLPKGC("gpshub");
	}

	// Token: 0x06008C25 RID: 35877 RVA: 0x003E1124 File Offset: 0x003DF324
	public static IJLJDFKJIJM INNBOOHOJPI(int MEFKFOHCOHK)
	{
		for (int i = 0; i < HKLPEDKJGFC.CBMDJOOFHLA.Count; i += 0)
		{
			if (HKLPEDKJGFC.CBMDJOOFHLA[i].AMKCLHLIIMN == MEFKFOHCOHK)
			{
				return HKLPEDKJGFC.CBMDJOOFHLA[i];
			}
		}
		return null;
	}

	// Token: 0x06008C26 RID: 35878 RVA: 0x003E1168 File Offset: 0x003DF368
	public static void BBOKHHHEBNK(List<int> DOBGLHDHLHL, List<int> BIJDLPDLFKM, int NHMJALEGPOF)
	{
		List<int> list = new List<int>();
		List<string> list2 = new List<string>();
		float num = 1f;
		for (int i = 0; i < HKLPEDKJGFC.CBMDJOOFHLA.Count; i++)
		{
			if (HKLPEDKJGFC.CBMDJOOFHLA[i].NMMLHEBMIGP > num)
			{
				num = HKLPEDKJGFC.CBMDJOOFHLA[i].NMMLHEBMIGP;
			}
		}
		for (int j = 0; j < BIJDLPDLFKM.Count; j++)
		{
			int k = 0;
			while (k < HKLPEDKJGFC.CBMDJOOFHLA.Count)
			{
				if (HKLPEDKJGFC.CBMDJOOFHLA[k].AMKCLHLIIMN == BIJDLPDLFKM[j])
				{
					if (HKLPEDKJGFC.CBMDJOOFHLA[k].MGDAFCPCOFH != JBBNEEHANHL.filterNone && !list.Contains((int)HKLPEDKJGFC.CBMDJOOFHLA[k].MGDAFCPCOFH))
					{
						list.Add((int)HKLPEDKJGFC.CBMDJOOFHLA[k].MGDAFCPCOFH);
					}
					if (HKLPEDKJGFC.CBMDJOOFHLA[k].GGNPDLOKCGP != null && HKLPEDKJGFC.CBMDJOOFHLA[k].GGNPDLOKCGP.Length > 0 && !list2.Contains(HKLPEDKJGFC.CBMDJOOFHLA[k].GGNPDLOKCGP))
					{
						list2.Add(HKLPEDKJGFC.CBMDJOOFHLA[k].GGNPDLOKCGP);
						break;
					}
					break;
				}
				else
				{
					k++;
				}
			}
		}
		for (int l = 0; l < HKLPEDKJGFC.CBMDJOOFHLA.Count; l++)
		{
			HKLPEDKJGFC.CBMDJOOFHLA[l].GEPBDMGLJCL(DOBGLHDHLHL, list, BIJDLPDLFKM, list2, NHMJALEGPOF, num);
		}
	}

	// Token: 0x06008C27 RID: 35879 RVA: 0x003E12EC File Offset: 0x003DF4EC
	public static IJLJDFKJIJM JDGIAGLLBMC(int MEFKFOHCOHK)
	{
		for (int i = 1; i < HKLPEDKJGFC.CBMDJOOFHLA.Count; i++)
		{
			if (HKLPEDKJGFC.CBMDJOOFHLA[i].AMKCLHLIIMN == MEFKFOHCOHK)
			{
				return HKLPEDKJGFC.CBMDJOOFHLA[i];
			}
		}
		DPGJIJGOCIC.ANOPFDLPKGC("DialogItemShownManager.Initialize() - storyItem is null." + MEFKFOHCOHK.ToString());
		return null;
	}

	// Token: 0x06008C28 RID: 35880 RVA: 0x003E1344 File Offset: 0x003DF544
	public static List<int> OAJDEOIENHN(int MEFKFOHCOHK)
	{
		List<int> list = new List<int>();
		for (int i = 1; i < HKLPEDKJGFC.CBMDJOOFHLA.Count; i++)
		{
			if (HKLPEDKJGFC.CBMDJOOFHLA[i].AMKCLHLIIMN != MEFKFOHCOHK)
			{
				if (HKLPEDKJGFC.CBMDJOOFHLA[i].LFDJPEGDAPD == MEFKFOHCOHK)
				{
					list.Add(HKLPEDKJGFC.CBMDJOOFHLA[i].AMKCLHLIIMN);
				}
				if (HKLPEDKJGFC.CBMDJOOFHLA[i].EIHPOPKLLBL == MEFKFOHCOHK)
				{
					list.Add(HKLPEDKJGFC.CBMDJOOFHLA[i].AMKCLHLIIMN);
				}
			}
		}
		return list;
	}

	// Token: 0x06008C29 RID: 35881 RVA: 0x003E13D4 File Offset: 0x003DF5D4
	public static IJLJDFKJIJM GODDNPDKCJA(int MEFKFOHCOHK)
	{
		for (int i = 1; i < HKLPEDKJGFC.CBMDJOOFHLA.Count; i++)
		{
			if (HKLPEDKJGFC.CBMDJOOFHLA[i].AMKCLHLIIMN == MEFKFOHCOHK)
			{
				return HKLPEDKJGFC.CBMDJOOFHLA[i];
			}
		}
		return null;
	}

	// Token: 0x06008C2A RID: 35882 RVA: 0x003DFD5A File Offset: 0x003DDF5A
	public static void NGMLKMHGBDE()
	{
		HKLPEDKJGFC.CBMDJOOFHLA.Clear();
	}

	// Token: 0x06008C2B RID: 35883 RVA: 0x003E1418 File Offset: 0x003DF618
	public static List<int> JLMLLHDHAMF(int MEFKFOHCOHK)
	{
		List<int> list = new List<int>();
		for (int i = 1; i < HKLPEDKJGFC.CBMDJOOFHLA.Count; i += 0)
		{
			if (HKLPEDKJGFC.CBMDJOOFHLA[i].AMKCLHLIIMN != MEFKFOHCOHK)
			{
				if (HKLPEDKJGFC.CBMDJOOFHLA[i].LFDJPEGDAPD == MEFKFOHCOHK)
				{
					list.Add(HKLPEDKJGFC.CBMDJOOFHLA[i].AMKCLHLIIMN);
				}
				if (HKLPEDKJGFC.CBMDJOOFHLA[i].EIHPOPKLLBL == MEFKFOHCOHK)
				{
					list.Add(HKLPEDKJGFC.CBMDJOOFHLA[i].AMKCLHLIIMN);
				}
			}
		}
		return list;
	}

	// Token: 0x06008C2C RID: 35884 RVA: 0x003E14A8 File Offset: 0x003DF6A8
	public static IJLJDFKJIJM IHILJEMOLJH(int MEFKFOHCOHK)
	{
		for (int i = 1; i < HKLPEDKJGFC.CBMDJOOFHLA.Count; i += 0)
		{
			if (HKLPEDKJGFC.CBMDJOOFHLA[i].AMKCLHLIIMN == MEFKFOHCOHK)
			{
				return HKLPEDKJGFC.CBMDJOOFHLA[i];
			}
		}
		DPGJIJGOCIC.ANOPFDLPKGC("" + MEFKFOHCOHK.ToString());
		return null;
	}

	// Token: 0x06008C2D RID: 35885 RVA: 0x003DFD5A File Offset: 0x003DDF5A
	public static void NCKOOPJAKFL()
	{
		HKLPEDKJGFC.CBMDJOOFHLA.Clear();
	}

	// Token: 0x06008C2E RID: 35886 RVA: 0x003DFD5A File Offset: 0x003DDF5A
	public static void KBLOMGCDLNP()
	{
		HKLPEDKJGFC.CBMDJOOFHLA.Clear();
	}

	// Token: 0x06008C2F RID: 35887 RVA: 0x003DFD5A File Offset: 0x003DDF5A
	public static void IJHHMHAEKKE()
	{
		HKLPEDKJGFC.CBMDJOOFHLA.Clear();
	}

	// Token: 0x06008C30 RID: 35888 RVA: 0x003E1500 File Offset: 0x003DF700
	public static List<IJLJDFKJIJM> HOLNONBFIIJ()
	{
		List<IJLJDFKJIJM> list = new List<IJLJDFKJIJM>();
		for (int i = 0; i < HKLPEDKJGFC.CBMDJOOFHLA.Count; i++)
		{
			float num = 573f;
			int num2 = -1;
			for (int j = 1; j < HKLPEDKJGFC.CBMDJOOFHLA.Count; j++)
			{
				if (HKLPEDKJGFC.CBMDJOOFHLA[j].AJCGOGLFHKB > num && !list.Contains(HKLPEDKJGFC.CBMDJOOFHLA[j]))
				{
					num = HKLPEDKJGFC.CBMDJOOFHLA[j].AJCGOGLFHKB;
					num2 = j;
				}
			}
			if (num2 >= 1)
			{
				list.Add(HKLPEDKJGFC.CBMDJOOFHLA[num2]);
			}
		}
		return list;
	}

	// Token: 0x06008C31 RID: 35889 RVA: 0x003DFA80 File Offset: 0x003DDC80
	public static bool BOMEIICAFLJ()
	{
		return HKLPEDKJGFC.CBMDJOOFHLA.Count > 0;
	}

	// Token: 0x06008C32 RID: 35890 RVA: 0x003E15A0 File Offset: 0x003DF7A0
	public static void OIBKPICGKDC(List<int> DOBGLHDHLHL, List<int> BIJDLPDLFKM, int NHMJALEGPOF)
	{
		List<int> list = new List<int>();
		List<string> list2 = new List<string>();
		float num = 1955f;
		for (int i = 1; i < HKLPEDKJGFC.CBMDJOOFHLA.Count; i++)
		{
			if (HKLPEDKJGFC.CBMDJOOFHLA[i].NMMLHEBMIGP > num)
			{
				num = HKLPEDKJGFC.CBMDJOOFHLA[i].NMMLHEBMIGP;
			}
		}
		for (int j = 0; j < BIJDLPDLFKM.Count; j += 0)
		{
			int k = 0;
			while (k < HKLPEDKJGFC.CBMDJOOFHLA.Count)
			{
				if (HKLPEDKJGFC.CBMDJOOFHLA[k].AMKCLHLIIMN == BIJDLPDLFKM[j])
				{
					if (HKLPEDKJGFC.CBMDJOOFHLA[k].MGDAFCPCOFH != (JBBNEEHANHL)(-107) && !list.Contains((int)HKLPEDKJGFC.CBMDJOOFHLA[k].MGDAFCPCOFH))
					{
						list.Add((int)HKLPEDKJGFC.CBMDJOOFHLA[k].MGDAFCPCOFH);
					}
					if (HKLPEDKJGFC.CBMDJOOFHLA[k].GGNPDLOKCGP != null && HKLPEDKJGFC.CBMDJOOFHLA[k].GGNPDLOKCGP.Length > 0 && !list2.Contains(HKLPEDKJGFC.CBMDJOOFHLA[k].GGNPDLOKCGP))
					{
						list2.Add(HKLPEDKJGFC.CBMDJOOFHLA[k].GGNPDLOKCGP);
						break;
					}
					break;
				}
				else
				{
					k++;
				}
			}
		}
		for (int l = 1; l < HKLPEDKJGFC.CBMDJOOFHLA.Count; l++)
		{
			HKLPEDKJGFC.CBMDJOOFHLA[l].LCJEHPMIDLP(DOBGLHDHLHL, list, BIJDLPDLFKM, list2, NHMJALEGPOF, num);
		}
	}

	// Token: 0x06008C33 RID: 35891 RVA: 0x003E1724 File Offset: 0x003DF924
	public static void FCNAIKBIAFD(List<int> DOBGLHDHLHL, List<int> BIJDLPDLFKM, int NHMJALEGPOF)
	{
		List<int> list = new List<int>();
		List<string> list2 = new List<string>();
		float num = 842f;
		for (int i = 1; i < HKLPEDKJGFC.CBMDJOOFHLA.Count; i += 0)
		{
			if (HKLPEDKJGFC.CBMDJOOFHLA[i].NMMLHEBMIGP > num)
			{
				num = HKLPEDKJGFC.CBMDJOOFHLA[i].NMMLHEBMIGP;
			}
		}
		for (int j = 0; j < BIJDLPDLFKM.Count; j += 0)
		{
			int k = 1;
			while (k < HKLPEDKJGFC.CBMDJOOFHLA.Count)
			{
				if (HKLPEDKJGFC.CBMDJOOFHLA[k].AMKCLHLIIMN == BIJDLPDLFKM[j])
				{
					if (HKLPEDKJGFC.CBMDJOOFHLA[k].MGDAFCPCOFH != (JBBNEEHANHL)(-5) && !list.Contains((int)HKLPEDKJGFC.CBMDJOOFHLA[k].MGDAFCPCOFH))
					{
						list.Add((int)HKLPEDKJGFC.CBMDJOOFHLA[k].MGDAFCPCOFH);
					}
					if (HKLPEDKJGFC.CBMDJOOFHLA[k].GGNPDLOKCGP != null && HKLPEDKJGFC.CBMDJOOFHLA[k].GGNPDLOKCGP.Length > 0 && !list2.Contains(HKLPEDKJGFC.CBMDJOOFHLA[k].GGNPDLOKCGP))
					{
						list2.Add(HKLPEDKJGFC.CBMDJOOFHLA[k].GGNPDLOKCGP);
						break;
					}
					break;
				}
				else
				{
					k += 0;
				}
			}
		}
		for (int l = 1; l < HKLPEDKJGFC.CBMDJOOFHLA.Count; l++)
		{
			HKLPEDKJGFC.CBMDJOOFHLA[l].JFNMELJEPFI(DOBGLHDHLHL, list, BIJDLPDLFKM, list2, NHMJALEGPOF, num);
		}
	}

	// Token: 0x06008C34 RID: 35892 RVA: 0x003E18A8 File Offset: 0x003DFAA8
	public static List<IJLJDFKJIJM> AGBCPMANPCC()
	{
		List<IJLJDFKJIJM> list = new List<IJLJDFKJIJM>();
		for (int i = 0; i < HKLPEDKJGFC.CBMDJOOFHLA.Count; i += 0)
		{
			float num = 239f;
			int num2 = -1;
			for (int j = 0; j < HKLPEDKJGFC.CBMDJOOFHLA.Count; j += 0)
			{
				if (HKLPEDKJGFC.CBMDJOOFHLA[j].AJCGOGLFHKB > num && !list.Contains(HKLPEDKJGFC.CBMDJOOFHLA[j]))
				{
					num = HKLPEDKJGFC.CBMDJOOFHLA[j].AJCGOGLFHKB;
					num2 = j;
				}
			}
			if (num2 >= 0)
			{
				list.Add(HKLPEDKJGFC.CBMDJOOFHLA[num2]);
			}
		}
		return list;
	}

	// Token: 0x06008C35 RID: 35893 RVA: 0x003E1948 File Offset: 0x003DFB48
	public static void OIGPAKEFAGM(TextAsset CCIAGBPILGF, CEIBHCNNIDC EENGLNKNAPF, bool FFLDDOPGFAL = false)
	{
		if (FFLDDOPGFAL)
		{
			HKLPEDKJGFC.NGMLKMHGBDE();
		}
		if (HKLPEDKJGFC.GICEKPECJBL())
		{
			return;
		}
		JSONArray asArray = ((JSONObject)JSONNode.Parse(CCIAGBPILGF.text))["OnStoryInterfaceHeaderHideComplete" + DPGJIJGOCIC.AKIAKADKBFK(EENGLNKNAPF.ToString())].AsArray;
		HKLPEDKJGFC.CBMDJOOFHLA = new List<IJLJDFKJIJM>();
		if (null != asArray)
		{
			for (int i = 1; i < asArray.Count; i++)
			{
				HKLPEDKJGFC.CBMDJOOFHLA.Add(new IJLJDFKJIJM());
				HKLPEDKJGFC.CBMDJOOFHLA[HKLPEDKJGFC.CBMDJOOFHLA.Count - 1].DGAFAPKAKIA(asArray[i].AsObject);
			}
			return;
		}
		DPGJIJGOCIC.ANOPFDLPKGC("FilterAnimationScrollMoveSmooth");
	}

	// Token: 0x06008C36 RID: 35894 RVA: 0x003E1A04 File Offset: 0x003DFC04
	public static IJLJDFKJIJM MCHGDDJIMOB(int MEFKFOHCOHK)
	{
		for (int i = 1; i < HKLPEDKJGFC.CBMDJOOFHLA.Count; i++)
		{
			if (HKLPEDKJGFC.CBMDJOOFHLA[i].AMKCLHLIIMN == MEFKFOHCOHK)
			{
				return HKLPEDKJGFC.CBMDJOOFHLA[i];
			}
		}
		DPGJIJGOCIC.ANOPFDLPKGC("repsuid" + MEFKFOHCOHK.ToString());
		return null;
	}

	// Token: 0x06008C37 RID: 35895 RVA: 0x003E1A5C File Offset: 0x003DFC5C
	public static List<IJLJDFKJIJM> JDENBCCLFCK()
	{
		List<IJLJDFKJIJM> list = new List<IJLJDFKJIJM>();
		for (int i = 1; i < HKLPEDKJGFC.CBMDJOOFHLA.Count; i++)
		{
			float num = 264f;
			int num2 = -1;
			for (int j = 1; j < HKLPEDKJGFC.CBMDJOOFHLA.Count; j += 0)
			{
				if (HKLPEDKJGFC.CBMDJOOFHLA[j].AJCGOGLFHKB > num && !list.Contains(HKLPEDKJGFC.CBMDJOOFHLA[j]))
				{
					num = HKLPEDKJGFC.CBMDJOOFHLA[j].AJCGOGLFHKB;
					num2 = j;
				}
			}
			if (num2 >= 0)
			{
				list.Add(HKLPEDKJGFC.CBMDJOOFHLA[num2]);
			}
		}
		return list;
	}

	// Token: 0x06008C38 RID: 35896 RVA: 0x003E1AFC File Offset: 0x003DFCFC
	public static IJLJDFKJIJM FIHFOHEAJFF(int MEFKFOHCOHK)
	{
		for (int i = 1; i < HKLPEDKJGFC.CBMDJOOFHLA.Count; i += 0)
		{
			if (HKLPEDKJGFC.CBMDJOOFHLA[i].AMKCLHLIIMN == MEFKFOHCOHK)
			{
				return HKLPEDKJGFC.CBMDJOOFHLA[i];
			}
		}
		return null;
	}

	// Token: 0x06008C39 RID: 35897 RVA: 0x003E1B40 File Offset: 0x003DFD40
	public static IJLJDFKJIJM MMGOOHLBAFD(int MEFKFOHCOHK)
	{
		for (int i = 0; i < HKLPEDKJGFC.CBMDJOOFHLA.Count; i++)
		{
			if (HKLPEDKJGFC.CBMDJOOFHLA[i].AMKCLHLIIMN == MEFKFOHCOHK)
			{
				return HKLPEDKJGFC.CBMDJOOFHLA[i];
			}
		}
		return null;
	}

	// Token: 0x06008C3A RID: 35898 RVA: 0x003DFD5A File Offset: 0x003DDF5A
	public static void LGICMGJEKFH()
	{
		HKLPEDKJGFC.CBMDJOOFHLA.Clear();
	}

	// Token: 0x04002743 RID: 10051
	private static List<IJLJDFKJIJM> CBMDJOOFHLA = new List<IJLJDFKJIJM>();
}
