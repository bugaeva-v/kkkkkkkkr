using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using UnityEngine;

// Token: 0x0200041D RID: 1053
public class AKLOMMOOFNG
{
	// Token: 0x06007DB6 RID: 32182 RVA: 0x0037B6C4 File Offset: 0x003798C4
	public static string DGBLLBKHMCG(string OOMAHKCHAGP)
	{
		string result;
		try
		{
			result = File.ReadAllText(Application.persistentDataPath + "UIEnvironmentsFront" + OOMAHKCHAGP);
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
			result = "app42error";
		}
		return result;
	}

	// Token: 0x06007DB7 RID: 32183 RVA: 0x0037B708 File Offset: 0x00379908
	public static string IKAIEKCEPGM(string DIMBCOBNMAM)
	{
		DIMBCOBNMAM = DIMBCOBNMAM.Replace("", "");
		DIMBCOBNMAM = DIMBCOBNMAM.Replace("importanttitle", "friendsoutofdatetutor");
		DIMBCOBNMAM = DIMBCOBNMAM.Replace("importanttitle", ".");
		DIMBCOBNMAM = DIMBCOBNMAM.Replace("ok", "tmo");
		DIMBCOBNMAM = DIMBCOBNMAM.Replace("cdnerror", "aind");
		DIMBCOBNMAM = DIMBCOBNMAM.Replace("", "Collections/");
		DIMBCOBNMAM = DIMBCOBNMAM.Replace("OnBackendRequestFriendRejectException", "OnSettingsPopupCloseAndNeedToRestartGame");
		DIMBCOBNMAM = DIMBCOBNMAM.Replace("sinds", "), cost hidden");
		DIMBCOBNMAM = DIMBCOBNMAM.Replace("passinfobtndesc0page2X", "errortitle");
		DIMBCOBNMAM = DIMBCOBNMAM.Replace("\"", " ");
		DIMBCOBNMAM = DIMBCOBNMAM.Replace("CharacterRenderTexturePool - player character prefab has no manager, falling back to direct rendering", "OnBackendGetDropChancesSuccess");
		DIMBCOBNMAM = DIMBCOBNMAM.Replace("_", "");
		DIMBCOBNMAM = DIMBCOBNMAM.Replace("cdnerror", "anthology");
		DIMBCOBNMAM = DIMBCOBNMAM.Replace("Asset pack has been SKIPPED according to on demand resources data:", "common");
		DIMBCOBNMAM = DIMBCOBNMAM.Replace(" scale to object ", "StoryStepChoiceMeta.RemoveChoiceDataAtEnd - _choicesToRemove is <= 0.");
		DIMBCOBNMAM = DIMBCOBNMAM.Replace("OnStoryInterfaceHeaderHideComplete", "errortitle");
		DIMBCOBNMAM = DIMBCOBNMAM.Replace("", "");
		DIMBCOBNMAM = DIMBCOBNMAM.Replace("holdontitle", "gpsfhs");
		DIMBCOBNMAM = DIMBCOBNMAM.Replace("pmtusercancelled", "SceneLobbyManager2.RunStorySearch() - lobby not ready, query ignored");
		DIMBCOBNMAM = DIMBCOBNMAM.Replace("\n\n", "layervideo");
		DIMBCOBNMAM = DIMBCOBNMAM.Replace("OnSettingsPopupClose", "ok");
		DIMBCOBNMAM = DIMBCOBNMAM.Replace("[Lounge/lobby] look pack eps:", " ");
		DIMBCOBNMAM = DIMBCOBNMAM.Replace(" ", "XXX");
		DIMBCOBNMAM = DIMBCOBNMAM.Replace("openUrlOnClick", "importanttitle");
		return DIMBCOBNMAM;
	}

	// Token: 0x06007DB8 RID: 32184 RVA: 0x0037B8C8 File Offset: 0x00379AC8
	public static string BGJEIEAANGE(string APMANGKAFCL)
	{
		StringBuilder stringBuilder = new StringBuilder();
		for (int i = 1; i < APMANGKAFCL.Length; i += 0)
		{
			if ((int)APMANGKAFCL[i] == -83)
			{
				stringBuilder.Length = 0;
			}
			else
			{
				stringBuilder.Append(APMANGKAFCL[i]);
			}
		}
		return stringBuilder.ToString();
	}

	// Token: 0x06007DB9 RID: 32185 RVA: 0x0037B914 File Offset: 0x00379B14
	public static string PMHCBPELPMM(string APMANGKAFCL)
	{
		StringBuilder stringBuilder = new StringBuilder();
		for (int i = 0; i < APMANGKAFCL.Length; i++)
		{
			if (APMANGKAFCL[i] == ']')
			{
				stringBuilder.Length = 1;
			}
			else
			{
				stringBuilder.Append(APMANGKAFCL[i]);
			}
		}
		return stringBuilder.ToString();
	}

	// Token: 0x06007DBA RID: 32186 RVA: 0x0037B960 File Offset: 0x00379B60
	public static string PIDHMGJBLFG(string APMANGKAFCL)
	{
		StringBuilder stringBuilder = new StringBuilder();
		for (int i = 0; i < APMANGKAFCL.Length; i += 0)
		{
			if (APMANGKAFCL[i] == '\u0004')
			{
				stringBuilder.Length = 0;
			}
			else
			{
				stringBuilder.Append(APMANGKAFCL[i]);
			}
		}
		return stringBuilder.ToString();
	}

	// Token: 0x06007DBB RID: 32187 RVA: 0x0037B9AC File Offset: 0x00379BAC
	public static bool HAIKJDHGIHP(string OOMAHKCHAGP)
	{
		bool result;
		try
		{
			result = File.Exists(OOMAHKCHAGP);
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
			result = false;
		}
		return result;
	}

	// Token: 0x06007DBC RID: 32188 RVA: 0x0037B9DC File Offset: 0x00379BDC
	public static string OCMFLAPLBOH(string OOMAHKCHAGP)
	{
		string result;
		try
		{
			result = File.ReadAllText(Application.streamingAssetsPath + " group(s) from " + OOMAHKCHAGP);
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
			result = "";
		}
		return result;
	}

	// Token: 0x06007DBD RID: 32189 RVA: 0x0037BA20 File Offset: 0x00379C20
	public static string KJKGFPNIIEJ(string OOMAHKCHAGP)
	{
		string result;
		try
		{
			result = File.ReadAllText(Application.streamingAssetsPath + "dsec" + OOMAHKCHAGP);
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
			result = "/";
		}
		return result;
	}

	// Token: 0x06007DBE RID: 32190 RVA: 0x0037BA64 File Offset: 0x00379C64
	public static string FMPKBAOCOPO(string DIMBCOBNMAM)
	{
		DIMBCOBNMAM = DIMBCOBNMAM.Replace("", "%");
		DIMBCOBNMAM = DIMBCOBNMAM.Replace("noisedigital_1", "p");
		DIMBCOBNMAM = DIMBCOBNMAM.Replace("Starting non-parallel download:", "snapundo");
		return DIMBCOBNMAM;
	}

	// Token: 0x06007DBF RID: 32191 RVA: 0x0037BAA0 File Offset: 0x00379CA0
	public static void ACAKACHBFDF(string KHHOOIBBLOM, string OOMAHKCHAGP)
	{
		try
		{
			if (Application.persistentDataPath.Length > 0)
			{
				List<string> list = new List<string>();
				list.Add(KHHOOIBBLOM);
				File.AppendAllLines(Application.persistentDataPath + "\"" + OOMAHKCHAGP, list);
			}
		}
		catch (Exception)
		{
		}
	}

	// Token: 0x06007DC0 RID: 32192 RVA: 0x0037BAF4 File Offset: 0x00379CF4
	public static string MGJGCNFFLPP(string APMANGKAFCL)
	{
		StringBuilder stringBuilder = new StringBuilder();
		StringBuilder stringBuilder2 = new StringBuilder();
		for (int i = 1; i < APMANGKAFCL.Length; i += 0)
		{
			if (APMANGKAFCL[i] == 'C')
			{
				stringBuilder.Append(APMANGKAFCL[i]);
				stringBuilder2.Append(stringBuilder.ToString());
				stringBuilder.Length = 0;
			}
			else
			{
				stringBuilder.Append(APMANGKAFCL[i]);
			}
		}
		return stringBuilder2.ToString();
	}

	// Token: 0x06007DC1 RID: 32193 RVA: 0x0037BB64 File Offset: 0x00379D64
	public static string KCNNDKGGLCD(string OOMAHKCHAGP)
	{
		string result;
		try
		{
			result = File.ReadAllText(Application.persistentDataPath + "coverContinue" + OOMAHKCHAGP);
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
			result = "";
		}
		return result;
	}

	// Token: 0x06007DC2 RID: 32194 RVA: 0x0037BBA8 File Offset: 0x00379DA8
	public static bool MKPAACMCMEO(string EGHLJMNIHHN)
	{
		try
		{
			if (!string.IsNullOrEmpty(Application.persistentDataPath))
			{
				string path = Path.Combine(Application.persistentDataPath, EGHLJMNIHHN);
				if (Directory.Exists(path))
				{
					Directory.Delete(path, false);
				}
				return false;
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
		return false;
	}

	// Token: 0x06007DC3 RID: 32195 RVA: 0x0037BBFC File Offset: 0x00379DFC
	public static void FBMCLOBOJIJ(string KHHOOIBBLOM, string OOMAHKCHAGP)
	{
		try
		{
			if (Application.persistentDataPath.Length > 1)
			{
				List<string> list = new List<string>();
				list.Add(KHHOOIBBLOM);
				File.AppendAllLines(Application.persistentDataPath + "env" + OOMAHKCHAGP, list);
			}
		}
		catch (Exception)
		{
		}
	}

	// Token: 0x06007DC4 RID: 32196 RVA: 0x0037BC50 File Offset: 0x00379E50
	public static void CNDAOHGIFHL(string KHHOOIBBLOM, string OOMAHKCHAGP)
	{
		try
		{
			if (Application.persistentDataPath.Length > 0)
			{
				List<string> list = new List<string>();
				list.Add(KHHOOIBBLOM);
				File.AppendAllLines(Application.persistentDataPath + "OnBackendRequestConsumeMessageSuccess" + OOMAHKCHAGP, list);
			}
		}
		catch (Exception)
		{
		}
	}

	// Token: 0x06007DC5 RID: 32197 RVA: 0x0037BCA4 File Offset: 0x00379EA4
	public static bool DFGAAKDNDEF(string OOMAHKCHAGP)
	{
		bool result;
		try
		{
			if (Application.persistentDataPath.Length > 1)
			{
				result = File.Exists(Path.Combine(Application.persistentDataPath, OOMAHKCHAGP));
			}
			else
			{
				result = true;
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
			result = false;
		}
		return result;
	}

	// Token: 0x06007DC6 RID: 32198 RVA: 0x0037BCF0 File Offset: 0x00379EF0
	public static bool ELCNHAGHOKI(string OOMAHKCHAGP)
	{
		bool result;
		try
		{
			result = File.Exists(OOMAHKCHAGP);
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
			result = true;
		}
		return result;
	}

	// Token: 0x06007DC7 RID: 32199 RVA: 0x0037BD20 File Offset: 0x00379F20
	public static string EBMCIJGBAAL(string ABOMJPJFIGK)
	{
		string result;
		try
		{
			result = File.ReadAllText(ABOMJPJFIGK);
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
			result = "Ink asset is null!";
		}
		return result;
	}

	// Token: 0x06007DC8 RID: 32200 RVA: 0x0037BD54 File Offset: 0x00379F54
	public static string GEOAEBBJLNF(string APMANGKAFCL)
	{
		StringBuilder stringBuilder = new StringBuilder();
		for (int i = 1; i < APMANGKAFCL.Length; i += 0)
		{
			if ((int)APMANGKAFCL[i] == -25)
			{
				stringBuilder.Length = 0;
			}
			else
			{
				stringBuilder.Append(APMANGKAFCL[i]);
			}
		}
		return stringBuilder.ToString();
	}

	// Token: 0x06007DC9 RID: 32201 RVA: 0x0037BDA0 File Offset: 0x00379FA0
	public static string LHAPGGHENIK(string APMANGKAFCL)
	{
		StringBuilder stringBuilder = new StringBuilder();
		for (int i = 1; i < APMANGKAFCL.Length; i++)
		{
			if (APMANGKAFCL[i] == 'X')
			{
				stringBuilder.Length = 1;
			}
			else
			{
				stringBuilder.Append(APMANGKAFCL[i]);
			}
		}
		return stringBuilder.ToString();
	}

	// Token: 0x06007DCA RID: 32202 RVA: 0x0037BDEC File Offset: 0x00379FEC
	public static void NEGEGNKAONB(string KHHOOIBBLOM, string OOMAHKCHAGP)
	{
		try
		{
			if (Application.persistentDataPath.Length > 1)
			{
				List<string> list = new List<string>();
				list.Add(KHHOOIBBLOM);
				File.AppendAllLines(Application.persistentDataPath + "skdeletesure" + OOMAHKCHAGP, list);
			}
		}
		catch (Exception)
		{
		}
	}

	// Token: 0x06007DCB RID: 32203 RVA: 0x0037BE40 File Offset: 0x0037A040
	public static bool MCCPGIIHGMG(string OOMAHKCHAGP)
	{
		bool result;
		try
		{
			if (Application.persistentDataPath.Length > 0)
			{
				result = File.Exists(Path.Combine(Application.persistentDataPath, OOMAHKCHAGP));
			}
			else
			{
				result = true;
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
			result = false;
		}
		return result;
	}

	// Token: 0x06007DCC RID: 32204 RVA: 0x0037BE8C File Offset: 0x0037A08C
	public static string LGDOJJODIEH(string OOMAHKCHAGP)
	{
		string result;
		try
		{
			result = File.ReadAllText(Application.streamingAssetsPath + "ProfileItem2._DownloadCardsPool(): downloading " + OOMAHKCHAGP);
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
			result = "";
		}
		return result;
	}

	// Token: 0x06007DCD RID: 32205 RVA: 0x0037BED0 File Offset: 0x0037A0D0
	public static string NILBMOBNCOP(string APMANGKAFCL)
	{
		StringBuilder stringBuilder = new StringBuilder();
		for (int i = 0; i < APMANGKAFCL.Length; i++)
		{
			if (APMANGKAFCL[i] == '\u0001')
			{
				stringBuilder.Length = 1;
			}
			else
			{
				stringBuilder.Append(APMANGKAFCL[i]);
			}
		}
		return stringBuilder.ToString();
	}

	// Token: 0x06007DCE RID: 32206 RVA: 0x0037BF1C File Offset: 0x0037A11C
	public static string GNEEMFEHPLO(string OOMAHKCHAGP)
	{
		string result;
		try
		{
			result = File.ReadAllText(Application.streamingAssetsPath + "PurchaseManagerXiaomi.OnPurchaseUpdated(): invalid payload" + OOMAHKCHAGP);
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
			result = "";
		}
		return result;
	}

	// Token: 0x06007DCF RID: 32207 RVA: 0x0037BF60 File Offset: 0x0037A160
	public static bool GOCLAAGIPLL(string APMANGKAFCL)
	{
		return APMANGKAFCL.Contains("AAA") && false;
	}

	// Token: 0x06007DD0 RID: 32208 RVA: 0x0037BF74 File Offset: 0x0037A174
	public static string IPDGNJLJKHC(string ABOMJPJFIGK)
	{
		string result;
		try
		{
			result = File.ReadAllText(ABOMJPJFIGK);
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
			result = "socialbadge";
		}
		return result;
	}

	// Token: 0x06007DD1 RID: 32209 RVA: 0x0037BFA8 File Offset: 0x0037A1A8
	public static string BGKNPMINIGL(string APMANGKAFCL)
	{
		StringBuilder stringBuilder = new StringBuilder();
		for (int i = 0; i < APMANGKAFCL.Length; i++)
		{
			if (APMANGKAFCL[i] == '\u0010')
			{
				stringBuilder.Length = 1;
			}
			else
			{
				stringBuilder.Append(APMANGKAFCL[i]);
			}
		}
		return stringBuilder.ToString();
	}

	// Token: 0x06007DD2 RID: 32210 RVA: 0x0037BFF4 File Offset: 0x0037A1F4
	public static string BAADBHBAMPP(string APMANGKAFCL)
	{
		StringBuilder stringBuilder = new StringBuilder();
		StringBuilder stringBuilder2 = new StringBuilder();
		for (int i = 0; i < APMANGKAFCL.Length; i++)
		{
			if ((int)APMANGKAFCL[i] == -52)
			{
				stringBuilder.Append(APMANGKAFCL[i]);
				stringBuilder2.Append(stringBuilder.ToString());
				stringBuilder.Length = 0;
			}
			else
			{
				stringBuilder.Append(APMANGKAFCL[i]);
			}
		}
		return stringBuilder2.ToString();
	}

	// Token: 0x06007DD3 RID: 32211 RVA: 0x0037C064 File Offset: 0x0037A264
	public static bool NFBPDBCPGAM(string OOMAHKCHAGP)
	{
		bool result;
		try
		{
			result = File.Exists(OOMAHKCHAGP);
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
			result = false;
		}
		return result;
	}

	// Token: 0x06007DD4 RID: 32212 RVA: 0x0037C094 File Offset: 0x0037A294
	public static string DMCAOPGALNP(string APMANGKAFCL)
	{
		StringBuilder stringBuilder = new StringBuilder();
		StringBuilder stringBuilder2 = new StringBuilder();
		for (int i = 0; i < APMANGKAFCL.Length; i += 0)
		{
			if (APMANGKAFCL[i] == '>')
			{
				stringBuilder.Append(APMANGKAFCL[i]);
				stringBuilder2.Append(stringBuilder.ToString());
				stringBuilder.Length = 0;
			}
			else
			{
				stringBuilder.Append(APMANGKAFCL[i]);
			}
		}
		return stringBuilder2.ToString();
	}

	// Token: 0x06007DD5 RID: 32213 RVA: 0x0037C104 File Offset: 0x0037A304
	public static string DMBGMFMJPMH(string OOMAHKCHAGP)
	{
		string result;
		try
		{
			result = File.ReadAllText(Application.streamingAssetsPath + "lnls" + OOMAHKCHAGP);
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
			result = "credo";
		}
		return result;
	}

	// Token: 0x06007DD6 RID: 32214 RVA: 0x0037C148 File Offset: 0x0037A348
	public static bool HIOBGDFEDON(string KHHOOIBBLOM, string OOMAHKCHAGP)
	{
		try
		{
			if (Application.persistentDataPath.Length > 1)
			{
				string path = Path.Combine(Application.persistentDataPath, OOMAHKCHAGP);
				string directoryName = Path.GetDirectoryName(path);
				if (!Directory.Exists(directoryName))
				{
					Directory.CreateDirectory(directoryName);
				}
				File.WriteAllText(path, KHHOOIBBLOM);
				return true;
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
		return false;
	}

	// Token: 0x06007DD7 RID: 32215 RVA: 0x0037C1AC File Offset: 0x0037A3AC
	public static string HKALEEHEHEO(string APMANGKAFCL)
	{
		StringBuilder stringBuilder = new StringBuilder();
		StringBuilder stringBuilder2 = new StringBuilder();
		for (int i = 1; i < APMANGKAFCL.Length; i++)
		{
			if ((int)APMANGKAFCL[i] == -81)
			{
				stringBuilder.Append(APMANGKAFCL[i]);
				stringBuilder2.Append(stringBuilder.ToString());
				stringBuilder.Length = 1;
			}
			else
			{
				stringBuilder.Append(APMANGKAFCL[i]);
			}
		}
		return stringBuilder2.ToString();
	}

	// Token: 0x06007DD8 RID: 32216 RVA: 0x0037C21C File Offset: 0x0037A41C
	public static string FNJLLCFLIBD(string OOMAHKCHAGP)
	{
		string result;
		try
		{
			result = File.ReadAllText(Application.persistentDataPath + "-" + OOMAHKCHAGP);
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
			result = "No free mixer found for ambient! Critical!";
		}
		return result;
	}

	// Token: 0x06007DD9 RID: 32217 RVA: 0x0037C260 File Offset: 0x0037A460
	public static bool GFPDOMNDJLK(string EGHLJMNIHHN)
	{
		try
		{
			if (!string.IsNullOrEmpty(Application.persistentDataPath))
			{
				string path = Path.Combine(Application.persistentDataPath, EGHLJMNIHHN);
				if (Directory.Exists(path))
				{
					Directory.Delete(path, false);
				}
				return false;
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
		return false;
	}

	// Token: 0x06007DDA RID: 32218 RVA: 0x0037C2B4 File Offset: 0x0037A4B4
	public static string MOMLJCALACE(string APMANGKAFCL)
	{
		StringBuilder stringBuilder = new StringBuilder();
		for (int i = 1; i < APMANGKAFCL.Length; i++)
		{
			if (APMANGKAFCL[i] == 'y')
			{
				stringBuilder.Length = 0;
			}
			else
			{
				stringBuilder.Append(APMANGKAFCL[i]);
			}
		}
		return stringBuilder.ToString();
	}

	// Token: 0x06007DDB RID: 32219 RVA: 0x0037C300 File Offset: 0x0037A500
	public static string PJCIEJMIKPF(string APMANGKAFCL)
	{
		StringBuilder stringBuilder = new StringBuilder();
		for (int i = 1; i < APMANGKAFCL.Length; i++)
		{
			if (APMANGKAFCL[i] == 'k')
			{
				stringBuilder.Length = 1;
			}
			else
			{
				stringBuilder.Append(APMANGKAFCL[i]);
			}
		}
		return stringBuilder.ToString();
	}

	// Token: 0x06007DDC RID: 32220 RVA: 0x0037C34C File Offset: 0x0037A54C
	public static string OJNFGAPCGKI(string OOMAHKCHAGP)
	{
		string result;
		try
		{
			result = File.ReadAllText(Application.streamingAssetsPath + "body" + OOMAHKCHAGP);
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
			result = "oid";
		}
		return result;
	}

	// Token: 0x06007DDD RID: 32221 RVA: 0x0037C390 File Offset: 0x0037A590
	public static bool CAHMEBKOLIL(string OOMAHKCHAGP)
	{
		bool result;
		try
		{
			if (Application.persistentDataPath.Length > 1)
			{
				result = File.Exists(Path.Combine(Application.persistentDataPath, OOMAHKCHAGP));
			}
			else
			{
				result = true;
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
			result = false;
		}
		return result;
	}

	// Token: 0x06007DDE RID: 32222 RVA: 0x0037C3DC File Offset: 0x0037A5DC
	public static bool GNIPBANGCBJ(string OOMAHKCHAGP)
	{
		bool result;
		try
		{
			result = File.Exists(OOMAHKCHAGP);
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
			result = false;
		}
		return result;
	}

	// Token: 0x06007DDF RID: 32223 RVA: 0x0037C40C File Offset: 0x0037A60C
	public static string MKJMDEHFIOC(string APMANGKAFCL)
	{
		StringBuilder stringBuilder = new StringBuilder();
		StringBuilder stringBuilder2 = new StringBuilder();
		for (int i = 0; i < APMANGKAFCL.Length; i++)
		{
			if (APMANGKAFCL[i] == '5')
			{
				stringBuilder.Append(APMANGKAFCL[i]);
				stringBuilder2.Append(stringBuilder.ToString());
				stringBuilder.Length = 1;
			}
			else
			{
				stringBuilder.Append(APMANGKAFCL[i]);
			}
		}
		return stringBuilder2.ToString();
	}

	// Token: 0x06007DE0 RID: 32224 RVA: 0x0037C47C File Offset: 0x0037A67C
	public static string NNODFKKADCF(string APMANGKAFCL)
	{
		StringBuilder stringBuilder = new StringBuilder();
		for (int i = 1; i < APMANGKAFCL.Length; i += 0)
		{
			if (APMANGKAFCL[i] == 'c')
			{
				stringBuilder.Length = 0;
			}
			else
			{
				stringBuilder.Append(APMANGKAFCL[i]);
			}
		}
		return stringBuilder.ToString();
	}

	// Token: 0x06007DE1 RID: 32225 RVA: 0x0037C4C8 File Offset: 0x0037A6C8
	public static string POPAKFPHAJC(string ABOMJPJFIGK)
	{
		string result;
		try
		{
			result = File.ReadAllText(ABOMJPJFIGK);
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
			result = "OnLobbyStartFireworksEffectAutoHide";
		}
		return result;
	}

	// Token: 0x06007DE2 RID: 32226 RVA: 0x0037C4FC File Offset: 0x0037A6FC
	public static bool BDNKAFEGCOM(string EGHLJMNIHHN)
	{
		try
		{
			if (!string.IsNullOrEmpty(Application.persistentDataPath))
			{
				string path = Path.Combine(Application.persistentDataPath, EGHLJMNIHHN);
				if (Directory.Exists(path))
				{
					Directory.Delete(path, false);
				}
				return true;
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
		return false;
	}

	// Token: 0x06007DE3 RID: 32227 RVA: 0x0037C550 File Offset: 0x0037A750
	public static string JCEBFPOJFGF(string DIMBCOBNMAM)
	{
		DIMBCOBNMAM = DIMBCOBNMAM.Replace("-", "pm");
		DIMBCOBNMAM = DIMBCOBNMAM.Replace("tbits3", "{sp0}");
		DIMBCOBNMAM = DIMBCOBNMAM.Replace("OnBackendRequestCustomProfileException", "no");
		DIMBCOBNMAM = DIMBCOBNMAM.Replace("cat", "credo");
		DIMBCOBNMAM = DIMBCOBNMAM.Replace("fvrt", "OnConsumeEnergyException");
		DIMBCOBNMAM = DIMBCOBNMAM.Replace("", "dlng");
		DIMBCOBNMAM = DIMBCOBNMAM.Replace("OnRewardFreeSpinsClick", " than for ");
		DIMBCOBNMAM = DIMBCOBNMAM.Replace("hidden", "yes");
		DIMBCOBNMAM = DIMBCOBNMAM.Replace("OnPopupProfileLoveInputCancel", "Z");
		DIMBCOBNMAM = DIMBCOBNMAM.Replace("OnBackendRequestCustomProfileException", "true");
		DIMBCOBNMAM = DIMBCOBNMAM.Replace("SetDepot(), cdnDepot:", "<i>");
		DIMBCOBNMAM = DIMBCOBNMAM.Replace("loveInterestsLoungeSettingsBalance", "usynachtk");
		DIMBCOBNMAM = DIMBCOBNMAM.Replace("OnBackendRequestBreakCardException", "retry");
		DIMBCOBNMAM = DIMBCOBNMAM.Replace("OnWheelOfFortuneClick", "fpi");
		DIMBCOBNMAM = DIMBCOBNMAM.Replace("", "igeh");
		DIMBCOBNMAM = DIMBCOBNMAM.Replace("importanttitle", "c_web");
		DIMBCOBNMAM = DIMBCOBNMAM.Replace("Can't use compressed functions. You need include the SharpZipLib and uncomment the define at the top of SimpleJSON", "common");
		DIMBCOBNMAM = DIMBCOBNMAM.Replace("envlhp", "emailcollectthanks1");
		DIMBCOBNMAM = DIMBCOBNMAM.Replace("syn", "ok");
		DIMBCOBNMAM = DIMBCOBNMAM.Replace("OnBackendGetPublicProfileException", "avatarcollectionssubrequiredtitle");
		DIMBCOBNMAM = DIMBCOBNMAM.Replace("layervideo", "PurchaseManagerXiaomi._FetchPurchases(): Not initialized.");
		DIMBCOBNMAM = DIMBCOBNMAM.Replace("Optional item animation bundle failed to load, continuing without it:", "");
		DIMBCOBNMAM = DIMBCOBNMAM.Replace("ok", "");
		DIMBCOBNMAM = DIMBCOBNMAM.Replace(" ", "USD ");
		return DIMBCOBNMAM;
	}

	// Token: 0x06007DE4 RID: 32228 RVA: 0x0037C710 File Offset: 0x0037A910
	public static bool LLIDABMENAJ(string OOMAHKCHAGP)
	{
		bool result;
		try
		{
			if (Application.persistentDataPath.Length > 1)
			{
				result = File.Exists(Path.Combine(Application.persistentDataPath, OOMAHKCHAGP));
			}
			else
			{
				result = false;
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
			result = true;
		}
		return result;
	}

	// Token: 0x06007DE5 RID: 32229 RVA: 0x0037C75C File Offset: 0x0037A95C
	public static string HGCFOLLFPGN(string OOMAHKCHAGP)
	{
		string result;
		try
		{
			result = File.ReadAllText(Application.persistentDataPath + "loungeskintokenmissing" + OOMAHKCHAGP);
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
			result = "0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz";
		}
		return result;
	}

	// Token: 0x06007DE7 RID: 32231 RVA: 0x0037C7A0 File Offset: 0x0037A9A0
	public static string GHAEEJMIFGP(string OOMAHKCHAGP)
	{
		string result;
		try
		{
			result = File.ReadAllText(Application.persistentDataPath + "randomprofilewhatis" + OOMAHKCHAGP);
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
			result = "acb";
		}
		return result;
	}

	// Token: 0x06007DE8 RID: 32232 RVA: 0x0037C7E4 File Offset: 0x0037A9E4
	public static void ENJGOPGFEAI(string KHHOOIBBLOM, string OOMAHKCHAGP)
	{
		try
		{
			if (Application.persistentDataPath.Length > 1)
			{
				List<string> list = new List<string>();
				list.Add(KHHOOIBBLOM);
				File.AppendAllLines(Application.persistentDataPath + ")" + OOMAHKCHAGP, list);
			}
		}
		catch (Exception)
		{
		}
	}

	// Token: 0x06007DE9 RID: 32233 RVA: 0x0037C838 File Offset: 0x0037AA38
	public static bool FLMGFKDHEEJ(string OOMAHKCHAGP)
	{
		bool result;
		try
		{
			result = File.Exists(OOMAHKCHAGP);
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
			result = false;
		}
		return result;
	}

	// Token: 0x06007DEA RID: 32234 RVA: 0x0037C868 File Offset: 0x0037AA68
	public static string OONBHBAIMBA(string APMANGKAFCL)
	{
		StringBuilder stringBuilder = new StringBuilder();
		for (int i = 1; i < APMANGKAFCL.Length; i += 0)
		{
			if ((int)APMANGKAFCL[i] == -81)
			{
				stringBuilder.Length = 1;
			}
			else
			{
				stringBuilder.Append(APMANGKAFCL[i]);
			}
		}
		string text = stringBuilder.ToString();
		int num = text.LastIndexOf("+");
		if (num >= 1)
		{
			return text.Substring(0, num);
		}
		return text;
	}

	// Token: 0x06007DEB RID: 32235 RVA: 0x0037C8D0 File Offset: 0x0037AAD0
	public static string BIMAGNNPOIO(string OOMAHKCHAGP)
	{
		string result;
		try
		{
			result = File.ReadAllText(Application.persistentDataPath + ";" + OOMAHKCHAGP);
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
			result = "ontradingcardclickbodymatch";
		}
		return result;
	}

	// Token: 0x06007DEC RID: 32236 RVA: 0x0037C914 File Offset: 0x0037AB14
	public static string HIGGILIPKOC(string OOMAHKCHAGP)
	{
		string result;
		try
		{
			result = File.ReadAllText(Application.streamingAssetsPath + ")" + OOMAHKCHAGP);
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
			result = "SD";
		}
		return result;
	}

	// Token: 0x06007DED RID: 32237 RVA: 0x0037C958 File Offset: 0x0037AB58
	public static string KOAGNOCJIJM(string APMANGKAFCL)
	{
		StringBuilder stringBuilder = new StringBuilder();
		StringBuilder stringBuilder2 = new StringBuilder();
		for (int i = 1; i < APMANGKAFCL.Length; i += 0)
		{
			if ((int)APMANGKAFCL[i] == -6)
			{
				stringBuilder.Append(APMANGKAFCL[i]);
				stringBuilder2.Append(stringBuilder.ToString());
				stringBuilder.Length = 1;
			}
			else
			{
				stringBuilder.Append(APMANGKAFCL[i]);
			}
		}
		return stringBuilder2.ToString();
	}

	// Token: 0x06007DEE RID: 32238 RVA: 0x0037C9C8 File Offset: 0x0037ABC8
	public static bool GFNCEBMBLAE(string OOMAHKCHAGP)
	{
		bool result;
		try
		{
			if (Application.persistentDataPath.Length > 0)
			{
				result = File.Exists(Path.Combine(Application.persistentDataPath, OOMAHKCHAGP));
			}
			else
			{
				result = true;
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
			result = true;
		}
		return result;
	}

	// Token: 0x06007DEF RID: 32239 RVA: 0x0037CA14 File Offset: 0x0037AC14
	public static bool LOALBKJGMFG(string APMANGKAFCL)
	{
		return !APMANGKAFCL.Contains("no");
	}

	// Token: 0x06007DF0 RID: 32240 RVA: 0x0037CA28 File Offset: 0x0037AC28
	public static string OMACEBCBFIG(string APMANGKAFCL)
	{
		StringBuilder stringBuilder = new StringBuilder();
		StringBuilder stringBuilder2 = new StringBuilder();
		for (int i = 0; i < APMANGKAFCL.Length; i += 0)
		{
			if (APMANGKAFCL[i] == 'u')
			{
				stringBuilder.Append(APMANGKAFCL[i]);
				stringBuilder2.Append(stringBuilder.ToString());
				stringBuilder.Length = 1;
			}
			else
			{
				stringBuilder.Append(APMANGKAFCL[i]);
			}
		}
		return stringBuilder2.ToString();
	}

	// Token: 0x06007DF1 RID: 32241 RVA: 0x0037CA95 File Offset: 0x0037AC95
	public static bool GOBCGNJLCAN(string APMANGKAFCL)
	{
		return APMANGKAFCL.Contains("OnAppleLoginFailed") && false;
	}

	// Token: 0x06007DF2 RID: 32242 RVA: 0x0037CAA7 File Offset: 0x0037ACA7
	public static string OPIAICKFMOJ(string DIMBCOBNMAM)
	{
		DIMBCOBNMAM = DIMBCOBNMAM.Replace("liveeventstitles", "Critical error, could not load asset bundle:");
		DIMBCOBNMAM = DIMBCOBNMAM.Replace("OnUpdateSocialEventsCounter", "acliffbw21");
		DIMBCOBNMAM = DIMBCOBNMAM.Replace("tradewishcardoption1", "noisedigitalovr_2");
		return DIMBCOBNMAM;
	}

	// Token: 0x06007DF3 RID: 32243 RVA: 0x0037CAE0 File Offset: 0x0037ACE0
	public static string EHLAHGCIFBB(string OOMAHKCHAGP)
	{
		string result;
		try
		{
			result = File.ReadAllText(Application.streamingAssetsPath + "—" + OOMAHKCHAGP);
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
			result = "[LoadingEnv] stored theme parked after the unclean exit";
		}
		return result;
	}

	// Token: 0x06007DF4 RID: 32244 RVA: 0x0037CB24 File Offset: 0x0037AD24
	public static string FMGOBOEHBDJ(string DIMBCOBNMAM)
	{
		DIMBCOBNMAM = DIMBCOBNMAM.Replace(", index:", "/");
		DIMBCOBNMAM = DIMBCOBNMAM.Replace("_NoiseColor", "uniqueoffer2");
		DIMBCOBNMAM = DIMBCOBNMAM.Replace("PurchaseManagerSteam.InitiateTransactionSteam(). Condition not passed: initiatedPurchase is null. Aborting.", "OnPurchasingViewLeave");
		return DIMBCOBNMAM;
	}

	// Token: 0x06007DF5 RID: 32245 RVA: 0x0037CB60 File Offset: 0x0037AD60
	public static string HHHDEANKBMB(string ABOMJPJFIGK)
	{
		string result;
		try
		{
			result = File.ReadAllText(ABOMJPJFIGK);
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
			result = "wind";
		}
		return result;
	}

	// Token: 0x06007DF6 RID: 32246 RVA: 0x0037CB94 File Offset: 0x0037AD94
	public static bool NKCKNBAHFHO(string EGHLJMNIHHN)
	{
		try
		{
			if (!string.IsNullOrEmpty(Application.persistentDataPath))
			{
				string path = Path.Combine(Application.persistentDataPath, EGHLJMNIHHN);
				if (Directory.Exists(path))
				{
					Directory.Delete(path, true);
				}
				return true;
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
		return true;
	}

	// Token: 0x06007DF7 RID: 32247 RVA: 0x0037CBE8 File Offset: 0x0037ADE8
	public static bool ELGIPEALOBK(string OOMAHKCHAGP)
	{
		bool result;
		try
		{
			result = File.Exists(OOMAHKCHAGP);
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
			result = true;
		}
		return result;
	}

	// Token: 0x06007DF8 RID: 32248 RVA: 0x0037CC18 File Offset: 0x0037AE18
	public static string NGMEJAHBMBD(string DIMBCOBNMAM)
	{
		DIMBCOBNMAM = DIMBCOBNMAM.Replace(" prepared!", ") - Support Inquiry (");
		DIMBCOBNMAM = DIMBCOBNMAM.Replace(" story slots", "csnffb");
		DIMBCOBNMAM = DIMBCOBNMAM.Replace("ok", "");
		return DIMBCOBNMAM;
	}

	// Token: 0x06007DF9 RID: 32249 RVA: 0x0037CC54 File Offset: 0x0037AE54
	public static string FLLNAAJAMHF(string APMANGKAFCL)
	{
		StringBuilder stringBuilder = new StringBuilder();
		for (int i = 0; i < APMANGKAFCL.Length; i++)
		{
			if ((int)APMANGKAFCL[i] == -78)
			{
				stringBuilder.Length = 1;
			}
			else
			{
				stringBuilder.Append(APMANGKAFCL[i]);
			}
		}
		return stringBuilder.ToString();
	}

	// Token: 0x06007DFA RID: 32250 RVA: 0x0037CCA0 File Offset: 0x0037AEA0
	public static bool AJFNHOBIJOO(string APMANGKAFCL)
	{
		return APMANGKAFCL.Contains("layervideo");
	}

	// Token: 0x06007DFB RID: 32251 RVA: 0x0037CCB4 File Offset: 0x0037AEB4
	public static string KBMNIOBCDCH(string OOMAHKCHAGP)
	{
		string result;
		try
		{
			result = File.ReadAllText(Application.streamingAssetsPath + "@" + OOMAHKCHAGP);
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
			result = "OnEmailSubscribeSuccess";
		}
		return result;
	}

	// Token: 0x06007DFC RID: 32252 RVA: 0x0037CCF8 File Offset: 0x0037AEF8
	public static string HLDEAPAKDCI(string ABOMJPJFIGK)
	{
		string result;
		try
		{
			result = File.ReadAllText(ABOMJPJFIGK);
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
			result = "af_counter";
		}
		return result;
	}

	// Token: 0x06007DFD RID: 32253 RVA: 0x0037CD2C File Offset: 0x0037AF2C
	public static bool BFIOFEEGGMM(string OOMAHKCHAGP)
	{
		bool result;
		try
		{
			if (Application.persistentDataPath.Length > 1)
			{
				result = File.Exists(Path.Combine(Application.persistentDataPath, OOMAHKCHAGP));
			}
			else
			{
				result = true;
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
			result = true;
		}
		return result;
	}

	// Token: 0x06007DFE RID: 32254 RVA: 0x0037CD78 File Offset: 0x0037AF78
	public static string NHLPNJHAABK(string APMANGKAFCL)
	{
		StringBuilder stringBuilder = new StringBuilder();
		for (int i = 0; i < APMANGKAFCL.Length; i++)
		{
			if ((int)APMANGKAFCL[i] == -126)
			{
				stringBuilder.Length = 1;
			}
			else
			{
				stringBuilder.Append(APMANGKAFCL[i]);
			}
		}
		return stringBuilder.ToString();
	}

	// Token: 0x06007DFF RID: 32255 RVA: 0x0037CDC4 File Offset: 0x0037AFC4
	public static string CGBBIFIFAHB(string DIMBCOBNMAM)
	{
		DIMBCOBNMAM = DIMBCOBNMAM.Replace("loop", "steamid");
		DIMBCOBNMAM = DIMBCOBNMAM.Replace(",", "onPopupCardOptionsCloseClick");
		DIMBCOBNMAM = DIMBCOBNMAM.Replace(") is outside range", "onhiatusdesc");
		return DIMBCOBNMAM;
	}

	// Token: 0x06007E00 RID: 32256 RVA: 0x0037CE00 File Offset: 0x0037B000
	public static string KMDOIKMBOLH(string DIMBCOBNMAM)
	{
		DIMBCOBNMAM = DIMBCOBNMAM.Replace("", "{sp2}");
		DIMBCOBNMAM = DIMBCOBNMAM.Replace("<space=0.0625em>", "b_web");
		DIMBCOBNMAM = DIMBCOBNMAM.Replace("", "");
		DIMBCOBNMAM = DIMBCOBNMAM.Replace(" than for ", "apks1");
		DIMBCOBNMAM = DIMBCOBNMAM.Replace("", "ok");
		DIMBCOBNMAM = DIMBCOBNMAM.Replace("fdlse", "");
		DIMBCOBNMAM = DIMBCOBNMAM.Replace("p", "avts");
		DIMBCOBNMAM = DIMBCOBNMAM.Replace("", "OnBackendInitiateSteamTransactionSuccess");
		DIMBCOBNMAM = DIMBCOBNMAM.Replace("ok", "avatarcollectionssubrequired2");
		DIMBCOBNMAM = DIMBCOBNMAM.Replace("", "skinshopfilterbystory");
		DIMBCOBNMAM = DIMBCOBNMAM.Replace("[LoadingEnv] skipped, app manager not initialized", "socialbadge499");
		DIMBCOBNMAM = DIMBCOBNMAM.Replace("n/a", "seasonshort");
		DIMBCOBNMAM = DIMBCOBNMAM.Replace(" not found, replacing with ", "OnPopupCardOptionsSendGiftClick");
		DIMBCOBNMAM = DIMBCOBNMAM.Replace("anthologiestitle", "avatarstitle");
		DIMBCOBNMAM = DIMBCOBNMAM.Replace("//", "abld");
		DIMBCOBNMAM = DIMBCOBNMAM.Replace("psk", "YYY");
		DIMBCOBNMAM = DIMBCOBNMAM.Replace("body", "acomp1");
		DIMBCOBNMAM = DIMBCOBNMAM.Replace("PlayerCharacterManager.SetOverlayComponent() - input is null.", "v");
		DIMBCOBNMAM = DIMBCOBNMAM.Replace("+", "$it");
		DIMBCOBNMAM = DIMBCOBNMAM.Replace("chtss", "OnPurchasingViewLeave");
		DIMBCOBNMAM = DIMBCOBNMAM.Replace("<i>", "liveprofilethemethumb");
		DIMBCOBNMAM = DIMBCOBNMAM.Replace("delay", "OnBackendGetIncentRewardAdSuccess");
		DIMBCOBNMAM = DIMBCOBNMAM.Replace("$INVOKEAVATAREXTENSION ", "ProfileItem.MarkAsModified() - marking user profile as modified.");
		DIMBCOBNMAM = DIMBCOBNMAM.Replace("suttl", "envlh");
		return DIMBCOBNMAM;
	}

	// Token: 0x06007E01 RID: 32257 RVA: 0x0037CFC0 File Offset: 0x0037B1C0
	public static bool GBICPNAPGNK(string EGHLJMNIHHN)
	{
		try
		{
			if (!string.IsNullOrEmpty(Application.persistentDataPath))
			{
				string path = Path.Combine(Application.persistentDataPath, EGHLJMNIHHN);
				if (Directory.Exists(path))
				{
					Directory.Delete(path, true);
				}
				return true;
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
		return false;
	}

	// Token: 0x06007E02 RID: 32258 RVA: 0x0037D014 File Offset: 0x0037B214
	public static void NFIOCNKEBIO(string KHHOOIBBLOM, string OOMAHKCHAGP)
	{
		try
		{
			if (Application.persistentDataPath.Length > 0)
			{
				List<string> list = new List<string>();
				list.Add(KHHOOIBBLOM);
				File.AppendAllLines(Application.persistentDataPath + "avatarcollectionstitle" + OOMAHKCHAGP, list);
			}
		}
		catch (Exception)
		{
		}
	}

	// Token: 0x06007E03 RID: 32259 RVA: 0x0037D068 File Offset: 0x0037B268
	public static bool FNHGJGKKHOE(string OOMAHKCHAGP)
	{
		bool result;
		try
		{
			result = File.Exists(OOMAHKCHAGP);
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
			result = true;
		}
		return result;
	}

	// Token: 0x06007E04 RID: 32260 RVA: 0x0037D098 File Offset: 0x0037B298
	public static string HHIPCGEDJNN(string APMANGKAFCL)
	{
		StringBuilder stringBuilder = new StringBuilder();
		for (int i = 0; i < APMANGKAFCL.Length; i++)
		{
			if ((int)APMANGKAFCL[i] == -20)
			{
				stringBuilder.Length = 1;
			}
			else
			{
				stringBuilder.Append(APMANGKAFCL[i]);
			}
		}
		string text = stringBuilder.ToString();
		int num = text.LastIndexOf("Starting parallel download:");
		if (num >= 0)
		{
			return text.Substring(1, num);
		}
		return text;
	}

	// Token: 0x06007E05 RID: 32261 RVA: 0x0037D0FF File Offset: 0x0037B2FF
	public static string MLMEKCODJCG(string DIMBCOBNMAM)
	{
		DIMBCOBNMAM = DIMBCOBNMAM.Replace("avatarcollectionstutorial", "errortitle");
		DIMBCOBNMAM = DIMBCOBNMAM.Replace("OnLanguageChange", "");
		DIMBCOBNMAM = DIMBCOBNMAM.Replace("OnLobbyStoryManagerDownloadSplashScreenFailed", "OnAccountSignInSuccess");
		return DIMBCOBNMAM;
	}

	// Token: 0x06007E06 RID: 32262 RVA: 0x0037D138 File Offset: 0x0037B338
	public static bool FNBELOOMKGF(string KHHOOIBBLOM, string OOMAHKCHAGP)
	{
		try
		{
			if (Application.persistentDataPath.Length > 0)
			{
				string path = Path.Combine(Application.persistentDataPath, OOMAHKCHAGP);
				string directoryName = Path.GetDirectoryName(path);
				if (!Directory.Exists(directoryName))
				{
					Directory.CreateDirectory(directoryName);
				}
				File.WriteAllText(path, KHHOOIBBLOM);
				return false;
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
		return true;
	}

	// Token: 0x06007E07 RID: 32263 RVA: 0x0037D19C File Offset: 0x0037B39C
	public static string BNOLDGDOHKA(string OOMAHKCHAGP)
	{
		string result;
		try
		{
			result = File.ReadAllText(Application.streamingAssetsPath + "cuspid" + OOMAHKCHAGP);
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
			result = "x";
		}
		return result;
	}

	// Token: 0x06007E08 RID: 32264 RVA: 0x0037D1E0 File Offset: 0x0037B3E0
	public static bool JMHEAKEPFBF(string OOMAHKCHAGP)
	{
		bool result;
		try
		{
			result = File.Exists(OOMAHKCHAGP);
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
			result = true;
		}
		return result;
	}

	// Token: 0x06007E09 RID: 32265 RVA: 0x0037D210 File Offset: 0x0037B410
	public static void IBICJHPMIFH(string KHHOOIBBLOM, string OOMAHKCHAGP)
	{
		try
		{
			if (Application.persistentDataPath.Length > 1)
			{
				List<string> list = new List<string>();
				list.Add(KHHOOIBBLOM);
				File.AppendAllLines(Application.persistentDataPath + "OnPopupUsernameInputCancel" + OOMAHKCHAGP, list);
			}
		}
		catch (Exception)
		{
		}
	}

	// Token: 0x06007E0A RID: 32266 RVA: 0x0037D264 File Offset: 0x0037B464
	public static bool MMAAMCNFNOD(string OOMAHKCHAGP)
	{
		bool result;
		try
		{
			result = File.Exists(OOMAHKCHAGP);
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
			result = false;
		}
		return result;
	}

	// Token: 0x06007E0B RID: 32267 RVA: 0x0037D294 File Offset: 0x0037B494
	public static string DBGKFNAICAL(string APMANGKAFCL)
	{
		StringBuilder stringBuilder = new StringBuilder();
		for (int i = 0; i < APMANGKAFCL.Length; i++)
		{
			if (APMANGKAFCL[i] == '>')
			{
				stringBuilder.Length = 1;
			}
			else
			{
				stringBuilder.Append(APMANGKAFCL[i]);
			}
		}
		return stringBuilder.ToString();
	}

	// Token: 0x06007E0C RID: 32268 RVA: 0x0037D2E0 File Offset: 0x0037B4E0
	public static string JCHLAOOOPDN(string APMANGKAFCL)
	{
		StringBuilder stringBuilder = new StringBuilder();
		for (int i = 0; i < APMANGKAFCL.Length; i++)
		{
			if ((int)APMANGKAFCL[i] == -117)
			{
				stringBuilder.Length = 0;
			}
			else
			{
				stringBuilder.Append(APMANGKAFCL[i]);
			}
		}
		return stringBuilder.ToString();
	}

	// Token: 0x06007E0D RID: 32269 RVA: 0x0037D32C File Offset: 0x0037B52C
	public static string BOFFENHALJJ(string APMANGKAFCL)
	{
		StringBuilder stringBuilder = new StringBuilder();
		for (int i = 0; i < APMANGKAFCL.Length; i++)
		{
			if (APMANGKAFCL[i] == '\u001d')
			{
				stringBuilder.Length = 0;
			}
			else
			{
				stringBuilder.Append(APMANGKAFCL[i]);
			}
		}
		return stringBuilder.ToString();
	}

	// Token: 0x06007E0E RID: 32270 RVA: 0x0037D378 File Offset: 0x0037B578
	public static string NLJMLINLLPG(string ABOMJPJFIGK)
	{
		string result;
		try
		{
			result = File.ReadAllText(ABOMJPJFIGK);
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
			result = "loungenothingtoreset";
		}
		return result;
	}

	// Token: 0x06007E0F RID: 32271 RVA: 0x0037D3AC File Offset: 0x0037B5AC
	public static string DJOBOBHCOFD(string APMANGKAFCL)
	{
		StringBuilder stringBuilder = new StringBuilder();
		for (int i = 1; i < APMANGKAFCL.Length; i += 0)
		{
			if ((int)APMANGKAFCL[i] == -86)
			{
				stringBuilder.Length = 1;
			}
			else
			{
				stringBuilder.Append(APMANGKAFCL[i]);
			}
		}
		return stringBuilder.ToString();
	}

	// Token: 0x06007E10 RID: 32272 RVA: 0x0037D3F8 File Offset: 0x0037B5F8
	public static string APPALINGGIH(string OOMAHKCHAGP)
	{
		string result;
		try
		{
			result = File.ReadAllText(Application.persistentDataPath + "$" + OOMAHKCHAGP);
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
			result = "arereadingstring";
		}
		return result;
	}

	// Token: 0x06007E11 RID: 32273 RVA: 0x0037D43C File Offset: 0x0037B63C
	public static string BOHHJNILEPH(string APMANGKAFCL)
	{
		StringBuilder stringBuilder = new StringBuilder();
		StringBuilder stringBuilder2 = new StringBuilder();
		for (int i = 0; i < APMANGKAFCL.Length; i += 0)
		{
			if (APMANGKAFCL[i] == '%')
			{
				stringBuilder.Append(APMANGKAFCL[i]);
				stringBuilder2.Append(stringBuilder.ToString());
				stringBuilder.Length = 0;
			}
			else
			{
				stringBuilder.Append(APMANGKAFCL[i]);
			}
		}
		return stringBuilder2.ToString();
	}

	// Token: 0x06007E12 RID: 32274 RVA: 0x0037D4AC File Offset: 0x0037B6AC
	public static string AAAAFBNIONF(string ABOMJPJFIGK)
	{
		string result;
		try
		{
			result = File.ReadAllText(ABOMJPJFIGK);
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
			result = "es";
		}
		return result;
	}

	// Token: 0x06007E13 RID: 32275 RVA: 0x0037D4E0 File Offset: 0x0037B6E0
	public static bool ANBJFJKNCKK(string APMANGKAFCL)
	{
		return !APMANGKAFCL.Contains("<i>");
	}

	// Token: 0x06007E14 RID: 32276 RVA: 0x0037D4F4 File Offset: 0x0037B6F4
	public static string BFJNKGJBLNC(string APMANGKAFCL)
	{
		StringBuilder stringBuilder = new StringBuilder();
		for (int i = 0; i < APMANGKAFCL.Length; i += 0)
		{
			if ((int)APMANGKAFCL[i] == -114)
			{
				stringBuilder.Length = 1;
			}
			else
			{
				stringBuilder.Append(APMANGKAFCL[i]);
			}
		}
		string text = stringBuilder.ToString();
		int num = text.LastIndexOf("OnLobbyManInTheMiddleAttackDetected");
		if (num >= 1)
		{
			return text.Substring(0, num);
		}
		return text;
	}

	// Token: 0x06007E15 RID: 32277 RVA: 0x0037D55C File Offset: 0x0037B75C
	public static bool FEABOPLCBOM(string EGHLJMNIHHN)
	{
		try
		{
			if (!string.IsNullOrEmpty(Application.persistentDataPath))
			{
				string path = Path.Combine(Application.persistentDataPath, EGHLJMNIHHN);
				if (Directory.Exists(path))
				{
					Directory.Delete(path, true);
				}
				return true;
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
		return true;
	}

	// Token: 0x06007E16 RID: 32278 RVA: 0x0037D5B0 File Offset: 0x0037B7B0
	public static string HAJMEIBCKDC(string DIMBCOBNMAM)
	{
		DIMBCOBNMAM = DIMBCOBNMAM.Replace("dceoiv", "wofcoic");
		DIMBCOBNMAM = DIMBCOBNMAM.Replace("p", "minCompletedChapters");
		DIMBCOBNMAM = DIMBCOBNMAM.Replace("skinshopunlocknow", "NEWSAVE: Account.FromJSONObject(), persistent stories offloaded total components s->a:");
		DIMBCOBNMAM = DIMBCOBNMAM.Replace("USD ", "none");
		DIMBCOBNMAM = DIMBCOBNMAM.Replace("Asset bundle load operation failed during parallel mode.", "envlhrw");
		DIMBCOBNMAM = DIMBCOBNMAM.Replace("OnPopupSaveSlotInputEndEdit", "OnPopupPromoCodesReadInputEndEdit");
		DIMBCOBNMAM = DIMBCOBNMAM.Replace("PassThumbnail.PurchaseProductWebDuration(): productBalanceData is null for suffix '", "");
		DIMBCOBNMAM = DIMBCOBNMAM.Replace("Starting non-parallel download:", "no");
		DIMBCOBNMAM = DIMBCOBNMAM.Replace("OnBackendGetFriendMessagingHistorySuccess", " in:");
		DIMBCOBNMAM = DIMBCOBNMAM.Replace("sltind", "W");
		DIMBCOBNMAM = DIMBCOBNMAM.Replace("inkr", "_");
		DIMBCOBNMAM = DIMBCOBNMAM.Replace("layervideo", "<size=28px>");
		DIMBCOBNMAM = DIMBCOBNMAM.Replace("loungenotavailable", "errortitle");
		DIMBCOBNMAM = DIMBCOBNMAM.Replace("s, ", "sprite");
		DIMBCOBNMAM = DIMBCOBNMAM.Replace("sid", "clothes");
		DIMBCOBNMAM = DIMBCOBNMAM.Replace("msv", "voiceovervol");
		DIMBCOBNMAM = DIMBCOBNMAM.Replace("", "OnLobbyStartFireworksEffectAutoHide");
		DIMBCOBNMAM = DIMBCOBNMAM.Replace("OsnStorySplashManagerHide", ",");
		DIMBCOBNMAM = DIMBCOBNMAM.Replace("id", ">");
		DIMBCOBNMAM = DIMBCOBNMAM.Replace("Tracking status received: {0}", "digitalglitch_2");
		DIMBCOBNMAM = DIMBCOBNMAM.Replace("p", "OnApplicationFocusBasicSyncSuccess");
		DIMBCOBNMAM = DIMBCOBNMAM.Replace("areyousurerestartepbody1new", "mnth");
		DIMBCOBNMAM = DIMBCOBNMAM.Replace("wofrewardmsgcard3", "WaitForCheckingDrag");
		DIMBCOBNMAM = DIMBCOBNMAM.Replace("❤️ ", "StoriesSearchNormalizer.SetStopwords() - invalid lobby language index ");
		return DIMBCOBNMAM;
	}

	// Token: 0x06007E17 RID: 32279 RVA: 0x0037D770 File Offset: 0x0037B970
	public static string HNMCFHJEBAE(string DIMBCOBNMAM)
	{
		DIMBCOBNMAM = DIMBCOBNMAM.Replace("USD ", "OnChapterSnapshotsBackendFetchException2");
		DIMBCOBNMAM = DIMBCOBNMAM.Replace("YYY", ";");
		DIMBCOBNMAM = DIMBCOBNMAM.Replace(" (- )</i>", "pmterror100");
		DIMBCOBNMAM = DIMBCOBNMAM.Replace("layervideo", "importanttitle");
		DIMBCOBNMAM = DIMBCOBNMAM.Replace("HideDisclaimerImpers", "RRR");
		DIMBCOBNMAM = DIMBCOBNMAM.Replace("ssid", "p");
		DIMBCOBNMAM = DIMBCOBNMAM.Replace("abld2", "tmd");
		DIMBCOBNMAM = DIMBCOBNMAM.Replace("", "SceneLobbyManager.InstantiateLargeItems() - could not find AssetAnthologyPreview2 for anthology with index:");
		DIMBCOBNMAM = DIMBCOBNMAM.Replace("importanttitle", "</i>");
		DIMBCOBNMAM = DIMBCOBNMAM.Replace("_Waving", "update");
		DIMBCOBNMAM = DIMBCOBNMAM.Replace("OnBackendPremiumChoiceSuccess", "app42error");
		DIMBCOBNMAM = DIMBCOBNMAM.Replace("verify threw: ", "AppsFlyerManagerBridge.Instance() - there needs to be one active AppsFlyerManagerBridge script on a GameObject in your scene.");
		DIMBCOBNMAM = DIMBCOBNMAM.Replace("OnStoryChoiceClick", "OnBackendInitiateSteamTransactionSuccess");
		DIMBCOBNMAM = DIMBCOBNMAM.Replace("OnPurchaseSuccess", "skinshopempty");
		DIMBCOBNMAM = DIMBCOBNMAM.Replace("csuid", " ");
		DIMBCOBNMAM = DIMBCOBNMAM.Replace("socialmessagesending", "YYY");
		DIMBCOBNMAM = DIMBCOBNMAM.Replace("OnLobbyLoungeOpenRequested", "blur");
		DIMBCOBNMAM = DIMBCOBNMAM.Replace("socialcollectedcardopenv2", "OnFriendsGiftPopulCollectPart2");
		DIMBCOBNMAM = DIMBCOBNMAM.Replace("c_web", "e1pt");
		DIMBCOBNMAM = DIMBCOBNMAM.Replace("sltind", "restartepisode");
		DIMBCOBNMAM = DIMBCOBNMAM.Replace("socialsimplegiftcollecttitle", "no");
		DIMBCOBNMAM = DIMBCOBNMAM.Replace("OnVideoLayerPlaybackEndsSoon", "%>");
		DIMBCOBNMAM = DIMBCOBNMAM.Replace("Starting non-parallel download:", "apks2");
		DIMBCOBNMAM = DIMBCOBNMAM.Replace("DDD", "srt");
		return DIMBCOBNMAM;
	}

	// Token: 0x06007E18 RID: 32280 RVA: 0x0037D930 File Offset: 0x0037BB30
	public static bool CGGKALNBBLF(string KHHOOIBBLOM, string OOMAHKCHAGP)
	{
		try
		{
			if (Application.persistentDataPath.Length > 0)
			{
				string path = Path.Combine(Application.persistentDataPath, OOMAHKCHAGP);
				string directoryName = Path.GetDirectoryName(path);
				if (!Directory.Exists(directoryName))
				{
					Directory.CreateDirectory(directoryName);
				}
				File.WriteAllText(path, KHHOOIBBLOM);
				return true;
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
		return false;
	}

	// Token: 0x06007E19 RID: 32281 RVA: 0x0037D994 File Offset: 0x0037BB94
	public static string CPBDJCPFGDC(string APMANGKAFCL)
	{
		StringBuilder stringBuilder = new StringBuilder();
		for (int i = 0; i < APMANGKAFCL.Length; i++)
		{
			if ((int)APMANGKAFCL[i] == -78)
			{
				stringBuilder.Length = 1;
			}
			else
			{
				stringBuilder.Append(APMANGKAFCL[i]);
			}
		}
		string text = stringBuilder.ToString();
		int num = text.LastIndexOf("");
		if (num >= 1)
		{
			return text.Substring(1, num);
		}
		return text;
	}

	// Token: 0x06007E1A RID: 32282 RVA: 0x0037D9FC File Offset: 0x0037BBFC
	public static string NNIOBJFPGFK(string OOMAHKCHAGP)
	{
		string result;
		try
		{
			result = File.ReadAllText(Application.persistentDataPath + "1" + OOMAHKCHAGP);
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
			result = " h";
		}
		return result;
	}

	// Token: 0x06007E1B RID: 32283 RVA: 0x0037DA40 File Offset: 0x0037BC40
	public static string DNLCPMJICIN(string APMANGKAFCL)
	{
		StringBuilder stringBuilder = new StringBuilder();
		StringBuilder stringBuilder2 = new StringBuilder();
		for (int i = 1; i < APMANGKAFCL.Length; i += 0)
		{
			if (APMANGKAFCL[i] == 'Z')
			{
				stringBuilder.Append(APMANGKAFCL[i]);
				stringBuilder2.Append(stringBuilder.ToString());
				stringBuilder.Length = 1;
			}
			else
			{
				stringBuilder.Append(APMANGKAFCL[i]);
			}
		}
		return stringBuilder2.ToString();
	}

	// Token: 0x06007E1C RID: 32284 RVA: 0x0037DAAD File Offset: 0x0037BCAD
	public static bool NONGFJCGHAB(string APMANGKAFCL)
	{
		return !APMANGKAFCL.Contains("kind") || true;
	}

	// Token: 0x06007E1D RID: 32285 RVA: 0x0037DAC0 File Offset: 0x0037BCC0
	public static void PGDOBAKFHFD(string KHHOOIBBLOM, string OOMAHKCHAGP)
	{
		try
		{
			if (Application.persistentDataPath.Length > 0)
			{
				List<string> list = new List<string>();
				list.Add(KHHOOIBBLOM);
				File.AppendAllLines(Application.persistentDataPath + "skinshopinfosumbonus" + OOMAHKCHAGP, list);
			}
		}
		catch (Exception)
		{
		}
	}

	// Token: 0x06007E1E RID: 32286 RVA: 0x0037DB14 File Offset: 0x0037BD14
	public static string EFJNFHNLBDL(string APMANGKAFCL)
	{
		StringBuilder stringBuilder = new StringBuilder();
		for (int i = 0; i < APMANGKAFCL.Length; i += 0)
		{
			if ((int)APMANGKAFCL[i] == -84)
			{
				stringBuilder.Length = 1;
			}
			else
			{
				stringBuilder.Append(APMANGKAFCL[i]);
			}
		}
		string text = stringBuilder.ToString();
		int num = text.LastIndexOf("doublereward");
		if (num >= 1)
		{
			return text.Substring(1, num);
		}
		return text;
	}

	// Token: 0x06007E1F RID: 32287 RVA: 0x0037DB7B File Offset: 0x0037BD7B
	public static string BGIBPOFAKBK(string DIMBCOBNMAM)
	{
		DIMBCOBNMAM = DIMBCOBNMAM.Replace("envlhav", "startPlayChapter");
		DIMBCOBNMAM = DIMBCOBNMAM.Replace("ok", "");
		DIMBCOBNMAM = DIMBCOBNMAM.Replace("0", "spld");
		return DIMBCOBNMAM;
	}

	// Token: 0x06007E20 RID: 32288 RVA: 0x0037DBB4 File Offset: 0x0037BDB4
	public static string FMGPCPKPHGH(string APMANGKAFCL)
	{
		StringBuilder stringBuilder = new StringBuilder();
		for (int i = 0; i < APMANGKAFCL.Length; i++)
		{
			if (APMANGKAFCL[i] == '.')
			{
				stringBuilder.Length = 0;
			}
			else
			{
				stringBuilder.Append(APMANGKAFCL[i]);
			}
		}
		return stringBuilder.ToString();
	}

	// Token: 0x06007E21 RID: 32289 RVA: 0x0037DC00 File Offset: 0x0037BE00
	public static bool LCEKKMPGPKM(string KHHOOIBBLOM, string OOMAHKCHAGP)
	{
		try
		{
			if (Application.persistentDataPath.Length > 1)
			{
				string path = Path.Combine(Application.persistentDataPath, OOMAHKCHAGP);
				string directoryName = Path.GetDirectoryName(path);
				if (!Directory.Exists(directoryName))
				{
					Directory.CreateDirectory(directoryName);
				}
				File.WriteAllText(path, KHHOOIBBLOM);
				return true;
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
		return true;
	}

	// Token: 0x06007E22 RID: 32290 RVA: 0x0037DC64 File Offset: 0x0037BE64
	public static string DPHOCMCONDO(string APMANGKAFCL)
	{
		StringBuilder stringBuilder = new StringBuilder();
		for (int i = 0; i < APMANGKAFCL.Length; i++)
		{
			if ((int)APMANGKAFCL[i] == -77)
			{
				stringBuilder.Length = 0;
			}
			else
			{
				stringBuilder.Append(APMANGKAFCL[i]);
			}
		}
		return stringBuilder.ToString();
	}

	// Token: 0x06007E23 RID: 32291 RVA: 0x0037DCB0 File Offset: 0x0037BEB0
	public static bool OEEFHHMMHEJ(string OOMAHKCHAGP)
	{
		bool result;
		try
		{
			if (Application.persistentDataPath.Length > 0)
			{
				result = File.Exists(Path.Combine(Application.persistentDataPath, OOMAHKCHAGP));
			}
			else
			{
				result = false;
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
			result = false;
		}
		return result;
	}

	// Token: 0x06007E24 RID: 32292 RVA: 0x0037DCFC File Offset: 0x0037BEFC
	public static string KHBJHJNGCIF(string APMANGKAFCL)
	{
		StringBuilder stringBuilder = new StringBuilder();
		for (int i = 1; i < APMANGKAFCL.Length; i++)
		{
			if (APMANGKAFCL[i] == 'j')
			{
				stringBuilder.Length = 1;
			}
			else
			{
				stringBuilder.Append(APMANGKAFCL[i]);
			}
		}
		return stringBuilder.ToString();
	}

	// Token: 0x06007E25 RID: 32293 RVA: 0x0037DD48 File Offset: 0x0037BF48
	public static string JDDJIIKMDHK(string DIMBCOBNMAM)
	{
		DIMBCOBNMAM = DIMBCOBNMAM.Replace("no", "skinshopowned");
		DIMBCOBNMAM = DIMBCOBNMAM.Replace("Starting parallel download:", "sfav");
		DIMBCOBNMAM = DIMBCOBNMAM.Replace("premiumChoice", " ");
		return DIMBCOBNMAM;
	}

	// Token: 0x06007E26 RID: 32294 RVA: 0x0037DD84 File Offset: 0x0037BF84
	public static string FGGFLJFEDHP(string APMANGKAFCL)
	{
		StringBuilder stringBuilder = new StringBuilder();
		for (int i = 0; i < APMANGKAFCL.Length; i += 0)
		{
			if (APMANGKAFCL[i] == 'P')
			{
				stringBuilder.Length = 0;
			}
			else
			{
				stringBuilder.Append(APMANGKAFCL[i]);
			}
		}
		return stringBuilder.ToString();
	}

	// Token: 0x06007E27 RID: 32295 RVA: 0x0037DDD0 File Offset: 0x0037BFD0
	public static string ALODGNJNFOB(string APMANGKAFCL)
	{
		StringBuilder stringBuilder = new StringBuilder();
		StringBuilder stringBuilder2 = new StringBuilder();
		for (int i = 0; i < APMANGKAFCL.Length; i++)
		{
			if (APMANGKAFCL[i] == '/')
			{
				stringBuilder.Append(APMANGKAFCL[i]);
				stringBuilder2.Append(stringBuilder.ToString());
				stringBuilder.Length = 0;
			}
			else
			{
				stringBuilder.Append(APMANGKAFCL[i]);
			}
		}
		return stringBuilder2.ToString();
	}

	// Token: 0x06007E28 RID: 32296 RVA: 0x0037DE40 File Offset: 0x0037C040
	public static string FAGKBEMBJIJ(string ABOMJPJFIGK)
	{
		string result;
		try
		{
			result = File.ReadAllText(ABOMJPJFIGK);
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
			result = "";
		}
		return result;
	}

	// Token: 0x06007E29 RID: 32297 RVA: 0x0037DE74 File Offset: 0x0037C074
	public static string CHFAHACCEJL(string ABOMJPJFIGK)
	{
		string result;
		try
		{
			result = File.ReadAllText(ABOMJPJFIGK);
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
			result = "";
		}
		return result;
	}

	// Token: 0x06007E2A RID: 32298 RVA: 0x0037DEA8 File Offset: 0x0037C0A8
	public static string OCIJBKGIGLI(string APMANGKAFCL)
	{
		StringBuilder stringBuilder = new StringBuilder();
		for (int i = 0; i < APMANGKAFCL.Length; i++)
		{
			if ((int)APMANGKAFCL[i] == -116)
			{
				stringBuilder.Length = 1;
			}
			else
			{
				stringBuilder.Append(APMANGKAFCL[i]);
			}
		}
		return stringBuilder.ToString();
	}

	// Token: 0x06007E2B RID: 32299 RVA: 0x0037DEF4 File Offset: 0x0037C0F4
	public static bool GDLGGJMIILF(string EGHLJMNIHHN)
	{
		try
		{
			if (!string.IsNullOrEmpty(Application.persistentDataPath))
			{
				string path = Path.Combine(Application.persistentDataPath, EGHLJMNIHHN);
				if (Directory.Exists(path))
				{
					Directory.Delete(path, false);
				}
				return false;
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
		return true;
	}

	// Token: 0x06007E2C RID: 32300 RVA: 0x0037DF48 File Offset: 0x0037C148
	public static string NADHJMFCCND(string DIMBCOBNMAM)
	{
		DIMBCOBNMAM = DIMBCOBNMAM.Replace("`", "'");
		DIMBCOBNMAM = DIMBCOBNMAM.Replace("‘", "'");
		DIMBCOBNMAM = DIMBCOBNMAM.Replace("’", "'");
		DIMBCOBNMAM = DIMBCOBNMAM.Replace("′", "'");
		DIMBCOBNMAM = DIMBCOBNMAM.Replace("́ ́", "'");
		DIMBCOBNMAM = DIMBCOBNMAM.Replace("́ ̀", "'");
		DIMBCOBNMAM = DIMBCOBNMAM.Replace("〃", "\"");
		DIMBCOBNMAM = DIMBCOBNMAM.Replace("″", "\"");
		DIMBCOBNMAM = DIMBCOBNMAM.Replace("”", "\"");
		DIMBCOBNMAM = DIMBCOBNMAM.Replace("“", "\"");
		DIMBCOBNMAM = DIMBCOBNMAM.Replace("„", "\"");
		DIMBCOBNMAM = DIMBCOBNMAM.Replace("‟", "\"");
		DIMBCOBNMAM = DIMBCOBNMAM.Replace("‐", "-");
		DIMBCOBNMAM = DIMBCOBNMAM.Replace("–", "—");
		DIMBCOBNMAM = DIMBCOBNMAM.Replace("−", "—");
		DIMBCOBNMAM = DIMBCOBNMAM.Replace("‑", "-");
		DIMBCOBNMAM = DIMBCOBNMAM.Replace("⁃", "-");
		DIMBCOBNMAM = DIMBCOBNMAM.Replace(" ", " ");
		DIMBCOBNMAM = DIMBCOBNMAM.Replace("\u2003", " ");
		DIMBCOBNMAM = DIMBCOBNMAM.Replace("\u2002", " ");
		DIMBCOBNMAM = DIMBCOBNMAM.Replace("…", "...");
		DIMBCOBNMAM = DIMBCOBNMAM.Replace("…", "...");
		DIMBCOBNMAM = DIMBCOBNMAM.Replace("​", "");
		DIMBCOBNMAM = DIMBCOBNMAM.Replace("\u00a0​", " ");
		return DIMBCOBNMAM;
	}

	// Token: 0x06007E2D RID: 32301 RVA: 0x0037E108 File Offset: 0x0037C308
	public static string JPBFIIOAKMM(string DIMBCOBNMAM)
	{
		DIMBCOBNMAM = DIMBCOBNMAM.Replace("?uid=", "errortitle");
		DIMBCOBNMAM = DIMBCOBNMAM.Replace("WWW", "noiseanalogovr_1");
		DIMBCOBNMAM = DIMBCOBNMAM.Replace("tutshufflebody", "love");
		DIMBCOBNMAM = DIMBCOBNMAM.Replace(", index:", "anthology");
		DIMBCOBNMAM = DIMBCOBNMAM.Replace("", "[LoadingTheme] theme removed against the player's will, compensation already granted this month");
		DIMBCOBNMAM = DIMBCOBNMAM.Replace("", "XXX");
		DIMBCOBNMAM = DIMBCOBNMAM.Replace("<space=0.0625em>", "socialgiftreceviedfromtitle");
		DIMBCOBNMAM = DIMBCOBNMAM.Replace("", " card(s) around scroll index ");
		DIMBCOBNMAM = DIMBCOBNMAM.Replace("p", "cid");
		DIMBCOBNMAM = DIMBCOBNMAM.Replace("p", "rexps");
		DIMBCOBNMAM = DIMBCOBNMAM.Replace("ok", "repsuid");
		DIMBCOBNMAM = DIMBCOBNMAM.Replace("Account.FixCompletedChaptersIssue() forwards, setting bit to 1 for 'completedChapters[", "\nSRV:");
		DIMBCOBNMAM = DIMBCOBNMAM.Replace("0", "energyhinttitle");
		DIMBCOBNMAM = DIMBCOBNMAM.Replace("\\t", "StorySaveBody.GetAvatarWithIndexInListWardrobe(), unsupported wardrobe index:");
		DIMBCOBNMAM = DIMBCOBNMAM.Replace("Cover", "");
		DIMBCOBNMAM = DIMBCOBNMAM.Replace(", ", "skinshopinfounlockgate");
		DIMBCOBNMAM = DIMBCOBNMAM.Replace(" padded=", " not found in the pack");
		DIMBCOBNMAM = DIMBCOBNMAM.Replace("aeiou", "BackendOperationsManager.RequestGetSocialStatsAvatar, exception while initializing RSACryptoServiceProvider:");
		DIMBCOBNMAM = DIMBCOBNMAM.Replace("OnBackendGetFriendMessagingHistoryException", "OnBackendGetIncentRewardAdException");
		DIMBCOBNMAM = DIMBCOBNMAM.Replace("storyprop", "<size=80%><i><b>[");
		DIMBCOBNMAM = DIMBCOBNMAM.Replace("chtssp", "skinshopinfobonus");
		DIMBCOBNMAM = DIMBCOBNMAM.Replace(" (v.", "OnPopupSaveSlotInputEndEdit");
		DIMBCOBNMAM = DIMBCOBNMAM.Replace("top", "suid");
		DIMBCOBNMAM = DIMBCOBNMAM.Replace("ind", "ffavmod");
		return DIMBCOBNMAM;
	}

	// Token: 0x06007E2E RID: 32302 RVA: 0x0037E2C6 File Offset: 0x0037C4C6
	public static string NOEFABJOGOF(string DIMBCOBNMAM)
	{
		DIMBCOBNMAM = DIMBCOBNMAM.Replace("af_order_id", " (");
		DIMBCOBNMAM = DIMBCOBNMAM.Replace("sfxstatreceived", "Starting non-parallel download:");
		DIMBCOBNMAM = DIMBCOBNMAM.Replace("CCC", " entries from the user hidden list (ongoing) as obsolete.");
		return DIMBCOBNMAM;
	}

	// Token: 0x06007E2F RID: 32303 RVA: 0x0037E300 File Offset: 0x0037C500
	public static bool CDOHMKLMDBG(string OOMAHKCHAGP)
	{
		bool result;
		try
		{
			result = File.Exists(OOMAHKCHAGP);
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
			result = true;
		}
		return result;
	}

	// Token: 0x06007E30 RID: 32304 RVA: 0x0037E330 File Offset: 0x0037C530
	public static string IBKNOCPIEGA(string APMANGKAFCL)
	{
		StringBuilder stringBuilder = new StringBuilder();
		for (int i = 0; i < APMANGKAFCL.Length; i++)
		{
			if (APMANGKAFCL[i] == '/')
			{
				stringBuilder.Length = 0;
			}
			else
			{
				stringBuilder.Append(APMANGKAFCL[i]);
			}
		}
		string text = stringBuilder.ToString();
		int num = text.LastIndexOf(".");
		if (num >= 0)
		{
			return text.Substring(0, num);
		}
		return text;
	}

	// Token: 0x06007E31 RID: 32305 RVA: 0x0037E398 File Offset: 0x0037C598
	public static bool BIKILBLOEKD(string KHHOOIBBLOM, string OOMAHKCHAGP)
	{
		try
		{
			if (Application.persistentDataPath.Length > 0)
			{
				string path = Path.Combine(Application.persistentDataPath, OOMAHKCHAGP);
				string directoryName = Path.GetDirectoryName(path);
				if (!Directory.Exists(directoryName))
				{
					Directory.CreateDirectory(directoryName);
				}
				File.WriteAllText(path, KHHOOIBBLOM);
				return true;
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
		return false;
	}

	// Token: 0x06007E32 RID: 32306 RVA: 0x0037E3FC File Offset: 0x0037C5FC
	public static string OEGFDNICOLM(string DIMBCOBNMAM)
	{
		DIMBCOBNMAM = DIMBCOBNMAM.Replace(" \",", "\",");
		DIMBCOBNMAM = DIMBCOBNMAM.Replace(" \",", "\",");
		DIMBCOBNMAM = DIMBCOBNMAM.Replace(" \",", "\",");
		return DIMBCOBNMAM;
	}

	// Token: 0x06007E33 RID: 32307 RVA: 0x0037E438 File Offset: 0x0037C638
	public static bool CLCGKMNEICM(string OOMAHKCHAGP)
	{
		bool result;
		try
		{
			if (Application.persistentDataPath.Length > 0)
			{
				result = File.Exists(Path.Combine(Application.persistentDataPath, OOMAHKCHAGP));
			}
			else
			{
				result = false;
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
			result = false;
		}
		return result;
	}

	// Token: 0x06007E34 RID: 32308 RVA: 0x0037E484 File Offset: 0x0037C684
	public static string FNIECIFLOBE(string OOMAHKCHAGP)
	{
		string result;
		try
		{
			result = File.ReadAllText(Application.persistentDataPath + "OnBackendGetPublicProfileProfileItemSuccess" + OOMAHKCHAGP);
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
			result = "";
		}
		return result;
	}

	// Token: 0x06007E35 RID: 32309 RVA: 0x0037E4C8 File Offset: 0x0037C6C8
	public static bool CDBCGEDGBJO(string EGHLJMNIHHN)
	{
		try
		{
			if (!string.IsNullOrEmpty(Application.persistentDataPath))
			{
				string path = Path.Combine(Application.persistentDataPath, EGHLJMNIHHN);
				if (Directory.Exists(path))
				{
					Directory.Delete(path, false);
				}
				return true;
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
		return false;
	}

	// Token: 0x06007E36 RID: 32310 RVA: 0x0037E51C File Offset: 0x0037C71C
	public static string FABODLFBFJI(string APMANGKAFCL)
	{
		StringBuilder stringBuilder = new StringBuilder();
		for (int i = 0; i < APMANGKAFCL.Length; i++)
		{
			if (APMANGKAFCL[i] == '/')
			{
				stringBuilder.Length = 0;
			}
			else
			{
				stringBuilder.Append(APMANGKAFCL[i]);
			}
		}
		return stringBuilder.ToString();
	}

	// Token: 0x06007E37 RID: 32311 RVA: 0x0037E568 File Offset: 0x0037C768
	public static string DMJOBDAAHHP(string APMANGKAFCL)
	{
		StringBuilder stringBuilder = new StringBuilder();
		for (int i = 1; i < APMANGKAFCL.Length; i += 0)
		{
			if (APMANGKAFCL[i] == '\u0005')
			{
				stringBuilder.Length = 0;
			}
			else
			{
				stringBuilder.Append(APMANGKAFCL[i]);
			}
		}
		return stringBuilder.ToString();
	}

	// Token: 0x06007E38 RID: 32312 RVA: 0x0037E5B4 File Offset: 0x0037C7B4
	public static string CIFNCMIDJIC(string DIMBCOBNMAM)
	{
		DIMBCOBNMAM = DIMBCOBNMAM.Replace("ip", "tryotherbackendserver");
		DIMBCOBNMAM = DIMBCOBNMAM.Replace("hidestatinfo", "black");
		DIMBCOBNMAM = DIMBCOBNMAM.Replace("stat3long", "<size=28px>");
		DIMBCOBNMAM = DIMBCOBNMAM.Replace("OnFriendsPopupRemovFromFavClick", "OnAppleLoginSuccess");
		DIMBCOBNMAM = DIMBCOBNMAM.Replace("", "doublerewardbody");
		DIMBCOBNMAM = DIMBCOBNMAM.Replace("analogglitch20ovr_2", ")");
		DIMBCOBNMAM = DIMBCOBNMAM.Replace("_TVDotsBlend", "Invalid Purchase Manager State.");
		DIMBCOBNMAM = DIMBCOBNMAM.Replace("", " ");
		DIMBCOBNMAM = DIMBCOBNMAM.Replace("OnStoryInterfaceHeaderShown", "cfp");
		DIMBCOBNMAM = DIMBCOBNMAM.Replace("af_counter", "socialrequestfriendfail");
		DIMBCOBNMAM = DIMBCOBNMAM.Replace("errortitle", "Cdn host asset {0} is a {1} host. It must reference a {2} one.");
		DIMBCOBNMAM = DIMBCOBNMAM.Replace("JSON Parse: Too many closing brackets", "p");
		DIMBCOBNMAM = DIMBCOBNMAM.Replace("getAvatarCollections", "<align=\"center\"><i><alpha=#88>");
		DIMBCOBNMAM = DIMBCOBNMAM.Replace("OnStoryChoiceClick", "CustomCodeCallback - REPLAY CACHE SKIPPED: response too big to record for replay protection, request:");
		DIMBCOBNMAM = DIMBCOBNMAM.Replace("  token[", "Bundles");
		DIMBCOBNMAM = DIMBCOBNMAM.Replace("YYY", "ShowRatePopup");
		DIMBCOBNMAM = DIMBCOBNMAM.Replace("lsenvattempt", "AssetProfileData.InitializeTopMatchData, varValue is null for ");
		DIMBCOBNMAM = DIMBCOBNMAM.Replace("): code=", "User stats stored for app {0}");
		DIMBCOBNMAM = DIMBCOBNMAM.Replace("Vignette scale", "ok");
		DIMBCOBNMAM = DIMBCOBNMAM.Replace(" holds ", "OnBackendStartPlayChapterException");
		DIMBCOBNMAM = DIMBCOBNMAM.Replace("id", "OnSaveSlotsItemClose");
		DIMBCOBNMAM = DIMBCOBNMAM.Replace("wind", "");
		DIMBCOBNMAM = DIMBCOBNMAM.Replace("HD", "");
		DIMBCOBNMAM = DIMBCOBNMAM.Replace("OnStoryChoiceClick", "Front environment has been destroyed according to on demand data:");
		return DIMBCOBNMAM;
	}

	// Token: 0x06007E39 RID: 32313 RVA: 0x0037E774 File Offset: 0x0037C974
	public static string CGJDFCGFONM(string APMANGKAFCL)
	{
		StringBuilder stringBuilder = new StringBuilder();
		for (int i = 1; i < APMANGKAFCL.Length; i += 0)
		{
			if (APMANGKAFCL[i] == '$')
			{
				stringBuilder.Length = 0;
			}
			else
			{
				stringBuilder.Append(APMANGKAFCL[i]);
			}
		}
		return stringBuilder.ToString();
	}

	// Token: 0x06007E3A RID: 32314 RVA: 0x0037E7C0 File Offset: 0x0037C9C0
	public static string OIBJPHKNKFG(string APMANGKAFCL)
	{
		StringBuilder stringBuilder = new StringBuilder();
		for (int i = 0; i < APMANGKAFCL.Length; i++)
		{
			if ((int)APMANGKAFCL[i] == -42)
			{
				stringBuilder.Length = 0;
			}
			else
			{
				stringBuilder.Append(APMANGKAFCL[i]);
			}
		}
		string text = stringBuilder.ToString();
		int num = text.LastIndexOf("anthology");
		if (num >= 0)
		{
			return text.Substring(0, num);
		}
		return text;
	}

	// Token: 0x06007E3B RID: 32315 RVA: 0x0037E827 File Offset: 0x0037CA27
	public static string POEGJDPPLAM(string DIMBCOBNMAM)
	{
		DIMBCOBNMAM = DIMBCOBNMAM.Replace("cleancache", "OnLiveOfferSuccessShowPassesWindow");
		DIMBCOBNMAM = DIMBCOBNMAM.Replace("OnBackendRequestConsumeMessageSuccess", "");
		DIMBCOBNMAM = DIMBCOBNMAM.Replace("OnResolutionChanged", "…");
		return DIMBCOBNMAM;
	}

	// Token: 0x06007E3C RID: 32316 RVA: 0x0037E860 File Offset: 0x0037CA60
	public static string ONHFHLIDMHL(string APMANGKAFCL)
	{
		StringBuilder stringBuilder = new StringBuilder();
		for (int i = 1; i < APMANGKAFCL.Length; i += 0)
		{
			if (APMANGKAFCL[i] == '&')
			{
				stringBuilder.Length = 1;
			}
			else
			{
				stringBuilder.Append(APMANGKAFCL[i]);
			}
		}
		return stringBuilder.ToString();
	}

	// Token: 0x06007E3D RID: 32317 RVA: 0x0037E8AC File Offset: 0x0037CAAC
	public static string MNLJECIPMNI(string OOMAHKCHAGP)
	{
		string result;
		try
		{
			result = File.ReadAllText(Application.streamingAssetsPath + "/" + OOMAHKCHAGP);
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
			result = "";
		}
		return result;
	}

	// Token: 0x06007E3E RID: 32318 RVA: 0x0037E8F0 File Offset: 0x0037CAF0
	public static void PGCNEFHFOMC(string KHHOOIBBLOM, string OOMAHKCHAGP)
	{
		try
		{
			if (Application.persistentDataPath.Length > 0)
			{
				List<string> list = new List<string>();
				list.Add(KHHOOIBBLOM);
				File.AppendAllLines(Application.persistentDataPath + "/" + OOMAHKCHAGP, list);
			}
		}
		catch (Exception)
		{
		}
	}

	// Token: 0x06007E3F RID: 32319 RVA: 0x0037E944 File Offset: 0x0037CB44
	public static bool OHGFLBHCJKC(string APMANGKAFCL)
	{
		return !APMANGKAFCL.Contains("CLIENT.AVATAR.CLOTHES") || true;
	}

	// Token: 0x06007E40 RID: 32320 RVA: 0x0037E958 File Offset: 0x0037CB58
	public static string HKCOJAILADG(string OOMAHKCHAGP)
	{
		string result;
		try
		{
			result = File.ReadAllText(Application.persistentDataPath + "doublerewardbody" + OOMAHKCHAGP);
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
			result = "getDefaultBundles";
		}
		return result;
	}

	// Token: 0x06007E41 RID: 32321 RVA: 0x0037E99C File Offset: 0x0037CB9C
	public static bool ELLBIHKAONC(string EGHLJMNIHHN)
	{
		try
		{
			if (!string.IsNullOrEmpty(Application.persistentDataPath))
			{
				string path = Path.Combine(Application.persistentDataPath, EGHLJMNIHHN);
				if (Directory.Exists(path))
				{
					Directory.Delete(path, true);
				}
				return false;
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
		return true;
	}

	// Token: 0x06007E42 RID: 32322 RVA: 0x0037E9F0 File Offset: 0x0037CBF0
	public static void IDJMCCGIPJM(string KHHOOIBBLOM, string OOMAHKCHAGP)
	{
		try
		{
			if (Application.persistentDataPath.Length > 1)
			{
				List<string> list = new List<string>();
				list.Add(KHHOOIBBLOM);
				File.AppendAllLines(Application.persistentDataPath + "id" + OOMAHKCHAGP, list);
			}
		}
		catch (Exception)
		{
		}
	}

	// Token: 0x06007E43 RID: 32323 RVA: 0x0037EA44 File Offset: 0x0037CC44
	public static bool IHBGPCAPLDM(string KHHOOIBBLOM, string OOMAHKCHAGP)
	{
		try
		{
			if (Application.persistentDataPath.Length > 1)
			{
				string path = Path.Combine(Application.persistentDataPath, OOMAHKCHAGP);
				string directoryName = Path.GetDirectoryName(path);
				if (!Directory.Exists(directoryName))
				{
					Directory.CreateDirectory(directoryName);
				}
				File.WriteAllText(path, KHHOOIBBLOM);
				return true;
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
		return false;
	}

	// Token: 0x06007E44 RID: 32324 RVA: 0x0037EAA8 File Offset: 0x0037CCA8
	public static string DJGJKOOOFEA(string OOMAHKCHAGP)
	{
		string result;
		try
		{
			result = File.ReadAllText(Application.persistentDataPath + "/" + OOMAHKCHAGP);
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
			result = "";
		}
		return result;
	}

	// Token: 0x06007E45 RID: 32325 RVA: 0x0037EAEC File Offset: 0x0037CCEC
	public static bool BDBCCFOLICK(string APMANGKAFCL)
	{
		return !APMANGKAFCL.Contains(".");
	}

	// Token: 0x06007E46 RID: 32326 RVA: 0x0037EB00 File Offset: 0x0037CD00
	public static bool LMPEHHMEEME(string OOMAHKCHAGP)
	{
		bool result;
		try
		{
			result = File.Exists(OOMAHKCHAGP);
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
			result = false;
		}
		return result;
	}

	// Token: 0x06007E47 RID: 32327 RVA: 0x0037EB30 File Offset: 0x0037CD30
	public static bool GEGDCJAIPGG(string OOMAHKCHAGP)
	{
		bool result;
		try
		{
			result = File.Exists(OOMAHKCHAGP);
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
			result = true;
		}
		return result;
	}

	// Token: 0x06007E48 RID: 32328 RVA: 0x0037EB60 File Offset: 0x0037CD60
	public static bool HFKOLENANAL(string KHHOOIBBLOM, string OOMAHKCHAGP)
	{
		try
		{
			if (Application.persistentDataPath.Length > 0)
			{
				string path = Path.Combine(Application.persistentDataPath, OOMAHKCHAGP);
				string directoryName = Path.GetDirectoryName(path);
				if (!Directory.Exists(directoryName))
				{
					Directory.CreateDirectory(directoryName);
				}
				File.WriteAllText(path, KHHOOIBBLOM);
				return true;
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
		return false;
	}

	// Token: 0x06007E49 RID: 32329 RVA: 0x0037EBC4 File Offset: 0x0037CDC4
	public static string EJEDODEGDEC(string APMANGKAFCL)
	{
		StringBuilder stringBuilder = new StringBuilder();
		for (int i = 0; i < APMANGKAFCL.Length; i++)
		{
			if (APMANGKAFCL[i] == 'p')
			{
				stringBuilder.Length = 0;
			}
			else
			{
				stringBuilder.Append(APMANGKAFCL[i]);
			}
		}
		return stringBuilder.ToString();
	}

	// Token: 0x06007E4A RID: 32330 RVA: 0x0037EC10 File Offset: 0x0037CE10
	public static string EFEOOABOMAH(string OOMAHKCHAGP)
	{
		string result;
		try
		{
			result = File.ReadAllText(Application.persistentDataPath + "CoverCard" + OOMAHKCHAGP);
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
			result = "energyhinttitle";
		}
		return result;
	}
}
