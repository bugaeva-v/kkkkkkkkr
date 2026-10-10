using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

// Token: 0x020001E1 RID: 481
public static class NIDOKPOOIHH
{
	// Token: 0x06003B9A RID: 15258 RVA: 0x0018B500 File Offset: 0x00189700
	private static void LPCBDEBKAIM(Dictionary<int, int> ILOPFGPCKBF)
	{
		StringBuilder stringBuilder = new StringBuilder();
		foreach (KeyValuePair<int, int> keyValuePair in ILOPFGPCKBF)
		{
			if (stringBuilder.Length > 0)
			{
				stringBuilder.Append(',');
			}
			stringBuilder.Append(keyValuePair.Key);
			stringBuilder.Append(':');
			stringBuilder.Append(keyValuePair.Value);
		}
		PlayerPrefs.SetString("lnls", stringBuilder.ToString());
		PlayerPrefs.Save();
	}

	// Token: 0x06003B9B RID: 15259 RVA: 0x0018B59C File Offset: 0x0018979C
	public static void EPJKDCDOEMM()
	{
		NIDOKPOOIHH.GNNOJPJPJCL = null;
		PlayerPrefs.DeleteKey("lnls");
	}

	// Token: 0x06003B9C RID: 15260 RVA: 0x0018B5B0 File Offset: 0x001897B0
	public static int PIMJNEOMAOG(int PLKMJJIIJNO, PLFDAJJHMKO LFLOCKNKAKC, int OLKMHHNMDLP)
	{
		int num = 0;
		try
		{
			if (LFLOCKNKAKC == null || null == AssetsManager.EHBBFMCILPC || null == AssetsManager.EHBBFMCILPC.lobbyDataAsset)
			{
				return 0;
			}
			FJLGCKNOJMJ fjlgcknojmj = AssetsManager.EHBBFMCILPC.lobbyDataAsset.MFMJHIFAOHE().ELDKHHGLNBK(PLKMJJIIJNO);
			if (fjlgcknojmj == null)
			{
				return 0;
			}
			for (int i = 0; i < fjlgcknojmj.OINAAMKLNLO.Count; i++)
			{
				if (SceneStoryManager.LoungeCharacterInActiveWardrobe(fjlgcknojmj.OINAAMKLNLO[i], LFLOCKNKAKC))
				{
					for (int j = 0; j < fjlgcknojmj.OINAAMKLNLO[i].KKEENPEFFBJ.Count; j++)
					{
						if (NIDOKPOOIHH.HFEBFOJPMDB(fjlgcknojmj.OINAAMKLNLO[i].KKEENPEFFBJ[j], LFLOCKNKAKC, OLKMHHNMDLP))
						{
							num++;
						}
					}
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
		return num;
	}

	// Token: 0x06003B9D RID: 15261 RVA: 0x0018B698 File Offset: 0x00189898
	public static void GMGPLOLADGB(int EHIJHIDBLII, int OLKMHHNMDLP)
	{
		try
		{
			Dictionary<int, int> dictionary = NIDOKPOOIHH.HLCOGPHDCKN();
			int num;
			if (!dictionary.TryGetValue(EHIJHIDBLII, out num) || num <= OLKMHHNMDLP)
			{
				dictionary[EHIJHIDBLII] = OLKMHHNMDLP;
				NIDOKPOOIHH.LPCBDEBKAIM(dictionary);
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x06003B9E RID: 15262 RVA: 0x0018B6E4 File Offset: 0x001898E4
	public static bool BFMOBNPFEOF(int EHIJHIDBLII, int OLKMHHNMDLP)
	{
		int num;
		return NIDOKPOOIHH.HLCOGPHDCKN().TryGetValue(EHIJHIDBLII, out num) && num >= OLKMHHNMDLP;
	}

	// Token: 0x06003B9F RID: 15263 RVA: 0x0018B70C File Offset: 0x0018990C
	private static bool HFEBFOJPMDB(ECJCFGAOPHJ FFACCDIEBIA, PLFDAJJHMKO LFLOCKNKAKC, int OLKMHHNMDLP)
	{
		return FFACCDIEBIA.HLEOLMIFCGI() && (FFACCDIEBIA.MNBBOAPGCMM <= 0 || !AppManager.EHBBFMCILPC.UnsupportedRevision(FFACCDIEBIA.MNBBOAPGCMM)) && (!FFACCDIEBIA.PPBPOPEEPDJ(AKLFPGMDKLA.EHBBFMCILPC.CDNGHFCPPEA()) || (FFACCDIEBIA.OBLBNLBFBNI >= 0 && AKLFPGMDKLA.EHBBFMCILPC.OKNDDBOOFPL(FFACCDIEBIA.OBLBNLBFBNI))) && LFLOCKNKAKC.DHONIOBOLEL.GGICIBLJIKI >= FFACCDIEBIA.PBGKGCHMHOP && (LFLOCKNKAKC.DHONIOBOLEL.GGICIBLJIKI != FFACCDIEBIA.PBGKGCHMHOP || OLKMHHNMDLP >= FFACCDIEBIA.CGKKPPEIFJH);
	}

	// Token: 0x06003BA0 RID: 15264 RVA: 0x0018B7A4 File Offset: 0x001899A4
	public static int DOCAFHDOEHE(int PLKMJJIIJNO, PLFDAJJHMKO LFLOCKNKAKC)
	{
		if (LFLOCKNKAKC == null)
		{
			return 0;
		}
		int num = LFLOCKNKAKC.DHONIOBOLEL.DDEDAHCFHJN();
		if (num <= 0)
		{
			return 0;
		}
		int num2 = NIDOKPOOIHH.PIMJNEOMAOG(PLKMJJIIJNO, LFLOCKNKAKC, num);
		int num3 = NIDOKPOOIHH.PIMJNEOMAOG(PLKMJJIIJNO, LFLOCKNKAKC, num - 1);
		return Mathf.Max(0, num2 - num3);
	}

	// Token: 0x06003BA1 RID: 15265 RVA: 0x0018B7E8 File Offset: 0x001899E8
	public static int ALLBOOMIFNM(int PLKMJJIIJNO, PLFDAJJHMKO LFLOCKNKAKC)
	{
		if (LFLOCKNKAKC == null)
		{
			return 0;
		}
		int num = LFLOCKNKAKC.DHONIOBOLEL.DDEDAHCFHJN();
		if (num <= 0)
		{
			return 0;
		}
		if (NIDOKPOOIHH.BFMOBNPFEOF(NIDOKPOOIHH.IGPFACNOAGD(LFLOCKNKAKC), num))
		{
			return 0;
		}
		return NIDOKPOOIHH.DOCAFHDOEHE(PLKMJJIIJNO, LFLOCKNKAKC);
	}

	// Token: 0x06003BA2 RID: 15266 RVA: 0x0018B824 File Offset: 0x00189A24
	public static void GMGPLOLADGB(PLFDAJJHMKO LFLOCKNKAKC)
	{
		if (LFLOCKNKAKC == null)
		{
			return;
		}
		int num = LFLOCKNKAKC.DHONIOBOLEL.DDEDAHCFHJN();
		AssetStoryHeader assetStoryHeader = GKJPOGNFKNK.CDCEFHLNNEC(LFLOCKNKAKC.DHONIOBOLEL.GGICIBLJIKI);
		if (null != assetStoryHeader && assetStoryHeader.availableChaptersCount > 0 && num > assetStoryHeader.availableChaptersCount - 1)
		{
			num = assetStoryHeader.availableChaptersCount - 1;
		}
		NIDOKPOOIHH.GMGPLOLADGB(NIDOKPOOIHH.IGPFACNOAGD(LFLOCKNKAKC), num);
	}

	// Token: 0x06003BA3 RID: 15267 RVA: 0x0018B884 File Offset: 0x00189A84
	private static Dictionary<int, int> HLCOGPHDCKN()
	{
		if (NIDOKPOOIHH.GNNOJPJPJCL != null)
		{
			return NIDOKPOOIHH.GNNOJPJPJCL;
		}
		NIDOKPOOIHH.GNNOJPJPJCL = new Dictionary<int, int>();
		try
		{
			string @string = PlayerPrefs.GetString("lnls", "");
			if (!string.IsNullOrEmpty(@string))
			{
				string[] array = @string.Split(',', StringSplitOptions.None);
				for (int i = 0; i < array.Length; i++)
				{
					string[] array2 = array[i].Split(':', StringSplitOptions.None);
					int key;
					int value;
					if (array2.Length == 2 && int.TryParse(array2[0], out key) && int.TryParse(array2[1], out value))
					{
						NIDOKPOOIHH.GNNOJPJPJCL[key] = value;
					}
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
		return NIDOKPOOIHH.GNNOJPJPJCL;
	}

	// Token: 0x06003BA4 RID: 15268 RVA: 0x0018B930 File Offset: 0x00189B30
	public static int IGPFACNOAGD(PLFDAJJHMKO LFLOCKNKAKC)
	{
		return AKLFPGMDKLA.ACFJMCBMOFG(LFLOCKNKAKC.DHONIOBOLEL.GGICIBLJIKI, LFLOCKNKAKC.POJAPLKAJEF);
	}

	// Token: 0x04001145 RID: 4421
	private const string MAFGLIADKCF = "lnls";

	// Token: 0x04001146 RID: 4422
	private const char COMCEOKNMNP = ',';

	// Token: 0x04001147 RID: 4423
	private const char KBAEAPAIJJE = ':';

	// Token: 0x04001148 RID: 4424
	public const int PNAJOEBLCAJ = 99;

	// Token: 0x04001149 RID: 4425
	private static Dictionary<int, int> GNNOJPJPJCL;
}
