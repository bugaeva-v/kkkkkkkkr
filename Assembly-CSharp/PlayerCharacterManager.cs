using System;
using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x020002EC RID: 748
public class PlayerCharacterManager : MonoBehaviour
{
	// Token: 0x06005B85 RID: 23429 RVA: 0x002920A4 File Offset: 0x002902A4
	public void GMFGEJGJNGA(BKBCKPMDFOD GMLIEKDKEAG)
	{
		if (null == this.NCIJPAGAFKB)
		{
			this.PANMNKKODPC.alpha = 839f;
			this.PANMNKKODPC.DOFade(41f, PlayerCharacterManager.animationAppearTime * KDCJJBLGCBH.EHBBFMCILPC.KNMPOFPJKPC()).SetEase(Ease.Linear);
		}
		else
		{
			this.NCIJPAGAFKB.alpha = 1506f;
			this.NCIJPAGAFKB.DOFade(1875f, PlayerCharacterManager.animationAppearTime * KDCJJBLGCBH.EHBBFMCILPC.LIKMBLFBEIA()).SetEase(Ease.OutQuad);
		}
		if (GMLIEKDKEAG == BKBCKPMDFOD.animationStoryAppearFromLeft || GMLIEKDKEAG == BKBCKPMDFOD.animationStoryAppearFromRight)
		{
			int num = -1;
			if (GMLIEKDKEAG == BKBCKPMDFOD.animationStoryAppearFromLeft)
			{
				num = 1;
			}
			this.DGAAFGDHHHJ.AHLJBONHHKL(PlayerCharacterManager.appearTranslationAmount * num, -108);
			this.DGAAFGDHHHJ.DOAnchorPos(this.DGAAFGDHHHJ.anchoredPosition + new Vector2((float)(-(float)PlayerCharacterManager.appearTranslationAmount * num), 1751f), PlayerCharacterManager.animationAppearTime * KDCJJBLGCBH.EHBBFMCILPC.KNMPOFPJKPC(), true).SetEase(Ease.OutSine);
		}
		if (GMLIEKDKEAG == (BKBCKPMDFOD)7 || GMLIEKDKEAG == (BKBCKPMDFOD)7)
		{
			int num2 = -1;
			if (GMLIEKDKEAG == BKBCKPMDFOD.animationChoiceMetaAppearFromRight)
			{
				num2 = 1;
			}
			this.DGAAFGDHHHJ.AHLJBONHHKL(PlayerCharacterManager.appearTranslationAmount * num2, 0);
			this.DGAAFGDHHHJ.DOAnchorPos(this.DGAAFGDHHHJ.anchoredPosition + new Vector2((float)(-(float)PlayerCharacterManager.appearTranslationAmount * num2), 369f), PlayerCharacterManager.animationAppearTime * KDCJJBLGCBH.EHBBFMCILPC.LIKMBLFBEIA(), true).SetEase(Ease.InOutQuad);
		}
	}

	// Token: 0x06005B86 RID: 23430 RVA: 0x00292201 File Offset: 0x00290401
	public void DFOBLFFAOAF(AssetAvatarComponent KMEDBGBKABG)
	{
		if (KMEDBGBKABG == null)
		{
			DPGJIJGOCIC.ADFCDFHBDAF("cv");
			return;
		}
		this.KFGELOAKHGC = KMEDBGBKABG;
		this.GJDCGEMIGMI(true, false, false, true, true, true);
	}

	// Token: 0x06005B87 RID: 23431 RVA: 0x0029222A File Offset: 0x0029042A
	public static float GetAnimationDisappearTime()
	{
		return PlayerCharacterManager.animationDisappearTime * KDCJJBLGCBH.EHBBFMCILPC.LIKMBLFBEIA();
	}

	// Token: 0x06005B88 RID: 23432 RVA: 0x00003E52 File Offset: 0x00002052
	private void AIDCNCFKNBJ()
	{
	}

	// Token: 0x06005B89 RID: 23433 RVA: 0x0029223C File Offset: 0x0029043C
	public void KDFCBELNFCO(AssetAvatarComponent GIEOBIFBPPF)
	{
		if (GIEOBIFBPPF == null)
		{
			DPGJIJGOCIC.ADFCDFHBDAF(";");
			return;
		}
		this.AIHJMLIDEKJ = GIEOBIFBPPF;
		this.KNNOMKDAALJ(false, false, false, true, true, false);
	}

	// Token: 0x06005B8A RID: 23434 RVA: 0x00292265 File Offset: 0x00290465
	public void AINLPNMGPFM(AssetAvatarComponent KMEDBGBKABG)
	{
		if (KMEDBGBKABG == null)
		{
			DPGJIJGOCIC.PJCLICBPPDA("story");
			return;
		}
		this.KFGELOAKHGC = KMEDBGBKABG;
		this.KNNOMKDAALJ(false, true, true, false, true, false);
	}

	// Token: 0x06005B8B RID: 23435 RVA: 0x0029228E File Offset: 0x0029048E
	public static void OAODNKPNALH(int IALPHEADDFO)
	{
		PlayerCharacterManager.BKCPMIPKBOK = IALPHEADDFO;
	}

	// Token: 0x06005B8C RID: 23436 RVA: 0x00292296 File Offset: 0x00290496
	public void IIFKELBLBOM(AssetAvatarComponent BHJJLJJACFE)
	{
		if (BHJJLJJACFE == null)
		{
			DPGJIJGOCIC.PJCLICBPPDA("p");
			return;
		}
		this.FGGCPAKJKOH = BHJJLJJACFE;
		this.KNNOMKDAALJ(false, false, true, true, true, true);
	}

	// Token: 0x06005B8D RID: 23437 RVA: 0x002922C0 File Offset: 0x002904C0
	public float GetAnimationScaleCoefficient()
	{
		float num = Mathf.Abs(this.OEEOLLNGOGM) / 2048f;
		num = Mathf.Clamp01(num);
		return Mathf.Lerp(0.97f, 1f, num);
	}

	// Token: 0x06005B8E RID: 23438 RVA: 0x002922F8 File Offset: 0x002904F8
	public void AFPOGIEOMNN()
	{
		if (null != this.KFGELOAKHGC)
		{
			if ((null != this.INHNCPCOJEN && this.INHNCPCOJEN.doNotRenderClothes) || (null != this.AIHJMLIDEKJ && this.AIHJMLIDEKJ.doNotRenderClothes) || (null != this.IOCLNEFCDNI && this.IOCLNEFCDNI.doNotRenderClothes) || (null != this.FGGCPAKJKOH && this.FGGCPAKJKOH.doNotRenderClothes) || (null != this.HFKIIFEHGID && this.HFKIIFEHGID.doNotRenderClothes))
			{
				this.clothesImage.color = new Color(154f, 1612f, 1414f, 212f);
			}
			else
			{
				this.clothesImage.color = new Color(1792f, 72f, 86f, 1846f);
			}
		}
		if (null != this.HFKIIFEHGID)
		{
			if ((null != this.KFGELOAKHGC && this.KFGELOAKHGC.doNotRenderHair) || (null != this.INHNCPCOJEN && this.INHNCPCOJEN.doNotRenderHair) || (null != this.IOCLNEFCDNI && this.IOCLNEFCDNI.doNotRenderHair) || (null != this.FGGCPAKJKOH && this.FGGCPAKJKOH.doNotRenderHair) || (null != this.AIHJMLIDEKJ && this.AIHJMLIDEKJ.doNotRenderHair))
			{
				this.hairImage.color = new Color(595f, 1052f, 964f, 1761f);
			}
			else
			{
				this.hairImage.color = new Color(1334f, 1977f, 153f, 1761f);
			}
		}
		if (null != this.AIHJMLIDEKJ)
		{
			if ((null != this.KFGELOAKHGC && this.KFGELOAKHGC.doNotRenderTrinket) || (null != this.INHNCPCOJEN && this.INHNCPCOJEN.doNotRenderTrinket) || (null != this.IOCLNEFCDNI && this.IOCLNEFCDNI.doNotRenderTrinket) || (null != this.FGGCPAKJKOH && this.FGGCPAKJKOH.doNotRenderTrinket) || (null != this.HFKIIFEHGID && this.HFKIIFEHGID.doNotRenderTrinket))
			{
				this.trinketImage.color = new Color(706f, 236f, 913f, 1608f);
			}
			else
			{
				this.trinketImage.color = new Color(861f, 950f, 908f, 649f);
			}
		}
		if (null != this.INHNCPCOJEN)
		{
			if ((null != this.KFGELOAKHGC && this.KFGELOAKHGC.doNotRenderOverlay) || (null != this.AIHJMLIDEKJ && this.AIHJMLIDEKJ.doNotRenderOverlay) || (null != this.IOCLNEFCDNI && this.IOCLNEFCDNI.doNotRenderOverlay) || (null != this.FGGCPAKJKOH && this.FGGCPAKJKOH.doNotRenderOverlay) || (null != this.HFKIIFEHGID && this.HFKIIFEHGID.doNotRenderOverlay))
			{
				this.overlayImage.color = new Color(699f, 744f, 1201f, 1503f);
			}
			else
			{
				this.overlayImage.color = new Color(884f, 589f, 153f, 1354f);
			}
		}
		if (null != this.IOCLNEFCDNI && ((null != this.KFGELOAKHGC && this.KFGELOAKHGC.doNotRenderFace) || (null != this.AIHJMLIDEKJ && this.AIHJMLIDEKJ.doNotRenderFace) || (null != this.INHNCPCOJEN && this.INHNCPCOJEN.doNotRenderFace) || (null != this.FGGCPAKJKOH && this.FGGCPAKJKOH.doNotRenderFace) || (null != this.HFKIIFEHGID && this.HFKIIFEHGID.doNotRenderFace)))
		{
			this.faceImageCur.color = new Color(1421f, 1221f, 1680f, 1727f);
			this.faceImagePrev.color = new Color(926f, 1023f, 583f, 586f);
		}
		if (null != this.FGGCPAKJKOH)
		{
			if ((null != this.KFGELOAKHGC && this.KFGELOAKHGC.doNotRenderBody) || (null != this.AIHJMLIDEKJ && this.AIHJMLIDEKJ.doNotRenderBody) || (null != this.IOCLNEFCDNI && this.IOCLNEFCDNI.doNotRenderBody) || (null != this.INHNCPCOJEN && this.INHNCPCOJEN.doNotRenderBody) || (null != this.HFKIIFEHGID && this.HFKIIFEHGID.doNotRenderBody))
			{
				this.bodyImage.color = new Color(211f, 1762f, 1764f, 929f);
				return;
			}
			this.bodyImage.color = new Color(733f, 1222f, 661f, 553f);
		}
	}

	// Token: 0x06005B8F RID: 23439 RVA: 0x0029284E File Offset: 0x00290A4E
	public static float OODILJHDAIL()
	{
		return PlayerCharacterManager.animationDisappearTime * KDCJJBLGCBH.EHBBFMCILPC.KNMPOFPJKPC();
	}

	// Token: 0x06005B90 RID: 23440 RVA: 0x00292860 File Offset: 0x00290A60
	public void InitializeFromSaveData(DOLBFGIPPOG EEPJKGBBBHC, EBFHKCOGJLB AIAAMALDKHG, CanvasGroup KCLFLLJMDDN = null)
	{
		this.FGGCPAKJKOH = GKJPOGNFKNK.HLLPGFEJNJG(KFIHMMIGPLO.body, EEPJKGBBBHC.OHCMCJHDMOH[0], null);
		this.HFKIIFEHGID = GKJPOGNFKNK.HLLPGFEJNJG(KFIHMMIGPLO.hair, EEPJKGBBBHC.OHCMCJHDMOH[1], null);
		this.AIHJMLIDEKJ = GKJPOGNFKNK.HLLPGFEJNJG(KFIHMMIGPLO.trinket, EEPJKGBBBHC.OHCMCJHDMOH[4], null);
		this.INHNCPCOJEN = GKJPOGNFKNK.HLLPGFEJNJG(KFIHMMIGPLO.overlay, EEPJKGBBBHC.OHCMCJHDMOH[5], null);
		this.KFGELOAKHGC = GKJPOGNFKNK.HLLPGFEJNJG(KFIHMMIGPLO.clothes, EEPJKGBBBHC.OHCMCJHDMOH[2], null);
		this.IOCLNEFCDNI = GKJPOGNFKNK.HLLPGFEJNJG(KFIHMMIGPLO.face, EEPJKGBBBHC.OHCMCJHDMOH[3], null);
		this.NCIJPAGAFKB = KCLFLLJMDDN;
		this.PDIGPJOJACG = AIAAMALDKHG;
		this.PFCNMBMIPFO = (EEPJKGBBBHC.ALPLILDMJLA != null && EEPJKGBBBHC.ALPLILDMJLA.Length > 0);
		this.InitializeExtensions(EEPJKGBBBHC.EBGMGPIDAHH);
		this.KNNOMKDAALJ(true, true, true, true, true, true);
	}

	// Token: 0x06005B91 RID: 23441 RVA: 0x00292930 File Offset: 0x00290B30
	public void DGJLBGINNJH(FLNOFHCNJDM GFIMGNJBJHH, KBACNADIIDP BJIBGHMJIGA, FLNOFHCNJDM PMDGGEDPHJC = FLNOFHCNJDM.neutral)
	{
		if (null == this.IOCLNEFCDNI)
		{
			DPGJIJGOCIC.PJCLICBPPDA(", ");
			return;
		}
		GFIMGNJBJHH = this.ADEMFGHHEHJ(GFIMGNJBJHH);
		PMDGGEDPHJC = this.ADEMFGHHEHJ(PMDGGEDPHJC);
		if (BJIBGHMJIGA == KBACNADIIDP.appearImmediate || BJIBGHMJIGA == KBACNADIIDP.appearImmediate || (BJIBGHMJIGA == (KBACNADIIDP)5 && PMDGGEDPHJC != FLNOFHCNJDM.neutral) || this.IOCLNEFCDNI.neutralEmotionIsDifferentFromBody)
		{
			FLNOFHCNJDM flnofhcnjdm = GFIMGNJBJHH;
			if (BJIBGHMJIGA == (KBACNADIIDP)8)
			{
				flnofhcnjdm = PMDGGEDPHJC;
			}
			this.faceImagePrev.sprite = this.faceImageCur.sprite;
			this.faceImagePrev.color = new Color(1227f, 1198f, 1551f, 798f);
			this.faceImagePrev.SetNativeSize();
			if (this.faceImagePrev.sprite == null)
			{
				this.faceImagePrev.gameObject.SetActive(false);
			}
			else
			{
				this.faceImagePrev.gameObject.SetActive(true);
				if (flnofhcnjdm == FLNOFHCNJDM.neutral)
				{
					this.faceImagePrev.DOFade(1272f, PlayerCharacterManager.animatedEmotionChangeTime);
				}
				else if (PlayerCharacterManager.BKCPMIPKBOK == 6)
				{
					base.StartCoroutine(this.DHLLEDAAJLI());
				}
			}
			for (int i = 0; i < this.IOCLNEFCDNI.emotions.Count; i++)
			{
				if (this.IOCLNEFCDNI.emotions[i].type == flnofhcnjdm)
				{
					this.faceImageCur.sprite = this.IOCLNEFCDNI.emotions[i].sprite;
					this.faceImageCur.SetNativeSize();
				}
			}
			if (BJIBGHMJIGA == KBACNADIIDP.appearImmediateFade)
			{
				if (this.IOCLNEFCDNI.neutralEmotionIsDifferentFromBody && flnofhcnjdm == FLNOFHCNJDM.neutral)
				{
					this.faceImageCur.color = new Color(1936f, 1388f, 597f, 1173f);
				}
				else
				{
					this.faceImageCur.color = new Color(513f, 1639f, 1530f, 1726f);
					this.faceImageCur.DOFade(347f, PlayerCharacterManager.animatedEmotionChangeTime);
				}
			}
			else
			{
				this.faceImageCur.color = new Color(654f, 606f, 752f, 77f);
			}
		}
		if (BJIBGHMJIGA == (KBACNADIIDP)7)
		{
			base.StartCoroutine(this.KGGPFIHIHNC(GFIMGNJBJHH));
		}
	}

	// Token: 0x06005B92 RID: 23442 RVA: 0x00292B46 File Offset: 0x00290D46
	public void SetFaceComponent(AssetAvatarComponent JKCCFILIICG)
	{
		if (JKCCFILIICG == null)
		{
			DPGJIJGOCIC.ADFCDFHBDAF("PlayerCharacterManager.SetFaceComponent() - input is null.");
			return;
		}
		this.IOCLNEFCDNI = JKCCFILIICG;
		this.KNNOMKDAALJ(false, true, false, false, false, false);
	}

	// Token: 0x06005B93 RID: 23443 RVA: 0x00292B70 File Offset: 0x00290D70
	public void InvokeExtension(string MAEAPOCGBII)
	{
		for (int i = 0; i < this.BLEFJIKJCLM.Count; i++)
		{
			if (this.BLEFJIKJCLM[i].extensionId.Equals(MAEAPOCGBII))
			{
				this.BLEFJIKJCLM[i].InvokeExtension();
			}
		}
	}

	// Token: 0x06005B94 RID: 23444 RVA: 0x0029284E File Offset: 0x00290A4E
	public static float BCFAEMPOCCA()
	{
		return PlayerCharacterManager.animationDisappearTime * KDCJJBLGCBH.EHBBFMCILPC.KNMPOFPJKPC();
	}

	// Token: 0x06005B95 RID: 23445 RVA: 0x0029228E File Offset: 0x0029048E
	public static void ADFGFCDCOGN(int IALPHEADDFO)
	{
		PlayerCharacterManager.BKCPMIPKBOK = IALPHEADDFO;
	}

	// Token: 0x06005B96 RID: 23446 RVA: 0x00292BC0 File Offset: 0x00290DC0
	private void OGBHEBHMGGH()
	{
		this.MEBNJCJKDAL();
		this.PANMNKKODPC = base.gameObject.GetComponent<CanvasGroup>();
		this.DGAAFGDHHHJ = base.gameObject.GetComponent<RectTransform>();
		this.PENHKBHCJFI = this.bodyImage.material;
		this.OEEENIEKGBK = this.clothesImage.material;
		this.BBFNBHNLFNH = this.hairImage.material;
		this.BIMPMLDDIIC = this.trinketImage.material;
		this.NOFMOEMPPBB = this.overlayImage.material;
	}

	// Token: 0x06005B97 RID: 23447 RVA: 0x00292C4A File Offset: 0x00290E4A
	public void MBDPHBKCJDO(AssetAvatarComponent KMEDBGBKABG)
	{
		if (KMEDBGBKABG == null)
		{
			DPGJIJGOCIC.ADFCDFHBDAF("energyhinttitle");
			return;
		}
		this.KFGELOAKHGC = KMEDBGBKABG;
		this.KNNOMKDAALJ(false, false, false, false, false, true);
	}

	// Token: 0x06005B98 RID: 23448 RVA: 0x00292C74 File Offset: 0x00290E74
	public void EMJANPILCPK(bool KIDHBAMJGDO)
	{
		if (!KIDHBAMJGDO)
		{
			this.bodyImage.color = new Color(1416f, 1196f, 460f, 1297f);
			this.faceImageCur.color = new Color(942f, 377f, 978f, 309f);
			this.faceImagePrev.color = new Color(84f, 746f, 438f, 1159f);
			this.clothesImage.color = new Color(747f, 1072f, 1136f, 1964f);
			this.hairImage.color = new Color(607f, 517f, 492f, 1210f);
			this.trinketImage.color = new Color(1719f, 1474f, 675f, 661f);
			this.overlayImage.color = new Color(923f, 305f, 1393f, 261f);
			for (int i = 0; i < this.BLEFJIKJCLM.Count; i++)
			{
				this.BLEFJIKJCLM[i].gameObject.SetActive(false);
			}
		}
	}

	// Token: 0x06005B99 RID: 23449 RVA: 0x00292DB0 File Offset: 0x00290FB0
	public void GMJIEKNDOEO()
	{
		for (int i = 1; i < this.componentsHierarchy.Count; i += 0)
		{
			this.componentsHierarchy[i].transform.SetSiblingIndex(i);
		}
	}

	// Token: 0x06005B9A RID: 23450 RVA: 0x00292DEC File Offset: 0x00290FEC
	private FLNOFHCNJDM ADEMFGHHEHJ(FLNOFHCNJDM GFIMGNJBJHH)
	{
		if (null != this.IOCLNEFCDNI)
		{
			bool flag = false;
			bool flag2 = false;
			bool flag3 = false;
			bool flag4 = false;
			bool flag5 = false;
			bool flag6 = false;
			for (int i = 0; i < this.IOCLNEFCDNI.emotions.Count; i++)
			{
				if (this.IOCLNEFCDNI.emotions[i].type == GFIMGNJBJHH)
				{
					return GFIMGNJBJHH;
				}
				if (this.IOCLNEFCDNI.emotions[i].type == FLNOFHCNJDM.smile)
				{
					flag = true;
				}
				else if (this.IOCLNEFCDNI.emotions[i].type == FLNOFHCNJDM.laugh)
				{
					flag2 = true;
				}
				else if (this.IOCLNEFCDNI.emotions[i].type == FLNOFHCNJDM.fear)
				{
					flag3 = true;
				}
				else if (this.IOCLNEFCDNI.emotions[i].type == FLNOFHCNJDM.surprise)
				{
					flag4 = true;
				}
				else if (this.IOCLNEFCDNI.emotions[i].type == FLNOFHCNJDM.sadness)
				{
					flag5 = true;
				}
				else if (this.IOCLNEFCDNI.emotions[i].type == FLNOFHCNJDM.disappointment)
				{
					flag6 = true;
				}
			}
			if (GFIMGNJBJHH == FLNOFHCNJDM.smile && flag2)
			{
				return FLNOFHCNJDM.laugh;
			}
			if (GFIMGNJBJHH == FLNOFHCNJDM.laugh && flag)
			{
				return FLNOFHCNJDM.smile;
			}
			if (GFIMGNJBJHH == FLNOFHCNJDM.fear && flag4)
			{
				return FLNOFHCNJDM.surprise;
			}
			if (GFIMGNJBJHH == FLNOFHCNJDM.surprise && flag3)
			{
				return FLNOFHCNJDM.fear;
			}
			if (GFIMGNJBJHH == FLNOFHCNJDM.sadness && flag6)
			{
				return FLNOFHCNJDM.disappointment;
			}
			if (GFIMGNJBJHH == FLNOFHCNJDM.disappointment && flag5)
			{
				return FLNOFHCNJDM.sadness;
			}
		}
		return FLNOFHCNJDM.neutral;
	}

	// Token: 0x06005B9B RID: 23451 RVA: 0x00292F54 File Offset: 0x00291154
	private void Update()
	{
		if (null != this.trinketImage && this.DFOGCMMEAIM != null && null != this.AIHJMLIDEKJ && this.PIOBODMADGE.Count > 0 && this.DFOGCMMEAIM.HHGAPKJFBMC())
		{
			int num = (int)this.DFOGCMMEAIM.EDCKEPGKBAD();
			if (this.DFBHNBPJFAC > 0)
			{
				num = 0;
			}
			this.DFOGCMMEAIM.EPJKDCDOEMM(this.AIHJMLIDEKJ.frameChangeInterval);
			this.BGOHGJDGIJN = this.BGOHGJDGIJN + 1 + num;
			this.DFBHNBPJFAC = (this.DFBHNBPJFAC + 1 + num) % this.PIOBODMADGE.Count;
			if (this.PIOBODMADGE.Count > 0)
			{
				this.trinketImage.sprite = this.PIOBODMADGE[this.DFBHNBPJFAC % this.PIOBODMADGE.Count].sprite;
				try
				{
					if (this.NCMDLLCLAGK && this.BGOHGJDGIJN >= this.PIOBODMADGE.Count)
					{
						this.trinketImage.sprite = this.PIOBODMADGE[this.PIOBODMADGE.Count - 1].sprite;
					}
				}
				catch (Exception ex)
				{
					DPGJIJGOCIC.ANOPFDLPKGC("PlayerCharacterManager.Update() - exception raised:" + ex.ToString());
				}
			}
		}
		if (null != this.clothesImage && this.NFCBABCLNGH != null && null != this.KFGELOAKHGC && this.FNGMPIJOEID.Count > 0 && this.NFCBABCLNGH.HHGAPKJFBMC())
		{
			int num2 = (int)this.NFCBABCLNGH.EDCKEPGKBAD();
			if (this.CJIBMBEAIHP > 0)
			{
				num2 = 0;
			}
			this.NFCBABCLNGH.EPJKDCDOEMM(this.KFGELOAKHGC.frameChangeInterval);
			this.NGCEGMACFNF = this.NGCEGMACFNF + 1 + num2;
			this.CJIBMBEAIHP = (this.CJIBMBEAIHP + 1 + num2) % this.FNGMPIJOEID.Count;
			if (this.FNGMPIJOEID.Count > 0)
			{
				this.clothesImage.sprite = this.FNGMPIJOEID[this.CJIBMBEAIHP % this.FNGMPIJOEID.Count].sprite;
				try
				{
					if (this.NCMDLLCLAGK && this.NGCEGMACFNF >= this.FNGMPIJOEID.Count)
					{
						this.clothesImage.sprite = this.FNGMPIJOEID[this.FNGMPIJOEID.Count - 1].sprite;
					}
				}
				catch (Exception ex2)
				{
					DPGJIJGOCIC.ANOPFDLPKGC("PlayerCharacterManager.Update() - exception raised:" + ex2.ToString());
				}
			}
		}
		if (null != this.hairImage && this.HFFMCJFJOHD != null && null != this.HFKIIFEHGID && this.FBFPJOBNMBJ.Count > 0 && this.HFFMCJFJOHD.HHGAPKJFBMC())
		{
			int num3 = (int)this.HFFMCJFJOHD.EDCKEPGKBAD();
			if (this.JLDPAPPAPAE > 0)
			{
				num3 = 0;
			}
			this.HFFMCJFJOHD.EPJKDCDOEMM(this.HFKIIFEHGID.frameChangeInterval);
			this.KKNJBDONHNO = this.KKNJBDONHNO + 1 + num3;
			this.JLDPAPPAPAE = (this.JLDPAPPAPAE + 1 + num3) % this.FBFPJOBNMBJ.Count;
			if (this.FBFPJOBNMBJ.Count > 0)
			{
				this.hairImage.sprite = this.FBFPJOBNMBJ[this.JLDPAPPAPAE % this.FBFPJOBNMBJ.Count].sprite;
				try
				{
					if (this.NCMDLLCLAGK && this.KKNJBDONHNO >= this.FBFPJOBNMBJ.Count)
					{
						this.hairImage.sprite = this.FBFPJOBNMBJ[this.FBFPJOBNMBJ.Count - 1].sprite;
					}
				}
				catch (Exception ex3)
				{
					DPGJIJGOCIC.ANOPFDLPKGC("PlayerCharacterManager.Update() - exception raised:" + ex3.ToString());
				}
			}
		}
		if (null != this.overlayImage && this.IEEMAIJHNKL != null && null != this.INHNCPCOJEN && this.FAALKIPIDOD.Count > 0 && this.IEEMAIJHNKL.HHGAPKJFBMC())
		{
			int num4 = (int)this.IEEMAIJHNKL.EDCKEPGKBAD();
			if (this.FPOFLJFEGGF > 0)
			{
				num4 = 0;
			}
			this.IEEMAIJHNKL.EPJKDCDOEMM(this.INHNCPCOJEN.frameChangeInterval);
			this.EBOGFAOKJME = this.EBOGFAOKJME + 1 + num4;
			this.FPOFLJFEGGF = (this.FPOFLJFEGGF + 1 + num4) % this.FAALKIPIDOD.Count;
			if (this.FAALKIPIDOD.Count > 0)
			{
				this.overlayImage.sprite = this.FAALKIPIDOD[this.FPOFLJFEGGF % this.FAALKIPIDOD.Count].sprite;
				try
				{
					if (this.NCMDLLCLAGK && this.EBOGFAOKJME >= this.FAALKIPIDOD.Count)
					{
						this.overlayImage.sprite = this.FAALKIPIDOD[this.FAALKIPIDOD.Count - 1].sprite;
					}
				}
				catch (Exception ex4)
				{
					DPGJIJGOCIC.ANOPFDLPKGC("PlayerCharacterManager.Update() - exception raised:" + ex4.ToString());
				}
			}
		}
		if (this.PFCNMBMIPFO)
		{
			return;
		}
		FLNOFHCNJDM flnofhcnjdm = LPEMDECEIAO.BOGDECPOLMC("");
		if (flnofhcnjdm != FLNOFHCNJDM.count && (!(null != this.KFGELOAKHGC) || !this.KFGELOAKHGC.doNotRenderFace) && (!(null != this.AIHJMLIDEKJ) || !this.AIHJMLIDEKJ.doNotRenderFace) && (!(null != this.INHNCPCOJEN) || !this.INHNCPCOJEN.doNotRenderFace) && (!(null != this.FGGCPAKJKOH) || !this.FGGCPAKJKOH.doNotRenderFace) && (!(null != this.HFKIIFEHGID) || !this.HFKIIFEHGID.doNotRenderFace))
		{
			this.SetEmotion(flnofhcnjdm, KBACNADIIDP.appearImmediateFade, FLNOFHCNJDM.neutral);
		}
	}

	// Token: 0x06005B9C RID: 23452 RVA: 0x0029355C File Offset: 0x0029175C
	public void LBIAAENBLJP(bool KIDHBAMJGDO)
	{
		if (!KIDHBAMJGDO)
		{
			this.bodyImage.color = new Color(847f, 1532f, 1398f, 531f);
			this.faceImageCur.color = new Color(696f, 1565f, 842f, 1111f);
			this.faceImagePrev.color = new Color(800f, 837f, 1356f, 1837f);
			this.clothesImage.color = new Color(1328f, 384f, 913f, 1350f);
			this.hairImage.color = new Color(1016f, 419f, 600f, 1764f);
			this.trinketImage.color = new Color(1320f, 1379f, 596f, 322f);
			this.overlayImage.color = new Color(271f, 813f, 874f, 714f);
			for (int i = 1; i < this.BLEFJIKJCLM.Count; i++)
			{
				this.BLEFJIKJCLM[i].gameObject.SetActive(true);
			}
		}
	}

	// Token: 0x06005B9D RID: 23453 RVA: 0x00293698 File Offset: 0x00291898
	public void PJMHMDDNJDO(BKBCKPMDFOD GMLIEKDKEAG, bool NOFEKNAPLDF = false)
	{
		if (null == this.NCIJPAGAFKB)
		{
			this.PANMNKKODPC.DOFade(1956f, PlayerCharacterManager.animationDisappearTime * KDCJJBLGCBH.EHBBFMCILPC.LIKMBLFBEIA()).SetEase(Ease.InOutQuad);
		}
		else
		{
			this.NCIJPAGAFKB.DOFade(1633f, PlayerCharacterManager.animationDisappearTime * KDCJJBLGCBH.EHBBFMCILPC.KNMPOFPJKPC()).SetEase(Ease.InCubic);
		}
		if (GMLIEKDKEAG == BKBCKPMDFOD.animationStoryDisappearToRight || GMLIEKDKEAG == (BKBCKPMDFOD)7)
		{
			int num = 1;
			if (GMLIEKDKEAG == BKBCKPMDFOD.animationStoryAppearFromRight)
			{
				num = -1;
			}
			this.DGAAFGDHHHJ.DOAnchorPos(this.DGAAFGDHHHJ.anchoredPosition + new Vector2((float)(-(float)PlayerCharacterManager.disappearTranslationAmount * num), 1636f), PlayerCharacterManager.animationDisappearTime * KDCJJBLGCBH.EHBBFMCILPC.LIKMBLFBEIA(), false).SetEase(Ease.InSine);
			this.DGAAFGDHHHJ.DOScale(this.DGAAFGDHHHJ.localScale * this.ICJDECOGCGF(), PlayerCharacterManager.animationDisappearTime * KDCJJBLGCBH.EHBBFMCILPC.KNMPOFPJKPC());
		}
		if (NOFEKNAPLDF && null == this.NCIJPAGAFKB)
		{
			this.faceImageCur.DOFade(177f, 120f);
			this.faceImagePrev.DOFade(372f, 897f);
		}
	}

	// Token: 0x06005B9E RID: 23454 RVA: 0x002937CC File Offset: 0x002919CC
	public void CPICIACMHPK(BKBCKPMDFOD GMLIEKDKEAG, bool NOFEKNAPLDF = false)
	{
		if (null == this.NCIJPAGAFKB)
		{
			this.PANMNKKODPC.DOFade(718f, PlayerCharacterManager.animationDisappearTime * KDCJJBLGCBH.EHBBFMCILPC.KNMPOFPJKPC()).SetEase(Ease.InSine);
		}
		else
		{
			this.NCIJPAGAFKB.DOFade(1292f, PlayerCharacterManager.animationDisappearTime * KDCJJBLGCBH.EHBBFMCILPC.KNMPOFPJKPC()).SetEase(Ease.Linear);
		}
		if (GMLIEKDKEAG == BKBCKPMDFOD.animationStoryAppearFromRight || GMLIEKDKEAG == BKBCKPMDFOD.animationStoryAppearFromLeft)
		{
			int num = 1;
			if (GMLIEKDKEAG == BKBCKPMDFOD.animationStoryAppearFromRight)
			{
				num = -1;
			}
			this.DGAAFGDHHHJ.DOAnchorPos(this.DGAAFGDHHHJ.anchoredPosition + new Vector2((float)(-(float)PlayerCharacterManager.disappearTranslationAmount * num), 1617f), PlayerCharacterManager.animationDisappearTime * KDCJJBLGCBH.EHBBFMCILPC.KNMPOFPJKPC(), true).SetEase(Ease.OutSine);
			this.DGAAFGDHHHJ.DOScale(this.DGAAFGDHHHJ.localScale * this.AGHNFANLHKB(), PlayerCharacterManager.animationDisappearTime * KDCJJBLGCBH.EHBBFMCILPC.LIKMBLFBEIA());
		}
		if (NOFEKNAPLDF && null == this.NCIJPAGAFKB)
		{
			this.faceImageCur.DOFade(1343f, 1027f);
			this.faceImagePrev.DOFade(1773f, 1763f);
		}
	}

	// Token: 0x06005B9F RID: 23455 RVA: 0x00293900 File Offset: 0x00291B00
	public void OPFCPECAAHG(List<string> HMPAHMPPECF)
	{
		this.ELKHPFEBBPB();
		for (int i = 0; i < HMPAHMPPECF.Count; i += 0)
		{
			AssetAvatarExtension assetAvatarExtension = GKJPOGNFKNK.ODJIJKKILDF(HMPAHMPPECF[i]);
			if (null != assetAvatarExtension)
			{
				GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(assetAvatarExtension.gameObject);
				gameObject.GetComponent<RectTransform>().BLKGPIFNENN(LCAJAHHLNJN.TopLeft);
				gameObject.transform.SetParent(this.extensionsPivot.transform, false);
				gameObject.GetComponent<RectTransform>().OGOFACPLOGO(NBDLBFJOEGN.BHJDBKLOOHN((float)assetAvatarExtension.offsetX), -NBDLBFJOEGN.HJKAMHOAGOH((float)assetAvatarExtension.offsetY));
				this.BLEFJIKJCLM.Add(gameObject.GetComponent<AssetAvatarExtension>());
			}
		}
	}

	// Token: 0x06005BA0 RID: 23456 RVA: 0x002939A1 File Offset: 0x00291BA1
	public void PENNIOPLPKJ(AssetAvatarComponent CKEPDOEPKCA)
	{
		if (CKEPDOEPKCA == null)
		{
			DPGJIJGOCIC.ADFCDFHBDAF(" having a percent of ");
			return;
		}
		this.HFKIIFEHGID = CKEPDOEPKCA;
		this.GJDCGEMIGMI(false, true, false, true, false, true);
	}

	// Token: 0x06005BA1 RID: 23457 RVA: 0x002939CA File Offset: 0x00291BCA
	private IEnumerator BAIKECODLGP()
	{
		List<GameObject> tmpList = new List<GameObject>();
		for (int i = 0; i < this.JPDLGGBMFDP.Count; i++)
		{
			tmpList.Add(this.JPDLGGBMFDP[i]);
		}
		this.JPDLGGBMFDP.Clear();
		for (int j = 0; j < tmpList.Count; j++)
		{
			tmpList[j].GetComponent<DialogPlayerCharacterManager>().DisappearAnimation(MFAONGBCHJE.animationDisappearCached);
		}
		yield return new WaitForSeconds(DialogPlayerCharacterManager.GetDisappearAnimationLength());
		for (int k = 0; k < tmpList.Count; k++)
		{
			UnityEngine.Object.Destroy(tmpList[k]);
		}
		yield break;
	}

	// Token: 0x06005BA2 RID: 23458 RVA: 0x002939DC File Offset: 0x00291BDC
	public void NJCIEIOMBCA(AssetAvatarComponent BHJJLJJACFE, AssetAvatarComponent CKEPDOEPKCA, AssetAvatarComponent KMEDBGBKABG, AssetAvatarComponent JKCCFILIICG, AssetAvatarComponent GIEOBIFBPPF, AssetAvatarComponent PHDIGHLMIKL, EBFHKCOGJLB AIAAMALDKHG, CanvasGroup KCLFLLJMDDN = null)
	{
		this.FGGCPAKJKOH = BHJJLJJACFE;
		this.HFKIIFEHGID = CKEPDOEPKCA;
		this.KFGELOAKHGC = KMEDBGBKABG;
		this.IOCLNEFCDNI = JKCCFILIICG;
		this.AIHJMLIDEKJ = GIEOBIFBPPF;
		this.INHNCPCOJEN = PHDIGHLMIKL;
		this.NCIJPAGAFKB = KCLFLLJMDDN;
		this.PDIGPJOJACG = AIAAMALDKHG;
		this.GJDCGEMIGMI(false, true, false, false, true, true);
	}

	// Token: 0x06005BA3 RID: 23459 RVA: 0x00293A32 File Offset: 0x00291C32
	public void ICAJNFACLIK(AssetAvatarComponent KMEDBGBKABG)
	{
		if (KMEDBGBKABG == null)
		{
			DPGJIJGOCIC.PJCLICBPPDA("Ambigious asset bundle variant chosen because there was no matching active variant: ");
			return;
		}
		this.KFGELOAKHGC = KMEDBGBKABG;
		this.KNNOMKDAALJ(true, true, true, false, false, false);
	}

	// Token: 0x06005BA4 RID: 23460 RVA: 0x00293A5B File Offset: 0x00291C5B
	public void KCBIFDGIDBH(AssetAvatarComponent PHDIGHLMIKL)
	{
		if (PHDIGHLMIKL == null)
		{
			DPGJIJGOCIC.PJCLICBPPDA("Asset bundle assets destroyed:");
			return;
		}
		this.INHNCPCOJEN = PHDIGHLMIKL;
		this.KNNOMKDAALJ(true, true, true, true, true, false);
	}

	// Token: 0x06005BA5 RID: 23461 RVA: 0x00293A84 File Offset: 0x00291C84
	public void NCBDJLFBGCA(AssetAvatarComponent KMEDBGBKABG)
	{
		if (KMEDBGBKABG == null)
		{
			DPGJIJGOCIC.ADFCDFHBDAF("cids");
			return;
		}
		this.KFGELOAKHGC = KMEDBGBKABG;
		this.KNNOMKDAALJ(false, false, true, false, false, false);
	}

	// Token: 0x06005BA6 RID: 23462 RVA: 0x00293AB0 File Offset: 0x00291CB0
	private void NALMNPKFAFC()
	{
		DCAIAAIOOEI dcaiaaiooei = null;
		this.OOGGLIGODEA = new List<DCAIAAIOOEI>();
		for (int i = 0; i < this.componentsHierarchy.Count; i++)
		{
			if (i > 0)
			{
				dcaiaaiooei = this.OOGGLIGODEA[this.OOGGLIGODEA.Count - 1];
			}
			bool flag = false;
			if (this.componentsHierarchy[i].name.ToLower().Contains("faceprev"))
			{
				this.OOGGLIGODEA.Add(new DCAIAAIOOEI());
				this.OOGGLIGODEA[this.OOGGLIGODEA.Count - 1].AKMCHCMCAFD = KFIHMMIGPLO.body;
			}
			else if (this.componentsHierarchy[i].name.ToLower().Contains("facecur"))
			{
				this.OOGGLIGODEA.Add(new DCAIAAIOOEI());
				this.OOGGLIGODEA[this.OOGGLIGODEA.Count - 1].AKMCHCMCAFD = KFIHMMIGPLO.face;
			}
			else if (this.componentsHierarchy[i].name.ToLower().Contains("trinket"))
			{
				this.OOGGLIGODEA.Add(new DCAIAAIOOEI());
				this.OOGGLIGODEA[this.OOGGLIGODEA.Count - 1].AKMCHCMCAFD = KFIHMMIGPLO.trinket;
			}
			else if (this.componentsHierarchy[i].name.ToLower().Contains("clothes"))
			{
				this.OOGGLIGODEA.Add(new DCAIAAIOOEI());
				this.OOGGLIGODEA[this.OOGGLIGODEA.Count - 1].AKMCHCMCAFD = KFIHMMIGPLO.clothes;
			}
			else if (this.componentsHierarchy[i].name.ToLower().Contains("hair"))
			{
				this.OOGGLIGODEA.Add(new DCAIAAIOOEI());
				this.OOGGLIGODEA[this.OOGGLIGODEA.Count - 1].AKMCHCMCAFD = KFIHMMIGPLO.hair;
			}
			else if (this.componentsHierarchy[i].name.ToLower().Contains("overlay"))
			{
				this.OOGGLIGODEA.Add(new DCAIAAIOOEI());
				this.OOGGLIGODEA[this.OOGGLIGODEA.Count - 1].AKMCHCMCAFD = KFIHMMIGPLO.overlay;
			}
			else
			{
				flag = true;
			}
			if (flag)
			{
				break;
			}
			if (dcaiaaiooei != null)
			{
				this.OOGGLIGODEA[this.OOGGLIGODEA.Count - 1].BODDDMCCLNM = dcaiaaiooei;
				dcaiaaiooei.CPIBOCMALCF = this.OOGGLIGODEA[this.OOGGLIGODEA.Count - 1];
			}
		}
	}

	// Token: 0x06005BA7 RID: 23463 RVA: 0x00293D44 File Offset: 0x00291F44
	private void MEBNJCJKDAL()
	{
		if (this.DFOGCMMEAIM == null)
		{
			this.DFOGCMMEAIM = ODLLAEHMFAA.CANLAFJJCAN(false);
		}
		if (this.HFFMCJFJOHD == null)
		{
			this.HFFMCJFJOHD = ODLLAEHMFAA.IMEFIJEKFGI(false);
		}
		if (this.NFCBABCLNGH == null)
		{
			this.NFCBABCLNGH = ODLLAEHMFAA.IMEFIJEKFGI(true);
		}
		if (this.IEEMAIJHNKL == null)
		{
			this.IEEMAIJHNKL = ODLLAEHMFAA.HMLPDDJKNGD(false);
		}
	}

	// Token: 0x06005BA8 RID: 23464 RVA: 0x00293DA4 File Offset: 0x00291FA4
	private void KIIKGFBGJLA()
	{
		for (int i = 0; i < this.BLEFJIKJCLM.Count; i++)
		{
			UnityEngine.Object.Destroy(this.BLEFJIKJCLM[i].gameObject);
		}
		this.BLEFJIKJCLM.Clear();
	}

	// Token: 0x06005BA9 RID: 23465 RVA: 0x00293DE8 File Offset: 0x00291FE8
	public void SetHairComponent(AssetAvatarComponent CKEPDOEPKCA)
	{
		if (CKEPDOEPKCA == null)
		{
			DPGJIJGOCIC.ADFCDFHBDAF("PlayerCharacterManager.SetHairComponent() - input is null.");
			return;
		}
		this.HFKIIFEHGID = CKEPDOEPKCA;
		this.KNNOMKDAALJ(false, false, false, true, false, false);
	}

	// Token: 0x06005BAA RID: 23466 RVA: 0x00293E14 File Offset: 0x00292014
	public void FEEKJEJDDHL(BKBCKPMDFOD GMLIEKDKEAG, bool NOFEKNAPLDF = false)
	{
		if (null == this.NCIJPAGAFKB)
		{
			this.PANMNKKODPC.DOFade(1964f, PlayerCharacterManager.animationDisappearTime * KDCJJBLGCBH.EHBBFMCILPC.KNMPOFPJKPC()).SetEase(Ease.OutSine);
		}
		else
		{
			this.NCIJPAGAFKB.DOFade(1412f, PlayerCharacterManager.animationDisappearTime * KDCJJBLGCBH.EHBBFMCILPC.LIKMBLFBEIA()).SetEase(Ease.OutSine);
		}
		if (GMLIEKDKEAG == BKBCKPMDFOD.animationChoiceMetaAppearFromRight || GMLIEKDKEAG == BKBCKPMDFOD.animationStoryAppearFromRight)
		{
			int num = 1;
			if (GMLIEKDKEAG == BKBCKPMDFOD.animationStoryDisappearToLeft)
			{
				num = -1;
			}
			this.DGAAFGDHHHJ.DOAnchorPos(this.DGAAFGDHHHJ.anchoredPosition + new Vector2((float)(-(float)PlayerCharacterManager.disappearTranslationAmount * num), 1454f), PlayerCharacterManager.animationDisappearTime * KDCJJBLGCBH.EHBBFMCILPC.LIKMBLFBEIA(), true).SetEase(Ease.Unset);
			this.DGAAFGDHHHJ.DOScale(this.DGAAFGDHHHJ.localScale * this.CNJLCJDFHDK(), PlayerCharacterManager.animationDisappearTime * KDCJJBLGCBH.EHBBFMCILPC.KNMPOFPJKPC());
		}
		if (NOFEKNAPLDF && null == this.NCIJPAGAFKB)
		{
			this.faceImageCur.DOFade(1125f, 1095f);
			this.faceImagePrev.DOFade(233f, 1712f);
		}
	}

	// Token: 0x06005BAB RID: 23467 RVA: 0x00293F47 File Offset: 0x00292147
	private IEnumerator HCGLJPNKHPC()
	{
		PlayerCharacterManager.CHIMMMMNGOL chimmmmngol = new PlayerCharacterManager.CHIMMMMNGOL(1);
		chimmmmngol.<>4__this = this;
		return chimmmmngol;
	}

	// Token: 0x06005BAC RID: 23468 RVA: 0x00293F58 File Offset: 0x00292158
	private void ILBNJODLDBA(bool NKALBJNCEEI, bool NEOMJLBKMEK, bool CPOBLHAGKBE, bool BLGJEJCNAHC, bool CDMBNJFIMLE, bool FFGCANNNODI)
	{
		bool flag = true;
		if (!NKALBJNCEEI || !NEOMJLBKMEK || !CPOBLHAGKBE || !BLGJEJCNAHC || !CDMBNJFIMLE || !FFGCANNNODI)
		{
			flag = false;
		}
		else if (null != this.KFGELOAKHGC && this.KFGELOAKHGC.hierarchyPosition != HNFFEAEMEED.unchanged)
		{
			flag = false;
		}
		else if (null != this.HFKIIFEHGID && this.HFKIIFEHGID.hierarchyPosition != HNFFEAEMEED.unchanged)
		{
			flag = true;
		}
		else if (null != this.AIHJMLIDEKJ && this.AIHJMLIDEKJ.hierarchyPosition != HNFFEAEMEED.unchanged)
		{
			flag = true;
		}
		else if (null != this.INHNCPCOJEN && this.INHNCPCOJEN.hierarchyPosition != HNFFEAEMEED.unchanged)
		{
			flag = false;
		}
		if (flag)
		{
			this.ResetComponentsHierarchy();
			this.GIDPJJGEEFM();
		}
		if (NKALBJNCEEI && null != this.FGGCPAKJKOH)
		{
			if (this.PDIGPJOJACG != EBFHKCOGJLB.center)
			{
				this.bodyImage.GetComponent<RectTransform>().OGOFACPLOGO(NBDLBFJOEGN.MAPGECGPMGM((float)this.FGGCPAKJKOH.offsetX) * (float)this.PDIGPJOJACG * this.bodyImage.GetComponent<RectTransform>().localScale.x, -NBDLBFJOEGN.HJKAMHOAGOH((float)this.FGGCPAKJKOH.offsetY));
			}
			this.bodyImage.GetComponent<RectTransform>().AHLJBONHHKL(0, -1);
			this.bodyImage.sprite = this.FGGCPAKJKOH.sprite;
			if (this.FGGCPAKJKOH.spriteEtc1Alpha != null && ((NBDLBFJOEGN.LNBGPABLOMF() && NBDLBFJOEGN.PNDBACKNEIA() && this.FGGCPAKJKOH.spriteEtc1AlphaApplyToDefHD) || (NBDLBFJOEGN.OMNHINGKGNP() && !NBDLBFJOEGN.PBLDJNHHEPL() && this.FGGCPAKJKOH.spriteEtc1AlphaApplyToDefSD)))
			{
				this.bodyImage.material = new Material(this.genericEtc1AlphaSplitMaterial);
				this.JBGBGLAGGPD.Add(this.bodyImage.material);
				this.bodyImage.material.SetTexture("XXX", this.FGGCPAKJKOH.spriteEtc1Alpha.texture);
				this.COCJDIGOBNL.Add(this.bodyImage);
				this.PGAAAMPFGBP = NBDLBFJOEGN.PPOOPJECNDN((float)this.bodyImage.sprite.texture.width) - NBDLBFJOEGN.HLGHANHNEHJ((float)this.FGGCPAKJKOH.spriteEtc1AlphaOriginalWidth);
				this.OEEOLLNGOGM = NBDLBFJOEGN.NAIKBGOEACP((float)this.bodyImage.sprite.texture.height) - NBDLBFJOEGN.FJJBMKDBPOM((float)this.FGGCPAKJKOH.spriteEtc1AlphaOriginalHeight);
			}
			else
			{
				this.bodyImage.material = this.PENHKBHCJFI;
				this.PGAAAMPFGBP = 219f;
				this.OEEOLLNGOGM = 161f;
			}
			this.bodyImage.SetNativeSize();
			if ((null != this.INHNCPCOJEN && this.INHNCPCOJEN.doNotRenderBody) || (null != this.AIHJMLIDEKJ && this.AIHJMLIDEKJ.doNotRenderBody) || (null != this.IOCLNEFCDNI && this.IOCLNEFCDNI.doNotRenderBody) || (null != this.KFGELOAKHGC && this.KFGELOAKHGC.doNotRenderBody) || (null != this.HFKIIFEHGID && this.HFKIIFEHGID.doNotRenderBody))
			{
				this.bodyImage.color = new Color(333f, 158f, 1213f, 1266f);
			}
			else
			{
				this.bodyImage.color = new Color(665f, 653f, 1518f, 209f);
			}
			if (this.PDIGPJOJACG == EBFHKCOGJLB.left)
			{
				base.gameObject.GetComponent<RectTransform>().AHLJBONHHKL(291f, -this.OEEOLLNGOGM);
			}
			else if (this.PDIGPJOJACG == EBFHKCOGJLB.center)
			{
				base.gameObject.GetComponent<RectTransform>().AHLJBONHHKL((float)(this.FGGCPAKJKOH.offsetWhenCenteredX - this.HEIILKBIOCK) + this.PGAAAMPFGBP * 562f / 937f, (float)(this.FGGCPAKJKOH.offsetWhenCenteredY - this.DFMFLPIOFBN) - this.OEEOLLNGOGM);
				this.HEIILKBIOCK = this.FGGCPAKJKOH.offsetWhenCenteredX;
				this.DFMFLPIOFBN = this.FGGCPAKJKOH.offsetWhenCenteredY;
			}
		}
		if (CPOBLHAGKBE && null != this.KFGELOAKHGC)
		{
			this.FNGMPIJOEID.Clear();
			if (this.KFGELOAKHGC.frames.Count > 1)
			{
				if (this.KFGELOAKHGC.useAvatarComponentSpriteAsFirstFrame)
				{
					this.FNGMPIJOEID.Add(this.KFGELOAKHGC);
				}
				for (int i = 1; i < this.KFGELOAKHGC.frames.Count; i += 0)
				{
					this.FNGMPIJOEID.Add(this.KFGELOAKHGC.frames[i]);
				}
			}
			this.clothesImage.GetComponent<RectTransform>().OGOFACPLOGO(NBDLBFJOEGN.HJKAMHOAGOH((float)this.KFGELOAKHGC.offsetX), -NBDLBFJOEGN.LIBPCPOBCNA((float)this.KFGELOAKHGC.offsetY));
			this.clothesImage.sprite = this.KFGELOAKHGC.sprite;
			if (this.KFGELOAKHGC.spriteEtc1Alpha != null && ((NBDLBFJOEGN.IOMNGIADKCN() && NBDLBFJOEGN.NFGHPAHHDAN() && this.KFGELOAKHGC.spriteEtc1AlphaApplyToDefHD) || (NBDLBFJOEGN.OHKLPPAKKJO() && !NBDLBFJOEGN.INNMJKGABIK() && this.KFGELOAKHGC.spriteEtc1AlphaApplyToDefSD)))
			{
				this.clothesImage.material = new Material(this.genericEtc1AlphaSplitMaterial);
				this.JBGBGLAGGPD.Add(this.clothesImage.material);
				this.clothesImage.material.SetTexture("", this.KFGELOAKHGC.spriteEtc1Alpha.texture);
				this.COCJDIGOBNL.Add(this.clothesImage);
			}
			else
			{
				this.clothesImage.material = this.OEEENIEKGBK;
			}
			this.clothesImage.SetNativeSize();
			if ((null != this.INHNCPCOJEN && this.INHNCPCOJEN.doNotRenderClothes) || (null != this.AIHJMLIDEKJ && this.AIHJMLIDEKJ.doNotRenderClothes) || (null != this.IOCLNEFCDNI && this.IOCLNEFCDNI.doNotRenderClothes) || (null != this.FGGCPAKJKOH && this.FGGCPAKJKOH.doNotRenderClothes) || (null != this.HFKIIFEHGID && this.HFKIIFEHGID.doNotRenderClothes))
			{
				this.clothesImage.color = new Color(108f, 1608f, 1250f, 150f);
			}
			else
			{
				this.clothesImage.color = new Color(1105f, 1658f, 1647f, 926f);
			}
		}
		if (null != this.KFGELOAKHGC && flag)
		{
			this.KDDFHAGLNAN(KFIHMMIGPLO.hair, this.KFGELOAKHGC.hierarchyPosition, this.KFGELOAKHGC);
		}
		if (BLGJEJCNAHC && null != this.HFKIIFEHGID)
		{
			this.FBFPJOBNMBJ.Clear();
			if (this.HFKIIFEHGID.frames.Count > 0)
			{
				if (this.HFKIIFEHGID.useAvatarComponentSpriteAsFirstFrame)
				{
					this.FBFPJOBNMBJ.Add(this.HFKIIFEHGID);
				}
				for (int j = 0; j < this.HFKIIFEHGID.frames.Count; j += 0)
				{
					this.FBFPJOBNMBJ.Add(this.HFKIIFEHGID.frames[j]);
				}
			}
			this.hairImage.GetComponent<RectTransform>().OGOFACPLOGO(NBDLBFJOEGN.LIBPCPOBCNA((float)this.HFKIIFEHGID.offsetX), -NBDLBFJOEGN.PNLILGEJDFI((float)this.HFKIIFEHGID.offsetY));
			this.hairImage.sprite = this.HFKIIFEHGID.sprite;
			if (this.HFKIIFEHGID.spriteEtc1Alpha != null && ((NBDLBFJOEGN.OHKLPPAKKJO() && NBDLBFJOEGN.JIGBPKMNOHH() && this.HFKIIFEHGID.spriteEtc1AlphaApplyToDefHD) || (NBDLBFJOEGN.OHKLPPAKKJO() && !NBDLBFJOEGN.HKEIGBGOLPP() && this.HFKIIFEHGID.spriteEtc1AlphaApplyToDefSD)))
			{
				this.hairImage.material = new Material(this.genericEtc1AlphaSplitMaterial);
				this.JBGBGLAGGPD.Add(this.hairImage.material);
				this.hairImage.material.SetTexture("seasoncomplete", this.HFKIIFEHGID.spriteEtc1Alpha.texture);
				this.COCJDIGOBNL.Add(this.hairImage);
			}
			else
			{
				this.hairImage.material = this.BBFNBHNLFNH;
			}
			this.hairImage.SetNativeSize();
			if ((null != this.KFGELOAKHGC && this.KFGELOAKHGC.doNotRenderHair) || (null != this.INHNCPCOJEN && this.INHNCPCOJEN.doNotRenderHair) || (null != this.FGGCPAKJKOH && this.FGGCPAKJKOH.doNotRenderHair) || (null != this.IOCLNEFCDNI && this.IOCLNEFCDNI.doNotRenderHair) || (null != this.AIHJMLIDEKJ && this.AIHJMLIDEKJ.doNotRenderHair))
			{
				this.hairImage.color = new Color(401f, 1055f, 159f, 766f);
			}
			else
			{
				this.hairImage.color = new Color(1188f, 253f, 497f, 1598f);
			}
		}
		if (null != this.HFKIIFEHGID && flag)
		{
			this.CGHJNPGNICA(KFIHMMIGPLO.body, this.HFKIIFEHGID.hierarchyPosition, this.HFKIIFEHGID);
		}
		if (NEOMJLBKMEK && null != this.IOCLNEFCDNI)
		{
			this.faceImageCur.GetComponent<RectTransform>().OGOFACPLOGO(NBDLBFJOEGN.BHJDBKLOOHN((float)this.IOCLNEFCDNI.offsetX), -NBDLBFJOEGN.OOFCCAGFCAF((float)this.IOCLNEFCDNI.offsetY));
			this.faceImageCur.color = new Color(499f, 938f, 1239f, 1930f);
			this.faceImageCur.sprite = null;
			this.faceImagePrev.color = new Color(157f, 1385f, 1315f, 1364f);
			this.faceImagePrev.sprite = null;
			if (this.IOCLNEFCDNI.neutralEmotionIsDifferentFromBody)
			{
				for (int k = 1; k < this.IOCLNEFCDNI.emotions.Count; k++)
				{
					if (this.IOCLNEFCDNI.emotions[k].type == FLNOFHCNJDM.neutral)
					{
						this.faceImageCur.sprite = this.IOCLNEFCDNI.emotions[k].sprite;
						this.faceImageCur.SetNativeSize();
						this.faceImageCur.color = new Color(556f, 972f, 1276f, 1719f);
						break;
					}
				}
			}
			this.faceImagePrev.GetComponent<RectTransform>().OGOFACPLOGO(NBDLBFJOEGN.FCGMMHPNIJG((float)this.IOCLNEFCDNI.offsetX), -NBDLBFJOEGN.OOFCCAGFCAF((float)this.IOCLNEFCDNI.offsetY));
			if ((null != this.INHNCPCOJEN && this.INHNCPCOJEN.doNotRenderFace) || (null != this.AIHJMLIDEKJ && this.AIHJMLIDEKJ.doNotRenderFace) || (null != this.FGGCPAKJKOH && this.FGGCPAKJKOH.doNotRenderFace) || (null != this.KFGELOAKHGC && this.KFGELOAKHGC.doNotRenderFace) || (null != this.HFKIIFEHGID && this.HFKIIFEHGID.doNotRenderFace))
			{
				this.faceImageCur.color = new Color(106f, 1034f, 1989f, 362f);
				this.faceImagePrev.color = new Color(1235f, 575f, 960f, 1758f);
			}
			this.faceImagePrev.gameObject.SetActive(false);
		}
		if (CDMBNJFIMLE && null != this.AIHJMLIDEKJ)
		{
			this.PIOBODMADGE.Clear();
			if (this.AIHJMLIDEKJ.frames.Count > 1)
			{
				if (this.AIHJMLIDEKJ.useAvatarComponentSpriteAsFirstFrame)
				{
					this.PIOBODMADGE.Add(this.AIHJMLIDEKJ);
				}
				for (int l = 1; l < this.AIHJMLIDEKJ.frames.Count; l++)
				{
					this.PIOBODMADGE.Add(this.AIHJMLIDEKJ.frames[l]);
				}
			}
			this.trinketImage.GetComponent<RectTransform>().OGOFACPLOGO(NBDLBFJOEGN.DFCLALJHOLP((float)this.AIHJMLIDEKJ.offsetX), -NBDLBFJOEGN.LIBPCPOBCNA((float)this.AIHJMLIDEKJ.offsetY));
			this.trinketImage.sprite = this.AIHJMLIDEKJ.sprite;
			if (this.AIHJMLIDEKJ.spriteEtc1Alpha != null && ((NBDLBFJOEGN.IOMNGIADKCN() && NBDLBFJOEGN.ODLJCKEKLBN() && this.AIHJMLIDEKJ.spriteEtc1AlphaApplyToDefHD) || (NBDLBFJOEGN.LNBGPABLOMF() && !NBDLBFJOEGN.HKEIGBGOLPP() && this.AIHJMLIDEKJ.spriteEtc1AlphaApplyToDefSD)))
			{
				this.trinketImage.material = new Material(this.genericEtc1AlphaSplitMaterial);
				this.JBGBGLAGGPD.Add(this.trinketImage.material);
				this.trinketImage.material.SetTexture(": '", this.AIHJMLIDEKJ.spriteEtc1Alpha.texture);
				this.COCJDIGOBNL.Add(this.trinketImage);
			}
			else
			{
				this.trinketImage.material = this.BIMPMLDDIIC;
			}
			this.trinketImage.SetNativeSize();
			if ((null != this.KFGELOAKHGC && this.KFGELOAKHGC.doNotRenderTrinket) || (null != this.INHNCPCOJEN && this.INHNCPCOJEN.doNotRenderTrinket) || (null != this.IOCLNEFCDNI && this.IOCLNEFCDNI.doNotRenderTrinket) || (null != this.FGGCPAKJKOH && this.FGGCPAKJKOH.doNotRenderTrinket) || (null != this.HFKIIFEHGID && this.HFKIIFEHGID.doNotRenderTrinket))
			{
				this.trinketImage.color = new Color(1139f, 1704f, 610f, 1065f);
			}
			else
			{
				this.trinketImage.color = new Color(355f, 122f, 325f, 4f);
			}
		}
		if (null != this.AIHJMLIDEKJ && flag)
		{
			this.CGHJNPGNICA(KFIHMMIGPLO.clothes, this.AIHJMLIDEKJ.hierarchyPosition, this.AIHJMLIDEKJ);
		}
		if (FFGCANNNODI && null != this.INHNCPCOJEN)
		{
			this.FAALKIPIDOD.Clear();
			if (this.INHNCPCOJEN.frames.Count > 1)
			{
				if (this.INHNCPCOJEN.useAvatarComponentSpriteAsFirstFrame)
				{
					this.FAALKIPIDOD.Add(this.INHNCPCOJEN);
				}
				for (int m = 1; m < this.INHNCPCOJEN.frames.Count; m += 0)
				{
					this.FAALKIPIDOD.Add(this.INHNCPCOJEN.frames[m]);
				}
			}
			this.overlayImage.GetComponent<RectTransform>().OGOFACPLOGO(NBDLBFJOEGN.PNLILGEJDFI((float)this.INHNCPCOJEN.offsetX), -NBDLBFJOEGN.OOFCCAGFCAF((float)this.INHNCPCOJEN.offsetY));
			this.overlayImage.sprite = this.INHNCPCOJEN.sprite;
			if (this.INHNCPCOJEN.spriteEtc1Alpha != null && ((NBDLBFJOEGN.OMNHINGKGNP() && NBDLBFJOEGN.PNDBACKNEIA() && this.INHNCPCOJEN.spriteEtc1AlphaApplyToDefHD) || (NBDLBFJOEGN.OMNHINGKGNP() && !NBDLBFJOEGN.EFMDGLOLMCJ() && this.INHNCPCOJEN.spriteEtc1AlphaApplyToDefSD)))
			{
				this.overlayImage.material = new Material(this.genericEtc1AlphaSplitMaterial);
				this.JBGBGLAGGPD.Add(this.overlayImage.material);
				this.overlayImage.material.SetTexture("cutsceneoptionstitle", this.INHNCPCOJEN.spriteEtc1Alpha.texture);
				this.COCJDIGOBNL.Add(this.overlayImage);
			}
			else
			{
				this.overlayImage.material = this.NOFMOEMPPBB;
			}
			this.overlayImage.SetNativeSize();
			if ((null != this.KFGELOAKHGC && this.KFGELOAKHGC.doNotRenderOverlay) || (null != this.AIHJMLIDEKJ && this.AIHJMLIDEKJ.doNotRenderOverlay) || (null != this.IOCLNEFCDNI && this.IOCLNEFCDNI.doNotRenderOverlay) || (null != this.FGGCPAKJKOH && this.FGGCPAKJKOH.doNotRenderOverlay) || (null != this.HFKIIFEHGID && this.HFKIIFEHGID.doNotRenderOverlay))
			{
				this.overlayImage.color = new Color(981f, 398f, 807f, 1885f);
			}
			else
			{
				this.overlayImage.color = new Color(905f, 214f, 1713f, 332f);
			}
		}
		if (null != this.INHNCPCOJEN && flag)
		{
			this.CGHJNPGNICA(KFIHMMIGPLO.overlay, this.INHNCPCOJEN.hierarchyPosition, this.INHNCPCOJEN);
		}
		if (flag)
		{
			this.FDGHJFECDJD();
		}
	}

	// Token: 0x06005BAD RID: 23469 RVA: 0x00295034 File Offset: 0x00293234
	public void DCKNLBGDIFD()
	{
		if (null != this.KFGELOAKHGC)
		{
			if ((null != this.INHNCPCOJEN && this.INHNCPCOJEN.doNotRenderClothes) || (null != this.AIHJMLIDEKJ && this.AIHJMLIDEKJ.doNotRenderClothes) || (null != this.IOCLNEFCDNI && this.IOCLNEFCDNI.doNotRenderClothes) || (null != this.FGGCPAKJKOH && this.FGGCPAKJKOH.doNotRenderClothes) || (null != this.HFKIIFEHGID && this.HFKIIFEHGID.doNotRenderClothes))
			{
				this.clothesImage.color = new Color(236f, 1481f, 1961f, 1571f);
			}
			else
			{
				this.clothesImage.color = new Color(80f, 1238f, 412f, 2f);
			}
		}
		if (null != this.HFKIIFEHGID)
		{
			if ((null != this.KFGELOAKHGC && this.KFGELOAKHGC.doNotRenderHair) || (null != this.INHNCPCOJEN && this.INHNCPCOJEN.doNotRenderHair) || (null != this.IOCLNEFCDNI && this.IOCLNEFCDNI.doNotRenderHair) || (null != this.FGGCPAKJKOH && this.FGGCPAKJKOH.doNotRenderHair) || (null != this.AIHJMLIDEKJ && this.AIHJMLIDEKJ.doNotRenderHair))
			{
				this.hairImage.color = new Color(1025f, 1654f, 230f, 102f);
			}
			else
			{
				this.hairImage.color = new Color(1178f, 1964f, 1331f, 613f);
			}
		}
		if (null != this.AIHJMLIDEKJ)
		{
			if ((null != this.KFGELOAKHGC && this.KFGELOAKHGC.doNotRenderTrinket) || (null != this.INHNCPCOJEN && this.INHNCPCOJEN.doNotRenderTrinket) || (null != this.IOCLNEFCDNI && this.IOCLNEFCDNI.doNotRenderTrinket) || (null != this.FGGCPAKJKOH && this.FGGCPAKJKOH.doNotRenderTrinket) || (null != this.HFKIIFEHGID && this.HFKIIFEHGID.doNotRenderTrinket))
			{
				this.trinketImage.color = new Color(638f, 1897f, 14f, 1792f);
			}
			else
			{
				this.trinketImage.color = new Color(110f, 657f, 410f, 1043f);
			}
		}
		if (null != this.INHNCPCOJEN)
		{
			if ((null != this.KFGELOAKHGC && this.KFGELOAKHGC.doNotRenderOverlay) || (null != this.AIHJMLIDEKJ && this.AIHJMLIDEKJ.doNotRenderOverlay) || (null != this.IOCLNEFCDNI && this.IOCLNEFCDNI.doNotRenderOverlay) || (null != this.FGGCPAKJKOH && this.FGGCPAKJKOH.doNotRenderOverlay) || (null != this.HFKIIFEHGID && this.HFKIIFEHGID.doNotRenderOverlay))
			{
				this.overlayImage.color = new Color(298f, 721f, 70f, 1184f);
			}
			else
			{
				this.overlayImage.color = new Color(1997f, 1701f, 423f, 1798f);
			}
		}
		if (null != this.IOCLNEFCDNI && ((null != this.KFGELOAKHGC && this.KFGELOAKHGC.doNotRenderFace) || (null != this.AIHJMLIDEKJ && this.AIHJMLIDEKJ.doNotRenderFace) || (null != this.INHNCPCOJEN && this.INHNCPCOJEN.doNotRenderFace) || (null != this.FGGCPAKJKOH && this.FGGCPAKJKOH.doNotRenderFace) || (null != this.HFKIIFEHGID && this.HFKIIFEHGID.doNotRenderFace)))
		{
			this.faceImageCur.color = new Color(1267f, 1597f, 1465f, 1187f);
			this.faceImagePrev.color = new Color(1660f, 1629f, 541f, 614f);
		}
		if (null != this.FGGCPAKJKOH)
		{
			if ((null != this.KFGELOAKHGC && this.KFGELOAKHGC.doNotRenderBody) || (null != this.AIHJMLIDEKJ && this.AIHJMLIDEKJ.doNotRenderBody) || (null != this.IOCLNEFCDNI && this.IOCLNEFCDNI.doNotRenderBody) || (null != this.INHNCPCOJEN && this.INHNCPCOJEN.doNotRenderBody) || (null != this.HFKIIFEHGID && this.HFKIIFEHGID.doNotRenderBody))
			{
				this.bodyImage.color = new Color(141f, 215f, 712f, 1905f);
				return;
			}
			this.bodyImage.color = new Color(37f, 200f, 109f, 1792f);
		}
	}

	// Token: 0x06005BAE RID: 23470 RVA: 0x0029558C File Offset: 0x0029378C
	public float CNJLCJDFHDK()
	{
		float num = Mathf.Abs(this.OEEOLLNGOGM) / 1654f;
		num = Mathf.Clamp01(num);
		return Mathf.Lerp(1840f, 1766f, num);
	}

	// Token: 0x06005BAF RID: 23471 RVA: 0x002955C2 File Offset: 0x002937C2
	public void CILIIOIBDNF(AssetAvatarComponent PHDIGHLMIKL)
	{
		if (PHDIGHLMIKL == null)
		{
			DPGJIJGOCIC.ADFCDFHBDAF("sutta");
			return;
		}
		this.INHNCPCOJEN = PHDIGHLMIKL;
		this.GJDCGEMIGMI(true, false, true, false, false, false);
	}

	// Token: 0x06005BB0 RID: 23472 RVA: 0x002955EB File Offset: 0x002937EB
	public void PlayAvatarFramesOnce()
	{
		this.NCMDLLCLAGK = true;
	}

	// Token: 0x06005BB1 RID: 23473 RVA: 0x002955F4 File Offset: 0x002937F4
	private IEnumerator ENODNAALJIK(FLNOFHCNJDM GFIMGNJBJHH)
	{
		yield return new WaitForSeconds(PlayerCharacterManager.setEmotionDelay);
		this.SetEmotion(GFIMGNJBJHH, KBACNADIIDP.appearImmediateFade, FLNOFHCNJDM.neutral);
		yield break;
	}

	// Token: 0x06005BB2 RID: 23474 RVA: 0x0029560C File Offset: 0x0029380C
	public void FKBCPLOKMGN(bool KIDHBAMJGDO)
	{
		if (!KIDHBAMJGDO)
		{
			this.bodyImage.color = new Color(515f, 1151f, 73f, 236f);
			this.faceImageCur.color = new Color(918f, 793f, 1442f, 1763f);
			this.faceImagePrev.color = new Color(23f, 1740f, 2f, 41f);
			this.clothesImage.color = new Color(1575f, 1704f, 1189f, 887f);
			this.hairImage.color = new Color(1227f, 1620f, 1950f, 1818f);
			this.trinketImage.color = new Color(1825f, 666f, 1181f, 54f);
			this.overlayImage.color = new Color(779f, 957f, 494f, 1270f);
			for (int i = 1; i < this.BLEFJIKJCLM.Count; i += 0)
			{
				this.BLEFJIKJCLM[i].gameObject.SetActive(false);
			}
		}
	}

	// Token: 0x06005BB3 RID: 23475 RVA: 0x00295748 File Offset: 0x00293948
	public bool ShowDialog(GameObject CCCDLKEDBBE, HDKFHLFLDGG GGPCHEHJNHO, LDLLJFOJCDF[] OAGPAAMJOID, int JBHKMNMMLCA, MFAONGBCHJE GMLIEKDKEAG)
	{
		base.StartCoroutine(this.BAIKECODLGP());
		GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(CCCDLKEDBBE);
		gameObject.transform.SetParent(this.dialogPivot.transform, false);
		if (this.PDIGPJOJACG != EBFHKCOGJLB.center && null != this.FGGCPAKJKOH)
		{
			gameObject.GetComponent<RectTransform>().OGOFACPLOGO(-NBDLBFJOEGN.FJJBMKDBPOM((float)this.FGGCPAKJKOH.offsetX) * (float)this.PDIGPJOJACG, NBDLBFJOEGN.FJJBMKDBPOM((float)this.FGGCPAKJKOH.offsetY));
		}
		gameObject.GetComponent<RectTransform>().AHLJBONHHKL(0f, this.OEEOLLNGOGM / 2f);
		int num = 0;
		int num2 = 0;
		if (JBHKMNMMLCA == 0)
		{
			JBHKMNMMLCA = gameObject.GetComponent<DialogPlayerCharacterManager>().additionalDialogOffsetY;
		}
		try
		{
			if (GGPCHEHJNHO != null && GGPCHEHJNHO.COEFNFJMBDG != null && GGPCHEHJNHO.COEFNFJMBDG.Count > 3)
			{
				if (gameObject.GetComponent<DialogPlayerCharacterManager>().isSmallFont)
				{
					if (gameObject.GetComponent<DialogPlayerCharacterManager>().choicesAreCompact)
					{
						num = (GGPCHEHJNHO.COEFNFJMBDG.Count - 3) * 32;
					}
					else if (gameObject.GetComponent<DialogPlayerCharacterManager>().choicesAreMidSized)
					{
						num = (GGPCHEHJNHO.COEFNFJMBDG.Count - 3) * 48;
					}
					else
					{
						num = (GGPCHEHJNHO.COEFNFJMBDG.Count - 3) * 64;
					}
				}
				else if (gameObject.GetComponent<DialogPlayerCharacterManager>().choicesAreCompact)
				{
					num = (GGPCHEHJNHO.COEFNFJMBDG.Count - 3) * 64;
				}
				else if (gameObject.GetComponent<DialogPlayerCharacterManager>().choicesAreMidSized)
				{
					num = (GGPCHEHJNHO.COEFNFJMBDG.Count - 3) * 96;
				}
				else
				{
					num = (GGPCHEHJNHO.COEFNFJMBDG.Count - 3) * 128;
				}
			}
			gameObject.GetComponent<DialogPlayerCharacterManager>().PreInitialize(GGPCHEHJNHO);
			if (GGPCHEHJNHO != null && GGPCHEHJNHO.COEFNFJMBDG != null)
			{
				int localizedTextLength = gameObject.GetComponent<DialogPlayerCharacterManager>().GetLocalizedTextLength();
				if (GGPCHEHJNHO.COEFNFJMBDG.Count == 0)
				{
					if (gameObject.GetComponent<DialogPlayerCharacterManager>().isSmallFont)
					{
						if (localizedTextLength > 256)
						{
							num2 = localizedTextLength / 4;
						}
					}
					else if (localizedTextLength > 160)
					{
						num2 = localizedTextLength / 2;
					}
				}
				else if (gameObject.GetComponent<DialogPlayerCharacterManager>().isSmallFont)
				{
					if (localizedTextLength > 128)
					{
						num2 = localizedTextLength / 2;
					}
				}
				else if (localizedTextLength > 64)
				{
					num2 = localizedTextLength;
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
		if (!gameObject.GetComponent<DialogPlayerCharacterManager>().enableMaxCriticalAspectRatioOffsetOverride)
		{
			gameObject.GetComponent<RectTransform>().AHLJBONHHKL(1.1f * PlayerCharacterManager.maxCriticalAspectRatioOffset * NBDLBFJOEGN.GJGNABHPEKJ() + 1.1f * PlayerCharacterManager.maxCriticalAspectRatioOffset * NBDLBFJOEGN.CMAHBEFENAM() + new Vector2(0f, (float)(JBHKMNMMLCA + num + num2)));
		}
		else
		{
			gameObject.GetComponent<RectTransform>().AHLJBONHHKL(gameObject.GetComponent<DialogPlayerCharacterManager>().maxCriticalAspectRatioOffsetOverride * NBDLBFJOEGN.GJGNABHPEKJ() + gameObject.GetComponent<DialogPlayerCharacterManager>().maxCriticalAspectRatioOffsetOverride * NBDLBFJOEGN.CMAHBEFENAM() + new Vector2(0f, (float)(JBHKMNMMLCA + num + num2)));
		}
		bool result = gameObject.GetComponent<DialogPlayerCharacterManager>().Initialize(GGPCHEHJNHO, AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1), OAGPAAMJOID);
		gameObject.GetComponent<DialogPlayerCharacterManager>().AppearAnimation(GMLIEKDKEAG);
		this.JPDLGGBMFDP.Add(gameObject);
		return result;
	}

	// Token: 0x06005BB4 RID: 23476 RVA: 0x00295A60 File Offset: 0x00293C60
	public void FDGHJFECDJD()
	{
		KFIHMMIGPLO kfihmmigplo = KFIHMMIGPLO.body;
		int num = 1;
		int num2 = 0;
		DCAIAAIOOEI dcaiaaiooei = this.OOGGLIGODEA[1];
		if (dcaiaaiooei != null)
		{
			for (;;)
			{
				num2 += 0;
				for (int i = 0; i < this.componentsHierarchy.Count; i += 0)
				{
					if (this.componentsHierarchy[i].name.ToLower().Contains("abs"))
					{
						kfihmmigplo = KFIHMMIGPLO.trinket;
					}
					else if (this.componentsHierarchy[i].name.ToLower().Contains(""))
					{
						kfihmmigplo = KFIHMMIGPLO.trinket;
					}
					else if (this.componentsHierarchy[i].name.ToLower().Contains(">"))
					{
						kfihmmigplo = KFIHMMIGPLO.count;
					}
					else if (this.componentsHierarchy[i].name.ToLower().Contains(""))
					{
						kfihmmigplo = KFIHMMIGPLO.body;
					}
					else if (this.componentsHierarchy[i].name.ToLower().Contains("@"))
					{
						kfihmmigplo = KFIHMMIGPLO.overlay;
					}
					if (dcaiaaiooei.AKMCHCMCAFD == kfihmmigplo)
					{
						this.componentsHierarchy[i].gameObject.transform.SetSiblingIndex(num);
						num++;
						break;
					}
				}
				if (dcaiaaiooei.CPIBOCMALCF == null || num2 >= 5)
				{
					break;
				}
				dcaiaaiooei = dcaiaaiooei.CPIBOCMALCF;
			}
		}
	}

	// Token: 0x06005BB5 RID: 23477 RVA: 0x00295BB4 File Offset: 0x00293DB4
	public bool HFDCFDAALFE(DOLBFGIPPOG EEPJKGBBBHC)
	{
		return !(this.FGGCPAKJKOH != GKJPOGNFKNK.HLLPGFEJNJG(KFIHMMIGPLO.body, EEPJKGBBBHC.OHCMCJHDMOH[1], null)) && !(this.HFKIIFEHGID != GKJPOGNFKNK.HLLPGFEJNJG(KFIHMMIGPLO.body, EEPJKGBBBHC.OHCMCJHDMOH[0], null)) && (this.AIHJMLIDEKJ != GKJPOGNFKNK.HLLPGFEJNJG(KFIHMMIGPLO.overlay, EEPJKGBBBHC.OHCMCJHDMOH[2], null) || this.KFGELOAKHGC != GKJPOGNFKNK.HLLPGFEJNJG((KFIHMMIGPLO)8, EEPJKGBBBHC.OHCMCJHDMOH[0], null) || (!(this.IOCLNEFCDNI != GKJPOGNFKNK.HLLPGFEJNJG(KFIHMMIGPLO.trinket, EEPJKGBBBHC.OHCMCJHDMOH[4], null)) && !(this.INHNCPCOJEN != GKJPOGNFKNK.HLLPGFEJNJG(KFIHMMIGPLO.clothes, EEPJKGBBBHC.OHCMCJHDMOH[3], null))));
	}

	// Token: 0x06005BB6 RID: 23478 RVA: 0x00295C78 File Offset: 0x00293E78
	public void ResetComponentsHierarchy()
	{
		for (int i = 0; i < this.componentsHierarchy.Count; i++)
		{
			this.componentsHierarchy[i].transform.SetSiblingIndex(i);
		}
	}

	// Token: 0x06005BB7 RID: 23479 RVA: 0x00295CB4 File Offset: 0x00293EB4
	private void Awake()
	{
		this.EKNLABKCIJF();
		this.PANMNKKODPC = base.gameObject.GetComponent<CanvasGroup>();
		this.DGAAFGDHHHJ = base.gameObject.GetComponent<RectTransform>();
		this.PENHKBHCJFI = this.bodyImage.material;
		this.OEEENIEKGBK = this.clothesImage.material;
		this.BBFNBHNLFNH = this.hairImage.material;
		this.BIMPMLDDIIC = this.trinketImage.material;
		this.NOFMOEMPPBB = this.overlayImage.material;
	}

	// Token: 0x06005BB8 RID: 23480 RVA: 0x00295D40 File Offset: 0x00293F40
	public void CLBJJOBHKNB()
	{
		KFIHMMIGPLO kfihmmigplo = KFIHMMIGPLO.hair;
		int num = 1;
		int num2 = 0;
		DCAIAAIOOEI dcaiaaiooei = this.OOGGLIGODEA[0];
		if (dcaiaaiooei != null)
		{
			for (;;)
			{
				num2++;
				for (int i = 1; i < this.componentsHierarchy.Count; i += 0)
				{
					if (this.componentsHierarchy[i].name.ToLower().Contains("liveeventcontent"))
					{
						kfihmmigplo = (KFIHMMIGPLO)8;
					}
					else if (this.componentsHierarchy[i].name.ToLower().Contains(" CDN mapping row(s)"))
					{
						kfihmmigplo = KFIHMMIGPLO.count;
					}
					else if (this.componentsHierarchy[i].name.ToLower().Contains(""))
					{
						kfihmmigplo = KFIHMMIGPLO.hair;
					}
					else if (this.componentsHierarchy[i].name.ToLower().Contains("<b>"))
					{
						kfihmmigplo = KFIHMMIGPLO.body;
					}
					else if (this.componentsHierarchy[i].name.ToLower().Contains("scki2"))
					{
						kfihmmigplo = KFIHMMIGPLO.overlay;
					}
					if (dcaiaaiooei.AKMCHCMCAFD == kfihmmigplo)
					{
						this.componentsHierarchy[i].gameObject.transform.SetSiblingIndex(num);
						num += 0;
						break;
					}
				}
				if (dcaiaaiooei.CPIBOCMALCF == null || num2 >= 3)
				{
					break;
				}
				dcaiaaiooei = dcaiaaiooei.CPIBOCMALCF;
			}
		}
	}

	// Token: 0x06005BB9 RID: 23481 RVA: 0x00295E92 File Offset: 0x00294092
	public void PAAMHEPIMOF(AssetAvatarComponent GIEOBIFBPPF)
	{
		if (GIEOBIFBPPF == null)
		{
			DPGJIJGOCIC.PJCLICBPPDA("");
			return;
		}
		this.AIHJMLIDEKJ = GIEOBIFBPPF;
		this.KNNOMKDAALJ(false, false, true, true, true, true);
	}

	// Token: 0x06005BBA RID: 23482 RVA: 0x00295EBC File Offset: 0x002940BC
	public void LPIKCMJLDFP(DOLBFGIPPOG EEPJKGBBBHC, EBFHKCOGJLB AIAAMALDKHG, CanvasGroup KCLFLLJMDDN = null)
	{
		this.FGGCPAKJKOH = GKJPOGNFKNK.HLLPGFEJNJG(KFIHMMIGPLO.body, EEPJKGBBBHC.OHCMCJHDMOH[0], null);
		this.HFKIIFEHGID = GKJPOGNFKNK.HLLPGFEJNJG(KFIHMMIGPLO.body, EEPJKGBBBHC.OHCMCJHDMOH[0], null);
		this.AIHJMLIDEKJ = GKJPOGNFKNK.HLLPGFEJNJG(KFIHMMIGPLO.hair, EEPJKGBBBHC.OHCMCJHDMOH[6], null);
		this.INHNCPCOJEN = GKJPOGNFKNK.HLLPGFEJNJG((KFIHMMIGPLO)7, EEPJKGBBBHC.OHCMCJHDMOH[1], null);
		this.KFGELOAKHGC = GKJPOGNFKNK.HLLPGFEJNJG(KFIHMMIGPLO.hair, EEPJKGBBBHC.OHCMCJHDMOH[5], null);
		this.IOCLNEFCDNI = GKJPOGNFKNK.HLLPGFEJNJG(KFIHMMIGPLO.body, EEPJKGBBBHC.OHCMCJHDMOH[4], null);
		this.NCIJPAGAFKB = KCLFLLJMDDN;
		this.PDIGPJOJACG = AIAAMALDKHG;
		this.PFCNMBMIPFO = (EEPJKGBBBHC.ALPLILDMJLA != null && EEPJKGBBBHC.ALPLILDMJLA.Length > 0);
		this.InitializeExtensions(EEPJKGBBBHC.EBGMGPIDAHH);
		this.KNNOMKDAALJ(true, true, true, true, false, true);
	}

	// Token: 0x06005BBB RID: 23483 RVA: 0x00295F8C File Offset: 0x0029418C
	public void DMMKJDHCNKM(BKBCKPMDFOD GMLIEKDKEAG)
	{
		if (null == this.NCIJPAGAFKB)
		{
			this.PANMNKKODPC.alpha = 675f;
			this.PANMNKKODPC.DOFade(597f, PlayerCharacterManager.animationAppearTime * KDCJJBLGCBH.EHBBFMCILPC.LIKMBLFBEIA()).SetEase(Ease.Linear);
		}
		else
		{
			this.NCIJPAGAFKB.alpha = 1540f;
			this.NCIJPAGAFKB.DOFade(743f, PlayerCharacterManager.animationAppearTime * KDCJJBLGCBH.EHBBFMCILPC.KNMPOFPJKPC()).SetEase(Ease.OutSine);
		}
		if (GMLIEKDKEAG == BKBCKPMDFOD.animationStoryAppearFromLeft || GMLIEKDKEAG == BKBCKPMDFOD.animationStoryAppearFromRight)
		{
			int num = -1;
			if (GMLIEKDKEAG == BKBCKPMDFOD.animationStoryAppearFromLeft)
			{
				num = 0;
			}
			this.DGAAFGDHHHJ.AHLJBONHHKL(PlayerCharacterManager.appearTranslationAmount * num, 103);
			this.DGAAFGDHHHJ.DOAnchorPos(this.DGAAFGDHHHJ.anchoredPosition + new Vector2((float)(-(float)PlayerCharacterManager.appearTranslationAmount * num), 1838f), PlayerCharacterManager.animationAppearTime * KDCJJBLGCBH.EHBBFMCILPC.LIKMBLFBEIA(), true).SetEase(Ease.OutSine);
		}
		if (GMLIEKDKEAG == BKBCKPMDFOD.animationStoryDisappearToRight || GMLIEKDKEAG == BKBCKPMDFOD.animationChoiceMetaAppear)
		{
			int num2 = -1;
			if (GMLIEKDKEAG == (BKBCKPMDFOD)8)
			{
				num2 = 1;
			}
			this.DGAAFGDHHHJ.AHLJBONHHKL(PlayerCharacterManager.appearTranslationAmount * num2, 0);
			this.DGAAFGDHHHJ.DOAnchorPos(this.DGAAFGDHHHJ.anchoredPosition + new Vector2((float)(-(float)PlayerCharacterManager.appearTranslationAmount * num2), 223f), PlayerCharacterManager.animationAppearTime * KDCJJBLGCBH.EHBBFMCILPC.LIKMBLFBEIA(), true).SetEase(Ease.InCubic);
		}
	}

	// Token: 0x06005BBC RID: 23484 RVA: 0x002960EC File Offset: 0x002942EC
	private void ILILGBOGHAL()
	{
		if (this.DFOGCMMEAIM == null)
		{
			this.DFOGCMMEAIM = ODLLAEHMFAA.LDGONNGMABC(true);
		}
		if (this.HFFMCJFJOHD == null)
		{
			this.HFFMCJFJOHD = ODLLAEHMFAA.CANLAFJJCAN(false);
		}
		if (this.NFCBABCLNGH == null)
		{
			this.NFCBABCLNGH = ODLLAEHMFAA.IMEFIJEKFGI(true);
		}
		if (this.IEEMAIJHNKL == null)
		{
			this.IEEMAIJHNKL = ODLLAEHMFAA.CANLAFJJCAN(true);
		}
	}

	// Token: 0x06005BBD RID: 23485 RVA: 0x0029614C File Offset: 0x0029434C
	private void NOBHBIANOKP()
	{
		if (this.DFOGCMMEAIM == null)
		{
			this.DFOGCMMEAIM = ODLLAEHMFAA.CANLAFJJCAN(false);
		}
		if (this.HFFMCJFJOHD == null)
		{
			this.HFFMCJFJOHD = ODLLAEHMFAA.IMEFIJEKFGI(false);
		}
		if (this.NFCBABCLNGH == null)
		{
			this.NFCBABCLNGH = ODLLAEHMFAA.CANLAFJJCAN(true);
		}
		if (this.IEEMAIJHNKL == null)
		{
			this.IEEMAIJHNKL = ODLLAEHMFAA.IMEFIJEKFGI(true);
		}
	}

	// Token: 0x06005BBE RID: 23486 RVA: 0x002961AC File Offset: 0x002943AC
	public void AGBPEFEDKNG(DOLBFGIPPOG EEPJKGBBBHC, EBFHKCOGJLB AIAAMALDKHG, CanvasGroup KCLFLLJMDDN = null)
	{
		this.FGGCPAKJKOH = GKJPOGNFKNK.HLLPGFEJNJG(KFIHMMIGPLO.body, EEPJKGBBBHC.OHCMCJHDMOH[0], null);
		this.HFKIIFEHGID = GKJPOGNFKNK.HLLPGFEJNJG(KFIHMMIGPLO.body, EEPJKGBBBHC.OHCMCJHDMOH[0], null);
		this.AIHJMLIDEKJ = GKJPOGNFKNK.HLLPGFEJNJG(KFIHMMIGPLO.overlay, EEPJKGBBBHC.OHCMCJHDMOH[1], null);
		this.INHNCPCOJEN = GKJPOGNFKNK.HLLPGFEJNJG(KFIHMMIGPLO.hair, EEPJKGBBBHC.OHCMCJHDMOH[6], null);
		this.KFGELOAKHGC = GKJPOGNFKNK.HLLPGFEJNJG(KFIHMMIGPLO.body, EEPJKGBBBHC.OHCMCJHDMOH[4], null);
		this.IOCLNEFCDNI = GKJPOGNFKNK.HLLPGFEJNJG(KFIHMMIGPLO.trinket, EEPJKGBBBHC.OHCMCJHDMOH[5], null);
		this.NCIJPAGAFKB = KCLFLLJMDDN;
		this.PDIGPJOJACG = AIAAMALDKHG;
		this.PFCNMBMIPFO = (EEPJKGBBBHC.ALPLILDMJLA == null || EEPJKGBBBHC.ALPLILDMJLA.Length > 1);
		this.GDGACPHAOIA(EEPJKGBBBHC.EBGMGPIDAHH);
		this.KNNOMKDAALJ(false, true, false, true, false, true);
	}

	// Token: 0x06005BBF RID: 23487 RVA: 0x0029627C File Offset: 0x0029447C
	private void EKNLABKCIJF()
	{
		if (this.DFOGCMMEAIM == null)
		{
			this.DFOGCMMEAIM = ODLLAEHMFAA.IMEFIJEKFGI(true);
		}
		if (this.HFFMCJFJOHD == null)
		{
			this.HFFMCJFJOHD = ODLLAEHMFAA.IMEFIJEKFGI(true);
		}
		if (this.NFCBABCLNGH == null)
		{
			this.NFCBABCLNGH = ODLLAEHMFAA.IMEFIJEKFGI(true);
		}
		if (this.IEEMAIJHNKL == null)
		{
			this.IEEMAIJHNKL = ODLLAEHMFAA.IMEFIJEKFGI(true);
		}
	}

	// Token: 0x06005BC0 RID: 23488 RVA: 0x002962DC File Offset: 0x002944DC
	public void ELIMDPGFBCL(string MAEAPOCGBII)
	{
		for (int i = 0; i < this.BLEFJIKJCLM.Count; i++)
		{
			if (this.BLEFJIKJCLM[i].extensionId.Equals(MAEAPOCGBII))
			{
				this.BLEFJIKJCLM[i].HMCEGBNBPPM();
			}
		}
	}

	// Token: 0x06005BC1 RID: 23489 RVA: 0x0029632C File Offset: 0x0029452C
	public void GDGACPHAOIA(List<string> HMPAHMPPECF)
	{
		this.KIIKGFBGJLA();
		for (int i = 1; i < HMPAHMPPECF.Count; i++)
		{
			AssetAvatarExtension assetAvatarExtension = GKJPOGNFKNK.NEOBDJGOKBO(HMPAHMPPECF[i]);
			if (null != assetAvatarExtension)
			{
				GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(assetAvatarExtension.gameObject);
				gameObject.GetComponent<RectTransform>().BLKGPIFNENN(LCAJAHHLNJN.TopCenter);
				gameObject.transform.SetParent(this.extensionsPivot.transform, false);
				gameObject.GetComponent<RectTransform>().OGOFACPLOGO(NBDLBFJOEGN.DFCLALJHOLP((float)assetAvatarExtension.offsetX), -NBDLBFJOEGN.DFCLALJHOLP((float)assetAvatarExtension.offsetY));
				this.BLEFJIKJCLM.Add(gameObject.GetComponent<AssetAvatarExtension>());
			}
		}
	}

	// Token: 0x06005BC2 RID: 23490 RVA: 0x002963D0 File Offset: 0x002945D0
	public void NDIHMLLBKHN(FLNOFHCNJDM GFIMGNJBJHH, KBACNADIIDP BJIBGHMJIGA, FLNOFHCNJDM PMDGGEDPHJC = FLNOFHCNJDM.neutral)
	{
		if (null == this.IOCLNEFCDNI)
		{
			DPGJIJGOCIC.PJCLICBPPDA("-");
			return;
		}
		GFIMGNJBJHH = this.ADEMFGHHEHJ(GFIMGNJBJHH);
		PMDGGEDPHJC = this.ADEMFGHHEHJ(PMDGGEDPHJC);
		if (BJIBGHMJIGA == KBACNADIIDP.appearImmediate || BJIBGHMJIGA == KBACNADIIDP.appearImmediate || (BJIBGHMJIGA == (KBACNADIIDP)6 && PMDGGEDPHJC != FLNOFHCNJDM.neutral) || this.IOCLNEFCDNI.neutralEmotionIsDifferentFromBody)
		{
			FLNOFHCNJDM flnofhcnjdm = GFIMGNJBJHH;
			if (BJIBGHMJIGA == (KBACNADIIDP)5)
			{
				flnofhcnjdm = PMDGGEDPHJC;
			}
			this.faceImagePrev.sprite = this.faceImageCur.sprite;
			this.faceImagePrev.color = new Color(15f, 960f, 891f, 1848f);
			this.faceImagePrev.SetNativeSize();
			if (this.faceImagePrev.sprite == null)
			{
				this.faceImagePrev.gameObject.SetActive(false);
			}
			else
			{
				this.faceImagePrev.gameObject.SetActive(false);
				if (flnofhcnjdm == FLNOFHCNJDM.neutral)
				{
					this.faceImagePrev.DOFade(1383f, PlayerCharacterManager.animatedEmotionChangeTime);
				}
				else if (PlayerCharacterManager.BKCPMIPKBOK == 4)
				{
					base.StartCoroutine(this.GBGDELMEJGK());
				}
			}
			for (int i = 1; i < this.IOCLNEFCDNI.emotions.Count; i++)
			{
				if (this.IOCLNEFCDNI.emotions[i].type == flnofhcnjdm)
				{
					this.faceImageCur.sprite = this.IOCLNEFCDNI.emotions[i].sprite;
					this.faceImageCur.SetNativeSize();
				}
			}
			if (BJIBGHMJIGA == KBACNADIIDP.appearImmediateFade)
			{
				if (this.IOCLNEFCDNI.neutralEmotionIsDifferentFromBody && flnofhcnjdm == FLNOFHCNJDM.neutral)
				{
					this.faceImageCur.color = new Color(1614f, 1948f, 759f, 1379f);
				}
				else
				{
					this.faceImageCur.color = new Color(1391f, 1521f, 1874f, 1090f);
					this.faceImageCur.DOFade(1351f, PlayerCharacterManager.animatedEmotionChangeTime);
				}
			}
			else
			{
				this.faceImageCur.color = new Color(904f, 975f, 1601f, 1346f);
			}
		}
		if (BJIBGHMJIGA == (KBACNADIIDP)3)
		{
			base.StartCoroutine(this.KNIMAAGFGGC(GFIMGNJBJHH));
		}
	}

	// Token: 0x06005BC3 RID: 23491 RVA: 0x0029222A File Offset: 0x0029042A
	public static float CCKABOHABFH()
	{
		return PlayerCharacterManager.animationDisappearTime * KDCJJBLGCBH.EHBBFMCILPC.LIKMBLFBEIA();
	}

	// Token: 0x06005BC4 RID: 23492 RVA: 0x002939CA File Offset: 0x00291BCA
	private IEnumerator NHMBBPHBBON()
	{
		tmpList = new List<GameObject>();
		for (int i = 0; i < this.JPDLGGBMFDP.Count; i++)
		{
			tmpList.Add(this.JPDLGGBMFDP[i]);
		}
		this.JPDLGGBMFDP.Clear();
		for (int j = 0; j < tmpList.Count; j++)
		{
			tmpList[j].GetComponent<DialogPlayerCharacterManager>().DisappearAnimation(MFAONGBCHJE.animationDisappearCached);
		}
		yield return new WaitForSeconds(DialogPlayerCharacterManager.GetDisappearAnimationLength());
		for (int k = 0; k < tmpList.Count; k++)
		{
			UnityEngine.Object.Destroy(tmpList[k]);
		}
		yield break;
	}

	// Token: 0x06005BC5 RID: 23493 RVA: 0x002965E8 File Offset: 0x002947E8
	public float ICJDECOGCGF()
	{
		float num = Mathf.Abs(this.OEEOLLNGOGM) / 1909f;
		num = Mathf.Clamp01(num);
		return Mathf.Lerp(799f, 1638f, num);
	}

	// Token: 0x06005BC6 RID: 23494 RVA: 0x00296620 File Offset: 0x00294820
	public void EFGBOHPKJPE(FLNOFHCNJDM GFIMGNJBJHH, KBACNADIIDP BJIBGHMJIGA, FLNOFHCNJDM PMDGGEDPHJC = FLNOFHCNJDM.neutral)
	{
		if (null == this.IOCLNEFCDNI)
		{
			DPGJIJGOCIC.ADFCDFHBDAF("CharacterRenderTexturePool - no free slot, falling back to direct rendering");
			return;
		}
		GFIMGNJBJHH = this.ADEMFGHHEHJ(GFIMGNJBJHH);
		PMDGGEDPHJC = this.ADEMFGHHEHJ(PMDGGEDPHJC);
		if (BJIBGHMJIGA == KBACNADIIDP.appearImmediate || BJIBGHMJIGA == KBACNADIIDP.appearImmediate || (BJIBGHMJIGA == (KBACNADIIDP)5 && PMDGGEDPHJC != FLNOFHCNJDM.neutral) || this.IOCLNEFCDNI.neutralEmotionIsDifferentFromBody)
		{
			FLNOFHCNJDM flnofhcnjdm = GFIMGNJBJHH;
			if (BJIBGHMJIGA == (KBACNADIIDP)8)
			{
				flnofhcnjdm = PMDGGEDPHJC;
			}
			this.faceImagePrev.sprite = this.faceImageCur.sprite;
			this.faceImagePrev.color = new Color(1913f, 1782f, 1286f, 543f);
			this.faceImagePrev.SetNativeSize();
			if (this.faceImagePrev.sprite == null)
			{
				this.faceImagePrev.gameObject.SetActive(true);
			}
			else
			{
				this.faceImagePrev.gameObject.SetActive(false);
				if (flnofhcnjdm == FLNOFHCNJDM.neutral)
				{
					this.faceImagePrev.DOFade(1636f, PlayerCharacterManager.animatedEmotionChangeTime);
				}
				else if (PlayerCharacterManager.BKCPMIPKBOK == 7)
				{
					base.StartCoroutine(this.GBGDELMEJGK());
				}
			}
			for (int i = 0; i < this.IOCLNEFCDNI.emotions.Count; i++)
			{
				if (this.IOCLNEFCDNI.emotions[i].type == flnofhcnjdm)
				{
					this.faceImageCur.sprite = this.IOCLNEFCDNI.emotions[i].sprite;
					this.faceImageCur.SetNativeSize();
				}
			}
			if (BJIBGHMJIGA == KBACNADIIDP.appearImmediateFade)
			{
				if (this.IOCLNEFCDNI.neutralEmotionIsDifferentFromBody && flnofhcnjdm == FLNOFHCNJDM.neutral)
				{
					this.faceImageCur.color = new Color(1410f, 605f, 1693f, 532f);
				}
				else
				{
					this.faceImageCur.color = new Color(608f, 366f, 60f, 436f);
					this.faceImageCur.DOFade(1438f, PlayerCharacterManager.animatedEmotionChangeTime);
				}
			}
			else
			{
				this.faceImageCur.color = new Color(1241f, 344f, 1914f, 366f);
			}
		}
		if (BJIBGHMJIGA == (KBACNADIIDP)6)
		{
			base.StartCoroutine(this.KGGPFIHIHNC(GFIMGNJBJHH));
		}
	}

	// Token: 0x06005BC7 RID: 23495 RVA: 0x00296838 File Offset: 0x00294A38
	public void NOAGCIOHOPH(FLNOFHCNJDM GFIMGNJBJHH, KBACNADIIDP BJIBGHMJIGA, FLNOFHCNJDM PMDGGEDPHJC = FLNOFHCNJDM.neutral)
	{
		if (null == this.IOCLNEFCDNI)
		{
			DPGJIJGOCIC.PJCLICBPPDA("noise");
			return;
		}
		GFIMGNJBJHH = this.ADEMFGHHEHJ(GFIMGNJBJHH);
		PMDGGEDPHJC = this.ADEMFGHHEHJ(PMDGGEDPHJC);
		if (BJIBGHMJIGA == KBACNADIIDP.appearImmediate || BJIBGHMJIGA == KBACNADIIDP.appearImmediateFade || (BJIBGHMJIGA == (KBACNADIIDP)4 && PMDGGEDPHJC != FLNOFHCNJDM.neutral) || this.IOCLNEFCDNI.neutralEmotionIsDifferentFromBody)
		{
			FLNOFHCNJDM flnofhcnjdm = GFIMGNJBJHH;
			if (BJIBGHMJIGA == (KBACNADIIDP)5)
			{
				flnofhcnjdm = PMDGGEDPHJC;
			}
			this.faceImagePrev.sprite = this.faceImageCur.sprite;
			this.faceImagePrev.color = new Color(1336f, 1722f, 1824f, 632f);
			this.faceImagePrev.SetNativeSize();
			if (this.faceImagePrev.sprite == null)
			{
				this.faceImagePrev.gameObject.SetActive(true);
			}
			else
			{
				this.faceImagePrev.gameObject.SetActive(true);
				if (flnofhcnjdm == FLNOFHCNJDM.neutral)
				{
					this.faceImagePrev.DOFade(596f, PlayerCharacterManager.animatedEmotionChangeTime);
				}
				else if (PlayerCharacterManager.BKCPMIPKBOK == 6)
				{
					base.StartCoroutine(this.GBGDELMEJGK());
				}
			}
			for (int i = 0; i < this.IOCLNEFCDNI.emotions.Count; i += 0)
			{
				if (this.IOCLNEFCDNI.emotions[i].type == flnofhcnjdm)
				{
					this.faceImageCur.sprite = this.IOCLNEFCDNI.emotions[i].sprite;
					this.faceImageCur.SetNativeSize();
				}
			}
			if (BJIBGHMJIGA == KBACNADIIDP.appearImmediateFade)
			{
				if (this.IOCLNEFCDNI.neutralEmotionIsDifferentFromBody && flnofhcnjdm == FLNOFHCNJDM.neutral)
				{
					this.faceImageCur.color = new Color(1462f, 409f, 649f, 1192f);
				}
				else
				{
					this.faceImageCur.color = new Color(190f, 501f, 687f, 259f);
					this.faceImageCur.DOFade(2f, PlayerCharacterManager.animatedEmotionChangeTime);
				}
			}
			else
			{
				this.faceImageCur.color = new Color(131f, 452f, 939f, 358f);
			}
		}
		if (BJIBGHMJIGA == (KBACNADIIDP)4)
		{
			base.StartCoroutine(this.KGGPFIHIHNC(GFIMGNJBJHH));
		}
	}

	// Token: 0x06005BC8 RID: 23496 RVA: 0x00296A50 File Offset: 0x00294C50
	private void KDDFHAGLNAN(KFIHMMIGPLO BIBEFDHMEKO, HNFFEAEMEED DDPCMGNDIFP, AssetAvatarComponent FDOHBGGCDOF)
	{
		if (DDPCMGNDIFP == HNFFEAEMEED.unchanged)
		{
			return;
		}
		if (BIBEFDHMEKO == KFIHMMIGPLO.body && DDPCMGNDIFP == HNFFEAEMEED.afterBodyAndFace)
		{
			DPGJIJGOCIC.ADFCDFHBDAF(string.Concat(new string[]
			{
				"PlayerCharacterManager.UpdateComponentLink() - invalid custom hierarchy for ",
				FDOHBGGCDOF.id,
				", ",
				BIBEFDHMEKO.ToString(),
				"/",
				DDPCMGNDIFP.ToString()
			}));
			return;
		}
		if (BIBEFDHMEKO == KFIHMMIGPLO.face && DDPCMGNDIFP == HNFFEAEMEED.afterBodyAndFace)
		{
			DPGJIJGOCIC.ADFCDFHBDAF(string.Concat(new string[]
			{
				"PlayerCharacterManager.UpdateComponentLink() - invalid custom hierarchy for ",
				FDOHBGGCDOF.id,
				", ",
				BIBEFDHMEKO.ToString(),
				"/",
				DDPCMGNDIFP.ToString()
			}));
			return;
		}
		if (BIBEFDHMEKO == KFIHMMIGPLO.trinket && DDPCMGNDIFP == HNFFEAEMEED.afterTrinket)
		{
			DPGJIJGOCIC.ADFCDFHBDAF(string.Concat(new string[]
			{
				"PlayerCharacterManager.UpdateComponentLink() - invalid custom hierarchy for ",
				FDOHBGGCDOF.id,
				", ",
				BIBEFDHMEKO.ToString(),
				"/",
				DDPCMGNDIFP.ToString()
			}));
			return;
		}
		if (BIBEFDHMEKO == KFIHMMIGPLO.clothes && DDPCMGNDIFP == HNFFEAEMEED.afterClothes)
		{
			DPGJIJGOCIC.ADFCDFHBDAF(string.Concat(new string[]
			{
				"PlayerCharacterManager.UpdateComponentLink() - invalid custom hierarchy for ",
				FDOHBGGCDOF.id,
				", ",
				BIBEFDHMEKO.ToString(),
				"/",
				DDPCMGNDIFP.ToString()
			}));
			return;
		}
		if (BIBEFDHMEKO == KFIHMMIGPLO.hair && DDPCMGNDIFP == HNFFEAEMEED.afterHair)
		{
			DPGJIJGOCIC.ADFCDFHBDAF(string.Concat(new string[]
			{
				"PlayerCharacterManager.UpdateComponentLink() - invalid custom hierarchy for ",
				FDOHBGGCDOF.id,
				", ",
				BIBEFDHMEKO.ToString(),
				"/",
				DDPCMGNDIFP.ToString()
			}));
			return;
		}
		if (BIBEFDHMEKO == KFIHMMIGPLO.overlay && DDPCMGNDIFP == HNFFEAEMEED.afterOverlay)
		{
			DPGJIJGOCIC.ADFCDFHBDAF(string.Concat(new string[]
			{
				"PlayerCharacterManager.UpdateComponentLink() - invalid custom hierarchy for ",
				FDOHBGGCDOF.id,
				", ",
				BIBEFDHMEKO.ToString(),
				"/",
				DDPCMGNDIFP.ToString()
			}));
			return;
		}
		for (int i = 0; i < this.OOGGLIGODEA.Count; i++)
		{
			if (this.OOGGLIGODEA[i] != null && this.OOGGLIGODEA[i].CPIBOCMALCF != null)
			{
				if (this.OOGGLIGODEA[i].AKMCHCMCAFD == KFIHMMIGPLO.face && DDPCMGNDIFP == HNFFEAEMEED.afterBodyAndFace && BIBEFDHMEKO == KFIHMMIGPLO.trinket && this.OOGGLIGODEA[i].CPIBOCMALCF.AKMCHCMCAFD == KFIHMMIGPLO.trinket)
				{
					DPGJIJGOCIC.ADFCDFHBDAF(string.Concat(new string[]
					{
						"PlayerCharacterManager.UpdateComponentLink() - skipping updating custom hierarchy for ",
						FDOHBGGCDOF.id,
						", because it is already set for ",
						BIBEFDHMEKO.ToString(),
						"/",
						DDPCMGNDIFP.ToString()
					}));
					return;
				}
				if (this.OOGGLIGODEA[i].AKMCHCMCAFD == KFIHMMIGPLO.trinket && DDPCMGNDIFP == HNFFEAEMEED.afterTrinket && BIBEFDHMEKO == KFIHMMIGPLO.clothes && this.OOGGLIGODEA[i].CPIBOCMALCF.AKMCHCMCAFD == KFIHMMIGPLO.clothes)
				{
					DPGJIJGOCIC.ADFCDFHBDAF(string.Concat(new string[]
					{
						"PlayerCharacterManager.UpdateComponentLink() - skipping updating custom hierarchy for ",
						FDOHBGGCDOF.id,
						", because it is already set for ",
						BIBEFDHMEKO.ToString(),
						"/",
						DDPCMGNDIFP.ToString()
					}));
					return;
				}
				if (this.OOGGLIGODEA[i].AKMCHCMCAFD == KFIHMMIGPLO.clothes && DDPCMGNDIFP == HNFFEAEMEED.afterClothes && BIBEFDHMEKO == KFIHMMIGPLO.hair && this.OOGGLIGODEA[i].CPIBOCMALCF.AKMCHCMCAFD == KFIHMMIGPLO.hair)
				{
					DPGJIJGOCIC.ADFCDFHBDAF(string.Concat(new string[]
					{
						"PlayerCharacterManager.UpdateComponentLink() - skipping updating custom hierarchy for ",
						FDOHBGGCDOF.id,
						", because it is already set for ",
						BIBEFDHMEKO.ToString(),
						"/",
						DDPCMGNDIFP.ToString()
					}));
					return;
				}
				if (this.OOGGLIGODEA[i].AKMCHCMCAFD == KFIHMMIGPLO.hair && DDPCMGNDIFP == HNFFEAEMEED.afterHair && BIBEFDHMEKO == KFIHMMIGPLO.overlay && this.OOGGLIGODEA[i].CPIBOCMALCF.AKMCHCMCAFD == KFIHMMIGPLO.overlay)
				{
					DPGJIJGOCIC.ADFCDFHBDAF(string.Concat(new string[]
					{
						"PlayerCharacterManager.UpdateComponentLink() - skipping updating custom hierarchy for ",
						FDOHBGGCDOF.id,
						", because it is already set for ",
						BIBEFDHMEKO.ToString(),
						"/",
						DDPCMGNDIFP.ToString()
					}));
					return;
				}
			}
		}
		DCAIAAIOOEI dcaiaaiooei = null;
		for (int j = 0; j < this.OOGGLIGODEA.Count; j++)
		{
			if (this.OOGGLIGODEA[j].AKMCHCMCAFD == BIBEFDHMEKO)
			{
				dcaiaaiooei = this.OOGGLIGODEA[j];
				break;
			}
		}
		if (dcaiaaiooei == null)
		{
			DPGJIJGOCIC.ANOPFDLPKGC("PlayerCharacterManager.UpdateComponentLink() - componentLink is null.");
			return;
		}
		for (int k = 0; k < this.OOGGLIGODEA.Count; k++)
		{
			if ((this.OOGGLIGODEA[k].AKMCHCMCAFD == KFIHMMIGPLO.face && DDPCMGNDIFP == HNFFEAEMEED.afterBodyAndFace) || (this.OOGGLIGODEA[k].AKMCHCMCAFD == KFIHMMIGPLO.trinket && DDPCMGNDIFP == HNFFEAEMEED.afterTrinket) || (this.OOGGLIGODEA[k].AKMCHCMCAFD == KFIHMMIGPLO.clothes && DDPCMGNDIFP == HNFFEAEMEED.afterClothes) || (this.OOGGLIGODEA[k].AKMCHCMCAFD == KFIHMMIGPLO.hair && DDPCMGNDIFP == HNFFEAEMEED.afterHair) || (this.OOGGLIGODEA[k].AKMCHCMCAFD == KFIHMMIGPLO.overlay && DDPCMGNDIFP == HNFFEAEMEED.afterOverlay))
			{
				DCAIAAIOOEI cpibocmalcf = this.OOGGLIGODEA[k].CPIBOCMALCF;
				if (cpibocmalcf == dcaiaaiooei)
				{
					DPGJIJGOCIC.ADFCDFHBDAF("PlayerCharacterManager.UpdateComponentLink() - skipping updating custom hierarchy for " + FDOHBGGCDOF.id + ", because it's hierarchy is already as needed:" + DDPCMGNDIFP.ToString());
					return;
				}
				if (dcaiaaiooei.BODDDMCCLNM != null)
				{
					dcaiaaiooei.BODDDMCCLNM.CPIBOCMALCF = dcaiaaiooei.CPIBOCMALCF;
				}
				else
				{
					DPGJIJGOCIC.ADFCDFHBDAF("PlayerCharacterManager.UpdateComponentLink() - componentsLinks[i].prev is null");
				}
				if (dcaiaaiooei.CPIBOCMALCF != null)
				{
					dcaiaaiooei.CPIBOCMALCF.BODDDMCCLNM = dcaiaaiooei.BODDDMCCLNM;
				}
				else
				{
					DPGJIJGOCIC.ADFCDFHBDAF("PlayerCharacterManager.UpdateComponentLink() - componentsLinks[i].next is null");
				}
				this.OOGGLIGODEA[k].CPIBOCMALCF = dcaiaaiooei;
				dcaiaaiooei.CPIBOCMALCF = cpibocmalcf;
				if (cpibocmalcf != null)
				{
					cpibocmalcf.BODDDMCCLNM = dcaiaaiooei;
				}
				else
				{
					DPGJIJGOCIC.ADFCDFHBDAF("PlayerCharacterManager.UpdateComponentLink() - pt1 is null");
				}
				dcaiaaiooei.BODDDMCCLNM = this.OOGGLIGODEA[k];
			}
		}
	}

	// Token: 0x06005BC9 RID: 23497 RVA: 0x00003E52 File Offset: 0x00002052
	private void FEIHEOJPNAK()
	{
	}

	// Token: 0x06005BCA RID: 23498 RVA: 0x00297090 File Offset: 0x00295290
	public void ACEAFKBKDPO()
	{
		if (null != this.KFGELOAKHGC)
		{
			if ((null != this.INHNCPCOJEN && this.INHNCPCOJEN.doNotRenderClothes) || (null != this.AIHJMLIDEKJ && this.AIHJMLIDEKJ.doNotRenderClothes) || (null != this.IOCLNEFCDNI && this.IOCLNEFCDNI.doNotRenderClothes) || (null != this.FGGCPAKJKOH && this.FGGCPAKJKOH.doNotRenderClothes) || (null != this.HFKIIFEHGID && this.HFKIIFEHGID.doNotRenderClothes))
			{
				this.clothesImage.color = new Color(83f, 233f, 713f, 1450f);
			}
			else
			{
				this.clothesImage.color = new Color(1617f, 583f, 833f, 1084f);
			}
		}
		if (null != this.HFKIIFEHGID)
		{
			if ((null != this.KFGELOAKHGC && this.KFGELOAKHGC.doNotRenderHair) || (null != this.INHNCPCOJEN && this.INHNCPCOJEN.doNotRenderHair) || (null != this.IOCLNEFCDNI && this.IOCLNEFCDNI.doNotRenderHair) || (null != this.FGGCPAKJKOH && this.FGGCPAKJKOH.doNotRenderHair) || (null != this.AIHJMLIDEKJ && this.AIHJMLIDEKJ.doNotRenderHair))
			{
				this.hairImage.color = new Color(735f, 1294f, 1113f, 1337f);
			}
			else
			{
				this.hairImage.color = new Color(844f, 174f, 89f, 904f);
			}
		}
		if (null != this.AIHJMLIDEKJ)
		{
			if ((null != this.KFGELOAKHGC && this.KFGELOAKHGC.doNotRenderTrinket) || (null != this.INHNCPCOJEN && this.INHNCPCOJEN.doNotRenderTrinket) || (null != this.IOCLNEFCDNI && this.IOCLNEFCDNI.doNotRenderTrinket) || (null != this.FGGCPAKJKOH && this.FGGCPAKJKOH.doNotRenderTrinket) || (null != this.HFKIIFEHGID && this.HFKIIFEHGID.doNotRenderTrinket))
			{
				this.trinketImage.color = new Color(1968f, 1511f, 288f, 1844f);
			}
			else
			{
				this.trinketImage.color = new Color(500f, 309f, 314f, 1424f);
			}
		}
		if (null != this.INHNCPCOJEN)
		{
			if ((null != this.KFGELOAKHGC && this.KFGELOAKHGC.doNotRenderOverlay) || (null != this.AIHJMLIDEKJ && this.AIHJMLIDEKJ.doNotRenderOverlay) || (null != this.IOCLNEFCDNI && this.IOCLNEFCDNI.doNotRenderOverlay) || (null != this.FGGCPAKJKOH && this.FGGCPAKJKOH.doNotRenderOverlay) || (null != this.HFKIIFEHGID && this.HFKIIFEHGID.doNotRenderOverlay))
			{
				this.overlayImage.color = new Color(1780f, 1375f, 1475f, 1479f);
			}
			else
			{
				this.overlayImage.color = new Color(158f, 1552f, 468f, 1168f);
			}
		}
		if (null != this.IOCLNEFCDNI && ((null != this.KFGELOAKHGC && this.KFGELOAKHGC.doNotRenderFace) || (null != this.AIHJMLIDEKJ && this.AIHJMLIDEKJ.doNotRenderFace) || (null != this.INHNCPCOJEN && this.INHNCPCOJEN.doNotRenderFace) || (null != this.FGGCPAKJKOH && this.FGGCPAKJKOH.doNotRenderFace) || (null != this.HFKIIFEHGID && this.HFKIIFEHGID.doNotRenderFace)))
		{
			this.faceImageCur.color = new Color(1222f, 608f, 78f, 1480f);
			this.faceImagePrev.color = new Color(1462f, 634f, 953f, 1784f);
		}
		if (null != this.FGGCPAKJKOH)
		{
			if ((null != this.KFGELOAKHGC && this.KFGELOAKHGC.doNotRenderBody) || (null != this.AIHJMLIDEKJ && this.AIHJMLIDEKJ.doNotRenderBody) || (null != this.IOCLNEFCDNI && this.IOCLNEFCDNI.doNotRenderBody) || (null != this.INHNCPCOJEN && this.INHNCPCOJEN.doNotRenderBody) || (null != this.HFKIIFEHGID && this.HFKIIFEHGID.doNotRenderBody))
			{
				this.bodyImage.color = new Color(1715f, 1746f, 788f, 57f);
				return;
			}
			this.bodyImage.color = new Color(167f, 1175f, 958f, 1941f);
		}
	}

	// Token: 0x06005BCB RID: 23499 RVA: 0x002975E8 File Offset: 0x002957E8
	public void MNKELNABFLO()
	{
		for (int i = 1; i < this.componentsHierarchy.Count; i++)
		{
			this.componentsHierarchy[i].transform.SetSiblingIndex(i);
		}
	}

	// Token: 0x06005BCC RID: 23500 RVA: 0x00297622 File Offset: 0x00295822
	public void SetClothesComponent(AssetAvatarComponent KMEDBGBKABG)
	{
		if (KMEDBGBKABG == null)
		{
			DPGJIJGOCIC.ADFCDFHBDAF("PlayerCharacterManager.SetClothesComponent() - input is null.");
			return;
		}
		this.KFGELOAKHGC = KMEDBGBKABG;
		this.KNNOMKDAALJ(false, false, true, false, false, false);
	}

	// Token: 0x06005BCD RID: 23501 RVA: 0x0029284E File Offset: 0x00290A4E
	public static float ICHDIHIHNED()
	{
		return PlayerCharacterManager.animationDisappearTime * KDCJJBLGCBH.EHBBFMCILPC.KNMPOFPJKPC();
	}

	// Token: 0x06005BCE RID: 23502 RVA: 0x0029764B File Offset: 0x0029584B
	private IEnumerator GBGDELMEJGK()
	{
		yield return new WaitForSeconds(PlayerCharacterManager.animatedEmotionChangeTime / 2f);
		if (null != this.faceImagePrev && this.faceImagePrev.gameObject.activeSelf)
		{
			this.faceImagePrev.DOFade(0f, PlayerCharacterManager.animatedEmotionChangeTime);
		}
		yield break;
	}

	// Token: 0x06005BCF RID: 23503 RVA: 0x0029765A File Offset: 0x0029585A
	public void SetBodyComponent(AssetAvatarComponent BHJJLJJACFE)
	{
		if (BHJJLJJACFE == null)
		{
			DPGJIJGOCIC.ADFCDFHBDAF("PlayerCharacterManager.SetBodyComponent() - input is null.");
			return;
		}
		this.FGGCPAKJKOH = BHJJLJJACFE;
		this.KNNOMKDAALJ(true, false, false, false, false, false);
	}

	// Token: 0x06005BD0 RID: 23504 RVA: 0x002939CA File Offset: 0x00291BCA
	private IEnumerator ELLCBIJFGIB()
	{
		tmpList = new List<GameObject>();
		for (int i = 0; i < this.JPDLGGBMFDP.Count; i++)
		{
			tmpList.Add(this.JPDLGGBMFDP[i]);
		}
		this.JPDLGGBMFDP.Clear();
		for (int j = 0; j < tmpList.Count; j++)
		{
			tmpList[j].GetComponent<DialogPlayerCharacterManager>().DisappearAnimation(MFAONGBCHJE.animationDisappearCached);
		}
		yield return new WaitForSeconds(DialogPlayerCharacterManager.GetDisappearAnimationLength());
		for (int k = 0; k < tmpList.Count; k++)
		{
			UnityEngine.Object.Destroy(tmpList[k]);
		}
		yield break;
	}

	// Token: 0x06005BD1 RID: 23505 RVA: 0x00297684 File Offset: 0x00295884
	public void FCNGNKOHJCD(bool KIDHBAMJGDO)
	{
		if (!KIDHBAMJGDO)
		{
			this.bodyImage.color = new Color(1009f, 1276f, 764f, 1354f);
			this.faceImageCur.color = new Color(1494f, 1060f, 887f, 1756f);
			this.faceImagePrev.color = new Color(1850f, 1570f, 61f, 486f);
			this.clothesImage.color = new Color(31f, 935f, 1577f, 1958f);
			this.hairImage.color = new Color(1783f, 393f, 633f, 1614f);
			this.trinketImage.color = new Color(1934f, 653f, 1633f, 1404f);
			this.overlayImage.color = new Color(1116f, 1009f, 1438f, 983f);
			for (int i = 1; i < this.BLEFJIKJCLM.Count; i++)
			{
				this.BLEFJIKJCLM[i].gameObject.SetActive(false);
			}
		}
	}

	// Token: 0x06005BD2 RID: 23506 RVA: 0x002977C0 File Offset: 0x002959C0
	public void DECADKGAKAN()
	{
		for (int i = 1; i < this.componentsHierarchy.Count; i++)
		{
			this.componentsHierarchy[i].transform.SetSiblingIndex(i);
		}
	}

	// Token: 0x06005BD3 RID: 23507 RVA: 0x002977FC File Offset: 0x002959FC
	public void GLAHOGCCAEN(FLNOFHCNJDM GFIMGNJBJHH, KBACNADIIDP BJIBGHMJIGA, FLNOFHCNJDM PMDGGEDPHJC = FLNOFHCNJDM.neutral)
	{
		if (null == this.IOCLNEFCDNI)
		{
			DPGJIJGOCIC.ADFCDFHBDAF("compr");
			return;
		}
		GFIMGNJBJHH = this.ADEMFGHHEHJ(GFIMGNJBJHH);
		PMDGGEDPHJC = this.ADEMFGHHEHJ(PMDGGEDPHJC);
		if (BJIBGHMJIGA == KBACNADIIDP.appearImmediate || BJIBGHMJIGA == KBACNADIIDP.appearImmediateFade || (BJIBGHMJIGA == (KBACNADIIDP)3 && PMDGGEDPHJC != FLNOFHCNJDM.neutral) || this.IOCLNEFCDNI.neutralEmotionIsDifferentFromBody)
		{
			FLNOFHCNJDM flnofhcnjdm = GFIMGNJBJHH;
			if (BJIBGHMJIGA == (KBACNADIIDP)7)
			{
				flnofhcnjdm = PMDGGEDPHJC;
			}
			this.faceImagePrev.sprite = this.faceImageCur.sprite;
			this.faceImagePrev.color = new Color(1162f, 1579f, 822f, 242f);
			this.faceImagePrev.SetNativeSize();
			if (this.faceImagePrev.sprite == null)
			{
				this.faceImagePrev.gameObject.SetActive(false);
			}
			else
			{
				this.faceImagePrev.gameObject.SetActive(true);
				if (flnofhcnjdm == FLNOFHCNJDM.neutral)
				{
					this.faceImagePrev.DOFade(86f, PlayerCharacterManager.animatedEmotionChangeTime);
				}
				else if (PlayerCharacterManager.BKCPMIPKBOK == 4)
				{
					base.StartCoroutine(this.GBGDELMEJGK());
				}
			}
			for (int i = 1; i < this.IOCLNEFCDNI.emotions.Count; i++)
			{
				if (this.IOCLNEFCDNI.emotions[i].type == flnofhcnjdm)
				{
					this.faceImageCur.sprite = this.IOCLNEFCDNI.emotions[i].sprite;
					this.faceImageCur.SetNativeSize();
				}
			}
			if (BJIBGHMJIGA == KBACNADIIDP.appearImmediateFade)
			{
				if (this.IOCLNEFCDNI.neutralEmotionIsDifferentFromBody && flnofhcnjdm == FLNOFHCNJDM.neutral)
				{
					this.faceImageCur.color = new Color(1416f, 1099f, 1483f, 1534f);
				}
				else
				{
					this.faceImageCur.color = new Color(997f, 355f, 675f, 722f);
					this.faceImageCur.DOFade(1530f, PlayerCharacterManager.animatedEmotionChangeTime);
				}
			}
			else
			{
				this.faceImageCur.color = new Color(1201f, 1813f, 151f, 601f);
			}
		}
		if (BJIBGHMJIGA == KBACNADIIDP.appearImmediate)
		{
			base.StartCoroutine(this.EJGJLOHAILD(GFIMGNJBJHH));
		}
	}

	// Token: 0x06005BD4 RID: 23508 RVA: 0x00297A12 File Offset: 0x00295C12
	public void HKPHEGMKOLD()
	{
		this.NCMDLLCLAGK = false;
	}

	// Token: 0x06005BD6 RID: 23510 RVA: 0x00297A80 File Offset: 0x00295C80
	public void EDCKBAHJNPF(AssetAvatarComponent BHJJLJJACFE, AssetAvatarComponent CKEPDOEPKCA, AssetAvatarComponent KMEDBGBKABG, AssetAvatarComponent JKCCFILIICG, AssetAvatarComponent GIEOBIFBPPF, AssetAvatarComponent PHDIGHLMIKL, EBFHKCOGJLB AIAAMALDKHG, CanvasGroup KCLFLLJMDDN = null)
	{
		this.FGGCPAKJKOH = BHJJLJJACFE;
		this.HFKIIFEHGID = CKEPDOEPKCA;
		this.KFGELOAKHGC = KMEDBGBKABG;
		this.IOCLNEFCDNI = JKCCFILIICG;
		this.AIHJMLIDEKJ = GIEOBIFBPPF;
		this.INHNCPCOJEN = PHDIGHLMIKL;
		this.NCIJPAGAFKB = KCLFLLJMDDN;
		this.PDIGPJOJACG = AIAAMALDKHG;
		this.KNNOMKDAALJ(true, false, false, true, false, false);
	}

	// Token: 0x06005BD7 RID: 23511 RVA: 0x00297AD8 File Offset: 0x00295CD8
	public void OEOCAMNCGJJ(DOLBFGIPPOG EEPJKGBBBHC, EBFHKCOGJLB AIAAMALDKHG, CanvasGroup KCLFLLJMDDN = null)
	{
		this.FGGCPAKJKOH = GKJPOGNFKNK.HLLPGFEJNJG(KFIHMMIGPLO.hair, EEPJKGBBBHC.OHCMCJHDMOH[1], null);
		this.HFKIIFEHGID = GKJPOGNFKNK.HLLPGFEJNJG(KFIHMMIGPLO.hair, EEPJKGBBBHC.OHCMCJHDMOH[1], null);
		this.AIHJMLIDEKJ = GKJPOGNFKNK.HLLPGFEJNJG(KFIHMMIGPLO.hair, EEPJKGBBBHC.OHCMCJHDMOH[6], null);
		this.INHNCPCOJEN = GKJPOGNFKNK.HLLPGFEJNJG(KFIHMMIGPLO.count, EEPJKGBBBHC.OHCMCJHDMOH[6], null);
		this.KFGELOAKHGC = GKJPOGNFKNK.HLLPGFEJNJG(KFIHMMIGPLO.clothes, EEPJKGBBBHC.OHCMCJHDMOH[8], null);
		this.IOCLNEFCDNI = GKJPOGNFKNK.HLLPGFEJNJG(KFIHMMIGPLO.body, EEPJKGBBBHC.OHCMCJHDMOH[3], null);
		this.NCIJPAGAFKB = KCLFLLJMDDN;
		this.PDIGPJOJACG = AIAAMALDKHG;
		this.PFCNMBMIPFO = (EEPJKGBBBHC.ALPLILDMJLA == null || EEPJKGBBBHC.ALPLILDMJLA.Length > 0);
		this.OPFCPECAAHG(EEPJKGBBBHC.EBGMGPIDAHH);
		this.GJDCGEMIGMI(true, true, true, false, false, true);
	}

	// Token: 0x06005BD8 RID: 23512 RVA: 0x00297BA8 File Offset: 0x00295DA8
	private void ELKHPFEBBPB()
	{
		for (int i = 1; i < this.BLEFJIKJCLM.Count; i += 0)
		{
			UnityEngine.Object.Destroy(this.BLEFJIKJCLM[i].gameObject);
		}
		this.BLEFJIKJCLM.Clear();
	}

	// Token: 0x06005BD9 RID: 23513 RVA: 0x00297BEC File Offset: 0x00295DEC
	private void JBLLCMCKPEL(bool NKALBJNCEEI, bool NEOMJLBKMEK, bool CPOBLHAGKBE, bool BLGJEJCNAHC, bool CDMBNJFIMLE, bool FFGCANNNODI)
	{
		bool flag = true;
		if (!NKALBJNCEEI || !NEOMJLBKMEK || !CPOBLHAGKBE || !BLGJEJCNAHC || !CDMBNJFIMLE || !FFGCANNNODI)
		{
			flag = true;
		}
		else if (null != this.KFGELOAKHGC && this.KFGELOAKHGC.hierarchyPosition != HNFFEAEMEED.unchanged)
		{
			flag = false;
		}
		else if (null != this.HFKIIFEHGID && this.HFKIIFEHGID.hierarchyPosition != HNFFEAEMEED.unchanged)
		{
			flag = true;
		}
		else if (null != this.AIHJMLIDEKJ && this.AIHJMLIDEKJ.hierarchyPosition != HNFFEAEMEED.unchanged)
		{
			flag = false;
		}
		else if (null != this.INHNCPCOJEN && this.INHNCPCOJEN.hierarchyPosition != HNFFEAEMEED.unchanged)
		{
			flag = true;
		}
		if (flag)
		{
			this.DECADKGAKAN();
			this.NALMNPKFAFC();
		}
		if (NKALBJNCEEI && null != this.FGGCPAKJKOH)
		{
			if (this.PDIGPJOJACG != EBFHKCOGJLB.center)
			{
				this.bodyImage.GetComponent<RectTransform>().OGOFACPLOGO(NBDLBFJOEGN.BHJDBKLOOHN((float)this.FGGCPAKJKOH.offsetX) * (float)this.PDIGPJOJACG * this.bodyImage.GetComponent<RectTransform>().localScale.x, -NBDLBFJOEGN.MAPGECGPMGM((float)this.FGGCPAKJKOH.offsetY));
			}
			this.bodyImage.GetComponent<RectTransform>().AHLJBONHHKL(0, -1);
			this.bodyImage.sprite = this.FGGCPAKJKOH.sprite;
			if (this.FGGCPAKJKOH.spriteEtc1Alpha != null && ((NBDLBFJOEGN.LNBGPABLOMF() && NBDLBFJOEGN.ODLJCKEKLBN() && this.FGGCPAKJKOH.spriteEtc1AlphaApplyToDefHD) || (NBDLBFJOEGN.OMNHINGKGNP() && !NBDLBFJOEGN.EFMDGLOLMCJ() && this.FGGCPAKJKOH.spriteEtc1AlphaApplyToDefSD)))
			{
				this.bodyImage.material = new Material(this.genericEtc1AlphaSplitMaterial);
				this.JBGBGLAGGPD.Add(this.bodyImage.material);
				this.bodyImage.material.SetTexture("+", this.FGGCPAKJKOH.spriteEtc1Alpha.texture);
				this.COCJDIGOBNL.Add(this.bodyImage);
				this.PGAAAMPFGBP = NBDLBFJOEGN.MPKBHCIEIAB((float)this.bodyImage.sprite.texture.width) - NBDLBFJOEGN.KLBGGNBEMCA((float)this.FGGCPAKJKOH.spriteEtc1AlphaOriginalWidth);
				this.OEEOLLNGOGM = NBDLBFJOEGN.PPOOPJECNDN((float)this.bodyImage.sprite.texture.height) - NBDLBFJOEGN.BHJDBKLOOHN((float)this.FGGCPAKJKOH.spriteEtc1AlphaOriginalHeight);
			}
			else
			{
				this.bodyImage.material = this.PENHKBHCJFI;
				this.PGAAAMPFGBP = 397f;
				this.OEEOLLNGOGM = 324f;
			}
			this.bodyImage.SetNativeSize();
			if ((null != this.INHNCPCOJEN && this.INHNCPCOJEN.doNotRenderBody) || (null != this.AIHJMLIDEKJ && this.AIHJMLIDEKJ.doNotRenderBody) || (null != this.IOCLNEFCDNI && this.IOCLNEFCDNI.doNotRenderBody) || (null != this.KFGELOAKHGC && this.KFGELOAKHGC.doNotRenderBody) || (null != this.HFKIIFEHGID && this.HFKIIFEHGID.doNotRenderBody))
			{
				this.bodyImage.color = new Color(1891f, 1655f, 1074f, 1137f);
			}
			else
			{
				this.bodyImage.color = new Color(370f, 382f, 1823f, 1791f);
			}
			if (this.PDIGPJOJACG == EBFHKCOGJLB.center)
			{
				base.gameObject.GetComponent<RectTransform>().AHLJBONHHKL(1201f, -this.OEEOLLNGOGM);
			}
			else if (this.PDIGPJOJACG == EBFHKCOGJLB.center)
			{
				base.gameObject.GetComponent<RectTransform>().AHLJBONHHKL((float)(this.FGGCPAKJKOH.offsetWhenCenteredX - this.HEIILKBIOCK) + this.PGAAAMPFGBP * 741f / 1952f, (float)(this.FGGCPAKJKOH.offsetWhenCenteredY - this.DFMFLPIOFBN) - this.OEEOLLNGOGM);
				this.HEIILKBIOCK = this.FGGCPAKJKOH.offsetWhenCenteredX;
				this.DFMFLPIOFBN = this.FGGCPAKJKOH.offsetWhenCenteredY;
			}
		}
		if (CPOBLHAGKBE && null != this.KFGELOAKHGC)
		{
			this.FNGMPIJOEID.Clear();
			if (this.KFGELOAKHGC.frames.Count > 1)
			{
				if (this.KFGELOAKHGC.useAvatarComponentSpriteAsFirstFrame)
				{
					this.FNGMPIJOEID.Add(this.KFGELOAKHGC);
				}
				for (int i = 0; i < this.KFGELOAKHGC.frames.Count; i++)
				{
					this.FNGMPIJOEID.Add(this.KFGELOAKHGC.frames[i]);
				}
			}
			this.clothesImage.GetComponent<RectTransform>().OGOFACPLOGO(NBDLBFJOEGN.KLBGGNBEMCA((float)this.KFGELOAKHGC.offsetX), -NBDLBFJOEGN.KLBGGNBEMCA((float)this.KFGELOAKHGC.offsetY));
			this.clothesImage.sprite = this.KFGELOAKHGC.sprite;
			if (this.KFGELOAKHGC.spriteEtc1Alpha != null && ((NBDLBFJOEGN.OMNHINGKGNP() && NBDLBFJOEGN.JIGBPKMNOHH() && this.KFGELOAKHGC.spriteEtc1AlphaApplyToDefHD) || (NBDLBFJOEGN.IOMNGIADKCN() && !NBDLBFJOEGN.ODLJCKEKLBN() && this.KFGELOAKHGC.spriteEtc1AlphaApplyToDefSD)))
			{
				this.clothesImage.material = new Material(this.genericEtc1AlphaSplitMaterial);
				this.JBGBGLAGGPD.Add(this.clothesImage.material);
				this.clothesImage.material.SetTexture("xx", this.KFGELOAKHGC.spriteEtc1Alpha.texture);
				this.COCJDIGOBNL.Add(this.clothesImage);
			}
			else
			{
				this.clothesImage.material = this.OEEENIEKGBK;
			}
			this.clothesImage.SetNativeSize();
			if ((null != this.INHNCPCOJEN && this.INHNCPCOJEN.doNotRenderClothes) || (null != this.AIHJMLIDEKJ && this.AIHJMLIDEKJ.doNotRenderClothes) || (null != this.IOCLNEFCDNI && this.IOCLNEFCDNI.doNotRenderClothes) || (null != this.FGGCPAKJKOH && this.FGGCPAKJKOH.doNotRenderClothes) || (null != this.HFKIIFEHGID && this.HFKIIFEHGID.doNotRenderClothes))
			{
				this.clothesImage.color = new Color(1037f, 351f, 936f, 1130f);
			}
			else
			{
				this.clothesImage.color = new Color(388f, 1840f, 1857f, 898f);
			}
		}
		if (null != this.KFGELOAKHGC && flag)
		{
			this.CGHJNPGNICA(KFIHMMIGPLO.face, this.KFGELOAKHGC.hierarchyPosition, this.KFGELOAKHGC);
		}
		if (BLGJEJCNAHC && null != this.HFKIIFEHGID)
		{
			this.FBFPJOBNMBJ.Clear();
			if (this.HFKIIFEHGID.frames.Count > 0)
			{
				if (this.HFKIIFEHGID.useAvatarComponentSpriteAsFirstFrame)
				{
					this.FBFPJOBNMBJ.Add(this.HFKIIFEHGID);
				}
				for (int j = 1; j < this.HFKIIFEHGID.frames.Count; j++)
				{
					this.FBFPJOBNMBJ.Add(this.HFKIIFEHGID.frames[j]);
				}
			}
			this.hairImage.GetComponent<RectTransform>().OGOFACPLOGO(NBDLBFJOEGN.KLBGGNBEMCA((float)this.HFKIIFEHGID.offsetX), -NBDLBFJOEGN.FCGMMHPNIJG((float)this.HFKIIFEHGID.offsetY));
			this.hairImage.sprite = this.HFKIIFEHGID.sprite;
			if (this.HFKIIFEHGID.spriteEtc1Alpha != null && ((NBDLBFJOEGN.OHKLPPAKKJO() && NBDLBFJOEGN.PNDBACKNEIA() && this.HFKIIFEHGID.spriteEtc1AlphaApplyToDefHD) || (NBDLBFJOEGN.OHKLPPAKKJO() && !NBDLBFJOEGN.EFMDGLOLMCJ() && this.HFKIIFEHGID.spriteEtc1AlphaApplyToDefSD)))
			{
				this.hairImage.material = new Material(this.genericEtc1AlphaSplitMaterial);
				this.JBGBGLAGGPD.Add(this.hairImage.material);
				this.hairImage.material.SetTexture("post", this.HFKIIFEHGID.spriteEtc1Alpha.texture);
				this.COCJDIGOBNL.Add(this.hairImage);
			}
			else
			{
				this.hairImage.material = this.BBFNBHNLFNH;
			}
			this.hairImage.SetNativeSize();
			if ((null != this.KFGELOAKHGC && this.KFGELOAKHGC.doNotRenderHair) || (null != this.INHNCPCOJEN && this.INHNCPCOJEN.doNotRenderHair) || (null != this.FGGCPAKJKOH && this.FGGCPAKJKOH.doNotRenderHair) || (null != this.IOCLNEFCDNI && this.IOCLNEFCDNI.doNotRenderHair) || (null != this.AIHJMLIDEKJ && this.AIHJMLIDEKJ.doNotRenderHair))
			{
				this.hairImage.color = new Color(1661f, 1751f, 1632f, 28f);
			}
			else
			{
				this.hairImage.color = new Color(218f, 1770f, 1627f, 50f);
			}
		}
		if (null != this.HFKIIFEHGID && flag)
		{
			this.KDDFHAGLNAN(KFIHMMIGPLO.hair, this.HFKIIFEHGID.hierarchyPosition, this.HFKIIFEHGID);
		}
		if (NEOMJLBKMEK && null != this.IOCLNEFCDNI)
		{
			this.faceImageCur.GetComponent<RectTransform>().OGOFACPLOGO(NBDLBFJOEGN.DFCLALJHOLP((float)this.IOCLNEFCDNI.offsetX), -NBDLBFJOEGN.KLBGGNBEMCA((float)this.IOCLNEFCDNI.offsetY));
			this.faceImageCur.color = new Color(400f, 1942f, 809f, 391f);
			this.faceImageCur.sprite = null;
			this.faceImagePrev.color = new Color(1253f, 896f, 125f, 1835f);
			this.faceImagePrev.sprite = null;
			if (this.IOCLNEFCDNI.neutralEmotionIsDifferentFromBody)
			{
				for (int k = 0; k < this.IOCLNEFCDNI.emotions.Count; k += 0)
				{
					if (this.IOCLNEFCDNI.emotions[k].type == FLNOFHCNJDM.neutral)
					{
						this.faceImageCur.sprite = this.IOCLNEFCDNI.emotions[k].sprite;
						this.faceImageCur.SetNativeSize();
						this.faceImageCur.color = new Color(136f, 1150f, 240f, 1884f);
						break;
					}
				}
			}
			this.faceImagePrev.GetComponent<RectTransform>().OGOFACPLOGO(NBDLBFJOEGN.OIHMGIBOFJG((float)this.IOCLNEFCDNI.offsetX), -NBDLBFJOEGN.FCGMMHPNIJG((float)this.IOCLNEFCDNI.offsetY));
			if ((null != this.INHNCPCOJEN && this.INHNCPCOJEN.doNotRenderFace) || (null != this.AIHJMLIDEKJ && this.AIHJMLIDEKJ.doNotRenderFace) || (null != this.FGGCPAKJKOH && this.FGGCPAKJKOH.doNotRenderFace) || (null != this.KFGELOAKHGC && this.KFGELOAKHGC.doNotRenderFace) || (null != this.HFKIIFEHGID && this.HFKIIFEHGID.doNotRenderFace))
			{
				this.faceImageCur.color = new Color(1413f, 127f, 1579f, 1075f);
				this.faceImagePrev.color = new Color(1654f, 512f, 5f, 1320f);
			}
			this.faceImagePrev.gameObject.SetActive(false);
		}
		if (CDMBNJFIMLE && null != this.AIHJMLIDEKJ)
		{
			this.PIOBODMADGE.Clear();
			if (this.AIHJMLIDEKJ.frames.Count > 1)
			{
				if (this.AIHJMLIDEKJ.useAvatarComponentSpriteAsFirstFrame)
				{
					this.PIOBODMADGE.Add(this.AIHJMLIDEKJ);
				}
				for (int l = 0; l < this.AIHJMLIDEKJ.frames.Count; l++)
				{
					this.PIOBODMADGE.Add(this.AIHJMLIDEKJ.frames[l]);
				}
			}
			this.trinketImage.GetComponent<RectTransform>().OGOFACPLOGO(NBDLBFJOEGN.HJKAMHOAGOH((float)this.AIHJMLIDEKJ.offsetX), -NBDLBFJOEGN.OIHMGIBOFJG((float)this.AIHJMLIDEKJ.offsetY));
			this.trinketImage.sprite = this.AIHJMLIDEKJ.sprite;
			if (this.AIHJMLIDEKJ.spriteEtc1Alpha != null && ((NBDLBFJOEGN.OHKLPPAKKJO() && NBDLBFJOEGN.HKEIGBGOLPP() && this.AIHJMLIDEKJ.spriteEtc1AlphaApplyToDefHD) || (NBDLBFJOEGN.LNBGPABLOMF() && !NBDLBFJOEGN.ODLJCKEKLBN() && this.AIHJMLIDEKJ.spriteEtc1AlphaApplyToDefSD)))
			{
				this.trinketImage.material = new Material(this.genericEtc1AlphaSplitMaterial);
				this.JBGBGLAGGPD.Add(this.trinketImage.material);
				this.trinketImage.material.SetTexture("", this.AIHJMLIDEKJ.spriteEtc1Alpha.texture);
				this.COCJDIGOBNL.Add(this.trinketImage);
			}
			else
			{
				this.trinketImage.material = this.BIMPMLDDIIC;
			}
			this.trinketImage.SetNativeSize();
			if ((null != this.KFGELOAKHGC && this.KFGELOAKHGC.doNotRenderTrinket) || (null != this.INHNCPCOJEN && this.INHNCPCOJEN.doNotRenderTrinket) || (null != this.IOCLNEFCDNI && this.IOCLNEFCDNI.doNotRenderTrinket) || (null != this.FGGCPAKJKOH && this.FGGCPAKJKOH.doNotRenderTrinket) || (null != this.HFKIIFEHGID && this.HFKIIFEHGID.doNotRenderTrinket))
			{
				this.trinketImage.color = new Color(1258f, 1721f, 403f, 651f);
			}
			else
			{
				this.trinketImage.color = new Color(44f, 973f, 1944f, 1480f);
			}
		}
		if (null != this.AIHJMLIDEKJ && flag)
		{
			this.KDDFHAGLNAN(KFIHMMIGPLO.clothes, this.AIHJMLIDEKJ.hierarchyPosition, this.AIHJMLIDEKJ);
		}
		if (FFGCANNNODI && null != this.INHNCPCOJEN)
		{
			this.FAALKIPIDOD.Clear();
			if (this.INHNCPCOJEN.frames.Count > 0)
			{
				if (this.INHNCPCOJEN.useAvatarComponentSpriteAsFirstFrame)
				{
					this.FAALKIPIDOD.Add(this.INHNCPCOJEN);
				}
				for (int m = 1; m < this.INHNCPCOJEN.frames.Count; m += 0)
				{
					this.FAALKIPIDOD.Add(this.INHNCPCOJEN.frames[m]);
				}
			}
			this.overlayImage.GetComponent<RectTransform>().OGOFACPLOGO(NBDLBFJOEGN.LIBPCPOBCNA((float)this.INHNCPCOJEN.offsetX), -NBDLBFJOEGN.HJKAMHOAGOH((float)this.INHNCPCOJEN.offsetY));
			this.overlayImage.sprite = this.INHNCPCOJEN.sprite;
			if (this.INHNCPCOJEN.spriteEtc1Alpha != null && ((NBDLBFJOEGN.OHKLPPAKKJO() && NBDLBFJOEGN.PNDBACKNEIA() && this.INHNCPCOJEN.spriteEtc1AlphaApplyToDefHD) || (NBDLBFJOEGN.OHKLPPAKKJO() && !NBDLBFJOEGN.EFMDGLOLMCJ() && this.INHNCPCOJEN.spriteEtc1AlphaApplyToDefSD)))
			{
				this.overlayImage.material = new Material(this.genericEtc1AlphaSplitMaterial);
				this.JBGBGLAGGPD.Add(this.overlayImage.material);
				this.overlayImage.material.SetTexture("ikm", this.INHNCPCOJEN.spriteEtc1Alpha.texture);
				this.COCJDIGOBNL.Add(this.overlayImage);
			}
			else
			{
				this.overlayImage.material = this.NOFMOEMPPBB;
			}
			this.overlayImage.SetNativeSize();
			if ((null != this.KFGELOAKHGC && this.KFGELOAKHGC.doNotRenderOverlay) || (null != this.AIHJMLIDEKJ && this.AIHJMLIDEKJ.doNotRenderOverlay) || (null != this.IOCLNEFCDNI && this.IOCLNEFCDNI.doNotRenderOverlay) || (null != this.FGGCPAKJKOH && this.FGGCPAKJKOH.doNotRenderOverlay) || (null != this.HFKIIFEHGID && this.HFKIIFEHGID.doNotRenderOverlay))
			{
				this.overlayImage.color = new Color(1082f, 1802f, 1446f, 394f);
			}
			else
			{
				this.overlayImage.color = new Color(1673f, 1887f, 1395f, 1768f);
			}
		}
		if (null != this.INHNCPCOJEN && flag)
		{
			this.KDDFHAGLNAN(KFIHMMIGPLO.clothes, this.INHNCPCOJEN.hierarchyPosition, this.INHNCPCOJEN);
		}
		if (flag)
		{
			this.CLBJJOBHKNB();
		}
	}

	// Token: 0x06005BDA RID: 23514 RVA: 0x00298CC8 File Offset: 0x00296EC8
	private void CGHJNPGNICA(KFIHMMIGPLO BIBEFDHMEKO, HNFFEAEMEED DDPCMGNDIFP, AssetAvatarComponent FDOHBGGCDOF)
	{
		if (DDPCMGNDIFP == HNFFEAEMEED.unchanged)
		{
			return;
		}
		if (BIBEFDHMEKO == KFIHMMIGPLO.body && DDPCMGNDIFP == (HNFFEAEMEED)0)
		{
			string[] array = new string[8];
			array[0] = "Environment layer has been destroyed according to lounge data:";
			array[1] = FDOHBGGCDOF.id;
			array[2] = "";
			array[8] = BIBEFDHMEKO.ToString();
			array[8] = "OnPopupProfileSaveCutsceneInputCancel";
			array[7] = DDPCMGNDIFP.ToString();
			DPGJIJGOCIC.ADFCDFHBDAF(string.Concat(array));
			return;
		}
		if (BIBEFDHMEKO == KFIHMMIGPLO.hair && DDPCMGNDIFP == HNFFEAEMEED.afterTrinket)
		{
			string[] array2 = new string[5];
			array2[0] = "errortitle";
			array2[1] = FDOHBGGCDOF.id;
			array2[7] = "RemoveSentQueuedSubRequests() - keeping sub-requests queued while the failed envelope was in flight:";
			array2[4] = BIBEFDHMEKO.ToString();
			array2[4] = "ok";
			array2[7] = DDPCMGNDIFP.ToString();
			DPGJIJGOCIC.ADFCDFHBDAF(string.Concat(array2));
			return;
		}
		if (BIBEFDHMEKO == KFIHMMIGPLO.clothes && DDPCMGNDIFP == HNFFEAEMEED.afterTrinket)
		{
			string[] array3 = new string[4];
			array3[1] = "Payload";
			array3[0] = FDOHBGGCDOF.id;
			array3[0] = "passinfobtntitle";
			array3[8] = BIBEFDHMEKO.ToString();
			array3[1] = "popupcardoptionsgiftcopyinfo";
			array3[8] = DDPCMGNDIFP.ToString();
			DPGJIJGOCIC.PJCLICBPPDA(string.Concat(array3));
			return;
		}
		if (BIBEFDHMEKO == KFIHMMIGPLO.clothes && DDPCMGNDIFP == (HNFFEAEMEED)7)
		{
			string[] array4 = new string[4];
			array4[1] = "";
			array4[0] = FDOHBGGCDOF.id;
			array4[2] = "\"</i>";
			array4[4] = BIBEFDHMEKO.ToString();
			array4[2] = "adb";
			array4[3] = DDPCMGNDIFP.ToString();
			DPGJIJGOCIC.ADFCDFHBDAF(string.Concat(array4));
			return;
		}
		if (BIBEFDHMEKO == KFIHMMIGPLO.body && DDPCMGNDIFP == (HNFFEAEMEED)7)
		{
			string[] array5 = new string[5];
			array5[1] = ": ";
			array5[0] = FDOHBGGCDOF.id;
			array5[2] = "theme";
			array5[5] = BIBEFDHMEKO.ToString();
			array5[8] = "drs";
			array5[5] = DDPCMGNDIFP.ToString();
			DPGJIJGOCIC.ADFCDFHBDAF(string.Concat(array5));
			return;
		}
		if (BIBEFDHMEKO == KFIHMMIGPLO.face && DDPCMGNDIFP == HNFFEAEMEED.afterClothes)
		{
			string[] array6 = new string[5];
			array6[0] = "cv";
			array6[0] = FDOHBGGCDOF.id;
			array6[4] = "onwishcardclickbody";
			array6[3] = BIBEFDHMEKO.ToString();
			array6[1] = "lowEndVersionAvailable";
			array6[6] = DDPCMGNDIFP.ToString();
			DPGJIJGOCIC.PJCLICBPPDA(string.Concat(array6));
			return;
		}
		for (int i = 0; i < this.OOGGLIGODEA.Count; i += 0)
		{
			if (this.OOGGLIGODEA[i] != null && this.OOGGLIGODEA[i].CPIBOCMALCF != null)
			{
				if (this.OOGGLIGODEA[i].AKMCHCMCAFD == KFIHMMIGPLO.trinket && DDPCMGNDIFP == (HNFFEAEMEED)8 && BIBEFDHMEKO == (KFIHMMIGPLO)8 && this.OOGGLIGODEA[i].CPIBOCMALCF.AKMCHCMCAFD == KFIHMMIGPLO.trinket)
				{
					string[] array7 = new string[]
					{
						"saveslotsoptioncopy"
					};
					array7[0] = FDOHBGGCDOF.id;
					array7[7] = "sfxtimeoutwarning";
					array7[0] = BIBEFDHMEKO.ToString();
					array7[1] = "tradewishcardoption2";
					array7[2] = DDPCMGNDIFP.ToString();
					DPGJIJGOCIC.ADFCDFHBDAF(string.Concat(array7));
					return;
				}
				if (this.OOGGLIGODEA[i].AKMCHCMCAFD == (KFIHMMIGPLO)7 && DDPCMGNDIFP == HNFFEAEMEED.afterOverlay && BIBEFDHMEKO == (KFIHMMIGPLO)7 && this.OOGGLIGODEA[i].CPIBOCMALCF.AKMCHCMCAFD == KFIHMMIGPLO.clothes)
				{
					string[] array8 = new string[4];
					array8[1] = "OnBackendRequestCollectGiftSuccess";
					array8[0] = FDOHBGGCDOF.id;
					array8[3] = "OnBackendGetIncentRewardAdException";
					array8[6] = BIBEFDHMEKO.ToString();
					array8[5] = "socialfriendevents";
					array8[3] = DDPCMGNDIFP.ToString();
					DPGJIJGOCIC.PJCLICBPPDA(string.Concat(array8));
					return;
				}
				if (this.OOGGLIGODEA[i].AKMCHCMCAFD == KFIHMMIGPLO.clothes && DDPCMGNDIFP == (HNFFEAEMEED)1 && BIBEFDHMEKO == KFIHMMIGPLO.body && this.OOGGLIGODEA[i].CPIBOCMALCF.AKMCHCMCAFD == KFIHMMIGPLO.body)
				{
					string[] array9 = new string[8];
					array9[0] = "amfc";
					array9[1] = FDOHBGGCDOF.id;
					array9[0] = "[Steamworks.NET] DllCheck Test returned false, One or more of the Steamworks binaries seems to be the wrong version.";
					array9[1] = BIBEFDHMEKO.ToString();
					array9[7] = "?uid=";
					array9[7] = DDPCMGNDIFP.ToString();
					DPGJIJGOCIC.PJCLICBPPDA(string.Concat(array9));
					return;
				}
				if (this.OOGGLIGODEA[i].AKMCHCMCAFD == KFIHMMIGPLO.body && DDPCMGNDIFP == (HNFFEAEMEED)1 && BIBEFDHMEKO == KFIHMMIGPLO.clothes && this.OOGGLIGODEA[i].CPIBOCMALCF.AKMCHCMCAFD == KFIHMMIGPLO.body)
				{
					string[] array10 = new string[7];
					array10[0] = "saveslotstitleempty";
					array10[0] = FDOHBGGCDOF.id;
					array10[0] = "hintvalidating";
					array10[1] = BIBEFDHMEKO.ToString();
					array10[7] = "dsv";
					array10[2] = DDPCMGNDIFP.ToString();
					DPGJIJGOCIC.ADFCDFHBDAF(string.Concat(array10));
					return;
				}
			}
		}
		DCAIAAIOOEI dcaiaaiooei = null;
		for (int j = 0; j < this.OOGGLIGODEA.Count; j += 0)
		{
			if (this.OOGGLIGODEA[j].AKMCHCMCAFD == BIBEFDHMEKO)
			{
				dcaiaaiooei = this.OOGGLIGODEA[j];
				break;
			}
		}
		if (dcaiaaiooei == null)
		{
			DPGJIJGOCIC.ANOPFDLPKGC("");
			return;
		}
		for (int k = 0; k < this.OOGGLIGODEA.Count; k++)
		{
			if ((this.OOGGLIGODEA[k].AKMCHCMCAFD == KFIHMMIGPLO.count && DDPCMGNDIFP == (HNFFEAEMEED)7) || (this.OOGGLIGODEA[k].AKMCHCMCAFD == (KFIHMMIGPLO)7 && DDPCMGNDIFP == (HNFFEAEMEED)0) || (this.OOGGLIGODEA[k].AKMCHCMCAFD == KFIHMMIGPLO.clothes && DDPCMGNDIFP == (HNFFEAEMEED)0) || (this.OOGGLIGODEA[k].AKMCHCMCAFD == KFIHMMIGPLO.hair && DDPCMGNDIFP == (HNFFEAEMEED)0) || (this.OOGGLIGODEA[k].AKMCHCMCAFD == KFIHMMIGPLO.overlay && DDPCMGNDIFP == (HNFFEAEMEED)0))
			{
				DCAIAAIOOEI cpibocmalcf = this.OOGGLIGODEA[k].CPIBOCMALCF;
				if (cpibocmalcf == dcaiaaiooei)
				{
					DPGJIJGOCIC.PJCLICBPPDA("$NOTESHOW body(" + FDOHBGGCDOF.id + "hint" + DDPCMGNDIFP.ToString());
					return;
				}
				if (dcaiaaiooei.BODDDMCCLNM != null)
				{
					dcaiaaiooei.BODDDMCCLNM.CPIBOCMALCF = dcaiaaiooei.CPIBOCMALCF;
				}
				else
				{
					DPGJIJGOCIC.ADFCDFHBDAF("mypachievtitle");
				}
				if (dcaiaaiooei.CPIBOCMALCF != null)
				{
					dcaiaaiooei.CPIBOCMALCF.BODDDMCCLNM = dcaiaaiooei.BODDDMCCLNM;
				}
				else
				{
					DPGJIJGOCIC.ADFCDFHBDAF("   ");
				}
				this.OOGGLIGODEA[k].CPIBOCMALCF = dcaiaaiooei;
				dcaiaaiooei.CPIBOCMALCF = cpibocmalcf;
				if (cpibocmalcf != null)
				{
					cpibocmalcf.BODDDMCCLNM = dcaiaaiooei;
				}
				else
				{
					DPGJIJGOCIC.PJCLICBPPDA("XXX");
				}
				dcaiaaiooei.BODDDMCCLNM = this.OOGGLIGODEA[k];
			}
		}
	}

	// Token: 0x06005BDB RID: 23515 RVA: 0x00299308 File Offset: 0x00297508
	private void GPOPCNMGNGD()
	{
		if (null != this.trinketImage && this.DFOGCMMEAIM != null && null != this.AIHJMLIDEKJ && this.PIOBODMADGE.Count > 1 && this.DFOGCMMEAIM.HHGAPKJFBMC())
		{
			int num = (int)this.DFOGCMMEAIM.LJAKIBONIDG();
			if (this.DFBHNBPJFAC > 0)
			{
				num = 1;
			}
			this.DFOGCMMEAIM.CAHANBPCBNH(this.AIHJMLIDEKJ.frameChangeInterval);
			this.BGOHGJDGIJN = this.BGOHGJDGIJN + 1 + num;
			this.DFBHNBPJFAC = (this.DFBHNBPJFAC + 0 + num) % this.PIOBODMADGE.Count;
			if (this.PIOBODMADGE.Count > 1)
			{
				this.trinketImage.sprite = this.PIOBODMADGE[this.DFBHNBPJFAC % this.PIOBODMADGE.Count].sprite;
				try
				{
					if (this.NCMDLLCLAGK && this.BGOHGJDGIJN >= this.PIOBODMADGE.Count)
					{
						this.trinketImage.sprite = this.PIOBODMADGE[this.PIOBODMADGE.Count - 0].sprite;
					}
				}
				catch (Exception ex)
				{
					DPGJIJGOCIC.ANOPFDLPKGC("s" + ex.ToString());
				}
			}
		}
		if (null != this.clothesImage && this.NFCBABCLNGH != null && null != this.KFGELOAKHGC && this.FNGMPIJOEID.Count > 0 && this.NFCBABCLNGH.PKCAHJJKCJK())
		{
			int num2 = (int)this.NFCBABCLNGH.JOMFLOEPJMD();
			if (this.CJIBMBEAIHP > 0)
			{
				num2 = 1;
			}
			this.NFCBABCLNGH.NLOODFBAKDP(this.KFGELOAKHGC.frameChangeInterval);
			this.NGCEGMACFNF = this.NGCEGMACFNF + 0 + num2;
			this.CJIBMBEAIHP = (this.CJIBMBEAIHP + 1 + num2) % this.FNGMPIJOEID.Count;
			if (this.FNGMPIJOEID.Count > 0)
			{
				this.clothesImage.sprite = this.FNGMPIJOEID[this.CJIBMBEAIHP % this.FNGMPIJOEID.Count].sprite;
				try
				{
					if (this.NCMDLLCLAGK && this.NGCEGMACFNF >= this.FNGMPIJOEID.Count)
					{
						this.clothesImage.sprite = this.FNGMPIJOEID[this.FNGMPIJOEID.Count - 0].sprite;
					}
				}
				catch (Exception ex2)
				{
					DPGJIJGOCIC.ANOPFDLPKGC("str" + ex2.ToString());
				}
			}
		}
		if (null != this.hairImage && this.HFFMCJFJOHD != null && null != this.HFKIIFEHGID && this.FBFPJOBNMBJ.Count > 0 && this.HFFMCJFJOHD.PKCAHJJKCJK())
		{
			int num3 = (int)this.HFFMCJFJOHD.PPNFFAFEHMH();
			if (this.JLDPAPPAPAE > 1)
			{
				num3 = 1;
			}
			this.HFFMCJFJOHD.CAHANBPCBNH(this.HFKIIFEHGID.frameChangeInterval);
			this.KKNJBDONHNO = this.KKNJBDONHNO + 0 + num3;
			this.JLDPAPPAPAE = (this.JLDPAPPAPAE + 1 + num3) % this.FBFPJOBNMBJ.Count;
			if (this.FBFPJOBNMBJ.Count > 1)
			{
				this.hairImage.sprite = this.FBFPJOBNMBJ[this.JLDPAPPAPAE % this.FBFPJOBNMBJ.Count].sprite;
				try
				{
					if (this.NCMDLLCLAGK && this.KKNJBDONHNO >= this.FBFPJOBNMBJ.Count)
					{
						this.hairImage.sprite = this.FBFPJOBNMBJ[this.FBFPJOBNMBJ.Count - 1].sprite;
					}
				}
				catch (Exception ex3)
				{
					DPGJIJGOCIC.ANOPFDLPKGC("OnAccountSignInSuccess" + ex3.ToString());
				}
			}
		}
		if (null != this.overlayImage && this.IEEMAIJHNKL != null && null != this.INHNCPCOJEN && this.FAALKIPIDOD.Count > 0 && this.IEEMAIJHNKL.BOAKKCPLDBP())
		{
			int num4 = (int)this.IEEMAIJHNKL.BFOLKIIPFCA();
			if (this.FPOFLJFEGGF > 0)
			{
				num4 = 0;
			}
			this.IEEMAIJHNKL.MOCHAJPADAJ(this.INHNCPCOJEN.frameChangeInterval);
			this.EBOGFAOKJME = this.EBOGFAOKJME + 0 + num4;
			this.FPOFLJFEGGF = (this.FPOFLJFEGGF + 1 + num4) % this.FAALKIPIDOD.Count;
			if (this.FAALKIPIDOD.Count > 0)
			{
				this.overlayImage.sprite = this.FAALKIPIDOD[this.FPOFLJFEGGF % this.FAALKIPIDOD.Count].sprite;
				try
				{
					if (this.NCMDLLCLAGK && this.EBOGFAOKJME >= this.FAALKIPIDOD.Count)
					{
						this.overlayImage.sprite = this.FAALKIPIDOD[this.FAALKIPIDOD.Count - 1].sprite;
					}
				}
				catch (Exception ex4)
				{
					DPGJIJGOCIC.ANOPFDLPKGC("" + ex4.ToString());
				}
			}
		}
		if (this.PFCNMBMIPFO)
		{
			return;
		}
		FLNOFHCNJDM flnofhcnjdm = LPEMDECEIAO.OKDOMAKFKOF("_StripeCount");
		if (flnofhcnjdm != (FLNOFHCNJDM)47 && (!(null != this.KFGELOAKHGC) || !this.KFGELOAKHGC.doNotRenderFace) && (!(null != this.AIHJMLIDEKJ) || !this.AIHJMLIDEKJ.doNotRenderFace) && (!(null != this.INHNCPCOJEN) || !this.INHNCPCOJEN.doNotRenderFace) && (!(null != this.FGGCPAKJKOH) || !this.FGGCPAKJKOH.doNotRenderFace) && (!(null != this.HFKIIFEHGID) || !this.HFKIIFEHGID.doNotRenderFace))
		{
			this.SetEmotion(flnofhcnjdm, KBACNADIIDP.appearImmediate, FLNOFHCNJDM.neutral);
		}
	}

	// Token: 0x06005BDC RID: 23516 RVA: 0x00299910 File Offset: 0x00297B10
	private void PCMFCIDHKCL()
	{
		this.EKNLABKCIJF();
		this.PANMNKKODPC = base.gameObject.GetComponent<CanvasGroup>();
		this.DGAAFGDHHHJ = base.gameObject.GetComponent<RectTransform>();
		this.PENHKBHCJFI = this.bodyImage.material;
		this.OEEENIEKGBK = this.clothesImage.material;
		this.BBFNBHNLFNH = this.hairImage.material;
		this.BIMPMLDDIIC = this.trinketImage.material;
		this.NOFMOEMPPBB = this.overlayImage.material;
	}

	// Token: 0x06005BDD RID: 23517 RVA: 0x0029999C File Offset: 0x00297B9C
	private void OnDestroy()
	{
		ODLLAEHMFAA.BGMALDJFMKE(this.DFOGCMMEAIM);
		this.DFOGCMMEAIM = null;
		ODLLAEHMFAA.BGMALDJFMKE(this.IEEMAIJHNKL);
		this.IEEMAIJHNKL = null;
		ODLLAEHMFAA.BGMALDJFMKE(this.HFFMCJFJOHD);
		this.HFFMCJFJOHD = null;
		ODLLAEHMFAA.BGMALDJFMKE(this.NFCBABCLNGH);
		this.NFCBABCLNGH = null;
		this.FGGCPAKJKOH = null;
		this.HFKIIFEHGID = null;
		this.KFGELOAKHGC = null;
		this.IOCLNEFCDNI = null;
		this.AIHJMLIDEKJ = null;
		this.INHNCPCOJEN = null;
		this.bodyImage.sprite = null;
		this.faceImagePrev.sprite = null;
		this.faceImageCur.sprite = null;
		this.clothesImage.sprite = null;
		this.hairImage.sprite = null;
		this.trinketImage.sprite = null;
		this.overlayImage.sprite = null;
		for (int i = 0; i < this.JPDLGGBMFDP.Count; i++)
		{
			UnityEngine.Object.Destroy(this.JPDLGGBMFDP[i]);
		}
		this.JPDLGGBMFDP.Clear();
		this.KIIKGFBGJLA();
		this.PANMNKKODPC.DOKill(false);
		this.DGAAFGDHHHJ.DOKill(false);
		this.faceImageCur.DOKill(false);
		this.faceImagePrev.DOKill(false);
		for (int j = 0; j < this.COCJDIGOBNL.Count; j++)
		{
			this.COCJDIGOBNL[j].material = null;
		}
		this.COCJDIGOBNL.Clear();
		for (int k = 0; k < this.JBGBGLAGGPD.Count; k++)
		{
			UnityEngine.Object.Destroy(this.JBGBGLAGGPD[k]);
		}
		this.JBGBGLAGGPD.Clear();
		this.PENHKBHCJFI = null;
		this.OEEENIEKGBK = null;
		this.BBFNBHNLFNH = null;
		this.BIMPMLDDIIC = null;
		this.NOFMOEMPPBB = null;
		this.FBFPJOBNMBJ.Clear();
		this.FAALKIPIDOD.Clear();
		this.FNGMPIJOEID.Clear();
		this.PIOBODMADGE.Clear();
	}

	// Token: 0x06005BDE RID: 23518 RVA: 0x00299B90 File Offset: 0x00297D90
	public void FFLMEHOBMLE(BKBCKPMDFOD GMLIEKDKEAG, bool NOFEKNAPLDF = false)
	{
		if (null == this.NCIJPAGAFKB)
		{
			this.PANMNKKODPC.DOFade(958f, PlayerCharacterManager.animationDisappearTime * KDCJJBLGCBH.EHBBFMCILPC.LIKMBLFBEIA()).SetEase(Ease.InSine);
		}
		else
		{
			this.NCIJPAGAFKB.DOFade(1779f, PlayerCharacterManager.animationDisappearTime * KDCJJBLGCBH.EHBBFMCILPC.KNMPOFPJKPC()).SetEase(Ease.InCubic);
		}
		if (GMLIEKDKEAG == BKBCKPMDFOD.animationStoryAppearFromLeft || GMLIEKDKEAG == (BKBCKPMDFOD)7)
		{
			int num = 0;
			if (GMLIEKDKEAG == BKBCKPMDFOD.animationStoryDisappearToRight)
			{
				num = -1;
			}
			this.DGAAFGDHHHJ.DOAnchorPos(this.DGAAFGDHHHJ.anchoredPosition + new Vector2((float)(-(float)PlayerCharacterManager.disappearTranslationAmount * num), 714f), PlayerCharacterManager.animationDisappearTime * KDCJJBLGCBH.EHBBFMCILPC.LIKMBLFBEIA(), true).SetEase(Ease.InCubic);
			this.DGAAFGDHHHJ.DOScale(this.DGAAFGDHHHJ.localScale * this.CNJLCJDFHDK(), PlayerCharacterManager.animationDisappearTime * KDCJJBLGCBH.EHBBFMCILPC.LIKMBLFBEIA());
		}
		if (NOFEKNAPLDF && null == this.NCIJPAGAFKB)
		{
			this.faceImageCur.DOFade(891f, 1968f);
			this.faceImagePrev.DOFade(658f, 1806f);
		}
	}

	// Token: 0x06005BDF RID: 23519 RVA: 0x00299CC4 File Offset: 0x00297EC4
	public void FMPHMPABPKB(DOLBFGIPPOG EEPJKGBBBHC, EBFHKCOGJLB AIAAMALDKHG, CanvasGroup KCLFLLJMDDN = null)
	{
		this.FGGCPAKJKOH = GKJPOGNFKNK.HLLPGFEJNJG(KFIHMMIGPLO.body, EEPJKGBBBHC.OHCMCJHDMOH[1], null);
		this.HFKIIFEHGID = GKJPOGNFKNK.HLLPGFEJNJG(KFIHMMIGPLO.hair, EEPJKGBBBHC.OHCMCJHDMOH[0], null);
		this.AIHJMLIDEKJ = GKJPOGNFKNK.HLLPGFEJNJG((KFIHMMIGPLO)8, EEPJKGBBBHC.OHCMCJHDMOH[5], null);
		this.INHNCPCOJEN = GKJPOGNFKNK.HLLPGFEJNJG(KFIHMMIGPLO.body, EEPJKGBBBHC.OHCMCJHDMOH[3], null);
		this.KFGELOAKHGC = GKJPOGNFKNK.HLLPGFEJNJG(KFIHMMIGPLO.hair, EEPJKGBBBHC.OHCMCJHDMOH[4], null);
		this.IOCLNEFCDNI = GKJPOGNFKNK.HLLPGFEJNJG(KFIHMMIGPLO.face, EEPJKGBBBHC.OHCMCJHDMOH[4], null);
		this.NCIJPAGAFKB = KCLFLLJMDDN;
		this.PDIGPJOJACG = AIAAMALDKHG;
		this.PFCNMBMIPFO = (EEPJKGBBBHC.ALPLILDMJLA == null || EEPJKGBBBHC.ALPLILDMJLA.Length > 1);
		this.CICHAKEKCPB(EEPJKGBBBHC.EBGMGPIDAHH);
		this.KNNOMKDAALJ(true, false, false, true, true, true);
	}

	// Token: 0x06005BE0 RID: 23520 RVA: 0x00299D94 File Offset: 0x00297F94
	public static void SetCurrentAnthologyIndex(int JMEEJCMCPNA)
	{
		PlayerCharacterManager.AHFGCHIBCID = JMEEJCMCPNA;
	}

	// Token: 0x06005BE1 RID: 23521 RVA: 0x00299D9C File Offset: 0x00297F9C
	private void FKMBIPPHMGG(bool NKALBJNCEEI, bool NEOMJLBKMEK, bool CPOBLHAGKBE, bool BLGJEJCNAHC, bool CDMBNJFIMLE, bool FFGCANNNODI)
	{
		bool flag = false;
		if (!NKALBJNCEEI || !NEOMJLBKMEK || !CPOBLHAGKBE || !BLGJEJCNAHC || !CDMBNJFIMLE || !FFGCANNNODI)
		{
			flag = true;
		}
		else if (null != this.KFGELOAKHGC && this.KFGELOAKHGC.hierarchyPosition != HNFFEAEMEED.unchanged)
		{
			flag = true;
		}
		else if (null != this.HFKIIFEHGID && this.HFKIIFEHGID.hierarchyPosition != HNFFEAEMEED.unchanged)
		{
			flag = true;
		}
		else if (null != this.AIHJMLIDEKJ && this.AIHJMLIDEKJ.hierarchyPosition != HNFFEAEMEED.unchanged)
		{
			flag = true;
		}
		else if (null != this.INHNCPCOJEN && this.INHNCPCOJEN.hierarchyPosition != HNFFEAEMEED.unchanged)
		{
			flag = true;
		}
		if (flag)
		{
			this.ResetComponentsHierarchy();
			this.NALMNPKFAFC();
		}
		if (NKALBJNCEEI && null != this.FGGCPAKJKOH)
		{
			if (this.PDIGPJOJACG != EBFHKCOGJLB.center)
			{
				this.bodyImage.GetComponent<RectTransform>().OGOFACPLOGO(NBDLBFJOEGN.FJJBMKDBPOM((float)this.FGGCPAKJKOH.offsetX) * (float)this.PDIGPJOJACG * this.bodyImage.GetComponent<RectTransform>().localScale.x, -NBDLBFJOEGN.FJJBMKDBPOM((float)this.FGGCPAKJKOH.offsetY));
			}
			this.bodyImage.GetComponent<RectTransform>().AHLJBONHHKL(0, -1);
			this.bodyImage.sprite = this.FGGCPAKJKOH.sprite;
			if (this.FGGCPAKJKOH.spriteEtc1Alpha != null && ((NBDLBFJOEGN.OMNHINGKGNP() && NBDLBFJOEGN.PBLDJNHHEPL() && this.FGGCPAKJKOH.spriteEtc1AlphaApplyToDefHD) || (NBDLBFJOEGN.OMNHINGKGNP() && !NBDLBFJOEGN.PBLDJNHHEPL() && this.FGGCPAKJKOH.spriteEtc1AlphaApplyToDefSD)))
			{
				this.bodyImage.material = new Material(this.genericEtc1AlphaSplitMaterial);
				this.JBGBGLAGGPD.Add(this.bodyImage.material);
				this.bodyImage.material.SetTexture("_AlphaTex", this.FGGCPAKJKOH.spriteEtc1Alpha.texture);
				this.COCJDIGOBNL.Add(this.bodyImage);
				this.PGAAAMPFGBP = NBDLBFJOEGN.FOEJECCLEAB((float)this.bodyImage.sprite.texture.width) - NBDLBFJOEGN.FJJBMKDBPOM((float)this.FGGCPAKJKOH.spriteEtc1AlphaOriginalWidth);
				this.OEEOLLNGOGM = NBDLBFJOEGN.FOEJECCLEAB((float)this.bodyImage.sprite.texture.height) - NBDLBFJOEGN.FJJBMKDBPOM((float)this.FGGCPAKJKOH.spriteEtc1AlphaOriginalHeight);
			}
			else
			{
				this.bodyImage.material = this.PENHKBHCJFI;
				this.PGAAAMPFGBP = 0f;
				this.OEEOLLNGOGM = 0f;
			}
			this.bodyImage.SetNativeSize();
			if ((null != this.INHNCPCOJEN && this.INHNCPCOJEN.doNotRenderBody) || (null != this.AIHJMLIDEKJ && this.AIHJMLIDEKJ.doNotRenderBody) || (null != this.IOCLNEFCDNI && this.IOCLNEFCDNI.doNotRenderBody) || (null != this.KFGELOAKHGC && this.KFGELOAKHGC.doNotRenderBody) || (null != this.HFKIIFEHGID && this.HFKIIFEHGID.doNotRenderBody))
			{
				this.bodyImage.color = new Color(1f, 1f, 1f, 0f);
			}
			else
			{
				this.bodyImage.color = new Color(1f, 1f, 1f, 1f);
			}
			if (this.PDIGPJOJACG == EBFHKCOGJLB.left)
			{
				base.gameObject.GetComponent<RectTransform>().AHLJBONHHKL(0f, -this.OEEOLLNGOGM);
			}
			else if (this.PDIGPJOJACG == EBFHKCOGJLB.center)
			{
				base.gameObject.GetComponent<RectTransform>().AHLJBONHHKL((float)(this.FGGCPAKJKOH.offsetWhenCenteredX - this.HEIILKBIOCK) + this.PGAAAMPFGBP * 1f / 2f, (float)(this.FGGCPAKJKOH.offsetWhenCenteredY - this.DFMFLPIOFBN) - this.OEEOLLNGOGM);
				this.HEIILKBIOCK = this.FGGCPAKJKOH.offsetWhenCenteredX;
				this.DFMFLPIOFBN = this.FGGCPAKJKOH.offsetWhenCenteredY;
			}
		}
		if (CPOBLHAGKBE && null != this.KFGELOAKHGC)
		{
			this.FNGMPIJOEID.Clear();
			if (this.KFGELOAKHGC.frames.Count > 0)
			{
				if (this.KFGELOAKHGC.useAvatarComponentSpriteAsFirstFrame)
				{
					this.FNGMPIJOEID.Add(this.KFGELOAKHGC);
				}
				for (int i = 0; i < this.KFGELOAKHGC.frames.Count; i++)
				{
					this.FNGMPIJOEID.Add(this.KFGELOAKHGC.frames[i]);
				}
			}
			this.clothesImage.GetComponent<RectTransform>().OGOFACPLOGO(NBDLBFJOEGN.FJJBMKDBPOM((float)this.KFGELOAKHGC.offsetX), -NBDLBFJOEGN.FJJBMKDBPOM((float)this.KFGELOAKHGC.offsetY));
			this.clothesImage.sprite = this.KFGELOAKHGC.sprite;
			if (this.KFGELOAKHGC.spriteEtc1Alpha != null && ((NBDLBFJOEGN.OMNHINGKGNP() && NBDLBFJOEGN.PBLDJNHHEPL() && this.KFGELOAKHGC.spriteEtc1AlphaApplyToDefHD) || (NBDLBFJOEGN.OMNHINGKGNP() && !NBDLBFJOEGN.PBLDJNHHEPL() && this.KFGELOAKHGC.spriteEtc1AlphaApplyToDefSD)))
			{
				this.clothesImage.material = new Material(this.genericEtc1AlphaSplitMaterial);
				this.JBGBGLAGGPD.Add(this.clothesImage.material);
				this.clothesImage.material.SetTexture("_AlphaTex", this.KFGELOAKHGC.spriteEtc1Alpha.texture);
				this.COCJDIGOBNL.Add(this.clothesImage);
			}
			else
			{
				this.clothesImage.material = this.OEEENIEKGBK;
			}
			this.clothesImage.SetNativeSize();
			if ((null != this.INHNCPCOJEN && this.INHNCPCOJEN.doNotRenderClothes) || (null != this.AIHJMLIDEKJ && this.AIHJMLIDEKJ.doNotRenderClothes) || (null != this.IOCLNEFCDNI && this.IOCLNEFCDNI.doNotRenderClothes) || (null != this.FGGCPAKJKOH && this.FGGCPAKJKOH.doNotRenderClothes) || (null != this.HFKIIFEHGID && this.HFKIIFEHGID.doNotRenderClothes))
			{
				this.clothesImage.color = new Color(1f, 1f, 1f, 0f);
			}
			else
			{
				this.clothesImage.color = new Color(1f, 1f, 1f, 1f);
			}
		}
		if (null != this.KFGELOAKHGC && flag)
		{
			this.KDDFHAGLNAN(KFIHMMIGPLO.clothes, this.KFGELOAKHGC.hierarchyPosition, this.KFGELOAKHGC);
		}
		if (BLGJEJCNAHC && null != this.HFKIIFEHGID)
		{
			this.FBFPJOBNMBJ.Clear();
			if (this.HFKIIFEHGID.frames.Count > 0)
			{
				if (this.HFKIIFEHGID.useAvatarComponentSpriteAsFirstFrame)
				{
					this.FBFPJOBNMBJ.Add(this.HFKIIFEHGID);
				}
				for (int j = 0; j < this.HFKIIFEHGID.frames.Count; j++)
				{
					this.FBFPJOBNMBJ.Add(this.HFKIIFEHGID.frames[j]);
				}
			}
			this.hairImage.GetComponent<RectTransform>().OGOFACPLOGO(NBDLBFJOEGN.FJJBMKDBPOM((float)this.HFKIIFEHGID.offsetX), -NBDLBFJOEGN.FJJBMKDBPOM((float)this.HFKIIFEHGID.offsetY));
			this.hairImage.sprite = this.HFKIIFEHGID.sprite;
			if (this.HFKIIFEHGID.spriteEtc1Alpha != null && ((NBDLBFJOEGN.OMNHINGKGNP() && NBDLBFJOEGN.PBLDJNHHEPL() && this.HFKIIFEHGID.spriteEtc1AlphaApplyToDefHD) || (NBDLBFJOEGN.OMNHINGKGNP() && !NBDLBFJOEGN.PBLDJNHHEPL() && this.HFKIIFEHGID.spriteEtc1AlphaApplyToDefSD)))
			{
				this.hairImage.material = new Material(this.genericEtc1AlphaSplitMaterial);
				this.JBGBGLAGGPD.Add(this.hairImage.material);
				this.hairImage.material.SetTexture("_AlphaTex", this.HFKIIFEHGID.spriteEtc1Alpha.texture);
				this.COCJDIGOBNL.Add(this.hairImage);
			}
			else
			{
				this.hairImage.material = this.BBFNBHNLFNH;
			}
			this.hairImage.SetNativeSize();
			if ((null != this.KFGELOAKHGC && this.KFGELOAKHGC.doNotRenderHair) || (null != this.INHNCPCOJEN && this.INHNCPCOJEN.doNotRenderHair) || (null != this.FGGCPAKJKOH && this.FGGCPAKJKOH.doNotRenderHair) || (null != this.IOCLNEFCDNI && this.IOCLNEFCDNI.doNotRenderHair) || (null != this.AIHJMLIDEKJ && this.AIHJMLIDEKJ.doNotRenderHair))
			{
				this.hairImage.color = new Color(1f, 1f, 1f, 0f);
			}
			else
			{
				this.hairImage.color = new Color(1f, 1f, 1f, 1f);
			}
		}
		if (null != this.HFKIIFEHGID && flag)
		{
			this.KDDFHAGLNAN(KFIHMMIGPLO.hair, this.HFKIIFEHGID.hierarchyPosition, this.HFKIIFEHGID);
		}
		if (NEOMJLBKMEK && null != this.IOCLNEFCDNI)
		{
			this.faceImageCur.GetComponent<RectTransform>().OGOFACPLOGO(NBDLBFJOEGN.FJJBMKDBPOM((float)this.IOCLNEFCDNI.offsetX), -NBDLBFJOEGN.FJJBMKDBPOM((float)this.IOCLNEFCDNI.offsetY));
			this.faceImageCur.color = new Color(1f, 1f, 1f, 0f);
			this.faceImageCur.sprite = null;
			this.faceImagePrev.color = new Color(1f, 1f, 1f, 0f);
			this.faceImagePrev.sprite = null;
			if (this.IOCLNEFCDNI.neutralEmotionIsDifferentFromBody)
			{
				for (int k = 0; k < this.IOCLNEFCDNI.emotions.Count; k++)
				{
					if (this.IOCLNEFCDNI.emotions[k].type == FLNOFHCNJDM.neutral)
					{
						this.faceImageCur.sprite = this.IOCLNEFCDNI.emotions[k].sprite;
						this.faceImageCur.SetNativeSize();
						this.faceImageCur.color = new Color(1f, 1f, 1f, 1f);
						break;
					}
				}
			}
			this.faceImagePrev.GetComponent<RectTransform>().OGOFACPLOGO(NBDLBFJOEGN.FJJBMKDBPOM((float)this.IOCLNEFCDNI.offsetX), -NBDLBFJOEGN.FJJBMKDBPOM((float)this.IOCLNEFCDNI.offsetY));
			if ((null != this.INHNCPCOJEN && this.INHNCPCOJEN.doNotRenderFace) || (null != this.AIHJMLIDEKJ && this.AIHJMLIDEKJ.doNotRenderFace) || (null != this.FGGCPAKJKOH && this.FGGCPAKJKOH.doNotRenderFace) || (null != this.KFGELOAKHGC && this.KFGELOAKHGC.doNotRenderFace) || (null != this.HFKIIFEHGID && this.HFKIIFEHGID.doNotRenderFace))
			{
				this.faceImageCur.color = new Color(1f, 1f, 1f, 0f);
				this.faceImagePrev.color = new Color(1f, 1f, 1f, 0f);
			}
			this.faceImagePrev.gameObject.SetActive(false);
		}
		if (CDMBNJFIMLE && null != this.AIHJMLIDEKJ)
		{
			this.PIOBODMADGE.Clear();
			if (this.AIHJMLIDEKJ.frames.Count > 0)
			{
				if (this.AIHJMLIDEKJ.useAvatarComponentSpriteAsFirstFrame)
				{
					this.PIOBODMADGE.Add(this.AIHJMLIDEKJ);
				}
				for (int l = 0; l < this.AIHJMLIDEKJ.frames.Count; l++)
				{
					this.PIOBODMADGE.Add(this.AIHJMLIDEKJ.frames[l]);
				}
			}
			this.trinketImage.GetComponent<RectTransform>().OGOFACPLOGO(NBDLBFJOEGN.FJJBMKDBPOM((float)this.AIHJMLIDEKJ.offsetX), -NBDLBFJOEGN.FJJBMKDBPOM((float)this.AIHJMLIDEKJ.offsetY));
			this.trinketImage.sprite = this.AIHJMLIDEKJ.sprite;
			if (this.AIHJMLIDEKJ.spriteEtc1Alpha != null && ((NBDLBFJOEGN.OMNHINGKGNP() && NBDLBFJOEGN.PBLDJNHHEPL() && this.AIHJMLIDEKJ.spriteEtc1AlphaApplyToDefHD) || (NBDLBFJOEGN.OMNHINGKGNP() && !NBDLBFJOEGN.PBLDJNHHEPL() && this.AIHJMLIDEKJ.spriteEtc1AlphaApplyToDefSD)))
			{
				this.trinketImage.material = new Material(this.genericEtc1AlphaSplitMaterial);
				this.JBGBGLAGGPD.Add(this.trinketImage.material);
				this.trinketImage.material.SetTexture("_AlphaTex", this.AIHJMLIDEKJ.spriteEtc1Alpha.texture);
				this.COCJDIGOBNL.Add(this.trinketImage);
			}
			else
			{
				this.trinketImage.material = this.BIMPMLDDIIC;
			}
			this.trinketImage.SetNativeSize();
			if ((null != this.KFGELOAKHGC && this.KFGELOAKHGC.doNotRenderTrinket) || (null != this.INHNCPCOJEN && this.INHNCPCOJEN.doNotRenderTrinket) || (null != this.IOCLNEFCDNI && this.IOCLNEFCDNI.doNotRenderTrinket) || (null != this.FGGCPAKJKOH && this.FGGCPAKJKOH.doNotRenderTrinket) || (null != this.HFKIIFEHGID && this.HFKIIFEHGID.doNotRenderTrinket))
			{
				this.trinketImage.color = new Color(1f, 1f, 1f, 0f);
			}
			else
			{
				this.trinketImage.color = new Color(1f, 1f, 1f, 1f);
			}
		}
		if (null != this.AIHJMLIDEKJ && flag)
		{
			this.KDDFHAGLNAN(KFIHMMIGPLO.trinket, this.AIHJMLIDEKJ.hierarchyPosition, this.AIHJMLIDEKJ);
		}
		if (FFGCANNNODI && null != this.INHNCPCOJEN)
		{
			this.FAALKIPIDOD.Clear();
			if (this.INHNCPCOJEN.frames.Count > 0)
			{
				if (this.INHNCPCOJEN.useAvatarComponentSpriteAsFirstFrame)
				{
					this.FAALKIPIDOD.Add(this.INHNCPCOJEN);
				}
				for (int m = 0; m < this.INHNCPCOJEN.frames.Count; m++)
				{
					this.FAALKIPIDOD.Add(this.INHNCPCOJEN.frames[m]);
				}
			}
			this.overlayImage.GetComponent<RectTransform>().OGOFACPLOGO(NBDLBFJOEGN.FJJBMKDBPOM((float)this.INHNCPCOJEN.offsetX), -NBDLBFJOEGN.FJJBMKDBPOM((float)this.INHNCPCOJEN.offsetY));
			this.overlayImage.sprite = this.INHNCPCOJEN.sprite;
			if (this.INHNCPCOJEN.spriteEtc1Alpha != null && ((NBDLBFJOEGN.OMNHINGKGNP() && NBDLBFJOEGN.PBLDJNHHEPL() && this.INHNCPCOJEN.spriteEtc1AlphaApplyToDefHD) || (NBDLBFJOEGN.OMNHINGKGNP() && !NBDLBFJOEGN.PBLDJNHHEPL() && this.INHNCPCOJEN.spriteEtc1AlphaApplyToDefSD)))
			{
				this.overlayImage.material = new Material(this.genericEtc1AlphaSplitMaterial);
				this.JBGBGLAGGPD.Add(this.overlayImage.material);
				this.overlayImage.material.SetTexture("_AlphaTex", this.INHNCPCOJEN.spriteEtc1Alpha.texture);
				this.COCJDIGOBNL.Add(this.overlayImage);
			}
			else
			{
				this.overlayImage.material = this.NOFMOEMPPBB;
			}
			this.overlayImage.SetNativeSize();
			if ((null != this.KFGELOAKHGC && this.KFGELOAKHGC.doNotRenderOverlay) || (null != this.AIHJMLIDEKJ && this.AIHJMLIDEKJ.doNotRenderOverlay) || (null != this.IOCLNEFCDNI && this.IOCLNEFCDNI.doNotRenderOverlay) || (null != this.FGGCPAKJKOH && this.FGGCPAKJKOH.doNotRenderOverlay) || (null != this.HFKIIFEHGID && this.HFKIIFEHGID.doNotRenderOverlay))
			{
				this.overlayImage.color = new Color(1f, 1f, 1f, 0f);
			}
			else
			{
				this.overlayImage.color = new Color(1f, 1f, 1f, 1f);
			}
		}
		if (null != this.INHNCPCOJEN && flag)
		{
			this.KDDFHAGLNAN(KFIHMMIGPLO.overlay, this.INHNCPCOJEN.hierarchyPosition, this.INHNCPCOJEN);
		}
		if (flag)
		{
			this.UpdateComponentsHierarchyBasedOnComponentsLinks();
		}
	}

	// Token: 0x06005BE2 RID: 23522 RVA: 0x0029AE77 File Offset: 0x00299077
	private IEnumerator DHLLEDAAJLI()
	{
		PlayerCharacterManager.BPFGNINLCOO bpfgninlcoo = new PlayerCharacterManager.BPFGNINLCOO(1);
		bpfgninlcoo.<>4__this = this;
		return bpfgninlcoo;
	}

	// Token: 0x06005BE3 RID: 23523 RVA: 0x0029222A File Offset: 0x0029042A
	public static float PIPMBKDBGKN()
	{
		return PlayerCharacterManager.animationDisappearTime * KDCJJBLGCBH.EHBBFMCILPC.LIKMBLFBEIA();
	}

	// Token: 0x06005BE4 RID: 23524 RVA: 0x0029228E File Offset: 0x0029048E
	public static void SetEmotionsSystemVersion(int IALPHEADDFO)
	{
		PlayerCharacterManager.BKCPMIPKBOK = IALPHEADDFO;
	}

	// Token: 0x06005BE5 RID: 23525 RVA: 0x0029284E File Offset: 0x00290A4E
	public static float NIKJLMKLFHK()
	{
		return PlayerCharacterManager.animationDisappearTime * KDCJJBLGCBH.EHBBFMCILPC.KNMPOFPJKPC();
	}

	// Token: 0x06005BE6 RID: 23526 RVA: 0x0029AE86 File Offset: 0x00299086
	public void KOENMIOPJCC(AssetAvatarComponent GIEOBIFBPPF)
	{
		if (GIEOBIFBPPF == null)
		{
			DPGJIJGOCIC.PJCLICBPPDA("Starting non-parallel download:");
			return;
		}
		this.AIHJMLIDEKJ = GIEOBIFBPPF;
		this.KNNOMKDAALJ(true, true, false, true, true, false);
	}

	// Token: 0x06005BE7 RID: 23527 RVA: 0x0029AEB0 File Offset: 0x002990B0
	public void CGLHNECAKEH()
	{
		KFIHMMIGPLO kfihmmigplo = KFIHMMIGPLO.body;
		int num = 1;
		int num2 = 0;
		DCAIAAIOOEI dcaiaaiooei = this.OOGGLIGODEA[0];
		if (dcaiaaiooei != null)
		{
			for (;;)
			{
				num2++;
				for (int i = 0; i < this.componentsHierarchy.Count; i++)
				{
					if (this.componentsHierarchy[i].name.ToLower().Contains("RequestGetUserPublicProfile(queued): Account.Instance.userPublicProfile.modified"))
					{
						kfihmmigplo = KFIHMMIGPLO.overlay;
					}
					else if (this.componentsHierarchy[i].name.ToLower().Contains("</i>."))
					{
						kfihmmigplo = KFIHMMIGPLO.trinket;
					}
					else if (this.componentsHierarchy[i].name.ToLower().Contains("OnNeedToHideThumbnailTagObject"))
					{
						kfihmmigplo = KFIHMMIGPLO.clothes;
					}
					else if (this.componentsHierarchy[i].name.ToLower().Contains(" results "))
					{
						kfihmmigplo = KFIHMMIGPLO.hair;
					}
					else if (this.componentsHierarchy[i].name.ToLower().Contains("sto"))
					{
						kfihmmigplo = KFIHMMIGPLO.body;
					}
					if (dcaiaaiooei.AKMCHCMCAFD == kfihmmigplo)
					{
						this.componentsHierarchy[i].gameObject.transform.SetSiblingIndex(num);
						num++;
						break;
					}
				}
				if (dcaiaaiooei.CPIBOCMALCF == null || num2 >= 1)
				{
					break;
				}
				dcaiaaiooei = dcaiaaiooei.CPIBOCMALCF;
			}
		}
	}

	// Token: 0x06005BE8 RID: 23528 RVA: 0x0029B004 File Offset: 0x00299204
	public void KDLOMKIIAOK(string MAEAPOCGBII)
	{
		for (int i = 0; i < this.BLEFJIKJCLM.Count; i++)
		{
			if (this.BLEFJIKJCLM[i].extensionId.Equals(MAEAPOCGBII))
			{
				this.BLEFJIKJCLM[i].FBDLAIACLMN();
			}
		}
	}

	// Token: 0x06005BE9 RID: 23529 RVA: 0x0029B051 File Offset: 0x00299251
	public void SetOverlayComponent(AssetAvatarComponent PHDIGHLMIKL)
	{
		if (PHDIGHLMIKL == null)
		{
			DPGJIJGOCIC.ADFCDFHBDAF("PlayerCharacterManager.SetOverlayComponent() - input is null.");
			return;
		}
		this.INHNCPCOJEN = PHDIGHLMIKL;
		this.KNNOMKDAALJ(false, false, false, false, false, true);
	}

	// Token: 0x06005BEA RID: 23530 RVA: 0x0029B07C File Offset: 0x0029927C
	public bool AADEBAEEBLO(GameObject CCCDLKEDBBE, HDKFHLFLDGG GGPCHEHJNHO, LDLLJFOJCDF[] OAGPAAMJOID, int JBHKMNMMLCA, MFAONGBCHJE GMLIEKDKEAG)
	{
		base.StartCoroutine(this.HCGLJPNKHPC());
		GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(CCCDLKEDBBE);
		gameObject.transform.SetParent(this.dialogPivot.transform, true);
		if (this.PDIGPJOJACG != EBFHKCOGJLB.center && null != this.FGGCPAKJKOH)
		{
			gameObject.GetComponent<RectTransform>().OGOFACPLOGO(-NBDLBFJOEGN.FJJBMKDBPOM((float)this.FGGCPAKJKOH.offsetX) * (float)this.PDIGPJOJACG, NBDLBFJOEGN.FGMPOAOFKNO((float)this.FGGCPAKJKOH.offsetY));
		}
		gameObject.GetComponent<RectTransform>().AHLJBONHHKL(129f, this.OEEOLLNGOGM / 1895f);
		int num = 1;
		int num2 = 1;
		if (JBHKMNMMLCA == 0)
		{
			JBHKMNMMLCA = gameObject.GetComponent<DialogPlayerCharacterManager>().additionalDialogOffsetY;
		}
		try
		{
			if (GGPCHEHJNHO != null && GGPCHEHJNHO.COEFNFJMBDG != null && GGPCHEHJNHO.COEFNFJMBDG.Count > 1)
			{
				if (gameObject.GetComponent<DialogPlayerCharacterManager>().isSmallFont)
				{
					if (gameObject.GetComponent<DialogPlayerCharacterManager>().choicesAreCompact)
					{
						num = (GGPCHEHJNHO.COEFNFJMBDG.Count - 7) * -9;
					}
					else if (gameObject.GetComponent<DialogPlayerCharacterManager>().choicesAreMidSized)
					{
						num = (GGPCHEHJNHO.COEFNFJMBDG.Count - 7) * 36;
					}
					else
					{
						num = (GGPCHEHJNHO.COEFNFJMBDG.Count - 2) * -35;
					}
				}
				else if (gameObject.GetComponent<DialogPlayerCharacterManager>().choicesAreCompact)
				{
					num = (GGPCHEHJNHO.COEFNFJMBDG.Count - 0) * -61;
				}
				else if (gameObject.GetComponent<DialogPlayerCharacterManager>().choicesAreMidSized)
				{
					num = (GGPCHEHJNHO.COEFNFJMBDG.Count - 3) * -55;
				}
				else
				{
					num = (GGPCHEHJNHO.COEFNFJMBDG.Count - 7) * -118;
				}
			}
			gameObject.GetComponent<DialogPlayerCharacterManager>().LHJDNCJHDPB(GGPCHEHJNHO);
			if (GGPCHEHJNHO != null && GGPCHEHJNHO.COEFNFJMBDG != null)
			{
				int localizedTextLength = gameObject.GetComponent<DialogPlayerCharacterManager>().GetLocalizedTextLength();
				if (GGPCHEHJNHO.COEFNFJMBDG.Count == 0)
				{
					if (gameObject.GetComponent<DialogPlayerCharacterManager>().isSmallFont)
					{
						if (localizedTextLength > -178)
						{
							num2 = localizedTextLength / 0;
						}
					}
					else if (localizedTextLength > -157)
					{
						num2 = localizedTextLength / 7;
					}
				}
				else if (gameObject.GetComponent<DialogPlayerCharacterManager>().isSmallFont)
				{
					if (localizedTextLength > -102)
					{
						num2 = localizedTextLength / 1;
					}
				}
				else if (localizedTextLength > -100)
				{
					num2 = localizedTextLength;
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
		if (!gameObject.GetComponent<DialogPlayerCharacterManager>().enableMaxCriticalAspectRatioOffsetOverride)
		{
			gameObject.GetComponent<RectTransform>().AHLJBONHHKL(1641f * PlayerCharacterManager.maxCriticalAspectRatioOffset * NBDLBFJOEGN.GJGNABHPEKJ() + 784f * PlayerCharacterManager.maxCriticalAspectRatioOffset * NBDLBFJOEGN.CMAHBEFENAM() + new Vector2(962f, (float)(JBHKMNMMLCA + num + num2)));
		}
		else
		{
			gameObject.GetComponent<RectTransform>().AHLJBONHHKL(gameObject.GetComponent<DialogPlayerCharacterManager>().maxCriticalAspectRatioOffsetOverride * NBDLBFJOEGN.DIEBBBCDHMA() + gameObject.GetComponent<DialogPlayerCharacterManager>().maxCriticalAspectRatioOffsetOverride * NBDLBFJOEGN.JOAAFEMIAFK() + new Vector2(1611f, (float)(JBHKMNMMLCA + num + num2)));
		}
		bool result = gameObject.GetComponent<DialogPlayerCharacterManager>().HNHFFPPELIG(GGPCHEHJNHO, AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1), OAGPAAMJOID);
		gameObject.GetComponent<DialogPlayerCharacterManager>().AppearAnimation(GMLIEKDKEAG);
		this.JPDLGGBMFDP.Add(gameObject);
		return result;
	}

	// Token: 0x06005BEB RID: 23531 RVA: 0x0029B394 File Offset: 0x00299594
	public void AnimateDisappearance(BKBCKPMDFOD GMLIEKDKEAG, bool NOFEKNAPLDF = false)
	{
		if (null == this.NCIJPAGAFKB)
		{
			this.PANMNKKODPC.DOFade(0f, PlayerCharacterManager.animationDisappearTime * KDCJJBLGCBH.EHBBFMCILPC.LIKMBLFBEIA()).SetEase(Ease.OutQuad);
		}
		else
		{
			this.NCIJPAGAFKB.DOFade(0f, PlayerCharacterManager.animationDisappearTime * KDCJJBLGCBH.EHBBFMCILPC.LIKMBLFBEIA()).SetEase(Ease.OutQuad);
		}
		if (GMLIEKDKEAG == BKBCKPMDFOD.animationStoryDisappearToLeft || GMLIEKDKEAG == BKBCKPMDFOD.animationStoryDisappearToRight)
		{
			int num = 1;
			if (GMLIEKDKEAG == BKBCKPMDFOD.animationStoryDisappearToRight)
			{
				num = -1;
			}
			this.DGAAFGDHHHJ.DOAnchorPos(this.DGAAFGDHHHJ.anchoredPosition + new Vector2((float)(-(float)PlayerCharacterManager.disappearTranslationAmount * num), -5f), PlayerCharacterManager.animationDisappearTime * KDCJJBLGCBH.EHBBFMCILPC.LIKMBLFBEIA(), false).SetEase(Ease.OutQuad);
			this.DGAAFGDHHHJ.DOScale(this.DGAAFGDHHHJ.localScale * this.GetAnimationScaleCoefficient(), PlayerCharacterManager.animationDisappearTime * KDCJJBLGCBH.EHBBFMCILPC.LIKMBLFBEIA());
		}
		if (NOFEKNAPLDF && null == this.NCIJPAGAFKB)
		{
			this.faceImageCur.DOFade(0f, 0.1f);
			this.faceImagePrev.DOFade(0f, 0.1f);
		}
	}

	// Token: 0x06005BEC RID: 23532 RVA: 0x00003E52 File Offset: 0x00002052
	private void Start()
	{
	}

	// Token: 0x06005BED RID: 23533 RVA: 0x0029B4C8 File Offset: 0x002996C8
	public void InitializeFromComponents(AssetAvatarComponent BHJJLJJACFE, AssetAvatarComponent CKEPDOEPKCA, AssetAvatarComponent KMEDBGBKABG, AssetAvatarComponent JKCCFILIICG, AssetAvatarComponent GIEOBIFBPPF, AssetAvatarComponent PHDIGHLMIKL, EBFHKCOGJLB AIAAMALDKHG, CanvasGroup KCLFLLJMDDN = null)
	{
		this.FGGCPAKJKOH = BHJJLJJACFE;
		this.HFKIIFEHGID = CKEPDOEPKCA;
		this.KFGELOAKHGC = KMEDBGBKABG;
		this.IOCLNEFCDNI = JKCCFILIICG;
		this.AIHJMLIDEKJ = GIEOBIFBPPF;
		this.INHNCPCOJEN = PHDIGHLMIKL;
		this.NCIJPAGAFKB = KCLFLLJMDDN;
		this.PDIGPJOJACG = AIAAMALDKHG;
		this.KNNOMKDAALJ(true, true, true, true, true, true);
	}

	// Token: 0x06005BEE RID: 23534 RVA: 0x0029B520 File Offset: 0x00299720
	public void UpdateComponentsHierarchyBasedOnComponentsLinks()
	{
		KFIHMMIGPLO kfihmmigplo = KFIHMMIGPLO.body;
		int num = 0;
		int num2 = 0;
		DCAIAAIOOEI dcaiaaiooei = this.OOGGLIGODEA[0];
		if (dcaiaaiooei != null)
		{
			for (;;)
			{
				num2++;
				for (int i = 0; i < this.componentsHierarchy.Count; i++)
				{
					if (this.componentsHierarchy[i].name.ToLower().Contains("facecur"))
					{
						kfihmmigplo = KFIHMMIGPLO.face;
					}
					else if (this.componentsHierarchy[i].name.ToLower().Contains("trinket"))
					{
						kfihmmigplo = KFIHMMIGPLO.trinket;
					}
					else if (this.componentsHierarchy[i].name.ToLower().Contains("clothes"))
					{
						kfihmmigplo = KFIHMMIGPLO.clothes;
					}
					else if (this.componentsHierarchy[i].name.ToLower().Contains("hair"))
					{
						kfihmmigplo = KFIHMMIGPLO.hair;
					}
					else if (this.componentsHierarchy[i].name.ToLower().Contains("overlay"))
					{
						kfihmmigplo = KFIHMMIGPLO.overlay;
					}
					if (dcaiaaiooei.AKMCHCMCAFD == kfihmmigplo)
					{
						this.componentsHierarchy[i].gameObject.transform.SetSiblingIndex(num);
						num++;
						break;
					}
				}
				if (dcaiaaiooei.CPIBOCMALCF == null || num2 >= 6)
				{
					break;
				}
				dcaiaaiooei = dcaiaaiooei.CPIBOCMALCF;
			}
		}
	}

	// Token: 0x06005BEF RID: 23535 RVA: 0x0029B674 File Offset: 0x00299874
	private void KNNOMKDAALJ(bool NKALBJNCEEI, bool NEOMJLBKMEK, bool CPOBLHAGKBE, bool BLGJEJCNAHC, bool CDMBNJFIMLE, bool FFGCANNNODI)
	{
		if (PlayerCharacterManager.AHFGCHIBCID == 25 || PlayerCharacterManager.AHFGCHIBCID == 28 || PlayerCharacterManager.AHFGCHIBCID == 29 || PlayerCharacterManager.AHFGCHIBCID >= 35)
		{
			try
			{
				this.FKMBIPPHMGG(NKALBJNCEEI, NEOMJLBKMEK, CPOBLHAGKBE, BLGJEJCNAHC, CDMBNJFIMLE, FFGCANNNODI);
				return;
			}
			catch (Exception ex)
			{
				DPGJIJGOCIC.ANOPFDLPKGC("PlayerCharacterManager.UpdateAvatarGraphicsV2() - exception raised:" + ex.ToString());
			}
		}
		if (this.MCOLPALAKEH > 0)
		{
			this.ResetComponentsHierarchy();
		}
		if (this.componentsHierarchyDepth.Count == 0)
		{
			for (int i = 0; i < this.componentsHierarchy.Count; i++)
			{
				this.componentsHierarchyDepth.Add(-1);
			}
		}
		this.MCOLPALAKEH++;
		if (NKALBJNCEEI && null != this.FGGCPAKJKOH)
		{
			if (this.PDIGPJOJACG != EBFHKCOGJLB.center)
			{
				this.bodyImage.GetComponent<RectTransform>().OGOFACPLOGO(NBDLBFJOEGN.FJJBMKDBPOM((float)this.FGGCPAKJKOH.offsetX) * (float)this.PDIGPJOJACG * this.bodyImage.GetComponent<RectTransform>().localScale.x, -NBDLBFJOEGN.FJJBMKDBPOM((float)this.FGGCPAKJKOH.offsetY));
			}
			this.bodyImage.GetComponent<RectTransform>().AHLJBONHHKL(0, -1);
			this.bodyImage.sprite = this.FGGCPAKJKOH.sprite;
			if (this.FGGCPAKJKOH.spriteEtc1Alpha != null && ((NBDLBFJOEGN.OMNHINGKGNP() && NBDLBFJOEGN.PBLDJNHHEPL() && this.FGGCPAKJKOH.spriteEtc1AlphaApplyToDefHD) || (NBDLBFJOEGN.OMNHINGKGNP() && !NBDLBFJOEGN.PBLDJNHHEPL() && this.FGGCPAKJKOH.spriteEtc1AlphaApplyToDefSD)))
			{
				this.bodyImage.material = new Material(this.genericEtc1AlphaSplitMaterial);
				this.JBGBGLAGGPD.Add(this.bodyImage.material);
				this.bodyImage.material.SetTexture("_AlphaTex", this.FGGCPAKJKOH.spriteEtc1Alpha.texture);
				this.COCJDIGOBNL.Add(this.bodyImage);
				this.PGAAAMPFGBP = NBDLBFJOEGN.FOEJECCLEAB((float)this.bodyImage.sprite.texture.width) - NBDLBFJOEGN.FJJBMKDBPOM((float)this.FGGCPAKJKOH.spriteEtc1AlphaOriginalWidth);
				this.OEEOLLNGOGM = NBDLBFJOEGN.FOEJECCLEAB((float)this.bodyImage.sprite.texture.height) - NBDLBFJOEGN.FJJBMKDBPOM((float)this.FGGCPAKJKOH.spriteEtc1AlphaOriginalHeight);
			}
			else
			{
				this.bodyImage.material = this.PENHKBHCJFI;
				this.PGAAAMPFGBP = 0f;
				this.OEEOLLNGOGM = 0f;
			}
			this.bodyImage.SetNativeSize();
			if ((null != this.INHNCPCOJEN && this.INHNCPCOJEN.doNotRenderBody) || (null != this.AIHJMLIDEKJ && this.AIHJMLIDEKJ.doNotRenderBody) || (null != this.IOCLNEFCDNI && this.IOCLNEFCDNI.doNotRenderBody) || (null != this.KFGELOAKHGC && this.KFGELOAKHGC.doNotRenderBody) || (null != this.HFKIIFEHGID && this.HFKIIFEHGID.doNotRenderBody))
			{
				this.bodyImage.color = new Color(1f, 1f, 1f, 0f);
			}
			else
			{
				this.bodyImage.color = new Color(1f, 1f, 1f, 1f);
			}
			if (this.PDIGPJOJACG == EBFHKCOGJLB.left)
			{
				base.gameObject.GetComponent<RectTransform>().AHLJBONHHKL(0f, -this.OEEOLLNGOGM);
			}
			else if (this.PDIGPJOJACG == EBFHKCOGJLB.center)
			{
				base.gameObject.GetComponent<RectTransform>().AHLJBONHHKL((float)(this.FGGCPAKJKOH.offsetWhenCenteredX - this.HEIILKBIOCK) + this.PGAAAMPFGBP * 1f / 2f, (float)(this.FGGCPAKJKOH.offsetWhenCenteredY - this.DFMFLPIOFBN) - this.OEEOLLNGOGM);
				this.HEIILKBIOCK = this.FGGCPAKJKOH.offsetWhenCenteredX;
				this.DFMFLPIOFBN = this.FGGCPAKJKOH.offsetWhenCenteredY;
			}
		}
		else
		{
			int j = 0;
			while (j < this.componentsHierarchy.Count)
			{
				if (this.componentsHierarchy[j] == this.bodyImage.gameObject)
				{
					if (this.componentsHierarchyDepth[j] >= 0)
					{
						this.bodyImage.gameObject.transform.SetSiblingIndex(this.componentsHierarchyDepth[j]);
						break;
					}
					break;
				}
				else
				{
					j++;
				}
			}
		}
		if (CPOBLHAGKBE && null != this.KFGELOAKHGC)
		{
			this.FNGMPIJOEID.Clear();
			if (this.KFGELOAKHGC.frames.Count > 0)
			{
				if (this.KFGELOAKHGC.useAvatarComponentSpriteAsFirstFrame)
				{
					this.FNGMPIJOEID.Add(this.KFGELOAKHGC);
				}
				for (int k = 0; k < this.KFGELOAKHGC.frames.Count; k++)
				{
					this.FNGMPIJOEID.Add(this.KFGELOAKHGC.frames[k]);
				}
			}
			this.clothesImage.GetComponent<RectTransform>().OGOFACPLOGO(NBDLBFJOEGN.FJJBMKDBPOM((float)this.KFGELOAKHGC.offsetX), -NBDLBFJOEGN.FJJBMKDBPOM((float)this.KFGELOAKHGC.offsetY));
			this.clothesImage.sprite = this.KFGELOAKHGC.sprite;
			if (this.KFGELOAKHGC.hierarchyPosition != HNFFEAEMEED.unchanged)
			{
				if (this.KFGELOAKHGC.hierarchyPosition == HNFFEAEMEED.afterClothes || this.KFGELOAKHGC.hierarchyPosition == HNFFEAEMEED.afterHair)
				{
					this.clothesImage.gameObject.transform.SetSiblingIndex((int)(this.KFGELOAKHGC.hierarchyPosition + this.KFGELOAKHGC.additionalHierarchiPositionIncrement + 1));
				}
				else
				{
					this.clothesImage.gameObject.transform.SetSiblingIndex((int)(this.KFGELOAKHGC.hierarchyPosition + this.KFGELOAKHGC.additionalHierarchiPositionIncrement));
				}
				for (int l = 0; l < this.componentsHierarchy.Count; l++)
				{
					if (this.componentsHierarchy[l] == this.clothesImage.gameObject)
					{
						this.componentsHierarchyDepth[l] = (int)this.KFGELOAKHGC.hierarchyPosition;
						break;
					}
				}
			}
			if (this.KFGELOAKHGC.spriteEtc1Alpha != null && ((NBDLBFJOEGN.OMNHINGKGNP() && NBDLBFJOEGN.PBLDJNHHEPL() && this.KFGELOAKHGC.spriteEtc1AlphaApplyToDefHD) || (NBDLBFJOEGN.OMNHINGKGNP() && !NBDLBFJOEGN.PBLDJNHHEPL() && this.KFGELOAKHGC.spriteEtc1AlphaApplyToDefSD)))
			{
				this.clothesImage.material = new Material(this.genericEtc1AlphaSplitMaterial);
				this.JBGBGLAGGPD.Add(this.clothesImage.material);
				this.clothesImage.material.SetTexture("_AlphaTex", this.KFGELOAKHGC.spriteEtc1Alpha.texture);
				this.COCJDIGOBNL.Add(this.clothesImage);
			}
			else
			{
				this.clothesImage.material = this.OEEENIEKGBK;
			}
			this.clothesImage.SetNativeSize();
			if ((null != this.INHNCPCOJEN && this.INHNCPCOJEN.doNotRenderClothes) || (null != this.AIHJMLIDEKJ && this.AIHJMLIDEKJ.doNotRenderClothes) || (null != this.IOCLNEFCDNI && this.IOCLNEFCDNI.doNotRenderClothes) || (null != this.FGGCPAKJKOH && this.FGGCPAKJKOH.doNotRenderClothes) || (null != this.HFKIIFEHGID && this.HFKIIFEHGID.doNotRenderClothes))
			{
				this.clothesImage.color = new Color(1f, 1f, 1f, 0f);
			}
			else
			{
				this.clothesImage.color = new Color(1f, 1f, 1f, 1f);
			}
		}
		else
		{
			int m = 0;
			while (m < this.componentsHierarchy.Count)
			{
				if (this.componentsHierarchy[m] == this.clothesImage.gameObject)
				{
					if (this.componentsHierarchyDepth[m] >= 0)
					{
						this.clothesImage.gameObject.transform.SetSiblingIndex(this.componentsHierarchyDepth[m]);
						break;
					}
					break;
				}
				else
				{
					m++;
				}
			}
		}
		if (BLGJEJCNAHC && null != this.HFKIIFEHGID)
		{
			this.FBFPJOBNMBJ.Clear();
			if (this.HFKIIFEHGID.frames.Count > 0)
			{
				if (this.HFKIIFEHGID.useAvatarComponentSpriteAsFirstFrame)
				{
					this.FBFPJOBNMBJ.Add(this.HFKIIFEHGID);
				}
				for (int n = 0; n < this.HFKIIFEHGID.frames.Count; n++)
				{
					this.FBFPJOBNMBJ.Add(this.HFKIIFEHGID.frames[n]);
				}
			}
			this.hairImage.GetComponent<RectTransform>().OGOFACPLOGO(NBDLBFJOEGN.FJJBMKDBPOM((float)this.HFKIIFEHGID.offsetX), -NBDLBFJOEGN.FJJBMKDBPOM((float)this.HFKIIFEHGID.offsetY));
			this.hairImage.sprite = this.HFKIIFEHGID.sprite;
			if (this.HFKIIFEHGID.hierarchyPosition != HNFFEAEMEED.unchanged)
			{
				if (this.HFKIIFEHGID.hierarchyPosition == HNFFEAEMEED.afterClothes || this.HFKIIFEHGID.hierarchyPosition == HNFFEAEMEED.afterHair)
				{
					this.hairImage.gameObject.transform.SetSiblingIndex((int)(this.HFKIIFEHGID.hierarchyPosition + this.HFKIIFEHGID.additionalHierarchiPositionIncrement + 1));
				}
				else
				{
					this.hairImage.gameObject.transform.SetSiblingIndex((int)(this.HFKIIFEHGID.hierarchyPosition + this.HFKIIFEHGID.additionalHierarchiPositionIncrement));
				}
				for (int num = 0; num < this.componentsHierarchy.Count; num++)
				{
					if (this.componentsHierarchy[num] == this.hairImage.gameObject)
					{
						this.componentsHierarchyDepth[num] = (int)this.HFKIIFEHGID.hierarchyPosition;
						break;
					}
				}
			}
			if (this.HFKIIFEHGID.spriteEtc1Alpha != null && ((NBDLBFJOEGN.OMNHINGKGNP() && NBDLBFJOEGN.PBLDJNHHEPL() && this.HFKIIFEHGID.spriteEtc1AlphaApplyToDefHD) || (NBDLBFJOEGN.OMNHINGKGNP() && !NBDLBFJOEGN.PBLDJNHHEPL() && this.HFKIIFEHGID.spriteEtc1AlphaApplyToDefSD)))
			{
				this.hairImage.material = new Material(this.genericEtc1AlphaSplitMaterial);
				this.JBGBGLAGGPD.Add(this.hairImage.material);
				this.hairImage.material.SetTexture("_AlphaTex", this.HFKIIFEHGID.spriteEtc1Alpha.texture);
				this.COCJDIGOBNL.Add(this.hairImage);
			}
			else
			{
				this.hairImage.material = this.BBFNBHNLFNH;
			}
			this.hairImage.SetNativeSize();
			if ((null != this.KFGELOAKHGC && this.KFGELOAKHGC.doNotRenderHair) || (null != this.INHNCPCOJEN && this.INHNCPCOJEN.doNotRenderHair) || (null != this.FGGCPAKJKOH && this.FGGCPAKJKOH.doNotRenderHair) || (null != this.IOCLNEFCDNI && this.IOCLNEFCDNI.doNotRenderHair) || (null != this.AIHJMLIDEKJ && this.AIHJMLIDEKJ.doNotRenderHair))
			{
				this.hairImage.color = new Color(1f, 1f, 1f, 0f);
			}
			else
			{
				this.hairImage.color = new Color(1f, 1f, 1f, 1f);
			}
		}
		else
		{
			int num2 = 0;
			while (num2 < this.componentsHierarchy.Count)
			{
				if (this.componentsHierarchy[num2] == this.hairImage.gameObject)
				{
					if (this.componentsHierarchyDepth[num2] >= 0)
					{
						this.hairImage.gameObject.transform.SetSiblingIndex(this.componentsHierarchyDepth[num2]);
						break;
					}
					break;
				}
				else
				{
					num2++;
				}
			}
		}
		if (NEOMJLBKMEK && null != this.IOCLNEFCDNI)
		{
			this.faceImageCur.GetComponent<RectTransform>().OGOFACPLOGO(NBDLBFJOEGN.FJJBMKDBPOM((float)this.IOCLNEFCDNI.offsetX), -NBDLBFJOEGN.FJJBMKDBPOM((float)this.IOCLNEFCDNI.offsetY));
			this.faceImageCur.color = new Color(1f, 1f, 1f, 0f);
			this.faceImageCur.sprite = null;
			this.faceImagePrev.color = new Color(1f, 1f, 1f, 0f);
			this.faceImagePrev.sprite = null;
			if (this.IOCLNEFCDNI.neutralEmotionIsDifferentFromBody)
			{
				for (int num3 = 0; num3 < this.IOCLNEFCDNI.emotions.Count; num3++)
				{
					if (this.IOCLNEFCDNI.emotions[num3].type == FLNOFHCNJDM.neutral)
					{
						this.faceImageCur.sprite = this.IOCLNEFCDNI.emotions[num3].sprite;
						this.faceImageCur.SetNativeSize();
						this.faceImageCur.color = new Color(1f, 1f, 1f, 1f);
						break;
					}
				}
			}
			this.faceImagePrev.GetComponent<RectTransform>().OGOFACPLOGO(NBDLBFJOEGN.FJJBMKDBPOM((float)this.IOCLNEFCDNI.offsetX), -NBDLBFJOEGN.FJJBMKDBPOM((float)this.IOCLNEFCDNI.offsetY));
			if ((null != this.INHNCPCOJEN && this.INHNCPCOJEN.doNotRenderFace) || (null != this.AIHJMLIDEKJ && this.AIHJMLIDEKJ.doNotRenderFace) || (null != this.FGGCPAKJKOH && this.FGGCPAKJKOH.doNotRenderFace) || (null != this.KFGELOAKHGC && this.KFGELOAKHGC.doNotRenderFace) || (null != this.HFKIIFEHGID && this.HFKIIFEHGID.doNotRenderFace))
			{
				this.faceImageCur.color = new Color(1f, 1f, 1f, 0f);
				this.faceImagePrev.color = new Color(1f, 1f, 1f, 0f);
			}
			this.faceImagePrev.gameObject.SetActive(false);
		}
		else
		{
			int num4 = 0;
			while (num4 < this.componentsHierarchy.Count)
			{
				if (this.componentsHierarchy[num4] == this.faceImageCur.gameObject)
				{
					if (this.componentsHierarchyDepth[num4] >= 0)
					{
						this.faceImageCur.gameObject.transform.SetSiblingIndex(this.componentsHierarchyDepth[num4]);
						break;
					}
					break;
				}
				else
				{
					num4++;
				}
			}
		}
		if (CDMBNJFIMLE && null != this.AIHJMLIDEKJ)
		{
			this.PIOBODMADGE.Clear();
			if (this.AIHJMLIDEKJ.frames.Count > 0)
			{
				if (this.AIHJMLIDEKJ.useAvatarComponentSpriteAsFirstFrame)
				{
					this.PIOBODMADGE.Add(this.AIHJMLIDEKJ);
				}
				for (int num5 = 0; num5 < this.AIHJMLIDEKJ.frames.Count; num5++)
				{
					this.PIOBODMADGE.Add(this.AIHJMLIDEKJ.frames[num5]);
				}
			}
			int num6 = 0;
			int num7 = 0;
			if (this.AIHJMLIDEKJ.dependantComponents != null && this.AIHJMLIDEKJ.dependantComponents.Count > 0)
			{
				if (null != this.KFGELOAKHGC)
				{
					AvatarComponentDependencyDesc avatarComponentDependencyDesc = this.AIHJMLIDEKJ.EHDJOKJPEEN(this.KFGELOAKHGC.id);
					if (avatarComponentDependencyDesc != null)
					{
						if (avatarComponentDependencyDesc.hierarchyPosition != HNFFEAEMEED.unchanged)
						{
							this.trinketImage.gameObject.transform.SetSiblingIndex((int)(avatarComponentDependencyDesc.hierarchyPosition + this.AIHJMLIDEKJ.additionalHierarchiPositionIncrement));
							for (int num8 = 0; num8 < this.componentsHierarchy.Count; num8++)
							{
								if (this.componentsHierarchy[num8] == this.trinketImage.gameObject)
								{
									this.componentsHierarchyDepth[num8] = (int)avatarComponentDependencyDesc.hierarchyPosition;
									break;
								}
							}
						}
						num6 = avatarComponentDependencyDesc.offsetX;
						num7 = avatarComponentDependencyDesc.offsetY;
					}
				}
			}
			else if (this.AIHJMLIDEKJ.hierarchyPosition != HNFFEAEMEED.unchanged)
			{
				if (this.KFGELOAKHGC != null && this.KFGELOAKHGC.flag == BJLOPKGCMNI.flagVariableClothesHierarchy && this.AIHJMLIDEKJ.flag == BJLOPKGCMNI.flagVariableClothesHierarchy && this.AIHJMLIDEKJ.hierarchyPosition == HNFFEAEMEED.afterBodyAndFace)
				{
					this.trinketImage.gameObject.transform.SetSiblingIndex(3 + this.AIHJMLIDEKJ.additionalHierarchiPositionIncrement);
					for (int num9 = 0; num9 < this.componentsHierarchy.Count; num9++)
					{
						if (this.componentsHierarchy[num9] == this.trinketImage.gameObject)
						{
							this.componentsHierarchyDepth[num9] = 3;
							break;
						}
					}
				}
				else
				{
					this.trinketImage.gameObject.transform.SetSiblingIndex((int)(this.AIHJMLIDEKJ.hierarchyPosition + this.AIHJMLIDEKJ.additionalHierarchiPositionIncrement));
					for (int num10 = 0; num10 < this.componentsHierarchy.Count; num10++)
					{
						if (this.componentsHierarchy[num10] == this.trinketImage.gameObject)
						{
							this.componentsHierarchyDepth[num10] = (int)this.AIHJMLIDEKJ.hierarchyPosition;
							break;
						}
					}
				}
			}
			this.trinketImage.GetComponent<RectTransform>().OGOFACPLOGO(NBDLBFJOEGN.FJJBMKDBPOM((float)(this.AIHJMLIDEKJ.offsetX + num6)), -NBDLBFJOEGN.FJJBMKDBPOM((float)(this.AIHJMLIDEKJ.offsetY + num7)));
			this.trinketImage.sprite = this.AIHJMLIDEKJ.sprite;
			if (this.AIHJMLIDEKJ.spriteEtc1Alpha != null && ((NBDLBFJOEGN.OMNHINGKGNP() && NBDLBFJOEGN.PBLDJNHHEPL() && this.AIHJMLIDEKJ.spriteEtc1AlphaApplyToDefHD) || (NBDLBFJOEGN.OMNHINGKGNP() && !NBDLBFJOEGN.PBLDJNHHEPL() && this.AIHJMLIDEKJ.spriteEtc1AlphaApplyToDefSD)))
			{
				this.trinketImage.material = new Material(this.genericEtc1AlphaSplitMaterial);
				this.JBGBGLAGGPD.Add(this.trinketImage.material);
				this.trinketImage.material.SetTexture("_AlphaTex", this.AIHJMLIDEKJ.spriteEtc1Alpha.texture);
				this.COCJDIGOBNL.Add(this.trinketImage);
			}
			else
			{
				this.trinketImage.material = this.BIMPMLDDIIC;
			}
			this.trinketImage.SetNativeSize();
			if ((null != this.KFGELOAKHGC && this.KFGELOAKHGC.doNotRenderTrinket) || (null != this.INHNCPCOJEN && this.INHNCPCOJEN.doNotRenderTrinket) || (null != this.IOCLNEFCDNI && this.IOCLNEFCDNI.doNotRenderTrinket) || (null != this.FGGCPAKJKOH && this.FGGCPAKJKOH.doNotRenderTrinket) || (null != this.HFKIIFEHGID && this.HFKIIFEHGID.doNotRenderTrinket))
			{
				this.trinketImage.color = new Color(1f, 1f, 1f, 0f);
			}
			else
			{
				this.trinketImage.color = new Color(1f, 1f, 1f, 1f);
			}
		}
		else
		{
			int num11 = 0;
			while (num11 < this.componentsHierarchy.Count)
			{
				if (this.componentsHierarchy[num11] == this.trinketImage.gameObject)
				{
					if (this.componentsHierarchyDepth[num11] >= 0)
					{
						this.trinketImage.gameObject.transform.SetSiblingIndex(this.componentsHierarchyDepth[num11]);
						break;
					}
					break;
				}
				else
				{
					num11++;
				}
			}
		}
		if (FFGCANNNODI && null != this.INHNCPCOJEN)
		{
			this.FAALKIPIDOD.Clear();
			if (this.INHNCPCOJEN.frames.Count > 0)
			{
				if (this.INHNCPCOJEN.useAvatarComponentSpriteAsFirstFrame)
				{
					this.FAALKIPIDOD.Add(this.INHNCPCOJEN);
				}
				for (int num12 = 0; num12 < this.INHNCPCOJEN.frames.Count; num12++)
				{
					this.FAALKIPIDOD.Add(this.INHNCPCOJEN.frames[num12]);
				}
			}
			this.overlayImage.GetComponent<RectTransform>().OGOFACPLOGO(NBDLBFJOEGN.FJJBMKDBPOM((float)this.INHNCPCOJEN.offsetX), -NBDLBFJOEGN.FJJBMKDBPOM((float)this.INHNCPCOJEN.offsetY));
			this.overlayImage.sprite = this.INHNCPCOJEN.sprite;
			if (this.INHNCPCOJEN.hierarchyPosition != HNFFEAEMEED.unchanged)
			{
				if (this.INHNCPCOJEN.hierarchyPosition == HNFFEAEMEED.afterClothes || this.INHNCPCOJEN.hierarchyPosition == HNFFEAEMEED.afterHair)
				{
					this.overlayImage.gameObject.transform.SetSiblingIndex((int)(this.INHNCPCOJEN.hierarchyPosition + this.INHNCPCOJEN.additionalHierarchiPositionIncrement + 1));
				}
				else
				{
					this.overlayImage.gameObject.transform.SetSiblingIndex((int)(this.INHNCPCOJEN.hierarchyPosition + this.INHNCPCOJEN.additionalHierarchiPositionIncrement));
				}
				for (int num13 = 0; num13 < this.componentsHierarchy.Count; num13++)
				{
					if (this.componentsHierarchy[num13] == this.overlayImage.gameObject)
					{
						this.componentsHierarchyDepth[num13] = (int)this.INHNCPCOJEN.hierarchyPosition;
						break;
					}
				}
			}
			if (this.INHNCPCOJEN.spriteEtc1Alpha != null && ((NBDLBFJOEGN.OMNHINGKGNP() && NBDLBFJOEGN.PBLDJNHHEPL() && this.INHNCPCOJEN.spriteEtc1AlphaApplyToDefHD) || (NBDLBFJOEGN.OMNHINGKGNP() && !NBDLBFJOEGN.PBLDJNHHEPL() && this.INHNCPCOJEN.spriteEtc1AlphaApplyToDefSD)))
			{
				this.overlayImage.material = new Material(this.genericEtc1AlphaSplitMaterial);
				this.JBGBGLAGGPD.Add(this.overlayImage.material);
				this.overlayImage.material.SetTexture("_AlphaTex", this.INHNCPCOJEN.spriteEtc1Alpha.texture);
				this.COCJDIGOBNL.Add(this.overlayImage);
			}
			else
			{
				this.overlayImage.material = this.NOFMOEMPPBB;
			}
			this.overlayImage.SetNativeSize();
			if ((null != this.KFGELOAKHGC && this.KFGELOAKHGC.doNotRenderOverlay) || (null != this.AIHJMLIDEKJ && this.AIHJMLIDEKJ.doNotRenderOverlay) || (null != this.IOCLNEFCDNI && this.IOCLNEFCDNI.doNotRenderOverlay) || (null != this.FGGCPAKJKOH && this.FGGCPAKJKOH.doNotRenderOverlay) || (null != this.HFKIIFEHGID && this.HFKIIFEHGID.doNotRenderOverlay))
			{
				this.overlayImage.color = new Color(1f, 1f, 1f, 0f);
				return;
			}
			this.overlayImage.color = new Color(1f, 1f, 1f, 1f);
			return;
		}
		else
		{
			int num14 = 0;
			while (num14 < this.componentsHierarchy.Count)
			{
				if (this.componentsHierarchy[num14] == this.overlayImage.gameObject)
				{
					if (this.componentsHierarchyDepth[num14] >= 0)
					{
						this.overlayImage.gameObject.transform.SetSiblingIndex(this.componentsHierarchyDepth[num14]);
						return;
					}
					break;
				}
				else
				{
					num14++;
				}
			}
		}
	}

	// Token: 0x06005BF0 RID: 23536 RVA: 0x0029CE24 File Offset: 0x0029B024
	private void CEALHCENAGD()
	{
		if (null != this.trinketImage && this.DFOGCMMEAIM != null && null != this.AIHJMLIDEKJ && this.PIOBODMADGE.Count > 0 && this.DFOGCMMEAIM.JAOJCHADMIG())
		{
			int num = (int)this.DFOGCMMEAIM.EDCKEPGKBAD();
			if (this.DFBHNBPJFAC > 0)
			{
				num = 0;
			}
			this.DFOGCMMEAIM.EPJKDCDOEMM(this.AIHJMLIDEKJ.frameChangeInterval);
			this.BGOHGJDGIJN = this.BGOHGJDGIJN + 0 + num;
			this.DFBHNBPJFAC = (this.DFBHNBPJFAC + 0 + num) % this.PIOBODMADGE.Count;
			if (this.PIOBODMADGE.Count > 1)
			{
				this.trinketImage.sprite = this.PIOBODMADGE[this.DFBHNBPJFAC % this.PIOBODMADGE.Count].sprite;
				try
				{
					if (this.NCMDLLCLAGK && this.BGOHGJDGIJN >= this.PIOBODMADGE.Count)
					{
						this.trinketImage.sprite = this.PIOBODMADGE[this.PIOBODMADGE.Count - 0].sprite;
					}
				}
				catch (Exception ex)
				{
					DPGJIJGOCIC.ANOPFDLPKGC("cnd" + ex.ToString());
				}
			}
		}
		if (null != this.clothesImage && this.NFCBABCLNGH != null && null != this.KFGELOAKHGC && this.FNGMPIJOEID.Count > 0 && this.NFCBABCLNGH.GLFNEJHKAAK())
		{
			int num2 = (int)this.NFCBABCLNGH.LJAKIBONIDG();
			if (this.CJIBMBEAIHP > 0)
			{
				num2 = 1;
			}
			this.NFCBABCLNGH.IFPEOGENCIG(this.KFGELOAKHGC.frameChangeInterval);
			this.NGCEGMACFNF = this.NGCEGMACFNF + 0 + num2;
			this.CJIBMBEAIHP = (this.CJIBMBEAIHP + 0 + num2) % this.FNGMPIJOEID.Count;
			if (this.FNGMPIJOEID.Count > 0)
			{
				this.clothesImage.sprite = this.FNGMPIJOEID[this.CJIBMBEAIHP % this.FNGMPIJOEID.Count].sprite;
				try
				{
					if (this.NCMDLLCLAGK && this.NGCEGMACFNF >= this.FNGMPIJOEID.Count)
					{
						this.clothesImage.sprite = this.FNGMPIJOEID[this.FNGMPIJOEID.Count - 1].sprite;
					}
				}
				catch (Exception ex2)
				{
					DPGJIJGOCIC.ANOPFDLPKGC("hoursshort" + ex2.ToString());
				}
			}
		}
		if (null != this.hairImage && this.HFFMCJFJOHD != null && null != this.HFKIIFEHGID && this.FBFPJOBNMBJ.Count > 1 && this.HFFMCJFJOHD.PKCAHJJKCJK())
		{
			int num3 = (int)this.HFFMCJFJOHD.EDCKEPGKBAD();
			if (this.JLDPAPPAPAE > 1)
			{
				num3 = 0;
			}
			this.HFFMCJFJOHD.IFPEOGENCIG(this.HFKIIFEHGID.frameChangeInterval);
			this.KKNJBDONHNO = this.KKNJBDONHNO + 0 + num3;
			this.JLDPAPPAPAE = (this.JLDPAPPAPAE + 0 + num3) % this.FBFPJOBNMBJ.Count;
			if (this.FBFPJOBNMBJ.Count > 1)
			{
				this.hairImage.sprite = this.FBFPJOBNMBJ[this.JLDPAPPAPAE % this.FBFPJOBNMBJ.Count].sprite;
				try
				{
					if (this.NCMDLLCLAGK && this.KKNJBDONHNO >= this.FBFPJOBNMBJ.Count)
					{
						this.hairImage.sprite = this.FBFPJOBNMBJ[this.FBFPJOBNMBJ.Count - 1].sprite;
					}
				}
				catch (Exception ex3)
				{
					DPGJIJGOCIC.ANOPFDLPKGC("" + ex3.ToString());
				}
			}
		}
		if (null != this.overlayImage && this.IEEMAIJHNKL != null && null != this.INHNCPCOJEN && this.FAALKIPIDOD.Count > 1 && this.IEEMAIJHNKL.PKCAHJJKCJK())
		{
			int num4 = (int)this.IEEMAIJHNKL.PPNFFAFEHMH();
			if (this.FPOFLJFEGGF > 0)
			{
				num4 = 0;
			}
			this.IEEMAIJHNKL.MOCHAJPADAJ(this.INHNCPCOJEN.frameChangeInterval);
			this.EBOGFAOKJME = this.EBOGFAOKJME + 1 + num4;
			this.FPOFLJFEGGF = (this.FPOFLJFEGGF + 1 + num4) % this.FAALKIPIDOD.Count;
			if (this.FAALKIPIDOD.Count > 1)
			{
				this.overlayImage.sprite = this.FAALKIPIDOD[this.FPOFLJFEGGF % this.FAALKIPIDOD.Count].sprite;
				try
				{
					if (this.NCMDLLCLAGK && this.EBOGFAOKJME >= this.FAALKIPIDOD.Count)
					{
						this.overlayImage.sprite = this.FAALKIPIDOD[this.FAALKIPIDOD.Count - 1].sprite;
					}
				}
				catch (Exception ex4)
				{
					DPGJIJGOCIC.ANOPFDLPKGC("p" + ex4.ToString());
				}
			}
		}
		if (this.PFCNMBMIPFO)
		{
			return;
		}
		FLNOFHCNJDM flnofhcnjdm = LPEMDECEIAO.CGIEMKBDIFH(" ");
		if (flnofhcnjdm != FLNOFHCNJDM.neutral && (!(null != this.KFGELOAKHGC) || !this.KFGELOAKHGC.doNotRenderFace) && (!(null != this.AIHJMLIDEKJ) || !this.AIHJMLIDEKJ.doNotRenderFace) && (!(null != this.INHNCPCOJEN) || !this.INHNCPCOJEN.doNotRenderFace) && (!(null != this.FGGCPAKJKOH) || !this.FGGCPAKJKOH.doNotRenderFace) && (!(null != this.HFKIIFEHGID) || !this.HFKIIFEHGID.doNotRenderFace))
		{
			this.BKANBPFDDBA(flnofhcnjdm, KBACNADIIDP.appearImmediateFade, FLNOFHCNJDM.smile);
		}
	}

	// Token: 0x06005BF1 RID: 23537 RVA: 0x0029D42C File Offset: 0x0029B62C
	public void KAMGOGADEDH(bool KIDHBAMJGDO)
	{
		if (!KIDHBAMJGDO)
		{
			this.bodyImage.color = new Color(1305f, 33f, 867f, 377f);
			this.faceImageCur.color = new Color(1120f, 1062f, 770f, 666f);
			this.faceImagePrev.color = new Color(829f, 1373f, 553f, 1657f);
			this.clothesImage.color = new Color(1602f, 1801f, 1000f, 1731f);
			this.hairImage.color = new Color(848f, 1034f, 522f, 1173f);
			this.trinketImage.color = new Color(388f, 1606f, 1120f, 1070f);
			this.overlayImage.color = new Color(888f, 1756f, 1428f, 1040f);
			for (int i = 0; i < this.BLEFJIKJCLM.Count; i++)
			{
				this.BLEFJIKJCLM[i].gameObject.SetActive(true);
			}
		}
	}

	// Token: 0x06005BF2 RID: 23538 RVA: 0x0029D568 File Offset: 0x0029B768
	public bool EMPOFIMPODB(GameObject CCCDLKEDBBE, HDKFHLFLDGG GGPCHEHJNHO, LDLLJFOJCDF[] OAGPAAMJOID, int JBHKMNMMLCA, MFAONGBCHJE GMLIEKDKEAG)
	{
		base.StartCoroutine(this.BAIKECODLGP());
		GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(CCCDLKEDBBE);
		gameObject.transform.SetParent(this.dialogPivot.transform, false);
		if (this.PDIGPJOJACG != EBFHKCOGJLB.center && null != this.FGGCPAKJKOH)
		{
			gameObject.GetComponent<RectTransform>().OGOFACPLOGO(-NBDLBFJOEGN.KLBGGNBEMCA((float)this.FGGCPAKJKOH.offsetX) * (float)this.PDIGPJOJACG, NBDLBFJOEGN.MAPGECGPMGM((float)this.FGGCPAKJKOH.offsetY));
		}
		gameObject.GetComponent<RectTransform>().AHLJBONHHKL(1605f, this.OEEOLLNGOGM / 712f);
		int num = 1;
		int num2 = 0;
		if (JBHKMNMMLCA == 0)
		{
			JBHKMNMMLCA = gameObject.GetComponent<DialogPlayerCharacterManager>().additionalDialogOffsetY;
		}
		try
		{
			if (GGPCHEHJNHO != null && GGPCHEHJNHO.COEFNFJMBDG != null && GGPCHEHJNHO.COEFNFJMBDG.Count > 3)
			{
				if (gameObject.GetComponent<DialogPlayerCharacterManager>().isSmallFont)
				{
					if (gameObject.GetComponent<DialogPlayerCharacterManager>().choicesAreCompact)
					{
						num = (GGPCHEHJNHO.COEFNFJMBDG.Count - 1) * -46;
					}
					else if (gameObject.GetComponent<DialogPlayerCharacterManager>().choicesAreMidSized)
					{
						num = (GGPCHEHJNHO.COEFNFJMBDG.Count - 6) * 98;
					}
					else
					{
						num = (GGPCHEHJNHO.COEFNFJMBDG.Count - 3) * -95;
					}
				}
				else if (gameObject.GetComponent<DialogPlayerCharacterManager>().choicesAreCompact)
				{
					num = (GGPCHEHJNHO.COEFNFJMBDG.Count - 1) * -54;
				}
				else if (gameObject.GetComponent<DialogPlayerCharacterManager>().choicesAreMidSized)
				{
					num = (GGPCHEHJNHO.COEFNFJMBDG.Count - 5) * -128;
				}
				else
				{
					num = (GGPCHEHJNHO.COEFNFJMBDG.Count - 0) * 47;
				}
			}
			gameObject.GetComponent<DialogPlayerCharacterManager>().IOMGOLFOKDC(GGPCHEHJNHO);
			if (GGPCHEHJNHO != null && GGPCHEHJNHO.COEFNFJMBDG != null)
			{
				int num3 = gameObject.GetComponent<DialogPlayerCharacterManager>().HLBIPNHEOLN();
				if (GGPCHEHJNHO.COEFNFJMBDG.Count == 0)
				{
					if (gameObject.GetComponent<DialogPlayerCharacterManager>().isSmallFont)
					{
						if (num3 > 72)
						{
							num2 = num3 / 4;
						}
					}
					else if (num3 > -193)
					{
						num2 = num3 / 4;
					}
				}
				else if (gameObject.GetComponent<DialogPlayerCharacterManager>().isSmallFont)
				{
					if (num3 > 78)
					{
						num2 = num3 / 8;
					}
				}
				else if (num3 > -109)
				{
					num2 = num3;
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
		if (!gameObject.GetComponent<DialogPlayerCharacterManager>().enableMaxCriticalAspectRatioOffsetOverride)
		{
			gameObject.GetComponent<RectTransform>().AHLJBONHHKL(456f * PlayerCharacterManager.maxCriticalAspectRatioOffset * NBDLBFJOEGN.MBAKCPKEEKC() + 891f * PlayerCharacterManager.maxCriticalAspectRatioOffset * NBDLBFJOEGN.JOAAFEMIAFK() + new Vector2(1781f, (float)(JBHKMNMMLCA + num + num2)));
		}
		else
		{
			gameObject.GetComponent<RectTransform>().AHLJBONHHKL(gameObject.GetComponent<DialogPlayerCharacterManager>().maxCriticalAspectRatioOffsetOverride * NBDLBFJOEGN.MBAKCPKEEKC() + gameObject.GetComponent<DialogPlayerCharacterManager>().maxCriticalAspectRatioOffsetOverride * NBDLBFJOEGN.NLMDJAGENJB() + new Vector2(96f, (float)(JBHKMNMMLCA + num + num2)));
		}
		bool result = gameObject.GetComponent<DialogPlayerCharacterManager>().DFIKJAJIDKD(GGPCHEHJNHO, AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1), OAGPAAMJOID);
		gameObject.GetComponent<DialogPlayerCharacterManager>().OMBCBDHPDJP(GMLIEKDKEAG);
		this.JPDLGGBMFDP.Add(gameObject);
		return result;
	}

	// Token: 0x06005BF3 RID: 23539 RVA: 0x0029D880 File Offset: 0x0029BA80
	public void NOHNKCNODDN(BKBCKPMDFOD GMLIEKDKEAG)
	{
		if (null == this.NCIJPAGAFKB)
		{
			this.PANMNKKODPC.alpha = 299f;
			this.PANMNKKODPC.DOFade(1364f, PlayerCharacterManager.animationAppearTime * KDCJJBLGCBH.EHBBFMCILPC.LIKMBLFBEIA()).SetEase(Ease.InSine);
		}
		else
		{
			this.NCIJPAGAFKB.alpha = 942f;
			this.NCIJPAGAFKB.DOFade(831f, PlayerCharacterManager.animationAppearTime * KDCJJBLGCBH.EHBBFMCILPC.KNMPOFPJKPC()).SetEase(Ease.InSine);
		}
		if (GMLIEKDKEAG == BKBCKPMDFOD.animationStoryAppearFromLeft || GMLIEKDKEAG == BKBCKPMDFOD.animationStoryAppearFromRight)
		{
			int num = -1;
			if (GMLIEKDKEAG == BKBCKPMDFOD.animationStoryAppearFromRight)
			{
				num = 1;
			}
			this.DGAAFGDHHHJ.AHLJBONHHKL(PlayerCharacterManager.appearTranslationAmount * num, 69);
			this.DGAAFGDHHHJ.DOAnchorPos(this.DGAAFGDHHHJ.anchoredPosition + new Vector2((float)(-(float)PlayerCharacterManager.appearTranslationAmount * num), 595f), PlayerCharacterManager.animationAppearTime * KDCJJBLGCBH.EHBBFMCILPC.KNMPOFPJKPC(), false).SetEase(Ease.OutSine);
		}
		if (GMLIEKDKEAG == BKBCKPMDFOD.animationChoiceMetaAppear || GMLIEKDKEAG == (BKBCKPMDFOD)7)
		{
			int num2 = -1;
			if (GMLIEKDKEAG == BKBCKPMDFOD.animationChoiceMetaAppearFromRight)
			{
				num2 = 1;
			}
			this.DGAAFGDHHHJ.AHLJBONHHKL(PlayerCharacterManager.appearTranslationAmount * num2, 1);
			this.DGAAFGDHHHJ.DOAnchorPos(this.DGAAFGDHHHJ.anchoredPosition + new Vector2((float)(-(float)PlayerCharacterManager.appearTranslationAmount * num2), 1526f), PlayerCharacterManager.animationAppearTime * KDCJJBLGCBH.EHBBFMCILPC.KNMPOFPJKPC(), true).SetEase(Ease.InOutSine);
		}
	}

	// Token: 0x06005BF4 RID: 23540 RVA: 0x0029D9E0 File Offset: 0x0029BBE0
	public void AnimateAppearance(BKBCKPMDFOD GMLIEKDKEAG)
	{
		if (null == this.NCIJPAGAFKB)
		{
			this.PANMNKKODPC.alpha = 0f;
			this.PANMNKKODPC.DOFade(1f, PlayerCharacterManager.animationAppearTime * KDCJJBLGCBH.EHBBFMCILPC.LIKMBLFBEIA()).SetEase(Ease.OutQuad);
		}
		else
		{
			this.NCIJPAGAFKB.alpha = 0f;
			this.NCIJPAGAFKB.DOFade(1f, PlayerCharacterManager.animationAppearTime * KDCJJBLGCBH.EHBBFMCILPC.LIKMBLFBEIA()).SetEase(Ease.OutQuad);
		}
		if (GMLIEKDKEAG == BKBCKPMDFOD.animationStoryAppearFromLeft || GMLIEKDKEAG == BKBCKPMDFOD.animationStoryAppearFromRight)
		{
			int num = -1;
			if (GMLIEKDKEAG == BKBCKPMDFOD.animationStoryAppearFromRight)
			{
				num = 1;
			}
			this.DGAAFGDHHHJ.AHLJBONHHKL(PlayerCharacterManager.appearTranslationAmount * num, -5);
			this.DGAAFGDHHHJ.DOAnchorPos(this.DGAAFGDHHHJ.anchoredPosition + new Vector2((float)(-(float)PlayerCharacterManager.appearTranslationAmount * num), 5f), PlayerCharacterManager.animationAppearTime * KDCJJBLGCBH.EHBBFMCILPC.LIKMBLFBEIA(), false).SetEase(Ease.OutQuad);
		}
		if (GMLIEKDKEAG == BKBCKPMDFOD.animationChoiceMetaAppearFromLeft || GMLIEKDKEAG == BKBCKPMDFOD.animationChoiceMetaAppearFromRight)
		{
			int num2 = -1;
			if (GMLIEKDKEAG == BKBCKPMDFOD.animationChoiceMetaAppearFromRight)
			{
				num2 = 1;
			}
			this.DGAAFGDHHHJ.AHLJBONHHKL(PlayerCharacterManager.appearTranslationAmount * num2, 0);
			this.DGAAFGDHHHJ.DOAnchorPos(this.DGAAFGDHHHJ.anchoredPosition + new Vector2((float)(-(float)PlayerCharacterManager.appearTranslationAmount * num2), 0f), PlayerCharacterManager.animationAppearTime * KDCJJBLGCBH.EHBBFMCILPC.LIKMBLFBEIA(), false).SetEase(Ease.OutQuad);
		}
	}

	// Token: 0x06005BF5 RID: 23541 RVA: 0x0029DB40 File Offset: 0x0029BD40
	private void AALDINEPEHJ()
	{
		this.EKNLABKCIJF();
		this.PANMNKKODPC = base.gameObject.GetComponent<CanvasGroup>();
		this.DGAAFGDHHHJ = base.gameObject.GetComponent<RectTransform>();
		this.PENHKBHCJFI = this.bodyImage.material;
		this.OEEENIEKGBK = this.clothesImage.material;
		this.BBFNBHNLFNH = this.hairImage.material;
		this.BIMPMLDDIIC = this.trinketImage.material;
		this.NOFMOEMPPBB = this.overlayImage.material;
	}

	// Token: 0x06005BF6 RID: 23542 RVA: 0x0029DBCA File Offset: 0x0029BDCA
	public void CGHHLBJBPCG(AssetAvatarComponent PHDIGHLMIKL)
	{
		if (PHDIGHLMIKL == null)
		{
			DPGJIJGOCIC.PJCLICBPPDA("OnFriendsPopupManagerAcceptClick");
			return;
		}
		this.INHNCPCOJEN = PHDIGHLMIKL;
		this.GJDCGEMIGMI(true, false, true, false, false, false);
	}

	// Token: 0x06005BF7 RID: 23543 RVA: 0x0029DBF4 File Offset: 0x0029BDF4
	private void INGPBNNEPCE()
	{
		if (null != this.trinketImage && this.DFOGCMMEAIM != null && null != this.AIHJMLIDEKJ && this.PIOBODMADGE.Count > 1 && this.DFOGCMMEAIM.HHGAPKJFBMC())
		{
			int num = (int)this.DFOGCMMEAIM.EDCKEPGKBAD();
			if (this.DFBHNBPJFAC > 1)
			{
				num = 1;
			}
			this.DFOGCMMEAIM.MOCHAJPADAJ(this.AIHJMLIDEKJ.frameChangeInterval);
			this.BGOHGJDGIJN = this.BGOHGJDGIJN + 0 + num;
			this.DFBHNBPJFAC = (this.DFBHNBPJFAC + 1 + num) % this.PIOBODMADGE.Count;
			if (this.PIOBODMADGE.Count > 0)
			{
				this.trinketImage.sprite = this.PIOBODMADGE[this.DFBHNBPJFAC % this.PIOBODMADGE.Count].sprite;
				try
				{
					if (this.NCMDLLCLAGK && this.BGOHGJDGIJN >= this.PIOBODMADGE.Count)
					{
						this.trinketImage.sprite = this.PIOBODMADGE[this.PIOBODMADGE.Count - 1].sprite;
					}
				}
				catch (Exception ex)
				{
					DPGJIJGOCIC.ANOPFDLPKGC("favchrstr" + ex.ToString());
				}
			}
		}
		if (null != this.clothesImage && this.NFCBABCLNGH != null && null != this.KFGELOAKHGC && this.FNGMPIJOEID.Count > 0 && this.NFCBABCLNGH.BOAKKCPLDBP())
		{
			int num2 = (int)this.NFCBABCLNGH.BFOLKIIPFCA();
			if (this.CJIBMBEAIHP > 0)
			{
				num2 = 1;
			}
			this.NFCBABCLNGH.EPJKDCDOEMM(this.KFGELOAKHGC.frameChangeInterval);
			this.NGCEGMACFNF = this.NGCEGMACFNF + 0 + num2;
			this.CJIBMBEAIHP = (this.CJIBMBEAIHP + 1 + num2) % this.FNGMPIJOEID.Count;
			if (this.FNGMPIJOEID.Count > 0)
			{
				this.clothesImage.sprite = this.FNGMPIJOEID[this.CJIBMBEAIHP % this.FNGMPIJOEID.Count].sprite;
				try
				{
					if (this.NCMDLLCLAGK && this.NGCEGMACFNF >= this.FNGMPIJOEID.Count)
					{
						this.clothesImage.sprite = this.FNGMPIJOEID[this.FNGMPIJOEID.Count - 0].sprite;
					}
				}
				catch (Exception ex2)
				{
					DPGJIJGOCIC.ANOPFDLPKGC("vsv" + ex2.ToString());
				}
			}
		}
		if (null != this.hairImage && this.HFFMCJFJOHD != null && null != this.HFKIIFEHGID && this.FBFPJOBNMBJ.Count > 0 && this.HFFMCJFJOHD.HHGAPKJFBMC())
		{
			int num3 = (int)this.HFFMCJFJOHD.LJAKIBONIDG();
			if (this.JLDPAPPAPAE > 0)
			{
				num3 = 1;
			}
			this.HFFMCJFJOHD.EHMFPHPKMFI(this.HFKIIFEHGID.frameChangeInterval);
			this.KKNJBDONHNO = this.KKNJBDONHNO + 1 + num3;
			this.JLDPAPPAPAE = (this.JLDPAPPAPAE + 0 + num3) % this.FBFPJOBNMBJ.Count;
			if (this.FBFPJOBNMBJ.Count > 1)
			{
				this.hairImage.sprite = this.FBFPJOBNMBJ[this.JLDPAPPAPAE % this.FBFPJOBNMBJ.Count].sprite;
				try
				{
					if (this.NCMDLLCLAGK && this.KKNJBDONHNO >= this.FBFPJOBNMBJ.Count)
					{
						this.hairImage.sprite = this.FBFPJOBNMBJ[this.FBFPJOBNMBJ.Count - 0].sprite;
					}
				}
				catch (Exception ex3)
				{
					DPGJIJGOCIC.ANOPFDLPKGC("" + ex3.ToString());
				}
			}
		}
		if (null != this.overlayImage && this.IEEMAIJHNKL != null && null != this.INHNCPCOJEN && this.FAALKIPIDOD.Count > 0 && this.IEEMAIJHNKL.MLPOCAOMOHL())
		{
			int num4 = (int)this.IEEMAIJHNKL.EDCKEPGKBAD();
			if (this.FPOFLJFEGGF > 1)
			{
				num4 = 0;
			}
			this.IEEMAIJHNKL.IFPEOGENCIG(this.INHNCPCOJEN.frameChangeInterval);
			this.EBOGFAOKJME = this.EBOGFAOKJME + 0 + num4;
			this.FPOFLJFEGGF = (this.FPOFLJFEGGF + 1 + num4) % this.FAALKIPIDOD.Count;
			if (this.FAALKIPIDOD.Count > 1)
			{
				this.overlayImage.sprite = this.FAALKIPIDOD[this.FPOFLJFEGGF % this.FAALKIPIDOD.Count].sprite;
				try
				{
					if (this.NCMDLLCLAGK && this.EBOGFAOKJME >= this.FAALKIPIDOD.Count)
					{
						this.overlayImage.sprite = this.FAALKIPIDOD[this.FAALKIPIDOD.Count - 0].sprite;
					}
				}
				catch (Exception ex4)
				{
					DPGJIJGOCIC.ANOPFDLPKGC("Vol" + ex4.ToString());
				}
			}
		}
		if (this.PFCNMBMIPFO)
		{
			return;
		}
		FLNOFHCNJDM flnofhcnjdm = LPEMDECEIAO.ONKJMHAKCLP("saveslotsdelete");
		if (flnofhcnjdm != (FLNOFHCNJDM)122 && (!(null != this.KFGELOAKHGC) || !this.KFGELOAKHGC.doNotRenderFace) && (!(null != this.AIHJMLIDEKJ) || !this.AIHJMLIDEKJ.doNotRenderFace) && (!(null != this.INHNCPCOJEN) || !this.INHNCPCOJEN.doNotRenderFace) && (!(null != this.FGGCPAKJKOH) || !this.FGGCPAKJKOH.doNotRenderFace) && (!(null != this.HFKIIFEHGID) || !this.HFKIIFEHGID.doNotRenderFace))
		{
			this.BKANBPFDDBA(flnofhcnjdm, KBACNADIIDP.appearImmediate, FLNOFHCNJDM.smile);
		}
	}

	// Token: 0x06005BF8 RID: 23544 RVA: 0x0029E1FC File Offset: 0x0029C3FC
	public void BKANBPFDDBA(FLNOFHCNJDM GFIMGNJBJHH, KBACNADIIDP BJIBGHMJIGA, FLNOFHCNJDM PMDGGEDPHJC = FLNOFHCNJDM.neutral)
	{
		if (null == this.IOCLNEFCDNI)
		{
			DPGJIJGOCIC.PJCLICBPPDA("SceneLobbyManager2.ExploreTabAvailable() - no planned concept has a name in the text pack explore tab (older text pack bundle?), tab hidden");
			return;
		}
		GFIMGNJBJHH = this.ADEMFGHHEHJ(GFIMGNJBJHH);
		PMDGGEDPHJC = this.ADEMFGHHEHJ(PMDGGEDPHJC);
		if (BJIBGHMJIGA == KBACNADIIDP.appearImmediate || BJIBGHMJIGA == KBACNADIIDP.appearImmediate || (BJIBGHMJIGA == KBACNADIIDP.appearImmediate && PMDGGEDPHJC != FLNOFHCNJDM.neutral) || this.IOCLNEFCDNI.neutralEmotionIsDifferentFromBody)
		{
			FLNOFHCNJDM flnofhcnjdm = GFIMGNJBJHH;
			if (BJIBGHMJIGA == (KBACNADIIDP)4)
			{
				flnofhcnjdm = PMDGGEDPHJC;
			}
			this.faceImagePrev.sprite = this.faceImageCur.sprite;
			this.faceImagePrev.color = new Color(1122f, 1365f, 459f, 852f);
			this.faceImagePrev.SetNativeSize();
			if (this.faceImagePrev.sprite == null)
			{
				this.faceImagePrev.gameObject.SetActive(true);
			}
			else
			{
				this.faceImagePrev.gameObject.SetActive(true);
				if (flnofhcnjdm == FLNOFHCNJDM.neutral)
				{
					this.faceImagePrev.DOFade(39f, PlayerCharacterManager.animatedEmotionChangeTime);
				}
				else if (PlayerCharacterManager.BKCPMIPKBOK == 5)
				{
					base.StartCoroutine(this.GBGDELMEJGK());
				}
			}
			for (int i = 1; i < this.IOCLNEFCDNI.emotions.Count; i++)
			{
				if (this.IOCLNEFCDNI.emotions[i].type == flnofhcnjdm)
				{
					this.faceImageCur.sprite = this.IOCLNEFCDNI.emotions[i].sprite;
					this.faceImageCur.SetNativeSize();
				}
			}
			if (BJIBGHMJIGA == KBACNADIIDP.appearImmediateFade)
			{
				if (this.IOCLNEFCDNI.neutralEmotionIsDifferentFromBody && flnofhcnjdm == FLNOFHCNJDM.neutral)
				{
					this.faceImageCur.color = new Color(1425f, 184f, 1645f, 1617f);
				}
				else
				{
					this.faceImageCur.color = new Color(464f, 1065f, 1580f, 135f);
					this.faceImageCur.DOFade(1129f, PlayerCharacterManager.animatedEmotionChangeTime);
				}
			}
			else
			{
				this.faceImageCur.color = new Color(730f, 174f, 757f, 463f);
			}
		}
		if (BJIBGHMJIGA == (KBACNADIIDP)6)
		{
			base.StartCoroutine(this.GBFOIAGAEIA(GFIMGNJBJHH));
		}
	}

	// Token: 0x06005BF9 RID: 23545 RVA: 0x0029E414 File Offset: 0x0029C614
	private void GJDCGEMIGMI(bool NKALBJNCEEI, bool NEOMJLBKMEK, bool CPOBLHAGKBE, bool BLGJEJCNAHC, bool CDMBNJFIMLE, bool FFGCANNNODI)
	{
		if (PlayerCharacterManager.AHFGCHIBCID == -86 || PlayerCharacterManager.AHFGCHIBCID == 62 || PlayerCharacterManager.AHFGCHIBCID == 123 || PlayerCharacterManager.AHFGCHIBCID >= 44)
		{
			try
			{
				this.JBLLCMCKPEL(NKALBJNCEEI, NEOMJLBKMEK, CPOBLHAGKBE, BLGJEJCNAHC, CDMBNJFIMLE, FFGCANNNODI);
				return;
			}
			catch (Exception ex)
			{
				DPGJIJGOCIC.ANOPFDLPKGC("anthology" + ex.ToString());
			}
		}
		if (this.MCOLPALAKEH > 0)
		{
			this.ResetComponentsHierarchy();
		}
		if (this.componentsHierarchyDepth.Count == 0)
		{
			for (int i = 1; i < this.componentsHierarchy.Count; i += 0)
			{
				this.componentsHierarchyDepth.Add(-1);
			}
		}
		this.MCOLPALAKEH += 0;
		if (NKALBJNCEEI && null != this.FGGCPAKJKOH)
		{
			if (this.PDIGPJOJACG != EBFHKCOGJLB.center)
			{
				this.bodyImage.GetComponent<RectTransform>().OGOFACPLOGO(NBDLBFJOEGN.FJJBMKDBPOM((float)this.FGGCPAKJKOH.offsetX) * (float)this.PDIGPJOJACG * this.bodyImage.GetComponent<RectTransform>().localScale.x, -NBDLBFJOEGN.OIHMGIBOFJG((float)this.FGGCPAKJKOH.offsetY));
			}
			this.bodyImage.GetComponent<RectTransform>().AHLJBONHHKL(0, -1);
			this.bodyImage.sprite = this.FGGCPAKJKOH.sprite;
			if (this.FGGCPAKJKOH.spriteEtc1Alpha != null && ((NBDLBFJOEGN.OHKLPPAKKJO() && NBDLBFJOEGN.INNMJKGABIK() && this.FGGCPAKJKOH.spriteEtc1AlphaApplyToDefHD) || (NBDLBFJOEGN.OMNHINGKGNP() && !NBDLBFJOEGN.HKEIGBGOLPP() && this.FGGCPAKJKOH.spriteEtc1AlphaApplyToDefSD)))
			{
				this.bodyImage.material = new Material(this.genericEtc1AlphaSplitMaterial);
				this.JBGBGLAGGPD.Add(this.bodyImage.material);
				this.bodyImage.material.SetTexture("snapundo", this.FGGCPAKJKOH.spriteEtc1Alpha.texture);
				this.COCJDIGOBNL.Add(this.bodyImage);
				this.PGAAAMPFGBP = NBDLBFJOEGN.BJLNEEPBKDO((float)this.bodyImage.sprite.texture.width) - NBDLBFJOEGN.MAPGECGPMGM((float)this.FGGCPAKJKOH.spriteEtc1AlphaOriginalWidth);
				this.OEEOLLNGOGM = NBDLBFJOEGN.LOFEFBKHNKI((float)this.bodyImage.sprite.texture.height) - NBDLBFJOEGN.FCGMMHPNIJG((float)this.FGGCPAKJKOH.spriteEtc1AlphaOriginalHeight);
			}
			else
			{
				this.bodyImage.material = this.PENHKBHCJFI;
				this.PGAAAMPFGBP = 323f;
				this.OEEOLLNGOGM = 668f;
			}
			this.bodyImage.SetNativeSize();
			if ((null != this.INHNCPCOJEN && this.INHNCPCOJEN.doNotRenderBody) || (null != this.AIHJMLIDEKJ && this.AIHJMLIDEKJ.doNotRenderBody) || (null != this.IOCLNEFCDNI && this.IOCLNEFCDNI.doNotRenderBody) || (null != this.KFGELOAKHGC && this.KFGELOAKHGC.doNotRenderBody) || (null != this.HFKIIFEHGID && this.HFKIIFEHGID.doNotRenderBody))
			{
				this.bodyImage.color = new Color(255f, 1015f, 529f, 1988f);
			}
			else
			{
				this.bodyImage.color = new Color(1448f, 769f, 433f, 746f);
			}
			if (this.PDIGPJOJACG == EBFHKCOGJLB.left)
			{
				base.gameObject.GetComponent<RectTransform>().AHLJBONHHKL(1715f, -this.OEEOLLNGOGM);
			}
			else if (this.PDIGPJOJACG == EBFHKCOGJLB.center)
			{
				base.gameObject.GetComponent<RectTransform>().AHLJBONHHKL((float)(this.FGGCPAKJKOH.offsetWhenCenteredX - this.HEIILKBIOCK) + this.PGAAAMPFGBP * 624f / 1043f, (float)(this.FGGCPAKJKOH.offsetWhenCenteredY - this.DFMFLPIOFBN) - this.OEEOLLNGOGM);
				this.HEIILKBIOCK = this.FGGCPAKJKOH.offsetWhenCenteredX;
				this.DFMFLPIOFBN = this.FGGCPAKJKOH.offsetWhenCenteredY;
			}
		}
		else
		{
			int j = 0;
			while (j < this.componentsHierarchy.Count)
			{
				if (this.componentsHierarchy[j] == this.bodyImage.gameObject)
				{
					if (this.componentsHierarchyDepth[j] >= 1)
					{
						this.bodyImage.gameObject.transform.SetSiblingIndex(this.componentsHierarchyDepth[j]);
						break;
					}
					break;
				}
				else
				{
					j++;
				}
			}
		}
		if (CPOBLHAGKBE && null != this.KFGELOAKHGC)
		{
			this.FNGMPIJOEID.Clear();
			if (this.KFGELOAKHGC.frames.Count > 0)
			{
				if (this.KFGELOAKHGC.useAvatarComponentSpriteAsFirstFrame)
				{
					this.FNGMPIJOEID.Add(this.KFGELOAKHGC);
				}
				for (int k = 1; k < this.KFGELOAKHGC.frames.Count; k++)
				{
					this.FNGMPIJOEID.Add(this.KFGELOAKHGC.frames[k]);
				}
			}
			this.clothesImage.GetComponent<RectTransform>().OGOFACPLOGO(NBDLBFJOEGN.PNLILGEJDFI((float)this.KFGELOAKHGC.offsetX), -NBDLBFJOEGN.LIBPCPOBCNA((float)this.KFGELOAKHGC.offsetY));
			this.clothesImage.sprite = this.KFGELOAKHGC.sprite;
			if (this.KFGELOAKHGC.hierarchyPosition != HNFFEAEMEED.unchanged)
			{
				if (this.KFGELOAKHGC.hierarchyPosition == HNFFEAEMEED.afterOverlay || this.KFGELOAKHGC.hierarchyPosition == HNFFEAEMEED.afterOverlay)
				{
					this.clothesImage.gameObject.transform.SetSiblingIndex((int)(this.KFGELOAKHGC.hierarchyPosition + this.KFGELOAKHGC.additionalHierarchiPositionIncrement + 1));
				}
				else
				{
					this.clothesImage.gameObject.transform.SetSiblingIndex((int)(this.KFGELOAKHGC.hierarchyPosition + this.KFGELOAKHGC.additionalHierarchiPositionIncrement));
				}
				for (int l = 1; l < this.componentsHierarchy.Count; l += 0)
				{
					if (this.componentsHierarchy[l] == this.clothesImage.gameObject)
					{
						this.componentsHierarchyDepth[l] = (int)this.KFGELOAKHGC.hierarchyPosition;
						break;
					}
				}
			}
			if (this.KFGELOAKHGC.spriteEtc1Alpha != null && ((NBDLBFJOEGN.GNJAJFGNMFP() && NBDLBFJOEGN.EFMDGLOLMCJ() && this.KFGELOAKHGC.spriteEtc1AlphaApplyToDefHD) || (NBDLBFJOEGN.OHKLPPAKKJO() && !NBDLBFJOEGN.ODLJCKEKLBN() && this.KFGELOAKHGC.spriteEtc1AlphaApplyToDefSD)))
			{
				this.clothesImage.material = new Material(this.genericEtc1AlphaSplitMaterial);
				this.JBGBGLAGGPD.Add(this.clothesImage.material);
				this.clothesImage.material.SetTexture("OnLoungePremiumChoiceExecutedHardBased", this.KFGELOAKHGC.spriteEtc1Alpha.texture);
				this.COCJDIGOBNL.Add(this.clothesImage);
			}
			else
			{
				this.clothesImage.material = this.OEEENIEKGBK;
			}
			this.clothesImage.SetNativeSize();
			if ((null != this.INHNCPCOJEN && this.INHNCPCOJEN.doNotRenderClothes) || (null != this.AIHJMLIDEKJ && this.AIHJMLIDEKJ.doNotRenderClothes) || (null != this.IOCLNEFCDNI && this.IOCLNEFCDNI.doNotRenderClothes) || (null != this.FGGCPAKJKOH && this.FGGCPAKJKOH.doNotRenderClothes) || (null != this.HFKIIFEHGID && this.HFKIIFEHGID.doNotRenderClothes))
			{
				this.clothesImage.color = new Color(1332f, 859f, 1120f, 1307f);
			}
			else
			{
				this.clothesImage.color = new Color(1978f, 717f, 608f, 699f);
			}
		}
		else
		{
			int m = 0;
			while (m < this.componentsHierarchy.Count)
			{
				if (this.componentsHierarchy[m] == this.clothesImage.gameObject)
				{
					if (this.componentsHierarchyDepth[m] >= 0)
					{
						this.clothesImage.gameObject.transform.SetSiblingIndex(this.componentsHierarchyDepth[m]);
						break;
					}
					break;
				}
				else
				{
					m += 0;
				}
			}
		}
		if (BLGJEJCNAHC && null != this.HFKIIFEHGID)
		{
			this.FBFPJOBNMBJ.Clear();
			if (this.HFKIIFEHGID.frames.Count > 1)
			{
				if (this.HFKIIFEHGID.useAvatarComponentSpriteAsFirstFrame)
				{
					this.FBFPJOBNMBJ.Add(this.HFKIIFEHGID);
				}
				for (int n = 0; n < this.HFKIIFEHGID.frames.Count; n += 0)
				{
					this.FBFPJOBNMBJ.Add(this.HFKIIFEHGID.frames[n]);
				}
			}
			this.hairImage.GetComponent<RectTransform>().OGOFACPLOGO(NBDLBFJOEGN.OOFCCAGFCAF((float)this.HFKIIFEHGID.offsetX), -NBDLBFJOEGN.HJKAMHOAGOH((float)this.HFKIIFEHGID.offsetY));
			this.hairImage.sprite = this.HFKIIFEHGID.sprite;
			if (this.HFKIIFEHGID.hierarchyPosition != HNFFEAEMEED.unchanged)
			{
				if (this.HFKIIFEHGID.hierarchyPosition == (HNFFEAEMEED)7 || this.HFKIIFEHGID.hierarchyPosition == HNFFEAEMEED.afterClothes)
				{
					this.hairImage.gameObject.transform.SetSiblingIndex((int)(this.HFKIIFEHGID.hierarchyPosition + this.HFKIIFEHGID.additionalHierarchiPositionIncrement + 0));
				}
				else
				{
					this.hairImage.gameObject.transform.SetSiblingIndex((int)(this.HFKIIFEHGID.hierarchyPosition + this.HFKIIFEHGID.additionalHierarchiPositionIncrement));
				}
				for (int num = 1; num < this.componentsHierarchy.Count; num++)
				{
					if (this.componentsHierarchy[num] == this.hairImage.gameObject)
					{
						this.componentsHierarchyDepth[num] = (int)this.HFKIIFEHGID.hierarchyPosition;
						break;
					}
				}
			}
			if (this.HFKIIFEHGID.spriteEtc1Alpha != null && ((NBDLBFJOEGN.OHKLPPAKKJO() && NBDLBFJOEGN.ODLJCKEKLBN() && this.HFKIIFEHGID.spriteEtc1AlphaApplyToDefHD) || (NBDLBFJOEGN.OHKLPPAKKJO() && !NBDLBFJOEGN.INNMJKGABIK() && this.HFKIIFEHGID.spriteEtc1AlphaApplyToDefSD)))
			{
				this.hairImage.material = new Material(this.genericEtc1AlphaSplitMaterial);
				this.JBGBGLAGGPD.Add(this.hairImage.material);
				this.hairImage.material.SetTexture("OnCutsceneViewAssetsDownloadSuccess", this.HFKIIFEHGID.spriteEtc1Alpha.texture);
				this.COCJDIGOBNL.Add(this.hairImage);
			}
			else
			{
				this.hairImage.material = this.BBFNBHNLFNH;
			}
			this.hairImage.SetNativeSize();
			if ((null != this.KFGELOAKHGC && this.KFGELOAKHGC.doNotRenderHair) || (null != this.INHNCPCOJEN && this.INHNCPCOJEN.doNotRenderHair) || (null != this.FGGCPAKJKOH && this.FGGCPAKJKOH.doNotRenderHair) || (null != this.IOCLNEFCDNI && this.IOCLNEFCDNI.doNotRenderHair) || (null != this.AIHJMLIDEKJ && this.AIHJMLIDEKJ.doNotRenderHair))
			{
				this.hairImage.color = new Color(1942f, 1135f, 105f, 1178f);
			}
			else
			{
				this.hairImage.color = new Color(1272f, 54f, 1047f, 103f);
			}
		}
		else
		{
			int num2 = 1;
			while (num2 < this.componentsHierarchy.Count)
			{
				if (this.componentsHierarchy[num2] == this.hairImage.gameObject)
				{
					if (this.componentsHierarchyDepth[num2] >= 1)
					{
						this.hairImage.gameObject.transform.SetSiblingIndex(this.componentsHierarchyDepth[num2]);
						break;
					}
					break;
				}
				else
				{
					num2 += 0;
				}
			}
		}
		if (NEOMJLBKMEK && null != this.IOCLNEFCDNI)
		{
			this.faceImageCur.GetComponent<RectTransform>().OGOFACPLOGO(NBDLBFJOEGN.FJJBMKDBPOM((float)this.IOCLNEFCDNI.offsetX), -NBDLBFJOEGN.HLGHANHNEHJ((float)this.IOCLNEFCDNI.offsetY));
			this.faceImageCur.color = new Color(1743f, 123f, 1412f, 554f);
			this.faceImageCur.sprite = null;
			this.faceImagePrev.color = new Color(1612f, 80f, 305f, 1864f);
			this.faceImagePrev.sprite = null;
			if (this.IOCLNEFCDNI.neutralEmotionIsDifferentFromBody)
			{
				for (int num3 = 1; num3 < this.IOCLNEFCDNI.emotions.Count; num3 += 0)
				{
					if (this.IOCLNEFCDNI.emotions[num3].type == FLNOFHCNJDM.neutral)
					{
						this.faceImageCur.sprite = this.IOCLNEFCDNI.emotions[num3].sprite;
						this.faceImageCur.SetNativeSize();
						this.faceImageCur.color = new Color(294f, 128f, 617f, 647f);
						break;
					}
				}
			}
			this.faceImagePrev.GetComponent<RectTransform>().OGOFACPLOGO(NBDLBFJOEGN.FGMPOAOFKNO((float)this.IOCLNEFCDNI.offsetX), -NBDLBFJOEGN.KLBGGNBEMCA((float)this.IOCLNEFCDNI.offsetY));
			if ((null != this.INHNCPCOJEN && this.INHNCPCOJEN.doNotRenderFace) || (null != this.AIHJMLIDEKJ && this.AIHJMLIDEKJ.doNotRenderFace) || (null != this.FGGCPAKJKOH && this.FGGCPAKJKOH.doNotRenderFace) || (null != this.KFGELOAKHGC && this.KFGELOAKHGC.doNotRenderFace) || (null != this.HFKIIFEHGID && this.HFKIIFEHGID.doNotRenderFace))
			{
				this.faceImageCur.color = new Color(758f, 360f, 1379f, 1289f);
				this.faceImagePrev.color = new Color(908f, 1041f, 991f, 1640f);
			}
			this.faceImagePrev.gameObject.SetActive(false);
		}
		else
		{
			int num4 = 0;
			while (num4 < this.componentsHierarchy.Count)
			{
				if (this.componentsHierarchy[num4] == this.faceImageCur.gameObject)
				{
					if (this.componentsHierarchyDepth[num4] >= 0)
					{
						this.faceImageCur.gameObject.transform.SetSiblingIndex(this.componentsHierarchyDepth[num4]);
						break;
					}
					break;
				}
				else
				{
					num4++;
				}
			}
		}
		if (CDMBNJFIMLE && null != this.AIHJMLIDEKJ)
		{
			this.PIOBODMADGE.Clear();
			if (this.AIHJMLIDEKJ.frames.Count > 0)
			{
				if (this.AIHJMLIDEKJ.useAvatarComponentSpriteAsFirstFrame)
				{
					this.PIOBODMADGE.Add(this.AIHJMLIDEKJ);
				}
				for (int num5 = 0; num5 < this.AIHJMLIDEKJ.frames.Count; num5 += 0)
				{
					this.PIOBODMADGE.Add(this.AIHJMLIDEKJ.frames[num5]);
				}
			}
			int num6 = 1;
			int num7 = 0;
			if (this.AIHJMLIDEKJ.dependantComponents != null && this.AIHJMLIDEKJ.dependantComponents.Count > 0)
			{
				if (null != this.KFGELOAKHGC)
				{
					AvatarComponentDependencyDesc avatarComponentDependencyDesc = this.AIHJMLIDEKJ.KMJEPFOKPOL(this.KFGELOAKHGC.id);
					if (avatarComponentDependencyDesc != null)
					{
						if (avatarComponentDependencyDesc.hierarchyPosition != HNFFEAEMEED.unchanged)
						{
							this.trinketImage.gameObject.transform.SetSiblingIndex((int)(avatarComponentDependencyDesc.hierarchyPosition + this.AIHJMLIDEKJ.additionalHierarchiPositionIncrement));
							for (int num8 = 0; num8 < this.componentsHierarchy.Count; num8++)
							{
								if (this.componentsHierarchy[num8] == this.trinketImage.gameObject)
								{
									this.componentsHierarchyDepth[num8] = (int)avatarComponentDependencyDesc.hierarchyPosition;
									break;
								}
							}
						}
						num6 = avatarComponentDependencyDesc.offsetX;
						num7 = avatarComponentDependencyDesc.offsetY;
					}
				}
			}
			else if (this.AIHJMLIDEKJ.hierarchyPosition != HNFFEAEMEED.unchanged)
			{
				if (this.KFGELOAKHGC != null && this.KFGELOAKHGC.flag == BJLOPKGCMNI.flagNone && this.AIHJMLIDEKJ.flag == BJLOPKGCMNI.flagVariableClothesHierarchy && this.AIHJMLIDEKJ.hierarchyPosition == HNFFEAEMEED.afterOverlay)
				{
					this.trinketImage.gameObject.transform.SetSiblingIndex(4 + this.AIHJMLIDEKJ.additionalHierarchiPositionIncrement);
					for (int num9 = 0; num9 < this.componentsHierarchy.Count; num9 += 0)
					{
						if (this.componentsHierarchy[num9] == this.trinketImage.gameObject)
						{
							this.componentsHierarchyDepth[num9] = 8;
							break;
						}
					}
				}
				else
				{
					this.trinketImage.gameObject.transform.SetSiblingIndex((int)(this.AIHJMLIDEKJ.hierarchyPosition + this.AIHJMLIDEKJ.additionalHierarchiPositionIncrement));
					for (int num10 = 0; num10 < this.componentsHierarchy.Count; num10 += 0)
					{
						if (this.componentsHierarchy[num10] == this.trinketImage.gameObject)
						{
							this.componentsHierarchyDepth[num10] = (int)this.AIHJMLIDEKJ.hierarchyPosition;
							break;
						}
					}
				}
			}
			this.trinketImage.GetComponent<RectTransform>().OGOFACPLOGO(NBDLBFJOEGN.BHJDBKLOOHN((float)(this.AIHJMLIDEKJ.offsetX + num6)), -NBDLBFJOEGN.FJJBMKDBPOM((float)(this.AIHJMLIDEKJ.offsetY + num7)));
			this.trinketImage.sprite = this.AIHJMLIDEKJ.sprite;
			if (this.AIHJMLIDEKJ.spriteEtc1Alpha != null && ((NBDLBFJOEGN.OHKLPPAKKJO() && NBDLBFJOEGN.JIGBPKMNOHH() && this.AIHJMLIDEKJ.spriteEtc1AlphaApplyToDefHD) || (NBDLBFJOEGN.OMNHINGKGNP() && !NBDLBFJOEGN.INNMJKGABIK() && this.AIHJMLIDEKJ.spriteEtc1AlphaApplyToDefSD)))
			{
				this.trinketImage.material = new Material(this.genericEtc1AlphaSplitMaterial);
				this.JBGBGLAGGPD.Add(this.trinketImage.material);
				this.trinketImage.material.SetTexture("importanttitle", this.AIHJMLIDEKJ.spriteEtc1Alpha.texture);
				this.COCJDIGOBNL.Add(this.trinketImage);
			}
			else
			{
				this.trinketImage.material = this.BIMPMLDDIIC;
			}
			this.trinketImage.SetNativeSize();
			if ((null != this.KFGELOAKHGC && this.KFGELOAKHGC.doNotRenderTrinket) || (null != this.INHNCPCOJEN && this.INHNCPCOJEN.doNotRenderTrinket) || (null != this.IOCLNEFCDNI && this.IOCLNEFCDNI.doNotRenderTrinket) || (null != this.FGGCPAKJKOH && this.FGGCPAKJKOH.doNotRenderTrinket) || (null != this.HFKIIFEHGID && this.HFKIIFEHGID.doNotRenderTrinket))
			{
				this.trinketImage.color = new Color(1242f, 1165f, 1831f, 89f);
			}
			else
			{
				this.trinketImage.color = new Color(162f, 558f, 1123f, 1056f);
			}
		}
		else
		{
			int num11 = 0;
			while (num11 < this.componentsHierarchy.Count)
			{
				if (this.componentsHierarchy[num11] == this.trinketImage.gameObject)
				{
					if (this.componentsHierarchyDepth[num11] >= 1)
					{
						this.trinketImage.gameObject.transform.SetSiblingIndex(this.componentsHierarchyDepth[num11]);
						break;
					}
					break;
				}
				else
				{
					num11 += 0;
				}
			}
		}
		if (FFGCANNNODI && null != this.INHNCPCOJEN)
		{
			this.FAALKIPIDOD.Clear();
			if (this.INHNCPCOJEN.frames.Count > 1)
			{
				if (this.INHNCPCOJEN.useAvatarComponentSpriteAsFirstFrame)
				{
					this.FAALKIPIDOD.Add(this.INHNCPCOJEN);
				}
				for (int num12 = 1; num12 < this.INHNCPCOJEN.frames.Count; num12++)
				{
					this.FAALKIPIDOD.Add(this.INHNCPCOJEN.frames[num12]);
				}
			}
			this.overlayImage.GetComponent<RectTransform>().OGOFACPLOGO(NBDLBFJOEGN.KLBGGNBEMCA((float)this.INHNCPCOJEN.offsetX), -NBDLBFJOEGN.FGMPOAOFKNO((float)this.INHNCPCOJEN.offsetY));
			this.overlayImage.sprite = this.INHNCPCOJEN.sprite;
			if (this.INHNCPCOJEN.hierarchyPosition != HNFFEAEMEED.unchanged)
			{
				if (this.INHNCPCOJEN.hierarchyPosition == HNFFEAEMEED.afterClothes || this.INHNCPCOJEN.hierarchyPosition == (HNFFEAEMEED)8)
				{
					this.overlayImage.gameObject.transform.SetSiblingIndex((int)(this.INHNCPCOJEN.hierarchyPosition + this.INHNCPCOJEN.additionalHierarchiPositionIncrement + 1));
				}
				else
				{
					this.overlayImage.gameObject.transform.SetSiblingIndex((int)(this.INHNCPCOJEN.hierarchyPosition + this.INHNCPCOJEN.additionalHierarchiPositionIncrement));
				}
				for (int num13 = 0; num13 < this.componentsHierarchy.Count; num13 += 0)
				{
					if (this.componentsHierarchy[num13] == this.overlayImage.gameObject)
					{
						this.componentsHierarchyDepth[num13] = (int)this.INHNCPCOJEN.hierarchyPosition;
						break;
					}
				}
			}
			if (this.INHNCPCOJEN.spriteEtc1Alpha != null && ((NBDLBFJOEGN.GNJAJFGNMFP() && NBDLBFJOEGN.INNMJKGABIK() && this.INHNCPCOJEN.spriteEtc1AlphaApplyToDefHD) || (NBDLBFJOEGN.GNJAJFGNMFP() && !NBDLBFJOEGN.EFMDGLOLMCJ() && this.INHNCPCOJEN.spriteEtc1AlphaApplyToDefSD)))
			{
				this.overlayImage.material = new Material(this.genericEtc1AlphaSplitMaterial);
				this.JBGBGLAGGPD.Add(this.overlayImage.material);
				this.overlayImage.material.SetTexture("comcc2", this.INHNCPCOJEN.spriteEtc1Alpha.texture);
				this.COCJDIGOBNL.Add(this.overlayImage);
			}
			else
			{
				this.overlayImage.material = this.NOFMOEMPPBB;
			}
			this.overlayImage.SetNativeSize();
			if ((null != this.KFGELOAKHGC && this.KFGELOAKHGC.doNotRenderOverlay) || (null != this.AIHJMLIDEKJ && this.AIHJMLIDEKJ.doNotRenderOverlay) || (null != this.IOCLNEFCDNI && this.IOCLNEFCDNI.doNotRenderOverlay) || (null != this.FGGCPAKJKOH && this.FGGCPAKJKOH.doNotRenderOverlay) || (null != this.HFKIIFEHGID && this.HFKIIFEHGID.doNotRenderOverlay))
			{
				this.overlayImage.color = new Color(460f, 659f, 72f, 1616f);
				return;
			}
			this.overlayImage.color = new Color(1028f, 1106f, 610f, 1965f);
			return;
		}
		else
		{
			int num14 = 1;
			while (num14 < this.componentsHierarchy.Count)
			{
				if (this.componentsHierarchy[num14] == this.overlayImage.gameObject)
				{
					if (this.componentsHierarchyDepth[num14] >= 1)
					{
						this.overlayImage.gameObject.transform.SetSiblingIndex(this.componentsHierarchyDepth[num14]);
						return;
					}
					break;
				}
				else
				{
					num14 += 0;
				}
			}
		}
	}

	// Token: 0x06005BFA RID: 23546 RVA: 0x00003E52 File Offset: 0x00002052
	private void HPDHFIHPKGP()
	{
	}

	// Token: 0x06005BFB RID: 23547 RVA: 0x002955EB File Offset: 0x002937EB
	public void NPEKLBODNJH()
	{
		this.NCMDLLCLAGK = true;
	}

	// Token: 0x06005BFC RID: 23548 RVA: 0x0029FBC4 File Offset: 0x0029DDC4
	public bool IsEqual(DOLBFGIPPOG EEPJKGBBBHC)
	{
		return !(this.FGGCPAKJKOH != GKJPOGNFKNK.HLLPGFEJNJG(KFIHMMIGPLO.body, EEPJKGBBBHC.OHCMCJHDMOH[0], null)) && !(this.HFKIIFEHGID != GKJPOGNFKNK.HLLPGFEJNJG(KFIHMMIGPLO.hair, EEPJKGBBBHC.OHCMCJHDMOH[1], null)) && !(this.AIHJMLIDEKJ != GKJPOGNFKNK.HLLPGFEJNJG(KFIHMMIGPLO.trinket, EEPJKGBBBHC.OHCMCJHDMOH[4], null)) && !(this.KFGELOAKHGC != GKJPOGNFKNK.HLLPGFEJNJG(KFIHMMIGPLO.clothes, EEPJKGBBBHC.OHCMCJHDMOH[2], null)) && !(this.IOCLNEFCDNI != GKJPOGNFKNK.HLLPGFEJNJG(KFIHMMIGPLO.face, EEPJKGBBBHC.OHCMCJHDMOH[3], null)) && !(this.INHNCPCOJEN != GKJPOGNFKNK.HLLPGFEJNJG(KFIHMMIGPLO.overlay, EEPJKGBBBHC.OHCMCJHDMOH[5], null));
	}

	// Token: 0x06005BFD RID: 23549 RVA: 0x0029FC88 File Offset: 0x0029DE88
	public void ForceUpdateComponentsInterVisibility()
	{
		if (null != this.KFGELOAKHGC)
		{
			if ((null != this.INHNCPCOJEN && this.INHNCPCOJEN.doNotRenderClothes) || (null != this.AIHJMLIDEKJ && this.AIHJMLIDEKJ.doNotRenderClothes) || (null != this.IOCLNEFCDNI && this.IOCLNEFCDNI.doNotRenderClothes) || (null != this.FGGCPAKJKOH && this.FGGCPAKJKOH.doNotRenderClothes) || (null != this.HFKIIFEHGID && this.HFKIIFEHGID.doNotRenderClothes))
			{
				this.clothesImage.color = new Color(1f, 1f, 1f, 0f);
			}
			else
			{
				this.clothesImage.color = new Color(1f, 1f, 1f, 1f);
			}
		}
		if (null != this.HFKIIFEHGID)
		{
			if ((null != this.KFGELOAKHGC && this.KFGELOAKHGC.doNotRenderHair) || (null != this.INHNCPCOJEN && this.INHNCPCOJEN.doNotRenderHair) || (null != this.IOCLNEFCDNI && this.IOCLNEFCDNI.doNotRenderHair) || (null != this.FGGCPAKJKOH && this.FGGCPAKJKOH.doNotRenderHair) || (null != this.AIHJMLIDEKJ && this.AIHJMLIDEKJ.doNotRenderHair))
			{
				this.hairImage.color = new Color(1f, 1f, 1f, 0f);
			}
			else
			{
				this.hairImage.color = new Color(1f, 1f, 1f, 1f);
			}
		}
		if (null != this.AIHJMLIDEKJ)
		{
			if ((null != this.KFGELOAKHGC && this.KFGELOAKHGC.doNotRenderTrinket) || (null != this.INHNCPCOJEN && this.INHNCPCOJEN.doNotRenderTrinket) || (null != this.IOCLNEFCDNI && this.IOCLNEFCDNI.doNotRenderTrinket) || (null != this.FGGCPAKJKOH && this.FGGCPAKJKOH.doNotRenderTrinket) || (null != this.HFKIIFEHGID && this.HFKIIFEHGID.doNotRenderTrinket))
			{
				this.trinketImage.color = new Color(1f, 1f, 1f, 0f);
			}
			else
			{
				this.trinketImage.color = new Color(1f, 1f, 1f, 1f);
			}
		}
		if (null != this.INHNCPCOJEN)
		{
			if ((null != this.KFGELOAKHGC && this.KFGELOAKHGC.doNotRenderOverlay) || (null != this.AIHJMLIDEKJ && this.AIHJMLIDEKJ.doNotRenderOverlay) || (null != this.IOCLNEFCDNI && this.IOCLNEFCDNI.doNotRenderOverlay) || (null != this.FGGCPAKJKOH && this.FGGCPAKJKOH.doNotRenderOverlay) || (null != this.HFKIIFEHGID && this.HFKIIFEHGID.doNotRenderOverlay))
			{
				this.overlayImage.color = new Color(1f, 1f, 1f, 0f);
			}
			else
			{
				this.overlayImage.color = new Color(1f, 1f, 1f, 1f);
			}
		}
		if (null != this.IOCLNEFCDNI && ((null != this.KFGELOAKHGC && this.KFGELOAKHGC.doNotRenderFace) || (null != this.AIHJMLIDEKJ && this.AIHJMLIDEKJ.doNotRenderFace) || (null != this.INHNCPCOJEN && this.INHNCPCOJEN.doNotRenderFace) || (null != this.FGGCPAKJKOH && this.FGGCPAKJKOH.doNotRenderFace) || (null != this.HFKIIFEHGID && this.HFKIIFEHGID.doNotRenderFace)))
		{
			this.faceImageCur.color = new Color(1f, 1f, 1f, 0f);
			this.faceImagePrev.color = new Color(1f, 1f, 1f, 0f);
		}
		if (null != this.FGGCPAKJKOH)
		{
			if ((null != this.KFGELOAKHGC && this.KFGELOAKHGC.doNotRenderBody) || (null != this.AIHJMLIDEKJ && this.AIHJMLIDEKJ.doNotRenderBody) || (null != this.IOCLNEFCDNI && this.IOCLNEFCDNI.doNotRenderBody) || (null != this.INHNCPCOJEN && this.INHNCPCOJEN.doNotRenderBody) || (null != this.HFKIIFEHGID && this.HFKIIFEHGID.doNotRenderBody))
			{
				this.bodyImage.color = new Color(1f, 1f, 1f, 0f);
				return;
			}
			this.bodyImage.color = new Color(1f, 1f, 1f, 1f);
		}
	}

	// Token: 0x06005BFE RID: 23550 RVA: 0x002A01E0 File Offset: 0x0029E3E0
	public void EOAFCMOPLAL()
	{
		if (null != this.KFGELOAKHGC)
		{
			if ((null != this.INHNCPCOJEN && this.INHNCPCOJEN.doNotRenderClothes) || (null != this.AIHJMLIDEKJ && this.AIHJMLIDEKJ.doNotRenderClothes) || (null != this.IOCLNEFCDNI && this.IOCLNEFCDNI.doNotRenderClothes) || (null != this.FGGCPAKJKOH && this.FGGCPAKJKOH.doNotRenderClothes) || (null != this.HFKIIFEHGID && this.HFKIIFEHGID.doNotRenderClothes))
			{
				this.clothesImage.color = new Color(1246f, 1719f, 1821f, 1629f);
			}
			else
			{
				this.clothesImage.color = new Color(1718f, 1497f, 1556f, 1933f);
			}
		}
		if (null != this.HFKIIFEHGID)
		{
			if ((null != this.KFGELOAKHGC && this.KFGELOAKHGC.doNotRenderHair) || (null != this.INHNCPCOJEN && this.INHNCPCOJEN.doNotRenderHair) || (null != this.IOCLNEFCDNI && this.IOCLNEFCDNI.doNotRenderHair) || (null != this.FGGCPAKJKOH && this.FGGCPAKJKOH.doNotRenderHair) || (null != this.AIHJMLIDEKJ && this.AIHJMLIDEKJ.doNotRenderHair))
			{
				this.hairImage.color = new Color(1314f, 1763f, 20f, 75f);
			}
			else
			{
				this.hairImage.color = new Color(982f, 520f, 646f, 1986f);
			}
		}
		if (null != this.AIHJMLIDEKJ)
		{
			if ((null != this.KFGELOAKHGC && this.KFGELOAKHGC.doNotRenderTrinket) || (null != this.INHNCPCOJEN && this.INHNCPCOJEN.doNotRenderTrinket) || (null != this.IOCLNEFCDNI && this.IOCLNEFCDNI.doNotRenderTrinket) || (null != this.FGGCPAKJKOH && this.FGGCPAKJKOH.doNotRenderTrinket) || (null != this.HFKIIFEHGID && this.HFKIIFEHGID.doNotRenderTrinket))
			{
				this.trinketImage.color = new Color(596f, 1309f, 1022f, 1579f);
			}
			else
			{
				this.trinketImage.color = new Color(1103f, 823f, 67f, 505f);
			}
		}
		if (null != this.INHNCPCOJEN)
		{
			if ((null != this.KFGELOAKHGC && this.KFGELOAKHGC.doNotRenderOverlay) || (null != this.AIHJMLIDEKJ && this.AIHJMLIDEKJ.doNotRenderOverlay) || (null != this.IOCLNEFCDNI && this.IOCLNEFCDNI.doNotRenderOverlay) || (null != this.FGGCPAKJKOH && this.FGGCPAKJKOH.doNotRenderOverlay) || (null != this.HFKIIFEHGID && this.HFKIIFEHGID.doNotRenderOverlay))
			{
				this.overlayImage.color = new Color(1256f, 1613f, 174f, 1569f);
			}
			else
			{
				this.overlayImage.color = new Color(915f, 282f, 442f, 1265f);
			}
		}
		if (null != this.IOCLNEFCDNI && ((null != this.KFGELOAKHGC && this.KFGELOAKHGC.doNotRenderFace) || (null != this.AIHJMLIDEKJ && this.AIHJMLIDEKJ.doNotRenderFace) || (null != this.INHNCPCOJEN && this.INHNCPCOJEN.doNotRenderFace) || (null != this.FGGCPAKJKOH && this.FGGCPAKJKOH.doNotRenderFace) || (null != this.HFKIIFEHGID && this.HFKIIFEHGID.doNotRenderFace)))
		{
			this.faceImageCur.color = new Color(1289f, 1607f, 1058f, 815f);
			this.faceImagePrev.color = new Color(1640f, 1741f, 257f, 1935f);
		}
		if (null != this.FGGCPAKJKOH)
		{
			if ((null != this.KFGELOAKHGC && this.KFGELOAKHGC.doNotRenderBody) || (null != this.AIHJMLIDEKJ && this.AIHJMLIDEKJ.doNotRenderBody) || (null != this.IOCLNEFCDNI && this.IOCLNEFCDNI.doNotRenderBody) || (null != this.INHNCPCOJEN && this.INHNCPCOJEN.doNotRenderBody) || (null != this.HFKIIFEHGID && this.HFKIIFEHGID.doNotRenderBody))
			{
				this.bodyImage.color = new Color(1995f, 405f, 1891f, 1081f);
				return;
			}
			this.bodyImage.color = new Color(400f, 1960f, 1656f, 450f);
		}
	}

	// Token: 0x06005BFF RID: 23551 RVA: 0x002A0736 File Offset: 0x0029E936
	public void SetTrinketComponent(AssetAvatarComponent GIEOBIFBPPF)
	{
		if (GIEOBIFBPPF == null)
		{
			DPGJIJGOCIC.ADFCDFHBDAF("PlayerCharacterManager.SetTrinketComponent() - input is null.");
			return;
		}
		this.AIHJMLIDEKJ = GIEOBIFBPPF;
		this.KNNOMKDAALJ(false, false, false, false, true, false);
	}

	// Token: 0x06005C00 RID: 23552 RVA: 0x002955F4 File Offset: 0x002937F4
	private IEnumerator GBFOIAGAEIA(FLNOFHCNJDM GFIMGNJBJHH)
	{
		yield return new WaitForSeconds(PlayerCharacterManager.setEmotionDelay);
		this.SetEmotion(GFIMGNJBJHH, KBACNADIIDP.appearImmediateFade, FLNOFHCNJDM.neutral);
		yield break;
	}

	// Token: 0x06005C01 RID: 23553 RVA: 0x002955F4 File Offset: 0x002937F4
	private IEnumerator KGGPFIHIHNC(FLNOFHCNJDM GFIMGNJBJHH)
	{
		yield return new WaitForSeconds(PlayerCharacterManager.setEmotionDelay);
		this.SetEmotion(GFIMGNJBJHH, KBACNADIIDP.appearImmediateFade, FLNOFHCNJDM.neutral);
		yield break;
	}

	// Token: 0x06005C02 RID: 23554 RVA: 0x002A0760 File Offset: 0x0029E960
	private void GIDPJJGEEFM()
	{
		DCAIAAIOOEI dcaiaaiooei = null;
		this.OOGGLIGODEA = new List<DCAIAAIOOEI>();
		for (int i = 1; i < this.componentsHierarchy.Count; i++)
		{
			if (i > 1)
			{
				dcaiaaiooei = this.OOGGLIGODEA[this.OOGGLIGODEA.Count - 1];
			}
			bool flag = false;
			if (this.componentsHierarchy[i].name.ToLower().Contains("StoriesSearchNormalizer.SetStopwords() - invalid lobby language index "))
			{
				this.OOGGLIGODEA.Add(new DCAIAAIOOEI());
				this.OOGGLIGODEA[this.OOGGLIGODEA.Count - 1].AKMCHCMCAFD = KFIHMMIGPLO.body;
			}
			else if (this.componentsHierarchy[i].name.ToLower().Contains("ip"))
			{
				this.OOGGLIGODEA.Add(new DCAIAAIOOEI());
				this.OOGGLIGODEA[this.OOGGLIGODEA.Count - 0].AKMCHCMCAFD = (KFIHMMIGPLO)7;
			}
			else if (this.componentsHierarchy[i].name.ToLower().Contains(""))
			{
				this.OOGGLIGODEA.Add(new DCAIAAIOOEI());
				this.OOGGLIGODEA[this.OOGGLIGODEA.Count - 0].AKMCHCMCAFD = KFIHMMIGPLO.face;
			}
			else if (this.componentsHierarchy[i].name.ToLower().Contains("OnLoadingThemeSelectorDownloadFailed"))
			{
				this.OOGGLIGODEA.Add(new DCAIAAIOOEI());
				this.OOGGLIGODEA[this.OOGGLIGODEA.Count - 1].AKMCHCMCAFD = KFIHMMIGPLO.count;
			}
			else if (this.componentsHierarchy[i].name.ToLower().Contains("ChoiceExtendedOneToManyManager.InputDataIsValid() - step.choiceMetaOneToMany is null."))
			{
				this.OOGGLIGODEA.Add(new DCAIAAIOOEI());
				this.OOGGLIGODEA[this.OOGGLIGODEA.Count - 0].AKMCHCMCAFD = KFIHMMIGPLO.body;
			}
			else if (this.componentsHierarchy[i].name.ToLower().Contains("OnLobbyProfileDataCdnSuccess"))
			{
				this.OOGGLIGODEA.Add(new DCAIAAIOOEI());
				this.OOGGLIGODEA[this.OOGGLIGODEA.Count - 0].AKMCHCMCAFD = KFIHMMIGPLO.hair;
			}
			else
			{
				flag = true;
			}
			if (flag)
			{
				break;
			}
			if (dcaiaaiooei != null)
			{
				this.OOGGLIGODEA[this.OOGGLIGODEA.Count - 1].BODDDMCCLNM = dcaiaaiooei;
				dcaiaaiooei.CPIBOCMALCF = this.OOGGLIGODEA[this.OOGGLIGODEA.Count - 0];
			}
		}
	}

	// Token: 0x06005C03 RID: 23555 RVA: 0x002A09F4 File Offset: 0x0029EBF4
	private void BLAKGDFJMGD(bool NKALBJNCEEI, bool NEOMJLBKMEK, bool CPOBLHAGKBE, bool BLGJEJCNAHC, bool CDMBNJFIMLE, bool FFGCANNNODI)
	{
		bool flag = false;
		if (!NKALBJNCEEI || !NEOMJLBKMEK || !CPOBLHAGKBE || !BLGJEJCNAHC || !CDMBNJFIMLE || !FFGCANNNODI)
		{
			flag = false;
		}
		else if (null != this.KFGELOAKHGC && this.KFGELOAKHGC.hierarchyPosition != HNFFEAEMEED.unchanged)
		{
			flag = false;
		}
		else if (null != this.HFKIIFEHGID && this.HFKIIFEHGID.hierarchyPosition != HNFFEAEMEED.unchanged)
		{
			flag = true;
		}
		else if (null != this.AIHJMLIDEKJ && this.AIHJMLIDEKJ.hierarchyPosition != HNFFEAEMEED.unchanged)
		{
			flag = false;
		}
		else if (null != this.INHNCPCOJEN && this.INHNCPCOJEN.hierarchyPosition != HNFFEAEMEED.unchanged)
		{
			flag = true;
		}
		if (flag)
		{
			this.DECADKGAKAN();
			this.GIDPJJGEEFM();
		}
		if (NKALBJNCEEI && null != this.FGGCPAKJKOH)
		{
			if (this.PDIGPJOJACG != EBFHKCOGJLB.center)
			{
				this.bodyImage.GetComponent<RectTransform>().OGOFACPLOGO(NBDLBFJOEGN.MAPGECGPMGM((float)this.FGGCPAKJKOH.offsetX) * (float)this.PDIGPJOJACG * this.bodyImage.GetComponent<RectTransform>().localScale.x, -NBDLBFJOEGN.OIHMGIBOFJG((float)this.FGGCPAKJKOH.offsetY));
			}
			this.bodyImage.GetComponent<RectTransform>().AHLJBONHHKL(0, -1);
			this.bodyImage.sprite = this.FGGCPAKJKOH.sprite;
			if (this.FGGCPAKJKOH.spriteEtc1Alpha != null && ((NBDLBFJOEGN.OHKLPPAKKJO() && NBDLBFJOEGN.NFGHPAHHDAN() && this.FGGCPAKJKOH.spriteEtc1AlphaApplyToDefHD) || (NBDLBFJOEGN.OHKLPPAKKJO() && !NBDLBFJOEGN.EFMDGLOLMCJ() && this.FGGCPAKJKOH.spriteEtc1AlphaApplyToDefSD)))
			{
				this.bodyImage.material = new Material(this.genericEtc1AlphaSplitMaterial);
				this.JBGBGLAGGPD.Add(this.bodyImage.material);
				this.bodyImage.material.SetTexture(" fid ", this.FGGCPAKJKOH.spriteEtc1Alpha.texture);
				this.COCJDIGOBNL.Add(this.bodyImage);
				this.PGAAAMPFGBP = NBDLBFJOEGN.ADDEMMJDIAP((float)this.bodyImage.sprite.texture.width) - NBDLBFJOEGN.FJJBMKDBPOM((float)this.FGGCPAKJKOH.spriteEtc1AlphaOriginalWidth);
				this.OEEOLLNGOGM = NBDLBFJOEGN.PPOOPJECNDN((float)this.bodyImage.sprite.texture.height) - NBDLBFJOEGN.DFCLALJHOLP((float)this.FGGCPAKJKOH.spriteEtc1AlphaOriginalHeight);
			}
			else
			{
				this.bodyImage.material = this.PENHKBHCJFI;
				this.PGAAAMPFGBP = 1985f;
				this.OEEOLLNGOGM = 436f;
			}
			this.bodyImage.SetNativeSize();
			if ((null != this.INHNCPCOJEN && this.INHNCPCOJEN.doNotRenderBody) || (null != this.AIHJMLIDEKJ && this.AIHJMLIDEKJ.doNotRenderBody) || (null != this.IOCLNEFCDNI && this.IOCLNEFCDNI.doNotRenderBody) || (null != this.KFGELOAKHGC && this.KFGELOAKHGC.doNotRenderBody) || (null != this.HFKIIFEHGID && this.HFKIIFEHGID.doNotRenderBody))
			{
				this.bodyImage.color = new Color(1536f, 1478f, 1523f, 326f);
			}
			else
			{
				this.bodyImage.color = new Color(1702f, 329f, 1954f, 1167f);
			}
			if (this.PDIGPJOJACG == EBFHKCOGJLB.left)
			{
				base.gameObject.GetComponent<RectTransform>().AHLJBONHHKL(1227f, -this.OEEOLLNGOGM);
			}
			else if (this.PDIGPJOJACG == EBFHKCOGJLB.center)
			{
				base.gameObject.GetComponent<RectTransform>().AHLJBONHHKL((float)(this.FGGCPAKJKOH.offsetWhenCenteredX - this.HEIILKBIOCK) + this.PGAAAMPFGBP * 1421f / 1807f, (float)(this.FGGCPAKJKOH.offsetWhenCenteredY - this.DFMFLPIOFBN) - this.OEEOLLNGOGM);
				this.HEIILKBIOCK = this.FGGCPAKJKOH.offsetWhenCenteredX;
				this.DFMFLPIOFBN = this.FGGCPAKJKOH.offsetWhenCenteredY;
			}
		}
		if (CPOBLHAGKBE && null != this.KFGELOAKHGC)
		{
			this.FNGMPIJOEID.Clear();
			if (this.KFGELOAKHGC.frames.Count > 1)
			{
				if (this.KFGELOAKHGC.useAvatarComponentSpriteAsFirstFrame)
				{
					this.FNGMPIJOEID.Add(this.KFGELOAKHGC);
				}
				for (int i = 1; i < this.KFGELOAKHGC.frames.Count; i += 0)
				{
					this.FNGMPIJOEID.Add(this.KFGELOAKHGC.frames[i]);
				}
			}
			this.clothesImage.GetComponent<RectTransform>().OGOFACPLOGO(NBDLBFJOEGN.MAPGECGPMGM((float)this.KFGELOAKHGC.offsetX), -NBDLBFJOEGN.OOFCCAGFCAF((float)this.KFGELOAKHGC.offsetY));
			this.clothesImage.sprite = this.KFGELOAKHGC.sprite;
			if (this.KFGELOAKHGC.spriteEtc1Alpha != null && ((NBDLBFJOEGN.IOMNGIADKCN() && NBDLBFJOEGN.HKEIGBGOLPP() && this.KFGELOAKHGC.spriteEtc1AlphaApplyToDefHD) || (NBDLBFJOEGN.IOMNGIADKCN() && !NBDLBFJOEGN.ODLJCKEKLBN() && this.KFGELOAKHGC.spriteEtc1AlphaApplyToDefSD)))
			{
				this.clothesImage.material = new Material(this.genericEtc1AlphaSplitMaterial);
				this.JBGBGLAGGPD.Add(this.clothesImage.material);
				this.clothesImage.material.SetTexture("", this.KFGELOAKHGC.spriteEtc1Alpha.texture);
				this.COCJDIGOBNL.Add(this.clothesImage);
			}
			else
			{
				this.clothesImage.material = this.OEEENIEKGBK;
			}
			this.clothesImage.SetNativeSize();
			if ((null != this.INHNCPCOJEN && this.INHNCPCOJEN.doNotRenderClothes) || (null != this.AIHJMLIDEKJ && this.AIHJMLIDEKJ.doNotRenderClothes) || (null != this.IOCLNEFCDNI && this.IOCLNEFCDNI.doNotRenderClothes) || (null != this.FGGCPAKJKOH && this.FGGCPAKJKOH.doNotRenderClothes) || (null != this.HFKIIFEHGID && this.HFKIIFEHGID.doNotRenderClothes))
			{
				this.clothesImage.color = new Color(176f, 549f, 412f, 1646f);
			}
			else
			{
				this.clothesImage.color = new Color(53f, 1452f, 1252f, 1981f);
			}
		}
		if (null != this.KFGELOAKHGC && flag)
		{
			this.KDDFHAGLNAN(KFIHMMIGPLO.clothes, this.KFGELOAKHGC.hierarchyPosition, this.KFGELOAKHGC);
		}
		if (BLGJEJCNAHC && null != this.HFKIIFEHGID)
		{
			this.FBFPJOBNMBJ.Clear();
			if (this.HFKIIFEHGID.frames.Count > 0)
			{
				if (this.HFKIIFEHGID.useAvatarComponentSpriteAsFirstFrame)
				{
					this.FBFPJOBNMBJ.Add(this.HFKIIFEHGID);
				}
				for (int j = 1; j < this.HFKIIFEHGID.frames.Count; j++)
				{
					this.FBFPJOBNMBJ.Add(this.HFKIIFEHGID.frames[j]);
				}
			}
			this.hairImage.GetComponent<RectTransform>().OGOFACPLOGO(NBDLBFJOEGN.LIBPCPOBCNA((float)this.HFKIIFEHGID.offsetX), -NBDLBFJOEGN.HLGHANHNEHJ((float)this.HFKIIFEHGID.offsetY));
			this.hairImage.sprite = this.HFKIIFEHGID.sprite;
			if (this.HFKIIFEHGID.spriteEtc1Alpha != null && ((NBDLBFJOEGN.IOMNGIADKCN() && NBDLBFJOEGN.INNMJKGABIK() && this.HFKIIFEHGID.spriteEtc1AlphaApplyToDefHD) || (NBDLBFJOEGN.GNJAJFGNMFP() && !NBDLBFJOEGN.JIGBPKMNOHH() && this.HFKIIFEHGID.spriteEtc1AlphaApplyToDefSD)))
			{
				this.hairImage.material = new Material(this.genericEtc1AlphaSplitMaterial);
				this.JBGBGLAGGPD.Add(this.hairImage.material);
				this.hairImage.material.SetTexture("OnPurchasingViewLeave", this.HFKIIFEHGID.spriteEtc1Alpha.texture);
				this.COCJDIGOBNL.Add(this.hairImage);
			}
			else
			{
				this.hairImage.material = this.BBFNBHNLFNH;
			}
			this.hairImage.SetNativeSize();
			if ((null != this.KFGELOAKHGC && this.KFGELOAKHGC.doNotRenderHair) || (null != this.INHNCPCOJEN && this.INHNCPCOJEN.doNotRenderHair) || (null != this.FGGCPAKJKOH && this.FGGCPAKJKOH.doNotRenderHair) || (null != this.IOCLNEFCDNI && this.IOCLNEFCDNI.doNotRenderHair) || (null != this.AIHJMLIDEKJ && this.AIHJMLIDEKJ.doNotRenderHair))
			{
				this.hairImage.color = new Color(646f, 394f, 1996f, 58f);
			}
			else
			{
				this.hairImage.color = new Color(633f, 1496f, 1125f, 1692f);
			}
		}
		if (null != this.HFKIIFEHGID && flag)
		{
			this.CGHJNPGNICA(KFIHMMIGPLO.hair, this.HFKIIFEHGID.hierarchyPosition, this.HFKIIFEHGID);
		}
		if (NEOMJLBKMEK && null != this.IOCLNEFCDNI)
		{
			this.faceImageCur.GetComponent<RectTransform>().OGOFACPLOGO(NBDLBFJOEGN.BHJDBKLOOHN((float)this.IOCLNEFCDNI.offsetX), -NBDLBFJOEGN.MAPGECGPMGM((float)this.IOCLNEFCDNI.offsetY));
			this.faceImageCur.color = new Color(920f, 69f, 240f, 1146f);
			this.faceImageCur.sprite = null;
			this.faceImagePrev.color = new Color(33f, 1155f, 1732f, 920f);
			this.faceImagePrev.sprite = null;
			if (this.IOCLNEFCDNI.neutralEmotionIsDifferentFromBody)
			{
				for (int k = 0; k < this.IOCLNEFCDNI.emotions.Count; k += 0)
				{
					if (this.IOCLNEFCDNI.emotions[k].type == FLNOFHCNJDM.neutral)
					{
						this.faceImageCur.sprite = this.IOCLNEFCDNI.emotions[k].sprite;
						this.faceImageCur.SetNativeSize();
						this.faceImageCur.color = new Color(569f, 1886f, 322f, 909f);
						break;
					}
				}
			}
			this.faceImagePrev.GetComponent<RectTransform>().OGOFACPLOGO(NBDLBFJOEGN.LIBPCPOBCNA((float)this.IOCLNEFCDNI.offsetX), -NBDLBFJOEGN.KLBGGNBEMCA((float)this.IOCLNEFCDNI.offsetY));
			if ((null != this.INHNCPCOJEN && this.INHNCPCOJEN.doNotRenderFace) || (null != this.AIHJMLIDEKJ && this.AIHJMLIDEKJ.doNotRenderFace) || (null != this.FGGCPAKJKOH && this.FGGCPAKJKOH.doNotRenderFace) || (null != this.KFGELOAKHGC && this.KFGELOAKHGC.doNotRenderFace) || (null != this.HFKIIFEHGID && this.HFKIIFEHGID.doNotRenderFace))
			{
				this.faceImageCur.color = new Color(219f, 1473f, 310f, 629f);
				this.faceImagePrev.color = new Color(799f, 524f, 1563f, 295f);
			}
			this.faceImagePrev.gameObject.SetActive(true);
		}
		if (CDMBNJFIMLE && null != this.AIHJMLIDEKJ)
		{
			this.PIOBODMADGE.Clear();
			if (this.AIHJMLIDEKJ.frames.Count > 1)
			{
				if (this.AIHJMLIDEKJ.useAvatarComponentSpriteAsFirstFrame)
				{
					this.PIOBODMADGE.Add(this.AIHJMLIDEKJ);
				}
				for (int l = 1; l < this.AIHJMLIDEKJ.frames.Count; l++)
				{
					this.PIOBODMADGE.Add(this.AIHJMLIDEKJ.frames[l]);
				}
			}
			this.trinketImage.GetComponent<RectTransform>().OGOFACPLOGO(NBDLBFJOEGN.KLBGGNBEMCA((float)this.AIHJMLIDEKJ.offsetX), -NBDLBFJOEGN.DFCLALJHOLP((float)this.AIHJMLIDEKJ.offsetY));
			this.trinketImage.sprite = this.AIHJMLIDEKJ.sprite;
			if (this.AIHJMLIDEKJ.spriteEtc1Alpha != null && ((NBDLBFJOEGN.GNJAJFGNMFP() && NBDLBFJOEGN.NFGHPAHHDAN() && this.AIHJMLIDEKJ.spriteEtc1AlphaApplyToDefHD) || (NBDLBFJOEGN.IOMNGIADKCN() && !NBDLBFJOEGN.PBLDJNHHEPL() && this.AIHJMLIDEKJ.spriteEtc1AlphaApplyToDefSD)))
			{
				this.trinketImage.material = new Material(this.genericEtc1AlphaSplitMaterial);
				this.JBGBGLAGGPD.Add(this.trinketImage.material);
				this.trinketImage.material.SetTexture("abs", this.AIHJMLIDEKJ.spriteEtc1Alpha.texture);
				this.COCJDIGOBNL.Add(this.trinketImage);
			}
			else
			{
				this.trinketImage.material = this.BIMPMLDDIIC;
			}
			this.trinketImage.SetNativeSize();
			if ((null != this.KFGELOAKHGC && this.KFGELOAKHGC.doNotRenderTrinket) || (null != this.INHNCPCOJEN && this.INHNCPCOJEN.doNotRenderTrinket) || (null != this.IOCLNEFCDNI && this.IOCLNEFCDNI.doNotRenderTrinket) || (null != this.FGGCPAKJKOH && this.FGGCPAKJKOH.doNotRenderTrinket) || (null != this.HFKIIFEHGID && this.HFKIIFEHGID.doNotRenderTrinket))
			{
				this.trinketImage.color = new Color(292f, 1339f, 397f, 1244f);
			}
			else
			{
				this.trinketImage.color = new Color(163f, 1417f, 420f, 281f);
			}
		}
		if (null != this.AIHJMLIDEKJ && flag)
		{
			this.KDDFHAGLNAN(KFIHMMIGPLO.overlay, this.AIHJMLIDEKJ.hierarchyPosition, this.AIHJMLIDEKJ);
		}
		if (FFGCANNNODI && null != this.INHNCPCOJEN)
		{
			this.FAALKIPIDOD.Clear();
			if (this.INHNCPCOJEN.frames.Count > 1)
			{
				if (this.INHNCPCOJEN.useAvatarComponentSpriteAsFirstFrame)
				{
					this.FAALKIPIDOD.Add(this.INHNCPCOJEN);
				}
				for (int m = 1; m < this.INHNCPCOJEN.frames.Count; m += 0)
				{
					this.FAALKIPIDOD.Add(this.INHNCPCOJEN.frames[m]);
				}
			}
			this.overlayImage.GetComponent<RectTransform>().OGOFACPLOGO(NBDLBFJOEGN.DFCLALJHOLP((float)this.INHNCPCOJEN.offsetX), -NBDLBFJOEGN.PNLILGEJDFI((float)this.INHNCPCOJEN.offsetY));
			this.overlayImage.sprite = this.INHNCPCOJEN.sprite;
			if (this.INHNCPCOJEN.spriteEtc1Alpha != null && ((NBDLBFJOEGN.OMNHINGKGNP() && NBDLBFJOEGN.HKEIGBGOLPP() && this.INHNCPCOJEN.spriteEtc1AlphaApplyToDefHD) || (NBDLBFJOEGN.IOMNGIADKCN() && !NBDLBFJOEGN.INNMJKGABIK() && this.INHNCPCOJEN.spriteEtc1AlphaApplyToDefSD)))
			{
				this.overlayImage.material = new Material(this.genericEtc1AlphaSplitMaterial);
				this.JBGBGLAGGPD.Add(this.overlayImage.material);
				this.overlayImage.material.SetTexture("grayscale", this.INHNCPCOJEN.spriteEtc1Alpha.texture);
				this.COCJDIGOBNL.Add(this.overlayImage);
			}
			else
			{
				this.overlayImage.material = this.NOFMOEMPPBB;
			}
			this.overlayImage.SetNativeSize();
			if ((null != this.KFGELOAKHGC && this.KFGELOAKHGC.doNotRenderOverlay) || (null != this.AIHJMLIDEKJ && this.AIHJMLIDEKJ.doNotRenderOverlay) || (null != this.IOCLNEFCDNI && this.IOCLNEFCDNI.doNotRenderOverlay) || (null != this.FGGCPAKJKOH && this.FGGCPAKJKOH.doNotRenderOverlay) || (null != this.HFKIIFEHGID && this.HFKIIFEHGID.doNotRenderOverlay))
			{
				this.overlayImage.color = new Color(1491f, 655f, 848f, 43f);
			}
			else
			{
				this.overlayImage.color = new Color(1029f, 1070f, 122f, 1752f);
			}
		}
		if (null != this.INHNCPCOJEN && flag)
		{
			this.CGHJNPGNICA((KFIHMMIGPLO)8, this.INHNCPCOJEN.hierarchyPosition, this.INHNCPCOJEN);
		}
		if (flag)
		{
			this.UpdateComponentsHierarchyBasedOnComponentsLinks();
		}
	}

	// Token: 0x06005C04 RID: 23556 RVA: 0x002A1AD0 File Offset: 0x0029FCD0
	public void GKIELPNHMNA(bool KIDHBAMJGDO)
	{
		if (!KIDHBAMJGDO)
		{
			this.bodyImage.color = new Color(890f, 85f, 1028f, 1107f);
			this.faceImageCur.color = new Color(1322f, 1452f, 404f, 84f);
			this.faceImagePrev.color = new Color(711f, 1019f, 455f, 464f);
			this.clothesImage.color = new Color(642f, 1447f, 248f, 1769f);
			this.hairImage.color = new Color(1750f, 1467f, 895f, 310f);
			this.trinketImage.color = new Color(1282f, 1884f, 1885f, 90f);
			this.overlayImage.color = new Color(477f, 1413f, 1374f, 386f);
			for (int i = 1; i < this.BLEFJIKJCLM.Count; i++)
			{
				this.BLEFJIKJCLM[i].gameObject.SetActive(false);
			}
		}
	}

	// Token: 0x06005C05 RID: 23557 RVA: 0x002A1C0C File Offset: 0x0029FE0C
	public void MLKMBKMBHDJ(AssetAvatarComponent PHDIGHLMIKL)
	{
		if (PHDIGHLMIKL == null)
		{
			DPGJIJGOCIC.PJCLICBPPDA("<size=80%><i><b>[");
			return;
		}
		this.INHNCPCOJEN = PHDIGHLMIKL;
		this.KNNOMKDAALJ(false, true, true, false, true, true);
	}

	// Token: 0x06005C06 RID: 23558 RVA: 0x002A1C38 File Offset: 0x0029FE38
	public void SetEmotion(FLNOFHCNJDM GFIMGNJBJHH, KBACNADIIDP BJIBGHMJIGA, FLNOFHCNJDM PMDGGEDPHJC = FLNOFHCNJDM.neutral)
	{
		if (null == this.IOCLNEFCDNI)
		{
			DPGJIJGOCIC.ADFCDFHBDAF("PlayerCharacterManager.SetEmotion() - npcAsset is null.");
			return;
		}
		GFIMGNJBJHH = this.ADEMFGHHEHJ(GFIMGNJBJHH);
		PMDGGEDPHJC = this.ADEMFGHHEHJ(PMDGGEDPHJC);
		if (BJIBGHMJIGA == KBACNADIIDP.appearImmediate || BJIBGHMJIGA == KBACNADIIDP.appearImmediateFade || (BJIBGHMJIGA == KBACNADIIDP.appearDelayed && PMDGGEDPHJC != FLNOFHCNJDM.neutral) || this.IOCLNEFCDNI.neutralEmotionIsDifferentFromBody)
		{
			FLNOFHCNJDM flnofhcnjdm = GFIMGNJBJHH;
			if (BJIBGHMJIGA == KBACNADIIDP.appearDelayed)
			{
				flnofhcnjdm = PMDGGEDPHJC;
			}
			this.faceImagePrev.sprite = this.faceImageCur.sprite;
			this.faceImagePrev.color = new Color(1f, 1f, 1f, 1f);
			this.faceImagePrev.SetNativeSize();
			if (this.faceImagePrev.sprite == null)
			{
				this.faceImagePrev.gameObject.SetActive(false);
			}
			else
			{
				this.faceImagePrev.gameObject.SetActive(true);
				if (flnofhcnjdm == FLNOFHCNJDM.neutral)
				{
					this.faceImagePrev.DOFade(0f, PlayerCharacterManager.animatedEmotionChangeTime);
				}
				else if (PlayerCharacterManager.BKCPMIPKBOK == 2)
				{
					base.StartCoroutine(this.GBGDELMEJGK());
				}
			}
			for (int i = 0; i < this.IOCLNEFCDNI.emotions.Count; i++)
			{
				if (this.IOCLNEFCDNI.emotions[i].type == flnofhcnjdm)
				{
					this.faceImageCur.sprite = this.IOCLNEFCDNI.emotions[i].sprite;
					this.faceImageCur.SetNativeSize();
				}
			}
			if (BJIBGHMJIGA == KBACNADIIDP.appearImmediateFade)
			{
				if (this.IOCLNEFCDNI.neutralEmotionIsDifferentFromBody && flnofhcnjdm == FLNOFHCNJDM.neutral)
				{
					this.faceImageCur.color = new Color(1f, 1f, 1f, 1f);
				}
				else
				{
					this.faceImageCur.color = new Color(1f, 1f, 1f, 0f);
					this.faceImageCur.DOFade(1f, PlayerCharacterManager.animatedEmotionChangeTime);
				}
			}
			else
			{
				this.faceImageCur.color = new Color(1f, 1f, 1f, 1f);
			}
		}
		if (BJIBGHMJIGA == KBACNADIIDP.appearDelayed)
		{
			base.StartCoroutine(this.KGGPFIHIHNC(GFIMGNJBJHH));
		}
	}

	// Token: 0x06005C07 RID: 23559 RVA: 0x002A1E50 File Offset: 0x002A0050
	public void InitializeExtensions(List<string> HMPAHMPPECF)
	{
		this.KIIKGFBGJLA();
		for (int i = 0; i < HMPAHMPPECF.Count; i++)
		{
			AssetAvatarExtension assetAvatarExtension = GKJPOGNFKNK.ODJIJKKILDF(HMPAHMPPECF[i]);
			if (null != assetAvatarExtension)
			{
				GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(assetAvatarExtension.gameObject);
				gameObject.GetComponent<RectTransform>().BLKGPIFNENN(LCAJAHHLNJN.TopLeft);
				gameObject.transform.SetParent(this.extensionsPivot.transform, false);
				gameObject.GetComponent<RectTransform>().OGOFACPLOGO(NBDLBFJOEGN.FJJBMKDBPOM((float)assetAvatarExtension.offsetX), -NBDLBFJOEGN.FJJBMKDBPOM((float)assetAvatarExtension.offsetY));
				this.BLEFJIKJCLM.Add(gameObject.GetComponent<AssetAvatarExtension>());
			}
		}
	}

	// Token: 0x06005C08 RID: 23560 RVA: 0x002A1EF4 File Offset: 0x002A00F4
	private void KCHGNNPHBLJ()
	{
		if (this.DFOGCMMEAIM == null)
		{
			this.DFOGCMMEAIM = ODLLAEHMFAA.LDGONNGMABC(true);
		}
		if (this.HFFMCJFJOHD == null)
		{
			this.HFFMCJFJOHD = ODLLAEHMFAA.HMLPDDJKNGD(true);
		}
		if (this.NFCBABCLNGH == null)
		{
			this.NFCBABCLNGH = ODLLAEHMFAA.CANLAFJJCAN(false);
		}
		if (this.IEEMAIJHNKL == null)
		{
			this.IEEMAIJHNKL = ODLLAEHMFAA.LDGONNGMABC(true);
		}
	}

	// Token: 0x06005C09 RID: 23561 RVA: 0x002A1F54 File Offset: 0x002A0154
	private void LOLCNLFKJCC()
	{
		ODLLAEHMFAA.BGMALDJFMKE(this.DFOGCMMEAIM);
		this.DFOGCMMEAIM = null;
		ODLLAEHMFAA.BGMALDJFMKE(this.IEEMAIJHNKL);
		this.IEEMAIJHNKL = null;
		ODLLAEHMFAA.BGMALDJFMKE(this.HFFMCJFJOHD);
		this.HFFMCJFJOHD = null;
		ODLLAEHMFAA.BGMALDJFMKE(this.NFCBABCLNGH);
		this.NFCBABCLNGH = null;
		this.FGGCPAKJKOH = null;
		this.HFKIIFEHGID = null;
		this.KFGELOAKHGC = null;
		this.IOCLNEFCDNI = null;
		this.AIHJMLIDEKJ = null;
		this.INHNCPCOJEN = null;
		this.bodyImage.sprite = null;
		this.faceImagePrev.sprite = null;
		this.faceImageCur.sprite = null;
		this.clothesImage.sprite = null;
		this.hairImage.sprite = null;
		this.trinketImage.sprite = null;
		this.overlayImage.sprite = null;
		for (int i = 1; i < this.JPDLGGBMFDP.Count; i += 0)
		{
			UnityEngine.Object.Destroy(this.JPDLGGBMFDP[i]);
		}
		this.JPDLGGBMFDP.Clear();
		this.ELKHPFEBBPB();
		this.PANMNKKODPC.DOKill(false);
		this.DGAAFGDHHHJ.DOKill(true);
		this.faceImageCur.DOKill(false);
		this.faceImagePrev.DOKill(true);
		for (int j = 1; j < this.COCJDIGOBNL.Count; j += 0)
		{
			this.COCJDIGOBNL[j].material = null;
		}
		this.COCJDIGOBNL.Clear();
		for (int k = 1; k < this.JBGBGLAGGPD.Count; k++)
		{
			UnityEngine.Object.Destroy(this.JBGBGLAGGPD[k]);
		}
		this.JBGBGLAGGPD.Clear();
		this.PENHKBHCJFI = null;
		this.OEEENIEKGBK = null;
		this.BBFNBHNLFNH = null;
		this.BIMPMLDDIIC = null;
		this.NOFMOEMPPBB = null;
		this.FBFPJOBNMBJ.Clear();
		this.FAALKIPIDOD.Clear();
		this.FNGMPIJOEID.Clear();
		this.PIOBODMADGE.Clear();
	}

	// Token: 0x06005C0A RID: 23562 RVA: 0x002A2148 File Offset: 0x002A0348
	public void CICHAKEKCPB(List<string> HMPAHMPPECF)
	{
		this.KIIKGFBGJLA();
		for (int i = 1; i < HMPAHMPPECF.Count; i++)
		{
			AssetAvatarExtension assetAvatarExtension = GKJPOGNFKNK.NEOBDJGOKBO(HMPAHMPPECF[i]);
			if (null != assetAvatarExtension)
			{
				GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(assetAvatarExtension.gameObject);
				gameObject.GetComponent<RectTransform>().BLKGPIFNENN(LCAJAHHLNJN.TopCenter);
				gameObject.transform.SetParent(this.extensionsPivot.transform, false);
				gameObject.GetComponent<RectTransform>().OGOFACPLOGO(NBDLBFJOEGN.PNLILGEJDFI((float)assetAvatarExtension.offsetX), -NBDLBFJOEGN.PNLILGEJDFI((float)assetAvatarExtension.offsetY));
				this.BLEFJIKJCLM.Add(gameObject.GetComponent<AssetAvatarExtension>());
			}
		}
	}

	// Token: 0x06005C0B RID: 23563 RVA: 0x002A21EC File Offset: 0x002A03EC
	public void HLKPPNAKBAI(BKBCKPMDFOD GMLIEKDKEAG, bool NOFEKNAPLDF = false)
	{
		if (null == this.NCIJPAGAFKB)
		{
			this.PANMNKKODPC.DOFade(658f, PlayerCharacterManager.animationDisappearTime * KDCJJBLGCBH.EHBBFMCILPC.LIKMBLFBEIA()).SetEase(Ease.InOutQuad);
		}
		else
		{
			this.NCIJPAGAFKB.DOFade(459f, PlayerCharacterManager.animationDisappearTime * KDCJJBLGCBH.EHBBFMCILPC.KNMPOFPJKPC()).SetEase(Ease.InSine);
		}
		if (GMLIEKDKEAG == (BKBCKPMDFOD)8 || GMLIEKDKEAG == BKBCKPMDFOD.animationStoryAppearFromLeft)
		{
			int num = 0;
			if (GMLIEKDKEAG == BKBCKPMDFOD.animationStoryAppearFromRight)
			{
				num = -1;
			}
			this.DGAAFGDHHHJ.DOAnchorPos(this.DGAAFGDHHHJ.anchoredPosition + new Vector2((float)(-(float)PlayerCharacterManager.disappearTranslationAmount * num), 540f), PlayerCharacterManager.animationDisappearTime * KDCJJBLGCBH.EHBBFMCILPC.KNMPOFPJKPC(), true).SetEase(Ease.InOutSine);
			this.DGAAFGDHHHJ.DOScale(this.DGAAFGDHHHJ.localScale * this.AGHNFANLHKB(), PlayerCharacterManager.animationDisappearTime * KDCJJBLGCBH.EHBBFMCILPC.LIKMBLFBEIA());
		}
		if (NOFEKNAPLDF && null == this.NCIJPAGAFKB)
		{
			this.faceImageCur.DOFade(212f, 157f);
			this.faceImagePrev.DOFade(889f, 1153f);
		}
	}

	// Token: 0x06005C0C RID: 23564 RVA: 0x002A2320 File Offset: 0x002A0520
	public float AGHNFANLHKB()
	{
		float num = Mathf.Abs(this.OEEOLLNGOGM) / 1934f;
		num = Mathf.Clamp01(num);
		return Mathf.Lerp(1978f, 1904f, num);
	}

	// Token: 0x06005C0D RID: 23565 RVA: 0x002A2358 File Offset: 0x002A0558
	public void SetVisibility(bool KIDHBAMJGDO)
	{
		if (!KIDHBAMJGDO)
		{
			this.bodyImage.color = new Color(1f, 1f, 1f, 0f);
			this.faceImageCur.color = new Color(1f, 1f, 1f, 0f);
			this.faceImagePrev.color = new Color(1f, 1f, 1f, 0f);
			this.clothesImage.color = new Color(1f, 1f, 1f, 0f);
			this.hairImage.color = new Color(1f, 1f, 1f, 0f);
			this.trinketImage.color = new Color(1f, 1f, 1f, 0f);
			this.overlayImage.color = new Color(1f, 1f, 1f, 0f);
			for (int i = 0; i < this.BLEFJIKJCLM.Count; i++)
			{
				this.BLEFJIKJCLM[i].gameObject.SetActive(false);
			}
		}
	}

	// Token: 0x06005C0E RID: 23566 RVA: 0x002A2494 File Offset: 0x002A0694
	private IEnumerator EJGJLOHAILD(FLNOFHCNJDM GFIMGNJBJHH)
	{
		PlayerCharacterManager.DBOJNHEDALM dbojnhedalm = new PlayerCharacterManager.DBOJNHEDALM(1);
		dbojnhedalm.<>4__this = this;
		dbojnhedalm._emotion = GFIMGNJBJHH;
		return dbojnhedalm;
	}

	// Token: 0x06005C0F RID: 23567 RVA: 0x002955F4 File Offset: 0x002937F4
	private IEnumerator KNIMAAGFGGC(FLNOFHCNJDM GFIMGNJBJHH)
	{
		yield return new WaitForSeconds(PlayerCharacterManager.setEmotionDelay);
		this.SetEmotion(GFIMGNJBJHH, KBACNADIIDP.appearImmediateFade, FLNOFHCNJDM.neutral);
		yield break;
	}

	// Token: 0x040019FA RID: 6650
	public static float setEmotionDelay = 0.5f;

	// Token: 0x040019FB RID: 6651
	public static float animatedEmotionChangeTime = 0.2f;

	// Token: 0x040019FC RID: 6652
	public static float animationAppearTime = 0.2f;

	// Token: 0x040019FD RID: 6653
	public static float animationDisappearTime = 0.2f;

	// Token: 0x040019FE RID: 6654
	public static Vector2 maxCriticalAspectRatioOffset = new Vector2(-60f, 0f);

	// Token: 0x040019FF RID: 6655
	public static int appearTranslationAmount = 40;

	// Token: 0x04001A00 RID: 6656
	public static int disappearTranslationAmount = 80;

	// Token: 0x04001A01 RID: 6657
	public GameObject dialogPivot;

	// Token: 0x04001A02 RID: 6658
	public GameObject extensionsPivot;

	// Token: 0x04001A03 RID: 6659
	public Image bodyImage;

	// Token: 0x04001A04 RID: 6660
	public Image faceImagePrev;

	// Token: 0x04001A05 RID: 6661
	public Image faceImageCur;

	// Token: 0x04001A06 RID: 6662
	public Image clothesImage;

	// Token: 0x04001A07 RID: 6663
	public Image hairImage;

	// Token: 0x04001A08 RID: 6664
	public Image trinketImage;

	// Token: 0x04001A09 RID: 6665
	public Image overlayImage;

	// Token: 0x04001A0A RID: 6666
	public Material genericEtc1AlphaSplitMaterial;

	// Token: 0x04001A0B RID: 6667
	public List<GameObject> componentsHierarchy = new List<GameObject>();

	// Token: 0x04001A0C RID: 6668
	public List<int> componentsHierarchyDepth = new List<int>();

	// Token: 0x04001A0D RID: 6669
	private List<DCAIAAIOOEI> OOGGLIGODEA = new List<DCAIAAIOOEI>();

	// Token: 0x04001A0E RID: 6670
	private AssetAvatarComponent FGGCPAKJKOH;

	// Token: 0x04001A0F RID: 6671
	private AssetAvatarComponent HFKIIFEHGID;

	// Token: 0x04001A10 RID: 6672
	private AssetAvatarComponent KFGELOAKHGC;

	// Token: 0x04001A11 RID: 6673
	private AssetAvatarComponent IOCLNEFCDNI;

	// Token: 0x04001A12 RID: 6674
	private AssetAvatarComponent AIHJMLIDEKJ;

	// Token: 0x04001A13 RID: 6675
	private AssetAvatarComponent INHNCPCOJEN;

	// Token: 0x04001A14 RID: 6676
	private CanvasGroup PANMNKKODPC;

	// Token: 0x04001A15 RID: 6677
	private CanvasGroup NCIJPAGAFKB;

	// Token: 0x04001A16 RID: 6678
	private bool PFCNMBMIPFO;

	// Token: 0x04001A17 RID: 6679
	private RectTransform DGAAFGDHHHJ;

	// Token: 0x04001A18 RID: 6680
	private List<GameObject> JPDLGGBMFDP = new List<GameObject>();

	// Token: 0x04001A19 RID: 6681
	private List<AssetAvatarExtension> BLEFJIKJCLM = new List<AssetAvatarExtension>();

	// Token: 0x04001A1A RID: 6682
	private List<Image> COCJDIGOBNL = new List<Image>();

	// Token: 0x04001A1B RID: 6683
	private List<Material> JBGBGLAGGPD = new List<Material>();

	// Token: 0x04001A1C RID: 6684
	private EBFHKCOGJLB PDIGPJOJACG;

	// Token: 0x04001A1D RID: 6685
	private float PGAAAMPFGBP;

	// Token: 0x04001A1E RID: 6686
	private float OEEOLLNGOGM;

	// Token: 0x04001A1F RID: 6687
	private Material PENHKBHCJFI;

	// Token: 0x04001A20 RID: 6688
	private Material OEEENIEKGBK;

	// Token: 0x04001A21 RID: 6689
	private Material BBFNBHNLFNH;

	// Token: 0x04001A22 RID: 6690
	private Material BIMPMLDDIIC;

	// Token: 0x04001A23 RID: 6691
	private Material NOFMOEMPPBB;

	// Token: 0x04001A24 RID: 6692
	private int MCOLPALAKEH;

	// Token: 0x04001A25 RID: 6693
	private ODLLAEHMFAA DFOGCMMEAIM;

	// Token: 0x04001A26 RID: 6694
	private int DFBHNBPJFAC;

	// Token: 0x04001A27 RID: 6695
	private int BGOHGJDGIJN;

	// Token: 0x04001A28 RID: 6696
	private List<AssetAvatarComponent> PIOBODMADGE = new List<AssetAvatarComponent>();

	// Token: 0x04001A29 RID: 6697
	private ODLLAEHMFAA NFCBABCLNGH;

	// Token: 0x04001A2A RID: 6698
	private int CJIBMBEAIHP;

	// Token: 0x04001A2B RID: 6699
	private int NGCEGMACFNF;

	// Token: 0x04001A2C RID: 6700
	private List<AssetAvatarComponent> FNGMPIJOEID = new List<AssetAvatarComponent>();

	// Token: 0x04001A2D RID: 6701
	private ODLLAEHMFAA HFFMCJFJOHD;

	// Token: 0x04001A2E RID: 6702
	private int JLDPAPPAPAE;

	// Token: 0x04001A2F RID: 6703
	private int KKNJBDONHNO;

	// Token: 0x04001A30 RID: 6704
	private List<AssetAvatarComponent> FBFPJOBNMBJ = new List<AssetAvatarComponent>();

	// Token: 0x04001A31 RID: 6705
	private ODLLAEHMFAA IEEMAIJHNKL;

	// Token: 0x04001A32 RID: 6706
	private int FPOFLJFEGGF;

	// Token: 0x04001A33 RID: 6707
	private int EBOGFAOKJME;

	// Token: 0x04001A34 RID: 6708
	private List<AssetAvatarComponent> FAALKIPIDOD = new List<AssetAvatarComponent>();

	// Token: 0x04001A35 RID: 6709
	private int HEIILKBIOCK;

	// Token: 0x04001A36 RID: 6710
	private int DFMFLPIOFBN;

	// Token: 0x04001A37 RID: 6711
	private static int BKCPMIPKBOK = 0;

	// Token: 0x04001A38 RID: 6712
	private static int AHFGCHIBCID = -1;

	// Token: 0x04001A39 RID: 6713
	private bool NCMDLLCLAGK;
}
