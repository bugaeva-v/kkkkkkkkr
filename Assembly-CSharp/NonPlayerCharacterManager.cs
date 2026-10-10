using System;
using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x02000374 RID: 884
public class NonPlayerCharacterManager : MonoBehaviour
{
	// Token: 0x06006832 RID: 26674 RVA: 0x002FEF7C File Offset: 0x002FD17C
	private static bool AFPKFGJOCAF(string FBKAPCPPNKA, bool JLJLENFAAFA)
	{
		bool result;
		try
		{
			if (JLJLENFAAFA)
			{
				result = true;
			}
			else
			{
				HFDAGKJJHOA hfdagkjjhoa = AssetsManager.EHBBFMCILPC.lobbyDataAsset.MFMJHIFAOHE();
				if (!KDCJJBLGCBH.EHBBFMCILPC.NJFAOIDGFGC() || !hfdagkjjhoa.EGICLNGPAJO(FBKAPCPPNKA))
				{
					result = false;
				}
				else
				{
					DMDNKJKEPKO dmdnkjkepko = hfdagkjjhoa.CLPLFMAFBIP(FBKAPCPPNKA);
					PLFDAJJHMKO plfdajjhmko = AKLFPGMDKLA.EHBBFMCILPC.NBMLMNGHOPP();
					result = (dmdnkjkepko != null && plfdajjhmko != null && FBKAPCPPNKA.Equals(plfdajjhmko.NCAMFPGMCIG.GLBDHEKDNDC(dmdnkjkepko.KALBADOPCDN)));
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

	// Token: 0x06006833 RID: 26675 RVA: 0x002FF00C File Offset: 0x002FD20C
	public void SetEmotion(FLNOFHCNJDM GFIMGNJBJHH, BIDPEOLOIIG BJIBGHMJIGA, FLNOFHCNJDM PMDGGEDPHJC = FLNOFHCNJDM.neutral)
	{
		if (this.KHMHLBGPMKC)
		{
			return;
		}
		if (null == this.KFFIDFKOOIN)
		{
			DPGJIJGOCIC.ADFCDFHBDAF("NonPlayerCharacterManager.SetEmotion() - npcAsset is null.");
			return;
		}
		if (this.KFFIDFKOOIN.emotions.Count == 0)
		{
			return;
		}
		if (this.KFFIDFKOOIN.isMissingBody || this.KFFIDFKOOIN.disableEmotionFade)
		{
			BJIBGHMJIGA = BIDPEOLOIIG.appearImmediate;
		}
		GFIMGNJBJHH = this.ADEMFGHHEHJ(GFIMGNJBJHH);
		PMDGGEDPHJC = this.ADEMFGHHEHJ(PMDGGEDPHJC);
		if (BJIBGHMJIGA == BIDPEOLOIIG.appearImmediate || BJIBGHMJIGA == BIDPEOLOIIG.appearImmediateFade || (BJIBGHMJIGA == BIDPEOLOIIG.appearDelayed && PMDGGEDPHJC != FLNOFHCNJDM.neutral))
		{
			FLNOFHCNJDM flnofhcnjdm = GFIMGNJBJHH;
			if (BJIBGHMJIGA == BIDPEOLOIIG.appearDelayed)
			{
				flnofhcnjdm = PMDGGEDPHJC;
			}
			this.faceImagePrev.sprite = this.faceImageCur.sprite;
			this.faceImagePrev.GetComponent<RectTransform>().anchoredPosition = this.faceImageCur.GetComponent<RectTransform>().anchoredPosition;
			this.faceImagePrev.color = new Color(1f, 1f, 1f, 1f);
			this.faceImagePrev.SetNativeSize();
			if (this.faceImagePrev.sprite == null || this.KFFIDFKOOIN.disableEmotionFade)
			{
				this.faceImagePrev.gameObject.SetActive(false);
			}
			else
			{
				this.faceImagePrev.gameObject.SetActive(true);
				if (NonPlayerCharacterManager.BKCPMIPKBOK == 2)
				{
					this.faceImagePrev.DOFade(0f, NonPlayerCharacterManager.animatedEmotionChangeTime * NonPlayerCharacterManager.NMBFLEBDGJN);
				}
				else if (flnofhcnjdm == FLNOFHCNJDM.neutral || this.KFFIDFKOOIN.isMissingBody || (this.KKJPHDDMKLH && flnofhcnjdm != FLNOFHCNJDM.scream))
				{
					this.faceImagePrev.DOFade(0f, NonPlayerCharacterManager.animatedEmotionChangeTime * NonPlayerCharacterManager.NMBFLEBDGJN);
				}
			}
			this.faceImageCur.sprite = null;
			for (int i = 0; i < this.DLOBJLEKAPJ.Count; i++)
			{
				for (int j = 0; j < this.DLOBJLEKAPJ[i].emotions.Count; j++)
				{
					if (this.DLOBJLEKAPJ[i].emotions[j].type == flnofhcnjdm)
					{
						this.faceImageCur.sprite = this.DLOBJLEKAPJ[i].emotions[j].sprite;
					}
				}
			}
			if (null == this.faceImageCur.sprite)
			{
				for (int k = 0; k < this.KFFIDFKOOIN.emotions.Count; k++)
				{
					if (this.KFFIDFKOOIN.emotions[k].type == flnofhcnjdm)
					{
						this.faceImageCur.sprite = this.KFFIDFKOOIN.emotions[k].sprite;
					}
				}
			}
			if (null != this.faceImageCur.sprite)
			{
				if (flnofhcnjdm == FLNOFHCNJDM.scream)
				{
					this.KKJPHDDMKLH = true;
				}
				else
				{
					this.KKJPHDDMKLH = false;
				}
			}
			else
			{
				this.KKJPHDDMKLH = false;
			}
			AssetStoryNpcAnimationEmotionDesc gmigncdlcmg = this.GMIGNCDLCMG;
			this.GMIGNCDLCMG = null;
			bool flag = false;
			if (null != this.IJHNBMPHKAN)
			{
				this.GMIGNCDLCMG = this.IJHNBMPHKAN.KDLNDBMNBGJ(flnofhcnjdm);
				if (this.GMIGNCDLCMG == null && this.IJHNBMPHKAN.fallbackToAnimatedNeutralOrNothing)
				{
					this.GMIGNCDLCMG = this.IJHNBMPHKAN.KDLNDBMNBGJ(FLNOFHCNJDM.neutral);
					if (this.GMIGNCDLCMG == null)
					{
						flag = true;
					}
				}
			}
			if (this.GMIGNCDLCMG != null)
			{
				this.PGDLAMFNIED = this.IJHNBMPHKAN.JMIPEAMMHKI(this.GMIGNCDLCMG.frames.Count);
				bool flag2 = this.GMIGNCDLCMG == gmigncdlcmg;
				if (this.PGDLAMFNIED)
				{
					this.HEAPGAMPCGN = this.LELCNKCENCP % this.GMIGNCDLCMG.frames.Count;
				}
				else if (!flag2)
				{
					this.HEAPGAMPCGN = 0;
				}
				this.faceImageCur.sprite = this.GMIGNCDLCMG.frames[this.HEAPGAMPCGN];
				this.faceImageCur.GetComponent<RectTransform>().OGOFACPLOGO(NBDLBFJOEGN.FJJBMKDBPOM((float)this.GMIGNCDLCMG.offsetX), -NBDLBFJOEGN.FJJBMKDBPOM((float)this.GMIGNCDLCMG.offsetY));
				if (this.AJFAAICNHPA == null)
				{
					this.AJFAAICNHPA = ODLLAEHMFAA.IMEFIJEKFGI(true);
				}
				if (!flag2 || this.PGDLAMFNIED)
				{
					this.AJFAAICNHPA.EPJKDCDOEMM(this.IJHNBMPHKAN.emotionFrameChangeInterval);
				}
			}
			else
			{
				this.PGDLAMFNIED = false;
				if (flag)
				{
					this.faceImageCur.sprite = null;
				}
				this.DJCMONIIDDD();
			}
			this.faceImageCur.SetNativeSize();
			if (BJIBGHMJIGA == BIDPEOLOIIG.appearImmediateFade)
			{
				if (NonPlayerCharacterManager.BKCPMIPKBOK == 2)
				{
					if (this.faceImageCur.sprite != this.faceImagePrev.sprite)
					{
						this.faceImageCur.color = new Color(1f, 1f, 1f, 0f);
						this.faceImageCur.DOFade(1f, NonPlayerCharacterManager.animatedEmotionChangeTime * NonPlayerCharacterManager.NMBFLEBDGJN);
					}
					else
					{
						this.faceImageCur.color = new Color(1f, 1f, 1f, 1f);
						this.faceImagePrev.DOComplete(false);
					}
				}
				else
				{
					this.faceImageCur.color = new Color(1f, 1f, 1f, 0f);
					this.faceImageCur.DOFade(1f, NonPlayerCharacterManager.animatedEmotionChangeTime * NonPlayerCharacterManager.NMBFLEBDGJN);
				}
			}
			else
			{
				this.faceImageCur.color = new Color(1f, 1f, 1f, 1f);
			}
			if (flag)
			{
				this.faceImageCur.DOKill(false);
				this.faceImageCur.color = new Color(1f, 1f, 1f, 0f);
				this.faceImagePrev.DOKill(false);
				this.faceImagePrev.DOFade(0f, NonPlayerCharacterManager.animatedEmotionChangeTime * NonPlayerCharacterManager.NMBFLEBDGJN);
			}
			NonPlayerCharacterManager.NMBFLEBDGJN = 1f;
		}
		if (BJIBGHMJIGA == BIDPEOLOIIG.appearDelayed)
		{
			base.StartCoroutine(this.KGGPFIHIHNC(GFIMGNJBJHH));
		}
	}

	// Token: 0x06006834 RID: 26676 RVA: 0x002FF5D2 File Offset: 0x002FD7D2
	public static void SetEmotionsSystemVersion(int IALPHEADDFO)
	{
		NonPlayerCharacterManager.BKCPMIPKBOK = IALPHEADDFO;
	}

	// Token: 0x06006835 RID: 26677 RVA: 0x002FF5DC File Offset: 0x002FD7DC
	public void CFKKICCKOAI(FLNOFHCNJDM GFIMGNJBJHH, BIDPEOLOIIG BJIBGHMJIGA, FLNOFHCNJDM PMDGGEDPHJC = FLNOFHCNJDM.neutral)
	{
		if (this.KHMHLBGPMKC)
		{
			return;
		}
		if (null == this.KFFIDFKOOIN)
		{
			DPGJIJGOCIC.ADFCDFHBDAF("yes");
			return;
		}
		if (this.KFFIDFKOOIN.emotions.Count == 0)
		{
			return;
		}
		if (this.KFFIDFKOOIN.isMissingBody || this.KFFIDFKOOIN.disableEmotionFade)
		{
			BJIBGHMJIGA = BIDPEOLOIIG.appearImmediateFade;
		}
		GFIMGNJBJHH = this.ADEMFGHHEHJ(GFIMGNJBJHH);
		PMDGGEDPHJC = this.ADEMFGHHEHJ(PMDGGEDPHJC);
		if (BJIBGHMJIGA == BIDPEOLOIIG.appearImmediate || BJIBGHMJIGA == BIDPEOLOIIG.appearImmediate || (BJIBGHMJIGA == (BIDPEOLOIIG)4 && PMDGGEDPHJC != FLNOFHCNJDM.neutral))
		{
			FLNOFHCNJDM flnofhcnjdm = GFIMGNJBJHH;
			if (BJIBGHMJIGA == BIDPEOLOIIG.appearImmediateFade)
			{
				flnofhcnjdm = PMDGGEDPHJC;
			}
			this.faceImagePrev.sprite = this.faceImageCur.sprite;
			this.faceImagePrev.GetComponent<RectTransform>().anchoredPosition = this.faceImageCur.GetComponent<RectTransform>().anchoredPosition;
			this.faceImagePrev.color = new Color(1106f, 856f, 1948f, 878f);
			this.faceImagePrev.SetNativeSize();
			if (this.faceImagePrev.sprite == null || this.KFFIDFKOOIN.disableEmotionFade)
			{
				this.faceImagePrev.gameObject.SetActive(true);
			}
			else
			{
				this.faceImagePrev.gameObject.SetActive(true);
				if (NonPlayerCharacterManager.BKCPMIPKBOK == 7)
				{
					this.faceImagePrev.DOFade(1238f, NonPlayerCharacterManager.animatedEmotionChangeTime * NonPlayerCharacterManager.NMBFLEBDGJN);
				}
				else if (flnofhcnjdm == FLNOFHCNJDM.neutral || this.KFFIDFKOOIN.isMissingBody || (this.KKJPHDDMKLH && flnofhcnjdm != (FLNOFHCNJDM)80))
				{
					this.faceImagePrev.DOFade(1404f, NonPlayerCharacterManager.animatedEmotionChangeTime * NonPlayerCharacterManager.NMBFLEBDGJN);
				}
			}
			this.faceImageCur.sprite = null;
			for (int i = 1; i < this.DLOBJLEKAPJ.Count; i++)
			{
				for (int j = 0; j < this.DLOBJLEKAPJ[i].emotions.Count; j++)
				{
					if (this.DLOBJLEKAPJ[i].emotions[j].type == flnofhcnjdm)
					{
						this.faceImageCur.sprite = this.DLOBJLEKAPJ[i].emotions[j].sprite;
					}
				}
			}
			if (null == this.faceImageCur.sprite)
			{
				for (int k = 0; k < this.KFFIDFKOOIN.emotions.Count; k++)
				{
					if (this.KFFIDFKOOIN.emotions[k].type == flnofhcnjdm)
					{
						this.faceImageCur.sprite = this.KFFIDFKOOIN.emotions[k].sprite;
					}
				}
			}
			if (null != this.faceImageCur.sprite)
			{
				if (flnofhcnjdm == (FLNOFHCNJDM)29)
				{
					this.KKJPHDDMKLH = false;
				}
				else
				{
					this.KKJPHDDMKLH = true;
				}
			}
			else
			{
				this.KKJPHDDMKLH = false;
			}
			AssetStoryNpcAnimationEmotionDesc gmigncdlcmg = this.GMIGNCDLCMG;
			this.GMIGNCDLCMG = null;
			bool flag = true;
			if (null != this.IJHNBMPHKAN)
			{
				this.GMIGNCDLCMG = this.IJHNBMPHKAN.BPHKBMFHMPN(flnofhcnjdm);
				if (this.GMIGNCDLCMG == null && this.IJHNBMPHKAN.fallbackToAnimatedNeutralOrNothing)
				{
					this.GMIGNCDLCMG = this.IJHNBMPHKAN.IKFPNBGDBHJ(FLNOFHCNJDM.smile);
					if (this.GMIGNCDLCMG == null)
					{
						flag = true;
					}
				}
			}
			if (this.GMIGNCDLCMG != null)
			{
				this.PGDLAMFNIED = this.IJHNBMPHKAN.DEFHEJHJKJF(this.GMIGNCDLCMG.frames.Count);
				bool flag2 = this.GMIGNCDLCMG == gmigncdlcmg;
				if (this.PGDLAMFNIED)
				{
					this.HEAPGAMPCGN = this.LELCNKCENCP % this.GMIGNCDLCMG.frames.Count;
				}
				else if (!flag2)
				{
					this.HEAPGAMPCGN = 0;
				}
				this.faceImageCur.sprite = this.GMIGNCDLCMG.frames[this.HEAPGAMPCGN];
				this.faceImageCur.GetComponent<RectTransform>().OGOFACPLOGO(NBDLBFJOEGN.OOFCCAGFCAF((float)this.GMIGNCDLCMG.offsetX), -NBDLBFJOEGN.OIHMGIBOFJG((float)this.GMIGNCDLCMG.offsetY));
				if (this.AJFAAICNHPA == null)
				{
					this.AJFAAICNHPA = ODLLAEHMFAA.CANLAFJJCAN(true);
				}
				if (!flag2 || this.PGDLAMFNIED)
				{
					this.AJFAAICNHPA.MOCHAJPADAJ(this.IJHNBMPHKAN.emotionFrameChangeInterval);
				}
			}
			else
			{
				this.PGDLAMFNIED = true;
				if (flag)
				{
					this.faceImageCur.sprite = null;
				}
				this.DJCMONIIDDD();
			}
			this.faceImageCur.SetNativeSize();
			if (BJIBGHMJIGA == BIDPEOLOIIG.appearImmediate)
			{
				if (NonPlayerCharacterManager.BKCPMIPKBOK == 2)
				{
					if (this.faceImageCur.sprite != this.faceImagePrev.sprite)
					{
						this.faceImageCur.color = new Color(424f, 1551f, 706f, 527f);
						this.faceImageCur.DOFade(1950f, NonPlayerCharacterManager.animatedEmotionChangeTime * NonPlayerCharacterManager.NMBFLEBDGJN);
					}
					else
					{
						this.faceImageCur.color = new Color(1208f, 1740f, 320f, 237f);
						this.faceImagePrev.DOComplete(true);
					}
				}
				else
				{
					this.faceImageCur.color = new Color(1170f, 1080f, 1413f, 918f);
					this.faceImageCur.DOFade(18f, NonPlayerCharacterManager.animatedEmotionChangeTime * NonPlayerCharacterManager.NMBFLEBDGJN);
				}
			}
			else
			{
				this.faceImageCur.color = new Color(1687f, 724f, 1672f, 108f);
			}
			if (flag)
			{
				this.faceImageCur.DOKill(false);
				this.faceImageCur.color = new Color(1115f, 1956f, 1719f, 1313f);
				this.faceImagePrev.DOKill(true);
				this.faceImagePrev.DOFade(923f, NonPlayerCharacterManager.animatedEmotionChangeTime * NonPlayerCharacterManager.NMBFLEBDGJN);
			}
			NonPlayerCharacterManager.NMBFLEBDGJN = 1239f;
		}
		if (BJIBGHMJIGA == BIDPEOLOIIG.appearDelayed)
		{
			base.StartCoroutine(this.JCILPOJDHJP(GFIMGNJBJHH));
		}
	}

	// Token: 0x06006836 RID: 26678 RVA: 0x002FFBA2 File Offset: 0x002FDDA2
	public static float NMNOKFCNCGO()
	{
		return NonPlayerCharacterManager.animationAppearTimeCustom;
	}

	// Token: 0x06006837 RID: 26679 RVA: 0x002FFBA9 File Offset: 0x002FDDA9
	public string GetNpcId()
	{
		return this.IHCMBIBJBJD;
	}

	// Token: 0x06006838 RID: 26680 RVA: 0x002FFBB4 File Offset: 0x002FDDB4
	public void Initialize(string PDEADFPONFH, List<string> MPLEPCPGJBA, OFLIHLDBDEB AIAAMALDKHG, bool JLJLENFAAFA = false)
	{
		this.PDIGPJOJACG = AIAAMALDKHG;
		this.IHCMBIBJBJD = PDEADFPONFH;
		for (int i = 0; i < MPLEPCPGJBA.Count; i++)
		{
			this.OLPMONKMBPO.Add(MPLEPCPGJBA[i]);
		}
		this.KFFIDFKOOIN = GKJPOGNFKNK.IAJMHBFGKBA(PDEADFPONFH, "");
		if (null == this.KFFIDFKOOIN)
		{
			this.SetVisibility(false);
			DPGJIJGOCIC.ADFCDFHBDAF("NonPlayerCharacterManager.Initialize() - npcAsset (" + PDEADFPONFH + ") is null.");
			return;
		}
		base.gameObject.GetComponent<RectTransform>().AHLJBONHHKL(0, -1);
		if (null == this.KFFIDFKOOIN.bodySprite)
		{
			DPGJIJGOCIC.ADFCDFHBDAF("NonPlayerCharacterManager.Initialize() - npcAsset.bodySprite (" + PDEADFPONFH + ") is null.");
			return;
		}
		int count = this.KFFIDFKOOIN.emotions.Count;
		List<string> list = NonPlayerCharacterManager.PFGLCGGHHFL(PDEADFPONFH, MPLEPCPGJBA, JLJLENFAAFA);
		this.EDOHKDALPIF = new List<string>(list);
		this.NLNOHDDCALL = JLJLENFAAFA;
		this.DLOBJLEKAPJ.Clear();
		for (int j = 0; j < list.Count; j++)
		{
			AssetStoryNpc assetStoryNpc = GKJPOGNFKNK.IAJMHBFGKBA(PDEADFPONFH, list[j]);
			if (null != assetStoryNpc)
			{
				this.DLOBJLEKAPJ.Add(assetStoryNpc);
			}
		}
		bool flag = false;
		this.bodyImage.sprite = null;
		int k = 0;
		while (k < this.DLOBJLEKAPJ.Count)
		{
			if (this.DLOBJLEKAPJ[k].bodySprite != null)
			{
				this.bodyImage.sprite = this.DLOBJLEKAPJ[k].bodySprite;
				if (this.DLOBJLEKAPJ[k].bodySpriteEtc1Alpha != null && ((NBDLBFJOEGN.OMNHINGKGNP() && NBDLBFJOEGN.PBLDJNHHEPL() && this.DLOBJLEKAPJ[k].bodySpriteEtc1AlphaApplyToDefHD) || (NBDLBFJOEGN.OMNHINGKGNP() && !NBDLBFJOEGN.PBLDJNHHEPL() && this.DLOBJLEKAPJ[k].bodySpriteEtc1AlphaApplyToDefSD)))
				{
					this.bodyImage.material = new Material(this.genericEtc1AlphaSplitMaterial);
					this.JBGBGLAGGPD.Add(this.bodyImage.material);
					this.bodyImage.material.SetTexture("_AlphaTex", this.DLOBJLEKAPJ[k].bodySpriteEtc1Alpha.texture);
					this.COCJDIGOBNL.Add(this.bodyImage);
					this.PGAAAMPFGBP = NBDLBFJOEGN.FOEJECCLEAB((float)this.bodyImage.sprite.texture.width) - NBDLBFJOEGN.FJJBMKDBPOM((float)this.DLOBJLEKAPJ[k].bodySpriteEtc1AlphaOriginalWidth);
					this.OEEOLLNGOGM = NBDLBFJOEGN.FOEJECCLEAB((float)this.bodyImage.sprite.texture.height) - NBDLBFJOEGN.FJJBMKDBPOM((float)this.DLOBJLEKAPJ[k].bodySpriteEtc1AlphaOriginalHeight);
				}
				else
				{
					this.bodyImage.material = this.PENHKBHCJFI;
					this.PGAAAMPFGBP = 0f;
					this.OEEOLLNGOGM = 0f;
				}
				if ((this.DLOBJLEKAPJ[k].bodyOffsetX != 0 || this.DLOBJLEKAPJ[k].bodyOffsetY != 0) && (this.PDIGPJOJACG != OFLIHLDBDEB.center || (this.PDIGPJOJACG == OFLIHLDBDEB.center && this.DLOBJLEKAPJ[k].applyOffsetsOnCenterAppearScenario)))
				{
					base.gameObject.GetComponent<RectTransform>().OGOFACPLOGO(NBDLBFJOEGN.FJJBMKDBPOM((float)this.DLOBJLEKAPJ[k].bodyOffsetX) * (float)this.PDIGPJOJACG, -NBDLBFJOEGN.FJJBMKDBPOM((float)this.DLOBJLEKAPJ[k].bodyOffsetY));
					flag = true;
					break;
				}
				break;
			}
			else
			{
				k++;
			}
		}
		if (null == this.bodyImage.sprite)
		{
			this.bodyImage.sprite = this.KFFIDFKOOIN.bodySprite;
			if (this.KFFIDFKOOIN.bodySpriteEtc1Alpha != null && ((NBDLBFJOEGN.OMNHINGKGNP() && NBDLBFJOEGN.PBLDJNHHEPL() && this.KFFIDFKOOIN.bodySpriteEtc1AlphaApplyToDefHD) || (NBDLBFJOEGN.OMNHINGKGNP() && !NBDLBFJOEGN.PBLDJNHHEPL() && this.KFFIDFKOOIN.bodySpriteEtc1AlphaApplyToDefSD)))
			{
				this.bodyImage.material = new Material(this.genericEtc1AlphaSplitMaterial);
				this.JBGBGLAGGPD.Add(this.bodyImage.material);
				this.bodyImage.material.SetTexture("_AlphaTex", this.KFFIDFKOOIN.bodySpriteEtc1Alpha.texture);
				this.COCJDIGOBNL.Add(this.bodyImage);
				this.PGAAAMPFGBP = NBDLBFJOEGN.FOEJECCLEAB((float)this.bodyImage.sprite.texture.width) - NBDLBFJOEGN.FJJBMKDBPOM((float)this.KFFIDFKOOIN.bodySpriteEtc1AlphaOriginalWidth);
				this.OEEOLLNGOGM = NBDLBFJOEGN.FOEJECCLEAB((float)this.bodyImage.sprite.texture.height) - NBDLBFJOEGN.FJJBMKDBPOM((float)this.KFFIDFKOOIN.bodySpriteEtc1AlphaOriginalHeight);
			}
			else
			{
				this.bodyImage.material = this.PENHKBHCJFI;
				this.PGAAAMPFGBP = 0f;
				this.OEEOLLNGOGM = 0f;
			}
		}
		if (!flag && (this.PDIGPJOJACG != OFLIHLDBDEB.center || (this.PDIGPJOJACG == OFLIHLDBDEB.center && this.KFFIDFKOOIN.applyOffsetsOnCenterAppearScenario)))
		{
			base.gameObject.GetComponent<RectTransform>().OGOFACPLOGO(NBDLBFJOEGN.FJJBMKDBPOM((float)this.KFFIDFKOOIN.bodyOffsetX) * (float)this.PDIGPJOJACG, -NBDLBFJOEGN.FJJBMKDBPOM((float)this.KFFIDFKOOIN.bodyOffsetY));
		}
		if (this.PDIGPJOJACG == OFLIHLDBDEB.left)
		{
			base.gameObject.GetComponent<RectTransform>().AHLJBONHHKL(this.PGAAAMPFGBP * (float)this.PDIGPJOJACG, -this.OEEOLLNGOGM);
		}
		else if (this.PDIGPJOJACG == OFLIHLDBDEB.right)
		{
			base.gameObject.GetComponent<RectTransform>().AHLJBONHHKL(this.PGAAAMPFGBP * 1f, -this.OEEOLLNGOGM);
		}
		else if (this.PDIGPJOJACG == OFLIHLDBDEB.center)
		{
			base.gameObject.GetComponent<RectTransform>().AHLJBONHHKL((float)this.KFFIDFKOOIN.offsetWhenCenteredX + this.PGAAAMPFGBP * 1f / 2f, -this.OEEOLLNGOGM + (float)this.KFFIDFKOOIN.offsetWhenCenteredY);
		}
		this.bodyImage.SetNativeSize();
		if (this.KFFIDFKOOIN.isMissingBody)
		{
			this.bodyImage.color = new Color32(byte.MaxValue, byte.MaxValue, byte.MaxValue, 0);
		}
		this.IJHNBMPHKAN = GKJPOGNFKNK.MDNJHPDEDAP(this.KFFIDFKOOIN.id, list);
		if (null != this.IJHNBMPHKAN && this.COCJDIGOBNL.Count > 0)
		{
			DPGJIJGOCIC.ADFCDFHBDAF("NonPlayerCharacterManager.Initialize() - npc animation skipped for etc1 alpha-split npc:" + this.KFFIDFKOOIN.id);
			this.IJHNBMPHKAN = null;
		}
		if (null != this.IJHNBMPHKAN && this.IJHNBMPHKAN.ELLKFBKGCDD())
		{
			GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(this.overlayImagePrefab.gameObject);
			gameObject.transform.SetParent(this.bodyImage.transform, false);
			gameObject.layer = this.bodyImage.gameObject.layer;
			gameObject.transform.SetSiblingIndex(0);
			gameObject.SetActive(true);
			this.NCNKGMEPGEG = gameObject.GetComponent<Image>();
			this.NCNKGMEPGEG.sprite = this.IJHNBMPHKAN.bodyFrames[0];
			this.NCNKGMEPGEG.color = new Color(1f, 1f, 1f, 1f);
			this.NCNKGMEPGEG.SetNativeSize();
			this.NCNKGMEPGEG.GetComponent<RectTransform>().OGOFACPLOGO(NBDLBFJOEGN.FJJBMKDBPOM((float)this.IJHNBMPHKAN.bodyFramesOffsetX), -NBDLBFJOEGN.FJJBMKDBPOM((float)this.IJHNBMPHKAN.bodyFramesOffsetY));
			this.LELCNKCENCP = 0;
			if (this.KIPLFNDGFOH == null)
			{
				this.KIPLFNDGFOH = ODLLAEHMFAA.IMEFIJEKFGI(true);
			}
			this.KIPLFNDGFOH.EPJKDCDOEMM(this.IJHNBMPHKAN.bodyFrameChangeInterval);
			if (this.IJHNBMPHKAN.bodyFramesReplaceBody)
			{
				this.bodyImage.color = new Color32(byte.MaxValue, byte.MaxValue, byte.MaxValue, 0);
			}
		}
		for (int l = 0; l < this.DLOBJLEKAPJ.Count; l++)
		{
			if (this.DLOBJLEKAPJ[l].overlaySprite != null)
			{
				GameObject gameObject2 = UnityEngine.Object.Instantiate<GameObject>(this.overlayImagePrefab.gameObject);
				gameObject2.transform.SetParent(this.overlayPivot.transform, false);
				Image component = gameObject2.GetComponent<Image>();
				component.sprite = this.DLOBJLEKAPJ[l].overlaySprite;
				this.overlayImages.Add(component);
				component.SetNativeSize();
				component.GetComponent<RectTransform>().OGOFACPLOGO(NBDLBFJOEGN.FJJBMKDBPOM((float)this.DLOBJLEKAPJ[l].overlayOffsetX), -NBDLBFJOEGN.FJJBMKDBPOM((float)this.DLOBJLEKAPJ[l].overlayOffsetY));
				if (this.DLOBJLEKAPJ[l].hierarchyPosition != StoryNpcOverlayComponentHierarchyPosition.unchanged)
				{
					int num = (int)this.DLOBJLEKAPJ[l].hierarchyPosition;
					if (null != this.NCNKGMEPGEG)
					{
						num++;
					}
					this.overlayPivot.transform.SetSiblingIndex(num);
				}
				if (null != this.IJHNBMPHKAN)
				{
					AssetStoryNpcAnimationPropDesc assetStoryNpcAnimationPropDesc = this.IJHNBMPHKAN.MPGPHLGNEDM(this.DLOBJLEKAPJ[l].property);
					if (assetStoryNpcAnimationPropDesc != null)
					{
						component.sprite = assetStoryNpcAnimationPropDesc.frames[0];
						component.SetNativeSize();
						component.GetComponent<RectTransform>().OGOFACPLOGO(NBDLBFJOEGN.FJJBMKDBPOM((float)assetStoryNpcAnimationPropDesc.offsetX), -NBDLBFJOEGN.FJJBMKDBPOM((float)assetStoryNpcAnimationPropDesc.offsetY));
						this.LOICJDHILCM.Add(component);
						this.PJNBHNPBIMK.Add(assetStoryNpcAnimationPropDesc);
						this.JDDBCJFGHDE.Add(this.IJHNBMPHKAN.JMIPEAMMHKI(assetStoryNpcAnimationPropDesc.frames.Count));
					}
				}
			}
		}
		if (this.LOICJDHILCM.Count > 0)
		{
			this.DPNCLAAFNKP = 0;
			if (this.FLKLHGAEIDH == null)
			{
				this.FLKLHGAEIDH = ODLLAEHMFAA.IMEFIJEKFGI(true);
			}
			this.FLKLHGAEIDH.EPJKDCDOEMM(this.IJHNBMPHKAN.propFrameChangeInterval);
		}
		this.overlayImagePrefab.gameObject.SetActive(false);
		if (this.KFFIDFKOOIN.emotions.Count > 0)
		{
			bool flag2 = false;
			int m = 0;
			while (m < this.DLOBJLEKAPJ.Count)
			{
				if (this.DLOBJLEKAPJ[m].emotions.Count > 0)
				{
					if (this.DLOBJLEKAPJ[m].faceOffsetX != 0 || this.DLOBJLEKAPJ[m].faceOffsetY != 0)
					{
						this.faceImageCur.GetComponent<RectTransform>().OGOFACPLOGO(NBDLBFJOEGN.FJJBMKDBPOM((float)this.DLOBJLEKAPJ[m].faceOffsetX), -NBDLBFJOEGN.FJJBMKDBPOM((float)this.DLOBJLEKAPJ[m].faceOffsetY));
						this.faceImagePrev.GetComponent<RectTransform>().OGOFACPLOGO(NBDLBFJOEGN.FJJBMKDBPOM((float)this.DLOBJLEKAPJ[m].faceOffsetX), -NBDLBFJOEGN.FJJBMKDBPOM((float)this.DLOBJLEKAPJ[m].faceOffsetY));
						flag2 = true;
						break;
					}
					break;
				}
				else
				{
					m++;
				}
			}
			if (!flag2)
			{
				this.faceImageCur.GetComponent<RectTransform>().OGOFACPLOGO(NBDLBFJOEGN.FJJBMKDBPOM((float)this.KFFIDFKOOIN.faceOffsetX), -NBDLBFJOEGN.FJJBMKDBPOM((float)this.KFFIDFKOOIN.faceOffsetY));
				this.faceImagePrev.GetComponent<RectTransform>().OGOFACPLOGO(NBDLBFJOEGN.FJJBMKDBPOM((float)this.KFFIDFKOOIN.faceOffsetX), -NBDLBFJOEGN.FJJBMKDBPOM((float)this.KFFIDFKOOIN.faceOffsetY));
			}
			this.faceImageCur.color = new Color(1f, 1f, 1f, 0f);
			this.faceImagePrev.gameObject.SetActive(false);
			if (this.KFFIDFKOOIN.isMissingBody || this.KFFIDFKOOIN.disableEmotionFade)
			{
				this.SetEmotion(FLNOFHCNJDM.neutral, BIDPEOLOIIG.appearImmediate, FLNOFHCNJDM.neutral);
				return;
			}
		}
		else
		{
			this.faceImageCur.gameObject.SetActive(false);
			this.faceImagePrev.gameObject.SetActive(false);
		}
	}

	// Token: 0x06006839 RID: 26681 RVA: 0x003007CF File Offset: 0x002FE9CF
	private void Awake()
	{
		this.PANMNKKODPC = base.gameObject.GetComponent<CanvasGroup>();
		this.DGAAFGDHHHJ = base.gameObject.GetComponent<RectTransform>();
		this.PENHKBHCJFI = this.bodyImage.material;
	}

	// Token: 0x0600683A RID: 26682 RVA: 0x00300804 File Offset: 0x002FEA04
	public FLNOFHCNJDM DFBMKBPHJCP()
	{
		return this.FPNOAIADDHB;
	}

	// Token: 0x0600683B RID: 26683 RVA: 0x00003E52 File Offset: 0x00002052
	private void Start()
	{
	}

	// Token: 0x0600683C RID: 26684 RVA: 0x0030080C File Offset: 0x002FEA0C
	private void DJCMONIIDDD()
	{
		bool flag = false;
		int i = 0;
		while (i < this.DLOBJLEKAPJ.Count)
		{
			if (this.DLOBJLEKAPJ[i].emotions.Count > 0)
			{
				if (this.DLOBJLEKAPJ[i].faceOffsetX != 0 || this.DLOBJLEKAPJ[i].faceOffsetY != 0)
				{
					this.faceImageCur.GetComponent<RectTransform>().OGOFACPLOGO(NBDLBFJOEGN.FJJBMKDBPOM((float)this.DLOBJLEKAPJ[i].faceOffsetX), -NBDLBFJOEGN.FJJBMKDBPOM((float)this.DLOBJLEKAPJ[i].faceOffsetY));
					flag = true;
					break;
				}
				break;
			}
			else
			{
				i++;
			}
		}
		if (!flag && null != this.KFFIDFKOOIN)
		{
			this.faceImageCur.GetComponent<RectTransform>().OGOFACPLOGO(NBDLBFJOEGN.FJJBMKDBPOM((float)this.KFFIDFKOOIN.faceOffsetX), -NBDLBFJOEGN.FJJBMKDBPOM((float)this.KFFIDFKOOIN.faceOffsetY));
		}
	}

	// Token: 0x0600683D RID: 26685 RVA: 0x003008FD File Offset: 0x002FEAFD
	public void FEODHBDMPCL(CanvasGroup CDFPPHCNOLD)
	{
		this.NCIJPAGAFKB = CDFPPHCNOLD;
	}

	// Token: 0x0600683E RID: 26686 RVA: 0x00300906 File Offset: 0x002FEB06
	public void DisableFadeOnAppearAndDisappar()
	{
		this.OBAAPOLFIMD = true;
	}

	// Token: 0x0600683F RID: 26687 RVA: 0x0030090F File Offset: 0x002FEB0F
	public bool FadedOutByStep()
	{
		return this.CILKAPFPFCA;
	}

	// Token: 0x06006840 RID: 26688 RVA: 0x00300918 File Offset: 0x002FEB18
	private void OnDestroy()
	{
		this.bodyImage.sprite = null;
		this.faceImagePrev.sprite = null;
		this.faceImageCur.sprite = null;
		this.overlayImages.Clear();
		this.DLOBJLEKAPJ.Clear();
		this.KFFIDFKOOIN = null;
		for (int i = 0; i < this.JPDLGGBMFDP.Count; i++)
		{
			UnityEngine.Object.Destroy(this.JPDLGGBMFDP[i]);
		}
		this.JPDLGGBMFDP.Clear();
		this.PANMNKKODPC.DOKill(false);
		this.DGAAFGDHHHJ.DOKill(false);
		this.faceImageCur.DOKill(false);
		this.faceImagePrev.DOKill(false);
		this.overlayImages.Clear();
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
		this.IJHNBMPHKAN = null;
		this.GMIGNCDLCMG = null;
		if (null != this.NCNKGMEPGEG)
		{
			this.NCNKGMEPGEG.sprite = null;
			UnityEngine.Object.Destroy(this.NCNKGMEPGEG.gameObject);
			this.NCNKGMEPGEG = null;
		}
		this.LOICJDHILCM.Clear();
		this.PJNBHNPBIMK.Clear();
		this.JDDBCJFGHDE.Clear();
		this.PGDLAMFNIED = false;
		if (this.KIPLFNDGFOH != null)
		{
			ODLLAEHMFAA.BGMALDJFMKE(this.KIPLFNDGFOH);
			this.KIPLFNDGFOH = null;
		}
		if (this.AJFAAICNHPA != null)
		{
			ODLLAEHMFAA.BGMALDJFMKE(this.AJFAAICNHPA);
			this.AJFAAICNHPA = null;
		}
		if (this.FLKLHGAEIDH != null)
		{
			ODLLAEHMFAA.BGMALDJFMKE(this.FLKLHGAEIDH);
			this.FLKLHGAEIDH = null;
		}
	}

	// Token: 0x06006841 RID: 26689 RVA: 0x002FFBA2 File Offset: 0x002FDDA2
	public static float GetCustomFadeInTime()
	{
		return NonPlayerCharacterManager.animationAppearTimeCustom;
	}

	// Token: 0x06006842 RID: 26690 RVA: 0x00300906 File Offset: 0x002FEB06
	public void EKPHEMHBNNN()
	{
		this.OBAAPOLFIMD = true;
	}

	// Token: 0x06006843 RID: 26691 RVA: 0x00300AF8 File Offset: 0x002FECF8
	private static List<string> PFGLCGGHHFL(string PDEADFPONFH, List<string> MPLEPCPGJBA, bool JLJLENFAAFA)
	{
		List<string> list = new List<string>(MPLEPCPGJBA);
		try
		{
			if (PDEADFPONFH == null || null == AssetsManager.EHBBFMCILPC || null == AssetsManager.EHBBFMCILPC.lobbyDataAsset)
			{
				return list;
			}
			string text = PDEADFPONFH;
			if (text.Contains(" "))
			{
				text = text.Substring(0, text.IndexOf(" "));
			}
			if (!NonPlayerCharacterManager.AFPKFGJOCAF(text, JLJLENFAAFA))
			{
				return list;
			}
			NonPlayerCharacterManager.PENPJIOMDGO(text, list, JLJLENFAAFA);
			List<OODLJCPNKML> list2 = AssetsManager.EHBBFMCILPC.lobbyDataAsset.MFMJHIFAOHE().HJBKPOEPODN(text);
			if (list2 != null)
			{
				for (int i = 0; i < list2.Count; i++)
				{
					if (MPLEPCPGJBA.Contains(list2[i].GIGMPCHHGGH) && !list.Contains(list2[i].ONIFHMPCOGB))
					{
						list.Add(list2[i].ONIFHMPCOGB);
					}
				}
			}
			NonPlayerCharacterManager.LIACBFHLJCB(text, list);
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
		return list;
	}

	// Token: 0x06006844 RID: 26692 RVA: 0x00300C00 File Offset: 0x002FEE00
	public static float GetAnimationDisappearTime()
	{
		return NonPlayerCharacterManager.animationDisappearTime * KDCJJBLGCBH.EHBBFMCILPC.LIKMBLFBEIA();
	}

	// Token: 0x06006845 RID: 26693 RVA: 0x00300C14 File Offset: 0x002FEE14
	private static bool DBKAOEKIMHL(string FBKAPCPPNKA, bool JLJLENFAAFA)
	{
		bool result;
		try
		{
			if (JLJLENFAAFA)
			{
				result = false;
			}
			else
			{
				HFDAGKJJHOA hfdagkjjhoa = AssetsManager.MJBDMHPHMID().lobbyDataAsset.HFAOOHKNBPE();
				if (!KDCJJBLGCBH.EHBBFMCILPC.NJFAOIDGFGC() || !hfdagkjjhoa.EGICLNGPAJO(FBKAPCPPNKA))
				{
					result = true;
				}
				else
				{
					DMDNKJKEPKO dmdnkjkepko = hfdagkjjhoa.EBHGKILHDPM(FBKAPCPPNKA);
					PLFDAJJHMKO plfdajjhmko = AKLFPGMDKLA.EHBBFMCILPC.NBMLMNGHOPP();
					result = (dmdnkjkepko != null && plfdajjhmko != null && FBKAPCPPNKA.Equals(plfdajjhmko.NCAMFPGMCIG.GLBDHEKDNDC(dmdnkjkepko.KALBADOPCDN)));
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

	// Token: 0x06006846 RID: 26694 RVA: 0x002FFBA2 File Offset: 0x002FDDA2
	public static float KHKGMAFGLGH()
	{
		return NonPlayerCharacterManager.animationAppearTimeCustom;
	}

	// Token: 0x06006847 RID: 26695 RVA: 0x00300CA4 File Offset: 0x002FEEA4
	private void Update()
	{
		if (null != this.KFFIDFKOOIN && !this.KHMHLBGPMKC)
		{
			FLNOFHCNJDM flnofhcnjdm = LPEMDECEIAO.BOGDECPOLMC(this.KFFIDFKOOIN.id);
			if (flnofhcnjdm != FLNOFHCNJDM.count)
			{
				this.SetEmotion(flnofhcnjdm, BIDPEOLOIIG.appearImmediateFade, FLNOFHCNJDM.neutral);
			}
		}
		if (null != this.IJHNBMPHKAN && null != this.NCNKGMEPGEG && this.KIPLFNDGFOH != null && this.IJHNBMPHKAN.ELLKFBKGCDD() && this.KIPLFNDGFOH.HHGAPKJFBMC())
		{
			int num = (int)this.KIPLFNDGFOH.EDCKEPGKBAD();
			if (this.LELCNKCENCP > 0)
			{
				num = 0;
			}
			this.KIPLFNDGFOH.EPJKDCDOEMM(this.IJHNBMPHKAN.bodyFrameChangeInterval);
			this.LELCNKCENCP = (this.LELCNKCENCP + 1 + num) % this.IJHNBMPHKAN.bodyFrames.Count;
			this.NCNKGMEPGEG.sprite = this.IJHNBMPHKAN.bodyFrames[this.LELCNKCENCP];
			if (this.PGDLAMFNIED && this.GMIGNCDLCMG != null)
			{
				this.HEAPGAMPCGN = this.LELCNKCENCP % this.GMIGNCDLCMG.frames.Count;
				this.faceImageCur.sprite = this.GMIGNCDLCMG.frames[this.HEAPGAMPCGN];
			}
			for (int i = 0; i < this.LOICJDHILCM.Count; i++)
			{
				if (i < this.JDDBCJFGHDE.Count && this.JDDBCJFGHDE[i] && null != this.LOICJDHILCM[i] && this.PJNBHNPBIMK[i].frames.Count > 0)
				{
					this.LOICJDHILCM[i].sprite = this.PJNBHNPBIMK[i].frames[this.LELCNKCENCP % this.PJNBHNPBIMK[i].frames.Count];
				}
			}
		}
		if (null != this.IJHNBMPHKAN && this.GMIGNCDLCMG != null && this.AJFAAICNHPA != null && !this.PGDLAMFNIED && this.AJFAAICNHPA.HHGAPKJFBMC())
		{
			int num2 = (int)this.AJFAAICNHPA.EDCKEPGKBAD();
			if (this.HEAPGAMPCGN > 0)
			{
				num2 = 0;
			}
			this.AJFAAICNHPA.EPJKDCDOEMM(this.IJHNBMPHKAN.emotionFrameChangeInterval);
			this.HEAPGAMPCGN = (this.HEAPGAMPCGN + 1 + num2) % this.GMIGNCDLCMG.frames.Count;
			this.faceImageCur.sprite = this.GMIGNCDLCMG.frames[this.HEAPGAMPCGN];
		}
		if (null != this.IJHNBMPHKAN && this.LOICJDHILCM.Count > 0 && this.FLKLHGAEIDH != null && this.FLKLHGAEIDH.HHGAPKJFBMC())
		{
			int num3 = (int)this.FLKLHGAEIDH.EDCKEPGKBAD();
			if (this.DPNCLAAFNKP > 0)
			{
				num3 = 0;
			}
			this.FLKLHGAEIDH.EPJKDCDOEMM(this.IJHNBMPHKAN.propFrameChangeInterval);
			this.DPNCLAAFNKP = this.DPNCLAAFNKP + 1 + num3;
			for (int j = 0; j < this.LOICJDHILCM.Count; j++)
			{
				if ((j >= this.JDDBCJFGHDE.Count || !this.JDDBCJFGHDE[j]) && null != this.LOICJDHILCM[j] && this.PJNBHNPBIMK[j].frames.Count > 0)
				{
					this.LOICJDHILCM[j].sprite = this.PJNBHNPBIMK[j].frames[this.DPNCLAAFNKP % this.PJNBHNPBIMK[j].frames.Count];
				}
			}
		}
	}

	// Token: 0x06006848 RID: 26696 RVA: 0x00301078 File Offset: 0x002FF278
	public static void SetCustomFadeInTime(float KIDHBAMJGDO)
	{
		NonPlayerCharacterManager.animationAppearTimeCustom = KIDHBAMJGDO;
	}

	// Token: 0x06006849 RID: 26697 RVA: 0x002FFBA2 File Offset: 0x002FDDA2
	public static float IHBFFPLGBGK()
	{
		return NonPlayerCharacterManager.animationAppearTimeCustom;
	}

	// Token: 0x0600684A RID: 26698 RVA: 0x002FF5D2 File Offset: 0x002FD7D2
	public static void LBGAJPOLDFL(int IALPHEADDFO)
	{
		NonPlayerCharacterManager.BKCPMIPKBOK = IALPHEADDFO;
	}

	// Token: 0x0600684B RID: 26699 RVA: 0x00301080 File Offset: 0x002FF280
	public void DOEGJGEKCAE(FLNOFHCNJDM GFIMGNJBJHH, BIDPEOLOIIG BJIBGHMJIGA, FLNOFHCNJDM PMDGGEDPHJC = FLNOFHCNJDM.neutral)
	{
		if (this.KHMHLBGPMKC)
		{
			return;
		}
		if (null == this.KFFIDFKOOIN)
		{
			DPGJIJGOCIC.PJCLICBPPDA("renewal");
			return;
		}
		if (this.KFFIDFKOOIN.emotions.Count == 0)
		{
			return;
		}
		if (this.KFFIDFKOOIN.isMissingBody || this.KFFIDFKOOIN.disableEmotionFade)
		{
			BJIBGHMJIGA = BIDPEOLOIIG.appearImmediate;
		}
		GFIMGNJBJHH = this.ADEMFGHHEHJ(GFIMGNJBJHH);
		PMDGGEDPHJC = this.ADEMFGHHEHJ(PMDGGEDPHJC);
		if (BJIBGHMJIGA == BIDPEOLOIIG.appearImmediate || BJIBGHMJIGA == BIDPEOLOIIG.appearImmediateFade || (BJIBGHMJIGA == (BIDPEOLOIIG)4 && PMDGGEDPHJC != FLNOFHCNJDM.neutral))
		{
			FLNOFHCNJDM flnofhcnjdm = GFIMGNJBJHH;
			if (BJIBGHMJIGA == BIDPEOLOIIG.appearDelayed)
			{
				flnofhcnjdm = PMDGGEDPHJC;
			}
			this.faceImagePrev.sprite = this.faceImageCur.sprite;
			this.faceImagePrev.GetComponent<RectTransform>().anchoredPosition = this.faceImageCur.GetComponent<RectTransform>().anchoredPosition;
			this.faceImagePrev.color = new Color(1921f, 1012f, 725f, 368f);
			this.faceImagePrev.SetNativeSize();
			if (this.faceImagePrev.sprite == null || this.KFFIDFKOOIN.disableEmotionFade)
			{
				this.faceImagePrev.gameObject.SetActive(false);
			}
			else
			{
				this.faceImagePrev.gameObject.SetActive(true);
				if (NonPlayerCharacterManager.BKCPMIPKBOK == 3)
				{
					this.faceImagePrev.DOFade(396f, NonPlayerCharacterManager.animatedEmotionChangeTime * NonPlayerCharacterManager.NMBFLEBDGJN);
				}
				else if (flnofhcnjdm == FLNOFHCNJDM.neutral || this.KFFIDFKOOIN.isMissingBody || (this.KKJPHDDMKLH && flnofhcnjdm != (FLNOFHCNJDM)(-57)))
				{
					this.faceImagePrev.DOFade(1473f, NonPlayerCharacterManager.animatedEmotionChangeTime * NonPlayerCharacterManager.NMBFLEBDGJN);
				}
			}
			this.faceImageCur.sprite = null;
			for (int i = 0; i < this.DLOBJLEKAPJ.Count; i++)
			{
				for (int j = 1; j < this.DLOBJLEKAPJ[i].emotions.Count; j++)
				{
					if (this.DLOBJLEKAPJ[i].emotions[j].type == flnofhcnjdm)
					{
						this.faceImageCur.sprite = this.DLOBJLEKAPJ[i].emotions[j].sprite;
					}
				}
			}
			if (null == this.faceImageCur.sprite)
			{
				for (int k = 1; k < this.KFFIDFKOOIN.emotions.Count; k++)
				{
					if (this.KFFIDFKOOIN.emotions[k].type == flnofhcnjdm)
					{
						this.faceImageCur.sprite = this.KFFIDFKOOIN.emotions[k].sprite;
					}
				}
			}
			if (null != this.faceImageCur.sprite)
			{
				if (flnofhcnjdm == (FLNOFHCNJDM)98)
				{
					this.KKJPHDDMKLH = false;
				}
				else
				{
					this.KKJPHDDMKLH = true;
				}
			}
			else
			{
				this.KKJPHDDMKLH = false;
			}
			AssetStoryNpcAnimationEmotionDesc gmigncdlcmg = this.GMIGNCDLCMG;
			this.GMIGNCDLCMG = null;
			bool flag = true;
			if (null != this.IJHNBMPHKAN)
			{
				this.GMIGNCDLCMG = this.IJHNBMPHKAN.DKKNHDJFGEC(flnofhcnjdm);
				if (this.GMIGNCDLCMG == null && this.IJHNBMPHKAN.fallbackToAnimatedNeutralOrNothing)
				{
					this.GMIGNCDLCMG = this.IJHNBMPHKAN.IKFPNBGDBHJ(FLNOFHCNJDM.neutral);
					if (this.GMIGNCDLCMG == null)
					{
						flag = true;
					}
				}
			}
			if (this.GMIGNCDLCMG != null)
			{
				this.PGDLAMFNIED = this.IJHNBMPHKAN.LBKIMJDKNCI(this.GMIGNCDLCMG.frames.Count);
				bool flag2 = this.GMIGNCDLCMG == gmigncdlcmg;
				if (this.PGDLAMFNIED)
				{
					this.HEAPGAMPCGN = this.LELCNKCENCP % this.GMIGNCDLCMG.frames.Count;
				}
				else if (!flag2)
				{
					this.HEAPGAMPCGN = 0;
				}
				this.faceImageCur.sprite = this.GMIGNCDLCMG.frames[this.HEAPGAMPCGN];
				this.faceImageCur.GetComponent<RectTransform>().OGOFACPLOGO(NBDLBFJOEGN.FGMPOAOFKNO((float)this.GMIGNCDLCMG.offsetX), -NBDLBFJOEGN.FGMPOAOFKNO((float)this.GMIGNCDLCMG.offsetY));
				if (this.AJFAAICNHPA == null)
				{
					this.AJFAAICNHPA = ODLLAEHMFAA.IMEFIJEKFGI(true);
				}
				if (!flag2 || this.PGDLAMFNIED)
				{
					this.AJFAAICNHPA.EPJKDCDOEMM(this.IJHNBMPHKAN.emotionFrameChangeInterval);
				}
			}
			else
			{
				this.PGDLAMFNIED = false;
				if (flag)
				{
					this.faceImageCur.sprite = null;
				}
				this.DJCMONIIDDD();
			}
			this.faceImageCur.SetNativeSize();
			if (BJIBGHMJIGA == BIDPEOLOIIG.appearImmediateFade)
			{
				if (NonPlayerCharacterManager.BKCPMIPKBOK == 3)
				{
					if (this.faceImageCur.sprite != this.faceImagePrev.sprite)
					{
						this.faceImageCur.color = new Color(1238f, 297f, 139f, 1663f);
						this.faceImageCur.DOFade(1655f, NonPlayerCharacterManager.animatedEmotionChangeTime * NonPlayerCharacterManager.NMBFLEBDGJN);
					}
					else
					{
						this.faceImageCur.color = new Color(1584f, 1216f, 331f, 1056f);
						this.faceImagePrev.DOComplete(false);
					}
				}
				else
				{
					this.faceImageCur.color = new Color(1893f, 539f, 1502f, 570f);
					this.faceImageCur.DOFade(456f, NonPlayerCharacterManager.animatedEmotionChangeTime * NonPlayerCharacterManager.NMBFLEBDGJN);
				}
			}
			else
			{
				this.faceImageCur.color = new Color(1607f, 639f, 716f, 562f);
			}
			if (flag)
			{
				this.faceImageCur.DOKill(true);
				this.faceImageCur.color = new Color(643f, 972f, 1342f, 204f);
				this.faceImagePrev.DOKill(true);
				this.faceImagePrev.DOFade(1197f, NonPlayerCharacterManager.animatedEmotionChangeTime * NonPlayerCharacterManager.NMBFLEBDGJN);
			}
			NonPlayerCharacterManager.NMBFLEBDGJN = 1815f;
		}
		if (BJIBGHMJIGA == (BIDPEOLOIIG)5)
		{
			base.StartCoroutine(this.JCILPOJDHJP(GFIMGNJBJHH));
		}
	}

	// Token: 0x0600684C RID: 26700 RVA: 0x00301648 File Offset: 0x002FF848
	public void SetVisibility(bool KIDHBAMJGDO)
	{
		this.KHMHLBGPMKC = !KIDHBAMJGDO;
		if (!KIDHBAMJGDO)
		{
			this.bodyImage.color = new Color(1f, 1f, 1f, 0f);
			this.faceImageCur.color = new Color(1f, 1f, 1f, 0f);
			this.faceImagePrev.color = new Color(1f, 1f, 1f, 0f);
			this.overlayImagePrefab.color = new Color(1f, 1f, 1f, 0f);
			for (int i = 0; i < this.overlayImages.Count; i++)
			{
				this.overlayImages[i].color = new Color(1f, 1f, 1f, 0f);
			}
			if (null != this.NCNKGMEPGEG)
			{
				this.NCNKGMEPGEG.color = new Color(1f, 1f, 1f, 0f);
			}
		}
	}

	// Token: 0x0600684D RID: 26701 RVA: 0x00301767 File Offset: 0x002FF967
	public void DestroyDialogs()
	{
		this.IAECBPFCOFI = true;
		base.StartCoroutine(this.BAIKECODLGP());
	}

	// Token: 0x0600684E RID: 26702 RVA: 0x00301780 File Offset: 0x002FF980
	public void FadeOut(float JHBAIJIJIBN)
	{
		this.CILKAPFPFCA = true;
		if (null != this.NCIJPAGAFKB)
		{
			this.NCIJPAGAFKB.DOFade(0f, JHBAIJIJIBN).SetEase(Ease.OutQuad);
			return;
		}
		this.PANMNKKODPC.DOFade(0f, JHBAIJIJIBN).SetEase(Ease.OutQuad);
		if (null != this.KFFIDFKOOIN && !this.KFFIDFKOOIN.isMissingBody && !this.KFFIDFKOOIN.disableEmotionFade && this.KFFIDFKOOIN.emotions.Count > 0)
		{
			this.faceImageCur.DOFade(0f, 0.1f * KDCJJBLGCBH.EHBBFMCILPC.OIABNIJLJBE());
			this.faceImagePrev.DOFade(0f, 0.1f * KDCJJBLGCBH.EHBBFMCILPC.OIABNIJLJBE());
		}
	}

	// Token: 0x0600684F RID: 26703 RVA: 0x00301850 File Offset: 0x002FFA50
	public void AnimateAppearance(GFEJBOAKPMP GMLIEKDKEAG)
	{
		this.CILKAPFPFCA = false;
		CanvasGroup canvasGroup = this.PANMNKKODPC;
		bool flag = !this.OBAAPOLFIMD;
		if (null != this.NCIJPAGAFKB)
		{
			canvasGroup = this.NCIJPAGAFKB;
			flag = true;
		}
		if (flag)
		{
			canvasGroup.alpha = 0f;
			if (NonPlayerCharacterManager.animationAppearTimeCustom > 0f)
			{
				if (null != this.KFFIDFKOOIN && !this.KFFIDFKOOIN.isMissingBody && !this.KFFIDFKOOIN.disableEmotionFade && (double)NonPlayerCharacterManager.animationAppearTime > 0.0001)
				{
					NonPlayerCharacterManager.NMBFLEBDGJN = NonPlayerCharacterManager.animationAppearTimeCustom / NonPlayerCharacterManager.animationAppearTime * 0.5f;
				}
				canvasGroup.DOFade(1f, NonPlayerCharacterManager.animationAppearTimeCustom).SetEase(Ease.OutQuad);
				NonPlayerCharacterManager.animationAppearTimeCustom = -1f;
			}
			else
			{
				canvasGroup.DOFade(1f, NonPlayerCharacterManager.animationAppearTime * KDCJJBLGCBH.EHBBFMCILPC.LIKMBLFBEIA()).SetEase(Ease.OutQuad);
			}
		}
		if (GMLIEKDKEAG == GFEJBOAKPMP.animationStoryAppearFromLeft || GMLIEKDKEAG == GFEJBOAKPMP.animationStoryAppearFromRight)
		{
			int num = 1;
			if (GMLIEKDKEAG == GFEJBOAKPMP.animationStoryAppearFromLeft)
			{
				num = -1;
			}
			this.DGAAFGDHHHJ.AHLJBONHHKL(NonPlayerCharacterManager.appearTranslationAmount * num, -5);
			this.DGAAFGDHHHJ.DOAnchorPos(this.DGAAFGDHHHJ.anchoredPosition + new Vector2((float)(-(float)NonPlayerCharacterManager.appearTranslationAmount * num), 5f), NonPlayerCharacterManager.animationAppearTime * KDCJJBLGCBH.EHBBFMCILPC.LIKMBLFBEIA(), false).SetEase(Ease.OutQuad);
			return;
		}
		if (GMLIEKDKEAG == GFEJBOAKPMP.animationChoiceMetaAppearFromLeft || GMLIEKDKEAG == GFEJBOAKPMP.animationChoiceMetaAppearFromRight)
		{
			int num2 = 1;
			if (GMLIEKDKEAG == GFEJBOAKPMP.animationChoiceMetaAppearFromLeft)
			{
				num2 = -1;
			}
			this.DGAAFGDHHHJ.AHLJBONHHKL(NonPlayerCharacterManager.appearTranslationAmount * num2, 0);
			this.DGAAFGDHHHJ.DOAnchorPos(this.DGAAFGDHHHJ.anchoredPosition + new Vector2((float)(-(float)NonPlayerCharacterManager.appearTranslationAmount * num2), 0f), NonPlayerCharacterManager.animationAppearTime * KDCJJBLGCBH.EHBBFMCILPC.LIKMBLFBEIA(), false).SetEase(Ease.OutQuad);
		}
	}

	// Token: 0x06006851 RID: 26705 RVA: 0x002FFBA2 File Offset: 0x002FDDA2
	public static float DEMKCBJMEFL()
	{
		return NonPlayerCharacterManager.animationAppearTimeCustom;
	}

	// Token: 0x06006852 RID: 26706 RVA: 0x00301A91 File Offset: 0x002FFC91
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
			tmpList[j].GetComponent<DialogNonPlayerCharacterManager>().DisappearAnimation(FJOIFOINENC.animationDisappearCached);
		}
		yield return new WaitForSeconds(DialogNonPlayerCharacterManager.GetDisappearAnimationLength());
		for (int k = 0; k < tmpList.Count; k++)
		{
			UnityEngine.Object.Destroy(tmpList[k]);
		}
		yield break;
	}

	// Token: 0x06006853 RID: 26707 RVA: 0x00301AA0 File Offset: 0x002FFCA0
	public FEMKDIHKJCM GetLastDialogStep()
	{
		return this.BMPCLNCMDEF;
	}

	// Token: 0x06006854 RID: 26708 RVA: 0x00301AA8 File Offset: 0x002FFCA8
	public void ShowDialog(GameObject KGFDGHFHCNJ, FEMKDIHKJCM GGPCHEHJNHO, FJOIFOINENC GMLIEKDKEAG)
	{
		this.BMPCLNCMDEF = GGPCHEHJNHO;
		this.IAECBPFCOFI = false;
		base.StartCoroutine(this.BAIKECODLGP());
		GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(KGFDGHFHCNJ);
		gameObject.transform.SetParent(this.dialogPivot.transform, false);
		if (this.PDIGPJOJACG != OFLIHLDBDEB.center && null != this.KFFIDFKOOIN)
		{
			gameObject.GetComponent<RectTransform>().OGOFACPLOGO(-NBDLBFJOEGN.FJJBMKDBPOM((float)this.KFFIDFKOOIN.bodyOffsetX) * (float)this.PDIGPJOJACG, NBDLBFJOEGN.FJJBMKDBPOM((float)this.KFFIDFKOOIN.bodyOffsetY));
		}
		gameObject.GetComponent<RectTransform>().AHLJBONHHKL(-this.PGAAAMPFGBP, this.OEEOLLNGOGM / 2f);
		if (!gameObject.GetComponent<DialogNonPlayerCharacterManager>().enableMaxCriticalAspectRatioOffsetOverride)
		{
			gameObject.GetComponent<RectTransform>().AHLJBONHHKL(1.1f * NonPlayerCharacterManager.maxCriticalAspectRatioOffset * NBDLBFJOEGN.GJGNABHPEKJ() + 1.1f * NonPlayerCharacterManager.maxCriticalAspectRatioOffset * NBDLBFJOEGN.CMAHBEFENAM());
		}
		else
		{
			gameObject.GetComponent<RectTransform>().AHLJBONHHKL(gameObject.GetComponent<DialogNonPlayerCharacterManager>().maxCriticalAspectRatioOffsetOverride * NBDLBFJOEGN.GJGNABHPEKJ() + gameObject.GetComponent<DialogNonPlayerCharacterManager>().maxCriticalAspectRatioOffsetOverride * NBDLBFJOEGN.CMAHBEFENAM());
		}
		if (null != this.KFFIDFKOOIN && this.KFFIDFKOOIN.dialogOffsetAppliesToNpcSide)
		{
			gameObject.GetComponent<RectTransform>().AHLJBONHHKL(0, this.KFFIDFKOOIN.dialogOffsetY);
		}
		gameObject.GetComponent<DialogNonPlayerCharacterManager>().PreInitialize(GGPCHEHJNHO);
		int num = 0;
		try
		{
			if (GGPCHEHJNHO != null)
			{
				int localizedTextLength = gameObject.GetComponent<DialogNonPlayerCharacterManager>().GetLocalizedTextLength();
				if (gameObject.GetComponent<DialogNonPlayerCharacterManager>().isSmallFont)
				{
					if (localizedTextLength > 300)
					{
						num = localizedTextLength / 8;
					}
				}
				else if (localizedTextLength > 180)
				{
					num = localizedTextLength / 4;
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
		gameObject.GetComponent<RectTransform>().AHLJBONHHKL(0, gameObject.GetComponent<DialogNonPlayerCharacterManager>().dialogOffsetY + num);
		gameObject.GetComponent<DialogNonPlayerCharacterManager>().Initialize(GGPCHEHJNHO);
		gameObject.GetComponent<DialogNonPlayerCharacterManager>().AppearAnimation(GMLIEKDKEAG);
		this.JPDLGGBMFDP.Add(gameObject);
	}

	// Token: 0x06006855 RID: 26709 RVA: 0x00301CB0 File Offset: 0x002FFEB0
	public float GetAnimationScaleCoefficient()
	{
		float num = Mathf.Abs(this.OEEOLLNGOGM) / 2048f;
		num = Mathf.Clamp01(num);
		return Mathf.Lerp(0.97f, 1f, num);
	}

	// Token: 0x06006856 RID: 26710 RVA: 0x00300804 File Offset: 0x002FEA04
	public FLNOFHCNJDM GetLastEmotionRequested()
	{
		return this.FPNOAIADDHB;
	}

	// Token: 0x06006857 RID: 26711 RVA: 0x00301CE6 File Offset: 0x002FFEE6
	private IEnumerator JCILPOJDHJP(FLNOFHCNJDM GFIMGNJBJHH)
	{
		NonPlayerCharacterManager.KMFAMBFEOCJ kmfambfeocj = new NonPlayerCharacterManager.KMFAMBFEOCJ(1);
		kmfambfeocj.<>4__this = this;
		kmfambfeocj._emotion = GFIMGNJBJHH;
		return kmfambfeocj;
	}

	// Token: 0x06006858 RID: 26712 RVA: 0x00301CFC File Offset: 0x002FFEFC
	public void MarkDialogsDestroyedByStep()
	{
		this.IAECBPFCOFI = true;
	}

	// Token: 0x06006859 RID: 26713 RVA: 0x00301D05 File Offset: 0x002FFF05
	public static float FINLNKLGIDI()
	{
		return NonPlayerCharacterManager.animationDisappearTime * KDCJJBLGCBH.EHBBFMCILPC.KNMPOFPJKPC();
	}

	// Token: 0x0600685A RID: 26714 RVA: 0x00301D17 File Offset: 0x002FFF17
	public FLNOFHCNJDM GetLastDelayedDefaultEmotionRequested()
	{
		return this.CKGPKDECDGN;
	}

	// Token: 0x0600685B RID: 26715 RVA: 0x00301D1F File Offset: 0x002FFF1F
	private IEnumerator AHIDCFGHGIO()
	{
		NonPlayerCharacterManager.IEPMGNADGEO iepmgnadgeo = new NonPlayerCharacterManager.IEPMGNADGEO(1);
		iepmgnadgeo.<>4__this = this;
		return iepmgnadgeo;
	}

	// Token: 0x0600685C RID: 26716 RVA: 0x00301D30 File Offset: 0x002FFF30
	public void FGKPPKIIOBJ(float JHBAIJIJIBN)
	{
		this.CILKAPFPFCA = true;
		if (null != this.NCIJPAGAFKB)
		{
			this.NCIJPAGAFKB.DOFade(1140f, JHBAIJIJIBN).SetEase(Ease.InQuad);
			return;
		}
		this.PANMNKKODPC.DOFade(1015f, JHBAIJIJIBN).SetEase(Ease.InQuad);
		if (null != this.KFFIDFKOOIN && !this.KFFIDFKOOIN.isMissingBody && !this.KFFIDFKOOIN.disableEmotionFade && this.KFFIDFKOOIN.emotions.Count > 0)
		{
			this.faceImageCur.DOFade(459f, 1041f * KDCJJBLGCBH.EHBBFMCILPC.OIABNIJLJBE());
			this.faceImagePrev.DOFade(1587f, 1681f * KDCJJBLGCBH.EHBBFMCILPC.OIABNIJLJBE());
		}
	}

	// Token: 0x0600685D RID: 26717 RVA: 0x00301E00 File Offset: 0x00300000
	private FLNOFHCNJDM ADEMFGHHEHJ(FLNOFHCNJDM GFIMGNJBJHH)
	{
		if (null != this.KFFIDFKOOIN)
		{
			bool flag = false;
			bool flag2 = false;
			bool flag3 = false;
			bool flag4 = false;
			bool flag5 = false;
			bool flag6 = false;
			bool flag7 = false;
			if (this.DLOBJLEKAPJ.Count > 0)
			{
				for (int i = 0; i < this.DLOBJLEKAPJ.Count; i++)
				{
					for (int j = 0; j < this.DLOBJLEKAPJ[i].emotions.Count; j++)
					{
						if (this.DLOBJLEKAPJ[i].emotions[j].type == GFIMGNJBJHH)
						{
							return GFIMGNJBJHH;
						}
						if (this.DLOBJLEKAPJ[i].emotions[j].type == FLNOFHCNJDM.neutral)
						{
							flag = true;
						}
						else if (this.DLOBJLEKAPJ[i].emotions[j].type == FLNOFHCNJDM.smile)
						{
							flag2 = true;
						}
						else if (this.DLOBJLEKAPJ[i].emotions[j].type == FLNOFHCNJDM.laugh)
						{
							flag3 = true;
						}
						else if (this.DLOBJLEKAPJ[i].emotions[j].type == FLNOFHCNJDM.fear)
						{
							flag4 = true;
						}
						else if (this.DLOBJLEKAPJ[i].emotions[j].type == FLNOFHCNJDM.surprise)
						{
							flag5 = true;
						}
						else if (this.DLOBJLEKAPJ[i].emotions[j].type == FLNOFHCNJDM.sadness)
						{
							flag6 = true;
						}
						else if (this.DLOBJLEKAPJ[i].emotions[j].type == FLNOFHCNJDM.disappointment)
						{
							flag7 = true;
						}
					}
				}
				if (GFIMGNJBJHH == FLNOFHCNJDM.smile && flag3)
				{
					return FLNOFHCNJDM.laugh;
				}
				if (GFIMGNJBJHH == FLNOFHCNJDM.laugh && flag2)
				{
					return FLNOFHCNJDM.smile;
				}
				if (GFIMGNJBJHH == FLNOFHCNJDM.fear && flag5)
				{
					return FLNOFHCNJDM.surprise;
				}
				if (GFIMGNJBJHH == FLNOFHCNJDM.surprise && flag4)
				{
					return FLNOFHCNJDM.fear;
				}
				if (GFIMGNJBJHH == FLNOFHCNJDM.sadness && flag7)
				{
					return FLNOFHCNJDM.disappointment;
				}
				if (GFIMGNJBJHH == FLNOFHCNJDM.disappointment && flag6)
				{
					return FLNOFHCNJDM.sadness;
				}
				if (flag)
				{
					return FLNOFHCNJDM.neutral;
				}
				flag = false;
				flag2 = false;
				flag3 = false;
				flag4 = false;
				flag5 = false;
				flag6 = false;
				flag7 = false;
			}
			for (int k = 0; k < this.KFFIDFKOOIN.emotions.Count; k++)
			{
				if (this.KFFIDFKOOIN.emotions[k].type == GFIMGNJBJHH)
				{
					return GFIMGNJBJHH;
				}
				if (this.KFFIDFKOOIN.emotions[k].type == FLNOFHCNJDM.neutral)
				{
					flag = true;
				}
				else if (this.KFFIDFKOOIN.emotions[k].type == FLNOFHCNJDM.smile)
				{
					flag2 = true;
				}
				else if (this.KFFIDFKOOIN.emotions[k].type == FLNOFHCNJDM.laugh)
				{
					flag3 = true;
				}
				else if (this.KFFIDFKOOIN.emotions[k].type == FLNOFHCNJDM.fear)
				{
					flag4 = true;
				}
				else if (this.KFFIDFKOOIN.emotions[k].type == FLNOFHCNJDM.surprise)
				{
					flag5 = true;
				}
				else if (this.KFFIDFKOOIN.emotions[k].type == FLNOFHCNJDM.sadness)
				{
					flag6 = true;
				}
				else if (this.KFFIDFKOOIN.emotions[k].type == FLNOFHCNJDM.disappointment)
				{
					flag7 = true;
				}
			}
			if (GFIMGNJBJHH == FLNOFHCNJDM.smile && flag3)
			{
				return FLNOFHCNJDM.laugh;
			}
			if (GFIMGNJBJHH == FLNOFHCNJDM.laugh && flag2)
			{
				return FLNOFHCNJDM.smile;
			}
			if (GFIMGNJBJHH == FLNOFHCNJDM.fear && flag5)
			{
				return FLNOFHCNJDM.surprise;
			}
			if (GFIMGNJBJHH == FLNOFHCNJDM.surprise && flag4)
			{
				return FLNOFHCNJDM.fear;
			}
			if (GFIMGNJBJHH == FLNOFHCNJDM.sadness && flag7)
			{
				return FLNOFHCNJDM.disappointment;
			}
			if (GFIMGNJBJHH == FLNOFHCNJDM.disappointment && flag6)
			{
				return FLNOFHCNJDM.sadness;
			}
			if (!flag && this.KFFIDFKOOIN.emotions.Count > 0)
			{
				return this.KFFIDFKOOIN.emotions[0].type;
			}
		}
		return FLNOFHCNJDM.neutral;
	}

	// Token: 0x0600685E RID: 26718 RVA: 0x0030219C File Offset: 0x0030039C
	public void SetLastDialogStep(FEMKDIHKJCM GGPCHEHJNHO)
	{
		this.BMPCLNCMDEF = GGPCHEHJNHO;
	}

	// Token: 0x0600685F RID: 26719 RVA: 0x003021A8 File Offset: 0x003003A8
	public bool EffectiveLoungePropsChanged()
	{
		bool result;
		try
		{
			if (this.IHCMBIBJBJD == null)
			{
				result = false;
			}
			else
			{
				List<string> list = NonPlayerCharacterManager.PFGLCGGHHFL(this.IHCMBIBJBJD, this.OLPMONKMBPO, this.NLNOHDDCALL);
				if (list.Count != this.EDOHKDALPIF.Count)
				{
					result = true;
				}
				else
				{
					for (int i = 0; i < list.Count; i++)
					{
						if (!this.EDOHKDALPIF.Contains(list[i]))
						{
							return true;
						}
					}
					result = false;
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

	// Token: 0x06006860 RID: 26720 RVA: 0x0030219C File Offset: 0x0030039C
	public void OMBJFJLGOOF(FEMKDIHKJCM GGPCHEHJNHO)
	{
		this.BMPCLNCMDEF = GGPCHEHJNHO;
	}

	// Token: 0x06006861 RID: 26721 RVA: 0x00301D17 File Offset: 0x002FFF17
	public FLNOFHCNJDM CCHPKAOEAFF()
	{
		return this.CKGPKDECDGN;
	}

	// Token: 0x06006862 RID: 26722 RVA: 0x00302238 File Offset: 0x00300438
	public void HideAtOnce()
	{
		if (null != this.faceImageCur)
		{
			this.faceImageCur.DOKill(false);
		}
		if (null != this.faceImagePrev)
		{
			this.faceImagePrev.DOKill(false);
		}
		this.SetVisibility(false);
	}

	// Token: 0x06006863 RID: 26723 RVA: 0x00302278 File Offset: 0x00300478
	public bool IsEqual(string PDEADFPONFH, List<string> MPLEPCPGJBA)
	{
		if (this.IHCMBIBJBJD.Equals(PDEADFPONFH) && this.OLPMONKMBPO.Count == MPLEPCPGJBA.Count)
		{
			for (int i = 0; i < MPLEPCPGJBA.Count; i++)
			{
				if (!this.OLPMONKMBPO[i].Equals(MPLEPCPGJBA[i]))
				{
					return false;
				}
			}
			return true;
		}
		return false;
	}

	// Token: 0x06006864 RID: 26724 RVA: 0x003022D8 File Offset: 0x003004D8
	public void HideDialogsAtOnce()
	{
		for (int i = 0; i < this.JPDLGGBMFDP.Count; i++)
		{
			if (null != this.JPDLGGBMFDP[i])
			{
				this.JPDLGGBMFDP[i].SetActive(false);
			}
		}
	}

	// Token: 0x06006865 RID: 26725 RVA: 0x00302324 File Offset: 0x00300524
	private static void LIACBFHLJCB(string FBKAPCPPNKA, List<string> MEMLMIDBOAG)
	{
		try
		{
			ECJCFGAOPHJ ecjcfgaophj = AssetsManager.EHBBFMCILPC.lobbyDataAsset.MFMJHIFAOHE().DCPPCOHEAFA(FBKAPCPPNKA);
			if (ecjcfgaophj != null && ecjcfgaophj.GAGNFIDEJNC != null && ecjcfgaophj.GAGNFIDEJNC.Count != 0)
			{
				int num = 0;
				for (int i = 0; i < ecjcfgaophj.GAGNFIDEJNC.Count; i++)
				{
					while (MEMLMIDBOAG.Remove(ecjcfgaophj.GAGNFIDEJNC[i]))
					{
						num++;
					}
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x06006867 RID: 26727 RVA: 0x0030241D File Offset: 0x0030061D
	public bool PCBBFEPBJIM()
	{
		return this.IAECBPFCOFI;
	}

	// Token: 0x06006868 RID: 26728 RVA: 0x00302428 File Offset: 0x00300628
	public void MAHHJBLOJFA(GFEJBOAKPMP GMLIEKDKEAG)
	{
		this.CILKAPFPFCA = false;
		CanvasGroup canvasGroup = this.PANMNKKODPC;
		bool flag = this.OBAAPOLFIMD;
		if (null != this.NCIJPAGAFKB)
		{
			canvasGroup = this.NCIJPAGAFKB;
			flag = false;
		}
		if (flag)
		{
			canvasGroup.alpha = 900f;
			if (NonPlayerCharacterManager.animationAppearTimeCustom > 1584f)
			{
				if (null != this.KFFIDFKOOIN && !this.KFFIDFKOOIN.isMissingBody && !this.KFFIDFKOOIN.disableEmotionFade && (double)NonPlayerCharacterManager.animationAppearTime > 1233.0)
				{
					NonPlayerCharacterManager.NMBFLEBDGJN = NonPlayerCharacterManager.animationAppearTimeCustom / NonPlayerCharacterManager.animationAppearTime * 1227f;
				}
				canvasGroup.DOFade(1261f, NonPlayerCharacterManager.animationAppearTimeCustom).SetEase(Ease.InCubic);
				NonPlayerCharacterManager.animationAppearTimeCustom = 654f;
			}
			else
			{
				canvasGroup.DOFade(1980f, NonPlayerCharacterManager.animationAppearTime * KDCJJBLGCBH.EHBBFMCILPC.LIKMBLFBEIA()).SetEase(Ease.InSine);
			}
		}
		if (GMLIEKDKEAG == GFEJBOAKPMP.animationStoryAppearFromLeft || GMLIEKDKEAG == GFEJBOAKPMP.animationStoryAppearFromRight)
		{
			int num = 0;
			if (GMLIEKDKEAG == GFEJBOAKPMP.animationStoryAppearFromLeft)
			{
				num = -1;
			}
			this.DGAAFGDHHHJ.AHLJBONHHKL(NonPlayerCharacterManager.appearTranslationAmount * num, -51);
			this.DGAAFGDHHHJ.DOAnchorPos(this.DGAAFGDHHHJ.anchoredPosition + new Vector2((float)(-(float)NonPlayerCharacterManager.appearTranslationAmount * num), 1664f), NonPlayerCharacterManager.animationAppearTime * KDCJJBLGCBH.EHBBFMCILPC.LIKMBLFBEIA(), false).SetEase(Ease.OutSine);
			return;
		}
		if (GMLIEKDKEAG == GFEJBOAKPMP.animationChoiceMetaAppear || GMLIEKDKEAG == GFEJBOAKPMP.animationStoryAppearFromLeft)
		{
			int num2 = 0;
			if (GMLIEKDKEAG == GFEJBOAKPMP.animationChoiceMetaAppearFromRight)
			{
				num2 = -1;
			}
			this.DGAAFGDHHHJ.AHLJBONHHKL(NonPlayerCharacterManager.appearTranslationAmount * num2, 1);
			this.DGAAFGDHHHJ.DOAnchorPos(this.DGAAFGDHHHJ.anchoredPosition + new Vector2((float)(-(float)NonPlayerCharacterManager.appearTranslationAmount * num2), 256f), NonPlayerCharacterManager.animationAppearTime * KDCJJBLGCBH.EHBBFMCILPC.LIKMBLFBEIA(), false).SetEase(Ease.InCubic);
		}
	}

	// Token: 0x06006869 RID: 26729 RVA: 0x003025E7 File Offset: 0x003007E7
	public void RecordLineEmotion(FLNOFHCNJDM GFIMGNJBJHH, FLNOFHCNJDM PMDGGEDPHJC)
	{
		this.FPNOAIADDHB = GFIMGNJBJHH;
		this.CKGPKDECDGN = PMDGGEDPHJC;
	}

	// Token: 0x0600686A RID: 26730 RVA: 0x003025F8 File Offset: 0x003007F8
	private static void PENPJIOMDGO(string FBKAPCPPNKA, List<string> MEMLMIDBOAG, bool JLJLENFAAFA)
	{
		try
		{
			ECJCFGAOPHJ ecjcfgaophj = AssetsManager.EHBBFMCILPC.lobbyDataAsset.MFMJHIFAOHE().DCPPCOHEAFA(FBKAPCPPNKA);
			if (ecjcfgaophj != null)
			{
				List<string> list = (CEIBHCNNIDC.ru == LanguageManager.EHBBFMCILPC.GetSelectedLanguage()) ? ecjcfgaophj.HNLGMBDMOKA : ecjcfgaophj.OFLLFDDLKFA;
				if (list != null && list.Count != 0)
				{
					if (NonPlayerCharacterManager.AFPKFGJOCAF(FBKAPCPPNKA, JLJLENFAAFA))
					{
						int num = 0;
						for (int i = 0; i < list.Count; i++)
						{
							if (!MEMLMIDBOAG.Contains(list[i]))
							{
								MEMLMIDBOAG.Add(list[i]);
								num++;
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
	}

	// Token: 0x0600686B RID: 26731 RVA: 0x003008FD File Offset: 0x002FEAFD
	public void SetCustomFadeCanvasGroup(CanvasGroup CDFPPHCNOLD)
	{
		this.NCIJPAGAFKB = CDFPPHCNOLD;
	}

	// Token: 0x0600686C RID: 26732 RVA: 0x003026A4 File Offset: 0x003008A4
	private IEnumerator KGGPFIHIHNC(FLNOFHCNJDM GFIMGNJBJHH)
	{
		yield return new WaitForSeconds(NonPlayerCharacterManager.setEmotionDelay);
		this.SetEmotion(GFIMGNJBJHH, BIDPEOLOIIG.appearImmediateFade, FLNOFHCNJDM.neutral);
		yield break;
	}

	// Token: 0x0600686D RID: 26733 RVA: 0x0030241D File Offset: 0x0030061D
	public bool DialogsDestroyedByStep()
	{
		return this.IAECBPFCOFI;
	}

	// Token: 0x0600686E RID: 26734 RVA: 0x003026BC File Offset: 0x003008BC
	public void AnimateDisappearance(GFEJBOAKPMP GMLIEKDKEAG)
	{
		if (null != this.NCIJPAGAFKB)
		{
			this.NCIJPAGAFKB.DOFade(0f, NonPlayerCharacterManager.animationDisappearTime * KDCJJBLGCBH.EHBBFMCILPC.LIKMBLFBEIA()).SetEase(Ease.OutQuad);
		}
		else if (!this.OBAAPOLFIMD)
		{
			this.PANMNKKODPC.DOFade(0f, NonPlayerCharacterManager.animationDisappearTime * KDCJJBLGCBH.EHBBFMCILPC.LIKMBLFBEIA()).SetEase(Ease.OutQuad);
		}
		if (GMLIEKDKEAG == GFEJBOAKPMP.animationStoryDisappearToLeft || GMLIEKDKEAG == GFEJBOAKPMP.animationStoryDisappearToRight)
		{
			int num = -1;
			if (GMLIEKDKEAG == GFEJBOAKPMP.animationStoryDisappearToLeft)
			{
				num = 1;
			}
			this.DGAAFGDHHHJ.DOAnchorPos(this.DGAAFGDHHHJ.anchoredPosition + new Vector2((float)(-(float)NonPlayerCharacterManager.disappearTranslationAmount * num), -5f), NonPlayerCharacterManager.animationDisappearTime * KDCJJBLGCBH.EHBBFMCILPC.LIKMBLFBEIA(), false).SetEase(Ease.OutQuad);
			this.DGAAFGDHHHJ.DOScale(this.DGAAFGDHHHJ.localScale * this.GetAnimationScaleCoefficient(), NonPlayerCharacterManager.animationDisappearTime * KDCJJBLGCBH.EHBBFMCILPC.LIKMBLFBEIA());
		}
		if (null == this.NCIJPAGAFKB && null != this.KFFIDFKOOIN)
		{
			if (!this.KFFIDFKOOIN.isMissingBody && !this.KFFIDFKOOIN.disableEmotionFade)
			{
				if (this.KFFIDFKOOIN.emotions.Count > 0)
				{
					this.faceImageCur.DOFade(0f, 0.1f * KDCJJBLGCBH.EHBBFMCILPC.OIABNIJLJBE());
					this.faceImagePrev.DOFade(0f, 0.1f * KDCJJBLGCBH.EHBBFMCILPC.OIABNIJLJBE());
					return;
				}
			}
			else if (this.KFFIDFKOOIN.emotions.Count > 0)
			{
				this.faceImageCur.DOFade(0f, 0.5f * KDCJJBLGCBH.EHBBFMCILPC.OIABNIJLJBE());
				this.faceImagePrev.DOFade(0f, 0.5f * KDCJJBLGCBH.EHBBFMCILPC.OIABNIJLJBE());
			}
		}
	}

	// Token: 0x04001EA4 RID: 7844
	public static float setEmotionDelay = 0.5f;

	// Token: 0x04001EA5 RID: 7845
	public static float animatedEmotionChangeTime = 0.2f;

	// Token: 0x04001EA6 RID: 7846
	public static float animationAppearTime = 0.2f;

	// Token: 0x04001EA7 RID: 7847
	public static float animationAppearTimeCustom = -1f;

	// Token: 0x04001EA8 RID: 7848
	public static float animationDisappearTime = 0.2f;

	// Token: 0x04001EA9 RID: 7849
	public static Vector2 maxCriticalAspectRatioOffset = new Vector2(60f, 0f);

	// Token: 0x04001EAA RID: 7850
	public static int appearTranslationAmount = 40;

	// Token: 0x04001EAB RID: 7851
	public static int disappearTranslationAmount = 80;

	// Token: 0x04001EAC RID: 7852
	public GameObject dialogPivot;

	// Token: 0x04001EAD RID: 7853
	public GameObject overlayPivot;

	// Token: 0x04001EAE RID: 7854
	public Image bodyImage;

	// Token: 0x04001EAF RID: 7855
	public Image faceImagePrev;

	// Token: 0x04001EB0 RID: 7856
	public Image faceImageCur;

	// Token: 0x04001EB1 RID: 7857
	public Image overlayImagePrefab;

	// Token: 0x04001EB2 RID: 7858
	public List<Image> overlayImages = new List<Image>();

	// Token: 0x04001EB3 RID: 7859
	public Material genericEtc1AlphaSplitMaterial;

	// Token: 0x04001EB4 RID: 7860
	private List<GameObject> JPDLGGBMFDP = new List<GameObject>();

	// Token: 0x04001EB5 RID: 7861
	private AssetStoryNpc KFFIDFKOOIN;

	// Token: 0x04001EB6 RID: 7862
	private List<AssetStoryNpc> DLOBJLEKAPJ = new List<AssetStoryNpc>();

	// Token: 0x04001EB7 RID: 7863
	private CanvasGroup PANMNKKODPC;

	// Token: 0x04001EB8 RID: 7864
	private RectTransform DGAAFGDHHHJ;

	// Token: 0x04001EB9 RID: 7865
	private string IHCMBIBJBJD;

	// Token: 0x04001EBA RID: 7866
	private FEMKDIHKJCM BMPCLNCMDEF;

	// Token: 0x04001EBB RID: 7867
	private bool IAECBPFCOFI;

	// Token: 0x04001EBC RID: 7868
	private bool CILKAPFPFCA;

	// Token: 0x04001EBD RID: 7869
	private FLNOFHCNJDM FPNOAIADDHB;

	// Token: 0x04001EBE RID: 7870
	private FLNOFHCNJDM CKGPKDECDGN;

	// Token: 0x04001EBF RID: 7871
	private List<string> OLPMONKMBPO = new List<string>();

	// Token: 0x04001EC0 RID: 7872
	private List<Image> COCJDIGOBNL = new List<Image>();

	// Token: 0x04001EC1 RID: 7873
	private List<Material> JBGBGLAGGPD = new List<Material>();

	// Token: 0x04001EC2 RID: 7874
	private OFLIHLDBDEB PDIGPJOJACG;

	// Token: 0x04001EC3 RID: 7875
	private bool OBAAPOLFIMD;

	// Token: 0x04001EC4 RID: 7876
	private CanvasGroup NCIJPAGAFKB;

	// Token: 0x04001EC5 RID: 7877
	private bool KHMHLBGPMKC;

	// Token: 0x04001EC6 RID: 7878
	private float PGAAAMPFGBP;

	// Token: 0x04001EC7 RID: 7879
	private float OEEOLLNGOGM;

	// Token: 0x04001EC8 RID: 7880
	private Material PENHKBHCJFI;

	// Token: 0x04001EC9 RID: 7881
	private bool KKJPHDDMKLH;

	// Token: 0x04001ECA RID: 7882
	private static float NMBFLEBDGJN = 1f;

	// Token: 0x04001ECB RID: 7883
	private static int BKCPMIPKBOK = 0;

	// Token: 0x04001ECC RID: 7884
	private AssetStoryNpcAnimation IJHNBMPHKAN;

	// Token: 0x04001ECD RID: 7885
	private Image NCNKGMEPGEG;

	// Token: 0x04001ECE RID: 7886
	private ODLLAEHMFAA KIPLFNDGFOH;

	// Token: 0x04001ECF RID: 7887
	private int LELCNKCENCP;

	// Token: 0x04001ED0 RID: 7888
	private AssetStoryNpcAnimationEmotionDesc GMIGNCDLCMG;

	// Token: 0x04001ED1 RID: 7889
	private ODLLAEHMFAA AJFAAICNHPA;

	// Token: 0x04001ED2 RID: 7890
	private int HEAPGAMPCGN;

	// Token: 0x04001ED3 RID: 7891
	private List<Image> LOICJDHILCM = new List<Image>();

	// Token: 0x04001ED4 RID: 7892
	private List<AssetStoryNpcAnimationPropDesc> PJNBHNPBIMK = new List<AssetStoryNpcAnimationPropDesc>();

	// Token: 0x04001ED5 RID: 7893
	private ODLLAEHMFAA FLKLHGAEIDH;

	// Token: 0x04001ED6 RID: 7894
	private int DPNCLAAFNKP;

	// Token: 0x04001ED7 RID: 7895
	private bool PGDLAMFNIED;

	// Token: 0x04001ED8 RID: 7896
	private List<bool> JDDBCJFGHDE = new List<bool>();

	// Token: 0x04001ED9 RID: 7897
	private List<string> EDOHKDALPIF = new List<string>();

	// Token: 0x04001EDA RID: 7898
	private bool NLNOHDDCALL;
}
