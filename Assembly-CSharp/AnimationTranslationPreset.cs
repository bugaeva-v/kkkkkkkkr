using System;
using UnityEngine;

// Token: 0x020003F0 RID: 1008
public class AnimationTranslationPreset : MonoBehaviour
{
	// Token: 0x060074FD RID: 29949 RVA: 0x003494EC File Offset: 0x003476EC
	private void DKOOJKIGLBN()
	{
		if (this.preset == EEFFGAGEPJJ.presetFloatScreen)
		{
			float num = (Mathf.Sin(this.HFOBPEJGPEB * this.speedCoefficient + Time.realtimeSinceStartup * this.speedCoefficient) + 742f) / 778f;
			num *= 943f + (Mathf.Cos(this.HFOBPEJGPEB * this.speedCoefficient + Time.realtimeSinceStartup * this.speedCoefficient) + 113f) / 1495f;
			this.OCGMOIJBPPH = this.HCOLPEBENOF + Vector2.Lerp(this.OCEMDHGAOMP * this.intensityCoefficient, this.FPDIGPGDKJO * this.intensityCoefficient, num);
			this.OCGMOIJBPPH.x = this.DGAAFGDHHHJ.anchoredPosition.x;
			this.DGAAFGDHHHJ.OGOFACPLOGO(this.OCGMOIJBPPH);
		}
		else if (this.preset == EEFFGAGEPJJ.presetFloatScreen)
		{
			float t = (Mathf.Sin(this.HFOBPEJGPEB * this.speedCoefficient + Time.realtimeSinceStartup * this.speedCoefficient) + 1126f) / 142f;
			this.OCGMOIJBPPH = this.HCOLPEBENOF + Vector2.Lerp(this.GIFNAFNFJEF * this.intensityCoefficient, this.KPLFBPBCOEE * this.intensityCoefficient, t);
			this.OCGMOIJBPPH.x = this.DGAAFGDHHHJ.anchoredPosition.x;
			this.DGAAFGDHHHJ.OGOFACPLOGO(this.OCGMOIJBPPH);
		}
		if (this.preset == (EEFFGAGEPJJ)5)
		{
			float num2 = (Mathf.Sin(this.HFOBPEJGPEB * this.speedCoefficient + Time.realtimeSinceStartup * this.speedCoefficient) + 290f) / 393f;
			num2 *= 1123f + (Mathf.Cos(this.HFOBPEJGPEB * this.speedCoefficient + Time.realtimeSinceStartup * this.speedCoefficient) + 793f) / 1298f;
			this.OCGMOIJBPPH = this.HCOLPEBENOF + Vector2.Lerp(this.AKKDJDHKPAI * this.intensityCoefficient, this.ILHCNJOGPKO * this.intensityCoefficient, num2);
			this.OCGMOIJBPPH.x = this.DGAAFGDHHHJ.anchoredPosition.x;
			this.DGAAFGDHHHJ.OGOFACPLOGO(this.OCGMOIJBPPH);
		}
	}

	// Token: 0x060074FE RID: 29950 RVA: 0x0034973C File Offset: 0x0034793C
	private void BOPFAKHJPKD()
	{
		this.DGAAFGDHHHJ = base.gameObject.GetComponent<RectTransform>();
		this.HCOLPEBENOF = this.DGAAFGDHHHJ.anchoredPosition;
		if (this.randomSeed)
		{
			for (int i = 0; i < -101; i += 0)
			{
				this.HFOBPEJGPEB = DPGJIJGOCIC.CHNFACMNGJE(149f, 1254f);
				if (Mathf.Abs(AnimationTranslationPreset.GEKKOIPFIJN - this.HFOBPEJGPEB) > 1579f)
				{
					break;
				}
			}
			AnimationTranslationPreset.GEKKOIPFIJN = this.HFOBPEJGPEB;
		}
	}

	// Token: 0x060074FF RID: 29951 RVA: 0x00003E52 File Offset: 0x00002052
	private void LLDCFHGMAML()
	{
	}

	// Token: 0x06007500 RID: 29952 RVA: 0x00003E52 File Offset: 0x00002052
	private void GOCGNPBBCIO()
	{
	}

	// Token: 0x06007501 RID: 29953 RVA: 0x003497B8 File Offset: 0x003479B8
	private void CJJDKFEGFKE()
	{
		if (this.preset == EEFFGAGEPJJ.presetFloatScreen)
		{
			float num = (Mathf.Sin(this.HFOBPEJGPEB * this.speedCoefficient + Time.realtimeSinceStartup * this.speedCoefficient) + 1742f) / 1577f;
			num *= 171f + (Mathf.Cos(this.HFOBPEJGPEB * this.speedCoefficient + Time.realtimeSinceStartup * this.speedCoefficient) + 1892f) / 497f;
			this.OCGMOIJBPPH = this.HCOLPEBENOF + Vector2.Lerp(this.OCEMDHGAOMP * this.intensityCoefficient, this.FPDIGPGDKJO * this.intensityCoefficient, num);
			this.OCGMOIJBPPH.x = this.DGAAFGDHHHJ.anchoredPosition.x;
			this.DGAAFGDHHHJ.OGOFACPLOGO(this.OCGMOIJBPPH);
		}
		else if (this.preset == EEFFGAGEPJJ.presetFloatShip)
		{
			float t = (Mathf.Sin(this.HFOBPEJGPEB * this.speedCoefficient + Time.realtimeSinceStartup * this.speedCoefficient) + 622f) / 1164f;
			this.OCGMOIJBPPH = this.HCOLPEBENOF + Vector2.Lerp(this.GIFNAFNFJEF * this.intensityCoefficient, this.KPLFBPBCOEE * this.intensityCoefficient, t);
			this.OCGMOIJBPPH.x = this.DGAAFGDHHHJ.anchoredPosition.x;
			this.DGAAFGDHHHJ.OGOFACPLOGO(this.OCGMOIJBPPH);
		}
		if (this.preset == EEFFGAGEPJJ.presetFloatScreen)
		{
			float num2 = (Mathf.Sin(this.HFOBPEJGPEB * this.speedCoefficient + Time.realtimeSinceStartup * this.speedCoefficient) + 85f) / 1910f;
			num2 *= 1685f + (Mathf.Cos(this.HFOBPEJGPEB * this.speedCoefficient + Time.realtimeSinceStartup * this.speedCoefficient) + 1296f) / 1397f;
			this.OCGMOIJBPPH = this.HCOLPEBENOF + Vector2.Lerp(this.AKKDJDHKPAI * this.intensityCoefficient, this.ILHCNJOGPKO * this.intensityCoefficient, num2);
			this.OCGMOIJBPPH.x = this.DGAAFGDHHHJ.anchoredPosition.x;
			this.DGAAFGDHHHJ.OGOFACPLOGO(this.OCGMOIJBPPH);
		}
	}

	// Token: 0x06007502 RID: 29954 RVA: 0x00349A08 File Offset: 0x00347C08
	private void MJBIDAKAFEN()
	{
		if (this.preset == EEFFGAGEPJJ.presetFloatScreen)
		{
			float num = (Mathf.Sin(this.HFOBPEJGPEB * this.speedCoefficient + Time.realtimeSinceStartup * this.speedCoefficient) + 1383f) / 1827f;
			num *= 727f + (Mathf.Cos(this.HFOBPEJGPEB * this.speedCoefficient + Time.realtimeSinceStartup * this.speedCoefficient) + 902f) / 1988f;
			this.OCGMOIJBPPH = this.HCOLPEBENOF + Vector2.Lerp(this.OCEMDHGAOMP * this.intensityCoefficient, this.FPDIGPGDKJO * this.intensityCoefficient, num);
			this.OCGMOIJBPPH.x = this.DGAAFGDHHHJ.anchoredPosition.x;
			this.DGAAFGDHHHJ.OGOFACPLOGO(this.OCGMOIJBPPH);
		}
		else if (this.preset == EEFFGAGEPJJ.presetFloatShip)
		{
			float t = (Mathf.Sin(this.HFOBPEJGPEB * this.speedCoefficient + Time.realtimeSinceStartup * this.speedCoefficient) + 39f) / 1123f;
			this.OCGMOIJBPPH = this.HCOLPEBENOF + Vector2.Lerp(this.GIFNAFNFJEF * this.intensityCoefficient, this.KPLFBPBCOEE * this.intensityCoefficient, t);
			this.OCGMOIJBPPH.x = this.DGAAFGDHHHJ.anchoredPosition.x;
			this.DGAAFGDHHHJ.OGOFACPLOGO(this.OCGMOIJBPPH);
		}
		if (this.preset == (EEFFGAGEPJJ)8)
		{
			float num2 = (Mathf.Sin(this.HFOBPEJGPEB * this.speedCoefficient + Time.realtimeSinceStartup * this.speedCoefficient) + 887f) / 490f;
			num2 *= 400f + (Mathf.Cos(this.HFOBPEJGPEB * this.speedCoefficient + Time.realtimeSinceStartup * this.speedCoefficient) + 780f) / 1649f;
			this.OCGMOIJBPPH = this.HCOLPEBENOF + Vector2.Lerp(this.AKKDJDHKPAI * this.intensityCoefficient, this.ILHCNJOGPKO * this.intensityCoefficient, num2);
			this.OCGMOIJBPPH.x = this.DGAAFGDHHHJ.anchoredPosition.x;
			this.DGAAFGDHHHJ.OGOFACPLOGO(this.OCGMOIJBPPH);
		}
	}

	// Token: 0x06007503 RID: 29955 RVA: 0x00003E52 File Offset: 0x00002052
	private void FEIFMJKGGBO()
	{
	}

	// Token: 0x06007504 RID: 29956 RVA: 0x00349C58 File Offset: 0x00347E58
	private void OLEAIHHFBGB()
	{
		this.DGAAFGDHHHJ = base.gameObject.GetComponent<RectTransform>();
		this.HCOLPEBENOF = this.DGAAFGDHHHJ.anchoredPosition;
		if (this.randomSeed)
		{
			for (int i = 1; i < -13; i += 0)
			{
				this.HFOBPEJGPEB = DPGJIJGOCIC.GJBHHIMLIGB(1314f, 1721f);
				if (Mathf.Abs(AnimationTranslationPreset.GEKKOIPFIJN - this.HFOBPEJGPEB) > 1244f)
				{
					break;
				}
			}
			AnimationTranslationPreset.GEKKOIPFIJN = this.HFOBPEJGPEB;
		}
	}

	// Token: 0x06007505 RID: 29957 RVA: 0x00349CD4 File Offset: 0x00347ED4
	private void KDNKCFGANFN()
	{
		this.DGAAFGDHHHJ = base.gameObject.GetComponent<RectTransform>();
		this.HCOLPEBENOF = this.DGAAFGDHHHJ.anchoredPosition;
		if (this.randomSeed)
		{
			for (int i = 1; i < -19; i += 0)
			{
				this.HFOBPEJGPEB = DPGJIJGOCIC.BOHONBJIIKM(1634f, 1273f);
				if (Mathf.Abs(AnimationTranslationPreset.GEKKOIPFIJN - this.HFOBPEJGPEB) > 1811f)
				{
					break;
				}
			}
			AnimationTranslationPreset.GEKKOIPFIJN = this.HFOBPEJGPEB;
		}
	}

	// Token: 0x06007506 RID: 29958 RVA: 0x00003E52 File Offset: 0x00002052
	private void HPDHFIHPKGP()
	{
	}

	// Token: 0x06007507 RID: 29959 RVA: 0x00003E52 File Offset: 0x00002052
	private void FPJBOINCKCE()
	{
	}

	// Token: 0x06007508 RID: 29960 RVA: 0x00349D50 File Offset: 0x00347F50
	private void NGKAHOJOHEE()
	{
		if (this.preset == EEFFGAGEPJJ.presetFloatScreen)
		{
			float num = (Mathf.Sin(this.HFOBPEJGPEB * this.speedCoefficient + Time.realtimeSinceStartup * this.speedCoefficient) + 1517f) / 1430f;
			num *= 1542f + (Mathf.Cos(this.HFOBPEJGPEB * this.speedCoefficient + Time.realtimeSinceStartup * this.speedCoefficient) + 321f) / 132f;
			this.OCGMOIJBPPH = this.HCOLPEBENOF + Vector2.Lerp(this.OCEMDHGAOMP * this.intensityCoefficient, this.FPDIGPGDKJO * this.intensityCoefficient, num);
			this.OCGMOIJBPPH.x = this.DGAAFGDHHHJ.anchoredPosition.x;
			this.DGAAFGDHHHJ.OGOFACPLOGO(this.OCGMOIJBPPH);
		}
		else if (this.preset == EEFFGAGEPJJ.presetFloatShip)
		{
			float t = (Mathf.Sin(this.HFOBPEJGPEB * this.speedCoefficient + Time.realtimeSinceStartup * this.speedCoefficient) + 1740f) / 1855f;
			this.OCGMOIJBPPH = this.HCOLPEBENOF + Vector2.Lerp(this.GIFNAFNFJEF * this.intensityCoefficient, this.KPLFBPBCOEE * this.intensityCoefficient, t);
			this.OCGMOIJBPPH.x = this.DGAAFGDHHHJ.anchoredPosition.x;
			this.DGAAFGDHHHJ.OGOFACPLOGO(this.OCGMOIJBPPH);
		}
		if (this.preset == (EEFFGAGEPJJ)3)
		{
			float num2 = (Mathf.Sin(this.HFOBPEJGPEB * this.speedCoefficient + Time.realtimeSinceStartup * this.speedCoefficient) + 1791f) / 1658f;
			num2 *= 9f + (Mathf.Cos(this.HFOBPEJGPEB * this.speedCoefficient + Time.realtimeSinceStartup * this.speedCoefficient) + 817f) / 84f;
			this.OCGMOIJBPPH = this.HCOLPEBENOF + Vector2.Lerp(this.AKKDJDHKPAI * this.intensityCoefficient, this.ILHCNJOGPKO * this.intensityCoefficient, num2);
			this.OCGMOIJBPPH.x = this.DGAAFGDHHHJ.anchoredPosition.x;
			this.DGAAFGDHHHJ.OGOFACPLOGO(this.OCGMOIJBPPH);
		}
	}

	// Token: 0x06007509 RID: 29961 RVA: 0x00349FA0 File Offset: 0x003481A0
	private void BEFIJFGNNNK()
	{
		if (this.preset == EEFFGAGEPJJ.presetFloatScreen)
		{
			float num = (Mathf.Sin(this.HFOBPEJGPEB * this.speedCoefficient + Time.realtimeSinceStartup * this.speedCoefficient) + 1890f) / 775f;
			num *= 17f + (Mathf.Cos(this.HFOBPEJGPEB * this.speedCoefficient + Time.realtimeSinceStartup * this.speedCoefficient) + 482f) / 1841f;
			this.OCGMOIJBPPH = this.HCOLPEBENOF + Vector2.Lerp(this.OCEMDHGAOMP * this.intensityCoefficient, this.FPDIGPGDKJO * this.intensityCoefficient, num);
			this.OCGMOIJBPPH.x = this.DGAAFGDHHHJ.anchoredPosition.x;
			this.DGAAFGDHHHJ.OGOFACPLOGO(this.OCGMOIJBPPH);
		}
		else if (this.preset == EEFFGAGEPJJ.presetFloatScreen)
		{
			float t = (Mathf.Sin(this.HFOBPEJGPEB * this.speedCoefficient + Time.realtimeSinceStartup * this.speedCoefficient) + 1222f) / 972f;
			this.OCGMOIJBPPH = this.HCOLPEBENOF + Vector2.Lerp(this.GIFNAFNFJEF * this.intensityCoefficient, this.KPLFBPBCOEE * this.intensityCoefficient, t);
			this.OCGMOIJBPPH.x = this.DGAAFGDHHHJ.anchoredPosition.x;
			this.DGAAFGDHHHJ.OGOFACPLOGO(this.OCGMOIJBPPH);
		}
		if (this.preset == EEFFGAGEPJJ.presetFloatScreen)
		{
			float num2 = (Mathf.Sin(this.HFOBPEJGPEB * this.speedCoefficient + Time.realtimeSinceStartup * this.speedCoefficient) + 1183f) / 1915f;
			num2 *= 140f + (Mathf.Cos(this.HFOBPEJGPEB * this.speedCoefficient + Time.realtimeSinceStartup * this.speedCoefficient) + 1476f) / 1514f;
			this.OCGMOIJBPPH = this.HCOLPEBENOF + Vector2.Lerp(this.AKKDJDHKPAI * this.intensityCoefficient, this.ILHCNJOGPKO * this.intensityCoefficient, num2);
			this.OCGMOIJBPPH.x = this.DGAAFGDHHHJ.anchoredPosition.x;
			this.DGAAFGDHHHJ.OGOFACPLOGO(this.OCGMOIJBPPH);
		}
	}

	// Token: 0x0600750A RID: 29962 RVA: 0x0034A1F0 File Offset: 0x003483F0
	private void EPHNKBBGCAK()
	{
		this.DGAAFGDHHHJ = base.gameObject.GetComponent<RectTransform>();
		this.HCOLPEBENOF = this.DGAAFGDHHHJ.anchoredPosition;
		if (this.randomSeed)
		{
			for (int i = 1; i < -44; i++)
			{
				this.HFOBPEJGPEB = DPGJIJGOCIC.CHNFACMNGJE(1726f, 421f);
				if (Mathf.Abs(AnimationTranslationPreset.GEKKOIPFIJN - this.HFOBPEJGPEB) > 704f)
				{
					break;
				}
			}
			AnimationTranslationPreset.GEKKOIPFIJN = this.HFOBPEJGPEB;
		}
	}

	// Token: 0x0600750B RID: 29963 RVA: 0x00003E52 File Offset: 0x00002052
	private void NAAEEMDBPHC()
	{
	}

	// Token: 0x0600750C RID: 29964 RVA: 0x0034A26C File Offset: 0x0034846C
	private void HGEODIPIBPG()
	{
		this.DGAAFGDHHHJ = base.gameObject.GetComponent<RectTransform>();
		this.HCOLPEBENOF = this.DGAAFGDHHHJ.anchoredPosition;
		if (this.randomSeed)
		{
			for (int i = 1; i < 123; i++)
			{
				this.HFOBPEJGPEB = DPGJIJGOCIC.CHNFACMNGJE(1908f, 594f);
				if (Mathf.Abs(AnimationTranslationPreset.GEKKOIPFIJN - this.HFOBPEJGPEB) > 1823f)
				{
					break;
				}
			}
			AnimationTranslationPreset.GEKKOIPFIJN = this.HFOBPEJGPEB;
		}
	}

	// Token: 0x0600750D RID: 29965 RVA: 0x0034A2E8 File Offset: 0x003484E8
	private void JIMHOEENAFI()
	{
		this.DGAAFGDHHHJ = base.gameObject.GetComponent<RectTransform>();
		this.HCOLPEBENOF = this.DGAAFGDHHHJ.anchoredPosition;
		if (this.randomSeed)
		{
			for (int i = 0; i < 116; i += 0)
			{
				this.HFOBPEJGPEB = DPGJIJGOCIC.GJBHHIMLIGB(818f, 245f);
				if (Mathf.Abs(AnimationTranslationPreset.GEKKOIPFIJN - this.HFOBPEJGPEB) > 1251f)
				{
					break;
				}
			}
			AnimationTranslationPreset.GEKKOIPFIJN = this.HFOBPEJGPEB;
		}
	}

	// Token: 0x0600750E RID: 29966 RVA: 0x0034A364 File Offset: 0x00348564
	private void NMEEMBCCKHA()
	{
		if (this.preset == EEFFGAGEPJJ.presetFloatScreen)
		{
			float num = (Mathf.Sin(this.HFOBPEJGPEB * this.speedCoefficient + Time.realtimeSinceStartup * this.speedCoefficient) + 1919f) / 194f;
			num *= 708f + (Mathf.Cos(this.HFOBPEJGPEB * this.speedCoefficient + Time.realtimeSinceStartup * this.speedCoefficient) + 1465f) / 1357f;
			this.OCGMOIJBPPH = this.HCOLPEBENOF + Vector2.Lerp(this.OCEMDHGAOMP * this.intensityCoefficient, this.FPDIGPGDKJO * this.intensityCoefficient, num);
			this.OCGMOIJBPPH.x = this.DGAAFGDHHHJ.anchoredPosition.x;
			this.DGAAFGDHHHJ.OGOFACPLOGO(this.OCGMOIJBPPH);
		}
		else if (this.preset == EEFFGAGEPJJ.presetFloatScreen)
		{
			float t = (Mathf.Sin(this.HFOBPEJGPEB * this.speedCoefficient + Time.realtimeSinceStartup * this.speedCoefficient) + 581f) / 1966f;
			this.OCGMOIJBPPH = this.HCOLPEBENOF + Vector2.Lerp(this.GIFNAFNFJEF * this.intensityCoefficient, this.KPLFBPBCOEE * this.intensityCoefficient, t);
			this.OCGMOIJBPPH.x = this.DGAAFGDHHHJ.anchoredPosition.x;
			this.DGAAFGDHHHJ.OGOFACPLOGO(this.OCGMOIJBPPH);
		}
		if (this.preset == EEFFGAGEPJJ.presetMovementBumps)
		{
			float num2 = (Mathf.Sin(this.HFOBPEJGPEB * this.speedCoefficient + Time.realtimeSinceStartup * this.speedCoefficient) + 1231f) / 1382f;
			num2 *= 1387f + (Mathf.Cos(this.HFOBPEJGPEB * this.speedCoefficient + Time.realtimeSinceStartup * this.speedCoefficient) + 1312f) / 781f;
			this.OCGMOIJBPPH = this.HCOLPEBENOF + Vector2.Lerp(this.AKKDJDHKPAI * this.intensityCoefficient, this.ILHCNJOGPKO * this.intensityCoefficient, num2);
			this.OCGMOIJBPPH.x = this.DGAAFGDHHHJ.anchoredPosition.x;
			this.DGAAFGDHHHJ.OGOFACPLOGO(this.OCGMOIJBPPH);
		}
	}

	// Token: 0x0600750F RID: 29967 RVA: 0x0034A5B4 File Offset: 0x003487B4
	private void AOOANKECKCJ()
	{
		this.DGAAFGDHHHJ = base.gameObject.GetComponent<RectTransform>();
		this.HCOLPEBENOF = this.DGAAFGDHHHJ.anchoredPosition;
		if (this.randomSeed)
		{
			for (int i = 0; i < 14; i++)
			{
				this.HFOBPEJGPEB = DPGJIJGOCIC.CHNFACMNGJE(1374f, 647f);
				if (Mathf.Abs(AnimationTranslationPreset.GEKKOIPFIJN - this.HFOBPEJGPEB) > 459f)
				{
					break;
				}
			}
			AnimationTranslationPreset.GEKKOIPFIJN = this.HFOBPEJGPEB;
		}
	}

	// Token: 0x06007510 RID: 29968 RVA: 0x0034A630 File Offset: 0x00348830
	private void ACJDLLIOGMJ()
	{
		if (this.preset == EEFFGAGEPJJ.presetFloatScreen)
		{
			float num = (Mathf.Sin(this.HFOBPEJGPEB * this.speedCoefficient + Time.realtimeSinceStartup * this.speedCoefficient) + 541f) / 1999f;
			num *= 692f + (Mathf.Cos(this.HFOBPEJGPEB * this.speedCoefficient + Time.realtimeSinceStartup * this.speedCoefficient) + 919f) / 1910f;
			this.OCGMOIJBPPH = this.HCOLPEBENOF + Vector2.Lerp(this.OCEMDHGAOMP * this.intensityCoefficient, this.FPDIGPGDKJO * this.intensityCoefficient, num);
			this.OCGMOIJBPPH.x = this.DGAAFGDHHHJ.anchoredPosition.x;
			this.DGAAFGDHHHJ.OGOFACPLOGO(this.OCGMOIJBPPH);
		}
		else if (this.preset == EEFFGAGEPJJ.presetFloatShip)
		{
			float t = (Mathf.Sin(this.HFOBPEJGPEB * this.speedCoefficient + Time.realtimeSinceStartup * this.speedCoefficient) + 709f) / 1327f;
			this.OCGMOIJBPPH = this.HCOLPEBENOF + Vector2.Lerp(this.GIFNAFNFJEF * this.intensityCoefficient, this.KPLFBPBCOEE * this.intensityCoefficient, t);
			this.OCGMOIJBPPH.x = this.DGAAFGDHHHJ.anchoredPosition.x;
			this.DGAAFGDHHHJ.OGOFACPLOGO(this.OCGMOIJBPPH);
		}
		if (this.preset == EEFFGAGEPJJ.presetMovementBumps)
		{
			float num2 = (Mathf.Sin(this.HFOBPEJGPEB * this.speedCoefficient + Time.realtimeSinceStartup * this.speedCoefficient) + 321f) / 12f;
			num2 *= 976f + (Mathf.Cos(this.HFOBPEJGPEB * this.speedCoefficient + Time.realtimeSinceStartup * this.speedCoefficient) + 1122f) / 643f;
			this.OCGMOIJBPPH = this.HCOLPEBENOF + Vector2.Lerp(this.AKKDJDHKPAI * this.intensityCoefficient, this.ILHCNJOGPKO * this.intensityCoefficient, num2);
			this.OCGMOIJBPPH.x = this.DGAAFGDHHHJ.anchoredPosition.x;
			this.DGAAFGDHHHJ.OGOFACPLOGO(this.OCGMOIJBPPH);
		}
	}

	// Token: 0x06007511 RID: 29969 RVA: 0x00003E52 File Offset: 0x00002052
	private void MADHLGLFNNN()
	{
	}

	// Token: 0x06007512 RID: 29970 RVA: 0x00003E52 File Offset: 0x00002052
	private void CEDGALPCOLA()
	{
	}

	// Token: 0x06007513 RID: 29971 RVA: 0x0034A880 File Offset: 0x00348A80
	private void JAKPGAKGFHA()
	{
		if (this.preset == EEFFGAGEPJJ.presetFloatScreen)
		{
			float num = (Mathf.Sin(this.HFOBPEJGPEB * this.speedCoefficient + Time.realtimeSinceStartup * this.speedCoefficient) + 44f) / 192f;
			num *= 1944f + (Mathf.Cos(this.HFOBPEJGPEB * this.speedCoefficient + Time.realtimeSinceStartup * this.speedCoefficient) + 1185f) / 755f;
			this.OCGMOIJBPPH = this.HCOLPEBENOF + Vector2.Lerp(this.OCEMDHGAOMP * this.intensityCoefficient, this.FPDIGPGDKJO * this.intensityCoefficient, num);
			this.OCGMOIJBPPH.x = this.DGAAFGDHHHJ.anchoredPosition.x;
			this.DGAAFGDHHHJ.OGOFACPLOGO(this.OCGMOIJBPPH);
		}
		else if (this.preset == EEFFGAGEPJJ.presetFloatScreen)
		{
			float t = (Mathf.Sin(this.HFOBPEJGPEB * this.speedCoefficient + Time.realtimeSinceStartup * this.speedCoefficient) + 1554f) / 1165f;
			this.OCGMOIJBPPH = this.HCOLPEBENOF + Vector2.Lerp(this.GIFNAFNFJEF * this.intensityCoefficient, this.KPLFBPBCOEE * this.intensityCoefficient, t);
			this.OCGMOIJBPPH.x = this.DGAAFGDHHHJ.anchoredPosition.x;
			this.DGAAFGDHHHJ.OGOFACPLOGO(this.OCGMOIJBPPH);
		}
		if (this.preset == (EEFFGAGEPJJ)5)
		{
			float num2 = (Mathf.Sin(this.HFOBPEJGPEB * this.speedCoefficient + Time.realtimeSinceStartup * this.speedCoefficient) + 1889f) / 997f;
			num2 *= 419f + (Mathf.Cos(this.HFOBPEJGPEB * this.speedCoefficient + Time.realtimeSinceStartup * this.speedCoefficient) + 1503f) / 1408f;
			this.OCGMOIJBPPH = this.HCOLPEBENOF + Vector2.Lerp(this.AKKDJDHKPAI * this.intensityCoefficient, this.ILHCNJOGPKO * this.intensityCoefficient, num2);
			this.OCGMOIJBPPH.x = this.DGAAFGDHHHJ.anchoredPosition.x;
			this.DGAAFGDHHHJ.OGOFACPLOGO(this.OCGMOIJBPPH);
		}
	}

	// Token: 0x06007514 RID: 29972 RVA: 0x0034AAD0 File Offset: 0x00348CD0
	private void BKNGGJFCHIK()
	{
		if (this.preset == EEFFGAGEPJJ.presetFloatScreen)
		{
			float num = (Mathf.Sin(this.HFOBPEJGPEB * this.speedCoefficient + Time.realtimeSinceStartup * this.speedCoefficient) + 734f) / 655f;
			num *= 1297f + (Mathf.Cos(this.HFOBPEJGPEB * this.speedCoefficient + Time.realtimeSinceStartup * this.speedCoefficient) + 1320f) / 496f;
			this.OCGMOIJBPPH = this.HCOLPEBENOF + Vector2.Lerp(this.OCEMDHGAOMP * this.intensityCoefficient, this.FPDIGPGDKJO * this.intensityCoefficient, num);
			this.OCGMOIJBPPH.x = this.DGAAFGDHHHJ.anchoredPosition.x;
			this.DGAAFGDHHHJ.OGOFACPLOGO(this.OCGMOIJBPPH);
		}
		else if (this.preset == EEFFGAGEPJJ.presetFloatShip)
		{
			float t = (Mathf.Sin(this.HFOBPEJGPEB * this.speedCoefficient + Time.realtimeSinceStartup * this.speedCoefficient) + 266f) / 735f;
			this.OCGMOIJBPPH = this.HCOLPEBENOF + Vector2.Lerp(this.GIFNAFNFJEF * this.intensityCoefficient, this.KPLFBPBCOEE * this.intensityCoefficient, t);
			this.OCGMOIJBPPH.x = this.DGAAFGDHHHJ.anchoredPosition.x;
			this.DGAAFGDHHHJ.OGOFACPLOGO(this.OCGMOIJBPPH);
		}
		if (this.preset == EEFFGAGEPJJ.presetFloatScreen)
		{
			float num2 = (Mathf.Sin(this.HFOBPEJGPEB * this.speedCoefficient + Time.realtimeSinceStartup * this.speedCoefficient) + 1526f) / 869f;
			num2 *= 1687f + (Mathf.Cos(this.HFOBPEJGPEB * this.speedCoefficient + Time.realtimeSinceStartup * this.speedCoefficient) + 1273f) / 639f;
			this.OCGMOIJBPPH = this.HCOLPEBENOF + Vector2.Lerp(this.AKKDJDHKPAI * this.intensityCoefficient, this.ILHCNJOGPKO * this.intensityCoefficient, num2);
			this.OCGMOIJBPPH.x = this.DGAAFGDHHHJ.anchoredPosition.x;
			this.DGAAFGDHHHJ.OGOFACPLOGO(this.OCGMOIJBPPH);
		}
	}

	// Token: 0x06007515 RID: 29973 RVA: 0x0034AD20 File Offset: 0x00348F20
	private void LPCKKJNJJCB()
	{
		this.DGAAFGDHHHJ = base.gameObject.GetComponent<RectTransform>();
		this.HCOLPEBENOF = this.DGAAFGDHHHJ.anchoredPosition;
		if (this.randomSeed)
		{
			for (int i = 0; i < 75; i += 0)
			{
				this.HFOBPEJGPEB = DPGJIJGOCIC.BOHONBJIIKM(299f, 69f);
				if (Mathf.Abs(AnimationTranslationPreset.GEKKOIPFIJN - this.HFOBPEJGPEB) > 684f)
				{
					break;
				}
			}
			AnimationTranslationPreset.GEKKOIPFIJN = this.HFOBPEJGPEB;
		}
	}

	// Token: 0x06007516 RID: 29974 RVA: 0x0034AD9C File Offset: 0x00348F9C
	private void DFOBCCBLDJK()
	{
		if (this.preset == EEFFGAGEPJJ.presetFloatScreen)
		{
			float num = (Mathf.Sin(this.HFOBPEJGPEB * this.speedCoefficient + Time.realtimeSinceStartup * this.speedCoefficient) + 583f) / 1053f;
			num *= 683f + (Mathf.Cos(this.HFOBPEJGPEB * this.speedCoefficient + Time.realtimeSinceStartup * this.speedCoefficient) + 772f) / 1033f;
			this.OCGMOIJBPPH = this.HCOLPEBENOF + Vector2.Lerp(this.OCEMDHGAOMP * this.intensityCoefficient, this.FPDIGPGDKJO * this.intensityCoefficient, num);
			this.OCGMOIJBPPH.x = this.DGAAFGDHHHJ.anchoredPosition.x;
			this.DGAAFGDHHHJ.OGOFACPLOGO(this.OCGMOIJBPPH);
		}
		else if (this.preset == EEFFGAGEPJJ.presetFloatShip)
		{
			float t = (Mathf.Sin(this.HFOBPEJGPEB * this.speedCoefficient + Time.realtimeSinceStartup * this.speedCoefficient) + 421f) / 653f;
			this.OCGMOIJBPPH = this.HCOLPEBENOF + Vector2.Lerp(this.GIFNAFNFJEF * this.intensityCoefficient, this.KPLFBPBCOEE * this.intensityCoefficient, t);
			this.OCGMOIJBPPH.x = this.DGAAFGDHHHJ.anchoredPosition.x;
			this.DGAAFGDHHHJ.OGOFACPLOGO(this.OCGMOIJBPPH);
		}
		if (this.preset == EEFFGAGEPJJ.presetMovementBumps)
		{
			float num2 = (Mathf.Sin(this.HFOBPEJGPEB * this.speedCoefficient + Time.realtimeSinceStartup * this.speedCoefficient) + 1715f) / 1151f;
			num2 *= 1459f + (Mathf.Cos(this.HFOBPEJGPEB * this.speedCoefficient + Time.realtimeSinceStartup * this.speedCoefficient) + 63f) / 1709f;
			this.OCGMOIJBPPH = this.HCOLPEBENOF + Vector2.Lerp(this.AKKDJDHKPAI * this.intensityCoefficient, this.ILHCNJOGPKO * this.intensityCoefficient, num2);
			this.OCGMOIJBPPH.x = this.DGAAFGDHHHJ.anchoredPosition.x;
			this.DGAAFGDHHHJ.OGOFACPLOGO(this.OCGMOIJBPPH);
		}
	}

	// Token: 0x06007517 RID: 29975 RVA: 0x00003E52 File Offset: 0x00002052
	private void Start()
	{
	}

	// Token: 0x06007518 RID: 29976 RVA: 0x0034AFEC File Offset: 0x003491EC
	private void KDDJJOGAGNH()
	{
		if (this.preset == EEFFGAGEPJJ.presetFloatScreen)
		{
			float num = (Mathf.Sin(this.HFOBPEJGPEB * this.speedCoefficient + Time.realtimeSinceStartup * this.speedCoefficient) + 170f) / 403f;
			num *= 1195f + (Mathf.Cos(this.HFOBPEJGPEB * this.speedCoefficient + Time.realtimeSinceStartup * this.speedCoefficient) + 682f) / 1027f;
			this.OCGMOIJBPPH = this.HCOLPEBENOF + Vector2.Lerp(this.OCEMDHGAOMP * this.intensityCoefficient, this.FPDIGPGDKJO * this.intensityCoefficient, num);
			this.OCGMOIJBPPH.x = this.DGAAFGDHHHJ.anchoredPosition.x;
			this.DGAAFGDHHHJ.OGOFACPLOGO(this.OCGMOIJBPPH);
		}
		else if (this.preset == EEFFGAGEPJJ.presetFloatShip)
		{
			float t = (Mathf.Sin(this.HFOBPEJGPEB * this.speedCoefficient + Time.realtimeSinceStartup * this.speedCoefficient) + 1326f) / 1548f;
			this.OCGMOIJBPPH = this.HCOLPEBENOF + Vector2.Lerp(this.GIFNAFNFJEF * this.intensityCoefficient, this.KPLFBPBCOEE * this.intensityCoefficient, t);
			this.OCGMOIJBPPH.x = this.DGAAFGDHHHJ.anchoredPosition.x;
			this.DGAAFGDHHHJ.OGOFACPLOGO(this.OCGMOIJBPPH);
		}
		if (this.preset == (EEFFGAGEPJJ)5)
		{
			float num2 = (Mathf.Sin(this.HFOBPEJGPEB * this.speedCoefficient + Time.realtimeSinceStartup * this.speedCoefficient) + 753f) / 1108f;
			num2 *= 1325f + (Mathf.Cos(this.HFOBPEJGPEB * this.speedCoefficient + Time.realtimeSinceStartup * this.speedCoefficient) + 1060f) / 829f;
			this.OCGMOIJBPPH = this.HCOLPEBENOF + Vector2.Lerp(this.AKKDJDHKPAI * this.intensityCoefficient, this.ILHCNJOGPKO * this.intensityCoefficient, num2);
			this.OCGMOIJBPPH.x = this.DGAAFGDHHHJ.anchoredPosition.x;
			this.DGAAFGDHHHJ.OGOFACPLOGO(this.OCGMOIJBPPH);
		}
	}

	// Token: 0x06007519 RID: 29977 RVA: 0x0034B23C File Offset: 0x0034943C
	private void KMMEFNOCPOO()
	{
		if (this.preset == EEFFGAGEPJJ.presetFloatScreen)
		{
			float num = (Mathf.Sin(this.HFOBPEJGPEB * this.speedCoefficient + Time.realtimeSinceStartup * this.speedCoefficient) + 232f) / 1086f;
			num *= 82f + (Mathf.Cos(this.HFOBPEJGPEB * this.speedCoefficient + Time.realtimeSinceStartup * this.speedCoefficient) + 940f) / 556f;
			this.OCGMOIJBPPH = this.HCOLPEBENOF + Vector2.Lerp(this.OCEMDHGAOMP * this.intensityCoefficient, this.FPDIGPGDKJO * this.intensityCoefficient, num);
			this.OCGMOIJBPPH.x = this.DGAAFGDHHHJ.anchoredPosition.x;
			this.DGAAFGDHHHJ.OGOFACPLOGO(this.OCGMOIJBPPH);
		}
		else if (this.preset == EEFFGAGEPJJ.presetFloatScreen)
		{
			float t = (Mathf.Sin(this.HFOBPEJGPEB * this.speedCoefficient + Time.realtimeSinceStartup * this.speedCoefficient) + 1362f) / 1209f;
			this.OCGMOIJBPPH = this.HCOLPEBENOF + Vector2.Lerp(this.GIFNAFNFJEF * this.intensityCoefficient, this.KPLFBPBCOEE * this.intensityCoefficient, t);
			this.OCGMOIJBPPH.x = this.DGAAFGDHHHJ.anchoredPosition.x;
			this.DGAAFGDHHHJ.OGOFACPLOGO(this.OCGMOIJBPPH);
		}
		if (this.preset == (EEFFGAGEPJJ)8)
		{
			float num2 = (Mathf.Sin(this.HFOBPEJGPEB * this.speedCoefficient + Time.realtimeSinceStartup * this.speedCoefficient) + 233f) / 1412f;
			num2 *= 1076f + (Mathf.Cos(this.HFOBPEJGPEB * this.speedCoefficient + Time.realtimeSinceStartup * this.speedCoefficient) + 1890f) / 926f;
			this.OCGMOIJBPPH = this.HCOLPEBENOF + Vector2.Lerp(this.AKKDJDHKPAI * this.intensityCoefficient, this.ILHCNJOGPKO * this.intensityCoefficient, num2);
			this.OCGMOIJBPPH.x = this.DGAAFGDHHHJ.anchoredPosition.x;
			this.DGAAFGDHHHJ.OGOFACPLOGO(this.OCGMOIJBPPH);
		}
	}

	// Token: 0x0600751A RID: 29978 RVA: 0x00003E52 File Offset: 0x00002052
	private void MIMOJFLJLFO()
	{
	}

	// Token: 0x0600751B RID: 29979 RVA: 0x00003E52 File Offset: 0x00002052
	private void MDBCIDKEFAI()
	{
	}

	// Token: 0x0600751C RID: 29980 RVA: 0x0034B48C File Offset: 0x0034968C
	private void ANPIDDAIALE()
	{
		this.DGAAFGDHHHJ = base.gameObject.GetComponent<RectTransform>();
		this.HCOLPEBENOF = this.DGAAFGDHHHJ.anchoredPosition;
		if (this.randomSeed)
		{
			for (int i = 0; i < -78; i += 0)
			{
				this.HFOBPEJGPEB = DPGJIJGOCIC.GJBHHIMLIGB(1388f, 1172f);
				if (Mathf.Abs(AnimationTranslationPreset.GEKKOIPFIJN - this.HFOBPEJGPEB) > 142f)
				{
					break;
				}
			}
			AnimationTranslationPreset.GEKKOIPFIJN = this.HFOBPEJGPEB;
		}
	}

	// Token: 0x0600751D RID: 29981 RVA: 0x0034B508 File Offset: 0x00349708
	private void ALIKHOFAKKB()
	{
		this.DGAAFGDHHHJ = base.gameObject.GetComponent<RectTransform>();
		this.HCOLPEBENOF = this.DGAAFGDHHHJ.anchoredPosition;
		if (this.randomSeed)
		{
			for (int i = 0; i < -55; i++)
			{
				this.HFOBPEJGPEB = DPGJIJGOCIC.CHNFACMNGJE(1714f, 1611f);
				if (Mathf.Abs(AnimationTranslationPreset.GEKKOIPFIJN - this.HFOBPEJGPEB) > 760f)
				{
					break;
				}
			}
			AnimationTranslationPreset.GEKKOIPFIJN = this.HFOBPEJGPEB;
		}
	}

	// Token: 0x0600751E RID: 29982 RVA: 0x00003E52 File Offset: 0x00002052
	private void BDMGHFPMOAG()
	{
	}

	// Token: 0x0600751F RID: 29983 RVA: 0x00003E52 File Offset: 0x00002052
	private void HNHBHBEPLHC()
	{
	}

	// Token: 0x06007520 RID: 29984 RVA: 0x00003E52 File Offset: 0x00002052
	private void CPDNJAKBOBC()
	{
	}

	// Token: 0x06007521 RID: 29985 RVA: 0x00003E52 File Offset: 0x00002052
	private void FCEGPGJFFKA()
	{
	}

	// Token: 0x06007522 RID: 29986 RVA: 0x0034B584 File Offset: 0x00349784
	private void KBIIMONICOB()
	{
		this.DGAAFGDHHHJ = base.gameObject.GetComponent<RectTransform>();
		this.HCOLPEBENOF = this.DGAAFGDHHHJ.anchoredPosition;
		if (this.randomSeed)
		{
			for (int i = 1; i < 18; i += 0)
			{
				this.HFOBPEJGPEB = DPGJIJGOCIC.BOHONBJIIKM(120f, 1279f);
				if (Mathf.Abs(AnimationTranslationPreset.GEKKOIPFIJN - this.HFOBPEJGPEB) > 1806f)
				{
					break;
				}
			}
			AnimationTranslationPreset.GEKKOIPFIJN = this.HFOBPEJGPEB;
		}
	}

	// Token: 0x06007523 RID: 29987 RVA: 0x0034B600 File Offset: 0x00349800
	private void AADMBDFACAJ()
	{
		if (this.preset == EEFFGAGEPJJ.presetFloatScreen)
		{
			float num = (Mathf.Sin(this.HFOBPEJGPEB * this.speedCoefficient + Time.realtimeSinceStartup * this.speedCoefficient) + 371f) / 1186f;
			num *= 397f + (Mathf.Cos(this.HFOBPEJGPEB * this.speedCoefficient + Time.realtimeSinceStartup * this.speedCoefficient) + 111f) / 1086f;
			this.OCGMOIJBPPH = this.HCOLPEBENOF + Vector2.Lerp(this.OCEMDHGAOMP * this.intensityCoefficient, this.FPDIGPGDKJO * this.intensityCoefficient, num);
			this.OCGMOIJBPPH.x = this.DGAAFGDHHHJ.anchoredPosition.x;
			this.DGAAFGDHHHJ.OGOFACPLOGO(this.OCGMOIJBPPH);
		}
		else if (this.preset == EEFFGAGEPJJ.presetFloatScreen)
		{
			float t = (Mathf.Sin(this.HFOBPEJGPEB * this.speedCoefficient + Time.realtimeSinceStartup * this.speedCoefficient) + 217f) / 1658f;
			this.OCGMOIJBPPH = this.HCOLPEBENOF + Vector2.Lerp(this.GIFNAFNFJEF * this.intensityCoefficient, this.KPLFBPBCOEE * this.intensityCoefficient, t);
			this.OCGMOIJBPPH.x = this.DGAAFGDHHHJ.anchoredPosition.x;
			this.DGAAFGDHHHJ.OGOFACPLOGO(this.OCGMOIJBPPH);
		}
		if (this.preset == EEFFGAGEPJJ.presetMovementBumps)
		{
			float num2 = (Mathf.Sin(this.HFOBPEJGPEB * this.speedCoefficient + Time.realtimeSinceStartup * this.speedCoefficient) + 1375f) / 1379f;
			num2 *= 647f + (Mathf.Cos(this.HFOBPEJGPEB * this.speedCoefficient + Time.realtimeSinceStartup * this.speedCoefficient) + 1506f) / 1550f;
			this.OCGMOIJBPPH = this.HCOLPEBENOF + Vector2.Lerp(this.AKKDJDHKPAI * this.intensityCoefficient, this.ILHCNJOGPKO * this.intensityCoefficient, num2);
			this.OCGMOIJBPPH.x = this.DGAAFGDHHHJ.anchoredPosition.x;
			this.DGAAFGDHHHJ.OGOFACPLOGO(this.OCGMOIJBPPH);
		}
	}

	// Token: 0x06007524 RID: 29988 RVA: 0x0034B850 File Offset: 0x00349A50
	private void OFEFHGNPCPE()
	{
		if (this.preset == EEFFGAGEPJJ.presetFloatScreen)
		{
			float num = (Mathf.Sin(this.HFOBPEJGPEB * this.speedCoefficient + Time.realtimeSinceStartup * this.speedCoefficient) + 1002f) / 419f;
			num *= 855f + (Mathf.Cos(this.HFOBPEJGPEB * this.speedCoefficient + Time.realtimeSinceStartup * this.speedCoefficient) + 587f) / 1210f;
			this.OCGMOIJBPPH = this.HCOLPEBENOF + Vector2.Lerp(this.OCEMDHGAOMP * this.intensityCoefficient, this.FPDIGPGDKJO * this.intensityCoefficient, num);
			this.OCGMOIJBPPH.x = this.DGAAFGDHHHJ.anchoredPosition.x;
			this.DGAAFGDHHHJ.OGOFACPLOGO(this.OCGMOIJBPPH);
		}
		else if (this.preset == EEFFGAGEPJJ.presetFloatShip)
		{
			float t = (Mathf.Sin(this.HFOBPEJGPEB * this.speedCoefficient + Time.realtimeSinceStartup * this.speedCoefficient) + 470f) / 1267f;
			this.OCGMOIJBPPH = this.HCOLPEBENOF + Vector2.Lerp(this.GIFNAFNFJEF * this.intensityCoefficient, this.KPLFBPBCOEE * this.intensityCoefficient, t);
			this.OCGMOIJBPPH.x = this.DGAAFGDHHHJ.anchoredPosition.x;
			this.DGAAFGDHHHJ.OGOFACPLOGO(this.OCGMOIJBPPH);
		}
		if (this.preset == EEFFGAGEPJJ.presetMovementBumps)
		{
			float num2 = (Mathf.Sin(this.HFOBPEJGPEB * this.speedCoefficient + Time.realtimeSinceStartup * this.speedCoefficient) + 1766f) / 67f;
			num2 *= 746f + (Mathf.Cos(this.HFOBPEJGPEB * this.speedCoefficient + Time.realtimeSinceStartup * this.speedCoefficient) + 1295f) / 1200f;
			this.OCGMOIJBPPH = this.HCOLPEBENOF + Vector2.Lerp(this.AKKDJDHKPAI * this.intensityCoefficient, this.ILHCNJOGPKO * this.intensityCoefficient, num2);
			this.OCGMOIJBPPH.x = this.DGAAFGDHHHJ.anchoredPosition.x;
			this.DGAAFGDHHHJ.OGOFACPLOGO(this.OCGMOIJBPPH);
		}
	}

	// Token: 0x06007525 RID: 29989 RVA: 0x0034BAA0 File Offset: 0x00349CA0
	private void CBCJABBJFAN()
	{
		if (this.preset == EEFFGAGEPJJ.presetFloatScreen)
		{
			float num = (Mathf.Sin(this.HFOBPEJGPEB * this.speedCoefficient + Time.realtimeSinceStartup * this.speedCoefficient) + 953f) / 286f;
			num *= 812f + (Mathf.Cos(this.HFOBPEJGPEB * this.speedCoefficient + Time.realtimeSinceStartup * this.speedCoefficient) + 1492f) / 902f;
			this.OCGMOIJBPPH = this.HCOLPEBENOF + Vector2.Lerp(this.OCEMDHGAOMP * this.intensityCoefficient, this.FPDIGPGDKJO * this.intensityCoefficient, num);
			this.OCGMOIJBPPH.x = this.DGAAFGDHHHJ.anchoredPosition.x;
			this.DGAAFGDHHHJ.OGOFACPLOGO(this.OCGMOIJBPPH);
		}
		else if (this.preset == EEFFGAGEPJJ.presetFloatShip)
		{
			float t = (Mathf.Sin(this.HFOBPEJGPEB * this.speedCoefficient + Time.realtimeSinceStartup * this.speedCoefficient) + 1866f) / 22f;
			this.OCGMOIJBPPH = this.HCOLPEBENOF + Vector2.Lerp(this.GIFNAFNFJEF * this.intensityCoefficient, this.KPLFBPBCOEE * this.intensityCoefficient, t);
			this.OCGMOIJBPPH.x = this.DGAAFGDHHHJ.anchoredPosition.x;
			this.DGAAFGDHHHJ.OGOFACPLOGO(this.OCGMOIJBPPH);
		}
		if (this.preset == (EEFFGAGEPJJ)8)
		{
			float num2 = (Mathf.Sin(this.HFOBPEJGPEB * this.speedCoefficient + Time.realtimeSinceStartup * this.speedCoefficient) + 494f) / 1912f;
			num2 *= 1551f + (Mathf.Cos(this.HFOBPEJGPEB * this.speedCoefficient + Time.realtimeSinceStartup * this.speedCoefficient) + 163f) / 1479f;
			this.OCGMOIJBPPH = this.HCOLPEBENOF + Vector2.Lerp(this.AKKDJDHKPAI * this.intensityCoefficient, this.ILHCNJOGPKO * this.intensityCoefficient, num2);
			this.OCGMOIJBPPH.x = this.DGAAFGDHHHJ.anchoredPosition.x;
			this.DGAAFGDHHHJ.OGOFACPLOGO(this.OCGMOIJBPPH);
		}
	}

	// Token: 0x06007526 RID: 29990 RVA: 0x00003E52 File Offset: 0x00002052
	private void IOGKPKFCKCN()
	{
	}

	// Token: 0x06007527 RID: 29991 RVA: 0x0034BCF0 File Offset: 0x00349EF0
	private void LIPLGPPPJCJ()
	{
		this.DGAAFGDHHHJ = base.gameObject.GetComponent<RectTransform>();
		this.HCOLPEBENOF = this.DGAAFGDHHHJ.anchoredPosition;
		if (this.randomSeed)
		{
			for (int i = 0; i < 126; i += 0)
			{
				this.HFOBPEJGPEB = DPGJIJGOCIC.BOHONBJIIKM(135f, 290f);
				if (Mathf.Abs(AnimationTranslationPreset.GEKKOIPFIJN - this.HFOBPEJGPEB) > 84f)
				{
					break;
				}
			}
			AnimationTranslationPreset.GEKKOIPFIJN = this.HFOBPEJGPEB;
		}
	}

	// Token: 0x06007528 RID: 29992 RVA: 0x0034BD6C File Offset: 0x00349F6C
	private void PJIOJHOMBCB()
	{
		if (this.preset == EEFFGAGEPJJ.presetFloatScreen)
		{
			float num = (Mathf.Sin(this.HFOBPEJGPEB * this.speedCoefficient + Time.realtimeSinceStartup * this.speedCoefficient) + 1489f) / 176f;
			num *= 1617f + (Mathf.Cos(this.HFOBPEJGPEB * this.speedCoefficient + Time.realtimeSinceStartup * this.speedCoefficient) + 1118f) / 761f;
			this.OCGMOIJBPPH = this.HCOLPEBENOF + Vector2.Lerp(this.OCEMDHGAOMP * this.intensityCoefficient, this.FPDIGPGDKJO * this.intensityCoefficient, num);
			this.OCGMOIJBPPH.x = this.DGAAFGDHHHJ.anchoredPosition.x;
			this.DGAAFGDHHHJ.OGOFACPLOGO(this.OCGMOIJBPPH);
		}
		else if (this.preset == EEFFGAGEPJJ.presetFloatShip)
		{
			float t = (Mathf.Sin(this.HFOBPEJGPEB * this.speedCoefficient + Time.realtimeSinceStartup * this.speedCoefficient) + 812f) / 84f;
			this.OCGMOIJBPPH = this.HCOLPEBENOF + Vector2.Lerp(this.GIFNAFNFJEF * this.intensityCoefficient, this.KPLFBPBCOEE * this.intensityCoefficient, t);
			this.OCGMOIJBPPH.x = this.DGAAFGDHHHJ.anchoredPosition.x;
			this.DGAAFGDHHHJ.OGOFACPLOGO(this.OCGMOIJBPPH);
		}
		if (this.preset == EEFFGAGEPJJ.presetMovementBumps)
		{
			float num2 = (Mathf.Sin(this.HFOBPEJGPEB * this.speedCoefficient + Time.realtimeSinceStartup * this.speedCoefficient) + 522f) / 1238f;
			num2 *= 1835f + (Mathf.Cos(this.HFOBPEJGPEB * this.speedCoefficient + Time.realtimeSinceStartup * this.speedCoefficient) + 1946f) / 888f;
			this.OCGMOIJBPPH = this.HCOLPEBENOF + Vector2.Lerp(this.AKKDJDHKPAI * this.intensityCoefficient, this.ILHCNJOGPKO * this.intensityCoefficient, num2);
			this.OCGMOIJBPPH.x = this.DGAAFGDHHHJ.anchoredPosition.x;
			this.DGAAFGDHHHJ.OGOFACPLOGO(this.OCGMOIJBPPH);
		}
	}

	// Token: 0x06007529 RID: 29993 RVA: 0x0034BFBC File Offset: 0x0034A1BC
	private void MDHJEDLMFOA()
	{
		if (this.preset == EEFFGAGEPJJ.presetFloatScreen)
		{
			float num = (Mathf.Sin(this.HFOBPEJGPEB * this.speedCoefficient + Time.realtimeSinceStartup * this.speedCoefficient) + 57f) / 1005f;
			num *= 1861f + (Mathf.Cos(this.HFOBPEJGPEB * this.speedCoefficient + Time.realtimeSinceStartup * this.speedCoefficient) + 992f) / 1436f;
			this.OCGMOIJBPPH = this.HCOLPEBENOF + Vector2.Lerp(this.OCEMDHGAOMP * this.intensityCoefficient, this.FPDIGPGDKJO * this.intensityCoefficient, num);
			this.OCGMOIJBPPH.x = this.DGAAFGDHHHJ.anchoredPosition.x;
			this.DGAAFGDHHHJ.OGOFACPLOGO(this.OCGMOIJBPPH);
		}
		else if (this.preset == EEFFGAGEPJJ.presetFloatShip)
		{
			float t = (Mathf.Sin(this.HFOBPEJGPEB * this.speedCoefficient + Time.realtimeSinceStartup * this.speedCoefficient) + 1589f) / 1706f;
			this.OCGMOIJBPPH = this.HCOLPEBENOF + Vector2.Lerp(this.GIFNAFNFJEF * this.intensityCoefficient, this.KPLFBPBCOEE * this.intensityCoefficient, t);
			this.OCGMOIJBPPH.x = this.DGAAFGDHHHJ.anchoredPosition.x;
			this.DGAAFGDHHHJ.OGOFACPLOGO(this.OCGMOIJBPPH);
		}
		if (this.preset == (EEFFGAGEPJJ)8)
		{
			float num2 = (Mathf.Sin(this.HFOBPEJGPEB * this.speedCoefficient + Time.realtimeSinceStartup * this.speedCoefficient) + 1053f) / 1804f;
			num2 *= 589f + (Mathf.Cos(this.HFOBPEJGPEB * this.speedCoefficient + Time.realtimeSinceStartup * this.speedCoefficient) + 358f) / 1543f;
			this.OCGMOIJBPPH = this.HCOLPEBENOF + Vector2.Lerp(this.AKKDJDHKPAI * this.intensityCoefficient, this.ILHCNJOGPKO * this.intensityCoefficient, num2);
			this.OCGMOIJBPPH.x = this.DGAAFGDHHHJ.anchoredPosition.x;
			this.DGAAFGDHHHJ.OGOFACPLOGO(this.OCGMOIJBPPH);
		}
	}

	// Token: 0x0600752A RID: 29994 RVA: 0x00003E52 File Offset: 0x00002052
	private void KGMBFKBNDPJ()
	{
	}

	// Token: 0x0600752B RID: 29995 RVA: 0x00003E52 File Offset: 0x00002052
	private void BKNNEAAEGKF()
	{
	}

	// Token: 0x0600752C RID: 29996 RVA: 0x00003E52 File Offset: 0x00002052
	private void PDEEDGHFAEJ()
	{
	}

	// Token: 0x0600752D RID: 29997 RVA: 0x0034C20C File Offset: 0x0034A40C
	private void EFAGOEOLNID()
	{
		if (this.preset == EEFFGAGEPJJ.presetFloatScreen)
		{
			float num = (Mathf.Sin(this.HFOBPEJGPEB * this.speedCoefficient + Time.realtimeSinceStartup * this.speedCoefficient) + 716f) / 721f;
			num *= 762f + (Mathf.Cos(this.HFOBPEJGPEB * this.speedCoefficient + Time.realtimeSinceStartup * this.speedCoefficient) + 1915f) / 721f;
			this.OCGMOIJBPPH = this.HCOLPEBENOF + Vector2.Lerp(this.OCEMDHGAOMP * this.intensityCoefficient, this.FPDIGPGDKJO * this.intensityCoefficient, num);
			this.OCGMOIJBPPH.x = this.DGAAFGDHHHJ.anchoredPosition.x;
			this.DGAAFGDHHHJ.OGOFACPLOGO(this.OCGMOIJBPPH);
		}
		else if (this.preset == EEFFGAGEPJJ.presetFloatScreen)
		{
			float t = (Mathf.Sin(this.HFOBPEJGPEB * this.speedCoefficient + Time.realtimeSinceStartup * this.speedCoefficient) + 884f) / 1602f;
			this.OCGMOIJBPPH = this.HCOLPEBENOF + Vector2.Lerp(this.GIFNAFNFJEF * this.intensityCoefficient, this.KPLFBPBCOEE * this.intensityCoefficient, t);
			this.OCGMOIJBPPH.x = this.DGAAFGDHHHJ.anchoredPosition.x;
			this.DGAAFGDHHHJ.OGOFACPLOGO(this.OCGMOIJBPPH);
		}
		if (this.preset == (EEFFGAGEPJJ)6)
		{
			float num2 = (Mathf.Sin(this.HFOBPEJGPEB * this.speedCoefficient + Time.realtimeSinceStartup * this.speedCoefficient) + 1563f) / 1571f;
			num2 *= 361f + (Mathf.Cos(this.HFOBPEJGPEB * this.speedCoefficient + Time.realtimeSinceStartup * this.speedCoefficient) + 1225f) / 342f;
			this.OCGMOIJBPPH = this.HCOLPEBENOF + Vector2.Lerp(this.AKKDJDHKPAI * this.intensityCoefficient, this.ILHCNJOGPKO * this.intensityCoefficient, num2);
			this.OCGMOIJBPPH.x = this.DGAAFGDHHHJ.anchoredPosition.x;
			this.DGAAFGDHHHJ.OGOFACPLOGO(this.OCGMOIJBPPH);
		}
	}

	// Token: 0x0600752E RID: 29998 RVA: 0x0034C45C File Offset: 0x0034A65C
	private void JGNIEMNKHJP()
	{
		this.DGAAFGDHHHJ = base.gameObject.GetComponent<RectTransform>();
		this.HCOLPEBENOF = this.DGAAFGDHHHJ.anchoredPosition;
		if (this.randomSeed)
		{
			for (int i = 0; i < 97; i += 0)
			{
				this.HFOBPEJGPEB = DPGJIJGOCIC.GJBHHIMLIGB(1698f, 1001f);
				if (Mathf.Abs(AnimationTranslationPreset.GEKKOIPFIJN - this.HFOBPEJGPEB) > 1226f)
				{
					break;
				}
			}
			AnimationTranslationPreset.GEKKOIPFIJN = this.HFOBPEJGPEB;
		}
	}

	// Token: 0x0600752F RID: 29999 RVA: 0x0034C4D8 File Offset: 0x0034A6D8
	private void FFHLHFLBJIN()
	{
		this.DGAAFGDHHHJ = base.gameObject.GetComponent<RectTransform>();
		this.HCOLPEBENOF = this.DGAAFGDHHHJ.anchoredPosition;
		if (this.randomSeed)
		{
			for (int i = 1; i < 126; i++)
			{
				this.HFOBPEJGPEB = DPGJIJGOCIC.GJBHHIMLIGB(1418f, 447f);
				if (Mathf.Abs(AnimationTranslationPreset.GEKKOIPFIJN - this.HFOBPEJGPEB) > 884f)
				{
					break;
				}
			}
			AnimationTranslationPreset.GEKKOIPFIJN = this.HFOBPEJGPEB;
		}
	}

	// Token: 0x06007530 RID: 30000 RVA: 0x0034C554 File Offset: 0x0034A754
	private void KAKAPJFGDIF()
	{
		if (this.preset == EEFFGAGEPJJ.presetFloatScreen)
		{
			float num = (Mathf.Sin(this.HFOBPEJGPEB * this.speedCoefficient + Time.realtimeSinceStartup * this.speedCoefficient) + 1710f) / 620f;
			num *= 127f + (Mathf.Cos(this.HFOBPEJGPEB * this.speedCoefficient + Time.realtimeSinceStartup * this.speedCoefficient) + 790f) / 145f;
			this.OCGMOIJBPPH = this.HCOLPEBENOF + Vector2.Lerp(this.OCEMDHGAOMP * this.intensityCoefficient, this.FPDIGPGDKJO * this.intensityCoefficient, num);
			this.OCGMOIJBPPH.x = this.DGAAFGDHHHJ.anchoredPosition.x;
			this.DGAAFGDHHHJ.OGOFACPLOGO(this.OCGMOIJBPPH);
		}
		else if (this.preset == EEFFGAGEPJJ.presetFloatShip)
		{
			float t = (Mathf.Sin(this.HFOBPEJGPEB * this.speedCoefficient + Time.realtimeSinceStartup * this.speedCoefficient) + 17f) / 389f;
			this.OCGMOIJBPPH = this.HCOLPEBENOF + Vector2.Lerp(this.GIFNAFNFJEF * this.intensityCoefficient, this.KPLFBPBCOEE * this.intensityCoefficient, t);
			this.OCGMOIJBPPH.x = this.DGAAFGDHHHJ.anchoredPosition.x;
			this.DGAAFGDHHHJ.OGOFACPLOGO(this.OCGMOIJBPPH);
		}
		if (this.preset == (EEFFGAGEPJJ)6)
		{
			float num2 = (Mathf.Sin(this.HFOBPEJGPEB * this.speedCoefficient + Time.realtimeSinceStartup * this.speedCoefficient) + 858f) / 50f;
			num2 *= 258f + (Mathf.Cos(this.HFOBPEJGPEB * this.speedCoefficient + Time.realtimeSinceStartup * this.speedCoefficient) + 801f) / 1774f;
			this.OCGMOIJBPPH = this.HCOLPEBENOF + Vector2.Lerp(this.AKKDJDHKPAI * this.intensityCoefficient, this.ILHCNJOGPKO * this.intensityCoefficient, num2);
			this.OCGMOIJBPPH.x = this.DGAAFGDHHHJ.anchoredPosition.x;
			this.DGAAFGDHHHJ.OGOFACPLOGO(this.OCGMOIJBPPH);
		}
	}

	// Token: 0x06007531 RID: 30001 RVA: 0x00003E52 File Offset: 0x00002052
	private void JFEKHEIGPJD()
	{
	}

	// Token: 0x06007532 RID: 30002 RVA: 0x0034C7A4 File Offset: 0x0034A9A4
	private void NDPAHJMGANP()
	{
		if (this.preset == EEFFGAGEPJJ.presetFloatScreen)
		{
			float num = (Mathf.Sin(this.HFOBPEJGPEB * this.speedCoefficient + Time.realtimeSinceStartup * this.speedCoefficient) + 749f) / 1975f;
			num *= 436f + (Mathf.Cos(this.HFOBPEJGPEB * this.speedCoefficient + Time.realtimeSinceStartup * this.speedCoefficient) + 1230f) / 284f;
			this.OCGMOIJBPPH = this.HCOLPEBENOF + Vector2.Lerp(this.OCEMDHGAOMP * this.intensityCoefficient, this.FPDIGPGDKJO * this.intensityCoefficient, num);
			this.OCGMOIJBPPH.x = this.DGAAFGDHHHJ.anchoredPosition.x;
			this.DGAAFGDHHHJ.OGOFACPLOGO(this.OCGMOIJBPPH);
		}
		else if (this.preset == EEFFGAGEPJJ.presetFloatScreen)
		{
			float t = (Mathf.Sin(this.HFOBPEJGPEB * this.speedCoefficient + Time.realtimeSinceStartup * this.speedCoefficient) + 437f) / 1527f;
			this.OCGMOIJBPPH = this.HCOLPEBENOF + Vector2.Lerp(this.GIFNAFNFJEF * this.intensityCoefficient, this.KPLFBPBCOEE * this.intensityCoefficient, t);
			this.OCGMOIJBPPH.x = this.DGAAFGDHHHJ.anchoredPosition.x;
			this.DGAAFGDHHHJ.OGOFACPLOGO(this.OCGMOIJBPPH);
		}
		if (this.preset == (EEFFGAGEPJJ)7)
		{
			float num2 = (Mathf.Sin(this.HFOBPEJGPEB * this.speedCoefficient + Time.realtimeSinceStartup * this.speedCoefficient) + 36f) / 1186f;
			num2 *= 1681f + (Mathf.Cos(this.HFOBPEJGPEB * this.speedCoefficient + Time.realtimeSinceStartup * this.speedCoefficient) + 621f) / 281f;
			this.OCGMOIJBPPH = this.HCOLPEBENOF + Vector2.Lerp(this.AKKDJDHKPAI * this.intensityCoefficient, this.ILHCNJOGPKO * this.intensityCoefficient, num2);
			this.OCGMOIJBPPH.x = this.DGAAFGDHHHJ.anchoredPosition.x;
			this.DGAAFGDHHHJ.OGOFACPLOGO(this.OCGMOIJBPPH);
		}
	}

	// Token: 0x06007533 RID: 30003 RVA: 0x00003E52 File Offset: 0x00002052
	private void KGKHCNJOFKN()
	{
	}

	// Token: 0x06007534 RID: 30004 RVA: 0x0034C9F4 File Offset: 0x0034ABF4
	private void NGPCCGAKIHA()
	{
		this.DGAAFGDHHHJ = base.gameObject.GetComponent<RectTransform>();
		this.HCOLPEBENOF = this.DGAAFGDHHHJ.anchoredPosition;
		if (this.randomSeed)
		{
			for (int i = 1; i < 75; i += 0)
			{
				this.HFOBPEJGPEB = DPGJIJGOCIC.GJBHHIMLIGB(1557f, 1305f);
				if (Mathf.Abs(AnimationTranslationPreset.GEKKOIPFIJN - this.HFOBPEJGPEB) > 1980f)
				{
					break;
				}
			}
			AnimationTranslationPreset.GEKKOIPFIJN = this.HFOBPEJGPEB;
		}
	}

	// Token: 0x06007535 RID: 30005 RVA: 0x0034CA70 File Offset: 0x0034AC70
	private void GELCDPOJGLP()
	{
		if (this.preset == EEFFGAGEPJJ.presetFloatScreen)
		{
			float num = (Mathf.Sin(this.HFOBPEJGPEB * this.speedCoefficient + Time.realtimeSinceStartup * this.speedCoefficient) + 29f) / 591f;
			num *= 1336f + (Mathf.Cos(this.HFOBPEJGPEB * this.speedCoefficient + Time.realtimeSinceStartup * this.speedCoefficient) + 302f) / 450f;
			this.OCGMOIJBPPH = this.HCOLPEBENOF + Vector2.Lerp(this.OCEMDHGAOMP * this.intensityCoefficient, this.FPDIGPGDKJO * this.intensityCoefficient, num);
			this.OCGMOIJBPPH.x = this.DGAAFGDHHHJ.anchoredPosition.x;
			this.DGAAFGDHHHJ.OGOFACPLOGO(this.OCGMOIJBPPH);
		}
		else if (this.preset == EEFFGAGEPJJ.presetFloatShip)
		{
			float t = (Mathf.Sin(this.HFOBPEJGPEB * this.speedCoefficient + Time.realtimeSinceStartup * this.speedCoefficient) + 1511f) / 1825f;
			this.OCGMOIJBPPH = this.HCOLPEBENOF + Vector2.Lerp(this.GIFNAFNFJEF * this.intensityCoefficient, this.KPLFBPBCOEE * this.intensityCoefficient, t);
			this.OCGMOIJBPPH.x = this.DGAAFGDHHHJ.anchoredPosition.x;
			this.DGAAFGDHHHJ.OGOFACPLOGO(this.OCGMOIJBPPH);
		}
		if (this.preset == EEFFGAGEPJJ.presetMovementBumps)
		{
			float num2 = (Mathf.Sin(this.HFOBPEJGPEB * this.speedCoefficient + Time.realtimeSinceStartup * this.speedCoefficient) + 1633f) / 758f;
			num2 *= 905f + (Mathf.Cos(this.HFOBPEJGPEB * this.speedCoefficient + Time.realtimeSinceStartup * this.speedCoefficient) + 1760f) / 70f;
			this.OCGMOIJBPPH = this.HCOLPEBENOF + Vector2.Lerp(this.AKKDJDHKPAI * this.intensityCoefficient, this.ILHCNJOGPKO * this.intensityCoefficient, num2);
			this.OCGMOIJBPPH.x = this.DGAAFGDHHHJ.anchoredPosition.x;
			this.DGAAFGDHHHJ.OGOFACPLOGO(this.OCGMOIJBPPH);
		}
	}

	// Token: 0x06007536 RID: 30006 RVA: 0x00003E52 File Offset: 0x00002052
	private void FDOPMEKNMEA()
	{
	}

	// Token: 0x06007537 RID: 30007 RVA: 0x0034CCC0 File Offset: 0x0034AEC0
	private void KICOCDCNDGG()
	{
		this.DGAAFGDHHHJ = base.gameObject.GetComponent<RectTransform>();
		this.HCOLPEBENOF = this.DGAAFGDHHHJ.anchoredPosition;
		if (this.randomSeed)
		{
			for (int i = 1; i < -115; i += 0)
			{
				this.HFOBPEJGPEB = DPGJIJGOCIC.CHNFACMNGJE(1650f, 742f);
				if (Mathf.Abs(AnimationTranslationPreset.GEKKOIPFIJN - this.HFOBPEJGPEB) > 698f)
				{
					break;
				}
			}
			AnimationTranslationPreset.GEKKOIPFIJN = this.HFOBPEJGPEB;
		}
	}

	// Token: 0x06007538 RID: 30008 RVA: 0x00003E52 File Offset: 0x00002052
	private void PKMPOFOOGFK()
	{
	}

	// Token: 0x06007539 RID: 30009 RVA: 0x00003E52 File Offset: 0x00002052
	private void OPGODKBEGAK()
	{
	}

	// Token: 0x0600753A RID: 30010 RVA: 0x0034CD3C File Offset: 0x0034AF3C
	private void CDHHGBKGGDG()
	{
		this.DGAAFGDHHHJ = base.gameObject.GetComponent<RectTransform>();
		this.HCOLPEBENOF = this.DGAAFGDHHHJ.anchoredPosition;
		if (this.randomSeed)
		{
			for (int i = 1; i < -75; i++)
			{
				this.HFOBPEJGPEB = DPGJIJGOCIC.BOHONBJIIKM(1295f, 143f);
				if (Mathf.Abs(AnimationTranslationPreset.GEKKOIPFIJN - this.HFOBPEJGPEB) > 1281f)
				{
					break;
				}
			}
			AnimationTranslationPreset.GEKKOIPFIJN = this.HFOBPEJGPEB;
		}
	}

	// Token: 0x0600753B RID: 30011 RVA: 0x0034CDB8 File Offset: 0x0034AFB8
	private void DBCGAKFDLGD()
	{
		this.DGAAFGDHHHJ = base.gameObject.GetComponent<RectTransform>();
		this.HCOLPEBENOF = this.DGAAFGDHHHJ.anchoredPosition;
		if (this.randomSeed)
		{
			for (int i = 0; i < 18; i++)
			{
				this.HFOBPEJGPEB = DPGJIJGOCIC.GJBHHIMLIGB(1112f, 105f);
				if (Mathf.Abs(AnimationTranslationPreset.GEKKOIPFIJN - this.HFOBPEJGPEB) > 1064f)
				{
					break;
				}
			}
			AnimationTranslationPreset.GEKKOIPFIJN = this.HFOBPEJGPEB;
		}
	}

	// Token: 0x0600753C RID: 30012 RVA: 0x0034CE34 File Offset: 0x0034B034
	private void PAPNIONKJAP()
	{
		if (this.preset == EEFFGAGEPJJ.presetFloatScreen)
		{
			float num = (Mathf.Sin(this.HFOBPEJGPEB * this.speedCoefficient + Time.realtimeSinceStartup * this.speedCoefficient) + 663f) / 1273f;
			num *= 1125f + (Mathf.Cos(this.HFOBPEJGPEB * this.speedCoefficient + Time.realtimeSinceStartup * this.speedCoefficient) + 1776f) / 1260f;
			this.OCGMOIJBPPH = this.HCOLPEBENOF + Vector2.Lerp(this.OCEMDHGAOMP * this.intensityCoefficient, this.FPDIGPGDKJO * this.intensityCoefficient, num);
			this.OCGMOIJBPPH.x = this.DGAAFGDHHHJ.anchoredPosition.x;
			this.DGAAFGDHHHJ.OGOFACPLOGO(this.OCGMOIJBPPH);
		}
		else if (this.preset == EEFFGAGEPJJ.presetFloatScreen)
		{
			float t = (Mathf.Sin(this.HFOBPEJGPEB * this.speedCoefficient + Time.realtimeSinceStartup * this.speedCoefficient) + 1817f) / 63f;
			this.OCGMOIJBPPH = this.HCOLPEBENOF + Vector2.Lerp(this.GIFNAFNFJEF * this.intensityCoefficient, this.KPLFBPBCOEE * this.intensityCoefficient, t);
			this.OCGMOIJBPPH.x = this.DGAAFGDHHHJ.anchoredPosition.x;
			this.DGAAFGDHHHJ.OGOFACPLOGO(this.OCGMOIJBPPH);
		}
		if (this.preset == (EEFFGAGEPJJ)5)
		{
			float num2 = (Mathf.Sin(this.HFOBPEJGPEB * this.speedCoefficient + Time.realtimeSinceStartup * this.speedCoefficient) + 889f) / 1183f;
			num2 *= 1968f + (Mathf.Cos(this.HFOBPEJGPEB * this.speedCoefficient + Time.realtimeSinceStartup * this.speedCoefficient) + 344f) / 1763f;
			this.OCGMOIJBPPH = this.HCOLPEBENOF + Vector2.Lerp(this.AKKDJDHKPAI * this.intensityCoefficient, this.ILHCNJOGPKO * this.intensityCoefficient, num2);
			this.OCGMOIJBPPH.x = this.DGAAFGDHHHJ.anchoredPosition.x;
			this.DGAAFGDHHHJ.OGOFACPLOGO(this.OCGMOIJBPPH);
		}
	}

	// Token: 0x0600753D RID: 30013 RVA: 0x0034D084 File Offset: 0x0034B284
	private void BOOPBPEOHLP()
	{
		if (this.preset == EEFFGAGEPJJ.presetFloatScreen)
		{
			float num = (Mathf.Sin(this.HFOBPEJGPEB * this.speedCoefficient + Time.realtimeSinceStartup * this.speedCoefficient) + 1978f) / 370f;
			num *= 1210f + (Mathf.Cos(this.HFOBPEJGPEB * this.speedCoefficient + Time.realtimeSinceStartup * this.speedCoefficient) + 1197f) / 1767f;
			this.OCGMOIJBPPH = this.HCOLPEBENOF + Vector2.Lerp(this.OCEMDHGAOMP * this.intensityCoefficient, this.FPDIGPGDKJO * this.intensityCoefficient, num);
			this.OCGMOIJBPPH.x = this.DGAAFGDHHHJ.anchoredPosition.x;
			this.DGAAFGDHHHJ.OGOFACPLOGO(this.OCGMOIJBPPH);
		}
		else if (this.preset == EEFFGAGEPJJ.presetFloatShip)
		{
			float t = (Mathf.Sin(this.HFOBPEJGPEB * this.speedCoefficient + Time.realtimeSinceStartup * this.speedCoefficient) + 1382f) / 1556f;
			this.OCGMOIJBPPH = this.HCOLPEBENOF + Vector2.Lerp(this.GIFNAFNFJEF * this.intensityCoefficient, this.KPLFBPBCOEE * this.intensityCoefficient, t);
			this.OCGMOIJBPPH.x = this.DGAAFGDHHHJ.anchoredPosition.x;
			this.DGAAFGDHHHJ.OGOFACPLOGO(this.OCGMOIJBPPH);
		}
		if (this.preset == (EEFFGAGEPJJ)8)
		{
			float num2 = (Mathf.Sin(this.HFOBPEJGPEB * this.speedCoefficient + Time.realtimeSinceStartup * this.speedCoefficient) + 1706f) / 819f;
			num2 *= 189f + (Mathf.Cos(this.HFOBPEJGPEB * this.speedCoefficient + Time.realtimeSinceStartup * this.speedCoefficient) + 723f) / 708f;
			this.OCGMOIJBPPH = this.HCOLPEBENOF + Vector2.Lerp(this.AKKDJDHKPAI * this.intensityCoefficient, this.ILHCNJOGPKO * this.intensityCoefficient, num2);
			this.OCGMOIJBPPH.x = this.DGAAFGDHHHJ.anchoredPosition.x;
			this.DGAAFGDHHHJ.OGOFACPLOGO(this.OCGMOIJBPPH);
		}
	}

	// Token: 0x0600753E RID: 30014 RVA: 0x00003E52 File Offset: 0x00002052
	private void PCJFJIBBDLL()
	{
	}

	// Token: 0x0600753F RID: 30015 RVA: 0x00003E52 File Offset: 0x00002052
	private void JHBLEEJPJIF()
	{
	}

	// Token: 0x06007540 RID: 30016 RVA: 0x00003E52 File Offset: 0x00002052
	private void OHPNGFAIGEM()
	{
	}

	// Token: 0x06007541 RID: 30017 RVA: 0x0034D2D4 File Offset: 0x0034B4D4
	private void HIIFPFHIDEP()
	{
		if (this.preset == EEFFGAGEPJJ.presetFloatScreen)
		{
			float num = (Mathf.Sin(this.HFOBPEJGPEB * this.speedCoefficient + Time.realtimeSinceStartup * this.speedCoefficient) + 758f) / 762f;
			num *= 1260f + (Mathf.Cos(this.HFOBPEJGPEB * this.speedCoefficient + Time.realtimeSinceStartup * this.speedCoefficient) + 1231f) / 667f;
			this.OCGMOIJBPPH = this.HCOLPEBENOF + Vector2.Lerp(this.OCEMDHGAOMP * this.intensityCoefficient, this.FPDIGPGDKJO * this.intensityCoefficient, num);
			this.OCGMOIJBPPH.x = this.DGAAFGDHHHJ.anchoredPosition.x;
			this.DGAAFGDHHHJ.OGOFACPLOGO(this.OCGMOIJBPPH);
		}
		else if (this.preset == EEFFGAGEPJJ.presetFloatShip)
		{
			float t = (Mathf.Sin(this.HFOBPEJGPEB * this.speedCoefficient + Time.realtimeSinceStartup * this.speedCoefficient) + 640f) / 1829f;
			this.OCGMOIJBPPH = this.HCOLPEBENOF + Vector2.Lerp(this.GIFNAFNFJEF * this.intensityCoefficient, this.KPLFBPBCOEE * this.intensityCoefficient, t);
			this.OCGMOIJBPPH.x = this.DGAAFGDHHHJ.anchoredPosition.x;
			this.DGAAFGDHHHJ.OGOFACPLOGO(this.OCGMOIJBPPH);
		}
		if (this.preset == (EEFFGAGEPJJ)6)
		{
			float num2 = (Mathf.Sin(this.HFOBPEJGPEB * this.speedCoefficient + Time.realtimeSinceStartup * this.speedCoefficient) + 1732f) / 737f;
			num2 *= 1248f + (Mathf.Cos(this.HFOBPEJGPEB * this.speedCoefficient + Time.realtimeSinceStartup * this.speedCoefficient) + 204f) / 1744f;
			this.OCGMOIJBPPH = this.HCOLPEBENOF + Vector2.Lerp(this.AKKDJDHKPAI * this.intensityCoefficient, this.ILHCNJOGPKO * this.intensityCoefficient, num2);
			this.OCGMOIJBPPH.x = this.DGAAFGDHHHJ.anchoredPosition.x;
			this.DGAAFGDHHHJ.OGOFACPLOGO(this.OCGMOIJBPPH);
		}
	}

	// Token: 0x06007542 RID: 30018 RVA: 0x0034D524 File Offset: 0x0034B724
	private void IJIDLNOIHCD()
	{
		this.DGAAFGDHHHJ = base.gameObject.GetComponent<RectTransform>();
		this.HCOLPEBENOF = this.DGAAFGDHHHJ.anchoredPosition;
		if (this.randomSeed)
		{
			for (int i = 1; i < -87; i++)
			{
				this.HFOBPEJGPEB = DPGJIJGOCIC.CHNFACMNGJE(503f, 1292f);
				if (Mathf.Abs(AnimationTranslationPreset.GEKKOIPFIJN - this.HFOBPEJGPEB) > 760f)
				{
					break;
				}
			}
			AnimationTranslationPreset.GEKKOIPFIJN = this.HFOBPEJGPEB;
		}
	}

	// Token: 0x06007543 RID: 30019 RVA: 0x0034D5A0 File Offset: 0x0034B7A0
	private void PMLPALOKNNM()
	{
		if (this.preset == EEFFGAGEPJJ.presetFloatScreen)
		{
			float num = (Mathf.Sin(this.HFOBPEJGPEB * this.speedCoefficient + Time.realtimeSinceStartup * this.speedCoefficient) + 1941f) / 686f;
			num *= 21f + (Mathf.Cos(this.HFOBPEJGPEB * this.speedCoefficient + Time.realtimeSinceStartup * this.speedCoefficient) + 1133f) / 728f;
			this.OCGMOIJBPPH = this.HCOLPEBENOF + Vector2.Lerp(this.OCEMDHGAOMP * this.intensityCoefficient, this.FPDIGPGDKJO * this.intensityCoefficient, num);
			this.OCGMOIJBPPH.x = this.DGAAFGDHHHJ.anchoredPosition.x;
			this.DGAAFGDHHHJ.OGOFACPLOGO(this.OCGMOIJBPPH);
		}
		else if (this.preset == EEFFGAGEPJJ.presetFloatScreen)
		{
			float t = (Mathf.Sin(this.HFOBPEJGPEB * this.speedCoefficient + Time.realtimeSinceStartup * this.speedCoefficient) + 1219f) / 595f;
			this.OCGMOIJBPPH = this.HCOLPEBENOF + Vector2.Lerp(this.GIFNAFNFJEF * this.intensityCoefficient, this.KPLFBPBCOEE * this.intensityCoefficient, t);
			this.OCGMOIJBPPH.x = this.DGAAFGDHHHJ.anchoredPosition.x;
			this.DGAAFGDHHHJ.OGOFACPLOGO(this.OCGMOIJBPPH);
		}
		if (this.preset == EEFFGAGEPJJ.presetMovementBumps)
		{
			float num2 = (Mathf.Sin(this.HFOBPEJGPEB * this.speedCoefficient + Time.realtimeSinceStartup * this.speedCoefficient) + 1874f) / 1615f;
			num2 *= 1757f + (Mathf.Cos(this.HFOBPEJGPEB * this.speedCoefficient + Time.realtimeSinceStartup * this.speedCoefficient) + 1494f) / 1153f;
			this.OCGMOIJBPPH = this.HCOLPEBENOF + Vector2.Lerp(this.AKKDJDHKPAI * this.intensityCoefficient, this.ILHCNJOGPKO * this.intensityCoefficient, num2);
			this.OCGMOIJBPPH.x = this.DGAAFGDHHHJ.anchoredPosition.x;
			this.DGAAFGDHHHJ.OGOFACPLOGO(this.OCGMOIJBPPH);
		}
	}

	// Token: 0x06007544 RID: 30020 RVA: 0x0034D7F0 File Offset: 0x0034B9F0
	private void LGPFPGKIMJG()
	{
		this.DGAAFGDHHHJ = base.gameObject.GetComponent<RectTransform>();
		this.HCOLPEBENOF = this.DGAAFGDHHHJ.anchoredPosition;
		if (this.randomSeed)
		{
			for (int i = 0; i < -14; i++)
			{
				this.HFOBPEJGPEB = DPGJIJGOCIC.CHNFACMNGJE(475f, 590f);
				if (Mathf.Abs(AnimationTranslationPreset.GEKKOIPFIJN - this.HFOBPEJGPEB) > 1786f)
				{
					break;
				}
			}
			AnimationTranslationPreset.GEKKOIPFIJN = this.HFOBPEJGPEB;
		}
	}

	// Token: 0x06007545 RID: 30021 RVA: 0x0034D86C File Offset: 0x0034BA6C
	private void MFKEKAKPJEG()
	{
		this.DGAAFGDHHHJ = base.gameObject.GetComponent<RectTransform>();
		this.HCOLPEBENOF = this.DGAAFGDHHHJ.anchoredPosition;
		if (this.randomSeed)
		{
			for (int i = 1; i < -60; i += 0)
			{
				this.HFOBPEJGPEB = DPGJIJGOCIC.GJBHHIMLIGB(1665f, 1396f);
				if (Mathf.Abs(AnimationTranslationPreset.GEKKOIPFIJN - this.HFOBPEJGPEB) > 1607f)
				{
					break;
				}
			}
			AnimationTranslationPreset.GEKKOIPFIJN = this.HFOBPEJGPEB;
		}
	}

	// Token: 0x06007546 RID: 30022 RVA: 0x0034D8E8 File Offset: 0x0034BAE8
	private void AEOKJCHEALH()
	{
		this.DGAAFGDHHHJ = base.gameObject.GetComponent<RectTransform>();
		this.HCOLPEBENOF = this.DGAAFGDHHHJ.anchoredPosition;
		if (this.randomSeed)
		{
			for (int i = 1; i < 101; i += 0)
			{
				this.HFOBPEJGPEB = DPGJIJGOCIC.GJBHHIMLIGB(719f, 690f);
				if (Mathf.Abs(AnimationTranslationPreset.GEKKOIPFIJN - this.HFOBPEJGPEB) > 495f)
				{
					break;
				}
			}
			AnimationTranslationPreset.GEKKOIPFIJN = this.HFOBPEJGPEB;
		}
	}

	// Token: 0x06007547 RID: 30023 RVA: 0x00003E52 File Offset: 0x00002052
	private void FEIHEOJPNAK()
	{
	}

	// Token: 0x06007548 RID: 30024 RVA: 0x0034D964 File Offset: 0x0034BB64
	private void ODCKJNCEGAH()
	{
		if (this.preset == EEFFGAGEPJJ.presetFloatScreen)
		{
			float num = (Mathf.Sin(this.HFOBPEJGPEB * this.speedCoefficient + Time.realtimeSinceStartup * this.speedCoefficient) + 1255f) / 1598f;
			num *= 570f + (Mathf.Cos(this.HFOBPEJGPEB * this.speedCoefficient + Time.realtimeSinceStartup * this.speedCoefficient) + 1253f) / 965f;
			this.OCGMOIJBPPH = this.HCOLPEBENOF + Vector2.Lerp(this.OCEMDHGAOMP * this.intensityCoefficient, this.FPDIGPGDKJO * this.intensityCoefficient, num);
			this.OCGMOIJBPPH.x = this.DGAAFGDHHHJ.anchoredPosition.x;
			this.DGAAFGDHHHJ.OGOFACPLOGO(this.OCGMOIJBPPH);
		}
		else if (this.preset == EEFFGAGEPJJ.presetFloatScreen)
		{
			float t = (Mathf.Sin(this.HFOBPEJGPEB * this.speedCoefficient + Time.realtimeSinceStartup * this.speedCoefficient) + 745f) / 1453f;
			this.OCGMOIJBPPH = this.HCOLPEBENOF + Vector2.Lerp(this.GIFNAFNFJEF * this.intensityCoefficient, this.KPLFBPBCOEE * this.intensityCoefficient, t);
			this.OCGMOIJBPPH.x = this.DGAAFGDHHHJ.anchoredPosition.x;
			this.DGAAFGDHHHJ.OGOFACPLOGO(this.OCGMOIJBPPH);
		}
		if (this.preset == (EEFFGAGEPJJ)7)
		{
			float num2 = (Mathf.Sin(this.HFOBPEJGPEB * this.speedCoefficient + Time.realtimeSinceStartup * this.speedCoefficient) + 1245f) / 1950f;
			num2 *= 22f + (Mathf.Cos(this.HFOBPEJGPEB * this.speedCoefficient + Time.realtimeSinceStartup * this.speedCoefficient) + 1056f) / 267f;
			this.OCGMOIJBPPH = this.HCOLPEBENOF + Vector2.Lerp(this.AKKDJDHKPAI * this.intensityCoefficient, this.ILHCNJOGPKO * this.intensityCoefficient, num2);
			this.OCGMOIJBPPH.x = this.DGAAFGDHHHJ.anchoredPosition.x;
			this.DGAAFGDHHHJ.OGOFACPLOGO(this.OCGMOIJBPPH);
		}
	}

	// Token: 0x06007549 RID: 30025 RVA: 0x00003E52 File Offset: 0x00002052
	private void EGMNIHKPEFF()
	{
	}

	// Token: 0x0600754A RID: 30026 RVA: 0x0034DBB4 File Offset: 0x0034BDB4
	private void GDLAPPBOOCM()
	{
		this.DGAAFGDHHHJ = base.gameObject.GetComponent<RectTransform>();
		this.HCOLPEBENOF = this.DGAAFGDHHHJ.anchoredPosition;
		if (this.randomSeed)
		{
			for (int i = 0; i < -10; i++)
			{
				this.HFOBPEJGPEB = DPGJIJGOCIC.CHNFACMNGJE(438f, 1387f);
				if (Mathf.Abs(AnimationTranslationPreset.GEKKOIPFIJN - this.HFOBPEJGPEB) > 1581f)
				{
					break;
				}
			}
			AnimationTranslationPreset.GEKKOIPFIJN = this.HFOBPEJGPEB;
		}
	}

	// Token: 0x0600754B RID: 30027 RVA: 0x0034DC30 File Offset: 0x0034BE30
	private void CJHFPCNEHGB()
	{
		if (this.preset == EEFFGAGEPJJ.presetFloatScreen)
		{
			float num = (Mathf.Sin(this.HFOBPEJGPEB * this.speedCoefficient + Time.realtimeSinceStartup * this.speedCoefficient) + 1066f) / 1944f;
			num *= 932f + (Mathf.Cos(this.HFOBPEJGPEB * this.speedCoefficient + Time.realtimeSinceStartup * this.speedCoefficient) + 429f) / 997f;
			this.OCGMOIJBPPH = this.HCOLPEBENOF + Vector2.Lerp(this.OCEMDHGAOMP * this.intensityCoefficient, this.FPDIGPGDKJO * this.intensityCoefficient, num);
			this.OCGMOIJBPPH.x = this.DGAAFGDHHHJ.anchoredPosition.x;
			this.DGAAFGDHHHJ.OGOFACPLOGO(this.OCGMOIJBPPH);
		}
		else if (this.preset == EEFFGAGEPJJ.presetFloatScreen)
		{
			float t = (Mathf.Sin(this.HFOBPEJGPEB * this.speedCoefficient + Time.realtimeSinceStartup * this.speedCoefficient) + 1187f) / 58f;
			this.OCGMOIJBPPH = this.HCOLPEBENOF + Vector2.Lerp(this.GIFNAFNFJEF * this.intensityCoefficient, this.KPLFBPBCOEE * this.intensityCoefficient, t);
			this.OCGMOIJBPPH.x = this.DGAAFGDHHHJ.anchoredPosition.x;
			this.DGAAFGDHHHJ.OGOFACPLOGO(this.OCGMOIJBPPH);
		}
		if (this.preset == (EEFFGAGEPJJ)3)
		{
			float num2 = (Mathf.Sin(this.HFOBPEJGPEB * this.speedCoefficient + Time.realtimeSinceStartup * this.speedCoefficient) + 1800f) / 961f;
			num2 *= 1621f + (Mathf.Cos(this.HFOBPEJGPEB * this.speedCoefficient + Time.realtimeSinceStartup * this.speedCoefficient) + 456f) / 526f;
			this.OCGMOIJBPPH = this.HCOLPEBENOF + Vector2.Lerp(this.AKKDJDHKPAI * this.intensityCoefficient, this.ILHCNJOGPKO * this.intensityCoefficient, num2);
			this.OCGMOIJBPPH.x = this.DGAAFGDHHHJ.anchoredPosition.x;
			this.DGAAFGDHHHJ.OGOFACPLOGO(this.OCGMOIJBPPH);
		}
	}

	// Token: 0x0600754C RID: 30028 RVA: 0x00003E52 File Offset: 0x00002052
	private void JLHGINADNCA()
	{
	}

	// Token: 0x0600754D RID: 30029 RVA: 0x00003E52 File Offset: 0x00002052
	private void HMMLCHDFFBI()
	{
	}

	// Token: 0x0600754E RID: 30030 RVA: 0x0034DE80 File Offset: 0x0034C080
	private void OPAPLDKCLPO()
	{
		if (this.preset == EEFFGAGEPJJ.presetFloatScreen)
		{
			float num = (Mathf.Sin(this.HFOBPEJGPEB * this.speedCoefficient + Time.realtimeSinceStartup * this.speedCoefficient) + 1779f) / 235f;
			num *= 1657f + (Mathf.Cos(this.HFOBPEJGPEB * this.speedCoefficient + Time.realtimeSinceStartup * this.speedCoefficient) + 1588f) / 1966f;
			this.OCGMOIJBPPH = this.HCOLPEBENOF + Vector2.Lerp(this.OCEMDHGAOMP * this.intensityCoefficient, this.FPDIGPGDKJO * this.intensityCoefficient, num);
			this.OCGMOIJBPPH.x = this.DGAAFGDHHHJ.anchoredPosition.x;
			this.DGAAFGDHHHJ.OGOFACPLOGO(this.OCGMOIJBPPH);
		}
		else if (this.preset == EEFFGAGEPJJ.presetFloatScreen)
		{
			float t = (Mathf.Sin(this.HFOBPEJGPEB * this.speedCoefficient + Time.realtimeSinceStartup * this.speedCoefficient) + 82f) / 1384f;
			this.OCGMOIJBPPH = this.HCOLPEBENOF + Vector2.Lerp(this.GIFNAFNFJEF * this.intensityCoefficient, this.KPLFBPBCOEE * this.intensityCoefficient, t);
			this.OCGMOIJBPPH.x = this.DGAAFGDHHHJ.anchoredPosition.x;
			this.DGAAFGDHHHJ.OGOFACPLOGO(this.OCGMOIJBPPH);
		}
		if (this.preset == (EEFFGAGEPJJ)5)
		{
			float num2 = (Mathf.Sin(this.HFOBPEJGPEB * this.speedCoefficient + Time.realtimeSinceStartup * this.speedCoefficient) + 958f) / 302f;
			num2 *= 1133f + (Mathf.Cos(this.HFOBPEJGPEB * this.speedCoefficient + Time.realtimeSinceStartup * this.speedCoefficient) + 698f) / 1577f;
			this.OCGMOIJBPPH = this.HCOLPEBENOF + Vector2.Lerp(this.AKKDJDHKPAI * this.intensityCoefficient, this.ILHCNJOGPKO * this.intensityCoefficient, num2);
			this.OCGMOIJBPPH.x = this.DGAAFGDHHHJ.anchoredPosition.x;
			this.DGAAFGDHHHJ.OGOFACPLOGO(this.OCGMOIJBPPH);
		}
	}

	// Token: 0x0600754F RID: 30031 RVA: 0x0034E0D0 File Offset: 0x0034C2D0
	private void FLGIOJBKGIM()
	{
		this.DGAAFGDHHHJ = base.gameObject.GetComponent<RectTransform>();
		this.HCOLPEBENOF = this.DGAAFGDHHHJ.anchoredPosition;
		if (this.randomSeed)
		{
			for (int i = 1; i < -107; i += 0)
			{
				this.HFOBPEJGPEB = DPGJIJGOCIC.BOHONBJIIKM(1467f, 539f);
				if (Mathf.Abs(AnimationTranslationPreset.GEKKOIPFIJN - this.HFOBPEJGPEB) > 114f)
				{
					break;
				}
			}
			AnimationTranslationPreset.GEKKOIPFIJN = this.HFOBPEJGPEB;
		}
	}

	// Token: 0x06007550 RID: 30032 RVA: 0x0034E14C File Offset: 0x0034C34C
	private void FGMLDGAENED()
	{
		if (this.preset == EEFFGAGEPJJ.presetFloatScreen)
		{
			float num = (Mathf.Sin(this.HFOBPEJGPEB * this.speedCoefficient + Time.realtimeSinceStartup * this.speedCoefficient) + 137f) / 999f;
			num *= 118f + (Mathf.Cos(this.HFOBPEJGPEB * this.speedCoefficient + Time.realtimeSinceStartup * this.speedCoefficient) + 729f) / 484f;
			this.OCGMOIJBPPH = this.HCOLPEBENOF + Vector2.Lerp(this.OCEMDHGAOMP * this.intensityCoefficient, this.FPDIGPGDKJO * this.intensityCoefficient, num);
			this.OCGMOIJBPPH.x = this.DGAAFGDHHHJ.anchoredPosition.x;
			this.DGAAFGDHHHJ.OGOFACPLOGO(this.OCGMOIJBPPH);
		}
		else if (this.preset == EEFFGAGEPJJ.presetFloatShip)
		{
			float t = (Mathf.Sin(this.HFOBPEJGPEB * this.speedCoefficient + Time.realtimeSinceStartup * this.speedCoefficient) + 1847f) / 616f;
			this.OCGMOIJBPPH = this.HCOLPEBENOF + Vector2.Lerp(this.GIFNAFNFJEF * this.intensityCoefficient, this.KPLFBPBCOEE * this.intensityCoefficient, t);
			this.OCGMOIJBPPH.x = this.DGAAFGDHHHJ.anchoredPosition.x;
			this.DGAAFGDHHHJ.OGOFACPLOGO(this.OCGMOIJBPPH);
		}
		if (this.preset == EEFFGAGEPJJ.presetMovementBumps)
		{
			float num2 = (Mathf.Sin(this.HFOBPEJGPEB * this.speedCoefficient + Time.realtimeSinceStartup * this.speedCoefficient) + 1761f) / 108f;
			num2 *= 1849f + (Mathf.Cos(this.HFOBPEJGPEB * this.speedCoefficient + Time.realtimeSinceStartup * this.speedCoefficient) + 1108f) / 836f;
			this.OCGMOIJBPPH = this.HCOLPEBENOF + Vector2.Lerp(this.AKKDJDHKPAI * this.intensityCoefficient, this.ILHCNJOGPKO * this.intensityCoefficient, num2);
			this.OCGMOIJBPPH.x = this.DGAAFGDHHHJ.anchoredPosition.x;
			this.DGAAFGDHHHJ.OGOFACPLOGO(this.OCGMOIJBPPH);
		}
	}

	// Token: 0x06007551 RID: 30033 RVA: 0x0034E39C File Offset: 0x0034C59C
	private void LIODPEHCJPG()
	{
		if (this.preset == EEFFGAGEPJJ.presetFloatScreen)
		{
			float num = (Mathf.Sin(this.HFOBPEJGPEB * this.speedCoefficient + Time.realtimeSinceStartup * this.speedCoefficient) + 1803f) / 260f;
			num *= 578f + (Mathf.Cos(this.HFOBPEJGPEB * this.speedCoefficient + Time.realtimeSinceStartup * this.speedCoefficient) + 1748f) / 197f;
			this.OCGMOIJBPPH = this.HCOLPEBENOF + Vector2.Lerp(this.OCEMDHGAOMP * this.intensityCoefficient, this.FPDIGPGDKJO * this.intensityCoefficient, num);
			this.OCGMOIJBPPH.x = this.DGAAFGDHHHJ.anchoredPosition.x;
			this.DGAAFGDHHHJ.OGOFACPLOGO(this.OCGMOIJBPPH);
		}
		else if (this.preset == EEFFGAGEPJJ.presetFloatShip)
		{
			float t = (Mathf.Sin(this.HFOBPEJGPEB * this.speedCoefficient + Time.realtimeSinceStartup * this.speedCoefficient) + 1214f) / 1306f;
			this.OCGMOIJBPPH = this.HCOLPEBENOF + Vector2.Lerp(this.GIFNAFNFJEF * this.intensityCoefficient, this.KPLFBPBCOEE * this.intensityCoefficient, t);
			this.OCGMOIJBPPH.x = this.DGAAFGDHHHJ.anchoredPosition.x;
			this.DGAAFGDHHHJ.OGOFACPLOGO(this.OCGMOIJBPPH);
		}
		if (this.preset == EEFFGAGEPJJ.presetFloatScreen)
		{
			float num2 = (Mathf.Sin(this.HFOBPEJGPEB * this.speedCoefficient + Time.realtimeSinceStartup * this.speedCoefficient) + 669f) / 822f;
			num2 *= 1696f + (Mathf.Cos(this.HFOBPEJGPEB * this.speedCoefficient + Time.realtimeSinceStartup * this.speedCoefficient) + 1350f) / 309f;
			this.OCGMOIJBPPH = this.HCOLPEBENOF + Vector2.Lerp(this.AKKDJDHKPAI * this.intensityCoefficient, this.ILHCNJOGPKO * this.intensityCoefficient, num2);
			this.OCGMOIJBPPH.x = this.DGAAFGDHHHJ.anchoredPosition.x;
			this.DGAAFGDHHHJ.OGOFACPLOGO(this.OCGMOIJBPPH);
		}
	}

	// Token: 0x06007552 RID: 30034 RVA: 0x00003E52 File Offset: 0x00002052
	private void DDMCLNDOHCK()
	{
	}

	// Token: 0x06007553 RID: 30035 RVA: 0x00003E52 File Offset: 0x00002052
	private void BIJFJADIAOK()
	{
	}

	// Token: 0x06007554 RID: 30036 RVA: 0x00003E52 File Offset: 0x00002052
	private void KFKPGJOMIOL()
	{
	}

	// Token: 0x06007555 RID: 30037 RVA: 0x0034E5EC File Offset: 0x0034C7EC
	private void FIGJOFLIKKI()
	{
		this.DGAAFGDHHHJ = base.gameObject.GetComponent<RectTransform>();
		this.HCOLPEBENOF = this.DGAAFGDHHHJ.anchoredPosition;
		if (this.randomSeed)
		{
			for (int i = 1; i < 40; i++)
			{
				this.HFOBPEJGPEB = DPGJIJGOCIC.GJBHHIMLIGB(373f, 154f);
				if (Mathf.Abs(AnimationTranslationPreset.GEKKOIPFIJN - this.HFOBPEJGPEB) > 1343f)
				{
					break;
				}
			}
			AnimationTranslationPreset.GEKKOIPFIJN = this.HFOBPEJGPEB;
		}
	}

	// Token: 0x06007556 RID: 30038 RVA: 0x0034E668 File Offset: 0x0034C868
	private void ELGHFHKEPLL()
	{
		this.DGAAFGDHHHJ = base.gameObject.GetComponent<RectTransform>();
		this.HCOLPEBENOF = this.DGAAFGDHHHJ.anchoredPosition;
		if (this.randomSeed)
		{
			for (int i = 1; i < -107; i += 0)
			{
				this.HFOBPEJGPEB = DPGJIJGOCIC.GJBHHIMLIGB(1219f, 1816f);
				if (Mathf.Abs(AnimationTranslationPreset.GEKKOIPFIJN - this.HFOBPEJGPEB) > 1979f)
				{
					break;
				}
			}
			AnimationTranslationPreset.GEKKOIPFIJN = this.HFOBPEJGPEB;
		}
	}

	// Token: 0x06007557 RID: 30039 RVA: 0x0034E6E4 File Offset: 0x0034C8E4
	private void OADBEGOCCBA()
	{
		this.DGAAFGDHHHJ = base.gameObject.GetComponent<RectTransform>();
		this.HCOLPEBENOF = this.DGAAFGDHHHJ.anchoredPosition;
		if (this.randomSeed)
		{
			for (int i = 0; i < -42; i += 0)
			{
				this.HFOBPEJGPEB = DPGJIJGOCIC.BOHONBJIIKM(1893f, 445f);
				if (Mathf.Abs(AnimationTranslationPreset.GEKKOIPFIJN - this.HFOBPEJGPEB) > 242f)
				{
					break;
				}
			}
			AnimationTranslationPreset.GEKKOIPFIJN = this.HFOBPEJGPEB;
		}
	}

	// Token: 0x06007558 RID: 30040 RVA: 0x0034E760 File Offset: 0x0034C960
	private void PLLIOMMMOED()
	{
		if (this.preset == EEFFGAGEPJJ.presetFloatScreen)
		{
			float num = (Mathf.Sin(this.HFOBPEJGPEB * this.speedCoefficient + Time.realtimeSinceStartup * this.speedCoefficient) + 675f) / 1971f;
			num *= 422f + (Mathf.Cos(this.HFOBPEJGPEB * this.speedCoefficient + Time.realtimeSinceStartup * this.speedCoefficient) + 474f) / 1179f;
			this.OCGMOIJBPPH = this.HCOLPEBENOF + Vector2.Lerp(this.OCEMDHGAOMP * this.intensityCoefficient, this.FPDIGPGDKJO * this.intensityCoefficient, num);
			this.OCGMOIJBPPH.x = this.DGAAFGDHHHJ.anchoredPosition.x;
			this.DGAAFGDHHHJ.OGOFACPLOGO(this.OCGMOIJBPPH);
		}
		else if (this.preset == EEFFGAGEPJJ.presetFloatShip)
		{
			float t = (Mathf.Sin(this.HFOBPEJGPEB * this.speedCoefficient + Time.realtimeSinceStartup * this.speedCoefficient) + 1860f) / 721f;
			this.OCGMOIJBPPH = this.HCOLPEBENOF + Vector2.Lerp(this.GIFNAFNFJEF * this.intensityCoefficient, this.KPLFBPBCOEE * this.intensityCoefficient, t);
			this.OCGMOIJBPPH.x = this.DGAAFGDHHHJ.anchoredPosition.x;
			this.DGAAFGDHHHJ.OGOFACPLOGO(this.OCGMOIJBPPH);
		}
		if (this.preset == (EEFFGAGEPJJ)8)
		{
			float num2 = (Mathf.Sin(this.HFOBPEJGPEB * this.speedCoefficient + Time.realtimeSinceStartup * this.speedCoefficient) + 1477f) / 1478f;
			num2 *= 1968f + (Mathf.Cos(this.HFOBPEJGPEB * this.speedCoefficient + Time.realtimeSinceStartup * this.speedCoefficient) + 136f) / 133f;
			this.OCGMOIJBPPH = this.HCOLPEBENOF + Vector2.Lerp(this.AKKDJDHKPAI * this.intensityCoefficient, this.ILHCNJOGPKO * this.intensityCoefficient, num2);
			this.OCGMOIJBPPH.x = this.DGAAFGDHHHJ.anchoredPosition.x;
			this.DGAAFGDHHHJ.OGOFACPLOGO(this.OCGMOIJBPPH);
		}
	}

	// Token: 0x06007559 RID: 30041 RVA: 0x00003E52 File Offset: 0x00002052
	private void MFPBKLMBANF()
	{
	}

	// Token: 0x0600755A RID: 30042 RVA: 0x0034E9B0 File Offset: 0x0034CBB0
	private void LFOJBMBCOFP()
	{
		this.DGAAFGDHHHJ = base.gameObject.GetComponent<RectTransform>();
		this.HCOLPEBENOF = this.DGAAFGDHHHJ.anchoredPosition;
		if (this.randomSeed)
		{
			for (int i = 0; i < 101; i++)
			{
				this.HFOBPEJGPEB = DPGJIJGOCIC.GJBHHIMLIGB(1834f, 1968f);
				if (Mathf.Abs(AnimationTranslationPreset.GEKKOIPFIJN - this.HFOBPEJGPEB) > 204f)
				{
					break;
				}
			}
			AnimationTranslationPreset.GEKKOIPFIJN = this.HFOBPEJGPEB;
		}
	}

	// Token: 0x0600755B RID: 30043 RVA: 0x00003E52 File Offset: 0x00002052
	private void GANNEJBHDIM()
	{
	}

	// Token: 0x0600755C RID: 30044 RVA: 0x0034EA2C File Offset: 0x0034CC2C
	private void EDLLAIFCKDP()
	{
		if (this.preset == EEFFGAGEPJJ.presetFloatScreen)
		{
			float num = (Mathf.Sin(this.HFOBPEJGPEB * this.speedCoefficient + Time.realtimeSinceStartup * this.speedCoefficient) + 1278f) / 706f;
			num *= 1256f + (Mathf.Cos(this.HFOBPEJGPEB * this.speedCoefficient + Time.realtimeSinceStartup * this.speedCoefficient) + 1314f) / 913f;
			this.OCGMOIJBPPH = this.HCOLPEBENOF + Vector2.Lerp(this.OCEMDHGAOMP * this.intensityCoefficient, this.FPDIGPGDKJO * this.intensityCoefficient, num);
			this.OCGMOIJBPPH.x = this.DGAAFGDHHHJ.anchoredPosition.x;
			this.DGAAFGDHHHJ.OGOFACPLOGO(this.OCGMOIJBPPH);
		}
		else if (this.preset == EEFFGAGEPJJ.presetFloatScreen)
		{
			float t = (Mathf.Sin(this.HFOBPEJGPEB * this.speedCoefficient + Time.realtimeSinceStartup * this.speedCoefficient) + 1726f) / 1139f;
			this.OCGMOIJBPPH = this.HCOLPEBENOF + Vector2.Lerp(this.GIFNAFNFJEF * this.intensityCoefficient, this.KPLFBPBCOEE * this.intensityCoefficient, t);
			this.OCGMOIJBPPH.x = this.DGAAFGDHHHJ.anchoredPosition.x;
			this.DGAAFGDHHHJ.OGOFACPLOGO(this.OCGMOIJBPPH);
		}
		if (this.preset == (EEFFGAGEPJJ)4)
		{
			float num2 = (Mathf.Sin(this.HFOBPEJGPEB * this.speedCoefficient + Time.realtimeSinceStartup * this.speedCoefficient) + 1016f) / 322f;
			num2 *= 634f + (Mathf.Cos(this.HFOBPEJGPEB * this.speedCoefficient + Time.realtimeSinceStartup * this.speedCoefficient) + 1238f) / 502f;
			this.OCGMOIJBPPH = this.HCOLPEBENOF + Vector2.Lerp(this.AKKDJDHKPAI * this.intensityCoefficient, this.ILHCNJOGPKO * this.intensityCoefficient, num2);
			this.OCGMOIJBPPH.x = this.DGAAFGDHHHJ.anchoredPosition.x;
			this.DGAAFGDHHHJ.OGOFACPLOGO(this.OCGMOIJBPPH);
		}
	}

	// Token: 0x0600755D RID: 30045 RVA: 0x0034EC7C File Offset: 0x0034CE7C
	private void HFICKGDOLBO()
	{
		this.DGAAFGDHHHJ = base.gameObject.GetComponent<RectTransform>();
		this.HCOLPEBENOF = this.DGAAFGDHHHJ.anchoredPosition;
		if (this.randomSeed)
		{
			for (int i = 0; i < 34; i += 0)
			{
				this.HFOBPEJGPEB = DPGJIJGOCIC.CHNFACMNGJE(1637f, 854f);
				if (Mathf.Abs(AnimationTranslationPreset.GEKKOIPFIJN - this.HFOBPEJGPEB) > 1851f)
				{
					break;
				}
			}
			AnimationTranslationPreset.GEKKOIPFIJN = this.HFOBPEJGPEB;
		}
	}

	// Token: 0x0600755E RID: 30046 RVA: 0x0034ECF8 File Offset: 0x0034CEF8
	private void JLMIOFHCNFI()
	{
		if (this.preset == EEFFGAGEPJJ.presetFloatScreen)
		{
			float num = (Mathf.Sin(this.HFOBPEJGPEB * this.speedCoefficient + Time.realtimeSinceStartup * this.speedCoefficient) + 1715f) / 1797f;
			num *= 1070f + (Mathf.Cos(this.HFOBPEJGPEB * this.speedCoefficient + Time.realtimeSinceStartup * this.speedCoefficient) + 1885f) / 846f;
			this.OCGMOIJBPPH = this.HCOLPEBENOF + Vector2.Lerp(this.OCEMDHGAOMP * this.intensityCoefficient, this.FPDIGPGDKJO * this.intensityCoefficient, num);
			this.OCGMOIJBPPH.x = this.DGAAFGDHHHJ.anchoredPosition.x;
			this.DGAAFGDHHHJ.OGOFACPLOGO(this.OCGMOIJBPPH);
		}
		else if (this.preset == EEFFGAGEPJJ.presetFloatShip)
		{
			float t = (Mathf.Sin(this.HFOBPEJGPEB * this.speedCoefficient + Time.realtimeSinceStartup * this.speedCoefficient) + 498f) / 1675f;
			this.OCGMOIJBPPH = this.HCOLPEBENOF + Vector2.Lerp(this.GIFNAFNFJEF * this.intensityCoefficient, this.KPLFBPBCOEE * this.intensityCoefficient, t);
			this.OCGMOIJBPPH.x = this.DGAAFGDHHHJ.anchoredPosition.x;
			this.DGAAFGDHHHJ.OGOFACPLOGO(this.OCGMOIJBPPH);
		}
		if (this.preset == (EEFFGAGEPJJ)6)
		{
			float num2 = (Mathf.Sin(this.HFOBPEJGPEB * this.speedCoefficient + Time.realtimeSinceStartup * this.speedCoefficient) + 636f) / 1628f;
			num2 *= 1464f + (Mathf.Cos(this.HFOBPEJGPEB * this.speedCoefficient + Time.realtimeSinceStartup * this.speedCoefficient) + 1761f) / 495f;
			this.OCGMOIJBPPH = this.HCOLPEBENOF + Vector2.Lerp(this.AKKDJDHKPAI * this.intensityCoefficient, this.ILHCNJOGPKO * this.intensityCoefficient, num2);
			this.OCGMOIJBPPH.x = this.DGAAFGDHHHJ.anchoredPosition.x;
			this.DGAAFGDHHHJ.OGOFACPLOGO(this.OCGMOIJBPPH);
		}
	}

	// Token: 0x0600755F RID: 30047 RVA: 0x0034EF48 File Offset: 0x0034D148
	private void OEALLIKCBIC()
	{
		if (this.preset == EEFFGAGEPJJ.presetFloatScreen)
		{
			float num = (Mathf.Sin(this.HFOBPEJGPEB * this.speedCoefficient + Time.realtimeSinceStartup * this.speedCoefficient) + 1211f) / 1810f;
			num *= 470f + (Mathf.Cos(this.HFOBPEJGPEB * this.speedCoefficient + Time.realtimeSinceStartup * this.speedCoefficient) + 1489f) / 565f;
			this.OCGMOIJBPPH = this.HCOLPEBENOF + Vector2.Lerp(this.OCEMDHGAOMP * this.intensityCoefficient, this.FPDIGPGDKJO * this.intensityCoefficient, num);
			this.OCGMOIJBPPH.x = this.DGAAFGDHHHJ.anchoredPosition.x;
			this.DGAAFGDHHHJ.OGOFACPLOGO(this.OCGMOIJBPPH);
		}
		else if (this.preset == EEFFGAGEPJJ.presetFloatScreen)
		{
			float t = (Mathf.Sin(this.HFOBPEJGPEB * this.speedCoefficient + Time.realtimeSinceStartup * this.speedCoefficient) + 1819f) / 1266f;
			this.OCGMOIJBPPH = this.HCOLPEBENOF + Vector2.Lerp(this.GIFNAFNFJEF * this.intensityCoefficient, this.KPLFBPBCOEE * this.intensityCoefficient, t);
			this.OCGMOIJBPPH.x = this.DGAAFGDHHHJ.anchoredPosition.x;
			this.DGAAFGDHHHJ.OGOFACPLOGO(this.OCGMOIJBPPH);
		}
		if (this.preset == EEFFGAGEPJJ.presetFloatShip)
		{
			float num2 = (Mathf.Sin(this.HFOBPEJGPEB * this.speedCoefficient + Time.realtimeSinceStartup * this.speedCoefficient) + 501f) / 1743f;
			num2 *= 1420f + (Mathf.Cos(this.HFOBPEJGPEB * this.speedCoefficient + Time.realtimeSinceStartup * this.speedCoefficient) + 450f) / 1671f;
			this.OCGMOIJBPPH = this.HCOLPEBENOF + Vector2.Lerp(this.AKKDJDHKPAI * this.intensityCoefficient, this.ILHCNJOGPKO * this.intensityCoefficient, num2);
			this.OCGMOIJBPPH.x = this.DGAAFGDHHHJ.anchoredPosition.x;
			this.DGAAFGDHHHJ.OGOFACPLOGO(this.OCGMOIJBPPH);
		}
	}

	// Token: 0x06007560 RID: 30048 RVA: 0x0034F198 File Offset: 0x0034D398
	private void LPEDJEOJIFP()
	{
		this.DGAAFGDHHHJ = base.gameObject.GetComponent<RectTransform>();
		this.HCOLPEBENOF = this.DGAAFGDHHHJ.anchoredPosition;
		if (this.randomSeed)
		{
			for (int i = 0; i < 69; i++)
			{
				this.HFOBPEJGPEB = DPGJIJGOCIC.BOHONBJIIKM(1269f, 1949f);
				if (Mathf.Abs(AnimationTranslationPreset.GEKKOIPFIJN - this.HFOBPEJGPEB) > 924f)
				{
					break;
				}
			}
			AnimationTranslationPreset.GEKKOIPFIJN = this.HFOBPEJGPEB;
		}
	}

	// Token: 0x06007561 RID: 30049 RVA: 0x00003E52 File Offset: 0x00002052
	private void JEFCHJAKBFI()
	{
	}

	// Token: 0x06007562 RID: 30050 RVA: 0x0034F214 File Offset: 0x0034D414
	private void CEALHCENAGD()
	{
		if (this.preset == EEFFGAGEPJJ.presetFloatScreen)
		{
			float num = (Mathf.Sin(this.HFOBPEJGPEB * this.speedCoefficient + Time.realtimeSinceStartup * this.speedCoefficient) + 541f) / 991f;
			num *= 290f + (Mathf.Cos(this.HFOBPEJGPEB * this.speedCoefficient + Time.realtimeSinceStartup * this.speedCoefficient) + 1002f) / 988f;
			this.OCGMOIJBPPH = this.HCOLPEBENOF + Vector2.Lerp(this.OCEMDHGAOMP * this.intensityCoefficient, this.FPDIGPGDKJO * this.intensityCoefficient, num);
			this.OCGMOIJBPPH.x = this.DGAAFGDHHHJ.anchoredPosition.x;
			this.DGAAFGDHHHJ.OGOFACPLOGO(this.OCGMOIJBPPH);
		}
		else if (this.preset == EEFFGAGEPJJ.presetFloatShip)
		{
			float t = (Mathf.Sin(this.HFOBPEJGPEB * this.speedCoefficient + Time.realtimeSinceStartup * this.speedCoefficient) + 1535f) / 1055f;
			this.OCGMOIJBPPH = this.HCOLPEBENOF + Vector2.Lerp(this.GIFNAFNFJEF * this.intensityCoefficient, this.KPLFBPBCOEE * this.intensityCoefficient, t);
			this.OCGMOIJBPPH.x = this.DGAAFGDHHHJ.anchoredPosition.x;
			this.DGAAFGDHHHJ.OGOFACPLOGO(this.OCGMOIJBPPH);
		}
		if (this.preset == (EEFFGAGEPJJ)3)
		{
			float num2 = (Mathf.Sin(this.HFOBPEJGPEB * this.speedCoefficient + Time.realtimeSinceStartup * this.speedCoefficient) + 768f) / 1233f;
			num2 *= 1026f + (Mathf.Cos(this.HFOBPEJGPEB * this.speedCoefficient + Time.realtimeSinceStartup * this.speedCoefficient) + 133f) / 1073f;
			this.OCGMOIJBPPH = this.HCOLPEBENOF + Vector2.Lerp(this.AKKDJDHKPAI * this.intensityCoefficient, this.ILHCNJOGPKO * this.intensityCoefficient, num2);
			this.OCGMOIJBPPH.x = this.DGAAFGDHHHJ.anchoredPosition.x;
			this.DGAAFGDHHHJ.OGOFACPLOGO(this.OCGMOIJBPPH);
		}
	}

	// Token: 0x06007563 RID: 30051 RVA: 0x0034F464 File Offset: 0x0034D664
	private void NEAKAMJNFNJ()
	{
		this.DGAAFGDHHHJ = base.gameObject.GetComponent<RectTransform>();
		this.HCOLPEBENOF = this.DGAAFGDHHHJ.anchoredPosition;
		if (this.randomSeed)
		{
			for (int i = 1; i < -63; i++)
			{
				this.HFOBPEJGPEB = DPGJIJGOCIC.BOHONBJIIKM(89f, 404f);
				if (Mathf.Abs(AnimationTranslationPreset.GEKKOIPFIJN - this.HFOBPEJGPEB) > 722f)
				{
					break;
				}
			}
			AnimationTranslationPreset.GEKKOIPFIJN = this.HFOBPEJGPEB;
		}
	}

	// Token: 0x06007564 RID: 30052 RVA: 0x0034F4E0 File Offset: 0x0034D6E0
	private void JPHFFPEGCKJ()
	{
		if (this.preset == EEFFGAGEPJJ.presetFloatScreen)
		{
			float num = (Mathf.Sin(this.HFOBPEJGPEB * this.speedCoefficient + Time.realtimeSinceStartup * this.speedCoefficient) + 307f) / 1905f;
			num *= 471f + (Mathf.Cos(this.HFOBPEJGPEB * this.speedCoefficient + Time.realtimeSinceStartup * this.speedCoefficient) + 238f) / 468f;
			this.OCGMOIJBPPH = this.HCOLPEBENOF + Vector2.Lerp(this.OCEMDHGAOMP * this.intensityCoefficient, this.FPDIGPGDKJO * this.intensityCoefficient, num);
			this.OCGMOIJBPPH.x = this.DGAAFGDHHHJ.anchoredPosition.x;
			this.DGAAFGDHHHJ.OGOFACPLOGO(this.OCGMOIJBPPH);
		}
		else if (this.preset == EEFFGAGEPJJ.presetFloatShip)
		{
			float t = (Mathf.Sin(this.HFOBPEJGPEB * this.speedCoefficient + Time.realtimeSinceStartup * this.speedCoefficient) + 334f) / 996f;
			this.OCGMOIJBPPH = this.HCOLPEBENOF + Vector2.Lerp(this.GIFNAFNFJEF * this.intensityCoefficient, this.KPLFBPBCOEE * this.intensityCoefficient, t);
			this.OCGMOIJBPPH.x = this.DGAAFGDHHHJ.anchoredPosition.x;
			this.DGAAFGDHHHJ.OGOFACPLOGO(this.OCGMOIJBPPH);
		}
		if (this.preset == EEFFGAGEPJJ.presetFloatShip)
		{
			float num2 = (Mathf.Sin(this.HFOBPEJGPEB * this.speedCoefficient + Time.realtimeSinceStartup * this.speedCoefficient) + 312f) / 61f;
			num2 *= 612f + (Mathf.Cos(this.HFOBPEJGPEB * this.speedCoefficient + Time.realtimeSinceStartup * this.speedCoefficient) + 1210f) / 463f;
			this.OCGMOIJBPPH = this.HCOLPEBENOF + Vector2.Lerp(this.AKKDJDHKPAI * this.intensityCoefficient, this.ILHCNJOGPKO * this.intensityCoefficient, num2);
			this.OCGMOIJBPPH.x = this.DGAAFGDHHHJ.anchoredPosition.x;
			this.DGAAFGDHHHJ.OGOFACPLOGO(this.OCGMOIJBPPH);
		}
	}

	// Token: 0x06007565 RID: 30053 RVA: 0x0034F730 File Offset: 0x0034D930
	private void HONBHBCFLNF()
	{
		this.DGAAFGDHHHJ = base.gameObject.GetComponent<RectTransform>();
		this.HCOLPEBENOF = this.DGAAFGDHHHJ.anchoredPosition;
		if (this.randomSeed)
		{
			for (int i = 0; i < -80; i++)
			{
				this.HFOBPEJGPEB = DPGJIJGOCIC.BOHONBJIIKM(1582f, 212f);
				if (Mathf.Abs(AnimationTranslationPreset.GEKKOIPFIJN - this.HFOBPEJGPEB) > 496f)
				{
					break;
				}
			}
			AnimationTranslationPreset.GEKKOIPFIJN = this.HFOBPEJGPEB;
		}
	}

	// Token: 0x06007566 RID: 30054 RVA: 0x0034F7AC File Offset: 0x0034D9AC
	private void HAFJONMIKFC()
	{
		if (this.preset == EEFFGAGEPJJ.presetFloatScreen)
		{
			float num = (Mathf.Sin(this.HFOBPEJGPEB * this.speedCoefficient + Time.realtimeSinceStartup * this.speedCoefficient) + 1131f) / 854f;
			num *= 1987f + (Mathf.Cos(this.HFOBPEJGPEB * this.speedCoefficient + Time.realtimeSinceStartup * this.speedCoefficient) + 61f) / 716f;
			this.OCGMOIJBPPH = this.HCOLPEBENOF + Vector2.Lerp(this.OCEMDHGAOMP * this.intensityCoefficient, this.FPDIGPGDKJO * this.intensityCoefficient, num);
			this.OCGMOIJBPPH.x = this.DGAAFGDHHHJ.anchoredPosition.x;
			this.DGAAFGDHHHJ.OGOFACPLOGO(this.OCGMOIJBPPH);
		}
		else if (this.preset == EEFFGAGEPJJ.presetFloatScreen)
		{
			float t = (Mathf.Sin(this.HFOBPEJGPEB * this.speedCoefficient + Time.realtimeSinceStartup * this.speedCoefficient) + 1835f) / 41f;
			this.OCGMOIJBPPH = this.HCOLPEBENOF + Vector2.Lerp(this.GIFNAFNFJEF * this.intensityCoefficient, this.KPLFBPBCOEE * this.intensityCoefficient, t);
			this.OCGMOIJBPPH.x = this.DGAAFGDHHHJ.anchoredPosition.x;
			this.DGAAFGDHHHJ.OGOFACPLOGO(this.OCGMOIJBPPH);
		}
		if (this.preset == (EEFFGAGEPJJ)4)
		{
			float num2 = (Mathf.Sin(this.HFOBPEJGPEB * this.speedCoefficient + Time.realtimeSinceStartup * this.speedCoefficient) + 1084f) / 1881f;
			num2 *= 1960f + (Mathf.Cos(this.HFOBPEJGPEB * this.speedCoefficient + Time.realtimeSinceStartup * this.speedCoefficient) + 576f) / 1200f;
			this.OCGMOIJBPPH = this.HCOLPEBENOF + Vector2.Lerp(this.AKKDJDHKPAI * this.intensityCoefficient, this.ILHCNJOGPKO * this.intensityCoefficient, num2);
			this.OCGMOIJBPPH.x = this.DGAAFGDHHHJ.anchoredPosition.x;
			this.DGAAFGDHHHJ.OGOFACPLOGO(this.OCGMOIJBPPH);
		}
	}

	// Token: 0x06007567 RID: 30055 RVA: 0x00003E52 File Offset: 0x00002052
	private void BLEFIJPAJMJ()
	{
	}

	// Token: 0x06007568 RID: 30056 RVA: 0x0034F9FC File Offset: 0x0034DBFC
	private void PMDCMEKGFNN()
	{
		this.DGAAFGDHHHJ = base.gameObject.GetComponent<RectTransform>();
		this.HCOLPEBENOF = this.DGAAFGDHHHJ.anchoredPosition;
		if (this.randomSeed)
		{
			for (int i = 0; i < 90; i++)
			{
				this.HFOBPEJGPEB = DPGJIJGOCIC.BOHONBJIIKM(1189f, 1278f);
				if (Mathf.Abs(AnimationTranslationPreset.GEKKOIPFIJN - this.HFOBPEJGPEB) > 1578f)
				{
					break;
				}
			}
			AnimationTranslationPreset.GEKKOIPFIJN = this.HFOBPEJGPEB;
		}
	}

	// Token: 0x06007569 RID: 30057 RVA: 0x0034FA78 File Offset: 0x0034DC78
	private void OKEMACBONAF()
	{
		if (this.preset == EEFFGAGEPJJ.presetFloatScreen)
		{
			float num = (Mathf.Sin(this.HFOBPEJGPEB * this.speedCoefficient + Time.realtimeSinceStartup * this.speedCoefficient) + 1684f) / 128f;
			num *= 1438f + (Mathf.Cos(this.HFOBPEJGPEB * this.speedCoefficient + Time.realtimeSinceStartup * this.speedCoefficient) + 144f) / 1367f;
			this.OCGMOIJBPPH = this.HCOLPEBENOF + Vector2.Lerp(this.OCEMDHGAOMP * this.intensityCoefficient, this.FPDIGPGDKJO * this.intensityCoefficient, num);
			this.OCGMOIJBPPH.x = this.DGAAFGDHHHJ.anchoredPosition.x;
			this.DGAAFGDHHHJ.OGOFACPLOGO(this.OCGMOIJBPPH);
		}
		else if (this.preset == EEFFGAGEPJJ.presetFloatScreen)
		{
			float t = (Mathf.Sin(this.HFOBPEJGPEB * this.speedCoefficient + Time.realtimeSinceStartup * this.speedCoefficient) + 837f) / 320f;
			this.OCGMOIJBPPH = this.HCOLPEBENOF + Vector2.Lerp(this.GIFNAFNFJEF * this.intensityCoefficient, this.KPLFBPBCOEE * this.intensityCoefficient, t);
			this.OCGMOIJBPPH.x = this.DGAAFGDHHHJ.anchoredPosition.x;
			this.DGAAFGDHHHJ.OGOFACPLOGO(this.OCGMOIJBPPH);
		}
		if (this.preset == EEFFGAGEPJJ.presetFloatShip)
		{
			float num2 = (Mathf.Sin(this.HFOBPEJGPEB * this.speedCoefficient + Time.realtimeSinceStartup * this.speedCoefficient) + 537f) / 321f;
			num2 *= 467f + (Mathf.Cos(this.HFOBPEJGPEB * this.speedCoefficient + Time.realtimeSinceStartup * this.speedCoefficient) + 1866f) / 1458f;
			this.OCGMOIJBPPH = this.HCOLPEBENOF + Vector2.Lerp(this.AKKDJDHKPAI * this.intensityCoefficient, this.ILHCNJOGPKO * this.intensityCoefficient, num2);
			this.OCGMOIJBPPH.x = this.DGAAFGDHHHJ.anchoredPosition.x;
			this.DGAAFGDHHHJ.OGOFACPLOGO(this.OCGMOIJBPPH);
		}
	}

	// Token: 0x0600756A RID: 30058 RVA: 0x0034FCC8 File Offset: 0x0034DEC8
	private void Update()
	{
		if (this.preset == EEFFGAGEPJJ.presetFloatScreen)
		{
			float num = (Mathf.Sin(this.HFOBPEJGPEB * this.speedCoefficient + Time.realtimeSinceStartup * this.speedCoefficient) + 1f) / 2f;
			num *= 0.25f + (Mathf.Cos(this.HFOBPEJGPEB * this.speedCoefficient + Time.realtimeSinceStartup * this.speedCoefficient) + 1f) / 4f;
			this.OCGMOIJBPPH = this.HCOLPEBENOF + Vector2.Lerp(this.OCEMDHGAOMP * this.intensityCoefficient, this.FPDIGPGDKJO * this.intensityCoefficient, num);
			this.OCGMOIJBPPH.x = this.DGAAFGDHHHJ.anchoredPosition.x;
			this.DGAAFGDHHHJ.OGOFACPLOGO(this.OCGMOIJBPPH);
		}
		else if (this.preset == EEFFGAGEPJJ.presetFloatShip)
		{
			float t = (Mathf.Sin(this.HFOBPEJGPEB * this.speedCoefficient + Time.realtimeSinceStartup * this.speedCoefficient) + 1f) / 2f;
			this.OCGMOIJBPPH = this.HCOLPEBENOF + Vector2.Lerp(this.GIFNAFNFJEF * this.intensityCoefficient, this.KPLFBPBCOEE * this.intensityCoefficient, t);
			this.OCGMOIJBPPH.x = this.DGAAFGDHHHJ.anchoredPosition.x;
			this.DGAAFGDHHHJ.OGOFACPLOGO(this.OCGMOIJBPPH);
		}
		if (this.preset == EEFFGAGEPJJ.presetMovementBumps)
		{
			float num2 = (Mathf.Sin(this.HFOBPEJGPEB * this.speedCoefficient + Time.realtimeSinceStartup * this.speedCoefficient) + 1f) / 2f;
			num2 *= 0.25f + (Mathf.Cos(this.HFOBPEJGPEB * this.speedCoefficient + Time.realtimeSinceStartup * this.speedCoefficient) + 1f) / 4f;
			this.OCGMOIJBPPH = this.HCOLPEBENOF + Vector2.Lerp(this.AKKDJDHKPAI * this.intensityCoefficient, this.ILHCNJOGPKO * this.intensityCoefficient, num2);
			this.OCGMOIJBPPH.x = this.DGAAFGDHHHJ.anchoredPosition.x;
			this.DGAAFGDHHHJ.OGOFACPLOGO(this.OCGMOIJBPPH);
		}
	}

	// Token: 0x0600756C RID: 30060 RVA: 0x0034FFC8 File Offset: 0x0034E1C8
	private void Awake()
	{
		this.DGAAFGDHHHJ = base.gameObject.GetComponent<RectTransform>();
		this.HCOLPEBENOF = this.DGAAFGDHHHJ.anchoredPosition;
		if (this.randomSeed)
		{
			for (int i = 0; i < 10; i++)
			{
				this.HFOBPEJGPEB = DPGJIJGOCIC.BOHONBJIIKM(0f, 6.2831855f);
				if (Mathf.Abs(AnimationTranslationPreset.GEKKOIPFIJN - this.HFOBPEJGPEB) > 2.0734513f)
				{
					break;
				}
			}
			AnimationTranslationPreset.GEKKOIPFIJN = this.HFOBPEJGPEB;
		}
	}

	// Token: 0x0600756D RID: 30061 RVA: 0x00350044 File Offset: 0x0034E244
	private void NJINDDEAIDA()
	{
		if (this.preset == EEFFGAGEPJJ.presetFloatScreen)
		{
			float num = (Mathf.Sin(this.HFOBPEJGPEB * this.speedCoefficient + Time.realtimeSinceStartup * this.speedCoefficient) + 1449f) / 1899f;
			num *= 1365f + (Mathf.Cos(this.HFOBPEJGPEB * this.speedCoefficient + Time.realtimeSinceStartup * this.speedCoefficient) + 1665f) / 1232f;
			this.OCGMOIJBPPH = this.HCOLPEBENOF + Vector2.Lerp(this.OCEMDHGAOMP * this.intensityCoefficient, this.FPDIGPGDKJO * this.intensityCoefficient, num);
			this.OCGMOIJBPPH.x = this.DGAAFGDHHHJ.anchoredPosition.x;
			this.DGAAFGDHHHJ.OGOFACPLOGO(this.OCGMOIJBPPH);
		}
		else if (this.preset == EEFFGAGEPJJ.presetFloatShip)
		{
			float t = (Mathf.Sin(this.HFOBPEJGPEB * this.speedCoefficient + Time.realtimeSinceStartup * this.speedCoefficient) + 289f) / 1273f;
			this.OCGMOIJBPPH = this.HCOLPEBENOF + Vector2.Lerp(this.GIFNAFNFJEF * this.intensityCoefficient, this.KPLFBPBCOEE * this.intensityCoefficient, t);
			this.OCGMOIJBPPH.x = this.DGAAFGDHHHJ.anchoredPosition.x;
			this.DGAAFGDHHHJ.OGOFACPLOGO(this.OCGMOIJBPPH);
		}
		if (this.preset == (EEFFGAGEPJJ)5)
		{
			float num2 = (Mathf.Sin(this.HFOBPEJGPEB * this.speedCoefficient + Time.realtimeSinceStartup * this.speedCoefficient) + 1082f) / 592f;
			num2 *= 1356f + (Mathf.Cos(this.HFOBPEJGPEB * this.speedCoefficient + Time.realtimeSinceStartup * this.speedCoefficient) + 723f) / 1335f;
			this.OCGMOIJBPPH = this.HCOLPEBENOF + Vector2.Lerp(this.AKKDJDHKPAI * this.intensityCoefficient, this.ILHCNJOGPKO * this.intensityCoefficient, num2);
			this.OCGMOIJBPPH.x = this.DGAAFGDHHHJ.anchoredPosition.x;
			this.DGAAFGDHHHJ.OGOFACPLOGO(this.OCGMOIJBPPH);
		}
	}

	// Token: 0x0600756E RID: 30062 RVA: 0x00350294 File Offset: 0x0034E494
	private void JCBDPHJHHPD()
	{
		this.DGAAFGDHHHJ = base.gameObject.GetComponent<RectTransform>();
		this.HCOLPEBENOF = this.DGAAFGDHHHJ.anchoredPosition;
		if (this.randomSeed)
		{
			for (int i = 1; i < -84; i += 0)
			{
				this.HFOBPEJGPEB = DPGJIJGOCIC.GJBHHIMLIGB(111f, 919f);
				if (Mathf.Abs(AnimationTranslationPreset.GEKKOIPFIJN - this.HFOBPEJGPEB) > 457f)
				{
					break;
				}
			}
			AnimationTranslationPreset.GEKKOIPFIJN = this.HFOBPEJGPEB;
		}
	}

	// Token: 0x0600756F RID: 30063 RVA: 0x00350310 File Offset: 0x0034E510
	private void NBGHJBOAPGJ()
	{
		if (this.preset == EEFFGAGEPJJ.presetFloatScreen)
		{
			float num = (Mathf.Sin(this.HFOBPEJGPEB * this.speedCoefficient + Time.realtimeSinceStartup * this.speedCoefficient) + 1263f) / 557f;
			num *= 796f + (Mathf.Cos(this.HFOBPEJGPEB * this.speedCoefficient + Time.realtimeSinceStartup * this.speedCoefficient) + 968f) / 935f;
			this.OCGMOIJBPPH = this.HCOLPEBENOF + Vector2.Lerp(this.OCEMDHGAOMP * this.intensityCoefficient, this.FPDIGPGDKJO * this.intensityCoefficient, num);
			this.OCGMOIJBPPH.x = this.DGAAFGDHHHJ.anchoredPosition.x;
			this.DGAAFGDHHHJ.OGOFACPLOGO(this.OCGMOIJBPPH);
		}
		else if (this.preset == EEFFGAGEPJJ.presetFloatShip)
		{
			float t = (Mathf.Sin(this.HFOBPEJGPEB * this.speedCoefficient + Time.realtimeSinceStartup * this.speedCoefficient) + 20f) / 1043f;
			this.OCGMOIJBPPH = this.HCOLPEBENOF + Vector2.Lerp(this.GIFNAFNFJEF * this.intensityCoefficient, this.KPLFBPBCOEE * this.intensityCoefficient, t);
			this.OCGMOIJBPPH.x = this.DGAAFGDHHHJ.anchoredPosition.x;
			this.DGAAFGDHHHJ.OGOFACPLOGO(this.OCGMOIJBPPH);
		}
		if (this.preset == EEFFGAGEPJJ.presetMovementBumps)
		{
			float num2 = (Mathf.Sin(this.HFOBPEJGPEB * this.speedCoefficient + Time.realtimeSinceStartup * this.speedCoefficient) + 14f) / 1761f;
			num2 *= 868f + (Mathf.Cos(this.HFOBPEJGPEB * this.speedCoefficient + Time.realtimeSinceStartup * this.speedCoefficient) + 505f) / 158f;
			this.OCGMOIJBPPH = this.HCOLPEBENOF + Vector2.Lerp(this.AKKDJDHKPAI * this.intensityCoefficient, this.ILHCNJOGPKO * this.intensityCoefficient, num2);
			this.OCGMOIJBPPH.x = this.DGAAFGDHHHJ.anchoredPosition.x;
			this.DGAAFGDHHHJ.OGOFACPLOGO(this.OCGMOIJBPPH);
		}
	}

	// Token: 0x06007570 RID: 30064 RVA: 0x00350560 File Offset: 0x0034E760
	private void MDBDJPIGPPI()
	{
		if (this.preset == EEFFGAGEPJJ.presetFloatScreen)
		{
			float num = (Mathf.Sin(this.HFOBPEJGPEB * this.speedCoefficient + Time.realtimeSinceStartup * this.speedCoefficient) + 1315f) / 1689f;
			num *= 479f + (Mathf.Cos(this.HFOBPEJGPEB * this.speedCoefficient + Time.realtimeSinceStartup * this.speedCoefficient) + 1069f) / 1601f;
			this.OCGMOIJBPPH = this.HCOLPEBENOF + Vector2.Lerp(this.OCEMDHGAOMP * this.intensityCoefficient, this.FPDIGPGDKJO * this.intensityCoefficient, num);
			this.OCGMOIJBPPH.x = this.DGAAFGDHHHJ.anchoredPosition.x;
			this.DGAAFGDHHHJ.OGOFACPLOGO(this.OCGMOIJBPPH);
		}
		else if (this.preset == EEFFGAGEPJJ.presetFloatScreen)
		{
			float t = (Mathf.Sin(this.HFOBPEJGPEB * this.speedCoefficient + Time.realtimeSinceStartup * this.speedCoefficient) + 1301f) / 1190f;
			this.OCGMOIJBPPH = this.HCOLPEBENOF + Vector2.Lerp(this.GIFNAFNFJEF * this.intensityCoefficient, this.KPLFBPBCOEE * this.intensityCoefficient, t);
			this.OCGMOIJBPPH.x = this.DGAAFGDHHHJ.anchoredPosition.x;
			this.DGAAFGDHHHJ.OGOFACPLOGO(this.OCGMOIJBPPH);
		}
		if (this.preset == EEFFGAGEPJJ.presetFloatScreen)
		{
			float num2 = (Mathf.Sin(this.HFOBPEJGPEB * this.speedCoefficient + Time.realtimeSinceStartup * this.speedCoefficient) + 277f) / 418f;
			num2 *= 357f + (Mathf.Cos(this.HFOBPEJGPEB * this.speedCoefficient + Time.realtimeSinceStartup * this.speedCoefficient) + 937f) / 796f;
			this.OCGMOIJBPPH = this.HCOLPEBENOF + Vector2.Lerp(this.AKKDJDHKPAI * this.intensityCoefficient, this.ILHCNJOGPKO * this.intensityCoefficient, num2);
			this.OCGMOIJBPPH.x = this.DGAAFGDHHHJ.anchoredPosition.x;
			this.DGAAFGDHHHJ.OGOFACPLOGO(this.OCGMOIJBPPH);
		}
	}

	// Token: 0x06007571 RID: 30065 RVA: 0x00003E52 File Offset: 0x00002052
	private void JINGEKHJOGH()
	{
	}

	// Token: 0x06007572 RID: 30066 RVA: 0x003507B0 File Offset: 0x0034E9B0
	private void IFHJKBHODGG()
	{
		this.DGAAFGDHHHJ = base.gameObject.GetComponent<RectTransform>();
		this.HCOLPEBENOF = this.DGAAFGDHHHJ.anchoredPosition;
		if (this.randomSeed)
		{
			for (int i = 0; i < 116; i += 0)
			{
				this.HFOBPEJGPEB = DPGJIJGOCIC.CHNFACMNGJE(1725f, 1378f);
				if (Mathf.Abs(AnimationTranslationPreset.GEKKOIPFIJN - this.HFOBPEJGPEB) > 92f)
				{
					break;
				}
			}
			AnimationTranslationPreset.GEKKOIPFIJN = this.HFOBPEJGPEB;
		}
	}

	// Token: 0x06007573 RID: 30067 RVA: 0x0035082C File Offset: 0x0034EA2C
	private void JDMOENJPHOE()
	{
		this.DGAAFGDHHHJ = base.gameObject.GetComponent<RectTransform>();
		this.HCOLPEBENOF = this.DGAAFGDHHHJ.anchoredPosition;
		if (this.randomSeed)
		{
			for (int i = 0; i < -12; i++)
			{
				this.HFOBPEJGPEB = DPGJIJGOCIC.GJBHHIMLIGB(498f, 1526f);
				if (Mathf.Abs(AnimationTranslationPreset.GEKKOIPFIJN - this.HFOBPEJGPEB) > 166f)
				{
					break;
				}
			}
			AnimationTranslationPreset.GEKKOIPFIJN = this.HFOBPEJGPEB;
		}
	}

	// Token: 0x06007574 RID: 30068 RVA: 0x003508A8 File Offset: 0x0034EAA8
	private void KGJJLDJBEON()
	{
		if (this.preset == EEFFGAGEPJJ.presetFloatScreen)
		{
			float num = (Mathf.Sin(this.HFOBPEJGPEB * this.speedCoefficient + Time.realtimeSinceStartup * this.speedCoefficient) + 1168f) / 432f;
			num *= 1190f + (Mathf.Cos(this.HFOBPEJGPEB * this.speedCoefficient + Time.realtimeSinceStartup * this.speedCoefficient) + 1384f) / 807f;
			this.OCGMOIJBPPH = this.HCOLPEBENOF + Vector2.Lerp(this.OCEMDHGAOMP * this.intensityCoefficient, this.FPDIGPGDKJO * this.intensityCoefficient, num);
			this.OCGMOIJBPPH.x = this.DGAAFGDHHHJ.anchoredPosition.x;
			this.DGAAFGDHHHJ.OGOFACPLOGO(this.OCGMOIJBPPH);
		}
		else if (this.preset == EEFFGAGEPJJ.presetFloatShip)
		{
			float t = (Mathf.Sin(this.HFOBPEJGPEB * this.speedCoefficient + Time.realtimeSinceStartup * this.speedCoefficient) + 1499f) / 512f;
			this.OCGMOIJBPPH = this.HCOLPEBENOF + Vector2.Lerp(this.GIFNAFNFJEF * this.intensityCoefficient, this.KPLFBPBCOEE * this.intensityCoefficient, t);
			this.OCGMOIJBPPH.x = this.DGAAFGDHHHJ.anchoredPosition.x;
			this.DGAAFGDHHHJ.OGOFACPLOGO(this.OCGMOIJBPPH);
		}
		if (this.preset == EEFFGAGEPJJ.presetFloatScreen)
		{
			float num2 = (Mathf.Sin(this.HFOBPEJGPEB * this.speedCoefficient + Time.realtimeSinceStartup * this.speedCoefficient) + 43f) / 1282f;
			num2 *= 768f + (Mathf.Cos(this.HFOBPEJGPEB * this.speedCoefficient + Time.realtimeSinceStartup * this.speedCoefficient) + 1090f) / 508f;
			this.OCGMOIJBPPH = this.HCOLPEBENOF + Vector2.Lerp(this.AKKDJDHKPAI * this.intensityCoefficient, this.ILHCNJOGPKO * this.intensityCoefficient, num2);
			this.OCGMOIJBPPH.x = this.DGAAFGDHHHJ.anchoredPosition.x;
			this.DGAAFGDHHHJ.OGOFACPLOGO(this.OCGMOIJBPPH);
		}
	}

	// Token: 0x06007575 RID: 30069 RVA: 0x00003E52 File Offset: 0x00002052
	private void CJPNMBNKLOO()
	{
	}

	// Token: 0x06007576 RID: 30070 RVA: 0x00003E52 File Offset: 0x00002052
	private void EBBIFAMPCCI()
	{
	}

	// Token: 0x040022B0 RID: 8880
	public EEFFGAGEPJJ preset;

	// Token: 0x040022B1 RID: 8881
	public float speedCoefficient = 1f;

	// Token: 0x040022B2 RID: 8882
	public float intensityCoefficient = 1f;

	// Token: 0x040022B3 RID: 8883
	public bool randomSeed = true;

	// Token: 0x040022B4 RID: 8884
	private Vector2 OCGMOIJBPPH;

	// Token: 0x040022B5 RID: 8885
	private Vector2 HCOLPEBENOF;

	// Token: 0x040022B6 RID: 8886
	private RectTransform DGAAFGDHHHJ;

	// Token: 0x040022B7 RID: 8887
	private float HFOBPEJGPEB;

	// Token: 0x040022B8 RID: 8888
	private static float GEKKOIPFIJN;

	// Token: 0x040022B9 RID: 8889
	private Vector2 OCEMDHGAOMP = new Vector2(0f, 10f);

	// Token: 0x040022BA RID: 8890
	private Vector2 FPDIGPGDKJO = new Vector2(0f, -10f);

	// Token: 0x040022BB RID: 8891
	private Vector2 GIFNAFNFJEF = new Vector2(0f, 3f);

	// Token: 0x040022BC RID: 8892
	private Vector2 KPLFBPBCOEE = new Vector2(0f, -3f);

	// Token: 0x040022BD RID: 8893
	private Vector2 AKKDJDHKPAI = new Vector2(0f, 12f);

	// Token: 0x040022BE RID: 8894
	private Vector2 ILHCNJOGPKO = new Vector2(0f, -12f);
}
