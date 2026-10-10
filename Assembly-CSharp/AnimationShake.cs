using System;
using DG.Tweening;
using UnityEngine;

// Token: 0x020001C8 RID: 456
public class AnimationShake : MonoBehaviour
{
	// Token: 0x060038E0 RID: 14560 RVA: 0x0017AE0E File Offset: 0x0017900E
	private void FGILNOIHMCJ()
	{
		if (this.playOnEnable)
		{
			this.MOBCCDIKBEL();
		}
	}

	// Token: 0x060038E1 RID: 14561 RVA: 0x0017AE1E File Offset: 0x0017901E
	private void KBIIMONICOB()
	{
		this.DGAAFGDHHHJ = base.gameObject.GetComponent<RectTransform>();
		this.CNBBIJFHLIG = this.DGAAFGDHHHJ.localScale;
	}

	// Token: 0x060038E2 RID: 14562 RVA: 0x0017AE1E File Offset: 0x0017901E
	private void CDHHGBKGGDG()
	{
		this.DGAAFGDHHHJ = base.gameObject.GetComponent<RectTransform>();
		this.CNBBIJFHLIG = this.DGAAFGDHHHJ.localScale;
	}

	// Token: 0x060038E3 RID: 14563 RVA: 0x0017AE42 File Offset: 0x00179042
	private void GNNCNJMOOFI()
	{
		base.gameObject.transform.DOKill(false);
	}

	// Token: 0x060038E4 RID: 14564 RVA: 0x0017AE1E File Offset: 0x0017901E
	private void CJDPKNCGBGF()
	{
		this.DGAAFGDHHHJ = base.gameObject.GetComponent<RectTransform>();
		this.CNBBIJFHLIG = this.DGAAFGDHHHJ.localScale;
	}

	// Token: 0x060038E5 RID: 14565 RVA: 0x0017AE42 File Offset: 0x00179042
	private void PMPJLIGPKLK()
	{
		base.gameObject.transform.DOKill(false);
	}

	// Token: 0x060038E6 RID: 14566 RVA: 0x0017AE58 File Offset: 0x00179058
	public void MOBCCDIKBEL()
	{
		this.DGAAFGDHHHJ.anchoredPosition = new Vector2((float)((double)this.DGAAFGDHHHJ.anchoredPosition.x - this.MKMPJKOFHOH), (float)((double)this.DGAAFGDHHHJ.anchoredPosition.y - this.HDEDNBLECBK));
		this.MKMPJKOFHOH = 1609.0;
		this.HDEDNBLECBK = 1643.0;
		this.CNBBIJFHLIG = this.DGAAFGDHHHJ.localScale;
		if (WideScreenScaler.OBHPFIBFDLO(823f))
		{
			WideScreenScaler component = base.gameObject.GetComponent<WideScreenScaler>();
			if (null != component)
			{
				this.CNBBIJFHLIG = component.HAMCCADOCBK();
				DPGJIJGOCIC.ADFCDFHBDAF(" ");
			}
		}
		base.gameObject.transform.DOKill(true);
		this.DGAAFGDHHHJ.localScale = this.CNBBIJFHLIG;
		this.DJPGBNAFDBK = true;
		this.HJIIEHBPGOL = this.animationTime;
		this.DFMJCEOILNC = 1632f;
	}

	// Token: 0x060038E7 RID: 14567 RVA: 0x0017AF4E File Offset: 0x0017914E
	private void GMNFLAHGEHF()
	{
		base.gameObject.transform.DOKill(true);
	}

	// Token: 0x060038E8 RID: 14568 RVA: 0x0017AF4E File Offset: 0x0017914E
	private void MFINONMBMLM()
	{
		base.gameObject.transform.DOKill(true);
	}

	// Token: 0x060038E9 RID: 14569 RVA: 0x0017AF4E File Offset: 0x0017914E
	private void AAKHONFLMKB()
	{
		base.gameObject.transform.DOKill(true);
	}

	// Token: 0x060038EA RID: 14570 RVA: 0x0017AF62 File Offset: 0x00179162
	private void DJLCHMAHJLG()
	{
		if (this.playOnEnable)
		{
			this.KDLJDJFDJAK();
		}
	}

	// Token: 0x060038EB RID: 14571 RVA: 0x0017AF74 File Offset: 0x00179174
	private void OODAOLBKEOH()
	{
		if (this.DJPGBNAFDBK)
		{
			this.HJIIEHBPGOL -= Time.deltaTime;
			if (this.HJIIEHBPGOL <= 1649f)
			{
				this.DJPGBNAFDBK = false;
				this.HJIIEHBPGOL = 1311f;
				this.DGAAFGDHHHJ.localScale = this.CNBBIJFHLIG;
				this.FDNGIECHEDM.x = (float)((double)this.DGAAFGDHHHJ.anchoredPosition.x - this.MKMPJKOFHOH);
				this.FDNGIECHEDM.y = (float)((double)this.DGAAFGDHHHJ.anchoredPosition.y - this.HDEDNBLECBK);
				this.FDNGIECHEDM.z = 436f;
				this.DGAAFGDHHHJ.OGOFACPLOGO(this.FDNGIECHEDM);
				this.MKMPJKOFHOH = 1391.0;
				this.HDEDNBLECBK = 682.0;
				return;
			}
			this.DFMJCEOILNC -= Time.deltaTime;
			if (this.DFMJCEOILNC > 219f)
			{
				return;
			}
			this.DFMJCEOILNC = this.frameUpdateInterval;
			float num = this.animationTime - this.HJIIEHBPGOL;
			float num2 = Mathf.Clamp01(num / this.animationTime);
			float num3 = 1381f * (325f - Mathf.Cos(num2 * 1237f * 998f));
			num3 = Mathf.Pow(Mathf.Clamp01(num3), 1907f);
			float x = num * 1757f;
			float num4 = Mathf.PerlinNoise(x, 1537f) * 876f - 179f;
			double num5 = (double)(Mathf.PerlinNoise(x, 1662f) * 1000f - 424f);
			float t = 1241f * (298f - Mathf.Cos(num * 460f * 1514f * 149f)) * num3;
			this.FDNGIECHEDM.x = Mathf.Lerp(this.CNBBIJFHLIG.x, this.CNBBIJFHLIG.x * this.scaleFactor, t);
			this.FDNGIECHEDM.y = Mathf.Lerp(this.CNBBIJFHLIG.y, this.CNBBIJFHLIG.y * this.scaleFactor, t);
			this.FDNGIECHEDM.z = Mathf.Lerp(this.CNBBIJFHLIG.z, this.CNBBIJFHLIG.z * this.scaleFactor, t);
			this.DGAAFGDHHHJ.localScale = this.FDNGIECHEDM;
			double num6 = (double)(num4 * this.translationAmount * num3 * 1611f);
			double num7 = num5 * (double)this.translationAmount * (double)num3 * (double)214f;
			this.FDNGIECHEDM.x = (float)((double)this.DGAAFGDHHHJ.anchoredPosition.x - this.MKMPJKOFHOH + num6);
			this.FDNGIECHEDM.y = (float)((double)this.DGAAFGDHHHJ.anchoredPosition.y - this.HDEDNBLECBK + num7);
			this.FDNGIECHEDM.z = 299f;
			this.DGAAFGDHHHJ.OGOFACPLOGO(this.FDNGIECHEDM);
			this.MKMPJKOFHOH = num6;
			this.HDEDNBLECBK = num7;
		}
	}

	// Token: 0x060038EC RID: 14572 RVA: 0x0017AE1E File Offset: 0x0017901E
	private void AMONIDCJNHB()
	{
		this.DGAAFGDHHHJ = base.gameObject.GetComponent<RectTransform>();
		this.CNBBIJFHLIG = this.DGAAFGDHHHJ.localScale;
	}

	// Token: 0x060038ED RID: 14573 RVA: 0x0017AE42 File Offset: 0x00179042
	private void LOCANABKJEE()
	{
		base.gameObject.transform.DOKill(false);
	}

	// Token: 0x060038EE RID: 14574 RVA: 0x0017AE42 File Offset: 0x00179042
	private void BFNOBDAKJON()
	{
		base.gameObject.transform.DOKill(false);
	}

	// Token: 0x060038EF RID: 14575 RVA: 0x0017AE1E File Offset: 0x0017901E
	private void KBGOLEGBMAP()
	{
		this.DGAAFGDHHHJ = base.gameObject.GetComponent<RectTransform>();
		this.CNBBIJFHLIG = this.DGAAFGDHHHJ.localScale;
	}

	// Token: 0x060038F0 RID: 14576 RVA: 0x0017B27C File Offset: 0x0017947C
	private void BNCAGDKIEJI()
	{
		if (this.DJPGBNAFDBK)
		{
			this.HJIIEHBPGOL -= Time.deltaTime;
			if (this.HJIIEHBPGOL <= 1702f)
			{
				this.DJPGBNAFDBK = true;
				this.HJIIEHBPGOL = 1276f;
				this.DGAAFGDHHHJ.localScale = this.CNBBIJFHLIG;
				this.FDNGIECHEDM.x = (float)((double)this.DGAAFGDHHHJ.anchoredPosition.x - this.MKMPJKOFHOH);
				this.FDNGIECHEDM.y = (float)((double)this.DGAAFGDHHHJ.anchoredPosition.y - this.HDEDNBLECBK);
				this.FDNGIECHEDM.z = 1281f;
				this.DGAAFGDHHHJ.OGOFACPLOGO(this.FDNGIECHEDM);
				this.MKMPJKOFHOH = 814.0;
				this.HDEDNBLECBK = 989.0;
				return;
			}
			this.DFMJCEOILNC -= Time.deltaTime;
			if (this.DFMJCEOILNC > 1498f)
			{
				return;
			}
			this.DFMJCEOILNC = this.frameUpdateInterval;
			float num = this.animationTime - this.HJIIEHBPGOL;
			float num2 = Mathf.Clamp01(num / this.animationTime);
			float num3 = 775f * (9f - Mathf.Cos(num2 * 786f * 878f));
			num3 = Mathf.Pow(Mathf.Clamp01(num3), 1677f);
			float x = num * 147f;
			float num4 = Mathf.PerlinNoise(x, 256f) * 912f - 875f;
			double num5 = (double)(Mathf.PerlinNoise(x, 1258f) * 148f - 1877f);
			float t = 410f * (1213f - Mathf.Cos(num * 1723f * 1128f * 1225f)) * num3;
			this.FDNGIECHEDM.x = Mathf.Lerp(this.CNBBIJFHLIG.x, this.CNBBIJFHLIG.x * this.scaleFactor, t);
			this.FDNGIECHEDM.y = Mathf.Lerp(this.CNBBIJFHLIG.y, this.CNBBIJFHLIG.y * this.scaleFactor, t);
			this.FDNGIECHEDM.z = Mathf.Lerp(this.CNBBIJFHLIG.z, this.CNBBIJFHLIG.z * this.scaleFactor, t);
			this.DGAAFGDHHHJ.localScale = this.FDNGIECHEDM;
			double num6 = (double)(num4 * this.translationAmount * num3 * 404f);
			double num7 = num5 * (double)this.translationAmount * (double)num3 * (double)1977f;
			this.FDNGIECHEDM.x = (float)((double)this.DGAAFGDHHHJ.anchoredPosition.x - this.MKMPJKOFHOH + num6);
			this.FDNGIECHEDM.y = (float)((double)this.DGAAFGDHHHJ.anchoredPosition.y - this.HDEDNBLECBK + num7);
			this.FDNGIECHEDM.z = 1293f;
			this.DGAAFGDHHHJ.OGOFACPLOGO(this.FDNGIECHEDM);
			this.MKMPJKOFHOH = num6;
			this.HDEDNBLECBK = num7;
		}
	}

	// Token: 0x060038F1 RID: 14577 RVA: 0x0017B584 File Offset: 0x00179784
	private void BKFCGNCKFEC()
	{
		if (this.DJPGBNAFDBK)
		{
			this.HJIIEHBPGOL -= Time.deltaTime;
			if (this.HJIIEHBPGOL <= 1643f)
			{
				this.DJPGBNAFDBK = false;
				this.HJIIEHBPGOL = 248f;
				this.DGAAFGDHHHJ.localScale = this.CNBBIJFHLIG;
				this.FDNGIECHEDM.x = (float)((double)this.DGAAFGDHHHJ.anchoredPosition.x - this.MKMPJKOFHOH);
				this.FDNGIECHEDM.y = (float)((double)this.DGAAFGDHHHJ.anchoredPosition.y - this.HDEDNBLECBK);
				this.FDNGIECHEDM.z = 1079f;
				this.DGAAFGDHHHJ.OGOFACPLOGO(this.FDNGIECHEDM);
				this.MKMPJKOFHOH = 592.0;
				this.HDEDNBLECBK = 1328.0;
				return;
			}
			this.DFMJCEOILNC -= Time.deltaTime;
			if (this.DFMJCEOILNC > 1301f)
			{
				return;
			}
			this.DFMJCEOILNC = this.frameUpdateInterval;
			float num = this.animationTime - this.HJIIEHBPGOL;
			float num2 = Mathf.Clamp01(num / this.animationTime);
			float num3 = 455f * (1264f - Mathf.Cos(num2 * 523f * 1610f));
			num3 = Mathf.Pow(Mathf.Clamp01(num3), 1936f);
			float x = num * 631f;
			float num4 = Mathf.PerlinNoise(x, 63f) * 1082f - 1995f;
			double num5 = (double)(Mathf.PerlinNoise(x, 1463f) * 544f - 1667f);
			float t = 1769f * (178f - Mathf.Cos(num * 74f * 167f * 141f)) * num3;
			this.FDNGIECHEDM.x = Mathf.Lerp(this.CNBBIJFHLIG.x, this.CNBBIJFHLIG.x * this.scaleFactor, t);
			this.FDNGIECHEDM.y = Mathf.Lerp(this.CNBBIJFHLIG.y, this.CNBBIJFHLIG.y * this.scaleFactor, t);
			this.FDNGIECHEDM.z = Mathf.Lerp(this.CNBBIJFHLIG.z, this.CNBBIJFHLIG.z * this.scaleFactor, t);
			this.DGAAFGDHHHJ.localScale = this.FDNGIECHEDM;
			double num6 = (double)(num4 * this.translationAmount * num3 * 562f);
			double num7 = num5 * (double)this.translationAmount * (double)num3 * (double)81f;
			this.FDNGIECHEDM.x = (float)((double)this.DGAAFGDHHHJ.anchoredPosition.x - this.MKMPJKOFHOH + num6);
			this.FDNGIECHEDM.y = (float)((double)this.DGAAFGDHHHJ.anchoredPosition.y - this.HDEDNBLECBK + num7);
			this.FDNGIECHEDM.z = 419f;
			this.DGAAFGDHHHJ.OGOFACPLOGO(this.FDNGIECHEDM);
			this.MKMPJKOFHOH = num6;
			this.HDEDNBLECBK = num7;
		}
	}

	// Token: 0x060038F2 RID: 14578 RVA: 0x0017B88C File Offset: 0x00179A8C
	private void CJJDKFEGFKE()
	{
		if (this.DJPGBNAFDBK)
		{
			this.HJIIEHBPGOL -= Time.deltaTime;
			if (this.HJIIEHBPGOL <= 832f)
			{
				this.DJPGBNAFDBK = false;
				this.HJIIEHBPGOL = 387f;
				this.DGAAFGDHHHJ.localScale = this.CNBBIJFHLIG;
				this.FDNGIECHEDM.x = (float)((double)this.DGAAFGDHHHJ.anchoredPosition.x - this.MKMPJKOFHOH);
				this.FDNGIECHEDM.y = (float)((double)this.DGAAFGDHHHJ.anchoredPosition.y - this.HDEDNBLECBK);
				this.FDNGIECHEDM.z = 41f;
				this.DGAAFGDHHHJ.OGOFACPLOGO(this.FDNGIECHEDM);
				this.MKMPJKOFHOH = 268.0;
				this.HDEDNBLECBK = 72.0;
				return;
			}
			this.DFMJCEOILNC -= Time.deltaTime;
			if (this.DFMJCEOILNC > 108f)
			{
				return;
			}
			this.DFMJCEOILNC = this.frameUpdateInterval;
			float num = this.animationTime - this.HJIIEHBPGOL;
			float num2 = Mathf.Clamp01(num / this.animationTime);
			float num3 = 989f * (1912f - Mathf.Cos(num2 * 1359f * 361f));
			num3 = Mathf.Pow(Mathf.Clamp01(num3), 715f);
			float x = num * 859f;
			float num4 = Mathf.PerlinNoise(x, 53f) * 1124f - 650f;
			double num5 = (double)(Mathf.PerlinNoise(x, 384f) * 1885f - 1161f);
			float t = 1971f * (473f - Mathf.Cos(num * 464f * 312f * 236f)) * num3;
			this.FDNGIECHEDM.x = Mathf.Lerp(this.CNBBIJFHLIG.x, this.CNBBIJFHLIG.x * this.scaleFactor, t);
			this.FDNGIECHEDM.y = Mathf.Lerp(this.CNBBIJFHLIG.y, this.CNBBIJFHLIG.y * this.scaleFactor, t);
			this.FDNGIECHEDM.z = Mathf.Lerp(this.CNBBIJFHLIG.z, this.CNBBIJFHLIG.z * this.scaleFactor, t);
			this.DGAAFGDHHHJ.localScale = this.FDNGIECHEDM;
			double num6 = (double)(num4 * this.translationAmount * num3 * 1093f);
			double num7 = num5 * (double)this.translationAmount * (double)num3 * (double)558f;
			this.FDNGIECHEDM.x = (float)((double)this.DGAAFGDHHHJ.anchoredPosition.x - this.MKMPJKOFHOH + num6);
			this.FDNGIECHEDM.y = (float)((double)this.DGAAFGDHHHJ.anchoredPosition.y - this.HDEDNBLECBK + num7);
			this.FDNGIECHEDM.z = 932f;
			this.DGAAFGDHHHJ.OGOFACPLOGO(this.FDNGIECHEDM);
			this.MKMPJKOFHOH = num6;
			this.HDEDNBLECBK = num7;
		}
	}

	// Token: 0x060038F3 RID: 14579 RVA: 0x0017AE1E File Offset: 0x0017901E
	private void PAJCJBEMCDN()
	{
		this.DGAAFGDHHHJ = base.gameObject.GetComponent<RectTransform>();
		this.CNBBIJFHLIG = this.DGAAFGDHHHJ.localScale;
	}

	// Token: 0x060038F4 RID: 14580 RVA: 0x0017BB94 File Offset: 0x00179D94
	private void KGENGPOFIEL()
	{
		if (this.playOnEnable)
		{
			this.MAIEJJFLEIH();
		}
	}

	// Token: 0x060038F5 RID: 14581 RVA: 0x0017BBA4 File Offset: 0x00179DA4
	public void GBDMCPCNFLO()
	{
		this.DGAAFGDHHHJ.anchoredPosition = new Vector2((float)((double)this.DGAAFGDHHHJ.anchoredPosition.x - this.MKMPJKOFHOH), (float)((double)this.DGAAFGDHHHJ.anchoredPosition.y - this.HDEDNBLECBK));
		this.MKMPJKOFHOH = 772.0;
		this.HDEDNBLECBK = 856.0;
		this.CNBBIJFHLIG = this.DGAAFGDHHHJ.localScale;
		if (WideScreenScaler.FICKNODIDKP(1487f))
		{
			WideScreenScaler component = base.gameObject.GetComponent<WideScreenScaler>();
			if (null != component)
			{
				this.CNBBIJFHLIG = component.BBNNKIBPJKI();
				DPGJIJGOCIC.PJCLICBPPDA("OnCutsceneViewShowWI");
			}
		}
		base.gameObject.transform.DOKill(false);
		this.DGAAFGDHHHJ.localScale = this.CNBBIJFHLIG;
		this.DJPGBNAFDBK = false;
		this.HJIIEHBPGOL = this.animationTime;
		this.DFMJCEOILNC = 1421f;
	}

	// Token: 0x060038F6 RID: 14582 RVA: 0x0017AE42 File Offset: 0x00179042
	private void JPNDEHBIOGC()
	{
		base.gameObject.transform.DOKill(false);
	}

	// Token: 0x060038F7 RID: 14583 RVA: 0x0017BC9C File Offset: 0x00179E9C
	private void NFFGMDALKCE()
	{
		if (this.DJPGBNAFDBK)
		{
			this.HJIIEHBPGOL -= Time.deltaTime;
			if (this.HJIIEHBPGOL <= 1860f)
			{
				this.DJPGBNAFDBK = false;
				this.HJIIEHBPGOL = 1044f;
				this.DGAAFGDHHHJ.localScale = this.CNBBIJFHLIG;
				this.FDNGIECHEDM.x = (float)((double)this.DGAAFGDHHHJ.anchoredPosition.x - this.MKMPJKOFHOH);
				this.FDNGIECHEDM.y = (float)((double)this.DGAAFGDHHHJ.anchoredPosition.y - this.HDEDNBLECBK);
				this.FDNGIECHEDM.z = 1429f;
				this.DGAAFGDHHHJ.OGOFACPLOGO(this.FDNGIECHEDM);
				this.MKMPJKOFHOH = 1257.0;
				this.HDEDNBLECBK = 430.0;
				return;
			}
			this.DFMJCEOILNC -= Time.deltaTime;
			if (this.DFMJCEOILNC > 1574f)
			{
				return;
			}
			this.DFMJCEOILNC = this.frameUpdateInterval;
			float num = this.animationTime - this.HJIIEHBPGOL;
			float num2 = Mathf.Clamp01(num / this.animationTime);
			float num3 = 1226f * (510f - Mathf.Cos(num2 * 801f * 308f));
			num3 = Mathf.Pow(Mathf.Clamp01(num3), 1048f);
			float x = num * 832f;
			float num4 = Mathf.PerlinNoise(x, 306f) * 43f - 1130f;
			double num5 = (double)(Mathf.PerlinNoise(x, 523f) * 830f - 1639f);
			float t = 1308f * (1120f - Mathf.Cos(num * 344f * 1642f * 111f)) * num3;
			this.FDNGIECHEDM.x = Mathf.Lerp(this.CNBBIJFHLIG.x, this.CNBBIJFHLIG.x * this.scaleFactor, t);
			this.FDNGIECHEDM.y = Mathf.Lerp(this.CNBBIJFHLIG.y, this.CNBBIJFHLIG.y * this.scaleFactor, t);
			this.FDNGIECHEDM.z = Mathf.Lerp(this.CNBBIJFHLIG.z, this.CNBBIJFHLIG.z * this.scaleFactor, t);
			this.DGAAFGDHHHJ.localScale = this.FDNGIECHEDM;
			double num6 = (double)(num4 * this.translationAmount * num3 * 601f);
			double num7 = num5 * (double)this.translationAmount * (double)num3 * (double)1299f;
			this.FDNGIECHEDM.x = (float)((double)this.DGAAFGDHHHJ.anchoredPosition.x - this.MKMPJKOFHOH + num6);
			this.FDNGIECHEDM.y = (float)((double)this.DGAAFGDHHHJ.anchoredPosition.y - this.HDEDNBLECBK + num7);
			this.FDNGIECHEDM.z = 481f;
			this.DGAAFGDHHHJ.OGOFACPLOGO(this.FDNGIECHEDM);
			this.MKMPJKOFHOH = num6;
			this.HDEDNBLECBK = num7;
		}
	}

	// Token: 0x060038F8 RID: 14584 RVA: 0x0017BFA4 File Offset: 0x0017A1A4
	private void OnEnable()
	{
		if (this.playOnEnable)
		{
			this.PlayAnimation();
		}
	}

	// Token: 0x060038F9 RID: 14585 RVA: 0x0017AE1E File Offset: 0x0017901E
	private void Awake()
	{
		this.DGAAFGDHHHJ = base.gameObject.GetComponent<RectTransform>();
		this.CNBBIJFHLIG = this.DGAAFGDHHHJ.localScale;
	}

	// Token: 0x060038FA RID: 14586 RVA: 0x0017AE42 File Offset: 0x00179042
	private void NJJADNLALNL()
	{
		base.gameObject.transform.DOKill(false);
	}

	// Token: 0x060038FB RID: 14587 RVA: 0x0017AF62 File Offset: 0x00179162
	private void DJDLHIOMGJB()
	{
		if (this.playOnEnable)
		{
			this.KDLJDJFDJAK();
		}
	}

	// Token: 0x060038FC RID: 14588 RVA: 0x0017AE42 File Offset: 0x00179042
	private void JBLGJPPIBJL()
	{
		base.gameObject.transform.DOKill(false);
	}

	// Token: 0x060038FD RID: 14589 RVA: 0x0017BFB4 File Offset: 0x0017A1B4
	public void DODGGGHNHCD()
	{
		this.DGAAFGDHHHJ.anchoredPosition = new Vector2((float)((double)this.DGAAFGDHHHJ.anchoredPosition.x - this.MKMPJKOFHOH), (float)((double)this.DGAAFGDHHHJ.anchoredPosition.y - this.HDEDNBLECBK));
		this.MKMPJKOFHOH = 780.0;
		this.HDEDNBLECBK = 859.0;
		this.CNBBIJFHLIG = this.DGAAFGDHHHJ.localScale;
		if (WideScreenScaler.AKDFAECJMEP(1318f))
		{
			WideScreenScaler component = base.gameObject.GetComponent<WideScreenScaler>();
			if (null != component)
			{
				this.CNBBIJFHLIG = component.BMDLNEGNGOH();
				DPGJIJGOCIC.ADFCDFHBDAF("ERROR: StoryStepChoiceExtended.StoryStepStage.executeChoice.clothes: bulk choice index must be > 0.");
			}
		}
		base.gameObject.transform.DOKill(true);
		this.DGAAFGDHHHJ.localScale = this.CNBBIJFHLIG;
		this.DJPGBNAFDBK = false;
		this.HJIIEHBPGOL = this.animationTime;
		this.DFMJCEOILNC = 426f;
	}

	// Token: 0x060038FE RID: 14590 RVA: 0x0017C0AC File Offset: 0x0017A2AC
	public void GNGHPDNEBDJ()
	{
		this.DGAAFGDHHHJ.anchoredPosition = new Vector2((float)((double)this.DGAAFGDHHHJ.anchoredPosition.x - this.MKMPJKOFHOH), (float)((double)this.DGAAFGDHHHJ.anchoredPosition.y - this.HDEDNBLECBK));
		this.MKMPJKOFHOH = 936.0;
		this.HDEDNBLECBK = 355.0;
		this.CNBBIJFHLIG = this.DGAAFGDHHHJ.localScale;
		if (WideScreenScaler.AAOLPGHOGNO(19f))
		{
			WideScreenScaler component = base.gameObject.GetComponent<WideScreenScaler>();
			if (null != component)
			{
				this.CNBBIJFHLIG = component.NAIFCIGCBNP();
				DPGJIJGOCIC.ADFCDFHBDAF("_not_found");
			}
		}
		base.gameObject.transform.DOKill(true);
		this.DGAAFGDHHHJ.localScale = this.CNBBIJFHLIG;
		this.DJPGBNAFDBK = false;
		this.HJIIEHBPGOL = this.animationTime;
		this.DFMJCEOILNC = 369f;
	}

	// Token: 0x060038FF RID: 14591 RVA: 0x0017AE1E File Offset: 0x0017901E
	private void ANPIDDAIALE()
	{
		this.DGAAFGDHHHJ = base.gameObject.GetComponent<RectTransform>();
		this.CNBBIJFHLIG = this.DGAAFGDHHHJ.localScale;
	}

	// Token: 0x06003900 RID: 14592 RVA: 0x0017C1A4 File Offset: 0x0017A3A4
	private void HAGIEEDOADD()
	{
		if (this.DJPGBNAFDBK)
		{
			this.HJIIEHBPGOL -= Time.deltaTime;
			if (this.HJIIEHBPGOL <= 838f)
			{
				this.DJPGBNAFDBK = false;
				this.HJIIEHBPGOL = 378f;
				this.DGAAFGDHHHJ.localScale = this.CNBBIJFHLIG;
				this.FDNGIECHEDM.x = (float)((double)this.DGAAFGDHHHJ.anchoredPosition.x - this.MKMPJKOFHOH);
				this.FDNGIECHEDM.y = (float)((double)this.DGAAFGDHHHJ.anchoredPosition.y - this.HDEDNBLECBK);
				this.FDNGIECHEDM.z = 850f;
				this.DGAAFGDHHHJ.OGOFACPLOGO(this.FDNGIECHEDM);
				this.MKMPJKOFHOH = 587.0;
				this.HDEDNBLECBK = 1080.0;
				return;
			}
			this.DFMJCEOILNC -= Time.deltaTime;
			if (this.DFMJCEOILNC > 867f)
			{
				return;
			}
			this.DFMJCEOILNC = this.frameUpdateInterval;
			float num = this.animationTime - this.HJIIEHBPGOL;
			float num2 = Mathf.Clamp01(num / this.animationTime);
			float num3 = 1191f * (246f - Mathf.Cos(num2 * 1308f * 1324f));
			num3 = Mathf.Pow(Mathf.Clamp01(num3), 887f);
			float x = num * 1576f;
			float num4 = Mathf.PerlinNoise(x, 437f) * 1792f - 490f;
			double num5 = (double)(Mathf.PerlinNoise(x, 585f) * 517f - 991f);
			float t = 493f * (1056f - Mathf.Cos(num * 490f * 415f * 1112f)) * num3;
			this.FDNGIECHEDM.x = Mathf.Lerp(this.CNBBIJFHLIG.x, this.CNBBIJFHLIG.x * this.scaleFactor, t);
			this.FDNGIECHEDM.y = Mathf.Lerp(this.CNBBIJFHLIG.y, this.CNBBIJFHLIG.y * this.scaleFactor, t);
			this.FDNGIECHEDM.z = Mathf.Lerp(this.CNBBIJFHLIG.z, this.CNBBIJFHLIG.z * this.scaleFactor, t);
			this.DGAAFGDHHHJ.localScale = this.FDNGIECHEDM;
			double num6 = (double)(num4 * this.translationAmount * num3 * 1119f);
			double num7 = num5 * (double)this.translationAmount * (double)num3 * (double)1197f;
			this.FDNGIECHEDM.x = (float)((double)this.DGAAFGDHHHJ.anchoredPosition.x - this.MKMPJKOFHOH + num6);
			this.FDNGIECHEDM.y = (float)((double)this.DGAAFGDHHHJ.anchoredPosition.y - this.HDEDNBLECBK + num7);
			this.FDNGIECHEDM.z = 829f;
			this.DGAAFGDHHHJ.OGOFACPLOGO(this.FDNGIECHEDM);
			this.MKMPJKOFHOH = num6;
			this.HDEDNBLECBK = num7;
		}
	}

	// Token: 0x06003901 RID: 14593 RVA: 0x0017AE1E File Offset: 0x0017901E
	private void PKJBCFKMGHE()
	{
		this.DGAAFGDHHHJ = base.gameObject.GetComponent<RectTransform>();
		this.CNBBIJFHLIG = this.DGAAFGDHHHJ.localScale;
	}

	// Token: 0x06003902 RID: 14594 RVA: 0x0017C4AC File Offset: 0x0017A6AC
	private void PJCAGMOADBK()
	{
		if (this.playOnEnable)
		{
			this.NPBNPBBHJPI();
		}
	}

	// Token: 0x06003903 RID: 14595 RVA: 0x0017AE1E File Offset: 0x0017901E
	private void LFPPGGLOOHJ()
	{
		this.DGAAFGDHHHJ = base.gameObject.GetComponent<RectTransform>();
		this.CNBBIJFHLIG = this.DGAAFGDHHHJ.localScale;
	}

	// Token: 0x06003904 RID: 14596 RVA: 0x0017C4BC File Offset: 0x0017A6BC
	public void MAIEJJFLEIH()
	{
		this.DGAAFGDHHHJ.anchoredPosition = new Vector2((float)((double)this.DGAAFGDHHHJ.anchoredPosition.x - this.MKMPJKOFHOH), (float)((double)this.DGAAFGDHHHJ.anchoredPosition.y - this.HDEDNBLECBK));
		this.MKMPJKOFHOH = 357.0;
		this.HDEDNBLECBK = 1279.0;
		this.CNBBIJFHLIG = this.DGAAFGDHHHJ.localScale;
		if (WideScreenScaler.CEJJDGNDFGK(215f))
		{
			WideScreenScaler component = base.gameObject.GetComponent<WideScreenScaler>();
			if (null != component)
			{
				this.CNBBIJFHLIG = component.FKFOOAACAOG();
				DPGJIJGOCIC.ADFCDFHBDAF("not_found");
			}
		}
		base.gameObject.transform.DOKill(true);
		this.DGAAFGDHHHJ.localScale = this.CNBBIJFHLIG;
		this.DJPGBNAFDBK = false;
		this.HJIIEHBPGOL = this.animationTime;
		this.DFMJCEOILNC = 464f;
	}

	// Token: 0x06003905 RID: 14597 RVA: 0x0017C5B4 File Offset: 0x0017A7B4
	public void CKOGKCMDLDI()
	{
		this.DGAAFGDHHHJ.anchoredPosition = new Vector2((float)((double)this.DGAAFGDHHHJ.anchoredPosition.x - this.MKMPJKOFHOH), (float)((double)this.DGAAFGDHHHJ.anchoredPosition.y - this.HDEDNBLECBK));
		this.MKMPJKOFHOH = 519.0;
		this.HDEDNBLECBK = 1837.0;
		this.CNBBIJFHLIG = this.DGAAFGDHHHJ.localScale;
		if (WideScreenScaler.OBHPFIBFDLO(899f))
		{
			WideScreenScaler component = base.gameObject.GetComponent<WideScreenScaler>();
			if (null != component)
			{
				this.CNBBIJFHLIG = component.GetNewScale();
				DPGJIJGOCIC.ADFCDFHBDAF("OnStoryChoiceClick");
			}
		}
		base.gameObject.transform.DOKill(false);
		this.DGAAFGDHHHJ.localScale = this.CNBBIJFHLIG;
		this.DJPGBNAFDBK = false;
		this.HJIIEHBPGOL = this.animationTime;
		this.DFMJCEOILNC = 140f;
	}

	// Token: 0x06003906 RID: 14598 RVA: 0x0017AF4E File Offset: 0x0017914E
	private void KCIHDOMDINL()
	{
		base.gameObject.transform.DOKill(true);
	}

	// Token: 0x06003907 RID: 14599 RVA: 0x0017AE42 File Offset: 0x00179042
	private void FEBECEEIHBP()
	{
		base.gameObject.transform.DOKill(false);
	}

	// Token: 0x06003908 RID: 14600 RVA: 0x0017AE42 File Offset: 0x00179042
	private void GJMIHJNBPEB()
	{
		base.gameObject.transform.DOKill(false);
	}

	// Token: 0x06003909 RID: 14601 RVA: 0x0017AE42 File Offset: 0x00179042
	private void PBLDIMHDNNJ()
	{
		base.gameObject.transform.DOKill(false);
	}

	// Token: 0x0600390A RID: 14602 RVA: 0x0017AE42 File Offset: 0x00179042
	private void KDKPPDMCEBF()
	{
		base.gameObject.transform.DOKill(false);
	}

	// Token: 0x0600390B RID: 14603 RVA: 0x0017AE1E File Offset: 0x0017901E
	private void KBGANABGEMK()
	{
		this.DGAAFGDHHHJ = base.gameObject.GetComponent<RectTransform>();
		this.CNBBIJFHLIG = this.DGAAFGDHHHJ.localScale;
	}

	// Token: 0x0600390C RID: 14604 RVA: 0x0017C6AC File Offset: 0x0017A8AC
	private void BEFIJFGNNNK()
	{
		if (this.DJPGBNAFDBK)
		{
			this.HJIIEHBPGOL -= Time.deltaTime;
			if (this.HJIIEHBPGOL <= 1964f)
			{
				this.DJPGBNAFDBK = false;
				this.HJIIEHBPGOL = 1662f;
				this.DGAAFGDHHHJ.localScale = this.CNBBIJFHLIG;
				this.FDNGIECHEDM.x = (float)((double)this.DGAAFGDHHHJ.anchoredPosition.x - this.MKMPJKOFHOH);
				this.FDNGIECHEDM.y = (float)((double)this.DGAAFGDHHHJ.anchoredPosition.y - this.HDEDNBLECBK);
				this.FDNGIECHEDM.z = 1183f;
				this.DGAAFGDHHHJ.OGOFACPLOGO(this.FDNGIECHEDM);
				this.MKMPJKOFHOH = 836.0;
				this.HDEDNBLECBK = 1406.0;
				return;
			}
			this.DFMJCEOILNC -= Time.deltaTime;
			if (this.DFMJCEOILNC > 1588f)
			{
				return;
			}
			this.DFMJCEOILNC = this.frameUpdateInterval;
			float num = this.animationTime - this.HJIIEHBPGOL;
			float num2 = Mathf.Clamp01(num / this.animationTime);
			float num3 = 474f * (1405f - Mathf.Cos(num2 * 89f * 1774f));
			num3 = Mathf.Pow(Mathf.Clamp01(num3), 125f);
			float x = num * 361f;
			float num4 = Mathf.PerlinNoise(x, 1451f) * 1273f - 982f;
			double num5 = (double)(Mathf.PerlinNoise(x, 1940f) * 1535f - 1950f);
			float t = 1458f * (1190f - Mathf.Cos(num * 1188f * 1421f * 207f)) * num3;
			this.FDNGIECHEDM.x = Mathf.Lerp(this.CNBBIJFHLIG.x, this.CNBBIJFHLIG.x * this.scaleFactor, t);
			this.FDNGIECHEDM.y = Mathf.Lerp(this.CNBBIJFHLIG.y, this.CNBBIJFHLIG.y * this.scaleFactor, t);
			this.FDNGIECHEDM.z = Mathf.Lerp(this.CNBBIJFHLIG.z, this.CNBBIJFHLIG.z * this.scaleFactor, t);
			this.DGAAFGDHHHJ.localScale = this.FDNGIECHEDM;
			double num6 = (double)(num4 * this.translationAmount * num3 * 630f);
			double num7 = num5 * (double)this.translationAmount * (double)num3 * (double)1622f;
			this.FDNGIECHEDM.x = (float)((double)this.DGAAFGDHHHJ.anchoredPosition.x - this.MKMPJKOFHOH + num6);
			this.FDNGIECHEDM.y = (float)((double)this.DGAAFGDHHHJ.anchoredPosition.y - this.HDEDNBLECBK + num7);
			this.FDNGIECHEDM.z = 1042f;
			this.DGAAFGDHHHJ.OGOFACPLOGO(this.FDNGIECHEDM);
			this.MKMPJKOFHOH = num6;
			this.HDEDNBLECBK = num7;
		}
	}

	// Token: 0x0600390D RID: 14605 RVA: 0x0017C9B4 File Offset: 0x0017ABB4
	private void KHOLJLKNAPJ()
	{
		if (this.playOnEnable)
		{
			this.AHGHAIEKAIL();
		}
	}

	// Token: 0x0600390E RID: 14606 RVA: 0x0017C9C4 File Offset: 0x0017ABC4
	private void MFFLJDMOMPD()
	{
		if (this.playOnEnable)
		{
			this.DOEGPEFNOLK();
		}
	}

	// Token: 0x0600390F RID: 14607 RVA: 0x0017C9D4 File Offset: 0x0017ABD4
	private void BKLLPIBAGGO()
	{
		if (this.DJPGBNAFDBK)
		{
			this.HJIIEHBPGOL -= Time.deltaTime;
			if (this.HJIIEHBPGOL <= 115f)
			{
				this.DJPGBNAFDBK = true;
				this.HJIIEHBPGOL = 582f;
				this.DGAAFGDHHHJ.localScale = this.CNBBIJFHLIG;
				this.FDNGIECHEDM.x = (float)((double)this.DGAAFGDHHHJ.anchoredPosition.x - this.MKMPJKOFHOH);
				this.FDNGIECHEDM.y = (float)((double)this.DGAAFGDHHHJ.anchoredPosition.y - this.HDEDNBLECBK);
				this.FDNGIECHEDM.z = 145f;
				this.DGAAFGDHHHJ.OGOFACPLOGO(this.FDNGIECHEDM);
				this.MKMPJKOFHOH = 1496.0;
				this.HDEDNBLECBK = 516.0;
				return;
			}
			this.DFMJCEOILNC -= Time.deltaTime;
			if (this.DFMJCEOILNC > 553f)
			{
				return;
			}
			this.DFMJCEOILNC = this.frameUpdateInterval;
			float num = this.animationTime - this.HJIIEHBPGOL;
			float num2 = Mathf.Clamp01(num / this.animationTime);
			float num3 = 1451f * (1396f - Mathf.Cos(num2 * 1420f * 667f));
			num3 = Mathf.Pow(Mathf.Clamp01(num3), 206f);
			float x = num * 262f;
			float num4 = Mathf.PerlinNoise(x, 186f) * 1171f - 593f;
			double num5 = (double)(Mathf.PerlinNoise(x, 143f) * 130f - 1952f);
			float t = 1515f * (618f - Mathf.Cos(num * 1208f * 252f * 1114f)) * num3;
			this.FDNGIECHEDM.x = Mathf.Lerp(this.CNBBIJFHLIG.x, this.CNBBIJFHLIG.x * this.scaleFactor, t);
			this.FDNGIECHEDM.y = Mathf.Lerp(this.CNBBIJFHLIG.y, this.CNBBIJFHLIG.y * this.scaleFactor, t);
			this.FDNGIECHEDM.z = Mathf.Lerp(this.CNBBIJFHLIG.z, this.CNBBIJFHLIG.z * this.scaleFactor, t);
			this.DGAAFGDHHHJ.localScale = this.FDNGIECHEDM;
			double num6 = (double)(num4 * this.translationAmount * num3 * 895f);
			double num7 = num5 * (double)this.translationAmount * (double)num3 * (double)268f;
			this.FDNGIECHEDM.x = (float)((double)this.DGAAFGDHHHJ.anchoredPosition.x - this.MKMPJKOFHOH + num6);
			this.FDNGIECHEDM.y = (float)((double)this.DGAAFGDHHHJ.anchoredPosition.y - this.HDEDNBLECBK + num7);
			this.FDNGIECHEDM.z = 880f;
			this.DGAAFGDHHHJ.OGOFACPLOGO(this.FDNGIECHEDM);
			this.MKMPJKOFHOH = num6;
			this.HDEDNBLECBK = num7;
		}
	}

	// Token: 0x06003911 RID: 14609 RVA: 0x0017CD0C File Offset: 0x0017AF0C
	private void KMEGABEIPBL()
	{
		if (this.DJPGBNAFDBK)
		{
			this.HJIIEHBPGOL -= Time.deltaTime;
			if (this.HJIIEHBPGOL <= 1328f)
			{
				this.DJPGBNAFDBK = false;
				this.HJIIEHBPGOL = 244f;
				this.DGAAFGDHHHJ.localScale = this.CNBBIJFHLIG;
				this.FDNGIECHEDM.x = (float)((double)this.DGAAFGDHHHJ.anchoredPosition.x - this.MKMPJKOFHOH);
				this.FDNGIECHEDM.y = (float)((double)this.DGAAFGDHHHJ.anchoredPosition.y - this.HDEDNBLECBK);
				this.FDNGIECHEDM.z = 1332f;
				this.DGAAFGDHHHJ.OGOFACPLOGO(this.FDNGIECHEDM);
				this.MKMPJKOFHOH = 107.0;
				this.HDEDNBLECBK = 1782.0;
				return;
			}
			this.DFMJCEOILNC -= Time.deltaTime;
			if (this.DFMJCEOILNC > 1855f)
			{
				return;
			}
			this.DFMJCEOILNC = this.frameUpdateInterval;
			float num = this.animationTime - this.HJIIEHBPGOL;
			float num2 = Mathf.Clamp01(num / this.animationTime);
			float num3 = 767f * (137f - Mathf.Cos(num2 * 492f * 528f));
			num3 = Mathf.Pow(Mathf.Clamp01(num3), 1448f);
			float x = num * 1750f;
			float num4 = Mathf.PerlinNoise(x, 379f) * 1914f - 1472f;
			double num5 = (double)(Mathf.PerlinNoise(x, 127f) * 274f - 112f);
			float t = 274f * (1718f - Mathf.Cos(num * 558f * 384f * 949f)) * num3;
			this.FDNGIECHEDM.x = Mathf.Lerp(this.CNBBIJFHLIG.x, this.CNBBIJFHLIG.x * this.scaleFactor, t);
			this.FDNGIECHEDM.y = Mathf.Lerp(this.CNBBIJFHLIG.y, this.CNBBIJFHLIG.y * this.scaleFactor, t);
			this.FDNGIECHEDM.z = Mathf.Lerp(this.CNBBIJFHLIG.z, this.CNBBIJFHLIG.z * this.scaleFactor, t);
			this.DGAAFGDHHHJ.localScale = this.FDNGIECHEDM;
			double num6 = (double)(num4 * this.translationAmount * num3 * 1942f);
			double num7 = num5 * (double)this.translationAmount * (double)num3 * (double)134f;
			this.FDNGIECHEDM.x = (float)((double)this.DGAAFGDHHHJ.anchoredPosition.x - this.MKMPJKOFHOH + num6);
			this.FDNGIECHEDM.y = (float)((double)this.DGAAFGDHHHJ.anchoredPosition.y - this.HDEDNBLECBK + num7);
			this.FDNGIECHEDM.z = 780f;
			this.DGAAFGDHHHJ.OGOFACPLOGO(this.FDNGIECHEDM);
			this.MKMPJKOFHOH = num6;
			this.HDEDNBLECBK = num7;
		}
	}

	// Token: 0x06003912 RID: 14610 RVA: 0x0017D014 File Offset: 0x0017B214
	private void OPFEBCFFCCA()
	{
		if (this.playOnEnable)
		{
			this.KDBPEMFKNJE();
		}
	}

	// Token: 0x06003913 RID: 14611 RVA: 0x0017D024 File Offset: 0x0017B224
	private void PNEBOIIJMDK()
	{
		if (this.DJPGBNAFDBK)
		{
			this.HJIIEHBPGOL -= Time.deltaTime;
			if (this.HJIIEHBPGOL <= 1243f)
			{
				this.DJPGBNAFDBK = true;
				this.HJIIEHBPGOL = 597f;
				this.DGAAFGDHHHJ.localScale = this.CNBBIJFHLIG;
				this.FDNGIECHEDM.x = (float)((double)this.DGAAFGDHHHJ.anchoredPosition.x - this.MKMPJKOFHOH);
				this.FDNGIECHEDM.y = (float)((double)this.DGAAFGDHHHJ.anchoredPosition.y - this.HDEDNBLECBK);
				this.FDNGIECHEDM.z = 407f;
				this.DGAAFGDHHHJ.OGOFACPLOGO(this.FDNGIECHEDM);
				this.MKMPJKOFHOH = 792.0;
				this.HDEDNBLECBK = 1569.0;
				return;
			}
			this.DFMJCEOILNC -= Time.deltaTime;
			if (this.DFMJCEOILNC > 1918f)
			{
				return;
			}
			this.DFMJCEOILNC = this.frameUpdateInterval;
			float num = this.animationTime - this.HJIIEHBPGOL;
			float num2 = Mathf.Clamp01(num / this.animationTime);
			float num3 = 195f * (264f - Mathf.Cos(num2 * 1308f * 660f));
			num3 = Mathf.Pow(Mathf.Clamp01(num3), 1320f);
			float x = num * 1595f;
			float num4 = Mathf.PerlinNoise(x, 668f) * 1421f - 713f;
			double num5 = (double)(Mathf.PerlinNoise(x, 522f) * 765f - 300f);
			float t = 503f * (1504f - Mathf.Cos(num * 1220f * 702f * 1605f)) * num3;
			this.FDNGIECHEDM.x = Mathf.Lerp(this.CNBBIJFHLIG.x, this.CNBBIJFHLIG.x * this.scaleFactor, t);
			this.FDNGIECHEDM.y = Mathf.Lerp(this.CNBBIJFHLIG.y, this.CNBBIJFHLIG.y * this.scaleFactor, t);
			this.FDNGIECHEDM.z = Mathf.Lerp(this.CNBBIJFHLIG.z, this.CNBBIJFHLIG.z * this.scaleFactor, t);
			this.DGAAFGDHHHJ.localScale = this.FDNGIECHEDM;
			double num6 = (double)(num4 * this.translationAmount * num3 * 1349f);
			double num7 = num5 * (double)this.translationAmount * (double)num3 * (double)819f;
			this.FDNGIECHEDM.x = (float)((double)this.DGAAFGDHHHJ.anchoredPosition.x - this.MKMPJKOFHOH + num6);
			this.FDNGIECHEDM.y = (float)((double)this.DGAAFGDHHHJ.anchoredPosition.y - this.HDEDNBLECBK + num7);
			this.FDNGIECHEDM.z = 1606f;
			this.DGAAFGDHHHJ.OGOFACPLOGO(this.FDNGIECHEDM);
			this.MKMPJKOFHOH = num6;
			this.HDEDNBLECBK = num7;
		}
	}

	// Token: 0x06003914 RID: 14612 RVA: 0x0017AE42 File Offset: 0x00179042
	private void OANOLIAPPMH()
	{
		base.gameObject.transform.DOKill(false);
	}

	// Token: 0x06003915 RID: 14613 RVA: 0x0017AE42 File Offset: 0x00179042
	private void OnDestroy()
	{
		base.gameObject.transform.DOKill(false);
	}

	// Token: 0x06003916 RID: 14614 RVA: 0x0017D32C File Offset: 0x0017B52C
	private void GKJGAJOMNKD()
	{
		if (this.DJPGBNAFDBK)
		{
			this.HJIIEHBPGOL -= Time.deltaTime;
			if (this.HJIIEHBPGOL <= 1585f)
			{
				this.DJPGBNAFDBK = true;
				this.HJIIEHBPGOL = 577f;
				this.DGAAFGDHHHJ.localScale = this.CNBBIJFHLIG;
				this.FDNGIECHEDM.x = (float)((double)this.DGAAFGDHHHJ.anchoredPosition.x - this.MKMPJKOFHOH);
				this.FDNGIECHEDM.y = (float)((double)this.DGAAFGDHHHJ.anchoredPosition.y - this.HDEDNBLECBK);
				this.FDNGIECHEDM.z = 1636f;
				this.DGAAFGDHHHJ.OGOFACPLOGO(this.FDNGIECHEDM);
				this.MKMPJKOFHOH = 1347.0;
				this.HDEDNBLECBK = 512.0;
				return;
			}
			this.DFMJCEOILNC -= Time.deltaTime;
			if (this.DFMJCEOILNC > 1411f)
			{
				return;
			}
			this.DFMJCEOILNC = this.frameUpdateInterval;
			float num = this.animationTime - this.HJIIEHBPGOL;
			float num2 = Mathf.Clamp01(num / this.animationTime);
			float num3 = 1818f * (209f - Mathf.Cos(num2 * 1563f * 48f));
			num3 = Mathf.Pow(Mathf.Clamp01(num3), 808f);
			float x = num * 1785f;
			float num4 = Mathf.PerlinNoise(x, 440f) * 158f - 909f;
			double num5 = (double)(Mathf.PerlinNoise(x, 66f) * 1486f - 874f);
			float t = 1879f * (1296f - Mathf.Cos(num * 552f * 1684f * 955f)) * num3;
			this.FDNGIECHEDM.x = Mathf.Lerp(this.CNBBIJFHLIG.x, this.CNBBIJFHLIG.x * this.scaleFactor, t);
			this.FDNGIECHEDM.y = Mathf.Lerp(this.CNBBIJFHLIG.y, this.CNBBIJFHLIG.y * this.scaleFactor, t);
			this.FDNGIECHEDM.z = Mathf.Lerp(this.CNBBIJFHLIG.z, this.CNBBIJFHLIG.z * this.scaleFactor, t);
			this.DGAAFGDHHHJ.localScale = this.FDNGIECHEDM;
			double num6 = (double)(num4 * this.translationAmount * num3 * 1059f);
			double num7 = num5 * (double)this.translationAmount * (double)num3 * (double)1074f;
			this.FDNGIECHEDM.x = (float)((double)this.DGAAFGDHHHJ.anchoredPosition.x - this.MKMPJKOFHOH + num6);
			this.FDNGIECHEDM.y = (float)((double)this.DGAAFGDHHHJ.anchoredPosition.y - this.HDEDNBLECBK + num7);
			this.FDNGIECHEDM.z = 346f;
			this.DGAAFGDHHHJ.OGOFACPLOGO(this.FDNGIECHEDM);
			this.MKMPJKOFHOH = num6;
			this.HDEDNBLECBK = num7;
		}
	}

	// Token: 0x06003917 RID: 14615 RVA: 0x0017AF4E File Offset: 0x0017914E
	private void JIJNNDHINGK()
	{
		base.gameObject.transform.DOKill(true);
	}

	// Token: 0x06003918 RID: 14616 RVA: 0x0017D634 File Offset: 0x0017B834
	private void DHNDICIEGEE()
	{
		if (this.playOnEnable)
		{
			this.DODGGGHNHCD();
		}
	}

	// Token: 0x06003919 RID: 14617 RVA: 0x0017D644 File Offset: 0x0017B844
	public void FFKFIKPGJDI()
	{
		this.DGAAFGDHHHJ.anchoredPosition = new Vector2((float)((double)this.DGAAFGDHHHJ.anchoredPosition.x - this.MKMPJKOFHOH), (float)((double)this.DGAAFGDHHHJ.anchoredPosition.y - this.HDEDNBLECBK));
		this.MKMPJKOFHOH = 855.0;
		this.HDEDNBLECBK = 281.0;
		this.CNBBIJFHLIG = this.DGAAFGDHHHJ.localScale;
		if (WideScreenScaler.MAFGKLMFBAN(1071f))
		{
			WideScreenScaler component = base.gameObject.GetComponent<WideScreenScaler>();
			if (null != component)
			{
				this.CNBBIJFHLIG = component.EIKHJLDIILI();
				DPGJIJGOCIC.PJCLICBPPDA("@");
			}
		}
		base.gameObject.transform.DOKill(false);
		this.DGAAFGDHHHJ.localScale = this.CNBBIJFHLIG;
		this.DJPGBNAFDBK = true;
		this.HJIIEHBPGOL = this.animationTime;
		this.DFMJCEOILNC = 1125f;
	}

	// Token: 0x0600391A RID: 14618 RVA: 0x0017AE42 File Offset: 0x00179042
	private void KGDGHFPMENB()
	{
		base.gameObject.transform.DOKill(false);
	}

	// Token: 0x0600391B RID: 14619 RVA: 0x0017AE1E File Offset: 0x0017901E
	private void LJCOLPBKBBH()
	{
		this.DGAAFGDHHHJ = base.gameObject.GetComponent<RectTransform>();
		this.CNBBIJFHLIG = this.DGAAFGDHHHJ.localScale;
	}

	// Token: 0x0600391C RID: 14620 RVA: 0x0017D73C File Offset: 0x0017B93C
	private void KPCLFGJLNJF()
	{
		if (this.DJPGBNAFDBK)
		{
			this.HJIIEHBPGOL -= Time.deltaTime;
			if (this.HJIIEHBPGOL <= 450f)
			{
				this.DJPGBNAFDBK = true;
				this.HJIIEHBPGOL = 508f;
				this.DGAAFGDHHHJ.localScale = this.CNBBIJFHLIG;
				this.FDNGIECHEDM.x = (float)((double)this.DGAAFGDHHHJ.anchoredPosition.x - this.MKMPJKOFHOH);
				this.FDNGIECHEDM.y = (float)((double)this.DGAAFGDHHHJ.anchoredPosition.y - this.HDEDNBLECBK);
				this.FDNGIECHEDM.z = 1767f;
				this.DGAAFGDHHHJ.OGOFACPLOGO(this.FDNGIECHEDM);
				this.MKMPJKOFHOH = 1505.0;
				this.HDEDNBLECBK = 1784.0;
				return;
			}
			this.DFMJCEOILNC -= Time.deltaTime;
			if (this.DFMJCEOILNC > 392f)
			{
				return;
			}
			this.DFMJCEOILNC = this.frameUpdateInterval;
			float num = this.animationTime - this.HJIIEHBPGOL;
			float num2 = Mathf.Clamp01(num / this.animationTime);
			float num3 = 1274f * (718f - Mathf.Cos(num2 * 1910f * 277f));
			num3 = Mathf.Pow(Mathf.Clamp01(num3), 1751f);
			float x = num * 460f;
			float num4 = Mathf.PerlinNoise(x, 1758f) * 1121f - 1337f;
			double num5 = (double)(Mathf.PerlinNoise(x, 1117f) * 43f - 656f);
			float t = 411f * (1896f - Mathf.Cos(num * 1545f * 1206f * 1531f)) * num3;
			this.FDNGIECHEDM.x = Mathf.Lerp(this.CNBBIJFHLIG.x, this.CNBBIJFHLIG.x * this.scaleFactor, t);
			this.FDNGIECHEDM.y = Mathf.Lerp(this.CNBBIJFHLIG.y, this.CNBBIJFHLIG.y * this.scaleFactor, t);
			this.FDNGIECHEDM.z = Mathf.Lerp(this.CNBBIJFHLIG.z, this.CNBBIJFHLIG.z * this.scaleFactor, t);
			this.DGAAFGDHHHJ.localScale = this.FDNGIECHEDM;
			double num6 = (double)(num4 * this.translationAmount * num3 * 90f);
			double num7 = num5 * (double)this.translationAmount * (double)num3 * (double)909f;
			this.FDNGIECHEDM.x = (float)((double)this.DGAAFGDHHHJ.anchoredPosition.x - this.MKMPJKOFHOH + num6);
			this.FDNGIECHEDM.y = (float)((double)this.DGAAFGDHHHJ.anchoredPosition.y - this.HDEDNBLECBK + num7);
			this.FDNGIECHEDM.z = 1080f;
			this.DGAAFGDHHHJ.OGOFACPLOGO(this.FDNGIECHEDM);
			this.MKMPJKOFHOH = num6;
			this.HDEDNBLECBK = num7;
		}
	}

	// Token: 0x0600391D RID: 14621 RVA: 0x0017AE1E File Offset: 0x0017901E
	private void DCEHHOHHFDM()
	{
		this.DGAAFGDHHHJ = base.gameObject.GetComponent<RectTransform>();
		this.CNBBIJFHLIG = this.DGAAFGDHHHJ.localScale;
	}

	// Token: 0x0600391E RID: 14622 RVA: 0x0017AE1E File Offset: 0x0017901E
	private void LFOJBMBCOFP()
	{
		this.DGAAFGDHHHJ = base.gameObject.GetComponent<RectTransform>();
		this.CNBBIJFHLIG = this.DGAAFGDHHHJ.localScale;
	}

	// Token: 0x0600391F RID: 14623 RVA: 0x0017D014 File Offset: 0x0017B214
	private void NIEEOIPNBAA()
	{
		if (this.playOnEnable)
		{
			this.KDBPEMFKNJE();
		}
	}

	// Token: 0x06003920 RID: 14624 RVA: 0x0017AF4E File Offset: 0x0017914E
	private void DNANKPMNMIF()
	{
		base.gameObject.transform.DOKill(true);
	}

	// Token: 0x06003921 RID: 14625 RVA: 0x0017DA44 File Offset: 0x0017BC44
	public void KDLJDJFDJAK()
	{
		this.DGAAFGDHHHJ.anchoredPosition = new Vector2((float)((double)this.DGAAFGDHHHJ.anchoredPosition.x - this.MKMPJKOFHOH), (float)((double)this.DGAAFGDHHHJ.anchoredPosition.y - this.HDEDNBLECBK));
		this.MKMPJKOFHOH = 173.0;
		this.HDEDNBLECBK = 130.0;
		this.CNBBIJFHLIG = this.DGAAFGDHHHJ.localScale;
		if (WideScreenScaler.MDFPEEFCLHK(745f))
		{
			WideScreenScaler component = base.gameObject.GetComponent<WideScreenScaler>();
			if (null != component)
			{
				this.CNBBIJFHLIG = component.NAIFCIGCBNP();
				DPGJIJGOCIC.ADFCDFHBDAF("+");
			}
		}
		base.gameObject.transform.DOKill(true);
		this.DGAAFGDHHHJ.localScale = this.CNBBIJFHLIG;
		this.DJPGBNAFDBK = false;
		this.HJIIEHBPGOL = this.animationTime;
		this.DFMJCEOILNC = 410f;
	}

	// Token: 0x06003922 RID: 14626 RVA: 0x0017DB3C File Offset: 0x0017BD3C
	public void PlayAnimation()
	{
		this.DGAAFGDHHHJ.anchoredPosition = new Vector2((float)((double)this.DGAAFGDHHHJ.anchoredPosition.x - this.MKMPJKOFHOH), (float)((double)this.DGAAFGDHHHJ.anchoredPosition.y - this.HDEDNBLECBK));
		this.MKMPJKOFHOH = 0.0;
		this.HDEDNBLECBK = 0.0;
		this.CNBBIJFHLIG = this.DGAAFGDHHHJ.localScale;
		if (WideScreenScaler.ScreenIsTooWide(1440f))
		{
			WideScreenScaler component = base.gameObject.GetComponent<WideScreenScaler>();
			if (null != component)
			{
				this.CNBBIJFHLIG = component.GetNewScale();
				DPGJIJGOCIC.ADFCDFHBDAF("WideScreenScaler(): screen is to wide, AnimationShake will be adjusted accordingly.");
			}
		}
		base.gameObject.transform.DOKill(false);
		this.DGAAFGDHHHJ.localScale = this.CNBBIJFHLIG;
		this.DJPGBNAFDBK = true;
		this.HJIIEHBPGOL = this.animationTime;
		this.DFMJCEOILNC = -1f;
	}

	// Token: 0x06003923 RID: 14627 RVA: 0x0017AE1E File Offset: 0x0017901E
	private void LPCKKJNJJCB()
	{
		this.DGAAFGDHHHJ = base.gameObject.GetComponent<RectTransform>();
		this.CNBBIJFHLIG = this.DGAAFGDHHHJ.localScale;
	}

	// Token: 0x06003924 RID: 14628 RVA: 0x0017AE42 File Offset: 0x00179042
	private void HHDMNFGALBA()
	{
		base.gameObject.transform.DOKill(false);
	}

	// Token: 0x06003925 RID: 14629 RVA: 0x0017AF4E File Offset: 0x0017914E
	private void HKELFCJCJHK()
	{
		base.gameObject.transform.DOKill(true);
	}

	// Token: 0x06003926 RID: 14630 RVA: 0x0017AE42 File Offset: 0x00179042
	private void NINHFENBENF()
	{
		base.gameObject.transform.DOKill(false);
	}

	// Token: 0x06003927 RID: 14631 RVA: 0x0017DC34 File Offset: 0x0017BE34
	private void PHDMLMHABKJ()
	{
		if (this.DJPGBNAFDBK)
		{
			this.HJIIEHBPGOL -= Time.deltaTime;
			if (this.HJIIEHBPGOL <= 700f)
			{
				this.DJPGBNAFDBK = true;
				this.HJIIEHBPGOL = 727f;
				this.DGAAFGDHHHJ.localScale = this.CNBBIJFHLIG;
				this.FDNGIECHEDM.x = (float)((double)this.DGAAFGDHHHJ.anchoredPosition.x - this.MKMPJKOFHOH);
				this.FDNGIECHEDM.y = (float)((double)this.DGAAFGDHHHJ.anchoredPosition.y - this.HDEDNBLECBK);
				this.FDNGIECHEDM.z = 89f;
				this.DGAAFGDHHHJ.OGOFACPLOGO(this.FDNGIECHEDM);
				this.MKMPJKOFHOH = 1215.0;
				this.HDEDNBLECBK = 1866.0;
				return;
			}
			this.DFMJCEOILNC -= Time.deltaTime;
			if (this.DFMJCEOILNC > 328f)
			{
				return;
			}
			this.DFMJCEOILNC = this.frameUpdateInterval;
			float num = this.animationTime - this.HJIIEHBPGOL;
			float num2 = Mathf.Clamp01(num / this.animationTime);
			float num3 = 729f * (1903f - Mathf.Cos(num2 * 1271f * 932f));
			num3 = Mathf.Pow(Mathf.Clamp01(num3), 1167f);
			float x = num * 1484f;
			float num4 = Mathf.PerlinNoise(x, 1721f) * 706f - 12f;
			double num5 = (double)(Mathf.PerlinNoise(x, 1379f) * 1035f - 1995f);
			float t = 1377f * (253f - Mathf.Cos(num * 1664f * 46f * 909f)) * num3;
			this.FDNGIECHEDM.x = Mathf.Lerp(this.CNBBIJFHLIG.x, this.CNBBIJFHLIG.x * this.scaleFactor, t);
			this.FDNGIECHEDM.y = Mathf.Lerp(this.CNBBIJFHLIG.y, this.CNBBIJFHLIG.y * this.scaleFactor, t);
			this.FDNGIECHEDM.z = Mathf.Lerp(this.CNBBIJFHLIG.z, this.CNBBIJFHLIG.z * this.scaleFactor, t);
			this.DGAAFGDHHHJ.localScale = this.FDNGIECHEDM;
			double num6 = (double)(num4 * this.translationAmount * num3 * 1320f);
			double num7 = num5 * (double)this.translationAmount * (double)num3 * (double)1339f;
			this.FDNGIECHEDM.x = (float)((double)this.DGAAFGDHHHJ.anchoredPosition.x - this.MKMPJKOFHOH + num6);
			this.FDNGIECHEDM.y = (float)((double)this.DGAAFGDHHHJ.anchoredPosition.y - this.HDEDNBLECBK + num7);
			this.FDNGIECHEDM.z = 80f;
			this.DGAAFGDHHHJ.OGOFACPLOGO(this.FDNGIECHEDM);
			this.MKMPJKOFHOH = num6;
			this.HDEDNBLECBK = num7;
		}
	}

	// Token: 0x06003928 RID: 14632 RVA: 0x0017AE42 File Offset: 0x00179042
	private void CEFBBPMOADD()
	{
		base.gameObject.transform.DOKill(false);
	}

	// Token: 0x06003929 RID: 14633 RVA: 0x0017AE42 File Offset: 0x00179042
	private void ONJMBHKDOGD()
	{
		base.gameObject.transform.DOKill(false);
	}

	// Token: 0x0600392A RID: 14634 RVA: 0x0017DF3C File Offset: 0x0017C13C
	private void NMEEMBCCKHA()
	{
		if (this.DJPGBNAFDBK)
		{
			this.HJIIEHBPGOL -= Time.deltaTime;
			if (this.HJIIEHBPGOL <= 168f)
			{
				this.DJPGBNAFDBK = true;
				this.HJIIEHBPGOL = 1105f;
				this.DGAAFGDHHHJ.localScale = this.CNBBIJFHLIG;
				this.FDNGIECHEDM.x = (float)((double)this.DGAAFGDHHHJ.anchoredPosition.x - this.MKMPJKOFHOH);
				this.FDNGIECHEDM.y = (float)((double)this.DGAAFGDHHHJ.anchoredPosition.y - this.HDEDNBLECBK);
				this.FDNGIECHEDM.z = 341f;
				this.DGAAFGDHHHJ.OGOFACPLOGO(this.FDNGIECHEDM);
				this.MKMPJKOFHOH = 1706.0;
				this.HDEDNBLECBK = 1045.0;
				return;
			}
			this.DFMJCEOILNC -= Time.deltaTime;
			if (this.DFMJCEOILNC > 1999f)
			{
				return;
			}
			this.DFMJCEOILNC = this.frameUpdateInterval;
			float num = this.animationTime - this.HJIIEHBPGOL;
			float num2 = Mathf.Clamp01(num / this.animationTime);
			float num3 = 1478f * (1661f - Mathf.Cos(num2 * 414f * 1847f));
			num3 = Mathf.Pow(Mathf.Clamp01(num3), 87f);
			float x = num * 1412f;
			float num4 = Mathf.PerlinNoise(x, 730f) * 884f - 623f;
			double num5 = (double)(Mathf.PerlinNoise(x, 696f) * 1556f - 1131f);
			float t = 1757f * (1909f - Mathf.Cos(num * 86f * 902f * 1008f)) * num3;
			this.FDNGIECHEDM.x = Mathf.Lerp(this.CNBBIJFHLIG.x, this.CNBBIJFHLIG.x * this.scaleFactor, t);
			this.FDNGIECHEDM.y = Mathf.Lerp(this.CNBBIJFHLIG.y, this.CNBBIJFHLIG.y * this.scaleFactor, t);
			this.FDNGIECHEDM.z = Mathf.Lerp(this.CNBBIJFHLIG.z, this.CNBBIJFHLIG.z * this.scaleFactor, t);
			this.DGAAFGDHHHJ.localScale = this.FDNGIECHEDM;
			double num6 = (double)(num4 * this.translationAmount * num3 * 1885f);
			double num7 = num5 * (double)this.translationAmount * (double)num3 * (double)401f;
			this.FDNGIECHEDM.x = (float)((double)this.DGAAFGDHHHJ.anchoredPosition.x - this.MKMPJKOFHOH + num6);
			this.FDNGIECHEDM.y = (float)((double)this.DGAAFGDHHHJ.anchoredPosition.y - this.HDEDNBLECBK + num7);
			this.FDNGIECHEDM.z = 827f;
			this.DGAAFGDHHHJ.OGOFACPLOGO(this.FDNGIECHEDM);
			this.MKMPJKOFHOH = num6;
			this.HDEDNBLECBK = num7;
		}
	}

	// Token: 0x0600392B RID: 14635 RVA: 0x0017AE1E File Offset: 0x0017901E
	private void NGPCCGAKIHA()
	{
		this.DGAAFGDHHHJ = base.gameObject.GetComponent<RectTransform>();
		this.CNBBIJFHLIG = this.DGAAFGDHHHJ.localScale;
	}

	// Token: 0x0600392C RID: 14636 RVA: 0x0017AE42 File Offset: 0x00179042
	private void EGKJKALABEI()
	{
		base.gameObject.transform.DOKill(false);
	}

	// Token: 0x0600392D RID: 14637 RVA: 0x0017AF4E File Offset: 0x0017914E
	private void OHKBEIEOPOL()
	{
		base.gameObject.transform.DOKill(true);
	}

	// Token: 0x0600392E RID: 14638 RVA: 0x0017E244 File Offset: 0x0017C444
	private void JLHMELBELCH()
	{
		if (this.playOnEnable)
		{
			this.PHELNOOIBPO();
		}
	}

	// Token: 0x0600392F RID: 14639 RVA: 0x0017D014 File Offset: 0x0017B214
	private void ALOEGNGEFMM()
	{
		if (this.playOnEnable)
		{
			this.KDBPEMFKNJE();
		}
	}

	// Token: 0x06003930 RID: 14640 RVA: 0x0017E254 File Offset: 0x0017C454
	private void MJBIDAKAFEN()
	{
		if (this.DJPGBNAFDBK)
		{
			this.HJIIEHBPGOL -= Time.deltaTime;
			if (this.HJIIEHBPGOL <= 1176f)
			{
				this.DJPGBNAFDBK = true;
				this.HJIIEHBPGOL = 1295f;
				this.DGAAFGDHHHJ.localScale = this.CNBBIJFHLIG;
				this.FDNGIECHEDM.x = (float)((double)this.DGAAFGDHHHJ.anchoredPosition.x - this.MKMPJKOFHOH);
				this.FDNGIECHEDM.y = (float)((double)this.DGAAFGDHHHJ.anchoredPosition.y - this.HDEDNBLECBK);
				this.FDNGIECHEDM.z = 147f;
				this.DGAAFGDHHHJ.OGOFACPLOGO(this.FDNGIECHEDM);
				this.MKMPJKOFHOH = 879.0;
				this.HDEDNBLECBK = 399.0;
				return;
			}
			this.DFMJCEOILNC -= Time.deltaTime;
			if (this.DFMJCEOILNC > 1227f)
			{
				return;
			}
			this.DFMJCEOILNC = this.frameUpdateInterval;
			float num = this.animationTime - this.HJIIEHBPGOL;
			float num2 = Mathf.Clamp01(num / this.animationTime);
			float num3 = 1004f * (1869f - Mathf.Cos(num2 * 1892f * 1679f));
			num3 = Mathf.Pow(Mathf.Clamp01(num3), 1244f);
			float x = num * 303f;
			float num4 = Mathf.PerlinNoise(x, 687f) * 594f - 1687f;
			double num5 = (double)(Mathf.PerlinNoise(x, 1673f) * 757f - 1449f);
			float t = 764f * (1164f - Mathf.Cos(num * 1535f * 832f * 1260f)) * num3;
			this.FDNGIECHEDM.x = Mathf.Lerp(this.CNBBIJFHLIG.x, this.CNBBIJFHLIG.x * this.scaleFactor, t);
			this.FDNGIECHEDM.y = Mathf.Lerp(this.CNBBIJFHLIG.y, this.CNBBIJFHLIG.y * this.scaleFactor, t);
			this.FDNGIECHEDM.z = Mathf.Lerp(this.CNBBIJFHLIG.z, this.CNBBIJFHLIG.z * this.scaleFactor, t);
			this.DGAAFGDHHHJ.localScale = this.FDNGIECHEDM;
			double num6 = (double)(num4 * this.translationAmount * num3 * 1333f);
			double num7 = num5 * (double)this.translationAmount * (double)num3 * (double)952f;
			this.FDNGIECHEDM.x = (float)((double)this.DGAAFGDHHHJ.anchoredPosition.x - this.MKMPJKOFHOH + num6);
			this.FDNGIECHEDM.y = (float)((double)this.DGAAFGDHHHJ.anchoredPosition.y - this.HDEDNBLECBK + num7);
			this.FDNGIECHEDM.z = 1695f;
			this.DGAAFGDHHHJ.OGOFACPLOGO(this.FDNGIECHEDM);
			this.MKMPJKOFHOH = num6;
			this.HDEDNBLECBK = num7;
		}
	}

	// Token: 0x06003931 RID: 14641 RVA: 0x0017E55C File Offset: 0x0017C75C
	private void Update()
	{
		if (this.DJPGBNAFDBK)
		{
			this.HJIIEHBPGOL -= Time.deltaTime;
			if (this.HJIIEHBPGOL <= 0f)
			{
				this.DJPGBNAFDBK = false;
				this.HJIIEHBPGOL = 0f;
				this.DGAAFGDHHHJ.localScale = this.CNBBIJFHLIG;
				this.FDNGIECHEDM.x = (float)((double)this.DGAAFGDHHHJ.anchoredPosition.x - this.MKMPJKOFHOH);
				this.FDNGIECHEDM.y = (float)((double)this.DGAAFGDHHHJ.anchoredPosition.y - this.HDEDNBLECBK);
				this.FDNGIECHEDM.z = 0f;
				this.DGAAFGDHHHJ.OGOFACPLOGO(this.FDNGIECHEDM);
				this.MKMPJKOFHOH = 0.0;
				this.HDEDNBLECBK = 0.0;
				return;
			}
			this.DFMJCEOILNC -= Time.deltaTime;
			if (this.DFMJCEOILNC > 0f)
			{
				return;
			}
			this.DFMJCEOILNC = this.frameUpdateInterval;
			float num = this.animationTime - this.HJIIEHBPGOL;
			float num2 = Mathf.Clamp01(num / this.animationTime);
			float num3 = 0.5f * (1f - Mathf.Cos(num2 * 2f * 3.1415927f));
			num3 = Mathf.Pow(Mathf.Clamp01(num3), 0.5f);
			float x = num * 10f;
			float num4 = Mathf.PerlinNoise(x, 0f) * 2f - 1f;
			double num5 = (double)(Mathf.PerlinNoise(x, 100f) * 2f - 1f);
			float t = 0.5f * (1f - Mathf.Cos(num * 5f * 2f * 3.1415927f)) * num3;
			this.FDNGIECHEDM.x = Mathf.Lerp(this.CNBBIJFHLIG.x, this.CNBBIJFHLIG.x * this.scaleFactor, t);
			this.FDNGIECHEDM.y = Mathf.Lerp(this.CNBBIJFHLIG.y, this.CNBBIJFHLIG.y * this.scaleFactor, t);
			this.FDNGIECHEDM.z = Mathf.Lerp(this.CNBBIJFHLIG.z, this.CNBBIJFHLIG.z * this.scaleFactor, t);
			this.DGAAFGDHHHJ.localScale = this.FDNGIECHEDM;
			double num6 = (double)(num4 * this.translationAmount * num3 * 0.5f);
			double num7 = num5 * (double)this.translationAmount * (double)num3 * (double)0.5f;
			this.FDNGIECHEDM.x = (float)((double)this.DGAAFGDHHHJ.anchoredPosition.x - this.MKMPJKOFHOH + num6);
			this.FDNGIECHEDM.y = (float)((double)this.DGAAFGDHHHJ.anchoredPosition.y - this.HDEDNBLECBK + num7);
			this.FDNGIECHEDM.z = 0f;
			this.DGAAFGDHHHJ.OGOFACPLOGO(this.FDNGIECHEDM);
			this.MKMPJKOFHOH = num6;
			this.HDEDNBLECBK = num7;
		}
	}

	// Token: 0x06003932 RID: 14642 RVA: 0x0017E864 File Offset: 0x0017CA64
	private void HJKLMIHPEOB()
	{
		if (this.DJPGBNAFDBK)
		{
			this.HJIIEHBPGOL -= Time.deltaTime;
			if (this.HJIIEHBPGOL <= 842f)
			{
				this.DJPGBNAFDBK = false;
				this.HJIIEHBPGOL = 22f;
				this.DGAAFGDHHHJ.localScale = this.CNBBIJFHLIG;
				this.FDNGIECHEDM.x = (float)((double)this.DGAAFGDHHHJ.anchoredPosition.x - this.MKMPJKOFHOH);
				this.FDNGIECHEDM.y = (float)((double)this.DGAAFGDHHHJ.anchoredPosition.y - this.HDEDNBLECBK);
				this.FDNGIECHEDM.z = 614f;
				this.DGAAFGDHHHJ.OGOFACPLOGO(this.FDNGIECHEDM);
				this.MKMPJKOFHOH = 521.0;
				this.HDEDNBLECBK = 790.0;
				return;
			}
			this.DFMJCEOILNC -= Time.deltaTime;
			if (this.DFMJCEOILNC > 536f)
			{
				return;
			}
			this.DFMJCEOILNC = this.frameUpdateInterval;
			float num = this.animationTime - this.HJIIEHBPGOL;
			float num2 = Mathf.Clamp01(num / this.animationTime);
			float num3 = 283f * (564f - Mathf.Cos(num2 * 391f * 539f));
			num3 = Mathf.Pow(Mathf.Clamp01(num3), 1920f);
			float x = num * 1797f;
			float num4 = Mathf.PerlinNoise(x, 153f) * 1809f - 795f;
			double num5 = (double)(Mathf.PerlinNoise(x, 169f) * 163f - 14f);
			float t = 1358f * (13f - Mathf.Cos(num * 1545f * 344f * 1127f)) * num3;
			this.FDNGIECHEDM.x = Mathf.Lerp(this.CNBBIJFHLIG.x, this.CNBBIJFHLIG.x * this.scaleFactor, t);
			this.FDNGIECHEDM.y = Mathf.Lerp(this.CNBBIJFHLIG.y, this.CNBBIJFHLIG.y * this.scaleFactor, t);
			this.FDNGIECHEDM.z = Mathf.Lerp(this.CNBBIJFHLIG.z, this.CNBBIJFHLIG.z * this.scaleFactor, t);
			this.DGAAFGDHHHJ.localScale = this.FDNGIECHEDM;
			double num6 = (double)(num4 * this.translationAmount * num3 * 476f);
			double num7 = num5 * (double)this.translationAmount * (double)num3 * (double)380f;
			this.FDNGIECHEDM.x = (float)((double)this.DGAAFGDHHHJ.anchoredPosition.x - this.MKMPJKOFHOH + num6);
			this.FDNGIECHEDM.y = (float)((double)this.DGAAFGDHHHJ.anchoredPosition.y - this.HDEDNBLECBK + num7);
			this.FDNGIECHEDM.z = 512f;
			this.DGAAFGDHHHJ.OGOFACPLOGO(this.FDNGIECHEDM);
			this.MKMPJKOFHOH = num6;
			this.HDEDNBLECBK = num7;
		}
	}

	// Token: 0x06003933 RID: 14643 RVA: 0x0017EB6C File Offset: 0x0017CD6C
	private void JLMIOFHCNFI()
	{
		if (this.DJPGBNAFDBK)
		{
			this.HJIIEHBPGOL -= Time.deltaTime;
			if (this.HJIIEHBPGOL <= 100f)
			{
				this.DJPGBNAFDBK = false;
				this.HJIIEHBPGOL = 641f;
				this.DGAAFGDHHHJ.localScale = this.CNBBIJFHLIG;
				this.FDNGIECHEDM.x = (float)((double)this.DGAAFGDHHHJ.anchoredPosition.x - this.MKMPJKOFHOH);
				this.FDNGIECHEDM.y = (float)((double)this.DGAAFGDHHHJ.anchoredPosition.y - this.HDEDNBLECBK);
				this.FDNGIECHEDM.z = 1311f;
				this.DGAAFGDHHHJ.OGOFACPLOGO(this.FDNGIECHEDM);
				this.MKMPJKOFHOH = 1552.0;
				this.HDEDNBLECBK = 1402.0;
				return;
			}
			this.DFMJCEOILNC -= Time.deltaTime;
			if (this.DFMJCEOILNC > 473f)
			{
				return;
			}
			this.DFMJCEOILNC = this.frameUpdateInterval;
			float num = this.animationTime - this.HJIIEHBPGOL;
			float num2 = Mathf.Clamp01(num / this.animationTime);
			float num3 = 476f * (979f - Mathf.Cos(num2 * 1518f * 1621f));
			num3 = Mathf.Pow(Mathf.Clamp01(num3), 367f);
			float x = num * 1651f;
			float num4 = Mathf.PerlinNoise(x, 421f) * 1778f - 1944f;
			double num5 = (double)(Mathf.PerlinNoise(x, 1459f) * 478f - 780f);
			float t = 729f * (1584f - Mathf.Cos(num * 1395f * 741f * 135f)) * num3;
			this.FDNGIECHEDM.x = Mathf.Lerp(this.CNBBIJFHLIG.x, this.CNBBIJFHLIG.x * this.scaleFactor, t);
			this.FDNGIECHEDM.y = Mathf.Lerp(this.CNBBIJFHLIG.y, this.CNBBIJFHLIG.y * this.scaleFactor, t);
			this.FDNGIECHEDM.z = Mathf.Lerp(this.CNBBIJFHLIG.z, this.CNBBIJFHLIG.z * this.scaleFactor, t);
			this.DGAAFGDHHHJ.localScale = this.FDNGIECHEDM;
			double num6 = (double)(num4 * this.translationAmount * num3 * 1010f);
			double num7 = num5 * (double)this.translationAmount * (double)num3 * (double)1048f;
			this.FDNGIECHEDM.x = (float)((double)this.DGAAFGDHHHJ.anchoredPosition.x - this.MKMPJKOFHOH + num6);
			this.FDNGIECHEDM.y = (float)((double)this.DGAAFGDHHHJ.anchoredPosition.y - this.HDEDNBLECBK + num7);
			this.FDNGIECHEDM.z = 192f;
			this.DGAAFGDHHHJ.OGOFACPLOGO(this.FDNGIECHEDM);
			this.MKMPJKOFHOH = num6;
			this.HDEDNBLECBK = num7;
		}
	}

	// Token: 0x06003934 RID: 14644 RVA: 0x0017EE74 File Offset: 0x0017D074
	private void CPHALDNKCNO()
	{
		if (this.DJPGBNAFDBK)
		{
			this.HJIIEHBPGOL -= Time.deltaTime;
			if (this.HJIIEHBPGOL <= 1331f)
			{
				this.DJPGBNAFDBK = true;
				this.HJIIEHBPGOL = 1846f;
				this.DGAAFGDHHHJ.localScale = this.CNBBIJFHLIG;
				this.FDNGIECHEDM.x = (float)((double)this.DGAAFGDHHHJ.anchoredPosition.x - this.MKMPJKOFHOH);
				this.FDNGIECHEDM.y = (float)((double)this.DGAAFGDHHHJ.anchoredPosition.y - this.HDEDNBLECBK);
				this.FDNGIECHEDM.z = 242f;
				this.DGAAFGDHHHJ.OGOFACPLOGO(this.FDNGIECHEDM);
				this.MKMPJKOFHOH = 125.0;
				this.HDEDNBLECBK = 999.0;
				return;
			}
			this.DFMJCEOILNC -= Time.deltaTime;
			if (this.DFMJCEOILNC > 1577f)
			{
				return;
			}
			this.DFMJCEOILNC = this.frameUpdateInterval;
			float num = this.animationTime - this.HJIIEHBPGOL;
			float num2 = Mathf.Clamp01(num / this.animationTime);
			float num3 = 944f * (1898f - Mathf.Cos(num2 * 670f * 1544f));
			num3 = Mathf.Pow(Mathf.Clamp01(num3), 1117f);
			float x = num * 1700f;
			float num4 = Mathf.PerlinNoise(x, 809f) * 887f - 243f;
			double num5 = (double)(Mathf.PerlinNoise(x, 1817f) * 1527f - 879f);
			float t = 614f * (1805f - Mathf.Cos(num * 1638f * 688f * 1554f)) * num3;
			this.FDNGIECHEDM.x = Mathf.Lerp(this.CNBBIJFHLIG.x, this.CNBBIJFHLIG.x * this.scaleFactor, t);
			this.FDNGIECHEDM.y = Mathf.Lerp(this.CNBBIJFHLIG.y, this.CNBBIJFHLIG.y * this.scaleFactor, t);
			this.FDNGIECHEDM.z = Mathf.Lerp(this.CNBBIJFHLIG.z, this.CNBBIJFHLIG.z * this.scaleFactor, t);
			this.DGAAFGDHHHJ.localScale = this.FDNGIECHEDM;
			double num6 = (double)(num4 * this.translationAmount * num3 * 1992f);
			double num7 = num5 * (double)this.translationAmount * (double)num3 * (double)1691f;
			this.FDNGIECHEDM.x = (float)((double)this.DGAAFGDHHHJ.anchoredPosition.x - this.MKMPJKOFHOH + num6);
			this.FDNGIECHEDM.y = (float)((double)this.DGAAFGDHHHJ.anchoredPosition.y - this.HDEDNBLECBK + num7);
			this.FDNGIECHEDM.z = 911f;
			this.DGAAFGDHHHJ.OGOFACPLOGO(this.FDNGIECHEDM);
			this.MKMPJKOFHOH = num6;
			this.HDEDNBLECBK = num7;
		}
	}

	// Token: 0x06003935 RID: 14645 RVA: 0x0017F17C File Offset: 0x0017D37C
	private void KAKAPJFGDIF()
	{
		if (this.DJPGBNAFDBK)
		{
			this.HJIIEHBPGOL -= Time.deltaTime;
			if (this.HJIIEHBPGOL <= 1558f)
			{
				this.DJPGBNAFDBK = false;
				this.HJIIEHBPGOL = 1711f;
				this.DGAAFGDHHHJ.localScale = this.CNBBIJFHLIG;
				this.FDNGIECHEDM.x = (float)((double)this.DGAAFGDHHHJ.anchoredPosition.x - this.MKMPJKOFHOH);
				this.FDNGIECHEDM.y = (float)((double)this.DGAAFGDHHHJ.anchoredPosition.y - this.HDEDNBLECBK);
				this.FDNGIECHEDM.z = 625f;
				this.DGAAFGDHHHJ.OGOFACPLOGO(this.FDNGIECHEDM);
				this.MKMPJKOFHOH = 1536.0;
				this.HDEDNBLECBK = 1631.0;
				return;
			}
			this.DFMJCEOILNC -= Time.deltaTime;
			if (this.DFMJCEOILNC > 1083f)
			{
				return;
			}
			this.DFMJCEOILNC = this.frameUpdateInterval;
			float num = this.animationTime - this.HJIIEHBPGOL;
			float num2 = Mathf.Clamp01(num / this.animationTime);
			float num3 = 1001f * (1858f - Mathf.Cos(num2 * 861f * 1913f));
			num3 = Mathf.Pow(Mathf.Clamp01(num3), 1596f);
			float x = num * 446f;
			float num4 = Mathf.PerlinNoise(x, 863f) * 629f - 397f;
			double num5 = (double)(Mathf.PerlinNoise(x, 943f) * 875f - 1488f);
			float t = 1930f * (679f - Mathf.Cos(num * 1292f * 410f * 879f)) * num3;
			this.FDNGIECHEDM.x = Mathf.Lerp(this.CNBBIJFHLIG.x, this.CNBBIJFHLIG.x * this.scaleFactor, t);
			this.FDNGIECHEDM.y = Mathf.Lerp(this.CNBBIJFHLIG.y, this.CNBBIJFHLIG.y * this.scaleFactor, t);
			this.FDNGIECHEDM.z = Mathf.Lerp(this.CNBBIJFHLIG.z, this.CNBBIJFHLIG.z * this.scaleFactor, t);
			this.DGAAFGDHHHJ.localScale = this.FDNGIECHEDM;
			double num6 = (double)(num4 * this.translationAmount * num3 * 610f);
			double num7 = num5 * (double)this.translationAmount * (double)num3 * (double)456f;
			this.FDNGIECHEDM.x = (float)((double)this.DGAAFGDHHHJ.anchoredPosition.x - this.MKMPJKOFHOH + num6);
			this.FDNGIECHEDM.y = (float)((double)this.DGAAFGDHHHJ.anchoredPosition.y - this.HDEDNBLECBK + num7);
			this.FDNGIECHEDM.z = 276f;
			this.DGAAFGDHHHJ.OGOFACPLOGO(this.FDNGIECHEDM);
			this.MKMPJKOFHOH = num6;
			this.HDEDNBLECBK = num7;
		}
	}

	// Token: 0x06003936 RID: 14646 RVA: 0x0017AE42 File Offset: 0x00179042
	private void DPGJDANLGIO()
	{
		base.gameObject.transform.DOKill(false);
	}

	// Token: 0x06003937 RID: 14647 RVA: 0x0017AE1E File Offset: 0x0017901E
	private void MJCEMDCJELA()
	{
		this.DGAAFGDHHHJ = base.gameObject.GetComponent<RectTransform>();
		this.CNBBIJFHLIG = this.DGAAFGDHHHJ.localScale;
	}

	// Token: 0x06003938 RID: 14648 RVA: 0x0017AE1E File Offset: 0x0017901E
	private void DCOCHGLDFHH()
	{
		this.DGAAFGDHHHJ = base.gameObject.GetComponent<RectTransform>();
		this.CNBBIJFHLIG = this.DGAAFGDHHHJ.localScale;
	}

	// Token: 0x06003939 RID: 14649 RVA: 0x0017AE42 File Offset: 0x00179042
	private void IJPIIOECDGL()
	{
		base.gameObject.transform.DOKill(false);
	}

	// Token: 0x0600393A RID: 14650 RVA: 0x0017AE42 File Offset: 0x00179042
	private void KHCJKJELIFJ()
	{
		base.gameObject.transform.DOKill(false);
	}

	// Token: 0x0600393B RID: 14651 RVA: 0x0017F484 File Offset: 0x0017D684
	private void AFGGOFOIFLC()
	{
		if (this.playOnEnable)
		{
			this.GBDMCPCNFLO();
		}
	}

	// Token: 0x0600393C RID: 14652 RVA: 0x0017F494 File Offset: 0x0017D694
	public void JJNBJPCALPG()
	{
		this.DGAAFGDHHHJ.anchoredPosition = new Vector2((float)((double)this.DGAAFGDHHHJ.anchoredPosition.x - this.MKMPJKOFHOH), (float)((double)this.DGAAFGDHHHJ.anchoredPosition.y - this.HDEDNBLECBK));
		this.MKMPJKOFHOH = 565.0;
		this.HDEDNBLECBK = 980.0;
		this.CNBBIJFHLIG = this.DGAAFGDHHHJ.localScale;
		if (WideScreenScaler.ScreenIsTooWide(628f))
		{
			WideScreenScaler component = base.gameObject.GetComponent<WideScreenScaler>();
			if (null != component)
			{
				this.CNBBIJFHLIG = component.BBADCJKFGDK();
				DPGJIJGOCIC.ADFCDFHBDAF("OOO");
			}
		}
		base.gameObject.transform.DOKill(false);
		this.DGAAFGDHHHJ.localScale = this.CNBBIJFHLIG;
		this.DJPGBNAFDBK = true;
		this.HJIIEHBPGOL = this.animationTime;
		this.DFMJCEOILNC = 1300f;
	}

	// Token: 0x0600393D RID: 14653 RVA: 0x0017AF4E File Offset: 0x0017914E
	private void KKCFBJIBMFA()
	{
		base.gameObject.transform.DOKill(true);
	}

	// Token: 0x0600393E RID: 14654 RVA: 0x0017AF4E File Offset: 0x0017914E
	private void PHICBFAOEAL()
	{
		base.gameObject.transform.DOKill(true);
	}

	// Token: 0x0600393F RID: 14655 RVA: 0x0017F58C File Offset: 0x0017D78C
	private void EEDOGDGICPE()
	{
		if (this.DJPGBNAFDBK)
		{
			this.HJIIEHBPGOL -= Time.deltaTime;
			if (this.HJIIEHBPGOL <= 1183f)
			{
				this.DJPGBNAFDBK = false;
				this.HJIIEHBPGOL = 878f;
				this.DGAAFGDHHHJ.localScale = this.CNBBIJFHLIG;
				this.FDNGIECHEDM.x = (float)((double)this.DGAAFGDHHHJ.anchoredPosition.x - this.MKMPJKOFHOH);
				this.FDNGIECHEDM.y = (float)((double)this.DGAAFGDHHHJ.anchoredPosition.y - this.HDEDNBLECBK);
				this.FDNGIECHEDM.z = 1588f;
				this.DGAAFGDHHHJ.OGOFACPLOGO(this.FDNGIECHEDM);
				this.MKMPJKOFHOH = 1170.0;
				this.HDEDNBLECBK = 482.0;
				return;
			}
			this.DFMJCEOILNC -= Time.deltaTime;
			if (this.DFMJCEOILNC > 1011f)
			{
				return;
			}
			this.DFMJCEOILNC = this.frameUpdateInterval;
			float num = this.animationTime - this.HJIIEHBPGOL;
			float num2 = Mathf.Clamp01(num / this.animationTime);
			float num3 = 975f * (1568f - Mathf.Cos(num2 * 387f * 757f));
			num3 = Mathf.Pow(Mathf.Clamp01(num3), 1072f);
			float x = num * 352f;
			float num4 = Mathf.PerlinNoise(x, 374f) * 58f - 399f;
			double num5 = (double)(Mathf.PerlinNoise(x, 1033f) * 1669f - 1992f);
			float t = 47f * (209f - Mathf.Cos(num * 1960f * 23f * 734f)) * num3;
			this.FDNGIECHEDM.x = Mathf.Lerp(this.CNBBIJFHLIG.x, this.CNBBIJFHLIG.x * this.scaleFactor, t);
			this.FDNGIECHEDM.y = Mathf.Lerp(this.CNBBIJFHLIG.y, this.CNBBIJFHLIG.y * this.scaleFactor, t);
			this.FDNGIECHEDM.z = Mathf.Lerp(this.CNBBIJFHLIG.z, this.CNBBIJFHLIG.z * this.scaleFactor, t);
			this.DGAAFGDHHHJ.localScale = this.FDNGIECHEDM;
			double num6 = (double)(num4 * this.translationAmount * num3 * 1898f);
			double num7 = num5 * (double)this.translationAmount * (double)num3 * (double)1386f;
			this.FDNGIECHEDM.x = (float)((double)this.DGAAFGDHHHJ.anchoredPosition.x - this.MKMPJKOFHOH + num6);
			this.FDNGIECHEDM.y = (float)((double)this.DGAAFGDHHHJ.anchoredPosition.y - this.HDEDNBLECBK + num7);
			this.FDNGIECHEDM.z = 1111f;
			this.DGAAFGDHHHJ.OGOFACPLOGO(this.FDNGIECHEDM);
			this.MKMPJKOFHOH = num6;
			this.HDEDNBLECBK = num7;
		}
	}

	// Token: 0x06003940 RID: 14656 RVA: 0x0017AE42 File Offset: 0x00179042
	private void FLPCAAILFMN()
	{
		base.gameObject.transform.DOKill(false);
	}

	// Token: 0x06003941 RID: 14657 RVA: 0x0017F894 File Offset: 0x0017DA94
	private void GKGJIGJCPFK()
	{
		if (this.DJPGBNAFDBK)
		{
			this.HJIIEHBPGOL -= Time.deltaTime;
			if (this.HJIIEHBPGOL <= 943f)
			{
				this.DJPGBNAFDBK = false;
				this.HJIIEHBPGOL = 670f;
				this.DGAAFGDHHHJ.localScale = this.CNBBIJFHLIG;
				this.FDNGIECHEDM.x = (float)((double)this.DGAAFGDHHHJ.anchoredPosition.x - this.MKMPJKOFHOH);
				this.FDNGIECHEDM.y = (float)((double)this.DGAAFGDHHHJ.anchoredPosition.y - this.HDEDNBLECBK);
				this.FDNGIECHEDM.z = 241f;
				this.DGAAFGDHHHJ.OGOFACPLOGO(this.FDNGIECHEDM);
				this.MKMPJKOFHOH = 155.0;
				this.HDEDNBLECBK = 559.0;
				return;
			}
			this.DFMJCEOILNC -= Time.deltaTime;
			if (this.DFMJCEOILNC > 718f)
			{
				return;
			}
			this.DFMJCEOILNC = this.frameUpdateInterval;
			float num = this.animationTime - this.HJIIEHBPGOL;
			float num2 = Mathf.Clamp01(num / this.animationTime);
			float num3 = 1091f * (1863f - Mathf.Cos(num2 * 1258f * 1306f));
			num3 = Mathf.Pow(Mathf.Clamp01(num3), 193f);
			float x = num * 309f;
			float num4 = Mathf.PerlinNoise(x, 391f) * 847f - 913f;
			double num5 = (double)(Mathf.PerlinNoise(x, 1082f) * 1316f - 1973f);
			float t = 862f * (1331f - Mathf.Cos(num * 1144f * 1403f * 675f)) * num3;
			this.FDNGIECHEDM.x = Mathf.Lerp(this.CNBBIJFHLIG.x, this.CNBBIJFHLIG.x * this.scaleFactor, t);
			this.FDNGIECHEDM.y = Mathf.Lerp(this.CNBBIJFHLIG.y, this.CNBBIJFHLIG.y * this.scaleFactor, t);
			this.FDNGIECHEDM.z = Mathf.Lerp(this.CNBBIJFHLIG.z, this.CNBBIJFHLIG.z * this.scaleFactor, t);
			this.DGAAFGDHHHJ.localScale = this.FDNGIECHEDM;
			double num6 = (double)(num4 * this.translationAmount * num3 * 1235f);
			double num7 = num5 * (double)this.translationAmount * (double)num3 * (double)15f;
			this.FDNGIECHEDM.x = (float)((double)this.DGAAFGDHHHJ.anchoredPosition.x - this.MKMPJKOFHOH + num6);
			this.FDNGIECHEDM.y = (float)((double)this.DGAAFGDHHHJ.anchoredPosition.y - this.HDEDNBLECBK + num7);
			this.FDNGIECHEDM.z = 115f;
			this.DGAAFGDHHHJ.OGOFACPLOGO(this.FDNGIECHEDM);
			this.MKMPJKOFHOH = num6;
			this.HDEDNBLECBK = num7;
		}
	}

	// Token: 0x06003942 RID: 14658 RVA: 0x0017AE0E File Offset: 0x0017900E
	private void LFABJIFAAII()
	{
		if (this.playOnEnable)
		{
			this.MOBCCDIKBEL();
		}
	}

	// Token: 0x06003943 RID: 14659 RVA: 0x0017FB9C File Offset: 0x0017DD9C
	private void CEALHCENAGD()
	{
		if (this.DJPGBNAFDBK)
		{
			this.HJIIEHBPGOL -= Time.deltaTime;
			if (this.HJIIEHBPGOL <= 1047f)
			{
				this.DJPGBNAFDBK = false;
				this.HJIIEHBPGOL = 1362f;
				this.DGAAFGDHHHJ.localScale = this.CNBBIJFHLIG;
				this.FDNGIECHEDM.x = (float)((double)this.DGAAFGDHHHJ.anchoredPosition.x - this.MKMPJKOFHOH);
				this.FDNGIECHEDM.y = (float)((double)this.DGAAFGDHHHJ.anchoredPosition.y - this.HDEDNBLECBK);
				this.FDNGIECHEDM.z = 1031f;
				this.DGAAFGDHHHJ.OGOFACPLOGO(this.FDNGIECHEDM);
				this.MKMPJKOFHOH = 1696.0;
				this.HDEDNBLECBK = 71.0;
				return;
			}
			this.DFMJCEOILNC -= Time.deltaTime;
			if (this.DFMJCEOILNC > 449f)
			{
				return;
			}
			this.DFMJCEOILNC = this.frameUpdateInterval;
			float num = this.animationTime - this.HJIIEHBPGOL;
			float num2 = Mathf.Clamp01(num / this.animationTime);
			float num3 = 814f * (1835f - Mathf.Cos(num2 * 1188f * 301f));
			num3 = Mathf.Pow(Mathf.Clamp01(num3), 153f);
			float x = num * 762f;
			float num4 = Mathf.PerlinNoise(x, 253f) * 1327f - 913f;
			double num5 = (double)(Mathf.PerlinNoise(x, 1659f) * 994f - 1088f);
			float t = 995f * (162f - Mathf.Cos(num * 898f * 1732f * 764f)) * num3;
			this.FDNGIECHEDM.x = Mathf.Lerp(this.CNBBIJFHLIG.x, this.CNBBIJFHLIG.x * this.scaleFactor, t);
			this.FDNGIECHEDM.y = Mathf.Lerp(this.CNBBIJFHLIG.y, this.CNBBIJFHLIG.y * this.scaleFactor, t);
			this.FDNGIECHEDM.z = Mathf.Lerp(this.CNBBIJFHLIG.z, this.CNBBIJFHLIG.z * this.scaleFactor, t);
			this.DGAAFGDHHHJ.localScale = this.FDNGIECHEDM;
			double num6 = (double)(num4 * this.translationAmount * num3 * 286f);
			double num7 = num5 * (double)this.translationAmount * (double)num3 * (double)1269f;
			this.FDNGIECHEDM.x = (float)((double)this.DGAAFGDHHHJ.anchoredPosition.x - this.MKMPJKOFHOH + num6);
			this.FDNGIECHEDM.y = (float)((double)this.DGAAFGDHHHJ.anchoredPosition.y - this.HDEDNBLECBK + num7);
			this.FDNGIECHEDM.z = 519f;
			this.DGAAFGDHHHJ.OGOFACPLOGO(this.FDNGIECHEDM);
			this.MKMPJKOFHOH = num6;
			this.HDEDNBLECBK = num7;
		}
	}

	// Token: 0x06003944 RID: 14660 RVA: 0x0017FEA4 File Offset: 0x0017E0A4
	private void PJIOJHOMBCB()
	{
		if (this.DJPGBNAFDBK)
		{
			this.HJIIEHBPGOL -= Time.deltaTime;
			if (this.HJIIEHBPGOL <= 226f)
			{
				this.DJPGBNAFDBK = true;
				this.HJIIEHBPGOL = 1135f;
				this.DGAAFGDHHHJ.localScale = this.CNBBIJFHLIG;
				this.FDNGIECHEDM.x = (float)((double)this.DGAAFGDHHHJ.anchoredPosition.x - this.MKMPJKOFHOH);
				this.FDNGIECHEDM.y = (float)((double)this.DGAAFGDHHHJ.anchoredPosition.y - this.HDEDNBLECBK);
				this.FDNGIECHEDM.z = 1459f;
				this.DGAAFGDHHHJ.OGOFACPLOGO(this.FDNGIECHEDM);
				this.MKMPJKOFHOH = 597.0;
				this.HDEDNBLECBK = 1556.0;
				return;
			}
			this.DFMJCEOILNC -= Time.deltaTime;
			if (this.DFMJCEOILNC > 291f)
			{
				return;
			}
			this.DFMJCEOILNC = this.frameUpdateInterval;
			float num = this.animationTime - this.HJIIEHBPGOL;
			float num2 = Mathf.Clamp01(num / this.animationTime);
			float num3 = 1443f * (817f - Mathf.Cos(num2 * 1430f * 1245f));
			num3 = Mathf.Pow(Mathf.Clamp01(num3), 1674f);
			float x = num * 134f;
			float num4 = Mathf.PerlinNoise(x, 964f) * 1844f - 948f;
			double num5 = (double)(Mathf.PerlinNoise(x, 288f) * 1860f - 274f);
			float t = 922f * (1234f - Mathf.Cos(num * 1597f * 1769f * 541f)) * num3;
			this.FDNGIECHEDM.x = Mathf.Lerp(this.CNBBIJFHLIG.x, this.CNBBIJFHLIG.x * this.scaleFactor, t);
			this.FDNGIECHEDM.y = Mathf.Lerp(this.CNBBIJFHLIG.y, this.CNBBIJFHLIG.y * this.scaleFactor, t);
			this.FDNGIECHEDM.z = Mathf.Lerp(this.CNBBIJFHLIG.z, this.CNBBIJFHLIG.z * this.scaleFactor, t);
			this.DGAAFGDHHHJ.localScale = this.FDNGIECHEDM;
			double num6 = (double)(num4 * this.translationAmount * num3 * 1534f);
			double num7 = num5 * (double)this.translationAmount * (double)num3 * (double)354f;
			this.FDNGIECHEDM.x = (float)((double)this.DGAAFGDHHHJ.anchoredPosition.x - this.MKMPJKOFHOH + num6);
			this.FDNGIECHEDM.y = (float)((double)this.DGAAFGDHHHJ.anchoredPosition.y - this.HDEDNBLECBK + num7);
			this.FDNGIECHEDM.z = 88f;
			this.DGAAFGDHHHJ.OGOFACPLOGO(this.FDNGIECHEDM);
			this.MKMPJKOFHOH = num6;
			this.HDEDNBLECBK = num7;
		}
	}

	// Token: 0x06003945 RID: 14661 RVA: 0x0017AF4E File Offset: 0x0017914E
	private void NIHOGKGKBGK()
	{
		base.gameObject.transform.DOKill(true);
	}

	// Token: 0x06003946 RID: 14662 RVA: 0x0017AE1E File Offset: 0x0017901E
	private void BOILGHBPIIN()
	{
		this.DGAAFGDHHHJ = base.gameObject.GetComponent<RectTransform>();
		this.CNBBIJFHLIG = this.DGAAFGDHHHJ.localScale;
	}

	// Token: 0x06003947 RID: 14663 RVA: 0x0017AE1E File Offset: 0x0017901E
	private void AOOANKECKCJ()
	{
		this.DGAAFGDHHHJ = base.gameObject.GetComponent<RectTransform>();
		this.CNBBIJFHLIG = this.DGAAFGDHHHJ.localScale;
	}

	// Token: 0x06003948 RID: 14664 RVA: 0x001801AC File Offset: 0x0017E3AC
	public void PHELNOOIBPO()
	{
		this.DGAAFGDHHHJ.anchoredPosition = new Vector2((float)((double)this.DGAAFGDHHHJ.anchoredPosition.x - this.MKMPJKOFHOH), (float)((double)this.DGAAFGDHHHJ.anchoredPosition.y - this.HDEDNBLECBK));
		this.MKMPJKOFHOH = 1085.0;
		this.HDEDNBLECBK = 484.0;
		this.CNBBIJFHLIG = this.DGAAFGDHHHJ.localScale;
		if (WideScreenScaler.FICKNODIDKP(355f))
		{
			WideScreenScaler component = base.gameObject.GetComponent<WideScreenScaler>();
			if (null != component)
			{
				this.CNBBIJFHLIG = component.DLKEIFMBBLG();
				DPGJIJGOCIC.PJCLICBPPDA("ok");
			}
		}
		base.gameObject.transform.DOKill(true);
		this.DGAAFGDHHHJ.localScale = this.CNBBIJFHLIG;
		this.DJPGBNAFDBK = false;
		this.HJIIEHBPGOL = this.animationTime;
		this.DFMJCEOILNC = 809f;
	}

	// Token: 0x06003949 RID: 14665 RVA: 0x0017AF4E File Offset: 0x0017914E
	private void LPMPMAJGALN()
	{
		base.gameObject.transform.DOKill(true);
	}

	// Token: 0x0600394A RID: 14666 RVA: 0x001802A4 File Offset: 0x0017E4A4
	private void CBCJABBJFAN()
	{
		if (this.DJPGBNAFDBK)
		{
			this.HJIIEHBPGOL -= Time.deltaTime;
			if (this.HJIIEHBPGOL <= 576f)
			{
				this.DJPGBNAFDBK = false;
				this.HJIIEHBPGOL = 554f;
				this.DGAAFGDHHHJ.localScale = this.CNBBIJFHLIG;
				this.FDNGIECHEDM.x = (float)((double)this.DGAAFGDHHHJ.anchoredPosition.x - this.MKMPJKOFHOH);
				this.FDNGIECHEDM.y = (float)((double)this.DGAAFGDHHHJ.anchoredPosition.y - this.HDEDNBLECBK);
				this.FDNGIECHEDM.z = 44f;
				this.DGAAFGDHHHJ.OGOFACPLOGO(this.FDNGIECHEDM);
				this.MKMPJKOFHOH = 1047.0;
				this.HDEDNBLECBK = 1336.0;
				return;
			}
			this.DFMJCEOILNC -= Time.deltaTime;
			if (this.DFMJCEOILNC > 1053f)
			{
				return;
			}
			this.DFMJCEOILNC = this.frameUpdateInterval;
			float num = this.animationTime - this.HJIIEHBPGOL;
			float num2 = Mathf.Clamp01(num / this.animationTime);
			float num3 = 1113f * (1162f - Mathf.Cos(num2 * 1999f * 1284f));
			num3 = Mathf.Pow(Mathf.Clamp01(num3), 1807f);
			float x = num * 1244f;
			float num4 = Mathf.PerlinNoise(x, 1606f) * 745f - 72f;
			double num5 = (double)(Mathf.PerlinNoise(x, 1429f) * 1433f - 955f);
			float t = 1081f * (1506f - Mathf.Cos(num * 840f * 420f * 415f)) * num3;
			this.FDNGIECHEDM.x = Mathf.Lerp(this.CNBBIJFHLIG.x, this.CNBBIJFHLIG.x * this.scaleFactor, t);
			this.FDNGIECHEDM.y = Mathf.Lerp(this.CNBBIJFHLIG.y, this.CNBBIJFHLIG.y * this.scaleFactor, t);
			this.FDNGIECHEDM.z = Mathf.Lerp(this.CNBBIJFHLIG.z, this.CNBBIJFHLIG.z * this.scaleFactor, t);
			this.DGAAFGDHHHJ.localScale = this.FDNGIECHEDM;
			double num6 = (double)(num4 * this.translationAmount * num3 * 190f);
			double num7 = num5 * (double)this.translationAmount * (double)num3 * (double)1902f;
			this.FDNGIECHEDM.x = (float)((double)this.DGAAFGDHHHJ.anchoredPosition.x - this.MKMPJKOFHOH + num6);
			this.FDNGIECHEDM.y = (float)((double)this.DGAAFGDHHHJ.anchoredPosition.y - this.HDEDNBLECBK + num7);
			this.FDNGIECHEDM.z = 303f;
			this.DGAAFGDHHHJ.OGOFACPLOGO(this.FDNGIECHEDM);
			this.MKMPJKOFHOH = num6;
			this.HDEDNBLECBK = num7;
		}
	}

	// Token: 0x0600394B RID: 14667 RVA: 0x001805AC File Offset: 0x0017E7AC
	private void AADMBDFACAJ()
	{
		if (this.DJPGBNAFDBK)
		{
			this.HJIIEHBPGOL -= Time.deltaTime;
			if (this.HJIIEHBPGOL <= 734f)
			{
				this.DJPGBNAFDBK = false;
				this.HJIIEHBPGOL = 1892f;
				this.DGAAFGDHHHJ.localScale = this.CNBBIJFHLIG;
				this.FDNGIECHEDM.x = (float)((double)this.DGAAFGDHHHJ.anchoredPosition.x - this.MKMPJKOFHOH);
				this.FDNGIECHEDM.y = (float)((double)this.DGAAFGDHHHJ.anchoredPosition.y - this.HDEDNBLECBK);
				this.FDNGIECHEDM.z = 761f;
				this.DGAAFGDHHHJ.OGOFACPLOGO(this.FDNGIECHEDM);
				this.MKMPJKOFHOH = 716.0;
				this.HDEDNBLECBK = 1163.0;
				return;
			}
			this.DFMJCEOILNC -= Time.deltaTime;
			if (this.DFMJCEOILNC > 450f)
			{
				return;
			}
			this.DFMJCEOILNC = this.frameUpdateInterval;
			float num = this.animationTime - this.HJIIEHBPGOL;
			float num2 = Mathf.Clamp01(num / this.animationTime);
			float num3 = 1183f * (1096f - Mathf.Cos(num2 * 58f * 642f));
			num3 = Mathf.Pow(Mathf.Clamp01(num3), 1441f);
			float x = num * 1549f;
			float num4 = Mathf.PerlinNoise(x, 1654f) * 1024f - 438f;
			double num5 = (double)(Mathf.PerlinNoise(x, 268f) * 815f - 166f);
			float t = 622f * (447f - Mathf.Cos(num * 462f * 1212f * 41f)) * num3;
			this.FDNGIECHEDM.x = Mathf.Lerp(this.CNBBIJFHLIG.x, this.CNBBIJFHLIG.x * this.scaleFactor, t);
			this.FDNGIECHEDM.y = Mathf.Lerp(this.CNBBIJFHLIG.y, this.CNBBIJFHLIG.y * this.scaleFactor, t);
			this.FDNGIECHEDM.z = Mathf.Lerp(this.CNBBIJFHLIG.z, this.CNBBIJFHLIG.z * this.scaleFactor, t);
			this.DGAAFGDHHHJ.localScale = this.FDNGIECHEDM;
			double num6 = (double)(num4 * this.translationAmount * num3 * 600f);
			double num7 = num5 * (double)this.translationAmount * (double)num3 * (double)1547f;
			this.FDNGIECHEDM.x = (float)((double)this.DGAAFGDHHHJ.anchoredPosition.x - this.MKMPJKOFHOH + num6);
			this.FDNGIECHEDM.y = (float)((double)this.DGAAFGDHHHJ.anchoredPosition.y - this.HDEDNBLECBK + num7);
			this.FDNGIECHEDM.z = 1608f;
			this.DGAAFGDHHHJ.OGOFACPLOGO(this.FDNGIECHEDM);
			this.MKMPJKOFHOH = num6;
			this.HDEDNBLECBK = num7;
		}
	}

	// Token: 0x0600394C RID: 14668 RVA: 0x0017AF4E File Offset: 0x0017914E
	private void NAAFHFFELKK()
	{
		base.gameObject.transform.DOKill(true);
	}

	// Token: 0x0600394D RID: 14669 RVA: 0x001808B4 File Offset: 0x0017EAB4
	public void AHGHAIEKAIL()
	{
		this.DGAAFGDHHHJ.anchoredPosition = new Vector2((float)((double)this.DGAAFGDHHHJ.anchoredPosition.x - this.MKMPJKOFHOH), (float)((double)this.DGAAFGDHHHJ.anchoredPosition.y - this.HDEDNBLECBK));
		this.MKMPJKOFHOH = 156.0;
		this.HDEDNBLECBK = 1675.0;
		this.CNBBIJFHLIG = this.DGAAFGDHHHJ.localScale;
		if (WideScreenScaler.AKDFAECJMEP(1788f))
		{
			WideScreenScaler component = base.gameObject.GetComponent<WideScreenScaler>();
			if (null != component)
			{
				this.CNBBIJFHLIG = component.BBADCJKFGDK();
				DPGJIJGOCIC.ADFCDFHBDAF("ok");
			}
		}
		base.gameObject.transform.DOKill(false);
		this.DGAAFGDHHHJ.localScale = this.CNBBIJFHLIG;
		this.DJPGBNAFDBK = false;
		this.HJIIEHBPGOL = this.animationTime;
		this.DFMJCEOILNC = 132f;
	}

	// Token: 0x0600394E RID: 14670 RVA: 0x001809AC File Offset: 0x0017EBAC
	private void CPIBMIOJIJL()
	{
		if (this.DJPGBNAFDBK)
		{
			this.HJIIEHBPGOL -= Time.deltaTime;
			if (this.HJIIEHBPGOL <= 707f)
			{
				this.DJPGBNAFDBK = true;
				this.HJIIEHBPGOL = 1371f;
				this.DGAAFGDHHHJ.localScale = this.CNBBIJFHLIG;
				this.FDNGIECHEDM.x = (float)((double)this.DGAAFGDHHHJ.anchoredPosition.x - this.MKMPJKOFHOH);
				this.FDNGIECHEDM.y = (float)((double)this.DGAAFGDHHHJ.anchoredPosition.y - this.HDEDNBLECBK);
				this.FDNGIECHEDM.z = 748f;
				this.DGAAFGDHHHJ.OGOFACPLOGO(this.FDNGIECHEDM);
				this.MKMPJKOFHOH = 1160.0;
				this.HDEDNBLECBK = 386.0;
				return;
			}
			this.DFMJCEOILNC -= Time.deltaTime;
			if (this.DFMJCEOILNC > 1263f)
			{
				return;
			}
			this.DFMJCEOILNC = this.frameUpdateInterval;
			float num = this.animationTime - this.HJIIEHBPGOL;
			float num2 = Mathf.Clamp01(num / this.animationTime);
			float num3 = 1529f * (613f - Mathf.Cos(num2 * 1924f * 1800f));
			num3 = Mathf.Pow(Mathf.Clamp01(num3), 201f);
			float x = num * 189f;
			float num4 = Mathf.PerlinNoise(x, 552f) * 566f - 1633f;
			double num5 = (double)(Mathf.PerlinNoise(x, 1496f) * 299f - 759f);
			float t = 739f * (1149f - Mathf.Cos(num * 938f * 808f * 1100f)) * num3;
			this.FDNGIECHEDM.x = Mathf.Lerp(this.CNBBIJFHLIG.x, this.CNBBIJFHLIG.x * this.scaleFactor, t);
			this.FDNGIECHEDM.y = Mathf.Lerp(this.CNBBIJFHLIG.y, this.CNBBIJFHLIG.y * this.scaleFactor, t);
			this.FDNGIECHEDM.z = Mathf.Lerp(this.CNBBIJFHLIG.z, this.CNBBIJFHLIG.z * this.scaleFactor, t);
			this.DGAAFGDHHHJ.localScale = this.FDNGIECHEDM;
			double num6 = (double)(num4 * this.translationAmount * num3 * 1752f);
			double num7 = num5 * (double)this.translationAmount * (double)num3 * (double)332f;
			this.FDNGIECHEDM.x = (float)((double)this.DGAAFGDHHHJ.anchoredPosition.x - this.MKMPJKOFHOH + num6);
			this.FDNGIECHEDM.y = (float)((double)this.DGAAFGDHHHJ.anchoredPosition.y - this.HDEDNBLECBK + num7);
			this.FDNGIECHEDM.z = 1318f;
			this.DGAAFGDHHHJ.OGOFACPLOGO(this.FDNGIECHEDM);
			this.MKMPJKOFHOH = num6;
			this.HDEDNBLECBK = num7;
		}
	}

	// Token: 0x0600394F RID: 14671 RVA: 0x0017AF4E File Offset: 0x0017914E
	private void GEPMOBKFIMI()
	{
		base.gameObject.transform.DOKill(true);
	}

	// Token: 0x06003950 RID: 14672 RVA: 0x00180CB4 File Offset: 0x0017EEB4
	private void ODILEKGAKLI()
	{
		if (this.DJPGBNAFDBK)
		{
			this.HJIIEHBPGOL -= Time.deltaTime;
			if (this.HJIIEHBPGOL <= 364f)
			{
				this.DJPGBNAFDBK = true;
				this.HJIIEHBPGOL = 312f;
				this.DGAAFGDHHHJ.localScale = this.CNBBIJFHLIG;
				this.FDNGIECHEDM.x = (float)((double)this.DGAAFGDHHHJ.anchoredPosition.x - this.MKMPJKOFHOH);
				this.FDNGIECHEDM.y = (float)((double)this.DGAAFGDHHHJ.anchoredPosition.y - this.HDEDNBLECBK);
				this.FDNGIECHEDM.z = 1207f;
				this.DGAAFGDHHHJ.OGOFACPLOGO(this.FDNGIECHEDM);
				this.MKMPJKOFHOH = 1593.0;
				this.HDEDNBLECBK = 38.0;
				return;
			}
			this.DFMJCEOILNC -= Time.deltaTime;
			if (this.DFMJCEOILNC > 1734f)
			{
				return;
			}
			this.DFMJCEOILNC = this.frameUpdateInterval;
			float num = this.animationTime - this.HJIIEHBPGOL;
			float num2 = Mathf.Clamp01(num / this.animationTime);
			float num3 = 787f * (162f - Mathf.Cos(num2 * 1409f * 1517f));
			num3 = Mathf.Pow(Mathf.Clamp01(num3), 1285f);
			float x = num * 1293f;
			float num4 = Mathf.PerlinNoise(x, 700f) * 1384f - 1271f;
			double num5 = (double)(Mathf.PerlinNoise(x, 1765f) * 1234f - 277f);
			float t = 1461f * (21f - Mathf.Cos(num * 587f * 463f * 1288f)) * num3;
			this.FDNGIECHEDM.x = Mathf.Lerp(this.CNBBIJFHLIG.x, this.CNBBIJFHLIG.x * this.scaleFactor, t);
			this.FDNGIECHEDM.y = Mathf.Lerp(this.CNBBIJFHLIG.y, this.CNBBIJFHLIG.y * this.scaleFactor, t);
			this.FDNGIECHEDM.z = Mathf.Lerp(this.CNBBIJFHLIG.z, this.CNBBIJFHLIG.z * this.scaleFactor, t);
			this.DGAAFGDHHHJ.localScale = this.FDNGIECHEDM;
			double num6 = (double)(num4 * this.translationAmount * num3 * 1883f);
			double num7 = num5 * (double)this.translationAmount * (double)num3 * (double)874f;
			this.FDNGIECHEDM.x = (float)((double)this.DGAAFGDHHHJ.anchoredPosition.x - this.MKMPJKOFHOH + num6);
			this.FDNGIECHEDM.y = (float)((double)this.DGAAFGDHHHJ.anchoredPosition.y - this.HDEDNBLECBK + num7);
			this.FDNGIECHEDM.z = 674f;
			this.DGAAFGDHHHJ.OGOFACPLOGO(this.FDNGIECHEDM);
			this.MKMPJKOFHOH = num6;
			this.HDEDNBLECBK = num7;
		}
	}

	// Token: 0x06003951 RID: 14673 RVA: 0x0017AE42 File Offset: 0x00179042
	private void IEKKNHMNBBK()
	{
		base.gameObject.transform.DOKill(false);
	}

	// Token: 0x06003952 RID: 14674 RVA: 0x0017AE42 File Offset: 0x00179042
	private void NKIEJIHEADI()
	{
		base.gameObject.transform.DOKill(false);
	}

	// Token: 0x06003953 RID: 14675 RVA: 0x0017AE42 File Offset: 0x00179042
	private void MOHLNGBBIOB()
	{
		base.gameObject.transform.DOKill(false);
	}

	// Token: 0x06003954 RID: 14676 RVA: 0x00180FBC File Offset: 0x0017F1BC
	public void KDBPEMFKNJE()
	{
		this.DGAAFGDHHHJ.anchoredPosition = new Vector2((float)((double)this.DGAAFGDHHHJ.anchoredPosition.x - this.MKMPJKOFHOH), (float)((double)this.DGAAFGDHHHJ.anchoredPosition.y - this.HDEDNBLECBK));
		this.MKMPJKOFHOH = 1455.0;
		this.HDEDNBLECBK = 89.0;
		this.CNBBIJFHLIG = this.DGAAFGDHHHJ.localScale;
		if (WideScreenScaler.FICKNODIDKP(1224f))
		{
			WideScreenScaler component = base.gameObject.GetComponent<WideScreenScaler>();
			if (null != component)
			{
				this.CNBBIJFHLIG = component.GDJKMMDMFII();
				DPGJIJGOCIC.ADFCDFHBDAF("rsl");
			}
		}
		base.gameObject.transform.DOKill(false);
		this.DGAAFGDHHHJ.localScale = this.CNBBIJFHLIG;
		this.DJPGBNAFDBK = false;
		this.HJIIEHBPGOL = this.animationTime;
		this.DFMJCEOILNC = 1926f;
	}

	// Token: 0x06003955 RID: 14677 RVA: 0x0017AF4E File Offset: 0x0017914E
	private void HEHFAKOFHPK()
	{
		base.gameObject.transform.DOKill(true);
	}

	// Token: 0x06003956 RID: 14678 RVA: 0x001810B4 File Offset: 0x0017F2B4
	private void CGPGCGCMNBE()
	{
		if (this.DJPGBNAFDBK)
		{
			this.HJIIEHBPGOL -= Time.deltaTime;
			if (this.HJIIEHBPGOL <= 697f)
			{
				this.DJPGBNAFDBK = false;
				this.HJIIEHBPGOL = 1662f;
				this.DGAAFGDHHHJ.localScale = this.CNBBIJFHLIG;
				this.FDNGIECHEDM.x = (float)((double)this.DGAAFGDHHHJ.anchoredPosition.x - this.MKMPJKOFHOH);
				this.FDNGIECHEDM.y = (float)((double)this.DGAAFGDHHHJ.anchoredPosition.y - this.HDEDNBLECBK);
				this.FDNGIECHEDM.z = 486f;
				this.DGAAFGDHHHJ.OGOFACPLOGO(this.FDNGIECHEDM);
				this.MKMPJKOFHOH = 592.0;
				this.HDEDNBLECBK = 1207.0;
				return;
			}
			this.DFMJCEOILNC -= Time.deltaTime;
			if (this.DFMJCEOILNC > 1904f)
			{
				return;
			}
			this.DFMJCEOILNC = this.frameUpdateInterval;
			float num = this.animationTime - this.HJIIEHBPGOL;
			float num2 = Mathf.Clamp01(num / this.animationTime);
			float num3 = 90f * (1774f - Mathf.Cos(num2 * 1176f * 420f));
			num3 = Mathf.Pow(Mathf.Clamp01(num3), 147f);
			float x = num * 771f;
			float num4 = Mathf.PerlinNoise(x, 690f) * 1344f - 86f;
			double num5 = (double)(Mathf.PerlinNoise(x, 1918f) * 1928f - 14f);
			float t = 1790f * (598f - Mathf.Cos(num * 874f * 1706f * 1916f)) * num3;
			this.FDNGIECHEDM.x = Mathf.Lerp(this.CNBBIJFHLIG.x, this.CNBBIJFHLIG.x * this.scaleFactor, t);
			this.FDNGIECHEDM.y = Mathf.Lerp(this.CNBBIJFHLIG.y, this.CNBBIJFHLIG.y * this.scaleFactor, t);
			this.FDNGIECHEDM.z = Mathf.Lerp(this.CNBBIJFHLIG.z, this.CNBBIJFHLIG.z * this.scaleFactor, t);
			this.DGAAFGDHHHJ.localScale = this.FDNGIECHEDM;
			double num6 = (double)(num4 * this.translationAmount * num3 * 612f);
			double num7 = num5 * (double)this.translationAmount * (double)num3 * (double)948f;
			this.FDNGIECHEDM.x = (float)((double)this.DGAAFGDHHHJ.anchoredPosition.x - this.MKMPJKOFHOH + num6);
			this.FDNGIECHEDM.y = (float)((double)this.DGAAFGDHHHJ.anchoredPosition.y - this.HDEDNBLECBK + num7);
			this.FDNGIECHEDM.z = 1908f;
			this.DGAAFGDHHHJ.OGOFACPLOGO(this.FDNGIECHEDM);
			this.MKMPJKOFHOH = num6;
			this.HDEDNBLECBK = num7;
		}
	}

	// Token: 0x06003957 RID: 14679 RVA: 0x0017AE42 File Offset: 0x00179042
	private void JOLAMLIFMMB()
	{
		base.gameObject.transform.DOKill(false);
	}

	// Token: 0x06003958 RID: 14680 RVA: 0x001813BC File Offset: 0x0017F5BC
	private void JPHFFPEGCKJ()
	{
		if (this.DJPGBNAFDBK)
		{
			this.HJIIEHBPGOL -= Time.deltaTime;
			if (this.HJIIEHBPGOL <= 1665f)
			{
				this.DJPGBNAFDBK = false;
				this.HJIIEHBPGOL = 577f;
				this.DGAAFGDHHHJ.localScale = this.CNBBIJFHLIG;
				this.FDNGIECHEDM.x = (float)((double)this.DGAAFGDHHHJ.anchoredPosition.x - this.MKMPJKOFHOH);
				this.FDNGIECHEDM.y = (float)((double)this.DGAAFGDHHHJ.anchoredPosition.y - this.HDEDNBLECBK);
				this.FDNGIECHEDM.z = 198f;
				this.DGAAFGDHHHJ.OGOFACPLOGO(this.FDNGIECHEDM);
				this.MKMPJKOFHOH = 1169.0;
				this.HDEDNBLECBK = 800.0;
				return;
			}
			this.DFMJCEOILNC -= Time.deltaTime;
			if (this.DFMJCEOILNC > 304f)
			{
				return;
			}
			this.DFMJCEOILNC = this.frameUpdateInterval;
			float num = this.animationTime - this.HJIIEHBPGOL;
			float num2 = Mathf.Clamp01(num / this.animationTime);
			float num3 = 308f * (1819f - Mathf.Cos(num2 * 1148f * 232f));
			num3 = Mathf.Pow(Mathf.Clamp01(num3), 1961f);
			float x = num * 906f;
			float num4 = Mathf.PerlinNoise(x, 636f) * 675f - 199f;
			double num5 = (double)(Mathf.PerlinNoise(x, 1356f) * 322f - 905f);
			float t = 1971f * (930f - Mathf.Cos(num * 1355f * 864f * 809f)) * num3;
			this.FDNGIECHEDM.x = Mathf.Lerp(this.CNBBIJFHLIG.x, this.CNBBIJFHLIG.x * this.scaleFactor, t);
			this.FDNGIECHEDM.y = Mathf.Lerp(this.CNBBIJFHLIG.y, this.CNBBIJFHLIG.y * this.scaleFactor, t);
			this.FDNGIECHEDM.z = Mathf.Lerp(this.CNBBIJFHLIG.z, this.CNBBIJFHLIG.z * this.scaleFactor, t);
			this.DGAAFGDHHHJ.localScale = this.FDNGIECHEDM;
			double num6 = (double)(num4 * this.translationAmount * num3 * 1770f);
			double num7 = num5 * (double)this.translationAmount * (double)num3 * (double)401f;
			this.FDNGIECHEDM.x = (float)((double)this.DGAAFGDHHHJ.anchoredPosition.x - this.MKMPJKOFHOH + num6);
			this.FDNGIECHEDM.y = (float)((double)this.DGAAFGDHHHJ.anchoredPosition.y - this.HDEDNBLECBK + num7);
			this.FDNGIECHEDM.z = 80f;
			this.DGAAFGDHHHJ.OGOFACPLOGO(this.FDNGIECHEDM);
			this.MKMPJKOFHOH = num6;
			this.HDEDNBLECBK = num7;
		}
	}

	// Token: 0x06003959 RID: 14681 RVA: 0x0017AE42 File Offset: 0x00179042
	private void MBAJBIPOFCB()
	{
		base.gameObject.transform.DOKill(false);
	}

	// Token: 0x0600395A RID: 14682 RVA: 0x0017AE1E File Offset: 0x0017901E
	private void OLEAIHHFBGB()
	{
		this.DGAAFGDHHHJ = base.gameObject.GetComponent<RectTransform>();
		this.CNBBIJFHLIG = this.DGAAFGDHHHJ.localScale;
	}

	// Token: 0x0600395B RID: 14683 RVA: 0x0017D634 File Offset: 0x0017B834
	private void NBIMDEPPBON()
	{
		if (this.playOnEnable)
		{
			this.DODGGGHNHCD();
		}
	}

	// Token: 0x0600395C RID: 14684 RVA: 0x0017C9B4 File Offset: 0x0017ABB4
	private void AADPIFCICBL()
	{
		if (this.playOnEnable)
		{
			this.AHGHAIEKAIL();
		}
	}

	// Token: 0x0600395D RID: 14685 RVA: 0x0017AF4E File Offset: 0x0017914E
	private void JLCJJONEBIB()
	{
		base.gameObject.transform.DOKill(true);
	}

	// Token: 0x0600395E RID: 14686 RVA: 0x001816C4 File Offset: 0x0017F8C4
	public void DOEGPEFNOLK()
	{
		this.DGAAFGDHHHJ.anchoredPosition = new Vector2((float)((double)this.DGAAFGDHHHJ.anchoredPosition.x - this.MKMPJKOFHOH), (float)((double)this.DGAAFGDHHHJ.anchoredPosition.y - this.HDEDNBLECBK));
		this.MKMPJKOFHOH = 1134.0;
		this.HDEDNBLECBK = 1390.0;
		this.CNBBIJFHLIG = this.DGAAFGDHHHJ.localScale;
		if (WideScreenScaler.OBHPFIBFDLO(1604f))
		{
			WideScreenScaler component = base.gameObject.GetComponent<WideScreenScaler>();
			if (null != component)
			{
				this.CNBBIJFHLIG = component.BBNNKIBPJKI();
				DPGJIJGOCIC.PJCLICBPPDA("");
			}
		}
		base.gameObject.transform.DOKill(true);
		this.DGAAFGDHHHJ.localScale = this.CNBBIJFHLIG;
		this.DJPGBNAFDBK = false;
		this.HJIIEHBPGOL = this.animationTime;
		this.DFMJCEOILNC = 666f;
	}

	// Token: 0x0600395F RID: 14687 RVA: 0x0017AE42 File Offset: 0x00179042
	private void AFCGMNGCPMD()
	{
		base.gameObject.transform.DOKill(false);
	}

	// Token: 0x06003960 RID: 14688 RVA: 0x0017D014 File Offset: 0x0017B214
	private void LPLBDKPLGMA()
	{
		if (this.playOnEnable)
		{
			this.KDBPEMFKNJE();
		}
	}

	// Token: 0x06003961 RID: 14689 RVA: 0x0017E244 File Offset: 0x0017C444
	private void CJBAAMNCEJN()
	{
		if (this.playOnEnable)
		{
			this.PHELNOOIBPO();
		}
	}

	// Token: 0x06003962 RID: 14690 RVA: 0x001817BC File Offset: 0x0017F9BC
	public void NPBNPBBHJPI()
	{
		this.DGAAFGDHHHJ.anchoredPosition = new Vector2((float)((double)this.DGAAFGDHHHJ.anchoredPosition.x - this.MKMPJKOFHOH), (float)((double)this.DGAAFGDHHHJ.anchoredPosition.y - this.HDEDNBLECBK));
		this.MKMPJKOFHOH = 730.0;
		this.HDEDNBLECBK = 940.0;
		this.CNBBIJFHLIG = this.DGAAFGDHHHJ.localScale;
		if (WideScreenScaler.CEJJDGNDFGK(141f))
		{
			WideScreenScaler component = base.gameObject.GetComponent<WideScreenScaler>();
			if (null != component)
			{
				this.CNBBIJFHLIG = component.KILHFJMBLFK();
				DPGJIJGOCIC.PJCLICBPPDA(" usedSlots:");
			}
		}
		base.gameObject.transform.DOKill(false);
		this.DGAAFGDHHHJ.localScale = this.CNBBIJFHLIG;
		this.DJPGBNAFDBK = false;
		this.HJIIEHBPGOL = this.animationTime;
		this.DFMJCEOILNC = 1197f;
	}

	// Token: 0x06003963 RID: 14691 RVA: 0x0017AE1E File Offset: 0x0017901E
	private void AMNBHDNALGO()
	{
		this.DGAAFGDHHHJ = base.gameObject.GetComponent<RectTransform>();
		this.CNBBIJFHLIG = this.DGAAFGDHHHJ.localScale;
	}

	// Token: 0x06003964 RID: 14692 RVA: 0x0017AE42 File Offset: 0x00179042
	private void ENNCLHFGHDO()
	{
		base.gameObject.transform.DOKill(false);
	}

	// Token: 0x06003965 RID: 14693 RVA: 0x001818B4 File Offset: 0x0017FAB4
	private void IACMMOBHGCK()
	{
		if (this.DJPGBNAFDBK)
		{
			this.HJIIEHBPGOL -= Time.deltaTime;
			if (this.HJIIEHBPGOL <= 557f)
			{
				this.DJPGBNAFDBK = true;
				this.HJIIEHBPGOL = 627f;
				this.DGAAFGDHHHJ.localScale = this.CNBBIJFHLIG;
				this.FDNGIECHEDM.x = (float)((double)this.DGAAFGDHHHJ.anchoredPosition.x - this.MKMPJKOFHOH);
				this.FDNGIECHEDM.y = (float)((double)this.DGAAFGDHHHJ.anchoredPosition.y - this.HDEDNBLECBK);
				this.FDNGIECHEDM.z = 1190f;
				this.DGAAFGDHHHJ.OGOFACPLOGO(this.FDNGIECHEDM);
				this.MKMPJKOFHOH = 898.0;
				this.HDEDNBLECBK = 206.0;
				return;
			}
			this.DFMJCEOILNC -= Time.deltaTime;
			if (this.DFMJCEOILNC > 313f)
			{
				return;
			}
			this.DFMJCEOILNC = this.frameUpdateInterval;
			float num = this.animationTime - this.HJIIEHBPGOL;
			float num2 = Mathf.Clamp01(num / this.animationTime);
			float num3 = 433f * (898f - Mathf.Cos(num2 * 1443f * 686f));
			num3 = Mathf.Pow(Mathf.Clamp01(num3), 264f);
			float x = num * 855f;
			float num4 = Mathf.PerlinNoise(x, 1469f) * 1734f - 70f;
			double num5 = (double)(Mathf.PerlinNoise(x, 1200f) * 86f - 351f);
			float t = 724f * (6f - Mathf.Cos(num * 119f * 1677f * 1724f)) * num3;
			this.FDNGIECHEDM.x = Mathf.Lerp(this.CNBBIJFHLIG.x, this.CNBBIJFHLIG.x * this.scaleFactor, t);
			this.FDNGIECHEDM.y = Mathf.Lerp(this.CNBBIJFHLIG.y, this.CNBBIJFHLIG.y * this.scaleFactor, t);
			this.FDNGIECHEDM.z = Mathf.Lerp(this.CNBBIJFHLIG.z, this.CNBBIJFHLIG.z * this.scaleFactor, t);
			this.DGAAFGDHHHJ.localScale = this.FDNGIECHEDM;
			double num6 = (double)(num4 * this.translationAmount * num3 * 1205f);
			double num7 = num5 * (double)this.translationAmount * (double)num3 * (double)1766f;
			this.FDNGIECHEDM.x = (float)((double)this.DGAAFGDHHHJ.anchoredPosition.x - this.MKMPJKOFHOH + num6);
			this.FDNGIECHEDM.y = (float)((double)this.DGAAFGDHHHJ.anchoredPosition.y - this.HDEDNBLECBK + num7);
			this.FDNGIECHEDM.z = 1544f;
			this.DGAAFGDHHHJ.OGOFACPLOGO(this.FDNGIECHEDM);
			this.MKMPJKOFHOH = num6;
			this.HDEDNBLECBK = num7;
		}
	}

	// Token: 0x06003966 RID: 14694 RVA: 0x0017AE1E File Offset: 0x0017901E
	private void EEOPIBNCCLD()
	{
		this.DGAAFGDHHHJ = base.gameObject.GetComponent<RectTransform>();
		this.CNBBIJFHLIG = this.DGAAFGDHHHJ.localScale;
	}

	// Token: 0x06003967 RID: 14695 RVA: 0x0017AE42 File Offset: 0x00179042
	private void NKPBKBHKJMA()
	{
		base.gameObject.transform.DOKill(false);
	}

	// Token: 0x06003968 RID: 14696 RVA: 0x0017AE42 File Offset: 0x00179042
	private void OnDisable()
	{
		base.gameObject.transform.DOKill(false);
	}

	// Token: 0x06003969 RID: 14697 RVA: 0x0017AE1E File Offset: 0x0017901E
	private void OKBGBJDJMNI()
	{
		this.DGAAFGDHHHJ = base.gameObject.GetComponent<RectTransform>();
		this.CNBBIJFHLIG = this.DGAAFGDHHHJ.localScale;
	}

	// Token: 0x0600396A RID: 14698 RVA: 0x00181BBC File Offset: 0x0017FDBC
	private void JKAIDMIIHHB()
	{
		if (this.DJPGBNAFDBK)
		{
			this.HJIIEHBPGOL -= Time.deltaTime;
			if (this.HJIIEHBPGOL <= 1601f)
			{
				this.DJPGBNAFDBK = false;
				this.HJIIEHBPGOL = 1154f;
				this.DGAAFGDHHHJ.localScale = this.CNBBIJFHLIG;
				this.FDNGIECHEDM.x = (float)((double)this.DGAAFGDHHHJ.anchoredPosition.x - this.MKMPJKOFHOH);
				this.FDNGIECHEDM.y = (float)((double)this.DGAAFGDHHHJ.anchoredPosition.y - this.HDEDNBLECBK);
				this.FDNGIECHEDM.z = 1502f;
				this.DGAAFGDHHHJ.OGOFACPLOGO(this.FDNGIECHEDM);
				this.MKMPJKOFHOH = 392.0;
				this.HDEDNBLECBK = 1346.0;
				return;
			}
			this.DFMJCEOILNC -= Time.deltaTime;
			if (this.DFMJCEOILNC > 125f)
			{
				return;
			}
			this.DFMJCEOILNC = this.frameUpdateInterval;
			float num = this.animationTime - this.HJIIEHBPGOL;
			float num2 = Mathf.Clamp01(num / this.animationTime);
			float num3 = 1049f * (258f - Mathf.Cos(num2 * 1863f * 879f));
			num3 = Mathf.Pow(Mathf.Clamp01(num3), 1759f);
			float x = num * 11f;
			float num4 = Mathf.PerlinNoise(x, 1887f) * 405f - 623f;
			double num5 = (double)(Mathf.PerlinNoise(x, 478f) * 959f - 1210f);
			float t = 637f * (878f - Mathf.Cos(num * 299f * 174f * 1204f)) * num3;
			this.FDNGIECHEDM.x = Mathf.Lerp(this.CNBBIJFHLIG.x, this.CNBBIJFHLIG.x * this.scaleFactor, t);
			this.FDNGIECHEDM.y = Mathf.Lerp(this.CNBBIJFHLIG.y, this.CNBBIJFHLIG.y * this.scaleFactor, t);
			this.FDNGIECHEDM.z = Mathf.Lerp(this.CNBBIJFHLIG.z, this.CNBBIJFHLIG.z * this.scaleFactor, t);
			this.DGAAFGDHHHJ.localScale = this.FDNGIECHEDM;
			double num6 = (double)(num4 * this.translationAmount * num3 * 1189f);
			double num7 = num5 * (double)this.translationAmount * (double)num3 * (double)1434f;
			this.FDNGIECHEDM.x = (float)((double)this.DGAAFGDHHHJ.anchoredPosition.x - this.MKMPJKOFHOH + num6);
			this.FDNGIECHEDM.y = (float)((double)this.DGAAFGDHHHJ.anchoredPosition.y - this.HDEDNBLECBK + num7);
			this.FDNGIECHEDM.z = 632f;
			this.DGAAFGDHHHJ.OGOFACPLOGO(this.FDNGIECHEDM);
			this.MKMPJKOFHOH = num6;
			this.HDEDNBLECBK = num7;
		}
	}

	// Token: 0x0600396B RID: 14699 RVA: 0x0017AE42 File Offset: 0x00179042
	private void CEDPIGBOKGB()
	{
		base.gameObject.transform.DOKill(false);
	}

	// Token: 0x0600396C RID: 14700 RVA: 0x0017AE42 File Offset: 0x00179042
	private void CPLFHCNHAOK()
	{
		base.gameObject.transform.DOKill(false);
	}

	// Token: 0x040010CF RID: 4303
	public float animationTime = 1f;

	// Token: 0x040010D0 RID: 4304
	public float scaleFactor;

	// Token: 0x040010D1 RID: 4305
	public float translationAmount;

	// Token: 0x040010D2 RID: 4306
	public bool playOnEnable = true;

	// Token: 0x040010D3 RID: 4307
	public float frameUpdateInterval = 0.04f;

	// Token: 0x040010D4 RID: 4308
	private Vector3 CNBBIJFHLIG;

	// Token: 0x040010D5 RID: 4309
	private RectTransform DGAAFGDHHHJ;

	// Token: 0x040010D6 RID: 4310
	private bool DJPGBNAFDBK;

	// Token: 0x040010D7 RID: 4311
	private float HJIIEHBPGOL;

	// Token: 0x040010D8 RID: 4312
	private float DFMJCEOILNC = -1f;

	// Token: 0x040010D9 RID: 4313
	private Vector3 FDNGIECHEDM;

	// Token: 0x040010DA RID: 4314
	private double MKMPJKOFHOH;

	// Token: 0x040010DB RID: 4315
	private double HDEDNBLECBK;
}
