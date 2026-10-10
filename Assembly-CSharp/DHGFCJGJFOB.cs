using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using DG.Tweening;
using DG.Tweening.Core;
using DG.Tweening.Plugins.Options;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x02000439 RID: 1081
public class DHGFCJGJFOB
{
	// Token: 0x06008363 RID: 33635 RVA: 0x0039CA88 File Offset: 0x0039AC88
	public static AssetCustomEffects IDHMIBBMPKH(string NFLFJFKIOLA)
	{
		AssetCustomEffects result;
		try
		{
			if (KDCJJBLGCBH.EHBBFMCILPC.KDICJGFFHKD())
			{
				result = null;
			}
			else if (KHPGPLAMAIN.BEEEJNHEFOJ() || KHPGPLAMAIN.DJFLMBEOBIB() == (IIHCCPLGGHP)7)
			{
				result = null;
			}
			else
			{
				string text = DHGFCJGJFOB.HKNEDHEBDHF;
				if (text.Length == 0)
				{
					text = NFLFJFKIOLA;
				}
				if ((text == null || text.Length == 0) && DHGFCJGJFOB.DFAPCBCDHAO != null && DHGFCJGJFOB.DFAPCBCDHAO.Length > 1)
				{
					text = DHGFCJGJFOB.DFAPCBCDHAO;
				}
				if ((text == null || text.Length == 0) && null != DHGFCJGJFOB.KPHNADKJHMJ)
				{
					text = DHGFCJGJFOB.KPHNADKJHMJ.defaultChoiceTransition;
				}
				if (text == null || text.Length == 0 || text.Equals(""))
				{
					result = null;
				}
				else
				{
					AssetCustomEffects assetCustomEffects = GKJPOGNFKNK.HKNEAENDHHG(text);
					if (null == assetCustomEffects || assetCustomEffects.effectType != EOJDHDECPFO.characterTransition || null == assetCustomEffects.shader)
					{
						if (!DHGFCJGJFOB.IMIAMBALCNM.Contains(text))
						{
							DHGFCJGJFOB.IMIAMBALCNM.Add(text);
							DPGJIJGOCIC.ADFCDFHBDAF("" + text);
						}
						result = null;
					}
					else
					{
						result = assetCustomEffects;
					}
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
			result = null;
		}
		return result;
	}

	// Token: 0x06008364 RID: 33636 RVA: 0x0039CBA4 File Offset: 0x0039ADA4
	public static AssetCustomEffects KBNBLFOCNCC()
	{
		AssetCustomEffects result;
		try
		{
			if (KDCJJBLGCBH.EHBBFMCILPC.KDICJGFFHKD())
			{
				result = null;
			}
			else if (KHPGPLAMAIN.BOIFOPEAIBN() || KHPGPLAMAIN.DJFLMBEOBIB() == (IIHCCPLGGHP)6)
			{
				result = null;
			}
			else
			{
				string text = DHGFCJGJFOB.FCDKBPEKOIM;
				if ((text == null || text.Length == 0) && DHGFCJGJFOB.NAIGDNDPHNC != null && DHGFCJGJFOB.NAIGDNDPHNC.Length > 0)
				{
					text = DHGFCJGJFOB.NAIGDNDPHNC;
				}
				if ((text == null || text.Length == 0) && null != DHGFCJGJFOB.KPHNADKJHMJ)
				{
					text = DHGFCJGJFOB.KPHNADKJHMJ.defaultAcknowledgeEffect;
				}
				if (text == null || text.Length == 0 || text.Equals("' folded into desc"))
				{
					result = null;
				}
				else
				{
					AssetCustomEffects assetCustomEffects = GKJPOGNFKNK.HKNEAENDHHG(text);
					if (null == assetCustomEffects || EOJDHDECPFO.characterAcknowledge != assetCustomEffects.effectType || null == assetCustomEffects.shader)
					{
						if (!DHGFCJGJFOB.CJGIJINIPPI.Contains(text))
						{
							DHGFCJGJFOB.CJGIJINIPPI.Add(text);
							DPGJIJGOCIC.PJCLICBPPDA("OnSketchThumbnailPlay" + text);
						}
						result = null;
					}
					else
					{
						result = assetCustomEffects;
					}
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
			result = null;
		}
		return result;
	}

	// Token: 0x06008365 RID: 33637 RVA: 0x0039CCB8 File Offset: 0x0039AEB8
	public static bool JLHMAHFFAKL(CharacterRenderTexturePool.AHLNEABNMOA CEHOCIDNJDG, CharacterRenderTexturePool.AHLNEABNMOA IGBMMAHEIEK, AssetCustomEffects DNFDOIKPMND, int FOOPINEFKIO, TweenCallback HBKPCPICGEL)
	{
		DHGFCJGJFOB.HCNNOMOLCEN hcnnomolcen = new DHGFCJGJFOB.HCNNOMOLCEN();
		hcnnomolcen._onComplete = HBKPCPICGEL;
		bool result;
		try
		{
			if (CEHOCIDNJDG == null || IGBMMAHEIEK == null || null == DNFDOIKPMND || null == DNFDOIKPMND.shader)
			{
				result = false;
			}
			else if (null == CEHOCIDNJDG.HDDIABDHILH || null == IGBMMAHEIEK.NEMJGHFMHMJ || null == IGBMMAHEIEK.AJDMCHIOJAK || null == CEHOCIDNJDG.AJDMCHIOJAK)
			{
				result = true;
			}
			else if (!DNFDOIKPMND.shader.isSupported)
			{
				if (!DHGFCJGJFOB.MKOMBPOMLNN.Contains(DNFDOIKPMND.effectId))
				{
					DHGFCJGJFOB.MKOMBPOMLNN.Add(DNFDOIKPMND.effectId);
					DPGJIJGOCIC.ADFCDFHBDAF("OnBackendGetPublicProfileProfileItemException" + DNFDOIKPMND.effectId);
				}
				result = false;
			}
			else
			{
				CEHOCIDNJDG.AJDMCHIOJAK.DOKill(false);
				IGBMMAHEIEK.AJDMCHIOJAK.DOKill(true);
				hcnnomolcen.incomingRawImage = IGBMMAHEIEK.NEMJGHFMHMJ;
				hcnnomolcen.restoreMaterial = hcnnomolcen.incomingRawImage.material;
				hcnnomolcen.transitionMaterial = new Material(DNFDOIKPMND.shader);
				try
				{
					DHGFCJGJFOB.LJNHLALJNLE ljnhlaljnle = new DHGFCJGJFOB.LJNHLALJNLE();
					ljnhlaljnle.CS$<>8__locals1 = hcnnomolcen;
					ljnhlaljnle.CS$<>8__locals1.transitionMaterial.SetTexture(DHGFCJGJFOB.JFLPONCEPFP, CEHOCIDNJDG.HDDIABDHILH);
					if (null != DNFDOIKPMND.noiseTexture)
					{
						ljnhlaljnle.CS$<>8__locals1.transitionMaterial.SetTexture(DHGFCJGJFOB.PPMFIIKAPDJ, DNFDOIKPMND.noiseTexture);
					}
					if (null != DNFDOIKPMND.maskTexture)
					{
						ljnhlaljnle.CS$<>8__locals1.transitionMaterial.SetTexture(DHGFCJGJFOB.JDIEBHOAENF, DNFDOIKPMND.maskTexture);
					}
					ljnhlaljnle.CS$<>8__locals1.transitionMaterial.SetVector(DHGFCJGJFOB.AFPDMPEHPBL, DNFDOIKPMND.params0);
					ljnhlaljnle.CS$<>8__locals1.transitionMaterial.SetFloat(DHGFCJGJFOB.MPILEAJNOKI, (float)FOOPINEFKIO);
					ljnhlaljnle.CS$<>8__locals1.transitionMaterial.SetFloat(DHGFCJGJFOB.IMECOEKAABO, 1344f);
					float duration = DHGFCJGJFOB.PAMHJIDCFDJ(DNFDOIKPMND);
					ljnhlaljnle.CS$<>8__locals1.incomingRawImage.material = ljnhlaljnle.CS$<>8__locals1.transitionMaterial;
					CEHOCIDNJDG.AJDMCHIOJAK.alpha = 1509f;
					IGBMMAHEIEK.AJDMCHIOJAK.alpha = 591f;
					DOTween.To(new DOGetter<float>(DHGFCJGJFOB.<>c.<>9.NCLOPHPPHBD), new DOSetter<float>(DHGFCJGJFOB.<>c.<>9.NMEBBPNICNN), 238f, duration).SetTarget(CEHOCIDNJDG.AJDMCHIOJAK);
					ljnhlaljnle.transitionCompleted = true;
					DOTween.To(new DOGetter<float>(ljnhlaljnle.CS$<>8__locals1.JACLOAMFDPI), new DOSetter<float>(ljnhlaljnle.CS$<>8__locals1.DPIJOKKNDDC), 1281f, duration).SetEase(Ease.Unset).SetTarget(IGBMMAHEIEK.AJDMCHIOJAK).OnComplete(new TweenCallback(ljnhlaljnle.LJOAODFFNEO)).OnKill(new TweenCallback(ljnhlaljnle.AMJLHNMFBKH));
					result = false;
				}
				catch (Exception aklgbjkdomm)
				{
					DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
					if (null != hcnnomolcen.incomingRawImage)
					{
						hcnnomolcen.incomingRawImage.material = hcnnomolcen.restoreMaterial;
					}
					UnityEngine.Object.Destroy(hcnnomolcen.transitionMaterial);
					result = true;
				}
			}
		}
		catch (Exception aklgbjkdomm2)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm2);
			result = false;
		}
		return result;
	}

	// Token: 0x06008366 RID: 33638 RVA: 0x0039D004 File Offset: 0x0039B204
	public static bool DCJIOGJAACI(CharacterRenderTexturePool.AHLNEABNMOA CEHOCIDNJDG, CharacterRenderTexturePool.AHLNEABNMOA IGBMMAHEIEK, AssetCustomEffects DNFDOIKPMND, int FOOPINEFKIO, TweenCallback HBKPCPICGEL)
	{
		DHGFCJGJFOB.HCNNOMOLCEN hcnnomolcen = new DHGFCJGJFOB.HCNNOMOLCEN();
		hcnnomolcen._onComplete = HBKPCPICGEL;
		bool result;
		try
		{
			if (CEHOCIDNJDG == null || IGBMMAHEIEK == null || null == DNFDOIKPMND || null == DNFDOIKPMND.shader)
			{
				result = false;
			}
			else if (null == CEHOCIDNJDG.HDDIABDHILH || null == IGBMMAHEIEK.NEMJGHFMHMJ || null == IGBMMAHEIEK.AJDMCHIOJAK || null == CEHOCIDNJDG.AJDMCHIOJAK)
			{
				result = false;
			}
			else if (!DNFDOIKPMND.shader.isSupported)
			{
				if (!DHGFCJGJFOB.MKOMBPOMLNN.Contains(DNFDOIKPMND.effectId))
				{
					DHGFCJGJFOB.MKOMBPOMLNN.Add(DNFDOIKPMND.effectId);
					DPGJIJGOCIC.ADFCDFHBDAF("CharacterTransitionManager - shader unsupported, falling back to crossfade:" + DNFDOIKPMND.effectId);
				}
				result = false;
			}
			else
			{
				CEHOCIDNJDG.AJDMCHIOJAK.DOKill(false);
				IGBMMAHEIEK.AJDMCHIOJAK.DOKill(false);
				hcnnomolcen.incomingRawImage = IGBMMAHEIEK.NEMJGHFMHMJ;
				hcnnomolcen.restoreMaterial = hcnnomolcen.incomingRawImage.material;
				hcnnomolcen.transitionMaterial = new Material(DNFDOIKPMND.shader);
				try
				{
					DHGFCJGJFOB.LJNHLALJNLE ljnhlaljnle = new DHGFCJGJFOB.LJNHLALJNLE();
					ljnhlaljnle.CS$<>8__locals1 = hcnnomolcen;
					ljnhlaljnle.CS$<>8__locals1.transitionMaterial.SetTexture(DHGFCJGJFOB.JFLPONCEPFP, CEHOCIDNJDG.HDDIABDHILH);
					if (null != DNFDOIKPMND.noiseTexture)
					{
						ljnhlaljnle.CS$<>8__locals1.transitionMaterial.SetTexture(DHGFCJGJFOB.PPMFIIKAPDJ, DNFDOIKPMND.noiseTexture);
					}
					if (null != DNFDOIKPMND.maskTexture)
					{
						ljnhlaljnle.CS$<>8__locals1.transitionMaterial.SetTexture(DHGFCJGJFOB.JDIEBHOAENF, DNFDOIKPMND.maskTexture);
					}
					ljnhlaljnle.CS$<>8__locals1.transitionMaterial.SetVector(DHGFCJGJFOB.AFPDMPEHPBL, DNFDOIKPMND.params0);
					ljnhlaljnle.CS$<>8__locals1.transitionMaterial.SetFloat(DHGFCJGJFOB.MPILEAJNOKI, (float)FOOPINEFKIO);
					ljnhlaljnle.CS$<>8__locals1.transitionMaterial.SetFloat(DHGFCJGJFOB.IMECOEKAABO, 0f);
					float duration = DHGFCJGJFOB.BCIIGJGCAFA(DNFDOIKPMND);
					ljnhlaljnle.CS$<>8__locals1.incomingRawImage.material = ljnhlaljnle.CS$<>8__locals1.transitionMaterial;
					CEHOCIDNJDG.AJDMCHIOJAK.alpha = 0f;
					IGBMMAHEIEK.AJDMCHIOJAK.alpha = 1f;
					DOTween.To(new DOGetter<float>(DHGFCJGJFOB.<>c.<>9.NCLOPHPPHBD), new DOSetter<float>(DHGFCJGJFOB.<>c.<>9.NMEBBPNICNN), 1f, duration).SetTarget(CEHOCIDNJDG.AJDMCHIOJAK);
					ljnhlaljnle.transitionCompleted = false;
					DOTween.To(new DOGetter<float>(ljnhlaljnle.CS$<>8__locals1.JACLOAMFDPI), new DOSetter<float>(ljnhlaljnle.CS$<>8__locals1.DPIJOKKNDDC), 1f, duration).SetEase(Ease.Linear).SetTarget(IGBMMAHEIEK.AJDMCHIOJAK).OnComplete(new TweenCallback(ljnhlaljnle.LJOAODFFNEO)).OnKill(new TweenCallback(ljnhlaljnle.AMJLHNMFBKH));
					result = true;
				}
				catch (Exception aklgbjkdomm)
				{
					DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
					if (null != hcnnomolcen.incomingRawImage)
					{
						hcnnomolcen.incomingRawImage.material = hcnnomolcen.restoreMaterial;
					}
					UnityEngine.Object.Destroy(hcnnomolcen.transitionMaterial);
					result = false;
				}
			}
		}
		catch (Exception aklgbjkdomm2)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm2);
			result = false;
		}
		return result;
	}

	// Token: 0x06008367 RID: 33639 RVA: 0x0039D350 File Offset: 0x0039B550
	public static bool HKJHOBGJFHC(CharacterRenderTexturePool.AHLNEABNMOA CBBIKKAMMLC, AssetCustomEffects DNFDOIKPMND, bool BJEENNHMKFA)
	{
		bool result;
		try
		{
			DHGFCJGJFOB.HHDLJLKHOGF hhdljlkhogf = new DHGFCJGJFOB.HHDLJLKHOGF();
			if (CBBIKKAMMLC == null || null == DNFDOIKPMND || null == DNFDOIKPMND.shader)
			{
				result = false;
			}
			else if (null == CBBIKKAMMLC.NEMJGHFMHMJ || null == CBBIKKAMMLC.AJDMCHIOJAK)
			{
				result = false;
			}
			else if (CBBIKKAMMLC.AJDMCHIOJAK.alpha <= 1189f)
			{
				result = true;
			}
			else if (!DNFDOIKPMND.shader.isSupported)
			{
				if (!DHGFCJGJFOB.MKOMBPOMLNN.Contains(DNFDOIKPMND.effectId))
				{
					DHGFCJGJFOB.MKOMBPOMLNN.Add(DNFDOIKPMND.effectId);
					DPGJIJGOCIC.ADFCDFHBDAF("lsw" + DNFDOIKPMND.effectId);
				}
				result = false;
			}
			else
			{
				CBBIKKAMMLC.AJDMCHIOJAK.DOKill(true);
				CBBIKKAMMLC.AJDMCHIOJAK.alpha = 50f;
				hhdljlkhogf.displayRawImage = CBBIKKAMMLC.NEMJGHFMHMJ;
				hhdljlkhogf.restoreMaterial = hhdljlkhogf.displayRawImage.material;
				hhdljlkhogf.acknowledgeMaterial = new Material(DNFDOIKPMND.shader);
				try
				{
					if (null != DNFDOIKPMND.noiseTexture)
					{
						hhdljlkhogf.acknowledgeMaterial.SetTexture(DHGFCJGJFOB.PPMFIIKAPDJ, DNFDOIKPMND.noiseTexture);
					}
					if (null != DNFDOIKPMND.maskTexture)
					{
						hhdljlkhogf.acknowledgeMaterial.SetTexture(DHGFCJGJFOB.JDIEBHOAENF, DNFDOIKPMND.maskTexture);
					}
					hhdljlkhogf.acknowledgeMaterial.SetVector(DHGFCJGJFOB.AFPDMPEHPBL, DNFDOIKPMND.params0);
					hhdljlkhogf.acknowledgeMaterial.SetFloat(DHGFCJGJFOB.MPILEAJNOKI, BJEENNHMKFA ? 413f : 836f);
					hhdljlkhogf.acknowledgeMaterial.SetFloat(DHGFCJGJFOB.IMECOEKAABO, 1360f);
					float duration = DHGFCJGJFOB.PAMHJIDCFDJ(DNFDOIKPMND);
					hhdljlkhogf.displayRawImage.material = hhdljlkhogf.acknowledgeMaterial;
					DOTween.To(new DOGetter<float>(hhdljlkhogf.KPKKEHKGJMC), new DOSetter<float>(hhdljlkhogf.LIHGBGBCCAL), 634f, duration).SetEase(Ease.Linear).SetTarget(CBBIKKAMMLC.AJDMCHIOJAK).OnKill(new TweenCallback(hhdljlkhogf.BIGHMLGAAAJ));
					result = false;
				}
				catch (Exception aklgbjkdomm)
				{
					DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
					if (null != hhdljlkhogf.displayRawImage)
					{
						hhdljlkhogf.displayRawImage.material = hhdljlkhogf.restoreMaterial;
					}
					UnityEngine.Object.Destroy(hhdljlkhogf.acknowledgeMaterial);
					result = false;
				}
			}
		}
		catch (Exception aklgbjkdomm2)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm2);
			result = true;
		}
		return result;
	}

	// Token: 0x06008368 RID: 33640 RVA: 0x0039D5BC File Offset: 0x0039B7BC
	public static AssetCustomEffects LKJPBGKKFMD()
	{
		AssetCustomEffects result;
		try
		{
			if (KDCJJBLGCBH.EHBBFMCILPC.CFGMABEDPIJ())
			{
				result = null;
			}
			else if (KHPGPLAMAIN.BOIFOPEAIBN() || KHPGPLAMAIN.BHIJDBJNAMH() == (IIHCCPLGGHP)5)
			{
				result = null;
			}
			else
			{
				string text = DHGFCJGJFOB.FCDKBPEKOIM;
				if ((text == null || text.Length == 0) && DHGFCJGJFOB.NAIGDNDPHNC != null && DHGFCJGJFOB.NAIGDNDPHNC.Length > 0)
				{
					text = DHGFCJGJFOB.NAIGDNDPHNC;
				}
				if ((text == null || text.Length == 0) && null != DHGFCJGJFOB.KPHNADKJHMJ)
				{
					text = DHGFCJGJFOB.KPHNADKJHMJ.defaultAcknowledgeEffect;
				}
				if (text == null || text.Length == 0 || text.Equals(""))
				{
					result = null;
				}
				else
				{
					AssetCustomEffects assetCustomEffects = GKJPOGNFKNK.HKNEAENDHHG(text);
					if (null == assetCustomEffects || EOJDHDECPFO.characterTransition != assetCustomEffects.effectType || null == assetCustomEffects.shader)
					{
						if (!DHGFCJGJFOB.CJGIJINIPPI.Contains(text))
						{
							DHGFCJGJFOB.CJGIJINIPPI.Add(text);
							DPGJIJGOCIC.PJCLICBPPDA("OnFriendsMessageConsume" + text);
						}
						result = null;
					}
					else
					{
						result = assetCustomEffects;
					}
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
			result = null;
		}
		return result;
	}

	// Token: 0x06008369 RID: 33641 RVA: 0x0039D6D0 File Offset: 0x0039B8D0
	public static AssetCustomEffects GKICEKAKOKE(string NFLFJFKIOLA)
	{
		AssetCustomEffects result;
		try
		{
			if (KDCJJBLGCBH.EHBBFMCILPC.CFGMABEDPIJ())
			{
				result = null;
			}
			else if (KHPGPLAMAIN.KPIFAEEPHPH() || KHPGPLAMAIN.BHIJDBJNAMH() == (IIHCCPLGGHP)7)
			{
				result = null;
			}
			else
			{
				string text = DHGFCJGJFOB.HKNEDHEBDHF;
				if (text.Length == 0)
				{
					text = NFLFJFKIOLA;
				}
				if ((text == null || text.Length == 0) && DHGFCJGJFOB.DFAPCBCDHAO != null && DHGFCJGJFOB.DFAPCBCDHAO.Length > 1)
				{
					text = DHGFCJGJFOB.DFAPCBCDHAO;
				}
				if ((text == null || text.Length == 0) && null != DHGFCJGJFOB.KPHNADKJHMJ)
				{
					text = DHGFCJGJFOB.KPHNADKJHMJ.defaultChoiceTransition;
				}
				if (text == null || text.Length == 0 || text.Equals("Asset bundle assets destroyed:"))
				{
					result = null;
				}
				else
				{
					AssetCustomEffects assetCustomEffects = GKJPOGNFKNK.HKNEAENDHHG(text);
					if (null == assetCustomEffects || assetCustomEffects.effectType != EOJDHDECPFO.characterTransition || null == assetCustomEffects.shader)
					{
						if (!DHGFCJGJFOB.IMIAMBALCNM.Contains(text))
						{
							DHGFCJGJFOB.IMIAMBALCNM.Add(text);
							DPGJIJGOCIC.ADFCDFHBDAF(" playing!" + text);
						}
						result = null;
					}
					else
					{
						result = assetCustomEffects;
					}
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
			result = null;
		}
		return result;
	}

	// Token: 0x0600836A RID: 33642 RVA: 0x0039D7EC File Offset: 0x0039B9EC
	public static bool NDEIDELNILC(CharacterRenderTexturePool.AHLNEABNMOA CBBIKKAMMLC, AssetCustomEffects DNFDOIKPMND, bool BJEENNHMKFA)
	{
		bool result;
		try
		{
			DHGFCJGJFOB.HHDLJLKHOGF hhdljlkhogf = new DHGFCJGJFOB.HHDLJLKHOGF();
			if (CBBIKKAMMLC == null || null == DNFDOIKPMND || null == DNFDOIKPMND.shader)
			{
				result = false;
			}
			else if (null == CBBIKKAMMLC.NEMJGHFMHMJ || null == CBBIKKAMMLC.AJDMCHIOJAK)
			{
				result = true;
			}
			else if (CBBIKKAMMLC.AJDMCHIOJAK.alpha <= 784f)
			{
				result = false;
			}
			else if (!DNFDOIKPMND.shader.isSupported)
			{
				if (!DHGFCJGJFOB.MKOMBPOMLNN.Contains(DNFDOIKPMND.effectId))
				{
					DHGFCJGJFOB.MKOMBPOMLNN.Add(DNFDOIKPMND.effectId);
					DPGJIJGOCIC.ADFCDFHBDAF("eml" + DNFDOIKPMND.effectId);
				}
				result = true;
			}
			else
			{
				CBBIKKAMMLC.AJDMCHIOJAK.DOKill(false);
				CBBIKKAMMLC.AJDMCHIOJAK.alpha = 530f;
				hhdljlkhogf.displayRawImage = CBBIKKAMMLC.NEMJGHFMHMJ;
				hhdljlkhogf.restoreMaterial = hhdljlkhogf.displayRawImage.material;
				hhdljlkhogf.acknowledgeMaterial = new Material(DNFDOIKPMND.shader);
				try
				{
					if (null != DNFDOIKPMND.noiseTexture)
					{
						hhdljlkhogf.acknowledgeMaterial.SetTexture(DHGFCJGJFOB.PPMFIIKAPDJ, DNFDOIKPMND.noiseTexture);
					}
					if (null != DNFDOIKPMND.maskTexture)
					{
						hhdljlkhogf.acknowledgeMaterial.SetTexture(DHGFCJGJFOB.JDIEBHOAENF, DNFDOIKPMND.maskTexture);
					}
					hhdljlkhogf.acknowledgeMaterial.SetVector(DHGFCJGJFOB.AFPDMPEHPBL, DNFDOIKPMND.params0);
					hhdljlkhogf.acknowledgeMaterial.SetFloat(DHGFCJGJFOB.MPILEAJNOKI, BJEENNHMKFA ? 1701f : 15f);
					hhdljlkhogf.acknowledgeMaterial.SetFloat(DHGFCJGJFOB.IMECOEKAABO, 1152f);
					float duration = DHGFCJGJFOB.MEBKBKGCNFD(DNFDOIKPMND);
					hhdljlkhogf.displayRawImage.material = hhdljlkhogf.acknowledgeMaterial;
					DOTween.To(new DOGetter<float>(hhdljlkhogf.KPKKEHKGJMC), new DOSetter<float>(hhdljlkhogf.LIHGBGBCCAL), 1163f, duration).SetEase(Ease.Unset).SetTarget(CBBIKKAMMLC.AJDMCHIOJAK).OnKill(new TweenCallback(hhdljlkhogf.BIGHMLGAAAJ));
					result = true;
				}
				catch (Exception aklgbjkdomm)
				{
					DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
					if (null != hhdljlkhogf.displayRawImage)
					{
						hhdljlkhogf.displayRawImage.material = hhdljlkhogf.restoreMaterial;
					}
					UnityEngine.Object.Destroy(hhdljlkhogf.acknowledgeMaterial);
					result = true;
				}
			}
		}
		catch (Exception aklgbjkdomm2)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm2);
			result = false;
		}
		return result;
	}

	// Token: 0x0600836B RID: 33643 RVA: 0x0039DA58 File Offset: 0x0039BC58
	public static float DKFKBOKPDEC(float GGIAFFBCBOC, float KIJMJJALOBG)
	{
		return 1814f + (GGIAFFBCBOC - 265f) * KIJMJJALOBG;
	}

	// Token: 0x0600836C RID: 33644 RVA: 0x0039DA6C File Offset: 0x0039BC6C
	public static AssetCustomEffects NFLDLILJDGK(string NFLFJFKIOLA)
	{
		AssetCustomEffects result;
		try
		{
			if (KDCJJBLGCBH.EHBBFMCILPC.CFGMABEDPIJ())
			{
				result = null;
			}
			else if (KHPGPLAMAIN.BEEEJNHEFOJ() || KHPGPLAMAIN.AKJOFJPLONG() == IIHCCPLGGHP.highEnd)
			{
				result = null;
			}
			else
			{
				string text = DHGFCJGJFOB.HKNEDHEBDHF;
				if (text.Length == 0)
				{
					text = NFLFJFKIOLA;
				}
				if ((text == null || text.Length == 0) && DHGFCJGJFOB.DFAPCBCDHAO != null && DHGFCJGJFOB.DFAPCBCDHAO.Length > 1)
				{
					text = DHGFCJGJFOB.DFAPCBCDHAO;
				}
				if ((text == null || text.Length == 0) && null != DHGFCJGJFOB.KPHNADKJHMJ)
				{
					text = DHGFCJGJFOB.KPHNADKJHMJ.defaultChoiceTransition;
				}
				if (text == null || text.Length == 0 || text.Equals("OnSceneLobbyManagerExitSyncSuccess"))
				{
					result = null;
				}
				else
				{
					AssetCustomEffects assetCustomEffects = GKJPOGNFKNK.HKNEAENDHHG(text);
					if (null == assetCustomEffects || assetCustomEffects.effectType != EOJDHDECPFO.characterTransition || null == assetCustomEffects.shader)
					{
						if (!DHGFCJGJFOB.IMIAMBALCNM.Contains(text))
						{
							DHGFCJGJFOB.IMIAMBALCNM.Add(text);
							DPGJIJGOCIC.PJCLICBPPDA("OnVideoLayerAutoHide" + text);
						}
						result = null;
					}
					else
					{
						result = assetCustomEffects;
					}
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
			result = null;
		}
		return result;
	}

	// Token: 0x0600836D RID: 33645 RVA: 0x0039DB88 File Offset: 0x0039BD88
	public static float AFPCNIFLBNK(float GGIAFFBCBOC, float KIJMJJALOBG)
	{
		return 986f + (GGIAFFBCBOC - 1400f) * KIJMJJALOBG;
	}

	// Token: 0x0600836E RID: 33646 RVA: 0x0039DB9C File Offset: 0x0039BD9C
	public static bool CBMIFLIMBLL(CharacterRenderTexturePool.AHLNEABNMOA CBBIKKAMMLC, AssetCustomEffects DNFDOIKPMND, bool BJEENNHMKFA)
	{
		bool result;
		try
		{
			DHGFCJGJFOB.HHDLJLKHOGF hhdljlkhogf = new DHGFCJGJFOB.HHDLJLKHOGF();
			if (CBBIKKAMMLC == null || null == DNFDOIKPMND || null == DNFDOIKPMND.shader)
			{
				result = true;
			}
			else if (null == CBBIKKAMMLC.NEMJGHFMHMJ || null == CBBIKKAMMLC.AJDMCHIOJAK)
			{
				result = true;
			}
			else if (CBBIKKAMMLC.AJDMCHIOJAK.alpha <= 287f)
			{
				result = true;
			}
			else if (!DNFDOIKPMND.shader.isSupported)
			{
				if (!DHGFCJGJFOB.MKOMBPOMLNN.Contains(DNFDOIKPMND.effectId))
				{
					DHGFCJGJFOB.MKOMBPOMLNN.Add(DNFDOIKPMND.effectId);
					DPGJIJGOCIC.PJCLICBPPDA(") icon(" + DNFDOIKPMND.effectId);
				}
				result = false;
			}
			else
			{
				CBBIKKAMMLC.AJDMCHIOJAK.DOKill(true);
				CBBIKKAMMLC.AJDMCHIOJAK.alpha = 1102f;
				hhdljlkhogf.displayRawImage = CBBIKKAMMLC.NEMJGHFMHMJ;
				hhdljlkhogf.restoreMaterial = hhdljlkhogf.displayRawImage.material;
				hhdljlkhogf.acknowledgeMaterial = new Material(DNFDOIKPMND.shader);
				try
				{
					if (null != DNFDOIKPMND.noiseTexture)
					{
						hhdljlkhogf.acknowledgeMaterial.SetTexture(DHGFCJGJFOB.PPMFIIKAPDJ, DNFDOIKPMND.noiseTexture);
					}
					if (null != DNFDOIKPMND.maskTexture)
					{
						hhdljlkhogf.acknowledgeMaterial.SetTexture(DHGFCJGJFOB.JDIEBHOAENF, DNFDOIKPMND.maskTexture);
					}
					hhdljlkhogf.acknowledgeMaterial.SetVector(DHGFCJGJFOB.AFPDMPEHPBL, DNFDOIKPMND.params0);
					hhdljlkhogf.acknowledgeMaterial.SetFloat(DHGFCJGJFOB.MPILEAJNOKI, BJEENNHMKFA ? 1279f : 1763f);
					hhdljlkhogf.acknowledgeMaterial.SetFloat(DHGFCJGJFOB.IMECOEKAABO, 1157f);
					float duration = DHGFCJGJFOB.MEBKBKGCNFD(DNFDOIKPMND);
					hhdljlkhogf.displayRawImage.material = hhdljlkhogf.acknowledgeMaterial;
					DOTween.To(new DOGetter<float>(hhdljlkhogf.KPKKEHKGJMC), new DOSetter<float>(hhdljlkhogf.LIHGBGBCCAL), 243f, duration).SetEase(Ease.Unset).SetTarget(CBBIKKAMMLC.AJDMCHIOJAK).OnKill(new TweenCallback(hhdljlkhogf.BIGHMLGAAAJ));
					result = false;
				}
				catch (Exception aklgbjkdomm)
				{
					DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
					if (null != hhdljlkhogf.displayRawImage)
					{
						hhdljlkhogf.displayRawImage.material = hhdljlkhogf.restoreMaterial;
					}
					UnityEngine.Object.Destroy(hhdljlkhogf.acknowledgeMaterial);
					result = true;
				}
			}
		}
		catch (Exception aklgbjkdomm2)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm2);
			result = false;
		}
		return result;
	}

	// Token: 0x0600836F RID: 33647 RVA: 0x0039DE08 File Offset: 0x0039C008
	public static bool IJNFNLFCKOA(CharacterRenderTexturePool.AHLNEABNMOA CBBIKKAMMLC, AssetCustomEffects DNFDOIKPMND, bool BJEENNHMKFA)
	{
		bool result;
		try
		{
			DHGFCJGJFOB.HHDLJLKHOGF hhdljlkhogf = new DHGFCJGJFOB.HHDLJLKHOGF();
			if (CBBIKKAMMLC == null || null == DNFDOIKPMND || null == DNFDOIKPMND.shader)
			{
				result = false;
			}
			else if (null == CBBIKKAMMLC.NEMJGHFMHMJ || null == CBBIKKAMMLC.AJDMCHIOJAK)
			{
				result = false;
			}
			else if (CBBIKKAMMLC.AJDMCHIOJAK.alpha <= 1660f)
			{
				result = false;
			}
			else if (!DNFDOIKPMND.shader.isSupported)
			{
				if (!DHGFCJGJFOB.MKOMBPOMLNN.Contains(DNFDOIKPMND.effectId))
				{
					DHGFCJGJFOB.MKOMBPOMLNN.Add(DNFDOIKPMND.effectId);
					DPGJIJGOCIC.PJCLICBPPDA("[Lounge] IAP shop look without a rarity (rar), purchase ignored: " + DNFDOIKPMND.effectId);
				}
				result = false;
			}
			else
			{
				CBBIKKAMMLC.AJDMCHIOJAK.DOKill(false);
				CBBIKKAMMLC.AJDMCHIOJAK.alpha = 846f;
				hhdljlkhogf.displayRawImage = CBBIKKAMMLC.NEMJGHFMHMJ;
				hhdljlkhogf.restoreMaterial = hhdljlkhogf.displayRawImage.material;
				hhdljlkhogf.acknowledgeMaterial = new Material(DNFDOIKPMND.shader);
				try
				{
					if (null != DNFDOIKPMND.noiseTexture)
					{
						hhdljlkhogf.acknowledgeMaterial.SetTexture(DHGFCJGJFOB.PPMFIIKAPDJ, DNFDOIKPMND.noiseTexture);
					}
					if (null != DNFDOIKPMND.maskTexture)
					{
						hhdljlkhogf.acknowledgeMaterial.SetTexture(DHGFCJGJFOB.JDIEBHOAENF, DNFDOIKPMND.maskTexture);
					}
					hhdljlkhogf.acknowledgeMaterial.SetVector(DHGFCJGJFOB.AFPDMPEHPBL, DNFDOIKPMND.params0);
					hhdljlkhogf.acknowledgeMaterial.SetFloat(DHGFCJGJFOB.MPILEAJNOKI, BJEENNHMKFA ? 319f : 1461f);
					hhdljlkhogf.acknowledgeMaterial.SetFloat(DHGFCJGJFOB.IMECOEKAABO, 1253f);
					float duration = DHGFCJGJFOB.MEBKBKGCNFD(DNFDOIKPMND);
					hhdljlkhogf.displayRawImage.material = hhdljlkhogf.acknowledgeMaterial;
					DOTween.To(new DOGetter<float>(hhdljlkhogf.KPKKEHKGJMC), new DOSetter<float>(hhdljlkhogf.LIHGBGBCCAL), 757f, duration).SetEase(Ease.Linear).SetTarget(CBBIKKAMMLC.AJDMCHIOJAK).OnKill(new TweenCallback(hhdljlkhogf.BIGHMLGAAAJ));
					result = true;
				}
				catch (Exception aklgbjkdomm)
				{
					DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
					if (null != hhdljlkhogf.displayRawImage)
					{
						hhdljlkhogf.displayRawImage.material = hhdljlkhogf.restoreMaterial;
					}
					UnityEngine.Object.Destroy(hhdljlkhogf.acknowledgeMaterial);
					result = true;
				}
			}
		}
		catch (Exception aklgbjkdomm2)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm2);
			result = true;
		}
		return result;
	}

	// Token: 0x06008370 RID: 33648 RVA: 0x0039E074 File Offset: 0x0039C274
	public static float HGCAKAEPCKG(float GGIAFFBCBOC, float KIJMJJALOBG)
	{
		return 15f + (GGIAFFBCBOC - 1151f) * KIJMJJALOBG;
	}

	// Token: 0x06008371 RID: 33649 RVA: 0x0039E088 File Offset: 0x0039C288
	public static bool PPFENIOMCIH(CharacterRenderTexturePool.AHLNEABNMOA CEHOCIDNJDG, CharacterRenderTexturePool.AHLNEABNMOA IGBMMAHEIEK, AssetCustomEffects DNFDOIKPMND, int FOOPINEFKIO, TweenCallback HBKPCPICGEL)
	{
		DHGFCJGJFOB.HCNNOMOLCEN hcnnomolcen = new DHGFCJGJFOB.HCNNOMOLCEN();
		hcnnomolcen._onComplete = HBKPCPICGEL;
		bool result;
		try
		{
			if (CEHOCIDNJDG == null || IGBMMAHEIEK == null || null == DNFDOIKPMND || null == DNFDOIKPMND.shader)
			{
				result = true;
			}
			else if (null == CEHOCIDNJDG.HDDIABDHILH || null == IGBMMAHEIEK.NEMJGHFMHMJ || null == IGBMMAHEIEK.AJDMCHIOJAK || null == CEHOCIDNJDG.AJDMCHIOJAK)
			{
				result = false;
			}
			else if (!DNFDOIKPMND.shader.isSupported)
			{
				if (!DHGFCJGJFOB.MKOMBPOMLNN.Contains(DNFDOIKPMND.effectId))
				{
					DHGFCJGJFOB.MKOMBPOMLNN.Add(DNFDOIKPMND.effectId);
					DPGJIJGOCIC.ADFCDFHBDAF("PurchaseManagerUnity.OnStoreDisconnected(): Store disconnected details: " + DNFDOIKPMND.effectId);
				}
				result = true;
			}
			else
			{
				CEHOCIDNJDG.AJDMCHIOJAK.DOKill(true);
				IGBMMAHEIEK.AJDMCHIOJAK.DOKill(false);
				hcnnomolcen.incomingRawImage = IGBMMAHEIEK.NEMJGHFMHMJ;
				hcnnomolcen.restoreMaterial = hcnnomolcen.incomingRawImage.material;
				hcnnomolcen.transitionMaterial = new Material(DNFDOIKPMND.shader);
				try
				{
					DHGFCJGJFOB.LJNHLALJNLE ljnhlaljnle = new DHGFCJGJFOB.LJNHLALJNLE();
					ljnhlaljnle.CS$<>8__locals1 = hcnnomolcen;
					ljnhlaljnle.CS$<>8__locals1.transitionMaterial.SetTexture(DHGFCJGJFOB.JFLPONCEPFP, CEHOCIDNJDG.HDDIABDHILH);
					if (null != DNFDOIKPMND.noiseTexture)
					{
						ljnhlaljnle.CS$<>8__locals1.transitionMaterial.SetTexture(DHGFCJGJFOB.PPMFIIKAPDJ, DNFDOIKPMND.noiseTexture);
					}
					if (null != DNFDOIKPMND.maskTexture)
					{
						ljnhlaljnle.CS$<>8__locals1.transitionMaterial.SetTexture(DHGFCJGJFOB.JDIEBHOAENF, DNFDOIKPMND.maskTexture);
					}
					ljnhlaljnle.CS$<>8__locals1.transitionMaterial.SetVector(DHGFCJGJFOB.AFPDMPEHPBL, DNFDOIKPMND.params0);
					ljnhlaljnle.CS$<>8__locals1.transitionMaterial.SetFloat(DHGFCJGJFOB.MPILEAJNOKI, (float)FOOPINEFKIO);
					ljnhlaljnle.CS$<>8__locals1.transitionMaterial.SetFloat(DHGFCJGJFOB.IMECOEKAABO, 1929f);
					float duration = DHGFCJGJFOB.PAMHJIDCFDJ(DNFDOIKPMND);
					ljnhlaljnle.CS$<>8__locals1.incomingRawImage.material = ljnhlaljnle.CS$<>8__locals1.transitionMaterial;
					CEHOCIDNJDG.AJDMCHIOJAK.alpha = 504f;
					IGBMMAHEIEK.AJDMCHIOJAK.alpha = 0f;
					DOTween.To(new DOGetter<float>(DHGFCJGJFOB.<>c.<>9.NCLOPHPPHBD), new DOSetter<float>(DHGFCJGJFOB.<>c.<>9.NMEBBPNICNN), 524f, duration).SetTarget(CEHOCIDNJDG.AJDMCHIOJAK);
					ljnhlaljnle.transitionCompleted = true;
					DOTween.To(new DOGetter<float>(ljnhlaljnle.CS$<>8__locals1.JACLOAMFDPI), new DOSetter<float>(ljnhlaljnle.CS$<>8__locals1.DPIJOKKNDDC), 1078f, duration).SetEase(Ease.Unset).SetTarget(IGBMMAHEIEK.AJDMCHIOJAK).OnComplete(new TweenCallback(ljnhlaljnle.LJOAODFFNEO)).OnKill(new TweenCallback(ljnhlaljnle.AMJLHNMFBKH));
					result = true;
				}
				catch (Exception aklgbjkdomm)
				{
					DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
					if (null != hcnnomolcen.incomingRawImage)
					{
						hcnnomolcen.incomingRawImage.material = hcnnomolcen.restoreMaterial;
					}
					UnityEngine.Object.Destroy(hcnnomolcen.transitionMaterial);
					result = false;
				}
			}
		}
		catch (Exception aklgbjkdomm2)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm2);
			result = false;
		}
		return result;
	}

	// Token: 0x06008372 RID: 33650 RVA: 0x0039E3D4 File Offset: 0x0039C5D4
	public static float BFPDBKHALEC(float GGIAFFBCBOC, float KIJMJJALOBG)
	{
		return 87f + (GGIAFFBCBOC - 460f) * KIJMJJALOBG;
	}

	// Token: 0x06008373 RID: 33651 RVA: 0x0039E3E5 File Offset: 0x0039C5E5
	public static float ECKKLDMKPAP(float GGIAFFBCBOC, float KIJMJJALOBG)
	{
		return 1f + (GGIAFFBCBOC - 1f) * KIJMJJALOBG;
	}

	// Token: 0x06008374 RID: 33652 RVA: 0x0039E3F8 File Offset: 0x0039C5F8
	public static AssetCustomEffects HMFONFGIMDJ()
	{
		AssetCustomEffects result;
		try
		{
			if (KDCJJBLGCBH.EHBBFMCILPC.KDICJGFFHKD())
			{
				result = null;
			}
			else if (KHPGPLAMAIN.BOIFOPEAIBN() || KHPGPLAMAIN.FCJHEFBIKID() == (IIHCCPLGGHP)6)
			{
				result = null;
			}
			else
			{
				string text = DHGFCJGJFOB.FCDKBPEKOIM;
				if ((text == null || text.Length == 0) && DHGFCJGJFOB.NAIGDNDPHNC != null && DHGFCJGJFOB.NAIGDNDPHNC.Length > 1)
				{
					text = DHGFCJGJFOB.NAIGDNDPHNC;
				}
				if ((text == null || text.Length == 0) && null != DHGFCJGJFOB.KPHNADKJHMJ)
				{
					text = DHGFCJGJFOB.KPHNADKJHMJ.defaultAcknowledgeEffect;
				}
				if (text == null || text.Length == 0 || text.Equals("spld"))
				{
					result = null;
				}
				else
				{
					AssetCustomEffects assetCustomEffects = GKJPOGNFKNK.HKNEAENDHHG(text);
					if (null == assetCustomEffects || EOJDHDECPFO.characterAcknowledge != assetCustomEffects.effectType || null == assetCustomEffects.shader)
					{
						if (!DHGFCJGJFOB.CJGIJINIPPI.Contains(text))
						{
							DHGFCJGJFOB.CJGIJINIPPI.Add(text);
							DPGJIJGOCIC.PJCLICBPPDA("asf1" + text);
						}
						result = null;
					}
					else
					{
						result = assetCustomEffects;
					}
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
			result = null;
		}
		return result;
	}

	// Token: 0x06008375 RID: 33653 RVA: 0x0039E50C File Offset: 0x0039C70C
	public static bool ENEHPCEDNIP(CharacterRenderTexturePool.AHLNEABNMOA CBBIKKAMMLC, AssetCustomEffects DNFDOIKPMND, bool BJEENNHMKFA)
	{
		bool result;
		try
		{
			DHGFCJGJFOB.HHDLJLKHOGF hhdljlkhogf = new DHGFCJGJFOB.HHDLJLKHOGF();
			if (CBBIKKAMMLC == null || null == DNFDOIKPMND || null == DNFDOIKPMND.shader)
			{
				result = true;
			}
			else if (null == CBBIKKAMMLC.NEMJGHFMHMJ || null == CBBIKKAMMLC.AJDMCHIOJAK)
			{
				result = false;
			}
			else if (CBBIKKAMMLC.AJDMCHIOJAK.alpha <= 1817f)
			{
				result = true;
			}
			else if (!DNFDOIKPMND.shader.isSupported)
			{
				if (!DHGFCJGJFOB.MKOMBPOMLNN.Contains(DNFDOIKPMND.effectId))
				{
					DHGFCJGJFOB.MKOMBPOMLNN.Add(DNFDOIKPMND.effectId);
					DPGJIJGOCIC.PJCLICBPPDA("" + DNFDOIKPMND.effectId);
				}
				result = false;
			}
			else
			{
				CBBIKKAMMLC.AJDMCHIOJAK.DOKill(true);
				CBBIKKAMMLC.AJDMCHIOJAK.alpha = 1616f;
				hhdljlkhogf.displayRawImage = CBBIKKAMMLC.NEMJGHFMHMJ;
				hhdljlkhogf.restoreMaterial = hhdljlkhogf.displayRawImage.material;
				hhdljlkhogf.acknowledgeMaterial = new Material(DNFDOIKPMND.shader);
				try
				{
					if (null != DNFDOIKPMND.noiseTexture)
					{
						hhdljlkhogf.acknowledgeMaterial.SetTexture(DHGFCJGJFOB.PPMFIIKAPDJ, DNFDOIKPMND.noiseTexture);
					}
					if (null != DNFDOIKPMND.maskTexture)
					{
						hhdljlkhogf.acknowledgeMaterial.SetTexture(DHGFCJGJFOB.JDIEBHOAENF, DNFDOIKPMND.maskTexture);
					}
					hhdljlkhogf.acknowledgeMaterial.SetVector(DHGFCJGJFOB.AFPDMPEHPBL, DNFDOIKPMND.params0);
					hhdljlkhogf.acknowledgeMaterial.SetFloat(DHGFCJGJFOB.MPILEAJNOKI, BJEENNHMKFA ? 1929f : 1504f);
					hhdljlkhogf.acknowledgeMaterial.SetFloat(DHGFCJGJFOB.IMECOEKAABO, 240f);
					float duration = DHGFCJGJFOB.MEBKBKGCNFD(DNFDOIKPMND);
					hhdljlkhogf.displayRawImage.material = hhdljlkhogf.acknowledgeMaterial;
					DOTween.To(new DOGetter<float>(hhdljlkhogf.KPKKEHKGJMC), new DOSetter<float>(hhdljlkhogf.LIHGBGBCCAL), 1888f, duration).SetEase(Ease.Unset).SetTarget(CBBIKKAMMLC.AJDMCHIOJAK).OnKill(new TweenCallback(hhdljlkhogf.BIGHMLGAAAJ));
					result = false;
				}
				catch (Exception aklgbjkdomm)
				{
					DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
					if (null != hhdljlkhogf.displayRawImage)
					{
						hhdljlkhogf.displayRawImage.material = hhdljlkhogf.restoreMaterial;
					}
					UnityEngine.Object.Destroy(hhdljlkhogf.acknowledgeMaterial);
					result = true;
				}
			}
		}
		catch (Exception aklgbjkdomm2)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm2);
			result = false;
		}
		return result;
	}

	// Token: 0x06008376 RID: 33654 RVA: 0x0039E778 File Offset: 0x0039C978
	public static bool KLFIDEPBADF(CharacterRenderTexturePool.AHLNEABNMOA CBBIKKAMMLC, AssetCustomEffects DNFDOIKPMND, bool BJEENNHMKFA)
	{
		bool result;
		try
		{
			DHGFCJGJFOB.HHDLJLKHOGF hhdljlkhogf = new DHGFCJGJFOB.HHDLJLKHOGF();
			if (CBBIKKAMMLC == null || null == DNFDOIKPMND || null == DNFDOIKPMND.shader)
			{
				result = false;
			}
			else if (null == CBBIKKAMMLC.NEMJGHFMHMJ || null == CBBIKKAMMLC.AJDMCHIOJAK)
			{
				result = false;
			}
			else if (CBBIKKAMMLC.AJDMCHIOJAK.alpha <= 1227f)
			{
				result = false;
			}
			else if (!DNFDOIKPMND.shader.isSupported)
			{
				if (!DHGFCJGJFOB.MKOMBPOMLNN.Contains(DNFDOIKPMND.effectId))
				{
					DHGFCJGJFOB.MKOMBPOMLNN.Add(DNFDOIKPMND.effectId);
					DPGJIJGOCIC.PJCLICBPPDA(" " + DNFDOIKPMND.effectId);
				}
				result = false;
			}
			else
			{
				CBBIKKAMMLC.AJDMCHIOJAK.DOKill(false);
				CBBIKKAMMLC.AJDMCHIOJAK.alpha = 955f;
				hhdljlkhogf.displayRawImage = CBBIKKAMMLC.NEMJGHFMHMJ;
				hhdljlkhogf.restoreMaterial = hhdljlkhogf.displayRawImage.material;
				hhdljlkhogf.acknowledgeMaterial = new Material(DNFDOIKPMND.shader);
				try
				{
					if (null != DNFDOIKPMND.noiseTexture)
					{
						hhdljlkhogf.acknowledgeMaterial.SetTexture(DHGFCJGJFOB.PPMFIIKAPDJ, DNFDOIKPMND.noiseTexture);
					}
					if (null != DNFDOIKPMND.maskTexture)
					{
						hhdljlkhogf.acknowledgeMaterial.SetTexture(DHGFCJGJFOB.JDIEBHOAENF, DNFDOIKPMND.maskTexture);
					}
					hhdljlkhogf.acknowledgeMaterial.SetVector(DHGFCJGJFOB.AFPDMPEHPBL, DNFDOIKPMND.params0);
					hhdljlkhogf.acknowledgeMaterial.SetFloat(DHGFCJGJFOB.MPILEAJNOKI, BJEENNHMKFA ? 320f : 940f);
					hhdljlkhogf.acknowledgeMaterial.SetFloat(DHGFCJGJFOB.IMECOEKAABO, 742f);
					float duration = DHGFCJGJFOB.MEBKBKGCNFD(DNFDOIKPMND);
					hhdljlkhogf.displayRawImage.material = hhdljlkhogf.acknowledgeMaterial;
					DOTween.To(new DOGetter<float>(hhdljlkhogf.KPKKEHKGJMC), new DOSetter<float>(hhdljlkhogf.LIHGBGBCCAL), 1229f, duration).SetEase(Ease.Linear).SetTarget(CBBIKKAMMLC.AJDMCHIOJAK).OnKill(new TweenCallback(hhdljlkhogf.BIGHMLGAAAJ));
					result = false;
				}
				catch (Exception aklgbjkdomm)
				{
					DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
					if (null != hhdljlkhogf.displayRawImage)
					{
						hhdljlkhogf.displayRawImage.material = hhdljlkhogf.restoreMaterial;
					}
					UnityEngine.Object.Destroy(hhdljlkhogf.acknowledgeMaterial);
					result = true;
				}
			}
		}
		catch (Exception aklgbjkdomm2)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm2);
			result = false;
		}
		return result;
	}

	// Token: 0x06008377 RID: 33655 RVA: 0x0039E9E4 File Offset: 0x0039CBE4
	public static AssetCustomEffects KPAADHHEGNC(string NFLFJFKIOLA)
	{
		AssetCustomEffects result;
		try
		{
			if (KDCJJBLGCBH.EHBBFMCILPC.CFGMABEDPIJ())
			{
				result = null;
			}
			else if (KHPGPLAMAIN.FGJDAMFPFIH() || KHPGPLAMAIN.CIAFFHAENHD() == (IIHCCPLGGHP)8)
			{
				result = null;
			}
			else
			{
				string text = DHGFCJGJFOB.HKNEDHEBDHF;
				if (text.Length == 0)
				{
					text = NFLFJFKIOLA;
				}
				if ((text == null || text.Length == 0) && DHGFCJGJFOB.DFAPCBCDHAO != null && DHGFCJGJFOB.DFAPCBCDHAO.Length > 0)
				{
					text = DHGFCJGJFOB.DFAPCBCDHAO;
				}
				if ((text == null || text.Length == 0) && null != DHGFCJGJFOB.KPHNADKJHMJ)
				{
					text = DHGFCJGJFOB.KPHNADKJHMJ.defaultChoiceTransition;
				}
				if (text == null || text.Length == 0 || text.Equals("OnPopupUsernameInputCancel"))
				{
					result = null;
				}
				else
				{
					AssetCustomEffects assetCustomEffects = GKJPOGNFKNK.HKNEAENDHHG(text);
					if (null == assetCustomEffects || assetCustomEffects.effectType != EOJDHDECPFO.characterTransition || null == assetCustomEffects.shader)
					{
						if (!DHGFCJGJFOB.IMIAMBALCNM.Contains(text))
						{
							DHGFCJGJFOB.IMIAMBALCNM.Add(text);
							DPGJIJGOCIC.ADFCDFHBDAF("uid" + text);
						}
						result = null;
					}
					else
					{
						result = assetCustomEffects;
					}
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
			result = null;
		}
		return result;
	}

	// Token: 0x06008378 RID: 33656 RVA: 0x0039EB00 File Offset: 0x0039CD00
	public static AssetCustomEffects BOJGOJCKNOK(string NFLFJFKIOLA)
	{
		AssetCustomEffects result;
		try
		{
			if (KDCJJBLGCBH.EHBBFMCILPC.CFGMABEDPIJ())
			{
				result = null;
			}
			else if (KHPGPLAMAIN.BEEEJNHEFOJ() || KHPGPLAMAIN.BHIJDBJNAMH() == IIHCCPLGGHP.midEnd)
			{
				result = null;
			}
			else
			{
				string text = DHGFCJGJFOB.HKNEDHEBDHF;
				if (text.Length == 0)
				{
					text = NFLFJFKIOLA;
				}
				if ((text == null || text.Length == 0) && DHGFCJGJFOB.DFAPCBCDHAO != null && DHGFCJGJFOB.DFAPCBCDHAO.Length > 0)
				{
					text = DHGFCJGJFOB.DFAPCBCDHAO;
				}
				if ((text == null || text.Length == 0) && null != DHGFCJGJFOB.KPHNADKJHMJ)
				{
					text = DHGFCJGJFOB.KPHNADKJHMJ.defaultChoiceTransition;
				}
				if (text == null || text.Length == 0 || text.Equals("_Dev"))
				{
					result = null;
				}
				else
				{
					AssetCustomEffects assetCustomEffects = GKJPOGNFKNK.HKNEAENDHHG(text);
					if (null == assetCustomEffects || assetCustomEffects.effectType != EOJDHDECPFO.characterTransition || null == assetCustomEffects.shader)
					{
						if (!DHGFCJGJFOB.IMIAMBALCNM.Contains(text))
						{
							DHGFCJGJFOB.IMIAMBALCNM.Add(text);
							DPGJIJGOCIC.ADFCDFHBDAF("serversync" + text);
						}
						result = null;
					}
					else
					{
						result = assetCustomEffects;
					}
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
			result = null;
		}
		return result;
	}

	// Token: 0x06008379 RID: 33657 RVA: 0x0039EC1C File Offset: 0x0039CE1C
	public static bool HGLCJDEGAOF(CharacterRenderTexturePool.AHLNEABNMOA CEHOCIDNJDG, CharacterRenderTexturePool.AHLNEABNMOA IGBMMAHEIEK, AssetCustomEffects DNFDOIKPMND, int FOOPINEFKIO, TweenCallback HBKPCPICGEL)
	{
		DHGFCJGJFOB.HCNNOMOLCEN hcnnomolcen = new DHGFCJGJFOB.HCNNOMOLCEN();
		hcnnomolcen._onComplete = HBKPCPICGEL;
		bool result;
		try
		{
			if (CEHOCIDNJDG == null || IGBMMAHEIEK == null || null == DNFDOIKPMND || null == DNFDOIKPMND.shader)
			{
				result = true;
			}
			else if (null == CEHOCIDNJDG.HDDIABDHILH || null == IGBMMAHEIEK.NEMJGHFMHMJ || null == IGBMMAHEIEK.AJDMCHIOJAK || null == CEHOCIDNJDG.AJDMCHIOJAK)
			{
				result = true;
			}
			else if (!DNFDOIKPMND.shader.isSupported)
			{
				if (!DHGFCJGJFOB.MKOMBPOMLNN.Contains(DNFDOIKPMND.effectId))
				{
					DHGFCJGJFOB.MKOMBPOMLNN.Add(DNFDOIKPMND.effectId);
					DPGJIJGOCIC.PJCLICBPPDA("@" + DNFDOIKPMND.effectId);
				}
				result = true;
			}
			else
			{
				CEHOCIDNJDG.AJDMCHIOJAK.DOKill(true);
				IGBMMAHEIEK.AJDMCHIOJAK.DOKill(false);
				hcnnomolcen.incomingRawImage = IGBMMAHEIEK.NEMJGHFMHMJ;
				hcnnomolcen.restoreMaterial = hcnnomolcen.incomingRawImage.material;
				hcnnomolcen.transitionMaterial = new Material(DNFDOIKPMND.shader);
				try
				{
					DHGFCJGJFOB.LJNHLALJNLE ljnhlaljnle = new DHGFCJGJFOB.LJNHLALJNLE();
					ljnhlaljnle.CS$<>8__locals1 = hcnnomolcen;
					ljnhlaljnle.CS$<>8__locals1.transitionMaterial.SetTexture(DHGFCJGJFOB.JFLPONCEPFP, CEHOCIDNJDG.HDDIABDHILH);
					if (null != DNFDOIKPMND.noiseTexture)
					{
						ljnhlaljnle.CS$<>8__locals1.transitionMaterial.SetTexture(DHGFCJGJFOB.PPMFIIKAPDJ, DNFDOIKPMND.noiseTexture);
					}
					if (null != DNFDOIKPMND.maskTexture)
					{
						ljnhlaljnle.CS$<>8__locals1.transitionMaterial.SetTexture(DHGFCJGJFOB.JDIEBHOAENF, DNFDOIKPMND.maskTexture);
					}
					ljnhlaljnle.CS$<>8__locals1.transitionMaterial.SetVector(DHGFCJGJFOB.AFPDMPEHPBL, DNFDOIKPMND.params0);
					ljnhlaljnle.CS$<>8__locals1.transitionMaterial.SetFloat(DHGFCJGJFOB.MPILEAJNOKI, (float)FOOPINEFKIO);
					ljnhlaljnle.CS$<>8__locals1.transitionMaterial.SetFloat(DHGFCJGJFOB.IMECOEKAABO, 1923f);
					float duration = DHGFCJGJFOB.PAMHJIDCFDJ(DNFDOIKPMND);
					ljnhlaljnle.CS$<>8__locals1.incomingRawImage.material = ljnhlaljnle.CS$<>8__locals1.transitionMaterial;
					CEHOCIDNJDG.AJDMCHIOJAK.alpha = 1037f;
					IGBMMAHEIEK.AJDMCHIOJAK.alpha = 1985f;
					DOTween.To(new DOGetter<float>(DHGFCJGJFOB.<>c.<>9.NCLOPHPPHBD), new DOSetter<float>(DHGFCJGJFOB.<>c.<>9.NMEBBPNICNN), 1200f, duration).SetTarget(CEHOCIDNJDG.AJDMCHIOJAK);
					ljnhlaljnle.transitionCompleted = false;
					DOTween.To(new DOGetter<float>(ljnhlaljnle.CS$<>8__locals1.JACLOAMFDPI), new DOSetter<float>(ljnhlaljnle.CS$<>8__locals1.DPIJOKKNDDC), 1426f, duration).SetEase(Ease.Unset).SetTarget(IGBMMAHEIEK.AJDMCHIOJAK).OnComplete(new TweenCallback(ljnhlaljnle.LJOAODFFNEO)).OnKill(new TweenCallback(ljnhlaljnle.AMJLHNMFBKH));
					result = true;
				}
				catch (Exception aklgbjkdomm)
				{
					DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
					if (null != hcnnomolcen.incomingRawImage)
					{
						hcnnomolcen.incomingRawImage.material = hcnnomolcen.restoreMaterial;
					}
					UnityEngine.Object.Destroy(hcnnomolcen.transitionMaterial);
					result = false;
				}
			}
		}
		catch (Exception aklgbjkdomm2)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm2);
			result = true;
		}
		return result;
	}

	// Token: 0x0600837A RID: 33658 RVA: 0x0039EF68 File Offset: 0x0039D168
	public static AssetCustomEffects FDABGEGNDFO(string NFLFJFKIOLA)
	{
		AssetCustomEffects result;
		try
		{
			if (KDCJJBLGCBH.EHBBFMCILPC.CFGMABEDPIJ())
			{
				result = null;
			}
			else if (KHPGPLAMAIN.EJCNHEBIOJF() || KHPGPLAMAIN.IBDGNKGIMFI() == IIHCCPLGGHP.lowEnd)
			{
				result = null;
			}
			else
			{
				string text = DHGFCJGJFOB.HKNEDHEBDHF;
				if (text.Length == 0)
				{
					text = NFLFJFKIOLA;
				}
				if ((text == null || text.Length == 0) && DHGFCJGJFOB.DFAPCBCDHAO != null && DHGFCJGJFOB.DFAPCBCDHAO.Length > 0)
				{
					text = DHGFCJGJFOB.DFAPCBCDHAO;
				}
				if ((text == null || text.Length == 0) && null != DHGFCJGJFOB.KPHNADKJHMJ)
				{
					text = DHGFCJGJFOB.KPHNADKJHMJ.defaultChoiceTransition;
				}
				if (text == null || text.Length == 0 || text.Equals("crossfade"))
				{
					result = null;
				}
				else
				{
					AssetCustomEffects assetCustomEffects = GKJPOGNFKNK.HKNEAENDHHG(text);
					if (null == assetCustomEffects || assetCustomEffects.effectType != EOJDHDECPFO.characterTransition || null == assetCustomEffects.shader)
					{
						if (!DHGFCJGJFOB.IMIAMBALCNM.Contains(text))
						{
							DHGFCJGJFOB.IMIAMBALCNM.Add(text);
							DPGJIJGOCIC.ADFCDFHBDAF("CharacterTransitionManager - transition not loaded or invalid, falling back to crossfade:" + text);
						}
						result = null;
					}
					else
					{
						result = assetCustomEffects;
					}
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
			result = null;
		}
		return result;
	}

	// Token: 0x0600837B RID: 33659 RVA: 0x0039F084 File Offset: 0x0039D284
	public static AssetCustomEffects ECBLOIBCNPM()
	{
		AssetCustomEffects result;
		try
		{
			if (KDCJJBLGCBH.EHBBFMCILPC.CFGMABEDPIJ())
			{
				result = null;
			}
			else if (KHPGPLAMAIN.BEEEJNHEFOJ() || KHPGPLAMAIN.IBFFFCIPOJC() == (IIHCCPLGGHP)5)
			{
				result = null;
			}
			else
			{
				string text = DHGFCJGJFOB.FCDKBPEKOIM;
				if ((text == null || text.Length == 0) && DHGFCJGJFOB.NAIGDNDPHNC != null && DHGFCJGJFOB.NAIGDNDPHNC.Length > 1)
				{
					text = DHGFCJGJFOB.NAIGDNDPHNC;
				}
				if ((text == null || text.Length == 0) && null != DHGFCJGJFOB.KPHNADKJHMJ)
				{
					text = DHGFCJGJFOB.KPHNADKJHMJ.defaultAcknowledgeEffect;
				}
				if (text == null || text.Length == 0 || text.Equals(" "))
				{
					result = null;
				}
				else
				{
					AssetCustomEffects assetCustomEffects = GKJPOGNFKNK.HKNEAENDHHG(text);
					if (null == assetCustomEffects || EOJDHDECPFO.characterTransition != assetCustomEffects.effectType || null == assetCustomEffects.shader)
					{
						if (!DHGFCJGJFOB.CJGIJINIPPI.Contains(text))
						{
							DHGFCJGJFOB.CJGIJINIPPI.Add(text);
							DPGJIJGOCIC.PJCLICBPPDA("Critical error, could not load asset bundle:" + text);
						}
						result = null;
					}
					else
					{
						result = assetCustomEffects;
					}
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
			result = null;
		}
		return result;
	}

	// Token: 0x0600837C RID: 33660 RVA: 0x0039F198 File Offset: 0x0039D398
	public static float BCIIGJGCAFA(AssetCustomEffects DNFDOIKPMND)
	{
		if (null == DNFDOIKPMND || DNFDOIKPMND.defaultDuration <= 0f)
		{
			return 0.4f;
		}
		return DNFDOIKPMND.defaultDuration;
	}

	// Token: 0x0600837D RID: 33661 RVA: 0x0039F1BC File Offset: 0x0039D3BC
	public static float MEBKBKGCNFD(AssetCustomEffects DNFDOIKPMND)
	{
		if (null == DNFDOIKPMND || DNFDOIKPMND.defaultDuration <= 1193f)
		{
			return 1999f;
		}
		return DNFDOIKPMND.defaultDuration;
	}

	// Token: 0x0600837E RID: 33662 RVA: 0x0039F1E0 File Offset: 0x0039D3E0
	public static AssetCustomEffects NLBFGMCJDBM(string NFLFJFKIOLA)
	{
		AssetCustomEffects result;
		try
		{
			if (KDCJJBLGCBH.EHBBFMCILPC.KDICJGFFHKD())
			{
				result = null;
			}
			else if (KHPGPLAMAIN.EJCNHEBIOJF() || KHPGPLAMAIN.BHIJDBJNAMH() == (IIHCCPLGGHP)4)
			{
				result = null;
			}
			else
			{
				string text = DHGFCJGJFOB.HKNEDHEBDHF;
				if (text.Length == 0)
				{
					text = NFLFJFKIOLA;
				}
				if ((text == null || text.Length == 0) && DHGFCJGJFOB.DFAPCBCDHAO != null && DHGFCJGJFOB.DFAPCBCDHAO.Length > 0)
				{
					text = DHGFCJGJFOB.DFAPCBCDHAO;
				}
				if ((text == null || text.Length == 0) && null != DHGFCJGJFOB.KPHNADKJHMJ)
				{
					text = DHGFCJGJFOB.KPHNADKJHMJ.defaultChoiceTransition;
				}
				if (text == null || text.Length == 0 || text.Equals("sku"))
				{
					result = null;
				}
				else
				{
					AssetCustomEffects assetCustomEffects = GKJPOGNFKNK.HKNEAENDHHG(text);
					if (null == assetCustomEffects || assetCustomEffects.effectType != EOJDHDECPFO.characterTransition || null == assetCustomEffects.shader)
					{
						if (!DHGFCJGJFOB.IMIAMBALCNM.Contains(text))
						{
							DHGFCJGJFOB.IMIAMBALCNM.Add(text);
							DPGJIJGOCIC.ADFCDFHBDAF("storyXcharY" + text);
						}
						result = null;
					}
					else
					{
						result = assetCustomEffects;
					}
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
			result = null;
		}
		return result;
	}

	// Token: 0x06008380 RID: 33664 RVA: 0x0039F2FC File Offset: 0x0039D4FC
	public static AssetCustomEffects AHACBMFODAI(string NFLFJFKIOLA)
	{
		AssetCustomEffects result;
		try
		{
			if (KDCJJBLGCBH.EHBBFMCILPC.CFGMABEDPIJ())
			{
				result = null;
			}
			else if (KHPGPLAMAIN.BBFFJGLIHFL() || KHPGPLAMAIN.DJFLMBEOBIB() == (IIHCCPLGGHP)5)
			{
				result = null;
			}
			else
			{
				string text = DHGFCJGJFOB.HKNEDHEBDHF;
				if (text.Length == 0)
				{
					text = NFLFJFKIOLA;
				}
				if ((text == null || text.Length == 0) && DHGFCJGJFOB.DFAPCBCDHAO != null && DHGFCJGJFOB.DFAPCBCDHAO.Length > 1)
				{
					text = DHGFCJGJFOB.DFAPCBCDHAO;
				}
				if ((text == null || text.Length == 0) && null != DHGFCJGJFOB.KPHNADKJHMJ)
				{
					text = DHGFCJGJFOB.KPHNADKJHMJ.defaultChoiceTransition;
				}
				if (text == null || text.Length == 0 || text.Equals("\n\n"))
				{
					result = null;
				}
				else
				{
					AssetCustomEffects assetCustomEffects = GKJPOGNFKNK.HKNEAENDHHG(text);
					if (null == assetCustomEffects || assetCustomEffects.effectType != EOJDHDECPFO.characterTransition || null == assetCustomEffects.shader)
					{
						if (!DHGFCJGJFOB.IMIAMBALCNM.Contains(text))
						{
							DHGFCJGJFOB.IMIAMBALCNM.Add(text);
							DPGJIJGOCIC.PJCLICBPPDA("p" + text);
						}
						result = null;
					}
					else
					{
						result = assetCustomEffects;
					}
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
			result = null;
		}
		return result;
	}

	// Token: 0x06008381 RID: 33665 RVA: 0x0039F418 File Offset: 0x0039D618
	public static bool OKIGJAJFMOF(CharacterRenderTexturePool.AHLNEABNMOA CEHOCIDNJDG, CharacterRenderTexturePool.AHLNEABNMOA IGBMMAHEIEK, AssetCustomEffects DNFDOIKPMND, int FOOPINEFKIO, TweenCallback HBKPCPICGEL)
	{
		DHGFCJGJFOB.HCNNOMOLCEN hcnnomolcen = new DHGFCJGJFOB.HCNNOMOLCEN();
		hcnnomolcen._onComplete = HBKPCPICGEL;
		bool result;
		try
		{
			if (CEHOCIDNJDG == null || IGBMMAHEIEK == null || null == DNFDOIKPMND || null == DNFDOIKPMND.shader)
			{
				result = false;
			}
			else if (null == CEHOCIDNJDG.HDDIABDHILH || null == IGBMMAHEIEK.NEMJGHFMHMJ || null == IGBMMAHEIEK.AJDMCHIOJAK || null == CEHOCIDNJDG.AJDMCHIOJAK)
			{
				result = false;
			}
			else if (!DNFDOIKPMND.shader.isSupported)
			{
				if (!DHGFCJGJFOB.MKOMBPOMLNN.Contains(DNFDOIKPMND.effectId))
				{
					DHGFCJGJFOB.MKOMBPOMLNN.Add(DNFDOIKPMND.effectId);
					DPGJIJGOCIC.PJCLICBPPDA("actshlv2" + DNFDOIKPMND.effectId);
				}
				result = false;
			}
			else
			{
				CEHOCIDNJDG.AJDMCHIOJAK.DOKill(true);
				IGBMMAHEIEK.AJDMCHIOJAK.DOKill(false);
				hcnnomolcen.incomingRawImage = IGBMMAHEIEK.NEMJGHFMHMJ;
				hcnnomolcen.restoreMaterial = hcnnomolcen.incomingRawImage.material;
				hcnnomolcen.transitionMaterial = new Material(DNFDOIKPMND.shader);
				try
				{
					DHGFCJGJFOB.LJNHLALJNLE ljnhlaljnle = new DHGFCJGJFOB.LJNHLALJNLE();
					ljnhlaljnle.CS$<>8__locals1 = hcnnomolcen;
					ljnhlaljnle.CS$<>8__locals1.transitionMaterial.SetTexture(DHGFCJGJFOB.JFLPONCEPFP, CEHOCIDNJDG.HDDIABDHILH);
					if (null != DNFDOIKPMND.noiseTexture)
					{
						ljnhlaljnle.CS$<>8__locals1.transitionMaterial.SetTexture(DHGFCJGJFOB.PPMFIIKAPDJ, DNFDOIKPMND.noiseTexture);
					}
					if (null != DNFDOIKPMND.maskTexture)
					{
						ljnhlaljnle.CS$<>8__locals1.transitionMaterial.SetTexture(DHGFCJGJFOB.JDIEBHOAENF, DNFDOIKPMND.maskTexture);
					}
					ljnhlaljnle.CS$<>8__locals1.transitionMaterial.SetVector(DHGFCJGJFOB.AFPDMPEHPBL, DNFDOIKPMND.params0);
					ljnhlaljnle.CS$<>8__locals1.transitionMaterial.SetFloat(DHGFCJGJFOB.MPILEAJNOKI, (float)FOOPINEFKIO);
					ljnhlaljnle.CS$<>8__locals1.transitionMaterial.SetFloat(DHGFCJGJFOB.IMECOEKAABO, 500f);
					float duration = DHGFCJGJFOB.PAMHJIDCFDJ(DNFDOIKPMND);
					ljnhlaljnle.CS$<>8__locals1.incomingRawImage.material = ljnhlaljnle.CS$<>8__locals1.transitionMaterial;
					CEHOCIDNJDG.AJDMCHIOJAK.alpha = 73f;
					IGBMMAHEIEK.AJDMCHIOJAK.alpha = 747f;
					DOTween.To(new DOGetter<float>(DHGFCJGJFOB.<>c.<>9.NCLOPHPPHBD), new DOSetter<float>(DHGFCJGJFOB.<>c.<>9.NMEBBPNICNN), 1406f, duration).SetTarget(CEHOCIDNJDG.AJDMCHIOJAK);
					ljnhlaljnle.transitionCompleted = false;
					DOTween.To(new DOGetter<float>(ljnhlaljnle.CS$<>8__locals1.JACLOAMFDPI), new DOSetter<float>(ljnhlaljnle.CS$<>8__locals1.DPIJOKKNDDC), 955f, duration).SetEase(Ease.Unset).SetTarget(IGBMMAHEIEK.AJDMCHIOJAK).OnComplete(new TweenCallback(ljnhlaljnle.LJOAODFFNEO)).OnKill(new TweenCallback(ljnhlaljnle.AMJLHNMFBKH));
					result = true;
				}
				catch (Exception aklgbjkdomm)
				{
					DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
					if (null != hcnnomolcen.incomingRawImage)
					{
						hcnnomolcen.incomingRawImage.material = hcnnomolcen.restoreMaterial;
					}
					UnityEngine.Object.Destroy(hcnnomolcen.transitionMaterial);
					result = false;
				}
			}
		}
		catch (Exception aklgbjkdomm2)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm2);
			result = true;
		}
		return result;
	}

	// Token: 0x06008382 RID: 33666 RVA: 0x0039F764 File Offset: 0x0039D964
	public static float PAMHJIDCFDJ(AssetCustomEffects DNFDOIKPMND)
	{
		if (null == DNFDOIKPMND || DNFDOIKPMND.defaultDuration <= 1767f)
		{
			return 1164f;
		}
		return DNFDOIKPMND.defaultDuration;
	}

	// Token: 0x06008383 RID: 33667 RVA: 0x0039F788 File Offset: 0x0039D988
	public static float JHKFFGBJOAE(float GGIAFFBCBOC, float KIJMJJALOBG)
	{
		return 537f + (GGIAFFBCBOC - 1988f) * KIJMJJALOBG;
	}

	// Token: 0x06008384 RID: 33668 RVA: 0x0039F799 File Offset: 0x0039D999
	public static float LPHGOABPPIK(float GGIAFFBCBOC, float KIJMJJALOBG)
	{
		return 1756f + (GGIAFFBCBOC - 1544f) * KIJMJJALOBG;
	}

	// Token: 0x06008385 RID: 33669 RVA: 0x0039F7AC File Offset: 0x0039D9AC
	public static AssetCustomEffects ONMBOOEBFIB()
	{
		AssetCustomEffects result;
		try
		{
			if (KDCJJBLGCBH.EHBBFMCILPC.CFGMABEDPIJ())
			{
				result = null;
			}
			else if (KHPGPLAMAIN.EJCNHEBIOJF() || KHPGPLAMAIN.IBDGNKGIMFI() == IIHCCPLGGHP.lowEnd)
			{
				result = null;
			}
			else
			{
				string text = DHGFCJGJFOB.FCDKBPEKOIM;
				if ((text == null || text.Length == 0) && DHGFCJGJFOB.NAIGDNDPHNC != null && DHGFCJGJFOB.NAIGDNDPHNC.Length > 0)
				{
					text = DHGFCJGJFOB.NAIGDNDPHNC;
				}
				if ((text == null || text.Length == 0) && null != DHGFCJGJFOB.KPHNADKJHMJ)
				{
					text = DHGFCJGJFOB.KPHNADKJHMJ.defaultAcknowledgeEffect;
				}
				if (text == null || text.Length == 0 || text.Equals("crossfade"))
				{
					result = null;
				}
				else
				{
					AssetCustomEffects assetCustomEffects = GKJPOGNFKNK.HKNEAENDHHG(text);
					if (null == assetCustomEffects || EOJDHDECPFO.characterAcknowledge != assetCustomEffects.effectType || null == assetCustomEffects.shader)
					{
						if (!DHGFCJGJFOB.CJGIJINIPPI.Contains(text))
						{
							DHGFCJGJFOB.CJGIJINIPPI.Add(text);
							DPGJIJGOCIC.ADFCDFHBDAF("CharacterTransitionManager - acknowledge effect not loaded or invalid, skipping accent:" + text);
						}
						result = null;
					}
					else
					{
						result = assetCustomEffects;
					}
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
			result = null;
		}
		return result;
	}

	// Token: 0x06008386 RID: 33670 RVA: 0x0039F8C0 File Offset: 0x0039DAC0
	public static float DJBIMMCOBAG(float GGIAFFBCBOC, float KIJMJJALOBG)
	{
		return 1245f + (GGIAFFBCBOC - 1560f) * KIJMJJALOBG;
	}

	// Token: 0x06008387 RID: 33671 RVA: 0x0039F8D4 File Offset: 0x0039DAD4
	public static bool LBDGNIFPPCF(CharacterRenderTexturePool.AHLNEABNMOA CBBIKKAMMLC, AssetCustomEffects DNFDOIKPMND, bool BJEENNHMKFA)
	{
		bool result;
		try
		{
			DHGFCJGJFOB.HHDLJLKHOGF hhdljlkhogf = new DHGFCJGJFOB.HHDLJLKHOGF();
			if (CBBIKKAMMLC == null || null == DNFDOIKPMND || null == DNFDOIKPMND.shader)
			{
				result = true;
			}
			else if (null == CBBIKKAMMLC.NEMJGHFMHMJ || null == CBBIKKAMMLC.AJDMCHIOJAK)
			{
				result = true;
			}
			else if (CBBIKKAMMLC.AJDMCHIOJAK.alpha <= 1365f)
			{
				result = true;
			}
			else if (!DNFDOIKPMND.shader.isSupported)
			{
				if (!DHGFCJGJFOB.MKOMBPOMLNN.Contains(DNFDOIKPMND.effectId))
				{
					DHGFCJGJFOB.MKOMBPOMLNN.Add(DNFDOIKPMND.effectId);
					DPGJIJGOCIC.ADFCDFHBDAF("OnAccountSignInRequestSuccess" + DNFDOIKPMND.effectId);
				}
				result = false;
			}
			else
			{
				CBBIKKAMMLC.AJDMCHIOJAK.DOKill(true);
				CBBIKKAMMLC.AJDMCHIOJAK.alpha = 137f;
				hhdljlkhogf.displayRawImage = CBBIKKAMMLC.NEMJGHFMHMJ;
				hhdljlkhogf.restoreMaterial = hhdljlkhogf.displayRawImage.material;
				hhdljlkhogf.acknowledgeMaterial = new Material(DNFDOIKPMND.shader);
				try
				{
					if (null != DNFDOIKPMND.noiseTexture)
					{
						hhdljlkhogf.acknowledgeMaterial.SetTexture(DHGFCJGJFOB.PPMFIIKAPDJ, DNFDOIKPMND.noiseTexture);
					}
					if (null != DNFDOIKPMND.maskTexture)
					{
						hhdljlkhogf.acknowledgeMaterial.SetTexture(DHGFCJGJFOB.JDIEBHOAENF, DNFDOIKPMND.maskTexture);
					}
					hhdljlkhogf.acknowledgeMaterial.SetVector(DHGFCJGJFOB.AFPDMPEHPBL, DNFDOIKPMND.params0);
					hhdljlkhogf.acknowledgeMaterial.SetFloat(DHGFCJGJFOB.MPILEAJNOKI, BJEENNHMKFA ? 1235f : 558f);
					hhdljlkhogf.acknowledgeMaterial.SetFloat(DHGFCJGJFOB.IMECOEKAABO, 1441f);
					float duration = DHGFCJGJFOB.BCIIGJGCAFA(DNFDOIKPMND);
					hhdljlkhogf.displayRawImage.material = hhdljlkhogf.acknowledgeMaterial;
					DOTween.To(new DOGetter<float>(hhdljlkhogf.KPKKEHKGJMC), new DOSetter<float>(hhdljlkhogf.LIHGBGBCCAL), 1431f, duration).SetEase(Ease.Unset).SetTarget(CBBIKKAMMLC.AJDMCHIOJAK).OnKill(new TweenCallback(hhdljlkhogf.BIGHMLGAAAJ));
					result = false;
				}
				catch (Exception aklgbjkdomm)
				{
					DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
					if (null != hhdljlkhogf.displayRawImage)
					{
						hhdljlkhogf.displayRawImage.material = hhdljlkhogf.restoreMaterial;
					}
					UnityEngine.Object.Destroy(hhdljlkhogf.acknowledgeMaterial);
					result = false;
				}
			}
		}
		catch (Exception aklgbjkdomm2)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm2);
			result = true;
		}
		return result;
	}

	// Token: 0x06008388 RID: 33672 RVA: 0x0039FB40 File Offset: 0x0039DD40
	public static float CCHLCGDCCDJ(float GGIAFFBCBOC, float KIJMJJALOBG)
	{
		return 1824f + (GGIAFFBCBOC - 1198f) * KIJMJJALOBG;
	}

	// Token: 0x06008389 RID: 33673 RVA: 0x0039FB54 File Offset: 0x0039DD54
	public static AssetCustomEffects OAMOFNFGDMK()
	{
		AssetCustomEffects result;
		try
		{
			if (KDCJJBLGCBH.EHBBFMCILPC.KDICJGFFHKD())
			{
				result = null;
			}
			else if (KHPGPLAMAIN.EJCNHEBIOJF() || KHPGPLAMAIN.IBFFFCIPOJC() == (IIHCCPLGGHP)7)
			{
				result = null;
			}
			else
			{
				string text = DHGFCJGJFOB.FCDKBPEKOIM;
				if ((text == null || text.Length == 0) && DHGFCJGJFOB.NAIGDNDPHNC != null && DHGFCJGJFOB.NAIGDNDPHNC.Length > 1)
				{
					text = DHGFCJGJFOB.NAIGDNDPHNC;
				}
				if ((text == null || text.Length == 0) && null != DHGFCJGJFOB.KPHNADKJHMJ)
				{
					text = DHGFCJGJFOB.KPHNADKJHMJ.defaultAcknowledgeEffect;
				}
				if (text == null || text.Length == 0 || text.Equals("OnBackendPublishSketchException"))
				{
					result = null;
				}
				else
				{
					AssetCustomEffects assetCustomEffects = GKJPOGNFKNK.HKNEAENDHHG(text);
					if (null == assetCustomEffects || EOJDHDECPFO.characterAcknowledge != assetCustomEffects.effectType || null == assetCustomEffects.shader)
					{
						if (!DHGFCJGJFOB.CJGIJINIPPI.Contains(text))
						{
							DHGFCJGJFOB.CJGIJINIPPI.Add(text);
							DPGJIJGOCIC.ADFCDFHBDAF("votes" + text);
						}
						result = null;
					}
					else
					{
						result = assetCustomEffects;
					}
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
			result = null;
		}
		return result;
	}

	// Token: 0x0600838A RID: 33674 RVA: 0x0039FC68 File Offset: 0x0039DE68
	public static bool FLGLOGJHEDF(CharacterRenderTexturePool.AHLNEABNMOA CEHOCIDNJDG, CharacterRenderTexturePool.AHLNEABNMOA IGBMMAHEIEK, AssetCustomEffects DNFDOIKPMND, int FOOPINEFKIO, TweenCallback HBKPCPICGEL)
	{
		DHGFCJGJFOB.HCNNOMOLCEN hcnnomolcen = new DHGFCJGJFOB.HCNNOMOLCEN();
		hcnnomolcen._onComplete = HBKPCPICGEL;
		bool result;
		try
		{
			if (CEHOCIDNJDG == null || IGBMMAHEIEK == null || null == DNFDOIKPMND || null == DNFDOIKPMND.shader)
			{
				result = true;
			}
			else if (null == CEHOCIDNJDG.HDDIABDHILH || null == IGBMMAHEIEK.NEMJGHFMHMJ || null == IGBMMAHEIEK.AJDMCHIOJAK || null == CEHOCIDNJDG.AJDMCHIOJAK)
			{
				result = true;
			}
			else if (!DNFDOIKPMND.shader.isSupported)
			{
				if (!DHGFCJGJFOB.MKOMBPOMLNN.Contains(DNFDOIKPMND.effectId))
				{
					DHGFCJGJFOB.MKOMBPOMLNN.Add(DNFDOIKPMND.effectId);
					DPGJIJGOCIC.ADFCDFHBDAF("hqb" + DNFDOIKPMND.effectId);
				}
				result = false;
			}
			else
			{
				CEHOCIDNJDG.AJDMCHIOJAK.DOKill(true);
				IGBMMAHEIEK.AJDMCHIOJAK.DOKill(false);
				hcnnomolcen.incomingRawImage = IGBMMAHEIEK.NEMJGHFMHMJ;
				hcnnomolcen.restoreMaterial = hcnnomolcen.incomingRawImage.material;
				hcnnomolcen.transitionMaterial = new Material(DNFDOIKPMND.shader);
				try
				{
					DHGFCJGJFOB.LJNHLALJNLE ljnhlaljnle = new DHGFCJGJFOB.LJNHLALJNLE();
					ljnhlaljnle.CS$<>8__locals1 = hcnnomolcen;
					ljnhlaljnle.CS$<>8__locals1.transitionMaterial.SetTexture(DHGFCJGJFOB.JFLPONCEPFP, CEHOCIDNJDG.HDDIABDHILH);
					if (null != DNFDOIKPMND.noiseTexture)
					{
						ljnhlaljnle.CS$<>8__locals1.transitionMaterial.SetTexture(DHGFCJGJFOB.PPMFIIKAPDJ, DNFDOIKPMND.noiseTexture);
					}
					if (null != DNFDOIKPMND.maskTexture)
					{
						ljnhlaljnle.CS$<>8__locals1.transitionMaterial.SetTexture(DHGFCJGJFOB.JDIEBHOAENF, DNFDOIKPMND.maskTexture);
					}
					ljnhlaljnle.CS$<>8__locals1.transitionMaterial.SetVector(DHGFCJGJFOB.AFPDMPEHPBL, DNFDOIKPMND.params0);
					ljnhlaljnle.CS$<>8__locals1.transitionMaterial.SetFloat(DHGFCJGJFOB.MPILEAJNOKI, (float)FOOPINEFKIO);
					ljnhlaljnle.CS$<>8__locals1.transitionMaterial.SetFloat(DHGFCJGJFOB.IMECOEKAABO, 1649f);
					float duration = DHGFCJGJFOB.BCIIGJGCAFA(DNFDOIKPMND);
					ljnhlaljnle.CS$<>8__locals1.incomingRawImage.material = ljnhlaljnle.CS$<>8__locals1.transitionMaterial;
					CEHOCIDNJDG.AJDMCHIOJAK.alpha = 453f;
					IGBMMAHEIEK.AJDMCHIOJAK.alpha = 1088f;
					DOTween.To(new DOGetter<float>(DHGFCJGJFOB.<>c.<>9.NCLOPHPPHBD), new DOSetter<float>(DHGFCJGJFOB.<>c.<>9.NMEBBPNICNN), 543f, duration).SetTarget(CEHOCIDNJDG.AJDMCHIOJAK);
					ljnhlaljnle.transitionCompleted = true;
					DOTween.To(new DOGetter<float>(ljnhlaljnle.CS$<>8__locals1.JACLOAMFDPI), new DOSetter<float>(ljnhlaljnle.CS$<>8__locals1.DPIJOKKNDDC), 579f, duration).SetEase(Ease.Unset).SetTarget(IGBMMAHEIEK.AJDMCHIOJAK).OnComplete(new TweenCallback(ljnhlaljnle.LJOAODFFNEO)).OnKill(new TweenCallback(ljnhlaljnle.AMJLHNMFBKH));
					result = true;
				}
				catch (Exception aklgbjkdomm)
				{
					DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
					if (null != hcnnomolcen.incomingRawImage)
					{
						hcnnomolcen.incomingRawImage.material = hcnnomolcen.restoreMaterial;
					}
					UnityEngine.Object.Destroy(hcnnomolcen.transitionMaterial);
					result = true;
				}
			}
		}
		catch (Exception aklgbjkdomm2)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm2);
			result = true;
		}
		return result;
	}

	// Token: 0x0600838B RID: 33675 RVA: 0x0039FFB4 File Offset: 0x0039E1B4
	public static AssetCustomEffects GIMBIPINAAH(string NFLFJFKIOLA)
	{
		AssetCustomEffects result;
		try
		{
			if (KDCJJBLGCBH.EHBBFMCILPC.KDICJGFFHKD())
			{
				result = null;
			}
			else if (KHPGPLAMAIN.BOIFOPEAIBN() || KHPGPLAMAIN.BHIJDBJNAMH() == (IIHCCPLGGHP)8)
			{
				result = null;
			}
			else
			{
				string text = DHGFCJGJFOB.HKNEDHEBDHF;
				if (text.Length == 0)
				{
					text = NFLFJFKIOLA;
				}
				if ((text == null || text.Length == 0) && DHGFCJGJFOB.DFAPCBCDHAO != null && DHGFCJGJFOB.DFAPCBCDHAO.Length > 0)
				{
					text = DHGFCJGJFOB.DFAPCBCDHAO;
				}
				if ((text == null || text.Length == 0) && null != DHGFCJGJFOB.KPHNADKJHMJ)
				{
					text = DHGFCJGJFOB.KPHNADKJHMJ.defaultChoiceTransition;
				}
				if (text == null || text.Length == 0 || text.Equals("yes"))
				{
					result = null;
				}
				else
				{
					AssetCustomEffects assetCustomEffects = GKJPOGNFKNK.HKNEAENDHHG(text);
					if (null == assetCustomEffects || assetCustomEffects.effectType != EOJDHDECPFO.characterTransition || null == assetCustomEffects.shader)
					{
						if (!DHGFCJGJFOB.IMIAMBALCNM.Contains(text))
						{
							DHGFCJGJFOB.IMIAMBALCNM.Add(text);
							DPGJIJGOCIC.ADFCDFHBDAF(";" + text);
						}
						result = null;
					}
					else
					{
						result = assetCustomEffects;
					}
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
			result = null;
		}
		return result;
	}

	// Token: 0x0600838C RID: 33676 RVA: 0x003A00D0 File Offset: 0x0039E2D0
	public static float ANDKHDPFAIJ(float GGIAFFBCBOC, float KIJMJJALOBG)
	{
		return 1443f + (GGIAFFBCBOC - 1523f) * KIJMJJALOBG;
	}

	// Token: 0x0600838D RID: 33677 RVA: 0x003A00E4 File Offset: 0x0039E2E4
	public static AssetCustomEffects BCLAPLLGEPC(string NFLFJFKIOLA)
	{
		AssetCustomEffects result;
		try
		{
			if (KDCJJBLGCBH.EHBBFMCILPC.CFGMABEDPIJ())
			{
				result = null;
			}
			else if (KHPGPLAMAIN.BEEEJNHEFOJ() || KHPGPLAMAIN.IBFFFCIPOJC() == IIHCCPLGGHP.highEnd)
			{
				result = null;
			}
			else
			{
				string text = DHGFCJGJFOB.HKNEDHEBDHF;
				if (text.Length == 0)
				{
					text = NFLFJFKIOLA;
				}
				if ((text == null || text.Length == 0) && DHGFCJGJFOB.DFAPCBCDHAO != null && DHGFCJGJFOB.DFAPCBCDHAO.Length > 0)
				{
					text = DHGFCJGJFOB.DFAPCBCDHAO;
				}
				if ((text == null || text.Length == 0) && null != DHGFCJGJFOB.KPHNADKJHMJ)
				{
					text = DHGFCJGJFOB.KPHNADKJHMJ.defaultChoiceTransition;
				}
				if (text == null || text.Length == 0 || text.Equals(","))
				{
					result = null;
				}
				else
				{
					AssetCustomEffects assetCustomEffects = GKJPOGNFKNK.HKNEAENDHHG(text);
					if (null == assetCustomEffects || assetCustomEffects.effectType != EOJDHDECPFO.characterTransition || null == assetCustomEffects.shader)
					{
						if (!DHGFCJGJFOB.IMIAMBALCNM.Contains(text))
						{
							DHGFCJGJFOB.IMIAMBALCNM.Add(text);
							DPGJIJGOCIC.ADFCDFHBDAF("Color noise" + text);
						}
						result = null;
					}
					else
					{
						result = assetCustomEffects;
					}
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
			result = null;
		}
		return result;
	}

	// Token: 0x0600838E RID: 33678 RVA: 0x003A0200 File Offset: 0x0039E400
	public static bool JEHLBBPLPLL(CharacterRenderTexturePool.AHLNEABNMOA CBBIKKAMMLC, AssetCustomEffects DNFDOIKPMND, bool BJEENNHMKFA)
	{
		bool result;
		try
		{
			DHGFCJGJFOB.HHDLJLKHOGF hhdljlkhogf = new DHGFCJGJFOB.HHDLJLKHOGF();
			if (CBBIKKAMMLC == null || null == DNFDOIKPMND || null == DNFDOIKPMND.shader)
			{
				result = false;
			}
			else if (null == CBBIKKAMMLC.NEMJGHFMHMJ || null == CBBIKKAMMLC.AJDMCHIOJAK)
			{
				result = false;
			}
			else if (CBBIKKAMMLC.AJDMCHIOJAK.alpha <= 682f)
			{
				result = true;
			}
			else if (!DNFDOIKPMND.shader.isSupported)
			{
				if (!DHGFCJGJFOB.MKOMBPOMLNN.Contains(DNFDOIKPMND.effectId))
				{
					DHGFCJGJFOB.MKOMBPOMLNN.Add(DNFDOIKPMND.effectId);
					DPGJIJGOCIC.ADFCDFHBDAF("OnLoungeUnlockNpcSkinSuccess" + DNFDOIKPMND.effectId);
				}
				result = false;
			}
			else
			{
				CBBIKKAMMLC.AJDMCHIOJAK.DOKill(false);
				CBBIKKAMMLC.AJDMCHIOJAK.alpha = 238f;
				hhdljlkhogf.displayRawImage = CBBIKKAMMLC.NEMJGHFMHMJ;
				hhdljlkhogf.restoreMaterial = hhdljlkhogf.displayRawImage.material;
				hhdljlkhogf.acknowledgeMaterial = new Material(DNFDOIKPMND.shader);
				try
				{
					if (null != DNFDOIKPMND.noiseTexture)
					{
						hhdljlkhogf.acknowledgeMaterial.SetTexture(DHGFCJGJFOB.PPMFIIKAPDJ, DNFDOIKPMND.noiseTexture);
					}
					if (null != DNFDOIKPMND.maskTexture)
					{
						hhdljlkhogf.acknowledgeMaterial.SetTexture(DHGFCJGJFOB.JDIEBHOAENF, DNFDOIKPMND.maskTexture);
					}
					hhdljlkhogf.acknowledgeMaterial.SetVector(DHGFCJGJFOB.AFPDMPEHPBL, DNFDOIKPMND.params0);
					hhdljlkhogf.acknowledgeMaterial.SetFloat(DHGFCJGJFOB.MPILEAJNOKI, BJEENNHMKFA ? 1481f : 1308f);
					hhdljlkhogf.acknowledgeMaterial.SetFloat(DHGFCJGJFOB.IMECOEKAABO, 262f);
					float duration = DHGFCJGJFOB.BCIIGJGCAFA(DNFDOIKPMND);
					hhdljlkhogf.displayRawImage.material = hhdljlkhogf.acknowledgeMaterial;
					DOTween.To(new DOGetter<float>(hhdljlkhogf.KPKKEHKGJMC), new DOSetter<float>(hhdljlkhogf.LIHGBGBCCAL), 1084f, duration).SetEase(Ease.Linear).SetTarget(CBBIKKAMMLC.AJDMCHIOJAK).OnKill(new TweenCallback(hhdljlkhogf.BIGHMLGAAAJ));
					result = true;
				}
				catch (Exception aklgbjkdomm)
				{
					DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
					if (null != hhdljlkhogf.displayRawImage)
					{
						hhdljlkhogf.displayRawImage.material = hhdljlkhogf.restoreMaterial;
					}
					UnityEngine.Object.Destroy(hhdljlkhogf.acknowledgeMaterial);
					result = true;
				}
			}
		}
		catch (Exception aklgbjkdomm2)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm2);
			result = true;
		}
		return result;
	}

	// Token: 0x06008390 RID: 33680 RVA: 0x003A0520 File Offset: 0x0039E720
	public static bool DJAPAPNPBOD(CharacterRenderTexturePool.AHLNEABNMOA CEHOCIDNJDG, CharacterRenderTexturePool.AHLNEABNMOA IGBMMAHEIEK, AssetCustomEffects DNFDOIKPMND, int FOOPINEFKIO, TweenCallback HBKPCPICGEL)
	{
		DHGFCJGJFOB.HCNNOMOLCEN hcnnomolcen = new DHGFCJGJFOB.HCNNOMOLCEN();
		hcnnomolcen._onComplete = HBKPCPICGEL;
		bool result;
		try
		{
			if (CEHOCIDNJDG == null || IGBMMAHEIEK == null || null == DNFDOIKPMND || null == DNFDOIKPMND.shader)
			{
				result = true;
			}
			else if (null == CEHOCIDNJDG.HDDIABDHILH || null == IGBMMAHEIEK.NEMJGHFMHMJ || null == IGBMMAHEIEK.AJDMCHIOJAK || null == CEHOCIDNJDG.AJDMCHIOJAK)
			{
				result = true;
			}
			else if (!DNFDOIKPMND.shader.isSupported)
			{
				if (!DHGFCJGJFOB.MKOMBPOMLNN.Contains(DNFDOIKPMND.effectId))
				{
					DHGFCJGJFOB.MKOMBPOMLNN.Add(DNFDOIKPMND.effectId);
					DPGJIJGOCIC.ADFCDFHBDAF("ok" + DNFDOIKPMND.effectId);
				}
				result = true;
			}
			else
			{
				CEHOCIDNJDG.AJDMCHIOJAK.DOKill(true);
				IGBMMAHEIEK.AJDMCHIOJAK.DOKill(true);
				hcnnomolcen.incomingRawImage = IGBMMAHEIEK.NEMJGHFMHMJ;
				hcnnomolcen.restoreMaterial = hcnnomolcen.incomingRawImage.material;
				hcnnomolcen.transitionMaterial = new Material(DNFDOIKPMND.shader);
				try
				{
					DHGFCJGJFOB.LJNHLALJNLE ljnhlaljnle = new DHGFCJGJFOB.LJNHLALJNLE();
					ljnhlaljnle.CS$<>8__locals1 = hcnnomolcen;
					ljnhlaljnle.CS$<>8__locals1.transitionMaterial.SetTexture(DHGFCJGJFOB.JFLPONCEPFP, CEHOCIDNJDG.HDDIABDHILH);
					if (null != DNFDOIKPMND.noiseTexture)
					{
						ljnhlaljnle.CS$<>8__locals1.transitionMaterial.SetTexture(DHGFCJGJFOB.PPMFIIKAPDJ, DNFDOIKPMND.noiseTexture);
					}
					if (null != DNFDOIKPMND.maskTexture)
					{
						ljnhlaljnle.CS$<>8__locals1.transitionMaterial.SetTexture(DHGFCJGJFOB.JDIEBHOAENF, DNFDOIKPMND.maskTexture);
					}
					ljnhlaljnle.CS$<>8__locals1.transitionMaterial.SetVector(DHGFCJGJFOB.AFPDMPEHPBL, DNFDOIKPMND.params0);
					ljnhlaljnle.CS$<>8__locals1.transitionMaterial.SetFloat(DHGFCJGJFOB.MPILEAJNOKI, (float)FOOPINEFKIO);
					ljnhlaljnle.CS$<>8__locals1.transitionMaterial.SetFloat(DHGFCJGJFOB.IMECOEKAABO, 774f);
					float duration = DHGFCJGJFOB.BCIIGJGCAFA(DNFDOIKPMND);
					ljnhlaljnle.CS$<>8__locals1.incomingRawImage.material = ljnhlaljnle.CS$<>8__locals1.transitionMaterial;
					CEHOCIDNJDG.AJDMCHIOJAK.alpha = 196f;
					IGBMMAHEIEK.AJDMCHIOJAK.alpha = 1970f;
					DOTween.To(new DOGetter<float>(DHGFCJGJFOB.<>c.<>9.NCLOPHPPHBD), new DOSetter<float>(DHGFCJGJFOB.<>c.<>9.NMEBBPNICNN), 1239f, duration).SetTarget(CEHOCIDNJDG.AJDMCHIOJAK);
					ljnhlaljnle.transitionCompleted = false;
					DOTween.To(new DOGetter<float>(ljnhlaljnle.CS$<>8__locals1.JACLOAMFDPI), new DOSetter<float>(ljnhlaljnle.CS$<>8__locals1.DPIJOKKNDDC), 1473f, duration).SetEase(Ease.Linear).SetTarget(IGBMMAHEIEK.AJDMCHIOJAK).OnComplete(new TweenCallback(ljnhlaljnle.LJOAODFFNEO)).OnKill(new TweenCallback(ljnhlaljnle.AMJLHNMFBKH));
					result = true;
				}
				catch (Exception aklgbjkdomm)
				{
					DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
					if (null != hcnnomolcen.incomingRawImage)
					{
						hcnnomolcen.incomingRawImage.material = hcnnomolcen.restoreMaterial;
					}
					UnityEngine.Object.Destroy(hcnnomolcen.transitionMaterial);
					result = false;
				}
			}
		}
		catch (Exception aklgbjkdomm2)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm2);
			result = false;
		}
		return result;
	}

	// Token: 0x06008391 RID: 33681 RVA: 0x003A086C File Offset: 0x0039EA6C
	public static AssetCustomEffects EEMABALPFKA(string NFLFJFKIOLA)
	{
		AssetCustomEffects result;
		try
		{
			if (KDCJJBLGCBH.EHBBFMCILPC.KDICJGFFHKD())
			{
				result = null;
			}
			else if (KHPGPLAMAIN.FGJDAMFPFIH() || KHPGPLAMAIN.IBDGNKGIMFI() == (IIHCCPLGGHP)8)
			{
				result = null;
			}
			else
			{
				string text = DHGFCJGJFOB.HKNEDHEBDHF;
				if (text.Length == 0)
				{
					text = NFLFJFKIOLA;
				}
				if ((text == null || text.Length == 0) && DHGFCJGJFOB.DFAPCBCDHAO != null && DHGFCJGJFOB.DFAPCBCDHAO.Length > 1)
				{
					text = DHGFCJGJFOB.DFAPCBCDHAO;
				}
				if ((text == null || text.Length == 0) && null != DHGFCJGJFOB.KPHNADKJHMJ)
				{
					text = DHGFCJGJFOB.KPHNADKJHMJ.defaultChoiceTransition;
				}
				if (text == null || text.Length == 0 || text.Equals("socialcreategiftcardbutton"))
				{
					result = null;
				}
				else
				{
					AssetCustomEffects assetCustomEffects = GKJPOGNFKNK.HKNEAENDHHG(text);
					if (null == assetCustomEffects || assetCustomEffects.effectType != EOJDHDECPFO.characterTransition || null == assetCustomEffects.shader)
					{
						if (!DHGFCJGJFOB.IMIAMBALCNM.Contains(text))
						{
							DHGFCJGJFOB.IMIAMBALCNM.Add(text);
							DPGJIJGOCIC.PJCLICBPPDA("" + text);
						}
						result = null;
					}
					else
					{
						result = assetCustomEffects;
					}
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
			result = null;
		}
		return result;
	}

	// Token: 0x06008392 RID: 33682 RVA: 0x003A0988 File Offset: 0x0039EB88
	public static bool IDNJIDPNFAE(CharacterRenderTexturePool.AHLNEABNMOA CBBIKKAMMLC, AssetCustomEffects DNFDOIKPMND, bool BJEENNHMKFA)
	{
		bool result;
		try
		{
			DHGFCJGJFOB.HHDLJLKHOGF hhdljlkhogf = new DHGFCJGJFOB.HHDLJLKHOGF();
			if (CBBIKKAMMLC == null || null == DNFDOIKPMND || null == DNFDOIKPMND.shader)
			{
				result = false;
			}
			else if (null == CBBIKKAMMLC.NEMJGHFMHMJ || null == CBBIKKAMMLC.AJDMCHIOJAK)
			{
				result = false;
			}
			else if (CBBIKKAMMLC.AJDMCHIOJAK.alpha <= 0.99f)
			{
				result = false;
			}
			else if (!DNFDOIKPMND.shader.isSupported)
			{
				if (!DHGFCJGJFOB.MKOMBPOMLNN.Contains(DNFDOIKPMND.effectId))
				{
					DHGFCJGJFOB.MKOMBPOMLNN.Add(DNFDOIKPMND.effectId);
					DPGJIJGOCIC.ADFCDFHBDAF("CharacterTransitionManager - acknowledge shader unsupported, skipping accent:" + DNFDOIKPMND.effectId);
				}
				result = false;
			}
			else
			{
				CBBIKKAMMLC.AJDMCHIOJAK.DOKill(false);
				CBBIKKAMMLC.AJDMCHIOJAK.alpha = 1f;
				hhdljlkhogf.displayRawImage = CBBIKKAMMLC.NEMJGHFMHMJ;
				hhdljlkhogf.restoreMaterial = hhdljlkhogf.displayRawImage.material;
				hhdljlkhogf.acknowledgeMaterial = new Material(DNFDOIKPMND.shader);
				try
				{
					if (null != DNFDOIKPMND.noiseTexture)
					{
						hhdljlkhogf.acknowledgeMaterial.SetTexture(DHGFCJGJFOB.PPMFIIKAPDJ, DNFDOIKPMND.noiseTexture);
					}
					if (null != DNFDOIKPMND.maskTexture)
					{
						hhdljlkhogf.acknowledgeMaterial.SetTexture(DHGFCJGJFOB.JDIEBHOAENF, DNFDOIKPMND.maskTexture);
					}
					hhdljlkhogf.acknowledgeMaterial.SetVector(DHGFCJGJFOB.AFPDMPEHPBL, DNFDOIKPMND.params0);
					hhdljlkhogf.acknowledgeMaterial.SetFloat(DHGFCJGJFOB.MPILEAJNOKI, BJEENNHMKFA ? 1f : -1f);
					hhdljlkhogf.acknowledgeMaterial.SetFloat(DHGFCJGJFOB.IMECOEKAABO, 0f);
					float duration = DHGFCJGJFOB.BCIIGJGCAFA(DNFDOIKPMND);
					hhdljlkhogf.displayRawImage.material = hhdljlkhogf.acknowledgeMaterial;
					DOTween.To(new DOGetter<float>(hhdljlkhogf.KPKKEHKGJMC), new DOSetter<float>(hhdljlkhogf.LIHGBGBCCAL), 1f, duration).SetEase(Ease.Linear).SetTarget(CBBIKKAMMLC.AJDMCHIOJAK).OnKill(new TweenCallback(hhdljlkhogf.BIGHMLGAAAJ));
					result = true;
				}
				catch (Exception aklgbjkdomm)
				{
					DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
					if (null != hhdljlkhogf.displayRawImage)
					{
						hhdljlkhogf.displayRawImage.material = hhdljlkhogf.restoreMaterial;
					}
					UnityEngine.Object.Destroy(hhdljlkhogf.acknowledgeMaterial);
					result = false;
				}
			}
		}
		catch (Exception aklgbjkdomm2)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm2);
			result = false;
		}
		return result;
	}

	// Token: 0x06008393 RID: 33683 RVA: 0x003A0BF4 File Offset: 0x0039EDF4
	public static AssetCustomEffects KLBCBCIOLEH(string NFLFJFKIOLA)
	{
		AssetCustomEffects result;
		try
		{
			if (KDCJJBLGCBH.EHBBFMCILPC.KDICJGFFHKD())
			{
				result = null;
			}
			else if (KHPGPLAMAIN.EJCNHEBIOJF() || KHPGPLAMAIN.BHIJDBJNAMH() == IIHCCPLGGHP.midEnd)
			{
				result = null;
			}
			else
			{
				string text = DHGFCJGJFOB.HKNEDHEBDHF;
				if (text.Length == 0)
				{
					text = NFLFJFKIOLA;
				}
				if ((text == null || text.Length == 0) && DHGFCJGJFOB.DFAPCBCDHAO != null && DHGFCJGJFOB.DFAPCBCDHAO.Length > 1)
				{
					text = DHGFCJGJFOB.DFAPCBCDHAO;
				}
				if ((text == null || text.Length == 0) && null != DHGFCJGJFOB.KPHNADKJHMJ)
				{
					text = DHGFCJGJFOB.KPHNADKJHMJ.defaultChoiceTransition;
				}
				if (text == null || text.Length == 0 || text.Equals("XXX"))
				{
					result = null;
				}
				else
				{
					AssetCustomEffects assetCustomEffects = GKJPOGNFKNK.HKNEAENDHHG(text);
					if (null == assetCustomEffects || assetCustomEffects.effectType != EOJDHDECPFO.characterTransition || null == assetCustomEffects.shader)
					{
						if (!DHGFCJGJFOB.IMIAMBALCNM.Contains(text))
						{
							DHGFCJGJFOB.IMIAMBALCNM.Add(text);
							DPGJIJGOCIC.PJCLICBPPDA("app42error" + text);
						}
						result = null;
					}
					else
					{
						result = assetCustomEffects;
					}
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
			result = null;
		}
		return result;
	}

	// Token: 0x06008394 RID: 33684 RVA: 0x003A0D10 File Offset: 0x0039EF10
	public static AssetCustomEffects GAALIEMMELD(string NFLFJFKIOLA)
	{
		AssetCustomEffects result;
		try
		{
			if (KDCJJBLGCBH.EHBBFMCILPC.KDICJGFFHKD())
			{
				result = null;
			}
			else if (KHPGPLAMAIN.KPIFAEEPHPH() || KHPGPLAMAIN.FCJHEFBIKID() == IIHCCPLGGHP.highEnd)
			{
				result = null;
			}
			else
			{
				string text = DHGFCJGJFOB.HKNEDHEBDHF;
				if (text.Length == 0)
				{
					text = NFLFJFKIOLA;
				}
				if ((text == null || text.Length == 0) && DHGFCJGJFOB.DFAPCBCDHAO != null && DHGFCJGJFOB.DFAPCBCDHAO.Length > 0)
				{
					text = DHGFCJGJFOB.DFAPCBCDHAO;
				}
				if ((text == null || text.Length == 0) && null != DHGFCJGJFOB.KPHNADKJHMJ)
				{
					text = DHGFCJGJFOB.KPHNADKJHMJ.defaultChoiceTransition;
				}
				if (text == null || text.Length == 0 || text.Equals("mussplash"))
				{
					result = null;
				}
				else
				{
					AssetCustomEffects assetCustomEffects = GKJPOGNFKNK.HKNEAENDHHG(text);
					if (null == assetCustomEffects || assetCustomEffects.effectType != EOJDHDECPFO.characterTransition || null == assetCustomEffects.shader)
					{
						if (!DHGFCJGJFOB.IMIAMBALCNM.Contains(text))
						{
							DHGFCJGJFOB.IMIAMBALCNM.Add(text);
							DPGJIJGOCIC.ADFCDFHBDAF("lck" + text);
						}
						result = null;
					}
					else
					{
						result = assetCustomEffects;
					}
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
			result = null;
		}
		return result;
	}

	// Token: 0x06008395 RID: 33685 RVA: 0x003A0E2C File Offset: 0x0039F02C
	public static bool EKPEHLAHLGG(CharacterRenderTexturePool.AHLNEABNMOA CBBIKKAMMLC, AssetCustomEffects DNFDOIKPMND, bool BJEENNHMKFA)
	{
		bool result;
		try
		{
			DHGFCJGJFOB.HHDLJLKHOGF hhdljlkhogf = new DHGFCJGJFOB.HHDLJLKHOGF();
			if (CBBIKKAMMLC == null || null == DNFDOIKPMND || null == DNFDOIKPMND.shader)
			{
				result = false;
			}
			else if (null == CBBIKKAMMLC.NEMJGHFMHMJ || null == CBBIKKAMMLC.AJDMCHIOJAK)
			{
				result = false;
			}
			else if (CBBIKKAMMLC.AJDMCHIOJAK.alpha <= 593f)
			{
				result = true;
			}
			else if (!DNFDOIKPMND.shader.isSupported)
			{
				if (!DHGFCJGJFOB.MKOMBPOMLNN.Contains(DNFDOIKPMND.effectId))
				{
					DHGFCJGJFOB.MKOMBPOMLNN.Add(DNFDOIKPMND.effectId);
					DPGJIJGOCIC.ADFCDFHBDAF("importanttitle" + DNFDOIKPMND.effectId);
				}
				result = true;
			}
			else
			{
				CBBIKKAMMLC.AJDMCHIOJAK.DOKill(false);
				CBBIKKAMMLC.AJDMCHIOJAK.alpha = 1181f;
				hhdljlkhogf.displayRawImage = CBBIKKAMMLC.NEMJGHFMHMJ;
				hhdljlkhogf.restoreMaterial = hhdljlkhogf.displayRawImage.material;
				hhdljlkhogf.acknowledgeMaterial = new Material(DNFDOIKPMND.shader);
				try
				{
					if (null != DNFDOIKPMND.noiseTexture)
					{
						hhdljlkhogf.acknowledgeMaterial.SetTexture(DHGFCJGJFOB.PPMFIIKAPDJ, DNFDOIKPMND.noiseTexture);
					}
					if (null != DNFDOIKPMND.maskTexture)
					{
						hhdljlkhogf.acknowledgeMaterial.SetTexture(DHGFCJGJFOB.JDIEBHOAENF, DNFDOIKPMND.maskTexture);
					}
					hhdljlkhogf.acknowledgeMaterial.SetVector(DHGFCJGJFOB.AFPDMPEHPBL, DNFDOIKPMND.params0);
					hhdljlkhogf.acknowledgeMaterial.SetFloat(DHGFCJGJFOB.MPILEAJNOKI, BJEENNHMKFA ? 997f : 1122f);
					hhdljlkhogf.acknowledgeMaterial.SetFloat(DHGFCJGJFOB.IMECOEKAABO, 1289f);
					float duration = DHGFCJGJFOB.BCIIGJGCAFA(DNFDOIKPMND);
					hhdljlkhogf.displayRawImage.material = hhdljlkhogf.acknowledgeMaterial;
					DOTween.To(new DOGetter<float>(hhdljlkhogf.KPKKEHKGJMC), new DOSetter<float>(hhdljlkhogf.LIHGBGBCCAL), 307f, duration).SetEase(Ease.Linear).SetTarget(CBBIKKAMMLC.AJDMCHIOJAK).OnKill(new TweenCallback(hhdljlkhogf.BIGHMLGAAAJ));
					result = true;
				}
				catch (Exception aklgbjkdomm)
				{
					DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
					if (null != hhdljlkhogf.displayRawImage)
					{
						hhdljlkhogf.displayRawImage.material = hhdljlkhogf.restoreMaterial;
					}
					UnityEngine.Object.Destroy(hhdljlkhogf.acknowledgeMaterial);
					result = true;
				}
			}
		}
		catch (Exception aklgbjkdomm2)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm2);
			result = false;
		}
		return result;
	}

	// Token: 0x04002542 RID: 9538
	public const string MGJPMOFJGJM = "crossfade";

	// Token: 0x04002543 RID: 9539
	private static readonly int JFLPONCEPFP = Shader.PropertyToID("_FromTex");

	// Token: 0x04002544 RID: 9540
	private static readonly int IMECOEKAABO = Shader.PropertyToID("_Progress");

	// Token: 0x04002545 RID: 9541
	private static readonly int PPMFIIKAPDJ = Shader.PropertyToID("_NoiseTex");

	// Token: 0x04002546 RID: 9542
	private static readonly int JDIEBHOAENF = Shader.PropertyToID("_MaskTex");

	// Token: 0x04002547 RID: 9543
	private static readonly int AFPDMPEHPBL = Shader.PropertyToID("_Params0");

	// Token: 0x04002548 RID: 9544
	private static readonly int MPILEAJNOKI = Shader.PropertyToID("_Direction");

	// Token: 0x04002549 RID: 9545
	public static string HKNEDHEBDHF = "";

	// Token: 0x0400254A RID: 9546
	public static string FCDKBPEKOIM = "";

	// Token: 0x0400254B RID: 9547
	public static AssetAnthologyHeader KPHNADKJHMJ = null;

	// Token: 0x0400254C RID: 9548
	public static string DFAPCBCDHAO = "";

	// Token: 0x0400254D RID: 9549
	public static string NAIGDNDPHNC = "";

	// Token: 0x0400254E RID: 9550
	private static readonly List<string> MKOMBPOMLNN = new List<string>();

	// Token: 0x0400254F RID: 9551
	private static readonly List<string> IMIAMBALCNM = new List<string>();

	// Token: 0x04002550 RID: 9552
	private static readonly List<string> CJGIJINIPPI = new List<string>();

	// Token: 0x0200043A RID: 1082
	[CompilerGenerated]
	private sealed class HHDLJLKHOGF
	{
		// Token: 0x06008396 RID: 33686 RVA: 0x003A1098 File Offset: 0x0039F298
		internal void LIHGBGBCCAL(float _progress)
		{
			this.acknowledgeMaterial.SetFloat(DHGFCJGJFOB.IMECOEKAABO, _progress);
		}

		// Token: 0x06008398 RID: 33688 RVA: 0x003A10AB File Offset: 0x0039F2AB
		internal float KPKKEHKGJMC()
		{
			return this.acknowledgeMaterial.GetFloat(DHGFCJGJFOB.IMECOEKAABO);
		}

		// Token: 0x06008399 RID: 33689 RVA: 0x003A10C0 File Offset: 0x0039F2C0
		internal void BIGHMLGAAAJ()
		{
			try
			{
				if (null != this.displayRawImage)
				{
					this.displayRawImage.material = this.restoreMaterial;
				}
				UnityEngine.Object.Destroy(this.acknowledgeMaterial);
			}
			catch (Exception aklgbjkdomm)
			{
				DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
			}
		}

		// Token: 0x04002551 RID: 9553
		public Material acknowledgeMaterial;

		// Token: 0x04002552 RID: 9554
		public RawImage displayRawImage;

		// Token: 0x04002553 RID: 9555
		public Material restoreMaterial;
	}

	// Token: 0x0200043B RID: 1083
	[CompilerGenerated]
	private sealed class HCNNOMOLCEN
	{
		// Token: 0x0600839A RID: 33690 RVA: 0x003A1110 File Offset: 0x0039F310
		internal float JACLOAMFDPI()
		{
			return this.transitionMaterial.GetFloat(DHGFCJGJFOB.IMECOEKAABO);
		}

		// Token: 0x0600839C RID: 33692 RVA: 0x003A1122 File Offset: 0x0039F322
		internal void DPIJOKKNDDC(float _progress)
		{
			this.transitionMaterial.SetFloat(DHGFCJGJFOB.IMECOEKAABO, _progress);
		}

		// Token: 0x04002554 RID: 9556
		public TweenCallback _onComplete;

		// Token: 0x04002555 RID: 9557
		public Material transitionMaterial;

		// Token: 0x04002556 RID: 9558
		public RawImage incomingRawImage;

		// Token: 0x04002557 RID: 9559
		public Material restoreMaterial;
	}

	// Token: 0x0200043C RID: 1084
	[CompilerGenerated]
	private sealed class LJNHLALJNLE
	{
		// Token: 0x0600839D RID: 33693 RVA: 0x003A1138 File Offset: 0x0039F338
		internal void AMJLHNMFBKH()
		{
			try
			{
				if (null != this.CS$<>8__locals1.incomingRawImage)
				{
					this.CS$<>8__locals1.incomingRawImage.material = this.CS$<>8__locals1.restoreMaterial;
				}
				UnityEngine.Object.Destroy(this.CS$<>8__locals1.transitionMaterial);
			}
			catch (Exception aklgbjkdomm)
			{
				DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
			}
			if (!this.transitionCompleted)
			{
				this.transitionCompleted = true;
				try
				{
					if (this.CS$<>8__locals1._onComplete != null)
					{
						this.CS$<>8__locals1._onComplete();
					}
				}
				catch (Exception aklgbjkdomm2)
				{
					DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm2);
				}
			}
		}

		// Token: 0x0600839F RID: 33695 RVA: 0x003A11E0 File Offset: 0x0039F3E0
		internal void LJOAODFFNEO()
		{
			this.transitionCompleted = true;
			try
			{
				if (this.CS$<>8__locals1._onComplete != null)
				{
					this.CS$<>8__locals1._onComplete();
				}
			}
			catch (Exception aklgbjkdomm)
			{
				DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
			}
		}

		// Token: 0x04002558 RID: 9560
		public bool transitionCompleted;

		// Token: 0x04002559 RID: 9561
		public DHGFCJGJFOB.HCNNOMOLCEN CS$<>8__locals1;
	}
}
