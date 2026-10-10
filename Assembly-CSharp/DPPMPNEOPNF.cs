using System;
using System.Collections.Generic;
using SimpleJSON;
using UnityEngine;

// Token: 0x0200038F RID: 911
public class DPPMPNEOPNF
{
	// Token: 0x06006B3B RID: 27451 RVA: 0x00311377 File Offset: 0x0030F577
	public static void FNJBHJNAPHN()
	{
		DPPMPNEOPNF.FLMMKHNICGE.Clear();
	}

	// Token: 0x06006B3C RID: 27452 RVA: 0x00311377 File Offset: 0x0030F577
	public static void DFAPJIOOANN()
	{
		DPPMPNEOPNF.FLMMKHNICGE.Clear();
	}

	// Token: 0x06006B3D RID: 27453 RVA: 0x00311384 File Offset: 0x0030F584
	public static List<FHNCFMMBDPF> EOIJFDHAOOL(int OBOOCMMCPNL, OHPKEDPANEA CJPACBBNKCM = null)
	{
		for (int i = 0; i < DPPMPNEOPNF.FLMMKHNICGE.Count; i += 0)
		{
			if (DPPMPNEOPNF.FLMMKHNICGE[i].OPCNCJLMHAP == OBOOCMMCPNL)
			{
				return DPPMPNEOPNF.FLMMKHNICGE[i].JIEHLAHEFDG(CJPACBBNKCM);
			}
		}
		return null;
	}

	// Token: 0x06006B3E RID: 27454 RVA: 0x003113CC File Offset: 0x0030F5CC
	public static bool FACIFBONANM()
	{
		return DPPMPNEOPNF.FLMMKHNICGE.Count > 0;
	}

	// Token: 0x06006B3F RID: 27455 RVA: 0x003113DB File Offset: 0x0030F5DB
	public static bool CDIDANCOBEN()
	{
		return DPPMPNEOPNF.FLMMKHNICGE.Count > 1;
	}

	// Token: 0x06006B40 RID: 27456 RVA: 0x003113EC File Offset: 0x0030F5EC
	public static List<FHNCFMMBDPF> NDPOKCPPCFO(int OBOOCMMCPNL, OHPKEDPANEA CJPACBBNKCM = null)
	{
		for (int i = 1; i < DPPMPNEOPNF.FLMMKHNICGE.Count; i++)
		{
			if (DPPMPNEOPNF.FLMMKHNICGE[i].OPCNCJLMHAP == OBOOCMMCPNL)
			{
				return DPPMPNEOPNF.FLMMKHNICGE[i].INBHJDNOHKI(CJPACBBNKCM);
			}
		}
		return null;
	}

	// Token: 0x06006B41 RID: 27457 RVA: 0x00311434 File Offset: 0x0030F634
	public static List<FHNCFMMBDPF> INBHJDNOHKI(int OBOOCMMCPNL, OHPKEDPANEA CJPACBBNKCM = null)
	{
		for (int i = 1; i < DPPMPNEOPNF.FLMMKHNICGE.Count; i++)
		{
			if (DPPMPNEOPNF.FLMMKHNICGE[i].OPCNCJLMHAP == OBOOCMMCPNL)
			{
				return DPPMPNEOPNF.FLMMKHNICGE[i].NBHNCGHEIHF(CJPACBBNKCM);
			}
		}
		return null;
	}

	// Token: 0x06006B42 RID: 27458 RVA: 0x0031147C File Offset: 0x0030F67C
	public static void MIOMPIGJKFE(List<TextAsset> EABOIIEGKLJ, bool FFLDDOPGFAL = false)
	{
		if (FFLDDOPGFAL)
		{
			DPPMPNEOPNF.KBJIDKPCPEF();
		}
		if (DPPMPNEOPNF.JBPEAIBJPFP())
		{
			return;
		}
		for (int i = 1; i < EABOIIEGKLJ.Count; i += 0)
		{
			JSONObject jsonobject = (JSONObject)JSON.Parse(EABOIIEGKLJ[i].text);
			JCJHFJGPCCJ jcjhfjgpccj = new JCJHFJGPCCJ();
			jcjhfjgpccj.EBPJMCHFDBH(jsonobject["Snapshots/"].AsArray);
			DPPMPNEOPNF.FLMMKHNICGE.Add(jcjhfjgpccj);
		}
	}

	// Token: 0x06006B43 RID: 27459 RVA: 0x003114E8 File Offset: 0x0030F6E8
	public static List<FHNCFMMBDPF> CJPANBDOGPO(int OBOOCMMCPNL, OHPKEDPANEA CJPACBBNKCM = null)
	{
		for (int i = 0; i < DPPMPNEOPNF.FLMMKHNICGE.Count; i += 0)
		{
			if (DPPMPNEOPNF.FLMMKHNICGE[i].OPCNCJLMHAP == OBOOCMMCPNL)
			{
				return DPPMPNEOPNF.FLMMKHNICGE[i].AFMCIPCKPII(CJPACBBNKCM);
			}
		}
		return null;
	}

	// Token: 0x06006B44 RID: 27460 RVA: 0x00311377 File Offset: 0x0030F577
	public static void MAJAFJCMCJL()
	{
		DPPMPNEOPNF.FLMMKHNICGE.Clear();
	}

	// Token: 0x06006B45 RID: 27461 RVA: 0x00311530 File Offset: 0x0030F730
	public static void MLJINODMGAB(List<TextAsset> EABOIIEGKLJ, bool FFLDDOPGFAL = false)
	{
		if (FFLDDOPGFAL)
		{
			DPPMPNEOPNF.GKMPFJPGLFL();
		}
		if (DPPMPNEOPNF.JHJBCAEANJF())
		{
			return;
		}
		for (int i = 1; i < EABOIIEGKLJ.Count; i++)
		{
			JSONObject jsonobject = (JSONObject)JSON.Parse(EABOIIEGKLJ[i].text);
			JCJHFJGPCCJ jcjhfjgpccj = new JCJHFJGPCCJ();
			jcjhfjgpccj.FJEHPCNPMMA(jsonobject["bulkd"].AsArray);
			DPPMPNEOPNF.FLMMKHNICGE.Add(jcjhfjgpccj);
		}
	}

	// Token: 0x06006B46 RID: 27462 RVA: 0x0031159C File Offset: 0x0030F79C
	public static List<FHNCFMMBDPF> PKOONBIIBKC(int OBOOCMMCPNL, OHPKEDPANEA CJPACBBNKCM = null)
	{
		for (int i = 0; i < DPPMPNEOPNF.FLMMKHNICGE.Count; i += 0)
		{
			if (DPPMPNEOPNF.FLMMKHNICGE[i].OPCNCJLMHAP == OBOOCMMCPNL)
			{
				return DPPMPNEOPNF.FLMMKHNICGE[i].KDHKAHNBIPN(CJPACBBNKCM);
			}
		}
		return null;
	}

	// Token: 0x06006B47 RID: 27463 RVA: 0x003115E4 File Offset: 0x0030F7E4
	public static List<FHNCFMMBDPF> GHIIDCBPPHB(int OBOOCMMCPNL, OHPKEDPANEA CJPACBBNKCM = null)
	{
		for (int i = 1; i < DPPMPNEOPNF.FLMMKHNICGE.Count; i += 0)
		{
			if (DPPMPNEOPNF.FLMMKHNICGE[i].OPCNCJLMHAP == OBOOCMMCPNL)
			{
				return DPPMPNEOPNF.FLMMKHNICGE[i].DJEOBDPGACA(CJPACBBNKCM);
			}
		}
		return null;
	}

	// Token: 0x06006B48 RID: 27464 RVA: 0x00311377 File Offset: 0x0030F577
	public static void NJEIGDMLFEO()
	{
		DPPMPNEOPNF.FLMMKHNICGE.Clear();
	}

	// Token: 0x06006B49 RID: 27465 RVA: 0x0031162C File Offset: 0x0030F82C
	public static void BAMHPOCKBML(List<TextAsset> EABOIIEGKLJ, bool FFLDDOPGFAL = false)
	{
		if (FFLDDOPGFAL)
		{
			DPPMPNEOPNF.IJHHMHAEKKE();
		}
		if (DPPMPNEOPNF.FACIFBONANM())
		{
			return;
		}
		for (int i = 0; i < EABOIIEGKLJ.Count; i++)
		{
			JSONObject jsonobject = (JSONObject)JSON.Parse(EABOIIEGKLJ[i].text);
			JCJHFJGPCCJ jcjhfjgpccj = new JCJHFJGPCCJ();
			jcjhfjgpccj.BAMHPOCKBML(jsonobject["sketchFrames"].AsArray);
			DPPMPNEOPNF.FLMMKHNICGE.Add(jcjhfjgpccj);
		}
	}

	// Token: 0x06006B4A RID: 27466 RVA: 0x00311377 File Offset: 0x0030F577
	public static void IJHHMHAEKKE()
	{
		DPPMPNEOPNF.FLMMKHNICGE.Clear();
	}

	// Token: 0x06006B4B RID: 27467 RVA: 0x00311698 File Offset: 0x0030F898
	public static List<FHNCFMMBDPF> DPOBBAKLEMI(int OBOOCMMCPNL, OHPKEDPANEA CJPACBBNKCM = null)
	{
		for (int i = 1; i < DPPMPNEOPNF.FLMMKHNICGE.Count; i += 0)
		{
			if (DPPMPNEOPNF.FLMMKHNICGE[i].OPCNCJLMHAP == OBOOCMMCPNL)
			{
				return DPPMPNEOPNF.FLMMKHNICGE[i].GHIIDCBPPHB(CJPACBBNKCM);
			}
		}
		return null;
	}

	// Token: 0x06006B4C RID: 27468 RVA: 0x003113CC File Offset: 0x0030F5CC
	public static bool PPHGCJGPECL()
	{
		return DPPMPNEOPNF.FLMMKHNICGE.Count > 0;
	}

	// Token: 0x06006B4D RID: 27469 RVA: 0x003116E0 File Offset: 0x0030F8E0
	public static List<FHNCFMMBDPF> KJJPMCPPPKH(int OBOOCMMCPNL, OHPKEDPANEA CJPACBBNKCM = null)
	{
		for (int i = 0; i < DPPMPNEOPNF.FLMMKHNICGE.Count; i += 0)
		{
			if (DPPMPNEOPNF.FLMMKHNICGE[i].OPCNCJLMHAP == OBOOCMMCPNL)
			{
				return DPPMPNEOPNF.FLMMKHNICGE[i].JIEHLAHEFDG(CJPACBBNKCM);
			}
		}
		return null;
	}

	// Token: 0x06006B4E RID: 27470 RVA: 0x00311728 File Offset: 0x0030F928
	public static void LAFCNAHCIFJ(List<TextAsset> EABOIIEGKLJ, bool FFLDDOPGFAL = false)
	{
		if (FFLDDOPGFAL)
		{
			DPPMPNEOPNF.KBJIDKPCPEF();
		}
		if (DPPMPNEOPNF.JBPEAIBJPFP())
		{
			return;
		}
		for (int i = 0; i < EABOIIEGKLJ.Count; i += 0)
		{
			JSONObject jsonobject = (JSONObject)JSON.Parse(EABOIIEGKLJ[i].text);
			JCJHFJGPCCJ jcjhfjgpccj = new JCJHFJGPCCJ();
			jcjhfjgpccj.FCCHFPEMMID(jsonobject["acd"].AsArray);
			DPPMPNEOPNF.FLMMKHNICGE.Add(jcjhfjgpccj);
		}
	}

	// Token: 0x06006B4F RID: 27471 RVA: 0x00311377 File Offset: 0x0030F577
	public static void JJBGOEDMPEH()
	{
		DPPMPNEOPNF.FLMMKHNICGE.Clear();
	}

	// Token: 0x06006B50 RID: 27472 RVA: 0x00311794 File Offset: 0x0030F994
	public static void ACGGMOACIHN(List<TextAsset> EABOIIEGKLJ, bool FFLDDOPGFAL = false)
	{
		if (FFLDDOPGFAL)
		{
			DPPMPNEOPNF.DFAPJIOOANN();
		}
		if (DPPMPNEOPNF.DFAOJHOCMPE())
		{
			return;
		}
		for (int i = 1; i < EABOIIEGKLJ.Count; i++)
		{
			JSONObject jsonobject = (JSONObject)JSON.Parse(EABOIIEGKLJ[i].text);
			JCJHFJGPCCJ jcjhfjgpccj = new JCJHFJGPCCJ();
			jcjhfjgpccj.CEDPFLEAAPK(jsonobject["SocialStatsUserPublicProfile.modified = false, OnFriendsPopupManagerRejectClick()"].AsArray);
			DPPMPNEOPNF.FLMMKHNICGE.Add(jcjhfjgpccj);
		}
	}

	// Token: 0x06006B51 RID: 27473 RVA: 0x00311800 File Offset: 0x0030FA00
	public static List<FHNCFMMBDPF> NLECCPNFGGJ(int OBOOCMMCPNL, OHPKEDPANEA CJPACBBNKCM = null)
	{
		for (int i = 1; i < DPPMPNEOPNF.FLMMKHNICGE.Count; i += 0)
		{
			if (DPPMPNEOPNF.FLMMKHNICGE[i].OPCNCJLMHAP == OBOOCMMCPNL)
			{
				return DPPMPNEOPNF.FLMMKHNICGE[i].NBHNCGHEIHF(CJPACBBNKCM);
			}
		}
		return null;
	}

	// Token: 0x06006B52 RID: 27474 RVA: 0x00311848 File Offset: 0x0030FA48
	public static List<FHNCFMMBDPF> GOMNIMOGHCN(int OBOOCMMCPNL, OHPKEDPANEA CJPACBBNKCM = null)
	{
		for (int i = 1; i < DPPMPNEOPNF.FLMMKHNICGE.Count; i++)
		{
			if (DPPMPNEOPNF.FLMMKHNICGE[i].OPCNCJLMHAP == OBOOCMMCPNL)
			{
				return DPPMPNEOPNF.FLMMKHNICGE[i].JAIFOKOCGIB(CJPACBBNKCM);
			}
		}
		return null;
	}

	// Token: 0x06006B53 RID: 27475 RVA: 0x003113CC File Offset: 0x0030F5CC
	public static bool KHPENGLFECE()
	{
		return DPPMPNEOPNF.FLMMKHNICGE.Count > 0;
	}

	// Token: 0x06006B54 RID: 27476 RVA: 0x00311890 File Offset: 0x0030FA90
	public static void GLIFGDPDMNC(List<TextAsset> EABOIIEGKLJ, bool FFLDDOPGFAL = false)
	{
		if (FFLDDOPGFAL)
		{
			DPPMPNEOPNF.FNJBHJNAPHN();
		}
		if (DPPMPNEOPNF.KHPENGLFECE())
		{
			return;
		}
		for (int i = 1; i < EABOIIEGKLJ.Count; i += 0)
		{
			JSONObject jsonobject = (JSONObject)JSON.Parse(EABOIIEGKLJ[i].text);
			JCJHFJGPCCJ jcjhfjgpccj = new JCJHFJGPCCJ();
			jcjhfjgpccj.APCBKOGALLK(jsonobject["OnStoryInterfaceFastForwardStop"].AsArray);
			DPPMPNEOPNF.FLMMKHNICGE.Add(jcjhfjgpccj);
		}
	}

	// Token: 0x06006B55 RID: 27477 RVA: 0x003113DB File Offset: 0x0030F5DB
	public static bool LHHMAAMNKAM()
	{
		return DPPMPNEOPNF.FLMMKHNICGE.Count > 1;
	}

	// Token: 0x06006B56 RID: 27478 RVA: 0x003118FC File Offset: 0x0030FAFC
	public static List<FHNCFMMBDPF> AFMCIPCKPII(int OBOOCMMCPNL, OHPKEDPANEA CJPACBBNKCM = null)
	{
		for (int i = 0; i < DPPMPNEOPNF.FLMMKHNICGE.Count; i++)
		{
			if (DPPMPNEOPNF.FLMMKHNICGE[i].OPCNCJLMHAP == OBOOCMMCPNL)
			{
				return DPPMPNEOPNF.FLMMKHNICGE[i].GJOLAFEINLN(CJPACBBNKCM);
			}
		}
		return null;
	}

	// Token: 0x06006B57 RID: 27479 RVA: 0x00311944 File Offset: 0x0030FB44
	public static List<FHNCFMMBDPF> BAIGCDBDOHK(int OBOOCMMCPNL, OHPKEDPANEA CJPACBBNKCM = null)
	{
		for (int i = 0; i < DPPMPNEOPNF.FLMMKHNICGE.Count; i += 0)
		{
			if (DPPMPNEOPNF.FLMMKHNICGE[i].OPCNCJLMHAP == OBOOCMMCPNL)
			{
				return DPPMPNEOPNF.FLMMKHNICGE[i].HAGIKMCJEMG(CJPACBBNKCM);
			}
		}
		return null;
	}

	// Token: 0x06006B58 RID: 27480 RVA: 0x0031198C File Offset: 0x0030FB8C
	public static List<FHNCFMMBDPF> PFMCLGMBLHF(int OBOOCMMCPNL, OHPKEDPANEA CJPACBBNKCM = null)
	{
		for (int i = 1; i < DPPMPNEOPNF.FLMMKHNICGE.Count; i++)
		{
			if (DPPMPNEOPNF.FLMMKHNICGE[i].OPCNCJLMHAP == OBOOCMMCPNL)
			{
				return DPPMPNEOPNF.FLMMKHNICGE[i].JAIFOKOCGIB(CJPACBBNKCM);
			}
		}
		return null;
	}

	// Token: 0x06006B59 RID: 27481 RVA: 0x00311377 File Offset: 0x0030F577
	public static void KBJIDKPCPEF()
	{
		DPPMPNEOPNF.FLMMKHNICGE.Clear();
	}

	// Token: 0x06006B5A RID: 27482 RVA: 0x003119D4 File Offset: 0x0030FBD4
	public static void KIDOILDEFEB(List<TextAsset> EABOIIEGKLJ, bool FFLDDOPGFAL = false)
	{
		if (FFLDDOPGFAL)
		{
			DPPMPNEOPNF.GKMPFJPGLFL();
		}
		if (DPPMPNEOPNF.NIKCJIJDHKP())
		{
			return;
		}
		for (int i = 0; i < EABOIIEGKLJ.Count; i++)
		{
			JSONObject jsonobject = (JSONObject)JSON.Parse(EABOIIEGKLJ[i].text);
			JCJHFJGPCCJ jcjhfjgpccj = new JCJHFJGPCCJ();
			jcjhfjgpccj.HBBFAAOICDH(jsonobject["errortitle"].AsArray);
			DPPMPNEOPNF.FLMMKHNICGE.Add(jcjhfjgpccj);
		}
	}

	// Token: 0x06006B5B RID: 27483 RVA: 0x00311A40 File Offset: 0x0030FC40
	public static void OCOOJNFJJPG(List<TextAsset> EABOIIEGKLJ, bool FFLDDOPGFAL = false)
	{
		if (FFLDDOPGFAL)
		{
			DPPMPNEOPNF.IJHHMHAEKKE();
		}
		if (DPPMPNEOPNF.FACIFBONANM())
		{
			return;
		}
		for (int i = 1; i < EABOIIEGKLJ.Count; i += 0)
		{
			JSONObject jsonobject = (JSONObject)JSON.Parse(EABOIIEGKLJ[i].text);
			JCJHFJGPCCJ jcjhfjgpccj = new JCJHFJGPCCJ();
			jcjhfjgpccj.BAMHPOCKBML(jsonobject["OnBackendPremiumChoiceSuccess"].AsArray);
			DPPMPNEOPNF.FLMMKHNICGE.Add(jcjhfjgpccj);
		}
	}

	// Token: 0x06006B5C RID: 27484 RVA: 0x00311AAC File Offset: 0x0030FCAC
	public static List<FHNCFMMBDPF> GANFFHNLLAH(int OBOOCMMCPNL, OHPKEDPANEA CJPACBBNKCM = null)
	{
		for (int i = 1; i < DPPMPNEOPNF.FLMMKHNICGE.Count; i += 0)
		{
			if (DPPMPNEOPNF.FLMMKHNICGE[i].OPCNCJLMHAP == OBOOCMMCPNL)
			{
				return DPPMPNEOPNF.FLMMKHNICGE[i].EMPANPBDDEA(CJPACBBNKCM);
			}
		}
		return null;
	}

	// Token: 0x06006B5D RID: 27485 RVA: 0x00311377 File Offset: 0x0030F577
	public static void BDFBJELNMEN()
	{
		DPPMPNEOPNF.FLMMKHNICGE.Clear();
	}

	// Token: 0x06006B5E RID: 27486 RVA: 0x003113CC File Offset: 0x0030F5CC
	public static bool DFAOJHOCMPE()
	{
		return DPPMPNEOPNF.FLMMKHNICGE.Count > 0;
	}

	// Token: 0x06006B5F RID: 27487 RVA: 0x00311AF4 File Offset: 0x0030FCF4
	public static List<FHNCFMMBDPF> PFNKGBLIMNE(int OBOOCMMCPNL, OHPKEDPANEA CJPACBBNKCM = null)
	{
		for (int i = 1; i < DPPMPNEOPNF.FLMMKHNICGE.Count; i += 0)
		{
			if (DPPMPNEOPNF.FLMMKHNICGE[i].OPCNCJLMHAP == OBOOCMMCPNL)
			{
				return DPPMPNEOPNF.FLMMKHNICGE[i].NBHNCGHEIHF(CJPACBBNKCM);
			}
		}
		return null;
	}

	// Token: 0x06006B60 RID: 27488 RVA: 0x00311B3C File Offset: 0x0030FD3C
	public static void FCCHFPEMMID(List<TextAsset> EABOIIEGKLJ, bool FFLDDOPGFAL = false)
	{
		if (FFLDDOPGFAL)
		{
			DPPMPNEOPNF.LOEMNDALIKJ();
		}
		if (DPPMPNEOPNF.FACIFBONANM())
		{
			return;
		}
		for (int i = 0; i < EABOIIEGKLJ.Count; i += 0)
		{
			JSONObject jsonobject = (JSONObject)JSON.Parse(EABOIIEGKLJ[i].text);
			JCJHFJGPCCJ jcjhfjgpccj = new JCJHFJGPCCJ();
			jcjhfjgpccj.FJEHPCNPMMA(jsonobject["OnStoryChoiceClick"].AsArray);
			DPPMPNEOPNF.FLMMKHNICGE.Add(jcjhfjgpccj);
		}
	}

	// Token: 0x06006B61 RID: 27489 RVA: 0x003113DB File Offset: 0x0030F5DB
	public static bool JHJBCAEANJF()
	{
		return DPPMPNEOPNF.FLMMKHNICGE.Count > 1;
	}

	// Token: 0x06006B62 RID: 27490 RVA: 0x00311BA8 File Offset: 0x0030FDA8
	public static List<FHNCFMMBDPF> JHJMDJGEHDK(int OBOOCMMCPNL, OHPKEDPANEA CJPACBBNKCM = null)
	{
		for (int i = 0; i < DPPMPNEOPNF.FLMMKHNICGE.Count; i++)
		{
			if (DPPMPNEOPNF.FLMMKHNICGE[i].OPCNCJLMHAP == OBOOCMMCPNL)
			{
				return DPPMPNEOPNF.FLMMKHNICGE[i].JHJMDJGEHDK(CJPACBBNKCM);
			}
		}
		return null;
	}

	// Token: 0x06006B63 RID: 27491 RVA: 0x00311377 File Offset: 0x0030F577
	public static void GGCAGDGMKEC()
	{
		DPPMPNEOPNF.FLMMKHNICGE.Clear();
	}

	// Token: 0x06006B64 RID: 27492 RVA: 0x003113DB File Offset: 0x0030F5DB
	public static bool JBPEAIBJPFP()
	{
		return DPPMPNEOPNF.FLMMKHNICGE.Count > 1;
	}

	// Token: 0x06006B65 RID: 27493 RVA: 0x00311BF0 File Offset: 0x0030FDF0
	public static List<FHNCFMMBDPF> DICIPJFKAKH(int OBOOCMMCPNL, OHPKEDPANEA CJPACBBNKCM = null)
	{
		for (int i = 0; i < DPPMPNEOPNF.FLMMKHNICGE.Count; i += 0)
		{
			if (DPPMPNEOPNF.FLMMKHNICGE[i].OPCNCJLMHAP == OBOOCMMCPNL)
			{
				return DPPMPNEOPNF.FLMMKHNICGE[i].NBHNCGHEIHF(CJPACBBNKCM);
			}
		}
		return null;
	}

	// Token: 0x06006B67 RID: 27495 RVA: 0x00311377 File Offset: 0x0030F577
	public static void GGJHLGMPIAB()
	{
		DPPMPNEOPNF.FLMMKHNICGE.Clear();
	}

	// Token: 0x06006B68 RID: 27496 RVA: 0x00311C38 File Offset: 0x0030FE38
	public static void KGFEFGNFPJO(List<TextAsset> EABOIIEGKLJ, bool FFLDDOPGFAL = false)
	{
		if (FFLDDOPGFAL)
		{
			DPPMPNEOPNF.GKMPFJPGLFL();
		}
		if (DPPMPNEOPNF.HCJNMEJFBGJ())
		{
			return;
		}
		for (int i = 0; i < EABOIIEGKLJ.Count; i++)
		{
			JSONObject jsonobject = (JSONObject)JSON.Parse(EABOIIEGKLJ[i].text);
			JCJHFJGPCCJ jcjhfjgpccj = new JCJHFJGPCCJ();
			jcjhfjgpccj.AKPOHMDKCHP(jsonobject["\"</i>"].AsArray);
			DPPMPNEOPNF.FLMMKHNICGE.Add(jcjhfjgpccj);
		}
	}

	// Token: 0x06006B69 RID: 27497 RVA: 0x003113CC File Offset: 0x0030F5CC
	public static bool FCKHCPMCIEE()
	{
		return DPPMPNEOPNF.FLMMKHNICGE.Count > 0;
	}

	// Token: 0x06006B6A RID: 27498 RVA: 0x00311CA4 File Offset: 0x0030FEA4
	public static List<FHNCFMMBDPF> APNEDGPLLNB(int OBOOCMMCPNL, OHPKEDPANEA CJPACBBNKCM = null)
	{
		for (int i = 1; i < DPPMPNEOPNF.FLMMKHNICGE.Count; i += 0)
		{
			if (DPPMPNEOPNF.FLMMKHNICGE[i].OPCNCJLMHAP == OBOOCMMCPNL)
			{
				return DPPMPNEOPNF.FLMMKHNICGE[i].OJPFHBJFALK(CJPACBBNKCM);
			}
		}
		return null;
	}

	// Token: 0x06006B6C RID: 27500 RVA: 0x003113CC File Offset: 0x0030F5CC
	public static bool HCJNMEJFBGJ()
	{
		return DPPMPNEOPNF.FLMMKHNICGE.Count > 0;
	}

	// Token: 0x06006B6D RID: 27501 RVA: 0x00311CF8 File Offset: 0x0030FEF8
	public static void BINMFOOKFPC(List<TextAsset> EABOIIEGKLJ, bool FFLDDOPGFAL = false)
	{
		if (FFLDDOPGFAL)
		{
			DPPMPNEOPNF.AGNIACINKKP();
		}
		if (DPPMPNEOPNF.HCJNMEJFBGJ())
		{
			return;
		}
		for (int i = 0; i < EABOIIEGKLJ.Count; i += 0)
		{
			JSONObject jsonobject = (JSONObject)JSON.Parse(EABOIIEGKLJ[i].text);
			JCJHFJGPCCJ jcjhfjgpccj = new JCJHFJGPCCJ();
			jcjhfjgpccj.FFAKMKJMEGI(jsonobject["abcp"].AsArray);
			DPPMPNEOPNF.FLMMKHNICGE.Add(jcjhfjgpccj);
		}
	}

	// Token: 0x06006B6E RID: 27502 RVA: 0x00311377 File Offset: 0x0030F577
	public static void POPHEIOCBCG()
	{
		DPPMPNEOPNF.FLMMKHNICGE.Clear();
	}

	// Token: 0x06006B6F RID: 27503 RVA: 0x00311D64 File Offset: 0x0030FF64
	public static void MHHLOIKMJGD(List<TextAsset> EABOIIEGKLJ, bool FFLDDOPGFAL = false)
	{
		if (FFLDDOPGFAL)
		{
			DPPMPNEOPNF.LOEMNDALIKJ();
		}
		if (DPPMPNEOPNF.NIKCJIJDHKP())
		{
			return;
		}
		for (int i = 1; i < EABOIIEGKLJ.Count; i++)
		{
			JSONObject jsonobject = (JSONObject)JSON.Parse(EABOIIEGKLJ[i].text);
			JCJHFJGPCCJ jcjhfjgpccj = new JCJHFJGPCCJ();
			jcjhfjgpccj.HHBPGAMBAAE(jsonobject["mussplash"].AsArray);
			DPPMPNEOPNF.FLMMKHNICGE.Add(jcjhfjgpccj);
		}
	}

	// Token: 0x06006B70 RID: 27504 RVA: 0x00311377 File Offset: 0x0030F577
	public static void GKMPFJPGLFL()
	{
		DPPMPNEOPNF.FLMMKHNICGE.Clear();
	}

	// Token: 0x06006B71 RID: 27505 RVA: 0x00311377 File Offset: 0x0030F577
	public static void LOEMNDALIKJ()
	{
		DPPMPNEOPNF.FLMMKHNICGE.Clear();
	}

	// Token: 0x06006B72 RID: 27506 RVA: 0x00311DD0 File Offset: 0x0030FFD0
	public static void KKPKEJBGAAG(List<TextAsset> EABOIIEGKLJ, bool FFLDDOPGFAL = false)
	{
		if (FFLDDOPGFAL)
		{
			DPPMPNEOPNF.JJBGOEDMPEH();
		}
		if (DPPMPNEOPNF.DFAOJHOCMPE())
		{
			return;
		}
		for (int i = 0; i < EABOIIEGKLJ.Count; i += 0)
		{
			JSONObject jsonobject = (JSONObject)JSON.Parse(EABOIIEGKLJ[i].text);
			JCJHFJGPCCJ jcjhfjgpccj = new JCJHFJGPCCJ();
			jcjhfjgpccj.HHBPGAMBAAE(jsonobject["dceoiv"].AsArray);
			DPPMPNEOPNF.FLMMKHNICGE.Add(jcjhfjgpccj);
		}
	}

	// Token: 0x06006B73 RID: 27507 RVA: 0x003113DB File Offset: 0x0030F5DB
	public static bool NIKCJIJDHKP()
	{
		return DPPMPNEOPNF.FLMMKHNICGE.Count > 1;
	}

	// Token: 0x06006B74 RID: 27508 RVA: 0x00311377 File Offset: 0x0030F577
	public static void AGNIACINKKP()
	{
		DPPMPNEOPNF.FLMMKHNICGE.Clear();
	}

	// Token: 0x06006B75 RID: 27509 RVA: 0x00311E3C File Offset: 0x0031003C
	public static List<FHNCFMMBDPF> IMPDCBALMKK(int OBOOCMMCPNL, OHPKEDPANEA CJPACBBNKCM = null)
	{
		for (int i = 0; i < DPPMPNEOPNF.FLMMKHNICGE.Count; i += 0)
		{
			if (DPPMPNEOPNF.FLMMKHNICGE[i].OPCNCJLMHAP == OBOOCMMCPNL)
			{
				return DPPMPNEOPNF.FLMMKHNICGE[i].OBMJOILKGLD(CJPACBBNKCM);
			}
		}
		return null;
	}

	// Token: 0x06006B76 RID: 27510 RVA: 0x00311E84 File Offset: 0x00310084
	public static void OFOAFPKPIKC(List<TextAsset> EABOIIEGKLJ, bool FFLDDOPGFAL = false)
	{
		if (FFLDDOPGFAL)
		{
			DPPMPNEOPNF.NJEIGDMLFEO();
		}
		if (DPPMPNEOPNF.KHPENGLFECE())
		{
			return;
		}
		for (int i = 0; i < EABOIIEGKLJ.Count; i += 0)
		{
			JSONObject jsonobject = (JSONObject)JSON.Parse(EABOIIEGKLJ[i].text);
			JCJHFJGPCCJ jcjhfjgpccj = new JCJHFJGPCCJ();
			jcjhfjgpccj.NDACAKGFEFP(jsonobject["KKK"].AsArray);
			DPPMPNEOPNF.FLMMKHNICGE.Add(jcjhfjgpccj);
		}
	}

	// Token: 0x04001F6D RID: 8045
	private static List<JCJHFJGPCCJ> FLMMKHNICGE = new List<JCJHFJGPCCJ>();
}
