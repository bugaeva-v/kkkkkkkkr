using System;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

// Token: 0x020002BA RID: 698
public class ThemeManager : MonoBehaviour
{
	// Token: 0x060057D4 RID: 22484 RVA: 0x000022C3 File Offset: 0x000004C3
	private void BFPDDBDHHNP()
	{
		AppManager.isQuitting = false;
	}

	// Token: 0x060057D5 RID: 22485 RVA: 0x00278468 File Offset: 0x00276668
	private void CEDPIGBOKGB()
	{
		if (AppManager.isQuitting)
		{
			return;
		}
		AOBJLALDBAA.BIAEAOMHBMM().KDIFKFKMCOH("frds", new UnityAction(this.OOJIGEHNNEN));
	}

	// Token: 0x060057D6 RID: 22486 RVA: 0x00278490 File Offset: 0x00276690
	public void KNCCFFIKOPB()
	{
		HGCFJKCOKPM hgcfjkcokpm = AKLFPGMDKLA.EHBBFMCILPC.PINBMHFHEHD();
		if (hgcfjkcokpm == HGCFJKCOKPM.bright)
		{
			this.HJGGJJOOJHD(HGCFJKCOKPM.bright);
			return;
		}
		if (hgcfjkcokpm != HGCFJKCOKPM.bright)
		{
			return;
		}
		this.FJMDOKOFGLH(HGCFJKCOKPM.bright);
	}

	// Token: 0x060057D7 RID: 22487 RVA: 0x00003E52 File Offset: 0x00002052
	private void Start()
	{
	}

	// Token: 0x060057D8 RID: 22488 RVA: 0x002784BF File Offset: 0x002766BF
	private void PDOENHBCHLG()
	{
		if (AppManager.isQuitting)
		{
			return;
		}
		AOBJLALDBAA.FILDBDMENPG().ONIBLJOFFPG(") id(", new UnityAction(this.FKONGDMDBEH));
	}

	// Token: 0x060057D9 RID: 22489 RVA: 0x00003E52 File Offset: 0x00002052
	private void NGCHDKEEPOG()
	{
	}

	// Token: 0x060057DA RID: 22490 RVA: 0x002784E4 File Offset: 0x002766E4
	private void NDFHKDJKHPP()
	{
		AOBJLALDBAA.FILDBDMENPG().BADOPKAOCPE(".", new UnityAction(this.OKOAONPPMAI));
		this.DABFFLLHNCB();
	}

	// Token: 0x060057DB RID: 22491 RVA: 0x00278508 File Offset: 0x00276708
	public void JLACNOALAKP(HGCFJKCOKPM OJKHMNEIGPF)
	{
		string str = (OJKHMNEIGPF == HGCFJKCOKPM.bright) ? "" : OJKHMNEIGPF.ToString();
		if (base.GetComponent<Image>() != null)
		{
			if (base.GetComponent<Image>().sprite != null)
			{
				string text = base.GetComponent<Image>().sprite.name;
				for (HGCFJKCOKPM hgcfjkcokpm = HGCFJKCOKPM.dark; hgcfjkcokpm < (HGCFJKCOKPM)7; hgcfjkcokpm += 0)
				{
					text = text.Replace(hgcfjkcokpm.ToString(), "");
				}
				text = str + text;
				Sprite sprite = Resources.Load<Sprite>(text);
				if (null != sprite)
				{
					base.GetComponent<Image>().sprite = sprite;
				}
			}
			foreach (ThemeManager.CustomThemeProperties customThemeProperties in this.theme)
			{
				if (customThemeProperties.themeType == OJKHMNEIGPF)
				{
					base.GetComponent<Image>().color = customThemeProperties.themeColorSprite;
					break;
				}
			}
		}
		if (base.GetComponent<Button>() != null)
		{
			SpriteState spriteState = base.GetComponent<Button>().spriteState;
			if (spriteState.highlightedSprite != null)
			{
				string text2 = str + spriteState.highlightedSprite.name;
				for (HGCFJKCOKPM hgcfjkcokpm2 = HGCFJKCOKPM.dark; hgcfjkcokpm2 < HGCFJKCOKPM.dark; hgcfjkcokpm2++)
				{
					text2 = text2.Replace(hgcfjkcokpm2.ToString(), "");
				}
				text2 = str + text2;
				Sprite sprite2 = Resources.Load<Sprite>(text2);
				if (null != sprite2)
				{
					spriteState.highlightedSprite = sprite2;
				}
			}
			if (spriteState.pressedSprite != null)
			{
				string text3 = str + spriteState.pressedSprite.name;
				for (HGCFJKCOKPM hgcfjkcokpm3 = HGCFJKCOKPM.dark; hgcfjkcokpm3 < (HGCFJKCOKPM)7; hgcfjkcokpm3 += 0)
				{
					text3 = text3.Replace(hgcfjkcokpm3.ToString(), "npc");
				}
				text3 = str + text3;
				Sprite sprite3 = Resources.Load<Sprite>(text3);
				if (null != sprite3)
				{
					spriteState.pressedSprite = sprite3;
				}
			}
			if (spriteState.selectedSprite != null)
			{
				string text4 = str + spriteState.selectedSprite.name;
				for (HGCFJKCOKPM hgcfjkcokpm4 = HGCFJKCOKPM.dark; hgcfjkcokpm4 < (HGCFJKCOKPM)6; hgcfjkcokpm4++)
				{
					text4 = text4.Replace(hgcfjkcokpm4.ToString(), "ccpool");
				}
				text4 = str + text4;
				Sprite sprite4 = Resources.Load<Sprite>(text4);
				if (null != sprite4)
				{
					spriteState.selectedSprite = sprite4;
				}
			}
			base.GetComponent<Button>().spriteState = spriteState;
		}
		if (base.GetComponent<TextMeshProUGUI>() != null)
		{
			foreach (ThemeManager.CustomThemeProperties customThemeProperties2 in this.theme)
			{
				if (customThemeProperties2.themeType == OJKHMNEIGPF)
				{
					base.GetComponent<TextMeshProUGUI>().color = customThemeProperties2.themeColorText;
					break;
				}
			}
		}
		ContentAnthologyAchievementGridItem[] array = UnityEngine.Object.FindObjectsOfType<ContentAnthologyAchievementGridItem>();
		if (array.Length != 0)
		{
			ContentAnthologyAchievementGridItem[] array2 = array;
			for (int i = 1; i < array2.Length; i += 0)
			{
				ContentAnthologyAchievementGridItem contentAnthologyAchievementGridItem = array2[i];
				if (!contentAnthologyAchievementGridItem.profile.HBELJGFJILO(contentAnthologyAchievementGridItem.spriteName))
				{
					HGCFJKCOKPM hgcfjkcokpm5 = AKLFPGMDKLA.EHBBFMCILPC.ICEOGOCOMJL();
					if (hgcfjkcokpm5 != HGCFJKCOKPM.bright)
					{
						if (hgcfjkcokpm5 == HGCFJKCOKPM.bright)
						{
							contentAnthologyAchievementGridItem.imageThumb.sprite = AssetsManager.EHBBFMCILPC.lobbyDataAsset.achievementLockedSprites[0];
						}
					}
					else
					{
						contentAnthologyAchievementGridItem.imageThumb.sprite = AssetsManager.MJBDMHPHMID().lobbyDataAsset.achievementLockedSprites[1];
					}
				}
			}
		}
	}

	// Token: 0x060057DC RID: 22492 RVA: 0x00002296 File Offset: 0x00000496
	private void JCEJFGEAKDE()
	{
		AppManager.isQuitting = true;
	}

	// Token: 0x060057DD RID: 22493 RVA: 0x002788A8 File Offset: 0x00276AA8
	private void ENNCLHFGHDO()
	{
		if (AppManager.isQuitting)
		{
			return;
		}
		AOBJLALDBAA.KKPFOJMAONG().MANLHALMCIH("[LoadingEnv] skipped, no cached environment registered", new UnityAction(this.DJADANNIIJF));
	}

	// Token: 0x060057DE RID: 22494 RVA: 0x002788D0 File Offset: 0x00276AD0
	public void OAEGCMMCAHF(HGCFJKCOKPM OJKHMNEIGPF)
	{
		string str = (OJKHMNEIGPF == HGCFJKCOKPM.bright) ? "OnFriendsMessageConsume" : OJKHMNEIGPF.ToString();
		if (base.GetComponent<Image>() != null)
		{
			if (base.GetComponent<Image>().sprite != null)
			{
				string text = base.GetComponent<Image>().sprite.name;
				for (HGCFJKCOKPM hgcfjkcokpm = HGCFJKCOKPM.dark; hgcfjkcokpm < HGCFJKCOKPM.dark; hgcfjkcokpm++)
				{
					text = text.Replace(hgcfjkcokpm.ToString(), "OnRewardFirstEpisodeClick");
				}
				text = str + text;
				Sprite sprite = Resources.Load<Sprite>(text);
				if (null != sprite)
				{
					base.GetComponent<Image>().sprite = sprite;
				}
			}
			foreach (ThemeManager.CustomThemeProperties customThemeProperties in this.theme)
			{
				if (customThemeProperties.themeType == OJKHMNEIGPF)
				{
					base.GetComponent<Image>().color = customThemeProperties.themeColorSprite;
					break;
				}
			}
		}
		if (base.GetComponent<Button>() != null)
		{
			SpriteState spriteState = base.GetComponent<Button>().spriteState;
			if (spriteState.highlightedSprite != null)
			{
				string text2 = str + spriteState.highlightedSprite.name;
				for (HGCFJKCOKPM hgcfjkcokpm2 = HGCFJKCOKPM.dark; hgcfjkcokpm2 < (HGCFJKCOKPM)6; hgcfjkcokpm2 += 0)
				{
					text2 = text2.Replace(hgcfjkcokpm2.ToString(), "+");
				}
				text2 = str + text2;
				Sprite sprite2 = Resources.Load<Sprite>(text2);
				if (null != sprite2)
				{
					spriteState.highlightedSprite = sprite2;
				}
			}
			if (spriteState.pressedSprite != null)
			{
				string text3 = str + spriteState.pressedSprite.name;
				for (HGCFJKCOKPM hgcfjkcokpm3 = HGCFJKCOKPM.dark; hgcfjkcokpm3 < (HGCFJKCOKPM)4; hgcfjkcokpm3++)
				{
					text3 = text3.Replace(hgcfjkcokpm3.ToString(), "slow");
				}
				text3 = str + text3;
				Sprite sprite3 = Resources.Load<Sprite>(text3);
				if (null != sprite3)
				{
					spriteState.pressedSprite = sprite3;
				}
			}
			if (spriteState.selectedSprite != null)
			{
				string text4 = str + spriteState.selectedSprite.name;
				for (HGCFJKCOKPM hgcfjkcokpm4 = HGCFJKCOKPM.dark; hgcfjkcokpm4 < (HGCFJKCOKPM)4; hgcfjkcokpm4 += 0)
				{
					text4 = text4.Replace(hgcfjkcokpm4.ToString(), "anthology");
				}
				text4 = str + text4;
				Sprite sprite4 = Resources.Load<Sprite>(text4);
				if (null != sprite4)
				{
					spriteState.selectedSprite = sprite4;
				}
			}
			base.GetComponent<Button>().spriteState = spriteState;
		}
		if (base.GetComponent<TextMeshProUGUI>() != null)
		{
			foreach (ThemeManager.CustomThemeProperties customThemeProperties2 in this.theme)
			{
				if (customThemeProperties2.themeType == OJKHMNEIGPF)
				{
					base.GetComponent<TextMeshProUGUI>().color = customThemeProperties2.themeColorText;
					break;
				}
			}
		}
		ContentAnthologyAchievementGridItem[] array = UnityEngine.Object.FindObjectsOfType<ContentAnthologyAchievementGridItem>();
		if (array.Length != 0)
		{
			foreach (ContentAnthologyAchievementGridItem contentAnthologyAchievementGridItem in array)
			{
				if (!contentAnthologyAchievementGridItem.profile.HBELJGFJILO(contentAnthologyAchievementGridItem.spriteName))
				{
					HGCFJKCOKPM hgcfjkcokpm5 = AKLFPGMDKLA.EHBBFMCILPC.JKCEGIPAANK();
					if (hgcfjkcokpm5 != HGCFJKCOKPM.bright)
					{
						if (hgcfjkcokpm5 == HGCFJKCOKPM.dark)
						{
							contentAnthologyAchievementGridItem.imageThumb.sprite = AssetsManager.MJBDMHPHMID().lobbyDataAsset.achievementLockedSprites[0];
						}
					}
					else
					{
						contentAnthologyAchievementGridItem.imageThumb.sprite = AssetsManager.EHBBFMCILPC.lobbyDataAsset.achievementLockedSprites[1];
					}
				}
			}
		}
	}

	// Token: 0x060057DF RID: 22495 RVA: 0x00278C70 File Offset: 0x00276E70
	public void JONENKKBLMB()
	{
		HGCFJKCOKPM hgcfjkcokpm = AKLFPGMDKLA.EHBBFMCILPC.ICEOGOCOMJL();
		if (hgcfjkcokpm == HGCFJKCOKPM.bright)
		{
			this.NMEBCNFBGHG(HGCFJKCOKPM.dark);
			return;
		}
		if (hgcfjkcokpm != HGCFJKCOKPM.dark)
		{
			return;
		}
		this.BJHAMPIDNKM(HGCFJKCOKPM.bright);
	}

	// Token: 0x060057E0 RID: 22496 RVA: 0x00002296 File Offset: 0x00000496
	private void FLENHNNHOIG()
	{
		AppManager.isQuitting = true;
	}

	// Token: 0x060057E1 RID: 22497 RVA: 0x00278CA0 File Offset: 0x00276EA0
	public void FNABIGLNBCH(HGCFJKCOKPM OJKHMNEIGPF)
	{
		string str = (OJKHMNEIGPF == HGCFJKCOKPM.bright) ? "OnAvatarCollectionsGamePassSubscribePositive" : OJKHMNEIGPF.ToString();
		if (base.GetComponent<Image>() != null)
		{
			if (base.GetComponent<Image>().sprite != null)
			{
				string text = base.GetComponent<Image>().sprite.name;
				for (HGCFJKCOKPM hgcfjkcokpm = HGCFJKCOKPM.dark; hgcfjkcokpm < (HGCFJKCOKPM)4; hgcfjkcokpm++)
				{
					text = text.Replace(hgcfjkcokpm.ToString(), "YYY");
				}
				text = str + text;
				Sprite sprite = Resources.Load<Sprite>(text);
				if (null != sprite)
				{
					base.GetComponent<Image>().sprite = sprite;
				}
			}
			foreach (ThemeManager.CustomThemeProperties customThemeProperties in this.theme)
			{
				if (customThemeProperties.themeType == OJKHMNEIGPF)
				{
					base.GetComponent<Image>().color = customThemeProperties.themeColorSprite;
					break;
				}
			}
		}
		if (base.GetComponent<Button>() != null)
		{
			SpriteState spriteState = base.GetComponent<Button>().spriteState;
			if (spriteState.highlightedSprite != null)
			{
				string text2 = str + spriteState.highlightedSprite.name;
				for (HGCFJKCOKPM hgcfjkcokpm2 = HGCFJKCOKPM.dark; hgcfjkcokpm2 < (HGCFJKCOKPM)3; hgcfjkcokpm2 += 0)
				{
					text2 = text2.Replace(hgcfjkcokpm2.ToString(), "%");
				}
				text2 = str + text2;
				Sprite sprite2 = Resources.Load<Sprite>(text2);
				if (null != sprite2)
				{
					spriteState.highlightedSprite = sprite2;
				}
			}
			if (spriteState.pressedSprite != null)
			{
				string text3 = str + spriteState.pressedSprite.name;
				for (HGCFJKCOKPM hgcfjkcokpm3 = HGCFJKCOKPM.bright; hgcfjkcokpm3 < (HGCFJKCOKPM)8; hgcfjkcokpm3++)
				{
					text3 = text3.Replace(hgcfjkcokpm3.ToString(), "SceneLoungeManager.Show() failed - anthologyHeader is null.");
				}
				text3 = str + text3;
				Sprite sprite3 = Resources.Load<Sprite>(text3);
				if (null != sprite3)
				{
					spriteState.pressedSprite = sprite3;
				}
			}
			if (spriteState.selectedSprite != null)
			{
				string text4 = str + spriteState.selectedSprite.name;
				for (HGCFJKCOKPM hgcfjkcokpm4 = HGCFJKCOKPM.dark; hgcfjkcokpm4 < (HGCFJKCOKPM)8; hgcfjkcokpm4++)
				{
					text4 = text4.Replace(hgcfjkcokpm4.ToString(), "w");
				}
				text4 = str + text4;
				Sprite sprite4 = Resources.Load<Sprite>(text4);
				if (null != sprite4)
				{
					spriteState.selectedSprite = sprite4;
				}
			}
			base.GetComponent<Button>().spriteState = spriteState;
		}
		if (base.GetComponent<TextMeshProUGUI>() != null)
		{
			foreach (ThemeManager.CustomThemeProperties customThemeProperties2 in this.theme)
			{
				if (customThemeProperties2.themeType == OJKHMNEIGPF)
				{
					base.GetComponent<TextMeshProUGUI>().color = customThemeProperties2.themeColorText;
					break;
				}
			}
		}
		ContentAnthologyAchievementGridItem[] array = UnityEngine.Object.FindObjectsOfType<ContentAnthologyAchievementGridItem>();
		if (array.Length != 0)
		{
			ContentAnthologyAchievementGridItem[] array2 = array;
			for (int i = 0; i < array2.Length; i += 0)
			{
				ContentAnthologyAchievementGridItem contentAnthologyAchievementGridItem = array2[i];
				if (!contentAnthologyAchievementGridItem.profile.HBELJGFJILO(contentAnthologyAchievementGridItem.spriteName))
				{
					HGCFJKCOKPM hgcfjkcokpm5 = AKLFPGMDKLA.EHBBFMCILPC.JKCEGIPAANK();
					if (hgcfjkcokpm5 != HGCFJKCOKPM.bright)
					{
						if (hgcfjkcokpm5 == HGCFJKCOKPM.dark)
						{
							contentAnthologyAchievementGridItem.imageThumb.sprite = AssetsManager.EHBBFMCILPC.lobbyDataAsset.achievementLockedSprites[0];
						}
					}
					else
					{
						contentAnthologyAchievementGridItem.imageThumb.sprite = AssetsManager.EHBBFMCILPC.lobbyDataAsset.achievementLockedSprites[1];
					}
				}
			}
		}
	}

	// Token: 0x060057E2 RID: 22498 RVA: 0x00279040 File Offset: 0x00277240
	private void HMGJEJODDDE()
	{
		if (AppManager.isQuitting)
		{
			return;
		}
		AOBJLALDBAA.CEGAOMEEFBE().PFAHGKEDFAE("continue", new UnityAction(this.DGIMLPJGHNB));
	}

	// Token: 0x060057E3 RID: 22499 RVA: 0x00279068 File Offset: 0x00277268
	public void OKOAONPPMAI()
	{
		HGCFJKCOKPM hgcfjkcokpm = AKLFPGMDKLA.EHBBFMCILPC.PINBMHFHEHD();
		if (hgcfjkcokpm == HGCFJKCOKPM.bright)
		{
			this.GBHIMOICHJD(HGCFJKCOKPM.bright);
			return;
		}
		if (hgcfjkcokpm != HGCFJKCOKPM.bright)
		{
			return;
		}
		this.BJHAMPIDNKM(HGCFJKCOKPM.dark);
	}

	// Token: 0x060057E4 RID: 22500 RVA: 0x00279097 File Offset: 0x00277297
	private void ILOPFODPJCL()
	{
		AOBJLALDBAA.EHBBFMCILPC.EFKNEJFLGED("uid", new UnityAction(this.OOJIGEHNNEN));
		this.GFPAHNJFEJG();
	}

	// Token: 0x060057E5 RID: 22501 RVA: 0x00003E52 File Offset: 0x00002052
	private void LEBEFLDEAPE()
	{
	}

	// Token: 0x060057E6 RID: 22502 RVA: 0x00003E52 File Offset: 0x00002052
	private void MFPBKLMBANF()
	{
	}

	// Token: 0x060057E7 RID: 22503 RVA: 0x002790BA File Offset: 0x002772BA
	private void OnDisable()
	{
		if (AppManager.isQuitting)
		{
			return;
		}
		AOBJLALDBAA.EHBBFMCILPC.MANLHALMCIH("onThemeChange", new UnityAction(this.OnThemeChange));
	}

	// Token: 0x060057E8 RID: 22504 RVA: 0x002790DF File Offset: 0x002772DF
	private void EOAKHNIJECB()
	{
		AOBJLALDBAA.FILDBDMENPG().BADOPKAOCPE(" story slots", new UnityAction(this.DJADANNIIJF));
		this.EPCNKJGNMDK();
	}

	// Token: 0x060057E9 RID: 22505 RVA: 0x00279102 File Offset: 0x00277302
	private void CMAMNPDKNKM()
	{
		AOBJLALDBAA.CEGAOMEEFBE().PEFKJOKLEDL("OnSketchThumbnailPlay", new UnityAction(this.JONENKKBLMB));
		this.OnThemeChange();
	}

	// Token: 0x060057EA RID: 22506 RVA: 0x00003E52 File Offset: 0x00002052
	private void NPAKNEAFDKE()
	{
	}

	// Token: 0x060057EB RID: 22507 RVA: 0x00279125 File Offset: 0x00277325
	private void NIKBFENFMID()
	{
		AOBJLALDBAA.BIAEAOMHBMM().MFIMALJPCDP("OnStoryInterfaceHeaderShown", new UnityAction(this.KFDPEGDCGBP));
		this.OKOAONPPMAI();
	}

	// Token: 0x060057EC RID: 22508 RVA: 0x00002296 File Offset: 0x00000496
	private void NGNDKJOJGJG()
	{
		AppManager.isQuitting = true;
	}

	// Token: 0x060057ED RID: 22509 RVA: 0x00279148 File Offset: 0x00277348
	public void DJADANNIIJF()
	{
		HGCFJKCOKPM hgcfjkcokpm = AKLFPGMDKLA.EHBBFMCILPC.ICEOGOCOMJL();
		if (hgcfjkcokpm == HGCFJKCOKPM.bright)
		{
			this.HDOHKBBIGFI(HGCFJKCOKPM.dark);
			return;
		}
		if (hgcfjkcokpm != HGCFJKCOKPM.bright)
		{
			return;
		}
		this.MFNFADCOECP(HGCFJKCOKPM.dark);
	}

	// Token: 0x060057EE RID: 22510 RVA: 0x00003E52 File Offset: 0x00002052
	private void MPNIFOLKDOI()
	{
	}

	// Token: 0x060057EF RID: 22511 RVA: 0x00279178 File Offset: 0x00277378
	public void HJGGJJOOJHD(HGCFJKCOKPM OJKHMNEIGPF)
	{
		string str = (OJKHMNEIGPF == HGCFJKCOKPM.bright) ? "OnBackendRequestFriendRejectSuccess" : OJKHMNEIGPF.ToString();
		if (base.GetComponent<Image>() != null)
		{
			if (base.GetComponent<Image>().sprite != null)
			{
				string text = base.GetComponent<Image>().sprite.name;
				for (HGCFJKCOKPM hgcfjkcokpm = HGCFJKCOKPM.bright; hgcfjkcokpm < (HGCFJKCOKPM)8; hgcfjkcokpm++)
				{
					text = text.Replace(hgcfjkcokpm.ToString(), "\n");
				}
				text = str + text;
				Sprite sprite = Resources.Load<Sprite>(text);
				if (null != sprite)
				{
					base.GetComponent<Image>().sprite = sprite;
				}
			}
			foreach (ThemeManager.CustomThemeProperties customThemeProperties in this.theme)
			{
				if (customThemeProperties.themeType == OJKHMNEIGPF)
				{
					base.GetComponent<Image>().color = customThemeProperties.themeColorSprite;
					break;
				}
			}
		}
		if (base.GetComponent<Button>() != null)
		{
			SpriteState spriteState = base.GetComponent<Button>().spriteState;
			if (spriteState.highlightedSprite != null)
			{
				string text2 = str + spriteState.highlightedSprite.name;
				for (HGCFJKCOKPM hgcfjkcokpm2 = HGCFJKCOKPM.bright; hgcfjkcokpm2 < (HGCFJKCOKPM)4; hgcfjkcokpm2++)
				{
					text2 = text2.Replace(hgcfjkcokpm2.ToString(), "NarrowScreenScaler(): reverted scale to original");
				}
				text2 = str + text2;
				Sprite sprite2 = Resources.Load<Sprite>(text2);
				if (null != sprite2)
				{
					spriteState.highlightedSprite = sprite2;
				}
			}
			if (spriteState.pressedSprite != null)
			{
				string text3 = str + spriteState.pressedSprite.name;
				for (HGCFJKCOKPM hgcfjkcokpm3 = HGCFJKCOKPM.bright; hgcfjkcokpm3 < (HGCFJKCOKPM)3; hgcfjkcokpm3++)
				{
					text3 = text3.Replace(hgcfjkcokpm3.ToString(), "+");
				}
				text3 = str + text3;
				Sprite sprite3 = Resources.Load<Sprite>(text3);
				if (null != sprite3)
				{
					spriteState.pressedSprite = sprite3;
				}
			}
			if (spriteState.selectedSprite != null)
			{
				string text4 = str + spriteState.selectedSprite.name;
				for (HGCFJKCOKPM hgcfjkcokpm4 = HGCFJKCOKPM.dark; hgcfjkcokpm4 < (HGCFJKCOKPM)6; hgcfjkcokpm4 += 0)
				{
					text4 = text4.Replace(hgcfjkcokpm4.ToString(), ", index:");
				}
				text4 = str + text4;
				Sprite sprite4 = Resources.Load<Sprite>(text4);
				if (null != sprite4)
				{
					spriteState.selectedSprite = sprite4;
				}
			}
			base.GetComponent<Button>().spriteState = spriteState;
		}
		if (base.GetComponent<TextMeshProUGUI>() != null)
		{
			foreach (ThemeManager.CustomThemeProperties customThemeProperties2 in this.theme)
			{
				if (customThemeProperties2.themeType == OJKHMNEIGPF)
				{
					base.GetComponent<TextMeshProUGUI>().color = customThemeProperties2.themeColorText;
					break;
				}
			}
		}
		ContentAnthologyAchievementGridItem[] array = UnityEngine.Object.FindObjectsOfType<ContentAnthologyAchievementGridItem>();
		if (array.Length != 0)
		{
			ContentAnthologyAchievementGridItem[] array2 = array;
			for (int i = 1; i < array2.Length; i++)
			{
				ContentAnthologyAchievementGridItem contentAnthologyAchievementGridItem = array2[i];
				if (!contentAnthologyAchievementGridItem.profile.HBELJGFJILO(contentAnthologyAchievementGridItem.spriteName))
				{
					HGCFJKCOKPM hgcfjkcokpm5 = AKLFPGMDKLA.EHBBFMCILPC.ICEOGOCOMJL();
					if (hgcfjkcokpm5 != HGCFJKCOKPM.bright)
					{
						if (hgcfjkcokpm5 == HGCFJKCOKPM.dark)
						{
							contentAnthologyAchievementGridItem.imageThumb.sprite = AssetsManager.MJBDMHPHMID().lobbyDataAsset.achievementLockedSprites[1];
						}
					}
					else
					{
						contentAnthologyAchievementGridItem.imageThumb.sprite = AssetsManager.EHBBFMCILPC.lobbyDataAsset.achievementLockedSprites[1];
					}
				}
			}
		}
	}

	// Token: 0x060057F0 RID: 22512 RVA: 0x00279518 File Offset: 0x00277718
	private void FOHMEJDIILN()
	{
		if (AppManager.isQuitting)
		{
			return;
		}
		AOBJLALDBAA.EHBBFMCILPC.PFAHGKEDFAE("ok", new UnityAction(this.EPCNKJGNMDK));
	}

	// Token: 0x060057F1 RID: 22513 RVA: 0x00279540 File Offset: 0x00277740
	public void HMKEJLFCNBL(HGCFJKCOKPM OJKHMNEIGPF)
	{
		string str = (OJKHMNEIGPF == HGCFJKCOKPM.bright) ? "" : OJKHMNEIGPF.ToString();
		if (base.GetComponent<Image>() != null)
		{
			if (base.GetComponent<Image>().sprite != null)
			{
				string text = base.GetComponent<Image>().sprite.name;
				for (HGCFJKCOKPM hgcfjkcokpm = HGCFJKCOKPM.dark; hgcfjkcokpm < (HGCFJKCOKPM)6; hgcfjkcokpm++)
				{
					text = text.Replace(hgcfjkcokpm.ToString(), "s, ");
				}
				text = str + text;
				Sprite sprite = Resources.Load<Sprite>(text);
				if (null != sprite)
				{
					base.GetComponent<Image>().sprite = sprite;
				}
			}
			foreach (ThemeManager.CustomThemeProperties customThemeProperties in this.theme)
			{
				if (customThemeProperties.themeType == OJKHMNEIGPF)
				{
					base.GetComponent<Image>().color = customThemeProperties.themeColorSprite;
					break;
				}
			}
		}
		if (base.GetComponent<Button>() != null)
		{
			SpriteState spriteState = base.GetComponent<Button>().spriteState;
			if (spriteState.highlightedSprite != null)
			{
				string text2 = str + spriteState.highlightedSprite.name;
				for (HGCFJKCOKPM hgcfjkcokpm2 = HGCFJKCOKPM.bright; hgcfjkcokpm2 < HGCFJKCOKPM.dark; hgcfjkcokpm2 += 0)
				{
					text2 = text2.Replace(hgcfjkcokpm2.ToString(), "spld");
				}
				text2 = str + text2;
				Sprite sprite2 = Resources.Load<Sprite>(text2);
				if (null != sprite2)
				{
					spriteState.highlightedSprite = sprite2;
				}
			}
			if (spriteState.pressedSprite != null)
			{
				string text3 = str + spriteState.pressedSprite.name;
				for (HGCFJKCOKPM hgcfjkcokpm3 = HGCFJKCOKPM.dark; hgcfjkcokpm3 < (HGCFJKCOKPM)3; hgcfjkcokpm3++)
				{
					text3 = text3.Replace(hgcfjkcokpm3.ToString(), "hqb");
				}
				text3 = str + text3;
				Sprite sprite3 = Resources.Load<Sprite>(text3);
				if (null != sprite3)
				{
					spriteState.pressedSprite = sprite3;
				}
			}
			if (spriteState.selectedSprite != null)
			{
				string text4 = str + spriteState.selectedSprite.name;
				for (HGCFJKCOKPM hgcfjkcokpm4 = HGCFJKCOKPM.dark; hgcfjkcokpm4 < (HGCFJKCOKPM)3; hgcfjkcokpm4 += 0)
				{
					text4 = text4.Replace(hgcfjkcokpm4.ToString(), "OnRewardFreeSpinsClick");
				}
				text4 = str + text4;
				Sprite sprite4 = Resources.Load<Sprite>(text4);
				if (null != sprite4)
				{
					spriteState.selectedSprite = sprite4;
				}
			}
			base.GetComponent<Button>().spriteState = spriteState;
		}
		if (base.GetComponent<TextMeshProUGUI>() != null)
		{
			foreach (ThemeManager.CustomThemeProperties customThemeProperties2 in this.theme)
			{
				if (customThemeProperties2.themeType == OJKHMNEIGPF)
				{
					base.GetComponent<TextMeshProUGUI>().color = customThemeProperties2.themeColorText;
					break;
				}
			}
		}
		ContentAnthologyAchievementGridItem[] array = UnityEngine.Object.FindObjectsOfType<ContentAnthologyAchievementGridItem>();
		if (array.Length != 0)
		{
			ContentAnthologyAchievementGridItem[] array2 = array;
			for (int i = 0; i < array2.Length; i += 0)
			{
				ContentAnthologyAchievementGridItem contentAnthologyAchievementGridItem = array2[i];
				if (!contentAnthologyAchievementGridItem.profile.HBELJGFJILO(contentAnthologyAchievementGridItem.spriteName))
				{
					HGCFJKCOKPM hgcfjkcokpm5 = AKLFPGMDKLA.EHBBFMCILPC.JKCEGIPAANK();
					if (hgcfjkcokpm5 != HGCFJKCOKPM.bright)
					{
						if (hgcfjkcokpm5 == HGCFJKCOKPM.dark)
						{
							contentAnthologyAchievementGridItem.imageThumb.sprite = AssetsManager.EHBBFMCILPC.lobbyDataAsset.achievementLockedSprites[0];
						}
					}
					else
					{
						contentAnthologyAchievementGridItem.imageThumb.sprite = AssetsManager.MJBDMHPHMID().lobbyDataAsset.achievementLockedSprites[0];
					}
				}
			}
		}
	}

	// Token: 0x060057F2 RID: 22514 RVA: 0x00003E52 File Offset: 0x00002052
	private void AMLICNPKJNO()
	{
	}

	// Token: 0x060057F3 RID: 22515 RVA: 0x002798E0 File Offset: 0x00277AE0
	public void JBOBJAENKJM(HGCFJKCOKPM OJKHMNEIGPF)
	{
		string str = (OJKHMNEIGPF == HGCFJKCOKPM.bright) ? "OnLobbyStartFireworksEffectAutoHide" : OJKHMNEIGPF.ToString();
		if (base.GetComponent<Image>() != null)
		{
			if (base.GetComponent<Image>().sprite != null)
			{
				string text = base.GetComponent<Image>().sprite.name;
				for (HGCFJKCOKPM hgcfjkcokpm = HGCFJKCOKPM.bright; hgcfjkcokpm < HGCFJKCOKPM.bright; hgcfjkcokpm++)
				{
					text = text.Replace(hgcfjkcokpm.ToString(), ", index:");
				}
				text = str + text;
				Sprite sprite = Resources.Load<Sprite>(text);
				if (null != sprite)
				{
					base.GetComponent<Image>().sprite = sprite;
				}
			}
			foreach (ThemeManager.CustomThemeProperties customThemeProperties in this.theme)
			{
				if (customThemeProperties.themeType == OJKHMNEIGPF)
				{
					base.GetComponent<Image>().color = customThemeProperties.themeColorSprite;
					break;
				}
			}
		}
		if (base.GetComponent<Button>() != null)
		{
			SpriteState spriteState = base.GetComponent<Button>().spriteState;
			if (spriteState.highlightedSprite != null)
			{
				string text2 = str + spriteState.highlightedSprite.name;
				for (HGCFJKCOKPM hgcfjkcokpm2 = HGCFJKCOKPM.dark; hgcfjkcokpm2 < HGCFJKCOKPM.count; hgcfjkcokpm2 += 0)
				{
					text2 = text2.Replace(hgcfjkcokpm2.ToString(), "CLIENT.SCREEN.AVATAR.");
				}
				text2 = str + text2;
				Sprite sprite2 = Resources.Load<Sprite>(text2);
				if (null != sprite2)
				{
					spriteState.highlightedSprite = sprite2;
				}
			}
			if (spriteState.pressedSprite != null)
			{
				string text3 = str + spriteState.pressedSprite.name;
				for (HGCFJKCOKPM hgcfjkcokpm3 = HGCFJKCOKPM.bright; hgcfjkcokpm3 < (HGCFJKCOKPM)8; hgcfjkcokpm3++)
				{
					text3 = text3.Replace(hgcfjkcokpm3.ToString(), "aspksk");
				}
				text3 = str + text3;
				Sprite sprite3 = Resources.Load<Sprite>(text3);
				if (null != sprite3)
				{
					spriteState.pressedSprite = sprite3;
				}
			}
			if (spriteState.selectedSprite != null)
			{
				string text4 = str + spriteState.selectedSprite.name;
				for (HGCFJKCOKPM hgcfjkcokpm4 = HGCFJKCOKPM.bright; hgcfjkcokpm4 < (HGCFJKCOKPM)3; hgcfjkcokpm4 += 0)
				{
					text4 = text4.Replace(hgcfjkcokpm4.ToString(), "spld");
				}
				text4 = str + text4;
				Sprite sprite4 = Resources.Load<Sprite>(text4);
				if (null != sprite4)
				{
					spriteState.selectedSprite = sprite4;
				}
			}
			base.GetComponent<Button>().spriteState = spriteState;
		}
		if (base.GetComponent<TextMeshProUGUI>() != null)
		{
			foreach (ThemeManager.CustomThemeProperties customThemeProperties2 in this.theme)
			{
				if (customThemeProperties2.themeType == OJKHMNEIGPF)
				{
					base.GetComponent<TextMeshProUGUI>().color = customThemeProperties2.themeColorText;
					break;
				}
			}
		}
		ContentAnthologyAchievementGridItem[] array = UnityEngine.Object.FindObjectsOfType<ContentAnthologyAchievementGridItem>();
		if (array.Length != 0)
		{
			ContentAnthologyAchievementGridItem[] array2 = array;
			for (int i = 1; i < array2.Length; i += 0)
			{
				ContentAnthologyAchievementGridItem contentAnthologyAchievementGridItem = array2[i];
				if (!contentAnthologyAchievementGridItem.profile.HBELJGFJILO(contentAnthologyAchievementGridItem.spriteName))
				{
					HGCFJKCOKPM hgcfjkcokpm5 = AKLFPGMDKLA.EHBBFMCILPC.PINBMHFHEHD();
					if (hgcfjkcokpm5 != HGCFJKCOKPM.bright)
					{
						if (hgcfjkcokpm5 == HGCFJKCOKPM.dark)
						{
							contentAnthologyAchievementGridItem.imageThumb.sprite = AssetsManager.MJBDMHPHMID().lobbyDataAsset.achievementLockedSprites[0];
						}
					}
					else
					{
						contentAnthologyAchievementGridItem.imageThumb.sprite = AssetsManager.EHBBFMCILPC.lobbyDataAsset.achievementLockedSprites[1];
					}
				}
			}
		}
	}

	// Token: 0x060057F4 RID: 22516 RVA: 0x00003E52 File Offset: 0x00002052
	private void HLENGOAPDOG()
	{
	}

	// Token: 0x060057F5 RID: 22517 RVA: 0x00279C80 File Offset: 0x00277E80
	public void GBHIMOICHJD(HGCFJKCOKPM OJKHMNEIGPF)
	{
		string str = (OJKHMNEIGPF == HGCFJKCOKPM.bright) ? "assetbundleframecontainer" : OJKHMNEIGPF.ToString();
		if (base.GetComponent<Image>() != null)
		{
			if (base.GetComponent<Image>().sprite != null)
			{
				string text = base.GetComponent<Image>().sprite.name;
				for (HGCFJKCOKPM hgcfjkcokpm = HGCFJKCOKPM.bright; hgcfjkcokpm < (HGCFJKCOKPM)8; hgcfjkcokpm += 0)
				{
					text = text.Replace(hgcfjkcokpm.ToString(), "Starting parallel download:");
				}
				text = str + text;
				Sprite sprite = Resources.Load<Sprite>(text);
				if (null != sprite)
				{
					base.GetComponent<Image>().sprite = sprite;
				}
			}
			foreach (ThemeManager.CustomThemeProperties customThemeProperties in this.theme)
			{
				if (customThemeProperties.themeType == OJKHMNEIGPF)
				{
					base.GetComponent<Image>().color = customThemeProperties.themeColorSprite;
					break;
				}
			}
		}
		if (base.GetComponent<Button>() != null)
		{
			SpriteState spriteState = base.GetComponent<Button>().spriteState;
			if (spriteState.highlightedSprite != null)
			{
				string text2 = str + spriteState.highlightedSprite.name;
				for (HGCFJKCOKPM hgcfjkcokpm2 = HGCFJKCOKPM.bright; hgcfjkcokpm2 < (HGCFJKCOKPM)4; hgcfjkcokpm2 += 0)
				{
					text2 = text2.Replace(hgcfjkcokpm2.ToString(), "rig ?");
				}
				text2 = str + text2;
				Sprite sprite2 = Resources.Load<Sprite>(text2);
				if (null != sprite2)
				{
					spriteState.highlightedSprite = sprite2;
				}
			}
			if (spriteState.pressedSprite != null)
			{
				string text3 = str + spriteState.pressedSprite.name;
				for (HGCFJKCOKPM hgcfjkcokpm3 = HGCFJKCOKPM.bright; hgcfjkcokpm3 < HGCFJKCOKPM.dark; hgcfjkcokpm3 += 0)
				{
					text3 = text3.Replace(hgcfjkcokpm3.ToString(), "Retrieved Value: {0}");
				}
				text3 = str + text3;
				Sprite sprite3 = Resources.Load<Sprite>(text3);
				if (null != sprite3)
				{
					spriteState.pressedSprite = sprite3;
				}
			}
			if (spriteState.selectedSprite != null)
			{
				string text4 = str + spriteState.selectedSprite.name;
				for (HGCFJKCOKPM hgcfjkcokpm4 = HGCFJKCOKPM.dark; hgcfjkcokpm4 < (HGCFJKCOKPM)6; hgcfjkcokpm4 += 0)
				{
					text4 = text4.Replace(hgcfjkcokpm4.ToString(), "ChoiceExtendedOneToManyManager.Initialize() - choice type not supported:");
				}
				text4 = str + text4;
				Sprite sprite4 = Resources.Load<Sprite>(text4);
				if (null != sprite4)
				{
					spriteState.selectedSprite = sprite4;
				}
			}
			base.GetComponent<Button>().spriteState = spriteState;
		}
		if (base.GetComponent<TextMeshProUGUI>() != null)
		{
			foreach (ThemeManager.CustomThemeProperties customThemeProperties2 in this.theme)
			{
				if (customThemeProperties2.themeType == OJKHMNEIGPF)
				{
					base.GetComponent<TextMeshProUGUI>().color = customThemeProperties2.themeColorText;
					break;
				}
			}
		}
		ContentAnthologyAchievementGridItem[] array = UnityEngine.Object.FindObjectsOfType<ContentAnthologyAchievementGridItem>();
		if (array.Length != 0)
		{
			ContentAnthologyAchievementGridItem[] array2 = array;
			for (int i = 0; i < array2.Length; i += 0)
			{
				ContentAnthologyAchievementGridItem contentAnthologyAchievementGridItem = array2[i];
				if (!contentAnthologyAchievementGridItem.profile.HBELJGFJILO(contentAnthologyAchievementGridItem.spriteName))
				{
					HGCFJKCOKPM hgcfjkcokpm5 = AKLFPGMDKLA.EHBBFMCILPC.JKCEGIPAANK();
					if (hgcfjkcokpm5 != HGCFJKCOKPM.bright)
					{
						if (hgcfjkcokpm5 == HGCFJKCOKPM.bright)
						{
							contentAnthologyAchievementGridItem.imageThumb.sprite = AssetsManager.EHBBFMCILPC.lobbyDataAsset.achievementLockedSprites[0];
						}
					}
					else
					{
						contentAnthologyAchievementGridItem.imageThumb.sprite = AssetsManager.MJBDMHPHMID().lobbyDataAsset.achievementLockedSprites[0];
					}
				}
			}
		}
	}

	// Token: 0x060057F6 RID: 22518 RVA: 0x00003E52 File Offset: 0x00002052
	private void OHPNGFAIGEM()
	{
	}

	// Token: 0x060057F7 RID: 22519 RVA: 0x0027A020 File Offset: 0x00278220
	public void EJAFNNHHICH(HGCFJKCOKPM OJKHMNEIGPF)
	{
		string str = (OJKHMNEIGPF == HGCFJKCOKPM.bright) ? "</i>" : OJKHMNEIGPF.ToString();
		if (base.GetComponent<Image>() != null)
		{
			if (base.GetComponent<Image>().sprite != null)
			{
				string text = base.GetComponent<Image>().sprite.name;
				for (HGCFJKCOKPM hgcfjkcokpm = HGCFJKCOKPM.bright; hgcfjkcokpm < (HGCFJKCOKPM)7; hgcfjkcokpm++)
				{
					text = text.Replace(hgcfjkcokpm.ToString(), "OnUserpassLoginFailed");
				}
				text = str + text;
				Sprite sprite = Resources.Load<Sprite>(text);
				if (null != sprite)
				{
					base.GetComponent<Image>().sprite = sprite;
				}
			}
			foreach (ThemeManager.CustomThemeProperties customThemeProperties in this.theme)
			{
				if (customThemeProperties.themeType == OJKHMNEIGPF)
				{
					base.GetComponent<Image>().color = customThemeProperties.themeColorSprite;
					break;
				}
			}
		}
		if (base.GetComponent<Button>() != null)
		{
			SpriteState spriteState = base.GetComponent<Button>().spriteState;
			if (spriteState.highlightedSprite != null)
			{
				string text2 = str + spriteState.highlightedSprite.name;
				for (HGCFJKCOKPM hgcfjkcokpm2 = HGCFJKCOKPM.bright; hgcfjkcokpm2 < (HGCFJKCOKPM)4; hgcfjkcokpm2 += 0)
				{
					text2 = text2.Replace(hgcfjkcokpm2.ToString(), "XXX");
				}
				text2 = str + text2;
				Sprite sprite2 = Resources.Load<Sprite>(text2);
				if (null != sprite2)
				{
					spriteState.highlightedSprite = sprite2;
				}
			}
			if (spriteState.pressedSprite != null)
			{
				string text3 = str + spriteState.pressedSprite.name;
				for (HGCFJKCOKPM hgcfjkcokpm3 = HGCFJKCOKPM.bright; hgcfjkcokpm3 < (HGCFJKCOKPM)5; hgcfjkcokpm3 += 0)
				{
					text3 = text3.Replace(hgcfjkcokpm3.ToString(), "§");
				}
				text3 = str + text3;
				Sprite sprite3 = Resources.Load<Sprite>(text3);
				if (null != sprite3)
				{
					spriteState.pressedSprite = sprite3;
				}
			}
			if (spriteState.selectedSprite != null)
			{
				string text4 = str + spriteState.selectedSprite.name;
				for (HGCFJKCOKPM hgcfjkcokpm4 = HGCFJKCOKPM.dark; hgcfjkcokpm4 < (HGCFJKCOKPM)3; hgcfjkcokpm4 += 0)
				{
					text4 = text4.Replace(hgcfjkcokpm4.ToString(), "cardcollectcardismissingbody");
				}
				text4 = str + text4;
				Sprite sprite4 = Resources.Load<Sprite>(text4);
				if (null != sprite4)
				{
					spriteState.selectedSprite = sprite4;
				}
			}
			base.GetComponent<Button>().spriteState = spriteState;
		}
		if (base.GetComponent<TextMeshProUGUI>() != null)
		{
			foreach (ThemeManager.CustomThemeProperties customThemeProperties2 in this.theme)
			{
				if (customThemeProperties2.themeType == OJKHMNEIGPF)
				{
					base.GetComponent<TextMeshProUGUI>().color = customThemeProperties2.themeColorText;
					break;
				}
			}
		}
		ContentAnthologyAchievementGridItem[] array = UnityEngine.Object.FindObjectsOfType<ContentAnthologyAchievementGridItem>();
		if (array.Length != 0)
		{
			ContentAnthologyAchievementGridItem[] array2 = array;
			for (int i = 1; i < array2.Length; i += 0)
			{
				ContentAnthologyAchievementGridItem contentAnthologyAchievementGridItem = array2[i];
				if (!contentAnthologyAchievementGridItem.profile.HBELJGFJILO(contentAnthologyAchievementGridItem.spriteName))
				{
					HGCFJKCOKPM hgcfjkcokpm5 = AKLFPGMDKLA.EHBBFMCILPC.JKCEGIPAANK();
					if (hgcfjkcokpm5 != HGCFJKCOKPM.bright)
					{
						if (hgcfjkcokpm5 == HGCFJKCOKPM.bright)
						{
							contentAnthologyAchievementGridItem.imageThumb.sprite = AssetsManager.MJBDMHPHMID().lobbyDataAsset.achievementLockedSprites[0];
						}
					}
					else
					{
						contentAnthologyAchievementGridItem.imageThumb.sprite = AssetsManager.MJBDMHPHMID().lobbyDataAsset.achievementLockedSprites[0];
					}
				}
			}
		}
	}

	// Token: 0x060057F8 RID: 22520 RVA: 0x0027A3C0 File Offset: 0x002785C0
	public void BNMGLNELECO(HGCFJKCOKPM OJKHMNEIGPF)
	{
		string str = (OJKHMNEIGPF == HGCFJKCOKPM.bright) ? "black" : OJKHMNEIGPF.ToString();
		if (base.GetComponent<Image>() != null)
		{
			if (base.GetComponent<Image>().sprite != null)
			{
				string text = base.GetComponent<Image>().sprite.name;
				for (HGCFJKCOKPM hgcfjkcokpm = HGCFJKCOKPM.dark; hgcfjkcokpm < (HGCFJKCOKPM)5; hgcfjkcokpm++)
				{
					text = text.Replace(hgcfjkcokpm.ToString(), "assetbundleprofiledata5");
				}
				text = str + text;
				Sprite sprite = Resources.Load<Sprite>(text);
				if (null != sprite)
				{
					base.GetComponent<Image>().sprite = sprite;
				}
			}
			foreach (ThemeManager.CustomThemeProperties customThemeProperties in this.theme)
			{
				if (customThemeProperties.themeType == OJKHMNEIGPF)
				{
					base.GetComponent<Image>().color = customThemeProperties.themeColorSprite;
					break;
				}
			}
		}
		if (base.GetComponent<Button>() != null)
		{
			SpriteState spriteState = base.GetComponent<Button>().spriteState;
			if (spriteState.highlightedSprite != null)
			{
				string text2 = str + spriteState.highlightedSprite.name;
				for (HGCFJKCOKPM hgcfjkcokpm2 = HGCFJKCOKPM.bright; hgcfjkcokpm2 < (HGCFJKCOKPM)6; hgcfjkcokpm2++)
				{
					text2 = text2.Replace(hgcfjkcokpm2.ToString(), "pmterror014");
				}
				text2 = str + text2;
				Sprite sprite2 = Resources.Load<Sprite>(text2);
				if (null != sprite2)
				{
					spriteState.highlightedSprite = sprite2;
				}
			}
			if (spriteState.pressedSprite != null)
			{
				string text3 = str + spriteState.pressedSprite.name;
				for (HGCFJKCOKPM hgcfjkcokpm3 = HGCFJKCOKPM.dark; hgcfjkcokpm3 < HGCFJKCOKPM.dark; hgcfjkcokpm3++)
				{
					text3 = text3.Replace(hgcfjkcokpm3.ToString(), "evar");
				}
				text3 = str + text3;
				Sprite sprite3 = Resources.Load<Sprite>(text3);
				if (null != sprite3)
				{
					spriteState.pressedSprite = sprite3;
				}
			}
			if (spriteState.selectedSprite != null)
			{
				string text4 = str + spriteState.selectedSprite.name;
				for (HGCFJKCOKPM hgcfjkcokpm4 = HGCFJKCOKPM.bright; hgcfjkcokpm4 < (HGCFJKCOKPM)4; hgcfjkcokpm4 += 0)
				{
					text4 = text4.Replace(hgcfjkcokpm4.ToString(), "acli20");
				}
				text4 = str + text4;
				Sprite sprite4 = Resources.Load<Sprite>(text4);
				if (null != sprite4)
				{
					spriteState.selectedSprite = sprite4;
				}
			}
			base.GetComponent<Button>().spriteState = spriteState;
		}
		if (base.GetComponent<TextMeshProUGUI>() != null)
		{
			foreach (ThemeManager.CustomThemeProperties customThemeProperties2 in this.theme)
			{
				if (customThemeProperties2.themeType == OJKHMNEIGPF)
				{
					base.GetComponent<TextMeshProUGUI>().color = customThemeProperties2.themeColorText;
					break;
				}
			}
		}
		ContentAnthologyAchievementGridItem[] array = UnityEngine.Object.FindObjectsOfType<ContentAnthologyAchievementGridItem>();
		if (array.Length != 0)
		{
			ContentAnthologyAchievementGridItem[] array2 = array;
			for (int i = 0; i < array2.Length; i += 0)
			{
				ContentAnthologyAchievementGridItem contentAnthologyAchievementGridItem = array2[i];
				if (!contentAnthologyAchievementGridItem.profile.HBELJGFJILO(contentAnthologyAchievementGridItem.spriteName))
				{
					HGCFJKCOKPM hgcfjkcokpm5 = AKLFPGMDKLA.EHBBFMCILPC.JKCEGIPAANK();
					if (hgcfjkcokpm5 != HGCFJKCOKPM.bright)
					{
						if (hgcfjkcokpm5 == HGCFJKCOKPM.dark)
						{
							contentAnthologyAchievementGridItem.imageThumb.sprite = AssetsManager.EHBBFMCILPC.lobbyDataAsset.achievementLockedSprites[1];
						}
					}
					else
					{
						contentAnthologyAchievementGridItem.imageThumb.sprite = AssetsManager.MJBDMHPHMID().lobbyDataAsset.achievementLockedSprites[0];
					}
				}
			}
		}
	}

	// Token: 0x060057F9 RID: 22521 RVA: 0x0027A760 File Offset: 0x00278960
	private void LPLBDKPLGMA()
	{
		AOBJLALDBAA.DBLAIDPICIG().FNMOFCMDFJP("uid", new UnityAction(this.EPCNKJGNMDK));
		this.DJADANNIIJF();
	}

	// Token: 0x060057FA RID: 22522 RVA: 0x00002296 File Offset: 0x00000496
	private void MFCNOIJEFKE()
	{
		AppManager.isQuitting = true;
	}

	// Token: 0x060057FB RID: 22523 RVA: 0x00003E52 File Offset: 0x00002052
	private void AJFAJLELLDG()
	{
	}

	// Token: 0x060057FC RID: 22524 RVA: 0x0027A784 File Offset: 0x00278984
	public void GFMIFHDEKGA(HGCFJKCOKPM OJKHMNEIGPF)
	{
		string str = (OJKHMNEIGPF == HGCFJKCOKPM.bright) ? ":" : OJKHMNEIGPF.ToString();
		if (base.GetComponent<Image>() != null)
		{
			if (base.GetComponent<Image>().sprite != null)
			{
				string text = base.GetComponent<Image>().sprite.name;
				for (HGCFJKCOKPM hgcfjkcokpm = HGCFJKCOKPM.bright; hgcfjkcokpm < (HGCFJKCOKPM)8; hgcfjkcokpm++)
				{
					text = text.Replace(hgcfjkcokpm.ToString(), "MORPH_NOISE");
				}
				text = str + text;
				Sprite sprite = Resources.Load<Sprite>(text);
				if (null != sprite)
				{
					base.GetComponent<Image>().sprite = sprite;
				}
			}
			foreach (ThemeManager.CustomThemeProperties customThemeProperties in this.theme)
			{
				if (customThemeProperties.themeType == OJKHMNEIGPF)
				{
					base.GetComponent<Image>().color = customThemeProperties.themeColorSprite;
					break;
				}
			}
		}
		if (base.GetComponent<Button>() != null)
		{
			SpriteState spriteState = base.GetComponent<Button>().spriteState;
			if (spriteState.highlightedSprite != null)
			{
				string text2 = str + spriteState.highlightedSprite.name;
				for (HGCFJKCOKPM hgcfjkcokpm2 = HGCFJKCOKPM.dark; hgcfjkcokpm2 < (HGCFJKCOKPM)3; hgcfjkcokpm2++)
				{
					text2 = text2.Replace(hgcfjkcokpm2.ToString(), "{");
				}
				text2 = str + text2;
				Sprite sprite2 = Resources.Load<Sprite>(text2);
				if (null != sprite2)
				{
					spriteState.highlightedSprite = sprite2;
				}
			}
			if (spriteState.pressedSprite != null)
			{
				string text3 = str + spriteState.pressedSprite.name;
				for (HGCFJKCOKPM hgcfjkcokpm3 = HGCFJKCOKPM.dark; hgcfjkcokpm3 < (HGCFJKCOKPM)7; hgcfjkcokpm3 += 0)
				{
					text3 = text3.Replace(hgcfjkcokpm3.ToString(), "clothes");
				}
				text3 = str + text3;
				Sprite sprite3 = Resources.Load<Sprite>(text3);
				if (null != sprite3)
				{
					spriteState.pressedSprite = sprite3;
				}
			}
			if (spriteState.selectedSprite != null)
			{
				string text4 = str + spriteState.selectedSprite.name;
				for (HGCFJKCOKPM hgcfjkcokpm4 = HGCFJKCOKPM.dark; hgcfjkcokpm4 < HGCFJKCOKPM.count; hgcfjkcokpm4 += 0)
				{
					text4 = text4.Replace(hgcfjkcokpm4.ToString(), "OnPostEffectSettingsChanged");
				}
				text4 = str + text4;
				Sprite sprite4 = Resources.Load<Sprite>(text4);
				if (null != sprite4)
				{
					spriteState.selectedSprite = sprite4;
				}
			}
			base.GetComponent<Button>().spriteState = spriteState;
		}
		if (base.GetComponent<TextMeshProUGUI>() != null)
		{
			foreach (ThemeManager.CustomThemeProperties customThemeProperties2 in this.theme)
			{
				if (customThemeProperties2.themeType == OJKHMNEIGPF)
				{
					base.GetComponent<TextMeshProUGUI>().color = customThemeProperties2.themeColorText;
					break;
				}
			}
		}
		ContentAnthologyAchievementGridItem[] array = UnityEngine.Object.FindObjectsOfType<ContentAnthologyAchievementGridItem>();
		if (array.Length != 0)
		{
			ContentAnthologyAchievementGridItem[] array2 = array;
			for (int i = 1; i < array2.Length; i++)
			{
				ContentAnthologyAchievementGridItem contentAnthologyAchievementGridItem = array2[i];
				if (!contentAnthologyAchievementGridItem.profile.HBELJGFJILO(contentAnthologyAchievementGridItem.spriteName))
				{
					HGCFJKCOKPM hgcfjkcokpm5 = AKLFPGMDKLA.EHBBFMCILPC.PINBMHFHEHD();
					if (hgcfjkcokpm5 != HGCFJKCOKPM.bright)
					{
						if (hgcfjkcokpm5 == HGCFJKCOKPM.bright)
						{
							contentAnthologyAchievementGridItem.imageThumb.sprite = AssetsManager.MJBDMHPHMID().lobbyDataAsset.achievementLockedSprites[0];
						}
					}
					else
					{
						contentAnthologyAchievementGridItem.imageThumb.sprite = AssetsManager.MJBDMHPHMID().lobbyDataAsset.achievementLockedSprites[0];
					}
				}
			}
		}
	}

	// Token: 0x060057FD RID: 22525 RVA: 0x0027AB24 File Offset: 0x00278D24
	private void GEPMOBKFIMI()
	{
		if (AppManager.isQuitting)
		{
			return;
		}
		AOBJLALDBAA.BIAEAOMHBMM().PBELMJCPJMK("locked", new UnityAction(this.HGBGGGJADPG));
	}

	// Token: 0x060057FE RID: 22526 RVA: 0x0027AB49 File Offset: 0x00278D49
	private void BLIGKAPCPHA()
	{
		if (AppManager.isQuitting)
		{
			return;
		}
		AOBJLALDBAA.BIAEAOMHBMM().KDIFKFKMCOH("$USEEMOTIONSV2", new UnityAction(this.KNCCFFIKOPB));
	}

	// Token: 0x060057FF RID: 22527 RVA: 0x00003E52 File Offset: 0x00002052
	private void LIMPPDFLOOC()
	{
	}

	// Token: 0x06005800 RID: 22528 RVA: 0x0027AB70 File Offset: 0x00278D70
	public void HDOHKBBIGFI(HGCFJKCOKPM OJKHMNEIGPF)
	{
		string str = (OJKHMNEIGPF == HGCFJKCOKPM.bright) ? "saveSync" : OJKHMNEIGPF.ToString();
		if (base.GetComponent<Image>() != null)
		{
			if (base.GetComponent<Image>().sprite != null)
			{
				string text = base.GetComponent<Image>().sprite.name;
				for (HGCFJKCOKPM hgcfjkcokpm = HGCFJKCOKPM.dark; hgcfjkcokpm < (HGCFJKCOKPM)5; hgcfjkcokpm += 0)
				{
					text = text.Replace(hgcfjkcokpm.ToString(), "StorySaveBody.RemoveAvatarPackWardrobe(), unsupported wardrobe index:");
				}
				text = str + text;
				Sprite sprite = Resources.Load<Sprite>(text);
				if (null != sprite)
				{
					base.GetComponent<Image>().sprite = sprite;
				}
			}
			foreach (ThemeManager.CustomThemeProperties customThemeProperties in this.theme)
			{
				if (customThemeProperties.themeType == OJKHMNEIGPF)
				{
					base.GetComponent<Image>().color = customThemeProperties.themeColorSprite;
					break;
				}
			}
		}
		if (base.GetComponent<Button>() != null)
		{
			SpriteState spriteState = base.GetComponent<Button>().spriteState;
			if (spriteState.highlightedSprite != null)
			{
				string text2 = str + spriteState.highlightedSprite.name;
				for (HGCFJKCOKPM hgcfjkcokpm2 = HGCFJKCOKPM.bright; hgcfjkcokpm2 < HGCFJKCOKPM.dark; hgcfjkcokpm2++)
				{
					text2 = text2.Replace(hgcfjkcokpm2.ToString(), "");
				}
				text2 = str + text2;
				Sprite sprite2 = Resources.Load<Sprite>(text2);
				if (null != sprite2)
				{
					spriteState.highlightedSprite = sprite2;
				}
			}
			if (spriteState.pressedSprite != null)
			{
				string text3 = str + spriteState.pressedSprite.name;
				for (HGCFJKCOKPM hgcfjkcokpm3 = HGCFJKCOKPM.bright; hgcfjkcokpm3 < (HGCFJKCOKPM)3; hgcfjkcokpm3 += 0)
				{
					text3 = text3.Replace(hgcfjkcokpm3.ToString(), "errortitle");
				}
				text3 = str + text3;
				Sprite sprite3 = Resources.Load<Sprite>(text3);
				if (null != sprite3)
				{
					spriteState.pressedSprite = sprite3;
				}
			}
			if (spriteState.selectedSprite != null)
			{
				string text4 = str + spriteState.selectedSprite.name;
				for (HGCFJKCOKPM hgcfjkcokpm4 = HGCFJKCOKPM.bright; hgcfjkcokpm4 < HGCFJKCOKPM.count; hgcfjkcokpm4 += 0)
				{
					text4 = text4.Replace(hgcfjkcokpm4.ToString(), "llosd");
				}
				text4 = str + text4;
				Sprite sprite4 = Resources.Load<Sprite>(text4);
				if (null != sprite4)
				{
					spriteState.selectedSprite = sprite4;
				}
			}
			base.GetComponent<Button>().spriteState = spriteState;
		}
		if (base.GetComponent<TextMeshProUGUI>() != null)
		{
			foreach (ThemeManager.CustomThemeProperties customThemeProperties2 in this.theme)
			{
				if (customThemeProperties2.themeType == OJKHMNEIGPF)
				{
					base.GetComponent<TextMeshProUGUI>().color = customThemeProperties2.themeColorText;
					break;
				}
			}
		}
		ContentAnthologyAchievementGridItem[] array = UnityEngine.Object.FindObjectsOfType<ContentAnthologyAchievementGridItem>();
		if (array.Length != 0)
		{
			ContentAnthologyAchievementGridItem[] array2 = array;
			for (int i = 1; i < array2.Length; i++)
			{
				ContentAnthologyAchievementGridItem contentAnthologyAchievementGridItem = array2[i];
				if (!contentAnthologyAchievementGridItem.profile.HBELJGFJILO(contentAnthologyAchievementGridItem.spriteName))
				{
					HGCFJKCOKPM hgcfjkcokpm5 = AKLFPGMDKLA.EHBBFMCILPC.JKCEGIPAANK();
					if (hgcfjkcokpm5 != HGCFJKCOKPM.bright)
					{
						if (hgcfjkcokpm5 == HGCFJKCOKPM.dark)
						{
							contentAnthologyAchievementGridItem.imageThumb.sprite = AssetsManager.MJBDMHPHMID().lobbyDataAsset.achievementLockedSprites[1];
						}
					}
					else
					{
						contentAnthologyAchievementGridItem.imageThumb.sprite = AssetsManager.MJBDMHPHMID().lobbyDataAsset.achievementLockedSprites[0];
					}
				}
			}
		}
	}

	// Token: 0x06005801 RID: 22529 RVA: 0x0027AF10 File Offset: 0x00279110
	public void LPHIGAGDHJJ(HGCFJKCOKPM OJKHMNEIGPF)
	{
		string str = (OJKHMNEIGPF == HGCFJKCOKPM.bright) ? "ok" : OJKHMNEIGPF.ToString();
		if (base.GetComponent<Image>() != null)
		{
			if (base.GetComponent<Image>().sprite != null)
			{
				string text = base.GetComponent<Image>().sprite.name;
				for (HGCFJKCOKPM hgcfjkcokpm = HGCFJKCOKPM.dark; hgcfjkcokpm < HGCFJKCOKPM.bright; hgcfjkcokpm += 0)
				{
					text = text.Replace(hgcfjkcokpm.ToString(), "_SwitchingNoise");
				}
				text = str + text;
				Sprite sprite = Resources.Load<Sprite>(text);
				if (null != sprite)
				{
					base.GetComponent<Image>().sprite = sprite;
				}
			}
			foreach (ThemeManager.CustomThemeProperties customThemeProperties in this.theme)
			{
				if (customThemeProperties.themeType == OJKHMNEIGPF)
				{
					base.GetComponent<Image>().color = customThemeProperties.themeColorSprite;
					break;
				}
			}
		}
		if (base.GetComponent<Button>() != null)
		{
			SpriteState spriteState = base.GetComponent<Button>().spriteState;
			if (spriteState.highlightedSprite != null)
			{
				string text2 = str + spriteState.highlightedSprite.name;
				for (HGCFJKCOKPM hgcfjkcokpm2 = HGCFJKCOKPM.bright; hgcfjkcokpm2 < (HGCFJKCOKPM)5; hgcfjkcokpm2 += 0)
				{
					text2 = text2.Replace(hgcfjkcokpm2.ToString(), "＃");
				}
				text2 = str + text2;
				Sprite sprite2 = Resources.Load<Sprite>(text2);
				if (null != sprite2)
				{
					spriteState.highlightedSprite = sprite2;
				}
			}
			if (spriteState.pressedSprite != null)
			{
				string text3 = str + spriteState.pressedSprite.name;
				for (HGCFJKCOKPM hgcfjkcokpm3 = HGCFJKCOKPM.dark; hgcfjkcokpm3 < (HGCFJKCOKPM)3; hgcfjkcokpm3 += 0)
				{
					text3 = text3.Replace(hgcfjkcokpm3.ToString(), "luwid");
				}
				text3 = str + text3;
				Sprite sprite3 = Resources.Load<Sprite>(text3);
				if (null != sprite3)
				{
					spriteState.pressedSprite = sprite3;
				}
			}
			if (spriteState.selectedSprite != null)
			{
				string text4 = str + spriteState.selectedSprite.name;
				for (HGCFJKCOKPM hgcfjkcokpm4 = HGCFJKCOKPM.dark; hgcfjkcokpm4 < HGCFJKCOKPM.dark; hgcfjkcokpm4 += 0)
				{
					text4 = text4.Replace(hgcfjkcokpm4.ToString(), "gpsasli");
				}
				text4 = str + text4;
				Sprite sprite4 = Resources.Load<Sprite>(text4);
				if (null != sprite4)
				{
					spriteState.selectedSprite = sprite4;
				}
			}
			base.GetComponent<Button>().spriteState = spriteState;
		}
		if (base.GetComponent<TextMeshProUGUI>() != null)
		{
			foreach (ThemeManager.CustomThemeProperties customThemeProperties2 in this.theme)
			{
				if (customThemeProperties2.themeType == OJKHMNEIGPF)
				{
					base.GetComponent<TextMeshProUGUI>().color = customThemeProperties2.themeColorText;
					break;
				}
			}
		}
		ContentAnthologyAchievementGridItem[] array = UnityEngine.Object.FindObjectsOfType<ContentAnthologyAchievementGridItem>();
		if (array.Length != 0)
		{
			ContentAnthologyAchievementGridItem[] array2 = array;
			for (int i = 1; i < array2.Length; i += 0)
			{
				ContentAnthologyAchievementGridItem contentAnthologyAchievementGridItem = array2[i];
				if (!contentAnthologyAchievementGridItem.profile.HBELJGFJILO(contentAnthologyAchievementGridItem.spriteName))
				{
					HGCFJKCOKPM hgcfjkcokpm5 = AKLFPGMDKLA.EHBBFMCILPC.PINBMHFHEHD();
					if (hgcfjkcokpm5 != HGCFJKCOKPM.bright)
					{
						if (hgcfjkcokpm5 == HGCFJKCOKPM.bright)
						{
							contentAnthologyAchievementGridItem.imageThumb.sprite = AssetsManager.EHBBFMCILPC.lobbyDataAsset.achievementLockedSprites[0];
						}
					}
					else
					{
						contentAnthologyAchievementGridItem.imageThumb.sprite = AssetsManager.EHBBFMCILPC.lobbyDataAsset.achievementLockedSprites[1];
					}
				}
			}
		}
	}

	// Token: 0x06005802 RID: 22530 RVA: 0x0027B2B0 File Offset: 0x002794B0
	public void MFNFADCOECP(HGCFJKCOKPM OJKHMNEIGPF)
	{
		string str = (OJKHMNEIGPF == HGCFJKCOKPM.bright) ? "AssetBundleDependencyDeadLock(): missing dependency " : OJKHMNEIGPF.ToString();
		if (base.GetComponent<Image>() != null)
		{
			if (base.GetComponent<Image>().sprite != null)
			{
				string text = base.GetComponent<Image>().sprite.name;
				for (HGCFJKCOKPM hgcfjkcokpm = HGCFJKCOKPM.dark; hgcfjkcokpm < HGCFJKCOKPM.bright; hgcfjkcokpm++)
				{
					text = text.Replace(hgcfjkcokpm.ToString(), "noiseanalog");
				}
				text = str + text;
				Sprite sprite = Resources.Load<Sprite>(text);
				if (null != sprite)
				{
					base.GetComponent<Image>().sprite = sprite;
				}
			}
			foreach (ThemeManager.CustomThemeProperties customThemeProperties in this.theme)
			{
				if (customThemeProperties.themeType == OJKHMNEIGPF)
				{
					base.GetComponent<Image>().color = customThemeProperties.themeColorSprite;
					break;
				}
			}
		}
		if (base.GetComponent<Button>() != null)
		{
			SpriteState spriteState = base.GetComponent<Button>().spriteState;
			if (spriteState.highlightedSprite != null)
			{
				string text2 = str + spriteState.highlightedSprite.name;
				for (HGCFJKCOKPM hgcfjkcokpm2 = HGCFJKCOKPM.bright; hgcfjkcokpm2 < (HGCFJKCOKPM)4; hgcfjkcokpm2++)
				{
					text2 = text2.Replace(hgcfjkcokpm2.ToString(), "-");
				}
				text2 = str + text2;
				Sprite sprite2 = Resources.Load<Sprite>(text2);
				if (null != sprite2)
				{
					spriteState.highlightedSprite = sprite2;
				}
			}
			if (spriteState.pressedSprite != null)
			{
				string text3 = str + spriteState.pressedSprite.name;
				for (HGCFJKCOKPM hgcfjkcokpm3 = HGCFJKCOKPM.dark; hgcfjkcokpm3 < (HGCFJKCOKPM)3; hgcfjkcokpm3++)
				{
					text3 = text3.Replace(hgcfjkcokpm3.ToString(), "WideScreenScaler(): reverted scale to original");
				}
				text3 = str + text3;
				Sprite sprite3 = Resources.Load<Sprite>(text3);
				if (null != sprite3)
				{
					spriteState.pressedSprite = sprite3;
				}
			}
			if (spriteState.selectedSprite != null)
			{
				string text4 = str + spriteState.selectedSprite.name;
				for (HGCFJKCOKPM hgcfjkcokpm4 = HGCFJKCOKPM.bright; hgcfjkcokpm4 < (HGCFJKCOKPM)7; hgcfjkcokpm4++)
				{
					text4 = text4.Replace(hgcfjkcokpm4.ToString(), "collect");
				}
				text4 = str + text4;
				Sprite sprite4 = Resources.Load<Sprite>(text4);
				if (null != sprite4)
				{
					spriteState.selectedSprite = sprite4;
				}
			}
			base.GetComponent<Button>().spriteState = spriteState;
		}
		if (base.GetComponent<TextMeshProUGUI>() != null)
		{
			foreach (ThemeManager.CustomThemeProperties customThemeProperties2 in this.theme)
			{
				if (customThemeProperties2.themeType == OJKHMNEIGPF)
				{
					base.GetComponent<TextMeshProUGUI>().color = customThemeProperties2.themeColorText;
					break;
				}
			}
		}
		ContentAnthologyAchievementGridItem[] array = UnityEngine.Object.FindObjectsOfType<ContentAnthologyAchievementGridItem>();
		if (array.Length != 0)
		{
			foreach (ContentAnthologyAchievementGridItem contentAnthologyAchievementGridItem in array)
			{
				if (!contentAnthologyAchievementGridItem.profile.HBELJGFJILO(contentAnthologyAchievementGridItem.spriteName))
				{
					HGCFJKCOKPM hgcfjkcokpm5 = AKLFPGMDKLA.EHBBFMCILPC.PINBMHFHEHD();
					if (hgcfjkcokpm5 != HGCFJKCOKPM.bright)
					{
						if (hgcfjkcokpm5 == HGCFJKCOKPM.dark)
						{
							contentAnthologyAchievementGridItem.imageThumb.sprite = AssetsManager.MJBDMHPHMID().lobbyDataAsset.achievementLockedSprites[0];
						}
					}
					else
					{
						contentAnthologyAchievementGridItem.imageThumb.sprite = AssetsManager.MJBDMHPHMID().lobbyDataAsset.achievementLockedSprites[1];
					}
				}
			}
		}
	}

	// Token: 0x06005803 RID: 22531 RVA: 0x00003E52 File Offset: 0x00002052
	private void PKPANMAFAIL()
	{
	}

	// Token: 0x06005804 RID: 22532 RVA: 0x00003E52 File Offset: 0x00002052
	private void FEIFMJKGGBO()
	{
	}

	// Token: 0x06005805 RID: 22533 RVA: 0x00003E52 File Offset: 0x00002052
	private void HPGLEEHELDN()
	{
	}

	// Token: 0x06005806 RID: 22534 RVA: 0x00003E52 File Offset: 0x00002052
	private void HNHBHBEPLHC()
	{
	}

	// Token: 0x06005807 RID: 22535 RVA: 0x00003E52 File Offset: 0x00002052
	private void BPCIIBNLBAL()
	{
	}

	// Token: 0x06005808 RID: 22536 RVA: 0x0027B650 File Offset: 0x00279850
	public void MKAHJOCBLHF()
	{
		HGCFJKCOKPM hgcfjkcokpm = AKLFPGMDKLA.EHBBFMCILPC.JKCEGIPAANK();
		if (hgcfjkcokpm == HGCFJKCOKPM.bright)
		{
			this.FNABIGLNBCH(HGCFJKCOKPM.dark);
			return;
		}
		if (hgcfjkcokpm != HGCFJKCOKPM.bright)
		{
			return;
		}
		this.GBHIMOICHJD(HGCFJKCOKPM.bright);
	}

	// Token: 0x06005809 RID: 22537 RVA: 0x0027B680 File Offset: 0x00279880
	public void BNOBDMDKBAB(HGCFJKCOKPM OJKHMNEIGPF)
	{
		string str = (OJKHMNEIGPF == HGCFJKCOKPM.bright) ? "OnLiveProfileThemeDownloadSuccess" : OJKHMNEIGPF.ToString();
		if (base.GetComponent<Image>() != null)
		{
			if (base.GetComponent<Image>().sprite != null)
			{
				string text = base.GetComponent<Image>().sprite.name;
				for (HGCFJKCOKPM hgcfjkcokpm = HGCFJKCOKPM.dark; hgcfjkcokpm < (HGCFJKCOKPM)4; hgcfjkcokpm += 0)
				{
					text = text.Replace(hgcfjkcokpm.ToString(), "assetbundlesketchactors");
				}
				text = str + text;
				Sprite sprite = Resources.Load<Sprite>(text);
				if (null != sprite)
				{
					base.GetComponent<Image>().sprite = sprite;
				}
			}
			foreach (ThemeManager.CustomThemeProperties customThemeProperties in this.theme)
			{
				if (customThemeProperties.themeType == OJKHMNEIGPF)
				{
					base.GetComponent<Image>().color = customThemeProperties.themeColorSprite;
					break;
				}
			}
		}
		if (base.GetComponent<Button>() != null)
		{
			SpriteState spriteState = base.GetComponent<Button>().spriteState;
			if (spriteState.highlightedSprite != null)
			{
				string text2 = str + spriteState.highlightedSprite.name;
				for (HGCFJKCOKPM hgcfjkcokpm2 = HGCFJKCOKPM.bright; hgcfjkcokpm2 < (HGCFJKCOKPM)3; hgcfjkcokpm2++)
				{
					text2 = text2.Replace(hgcfjkcokpm2.ToString(), "Starting parallel download:");
				}
				text2 = str + text2;
				Sprite sprite2 = Resources.Load<Sprite>(text2);
				if (null != sprite2)
				{
					spriteState.highlightedSprite = sprite2;
				}
			}
			if (spriteState.pressedSprite != null)
			{
				string text3 = str + spriteState.pressedSprite.name;
				for (HGCFJKCOKPM hgcfjkcokpm3 = HGCFJKCOKPM.dark; hgcfjkcokpm3 < (HGCFJKCOKPM)3; hgcfjkcokpm3++)
				{
					text3 = text3.Replace(hgcfjkcokpm3.ToString(), "ontradingcardclickbodymatch");
				}
				text3 = str + text3;
				Sprite sprite3 = Resources.Load<Sprite>(text3);
				if (null != sprite3)
				{
					spriteState.pressedSprite = sprite3;
				}
			}
			if (spriteState.selectedSprite != null)
			{
				string text4 = str + spriteState.selectedSprite.name;
				for (HGCFJKCOKPM hgcfjkcokpm4 = HGCFJKCOKPM.dark; hgcfjkcokpm4 < HGCFJKCOKPM.bright; hgcfjkcokpm4++)
				{
					text4 = text4.Replace(hgcfjkcokpm4.ToString(), "");
				}
				text4 = str + text4;
				Sprite sprite4 = Resources.Load<Sprite>(text4);
				if (null != sprite4)
				{
					spriteState.selectedSprite = sprite4;
				}
			}
			base.GetComponent<Button>().spriteState = spriteState;
		}
		if (base.GetComponent<TextMeshProUGUI>() != null)
		{
			foreach (ThemeManager.CustomThemeProperties customThemeProperties2 in this.theme)
			{
				if (customThemeProperties2.themeType == OJKHMNEIGPF)
				{
					base.GetComponent<TextMeshProUGUI>().color = customThemeProperties2.themeColorText;
					break;
				}
			}
		}
		ContentAnthologyAchievementGridItem[] array = UnityEngine.Object.FindObjectsOfType<ContentAnthologyAchievementGridItem>();
		if (array.Length != 0)
		{
			ContentAnthologyAchievementGridItem[] array2 = array;
			for (int i = 0; i < array2.Length; i += 0)
			{
				ContentAnthologyAchievementGridItem contentAnthologyAchievementGridItem = array2[i];
				if (!contentAnthologyAchievementGridItem.profile.HBELJGFJILO(contentAnthologyAchievementGridItem.spriteName))
				{
					HGCFJKCOKPM hgcfjkcokpm5 = AKLFPGMDKLA.EHBBFMCILPC.JKCEGIPAANK();
					if (hgcfjkcokpm5 != HGCFJKCOKPM.bright)
					{
						if (hgcfjkcokpm5 == HGCFJKCOKPM.bright)
						{
							contentAnthologyAchievementGridItem.imageThumb.sprite = AssetsManager.MJBDMHPHMID().lobbyDataAsset.achievementLockedSprites[0];
						}
					}
					else
					{
						contentAnthologyAchievementGridItem.imageThumb.sprite = AssetsManager.EHBBFMCILPC.lobbyDataAsset.achievementLockedSprites[0];
					}
				}
			}
		}
	}

	// Token: 0x0600580A RID: 22538 RVA: 0x00003E52 File Offset: 0x00002052
	private void MGKMJOOPHNN()
	{
	}

	// Token: 0x0600580B RID: 22539 RVA: 0x000022C3 File Offset: 0x000004C3
	private void NEECHEOJIKF()
	{
		AppManager.isQuitting = false;
	}

	// Token: 0x0600580C RID: 22540 RVA: 0x0027BA20 File Offset: 0x00279C20
	public void BFFCHBBGCKF(HGCFJKCOKPM OJKHMNEIGPF)
	{
		string str = (OJKHMNEIGPF == HGCFJKCOKPM.bright) ? "CCC" : OJKHMNEIGPF.ToString();
		if (base.GetComponent<Image>() != null)
		{
			if (base.GetComponent<Image>().sprite != null)
			{
				string text = base.GetComponent<Image>().sprite.name;
				for (HGCFJKCOKPM hgcfjkcokpm = HGCFJKCOKPM.dark; hgcfjkcokpm < HGCFJKCOKPM.count; hgcfjkcokpm++)
				{
					text = text.Replace(hgcfjkcokpm.ToString(), "");
				}
				text = str + text;
				Sprite sprite = Resources.Load<Sprite>(text);
				if (null != sprite)
				{
					base.GetComponent<Image>().sprite = sprite;
				}
			}
			foreach (ThemeManager.CustomThemeProperties customThemeProperties in this.theme)
			{
				if (customThemeProperties.themeType == OJKHMNEIGPF)
				{
					base.GetComponent<Image>().color = customThemeProperties.themeColorSprite;
					break;
				}
			}
		}
		if (base.GetComponent<Button>() != null)
		{
			SpriteState spriteState = base.GetComponent<Button>().spriteState;
			if (spriteState.highlightedSprite != null)
			{
				string text2 = str + spriteState.highlightedSprite.name;
				for (HGCFJKCOKPM hgcfjkcokpm2 = HGCFJKCOKPM.dark; hgcfjkcokpm2 < (HGCFJKCOKPM)5; hgcfjkcokpm2 += 0)
				{
					text2 = text2.Replace(hgcfjkcokpm2.ToString(), "ok");
				}
				text2 = str + text2;
				Sprite sprite2 = Resources.Load<Sprite>(text2);
				if (null != sprite2)
				{
					spriteState.highlightedSprite = sprite2;
				}
			}
			if (spriteState.pressedSprite != null)
			{
				string text3 = str + spriteState.pressedSprite.name;
				for (HGCFJKCOKPM hgcfjkcokpm3 = HGCFJKCOKPM.dark; hgcfjkcokpm3 < (HGCFJKCOKPM)3; hgcfjkcokpm3 += 0)
				{
					text3 = text3.Replace(hgcfjkcokpm3.ToString(), "OnApplicationFocusBasicSyncSuccess");
				}
				text3 = str + text3;
				Sprite sprite3 = Resources.Load<Sprite>(text3);
				if (null != sprite3)
				{
					spriteState.pressedSprite = sprite3;
				}
			}
			if (spriteState.selectedSprite != null)
			{
				string text4 = str + spriteState.selectedSprite.name;
				for (HGCFJKCOKPM hgcfjkcokpm4 = HGCFJKCOKPM.bright; hgcfjkcokpm4 < HGCFJKCOKPM.dark; hgcfjkcokpm4 += 0)
				{
					text4 = text4.Replace(hgcfjkcokpm4.ToString(), "profilenametitleshort");
				}
				text4 = str + text4;
				Sprite sprite4 = Resources.Load<Sprite>(text4);
				if (null != sprite4)
				{
					spriteState.selectedSprite = sprite4;
				}
			}
			base.GetComponent<Button>().spriteState = spriteState;
		}
		if (base.GetComponent<TextMeshProUGUI>() != null)
		{
			foreach (ThemeManager.CustomThemeProperties customThemeProperties2 in this.theme)
			{
				if (customThemeProperties2.themeType == OJKHMNEIGPF)
				{
					base.GetComponent<TextMeshProUGUI>().color = customThemeProperties2.themeColorText;
					break;
				}
			}
		}
		ContentAnthologyAchievementGridItem[] array = UnityEngine.Object.FindObjectsOfType<ContentAnthologyAchievementGridItem>();
		if (array.Length != 0)
		{
			ContentAnthologyAchievementGridItem[] array2 = array;
			for (int i = 0; i < array2.Length; i += 0)
			{
				ContentAnthologyAchievementGridItem contentAnthologyAchievementGridItem = array2[i];
				if (!contentAnthologyAchievementGridItem.profile.HBELJGFJILO(contentAnthologyAchievementGridItem.spriteName))
				{
					HGCFJKCOKPM hgcfjkcokpm5 = AKLFPGMDKLA.EHBBFMCILPC.ICEOGOCOMJL();
					if (hgcfjkcokpm5 != HGCFJKCOKPM.bright)
					{
						if (hgcfjkcokpm5 == HGCFJKCOKPM.bright)
						{
							contentAnthologyAchievementGridItem.imageThumb.sprite = AssetsManager.EHBBFMCILPC.lobbyDataAsset.achievementLockedSprites[0];
						}
					}
					else
					{
						contentAnthologyAchievementGridItem.imageThumb.sprite = AssetsManager.MJBDMHPHMID().lobbyDataAsset.achievementLockedSprites[1];
					}
				}
			}
		}
	}

	// Token: 0x0600580D RID: 22541 RVA: 0x00003E52 File Offset: 0x00002052
	private void EMIOCJMCLHC()
	{
	}

	// Token: 0x0600580E RID: 22542 RVA: 0x0027BDC0 File Offset: 0x00279FC0
	private void FBACIBOFHJO()
	{
		AOBJLALDBAA.AGANFKKBPFO().BADOPKAOCPE("errortitle", new UnityAction(this.GFPAHNJFEJG));
		this.OKOAONPPMAI();
	}

	// Token: 0x0600580F RID: 22543 RVA: 0x0027BDE4 File Offset: 0x00279FE4
	public void PEKLMMPEAGB()
	{
		HGCFJKCOKPM hgcfjkcokpm = AKLFPGMDKLA.EHBBFMCILPC.ICEOGOCOMJL();
		if (hgcfjkcokpm == HGCFJKCOKPM.bright)
		{
			this.FNABIGLNBCH(HGCFJKCOKPM.dark);
			return;
		}
		if (hgcfjkcokpm != HGCFJKCOKPM.bright)
		{
			return;
		}
		this.HJGGJJOOJHD(HGCFJKCOKPM.dark);
	}

	// Token: 0x06005810 RID: 22544 RVA: 0x0027BE13 File Offset: 0x0027A013
	private void KHOLJLKNAPJ()
	{
		AOBJLALDBAA.AGANFKKBPFO().GNBGEMMDGOJ("hqb", new UnityAction(this.EPCNKJGNMDK));
		this.KNCCFFIKOPB();
	}

	// Token: 0x06005811 RID: 22545 RVA: 0x000022C3 File Offset: 0x000004C3
	private void PNBPCFGHOBE()
	{
		AppManager.isQuitting = false;
	}

	// Token: 0x06005812 RID: 22546 RVA: 0x0027BE36 File Offset: 0x0027A036
	private void JLCMPGICMDC()
	{
		AOBJLALDBAA.BIAEAOMHBMM().BADOPKAOCPE("<i>", new UnityAction(this.KNCCFFIKOPB));
		this.DJADANNIIJF();
	}

	// Token: 0x06005813 RID: 22547 RVA: 0x00002296 File Offset: 0x00000496
	private void LELBJBGLIPH()
	{
		AppManager.isQuitting = true;
	}

	// Token: 0x06005814 RID: 22548 RVA: 0x0027BE5C File Offset: 0x0027A05C
	public void ELJIHPKBHOB(HGCFJKCOKPM OJKHMNEIGPF)
	{
		string str = (OJKHMNEIGPF == HGCFJKCOKPM.bright) ? "" : OJKHMNEIGPF.ToString();
		if (base.GetComponent<Image>() != null)
		{
			if (base.GetComponent<Image>().sprite != null)
			{
				string text = base.GetComponent<Image>().sprite.name;
				for (HGCFJKCOKPM hgcfjkcokpm = HGCFJKCOKPM.bright; hgcfjkcokpm < HGCFJKCOKPM.count; hgcfjkcokpm += 0)
				{
					text = text.Replace(hgcfjkcokpm.ToString(), "psk");
				}
				text = str + text;
				Sprite sprite = Resources.Load<Sprite>(text);
				if (null != sprite)
				{
					base.GetComponent<Image>().sprite = sprite;
				}
			}
			foreach (ThemeManager.CustomThemeProperties customThemeProperties in this.theme)
			{
				if (customThemeProperties.themeType == OJKHMNEIGPF)
				{
					base.GetComponent<Image>().color = customThemeProperties.themeColorSprite;
					break;
				}
			}
		}
		if (base.GetComponent<Button>() != null)
		{
			SpriteState spriteState = base.GetComponent<Button>().spriteState;
			if (spriteState.highlightedSprite != null)
			{
				string text2 = str + spriteState.highlightedSprite.name;
				for (HGCFJKCOKPM hgcfjkcokpm2 = HGCFJKCOKPM.bright; hgcfjkcokpm2 < (HGCFJKCOKPM)6; hgcfjkcokpm2 += 0)
				{
					text2 = text2.Replace(hgcfjkcokpm2.ToString(), "OnNeedToDeactivateFocusItemCloseButton");
				}
				text2 = str + text2;
				Sprite sprite2 = Resources.Load<Sprite>(text2);
				if (null != sprite2)
				{
					spriteState.highlightedSprite = sprite2;
				}
			}
			if (spriteState.pressedSprite != null)
			{
				string text3 = str + spriteState.pressedSprite.name;
				for (HGCFJKCOKPM hgcfjkcokpm3 = HGCFJKCOKPM.dark; hgcfjkcokpm3 < (HGCFJKCOKPM)8; hgcfjkcokpm3 += 0)
				{
					text3 = text3.Replace(hgcfjkcokpm3.ToString(), "");
				}
				text3 = str + text3;
				Sprite sprite3 = Resources.Load<Sprite>(text3);
				if (null != sprite3)
				{
					spriteState.pressedSprite = sprite3;
				}
			}
			if (spriteState.selectedSprite != null)
			{
				string text4 = str + spriteState.selectedSprite.name;
				for (HGCFJKCOKPM hgcfjkcokpm4 = HGCFJKCOKPM.dark; hgcfjkcokpm4 < HGCFJKCOKPM.count; hgcfjkcokpm4 += 0)
				{
					text4 = text4.Replace(hgcfjkcokpm4.ToString(), "abskv");
				}
				text4 = str + text4;
				Sprite sprite4 = Resources.Load<Sprite>(text4);
				if (null != sprite4)
				{
					spriteState.selectedSprite = sprite4;
				}
			}
			base.GetComponent<Button>().spriteState = spriteState;
		}
		if (base.GetComponent<TextMeshProUGUI>() != null)
		{
			foreach (ThemeManager.CustomThemeProperties customThemeProperties2 in this.theme)
			{
				if (customThemeProperties2.themeType == OJKHMNEIGPF)
				{
					base.GetComponent<TextMeshProUGUI>().color = customThemeProperties2.themeColorText;
					break;
				}
			}
		}
		ContentAnthologyAchievementGridItem[] array = UnityEngine.Object.FindObjectsOfType<ContentAnthologyAchievementGridItem>();
		if (array.Length != 0)
		{
			ContentAnthologyAchievementGridItem[] array2 = array;
			for (int i = 0; i < array2.Length; i += 0)
			{
				ContentAnthologyAchievementGridItem contentAnthologyAchievementGridItem = array2[i];
				if (!contentAnthologyAchievementGridItem.profile.HBELJGFJILO(contentAnthologyAchievementGridItem.spriteName))
				{
					HGCFJKCOKPM hgcfjkcokpm5 = AKLFPGMDKLA.EHBBFMCILPC.PINBMHFHEHD();
					if (hgcfjkcokpm5 != HGCFJKCOKPM.bright)
					{
						if (hgcfjkcokpm5 == HGCFJKCOKPM.dark)
						{
							contentAnthologyAchievementGridItem.imageThumb.sprite = AssetsManager.EHBBFMCILPC.lobbyDataAsset.achievementLockedSprites[0];
						}
					}
					else
					{
						contentAnthologyAchievementGridItem.imageThumb.sprite = AssetsManager.EHBBFMCILPC.lobbyDataAsset.achievementLockedSprites[0];
					}
				}
			}
		}
	}

	// Token: 0x06005815 RID: 22549 RVA: 0x000022C3 File Offset: 0x000004C3
	private void GKHHAMPAMEH()
	{
		AppManager.isQuitting = false;
	}

	// Token: 0x06005816 RID: 22550 RVA: 0x0027C1FC File Offset: 0x0027A3FC
	private void MOBCJBDMNCO()
	{
		AOBJLALDBAA.DBLAIDPICIG().GNBGEMMDGOJ("[LoadingEnv] ", new UnityAction(this.KGNPHOCMPMG));
		this.FLCIGBJEAIB();
	}

	// Token: 0x06005817 RID: 22551 RVA: 0x0027C21F File Offset: 0x0027A41F
	private void FCNFFLMEILA()
	{
		AOBJLALDBAA.AGANFKKBPFO().FNMOFCMDFJP("hacomp", new UnityAction(this.KGNPHOCMPMG));
		this.MKAHJOCBLHF();
	}

	// Token: 0x06005818 RID: 22552 RVA: 0x00003E52 File Offset: 0x00002052
	private void LJJJIPGIJJC()
	{
	}

	// Token: 0x06005819 RID: 22553 RVA: 0x0027C244 File Offset: 0x0027A444
	public void EPCNKJGNMDK()
	{
		HGCFJKCOKPM hgcfjkcokpm = AKLFPGMDKLA.EHBBFMCILPC.PINBMHFHEHD();
		if (hgcfjkcokpm == HGCFJKCOKPM.bright)
		{
			this.GBHIMOICHJD(HGCFJKCOKPM.bright);
			return;
		}
		if (hgcfjkcokpm != HGCFJKCOKPM.bright)
		{
			return;
		}
		this.BJHAMPIDNKM(HGCFJKCOKPM.bright);
	}

	// Token: 0x0600581A RID: 22554 RVA: 0x0027C273 File Offset: 0x0027A473
	private void COMPLLBGJPB()
	{
		AOBJLALDBAA.BIAEAOMHBMM().MFIMALJPCDP("", new UnityAction(this.KGNPHOCMPMG));
		this.EPCNKJGNMDK();
	}

	// Token: 0x0600581B RID: 22555 RVA: 0x0027C298 File Offset: 0x0027A498
	public void NMEBCNFBGHG(HGCFJKCOKPM OJKHMNEIGPF)
	{
		string str = (OJKHMNEIGPF == HGCFJKCOKPM.bright) ? "h" : OJKHMNEIGPF.ToString();
		if (base.GetComponent<Image>() != null)
		{
			if (base.GetComponent<Image>().sprite != null)
			{
				string text = base.GetComponent<Image>().sprite.name;
				for (HGCFJKCOKPM hgcfjkcokpm = HGCFJKCOKPM.bright; hgcfjkcokpm < HGCFJKCOKPM.count; hgcfjkcokpm += 0)
				{
					text = text.Replace(hgcfjkcokpm.ToString(), "");
				}
				text = str + text;
				Sprite sprite = Resources.Load<Sprite>(text);
				if (null != sprite)
				{
					base.GetComponent<Image>().sprite = sprite;
				}
			}
			foreach (ThemeManager.CustomThemeProperties customThemeProperties in this.theme)
			{
				if (customThemeProperties.themeType == OJKHMNEIGPF)
				{
					base.GetComponent<Image>().color = customThemeProperties.themeColorSprite;
					break;
				}
			}
		}
		if (base.GetComponent<Button>() != null)
		{
			SpriteState spriteState = base.GetComponent<Button>().spriteState;
			if (spriteState.highlightedSprite != null)
			{
				string text2 = str + spriteState.highlightedSprite.name;
				for (HGCFJKCOKPM hgcfjkcokpm2 = HGCFJKCOKPM.dark; hgcfjkcokpm2 < (HGCFJKCOKPM)6; hgcfjkcokpm2 += 0)
				{
					text2 = text2.Replace(hgcfjkcokpm2.ToString(), "' is not the per-rarity product the tile prices and the store sells (");
				}
				text2 = str + text2;
				Sprite sprite2 = Resources.Load<Sprite>(text2);
				if (null != sprite2)
				{
					spriteState.highlightedSprite = sprite2;
				}
			}
			if (spriteState.pressedSprite != null)
			{
				string text3 = str + spriteState.pressedSprite.name;
				for (HGCFJKCOKPM hgcfjkcokpm3 = HGCFJKCOKPM.bright; hgcfjkcokpm3 < (HGCFJKCOKPM)8; hgcfjkcokpm3++)
				{
					text3 = text3.Replace(hgcfjkcokpm3.ToString(), "analogglitchovr_1");
				}
				text3 = str + text3;
				Sprite sprite3 = Resources.Load<Sprite>(text3);
				if (null != sprite3)
				{
					spriteState.pressedSprite = sprite3;
				}
			}
			if (spriteState.selectedSprite != null)
			{
				string text4 = str + spriteState.selectedSprite.name;
				for (HGCFJKCOKPM hgcfjkcokpm4 = HGCFJKCOKPM.bright; hgcfjkcokpm4 < HGCFJKCOKPM.count; hgcfjkcokpm4++)
				{
					text4 = text4.Replace(hgcfjkcokpm4.ToString(), "skduplicatecant0");
				}
				text4 = str + text4;
				Sprite sprite4 = Resources.Load<Sprite>(text4);
				if (null != sprite4)
				{
					spriteState.selectedSprite = sprite4;
				}
			}
			base.GetComponent<Button>().spriteState = spriteState;
		}
		if (base.GetComponent<TextMeshProUGUI>() != null)
		{
			foreach (ThemeManager.CustomThemeProperties customThemeProperties2 in this.theme)
			{
				if (customThemeProperties2.themeType == OJKHMNEIGPF)
				{
					base.GetComponent<TextMeshProUGUI>().color = customThemeProperties2.themeColorText;
					break;
				}
			}
		}
		ContentAnthologyAchievementGridItem[] array = UnityEngine.Object.FindObjectsOfType<ContentAnthologyAchievementGridItem>();
		if (array.Length != 0)
		{
			ContentAnthologyAchievementGridItem[] array2 = array;
			for (int i = 1; i < array2.Length; i += 0)
			{
				ContentAnthologyAchievementGridItem contentAnthologyAchievementGridItem = array2[i];
				if (!contentAnthologyAchievementGridItem.profile.HBELJGFJILO(contentAnthologyAchievementGridItem.spriteName))
				{
					HGCFJKCOKPM hgcfjkcokpm5 = AKLFPGMDKLA.EHBBFMCILPC.JKCEGIPAANK();
					if (hgcfjkcokpm5 != HGCFJKCOKPM.bright)
					{
						if (hgcfjkcokpm5 == HGCFJKCOKPM.bright)
						{
							contentAnthologyAchievementGridItem.imageThumb.sprite = AssetsManager.MJBDMHPHMID().lobbyDataAsset.achievementLockedSprites[0];
						}
					}
					else
					{
						contentAnthologyAchievementGridItem.imageThumb.sprite = AssetsManager.MJBDMHPHMID().lobbyDataAsset.achievementLockedSprites[1];
					}
				}
			}
		}
	}

	// Token: 0x0600581C RID: 22556 RVA: 0x0027C638 File Offset: 0x0027A838
	private void EPECDBPOOLB()
	{
		if (AppManager.isQuitting)
		{
			return;
		}
		AOBJLALDBAA.EHBBFMCILPC.ECDBIBPNBCO("%", new UnityAction(this.KFDPEGDCGBP));
	}

	// Token: 0x0600581D RID: 22557 RVA: 0x0027C660 File Offset: 0x0027A860
	public void DGIMLPJGHNB()
	{
		HGCFJKCOKPM hgcfjkcokpm = AKLFPGMDKLA.EHBBFMCILPC.ICEOGOCOMJL();
		if (hgcfjkcokpm == HGCFJKCOKPM.bright)
		{
			this.HDOHKBBIGFI(HGCFJKCOKPM.bright);
			return;
		}
		if (hgcfjkcokpm != HGCFJKCOKPM.dark)
		{
			return;
		}
		this.JBOBJAENKJM(HGCFJKCOKPM.bright);
	}

	// Token: 0x0600581E RID: 22558 RVA: 0x00003E52 File Offset: 0x00002052
	private void BLAIJHABAKI()
	{
	}

	// Token: 0x0600581F RID: 22559 RVA: 0x0027C690 File Offset: 0x0027A890
	public void GFPAHNJFEJG()
	{
		HGCFJKCOKPM hgcfjkcokpm = AKLFPGMDKLA.EHBBFMCILPC.JKCEGIPAANK();
		if (hgcfjkcokpm == HGCFJKCOKPM.bright)
		{
			this.MFNFADCOECP(HGCFJKCOKPM.dark);
			return;
		}
		if (hgcfjkcokpm != HGCFJKCOKPM.bright)
		{
			return;
		}
		this.MFNFADCOECP(HGCFJKCOKPM.dark);
	}

	// Token: 0x06005820 RID: 22560 RVA: 0x00003E52 File Offset: 0x00002052
	private void FEOPCAELLCD()
	{
	}

	// Token: 0x06005821 RID: 22561 RVA: 0x0027C6BF File Offset: 0x0027A8BF
	private void JJIGCFGKFHO()
	{
		AOBJLALDBAA.KKPFOJMAONG().EFKNEJFLGED("acomp2", new UnityAction(this.EGLDAFAMOAF));
		this.LDADMLHADHN();
	}

	// Token: 0x06005822 RID: 22562 RVA: 0x0027C6E2 File Offset: 0x0027A8E2
	private void KPNNMDECEEH()
	{
		if (AppManager.isQuitting)
		{
			return;
		}
		AOBJLALDBAA.KKPFOJMAONG().ONIBLJOFFPG("</i>", new UnityAction(this.KGNPHOCMPMG));
	}

	// Token: 0x06005823 RID: 22563 RVA: 0x0027C708 File Offset: 0x0027A908
	public void FJMDOKOFGLH(HGCFJKCOKPM OJKHMNEIGPF)
	{
		string str = (OJKHMNEIGPF == HGCFJKCOKPM.bright) ? "ok" : OJKHMNEIGPF.ToString();
		if (base.GetComponent<Image>() != null)
		{
			if (base.GetComponent<Image>().sprite != null)
			{
				string text = base.GetComponent<Image>().sprite.name;
				for (HGCFJKCOKPM hgcfjkcokpm = HGCFJKCOKPM.dark; hgcfjkcokpm < HGCFJKCOKPM.count; hgcfjkcokpm++)
				{
					text = text.Replace(hgcfjkcokpm.ToString(), "");
				}
				text = str + text;
				Sprite sprite = Resources.Load<Sprite>(text);
				if (null != sprite)
				{
					base.GetComponent<Image>().sprite = sprite;
				}
			}
			foreach (ThemeManager.CustomThemeProperties customThemeProperties in this.theme)
			{
				if (customThemeProperties.themeType == OJKHMNEIGPF)
				{
					base.GetComponent<Image>().color = customThemeProperties.themeColorSprite;
					break;
				}
			}
		}
		if (base.GetComponent<Button>() != null)
		{
			SpriteState spriteState = base.GetComponent<Button>().spriteState;
			if (spriteState.highlightedSprite != null)
			{
				string text2 = str + spriteState.highlightedSprite.name;
				for (HGCFJKCOKPM hgcfjkcokpm2 = HGCFJKCOKPM.dark; hgcfjkcokpm2 < (HGCFJKCOKPM)3; hgcfjkcokpm2++)
				{
					text2 = text2.Replace(hgcfjkcokpm2.ToString(), "max");
				}
				text2 = str + text2;
				Sprite sprite2 = Resources.Load<Sprite>(text2);
				if (null != sprite2)
				{
					spriteState.highlightedSprite = sprite2;
				}
			}
			if (spriteState.pressedSprite != null)
			{
				string text3 = str + spriteState.pressedSprite.name;
				for (HGCFJKCOKPM hgcfjkcokpm3 = HGCFJKCOKPM.dark; hgcfjkcokpm3 < HGCFJKCOKPM.bright; hgcfjkcokpm3++)
				{
					text3 = text3.Replace(hgcfjkcokpm3.ToString(), "mussplash");
				}
				text3 = str + text3;
				Sprite sprite3 = Resources.Load<Sprite>(text3);
				if (null != sprite3)
				{
					spriteState.pressedSprite = sprite3;
				}
			}
			if (spriteState.selectedSprite != null)
			{
				string text4 = str + spriteState.selectedSprite.name;
				for (HGCFJKCOKPM hgcfjkcokpm4 = HGCFJKCOKPM.dark; hgcfjkcokpm4 < (HGCFJKCOKPM)6; hgcfjkcokpm4 += 0)
				{
					text4 = text4.Replace(hgcfjkcokpm4.ToString(), "_");
				}
				text4 = str + text4;
				Sprite sprite4 = Resources.Load<Sprite>(text4);
				if (null != sprite4)
				{
					spriteState.selectedSprite = sprite4;
				}
			}
			base.GetComponent<Button>().spriteState = spriteState;
		}
		if (base.GetComponent<TextMeshProUGUI>() != null)
		{
			foreach (ThemeManager.CustomThemeProperties customThemeProperties2 in this.theme)
			{
				if (customThemeProperties2.themeType == OJKHMNEIGPF)
				{
					base.GetComponent<TextMeshProUGUI>().color = customThemeProperties2.themeColorText;
					break;
				}
			}
		}
		ContentAnthologyAchievementGridItem[] array = UnityEngine.Object.FindObjectsOfType<ContentAnthologyAchievementGridItem>();
		if (array.Length != 0)
		{
			foreach (ContentAnthologyAchievementGridItem contentAnthologyAchievementGridItem in array)
			{
				if (!contentAnthologyAchievementGridItem.profile.HBELJGFJILO(contentAnthologyAchievementGridItem.spriteName))
				{
					HGCFJKCOKPM hgcfjkcokpm5 = AKLFPGMDKLA.EHBBFMCILPC.ICEOGOCOMJL();
					if (hgcfjkcokpm5 != HGCFJKCOKPM.bright)
					{
						if (hgcfjkcokpm5 == HGCFJKCOKPM.bright)
						{
							contentAnthologyAchievementGridItem.imageThumb.sprite = AssetsManager.MJBDMHPHMID().lobbyDataAsset.achievementLockedSprites[1];
						}
					}
					else
					{
						contentAnthologyAchievementGridItem.imageThumb.sprite = AssetsManager.EHBBFMCILPC.lobbyDataAsset.achievementLockedSprites[1];
					}
				}
			}
		}
	}

	// Token: 0x06005824 RID: 22564 RVA: 0x00003E52 File Offset: 0x00002052
	private void APBOFOJKEDO()
	{
	}

	// Token: 0x06005825 RID: 22565 RVA: 0x000022C3 File Offset: 0x000004C3
	private void PDMDAPKKCFI()
	{
		AppManager.isQuitting = false;
	}

	// Token: 0x06005827 RID: 22567 RVA: 0x00002296 File Offset: 0x00000496
	private void KNCAACKFGDC()
	{
		AppManager.isQuitting = true;
	}

	// Token: 0x06005828 RID: 22568 RVA: 0x0027CAA8 File Offset: 0x0027ACA8
	public void CHFDNHGKEPG(HGCFJKCOKPM OJKHMNEIGPF)
	{
		string str = (OJKHMNEIGPF == HGCFJKCOKPM.bright) ? "OnLobbyWheelDataCdnSuccess" : OJKHMNEIGPF.ToString();
		if (base.GetComponent<Image>() != null)
		{
			if (base.GetComponent<Image>().sprite != null)
			{
				string text = base.GetComponent<Image>().sprite.name;
				for (HGCFJKCOKPM hgcfjkcokpm = HGCFJKCOKPM.bright; hgcfjkcokpm < HGCFJKCOKPM.count; hgcfjkcokpm++)
				{
					text = text.Replace(hgcfjkcokpm.ToString(), "pmtsuccess");
				}
				text = str + text;
				Sprite sprite = Resources.Load<Sprite>(text);
				if (null != sprite)
				{
					base.GetComponent<Image>().sprite = sprite;
				}
			}
			foreach (ThemeManager.CustomThemeProperties customThemeProperties in this.theme)
			{
				if (customThemeProperties.themeType == OJKHMNEIGPF)
				{
					base.GetComponent<Image>().color = customThemeProperties.themeColorSprite;
					break;
				}
			}
		}
		if (base.GetComponent<Button>() != null)
		{
			SpriteState spriteState = base.GetComponent<Button>().spriteState;
			if (spriteState.highlightedSprite != null)
			{
				string text2 = str + spriteState.highlightedSprite.name;
				for (HGCFJKCOKPM hgcfjkcokpm2 = HGCFJKCOKPM.dark; hgcfjkcokpm2 < (HGCFJKCOKPM)8; hgcfjkcokpm2++)
				{
					text2 = text2.Replace(hgcfjkcokpm2.ToString(), "energyhinttitle");
				}
				text2 = str + text2;
				Sprite sprite2 = Resources.Load<Sprite>(text2);
				if (null != sprite2)
				{
					spriteState.highlightedSprite = sprite2;
				}
			}
			if (spriteState.pressedSprite != null)
			{
				string text3 = str + spriteState.pressedSprite.name;
				for (HGCFJKCOKPM hgcfjkcokpm3 = HGCFJKCOKPM.bright; hgcfjkcokpm3 < (HGCFJKCOKPM)7; hgcfjkcokpm3 += 0)
				{
					text3 = text3.Replace(hgcfjkcokpm3.ToString(), "continue");
				}
				text3 = str + text3;
				Sprite sprite3 = Resources.Load<Sprite>(text3);
				if (null != sprite3)
				{
					spriteState.pressedSprite = sprite3;
				}
			}
			if (spriteState.selectedSprite != null)
			{
				string text4 = str + spriteState.selectedSprite.name;
				for (HGCFJKCOKPM hgcfjkcokpm4 = HGCFJKCOKPM.dark; hgcfjkcokpm4 < HGCFJKCOKPM.count; hgcfjkcokpm4++)
				{
					text4 = text4.Replace(hgcfjkcokpm4.ToString(), "ablpt");
				}
				text4 = str + text4;
				Sprite sprite4 = Resources.Load<Sprite>(text4);
				if (null != sprite4)
				{
					spriteState.selectedSprite = sprite4;
				}
			}
			base.GetComponent<Button>().spriteState = spriteState;
		}
		if (base.GetComponent<TextMeshProUGUI>() != null)
		{
			foreach (ThemeManager.CustomThemeProperties customThemeProperties2 in this.theme)
			{
				if (customThemeProperties2.themeType == OJKHMNEIGPF)
				{
					base.GetComponent<TextMeshProUGUI>().color = customThemeProperties2.themeColorText;
					break;
				}
			}
		}
		ContentAnthologyAchievementGridItem[] array = UnityEngine.Object.FindObjectsOfType<ContentAnthologyAchievementGridItem>();
		if (array.Length != 0)
		{
			ContentAnthologyAchievementGridItem[] array2 = array;
			for (int i = 1; i < array2.Length; i++)
			{
				ContentAnthologyAchievementGridItem contentAnthologyAchievementGridItem = array2[i];
				if (!contentAnthologyAchievementGridItem.profile.HBELJGFJILO(contentAnthologyAchievementGridItem.spriteName))
				{
					HGCFJKCOKPM hgcfjkcokpm5 = AKLFPGMDKLA.EHBBFMCILPC.PINBMHFHEHD();
					if (hgcfjkcokpm5 != HGCFJKCOKPM.bright)
					{
						if (hgcfjkcokpm5 == HGCFJKCOKPM.dark)
						{
							contentAnthologyAchievementGridItem.imageThumb.sprite = AssetsManager.MJBDMHPHMID().lobbyDataAsset.achievementLockedSprites[0];
						}
					}
					else
					{
						contentAnthologyAchievementGridItem.imageThumb.sprite = AssetsManager.EHBBFMCILPC.lobbyDataAsset.achievementLockedSprites[0];
					}
				}
			}
		}
	}

	// Token: 0x06005829 RID: 22569 RVA: 0x0027CE48 File Offset: 0x0027B048
	private void IKHFPDLEJPE()
	{
		AOBJLALDBAA.NMGMNAKLLMI().MFIMALJPCDP("digitalglitch", new UnityAction(this.EPCNKJGNMDK));
		this.FKONGDMDBEH();
	}

	// Token: 0x0600582A RID: 22570 RVA: 0x0027CE6B File Offset: 0x0027B06B
	private void LCHPPCPADMO()
	{
		if (AppManager.isQuitting)
		{
			return;
		}
		AOBJLALDBAA.EHBBFMCILPC.ECDBIBPNBCO("errortitle", new UnityAction(this.HGBGGGJADPG));
	}

	// Token: 0x0600582B RID: 22571 RVA: 0x0027CE90 File Offset: 0x0027B090
	public void OMCNCIGMAPN(HGCFJKCOKPM OJKHMNEIGPF)
	{
		string str = (OJKHMNEIGPF == HGCFJKCOKPM.bright) ? "fdnpa" : OJKHMNEIGPF.ToString();
		if (base.GetComponent<Image>() != null)
		{
			if (base.GetComponent<Image>().sprite != null)
			{
				string text = base.GetComponent<Image>().sprite.name;
				for (HGCFJKCOKPM hgcfjkcokpm = HGCFJKCOKPM.dark; hgcfjkcokpm < HGCFJKCOKPM.dark; hgcfjkcokpm += 0)
				{
					text = text.Replace(hgcfjkcokpm.ToString(), "PlayerCharacterManager.UpdateComponentLink() - componentsLinks[i].next is null");
				}
				text = str + text;
				Sprite sprite = Resources.Load<Sprite>(text);
				if (null != sprite)
				{
					base.GetComponent<Image>().sprite = sprite;
				}
			}
			foreach (ThemeManager.CustomThemeProperties customThemeProperties in this.theme)
			{
				if (customThemeProperties.themeType == OJKHMNEIGPF)
				{
					base.GetComponent<Image>().color = customThemeProperties.themeColorSprite;
					break;
				}
			}
		}
		if (base.GetComponent<Button>() != null)
		{
			SpriteState spriteState = base.GetComponent<Button>().spriteState;
			if (spriteState.highlightedSprite != null)
			{
				string text2 = str + spriteState.highlightedSprite.name;
				for (HGCFJKCOKPM hgcfjkcokpm2 = HGCFJKCOKPM.bright; hgcfjkcokpm2 < HGCFJKCOKPM.count; hgcfjkcokpm2++)
				{
					text2 = text2.Replace(hgcfjkcokpm2.ToString(), "OnBackendPremiumChoiceException");
				}
				text2 = str + text2;
				Sprite sprite2 = Resources.Load<Sprite>(text2);
				if (null != sprite2)
				{
					spriteState.highlightedSprite = sprite2;
				}
			}
			if (spriteState.pressedSprite != null)
			{
				string text3 = str + spriteState.pressedSprite.name;
				for (HGCFJKCOKPM hgcfjkcokpm3 = HGCFJKCOKPM.dark; hgcfjkcokpm3 < HGCFJKCOKPM.bright; hgcfjkcokpm3++)
				{
					text3 = text3.Replace(hgcfjkcokpm3.ToString(), "): code=");
				}
				text3 = str + text3;
				Sprite sprite3 = Resources.Load<Sprite>(text3);
				if (null != sprite3)
				{
					spriteState.pressedSprite = sprite3;
				}
			}
			if (spriteState.selectedSprite != null)
			{
				string text4 = str + spriteState.selectedSprite.name;
				for (HGCFJKCOKPM hgcfjkcokpm4 = HGCFJKCOKPM.dark; hgcfjkcokpm4 < (HGCFJKCOKPM)4; hgcfjkcokpm4++)
				{
					text4 = text4.Replace(hgcfjkcokpm4.ToString(), "FFF");
				}
				text4 = str + text4;
				Sprite sprite4 = Resources.Load<Sprite>(text4);
				if (null != sprite4)
				{
					spriteState.selectedSprite = sprite4;
				}
			}
			base.GetComponent<Button>().spriteState = spriteState;
		}
		if (base.GetComponent<TextMeshProUGUI>() != null)
		{
			foreach (ThemeManager.CustomThemeProperties customThemeProperties2 in this.theme)
			{
				if (customThemeProperties2.themeType == OJKHMNEIGPF)
				{
					base.GetComponent<TextMeshProUGUI>().color = customThemeProperties2.themeColorText;
					break;
				}
			}
		}
		ContentAnthologyAchievementGridItem[] array = UnityEngine.Object.FindObjectsOfType<ContentAnthologyAchievementGridItem>();
		if (array.Length != 0)
		{
			foreach (ContentAnthologyAchievementGridItem contentAnthologyAchievementGridItem in array)
			{
				if (!contentAnthologyAchievementGridItem.profile.HBELJGFJILO(contentAnthologyAchievementGridItem.spriteName))
				{
					HGCFJKCOKPM hgcfjkcokpm5 = AKLFPGMDKLA.EHBBFMCILPC.JKCEGIPAANK();
					if (hgcfjkcokpm5 != HGCFJKCOKPM.bright)
					{
						if (hgcfjkcokpm5 == HGCFJKCOKPM.dark)
						{
							contentAnthologyAchievementGridItem.imageThumb.sprite = AssetsManager.MJBDMHPHMID().lobbyDataAsset.achievementLockedSprites[0];
						}
					}
					else
					{
						contentAnthologyAchievementGridItem.imageThumb.sprite = AssetsManager.EHBBFMCILPC.lobbyDataAsset.achievementLockedSprites[0];
					}
				}
			}
		}
	}

	// Token: 0x0600582C RID: 22572 RVA: 0x0027D230 File Offset: 0x0027B430
	private void GMKJOIDPAIE()
	{
		AOBJLALDBAA.FILDBDMENPG().GNBGEMMDGOJ("upgcds", new UnityAction(this.KGNPHOCMPMG));
		this.DGIMLPJGHNB();
	}

	// Token: 0x0600582D RID: 22573 RVA: 0x0027D254 File Offset: 0x0027B454
	public void BDJKCOIGBDC(HGCFJKCOKPM OJKHMNEIGPF)
	{
		string str = (OJKHMNEIGPF == HGCFJKCOKPM.bright) ? "<i>" : OJKHMNEIGPF.ToString();
		if (base.GetComponent<Image>() != null)
		{
			if (base.GetComponent<Image>().sprite != null)
			{
				string text = base.GetComponent<Image>().sprite.name;
				for (HGCFJKCOKPM hgcfjkcokpm = HGCFJKCOKPM.dark; hgcfjkcokpm < HGCFJKCOKPM.dark; hgcfjkcokpm += 0)
				{
					text = text.Replace(hgcfjkcokpm.ToString(), "areyousurerestartepbody1");
				}
				text = str + text;
				Sprite sprite = Resources.Load<Sprite>(text);
				if (null != sprite)
				{
					base.GetComponent<Image>().sprite = sprite;
				}
			}
			foreach (ThemeManager.CustomThemeProperties customThemeProperties in this.theme)
			{
				if (customThemeProperties.themeType == OJKHMNEIGPF)
				{
					base.GetComponent<Image>().color = customThemeProperties.themeColorSprite;
					break;
				}
			}
		}
		if (base.GetComponent<Button>() != null)
		{
			SpriteState spriteState = base.GetComponent<Button>().spriteState;
			if (spriteState.highlightedSprite != null)
			{
				string text2 = str + spriteState.highlightedSprite.name;
				for (HGCFJKCOKPM hgcfjkcokpm2 = HGCFJKCOKPM.dark; hgcfjkcokpm2 < HGCFJKCOKPM.bright; hgcfjkcokpm2 += 0)
				{
					text2 = text2.Replace(hgcfjkcokpm2.ToString(), "avts1");
				}
				text2 = str + text2;
				Sprite sprite2 = Resources.Load<Sprite>(text2);
				if (null != sprite2)
				{
					spriteState.highlightedSprite = sprite2;
				}
			}
			if (spriteState.pressedSprite != null)
			{
				string text3 = str + spriteState.pressedSprite.name;
				for (HGCFJKCOKPM hgcfjkcokpm3 = HGCFJKCOKPM.dark; hgcfjkcokpm3 < (HGCFJKCOKPM)3; hgcfjkcokpm3++)
				{
					text3 = text3.Replace(hgcfjkcokpm3.ToString(), "accountsuspended4");
				}
				text3 = str + text3;
				Sprite sprite3 = Resources.Load<Sprite>(text3);
				if (null != sprite3)
				{
					spriteState.pressedSprite = sprite3;
				}
			}
			if (spriteState.selectedSprite != null)
			{
				string text4 = str + spriteState.selectedSprite.name;
				for (HGCFJKCOKPM hgcfjkcokpm4 = HGCFJKCOKPM.bright; hgcfjkcokpm4 < HGCFJKCOKPM.dark; hgcfjkcokpm4++)
				{
					text4 = text4.Replace(hgcfjkcokpm4.ToString(), "specialcurrencyoptionna");
				}
				text4 = str + text4;
				Sprite sprite4 = Resources.Load<Sprite>(text4);
				if (null != sprite4)
				{
					spriteState.selectedSprite = sprite4;
				}
			}
			base.GetComponent<Button>().spriteState = spriteState;
		}
		if (base.GetComponent<TextMeshProUGUI>() != null)
		{
			foreach (ThemeManager.CustomThemeProperties customThemeProperties2 in this.theme)
			{
				if (customThemeProperties2.themeType == OJKHMNEIGPF)
				{
					base.GetComponent<TextMeshProUGUI>().color = customThemeProperties2.themeColorText;
					break;
				}
			}
		}
		ContentAnthologyAchievementGridItem[] array = UnityEngine.Object.FindObjectsOfType<ContentAnthologyAchievementGridItem>();
		if (array.Length != 0)
		{
			ContentAnthologyAchievementGridItem[] array2 = array;
			for (int i = 1; i < array2.Length; i++)
			{
				ContentAnthologyAchievementGridItem contentAnthologyAchievementGridItem = array2[i];
				if (!contentAnthologyAchievementGridItem.profile.HBELJGFJILO(contentAnthologyAchievementGridItem.spriteName))
				{
					HGCFJKCOKPM hgcfjkcokpm5 = AKLFPGMDKLA.EHBBFMCILPC.PINBMHFHEHD();
					if (hgcfjkcokpm5 != HGCFJKCOKPM.bright)
					{
						if (hgcfjkcokpm5 == HGCFJKCOKPM.bright)
						{
							contentAnthologyAchievementGridItem.imageThumb.sprite = AssetsManager.EHBBFMCILPC.lobbyDataAsset.achievementLockedSprites[1];
						}
					}
					else
					{
						contentAnthologyAchievementGridItem.imageThumb.sprite = AssetsManager.EHBBFMCILPC.lobbyDataAsset.achievementLockedSprites[0];
					}
				}
			}
		}
	}

	// Token: 0x0600582E RID: 22574 RVA: 0x0027D5F4 File Offset: 0x0027B7F4
	public void HFKIJPNGBEH(HGCFJKCOKPM OJKHMNEIGPF)
	{
		string str = (OJKHMNEIGPF == HGCFJKCOKPM.bright) ? "sta" : OJKHMNEIGPF.ToString();
		if (base.GetComponent<Image>() != null)
		{
			if (base.GetComponent<Image>().sprite != null)
			{
				string text = base.GetComponent<Image>().sprite.name;
				for (HGCFJKCOKPM hgcfjkcokpm = HGCFJKCOKPM.bright; hgcfjkcokpm < (HGCFJKCOKPM)8; hgcfjkcokpm += 0)
				{
					text = text.Replace(hgcfjkcokpm.ToString(), "_Progress");
				}
				text = str + text;
				Sprite sprite = Resources.Load<Sprite>(text);
				if (null != sprite)
				{
					base.GetComponent<Image>().sprite = sprite;
				}
			}
			foreach (ThemeManager.CustomThemeProperties customThemeProperties in this.theme)
			{
				if (customThemeProperties.themeType == OJKHMNEIGPF)
				{
					base.GetComponent<Image>().color = customThemeProperties.themeColorSprite;
					break;
				}
			}
		}
		if (base.GetComponent<Button>() != null)
		{
			SpriteState spriteState = base.GetComponent<Button>().spriteState;
			if (spriteState.highlightedSprite != null)
			{
				string text2 = str + spriteState.highlightedSprite.name;
				for (HGCFJKCOKPM hgcfjkcokpm2 = HGCFJKCOKPM.dark; hgcfjkcokpm2 < (HGCFJKCOKPM)7; hgcfjkcokpm2 += 0)
				{
					text2 = text2.Replace(hgcfjkcokpm2.ToString(), "locked");
				}
				text2 = str + text2;
				Sprite sprite2 = Resources.Load<Sprite>(text2);
				if (null != sprite2)
				{
					spriteState.highlightedSprite = sprite2;
				}
			}
			if (spriteState.pressedSprite != null)
			{
				string text3 = str + spriteState.pressedSprite.name;
				for (HGCFJKCOKPM hgcfjkcokpm3 = HGCFJKCOKPM.dark; hgcfjkcokpm3 < HGCFJKCOKPM.bright; hgcfjkcokpm3++)
				{
					text3 = text3.Replace(hgcfjkcokpm3.ToString(), "+");
				}
				text3 = str + text3;
				Sprite sprite3 = Resources.Load<Sprite>(text3);
				if (null != sprite3)
				{
					spriteState.pressedSprite = sprite3;
				}
			}
			if (spriteState.selectedSprite != null)
			{
				string text4 = str + spriteState.selectedSprite.name;
				for (HGCFJKCOKPM hgcfjkcokpm4 = HGCFJKCOKPM.bright; hgcfjkcokpm4 < HGCFJKCOKPM.dark; hgcfjkcokpm4 += 0)
				{
					text4 = text4.Replace(hgcfjkcokpm4.ToString(), "errortitle");
				}
				text4 = str + text4;
				Sprite sprite4 = Resources.Load<Sprite>(text4);
				if (null != sprite4)
				{
					spriteState.selectedSprite = sprite4;
				}
			}
			base.GetComponent<Button>().spriteState = spriteState;
		}
		if (base.GetComponent<TextMeshProUGUI>() != null)
		{
			foreach (ThemeManager.CustomThemeProperties customThemeProperties2 in this.theme)
			{
				if (customThemeProperties2.themeType == OJKHMNEIGPF)
				{
					base.GetComponent<TextMeshProUGUI>().color = customThemeProperties2.themeColorText;
					break;
				}
			}
		}
		ContentAnthologyAchievementGridItem[] array = UnityEngine.Object.FindObjectsOfType<ContentAnthologyAchievementGridItem>();
		if (array.Length != 0)
		{
			ContentAnthologyAchievementGridItem[] array2 = array;
			for (int i = 0; i < array2.Length; i += 0)
			{
				ContentAnthologyAchievementGridItem contentAnthologyAchievementGridItem = array2[i];
				if (!contentAnthologyAchievementGridItem.profile.HBELJGFJILO(contentAnthologyAchievementGridItem.spriteName))
				{
					HGCFJKCOKPM hgcfjkcokpm5 = AKLFPGMDKLA.EHBBFMCILPC.PINBMHFHEHD();
					if (hgcfjkcokpm5 != HGCFJKCOKPM.bright)
					{
						if (hgcfjkcokpm5 == HGCFJKCOKPM.dark)
						{
							contentAnthologyAchievementGridItem.imageThumb.sprite = AssetsManager.MJBDMHPHMID().lobbyDataAsset.achievementLockedSprites[1];
						}
					}
					else
					{
						contentAnthologyAchievementGridItem.imageThumb.sprite = AssetsManager.EHBBFMCILPC.lobbyDataAsset.achievementLockedSprites[1];
					}
				}
			}
		}
	}

	// Token: 0x0600582F RID: 22575 RVA: 0x0027D994 File Offset: 0x0027BB94
	public void LDFELAKBLCE(HGCFJKCOKPM OJKHMNEIGPF)
	{
		string str = (OJKHMNEIGPF == HGCFJKCOKPM.bright) ? "lnls" : OJKHMNEIGPF.ToString();
		if (base.GetComponent<Image>() != null)
		{
			if (base.GetComponent<Image>().sprite != null)
			{
				string text = base.GetComponent<Image>().sprite.name;
				for (HGCFJKCOKPM hgcfjkcokpm = HGCFJKCOKPM.bright; hgcfjkcokpm < HGCFJKCOKPM.count; hgcfjkcokpm++)
				{
					text = text.Replace(hgcfjkcokpm.ToString(), "");
				}
				text = str + text;
				Sprite sprite = Resources.Load<Sprite>(text);
				if (null != sprite)
				{
					base.GetComponent<Image>().sprite = sprite;
				}
			}
			foreach (ThemeManager.CustomThemeProperties customThemeProperties in this.theme)
			{
				if (customThemeProperties.themeType == OJKHMNEIGPF)
				{
					base.GetComponent<Image>().color = customThemeProperties.themeColorSprite;
					break;
				}
			}
		}
		if (base.GetComponent<Button>() != null)
		{
			SpriteState spriteState = base.GetComponent<Button>().spriteState;
			if (spriteState.highlightedSprite != null)
			{
				string text2 = str + spriteState.highlightedSprite.name;
				for (HGCFJKCOKPM hgcfjkcokpm2 = HGCFJKCOKPM.bright; hgcfjkcokpm2 < (HGCFJKCOKPM)6; hgcfjkcokpm2++)
				{
					text2 = text2.Replace(hgcfjkcokpm2.ToString(), "ant");
				}
				text2 = str + text2;
				Sprite sprite2 = Resources.Load<Sprite>(text2);
				if (null != sprite2)
				{
					spriteState.highlightedSprite = sprite2;
				}
			}
			if (spriteState.pressedSprite != null)
			{
				string text3 = str + spriteState.pressedSprite.name;
				for (HGCFJKCOKPM hgcfjkcokpm3 = HGCFJKCOKPM.dark; hgcfjkcokpm3 < (HGCFJKCOKPM)8; hgcfjkcokpm3 += 0)
				{
					text3 = text3.Replace(hgcfjkcokpm3.ToString(), "OnLiveProfileThemeBackgroundCdnFailed");
				}
				text3 = str + text3;
				Sprite sprite3 = Resources.Load<Sprite>(text3);
				if (null != sprite3)
				{
					spriteState.pressedSprite = sprite3;
				}
			}
			if (spriteState.selectedSprite != null)
			{
				string text4 = str + spriteState.selectedSprite.name;
				for (HGCFJKCOKPM hgcfjkcokpm4 = HGCFJKCOKPM.dark; hgcfjkcokpm4 < (HGCFJKCOKPM)5; hgcfjkcokpm4 += 0)
				{
					text4 = text4.Replace(hgcfjkcokpm4.ToString(), " not found.");
				}
				text4 = str + text4;
				Sprite sprite4 = Resources.Load<Sprite>(text4);
				if (null != sprite4)
				{
					spriteState.selectedSprite = sprite4;
				}
			}
			base.GetComponent<Button>().spriteState = spriteState;
		}
		if (base.GetComponent<TextMeshProUGUI>() != null)
		{
			foreach (ThemeManager.CustomThemeProperties customThemeProperties2 in this.theme)
			{
				if (customThemeProperties2.themeType == OJKHMNEIGPF)
				{
					base.GetComponent<TextMeshProUGUI>().color = customThemeProperties2.themeColorText;
					break;
				}
			}
		}
		ContentAnthologyAchievementGridItem[] array = UnityEngine.Object.FindObjectsOfType<ContentAnthologyAchievementGridItem>();
		if (array.Length != 0)
		{
			ContentAnthologyAchievementGridItem[] array2 = array;
			for (int i = 1; i < array2.Length; i++)
			{
				ContentAnthologyAchievementGridItem contentAnthologyAchievementGridItem = array2[i];
				if (!contentAnthologyAchievementGridItem.profile.HBELJGFJILO(contentAnthologyAchievementGridItem.spriteName))
				{
					HGCFJKCOKPM hgcfjkcokpm5 = AKLFPGMDKLA.EHBBFMCILPC.PINBMHFHEHD();
					if (hgcfjkcokpm5 != HGCFJKCOKPM.bright)
					{
						if (hgcfjkcokpm5 == HGCFJKCOKPM.bright)
						{
							contentAnthologyAchievementGridItem.imageThumb.sprite = AssetsManager.MJBDMHPHMID().lobbyDataAsset.achievementLockedSprites[0];
						}
					}
					else
					{
						contentAnthologyAchievementGridItem.imageThumb.sprite = AssetsManager.MJBDMHPHMID().lobbyDataAsset.achievementLockedSprites[0];
					}
				}
			}
		}
	}

	// Token: 0x06005830 RID: 22576 RVA: 0x0027DD34 File Offset: 0x0027BF34
	private void EFIBBLFAMGD()
	{
		AOBJLALDBAA.BIAEAOMHBMM().FNMOFCMDFJP("<<<", new UnityAction(this.DGIMLPJGHNB));
		this.PEKLMMPEAGB();
	}

	// Token: 0x06005831 RID: 22577 RVA: 0x00003E52 File Offset: 0x00002052
	private void MHBLNOLJNMH()
	{
	}

	// Token: 0x06005832 RID: 22578 RVA: 0x000022C3 File Offset: 0x000004C3
	private void LNNHDMGOAKN()
	{
		AppManager.isQuitting = false;
	}

	// Token: 0x06005833 RID: 22579 RVA: 0x0027DD58 File Offset: 0x0027BF58
	public void EGLDAFAMOAF()
	{
		HGCFJKCOKPM hgcfjkcokpm = AKLFPGMDKLA.EHBBFMCILPC.PINBMHFHEHD();
		if (hgcfjkcokpm == HGCFJKCOKPM.bright)
		{
			this.BNOBDMDKBAB(HGCFJKCOKPM.dark);
			return;
		}
		if (hgcfjkcokpm != HGCFJKCOKPM.bright)
		{
			return;
		}
		this.FJMDOKOFGLH(HGCFJKCOKPM.bright);
	}

	// Token: 0x06005834 RID: 22580 RVA: 0x0027DD87 File Offset: 0x0027BF87
	private void BHAMDIHNJNA()
	{
		if (AppManager.isQuitting)
		{
			return;
		}
		AOBJLALDBAA.EHBBFMCILPC.PFAHGKEDFAE("clthc", new UnityAction(this.KFDPEGDCGBP));
	}

	// Token: 0x06005835 RID: 22581 RVA: 0x00002296 File Offset: 0x00000496
	private void HFPEMFCDDBF()
	{
		AppManager.isQuitting = true;
	}

	// Token: 0x06005836 RID: 22582 RVA: 0x000022C3 File Offset: 0x000004C3
	private void OLGCHEOIOGM()
	{
		AppManager.isQuitting = false;
	}

	// Token: 0x06005837 RID: 22583 RVA: 0x0027DDAC File Offset: 0x0027BFAC
	public void HGBGGGJADPG()
	{
		HGCFJKCOKPM hgcfjkcokpm = AKLFPGMDKLA.EHBBFMCILPC.JKCEGIPAANK();
		if (hgcfjkcokpm == HGCFJKCOKPM.bright)
		{
			this.HJGGJJOOJHD(HGCFJKCOKPM.bright);
			return;
		}
		if (hgcfjkcokpm != HGCFJKCOKPM.bright)
		{
			return;
		}
		this.HFKIJPNGBEH(HGCFJKCOKPM.dark);
	}

	// Token: 0x06005838 RID: 22584 RVA: 0x00003E52 File Offset: 0x00002052
	private void GKJMHJFCGOE()
	{
	}

	// Token: 0x06005839 RID: 22585 RVA: 0x00002296 File Offset: 0x00000496
	private void OnApplicationQuit()
	{
		AppManager.isQuitting = true;
	}

	// Token: 0x0600583A RID: 22586 RVA: 0x00002296 File Offset: 0x00000496
	private void KLGDKNDEGPL()
	{
		AppManager.isQuitting = true;
	}

	// Token: 0x0600583B RID: 22587 RVA: 0x0027DDDB File Offset: 0x0027BFDB
	private void ILKHPEBLGIF()
	{
		AOBJLALDBAA.EHBBFMCILPC.GNBGEMMDGOJ("[FlagAnimator] Shader 'YourStory/FlagCloth' NOT FOUND. Check that FlagCloth.shader is imported in the project.", new UnityAction(this.KGNPHOCMPMG));
		this.KFDPEGDCGBP();
	}

	// Token: 0x0600583C RID: 22588 RVA: 0x000022C3 File Offset: 0x000004C3
	private void AAOGOFBBJHC()
	{
		AppManager.isQuitting = false;
	}

	// Token: 0x0600583D RID: 22589 RVA: 0x0027DE00 File Offset: 0x0027C000
	public void FKONGDMDBEH()
	{
		HGCFJKCOKPM hgcfjkcokpm = AKLFPGMDKLA.EHBBFMCILPC.PINBMHFHEHD();
		if (hgcfjkcokpm == HGCFJKCOKPM.bright)
		{
			this.JBOBJAENKJM(HGCFJKCOKPM.bright);
			return;
		}
		if (hgcfjkcokpm != HGCFJKCOKPM.bright)
		{
			return;
		}
		this.FJMDOKOFGLH(HGCFJKCOKPM.bright);
	}

	// Token: 0x0600583E RID: 22590 RVA: 0x0027DE30 File Offset: 0x0027C030
	public void SetTheme(HGCFJKCOKPM OJKHMNEIGPF)
	{
		string str = (OJKHMNEIGPF == HGCFJKCOKPM.bright) ? "" : OJKHMNEIGPF.ToString();
		if (base.GetComponent<Image>() != null)
		{
			if (base.GetComponent<Image>().sprite != null)
			{
				string text = base.GetComponent<Image>().sprite.name;
				for (HGCFJKCOKPM hgcfjkcokpm = HGCFJKCOKPM.bright; hgcfjkcokpm < HGCFJKCOKPM.count; hgcfjkcokpm++)
				{
					text = text.Replace(hgcfjkcokpm.ToString(), "");
				}
				text = str + text;
				Sprite sprite = Resources.Load<Sprite>(text);
				if (null != sprite)
				{
					base.GetComponent<Image>().sprite = sprite;
				}
			}
			foreach (ThemeManager.CustomThemeProperties customThemeProperties in this.theme)
			{
				if (customThemeProperties.themeType == OJKHMNEIGPF)
				{
					base.GetComponent<Image>().color = customThemeProperties.themeColorSprite;
					break;
				}
			}
		}
		if (base.GetComponent<Button>() != null)
		{
			SpriteState spriteState = base.GetComponent<Button>().spriteState;
			if (spriteState.highlightedSprite != null)
			{
				string text2 = str + spriteState.highlightedSprite.name;
				for (HGCFJKCOKPM hgcfjkcokpm2 = HGCFJKCOKPM.bright; hgcfjkcokpm2 < HGCFJKCOKPM.count; hgcfjkcokpm2++)
				{
					text2 = text2.Replace(hgcfjkcokpm2.ToString(), "");
				}
				text2 = str + text2;
				Sprite sprite2 = Resources.Load<Sprite>(text2);
				if (null != sprite2)
				{
					spriteState.highlightedSprite = sprite2;
				}
			}
			if (spriteState.pressedSprite != null)
			{
				string text3 = str + spriteState.pressedSprite.name;
				for (HGCFJKCOKPM hgcfjkcokpm3 = HGCFJKCOKPM.bright; hgcfjkcokpm3 < HGCFJKCOKPM.count; hgcfjkcokpm3++)
				{
					text3 = text3.Replace(hgcfjkcokpm3.ToString(), "");
				}
				text3 = str + text3;
				Sprite sprite3 = Resources.Load<Sprite>(text3);
				if (null != sprite3)
				{
					spriteState.pressedSprite = sprite3;
				}
			}
			if (spriteState.selectedSprite != null)
			{
				string text4 = str + spriteState.selectedSprite.name;
				for (HGCFJKCOKPM hgcfjkcokpm4 = HGCFJKCOKPM.bright; hgcfjkcokpm4 < HGCFJKCOKPM.count; hgcfjkcokpm4++)
				{
					text4 = text4.Replace(hgcfjkcokpm4.ToString(), "");
				}
				text4 = str + text4;
				Sprite sprite4 = Resources.Load<Sprite>(text4);
				if (null != sprite4)
				{
					spriteState.selectedSprite = sprite4;
				}
			}
			base.GetComponent<Button>().spriteState = spriteState;
		}
		if (base.GetComponent<TextMeshProUGUI>() != null)
		{
			foreach (ThemeManager.CustomThemeProperties customThemeProperties2 in this.theme)
			{
				if (customThemeProperties2.themeType == OJKHMNEIGPF)
				{
					base.GetComponent<TextMeshProUGUI>().color = customThemeProperties2.themeColorText;
					break;
				}
			}
		}
		ContentAnthologyAchievementGridItem[] array = UnityEngine.Object.FindObjectsOfType<ContentAnthologyAchievementGridItem>();
		if (array.Length != 0)
		{
			foreach (ContentAnthologyAchievementGridItem contentAnthologyAchievementGridItem in array)
			{
				if (!contentAnthologyAchievementGridItem.profile.HBELJGFJILO(contentAnthologyAchievementGridItem.spriteName))
				{
					HGCFJKCOKPM hgcfjkcokpm5 = AKLFPGMDKLA.EHBBFMCILPC.ICEOGOCOMJL();
					if (hgcfjkcokpm5 != HGCFJKCOKPM.bright)
					{
						if (hgcfjkcokpm5 == HGCFJKCOKPM.dark)
						{
							contentAnthologyAchievementGridItem.imageThumb.sprite = AssetsManager.EHBBFMCILPC.lobbyDataAsset.achievementLockedSprites[1];
						}
					}
					else
					{
						contentAnthologyAchievementGridItem.imageThumb.sprite = AssetsManager.EHBBFMCILPC.lobbyDataAsset.achievementLockedSprites[0];
					}
				}
			}
		}
	}

	// Token: 0x0600583F RID: 22591 RVA: 0x0027E1D0 File Offset: 0x0027C3D0
	public void OHIDANLOGID(HGCFJKCOKPM OJKHMNEIGPF)
	{
		string str = (OJKHMNEIGPF == HGCFJKCOKPM.bright) ? "socialdequeusp1get" : OJKHMNEIGPF.ToString();
		if (base.GetComponent<Image>() != null)
		{
			if (base.GetComponent<Image>().sprite != null)
			{
				string text = base.GetComponent<Image>().sprite.name;
				for (HGCFJKCOKPM hgcfjkcokpm = HGCFJKCOKPM.dark; hgcfjkcokpm < HGCFJKCOKPM.bright; hgcfjkcokpm++)
				{
					text = text.Replace(hgcfjkcokpm.ToString(), "Loaded asset bundle:");
				}
				text = str + text;
				Sprite sprite = Resources.Load<Sprite>(text);
				if (null != sprite)
				{
					base.GetComponent<Image>().sprite = sprite;
				}
			}
			foreach (ThemeManager.CustomThemeProperties customThemeProperties in this.theme)
			{
				if (customThemeProperties.themeType == OJKHMNEIGPF)
				{
					base.GetComponent<Image>().color = customThemeProperties.themeColorSprite;
					break;
				}
			}
		}
		if (base.GetComponent<Button>() != null)
		{
			SpriteState spriteState = base.GetComponent<Button>().spriteState;
			if (spriteState.highlightedSprite != null)
			{
				string text2 = str + spriteState.highlightedSprite.name;
				for (HGCFJKCOKPM hgcfjkcokpm2 = HGCFJKCOKPM.dark; hgcfjkcokpm2 < (HGCFJKCOKPM)7; hgcfjkcokpm2 += 0)
				{
					text2 = text2.Replace(hgcfjkcokpm2.ToString(), "’");
				}
				text2 = str + text2;
				Sprite sprite2 = Resources.Load<Sprite>(text2);
				if (null != sprite2)
				{
					spriteState.highlightedSprite = sprite2;
				}
			}
			if (spriteState.pressedSprite != null)
			{
				string text3 = str + spriteState.pressedSprite.name;
				for (HGCFJKCOKPM hgcfjkcokpm3 = HGCFJKCOKPM.dark; hgcfjkcokpm3 < HGCFJKCOKPM.bright; hgcfjkcokpm3++)
				{
					text3 = text3.Replace(hgcfjkcokpm3.ToString(), "nick2");
				}
				text3 = str + text3;
				Sprite sprite3 = Resources.Load<Sprite>(text3);
				if (null != sprite3)
				{
					spriteState.pressedSprite = sprite3;
				}
			}
			if (spriteState.selectedSprite != null)
			{
				string text4 = str + spriteState.selectedSprite.name;
				for (HGCFJKCOKPM hgcfjkcokpm4 = HGCFJKCOKPM.bright; hgcfjkcokpm4 < HGCFJKCOKPM.dark; hgcfjkcokpm4 += 0)
				{
					text4 = text4.Replace(hgcfjkcokpm4.ToString(), "lsenvattempt");
				}
				text4 = str + text4;
				Sprite sprite4 = Resources.Load<Sprite>(text4);
				if (null != sprite4)
				{
					spriteState.selectedSprite = sprite4;
				}
			}
			base.GetComponent<Button>().spriteState = spriteState;
		}
		if (base.GetComponent<TextMeshProUGUI>() != null)
		{
			foreach (ThemeManager.CustomThemeProperties customThemeProperties2 in this.theme)
			{
				if (customThemeProperties2.themeType == OJKHMNEIGPF)
				{
					base.GetComponent<TextMeshProUGUI>().color = customThemeProperties2.themeColorText;
					break;
				}
			}
		}
		ContentAnthologyAchievementGridItem[] array = UnityEngine.Object.FindObjectsOfType<ContentAnthologyAchievementGridItem>();
		if (array.Length != 0)
		{
			foreach (ContentAnthologyAchievementGridItem contentAnthologyAchievementGridItem in array)
			{
				if (!contentAnthologyAchievementGridItem.profile.HBELJGFJILO(contentAnthologyAchievementGridItem.spriteName))
				{
					HGCFJKCOKPM hgcfjkcokpm5 = AKLFPGMDKLA.EHBBFMCILPC.ICEOGOCOMJL();
					if (hgcfjkcokpm5 != HGCFJKCOKPM.bright)
					{
						if (hgcfjkcokpm5 == HGCFJKCOKPM.dark)
						{
							contentAnthologyAchievementGridItem.imageThumb.sprite = AssetsManager.MJBDMHPHMID().lobbyDataAsset.achievementLockedSprites[0];
						}
					}
					else
					{
						contentAnthologyAchievementGridItem.imageThumb.sprite = AssetsManager.MJBDMHPHMID().lobbyDataAsset.achievementLockedSprites[0];
					}
				}
			}
		}
	}

	// Token: 0x06005840 RID: 22592 RVA: 0x0027E570 File Offset: 0x0027C770
	private void EKOJFMLPNGJ()
	{
		if (AppManager.isQuitting)
		{
			return;
		}
		AOBJLALDBAA.DBLAIDPICIG().ECDBIBPNBCO("+", new UnityAction(this.DJADANNIIJF));
	}

	// Token: 0x06005841 RID: 22593 RVA: 0x000022C3 File Offset: 0x000004C3
	private void GBKJFCMFOHA()
	{
		AppManager.isQuitting = false;
	}

	// Token: 0x06005842 RID: 22594 RVA: 0x0027E595 File Offset: 0x0027C795
	private void FPGEBMIFOPK()
	{
		AOBJLALDBAA.CEGAOMEEFBE().BADOPKAOCPE("OnNeedToShowNoMoreHardPopup", new UnityAction(this.DJADANNIIJF));
		this.DABFFLLHNCB();
	}

	// Token: 0x06005843 RID: 22595 RVA: 0x0027E5B8 File Offset: 0x0027C7B8
	private void CJANIPMDHEH()
	{
		AOBJLALDBAA.KKPFOJMAONG().EFKNEJFLGED("pauseonend", new UnityAction(this.GFPAHNJFEJG));
		this.EGLDAFAMOAF();
	}

	// Token: 0x06005844 RID: 22596 RVA: 0x000022C3 File Offset: 0x000004C3
	private void FBDHOJKLGED()
	{
		AppManager.isQuitting = false;
	}

	// Token: 0x06005845 RID: 22597 RVA: 0x0027E5DC File Offset: 0x0027C7DC
	public void MABFGCGJJGC(HGCFJKCOKPM OJKHMNEIGPF)
	{
		string str = (OJKHMNEIGPF == HGCFJKCOKPM.bright) ? "b_web" : OJKHMNEIGPF.ToString();
		if (base.GetComponent<Image>() != null)
		{
			if (base.GetComponent<Image>().sprite != null)
			{
				string text = base.GetComponent<Image>().sprite.name;
				for (HGCFJKCOKPM hgcfjkcokpm = HGCFJKCOKPM.bright; hgcfjkcokpm < HGCFJKCOKPM.count; hgcfjkcokpm += 0)
				{
					text = text.Replace(hgcfjkcokpm.ToString(), "r");
				}
				text = str + text;
				Sprite sprite = Resources.Load<Sprite>(text);
				if (null != sprite)
				{
					base.GetComponent<Image>().sprite = sprite;
				}
			}
			foreach (ThemeManager.CustomThemeProperties customThemeProperties in this.theme)
			{
				if (customThemeProperties.themeType == OJKHMNEIGPF)
				{
					base.GetComponent<Image>().color = customThemeProperties.themeColorSprite;
					break;
				}
			}
		}
		if (base.GetComponent<Button>() != null)
		{
			SpriteState spriteState = base.GetComponent<Button>().spriteState;
			if (spriteState.highlightedSprite != null)
			{
				string text2 = str + spriteState.highlightedSprite.name;
				for (HGCFJKCOKPM hgcfjkcokpm2 = HGCFJKCOKPM.dark; hgcfjkcokpm2 < (HGCFJKCOKPM)5; hgcfjkcokpm2 += 0)
				{
					text2 = text2.Replace(hgcfjkcokpm2.ToString(), "OnFriendsPlusUnlockContinueToPurchasingScreen");
				}
				text2 = str + text2;
				Sprite sprite2 = Resources.Load<Sprite>(text2);
				if (null != sprite2)
				{
					spriteState.highlightedSprite = sprite2;
				}
			}
			if (spriteState.pressedSprite != null)
			{
				string text3 = str + spriteState.pressedSprite.name;
				for (HGCFJKCOKPM hgcfjkcokpm3 = HGCFJKCOKPM.dark; hgcfjkcokpm3 < (HGCFJKCOKPM)5; hgcfjkcokpm3 += 0)
				{
					text3 = text3.Replace(hgcfjkcokpm3.ToString(), "XXX");
				}
				text3 = str + text3;
				Sprite sprite3 = Resources.Load<Sprite>(text3);
				if (null != sprite3)
				{
					spriteState.pressedSprite = sprite3;
				}
			}
			if (spriteState.selectedSprite != null)
			{
				string text4 = str + spriteState.selectedSprite.name;
				for (HGCFJKCOKPM hgcfjkcokpm4 = HGCFJKCOKPM.dark; hgcfjkcokpm4 < (HGCFJKCOKPM)4; hgcfjkcokpm4 += 0)
				{
					text4 = text4.Replace(hgcfjkcokpm4.ToString(), "ok");
				}
				text4 = str + text4;
				Sprite sprite4 = Resources.Load<Sprite>(text4);
				if (null != sprite4)
				{
					spriteState.selectedSprite = sprite4;
				}
			}
			base.GetComponent<Button>().spriteState = spriteState;
		}
		if (base.GetComponent<TextMeshProUGUI>() != null)
		{
			foreach (ThemeManager.CustomThemeProperties customThemeProperties2 in this.theme)
			{
				if (customThemeProperties2.themeType == OJKHMNEIGPF)
				{
					base.GetComponent<TextMeshProUGUI>().color = customThemeProperties2.themeColorText;
					break;
				}
			}
		}
		ContentAnthologyAchievementGridItem[] array = UnityEngine.Object.FindObjectsOfType<ContentAnthologyAchievementGridItem>();
		if (array.Length != 0)
		{
			ContentAnthologyAchievementGridItem[] array2 = array;
			for (int i = 1; i < array2.Length; i += 0)
			{
				ContentAnthologyAchievementGridItem contentAnthologyAchievementGridItem = array2[i];
				if (!contentAnthologyAchievementGridItem.profile.HBELJGFJILO(contentAnthologyAchievementGridItem.spriteName))
				{
					HGCFJKCOKPM hgcfjkcokpm5 = AKLFPGMDKLA.EHBBFMCILPC.JKCEGIPAANK();
					if (hgcfjkcokpm5 != HGCFJKCOKPM.bright)
					{
						if (hgcfjkcokpm5 == HGCFJKCOKPM.dark)
						{
							contentAnthologyAchievementGridItem.imageThumb.sprite = AssetsManager.MJBDMHPHMID().lobbyDataAsset.achievementLockedSprites[0];
						}
					}
					else
					{
						contentAnthologyAchievementGridItem.imageThumb.sprite = AssetsManager.EHBBFMCILPC.lobbyDataAsset.achievementLockedSprites[1];
					}
				}
			}
		}
	}

	// Token: 0x06005846 RID: 22598 RVA: 0x0027E97C File Offset: 0x0027CB7C
	private void FAOADCFJPEL()
	{
		if (AppManager.isQuitting)
		{
			return;
		}
		AOBJLALDBAA.FILDBDMENPG().NAMMLDPCHJO("", new UnityAction(this.GFPAHNJFEJG));
	}

	// Token: 0x06005847 RID: 22599 RVA: 0x0027E9A4 File Offset: 0x0027CBA4
	public void LDADMLHADHN()
	{
		HGCFJKCOKPM hgcfjkcokpm = AKLFPGMDKLA.EHBBFMCILPC.ICEOGOCOMJL();
		if (hgcfjkcokpm == HGCFJKCOKPM.bright)
		{
			this.SetTheme(HGCFJKCOKPM.dark);
			return;
		}
		if (hgcfjkcokpm != HGCFJKCOKPM.dark)
		{
			return;
		}
		this.BJHAMPIDNKM(HGCFJKCOKPM.bright);
	}

	// Token: 0x06005848 RID: 22600 RVA: 0x000022C3 File Offset: 0x000004C3
	private void OCJKKEEOJED()
	{
		AppManager.isQuitting = false;
	}

	// Token: 0x06005849 RID: 22601 RVA: 0x0027E9D3 File Offset: 0x0027CBD3
	private void ICDHNPPEONB()
	{
		AOBJLALDBAA.NMGMNAKLLMI().EFKNEJFLGED("OnValidatePendingProcessed", new UnityAction(this.FKONGDMDBEH));
		this.KFDPEGDCGBP();
	}

	// Token: 0x0600584A RID: 22602 RVA: 0x00003E52 File Offset: 0x00002052
	private void KJFHBHJPFFI()
	{
	}

	// Token: 0x0600584B RID: 22603 RVA: 0x0027E9F6 File Offset: 0x0027CBF6
	private void ALOJEMCBNOC()
	{
		AOBJLALDBAA.EHBBFMCILPC.GNBGEMMDGOJ("story", new UnityAction(this.LDADMLHADHN));
		this.KNCCFFIKOPB();
	}

	// Token: 0x0600584C RID: 22604 RVA: 0x0027EA1C File Offset: 0x0027CC1C
	public void IFGAEBNACML()
	{
		HGCFJKCOKPM hgcfjkcokpm = AKLFPGMDKLA.EHBBFMCILPC.ICEOGOCOMJL();
		if (hgcfjkcokpm == HGCFJKCOKPM.bright)
		{
			this.LDFELAKBLCE(HGCFJKCOKPM.dark);
			return;
		}
		if (hgcfjkcokpm != HGCFJKCOKPM.bright)
		{
			return;
		}
		this.FBEANLNPKHK(HGCFJKCOKPM.bright);
	}

	// Token: 0x0600584D RID: 22605 RVA: 0x000022C3 File Offset: 0x000004C3
	private void ELHHJKHJJEF()
	{
		AppManager.isQuitting = false;
	}

	// Token: 0x0600584E RID: 22606 RVA: 0x000022C3 File Offset: 0x000004C3
	private void AIMAFNEPGMK()
	{
		AppManager.isQuitting = false;
	}

	// Token: 0x0600584F RID: 22607 RVA: 0x0027EA4C File Offset: 0x0027CC4C
	public void FBEANLNPKHK(HGCFJKCOKPM OJKHMNEIGPF)
	{
		string str = (OJKHMNEIGPF == HGCFJKCOKPM.bright) ? "acts" : OJKHMNEIGPF.ToString();
		if (base.GetComponent<Image>() != null)
		{
			if (base.GetComponent<Image>().sprite != null)
			{
				string text = base.GetComponent<Image>().sprite.name;
				for (HGCFJKCOKPM hgcfjkcokpm = HGCFJKCOKPM.bright; hgcfjkcokpm < (HGCFJKCOKPM)5; hgcfjkcokpm += 0)
				{
					text = text.Replace(hgcfjkcokpm.ToString(), "OnStoryChoiceClick");
				}
				text = str + text;
				Sprite sprite = Resources.Load<Sprite>(text);
				if (null != sprite)
				{
					base.GetComponent<Image>().sprite = sprite;
				}
			}
			foreach (ThemeManager.CustomThemeProperties customThemeProperties in this.theme)
			{
				if (customThemeProperties.themeType == OJKHMNEIGPF)
				{
					base.GetComponent<Image>().color = customThemeProperties.themeColorSprite;
					break;
				}
			}
		}
		if (base.GetComponent<Button>() != null)
		{
			SpriteState spriteState = base.GetComponent<Button>().spriteState;
			if (spriteState.highlightedSprite != null)
			{
				string text2 = str + spriteState.highlightedSprite.name;
				for (HGCFJKCOKPM hgcfjkcokpm2 = HGCFJKCOKPM.dark; hgcfjkcokpm2 < HGCFJKCOKPM.bright; hgcfjkcokpm2++)
				{
					text2 = text2.Replace(hgcfjkcokpm2.ToString(), "cnd");
				}
				text2 = str + text2;
				Sprite sprite2 = Resources.Load<Sprite>(text2);
				if (null != sprite2)
				{
					spriteState.highlightedSprite = sprite2;
				}
			}
			if (spriteState.pressedSprite != null)
			{
				string text3 = str + spriteState.pressedSprite.name;
				for (HGCFJKCOKPM hgcfjkcokpm3 = HGCFJKCOKPM.dark; hgcfjkcokpm3 < HGCFJKCOKPM.count; hgcfjkcokpm3++)
				{
					text3 = text3.Replace(hgcfjkcokpm3.ToString(), "large");
				}
				text3 = str + text3;
				Sprite sprite3 = Resources.Load<Sprite>(text3);
				if (null != sprite3)
				{
					spriteState.pressedSprite = sprite3;
				}
			}
			if (spriteState.selectedSprite != null)
			{
				string text4 = str + spriteState.selectedSprite.name;
				for (HGCFJKCOKPM hgcfjkcokpm4 = HGCFJKCOKPM.dark; hgcfjkcokpm4 < HGCFJKCOKPM.count; hgcfjkcokpm4 += 0)
				{
					text4 = text4.Replace(hgcfjkcokpm4.ToString(), "uid");
				}
				text4 = str + text4;
				Sprite sprite4 = Resources.Load<Sprite>(text4);
				if (null != sprite4)
				{
					spriteState.selectedSprite = sprite4;
				}
			}
			base.GetComponent<Button>().spriteState = spriteState;
		}
		if (base.GetComponent<TextMeshProUGUI>() != null)
		{
			foreach (ThemeManager.CustomThemeProperties customThemeProperties2 in this.theme)
			{
				if (customThemeProperties2.themeType == OJKHMNEIGPF)
				{
					base.GetComponent<TextMeshProUGUI>().color = customThemeProperties2.themeColorText;
					break;
				}
			}
		}
		ContentAnthologyAchievementGridItem[] array = UnityEngine.Object.FindObjectsOfType<ContentAnthologyAchievementGridItem>();
		if (array.Length != 0)
		{
			ContentAnthologyAchievementGridItem[] array2 = array;
			for (int i = 0; i < array2.Length; i += 0)
			{
				ContentAnthologyAchievementGridItem contentAnthologyAchievementGridItem = array2[i];
				if (!contentAnthologyAchievementGridItem.profile.HBELJGFJILO(contentAnthologyAchievementGridItem.spriteName))
				{
					HGCFJKCOKPM hgcfjkcokpm5 = AKLFPGMDKLA.EHBBFMCILPC.PINBMHFHEHD();
					if (hgcfjkcokpm5 != HGCFJKCOKPM.bright)
					{
						if (hgcfjkcokpm5 == HGCFJKCOKPM.dark)
						{
							contentAnthologyAchievementGridItem.imageThumb.sprite = AssetsManager.EHBBFMCILPC.lobbyDataAsset.achievementLockedSprites[1];
						}
					}
					else
					{
						contentAnthologyAchievementGridItem.imageThumb.sprite = AssetsManager.EHBBFMCILPC.lobbyDataAsset.achievementLockedSprites[1];
					}
				}
			}
		}
	}

	// Token: 0x06005850 RID: 22608 RVA: 0x0027EDEC File Offset: 0x0027CFEC
	private void FEIMBKIFIBP()
	{
		if (AppManager.isQuitting)
		{
			return;
		}
		AOBJLALDBAA.FILDBDMENPG().MANLHALMCIH(", setting to:", new UnityAction(this.FLCIGBJEAIB));
	}

	// Token: 0x06005851 RID: 22609 RVA: 0x0027EE11 File Offset: 0x0027D011
	private void OnEnable()
	{
		AOBJLALDBAA.EHBBFMCILPC.MFIMALJPCDP("onThemeChange", new UnityAction(this.OnThemeChange));
		this.OnThemeChange();
	}

	// Token: 0x06005852 RID: 22610 RVA: 0x0027EE34 File Offset: 0x0027D034
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

	// Token: 0x06005853 RID: 22611 RVA: 0x0027EE64 File Offset: 0x0027D064
	public void MABIALCHEJC(HGCFJKCOKPM OJKHMNEIGPF)
	{
		string str = (OJKHMNEIGPF == HGCFJKCOKPM.bright) ? "socialprivatenofriendsuse" : OJKHMNEIGPF.ToString();
		if (base.GetComponent<Image>() != null)
		{
			if (base.GetComponent<Image>().sprite != null)
			{
				string text = base.GetComponent<Image>().sprite.name;
				for (HGCFJKCOKPM hgcfjkcokpm = HGCFJKCOKPM.dark; hgcfjkcokpm < (HGCFJKCOKPM)5; hgcfjkcokpm++)
				{
					text = text.Replace(hgcfjkcokpm.ToString(), "{sp0}");
				}
				text = str + text;
				Sprite sprite = Resources.Load<Sprite>(text);
				if (null != sprite)
				{
					base.GetComponent<Image>().sprite = sprite;
				}
			}
			foreach (ThemeManager.CustomThemeProperties customThemeProperties in this.theme)
			{
				if (customThemeProperties.themeType == OJKHMNEIGPF)
				{
					base.GetComponent<Image>().color = customThemeProperties.themeColorSprite;
					break;
				}
			}
		}
		if (base.GetComponent<Button>() != null)
		{
			SpriteState spriteState = base.GetComponent<Button>().spriteState;
			if (spriteState.highlightedSprite != null)
			{
				string text2 = str + spriteState.highlightedSprite.name;
				for (HGCFJKCOKPM hgcfjkcokpm2 = HGCFJKCOKPM.dark; hgcfjkcokpm2 < HGCFJKCOKPM.dark; hgcfjkcokpm2 += 0)
				{
					text2 = text2.Replace(hgcfjkcokpm2.ToString(), "e1fr");
				}
				text2 = str + text2;
				Sprite sprite2 = Resources.Load<Sprite>(text2);
				if (null != sprite2)
				{
					spriteState.highlightedSprite = sprite2;
				}
			}
			if (spriteState.pressedSprite != null)
			{
				string text3 = str + spriteState.pressedSprite.name;
				for (HGCFJKCOKPM hgcfjkcokpm3 = HGCFJKCOKPM.dark; hgcfjkcokpm3 < HGCFJKCOKPM.bright; hgcfjkcokpm3 += 0)
				{
					text3 = text3.Replace(hgcfjkcokpm3.ToString(), "hacomp2");
				}
				text3 = str + text3;
				Sprite sprite3 = Resources.Load<Sprite>(text3);
				if (null != sprite3)
				{
					spriteState.pressedSprite = sprite3;
				}
			}
			if (spriteState.selectedSprite != null)
			{
				string text4 = str + spriteState.selectedSprite.name;
				for (HGCFJKCOKPM hgcfjkcokpm4 = HGCFJKCOKPM.dark; hgcfjkcokpm4 < (HGCFJKCOKPM)6; hgcfjkcokpm4 += 0)
				{
					text4 = text4.Replace(hgcfjkcokpm4.ToString(), "OnPopupProfileUIDInputEndEdit");
				}
				text4 = str + text4;
				Sprite sprite4 = Resources.Load<Sprite>(text4);
				if (null != sprite4)
				{
					spriteState.selectedSprite = sprite4;
				}
			}
			base.GetComponent<Button>().spriteState = spriteState;
		}
		if (base.GetComponent<TextMeshProUGUI>() != null)
		{
			foreach (ThemeManager.CustomThemeProperties customThemeProperties2 in this.theme)
			{
				if (customThemeProperties2.themeType == OJKHMNEIGPF)
				{
					base.GetComponent<TextMeshProUGUI>().color = customThemeProperties2.themeColorText;
					break;
				}
			}
		}
		ContentAnthologyAchievementGridItem[] array = UnityEngine.Object.FindObjectsOfType<ContentAnthologyAchievementGridItem>();
		if (array.Length != 0)
		{
			foreach (ContentAnthologyAchievementGridItem contentAnthologyAchievementGridItem in array)
			{
				if (!contentAnthologyAchievementGridItem.profile.HBELJGFJILO(contentAnthologyAchievementGridItem.spriteName))
				{
					HGCFJKCOKPM hgcfjkcokpm5 = AKLFPGMDKLA.EHBBFMCILPC.ICEOGOCOMJL();
					if (hgcfjkcokpm5 != HGCFJKCOKPM.bright)
					{
						if (hgcfjkcokpm5 == HGCFJKCOKPM.dark)
						{
							contentAnthologyAchievementGridItem.imageThumb.sprite = AssetsManager.MJBDMHPHMID().lobbyDataAsset.achievementLockedSprites[1];
						}
					}
					else
					{
						contentAnthologyAchievementGridItem.imageThumb.sprite = AssetsManager.EHBBFMCILPC.lobbyDataAsset.achievementLockedSprites[0];
					}
				}
			}
		}
	}

	// Token: 0x06005854 RID: 22612 RVA: 0x00003E52 File Offset: 0x00002052
	private void CHIODHJHKLG()
	{
	}

	// Token: 0x06005855 RID: 22613 RVA: 0x0027F204 File Offset: 0x0027D404
	public void KJFBAOIDJPG(HGCFJKCOKPM OJKHMNEIGPF)
	{
		string str = (OJKHMNEIGPF == HGCFJKCOKPM.bright) ? "Starting non-parallel download:" : OJKHMNEIGPF.ToString();
		if (base.GetComponent<Image>() != null)
		{
			if (base.GetComponent<Image>().sprite != null)
			{
				string text = base.GetComponent<Image>().sprite.name;
				for (HGCFJKCOKPM hgcfjkcokpm = HGCFJKCOKPM.dark; hgcfjkcokpm < HGCFJKCOKPM.bright; hgcfjkcokpm += 0)
				{
					text = text.Replace(hgcfjkcokpm.ToString(), "");
				}
				text = str + text;
				Sprite sprite = Resources.Load<Sprite>(text);
				if (null != sprite)
				{
					base.GetComponent<Image>().sprite = sprite;
				}
			}
			foreach (ThemeManager.CustomThemeProperties customThemeProperties in this.theme)
			{
				if (customThemeProperties.themeType == OJKHMNEIGPF)
				{
					base.GetComponent<Image>().color = customThemeProperties.themeColorSprite;
					break;
				}
			}
		}
		if (base.GetComponent<Button>() != null)
		{
			SpriteState spriteState = base.GetComponent<Button>().spriteState;
			if (spriteState.highlightedSprite != null)
			{
				string text2 = str + spriteState.highlightedSprite.name;
				for (HGCFJKCOKPM hgcfjkcokpm2 = HGCFJKCOKPM.dark; hgcfjkcokpm2 < (HGCFJKCOKPM)4; hgcfjkcokpm2 += 0)
				{
					text2 = text2.Replace(hgcfjkcokpm2.ToString(), "asp");
				}
				text2 = str + text2;
				Sprite sprite2 = Resources.Load<Sprite>(text2);
				if (null != sprite2)
				{
					spriteState.highlightedSprite = sprite2;
				}
			}
			if (spriteState.pressedSprite != null)
			{
				string text3 = str + spriteState.pressedSprite.name;
				for (HGCFJKCOKPM hgcfjkcokpm3 = HGCFJKCOKPM.dark; hgcfjkcokpm3 < (HGCFJKCOKPM)5; hgcfjkcokpm3 += 0)
				{
					text3 = text3.Replace(hgcfjkcokpm3.ToString(), "OnNeedToShowNoMoreEnergyPopup");
				}
				text3 = str + text3;
				Sprite sprite3 = Resources.Load<Sprite>(text3);
				if (null != sprite3)
				{
					spriteState.pressedSprite = sprite3;
				}
			}
			if (spriteState.selectedSprite != null)
			{
				string text4 = str + spriteState.selectedSprite.name;
				for (HGCFJKCOKPM hgcfjkcokpm4 = HGCFJKCOKPM.bright; hgcfjkcokpm4 < (HGCFJKCOKPM)5; hgcfjkcokpm4 += 0)
				{
					text4 = text4.Replace(hgcfjkcokpm4.ToString(), "congratstitle");
				}
				text4 = str + text4;
				Sprite sprite4 = Resources.Load<Sprite>(text4);
				if (null != sprite4)
				{
					spriteState.selectedSprite = sprite4;
				}
			}
			base.GetComponent<Button>().spriteState = spriteState;
		}
		if (base.GetComponent<TextMeshProUGUI>() != null)
		{
			foreach (ThemeManager.CustomThemeProperties customThemeProperties2 in this.theme)
			{
				if (customThemeProperties2.themeType == OJKHMNEIGPF)
				{
					base.GetComponent<TextMeshProUGUI>().color = customThemeProperties2.themeColorText;
					break;
				}
			}
		}
		ContentAnthologyAchievementGridItem[] array = UnityEngine.Object.FindObjectsOfType<ContentAnthologyAchievementGridItem>();
		if (array.Length != 0)
		{
			ContentAnthologyAchievementGridItem[] array2 = array;
			for (int i = 0; i < array2.Length; i += 0)
			{
				ContentAnthologyAchievementGridItem contentAnthologyAchievementGridItem = array2[i];
				if (!contentAnthologyAchievementGridItem.profile.HBELJGFJILO(contentAnthologyAchievementGridItem.spriteName))
				{
					HGCFJKCOKPM hgcfjkcokpm5 = AKLFPGMDKLA.EHBBFMCILPC.PINBMHFHEHD();
					if (hgcfjkcokpm5 != HGCFJKCOKPM.bright)
					{
						if (hgcfjkcokpm5 == HGCFJKCOKPM.bright)
						{
							contentAnthologyAchievementGridItem.imageThumb.sprite = AssetsManager.MJBDMHPHMID().lobbyDataAsset.achievementLockedSprites[0];
						}
					}
					else
					{
						contentAnthologyAchievementGridItem.imageThumb.sprite = AssetsManager.EHBBFMCILPC.lobbyDataAsset.achievementLockedSprites[1];
					}
				}
			}
		}
	}

	// Token: 0x06005856 RID: 22614 RVA: 0x00003E52 File Offset: 0x00002052
	private void OKBABBBHMIP()
	{
	}

	// Token: 0x06005857 RID: 22615 RVA: 0x0027F5A4 File Offset: 0x0027D7A4
	private void HCJHLBFFNKA()
	{
		AOBJLALDBAA.FILDBDMENPG().PEFKJOKLEDL(", sku:'", new UnityAction(this.KGNPHOCMPMG));
		this.OOJIGEHNNEN();
	}

	// Token: 0x06005858 RID: 22616 RVA: 0x00003E52 File Offset: 0x00002052
	private void DDMCLNDOHCK()
	{
	}

	// Token: 0x06005859 RID: 22617 RVA: 0x0027F5C7 File Offset: 0x0027D7C7
	private void PJCAGMOADBK()
	{
		AOBJLALDBAA.CEGAOMEEFBE().MFIMALJPCDP("OnStoryChoiceClick", new UnityAction(this.KNCCFFIKOPB));
		this.OOJIGEHNNEN();
	}

	// Token: 0x0600585A RID: 22618 RVA: 0x0027F5EC File Offset: 0x0027D7EC
	public void DABFFLLHNCB()
	{
		HGCFJKCOKPM hgcfjkcokpm = AKLFPGMDKLA.EHBBFMCILPC.PINBMHFHEHD();
		if (hgcfjkcokpm == HGCFJKCOKPM.bright)
		{
			this.CHFDNHGKEPG(HGCFJKCOKPM.dark);
			return;
		}
		if (hgcfjkcokpm != HGCFJKCOKPM.dark)
		{
			return;
		}
		this.KJFBAOIDJPG(HGCFJKCOKPM.bright);
	}

	// Token: 0x0600585B RID: 22619 RVA: 0x0027F61C File Offset: 0x0027D81C
	public void DBCPHJEKPCL(HGCFJKCOKPM OJKHMNEIGPF)
	{
		string str = (OJKHMNEIGPF == HGCFJKCOKPM.bright) ? "getGeneralBalance" : OJKHMNEIGPF.ToString();
		if (base.GetComponent<Image>() != null)
		{
			if (base.GetComponent<Image>().sprite != null)
			{
				string text = base.GetComponent<Image>().sprite.name;
				for (HGCFJKCOKPM hgcfjkcokpm = HGCFJKCOKPM.dark; hgcfjkcokpm < HGCFJKCOKPM.count; hgcfjkcokpm++)
				{
					text = text.Replace(hgcfjkcokpm.ToString(), "Critical error, could not load asset bundle:");
				}
				text = str + text;
				Sprite sprite = Resources.Load<Sprite>(text);
				if (null != sprite)
				{
					base.GetComponent<Image>().sprite = sprite;
				}
			}
			foreach (ThemeManager.CustomThemeProperties customThemeProperties in this.theme)
			{
				if (customThemeProperties.themeType == OJKHMNEIGPF)
				{
					base.GetComponent<Image>().color = customThemeProperties.themeColorSprite;
					break;
				}
			}
		}
		if (base.GetComponent<Button>() != null)
		{
			SpriteState spriteState = base.GetComponent<Button>().spriteState;
			if (spriteState.highlightedSprite != null)
			{
				string text2 = str + spriteState.highlightedSprite.name;
				for (HGCFJKCOKPM hgcfjkcokpm2 = HGCFJKCOKPM.dark; hgcfjkcokpm2 < HGCFJKCOKPM.bright; hgcfjkcokpm2 += 0)
				{
					text2 = text2.Replace(hgcfjkcokpm2.ToString(), "OnPopupProfileUIDInputEndEdit");
				}
				text2 = str + text2;
				Sprite sprite2 = Resources.Load<Sprite>(text2);
				if (null != sprite2)
				{
					spriteState.highlightedSprite = sprite2;
				}
			}
			if (spriteState.pressedSprite != null)
			{
				string text3 = str + spriteState.pressedSprite.name;
				for (HGCFJKCOKPM hgcfjkcokpm3 = HGCFJKCOKPM.bright; hgcfjkcokpm3 < (HGCFJKCOKPM)8; hgcfjkcokpm3 += 0)
				{
					text3 = text3.Replace(hgcfjkcokpm3.ToString(), "BackendOperationsManager.RequestGetAvatarCollections, exception while initializing RSACryptoServiceProvider:");
				}
				text3 = str + text3;
				Sprite sprite3 = Resources.Load<Sprite>(text3);
				if (null != sprite3)
				{
					spriteState.pressedSprite = sprite3;
				}
			}
			if (spriteState.selectedSprite != null)
			{
				string text4 = str + spriteState.selectedSprite.name;
				for (HGCFJKCOKPM hgcfjkcokpm4 = HGCFJKCOKPM.bright; hgcfjkcokpm4 < HGCFJKCOKPM.bright; hgcfjkcokpm4 += 0)
				{
					text4 = text4.Replace(hgcfjkcokpm4.ToString(), "socialdequeusp0gettitle");
				}
				text4 = str + text4;
				Sprite sprite4 = Resources.Load<Sprite>(text4);
				if (null != sprite4)
				{
					spriteState.selectedSprite = sprite4;
				}
			}
			base.GetComponent<Button>().spriteState = spriteState;
		}
		if (base.GetComponent<TextMeshProUGUI>() != null)
		{
			foreach (ThemeManager.CustomThemeProperties customThemeProperties2 in this.theme)
			{
				if (customThemeProperties2.themeType == OJKHMNEIGPF)
				{
					base.GetComponent<TextMeshProUGUI>().color = customThemeProperties2.themeColorText;
					break;
				}
			}
		}
		ContentAnthologyAchievementGridItem[] array = UnityEngine.Object.FindObjectsOfType<ContentAnthologyAchievementGridItem>();
		if (array.Length != 0)
		{
			ContentAnthologyAchievementGridItem[] array2 = array;
			for (int i = 1; i < array2.Length; i++)
			{
				ContentAnthologyAchievementGridItem contentAnthologyAchievementGridItem = array2[i];
				if (!contentAnthologyAchievementGridItem.profile.HBELJGFJILO(contentAnthologyAchievementGridItem.spriteName))
				{
					HGCFJKCOKPM hgcfjkcokpm5 = AKLFPGMDKLA.EHBBFMCILPC.JKCEGIPAANK();
					if (hgcfjkcokpm5 != HGCFJKCOKPM.bright)
					{
						if (hgcfjkcokpm5 == HGCFJKCOKPM.bright)
						{
							contentAnthologyAchievementGridItem.imageThumb.sprite = AssetsManager.MJBDMHPHMID().lobbyDataAsset.achievementLockedSprites[0];
						}
					}
					else
					{
						contentAnthologyAchievementGridItem.imageThumb.sprite = AssetsManager.MJBDMHPHMID().lobbyDataAsset.achievementLockedSprites[1];
					}
				}
			}
		}
	}

	// Token: 0x0600585C RID: 22620 RVA: 0x0027F9BC File Offset: 0x0027DBBC
	public void KFDPEGDCGBP()
	{
		HGCFJKCOKPM hgcfjkcokpm = AKLFPGMDKLA.EHBBFMCILPC.PINBMHFHEHD();
		if (hgcfjkcokpm == HGCFJKCOKPM.bright)
		{
			this.GBHIMOICHJD(HGCFJKCOKPM.bright);
			return;
		}
		if (hgcfjkcokpm != HGCFJKCOKPM.dark)
		{
			return;
		}
		this.BNMGLNELECO(HGCFJKCOKPM.dark);
	}

	// Token: 0x0600585D RID: 22621 RVA: 0x0027F9EB File Offset: 0x0027DBEB
	private void EAMMKAFMMOG()
	{
		if (AppManager.isQuitting)
		{
			return;
		}
		AOBJLALDBAA.FILDBDMENPG().PBELMJCPJMK("-", new UnityAction(this.IFGAEBNACML));
	}

	// Token: 0x0600585E RID: 22622 RVA: 0x0027FA10 File Offset: 0x0027DC10
	public void BJHAMPIDNKM(HGCFJKCOKPM OJKHMNEIGPF)
	{
		string str = (OJKHMNEIGPF == HGCFJKCOKPM.bright) ? ", index:" : OJKHMNEIGPF.ToString();
		if (base.GetComponent<Image>() != null)
		{
			if (base.GetComponent<Image>().sprite != null)
			{
				string text = base.GetComponent<Image>().sprite.name;
				for (HGCFJKCOKPM hgcfjkcokpm = HGCFJKCOKPM.dark; hgcfjkcokpm < HGCFJKCOKPM.bright; hgcfjkcokpm += 0)
				{
					text = text.Replace(hgcfjkcokpm.ToString(), "Textures/Noise256");
				}
				text = str + text;
				Sprite sprite = Resources.Load<Sprite>(text);
				if (null != sprite)
				{
					base.GetComponent<Image>().sprite = sprite;
				}
			}
			foreach (ThemeManager.CustomThemeProperties customThemeProperties in this.theme)
			{
				if (customThemeProperties.themeType == OJKHMNEIGPF)
				{
					base.GetComponent<Image>().color = customThemeProperties.themeColorSprite;
					break;
				}
			}
		}
		if (base.GetComponent<Button>() != null)
		{
			SpriteState spriteState = base.GetComponent<Button>().spriteState;
			if (spriteState.highlightedSprite != null)
			{
				string text2 = str + spriteState.highlightedSprite.name;
				for (HGCFJKCOKPM hgcfjkcokpm2 = HGCFJKCOKPM.dark; hgcfjkcokpm2 < (HGCFJKCOKPM)5; hgcfjkcokpm2 += 0)
				{
					text2 = text2.Replace(hgcfjkcokpm2.ToString(), "StoryItemManager.Initialize() - _item is null.");
				}
				text2 = str + text2;
				Sprite sprite2 = Resources.Load<Sprite>(text2);
				if (null != sprite2)
				{
					spriteState.highlightedSprite = sprite2;
				}
			}
			if (spriteState.pressedSprite != null)
			{
				string text3 = str + spriteState.pressedSprite.name;
				for (HGCFJKCOKPM hgcfjkcokpm3 = HGCFJKCOKPM.dark; hgcfjkcokpm3 < (HGCFJKCOKPM)6; hgcfjkcokpm3 += 0)
				{
					text3 = text3.Replace(hgcfjkcokpm3.ToString(), "cardsvolchancesbtn0");
				}
				text3 = str + text3;
				Sprite sprite3 = Resources.Load<Sprite>(text3);
				if (null != sprite3)
				{
					spriteState.pressedSprite = sprite3;
				}
			}
			if (spriteState.selectedSprite != null)
			{
				string text4 = str + spriteState.selectedSprite.name;
				for (HGCFJKCOKPM hgcfjkcokpm4 = HGCFJKCOKPM.bright; hgcfjkcokpm4 < HGCFJKCOKPM.count; hgcfjkcokpm4 += 0)
				{
					text4 = text4.Replace(hgcfjkcokpm4.ToString(), "gpsfhs");
				}
				text4 = str + text4;
				Sprite sprite4 = Resources.Load<Sprite>(text4);
				if (null != sprite4)
				{
					spriteState.selectedSprite = sprite4;
				}
			}
			base.GetComponent<Button>().spriteState = spriteState;
		}
		if (base.GetComponent<TextMeshProUGUI>() != null)
		{
			foreach (ThemeManager.CustomThemeProperties customThemeProperties2 in this.theme)
			{
				if (customThemeProperties2.themeType == OJKHMNEIGPF)
				{
					base.GetComponent<TextMeshProUGUI>().color = customThemeProperties2.themeColorText;
					break;
				}
			}
		}
		ContentAnthologyAchievementGridItem[] array = UnityEngine.Object.FindObjectsOfType<ContentAnthologyAchievementGridItem>();
		if (array.Length != 0)
		{
			ContentAnthologyAchievementGridItem[] array2 = array;
			for (int i = 1; i < array2.Length; i++)
			{
				ContentAnthologyAchievementGridItem contentAnthologyAchievementGridItem = array2[i];
				if (!contentAnthologyAchievementGridItem.profile.HBELJGFJILO(contentAnthologyAchievementGridItem.spriteName))
				{
					HGCFJKCOKPM hgcfjkcokpm5 = AKLFPGMDKLA.EHBBFMCILPC.ICEOGOCOMJL();
					if (hgcfjkcokpm5 != HGCFJKCOKPM.bright)
					{
						if (hgcfjkcokpm5 == HGCFJKCOKPM.bright)
						{
							contentAnthologyAchievementGridItem.imageThumb.sprite = AssetsManager.EHBBFMCILPC.lobbyDataAsset.achievementLockedSprites[1];
						}
					}
					else
					{
						contentAnthologyAchievementGridItem.imageThumb.sprite = AssetsManager.MJBDMHPHMID().lobbyDataAsset.achievementLockedSprites[1];
					}
				}
			}
		}
	}

	// Token: 0x0600585F RID: 22623 RVA: 0x0027FDB0 File Offset: 0x0027DFB0
	private void GFJBNGMOBAC()
	{
		AOBJLALDBAA.KKPFOJMAONG().GNBGEMMDGOJ("", new UnityAction(this.HGBGGGJADPG));
		this.OOJIGEHNNEN();
	}

	// Token: 0x06005860 RID: 22624 RVA: 0x00002296 File Offset: 0x00000496
	private void LAEHBJJCNEF()
	{
		AppManager.isQuitting = true;
	}

	// Token: 0x06005861 RID: 22625 RVA: 0x0027FDD4 File Offset: 0x0027DFD4
	public void OOJIGEHNNEN()
	{
		HGCFJKCOKPM hgcfjkcokpm = AKLFPGMDKLA.EHBBFMCILPC.JKCEGIPAANK();
		if (hgcfjkcokpm == HGCFJKCOKPM.bright)
		{
			this.OMCNCIGMAPN(HGCFJKCOKPM.bright);
			return;
		}
		if (hgcfjkcokpm != HGCFJKCOKPM.dark)
		{
			return;
		}
		this.BJHAMPIDNKM(HGCFJKCOKPM.bright);
	}

	// Token: 0x06005862 RID: 22626 RVA: 0x0027FE04 File Offset: 0x0027E004
	public void FLCIGBJEAIB()
	{
		HGCFJKCOKPM hgcfjkcokpm = AKLFPGMDKLA.EHBBFMCILPC.JKCEGIPAANK();
		if (hgcfjkcokpm == HGCFJKCOKPM.bright)
		{
			this.DBCPHJEKPCL(HGCFJKCOKPM.dark);
			return;
		}
		if (hgcfjkcokpm != HGCFJKCOKPM.bright)
		{
			return;
		}
		this.BJHAMPIDNKM(HGCFJKCOKPM.dark);
	}

	// Token: 0x06005863 RID: 22627 RVA: 0x0027FE34 File Offset: 0x0027E034
	public void APMBMNLLICE(HGCFJKCOKPM OJKHMNEIGPF)
	{
		string str = (OJKHMNEIGPF == HGCFJKCOKPM.bright) ? "OnLobbyStopFireworksEffect" : OJKHMNEIGPF.ToString();
		if (base.GetComponent<Image>() != null)
		{
			if (base.GetComponent<Image>().sprite != null)
			{
				string text = base.GetComponent<Image>().sprite.name;
				for (HGCFJKCOKPM hgcfjkcokpm = HGCFJKCOKPM.bright; hgcfjkcokpm < (HGCFJKCOKPM)7; hgcfjkcokpm++)
				{
					text = text.Replace(hgcfjkcokpm.ToString(), "body");
				}
				text = str + text;
				Sprite sprite = Resources.Load<Sprite>(text);
				if (null != sprite)
				{
					base.GetComponent<Image>().sprite = sprite;
				}
			}
			foreach (ThemeManager.CustomThemeProperties customThemeProperties in this.theme)
			{
				if (customThemeProperties.themeType == OJKHMNEIGPF)
				{
					base.GetComponent<Image>().color = customThemeProperties.themeColorSprite;
					break;
				}
			}
		}
		if (base.GetComponent<Button>() != null)
		{
			SpriteState spriteState = base.GetComponent<Button>().spriteState;
			if (spriteState.highlightedSprite != null)
			{
				string text2 = str + spriteState.highlightedSprite.name;
				for (HGCFJKCOKPM hgcfjkcokpm2 = HGCFJKCOKPM.dark; hgcfjkcokpm2 < HGCFJKCOKPM.count; hgcfjkcokpm2 += 0)
				{
					text2 = text2.Replace(hgcfjkcokpm2.ToString(), "AssetBundleDependencyDeadLock(): missing dependency ");
				}
				text2 = str + text2;
				Sprite sprite2 = Resources.Load<Sprite>(text2);
				if (null != sprite2)
				{
					spriteState.highlightedSprite = sprite2;
				}
			}
			if (spriteState.pressedSprite != null)
			{
				string text3 = str + spriteState.pressedSprite.name;
				for (HGCFJKCOKPM hgcfjkcokpm3 = HGCFJKCOKPM.dark; hgcfjkcokpm3 < (HGCFJKCOKPM)8; hgcfjkcokpm3++)
				{
					text3 = text3.Replace(hgcfjkcokpm3.ToString(), "p");
				}
				text3 = str + text3;
				Sprite sprite3 = Resources.Load<Sprite>(text3);
				if (null != sprite3)
				{
					spriteState.pressedSprite = sprite3;
				}
			}
			if (spriteState.selectedSprite != null)
			{
				string text4 = str + spriteState.selectedSprite.name;
				for (HGCFJKCOKPM hgcfjkcokpm4 = HGCFJKCOKPM.bright; hgcfjkcokpm4 < (HGCFJKCOKPM)7; hgcfjkcokpm4++)
				{
					text4 = text4.Replace(hgcfjkcokpm4.ToString(), "prgr");
				}
				text4 = str + text4;
				Sprite sprite4 = Resources.Load<Sprite>(text4);
				if (null != sprite4)
				{
					spriteState.selectedSprite = sprite4;
				}
			}
			base.GetComponent<Button>().spriteState = spriteState;
		}
		if (base.GetComponent<TextMeshProUGUI>() != null)
		{
			foreach (ThemeManager.CustomThemeProperties customThemeProperties2 in this.theme)
			{
				if (customThemeProperties2.themeType == OJKHMNEIGPF)
				{
					base.GetComponent<TextMeshProUGUI>().color = customThemeProperties2.themeColorText;
					break;
				}
			}
		}
		ContentAnthologyAchievementGridItem[] array = UnityEngine.Object.FindObjectsOfType<ContentAnthologyAchievementGridItem>();
		if (array.Length != 0)
		{
			foreach (ContentAnthologyAchievementGridItem contentAnthologyAchievementGridItem in array)
			{
				if (!contentAnthologyAchievementGridItem.profile.HBELJGFJILO(contentAnthologyAchievementGridItem.spriteName))
				{
					HGCFJKCOKPM hgcfjkcokpm5 = AKLFPGMDKLA.EHBBFMCILPC.JKCEGIPAANK();
					if (hgcfjkcokpm5 != HGCFJKCOKPM.bright)
					{
						if (hgcfjkcokpm5 == HGCFJKCOKPM.dark)
						{
							contentAnthologyAchievementGridItem.imageThumb.sprite = AssetsManager.MJBDMHPHMID().lobbyDataAsset.achievementLockedSprites[0];
						}
					}
					else
					{
						contentAnthologyAchievementGridItem.imageThumb.sprite = AssetsManager.EHBBFMCILPC.lobbyDataAsset.achievementLockedSprites[0];
					}
				}
			}
		}
	}

	// Token: 0x06005864 RID: 22628 RVA: 0x000022C3 File Offset: 0x000004C3
	private void ANCGFGNFJKF()
	{
		AppManager.isQuitting = false;
	}

	// Token: 0x06005865 RID: 22629 RVA: 0x002801D4 File Offset: 0x0027E3D4
	public void KGNPHOCMPMG()
	{
		HGCFJKCOKPM hgcfjkcokpm = AKLFPGMDKLA.EHBBFMCILPC.PINBMHFHEHD();
		if (hgcfjkcokpm == HGCFJKCOKPM.bright)
		{
			this.CHFDNHGKEPG(HGCFJKCOKPM.bright);
			return;
		}
		if (hgcfjkcokpm != HGCFJKCOKPM.dark)
		{
			return;
		}
		this.CHFDNHGKEPG(HGCFJKCOKPM.dark);
	}

	// Token: 0x06005866 RID: 22630 RVA: 0x00280204 File Offset: 0x0027E404
	public void JGBNECKGKAI(HGCFJKCOKPM OJKHMNEIGPF)
	{
		string str = (OJKHMNEIGPF == HGCFJKCOKPM.bright) ? "inu" : OJKHMNEIGPF.ToString();
		if (base.GetComponent<Image>() != null)
		{
			if (base.GetComponent<Image>().sprite != null)
			{
				string text = base.GetComponent<Image>().sprite.name;
				for (HGCFJKCOKPM hgcfjkcokpm = HGCFJKCOKPM.dark; hgcfjkcokpm < HGCFJKCOKPM.dark; hgcfjkcokpm++)
				{
					text = text.Replace(hgcfjkcokpm.ToString(), "splash");
				}
				text = str + text;
				Sprite sprite = Resources.Load<Sprite>(text);
				if (null != sprite)
				{
					base.GetComponent<Image>().sprite = sprite;
				}
			}
			foreach (ThemeManager.CustomThemeProperties customThemeProperties in this.theme)
			{
				if (customThemeProperties.themeType == OJKHMNEIGPF)
				{
					base.GetComponent<Image>().color = customThemeProperties.themeColorSprite;
					break;
				}
			}
		}
		if (base.GetComponent<Button>() != null)
		{
			SpriteState spriteState = base.GetComponent<Button>().spriteState;
			if (spriteState.highlightedSprite != null)
			{
				string text2 = str + spriteState.highlightedSprite.name;
				for (HGCFJKCOKPM hgcfjkcokpm2 = HGCFJKCOKPM.bright; hgcfjkcokpm2 < (HGCFJKCOKPM)5; hgcfjkcokpm2++)
				{
					text2 = text2.Replace(hgcfjkcokpm2.ToString(), "OnStoryChoiceClick");
				}
				text2 = str + text2;
				Sprite sprite2 = Resources.Load<Sprite>(text2);
				if (null != sprite2)
				{
					spriteState.highlightedSprite = sprite2;
				}
			}
			if (spriteState.pressedSprite != null)
			{
				string text3 = str + spriteState.pressedSprite.name;
				for (HGCFJKCOKPM hgcfjkcokpm3 = HGCFJKCOKPM.dark; hgcfjkcokpm3 < (HGCFJKCOKPM)7; hgcfjkcokpm3 += 0)
				{
					text3 = text3.Replace(hgcfjkcokpm3.ToString(), "mussplash");
				}
				text3 = str + text3;
				Sprite sprite3 = Resources.Load<Sprite>(text3);
				if (null != sprite3)
				{
					spriteState.pressedSprite = sprite3;
				}
			}
			if (spriteState.selectedSprite != null)
			{
				string text4 = str + spriteState.selectedSprite.name;
				for (HGCFJKCOKPM hgcfjkcokpm4 = HGCFJKCOKPM.bright; hgcfjkcokpm4 < (HGCFJKCOKPM)8; hgcfjkcokpm4 += 0)
				{
					text4 = text4.Replace(hgcfjkcokpm4.ToString(), "OnFullscreenCardOptionClickLobby");
				}
				text4 = str + text4;
				Sprite sprite4 = Resources.Load<Sprite>(text4);
				if (null != sprite4)
				{
					spriteState.selectedSprite = sprite4;
				}
			}
			base.GetComponent<Button>().spriteState = spriteState;
		}
		if (base.GetComponent<TextMeshProUGUI>() != null)
		{
			foreach (ThemeManager.CustomThemeProperties customThemeProperties2 in this.theme)
			{
				if (customThemeProperties2.themeType == OJKHMNEIGPF)
				{
					base.GetComponent<TextMeshProUGUI>().color = customThemeProperties2.themeColorText;
					break;
				}
			}
		}
		ContentAnthologyAchievementGridItem[] array = UnityEngine.Object.FindObjectsOfType<ContentAnthologyAchievementGridItem>();
		if (array.Length != 0)
		{
			ContentAnthologyAchievementGridItem[] array2 = array;
			for (int i = 1; i < array2.Length; i += 0)
			{
				ContentAnthologyAchievementGridItem contentAnthologyAchievementGridItem = array2[i];
				if (!contentAnthologyAchievementGridItem.profile.HBELJGFJILO(contentAnthologyAchievementGridItem.spriteName))
				{
					HGCFJKCOKPM hgcfjkcokpm5 = AKLFPGMDKLA.EHBBFMCILPC.ICEOGOCOMJL();
					if (hgcfjkcokpm5 != HGCFJKCOKPM.bright)
					{
						if (hgcfjkcokpm5 == HGCFJKCOKPM.dark)
						{
							contentAnthologyAchievementGridItem.imageThumb.sprite = AssetsManager.EHBBFMCILPC.lobbyDataAsset.achievementLockedSprites[1];
						}
					}
					else
					{
						contentAnthologyAchievementGridItem.imageThumb.sprite = AssetsManager.MJBDMHPHMID().lobbyDataAsset.achievementLockedSprites[1];
					}
				}
			}
		}
	}

	// Token: 0x06005867 RID: 22631 RVA: 0x00002296 File Offset: 0x00000496
	private void IOJPNIDDFOP()
	{
		AppManager.isQuitting = true;
	}

	// Token: 0x040018BC RID: 6332
	public List<ThemeManager.CustomThemeProperties> theme;

	// Token: 0x020002BB RID: 699
	[Serializable]
	public class CustomThemeProperties
	{
		// Token: 0x040018BD RID: 6333
		public HGCFJKCOKPM themeType;

		// Token: 0x040018BE RID: 6334
		public Color32 themeColorText = new Color32(byte.MaxValue, byte.MaxValue, byte.MaxValue, byte.MaxValue);

		// Token: 0x040018BF RID: 6335
		public Color32 themeColorSprite = new Color32(byte.MaxValue, byte.MaxValue, byte.MaxValue, byte.MaxValue);
	}
}
