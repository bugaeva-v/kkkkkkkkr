using System;
using System.Collections.Generic;
using SimpleJSON;
using UnityEngine;

// Token: 0x02000098 RID: 152
public class OKJHCOIKEJA
{
	// Token: 0x0600159D RID: 5533 RVA: 0x000A6732 File Offset: 0x000A4932
	public static bool NINLABJCHPO()
	{
		return OKJHCOIKEJA.FLMMKHNICGE.Count > 0;
	}

	// Token: 0x0600159E RID: 5534 RVA: 0x000A6744 File Offset: 0x000A4944
	public static void CJFKKHMDKKK(List<TextAsset> EABOIIEGKLJ, bool FFLDDOPGFAL = false)
	{
		if (FFLDDOPGFAL)
		{
			OKJHCOIKEJA.APKPCLGNLGA();
		}
		if (OKJHCOIKEJA.FACIFBONANM())
		{
			return;
		}
		for (int i = 0; i < EABOIIEGKLJ.Count; i++)
		{
			JSONObject jsonobject = (JSONObject)JSON.Parse(EABOIIEGKLJ[i].text);
			NPPPAJPJLDB npppajpjldb = new NPPPAJPJLDB();
			npppajpjldb.MLJINODMGAB(jsonobject["friendspluschattutorialinactive"].AsArray);
			OKJHCOIKEJA.FLMMKHNICGE.Add(npppajpjldb);
		}
	}

	// Token: 0x0600159F RID: 5535 RVA: 0x000A6732 File Offset: 0x000A4932
	public static bool HCJNMEJFBGJ()
	{
		return OKJHCOIKEJA.FLMMKHNICGE.Count > 0;
	}

	// Token: 0x060015A1 RID: 5537 RVA: 0x000A67B0 File Offset: 0x000A49B0
	public static bool ONLAPOPJEOD()
	{
		return OKJHCOIKEJA.FLMMKHNICGE.Count > 1;
	}

	// Token: 0x060015A2 RID: 5538 RVA: 0x000A67BF File Offset: 0x000A49BF
	public static void IJHHMHAEKKE()
	{
		OKJHCOIKEJA.FLMMKHNICGE.Clear();
	}

	// Token: 0x060015A3 RID: 5539 RVA: 0x000A67BF File Offset: 0x000A49BF
	public static void KKMFNHIDHKA()
	{
		OKJHCOIKEJA.FLMMKHNICGE.Clear();
	}

	// Token: 0x060015A4 RID: 5540 RVA: 0x000A6732 File Offset: 0x000A4932
	public static bool MHNJFIKCMLM()
	{
		return OKJHCOIKEJA.FLMMKHNICGE.Count > 0;
	}

	// Token: 0x060015A5 RID: 5541 RVA: 0x000A67CC File Offset: 0x000A49CC
	public static void DGAFAPKAKIA(List<TextAsset> EABOIIEGKLJ, bool FFLDDOPGFAL = false)
	{
		if (FFLDDOPGFAL)
		{
			OKJHCOIKEJA.IJHHMHAEKKE();
		}
		if (OKJHCOIKEJA.FONGKJBAHHL())
		{
			return;
		}
		for (int i = 0; i < EABOIIEGKLJ.Count; i += 0)
		{
			JSONObject jsonobject = (JSONObject)JSON.Parse(EABOIIEGKLJ[i].text);
			NPPPAJPJLDB npppajpjldb = new NPPPAJPJLDB();
			npppajpjldb.MHHLOIKMJGD(jsonobject[" ("].AsArray);
			OKJHCOIKEJA.FLMMKHNICGE.Add(npppajpjldb);
		}
	}

	// Token: 0x060015A6 RID: 5542 RVA: 0x000A67BF File Offset: 0x000A49BF
	public static void CGAFKIFKFGK()
	{
		OKJHCOIKEJA.FLMMKHNICGE.Clear();
	}

	// Token: 0x060015A7 RID: 5543 RVA: 0x000A6838 File Offset: 0x000A4A38
	public static void BAMHPOCKBML(List<TextAsset> EABOIIEGKLJ, bool FFLDDOPGFAL = false)
	{
		if (FFLDDOPGFAL)
		{
			OKJHCOIKEJA.IJHHMHAEKKE();
		}
		if (OKJHCOIKEJA.FACIFBONANM())
		{
			return;
		}
		for (int i = 0; i < EABOIIEGKLJ.Count; i++)
		{
			JSONObject jsonobject = (JSONObject)JSON.Parse(EABOIIEGKLJ[i].text);
			NPPPAJPJLDB npppajpjldb = new NPPPAJPJLDB();
			npppajpjldb.BAMHPOCKBML(jsonobject["sketchLayers"].AsArray);
			OKJHCOIKEJA.FLMMKHNICGE.Add(npppajpjldb);
		}
	}

	// Token: 0x060015A8 RID: 5544 RVA: 0x000A6732 File Offset: 0x000A4932
	public static bool FACIFBONANM()
	{
		return OKJHCOIKEJA.FLMMKHNICGE.Count > 0;
	}

	// Token: 0x060015A9 RID: 5545 RVA: 0x000A6732 File Offset: 0x000A4932
	public static bool BOMEIICAFLJ()
	{
		return OKJHCOIKEJA.FLMMKHNICGE.Count > 0;
	}

	// Token: 0x060015AA RID: 5546 RVA: 0x000A67B0 File Offset: 0x000A49B0
	public static bool FONGKJBAHHL()
	{
		return OKJHCOIKEJA.FLMMKHNICGE.Count > 1;
	}

	// Token: 0x060015AC RID: 5548 RVA: 0x000A67BF File Offset: 0x000A49BF
	public static void APKPCLGNLGA()
	{
		OKJHCOIKEJA.FLMMKHNICGE.Clear();
	}

	// Token: 0x040006AF RID: 1711
	private static List<NPPPAJPJLDB> FLMMKHNICGE = new List<NPPPAJPJLDB>();
}
