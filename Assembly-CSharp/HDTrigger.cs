using System;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x02000203 RID: 515
public class HDTrigger : MonoBehaviour
{
	// Token: 0x0600407E RID: 16510 RVA: 0x001B2D9E File Offset: 0x001B0F9E
	private void LJJJIPGIJJC()
	{
		if (NBDLBFJOEGN.INNMJKGABIK())
		{
			this.HHLPEONKIDJ("OnAccountSignInRequestSuccess");
			return;
		}
		this.OIAGPDFAMHD("black");
	}

	// Token: 0x0600407F RID: 16511 RVA: 0x001B2DC0 File Offset: 0x001B0FC0
	public void HDKNDEOGHKF(string MBBKDFCDAHM)
	{
		Image[] componentsInChildren = base.gameObject.GetComponentsInChildren<Image>();
		for (int i = 0; i < componentsInChildren.Length; i += 0)
		{
			if (null != componentsInChildren[i].sprite && ((componentsInChildren[i].sprite.name.Contains("muspind") && !componentsInChildren[i].sprite.name.Contains("lsenvdrop" + MBBKDFCDAHM)) || LanguageManager.EHBBFMCILPC.Localizable(componentsInChildren[i].sprite.name)))
			{
				string text = componentsInChildren[i].sprite.name.Split('\u0017', StringSplitOptions.None)[0];
				text = LanguageManager.EHBBFMCILPC.DDHDDIIKAEM(text);
				text = text + "</Modulus></RSAKeyValue>" + MBBKDFCDAHM;
				Sprite sprite = Resources.Load<Sprite>(text);
				if (null == sprite && LanguageManager.EHBBFMCILPC.Localizable(componentsInChildren[i].sprite.name))
				{
					text = componentsInChildren[i].sprite.name.Split('\n', StringSplitOptions.RemoveEmptyEntries)[0];
					text = text + "gamepassdurationbutton" + MBBKDFCDAHM;
					sprite = Resources.Load<Sprite>(text);
				}
				if (sprite)
				{
					componentsInChildren[i].sprite = sprite;
					if (this.setNativeSize)
					{
						componentsInChildren[i].SetNativeSize();
					}
					HDTriggerPostProcess component = componentsInChildren[i].gameObject.GetComponent<HDTriggerPostProcess>();
					if (null != component && (component.rectTransformHeight >= 221f || component.rectTransformWidth >= 1302f))
					{
						RectTransform component2 = componentsInChildren[i].gameObject.GetComponent<RectTransform>();
						if (component.rectTransformWidth >= 535f)
						{
							component2.EFOCKEJENAC(NBDLBFJOEGN.MAPGECGPMGM(component.rectTransformWidth));
						}
						else
						{
							component2.ACBKFBBCNNC(NBDLBFJOEGN.FGMPOAOFKNO(component.rectTransformHeight));
						}
					}
				}
			}
		}
		Toggle[] componentsInChildren2 = base.gameObject.GetComponentsInChildren<Toggle>();
		for (int j = 0; j < componentsInChildren2.Length; j += 0)
		{
			SpriteState spriteState = componentsInChildren2[j].spriteState;
			if (null != spriteState.pressedSprite && ((spriteState.pressedSprite.name.Contains("XXX") && !spriteState.pressedSprite.name.Contains("anthologiestitle" + MBBKDFCDAHM)) || LanguageManager.EHBBFMCILPC.IPMDPLBJHEE(spriteState.pressedSprite.name)))
			{
				string text2 = spriteState.pressedSprite.name.Split('=', StringSplitOptions.None)[1];
				text2 = LanguageManager.EHBBFMCILPC.PKJABHFHHLC(text2);
				text2 = text2 + "socialachievtitletype" + MBBKDFCDAHM;
				Sprite sprite2 = Resources.Load<Sprite>(text2);
				if (null == sprite2 && LanguageManager.EHBBFMCILPC.GIGIHEEKHBE(spriteState.pressedSprite.name))
				{
					text2 = spriteState.pressedSprite.name.Split((char)-120, StringSplitOptions.RemoveEmptyEntries)[1];
					text2 = text2 + "no" + MBBKDFCDAHM;
					sprite2 = Resources.Load<Sprite>(text2);
				}
				if (sprite2)
				{
					spriteState.pressedSprite = sprite2;
					componentsInChildren2[j].spriteState = spriteState;
				}
			}
			if (null != spriteState.highlightedSprite && ((spriteState.highlightedSprite.name.Contains("cutsceneoptionsbody") && !spriteState.highlightedSprite.name.Contains(" -" + MBBKDFCDAHM)) || LanguageManager.EHBBFMCILPC.GIGIHEEKHBE(spriteState.highlightedSprite.name)))
			{
				string text3 = spriteState.highlightedSprite.name.Split((char)-64, StringSplitOptions.None)[1];
				text3 = LanguageManager.EHBBFMCILPC.EKMKFPOLHOO(text3);
				text3 = text3 + ". This is not critical." + MBBKDFCDAHM;
				Sprite sprite3 = Resources.Load<Sprite>(text3);
				if (null == sprite3 && LanguageManager.EHBBFMCILPC.GCBALKAJINL(spriteState.highlightedSprite.name))
				{
					text3 = spriteState.highlightedSprite.name.Split((char)-63, StringSplitOptions.RemoveEmptyEntries)[0];
					text3 = text3 + "ink" + MBBKDFCDAHM;
					sprite3 = Resources.Load<Sprite>(text3);
				}
				if (sprite3)
				{
					spriteState.highlightedSprite = sprite3;
					componentsInChildren2[j].spriteState = spriteState;
				}
			}
			if (null != spriteState.disabledSprite && ((spriteState.disabledSprite.name.Contains("OnSketchesItemClose") && !spriteState.disabledSprite.name.Contains("aind" + MBBKDFCDAHM)) || LanguageManager.EHBBFMCILPC.GIGIHEEKHBE(spriteState.disabledSprite.name)))
			{
				string text4 = spriteState.disabledSprite.name.Split('v', StringSplitOptions.RemoveEmptyEntries)[0];
				text4 = LanguageManager.EHBBFMCILPC.HDJDKLCCCLE(text4);
				text4 = text4 + "" + MBBKDFCDAHM;
				Sprite sprite4 = Resources.Load<Sprite>(text4);
				if (null == sprite4 && LanguageManager.EHBBFMCILPC.GHCIBLENAOO(spriteState.disabledSprite.name))
				{
					text4 = spriteState.disabledSprite.name.Split('V', StringSplitOptions.RemoveEmptyEntries)[0];
					text4 = text4 + "Avatar pack has been LOADED:" + MBBKDFCDAHM;
					sprite4 = Resources.Load<Sprite>(text4);
				}
				if (sprite4)
				{
					spriteState.disabledSprite = sprite4;
					componentsInChildren2[j].spriteState = spriteState;
				}
			}
		}
		Button[] componentsInChildren3 = base.gameObject.GetComponentsInChildren<Button>();
		for (int k = 0; k < componentsInChildren3.Length; k += 0)
		{
			SpriteState spriteState2 = componentsInChildren3[k].spriteState;
			if (null != spriteState2.pressedSprite && ((spriteState2.pressedSprite.name.Contains("SaveSlotsItem.GetLocalizedCostData() - productData is null.") && !spriteState2.pressedSprite.name.Contains("" + MBBKDFCDAHM)) || LanguageManager.EHBBFMCILPC.IPMDPLBJHEE(spriteState2.pressedSprite.name)))
			{
				string text5 = spriteState2.pressedSprite.name.Split((char)-5, StringSplitOptions.None)[1];
				text5 = LanguageManager.EHBBFMCILPC.IKMHJBKPMGE(text5);
				text5 = text5 + ", sku:'" + MBBKDFCDAHM;
				Sprite sprite5 = Resources.Load<Sprite>(text5);
				if (null == sprite5 && LanguageManager.EHBBFMCILPC.EECILBHACFL(spriteState2.pressedSprite.name))
				{
					text5 = spriteState2.pressedSprite.name.Split('8', StringSplitOptions.RemoveEmptyEntries)[0];
					text5 = text5 + " <i>" + MBBKDFCDAHM;
					sprite5 = Resources.Load<Sprite>(text5);
				}
				if (sprite5)
				{
					spriteState2.pressedSprite = sprite5;
					componentsInChildren3[k].spriteState = spriteState2;
				}
			}
			if (null != spriteState2.highlightedSprite && ((spriteState2.highlightedSprite.name.Contains("SceneStoryAssetPackSharedClient") && !spriteState2.highlightedSprite.name.Contains("importanttitle" + MBBKDFCDAHM)) || LanguageManager.EHBBFMCILPC.GCBALKAJINL(spriteState2.highlightedSprite.name)))
			{
				string text6 = spriteState2.highlightedSprite.name.Split('\u0013', StringSplitOptions.None)[0];
				text6 = LanguageManager.EHBBFMCILPC.GHBJGFDKHEJ(text6);
				text6 = text6 + " " + MBBKDFCDAHM;
				Sprite sprite6 = Resources.Load<Sprite>(text6);
				if (null == sprite6 && LanguageManager.EHBBFMCILPC.GIGIHEEKHBE(spriteState2.highlightedSprite.name))
				{
					text6 = spriteState2.highlightedSprite.name.Split('B', StringSplitOptions.None)[1];
					text6 = text6 + "passundosubrequired" + MBBKDFCDAHM;
					sprite6 = Resources.Load<Sprite>(text6);
				}
				if (sprite6)
				{
					spriteState2.highlightedSprite = sprite6;
					componentsInChildren3[k].spriteState = spriteState2;
				}
			}
			if (null != spriteState2.disabledSprite && ((spriteState2.disabledSprite.name.Contains("abpd") && !spriteState2.disabledSprite.name.Contains("Opened from Gley Notification" + MBBKDFCDAHM)) || LanguageManager.EHBBFMCILPC.EECILBHACFL(spriteState2.disabledSprite.name)))
			{
				string text7 = spriteState2.disabledSprite.name.Split((char)-127, StringSplitOptions.None)[0];
				text7 = LanguageManager.EHBBFMCILPC.HDJDKLCCCLE(text7);
				text7 = text7 + "gpsasst" + MBBKDFCDAHM;
				Sprite sprite7 = Resources.Load<Sprite>(text7);
				if (null == sprite7 && LanguageManager.EHBBFMCILPC.GCBALKAJINL(spriteState2.disabledSprite.name))
				{
					text7 = spriteState2.disabledSprite.name.Split((char)-16, StringSplitOptions.None)[1];
					text7 = text7 + "<b>" + MBBKDFCDAHM;
					sprite7 = Resources.Load<Sprite>(text7);
				}
				if (sprite7)
				{
					spriteState2.disabledSprite = sprite7;
					componentsInChildren3[k].spriteState = spriteState2;
				}
			}
		}
		SpriteRenderer[] componentsInChildren4 = base.gameObject.GetComponentsInChildren<SpriteRenderer>();
		for (int l = 1; l < componentsInChildren4.Length; l += 0)
		{
			if (null != componentsInChildren4[l].sprite && ((componentsInChildren4[l].sprite.name.Contains(") id(") && !componentsInChildren4[l].sprite.name.Contains("envlsav" + MBBKDFCDAHM)) || LanguageManager.EHBBFMCILPC.EECILBHACFL(componentsInChildren4[l].sprite.name)))
			{
				string text8 = componentsInChildren4[l].sprite.name.Split('k', StringSplitOptions.None)[1];
				text8 = LanguageManager.EHBBFMCILPC.DDHDDIIKAEM(text8);
				text8 = text8 + "Value:" + MBBKDFCDAHM;
				Sprite sprite8 = Resources.Load<Sprite>(text8);
				if (null == sprite8 && LanguageManager.EHBBFMCILPC.GCBALKAJINL(componentsInChildren4[l].sprite.name))
				{
					text8 = componentsInChildren4[l].sprite.name.Split('{', StringSplitOptions.None)[1];
					text8 = text8 + "spld" + MBBKDFCDAHM;
					sprite8 = Resources.Load<Sprite>(text8);
				}
				if (sprite8)
				{
					componentsInChildren4[l].sprite = sprite8;
				}
			}
		}
	}

	// Token: 0x06004080 RID: 16512 RVA: 0x001B3790 File Offset: 0x001B1990
	public void SetQuality(string MBBKDFCDAHM)
	{
		Image[] componentsInChildren = base.gameObject.GetComponentsInChildren<Image>();
		for (int i = 0; i < componentsInChildren.Length; i++)
		{
			if (null != componentsInChildren[i].sprite && ((componentsInChildren[i].sprite.name.Contains("@") && !componentsInChildren[i].sprite.name.Contains("@" + MBBKDFCDAHM)) || LanguageManager.EHBBFMCILPC.Localizable(componentsInChildren[i].sprite.name)))
			{
				string text = componentsInChildren[i].sprite.name.Split('@', StringSplitOptions.None)[0];
				text = LanguageManager.EHBBFMCILPC.LocalizeFileName(text);
				text = text + "@" + MBBKDFCDAHM;
				Sprite sprite = Resources.Load<Sprite>(text);
				if (null == sprite && LanguageManager.EHBBFMCILPC.Localizable(componentsInChildren[i].sprite.name))
				{
					text = componentsInChildren[i].sprite.name.Split('@', StringSplitOptions.None)[0];
					text = text + "@" + MBBKDFCDAHM;
					sprite = Resources.Load<Sprite>(text);
				}
				if (sprite)
				{
					componentsInChildren[i].sprite = sprite;
					if (this.setNativeSize)
					{
						componentsInChildren[i].SetNativeSize();
					}
					HDTriggerPostProcess component = componentsInChildren[i].gameObject.GetComponent<HDTriggerPostProcess>();
					if (null != component && (component.rectTransformHeight >= 0f || component.rectTransformWidth >= 0f))
					{
						RectTransform component2 = componentsInChildren[i].gameObject.GetComponent<RectTransform>();
						if (component.rectTransformWidth >= 0f)
						{
							component2.EFOCKEJENAC(NBDLBFJOEGN.FJJBMKDBPOM(component.rectTransformWidth));
						}
						else
						{
							component2.ACBKFBBCNNC(NBDLBFJOEGN.FJJBMKDBPOM(component.rectTransformHeight));
						}
					}
				}
			}
		}
		Toggle[] componentsInChildren2 = base.gameObject.GetComponentsInChildren<Toggle>();
		for (int j = 0; j < componentsInChildren2.Length; j++)
		{
			SpriteState spriteState = componentsInChildren2[j].spriteState;
			if (null != spriteState.pressedSprite && ((spriteState.pressedSprite.name.Contains("@") && !spriteState.pressedSprite.name.Contains("@" + MBBKDFCDAHM)) || LanguageManager.EHBBFMCILPC.Localizable(spriteState.pressedSprite.name)))
			{
				string text2 = spriteState.pressedSprite.name.Split('@', StringSplitOptions.None)[0];
				text2 = LanguageManager.EHBBFMCILPC.LocalizeFileName(text2);
				text2 = text2 + "@" + MBBKDFCDAHM;
				Sprite sprite2 = Resources.Load<Sprite>(text2);
				if (null == sprite2 && LanguageManager.EHBBFMCILPC.Localizable(spriteState.pressedSprite.name))
				{
					text2 = spriteState.pressedSprite.name.Split('@', StringSplitOptions.None)[0];
					text2 = text2 + "@" + MBBKDFCDAHM;
					sprite2 = Resources.Load<Sprite>(text2);
				}
				if (sprite2)
				{
					spriteState.pressedSprite = sprite2;
					componentsInChildren2[j].spriteState = spriteState;
				}
			}
			if (null != spriteState.highlightedSprite && ((spriteState.highlightedSprite.name.Contains("@") && !spriteState.highlightedSprite.name.Contains("@" + MBBKDFCDAHM)) || LanguageManager.EHBBFMCILPC.Localizable(spriteState.highlightedSprite.name)))
			{
				string text3 = spriteState.highlightedSprite.name.Split('@', StringSplitOptions.None)[0];
				text3 = LanguageManager.EHBBFMCILPC.LocalizeFileName(text3);
				text3 = text3 + "@" + MBBKDFCDAHM;
				Sprite sprite3 = Resources.Load<Sprite>(text3);
				if (null == sprite3 && LanguageManager.EHBBFMCILPC.Localizable(spriteState.highlightedSprite.name))
				{
					text3 = spriteState.highlightedSprite.name.Split('@', StringSplitOptions.None)[0];
					text3 = text3 + "@" + MBBKDFCDAHM;
					sprite3 = Resources.Load<Sprite>(text3);
				}
				if (sprite3)
				{
					spriteState.highlightedSprite = sprite3;
					componentsInChildren2[j].spriteState = spriteState;
				}
			}
			if (null != spriteState.disabledSprite && ((spriteState.disabledSprite.name.Contains("@") && !spriteState.disabledSprite.name.Contains("@" + MBBKDFCDAHM)) || LanguageManager.EHBBFMCILPC.Localizable(spriteState.disabledSprite.name)))
			{
				string text4 = spriteState.disabledSprite.name.Split('@', StringSplitOptions.None)[0];
				text4 = LanguageManager.EHBBFMCILPC.LocalizeFileName(text4);
				text4 = text4 + "@" + MBBKDFCDAHM;
				Sprite sprite4 = Resources.Load<Sprite>(text4);
				if (null == sprite4 && LanguageManager.EHBBFMCILPC.Localizable(spriteState.disabledSprite.name))
				{
					text4 = spriteState.disabledSprite.name.Split('@', StringSplitOptions.None)[0];
					text4 = text4 + "@" + MBBKDFCDAHM;
					sprite4 = Resources.Load<Sprite>(text4);
				}
				if (sprite4)
				{
					spriteState.disabledSprite = sprite4;
					componentsInChildren2[j].spriteState = spriteState;
				}
			}
		}
		Button[] componentsInChildren3 = base.gameObject.GetComponentsInChildren<Button>();
		for (int k = 0; k < componentsInChildren3.Length; k++)
		{
			SpriteState spriteState2 = componentsInChildren3[k].spriteState;
			if (null != spriteState2.pressedSprite && ((spriteState2.pressedSprite.name.Contains("@") && !spriteState2.pressedSprite.name.Contains("@" + MBBKDFCDAHM)) || LanguageManager.EHBBFMCILPC.Localizable(spriteState2.pressedSprite.name)))
			{
				string text5 = spriteState2.pressedSprite.name.Split('@', StringSplitOptions.None)[0];
				text5 = LanguageManager.EHBBFMCILPC.LocalizeFileName(text5);
				text5 = text5 + "@" + MBBKDFCDAHM;
				Sprite sprite5 = Resources.Load<Sprite>(text5);
				if (null == sprite5 && LanguageManager.EHBBFMCILPC.Localizable(spriteState2.pressedSprite.name))
				{
					text5 = spriteState2.pressedSprite.name.Split('@', StringSplitOptions.None)[0];
					text5 = text5 + "@" + MBBKDFCDAHM;
					sprite5 = Resources.Load<Sprite>(text5);
				}
				if (sprite5)
				{
					spriteState2.pressedSprite = sprite5;
					componentsInChildren3[k].spriteState = spriteState2;
				}
			}
			if (null != spriteState2.highlightedSprite && ((spriteState2.highlightedSprite.name.Contains("@") && !spriteState2.highlightedSprite.name.Contains("@" + MBBKDFCDAHM)) || LanguageManager.EHBBFMCILPC.Localizable(spriteState2.highlightedSprite.name)))
			{
				string text6 = spriteState2.highlightedSprite.name.Split('@', StringSplitOptions.None)[0];
				text6 = LanguageManager.EHBBFMCILPC.LocalizeFileName(text6);
				text6 = text6 + "@" + MBBKDFCDAHM;
				Sprite sprite6 = Resources.Load<Sprite>(text6);
				if (null == sprite6 && LanguageManager.EHBBFMCILPC.Localizable(spriteState2.highlightedSprite.name))
				{
					text6 = spriteState2.highlightedSprite.name.Split('@', StringSplitOptions.None)[0];
					text6 = text6 + "@" + MBBKDFCDAHM;
					sprite6 = Resources.Load<Sprite>(text6);
				}
				if (sprite6)
				{
					spriteState2.highlightedSprite = sprite6;
					componentsInChildren3[k].spriteState = spriteState2;
				}
			}
			if (null != spriteState2.disabledSprite && ((spriteState2.disabledSprite.name.Contains("@") && !spriteState2.disabledSprite.name.Contains("@" + MBBKDFCDAHM)) || LanguageManager.EHBBFMCILPC.Localizable(spriteState2.disabledSprite.name)))
			{
				string text7 = spriteState2.disabledSprite.name.Split('@', StringSplitOptions.None)[0];
				text7 = LanguageManager.EHBBFMCILPC.LocalizeFileName(text7);
				text7 = text7 + "@" + MBBKDFCDAHM;
				Sprite sprite7 = Resources.Load<Sprite>(text7);
				if (null == sprite7 && LanguageManager.EHBBFMCILPC.Localizable(spriteState2.disabledSprite.name))
				{
					text7 = spriteState2.disabledSprite.name.Split('@', StringSplitOptions.None)[0];
					text7 = text7 + "@" + MBBKDFCDAHM;
					sprite7 = Resources.Load<Sprite>(text7);
				}
				if (sprite7)
				{
					spriteState2.disabledSprite = sprite7;
					componentsInChildren3[k].spriteState = spriteState2;
				}
			}
		}
		SpriteRenderer[] componentsInChildren4 = base.gameObject.GetComponentsInChildren<SpriteRenderer>();
		for (int l = 0; l < componentsInChildren4.Length; l++)
		{
			if (null != componentsInChildren4[l].sprite && ((componentsInChildren4[l].sprite.name.Contains("@") && !componentsInChildren4[l].sprite.name.Contains("@" + MBBKDFCDAHM)) || LanguageManager.EHBBFMCILPC.Localizable(componentsInChildren4[l].sprite.name)))
			{
				string text8 = componentsInChildren4[l].sprite.name.Split('@', StringSplitOptions.None)[0];
				text8 = LanguageManager.EHBBFMCILPC.LocalizeFileName(text8);
				text8 = text8 + "@" + MBBKDFCDAHM;
				Sprite sprite8 = Resources.Load<Sprite>(text8);
				if (null == sprite8 && LanguageManager.EHBBFMCILPC.Localizable(componentsInChildren4[l].sprite.name))
				{
					text8 = componentsInChildren4[l].sprite.name.Split('@', StringSplitOptions.None)[0];
					text8 = text8 + "@" + MBBKDFCDAHM;
					sprite8 = Resources.Load<Sprite>(text8);
				}
				if (sprite8)
				{
					componentsInChildren4[l].sprite = sprite8;
				}
			}
		}
	}

	// Token: 0x06004081 RID: 16513 RVA: 0x001B415D File Offset: 0x001B235D
	private void Start()
	{
		if (NBDLBFJOEGN.PBLDJNHHEPL())
		{
			this.SetQuality("HD");
			return;
		}
		this.SetQuality("SD");
	}

	// Token: 0x06004082 RID: 16514 RVA: 0x001B417D File Offset: 0x001B237D
	private void ODOOIGEDLKB()
	{
		if (NBDLBFJOEGN.EFMDGLOLMCJ())
		{
			this.HDLKKHAICOK("OnApplicationFocusBasicSyncEcxeption");
			return;
		}
		this.DFGLNFLPCNO("sfxstatreceived");
	}

	// Token: 0x06004083 RID: 16515 RVA: 0x001B419D File Offset: 0x001B239D
	private void PKMPOFOOGFK()
	{
		if (NBDLBFJOEGN.EFMDGLOLMCJ())
		{
			this.GAJNOAKGGND("musreward");
			return;
		}
		this.IFCJFILBBPN(">");
	}

	// Token: 0x06004084 RID: 16516 RVA: 0x001B41BD File Offset: 0x001B23BD
	private void GEHKPILFMLD()
	{
		if (NBDLBFJOEGN.PNDBACKNEIA())
		{
			this.GHBAPPJKACF("anthology");
			return;
		}
		this.OIAGPDFAMHD("propoff");
	}

	// Token: 0x06004085 RID: 16517 RVA: 0x001B41DD File Offset: 0x001B23DD
	private void JINGEKHJOGH()
	{
		if (NBDLBFJOEGN.EFMDGLOLMCJ())
		{
			this.SetQuality("1.0.0");
			return;
		}
		this.JLOIOAGFDAF("+");
	}

	// Token: 0x06004086 RID: 16518 RVA: 0x001B41FD File Offset: 0x001B23FD
	private void AIDCNCFKNBJ()
	{
		if (NBDLBFJOEGN.PBLDJNHHEPL())
		{
			this.GHBAPPJKACF("OnStoryInterfaceHeaderShopClick");
			return;
		}
		this.IFCJFILBBPN("_Distort");
	}

	// Token: 0x06004087 RID: 16519 RVA: 0x001B4220 File Offset: 0x001B2420
	public void JKOMCGPPEHB(string MBBKDFCDAHM)
	{
		Image[] componentsInChildren = base.gameObject.GetComponentsInChildren<Image>();
		for (int i = 1; i < componentsInChildren.Length; i += 0)
		{
			if (null != componentsInChildren[i].sprite && ((componentsInChildren[i].sprite.name.Contains("USD ") && !componentsInChildren[i].sprite.name.Contains("Failed downloading bundle {0} from {1}: {2}" + MBBKDFCDAHM)) || LanguageManager.EHBBFMCILPC.GCBALKAJINL(componentsInChildren[i].sprite.name)))
			{
				string text = componentsInChildren[i].sprite.name.Split('w', StringSplitOptions.None)[0];
				text = LanguageManager.EHBBFMCILPC.DDHDDIIKAEM(text);
				text = text + "XXX" + MBBKDFCDAHM;
				Sprite sprite = Resources.Load<Sprite>(text);
				if (null == sprite && LanguageManager.EHBBFMCILPC.Localizable(componentsInChildren[i].sprite.name))
				{
					text = componentsInChildren[i].sprite.name.Split((char)-6, StringSplitOptions.None)[0];
					text = text + "sinds" + MBBKDFCDAHM;
					sprite = Resources.Load<Sprite>(text);
				}
				if (sprite)
				{
					componentsInChildren[i].sprite = sprite;
					if (this.setNativeSize)
					{
						componentsInChildren[i].SetNativeSize();
					}
					HDTriggerPostProcess component = componentsInChildren[i].gameObject.GetComponent<HDTriggerPostProcess>();
					if (null != component && (component.rectTransformHeight >= 1146f || component.rectTransformWidth >= 304f))
					{
						RectTransform component2 = componentsInChildren[i].gameObject.GetComponent<RectTransform>();
						if (component.rectTransformWidth >= 1009f)
						{
							component2.EFOCKEJENAC(NBDLBFJOEGN.HJKAMHOAGOH(component.rectTransformWidth));
						}
						else
						{
							component2.ACBKFBBCNNC(NBDLBFJOEGN.HJKAMHOAGOH(component.rectTransformHeight));
						}
					}
				}
			}
		}
		Toggle[] componentsInChildren2 = base.gameObject.GetComponentsInChildren<Toggle>();
		for (int j = 1; j < componentsInChildren2.Length; j++)
		{
			SpriteState spriteState = componentsInChildren2[j].spriteState;
			if (null != spriteState.pressedSprite && ((spriteState.pressedSprite.name.Contains("\\") && !spriteState.pressedSprite.name.Contains("assetbundlepurchasingview" + MBBKDFCDAHM)) || LanguageManager.EHBBFMCILPC.IPMDPLBJHEE(spriteState.pressedSprite.name)))
			{
				string text2 = spriteState.pressedSprite.name.Split((char)-6, StringSplitOptions.RemoveEmptyEntries)[1];
				text2 = LanguageManager.EHBBFMCILPC.DDHDDIIKAEM(text2);
				text2 = text2 + "rsind" + MBBKDFCDAHM;
				Sprite sprite2 = Resources.Load<Sprite>(text2);
				if (null == sprite2 && LanguageManager.EHBBFMCILPC.GCBALKAJINL(spriteState.pressedSprite.name))
				{
					text2 = spriteState.pressedSprite.name.Split((char)-55, StringSplitOptions.RemoveEmptyEntries)[0];
					text2 = text2 + "accountsuspended5" + MBBKDFCDAHM;
					sprite2 = Resources.Load<Sprite>(text2);
				}
				if (sprite2)
				{
					spriteState.pressedSprite = sprite2;
					componentsInChildren2[j].spriteState = spriteState;
				}
			}
			if (null != spriteState.highlightedSprite && ((spriteState.highlightedSprite.name.Contains("assetbundlecommonpack") && !spriteState.highlightedSprite.name.Contains("_Center" + MBBKDFCDAHM)) || LanguageManager.EHBBFMCILPC.GKOAABDJCJH(spriteState.highlightedSprite.name)))
			{
				string text3 = spriteState.highlightedSprite.name.Split(',', StringSplitOptions.RemoveEmptyEntries)[1];
				text3 = LanguageManager.EHBBFMCILPC.EKMKFPOLHOO(text3);
				text3 = text3 + "default" + MBBKDFCDAHM;
				Sprite sprite3 = Resources.Load<Sprite>(text3);
				if (null == sprite3 && LanguageManager.EHBBFMCILPC.GIGIHEEKHBE(spriteState.highlightedSprite.name))
				{
					text3 = spriteState.highlightedSprite.name.Split(' ', StringSplitOptions.None)[0];
					text3 = text3 + "incentadthanks" + MBBKDFCDAHM;
					sprite3 = Resources.Load<Sprite>(text3);
				}
				if (sprite3)
				{
					spriteState.highlightedSprite = sprite3;
					componentsInChildren2[j].spriteState = spriteState;
				}
			}
			if (null != spriteState.disabledSprite && ((spriteState.disabledSprite.name.Contains("idmr") && !spriteState.disabledSprite.name.Contains("ok" + MBBKDFCDAHM)) || LanguageManager.EHBBFMCILPC.EECILBHACFL(spriteState.disabledSprite.name)))
			{
				string text4 = spriteState.disabledSprite.name.Split((char)-123, StringSplitOptions.None)[1];
				text4 = LanguageManager.EHBBFMCILPC.HDJDKLCCCLE(text4);
				text4 = text4 + "" + MBBKDFCDAHM;
				Sprite sprite4 = Resources.Load<Sprite>(text4);
				if (null == sprite4 && LanguageManager.EHBBFMCILPC.GIGIHEEKHBE(spriteState.disabledSprite.name))
				{
					text4 = spriteState.disabledSprite.name.Split('\u0016', StringSplitOptions.None)[0];
					text4 = text4 + "loungeplayfirst" + MBBKDFCDAHM;
					sprite4 = Resources.Load<Sprite>(text4);
				}
				if (sprite4)
				{
					spriteState.disabledSprite = sprite4;
					componentsInChildren2[j].spriteState = spriteState;
				}
			}
		}
		Button[] componentsInChildren3 = base.gameObject.GetComponentsInChildren<Button>();
		for (int k = 0; k < componentsInChildren3.Length; k++)
		{
			SpriteState spriteState2 = componentsInChildren3[k].spriteState;
			if (null != spriteState2.pressedSprite && ((spriteState2.pressedSprite.name.Contains("bits") && !spriteState2.pressedSprite.name.Contains("_" + MBBKDFCDAHM)) || LanguageManager.EHBBFMCILPC.GIGIHEEKHBE(spriteState2.pressedSprite.name)))
			{
				string text5 = spriteState2.pressedSprite.name.Split('-', StringSplitOptions.RemoveEmptyEntries)[1];
				text5 = LanguageManager.EHBBFMCILPC.HDJDKLCCCLE(text5);
				text5 = text5 + "" + MBBKDFCDAHM;
				Sprite sprite5 = Resources.Load<Sprite>(text5);
				if (null == sprite5 && LanguageManager.EHBBFMCILPC.AJLGKKJAAOI(spriteState2.pressedSprite.name))
				{
					text5 = spriteState2.pressedSprite.name.Split('\u0005', StringSplitOptions.None)[0];
					text5 = text5 + " loading " + MBBKDFCDAHM;
					sprite5 = Resources.Load<Sprite>(text5);
				}
				if (sprite5)
				{
					spriteState2.pressedSprite = sprite5;
					componentsInChildren3[k].spriteState = spriteState2;
				}
			}
			if (null != spriteState2.highlightedSprite && ((spriteState2.highlightedSprite.name.Contains("[LoadingEnv] ") && !spriteState2.highlightedSprite.name.Contains("lcdp" + MBBKDFCDAHM)) || LanguageManager.EHBBFMCILPC.EECILBHACFL(spriteState2.highlightedSprite.name)))
			{
				string text6 = spriteState2.highlightedSprite.name.Split('\u0017', StringSplitOptions.None)[1];
				text6 = LanguageManager.EHBBFMCILPC.HDJDKLCCCLE(text6);
				text6 = text6 + "ip" + MBBKDFCDAHM;
				Sprite sprite6 = Resources.Load<Sprite>(text6);
				if (null == sprite6 && LanguageManager.EHBBFMCILPC.Localizable(spriteState2.highlightedSprite.name))
				{
					text6 = spriteState2.highlightedSprite.name.Split((char)-123, StringSplitOptions.RemoveEmptyEntries)[1];
					text6 = text6 + "Invalid frame container bundle index, skipped:" + MBBKDFCDAHM;
					sprite6 = Resources.Load<Sprite>(text6);
				}
				if (sprite6)
				{
					spriteState2.highlightedSprite = sprite6;
					componentsInChildren3[k].spriteState = spriteState2;
				}
			}
			if (null != spriteState2.disabledSprite && ((spriteState2.disabledSprite.name.Contains("$e1en") && !spriteState2.disabledSprite.name.Contains(")" + MBBKDFCDAHM)) || LanguageManager.EHBBFMCILPC.GKOAABDJCJH(spriteState2.disabledSprite.name)))
			{
				string text7 = spriteState2.disabledSprite.name.Split('\b', StringSplitOptions.None)[1];
				text7 = LanguageManager.EHBBFMCILPC.LocalizeFileName(text7);
				text7 = text7 + "" + MBBKDFCDAHM;
				Sprite sprite7 = Resources.Load<Sprite>(text7);
				if (null == sprite7 && LanguageManager.EHBBFMCILPC.GIGIHEEKHBE(spriteState2.disabledSprite.name))
				{
					text7 = spriteState2.disabledSprite.name.Split('D', StringSplitOptions.None)[1];
					text7 = text7 + "\"" + MBBKDFCDAHM;
					sprite7 = Resources.Load<Sprite>(text7);
				}
				if (sprite7)
				{
					spriteState2.disabledSprite = sprite7;
					componentsInChildren3[k].spriteState = spriteState2;
				}
			}
		}
		SpriteRenderer[] componentsInChildren4 = base.gameObject.GetComponentsInChildren<SpriteRenderer>();
		for (int l = 0; l < componentsInChildren4.Length; l++)
		{
			if (null != componentsInChildren4[l].sprite && ((componentsInChildren4[l].sprite.name.Contains("yes") && !componentsInChildren4[l].sprite.name.Contains("YYY" + MBBKDFCDAHM)) || LanguageManager.EHBBFMCILPC.GKOAABDJCJH(componentsInChildren4[l].sprite.name)))
			{
				string text8 = componentsInChildren4[l].sprite.name.Split((char)-63, StringSplitOptions.RemoveEmptyEntries)[1];
				text8 = LanguageManager.EHBBFMCILPC.PKJABHFHHLC(text8);
				text8 = text8 + "Loaded asset bundle:" + MBBKDFCDAHM;
				Sprite sprite8 = Resources.Load<Sprite>(text8);
				if (null == sprite8 && LanguageManager.EHBBFMCILPC.GHCIBLENAOO(componentsInChildren4[l].sprite.name))
				{
					text8 = componentsInChildren4[l].sprite.name.Split((char)-9, StringSplitOptions.None)[0];
					text8 = text8 + "OnApplicationFocusBasicSyncSuccess" + MBBKDFCDAHM;
					sprite8 = Resources.Load<Sprite>(text8);
				}
				if (sprite8)
				{
					componentsInChildren4[l].sprite = sprite8;
				}
			}
		}
	}

	// Token: 0x06004088 RID: 16520 RVA: 0x001B4BF0 File Offset: 0x001B2DF0
	public void BCIIGDHDOAJ(string MBBKDFCDAHM)
	{
		Image[] componentsInChildren = base.gameObject.GetComponentsInChildren<Image>();
		for (int i = 1; i < componentsInChildren.Length; i += 0)
		{
			if (null != componentsInChildren[i].sprite && ((componentsInChildren[i].sprite.name.Contains(" <i>") && !componentsInChildren[i].sprite.name.Contains(": ym '" + MBBKDFCDAHM)) || LanguageManager.EHBBFMCILPC.EECILBHACFL(componentsInChildren[i].sprite.name)))
			{
				string text = componentsInChildren[i].sprite.name.Split('C', StringSplitOptions.None)[0];
				text = LanguageManager.EHBBFMCILPC.EKMKFPOLHOO(text);
				text = text + "myprreportdonebody" + MBBKDFCDAHM;
				Sprite sprite = Resources.Load<Sprite>(text);
				if (null == sprite && LanguageManager.EHBBFMCILPC.Localizable(componentsInChildren[i].sprite.name))
				{
					text = componentsInChildren[i].sprite.name.Split((char)-11, StringSplitOptions.RemoveEmptyEntries)[0];
					text = text + "" + MBBKDFCDAHM;
					sprite = Resources.Load<Sprite>(text);
				}
				if (sprite)
				{
					componentsInChildren[i].sprite = sprite;
					if (this.setNativeSize)
					{
						componentsInChildren[i].SetNativeSize();
					}
					HDTriggerPostProcess component = componentsInChildren[i].gameObject.GetComponent<HDTriggerPostProcess>();
					if (null != component && (component.rectTransformHeight >= 250f || component.rectTransformWidth >= 286f))
					{
						RectTransform component2 = componentsInChildren[i].gameObject.GetComponent<RectTransform>();
						if (component.rectTransformWidth >= 153f)
						{
							component2.EFOCKEJENAC(NBDLBFJOEGN.HLGHANHNEHJ(component.rectTransformWidth));
						}
						else
						{
							component2.ACBKFBBCNNC(NBDLBFJOEGN.FJJBMKDBPOM(component.rectTransformHeight));
						}
					}
				}
			}
		}
		Toggle[] componentsInChildren2 = base.gameObject.GetComponentsInChildren<Toggle>();
		for (int j = 1; j < componentsInChildren2.Length; j += 0)
		{
			SpriteState spriteState = componentsInChildren2[j].spriteState;
			if (null != spriteState.pressedSprite && ((spriteState.pressedSprite.name.Contains("cch") && !spriteState.pressedSprite.name.Contains("filter" + MBBKDFCDAHM)) || LanguageManager.EHBBFMCILPC.IPMDPLBJHEE(spriteState.pressedSprite.name)))
			{
				string text2 = spriteState.pressedSprite.name.Split((char)-113, StringSplitOptions.None)[0];
				text2 = LanguageManager.EHBBFMCILPC.EKMKFPOLHOO(text2);
				text2 = text2 + "offerType" + MBBKDFCDAHM;
				Sprite sprite2 = Resources.Load<Sprite>(text2);
				if (null == sprite2 && LanguageManager.EHBBFMCILPC.EECILBHACFL(spriteState.pressedSprite.name))
				{
					text2 = spriteState.pressedSprite.name.Split('\u001a', StringSplitOptions.None)[0];
					text2 = text2 + ", day " + MBBKDFCDAHM;
					sprite2 = Resources.Load<Sprite>(text2);
				}
				if (sprite2)
				{
					spriteState.pressedSprite = sprite2;
					componentsInChildren2[j].spriteState = spriteState;
				}
			}
			if (null != spriteState.highlightedSprite && ((spriteState.highlightedSprite.name.Contains("OnChoiceExtendedLayerChange") && !spriteState.highlightedSprite.name.Contains("Development Server URL could not be found." + MBBKDFCDAHM)) || LanguageManager.EHBBFMCILPC.IPMDPLBJHEE(spriteState.highlightedSprite.name)))
			{
				string text3 = spriteState.highlightedSprite.name.Split((char)-66, StringSplitOptions.None)[1];
				text3 = LanguageManager.EHBBFMCILPC.DDHDDIIKAEM(text3);
				text3 = text3 + ")" + MBBKDFCDAHM;
				Sprite sprite3 = Resources.Load<Sprite>(text3);
				if (null == sprite3 && LanguageManager.EHBBFMCILPC.GCBALKAJINL(spriteState.highlightedSprite.name))
				{
					text3 = spriteState.highlightedSprite.name.Split((char)-104, StringSplitOptions.None)[1];
					text3 = text3 + "lsvv" + MBBKDFCDAHM;
					sprite3 = Resources.Load<Sprite>(text3);
				}
				if (sprite3)
				{
					spriteState.highlightedSprite = sprite3;
					componentsInChildren2[j].spriteState = spriteState;
				}
			}
			if (null != spriteState.disabledSprite && ((spriteState.disabledSprite.name.Contains("' has no category, skipped") && !spriteState.disabledSprite.name.Contains("getSketchesBalance" + MBBKDFCDAHM)) || LanguageManager.EHBBFMCILPC.IPMDPLBJHEE(spriteState.disabledSprite.name)))
			{
				string text4 = spriteState.disabledSprite.name.Split((char)-102, StringSplitOptions.RemoveEmptyEntries)[1];
				text4 = LanguageManager.EHBBFMCILPC.GHBJGFDKHEJ(text4);
				text4 = text4 + "loungechoosetitle" + MBBKDFCDAHM;
				Sprite sprite4 = Resources.Load<Sprite>(text4);
				if (null == sprite4 && LanguageManager.EHBBFMCILPC.Localizable(spriteState.disabledSprite.name))
				{
					text4 = spriteState.disabledSprite.name.Split('W', StringSplitOptions.None)[1];
					text4 = text4 + "continue" + MBBKDFCDAHM;
					sprite4 = Resources.Load<Sprite>(text4);
				}
				if (sprite4)
				{
					spriteState.disabledSprite = sprite4;
					componentsInChildren2[j].spriteState = spriteState;
				}
			}
		}
		Button[] componentsInChildren3 = base.gameObject.GetComponentsInChildren<Button>();
		for (int k = 0; k < componentsInChildren3.Length; k += 0)
		{
			SpriteState spriteState2 = componentsInChildren3[k].spriteState;
			if (null != spriteState2.pressedSprite && ((spriteState2.pressedSprite.name.Contains(",") && !spriteState2.pressedSprite.name.Contains("0" + MBBKDFCDAHM)) || LanguageManager.EHBBFMCILPC.GKOAABDJCJH(spriteState2.pressedSprite.name)))
			{
				string text5 = spriteState2.pressedSprite.name.Split((char)-127, StringSplitOptions.RemoveEmptyEntries)[1];
				text5 = LanguageManager.EHBBFMCILPC.IKMHJBKPMGE(text5);
				text5 = text5 + "AssetsManager.UpdateUrlPingManagerState(): urlPingManager.StartPing()" + MBBKDFCDAHM;
				Sprite sprite5 = Resources.Load<Sprite>(text5);
				if (null == sprite5 && LanguageManager.EHBBFMCILPC.GKOAABDJCJH(spriteState2.pressedSprite.name))
				{
					text5 = spriteState2.pressedSprite.name.Split('=', StringSplitOptions.None)[1];
					text5 = text5 + "OnAppleLoginSuccess" + MBBKDFCDAHM;
					sprite5 = Resources.Load<Sprite>(text5);
				}
				if (sprite5)
				{
					spriteState2.pressedSprite = sprite5;
					componentsInChildren3[k].spriteState = spriteState2;
				}
			}
			if (null != spriteState2.highlightedSprite && ((spriteState2.highlightedSprite.name.Contains("pmtsuccess") && !spriteState2.highlightedSprite.name.Contains("́ ̀" + MBBKDFCDAHM)) || LanguageManager.EHBBFMCILPC.EECILBHACFL(spriteState2.highlightedSprite.name)))
			{
				string text6 = spriteState2.highlightedSprite.name.Split('E', StringSplitOptions.None)[0];
				text6 = LanguageManager.EHBBFMCILPC.EKMKFPOLHOO(text6);
				text6 = text6 + "Swipe tutorial shown, frames:" + MBBKDFCDAHM;
				Sprite sprite6 = Resources.Load<Sprite>(text6);
				if (null == sprite6 && LanguageManager.EHBBFMCILPC.GHCIBLENAOO(spriteState2.highlightedSprite.name))
				{
					text6 = spriteState2.highlightedSprite.name.Split(')', StringSplitOptions.RemoveEmptyEntries)[0];
					text6 = text6 + "sfxtimeoutwarning" + MBBKDFCDAHM;
					sprite6 = Resources.Load<Sprite>(text6);
				}
				if (sprite6)
				{
					spriteState2.highlightedSprite = sprite6;
					componentsInChildren3[k].spriteState = spriteState2;
				}
			}
			if (null != spriteState2.disabledSprite && ((spriteState2.disabledSprite.name.Contains(" ") && !spriteState2.disabledSprite.name.Contains("cind" + MBBKDFCDAHM)) || LanguageManager.EHBBFMCILPC.GIGIHEEKHBE(spriteState2.disabledSprite.name)))
			{
				string text7 = spriteState2.disabledSprite.name.Split((char)-111, StringSplitOptions.RemoveEmptyEntries)[1];
				text7 = LanguageManager.EHBBFMCILPC.EKMKFPOLHOO(text7);
				text7 = text7 + "OnMissingPreview2CdnSuccess" + MBBKDFCDAHM;
				Sprite sprite7 = Resources.Load<Sprite>(text7);
				if (null == sprite7 && LanguageManager.EHBBFMCILPC.GHCIBLENAOO(spriteState2.disabledSprite.name))
				{
					text7 = spriteState2.disabledSprite.name.Split('E', StringSplitOptions.RemoveEmptyEntries)[1];
					text7 = text7 + "OnFriendsGiftPopulCollectPart1" + MBBKDFCDAHM;
					sprite7 = Resources.Load<Sprite>(text7);
				}
				if (sprite7)
				{
					spriteState2.disabledSprite = sprite7;
					componentsInChildren3[k].spriteState = spriteState2;
				}
			}
		}
		SpriteRenderer[] componentsInChildren4 = base.gameObject.GetComponentsInChildren<SpriteRenderer>();
		for (int l = 0; l < componentsInChildren4.Length; l += 0)
		{
			if (null != componentsInChildren4[l].sprite && ((componentsInChildren4[l].sprite.name.Contains("fstr") && !componentsInChildren4[l].sprite.name.Contains("" + MBBKDFCDAHM)) || LanguageManager.EHBBFMCILPC.GCBALKAJINL(componentsInChildren4[l].sprite.name)))
			{
				string text8 = componentsInChildren4[l].sprite.name.Split((char)-110, StringSplitOptions.None)[1];
				text8 = LanguageManager.EHBBFMCILPC.LocalizeFileName(text8);
				text8 = text8 + "frds" + MBBKDFCDAHM;
				Sprite sprite8 = Resources.Load<Sprite>(text8);
				if (null == sprite8 && LanguageManager.EHBBFMCILPC.GCBALKAJINL(componentsInChildren4[l].sprite.name))
				{
					text8 = componentsInChildren4[l].sprite.name.Split((char)-11, StringSplitOptions.RemoveEmptyEntries)[0];
					text8 = text8 + "areyousurerestartchapter0" + MBBKDFCDAHM;
					sprite8 = Resources.Load<Sprite>(text8);
				}
				if (sprite8)
				{
					componentsInChildren4[l].sprite = sprite8;
				}
			}
		}
	}

	// Token: 0x06004089 RID: 16521 RVA: 0x001B55BD File Offset: 0x001B37BD
	private void PMKKOENBNOM()
	{
		if (NBDLBFJOEGN.JIGBPKMNOHH())
		{
			this.PBNGGMCIBMA("per");
			return;
		}
		this.HJNOFHJLAFA("gsec");
	}

	// Token: 0x0600408A RID: 16522 RVA: 0x001B55E0 File Offset: 0x001B37E0
	public void ICKMGFMPMPI(string MBBKDFCDAHM)
	{
		Image[] componentsInChildren = base.gameObject.GetComponentsInChildren<Image>();
		for (int i = 1; i < componentsInChildren.Length; i++)
		{
			if (null != componentsInChildren[i].sprite && ((componentsInChildren[i].sprite.name.Contains("UpdateSoundOnOffState") && !componentsInChildren[i].sprite.name.Contains("PostponeCustomCode() here's postponedCustomCode contents:" + MBBKDFCDAHM)) || LanguageManager.EHBBFMCILPC.IPMDPLBJHEE(componentsInChildren[i].sprite.name)))
			{
				string text = componentsInChildren[i].sprite.name.Split('\u0005', StringSplitOptions.RemoveEmptyEntries)[1];
				text = LanguageManager.EHBBFMCILPC.PKJABHFHHLC(text);
				text = text + "tradewishcardoption0" + MBBKDFCDAHM;
				Sprite sprite = Resources.Load<Sprite>(text);
				if (null == sprite && LanguageManager.EHBBFMCILPC.Localizable(componentsInChildren[i].sprite.name))
				{
					text = componentsInChildren[i].sprite.name.Split((char)-109, StringSplitOptions.RemoveEmptyEntries)[1];
					text = text + "continue" + MBBKDFCDAHM;
					sprite = Resources.Load<Sprite>(text);
				}
				if (sprite)
				{
					componentsInChildren[i].sprite = sprite;
					if (this.setNativeSize)
					{
						componentsInChildren[i].SetNativeSize();
					}
					HDTriggerPostProcess component = componentsInChildren[i].gameObject.GetComponent<HDTriggerPostProcess>();
					if (null != component && (component.rectTransformHeight >= 862f || component.rectTransformWidth >= 439f))
					{
						RectTransform component2 = componentsInChildren[i].gameObject.GetComponent<RectTransform>();
						if (component.rectTransformWidth >= 603f)
						{
							component2.EFOCKEJENAC(NBDLBFJOEGN.LIBPCPOBCNA(component.rectTransformWidth));
						}
						else
						{
							component2.ACBKFBBCNNC(NBDLBFJOEGN.MAPGECGPMGM(component.rectTransformHeight));
						}
					}
				}
			}
		}
		Toggle[] componentsInChildren2 = base.gameObject.GetComponentsInChildren<Toggle>();
		for (int j = 0; j < componentsInChildren2.Length; j++)
		{
			SpriteState spriteState = componentsInChildren2[j].spriteState;
			if (null != spriteState.pressedSprite && ((spriteState.pressedSprite.name.Contains("bdgsspr") && !spriteState.pressedSprite.name.Contains("CLIENT.SCREEN.REWARD." + MBBKDFCDAHM)) || LanguageManager.EHBBFMCILPC.AJLGKKJAAOI(spriteState.pressedSprite.name)))
			{
				string text2 = spriteState.pressedSprite.name.Split((char)-5, StringSplitOptions.None)[0];
				text2 = LanguageManager.EHBBFMCILPC.HDJDKLCCCLE(text2);
				text2 = text2 + "ok" + MBBKDFCDAHM;
				Sprite sprite2 = Resources.Load<Sprite>(text2);
				if (null == sprite2 && LanguageManager.EHBBFMCILPC.Localizable(spriteState.pressedSprite.name))
				{
					text2 = spriteState.pressedSprite.name.Split((char)-52, StringSplitOptions.RemoveEmptyEntries)[0];
					text2 = text2 + "_Distortion" + MBBKDFCDAHM;
					sprite2 = Resources.Load<Sprite>(text2);
				}
				if (sprite2)
				{
					spriteState.pressedSprite = sprite2;
					componentsInChildren2[j].spriteState = spriteState;
				}
			}
			if (null != spriteState.highlightedSprite && ((spriteState.highlightedSprite.name.Contains("HD") && !spriteState.highlightedSprite.name.Contains("OnBackendPassResourcesChangedType0" + MBBKDFCDAHM)) || LanguageManager.EHBBFMCILPC.GHCIBLENAOO(spriteState.highlightedSprite.name)))
			{
				string text3 = spriteState.highlightedSprite.name.Split('r', StringSplitOptions.RemoveEmptyEntries)[0];
				text3 = LanguageManager.EHBBFMCILPC.EKMKFPOLHOO(text3);
				text3 = text3 + "AdsManagerLP: ShowAdRewarded() called" + MBBKDFCDAHM;
				Sprite sprite3 = Resources.Load<Sprite>(text3);
				if (null == sprite3 && LanguageManager.EHBBFMCILPC.EECILBHACFL(spriteState.highlightedSprite.name))
				{
					text3 = spriteState.highlightedSprite.name.Split((char)-86, StringSplitOptions.None)[1];
					text3 = text3 + "_Opacity" + MBBKDFCDAHM;
					sprite3 = Resources.Load<Sprite>(text3);
				}
				if (sprite3)
				{
					spriteState.highlightedSprite = sprite3;
					componentsInChildren2[j].spriteState = spriteState;
				}
			}
			if (null != spriteState.disabledSprite && ((spriteState.disabledSprite.name.Contains("AnthologySave.AddAvatarComponent(), unsupported wardrobe index:") && !spriteState.disabledSprite.name.Contains("gamepassdurationtitle" + MBBKDFCDAHM)) || LanguageManager.EHBBFMCILPC.GCBALKAJINL(spriteState.disabledSprite.name)))
			{
				string text4 = spriteState.disabledSprite.name.Split((char)-37, StringSplitOptions.None)[1];
				text4 = LanguageManager.EHBBFMCILPC.MNAALCNJHFP(text4);
				text4 = text4 + "FilterAnimationScrollMoveSmooth" + MBBKDFCDAHM;
				Sprite sprite4 = Resources.Load<Sprite>(text4);
				if (null == sprite4 && LanguageManager.EHBBFMCILPC.Localizable(spriteState.disabledSprite.name))
				{
					text4 = spriteState.disabledSprite.name.Split('8', StringSplitOptions.RemoveEmptyEntries)[0];
					text4 = text4 + "\"" + MBBKDFCDAHM;
					sprite4 = Resources.Load<Sprite>(text4);
				}
				if (sprite4)
				{
					spriteState.disabledSprite = sprite4;
					componentsInChildren2[j].spriteState = spriteState;
				}
			}
		}
		Button[] componentsInChildren3 = base.gameObject.GetComponentsInChildren<Button>();
		for (int k = 1; k < componentsInChildren3.Length; k += 0)
		{
			SpriteState spriteState2 = componentsInChildren3[k].spriteState;
			if (null != spriteState2.pressedSprite && ((spriteState2.pressedSprite.name.Contains("continue") && !spriteState2.pressedSprite.name.Contains("" + MBBKDFCDAHM)) || LanguageManager.EHBBFMCILPC.GKOAABDJCJH(spriteState2.pressedSprite.name)))
			{
				string text5 = spriteState2.pressedSprite.name.Split((char)-79, StringSplitOptions.None)[0];
				text5 = LanguageManager.EHBBFMCILPC.HDJDKLCCCLE(text5);
				text5 = text5 + "OnTryToFireNoteshowTimer" + MBBKDFCDAHM;
				Sprite sprite5 = Resources.Load<Sprite>(text5);
				if (null == sprite5 && LanguageManager.EHBBFMCILPC.Localizable(spriteState2.pressedSprite.name))
				{
					text5 = spriteState2.pressedSprite.name.Split((char)-26, StringSplitOptions.RemoveEmptyEntries)[0];
					text5 = text5 + "Vol" + MBBKDFCDAHM;
					sprite5 = Resources.Load<Sprite>(text5);
				}
				if (sprite5)
				{
					spriteState2.pressedSprite = sprite5;
					componentsInChildren3[k].spriteState = spriteState2;
				}
			}
			if (null != spriteState2.highlightedSprite && ((spriteState2.highlightedSprite.name.Contains("p") && !spriteState2.highlightedSprite.name.Contains(";" + MBBKDFCDAHM)) || LanguageManager.EHBBFMCILPC.GCBALKAJINL(spriteState2.highlightedSprite.name)))
			{
				string text6 = spriteState2.highlightedSprite.name.Split((char)-92, StringSplitOptions.None)[0];
				text6 = LanguageManager.EHBBFMCILPC.IKMHJBKPMGE(text6);
				text6 = text6 + "" + MBBKDFCDAHM;
				Sprite sprite6 = Resources.Load<Sprite>(text6);
				if (null == sprite6 && LanguageManager.EHBBFMCILPC.GHCIBLENAOO(spriteState2.highlightedSprite.name))
				{
					text6 = spriteState2.highlightedSprite.name.Split((char)-94, StringSplitOptions.RemoveEmptyEntries)[1];
					text6 = text6 + "" + MBBKDFCDAHM;
					sprite6 = Resources.Load<Sprite>(text6);
				}
				if (sprite6)
				{
					spriteState2.highlightedSprite = sprite6;
					componentsInChildren3[k].spriteState = spriteState2;
				}
			}
			if (null != spriteState2.disabledSprite && ((spriteState2.disabledSprite.name.Contains("skpublisherr") && !spriteState2.disabledSprite.name.Contains("OnCutsceneViewAssetsDownloadFailed" + MBBKDFCDAHM)) || LanguageManager.EHBBFMCILPC.GHCIBLENAOO(spriteState2.disabledSprite.name)))
			{
				string text7 = spriteState2.disabledSprite.name.Split((char)-10, StringSplitOptions.None)[0];
				text7 = LanguageManager.EHBBFMCILPC.HDJDKLCCCLE(text7);
				text7 = text7 + "rsl" + MBBKDFCDAHM;
				Sprite sprite7 = Resources.Load<Sprite>(text7);
				if (null == sprite7 && LanguageManager.EHBBFMCILPC.EECILBHACFL(spriteState2.disabledSprite.name))
				{
					text7 = spriteState2.disabledSprite.name.Split('h', StringSplitOptions.RemoveEmptyEntries)[1];
					text7 = text7 + "anthology" + MBBKDFCDAHM;
					sprite7 = Resources.Load<Sprite>(text7);
				}
				if (sprite7)
				{
					spriteState2.disabledSprite = sprite7;
					componentsInChildren3[k].spriteState = spriteState2;
				}
			}
		}
		SpriteRenderer[] componentsInChildren4 = base.gameObject.GetComponentsInChildren<SpriteRenderer>();
		for (int l = 0; l < componentsInChildren4.Length; l += 0)
		{
			if (null != componentsInChildren4[l].sprite && ((componentsInChildren4[l].sprite.name.Contains("p") && !componentsInChildren4[l].sprite.name.Contains(">" + MBBKDFCDAHM)) || LanguageManager.EHBBFMCILPC.EECILBHACFL(componentsInChildren4[l].sprite.name)))
			{
				string text8 = componentsInChildren4[l].sprite.name.Split('O', StringSplitOptions.RemoveEmptyEntries)[1];
				text8 = LanguageManager.EHBBFMCILPC.LocalizeFileName(text8);
				text8 = text8 + "OnStoryCurrencyInfoClick" + MBBKDFCDAHM;
				Sprite sprite8 = Resources.Load<Sprite>(text8);
				if (null == sprite8 && LanguageManager.EHBBFMCILPC.AJLGKKJAAOI(componentsInChildren4[l].sprite.name))
				{
					text8 = componentsInChildren4[l].sprite.name.Split((char)-102, StringSplitOptions.RemoveEmptyEntries)[1];
					text8 = text8 + "ZZZ" + MBBKDFCDAHM;
					sprite8 = Resources.Load<Sprite>(text8);
				}
				if (sprite8)
				{
					componentsInChildren4[l].sprite = sprite8;
				}
			}
		}
	}

	// Token: 0x0600408B RID: 16523 RVA: 0x001B5FB0 File Offset: 0x001B41B0
	public void OGJLMKBBINC(string MBBKDFCDAHM)
	{
		Image[] componentsInChildren = base.gameObject.GetComponentsInChildren<Image>();
		for (int i = 1; i < componentsInChildren.Length; i++)
		{
			if (null != componentsInChildren[i].sprite && ((componentsInChildren[i].sprite.name.Contains("cmec") && !componentsInChildren[i].sprite.name.Contains(" " + MBBKDFCDAHM)) || LanguageManager.EHBBFMCILPC.Localizable(componentsInChildren[i].sprite.name)))
			{
				string text = componentsInChildren[i].sprite.name.Split((char)-91, StringSplitOptions.None)[1];
				text = LanguageManager.EHBBFMCILPC.HDJDKLCCCLE(text);
				text = text + "storyAssetPackManager[i].environmentsBackList[j] is null!" + MBBKDFCDAHM;
				Sprite sprite = Resources.Load<Sprite>(text);
				if (null == sprite && LanguageManager.EHBBFMCILPC.Localizable(componentsInChildren[i].sprite.name))
				{
					text = componentsInChildren[i].sprite.name.Split((char)-20, StringSplitOptions.RemoveEmptyEntries)[0];
					text = text + "PlayerCharacterManager.SetTrinketComponent() - input is null." + MBBKDFCDAHM;
					sprite = Resources.Load<Sprite>(text);
				}
				if (sprite)
				{
					componentsInChildren[i].sprite = sprite;
					if (this.setNativeSize)
					{
						componentsInChildren[i].SetNativeSize();
					}
					HDTriggerPostProcess component = componentsInChildren[i].gameObject.GetComponent<HDTriggerPostProcess>();
					if (null != component && (component.rectTransformHeight >= 301f || component.rectTransformWidth >= 358f))
					{
						RectTransform component2 = componentsInChildren[i].gameObject.GetComponent<RectTransform>();
						if (component.rectTransformWidth >= 1277f)
						{
							component2.EFOCKEJENAC(NBDLBFJOEGN.FCGMMHPNIJG(component.rectTransformWidth));
						}
						else
						{
							component2.ACBKFBBCNNC(NBDLBFJOEGN.OIHMGIBOFJG(component.rectTransformHeight));
						}
					}
				}
			}
		}
		Toggle[] componentsInChildren2 = base.gameObject.GetComponentsInChildren<Toggle>();
		for (int j = 0; j < componentsInChildren2.Length; j++)
		{
			SpriteState spriteState = componentsInChildren2[j].spriteState;
			if (null != spriteState.pressedSprite && ((spriteState.pressedSprite.name.Contains("evar") && !spriteState.pressedSprite.name.Contains("skpcut" + MBBKDFCDAHM)) || LanguageManager.EHBBFMCILPC.GIGIHEEKHBE(spriteState.pressedSprite.name)))
			{
				string text2 = spriteState.pressedSprite.name.Split((char)-35, StringSplitOptions.None)[1];
				text2 = LanguageManager.EHBBFMCILPC.DDHDDIIKAEM(text2);
				text2 = text2 + "" + MBBKDFCDAHM;
				Sprite sprite2 = Resources.Load<Sprite>(text2);
				if (null == sprite2 && LanguageManager.EHBBFMCILPC.AJLGKKJAAOI(spriteState.pressedSprite.name))
				{
					text2 = spriteState.pressedSprite.name.Split((char)-107, StringSplitOptions.RemoveEmptyEntries)[1];
					text2 = text2 + "There needs to be one active FacebookManager script on a GameObject in your scene." + MBBKDFCDAHM;
					sprite2 = Resources.Load<Sprite>(text2);
				}
				if (sprite2)
				{
					spriteState.pressedSprite = sprite2;
					componentsInChildren2[j].spriteState = spriteState;
				}
			}
			if (null != spriteState.highlightedSprite && ((spriteState.highlightedSprite.name.Contains("p") && !spriteState.highlightedSprite.name.Contains("" + MBBKDFCDAHM)) || LanguageManager.EHBBFMCILPC.GHCIBLENAOO(spriteState.highlightedSprite.name)))
			{
				string text3 = spriteState.highlightedSprite.name.Split((char)-102, StringSplitOptions.RemoveEmptyEntries)[0];
				text3 = LanguageManager.EHBBFMCILPC.MNAALCNJHFP(text3);
				text3 = text3 + "errortitle" + MBBKDFCDAHM;
				Sprite sprite3 = Resources.Load<Sprite>(text3);
				if (null == sprite3 && LanguageManager.EHBBFMCILPC.GIGIHEEKHBE(spriteState.highlightedSprite.name))
				{
					text3 = spriteState.highlightedSprite.name.Split('\u0017', StringSplitOptions.RemoveEmptyEntries)[1];
					text3 = text3 + "Npc id has been destroyed according to on demand data:" + MBBKDFCDAHM;
					sprite3 = Resources.Load<Sprite>(text3);
				}
				if (sprite3)
				{
					spriteState.highlightedSprite = sprite3;
					componentsInChildren2[j].spriteState = spriteState;
				}
			}
			if (null != spriteState.disabledSprite && ((spriteState.disabledSprite.name.Contains("+") && !spriteState.disabledSprite.name.Contains("%" + MBBKDFCDAHM)) || LanguageManager.EHBBFMCILPC.Localizable(spriteState.disabledSprite.name)))
			{
				string text4 = spriteState.disabledSprite.name.Split('c', StringSplitOptions.RemoveEmptyEntries)[1];
				text4 = LanguageManager.EHBBFMCILPC.HDJDKLCCCLE(text4);
				text4 = text4 + "n/a" + MBBKDFCDAHM;
				Sprite sprite4 = Resources.Load<Sprite>(text4);
				if (null == sprite4 && LanguageManager.EHBBFMCILPC.GHCIBLENAOO(spriteState.disabledSprite.name))
				{
					text4 = spriteState.disabledSprite.name.Split((char)-73, StringSplitOptions.RemoveEmptyEntries)[1];
					text4 = text4 + "restartseason" + MBBKDFCDAHM;
					sprite4 = Resources.Load<Sprite>(text4);
				}
				if (sprite4)
				{
					spriteState.disabledSprite = sprite4;
					componentsInChildren2[j].spriteState = spriteState;
				}
			}
		}
		Button[] componentsInChildren3 = base.gameObject.GetComponentsInChildren<Button>();
		for (int k = 0; k < componentsInChildren3.Length; k++)
		{
			SpriteState spriteState2 = componentsInChildren3[k].spriteState;
			if (null != spriteState2.pressedSprite && ((spriteState2.pressedSprite.name.Contains("trsv") && !spriteState2.pressedSprite.name.Contains("OnBackendRequestFriendAcceptException" + MBBKDFCDAHM)) || LanguageManager.EHBBFMCILPC.GCBALKAJINL(spriteState2.pressedSprite.name)))
			{
				string text5 = spriteState2.pressedSprite.name.Split('\u001a', StringSplitOptions.None)[1];
				text5 = LanguageManager.EHBBFMCILPC.PKJABHFHHLC(text5);
				text5 = text5 + "amt" + MBBKDFCDAHM;
				Sprite sprite5 = Resources.Load<Sprite>(text5);
				if (null == sprite5 && LanguageManager.EHBBFMCILPC.GIGIHEEKHBE(spriteState2.pressedSprite.name))
				{
					text5 = spriteState2.pressedSprite.name.Split((char)-35, StringSplitOptions.None)[0];
					text5 = text5 + "ActivateSystemBackButtonManager" + MBBKDFCDAHM;
					sprite5 = Resources.Load<Sprite>(text5);
				}
				if (sprite5)
				{
					spriteState2.pressedSprite = sprite5;
					componentsInChildren3[k].spriteState = spriteState2;
				}
			}
			if (null != spriteState2.highlightedSprite && ((spriteState2.highlightedSprite.name.Contains("ZZZ") && !spriteState2.highlightedSprite.name.Contains(" story slots" + MBBKDFCDAHM)) || LanguageManager.EHBBFMCILPC.GIGIHEEKHBE(spriteState2.highlightedSprite.name)))
			{
				string text6 = spriteState2.highlightedSprite.name.Split('I', StringSplitOptions.RemoveEmptyEntries)[1];
				text6 = LanguageManager.EHBBFMCILPC.IKMHJBKPMGE(text6);
				text6 = text6 + "" + MBBKDFCDAHM;
				Sprite sprite6 = Resources.Load<Sprite>(text6);
				if (null == sprite6 && LanguageManager.EHBBFMCILPC.IPMDPLBJHEE(spriteState2.highlightedSprite.name))
				{
					text6 = spriteState2.highlightedSprite.name.Split((char)-89, StringSplitOptions.None)[1];
					text6 = text6 + "grayscale" + MBBKDFCDAHM;
					sprite6 = Resources.Load<Sprite>(text6);
				}
				if (sprite6)
				{
					spriteState2.highlightedSprite = sprite6;
					componentsInChildren3[k].spriteState = spriteState2;
				}
			}
			if (null != spriteState2.disabledSprite && ((spriteState2.disabledSprite.name.Contains("OnPurchasingNotInitialized") && !spriteState2.disabledSprite.name.Contains("" + MBBKDFCDAHM)) || LanguageManager.EHBBFMCILPC.GCBALKAJINL(spriteState2.disabledSprite.name)))
			{
				string text7 = spriteState2.disabledSprite.name.Split((char)-87, StringSplitOptions.RemoveEmptyEntries)[1];
				text7 = LanguageManager.EHBBFMCILPC.GHBJGFDKHEJ(text7);
				text7 = text7 + "RT REPORT - ChoiceExtendedManager - " + MBBKDFCDAHM;
				Sprite sprite7 = Resources.Load<Sprite>(text7);
				if (null == sprite7 && LanguageManager.EHBBFMCILPC.GHCIBLENAOO(spriteState2.disabledSprite.name))
				{
					text7 = spriteState2.disabledSprite.name.Split((char)-98, StringSplitOptions.None)[0];
					text7 = text7 + "" + MBBKDFCDAHM;
					sprite7 = Resources.Load<Sprite>(text7);
				}
				if (sprite7)
				{
					spriteState2.disabledSprite = sprite7;
					componentsInChildren3[k].spriteState = spriteState2;
				}
			}
		}
		SpriteRenderer[] componentsInChildren4 = base.gameObject.GetComponentsInChildren<SpriteRenderer>();
		for (int l = 0; l < componentsInChildren4.Length; l += 0)
		{
			if (null != componentsInChildren4[l].sprite && ((componentsInChildren4[l].sprite.name.Contains("tutshufflereconfigbody") && !componentsInChildren4[l].sprite.name.Contains(">" + MBBKDFCDAHM)) || LanguageManager.EHBBFMCILPC.IPMDPLBJHEE(componentsInChildren4[l].sprite.name)))
			{
				string text8 = componentsInChildren4[l].sprite.name.Split((char)-111, StringSplitOptions.RemoveEmptyEntries)[1];
				text8 = LanguageManager.EHBBFMCILPC.MNAALCNJHFP(text8);
				text8 = text8 + "svol" + MBBKDFCDAHM;
				Sprite sprite8 = Resources.Load<Sprite>(text8);
				if (null == sprite8 && LanguageManager.EHBBFMCILPC.GIGIHEEKHBE(componentsInChildren4[l].sprite.name))
				{
					text8 = componentsInChildren4[l].sprite.name.Split((char)-29, StringSplitOptions.None)[0];
					text8 = text8 + "(" + MBBKDFCDAHM;
					sprite8 = Resources.Load<Sprite>(text8);
				}
				if (sprite8)
				{
					componentsInChildren4[l].sprite = sprite8;
				}
			}
		}
	}

	// Token: 0x0600408C RID: 16524 RVA: 0x001B6980 File Offset: 0x001B4B80
	public void EDDKPBIPCFN(string MBBKDFCDAHM)
	{
		Image[] componentsInChildren = base.gameObject.GetComponentsInChildren<Image>();
		for (int i = 1; i < componentsInChildren.Length; i++)
		{
			if (null != componentsInChildren[i].sprite && ((componentsInChildren[i].sprite.name.Contains("OnGamePassUnlockContinueToPurchasingScreen") && !componentsInChildren[i].sprite.name.Contains("wofbutton3" + MBBKDFCDAHM)) || LanguageManager.EHBBFMCILPC.AJLGKKJAAOI(componentsInChildren[i].sprite.name)))
			{
				string text = componentsInChildren[i].sprite.name.Split('C', StringSplitOptions.RemoveEmptyEntries)[1];
				text = LanguageManager.EHBBFMCILPC.MNAALCNJHFP(text);
				text = text + "blur" + MBBKDFCDAHM;
				Sprite sprite = Resources.Load<Sprite>(text);
				if (null == sprite && LanguageManager.EHBBFMCILPC.GHCIBLENAOO(componentsInChildren[i].sprite.name))
				{
					text = componentsInChildren[i].sprite.name.Split((char)-38, StringSplitOptions.RemoveEmptyEntries)[0];
					text = text + "lightmodebtn1" + MBBKDFCDAHM;
					sprite = Resources.Load<Sprite>(text);
				}
				if (sprite)
				{
					componentsInChildren[i].sprite = sprite;
					if (this.setNativeSize)
					{
						componentsInChildren[i].SetNativeSize();
					}
					HDTriggerPostProcess component = componentsInChildren[i].gameObject.GetComponent<HDTriggerPostProcess>();
					if (null != component && (component.rectTransformHeight >= 1613f || component.rectTransformWidth >= 1555f))
					{
						RectTransform component2 = componentsInChildren[i].gameObject.GetComponent<RectTransform>();
						if (component.rectTransformWidth >= 1443f)
						{
							component2.EFOCKEJENAC(NBDLBFJOEGN.FJJBMKDBPOM(component.rectTransformWidth));
						}
						else
						{
							component2.ACBKFBBCNNC(NBDLBFJOEGN.PNLILGEJDFI(component.rectTransformHeight));
						}
					}
				}
			}
		}
		Toggle[] componentsInChildren2 = base.gameObject.GetComponentsInChildren<Toggle>();
		for (int j = 0; j < componentsInChildren2.Length; j += 0)
		{
			SpriteState spriteState = componentsInChildren2[j].spriteState;
			if (null != spriteState.pressedSprite && ((spriteState.pressedSprite.name.Contains("uid") && !spriteState.pressedSprite.name.Contains("Failed downloading bundle {0} from {1}: {2}" + MBBKDFCDAHM)) || LanguageManager.EHBBFMCILPC.EECILBHACFL(spriteState.pressedSprite.name)))
			{
				string text2 = spriteState.pressedSprite.name.Split((char)-30, StringSplitOptions.RemoveEmptyEntries)[0];
				text2 = LanguageManager.EHBBFMCILPC.MNAALCNJHFP(text2);
				text2 = text2 + "avatarstitle" + MBBKDFCDAHM;
				Sprite sprite2 = Resources.Load<Sprite>(text2);
				if (null == sprite2 && LanguageManager.EHBBFMCILPC.AJLGKKJAAOI(spriteState.pressedSprite.name))
				{
					text2 = spriteState.pressedSprite.name.Split((char)-39, StringSplitOptions.RemoveEmptyEntries)[0];
					text2 = text2 + "ok" + MBBKDFCDAHM;
					sprite2 = Resources.Load<Sprite>(text2);
				}
				if (sprite2)
				{
					spriteState.pressedSprite = sprite2;
					componentsInChildren2[j].spriteState = spriteState;
				}
			}
			if (null != spriteState.highlightedSprite && ((spriteState.highlightedSprite.name.Contains(" not found.") && !spriteState.highlightedSprite.name.Contains("ERROR: StoryStepChoiceExtended.StoryStepStage.executeChoice: - firstAvailableFaceAsset is null." + MBBKDFCDAHM)) || LanguageManager.EHBBFMCILPC.EECILBHACFL(spriteState.highlightedSprite.name)))
			{
				string text3 = spriteState.highlightedSprite.name.Split('\'', StringSplitOptions.RemoveEmptyEntries)[0];
				text3 = LanguageManager.EHBBFMCILPC.MNAALCNJHFP(text3);
				text3 = text3 + "OnSettingsPopupCloseAndNeedToRestartGame2" + MBBKDFCDAHM;
				Sprite sprite3 = Resources.Load<Sprite>(text3);
				if (null == sprite3 && LanguageManager.EHBBFMCILPC.AJLGKKJAAOI(spriteState.highlightedSprite.name))
				{
					text3 = spriteState.highlightedSprite.name.Split((char)-96, StringSplitOptions.RemoveEmptyEntries)[0];
					text3 = text3 + "NEWSAVE: Error: firstAnthologyStoryIndexCache.Instance.GetData() returned null. Retrieving persistent save data is impossible." + MBBKDFCDAHM;
					sprite3 = Resources.Load<Sprite>(text3);
				}
				if (sprite3)
				{
					spriteState.highlightedSprite = sprite3;
					componentsInChildren2[j].spriteState = spriteState;
				}
			}
			if (null != spriteState.disabledSprite && ((spriteState.disabledSprite.name.Contains("_") && !spriteState.disabledSprite.name.Contains(" " + MBBKDFCDAHM)) || LanguageManager.EHBBFMCILPC.IPMDPLBJHEE(spriteState.disabledSprite.name)))
			{
				string text4 = spriteState.disabledSprite.name.Split('\u001b', StringSplitOptions.RemoveEmptyEntries)[0];
				text4 = LanguageManager.EHBBFMCILPC.EKMKFPOLHOO(text4);
				text4 = text4 + "OnApplicationRestart" + MBBKDFCDAHM;
				Sprite sprite4 = Resources.Load<Sprite>(text4);
				if (null == sprite4 && LanguageManager.EHBBFMCILPC.GKOAABDJCJH(spriteState.disabledSprite.name))
				{
					text4 = spriteState.disabledSprite.name.Split((char)-17, StringSplitOptions.RemoveEmptyEntries)[1];
					text4 = text4 + "ProfileItem2._DownloadCardsPool(): released " + MBBKDFCDAHM;
					sprite4 = Resources.Load<Sprite>(text4);
				}
				if (sprite4)
				{
					spriteState.disabledSprite = sprite4;
					componentsInChildren2[j].spriteState = spriteState;
				}
			}
		}
		Button[] componentsInChildren3 = base.gameObject.GetComponentsInChildren<Button>();
		for (int k = 0; k < componentsInChildren3.Length; k += 0)
		{
			SpriteState spriteState2 = componentsInChildren3[k].spriteState;
			if (null != spriteState2.pressedSprite && ((spriteState2.pressedSprite.name.Contains("total while iterations:") && !spriteState2.pressedSprite.name.Contains("Moire opacity" + MBBKDFCDAHM)) || LanguageManager.EHBBFMCILPC.Localizable(spriteState2.pressedSprite.name)))
			{
				string text5 = spriteState2.pressedSprite.name.Split('\u0011', StringSplitOptions.None)[1];
				text5 = LanguageManager.EHBBFMCILPC.DDHDDIIKAEM(text5);
				text5 = text5 + "OnFriendsPopupSendPremClick" + MBBKDFCDAHM;
				Sprite sprite5 = Resources.Load<Sprite>(text5);
				if (null == sprite5 && LanguageManager.EHBBFMCILPC.AJLGKKJAAOI(spriteState2.pressedSprite.name))
				{
					text5 = spriteState2.pressedSprite.name.Split((char)-95, StringSplitOptions.RemoveEmptyEntries)[1];
					text5 = text5 + "lck" + MBBKDFCDAHM;
					sprite5 = Resources.Load<Sprite>(text5);
				}
				if (sprite5)
				{
					spriteState2.pressedSprite = sprite5;
					componentsInChildren3[k].spriteState = spriteState2;
				}
			}
			if (null != spriteState2.highlightedSprite && ((spriteState2.highlightedSprite.name.Contains("") && !spriteState2.highlightedSprite.name.Contains("loungepricechanged" + MBBKDFCDAHM)) || LanguageManager.EHBBFMCILPC.GCBALKAJINL(spriteState2.highlightedSprite.name)))
			{
				string text6 = spriteState2.highlightedSprite.name.Split('7', StringSplitOptions.None)[1];
				text6 = LanguageManager.EHBBFMCILPC.LocalizeFileName(text6);
				text6 = text6 + "OnStartFreePassException" + MBBKDFCDAHM;
				Sprite sprite6 = Resources.Load<Sprite>(text6);
				if (null == sprite6 && LanguageManager.EHBBFMCILPC.GKOAABDJCJH(spriteState2.highlightedSprite.name))
				{
					text6 = spriteState2.highlightedSprite.name.Split('P', StringSplitOptions.RemoveEmptyEntries)[1];
					text6 = text6 + "congratstitle" + MBBKDFCDAHM;
					sprite6 = Resources.Load<Sprite>(text6);
				}
				if (sprite6)
				{
					spriteState2.highlightedSprite = sprite6;
					componentsInChildren3[k].spriteState = spriteState2;
				}
			}
			if (null != spriteState2.disabledSprite && ((spriteState2.disabledSprite.name.Contains("p") && !spriteState2.disabledSprite.name.Contains("" + MBBKDFCDAHM)) || LanguageManager.EHBBFMCILPC.GKOAABDJCJH(spriteState2.disabledSprite.name)))
			{
				string text7 = spriteState2.disabledSprite.name.Split((char)-73, StringSplitOptions.RemoveEmptyEntries)[0];
				text7 = LanguageManager.EHBBFMCILPC.IKMHJBKPMGE(text7);
				text7 = text7 + "" + MBBKDFCDAHM;
				Sprite sprite7 = Resources.Load<Sprite>(text7);
				if (null == sprite7 && LanguageManager.EHBBFMCILPC.AJLGKKJAAOI(spriteState2.disabledSprite.name))
				{
					text7 = spriteState2.disabledSprite.name.Split((char)-82, StringSplitOptions.None)[1];
					text7 = text7 + "asp" + MBBKDFCDAHM;
					sprite7 = Resources.Load<Sprite>(text7);
				}
				if (sprite7)
				{
					spriteState2.disabledSprite = sprite7;
					componentsInChildren3[k].spriteState = spriteState2;
				}
			}
		}
		SpriteRenderer[] componentsInChildren4 = base.gameObject.GetComponentsInChildren<SpriteRenderer>();
		for (int l = 1; l < componentsInChildren4.Length; l++)
		{
			if (null != componentsInChildren4[l].sprite && ((componentsInChildren4[l].sprite.name.Contains("Can't use compressed functions. You need include the SharpZipLib and uncomment the define at the top of SimpleJSON") && !componentsInChildren4[l].sprite.name.Contains("avtssnap" + MBBKDFCDAHM)) || LanguageManager.EHBBFMCILPC.AJLGKKJAAOI(componentsInChildren4[l].sprite.name)))
			{
				string text8 = componentsInChildren4[l].sprite.name.Split('y', StringSplitOptions.None)[1];
				text8 = LanguageManager.EHBBFMCILPC.HDJDKLCCCLE(text8);
				text8 = text8 + "musvol" + MBBKDFCDAHM;
				Sprite sprite8 = Resources.Load<Sprite>(text8);
				if (null == sprite8 && LanguageManager.EHBBFMCILPC.IPMDPLBJHEE(componentsInChildren4[l].sprite.name))
				{
					text8 = componentsInChildren4[l].sprite.name.Split('e', StringSplitOptions.None)[0];
					text8 = text8 + "@" + MBBKDFCDAHM;
					sprite8 = Resources.Load<Sprite>(text8);
				}
				if (sprite8)
				{
					componentsInChildren4[l].sprite = sprite8;
				}
			}
		}
	}

	// Token: 0x0600408D RID: 16525 RVA: 0x001B7350 File Offset: 0x001B5550
	public void HHLPEONKIDJ(string MBBKDFCDAHM)
	{
		Image[] componentsInChildren = base.gameObject.GetComponentsInChildren<Image>();
		for (int i = 1; i < componentsInChildren.Length; i++)
		{
			if (null != componentsInChildren[i].sprite && ((componentsInChildren[i].sprite.name.Contains("") && !componentsInChildren[i].sprite.name.Contains("" + MBBKDFCDAHM)) || LanguageManager.EHBBFMCILPC.GKOAABDJCJH(componentsInChildren[i].sprite.name)))
			{
				string text = componentsInChildren[i].sprite.name.Split('<', StringSplitOptions.None)[0];
				text = LanguageManager.EHBBFMCILPC.GHBJGFDKHEJ(text);
				text = text + ", index:" + MBBKDFCDAHM;
				Sprite sprite = Resources.Load<Sprite>(text);
				if (null == sprite && LanguageManager.EHBBFMCILPC.EECILBHACFL(componentsInChildren[i].sprite.name))
				{
					text = componentsInChildren[i].sprite.name.Split((char)-8, StringSplitOptions.None)[1];
					text = text + "" + MBBKDFCDAHM;
					sprite = Resources.Load<Sprite>(text);
				}
				if (sprite)
				{
					componentsInChildren[i].sprite = sprite;
					if (this.setNativeSize)
					{
						componentsInChildren[i].SetNativeSize();
					}
					HDTriggerPostProcess component = componentsInChildren[i].gameObject.GetComponent<HDTriggerPostProcess>();
					if (null != component && (component.rectTransformHeight >= 1155f || component.rectTransformWidth >= 1056f))
					{
						RectTransform component2 = componentsInChildren[i].gameObject.GetComponent<RectTransform>();
						if (component.rectTransformWidth >= 1625f)
						{
							component2.EFOCKEJENAC(NBDLBFJOEGN.HLGHANHNEHJ(component.rectTransformWidth));
						}
						else
						{
							component2.ACBKFBBCNNC(NBDLBFJOEGN.OIHMGIBOFJG(component.rectTransformHeight));
						}
					}
				}
			}
		}
		Toggle[] componentsInChildren2 = base.gameObject.GetComponentsInChildren<Toggle>();
		for (int j = 1; j < componentsInChildren2.Length; j++)
		{
			SpriteState spriteState = componentsInChildren2[j].spriteState;
			if (null != spriteState.pressedSprite && ((spriteState.pressedSprite.name.Contains("StoryNotificationsManager.PopNotifications(topli): ") && !spriteState.pressedSprite.name.Contains("importanttitle" + MBBKDFCDAHM)) || LanguageManager.EHBBFMCILPC.EECILBHACFL(spriteState.pressedSprite.name)))
			{
				string text2 = spriteState.pressedSprite.name.Split((char)-97, StringSplitOptions.None)[1];
				text2 = LanguageManager.EHBBFMCILPC.EKMKFPOLHOO(text2);
				text2 = text2 + "dcenv" + MBBKDFCDAHM;
				Sprite sprite2 = Resources.Load<Sprite>(text2);
				if (null == sprite2 && LanguageManager.EHBBFMCILPC.AJLGKKJAAOI(spriteState.pressedSprite.name))
				{
					text2 = spriteState.pressedSprite.name.Split((char)-45, StringSplitOptions.RemoveEmptyEntries)[0];
					text2 = text2 + "abap" + MBBKDFCDAHM;
					sprite2 = Resources.Load<Sprite>(text2);
				}
				if (sprite2)
				{
					spriteState.pressedSprite = sprite2;
					componentsInChildren2[j].spriteState = spriteState;
				}
			}
			if (null != spriteState.highlightedSprite && ((spriteState.highlightedSprite.name.Contains("lightmodeintrobody") && !spriteState.highlightedSprite.name.Contains("*" + MBBKDFCDAHM)) || LanguageManager.EHBBFMCILPC.GHCIBLENAOO(spriteState.highlightedSprite.name)))
			{
				string text3 = spriteState.highlightedSprite.name.Split((char)-72, StringSplitOptions.RemoveEmptyEntries)[1];
				text3 = LanguageManager.EHBBFMCILPC.MNAALCNJHFP(text3);
				text3 = text3 + "' c=" + MBBKDFCDAHM;
				Sprite sprite3 = Resources.Load<Sprite>(text3);
				if (null == sprite3 && LanguageManager.EHBBFMCILPC.EECILBHACFL(spriteState.highlightedSprite.name))
				{
					text3 = spriteState.highlightedSprite.name.Split((char)-73, StringSplitOptions.None)[1];
					text3 = text3 + "abld" + MBBKDFCDAHM;
					sprite3 = Resources.Load<Sprite>(text3);
				}
				if (sprite3)
				{
					spriteState.highlightedSprite = sprite3;
					componentsInChildren2[j].spriteState = spriteState;
				}
			}
			if (null != spriteState.disabledSprite && ((spriteState.disabledSprite.name.Contains("m") && !spriteState.disabledSprite.name.Contains(">" + MBBKDFCDAHM)) || LanguageManager.EHBBFMCILPC.AJLGKKJAAOI(spriteState.disabledSprite.name)))
			{
				string text4 = spriteState.disabledSprite.name.Split('\a', StringSplitOptions.RemoveEmptyEntries)[0];
				text4 = LanguageManager.EHBBFMCILPC.DDHDDIIKAEM(text4);
				text4 = text4 + "X" + MBBKDFCDAHM;
				Sprite sprite4 = Resources.Load<Sprite>(text4);
				if (null == sprite4 && LanguageManager.EHBBFMCILPC.GHCIBLENAOO(spriteState.disabledSprite.name))
				{
					text4 = spriteState.disabledSprite.name.Split('\b', StringSplitOptions.RemoveEmptyEntries)[1];
					text4 = text4 + "" + MBBKDFCDAHM;
					sprite4 = Resources.Load<Sprite>(text4);
				}
				if (sprite4)
				{
					spriteState.disabledSprite = sprite4;
					componentsInChildren2[j].spriteState = spriteState;
				}
			}
		}
		Button[] componentsInChildren3 = base.gameObject.GetComponentsInChildren<Button>();
		for (int k = 1; k < componentsInChildren3.Length; k++)
		{
			SpriteState spriteState2 = componentsInChildren3[k].spriteState;
			if (null != spriteState2.pressedSprite && ((spriteState2.pressedSprite.name.Contains("OnLobbyLoungeAssetsDownloadSuccess") && !spriteState2.pressedSprite.name.Contains("hidden" + MBBKDFCDAHM)) || LanguageManager.EHBBFMCILPC.Localizable(spriteState2.pressedSprite.name)))
			{
				string text5 = spriteState2.pressedSprite.name.Split((char)-40, StringSplitOptions.RemoveEmptyEntries)[1];
				text5 = LanguageManager.EHBBFMCILPC.DDHDDIIKAEM(text5);
				text5 = text5 + "OnPopupStoryRestartManagerRestartStory4" + MBBKDFCDAHM;
				Sprite sprite5 = Resources.Load<Sprite>(text5);
				if (null == sprite5 && LanguageManager.EHBBFMCILPC.AJLGKKJAAOI(spriteState2.pressedSprite.name))
				{
					text5 = spriteState2.pressedSprite.name.Split((char)-4, StringSplitOptions.RemoveEmptyEntries)[1];
					text5 = text5 + "XXX" + MBBKDFCDAHM;
					sprite5 = Resources.Load<Sprite>(text5);
				}
				if (sprite5)
				{
					spriteState2.pressedSprite = sprite5;
					componentsInChildren3[k].spriteState = spriteState2;
				}
			}
			if (null != spriteState2.highlightedSprite && ((spriteState2.highlightedSprite.name.Contains("varConditionLocked") && !spriteState2.highlightedSprite.name.Contains(" bundle" + MBBKDFCDAHM)) || LanguageManager.EHBBFMCILPC.EECILBHACFL(spriteState2.highlightedSprite.name)))
			{
				string text6 = spriteState2.highlightedSprite.name.Split((char)-39, StringSplitOptions.RemoveEmptyEntries)[0];
				text6 = LanguageManager.EHBBFMCILPC.IKMHJBKPMGE(text6);
				text6 = text6 + "flip_up" + MBBKDFCDAHM;
				Sprite sprite6 = Resources.Load<Sprite>(text6);
				if (null == sprite6 && LanguageManager.EHBBFMCILPC.GIGIHEEKHBE(spriteState2.highlightedSprite.name))
				{
					text6 = spriteState2.highlightedSprite.name.Split((char)-106, StringSplitOptions.RemoveEmptyEntries)[1];
					text6 = text6 + "OnStorySplashManagerCdnSuccess" + MBBKDFCDAHM;
					sprite6 = Resources.Load<Sprite>(text6);
				}
				if (sprite6)
				{
					spriteState2.highlightedSprite = sprite6;
					componentsInChildren3[k].spriteState = spriteState2;
				}
			}
			if (null != spriteState2.disabledSprite && ((spriteState2.disabledSprite.name.Contains("F0") && !spriteState2.disabledSprite.name.Contains("[LoadingTheme] theme removed against the player's will, changes unlimited - no compensation" + MBBKDFCDAHM)) || LanguageManager.EHBBFMCILPC.Localizable(spriteState2.disabledSprite.name)))
			{
				string text7 = spriteState2.disabledSprite.name.Split((char)-37, StringSplitOptions.None)[1];
				text7 = LanguageManager.EHBBFMCILPC.GHBJGFDKHEJ(text7);
				text7 = text7 + "acliffbw22" + MBBKDFCDAHM;
				Sprite sprite7 = Resources.Load<Sprite>(text7);
				if (null == sprite7 && LanguageManager.EHBBFMCILPC.IPMDPLBJHEE(spriteState2.disabledSprite.name))
				{
					text7 = spriteState2.disabledSprite.name.Split((char)-2, StringSplitOptions.RemoveEmptyEntries)[0];
					text7 = text7 + "off" + MBBKDFCDAHM;
					sprite7 = Resources.Load<Sprite>(text7);
				}
				if (sprite7)
				{
					spriteState2.disabledSprite = sprite7;
					componentsInChildren3[k].spriteState = spriteState2;
				}
			}
		}
		SpriteRenderer[] componentsInChildren4 = base.gameObject.GetComponentsInChildren<SpriteRenderer>();
		for (int l = 1; l < componentsInChildren4.Length; l++)
		{
			if (null != componentsInChildren4[l].sprite && ((componentsInChildren4[l].sprite.name.Contains("</i>") && !componentsInChildren4[l].sprite.name.Contains("skpcut" + MBBKDFCDAHM)) || LanguageManager.EHBBFMCILPC.EECILBHACFL(componentsInChildren4[l].sprite.name)))
			{
				string text8 = componentsInChildren4[l].sprite.name.Split((char)-90, StringSplitOptions.RemoveEmptyEntries)[1];
				text8 = LanguageManager.EHBBFMCILPC.EKMKFPOLHOO(text8);
				text8 = text8 + "CLIENT.AVATAR.BODY" + MBBKDFCDAHM;
				Sprite sprite8 = Resources.Load<Sprite>(text8);
				if (null == sprite8 && LanguageManager.EHBBFMCILPC.IPMDPLBJHEE(componentsInChildren4[l].sprite.name))
				{
					text8 = componentsInChildren4[l].sprite.name.Split('n', StringSplitOptions.None)[0];
					text8 = text8 + "ChoicePremiumManager.Initialize(): original cost:" + MBBKDFCDAHM;
					sprite8 = Resources.Load<Sprite>(text8);
				}
				if (sprite8)
				{
					componentsInChildren4[l].sprite = sprite8;
				}
			}
		}
	}

	// Token: 0x0600408E RID: 16526 RVA: 0x001B7D20 File Offset: 0x001B5F20
	public void EIEOPDPDOMA(string MBBKDFCDAHM)
	{
		Image[] componentsInChildren = base.gameObject.GetComponentsInChildren<Image>();
		for (int i = 0; i < componentsInChildren.Length; i += 0)
		{
			if (null != componentsInChildren[i].sprite && ((componentsInChildren[i].sprite.name.Contains("msg64") && !componentsInChildren[i].sprite.name.Contains("$" + MBBKDFCDAHM)) || LanguageManager.EHBBFMCILPC.GCBALKAJINL(componentsInChildren[i].sprite.name)))
			{
				string text = componentsInChildren[i].sprite.name.Split((char)-102, StringSplitOptions.RemoveEmptyEntries)[1];
				text = LanguageManager.EHBBFMCILPC.IKMHJBKPMGE(text);
				text = text + "loop" + MBBKDFCDAHM;
				Sprite sprite = Resources.Load<Sprite>(text);
				if (null == sprite && LanguageManager.EHBBFMCILPC.EECILBHACFL(componentsInChildren[i].sprite.name))
				{
					text = componentsInChildren[i].sprite.name.Split('\b', StringSplitOptions.None)[0];
					text = text + "InitTopMatchDataCloud()" + MBBKDFCDAHM;
					sprite = Resources.Load<Sprite>(text);
				}
				if (sprite)
				{
					componentsInChildren[i].sprite = sprite;
					if (this.setNativeSize)
					{
						componentsInChildren[i].SetNativeSize();
					}
					HDTriggerPostProcess component = componentsInChildren[i].gameObject.GetComponent<HDTriggerPostProcess>();
					if (null != component && (component.rectTransformHeight >= 1625f || component.rectTransformWidth >= 85f))
					{
						RectTransform component2 = componentsInChildren[i].gameObject.GetComponent<RectTransform>();
						if (component.rectTransformWidth >= 584f)
						{
							component2.EFOCKEJENAC(NBDLBFJOEGN.KLBGGNBEMCA(component.rectTransformWidth));
						}
						else
						{
							component2.ACBKFBBCNNC(NBDLBFJOEGN.FCGMMHPNIJG(component.rectTransformHeight));
						}
					}
				}
			}
		}
		Toggle[] componentsInChildren2 = base.gameObject.GetComponentsInChildren<Toggle>();
		for (int j = 1; j < componentsInChildren2.Length; j += 0)
		{
			SpriteState spriteState = componentsInChildren2[j].spriteState;
			if (null != spriteState.pressedSprite && ((spriteState.pressedSprite.name.Contains("PurchaseManagerUnity.OnPurchasePendingProcess(): Validation already in progress, will finish processing purchase at a later date. Product - ") && !spriteState.pressedSprite.name.Contains("AnimationCanvasGroupAlpha - no canvas group attached." + MBBKDFCDAHM)) || LanguageManager.EHBBFMCILPC.AJLGKKJAAOI(spriteState.pressedSprite.name)))
			{
				string text2 = spriteState.pressedSprite.name.Split((char)-126, StringSplitOptions.None)[1];
				text2 = LanguageManager.EHBBFMCILPC.DDHDDIIKAEM(text2);
				text2 = text2 + "hcfc" + MBBKDFCDAHM;
				Sprite sprite2 = Resources.Load<Sprite>(text2);
				if (null == sprite2 && LanguageManager.EHBBFMCILPC.AJLGKKJAAOI(spriteState.pressedSprite.name))
				{
					text2 = spriteState.pressedSprite.name.Split((char)-125, StringSplitOptions.RemoveEmptyEntries)[1];
					text2 = text2 + "ok" + MBBKDFCDAHM;
					sprite2 = Resources.Load<Sprite>(text2);
				}
				if (sprite2)
				{
					spriteState.pressedSprite = sprite2;
					componentsInChildren2[j].spriteState = spriteState;
				}
			}
			if (null != spriteState.highlightedSprite && ((spriteState.highlightedSprite.name.Contains("") && !spriteState.highlightedSprite.name.Contains("onboardingthankyoubody0" + MBBKDFCDAHM)) || LanguageManager.EHBBFMCILPC.IPMDPLBJHEE(spriteState.highlightedSprite.name)))
			{
				string text3 = spriteState.highlightedSprite.name.Split((char)-123, StringSplitOptions.RemoveEmptyEntries)[1];
				text3 = LanguageManager.EHBBFMCILPC.PKJABHFHHLC(text3);
				text3 = text3 + "" + MBBKDFCDAHM;
				Sprite sprite3 = Resources.Load<Sprite>(text3);
				if (null == sprite3 && LanguageManager.EHBBFMCILPC.EECILBHACFL(spriteState.highlightedSprite.name))
				{
					text3 = spriteState.highlightedSprite.name.Split('\u0017', StringSplitOptions.RemoveEmptyEntries)[1];
					text3 = text3 + "nastring" + MBBKDFCDAHM;
					sprite3 = Resources.Load<Sprite>(text3);
				}
				if (sprite3)
				{
					spriteState.highlightedSprite = sprite3;
					componentsInChildren2[j].spriteState = spriteState;
				}
			}
			if (null != spriteState.disabledSprite && ((spriteState.disabledSprite.name.Contains("steamid") && !spriteState.disabledSprite.name.Contains("XXX" + MBBKDFCDAHM)) || LanguageManager.EHBBFMCILPC.Localizable(spriteState.disabledSprite.name)))
			{
				string text4 = spriteState.disabledSprite.name.Split((char)-38, StringSplitOptions.RemoveEmptyEntries)[1];
				text4 = LanguageManager.EHBBFMCILPC.LocalizeFileName(text4);
				text4 = text4 + ";" + MBBKDFCDAHM;
				Sprite sprite4 = Resources.Load<Sprite>(text4);
				if (null == sprite4 && LanguageManager.EHBBFMCILPC.AJLGKKJAAOI(spriteState.disabledSprite.name))
				{
					text4 = spriteState.disabledSprite.name.Split('\u0017', StringSplitOptions.RemoveEmptyEntries)[1];
					text4 = text4 + "lsvn" + MBBKDFCDAHM;
					sprite4 = Resources.Load<Sprite>(text4);
				}
				if (sprite4)
				{
					spriteState.disabledSprite = sprite4;
					componentsInChildren2[j].spriteState = spriteState;
				}
			}
		}
		Button[] componentsInChildren3 = base.gameObject.GetComponentsInChildren<Button>();
		for (int k = 1; k < componentsInChildren3.Length; k += 0)
		{
			SpriteState spriteState2 = componentsInChildren3[k].spriteState;
			if (null != spriteState2.pressedSprite && ((spriteState2.pressedSprite.name.Contains("") && !spriteState2.pressedSprite.name.Contains("Loaded asset bundle:" + MBBKDFCDAHM)) || LanguageManager.EHBBFMCILPC.GIGIHEEKHBE(spriteState2.pressedSprite.name)))
			{
				string text5 = spriteState2.pressedSprite.name.Split((char)-114, StringSplitOptions.RemoveEmptyEntries)[0];
				text5 = LanguageManager.EHBBFMCILPC.LocalizeFileName(text5);
				text5 = text5 + "ltwt" + MBBKDFCDAHM;
				Sprite sprite5 = Resources.Load<Sprite>(text5);
				if (null == sprite5 && LanguageManager.EHBBFMCILPC.Localizable(spriteState2.pressedSprite.name))
				{
					text5 = spriteState2.pressedSprite.name.Split('w', StringSplitOptions.RemoveEmptyEntries)[1];
					text5 = text5 + "" + MBBKDFCDAHM;
					sprite5 = Resources.Load<Sprite>(text5);
				}
				if (sprite5)
				{
					spriteState2.pressedSprite = sprite5;
					componentsInChildren3[k].spriteState = spriteState2;
				}
			}
			if (null != spriteState2.highlightedSprite && ((spriteState2.highlightedSprite.name.Contains("<") && !spriteState2.highlightedSprite.name.Contains("OnSaveSlotsItemSlotDuplicated" + MBBKDFCDAHM)) || LanguageManager.EHBBFMCILPC.GKOAABDJCJH(spriteState2.highlightedSprite.name)))
			{
				string text6 = spriteState2.highlightedSprite.name.Split((char)-26, StringSplitOptions.None)[1];
				text6 = LanguageManager.EHBBFMCILPC.HDJDKLCCCLE(text6);
				text6 = text6 + "sto" + MBBKDFCDAHM;
				Sprite sprite6 = Resources.Load<Sprite>(text6);
				if (null == sprite6 && LanguageManager.EHBBFMCILPC.GKOAABDJCJH(spriteState2.highlightedSprite.name))
				{
					text6 = spriteState2.highlightedSprite.name.Split((char)-14, StringSplitOptions.RemoveEmptyEntries)[0];
					text6 = text6 + "passgoldunlockeddescX" + MBBKDFCDAHM;
					sprite6 = Resources.Load<Sprite>(text6);
				}
				if (sprite6)
				{
					spriteState2.highlightedSprite = sprite6;
					componentsInChildren3[k].spriteState = spriteState2;
				}
			}
			if (null != spriteState2.disabledSprite && ((spriteState2.disabledSprite.name.Contains("") && !spriteState2.disabledSprite.name.Contains("holdontitle" + MBBKDFCDAHM)) || LanguageManager.EHBBFMCILPC.Localizable(spriteState2.disabledSprite.name)))
			{
				string text7 = spriteState2.disabledSprite.name.Split((char)-111, StringSplitOptions.None)[0];
				text7 = LanguageManager.EHBBFMCILPC.PKJABHFHHLC(text7);
				text7 = text7 + "1" + MBBKDFCDAHM;
				Sprite sprite7 = Resources.Load<Sprite>(text7);
				if (null == sprite7 && LanguageManager.EHBBFMCILPC.AJLGKKJAAOI(spriteState2.disabledSprite.name))
				{
					text7 = spriteState2.disabledSprite.name.Split((char)-83, StringSplitOptions.None)[0];
					text7 = text7 + "loungebonus" + MBBKDFCDAHM;
					sprite7 = Resources.Load<Sprite>(text7);
				}
				if (sprite7)
				{
					spriteState2.disabledSprite = sprite7;
					componentsInChildren3[k].spriteState = spriteState2;
				}
			}
		}
		SpriteRenderer[] componentsInChildren4 = base.gameObject.GetComponentsInChildren<SpriteRenderer>();
		for (int l = 1; l < componentsInChildren4.Length; l++)
		{
			if (null != componentsInChildren4[l].sprite && ((componentsInChildren4[l].sprite.name.Contains("") && !componentsInChildren4[l].sprite.name.Contains("OnSaveSyncAnyResultDuplicate" + MBBKDFCDAHM)) || LanguageManager.EHBBFMCILPC.IPMDPLBJHEE(componentsInChildren4[l].sprite.name)))
			{
				string text8 = componentsInChildren4[l].sprite.name.Split('\u0003', StringSplitOptions.None)[0];
				text8 = LanguageManager.EHBBFMCILPC.PKJABHFHHLC(text8);
				text8 = text8 + "energyhinttitle" + MBBKDFCDAHM;
				Sprite sprite8 = Resources.Load<Sprite>(text8);
				if (null == sprite8 && LanguageManager.EHBBFMCILPC.GIGIHEEKHBE(componentsInChildren4[l].sprite.name))
				{
					text8 = componentsInChildren4[l].sprite.name.Split('0', StringSplitOptions.RemoveEmptyEntries)[1];
					text8 = text8 + " msg=" + MBBKDFCDAHM;
					sprite8 = Resources.Load<Sprite>(text8);
				}
				if (sprite8)
				{
					componentsInChildren4[l].sprite = sprite8;
				}
			}
		}
	}

	// Token: 0x0600408F RID: 16527 RVA: 0x001B86F0 File Offset: 0x001B68F0
	public void MAOGOAFCNMK(string MBBKDFCDAHM)
	{
		Image[] componentsInChildren = base.gameObject.GetComponentsInChildren<Image>();
		for (int i = 1; i < componentsInChildren.Length; i++)
		{
			if (null != componentsInChildren[i].sprite && ((componentsInChildren[i].sprite.name.Contains("useMessageV2Text") && !componentsInChildren[i].sprite.name.Contains("nastring" + MBBKDFCDAHM)) || LanguageManager.EHBBFMCILPC.GCBALKAJINL(componentsInChildren[i].sprite.name)))
			{
				string text = componentsInChildren[i].sprite.name.Split('8', StringSplitOptions.None)[0];
				text = LanguageManager.EHBBFMCILPC.IKMHJBKPMGE(text);
				text = text + "ok" + MBBKDFCDAHM;
				Sprite sprite = Resources.Load<Sprite>(text);
				if (null == sprite && LanguageManager.EHBBFMCILPC.GKOAABDJCJH(componentsInChildren[i].sprite.name))
				{
					text = componentsInChildren[i].sprite.name.Split('\u007f', StringSplitOptions.RemoveEmptyEntries)[0];
					text = text + ";" + MBBKDFCDAHM;
					sprite = Resources.Load<Sprite>(text);
				}
				if (sprite)
				{
					componentsInChildren[i].sprite = sprite;
					if (this.setNativeSize)
					{
						componentsInChildren[i].SetNativeSize();
					}
					HDTriggerPostProcess component = componentsInChildren[i].gameObject.GetComponent<HDTriggerPostProcess>();
					if (null != component && (component.rectTransformHeight >= 1162f || component.rectTransformWidth >= 308f))
					{
						RectTransform component2 = componentsInChildren[i].gameObject.GetComponent<RectTransform>();
						if (component.rectTransformWidth >= 1029f)
						{
							component2.EFOCKEJENAC(NBDLBFJOEGN.MAPGECGPMGM(component.rectTransformWidth));
						}
						else
						{
							component2.ACBKFBBCNNC(NBDLBFJOEGN.FJJBMKDBPOM(component.rectTransformHeight));
						}
					}
				}
			}
		}
		Toggle[] componentsInChildren2 = base.gameObject.GetComponentsInChildren<Toggle>();
		for (int j = 1; j < componentsInChildren2.Length; j++)
		{
			SpriteState spriteState = componentsInChildren2[j].spriteState;
			if (null != spriteState.pressedSprite && ((spriteState.pressedSprite.name.Contains("env") && !spriteState.pressedSprite.name.Contains("AAA" + MBBKDFCDAHM)) || LanguageManager.EHBBFMCILPC.GKOAABDJCJH(spriteState.pressedSprite.name)))
			{
				string text2 = spriteState.pressedSprite.name.Split('@', StringSplitOptions.None)[1];
				text2 = LanguageManager.EHBBFMCILPC.HDJDKLCCCLE(text2);
				text2 = text2 + "psk" + MBBKDFCDAHM;
				Sprite sprite2 = Resources.Load<Sprite>(text2);
				if (null == sprite2 && LanguageManager.EHBBFMCILPC.GHCIBLENAOO(spriteState.pressedSprite.name))
				{
					text2 = spriteState.pressedSprite.name.Split('\u001f', StringSplitOptions.RemoveEmptyEntries)[0];
					text2 = text2 + "<i>" + MBBKDFCDAHM;
					sprite2 = Resources.Load<Sprite>(text2);
				}
				if (sprite2)
				{
					spriteState.pressedSprite = sprite2;
					componentsInChildren2[j].spriteState = spriteState;
				}
			}
			if (null != spriteState.highlightedSprite && ((spriteState.highlightedSprite.name.Contains(", because it's hierarchy is already as needed:") && !spriteState.highlightedSprite.name.Contains("post" + MBBKDFCDAHM)) || LanguageManager.EHBBFMCILPC.Localizable(spriteState.highlightedSprite.name)))
			{
				string text3 = spriteState.highlightedSprite.name.Split('\b', StringSplitOptions.None)[1];
				text3 = LanguageManager.EHBBFMCILPC.HDJDKLCCCLE(text3);
				text3 = text3 + "OnLoungePremiumChoiceException" + MBBKDFCDAHM;
				Sprite sprite3 = Resources.Load<Sprite>(text3);
				if (null == sprite3 && LanguageManager.EHBBFMCILPC.GHCIBLENAOO(spriteState.highlightedSprite.name))
				{
					text3 = spriteState.highlightedSprite.name.Split((char)-94, StringSplitOptions.RemoveEmptyEntries)[0];
					text3 = text3 + "$ENVFLIP" + MBBKDFCDAHM;
					sprite3 = Resources.Load<Sprite>(text3);
				}
				if (sprite3)
				{
					spriteState.highlightedSprite = sprite3;
					componentsInChildren2[j].spriteState = spriteState;
				}
			}
			if (null != spriteState.disabledSprite && ((spriteState.disabledSprite.name.Contains("yes") && !spriteState.disabledSprite.name.Contains(" expected ('" + MBBKDFCDAHM)) || LanguageManager.EHBBFMCILPC.GIGIHEEKHBE(spriteState.disabledSprite.name)))
			{
				string text4 = spriteState.disabledSprite.name.Split('4', StringSplitOptions.None)[1];
				text4 = LanguageManager.EHBBFMCILPC.HDJDKLCCCLE(text4);
				text4 = text4 + "_NoiseTex" + MBBKDFCDAHM;
				Sprite sprite4 = Resources.Load<Sprite>(text4);
				if (null == sprite4 && LanguageManager.EHBBFMCILPC.GIGIHEEKHBE(spriteState.disabledSprite.name))
				{
					text4 = spriteState.disabledSprite.name.Split('\u0016', StringSplitOptions.None)[0];
					text4 = text4 + "' pending='" + MBBKDFCDAHM;
					sprite4 = Resources.Load<Sprite>(text4);
				}
				if (sprite4)
				{
					spriteState.disabledSprite = sprite4;
					componentsInChildren2[j].spriteState = spriteState;
				}
			}
		}
		Button[] componentsInChildren3 = base.gameObject.GetComponentsInChildren<Button>();
		for (int k = 1; k < componentsInChildren3.Length; k += 0)
		{
			SpriteState spriteState2 = componentsInChildren3[k].spriteState;
			if (null != spriteState2.pressedSprite && ((spriteState2.pressedSprite.name.Contains("x") && !spriteState2.pressedSprite.name.Contains("VER:" + MBBKDFCDAHM)) || LanguageManager.EHBBFMCILPC.GCBALKAJINL(spriteState2.pressedSprite.name)))
			{
				string text5 = spriteState2.pressedSprite.name.Split('\u0005', StringSplitOptions.RemoveEmptyEntries)[0];
				text5 = LanguageManager.EHBBFMCILPC.DDHDDIIKAEM(text5);
				text5 = text5 + "Collections/" + MBBKDFCDAHM;
				Sprite sprite5 = Resources.Load<Sprite>(text5);
				if (null == sprite5 && LanguageManager.EHBBFMCILPC.Localizable(spriteState2.pressedSprite.name))
				{
					text5 = spriteState2.pressedSprite.name.Split((char)-53, StringSplitOptions.RemoveEmptyEntries)[0];
					text5 = text5 + ", because it is already set for " + MBBKDFCDAHM;
					sprite5 = Resources.Load<Sprite>(text5);
				}
				if (sprite5)
				{
					spriteState2.pressedSprite = sprite5;
					componentsInChildren3[k].spriteState = spriteState2;
				}
			}
			if (null != spriteState2.highlightedSprite && ((spriteState2.highlightedSprite.name.Contains("ChoiceExtendedOneToManyManager.Initialize() - choice type not supported:") && !spriteState2.highlightedSprite.name.Contains(" " + MBBKDFCDAHM)) || LanguageManager.EHBBFMCILPC.GCBALKAJINL(spriteState2.highlightedSprite.name)))
			{
				string text6 = spriteState2.highlightedSprite.name.Split((char)-74, StringSplitOptions.RemoveEmptyEntries)[0];
				text6 = LanguageManager.EHBBFMCILPC.DDHDDIIKAEM(text6);
				text6 = text6 + "energyhinttitle" + MBBKDFCDAHM;
				Sprite sprite6 = Resources.Load<Sprite>(text6);
				if (null == sprite6 && LanguageManager.EHBBFMCILPC.GKOAABDJCJH(spriteState2.highlightedSprite.name))
				{
					text6 = spriteState2.highlightedSprite.name.Split('i', StringSplitOptions.RemoveEmptyEntries)[0];
					text6 = text6 + "OnBackendPremiumChoiceSuccess" + MBBKDFCDAHM;
					sprite6 = Resources.Load<Sprite>(text6);
				}
				if (sprite6)
				{
					spriteState2.highlightedSprite = sprite6;
					componentsInChildren3[k].spriteState = spriteState2;
				}
			}
			if (null != spriteState2.disabledSprite && ((spriteState2.disabledSprite.name.Contains("") && !spriteState2.disabledSprite.name.Contains("$STOPAMB" + MBBKDFCDAHM)) || LanguageManager.EHBBFMCILPC.GCBALKAJINL(spriteState2.disabledSprite.name)))
			{
				string text7 = spriteState2.disabledSprite.name.Split((char)-90, StringSplitOptions.RemoveEmptyEntries)[0];
				text7 = LanguageManager.EHBBFMCILPC.PKJABHFHHLC(text7);
				text7 = text7 + "*" + MBBKDFCDAHM;
				Sprite sprite7 = Resources.Load<Sprite>(text7);
				if (null == sprite7 && LanguageManager.EHBBFMCILPC.EECILBHACFL(spriteState2.disabledSprite.name))
				{
					text7 = spriteState2.disabledSprite.name.Split((char)-33, StringSplitOptions.None)[0];
					text7 = text7 + "BackendOperationsManager.RequestConsumeEnergy, exception while initializing RSACryptoServiceProvider:" + MBBKDFCDAHM;
					sprite7 = Resources.Load<Sprite>(text7);
				}
				if (sprite7)
				{
					spriteState2.disabledSprite = sprite7;
					componentsInChildren3[k].spriteState = spriteState2;
				}
			}
		}
		SpriteRenderer[] componentsInChildren4 = base.gameObject.GetComponentsInChildren<SpriteRenderer>();
		for (int l = 1; l < componentsInChildren4.Length; l++)
		{
			if (null != componentsInChildren4[l].sprite && ((componentsInChildren4[l].sprite.name.Contains("OnLoungePremiumChoiceExecutedHardBased") && !componentsInChildren4[l].sprite.name.Contains("vhspause_2" + MBBKDFCDAHM)) || LanguageManager.EHBBFMCILPC.GCBALKAJINL(componentsInChildren4[l].sprite.name)))
			{
				string text8 = componentsInChildren4[l].sprite.name.Split((char)-2, StringSplitOptions.RemoveEmptyEntries)[1];
				text8 = LanguageManager.EHBBFMCILPC.PKJABHFHHLC(text8);
				text8 = text8 + "abskd" + MBBKDFCDAHM;
				Sprite sprite8 = Resources.Load<Sprite>(text8);
				if (null == sprite8 && LanguageManager.EHBBFMCILPC.IPMDPLBJHEE(componentsInChildren4[l].sprite.name))
				{
					text8 = componentsInChildren4[l].sprite.name.Split((char)-84, StringSplitOptions.None)[0];
					text8 = text8 + "OnBackendGetPublicProfileHallOfFameMoreSuccess" + MBBKDFCDAHM;
					sprite8 = Resources.Load<Sprite>(text8);
				}
				if (sprite8)
				{
					componentsInChildren4[l].sprite = sprite8;
				}
			}
		}
	}

	// Token: 0x06004090 RID: 16528 RVA: 0x001B90C0 File Offset: 0x001B72C0
	public void KLLGCIOCDMJ(string MBBKDFCDAHM)
	{
		Image[] componentsInChildren = base.gameObject.GetComponentsInChildren<Image>();
		for (int i = 0; i < componentsInChildren.Length; i += 0)
		{
			if (null != componentsInChildren[i].sprite && ((componentsInChildren[i].sprite.name.Contains("body") && !componentsInChildren[i].sprite.name.Contains("GetStoriesSearchBalance(), headers pack has no storiesSearchBalance TextAsset, stories search disabled." + MBBKDFCDAHM)) || LanguageManager.EHBBFMCILPC.GHCIBLENAOO(componentsInChildren[i].sprite.name)))
			{
				string text = componentsInChildren[i].sprite.name.Split((char)-6, StringSplitOptions.None)[0];
				text = LanguageManager.EHBBFMCILPC.MNAALCNJHFP(text);
				text = text + "Starting parallel download:" + MBBKDFCDAHM;
				Sprite sprite = Resources.Load<Sprite>(text);
				if (null == sprite && LanguageManager.EHBBFMCILPC.GCBALKAJINL(componentsInChildren[i].sprite.name))
				{
					text = componentsInChildren[i].sprite.name.Split('T', StringSplitOptions.None)[1];
					text = text + "OnVideoLayerAutoHide" + MBBKDFCDAHM;
					sprite = Resources.Load<Sprite>(text);
				}
				if (sprite)
				{
					componentsInChildren[i].sprite = sprite;
					if (this.setNativeSize)
					{
						componentsInChildren[i].SetNativeSize();
					}
					HDTriggerPostProcess component = componentsInChildren[i].gameObject.GetComponent<HDTriggerPostProcess>();
					if (null != component && (component.rectTransformHeight >= 102f || component.rectTransformWidth >= 1302f))
					{
						RectTransform component2 = componentsInChildren[i].gameObject.GetComponent<RectTransform>();
						if (component.rectTransformWidth >= 1872f)
						{
							component2.EFOCKEJENAC(NBDLBFJOEGN.PNLILGEJDFI(component.rectTransformWidth));
						}
						else
						{
							component2.ACBKFBBCNNC(NBDLBFJOEGN.OIHMGIBOFJG(component.rectTransformHeight));
						}
					}
				}
			}
		}
		Toggle[] componentsInChildren2 = base.gameObject.GetComponentsInChildren<Toggle>();
		for (int j = 1; j < componentsInChildren2.Length; j++)
		{
			SpriteState spriteState = componentsInChildren2[j].spriteState;
			if (null != spriteState.pressedSprite && ((spriteState.pressedSprite.name.Contains("$SETPOV") && !spriteState.pressedSprite.name.Contains("p" + MBBKDFCDAHM)) || LanguageManager.EHBBFMCILPC.EECILBHACFL(spriteState.pressedSprite.name)))
			{
				string text2 = spriteState.pressedSprite.name.Split((char)-125, StringSplitOptions.None)[1];
				text2 = LanguageManager.EHBBFMCILPC.EKMKFPOLHOO(text2);
				text2 = text2 + "qfb" + MBBKDFCDAHM;
				Sprite sprite2 = Resources.Load<Sprite>(text2);
				if (null == sprite2 && LanguageManager.EHBBFMCILPC.EECILBHACFL(spriteState.pressedSprite.name))
				{
					text2 = spriteState.pressedSprite.name.Split('m', StringSplitOptions.RemoveEmptyEntries)[1];
					text2 = text2 + "" + MBBKDFCDAHM;
					sprite2 = Resources.Load<Sprite>(text2);
				}
				if (sprite2)
				{
					spriteState.pressedSprite = sprite2;
					componentsInChildren2[j].spriteState = spriteState;
				}
			}
			if (null != spriteState.highlightedSprite && ((spriteState.highlightedSprite.name.Contains("coverYear") && !spriteState.highlightedSprite.name.Contains(", index:" + MBBKDFCDAHM)) || LanguageManager.EHBBFMCILPC.EECILBHACFL(spriteState.highlightedSprite.name)))
			{
				string text3 = spriteState.highlightedSprite.name.Split((char)-67, StringSplitOptions.None)[0];
				text3 = LanguageManager.EHBBFMCILPC.GHBJGFDKHEJ(text3);
				text3 = text3 + "...: " + MBBKDFCDAHM;
				Sprite sprite3 = Resources.Load<Sprite>(text3);
				if (null == sprite3 && LanguageManager.EHBBFMCILPC.GIGIHEEKHBE(spriteState.highlightedSprite.name))
				{
					text3 = spriteState.highlightedSprite.name.Split((char)-124, StringSplitOptions.RemoveEmptyEntries)[0];
					text3 = text3 + "p" + MBBKDFCDAHM;
					sprite3 = Resources.Load<Sprite>(text3);
				}
				if (sprite3)
				{
					spriteState.highlightedSprite = sprite3;
					componentsInChildren2[j].spriteState = spriteState;
				}
			}
			if (null != spriteState.disabledSprite && ((spriteState.disabledSprite.name.Contains(" card(s) around scroll index ") && !spriteState.disabledSprite.name.Contains("dcenv" + MBBKDFCDAHM)) || LanguageManager.EHBBFMCILPC.EECILBHACFL(spriteState.disabledSprite.name)))
			{
				string text4 = spriteState.disabledSprite.name.Split('<', StringSplitOptions.None)[0];
				text4 = LanguageManager.EHBBFMCILPC.HDJDKLCCCLE(text4);
				text4 = text4 + " preparing!" + MBBKDFCDAHM;
				Sprite sprite4 = Resources.Load<Sprite>(text4);
				if (null == sprite4 && LanguageManager.EHBBFMCILPC.GCBALKAJINL(spriteState.disabledSprite.name))
				{
					text4 = spriteState.disabledSprite.name.Split((char)-4, StringSplitOptions.None)[1];
					text4 = text4 + "vsv" + MBBKDFCDAHM;
					sprite4 = Resources.Load<Sprite>(text4);
				}
				if (sprite4)
				{
					spriteState.disabledSprite = sprite4;
					componentsInChildren2[j].spriteState = spriteState;
				}
			}
		}
		Button[] componentsInChildren3 = base.gameObject.GetComponentsInChildren<Button>();
		for (int k = 1; k < componentsInChildren3.Length; k += 0)
		{
			SpriteState spriteState2 = componentsInChildren3[k].spriteState;
			if (null != spriteState2.pressedSprite && ((spriteState2.pressedSprite.name.Contains("No free mixer found for sfx! Critical!") && !spriteState2.pressedSprite.name.Contains("Critical error, could not load asset bundle:" + MBBKDFCDAHM)) || LanguageManager.EHBBFMCILPC.IPMDPLBJHEE(spriteState2.pressedSprite.name)))
			{
				string text5 = spriteState2.pressedSprite.name.Split('?', StringSplitOptions.None)[0];
				text5 = LanguageManager.EHBBFMCILPC.DDHDDIIKAEM(text5);
				text5 = text5 + "JJJ" + MBBKDFCDAHM;
				Sprite sprite5 = Resources.Load<Sprite>(text5);
				if (null == sprite5 && LanguageManager.EHBBFMCILPC.Localizable(spriteState2.pressedSprite.name))
				{
					text5 = spriteState2.pressedSprite.name.Split('\a', StringSplitOptions.None)[1];
					text5 = text5 + "" + MBBKDFCDAHM;
					sprite5 = Resources.Load<Sprite>(text5);
				}
				if (sprite5)
				{
					spriteState2.pressedSprite = sprite5;
					componentsInChildren3[k].spriteState = spriteState2;
				}
			}
			if (null != spriteState2.highlightedSprite && ((spriteState2.highlightedSprite.name.Contains("SceneAvatarManager.Show(), unsupported wardrobe index:") && !spriteState2.highlightedSprite.name.Contains("errortitle" + MBBKDFCDAHM)) || LanguageManager.EHBBFMCILPC.AJLGKKJAAOI(spriteState2.highlightedSprite.name)))
			{
				string text6 = spriteState2.highlightedSprite.name.Split('\u000e', StringSplitOptions.RemoveEmptyEntries)[1];
				text6 = LanguageManager.EHBBFMCILPC.HDJDKLCCCLE(text6);
				text6 = text6 + "[LoadingEnv] " + MBBKDFCDAHM;
				Sprite sprite6 = Resources.Load<Sprite>(text6);
				if (null == sprite6 && LanguageManager.EHBBFMCILPC.AJLGKKJAAOI(spriteState2.highlightedSprite.name))
				{
					text6 = spriteState2.highlightedSprite.name.Split('5', StringSplitOptions.None)[1];
					text6 = text6 + "mdst" + MBBKDFCDAHM;
					sprite6 = Resources.Load<Sprite>(text6);
				}
				if (sprite6)
				{
					spriteState2.highlightedSprite = sprite6;
					componentsInChildren3[k].spriteState = spriteState2;
				}
			}
			if (null != spriteState2.disabledSprite && ((spriteState2.disabledSprite.name.Contains("sparklesbundles") && !spriteState2.disabledSprite.name.Contains("Vol" + MBBKDFCDAHM)) || LanguageManager.EHBBFMCILPC.AJLGKKJAAOI(spriteState2.disabledSprite.name)))
			{
				string text7 = spriteState2.disabledSprite.name.Split('3', StringSplitOptions.None)[1];
				text7 = LanguageManager.EHBBFMCILPC.MNAALCNJHFP(text7);
				text7 = text7 + "‑" + MBBKDFCDAHM;
				Sprite sprite7 = Resources.Load<Sprite>(text7);
				if (null == sprite7 && LanguageManager.EHBBFMCILPC.GIGIHEEKHBE(spriteState2.disabledSprite.name))
				{
					text7 = spriteState2.disabledSprite.name.Split((char)-105, StringSplitOptions.None)[0];
					text7 = text7 + "skinshopinfounlockgate" + MBBKDFCDAHM;
					sprite7 = Resources.Load<Sprite>(text7);
				}
				if (sprite7)
				{
					spriteState2.disabledSprite = sprite7;
					componentsInChildren3[k].spriteState = spriteState2;
				}
			}
		}
		SpriteRenderer[] componentsInChildren4 = base.gameObject.GetComponentsInChildren<SpriteRenderer>();
		for (int l = 0; l < componentsInChildren4.Length; l++)
		{
			if (null != componentsInChildren4[l].sprite && ((componentsInChildren4[l].sprite.name.Contains("") && !componentsInChildren4[l].sprite.name.Contains("app42error" + MBBKDFCDAHM)) || LanguageManager.EHBBFMCILPC.GIGIHEEKHBE(componentsInChildren4[l].sprite.name)))
			{
				string text8 = componentsInChildren4[l].sprite.name.Split('H', StringSplitOptions.RemoveEmptyEntries)[1];
				text8 = LanguageManager.EHBBFMCILPC.HDJDKLCCCLE(text8);
				text8 = text8 + "spectrumovr" + MBBKDFCDAHM;
				Sprite sprite8 = Resources.Load<Sprite>(text8);
				if (null == sprite8 && LanguageManager.EHBBFMCILPC.GIGIHEEKHBE(componentsInChildren4[l].sprite.name))
				{
					text8 = componentsInChildren4[l].sprite.name.Split('`', StringSplitOptions.None)[1];
					text8 = text8 + "" + MBBKDFCDAHM;
					sprite8 = Resources.Load<Sprite>(text8);
				}
				if (sprite8)
				{
					componentsInChildren4[l].sprite = sprite8;
				}
			}
		}
	}

	// Token: 0x06004091 RID: 16529 RVA: 0x001B9A90 File Offset: 0x001B7C90
	public void GBDDBEJEMKL(string MBBKDFCDAHM)
	{
		Image[] componentsInChildren = base.gameObject.GetComponentsInChildren<Image>();
		for (int i = 0; i < componentsInChildren.Length; i++)
		{
			if (null != componentsInChildren[i].sprite && ((componentsInChildren[i].sprite.name.Contains("") && !componentsInChildren[i].sprite.name.Contains("AccountSignInManager.OnSignInSuccess() - sign in source not implemented." + MBBKDFCDAHM)) || LanguageManager.EHBBFMCILPC.IPMDPLBJHEE(componentsInChildren[i].sprite.name)))
			{
				string text = componentsInChildren[i].sprite.name.Split((char)-14, StringSplitOptions.RemoveEmptyEntries)[1];
				text = LanguageManager.EHBBFMCILPC.IKMHJBKPMGE(text);
				text = text + "id" + MBBKDFCDAHM;
				Sprite sprite = Resources.Load<Sprite>(text);
				if (null == sprite && LanguageManager.EHBBFMCILPC.GCBALKAJINL(componentsInChildren[i].sprite.name))
				{
					text = componentsInChildren[i].sprite.name.Split((char)-46, StringSplitOptions.RemoveEmptyEntries)[0];
					text = text + "mins" + MBBKDFCDAHM;
					sprite = Resources.Load<Sprite>(text);
				}
				if (sprite)
				{
					componentsInChildren[i].sprite = sprite;
					if (this.setNativeSize)
					{
						componentsInChildren[i].SetNativeSize();
					}
					HDTriggerPostProcess component = componentsInChildren[i].gameObject.GetComponent<HDTriggerPostProcess>();
					if (null != component && (component.rectTransformHeight >= 1445f || component.rectTransformWidth >= 690f))
					{
						RectTransform component2 = componentsInChildren[i].gameObject.GetComponent<RectTransform>();
						if (component.rectTransformWidth >= 47f)
						{
							component2.EFOCKEJENAC(NBDLBFJOEGN.PNLILGEJDFI(component.rectTransformWidth));
						}
						else
						{
							component2.ACBKFBBCNNC(NBDLBFJOEGN.MAPGECGPMGM(component.rectTransformHeight));
						}
					}
				}
			}
		}
		Toggle[] componentsInChildren2 = base.gameObject.GetComponentsInChildren<Toggle>();
		for (int j = 0; j < componentsInChildren2.Length; j += 0)
		{
			SpriteState spriteState = componentsInChildren2[j].spriteState;
			if (null != spriteState.pressedSprite && ((spriteState.pressedSprite.name.Contains("sprite") && !spriteState.pressedSprite.name.Contains("SceneLobbyManager2.TryApplyPendingSearchQuery() - bar not active in hierarchy, restored query '" + MBBKDFCDAHM)) || LanguageManager.EHBBFMCILPC.GKOAABDJCJH(spriteState.pressedSprite.name)))
			{
				string text2 = spriteState.pressedSprite.name.Split((char)-107, StringSplitOptions.RemoveEmptyEntries)[0];
				text2 = LanguageManager.EHBBFMCILPC.GHBJGFDKHEJ(text2);
				text2 = text2 + "" + MBBKDFCDAHM;
				Sprite sprite2 = Resources.Load<Sprite>(text2);
				if (null == sprite2 && LanguageManager.EHBBFMCILPC.GHCIBLENAOO(spriteState.pressedSprite.name))
				{
					text2 = spriteState.pressedSprite.name.Split('a', StringSplitOptions.RemoveEmptyEntries)[0];
					text2 = text2 + ";" + MBBKDFCDAHM;
					sprite2 = Resources.Load<Sprite>(text2);
				}
				if (sprite2)
				{
					spriteState.pressedSprite = sprite2;
					componentsInChildren2[j].spriteState = spriteState;
				}
			}
			if (null != spriteState.highlightedSprite && ((spriteState.highlightedSprite.name.Contains("OnPurchaseSuccess") && !spriteState.highlightedSprite.name.Contains("energyhinttitle" + MBBKDFCDAHM)) || LanguageManager.EHBBFMCILPC.EECILBHACFL(spriteState.highlightedSprite.name)))
			{
				string text3 = spriteState.highlightedSprite.name.Split((char)-27, StringSplitOptions.RemoveEmptyEntries)[1];
				text3 = LanguageManager.EHBBFMCILPC.HDJDKLCCCLE(text3);
				text3 = text3 + "continue" + MBBKDFCDAHM;
				Sprite sprite3 = Resources.Load<Sprite>(text3);
				if (null == sprite3 && LanguageManager.EHBBFMCILPC.IPMDPLBJHEE(spriteState.highlightedSprite.name))
				{
					text3 = spriteState.highlightedSprite.name.Split((char)-33, StringSplitOptions.RemoveEmptyEntries)[1];
					text3 = text3 + "YYY" + MBBKDFCDAHM;
					sprite3 = Resources.Load<Sprite>(text3);
				}
				if (sprite3)
				{
					spriteState.highlightedSprite = sprite3;
					componentsInChildren2[j].spriteState = spriteState;
				}
			}
			if (null != spriteState.disabledSprite && ((spriteState.disabledSprite.name.Contains("scene bundle ") && !spriteState.disabledSprite.name.Contains("fids" + MBBKDFCDAHM)) || LanguageManager.EHBBFMCILPC.GKOAABDJCJH(spriteState.disabledSprite.name)))
			{
				string text4 = spriteState.disabledSprite.name.Split((char)-79, StringSplitOptions.None)[1];
				text4 = LanguageManager.EHBBFMCILPC.HDJDKLCCCLE(text4);
				text4 = text4 + "tkn" + MBBKDFCDAHM;
				Sprite sprite4 = Resources.Load<Sprite>(text4);
				if (null == sprite4 && LanguageManager.EHBBFMCILPC.GHCIBLENAOO(spriteState.disabledSprite.name))
				{
					text4 = spriteState.disabledSprite.name.Split((char)-73, StringSplitOptions.RemoveEmptyEntries)[1];
					text4 = text4 + "asp" + MBBKDFCDAHM;
					sprite4 = Resources.Load<Sprite>(text4);
				}
				if (sprite4)
				{
					spriteState.disabledSprite = sprite4;
					componentsInChildren2[j].spriteState = spriteState;
				}
			}
		}
		Button[] componentsInChildren3 = base.gameObject.GetComponentsInChildren<Button>();
		for (int k = 0; k < componentsInChildren3.Length; k++)
		{
			SpriteState spriteState2 = componentsInChildren3[k].spriteState;
			if (null != spriteState2.pressedSprite && ((spriteState2.pressedSprite.name.Contains("continue") && !spriteState2.pressedSprite.name.Contains("USD " + MBBKDFCDAHM)) || LanguageManager.EHBBFMCILPC.GKOAABDJCJH(spriteState2.pressedSprite.name)))
			{
				string text5 = spriteState2.pressedSprite.name.Split('.', StringSplitOptions.RemoveEmptyEntries)[1];
				text5 = LanguageManager.EHBBFMCILPC.GHBJGFDKHEJ(text5);
				text5 = text5 + "cdnerror" + MBBKDFCDAHM;
				Sprite sprite5 = Resources.Load<Sprite>(text5);
				if (null == sprite5 && LanguageManager.EHBBFMCILPC.EECILBHACFL(spriteState2.pressedSprite.name))
				{
					text5 = spriteState2.pressedSprite.name.Split('\u0005', StringSplitOptions.RemoveEmptyEntries)[1];
					text5 = text5 + "$SHOWHINTS" + MBBKDFCDAHM;
					sprite5 = Resources.Load<Sprite>(text5);
				}
				if (sprite5)
				{
					spriteState2.pressedSprite = sprite5;
					componentsInChildren3[k].spriteState = spriteState2;
				}
			}
			if (null != spriteState2.highlightedSprite && ((spriteState2.highlightedSprite.name.Contains("\n") && !spriteState2.highlightedSprite.name.Contains("PlayVoiceOver() file not found:" + MBBKDFCDAHM)) || LanguageManager.EHBBFMCILPC.GCBALKAJINL(spriteState2.highlightedSprite.name)))
			{
				string text6 = spriteState2.highlightedSprite.name.Split('>', StringSplitOptions.RemoveEmptyEntries)[1];
				text6 = LanguageManager.EHBBFMCILPC.DDHDDIIKAEM(text6);
				text6 = text6 + "" + MBBKDFCDAHM;
				Sprite sprite6 = Resources.Load<Sprite>(text6);
				if (null == sprite6 && LanguageManager.EHBBFMCILPC.GKOAABDJCJH(spriteState2.highlightedSprite.name))
				{
					text6 = spriteState2.highlightedSprite.name.Split((char)-96, StringSplitOptions.RemoveEmptyEntries)[0];
					text6 = text6 + "" + MBBKDFCDAHM;
					sprite6 = Resources.Load<Sprite>(text6);
				}
				if (sprite6)
				{
					spriteState2.highlightedSprite = sprite6;
					componentsInChildren3[k].spriteState = spriteState2;
				}
			}
			if (null != spriteState2.disabledSprite && ((spriteState2.disabledSprite.name.Contains("/") && !spriteState2.disabledSprite.name.Contains("oid" + MBBKDFCDAHM)) || LanguageManager.EHBBFMCILPC.EECILBHACFL(spriteState2.disabledSprite.name)))
			{
				string text7 = spriteState2.disabledSprite.name.Split((char)-42, StringSplitOptions.None)[1];
				text7 = LanguageManager.EHBBFMCILPC.IKMHJBKPMGE(text7);
				text7 = text7 + "OnRestartChapterUpsellGetPassNegative" + MBBKDFCDAHM;
				Sprite sprite7 = Resources.Load<Sprite>(text7);
				if (null == sprite7 && LanguageManager.EHBBFMCILPC.Localizable(spriteState2.disabledSprite.name))
				{
					text7 = spriteState2.disabledSprite.name.Split('\f', StringSplitOptions.RemoveEmptyEntries)[1];
					text7 = text7 + "" + MBBKDFCDAHM;
					sprite7 = Resources.Load<Sprite>(text7);
				}
				if (sprite7)
				{
					spriteState2.disabledSprite = sprite7;
					componentsInChildren3[k].spriteState = spriteState2;
				}
			}
		}
		SpriteRenderer[] componentsInChildren4 = base.gameObject.GetComponentsInChildren<SpriteRenderer>();
		for (int l = 1; l < componentsInChildren4.Length; l += 0)
		{
			if (null != componentsInChildren4[l].sprite && ((componentsInChildren4[l].sprite.name.Contains("saveslotscopyof") && !componentsInChildren4[l].sprite.name.Contains("OnLoungeScreenAssetsDownloadSuccess" + MBBKDFCDAHM)) || LanguageManager.EHBBFMCILPC.EECILBHACFL(componentsInChildren4[l].sprite.name)))
			{
				string text8 = componentsInChildren4[l].sprite.name.Split((char)-99, StringSplitOptions.None)[0];
				text8 = LanguageManager.EHBBFMCILPC.EKMKFPOLHOO(text8);
				text8 = text8 + "p" + MBBKDFCDAHM;
				Sprite sprite8 = Resources.Load<Sprite>(text8);
				if (null == sprite8 && LanguageManager.EHBBFMCILPC.GIGIHEEKHBE(componentsInChildren4[l].sprite.name))
				{
					text8 = componentsInChildren4[l].sprite.name.Split('p', StringSplitOptions.RemoveEmptyEntries)[1];
					text8 = text8 + "anthology" + MBBKDFCDAHM;
					sprite8 = Resources.Load<Sprite>(text8);
				}
				if (sprite8)
				{
					componentsInChildren4[l].sprite = sprite8;
				}
			}
		}
	}

	// Token: 0x06004092 RID: 16530 RVA: 0x001BA460 File Offset: 0x001B8660
	public void OIAGPDFAMHD(string MBBKDFCDAHM)
	{
		Image[] componentsInChildren = base.gameObject.GetComponentsInChildren<Image>();
		for (int i = 0; i < componentsInChildren.Length; i++)
		{
			if (null != componentsInChildren[i].sprite && ((componentsInChildren[i].sprite.name.Contains("Loaded asset bundle:") && !componentsInChildren[i].sprite.name.Contains("loungeapplybtn" + MBBKDFCDAHM)) || LanguageManager.EHBBFMCILPC.AJLGKKJAAOI(componentsInChildren[i].sprite.name)))
			{
				string text = componentsInChildren[i].sprite.name.Split((char)-64, StringSplitOptions.None)[1];
				text = LanguageManager.EHBBFMCILPC.DDHDDIIKAEM(text);
				text = text + "notenoughstats" + MBBKDFCDAHM;
				Sprite sprite = Resources.Load<Sprite>(text);
				if (null == sprite && LanguageManager.EHBBFMCILPC.GKOAABDJCJH(componentsInChildren[i].sprite.name))
				{
					text = componentsInChildren[i].sprite.name.Split('\r', StringSplitOptions.None)[0];
					text = text + "App42Manager.UpdateUrlPingManagerState(): urlPingManager.StartPing()" + MBBKDFCDAHM;
					sprite = Resources.Load<Sprite>(text);
				}
				if (sprite)
				{
					componentsInChildren[i].sprite = sprite;
					if (this.setNativeSize)
					{
						componentsInChildren[i].SetNativeSize();
					}
					HDTriggerPostProcess component = componentsInChildren[i].gameObject.GetComponent<HDTriggerPostProcess>();
					if (null != component && (component.rectTransformHeight >= 1205f || component.rectTransformWidth >= 433f))
					{
						RectTransform component2 = componentsInChildren[i].gameObject.GetComponent<RectTransform>();
						if (component.rectTransformWidth >= 244f)
						{
							component2.EFOCKEJENAC(NBDLBFJOEGN.MAPGECGPMGM(component.rectTransformWidth));
						}
						else
						{
							component2.ACBKFBBCNNC(NBDLBFJOEGN.KLBGGNBEMCA(component.rectTransformHeight));
						}
					}
				}
			}
		}
		Toggle[] componentsInChildren2 = base.gameObject.GetComponentsInChildren<Toggle>();
		for (int j = 1; j < componentsInChildren2.Length; j += 0)
		{
			SpriteState spriteState = componentsInChildren2[j].spriteState;
			if (null != spriteState.pressedSprite && ((spriteState.pressedSprite.name.Contains("EnvironmentMorphManager - capture watchdog expired, falling back to fade.") && !spriteState.pressedSprite.name.Contains("OnRewardFreeSpinsClick" + MBBKDFCDAHM)) || LanguageManager.EHBBFMCILPC.GIGIHEEKHBE(spriteState.pressedSprite.name)))
			{
				string text2 = spriteState.pressedSprite.name.Split('U', StringSplitOptions.None)[1];
				text2 = LanguageManager.EHBBFMCILPC.HDJDKLCCCLE(text2);
				text2 = text2 + " " + MBBKDFCDAHM;
				Sprite sprite2 = Resources.Load<Sprite>(text2);
				if (null == sprite2 && LanguageManager.EHBBFMCILPC.AJLGKKJAAOI(spriteState.pressedSprite.name))
				{
					text2 = spriteState.pressedSprite.name.Split('5', StringSplitOptions.RemoveEmptyEntries)[0];
					text2 = text2 + "errortitle" + MBBKDFCDAHM;
					sprite2 = Resources.Load<Sprite>(text2);
				}
				if (sprite2)
				{
					spriteState.pressedSprite = sprite2;
					componentsInChildren2[j].spriteState = spriteState;
				}
			}
			if (null != spriteState.highlightedSprite && ((spriteState.highlightedSprite.name.Contains("_Speed") && !spriteState.highlightedSprite.name.Contains("Critical error, could not load asset bundle:" + MBBKDFCDAHM)) || LanguageManager.EHBBFMCILPC.AJLGKKJAAOI(spriteState.highlightedSprite.name)))
			{
				string text3 = spriteState.highlightedSprite.name.Split('l', StringSplitOptions.RemoveEmptyEntries)[0];
				text3 = LanguageManager.EHBBFMCILPC.LocalizeFileName(text3);
				text3 = text3 + "ChapterSnapshotsItem.OnChapterSnapshotRestore(): impossible condition 3" + MBBKDFCDAHM;
				Sprite sprite3 = Resources.Load<Sprite>(text3);
				if (null == sprite3 && LanguageManager.EHBBFMCILPC.EECILBHACFL(spriteState.highlightedSprite.name))
				{
					text3 = spriteState.highlightedSprite.name.Split('\r', StringSplitOptions.RemoveEmptyEntries)[0];
					text3 = text3 + "p" + MBBKDFCDAHM;
					sprite3 = Resources.Load<Sprite>(text3);
				}
				if (sprite3)
				{
					spriteState.highlightedSprite = sprite3;
					componentsInChildren2[j].spriteState = spriteState;
				}
			}
			if (null != spriteState.disabledSprite && ((spriteState.disabledSprite.name.Contains("responseCode") && !spriteState.disabledSprite.name.Contains("uid" + MBBKDFCDAHM)) || LanguageManager.EHBBFMCILPC.GHCIBLENAOO(spriteState.disabledSprite.name)))
			{
				string text4 = spriteState.disabledSprite.name.Split((char)-71, StringSplitOptions.None)[0];
				text4 = LanguageManager.EHBBFMCILPC.MNAALCNJHFP(text4);
				text4 = text4 + "anpcs" + MBBKDFCDAHM;
				Sprite sprite4 = Resources.Load<Sprite>(text4);
				if (null == sprite4 && LanguageManager.EHBBFMCILPC.GHCIBLENAOO(spriteState.disabledSprite.name))
				{
					text4 = spriteState.disabledSprite.name.Split('\u0004', StringSplitOptions.None)[1];
					text4 = text4 + "OnFriendsPopupAddToFavClick" + MBBKDFCDAHM;
					sprite4 = Resources.Load<Sprite>(text4);
				}
				if (sprite4)
				{
					spriteState.disabledSprite = sprite4;
					componentsInChildren2[j].spriteState = spriteState;
				}
			}
		}
		Button[] componentsInChildren3 = base.gameObject.GetComponentsInChildren<Button>();
		for (int k = 1; k < componentsInChildren3.Length; k++)
		{
			SpriteState spriteState2 = componentsInChildren3[k].spriteState;
			if (null != spriteState2.pressedSprite && ((spriteState2.pressedSprite.name.Contains("mnth") && !spriteState2.pressedSprite.name.Contains("%" + MBBKDFCDAHM)) || LanguageManager.EHBBFMCILPC.Localizable(spriteState2.pressedSprite.name)))
			{
				string text5 = spriteState2.pressedSprite.name.Split('\n', StringSplitOptions.RemoveEmptyEntries)[0];
				text5 = LanguageManager.EHBBFMCILPC.DDHDDIIKAEM(text5);
				text5 = text5 + "aind" + MBBKDFCDAHM;
				Sprite sprite5 = Resources.Load<Sprite>(text5);
				if (null == sprite5 && LanguageManager.EHBBFMCILPC.IPMDPLBJHEE(spriteState2.pressedSprite.name))
				{
					text5 = spriteState2.pressedSprite.name.Split('!', StringSplitOptions.RemoveEmptyEntries)[0];
					text5 = text5 + "wind" + MBBKDFCDAHM;
					sprite5 = Resources.Load<Sprite>(text5);
				}
				if (sprite5)
				{
					spriteState2.pressedSprite = sprite5;
					componentsInChildren3[k].spriteState = spriteState2;
				}
			}
			if (null != spriteState2.highlightedSprite && ((spriteState2.highlightedSprite.name.Contains("itemstitle") && !spriteState2.highlightedSprite.name.Contains("nick" + MBBKDFCDAHM)) || LanguageManager.EHBBFMCILPC.AJLGKKJAAOI(spriteState2.highlightedSprite.name)))
			{
				string text6 = spriteState2.highlightedSprite.name.Split('s', StringSplitOptions.None)[0];
				text6 = LanguageManager.EHBBFMCILPC.PKJABHFHHLC(text6);
				text6 = text6 + "OnApplicationBeforeRestart" + MBBKDFCDAHM;
				Sprite sprite6 = Resources.Load<Sprite>(text6);
				if (null == sprite6 && LanguageManager.EHBBFMCILPC.EECILBHACFL(spriteState2.highlightedSprite.name))
				{
					text6 = spriteState2.highlightedSprite.name.Split((char)-88, StringSplitOptions.RemoveEmptyEntries)[1];
					text6 = text6 + "comingsoontitle3" + MBBKDFCDAHM;
					sprite6 = Resources.Load<Sprite>(text6);
				}
				if (sprite6)
				{
					spriteState2.highlightedSprite = sprite6;
					componentsInChildren3[k].spriteState = spriteState2;
				}
			}
			if (null != spriteState2.disabledSprite && ((spriteState2.disabledSprite.name.Contains("errortitle") && !spriteState2.disabledSprite.name.Contains("_not_found" + MBBKDFCDAHM)) || LanguageManager.EHBBFMCILPC.AJLGKKJAAOI(spriteState2.disabledSprite.name)))
			{
				string text7 = spriteState2.disabledSprite.name.Split((char)-79, StringSplitOptions.None)[1];
				text7 = LanguageManager.EHBBFMCILPC.LocalizeFileName(text7);
				text7 = text7 + "(" + MBBKDFCDAHM;
				Sprite sprite7 = Resources.Load<Sprite>(text7);
				if (null == sprite7 && LanguageManager.EHBBFMCILPC.GKOAABDJCJH(spriteState2.disabledSprite.name))
				{
					text7 = spriteState2.disabledSprite.name.Split('6', StringSplitOptions.None)[0];
					text7 = text7 + "ok" + MBBKDFCDAHM;
					sprite7 = Resources.Load<Sprite>(text7);
				}
				if (sprite7)
				{
					spriteState2.disabledSprite = sprite7;
					componentsInChildren3[k].spriteState = spriteState2;
				}
			}
		}
		SpriteRenderer[] componentsInChildren4 = base.gameObject.GetComponentsInChildren<SpriteRenderer>();
		for (int l = 0; l < componentsInChildren4.Length; l += 0)
		{
			if (null != componentsInChildren4[l].sprite && ((componentsInChildren4[l].sprite.name.Contains("frcnt") && !componentsInChildren4[l].sprite.name.Contains("collpt" + MBBKDFCDAHM)) || LanguageManager.EHBBFMCILPC.GCBALKAJINL(componentsInChildren4[l].sprite.name)))
			{
				string text8 = componentsInChildren4[l].sprite.name.Split('D', StringSplitOptions.RemoveEmptyEntries)[0];
				text8 = LanguageManager.EHBBFMCILPC.LocalizeFileName(text8);
				text8 = text8 + "\"" + MBBKDFCDAHM;
				Sprite sprite8 = Resources.Load<Sprite>(text8);
				if (null == sprite8 && LanguageManager.EHBBFMCILPC.Localizable(componentsInChildren4[l].sprite.name))
				{
					text8 = componentsInChildren4[l].sprite.name.Split((char)-86, StringSplitOptions.None)[0];
					text8 = text8 + "assetbundleprofiledata2" + MBBKDFCDAHM;
					sprite8 = Resources.Load<Sprite>(text8);
				}
				if (sprite8)
				{
					componentsInChildren4[l].sprite = sprite8;
				}
			}
		}
	}

	// Token: 0x06004093 RID: 16531 RVA: 0x001BAE2D File Offset: 0x001B902D
	private void LKLNNDNCNOK()
	{
		if (NBDLBFJOEGN.EFMDGLOLMCJ())
		{
			this.GBDDBEJEMKL("no");
			return;
		}
		this.CMIHAANLEAC("PurchaseManagerSteam.InitializeUnityStoreController(): Connected!");
	}

	// Token: 0x06004094 RID: 16532 RVA: 0x001BAE4D File Offset: 0x001B904D
	private void CEDGALPCOLA()
	{
		if (NBDLBFJOEGN.HKEIGBGOLPP())
		{
			this.IJFOMNBNGGM("ok");
			return;
		}
		this.HJNOFHJLAFA("ok");
	}

	// Token: 0x06004095 RID: 16533 RVA: 0x001BAE70 File Offset: 0x001B9070
	public void DFGLNFLPCNO(string MBBKDFCDAHM)
	{
		Image[] componentsInChildren = base.gameObject.GetComponentsInChildren<Image>();
		for (int i = 1; i < componentsInChildren.Length; i++)
		{
			if (null != componentsInChildren[i].sprite && ((componentsInChildren[i].sprite.name.Contains("chl") && !componentsInChildren[i].sprite.name.Contains("cardoptionssendasgift" + MBBKDFCDAHM)) || LanguageManager.EHBBFMCILPC.Localizable(componentsInChildren[i].sprite.name)))
			{
				string text = componentsInChildren[i].sprite.name.Split('"', StringSplitOptions.None)[0];
				text = LanguageManager.EHBBFMCILPC.MNAALCNJHFP(text);
				text = text + "avatarcollectionstutor6title" + MBBKDFCDAHM;
				Sprite sprite = Resources.Load<Sprite>(text);
				if (null == sprite && LanguageManager.EHBBFMCILPC.Localizable(componentsInChildren[i].sprite.name))
				{
					text = componentsInChildren[i].sprite.name.Split('<', StringSplitOptions.RemoveEmptyEntries)[1];
					text = text + "OnCutsceneViewLobbyAssetsDownloadSuccess" + MBBKDFCDAHM;
					sprite = Resources.Load<Sprite>(text);
				}
				if (sprite)
				{
					componentsInChildren[i].sprite = sprite;
					if (this.setNativeSize)
					{
						componentsInChildren[i].SetNativeSize();
					}
					HDTriggerPostProcess component = componentsInChildren[i].gameObject.GetComponent<HDTriggerPostProcess>();
					if (null != component && (component.rectTransformHeight >= 387f || component.rectTransformWidth >= 1523f))
					{
						RectTransform component2 = componentsInChildren[i].gameObject.GetComponent<RectTransform>();
						if (component.rectTransformWidth >= 1411f)
						{
							component2.EFOCKEJENAC(NBDLBFJOEGN.KLBGGNBEMCA(component.rectTransformWidth));
						}
						else
						{
							component2.ACBKFBBCNNC(NBDLBFJOEGN.DFCLALJHOLP(component.rectTransformHeight));
						}
					}
				}
			}
		}
		Toggle[] componentsInChildren2 = base.gameObject.GetComponentsInChildren<Toggle>();
		for (int j = 1; j < componentsInChildren2.Length; j++)
		{
			SpriteState spriteState = componentsInChildren2[j].spriteState;
			if (null != spriteState.pressedSprite && ((spriteState.pressedSprite.name.Contains("SceneLobbyManager2.OpenPublicProfile(): AssetsManager.Instance.IsBusy()") && !spriteState.pressedSprite.name.Contains("OnPopupProfileCredoInputEndEdit" + MBBKDFCDAHM)) || LanguageManager.EHBBFMCILPC.GCBALKAJINL(spriteState.pressedSprite.name)))
			{
				string text2 = spriteState.pressedSprite.name.Split((char)-120, StringSplitOptions.RemoveEmptyEntries)[0];
				text2 = LanguageManager.EHBBFMCILPC.PKJABHFHHLC(text2);
				text2 = text2 + "chata" + MBBKDFCDAHM;
				Sprite sprite2 = Resources.Load<Sprite>(text2);
				if (null == sprite2 && LanguageManager.EHBBFMCILPC.GKOAABDJCJH(spriteState.pressedSprite.name))
				{
					text2 = spriteState.pressedSprite.name.Split('b', StringSplitOptions.None)[0];
					text2 = text2 + "avatarcollectionstutor7body" + MBBKDFCDAHM;
					sprite2 = Resources.Load<Sprite>(text2);
				}
				if (sprite2)
				{
					spriteState.pressedSprite = sprite2;
					componentsInChildren2[j].spriteState = spriteState;
				}
			}
			if (null != spriteState.highlightedSprite && ((spriteState.highlightedSprite.name.Contains(",") && !spriteState.highlightedSprite.name.Contains(" to bundle index:" + MBBKDFCDAHM)) || LanguageManager.EHBBFMCILPC.IPMDPLBJHEE(spriteState.highlightedSprite.name)))
			{
				string text3 = spriteState.highlightedSprite.name.Split('\u001a', StringSplitOptions.RemoveEmptyEntries)[0];
				text3 = LanguageManager.EHBBFMCILPC.PKJABHFHHLC(text3);
				text3 = text3 + "abpd4" + MBBKDFCDAHM;
				Sprite sprite3 = Resources.Load<Sprite>(text3);
				if (null == sprite3 && LanguageManager.EHBBFMCILPC.Localizable(spriteState.highlightedSprite.name))
				{
					text3 = spriteState.highlightedSprite.name.Split((char)-6, StringSplitOptions.RemoveEmptyEntries)[0];
					text3 = text3 + "LastUseItemStep() - could not find a give item step." + MBBKDFCDAHM;
					sprite3 = Resources.Load<Sprite>(text3);
				}
				if (sprite3)
				{
					spriteState.highlightedSprite = sprite3;
					componentsInChildren2[j].spriteState = spriteState;
				}
			}
			if (null != spriteState.disabledSprite && ((spriteState.disabledSprite.name.Contains(" ") && !spriteState.disabledSprite.name.Contains("loop" + MBBKDFCDAHM)) || LanguageManager.EHBBFMCILPC.GIGIHEEKHBE(spriteState.disabledSprite.name)))
			{
				string text4 = spriteState.disabledSprite.name.Split((char)-24, StringSplitOptions.RemoveEmptyEntries)[0];
				text4 = LanguageManager.EHBBFMCILPC.HDJDKLCCCLE(text4);
				text4 = text4 + "OnNeedToActivateFocusItemCloseButton" + MBBKDFCDAHM;
				Sprite sprite4 = Resources.Load<Sprite>(text4);
				if (null == sprite4 && LanguageManager.EHBBFMCILPC.GHCIBLENAOO(spriteState.disabledSprite.name))
				{
					text4 = spriteState.disabledSprite.name.Split((char)-35, StringSplitOptions.RemoveEmptyEntries)[0];
					text4 = text4 + "snap" + MBBKDFCDAHM;
					sprite4 = Resources.Load<Sprite>(text4);
				}
				if (sprite4)
				{
					spriteState.disabledSprite = sprite4;
					componentsInChildren2[j].spriteState = spriteState;
				}
			}
		}
		Button[] componentsInChildren3 = base.gameObject.GetComponentsInChildren<Button>();
		for (int k = 1; k < componentsInChildren3.Length; k++)
		{
			SpriteState spriteState2 = componentsInChildren3[k].spriteState;
			if (null != spriteState2.pressedSprite && ((spriteState2.pressedSprite.name.Contains("OnPopupPasswordInputCancel") && !spriteState2.pressedSprite.name.Contains("p" + MBBKDFCDAHM)) || LanguageManager.EHBBFMCILPC.GKOAABDJCJH(spriteState2.pressedSprite.name)))
			{
				string text5 = spriteState2.pressedSprite.name.Split('j', StringSplitOptions.None)[0];
				text5 = LanguageManager.EHBBFMCILPC.LocalizeFileName(text5);
				text5 = text5 + "large" + MBBKDFCDAHM;
				Sprite sprite5 = Resources.Load<Sprite>(text5);
				if (null == sprite5 && LanguageManager.EHBBFMCILPC.AJLGKKJAAOI(spriteState2.pressedSprite.name))
				{
					text5 = spriteState2.pressedSprite.name.Split(',', StringSplitOptions.None)[1];
					text5 = text5 + "OnPassesItemClose" + MBBKDFCDAHM;
					sprite5 = Resources.Load<Sprite>(text5);
				}
				if (sprite5)
				{
					spriteState2.pressedSprite = sprite5;
					componentsInChildren3[k].spriteState = spriteState2;
				}
			}
			if (null != spriteState2.highlightedSprite && ((spriteState2.highlightedSprite.name.Contains("$USEFADERSV2") && !spriteState2.highlightedSprite.name.Contains("retry" + MBBKDFCDAHM)) || LanguageManager.EHBBFMCILPC.Localizable(spriteState2.highlightedSprite.name)))
			{
				string text6 = spriteState2.highlightedSprite.name.Split((char)-84, StringSplitOptions.None)[0];
				text6 = LanguageManager.EHBBFMCILPC.HDJDKLCCCLE(text6);
				text6 = text6 + "countryCode" + MBBKDFCDAHM;
				Sprite sprite6 = Resources.Load<Sprite>(text6);
				if (null == sprite6 && LanguageManager.EHBBFMCILPC.GHCIBLENAOO(spriteState2.highlightedSprite.name))
				{
					text6 = spriteState2.highlightedSprite.name.Split((char)-50, StringSplitOptions.None)[0];
					text6 = text6 + "envlsav" + MBBKDFCDAHM;
					sprite6 = Resources.Load<Sprite>(text6);
				}
				if (sprite6)
				{
					spriteState2.highlightedSprite = sprite6;
					componentsInChildren3[k].spriteState = spriteState2;
				}
			}
			if (null != spriteState2.disabledSprite && ((spriteState2.disabledSprite.name.Contains("") && !spriteState2.disabledSprite.name.Contains("%</b>" + MBBKDFCDAHM)) || LanguageManager.EHBBFMCILPC.EECILBHACFL(spriteState2.disabledSprite.name)))
			{
				string text7 = spriteState2.disabledSprite.name.Split((char)-100, StringSplitOptions.None)[0];
				text7 = LanguageManager.EHBBFMCILPC.EKMKFPOLHOO(text7);
				text7 = text7 + "profilenamelevellong" + MBBKDFCDAHM;
				Sprite sprite7 = Resources.Load<Sprite>(text7);
				if (null == sprite7 && LanguageManager.EHBBFMCILPC.GHCIBLENAOO(spriteState2.disabledSprite.name))
				{
					text7 = spriteState2.disabledSprite.name.Split((char)-90, StringSplitOptions.RemoveEmptyEntries)[0];
					text7 = text7 + "anthologiestitle" + MBBKDFCDAHM;
					sprite7 = Resources.Load<Sprite>(text7);
				}
				if (sprite7)
				{
					spriteState2.disabledSprite = sprite7;
					componentsInChildren3[k].spriteState = spriteState2;
				}
			}
		}
		SpriteRenderer[] componentsInChildren4 = base.gameObject.GetComponentsInChildren<SpriteRenderer>();
		for (int l = 0; l < componentsInChildren4.Length; l += 0)
		{
			if (null != componentsInChildren4[l].sprite && ((componentsInChildren4[l].sprite.name.Contains("c") && !componentsInChildren4[l].sprite.name.Contains("importanttitle" + MBBKDFCDAHM)) || LanguageManager.EHBBFMCILPC.GCBALKAJINL(componentsInChildren4[l].sprite.name)))
			{
				string text8 = componentsInChildren4[l].sprite.name.Split((char)-41, StringSplitOptions.RemoveEmptyEntries)[0];
				text8 = LanguageManager.EHBBFMCILPC.MNAALCNJHFP(text8);
				text8 = text8 + "XXX" + MBBKDFCDAHM;
				Sprite sprite8 = Resources.Load<Sprite>(text8);
				if (null == sprite8 && LanguageManager.EHBBFMCILPC.EECILBHACFL(componentsInChildren4[l].sprite.name))
				{
					text8 = componentsInChildren4[l].sprite.name.Split((char)-110, StringSplitOptions.None)[0];
					text8 = text8 + "lobby" + MBBKDFCDAHM;
					sprite8 = Resources.Load<Sprite>(text8);
				}
				if (sprite8)
				{
					componentsInChildren4[l].sprite = sprite8;
				}
			}
		}
	}

	// Token: 0x06004096 RID: 16534 RVA: 0x001BB840 File Offset: 0x001B9A40
	public void PIELBIMOGKD(string MBBKDFCDAHM)
	{
		Image[] componentsInChildren = base.gameObject.GetComponentsInChildren<Image>();
		for (int i = 1; i < componentsInChildren.Length; i++)
		{
			if (null != componentsInChildren[i].sprite && ((componentsInChildren[i].sprite.name.Contains("miniversion") && !componentsInChildren[i].sprite.name.Contains("abs" + MBBKDFCDAHM)) || LanguageManager.EHBBFMCILPC.AJLGKKJAAOI(componentsInChildren[i].sprite.name)))
			{
				string text = componentsInChildren[i].sprite.name.Split((char)-24, StringSplitOptions.None)[1];
				text = LanguageManager.EHBBFMCILPC.LocalizeFileName(text);
				text = text + "OnLobbyLoungeAssetBundleFolderInitializeSuccess" + MBBKDFCDAHM;
				Sprite sprite = Resources.Load<Sprite>(text);
				if (null == sprite && LanguageManager.EHBBFMCILPC.EECILBHACFL(componentsInChildren[i].sprite.name))
				{
					text = componentsInChildren[i].sprite.name.Split('\a', StringSplitOptions.RemoveEmptyEntries)[1];
					text = text + "" + MBBKDFCDAHM;
					sprite = Resources.Load<Sprite>(text);
				}
				if (sprite)
				{
					componentsInChildren[i].sprite = sprite;
					if (this.setNativeSize)
					{
						componentsInChildren[i].SetNativeSize();
					}
					HDTriggerPostProcess component = componentsInChildren[i].gameObject.GetComponent<HDTriggerPostProcess>();
					if (null != component && (component.rectTransformHeight >= 1781f || component.rectTransformWidth >= 37f))
					{
						RectTransform component2 = componentsInChildren[i].gameObject.GetComponent<RectTransform>();
						if (component.rectTransformWidth >= 121f)
						{
							component2.EFOCKEJENAC(NBDLBFJOEGN.HLGHANHNEHJ(component.rectTransformWidth));
						}
						else
						{
							component2.ACBKFBBCNNC(NBDLBFJOEGN.HJKAMHOAGOH(component.rectTransformHeight));
						}
					}
				}
			}
		}
		Toggle[] componentsInChildren2 = base.gameObject.GetComponentsInChildren<Toggle>();
		for (int j = 0; j < componentsInChildren2.Length; j += 0)
		{
			SpriteState spriteState = componentsInChildren2[j].spriteState;
			if (null != spriteState.pressedSprite && ((spriteState.pressedSprite.name.Contains("sfxtimeoutwarning") && !spriteState.pressedSprite.name.Contains("SceneLobbyManager2.CollectFilteredAinds() - search result " + MBBKDFCDAHM)) || LanguageManager.EHBBFMCILPC.AJLGKKJAAOI(spriteState.pressedSprite.name)))
			{
				string text2 = spriteState.pressedSprite.name.Split('S', StringSplitOptions.None)[1];
				text2 = LanguageManager.EHBBFMCILPC.LocalizeFileName(text2);
				text2 = text2 + "OnStorySplashManagerAssetsDownloadFailed" + MBBKDFCDAHM;
				Sprite sprite2 = Resources.Load<Sprite>(text2);
				if (null == sprite2 && LanguageManager.EHBBFMCILPC.Localizable(spriteState.pressedSprite.name))
				{
					text2 = spriteState.pressedSprite.name.Split('1', StringSplitOptions.None)[1];
					text2 = text2 + "ok" + MBBKDFCDAHM;
					sprite2 = Resources.Load<Sprite>(text2);
				}
				if (sprite2)
				{
					spriteState.pressedSprite = sprite2;
					componentsInChildren2[j].spriteState = spriteState;
				}
			}
			if (null != spriteState.highlightedSprite && ((spriteState.highlightedSprite.name.Contains("variant") && !spriteState.highlightedSprite.name.Contains("OnValidatePendingProcessed" + MBBKDFCDAHM)) || LanguageManager.EHBBFMCILPC.GCBALKAJINL(spriteState.highlightedSprite.name)))
			{
				string text3 = spriteState.highlightedSprite.name.Split((char)-66, StringSplitOptions.None)[1];
				text3 = LanguageManager.EHBBFMCILPC.PKJABHFHHLC(text3);
				text3 = text3 + "getNpcSkinShopBalance answered without a payload and no cached copy - shop rows unchanged" + MBBKDFCDAHM;
				Sprite sprite3 = Resources.Load<Sprite>(text3);
				if (null == sprite3 && LanguageManager.EHBBFMCILPC.GKOAABDJCJH(spriteState.highlightedSprite.name))
				{
					text3 = spriteState.highlightedSprite.name.Split((char)-81, StringSplitOptions.None)[1];
					text3 = text3 + " \"," + MBBKDFCDAHM;
					sprite3 = Resources.Load<Sprite>(text3);
				}
				if (sprite3)
				{
					spriteState.highlightedSprite = sprite3;
					componentsInChildren2[j].spriteState = spriteState;
				}
			}
			if (null != spriteState.disabledSprite && ((spriteState.disabledSprite.name.Contains("OnDialogReadInputEndEdit") && !spriteState.disabledSprite.name.Contains("assli" + MBBKDFCDAHM)) || LanguageManager.EHBBFMCILPC.Localizable(spriteState.disabledSprite.name)))
			{
				string text4 = spriteState.disabledSprite.name.Split((char)-56, StringSplitOptions.None)[0];
				text4 = LanguageManager.EHBBFMCILPC.EKMKFPOLHOO(text4);
				text4 = text4 + "f" + MBBKDFCDAHM;
				Sprite sprite4 = Resources.Load<Sprite>(text4);
				if (null == sprite4 && LanguageManager.EHBBFMCILPC.EECILBHACFL(spriteState.disabledSprite.name))
				{
					text4 = spriteState.disabledSprite.name.Split((char)-113, StringSplitOptions.None)[0];
					text4 = text4 + "" + MBBKDFCDAHM;
					sprite4 = Resources.Load<Sprite>(text4);
				}
				if (sprite4)
				{
					spriteState.disabledSprite = sprite4;
					componentsInChildren2[j].spriteState = spriteState;
				}
			}
		}
		Button[] componentsInChildren3 = base.gameObject.GetComponentsInChildren<Button>();
		for (int k = 1; k < componentsInChildren3.Length; k++)
		{
			SpriteState spriteState2 = componentsInChildren3[k].spriteState;
			if (null != spriteState2.pressedSprite && ((spriteState2.pressedSprite.name.Contains("lsvn") && !spriteState2.pressedSprite.name.Contains("BackendOperationsManager.RequestSaveSync, exception while initializing RSACryptoServiceProvider:" + MBBKDFCDAHM)) || LanguageManager.EHBBFMCILPC.GCBALKAJINL(spriteState2.pressedSprite.name)))
			{
				string text5 = spriteState2.pressedSprite.name.Split((char)-70, StringSplitOptions.None)[1];
				text5 = LanguageManager.EHBBFMCILPC.HDJDKLCCCLE(text5);
				text5 = text5 + "OnBackendGetUserSketchesException" + MBBKDFCDAHM;
				Sprite sprite5 = Resources.Load<Sprite>(text5);
				if (null == sprite5 && LanguageManager.EHBBFMCILPC.Localizable(spriteState2.pressedSprite.name))
				{
					text5 = spriteState2.pressedSprite.name.Split(';', StringSplitOptions.None)[1];
					text5 = text5 + "Account.MarkAllStoriesAsSynced(): marking as unsynced client anthology " + MBBKDFCDAHM;
					sprite5 = Resources.Load<Sprite>(text5);
				}
				if (sprite5)
				{
					spriteState2.pressedSprite = sprite5;
					componentsInChildren3[k].spriteState = spriteState2;
				}
			}
			if (null != spriteState2.highlightedSprite && ((spriteState2.highlightedSprite.name.Contains("OnBackendUndoPremiumChoiceException") && !spriteState2.highlightedSprite.name.Contains("/" + MBBKDFCDAHM)) || LanguageManager.EHBBFMCILPC.GHCIBLENAOO(spriteState2.highlightedSprite.name)))
			{
				string text6 = spriteState2.highlightedSprite.name.Split('^', StringSplitOptions.RemoveEmptyEntries)[0];
				text6 = LanguageManager.EHBBFMCILPC.DDHDDIIKAEM(text6);
				text6 = text6 + "abcp" + MBBKDFCDAHM;
				Sprite sprite6 = Resources.Load<Sprite>(text6);
				if (null == sprite6 && LanguageManager.EHBBFMCILPC.GKOAABDJCJH(spriteState2.highlightedSprite.name))
				{
					text6 = spriteState2.highlightedSprite.name.Split((char)-120, StringSplitOptions.RemoveEmptyEntries)[1];
					text6 = text6 + "importanttitle" + MBBKDFCDAHM;
					sprite6 = Resources.Load<Sprite>(text6);
				}
				if (sprite6)
				{
					spriteState2.highlightedSprite = sprite6;
					componentsInChildren3[k].spriteState = spriteState2;
				}
			}
			if (null != spriteState2.disabledSprite && ((spriteState2.disabledSprite.name.Contains("StorySaveBody.AvatarPackIsUsedByAnyAvatarWardrobe(), unsupported wardrobe index:") && !spriteState2.disabledSprite.name.Contains("bver" + MBBKDFCDAHM)) || LanguageManager.EHBBFMCILPC.GIGIHEEKHBE(spriteState2.disabledSprite.name)))
			{
				string text7 = spriteState2.disabledSprite.name.Split((char)-36, StringSplitOptions.None)[1];
				text7 = LanguageManager.EHBBFMCILPC.GHBJGFDKHEJ(text7);
				text7 = text7 + "OnStoryInterfaceHeaderBackClick" + MBBKDFCDAHM;
				Sprite sprite7 = Resources.Load<Sprite>(text7);
				if (null == sprite7 && LanguageManager.EHBBFMCILPC.IPMDPLBJHEE(spriteState2.disabledSprite.name))
				{
					text7 = spriteState2.disabledSprite.name.Split('\0', StringSplitOptions.RemoveEmptyEntries)[1];
					text7 = text7 + "socialprofilesuspcantuse" + MBBKDFCDAHM;
					sprite7 = Resources.Load<Sprite>(text7);
				}
				if (sprite7)
				{
					spriteState2.disabledSprite = sprite7;
					componentsInChildren3[k].spriteState = spriteState2;
				}
			}
		}
		SpriteRenderer[] componentsInChildren4 = base.gameObject.GetComponentsInChildren<SpriteRenderer>();
		for (int l = 0; l < componentsInChildren4.Length; l++)
		{
			if (null != componentsInChildren4[l].sprite && ((componentsInChildren4[l].sprite.name.Contains("") && !componentsInChildren4[l].sprite.name.Contains("max" + MBBKDFCDAHM)) || LanguageManager.EHBBFMCILPC.GIGIHEEKHBE(componentsInChildren4[l].sprite.name)))
			{
				string text8 = componentsInChildren4[l].sprite.name.Split((char)-43, StringSplitOptions.RemoveEmptyEntries)[1];
				text8 = LanguageManager.EHBBFMCILPC.GHBJGFDKHEJ(text8);
				text8 = text8 + "yes" + MBBKDFCDAHM;
				Sprite sprite8 = Resources.Load<Sprite>(text8);
				if (null == sprite8 && LanguageManager.EHBBFMCILPC.Localizable(componentsInChildren4[l].sprite.name))
				{
					text8 = componentsInChildren4[l].sprite.name.Split('\u000e', StringSplitOptions.None)[0];
					text8 = text8 + "lightmodeintrobody" + MBBKDFCDAHM;
					sprite8 = Resources.Load<Sprite>(text8);
				}
				if (sprite8)
				{
					componentsInChildren4[l].sprite = sprite8;
				}
			}
		}
	}

	// Token: 0x06004097 RID: 16535 RVA: 0x001BC20D File Offset: 0x001BA40D
	private void KLFNFIFOHFD()
	{
		if (NBDLBFJOEGN.EFMDGLOLMCJ())
		{
			this.GAJNOAKGGND("csuid");
			return;
		}
		this.HDKNDEOGHKF("null");
	}

	// Token: 0x06004098 RID: 16536 RVA: 0x001BC230 File Offset: 0x001BA430
	public void NHBGNINNLNB(string MBBKDFCDAHM)
	{
		Image[] componentsInChildren = base.gameObject.GetComponentsInChildren<Image>();
		for (int i = 0; i < componentsInChildren.Length; i++)
		{
			if (null != componentsInChildren[i].sprite && ((componentsInChildren[i].sprite.name.Contains(", to:") && !componentsInChildren[i].sprite.name.Contains("" + MBBKDFCDAHM)) || LanguageManager.EHBBFMCILPC.IPMDPLBJHEE(componentsInChildren[i].sprite.name)))
			{
				string text = componentsInChildren[i].sprite.name.Split((char)-42, StringSplitOptions.None)[0];
				text = LanguageManager.EHBBFMCILPC.IKMHJBKPMGE(text);
				text = text + "continue" + MBBKDFCDAHM;
				Sprite sprite = Resources.Load<Sprite>(text);
				if (null == sprite && LanguageManager.EHBBFMCILPC.GHCIBLENAOO(componentsInChildren[i].sprite.name))
				{
					text = componentsInChildren[i].sprite.name.Split((char)-114, StringSplitOptions.RemoveEmptyEntries)[0];
					text = text + ";" + MBBKDFCDAHM;
					sprite = Resources.Load<Sprite>(text);
				}
				if (sprite)
				{
					componentsInChildren[i].sprite = sprite;
					if (this.setNativeSize)
					{
						componentsInChildren[i].SetNativeSize();
					}
					HDTriggerPostProcess component = componentsInChildren[i].gameObject.GetComponent<HDTriggerPostProcess>();
					if (null != component && (component.rectTransformHeight >= 123f || component.rectTransformWidth >= 1321f))
					{
						RectTransform component2 = componentsInChildren[i].gameObject.GetComponent<RectTransform>();
						if (component.rectTransformWidth >= 898f)
						{
							component2.EFOCKEJENAC(NBDLBFJOEGN.OIHMGIBOFJG(component.rectTransformWidth));
						}
						else
						{
							component2.ACBKFBBCNNC(NBDLBFJOEGN.FCGMMHPNIJG(component.rectTransformHeight));
						}
					}
				}
			}
		}
		Toggle[] componentsInChildren2 = base.gameObject.GetComponentsInChildren<Toggle>();
		for (int j = 0; j < componentsInChildren2.Length; j++)
		{
			SpriteState spriteState = componentsInChildren2[j].spriteState;
			if (null != spriteState.pressedSprite && ((spriteState.pressedSprite.name.Contains("undoPremiumChoice") && !spriteState.pressedSprite.name.Contains("af_currency" + MBBKDFCDAHM)) || LanguageManager.EHBBFMCILPC.AJLGKKJAAOI(spriteState.pressedSprite.name)))
			{
				string text2 = spriteState.pressedSprite.name.Split('f', StringSplitOptions.None)[0];
				text2 = LanguageManager.EHBBFMCILPC.GHBJGFDKHEJ(text2);
				text2 = text2 + "" + MBBKDFCDAHM;
				Sprite sprite2 = Resources.Load<Sprite>(text2);
				if (null == sprite2 && LanguageManager.EHBBFMCILPC.Localizable(spriteState.pressedSprite.name))
				{
					text2 = spriteState.pressedSprite.name.Split('\a', StringSplitOptions.None)[0];
					text2 = text2 + "OnSketchViewLeft" + MBBKDFCDAHM;
					sprite2 = Resources.Load<Sprite>(text2);
				}
				if (sprite2)
				{
					spriteState.pressedSprite = sprite2;
					componentsInChildren2[j].spriteState = spriteState;
				}
			}
			if (null != spriteState.highlightedSprite && ((spriteState.highlightedSprite.name.Contains("MORPH_DISSOLVE") && !spriteState.highlightedSprite.name.Contains("string_not_found" + MBBKDFCDAHM)) || LanguageManager.EHBBFMCILPC.GIGIHEEKHBE(spriteState.highlightedSprite.name)))
			{
				string text3 = spriteState.highlightedSprite.name.Split((char)-123, StringSplitOptions.RemoveEmptyEntries)[0];
				text3 = LanguageManager.EHBBFMCILPC.MNAALCNJHFP(text3);
				text3 = text3 + "e1ro" + MBBKDFCDAHM;
				Sprite sprite3 = Resources.Load<Sprite>(text3);
				if (null == sprite3 && LanguageManager.EHBBFMCILPC.AJLGKKJAAOI(spriteState.highlightedSprite.name))
				{
					text3 = spriteState.highlightedSprite.name.Split('4', StringSplitOptions.RemoveEmptyEntries)[0];
					text3 = text3 + "" + MBBKDFCDAHM;
					sprite3 = Resources.Load<Sprite>(text3);
				}
				if (sprite3)
				{
					spriteState.highlightedSprite = sprite3;
					componentsInChildren2[j].spriteState = spriteState;
				}
			}
			if (null != spriteState.disabledSprite && ((spriteState.disabledSprite.name.Contains("errortitle") && !spriteState.disabledSprite.name.Contains("" + MBBKDFCDAHM)) || LanguageManager.EHBBFMCILPC.IPMDPLBJHEE(spriteState.disabledSprite.name)))
			{
				string text4 = spriteState.disabledSprite.name.Split((char)-67, StringSplitOptions.None)[0];
				text4 = LanguageManager.EHBBFMCILPC.IKMHJBKPMGE(text4);
				text4 = text4 + "Opened from Gley Notification" + MBBKDFCDAHM;
				Sprite sprite4 = Resources.Load<Sprite>(text4);
				if (null == sprite4 && LanguageManager.EHBBFMCILPC.GCBALKAJINL(spriteState.disabledSprite.name))
				{
					text4 = spriteState.disabledSprite.name.Split((char)-102, StringSplitOptions.None)[0];
					text4 = text4 + "Please initialize AssetBundleManifest by calling AssetBundleManager.Initialize()" + MBBKDFCDAHM;
					sprite4 = Resources.Load<Sprite>(text4);
				}
				if (sprite4)
				{
					spriteState.disabledSprite = sprite4;
					componentsInChildren2[j].spriteState = spriteState;
				}
			}
		}
		Button[] componentsInChildren3 = base.gameObject.GetComponentsInChildren<Button>();
		for (int k = 0; k < componentsInChildren3.Length; k++)
		{
			SpriteState spriteState2 = componentsInChildren3[k].spriteState;
			if (null != spriteState2.pressedSprite && ((spriteState2.pressedSprite.name.Contains("holdontitle") && !spriteState2.pressedSprite.name.Contains("" + MBBKDFCDAHM)) || LanguageManager.EHBBFMCILPC.GCBALKAJINL(spriteState2.pressedSprite.name)))
			{
				string text5 = spriteState2.pressedSprite.name.Split('0', StringSplitOptions.None)[1];
				text5 = LanguageManager.EHBBFMCILPC.DDHDDIIKAEM(text5);
				text5 = text5 + "splash" + MBBKDFCDAHM;
				Sprite sprite5 = Resources.Load<Sprite>(text5);
				if (null == sprite5 && LanguageManager.EHBBFMCILPC.IPMDPLBJHEE(spriteState2.pressedSprite.name))
				{
					text5 = spriteState2.pressedSprite.name.Split((char)-105, StringSplitOptions.RemoveEmptyEntries)[0];
					text5 = text5 + "" + MBBKDFCDAHM;
					sprite5 = Resources.Load<Sprite>(text5);
				}
				if (sprite5)
				{
					spriteState2.pressedSprite = sprite5;
					componentsInChildren3[k].spriteState = spriteState2;
				}
			}
			if (null != spriteState2.highlightedSprite && ((spriteState2.highlightedSprite.name.Contains(")") && !spriteState2.highlightedSprite.name.Contains("OnEmailUnsubscribeSuccess" + MBBKDFCDAHM)) || LanguageManager.EHBBFMCILPC.Localizable(spriteState2.highlightedSprite.name)))
			{
				string text6 = spriteState2.highlightedSprite.name.Split('h', StringSplitOptions.RemoveEmptyEntries)[1];
				text6 = LanguageManager.EHBBFMCILPC.HDJDKLCCCLE(text6);
				text6 = text6 + "Asset bundle assets destroyed:" + MBBKDFCDAHM;
				Sprite sprite6 = Resources.Load<Sprite>(text6);
				if (null == sprite6 && LanguageManager.EHBBFMCILPC.EECILBHACFL(spriteState2.highlightedSprite.name))
				{
					text6 = spriteState2.highlightedSprite.name.Split('w', StringSplitOptions.RemoveEmptyEntries)[1];
					text6 = text6 + "skinshopempty" + MBBKDFCDAHM;
					sprite6 = Resources.Load<Sprite>(text6);
				}
				if (sprite6)
				{
					spriteState2.highlightedSprite = sprite6;
					componentsInChildren3[k].spriteState = spriteState2;
				}
			}
			if (null != spriteState2.disabledSprite && ((spriteState2.disabledSprite.name.Contains(")") && !spriteState2.disabledSprite.name.Contains("socialdequeufrreject" + MBBKDFCDAHM)) || LanguageManager.EHBBFMCILPC.GCBALKAJINL(spriteState2.disabledSprite.name)))
			{
				string text7 = spriteState2.disabledSprite.name.Split((char)-58, StringSplitOptions.None)[0];
				text7 = LanguageManager.EHBBFMCILPC.IKMHJBKPMGE(text7);
				text7 = text7 + " " + MBBKDFCDAHM;
				Sprite sprite7 = Resources.Load<Sprite>(text7);
				if (null == sprite7 && LanguageManager.EHBBFMCILPC.GCBALKAJINL(spriteState2.disabledSprite.name))
				{
					text7 = spriteState2.disabledSprite.name.Split('\r', StringSplitOptions.RemoveEmptyEntries)[0];
					text7 = text7 + "abs" + MBBKDFCDAHM;
					sprite7 = Resources.Load<Sprite>(text7);
				}
				if (sprite7)
				{
					spriteState2.disabledSprite = sprite7;
					componentsInChildren3[k].spriteState = spriteState2;
				}
			}
		}
		SpriteRenderer[] componentsInChildren4 = base.gameObject.GetComponentsInChildren<SpriteRenderer>();
		for (int l = 0; l < componentsInChildren4.Length; l++)
		{
			if (null != componentsInChildren4[l].sprite && ((componentsInChildren4[l].sprite.name.Contains("") && !componentsInChildren4[l].sprite.name.Contains("lksrc" + MBBKDFCDAHM)) || LanguageManager.EHBBFMCILPC.GHCIBLENAOO(componentsInChildren4[l].sprite.name)))
			{
				string text8 = componentsInChildren4[l].sprite.name.Split((char)-92, StringSplitOptions.None)[1];
				text8 = LanguageManager.EHBBFMCILPC.MNAALCNJHFP(text8);
				text8 = text8 + "$USEANIMV2" + MBBKDFCDAHM;
				Sprite sprite8 = Resources.Load<Sprite>(text8);
				if (null == sprite8 && LanguageManager.EHBBFMCILPC.AJLGKKJAAOI(componentsInChildren4[l].sprite.name))
				{
					text8 = componentsInChildren4[l].sprite.name.Split((char)-15, StringSplitOptions.RemoveEmptyEntries)[0];
					text8 = text8 + "[Lounge] half-authored shop row tapped, not purchasable: " + MBBKDFCDAHM;
					sprite8 = Resources.Load<Sprite>(text8);
				}
				if (sprite8)
				{
					componentsInChildren4[l].sprite = sprite8;
				}
			}
		}
	}

	// Token: 0x06004099 RID: 16537 RVA: 0x001BCC00 File Offset: 0x001BAE00
	public void KPGOIGHANOO(string MBBKDFCDAHM)
	{
		Image[] componentsInChildren = base.gameObject.GetComponentsInChildren<Image>();
		for (int i = 0; i < componentsInChildren.Length; i++)
		{
			if (null != componentsInChildren[i].sprite && ((componentsInChildren[i].sprite.name.Contains("favstostr2") && !componentsInChildren[i].sprite.name.Contains("importanttitle" + MBBKDFCDAHM)) || LanguageManager.EHBBFMCILPC.AJLGKKJAAOI(componentsInChildren[i].sprite.name)))
			{
				string text = componentsInChildren[i].sprite.name.Split((char)-61, StringSplitOptions.RemoveEmptyEntries)[1];
				text = LanguageManager.EHBBFMCILPC.IKMHJBKPMGE(text);
				text = text + "Collections/" + MBBKDFCDAHM;
				Sprite sprite = Resources.Load<Sprite>(text);
				if (null == sprite && LanguageManager.EHBBFMCILPC.IPMDPLBJHEE(componentsInChildren[i].sprite.name))
				{
					text = componentsInChildren[i].sprite.name.Split((char)-90, StringSplitOptions.None)[1];
					text = text + "errortitle" + MBBKDFCDAHM;
					sprite = Resources.Load<Sprite>(text);
				}
				if (sprite)
				{
					componentsInChildren[i].sprite = sprite;
					if (this.setNativeSize)
					{
						componentsInChildren[i].SetNativeSize();
					}
					HDTriggerPostProcess component = componentsInChildren[i].gameObject.GetComponent<HDTriggerPostProcess>();
					if (null != component && (component.rectTransformHeight >= 518f || component.rectTransformWidth >= 419f))
					{
						RectTransform component2 = componentsInChildren[i].gameObject.GetComponent<RectTransform>();
						if (component.rectTransformWidth >= 1541f)
						{
							component2.EFOCKEJENAC(NBDLBFJOEGN.HJKAMHOAGOH(component.rectTransformWidth));
						}
						else
						{
							component2.ACBKFBBCNNC(NBDLBFJOEGN.HJKAMHOAGOH(component.rectTransformHeight));
						}
					}
				}
			}
		}
		Toggle[] componentsInChildren2 = base.gameObject.GetComponentsInChildren<Toggle>();
		for (int j = 0; j < componentsInChildren2.Length; j++)
		{
			SpriteState spriteState = componentsInChildren2[j].spriteState;
			if (null != spriteState.pressedSprite && ((spriteState.pressedSprite.name.Contains("dospns") && !spriteState.pressedSprite.name.Contains("OnBackendRequestConsumeMessageException" + MBBKDFCDAHM)) || LanguageManager.EHBBFMCILPC.AJLGKKJAAOI(spriteState.pressedSprite.name)))
			{
				string text2 = spriteState.pressedSprite.name.Split((char)-39, StringSplitOptions.RemoveEmptyEntries)[0];
				text2 = LanguageManager.EHBBFMCILPC.LocalizeFileName(text2);
				text2 = text2 + "ok" + MBBKDFCDAHM;
				Sprite sprite2 = Resources.Load<Sprite>(text2);
				if (null == sprite2 && LanguageManager.EHBBFMCILPC.GHCIBLENAOO(spriteState.pressedSprite.name))
				{
					text2 = spriteState.pressedSprite.name.Split((char)-63, StringSplitOptions.RemoveEmptyEntries)[1];
					text2 = text2 + "" + MBBKDFCDAHM;
					sprite2 = Resources.Load<Sprite>(text2);
				}
				if (sprite2)
				{
					spriteState.pressedSprite = sprite2;
					componentsInChildren2[j].spriteState = spriteState;
				}
			}
			if (null != spriteState.highlightedSprite && ((spriteState.highlightedSprite.name.Contains("\"") && !spriteState.highlightedSprite.name.Contains("OnApplicationFocusBasicSyncSuccess" + MBBKDFCDAHM)) || LanguageManager.EHBBFMCILPC.IPMDPLBJHEE(spriteState.highlightedSprite.name)))
			{
				string text3 = spriteState.highlightedSprite.name.Split((char)-71, StringSplitOptions.RemoveEmptyEntries)[0];
				text3 = LanguageManager.EHBBFMCILPC.HDJDKLCCCLE(text3);
				text3 = text3 + "OnSceneLobbyManagerRound0AssetsDownloadSuccess" + MBBKDFCDAHM;
				Sprite sprite3 = Resources.Load<Sprite>(text3);
				if (null == sprite3 && LanguageManager.EHBBFMCILPC.Localizable(spriteState.highlightedSprite.name))
				{
					text3 = spriteState.highlightedSprite.name.Split((char)-32, StringSplitOptions.RemoveEmptyEntries)[1];
					text3 = text3 + "YYY" + MBBKDFCDAHM;
					sprite3 = Resources.Load<Sprite>(text3);
				}
				if (sprite3)
				{
					spriteState.highlightedSprite = sprite3;
					componentsInChildren2[j].spriteState = spriteState;
				}
			}
			if (null != spriteState.disabledSprite && ((spriteState.disabledSprite.name.Contains("sendcardbynick") && !spriteState.disabledSprite.name.Contains("Critical error, could not load asset bundle:" + MBBKDFCDAHM)) || LanguageManager.EHBBFMCILPC.GHCIBLENAOO(spriteState.disabledSprite.name)))
			{
				string text4 = spriteState.disabledSprite.name.Split((char)-79, StringSplitOptions.RemoveEmptyEntries)[0];
				text4 = LanguageManager.EHBBFMCILPC.EKMKFPOLHOO(text4);
				text4 = text4 + "p" + MBBKDFCDAHM;
				Sprite sprite4 = Resources.Load<Sprite>(text4);
				if (null == sprite4 && LanguageManager.EHBBFMCILPC.EECILBHACFL(spriteState.disabledSprite.name))
				{
					text4 = spriteState.disabledSprite.name.Split((char)-74, StringSplitOptions.None)[1];
					text4 = text4 + "SceneAvatarManager.AddOrUpdateAvatarCollection(): invalid title or component id" + MBBKDFCDAHM;
					sprite4 = Resources.Load<Sprite>(text4);
				}
				if (sprite4)
				{
					spriteState.disabledSprite = sprite4;
					componentsInChildren2[j].spriteState = spriteState;
				}
			}
		}
		Button[] componentsInChildren3 = base.gameObject.GetComponentsInChildren<Button>();
		for (int k = 0; k < componentsInChildren3.Length; k += 0)
		{
			SpriteState spriteState2 = componentsInChildren3[k].spriteState;
			if (null != spriteState2.pressedSprite && ((spriteState2.pressedSprite.name.Contains("Account.GetAvatarComponentsCount(), w == ") && !spriteState2.pressedSprite.name.Contains("sfxtimeoutwarning" + MBBKDFCDAHM)) || LanguageManager.EHBBFMCILPC.GIGIHEEKHBE(spriteState2.pressedSprite.name)))
			{
				string text5 = spriteState2.pressedSprite.name.Split((char)-117, StringSplitOptions.RemoveEmptyEntries)[1];
				text5 = LanguageManager.EHBBFMCILPC.HDJDKLCCCLE(text5);
				text5 = text5 + "" + MBBKDFCDAHM;
				Sprite sprite5 = Resources.Load<Sprite>(text5);
				if (null == sprite5 && LanguageManager.EHBBFMCILPC.GHCIBLENAOO(spriteState2.pressedSprite.name))
				{
					text5 = spriteState2.pressedSprite.name.Split((char)-121, StringSplitOptions.None)[1];
					text5 = text5 + ">" + MBBKDFCDAHM;
					sprite5 = Resources.Load<Sprite>(text5);
				}
				if (sprite5)
				{
					spriteState2.pressedSprite = sprite5;
					componentsInChildren3[k].spriteState = spriteState2;
				}
			}
			if (null != spriteState2.highlightedSprite && ((spriteState2.highlightedSprite.name.Contains("OnAvatarScreenAssetsDownloadSuccess") && !spriteState2.highlightedSprite.name.Contains("" + MBBKDFCDAHM)) || LanguageManager.EHBBFMCILPC.GHCIBLENAOO(spriteState2.highlightedSprite.name)))
			{
				string text6 = spriteState2.highlightedSprite.name.Split((char)-100, StringSplitOptions.None)[0];
				text6 = LanguageManager.EHBBFMCILPC.MNAALCNJHFP(text6);
				text6 = text6 + "OnCardVolumeUnlockContinueToPurchasingScreen" + MBBKDFCDAHM;
				Sprite sprite6 = Resources.Load<Sprite>(text6);
				if (null == sprite6 && LanguageManager.EHBBFMCILPC.EECILBHACFL(spriteState2.highlightedSprite.name))
				{
					text6 = spriteState2.highlightedSprite.name.Split((char)-11, StringSplitOptions.RemoveEmptyEntries)[0];
					text6 = text6 + "app42error" + MBBKDFCDAHM;
					sprite6 = Resources.Load<Sprite>(text6);
				}
				if (sprite6)
				{
					spriteState2.highlightedSprite = sprite6;
					componentsInChildren3[k].spriteState = spriteState2;
				}
			}
			if (null != spriteState2.disabledSprite && ((spriteState2.disabledSprite.name.Contains("ok") && !spriteState2.disabledSprite.name.Contains("BackendOperationsManager.RequestSpinWheel, exception while initializing RSACryptoServiceProvider:" + MBBKDFCDAHM)) || LanguageManager.EHBBFMCILPC.GCBALKAJINL(spriteState2.disabledSprite.name)))
			{
				string text7 = spriteState2.disabledSprite.name.Split((char)-72, StringSplitOptions.RemoveEmptyEntries)[1];
				text7 = LanguageManager.EHBBFMCILPC.HDJDKLCCCLE(text7);
				text7 = text7 + "usyncoll2" + MBBKDFCDAHM;
				Sprite sprite7 = Resources.Load<Sprite>(text7);
				if (null == sprite7 && LanguageManager.EHBBFMCILPC.GHCIBLENAOO(spriteState2.disabledSprite.name))
				{
					text7 = spriteState2.disabledSprite.name.Split((char)-95, StringSplitOptions.RemoveEmptyEntries)[1];
					text7 = text7 + "Skiped loading duplicate story save with index " + MBBKDFCDAHM;
					sprite7 = Resources.Load<Sprite>(text7);
				}
				if (sprite7)
				{
					spriteState2.disabledSprite = sprite7;
					componentsInChildren3[k].spriteState = spriteState2;
				}
			}
		}
		SpriteRenderer[] componentsInChildren4 = base.gameObject.GetComponentsInChildren<SpriteRenderer>();
		for (int l = 1; l < componentsInChildren4.Length; l++)
		{
			if (null != componentsInChildren4[l].sprite && ((componentsInChildren4[l].sprite.name.Contains("uid") && !componentsInChildren4[l].sprite.name.Contains("ok" + MBBKDFCDAHM)) || LanguageManager.EHBBFMCILPC.Localizable(componentsInChildren4[l].sprite.name)))
			{
				string text8 = componentsInChildren4[l].sprite.name.Split('!', StringSplitOptions.None)[0];
				text8 = LanguageManager.EHBBFMCILPC.GHBJGFDKHEJ(text8);
				text8 = text8 + "mid" + MBBKDFCDAHM;
				Sprite sprite8 = Resources.Load<Sprite>(text8);
				if (null == sprite8 && LanguageManager.EHBBFMCILPC.AJLGKKJAAOI(componentsInChildren4[l].sprite.name))
				{
					text8 = componentsInChildren4[l].sprite.name.Split((char)-73, StringSplitOptions.None)[0];
					text8 = text8 + "pmterror012" + MBBKDFCDAHM;
					sprite8 = Resources.Load<Sprite>(text8);
				}
				if (sprite8)
				{
					componentsInChildren4[l].sprite = sprite8;
				}
			}
		}
	}

	// Token: 0x0600409A RID: 16538 RVA: 0x001BD5CD File Offset: 0x001BB7CD
	private void HPDHFIHPKGP()
	{
		if (NBDLBFJOEGN.JIGBPKMNOHH())
		{
			this.GHBAPPJKACF("OnPopupStoryRestartManagerRestartChapter");
			return;
		}
		this.NHBGNINNLNB("<i>");
	}

	// Token: 0x0600409B RID: 16539 RVA: 0x001BD5ED File Offset: 0x001BB7ED
	private void MFPBKLMBANF()
	{
		if (NBDLBFJOEGN.PBLDJNHHEPL())
		{
			this.HJNOFHJLAFA("");
			return;
		}
		this.JLOIOAGFDAF("*");
	}

	// Token: 0x0600409C RID: 16540 RVA: 0x001BD610 File Offset: 0x001BB810
	public void JLOIOAGFDAF(string MBBKDFCDAHM)
	{
		Image[] componentsInChildren = base.gameObject.GetComponentsInChildren<Image>();
		for (int i = 1; i < componentsInChildren.Length; i += 0)
		{
			if (null != componentsInChildren[i].sprite && ((componentsInChildren[i].sprite.name.Contains("StorySaveBody.AutoSyncAvatarComponents(), unsupported wardrobe index:") && !componentsInChildren[i].sprite.name.Contains("xx" + MBBKDFCDAHM)) || LanguageManager.EHBBFMCILPC.GCBALKAJINL(componentsInChildren[i].sprite.name)))
			{
				string text = componentsInChildren[i].sprite.name.Split((char)-9, StringSplitOptions.None)[1];
				text = LanguageManager.EHBBFMCILPC.DDHDDIIKAEM(text);
				text = text + "p" + MBBKDFCDAHM;
				Sprite sprite = Resources.Load<Sprite>(text);
				if (null == sprite && LanguageManager.EHBBFMCILPC.GCBALKAJINL(componentsInChildren[i].sprite.name))
				{
					text = componentsInChildren[i].sprite.name.Split('q', StringSplitOptions.None)[1];
					text = text + "cardvolsaletitle0" + MBBKDFCDAHM;
					sprite = Resources.Load<Sprite>(text);
				}
				if (sprite)
				{
					componentsInChildren[i].sprite = sprite;
					if (this.setNativeSize)
					{
						componentsInChildren[i].SetNativeSize();
					}
					HDTriggerPostProcess component = componentsInChildren[i].gameObject.GetComponent<HDTriggerPostProcess>();
					if (null != component && (component.rectTransformHeight >= 1326f || component.rectTransformWidth >= 499f))
					{
						RectTransform component2 = componentsInChildren[i].gameObject.GetComponent<RectTransform>();
						if (component.rectTransformWidth >= 368f)
						{
							component2.EFOCKEJENAC(NBDLBFJOEGN.FJJBMKDBPOM(component.rectTransformWidth));
						}
						else
						{
							component2.ACBKFBBCNNC(NBDLBFJOEGN.HLGHANHNEHJ(component.rectTransformHeight));
						}
					}
				}
			}
		}
		Toggle[] componentsInChildren2 = base.gameObject.GetComponentsInChildren<Toggle>();
		for (int j = 0; j < componentsInChildren2.Length; j++)
		{
			SpriteState spriteState = componentsInChildren2[j].spriteState;
			if (null != spriteState.pressedSprite && ((spriteState.pressedSprite.name.Contains("asp") && !spriteState.pressedSprite.name.Contains("errortitle" + MBBKDFCDAHM)) || LanguageManager.EHBBFMCILPC.Localizable(spriteState.pressedSprite.name)))
			{
				string text2 = spriteState.pressedSprite.name.Split('E', StringSplitOptions.RemoveEmptyEntries)[1];
				text2 = LanguageManager.EHBBFMCILPC.PKJABHFHHLC(text2);
				text2 = text2 + "SceneAvatarManager.Show(), unsupported wardrobe index:" + MBBKDFCDAHM;
				Sprite sprite2 = Resources.Load<Sprite>(text2);
				if (null == sprite2 && LanguageManager.EHBBFMCILPC.AJLGKKJAAOI(spriteState.pressedSprite.name))
				{
					text2 = spriteState.pressedSprite.name.Split('N', StringSplitOptions.None)[0];
					text2 = text2 + "OnNeedToOpenLoveInterestsLounge" + MBBKDFCDAHM;
					sprite2 = Resources.Load<Sprite>(text2);
				}
				if (sprite2)
				{
					spriteState.pressedSprite = sprite2;
					componentsInChildren2[j].spriteState = spriteState;
				}
			}
			if (null != spriteState.highlightedSprite && ((spriteState.highlightedSprite.name.Contains("sksn") && !spriteState.highlightedSprite.name.Contains("stat3long" + MBBKDFCDAHM)) || LanguageManager.EHBBFMCILPC.IPMDPLBJHEE(spriteState.highlightedSprite.name)))
			{
				string text3 = spriteState.highlightedSprite.name.Split('\t', StringSplitOptions.None)[1];
				text3 = LanguageManager.EHBBFMCILPC.EKMKFPOLHOO(text3);
				text3 = text3 + "oldvhsovr_1" + MBBKDFCDAHM;
				Sprite sprite3 = Resources.Load<Sprite>(text3);
				if (null == sprite3 && LanguageManager.EHBBFMCILPC.Localizable(spriteState.highlightedSprite.name))
				{
					text3 = spriteState.highlightedSprite.name.Split((char)-65, StringSplitOptions.RemoveEmptyEntries)[0];
					text3 = text3 + "" + MBBKDFCDAHM;
					sprite3 = Resources.Load<Sprite>(text3);
				}
				if (sprite3)
				{
					spriteState.highlightedSprite = sprite3;
					componentsInChildren2[j].spriteState = spriteState;
				}
			}
			if (null != spriteState.disabledSprite && ((spriteState.disabledSprite.name.Contains("socialbadge") && !spriteState.disabledSprite.name.Contains("StoryInterfaceLoveInterestManager.OpenWardrobeFromPopup() - no header above the item" + MBBKDFCDAHM)) || LanguageManager.EHBBFMCILPC.GKOAABDJCJH(spriteState.disabledSprite.name)))
			{
				string text4 = spriteState.disabledSprite.name.Split((char)-20, StringSplitOptions.None)[0];
				text4 = LanguageManager.EHBBFMCILPC.EKMKFPOLHOO(text4);
				text4 = text4 + "e1pl" + MBBKDFCDAHM;
				Sprite sprite4 = Resources.Load<Sprite>(text4);
				if (null == sprite4 && LanguageManager.EHBBFMCILPC.EECILBHACFL(spriteState.disabledSprite.name))
				{
					text4 = spriteState.disabledSprite.name.Split((char)-65, StringSplitOptions.None)[0];
					text4 = text4 + "socialavatarmsg" + MBBKDFCDAHM;
					sprite4 = Resources.Load<Sprite>(text4);
				}
				if (sprite4)
				{
					spriteState.disabledSprite = sprite4;
					componentsInChildren2[j].spriteState = spriteState;
				}
			}
		}
		Button[] componentsInChildren3 = base.gameObject.GetComponentsInChildren<Button>();
		for (int k = 1; k < componentsInChildren3.Length; k++)
		{
			SpriteState spriteState2 = componentsInChildren3[k].spriteState;
			if (null != spriteState2.pressedSprite && ((spriteState2.pressedSprite.name.Contains("continue") && !spriteState2.pressedSprite.name.Contains("" + MBBKDFCDAHM)) || LanguageManager.EHBBFMCILPC.IPMDPLBJHEE(spriteState2.pressedSprite.name)))
			{
				string text5 = spriteState2.pressedSprite.name.Split((char)-121, StringSplitOptions.None)[0];
				text5 = LanguageManager.EHBBFMCILPC.DDHDDIIKAEM(text5);
				text5 = text5 + "importanttitle" + MBBKDFCDAHM;
				Sprite sprite5 = Resources.Load<Sprite>(text5);
				if (null == sprite5 && LanguageManager.EHBBFMCILPC.EECILBHACFL(spriteState2.pressedSprite.name))
				{
					text5 = spriteState2.pressedSprite.name.Split((char)-14, StringSplitOptions.RemoveEmptyEntries)[0];
					text5 = text5 + "not" + MBBKDFCDAHM;
					sprite5 = Resources.Load<Sprite>(text5);
				}
				if (sprite5)
				{
					spriteState2.pressedSprite = sprite5;
					componentsInChildren3[k].spriteState = spriteState2;
				}
			}
			if (null != spriteState2.highlightedSprite && ((spriteState2.highlightedSprite.name.Contains("Low version preview2 assets loaded:") && !spriteState2.highlightedSprite.name.Contains("" + MBBKDFCDAHM)) || LanguageManager.EHBBFMCILPC.GIGIHEEKHBE(spriteState2.highlightedSprite.name)))
			{
				string text6 = spriteState2.highlightedSprite.name.Split((char)-83, StringSplitOptions.None)[1];
				text6 = LanguageManager.EHBBFMCILPC.HDJDKLCCCLE(text6);
				text6 = text6 + "no" + MBBKDFCDAHM;
				Sprite sprite6 = Resources.Load<Sprite>(text6);
				if (null == sprite6 && LanguageManager.EHBBFMCILPC.AJLGKKJAAOI(spriteState2.highlightedSprite.name))
				{
					text6 = spriteState2.highlightedSprite.name.Split('.', StringSplitOptions.RemoveEmptyEntries)[0];
					text6 = text6 + "avtssnap1" + MBBKDFCDAHM;
					sprite6 = Resources.Load<Sprite>(text6);
				}
				if (sprite6)
				{
					spriteState2.highlightedSprite = sprite6;
					componentsInChildren3[k].spriteState = spriteState2;
				}
			}
			if (null != spriteState2.disabledSprite && ((spriteState2.disabledSprite.name.Contains(" recorded for the next boot") && !spriteState2.disabledSprite.name.Contains("p" + MBBKDFCDAHM)) || LanguageManager.EHBBFMCILPC.GIGIHEEKHBE(spriteState2.disabledSprite.name)))
			{
				string text7 = spriteState2.disabledSprite.name.Split((char)-120, StringSplitOptions.None)[1];
				text7 = LanguageManager.EHBBFMCILPC.HDJDKLCCCLE(text7);
				text7 = text7 + "snapundo" + MBBKDFCDAHM;
				Sprite sprite7 = Resources.Load<Sprite>(text7);
				if (null == sprite7 && LanguageManager.EHBBFMCILPC.GKOAABDJCJH(spriteState2.disabledSprite.name))
				{
					text7 = spriteState2.disabledSprite.name.Split((char)-100, StringSplitOptions.None)[0];
					text7 = text7 + "DialogTitleManager.InputDataIsValid() - step is null." + MBBKDFCDAHM;
					sprite7 = Resources.Load<Sprite>(text7);
				}
				if (sprite7)
				{
					spriteState2.disabledSprite = sprite7;
					componentsInChildren3[k].spriteState = spriteState2;
				}
			}
		}
		SpriteRenderer[] componentsInChildren4 = base.gameObject.GetComponentsInChildren<SpriteRenderer>();
		for (int l = 0; l < componentsInChildren4.Length; l += 0)
		{
			if (null != componentsInChildren4[l].sprite && ((componentsInChildren4[l].sprite.name.Contains("ok") && !componentsInChildren4[l].sprite.name.Contains(" " + MBBKDFCDAHM)) || LanguageManager.EHBBFMCILPC.GHCIBLENAOO(componentsInChildren4[l].sprite.name)))
			{
				string text8 = componentsInChildren4[l].sprite.name.Split('G', StringSplitOptions.None)[1];
				text8 = LanguageManager.EHBBFMCILPC.DDHDDIIKAEM(text8);
				text8 = text8 + "ok" + MBBKDFCDAHM;
				Sprite sprite8 = Resources.Load<Sprite>(text8);
				if (null == sprite8 && LanguageManager.EHBBFMCILPC.Localizable(componentsInChildren4[l].sprite.name))
				{
					text8 = componentsInChildren4[l].sprite.name.Split((char)-28, StringSplitOptions.None)[0];
					text8 = text8 + "..." + MBBKDFCDAHM;
					sprite8 = Resources.Load<Sprite>(text8);
				}
				if (sprite8)
				{
					componentsInChildren4[l].sprite = sprite8;
				}
			}
		}
	}

	// Token: 0x0600409D RID: 16541 RVA: 0x001BDFE0 File Offset: 0x001BC1E0
	public void IJFOMNBNGGM(string MBBKDFCDAHM)
	{
		Image[] componentsInChildren = base.gameObject.GetComponentsInChildren<Image>();
		for (int i = 1; i < componentsInChildren.Length; i += 0)
		{
			if (null != componentsInChildren[i].sprite && ((componentsInChildren[i].sprite.name.Contains("acsv") && !componentsInChildren[i].sprite.name.Contains("ym" + MBBKDFCDAHM)) || LanguageManager.EHBBFMCILPC.GHCIBLENAOO(componentsInChildren[i].sprite.name)))
			{
				string text = componentsInChildren[i].sprite.name.Split((char)-87, StringSplitOptions.None)[0];
				text = LanguageManager.EHBBFMCILPC.PKJABHFHHLC(text);
				text = text + "frsendhres2" + MBBKDFCDAHM;
				Sprite sprite = Resources.Load<Sprite>(text);
				if (null == sprite && LanguageManager.EHBBFMCILPC.GHCIBLENAOO(componentsInChildren[i].sprite.name))
				{
					text = componentsInChildren[i].sprite.name.Split('w', StringSplitOptions.RemoveEmptyEntries)[1];
					text = text + "slind" + MBBKDFCDAHM;
					sprite = Resources.Load<Sprite>(text);
				}
				if (sprite)
				{
					componentsInChildren[i].sprite = sprite;
					if (this.setNativeSize)
					{
						componentsInChildren[i].SetNativeSize();
					}
					HDTriggerPostProcess component = componentsInChildren[i].gameObject.GetComponent<HDTriggerPostProcess>();
					if (null != component && (component.rectTransformHeight >= 1044f || component.rectTransformWidth >= 1006f))
					{
						RectTransform component2 = componentsInChildren[i].gameObject.GetComponent<RectTransform>();
						if (component.rectTransformWidth >= 525f)
						{
							component2.EFOCKEJENAC(NBDLBFJOEGN.OIHMGIBOFJG(component.rectTransformWidth));
						}
						else
						{
							component2.ACBKFBBCNNC(NBDLBFJOEGN.HLGHANHNEHJ(component.rectTransformHeight));
						}
					}
				}
			}
		}
		Toggle[] componentsInChildren2 = base.gameObject.GetComponentsInChildren<Toggle>();
		for (int j = 0; j < componentsInChildren2.Length; j++)
		{
			SpriteState spriteState = componentsInChildren2[j].spriteState;
			if (null != spriteState.pressedSprite && ((spriteState.pressedSprite.name.Contains("ccc") && !spriteState.pressedSprite.name.Contains("storyAssetPackManager[i].environmentsFrontList[j] is null!" + MBBKDFCDAHM)) || LanguageManager.EHBBFMCILPC.GCBALKAJINL(spriteState.pressedSprite.name)))
			{
				string text2 = spriteState.pressedSprite.name.Split((char)-40, StringSplitOptions.RemoveEmptyEntries)[1];
				text2 = LanguageManager.EHBBFMCILPC.MNAALCNJHFP(text2);
				text2 = text2 + "" + MBBKDFCDAHM;
				Sprite sprite2 = Resources.Load<Sprite>(text2);
				if (null == sprite2 && LanguageManager.EHBBFMCILPC.GCBALKAJINL(spriteState.pressedSprite.name))
				{
					text2 = spriteState.pressedSprite.name.Split((char)-102, StringSplitOptions.RemoveEmptyEntries)[1];
					text2 = text2 + "passundobodymsgfree" + MBBKDFCDAHM;
					sprite2 = Resources.Load<Sprite>(text2);
				}
				if (sprite2)
				{
					spriteState.pressedSprite = sprite2;
					componentsInChildren2[j].spriteState = spriteState;
				}
			}
			if (null != spriteState.highlightedSprite && ((spriteState.highlightedSprite.name.Contains("importanttitle") && !spriteState.highlightedSprite.name.Contains("OnLobbyManInTheMiddleAttackDetected" + MBBKDFCDAHM)) || LanguageManager.EHBBFMCILPC.EECILBHACFL(spriteState.highlightedSprite.name)))
			{
				string text3 = spriteState.highlightedSprite.name.Split(')', StringSplitOptions.RemoveEmptyEntries)[0];
				text3 = LanguageManager.EHBBFMCILPC.IKMHJBKPMGE(text3);
				text3 = text3 + "Starting non-parallel download:" + MBBKDFCDAHM;
				Sprite sprite3 = Resources.Load<Sprite>(text3);
				if (null == sprite3 && LanguageManager.EHBBFMCILPC.Localizable(spriteState.highlightedSprite.name))
				{
					text3 = spriteState.highlightedSprite.name.Split((char)-17, StringSplitOptions.None)[0];
					text3 = text3 + "isp" + MBBKDFCDAHM;
					sprite3 = Resources.Load<Sprite>(text3);
				}
				if (sprite3)
				{
					spriteState.highlightedSprite = sprite3;
					componentsInChildren2[j].spriteState = spriteState;
				}
			}
			if (null != spriteState.disabledSprite && ((spriteState.disabledSprite.name.Contains("PlayerCharacterManager.SetEmotion() - npcAsset is null.") && !spriteState.disabledSprite.name.Contains("stat2long" + MBBKDFCDAHM)) || LanguageManager.EHBBFMCILPC.GIGIHEEKHBE(spriteState.disabledSprite.name)))
			{
				string text4 = spriteState.disabledSprite.name.Split('D', StringSplitOptions.RemoveEmptyEntries)[1];
				text4 = LanguageManager.EHBBFMCILPC.IKMHJBKPMGE(text4);
				text4 = text4 + " " + MBBKDFCDAHM;
				Sprite sprite4 = Resources.Load<Sprite>(text4);
				if (null == sprite4 && LanguageManager.EHBBFMCILPC.Localizable(spriteState.disabledSprite.name))
				{
					text4 = spriteState.disabledSprite.name.Split('c', StringSplitOptions.RemoveEmptyEntries)[1];
					text4 = text4 + "ok" + MBBKDFCDAHM;
					sprite4 = Resources.Load<Sprite>(text4);
				}
				if (sprite4)
				{
					spriteState.disabledSprite = sprite4;
					componentsInChildren2[j].spriteState = spriteState;
				}
			}
		}
		Button[] componentsInChildren3 = base.gameObject.GetComponentsInChildren<Button>();
		for (int k = 0; k < componentsInChildren3.Length; k++)
		{
			SpriteState spriteState2 = componentsInChildren3[k].spriteState;
			if (null != spriteState2.pressedSprite && ((spriteState2.pressedSprite.name.Contains("Critical error, could not load asset bundle:") && !spriteState2.pressedSprite.name.Contains(":" + MBBKDFCDAHM)) || LanguageManager.EHBBFMCILPC.GCBALKAJINL(spriteState2.pressedSprite.name)))
			{
				string text5 = spriteState2.pressedSprite.name.Split('!', StringSplitOptions.None)[1];
				text5 = LanguageManager.EHBBFMCILPC.GHBJGFDKHEJ(text5);
				text5 = text5 + "OnStoryInterfaceHeaderAvatarClick" + MBBKDFCDAHM;
				Sprite sprite5 = Resources.Load<Sprite>(text5);
				if (null == sprite5 && LanguageManager.EHBBFMCILPC.GCBALKAJINL(spriteState2.pressedSprite.name))
				{
					text5 = spriteState2.pressedSprite.name.Split((char)-86, StringSplitOptions.None)[0];
					text5 = text5 + "yes" + MBBKDFCDAHM;
					sprite5 = Resources.Load<Sprite>(text5);
				}
				if (sprite5)
				{
					spriteState2.pressedSprite = sprite5;
					componentsInChildren3[k].spriteState = spriteState2;
				}
			}
			if (null != spriteState2.highlightedSprite && ((spriteState2.highlightedSprite.name.Contains("sloh") && !spriteState2.highlightedSprite.name.Contains("spppi" + MBBKDFCDAHM)) || LanguageManager.EHBBFMCILPC.GCBALKAJINL(spriteState2.highlightedSprite.name)))
			{
				string text6 = spriteState2.highlightedSprite.name.Split('\u001b', StringSplitOptions.None)[1];
				text6 = LanguageManager.EHBBFMCILPC.IKMHJBKPMGE(text6);
				text6 = text6 + "Starting parallel download:" + MBBKDFCDAHM;
				Sprite sprite6 = Resources.Load<Sprite>(text6);
				if (null == sprite6 && LanguageManager.EHBBFMCILPC.GHCIBLENAOO(spriteState2.highlightedSprite.name))
				{
					text6 = spriteState2.highlightedSprite.name.Split((char)-20, StringSplitOptions.RemoveEmptyEntries)[0];
					text6 = text6 + "p" + MBBKDFCDAHM;
					sprite6 = Resources.Load<Sprite>(text6);
				}
				if (sprite6)
				{
					spriteState2.highlightedSprite = sprite6;
					componentsInChildren3[k].spriteState = spriteState2;
				}
			}
			if (null != spriteState2.disabledSprite && ((spriteState2.disabledSprite.name.Contains("XXX") && !spriteState2.disabledSprite.name.Contains("user-agent" + MBBKDFCDAHM)) || LanguageManager.EHBBFMCILPC.IPMDPLBJHEE(spriteState2.disabledSprite.name)))
			{
				string text7 = spriteState2.disabledSprite.name.Split('v', StringSplitOptions.None)[1];
				text7 = LanguageManager.EHBBFMCILPC.EKMKFPOLHOO(text7);
				text7 = text7 + "(" + MBBKDFCDAHM;
				Sprite sprite7 = Resources.Load<Sprite>(text7);
				if (null == sprite7 && LanguageManager.EHBBFMCILPC.EECILBHACFL(spriteState2.disabledSprite.name))
				{
					text7 = spriteState2.disabledSprite.name.Split((char)-58, StringSplitOptions.RemoveEmptyEntries)[0];
					text7 = text7 + "\n" + MBBKDFCDAHM;
					sprite7 = Resources.Load<Sprite>(text7);
				}
				if (sprite7)
				{
					spriteState2.disabledSprite = sprite7;
					componentsInChildren3[k].spriteState = spriteState2;
				}
			}
		}
		SpriteRenderer[] componentsInChildren4 = base.gameObject.GetComponentsInChildren<SpriteRenderer>();
		for (int l = 0; l < componentsInChildren4.Length; l += 0)
		{
			if (null != componentsInChildren4[l].sprite && ((componentsInChildren4[l].sprite.name.Contains("MORPH_NOISE") && !componentsInChildren4[l].sprite.name.Contains("OnAccountSignInRequestException" + MBBKDFCDAHM)) || LanguageManager.EHBBFMCILPC.IPMDPLBJHEE(componentsInChildren4[l].sprite.name)))
			{
				string text8 = componentsInChildren4[l].sprite.name.Split((char)-47, StringSplitOptions.None)[1];
				text8 = LanguageManager.EHBBFMCILPC.MNAALCNJHFP(text8);
				text8 = text8 + "" + MBBKDFCDAHM;
				Sprite sprite8 = Resources.Load<Sprite>(text8);
				if (null == sprite8 && LanguageManager.EHBBFMCILPC.Localizable(componentsInChildren4[l].sprite.name))
				{
					text8 = componentsInChildren4[l].sprite.name.Split('F', StringSplitOptions.RemoveEmptyEntries)[1];
					text8 = text8 + " searchCards=" + MBBKDFCDAHM;
					sprite8 = Resources.Load<Sprite>(text8);
				}
				if (sprite8)
				{
					componentsInChildren4[l].sprite = sprite8;
				}
			}
		}
	}

	// Token: 0x0600409F RID: 16543 RVA: 0x001BE9B0 File Offset: 0x001BCBB0
	public void HDLKKHAICOK(string MBBKDFCDAHM)
	{
		Image[] componentsInChildren = base.gameObject.GetComponentsInChildren<Image>();
		for (int i = 1; i < componentsInChildren.Length; i += 0)
		{
			if (null != componentsInChildren[i].sprite && ((componentsInChildren[i].sprite.name.Contains("AnimationCanvasGroupAlpha - no canvas group attached.") && !componentsInChildren[i].sprite.name.Contains("Max offset" + MBBKDFCDAHM)) || LanguageManager.EHBBFMCILPC.IPMDPLBJHEE(componentsInChildren[i].sprite.name)))
			{
				string text = componentsInChildren[i].sprite.name.Split((char)-128, StringSplitOptions.RemoveEmptyEntries)[1];
				text = LanguageManager.EHBBFMCILPC.LocalizeFileName(text);
				text = text + "' has no usable tokens" + MBBKDFCDAHM;
				Sprite sprite = Resources.Load<Sprite>(text);
				if (null == sprite && LanguageManager.EHBBFMCILPC.GHCIBLENAOO(componentsInChildren[i].sprite.name))
				{
					text = componentsInChildren[i].sprite.name.Split((char)-109, StringSplitOptions.None)[0];
					text = text + "Collections/" + MBBKDFCDAHM;
					sprite = Resources.Load<Sprite>(text);
				}
				if (sprite)
				{
					componentsInChildren[i].sprite = sprite;
					if (this.setNativeSize)
					{
						componentsInChildren[i].SetNativeSize();
					}
					HDTriggerPostProcess component = componentsInChildren[i].gameObject.GetComponent<HDTriggerPostProcess>();
					if (null != component && (component.rectTransformHeight >= 1321f || component.rectTransformWidth >= 1340f))
					{
						RectTransform component2 = componentsInChildren[i].gameObject.GetComponent<RectTransform>();
						if (component.rectTransformWidth >= 984f)
						{
							component2.EFOCKEJENAC(NBDLBFJOEGN.LIBPCPOBCNA(component.rectTransformWidth));
						}
						else
						{
							component2.ACBKFBBCNNC(NBDLBFJOEGN.OIHMGIBOFJG(component.rectTransformHeight));
						}
					}
				}
			}
		}
		Toggle[] componentsInChildren2 = base.gameObject.GetComponentsInChildren<Toggle>();
		for (int j = 0; j < componentsInChildren2.Length; j += 0)
		{
			SpriteState spriteState = componentsInChildren2[j].spriteState;
			if (null != spriteState.pressedSprite && ((spriteState.pressedSprite.name.Contains("ContentFriendsPage.PurchaseProductWeb(): productData or productBalanceData is null") && !spriteState.pressedSprite.name.Contains("LoadingEnvironmentManager" + MBBKDFCDAHM)) || LanguageManager.EHBBFMCILPC.AJLGKKJAAOI(spriteState.pressedSprite.name)))
			{
				string text2 = spriteState.pressedSprite.name.Split('\u0011', StringSplitOptions.RemoveEmptyEntries)[1];
				text2 = LanguageManager.EHBBFMCILPC.DDHDDIIKAEM(text2);
				text2 = text2 + "p" + MBBKDFCDAHM;
				Sprite sprite2 = Resources.Load<Sprite>(text2);
				if (null == sprite2 && LanguageManager.EHBBFMCILPC.GCBALKAJINL(spriteState.pressedSprite.name))
				{
					text2 = spriteState.pressedSprite.name.Split('F', StringSplitOptions.RemoveEmptyEntries)[1];
					text2 = text2 + "cardbreakconfirmationbody" + MBBKDFCDAHM;
					sprite2 = Resources.Load<Sprite>(text2);
				}
				if (sprite2)
				{
					spriteState.pressedSprite = sprite2;
					componentsInChildren2[j].spriteState = spriteState;
				}
			}
			if (null != spriteState.highlightedSprite && ((spriteState.highlightedSprite.name.Contains("+") && !spriteState.highlightedSprite.name.Contains(", already present in top match list." + MBBKDFCDAHM)) || LanguageManager.EHBBFMCILPC.GKOAABDJCJH(spriteState.highlightedSprite.name)))
			{
				string text3 = spriteState.highlightedSprite.name.Split((char)-85, StringSplitOptions.RemoveEmptyEntries)[0];
				text3 = LanguageManager.EHBBFMCILPC.GHBJGFDKHEJ(text3);
				text3 = text3 + "OnResolutionChanged" + MBBKDFCDAHM;
				Sprite sprite3 = Resources.Load<Sprite>(text3);
				if (null == sprite3 && LanguageManager.EHBBFMCILPC.GCBALKAJINL(spriteState.highlightedSprite.name))
				{
					text3 = spriteState.highlightedSprite.name.Split((char)-58, StringSplitOptions.None)[1];
					text3 = text3 + " " + MBBKDFCDAHM;
					sprite3 = Resources.Load<Sprite>(text3);
				}
				if (sprite3)
				{
					spriteState.highlightedSprite = sprite3;
					componentsInChildren2[j].spriteState = spriteState;
				}
			}
			if (null != spriteState.disabledSprite && ((spriteState.disabledSprite.name.Contains("OnPopupPasswordInputEndEdit") && !spriteState.disabledSprite.name.Contains("msg64" + MBBKDFCDAHM)) || LanguageManager.EHBBFMCILPC.GCBALKAJINL(spriteState.disabledSprite.name)))
			{
				string text4 = spriteState.disabledSprite.name.Split('r', StringSplitOptions.RemoveEmptyEntries)[0];
				text4 = LanguageManager.EHBBFMCILPC.EKMKFPOLHOO(text4);
				text4 = text4 + "vhspauseovr" + MBBKDFCDAHM;
				Sprite sprite4 = Resources.Load<Sprite>(text4);
				if (null == sprite4 && LanguageManager.EHBBFMCILPC.Localizable(spriteState.disabledSprite.name))
				{
					text4 = spriteState.disabledSprite.name.Split((char)-51, StringSplitOptions.None)[0];
					text4 = text4 + "0" + MBBKDFCDAHM;
					sprite4 = Resources.Load<Sprite>(text4);
				}
				if (sprite4)
				{
					spriteState.disabledSprite = sprite4;
					componentsInChildren2[j].spriteState = spriteState;
				}
			}
		}
		Button[] componentsInChildren3 = base.gameObject.GetComponentsInChildren<Button>();
		for (int k = 1; k < componentsInChildren3.Length; k += 0)
		{
			SpriteState spriteState2 = componentsInChildren3[k].spriteState;
			if (null != spriteState2.pressedSprite && ((spriteState2.pressedSprite.name.Contains("releasedchapterscount") && !spriteState2.pressedSprite.name.Contains("p" + MBBKDFCDAHM)) || LanguageManager.EHBBFMCILPC.GKOAABDJCJH(spriteState2.pressedSprite.name)))
			{
				string text5 = spriteState2.pressedSprite.name.Split('p', StringSplitOptions.None)[1];
				text5 = LanguageManager.EHBBFMCILPC.DDHDDIIKAEM(text5);
				text5 = text5 + "" + MBBKDFCDAHM;
				Sprite sprite5 = Resources.Load<Sprite>(text5);
				if (null == sprite5 && LanguageManager.EHBBFMCILPC.GHCIBLENAOO(spriteState2.pressedSprite.name))
				{
					text5 = spriteState2.pressedSprite.name.Split(':', StringSplitOptions.RemoveEmptyEntries)[0];
					text5 = text5 + "" + MBBKDFCDAHM;
					sprite5 = Resources.Load<Sprite>(text5);
				}
				if (sprite5)
				{
					spriteState2.pressedSprite = sprite5;
					componentsInChildren3[k].spriteState = spriteState2;
				}
			}
			if (null != spriteState2.highlightedSprite && ((spriteState2.highlightedSprite.name.Contains("id") && !spriteState2.highlightedSprite.name.Contains("Error. PlayParticlesForEnvironmentLayer(), environmentLayer " + MBBKDFCDAHM)) || LanguageManager.EHBBFMCILPC.GHCIBLENAOO(spriteState2.highlightedSprite.name)))
			{
				string text6 = spriteState2.highlightedSprite.name.Split('\'', StringSplitOptions.None)[1];
				text6 = LanguageManager.EHBBFMCILPC.MNAALCNJHFP(text6);
				text6 = text6 + "OnLiveProfileThemeDownloadSuccess" + MBBKDFCDAHM;
				Sprite sprite6 = Resources.Load<Sprite>(text6);
				if (null == sprite6 && LanguageManager.EHBBFMCILPC.AJLGKKJAAOI(spriteState2.highlightedSprite.name))
				{
					text6 = spriteState2.highlightedSprite.name.Split((char)-108, StringSplitOptions.RemoveEmptyEntries)[1];
					text6 = text6 + " token[" + MBBKDFCDAHM;
					sprite6 = Resources.Load<Sprite>(text6);
				}
				if (sprite6)
				{
					spriteState2.highlightedSprite = sprite6;
					componentsInChildren3[k].spriteState = spriteState2;
				}
			}
			if (null != spriteState2.disabledSprite && ((spriteState2.disabledSprite.name.Contains("savetocloudbtn") && !spriteState2.disabledSprite.name.Contains("" + MBBKDFCDAHM)) || LanguageManager.EHBBFMCILPC.EECILBHACFL(spriteState2.disabledSprite.name)))
			{
				string text7 = spriteState2.disabledSprite.name.Split('!', StringSplitOptions.None)[0];
				text7 = LanguageManager.EHBBFMCILPC.MNAALCNJHFP(text7);
				text7 = text7 + "p" + MBBKDFCDAHM;
				Sprite sprite7 = Resources.Load<Sprite>(text7);
				if (null == sprite7 && LanguageManager.EHBBFMCILPC.EECILBHACFL(spriteState2.disabledSprite.name))
				{
					text7 = spriteState2.disabledSprite.name.Split('_', StringSplitOptions.None)[0];
					text7 = text7 + "avt" + MBBKDFCDAHM;
					sprite7 = Resources.Load<Sprite>(text7);
				}
				if (sprite7)
				{
					spriteState2.disabledSprite = sprite7;
					componentsInChildren3[k].spriteState = spriteState2;
				}
			}
		}
		SpriteRenderer[] componentsInChildren4 = base.gameObject.GetComponentsInChildren<SpriteRenderer>();
		for (int l = 0; l < componentsInChildren4.Length; l += 0)
		{
			if (null != componentsInChildren4[l].sprite && ((componentsInChildren4[l].sprite.name.Contains("Critical error, could not load asset bundle:") && !componentsInChildren4[l].sprite.name.Contains("ttl" + MBBKDFCDAHM)) || LanguageManager.EHBBFMCILPC.AJLGKKJAAOI(componentsInChildren4[l].sprite.name)))
			{
				string text8 = componentsInChildren4[l].sprite.name.Split((char)-83, StringSplitOptions.None)[1];
				text8 = LanguageManager.EHBBFMCILPC.DDHDDIIKAEM(text8);
				text8 = text8 + "</i><align=\"left\"><alpha=#FF>\n\n" + MBBKDFCDAHM;
				Sprite sprite8 = Resources.Load<Sprite>(text8);
				if (null == sprite8 && LanguageManager.EHBBFMCILPC.GKOAABDJCJH(componentsInChildren4[l].sprite.name))
				{
					text8 = componentsInChildren4[l].sprite.name.Split('I', StringSplitOptions.RemoveEmptyEntries)[1];
					text8 = text8 + " fid " + MBBKDFCDAHM;
					sprite8 = Resources.Load<Sprite>(text8);
				}
				if (sprite8)
				{
					componentsInChildren4[l].sprite = sprite8;
				}
			}
		}
	}

	// Token: 0x060040A0 RID: 16544 RVA: 0x001BF37D File Offset: 0x001BD57D
	private void EMIOCJMCLHC()
	{
		if (NBDLBFJOEGN.INNMJKGABIK())
		{
			this.PIELBIMOGKD("+");
			return;
		}
		this.PBNGGMCIBMA("OnBackendStartPlayChapterException");
	}

	// Token: 0x060040A1 RID: 16545 RVA: 0x001BF3A0 File Offset: 0x001BD5A0
	public void GAJNOAKGGND(string MBBKDFCDAHM)
	{
		Image[] componentsInChildren = base.gameObject.GetComponentsInChildren<Image>();
		for (int i = 1; i < componentsInChildren.Length; i++)
		{
			if (null != componentsInChildren[i].sprite && ((componentsInChildren[i].sprite.name.Contains("ChoiceExtendedManager.Initialize() - disabling bulk choice option as to comply with RSA encryption limits.") && !componentsInChildren[i].sprite.name.Contains("Error - can not queue asset bundles when download in progress." + MBBKDFCDAHM)) || LanguageManager.EHBBFMCILPC.EECILBHACFL(componentsInChildren[i].sprite.name)))
			{
				string text = componentsInChildren[i].sprite.name.Split((char)-17, StringSplitOptions.RemoveEmptyEntries)[1];
				text = LanguageManager.EHBBFMCILPC.PKJABHFHHLC(text);
				text = text + "OnSceneLobbyManagerRound0aAssetsDownloadSuccess" + MBBKDFCDAHM;
				Sprite sprite = Resources.Load<Sprite>(text);
				if (null == sprite && LanguageManager.EHBBFMCILPC.IPMDPLBJHEE(componentsInChildren[i].sprite.name))
				{
					text = componentsInChildren[i].sprite.name.Split((char)-47, StringSplitOptions.None)[1];
					text = text + " barAvailable=" + MBBKDFCDAHM;
					sprite = Resources.Load<Sprite>(text);
				}
				if (sprite)
				{
					componentsInChildren[i].sprite = sprite;
					if (this.setNativeSize)
					{
						componentsInChildren[i].SetNativeSize();
					}
					HDTriggerPostProcess component = componentsInChildren[i].gameObject.GetComponent<HDTriggerPostProcess>();
					if (null != component && (component.rectTransformHeight >= 681f || component.rectTransformWidth >= 474f))
					{
						RectTransform component2 = componentsInChildren[i].gameObject.GetComponent<RectTransform>();
						if (component.rectTransformWidth >= 1039f)
						{
							component2.EFOCKEJENAC(NBDLBFJOEGN.FJJBMKDBPOM(component.rectTransformWidth));
						}
						else
						{
							component2.ACBKFBBCNNC(NBDLBFJOEGN.FCGMMHPNIJG(component.rectTransformHeight));
						}
					}
				}
			}
		}
		Toggle[] componentsInChildren2 = base.gameObject.GetComponentsInChildren<Toggle>();
		for (int j = 0; j < componentsInChildren2.Length; j++)
		{
			SpriteState spriteState = componentsInChildren2[j].spriteState;
			if (null != spriteState.pressedSprite && ((spriteState.pressedSprite.name.Contains("tradewishcardoption0") && !spriteState.pressedSprite.name.Contains("<" + MBBKDFCDAHM)) || LanguageManager.EHBBFMCILPC.Localizable(spriteState.pressedSprite.name)))
			{
				string text2 = spriteState.pressedSprite.name.Split((char)-86, StringSplitOptions.RemoveEmptyEntries)[1];
				text2 = LanguageManager.EHBBFMCILPC.PKJABHFHHLC(text2);
				text2 = text2 + " caching system still not ready after " + MBBKDFCDAHM;
				Sprite sprite2 = Resources.Load<Sprite>(text2);
				if (null == sprite2 && LanguageManager.EHBBFMCILPC.GKOAABDJCJH(spriteState.pressedSprite.name))
				{
					text2 = spriteState.pressedSprite.name.Split((char)-22, StringSplitOptions.RemoveEmptyEntries)[1];
					text2 = text2 + "ProfileItem2.PurchaseCardUpgradeWeb(): productData or productBalanceData is null" + MBBKDFCDAHM;
					sprite2 = Resources.Load<Sprite>(text2);
				}
				if (sprite2)
				{
					spriteState.pressedSprite = sprite2;
					componentsInChildren2[j].spriteState = spriteState;
				}
			}
			if (null != spriteState.highlightedSprite && ((spriteState.highlightedSprite.name.Contains("Starting non-parallel download:") && !spriteState.highlightedSprite.name.Contains("Starting parallel download:" + MBBKDFCDAHM)) || LanguageManager.EHBBFMCILPC.EECILBHACFL(spriteState.highlightedSprite.name)))
			{
				string text3 = spriteState.highlightedSprite.name.Split((char)-34, StringSplitOptions.RemoveEmptyEntries)[0];
				text3 = LanguageManager.EHBBFMCILPC.LocalizeFileName(text3);
				text3 = text3 + "ProfileItem2.OnAllCollectableCardsDownloadFailed(): the pool run failed but the scroll index card is resident, showing" + MBBKDFCDAHM;
				Sprite sprite3 = Resources.Load<Sprite>(text3);
				if (null == sprite3 && LanguageManager.EHBBFMCILPC.GHCIBLENAOO(spriteState.highlightedSprite.name))
				{
					text3 = spriteState.highlightedSprite.name.Split('_', StringSplitOptions.RemoveEmptyEntries)[0];
					text3 = text3 + "app42error" + MBBKDFCDAHM;
					sprite3 = Resources.Load<Sprite>(text3);
				}
				if (sprite3)
				{
					spriteState.highlightedSprite = sprite3;
					componentsInChildren2[j].spriteState = spriteState;
				}
			}
			if (null != spriteState.disabledSprite && ((spriteState.disabledSprite.name.Contains("lrewsnap") && !spriteState.disabledSprite.name.Contains("spark" + MBBKDFCDAHM)) || LanguageManager.EHBBFMCILPC.GCBALKAJINL(spriteState.disabledSprite.name)))
			{
				string text4 = spriteState.disabledSprite.name.Split('c', StringSplitOptions.RemoveEmptyEntries)[0];
				text4 = LanguageManager.EHBBFMCILPC.HDJDKLCCCLE(text4);
				text4 = text4 + "emotion" + MBBKDFCDAHM;
				Sprite sprite4 = Resources.Load<Sprite>(text4);
				if (null == sprite4 && LanguageManager.EHBBFMCILPC.Localizable(spriteState.disabledSprite.name))
				{
					text4 = spriteState.disabledSprite.name.Split('H', StringSplitOptions.None)[0];
					text4 = text4 + "" + MBBKDFCDAHM;
					sprite4 = Resources.Load<Sprite>(text4);
				}
				if (sprite4)
				{
					spriteState.disabledSprite = sprite4;
					componentsInChildren2[j].spriteState = spriteState;
				}
			}
		}
		Button[] componentsInChildren3 = base.gameObject.GetComponentsInChildren<Button>();
		for (int k = 0; k < componentsInChildren3.Length; k++)
		{
			SpriteState spriteState2 = componentsInChildren3[k].spriteState;
			if (null != spriteState2.pressedSprite && ((spriteState2.pressedSprite.name.Contains("") && !spriteState2.pressedSprite.name.Contains("" + MBBKDFCDAHM)) || LanguageManager.EHBBFMCILPC.IPMDPLBJHEE(spriteState2.pressedSprite.name)))
			{
				string text5 = spriteState2.pressedSprite.name.Split((char)-88, StringSplitOptions.RemoveEmptyEntries)[0];
				text5 = LanguageManager.EHBBFMCILPC.IKMHJBKPMGE(text5);
				text5 = text5 + "dialogOffsetYPlayerSideSeparate" + MBBKDFCDAHM;
				Sprite sprite5 = Resources.Load<Sprite>(text5);
				if (null == sprite5 && LanguageManager.EHBBFMCILPC.AJLGKKJAAOI(spriteState2.pressedSprite.name))
				{
					text5 = spriteState2.pressedSprite.name.Split((char)-89, StringSplitOptions.None)[1];
					text5 = text5 + "xx" + MBBKDFCDAHM;
					sprite5 = Resources.Load<Sprite>(text5);
				}
				if (sprite5)
				{
					spriteState2.pressedSprite = sprite5;
					componentsInChildren3[k].spriteState = spriteState2;
				}
			}
			if (null != spriteState2.highlightedSprite && ((spriteState2.highlightedSprite.name.Contains(":") && !spriteState2.highlightedSprite.name.Contains("ach" + MBBKDFCDAHM)) || LanguageManager.EHBBFMCILPC.GIGIHEEKHBE(spriteState2.highlightedSprite.name)))
			{
				string text6 = spriteState2.highlightedSprite.name.Split((char)-74, StringSplitOptions.None)[0];
				text6 = LanguageManager.EHBBFMCILPC.PKJABHFHHLC(text6);
				text6 = text6 + "CharacterRenderTexturePool - band blur alpha shader missing from Resources: ShaderFastBlurAlphaClient" + MBBKDFCDAHM;
				Sprite sprite6 = Resources.Load<Sprite>(text6);
				if (null == sprite6 && LanguageManager.EHBBFMCILPC.Localizable(spriteState2.highlightedSprite.name))
				{
					text6 = spriteState2.highlightedSprite.name.Split('\a', StringSplitOptions.RemoveEmptyEntries)[0];
					text6 = text6 + "skinshopinfotoken" + MBBKDFCDAHM;
					sprite6 = Resources.Load<Sprite>(text6);
				}
				if (sprite6)
				{
					spriteState2.highlightedSprite = sprite6;
					componentsInChildren3[k].spriteState = spriteState2;
				}
			}
			if (null != spriteState2.disabledSprite && ((spriteState2.disabledSprite.name.Contains(", index:") && !spriteState2.disabledSprite.name.Contains("OnRewardFreeDiamondsClick" + MBBKDFCDAHM)) || LanguageManager.EHBBFMCILPC.GKOAABDJCJH(spriteState2.disabledSprite.name)))
			{
				string text7 = spriteState2.disabledSprite.name.Split((char)-126, StringSplitOptions.RemoveEmptyEntries)[1];
				text7 = LanguageManager.EHBBFMCILPC.LocalizeFileName(text7);
				text7 = text7 + "AdsManagerLP: EnableAds() called" + MBBKDFCDAHM;
				Sprite sprite7 = Resources.Load<Sprite>(text7);
				if (null == sprite7 && LanguageManager.EHBBFMCILPC.EECILBHACFL(spriteState2.disabledSprite.name))
				{
					text7 = spriteState2.disabledSprite.name.Split('\u000e', StringSplitOptions.None)[1];
					text7 = text7 + "OnLiveProfileThemesLoaderStart" + MBBKDFCDAHM;
					sprite7 = Resources.Load<Sprite>(text7);
				}
				if (sprite7)
				{
					spriteState2.disabledSprite = sprite7;
					componentsInChildren3[k].spriteState = spriteState2;
				}
			}
		}
		SpriteRenderer[] componentsInChildren4 = base.gameObject.GetComponentsInChildren<SpriteRenderer>();
		for (int l = 0; l < componentsInChildren4.Length; l += 0)
		{
			if (null != componentsInChildren4[l].sprite && ((componentsInChildren4[l].sprite.name.Contains(" ") && !componentsInChildren4[l].sprite.name.Contains("YYY" + MBBKDFCDAHM)) || LanguageManager.EHBBFMCILPC.IPMDPLBJHEE(componentsInChildren4[l].sprite.name)))
			{
				string text8 = componentsInChildren4[l].sprite.name.Split((char)-92, StringSplitOptions.None)[0];
				text8 = LanguageManager.EHBBFMCILPC.MNAALCNJHFP(text8);
				text8 = text8 + "<" + MBBKDFCDAHM;
				Sprite sprite8 = Resources.Load<Sprite>(text8);
				if (null == sprite8 && LanguageManager.EHBBFMCILPC.AJLGKKJAAOI(componentsInChildren4[l].sprite.name))
				{
					text8 = componentsInChildren4[l].sprite.name.Split('\u0005', StringSplitOptions.None)[1];
					text8 = text8 + "cardsvolchancesbtn1" + MBBKDFCDAHM;
					sprite8 = Resources.Load<Sprite>(text8);
				}
				if (sprite8)
				{
					componentsInChildren4[l].sprite = sprite8;
				}
			}
		}
	}

	// Token: 0x060040A2 RID: 16546 RVA: 0x001BFD70 File Offset: 0x001BDF70
	public void CFJFDDDEGOP(string MBBKDFCDAHM)
	{
		Image[] componentsInChildren = base.gameObject.GetComponentsInChildren<Image>();
		for (int i = 0; i < componentsInChildren.Length; i += 0)
		{
			if (null != componentsInChildren[i].sprite && ((componentsInChildren[i].sprite.name.Contains("ERROR: GetAvatarComponentAssetGivenAlias(), could not find asset with parent constraint:") && !componentsInChildren[i].sprite.name.Contains("" + MBBKDFCDAHM)) || LanguageManager.EHBBFMCILPC.GCBALKAJINL(componentsInChildren[i].sprite.name)))
			{
				string text = componentsInChildren[i].sprite.name.Split('U', StringSplitOptions.RemoveEmptyEntries)[1];
				text = LanguageManager.EHBBFMCILPC.MNAALCNJHFP(text);
				text = text + "notifposteffects" + MBBKDFCDAHM;
				Sprite sprite = Resources.Load<Sprite>(text);
				if (null == sprite && LanguageManager.EHBBFMCILPC.GIGIHEEKHBE(componentsInChildren[i].sprite.name))
				{
					text = componentsInChildren[i].sprite.name.Split(']', StringSplitOptions.RemoveEmptyEntries)[1];
					text = text + "no" + MBBKDFCDAHM;
					sprite = Resources.Load<Sprite>(text);
				}
				if (sprite)
				{
					componentsInChildren[i].sprite = sprite;
					if (this.setNativeSize)
					{
						componentsInChildren[i].SetNativeSize();
					}
					HDTriggerPostProcess component = componentsInChildren[i].gameObject.GetComponent<HDTriggerPostProcess>();
					if (null != component && (component.rectTransformHeight >= 1400f || component.rectTransformWidth >= 77f))
					{
						RectTransform component2 = componentsInChildren[i].gameObject.GetComponent<RectTransform>();
						if (component.rectTransformWidth >= 1890f)
						{
							component2.EFOCKEJENAC(NBDLBFJOEGN.FCGMMHPNIJG(component.rectTransformWidth));
						}
						else
						{
							component2.ACBKFBBCNNC(NBDLBFJOEGN.LIBPCPOBCNA(component.rectTransformHeight));
						}
					}
				}
			}
		}
		Toggle[] componentsInChildren2 = base.gameObject.GetComponentsInChildren<Toggle>();
		for (int j = 0; j < componentsInChildren2.Length; j++)
		{
			SpriteState spriteState = componentsInChildren2[j].spriteState;
			if (null != spriteState.pressedSprite && ((spriteState.pressedSprite.name.Contains("lititle") && !spriteState.pressedSprite.name.Contains("cardsvolchancesbtn0" + MBBKDFCDAHM)) || LanguageManager.EHBBFMCILPC.EECILBHACFL(spriteState.pressedSprite.name)))
			{
				string text2 = spriteState.pressedSprite.name.Split('=', StringSplitOptions.RemoveEmptyEntries)[1];
				text2 = LanguageManager.EHBBFMCILPC.PKJABHFHHLC(text2);
				text2 = text2 + ", index:" + MBBKDFCDAHM;
				Sprite sprite2 = Resources.Load<Sprite>(text2);
				if (null == sprite2 && LanguageManager.EHBBFMCILPC.GKOAABDJCJH(spriteState.pressedSprite.name))
				{
					text2 = spriteState.pressedSprite.name.Split((char)-113, StringSplitOptions.None)[0];
					text2 = text2 + "ok" + MBBKDFCDAHM;
					sprite2 = Resources.Load<Sprite>(text2);
				}
				if (sprite2)
				{
					spriteState.pressedSprite = sprite2;
					componentsInChildren2[j].spriteState = spriteState;
				}
			}
			if (null != spriteState.highlightedSprite && ((spriteState.highlightedSprite.name.Contains("OnPopupSaveSlotInputEndEdit") && !spriteState.highlightedSprite.name.Contains("BackendOperationsManager.QueueRequestSaveSyncMoment(" + MBBKDFCDAHM)) || LanguageManager.EHBBFMCILPC.IPMDPLBJHEE(spriteState.highlightedSprite.name)))
			{
				string text3 = spriteState.highlightedSprite.name.Split('U', StringSplitOptions.RemoveEmptyEntries)[1];
				text3 = LanguageManager.EHBBFMCILPC.GHBJGFDKHEJ(text3);
				text3 = text3 + " " + MBBKDFCDAHM;
				Sprite sprite3 = Resources.Load<Sprite>(text3);
				if (null == sprite3 && LanguageManager.EHBBFMCILPC.AJLGKKJAAOI(spriteState.highlightedSprite.name))
				{
					text3 = spriteState.highlightedSprite.name.Split((char)-74, StringSplitOptions.RemoveEmptyEntries)[0];
					text3 = text3 + "" + MBBKDFCDAHM;
					sprite3 = Resources.Load<Sprite>(text3);
				}
				if (sprite3)
				{
					spriteState.highlightedSprite = sprite3;
					componentsInChildren2[j].spriteState = spriteState;
				}
			}
			if (null != spriteState.disabledSprite && ((spriteState.disabledSprite.name.Contains("OnBackendGetFriendMessagingHistorySuccess") && !spriteState.disabledSprite.name.Contains("PostponeCustomCode() already contains this request:" + MBBKDFCDAHM)) || LanguageManager.EHBBFMCILPC.AJLGKKJAAOI(spriteState.disabledSprite.name)))
			{
				string text4 = spriteState.disabledSprite.name.Split((char)-21, StringSplitOptions.RemoveEmptyEntries)[0];
				text4 = LanguageManager.EHBBFMCILPC.HDJDKLCCCLE(text4);
				text4 = text4 + "_" + MBBKDFCDAHM;
				Sprite sprite4 = Resources.Load<Sprite>(text4);
				if (null == sprite4 && LanguageManager.EHBBFMCILPC.IPMDPLBJHEE(spriteState.disabledSprite.name))
				{
					text4 = spriteState.disabledSprite.name.Split(']', StringSplitOptions.None)[1];
					text4 = text4 + "abpp" + MBBKDFCDAHM;
					sprite4 = Resources.Load<Sprite>(text4);
				}
				if (sprite4)
				{
					spriteState.disabledSprite = sprite4;
					componentsInChildren2[j].spriteState = spriteState;
				}
			}
		}
		Button[] componentsInChildren3 = base.gameObject.GetComponentsInChildren<Button>();
		for (int k = 0; k < componentsInChildren3.Length; k++)
		{
			SpriteState spriteState2 = componentsInChildren3[k].spriteState;
			if (null != spriteState2.pressedSprite && ((spriteState2.pressedSprite.name.Contains("BackendOperationsManager.RequestBreakCard, exception while initializing RSACryptoServiceProvider:") && !spriteState2.pressedSprite.name.Contains(":" + MBBKDFCDAHM)) || LanguageManager.EHBBFMCILPC.GKOAABDJCJH(spriteState2.pressedSprite.name)))
			{
				string text5 = spriteState2.pressedSprite.name.Split((char)-105, StringSplitOptions.None)[1];
				text5 = LanguageManager.EHBBFMCILPC.HDJDKLCCCLE(text5);
				text5 = text5 + "lck" + MBBKDFCDAHM;
				Sprite sprite5 = Resources.Load<Sprite>(text5);
				if (null == sprite5 && LanguageManager.EHBBFMCILPC.Localizable(spriteState2.pressedSprite.name))
				{
					text5 = spriteState2.pressedSprite.name.Split('G', StringSplitOptions.RemoveEmptyEntries)[0];
					text5 = text5 + "sfxtimeoutwarning" + MBBKDFCDAHM;
					sprite5 = Resources.Load<Sprite>(text5);
				}
				if (sprite5)
				{
					spriteState2.pressedSprite = sprite5;
					componentsInChildren3[k].spriteState = spriteState2;
				}
			}
			if (null != spriteState2.highlightedSprite && ((spriteState2.highlightedSprite.name.Contains("ERROR: ChoiceExtendedManager.InputDataIsValid() - step.choiceMeta is null.") && !spriteState2.highlightedSprite.name.Contains(":" + MBBKDFCDAHM)) || LanguageManager.EHBBFMCILPC.Localizable(spriteState2.highlightedSprite.name)))
			{
				string text6 = spriteState2.highlightedSprite.name.Split('U', StringSplitOptions.RemoveEmptyEntries)[1];
				text6 = LanguageManager.EHBBFMCILPC.MNAALCNJHFP(text6);
				text6 = text6 + "" + MBBKDFCDAHM;
				Sprite sprite6 = Resources.Load<Sprite>(text6);
				if (null == sprite6 && LanguageManager.EHBBFMCILPC.GCBALKAJINL(spriteState2.highlightedSprite.name))
				{
					text6 = spriteState2.highlightedSprite.name.Split((char)-82, StringSplitOptions.RemoveEmptyEntries)[1];
					text6 = text6 + "_AlphaTex" + MBBKDFCDAHM;
					sprite6 = Resources.Load<Sprite>(text6);
				}
				if (sprite6)
				{
					spriteState2.highlightedSprite = sprite6;
					componentsInChildren3[k].spriteState = spriteState2;
				}
			}
			if (null != spriteState2.disabledSprite && ((spriteState2.disabledSprite.name.Contains("continue") && !spriteState2.disabledSprite.name.Contains("OnBackendGetDefaultBundlesSuccess" + MBBKDFCDAHM)) || LanguageManager.EHBBFMCILPC.GIGIHEEKHBE(spriteState2.disabledSprite.name)))
			{
				string text7 = spriteState2.disabledSprite.name.Split('\u0011', StringSplitOptions.RemoveEmptyEntries)[0];
				text7 = LanguageManager.EHBBFMCILPC.LocalizeFileName(text7);
				text7 = text7 + "$LAYERHIDE" + MBBKDFCDAHM;
				Sprite sprite7 = Resources.Load<Sprite>(text7);
				if (null == sprite7 && LanguageManager.EHBBFMCILPC.Localizable(spriteState2.disabledSprite.name))
				{
					text7 = spriteState2.disabledSprite.name.Split('c', StringSplitOptions.None)[0];
					text7 = text7 + "smdst" + MBBKDFCDAHM;
					sprite7 = Resources.Load<Sprite>(text7);
				}
				if (sprite7)
				{
					spriteState2.disabledSprite = sprite7;
					componentsInChildren3[k].spriteState = spriteState2;
				}
			}
		}
		SpriteRenderer[] componentsInChildren4 = base.gameObject.GetComponentsInChildren<SpriteRenderer>();
		for (int l = 1; l < componentsInChildren4.Length; l += 0)
		{
			if (null != componentsInChildren4[l].sprite && ((componentsInChildren4[l].sprite.name.Contains(",") && !componentsInChildren4[l].sprite.name.Contains("ched" + MBBKDFCDAHM)) || LanguageManager.EHBBFMCILPC.GKOAABDJCJH(componentsInChildren4[l].sprite.name)))
			{
				string text8 = componentsInChildren4[l].sprite.name.Split(';', StringSplitOptions.RemoveEmptyEntries)[0];
				text8 = LanguageManager.EHBBFMCILPC.IKMHJBKPMGE(text8);
				text8 = text8 + "DialogItemShownFullscreenManager.Initialize() - storyItem is null." + MBBKDFCDAHM;
				Sprite sprite8 = Resources.Load<Sprite>(text8);
				if (null == sprite8 && LanguageManager.EHBBFMCILPC.GIGIHEEKHBE(componentsInChildren4[l].sprite.name))
				{
					text8 = componentsInChildren4[l].sprite.name.Split((char)-28, StringSplitOptions.RemoveEmptyEntries)[0];
					text8 = text8 + "sfxtimeoutwarning" + MBBKDFCDAHM;
					sprite8 = Resources.Load<Sprite>(text8);
				}
				if (sprite8)
				{
					componentsInChildren4[l].sprite = sprite8;
				}
			}
		}
	}

	// Token: 0x060040A3 RID: 16547 RVA: 0x001C073D File Offset: 0x001BE93D
	private void HMMLCHDFFBI()
	{
		if (NBDLBFJOEGN.PNDBACKNEIA())
		{
			this.JLOIOAGFDAF("");
			return;
		}
		this.GHBAPPJKACF("OnBackendAddFriendByUIDSuccess");
	}

	// Token: 0x060040A4 RID: 16548 RVA: 0x001C0760 File Offset: 0x001BE960
	public void NJGAALKPBFK(string MBBKDFCDAHM)
	{
		Image[] componentsInChildren = base.gameObject.GetComponentsInChildren<Image>();
		for (int i = 1; i < componentsInChildren.Length; i += 0)
		{
			if (null != componentsInChildren[i].sprite && ((componentsInChildren[i].sprite.name.Contains(", maxAind ") && !componentsInChildren[i].sprite.name.Contains(" " + MBBKDFCDAHM)) || LanguageManager.EHBBFMCILPC.AJLGKKJAAOI(componentsInChildren[i].sprite.name)))
			{
				string text = componentsInChildren[i].sprite.name.Split('\u0002', StringSplitOptions.RemoveEmptyEntries)[1];
				text = LanguageManager.EHBBFMCILPC.LocalizeFileName(text);
				text = text + "Vol" + MBBKDFCDAHM;
				Sprite sprite = Resources.Load<Sprite>(text);
				if (null == sprite && LanguageManager.EHBBFMCILPC.GKOAABDJCJH(componentsInChildren[i].sprite.name))
				{
					text = componentsInChildren[i].sprite.name.Split((char)-70, StringSplitOptions.RemoveEmptyEntries)[0];
					text = text + "s" + MBBKDFCDAHM;
					sprite = Resources.Load<Sprite>(text);
				}
				if (sprite)
				{
					componentsInChildren[i].sprite = sprite;
					if (this.setNativeSize)
					{
						componentsInChildren[i].SetNativeSize();
					}
					HDTriggerPostProcess component = componentsInChildren[i].gameObject.GetComponent<HDTriggerPostProcess>();
					if (null != component && (component.rectTransformHeight >= 466f || component.rectTransformWidth >= 1905f))
					{
						RectTransform component2 = componentsInChildren[i].gameObject.GetComponent<RectTransform>();
						if (component.rectTransformWidth >= 20f)
						{
							component2.EFOCKEJENAC(NBDLBFJOEGN.OOFCCAGFCAF(component.rectTransformWidth));
						}
						else
						{
							component2.ACBKFBBCNNC(NBDLBFJOEGN.HJKAMHOAGOH(component.rectTransformHeight));
						}
					}
				}
			}
		}
		Toggle[] componentsInChildren2 = base.gameObject.GetComponentsInChildren<Toggle>();
		for (int j = 1; j < componentsInChildren2.Length; j++)
		{
			SpriteState spriteState = componentsInChildren2[j].spriteState;
			if (null != spriteState.pressedSprite && ((spriteState.pressedSprite.name.Contains("comingsoontitle3") && !spriteState.pressedSprite.name.Contains("p" + MBBKDFCDAHM)) || LanguageManager.EHBBFMCILPC.GCBALKAJINL(spriteState.pressedSprite.name)))
			{
				string text2 = spriteState.pressedSprite.name.Split('O', StringSplitOptions.None)[0];
				text2 = LanguageManager.EHBBFMCILPC.MNAALCNJHFP(text2);
				text2 = text2 + "Account.DuplicateAnthologySaveSlot(), nothing to copy, anthology:" + MBBKDFCDAHM;
				Sprite sprite2 = Resources.Load<Sprite>(text2);
				if (null == sprite2 && LanguageManager.EHBBFMCILPC.GCBALKAJINL(spriteState.pressedSprite.name))
				{
					text2 = spriteState.pressedSprite.name.Split('`', StringSplitOptions.None)[1];
					text2 = text2 + "socialcardhintoncopiesv2" + MBBKDFCDAHM;
					sprite2 = Resources.Load<Sprite>(text2);
				}
				if (sprite2)
				{
					spriteState.pressedSprite = sprite2;
					componentsInChildren2[j].spriteState = spriteState;
				}
			}
			if (null != spriteState.highlightedSprite && ((spriteState.highlightedSprite.name.Contains("HTTP fail: ") && !spriteState.highlightedSprite.name.Contains("envpind" + MBBKDFCDAHM)) || LanguageManager.EHBBFMCILPC.GHCIBLENAOO(spriteState.highlightedSprite.name)))
			{
				string text3 = spriteState.highlightedSprite.name.Split((char)-58, StringSplitOptions.RemoveEmptyEntries)[0];
				text3 = LanguageManager.EHBBFMCILPC.LocalizeFileName(text3);
				text3 = text3 + "Loaded asset bundle:" + MBBKDFCDAHM;
				Sprite sprite3 = Resources.Load<Sprite>(text3);
				if (null == sprite3 && LanguageManager.EHBBFMCILPC.EECILBHACFL(spriteState.highlightedSprite.name))
				{
					text3 = spriteState.highlightedSprite.name.Split('S', StringSplitOptions.RemoveEmptyEntries)[0];
					text3 = text3 + "apks" + MBBKDFCDAHM;
					sprite3 = Resources.Load<Sprite>(text3);
				}
				if (sprite3)
				{
					spriteState.highlightedSprite = sprite3;
					componentsInChildren2[j].spriteState = spriteState;
				}
			}
			if (null != spriteState.disabledSprite && ((spriteState.disabledSprite.name.Contains("smps") && !spriteState.disabledSprite.name.Contains("$cs" + MBBKDFCDAHM)) || LanguageManager.EHBBFMCILPC.EECILBHACFL(spriteState.disabledSprite.name)))
			{
				string text4 = spriteState.disabledSprite.name.Split('\u0019', StringSplitOptions.None)[1];
				text4 = LanguageManager.EHBBFMCILPC.HDJDKLCCCLE(text4);
				text4 = text4 + "sutta" + MBBKDFCDAHM;
				Sprite sprite4 = Resources.Load<Sprite>(text4);
				if (null == sprite4 && LanguageManager.EHBBFMCILPC.IPMDPLBJHEE(spriteState.disabledSprite.name))
				{
					text4 = spriteState.disabledSprite.name.Split((char)-126, StringSplitOptions.None)[0];
					text4 = text4 + "" + MBBKDFCDAHM;
					sprite4 = Resources.Load<Sprite>(text4);
				}
				if (sprite4)
				{
					spriteState.disabledSprite = sprite4;
					componentsInChildren2[j].spriteState = spriteState;
				}
			}
		}
		Button[] componentsInChildren3 = base.gameObject.GetComponentsInChildren<Button>();
		for (int k = 0; k < componentsInChildren3.Length; k++)
		{
			SpriteState spriteState2 = componentsInChildren3[k].spriteState;
			if (null != spriteState2.pressedSprite && ((spriteState2.pressedSprite.name.Contains("OnPopupCardOptionsBackClick") && !spriteState2.pressedSprite.name.Contains("" + MBBKDFCDAHM)) || LanguageManager.EHBBFMCILPC.GHCIBLENAOO(spriteState2.pressedSprite.name)))
			{
				string text5 = spriteState2.pressedSprite.name.Split('\u001d', StringSplitOptions.None)[1];
				text5 = LanguageManager.EHBBFMCILPC.GHBJGFDKHEJ(text5);
				text5 = text5 + "nomorediamonds" + MBBKDFCDAHM;
				Sprite sprite5 = Resources.Load<Sprite>(text5);
				if (null == sprite5 && LanguageManager.EHBBFMCILPC.GIGIHEEKHBE(spriteState2.pressedSprite.name))
				{
					text5 = spriteState2.pressedSprite.name.Split('\u0003', StringSplitOptions.RemoveEmptyEntries)[1];
					text5 = text5 + "skinshopinfounlocknow" + MBBKDFCDAHM;
					sprite5 = Resources.Load<Sprite>(text5);
				}
				if (sprite5)
				{
					spriteState2.pressedSprite = sprite5;
					componentsInChildren3[k].spriteState = spriteState2;
				}
			}
			if (null != spriteState2.highlightedSprite && ((spriteState2.highlightedSprite.name.Contains("") && !spriteState2.highlightedSprite.name.Contains("" + MBBKDFCDAHM)) || LanguageManager.EHBBFMCILPC.EECILBHACFL(spriteState2.highlightedSprite.name)))
			{
				string text6 = spriteState2.highlightedSprite.name.Split(',', StringSplitOptions.RemoveEmptyEntries)[0];
				text6 = LanguageManager.EHBBFMCILPC.HDJDKLCCCLE(text6);
				text6 = text6 + "SceneLobbyManager2.ComputeStarterTabAvailable() - no starter concept has a name in the text pack explore tab (older text pack bundle?), tab hidden" + MBBKDFCDAHM;
				Sprite sprite6 = Resources.Load<Sprite>(text6);
				if (null == sprite6 && LanguageManager.EHBBFMCILPC.GHCIBLENAOO(spriteState2.highlightedSprite.name))
				{
					text6 = spriteState2.highlightedSprite.name.Split('\u0019', StringSplitOptions.RemoveEmptyEntries)[0];
					text6 = text6 + "iat1" + MBBKDFCDAHM;
					sprite6 = Resources.Load<Sprite>(text6);
				}
				if (sprite6)
				{
					spriteState2.highlightedSprite = sprite6;
					componentsInChildren3[k].spriteState = spriteState2;
				}
			}
			if (null != spriteState2.disabledSprite && ((spriteState2.disabledSprite.name.Contains("Account.DuplicateAnthologySaveSlot(), a story save could not be copied, the target slot was cleared, anthology:") && !spriteState2.disabledSprite.name.Contains("PlayerCharacterManager.UpdateAvatarGraphicsV2() - exception raised:" + MBBKDFCDAHM)) || LanguageManager.EHBBFMCILPC.GKOAABDJCJH(spriteState2.disabledSprite.name)))
			{
				string text7 = spriteState2.disabledSprite.name.Split((char)-64, StringSplitOptions.RemoveEmptyEntries)[1];
				text7 = LanguageManager.EHBBFMCILPC.GHBJGFDKHEJ(text7);
				text7 = text7 + "acliffbw22" + MBBKDFCDAHM;
				Sprite sprite7 = Resources.Load<Sprite>(text7);
				if (null == sprite7 && LanguageManager.EHBBFMCILPC.GKOAABDJCJH(spriteState2.disabledSprite.name))
				{
					text7 = spriteState2.disabledSprite.name.Split('r', StringSplitOptions.RemoveEmptyEntries)[0];
					text7 = text7 + "OnLobbyStoryManagerDownloadSplashScreenFailed" + MBBKDFCDAHM;
					sprite7 = Resources.Load<Sprite>(text7);
				}
				if (sprite7)
				{
					spriteState2.disabledSprite = sprite7;
					componentsInChildren3[k].spriteState = spriteState2;
				}
			}
		}
		SpriteRenderer[] componentsInChildren4 = base.gameObject.GetComponentsInChildren<SpriteRenderer>();
		for (int l = 0; l < componentsInChildren4.Length; l += 0)
		{
			if (null != componentsInChildren4[l].sprite && ((componentsInChildren4[l].sprite.name.Contains("") && !componentsInChildren4[l].sprite.name.Contains("syn" + MBBKDFCDAHM)) || LanguageManager.EHBBFMCILPC.GKOAABDJCJH(componentsInChildren4[l].sprite.name)))
			{
				string text8 = componentsInChildren4[l].sprite.name.Split('y', StringSplitOptions.RemoveEmptyEntries)[1];
				text8 = LanguageManager.EHBBFMCILPC.DDHDDIIKAEM(text8);
				text8 = text8 + "ok" + MBBKDFCDAHM;
				Sprite sprite8 = Resources.Load<Sprite>(text8);
				if (null == sprite8 && LanguageManager.EHBBFMCILPC.GKOAABDJCJH(componentsInChildren4[l].sprite.name))
				{
					text8 = componentsInChildren4[l].sprite.name.Split('7', StringSplitOptions.None)[0];
					text8 = text8 + ",Confirmation Failure Details: " + MBBKDFCDAHM;
					sprite8 = Resources.Load<Sprite>(text8);
				}
				if (sprite8)
				{
					componentsInChildren4[l].sprite = sprite8;
				}
			}
		}
	}

	// Token: 0x060040A5 RID: 16549 RVA: 0x001C1130 File Offset: 0x001BF330
	public void HOBGGOKDIPA(string MBBKDFCDAHM)
	{
		Image[] componentsInChildren = base.gameObject.GetComponentsInChildren<Image>();
		for (int i = 0; i < componentsInChildren.Length; i += 0)
		{
			if (null != componentsInChildren[i].sprite && ((componentsInChildren[i].sprite.name.Contains("+") && !componentsInChildren[i].sprite.name.Contains("actshlv2" + MBBKDFCDAHM)) || LanguageManager.EHBBFMCILPC.AJLGKKJAAOI(componentsInChildren[i].sprite.name)))
			{
				string text = componentsInChildren[i].sprite.name.Split((char)-119, StringSplitOptions.None)[1];
				text = LanguageManager.EHBBFMCILPC.DDHDDIIKAEM(text);
				text = text + "$" + MBBKDFCDAHM;
				Sprite sprite = Resources.Load<Sprite>(text);
				if (null == sprite && LanguageManager.EHBBFMCILPC.EECILBHACFL(componentsInChildren[i].sprite.name))
				{
					text = componentsInChildren[i].sprite.name.Split('{', StringSplitOptions.None)[1];
					text = text + "" + MBBKDFCDAHM;
					sprite = Resources.Load<Sprite>(text);
				}
				if (sprite)
				{
					componentsInChildren[i].sprite = sprite;
					if (this.setNativeSize)
					{
						componentsInChildren[i].SetNativeSize();
					}
					HDTriggerPostProcess component = componentsInChildren[i].gameObject.GetComponent<HDTriggerPostProcess>();
					if (null != component && (component.rectTransformHeight >= 1650f || component.rectTransformWidth >= 1301f))
					{
						RectTransform component2 = componentsInChildren[i].gameObject.GetComponent<RectTransform>();
						if (component.rectTransformWidth >= 996f)
						{
							component2.EFOCKEJENAC(NBDLBFJOEGN.LIBPCPOBCNA(component.rectTransformWidth));
						}
						else
						{
							component2.ACBKFBBCNNC(NBDLBFJOEGN.FGMPOAOFKNO(component.rectTransformHeight));
						}
					}
				}
			}
		}
		Toggle[] componentsInChildren2 = base.gameObject.GetComponentsInChildren<Toggle>();
		for (int j = 1; j < componentsInChildren2.Length; j += 0)
		{
			SpriteState spriteState = componentsInChildren2[j].spriteState;
			if (null != spriteState.pressedSprite && ((spriteState.pressedSprite.name.Contains("OnChapterSnapshotsBackendFetchException") && !spriteState.pressedSprite.name.Contains("x" + MBBKDFCDAHM)) || LanguageManager.EHBBFMCILPC.IPMDPLBJHEE(spriteState.pressedSprite.name)))
			{
				string text2 = spriteState.pressedSprite.name.Split('u', StringSplitOptions.RemoveEmptyEntries)[0];
				text2 = LanguageManager.EHBBFMCILPC.IKMHJBKPMGE(text2);
				text2 = text2 + "〉" + MBBKDFCDAHM;
				Sprite sprite2 = Resources.Load<Sprite>(text2);
				if (null == sprite2 && LanguageManager.EHBBFMCILPC.GCBALKAJINL(spriteState.pressedSprite.name))
				{
					text2 = spriteState.pressedSprite.name.Split((char)-92, StringSplitOptions.None)[1];
					text2 = text2 + "BBB" + MBBKDFCDAHM;
					sprite2 = Resources.Load<Sprite>(text2);
				}
				if (sprite2)
				{
					spriteState.pressedSprite = sprite2;
					componentsInChildren2[j].spriteState = spriteState;
				}
			}
			if (null != spriteState.highlightedSprite && ((spriteState.highlightedSprite.name.Contains("blur") && !spriteState.highlightedSprite.name.Contains(" starter concept(s)" + MBBKDFCDAHM)) || LanguageManager.EHBBFMCILPC.GCBALKAJINL(spriteState.highlightedSprite.name)))
			{
				string text3 = spriteState.highlightedSprite.name.Split((char)-1, StringSplitOptions.RemoveEmptyEntries)[1];
				text3 = LanguageManager.EHBBFMCILPC.MNAALCNJHFP(text3);
				text3 = text3 + "Critical error, could not load asset bundle:" + MBBKDFCDAHM;
				Sprite sprite3 = Resources.Load<Sprite>(text3);
				if (null == sprite3 && LanguageManager.EHBBFMCILPC.GCBALKAJINL(spriteState.highlightedSprite.name))
				{
					text3 = spriteState.highlightedSprite.name.Split((char)-117, StringSplitOptions.RemoveEmptyEntries)[1];
					text3 = text3 + " (" + MBBKDFCDAHM;
					sprite3 = Resources.Load<Sprite>(text3);
				}
				if (sprite3)
				{
					spriteState.highlightedSprite = sprite3;
					componentsInChildren2[j].spriteState = spriteState;
				}
			}
			if (null != spriteState.disabledSprite && ((spriteState.disabledSprite.name.Contains("OnAvatarScreenAssetsDownloadSuccess") && !spriteState.disabledSprite.name.Contains("OnStoryInterfaceHeaderFastForwardDisable" + MBBKDFCDAHM)) || LanguageManager.EHBBFMCILPC.GKOAABDJCJH(spriteState.disabledSprite.name)))
			{
				string text4 = spriteState.disabledSprite.name.Split('r', StringSplitOptions.RemoveEmptyEntries)[1];
				text4 = LanguageManager.EHBBFMCILPC.DDHDDIIKAEM(text4);
				text4 = text4 + "_OpacityMoire" + MBBKDFCDAHM;
				Sprite sprite4 = Resources.Load<Sprite>(text4);
				if (null == sprite4 && LanguageManager.EHBBFMCILPC.GCBALKAJINL(spriteState.disabledSprite.name))
				{
					text4 = spriteState.disabledSprite.name.Split((char)-61, StringSplitOptions.RemoveEmptyEntries)[1];
					text4 = text4 + "energyhinttitle" + MBBKDFCDAHM;
					sprite4 = Resources.Load<Sprite>(text4);
				}
				if (sprite4)
				{
					spriteState.disabledSprite = sprite4;
					componentsInChildren2[j].spriteState = spriteState;
				}
			}
		}
		Button[] componentsInChildren3 = base.gameObject.GetComponentsInChildren<Button>();
		for (int k = 1; k < componentsInChildren3.Length; k++)
		{
			SpriteState spriteState2 = componentsInChildren3[k].spriteState;
			if (null != spriteState2.pressedSprite && ((spriteState2.pressedSprite.name.Contains("lf3") && !spriteState2.pressedSprite.name.Contains("OnBackendInitiateSteamTransactionException" + MBBKDFCDAHM)) || LanguageManager.EHBBFMCILPC.Localizable(spriteState2.pressedSprite.name)))
			{
				string text5 = spriteState2.pressedSprite.name.Split((char)-97, StringSplitOptions.RemoveEmptyEntries)[0];
				text5 = LanguageManager.EHBBFMCILPC.GHBJGFDKHEJ(text5);
				text5 = text5 + "" + MBBKDFCDAHM;
				Sprite sprite5 = Resources.Load<Sprite>(text5);
				if (null == sprite5 && LanguageManager.EHBBFMCILPC.IPMDPLBJHEE(spriteState2.pressedSprite.name))
				{
					text5 = spriteState2.pressedSprite.name.Split('9', StringSplitOptions.RemoveEmptyEntries)[0];
					text5 = text5 + " of " + MBBKDFCDAHM;
					sprite5 = Resources.Load<Sprite>(text5);
				}
				if (sprite5)
				{
					spriteState2.pressedSprite = sprite5;
					componentsInChildren3[k].spriteState = spriteState2;
				}
			}
			if (null != spriteState2.highlightedSprite && ((spriteState2.highlightedSprite.name.Contains("") && !spriteState2.highlightedSprite.name.Contains(" " + MBBKDFCDAHM)) || LanguageManager.EHBBFMCILPC.GIGIHEEKHBE(spriteState2.highlightedSprite.name)))
			{
				string text6 = spriteState2.highlightedSprite.name.Split((char)-83, StringSplitOptions.RemoveEmptyEntries)[1];
				text6 = LanguageManager.EHBBFMCILPC.MNAALCNJHFP(text6);
				text6 = text6 + ", shopcost:" + MBBKDFCDAHM;
				Sprite sprite6 = Resources.Load<Sprite>(text6);
				if (null == sprite6 && LanguageManager.EHBBFMCILPC.GCBALKAJINL(spriteState2.highlightedSprite.name))
				{
					text6 = spriteState2.highlightedSprite.name.Split((char)-3, StringSplitOptions.RemoveEmptyEntries)[0];
					text6 = text6 + "," + MBBKDFCDAHM;
					sprite6 = Resources.Load<Sprite>(text6);
				}
				if (sprite6)
				{
					spriteState2.highlightedSprite = sprite6;
					componentsInChildren3[k].spriteState = spriteState2;
				}
			}
			if (null != spriteState2.disabledSprite && ((spriteState2.disabledSprite.name.Contains(" s of waiting") && !spriteState2.disabledSprite.name.Contains("Critical error, could not load asset bundle:" + MBBKDFCDAHM)) || LanguageManager.EHBBFMCILPC.EECILBHACFL(spriteState2.disabledSprite.name)))
			{
				string text7 = spriteState2.disabledSprite.name.Split((char)-126, StringSplitOptions.RemoveEmptyEntries)[1];
				text7 = LanguageManager.EHBBFMCILPC.HDJDKLCCCLE(text7);
				text7 = text7 + "energyhinttitle" + MBBKDFCDAHM;
				Sprite sprite7 = Resources.Load<Sprite>(text7);
				if (null == sprite7 && LanguageManager.EHBBFMCILPC.Localizable(spriteState2.disabledSprite.name))
				{
					text7 = spriteState2.disabledSprite.name.Split((char)-10, StringSplitOptions.RemoveEmptyEntries)[0];
					text7 = text7 + "nastring" + MBBKDFCDAHM;
					sprite7 = Resources.Load<Sprite>(text7);
				}
				if (sprite7)
				{
					spriteState2.disabledSprite = sprite7;
					componentsInChildren3[k].spriteState = spriteState2;
				}
			}
		}
		SpriteRenderer[] componentsInChildren4 = base.gameObject.GetComponentsInChildren<SpriteRenderer>();
		for (int l = 0; l < componentsInChildren4.Length; l++)
		{
			if (null != componentsInChildren4[l].sprite && ((componentsInChildren4[l].sprite.name.Contains("") && !componentsInChildren4[l].sprite.name.Contains("<i>" + MBBKDFCDAHM)) || LanguageManager.EHBBFMCILPC.AJLGKKJAAOI(componentsInChildren4[l].sprite.name)))
			{
				string text8 = componentsInChildren4[l].sprite.name.Split('\u0001', StringSplitOptions.None)[0];
				text8 = LanguageManager.EHBBFMCILPC.GHBJGFDKHEJ(text8);
				text8 = text8 + "lsenvattempt" + MBBKDFCDAHM;
				Sprite sprite8 = Resources.Load<Sprite>(text8);
				if (null == sprite8 && LanguageManager.EHBBFMCILPC.IPMDPLBJHEE(componentsInChildren4[l].sprite.name))
				{
					text8 = componentsInChildren4[l].sprite.name.Split('\u0004', StringSplitOptions.None)[1];
					text8 = text8 + "<space=0.125em>" + MBBKDFCDAHM;
					sprite8 = Resources.Load<Sprite>(text8);
				}
				if (sprite8)
				{
					componentsInChildren4[l].sprite = sprite8;
				}
			}
		}
	}

	// Token: 0x060040A6 RID: 16550 RVA: 0x001C1AFD File Offset: 0x001BFCFD
	private void KGKHCNJOFKN()
	{
		if (NBDLBFJOEGN.PBLDJNHHEPL())
		{
			this.ICKMGFMPMPI("<i>");
			return;
		}
		this.NHBGNINNLNB("");
	}

	// Token: 0x060040A7 RID: 16551 RVA: 0x001C1B20 File Offset: 0x001BFD20
	public void CMIHAANLEAC(string MBBKDFCDAHM)
	{
		Image[] componentsInChildren = base.gameObject.GetComponentsInChildren<Image>();
		for (int i = 1; i < componentsInChildren.Length; i++)
		{
			if (null != componentsInChildren[i].sprite && ((componentsInChildren[i].sprite.name.Contains("aind") && !componentsInChildren[i].sprite.name.Contains("" + MBBKDFCDAHM)) || LanguageManager.EHBBFMCILPC.GKOAABDJCJH(componentsInChildren[i].sprite.name)))
			{
				string text = componentsInChildren[i].sprite.name.Split('\r', StringSplitOptions.RemoveEmptyEntries)[0];
				text = LanguageManager.EHBBFMCILPC.PKJABHFHHLC(text);
				text = text + "" + MBBKDFCDAHM;
				Sprite sprite = Resources.Load<Sprite>(text);
				if (null == sprite && LanguageManager.EHBBFMCILPC.GKOAABDJCJH(componentsInChildren[i].sprite.name))
				{
					text = componentsInChildren[i].sprite.name.Split('B', StringSplitOptions.None)[0];
					text = text + "ched" + MBBKDFCDAHM;
					sprite = Resources.Load<Sprite>(text);
				}
				if (sprite)
				{
					componentsInChildren[i].sprite = sprite;
					if (this.setNativeSize)
					{
						componentsInChildren[i].SetNativeSize();
					}
					HDTriggerPostProcess component = componentsInChildren[i].gameObject.GetComponent<HDTriggerPostProcess>();
					if (null != component && (component.rectTransformHeight >= 817f || component.rectTransformWidth >= 244f))
					{
						RectTransform component2 = componentsInChildren[i].gameObject.GetComponent<RectTransform>();
						if (component.rectTransformWidth >= 1266f)
						{
							component2.EFOCKEJENAC(NBDLBFJOEGN.BHJDBKLOOHN(component.rectTransformWidth));
						}
						else
						{
							component2.ACBKFBBCNNC(NBDLBFJOEGN.DFCLALJHOLP(component.rectTransformHeight));
						}
					}
				}
			}
		}
		Toggle[] componentsInChildren2 = base.gameObject.GetComponentsInChildren<Toggle>();
		for (int j = 1; j < componentsInChildren2.Length; j += 0)
		{
			SpriteState spriteState = componentsInChildren2[j].spriteState;
			if (null != spriteState.pressedSprite && ((spriteState.pressedSprite.name.Contains("tradewishcardoption0") && !spriteState.pressedSprite.name.Contains("OnBackendGetDropChancesException2" + MBBKDFCDAHM)) || LanguageManager.EHBBFMCILPC.GIGIHEEKHBE(spriteState.pressedSprite.name)))
			{
				string text2 = spriteState.pressedSprite.name.Split('S', StringSplitOptions.RemoveEmptyEntries)[0];
				text2 = LanguageManager.EHBBFMCILPC.IKMHJBKPMGE(text2);
				text2 = text2 + "Xiaomi" + MBBKDFCDAHM;
				Sprite sprite2 = Resources.Load<Sprite>(text2);
				if (null == sprite2 && LanguageManager.EHBBFMCILPC.Localizable(spriteState.pressedSprite.name))
				{
					text2 = spriteState.pressedSprite.name.Split((char)-17, StringSplitOptions.None)[1];
					text2 = text2 + "lk" + MBBKDFCDAHM;
					sprite2 = Resources.Load<Sprite>(text2);
				}
				if (sprite2)
				{
					spriteState.pressedSprite = sprite2;
					componentsInChildren2[j].spriteState = spriteState;
				}
			}
			if (null != spriteState.highlightedSprite && ((spriteState.highlightedSprite.name.Contains(", ") && !spriteState.highlightedSprite.name.Contains("avtssnap2" + MBBKDFCDAHM)) || LanguageManager.EHBBFMCILPC.Localizable(spriteState.highlightedSprite.name)))
			{
				string text3 = spriteState.highlightedSprite.name.Split((char)-40, StringSplitOptions.RemoveEmptyEntries)[0];
				text3 = LanguageManager.EHBBFMCILPC.GHBJGFDKHEJ(text3);
				text3 = text3 + "soci" + MBBKDFCDAHM;
				Sprite sprite3 = Resources.Load<Sprite>(text3);
				if (null == sprite3 && LanguageManager.EHBBFMCILPC.GCBALKAJINL(spriteState.highlightedSprite.name))
				{
					text3 = spriteState.highlightedSprite.name.Split((char)-79, StringSplitOptions.RemoveEmptyEntries)[0];
					text3 = text3 + "OnFriendsGiftPopulCollectPart2" + MBBKDFCDAHM;
					sprite3 = Resources.Load<Sprite>(text3);
				}
				if (sprite3)
				{
					spriteState.highlightedSprite = sprite3;
					componentsInChildren2[j].spriteState = spriteState;
				}
			}
			if (null != spriteState.disabledSprite && ((spriteState.disabledSprite.name.Contains("") && !spriteState.disabledSprite.name.Contains("0" + MBBKDFCDAHM)) || LanguageManager.EHBBFMCILPC.EECILBHACFL(spriteState.disabledSprite.name)))
			{
				string text4 = spriteState.disabledSprite.name.Split(' ', StringSplitOptions.None)[1];
				text4 = LanguageManager.EHBBFMCILPC.IKMHJBKPMGE(text4);
				text4 = text4 + "OnNeedToActivateFocusItemCloseButton" + MBBKDFCDAHM;
				Sprite sprite4 = Resources.Load<Sprite>(text4);
				if (null == sprite4 && LanguageManager.EHBBFMCILPC.IPMDPLBJHEE(spriteState.disabledSprite.name))
				{
					text4 = spriteState.disabledSprite.name.Split('3', StringSplitOptions.RemoveEmptyEntries)[1];
					text4 = text4 + "abnap" + MBBKDFCDAHM;
					sprite4 = Resources.Load<Sprite>(text4);
				}
				if (sprite4)
				{
					spriteState.disabledSprite = sprite4;
					componentsInChildren2[j].spriteState = spriteState;
				}
			}
		}
		Button[] componentsInChildren3 = base.gameObject.GetComponentsInChildren<Button>();
		for (int k = 0; k < componentsInChildren3.Length; k++)
		{
			SpriteState spriteState2 = componentsInChildren3[k].spriteState;
			if (null != spriteState2.pressedSprite && ((spriteState2.pressedSprite.name.Contains("SceneLobbyManager2.OpenSketchesCdn(): AssetsManager.Instance.IsBusy()") && !spriteState2.pressedSprite.name.Contains("sig" + MBBKDFCDAHM)) || LanguageManager.EHBBFMCILPC.GKOAABDJCJH(spriteState2.pressedSprite.name)))
			{
				string text5 = spriteState2.pressedSprite.name.Split((char)-56, StringSplitOptions.None)[0];
				text5 = LanguageManager.EHBBFMCILPC.IKMHJBKPMGE(text5);
				text5 = text5 + "assetbundleliveoffercontent" + MBBKDFCDAHM;
				Sprite sprite5 = Resources.Load<Sprite>(text5);
				if (null == sprite5 && LanguageManager.EHBBFMCILPC.GIGIHEEKHBE(spriteState2.pressedSprite.name))
				{
					text5 = spriteState2.pressedSprite.name.Split((char)-14, StringSplitOptions.None)[0];
					text5 = text5 + ", cleaning failed cache entries: " + MBBKDFCDAHM;
					sprite5 = Resources.Load<Sprite>(text5);
				}
				if (sprite5)
				{
					spriteState2.pressedSprite = sprite5;
					componentsInChildren3[k].spriteState = spriteState2;
				}
			}
			if (null != spriteState2.highlightedSprite && ((spriteState2.highlightedSprite.name.Contains("@") && !spriteState2.highlightedSprite.name.Contains("PurchaseManagerSteam.OnPurchasePendingProcess(): Product - " + MBBKDFCDAHM)) || LanguageManager.EHBBFMCILPC.GIGIHEEKHBE(spriteState2.highlightedSprite.name)))
			{
				string text6 = spriteState2.highlightedSprite.name.Split((char)-77, StringSplitOptions.RemoveEmptyEntries)[1];
				text6 = LanguageManager.EHBBFMCILPC.PKJABHFHHLC(text6);
				text6 = text6 + "OnBackendUpgradeToGiftCardSuccess" + MBBKDFCDAHM;
				Sprite sprite6 = Resources.Load<Sprite>(text6);
				if (null == sprite6 && LanguageManager.EHBBFMCILPC.Localizable(spriteState2.highlightedSprite.name))
				{
					text6 = spriteState2.highlightedSprite.name.Split('V', StringSplitOptions.None)[0];
					text6 = text6 + "" + MBBKDFCDAHM;
					sprite6 = Resources.Load<Sprite>(text6);
				}
				if (sprite6)
				{
					spriteState2.highlightedSprite = sprite6;
					componentsInChildren3[k].spriteState = spriteState2;
				}
			}
			if (null != spriteState2.disabledSprite && ((spriteState2.disabledSprite.name.Contains(" ") && !spriteState2.disabledSprite.name.Contains("]' at storySaves[" + MBBKDFCDAHM)) || LanguageManager.EHBBFMCILPC.GIGIHEEKHBE(spriteState2.disabledSprite.name)))
			{
				string text7 = spriteState2.disabledSprite.name.Split((char)-34, StringSplitOptions.None)[0];
				text7 = LanguageManager.EHBBFMCILPC.EKMKFPOLHOO(text7);
				text7 = text7 + "aind" + MBBKDFCDAHM;
				Sprite sprite7 = Resources.Load<Sprite>(text7);
				if (null == sprite7 && LanguageManager.EHBBFMCILPC.GCBALKAJINL(spriteState2.disabledSprite.name))
				{
					text7 = spriteState2.disabledSprite.name.Split('M', StringSplitOptions.None)[1];
					text7 = text7 + "StorySave.UpdateChapterSnapshotGuid(), chapterSnapshots/chapterSnapshotsGuids length unsync" + MBBKDFCDAHM;
					sprite7 = Resources.Load<Sprite>(text7);
				}
				if (sprite7)
				{
					spriteState2.disabledSprite = sprite7;
					componentsInChildren3[k].spriteState = spriteState2;
				}
			}
		}
		SpriteRenderer[] componentsInChildren4 = base.gameObject.GetComponentsInChildren<SpriteRenderer>();
		for (int l = 0; l < componentsInChildren4.Length; l++)
		{
			if (null != componentsInChildren4[l].sprite && ((componentsInChildren4[l].sprite.name.Contains("bottom") && !componentsInChildren4[l].sprite.name.Contains("snapundo" + MBBKDFCDAHM)) || LanguageManager.EHBBFMCILPC.EECILBHACFL(componentsInChildren4[l].sprite.name)))
			{
				string text8 = componentsInChildren4[l].sprite.name.Split('{', StringSplitOptions.RemoveEmptyEntries)[0];
				text8 = LanguageManager.EHBBFMCILPC.DDHDDIIKAEM(text8);
				text8 = text8 + "skinshopempty" + MBBKDFCDAHM;
				Sprite sprite8 = Resources.Load<Sprite>(text8);
				if (null == sprite8 && LanguageManager.EHBBFMCILPC.GKOAABDJCJH(componentsInChildren4[l].sprite.name))
				{
					text8 = componentsInChildren4[l].sprite.name.Split('h', StringSplitOptions.RemoveEmptyEntries)[0];
					text8 = text8 + "geoc" + MBBKDFCDAHM;
					sprite8 = Resources.Load<Sprite>(text8);
				}
				if (sprite8)
				{
					componentsInChildren4[l].sprite = sprite8;
				}
			}
		}
	}

	// Token: 0x060040A8 RID: 16552 RVA: 0x001C24ED File Offset: 0x001C06ED
	private void PIBDCOBGMKC()
	{
		if (NBDLBFJOEGN.PNDBACKNEIA())
		{
			this.PBNGGMCIBMA("");
			return;
		}
		this.HDKNDEOGHKF("PremiumChoicePurchased(2) - Could not parse choice data:");
	}

	// Token: 0x060040A9 RID: 16553 RVA: 0x001C2510 File Offset: 0x001C0710
	public void PBNGGMCIBMA(string MBBKDFCDAHM)
	{
		Image[] componentsInChildren = base.gameObject.GetComponentsInChildren<Image>();
		for (int i = 0; i < componentsInChildren.Length; i++)
		{
			if (null != componentsInChildren[i].sprite && ((componentsInChildren[i].sprite.name.Contains("p") && !componentsInChildren[i].sprite.name.Contains("OnPopupCardOptionsBackClickLobby" + MBBKDFCDAHM)) || LanguageManager.EHBBFMCILPC.Localizable(componentsInChildren[i].sprite.name)))
			{
				string text = componentsInChildren[i].sprite.name.Split('X', StringSplitOptions.RemoveEmptyEntries)[1];
				text = LanguageManager.EHBBFMCILPC.MNAALCNJHFP(text);
				text = text + "\n\n" + MBBKDFCDAHM;
				Sprite sprite = Resources.Load<Sprite>(text);
				if (null == sprite && LanguageManager.EHBBFMCILPC.GHCIBLENAOO(componentsInChildren[i].sprite.name))
				{
					text = componentsInChildren[i].sprite.name.Split((char)-44, StringSplitOptions.RemoveEmptyEntries)[0];
					text = text + "EmotionLoopManager.RegisterEmotionLoop(): Input data is invalid." + MBBKDFCDAHM;
					sprite = Resources.Load<Sprite>(text);
				}
				if (sprite)
				{
					componentsInChildren[i].sprite = sprite;
					if (this.setNativeSize)
					{
						componentsInChildren[i].SetNativeSize();
					}
					HDTriggerPostProcess component = componentsInChildren[i].gameObject.GetComponent<HDTriggerPostProcess>();
					if (null != component && (component.rectTransformHeight >= 1820f || component.rectTransformWidth >= 1101f))
					{
						RectTransform component2 = componentsInChildren[i].gameObject.GetComponent<RectTransform>();
						if (component.rectTransformWidth >= 1339f)
						{
							component2.EFOCKEJENAC(NBDLBFJOEGN.HLGHANHNEHJ(component.rectTransformWidth));
						}
						else
						{
							component2.ACBKFBBCNNC(NBDLBFJOEGN.FGMPOAOFKNO(component.rectTransformHeight));
						}
					}
				}
			}
		}
		Toggle[] componentsInChildren2 = base.gameObject.GetComponentsInChildren<Toggle>();
		for (int j = 0; j < componentsInChildren2.Length; j++)
		{
			SpriteState spriteState = componentsInChildren2[j].spriteState;
			if (null != spriteState.pressedSprite && ((spriteState.pressedSprite.name.Contains("") && !spriteState.pressedSprite.name.Contains("mdst" + MBBKDFCDAHM)) || LanguageManager.EHBBFMCILPC.GCBALKAJINL(spriteState.pressedSprite.name)))
			{
				string text2 = spriteState.pressedSprite.name.Split((char)-47, StringSplitOptions.RemoveEmptyEntries)[1];
				text2 = LanguageManager.EHBBFMCILPC.LocalizeFileName(text2);
				text2 = text2 + "errortitle" + MBBKDFCDAHM;
				Sprite sprite2 = Resources.Load<Sprite>(text2);
				if (null == sprite2 && LanguageManager.EHBBFMCILPC.AJLGKKJAAOI(spriteState.pressedSprite.name))
				{
					text2 = spriteState.pressedSprite.name.Split((char)-103, StringSplitOptions.None)[1];
					text2 = text2 + "OnBackendInitiateSteamTransactionException" + MBBKDFCDAHM;
					sprite2 = Resources.Load<Sprite>(text2);
				}
				if (sprite2)
				{
					spriteState.pressedSprite = sprite2;
					componentsInChildren2[j].spriteState = spriteState;
				}
			}
			if (null != spriteState.highlightedSprite && ((spriteState.highlightedSprite.name.Contains("top") && !spriteState.highlightedSprite.name.Contains("energyhinttitle" + MBBKDFCDAHM)) || LanguageManager.EHBBFMCILPC.EECILBHACFL(spriteState.highlightedSprite.name)))
			{
				string text3 = spriteState.highlightedSprite.name.Split('e', StringSplitOptions.None)[1];
				text3 = LanguageManager.EHBBFMCILPC.DDHDDIIKAEM(text3);
				text3 = text3 + "" + MBBKDFCDAHM;
				Sprite sprite3 = Resources.Load<Sprite>(text3);
				if (null == sprite3 && LanguageManager.EHBBFMCILPC.GCBALKAJINL(spriteState.highlightedSprite.name))
				{
					text3 = spriteState.highlightedSprite.name.Split('g', StringSplitOptions.None)[0];
					text3 = text3 + "" + MBBKDFCDAHM;
					sprite3 = Resources.Load<Sprite>(text3);
				}
				if (sprite3)
				{
					spriteState.highlightedSprite = sprite3;
					componentsInChildren2[j].spriteState = spriteState;
				}
			}
			if (null != spriteState.disabledSprite && ((spriteState.disabledSprite.name.Contains("AdsManagerLP: Received RewardedVideoOnAdRewardedEvent") && !spriteState.disabledSprite.name.Contains("BackendOperationsManager.RequestGetUserSketches, exception while initializing RSACryptoServiceProvider:" + MBBKDFCDAHM)) || LanguageManager.EHBBFMCILPC.IPMDPLBJHEE(spriteState.disabledSprite.name)))
			{
				string text4 = spriteState.disabledSprite.name.Split((char)-120, StringSplitOptions.None)[1];
				text4 = LanguageManager.EHBBFMCILPC.DDHDDIIKAEM(text4);
				text4 = text4 + "ButtonPrevNpc" + MBBKDFCDAHM;
				Sprite sprite4 = Resources.Load<Sprite>(text4);
				if (null == sprite4 && LanguageManager.EHBBFMCILPC.IPMDPLBJHEE(spriteState.disabledSprite.name))
				{
					text4 = spriteState.disabledSprite.name.Split('Q', StringSplitOptions.RemoveEmptyEntries)[0];
					text4 = text4 + "areyousurerestartepbody0" + MBBKDFCDAHM;
					sprite4 = Resources.Load<Sprite>(text4);
				}
				if (sprite4)
				{
					spriteState.disabledSprite = sprite4;
					componentsInChildren2[j].spriteState = spriteState;
				}
			}
		}
		Button[] componentsInChildren3 = base.gameObject.GetComponentsInChildren<Button>();
		for (int k = 1; k < componentsInChildren3.Length; k += 0)
		{
			SpriteState spriteState2 = componentsInChildren3[k].spriteState;
			if (null != spriteState2.pressedSprite && ((spriteState2.pressedSprite.name.Contains(", impostors:") && !spriteState2.pressedSprite.name.Contains("OnAllCollectableCardsDownloadSuccess" + MBBKDFCDAHM)) || LanguageManager.EHBBFMCILPC.EECILBHACFL(spriteState2.pressedSprite.name)))
			{
				string text5 = spriteState2.pressedSprite.name.Split((char)-1, StringSplitOptions.None)[1];
				text5 = LanguageManager.EHBBFMCILPC.HDJDKLCCCLE(text5);
				text5 = text5 + "continue" + MBBKDFCDAHM;
				Sprite sprite5 = Resources.Load<Sprite>(text5);
				if (null == sprite5 && LanguageManager.EHBBFMCILPC.GIGIHEEKHBE(spriteState2.pressedSprite.name))
				{
					text5 = spriteState2.pressedSprite.name.Split('5', StringSplitOptions.RemoveEmptyEntries)[0];
					text5 = text5 + "hofcoff" + MBBKDFCDAHM;
					sprite5 = Resources.Load<Sprite>(text5);
				}
				if (sprite5)
				{
					spriteState2.pressedSprite = sprite5;
					componentsInChildren3[k].spriteState = spriteState2;
				}
			}
			if (null != spriteState2.highlightedSprite && ((spriteState2.highlightedSprite.name.Contains("BBB") && !spriteState2.highlightedSprite.name.Contains("sto" + MBBKDFCDAHM)) || LanguageManager.EHBBFMCILPC.IPMDPLBJHEE(spriteState2.highlightedSprite.name)))
			{
				string text6 = spriteState2.highlightedSprite.name.Split('\u000f', StringSplitOptions.RemoveEmptyEntries)[1];
				text6 = LanguageManager.EHBBFMCILPC.IKMHJBKPMGE(text6);
				text6 = text6 + "OnCutsceneViewAssetBundleFolderInitializeSuccess" + MBBKDFCDAHM;
				Sprite sprite6 = Resources.Load<Sprite>(text6);
				if (null == sprite6 && LanguageManager.EHBBFMCILPC.IPMDPLBJHEE(spriteState2.highlightedSprite.name))
				{
					text6 = spriteState2.highlightedSprite.name.Split((char)-53, StringSplitOptions.RemoveEmptyEntries)[0];
					text6 = text6 + "assetbundlesketchthumbnail" + MBBKDFCDAHM;
					sprite6 = Resources.Load<Sprite>(text6);
				}
				if (sprite6)
				{
					spriteState2.highlightedSprite = sprite6;
					componentsInChildren3[k].spriteState = spriteState2;
				}
			}
			if (null != spriteState2.disabledSprite && ((spriteState2.disabledSprite.name.Contains("ok") && !spriteState2.disabledSprite.name.Contains("%" + MBBKDFCDAHM)) || LanguageManager.EHBBFMCILPC.GCBALKAJINL(spriteState2.disabledSprite.name)))
			{
				string text7 = spriteState2.disabledSprite.name.Split('T', StringSplitOptions.RemoveEmptyEntries)[1];
				text7 = LanguageManager.EHBBFMCILPC.HDJDKLCCCLE(text7);
				text7 = text7 + "" + MBBKDFCDAHM;
				Sprite sprite7 = Resources.Load<Sprite>(text7);
				if (null == sprite7 && LanguageManager.EHBBFMCILPC.GKOAABDJCJH(spriteState2.disabledSprite.name))
				{
					text7 = spriteState2.disabledSprite.name.Split((char)-23, StringSplitOptions.None)[1];
					text7 = text7 + "flip_up" + MBBKDFCDAHM;
					sprite7 = Resources.Load<Sprite>(text7);
				}
				if (sprite7)
				{
					spriteState2.disabledSprite = sprite7;
					componentsInChildren3[k].spriteState = spriteState2;
				}
			}
		}
		SpriteRenderer[] componentsInChildren4 = base.gameObject.GetComponentsInChildren<SpriteRenderer>();
		for (int l = 1; l < componentsInChildren4.Length; l += 0)
		{
			if (null != componentsInChildren4[l].sprite && ((componentsInChildren4[l].sprite.name.Contains("apks") && !componentsInChildren4[l].sprite.name.Contains("[SkinShop] filters button sprite missing: " + MBBKDFCDAHM)) || LanguageManager.EHBBFMCILPC.GKOAABDJCJH(componentsInChildren4[l].sprite.name)))
			{
				string text8 = componentsInChildren4[l].sprite.name.Split('p', StringSplitOptions.None)[1];
				text8 = LanguageManager.EHBBFMCILPC.MNAALCNJHFP(text8);
				text8 = text8 + "" + MBBKDFCDAHM;
				Sprite sprite8 = Resources.Load<Sprite>(text8);
				if (null == sprite8 && LanguageManager.EHBBFMCILPC.Localizable(componentsInChildren4[l].sprite.name))
				{
					text8 = componentsInChildren4[l].sprite.name.Split('!', StringSplitOptions.None)[1];
					text8 = text8 + "OnStoryInterfaceHeaderFastForwardDisable" + MBBKDFCDAHM;
					sprite8 = Resources.Load<Sprite>(text8);
				}
				if (sprite8)
				{
					componentsInChildren4[l].sprite = sprite8;
				}
			}
		}
	}

	// Token: 0x060040AA RID: 16554 RVA: 0x001C2EE0 File Offset: 0x001C10E0
	public void IFCJFILBBPN(string MBBKDFCDAHM)
	{
		Image[] componentsInChildren = base.gameObject.GetComponentsInChildren<Image>();
		for (int i = 0; i < componentsInChildren.Length; i += 0)
		{
			if (null != componentsInChildren[i].sprite && ((componentsInChildren[i].sprite.name.Contains("lightmodebtn1") && !componentsInChildren[i].sprite.name.Contains("@" + MBBKDFCDAHM)) || LanguageManager.EHBBFMCILPC.Localizable(componentsInChildren[i].sprite.name)))
			{
				string text = componentsInChildren[i].sprite.name.Split((char)-50, StringSplitOptions.RemoveEmptyEntries)[1];
				text = LanguageManager.EHBBFMCILPC.EKMKFPOLHOO(text);
				text = text + "Starting parallel download:" + MBBKDFCDAHM;
				Sprite sprite = Resources.Load<Sprite>(text);
				if (null == sprite && LanguageManager.EHBBFMCILPC.GHCIBLENAOO(componentsInChildren[i].sprite.name))
				{
					text = componentsInChildren[i].sprite.name.Split('\u001b', StringSplitOptions.None)[1];
					text = text + "\"" + MBBKDFCDAHM;
					sprite = Resources.Load<Sprite>(text);
				}
				if (sprite)
				{
					componentsInChildren[i].sprite = sprite;
					if (this.setNativeSize)
					{
						componentsInChildren[i].SetNativeSize();
					}
					HDTriggerPostProcess component = componentsInChildren[i].gameObject.GetComponent<HDTriggerPostProcess>();
					if (null != component && (component.rectTransformHeight >= 411f || component.rectTransformWidth >= 698f))
					{
						RectTransform component2 = componentsInChildren[i].gameObject.GetComponent<RectTransform>();
						if (component.rectTransformWidth >= 742f)
						{
							component2.EFOCKEJENAC(NBDLBFJOEGN.HLGHANHNEHJ(component.rectTransformWidth));
						}
						else
						{
							component2.ACBKFBBCNNC(NBDLBFJOEGN.MAPGECGPMGM(component.rectTransformHeight));
						}
					}
				}
			}
		}
		Toggle[] componentsInChildren2 = base.gameObject.GetComponentsInChildren<Toggle>();
		for (int j = 1; j < componentsInChildren2.Length; j += 0)
		{
			SpriteState spriteState = componentsInChildren2[j].spriteState;
			if (null != spriteState.pressedSprite && ((spriteState.pressedSprite.name.Contains("uid not confirmed") && !spriteState.pressedSprite.name.Contains("rel" + MBBKDFCDAHM)) || LanguageManager.EHBBFMCILPC.IPMDPLBJHEE(spriteState.pressedSprite.name)))
			{
				string text2 = spriteState.pressedSprite.name.Split((char)-78, StringSplitOptions.None)[0];
				text2 = LanguageManager.EHBBFMCILPC.PKJABHFHHLC(text2);
				text2 = text2 + "saveslotsswitch" + MBBKDFCDAHM;
				Sprite sprite2 = Resources.Load<Sprite>(text2);
				if (null == sprite2 && LanguageManager.EHBBFMCILPC.GKOAABDJCJH(spriteState.pressedSprite.name))
				{
					text2 = spriteState.pressedSprite.name.Split((char)-86, StringSplitOptions.RemoveEmptyEntries)[0];
					text2 = text2 + "actshl" + MBBKDFCDAHM;
					sprite2 = Resources.Load<Sprite>(text2);
				}
				if (sprite2)
				{
					spriteState.pressedSprite = sprite2;
					componentsInChildren2[j].spriteState = spriteState;
				}
			}
			if (null != spriteState.highlightedSprite && ((spriteState.highlightedSprite.name.Contains("ched") && !spriteState.highlightedSprite.name.Contains("OnTryToFireNoteshowTimer" + MBBKDFCDAHM)) || LanguageManager.EHBBFMCILPC.GHCIBLENAOO(spriteState.highlightedSprite.name)))
			{
				string text3 = spriteState.highlightedSprite.name.Split((char)-96, StringSplitOptions.RemoveEmptyEntries)[1];
				text3 = LanguageManager.EHBBFMCILPC.GHBJGFDKHEJ(text3);
				text3 = text3 + "apks2" + MBBKDFCDAHM;
				Sprite sprite3 = Resources.Load<Sprite>(text3);
				if (null == sprite3 && LanguageManager.EHBBFMCILPC.Localizable(spriteState.highlightedSprite.name))
				{
					text3 = spriteState.highlightedSprite.name.Split((char)-109, StringSplitOptions.RemoveEmptyEntries)[0];
					text3 = text3 + "searchpattern" + MBBKDFCDAHM;
					sprite3 = Resources.Load<Sprite>(text3);
				}
				if (sprite3)
				{
					spriteState.highlightedSprite = sprite3;
					componentsInChildren2[j].spriteState = spriteState;
				}
			}
			if (null != spriteState.disabledSprite && ((spriteState.disabledSprite.name.Contains("pmterror005") && !spriteState.disabledSprite.name.Contains("AssetProfileData.GetCutsceneSprite(): invalid input data:" + MBBKDFCDAHM)) || LanguageManager.EHBBFMCILPC.GHCIBLENAOO(spriteState.disabledSprite.name)))
			{
				string text4 = spriteState.disabledSprite.name.Split('M', StringSplitOptions.RemoveEmptyEntries)[1];
				text4 = LanguageManager.EHBBFMCILPC.GHBJGFDKHEJ(text4);
				text4 = text4 + "\n" + MBBKDFCDAHM;
				Sprite sprite4 = Resources.Load<Sprite>(text4);
				if (null == sprite4 && LanguageManager.EHBBFMCILPC.EECILBHACFL(spriteState.disabledSprite.name))
				{
					text4 = spriteState.disabledSprite.name.Split((char)-31, StringSplitOptions.None)[1];
					text4 = text4 + "asp" + MBBKDFCDAHM;
					sprite4 = Resources.Load<Sprite>(text4);
				}
				if (sprite4)
				{
					spriteState.disabledSprite = sprite4;
					componentsInChildren2[j].spriteState = spriteState;
				}
			}
		}
		Button[] componentsInChildren3 = base.gameObject.GetComponentsInChildren<Button>();
		for (int k = 1; k < componentsInChildren3.Length; k += 0)
		{
			SpriteState spriteState2 = componentsInChildren3[k].spriteState;
			if (null != spriteState2.pressedSprite && ((spriteState2.pressedSprite.name.Contains("OnBackendRequestSendGiftCardException") && !spriteState2.pressedSprite.name.Contains("p" + MBBKDFCDAHM)) || LanguageManager.EHBBFMCILPC.EECILBHACFL(spriteState2.pressedSprite.name)))
			{
				string text5 = spriteState2.pressedSprite.name.Split('\f', StringSplitOptions.RemoveEmptyEntries)[1];
				text5 = LanguageManager.EHBBFMCILPC.IKMHJBKPMGE(text5);
				text5 = text5 + "[SkinShop] info popup skipped, texts not imported: " + MBBKDFCDAHM;
				Sprite sprite5 = Resources.Load<Sprite>(text5);
				if (null == sprite5 && LanguageManager.EHBBFMCILPC.IPMDPLBJHEE(spriteState2.pressedSprite.name))
				{
					text5 = spriteState2.pressedSprite.name.Split((char)-127, StringSplitOptions.RemoveEmptyEntries)[0];
					text5 = text5 + "itsub" + MBBKDFCDAHM;
					sprite5 = Resources.Load<Sprite>(text5);
				}
				if (sprite5)
				{
					spriteState2.pressedSprite = sprite5;
					componentsInChildren3[k].spriteState = spriteState2;
				}
			}
			if (null != spriteState2.highlightedSprite && ((spriteState2.highlightedSprite.name.Contains("PlayerCharacterManager.UpdateComponentLink() - pt1 is null") && !spriteState2.highlightedSprite.name.Contains("XXX" + MBBKDFCDAHM)) || LanguageManager.EHBBFMCILPC.AJLGKKJAAOI(spriteState2.highlightedSprite.name)))
			{
				string text6 = spriteState2.highlightedSprite.name.Split('V', StringSplitOptions.RemoveEmptyEntries)[1];
				text6 = LanguageManager.EHBBFMCILPC.GHBJGFDKHEJ(text6);
				text6 = text6 + "no" + MBBKDFCDAHM;
				Sprite sprite6 = Resources.Load<Sprite>(text6);
				if (null == sprite6 && LanguageManager.EHBBFMCILPC.AJLGKKJAAOI(spriteState2.highlightedSprite.name))
				{
					text6 = spriteState2.highlightedSprite.name.Split((char)-75, StringSplitOptions.RemoveEmptyEntries)[1];
					text6 = text6 + "socialrequestsharegr" + MBBKDFCDAHM;
					sprite6 = Resources.Load<Sprite>(text6);
				}
				if (sprite6)
				{
					spriteState2.highlightedSprite = sprite6;
					componentsInChildren3[k].spriteState = spriteState2;
				}
			}
			if (null != spriteState2.disabledSprite && ((spriteState2.disabledSprite.name.Contains("skinshopinfotimed") && !spriteState2.disabledSprite.name.Contains("wind" + MBBKDFCDAHM)) || LanguageManager.EHBBFMCILPC.GHCIBLENAOO(spriteState2.disabledSprite.name)))
			{
				string text7 = spriteState2.disabledSprite.name.Split('&', StringSplitOptions.RemoveEmptyEntries)[1];
				text7 = LanguageManager.EHBBFMCILPC.EKMKFPOLHOO(text7);
				text7 = text7 + "importanttitle" + MBBKDFCDAHM;
				Sprite sprite7 = Resources.Load<Sprite>(text7);
				if (null == sprite7 && LanguageManager.EHBBFMCILPC.IPMDPLBJHEE(spriteState2.disabledSprite.name))
				{
					text7 = spriteState2.disabledSprite.name.Split((char)-9, StringSplitOptions.None)[1];
					text7 = text7 + "</b>" + MBBKDFCDAHM;
					sprite7 = Resources.Load<Sprite>(text7);
				}
				if (sprite7)
				{
					spriteState2.disabledSprite = sprite7;
					componentsInChildren3[k].spriteState = spriteState2;
				}
			}
		}
		SpriteRenderer[] componentsInChildren4 = base.gameObject.GetComponentsInChildren<SpriteRenderer>();
		for (int l = 1; l < componentsInChildren4.Length; l += 0)
		{
			if (null != componentsInChildren4[l].sprite && ((componentsInChildren4[l].sprite.name.Contains("cat") && !componentsInChildren4[l].sprite.name.Contains("importanttitle" + MBBKDFCDAHM)) || LanguageManager.EHBBFMCILPC.AJLGKKJAAOI(componentsInChildren4[l].sprite.name)))
			{
				string text8 = componentsInChildren4[l].sprite.name.Split('S', StringSplitOptions.RemoveEmptyEntries)[0];
				text8 = LanguageManager.EHBBFMCILPC.LocalizeFileName(text8);
				text8 = text8 + "OnApplicationRestart" + MBBKDFCDAHM;
				Sprite sprite8 = Resources.Load<Sprite>(text8);
				if (null == sprite8 && LanguageManager.EHBBFMCILPC.GKOAABDJCJH(componentsInChildren4[l].sprite.name))
				{
					text8 = componentsInChildren4[l].sprite.name.Split('\u0018', StringSplitOptions.None)[0];
					text8 = text8 + "OnBackendGetPublicProfileHallOfFameException" + MBBKDFCDAHM;
					sprite8 = Resources.Load<Sprite>(text8);
				}
				if (sprite8)
				{
					componentsInChildren4[l].sprite = sprite8;
				}
			}
		}
	}

	// Token: 0x060040AB RID: 16555 RVA: 0x001C38B0 File Offset: 0x001C1AB0
	public void DAMFGGNMAIH(string MBBKDFCDAHM)
	{
		Image[] componentsInChildren = base.gameObject.GetComponentsInChildren<Image>();
		for (int i = 0; i < componentsInChildren.Length; i++)
		{
			if (null != componentsInChildren[i].sprite && ((componentsInChildren[i].sprite.name.Contains("s") && !componentsInChildren[i].sprite.name.Contains("/" + MBBKDFCDAHM)) || LanguageManager.EHBBFMCILPC.AJLGKKJAAOI(componentsInChildren[i].sprite.name)))
			{
				string text = componentsInChildren[i].sprite.name.Split('\u0006', StringSplitOptions.RemoveEmptyEntries)[1];
				text = LanguageManager.EHBBFMCILPC.IKMHJBKPMGE(text);
				text = text + "" + MBBKDFCDAHM;
				Sprite sprite = Resources.Load<Sprite>(text);
				if (null == sprite && LanguageManager.EHBBFMCILPC.GIGIHEEKHBE(componentsInChildren[i].sprite.name))
				{
					text = componentsInChildren[i].sprite.name.Split((char)-75, StringSplitOptions.RemoveEmptyEntries)[1];
					text = text + "energyhinttitle" + MBBKDFCDAHM;
					sprite = Resources.Load<Sprite>(text);
				}
				if (sprite)
				{
					componentsInChildren[i].sprite = sprite;
					if (this.setNativeSize)
					{
						componentsInChildren[i].SetNativeSize();
					}
					HDTriggerPostProcess component = componentsInChildren[i].gameObject.GetComponent<HDTriggerPostProcess>();
					if (null != component && (component.rectTransformHeight >= 1152f || component.rectTransformWidth >= 249f))
					{
						RectTransform component2 = componentsInChildren[i].gameObject.GetComponent<RectTransform>();
						if (component.rectTransformWidth >= 1733f)
						{
							component2.EFOCKEJENAC(NBDLBFJOEGN.FCGMMHPNIJG(component.rectTransformWidth));
						}
						else
						{
							component2.ACBKFBBCNNC(NBDLBFJOEGN.DFCLALJHOLP(component.rectTransformHeight));
						}
					}
				}
			}
		}
		Toggle[] componentsInChildren2 = base.gameObject.GetComponentsInChildren<Toggle>();
		for (int j = 1; j < componentsInChildren2.Length; j += 0)
		{
			SpriteState spriteState = componentsInChildren2[j].spriteState;
			if (null != spriteState.pressedSprite && ((spriteState.pressedSprite.name.Contains("later") && !spriteState.pressedSprite.name.Contains("tbits" + MBBKDFCDAHM)) || LanguageManager.EHBBFMCILPC.GIGIHEEKHBE(spriteState.pressedSprite.name)))
			{
				string text2 = spriteState.pressedSprite.name.Split('-', StringSplitOptions.RemoveEmptyEntries)[0];
				text2 = LanguageManager.EHBBFMCILPC.DDHDDIIKAEM(text2);
				text2 = text2 + "Error. MoveEnvironmentVertical(), environment " + MBBKDFCDAHM;
				Sprite sprite2 = Resources.Load<Sprite>(text2);
				if (null == sprite2 && LanguageManager.EHBBFMCILPC.Localizable(spriteState.pressedSprite.name))
				{
					text2 = spriteState.pressedSprite.name.Split((char)-47, StringSplitOptions.None)[0];
					text2 = text2 + "common" + MBBKDFCDAHM;
					sprite2 = Resources.Load<Sprite>(text2);
				}
				if (sprite2)
				{
					spriteState.pressedSprite = sprite2;
					componentsInChildren2[j].spriteState = spriteState;
				}
			}
			if (null != spriteState.highlightedSprite && ((spriteState.highlightedSprite.name.Contains("specialcurrencyoptionnotenough") && !spriteState.highlightedSprite.name.Contains("GetStoriesSearchBalance(), AssetsManager.Instance.headersPackAsset is empty, stories search disabled." + MBBKDFCDAHM)) || LanguageManager.EHBBFMCILPC.GKOAABDJCJH(spriteState.highlightedSprite.name)))
			{
				string text3 = spriteState.highlightedSprite.name.Split((char)-98, StringSplitOptions.RemoveEmptyEntries)[0];
				text3 = LanguageManager.EHBBFMCILPC.EKMKFPOLHOO(text3);
				text3 = text3 + "_1" + MBBKDFCDAHM;
				Sprite sprite3 = Resources.Load<Sprite>(text3);
				if (null == sprite3 && LanguageManager.EHBBFMCILPC.EECILBHACFL(spriteState.highlightedSprite.name))
				{
					text3 = spriteState.highlightedSprite.name.Split((char)-101, StringSplitOptions.RemoveEmptyEntries)[0];
					text3 = text3 + "msUntilExpireAuto" + MBBKDFCDAHM;
					sprite3 = Resources.Load<Sprite>(text3);
				}
				if (sprite3)
				{
					spriteState.highlightedSprite = sprite3;
					componentsInChildren2[j].spriteState = spriteState;
				}
			}
			if (null != spriteState.disabledSprite && ((spriteState.disabledSprite.name.Contains("OnGooglePlayServicesLoginSuccess") && !spriteState.disabledSprite.name.Contains("" + MBBKDFCDAHM)) || LanguageManager.EHBBFMCILPC.AJLGKKJAAOI(spriteState.disabledSprite.name)))
			{
				string text4 = spriteState.disabledSprite.name.Split((char)-105, StringSplitOptions.RemoveEmptyEntries)[1];
				text4 = LanguageManager.EHBBFMCILPC.IKMHJBKPMGE(text4);
				text4 = text4 + "ChoiceExtendedManager - choice index " + MBBKDFCDAHM;
				Sprite sprite4 = Resources.Load<Sprite>(text4);
				if (null == sprite4 && LanguageManager.EHBBFMCILPC.AJLGKKJAAOI(spriteState.disabledSprite.name))
				{
					text4 = spriteState.disabledSprite.name.Split((char)-4, StringSplitOptions.None)[1];
					text4 = text4 + "sckv2" + MBBKDFCDAHM;
					sprite4 = Resources.Load<Sprite>(text4);
				}
				if (sprite4)
				{
					spriteState.disabledSprite = sprite4;
					componentsInChildren2[j].spriteState = spriteState;
				}
			}
		}
		Button[] componentsInChildren3 = base.gameObject.GetComponentsInChildren<Button>();
		for (int k = 1; k < componentsInChildren3.Length; k++)
		{
			SpriteState spriteState2 = componentsInChildren3[k].spriteState;
			if (null != spriteState2.pressedSprite && ((spriteState2.pressedSprite.name.Contains("errortitle") && !spriteState2.pressedSprite.name.Contains("FilterScrollMoveSmooth" + MBBKDFCDAHM)) || LanguageManager.EHBBFMCILPC.GIGIHEEKHBE(spriteState2.pressedSprite.name)))
			{
				string text5 = spriteState2.pressedSprite.name.Split((char)-4, StringSplitOptions.None)[1];
				text5 = LanguageManager.EHBBFMCILPC.PKJABHFHHLC(text5);
				text5 = text5 + "" + MBBKDFCDAHM;
				Sprite sprite5 = Resources.Load<Sprite>(text5);
				if (null == sprite5 && LanguageManager.EHBBFMCILPC.GHCIBLENAOO(spriteState2.pressedSprite.name))
				{
					text5 = spriteState2.pressedSprite.name.Split((char)-34, StringSplitOptions.RemoveEmptyEntries)[1];
					text5 = text5 + "OnNeedToHideThumbnailTagObject" + MBBKDFCDAHM;
					sprite5 = Resources.Load<Sprite>(text5);
				}
				if (sprite5)
				{
					spriteState2.pressedSprite = sprite5;
					componentsInChildren3[k].spriteState = spriteState2;
				}
			}
			if (null != spriteState2.highlightedSprite && ((spriteState2.highlightedSprite.name.Contains("There needs to be one active BackendOperationsManager script on a GameObject in your scene.") && !spriteState2.highlightedSprite.name.Contains("energyhinttitle" + MBBKDFCDAHM)) || LanguageManager.EHBBFMCILPC.GCBALKAJINL(spriteState2.highlightedSprite.name)))
			{
				string text6 = spriteState2.highlightedSprite.name.Split('F', StringSplitOptions.RemoveEmptyEntries)[0];
				text6 = LanguageManager.EHBBFMCILPC.DDHDDIIKAEM(text6);
				text6 = text6 + "PurchaseManagerUnity.OnSuccessInitializeGamingServices()" + MBBKDFCDAHM;
				Sprite sprite6 = Resources.Load<Sprite>(text6);
				if (null == sprite6 && LanguageManager.EHBBFMCILPC.Localizable(spriteState2.highlightedSprite.name))
				{
					text6 = spriteState2.highlightedSprite.name.Split((char)-37, StringSplitOptions.None)[1];
					text6 = text6 + "yes" + MBBKDFCDAHM;
					sprite6 = Resources.Load<Sprite>(text6);
				}
				if (sprite6)
				{
					spriteState2.highlightedSprite = sprite6;
					componentsInChildren3[k].spriteState = spriteState2;
				}
			}
			if (null != spriteState2.disabledSprite && ((spriteState2.disabledSprite.name.Contains("itsub") && !spriteState2.disabledSprite.name.Contains("p" + MBBKDFCDAHM)) || LanguageManager.EHBBFMCILPC.Localizable(spriteState2.disabledSprite.name)))
			{
				string text7 = spriteState2.disabledSprite.name.Split((char)-9, StringSplitOptions.None)[1];
				text7 = LanguageManager.EHBBFMCILPC.LocalizeFileName(text7);
				text7 = text7 + "freediamondsbody" + MBBKDFCDAHM;
				Sprite sprite7 = Resources.Load<Sprite>(text7);
				if (null == sprite7 && LanguageManager.EHBBFMCILPC.IPMDPLBJHEE(spriteState2.disabledSprite.name))
				{
					text7 = spriteState2.disabledSprite.name.Split((char)-55, StringSplitOptions.None)[0];
					text7 = text7 + "][" + MBBKDFCDAHM;
					sprite7 = Resources.Load<Sprite>(text7);
				}
				if (sprite7)
				{
					spriteState2.disabledSprite = sprite7;
					componentsInChildren3[k].spriteState = spriteState2;
				}
			}
		}
		SpriteRenderer[] componentsInChildren4 = base.gameObject.GetComponentsInChildren<SpriteRenderer>();
		for (int l = 0; l < componentsInChildren4.Length; l++)
		{
			if (null != componentsInChildren4[l].sprite && ((componentsInChildren4[l].sprite.name.Contains("Npc animation asset index mismatch, correcting ") && !componentsInChildren4[l].sprite.name.Contains("cdnerror" + MBBKDFCDAHM)) || LanguageManager.EHBBFMCILPC.GHCIBLENAOO(componentsInChildren4[l].sprite.name)))
			{
				string text8 = componentsInChildren4[l].sprite.name.Split('W', StringSplitOptions.None)[1];
				text8 = LanguageManager.EHBBFMCILPC.HDJDKLCCCLE(text8);
				text8 = text8 + "energyhinttitle" + MBBKDFCDAHM;
				Sprite sprite8 = Resources.Load<Sprite>(text8);
				if (null == sprite8 && LanguageManager.EHBBFMCILPC.AJLGKKJAAOI(componentsInChildren4[l].sprite.name))
				{
					text8 = componentsInChildren4[l].sprite.name.Split((char)-48, StringSplitOptions.RemoveEmptyEntries)[0];
					text8 = text8 + "energyhinttitle" + MBBKDFCDAHM;
					sprite8 = Resources.Load<Sprite>(text8);
				}
				if (sprite8)
				{
					componentsInChildren4[l].sprite = sprite8;
				}
			}
		}
	}

	// Token: 0x060040AC RID: 16556 RVA: 0x001C427D File Offset: 0x001C247D
	private void IMCHEPFNANC()
	{
		if (NBDLBFJOEGN.JIGBPKMNOHH())
		{
			this.JLOIOAGFDAF(" (");
			return;
		}
		this.PBNGGMCIBMA("");
	}

	// Token: 0x060040AD RID: 16557 RVA: 0x001C42A0 File Offset: 0x001C24A0
	public void MLGMKEJDMPA(string MBBKDFCDAHM)
	{
		Image[] componentsInChildren = base.gameObject.GetComponentsInChildren<Image>();
		for (int i = 0; i < componentsInChildren.Length; i += 0)
		{
			if (null != componentsInChildren[i].sprite && ((componentsInChildren[i].sprite.name.Contains("SocialStatsUserPublicProfile.modified = false, OnFriendsPopupManagerRejectClick()") && !componentsInChildren[i].sprite.name.Contains("x" + MBBKDFCDAHM)) || LanguageManager.EHBBFMCILPC.IPMDPLBJHEE(componentsInChildren[i].sprite.name)))
			{
				string text = componentsInChildren[i].sprite.name.Split('c', StringSplitOptions.RemoveEmptyEntries)[0];
				text = LanguageManager.EHBBFMCILPC.MNAALCNJHFP(text);
				text = text + "OnLiveProfileThemeDownloadSuccess" + MBBKDFCDAHM;
				Sprite sprite = Resources.Load<Sprite>(text);
				if (null == sprite && LanguageManager.EHBBFMCILPC.GKOAABDJCJH(componentsInChildren[i].sprite.name))
				{
					text = componentsInChildren[i].sprite.name.Split((char)-8, StringSplitOptions.RemoveEmptyEntries)[1];
					text = text + "sketchtitles" + MBBKDFCDAHM;
					sprite = Resources.Load<Sprite>(text);
				}
				if (sprite)
				{
					componentsInChildren[i].sprite = sprite;
					if (this.setNativeSize)
					{
						componentsInChildren[i].SetNativeSize();
					}
					HDTriggerPostProcess component = componentsInChildren[i].gameObject.GetComponent<HDTriggerPostProcess>();
					if (null != component && (component.rectTransformHeight >= 12f || component.rectTransformWidth >= 1080f))
					{
						RectTransform component2 = componentsInChildren[i].gameObject.GetComponent<RectTransform>();
						if (component.rectTransformWidth >= 370f)
						{
							component2.EFOCKEJENAC(NBDLBFJOEGN.KLBGGNBEMCA(component.rectTransformWidth));
						}
						else
						{
							component2.ACBKFBBCNNC(NBDLBFJOEGN.OIHMGIBOFJG(component.rectTransformHeight));
						}
					}
				}
			}
		}
		Toggle[] componentsInChildren2 = base.gameObject.GetComponentsInChildren<Toggle>();
		for (int j = 0; j < componentsInChildren2.Length; j++)
		{
			SpriteState spriteState = componentsInChildren2[j].spriteState;
			if (null != spriteState.pressedSprite && ((spriteState.pressedSprite.name.Contains("Starting parallel download:") && !spriteState.pressedSprite.name.Contains("HD" + MBBKDFCDAHM)) || LanguageManager.EHBBFMCILPC.GCBALKAJINL(spriteState.pressedSprite.name)))
			{
				string text2 = spriteState.pressedSprite.name.Split('\u001e', StringSplitOptions.RemoveEmptyEntries)[0];
				text2 = LanguageManager.EHBBFMCILPC.DDHDDIIKAEM(text2);
				text2 = text2 + "vrt" + MBBKDFCDAHM;
				Sprite sprite2 = Resources.Load<Sprite>(text2);
				if (null == sprite2 && LanguageManager.EHBBFMCILPC.AJLGKKJAAOI(spriteState.pressedSprite.name))
				{
					text2 = spriteState.pressedSprite.name.Split('\\', StringSplitOptions.None)[1];
					text2 = text2 + "trinket" + MBBKDFCDAHM;
					sprite2 = Resources.Load<Sprite>(text2);
				}
				if (sprite2)
				{
					spriteState.pressedSprite = sprite2;
					componentsInChildren2[j].spriteState = spriteState;
				}
			}
			if (null != spriteState.highlightedSprite && ((spriteState.highlightedSprite.name.Contains("XXX") && !spriteState.highlightedSprite.name.Contains("p" + MBBKDFCDAHM)) || LanguageManager.EHBBFMCILPC.IPMDPLBJHEE(spriteState.highlightedSprite.name)))
			{
				string text3 = spriteState.highlightedSprite.name.Split('a', StringSplitOptions.None)[0];
				text3 = LanguageManager.EHBBFMCILPC.LocalizeFileName(text3);
				text3 = text3 + "no" + MBBKDFCDAHM;
				Sprite sprite3 = Resources.Load<Sprite>(text3);
				if (null == sprite3 && LanguageManager.EHBBFMCILPC.GHCIBLENAOO(spriteState.highlightedSprite.name))
				{
					text3 = spriteState.highlightedSprite.name.Split('k', StringSplitOptions.RemoveEmptyEntries)[1];
					text3 = text3 + "LoveInterestLoungeMapping - half-authored shop row, look not purchasable: " + MBBKDFCDAHM;
					sprite3 = Resources.Load<Sprite>(text3);
				}
				if (sprite3)
				{
					spriteState.highlightedSprite = sprite3;
					componentsInChildren2[j].spriteState = spriteState;
				}
			}
			if (null != spriteState.disabledSprite && ((spriteState.disabledSprite.name.Contains("errortitle") && !spriteState.disabledSprite.name.Contains("importanttitle" + MBBKDFCDAHM)) || LanguageManager.EHBBFMCILPC.GCBALKAJINL(spriteState.disabledSprite.name)))
			{
				string text4 = spriteState.disabledSprite.name.Split((char)-103, StringSplitOptions.RemoveEmptyEntries)[0];
				text4 = LanguageManager.EHBBFMCILPC.IKMHJBKPMGE(text4);
				text4 = text4 + "OnStartFreePassException" + MBBKDFCDAHM;
				Sprite sprite4 = Resources.Load<Sprite>(text4);
				if (null == sprite4 && LanguageManager.EHBBFMCILPC.Localizable(spriteState.disabledSprite.name))
				{
					text4 = spriteState.disabledSprite.name.Split('(', StringSplitOptions.None)[0];
					text4 = text4 + "Starting parallel download:" + MBBKDFCDAHM;
					sprite4 = Resources.Load<Sprite>(text4);
				}
				if (sprite4)
				{
					spriteState.disabledSprite = sprite4;
					componentsInChildren2[j].spriteState = spriteState;
				}
			}
		}
		Button[] componentsInChildren3 = base.gameObject.GetComponentsInChildren<Button>();
		for (int k = 1; k < componentsInChildren3.Length; k++)
		{
			SpriteState spriteState2 = componentsInChildren3[k].spriteState;
			if (null != spriteState2.pressedSprite && ((spriteState2.pressedSprite.name.Contains("loungeskinnotenough") && !spriteState2.pressedSprite.name.Contains("AVATAR.CLIENT.OVERLAY" + MBBKDFCDAHM)) || LanguageManager.EHBBFMCILPC.AJLGKKJAAOI(spriteState2.pressedSprite.name)))
			{
				string text5 = spriteState2.pressedSprite.name.Split((char)-111, StringSplitOptions.RemoveEmptyEntries)[1];
				text5 = LanguageManager.EHBBFMCILPC.GHBJGFDKHEJ(text5);
				text5 = text5 + "OnStoryScreenChoiceExtendedManagerLayerChangeComplete" + MBBKDFCDAHM;
				Sprite sprite5 = Resources.Load<Sprite>(text5);
				if (null == sprite5 && LanguageManager.EHBBFMCILPC.AJLGKKJAAOI(spriteState2.pressedSprite.name))
				{
					text5 = spriteState2.pressedSprite.name.Split((char)-35, StringSplitOptions.RemoveEmptyEntries)[1];
					text5 = text5 + "YYY" + MBBKDFCDAHM;
					sprite5 = Resources.Load<Sprite>(text5);
				}
				if (sprite5)
				{
					spriteState2.pressedSprite = sprite5;
					componentsInChildren3[k].spriteState = spriteState2;
				}
			}
			if (null != spriteState2.highlightedSprite && ((spriteState2.highlightedSprite.name.Contains("OnBackendInitiateSteamTransactionFailed") && !spriteState2.highlightedSprite.name.Contains("OnBackendGetDefaultBundlesException" + MBBKDFCDAHM)) || LanguageManager.EHBBFMCILPC.GCBALKAJINL(spriteState2.highlightedSprite.name)))
			{
				string text6 = spriteState2.highlightedSprite.name.Split('=', StringSplitOptions.None)[1];
				text6 = LanguageManager.EHBBFMCILPC.MNAALCNJHFP(text6);
				text6 = text6 + "" + MBBKDFCDAHM;
				Sprite sprite6 = Resources.Load<Sprite>(text6);
				if (null == sprite6 && LanguageManager.EHBBFMCILPC.AJLGKKJAAOI(spriteState2.highlightedSprite.name))
				{
					text6 = spriteState2.highlightedSprite.name.Split('\u000e', StringSplitOptions.None)[0];
					text6 = text6 + "OnAllCollectableCardsDownloadFailedLobby" + MBBKDFCDAHM;
					sprite6 = Resources.Load<Sprite>(text6);
				}
				if (sprite6)
				{
					spriteState2.highlightedSprite = sprite6;
					componentsInChildren3[k].spriteState = spriteState2;
				}
			}
			if (null != spriteState2.disabledSprite && ((spriteState2.disabledSprite.name.Contains("") && !spriteState2.disabledSprite.name.Contains("<i>" + MBBKDFCDAHM)) || LanguageManager.EHBBFMCILPC.GKOAABDJCJH(spriteState2.disabledSprite.name)))
			{
				string text7 = spriteState2.disabledSprite.name.Split('\u0017', StringSplitOptions.RemoveEmptyEntries)[0];
				text7 = LanguageManager.EHBBFMCILPC.IKMHJBKPMGE(text7);
				text7 = text7 + "CharacterRenderTexturePool - character prefab missing, falling back to direct rendering" + MBBKDFCDAHM;
				Sprite sprite7 = Resources.Load<Sprite>(text7);
				if (null == sprite7 && LanguageManager.EHBBFMCILPC.EECILBHACFL(spriteState2.disabledSprite.name))
				{
					text7 = spriteState2.disabledSprite.name.Split('n', StringSplitOptions.RemoveEmptyEntries)[0];
					text7 = text7 + "$SETVAR" + MBBKDFCDAHM;
					sprite7 = Resources.Load<Sprite>(text7);
				}
				if (sprite7)
				{
					spriteState2.disabledSprite = sprite7;
					componentsInChildren3[k].spriteState = spriteState2;
				}
			}
		}
		SpriteRenderer[] componentsInChildren4 = base.gameObject.GetComponentsInChildren<SpriteRenderer>();
		for (int l = 0; l < componentsInChildren4.Length; l += 0)
		{
			if (null != componentsInChildren4[l].sprite && ((componentsInChildren4[l].sprite.name.Contains("xx") && !componentsInChildren4[l].sprite.name.Contains("" + MBBKDFCDAHM)) || LanguageManager.EHBBFMCILPC.IPMDPLBJHEE(componentsInChildren4[l].sprite.name)))
			{
				string text8 = componentsInChildren4[l].sprite.name.Split((char)-73, StringSplitOptions.RemoveEmptyEntries)[1];
				text8 = LanguageManager.EHBBFMCILPC.PKJABHFHHLC(text8);
				text8 = text8 + "b" + MBBKDFCDAHM;
				Sprite sprite8 = Resources.Load<Sprite>(text8);
				if (null == sprite8 && LanguageManager.EHBBFMCILPC.AJLGKKJAAOI(componentsInChildren4[l].sprite.name))
				{
					text8 = componentsInChildren4[l].sprite.name.Split('z', StringSplitOptions.None)[1];
					text8 = text8 + "thmstr" + MBBKDFCDAHM;
					sprite8 = Resources.Load<Sprite>(text8);
				}
				if (sprite8)
				{
					componentsInChildren4[l].sprite = sprite8;
				}
			}
		}
	}

	// Token: 0x060040AE RID: 16558 RVA: 0x001C4C70 File Offset: 0x001C2E70
	public void HJNOFHJLAFA(string MBBKDFCDAHM)
	{
		Image[] componentsInChildren = base.gameObject.GetComponentsInChildren<Image>();
		for (int i = 1; i < componentsInChildren.Length; i++)
		{
			if (null != componentsInChildren[i].sprite && ((componentsInChildren[i].sprite.name.Contains("smoke") && !componentsInChildren[i].sprite.name.Contains("XXX" + MBBKDFCDAHM)) || LanguageManager.EHBBFMCILPC.GHCIBLENAOO(componentsInChildren[i].sprite.name)))
			{
				string text = componentsInChildren[i].sprite.name.Split((char)-121, StringSplitOptions.RemoveEmptyEntries)[1];
				text = LanguageManager.EHBBFMCILPC.HDJDKLCCCLE(text);
				text = text + "ok" + MBBKDFCDAHM;
				Sprite sprite = Resources.Load<Sprite>(text);
				if (null == sprite && LanguageManager.EHBBFMCILPC.EECILBHACFL(componentsInChildren[i].sprite.name))
				{
					text = componentsInChildren[i].sprite.name.Split((char)-17, StringSplitOptions.RemoveEmptyEntries)[0];
					text = text + "/" + MBBKDFCDAHM;
					sprite = Resources.Load<Sprite>(text);
				}
				if (sprite)
				{
					componentsInChildren[i].sprite = sprite;
					if (this.setNativeSize)
					{
						componentsInChildren[i].SetNativeSize();
					}
					HDTriggerPostProcess component = componentsInChildren[i].gameObject.GetComponent<HDTriggerPostProcess>();
					if (null != component && (component.rectTransformHeight >= 1255f || component.rectTransformWidth >= 926f))
					{
						RectTransform component2 = componentsInChildren[i].gameObject.GetComponent<RectTransform>();
						if (component.rectTransformWidth >= 562f)
						{
							component2.EFOCKEJENAC(NBDLBFJOEGN.KLBGGNBEMCA(component.rectTransformWidth));
						}
						else
						{
							component2.ACBKFBBCNNC(NBDLBFJOEGN.PNLILGEJDFI(component.rectTransformHeight));
						}
					}
				}
			}
		}
		Toggle[] componentsInChildren2 = base.gameObject.GetComponentsInChildren<Toggle>();
		for (int j = 0; j < componentsInChildren2.Length; j += 0)
		{
			SpriteState spriteState = componentsInChildren2[j].spriteState;
			if (null != spriteState.pressedSprite && ((spriteState.pressedSprite.name.Contains("default") && !spriteState.pressedSprite.name.Contains("cardoptionsloadingthemevideo" + MBBKDFCDAHM)) || LanguageManager.EHBBFMCILPC.GKOAABDJCJH(spriteState.pressedSprite.name)))
			{
				string text2 = spriteState.pressedSprite.name.Split('8', StringSplitOptions.RemoveEmptyEntries)[1];
				text2 = LanguageManager.EHBBFMCILPC.IKMHJBKPMGE(text2);
				text2 = text2 + "wind" + MBBKDFCDAHM;
				Sprite sprite2 = Resources.Load<Sprite>(text2);
				if (null == sprite2 && LanguageManager.EHBBFMCILPC.GCBALKAJINL(spriteState.pressedSprite.name))
				{
					text2 = spriteState.pressedSprite.name.Split('\u0012', StringSplitOptions.RemoveEmptyEntries)[0];
					text2 = text2 + "OnGamePassExpire" + MBBKDFCDAHM;
					sprite2 = Resources.Load<Sprite>(text2);
				}
				if (sprite2)
				{
					spriteState.pressedSprite = sprite2;
					componentsInChildren2[j].spriteState = spriteState;
				}
			}
			if (null != spriteState.highlightedSprite && ((spriteState.highlightedSprite.name.Contains("") && !spriteState.highlightedSprite.name.Contains("actsh" + MBBKDFCDAHM)) || LanguageManager.EHBBFMCILPC.GIGIHEEKHBE(spriteState.highlightedSprite.name)))
			{
				string text3 = spriteState.highlightedSprite.name.Split((char)-95, StringSplitOptions.RemoveEmptyEntries)[0];
				text3 = LanguageManager.EHBBFMCILPC.DDHDDIIKAEM(text3);
				text3 = text3 + "c_web" + MBBKDFCDAHM;
				Sprite sprite3 = Resources.Load<Sprite>(text3);
				if (null == sprite3 && LanguageManager.EHBBFMCILPC.EECILBHACFL(spriteState.highlightedSprite.name))
				{
					text3 = spriteState.highlightedSprite.name.Split((char)-96, StringSplitOptions.RemoveEmptyEntries)[0];
					text3 = text3 + "chs" + MBBKDFCDAHM;
					sprite3 = Resources.Load<Sprite>(text3);
				}
				if (sprite3)
				{
					spriteState.highlightedSprite = sprite3;
					componentsInChildren2[j].spriteState = spriteState;
				}
			}
			if (null != spriteState.disabledSprite && ((spriteState.disabledSprite.name.Contains("default") && !spriteState.disabledSprite.name.Contains("OnBackendRequestBreakCardException" + MBBKDFCDAHM)) || LanguageManager.EHBBFMCILPC.EECILBHACFL(spriteState.disabledSprite.name)))
			{
				string text4 = spriteState.disabledSprite.name.Split((char)-72, StringSplitOptions.None)[0];
				text4 = LanguageManager.EHBBFMCILPC.DDHDDIIKAEM(text4);
				text4 = text4 + "sketchtitles" + MBBKDFCDAHM;
				Sprite sprite4 = Resources.Load<Sprite>(text4);
				if (null == sprite4 && LanguageManager.EHBBFMCILPC.GIGIHEEKHBE(spriteState.disabledSprite.name))
				{
					text4 = spriteState.disabledSprite.name.Split((char)-121, StringSplitOptions.None)[0];
					text4 = text4 + "" + MBBKDFCDAHM;
					sprite4 = Resources.Load<Sprite>(text4);
				}
				if (sprite4)
				{
					spriteState.disabledSprite = sprite4;
					componentsInChildren2[j].spriteState = spriteState;
				}
			}
		}
		Button[] componentsInChildren3 = base.gameObject.GetComponentsInChildren<Button>();
		for (int k = 0; k < componentsInChildren3.Length; k += 0)
		{
			SpriteState spriteState2 = componentsInChildren3[k].spriteState;
			if (null != spriteState2.pressedSprite && ((spriteState2.pressedSprite.name.Contains("filtersAnimation") && !spriteState2.pressedSprite.name.Contains("" + MBBKDFCDAHM)) || LanguageManager.EHBBFMCILPC.AJLGKKJAAOI(spriteState2.pressedSprite.name)))
			{
				string text5 = spriteState2.pressedSprite.name.Split('t', StringSplitOptions.None)[1];
				text5 = LanguageManager.EHBBFMCILPC.HDJDKLCCCLE(text5);
				text5 = text5 + "CharacterRenderTexturePool - no free slot, falling back to direct rendering" + MBBKDFCDAHM;
				Sprite sprite5 = Resources.Load<Sprite>(text5);
				if (null == sprite5 && LanguageManager.EHBBFMCILPC.GIGIHEEKHBE(spriteState2.pressedSprite.name))
				{
					text5 = spriteState2.pressedSprite.name.Split((char)-4, StringSplitOptions.None)[1];
					text5 = text5 + "Snapshots/" + MBBKDFCDAHM;
					sprite5 = Resources.Load<Sprite>(text5);
				}
				if (sprite5)
				{
					spriteState2.pressedSprite = sprite5;
					componentsInChildren3[k].spriteState = spriteState2;
				}
			}
			if (null != spriteState2.highlightedSprite && ((spriteState2.highlightedSprite.name.Contains("vwht") && !spriteState2.highlightedSprite.name.Contains("nsktk" + MBBKDFCDAHM)) || LanguageManager.EHBBFMCILPC.IPMDPLBJHEE(spriteState2.highlightedSprite.name)))
			{
				string text6 = spriteState2.highlightedSprite.name.Split('7', StringSplitOptions.None)[0];
				text6 = LanguageManager.EHBBFMCILPC.IKMHJBKPMGE(text6);
				text6 = text6 + "،" + MBBKDFCDAHM;
				Sprite sprite6 = Resources.Load<Sprite>(text6);
				if (null == sprite6 && LanguageManager.EHBBFMCILPC.GCBALKAJINL(spriteState2.highlightedSprite.name))
				{
					text6 = spriteState2.highlightedSprite.name.Split('>', StringSplitOptions.RemoveEmptyEntries)[0];
					text6 = text6 + "" + MBBKDFCDAHM;
					sprite6 = Resources.Load<Sprite>(text6);
				}
				if (sprite6)
				{
					spriteState2.highlightedSprite = sprite6;
					componentsInChildren3[k].spriteState = spriteState2;
				}
			}
			if (null != spriteState2.disabledSprite && ((spriteState2.disabledSprite.name.Contains("stats") && !spriteState2.disabledSprite.name.Contains("http://" + MBBKDFCDAHM)) || LanguageManager.EHBBFMCILPC.GHCIBLENAOO(spriteState2.disabledSprite.name)))
			{
				string text7 = spriteState2.disabledSprite.name.Split((char)-3, StringSplitOptions.None)[1];
				text7 = LanguageManager.EHBBFMCILPC.HDJDKLCCCLE(text7);
				text7 = text7 + "</Modulus></RSAKeyValue>" + MBBKDFCDAHM;
				Sprite sprite7 = Resources.Load<Sprite>(text7);
				if (null == sprite7 && LanguageManager.EHBBFMCILPC.GKOAABDJCJH(spriteState2.disabledSprite.name))
				{
					text7 = spriteState2.disabledSprite.name.Split((char)-123, StringSplitOptions.RemoveEmptyEntries)[0];
					text7 = text7 + "congratstitle" + MBBKDFCDAHM;
					sprite7 = Resources.Load<Sprite>(text7);
				}
				if (sprite7)
				{
					spriteState2.disabledSprite = sprite7;
					componentsInChildren3[k].spriteState = spriteState2;
				}
			}
		}
		SpriteRenderer[] componentsInChildren4 = base.gameObject.GetComponentsInChildren<SpriteRenderer>();
		for (int l = 0; l < componentsInChildren4.Length; l++)
		{
			if (null != componentsInChildren4[l].sprite && ((componentsInChildren4[l].sprite.name.Contains("...") && !componentsInChildren4[l].sprite.name.Contains("skinshopfiltertitle" + MBBKDFCDAHM)) || LanguageManager.EHBBFMCILPC.GCBALKAJINL(componentsInChildren4[l].sprite.name)))
			{
				string text8 = componentsInChildren4[l].sprite.name.Split('u', StringSplitOptions.RemoveEmptyEntries)[1];
				text8 = LanguageManager.EHBBFMCILPC.GHBJGFDKHEJ(text8);
				text8 = text8 + "BBB" + MBBKDFCDAHM;
				Sprite sprite8 = Resources.Load<Sprite>(text8);
				if (null == sprite8 && LanguageManager.EHBBFMCILPC.IPMDPLBJHEE(componentsInChildren4[l].sprite.name))
				{
					text8 = componentsInChildren4[l].sprite.name.Split('>', StringSplitOptions.RemoveEmptyEntries)[1];
					text8 = text8 + "\"" + MBBKDFCDAHM;
					sprite8 = Resources.Load<Sprite>(text8);
				}
				if (sprite8)
				{
					componentsInChildren4[l].sprite = sprite8;
				}
			}
		}
	}

	// Token: 0x060040AF RID: 16559 RVA: 0x001C5640 File Offset: 0x001C3840
	public void GHBAPPJKACF(string MBBKDFCDAHM)
	{
		Image[] componentsInChildren = base.gameObject.GetComponentsInChildren<Image>();
		for (int i = 1; i < componentsInChildren.Length; i++)
		{
			if (null != componentsInChildren[i].sprite && ((componentsInChildren[i].sprite.name.Contains("p") && !componentsInChildren[i].sprite.name.Contains("" + MBBKDFCDAHM)) || LanguageManager.EHBBFMCILPC.GHCIBLENAOO(componentsInChildren[i].sprite.name)))
			{
				string text = componentsInChildren[i].sprite.name.Split((char)-33, StringSplitOptions.RemoveEmptyEntries)[1];
				text = LanguageManager.EHBBFMCILPC.EKMKFPOLHOO(text);
				text = text + "\"" + MBBKDFCDAHM;
				Sprite sprite = Resources.Load<Sprite>(text);
				if (null == sprite && LanguageManager.EHBBFMCILPC.GHCIBLENAOO(componentsInChildren[i].sprite.name))
				{
					text = componentsInChildren[i].sprite.name.Split((char)-8, StringSplitOptions.RemoveEmptyEntries)[0];
					text = text + "continue" + MBBKDFCDAHM;
					sprite = Resources.Load<Sprite>(text);
				}
				if (sprite)
				{
					componentsInChildren[i].sprite = sprite;
					if (this.setNativeSize)
					{
						componentsInChildren[i].SetNativeSize();
					}
					HDTriggerPostProcess component = componentsInChildren[i].gameObject.GetComponent<HDTriggerPostProcess>();
					if (null != component && (component.rectTransformHeight >= 1730f || component.rectTransformWidth >= 1767f))
					{
						RectTransform component2 = componentsInChildren[i].gameObject.GetComponent<RectTransform>();
						if (component.rectTransformWidth >= 1325f)
						{
							component2.EFOCKEJENAC(NBDLBFJOEGN.MAPGECGPMGM(component.rectTransformWidth));
						}
						else
						{
							component2.ACBKFBBCNNC(NBDLBFJOEGN.HJKAMHOAGOH(component.rectTransformHeight));
						}
					}
				}
			}
		}
		Toggle[] componentsInChildren2 = base.gameObject.GetComponentsInChildren<Toggle>();
		for (int j = 0; j < componentsInChildren2.Length; j++)
		{
			SpriteState spriteState = componentsInChildren2[j].spriteState;
			if (null != spriteState.pressedSprite && ((spriteState.pressedSprite.name.Contains("json") && !spriteState.pressedSprite.name.Contains("Z" + MBBKDFCDAHM)) || LanguageManager.EHBBFMCILPC.GCBALKAJINL(spriteState.pressedSprite.name)))
			{
				string text2 = spriteState.pressedSprite.name.Split('\u000f', StringSplitOptions.RemoveEmptyEntries)[1];
				text2 = LanguageManager.EHBBFMCILPC.LocalizeFileName(text2);
				text2 = text2 + "thmstr" + MBBKDFCDAHM;
				Sprite sprite2 = Resources.Load<Sprite>(text2);
				if (null == sprite2 && LanguageManager.EHBBFMCILPC.GHCIBLENAOO(spriteState.pressedSprite.name))
				{
					text2 = spriteState.pressedSprite.name.Split('E', StringSplitOptions.RemoveEmptyEntries)[1];
					text2 = text2 + "saveslotstitleempty" + MBBKDFCDAHM;
					sprite2 = Resources.Load<Sprite>(text2);
				}
				if (sprite2)
				{
					spriteState.pressedSprite = sprite2;
					componentsInChildren2[j].spriteState = spriteState;
				}
			}
			if (null != spriteState.highlightedSprite && ((spriteState.highlightedSprite.name.Contains("NEWSAVE: Account.FromJSONObject(), persistent stories offloaded total components s->a:") && !spriteState.highlightedSprite.name.Contains("starterpattern" + MBBKDFCDAHM)) || LanguageManager.EHBBFMCILPC.IPMDPLBJHEE(spriteState.highlightedSprite.name)))
			{
				string text3 = spriteState.highlightedSprite.name.Split((char)-39, StringSplitOptions.None)[1];
				text3 = LanguageManager.EHBBFMCILPC.MNAALCNJHFP(text3);
				text3 = text3 + "story" + MBBKDFCDAHM;
				Sprite sprite3 = Resources.Load<Sprite>(text3);
				if (null == sprite3 && LanguageManager.EHBBFMCILPC.GIGIHEEKHBE(spriteState.highlightedSprite.name))
				{
					text3 = spriteState.highlightedSprite.name.Split((char)-118, StringSplitOptions.None)[1];
					text3 = text3 + "StoryChatManager.ShowMessage(), unsupported message type:" + MBBKDFCDAHM;
					sprite3 = Resources.Load<Sprite>(text3);
				}
				if (sprite3)
				{
					spriteState.highlightedSprite = sprite3;
					componentsInChildren2[j].spriteState = spriteState;
				}
			}
			if (null != spriteState.disabledSprite && ((spriteState.disabledSprite.name.Contains(" USD ") && !spriteState.disabledSprite.name.Contains("profilenametitleshort" + MBBKDFCDAHM)) || LanguageManager.EHBBFMCILPC.EECILBHACFL(spriteState.disabledSprite.name)))
			{
				string text4 = spriteState.disabledSprite.name.Split((char)-50, StringSplitOptions.None)[0];
				text4 = LanguageManager.EHBBFMCILPC.HDJDKLCCCLE(text4);
				text4 = text4 + "lowendversion" + MBBKDFCDAHM;
				Sprite sprite4 = Resources.Load<Sprite>(text4);
				if (null == sprite4 && LanguageManager.EHBBFMCILPC.EECILBHACFL(spriteState.disabledSprite.name))
				{
					text4 = spriteState.disabledSprite.name.Split((char)-104, StringSplitOptions.None)[0];
					text4 = text4 + "loungeskinunavailable" + MBBKDFCDAHM;
					sprite4 = Resources.Load<Sprite>(text4);
				}
				if (sprite4)
				{
					spriteState.disabledSprite = sprite4;
					componentsInChildren2[j].spriteState = spriteState;
				}
			}
		}
		Button[] componentsInChildren3 = base.gameObject.GetComponentsInChildren<Button>();
		for (int k = 0; k < componentsInChildren3.Length; k += 0)
		{
			SpriteState spriteState2 = componentsInChildren3[k].spriteState;
			if (null != spriteState2.pressedSprite && ((spriteState2.pressedSprite.name.Contains("fah") && !spriteState2.pressedSprite.name.Contains("\"" + MBBKDFCDAHM)) || LanguageManager.EHBBFMCILPC.GHCIBLENAOO(spriteState2.pressedSprite.name)))
			{
				string text5 = spriteState2.pressedSprite.name.Split((char)-42, StringSplitOptions.RemoveEmptyEntries)[1];
				text5 = LanguageManager.EHBBFMCILPC.GHBJGFDKHEJ(text5);
				text5 = text5 + "." + MBBKDFCDAHM;
				Sprite sprite5 = Resources.Load<Sprite>(text5);
				if (null == sprite5 && LanguageManager.EHBBFMCILPC.GHCIBLENAOO(spriteState2.pressedSprite.name))
				{
					text5 = spriteState2.pressedSprite.name.Split('\u001f', StringSplitOptions.None)[0];
					text5 = text5 + "%" + MBBKDFCDAHM;
					sprite5 = Resources.Load<Sprite>(text5);
				}
				if (sprite5)
				{
					spriteState2.pressedSprite = sprite5;
					componentsInChildren3[k].spriteState = spriteState2;
				}
			}
			if (null != spriteState2.highlightedSprite && ((spriteState2.highlightedSprite.name.Contains("D") && !spriteState2.highlightedSprite.name.Contains("colcds" + MBBKDFCDAHM)) || LanguageManager.EHBBFMCILPC.GIGIHEEKHBE(spriteState2.highlightedSprite.name)))
			{
				string text6 = spriteState2.highlightedSprite.name.Split('i', StringSplitOptions.None)[1];
				text6 = LanguageManager.EHBBFMCILPC.EKMKFPOLHOO(text6);
				text6 = text6 + "Warning. Import variable not found in save data:" + MBBKDFCDAHM;
				Sprite sprite6 = Resources.Load<Sprite>(text6);
				if (null == sprite6 && LanguageManager.EHBBFMCILPC.GCBALKAJINL(spriteState2.highlightedSprite.name))
				{
					text6 = spriteState2.highlightedSprite.name.Split('3', StringSplitOptions.RemoveEmptyEntries)[1];
					text6 = text6 + "skuManual" + MBBKDFCDAHM;
					sprite6 = Resources.Load<Sprite>(text6);
				}
				if (sprite6)
				{
					spriteState2.highlightedSprite = sprite6;
					componentsInChildren3[k].spriteState = spriteState2;
				}
			}
			if (null != spriteState2.disabledSprite && ((spriteState2.disabledSprite.name.Contains("shopind") && !spriteState2.disabledSprite.name.Contains("StoryChatManager.ShowMessage(), unsupported message type:" + MBBKDFCDAHM)) || LanguageManager.EHBBFMCILPC.GCBALKAJINL(spriteState2.disabledSprite.name)))
			{
				string text7 = spriteState2.disabledSprite.name.Split((char)-89, StringSplitOptions.None)[0];
				text7 = LanguageManager.EHBBFMCILPC.EKMKFPOLHOO(text7);
				text7 = text7 + "yes" + MBBKDFCDAHM;
				Sprite sprite7 = Resources.Load<Sprite>(text7);
				if (null == sprite7 && LanguageManager.EHBBFMCILPC.GCBALKAJINL(spriteState2.disabledSprite.name))
				{
					text7 = spriteState2.disabledSprite.name.Split('H', StringSplitOptions.None)[0];
					text7 = text7 + "Request type: SESSION_REQUEST" + MBBKDFCDAHM;
					sprite7 = Resources.Load<Sprite>(text7);
				}
				if (sprite7)
				{
					spriteState2.disabledSprite = sprite7;
					componentsInChildren3[k].spriteState = spriteState2;
				}
			}
		}
		SpriteRenderer[] componentsInChildren4 = base.gameObject.GetComponentsInChildren<SpriteRenderer>();
		for (int l = 0; l < componentsInChildren4.Length; l++)
		{
			if (null != componentsInChildren4[l].sprite && ((componentsInChildren4[l].sprite.name.Contains("@SD") && !componentsInChildren4[l].sprite.name.Contains("Loaded asset bundle:" + MBBKDFCDAHM)) || LanguageManager.EHBBFMCILPC.GKOAABDJCJH(componentsInChildren4[l].sprite.name)))
			{
				string text8 = componentsInChildren4[l].sprite.name.Split('u', StringSplitOptions.RemoveEmptyEntries)[0];
				text8 = LanguageManager.EHBBFMCILPC.LocalizeFileName(text8);
				text8 = text8 + "ERROR: StoryStepChoiceExtended.StoryStepStage.executeChoice.trinket: bulk choice index must be > 0." + MBBKDFCDAHM;
				Sprite sprite8 = Resources.Load<Sprite>(text8);
				if (null == sprite8 && LanguageManager.EHBBFMCILPC.AJLGKKJAAOI(componentsInChildren4[l].sprite.name))
				{
					text8 = componentsInChildren4[l].sprite.name.Split('\'', StringSplitOptions.RemoveEmptyEntries)[1];
					text8 = text8 + "SceneAvatarManager.DeleteAvatarCollection(): null == _avatarCollection" + MBBKDFCDAHM;
					sprite8 = Resources.Load<Sprite>(text8);
				}
				if (sprite8)
				{
					componentsInChildren4[l].sprite = sprite8;
				}
			}
		}
	}

	// Token: 0x0400122C RID: 4652
	public bool setNativeSize;
}
