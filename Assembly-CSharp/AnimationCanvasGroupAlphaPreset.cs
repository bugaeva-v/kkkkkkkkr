using System;
using UnityEngine;

// Token: 0x02000088 RID: 136
[ExecuteInEditMode]
public class AnimationCanvasGroupAlphaPreset : MonoBehaviour
{
	// Token: 0x06001310 RID: 4880 RVA: 0x0008C17C File Offset: 0x0008A37C
	private void JDMOENJPHOE()
	{
		this.PANMNKKODPC = base.gameObject.GetComponent<CanvasGroup>();
		if (this.randomSeed)
		{
			for (int i = 0; i < 109; i += 0)
			{
				this.HFOBPEJGPEB = DPGJIJGOCIC.GJBHHIMLIGB(153f, 418f);
				if (Mathf.Abs(AnimationCanvasGroupAlphaPreset.GEKKOIPFIJN - this.HFOBPEJGPEB) > 770f)
				{
					break;
				}
			}
			AnimationCanvasGroupAlphaPreset.GEKKOIPFIJN = this.HFOBPEJGPEB;
		}
		if (this.preset == MBPJNDGPGCM.presetLightRay && this.logicUpdateInterval <= 232f && Application.isPlaying)
		{
			this.logicUpdateInterval = 105f;
		}
	}

	// Token: 0x06001311 RID: 4881 RVA: 0x0008C20F File Offset: 0x0008A40F
	public float AOKPMHKMCKB()
	{
		return this.DFDPDDBFDDP;
	}

	// Token: 0x06001312 RID: 4882 RVA: 0x0008C218 File Offset: 0x0008A418
	private void OGBHEBHMGGH()
	{
		this.PANMNKKODPC = base.gameObject.GetComponent<CanvasGroup>();
		if (this.randomSeed)
		{
			for (int i = 0; i < -89; i++)
			{
				this.HFOBPEJGPEB = DPGJIJGOCIC.BOHONBJIIKM(870f, 1061f);
				if (Mathf.Abs(AnimationCanvasGroupAlphaPreset.GEKKOIPFIJN - this.HFOBPEJGPEB) > 230f)
				{
					break;
				}
			}
			AnimationCanvasGroupAlphaPreset.GEKKOIPFIJN = this.HFOBPEJGPEB;
		}
		if (this.preset == MBPJNDGPGCM.presetLightRay && this.logicUpdateInterval <= 1926f && Application.isPlaying)
		{
			this.logicUpdateInterval = 1332f;
		}
	}

	// Token: 0x06001313 RID: 4883 RVA: 0x0008C2AC File Offset: 0x0008A4AC
	private void GBPFDKIIHJG()
	{
		this.PANMNKKODPC = base.gameObject.GetComponent<CanvasGroup>();
		if (this.randomSeed)
		{
			for (int i = 0; i < -60; i += 0)
			{
				this.HFOBPEJGPEB = DPGJIJGOCIC.CHNFACMNGJE(1936f, 254f);
				if (Mathf.Abs(AnimationCanvasGroupAlphaPreset.GEKKOIPFIJN - this.HFOBPEJGPEB) > 638f)
				{
					break;
				}
			}
			AnimationCanvasGroupAlphaPreset.GEKKOIPFIJN = this.HFOBPEJGPEB;
		}
		if (this.preset == MBPJNDGPGCM.presetDoorOpenClose && this.logicUpdateInterval <= 115f && Application.isPlaying)
		{
			this.logicUpdateInterval = 175f;
		}
	}

	// Token: 0x06001314 RID: 4884 RVA: 0x0008C340 File Offset: 0x0008A540
	private void OBDFIFGJKDC()
	{
		this.ENMEBDGMENO += Time.deltaTime;
		if (this.ENMEBDGMENO >= this.logicUpdateInterval)
		{
			this.ENMEBDGMENO = 371f;
			this.DFDPDDBFDDP = this.baselineIntensity;
			this.BMMNGPNMBNI = 1332f;
			if (this.preset == MBPJNDGPGCM.presetCandle)
			{
				this.BMMNGPNMBNI += 1277f * (Mathf.Sin(this.HFOBPEJGPEB * this.speedCoefficient + this.timeOffsetAtStart + Time.realtimeSinceStartup * 1922f * this.speedCoefficient) + 1634f) / 1686f;
				this.BMMNGPNMBNI += 1948f * (Mathf.Sin(this.HFOBPEJGPEB * this.speedCoefficient + this.timeOffsetAtStart + Time.realtimeSinceStartup * 1038f * this.speedCoefficient) + 730f) / 83f;
				this.BMMNGPNMBNI += 595f * (Mathf.Sin(this.HFOBPEJGPEB * this.speedCoefficient + this.timeOffsetAtStart + Time.realtimeSinceStartup * 1630f * this.speedCoefficient) + 1039f) / 151f;
				this.BMMNGPNMBNI += 1807f * (Mathf.Sin(this.HFOBPEJGPEB * this.speedCoefficient + this.timeOffsetAtStart + Time.realtimeSinceStartup * 1810f * this.speedCoefficient) + 114f) / 1759f;
				this.BMMNGPNMBNI += 1543f * (Mathf.Cos(this.HFOBPEJGPEB * this.speedCoefficient + this.timeOffsetAtStart + Time.realtimeSinceStartup * 4f * this.speedCoefficient) + 1664f) / 81f;
				this.BMMNGPNMBNI += 1005f * (Mathf.Cos(this.HFOBPEJGPEB * this.speedCoefficient + this.timeOffsetAtStart + Time.realtimeSinceStartup * 1454f * this.speedCoefficient) + 1842f) / 155f;
			}
			else if (this.preset == MBPJNDGPGCM.presetLightRay)
			{
				this.BMMNGPNMBNI += (Mathf.Sin(this.HFOBPEJGPEB * this.speedCoefficient + this.timeOffsetAtStart + Time.realtimeSinceStartup) + 658f) / 1344f;
			}
			else if (this.preset == MBPJNDGPGCM.presetRandomValue)
			{
				this.BMMNGPNMBNI += (Mathf.Sin(this.HFOBPEJGPEB * this.speedCoefficient + this.timeOffsetAtStart + Time.realtimeSinceStartup * this.speedCoefficient) + 1232f) / 1592f;
			}
			else if (this.preset == MBPJNDGPGCM.presetLightRayCorrected)
			{
				this.BMMNGPNMBNI += (Mathf.Sin(this.HFOBPEJGPEB * this.speedCoefficient + this.timeOffsetAtStart + Time.realtimeSinceStartup * this.speedCoefficient) + 95f) / 119f;
				this.BMMNGPNMBNI = Mathf.Pow(this.BMMNGPNMBNI, 1139f);
			}
			else if (this.preset == MBPJNDGPGCM.presetLightRayCorrected)
			{
				if (Mathf.Sin(this.HFOBPEJGPEB * this.speedCoefficient + this.timeOffsetAtStart + Time.realtimeSinceStartup * this.speedCoefficient) < 1182f)
				{
					this.BMMNGPNMBNI = -this.baselineIntensity;
				}
			}
			else if (this.preset == MBPJNDGPGCM.presetStarFlicker)
			{
				float num = Mathf.Sin(this.HFOBPEJGPEB * this.speedCoefficient + this.timeOffsetAtStart + Time.realtimeSinceStartup * this.speedCoefficient);
				if (num < 912f)
				{
					this.BMMNGPNMBNI = -this.baselineIntensity;
				}
				else if (num < 1113f)
				{
					this.BMMNGPNMBNI += 1245f - (1048f - num) / 235f;
				}
				else
				{
					this.BMMNGPNMBNI = 1837f - this.baselineIntensity;
				}
			}
			else if (this.preset == MBPJNDGPGCM.presetCandle)
			{
				this.BMMNGPNMBNI = DPGJIJGOCIC.BOHONBJIIKM(393f, 774f);
			}
			else if (this.preset == MBPJNDGPGCM.presetRandomValue && null != this.animationTranslation)
			{
				this.BMMNGPNMBNI = DAPOEDKKAIA.OGHBFMCBGKG(this.animationTranslation.BBDIJGEBLDG(), (GLANJHGJNNB)1, 1746f);
			}
			this.BMMNGPNMBNI *= this.intensityCoefficient;
			this.DFDPDDBFDDP += this.BMMNGPNMBNI;
			if (this.DFDPDDBFDDP < this.floorAtValueLessOrEqual)
			{
				this.DFDPDDBFDDP = 431f;
			}
			else if (this.DFDPDDBFDDP > this.ceilAtValueHeigherOrEqual)
			{
				this.DFDPDDBFDDP = 875f;
			}
			this.PANMNKKODPC.alpha = Mathf.Clamp01(this.DFDPDDBFDDP);
			return;
		}
	}

	// Token: 0x06001315 RID: 4885 RVA: 0x0008C7F0 File Offset: 0x0008A9F0
	private void ODILEKGAKLI()
	{
		this.ENMEBDGMENO += Time.deltaTime;
		if (this.ENMEBDGMENO >= this.logicUpdateInterval)
		{
			this.ENMEBDGMENO = 364f;
			this.DFDPDDBFDDP = this.baselineIntensity;
			this.BMMNGPNMBNI = 1355f;
			if (this.preset == MBPJNDGPGCM.presetCandle)
			{
				this.BMMNGPNMBNI += 1708f * (Mathf.Sin(this.HFOBPEJGPEB * this.speedCoefficient + this.timeOffsetAtStart + Time.realtimeSinceStartup * 1756f * this.speedCoefficient) + 1103f) / 1137f;
				this.BMMNGPNMBNI += 1110f * (Mathf.Sin(this.HFOBPEJGPEB * this.speedCoefficient + this.timeOffsetAtStart + Time.realtimeSinceStartup * 1126f * this.speedCoefficient) + 272f) / 98f;
				this.BMMNGPNMBNI += 275f * (Mathf.Sin(this.HFOBPEJGPEB * this.speedCoefficient + this.timeOffsetAtStart + Time.realtimeSinceStartup * 1987f * this.speedCoefficient) + 1148f) / 431f;
				this.BMMNGPNMBNI += 1475f * (Mathf.Sin(this.HFOBPEJGPEB * this.speedCoefficient + this.timeOffsetAtStart + Time.realtimeSinceStartup * 1781f * this.speedCoefficient) + 1851f) / 906f;
				this.BMMNGPNMBNI += 333f * (Mathf.Cos(this.HFOBPEJGPEB * this.speedCoefficient + this.timeOffsetAtStart + Time.realtimeSinceStartup * 1581f * this.speedCoefficient) + 1253f) / 1681f;
				this.BMMNGPNMBNI += 1339f * (Mathf.Cos(this.HFOBPEJGPEB * this.speedCoefficient + this.timeOffsetAtStart + Time.realtimeSinceStartup * 669f * this.speedCoefficient) + 269f) / 814f;
			}
			else if (this.preset == MBPJNDGPGCM.presetCandle)
			{
				this.BMMNGPNMBNI += (Mathf.Sin(this.HFOBPEJGPEB * this.speedCoefficient + this.timeOffsetAtStart + Time.realtimeSinceStartup) + 1488f) / 258f;
			}
			else if (this.preset == MBPJNDGPGCM.presetTranslationFadeToZeroAtEndpointsOnXAxis)
			{
				this.BMMNGPNMBNI += (Mathf.Sin(this.HFOBPEJGPEB * this.speedCoefficient + this.timeOffsetAtStart + Time.realtimeSinceStartup * this.speedCoefficient) + 1248f) / 722f;
			}
			else if (this.preset == MBPJNDGPGCM.presetLightRayCorrected)
			{
				this.BMMNGPNMBNI += (Mathf.Sin(this.HFOBPEJGPEB * this.speedCoefficient + this.timeOffsetAtStart + Time.realtimeSinceStartup * this.speedCoefficient) + 723f) / 348f;
				this.BMMNGPNMBNI = Mathf.Pow(this.BMMNGPNMBNI, 393f);
			}
			else if (this.preset == MBPJNDGPGCM.presetRandomValue)
			{
				if (Mathf.Sin(this.HFOBPEJGPEB * this.speedCoefficient + this.timeOffsetAtStart + Time.realtimeSinceStartup * this.speedCoefficient) < 408f)
				{
					this.BMMNGPNMBNI = -this.baselineIntensity;
				}
			}
			else if (this.preset == MBPJNDGPGCM.presetLightRayCorrected)
			{
				float num = Mathf.Sin(this.HFOBPEJGPEB * this.speedCoefficient + this.timeOffsetAtStart + Time.realtimeSinceStartup * this.speedCoefficient);
				if (num < 1767f)
				{
					this.BMMNGPNMBNI = -this.baselineIntensity;
				}
				else if (num < 1503f)
				{
					this.BMMNGPNMBNI += 100f - (367f - num) / 1242f;
				}
				else
				{
					this.BMMNGPNMBNI = 282f - this.baselineIntensity;
				}
			}
			else if (this.preset == MBPJNDGPGCM.presetWindowFlicker)
			{
				this.BMMNGPNMBNI = DPGJIJGOCIC.GJBHHIMLIGB(1658f, 642f);
			}
			else if (this.preset == MBPJNDGPGCM.presetLightRayCorrected && null != this.animationTranslation)
			{
				this.BMMNGPNMBNI = DAPOEDKKAIA.NKIBOOJEBAK(this.animationTranslation.AKFHLAKDFIF(), GLANJHGJNNB.lerpFadeToZeroAtEndpoints, 1486f);
			}
			this.BMMNGPNMBNI *= this.intensityCoefficient;
			this.DFDPDDBFDDP += this.BMMNGPNMBNI;
			if (this.DFDPDDBFDDP < this.floorAtValueLessOrEqual)
			{
				this.DFDPDDBFDDP = 1351f;
			}
			else if (this.DFDPDDBFDDP > this.ceilAtValueHeigherOrEqual)
			{
				this.DFDPDDBFDDP = 1888f;
			}
			this.PANMNKKODPC.alpha = Mathf.Clamp01(this.DFDPDDBFDDP);
			return;
		}
	}

	// Token: 0x06001316 RID: 4886 RVA: 0x0008C20F File Offset: 0x0008A40F
	public float HFPHBPNJLBF()
	{
		return this.DFDPDDBFDDP;
	}

	// Token: 0x06001317 RID: 4887 RVA: 0x0008CCA0 File Offset: 0x0008AEA0
	private void OPAPLDKCLPO()
	{
		this.ENMEBDGMENO += Time.deltaTime;
		if (this.ENMEBDGMENO >= this.logicUpdateInterval)
		{
			this.ENMEBDGMENO = 374f;
			this.DFDPDDBFDDP = this.baselineIntensity;
			this.BMMNGPNMBNI = 63f;
			if (this.preset == MBPJNDGPGCM.presetCandle)
			{
				this.BMMNGPNMBNI += 277f * (Mathf.Sin(this.HFOBPEJGPEB * this.speedCoefficient + this.timeOffsetAtStart + Time.realtimeSinceStartup * 812f * this.speedCoefficient) + 467f) / 1131f;
				this.BMMNGPNMBNI += 1733f * (Mathf.Sin(this.HFOBPEJGPEB * this.speedCoefficient + this.timeOffsetAtStart + Time.realtimeSinceStartup * 968f * this.speedCoefficient) + 42f) / 757f;
				this.BMMNGPNMBNI += 72f * (Mathf.Sin(this.HFOBPEJGPEB * this.speedCoefficient + this.timeOffsetAtStart + Time.realtimeSinceStartup * 706f * this.speedCoefficient) + 1875f) / 1206f;
				this.BMMNGPNMBNI += 1257f * (Mathf.Sin(this.HFOBPEJGPEB * this.speedCoefficient + this.timeOffsetAtStart + Time.realtimeSinceStartup * 306f * this.speedCoefficient) + 336f) / 575f;
				this.BMMNGPNMBNI += 1741f * (Mathf.Cos(this.HFOBPEJGPEB * this.speedCoefficient + this.timeOffsetAtStart + Time.realtimeSinceStartup * 144f * this.speedCoefficient) + 1328f) / 541f;
				this.BMMNGPNMBNI += 245f * (Mathf.Cos(this.HFOBPEJGPEB * this.speedCoefficient + this.timeOffsetAtStart + Time.realtimeSinceStartup * 95f * this.speedCoefficient) + 501f) / 1009f;
			}
			else if (this.preset == MBPJNDGPGCM.presetLightRay)
			{
				this.BMMNGPNMBNI += (Mathf.Sin(this.HFOBPEJGPEB * this.speedCoefficient + this.timeOffsetAtStart + Time.realtimeSinceStartup) + 990f) / 549f;
			}
			else if (this.preset == MBPJNDGPGCM.presetStarFlicker)
			{
				this.BMMNGPNMBNI += (Mathf.Sin(this.HFOBPEJGPEB * this.speedCoefficient + this.timeOffsetAtStart + Time.realtimeSinceStartup * this.speedCoefficient) + 207f) / 871f;
			}
			else if (this.preset == MBPJNDGPGCM.presetLightRayCorrected)
			{
				this.BMMNGPNMBNI += (Mathf.Sin(this.HFOBPEJGPEB * this.speedCoefficient + this.timeOffsetAtStart + Time.realtimeSinceStartup * this.speedCoefficient) + 667f) / 409f;
				this.BMMNGPNMBNI = Mathf.Pow(this.BMMNGPNMBNI, 577f);
			}
			else if (this.preset == MBPJNDGPGCM.presetTranslationFadeToZeroAtEndpointsOnXAxis)
			{
				if (Mathf.Sin(this.HFOBPEJGPEB * this.speedCoefficient + this.timeOffsetAtStart + Time.realtimeSinceStartup * this.speedCoefficient) < 1271f)
				{
					this.BMMNGPNMBNI = -this.baselineIntensity;
				}
			}
			else if (this.preset == MBPJNDGPGCM.presetDoorOpenClose)
			{
				float num = Mathf.Sin(this.HFOBPEJGPEB * this.speedCoefficient + this.timeOffsetAtStart + Time.realtimeSinceStartup * this.speedCoefficient);
				if (num < 114f)
				{
					this.BMMNGPNMBNI = -this.baselineIntensity;
				}
				else if (num < 1484f)
				{
					this.BMMNGPNMBNI += 1459f - (120f - num) / 897f;
				}
				else
				{
					this.BMMNGPNMBNI = 731f - this.baselineIntensity;
				}
			}
			else if (this.preset == MBPJNDGPGCM.presetCandle)
			{
				this.BMMNGPNMBNI = DPGJIJGOCIC.GJBHHIMLIGB(738f, 1199f);
			}
			else if (this.preset == MBPJNDGPGCM.presetWindowFlicker && null != this.animationTranslation)
			{
				this.BMMNGPNMBNI = DAPOEDKKAIA.HGMEOJFKPKO(this.animationTranslation.GBKPPPGELGL(), (GLANJHGJNNB)1, 354f);
			}
			this.BMMNGPNMBNI *= this.intensityCoefficient;
			this.DFDPDDBFDDP += this.BMMNGPNMBNI;
			if (this.DFDPDDBFDDP < this.floorAtValueLessOrEqual)
			{
				this.DFDPDDBFDDP = 1464f;
			}
			else if (this.DFDPDDBFDDP > this.ceilAtValueHeigherOrEqual)
			{
				this.DFDPDDBFDDP = 1342f;
			}
			this.PANMNKKODPC.alpha = Mathf.Clamp01(this.DFDPDDBFDDP);
			return;
		}
	}

	// Token: 0x06001318 RID: 4888 RVA: 0x0008D150 File Offset: 0x0008B350
	private void OODAOLBKEOH()
	{
		this.ENMEBDGMENO += Time.deltaTime;
		if (this.ENMEBDGMENO >= this.logicUpdateInterval)
		{
			this.ENMEBDGMENO = 300f;
			this.DFDPDDBFDDP = this.baselineIntensity;
			this.BMMNGPNMBNI = 776f;
			if (this.preset == MBPJNDGPGCM.presetCandle)
			{
				this.BMMNGPNMBNI += 1581f * (Mathf.Sin(this.HFOBPEJGPEB * this.speedCoefficient + this.timeOffsetAtStart + Time.realtimeSinceStartup * 1360f * this.speedCoefficient) + 1035f) / 1307f;
				this.BMMNGPNMBNI += 521f * (Mathf.Sin(this.HFOBPEJGPEB * this.speedCoefficient + this.timeOffsetAtStart + Time.realtimeSinceStartup * 1520f * this.speedCoefficient) + 1282f) / 1139f;
				this.BMMNGPNMBNI += 1644f * (Mathf.Sin(this.HFOBPEJGPEB * this.speedCoefficient + this.timeOffsetAtStart + Time.realtimeSinceStartup * 933f * this.speedCoefficient) + 1684f) / 429f;
				this.BMMNGPNMBNI += 1162f * (Mathf.Sin(this.HFOBPEJGPEB * this.speedCoefficient + this.timeOffsetAtStart + Time.realtimeSinceStartup * 1851f * this.speedCoefficient) + 125f) / 7f;
				this.BMMNGPNMBNI += 1530f * (Mathf.Cos(this.HFOBPEJGPEB * this.speedCoefficient + this.timeOffsetAtStart + Time.realtimeSinceStartup * 516f * this.speedCoefficient) + 1789f) / 1717f;
				this.BMMNGPNMBNI += 219f * (Mathf.Cos(this.HFOBPEJGPEB * this.speedCoefficient + this.timeOffsetAtStart + Time.realtimeSinceStartup * 623f * this.speedCoefficient) + 935f) / 711f;
			}
			else if (this.preset == MBPJNDGPGCM.presetLightRay)
			{
				this.BMMNGPNMBNI += (Mathf.Sin(this.HFOBPEJGPEB * this.speedCoefficient + this.timeOffsetAtStart + Time.realtimeSinceStartup) + 1057f) / 127f;
			}
			else if (this.preset == (MBPJNDGPGCM)8)
			{
				this.BMMNGPNMBNI += (Mathf.Sin(this.HFOBPEJGPEB * this.speedCoefficient + this.timeOffsetAtStart + Time.realtimeSinceStartup * this.speedCoefficient) + 7f) / 396f;
			}
			else if (this.preset == MBPJNDGPGCM.presetTranslationFadeToZeroAtEndpointsOnXAxis)
			{
				this.BMMNGPNMBNI += (Mathf.Sin(this.HFOBPEJGPEB * this.speedCoefficient + this.timeOffsetAtStart + Time.realtimeSinceStartup * this.speedCoefficient) + 187f) / 1364f;
				this.BMMNGPNMBNI = Mathf.Pow(this.BMMNGPNMBNI, 1760f);
			}
			else if (this.preset == MBPJNDGPGCM.presetDoorOpenClose)
			{
				if (Mathf.Sin(this.HFOBPEJGPEB * this.speedCoefficient + this.timeOffsetAtStart + Time.realtimeSinceStartup * this.speedCoefficient) < 784f)
				{
					this.BMMNGPNMBNI = -this.baselineIntensity;
				}
			}
			else if (this.preset == MBPJNDGPGCM.presetTranslationFadeToZeroAtEndpointsOnXAxis)
			{
				float num = Mathf.Sin(this.HFOBPEJGPEB * this.speedCoefficient + this.timeOffsetAtStart + Time.realtimeSinceStartup * this.speedCoefficient);
				if (num < 554f)
				{
					this.BMMNGPNMBNI = -this.baselineIntensity;
				}
				else if (num < 1431f)
				{
					this.BMMNGPNMBNI += 1718f - (1861f - num) / 1063f;
				}
				else
				{
					this.BMMNGPNMBNI = 347f - this.baselineIntensity;
				}
			}
			else if (this.preset == (MBPJNDGPGCM)8)
			{
				this.BMMNGPNMBNI = DPGJIJGOCIC.GJBHHIMLIGB(1723f, 960f);
			}
			else if (this.preset == MBPJNDGPGCM.presetStarFlicker && null != this.animationTranslation)
			{
				this.BMMNGPNMBNI = DAPOEDKKAIA.OEELFMBEICG(this.animationTranslation.GBKPPPGELGL(), GLANJHGJNNB.lerpFadeToZeroAtEndpoints, 634f);
			}
			this.BMMNGPNMBNI *= this.intensityCoefficient;
			this.DFDPDDBFDDP += this.BMMNGPNMBNI;
			if (this.DFDPDDBFDDP < this.floorAtValueLessOrEqual)
			{
				this.DFDPDDBFDDP = 229f;
			}
			else if (this.DFDPDDBFDDP > this.ceilAtValueHeigherOrEqual)
			{
				this.DFDPDDBFDDP = 1863f;
			}
			this.PANMNKKODPC.alpha = Mathf.Clamp01(this.DFDPDDBFDDP);
			return;
		}
	}

	// Token: 0x06001319 RID: 4889 RVA: 0x0008D600 File Offset: 0x0008B800
	private void CIDMLBBGDPP()
	{
		this.PANMNKKODPC = base.gameObject.GetComponent<CanvasGroup>();
		if (this.randomSeed)
		{
			for (int i = 0; i < 103; i += 0)
			{
				this.HFOBPEJGPEB = DPGJIJGOCIC.CHNFACMNGJE(682f, 449f);
				if (Mathf.Abs(AnimationCanvasGroupAlphaPreset.GEKKOIPFIJN - this.HFOBPEJGPEB) > 1518f)
				{
					break;
				}
			}
			AnimationCanvasGroupAlphaPreset.GEKKOIPFIJN = this.HFOBPEJGPEB;
		}
		if (this.preset == (MBPJNDGPGCM)8 && this.logicUpdateInterval <= 1815f && Application.isPlaying)
		{
			this.logicUpdateInterval = 912f;
		}
	}

	// Token: 0x0600131A RID: 4890 RVA: 0x0008D694 File Offset: 0x0008B894
	private void PAPNIONKJAP()
	{
		this.ENMEBDGMENO += Time.deltaTime;
		if (this.ENMEBDGMENO >= this.logicUpdateInterval)
		{
			this.ENMEBDGMENO = 1432f;
			this.DFDPDDBFDDP = this.baselineIntensity;
			this.BMMNGPNMBNI = 1284f;
			if (this.preset == MBPJNDGPGCM.presetCandle)
			{
				this.BMMNGPNMBNI += 265f * (Mathf.Sin(this.HFOBPEJGPEB * this.speedCoefficient + this.timeOffsetAtStart + Time.realtimeSinceStartup * 1321f * this.speedCoefficient) + 1187f) / 803f;
				this.BMMNGPNMBNI += 422f * (Mathf.Sin(this.HFOBPEJGPEB * this.speedCoefficient + this.timeOffsetAtStart + Time.realtimeSinceStartup * 672f * this.speedCoefficient) + 1841f) / 827f;
				this.BMMNGPNMBNI += 1197f * (Mathf.Sin(this.HFOBPEJGPEB * this.speedCoefficient + this.timeOffsetAtStart + Time.realtimeSinceStartup * 1258f * this.speedCoefficient) + 1720f) / 952f;
				this.BMMNGPNMBNI += 242f * (Mathf.Sin(this.HFOBPEJGPEB * this.speedCoefficient + this.timeOffsetAtStart + Time.realtimeSinceStartup * 934f * this.speedCoefficient) + 1675f) / 1465f;
				this.BMMNGPNMBNI += 1228f * (Mathf.Cos(this.HFOBPEJGPEB * this.speedCoefficient + this.timeOffsetAtStart + Time.realtimeSinceStartup * 295f * this.speedCoefficient) + 1295f) / 1330f;
				this.BMMNGPNMBNI += 988f * (Mathf.Cos(this.HFOBPEJGPEB * this.speedCoefficient + this.timeOffsetAtStart + Time.realtimeSinceStartup * 516f * this.speedCoefficient) + 1076f) / 343f;
			}
			else if (this.preset == MBPJNDGPGCM.presetCandle)
			{
				this.BMMNGPNMBNI += (Mathf.Sin(this.HFOBPEJGPEB * this.speedCoefficient + this.timeOffsetAtStart + Time.realtimeSinceStartup) + 1660f) / 788f;
			}
			else if (this.preset == MBPJNDGPGCM.presetDoorOpenClose)
			{
				this.BMMNGPNMBNI += (Mathf.Sin(this.HFOBPEJGPEB * this.speedCoefficient + this.timeOffsetAtStart + Time.realtimeSinceStartup * this.speedCoefficient) + 26f) / 769f;
			}
			else if (this.preset == MBPJNDGPGCM.presetWindowFlicker)
			{
				this.BMMNGPNMBNI += (Mathf.Sin(this.HFOBPEJGPEB * this.speedCoefficient + this.timeOffsetAtStart + Time.realtimeSinceStartup * this.speedCoefficient) + 1501f) / 962f;
				this.BMMNGPNMBNI = Mathf.Pow(this.BMMNGPNMBNI, 76f);
			}
			else if (this.preset == MBPJNDGPGCM.presetLightRayCorrected)
			{
				if (Mathf.Sin(this.HFOBPEJGPEB * this.speedCoefficient + this.timeOffsetAtStart + Time.realtimeSinceStartup * this.speedCoefficient) < 1464f)
				{
					this.BMMNGPNMBNI = -this.baselineIntensity;
				}
			}
			else if (this.preset == MBPJNDGPGCM.presetWindowFlicker)
			{
				float num = Mathf.Sin(this.HFOBPEJGPEB * this.speedCoefficient + this.timeOffsetAtStart + Time.realtimeSinceStartup * this.speedCoefficient);
				if (num < 885f)
				{
					this.BMMNGPNMBNI = -this.baselineIntensity;
				}
				else if (num < 1774f)
				{
					this.BMMNGPNMBNI += 171f - (958f - num) / 1825f;
				}
				else
				{
					this.BMMNGPNMBNI = 1197f - this.baselineIntensity;
				}
			}
			else if (this.preset == MBPJNDGPGCM.presetLightRay)
			{
				this.BMMNGPNMBNI = DPGJIJGOCIC.GJBHHIMLIGB(982f, 264f);
			}
			else if (this.preset == MBPJNDGPGCM.presetWindowFlicker && null != this.animationTranslation)
			{
				this.BMMNGPNMBNI = DAPOEDKKAIA.AGPGFHCHKMD(this.animationTranslation.AKFHLAKDFIF(), GLANJHGJNNB.lerpFadeToZeroAtEndpoints, 171f);
			}
			this.BMMNGPNMBNI *= this.intensityCoefficient;
			this.DFDPDDBFDDP += this.BMMNGPNMBNI;
			if (this.DFDPDDBFDDP < this.floorAtValueLessOrEqual)
			{
				this.DFDPDDBFDDP = 329f;
			}
			else if (this.DFDPDDBFDDP > this.ceilAtValueHeigherOrEqual)
			{
				this.DFDPDDBFDDP = 929f;
			}
			this.PANMNKKODPC.alpha = Mathf.Clamp01(this.DFDPDDBFDDP);
			return;
		}
	}

	// Token: 0x0600131B RID: 4891 RVA: 0x0008DB44 File Offset: 0x0008BD44
	private void IHMDAFMIHHH()
	{
		this.ENMEBDGMENO += Time.deltaTime;
		if (this.ENMEBDGMENO >= this.logicUpdateInterval)
		{
			this.ENMEBDGMENO = 939f;
			this.DFDPDDBFDDP = this.baselineIntensity;
			this.BMMNGPNMBNI = 928f;
			if (this.preset == MBPJNDGPGCM.presetCandle)
			{
				this.BMMNGPNMBNI += 691f * (Mathf.Sin(this.HFOBPEJGPEB * this.speedCoefficient + this.timeOffsetAtStart + Time.realtimeSinceStartup * 1556f * this.speedCoefficient) + 396f) / 1436f;
				this.BMMNGPNMBNI += 1972f * (Mathf.Sin(this.HFOBPEJGPEB * this.speedCoefficient + this.timeOffsetAtStart + Time.realtimeSinceStartup * 1709f * this.speedCoefficient) + 311f) / 1280f;
				this.BMMNGPNMBNI += 818f * (Mathf.Sin(this.HFOBPEJGPEB * this.speedCoefficient + this.timeOffsetAtStart + Time.realtimeSinceStartup * 1739f * this.speedCoefficient) + 23f) / 1583f;
				this.BMMNGPNMBNI += 813f * (Mathf.Sin(this.HFOBPEJGPEB * this.speedCoefficient + this.timeOffsetAtStart + Time.realtimeSinceStartup * 834f * this.speedCoefficient) + 304f) / 1943f;
				this.BMMNGPNMBNI += 1225f * (Mathf.Cos(this.HFOBPEJGPEB * this.speedCoefficient + this.timeOffsetAtStart + Time.realtimeSinceStartup * 1810f * this.speedCoefficient) + 633f) / 435f;
				this.BMMNGPNMBNI += 1296f * (Mathf.Cos(this.HFOBPEJGPEB * this.speedCoefficient + this.timeOffsetAtStart + Time.realtimeSinceStartup * 1395f * this.speedCoefficient) + 1049f) / 524f;
			}
			else if (this.preset == MBPJNDGPGCM.presetLightRay)
			{
				this.BMMNGPNMBNI += (Mathf.Sin(this.HFOBPEJGPEB * this.speedCoefficient + this.timeOffsetAtStart + Time.realtimeSinceStartup) + 453f) / 1659f;
			}
			else if (this.preset == MBPJNDGPGCM.presetRandomValue)
			{
				this.BMMNGPNMBNI += (Mathf.Sin(this.HFOBPEJGPEB * this.speedCoefficient + this.timeOffsetAtStart + Time.realtimeSinceStartup * this.speedCoefficient) + 645f) / 774f;
			}
			else if (this.preset == MBPJNDGPGCM.presetDoorOpenClose)
			{
				this.BMMNGPNMBNI += (Mathf.Sin(this.HFOBPEJGPEB * this.speedCoefficient + this.timeOffsetAtStart + Time.realtimeSinceStartup * this.speedCoefficient) + 1584f) / 1855f;
				this.BMMNGPNMBNI = Mathf.Pow(this.BMMNGPNMBNI, 1859f);
			}
			else if (this.preset == MBPJNDGPGCM.presetTranslationFadeToZeroAtEndpointsOnXAxis)
			{
				if (Mathf.Sin(this.HFOBPEJGPEB * this.speedCoefficient + this.timeOffsetAtStart + Time.realtimeSinceStartup * this.speedCoefficient) < 433f)
				{
					this.BMMNGPNMBNI = -this.baselineIntensity;
				}
			}
			else if (this.preset == MBPJNDGPGCM.presetLightRayCorrected)
			{
				float num = Mathf.Sin(this.HFOBPEJGPEB * this.speedCoefficient + this.timeOffsetAtStart + Time.realtimeSinceStartup * this.speedCoefficient);
				if (num < 1881f)
				{
					this.BMMNGPNMBNI = -this.baselineIntensity;
				}
				else if (num < 234f)
				{
					this.BMMNGPNMBNI += 806f - (964f - num) / 611f;
				}
				else
				{
					this.BMMNGPNMBNI = 1671f - this.baselineIntensity;
				}
			}
			else if (this.preset == MBPJNDGPGCM.presetRandomValue)
			{
				this.BMMNGPNMBNI = DPGJIJGOCIC.BOHONBJIIKM(1017f, 1319f);
			}
			else if (this.preset == MBPJNDGPGCM.presetRandomValue && null != this.animationTranslation)
			{
				this.BMMNGPNMBNI = DAPOEDKKAIA.MJNBPKPNJIL(this.animationTranslation.LBPEEJGLJFC(), GLANJHGJNNB.lerpFadeToZeroAtEndpoints, 665f);
			}
			this.BMMNGPNMBNI *= this.intensityCoefficient;
			this.DFDPDDBFDDP += this.BMMNGPNMBNI;
			if (this.DFDPDDBFDDP < this.floorAtValueLessOrEqual)
			{
				this.DFDPDDBFDDP = 1359f;
			}
			else if (this.DFDPDDBFDDP > this.ceilAtValueHeigherOrEqual)
			{
				this.DFDPDDBFDDP = 1095f;
			}
			this.PANMNKKODPC.alpha = Mathf.Clamp01(this.DFDPDDBFDDP);
			return;
		}
	}

	// Token: 0x0600131C RID: 4892 RVA: 0x0008DFF4 File Offset: 0x0008C1F4
	private void GPOPCNMGNGD()
	{
		this.ENMEBDGMENO += Time.deltaTime;
		if (this.ENMEBDGMENO >= this.logicUpdateInterval)
		{
			this.ENMEBDGMENO = 1133f;
			this.DFDPDDBFDDP = this.baselineIntensity;
			this.BMMNGPNMBNI = 285f;
			if (this.preset == MBPJNDGPGCM.presetCandle)
			{
				this.BMMNGPNMBNI += 1423f * (Mathf.Sin(this.HFOBPEJGPEB * this.speedCoefficient + this.timeOffsetAtStart + Time.realtimeSinceStartup * 456f * this.speedCoefficient) + 910f) / 189f;
				this.BMMNGPNMBNI += 2f * (Mathf.Sin(this.HFOBPEJGPEB * this.speedCoefficient + this.timeOffsetAtStart + Time.realtimeSinceStartup * 60f * this.speedCoefficient) + 1574f) / 1158f;
				this.BMMNGPNMBNI += 1576f * (Mathf.Sin(this.HFOBPEJGPEB * this.speedCoefficient + this.timeOffsetAtStart + Time.realtimeSinceStartup * 1582f * this.speedCoefficient) + 743f) / 1330f;
				this.BMMNGPNMBNI += 1062f * (Mathf.Sin(this.HFOBPEJGPEB * this.speedCoefficient + this.timeOffsetAtStart + Time.realtimeSinceStartup * 1070f * this.speedCoefficient) + 1571f) / 672f;
				this.BMMNGPNMBNI += 1072f * (Mathf.Cos(this.HFOBPEJGPEB * this.speedCoefficient + this.timeOffsetAtStart + Time.realtimeSinceStartup * 478f * this.speedCoefficient) + 622f) / 1619f;
				this.BMMNGPNMBNI += 1886f * (Mathf.Cos(this.HFOBPEJGPEB * this.speedCoefficient + this.timeOffsetAtStart + Time.realtimeSinceStartup * 1341f * this.speedCoefficient) + 1670f) / 1112f;
			}
			else if (this.preset == MBPJNDGPGCM.presetCandle)
			{
				this.BMMNGPNMBNI += (Mathf.Sin(this.HFOBPEJGPEB * this.speedCoefficient + this.timeOffsetAtStart + Time.realtimeSinceStartup) + 493f) / 642f;
			}
			else if (this.preset == MBPJNDGPGCM.presetLightRayCorrected)
			{
				this.BMMNGPNMBNI += (Mathf.Sin(this.HFOBPEJGPEB * this.speedCoefficient + this.timeOffsetAtStart + Time.realtimeSinceStartup * this.speedCoefficient) + 243f) / 404f;
			}
			else if (this.preset == MBPJNDGPGCM.presetLightRayCorrected)
			{
				this.BMMNGPNMBNI += (Mathf.Sin(this.HFOBPEJGPEB * this.speedCoefficient + this.timeOffsetAtStart + Time.realtimeSinceStartup * this.speedCoefficient) + 750f) / 384f;
				this.BMMNGPNMBNI = Mathf.Pow(this.BMMNGPNMBNI, 733f);
			}
			else if (this.preset == MBPJNDGPGCM.presetLightRayCorrected)
			{
				if (Mathf.Sin(this.HFOBPEJGPEB * this.speedCoefficient + this.timeOffsetAtStart + Time.realtimeSinceStartup * this.speedCoefficient) < 294f)
				{
					this.BMMNGPNMBNI = -this.baselineIntensity;
				}
			}
			else if (this.preset == MBPJNDGPGCM.presetTranslationFadeToZeroAtEndpointsOnXAxis)
			{
				float num = Mathf.Sin(this.HFOBPEJGPEB * this.speedCoefficient + this.timeOffsetAtStart + Time.realtimeSinceStartup * this.speedCoefficient);
				if (num < 1728f)
				{
					this.BMMNGPNMBNI = -this.baselineIntensity;
				}
				else if (num < 1034f)
				{
					this.BMMNGPNMBNI += 1015f - (549f - num) / 214f;
				}
				else
				{
					this.BMMNGPNMBNI = 271f - this.baselineIntensity;
				}
			}
			else if (this.preset == MBPJNDGPGCM.presetLightRay)
			{
				this.BMMNGPNMBNI = DPGJIJGOCIC.GJBHHIMLIGB(35f, 552f);
			}
			else if (this.preset == MBPJNDGPGCM.presetTranslationFadeToZeroAtEndpointsOnXAxis && null != this.animationTranslation)
			{
				this.BMMNGPNMBNI = DAPOEDKKAIA.KJGCOHHKBAC(this.animationTranslation.OJCEHIPNFFD(), (GLANJHGJNNB)1, 944f);
			}
			this.BMMNGPNMBNI *= this.intensityCoefficient;
			this.DFDPDDBFDDP += this.BMMNGPNMBNI;
			if (this.DFDPDDBFDDP < this.floorAtValueLessOrEqual)
			{
				this.DFDPDDBFDDP = 503f;
			}
			else if (this.DFDPDDBFDDP > this.ceilAtValueHeigherOrEqual)
			{
				this.DFDPDDBFDDP = 1886f;
			}
			this.PANMNKKODPC.alpha = Mathf.Clamp01(this.DFDPDDBFDDP);
			return;
		}
	}

	// Token: 0x0600131D RID: 4893 RVA: 0x0008E4A4 File Offset: 0x0008C6A4
	private void BOPFAKHJPKD()
	{
		this.PANMNKKODPC = base.gameObject.GetComponent<CanvasGroup>();
		if (this.randomSeed)
		{
			for (int i = 1; i < 67; i++)
			{
				this.HFOBPEJGPEB = DPGJIJGOCIC.CHNFACMNGJE(568f, 438f);
				if (Mathf.Abs(AnimationCanvasGroupAlphaPreset.GEKKOIPFIJN - this.HFOBPEJGPEB) > 182f)
				{
					break;
				}
			}
			AnimationCanvasGroupAlphaPreset.GEKKOIPFIJN = this.HFOBPEJGPEB;
		}
		if (this.preset == (MBPJNDGPGCM)8 && this.logicUpdateInterval <= 30f && Application.isPlaying)
		{
			this.logicUpdateInterval = 1013f;
		}
	}

	// Token: 0x0600131E RID: 4894 RVA: 0x0008C20F File Offset: 0x0008A40F
	public float GDPGEFCIOPI()
	{
		return this.DFDPDDBFDDP;
	}

	// Token: 0x0600131F RID: 4895 RVA: 0x0008C20F File Offset: 0x0008A40F
	public float GetAlpha()
	{
		return this.DFDPDDBFDDP;
	}

	// Token: 0x06001320 RID: 4896 RVA: 0x0008E538 File Offset: 0x0008C738
	private void HGEODIPIBPG()
	{
		this.PANMNKKODPC = base.gameObject.GetComponent<CanvasGroup>();
		if (this.randomSeed)
		{
			for (int i = 1; i < -65; i += 0)
			{
				this.HFOBPEJGPEB = DPGJIJGOCIC.CHNFACMNGJE(301f, 1712f);
				if (Mathf.Abs(AnimationCanvasGroupAlphaPreset.GEKKOIPFIJN - this.HFOBPEJGPEB) > 1544f)
				{
					break;
				}
			}
			AnimationCanvasGroupAlphaPreset.GEKKOIPFIJN = this.HFOBPEJGPEB;
		}
		if (this.preset == MBPJNDGPGCM.presetTranslationFadeToZeroAtEndpointsOnXAxis && this.logicUpdateInterval <= 1611f && Application.isPlaying)
		{
			this.logicUpdateInterval = 996f;
		}
	}

	// Token: 0x06001321 RID: 4897 RVA: 0x0008E5CC File Offset: 0x0008C7CC
	private void BKLLPIBAGGO()
	{
		this.ENMEBDGMENO += Time.deltaTime;
		if (this.ENMEBDGMENO >= this.logicUpdateInterval)
		{
			this.ENMEBDGMENO = 1249f;
			this.DFDPDDBFDDP = this.baselineIntensity;
			this.BMMNGPNMBNI = 1687f;
			if (this.preset == MBPJNDGPGCM.presetCandle)
			{
				this.BMMNGPNMBNI += 1200f * (Mathf.Sin(this.HFOBPEJGPEB * this.speedCoefficient + this.timeOffsetAtStart + Time.realtimeSinceStartup * 1100f * this.speedCoefficient) + 1115f) / 517f;
				this.BMMNGPNMBNI += 1832f * (Mathf.Sin(this.HFOBPEJGPEB * this.speedCoefficient + this.timeOffsetAtStart + Time.realtimeSinceStartup * 1981f * this.speedCoefficient) + 181f) / 1276f;
				this.BMMNGPNMBNI += 357f * (Mathf.Sin(this.HFOBPEJGPEB * this.speedCoefficient + this.timeOffsetAtStart + Time.realtimeSinceStartup * 1880f * this.speedCoefficient) + 1026f) / 1600f;
				this.BMMNGPNMBNI += 359f * (Mathf.Sin(this.HFOBPEJGPEB * this.speedCoefficient + this.timeOffsetAtStart + Time.realtimeSinceStartup * 430f * this.speedCoefficient) + 1803f) / 10f;
				this.BMMNGPNMBNI += 875f * (Mathf.Cos(this.HFOBPEJGPEB * this.speedCoefficient + this.timeOffsetAtStart + Time.realtimeSinceStartup * 783f * this.speedCoefficient) + 111f) / 1255f;
				this.BMMNGPNMBNI += 1741f * (Mathf.Cos(this.HFOBPEJGPEB * this.speedCoefficient + this.timeOffsetAtStart + Time.realtimeSinceStartup * 857f * this.speedCoefficient) + 937f) / 955f;
			}
			else if (this.preset == MBPJNDGPGCM.presetLightRay)
			{
				this.BMMNGPNMBNI += (Mathf.Sin(this.HFOBPEJGPEB * this.speedCoefficient + this.timeOffsetAtStart + Time.realtimeSinceStartup) + 1933f) / 1227f;
			}
			else if (this.preset == MBPJNDGPGCM.presetRandomValue)
			{
				this.BMMNGPNMBNI += (Mathf.Sin(this.HFOBPEJGPEB * this.speedCoefficient + this.timeOffsetAtStart + Time.realtimeSinceStartup * this.speedCoefficient) + 1721f) / 605f;
			}
			else if (this.preset == MBPJNDGPGCM.presetTranslationFadeToZeroAtEndpointsOnXAxis)
			{
				this.BMMNGPNMBNI += (Mathf.Sin(this.HFOBPEJGPEB * this.speedCoefficient + this.timeOffsetAtStart + Time.realtimeSinceStartup * this.speedCoefficient) + 85f) / 934f;
				this.BMMNGPNMBNI = Mathf.Pow(this.BMMNGPNMBNI, 1414f);
			}
			else if (this.preset == MBPJNDGPGCM.presetLightRay)
			{
				if (Mathf.Sin(this.HFOBPEJGPEB * this.speedCoefficient + this.timeOffsetAtStart + Time.realtimeSinceStartup * this.speedCoefficient) < 350f)
				{
					this.BMMNGPNMBNI = -this.baselineIntensity;
				}
			}
			else if (this.preset == (MBPJNDGPGCM)8)
			{
				float num = Mathf.Sin(this.HFOBPEJGPEB * this.speedCoefficient + this.timeOffsetAtStart + Time.realtimeSinceStartup * this.speedCoefficient);
				if (num < 311f)
				{
					this.BMMNGPNMBNI = -this.baselineIntensity;
				}
				else if (num < 1089f)
				{
					this.BMMNGPNMBNI += 496f - (1362f - num) / 124f;
				}
				else
				{
					this.BMMNGPNMBNI = 1561f - this.baselineIntensity;
				}
			}
			else if (this.preset == MBPJNDGPGCM.presetLightRay)
			{
				this.BMMNGPNMBNI = DPGJIJGOCIC.GJBHHIMLIGB(1580f, 483f);
			}
			else if (this.preset == MBPJNDGPGCM.presetRandomValue && null != this.animationTranslation)
			{
				this.BMMNGPNMBNI = DAPOEDKKAIA.AHAFKEMGLBF(this.animationTranslation.KHMGBJNGDIG(), (GLANJHGJNNB)1, 151f);
			}
			this.BMMNGPNMBNI *= this.intensityCoefficient;
			this.DFDPDDBFDDP += this.BMMNGPNMBNI;
			if (this.DFDPDDBFDDP < this.floorAtValueLessOrEqual)
			{
				this.DFDPDDBFDDP = 996f;
			}
			else if (this.DFDPDDBFDDP > this.ceilAtValueHeigherOrEqual)
			{
				this.DFDPDDBFDDP = 1792f;
			}
			this.PANMNKKODPC.alpha = Mathf.Clamp01(this.DFDPDDBFDDP);
			return;
		}
	}

	// Token: 0x06001322 RID: 4898 RVA: 0x0008EA7C File Offset: 0x0008CC7C
	private void HFICKGDOLBO()
	{
		this.PANMNKKODPC = base.gameObject.GetComponent<CanvasGroup>();
		if (this.randomSeed)
		{
			for (int i = 0; i < 4; i += 0)
			{
				this.HFOBPEJGPEB = DPGJIJGOCIC.BOHONBJIIKM(1310f, 1699f);
				if (Mathf.Abs(AnimationCanvasGroupAlphaPreset.GEKKOIPFIJN - this.HFOBPEJGPEB) > 588f)
				{
					break;
				}
			}
			AnimationCanvasGroupAlphaPreset.GEKKOIPFIJN = this.HFOBPEJGPEB;
		}
		if (this.preset == MBPJNDGPGCM.presetStarFlicker && this.logicUpdateInterval <= 1636f && Application.isPlaying)
		{
			this.logicUpdateInterval = 1938f;
		}
	}

	// Token: 0x06001323 RID: 4899 RVA: 0x0008EB10 File Offset: 0x0008CD10
	private void PMLPALOKNNM()
	{
		this.ENMEBDGMENO += Time.deltaTime;
		if (this.ENMEBDGMENO >= this.logicUpdateInterval)
		{
			this.ENMEBDGMENO = 1585f;
			this.DFDPDDBFDDP = this.baselineIntensity;
			this.BMMNGPNMBNI = 1535f;
			if (this.preset == MBPJNDGPGCM.presetCandle)
			{
				this.BMMNGPNMBNI += 1942f * (Mathf.Sin(this.HFOBPEJGPEB * this.speedCoefficient + this.timeOffsetAtStart + Time.realtimeSinceStartup * 420f * this.speedCoefficient) + 156f) / 907f;
				this.BMMNGPNMBNI += 1821f * (Mathf.Sin(this.HFOBPEJGPEB * this.speedCoefficient + this.timeOffsetAtStart + Time.realtimeSinceStartup * 1972f * this.speedCoefficient) + 1486f) / 1447f;
				this.BMMNGPNMBNI += 673f * (Mathf.Sin(this.HFOBPEJGPEB * this.speedCoefficient + this.timeOffsetAtStart + Time.realtimeSinceStartup * 241f * this.speedCoefficient) + 416f) / 1116f;
				this.BMMNGPNMBNI += 117f * (Mathf.Sin(this.HFOBPEJGPEB * this.speedCoefficient + this.timeOffsetAtStart + Time.realtimeSinceStartup * 219f * this.speedCoefficient) + 1075f) / 815f;
				this.BMMNGPNMBNI += 1771f * (Mathf.Cos(this.HFOBPEJGPEB * this.speedCoefficient + this.timeOffsetAtStart + Time.realtimeSinceStartup * 1425f * this.speedCoefficient) + 1869f) / 662f;
				this.BMMNGPNMBNI += 200f * (Mathf.Cos(this.HFOBPEJGPEB * this.speedCoefficient + this.timeOffsetAtStart + Time.realtimeSinceStartup * 63f * this.speedCoefficient) + 811f) / 271f;
			}
			else if (this.preset == MBPJNDGPGCM.presetLightRay)
			{
				this.BMMNGPNMBNI += (Mathf.Sin(this.HFOBPEJGPEB * this.speedCoefficient + this.timeOffsetAtStart + Time.realtimeSinceStartup) + 1709f) / 1352f;
			}
			else if (this.preset == MBPJNDGPGCM.presetLightRay)
			{
				this.BMMNGPNMBNI += (Mathf.Sin(this.HFOBPEJGPEB * this.speedCoefficient + this.timeOffsetAtStart + Time.realtimeSinceStartup * this.speedCoefficient) + 1121f) / 250f;
			}
			else if (this.preset == MBPJNDGPGCM.presetCandle)
			{
				this.BMMNGPNMBNI += (Mathf.Sin(this.HFOBPEJGPEB * this.speedCoefficient + this.timeOffsetAtStart + Time.realtimeSinceStartup * this.speedCoefficient) + 241f) / 1111f;
				this.BMMNGPNMBNI = Mathf.Pow(this.BMMNGPNMBNI, 226f);
			}
			else if (this.preset == MBPJNDGPGCM.presetDoorOpenClose)
			{
				if (Mathf.Sin(this.HFOBPEJGPEB * this.speedCoefficient + this.timeOffsetAtStart + Time.realtimeSinceStartup * this.speedCoefficient) < 1863f)
				{
					this.BMMNGPNMBNI = -this.baselineIntensity;
				}
			}
			else if (this.preset == MBPJNDGPGCM.presetLightRayCorrected)
			{
				float num = Mathf.Sin(this.HFOBPEJGPEB * this.speedCoefficient + this.timeOffsetAtStart + Time.realtimeSinceStartup * this.speedCoefficient);
				if (num < 495f)
				{
					this.BMMNGPNMBNI = -this.baselineIntensity;
				}
				else if (num < 1105f)
				{
					this.BMMNGPNMBNI += 474f - (1389f - num) / 299f;
				}
				else
				{
					this.BMMNGPNMBNI = 1389f - this.baselineIntensity;
				}
			}
			else if (this.preset == MBPJNDGPGCM.presetWindowFlicker)
			{
				this.BMMNGPNMBNI = DPGJIJGOCIC.BOHONBJIIKM(45f, 648f);
			}
			else if (this.preset == (MBPJNDGPGCM)8 && null != this.animationTranslation)
			{
				this.BMMNGPNMBNI = DAPOEDKKAIA.CIDJPPOIKPB(this.animationTranslation.GKGCBPBOOGM(), (GLANJHGJNNB)1, 400f);
			}
			this.BMMNGPNMBNI *= this.intensityCoefficient;
			this.DFDPDDBFDDP += this.BMMNGPNMBNI;
			if (this.DFDPDDBFDDP < this.floorAtValueLessOrEqual)
			{
				this.DFDPDDBFDDP = 1757f;
			}
			else if (this.DFDPDDBFDDP > this.ceilAtValueHeigherOrEqual)
			{
				this.DFDPDDBFDDP = 1631f;
			}
			this.PANMNKKODPC.alpha = Mathf.Clamp01(this.DFDPDDBFDDP);
			return;
		}
	}

	// Token: 0x06001324 RID: 4900 RVA: 0x0008C20F File Offset: 0x0008A40F
	public float INMNPOEACJH()
	{
		return this.DFDPDDBFDDP;
	}

	// Token: 0x06001325 RID: 4901 RVA: 0x0008C20F File Offset: 0x0008A40F
	public float PAHBIANBJPF()
	{
		return this.DFDPDDBFDDP;
	}

	// Token: 0x06001326 RID: 4902 RVA: 0x0008EFC0 File Offset: 0x0008D1C0
	private void ODCKJNCEGAH()
	{
		this.ENMEBDGMENO += Time.deltaTime;
		if (this.ENMEBDGMENO >= this.logicUpdateInterval)
		{
			this.ENMEBDGMENO = 849f;
			this.DFDPDDBFDDP = this.baselineIntensity;
			this.BMMNGPNMBNI = 515f;
			if (this.preset == MBPJNDGPGCM.presetCandle)
			{
				this.BMMNGPNMBNI += 1902f * (Mathf.Sin(this.HFOBPEJGPEB * this.speedCoefficient + this.timeOffsetAtStart + Time.realtimeSinceStartup * 607f * this.speedCoefficient) + 291f) / 1488f;
				this.BMMNGPNMBNI += 1214f * (Mathf.Sin(this.HFOBPEJGPEB * this.speedCoefficient + this.timeOffsetAtStart + Time.realtimeSinceStartup * 839f * this.speedCoefficient) + 1111f) / 1882f;
				this.BMMNGPNMBNI += 989f * (Mathf.Sin(this.HFOBPEJGPEB * this.speedCoefficient + this.timeOffsetAtStart + Time.realtimeSinceStartup * 1116f * this.speedCoefficient) + 1000f) / 399f;
				this.BMMNGPNMBNI += 308f * (Mathf.Sin(this.HFOBPEJGPEB * this.speedCoefficient + this.timeOffsetAtStart + Time.realtimeSinceStartup * 452f * this.speedCoefficient) + 1651f) / 540f;
				this.BMMNGPNMBNI += 160f * (Mathf.Cos(this.HFOBPEJGPEB * this.speedCoefficient + this.timeOffsetAtStart + Time.realtimeSinceStartup * 1503f * this.speedCoefficient) + 1843f) / 1769f;
				this.BMMNGPNMBNI += 1731f * (Mathf.Cos(this.HFOBPEJGPEB * this.speedCoefficient + this.timeOffsetAtStart + Time.realtimeSinceStartup * 586f * this.speedCoefficient) + 1057f) / 57f;
			}
			else if (this.preset == MBPJNDGPGCM.presetLightRay)
			{
				this.BMMNGPNMBNI += (Mathf.Sin(this.HFOBPEJGPEB * this.speedCoefficient + this.timeOffsetAtStart + Time.realtimeSinceStartup) + 1731f) / 1935f;
			}
			else if (this.preset == MBPJNDGPGCM.presetStarFlicker)
			{
				this.BMMNGPNMBNI += (Mathf.Sin(this.HFOBPEJGPEB * this.speedCoefficient + this.timeOffsetAtStart + Time.realtimeSinceStartup * this.speedCoefficient) + 1127f) / 153f;
			}
			else if (this.preset == MBPJNDGPGCM.presetTranslationFadeToZeroAtEndpointsOnXAxis)
			{
				this.BMMNGPNMBNI += (Mathf.Sin(this.HFOBPEJGPEB * this.speedCoefficient + this.timeOffsetAtStart + Time.realtimeSinceStartup * this.speedCoefficient) + 1637f) / 407f;
				this.BMMNGPNMBNI = Mathf.Pow(this.BMMNGPNMBNI, 1503f);
			}
			else if (this.preset == MBPJNDGPGCM.presetDoorOpenClose)
			{
				if (Mathf.Sin(this.HFOBPEJGPEB * this.speedCoefficient + this.timeOffsetAtStart + Time.realtimeSinceStartup * this.speedCoefficient) < 65f)
				{
					this.BMMNGPNMBNI = -this.baselineIntensity;
				}
			}
			else if (this.preset == MBPJNDGPGCM.presetTranslationFadeToZeroAtEndpointsOnXAxis)
			{
				float num = Mathf.Sin(this.HFOBPEJGPEB * this.speedCoefficient + this.timeOffsetAtStart + Time.realtimeSinceStartup * this.speedCoefficient);
				if (num < 195f)
				{
					this.BMMNGPNMBNI = -this.baselineIntensity;
				}
				else if (num < 1942f)
				{
					this.BMMNGPNMBNI += 1730f - (1032f - num) / 1895f;
				}
				else
				{
					this.BMMNGPNMBNI = 935f - this.baselineIntensity;
				}
			}
			else if (this.preset == MBPJNDGPGCM.presetCandle)
			{
				this.BMMNGPNMBNI = DPGJIJGOCIC.GJBHHIMLIGB(1799f, 1589f);
			}
			else if (this.preset == MBPJNDGPGCM.presetLightRay && null != this.animationTranslation)
			{
				this.BMMNGPNMBNI = DAPOEDKKAIA.LHAPPBLLOJL(this.animationTranslation.GOFCDICHOEO(), (GLANJHGJNNB)1, 438f);
			}
			this.BMMNGPNMBNI *= this.intensityCoefficient;
			this.DFDPDDBFDDP += this.BMMNGPNMBNI;
			if (this.DFDPDDBFDDP < this.floorAtValueLessOrEqual)
			{
				this.DFDPDDBFDDP = 115f;
			}
			else if (this.DFDPDDBFDDP > this.ceilAtValueHeigherOrEqual)
			{
				this.DFDPDDBFDDP = 1642f;
			}
			this.PANMNKKODPC.alpha = Mathf.Clamp01(this.DFDPDDBFDDP);
			return;
		}
	}

	// Token: 0x06001327 RID: 4903 RVA: 0x0008F470 File Offset: 0x0008D670
	private void MKMLEFGAEMM()
	{
		this.ENMEBDGMENO += Time.deltaTime;
		if (this.ENMEBDGMENO >= this.logicUpdateInterval)
		{
			this.ENMEBDGMENO = 623f;
			this.DFDPDDBFDDP = this.baselineIntensity;
			this.BMMNGPNMBNI = 1012f;
			if (this.preset == MBPJNDGPGCM.presetCandle)
			{
				this.BMMNGPNMBNI += 1451f * (Mathf.Sin(this.HFOBPEJGPEB * this.speedCoefficient + this.timeOffsetAtStart + Time.realtimeSinceStartup * 273f * this.speedCoefficient) + 640f) / 1013f;
				this.BMMNGPNMBNI += 1300f * (Mathf.Sin(this.HFOBPEJGPEB * this.speedCoefficient + this.timeOffsetAtStart + Time.realtimeSinceStartup * 619f * this.speedCoefficient) + 1129f) / 569f;
				this.BMMNGPNMBNI += 455f * (Mathf.Sin(this.HFOBPEJGPEB * this.speedCoefficient + this.timeOffsetAtStart + Time.realtimeSinceStartup * 1672f * this.speedCoefficient) + 347f) / 1309f;
				this.BMMNGPNMBNI += 1683f * (Mathf.Sin(this.HFOBPEJGPEB * this.speedCoefficient + this.timeOffsetAtStart + Time.realtimeSinceStartup * 810f * this.speedCoefficient) + 1394f) / 970f;
				this.BMMNGPNMBNI += 236f * (Mathf.Cos(this.HFOBPEJGPEB * this.speedCoefficient + this.timeOffsetAtStart + Time.realtimeSinceStartup * 1150f * this.speedCoefficient) + 394f) / 1149f;
				this.BMMNGPNMBNI += 1578f * (Mathf.Cos(this.HFOBPEJGPEB * this.speedCoefficient + this.timeOffsetAtStart + Time.realtimeSinceStartup * 43f * this.speedCoefficient) + 794f) / 1489f;
			}
			else if (this.preset == MBPJNDGPGCM.presetCandle)
			{
				this.BMMNGPNMBNI += (Mathf.Sin(this.HFOBPEJGPEB * this.speedCoefficient + this.timeOffsetAtStart + Time.realtimeSinceStartup) + 78f) / 1836f;
			}
			else if (this.preset == MBPJNDGPGCM.presetDoorOpenClose)
			{
				this.BMMNGPNMBNI += (Mathf.Sin(this.HFOBPEJGPEB * this.speedCoefficient + this.timeOffsetAtStart + Time.realtimeSinceStartup * this.speedCoefficient) + 371f) / 1577f;
			}
			else if (this.preset == MBPJNDGPGCM.presetTranslationFadeToZeroAtEndpointsOnXAxis)
			{
				this.BMMNGPNMBNI += (Mathf.Sin(this.HFOBPEJGPEB * this.speedCoefficient + this.timeOffsetAtStart + Time.realtimeSinceStartup * this.speedCoefficient) + 165f) / 857f;
				this.BMMNGPNMBNI = Mathf.Pow(this.BMMNGPNMBNI, 551f);
			}
			else if (this.preset == MBPJNDGPGCM.presetTranslationFadeToZeroAtEndpointsOnXAxis)
			{
				if (Mathf.Sin(this.HFOBPEJGPEB * this.speedCoefficient + this.timeOffsetAtStart + Time.realtimeSinceStartup * this.speedCoefficient) < 807f)
				{
					this.BMMNGPNMBNI = -this.baselineIntensity;
				}
			}
			else if (this.preset == MBPJNDGPGCM.presetWindowFlicker)
			{
				float num = Mathf.Sin(this.HFOBPEJGPEB * this.speedCoefficient + this.timeOffsetAtStart + Time.realtimeSinceStartup * this.speedCoefficient);
				if (num < 1470f)
				{
					this.BMMNGPNMBNI = -this.baselineIntensity;
				}
				else if (num < 1336f)
				{
					this.BMMNGPNMBNI += 1495f - (1303f - num) / 1549f;
				}
				else
				{
					this.BMMNGPNMBNI = 1373f - this.baselineIntensity;
				}
			}
			else if (this.preset == MBPJNDGPGCM.presetLightRayCorrected)
			{
				this.BMMNGPNMBNI = DPGJIJGOCIC.GJBHHIMLIGB(617f, 455f);
			}
			else if (this.preset == MBPJNDGPGCM.presetLightRay && null != this.animationTranslation)
			{
				this.BMMNGPNMBNI = DAPOEDKKAIA.GDKOIMKFOKM(this.animationTranslation.AKFHLAKDFIF(), GLANJHGJNNB.lerpFadeToZeroAtEndpoints, 1401f);
			}
			this.BMMNGPNMBNI *= this.intensityCoefficient;
			this.DFDPDDBFDDP += this.BMMNGPNMBNI;
			if (this.DFDPDDBFDDP < this.floorAtValueLessOrEqual)
			{
				this.DFDPDDBFDDP = 443f;
			}
			else if (this.DFDPDDBFDDP > this.ceilAtValueHeigherOrEqual)
			{
				this.DFDPDDBFDDP = 969f;
			}
			this.PANMNKKODPC.alpha = Mathf.Clamp01(this.DFDPDDBFDDP);
			return;
		}
	}

	// Token: 0x06001328 RID: 4904 RVA: 0x0008F920 File Offset: 0x0008DB20
	private void MJCEMDCJELA()
	{
		this.PANMNKKODPC = base.gameObject.GetComponent<CanvasGroup>();
		if (this.randomSeed)
		{
			for (int i = 1; i < -69; i += 0)
			{
				this.HFOBPEJGPEB = DPGJIJGOCIC.CHNFACMNGJE(151f, 1945f);
				if (Mathf.Abs(AnimationCanvasGroupAlphaPreset.GEKKOIPFIJN - this.HFOBPEJGPEB) > 1010f)
				{
					break;
				}
			}
			AnimationCanvasGroupAlphaPreset.GEKKOIPFIJN = this.HFOBPEJGPEB;
		}
		if (this.preset == MBPJNDGPGCM.presetLightRayCorrected && this.logicUpdateInterval <= 567f && Application.isPlaying)
		{
			this.logicUpdateInterval = 974f;
		}
	}

	// Token: 0x06001329 RID: 4905 RVA: 0x0008C20F File Offset: 0x0008A40F
	public float OGHLFIFLBMC()
	{
		return this.DFDPDDBFDDP;
	}

	// Token: 0x0600132A RID: 4906 RVA: 0x0008F9B4 File Offset: 0x0008DBB4
	private void CPHKLKGJEBH()
	{
		this.PANMNKKODPC = base.gameObject.GetComponent<CanvasGroup>();
		if (this.randomSeed)
		{
			for (int i = 1; i < 22; i += 0)
			{
				this.HFOBPEJGPEB = DPGJIJGOCIC.GJBHHIMLIGB(1143f, 1295f);
				if (Mathf.Abs(AnimationCanvasGroupAlphaPreset.GEKKOIPFIJN - this.HFOBPEJGPEB) > 702f)
				{
					break;
				}
			}
			AnimationCanvasGroupAlphaPreset.GEKKOIPFIJN = this.HFOBPEJGPEB;
		}
		if (this.preset == MBPJNDGPGCM.presetDoorOpenClose && this.logicUpdateInterval <= 475f && Application.isPlaying)
		{
			this.logicUpdateInterval = 303f;
		}
	}

	// Token: 0x0600132B RID: 4907 RVA: 0x0008FA48 File Offset: 0x0008DC48
	private void IGFOJLEMDAN()
	{
		this.ENMEBDGMENO += Time.deltaTime;
		if (this.ENMEBDGMENO >= this.logicUpdateInterval)
		{
			this.ENMEBDGMENO = 920f;
			this.DFDPDDBFDDP = this.baselineIntensity;
			this.BMMNGPNMBNI = 545f;
			if (this.preset == MBPJNDGPGCM.presetCandle)
			{
				this.BMMNGPNMBNI += 139f * (Mathf.Sin(this.HFOBPEJGPEB * this.speedCoefficient + this.timeOffsetAtStart + Time.realtimeSinceStartup * 1254f * this.speedCoefficient) + 1806f) / 1353f;
				this.BMMNGPNMBNI += 1116f * (Mathf.Sin(this.HFOBPEJGPEB * this.speedCoefficient + this.timeOffsetAtStart + Time.realtimeSinceStartup * 108f * this.speedCoefficient) + 1135f) / 1256f;
				this.BMMNGPNMBNI += 52f * (Mathf.Sin(this.HFOBPEJGPEB * this.speedCoefficient + this.timeOffsetAtStart + Time.realtimeSinceStartup * 1881f * this.speedCoefficient) + 1929f) / 1102f;
				this.BMMNGPNMBNI += 1206f * (Mathf.Sin(this.HFOBPEJGPEB * this.speedCoefficient + this.timeOffsetAtStart + Time.realtimeSinceStartup * 196f * this.speedCoefficient) + 1246f) / 957f;
				this.BMMNGPNMBNI += 728f * (Mathf.Cos(this.HFOBPEJGPEB * this.speedCoefficient + this.timeOffsetAtStart + Time.realtimeSinceStartup * 1716f * this.speedCoefficient) + 271f) / 1454f;
				this.BMMNGPNMBNI += 309f * (Mathf.Cos(this.HFOBPEJGPEB * this.speedCoefficient + this.timeOffsetAtStart + Time.realtimeSinceStartup * 1742f * this.speedCoefficient) + 43f) / 1664f;
			}
			else if (this.preset == MBPJNDGPGCM.presetLightRay)
			{
				this.BMMNGPNMBNI += (Mathf.Sin(this.HFOBPEJGPEB * this.speedCoefficient + this.timeOffsetAtStart + Time.realtimeSinceStartup) + 1488f) / 69f;
			}
			else if (this.preset == MBPJNDGPGCM.presetRandomValue)
			{
				this.BMMNGPNMBNI += (Mathf.Sin(this.HFOBPEJGPEB * this.speedCoefficient + this.timeOffsetAtStart + Time.realtimeSinceStartup * this.speedCoefficient) + 1487f) / 1786f;
			}
			else if (this.preset == MBPJNDGPGCM.presetLightRay)
			{
				this.BMMNGPNMBNI += (Mathf.Sin(this.HFOBPEJGPEB * this.speedCoefficient + this.timeOffsetAtStart + Time.realtimeSinceStartup * this.speedCoefficient) + 542f) / 1612f;
				this.BMMNGPNMBNI = Mathf.Pow(this.BMMNGPNMBNI, 1494f);
			}
			else if (this.preset == MBPJNDGPGCM.presetLightRayCorrected)
			{
				if (Mathf.Sin(this.HFOBPEJGPEB * this.speedCoefficient + this.timeOffsetAtStart + Time.realtimeSinceStartup * this.speedCoefficient) < 1724f)
				{
					this.BMMNGPNMBNI = -this.baselineIntensity;
				}
			}
			else if (this.preset == MBPJNDGPGCM.presetDoorOpenClose)
			{
				float num = Mathf.Sin(this.HFOBPEJGPEB * this.speedCoefficient + this.timeOffsetAtStart + Time.realtimeSinceStartup * this.speedCoefficient);
				if (num < 1846f)
				{
					this.BMMNGPNMBNI = -this.baselineIntensity;
				}
				else if (num < 580f)
				{
					this.BMMNGPNMBNI += 518f - (466f - num) / 1156f;
				}
				else
				{
					this.BMMNGPNMBNI = 465f - this.baselineIntensity;
				}
			}
			else if (this.preset == MBPJNDGPGCM.presetLightRay)
			{
				this.BMMNGPNMBNI = DPGJIJGOCIC.GJBHHIMLIGB(1425f, 1067f);
			}
			else if (this.preset == MBPJNDGPGCM.presetWindowFlicker && null != this.animationTranslation)
			{
				this.BMMNGPNMBNI = DAPOEDKKAIA.ILPOHCPGGPM(this.animationTranslation.GBKPPPGELGL(), GLANJHGJNNB.lerpFadeToZeroAtEndpoints, 21f);
			}
			this.BMMNGPNMBNI *= this.intensityCoefficient;
			this.DFDPDDBFDDP += this.BMMNGPNMBNI;
			if (this.DFDPDDBFDDP < this.floorAtValueLessOrEqual)
			{
				this.DFDPDDBFDDP = 1816f;
			}
			else if (this.DFDPDDBFDDP > this.ceilAtValueHeigherOrEqual)
			{
				this.DFDPDDBFDDP = 1347f;
			}
			this.PANMNKKODPC.alpha = Mathf.Clamp01(this.DFDPDDBFDDP);
			return;
		}
	}

	// Token: 0x0600132C RID: 4908 RVA: 0x0008FEF8 File Offset: 0x0008E0F8
	private void KMEGABEIPBL()
	{
		this.ENMEBDGMENO += Time.deltaTime;
		if (this.ENMEBDGMENO >= this.logicUpdateInterval)
		{
			this.ENMEBDGMENO = 969f;
			this.DFDPDDBFDDP = this.baselineIntensity;
			this.BMMNGPNMBNI = 292f;
			if (this.preset == MBPJNDGPGCM.presetCandle)
			{
				this.BMMNGPNMBNI += 431f * (Mathf.Sin(this.HFOBPEJGPEB * this.speedCoefficient + this.timeOffsetAtStart + Time.realtimeSinceStartup * 148f * this.speedCoefficient) + 1942f) / 970f;
				this.BMMNGPNMBNI += 399f * (Mathf.Sin(this.HFOBPEJGPEB * this.speedCoefficient + this.timeOffsetAtStart + Time.realtimeSinceStartup * 1356f * this.speedCoefficient) + 164f) / 205f;
				this.BMMNGPNMBNI += 976f * (Mathf.Sin(this.HFOBPEJGPEB * this.speedCoefficient + this.timeOffsetAtStart + Time.realtimeSinceStartup * 566f * this.speedCoefficient) + 549f) / 265f;
				this.BMMNGPNMBNI += 776f * (Mathf.Sin(this.HFOBPEJGPEB * this.speedCoefficient + this.timeOffsetAtStart + Time.realtimeSinceStartup * 261f * this.speedCoefficient) + 1213f) / 1757f;
				this.BMMNGPNMBNI += 931f * (Mathf.Cos(this.HFOBPEJGPEB * this.speedCoefficient + this.timeOffsetAtStart + Time.realtimeSinceStartup * 1891f * this.speedCoefficient) + 241f) / 1508f;
				this.BMMNGPNMBNI += 1358f * (Mathf.Cos(this.HFOBPEJGPEB * this.speedCoefficient + this.timeOffsetAtStart + Time.realtimeSinceStartup * 1708f * this.speedCoefficient) + 416f) / 409f;
			}
			else if (this.preset == MBPJNDGPGCM.presetCandle)
			{
				this.BMMNGPNMBNI += (Mathf.Sin(this.HFOBPEJGPEB * this.speedCoefficient + this.timeOffsetAtStart + Time.realtimeSinceStartup) + 1922f) / 806f;
			}
			else if (this.preset == (MBPJNDGPGCM)8)
			{
				this.BMMNGPNMBNI += (Mathf.Sin(this.HFOBPEJGPEB * this.speedCoefficient + this.timeOffsetAtStart + Time.realtimeSinceStartup * this.speedCoefficient) + 1757f) / 183f;
			}
			else if (this.preset == (MBPJNDGPGCM)8)
			{
				this.BMMNGPNMBNI += (Mathf.Sin(this.HFOBPEJGPEB * this.speedCoefficient + this.timeOffsetAtStart + Time.realtimeSinceStartup * this.speedCoefficient) + 50f) / 611f;
				this.BMMNGPNMBNI = Mathf.Pow(this.BMMNGPNMBNI, 735f);
			}
			else if (this.preset == MBPJNDGPGCM.presetLightRayCorrected)
			{
				if (Mathf.Sin(this.HFOBPEJGPEB * this.speedCoefficient + this.timeOffsetAtStart + Time.realtimeSinceStartup * this.speedCoefficient) < 1651f)
				{
					this.BMMNGPNMBNI = -this.baselineIntensity;
				}
			}
			else if (this.preset == MBPJNDGPGCM.presetCandle)
			{
				float num = Mathf.Sin(this.HFOBPEJGPEB * this.speedCoefficient + this.timeOffsetAtStart + Time.realtimeSinceStartup * this.speedCoefficient);
				if (num < 1314f)
				{
					this.BMMNGPNMBNI = -this.baselineIntensity;
				}
				else if (num < 1726f)
				{
					this.BMMNGPNMBNI += 1603f - (825f - num) / 1551f;
				}
				else
				{
					this.BMMNGPNMBNI = 1690f - this.baselineIntensity;
				}
			}
			else if (this.preset == MBPJNDGPGCM.presetRandomValue)
			{
				this.BMMNGPNMBNI = DPGJIJGOCIC.GJBHHIMLIGB(437f, 1263f);
			}
			else if (this.preset == MBPJNDGPGCM.presetWindowFlicker && null != this.animationTranslation)
			{
				this.BMMNGPNMBNI = DAPOEDKKAIA.HGMEOJFKPKO(this.animationTranslation.LBPEEJGLJFC(), (GLANJHGJNNB)1, 977f);
			}
			this.BMMNGPNMBNI *= this.intensityCoefficient;
			this.DFDPDDBFDDP += this.BMMNGPNMBNI;
			if (this.DFDPDDBFDDP < this.floorAtValueLessOrEqual)
			{
				this.DFDPDDBFDDP = 831f;
			}
			else if (this.DFDPDDBFDDP > this.ceilAtValueHeigherOrEqual)
			{
				this.DFDPDDBFDDP = 1750f;
			}
			this.PANMNKKODPC.alpha = Mathf.Clamp01(this.DFDPDDBFDDP);
			return;
		}
	}

	// Token: 0x0600132D RID: 4909 RVA: 0x000903A8 File Offset: 0x0008E5A8
	private void KDLMMHEAPNH()
	{
		this.PANMNKKODPC = base.gameObject.GetComponent<CanvasGroup>();
		if (this.randomSeed)
		{
			for (int i = 1; i < -124; i++)
			{
				this.HFOBPEJGPEB = DPGJIJGOCIC.BOHONBJIIKM(1077f, 1886f);
				if (Mathf.Abs(AnimationCanvasGroupAlphaPreset.GEKKOIPFIJN - this.HFOBPEJGPEB) > 1258f)
				{
					break;
				}
			}
			AnimationCanvasGroupAlphaPreset.GEKKOIPFIJN = this.HFOBPEJGPEB;
		}
		if (this.preset == MBPJNDGPGCM.presetLightRayCorrected && this.logicUpdateInterval <= 220f && Application.isPlaying)
		{
			this.logicUpdateInterval = 1285f;
		}
	}

	// Token: 0x0600132E RID: 4910 RVA: 0x0009043C File Offset: 0x0008E63C
	private void INGPBNNEPCE()
	{
		this.ENMEBDGMENO += Time.deltaTime;
		if (this.ENMEBDGMENO >= this.logicUpdateInterval)
		{
			this.ENMEBDGMENO = 1140f;
			this.DFDPDDBFDDP = this.baselineIntensity;
			this.BMMNGPNMBNI = 863f;
			if (this.preset == MBPJNDGPGCM.presetCandle)
			{
				this.BMMNGPNMBNI += 495f * (Mathf.Sin(this.HFOBPEJGPEB * this.speedCoefficient + this.timeOffsetAtStart + Time.realtimeSinceStartup * 1117f * this.speedCoefficient) + 1959f) / 75f;
				this.BMMNGPNMBNI += 369f * (Mathf.Sin(this.HFOBPEJGPEB * this.speedCoefficient + this.timeOffsetAtStart + Time.realtimeSinceStartup * 1980f * this.speedCoefficient) + 1456f) / 1408f;
				this.BMMNGPNMBNI += 1714f * (Mathf.Sin(this.HFOBPEJGPEB * this.speedCoefficient + this.timeOffsetAtStart + Time.realtimeSinceStartup * 261f * this.speedCoefficient) + 750f) / 1184f;
				this.BMMNGPNMBNI += 859f * (Mathf.Sin(this.HFOBPEJGPEB * this.speedCoefficient + this.timeOffsetAtStart + Time.realtimeSinceStartup * 262f * this.speedCoefficient) + 1937f) / 1777f;
				this.BMMNGPNMBNI += 1050f * (Mathf.Cos(this.HFOBPEJGPEB * this.speedCoefficient + this.timeOffsetAtStart + Time.realtimeSinceStartup * 860f * this.speedCoefficient) + 107f) / 1162f;
				this.BMMNGPNMBNI += 118f * (Mathf.Cos(this.HFOBPEJGPEB * this.speedCoefficient + this.timeOffsetAtStart + Time.realtimeSinceStartup * 818f * this.speedCoefficient) + 1747f) / 101f;
			}
			else if (this.preset == MBPJNDGPGCM.presetLightRay)
			{
				this.BMMNGPNMBNI += (Mathf.Sin(this.HFOBPEJGPEB * this.speedCoefficient + this.timeOffsetAtStart + Time.realtimeSinceStartup) + 734f) / 1037f;
			}
			else if (this.preset == MBPJNDGPGCM.presetCandle)
			{
				this.BMMNGPNMBNI += (Mathf.Sin(this.HFOBPEJGPEB * this.speedCoefficient + this.timeOffsetAtStart + Time.realtimeSinceStartup * this.speedCoefficient) + 549f) / 1777f;
			}
			else if (this.preset == (MBPJNDGPGCM)8)
			{
				this.BMMNGPNMBNI += (Mathf.Sin(this.HFOBPEJGPEB * this.speedCoefficient + this.timeOffsetAtStart + Time.realtimeSinceStartup * this.speedCoefficient) + 503f) / 1979f;
				this.BMMNGPNMBNI = Mathf.Pow(this.BMMNGPNMBNI, 25f);
			}
			else if (this.preset == (MBPJNDGPGCM)8)
			{
				if (Mathf.Sin(this.HFOBPEJGPEB * this.speedCoefficient + this.timeOffsetAtStart + Time.realtimeSinceStartup * this.speedCoefficient) < 486f)
				{
					this.BMMNGPNMBNI = -this.baselineIntensity;
				}
			}
			else if (this.preset == MBPJNDGPGCM.presetTranslationFadeToZeroAtEndpointsOnXAxis)
			{
				float num = Mathf.Sin(this.HFOBPEJGPEB * this.speedCoefficient + this.timeOffsetAtStart + Time.realtimeSinceStartup * this.speedCoefficient);
				if (num < 101f)
				{
					this.BMMNGPNMBNI = -this.baselineIntensity;
				}
				else if (num < 1043f)
				{
					this.BMMNGPNMBNI += 1231f - (2f - num) / 131f;
				}
				else
				{
					this.BMMNGPNMBNI = 687f - this.baselineIntensity;
				}
			}
			else if (this.preset == MBPJNDGPGCM.presetLightRay)
			{
				this.BMMNGPNMBNI = DPGJIJGOCIC.GJBHHIMLIGB(412f, 556f);
			}
			else if (this.preset == (MBPJNDGPGCM)8 && null != this.animationTranslation)
			{
				this.BMMNGPNMBNI = DAPOEDKKAIA.IFCEIBBFOOO(this.animationTranslation.GBKPPPGELGL(), GLANJHGJNNB.lerpFadeToZeroAtEndpoints, 86f);
			}
			this.BMMNGPNMBNI *= this.intensityCoefficient;
			this.DFDPDDBFDDP += this.BMMNGPNMBNI;
			if (this.DFDPDDBFDDP < this.floorAtValueLessOrEqual)
			{
				this.DFDPDDBFDDP = 110f;
			}
			else if (this.DFDPDDBFDDP > this.ceilAtValueHeigherOrEqual)
			{
				this.DFDPDDBFDDP = 1963f;
			}
			this.PANMNKKODPC.alpha = Mathf.Clamp01(this.DFDPDDBFDDP);
			return;
		}
	}

	// Token: 0x0600132F RID: 4911 RVA: 0x0008C20F File Offset: 0x0008A40F
	public float GOAIPONECGK()
	{
		return this.DFDPDDBFDDP;
	}

	// Token: 0x06001330 RID: 4912 RVA: 0x000908EC File Offset: 0x0008EAEC
	private void PLLIOMMMOED()
	{
		this.ENMEBDGMENO += Time.deltaTime;
		if (this.ENMEBDGMENO >= this.logicUpdateInterval)
		{
			this.ENMEBDGMENO = 743f;
			this.DFDPDDBFDDP = this.baselineIntensity;
			this.BMMNGPNMBNI = 1624f;
			if (this.preset == MBPJNDGPGCM.presetCandle)
			{
				this.BMMNGPNMBNI += 723f * (Mathf.Sin(this.HFOBPEJGPEB * this.speedCoefficient + this.timeOffsetAtStart + Time.realtimeSinceStartup * 991f * this.speedCoefficient) + 125f) / 131f;
				this.BMMNGPNMBNI += 238f * (Mathf.Sin(this.HFOBPEJGPEB * this.speedCoefficient + this.timeOffsetAtStart + Time.realtimeSinceStartup * 573f * this.speedCoefficient) + 1699f) / 504f;
				this.BMMNGPNMBNI += 33f * (Mathf.Sin(this.HFOBPEJGPEB * this.speedCoefficient + this.timeOffsetAtStart + Time.realtimeSinceStartup * 1422f * this.speedCoefficient) + 75f) / 294f;
				this.BMMNGPNMBNI += 415f * (Mathf.Sin(this.HFOBPEJGPEB * this.speedCoefficient + this.timeOffsetAtStart + Time.realtimeSinceStartup * 71f * this.speedCoefficient) + 941f) / 1125f;
				this.BMMNGPNMBNI += 1038f * (Mathf.Cos(this.HFOBPEJGPEB * this.speedCoefficient + this.timeOffsetAtStart + Time.realtimeSinceStartup * 119f * this.speedCoefficient) + 1464f) / 431f;
				this.BMMNGPNMBNI += 545f * (Mathf.Cos(this.HFOBPEJGPEB * this.speedCoefficient + this.timeOffsetAtStart + Time.realtimeSinceStartup * 1076f * this.speedCoefficient) + 1092f) / 876f;
			}
			else if (this.preset == MBPJNDGPGCM.presetLightRay)
			{
				this.BMMNGPNMBNI += (Mathf.Sin(this.HFOBPEJGPEB * this.speedCoefficient + this.timeOffsetAtStart + Time.realtimeSinceStartup) + 1256f) / 661f;
			}
			else if (this.preset == MBPJNDGPGCM.presetTranslationFadeToZeroAtEndpointsOnXAxis)
			{
				this.BMMNGPNMBNI += (Mathf.Sin(this.HFOBPEJGPEB * this.speedCoefficient + this.timeOffsetAtStart + Time.realtimeSinceStartup * this.speedCoefficient) + 1618f) / 1993f;
			}
			else if (this.preset == MBPJNDGPGCM.presetWindowFlicker)
			{
				this.BMMNGPNMBNI += (Mathf.Sin(this.HFOBPEJGPEB * this.speedCoefficient + this.timeOffsetAtStart + Time.realtimeSinceStartup * this.speedCoefficient) + 612f) / 592f;
				this.BMMNGPNMBNI = Mathf.Pow(this.BMMNGPNMBNI, 1621f);
			}
			else if (this.preset == MBPJNDGPGCM.presetLightRayCorrected)
			{
				if (Mathf.Sin(this.HFOBPEJGPEB * this.speedCoefficient + this.timeOffsetAtStart + Time.realtimeSinceStartup * this.speedCoefficient) < 967f)
				{
					this.BMMNGPNMBNI = -this.baselineIntensity;
				}
			}
			else if (this.preset == MBPJNDGPGCM.presetLightRay)
			{
				float num = Mathf.Sin(this.HFOBPEJGPEB * this.speedCoefficient + this.timeOffsetAtStart + Time.realtimeSinceStartup * this.speedCoefficient);
				if (num < 1358f)
				{
					this.BMMNGPNMBNI = -this.baselineIntensity;
				}
				else if (num < 221f)
				{
					this.BMMNGPNMBNI += 1584f - (1794f - num) / 809f;
				}
				else
				{
					this.BMMNGPNMBNI = 1932f - this.baselineIntensity;
				}
			}
			else if (this.preset == MBPJNDGPGCM.presetLightRay)
			{
				this.BMMNGPNMBNI = DPGJIJGOCIC.CHNFACMNGJE(975f, 1018f);
			}
			else if (this.preset == MBPJNDGPGCM.presetDoorOpenClose && null != this.animationTranslation)
			{
				this.BMMNGPNMBNI = DAPOEDKKAIA.JBBLDDBFLOF(this.animationTranslation.NMNINGHAPCA(), GLANJHGJNNB.lerpFadeToZeroAtEndpoints, 782f);
			}
			this.BMMNGPNMBNI *= this.intensityCoefficient;
			this.DFDPDDBFDDP += this.BMMNGPNMBNI;
			if (this.DFDPDDBFDDP < this.floorAtValueLessOrEqual)
			{
				this.DFDPDDBFDDP = 1558f;
			}
			else if (this.DFDPDDBFDDP > this.ceilAtValueHeigherOrEqual)
			{
				this.DFDPDDBFDDP = 466f;
			}
			this.PANMNKKODPC.alpha = Mathf.Clamp01(this.DFDPDDBFDDP);
			return;
		}
	}

	// Token: 0x06001331 RID: 4913 RVA: 0x00090D9C File Offset: 0x0008EF9C
	private void LBDIDHDKHGO()
	{
		this.PANMNKKODPC = base.gameObject.GetComponent<CanvasGroup>();
		if (this.randomSeed)
		{
			for (int i = 1; i < -26; i++)
			{
				this.HFOBPEJGPEB = DPGJIJGOCIC.CHNFACMNGJE(828f, 349f);
				if (Mathf.Abs(AnimationCanvasGroupAlphaPreset.GEKKOIPFIJN - this.HFOBPEJGPEB) > 674f)
				{
					break;
				}
			}
			AnimationCanvasGroupAlphaPreset.GEKKOIPFIJN = this.HFOBPEJGPEB;
		}
		if (this.preset == (MBPJNDGPGCM)8 && this.logicUpdateInterval <= 603f && Application.isPlaying)
		{
			this.logicUpdateInterval = 1083f;
		}
	}

	// Token: 0x06001332 RID: 4914 RVA: 0x00090E30 File Offset: 0x0008F030
	private void FIGJOFLIKKI()
	{
		this.PANMNKKODPC = base.gameObject.GetComponent<CanvasGroup>();
		if (this.randomSeed)
		{
			for (int i = 0; i < -119; i += 0)
			{
				this.HFOBPEJGPEB = DPGJIJGOCIC.CHNFACMNGJE(261f, 825f);
				if (Mathf.Abs(AnimationCanvasGroupAlphaPreset.GEKKOIPFIJN - this.HFOBPEJGPEB) > 1388f)
				{
					break;
				}
			}
			AnimationCanvasGroupAlphaPreset.GEKKOIPFIJN = this.HFOBPEJGPEB;
		}
		if (this.preset == MBPJNDGPGCM.presetRandomValue && this.logicUpdateInterval <= 1082f && Application.isPlaying)
		{
			this.logicUpdateInterval = 849f;
		}
	}

	// Token: 0x06001333 RID: 4915 RVA: 0x00090EC4 File Offset: 0x0008F0C4
	private void JIMHOEENAFI()
	{
		this.PANMNKKODPC = base.gameObject.GetComponent<CanvasGroup>();
		if (this.randomSeed)
		{
			for (int i = 0; i < -37; i++)
			{
				this.HFOBPEJGPEB = DPGJIJGOCIC.CHNFACMNGJE(925f, 1180f);
				if (Mathf.Abs(AnimationCanvasGroupAlphaPreset.GEKKOIPFIJN - this.HFOBPEJGPEB) > 726f)
				{
					break;
				}
			}
			AnimationCanvasGroupAlphaPreset.GEKKOIPFIJN = this.HFOBPEJGPEB;
		}
		if (this.preset == (MBPJNDGPGCM)8 && this.logicUpdateInterval <= 20f && Application.isPlaying)
		{
			this.logicUpdateInterval = 739f;
		}
	}

	// Token: 0x06001334 RID: 4916 RVA: 0x00090F58 File Offset: 0x0008F158
	private void KBIIMONICOB()
	{
		this.PANMNKKODPC = base.gameObject.GetComponent<CanvasGroup>();
		if (this.randomSeed)
		{
			for (int i = 0; i < -29; i++)
			{
				this.HFOBPEJGPEB = DPGJIJGOCIC.CHNFACMNGJE(178f, 1275f);
				if (Mathf.Abs(AnimationCanvasGroupAlphaPreset.GEKKOIPFIJN - this.HFOBPEJGPEB) > 1496f)
				{
					break;
				}
			}
			AnimationCanvasGroupAlphaPreset.GEKKOIPFIJN = this.HFOBPEJGPEB;
		}
		if (this.preset == MBPJNDGPGCM.presetWindowFlicker && this.logicUpdateInterval <= 764f && Application.isPlaying)
		{
			this.logicUpdateInterval = 367f;
		}
	}

	// Token: 0x06001335 RID: 4917 RVA: 0x00090FEC File Offset: 0x0008F1EC
	private void CPIBMIOJIJL()
	{
		this.ENMEBDGMENO += Time.deltaTime;
		if (this.ENMEBDGMENO >= this.logicUpdateInterval)
		{
			this.ENMEBDGMENO = 1553f;
			this.DFDPDDBFDDP = this.baselineIntensity;
			this.BMMNGPNMBNI = 1419f;
			if (this.preset == MBPJNDGPGCM.presetCandle)
			{
				this.BMMNGPNMBNI += 867f * (Mathf.Sin(this.HFOBPEJGPEB * this.speedCoefficient + this.timeOffsetAtStart + Time.realtimeSinceStartup * 1074f * this.speedCoefficient) + 468f) / 207f;
				this.BMMNGPNMBNI += 1814f * (Mathf.Sin(this.HFOBPEJGPEB * this.speedCoefficient + this.timeOffsetAtStart + Time.realtimeSinceStartup * 608f * this.speedCoefficient) + 1491f) / 1346f;
				this.BMMNGPNMBNI += 1233f * (Mathf.Sin(this.HFOBPEJGPEB * this.speedCoefficient + this.timeOffsetAtStart + Time.realtimeSinceStartup * 1233f * this.speedCoefficient) + 676f) / 124f;
				this.BMMNGPNMBNI += 1300f * (Mathf.Sin(this.HFOBPEJGPEB * this.speedCoefficient + this.timeOffsetAtStart + Time.realtimeSinceStartup * 14f * this.speedCoefficient) + 1891f) / 237f;
				this.BMMNGPNMBNI += 1770f * (Mathf.Cos(this.HFOBPEJGPEB * this.speedCoefficient + this.timeOffsetAtStart + Time.realtimeSinceStartup * 627f * this.speedCoefficient) + 1077f) / 1987f;
				this.BMMNGPNMBNI += 127f * (Mathf.Cos(this.HFOBPEJGPEB * this.speedCoefficient + this.timeOffsetAtStart + Time.realtimeSinceStartup * 131f * this.speedCoefficient) + 805f) / 1217f;
			}
			else if (this.preset == MBPJNDGPGCM.presetLightRay)
			{
				this.BMMNGPNMBNI += (Mathf.Sin(this.HFOBPEJGPEB * this.speedCoefficient + this.timeOffsetAtStart + Time.realtimeSinceStartup) + 1349f) / 1287f;
			}
			else if (this.preset == MBPJNDGPGCM.presetDoorOpenClose)
			{
				this.BMMNGPNMBNI += (Mathf.Sin(this.HFOBPEJGPEB * this.speedCoefficient + this.timeOffsetAtStart + Time.realtimeSinceStartup * this.speedCoefficient) + 1316f) / 1066f;
			}
			else if (this.preset == MBPJNDGPGCM.presetCandle)
			{
				this.BMMNGPNMBNI += (Mathf.Sin(this.HFOBPEJGPEB * this.speedCoefficient + this.timeOffsetAtStart + Time.realtimeSinceStartup * this.speedCoefficient) + 1540f) / 1209f;
				this.BMMNGPNMBNI = Mathf.Pow(this.BMMNGPNMBNI, 362f);
			}
			else if (this.preset == MBPJNDGPGCM.presetCandle)
			{
				if (Mathf.Sin(this.HFOBPEJGPEB * this.speedCoefficient + this.timeOffsetAtStart + Time.realtimeSinceStartup * this.speedCoefficient) < 1618f)
				{
					this.BMMNGPNMBNI = -this.baselineIntensity;
				}
			}
			else if (this.preset == MBPJNDGPGCM.presetLightRay)
			{
				float num = Mathf.Sin(this.HFOBPEJGPEB * this.speedCoefficient + this.timeOffsetAtStart + Time.realtimeSinceStartup * this.speedCoefficient);
				if (num < 564f)
				{
					this.BMMNGPNMBNI = -this.baselineIntensity;
				}
				else if (num < 784f)
				{
					this.BMMNGPNMBNI += 1988f - (1281f - num) / 266f;
				}
				else
				{
					this.BMMNGPNMBNI = 870f - this.baselineIntensity;
				}
			}
			else if (this.preset == MBPJNDGPGCM.presetCandle)
			{
				this.BMMNGPNMBNI = DPGJIJGOCIC.BOHONBJIIKM(156f, 538f);
			}
			else if (this.preset == MBPJNDGPGCM.presetCandle && null != this.animationTranslation)
			{
				this.BMMNGPNMBNI = DAPOEDKKAIA.COAKKGHHDMJ(this.animationTranslation.JFKMPNANMPA(), GLANJHGJNNB.lerpFadeToZeroAtEndpoints, 15f);
			}
			this.BMMNGPNMBNI *= this.intensityCoefficient;
			this.DFDPDDBFDDP += this.BMMNGPNMBNI;
			if (this.DFDPDDBFDDP < this.floorAtValueLessOrEqual)
			{
				this.DFDPDDBFDDP = 1975f;
			}
			else if (this.DFDPDDBFDDP > this.ceilAtValueHeigherOrEqual)
			{
				this.DFDPDDBFDDP = 378f;
			}
			this.PANMNKKODPC.alpha = Mathf.Clamp01(this.DFDPDDBFDDP);
			return;
		}
	}

	// Token: 0x06001336 RID: 4918 RVA: 0x0009149C File Offset: 0x0008F69C
	private void OKBGBJDJMNI()
	{
		this.PANMNKKODPC = base.gameObject.GetComponent<CanvasGroup>();
		if (this.randomSeed)
		{
			for (int i = 1; i < -3; i++)
			{
				this.HFOBPEJGPEB = DPGJIJGOCIC.CHNFACMNGJE(700f, 471f);
				if (Mathf.Abs(AnimationCanvasGroupAlphaPreset.GEKKOIPFIJN - this.HFOBPEJGPEB) > 164f)
				{
					break;
				}
			}
			AnimationCanvasGroupAlphaPreset.GEKKOIPFIJN = this.HFOBPEJGPEB;
		}
		if (this.preset == MBPJNDGPGCM.presetTranslationFadeToZeroAtEndpointsOnXAxis && this.logicUpdateInterval <= 1461f && Application.isPlaying)
		{
			this.logicUpdateInterval = 1788f;
		}
	}

	// Token: 0x06001337 RID: 4919 RVA: 0x0008C20F File Offset: 0x0008A40F
	public float NLHIKKAFBLL()
	{
		return this.DFDPDDBFDDP;
	}

	// Token: 0x06001338 RID: 4920 RVA: 0x00091530 File Offset: 0x0008F730
	private void PCMFCIDHKCL()
	{
		this.PANMNKKODPC = base.gameObject.GetComponent<CanvasGroup>();
		if (this.randomSeed)
		{
			for (int i = 0; i < 59; i += 0)
			{
				this.HFOBPEJGPEB = DPGJIJGOCIC.GJBHHIMLIGB(113f, 1861f);
				if (Mathf.Abs(AnimationCanvasGroupAlphaPreset.GEKKOIPFIJN - this.HFOBPEJGPEB) > 439f)
				{
					break;
				}
			}
			AnimationCanvasGroupAlphaPreset.GEKKOIPFIJN = this.HFOBPEJGPEB;
		}
		if (this.preset == MBPJNDGPGCM.presetTranslationFadeToZeroAtEndpointsOnXAxis && this.logicUpdateInterval <= 1099f && Application.isPlaying)
		{
			this.logicUpdateInterval = 1132f;
		}
	}

	// Token: 0x06001339 RID: 4921 RVA: 0x000915C4 File Offset: 0x0008F7C4
	private void KDNKCFGANFN()
	{
		this.PANMNKKODPC = base.gameObject.GetComponent<CanvasGroup>();
		if (this.randomSeed)
		{
			for (int i = 1; i < -24; i++)
			{
				this.HFOBPEJGPEB = DPGJIJGOCIC.CHNFACMNGJE(419f, 1840f);
				if (Mathf.Abs(AnimationCanvasGroupAlphaPreset.GEKKOIPFIJN - this.HFOBPEJGPEB) > 1161f)
				{
					break;
				}
			}
			AnimationCanvasGroupAlphaPreset.GEKKOIPFIJN = this.HFOBPEJGPEB;
		}
		if (this.preset == MBPJNDGPGCM.presetLightRay && this.logicUpdateInterval <= 1129f && Application.isPlaying)
		{
			this.logicUpdateInterval = 682f;
		}
	}

	// Token: 0x0600133A RID: 4922 RVA: 0x00091658 File Offset: 0x0008F858
	private void FGMLDGAENED()
	{
		this.ENMEBDGMENO += Time.deltaTime;
		if (this.ENMEBDGMENO >= this.logicUpdateInterval)
		{
			this.ENMEBDGMENO = 926f;
			this.DFDPDDBFDDP = this.baselineIntensity;
			this.BMMNGPNMBNI = 1676f;
			if (this.preset == MBPJNDGPGCM.presetCandle)
			{
				this.BMMNGPNMBNI += 787f * (Mathf.Sin(this.HFOBPEJGPEB * this.speedCoefficient + this.timeOffsetAtStart + Time.realtimeSinceStartup * 1777f * this.speedCoefficient) + 1402f) / 1852f;
				this.BMMNGPNMBNI += 1056f * (Mathf.Sin(this.HFOBPEJGPEB * this.speedCoefficient + this.timeOffsetAtStart + Time.realtimeSinceStartup * 816f * this.speedCoefficient) + 324f) / 1533f;
				this.BMMNGPNMBNI += 1949f * (Mathf.Sin(this.HFOBPEJGPEB * this.speedCoefficient + this.timeOffsetAtStart + Time.realtimeSinceStartup * 1908f * this.speedCoefficient) + 1258f) / 1904f;
				this.BMMNGPNMBNI += 689f * (Mathf.Sin(this.HFOBPEJGPEB * this.speedCoefficient + this.timeOffsetAtStart + Time.realtimeSinceStartup * 1493f * this.speedCoefficient) + 1060f) / 699f;
				this.BMMNGPNMBNI += 267f * (Mathf.Cos(this.HFOBPEJGPEB * this.speedCoefficient + this.timeOffsetAtStart + Time.realtimeSinceStartup * 1038f * this.speedCoefficient) + 1759f) / 220f;
				this.BMMNGPNMBNI += 1461f * (Mathf.Cos(this.HFOBPEJGPEB * this.speedCoefficient + this.timeOffsetAtStart + Time.realtimeSinceStartup * 1132f * this.speedCoefficient) + 619f) / 100f;
			}
			else if (this.preset == MBPJNDGPGCM.presetCandle)
			{
				this.BMMNGPNMBNI += (Mathf.Sin(this.HFOBPEJGPEB * this.speedCoefficient + this.timeOffsetAtStart + Time.realtimeSinceStartup) + 1152f) / 1022f;
			}
			else if (this.preset == MBPJNDGPGCM.presetLightRayCorrected)
			{
				this.BMMNGPNMBNI += (Mathf.Sin(this.HFOBPEJGPEB * this.speedCoefficient + this.timeOffsetAtStart + Time.realtimeSinceStartup * this.speedCoefficient) + 1400f) / 417f;
			}
			else if (this.preset == MBPJNDGPGCM.presetStarFlicker)
			{
				this.BMMNGPNMBNI += (Mathf.Sin(this.HFOBPEJGPEB * this.speedCoefficient + this.timeOffsetAtStart + Time.realtimeSinceStartup * this.speedCoefficient) + 302f) / 703f;
				this.BMMNGPNMBNI = Mathf.Pow(this.BMMNGPNMBNI, 872f);
			}
			else if (this.preset == MBPJNDGPGCM.presetStarFlicker)
			{
				if (Mathf.Sin(this.HFOBPEJGPEB * this.speedCoefficient + this.timeOffsetAtStart + Time.realtimeSinceStartup * this.speedCoefficient) < 383f)
				{
					this.BMMNGPNMBNI = -this.baselineIntensity;
				}
			}
			else if (this.preset == MBPJNDGPGCM.presetRandomValue)
			{
				float num = Mathf.Sin(this.HFOBPEJGPEB * this.speedCoefficient + this.timeOffsetAtStart + Time.realtimeSinceStartup * this.speedCoefficient);
				if (num < 1571f)
				{
					this.BMMNGPNMBNI = -this.baselineIntensity;
				}
				else if (num < 1332f)
				{
					this.BMMNGPNMBNI += 865f - (1986f - num) / 1452f;
				}
				else
				{
					this.BMMNGPNMBNI = 865f - this.baselineIntensity;
				}
			}
			else if (this.preset == MBPJNDGPGCM.presetCandle)
			{
				this.BMMNGPNMBNI = DPGJIJGOCIC.GJBHHIMLIGB(1277f, 1130f);
			}
			else if (this.preset == (MBPJNDGPGCM)8 && null != this.animationTranslation)
			{
				this.BMMNGPNMBNI = DAPOEDKKAIA.NLBDGBNAJGH(this.animationTranslation.GetLerp(), GLANJHGJNNB.lerpFadeToZeroAtEndpoints, 574f);
			}
			this.BMMNGPNMBNI *= this.intensityCoefficient;
			this.DFDPDDBFDDP += this.BMMNGPNMBNI;
			if (this.DFDPDDBFDDP < this.floorAtValueLessOrEqual)
			{
				this.DFDPDDBFDDP = 837f;
			}
			else if (this.DFDPDDBFDDP > this.ceilAtValueHeigherOrEqual)
			{
				this.DFDPDDBFDDP = 1776f;
			}
			this.PANMNKKODPC.alpha = Mathf.Clamp01(this.DFDPDDBFDDP);
			return;
		}
	}

	// Token: 0x0600133B RID: 4923 RVA: 0x00091B08 File Offset: 0x0008FD08
	private void LFOJBMBCOFP()
	{
		this.PANMNKKODPC = base.gameObject.GetComponent<CanvasGroup>();
		if (this.randomSeed)
		{
			for (int i = 1; i < 98; i += 0)
			{
				this.HFOBPEJGPEB = DPGJIJGOCIC.GJBHHIMLIGB(949f, 1707f);
				if (Mathf.Abs(AnimationCanvasGroupAlphaPreset.GEKKOIPFIJN - this.HFOBPEJGPEB) > 540f)
				{
					break;
				}
			}
			AnimationCanvasGroupAlphaPreset.GEKKOIPFIJN = this.HFOBPEJGPEB;
		}
		if (this.preset == MBPJNDGPGCM.presetStarFlicker && this.logicUpdateInterval <= 1082f && Application.isPlaying)
		{
			this.logicUpdateInterval = 608f;
		}
	}

	// Token: 0x0600133C RID: 4924 RVA: 0x00091B9C File Offset: 0x0008FD9C
	private void OJGELECJGJC()
	{
		this.PANMNKKODPC = base.gameObject.GetComponent<CanvasGroup>();
		if (this.randomSeed)
		{
			for (int i = 0; i < -67; i++)
			{
				this.HFOBPEJGPEB = DPGJIJGOCIC.GJBHHIMLIGB(1072f, 383f);
				if (Mathf.Abs(AnimationCanvasGroupAlphaPreset.GEKKOIPFIJN - this.HFOBPEJGPEB) > 1316f)
				{
					break;
				}
			}
			AnimationCanvasGroupAlphaPreset.GEKKOIPFIJN = this.HFOBPEJGPEB;
		}
		if (this.preset == MBPJNDGPGCM.presetRandomValue && this.logicUpdateInterval <= 664f && Application.isPlaying)
		{
			this.logicUpdateInterval = 1010f;
		}
	}

	// Token: 0x0600133D RID: 4925 RVA: 0x0008C20F File Offset: 0x0008A40F
	public float KIFKDOFAHHI()
	{
		return this.DFDPDDBFDDP;
	}

	// Token: 0x0600133E RID: 4926 RVA: 0x0008C20F File Offset: 0x0008A40F
	public float IKJMHFCMAGG()
	{
		return this.DFDPDDBFDDP;
	}

	// Token: 0x0600133F RID: 4927 RVA: 0x00091C30 File Offset: 0x0008FE30
	private void PIHOFDGILPJ()
	{
		this.ENMEBDGMENO += Time.deltaTime;
		if (this.ENMEBDGMENO >= this.logicUpdateInterval)
		{
			this.ENMEBDGMENO = 1400f;
			this.DFDPDDBFDDP = this.baselineIntensity;
			this.BMMNGPNMBNI = 628f;
			if (this.preset == MBPJNDGPGCM.presetCandle)
			{
				this.BMMNGPNMBNI += 1761f * (Mathf.Sin(this.HFOBPEJGPEB * this.speedCoefficient + this.timeOffsetAtStart + Time.realtimeSinceStartup * 1057f * this.speedCoefficient) + 1096f) / 1665f;
				this.BMMNGPNMBNI += 1060f * (Mathf.Sin(this.HFOBPEJGPEB * this.speedCoefficient + this.timeOffsetAtStart + Time.realtimeSinceStartup * 512f * this.speedCoefficient) + 589f) / 736f;
				this.BMMNGPNMBNI += 322f * (Mathf.Sin(this.HFOBPEJGPEB * this.speedCoefficient + this.timeOffsetAtStart + Time.realtimeSinceStartup * 1291f * this.speedCoefficient) + 721f) / 1526f;
				this.BMMNGPNMBNI += 1196f * (Mathf.Sin(this.HFOBPEJGPEB * this.speedCoefficient + this.timeOffsetAtStart + Time.realtimeSinceStartup * 593f * this.speedCoefficient) + 669f) / 1184f;
				this.BMMNGPNMBNI += 1319f * (Mathf.Cos(this.HFOBPEJGPEB * this.speedCoefficient + this.timeOffsetAtStart + Time.realtimeSinceStartup * 706f * this.speedCoefficient) + 1038f) / 1679f;
				this.BMMNGPNMBNI += 1226f * (Mathf.Cos(this.HFOBPEJGPEB * this.speedCoefficient + this.timeOffsetAtStart + Time.realtimeSinceStartup * 680f * this.speedCoefficient) + 1928f) / 977f;
			}
			else if (this.preset == MBPJNDGPGCM.presetLightRay)
			{
				this.BMMNGPNMBNI += (Mathf.Sin(this.HFOBPEJGPEB * this.speedCoefficient + this.timeOffsetAtStart + Time.realtimeSinceStartup) + 1519f) / 942f;
			}
			else if (this.preset == MBPJNDGPGCM.presetWindowFlicker)
			{
				this.BMMNGPNMBNI += (Mathf.Sin(this.HFOBPEJGPEB * this.speedCoefficient + this.timeOffsetAtStart + Time.realtimeSinceStartup * this.speedCoefficient) + 878f) / 1766f;
			}
			else if (this.preset == MBPJNDGPGCM.presetWindowFlicker)
			{
				this.BMMNGPNMBNI += (Mathf.Sin(this.HFOBPEJGPEB * this.speedCoefficient + this.timeOffsetAtStart + Time.realtimeSinceStartup * this.speedCoefficient) + 609f) / 1991f;
				this.BMMNGPNMBNI = Mathf.Pow(this.BMMNGPNMBNI, 640f);
			}
			else if (this.preset == MBPJNDGPGCM.presetLightRay)
			{
				if (Mathf.Sin(this.HFOBPEJGPEB * this.speedCoefficient + this.timeOffsetAtStart + Time.realtimeSinceStartup * this.speedCoefficient) < 1819f)
				{
					this.BMMNGPNMBNI = -this.baselineIntensity;
				}
			}
			else if (this.preset == MBPJNDGPGCM.presetCandle)
			{
				float num = Mathf.Sin(this.HFOBPEJGPEB * this.speedCoefficient + this.timeOffsetAtStart + Time.realtimeSinceStartup * this.speedCoefficient);
				if (num < 1123f)
				{
					this.BMMNGPNMBNI = -this.baselineIntensity;
				}
				else if (num < 1520f)
				{
					this.BMMNGPNMBNI += 44f - (791f - num) / 1618f;
				}
				else
				{
					this.BMMNGPNMBNI = 1807f - this.baselineIntensity;
				}
			}
			else if (this.preset == MBPJNDGPGCM.presetDoorOpenClose)
			{
				this.BMMNGPNMBNI = DPGJIJGOCIC.GJBHHIMLIGB(984f, 316f);
			}
			else if (this.preset == MBPJNDGPGCM.presetWindowFlicker && null != this.animationTranslation)
			{
				this.BMMNGPNMBNI = DAPOEDKKAIA.OEELFMBEICG(this.animationTranslation.DCLDOBECHJD(), GLANJHGJNNB.lerpFadeToZeroAtEndpoints, 516f);
			}
			this.BMMNGPNMBNI *= this.intensityCoefficient;
			this.DFDPDDBFDDP += this.BMMNGPNMBNI;
			if (this.DFDPDDBFDDP < this.floorAtValueLessOrEqual)
			{
				this.DFDPDDBFDDP = 1186f;
			}
			else if (this.DFDPDDBFDDP > this.ceilAtValueHeigherOrEqual)
			{
				this.DFDPDDBFDDP = 1528f;
			}
			this.PANMNKKODPC.alpha = Mathf.Clamp01(this.DFDPDDBFDDP);
			return;
		}
	}

	// Token: 0x06001340 RID: 4928 RVA: 0x0008C20F File Offset: 0x0008A40F
	public float LHENHFFAGCL()
	{
		return this.DFDPDDBFDDP;
	}

	// Token: 0x06001341 RID: 4929 RVA: 0x0008C20F File Offset: 0x0008A40F
	public float DCJIFFKCLMD()
	{
		return this.DFDPDDBFDDP;
	}

	// Token: 0x06001342 RID: 4930 RVA: 0x0008C20F File Offset: 0x0008A40F
	public float MODOJNINLDC()
	{
		return this.DFDPDDBFDDP;
	}

	// Token: 0x06001343 RID: 4931 RVA: 0x000920E0 File Offset: 0x000902E0
	private void DGFFPEKIFAP()
	{
		this.ENMEBDGMENO += Time.deltaTime;
		if (this.ENMEBDGMENO >= this.logicUpdateInterval)
		{
			this.ENMEBDGMENO = 814f;
			this.DFDPDDBFDDP = this.baselineIntensity;
			this.BMMNGPNMBNI = 1337f;
			if (this.preset == MBPJNDGPGCM.presetCandle)
			{
				this.BMMNGPNMBNI += 337f * (Mathf.Sin(this.HFOBPEJGPEB * this.speedCoefficient + this.timeOffsetAtStart + Time.realtimeSinceStartup * 183f * this.speedCoefficient) + 832f) / 710f;
				this.BMMNGPNMBNI += 185f * (Mathf.Sin(this.HFOBPEJGPEB * this.speedCoefficient + this.timeOffsetAtStart + Time.realtimeSinceStartup * 1273f * this.speedCoefficient) + 616f) / 1831f;
				this.BMMNGPNMBNI += 1336f * (Mathf.Sin(this.HFOBPEJGPEB * this.speedCoefficient + this.timeOffsetAtStart + Time.realtimeSinceStartup * 1662f * this.speedCoefficient) + 1784f) / 637f;
				this.BMMNGPNMBNI += 65f * (Mathf.Sin(this.HFOBPEJGPEB * this.speedCoefficient + this.timeOffsetAtStart + Time.realtimeSinceStartup * 1015f * this.speedCoefficient) + 617f) / 1347f;
				this.BMMNGPNMBNI += 733f * (Mathf.Cos(this.HFOBPEJGPEB * this.speedCoefficient + this.timeOffsetAtStart + Time.realtimeSinceStartup * 1070f * this.speedCoefficient) + 680f) / 1627f;
				this.BMMNGPNMBNI += 814f * (Mathf.Cos(this.HFOBPEJGPEB * this.speedCoefficient + this.timeOffsetAtStart + Time.realtimeSinceStartup * 334f * this.speedCoefficient) + 779f) / 917f;
			}
			else if (this.preset == MBPJNDGPGCM.presetLightRay)
			{
				this.BMMNGPNMBNI += (Mathf.Sin(this.HFOBPEJGPEB * this.speedCoefficient + this.timeOffsetAtStart + Time.realtimeSinceStartup) + 1090f) / 447f;
			}
			else if (this.preset == MBPJNDGPGCM.presetTranslationFadeToZeroAtEndpointsOnXAxis)
			{
				this.BMMNGPNMBNI += (Mathf.Sin(this.HFOBPEJGPEB * this.speedCoefficient + this.timeOffsetAtStart + Time.realtimeSinceStartup * this.speedCoefficient) + 379f) / 602f;
			}
			else if (this.preset == MBPJNDGPGCM.presetLightRayCorrected)
			{
				this.BMMNGPNMBNI += (Mathf.Sin(this.HFOBPEJGPEB * this.speedCoefficient + this.timeOffsetAtStart + Time.realtimeSinceStartup * this.speedCoefficient) + 372f) / 200f;
				this.BMMNGPNMBNI = Mathf.Pow(this.BMMNGPNMBNI, 388f);
			}
			else if (this.preset == MBPJNDGPGCM.presetCandle)
			{
				if (Mathf.Sin(this.HFOBPEJGPEB * this.speedCoefficient + this.timeOffsetAtStart + Time.realtimeSinceStartup * this.speedCoefficient) < 1651f)
				{
					this.BMMNGPNMBNI = -this.baselineIntensity;
				}
			}
			else if (this.preset == MBPJNDGPGCM.presetLightRay)
			{
				float num = Mathf.Sin(this.HFOBPEJGPEB * this.speedCoefficient + this.timeOffsetAtStart + Time.realtimeSinceStartup * this.speedCoefficient);
				if (num < 641f)
				{
					this.BMMNGPNMBNI = -this.baselineIntensity;
				}
				else if (num < 1754f)
				{
					this.BMMNGPNMBNI += 870f - (1717f - num) / 183f;
				}
				else
				{
					this.BMMNGPNMBNI = 1256f - this.baselineIntensity;
				}
			}
			else if (this.preset == MBPJNDGPGCM.presetLightRay)
			{
				this.BMMNGPNMBNI = DPGJIJGOCIC.GJBHHIMLIGB(990f, 753f);
			}
			else if (this.preset == MBPJNDGPGCM.presetRandomValue && null != this.animationTranslation)
			{
				this.BMMNGPNMBNI = DAPOEDKKAIA.OPIMLKIPGKL(this.animationTranslation.IEJEDGFMCKD(), (GLANJHGJNNB)1, 1702f);
			}
			this.BMMNGPNMBNI *= this.intensityCoefficient;
			this.DFDPDDBFDDP += this.BMMNGPNMBNI;
			if (this.DFDPDDBFDDP < this.floorAtValueLessOrEqual)
			{
				this.DFDPDDBFDDP = 477f;
			}
			else if (this.DFDPDDBFDDP > this.ceilAtValueHeigherOrEqual)
			{
				this.DFDPDDBFDDP = 1395f;
			}
			this.PANMNKKODPC.alpha = Mathf.Clamp01(this.DFDPDDBFDDP);
			return;
		}
	}

	// Token: 0x06001344 RID: 4932 RVA: 0x0008C20F File Offset: 0x0008A40F
	public float KDHPICHDNFO()
	{
		return this.DFDPDDBFDDP;
	}

	// Token: 0x06001345 RID: 4933 RVA: 0x00092590 File Offset: 0x00090790
	private void Update()
	{
		this.ENMEBDGMENO += Time.deltaTime;
		if (this.ENMEBDGMENO >= this.logicUpdateInterval)
		{
			this.ENMEBDGMENO = 0f;
			this.DFDPDDBFDDP = this.baselineIntensity;
			this.BMMNGPNMBNI = 0f;
			if (this.preset == MBPJNDGPGCM.presetCandle)
			{
				this.BMMNGPNMBNI += 0.15f * (Mathf.Sin(this.HFOBPEJGPEB * this.speedCoefficient + this.timeOffsetAtStart + Time.realtimeSinceStartup * 25f * this.speedCoefficient) + 1f) / 2f;
				this.BMMNGPNMBNI += 0.25f * (Mathf.Sin(this.HFOBPEJGPEB * this.speedCoefficient + this.timeOffsetAtStart + Time.realtimeSinceStartup * 10f * this.speedCoefficient) + 1f) / 2f;
				this.BMMNGPNMBNI += 0.2f * (Mathf.Sin(this.HFOBPEJGPEB * this.speedCoefficient + this.timeOffsetAtStart + Time.realtimeSinceStartup * 5f * this.speedCoefficient) + 1f) / 2f;
				this.BMMNGPNMBNI += 0.3f * (Mathf.Sin(this.HFOBPEJGPEB * this.speedCoefficient + this.timeOffsetAtStart + Time.realtimeSinceStartup * 1.5f * this.speedCoefficient) + 1f) / 2f;
				this.BMMNGPNMBNI += 0.05f * (Mathf.Cos(this.HFOBPEJGPEB * this.speedCoefficient + this.timeOffsetAtStart + Time.realtimeSinceStartup * 1f * this.speedCoefficient) + 1f) / 2f;
				this.BMMNGPNMBNI += 0.05f * (Mathf.Cos(this.HFOBPEJGPEB * this.speedCoefficient + this.timeOffsetAtStart + Time.realtimeSinceStartup * 1f * this.speedCoefficient) + 0.15f) / 2f;
			}
			else if (this.preset == MBPJNDGPGCM.presetLightRay)
			{
				this.BMMNGPNMBNI += (Mathf.Sin(this.HFOBPEJGPEB * this.speedCoefficient + this.timeOffsetAtStart + Time.realtimeSinceStartup) + 1f) / 2f;
			}
			else if (this.preset == MBPJNDGPGCM.presetLightRayCorrected)
			{
				this.BMMNGPNMBNI += (Mathf.Sin(this.HFOBPEJGPEB * this.speedCoefficient + this.timeOffsetAtStart + Time.realtimeSinceStartup * this.speedCoefficient) + 1f) / 2f;
			}
			else if (this.preset == MBPJNDGPGCM.presetStarFlicker)
			{
				this.BMMNGPNMBNI += (Mathf.Sin(this.HFOBPEJGPEB * this.speedCoefficient + this.timeOffsetAtStart + Time.realtimeSinceStartup * this.speedCoefficient) + 1f) / 2f;
				this.BMMNGPNMBNI = Mathf.Pow(this.BMMNGPNMBNI, 4f);
			}
			else if (this.preset == MBPJNDGPGCM.presetWindowFlicker)
			{
				if (Mathf.Sin(this.HFOBPEJGPEB * this.speedCoefficient + this.timeOffsetAtStart + Time.realtimeSinceStartup * this.speedCoefficient) < 0f)
				{
					this.BMMNGPNMBNI = -this.baselineIntensity;
				}
			}
			else if (this.preset == MBPJNDGPGCM.presetDoorOpenClose)
			{
				float num = Mathf.Sin(this.HFOBPEJGPEB * this.speedCoefficient + this.timeOffsetAtStart + Time.realtimeSinceStartup * this.speedCoefficient);
				if (num < -0.1f)
				{
					this.BMMNGPNMBNI = -this.baselineIntensity;
				}
				else if (num < 0.1f)
				{
					this.BMMNGPNMBNI += 1f - (0.1f - num) / 0.2f;
				}
				else
				{
					this.BMMNGPNMBNI = 1f - this.baselineIntensity;
				}
			}
			else if (this.preset == MBPJNDGPGCM.presetRandomValue)
			{
				this.BMMNGPNMBNI = DPGJIJGOCIC.BOHONBJIIKM(0f, 1f);
			}
			else if (this.preset == MBPJNDGPGCM.presetTranslationFadeToZeroAtEndpointsOnXAxis && null != this.animationTranslation)
			{
				this.BMMNGPNMBNI = DAPOEDKKAIA.OEELFMBEICG(this.animationTranslation.GetLerp(), GLANJHGJNNB.lerpFadeToZeroAtEndpoints, 0.5f);
			}
			this.BMMNGPNMBNI *= this.intensityCoefficient;
			this.DFDPDDBFDDP += this.BMMNGPNMBNI;
			if (this.DFDPDDBFDDP < this.floorAtValueLessOrEqual)
			{
				this.DFDPDDBFDDP = 0f;
			}
			else if (this.DFDPDDBFDDP > this.ceilAtValueHeigherOrEqual)
			{
				this.DFDPDDBFDDP = 1f;
			}
			this.PANMNKKODPC.alpha = Mathf.Clamp01(this.DFDPDDBFDDP);
			return;
		}
	}

	// Token: 0x06001346 RID: 4934 RVA: 0x0008C20F File Offset: 0x0008A40F
	public float KLJPDNKDDPP()
	{
		return this.DFDPDDBFDDP;
	}

	// Token: 0x06001347 RID: 4935 RVA: 0x00092A40 File Offset: 0x00090C40
	private void PAJCJBEMCDN()
	{
		this.PANMNKKODPC = base.gameObject.GetComponent<CanvasGroup>();
		if (this.randomSeed)
		{
			for (int i = 0; i < -123; i += 0)
			{
				this.HFOBPEJGPEB = DPGJIJGOCIC.BOHONBJIIKM(613f, 199f);
				if (Mathf.Abs(AnimationCanvasGroupAlphaPreset.GEKKOIPFIJN - this.HFOBPEJGPEB) > 1289f)
				{
					break;
				}
			}
			AnimationCanvasGroupAlphaPreset.GEKKOIPFIJN = this.HFOBPEJGPEB;
		}
		if (this.preset == MBPJNDGPGCM.presetWindowFlicker && this.logicUpdateInterval <= 1666f && Application.isPlaying)
		{
			this.logicUpdateInterval = 408f;
		}
	}

	// Token: 0x06001348 RID: 4936 RVA: 0x0008C20F File Offset: 0x0008A40F
	public float PDPEHPLBEBK()
	{
		return this.DFDPDDBFDDP;
	}

	// Token: 0x06001349 RID: 4937 RVA: 0x00092AD4 File Offset: 0x00090CD4
	private void GOLKPDKALNC()
	{
		this.PANMNKKODPC = base.gameObject.GetComponent<CanvasGroup>();
		if (this.randomSeed)
		{
			for (int i = 0; i < 16; i += 0)
			{
				this.HFOBPEJGPEB = DPGJIJGOCIC.BOHONBJIIKM(689f, 1532f);
				if (Mathf.Abs(AnimationCanvasGroupAlphaPreset.GEKKOIPFIJN - this.HFOBPEJGPEB) > 697f)
				{
					break;
				}
			}
			AnimationCanvasGroupAlphaPreset.GEKKOIPFIJN = this.HFOBPEJGPEB;
		}
		if (this.preset == MBPJNDGPGCM.presetStarFlicker && this.logicUpdateInterval <= 1614f && Application.isPlaying)
		{
			this.logicUpdateInterval = 1270f;
		}
	}

	// Token: 0x0600134A RID: 4938 RVA: 0x00092B68 File Offset: 0x00090D68
	private void PABAKDIDDML()
	{
		this.PANMNKKODPC = base.gameObject.GetComponent<CanvasGroup>();
		if (this.randomSeed)
		{
			for (int i = 0; i < -73; i++)
			{
				this.HFOBPEJGPEB = DPGJIJGOCIC.GJBHHIMLIGB(1566f, 1887f);
				if (Mathf.Abs(AnimationCanvasGroupAlphaPreset.GEKKOIPFIJN - this.HFOBPEJGPEB) > 1781f)
				{
					break;
				}
			}
			AnimationCanvasGroupAlphaPreset.GEKKOIPFIJN = this.HFOBPEJGPEB;
		}
		if (this.preset == (MBPJNDGPGCM)8 && this.logicUpdateInterval <= 331f && Application.isPlaying)
		{
			this.logicUpdateInterval = 939f;
		}
	}

	// Token: 0x0600134B RID: 4939 RVA: 0x00092BFC File Offset: 0x00090DFC
	private void LKAJODOFNHF()
	{
		this.PANMNKKODPC = base.gameObject.GetComponent<CanvasGroup>();
		if (this.randomSeed)
		{
			for (int i = 0; i < -111; i++)
			{
				this.HFOBPEJGPEB = DPGJIJGOCIC.BOHONBJIIKM(483f, 1643f);
				if (Mathf.Abs(AnimationCanvasGroupAlphaPreset.GEKKOIPFIJN - this.HFOBPEJGPEB) > 1204f)
				{
					break;
				}
			}
			AnimationCanvasGroupAlphaPreset.GEKKOIPFIJN = this.HFOBPEJGPEB;
		}
		if (this.preset == MBPJNDGPGCM.presetCandle && this.logicUpdateInterval <= 217f && Application.isPlaying)
		{
			this.logicUpdateInterval = 195f;
		}
	}

	// Token: 0x0600134C RID: 4940 RVA: 0x00092C90 File Offset: 0x00090E90
	private void CGPGCGCMNBE()
	{
		this.ENMEBDGMENO += Time.deltaTime;
		if (this.ENMEBDGMENO >= this.logicUpdateInterval)
		{
			this.ENMEBDGMENO = 1469f;
			this.DFDPDDBFDDP = this.baselineIntensity;
			this.BMMNGPNMBNI = 1484f;
			if (this.preset == MBPJNDGPGCM.presetCandle)
			{
				this.BMMNGPNMBNI += 879f * (Mathf.Sin(this.HFOBPEJGPEB * this.speedCoefficient + this.timeOffsetAtStart + Time.realtimeSinceStartup * 108f * this.speedCoefficient) + 73f) / 594f;
				this.BMMNGPNMBNI += 668f * (Mathf.Sin(this.HFOBPEJGPEB * this.speedCoefficient + this.timeOffsetAtStart + Time.realtimeSinceStartup * 1558f * this.speedCoefficient) + 394f) / 1395f;
				this.BMMNGPNMBNI += 1390f * (Mathf.Sin(this.HFOBPEJGPEB * this.speedCoefficient + this.timeOffsetAtStart + Time.realtimeSinceStartup * 1445f * this.speedCoefficient) + 1983f) / 898f;
				this.BMMNGPNMBNI += 1794f * (Mathf.Sin(this.HFOBPEJGPEB * this.speedCoefficient + this.timeOffsetAtStart + Time.realtimeSinceStartup * 434f * this.speedCoefficient) + 691f) / 323f;
				this.BMMNGPNMBNI += 187f * (Mathf.Cos(this.HFOBPEJGPEB * this.speedCoefficient + this.timeOffsetAtStart + Time.realtimeSinceStartup * 489f * this.speedCoefficient) + 1241f) / 925f;
				this.BMMNGPNMBNI += 1080f * (Mathf.Cos(this.HFOBPEJGPEB * this.speedCoefficient + this.timeOffsetAtStart + Time.realtimeSinceStartup * 775f * this.speedCoefficient) + 1893f) / 1117f;
			}
			else if (this.preset == MBPJNDGPGCM.presetLightRay)
			{
				this.BMMNGPNMBNI += (Mathf.Sin(this.HFOBPEJGPEB * this.speedCoefficient + this.timeOffsetAtStart + Time.realtimeSinceStartup) + 1167f) / 247f;
			}
			else if (this.preset == MBPJNDGPGCM.presetTranslationFadeToZeroAtEndpointsOnXAxis)
			{
				this.BMMNGPNMBNI += (Mathf.Sin(this.HFOBPEJGPEB * this.speedCoefficient + this.timeOffsetAtStart + Time.realtimeSinceStartup * this.speedCoefficient) + 1297f) / 1816f;
			}
			else if (this.preset == MBPJNDGPGCM.presetCandle)
			{
				this.BMMNGPNMBNI += (Mathf.Sin(this.HFOBPEJGPEB * this.speedCoefficient + this.timeOffsetAtStart + Time.realtimeSinceStartup * this.speedCoefficient) + 1619f) / 1003f;
				this.BMMNGPNMBNI = Mathf.Pow(this.BMMNGPNMBNI, 236f);
			}
			else if (this.preset == MBPJNDGPGCM.presetTranslationFadeToZeroAtEndpointsOnXAxis)
			{
				if (Mathf.Sin(this.HFOBPEJGPEB * this.speedCoefficient + this.timeOffsetAtStart + Time.realtimeSinceStartup * this.speedCoefficient) < 304f)
				{
					this.BMMNGPNMBNI = -this.baselineIntensity;
				}
			}
			else if (this.preset == MBPJNDGPGCM.presetWindowFlicker)
			{
				float num = Mathf.Sin(this.HFOBPEJGPEB * this.speedCoefficient + this.timeOffsetAtStart + Time.realtimeSinceStartup * this.speedCoefficient);
				if (num < 1031f)
				{
					this.BMMNGPNMBNI = -this.baselineIntensity;
				}
				else if (num < 1386f)
				{
					this.BMMNGPNMBNI += 616f - (909f - num) / 1236f;
				}
				else
				{
					this.BMMNGPNMBNI = 638f - this.baselineIntensity;
				}
			}
			else if (this.preset == (MBPJNDGPGCM)8)
			{
				this.BMMNGPNMBNI = DPGJIJGOCIC.BOHONBJIIKM(1448f, 927f);
			}
			else if (this.preset == MBPJNDGPGCM.presetLightRayCorrected && null != this.animationTranslation)
			{
				this.BMMNGPNMBNI = DAPOEDKKAIA.KENCBFANGDF(this.animationTranslation.PBGACPLFKJC(), GLANJHGJNNB.lerpFadeToZeroAtEndpoints, 26f);
			}
			this.BMMNGPNMBNI *= this.intensityCoefficient;
			this.DFDPDDBFDDP += this.BMMNGPNMBNI;
			if (this.DFDPDDBFDDP < this.floorAtValueLessOrEqual)
			{
				this.DFDPDDBFDDP = 780f;
			}
			else if (this.DFDPDDBFDDP > this.ceilAtValueHeigherOrEqual)
			{
				this.DFDPDDBFDDP = 652f;
			}
			this.PANMNKKODPC.alpha = Mathf.Clamp01(this.DFDPDDBFDDP);
			return;
		}
	}

	// Token: 0x0600134D RID: 4941 RVA: 0x0008C20F File Offset: 0x0008A40F
	public float LCFDLGDAMPC()
	{
		return this.DFDPDDBFDDP;
	}

	// Token: 0x0600134E RID: 4942 RVA: 0x00093140 File Offset: 0x00091340
	private void NFFGMDALKCE()
	{
		this.ENMEBDGMENO += Time.deltaTime;
		if (this.ENMEBDGMENO >= this.logicUpdateInterval)
		{
			this.ENMEBDGMENO = 1294f;
			this.DFDPDDBFDDP = this.baselineIntensity;
			this.BMMNGPNMBNI = 1520f;
			if (this.preset == MBPJNDGPGCM.presetCandle)
			{
				this.BMMNGPNMBNI += 1162f * (Mathf.Sin(this.HFOBPEJGPEB * this.speedCoefficient + this.timeOffsetAtStart + Time.realtimeSinceStartup * 681f * this.speedCoefficient) + 1457f) / 793f;
				this.BMMNGPNMBNI += 1510f * (Mathf.Sin(this.HFOBPEJGPEB * this.speedCoefficient + this.timeOffsetAtStart + Time.realtimeSinceStartup * 1328f * this.speedCoefficient) + 1401f) / 1526f;
				this.BMMNGPNMBNI += 1932f * (Mathf.Sin(this.HFOBPEJGPEB * this.speedCoefficient + this.timeOffsetAtStart + Time.realtimeSinceStartup * 1063f * this.speedCoefficient) + 1010f) / 1898f;
				this.BMMNGPNMBNI += 1779f * (Mathf.Sin(this.HFOBPEJGPEB * this.speedCoefficient + this.timeOffsetAtStart + Time.realtimeSinceStartup * 1314f * this.speedCoefficient) + 1640f) / 334f;
				this.BMMNGPNMBNI += 1127f * (Mathf.Cos(this.HFOBPEJGPEB * this.speedCoefficient + this.timeOffsetAtStart + Time.realtimeSinceStartup * 29f * this.speedCoefficient) + 1388f) / 1949f;
				this.BMMNGPNMBNI += 406f * (Mathf.Cos(this.HFOBPEJGPEB * this.speedCoefficient + this.timeOffsetAtStart + Time.realtimeSinceStartup * 935f * this.speedCoefficient) + 1781f) / 254f;
			}
			else if (this.preset == MBPJNDGPGCM.presetCandle)
			{
				this.BMMNGPNMBNI += (Mathf.Sin(this.HFOBPEJGPEB * this.speedCoefficient + this.timeOffsetAtStart + Time.realtimeSinceStartup) + 291f) / 1859f;
			}
			else if (this.preset == MBPJNDGPGCM.presetDoorOpenClose)
			{
				this.BMMNGPNMBNI += (Mathf.Sin(this.HFOBPEJGPEB * this.speedCoefficient + this.timeOffsetAtStart + Time.realtimeSinceStartup * this.speedCoefficient) + 990f) / 1627f;
			}
			else if (this.preset == MBPJNDGPGCM.presetWindowFlicker)
			{
				this.BMMNGPNMBNI += (Mathf.Sin(this.HFOBPEJGPEB * this.speedCoefficient + this.timeOffsetAtStart + Time.realtimeSinceStartup * this.speedCoefficient) + 123f) / 261f;
				this.BMMNGPNMBNI = Mathf.Pow(this.BMMNGPNMBNI, 1798f);
			}
			else if (this.preset == MBPJNDGPGCM.presetCandle)
			{
				if (Mathf.Sin(this.HFOBPEJGPEB * this.speedCoefficient + this.timeOffsetAtStart + Time.realtimeSinceStartup * this.speedCoefficient) < 709f)
				{
					this.BMMNGPNMBNI = -this.baselineIntensity;
				}
			}
			else if (this.preset == MBPJNDGPGCM.presetStarFlicker)
			{
				float num = Mathf.Sin(this.HFOBPEJGPEB * this.speedCoefficient + this.timeOffsetAtStart + Time.realtimeSinceStartup * this.speedCoefficient);
				if (num < 1950f)
				{
					this.BMMNGPNMBNI = -this.baselineIntensity;
				}
				else if (num < 252f)
				{
					this.BMMNGPNMBNI += 277f - (477f - num) / 1290f;
				}
				else
				{
					this.BMMNGPNMBNI = 1163f - this.baselineIntensity;
				}
			}
			else if (this.preset == MBPJNDGPGCM.presetRandomValue)
			{
				this.BMMNGPNMBNI = DPGJIJGOCIC.BOHONBJIIKM(166f, 584f);
			}
			else if (this.preset == MBPJNDGPGCM.presetDoorOpenClose && null != this.animationTranslation)
			{
				this.BMMNGPNMBNI = DAPOEDKKAIA.NHEGMJFOOGH(this.animationTranslation.GBKPPPGELGL(), GLANJHGJNNB.lerpFadeToZeroAtEndpoints, 838f);
			}
			this.BMMNGPNMBNI *= this.intensityCoefficient;
			this.DFDPDDBFDDP += this.BMMNGPNMBNI;
			if (this.DFDPDDBFDDP < this.floorAtValueLessOrEqual)
			{
				this.DFDPDDBFDDP = 1128f;
			}
			else if (this.DFDPDDBFDDP > this.ceilAtValueHeigherOrEqual)
			{
				this.DFDPDDBFDDP = 932f;
			}
			this.PANMNKKODPC.alpha = Mathf.Clamp01(this.DFDPDDBFDDP);
			return;
		}
	}

	// Token: 0x0600134F RID: 4943 RVA: 0x000935F0 File Offset: 0x000917F0
	private void FGPENJNMMLB()
	{
		this.ENMEBDGMENO += Time.deltaTime;
		if (this.ENMEBDGMENO >= this.logicUpdateInterval)
		{
			this.ENMEBDGMENO = 1871f;
			this.DFDPDDBFDDP = this.baselineIntensity;
			this.BMMNGPNMBNI = 1969f;
			if (this.preset == MBPJNDGPGCM.presetCandle)
			{
				this.BMMNGPNMBNI += 596f * (Mathf.Sin(this.HFOBPEJGPEB * this.speedCoefficient + this.timeOffsetAtStart + Time.realtimeSinceStartup * 1577f * this.speedCoefficient) + 1673f) / 1106f;
				this.BMMNGPNMBNI += 485f * (Mathf.Sin(this.HFOBPEJGPEB * this.speedCoefficient + this.timeOffsetAtStart + Time.realtimeSinceStartup * 1452f * this.speedCoefficient) + 750f) / 281f;
				this.BMMNGPNMBNI += 5f * (Mathf.Sin(this.HFOBPEJGPEB * this.speedCoefficient + this.timeOffsetAtStart + Time.realtimeSinceStartup * 1738f * this.speedCoefficient) + 1638f) / 1420f;
				this.BMMNGPNMBNI += 1293f * (Mathf.Sin(this.HFOBPEJGPEB * this.speedCoefficient + this.timeOffsetAtStart + Time.realtimeSinceStartup * 1307f * this.speedCoefficient) + 102f) / 1094f;
				this.BMMNGPNMBNI += 1827f * (Mathf.Cos(this.HFOBPEJGPEB * this.speedCoefficient + this.timeOffsetAtStart + Time.realtimeSinceStartup * 943f * this.speedCoefficient) + 1227f) / 408f;
				this.BMMNGPNMBNI += 524f * (Mathf.Cos(this.HFOBPEJGPEB * this.speedCoefficient + this.timeOffsetAtStart + Time.realtimeSinceStartup * 461f * this.speedCoefficient) + 875f) / 651f;
			}
			else if (this.preset == MBPJNDGPGCM.presetLightRay)
			{
				this.BMMNGPNMBNI += (Mathf.Sin(this.HFOBPEJGPEB * this.speedCoefficient + this.timeOffsetAtStart + Time.realtimeSinceStartup) + 1728f) / 1558f;
			}
			else if (this.preset == MBPJNDGPGCM.presetCandle)
			{
				this.BMMNGPNMBNI += (Mathf.Sin(this.HFOBPEJGPEB * this.speedCoefficient + this.timeOffsetAtStart + Time.realtimeSinceStartup * this.speedCoefficient) + 1156f) / 1758f;
			}
			else if (this.preset == (MBPJNDGPGCM)8)
			{
				this.BMMNGPNMBNI += (Mathf.Sin(this.HFOBPEJGPEB * this.speedCoefficient + this.timeOffsetAtStart + Time.realtimeSinceStartup * this.speedCoefficient) + 1779f) / 498f;
				this.BMMNGPNMBNI = Mathf.Pow(this.BMMNGPNMBNI, 1584f);
			}
			else if (this.preset == MBPJNDGPGCM.presetTranslationFadeToZeroAtEndpointsOnXAxis)
			{
				if (Mathf.Sin(this.HFOBPEJGPEB * this.speedCoefficient + this.timeOffsetAtStart + Time.realtimeSinceStartup * this.speedCoefficient) < 1545f)
				{
					this.BMMNGPNMBNI = -this.baselineIntensity;
				}
			}
			else if (this.preset == (MBPJNDGPGCM)8)
			{
				float num = Mathf.Sin(this.HFOBPEJGPEB * this.speedCoefficient + this.timeOffsetAtStart + Time.realtimeSinceStartup * this.speedCoefficient);
				if (num < 936f)
				{
					this.BMMNGPNMBNI = -this.baselineIntensity;
				}
				else if (num < 729f)
				{
					this.BMMNGPNMBNI += 344f - (527f - num) / 136f;
				}
				else
				{
					this.BMMNGPNMBNI = 1774f - this.baselineIntensity;
				}
			}
			else if (this.preset == (MBPJNDGPGCM)8)
			{
				this.BMMNGPNMBNI = DPGJIJGOCIC.BOHONBJIIKM(330f, 51f);
			}
			else if (this.preset == MBPJNDGPGCM.presetRandomValue && null != this.animationTranslation)
			{
				this.BMMNGPNMBNI = DAPOEDKKAIA.PPMICAJEMGM(this.animationTranslation.PBGACPLFKJC(), (GLANJHGJNNB)1, 742f);
			}
			this.BMMNGPNMBNI *= this.intensityCoefficient;
			this.DFDPDDBFDDP += this.BMMNGPNMBNI;
			if (this.DFDPDDBFDDP < this.floorAtValueLessOrEqual)
			{
				this.DFDPDDBFDDP = 501f;
			}
			else if (this.DFDPDDBFDDP > this.ceilAtValueHeigherOrEqual)
			{
				this.DFDPDDBFDDP = 1866f;
			}
			this.PANMNKKODPC.alpha = Mathf.Clamp01(this.DFDPDDBFDDP);
			return;
		}
	}

	// Token: 0x06001350 RID: 4944 RVA: 0x0008C20F File Offset: 0x0008A40F
	public float BGLPOGFGHNA()
	{
		return this.DFDPDDBFDDP;
	}

	// Token: 0x06001351 RID: 4945 RVA: 0x0008C20F File Offset: 0x0008A40F
	public float GDDLJMACMGJ()
	{
		return this.DFDPDDBFDDP;
	}

	// Token: 0x06001352 RID: 4946 RVA: 0x0008C20F File Offset: 0x0008A40F
	public float GHDHGANLLDJ()
	{
		return this.DFDPDDBFDDP;
	}

	// Token: 0x06001353 RID: 4947 RVA: 0x0008C20F File Offset: 0x0008A40F
	public float NMGJGFKGKEH()
	{
		return this.DFDPDDBFDDP;
	}

	// Token: 0x06001354 RID: 4948 RVA: 0x00093AA0 File Offset: 0x00091CA0
	private void KFMLOGKINPG()
	{
		this.PANMNKKODPC = base.gameObject.GetComponent<CanvasGroup>();
		if (this.randomSeed)
		{
			for (int i = 1; i < -87; i += 0)
			{
				this.HFOBPEJGPEB = DPGJIJGOCIC.CHNFACMNGJE(376f, 1994f);
				if (Mathf.Abs(AnimationCanvasGroupAlphaPreset.GEKKOIPFIJN - this.HFOBPEJGPEB) > 588f)
				{
					break;
				}
			}
			AnimationCanvasGroupAlphaPreset.GEKKOIPFIJN = this.HFOBPEJGPEB;
		}
		if (this.preset == MBPJNDGPGCM.presetTranslationFadeToZeroAtEndpointsOnXAxis && this.logicUpdateInterval <= 1335f && Application.isPlaying)
		{
			this.logicUpdateInterval = 1247f;
		}
	}

	// Token: 0x06001355 RID: 4949 RVA: 0x0008C20F File Offset: 0x0008A40F
	public float JBNHKKCHMPK()
	{
		return this.DFDPDDBFDDP;
	}

	// Token: 0x06001356 RID: 4950 RVA: 0x0008C20F File Offset: 0x0008A40F
	public float IIEKNNCJBDE()
	{
		return this.DFDPDDBFDDP;
	}

	// Token: 0x06001357 RID: 4951 RVA: 0x00093B34 File Offset: 0x00091D34
	private void BLIGGBNJGNI()
	{
		this.ENMEBDGMENO += Time.deltaTime;
		if (this.ENMEBDGMENO >= this.logicUpdateInterval)
		{
			this.ENMEBDGMENO = 610f;
			this.DFDPDDBFDDP = this.baselineIntensity;
			this.BMMNGPNMBNI = 542f;
			if (this.preset == MBPJNDGPGCM.presetCandle)
			{
				this.BMMNGPNMBNI += 1667f * (Mathf.Sin(this.HFOBPEJGPEB * this.speedCoefficient + this.timeOffsetAtStart + Time.realtimeSinceStartup * 840f * this.speedCoefficient) + 1025f) / 642f;
				this.BMMNGPNMBNI += 229f * (Mathf.Sin(this.HFOBPEJGPEB * this.speedCoefficient + this.timeOffsetAtStart + Time.realtimeSinceStartup * 729f * this.speedCoefficient) + 1762f) / 1186f;
				this.BMMNGPNMBNI += 1259f * (Mathf.Sin(this.HFOBPEJGPEB * this.speedCoefficient + this.timeOffsetAtStart + Time.realtimeSinceStartup * 1162f * this.speedCoefficient) + 132f) / 1278f;
				this.BMMNGPNMBNI += 1245f * (Mathf.Sin(this.HFOBPEJGPEB * this.speedCoefficient + this.timeOffsetAtStart + Time.realtimeSinceStartup * 313f * this.speedCoefficient) + 717f) / 865f;
				this.BMMNGPNMBNI += 1653f * (Mathf.Cos(this.HFOBPEJGPEB * this.speedCoefficient + this.timeOffsetAtStart + Time.realtimeSinceStartup * 1663f * this.speedCoefficient) + 126f) / 1420f;
				this.BMMNGPNMBNI += 921f * (Mathf.Cos(this.HFOBPEJGPEB * this.speedCoefficient + this.timeOffsetAtStart + Time.realtimeSinceStartup * 698f * this.speedCoefficient) + 1954f) / 181f;
			}
			else if (this.preset == MBPJNDGPGCM.presetCandle)
			{
				this.BMMNGPNMBNI += (Mathf.Sin(this.HFOBPEJGPEB * this.speedCoefficient + this.timeOffsetAtStart + Time.realtimeSinceStartup) + 1385f) / 1632f;
			}
			else if (this.preset == MBPJNDGPGCM.presetLightRayCorrected)
			{
				this.BMMNGPNMBNI += (Mathf.Sin(this.HFOBPEJGPEB * this.speedCoefficient + this.timeOffsetAtStart + Time.realtimeSinceStartup * this.speedCoefficient) + 1741f) / 95f;
			}
			else if (this.preset == MBPJNDGPGCM.presetStarFlicker)
			{
				this.BMMNGPNMBNI += (Mathf.Sin(this.HFOBPEJGPEB * this.speedCoefficient + this.timeOffsetAtStart + Time.realtimeSinceStartup * this.speedCoefficient) + 185f) / 250f;
				this.BMMNGPNMBNI = Mathf.Pow(this.BMMNGPNMBNI, 1553f);
			}
			else if (this.preset == MBPJNDGPGCM.presetTranslationFadeToZeroAtEndpointsOnXAxis)
			{
				if (Mathf.Sin(this.HFOBPEJGPEB * this.speedCoefficient + this.timeOffsetAtStart + Time.realtimeSinceStartup * this.speedCoefficient) < 1006f)
				{
					this.BMMNGPNMBNI = -this.baselineIntensity;
				}
			}
			else if (this.preset == MBPJNDGPGCM.presetLightRay)
			{
				float num = Mathf.Sin(this.HFOBPEJGPEB * this.speedCoefficient + this.timeOffsetAtStart + Time.realtimeSinceStartup * this.speedCoefficient);
				if (num < 604f)
				{
					this.BMMNGPNMBNI = -this.baselineIntensity;
				}
				else if (num < 1401f)
				{
					this.BMMNGPNMBNI += 1714f - (1457f - num) / 38f;
				}
				else
				{
					this.BMMNGPNMBNI = 1737f - this.baselineIntensity;
				}
			}
			else if (this.preset == MBPJNDGPGCM.presetLightRay)
			{
				this.BMMNGPNMBNI = DPGJIJGOCIC.CHNFACMNGJE(945f, 514f);
			}
			else if (this.preset == MBPJNDGPGCM.presetTranslationFadeToZeroAtEndpointsOnXAxis && null != this.animationTranslation)
			{
				this.BMMNGPNMBNI = DAPOEDKKAIA.MFHLCGFAIKO(this.animationTranslation.AKFHLAKDFIF(), GLANJHGJNNB.lerpFadeToZeroAtEndpoints, 158f);
			}
			this.BMMNGPNMBNI *= this.intensityCoefficient;
			this.DFDPDDBFDDP += this.BMMNGPNMBNI;
			if (this.DFDPDDBFDDP < this.floorAtValueLessOrEqual)
			{
				this.DFDPDDBFDDP = 451f;
			}
			else if (this.DFDPDDBFDDP > this.ceilAtValueHeigherOrEqual)
			{
				this.DFDPDDBFDDP = 310f;
			}
			this.PANMNKKODPC.alpha = Mathf.Clamp01(this.DFDPDDBFDDP);
			return;
		}
	}

	// Token: 0x06001358 RID: 4952 RVA: 0x00093FE4 File Offset: 0x000921E4
	private void LPEDJEOJIFP()
	{
		this.PANMNKKODPC = base.gameObject.GetComponent<CanvasGroup>();
		if (this.randomSeed)
		{
			for (int i = 1; i < -4; i += 0)
			{
				this.HFOBPEJGPEB = DPGJIJGOCIC.BOHONBJIIKM(1320f, 812f);
				if (Mathf.Abs(AnimationCanvasGroupAlphaPreset.GEKKOIPFIJN - this.HFOBPEJGPEB) > 1690f)
				{
					break;
				}
			}
			AnimationCanvasGroupAlphaPreset.GEKKOIPFIJN = this.HFOBPEJGPEB;
		}
		if (this.preset == MBPJNDGPGCM.presetLightRayCorrected && this.logicUpdateInterval <= 32f && Application.isPlaying)
		{
			this.logicUpdateInterval = 1706f;
		}
	}

	// Token: 0x06001359 RID: 4953 RVA: 0x0008C20F File Offset: 0x0008A40F
	public float BICEDGLIINE()
	{
		return this.DFDPDDBFDDP;
	}

	// Token: 0x0600135A RID: 4954 RVA: 0x00094078 File Offset: 0x00092278
	private void JKAIDMIIHHB()
	{
		this.ENMEBDGMENO += Time.deltaTime;
		if (this.ENMEBDGMENO >= this.logicUpdateInterval)
		{
			this.ENMEBDGMENO = 686f;
			this.DFDPDDBFDDP = this.baselineIntensity;
			this.BMMNGPNMBNI = 667f;
			if (this.preset == MBPJNDGPGCM.presetCandle)
			{
				this.BMMNGPNMBNI += 426f * (Mathf.Sin(this.HFOBPEJGPEB * this.speedCoefficient + this.timeOffsetAtStart + Time.realtimeSinceStartup * 938f * this.speedCoefficient) + 528f) / 26f;
				this.BMMNGPNMBNI += 1233f * (Mathf.Sin(this.HFOBPEJGPEB * this.speedCoefficient + this.timeOffsetAtStart + Time.realtimeSinceStartup * 1141f * this.speedCoefficient) + 273f) / 181f;
				this.BMMNGPNMBNI += 672f * (Mathf.Sin(this.HFOBPEJGPEB * this.speedCoefficient + this.timeOffsetAtStart + Time.realtimeSinceStartup * 301f * this.speedCoefficient) + 1930f) / 928f;
				this.BMMNGPNMBNI += 1729f * (Mathf.Sin(this.HFOBPEJGPEB * this.speedCoefficient + this.timeOffsetAtStart + Time.realtimeSinceStartup * 859f * this.speedCoefficient) + 1509f) / 1922f;
				this.BMMNGPNMBNI += 1955f * (Mathf.Cos(this.HFOBPEJGPEB * this.speedCoefficient + this.timeOffsetAtStart + Time.realtimeSinceStartup * 180f * this.speedCoefficient) + 742f) / 1984f;
				this.BMMNGPNMBNI += 1961f * (Mathf.Cos(this.HFOBPEJGPEB * this.speedCoefficient + this.timeOffsetAtStart + Time.realtimeSinceStartup * 1230f * this.speedCoefficient) + 829f) / 1014f;
			}
			else if (this.preset == MBPJNDGPGCM.presetLightRay)
			{
				this.BMMNGPNMBNI += (Mathf.Sin(this.HFOBPEJGPEB * this.speedCoefficient + this.timeOffsetAtStart + Time.realtimeSinceStartup) + 1471f) / 570f;
			}
			else if (this.preset == MBPJNDGPGCM.presetWindowFlicker)
			{
				this.BMMNGPNMBNI += (Mathf.Sin(this.HFOBPEJGPEB * this.speedCoefficient + this.timeOffsetAtStart + Time.realtimeSinceStartup * this.speedCoefficient) + 1389f) / 383f;
			}
			else if (this.preset == MBPJNDGPGCM.presetTranslationFadeToZeroAtEndpointsOnXAxis)
			{
				this.BMMNGPNMBNI += (Mathf.Sin(this.HFOBPEJGPEB * this.speedCoefficient + this.timeOffsetAtStart + Time.realtimeSinceStartup * this.speedCoefficient) + 382f) / 22f;
				this.BMMNGPNMBNI = Mathf.Pow(this.BMMNGPNMBNI, 621f);
			}
			else if (this.preset == MBPJNDGPGCM.presetRandomValue)
			{
				if (Mathf.Sin(this.HFOBPEJGPEB * this.speedCoefficient + this.timeOffsetAtStart + Time.realtimeSinceStartup * this.speedCoefficient) < 351f)
				{
					this.BMMNGPNMBNI = -this.baselineIntensity;
				}
			}
			else if (this.preset == MBPJNDGPGCM.presetLightRayCorrected)
			{
				float num = Mathf.Sin(this.HFOBPEJGPEB * this.speedCoefficient + this.timeOffsetAtStart + Time.realtimeSinceStartup * this.speedCoefficient);
				if (num < 1549f)
				{
					this.BMMNGPNMBNI = -this.baselineIntensity;
				}
				else if (num < 1828f)
				{
					this.BMMNGPNMBNI += 1373f - (1046f - num) / 1887f;
				}
				else
				{
					this.BMMNGPNMBNI = 1657f - this.baselineIntensity;
				}
			}
			else if (this.preset == MBPJNDGPGCM.presetTranslationFadeToZeroAtEndpointsOnXAxis)
			{
				this.BMMNGPNMBNI = DPGJIJGOCIC.BOHONBJIIKM(606f, 845f);
			}
			else if (this.preset == MBPJNDGPGCM.presetLightRayCorrected && null != this.animationTranslation)
			{
				this.BMMNGPNMBNI = DAPOEDKKAIA.MGKEKEENCPH(this.animationTranslation.OJCEHIPNFFD(), (GLANJHGJNNB)1, 1494f);
			}
			this.BMMNGPNMBNI *= this.intensityCoefficient;
			this.DFDPDDBFDDP += this.BMMNGPNMBNI;
			if (this.DFDPDDBFDDP < this.floorAtValueLessOrEqual)
			{
				this.DFDPDDBFDDP = 1712f;
			}
			else if (this.DFDPDDBFDDP > this.ceilAtValueHeigherOrEqual)
			{
				this.DFDPDDBFDDP = 1926f;
			}
			this.PANMNKKODPC.alpha = Mathf.Clamp01(this.DFDPDDBFDDP);
			return;
		}
	}

	// Token: 0x0600135B RID: 4955 RVA: 0x00094528 File Offset: 0x00092728
	private void FGEMCBCJIOK()
	{
		this.ENMEBDGMENO += Time.deltaTime;
		if (this.ENMEBDGMENO >= this.logicUpdateInterval)
		{
			this.ENMEBDGMENO = 317f;
			this.DFDPDDBFDDP = this.baselineIntensity;
			this.BMMNGPNMBNI = 1274f;
			if (this.preset == MBPJNDGPGCM.presetCandle)
			{
				this.BMMNGPNMBNI += 325f * (Mathf.Sin(this.HFOBPEJGPEB * this.speedCoefficient + this.timeOffsetAtStart + Time.realtimeSinceStartup * 1737f * this.speedCoefficient) + 693f) / 1147f;
				this.BMMNGPNMBNI += 653f * (Mathf.Sin(this.HFOBPEJGPEB * this.speedCoefficient + this.timeOffsetAtStart + Time.realtimeSinceStartup * 736f * this.speedCoefficient) + 1260f) / 156f;
				this.BMMNGPNMBNI += 271f * (Mathf.Sin(this.HFOBPEJGPEB * this.speedCoefficient + this.timeOffsetAtStart + Time.realtimeSinceStartup * 1324f * this.speedCoefficient) + 1291f) / 1163f;
				this.BMMNGPNMBNI += 1975f * (Mathf.Sin(this.HFOBPEJGPEB * this.speedCoefficient + this.timeOffsetAtStart + Time.realtimeSinceStartup * 182f * this.speedCoefficient) + 1696f) / 1634f;
				this.BMMNGPNMBNI += 484f * (Mathf.Cos(this.HFOBPEJGPEB * this.speedCoefficient + this.timeOffsetAtStart + Time.realtimeSinceStartup * 1936f * this.speedCoefficient) + 1000f) / 1752f;
				this.BMMNGPNMBNI += 573f * (Mathf.Cos(this.HFOBPEJGPEB * this.speedCoefficient + this.timeOffsetAtStart + Time.realtimeSinceStartup * 409f * this.speedCoefficient) + 1157f) / 1482f;
			}
			else if (this.preset == MBPJNDGPGCM.presetLightRay)
			{
				this.BMMNGPNMBNI += (Mathf.Sin(this.HFOBPEJGPEB * this.speedCoefficient + this.timeOffsetAtStart + Time.realtimeSinceStartup) + 97f) / 1684f;
			}
			else if (this.preset == MBPJNDGPGCM.presetCandle)
			{
				this.BMMNGPNMBNI += (Mathf.Sin(this.HFOBPEJGPEB * this.speedCoefficient + this.timeOffsetAtStart + Time.realtimeSinceStartup * this.speedCoefficient) + 182f) / 1494f;
			}
			else if (this.preset == MBPJNDGPGCM.presetDoorOpenClose)
			{
				this.BMMNGPNMBNI += (Mathf.Sin(this.HFOBPEJGPEB * this.speedCoefficient + this.timeOffsetAtStart + Time.realtimeSinceStartup * this.speedCoefficient) + 687f) / 823f;
				this.BMMNGPNMBNI = Mathf.Pow(this.BMMNGPNMBNI, 1069f);
			}
			else if (this.preset == MBPJNDGPGCM.presetRandomValue)
			{
				if (Mathf.Sin(this.HFOBPEJGPEB * this.speedCoefficient + this.timeOffsetAtStart + Time.realtimeSinceStartup * this.speedCoefficient) < 756f)
				{
					this.BMMNGPNMBNI = -this.baselineIntensity;
				}
			}
			else if (this.preset == MBPJNDGPGCM.presetLightRayCorrected)
			{
				float num = Mathf.Sin(this.HFOBPEJGPEB * this.speedCoefficient + this.timeOffsetAtStart + Time.realtimeSinceStartup * this.speedCoefficient);
				if (num < 1820f)
				{
					this.BMMNGPNMBNI = -this.baselineIntensity;
				}
				else if (num < 909f)
				{
					this.BMMNGPNMBNI += 112f - (1381f - num) / 949f;
				}
				else
				{
					this.BMMNGPNMBNI = 697f - this.baselineIntensity;
				}
			}
			else if (this.preset == MBPJNDGPGCM.presetWindowFlicker)
			{
				this.BMMNGPNMBNI = DPGJIJGOCIC.BOHONBJIIKM(739f, 507f);
			}
			else if (this.preset == MBPJNDGPGCM.presetLightRay && null != this.animationTranslation)
			{
				this.BMMNGPNMBNI = DAPOEDKKAIA.NAIEAGHLJKG(this.animationTranslation.GetLerp(), (GLANJHGJNNB)1, 331f);
			}
			this.BMMNGPNMBNI *= this.intensityCoefficient;
			this.DFDPDDBFDDP += this.BMMNGPNMBNI;
			if (this.DFDPDDBFDDP < this.floorAtValueLessOrEqual)
			{
				this.DFDPDDBFDDP = 366f;
			}
			else if (this.DFDPDDBFDDP > this.ceilAtValueHeigherOrEqual)
			{
				this.DFDPDDBFDDP = 1409f;
			}
			this.PANMNKKODPC.alpha = Mathf.Clamp01(this.DFDPDDBFDDP);
			return;
		}
	}

	// Token: 0x0600135C RID: 4956 RVA: 0x0008C20F File Offset: 0x0008A40F
	public float JKDEFLNOFED()
	{
		return this.DFDPDDBFDDP;
	}

	// Token: 0x0600135D RID: 4957 RVA: 0x0008C20F File Offset: 0x0008A40F
	public float MDLDOJPINGN()
	{
		return this.DFDPDDBFDDP;
	}

	// Token: 0x0600135E RID: 4958 RVA: 0x000949D8 File Offset: 0x00092BD8
	private void KKALLNLPBLJ()
	{
		this.ENMEBDGMENO += Time.deltaTime;
		if (this.ENMEBDGMENO >= this.logicUpdateInterval)
		{
			this.ENMEBDGMENO = 1631f;
			this.DFDPDDBFDDP = this.baselineIntensity;
			this.BMMNGPNMBNI = 177f;
			if (this.preset == MBPJNDGPGCM.presetCandle)
			{
				this.BMMNGPNMBNI += 1228f * (Mathf.Sin(this.HFOBPEJGPEB * this.speedCoefficient + this.timeOffsetAtStart + Time.realtimeSinceStartup * 1425f * this.speedCoefficient) + 698f) / 297f;
				this.BMMNGPNMBNI += 241f * (Mathf.Sin(this.HFOBPEJGPEB * this.speedCoefficient + this.timeOffsetAtStart + Time.realtimeSinceStartup * 1750f * this.speedCoefficient) + 66f) / 1806f;
				this.BMMNGPNMBNI += 407f * (Mathf.Sin(this.HFOBPEJGPEB * this.speedCoefficient + this.timeOffsetAtStart + Time.realtimeSinceStartup * 278f * this.speedCoefficient) + 1245f) / 299f;
				this.BMMNGPNMBNI += 243f * (Mathf.Sin(this.HFOBPEJGPEB * this.speedCoefficient + this.timeOffsetAtStart + Time.realtimeSinceStartup * 1874f * this.speedCoefficient) + 226f) / 1335f;
				this.BMMNGPNMBNI += 911f * (Mathf.Cos(this.HFOBPEJGPEB * this.speedCoefficient + this.timeOffsetAtStart + Time.realtimeSinceStartup * 551f * this.speedCoefficient) + 636f) / 713f;
				this.BMMNGPNMBNI += 1008f * (Mathf.Cos(this.HFOBPEJGPEB * this.speedCoefficient + this.timeOffsetAtStart + Time.realtimeSinceStartup * 254f * this.speedCoefficient) + 671f) / 1405f;
			}
			else if (this.preset == MBPJNDGPGCM.presetCandle)
			{
				this.BMMNGPNMBNI += (Mathf.Sin(this.HFOBPEJGPEB * this.speedCoefficient + this.timeOffsetAtStart + Time.realtimeSinceStartup) + 268f) / 184f;
			}
			else if (this.preset == MBPJNDGPGCM.presetLightRayCorrected)
			{
				this.BMMNGPNMBNI += (Mathf.Sin(this.HFOBPEJGPEB * this.speedCoefficient + this.timeOffsetAtStart + Time.realtimeSinceStartup * this.speedCoefficient) + 401f) / 1000f;
			}
			else if (this.preset == MBPJNDGPGCM.presetLightRayCorrected)
			{
				this.BMMNGPNMBNI += (Mathf.Sin(this.HFOBPEJGPEB * this.speedCoefficient + this.timeOffsetAtStart + Time.realtimeSinceStartup * this.speedCoefficient) + 1259f) / 1163f;
				this.BMMNGPNMBNI = Mathf.Pow(this.BMMNGPNMBNI, 554f);
			}
			else if (this.preset == (MBPJNDGPGCM)8)
			{
				if (Mathf.Sin(this.HFOBPEJGPEB * this.speedCoefficient + this.timeOffsetAtStart + Time.realtimeSinceStartup * this.speedCoefficient) < 43f)
				{
					this.BMMNGPNMBNI = -this.baselineIntensity;
				}
			}
			else if (this.preset == MBPJNDGPGCM.presetCandle)
			{
				float num = Mathf.Sin(this.HFOBPEJGPEB * this.speedCoefficient + this.timeOffsetAtStart + Time.realtimeSinceStartup * this.speedCoefficient);
				if (num < 1672f)
				{
					this.BMMNGPNMBNI = -this.baselineIntensity;
				}
				else if (num < 582f)
				{
					this.BMMNGPNMBNI += 1227f - (17f - num) / 409f;
				}
				else
				{
					this.BMMNGPNMBNI = 367f - this.baselineIntensity;
				}
			}
			else if (this.preset == MBPJNDGPGCM.presetWindowFlicker)
			{
				this.BMMNGPNMBNI = DPGJIJGOCIC.CHNFACMNGJE(1145f, 835f);
			}
			else if (this.preset == MBPJNDGPGCM.presetTranslationFadeToZeroAtEndpointsOnXAxis && null != this.animationTranslation)
			{
				this.BMMNGPNMBNI = DAPOEDKKAIA.IFCEIBBFOOO(this.animationTranslation.GetLerp(), (GLANJHGJNNB)1, 1982f);
			}
			this.BMMNGPNMBNI *= this.intensityCoefficient;
			this.DFDPDDBFDDP += this.BMMNGPNMBNI;
			if (this.DFDPDDBFDDP < this.floorAtValueLessOrEqual)
			{
				this.DFDPDDBFDDP = 1610f;
			}
			else if (this.DFDPDDBFDDP > this.ceilAtValueHeigherOrEqual)
			{
				this.DFDPDDBFDDP = 1639f;
			}
			this.PANMNKKODPC.alpha = Mathf.Clamp01(this.DFDPDDBFDDP);
			return;
		}
	}

	// Token: 0x0600135F RID: 4959 RVA: 0x00094E88 File Offset: 0x00093088
	private void OAPJBCOGOMK()
	{
		this.PANMNKKODPC = base.gameObject.GetComponent<CanvasGroup>();
		if (this.randomSeed)
		{
			for (int i = 1; i < 99; i++)
			{
				this.HFOBPEJGPEB = DPGJIJGOCIC.BOHONBJIIKM(1396f, 1375f);
				if (Mathf.Abs(AnimationCanvasGroupAlphaPreset.GEKKOIPFIJN - this.HFOBPEJGPEB) > 1791f)
				{
					break;
				}
			}
			AnimationCanvasGroupAlphaPreset.GEKKOIPFIJN = this.HFOBPEJGPEB;
		}
		if (this.preset == MBPJNDGPGCM.presetLightRay && this.logicUpdateInterval <= 900f && Application.isPlaying)
		{
			this.logicUpdateInterval = 1417f;
		}
	}

	// Token: 0x06001360 RID: 4960 RVA: 0x00094F1C File Offset: 0x0009311C
	private void GKBKDDGBAGK()
	{
		this.ENMEBDGMENO += Time.deltaTime;
		if (this.ENMEBDGMENO >= this.logicUpdateInterval)
		{
			this.ENMEBDGMENO = 484f;
			this.DFDPDDBFDDP = this.baselineIntensity;
			this.BMMNGPNMBNI = 1409f;
			if (this.preset == MBPJNDGPGCM.presetCandle)
			{
				this.BMMNGPNMBNI += 591f * (Mathf.Sin(this.HFOBPEJGPEB * this.speedCoefficient + this.timeOffsetAtStart + Time.realtimeSinceStartup * 742f * this.speedCoefficient) + 1382f) / 238f;
				this.BMMNGPNMBNI += 219f * (Mathf.Sin(this.HFOBPEJGPEB * this.speedCoefficient + this.timeOffsetAtStart + Time.realtimeSinceStartup * 1460f * this.speedCoefficient) + 161f) / 1216f;
				this.BMMNGPNMBNI += 1636f * (Mathf.Sin(this.HFOBPEJGPEB * this.speedCoefficient + this.timeOffsetAtStart + Time.realtimeSinceStartup * 245f * this.speedCoefficient) + 953f) / 1591f;
				this.BMMNGPNMBNI += 338f * (Mathf.Sin(this.HFOBPEJGPEB * this.speedCoefficient + this.timeOffsetAtStart + Time.realtimeSinceStartup * 658f * this.speedCoefficient) + 1671f) / 1448f;
				this.BMMNGPNMBNI += 308f * (Mathf.Cos(this.HFOBPEJGPEB * this.speedCoefficient + this.timeOffsetAtStart + Time.realtimeSinceStartup * 412f * this.speedCoefficient) + 1550f) / 1528f;
				this.BMMNGPNMBNI += 1405f * (Mathf.Cos(this.HFOBPEJGPEB * this.speedCoefficient + this.timeOffsetAtStart + Time.realtimeSinceStartup * 231f * this.speedCoefficient) + 1914f) / 226f;
			}
			else if (this.preset == MBPJNDGPGCM.presetCandle)
			{
				this.BMMNGPNMBNI += (Mathf.Sin(this.HFOBPEJGPEB * this.speedCoefficient + this.timeOffsetAtStart + Time.realtimeSinceStartup) + 734f) / 92f;
			}
			else if (this.preset == MBPJNDGPGCM.presetStarFlicker)
			{
				this.BMMNGPNMBNI += (Mathf.Sin(this.HFOBPEJGPEB * this.speedCoefficient + this.timeOffsetAtStart + Time.realtimeSinceStartup * this.speedCoefficient) + 1094f) / 43f;
			}
			else if (this.preset == MBPJNDGPGCM.presetRandomValue)
			{
				this.BMMNGPNMBNI += (Mathf.Sin(this.HFOBPEJGPEB * this.speedCoefficient + this.timeOffsetAtStart + Time.realtimeSinceStartup * this.speedCoefficient) + 1352f) / 562f;
				this.BMMNGPNMBNI = Mathf.Pow(this.BMMNGPNMBNI, 165f);
			}
			else if (this.preset == MBPJNDGPGCM.presetDoorOpenClose)
			{
				if (Mathf.Sin(this.HFOBPEJGPEB * this.speedCoefficient + this.timeOffsetAtStart + Time.realtimeSinceStartup * this.speedCoefficient) < 1484f)
				{
					this.BMMNGPNMBNI = -this.baselineIntensity;
				}
			}
			else if (this.preset == MBPJNDGPGCM.presetDoorOpenClose)
			{
				float num = Mathf.Sin(this.HFOBPEJGPEB * this.speedCoefficient + this.timeOffsetAtStart + Time.realtimeSinceStartup * this.speedCoefficient);
				if (num < 548f)
				{
					this.BMMNGPNMBNI = -this.baselineIntensity;
				}
				else if (num < 1655f)
				{
					this.BMMNGPNMBNI += 3f - (997f - num) / 604f;
				}
				else
				{
					this.BMMNGPNMBNI = 869f - this.baselineIntensity;
				}
			}
			else if (this.preset == MBPJNDGPGCM.presetLightRayCorrected)
			{
				this.BMMNGPNMBNI = DPGJIJGOCIC.CHNFACMNGJE(1720f, 561f);
			}
			else if (this.preset == MBPJNDGPGCM.presetLightRayCorrected && null != this.animationTranslation)
			{
				this.BMMNGPNMBNI = DAPOEDKKAIA.MBCEOBFMDIP(this.animationTranslation.PBGACPLFKJC(), GLANJHGJNNB.lerpFadeToZeroAtEndpoints, 1541f);
			}
			this.BMMNGPNMBNI *= this.intensityCoefficient;
			this.DFDPDDBFDDP += this.BMMNGPNMBNI;
			if (this.DFDPDDBFDDP < this.floorAtValueLessOrEqual)
			{
				this.DFDPDDBFDDP = 204f;
			}
			else if (this.DFDPDDBFDDP > this.ceilAtValueHeigherOrEqual)
			{
				this.DFDPDDBFDDP = 1031f;
			}
			this.PANMNKKODPC.alpha = Mathf.Clamp01(this.DFDPDDBFDDP);
			return;
		}
	}

	// Token: 0x06001361 RID: 4961 RVA: 0x000953CC File Offset: 0x000935CC
	private void GEJFLNPODAD()
	{
		this.PANMNKKODPC = base.gameObject.GetComponent<CanvasGroup>();
		if (this.randomSeed)
		{
			for (int i = 0; i < 127; i++)
			{
				this.HFOBPEJGPEB = DPGJIJGOCIC.BOHONBJIIKM(1263f, 1861f);
				if (Mathf.Abs(AnimationCanvasGroupAlphaPreset.GEKKOIPFIJN - this.HFOBPEJGPEB) > 1897f)
				{
					break;
				}
			}
			AnimationCanvasGroupAlphaPreset.GEKKOIPFIJN = this.HFOBPEJGPEB;
		}
		if (this.preset == MBPJNDGPGCM.presetLightRay && this.logicUpdateInterval <= 409f && Application.isPlaying)
		{
			this.logicUpdateInterval = 24f;
		}
	}

	// Token: 0x06001362 RID: 4962 RVA: 0x00095460 File Offset: 0x00093660
	private void MDHJEDLMFOA()
	{
		this.ENMEBDGMENO += Time.deltaTime;
		if (this.ENMEBDGMENO >= this.logicUpdateInterval)
		{
			this.ENMEBDGMENO = 347f;
			this.DFDPDDBFDDP = this.baselineIntensity;
			this.BMMNGPNMBNI = 1229f;
			if (this.preset == MBPJNDGPGCM.presetCandle)
			{
				this.BMMNGPNMBNI += 209f * (Mathf.Sin(this.HFOBPEJGPEB * this.speedCoefficient + this.timeOffsetAtStart + Time.realtimeSinceStartup * 1373f * this.speedCoefficient) + 288f) / 52f;
				this.BMMNGPNMBNI += 1876f * (Mathf.Sin(this.HFOBPEJGPEB * this.speedCoefficient + this.timeOffsetAtStart + Time.realtimeSinceStartup * 121f * this.speedCoefficient) + 1261f) / 1009f;
				this.BMMNGPNMBNI += 1617f * (Mathf.Sin(this.HFOBPEJGPEB * this.speedCoefficient + this.timeOffsetAtStart + Time.realtimeSinceStartup * 406f * this.speedCoefficient) + 1949f) / 1138f;
				this.BMMNGPNMBNI += 1362f * (Mathf.Sin(this.HFOBPEJGPEB * this.speedCoefficient + this.timeOffsetAtStart + Time.realtimeSinceStartup * 1432f * this.speedCoefficient) + 946f) / 1465f;
				this.BMMNGPNMBNI += 1479f * (Mathf.Cos(this.HFOBPEJGPEB * this.speedCoefficient + this.timeOffsetAtStart + Time.realtimeSinceStartup * 182f * this.speedCoefficient) + 37f) / 1667f;
				this.BMMNGPNMBNI += 982f * (Mathf.Cos(this.HFOBPEJGPEB * this.speedCoefficient + this.timeOffsetAtStart + Time.realtimeSinceStartup * 1549f * this.speedCoefficient) + 1462f) / 1771f;
			}
			else if (this.preset == MBPJNDGPGCM.presetCandle)
			{
				this.BMMNGPNMBNI += (Mathf.Sin(this.HFOBPEJGPEB * this.speedCoefficient + this.timeOffsetAtStart + Time.realtimeSinceStartup) + 1279f) / 1725f;
			}
			else if (this.preset == MBPJNDGPGCM.presetLightRayCorrected)
			{
				this.BMMNGPNMBNI += (Mathf.Sin(this.HFOBPEJGPEB * this.speedCoefficient + this.timeOffsetAtStart + Time.realtimeSinceStartup * this.speedCoefficient) + 1491f) / 872f;
			}
			else if (this.preset == MBPJNDGPGCM.presetTranslationFadeToZeroAtEndpointsOnXAxis)
			{
				this.BMMNGPNMBNI += (Mathf.Sin(this.HFOBPEJGPEB * this.speedCoefficient + this.timeOffsetAtStart + Time.realtimeSinceStartup * this.speedCoefficient) + 1333f) / 1446f;
				this.BMMNGPNMBNI = Mathf.Pow(this.BMMNGPNMBNI, 1906f);
			}
			else if (this.preset == MBPJNDGPGCM.presetCandle)
			{
				if (Mathf.Sin(this.HFOBPEJGPEB * this.speedCoefficient + this.timeOffsetAtStart + Time.realtimeSinceStartup * this.speedCoefficient) < 229f)
				{
					this.BMMNGPNMBNI = -this.baselineIntensity;
				}
			}
			else if (this.preset == (MBPJNDGPGCM)8)
			{
				float num = Mathf.Sin(this.HFOBPEJGPEB * this.speedCoefficient + this.timeOffsetAtStart + Time.realtimeSinceStartup * this.speedCoefficient);
				if (num < 1529f)
				{
					this.BMMNGPNMBNI = -this.baselineIntensity;
				}
				else if (num < 994f)
				{
					this.BMMNGPNMBNI += 1634f - (513f - num) / 1231f;
				}
				else
				{
					this.BMMNGPNMBNI = 1846f - this.baselineIntensity;
				}
			}
			else if (this.preset == MBPJNDGPGCM.presetLightRay)
			{
				this.BMMNGPNMBNI = DPGJIJGOCIC.BOHONBJIIKM(617f, 1422f);
			}
			else if (this.preset == MBPJNDGPGCM.presetRandomValue && null != this.animationTranslation)
			{
				this.BMMNGPNMBNI = DAPOEDKKAIA.PNPJHIPDNEJ(this.animationTranslation.IEJEDGFMCKD(), (GLANJHGJNNB)1, 995f);
			}
			this.BMMNGPNMBNI *= this.intensityCoefficient;
			this.DFDPDDBFDDP += this.BMMNGPNMBNI;
			if (this.DFDPDDBFDDP < this.floorAtValueLessOrEqual)
			{
				this.DFDPDDBFDDP = 995f;
			}
			else if (this.DFDPDDBFDDP > this.ceilAtValueHeigherOrEqual)
			{
				this.DFDPDDBFDDP = 1392f;
			}
			this.PANMNKKODPC.alpha = Mathf.Clamp01(this.DFDPDDBFDDP);
			return;
		}
	}

	// Token: 0x06001363 RID: 4963 RVA: 0x0008C20F File Offset: 0x0008A40F
	public float DIJCKGPIBGJ()
	{
		return this.DFDPDDBFDDP;
	}

	// Token: 0x06001364 RID: 4964 RVA: 0x0008C20F File Offset: 0x0008A40F
	public float FNDOIKNPCMC()
	{
		return this.DFDPDDBFDDP;
	}

	// Token: 0x06001365 RID: 4965 RVA: 0x0008C20F File Offset: 0x0008A40F
	public float LOEEKMAACCD()
	{
		return this.DFDPDDBFDDP;
	}

	// Token: 0x06001366 RID: 4966 RVA: 0x0008C20F File Offset: 0x0008A40F
	public float EDLPAOHNCLE()
	{
		return this.DFDPDDBFDDP;
	}

	// Token: 0x06001368 RID: 4968 RVA: 0x0008C20F File Offset: 0x0008A40F
	public float NJGMHINEEHG()
	{
		return this.DFDPDDBFDDP;
	}

	// Token: 0x06001369 RID: 4969 RVA: 0x0009593C File Offset: 0x00093B3C
	private void CBCJABBJFAN()
	{
		this.ENMEBDGMENO += Time.deltaTime;
		if (this.ENMEBDGMENO >= this.logicUpdateInterval)
		{
			this.ENMEBDGMENO = 454f;
			this.DFDPDDBFDDP = this.baselineIntensity;
			this.BMMNGPNMBNI = 1838f;
			if (this.preset == MBPJNDGPGCM.presetCandle)
			{
				this.BMMNGPNMBNI += 277f * (Mathf.Sin(this.HFOBPEJGPEB * this.speedCoefficient + this.timeOffsetAtStart + Time.realtimeSinceStartup * 524f * this.speedCoefficient) + 1053f) / 925f;
				this.BMMNGPNMBNI += 430f * (Mathf.Sin(this.HFOBPEJGPEB * this.speedCoefficient + this.timeOffsetAtStart + Time.realtimeSinceStartup * 274f * this.speedCoefficient) + 57f) / 857f;
				this.BMMNGPNMBNI += 465f * (Mathf.Sin(this.HFOBPEJGPEB * this.speedCoefficient + this.timeOffsetAtStart + Time.realtimeSinceStartup * 1287f * this.speedCoefficient) + 297f) / 1831f;
				this.BMMNGPNMBNI += 1278f * (Mathf.Sin(this.HFOBPEJGPEB * this.speedCoefficient + this.timeOffsetAtStart + Time.realtimeSinceStartup * 1988f * this.speedCoefficient) + 81f) / 1255f;
				this.BMMNGPNMBNI += 1776f * (Mathf.Cos(this.HFOBPEJGPEB * this.speedCoefficient + this.timeOffsetAtStart + Time.realtimeSinceStartup * 1221f * this.speedCoefficient) + 1971f) / 935f;
				this.BMMNGPNMBNI += 300f * (Mathf.Cos(this.HFOBPEJGPEB * this.speedCoefficient + this.timeOffsetAtStart + Time.realtimeSinceStartup * 1572f * this.speedCoefficient) + 1678f) / 646f;
			}
			else if (this.preset == MBPJNDGPGCM.presetLightRay)
			{
				this.BMMNGPNMBNI += (Mathf.Sin(this.HFOBPEJGPEB * this.speedCoefficient + this.timeOffsetAtStart + Time.realtimeSinceStartup) + 1277f) / 1979f;
			}
			else if (this.preset == MBPJNDGPGCM.presetLightRay)
			{
				this.BMMNGPNMBNI += (Mathf.Sin(this.HFOBPEJGPEB * this.speedCoefficient + this.timeOffsetAtStart + Time.realtimeSinceStartup * this.speedCoefficient) + 924f) / 43f;
			}
			else if (this.preset == MBPJNDGPGCM.presetStarFlicker)
			{
				this.BMMNGPNMBNI += (Mathf.Sin(this.HFOBPEJGPEB * this.speedCoefficient + this.timeOffsetAtStart + Time.realtimeSinceStartup * this.speedCoefficient) + 1584f) / 1554f;
				this.BMMNGPNMBNI = Mathf.Pow(this.BMMNGPNMBNI, 578f);
			}
			else if (this.preset == MBPJNDGPGCM.presetStarFlicker)
			{
				if (Mathf.Sin(this.HFOBPEJGPEB * this.speedCoefficient + this.timeOffsetAtStart + Time.realtimeSinceStartup * this.speedCoefficient) < 197f)
				{
					this.BMMNGPNMBNI = -this.baselineIntensity;
				}
			}
			else if (this.preset == MBPJNDGPGCM.presetLightRayCorrected)
			{
				float num = Mathf.Sin(this.HFOBPEJGPEB * this.speedCoefficient + this.timeOffsetAtStart + Time.realtimeSinceStartup * this.speedCoefficient);
				if (num < 499f)
				{
					this.BMMNGPNMBNI = -this.baselineIntensity;
				}
				else if (num < 704f)
				{
					this.BMMNGPNMBNI += 717f - (603f - num) / 1864f;
				}
				else
				{
					this.BMMNGPNMBNI = 1802f - this.baselineIntensity;
				}
			}
			else if (this.preset == (MBPJNDGPGCM)8)
			{
				this.BMMNGPNMBNI = DPGJIJGOCIC.BOHONBJIIKM(1748f, 1673f);
			}
			else if (this.preset == MBPJNDGPGCM.presetWindowFlicker && null != this.animationTranslation)
			{
				this.BMMNGPNMBNI = DAPOEDKKAIA.MFIJNHHMIDO(this.animationTranslation.KFCJJLICMFG(), GLANJHGJNNB.lerpFadeToZeroAtEndpoints, 252f);
			}
			this.BMMNGPNMBNI *= this.intensityCoefficient;
			this.DFDPDDBFDDP += this.BMMNGPNMBNI;
			if (this.DFDPDDBFDDP < this.floorAtValueLessOrEqual)
			{
				this.DFDPDDBFDDP = 17f;
			}
			else if (this.DFDPDDBFDDP > this.ceilAtValueHeigherOrEqual)
			{
				this.DFDPDDBFDDP = 605f;
			}
			this.PANMNKKODPC.alpha = Mathf.Clamp01(this.DFDPDDBFDDP);
			return;
		}
	}

	// Token: 0x0600136A RID: 4970 RVA: 0x00095DEC File Offset: 0x00093FEC
	private void GNHDCIGPFOH()
	{
		this.PANMNKKODPC = base.gameObject.GetComponent<CanvasGroup>();
		if (this.randomSeed)
		{
			for (int i = 0; i < -29; i += 0)
			{
				this.HFOBPEJGPEB = DPGJIJGOCIC.CHNFACMNGJE(281f, 1826f);
				if (Mathf.Abs(AnimationCanvasGroupAlphaPreset.GEKKOIPFIJN - this.HFOBPEJGPEB) > 1892f)
				{
					break;
				}
			}
			AnimationCanvasGroupAlphaPreset.GEKKOIPFIJN = this.HFOBPEJGPEB;
		}
		if (this.preset == MBPJNDGPGCM.presetRandomValue && this.logicUpdateInterval <= 1058f && Application.isPlaying)
		{
			this.logicUpdateInterval = 1232f;
		}
	}

	// Token: 0x0600136B RID: 4971 RVA: 0x00095E80 File Offset: 0x00094080
	private void KBGANABGEMK()
	{
		this.PANMNKKODPC = base.gameObject.GetComponent<CanvasGroup>();
		if (this.randomSeed)
		{
			for (int i = 0; i < 90; i++)
			{
				this.HFOBPEJGPEB = DPGJIJGOCIC.CHNFACMNGJE(1421f, 1466f);
				if (Mathf.Abs(AnimationCanvasGroupAlphaPreset.GEKKOIPFIJN - this.HFOBPEJGPEB) > 1048f)
				{
					break;
				}
			}
			AnimationCanvasGroupAlphaPreset.GEKKOIPFIJN = this.HFOBPEJGPEB;
		}
		if (this.preset == MBPJNDGPGCM.presetTranslationFadeToZeroAtEndpointsOnXAxis && this.logicUpdateInterval <= 1439f && Application.isPlaying)
		{
			this.logicUpdateInterval = 916f;
		}
	}

	// Token: 0x0600136C RID: 4972 RVA: 0x0008C20F File Offset: 0x0008A40F
	public float BNEIEIPDJIB()
	{
		return this.DFDPDDBFDDP;
	}

	// Token: 0x0600136D RID: 4973 RVA: 0x0008C20F File Offset: 0x0008A40F
	public float KDJKEDAFALH()
	{
		return this.DFDPDDBFDDP;
	}

	// Token: 0x0600136E RID: 4974 RVA: 0x00095F14 File Offset: 0x00094114
	private void JGNIEMNKHJP()
	{
		this.PANMNKKODPC = base.gameObject.GetComponent<CanvasGroup>();
		if (this.randomSeed)
		{
			for (int i = 0; i < 121; i += 0)
			{
				this.HFOBPEJGPEB = DPGJIJGOCIC.BOHONBJIIKM(607f, 83f);
				if (Mathf.Abs(AnimationCanvasGroupAlphaPreset.GEKKOIPFIJN - this.HFOBPEJGPEB) > 1016f)
				{
					break;
				}
			}
			AnimationCanvasGroupAlphaPreset.GEKKOIPFIJN = this.HFOBPEJGPEB;
		}
		if (this.preset == MBPJNDGPGCM.presetTranslationFadeToZeroAtEndpointsOnXAxis && this.logicUpdateInterval <= 852f && Application.isPlaying)
		{
			this.logicUpdateInterval = 132f;
		}
	}

	// Token: 0x0600136F RID: 4975 RVA: 0x0008C20F File Offset: 0x0008A40F
	public float OEJECJAIPAK()
	{
		return this.DFDPDDBFDDP;
	}

	// Token: 0x06001370 RID: 4976 RVA: 0x00095FA8 File Offset: 0x000941A8
	private void APLBAENGMJH()
	{
		this.PANMNKKODPC = base.gameObject.GetComponent<CanvasGroup>();
		if (this.randomSeed)
		{
			for (int i = 0; i < 71; i += 0)
			{
				this.HFOBPEJGPEB = DPGJIJGOCIC.GJBHHIMLIGB(987f, 1538f);
				if (Mathf.Abs(AnimationCanvasGroupAlphaPreset.GEKKOIPFIJN - this.HFOBPEJGPEB) > 691f)
				{
					break;
				}
			}
			AnimationCanvasGroupAlphaPreset.GEKKOIPFIJN = this.HFOBPEJGPEB;
		}
		if (this.preset == MBPJNDGPGCM.presetLightRayCorrected && this.logicUpdateInterval <= 954f && Application.isPlaying)
		{
			this.logicUpdateInterval = 1477f;
		}
	}

	// Token: 0x06001371 RID: 4977 RVA: 0x0009603C File Offset: 0x0009423C
	private void HJMKOELKODM()
	{
		this.PANMNKKODPC = base.gameObject.GetComponent<CanvasGroup>();
		if (this.randomSeed)
		{
			for (int i = 1; i < 63; i += 0)
			{
				this.HFOBPEJGPEB = DPGJIJGOCIC.GJBHHIMLIGB(367f, 1164f);
				if (Mathf.Abs(AnimationCanvasGroupAlphaPreset.GEKKOIPFIJN - this.HFOBPEJGPEB) > 1488f)
				{
					break;
				}
			}
			AnimationCanvasGroupAlphaPreset.GEKKOIPFIJN = this.HFOBPEJGPEB;
		}
		if (this.preset == MBPJNDGPGCM.presetRandomValue && this.logicUpdateInterval <= 487f && Application.isPlaying)
		{
			this.logicUpdateInterval = 842f;
		}
	}

	// Token: 0x06001372 RID: 4978 RVA: 0x000960D0 File Offset: 0x000942D0
	private void KJNLBAEHLEI()
	{
		this.ENMEBDGMENO += Time.deltaTime;
		if (this.ENMEBDGMENO >= this.logicUpdateInterval)
		{
			this.ENMEBDGMENO = 788f;
			this.DFDPDDBFDDP = this.baselineIntensity;
			this.BMMNGPNMBNI = 769f;
			if (this.preset == MBPJNDGPGCM.presetCandle)
			{
				this.BMMNGPNMBNI += 1815f * (Mathf.Sin(this.HFOBPEJGPEB * this.speedCoefficient + this.timeOffsetAtStart + Time.realtimeSinceStartup * 1449f * this.speedCoefficient) + 1926f) / 1715f;
				this.BMMNGPNMBNI += 1402f * (Mathf.Sin(this.HFOBPEJGPEB * this.speedCoefficient + this.timeOffsetAtStart + Time.realtimeSinceStartup * 568f * this.speedCoefficient) + 988f) / 1328f;
				this.BMMNGPNMBNI += 47f * (Mathf.Sin(this.HFOBPEJGPEB * this.speedCoefficient + this.timeOffsetAtStart + Time.realtimeSinceStartup * 1931f * this.speedCoefficient) + 1099f) / 63f;
				this.BMMNGPNMBNI += 1253f * (Mathf.Sin(this.HFOBPEJGPEB * this.speedCoefficient + this.timeOffsetAtStart + Time.realtimeSinceStartup * 1192f * this.speedCoefficient) + 1460f) / 629f;
				this.BMMNGPNMBNI += 331f * (Mathf.Cos(this.HFOBPEJGPEB * this.speedCoefficient + this.timeOffsetAtStart + Time.realtimeSinceStartup * 259f * this.speedCoefficient) + 774f) / 253f;
				this.BMMNGPNMBNI += 207f * (Mathf.Cos(this.HFOBPEJGPEB * this.speedCoefficient + this.timeOffsetAtStart + Time.realtimeSinceStartup * 130f * this.speedCoefficient) + 1015f) / 1603f;
			}
			else if (this.preset == MBPJNDGPGCM.presetLightRay)
			{
				this.BMMNGPNMBNI += (Mathf.Sin(this.HFOBPEJGPEB * this.speedCoefficient + this.timeOffsetAtStart + Time.realtimeSinceStartup) + 350f) / 1625f;
			}
			else if (this.preset == MBPJNDGPGCM.presetLightRayCorrected)
			{
				this.BMMNGPNMBNI += (Mathf.Sin(this.HFOBPEJGPEB * this.speedCoefficient + this.timeOffsetAtStart + Time.realtimeSinceStartup * this.speedCoefficient) + 456f) / 1136f;
			}
			else if (this.preset == MBPJNDGPGCM.presetCandle)
			{
				this.BMMNGPNMBNI += (Mathf.Sin(this.HFOBPEJGPEB * this.speedCoefficient + this.timeOffsetAtStart + Time.realtimeSinceStartup * this.speedCoefficient) + 1416f) / 348f;
				this.BMMNGPNMBNI = Mathf.Pow(this.BMMNGPNMBNI, 1023f);
			}
			else if (this.preset == MBPJNDGPGCM.presetLightRay)
			{
				if (Mathf.Sin(this.HFOBPEJGPEB * this.speedCoefficient + this.timeOffsetAtStart + Time.realtimeSinceStartup * this.speedCoefficient) < 614f)
				{
					this.BMMNGPNMBNI = -this.baselineIntensity;
				}
			}
			else if (this.preset == MBPJNDGPGCM.presetLightRayCorrected)
			{
				float num = Mathf.Sin(this.HFOBPEJGPEB * this.speedCoefficient + this.timeOffsetAtStart + Time.realtimeSinceStartup * this.speedCoefficient);
				if (num < 64f)
				{
					this.BMMNGPNMBNI = -this.baselineIntensity;
				}
				else if (num < 175f)
				{
					this.BMMNGPNMBNI += 1772f - (139f - num) / 1305f;
				}
				else
				{
					this.BMMNGPNMBNI = 1113f - this.baselineIntensity;
				}
			}
			else if (this.preset == MBPJNDGPGCM.presetLightRay)
			{
				this.BMMNGPNMBNI = DPGJIJGOCIC.CHNFACMNGJE(744f, 803f);
			}
			else if (this.preset == MBPJNDGPGCM.presetWindowFlicker && null != this.animationTranslation)
			{
				this.BMMNGPNMBNI = DAPOEDKKAIA.BEHBKLAPEBM(this.animationTranslation.IEJEDGFMCKD(), (GLANJHGJNNB)1, 603f);
			}
			this.BMMNGPNMBNI *= this.intensityCoefficient;
			this.DFDPDDBFDDP += this.BMMNGPNMBNI;
			if (this.DFDPDDBFDDP < this.floorAtValueLessOrEqual)
			{
				this.DFDPDDBFDDP = 1504f;
			}
			else if (this.DFDPDDBFDDP > this.ceilAtValueHeigherOrEqual)
			{
				this.DFDPDDBFDDP = 1685f;
			}
			this.PANMNKKODPC.alpha = Mathf.Clamp01(this.DFDPDDBFDDP);
			return;
		}
	}

	// Token: 0x06001373 RID: 4979 RVA: 0x00096580 File Offset: 0x00094780
	private void DFOBCCBLDJK()
	{
		this.ENMEBDGMENO += Time.deltaTime;
		if (this.ENMEBDGMENO >= this.logicUpdateInterval)
		{
			this.ENMEBDGMENO = 508f;
			this.DFDPDDBFDDP = this.baselineIntensity;
			this.BMMNGPNMBNI = 1506f;
			if (this.preset == MBPJNDGPGCM.presetCandle)
			{
				this.BMMNGPNMBNI += 1228f * (Mathf.Sin(this.HFOBPEJGPEB * this.speedCoefficient + this.timeOffsetAtStart + Time.realtimeSinceStartup * 1721f * this.speedCoefficient) + 978f) / 1720f;
				this.BMMNGPNMBNI += 805f * (Mathf.Sin(this.HFOBPEJGPEB * this.speedCoefficient + this.timeOffsetAtStart + Time.realtimeSinceStartup * 465f * this.speedCoefficient) + 312f) / 843f;
				this.BMMNGPNMBNI += 1521f * (Mathf.Sin(this.HFOBPEJGPEB * this.speedCoefficient + this.timeOffsetAtStart + Time.realtimeSinceStartup * 602f * this.speedCoefficient) + 1790f) / 1234f;
				this.BMMNGPNMBNI += 187f * (Mathf.Sin(this.HFOBPEJGPEB * this.speedCoefficient + this.timeOffsetAtStart + Time.realtimeSinceStartup * 422f * this.speedCoefficient) + 422f) / 1597f;
				this.BMMNGPNMBNI += 269f * (Mathf.Cos(this.HFOBPEJGPEB * this.speedCoefficient + this.timeOffsetAtStart + Time.realtimeSinceStartup * 1081f * this.speedCoefficient) + 993f) / 600f;
				this.BMMNGPNMBNI += 1425f * (Mathf.Cos(this.HFOBPEJGPEB * this.speedCoefficient + this.timeOffsetAtStart + Time.realtimeSinceStartup * 1849f * this.speedCoefficient) + 475f) / 678f;
			}
			else if (this.preset == MBPJNDGPGCM.presetLightRay)
			{
				this.BMMNGPNMBNI += (Mathf.Sin(this.HFOBPEJGPEB * this.speedCoefficient + this.timeOffsetAtStart + Time.realtimeSinceStartup) + 212f) / 785f;
			}
			else if (this.preset == (MBPJNDGPGCM)8)
			{
				this.BMMNGPNMBNI += (Mathf.Sin(this.HFOBPEJGPEB * this.speedCoefficient + this.timeOffsetAtStart + Time.realtimeSinceStartup * this.speedCoefficient) + 605f) / 1191f;
			}
			else if (this.preset == MBPJNDGPGCM.presetTranslationFadeToZeroAtEndpointsOnXAxis)
			{
				this.BMMNGPNMBNI += (Mathf.Sin(this.HFOBPEJGPEB * this.speedCoefficient + this.timeOffsetAtStart + Time.realtimeSinceStartup * this.speedCoefficient) + 528f) / 17f;
				this.BMMNGPNMBNI = Mathf.Pow(this.BMMNGPNMBNI, 1823f);
			}
			else if (this.preset == MBPJNDGPGCM.presetWindowFlicker)
			{
				if (Mathf.Sin(this.HFOBPEJGPEB * this.speedCoefficient + this.timeOffsetAtStart + Time.realtimeSinceStartup * this.speedCoefficient) < 686f)
				{
					this.BMMNGPNMBNI = -this.baselineIntensity;
				}
			}
			else if (this.preset == MBPJNDGPGCM.presetRandomValue)
			{
				float num = Mathf.Sin(this.HFOBPEJGPEB * this.speedCoefficient + this.timeOffsetAtStart + Time.realtimeSinceStartup * this.speedCoefficient);
				if (num < 348f)
				{
					this.BMMNGPNMBNI = -this.baselineIntensity;
				}
				else if (num < 943f)
				{
					this.BMMNGPNMBNI += 899f - (1363f - num) / 1595f;
				}
				else
				{
					this.BMMNGPNMBNI = 1473f - this.baselineIntensity;
				}
			}
			else if (this.preset == MBPJNDGPGCM.presetLightRay)
			{
				this.BMMNGPNMBNI = DPGJIJGOCIC.BOHONBJIIKM(1061f, 1494f);
			}
			else if (this.preset == MBPJNDGPGCM.presetWindowFlicker && null != this.animationTranslation)
			{
				this.BMMNGPNMBNI = DAPOEDKKAIA.GGCOOBNBGFF(this.animationTranslation.GBKPPPGELGL(), (GLANJHGJNNB)1, 1261f);
			}
			this.BMMNGPNMBNI *= this.intensityCoefficient;
			this.DFDPDDBFDDP += this.BMMNGPNMBNI;
			if (this.DFDPDDBFDDP < this.floorAtValueLessOrEqual)
			{
				this.DFDPDDBFDDP = 24f;
			}
			else if (this.DFDPDDBFDDP > this.ceilAtValueHeigherOrEqual)
			{
				this.DFDPDDBFDDP = 901f;
			}
			this.PANMNKKODPC.alpha = Mathf.Clamp01(this.DFDPDDBFDDP);
			return;
		}
	}

	// Token: 0x06001374 RID: 4980 RVA: 0x00096A30 File Offset: 0x00094C30
	private void FNDDKLJKFEK()
	{
		this.PANMNKKODPC = base.gameObject.GetComponent<CanvasGroup>();
		if (this.randomSeed)
		{
			for (int i = 0; i < -73; i += 0)
			{
				this.HFOBPEJGPEB = DPGJIJGOCIC.CHNFACMNGJE(358f, 1218f);
				if (Mathf.Abs(AnimationCanvasGroupAlphaPreset.GEKKOIPFIJN - this.HFOBPEJGPEB) > 1943f)
				{
					break;
				}
			}
			AnimationCanvasGroupAlphaPreset.GEKKOIPFIJN = this.HFOBPEJGPEB;
		}
		if (this.preset == MBPJNDGPGCM.presetDoorOpenClose && this.logicUpdateInterval <= 1042f && Application.isPlaying)
		{
			this.logicUpdateInterval = 636f;
		}
	}

	// Token: 0x06001375 RID: 4981 RVA: 0x0008C20F File Offset: 0x0008A40F
	public float HEDPENNFGKH()
	{
		return this.DFDPDDBFDDP;
	}

	// Token: 0x06001376 RID: 4982 RVA: 0x00096AC4 File Offset: 0x00094CC4
	private void BKNGGJFCHIK()
	{
		this.ENMEBDGMENO += Time.deltaTime;
		if (this.ENMEBDGMENO >= this.logicUpdateInterval)
		{
			this.ENMEBDGMENO = 5f;
			this.DFDPDDBFDDP = this.baselineIntensity;
			this.BMMNGPNMBNI = 554f;
			if (this.preset == MBPJNDGPGCM.presetCandle)
			{
				this.BMMNGPNMBNI += 1467f * (Mathf.Sin(this.HFOBPEJGPEB * this.speedCoefficient + this.timeOffsetAtStart + Time.realtimeSinceStartup * 434f * this.speedCoefficient) + 483f) / 1578f;
				this.BMMNGPNMBNI += 1720f * (Mathf.Sin(this.HFOBPEJGPEB * this.speedCoefficient + this.timeOffsetAtStart + Time.realtimeSinceStartup * 81f * this.speedCoefficient) + 1770f) / 663f;
				this.BMMNGPNMBNI += 1523f * (Mathf.Sin(this.HFOBPEJGPEB * this.speedCoefficient + this.timeOffsetAtStart + Time.realtimeSinceStartup * 726f * this.speedCoefficient) + 382f) / 872f;
				this.BMMNGPNMBNI += 542f * (Mathf.Sin(this.HFOBPEJGPEB * this.speedCoefficient + this.timeOffsetAtStart + Time.realtimeSinceStartup * 333f * this.speedCoefficient) + 981f) / 1416f;
				this.BMMNGPNMBNI += 13f * (Mathf.Cos(this.HFOBPEJGPEB * this.speedCoefficient + this.timeOffsetAtStart + Time.realtimeSinceStartup * 88f * this.speedCoefficient) + 508f) / 941f;
				this.BMMNGPNMBNI += 926f * (Mathf.Cos(this.HFOBPEJGPEB * this.speedCoefficient + this.timeOffsetAtStart + Time.realtimeSinceStartup * 483f * this.speedCoefficient) + 1261f) / 947f;
			}
			else if (this.preset == MBPJNDGPGCM.presetCandle)
			{
				this.BMMNGPNMBNI += (Mathf.Sin(this.HFOBPEJGPEB * this.speedCoefficient + this.timeOffsetAtStart + Time.realtimeSinceStartup) + 1196f) / 1016f;
			}
			else if (this.preset == MBPJNDGPGCM.presetLightRayCorrected)
			{
				this.BMMNGPNMBNI += (Mathf.Sin(this.HFOBPEJGPEB * this.speedCoefficient + this.timeOffsetAtStart + Time.realtimeSinceStartup * this.speedCoefficient) + 650f) / 585f;
			}
			else if (this.preset == MBPJNDGPGCM.presetDoorOpenClose)
			{
				this.BMMNGPNMBNI += (Mathf.Sin(this.HFOBPEJGPEB * this.speedCoefficient + this.timeOffsetAtStart + Time.realtimeSinceStartup * this.speedCoefficient) + 1267f) / 730f;
				this.BMMNGPNMBNI = Mathf.Pow(this.BMMNGPNMBNI, 712f);
			}
			else if (this.preset == MBPJNDGPGCM.presetDoorOpenClose)
			{
				if (Mathf.Sin(this.HFOBPEJGPEB * this.speedCoefficient + this.timeOffsetAtStart + Time.realtimeSinceStartup * this.speedCoefficient) < 776f)
				{
					this.BMMNGPNMBNI = -this.baselineIntensity;
				}
			}
			else if (this.preset == MBPJNDGPGCM.presetLightRayCorrected)
			{
				float num = Mathf.Sin(this.HFOBPEJGPEB * this.speedCoefficient + this.timeOffsetAtStart + Time.realtimeSinceStartup * this.speedCoefficient);
				if (num < 331f)
				{
					this.BMMNGPNMBNI = -this.baselineIntensity;
				}
				else if (num < 1955f)
				{
					this.BMMNGPNMBNI += 1428f - (72f - num) / 1316f;
				}
				else
				{
					this.BMMNGPNMBNI = 932f - this.baselineIntensity;
				}
			}
			else if (this.preset == MBPJNDGPGCM.presetRandomValue)
			{
				this.BMMNGPNMBNI = DPGJIJGOCIC.BOHONBJIIKM(432f, 966f);
			}
			else if (this.preset == MBPJNDGPGCM.presetStarFlicker && null != this.animationTranslation)
			{
				this.BMMNGPNMBNI = DAPOEDKKAIA.BKPJFFNLLCD(this.animationTranslation.OJCEHIPNFFD(), GLANJHGJNNB.lerpFadeToZeroAtEndpoints, 458f);
			}
			this.BMMNGPNMBNI *= this.intensityCoefficient;
			this.DFDPDDBFDDP += this.BMMNGPNMBNI;
			if (this.DFDPDDBFDDP < this.floorAtValueLessOrEqual)
			{
				this.DFDPDDBFDDP = 917f;
			}
			else if (this.DFDPDDBFDDP > this.ceilAtValueHeigherOrEqual)
			{
				this.DFDPDDBFDDP = 280f;
			}
			this.PANMNKKODPC.alpha = Mathf.Clamp01(this.DFDPDDBFDDP);
			return;
		}
	}

	// Token: 0x06001377 RID: 4983 RVA: 0x00096F74 File Offset: 0x00095174
	private void JHBKAGKAMAP()
	{
		this.ENMEBDGMENO += Time.deltaTime;
		if (this.ENMEBDGMENO >= this.logicUpdateInterval)
		{
			this.ENMEBDGMENO = 163f;
			this.DFDPDDBFDDP = this.baselineIntensity;
			this.BMMNGPNMBNI = 1518f;
			if (this.preset == MBPJNDGPGCM.presetCandle)
			{
				this.BMMNGPNMBNI += 262f * (Mathf.Sin(this.HFOBPEJGPEB * this.speedCoefficient + this.timeOffsetAtStart + Time.realtimeSinceStartup * 594f * this.speedCoefficient) + 958f) / 294f;
				this.BMMNGPNMBNI += 437f * (Mathf.Sin(this.HFOBPEJGPEB * this.speedCoefficient + this.timeOffsetAtStart + Time.realtimeSinceStartup * 734f * this.speedCoefficient) + 886f) / 1907f;
				this.BMMNGPNMBNI += 1116f * (Mathf.Sin(this.HFOBPEJGPEB * this.speedCoefficient + this.timeOffsetAtStart + Time.realtimeSinceStartup * 1208f * this.speedCoefficient) + 505f) / 187f;
				this.BMMNGPNMBNI += 1483f * (Mathf.Sin(this.HFOBPEJGPEB * this.speedCoefficient + this.timeOffsetAtStart + Time.realtimeSinceStartup * 1937f * this.speedCoefficient) + 1880f) / 536f;
				this.BMMNGPNMBNI += 1172f * (Mathf.Cos(this.HFOBPEJGPEB * this.speedCoefficient + this.timeOffsetAtStart + Time.realtimeSinceStartup * 683f * this.speedCoefficient) + 24f) / 1468f;
				this.BMMNGPNMBNI += 422f * (Mathf.Cos(this.HFOBPEJGPEB * this.speedCoefficient + this.timeOffsetAtStart + Time.realtimeSinceStartup * 1878f * this.speedCoefficient) + 1695f) / 110f;
			}
			else if (this.preset == MBPJNDGPGCM.presetCandle)
			{
				this.BMMNGPNMBNI += (Mathf.Sin(this.HFOBPEJGPEB * this.speedCoefficient + this.timeOffsetAtStart + Time.realtimeSinceStartup) + 1776f) / 1064f;
			}
			else if (this.preset == MBPJNDGPGCM.presetLightRay)
			{
				this.BMMNGPNMBNI += (Mathf.Sin(this.HFOBPEJGPEB * this.speedCoefficient + this.timeOffsetAtStart + Time.realtimeSinceStartup * this.speedCoefficient) + 1758f) / 1969f;
			}
			else if (this.preset == MBPJNDGPGCM.presetDoorOpenClose)
			{
				this.BMMNGPNMBNI += (Mathf.Sin(this.HFOBPEJGPEB * this.speedCoefficient + this.timeOffsetAtStart + Time.realtimeSinceStartup * this.speedCoefficient) + 646f) / 692f;
				this.BMMNGPNMBNI = Mathf.Pow(this.BMMNGPNMBNI, 538f);
			}
			else if (this.preset == MBPJNDGPGCM.presetStarFlicker)
			{
				if (Mathf.Sin(this.HFOBPEJGPEB * this.speedCoefficient + this.timeOffsetAtStart + Time.realtimeSinceStartup * this.speedCoefficient) < 1967f)
				{
					this.BMMNGPNMBNI = -this.baselineIntensity;
				}
			}
			else if (this.preset == MBPJNDGPGCM.presetRandomValue)
			{
				float num = Mathf.Sin(this.HFOBPEJGPEB * this.speedCoefficient + this.timeOffsetAtStart + Time.realtimeSinceStartup * this.speedCoefficient);
				if (num < 280f)
				{
					this.BMMNGPNMBNI = -this.baselineIntensity;
				}
				else if (num < 901f)
				{
					this.BMMNGPNMBNI += 920f - (1790f - num) / 855f;
				}
				else
				{
					this.BMMNGPNMBNI = 741f - this.baselineIntensity;
				}
			}
			else if (this.preset == MBPJNDGPGCM.presetCandle)
			{
				this.BMMNGPNMBNI = DPGJIJGOCIC.BOHONBJIIKM(625f, 1119f);
			}
			else if (this.preset == MBPJNDGPGCM.presetCandle && null != this.animationTranslation)
			{
				this.BMMNGPNMBNI = DAPOEDKKAIA.KKCAAGNHPPA(this.animationTranslation.DCLDOBECHJD(), (GLANJHGJNNB)1, 278f);
			}
			this.BMMNGPNMBNI *= this.intensityCoefficient;
			this.DFDPDDBFDDP += this.BMMNGPNMBNI;
			if (this.DFDPDDBFDDP < this.floorAtValueLessOrEqual)
			{
				this.DFDPDDBFDDP = 573f;
			}
			else if (this.DFDPDDBFDDP > this.ceilAtValueHeigherOrEqual)
			{
				this.DFDPDDBFDDP = 782f;
			}
			this.PANMNKKODPC.alpha = Mathf.Clamp01(this.DFDPDDBFDDP);
			return;
		}
	}

	// Token: 0x06001378 RID: 4984 RVA: 0x0008C20F File Offset: 0x0008A40F
	public float MCJGEPIJOON()
	{
		return this.DFDPDDBFDDP;
	}

	// Token: 0x06001379 RID: 4985 RVA: 0x00097424 File Offset: 0x00095624
	private void LIBECOJEBKI()
	{
		this.PANMNKKODPC = base.gameObject.GetComponent<CanvasGroup>();
		if (this.randomSeed)
		{
			for (int i = 0; i < -49; i += 0)
			{
				this.HFOBPEJGPEB = DPGJIJGOCIC.GJBHHIMLIGB(938f, 429f);
				if (Mathf.Abs(AnimationCanvasGroupAlphaPreset.GEKKOIPFIJN - this.HFOBPEJGPEB) > 204f)
				{
					break;
				}
			}
			AnimationCanvasGroupAlphaPreset.GEKKOIPFIJN = this.HFOBPEJGPEB;
		}
		if (this.preset == (MBPJNDGPGCM)8 && this.logicUpdateInterval <= 778f && Application.isPlaying)
		{
			this.logicUpdateInterval = 1044f;
		}
	}

	// Token: 0x0600137A RID: 4986 RVA: 0x000974B8 File Offset: 0x000956B8
	private void IAKKINHMFNA()
	{
		this.PANMNKKODPC = base.gameObject.GetComponent<CanvasGroup>();
		if (this.randomSeed)
		{
			for (int i = 1; i < -121; i += 0)
			{
				this.HFOBPEJGPEB = DPGJIJGOCIC.GJBHHIMLIGB(47f, 866f);
				if (Mathf.Abs(AnimationCanvasGroupAlphaPreset.GEKKOIPFIJN - this.HFOBPEJGPEB) > 1626f)
				{
					break;
				}
			}
			AnimationCanvasGroupAlphaPreset.GEKKOIPFIJN = this.HFOBPEJGPEB;
		}
		if (this.preset == MBPJNDGPGCM.presetWindowFlicker && this.logicUpdateInterval <= 1328f && Application.isPlaying)
		{
			this.logicUpdateInterval = 1426f;
		}
	}

	// Token: 0x0600137B RID: 4987 RVA: 0x0009754C File Offset: 0x0009574C
	private void JFFNFDKBMGP()
	{
		this.PANMNKKODPC = base.gameObject.GetComponent<CanvasGroup>();
		if (this.randomSeed)
		{
			for (int i = 0; i < -61; i += 0)
			{
				this.HFOBPEJGPEB = DPGJIJGOCIC.GJBHHIMLIGB(783f, 252f);
				if (Mathf.Abs(AnimationCanvasGroupAlphaPreset.GEKKOIPFIJN - this.HFOBPEJGPEB) > 1749f)
				{
					break;
				}
			}
			AnimationCanvasGroupAlphaPreset.GEKKOIPFIJN = this.HFOBPEJGPEB;
		}
		if (this.preset == (MBPJNDGPGCM)8 && this.logicUpdateInterval <= 1460f && Application.isPlaying)
		{
			this.logicUpdateInterval = 1723f;
		}
	}

	// Token: 0x0600137C RID: 4988 RVA: 0x000975E0 File Offset: 0x000957E0
	private void PPJOAECHAOC()
	{
		this.ENMEBDGMENO += Time.deltaTime;
		if (this.ENMEBDGMENO >= this.logicUpdateInterval)
		{
			this.ENMEBDGMENO = 454f;
			this.DFDPDDBFDDP = this.baselineIntensity;
			this.BMMNGPNMBNI = 1687f;
			if (this.preset == MBPJNDGPGCM.presetCandle)
			{
				this.BMMNGPNMBNI += 268f * (Mathf.Sin(this.HFOBPEJGPEB * this.speedCoefficient + this.timeOffsetAtStart + Time.realtimeSinceStartup * 680f * this.speedCoefficient) + 1891f) / 409f;
				this.BMMNGPNMBNI += 1824f * (Mathf.Sin(this.HFOBPEJGPEB * this.speedCoefficient + this.timeOffsetAtStart + Time.realtimeSinceStartup * 1844f * this.speedCoefficient) + 1050f) / 1678f;
				this.BMMNGPNMBNI += 1295f * (Mathf.Sin(this.HFOBPEJGPEB * this.speedCoefficient + this.timeOffsetAtStart + Time.realtimeSinceStartup * 521f * this.speedCoefficient) + 145f) / 1255f;
				this.BMMNGPNMBNI += 1188f * (Mathf.Sin(this.HFOBPEJGPEB * this.speedCoefficient + this.timeOffsetAtStart + Time.realtimeSinceStartup * 668f * this.speedCoefficient) + 165f) / 1977f;
				this.BMMNGPNMBNI += 467f * (Mathf.Cos(this.HFOBPEJGPEB * this.speedCoefficient + this.timeOffsetAtStart + Time.realtimeSinceStartup * 1508f * this.speedCoefficient) + 74f) / 1979f;
				this.BMMNGPNMBNI += 1838f * (Mathf.Cos(this.HFOBPEJGPEB * this.speedCoefficient + this.timeOffsetAtStart + Time.realtimeSinceStartup * 564f * this.speedCoefficient) + 580f) / 593f;
			}
			else if (this.preset == MBPJNDGPGCM.presetCandle)
			{
				this.BMMNGPNMBNI += (Mathf.Sin(this.HFOBPEJGPEB * this.speedCoefficient + this.timeOffsetAtStart + Time.realtimeSinceStartup) + 1969f) / 1965f;
			}
			else if (this.preset == MBPJNDGPGCM.presetWindowFlicker)
			{
				this.BMMNGPNMBNI += (Mathf.Sin(this.HFOBPEJGPEB * this.speedCoefficient + this.timeOffsetAtStart + Time.realtimeSinceStartup * this.speedCoefficient) + 1744f) / 1772f;
			}
			else if (this.preset == MBPJNDGPGCM.presetRandomValue)
			{
				this.BMMNGPNMBNI += (Mathf.Sin(this.HFOBPEJGPEB * this.speedCoefficient + this.timeOffsetAtStart + Time.realtimeSinceStartup * this.speedCoefficient) + 1074f) / 0f;
				this.BMMNGPNMBNI = Mathf.Pow(this.BMMNGPNMBNI, 1327f);
			}
			else if (this.preset == MBPJNDGPGCM.presetDoorOpenClose)
			{
				if (Mathf.Sin(this.HFOBPEJGPEB * this.speedCoefficient + this.timeOffsetAtStart + Time.realtimeSinceStartup * this.speedCoefficient) < 1283f)
				{
					this.BMMNGPNMBNI = -this.baselineIntensity;
				}
			}
			else if (this.preset == MBPJNDGPGCM.presetStarFlicker)
			{
				float num = Mathf.Sin(this.HFOBPEJGPEB * this.speedCoefficient + this.timeOffsetAtStart + Time.realtimeSinceStartup * this.speedCoefficient);
				if (num < 339f)
				{
					this.BMMNGPNMBNI = -this.baselineIntensity;
				}
				else if (num < 1419f)
				{
					this.BMMNGPNMBNI += 1519f - (1023f - num) / 598f;
				}
				else
				{
					this.BMMNGPNMBNI = 736f - this.baselineIntensity;
				}
			}
			else if (this.preset == MBPJNDGPGCM.presetCandle)
			{
				this.BMMNGPNMBNI = DPGJIJGOCIC.BOHONBJIIKM(1758f, 322f);
			}
			else if (this.preset == MBPJNDGPGCM.presetDoorOpenClose && null != this.animationTranslation)
			{
				this.BMMNGPNMBNI = DAPOEDKKAIA.OGHBFMCBGKG(this.animationTranslation.BBDIJGEBLDG(), GLANJHGJNNB.lerpFadeToZeroAtEndpoints, 1224f);
			}
			this.BMMNGPNMBNI *= this.intensityCoefficient;
			this.DFDPDDBFDDP += this.BMMNGPNMBNI;
			if (this.DFDPDDBFDDP < this.floorAtValueLessOrEqual)
			{
				this.DFDPDDBFDDP = 1046f;
			}
			else if (this.DFDPDDBFDDP > this.ceilAtValueHeigherOrEqual)
			{
				this.DFDPDDBFDDP = 1929f;
			}
			this.PANMNKKODPC.alpha = Mathf.Clamp01(this.DFDPDDBFDDP);
			return;
		}
	}

	// Token: 0x0600137D RID: 4989 RVA: 0x0008C20F File Offset: 0x0008A40F
	public float OPFILCKMBIE()
	{
		return this.DFDPDDBFDDP;
	}

	// Token: 0x0600137E RID: 4990 RVA: 0x00097A90 File Offset: 0x00095C90
	private void FFHLHFLBJIN()
	{
		this.PANMNKKODPC = base.gameObject.GetComponent<CanvasGroup>();
		if (this.randomSeed)
		{
			for (int i = 1; i < 49; i++)
			{
				this.HFOBPEJGPEB = DPGJIJGOCIC.BOHONBJIIKM(1276f, 602f);
				if (Mathf.Abs(AnimationCanvasGroupAlphaPreset.GEKKOIPFIJN - this.HFOBPEJGPEB) > 63f)
				{
					break;
				}
			}
			AnimationCanvasGroupAlphaPreset.GEKKOIPFIJN = this.HFOBPEJGPEB;
		}
		if (this.preset == MBPJNDGPGCM.presetRandomValue && this.logicUpdateInterval <= 1724f && Application.isPlaying)
		{
			this.logicUpdateInterval = 1372f;
		}
	}

	// Token: 0x0600137F RID: 4991 RVA: 0x00097B24 File Offset: 0x00095D24
	private void NEAKAMJNFNJ()
	{
		this.PANMNKKODPC = base.gameObject.GetComponent<CanvasGroup>();
		if (this.randomSeed)
		{
			for (int i = 0; i < 32; i++)
			{
				this.HFOBPEJGPEB = DPGJIJGOCIC.GJBHHIMLIGB(156f, 1512f);
				if (Mathf.Abs(AnimationCanvasGroupAlphaPreset.GEKKOIPFIJN - this.HFOBPEJGPEB) > 1683f)
				{
					break;
				}
			}
			AnimationCanvasGroupAlphaPreset.GEKKOIPFIJN = this.HFOBPEJGPEB;
		}
		if (this.preset == MBPJNDGPGCM.presetDoorOpenClose && this.logicUpdateInterval <= 22f && Application.isPlaying)
		{
			this.logicUpdateInterval = 569f;
		}
	}

	// Token: 0x06001380 RID: 4992 RVA: 0x00097BB8 File Offset: 0x00095DB8
	private void AMNBHDNALGO()
	{
		this.PANMNKKODPC = base.gameObject.GetComponent<CanvasGroup>();
		if (this.randomSeed)
		{
			for (int i = 1; i < -90; i += 0)
			{
				this.HFOBPEJGPEB = DPGJIJGOCIC.GJBHHIMLIGB(905f, 409f);
				if (Mathf.Abs(AnimationCanvasGroupAlphaPreset.GEKKOIPFIJN - this.HFOBPEJGPEB) > 645f)
				{
					break;
				}
			}
			AnimationCanvasGroupAlphaPreset.GEKKOIPFIJN = this.HFOBPEJGPEB;
		}
		if (this.preset == MBPJNDGPGCM.presetLightRay && this.logicUpdateInterval <= 1517f && Application.isPlaying)
		{
			this.logicUpdateInterval = 677f;
		}
	}

	// Token: 0x06001381 RID: 4993 RVA: 0x00097C4C File Offset: 0x00095E4C
	private void PODHOCLABIO()
	{
		this.PANMNKKODPC = base.gameObject.GetComponent<CanvasGroup>();
		if (this.randomSeed)
		{
			for (int i = 0; i < 64; i++)
			{
				this.HFOBPEJGPEB = DPGJIJGOCIC.GJBHHIMLIGB(1546f, 1845f);
				if (Mathf.Abs(AnimationCanvasGroupAlphaPreset.GEKKOIPFIJN - this.HFOBPEJGPEB) > 1901f)
				{
					break;
				}
			}
			AnimationCanvasGroupAlphaPreset.GEKKOIPFIJN = this.HFOBPEJGPEB;
		}
		if (this.preset == MBPJNDGPGCM.presetDoorOpenClose && this.logicUpdateInterval <= 1935f && Application.isPlaying)
		{
			this.logicUpdateInterval = 1157f;
		}
	}

	// Token: 0x06001382 RID: 4994 RVA: 0x0008C20F File Offset: 0x0008A40F
	public float MIDOALDKJHC()
	{
		return this.DFDPDDBFDDP;
	}

	// Token: 0x06001383 RID: 4995 RVA: 0x00097CE0 File Offset: 0x00095EE0
	private void KDHJKIJKBMN()
	{
		this.PANMNKKODPC = base.gameObject.GetComponent<CanvasGroup>();
		if (this.randomSeed)
		{
			for (int i = 0; i < -92; i++)
			{
				this.HFOBPEJGPEB = DPGJIJGOCIC.BOHONBJIIKM(928f, 900f);
				if (Mathf.Abs(AnimationCanvasGroupAlphaPreset.GEKKOIPFIJN - this.HFOBPEJGPEB) > 1587f)
				{
					break;
				}
			}
			AnimationCanvasGroupAlphaPreset.GEKKOIPFIJN = this.HFOBPEJGPEB;
		}
		if (this.preset == (MBPJNDGPGCM)8 && this.logicUpdateInterval <= 518f && Application.isPlaying)
		{
			this.logicUpdateInterval = 1080f;
		}
	}

	// Token: 0x06001384 RID: 4996 RVA: 0x00097D74 File Offset: 0x00095F74
	private void HIIFPFHIDEP()
	{
		this.ENMEBDGMENO += Time.deltaTime;
		if (this.ENMEBDGMENO >= this.logicUpdateInterval)
		{
			this.ENMEBDGMENO = 1157f;
			this.DFDPDDBFDDP = this.baselineIntensity;
			this.BMMNGPNMBNI = 1616f;
			if (this.preset == MBPJNDGPGCM.presetCandle)
			{
				this.BMMNGPNMBNI += 1739f * (Mathf.Sin(this.HFOBPEJGPEB * this.speedCoefficient + this.timeOffsetAtStart + Time.realtimeSinceStartup * 112f * this.speedCoefficient) + 137f) / 1446f;
				this.BMMNGPNMBNI += 1062f * (Mathf.Sin(this.HFOBPEJGPEB * this.speedCoefficient + this.timeOffsetAtStart + Time.realtimeSinceStartup * 499f * this.speedCoefficient) + 993f) / 503f;
				this.BMMNGPNMBNI += 1711f * (Mathf.Sin(this.HFOBPEJGPEB * this.speedCoefficient + this.timeOffsetAtStart + Time.realtimeSinceStartup * 761f * this.speedCoefficient) + 20f) / 994f;
				this.BMMNGPNMBNI += 921f * (Mathf.Sin(this.HFOBPEJGPEB * this.speedCoefficient + this.timeOffsetAtStart + Time.realtimeSinceStartup * 204f * this.speedCoefficient) + 1820f) / 178f;
				this.BMMNGPNMBNI += 1460f * (Mathf.Cos(this.HFOBPEJGPEB * this.speedCoefficient + this.timeOffsetAtStart + Time.realtimeSinceStartup * 1915f * this.speedCoefficient) + 1414f) / 1954f;
				this.BMMNGPNMBNI += 1569f * (Mathf.Cos(this.HFOBPEJGPEB * this.speedCoefficient + this.timeOffsetAtStart + Time.realtimeSinceStartup * 330f * this.speedCoefficient) + 1883f) / 929f;
			}
			else if (this.preset == MBPJNDGPGCM.presetCandle)
			{
				this.BMMNGPNMBNI += (Mathf.Sin(this.HFOBPEJGPEB * this.speedCoefficient + this.timeOffsetAtStart + Time.realtimeSinceStartup) + 1277f) / 1284f;
			}
			else if (this.preset == (MBPJNDGPGCM)8)
			{
				this.BMMNGPNMBNI += (Mathf.Sin(this.HFOBPEJGPEB * this.speedCoefficient + this.timeOffsetAtStart + Time.realtimeSinceStartup * this.speedCoefficient) + 349f) / 801f;
			}
			else if (this.preset == (MBPJNDGPGCM)8)
			{
				this.BMMNGPNMBNI += (Mathf.Sin(this.HFOBPEJGPEB * this.speedCoefficient + this.timeOffsetAtStart + Time.realtimeSinceStartup * this.speedCoefficient) + 521f) / 182f;
				this.BMMNGPNMBNI = Mathf.Pow(this.BMMNGPNMBNI, 956f);
			}
			else if (this.preset == MBPJNDGPGCM.presetTranslationFadeToZeroAtEndpointsOnXAxis)
			{
				if (Mathf.Sin(this.HFOBPEJGPEB * this.speedCoefficient + this.timeOffsetAtStart + Time.realtimeSinceStartup * this.speedCoefficient) < 183f)
				{
					this.BMMNGPNMBNI = -this.baselineIntensity;
				}
			}
			else if (this.preset == MBPJNDGPGCM.presetStarFlicker)
			{
				float num = Mathf.Sin(this.HFOBPEJGPEB * this.speedCoefficient + this.timeOffsetAtStart + Time.realtimeSinceStartup * this.speedCoefficient);
				if (num < 1369f)
				{
					this.BMMNGPNMBNI = -this.baselineIntensity;
				}
				else if (num < 1839f)
				{
					this.BMMNGPNMBNI += 441f - (222f - num) / 745f;
				}
				else
				{
					this.BMMNGPNMBNI = 1586f - this.baselineIntensity;
				}
			}
			else if (this.preset == MBPJNDGPGCM.presetRandomValue)
			{
				this.BMMNGPNMBNI = DPGJIJGOCIC.GJBHHIMLIGB(99f, 1624f);
			}
			else if (this.preset == MBPJNDGPGCM.presetRandomValue && null != this.animationTranslation)
			{
				this.BMMNGPNMBNI = DAPOEDKKAIA.MFIJNHHMIDO(this.animationTranslation.GetLerp(), GLANJHGJNNB.lerpFadeToZeroAtEndpoints, 567f);
			}
			this.BMMNGPNMBNI *= this.intensityCoefficient;
			this.DFDPDDBFDDP += this.BMMNGPNMBNI;
			if (this.DFDPDDBFDDP < this.floorAtValueLessOrEqual)
			{
				this.DFDPDDBFDDP = 45f;
			}
			else if (this.DFDPDDBFDDP > this.ceilAtValueHeigherOrEqual)
			{
				this.DFDPDDBFDDP = 924f;
			}
			this.PANMNKKODPC.alpha = Mathf.Clamp01(this.DFDPDDBFDDP);
			return;
		}
	}

	// Token: 0x06001385 RID: 4997 RVA: 0x00098224 File Offset: 0x00096424
	private void JLMIOFHCNFI()
	{
		this.ENMEBDGMENO += Time.deltaTime;
		if (this.ENMEBDGMENO >= this.logicUpdateInterval)
		{
			this.ENMEBDGMENO = 1941f;
			this.DFDPDDBFDDP = this.baselineIntensity;
			this.BMMNGPNMBNI = 1418f;
			if (this.preset == MBPJNDGPGCM.presetCandle)
			{
				this.BMMNGPNMBNI += 38f * (Mathf.Sin(this.HFOBPEJGPEB * this.speedCoefficient + this.timeOffsetAtStart + Time.realtimeSinceStartup * 18f * this.speedCoefficient) + 1569f) / 1938f;
				this.BMMNGPNMBNI += 901f * (Mathf.Sin(this.HFOBPEJGPEB * this.speedCoefficient + this.timeOffsetAtStart + Time.realtimeSinceStartup * 1139f * this.speedCoefficient) + 1076f) / 485f;
				this.BMMNGPNMBNI += 717f * (Mathf.Sin(this.HFOBPEJGPEB * this.speedCoefficient + this.timeOffsetAtStart + Time.realtimeSinceStartup * 561f * this.speedCoefficient) + 1117f) / 1404f;
				this.BMMNGPNMBNI += 803f * (Mathf.Sin(this.HFOBPEJGPEB * this.speedCoefficient + this.timeOffsetAtStart + Time.realtimeSinceStartup * 1348f * this.speedCoefficient) + 1842f) / 301f;
				this.BMMNGPNMBNI += 740f * (Mathf.Cos(this.HFOBPEJGPEB * this.speedCoefficient + this.timeOffsetAtStart + Time.realtimeSinceStartup * 168f * this.speedCoefficient) + 1587f) / 312f;
				this.BMMNGPNMBNI += 1579f * (Mathf.Cos(this.HFOBPEJGPEB * this.speedCoefficient + this.timeOffsetAtStart + Time.realtimeSinceStartup * 436f * this.speedCoefficient) + 1039f) / 1228f;
			}
			else if (this.preset == MBPJNDGPGCM.presetCandle)
			{
				this.BMMNGPNMBNI += (Mathf.Sin(this.HFOBPEJGPEB * this.speedCoefficient + this.timeOffsetAtStart + Time.realtimeSinceStartup) + 689f) / 468f;
			}
			else if (this.preset == (MBPJNDGPGCM)8)
			{
				this.BMMNGPNMBNI += (Mathf.Sin(this.HFOBPEJGPEB * this.speedCoefficient + this.timeOffsetAtStart + Time.realtimeSinceStartup * this.speedCoefficient) + 372f) / 1482f;
			}
			else if (this.preset == (MBPJNDGPGCM)8)
			{
				this.BMMNGPNMBNI += (Mathf.Sin(this.HFOBPEJGPEB * this.speedCoefficient + this.timeOffsetAtStart + Time.realtimeSinceStartup * this.speedCoefficient) + 1996f) / 830f;
				this.BMMNGPNMBNI = Mathf.Pow(this.BMMNGPNMBNI, 70f);
			}
			else if (this.preset == MBPJNDGPGCM.presetRandomValue)
			{
				if (Mathf.Sin(this.HFOBPEJGPEB * this.speedCoefficient + this.timeOffsetAtStart + Time.realtimeSinceStartup * this.speedCoefficient) < 1079f)
				{
					this.BMMNGPNMBNI = -this.baselineIntensity;
				}
			}
			else if (this.preset == MBPJNDGPGCM.presetWindowFlicker)
			{
				float num = Mathf.Sin(this.HFOBPEJGPEB * this.speedCoefficient + this.timeOffsetAtStart + Time.realtimeSinceStartup * this.speedCoefficient);
				if (num < 995f)
				{
					this.BMMNGPNMBNI = -this.baselineIntensity;
				}
				else if (num < 1531f)
				{
					this.BMMNGPNMBNI += 864f - (1049f - num) / 1187f;
				}
				else
				{
					this.BMMNGPNMBNI = 1764f - this.baselineIntensity;
				}
			}
			else if (this.preset == MBPJNDGPGCM.presetStarFlicker)
			{
				this.BMMNGPNMBNI = DPGJIJGOCIC.CHNFACMNGJE(201f, 1007f);
			}
			else if (this.preset == MBPJNDGPGCM.presetStarFlicker && null != this.animationTranslation)
			{
				this.BMMNGPNMBNI = DAPOEDKKAIA.COAKKGHHDMJ(this.animationTranslation.NMNINGHAPCA(), GLANJHGJNNB.lerpFadeToZeroAtEndpoints, 762f);
			}
			this.BMMNGPNMBNI *= this.intensityCoefficient;
			this.DFDPDDBFDDP += this.BMMNGPNMBNI;
			if (this.DFDPDDBFDDP < this.floorAtValueLessOrEqual)
			{
				this.DFDPDDBFDDP = 1783f;
			}
			else if (this.DFDPDDBFDDP > this.ceilAtValueHeigherOrEqual)
			{
				this.DFDPDDBFDDP = 1323f;
			}
			this.PANMNKKODPC.alpha = Mathf.Clamp01(this.DFDPDDBFDDP);
			return;
		}
	}

	// Token: 0x06001386 RID: 4998 RVA: 0x000986D4 File Offset: 0x000968D4
	private void GELCDPOJGLP()
	{
		this.ENMEBDGMENO += Time.deltaTime;
		if (this.ENMEBDGMENO >= this.logicUpdateInterval)
		{
			this.ENMEBDGMENO = 386f;
			this.DFDPDDBFDDP = this.baselineIntensity;
			this.BMMNGPNMBNI = 1003f;
			if (this.preset == MBPJNDGPGCM.presetCandle)
			{
				this.BMMNGPNMBNI += 1936f * (Mathf.Sin(this.HFOBPEJGPEB * this.speedCoefficient + this.timeOffsetAtStart + Time.realtimeSinceStartup * 1370f * this.speedCoefficient) + 373f) / 768f;
				this.BMMNGPNMBNI += 1607f * (Mathf.Sin(this.HFOBPEJGPEB * this.speedCoefficient + this.timeOffsetAtStart + Time.realtimeSinceStartup * 654f * this.speedCoefficient) + 1637f) / 1654f;
				this.BMMNGPNMBNI += 21f * (Mathf.Sin(this.HFOBPEJGPEB * this.speedCoefficient + this.timeOffsetAtStart + Time.realtimeSinceStartup * 264f * this.speedCoefficient) + 1167f) / 1863f;
				this.BMMNGPNMBNI += 1291f * (Mathf.Sin(this.HFOBPEJGPEB * this.speedCoefficient + this.timeOffsetAtStart + Time.realtimeSinceStartup * 1173f * this.speedCoefficient) + 1974f) / 1053f;
				this.BMMNGPNMBNI += 1201f * (Mathf.Cos(this.HFOBPEJGPEB * this.speedCoefficient + this.timeOffsetAtStart + Time.realtimeSinceStartup * 1613f * this.speedCoefficient) + 1611f) / 1169f;
				this.BMMNGPNMBNI += 897f * (Mathf.Cos(this.HFOBPEJGPEB * this.speedCoefficient + this.timeOffsetAtStart + Time.realtimeSinceStartup * 785f * this.speedCoefficient) + 1346f) / 70f;
			}
			else if (this.preset == MBPJNDGPGCM.presetLightRay)
			{
				this.BMMNGPNMBNI += (Mathf.Sin(this.HFOBPEJGPEB * this.speedCoefficient + this.timeOffsetAtStart + Time.realtimeSinceStartup) + 97f) / 957f;
			}
			else if (this.preset == MBPJNDGPGCM.presetLightRayCorrected)
			{
				this.BMMNGPNMBNI += (Mathf.Sin(this.HFOBPEJGPEB * this.speedCoefficient + this.timeOffsetAtStart + Time.realtimeSinceStartup * this.speedCoefficient) + 473f) / 1951f;
			}
			else if (this.preset == MBPJNDGPGCM.presetWindowFlicker)
			{
				this.BMMNGPNMBNI += (Mathf.Sin(this.HFOBPEJGPEB * this.speedCoefficient + this.timeOffsetAtStart + Time.realtimeSinceStartup * this.speedCoefficient) + 1322f) / 589f;
				this.BMMNGPNMBNI = Mathf.Pow(this.BMMNGPNMBNI, 1506f);
			}
			else if (this.preset == MBPJNDGPGCM.presetLightRay)
			{
				if (Mathf.Sin(this.HFOBPEJGPEB * this.speedCoefficient + this.timeOffsetAtStart + Time.realtimeSinceStartup * this.speedCoefficient) < 641f)
				{
					this.BMMNGPNMBNI = -this.baselineIntensity;
				}
			}
			else if (this.preset == (MBPJNDGPGCM)8)
			{
				float num = Mathf.Sin(this.HFOBPEJGPEB * this.speedCoefficient + this.timeOffsetAtStart + Time.realtimeSinceStartup * this.speedCoefficient);
				if (num < 223f)
				{
					this.BMMNGPNMBNI = -this.baselineIntensity;
				}
				else if (num < 628f)
				{
					this.BMMNGPNMBNI += 1839f - (1729f - num) / 1726f;
				}
				else
				{
					this.BMMNGPNMBNI = 1221f - this.baselineIntensity;
				}
			}
			else if (this.preset == MBPJNDGPGCM.presetLightRay)
			{
				this.BMMNGPNMBNI = DPGJIJGOCIC.GJBHHIMLIGB(676f, 384f);
			}
			else if (this.preset == MBPJNDGPGCM.presetTranslationFadeToZeroAtEndpointsOnXAxis && null != this.animationTranslation)
			{
				this.BMMNGPNMBNI = DAPOEDKKAIA.BHBOOECLPHI(this.animationTranslation.DCLDOBECHJD(), (GLANJHGJNNB)1, 605f);
			}
			this.BMMNGPNMBNI *= this.intensityCoefficient;
			this.DFDPDDBFDDP += this.BMMNGPNMBNI;
			if (this.DFDPDDBFDDP < this.floorAtValueLessOrEqual)
			{
				this.DFDPDDBFDDP = 939f;
			}
			else if (this.DFDPDDBFDDP > this.ceilAtValueHeigherOrEqual)
			{
				this.DFDPDDBFDDP = 126f;
			}
			this.PANMNKKODPC.alpha = Mathf.Clamp01(this.DFDPDDBFDDP);
			return;
		}
	}

	// Token: 0x06001387 RID: 4999 RVA: 0x00098B84 File Offset: 0x00096D84
	private void FIJDKGJEPGC()
	{
		this.ENMEBDGMENO += Time.deltaTime;
		if (this.ENMEBDGMENO >= this.logicUpdateInterval)
		{
			this.ENMEBDGMENO = 342f;
			this.DFDPDDBFDDP = this.baselineIntensity;
			this.BMMNGPNMBNI = 1497f;
			if (this.preset == MBPJNDGPGCM.presetCandle)
			{
				this.BMMNGPNMBNI += 762f * (Mathf.Sin(this.HFOBPEJGPEB * this.speedCoefficient + this.timeOffsetAtStart + Time.realtimeSinceStartup * 845f * this.speedCoefficient) + 106f) / 1575f;
				this.BMMNGPNMBNI += 1066f * (Mathf.Sin(this.HFOBPEJGPEB * this.speedCoefficient + this.timeOffsetAtStart + Time.realtimeSinceStartup * 1817f * this.speedCoefficient) + 1050f) / 217f;
				this.BMMNGPNMBNI += 281f * (Mathf.Sin(this.HFOBPEJGPEB * this.speedCoefficient + this.timeOffsetAtStart + Time.realtimeSinceStartup * 1248f * this.speedCoefficient) + 976f) / 1781f;
				this.BMMNGPNMBNI += 1324f * (Mathf.Sin(this.HFOBPEJGPEB * this.speedCoefficient + this.timeOffsetAtStart + Time.realtimeSinceStartup * 1555f * this.speedCoefficient) + 731f) / 1512f;
				this.BMMNGPNMBNI += 1880f * (Mathf.Cos(this.HFOBPEJGPEB * this.speedCoefficient + this.timeOffsetAtStart + Time.realtimeSinceStartup * 1127f * this.speedCoefficient) + 107f) / 1624f;
				this.BMMNGPNMBNI += 368f * (Mathf.Cos(this.HFOBPEJGPEB * this.speedCoefficient + this.timeOffsetAtStart + Time.realtimeSinceStartup * 539f * this.speedCoefficient) + 238f) / 1138f;
			}
			else if (this.preset == MBPJNDGPGCM.presetCandle)
			{
				this.BMMNGPNMBNI += (Mathf.Sin(this.HFOBPEJGPEB * this.speedCoefficient + this.timeOffsetAtStart + Time.realtimeSinceStartup) + 1813f) / 1356f;
			}
			else if (this.preset == MBPJNDGPGCM.presetDoorOpenClose)
			{
				this.BMMNGPNMBNI += (Mathf.Sin(this.HFOBPEJGPEB * this.speedCoefficient + this.timeOffsetAtStart + Time.realtimeSinceStartup * this.speedCoefficient) + 1064f) / 1601f;
			}
			else if (this.preset == MBPJNDGPGCM.presetCandle)
			{
				this.BMMNGPNMBNI += (Mathf.Sin(this.HFOBPEJGPEB * this.speedCoefficient + this.timeOffsetAtStart + Time.realtimeSinceStartup * this.speedCoefficient) + 980f) / 502f;
				this.BMMNGPNMBNI = Mathf.Pow(this.BMMNGPNMBNI, 637f);
			}
			else if (this.preset == MBPJNDGPGCM.presetCandle)
			{
				if (Mathf.Sin(this.HFOBPEJGPEB * this.speedCoefficient + this.timeOffsetAtStart + Time.realtimeSinceStartup * this.speedCoefficient) < 1995f)
				{
					this.BMMNGPNMBNI = -this.baselineIntensity;
				}
			}
			else if (this.preset == MBPJNDGPGCM.presetTranslationFadeToZeroAtEndpointsOnXAxis)
			{
				float num = Mathf.Sin(this.HFOBPEJGPEB * this.speedCoefficient + this.timeOffsetAtStart + Time.realtimeSinceStartup * this.speedCoefficient);
				if (num < 731f)
				{
					this.BMMNGPNMBNI = -this.baselineIntensity;
				}
				else if (num < 1945f)
				{
					this.BMMNGPNMBNI += 822f - (691f - num) / 15f;
				}
				else
				{
					this.BMMNGPNMBNI = 992f - this.baselineIntensity;
				}
			}
			else if (this.preset == MBPJNDGPGCM.presetDoorOpenClose)
			{
				this.BMMNGPNMBNI = DPGJIJGOCIC.BOHONBJIIKM(442f, 408f);
			}
			else if (this.preset == MBPJNDGPGCM.presetDoorOpenClose && null != this.animationTranslation)
			{
				this.BMMNGPNMBNI = DAPOEDKKAIA.GBDNEPGLJPM(this.animationTranslation.GBKPPPGELGL(), GLANJHGJNNB.lerpFadeToZeroAtEndpoints, 166f);
			}
			this.BMMNGPNMBNI *= this.intensityCoefficient;
			this.DFDPDDBFDDP += this.BMMNGPNMBNI;
			if (this.DFDPDDBFDDP < this.floorAtValueLessOrEqual)
			{
				this.DFDPDDBFDDP = 1683f;
			}
			else if (this.DFDPDDBFDDP > this.ceilAtValueHeigherOrEqual)
			{
				this.DFDPDDBFDDP = 1928f;
			}
			this.PANMNKKODPC.alpha = Mathf.Clamp01(this.DFDPDDBFDDP);
			return;
		}
	}

	// Token: 0x06001388 RID: 5000 RVA: 0x00099034 File Offset: 0x00097234
	private void NHOGOCONIEF()
	{
		this.PANMNKKODPC = base.gameObject.GetComponent<CanvasGroup>();
		if (this.randomSeed)
		{
			for (int i = 0; i < 112; i++)
			{
				this.HFOBPEJGPEB = DPGJIJGOCIC.GJBHHIMLIGB(996f, 1228f);
				if (Mathf.Abs(AnimationCanvasGroupAlphaPreset.GEKKOIPFIJN - this.HFOBPEJGPEB) > 818f)
				{
					break;
				}
			}
			AnimationCanvasGroupAlphaPreset.GEKKOIPFIJN = this.HFOBPEJGPEB;
		}
		if (this.preset == MBPJNDGPGCM.presetStarFlicker && this.logicUpdateInterval <= 1251f && Application.isPlaying)
		{
			this.logicUpdateInterval = 1091f;
		}
	}

	// Token: 0x06001389 RID: 5001 RVA: 0x000990C8 File Offset: 0x000972C8
	private void Awake()
	{
		this.PANMNKKODPC = base.gameObject.GetComponent<CanvasGroup>();
		if (this.randomSeed)
		{
			for (int i = 0; i < 10; i++)
			{
				this.HFOBPEJGPEB = DPGJIJGOCIC.BOHONBJIIKM(0f, 6.2831855f);
				if (Mathf.Abs(AnimationCanvasGroupAlphaPreset.GEKKOIPFIJN - this.HFOBPEJGPEB) > 2.0734513f)
				{
					break;
				}
			}
			AnimationCanvasGroupAlphaPreset.GEKKOIPFIJN = this.HFOBPEJGPEB;
		}
		if (this.preset == MBPJNDGPGCM.presetRandomValue && this.logicUpdateInterval <= 0.0001f && Application.isPlaying)
		{
			this.logicUpdateInterval = 0.033333335f;
		}
	}

	// Token: 0x0600138A RID: 5002 RVA: 0x0008C20F File Offset: 0x0008A40F
	public float LEHGDDMALNG()
	{
		return this.DFDPDDBFDDP;
	}

	// Token: 0x0600138B RID: 5003 RVA: 0x0008C20F File Offset: 0x0008A40F
	public float IBPMOJNCOAG()
	{
		return this.DFDPDDBFDDP;
	}

	// Token: 0x0600138C RID: 5004 RVA: 0x0009915C File Offset: 0x0009735C
	private void KLGLFKMIAPP()
	{
		this.PANMNKKODPC = base.gameObject.GetComponent<CanvasGroup>();
		if (this.randomSeed)
		{
			for (int i = 0; i < 97; i += 0)
			{
				this.HFOBPEJGPEB = DPGJIJGOCIC.BOHONBJIIKM(807f, 1007f);
				if (Mathf.Abs(AnimationCanvasGroupAlphaPreset.GEKKOIPFIJN - this.HFOBPEJGPEB) > 1242f)
				{
					break;
				}
			}
			AnimationCanvasGroupAlphaPreset.GEKKOIPFIJN = this.HFOBPEJGPEB;
		}
		if (this.preset == MBPJNDGPGCM.presetDoorOpenClose && this.logicUpdateInterval <= 1353f && Application.isPlaying)
		{
			this.logicUpdateInterval = 1332f;
		}
	}

	// Token: 0x0600138D RID: 5005 RVA: 0x000991F0 File Offset: 0x000973F0
	private void NACNAPKJMFI()
	{
		this.ENMEBDGMENO += Time.deltaTime;
		if (this.ENMEBDGMENO >= this.logicUpdateInterval)
		{
			this.ENMEBDGMENO = 1282f;
			this.DFDPDDBFDDP = this.baselineIntensity;
			this.BMMNGPNMBNI = 1239f;
			if (this.preset == MBPJNDGPGCM.presetCandle)
			{
				this.BMMNGPNMBNI += 1231f * (Mathf.Sin(this.HFOBPEJGPEB * this.speedCoefficient + this.timeOffsetAtStart + Time.realtimeSinceStartup * 1810f * this.speedCoefficient) + 894f) / 62f;
				this.BMMNGPNMBNI += 242f * (Mathf.Sin(this.HFOBPEJGPEB * this.speedCoefficient + this.timeOffsetAtStart + Time.realtimeSinceStartup * 1969f * this.speedCoefficient) + 139f) / 280f;
				this.BMMNGPNMBNI += 1199f * (Mathf.Sin(this.HFOBPEJGPEB * this.speedCoefficient + this.timeOffsetAtStart + Time.realtimeSinceStartup * 1759f * this.speedCoefficient) + 440f) / 1979f;
				this.BMMNGPNMBNI += 1783f * (Mathf.Sin(this.HFOBPEJGPEB * this.speedCoefficient + this.timeOffsetAtStart + Time.realtimeSinceStartup * 289f * this.speedCoefficient) + 1257f) / 1784f;
				this.BMMNGPNMBNI += 123f * (Mathf.Cos(this.HFOBPEJGPEB * this.speedCoefficient + this.timeOffsetAtStart + Time.realtimeSinceStartup * 1590f * this.speedCoefficient) + 1494f) / 48f;
				this.BMMNGPNMBNI += 798f * (Mathf.Cos(this.HFOBPEJGPEB * this.speedCoefficient + this.timeOffsetAtStart + Time.realtimeSinceStartup * 55f * this.speedCoefficient) + 640f) / 1156f;
			}
			else if (this.preset == MBPJNDGPGCM.presetCandle)
			{
				this.BMMNGPNMBNI += (Mathf.Sin(this.HFOBPEJGPEB * this.speedCoefficient + this.timeOffsetAtStart + Time.realtimeSinceStartup) + 773f) / 1955f;
			}
			else if (this.preset == MBPJNDGPGCM.presetTranslationFadeToZeroAtEndpointsOnXAxis)
			{
				this.BMMNGPNMBNI += (Mathf.Sin(this.HFOBPEJGPEB * this.speedCoefficient + this.timeOffsetAtStart + Time.realtimeSinceStartup * this.speedCoefficient) + 1689f) / 1656f;
			}
			else if (this.preset == MBPJNDGPGCM.presetDoorOpenClose)
			{
				this.BMMNGPNMBNI += (Mathf.Sin(this.HFOBPEJGPEB * this.speedCoefficient + this.timeOffsetAtStart + Time.realtimeSinceStartup * this.speedCoefficient) + 1219f) / 1616f;
				this.BMMNGPNMBNI = Mathf.Pow(this.BMMNGPNMBNI, 343f);
			}
			else if (this.preset == MBPJNDGPGCM.presetStarFlicker)
			{
				if (Mathf.Sin(this.HFOBPEJGPEB * this.speedCoefficient + this.timeOffsetAtStart + Time.realtimeSinceStartup * this.speedCoefficient) < 331f)
				{
					this.BMMNGPNMBNI = -this.baselineIntensity;
				}
			}
			else if (this.preset == MBPJNDGPGCM.presetWindowFlicker)
			{
				float num = Mathf.Sin(this.HFOBPEJGPEB * this.speedCoefficient + this.timeOffsetAtStart + Time.realtimeSinceStartup * this.speedCoefficient);
				if (num < 806f)
				{
					this.BMMNGPNMBNI = -this.baselineIntensity;
				}
				else if (num < 1094f)
				{
					this.BMMNGPNMBNI += 1919f - (323f - num) / 537f;
				}
				else
				{
					this.BMMNGPNMBNI = 898f - this.baselineIntensity;
				}
			}
			else if (this.preset == MBPJNDGPGCM.presetStarFlicker)
			{
				this.BMMNGPNMBNI = DPGJIJGOCIC.CHNFACMNGJE(1772f, 573f);
			}
			else if (this.preset == MBPJNDGPGCM.presetRandomValue && null != this.animationTranslation)
			{
				this.BMMNGPNMBNI = DAPOEDKKAIA.NCAAJFCIDFC(this.animationTranslation.GetLerp(), (GLANJHGJNNB)1, 124f);
			}
			this.BMMNGPNMBNI *= this.intensityCoefficient;
			this.DFDPDDBFDDP += this.BMMNGPNMBNI;
			if (this.DFDPDDBFDDP < this.floorAtValueLessOrEqual)
			{
				this.DFDPDDBFDDP = 1081f;
			}
			else if (this.DFDPDDBFDDP > this.ceilAtValueHeigherOrEqual)
			{
				this.DFDPDDBFDDP = 616f;
			}
			this.PANMNKKODPC.alpha = Mathf.Clamp01(this.DFDPDDBFDDP);
			return;
		}
	}

	// Token: 0x0600138E RID: 5006 RVA: 0x0008C20F File Offset: 0x0008A40F
	public float MIJPJDMCKCH()
	{
		return this.DFDPDDBFDDP;
	}

	// Token: 0x0600138F RID: 5007 RVA: 0x000996A0 File Offset: 0x000978A0
	private void JNCLGOBJGJD()
	{
		this.PANMNKKODPC = base.gameObject.GetComponent<CanvasGroup>();
		if (this.randomSeed)
		{
			for (int i = 1; i < 68; i++)
			{
				this.HFOBPEJGPEB = DPGJIJGOCIC.CHNFACMNGJE(1291f, 1366f);
				if (Mathf.Abs(AnimationCanvasGroupAlphaPreset.GEKKOIPFIJN - this.HFOBPEJGPEB) > 266f)
				{
					break;
				}
			}
			AnimationCanvasGroupAlphaPreset.GEKKOIPFIJN = this.HFOBPEJGPEB;
		}
		if (this.preset == MBPJNDGPGCM.presetDoorOpenClose && this.logicUpdateInterval <= 1023f && Application.isPlaying)
		{
			this.logicUpdateInterval = 1175f;
		}
	}

	// Token: 0x06001390 RID: 5008 RVA: 0x0008C20F File Offset: 0x0008A40F
	public float IHNDMNOKJLK()
	{
		return this.DFDPDDBFDDP;
	}

	// Token: 0x06001391 RID: 5009 RVA: 0x00099734 File Offset: 0x00097934
	private void AALDINEPEHJ()
	{
		this.PANMNKKODPC = base.gameObject.GetComponent<CanvasGroup>();
		if (this.randomSeed)
		{
			for (int i = 0; i < -119; i++)
			{
				this.HFOBPEJGPEB = DPGJIJGOCIC.BOHONBJIIKM(1290f, 1976f);
				if (Mathf.Abs(AnimationCanvasGroupAlphaPreset.GEKKOIPFIJN - this.HFOBPEJGPEB) > 712f)
				{
					break;
				}
			}
			AnimationCanvasGroupAlphaPreset.GEKKOIPFIJN = this.HFOBPEJGPEB;
		}
		if (this.preset == MBPJNDGPGCM.presetLightRayCorrected && this.logicUpdateInterval <= 373f && Application.isPlaying)
		{
			this.logicUpdateInterval = 635f;
		}
	}

	// Token: 0x06001392 RID: 5010 RVA: 0x000997C8 File Offset: 0x000979C8
	private void GKGJIGJCPFK()
	{
		this.ENMEBDGMENO += Time.deltaTime;
		if (this.ENMEBDGMENO >= this.logicUpdateInterval)
		{
			this.ENMEBDGMENO = 1980f;
			this.DFDPDDBFDDP = this.baselineIntensity;
			this.BMMNGPNMBNI = 1392f;
			if (this.preset == MBPJNDGPGCM.presetCandle)
			{
				this.BMMNGPNMBNI += 775f * (Mathf.Sin(this.HFOBPEJGPEB * this.speedCoefficient + this.timeOffsetAtStart + Time.realtimeSinceStartup * 413f * this.speedCoefficient) + 1259f) / 628f;
				this.BMMNGPNMBNI += 1120f * (Mathf.Sin(this.HFOBPEJGPEB * this.speedCoefficient + this.timeOffsetAtStart + Time.realtimeSinceStartup * 46f * this.speedCoefficient) + 1359f) / 1777f;
				this.BMMNGPNMBNI += 1538f * (Mathf.Sin(this.HFOBPEJGPEB * this.speedCoefficient + this.timeOffsetAtStart + Time.realtimeSinceStartup * 321f * this.speedCoefficient) + 1929f) / 1534f;
				this.BMMNGPNMBNI += 489f * (Mathf.Sin(this.HFOBPEJGPEB * this.speedCoefficient + this.timeOffsetAtStart + Time.realtimeSinceStartup * 645f * this.speedCoefficient) + 865f) / 635f;
				this.BMMNGPNMBNI += 846f * (Mathf.Cos(this.HFOBPEJGPEB * this.speedCoefficient + this.timeOffsetAtStart + Time.realtimeSinceStartup * 837f * this.speedCoefficient) + 1892f) / 940f;
				this.BMMNGPNMBNI += 585f * (Mathf.Cos(this.HFOBPEJGPEB * this.speedCoefficient + this.timeOffsetAtStart + Time.realtimeSinceStartup * 1229f * this.speedCoefficient) + 1383f) / 1084f;
			}
			else if (this.preset == MBPJNDGPGCM.presetCandle)
			{
				this.BMMNGPNMBNI += (Mathf.Sin(this.HFOBPEJGPEB * this.speedCoefficient + this.timeOffsetAtStart + Time.realtimeSinceStartup) + 1189f) / 673f;
			}
			else if (this.preset == MBPJNDGPGCM.presetWindowFlicker)
			{
				this.BMMNGPNMBNI += (Mathf.Sin(this.HFOBPEJGPEB * this.speedCoefficient + this.timeOffsetAtStart + Time.realtimeSinceStartup * this.speedCoefficient) + 1324f) / 1492f;
			}
			else if (this.preset == MBPJNDGPGCM.presetDoorOpenClose)
			{
				this.BMMNGPNMBNI += (Mathf.Sin(this.HFOBPEJGPEB * this.speedCoefficient + this.timeOffsetAtStart + Time.realtimeSinceStartup * this.speedCoefficient) + 1526f) / 161f;
				this.BMMNGPNMBNI = Mathf.Pow(this.BMMNGPNMBNI, 365f);
			}
			else if (this.preset == MBPJNDGPGCM.presetTranslationFadeToZeroAtEndpointsOnXAxis)
			{
				if (Mathf.Sin(this.HFOBPEJGPEB * this.speedCoefficient + this.timeOffsetAtStart + Time.realtimeSinceStartup * this.speedCoefficient) < 1039f)
				{
					this.BMMNGPNMBNI = -this.baselineIntensity;
				}
			}
			else if (this.preset == MBPJNDGPGCM.presetLightRayCorrected)
			{
				float num = Mathf.Sin(this.HFOBPEJGPEB * this.speedCoefficient + this.timeOffsetAtStart + Time.realtimeSinceStartup * this.speedCoefficient);
				if (num < 1934f)
				{
					this.BMMNGPNMBNI = -this.baselineIntensity;
				}
				else if (num < 213f)
				{
					this.BMMNGPNMBNI += 691f - (1820f - num) / 237f;
				}
				else
				{
					this.BMMNGPNMBNI = 1128f - this.baselineIntensity;
				}
			}
			else if (this.preset == MBPJNDGPGCM.presetCandle)
			{
				this.BMMNGPNMBNI = DPGJIJGOCIC.CHNFACMNGJE(367f, 1090f);
			}
			else if (this.preset == (MBPJNDGPGCM)8 && null != this.animationTranslation)
			{
				this.BMMNGPNMBNI = DAPOEDKKAIA.IOELPIFBHPO(this.animationTranslation.BBDIJGEBLDG(), (GLANJHGJNNB)1, 1932f);
			}
			this.BMMNGPNMBNI *= this.intensityCoefficient;
			this.DFDPDDBFDDP += this.BMMNGPNMBNI;
			if (this.DFDPDDBFDDP < this.floorAtValueLessOrEqual)
			{
				this.DFDPDDBFDDP = 685f;
			}
			else if (this.DFDPDDBFDDP > this.ceilAtValueHeigherOrEqual)
			{
				this.DFDPDDBFDDP = 347f;
			}
			this.PANMNKKODPC.alpha = Mathf.Clamp01(this.DFDPDDBFDDP);
			return;
		}
	}

	// Token: 0x06001393 RID: 5011 RVA: 0x00099C78 File Offset: 0x00097E78
	private void CONJNNGBLOB()
	{
		this.ENMEBDGMENO += Time.deltaTime;
		if (this.ENMEBDGMENO >= this.logicUpdateInterval)
		{
			this.ENMEBDGMENO = 607f;
			this.DFDPDDBFDDP = this.baselineIntensity;
			this.BMMNGPNMBNI = 1700f;
			if (this.preset == MBPJNDGPGCM.presetCandle)
			{
				this.BMMNGPNMBNI += 1995f * (Mathf.Sin(this.HFOBPEJGPEB * this.speedCoefficient + this.timeOffsetAtStart + Time.realtimeSinceStartup * 1949f * this.speedCoefficient) + 1447f) / 1004f;
				this.BMMNGPNMBNI += 34f * (Mathf.Sin(this.HFOBPEJGPEB * this.speedCoefficient + this.timeOffsetAtStart + Time.realtimeSinceStartup * 169f * this.speedCoefficient) + 224f) / 420f;
				this.BMMNGPNMBNI += 1396f * (Mathf.Sin(this.HFOBPEJGPEB * this.speedCoefficient + this.timeOffsetAtStart + Time.realtimeSinceStartup * 114f * this.speedCoefficient) + 1317f) / 1602f;
				this.BMMNGPNMBNI += 1577f * (Mathf.Sin(this.HFOBPEJGPEB * this.speedCoefficient + this.timeOffsetAtStart + Time.realtimeSinceStartup * 1941f * this.speedCoefficient) + 1902f) / 110f;
				this.BMMNGPNMBNI += 1017f * (Mathf.Cos(this.HFOBPEJGPEB * this.speedCoefficient + this.timeOffsetAtStart + Time.realtimeSinceStartup * 837f * this.speedCoefficient) + 1835f) / 1088f;
				this.BMMNGPNMBNI += 960f * (Mathf.Cos(this.HFOBPEJGPEB * this.speedCoefficient + this.timeOffsetAtStart + Time.realtimeSinceStartup * 807f * this.speedCoefficient) + 1730f) / 37f;
			}
			else if (this.preset == MBPJNDGPGCM.presetCandle)
			{
				this.BMMNGPNMBNI += (Mathf.Sin(this.HFOBPEJGPEB * this.speedCoefficient + this.timeOffsetAtStart + Time.realtimeSinceStartup) + 1686f) / 1601f;
			}
			else if (this.preset == MBPJNDGPGCM.presetCandle)
			{
				this.BMMNGPNMBNI += (Mathf.Sin(this.HFOBPEJGPEB * this.speedCoefficient + this.timeOffsetAtStart + Time.realtimeSinceStartup * this.speedCoefficient) + 1645f) / 945f;
			}
			else if (this.preset == MBPJNDGPGCM.presetLightRayCorrected)
			{
				this.BMMNGPNMBNI += (Mathf.Sin(this.HFOBPEJGPEB * this.speedCoefficient + this.timeOffsetAtStart + Time.realtimeSinceStartup * this.speedCoefficient) + 1458f) / 146f;
				this.BMMNGPNMBNI = Mathf.Pow(this.BMMNGPNMBNI, 1346f);
			}
			else if (this.preset == MBPJNDGPGCM.presetCandle)
			{
				if (Mathf.Sin(this.HFOBPEJGPEB * this.speedCoefficient + this.timeOffsetAtStart + Time.realtimeSinceStartup * this.speedCoefficient) < 1685f)
				{
					this.BMMNGPNMBNI = -this.baselineIntensity;
				}
			}
			else if (this.preset == MBPJNDGPGCM.presetWindowFlicker)
			{
				float num = Mathf.Sin(this.HFOBPEJGPEB * this.speedCoefficient + this.timeOffsetAtStart + Time.realtimeSinceStartup * this.speedCoefficient);
				if (num < 1230f)
				{
					this.BMMNGPNMBNI = -this.baselineIntensity;
				}
				else if (num < 1587f)
				{
					this.BMMNGPNMBNI += 1741f - (68f - num) / 1619f;
				}
				else
				{
					this.BMMNGPNMBNI = 1052f - this.baselineIntensity;
				}
			}
			else if (this.preset == MBPJNDGPGCM.presetDoorOpenClose)
			{
				this.BMMNGPNMBNI = DPGJIJGOCIC.GJBHHIMLIGB(1820f, 1142f);
			}
			else if (this.preset == MBPJNDGPGCM.presetCandle && null != this.animationTranslation)
			{
				this.BMMNGPNMBNI = DAPOEDKKAIA.LHAPPBLLOJL(this.animationTranslation.AKFHLAKDFIF(), (GLANJHGJNNB)1, 222f);
			}
			this.BMMNGPNMBNI *= this.intensityCoefficient;
			this.DFDPDDBFDDP += this.BMMNGPNMBNI;
			if (this.DFDPDDBFDDP < this.floorAtValueLessOrEqual)
			{
				this.DFDPDDBFDDP = 1979f;
			}
			else if (this.DFDPDDBFDDP > this.ceilAtValueHeigherOrEqual)
			{
				this.DFDPDDBFDDP = 1469f;
			}
			this.PANMNKKODPC.alpha = Mathf.Clamp01(this.DFDPDDBFDDP);
			return;
		}
	}

	// Token: 0x04000653 RID: 1619
	public MBPJNDGPGCM preset;

	// Token: 0x04000654 RID: 1620
	public AnimationTranslation animationTranslation;

	// Token: 0x04000655 RID: 1621
	public float speedCoefficient = 1f;

	// Token: 0x04000656 RID: 1622
	public float intensityCoefficient = 1f;

	// Token: 0x04000657 RID: 1623
	public float baselineIntensity;

	// Token: 0x04000658 RID: 1624
	public bool randomSeed;

	// Token: 0x04000659 RID: 1625
	public float logicUpdateInterval;

	// Token: 0x0400065A RID: 1626
	public float floorAtValueLessOrEqual;

	// Token: 0x0400065B RID: 1627
	public float ceilAtValueHeigherOrEqual = 1f;

	// Token: 0x0400065C RID: 1628
	public float timeOffsetAtStart;

	// Token: 0x0400065D RID: 1629
	private CanvasGroup PANMNKKODPC;

	// Token: 0x0400065E RID: 1630
	private float DFDPDDBFDDP;

	// Token: 0x0400065F RID: 1631
	private float BMMNGPNMBNI;

	// Token: 0x04000660 RID: 1632
	private float HFOBPEJGPEB;

	// Token: 0x04000661 RID: 1633
	private static float GEKKOIPFIJN;

	// Token: 0x04000662 RID: 1634
	private float ENMEBDGMENO;
}
