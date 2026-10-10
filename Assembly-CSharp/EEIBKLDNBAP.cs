using System;
using System.Collections.Generic;
using System.IO;
using AssetBundles;
using UnityEngine;

// Token: 0x020002B1 RID: 689
public static class EEIBKLDNBAP
{
	// Token: 0x060056FB RID: 22267 RVA: 0x0026C85C File Offset: 0x0026AA5C
	public static void JHOGPGMCIFB(string IOEENLMAMNC)
	{
		if (EEIBKLDNBAP.OCNPLOOGPCN() > 0)
		{
			EEIBKLDNBAP.OBCODEHLMLF(IOEENLMAMNC);
		}
	}

	// Token: 0x060056FC RID: 22268 RVA: 0x0026C86C File Offset: 0x0026AA6C
	public static bool ECMBPHMLCOI()
	{
		bool result;
		try
		{
			LoadingEnvironmentRegistryData loadingEnvironmentRegistryData = EEIBKLDNBAP.FMIJIKAKJFH();
			result = (loadingEnvironmentRegistryData.liteParkNotice && loadingEnvironmentRegistryData.entries.Count > 0);
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
			result = false;
		}
		return result;
	}

	// Token: 0x060056FD RID: 22269 RVA: 0x0026C8B8 File Offset: 0x0026AAB8
	public static bool LCJBJJIHNMH()
	{
		return EEIBKLDNBAP.HALKEBEDHEH;
	}

	// Token: 0x060056FE RID: 22270 RVA: 0x0026C8C0 File Offset: 0x0026AAC0
	private static bool OFPNANLFBMK(string IOEENLMAMNC)
	{
		LoadingEnvironmentRegistryData loadingEnvironmentRegistryData = EEIBKLDNBAP.FMIJIKAKJFH();
		if (loadingEnvironmentRegistryData.entries.Count == 0 || !loadingEnvironmentRegistryData.active)
		{
			return false;
		}
		loadingEnvironmentRegistryData.active = false;
		loadingEnvironmentRegistryData.liteParked = true;
		loadingEnvironmentRegistryData.liteParkNotice = true;
		EEIBKLDNBAP.LPCBDEBKAIM();
		DPGJIJGOCIC.NFIDPOMCNLP("[LoadingEnv] " + IOEENLMAMNC + ", stored theme parked until the full mode returns");
		return true;
	}

	// Token: 0x060056FF RID: 22271 RVA: 0x0026C91C File Offset: 0x0026AB1C
	public static LoadingEnvironmentRegistryEntry HMIKGAKODMP(List<string> MBFMFPCLDFH)
	{
		List<LoadingEnvironmentRegistryEntry> list = new List<LoadingEnvironmentRegistryEntry>();
		EEIBKLDNBAP.PMCELMLNPML = false;
		EEIBKLDNBAP.HALKEBEDHEH = false;
		try
		{
			LoadingEnvironmentRegistryData loadingEnvironmentRegistryData = EEIBKLDNBAP.FMIJIKAKJFH();
			bool flag = EEIBKLDNBAP.DOMBEHHFHOB(loadingEnvironmentRegistryData);
			for (int i = 0; i < loadingEnvironmentRegistryData.entries.Count; i++)
			{
				LoadingEnvironmentRegistryEntry loadingEnvironmentRegistryEntry = loadingEnvironmentRegistryData.entries[i];
				if (loadingEnvironmentRegistryEntry == null || !loadingEnvironmentRegistryEntry.INEKFCLBCAB())
				{
					EEIBKLDNBAP.OBCODEHLMLF("invalid registry entry");
					loadingEnvironmentRegistryData.entries.RemoveAt(i);
					i--;
					flag = true;
				}
				else
				{
					if (EEIBKLDNBAP.AACJIDADOAG(loadingEnvironmentRegistryEntry))
					{
						flag = true;
					}
					bool flag2;
					if (Caching.ready)
					{
						flag2 = EEIBKLDNBAP.JCKIPPJKKLH(loadingEnvironmentRegistryEntry, MBFMFPCLDFH);
					}
					else
					{
						if (!EEIBKLDNBAP.FJKCFFJKNND(loadingEnvironmentRegistryEntry) || !EEIBKLDNBAP.BGANJNLKPDO(loadingEnvironmentRegistryEntry, MBFMFPCLDFH))
						{
							DPGJIJGOCIC.NFIDPOMCNLP("[LoadingEnv] skipping " + loadingEnvironmentRegistryEntry.envId + " this time, caching system not ready and no direct cache files");
							EEIBKLDNBAP.HALKEBEDHEH = true;
							goto IL_130;
						}
						flag2 = true;
					}
					if (!flag2)
					{
						DPGJIJGOCIC.NFIDPOMCNLP("[LoadingEnv] dropping " + loadingEnvironmentRegistryEntry.envId + ", bundles no longer cached");
						EEIBKLDNBAP.OBCODEHLMLF("bundles no longer cached");
						loadingEnvironmentRegistryData.entries.RemoveAt(i);
						i--;
						flag = true;
					}
					else if (EEIBKLDNBAP.IFNENCAIEDM(loadingEnvironmentRegistryEntry, MBFMFPCLDFH))
					{
						DPGJIJGOCIC.NFIDPOMCNLP("[LoadingEnv] skipping " + loadingEnvironmentRegistryEntry.envId + " this time, its scene bundle is currently loaded");
						EEIBKLDNBAP.PMCELMLNPML = true;
					}
					else
					{
						list.Add(loadingEnvironmentRegistryEntry);
					}
				}
				IL_130:;
			}
			if (flag)
			{
				EEIBKLDNBAP.LPCBDEBKAIM();
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
		if (list.Count == 0)
		{
			return null;
		}
		return list[UnityEngine.Random.Range(0, list.Count)];
	}

	// Token: 0x06005700 RID: 22272 RVA: 0x0026CAB8 File Offset: 0x0026ACB8
	private static bool IIIGPMKABNG(LoadingEnvironmentRegistryEntry FOEEIJFHMGG)
	{
		if (FOEEIJFHMGG == null || FOEEIJFHMGG.chainFiles == null || FOEEIJFHMGG.chainFiles.Count == 0 || FOEEIJFHMGG.chainFiles.Count != FOEEIJFHMGG.chainNames.Count)
		{
			return false;
		}
		for (int i = 0; i < FOEEIJFHMGG.chainFiles.Count; i++)
		{
			if (FOEEIJFHMGG.chainFiles[i] == null || FOEEIJFHMGG.chainFiles[i].Length == 0)
			{
				return false;
			}
		}
		return true;
	}

	// Token: 0x06005701 RID: 22273 RVA: 0x0026CB34 File Offset: 0x0026AD34
	public static bool PFJGDBPAEBH(LoadingEnvironmentRegistryEntry FOEEIJFHMGG, List<string> MBFMFPCLDFH)
	{
		bool result;
		try
		{
			result = (FOEEIJFHMGG != null && EEIBKLDNBAP.JCKIPPJKKLH(FOEEIJFHMGG, MBFMFPCLDFH));
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
			result = false;
		}
		return result;
	}

	// Token: 0x06005702 RID: 22274 RVA: 0x0026CB6C File Offset: 0x0026AD6C
	private static string PJDNDMHJMEG(string EPKFFALJDEA, string NHPBLOEGIMM, string DJOKMJDNHIG, string LEPCBMINAOM)
	{
		string text = DJOKMJDNHIG;
		int num = text.IndexOf('?');
		if (num >= 0)
		{
			text = text.Substring(0, num);
		}
		int num2 = text.LastIndexOf('/');
		if (num2 >= 0)
		{
			text = text.Substring(num2 + 1);
		}
		List<string> list = new List<string>();
		list.Add(Path.GetFileNameWithoutExtension(text));
		list.Add(text);
		list.Add(NHPBLOEGIMM);
		for (int i = 0; i < list.Count; i++)
		{
			if (list[i] != null && list[i].Length != 0)
			{
				string text2 = Path.Combine(Path.Combine(Path.Combine(EPKFFALJDEA, list[i]), LEPCBMINAOM), "__data");
				if (File.Exists(text2))
				{
					return text2;
				}
			}
		}
		return null;
	}

	// Token: 0x06005703 RID: 22275 RVA: 0x0026CC24 File Offset: 0x0026AE24
	private static string EFAKAHEOEOA(LoadingEnvironmentRegistryEntry FOEEIJFHMGG, int GLLDFILNCKH)
	{
		return string.Concat(new string[]
		{
			FOEEIJFHMGG.envId,
			": ",
			FOEEIJFHMGG.chainNames[GLLDFILNCKH],
			" (",
			FOEEIJFHMGG.chainHashes[GLLDFILNCKH],
			") is not in the disk cache"
		});
	}

	// Token: 0x06005704 RID: 22276 RVA: 0x0026CC7C File Offset: 0x0026AE7C
	public static bool PNHLBGBGFIG(BNFCLKNDBLO CIBKELALAHF)
	{
		bool result;
		try
		{
			if (CIBKELALAHF == null)
			{
				result = false;
			}
			else
			{
				LoadingEnvironmentRegistryData loadingEnvironmentRegistryData = EEIBKLDNBAP.FMIJIKAKJFH();
				if (loadingEnvironmentRegistryData.entries.Count == 0)
				{
					result = false;
				}
				else
				{
					LoadingEnvironmentRegistryEntry loadingEnvironmentRegistryEntry = loadingEnvironmentRegistryData.entries[0];
					if (loadingEnvironmentRegistryEntry.bundleName != CIBKELALAHF.CIEHGJMAFKH || loadingEnvironmentRegistryEntry.envId != CIBKELALAHF.IBFLNCMCKAL)
					{
						result = false;
					}
					else if (loadingEnvironmentRegistryEntry.ambientDrift != (CIBKELALAHF.CGBHBJPLKIM != null))
					{
						result = false;
					}
					else if (loadingEnvironmentRegistryEntry.layersSystemVersion != CIBKELALAHF.FPJPHNLANPG)
					{
						result = false;
					}
					else if (loadingEnvironmentRegistryEntry.envPos != (int)CIBKELALAHF.LDECHKECBHB || loadingEnvironmentRegistryEntry.envMove != (int)CIBKELALAHF.EHPIMACBDLM || loadingEnvironmentRegistryEntry.envPosVertical != (int)CIBKELALAHF.ONNHAPFMDEN || loadingEnvironmentRegistryEntry.envMoveVertical != (int)CIBKELALAHF.JKAHANJANEI)
					{
						result = false;
					}
					else if (!EEIBKLDNBAP.EANAGAOJMCE(loadingEnvironmentRegistryEntry.layersShow, CIBKELALAHF.PIMEHAPFCHC) || !EEIBKLDNBAP.EANAGAOJMCE(loadingEnvironmentRegistryEntry.layersHide, CIBKELALAHF.HPFHJEAFIHI))
					{
						result = false;
					}
					else
					{
						result = true;
					}
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
			result = false;
		}
		return result;
	}

	// Token: 0x06005705 RID: 22277 RVA: 0x0026CD98 File Offset: 0x0026AF98
	public static void COOMLGKAOKF()
	{
		try
		{
			if (EEIBKLDNBAP.DOMBEHHFHOB(EEIBKLDNBAP.FMIJIKAKJFH()))
			{
				EEIBKLDNBAP.LPCBDEBKAIM();
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x06005706 RID: 22278 RVA: 0x0026CDD0 File Offset: 0x0026AFD0
	public static bool IMMPFEDIAPG()
	{
		bool result;
		try
		{
			if (!EEIBKLDNBAP.ALFGPLALKCN())
			{
				result = false;
			}
			else
			{
				result = EEIBKLDNBAP.BGANJNLKPDO(EEIBKLDNBAP.FMIJIKAKJFH().entries[0], null);
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
			result = false;
		}
		return result;
	}

	// Token: 0x06005707 RID: 22279 RVA: 0x0026CE1C File Offset: 0x0026B01C
	private static bool AACJIDADOAG(LoadingEnvironmentRegistryEntry FOEEIJFHMGG)
	{
		bool result;
		try
		{
			if (!AssetBundleManager.ManifestInitialized(FOEEIJFHMGG.folderIndex))
			{
				result = false;
			}
			else
			{
				List<string> list = new List<string>();
				List<Hash128> list2 = new List<Hash128>();
				List<string> list3 = new List<string>();
				if (!EEIBKLDNBAP.GBGIOFODCEE(FOEEIJFHMGG.bundleName, FOEEIJFHMGG.folderIndex, list, list2, list3))
				{
					result = false;
				}
				else
				{
					bool flag = list.Count == FOEEIJFHMGG.chainNames.Count;
					int num = 0;
					while (flag && num < list.Count)
					{
						if (!list[num].Equals(FOEEIJFHMGG.chainNames[num]) || !list2[num].ToString().Equals(FOEEIJFHMGG.chainHashes[num]) || !list3[num].Equals(FOEEIJFHMGG.chainUrls[num]))
						{
							flag = false;
						}
						num++;
					}
					if (flag)
					{
						result = false;
					}
					else
					{
						DPGJIJGOCIC.NFIDPOMCNLP("[LoadingEnv] chain of " + FOEEIJFHMGG.envId + " refreshed from the folder manifest");
						EEIBKLDNBAP.EKEBKAPNECK(FOEEIJFHMGG, list, list2, list3);
						EEIBKLDNBAP.IOBOBFICMDD(FOEEIJFHMGG);
						result = true;
					}
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
			result = false;
		}
		return result;
	}

	// Token: 0x06005708 RID: 22280 RVA: 0x0026CF60 File Offset: 0x0026B160
	private static void LPCBDEBKAIM()
	{
		try
		{
			PlayerPrefs.SetString("lsenvreg", JsonUtility.ToJson(EEIBKLDNBAP.FMIJIKAKJFH()));
			PlayerPrefs.Save();
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x06005709 RID: 22281 RVA: 0x0026CFA0 File Offset: 0x0026B1A0
	public static bool PKPDLCOKNMI()
	{
		bool result;
		try
		{
			if (!KDCJJBLGCBH.EHBBFMCILPC.FACIFBONANM())
			{
				result = false;
			}
			else
			{
				bool flag = KDCJJBLGCBH.EHBBFMCILPC.AMHJKMPIPGK();
				if (flag)
				{
					if (EEIBKLDNBAP.OCNPLOOGPCN() > 0)
					{
						DPGJIJGOCIC.NFIDPOMCNLP("[LoadingEnv] feature disabled by balance, registry cleared");
						EEIBKLDNBAP.OBCODEHLMLF("feature disabled by balance");
						EEIBKLDNBAP.IJHHMHAEKKE();
					}
					LoadingEnvironmentManager.DestroyIfAlive();
				}
				result = flag;
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
			result = false;
		}
		return result;
	}

	// Token: 0x0600570A RID: 22282 RVA: 0x0026D010 File Offset: 0x0026B210
	private static bool EEMFIBMFDEK(LoadingEnvironmentRegistryEntry FOEEIJFHMGG)
	{
		bool result;
		try
		{
			if (!Caching.ready)
			{
				result = true;
			}
			else
			{
				string path = Caching.currentCacheForWriting.path;
				result = (path != null && path.Equals(FOEEIJFHMGG.cacheRoot));
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
			result = true;
		}
		return result;
	}

	// Token: 0x0600570B RID: 22283 RVA: 0x0026D068 File Offset: 0x0026B268
	private static bool DOMBEHHFHOB(LoadingEnvironmentRegistryData KGMALOGFPPL)
	{
		if (!PlayerPrefs.HasKey("lsenvattempt"))
		{
			return false;
		}
		string @string = PlayerPrefs.GetString("lsenvattempt", "");
		PlayerPrefs.DeleteKey("lsenvattempt");
		bool result = false;
		for (int i = 0; i < KGMALOGFPPL.entries.Count; i++)
		{
			if (KGMALOGFPPL.entries[i] != null && KGMALOGFPPL.entries[i].GAFDFOANCFG().Equals(@string))
			{
				KGMALOGFPPL.entries[i].uncleanExits++;
				result = true;
				DPGJIJGOCIC.ADFCDFHBDAF(string.Concat(new string[]
				{
					"[LoadingEnv] previous run ended uncleanly with ",
					KGMALOGFPPL.entries[i].envId,
					" up (",
					KGMALOGFPPL.entries[i].uncleanExits.ToString(),
					"/",
					1.ToString(),
					")"
				}));
				if (KGMALOGFPPL.entries[i].uncleanExits >= 1)
				{
					KGMALOGFPPL.active = false;
					KGMALOGFPPL.crashParked = true;
					DPGJIJGOCIC.ADFCDFHBDAF("[LoadingEnv] stored theme parked after the unclean exit");
				}
			}
		}
		return result;
	}

	// Token: 0x0600570C RID: 22284 RVA: 0x0026D19C File Offset: 0x0026B39C
	private static void IOBOBFICMDD(LoadingEnvironmentRegistryEntry FOEEIJFHMGG)
	{
		FOEEIJFHMGG.cacheRoot = "";
		FOEEIJFHMGG.chainFiles = new List<string>();
		try
		{
			if (!Caching.ready)
			{
				DPGJIJGOCIC.NFIDPOMCNLP("[LoadingEnv] cache files of " + FOEEIJFHMGG.envId + " not recorded: caching system not ready");
			}
			else
			{
				string path = Caching.currentCacheForWriting.path;
				if (path == null || path.Length == 0 || !Directory.Exists(path))
				{
					DPGJIJGOCIC.NFIDPOMCNLP("[LoadingEnv] cache files of " + FOEEIJFHMGG.envId + " not recorded: no cache root");
				}
				else
				{
					List<string> list = new List<string>();
					for (int i = 0; i < FOEEIJFHMGG.chainNames.Count; i++)
					{
						string text = EEIBKLDNBAP.PJDNDMHJMEG(path, FOEEIJFHMGG.chainNames[i], FOEEIJFHMGG.chainUrls[i], FOEEIJFHMGG.chainHashes[i]);
						if (text == null)
						{
							DPGJIJGOCIC.NFIDPOMCNLP("[LoadingEnv] cache files of " + FOEEIJFHMGG.envId + " not recorded: no cache folder for " + FOEEIJFHMGG.chainNames[i]);
							return;
						}
						list.Add(text);
					}
					FOEEIJFHMGG.cacheRoot = path;
					FOEEIJFHMGG.chainFiles = list;
					FOEEIJFHMGG.directFailures = 0;
					DPGJIJGOCIC.NFIDPOMCNLP("[LoadingEnv] cache files of " + FOEEIJFHMGG.envId + " recorded under " + path);
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
			FOEEIJFHMGG.cacheRoot = "";
			FOEEIJFHMGG.chainFiles = new List<string>();
		}
	}

	// Token: 0x0600570D RID: 22285 RVA: 0x0026D30C File Offset: 0x0026B50C
	private static bool JKHDOHBLFJF(LoadingEnvironmentRegistryEntry FOEEIJFHMGG, List<string> MBFMFPCLDFH)
	{
		bool result;
		try
		{
			if (!EEIBKLDNBAP.IIIGPMKABNG(FOEEIJFHMGG))
			{
				result = false;
			}
			else
			{
				for (int i = 0; i < FOEEIJFHMGG.chainFiles.Count; i++)
				{
					if ((MBFMFPCLDFH == null || !MBFMFPCLDFH.Contains(FOEEIJFHMGG.chainNames[i])) && !File.Exists(FOEEIJFHMGG.chainFiles[i]))
					{
						DPGJIJGOCIC.NFIDPOMCNLP("[LoadingEnv] cache file of " + FOEEIJFHMGG.chainNames[i] + " missing: " + FOEEIJFHMGG.chainFiles[i]);
						return false;
					}
				}
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

	// Token: 0x0600570E RID: 22286 RVA: 0x0026D3B4 File Offset: 0x0026B5B4
	public static void JFMGICMMFBC()
	{
		try
		{
			if (PlayerPrefs.HasKey("lsenvdrop"))
			{
				PlayerPrefs.DeleteKey("lsenvdrop");
				PlayerPrefs.Save();
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x0600570F RID: 22287 RVA: 0x0026D3F8 File Offset: 0x0026B5F8
	private static bool BBLLENOPBCF(Transform FEJOADBPKMC)
	{
		if (!FEJOADBPKMC.gameObject.activeSelf)
		{
			return false;
		}
		if (FEJOADBPKMC.gameObject.name.ToLowerInvariant().Contains("layervideo"))
		{
			return true;
		}
		for (int i = 0; i < FEJOADBPKMC.childCount; i++)
		{
			if (EEIBKLDNBAP.BBLLENOPBCF(FEJOADBPKMC.GetChild(i)))
			{
				return true;
			}
		}
		return false;
	}

	// Token: 0x06005710 RID: 22288 RVA: 0x0026D454 File Offset: 0x0026B654
	public static bool BGANJNLKPDO(LoadingEnvironmentRegistryEntry FOEEIJFHMGG, List<string> MBFMFPCLDFH)
	{
		return EEIBKLDNBAP.FJKCFFJKNND(FOEEIJFHMGG) && EEIBKLDNBAP.JKHDOHBLFJF(FOEEIJFHMGG, MBFMFPCLDFH);
	}

	// Token: 0x06005711 RID: 22289 RVA: 0x0026D468 File Offset: 0x0026B668
	public static void HJALGLFGBCP()
	{
		try
		{
			if (!KHPGPLAMAIN.EJCNHEBIOJF())
			{
				EEIBKLDNBAP.JENCHCDPCLB();
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x06005712 RID: 22290 RVA: 0x0026D49C File Offset: 0x0026B69C
	public static void EDDOLOJALBG(LoadingEnvironmentRegistryEntry FOEEIJFHMGG)
	{
		try
		{
			if (FOEEIJFHMGG != null && PlayerPrefs.HasKey("lsenvattempt"))
			{
				if (PlayerPrefs.GetString("lsenvattempt", "").Equals(FOEEIJFHMGG.GAFDFOANCFG()))
				{
					EEIBKLDNBAP.EDDOLOJALBG();
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x06005713 RID: 22291 RVA: 0x0026D4F8 File Offset: 0x0026B6F8
	public static void ONMPPJOGCDO(bool JNHHHLGIHIO)
	{
		try
		{
			int num = JNHHHLGIHIO ? 1 : 0;
			if (num != PlayerPrefs.GetInt("lsenvlite", 0))
			{
				PlayerPrefs.SetInt("lsenvlite", num);
				PlayerPrefs.Save();
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x06005714 RID: 22292 RVA: 0x0026D548 File Offset: 0x0026B748
	public static bool FJKCFFJKNND(LoadingEnvironmentRegistryEntry FOEEIJFHMGG)
	{
		return FOEEIJFHMGG != null && FOEEIJFHMGG.directFailures <= 0 && EEIBKLDNBAP.IIIGPMKABNG(FOEEIJFHMGG);
	}

	// Token: 0x06005715 RID: 22293 RVA: 0x0026D560 File Offset: 0x0026B760
	public static bool FPAKKCDIHEN()
	{
		return EEIBKLDNBAP.PMCELMLNPML;
	}

	// Token: 0x06005716 RID: 22294 RVA: 0x0026D568 File Offset: 0x0026B768
	public static void LNMOJPLHION(LoadingEnvironmentRegistryEntry FOEEIJFHMGG)
	{
		try
		{
			if (FOEEIJFHMGG != null)
			{
				if (FOEEIJFHMGG.directFailures <= 0 || !EEIBKLDNBAP.JKHDOHBLFJF(FOEEIJFHMGG, null) || !EEIBKLDNBAP.EEMFIBMFDEK(FOEEIJFHMGG))
				{
					if (!EEIBKLDNBAP.FJKCFFJKNND(FOEEIJFHMGG) || !EEIBKLDNBAP.JKHDOHBLFJF(FOEEIJFHMGG, null) || !EEIBKLDNBAP.EEMFIBMFDEK(FOEEIJFHMGG))
					{
						EEIBKLDNBAP.IOBOBFICMDD(FOEEIJFHMGG);
						if (EEIBKLDNBAP.FJKCFFJKNND(FOEEIJFHMGG))
						{
							EEIBKLDNBAP.LPCBDEBKAIM();
							DPGJIJGOCIC.NFIDPOMCNLP("[LoadingEnv] cache files of " + FOEEIJFHMGG.envId + " recorded for the next boot");
						}
					}
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x06005717 RID: 22295 RVA: 0x0026D5F8 File Offset: 0x0026B7F8
	private static bool EANAGAOJMCE(List<string> MIDLEBAGDMN, List<string> DFNFPEMFNPN)
	{
		int num = (MIDLEBAGDMN == null) ? 0 : MIDLEBAGDMN.Count;
		int num2 = (DFNFPEMFNPN == null) ? 0 : DFNFPEMFNPN.Count;
		if (num != num2)
		{
			return false;
		}
		for (int i = 0; i < num; i++)
		{
			if (MIDLEBAGDMN[i] != DFNFPEMFNPN[i])
			{
				return false;
			}
		}
		return true;
	}

	// Token: 0x06005718 RID: 22296 RVA: 0x0026D649 File Offset: 0x0026B849
	public static void ACPMEPNBPLL()
	{
		EEIBKLDNBAP.JFMGICMMFBC();
	}

	// Token: 0x06005719 RID: 22297 RVA: 0x0026D650 File Offset: 0x0026B850
	public static bool ALFGPLALKCN()
	{
		LoadingEnvironmentRegistryData loadingEnvironmentRegistryData = EEIBKLDNBAP.FMIJIKAKJFH();
		return loadingEnvironmentRegistryData.entries.Count > 0 && loadingEnvironmentRegistryData.active;
	}

	// Token: 0x0600571A RID: 22298 RVA: 0x0026D67C File Offset: 0x0026B87C
	public static void MJDIDOBOOEN()
	{
		try
		{
			LoadingEnvironmentRegistryData loadingEnvironmentRegistryData = EEIBKLDNBAP.FMIJIKAKJFH();
			if (loadingEnvironmentRegistryData.liteParkNotice)
			{
				loadingEnvironmentRegistryData.liteParkNotice = false;
				EEIBKLDNBAP.LPCBDEBKAIM();
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x0600571B RID: 22299 RVA: 0x0026D6C0 File Offset: 0x0026B8C0
	private static LoadingEnvironmentRegistryData FMIJIKAKJFH()
	{
		if (EEIBKLDNBAP.GDAFFANBJED != null)
		{
			return EEIBKLDNBAP.GDAFFANBJED;
		}
		EEIBKLDNBAP.GDAFFANBJED = new LoadingEnvironmentRegistryData();
		EEIBKLDNBAP.GDAFFANBJED.version = 3;
		try
		{
			if (PlayerPrefs.HasKey("lsenvreg"))
			{
				string @string = PlayerPrefs.GetString("lsenvreg", "");
				if (@string.Length > 0)
				{
					LoadingEnvironmentRegistryData loadingEnvironmentRegistryData = JsonUtility.FromJson<LoadingEnvironmentRegistryData>(@string);
					if (loadingEnvironmentRegistryData != null && loadingEnvironmentRegistryData.version == 2 && loadingEnvironmentRegistryData.entries != null)
					{
						loadingEnvironmentRegistryData.version = 3;
					}
					if (loadingEnvironmentRegistryData != null && loadingEnvironmentRegistryData.version == 3 && loadingEnvironmentRegistryData.entries != null)
					{
						EEIBKLDNBAP.GDAFFANBJED = loadingEnvironmentRegistryData;
					}
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
		return EEIBKLDNBAP.GDAFFANBJED;
	}

	// Token: 0x0600571C RID: 22300 RVA: 0x0026D770 File Offset: 0x0026B970
	private static bool IFNENCAIEDM(LoadingEnvironmentRegistryEntry FOEEIJFHMGG, List<string> MBFMFPCLDFH)
	{
		return MBFMFPCLDFH != null && FOEEIJFHMGG.chainNames.Count != 0 && MBFMFPCLDFH.Contains(FOEEIJFHMGG.chainNames[FOEEIJFHMGG.chainNames.Count - 1]);
	}

	// Token: 0x0600571D RID: 22301 RVA: 0x0026D7A4 File Offset: 0x0026B9A4
	public static HJEEGEOCEGI NAGNMBGLLEI(BNFCLKNDBLO CIBKELALAHF, StoryEnvironmentManager JBPHJNDDOMA, StoryEnvironmentManager HKEFLHBANKP)
	{
		HJEEGEOCEGI result;
		try
		{
			if (CIBKELALAHF == null || null == JBPHJNDDOMA)
			{
				result = HJEEGEOCEGI.environmentMissing;
			}
			else if (EEIBKLDNBAP.PKPDLCOKNMI())
			{
				result = HJEEGEOCEGI.disabled;
			}
			else if (EEIBKLDNBAP.BBLLENOPBCF(JBPHJNDDOMA.transform) || (null != HKEFLHBANKP && EEIBKLDNBAP.BBLLENOPBCF(HKEFLHBANKP.transform)))
			{
				DPGJIJGOCIC.NFIDPOMCNLP("[LoadingEnv] not usable: " + JBPHJNDDOMA.gameObject.name + " carries an active video layer");
				result = HJEEGEOCEGI.videoLayer;
			}
			else
			{
				int fjfepnkbell = CIBKELALAHF.FJFEPNKBELL;
				List<string> list = new List<string>();
				List<Hash128> eddkhibdhkk = new List<Hash128>();
				List<string> gnhpjecjjbf = new List<string>();
				if (!EEIBKLDNBAP.GBGIOFODCEE(CIBKELALAHF.CIEHGJMAFKH, fjfepnkbell, list, eddkhibdhkk, gnhpjecjjbf))
				{
					DPGJIJGOCIC.ADFCDFHBDAF("[LoadingEnv] not usable: cache chain of " + CIBKELALAHF.CIEHGJMAFKH + " not resolvable");
					result = HJEEGEOCEGI.notResolvable;
				}
				else
				{
					LoadingEnvironmentRegistryEntry loadingEnvironmentRegistryEntry = new LoadingEnvironmentRegistryEntry();
					loadingEnvironmentRegistryEntry.bundleName = CIBKELALAHF.CIEHGJMAFKH;
					loadingEnvironmentRegistryEntry.folderIndex = fjfepnkbell;
					loadingEnvironmentRegistryEntry.sceneName = OMIMIKMIMFE.JGLEMENLPJP(HEIDEJOPKAA.SceneStoryAssetPack, CIBKELALAHF.OCPJHLCBIPB(), CIBKELALAHF.FECFDDGCPGB(), -1);
					loadingEnvironmentRegistryEntry.envId = JBPHJNDDOMA.gameObject.name;
					EEIBKLDNBAP.EKEBKAPNECK(loadingEnvironmentRegistryEntry, list, eddkhibdhkk, gnhpjecjjbf);
					EEIBKLDNBAP.IOBOBFICMDD(loadingEnvironmentRegistryEntry);
					for (int i = 0; i < CIBKELALAHF.PIMEHAPFCHC.Count; i++)
					{
						loadingEnvironmentRegistryEntry.layersShow.Add(CIBKELALAHF.PIMEHAPFCHC[i]);
					}
					for (int j = 0; j < CIBKELALAHF.HPFHJEAFIHI.Count; j++)
					{
						loadingEnvironmentRegistryEntry.layersHide.Add(CIBKELALAHF.HPFHJEAFIHI[j]);
					}
					loadingEnvironmentRegistryEntry.layersSystemVersion = CIBKELALAHF.FPJPHNLANPG;
					loadingEnvironmentRegistryEntry.envPos = (int)CIBKELALAHF.LDECHKECBHB;
					loadingEnvironmentRegistryEntry.envMove = (int)CIBKELALAHF.EHPIMACBDLM;
					loadingEnvironmentRegistryEntry.envPosVertical = (int)CIBKELALAHF.ONNHAPFMDEN;
					loadingEnvironmentRegistryEntry.envMoveVertical = (int)CIBKELALAHF.JKAHANJANEI;
					loadingEnvironmentRegistryEntry.ambientDrift = (CIBKELALAHF.CGBHBJPLKIM != null);
					loadingEnvironmentRegistryEntry.uncleanExits = 0;
					if (!loadingEnvironmentRegistryEntry.INEKFCLBCAB())
					{
						result = HJEEGEOCEGI.notResolvable;
					}
					else
					{
						LoadingEnvironmentRegistryData loadingEnvironmentRegistryData = EEIBKLDNBAP.FMIJIKAKJFH();
						loadingEnvironmentRegistryData.entries.Clear();
						loadingEnvironmentRegistryData.entries.Add(loadingEnvironmentRegistryEntry);
						loadingEnvironmentRegistryData.active = true;
						loadingEnvironmentRegistryData.crashParked = false;
						loadingEnvironmentRegistryData.liteParked = false;
						loadingEnvironmentRegistryData.liteParkNotice = false;
						EEIBKLDNBAP.LPCBDEBKAIM();
						EEIBKLDNBAP.ACPMEPNBPLL();
						DPGJIJGOCIC.NFIDPOMCNLP(string.Concat(new string[]
						{
							"[LoadingEnv] loading theme set: ",
							loadingEnvironmentRegistryEntry.envId,
							" (",
							loadingEnvironmentRegistryEntry.bundleName,
							", ",
							list.Count.ToString(),
							" bundles: ",
							EEIBKLDNBAP.LHGHKEIHOHD(list),
							")"
						}));
						result = HJEEGEOCEGI.set;
					}
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
			result = HJEEGEOCEGI.notResolvable;
		}
		return result;
	}

	// Token: 0x0600571E RID: 22302 RVA: 0x0026DA6C File Offset: 0x0026BC6C
	public static bool OJIHFHOLPCA()
	{
		bool result;
		try
		{
			LoadingEnvironmentRegistryData loadingEnvironmentRegistryData = EEIBKLDNBAP.FMIJIKAKJFH();
			if (!loadingEnvironmentRegistryData.crashParked)
			{
				result = false;
			}
			else
			{
				loadingEnvironmentRegistryData.crashParked = false;
				EEIBKLDNBAP.LPCBDEBKAIM();
				result = (loadingEnvironmentRegistryData.entries.Count > 0);
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
			result = false;
		}
		return result;
	}

	// Token: 0x0600571F RID: 22303 RVA: 0x0026DAC4 File Offset: 0x0026BCC4
	public static void IJHHMHAEKKE()
	{
		try
		{
			EEIBKLDNBAP.GDAFFANBJED = new LoadingEnvironmentRegistryData();
			EEIBKLDNBAP.GDAFFANBJED.version = 3;
			PlayerPrefs.DeleteKey("lsenvreg");
			PlayerPrefs.DeleteKey("lsenvattempt");
			PlayerPrefs.Save();
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x06005720 RID: 22304 RVA: 0x0026DB18 File Offset: 0x0026BD18
	public static bool IOJCHHGBOJB()
	{
		bool result;
		try
		{
			if (!KHPGPLAMAIN.EJCNHEBIOJF())
			{
				result = false;
			}
			else
			{
				EEIBKLDNBAP.OFPNANLFBMK("lite game mode on");
				LoadingEnvironmentManager.DestroyIfAlive();
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

	// Token: 0x06005721 RID: 22305 RVA: 0x0026DB60 File Offset: 0x0026BD60
	public static bool EKDKPPOGMGP()
	{
		bool result;
		try
		{
			LoadingEnvironmentRegistryData loadingEnvironmentRegistryData = EEIBKLDNBAP.FMIJIKAKJFH();
			result = (loadingEnvironmentRegistryData.crashParked && loadingEnvironmentRegistryData.entries.Count > 0);
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
			result = false;
		}
		return result;
	}

	// Token: 0x06005722 RID: 22306 RVA: 0x0026DBAC File Offset: 0x0026BDAC
	private static string LHGHKEIHOHD(List<string> PNMDDLGLLEJ)
	{
		string text = "";
		for (int i = 0; i < PNMDDLGLLEJ.Count; i++)
		{
			if (i > 0)
			{
				text += ", ";
			}
			text += PNMDDLGLLEJ[i];
		}
		return text;
	}

	// Token: 0x06005723 RID: 22307 RVA: 0x0026DBF0 File Offset: 0x0026BDF0
	private static void EKEBKAPNECK(LoadingEnvironmentRegistryEntry FOEEIJFHMGG, List<string> PNMDDLGLLEJ, List<Hash128> EDDKHIBDHKK, List<string> GNHPJECJJBF)
	{
		FOEEIJFHMGG.chainNames = new List<string>();
		FOEEIJFHMGG.chainHashes = new List<string>();
		FOEEIJFHMGG.chainUrls = new List<string>();
		for (int i = 0; i < PNMDDLGLLEJ.Count; i++)
		{
			FOEEIJFHMGG.chainNames.Add(PNMDDLGLLEJ[i]);
			FOEEIJFHMGG.chainHashes.Add(EDDKHIBDHKK[i].ToString());
			FOEEIJFHMGG.chainUrls.Add(GNHPJECJJBF[i]);
		}
	}

	// Token: 0x06005724 RID: 22308 RVA: 0x0026DC74 File Offset: 0x0026BE74
	public static void AALGIKKJJIC(LoadingEnvironmentRegistryEntry FOEEIJFHMGG)
	{
		try
		{
			if (FOEEIJFHMGG != null)
			{
				FOEEIJFHMGG.directFailures++;
				EEIBKLDNBAP.LPCBDEBKAIM();
				DPGJIJGOCIC.ADFCDFHBDAF(string.Concat(new string[]
				{
					"[LoadingEnv] direct cache files of ",
					FOEEIJFHMGG.envId,
					" struck out (",
					FOEEIJFHMGG.directFailures.ToString(),
					"), cache-api path until re-described"
				}));
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x06005725 RID: 22309 RVA: 0x0026DCF4 File Offset: 0x0026BEF4
	private static bool GBGIOFODCEE(string NHPBLOEGIMM, int LHBILKALHBJ, List<string> PNMDDLGLLEJ, List<Hash128> EDDKHIBDHKK, List<string> GNHPJECJJBF)
	{
		if (LHBILKALHBJ < 0 || LHBILKALHBJ >= 76)
		{
			return false;
		}
		LNDOOJOFFOM lndoojoffom = (LNDOOJOFFOM)LHBILKALHBJ;
		string hdnmhlgbcll = lndoojoffom.ToString();
		return AssetBundleManager.DescribeCachedAssetBundleChain(NHPBLOEGIMM, hdnmhlgbcll, LHBILKALHBJ, false, PNMDDLGLLEJ, EDDKHIBDHKK, GNHPJECJJBF);
	}

	// Token: 0x06005726 RID: 22310 RVA: 0x0026DD2C File Offset: 0x0026BF2C
	private static void OBCODEHLMLF(string IOEENLMAMNC)
	{
		try
		{
			PlayerPrefs.SetInt("lsenvdrop", 1);
			PlayerPrefs.Save();
			DPGJIJGOCIC.NFIDPOMCNLP("[LoadingEnv] theme dropped from this device: " + IOEENLMAMNC);
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x06005727 RID: 22311 RVA: 0x0026DD74 File Offset: 0x0026BF74
	public static bool HMOBOBAPNAJ()
	{
		bool result;
		try
		{
			result = (1 == PlayerPrefs.GetInt("lsenvlite", 0));
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
			result = false;
		}
		return result;
	}

	// Token: 0x06005728 RID: 22312 RVA: 0x0026DDAC File Offset: 0x0026BFAC
	public static bool GCJODEFFJPN()
	{
		return EEIBKLDNBAP.OCNPLOOGPCN() > 0;
	}

	// Token: 0x06005729 RID: 22313 RVA: 0x0026DDB6 File Offset: 0x0026BFB6
	public static int OCNPLOOGPCN()
	{
		return EEIBKLDNBAP.FMIJIKAKJFH().entries.Count;
	}

	// Token: 0x0600572A RID: 22314 RVA: 0x0026DDC8 File Offset: 0x0026BFC8
	private static bool JCKIPPJKKLH(LoadingEnvironmentRegistryEntry FOEEIJFHMGG, List<string> MBFMFPCLDFH)
	{
		if (!Caching.ready)
		{
			return false;
		}
		for (int i = 0; i < FOEEIJFHMGG.chainNames.Count; i++)
		{
			if (MBFMFPCLDFH == null || !MBFMFPCLDFH.Contains(FOEEIJFHMGG.chainNames[i]))
			{
				Hash128 hash = Hash128.Parse(FOEEIJFHMGG.chainHashes[i]);
				if (!hash.isValid)
				{
					return false;
				}
				if (!Caching.IsVersionCached(FOEEIJFHMGG.chainUrls[i], hash))
				{
					DPGJIJGOCIC.NFIDPOMCNLP("[LoadingEnv] " + EEIBKLDNBAP.EFAKAHEOEOA(FOEEIJFHMGG, i));
					return false;
				}
			}
		}
		return true;
	}

	// Token: 0x0600572B RID: 22315 RVA: 0x0026DE58 File Offset: 0x0026C058
	public static void EDDOLOJALBG()
	{
		try
		{
			if (PlayerPrefs.HasKey("lsenvattempt"))
			{
				string @string = PlayerPrefs.GetString("lsenvattempt", "");
				PlayerPrefs.DeleteKey("lsenvattempt");
				LoadingEnvironmentRegistryData loadingEnvironmentRegistryData = EEIBKLDNBAP.FMIJIKAKJFH();
				bool flag = false;
				for (int i = 0; i < loadingEnvironmentRegistryData.entries.Count; i++)
				{
					if (loadingEnvironmentRegistryData.entries[i] != null && loadingEnvironmentRegistryData.entries[i].GAFDFOANCFG().Equals(@string) && loadingEnvironmentRegistryData.entries[i].uncleanExits != 0)
					{
						loadingEnvironmentRegistryData.entries[i].uncleanExits = 0;
						flag = true;
					}
				}
				if (flag)
				{
					EEIBKLDNBAP.LPCBDEBKAIM();
				}
				else
				{
					PlayerPrefs.Save();
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x0600572C RID: 22316 RVA: 0x0026DF24 File Offset: 0x0026C124
	public static void KGLELEEIDPF(LoadingEnvironmentRegistryEntry FOEEIJFHMGG)
	{
		try
		{
			if (FOEEIJFHMGG != null)
			{
				PlayerPrefs.SetString("lsenvattempt", FOEEIJFHMGG.GAFDFOANCFG());
				PlayerPrefs.Save();
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x0600572D RID: 22317 RVA: 0x0026DF64 File Offset: 0x0026C164
	public static void JENCHCDPCLB()
	{
		try
		{
			LoadingEnvironmentRegistryData loadingEnvironmentRegistryData = EEIBKLDNBAP.FMIJIKAKJFH();
			if (loadingEnvironmentRegistryData.entries.Count != 0 && loadingEnvironmentRegistryData.liteParked)
			{
				loadingEnvironmentRegistryData.liteParked = false;
				loadingEnvironmentRegistryData.liteParkNotice = false;
				loadingEnvironmentRegistryData.active = true;
				loadingEnvironmentRegistryData.crashParked = false;
				EEIBKLDNBAP.LPCBDEBKAIM();
				AKLFPGMDKLA.EHBBFMCILPC.APLCOFLOAPA = 1;
				DPGJIJGOCIC.NFIDPOMCNLP("[LoadingEnv] full mode back, stored theme selected again");
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x0600572E RID: 22318 RVA: 0x0026DFE0 File Offset: 0x0026C1E0
	public static void BIHFLMJAILJ(bool KNNLCIBFDND)
	{
		try
		{
			LoadingEnvironmentRegistryData loadingEnvironmentRegistryData = EEIBKLDNBAP.FMIJIKAKJFH();
			if (loadingEnvironmentRegistryData.active != KNNLCIBFDND)
			{
				loadingEnvironmentRegistryData.active = KNNLCIBFDND;
				if (KNNLCIBFDND)
				{
					loadingEnvironmentRegistryData.crashParked = false;
					loadingEnvironmentRegistryData.liteParked = false;
					loadingEnvironmentRegistryData.liteParkNotice = false;
				}
				EEIBKLDNBAP.LPCBDEBKAIM();
				DPGJIJGOCIC.NFIDPOMCNLP("[LoadingEnv] " + (KNNLCIBFDND ? "stored theme selected" : "stored theme parked"));
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x0600572F RID: 22319 RVA: 0x0026E05C File Offset: 0x0026C25C
	public static bool PCJGFGDGIDM()
	{
		bool result;
		try
		{
			result = (1 == PlayerPrefs.GetInt("lsenvdrop", 0));
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
			result = false;
		}
		return result;
	}

	// Token: 0x06005730 RID: 22320 RVA: 0x0026E094 File Offset: 0x0026C294
	public static void NHKGIOOFKHM()
	{
		try
		{
			if (EEIBKLDNBAP.OCNPLOOGPCN() > 0)
			{
				DPGJIJGOCIC.NFIDPOMCNLP("[LoadingEnv] cache clean requested by the player, stored theme forgotten");
			}
			EEIBKLDNBAP.IJHHMHAEKKE();
			EEIBKLDNBAP.JFMGICMMFBC();
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x06005731 RID: 22321 RVA: 0x0026E0D8 File Offset: 0x0026C2D8
	public static bool FGJJOFMBKIJ()
	{
		bool result;
		try
		{
			if (!EEIBKLDNBAP.HMOBOBAPNAJ())
			{
				result = false;
			}
			else
			{
				EEIBKLDNBAP.OFPNANLFBMK("lite game mode flagged");
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

	// Token: 0x06005732 RID: 22322 RVA: 0x0026E11C File Offset: 0x0026C31C
	public static void FOHOCBHHOAP(LoadingEnvironmentRegistryEntry FOEEIJFHMGG)
	{
		try
		{
			if (FOEEIJFHMGG != null && Caching.ready)
			{
				for (int i = 0; i < FOEEIJFHMGG.chainNames.Count; i++)
				{
					Hash128 hash = Hash128.Parse(FOEEIJFHMGG.chainHashes[i]);
					if (hash.isValid)
					{
						Caching.MarkAsUsed(FOEEIJFHMGG.chainUrls[i], hash);
					}
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x0400185B RID: 6235
	private const string BDMKKMMKJHB = "lsenvreg";

	// Token: 0x0400185C RID: 6236
	private const string PGHFNNIHDKI = "lsenvattempt";

	// Token: 0x0400185D RID: 6237
	private const int JMBBNENAFPK = 3;

	// Token: 0x0400185E RID: 6238
	private const int KJLHCCEIODM = 1;

	// Token: 0x0400185F RID: 6239
	private const string KJEPDBDDOKF = "[LoadingEnv] ";

	// Token: 0x04001860 RID: 6240
	private static LoadingEnvironmentRegistryData GDAFFANBJED;

	// Token: 0x04001861 RID: 6241
	private const string EAJKIJDAFJB = "lsenvlite";

	// Token: 0x04001862 RID: 6242
	private static bool PMCELMLNPML;

	// Token: 0x04001863 RID: 6243
	private static bool HALKEBEDHEH;

	// Token: 0x04001864 RID: 6244
	private const bool CMGCEAOPOJJ = true;

	// Token: 0x04001865 RID: 6245
	private const string MKPCPFIKHLC = "__data";

	// Token: 0x04001866 RID: 6246
	private const string MINBGGPOHGC = "lsenvdrop";
}
