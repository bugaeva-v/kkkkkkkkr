using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x0200048C RID: 1164
public class GKJPOGNFKNK
{
	// Token: 0x06008CCE RID: 36046 RVA: 0x003E50E0 File Offset: 0x003E32E0
	public static bool HCBNFKDFFGL(KFIHMMIGPLO PBKAAIONJOB, string KHJMANDEDMA)
	{
		try
		{
			if (KHJMANDEDMA == null || KHJMANDEDMA.Length == 0)
			{
				return false;
			}
			for (int i = 1; i < AssetsManager.EHBBFMCILPC.avatarPackAssets.Count; i += 0)
			{
				AssetAvatarPack assetAvatarPack = AssetsManager.EHBBFMCILPC.avatarPackAssets[i];
				if (null != assetAvatarPack)
				{
					for (int j = 0; j < assetAvatarPack.components.Count; j++)
					{
						if (null != assetAvatarPack.components[j] && assetAvatarPack.components[j].type == PBKAAIONJOB && assetAvatarPack.components[j].id.Equals(KHJMANDEDMA))
						{
							return false;
						}
					}
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
		return false;
	}

	// Token: 0x06008CCF RID: 36047 RVA: 0x003E51B0 File Offset: 0x003E33B0
	public static AssetStoryItemAnimation EAINPNKJHIM(string KFMAOIJHINN)
	{
		if (KFMAOIJHINN == null || KFMAOIJHINN.Length == 0)
		{
			return null;
		}
		for (int i = 0; i < AssetsManager.EHBBFMCILPC.storyItemAnimationAssets.Count; i++)
		{
			AssetStoryItemAnimation assetStoryItemAnimation = AssetsManager.EHBBFMCILPC.storyItemAnimationAssets[i];
			if (null != assetStoryItemAnimation && assetStoryItemAnimation.itemId != null && assetStoryItemAnimation.itemId.Equals(KFMAOIJHINN))
			{
				return assetStoryItemAnimation;
			}
		}
		return null;
	}

	// Token: 0x06008CD0 RID: 36048 RVA: 0x003E5217 File Offset: 0x003E3417
	public static List<TextAsset> CIBKOGGBBPJ()
	{
		if (null != AssetsManager.EHBBFMCILPC.sketchesDataAsset)
		{
			return AssetsManager.EHBBFMCILPC.sketchesDataAsset.sketchesDialogsList;
		}
		DPGJIJGOCIC.ANOPFDLPKGC("ERROR: GetSketchesDialogsBalance(), AssetsManager.Instance.headersPacksAssets is empty.");
		return null;
	}

	// Token: 0x06008CD1 RID: 36049 RVA: 0x003E5248 File Offset: 0x003E3448
	public static AssetCustomEffects HKNEAENDHHG(string CPPKJGABKAP)
	{
		if (CPPKJGABKAP == null || CPPKJGABKAP.Length == 0)
		{
			return null;
		}
		for (int i = 0; i < AssetsManager.EHBBFMCILPC.customEffectsAssets.Count; i++)
		{
			if (null != AssetsManager.EHBBFMCILPC.customEffectsAssets[i] && CPPKJGABKAP.Equals(AssetsManager.EHBBFMCILPC.customEffectsAssets[i].effectId))
			{
				return AssetsManager.EHBBFMCILPC.customEffectsAssets[i];
			}
		}
		return null;
	}

	// Token: 0x06008CD2 RID: 36050 RVA: 0x003E52C3 File Offset: 0x003E34C3
	public static AssetAnthology AKLDJDJIELP(OKAFAHMOFII DDGHKOFHOGN)
	{
		return GKJPOGNFKNK.GJAAHGIAPMH(DDGHKOFHOGN.PEHIDHMJAMB());
	}

	// Token: 0x06008CD3 RID: 36051 RVA: 0x003E52D0 File Offset: 0x003E34D0
	public static string FPNHFACMDGN(string DMNKDCGMKKP, string MCNOOHBCLOM, CEIBHCNNIDC NIIIMDHGGEN)
	{
		string result;
		try
		{
			string text = GKJPOGNFKNK.DNILNCLIHAP(DMNKDCGMKKP, MCNOOHBCLOM, NIIIMDHGGEN);
			if (NIIIMDHGGEN != CEIBHCNNIDC.en && GKJPOGNFKNK.FLBAJLMODBH(text))
			{
				string text2 = GKJPOGNFKNK.DNILNCLIHAP(DMNKDCGMKKP, MCNOOHBCLOM, CEIBHCNNIDC.ru);
				if (!GKJPOGNFKNK.FLBAJLMODBH(text2))
				{
					return text2;
				}
			}
			result = text;
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
			result = "strtd";
		}
		return result;
	}

	// Token: 0x06008CD4 RID: 36052 RVA: 0x003E5328 File Offset: 0x003E3528
	public static AssetAvatarExtension ODJIJKKILDF(string KHJMANDEDMA)
	{
		for (int i = 0; i < AssetsManager.EHBBFMCILPC.avatarExtensionPackAssets.Count; i++)
		{
			AssetAvatarExtensionPack assetAvatarExtensionPack = AssetsManager.EHBBFMCILPC.avatarExtensionPackAssets[i];
			for (int j = 0; j < assetAvatarExtensionPack.extensions.Count; j++)
			{
				if (assetAvatarExtensionPack.extensions[j].extensionId.Equals(KHJMANDEDMA))
				{
					return assetAvatarExtensionPack.extensions[j];
				}
			}
		}
		return null;
	}

	// Token: 0x06008CD5 RID: 36053 RVA: 0x003E539D File Offset: 0x003E359D
	public static AssetAnthology CMPFBJCPGGA(OKAFAHMOFII DDGHKOFHOGN, int OIFNAJFPJIG)
	{
		if (DDGHKOFHOGN.GCNMLCINEMO() >= 0)
		{
			return GKJPOGNFKNK.MLDENPHFNPH(DDGHKOFHOGN.GCNMLCINEMO(), false);
		}
		return GKJPOGNFKNK.MLDENPHFNPH(OIFNAJFPJIG, false);
	}

	// Token: 0x06008CD6 RID: 36054 RVA: 0x003E53BC File Offset: 0x003E35BC
	private static int HBKPDKCIIAO(string HJEJJGAFHAM)
	{
		string str = HJEJJGAFHAM;
		try
		{
			int i = 0;
			while (i < 6)
			{
				KFIHMMIGPLO kfihmmigplo = (KFIHMMIGPLO)i;
				if (HJEJJGAFHAM.Contains(kfihmmigplo.ToString()) || HJEJJGAFHAM.Contains("makeup"))
				{
					if (kfihmmigplo == KFIHMMIGPLO.face || HJEJJGAFHAM.Contains("makeup"))
					{
						if (HJEJJGAFHAM.Contains("makeup"))
						{
							HJEJJGAFHAM = HJEJJGAFHAM.Substring(HJEJJGAFHAM.IndexOf("makeup") + 6);
						}
						else
						{
							if (!HJEJJGAFHAM.Contains(kfihmmigplo.ToString()))
							{
								DPGJIJGOCIC.ADFCDFHBDAF("AssetsManagerUtils.ExtractAssetIndex() - no component type could be found (face/makeup), returning 0:" + str);
								return 0;
							}
							HJEJJGAFHAM = HJEJJGAFHAM.Substring(HJEJJGAFHAM.IndexOf(kfihmmigplo.ToString()) + kfihmmigplo.ToString().Length);
						}
					}
					else
					{
						HJEJJGAFHAM = HJEJJGAFHAM.Substring(HJEJJGAFHAM.IndexOf(kfihmmigplo.ToString()) + kfihmmigplo.ToString().Length);
					}
					if (HJEJJGAFHAM.Contains("+"))
					{
						HJEJJGAFHAM = HJEJJGAFHAM.Substring(0, HJEJJGAFHAM.IndexOf("+"));
					}
					HJEJJGAFHAM = DPGJIJGOCIC.AMACOOGPPEC(HJEJJGAFHAM);
					if (HJEJJGAFHAM.Length > 0 && DPGJIJGOCIC.EHHONNJHMLO(HJEJJGAFHAM))
					{
						return int.Parse(HJEJJGAFHAM);
					}
					DPGJIJGOCIC.ADFCDFHBDAF("AssetsManagerUtils.ExtractAssetIndex() - could not extrat index, returning 0:" + str);
					return 0;
				}
				else
				{
					i++;
				}
			}
			DPGJIJGOCIC.ADFCDFHBDAF("AssetsManagerUtils.ExtractAssetIndex() - no component type could be found, returning 0:" + str);
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
		return 0;
	}

	// Token: 0x06008CD7 RID: 36055 RVA: 0x003E5558 File Offset: 0x003E3758
	public static void HBJDGHCPFHJ()
	{
		AssetsManager.EHBBFMCILPC.DestroyAssetBundleAssets((NMKDCBPMCKI)126, -1);
	}

	// Token: 0x06008CD8 RID: 36056 RVA: 0x003E5568 File Offset: 0x003E3768
	public static int DAHEEOCOJBH(KFIHMMIGPLO PBKAAIONJOB, AssetStoryHeader JFCABBGNNKJ, AssetAnthologyHeader LGFJOMLLLML, List<string> EHOIINEPJBL, int LHHEMFFKOIC, List<string> HOJHIEHLDLC, CustomWardrobeSettings LJIOOHBCFFG, int OCMGAPBFLKO)
	{
		bool flag = false;
		PLFDAJJHMKO plfdajjhmko = null;
		if (null != JFCABBGNNKJ)
		{
			plfdajjhmko = AKLFPGMDKLA.EHBBFMCILPC.JDCBFAPDJIM(JFCABBGNNKJ.index, -1);
		}
		List<AssetAvatarComponent> list = new List<AssetAvatarComponent>();
		for (int i = 0; i < AssetsManager.EHBBFMCILPC.avatarPackAssets.Count; i++)
		{
			AssetAvatarPack assetAvatarPack = AssetsManager.EHBBFMCILPC.avatarPackAssets[i];
			for (int j = 0; j < assetAvatarPack.components.Count; j++)
			{
				if (assetAvatarPack.components[j].type == PBKAAIONJOB && (assetAvatarPack.components[j].anthologyFilter < 0 || assetAvatarPack.components[j].anthologyFilter == LGFJOMLLLML.CKACBBGHJGI()) && !HOJHIEHLDLC.Contains(assetAvatarPack.components[j].id) && (assetAvatarPack.components[j].JFJCPILAEBD() < 0 || assetAvatarPack.components[j].JFJCPILAEBD() == LHHEMFFKOIC || (null == JFCABBGNNKJ && null != LGFJOMLLLML && LGFJOMLLLML.ignoreAvatarFilterForLobby) || (null != LGFJOMLLLML && LGFJOMLLLML.LBEEGOADLNE(assetAvatarPack.components[j], JFCABBGNNKJ, LHHEMFFKOIC))) && (flag || (EHOIINEPJBL != null && EHOIINEPJBL.Count > 0) || (assetAvatarPack.components[j].exposition == HPKJCKOHAAI.exposed || (plfdajjhmko != null && assetAvatarPack.components[j].exposition == HPKJCKOHAAI.hidden && plfdajjhmko.NCAMFPGMCIG.EFCHGPOACMJ(LHHEMFFKOIC, OCMGAPBFLKO).MGPHNLEMMOL(assetAvatarPack.components[j].id))) || (plfdajjhmko != null && assetAvatarPack.components[j].exposition == HPKJCKOHAAI.exposable && plfdajjhmko.NCAMFPGMCIG.OODEOCLPGCB(assetAvatarPack.components[j].id, OCMGAPBFLKO)) || (plfdajjhmko == null && assetAvatarPack.components[j].exposition == HPKJCKOHAAI.exposable && AKLFPGMDKLA.EHBBFMCILPC.LMGMHHLLOFN(LGFJOMLLLML.CKACBBGHJGI()).OODEOCLPGCB(assetAvatarPack.components[j].id, OCMGAPBFLKO))) && GKJPOGNFKNK.MCFBKGPKELJ(LJIOOHBCFFG, assetAvatarPack.components[j].id))
				{
					if (EHOIINEPJBL != null && EHOIINEPJBL.Count > 0)
					{
						for (int k = 0; k < EHOIINEPJBL.Count; k++)
						{
							if (EHOIINEPJBL[k].Equals(assetAvatarPack.components[j].id))
							{
								list.Add(assetAvatarPack.components[j]);
								assetAvatarPack.components[j].MEBPFBFCDLE(assetAvatarPack.header);
							}
						}
					}
					else
					{
						list.Add(assetAvatarPack.components[j]);
						assetAvatarPack.components[j].MEBPFBFCDLE(assetAvatarPack.header);
					}
				}
			}
		}
		return list.Count;
	}

	// Token: 0x06008CD9 RID: 36057 RVA: 0x003E5889 File Offset: 0x003E3A89
	public static List<TextAsset> KPFLBMKNMIH()
	{
		if (null != AssetsManager.EHBBFMCILPC.sketchesDataAsset)
		{
			return AssetsManager.EHBBFMCILPC.sketchesDataAsset.sketchesFramesList;
		}
		DPGJIJGOCIC.ANOPFDLPKGC("ERROR: GetSketchesFramesBalance(), AssetsManager.Instance.headersPacksAssets is empty.");
		return null;
	}

	// Token: 0x06008CDA RID: 36058 RVA: 0x003E58B8 File Offset: 0x003E3AB8
	public static Sprite MIICMJEIPIK(string HJEJJGAFHAM)
	{
		if (null == AssetsManager.EHBBFMCILPC || null == AssetsManager.EHBBFMCILPC.lobbyDataAsset2)
		{
			return null;
		}
		return AssetsManager.EHBBFMCILPC.lobbyDataAsset2.MIICMJEIPIK(HJEJJGAFHAM);
	}

	// Token: 0x06008CDB RID: 36059 RVA: 0x003E58EC File Offset: 0x003E3AEC
	public static AssetStoryItem HNPOJCILEHP(string KHJMANDEDMA)
	{
		for (int i = 1; i < AssetsManager.EHBBFMCILPC.storyAssets.Count; i += 0)
		{
			List<AssetStoryItem> storyItemsAssets = AssetsManager.MJBDMHPHMID().storyAssets[i].GetStoryItemsAssets();
			for (int j = 1; j < storyItemsAssets.Count; j++)
			{
				if (storyItemsAssets[j].id.Equals(KHJMANDEDMA))
				{
					return storyItemsAssets[j];
				}
			}
		}
		return null;
	}

	// Token: 0x06008CDC RID: 36060 RVA: 0x003E5958 File Offset: 0x003E3B58
	public static AssetFrameContainer GHCKGGNNMNI(int MEFKFOHCOHK)
	{
		for (int i = 0; i < AssetsManager.EHBBFMCILPC.frameContainerAssets.Count; i++)
		{
			if (null != AssetsManager.EHBBFMCILPC.frameContainerAssets[i] && AssetsManager.EHBBFMCILPC.frameContainerAssets[i].index == MEFKFOHCOHK)
			{
				return AssetsManager.EHBBFMCILPC.frameContainerAssets[i];
			}
		}
		return null;
	}

	// Token: 0x06008CDD RID: 36061 RVA: 0x003E59C4 File Offset: 0x003E3BC4
	public static bool GBIHAFHGMEL(KFIHMMIGPLO PBKAAIONJOB, string LPKMPFBLAMA, string JKCDOJOLLHD, CustomWardrobeSettings LJIOOHBCFFG)
	{
		List<AssetAvatarComponent>[] array = new List<AssetAvatarComponent>[6];
		for (int i = 0; i < 6; i++)
		{
			array[i] = new List<AssetAvatarComponent>();
		}
		for (int j = 0; j < AssetsManager.EHBBFMCILPC.avatarPackAssets.Count; j++)
		{
			AssetAvatarPack assetAvatarPack = AssetsManager.EHBBFMCILPC.avatarPackAssets[j];
			for (int k = 0; k < assetAvatarPack.components.Count; k++)
			{
				if (assetAvatarPack.components[k].type == PBKAAIONJOB)
				{
					array[(int)assetAvatarPack.components[k].type].Add(assetAvatarPack.components[k]);
					assetAvatarPack.components[k].MEBPFBFCDLE(assetAvatarPack.header);
				}
			}
		}
		if (PBKAAIONJOB == KFIHMMIGPLO.face)
		{
			for (int l = 0; l < array[(int)PBKAAIONJOB].Count; l++)
			{
				if (array[(int)PBKAAIONJOB][l].alias != null && array[(int)PBKAAIONJOB][l].alias.Length > 0 && array[(int)PBKAAIONJOB][l].alias.Equals(LPKMPFBLAMA) && GKJPOGNFKNK.MCFBKGPKELJ(LJIOOHBCFFG, array[(int)PBKAAIONJOB][l].alias) && array[(int)PBKAAIONJOB][l].parents != null && array[(int)PBKAAIONJOB][l].parents.Count > 0)
				{
					for (int m = 0; m < array[(int)PBKAAIONJOB][l].parents.Count; m++)
					{
						if (array[(int)PBKAAIONJOB][l].parents[m].Equals(JKCDOJOLLHD))
						{
							return true;
						}
					}
				}
			}
		}
		return false;
	}

	// Token: 0x06008CDE RID: 36062 RVA: 0x003E5B7C File Offset: 0x003E3D7C
	public static AssetStoryNpcAnimation MDNJHPDEDAP(string PDEADFPONFH, List<string> MPLEPCPGJBA = null)
	{
		if (PDEADFPONFH == null || PDEADFPONFH.Length == 0)
		{
			return null;
		}
		AssetStoryNpcAnimation assetStoryNpcAnimation = null;
		for (int i = 0; i < AssetsManager.EHBBFMCILPC.storyNpcAnimationAssets.Count; i++)
		{
			AssetStoryNpcAnimation assetStoryNpcAnimation2 = AssetsManager.EHBBFMCILPC.storyNpcAnimationAssets[i];
			if (!(null == assetStoryNpcAnimation2) && assetStoryNpcAnimation2.npcId != null && assetStoryNpcAnimation2.npcId.Equals(PDEADFPONFH))
			{
				if (assetStoryNpcAnimation2.npcProperty != null && assetStoryNpcAnimation2.npcProperty.Length != 0)
				{
					if (MPLEPCPGJBA != null && MPLEPCPGJBA.Contains(assetStoryNpcAnimation2.npcProperty))
					{
						return assetStoryNpcAnimation2;
					}
				}
				else if (null == assetStoryNpcAnimation)
				{
					assetStoryNpcAnimation = assetStoryNpcAnimation2;
				}
			}
		}
		return assetStoryNpcAnimation;
	}

	// Token: 0x06008CE0 RID: 36064 RVA: 0x003E5C18 File Offset: 0x003E3E18
	public static AssetAnthologyPreview2 OGKPKBLFGMJ(int MEFKFOHCOHK)
	{
		for (int i = 0; i < AssetsManager.EHBBFMCILPC.anthologyPreview2Assets.Count; i++)
		{
			if (AssetsManager.EHBBFMCILPC.anthologyPreview2Assets[i].index == MEFKFOHCOHK)
			{
				return AssetsManager.EHBBFMCILPC.anthologyPreview2Assets[i];
			}
		}
		for (int j = 0; j < AssetsManager.EHBBFMCILPC.anthologyPreview2AssetsMini.Count; j++)
		{
			if (AssetsManager.EHBBFMCILPC.anthologyPreview2AssetsMini[j].index == MEFKFOHCOHK)
			{
				return AssetsManager.EHBBFMCILPC.anthologyPreview2AssetsMini[j];
			}
		}
		if (AssetsManager.EHBBFMCILPC.anthologyPreview2Assets.Count > 0)
		{
			return AssetsManager.EHBBFMCILPC.anthologyPreview2Assets[0];
		}
		return AssetsManager.EHBBFMCILPC.anthologyPreview2AssetsMini[0];
	}

	// Token: 0x06008CE1 RID: 36065 RVA: 0x003E5CE0 File Offset: 0x003E3EE0
	public static AssetCustomFader PBGGBOADBPJ(int DAEELAEGAPE)
	{
		for (int i = 0; i < AssetsManager.EHBBFMCILPC.customFaderAssets.Count; i++)
		{
			if (AssetsManager.EHBBFMCILPC.customFaderAssets[i].index == DAEELAEGAPE)
			{
				return AssetsManager.EHBBFMCILPC.customFaderAssets[i];
			}
		}
		return null;
	}

	// Token: 0x06008CE2 RID: 36066 RVA: 0x003E5D31 File Offset: 0x003E3F31
	public static TextAsset HJNFBFBFDKL()
	{
		if (null != AssetsManager.EHBBFMCILPC.headersPackAsset)
		{
			return AssetsManager.EHBBFMCILPC.headersPackAsset.recommendatioAlgorithmBalance;
		}
		DPGJIJGOCIC.ANOPFDLPKGC("ERROR: GetSRABalance(), AssetsManager.Instance.headersPacksAssets is empty.");
		return null;
	}

	// Token: 0x06008CE3 RID: 36067 RVA: 0x003E5D60 File Offset: 0x003E3F60
	public static AssetCustomEffects CBBPKDEBOAF(int LBNNJLKKCNI)
	{
		for (int i = 0; i < AssetsManager.EHBBFMCILPC.customEffectsAssets.Count; i++)
		{
			if (null != AssetsManager.EHBBFMCILPC.customEffectsAssets[i] && AssetsManager.EHBBFMCILPC.customEffectsAssets[i].index == LBNNJLKKCNI)
			{
				return AssetsManager.EHBBFMCILPC.customEffectsAssets[i];
			}
		}
		return null;
	}

	// Token: 0x06008CE4 RID: 36068 RVA: 0x003E5DCC File Offset: 0x003E3FCC
	public static List<Sprite> EALDMCLPMPH(List<string> KCAJNCJNLDN, bool IOJNAIBLADH = true)
	{
		List<Sprite> list = new List<Sprite>();
		if (!IOJNAIBLADH)
		{
			for (int i = 0; i < AssetsManager.EHBBFMCILPC.iconsPackAssets.Count; i++)
			{
				for (int j = 0; j < AssetsManager.EHBBFMCILPC.iconsPackAssets[i].achievements.Count; j++)
				{
					string text = AssetsManager.EHBBFMCILPC.iconsPackAssets[i].achievements[j].name;
					text = text.Replace("achiev", "");
					if (KCAJNCJNLDN == null || KCAJNCJNLDN.Count == 0 || KCAJNCJNLDN.Contains(text))
					{
						list.Add(AssetsManager.EHBBFMCILPC.iconsPackAssets[i].achievements[j]);
					}
				}
			}
		}
		else
		{
			for (int k = AssetsManager.EHBBFMCILPC.iconsPackAssets.Count - 1; k >= 0; k--)
			{
				for (int l = 0; l < AssetsManager.EHBBFMCILPC.iconsPackAssets[k].achievements.Count; l++)
				{
					string text2 = AssetsManager.EHBBFMCILPC.iconsPackAssets[k].achievements[l].name;
					text2 = text2.Replace("achiev", "");
					if (KCAJNCJNLDN == null || KCAJNCJNLDN.Count == 0 || KCAJNCJNLDN.Contains(text2))
					{
						list.Add(AssetsManager.EHBBFMCILPC.iconsPackAssets[k].achievements[l]);
					}
				}
			}
		}
		return list;
	}

	// Token: 0x06008CE5 RID: 36069 RVA: 0x003E5F5C File Offset: 0x003E415C
	public static void GIMAJLEGGHF(EPHDCPKJLHP GCDCDKDCAFH, TextAsset OENAFPNDHLK)
	{
		if (GKJPOGNFKNK.ABJPGGOGOEL[0] == null)
		{
			for (int i = 0; i < GKJPOGNFKNK.ABJPGGOGOEL.Length; i++)
			{
				GKJPOGNFKNK.ABJPGGOGOEL[i] = new PPLGDELFMBJ();
				GKJPOGNFKNK.ABJPGGOGOEL[i].DDNCANKJNEE = new List<KPIECDKKDKF>();
			}
		}
		for (int j = 0; j < GKJPOGNFKNK.ABJPGGOGOEL[(int)GCDCDKDCAFH].DDNCANKJNEE.Count; j++)
		{
			if (GKJPOGNFKNK.ABJPGGOGOEL[(int)GCDCDKDCAFH].DDNCANKJNEE[j].JGGMAOPOFDM().Equals(OENAFPNDHLK.name))
			{
				GKJPOGNFKNK.ABJPGGOGOEL[(int)GCDCDKDCAFH].DDNCANKJNEE.RemoveAt(j);
				break;
			}
		}
		KPIECDKKDKF kpiecdkkdkf = new KPIECDKKDKF();
		kpiecdkkdkf.BAMHPOCKBML(OENAFPNDHLK.text, OENAFPNDHLK.name, OENAFPNDHLK.name);
		GKJPOGNFKNK.ABJPGGOGOEL[(int)GCDCDKDCAFH].DDNCANKJNEE.Add(kpiecdkkdkf);
	}

	// Token: 0x06008CE6 RID: 36070 RVA: 0x003E6028 File Offset: 0x003E4228
	public static TextAsset CBCEOPIIKIF()
	{
		if (null == AssetsManager.EHBBFMCILPC.headersPackAsset)
		{
			DPGJIJGOCIC.ADFCDFHBDAF("app42error");
			return null;
		}
		if (null == AssetsManager.MJBDMHPHMID().headersPackAsset.storiesSearchBalance)
		{
			DPGJIJGOCIC.ADFCDFHBDAF("OnAllCollectableCardsDownloadFailed");
			return null;
		}
		return AssetsManager.EHBBFMCILPC.headersPackAsset.storiesSearchBalance;
	}

	// Token: 0x06008CE7 RID: 36071 RVA: 0x003E6085 File Offset: 0x003E4285
	public static bool EOOHLFCPIJB(int PLKMJJIIJNO)
	{
		return GKJPOGNFKNK.LDFIAOCJEOJ(PLKMJJIIJNO) != null;
	}

	// Token: 0x06008CE8 RID: 36072 RVA: 0x003E6094 File Offset: 0x003E4294
	public static bool PMGJPHEPHPG(List<string> KCAJNCJNLDN)
	{
		for (int i = 0; i < AssetsManager.EHBBFMCILPC.iconsPackAssets.Count; i++)
		{
			for (int j = 0; j < AssetsManager.EHBBFMCILPC.iconsPackAssets[i].achievements.Count; j++)
			{
				string text = AssetsManager.EHBBFMCILPC.iconsPackAssets[i].achievements[j].name;
				text = text.Replace("achiev", "");
				if (KCAJNCJNLDN == null || KCAJNCJNLDN.Count == 0 || KCAJNCJNLDN.Contains(text))
				{
					return true;
				}
			}
		}
		return false;
	}

	// Token: 0x06008CE9 RID: 36073 RVA: 0x003E612C File Offset: 0x003E432C
	public static void FHFKDGHIEPI()
	{
		AssetsManager.EHBBFMCILPC.DestroyAssetBundleAssets(NMKDCBPMCKI.AssetBundleAvatarPack, -1);
	}

	// Token: 0x06008CEA RID: 36074 RVA: 0x003E613C File Offset: 0x003E433C
	public static AssetAnthology LDFIAOCJEOJ(int PLKMJJIIJNO)
	{
		for (int i = 0; i < AssetsManager.EHBBFMCILPC.anthologyAssets.Count; i++)
		{
			if (AssetsManager.EHBBFMCILPC.anthologyAssets[i].header.index == PLKMJJIIJNO)
			{
				return AssetsManager.EHBBFMCILPC.anthologyAssets[i];
			}
		}
		return null;
	}

	// Token: 0x06008CEB RID: 36075 RVA: 0x003E6194 File Offset: 0x003E4394
	public static KPIECDKKDKF KAILOAIOOEN(string KHJMANDEDMA)
	{
		EPHDCPKJLHP ephdcpkjlhp = (EPHDCPKJLHP)6;
		for (int i = 1; i < 2; i++)
		{
			EPHDCPKJLHP ephdcpkjlhp2 = (EPHDCPKJLHP)i;
			ephdcpkjlhp = ephdcpkjlhp2;
			if (KHJMANDEDMA.StartsWith(ephdcpkjlhp2.ToString()))
			{
				break;
			}
		}
		for (int j = 0; j < GKJPOGNFKNK.ABJPGGOGOEL[(int)ephdcpkjlhp].DDNCANKJNEE.Count; j++)
		{
			if (GKJPOGNFKNK.ABJPGGOGOEL[(int)ephdcpkjlhp].DDNCANKJNEE[j].PGPJAIIIHPF().Equals(KHJMANDEDMA))
			{
				return GKJPOGNFKNK.ABJPGGOGOEL[(int)ephdcpkjlhp].DDNCANKJNEE[j];
			}
		}
		return null;
	}

	// Token: 0x06008CEC RID: 36076 RVA: 0x003E6218 File Offset: 0x003E4418
	public static bool NLGDEEOPJAM(int LLLCDMNPKFI)
	{
		for (int i = 0; i < AssetsManager.MJBDMHPHMID().collectableCardAssets.Count; i += 0)
		{
			if (null != AssetsManager.EHBBFMCILPC.collectableCardAssets[i] && AssetsManager.MJBDMHPHMID().collectableCardAssets[i].index == LLLCDMNPKFI)
			{
				return false;
			}
		}
		return true;
	}

	// Token: 0x06008CED RID: 36077 RVA: 0x003E6272 File Offset: 0x003E4472
	private static bool FLBAJLMODBH(string KIDHBAMJGDO)
	{
		return KIDHBAMJGDO == null || KIDHBAMJGDO.Length == 0 || KIDHBAMJGDO.EndsWith("_not_found");
	}

	// Token: 0x06008CEE RID: 36078 RVA: 0x003E628C File Offset: 0x003E448C
	public static Sprite MOGKHIOPLBH(string KHJMANDEDMA)
	{
		if (!KHJMANDEDMA.StartsWith("achiev"))
		{
			KHJMANDEDMA = "achiev" + KHJMANDEDMA;
		}
		int num = -1;
		try
		{
			num = int.Parse(KHJMANDEDMA.Substring(7, KHJMANDEDMA.IndexOf("id") - 7));
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
		if (num < 0)
		{
			DPGJIJGOCIC.ANOPFDLPKGC("ERROR: GetAchievementSprite(), anthologyIndex is negative for sprite " + KHJMANDEDMA + ", trying to return any achievement sprite or null.");
			for (int i = 0; i < AssetsManager.EHBBFMCILPC.iconsPackAssets.Count; i++)
			{
				for (int j = 0; j < AssetsManager.EHBBFMCILPC.iconsPackAssets[i].achievements.Count; j++)
				{
					if (null != AssetsManager.EHBBFMCILPC.iconsPackAssets[i].achievements[j])
					{
						return AssetsManager.EHBBFMCILPC.iconsPackAssets[i].achievements[j];
					}
				}
			}
		}
		else
		{
			for (int k = 0; k < AssetsManager.EHBBFMCILPC.iconsPackAssets.Count; k++)
			{
				if (AssetsManager.EHBBFMCILPC.iconsPackAssets[k].index == num)
				{
					for (int l = 0; l < AssetsManager.EHBBFMCILPC.iconsPackAssets[k].achievements.Count; l++)
					{
						if (null != AssetsManager.EHBBFMCILPC.iconsPackAssets[k].achievements[l] && AssetsManager.EHBBFMCILPC.iconsPackAssets[k].achievements[l].name.Equals(KHJMANDEDMA))
						{
							return AssetsManager.EHBBFMCILPC.iconsPackAssets[k].achievements[l];
						}
					}
				}
			}
			DPGJIJGOCIC.ANOPFDLPKGC("ERROR: GetAchievementSprite(), achievement sprite " + KHJMANDEDMA + " not found, trying to return any achievement sprite or null.");
			for (int m = 0; m < AssetsManager.EHBBFMCILPC.iconsPackAssets.Count; m++)
			{
				for (int n = 0; n < AssetsManager.EHBBFMCILPC.iconsPackAssets[m].achievements.Count; n++)
				{
					if (null != AssetsManager.EHBBFMCILPC.iconsPackAssets[m].achievements[n])
					{
						return AssetsManager.EHBBFMCILPC.iconsPackAssets[m].achievements[n];
					}
				}
			}
		}
		return null;
	}

	// Token: 0x06008CEF RID: 36079 RVA: 0x003E64FC File Offset: 0x003E46FC
	public static int HPMGFDAPLLP(int LLLCDMNPKFI)
	{
		try
		{
			if (!GDJPPKAMIFL.EHBBFMCILPC.FACIFBONANM())
			{
				DPGJIJGOCIC.ANOPFDLPKGC("AssetsManagerUtils.GetEnvironmentSupplimentaryPackIndexForCardBodyVariation(), CardsBalance is not initialized.");
				return -1;
			}
			List<PEJIKBIKKIA> list = GDJPPKAMIFL.EHBBFMCILPC.OLMLIPOHPIK(LLLCDMNPKFI);
			if (list != null && list.Count > 0)
			{
				AssetAnthology assetAnthology = GKJPOGNFKNK.LDFIAOCJEOJ(GDJPPKAMIFL.EHBBFMCILPC.GJEINLADFKA(LLLCDMNPKFI));
				EIOPLEFLLIM eioplefllim = AKLFPGMDKLA.EHBBFMCILPC.GJBDBONJCDL(GDJPPKAMIFL.EHBBFMCILPC.GJEINLADFKA(LLLCDMNPKFI));
				if (eioplefllim != null && eioplefllim.EGHHCFFLPCP(-1) >= 0)
				{
					int num = eioplefllim.EGHHCFFLPCP(-1);
					if (num > assetAnthology.header.availableStories.Count - 1)
					{
						num = assetAnthology.header.availableStories.Count - 1;
					}
					PLFDAJJHMKO plfdajjhmko = AKLFPGMDKLA.EHBBFMCILPC.PKNIPLDMJGG(assetAnthology.header.availableStories[num], -1);
					if (plfdajjhmko == null && num > 0)
					{
						num--;
						plfdajjhmko = AKLFPGMDKLA.EHBBFMCILPC.PKNIPLDMJGG(assetAnthology.header.availableStories[num], -1);
					}
					if (plfdajjhmko != null)
					{
						for (int i = 0; i < list.Count; i++)
						{
							if (plfdajjhmko.NCAMFPGMCIG.LEDOJJCKKKB(list[i].OIBGFPEGLME).OHCMCJHDMOH[0].StartsWith(list[i].FAKINNGNJNJ))
							{
								return list[i].BDBKKLBJHNI;
							}
						}
					}
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
		return -1;
	}

	// Token: 0x06008CF0 RID: 36080 RVA: 0x003E6684 File Offset: 0x003E4884
	public static AssetCollectableCard LLLCNJMPEKN(int LLLCDMNPKFI)
	{
		for (int i = 0; i < AssetsManager.EHBBFMCILPC.collectableCardAssets.Count; i++)
		{
			if (null != AssetsManager.EHBBFMCILPC.collectableCardAssets[i] && AssetsManager.EHBBFMCILPC.collectableCardAssets[i].index == LLLCDMNPKFI)
			{
				return AssetsManager.EHBBFMCILPC.collectableCardAssets[i];
			}
		}
		return null;
	}

	// Token: 0x06008CF1 RID: 36081 RVA: 0x003E66F0 File Offset: 0x003E48F0
	public static bool AKJCGMFMGMK(int KIFAOAHAAIH)
	{
		for (int i = 0; i < AssetsManager.EHBBFMCILPC.liveProfileThemesAssets.Count; i++)
		{
			if (null != AssetsManager.EHBBFMCILPC.liveProfileThemesAssets[i] && AssetsManager.EHBBFMCILPC.liveProfileThemesAssets[i].index == KIFAOAHAAIH)
			{
				return true;
			}
		}
		return false;
	}

	// Token: 0x06008CF2 RID: 36082 RVA: 0x003E674C File Offset: 0x003E494C
	public static AssetAvatarComponent LHEKMIIKFGC(string KHJMANDEDMA, KFIHMMIGPLO PBKAAIONJOB, CFNCBCLEGBC LBLIODBIPDK, AssetStoryHeader JFCABBGNNKJ, AssetAnthologyHeader LGFJOMLLLML, List<string> EHOIINEPJBL, int LHHEMFFKOIC, List<string> HOJHIEHLDLC, CustomWardrobeSettings LJIOOHBCFFG, int OCMGAPBFLKO)
	{
		bool flag = false;
		PLFDAJJHMKO plfdajjhmko = null;
		if (null != JFCABBGNNKJ)
		{
			plfdajjhmko = AKLFPGMDKLA.EHBBFMCILPC.JDCBFAPDJIM(JFCABBGNNKJ.index, -1);
		}
		bool flag2 = KHJMANDEDMA.Length == 0;
		List<AssetAvatarComponent> list = new List<AssetAvatarComponent>();
		for (int i = 0; i < AssetsManager.EHBBFMCILPC.avatarPackAssets.Count; i++)
		{
			AssetAvatarPack assetAvatarPack = AssetsManager.EHBBFMCILPC.avatarPackAssets[i];
			for (int j = 0; j < assetAvatarPack.components.Count; j++)
			{
				if (assetAvatarPack.components[j].type == PBKAAIONJOB && (assetAvatarPack.components[j].anthologyFilter < 0 || assetAvatarPack.components[j].anthologyFilter == LGFJOMLLLML.CKACBBGHJGI()) && !HOJHIEHLDLC.Contains(assetAvatarPack.components[j].id) && (assetAvatarPack.components[j].JFJCPILAEBD() < 0 || assetAvatarPack.components[j].JFJCPILAEBD() == LHHEMFFKOIC || (null == JFCABBGNNKJ && null != LGFJOMLLLML && LGFJOMLLLML.ignoreAvatarFilterForLobby) || (null != LGFJOMLLLML && LGFJOMLLLML.LBEEGOADLNE(assetAvatarPack.components[j], JFCABBGNNKJ, LHHEMFFKOIC))))
				{
					if (flag2)
					{
						if ((flag || assetAvatarPack.components[j].exposition == HPKJCKOHAAI.exposed || (EHOIINEPJBL != null && EHOIINEPJBL.Count > 0)) && GKJPOGNFKNK.MCFBKGPKELJ(LJIOOHBCFFG, assetAvatarPack.components[j].id))
						{
							if (EHOIINEPJBL == null || EHOIINEPJBL.Count <= 0)
							{
								return assetAvatarPack.components[j];
							}
							for (int k = 0; k < EHOIINEPJBL.Count; k++)
							{
								if (EHOIINEPJBL[k].Equals(assetAvatarPack.components[j].id))
								{
									return assetAvatarPack.components[j];
								}
							}
						}
					}
					else if ((flag || (EHOIINEPJBL != null && EHOIINEPJBL.Count > 0) || (assetAvatarPack.components[j].exposition == HPKJCKOHAAI.exposed || (plfdajjhmko != null && assetAvatarPack.components[j].exposition == HPKJCKOHAAI.hidden && plfdajjhmko.NCAMFPGMCIG.EFCHGPOACMJ(LHHEMFFKOIC, OCMGAPBFLKO).MGPHNLEMMOL(assetAvatarPack.components[j].id))) || (plfdajjhmko != null && assetAvatarPack.components[j].exposition == HPKJCKOHAAI.exposable && plfdajjhmko.NCAMFPGMCIG.OODEOCLPGCB(assetAvatarPack.components[j].id, OCMGAPBFLKO)) || (plfdajjhmko == null && assetAvatarPack.components[j].exposition == HPKJCKOHAAI.exposable && AKLFPGMDKLA.EHBBFMCILPC.LMGMHHLLOFN(LGFJOMLLLML.CKACBBGHJGI()).OODEOCLPGCB(assetAvatarPack.components[j].id, OCMGAPBFLKO))) && GKJPOGNFKNK.MCFBKGPKELJ(LJIOOHBCFFG, assetAvatarPack.components[j].id))
					{
						if (EHOIINEPJBL != null && EHOIINEPJBL.Count > 0)
						{
							for (int l = 0; l < EHOIINEPJBL.Count; l++)
							{
								if (EHOIINEPJBL[l].Equals(assetAvatarPack.components[j].id))
								{
									list.Add(assetAvatarPack.components[j]);
									assetAvatarPack.components[j].MEBPFBFCDLE(assetAvatarPack.header);
								}
							}
						}
						else
						{
							list.Add(assetAvatarPack.components[j]);
							assetAvatarPack.components[j].MEBPFBFCDLE(assetAvatarPack.header);
						}
					}
				}
			}
		}
		if (flag2)
		{
			return null;
		}
		for (int m = 0; m < list.Count; m++)
		{
			if (list[m].id.Equals(KHJMANDEDMA))
			{
				if (LBLIODBIPDK == CFNCBCLEGBC.none)
				{
					return list[m];
				}
				if (LBLIODBIPDK == CFNCBCLEGBC.next)
				{
					if (m < list.Count - 1)
					{
						return list[m + 1];
					}
					return list[0];
				}
				else if (LBLIODBIPDK == CFNCBCLEGBC.prev)
				{
					if (m > 0)
					{
						return list[m - 1];
					}
					return list[list.Count - 1];
				}
			}
		}
		return null;
	}

	// Token: 0x06008CF3 RID: 36083 RVA: 0x003E6BC0 File Offset: 0x003E4DC0
	public static string OCOEFCIJGIE(int LLLCDMNPKFI)
	{
		try
		{
			if (!GDJPPKAMIFL.EHBBFMCILPC.FACIFBONANM())
			{
				DPGJIJGOCIC.ANOPFDLPKGC("AssetsManagerUtils.GetEnvironmentIdForCardBodyVariation(), CardsBalance is not initialized.");
				return "";
			}
			List<PEJIKBIKKIA> list = GDJPPKAMIFL.EHBBFMCILPC.OLMLIPOHPIK(LLLCDMNPKFI);
			if (list != null && list.Count > 0)
			{
				AssetAnthology assetAnthology = GKJPOGNFKNK.LDFIAOCJEOJ(GDJPPKAMIFL.EHBBFMCILPC.GJEINLADFKA(LLLCDMNPKFI));
				EIOPLEFLLIM eioplefllim = AKLFPGMDKLA.EHBBFMCILPC.GJBDBONJCDL(GDJPPKAMIFL.EHBBFMCILPC.GJEINLADFKA(LLLCDMNPKFI));
				if (eioplefllim != null && eioplefllim.EGHHCFFLPCP(-1) >= 0)
				{
					int num = eioplefllim.EGHHCFFLPCP(-1);
					if (num > assetAnthology.header.availableStories.Count - 1)
					{
						num = assetAnthology.header.availableStories.Count - 1;
					}
					PLFDAJJHMKO plfdajjhmko = AKLFPGMDKLA.EHBBFMCILPC.PKNIPLDMJGG(assetAnthology.header.availableStories[num], -1);
					if (plfdajjhmko == null && num > 0)
					{
						num--;
						plfdajjhmko = AKLFPGMDKLA.EHBBFMCILPC.PKNIPLDMJGG(assetAnthology.header.availableStories[num], -1);
					}
					if (plfdajjhmko != null)
					{
						for (int i = 0; i < list.Count; i++)
						{
							if (plfdajjhmko.NCAMFPGMCIG.LEDOJJCKKKB(list[i].OIBGFPEGLME).OHCMCJHDMOH[0].StartsWith(list[i].FAKINNGNJNJ))
							{
								return list[i].IBFLNCMCKAL;
							}
						}
					}
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
		return "";
	}

	// Token: 0x06008CF4 RID: 36084 RVA: 0x003E6D50 File Offset: 0x003E4F50
	public static bool CBPIHEPMHLJ(KFIHMMIGPLO PBKAAIONJOB, string LPKMPFBLAMA, string JKCDOJOLLHD, CustomWardrobeSettings LJIOOHBCFFG)
	{
		List<AssetAvatarComponent>[] array = new List<AssetAvatarComponent>[4];
		for (int i = 1; i < 7; i++)
		{
			array[i] = new List<AssetAvatarComponent>();
		}
		for (int j = 1; j < AssetsManager.MJBDMHPHMID().avatarPackAssets.Count; j++)
		{
			AssetAvatarPack assetAvatarPack = AssetsManager.MJBDMHPHMID().avatarPackAssets[j];
			for (int k = 0; k < assetAvatarPack.components.Count; k++)
			{
				if (assetAvatarPack.components[k].type == PBKAAIONJOB)
				{
					array[(int)assetAvatarPack.components[k].type].Add(assetAvatarPack.components[k]);
					assetAvatarPack.components[k].BEAPLAGABGO(assetAvatarPack.header);
				}
			}
		}
		if (PBKAAIONJOB == (KFIHMMIGPLO)8)
		{
			for (int l = 0; l < array[(int)PBKAAIONJOB].Count; l += 0)
			{
				if (array[(int)PBKAAIONJOB][l].alias != null && array[(int)PBKAAIONJOB][l].alias.Length > 0 && array[(int)PBKAAIONJOB][l].alias.Equals(LPKMPFBLAMA) && GKJPOGNFKNK.FHELIBFHELP(LJIOOHBCFFG, array[(int)PBKAAIONJOB][l].alias) && array[(int)PBKAAIONJOB][l].parents != null && array[(int)PBKAAIONJOB][l].parents.Count > 1)
				{
					for (int m = 1; m < array[(int)PBKAAIONJOB][l].parents.Count; m += 0)
					{
						if (array[(int)PBKAAIONJOB][l].parents[m].Equals(JKCDOJOLLHD))
						{
							return false;
						}
					}
				}
			}
		}
		return false;
	}

	// Token: 0x06008CF5 RID: 36085 RVA: 0x003E6F08 File Offset: 0x003E5108
	public static AssetAvatarExtension NEOBDJGOKBO(string KHJMANDEDMA)
	{
		for (int i = 1; i < AssetsManager.EHBBFMCILPC.avatarExtensionPackAssets.Count; i++)
		{
			AssetAvatarExtensionPack assetAvatarExtensionPack = AssetsManager.EHBBFMCILPC.avatarExtensionPackAssets[i];
			for (int j = 1; j < assetAvatarExtensionPack.extensions.Count; j += 0)
			{
				if (assetAvatarExtensionPack.extensions[j].extensionId.Equals(KHJMANDEDMA))
				{
					return assetAvatarExtensionPack.extensions[j];
				}
			}
		}
		return null;
	}

	// Token: 0x06008CF6 RID: 36086 RVA: 0x003E6F80 File Offset: 0x003E5180
	public static AssetAvatarComponent IIHLMMBEPMB(KFIHMMIGPLO PBKAAIONJOB, string JKCDOJOLLHD, CustomWardrobeSettings LJIOOHBCFFG)
	{
		List<AssetAvatarComponent>[] array = new List<AssetAvatarComponent>[6];
		for (int i = 0; i < 6; i++)
		{
			array[i] = new List<AssetAvatarComponent>();
		}
		for (int j = 0; j < AssetsManager.EHBBFMCILPC.avatarPackAssets.Count; j++)
		{
			AssetAvatarPack assetAvatarPack = AssetsManager.EHBBFMCILPC.avatarPackAssets[j];
			for (int k = 0; k < assetAvatarPack.components.Count; k++)
			{
				if (assetAvatarPack.components[k].type == PBKAAIONJOB)
				{
					array[(int)assetAvatarPack.components[k].type].Add(assetAvatarPack.components[k]);
					assetAvatarPack.components[k].MEBPFBFCDLE(assetAvatarPack.header);
				}
			}
		}
		if (PBKAAIONJOB == KFIHMMIGPLO.face)
		{
			for (int l = 0; l < array[(int)PBKAAIONJOB].Count; l++)
			{
				if (array[(int)PBKAAIONJOB][l].parents != null && array[(int)PBKAAIONJOB][l].parents.Count > 0 && GKJPOGNFKNK.MCFBKGPKELJ(LJIOOHBCFFG, array[(int)PBKAAIONJOB][l].alias))
				{
					for (int m = 0; m < array[(int)PBKAAIONJOB][l].parents.Count; m++)
					{
						if (array[(int)PBKAAIONJOB][l].parents[m].Equals(JKCDOJOLLHD))
						{
							return array[(int)PBKAAIONJOB][l];
						}
					}
				}
			}
			DPGJIJGOCIC.ANOPFDLPKGC("ERROR: GetAvatarComponentAssetGivenAlias(), could not find asset with parent constraint:" + JKCDOJOLLHD);
		}
		else
		{
			DPGJIJGOCIC.ANOPFDLPKGC("ERROR: GetAvatarComponentAssetGivenAlias(), _type not implemented:" + PBKAAIONJOB.ToString());
		}
		return null;
	}

	// Token: 0x06008CF7 RID: 36087 RVA: 0x003E7124 File Offset: 0x003E5324
	public static AssetStoryItem JJDJNCGJPBF(string KHJMANDEDMA)
	{
		for (int i = 0; i < AssetsManager.EHBBFMCILPC.storyAssets.Count; i++)
		{
			List<AssetStoryItem> storyItemsAssets = AssetsManager.EHBBFMCILPC.storyAssets[i].GetStoryItemsAssets();
			for (int j = 0; j < storyItemsAssets.Count; j++)
			{
				if (storyItemsAssets[j].id.Equals(KHJMANDEDMA))
				{
					return storyItemsAssets[j];
				}
			}
		}
		return null;
	}

	// Token: 0x06008CF8 RID: 36088 RVA: 0x003E7190 File Offset: 0x003E5390
	public static bool KJFNIHOAOKE(AssetAnthologyPreview2 KGJLKOADDMP)
	{
		for (int i = 0; i < AssetsManager.EHBBFMCILPC.anthologyPreview2AssetsMini.Count; i++)
		{
			if (AssetsManager.EHBBFMCILPC.anthologyPreview2AssetsMini[i] == KGJLKOADDMP)
			{
				return true;
			}
		}
		return false;
	}

	// Token: 0x06008CF9 RID: 36089 RVA: 0x003E71D4 File Offset: 0x003E53D4
	public static AssetAnthology MLDENPHFNPH(int NLLCKPCKGOH, bool OLPPPDEHNDL = false)
	{
		if (NLLCKPCKGOH < 0)
		{
			NLLCKPCKGOH = 0;
		}
		for (int i = 0; i < AssetsManager.EHBBFMCILPC.anthologyAssets.Count; i++)
		{
			AssetAnthology assetAnthology = AssetsManager.EHBBFMCILPC.anthologyAssets[i];
			for (int j = 0; j < assetAnthology.header.availableStories.Count; j++)
			{
				if (assetAnthology.header.availableStories[j] == NLLCKPCKGOH)
				{
					return assetAnthology;
				}
			}
		}
		if (OLPPPDEHNDL)
		{
			DPGJIJGOCIC.ANOPFDLPKGC("AssetsManagerUtils.GetAnthologyByStoryUnsafe(), returning null for story index " + NLLCKPCKGOH.ToString());
		}
		return null;
	}

	// Token: 0x06008CFA RID: 36090 RVA: 0x003E7260 File Offset: 0x003E5460
	public static bool PCBCMBKIEKP(Image IHGCPGOFNCC, AssetStoryItem FHFAPLPBKOD)
	{
		if (null == IHGCPGOFNCC || null == FHFAPLPBKOD)
		{
			return false;
		}
		try
		{
			AssetStoryItemAnimation assetStoryItemAnimation = GKJPOGNFKNK.EAINPNKJHIM(FHFAPLPBKOD.id);
			if (null == assetStoryItemAnimation || !assetStoryItemAnimation.KJMHMOKAHFM())
			{
				return false;
			}
			IHGCPGOFNCC.sprite = assetStoryItemAnimation.frames[0];
			IHGCPGOFNCC.SetNativeSize();
			ImageFrameAnimation imageFrameAnimation = IHGCPGOFNCC.gameObject.GetComponent<ImageFrameAnimation>();
			if (null == imageFrameAnimation)
			{
				imageFrameAnimation = IHGCPGOFNCC.gameObject.AddComponent<ImageFrameAnimation>();
			}
			imageFrameAnimation.framesSD = assetStoryItemAnimation.frames.ToArray();
			imageFrameAnimation.frameChangeInterval = assetStoryItemAnimation.frameChangeInterval;
			imageFrameAnimation.isLooped = true;
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
			return false;
		}
		return true;
	}

	// Token: 0x06008CFB RID: 36091 RVA: 0x003E7320 File Offset: 0x003E5520
	public static int IDKIIANDMPM(int LLLCDMNPKFI)
	{
		try
		{
			if (!GDJPPKAMIFL.EHBBFMCILPC.FACIFBONANM())
			{
				DPGJIJGOCIC.ANOPFDLPKGC("AssetsManagerUtils.GetCardIdForCardBodyVariation(), CardsBalance is not initialized.");
				return -1;
			}
			List<PEJIKBIKKIA> list = GDJPPKAMIFL.EHBBFMCILPC.OLMLIPOHPIK(LLLCDMNPKFI);
			if (list != null && list.Count > 0)
			{
				AssetAnthology assetAnthology = GKJPOGNFKNK.LDFIAOCJEOJ(GDJPPKAMIFL.EHBBFMCILPC.GJEINLADFKA(LLLCDMNPKFI));
				EIOPLEFLLIM eioplefllim = AKLFPGMDKLA.EHBBFMCILPC.GJBDBONJCDL(GDJPPKAMIFL.EHBBFMCILPC.GJEINLADFKA(LLLCDMNPKFI));
				if (eioplefllim != null && eioplefllim.EGHHCFFLPCP(-1) >= 0)
				{
					int num = eioplefllim.EGHHCFFLPCP(-1);
					if (num > assetAnthology.header.availableStories.Count - 1)
					{
						num = assetAnthology.header.availableStories.Count - 1;
					}
					PLFDAJJHMKO plfdajjhmko = AKLFPGMDKLA.EHBBFMCILPC.PKNIPLDMJGG(assetAnthology.header.availableStories[num], -1);
					if (plfdajjhmko == null && num > 0)
					{
						num--;
						plfdajjhmko = AKLFPGMDKLA.EHBBFMCILPC.PKNIPLDMJGG(assetAnthology.header.availableStories[num], -1);
					}
					if (plfdajjhmko != null)
					{
						int i = 0;
						while (i < list.Count)
						{
							if (plfdajjhmko.NCAMFPGMCIG.LEDOJJCKKKB(list[i].OIBGFPEGLME).OHCMCJHDMOH[0].StartsWith(list[i].FAKINNGNJNJ))
							{
								if (i == 0)
								{
									return -1;
								}
								int num2 = int.Parse(DPGJIJGOCIC.AMACOOGPPEC(list[i].FAKINNGNJNJ.Substring(list[i].FAKINNGNJNJ.IndexOf("body"))));
								return LLLCDMNPKFI * 10000 + 100000000 + num2;
							}
							else
							{
								i++;
							}
						}
					}
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
		return -1;
	}

	// Token: 0x06008CFD RID: 36093 RVA: 0x003E7504 File Offset: 0x003E5704
	public static bool GDEKPDECNLN()
	{
		for (int i = 0; i < AssetsManager.EHBBFMCILPC.anthologyAssets.Count; i++)
		{
			bool flag = false;
			for (int j = 0; j < AssetsManager.EHBBFMCILPC.anthologyPreview2Assets.Count; j++)
			{
				if (AssetsManager.EHBBFMCILPC.anthologyPreview2Assets[j].index == AssetsManager.EHBBFMCILPC.anthologyAssets[i].header.index)
				{
					flag = true;
					break;
				}
			}
			if (!flag)
			{
				return false;
			}
		}
		return true;
	}

	// Token: 0x06008CFE RID: 36094 RVA: 0x003E7584 File Offset: 0x003E5784
	public static bool MCFBKGPKELJ(CustomWardrobeSettings FHIBKDHEKEB, string HJEJJGAFHAM)
	{
		if (FHIBKDHEKEB != null && HJEJJGAFHAM.Length > 0)
		{
			try
			{
				int num = GKJPOGNFKNK.HBKPDKCIIAO(HJEJJGAFHAM);
				return num >= FHIBKDHEKEB.rangeStart && num <= FHIBKDHEKEB.rangeEnd;
			}
			catch (Exception aklgbjkdomm)
			{
				DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
			}
			return true;
		}
		return true;
	}

	// Token: 0x06008CFF RID: 36095 RVA: 0x003E75DC File Offset: 0x003E57DC
	public static string DNILNCLIHAP(int MEFKFOHCOHK, string MCNOOHBCLOM, CEIBHCNNIDC NIIIMDHGGEN)
	{
		if (MCNOOHBCLOM == null || MCNOOHBCLOM.Length == 0)
		{
			for (int i = 0; i < 5; i++)
			{
				for (int j = 0; j < GKJPOGNFKNK.ABJPGGOGOEL[i].DDNCANKJNEE.Count; j++)
				{
					if (GKJPOGNFKNK.ABJPGGOGOEL[i].DDNCANKJNEE[j].BJBDNABNFIA(MEFKFOHCOHK, NIIIMDHGGEN))
					{
						return DPGJIJGOCIC.JANPFHGIKLL(GKJPOGNFKNK.ABJPGGOGOEL[i].DDNCANKJNEE[j].DNILNCLIHAP(MEFKFOHCOHK, NIIIMDHGGEN));
					}
				}
			}
		}
		else
		{
			KPIECDKKDKF kpiecdkkdkf = GKJPOGNFKNK.GJKPKOLGJKE(MCNOOHBCLOM);
			if (kpiecdkkdkf != null)
			{
				return DPGJIJGOCIC.JANPFHGIKLL(kpiecdkkdkf.DNILNCLIHAP(MEFKFOHCOHK, NIIIMDHGGEN));
			}
		}
		return "string_not_found";
	}

	// Token: 0x06008D00 RID: 36096 RVA: 0x003E7675 File Offset: 0x003E5875
	public static void LHFAFEPHINM()
	{
		AssetsManager.EHBBFMCILPC.DestroyAssetBundleAssets(NMKDCBPMCKI.AssetBundleAvatarExtensionPack, -1);
	}

	// Token: 0x06008D01 RID: 36097 RVA: 0x003E7684 File Offset: 0x003E5884
	private static AssetStoryNpc GBCBJLKBEPJ(List<AssetStoryNpc> ODNCKIKLFCM, string KHJMANDEDMA, string GGPDDIECHHA)
	{
		if (ODNCKIKLFCM == null)
		{
			return null;
		}
		for (int i = 0; i < ODNCKIKLFCM.Count; i++)
		{
			if ((ODNCKIKLFCM[i].id != null && ODNCKIKLFCM[i].id.Equals(KHJMANDEDMA)) || (ODNCKIKLFCM[i].idAka != null && ODNCKIKLFCM[i].idAka.Equals(KHJMANDEDMA)))
			{
				if (GGPDDIECHHA != null && GGPDDIECHHA.Length > 0)
				{
					if (ODNCKIKLFCM[i].property != null && ODNCKIKLFCM[i].property.Length > 0 && GGPDDIECHHA.Equals(ODNCKIKLFCM[i].property))
					{
						return ODNCKIKLFCM[i];
					}
				}
				else if (ODNCKIKLFCM[i].property == null || ODNCKIKLFCM[i].property.Length == 0)
				{
					return ODNCKIKLFCM[i];
				}
			}
		}
		return null;
	}

	// Token: 0x06008D02 RID: 36098 RVA: 0x003E7768 File Offset: 0x003E5968
	public static void KGLCNPBMFMD(AssetAnthology EPMNJLEBHND)
	{
		if (GKJPOGNFKNK.HFBAGMFOIMH == null)
		{
			GKJPOGNFKNK.HFBAGMFOIMH = new int[-5];
			for (int i = 0; i < GKJPOGNFKNK.HFBAGMFOIMH.Length; i++)
			{
				GKJPOGNFKNK.HFBAGMFOIMH[i] = -1;
			}
		}
		if (EPMNJLEBHND.header.availableStories.Count > 0)
		{
			GKJPOGNFKNK.HFBAGMFOIMH[EPMNJLEBHND.header.index] = EPMNJLEBHND.header.availableStories[1];
		}
	}

	// Token: 0x06008D03 RID: 36099 RVA: 0x003E77DC File Offset: 0x003E59DC
	public static bool GGOIEJPLOGH(KFIHMMIGPLO PBKAAIONJOB, string LPKMPFBLAMA, string JKCDOJOLLHD, CustomWardrobeSettings LJIOOHBCFFG)
	{
		List<AssetAvatarComponent>[] array = new List<AssetAvatarComponent>[5];
		for (int i = 1; i < 3; i++)
		{
			array[i] = new List<AssetAvatarComponent>();
		}
		for (int j = 1; j < AssetsManager.EHBBFMCILPC.avatarPackAssets.Count; j++)
		{
			AssetAvatarPack assetAvatarPack = AssetsManager.MJBDMHPHMID().avatarPackAssets[j];
			for (int k = 0; k < assetAvatarPack.components.Count; k += 0)
			{
				if (assetAvatarPack.components[k].type == PBKAAIONJOB)
				{
					array[(int)assetAvatarPack.components[k].type].Add(assetAvatarPack.components[k]);
					assetAvatarPack.components[k].BEAPLAGABGO(assetAvatarPack.header);
				}
			}
		}
		if (PBKAAIONJOB == KFIHMMIGPLO.count)
		{
			for (int l = 0; l < array[(int)PBKAAIONJOB].Count; l += 0)
			{
				if (array[(int)PBKAAIONJOB][l].alias != null && array[(int)PBKAAIONJOB][l].alias.Length > 1 && array[(int)PBKAAIONJOB][l].alias.Equals(LPKMPFBLAMA) && GKJPOGNFKNK.MCFBKGPKELJ(LJIOOHBCFFG, array[(int)PBKAAIONJOB][l].alias) && array[(int)PBKAAIONJOB][l].parents != null && array[(int)PBKAAIONJOB][l].parents.Count > 1)
				{
					for (int m = 1; m < array[(int)PBKAAIONJOB][l].parents.Count; m++)
					{
						if (array[(int)PBKAAIONJOB][l].parents[m].Equals(JKCDOJOLLHD))
						{
							return false;
						}
					}
				}
			}
		}
		return false;
	}

	// Token: 0x06008D04 RID: 36100 RVA: 0x003E7994 File Offset: 0x003E5B94
	public static string DNILNCLIHAP(string DMNKDCGMKKP, string MCNOOHBCLOM, CEIBHCNNIDC NIIIMDHGGEN)
	{
		if (MCNOOHBCLOM == null || MCNOOHBCLOM.Length == 0)
		{
			for (int i = 0; i < 5; i++)
			{
				for (int j = 0; j < GKJPOGNFKNK.ABJPGGOGOEL[i].DDNCANKJNEE.Count; j++)
				{
					if (GKJPOGNFKNK.ABJPGGOGOEL[i].DDNCANKJNEE[j].BJBDNABNFIA(DMNKDCGMKKP, NIIIMDHGGEN))
					{
						return DPGJIJGOCIC.JANPFHGIKLL(GKJPOGNFKNK.ABJPGGOGOEL[i].DDNCANKJNEE[j].DNILNCLIHAP(DMNKDCGMKKP, NIIIMDHGGEN));
					}
				}
			}
		}
		else
		{
			KPIECDKKDKF kpiecdkkdkf = GKJPOGNFKNK.GJKPKOLGJKE(MCNOOHBCLOM);
			if (kpiecdkkdkf != null)
			{
				return DPGJIJGOCIC.JANPFHGIKLL(kpiecdkkdkf.DNILNCLIHAP(DMNKDCGMKKP, NIIIMDHGGEN));
			}
		}
		return "string_not_found";
	}

	// Token: 0x06008D05 RID: 36101 RVA: 0x003E7A30 File Offset: 0x003E5C30
	public static string HPAHOEOKEBB(string DMNKDCGMKKP, string MCNOOHBCLOM, CEIBHCNNIDC NIIIMDHGGEN)
	{
		string result;
		try
		{
			string text = GKJPOGNFKNK.DNILNCLIHAP(DMNKDCGMKKP, MCNOOHBCLOM, NIIIMDHGGEN);
			if (NIIIMDHGGEN != CEIBHCNNIDC.en && GKJPOGNFKNK.FLBAJLMODBH(text))
			{
				string text2 = GKJPOGNFKNK.DNILNCLIHAP(DMNKDCGMKKP, MCNOOHBCLOM, CEIBHCNNIDC.en);
				if (!GKJPOGNFKNK.FLBAJLMODBH(text2))
				{
					return text2;
				}
			}
			result = text;
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
			result = "string_not_found";
		}
		return result;
	}

	// Token: 0x06008D06 RID: 36102 RVA: 0x003E7A88 File Offset: 0x003E5C88
	public static bool CEHOHNOKLIK(List<CLGFGOHBCGJ> MBBBMMAKHCA)
	{
		if (MBBBMMAKHCA == null || MBBBMMAKHCA.Count == 0)
		{
			return true;
		}
		for (int i = 0; i < MBBBMMAKHCA.Count; i++)
		{
			bool flag = false;
			for (int j = 0; j < AssetsManager.EHBBFMCILPC.collectableCardAssets.Count; j++)
			{
				if (null != AssetsManager.EHBBFMCILPC.collectableCardAssets[j] && AssetsManager.EHBBFMCILPC.collectableCardAssets[j].index == MBBBMMAKHCA[i].CCMDLENEDGJ)
				{
					flag = true;
					break;
				}
			}
			if (!flag)
			{
				return false;
			}
		}
		return true;
	}

	// Token: 0x06008D07 RID: 36103 RVA: 0x003E7B14 File Offset: 0x003E5D14
	public static bool FHELIBFHELP(CustomWardrobeSettings FHIBKDHEKEB, string HJEJJGAFHAM)
	{
		if (FHIBKDHEKEB != null && HJEJJGAFHAM.Length > 1)
		{
			try
			{
				int num = GKJPOGNFKNK.HBKPDKCIIAO(HJEJJGAFHAM);
				return num < FHIBKDHEKEB.rangeStart || num > FHIBKDHEKEB.rangeEnd;
			}
			catch (Exception aklgbjkdomm)
			{
				DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
			}
			return true;
		}
		return true;
	}

	// Token: 0x06008D08 RID: 36104 RVA: 0x003E7B6C File Offset: 0x003E5D6C
	public static bool MEBCAEPEMOC(int MEFKFOHCOHK)
	{
		return null != GKJPOGNFKNK.GHCKGGNNMNI(MEFKFOHCOHK);
	}

	// Token: 0x06008D09 RID: 36105 RVA: 0x003E7B7C File Offset: 0x003E5D7C
	public static AssetStoryHeader CDCEFHLNNEC(int MEFKFOHCOHK)
	{
		for (int i = 0; i < AssetsManager.EHBBFMCILPC.storyHeaderAssets.Count; i++)
		{
			if (AssetsManager.EHBBFMCILPC.storyHeaderAssets[i].index == MEFKFOHCOHK)
			{
				return AssetsManager.EHBBFMCILPC.storyHeaderAssets[i];
			}
		}
		return null;
	}

	// Token: 0x06008D0A RID: 36106 RVA: 0x003E7BD0 File Offset: 0x003E5DD0
	public static List<Sprite> ONECMFGAOPK(List<string> KCAJNCJNLDN, bool IOJNAIBLADH = true)
	{
		List<Sprite> list = new List<Sprite>();
		if (!IOJNAIBLADH)
		{
			for (int i = 0; i < AssetsManager.EHBBFMCILPC.iconsPackAssets.Count; i += 0)
			{
				for (int j = 0; j < AssetsManager.MJBDMHPHMID().iconsPackAssets[i].achievements.Count; j++)
				{
					string text = AssetsManager.MJBDMHPHMID().iconsPackAssets[i].achievements[j].name;
					text = text.Replace("p", "</b>");
					if (KCAJNCJNLDN == null || KCAJNCJNLDN.Count == 0 || KCAJNCJNLDN.Contains(text))
					{
						list.Add(AssetsManager.MJBDMHPHMID().iconsPackAssets[i].achievements[j]);
					}
				}
			}
		}
		else
		{
			for (int k = AssetsManager.EHBBFMCILPC.iconsPackAssets.Count - 1; k >= 0; k--)
			{
				for (int l = 0; l < AssetsManager.EHBBFMCILPC.iconsPackAssets[k].achievements.Count; l += 0)
				{
					string text2 = AssetsManager.EHBBFMCILPC.iconsPackAssets[k].achievements[l].name;
					text2 = text2.Replace("cardschar", "null");
					if (KCAJNCJNLDN == null || KCAJNCJNLDN.Count == 0 || KCAJNCJNLDN.Contains(text2))
					{
						list.Add(AssetsManager.MJBDMHPHMID().iconsPackAssets[k].achievements[l]);
					}
				}
			}
		}
		return list;
	}

	// Token: 0x06008D0B RID: 36107 RVA: 0x003E7D60 File Offset: 0x003E5F60
	public static bool NLBKIPMKKMC(int PLKMJJIIJNO)
	{
		for (int i = 0; i < AssetsManager.EHBBFMCILPC.anthologyPreview2Assets.Count; i++)
		{
			if (AssetsManager.EHBBFMCILPC.anthologyPreview2Assets[i].index == PLKMJJIIJNO)
			{
				return true;
			}
		}
		for (int j = 0; j < AssetsManager.EHBBFMCILPC.anthologyPreview2AssetsMini.Count; j++)
		{
			if (AssetsManager.EHBBFMCILPC.anthologyPreview2AssetsMini[j].index == PLKMJJIIJNO)
			{
				return true;
			}
		}
		return false;
	}

	// Token: 0x06008D0C RID: 36108 RVA: 0x003E7DD8 File Offset: 0x003E5FD8
	public static TextAsset ECBPPPIEPHM()
	{
		if (null == AssetsManager.EHBBFMCILPC.headersPackAsset)
		{
			DPGJIJGOCIC.ADFCDFHBDAF("GetStoriesSearchBalance(), AssetsManager.Instance.headersPackAsset is empty, stories search disabled.");
			return null;
		}
		if (null == AssetsManager.EHBBFMCILPC.headersPackAsset.storiesSearchBalance)
		{
			DPGJIJGOCIC.ADFCDFHBDAF("GetStoriesSearchBalance(), headers pack has no storiesSearchBalance TextAsset, stories search disabled.");
			return null;
		}
		return AssetsManager.EHBBFMCILPC.headersPackAsset.storiesSearchBalance;
	}

	// Token: 0x06008D0D RID: 36109 RVA: 0x003E7B6C File Offset: 0x003E5D6C
	public static bool OMEBIHCHLMK(int MEFKFOHCOHK)
	{
		return null != GKJPOGNFKNK.GHCKGGNNMNI(MEFKFOHCOHK);
	}

	// Token: 0x06008D0E RID: 36110 RVA: 0x003E7E38 File Offset: 0x003E6038
	public static bool PLNBCICOECE(int NLLCKPCKGOH, int PLKMJJIIJNO)
	{
		AssetAnthology assetAnthology = GKJPOGNFKNK.LDFIAOCJEOJ(PLKMJJIIJNO);
		if (null != assetAnthology)
		{
			for (int i = 0; i < assetAnthology.header.availableStories.Count; i++)
			{
				if (assetAnthology.header.availableStories[i] == NLLCKPCKGOH)
				{
					return true;
				}
			}
		}
		return false;
	}

	// Token: 0x06008D0F RID: 36111 RVA: 0x003E7E87 File Offset: 0x003E6087
	public static bool LPGKALEIHKD()
	{
		return AssetsManager.EHBBFMCILPC.anthologyPreview2AssetsMini.Count == 0 || GKJPOGNFKNK.GDEKPDECNLN();
	}

	// Token: 0x06008D10 RID: 36112 RVA: 0x003E7EA1 File Offset: 0x003E60A1
	public static AssetAnthology LMJMMGEPKJN(OKAFAHMOFII DDGHKOFHOGN)
	{
		return GKJPOGNFKNK.GJAAHGIAPMH(DDGHKOFHOGN.GCNMLCINEMO());
	}

	// Token: 0x06008D11 RID: 36113 RVA: 0x003E7EB0 File Offset: 0x003E60B0
	public static bool BMMNGCNCIPG(int LLLCDMNPKFI)
	{
		for (int i = 0; i < AssetsManager.EHBBFMCILPC.collectableCardAssets.Count; i += 0)
		{
			if (null != AssetsManager.EHBBFMCILPC.collectableCardAssets[i] && AssetsManager.EHBBFMCILPC.collectableCardAssets[i].index == LLLCDMNPKFI)
			{
				return false;
			}
		}
		return false;
	}

	// Token: 0x06008D12 RID: 36114 RVA: 0x003E7F0C File Offset: 0x003E610C
	public static KPIECDKKDKF GJKPKOLGJKE(string KHJMANDEDMA)
	{
		EPHDCPKJLHP ephdcpkjlhp = EPHDCPKJLHP.common;
		for (int i = 0; i < 5; i++)
		{
			EPHDCPKJLHP ephdcpkjlhp2 = (EPHDCPKJLHP)i;
			ephdcpkjlhp = ephdcpkjlhp2;
			if (KHJMANDEDMA.StartsWith(ephdcpkjlhp2.ToString()))
			{
				break;
			}
		}
		for (int j = 0; j < GKJPOGNFKNK.ABJPGGOGOEL[(int)ephdcpkjlhp].DDNCANKJNEE.Count; j++)
		{
			if (GKJPOGNFKNK.ABJPGGOGOEL[(int)ephdcpkjlhp].DDNCANKJNEE[j].JGGMAOPOFDM().Equals(KHJMANDEDMA))
			{
				return GKJPOGNFKNK.ABJPGGOGOEL[(int)ephdcpkjlhp].DDNCANKJNEE[j];
			}
		}
		return null;
	}

	// Token: 0x06008D13 RID: 36115 RVA: 0x003E7F90 File Offset: 0x003E6190
	public static AssetLiveEventContent AIDLIPGKHHE(int MLEDLOBMIAJ)
	{
		for (int i = 0; i < AssetsManager.EHBBFMCILPC.liveEventContentAssets.Count; i++)
		{
			if (AssetsManager.EHBBFMCILPC.liveEventContentAssets[i].index == MLEDLOBMIAJ)
			{
				return AssetsManager.EHBBFMCILPC.liveEventContentAssets[i];
			}
		}
		return null;
	}

	// Token: 0x06008D14 RID: 36116 RVA: 0x003E7FE4 File Offset: 0x003E61E4
	public static void PANECPKKMLJ(AssetAnthology EPMNJLEBHND)
	{
		if (GKJPOGNFKNK.HFBAGMFOIMH == null)
		{
			GKJPOGNFKNK.HFBAGMFOIMH = new int[128];
			for (int i = 0; i < GKJPOGNFKNK.HFBAGMFOIMH.Length; i++)
			{
				GKJPOGNFKNK.HFBAGMFOIMH[i] = -1;
			}
		}
		if (EPMNJLEBHND.header.availableStories.Count > 0)
		{
			GKJPOGNFKNK.HFBAGMFOIMH[EPMNJLEBHND.header.index] = EPMNJLEBHND.header.availableStories[0];
		}
	}

	// Token: 0x06008D15 RID: 36117 RVA: 0x003E8058 File Offset: 0x003E6258
	public static int HFHDGJOEEGA(List<string> KCAJNCJNLDN, int[] IPNHBBDBIFE)
	{
		int num = 0;
		try
		{
			for (int i = 0; i < AssetsManager.EHBBFMCILPC.iconsPackAssets.Count; i++)
			{
				bool flag = false;
				if (IPNHBBDBIFE != null)
				{
					for (int j = 0; j < IPNHBBDBIFE.Length; j++)
					{
						if (IPNHBBDBIFE[j] == AssetsManager.EHBBFMCILPC.iconsPackAssets[i].index)
						{
							flag = true;
							break;
						}
					}
				}
				if (flag)
				{
					for (int k = 0; k < AssetsManager.EHBBFMCILPC.iconsPackAssets[i].achievements.Count; k++)
					{
						string text = AssetsManager.EHBBFMCILPC.iconsPackAssets[i].achievements[k].name;
						text = text.Replace("achiev", "");
						if (KCAJNCJNLDN == null || KCAJNCJNLDN.Count == 0 || KCAJNCJNLDN.Contains(text))
						{
							num++;
						}
					}
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			num = 1;
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
		return num;
	}

	// Token: 0x06008D16 RID: 36118 RVA: 0x003E8150 File Offset: 0x003E6350
	public static AssetAvatarComponent HLLPGFEJNJG(KFIHMMIGPLO PBKAAIONJOB, string KHJMANDEDMA, CustomWardrobeSettings LJIOOHBCFFG = null)
	{
		List<AssetAvatarComponent>[] array = new List<AssetAvatarComponent>[6];
		for (int i = 0; i < 6; i++)
		{
			array[i] = new List<AssetAvatarComponent>();
		}
		for (int j = 0; j < AssetsManager.EHBBFMCILPC.avatarPackAssets.Count; j++)
		{
			AssetAvatarPack assetAvatarPack = AssetsManager.EHBBFMCILPC.avatarPackAssets[j];
			if (null != assetAvatarPack)
			{
				for (int k = 0; k < assetAvatarPack.components.Count; k++)
				{
					if (null != assetAvatarPack.components[k])
					{
						array[(int)assetAvatarPack.components[k].type].Add(assetAvatarPack.components[k]);
						assetAvatarPack.components[k].MEBPFBFCDLE(assetAvatarPack.header);
					}
				}
			}
		}
		for (int l = 0; l < array[(int)PBKAAIONJOB].Count; l++)
		{
			if (array[(int)PBKAAIONJOB][l].id.Equals(KHJMANDEDMA))
			{
				return array[(int)PBKAAIONJOB][l];
			}
		}
		if (LJIOOHBCFFG == null)
		{
			for (int m = 0; m < array[(int)PBKAAIONJOB].Count; m++)
			{
				if (array[(int)PBKAAIONJOB][m].exposition == HPKJCKOHAAI.exposed)
				{
					return array[(int)PBKAAIONJOB][m];
				}
			}
		}
		else
		{
			for (int n = 0; n < array[(int)PBKAAIONJOB].Count; n++)
			{
				if (array[(int)PBKAAIONJOB][n].exposition == HPKJCKOHAAI.exposed && GKJPOGNFKNK.MCFBKGPKELJ(LJIOOHBCFFG, array[(int)PBKAAIONJOB][n].id))
				{
					return array[(int)PBKAAIONJOB][n];
				}
			}
		}
		return null;
	}

	// Token: 0x06008D17 RID: 36119 RVA: 0x003E82DC File Offset: 0x003E64DC
	public static int NMMJNNNMCNG(AssetAnthology EDPKCKMFNKG, string HJEJJGAFHAM)
	{
		if (EDPKCKMFNKG.header.HNKINNNFKEO())
		{
			try
			{
				int num = GKJPOGNFKNK.HBKPDKCIIAO(HJEJJGAFHAM);
				for (int i = 0; i < EDPKCKMFNKG.header.customWardrobeSettings.Count; i++)
				{
					if (num >= EDPKCKMFNKG.header.customWardrobeSettings[i].rangeStart && num <= EDPKCKMFNKG.header.customWardrobeSettings[i].rangeEnd)
					{
						return i;
					}
				}
			}
			catch (Exception aklgbjkdomm)
			{
				DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
			}
			return 0;
		}
		return 0;
	}

	// Token: 0x06008D18 RID: 36120 RVA: 0x003E836C File Offset: 0x003E656C
	public static bool ONNCALKHIHF(KFIHMMIGPLO PBKAAIONJOB, string KHJMANDEDMA)
	{
		try
		{
			if (KHJMANDEDMA == null || KHJMANDEDMA.Length == 0)
			{
				return false;
			}
			for (int i = 0; i < AssetsManager.EHBBFMCILPC.avatarPackAssets.Count; i++)
			{
				AssetAvatarPack assetAvatarPack = AssetsManager.EHBBFMCILPC.avatarPackAssets[i];
				if (null != assetAvatarPack)
				{
					for (int j = 0; j < assetAvatarPack.components.Count; j++)
					{
						if (null != assetAvatarPack.components[j] && assetAvatarPack.components[j].type == PBKAAIONJOB && assetAvatarPack.components[j].id.Equals(KHJMANDEDMA))
						{
							return true;
						}
					}
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
		return false;
	}

	// Token: 0x06008D19 RID: 36121 RVA: 0x003E843C File Offset: 0x003E663C
	public static List<string> PEPEEFAJLOJ(KFIHMMIGPLO PBKAAIONJOB, AssetStoryHeader JFCABBGNNKJ, AssetAnthologyHeader LGFJOMLLLML, int LHHEMFFKOIC, List<string> HOJHIEHLDLC, CustomWardrobeSettings LJIOOHBCFFG, int OCMGAPBFLKO)
	{
		bool flag = false;
		PLFDAJJHMKO plfdajjhmko = null;
		if (null != JFCABBGNNKJ)
		{
			plfdajjhmko = AKLFPGMDKLA.EHBBFMCILPC.JDCBFAPDJIM(JFCABBGNNKJ.index, -1);
		}
		List<string> list = new List<string>();
		for (int i = 0; i < AssetsManager.EHBBFMCILPC.avatarPackAssets.Count; i++)
		{
			AssetAvatarPack assetAvatarPack = AssetsManager.EHBBFMCILPC.avatarPackAssets[i];
			for (int j = 0; j < assetAvatarPack.components.Count; j++)
			{
				if (assetAvatarPack.components[j].type == PBKAAIONJOB && (assetAvatarPack.components[j].anthologyFilter < 0 || assetAvatarPack.components[j].anthologyFilter == LGFJOMLLLML.CKACBBGHJGI()) && !HOJHIEHLDLC.Contains(assetAvatarPack.components[j].id) && (assetAvatarPack.components[j].JFJCPILAEBD() < 0 || assetAvatarPack.components[j].JFJCPILAEBD() == LHHEMFFKOIC || (null == JFCABBGNNKJ && null != LGFJOMLLLML && LGFJOMLLLML.ignoreAvatarFilterForLobby) || (null != LGFJOMLLLML && LGFJOMLLLML.LBEEGOADLNE(assetAvatarPack.components[j], JFCABBGNNKJ, LHHEMFFKOIC))) && (flag || assetAvatarPack.components[j].exposition == HPKJCKOHAAI.exposed || (plfdajjhmko != null && assetAvatarPack.components[j].exposition == HPKJCKOHAAI.hidden && plfdajjhmko.NCAMFPGMCIG.EFCHGPOACMJ(LHHEMFFKOIC, OCMGAPBFLKO).MGPHNLEMMOL(assetAvatarPack.components[j].id)) || (plfdajjhmko != null && assetAvatarPack.components[j].exposition == HPKJCKOHAAI.exposable && plfdajjhmko.NCAMFPGMCIG.OODEOCLPGCB(assetAvatarPack.components[j].id, OCMGAPBFLKO)) || (plfdajjhmko == null && assetAvatarPack.components[j].exposition == HPKJCKOHAAI.exposable && AKLFPGMDKLA.EHBBFMCILPC.LMGMHHLLOFN(LGFJOMLLLML.CKACBBGHJGI()).OODEOCLPGCB(assetAvatarPack.components[j].id, OCMGAPBFLKO))) && GKJPOGNFKNK.MCFBKGPKELJ(LJIOOHBCFFG, assetAvatarPack.components[j].id))
				{
					list.Add(assetAvatarPack.components[j].id);
				}
			}
		}
		return list;
	}

	// Token: 0x06008D1A RID: 36122 RVA: 0x003E612C File Offset: 0x003E432C
	public static void BLFMCEPPCBE()
	{
		AssetsManager.EHBBFMCILPC.DestroyAssetBundleAssets(NMKDCBPMCKI.AssetBundleAvatarPack, -1);
	}

	// Token: 0x06008D1B RID: 36123 RVA: 0x003E86B4 File Offset: 0x003E68B4
	public static int BKBCNMEHGFA(int PLKMJJIIJNO)
	{
		if (PLKMJJIIJNO < 0)
		{
			return -1;
		}
		if (GKJPOGNFKNK.HFBAGMFOIMH != null && PLKMJJIIJNO < GKJPOGNFKNK.HFBAGMFOIMH.Length)
		{
			return GKJPOGNFKNK.HFBAGMFOIMH[PLKMJJIIJNO];
		}
		AssetAnthology assetAnthology = GKJPOGNFKNK.LDFIAOCJEOJ(PLKMJJIIJNO);
		if (null != assetAnthology)
		{
			return assetAnthology.header.availableStories[0];
		}
		return -1;
	}

	// Token: 0x06008D1C RID: 36124 RVA: 0x003E8704 File Offset: 0x003E6904
	public static AssetSketchThumbnail GILKNJMNJDM(int OBOOCMMCPNL)
	{
		for (int i = 0; i < AssetsManager.EHBBFMCILPC.sketchThumbnailAssets.Count; i++)
		{
			if (AssetsManager.EHBBFMCILPC.sketchThumbnailAssets[i].sketchId == OBOOCMMCPNL)
			{
				return AssetsManager.EHBBFMCILPC.sketchThumbnailAssets[i];
			}
		}
		return null;
	}

	// Token: 0x06008D1D RID: 36125 RVA: 0x003E8758 File Offset: 0x003E6958
	public static AssetAnthologyHeader BDEJIINKEHH(int MEFKFOHCOHK)
	{
		for (int i = 0; i < AssetsManager.EHBBFMCILPC.anthologyAssets.Count; i++)
		{
			if (AssetsManager.EHBBFMCILPC.anthologyAssets[i].header.index == MEFKFOHCOHK)
			{
				return AssetsManager.EHBBFMCILPC.anthologyAssets[i].header;
			}
		}
		return null;
	}

	// Token: 0x06008D1E RID: 36126 RVA: 0x003E87B4 File Offset: 0x003E69B4
	public static void BPKBIMMJGDI(EPHDCPKJLHP GCDCDKDCAFH, TextAsset OENAFPNDHLK)
	{
		if (GKJPOGNFKNK.ABJPGGOGOEL[0] == null)
		{
			for (int i = 0; i < GKJPOGNFKNK.ABJPGGOGOEL.Length; i += 0)
			{
				GKJPOGNFKNK.ABJPGGOGOEL[i] = new PPLGDELFMBJ();
				GKJPOGNFKNK.ABJPGGOGOEL[i].DDNCANKJNEE = new List<KPIECDKKDKF>();
			}
		}
		for (int j = 0; j < GKJPOGNFKNK.ABJPGGOGOEL[(int)GCDCDKDCAFH].DDNCANKJNEE.Count; j++)
		{
			if (GKJPOGNFKNK.ABJPGGOGOEL[(int)GCDCDKDCAFH].DDNCANKJNEE[j].MJNNOLFBABL().Equals(OENAFPNDHLK.name))
			{
				GKJPOGNFKNK.ABJPGGOGOEL[(int)GCDCDKDCAFH].DDNCANKJNEE.RemoveAt(j);
				break;
			}
		}
		KPIECDKKDKF kpiecdkkdkf = new KPIECDKKDKF();
		kpiecdkkdkf.JOFNFNFEFKN(OENAFPNDHLK.text, OENAFPNDHLK.name, OENAFPNDHLK.name);
		GKJPOGNFKNK.ABJPGGOGOEL[(int)GCDCDKDCAFH].DDNCANKJNEE.Add(kpiecdkkdkf);
	}

	// Token: 0x06008D1F RID: 36127 RVA: 0x003E8880 File Offset: 0x003E6A80
	public static bool OMGEDKNGBJI(int PLKMJJIIJNO)
	{
		for (int i = 0; i < AssetsManager.EHBBFMCILPC.anthologyPreview2Assets.Count; i++)
		{
			if (AssetsManager.MJBDMHPHMID().anthologyPreview2Assets[i].index == PLKMJJIIJNO)
			{
				return false;
			}
		}
		for (int j = 0; j < AssetsManager.EHBBFMCILPC.anthologyPreview2AssetsMini.Count; j++)
		{
			if (AssetsManager.EHBBFMCILPC.anthologyPreview2AssetsMini[j].index == PLKMJJIIJNO)
			{
				return false;
			}
		}
		return false;
	}

	// Token: 0x06008D20 RID: 36128 RVA: 0x003E88F8 File Offset: 0x003E6AF8
	public static bool NAAOKDICGMJ(int LLLCDMNPKFI)
	{
		for (int i = 0; i < AssetsManager.EHBBFMCILPC.collectableCardAssets.Count; i++)
		{
			if (null != AssetsManager.EHBBFMCILPC.collectableCardAssets[i] && AssetsManager.EHBBFMCILPC.collectableCardAssets[i].index == LLLCDMNPKFI)
			{
				return true;
			}
		}
		return false;
	}

	// Token: 0x06008D21 RID: 36129 RVA: 0x003E8954 File Offset: 0x003E6B54
	public static AssetAnthology GJAAHGIAPMH(int NLLCKPCKGOH)
	{
		if (NLLCKPCKGOH < 0)
		{
			NLLCKPCKGOH = 0;
		}
		for (int i = 0; i < AssetsManager.EHBBFMCILPC.anthologyAssets.Count; i++)
		{
			AssetAnthology assetAnthology = AssetsManager.EHBBFMCILPC.anthologyAssets[i];
			for (int j = 0; j < assetAnthology.header.availableStories.Count; j++)
			{
				if (assetAnthology.header.availableStories[j] == NLLCKPCKGOH)
				{
					return assetAnthology;
				}
			}
		}
		if (AssetsManager.EHBBFMCILPC.anthologyAssets.Count > 0)
		{
			DPGJIJGOCIC.ANOPFDLPKGC("AssetsManagerUtils.GetAnthologyByStorySafe(), failing safe (return anthology " + AssetsManager.EHBBFMCILPC.anthologyAssets[0].header.index.ToString() + ") for story index " + NLLCKPCKGOH.ToString());
			return AssetsManager.EHBBFMCILPC.anthologyAssets[0];
		}
		return null;
	}

	// Token: 0x06008D22 RID: 36130 RVA: 0x003E8A24 File Offset: 0x003E6C24
	public static TextAsset IGKIHFIGFAI()
	{
		if (null == AssetsManager.MJBDMHPHMID().headersPackAsset)
		{
			DPGJIJGOCIC.ADFCDFHBDAF("fog");
			return null;
		}
		if (null == AssetsManager.MJBDMHPHMID().headersPackAsset.storiesSearchBalance)
		{
			DPGJIJGOCIC.PJCLICBPPDA(")");
			return null;
		}
		return AssetsManager.MJBDMHPHMID().headersPackAsset.storiesSearchBalance;
	}

	// Token: 0x06008D23 RID: 36131 RVA: 0x003E8A81 File Offset: 0x003E6C81
	public static List<TextAsset> HHHMCDBEDJB()
	{
		if (null != AssetsManager.EHBBFMCILPC.sketchesDataAsset)
		{
			return AssetsManager.EHBBFMCILPC.sketchesDataAsset.sketchesActorsList;
		}
		DPGJIJGOCIC.ANOPFDLPKGC("ERROR: GetSketchesActorsBalance(), AssetsManager.Instance.headersPacksAssets is empty.");
		return null;
	}

	// Token: 0x06008D24 RID: 36132 RVA: 0x003E8AB0 File Offset: 0x003E6CB0
	public static AssetCollectableCard GEFCBBEKLCI(int LLLCDMNPKFI)
	{
		for (int i = 0; i < AssetsManager.EHBBFMCILPC.collectableCardAssets.Count; i++)
		{
			if (null != AssetsManager.EHBBFMCILPC.collectableCardAssets[i] && AssetsManager.EHBBFMCILPC.collectableCardAssets[i].index == LLLCDMNPKFI)
			{
				return AssetsManager.EHBBFMCILPC.collectableCardAssets[i];
			}
		}
		return null;
	}

	// Token: 0x06008D25 RID: 36133 RVA: 0x003E8B1C File Offset: 0x003E6D1C
	public static AssetStoryNpc IAJMHBFGKBA(string KHJMANDEDMA, string GGPDDIECHHA = "")
	{
		if (KHJMANDEDMA != null && KHJMANDEDMA.Contains(" "))
		{
			KHJMANDEDMA = KHJMANDEDMA.Substring(0, KHJMANDEDMA.IndexOf(" "));
		}
		if (GGPDDIECHHA != null && GGPDDIECHHA.Contains(" "))
		{
			GGPDDIECHHA = GGPDDIECHHA.Substring(0, GGPDDIECHHA.IndexOf(" "));
		}
		for (int i = 0; i < AssetsManager.EHBBFMCILPC.storyAssets.Count; i++)
		{
			AssetStoryNpc assetStoryNpc = GKJPOGNFKNK.GBCBJLKBEPJ(AssetsManager.EHBBFMCILPC.storyAssets[i].GetStoryNpcAssets(), KHJMANDEDMA, GGPDDIECHHA);
			if (null != assetStoryNpc)
			{
				return assetStoryNpc;
			}
		}
		return GKJPOGNFKNK.GBCBJLKBEPJ(AssetsManager.EHBBFMCILPC.lobbyLoungeNpcAssets, KHJMANDEDMA, GGPDDIECHHA);
	}

	// Token: 0x06008D26 RID: 36134 RVA: 0x003E8BC4 File Offset: 0x003E6DC4
	public static AssetAvatarComponent KGFLNLPJGAL(KFIHMMIGPLO PBKAAIONJOB, string LPKMPFBLAMA, string JKCDOJOLLHD, CustomWardrobeSettings LJIOOHBCFFG)
	{
		List<AssetAvatarComponent>[] array = new List<AssetAvatarComponent>[6];
		for (int i = 0; i < 6; i++)
		{
			array[i] = new List<AssetAvatarComponent>();
		}
		for (int j = 0; j < AssetsManager.EHBBFMCILPC.avatarPackAssets.Count; j++)
		{
			AssetAvatarPack assetAvatarPack = AssetsManager.EHBBFMCILPC.avatarPackAssets[j];
			for (int k = 0; k < assetAvatarPack.components.Count; k++)
			{
				if (assetAvatarPack.components[k].type == PBKAAIONJOB)
				{
					array[(int)assetAvatarPack.components[k].type].Add(assetAvatarPack.components[k]);
					assetAvatarPack.components[k].MEBPFBFCDLE(assetAvatarPack.header);
				}
			}
		}
		if (PBKAAIONJOB == KFIHMMIGPLO.face)
		{
			for (int l = 0; l < array[(int)PBKAAIONJOB].Count; l++)
			{
				if (array[(int)PBKAAIONJOB][l].alias != null && array[(int)PBKAAIONJOB][l].alias.Length > 0 && array[(int)PBKAAIONJOB][l].alias.Equals(LPKMPFBLAMA) && GKJPOGNFKNK.MCFBKGPKELJ(LJIOOHBCFFG, array[(int)PBKAAIONJOB][l].alias) && array[(int)PBKAAIONJOB][l].parents != null && array[(int)PBKAAIONJOB][l].parents.Count > 0)
				{
					for (int m = 0; m < array[(int)PBKAAIONJOB][l].parents.Count; m++)
					{
						if (array[(int)PBKAAIONJOB][l].parents[m].Equals(JKCDOJOLLHD))
						{
							return array[(int)PBKAAIONJOB][l];
						}
					}
				}
			}
			DPGJIJGOCIC.ANOPFDLPKGC("ERROR: GetAvatarComponentAssetGivenAlias(), could not find asset with alias:" + LPKMPFBLAMA);
		}
		else
		{
			DPGJIJGOCIC.ANOPFDLPKGC("ERROR: GetAvatarComponentAssetGivenAlias(), _type not implemented:" + PBKAAIONJOB.ToString());
		}
		for (int n = 0; n < array[(int)PBKAAIONJOB].Count; n++)
		{
			if (array[(int)PBKAAIONJOB][n].exposition == HPKJCKOHAAI.exposed && GKJPOGNFKNK.MCFBKGPKELJ(LJIOOHBCFFG, array[(int)PBKAAIONJOB][n].alias))
			{
				return array[(int)PBKAAIONJOB][n];
			}
		}
		return null;
	}

	// Token: 0x06008D27 RID: 36135 RVA: 0x003E8DFA File Offset: 0x003E6FFA
	public static List<TextAsset> JJDJCFHAHPB()
	{
		if (null != AssetsManager.EHBBFMCILPC.sketchesDataAsset)
		{
			return AssetsManager.EHBBFMCILPC.sketchesDataAsset.sketchesLayersList;
		}
		DPGJIJGOCIC.ANOPFDLPKGC("ERROR: GetSketchesLayersBalance(), AssetsManager.Instance.headersPacksAssets is empty.");
		return null;
	}

	// Token: 0x06008D28 RID: 36136 RVA: 0x003E8E2C File Offset: 0x003E702C
	public static AssetLiveProfileTheme NHBPDOOHKGD(int KIFAOAHAAIH)
	{
		for (int i = 0; i < AssetsManager.EHBBFMCILPC.liveProfileThemesAssets.Count; i++)
		{
			if (null != AssetsManager.EHBBFMCILPC.liveProfileThemesAssets[i] && AssetsManager.EHBBFMCILPC.liveProfileThemesAssets[i].index == KIFAOAHAAIH)
			{
				return AssetsManager.EHBBFMCILPC.liveProfileThemesAssets[i];
			}
		}
		return null;
	}

	// Token: 0x06008D29 RID: 36137 RVA: 0x003E8E98 File Offset: 0x003E7098
	public static bool DPINLGFKDMA(int OHFNCGCJOEC)
	{
		for (int i = 0; i < AssetsManager.EHBBFMCILPC.liveOfferContentAssets.Count; i++)
		{
			if (null != AssetsManager.EHBBFMCILPC.liveOfferContentAssets[i] && AssetsManager.EHBBFMCILPC.liveOfferContentAssets[i].index == OHFNCGCJOEC)
			{
				return true;
			}
		}
		return false;
	}

	// Token: 0x06008D2A RID: 36138 RVA: 0x003E8EF4 File Offset: 0x003E70F4
	public static AssetLiveOfferContent DKAHEEBDGLI(int OHFNCGCJOEC)
	{
		for (int i = 0; i < AssetsManager.EHBBFMCILPC.liveOfferContentAssets.Count; i++)
		{
			if (AssetsManager.EHBBFMCILPC.liveOfferContentAssets[i].index == OHFNCGCJOEC)
			{
				return AssetsManager.EHBBFMCILPC.liveOfferContentAssets[i];
			}
		}
		if (AssetsManager.EHBBFMCILPC.liveOfferContentAssets.Count > 0)
		{
			return AssetsManager.EHBBFMCILPC.liveOfferContentAssets[0];
		}
		return null;
	}

	// Token: 0x0400275C RID: 10076
	public static PPLGDELFMBJ[] ABJPGGOGOEL = new PPLGDELFMBJ[10];

	// Token: 0x0400275D RID: 10077
	public static int[] HFBAGMFOIMH = null;
}
