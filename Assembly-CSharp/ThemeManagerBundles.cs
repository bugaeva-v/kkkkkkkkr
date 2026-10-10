using System;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

// Token: 0x0200048E RID: 1166
public class ThemeManagerBundles : MonoBehaviour
{
	// Token: 0x06008D2C RID: 36140 RVA: 0x003E8FA7 File Offset: 0x003E71A7
	private void MHBPJEDCLDM()
	{
		if (AppManager.isQuitting)
		{
			return;
		}
		AOBJLALDBAA.CEGAOMEEFBE().ECDBIBPNBCO("ok", new UnityAction(this.IKPGGOBAKNJ));
	}

	// Token: 0x06008D2D RID: 36141 RVA: 0x003E8FCC File Offset: 0x003E71CC
	private void ILBAMCJFAAP()
	{
		AOBJLALDBAA.KKPFOJMAONG().PEFKJOKLEDL("yes", new UnityAction(this.OnThemeChange));
		this.OnThemeChange();
	}

	// Token: 0x06008D2E RID: 36142 RVA: 0x00003E52 File Offset: 0x00002052
	private void NAAEEMDBPHC()
	{
	}

	// Token: 0x06008D2F RID: 36143 RVA: 0x003E8FEF File Offset: 0x003E71EF
	private void LDLLCBDGGHN()
	{
		AOBJLALDBAA.BIAEAOMHBMM().GNBGEMMDGOJ("layervideo", new UnityAction(this.GAJOGDIBONK));
		this.KPJPIAKHLLO();
	}

	// Token: 0x06008D30 RID: 36144 RVA: 0x003E9014 File Offset: 0x003E7214
	public void OCLFJDJGOOI(HGCFJKCOKPM OJKHMNEIGPF)
	{
		if (base.GetComponent<Image>() != null && base.GetComponent<Image>().sprite != null)
		{
			foreach (ThemeManagerBundles.CustomThemePropertiesBundles customThemePropertiesBundles in this.theme)
			{
				if (customThemePropertiesBundles.themeType == OJKHMNEIGPF)
				{
					if (customThemePropertiesBundles.themeImageSprite != null)
					{
						base.GetComponent<Image>().color = customThemePropertiesBundles.themeColorSprite;
						base.GetComponent<Image>().sprite = customThemePropertiesBundles.themeImageSprite;
						break;
					}
					break;
				}
			}
		}
		if (base.GetComponent<Button>() != null)
		{
			SpriteState spriteState = base.GetComponent<Button>().spriteState;
			if (spriteState.highlightedSprite != null)
			{
				foreach (ThemeManagerBundles.CustomThemePropertiesBundles customThemePropertiesBundles2 in this.theme)
				{
					if (customThemePropertiesBundles2.themeType == OJKHMNEIGPF)
					{
						if (customThemePropertiesBundles2.themeImageSprite != null)
						{
							spriteState.highlightedSprite = customThemePropertiesBundles2.themeImageSprite;
							break;
						}
						break;
					}
				}
			}
			if (spriteState.pressedSprite != null)
			{
				foreach (ThemeManagerBundles.CustomThemePropertiesBundles customThemePropertiesBundles3 in this.theme)
				{
					if (customThemePropertiesBundles3.themeType == OJKHMNEIGPF)
					{
						if (customThemePropertiesBundles3.themeImageSprite != null)
						{
							spriteState.pressedSprite = customThemePropertiesBundles3.themeImageSprite;
							break;
						}
						break;
					}
				}
			}
			if (spriteState.selectedSprite != null)
			{
				foreach (ThemeManagerBundles.CustomThemePropertiesBundles customThemePropertiesBundles4 in this.theme)
				{
					if (customThemePropertiesBundles4.themeType == OJKHMNEIGPF)
					{
						if (customThemePropertiesBundles4.themeImageSprite != null)
						{
							spriteState.selectedSprite = customThemePropertiesBundles4.themeImageSprite;
							break;
						}
						break;
					}
				}
			}
			base.GetComponent<Button>().spriteState = spriteState;
		}
		if (base.GetComponent<TextMeshProUGUI>() != null)
		{
			foreach (ThemeManagerBundles.CustomThemePropertiesBundles customThemePropertiesBundles5 in this.theme)
			{
				if (customThemePropertiesBundles5.themeType == OJKHMNEIGPF)
				{
					base.GetComponent<TextMeshProUGUI>().color = customThemePropertiesBundles5.themeColorText;
					break;
				}
			}
		}
	}

	// Token: 0x06008D31 RID: 36145 RVA: 0x00002296 File Offset: 0x00000496
	private void HEHADOKFGBB()
	{
		AppManager.isQuitting = true;
	}

	// Token: 0x06008D32 RID: 36146 RVA: 0x003E92B4 File Offset: 0x003E74B4
	private void IKBLOOGEPJB()
	{
		AOBJLALDBAA.AGANFKKBPFO().EFKNEJFLGED("app42error", new UnityAction(this.BEOACFOGONA));
		this.BKPIFLODCFN();
	}

	// Token: 0x06008D33 RID: 36147 RVA: 0x003E92D7 File Offset: 0x003E74D7
	private void FGNEEMMJFCA()
	{
		if (AppManager.isQuitting)
		{
			return;
		}
		AOBJLALDBAA.DBLAIDPICIG().POLEDPIKODD("", new UnityAction(this.KPJPIAKHLLO));
	}

	// Token: 0x06008D34 RID: 36148 RVA: 0x003E92FC File Offset: 0x003E74FC
	private void MDFOBFFGDAB()
	{
		AOBJLALDBAA.KKPFOJMAONG().GNBGEMMDGOJ("OnPopupStoryRestartManagerRestartStory", new UnityAction(this.ACHOBBDGNLG));
		this.DMFKFJDDBEG();
	}

	// Token: 0x06008D35 RID: 36149 RVA: 0x00002296 File Offset: 0x00000496
	private void IOGKHOCAPMM()
	{
		AppManager.isQuitting = true;
	}

	// Token: 0x06008D36 RID: 36150 RVA: 0x00003E52 File Offset: 0x00002052
	private void AOIJOKHACJL()
	{
	}

	// Token: 0x06008D37 RID: 36151 RVA: 0x003E9320 File Offset: 0x003E7520
	public void MFJFOHBIHMJ(HGCFJKCOKPM OJKHMNEIGPF)
	{
		if (base.GetComponent<Image>() != null && base.GetComponent<Image>().sprite != null)
		{
			foreach (ThemeManagerBundles.CustomThemePropertiesBundles customThemePropertiesBundles in this.theme)
			{
				if (customThemePropertiesBundles.themeType == OJKHMNEIGPF)
				{
					if (customThemePropertiesBundles.themeImageSprite != null)
					{
						base.GetComponent<Image>().color = customThemePropertiesBundles.themeColorSprite;
						base.GetComponent<Image>().sprite = customThemePropertiesBundles.themeImageSprite;
						break;
					}
					break;
				}
			}
		}
		if (base.GetComponent<Button>() != null)
		{
			SpriteState spriteState = base.GetComponent<Button>().spriteState;
			if (spriteState.highlightedSprite != null)
			{
				foreach (ThemeManagerBundles.CustomThemePropertiesBundles customThemePropertiesBundles2 in this.theme)
				{
					if (customThemePropertiesBundles2.themeType == OJKHMNEIGPF)
					{
						if (customThemePropertiesBundles2.themeImageSprite != null)
						{
							spriteState.highlightedSprite = customThemePropertiesBundles2.themeImageSprite;
							break;
						}
						break;
					}
				}
			}
			if (spriteState.pressedSprite != null)
			{
				foreach (ThemeManagerBundles.CustomThemePropertiesBundles customThemePropertiesBundles3 in this.theme)
				{
					if (customThemePropertiesBundles3.themeType == OJKHMNEIGPF)
					{
						if (customThemePropertiesBundles3.themeImageSprite != null)
						{
							spriteState.pressedSprite = customThemePropertiesBundles3.themeImageSprite;
							break;
						}
						break;
					}
				}
			}
			if (spriteState.selectedSprite != null)
			{
				foreach (ThemeManagerBundles.CustomThemePropertiesBundles customThemePropertiesBundles4 in this.theme)
				{
					if (customThemePropertiesBundles4.themeType == OJKHMNEIGPF)
					{
						if (customThemePropertiesBundles4.themeImageSprite != null)
						{
							spriteState.selectedSprite = customThemePropertiesBundles4.themeImageSprite;
							break;
						}
						break;
					}
				}
			}
			base.GetComponent<Button>().spriteState = spriteState;
		}
		if (base.GetComponent<TextMeshProUGUI>() != null)
		{
			foreach (ThemeManagerBundles.CustomThemePropertiesBundles customThemePropertiesBundles5 in this.theme)
			{
				if (customThemePropertiesBundles5.themeType == OJKHMNEIGPF)
				{
					base.GetComponent<TextMeshProUGUI>().color = customThemePropertiesBundles5.themeColorText;
					break;
				}
			}
		}
	}

	// Token: 0x06008D38 RID: 36152 RVA: 0x003E95C0 File Offset: 0x003E77C0
	private void JJIGCFGKFHO()
	{
		AOBJLALDBAA.DBLAIDPICIG().FNMOFCMDFJP("socialdonotdisturbtut0", new UnityAction(this.ALNMBJHFDFA));
		this.KPJPIAKHLLO();
	}

	// Token: 0x06008D39 RID: 36153 RVA: 0x003E95E3 File Offset: 0x003E77E3
	private void DJDLHIOMGJB()
	{
		AOBJLALDBAA.FILDBDMENPG().GNBGEMMDGOJ("af_purchase", new UnityAction(this.CJHBHLGFFFH));
		this.PJPDHIGJJNG();
	}

	// Token: 0x06008D3A RID: 36154 RVA: 0x003E9608 File Offset: 0x003E7808
	public void ALOKEDBCELP()
	{
		HGCFJKCOKPM hgcfjkcokpm = AKLFPGMDKLA.EHBBFMCILPC.ICEOGOCOMJL();
		if (hgcfjkcokpm == HGCFJKCOKPM.bright)
		{
			this.MFJFOHBIHMJ(HGCFJKCOKPM.bright);
			return;
		}
		if (hgcfjkcokpm != HGCFJKCOKPM.bright)
		{
			return;
		}
		this.BIMLKCCNGFH(HGCFJKCOKPM.bright);
	}

	// Token: 0x06008D3B RID: 36155 RVA: 0x003E9637 File Offset: 0x003E7837
	private void ILOPFODPJCL()
	{
		AOBJLALDBAA.KKPFOJMAONG().GNBGEMMDGOJ("storyAssetPackManager[i].storyNpcAssets[j] is null!", new UnityAction(this.OnThemeChange));
		this.BKPIFLODCFN();
	}

	// Token: 0x06008D3C RID: 36156 RVA: 0x003E965C File Offset: 0x003E785C
	public void PJPDHIGJJNG()
	{
		HGCFJKCOKPM hgcfjkcokpm = AKLFPGMDKLA.EHBBFMCILPC.JKCEGIPAANK();
		if (hgcfjkcokpm == HGCFJKCOKPM.bright)
		{
			this.BNOBDMDKBAB(HGCFJKCOKPM.bright);
			return;
		}
		if (hgcfjkcokpm != HGCFJKCOKPM.dark)
		{
			return;
		}
		this.LMJABOJKKAO(HGCFJKCOKPM.dark);
	}

	// Token: 0x06008D3D RID: 36157 RVA: 0x003E968B File Offset: 0x003E788B
	private void FLPCAAILFMN()
	{
		if (AppManager.isQuitting)
		{
			return;
		}
		AOBJLALDBAA.KKPFOJMAONG().ONIBLJOFFPG("ulsk", new UnityAction(this.PLACAKEHLNC));
	}

	// Token: 0x06008D3E RID: 36158 RVA: 0x003E96B0 File Offset: 0x003E78B0
	private void HONIBLHFFAE()
	{
		if (AppManager.isQuitting)
		{
			return;
		}
		AOBJLALDBAA.EHBBFMCILPC.KDIFKFKMCOH("OnStoryChoiceClick", new UnityAction(this.GAJOGDIBONK));
	}

	// Token: 0x06008D3F RID: 36159 RVA: 0x003E96D5 File Offset: 0x003E78D5
	private void OOOHPJJOODA()
	{
		if (AppManager.isQuitting)
		{
			return;
		}
		AOBJLALDBAA.AGANFKKBPFO().PBELMJCPJMK("p", new UnityAction(this.BKPIFLODCFN));
	}

	// Token: 0x06008D40 RID: 36160 RVA: 0x003E96FC File Offset: 0x003E78FC
	public void OnThemeChange()
	{
		HGCFJKCOKPM hgcfjkcokpm = AKLFPGMDKLA.EHBBFMCILPC.ICEOGOCOMJL();
		if (hgcfjkcokpm == HGCFJKCOKPM.bright)
		{
			this.SetTheme(HGCFJKCOKPM.bright);
			return;
		}
		if (hgcfjkcokpm != HGCFJKCOKPM.dark)
		{
			return;
		}
		this.SetTheme(HGCFJKCOKPM.dark);
	}

	// Token: 0x06008D41 RID: 36161 RVA: 0x00002296 File Offset: 0x00000496
	private void LCLNCFPKGHE()
	{
		AppManager.isQuitting = true;
	}

	// Token: 0x06008D42 RID: 36162 RVA: 0x00002296 File Offset: 0x00000496
	private void OnApplicationQuit()
	{
		AppManager.isQuitting = true;
	}

	// Token: 0x06008D43 RID: 36163 RVA: 0x003E972C File Offset: 0x003E792C
	public void ALNMBJHFDFA()
	{
		HGCFJKCOKPM hgcfjkcokpm = AKLFPGMDKLA.EHBBFMCILPC.PINBMHFHEHD();
		if (hgcfjkcokpm == HGCFJKCOKPM.bright)
		{
			this.MFJFOHBIHMJ(HGCFJKCOKPM.dark);
			return;
		}
		if (hgcfjkcokpm != HGCFJKCOKPM.dark)
		{
			return;
		}
		this.CNINPIEGLDJ(HGCFJKCOKPM.dark);
	}

	// Token: 0x06008D44 RID: 36164 RVA: 0x00002296 File Offset: 0x00000496
	private void HELIPJGLNKD()
	{
		AppManager.isQuitting = true;
	}

	// Token: 0x06008D45 RID: 36165 RVA: 0x003E975B File Offset: 0x003E795B
	private void MNDPPAMNECC()
	{
		AOBJLALDBAA.FILDBDMENPG().GNBGEMMDGOJ(" focusOpened=", new UnityAction(this.ALOKEDBCELP));
		this.ALOKEDBCELP();
	}

	// Token: 0x06008D46 RID: 36166 RVA: 0x00003E52 File Offset: 0x00002052
	private void BIGNLMDFEFO()
	{
	}

	// Token: 0x06008D47 RID: 36167 RVA: 0x003E977E File Offset: 0x003E797E
	private void EGKJKALABEI()
	{
		if (AppManager.isQuitting)
		{
			return;
		}
		AOBJLALDBAA.AGANFKKBPFO().NAMMLDPCHJO("USD ", new UnityAction(this.BKPIFLODCFN));
	}

	// Token: 0x06008D48 RID: 36168 RVA: 0x003E97A4 File Offset: 0x003E79A4
	public void GINNCBBODJO()
	{
		HGCFJKCOKPM hgcfjkcokpm = AKLFPGMDKLA.EHBBFMCILPC.PINBMHFHEHD();
		if (hgcfjkcokpm == HGCFJKCOKPM.bright)
		{
			this.KKALDAGCIGL(HGCFJKCOKPM.dark);
			return;
		}
		if (hgcfjkcokpm != HGCFJKCOKPM.dark)
		{
			return;
		}
		this.SetTheme(HGCFJKCOKPM.bright);
	}

	// Token: 0x06008D49 RID: 36169 RVA: 0x003E97D4 File Offset: 0x003E79D4
	public void CJHBHLGFFFH()
	{
		HGCFJKCOKPM hgcfjkcokpm = AKLFPGMDKLA.EHBBFMCILPC.PINBMHFHEHD();
		if (hgcfjkcokpm == HGCFJKCOKPM.bright)
		{
			this.BNOBDMDKBAB(HGCFJKCOKPM.dark);
			return;
		}
		if (hgcfjkcokpm != HGCFJKCOKPM.dark)
		{
			return;
		}
		this.CNINPIEGLDJ(HGCFJKCOKPM.dark);
	}

	// Token: 0x06008D4A RID: 36170 RVA: 0x003E9803 File Offset: 0x003E7A03
	private void GPMIFPNCOLC()
	{
		if (AppManager.isQuitting)
		{
			return;
		}
		AOBJLALDBAA.EHBBFMCILPC.ONIBLJOFFPG("unexpected_platform", new UnityAction(this.DCEBKBMBBMM));
	}

	// Token: 0x06008D4B RID: 36171 RVA: 0x000022C3 File Offset: 0x000004C3
	private void EMNCBLNFINM()
	{
		AppManager.isQuitting = false;
	}

	// Token: 0x06008D4C RID: 36172 RVA: 0x00003E52 File Offset: 0x00002052
	private void BHDHJLIBHCJ()
	{
	}

	// Token: 0x06008D4D RID: 36173 RVA: 0x000022C3 File Offset: 0x000004C3
	private void OPHKBBGHKEB()
	{
		AppManager.isQuitting = false;
	}

	// Token: 0x06008D4E RID: 36174 RVA: 0x003E9828 File Offset: 0x003E7A28
	public void IPFKLADLGDF()
	{
		HGCFJKCOKPM hgcfjkcokpm = AKLFPGMDKLA.EHBBFMCILPC.ICEOGOCOMJL();
		if (hgcfjkcokpm == HGCFJKCOKPM.bright)
		{
			this.OCLFJDJGOOI(HGCFJKCOKPM.dark);
			return;
		}
		if (hgcfjkcokpm != HGCFJKCOKPM.bright)
		{
			return;
		}
		this.SetTheme(HGCFJKCOKPM.bright);
	}

	// Token: 0x06008D4F RID: 36175 RVA: 0x003E9857 File Offset: 0x003E7A57
	private void HOJIMOHCLHE()
	{
		AOBJLALDBAA.AGANFKKBPFO().BADOPKAOCPE("releaseTimeline", new UnityAction(this.ALOKEDBCELP));
		this.GINNCBBODJO();
	}

	// Token: 0x06008D50 RID: 36176 RVA: 0x000022C3 File Offset: 0x000004C3
	private void BBNKJNNLIME()
	{
		AppManager.isQuitting = false;
	}

	// Token: 0x06008D51 RID: 36177 RVA: 0x003E987C File Offset: 0x003E7A7C
	public void DMFKFJDDBEG()
	{
		HGCFJKCOKPM hgcfjkcokpm = AKLFPGMDKLA.EHBBFMCILPC.PINBMHFHEHD();
		if (hgcfjkcokpm == HGCFJKCOKPM.bright)
		{
			this.LMJABOJKKAO(HGCFJKCOKPM.bright);
			return;
		}
		if (hgcfjkcokpm != HGCFJKCOKPM.dark)
		{
			return;
		}
		this.CNINPIEGLDJ(HGCFJKCOKPM.dark);
	}

	// Token: 0x06008D52 RID: 36178 RVA: 0x00003E52 File Offset: 0x00002052
	private void GKMBPHPJAAP()
	{
	}

	// Token: 0x06008D53 RID: 36179 RVA: 0x000022C3 File Offset: 0x000004C3
	private void GLOPFMIPBHG()
	{
		AppManager.isQuitting = false;
	}

	// Token: 0x06008D54 RID: 36180 RVA: 0x00003E52 File Offset: 0x00002052
	private void PIBDCOBGMKC()
	{
	}

	// Token: 0x06008D55 RID: 36181 RVA: 0x003E98AB File Offset: 0x003E7AAB
	private void LGLMMPEJIHH()
	{
		if (AppManager.isQuitting)
		{
			return;
		}
		AOBJLALDBAA.FILDBDMENPG().KDIFKFKMCOH("eml", new UnityAction(this.DMPMMJKOLNG));
	}

	// Token: 0x06008D56 RID: 36182 RVA: 0x000022C3 File Offset: 0x000004C3
	private void NKJOAHMCGPF()
	{
		AppManager.isQuitting = false;
	}

	// Token: 0x06008D57 RID: 36183 RVA: 0x003E98D0 File Offset: 0x003E7AD0
	private void BBGMFNGGIDE()
	{
		if (AppManager.isQuitting)
		{
			return;
		}
		AOBJLALDBAA.BIAEAOMHBMM().KDIFKFKMCOH("secondsshort", new UnityAction(this.BEOACFOGONA));
	}

	// Token: 0x06008D59 RID: 36185 RVA: 0x003E98F8 File Offset: 0x003E7AF8
	public void DPJFGAGFHHB(HGCFJKCOKPM OJKHMNEIGPF)
	{
		if (base.GetComponent<Image>() != null && base.GetComponent<Image>().sprite != null)
		{
			foreach (ThemeManagerBundles.CustomThemePropertiesBundles customThemePropertiesBundles in this.theme)
			{
				if (customThemePropertiesBundles.themeType == OJKHMNEIGPF)
				{
					if (customThemePropertiesBundles.themeImageSprite != null)
					{
						base.GetComponent<Image>().color = customThemePropertiesBundles.themeColorSprite;
						base.GetComponent<Image>().sprite = customThemePropertiesBundles.themeImageSprite;
						break;
					}
					break;
				}
			}
		}
		if (base.GetComponent<Button>() != null)
		{
			SpriteState spriteState = base.GetComponent<Button>().spriteState;
			if (spriteState.highlightedSprite != null)
			{
				foreach (ThemeManagerBundles.CustomThemePropertiesBundles customThemePropertiesBundles2 in this.theme)
				{
					if (customThemePropertiesBundles2.themeType == OJKHMNEIGPF)
					{
						if (customThemePropertiesBundles2.themeImageSprite != null)
						{
							spriteState.highlightedSprite = customThemePropertiesBundles2.themeImageSprite;
							break;
						}
						break;
					}
				}
			}
			if (spriteState.pressedSprite != null)
			{
				foreach (ThemeManagerBundles.CustomThemePropertiesBundles customThemePropertiesBundles3 in this.theme)
				{
					if (customThemePropertiesBundles3.themeType == OJKHMNEIGPF)
					{
						if (customThemePropertiesBundles3.themeImageSprite != null)
						{
							spriteState.pressedSprite = customThemePropertiesBundles3.themeImageSprite;
							break;
						}
						break;
					}
				}
			}
			if (spriteState.selectedSprite != null)
			{
				foreach (ThemeManagerBundles.CustomThemePropertiesBundles customThemePropertiesBundles4 in this.theme)
				{
					if (customThemePropertiesBundles4.themeType == OJKHMNEIGPF)
					{
						if (customThemePropertiesBundles4.themeImageSprite != null)
						{
							spriteState.selectedSprite = customThemePropertiesBundles4.themeImageSprite;
							break;
						}
						break;
					}
				}
			}
			base.GetComponent<Button>().spriteState = spriteState;
		}
		if (base.GetComponent<TextMeshProUGUI>() != null)
		{
			foreach (ThemeManagerBundles.CustomThemePropertiesBundles customThemePropertiesBundles5 in this.theme)
			{
				if (customThemePropertiesBundles5.themeType == OJKHMNEIGPF)
				{
					base.GetComponent<TextMeshProUGUI>().color = customThemePropertiesBundles5.themeColorText;
					break;
				}
			}
		}
	}

	// Token: 0x06008D5A RID: 36186 RVA: 0x00002296 File Offset: 0x00000496
	private void PMDLBAEBPJG()
	{
		AppManager.isQuitting = true;
	}

	// Token: 0x06008D5B RID: 36187 RVA: 0x003E9B98 File Offset: 0x003E7D98
	public void CNINPIEGLDJ(HGCFJKCOKPM OJKHMNEIGPF)
	{
		if (base.GetComponent<Image>() != null && base.GetComponent<Image>().sprite != null)
		{
			foreach (ThemeManagerBundles.CustomThemePropertiesBundles customThemePropertiesBundles in this.theme)
			{
				if (customThemePropertiesBundles.themeType == OJKHMNEIGPF)
				{
					if (customThemePropertiesBundles.themeImageSprite != null)
					{
						base.GetComponent<Image>().color = customThemePropertiesBundles.themeColorSprite;
						base.GetComponent<Image>().sprite = customThemePropertiesBundles.themeImageSprite;
						break;
					}
					break;
				}
			}
		}
		if (base.GetComponent<Button>() != null)
		{
			SpriteState spriteState = base.GetComponent<Button>().spriteState;
			if (spriteState.highlightedSprite != null)
			{
				foreach (ThemeManagerBundles.CustomThemePropertiesBundles customThemePropertiesBundles2 in this.theme)
				{
					if (customThemePropertiesBundles2.themeType == OJKHMNEIGPF)
					{
						if (customThemePropertiesBundles2.themeImageSprite != null)
						{
							spriteState.highlightedSprite = customThemePropertiesBundles2.themeImageSprite;
							break;
						}
						break;
					}
				}
			}
			if (spriteState.pressedSprite != null)
			{
				foreach (ThemeManagerBundles.CustomThemePropertiesBundles customThemePropertiesBundles3 in this.theme)
				{
					if (customThemePropertiesBundles3.themeType == OJKHMNEIGPF)
					{
						if (customThemePropertiesBundles3.themeImageSprite != null)
						{
							spriteState.pressedSprite = customThemePropertiesBundles3.themeImageSprite;
							break;
						}
						break;
					}
				}
			}
			if (spriteState.selectedSprite != null)
			{
				foreach (ThemeManagerBundles.CustomThemePropertiesBundles customThemePropertiesBundles4 in this.theme)
				{
					if (customThemePropertiesBundles4.themeType == OJKHMNEIGPF)
					{
						if (customThemePropertiesBundles4.themeImageSprite != null)
						{
							spriteState.selectedSprite = customThemePropertiesBundles4.themeImageSprite;
							break;
						}
						break;
					}
				}
			}
			base.GetComponent<Button>().spriteState = spriteState;
		}
		if (base.GetComponent<TextMeshProUGUI>() != null)
		{
			foreach (ThemeManagerBundles.CustomThemePropertiesBundles customThemePropertiesBundles5 in this.theme)
			{
				if (customThemePropertiesBundles5.themeType == OJKHMNEIGPF)
				{
					base.GetComponent<TextMeshProUGUI>().color = customThemePropertiesBundles5.themeColorText;
					break;
				}
			}
		}
	}

	// Token: 0x06008D5C RID: 36188 RVA: 0x00003E52 File Offset: 0x00002052
	private void CEDGALPCOLA()
	{
	}

	// Token: 0x06008D5D RID: 36189 RVA: 0x003E9E38 File Offset: 0x003E8038
	public void BHJDBDCKAGH(HGCFJKCOKPM OJKHMNEIGPF)
	{
		if (base.GetComponent<Image>() != null && base.GetComponent<Image>().sprite != null)
		{
			foreach (ThemeManagerBundles.CustomThemePropertiesBundles customThemePropertiesBundles in this.theme)
			{
				if (customThemePropertiesBundles.themeType == OJKHMNEIGPF)
				{
					if (customThemePropertiesBundles.themeImageSprite != null)
					{
						base.GetComponent<Image>().color = customThemePropertiesBundles.themeColorSprite;
						base.GetComponent<Image>().sprite = customThemePropertiesBundles.themeImageSprite;
						break;
					}
					break;
				}
			}
		}
		if (base.GetComponent<Button>() != null)
		{
			SpriteState spriteState = base.GetComponent<Button>().spriteState;
			if (spriteState.highlightedSprite != null)
			{
				foreach (ThemeManagerBundles.CustomThemePropertiesBundles customThemePropertiesBundles2 in this.theme)
				{
					if (customThemePropertiesBundles2.themeType == OJKHMNEIGPF)
					{
						if (customThemePropertiesBundles2.themeImageSprite != null)
						{
							spriteState.highlightedSprite = customThemePropertiesBundles2.themeImageSprite;
							break;
						}
						break;
					}
				}
			}
			if (spriteState.pressedSprite != null)
			{
				foreach (ThemeManagerBundles.CustomThemePropertiesBundles customThemePropertiesBundles3 in this.theme)
				{
					if (customThemePropertiesBundles3.themeType == OJKHMNEIGPF)
					{
						if (customThemePropertiesBundles3.themeImageSprite != null)
						{
							spriteState.pressedSprite = customThemePropertiesBundles3.themeImageSprite;
							break;
						}
						break;
					}
				}
			}
			if (spriteState.selectedSprite != null)
			{
				foreach (ThemeManagerBundles.CustomThemePropertiesBundles customThemePropertiesBundles4 in this.theme)
				{
					if (customThemePropertiesBundles4.themeType == OJKHMNEIGPF)
					{
						if (customThemePropertiesBundles4.themeImageSprite != null)
						{
							spriteState.selectedSprite = customThemePropertiesBundles4.themeImageSprite;
							break;
						}
						break;
					}
				}
			}
			base.GetComponent<Button>().spriteState = spriteState;
		}
		if (base.GetComponent<TextMeshProUGUI>() != null)
		{
			foreach (ThemeManagerBundles.CustomThemePropertiesBundles customThemePropertiesBundles5 in this.theme)
			{
				if (customThemePropertiesBundles5.themeType == OJKHMNEIGPF)
				{
					base.GetComponent<TextMeshProUGUI>().color = customThemePropertiesBundles5.themeColorText;
					break;
				}
			}
		}
	}

	// Token: 0x06008D5E RID: 36190 RVA: 0x003EA0D8 File Offset: 0x003E82D8
	private void GMKJOIDPAIE()
	{
		AOBJLALDBAA.NMGMNAKLLMI().EFKNEJFLGED("continue", new UnityAction(this.DCEBKBMBBMM));
		this.PJPDHIGJJNG();
	}

	// Token: 0x06008D5F RID: 36191 RVA: 0x003EA0FC File Offset: 0x003E82FC
	public void GAJOGDIBONK()
	{
		HGCFJKCOKPM hgcfjkcokpm = AKLFPGMDKLA.EHBBFMCILPC.JKCEGIPAANK();
		if (hgcfjkcokpm == HGCFJKCOKPM.bright)
		{
			this.GFMIFHDEKGA(HGCFJKCOKPM.dark);
			return;
		}
		if (hgcfjkcokpm != HGCFJKCOKPM.bright)
		{
			return;
		}
		this.OCLFJDJGOOI(HGCFJKCOKPM.dark);
	}

	// Token: 0x06008D60 RID: 36192 RVA: 0x003EA12B File Offset: 0x003E832B
	private void HHHJOCGGNHE()
	{
		if (AppManager.isQuitting)
		{
			return;
		}
		AOBJLALDBAA.NMGMNAKLLMI().MANLHALMCIH("Error. ShowHideEnvironmentLayer(), environmentLayer ", new UnityAction(this.OnThemeChange));
	}

	// Token: 0x06008D61 RID: 36193 RVA: 0x003EA150 File Offset: 0x003E8350
	public void BEOACFOGONA()
	{
		HGCFJKCOKPM hgcfjkcokpm = AKLFPGMDKLA.EHBBFMCILPC.ICEOGOCOMJL();
		if (hgcfjkcokpm == HGCFJKCOKPM.bright)
		{
			this.SetTheme(HGCFJKCOKPM.bright);
			return;
		}
		if (hgcfjkcokpm != HGCFJKCOKPM.dark)
		{
			return;
		}
		this.SetTheme(HGCFJKCOKPM.dark);
	}

	// Token: 0x06008D62 RID: 36194 RVA: 0x003EA180 File Offset: 0x003E8380
	public void KPJPIAKHLLO()
	{
		HGCFJKCOKPM hgcfjkcokpm = AKLFPGMDKLA.EHBBFMCILPC.ICEOGOCOMJL();
		if (hgcfjkcokpm == HGCFJKCOKPM.bright)
		{
			this.CNINPIEGLDJ(HGCFJKCOKPM.bright);
			return;
		}
		if (hgcfjkcokpm != HGCFJKCOKPM.bright)
		{
			return;
		}
		this.BNOBDMDKBAB(HGCFJKCOKPM.bright);
	}

	// Token: 0x06008D63 RID: 36195 RVA: 0x003EA1AF File Offset: 0x003E83AF
	private void ELJFKBMKKML()
	{
		if (AppManager.isQuitting)
		{
			return;
		}
		AOBJLALDBAA.BIAEAOMHBMM().PBELMJCPJMK("OnAchievementSyncSuccess", new UnityAction(this.ALOKEDBCELP));
	}

	// Token: 0x06008D64 RID: 36196 RVA: 0x00003E52 File Offset: 0x00002052
	private void JHBLEEJPJIF()
	{
	}

	// Token: 0x06008D65 RID: 36197 RVA: 0x003EA1D4 File Offset: 0x003E83D4
	private void NEKHLHGBMBP()
	{
		if (AppManager.isQuitting)
		{
			return;
		}
		AOBJLALDBAA.DBLAIDPICIG().KDIFKFKMCOH("rand", new UnityAction(this.IPFKLADLGDF));
	}

	// Token: 0x06008D66 RID: 36198 RVA: 0x003EA1F9 File Offset: 0x003E83F9
	private void LLGBJHCIIGA()
	{
		AOBJLALDBAA.FILDBDMENPG().PEFKJOKLEDL("YYY", new UnityAction(this.GINNCBBODJO));
		this.ACHOBBDGNLG();
	}

	// Token: 0x06008D67 RID: 36199 RVA: 0x003EA21C File Offset: 0x003E841C
	public void BIMLKCCNGFH(HGCFJKCOKPM OJKHMNEIGPF)
	{
		if (base.GetComponent<Image>() != null && base.GetComponent<Image>().sprite != null)
		{
			foreach (ThemeManagerBundles.CustomThemePropertiesBundles customThemePropertiesBundles in this.theme)
			{
				if (customThemePropertiesBundles.themeType == OJKHMNEIGPF)
				{
					if (customThemePropertiesBundles.themeImageSprite != null)
					{
						base.GetComponent<Image>().color = customThemePropertiesBundles.themeColorSprite;
						base.GetComponent<Image>().sprite = customThemePropertiesBundles.themeImageSprite;
						break;
					}
					break;
				}
			}
		}
		if (base.GetComponent<Button>() != null)
		{
			SpriteState spriteState = base.GetComponent<Button>().spriteState;
			if (spriteState.highlightedSprite != null)
			{
				foreach (ThemeManagerBundles.CustomThemePropertiesBundles customThemePropertiesBundles2 in this.theme)
				{
					if (customThemePropertiesBundles2.themeType == OJKHMNEIGPF)
					{
						if (customThemePropertiesBundles2.themeImageSprite != null)
						{
							spriteState.highlightedSprite = customThemePropertiesBundles2.themeImageSprite;
							break;
						}
						break;
					}
				}
			}
			if (spriteState.pressedSprite != null)
			{
				foreach (ThemeManagerBundles.CustomThemePropertiesBundles customThemePropertiesBundles3 in this.theme)
				{
					if (customThemePropertiesBundles3.themeType == OJKHMNEIGPF)
					{
						if (customThemePropertiesBundles3.themeImageSprite != null)
						{
							spriteState.pressedSprite = customThemePropertiesBundles3.themeImageSprite;
							break;
						}
						break;
					}
				}
			}
			if (spriteState.selectedSprite != null)
			{
				foreach (ThemeManagerBundles.CustomThemePropertiesBundles customThemePropertiesBundles4 in this.theme)
				{
					if (customThemePropertiesBundles4.themeType == OJKHMNEIGPF)
					{
						if (customThemePropertiesBundles4.themeImageSprite != null)
						{
							spriteState.selectedSprite = customThemePropertiesBundles4.themeImageSprite;
							break;
						}
						break;
					}
				}
			}
			base.GetComponent<Button>().spriteState = spriteState;
		}
		if (base.GetComponent<TextMeshProUGUI>() != null)
		{
			foreach (ThemeManagerBundles.CustomThemePropertiesBundles customThemePropertiesBundles5 in this.theme)
			{
				if (customThemePropertiesBundles5.themeType == OJKHMNEIGPF)
				{
					base.GetComponent<TextMeshProUGUI>().color = customThemePropertiesBundles5.themeColorText;
					break;
				}
			}
		}
	}

	// Token: 0x06008D68 RID: 36200 RVA: 0x003EA4BC File Offset: 0x003E86BC
	public void BNOBDMDKBAB(HGCFJKCOKPM OJKHMNEIGPF)
	{
		if (base.GetComponent<Image>() != null && base.GetComponent<Image>().sprite != null)
		{
			foreach (ThemeManagerBundles.CustomThemePropertiesBundles customThemePropertiesBundles in this.theme)
			{
				if (customThemePropertiesBundles.themeType == OJKHMNEIGPF)
				{
					if (customThemePropertiesBundles.themeImageSprite != null)
					{
						base.GetComponent<Image>().color = customThemePropertiesBundles.themeColorSprite;
						base.GetComponent<Image>().sprite = customThemePropertiesBundles.themeImageSprite;
						break;
					}
					break;
				}
			}
		}
		if (base.GetComponent<Button>() != null)
		{
			SpriteState spriteState = base.GetComponent<Button>().spriteState;
			if (spriteState.highlightedSprite != null)
			{
				foreach (ThemeManagerBundles.CustomThemePropertiesBundles customThemePropertiesBundles2 in this.theme)
				{
					if (customThemePropertiesBundles2.themeType == OJKHMNEIGPF)
					{
						if (customThemePropertiesBundles2.themeImageSprite != null)
						{
							spriteState.highlightedSprite = customThemePropertiesBundles2.themeImageSprite;
							break;
						}
						break;
					}
				}
			}
			if (spriteState.pressedSprite != null)
			{
				foreach (ThemeManagerBundles.CustomThemePropertiesBundles customThemePropertiesBundles3 in this.theme)
				{
					if (customThemePropertiesBundles3.themeType == OJKHMNEIGPF)
					{
						if (customThemePropertiesBundles3.themeImageSprite != null)
						{
							spriteState.pressedSprite = customThemePropertiesBundles3.themeImageSprite;
							break;
						}
						break;
					}
				}
			}
			if (spriteState.selectedSprite != null)
			{
				foreach (ThemeManagerBundles.CustomThemePropertiesBundles customThemePropertiesBundles4 in this.theme)
				{
					if (customThemePropertiesBundles4.themeType == OJKHMNEIGPF)
					{
						if (customThemePropertiesBundles4.themeImageSprite != null)
						{
							spriteState.selectedSprite = customThemePropertiesBundles4.themeImageSprite;
							break;
						}
						break;
					}
				}
			}
			base.GetComponent<Button>().spriteState = spriteState;
		}
		if (base.GetComponent<TextMeshProUGUI>() != null)
		{
			foreach (ThemeManagerBundles.CustomThemePropertiesBundles customThemePropertiesBundles5 in this.theme)
			{
				if (customThemePropertiesBundles5.themeType == OJKHMNEIGPF)
				{
					base.GetComponent<TextMeshProUGUI>().color = customThemePropertiesBundles5.themeColorText;
					break;
				}
			}
		}
	}

	// Token: 0x06008D69 RID: 36201 RVA: 0x00002296 File Offset: 0x00000496
	private void MDNIBNGIEKO()
	{
		AppManager.isQuitting = true;
	}

	// Token: 0x06008D6A RID: 36202 RVA: 0x00003E52 File Offset: 0x00002052
	private void BDMGHFPMOAG()
	{
	}

	// Token: 0x06008D6B RID: 36203 RVA: 0x003EA75C File Offset: 0x003E895C
	private void GIOOKMFKLIO()
	{
		AOBJLALDBAA.EHBBFMCILPC.GNBGEMMDGOJ("anthology", new UnityAction(this.NCNFDBKDKAF));
		this.OnThemeChange();
	}

	// Token: 0x06008D6C RID: 36204 RVA: 0x003EA77F File Offset: 0x003E897F
	private void GEPMOBKFIMI()
	{
		if (AppManager.isQuitting)
		{
			return;
		}
		AOBJLALDBAA.BIAEAOMHBMM().PBELMJCPJMK("<i>", new UnityAction(this.FKONGDMDBEH));
	}

	// Token: 0x06008D6D RID: 36205 RVA: 0x003EA7A4 File Offset: 0x003E89A4
	private void GIHIKHJGOHN()
	{
		if (AppManager.isQuitting)
		{
			return;
		}
		AOBJLALDBAA.KKPFOJMAONG().MANLHALMCIH("seasonshort", new UnityAction(this.ALOKEDBCELP));
	}

	// Token: 0x06008D6E RID: 36206 RVA: 0x003EA7C9 File Offset: 0x003E89C9
	private void MOAHMBJJGOH()
	{
		AOBJLALDBAA.AGANFKKBPFO().EFKNEJFLGED("", new UnityAction(this.CJHBHLGFFFH));
		this.ACHOBBDGNLG();
	}

	// Token: 0x06008D6F RID: 36207 RVA: 0x00003E52 File Offset: 0x00002052
	private void PMKKOENBNOM()
	{
	}

	// Token: 0x06008D70 RID: 36208 RVA: 0x003EA7EC File Offset: 0x003E89EC
	public void BKPIFLODCFN()
	{
		HGCFJKCOKPM hgcfjkcokpm = AKLFPGMDKLA.EHBBFMCILPC.ICEOGOCOMJL();
		if (hgcfjkcokpm == HGCFJKCOKPM.bright)
		{
			this.BHJDBDCKAGH(HGCFJKCOKPM.dark);
			return;
		}
		if (hgcfjkcokpm != HGCFJKCOKPM.dark)
		{
			return;
		}
		this.BIMLKCCNGFH(HGCFJKCOKPM.bright);
	}

	// Token: 0x06008D71 RID: 36209 RVA: 0x003EA81C File Offset: 0x003E8A1C
	public void AKKAJEPEEME()
	{
		HGCFJKCOKPM hgcfjkcokpm = AKLFPGMDKLA.EHBBFMCILPC.JKCEGIPAANK();
		if (hgcfjkcokpm == HGCFJKCOKPM.bright)
		{
			this.BHJDBDCKAGH(HGCFJKCOKPM.bright);
			return;
		}
		if (hgcfjkcokpm != HGCFJKCOKPM.dark)
		{
			return;
		}
		this.LMJABOJKKAO(HGCFJKCOKPM.bright);
	}

	// Token: 0x06008D72 RID: 36210 RVA: 0x00003E52 File Offset: 0x00002052
	private void OMNGHDNDLKP()
	{
	}

	// Token: 0x06008D73 RID: 36211 RVA: 0x00003E52 File Offset: 0x00002052
	private void HLCCOGFOMHA()
	{
	}

	// Token: 0x06008D74 RID: 36212 RVA: 0x003EA84C File Offset: 0x003E8A4C
	public void DCEBKBMBBMM()
	{
		HGCFJKCOKPM hgcfjkcokpm = AKLFPGMDKLA.EHBBFMCILPC.ICEOGOCOMJL();
		if (hgcfjkcokpm == HGCFJKCOKPM.bright)
		{
			this.SetTheme(HGCFJKCOKPM.bright);
			return;
		}
		if (hgcfjkcokpm != HGCFJKCOKPM.bright)
		{
			return;
		}
		this.BIMLKCCNGFH(HGCFJKCOKPM.dark);
	}

	// Token: 0x06008D75 RID: 36213 RVA: 0x003EA87B File Offset: 0x003E8A7B
	private void INODDOOLMMB()
	{
		if (AppManager.isQuitting)
		{
			return;
		}
		AOBJLALDBAA.DBLAIDPICIG().POLEDPIKODD("</i>.", new UnityAction(this.NCNFDBKDKAF));
	}

	// Token: 0x06008D76 RID: 36214 RVA: 0x003EA8A0 File Offset: 0x003E8AA0
	private void BHAMDIHNJNA()
	{
		if (AppManager.isQuitting)
		{
			return;
		}
		AOBJLALDBAA.KKPFOJMAONG().PBELMJCPJMK("fhva", new UnityAction(this.DMPMMJKOLNG));
	}

	// Token: 0x06008D77 RID: 36215 RVA: 0x003EA8C5 File Offset: 0x003E8AC5
	private void CHEDGGLPOJP()
	{
		AOBJLALDBAA.NMGMNAKLLMI().FNMOFCMDFJP(")", new UnityAction(this.GAJOGDIBONK));
		this.GINNCBBODJO();
	}

	// Token: 0x06008D78 RID: 36216 RVA: 0x00003E52 File Offset: 0x00002052
	private void MIMOJFLJLFO()
	{
	}

	// Token: 0x06008D79 RID: 36217 RVA: 0x003EA8E8 File Offset: 0x003E8AE8
	private void HKCLEPNKGDH()
	{
		if (AppManager.isQuitting)
		{
			return;
		}
		AOBJLALDBAA.NMGMNAKLLMI().KDIFKFKMCOH("common", new UnityAction(this.FKONGDMDBEH));
	}

	// Token: 0x06008D7A RID: 36218 RVA: 0x003EA90D File Offset: 0x003E8B0D
	private void EJAENAPIMKF()
	{
		if (AppManager.isQuitting)
		{
			return;
		}
		AOBJLALDBAA.KKPFOJMAONG().PFAHGKEDFAE("minutesshort", new UnityAction(this.DCEBKBMBBMM));
	}

	// Token: 0x06008D7B RID: 36219 RVA: 0x003EA934 File Offset: 0x003E8B34
	public void ACHOBBDGNLG()
	{
		HGCFJKCOKPM hgcfjkcokpm = AKLFPGMDKLA.EHBBFMCILPC.PINBMHFHEHD();
		if (hgcfjkcokpm == HGCFJKCOKPM.bright)
		{
			this.GFMIFHDEKGA(HGCFJKCOKPM.dark);
			return;
		}
		if (hgcfjkcokpm != HGCFJKCOKPM.dark)
		{
			return;
		}
		this.GFMIFHDEKGA(HGCFJKCOKPM.dark);
	}

	// Token: 0x06008D7C RID: 36220 RVA: 0x003EA963 File Offset: 0x003E8B63
	private void DJLCHMAHJLG()
	{
		AOBJLALDBAA.AGANFKKBPFO().BADOPKAOCPE("ContentFriendsPage.GetLocalizedCostData() - productData is null.", new UnityAction(this.IPFKLADLGDF));
		this.IKPGGOBAKNJ();
	}

	// Token: 0x06008D7D RID: 36221 RVA: 0x003EA986 File Offset: 0x003E8B86
	private void OnDisable()
	{
		if (AppManager.isQuitting)
		{
			return;
		}
		AOBJLALDBAA.EHBBFMCILPC.MANLHALMCIH("onThemeChange", new UnityAction(this.OnThemeChange));
	}

	// Token: 0x06008D7E RID: 36222 RVA: 0x003EA9AB File Offset: 0x003E8BAB
	private void ENNCLHFGHDO()
	{
		if (AppManager.isQuitting)
		{
			return;
		}
		AOBJLALDBAA.FILDBDMENPG().ONIBLJOFFPG("OnPopupCardOptionsUnlockWithSpException", new UnityAction(this.AKKAJEPEEME));
	}

	// Token: 0x06008D7F RID: 36223 RVA: 0x00003E52 File Offset: 0x00002052
	private void PABLFIJDFAD()
	{
	}

	// Token: 0x06008D80 RID: 36224 RVA: 0x003EA9D0 File Offset: 0x003E8BD0
	public void SetTheme(HGCFJKCOKPM OJKHMNEIGPF)
	{
		if (base.GetComponent<Image>() != null && base.GetComponent<Image>().sprite != null)
		{
			foreach (ThemeManagerBundles.CustomThemePropertiesBundles customThemePropertiesBundles in this.theme)
			{
				if (customThemePropertiesBundles.themeType == OJKHMNEIGPF)
				{
					if (customThemePropertiesBundles.themeImageSprite != null)
					{
						base.GetComponent<Image>().color = customThemePropertiesBundles.themeColorSprite;
						base.GetComponent<Image>().sprite = customThemePropertiesBundles.themeImageSprite;
						break;
					}
					break;
				}
			}
		}
		if (base.GetComponent<Button>() != null)
		{
			SpriteState spriteState = base.GetComponent<Button>().spriteState;
			if (spriteState.highlightedSprite != null)
			{
				foreach (ThemeManagerBundles.CustomThemePropertiesBundles customThemePropertiesBundles2 in this.theme)
				{
					if (customThemePropertiesBundles2.themeType == OJKHMNEIGPF)
					{
						if (customThemePropertiesBundles2.themeImageSprite != null)
						{
							spriteState.highlightedSprite = customThemePropertiesBundles2.themeImageSprite;
							break;
						}
						break;
					}
				}
			}
			if (spriteState.pressedSprite != null)
			{
				foreach (ThemeManagerBundles.CustomThemePropertiesBundles customThemePropertiesBundles3 in this.theme)
				{
					if (customThemePropertiesBundles3.themeType == OJKHMNEIGPF)
					{
						if (customThemePropertiesBundles3.themeImageSprite != null)
						{
							spriteState.pressedSprite = customThemePropertiesBundles3.themeImageSprite;
							break;
						}
						break;
					}
				}
			}
			if (spriteState.selectedSprite != null)
			{
				foreach (ThemeManagerBundles.CustomThemePropertiesBundles customThemePropertiesBundles4 in this.theme)
				{
					if (customThemePropertiesBundles4.themeType == OJKHMNEIGPF)
					{
						if (customThemePropertiesBundles4.themeImageSprite != null)
						{
							spriteState.selectedSprite = customThemePropertiesBundles4.themeImageSprite;
							break;
						}
						break;
					}
				}
			}
			base.GetComponent<Button>().spriteState = spriteState;
		}
		if (base.GetComponent<TextMeshProUGUI>() != null)
		{
			foreach (ThemeManagerBundles.CustomThemePropertiesBundles customThemePropertiesBundles5 in this.theme)
			{
				if (customThemePropertiesBundles5.themeType == OJKHMNEIGPF)
				{
					base.GetComponent<TextMeshProUGUI>().color = customThemePropertiesBundles5.themeColorText;
					break;
				}
			}
		}
	}

	// Token: 0x06008D81 RID: 36225 RVA: 0x003EAC70 File Offset: 0x003E8E70
	private void PABMEBKPBJO()
	{
		AOBJLALDBAA.AGANFKKBPFO().MFIMALJPCDP("OnLiveProfileThemeDownloadSuccess", new UnityAction(this.GAJOGDIBONK));
		this.KPJPIAKHLLO();
	}

	// Token: 0x06008D82 RID: 36226 RVA: 0x003EAC93 File Offset: 0x003E8E93
	private void OnEnable()
	{
		AOBJLALDBAA.EHBBFMCILPC.MFIMALJPCDP("onThemeChange", new UnityAction(this.OnThemeChange));
		this.OnThemeChange();
	}

	// Token: 0x06008D83 RID: 36227 RVA: 0x00003E52 File Offset: 0x00002052
	private void NDKAFCKLNBL()
	{
	}

	// Token: 0x06008D84 RID: 36228 RVA: 0x00003E52 File Offset: 0x00002052
	private void Start()
	{
	}

	// Token: 0x06008D85 RID: 36229 RVA: 0x003EACB6 File Offset: 0x003E8EB6
	private void EBANEHOGOIO()
	{
		if (AppManager.isQuitting)
		{
			return;
		}
		AOBJLALDBAA.NMGMNAKLLMI().NAMMLDPCHJO("saveslotsduplicatepos", new UnityAction(this.PLACAKEHLNC));
	}

	// Token: 0x06008D86 RID: 36230 RVA: 0x003EACDC File Offset: 0x003E8EDC
	public void NCNFDBKDKAF()
	{
		HGCFJKCOKPM hgcfjkcokpm = AKLFPGMDKLA.EHBBFMCILPC.JKCEGIPAANK();
		if (hgcfjkcokpm == HGCFJKCOKPM.bright)
		{
			this.DPJFGAGFHHB(HGCFJKCOKPM.dark);
			return;
		}
		if (hgcfjkcokpm != HGCFJKCOKPM.bright)
		{
			return;
		}
		this.KKALDAGCIGL(HGCFJKCOKPM.dark);
	}

	// Token: 0x06008D87 RID: 36231 RVA: 0x003EAD0B File Offset: 0x003E8F0B
	private void PBLDIMHDNNJ()
	{
		if (AppManager.isQuitting)
		{
			return;
		}
		AOBJLALDBAA.DBLAIDPICIG().MANLHALMCIH("layervideo", new UnityAction(this.PJPDHIGJJNG));
	}

	// Token: 0x06008D88 RID: 36232 RVA: 0x003EAD30 File Offset: 0x003E8F30
	private void ALBKMBOKICH()
	{
		AOBJLALDBAA.AGANFKKBPFO().MFIMALJPCDP("Asset bundle load operation failed during parallel mode.", new UnityAction(this.DCEBKBMBBMM));
		this.DCEBKBMBBMM();
	}

	// Token: 0x06008D89 RID: 36233 RVA: 0x003EAD54 File Offset: 0x003E8F54
	public void IKPGGOBAKNJ()
	{
		HGCFJKCOKPM hgcfjkcokpm = AKLFPGMDKLA.EHBBFMCILPC.JKCEGIPAANK();
		if (hgcfjkcokpm == HGCFJKCOKPM.bright)
		{
			this.KKALDAGCIGL(HGCFJKCOKPM.dark);
			return;
		}
		if (hgcfjkcokpm != HGCFJKCOKPM.dark)
		{
			return;
		}
		this.BNOBDMDKBAB(HGCFJKCOKPM.bright);
	}

	// Token: 0x06008D8A RID: 36234 RVA: 0x003EAD83 File Offset: 0x003E8F83
	private void FMGJGMNOCMP()
	{
		AOBJLALDBAA.FILDBDMENPG().MFIMALJPCDP("</b>", new UnityAction(this.BKPIFLODCFN));
		this.NCNFDBKDKAF();
	}

	// Token: 0x06008D8B RID: 36235 RVA: 0x003EADA6 File Offset: 0x003E8FA6
	private void AFGGOFOIFLC()
	{
		AOBJLALDBAA.DBLAIDPICIG().EFKNEJFLGED("stat5long", new UnityAction(this.ACHOBBDGNLG));
		this.PLACAKEHLNC();
	}

	// Token: 0x06008D8C RID: 36236 RVA: 0x003EADCC File Offset: 0x003E8FCC
	public void KKALDAGCIGL(HGCFJKCOKPM OJKHMNEIGPF)
	{
		if (base.GetComponent<Image>() != null && base.GetComponent<Image>().sprite != null)
		{
			foreach (ThemeManagerBundles.CustomThemePropertiesBundles customThemePropertiesBundles in this.theme)
			{
				if (customThemePropertiesBundles.themeType == OJKHMNEIGPF)
				{
					if (customThemePropertiesBundles.themeImageSprite != null)
					{
						base.GetComponent<Image>().color = customThemePropertiesBundles.themeColorSprite;
						base.GetComponent<Image>().sprite = customThemePropertiesBundles.themeImageSprite;
						break;
					}
					break;
				}
			}
		}
		if (base.GetComponent<Button>() != null)
		{
			SpriteState spriteState = base.GetComponent<Button>().spriteState;
			if (spriteState.highlightedSprite != null)
			{
				foreach (ThemeManagerBundles.CustomThemePropertiesBundles customThemePropertiesBundles2 in this.theme)
				{
					if (customThemePropertiesBundles2.themeType == OJKHMNEIGPF)
					{
						if (customThemePropertiesBundles2.themeImageSprite != null)
						{
							spriteState.highlightedSprite = customThemePropertiesBundles2.themeImageSprite;
							break;
						}
						break;
					}
				}
			}
			if (spriteState.pressedSprite != null)
			{
				foreach (ThemeManagerBundles.CustomThemePropertiesBundles customThemePropertiesBundles3 in this.theme)
				{
					if (customThemePropertiesBundles3.themeType == OJKHMNEIGPF)
					{
						if (customThemePropertiesBundles3.themeImageSprite != null)
						{
							spriteState.pressedSprite = customThemePropertiesBundles3.themeImageSprite;
							break;
						}
						break;
					}
				}
			}
			if (spriteState.selectedSprite != null)
			{
				foreach (ThemeManagerBundles.CustomThemePropertiesBundles customThemePropertiesBundles4 in this.theme)
				{
					if (customThemePropertiesBundles4.themeType == OJKHMNEIGPF)
					{
						if (customThemePropertiesBundles4.themeImageSprite != null)
						{
							spriteState.selectedSprite = customThemePropertiesBundles4.themeImageSprite;
							break;
						}
						break;
					}
				}
			}
			base.GetComponent<Button>().spriteState = spriteState;
		}
		if (base.GetComponent<TextMeshProUGUI>() != null)
		{
			foreach (ThemeManagerBundles.CustomThemePropertiesBundles customThemePropertiesBundles5 in this.theme)
			{
				if (customThemePropertiesBundles5.themeType == OJKHMNEIGPF)
				{
					base.GetComponent<TextMeshProUGUI>().color = customThemePropertiesBundles5.themeColorText;
					break;
				}
			}
		}
	}

	// Token: 0x06008D8D RID: 36237 RVA: 0x00003E52 File Offset: 0x00002052
	private void JENGJLCDEFJ()
	{
	}

	// Token: 0x06008D8E RID: 36238 RVA: 0x003EB06C File Offset: 0x003E926C
	public void PLACAKEHLNC()
	{
		HGCFJKCOKPM hgcfjkcokpm = AKLFPGMDKLA.EHBBFMCILPC.ICEOGOCOMJL();
		if (hgcfjkcokpm == HGCFJKCOKPM.bright)
		{
			this.BNOBDMDKBAB(HGCFJKCOKPM.dark);
			return;
		}
		if (hgcfjkcokpm != HGCFJKCOKPM.bright)
		{
			return;
		}
		this.KKALDAGCIGL(HGCFJKCOKPM.dark);
	}

	// Token: 0x06008D8F RID: 36239 RVA: 0x00003E52 File Offset: 0x00002052
	private void PAMMAEGAIDP()
	{
	}

	// Token: 0x06008D90 RID: 36240 RVA: 0x00003E52 File Offset: 0x00002052
	private void DDMCLNDOHCK()
	{
	}

	// Token: 0x06008D91 RID: 36241 RVA: 0x00003E52 File Offset: 0x00002052
	private void PCIAOCNDCLO()
	{
	}

	// Token: 0x06008D92 RID: 36242 RVA: 0x003EB09B File Offset: 0x003E929B
	private void PMPJLIGPKLK()
	{
		if (AppManager.isQuitting)
		{
			return;
		}
		AOBJLALDBAA.CEGAOMEEFBE().PBELMJCPJMK(" ", new UnityAction(this.GAJOGDIBONK));
	}

	// Token: 0x06008D93 RID: 36243 RVA: 0x00003E52 File Offset: 0x00002052
	private void HNHBHBEPLHC()
	{
	}

	// Token: 0x06008D94 RID: 36244 RVA: 0x00003E52 File Offset: 0x00002052
	private void DCOGIJMKHMJ()
	{
	}

	// Token: 0x06008D95 RID: 36245 RVA: 0x003EB0C0 File Offset: 0x003E92C0
	private void IMHILNMKAIN()
	{
		if (AppManager.isQuitting)
		{
			return;
		}
		AOBJLALDBAA.FILDBDMENPG().NAMMLDPCHJO("", new UnityAction(this.AKKAJEPEEME));
	}

	// Token: 0x06008D96 RID: 36246 RVA: 0x003EB0E8 File Offset: 0x003E92E8
	public void LMJABOJKKAO(HGCFJKCOKPM OJKHMNEIGPF)
	{
		if (base.GetComponent<Image>() != null && base.GetComponent<Image>().sprite != null)
		{
			foreach (ThemeManagerBundles.CustomThemePropertiesBundles customThemePropertiesBundles in this.theme)
			{
				if (customThemePropertiesBundles.themeType == OJKHMNEIGPF)
				{
					if (customThemePropertiesBundles.themeImageSprite != null)
					{
						base.GetComponent<Image>().color = customThemePropertiesBundles.themeColorSprite;
						base.GetComponent<Image>().sprite = customThemePropertiesBundles.themeImageSprite;
						break;
					}
					break;
				}
			}
		}
		if (base.GetComponent<Button>() != null)
		{
			SpriteState spriteState = base.GetComponent<Button>().spriteState;
			if (spriteState.highlightedSprite != null)
			{
				foreach (ThemeManagerBundles.CustomThemePropertiesBundles customThemePropertiesBundles2 in this.theme)
				{
					if (customThemePropertiesBundles2.themeType == OJKHMNEIGPF)
					{
						if (customThemePropertiesBundles2.themeImageSprite != null)
						{
							spriteState.highlightedSprite = customThemePropertiesBundles2.themeImageSprite;
							break;
						}
						break;
					}
				}
			}
			if (spriteState.pressedSprite != null)
			{
				foreach (ThemeManagerBundles.CustomThemePropertiesBundles customThemePropertiesBundles3 in this.theme)
				{
					if (customThemePropertiesBundles3.themeType == OJKHMNEIGPF)
					{
						if (customThemePropertiesBundles3.themeImageSprite != null)
						{
							spriteState.pressedSprite = customThemePropertiesBundles3.themeImageSprite;
							break;
						}
						break;
					}
				}
			}
			if (spriteState.selectedSprite != null)
			{
				foreach (ThemeManagerBundles.CustomThemePropertiesBundles customThemePropertiesBundles4 in this.theme)
				{
					if (customThemePropertiesBundles4.themeType == OJKHMNEIGPF)
					{
						if (customThemePropertiesBundles4.themeImageSprite != null)
						{
							spriteState.selectedSprite = customThemePropertiesBundles4.themeImageSprite;
							break;
						}
						break;
					}
				}
			}
			base.GetComponent<Button>().spriteState = spriteState;
		}
		if (base.GetComponent<TextMeshProUGUI>() != null)
		{
			foreach (ThemeManagerBundles.CustomThemePropertiesBundles customThemePropertiesBundles5 in this.theme)
			{
				if (customThemePropertiesBundles5.themeType == OJKHMNEIGPF)
				{
					base.GetComponent<TextMeshProUGUI>().color = customThemePropertiesBundles5.themeColorText;
					break;
				}
			}
		}
	}

	// Token: 0x06008D97 RID: 36247 RVA: 0x00003E52 File Offset: 0x00002052
	private void NCLALOLOIGP()
	{
	}

	// Token: 0x06008D98 RID: 36248 RVA: 0x003EB388 File Offset: 0x003E9588
	private void KPNLKBPCDAF()
	{
		if (AppManager.isQuitting)
		{
			return;
		}
		AOBJLALDBAA.BIAEAOMHBMM().PFAHGKEDFAE("FadeTop", new UnityAction(this.DMPMMJKOLNG));
	}

	// Token: 0x06008D99 RID: 36249 RVA: 0x003EB3B0 File Offset: 0x003E95B0
	public void FKONGDMDBEH()
	{
		HGCFJKCOKPM hgcfjkcokpm = AKLFPGMDKLA.EHBBFMCILPC.PINBMHFHEHD();
		if (hgcfjkcokpm == HGCFJKCOKPM.bright)
		{
			this.MFJFOHBIHMJ(HGCFJKCOKPM.dark);
			return;
		}
		if (hgcfjkcokpm != HGCFJKCOKPM.dark)
		{
			return;
		}
		this.GFMIFHDEKGA(HGCFJKCOKPM.dark);
	}

	// Token: 0x06008D9A RID: 36250 RVA: 0x003EB3DF File Offset: 0x003E95DF
	private void AADPIFCICBL()
	{
		AOBJLALDBAA.EHBBFMCILPC.EFKNEJFLGED("", new UnityAction(this.BEOACFOGONA));
		this.AKKAJEPEEME();
	}

	// Token: 0x06008D9B RID: 36251 RVA: 0x003EB402 File Offset: 0x003E9602
	private void HHDMNFGALBA()
	{
		if (AppManager.isQuitting)
		{
			return;
		}
		AOBJLALDBAA.AGANFKKBPFO().ECDBIBPNBCO("/", new UnityAction(this.DMFKFJDDBEG));
	}

	// Token: 0x06008D9C RID: 36252 RVA: 0x003EB427 File Offset: 0x003E9627
	private void AAKDPLPPLMC()
	{
		AOBJLALDBAA.AGANFKKBPFO().FNMOFCMDFJP("$en", new UnityAction(this.NCNFDBKDKAF));
		this.CJHBHLGFFFH();
	}

	// Token: 0x06008D9D RID: 36253 RVA: 0x003EB44C File Offset: 0x003E964C
	public void GFMIFHDEKGA(HGCFJKCOKPM OJKHMNEIGPF)
	{
		if (base.GetComponent<Image>() != null && base.GetComponent<Image>().sprite != null)
		{
			foreach (ThemeManagerBundles.CustomThemePropertiesBundles customThemePropertiesBundles in this.theme)
			{
				if (customThemePropertiesBundles.themeType == OJKHMNEIGPF)
				{
					if (customThemePropertiesBundles.themeImageSprite != null)
					{
						base.GetComponent<Image>().color = customThemePropertiesBundles.themeColorSprite;
						base.GetComponent<Image>().sprite = customThemePropertiesBundles.themeImageSprite;
						break;
					}
					break;
				}
			}
		}
		if (base.GetComponent<Button>() != null)
		{
			SpriteState spriteState = base.GetComponent<Button>().spriteState;
			if (spriteState.highlightedSprite != null)
			{
				foreach (ThemeManagerBundles.CustomThemePropertiesBundles customThemePropertiesBundles2 in this.theme)
				{
					if (customThemePropertiesBundles2.themeType == OJKHMNEIGPF)
					{
						if (customThemePropertiesBundles2.themeImageSprite != null)
						{
							spriteState.highlightedSprite = customThemePropertiesBundles2.themeImageSprite;
							break;
						}
						break;
					}
				}
			}
			if (spriteState.pressedSprite != null)
			{
				foreach (ThemeManagerBundles.CustomThemePropertiesBundles customThemePropertiesBundles3 in this.theme)
				{
					if (customThemePropertiesBundles3.themeType == OJKHMNEIGPF)
					{
						if (customThemePropertiesBundles3.themeImageSprite != null)
						{
							spriteState.pressedSprite = customThemePropertiesBundles3.themeImageSprite;
							break;
						}
						break;
					}
				}
			}
			if (spriteState.selectedSprite != null)
			{
				foreach (ThemeManagerBundles.CustomThemePropertiesBundles customThemePropertiesBundles4 in this.theme)
				{
					if (customThemePropertiesBundles4.themeType == OJKHMNEIGPF)
					{
						if (customThemePropertiesBundles4.themeImageSprite != null)
						{
							spriteState.selectedSprite = customThemePropertiesBundles4.themeImageSprite;
							break;
						}
						break;
					}
				}
			}
			base.GetComponent<Button>().spriteState = spriteState;
		}
		if (base.GetComponent<TextMeshProUGUI>() != null)
		{
			foreach (ThemeManagerBundles.CustomThemePropertiesBundles customThemePropertiesBundles5 in this.theme)
			{
				if (customThemePropertiesBundles5.themeType == OJKHMNEIGPF)
				{
					base.GetComponent<TextMeshProUGUI>().color = customThemePropertiesBundles5.themeColorText;
					break;
				}
			}
		}
	}

	// Token: 0x06008D9E RID: 36254 RVA: 0x00003E52 File Offset: 0x00002052
	private void LLDCFHGMAML()
	{
	}

	// Token: 0x06008D9F RID: 36255 RVA: 0x003EB6EC File Offset: 0x003E98EC
	public void DMPMMJKOLNG()
	{
		HGCFJKCOKPM hgcfjkcokpm = AKLFPGMDKLA.EHBBFMCILPC.ICEOGOCOMJL();
		if (hgcfjkcokpm == HGCFJKCOKPM.bright)
		{
			this.CNINPIEGLDJ(HGCFJKCOKPM.dark);
			return;
		}
		if (hgcfjkcokpm != HGCFJKCOKPM.dark)
		{
			return;
		}
		this.GFMIFHDEKGA(HGCFJKCOKPM.bright);
	}

	// Token: 0x06008DA0 RID: 36256 RVA: 0x00003E52 File Offset: 0x00002052
	private void EIHOIEGKJLA()
	{
	}

	// Token: 0x0400276F RID: 10095
	public List<ThemeManagerBundles.CustomThemePropertiesBundles> theme;

	// Token: 0x0200048F RID: 1167
	[Serializable]
	public class CustomThemePropertiesBundles
	{
		// Token: 0x04002770 RID: 10096
		public HGCFJKCOKPM themeType;

		// Token: 0x04002771 RID: 10097
		public Sprite themeImageSprite;

		// Token: 0x04002772 RID: 10098
		public Color32 themeColorText = new Color32(byte.MaxValue, byte.MaxValue, byte.MaxValue, byte.MaxValue);

		// Token: 0x04002773 RID: 10099
		public Color32 themeColorSprite = new Color32(byte.MaxValue, byte.MaxValue, byte.MaxValue, byte.MaxValue);
	}
}
