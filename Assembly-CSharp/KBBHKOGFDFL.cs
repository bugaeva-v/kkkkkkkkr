using System;
using UnityEngine;

// Token: 0x020000CD RID: 205
public static class KBBHKOGFDFL
{
	// Token: 0x06001E35 RID: 7733 RVA: 0x000D9A42 File Offset: 0x000D7C42
	public static void GJEGCPHHODD(this RectTransform CCIAGBPILGF, float EKHFDMCLAJF)
	{
		CCIAGBPILGF.offsetMin = new Vector2(EKHFDMCLAJF, CCIAGBPILGF.offsetMin.y);
	}

	// Token: 0x06001E36 RID: 7734 RVA: 0x000D9A5B File Offset: 0x000D7C5B
	public static void MMGBLHCPJLE(this RectTransform CCIAGBPILGF, float FLADLMHFGJA)
	{
		CCIAGBPILGF.offsetMax = new Vector2(CCIAGBPILGF.offsetMax.x, -FLADLMHFGJA);
	}

	// Token: 0x06001E37 RID: 7735 RVA: 0x000D9A75 File Offset: 0x000D7C75
	public static void AHLJBONHHKL(this RectTransform CCIAGBPILGF, Vector2 HMEHIFNJMPF)
	{
		CCIAGBPILGF.anchoredPosition += new Vector2((float)((int)HMEHIFNJMPF.x), (float)((int)HMEHIFNJMPF.y));
	}

	// Token: 0x06001E38 RID: 7736 RVA: 0x000D9AA0 File Offset: 0x000D7CA0
	public static void EFOCKEJENAC(this RectTransform CCIAGBPILGF, float DDMMDDFIALL)
	{
		Vector2 sizeDelta = CCIAGBPILGF.sizeDelta;
		sizeDelta.x = DDMMDDFIALL;
		CCIAGBPILGF.sizeDelta = sizeDelta;
	}

	// Token: 0x06001E39 RID: 7737 RVA: 0x000D9AC3 File Offset: 0x000D7CC3
	public static void OGOFACPLOGO(this RectTransform CCIAGBPILGF, Vector2 KPELENLHOEF)
	{
		CCIAGBPILGF.anchoredPosition = KPELENLHOEF;
	}

	// Token: 0x06001E3A RID: 7738 RVA: 0x000D9ACC File Offset: 0x000D7CCC
	public static void BLKGPIFNENN(this RectTransform CCIAGBPILGF, LCAJAHHLNJN INMOPHIHBEB)
	{
		switch (INMOPHIHBEB)
		{
		case LCAJAHHLNJN.TopLeft:
			CCIAGBPILGF.pivot = new Vector2(0f, 1f);
			return;
		case LCAJAHHLNJN.TopCenter:
			CCIAGBPILGF.pivot = new Vector2(0.5f, 1f);
			return;
		case LCAJAHHLNJN.TopRight:
			CCIAGBPILGF.pivot = new Vector2(1f, 1f);
			return;
		case LCAJAHHLNJN.MiddleLeft:
			CCIAGBPILGF.pivot = new Vector2(0f, 0.5f);
			return;
		case LCAJAHHLNJN.MiddleCenter:
			CCIAGBPILGF.pivot = new Vector2(0.5f, 0.5f);
			return;
		case LCAJAHHLNJN.MiddleRight:
			CCIAGBPILGF.pivot = new Vector2(1f, 0.5f);
			return;
		case LCAJAHHLNJN.BottomLeft:
			CCIAGBPILGF.pivot = new Vector2(0f, 0f);
			return;
		case LCAJAHHLNJN.BottomCenter:
			CCIAGBPILGF.pivot = new Vector2(0.5f, 0f);
			return;
		case LCAJAHHLNJN.BottomRight:
			CCIAGBPILGF.pivot = new Vector2(1f, 0f);
			return;
		default:
			return;
		}
	}

	// Token: 0x06001E3B RID: 7739 RVA: 0x000D9BCC File Offset: 0x000D7DCC
	public static void GGIONHNFIKJ(this RectTransform CCIAGBPILGF, JMEAPEMDGMH DEOBNONPJAE, int KOILDMNMMMI = 0, int KFDNLKIGJJJ = 0)
	{
		CCIAGBPILGF.anchoredPosition = new Vector2((float)KOILDMNMMMI, (float)KFDNLKIGJJJ);
		switch (DEOBNONPJAE)
		{
		case JMEAPEMDGMH.TopLeft:
			CCIAGBPILGF.anchorMin = new Vector2(0f, 1f);
			CCIAGBPILGF.anchorMax = new Vector2(0f, 1f);
			return;
		case JMEAPEMDGMH.TopCenter:
			CCIAGBPILGF.anchorMin = new Vector2(0.5f, 1f);
			CCIAGBPILGF.anchorMax = new Vector2(0.5f, 1f);
			return;
		case JMEAPEMDGMH.TopRight:
			CCIAGBPILGF.anchorMin = new Vector2(1f, 1f);
			CCIAGBPILGF.anchorMax = new Vector2(1f, 1f);
			return;
		case JMEAPEMDGMH.MiddleLeft:
			CCIAGBPILGF.anchorMin = new Vector2(0f, 0.5f);
			CCIAGBPILGF.anchorMax = new Vector2(0f, 0.5f);
			return;
		case JMEAPEMDGMH.MiddleCenter:
			CCIAGBPILGF.anchorMin = new Vector2(0.5f, 0.5f);
			CCIAGBPILGF.anchorMax = new Vector2(0.5f, 0.5f);
			return;
		case JMEAPEMDGMH.MiddleRight:
			CCIAGBPILGF.anchorMin = new Vector2(1f, 0.5f);
			CCIAGBPILGF.anchorMax = new Vector2(1f, 0.5f);
			return;
		case JMEAPEMDGMH.BottomLeft:
			CCIAGBPILGF.anchorMin = new Vector2(0f, 0f);
			CCIAGBPILGF.anchorMax = new Vector2(0f, 0f);
			return;
		case JMEAPEMDGMH.BottonCenter:
			CCIAGBPILGF.anchorMin = new Vector2(0.5f, 0f);
			CCIAGBPILGF.anchorMax = new Vector2(0.5f, 0f);
			return;
		case JMEAPEMDGMH.BottomRight:
			CCIAGBPILGF.anchorMin = new Vector2(1f, 0f);
			CCIAGBPILGF.anchorMax = new Vector2(1f, 0f);
			return;
		case JMEAPEMDGMH.BottomStretch:
			break;
		case JMEAPEMDGMH.VertStretchLeft:
			CCIAGBPILGF.anchorMin = new Vector2(0f, 0f);
			CCIAGBPILGF.anchorMax = new Vector2(0f, 1f);
			return;
		case JMEAPEMDGMH.VertStretchRight:
			CCIAGBPILGF.anchorMin = new Vector2(1f, 0f);
			CCIAGBPILGF.anchorMax = new Vector2(1f, 1f);
			return;
		case JMEAPEMDGMH.VertStretchCenter:
			CCIAGBPILGF.anchorMin = new Vector2(0.5f, 0f);
			CCIAGBPILGF.anchorMax = new Vector2(0.5f, 1f);
			return;
		case JMEAPEMDGMH.HorStretchTop:
			CCIAGBPILGF.anchorMin = new Vector2(0f, 1f);
			CCIAGBPILGF.anchorMax = new Vector2(1f, 1f);
			return;
		case JMEAPEMDGMH.HorStretchMiddle:
			CCIAGBPILGF.anchorMin = new Vector2(0f, 0.5f);
			CCIAGBPILGF.anchorMax = new Vector2(1f, 0.5f);
			return;
		case JMEAPEMDGMH.HorStretchBottom:
			CCIAGBPILGF.anchorMin = new Vector2(0f, 0f);
			CCIAGBPILGF.anchorMax = new Vector2(1f, 0f);
			return;
		case JMEAPEMDGMH.StretchAll:
			CCIAGBPILGF.anchorMin = new Vector2(0f, 0f);
			CCIAGBPILGF.anchorMax = new Vector2(1f, 1f);
			break;
		default:
			return;
		}
	}

	// Token: 0x06001E3C RID: 7740 RVA: 0x000D9EE2 File Offset: 0x000D80E2
	public static float HILHDGDPANG(this RectTransform CCIAGBPILGF)
	{
		return CCIAGBPILGF.sizeDelta.y;
	}

	// Token: 0x06001E3D RID: 7741 RVA: 0x000D9EEF File Offset: 0x000D80EF
	public static void AHLJBONHHKL(this RectTransform CCIAGBPILGF, int HCEGFBMJNLD, int KMKIOCKJAEI)
	{
		CCIAGBPILGF.anchoredPosition += new Vector2((float)HCEGFBMJNLD, (float)KMKIOCKJAEI);
	}

	// Token: 0x06001E3E RID: 7742 RVA: 0x000D9F0B File Offset: 0x000D810B
	public static void OGOFACPLOGO(this RectTransform CCIAGBPILGF, float HEMJMIOJNMG, float JLNDMLIIAOG)
	{
		CCIAGBPILGF.anchoredPosition = new Vector2(HEMJMIOJNMG, JLNDMLIIAOG);
	}

	// Token: 0x06001E3F RID: 7743 RVA: 0x000D9F1C File Offset: 0x000D811C
	public static void IMLMHHMHEDP(this RectTransform CCIAGBPILGF, float EKHFDMCLAJF, float MBHKAENEMEB, float FLADLMHFGJA, float IHPMHOJOCMK, float HLEMNNHBICB)
	{
		RectTransform rectTransform = CCIAGBPILGF.parent as RectTransform;
		float num = ((rectTransform != null) ? rectTransform.rect.width : 0f) - EKHFDMCLAJF - MBHKAENEMEB;
		if (num > HLEMNNHBICB)
		{
			float num2 = num - HLEMNNHBICB;
			EKHFDMCLAJF += num2 / 2f;
			MBHKAENEMEB += num2 / 2f;
		}
		CCIAGBPILGF.offsetMin = new Vector2(EKHFDMCLAJF, IHPMHOJOCMK);
		CCIAGBPILGF.offsetMax = new Vector2(-MBHKAENEMEB, -FLADLMHFGJA);
	}

	// Token: 0x06001E40 RID: 7744 RVA: 0x000D9F95 File Offset: 0x000D8195
	public static void GOAKOMCLMFB(this RectTransform CCIAGBPILGF, float MBHKAENEMEB)
	{
		CCIAGBPILGF.offsetMax = new Vector2(-MBHKAENEMEB, CCIAGBPILGF.offsetMax.y);
	}

	// Token: 0x06001E41 RID: 7745 RVA: 0x000D9FB0 File Offset: 0x000D81B0
	public static void OEOKGDKPKGL(this RectTransform CCIAGBPILGF, float HCAAKKDLLLL)
	{
		Vector2 offsetMin = CCIAGBPILGF.offsetMin;
		offsetMin.y -= HCAAKKDLLLL;
		CCIAGBPILGF.offsetMin = offsetMin;
	}

	// Token: 0x06001E42 RID: 7746 RVA: 0x000D9FD7 File Offset: 0x000D81D7
	public static void PAFMBDCAPBL(this RectTransform CCIAGBPILGF, float IHPMHOJOCMK)
	{
		CCIAGBPILGF.offsetMin = new Vector2(CCIAGBPILGF.offsetMin.x, IHPMHOJOCMK);
	}

	// Token: 0x06001E43 RID: 7747 RVA: 0x000D9FF0 File Offset: 0x000D81F0
	public static void ACBKFBBCNNC(this RectTransform CCIAGBPILGF, float FFLGIPEIHOO)
	{
		Vector2 sizeDelta = CCIAGBPILGF.sizeDelta;
		sizeDelta.y = FFLGIPEIHOO;
		CCIAGBPILGF.sizeDelta = sizeDelta;
	}

	// Token: 0x06001E44 RID: 7748 RVA: 0x000DA014 File Offset: 0x000D8214
	public static void IMGKEIAKLOH(this RectTransform CCIAGBPILGF)
	{
		Vector3 localScale = CCIAGBPILGF.localScale;
		localScale.x = 1f;
		CCIAGBPILGF.localScale = localScale;
	}

	// Token: 0x06001E45 RID: 7749 RVA: 0x000DA03B File Offset: 0x000D823B
	public static void AMPMCKEAACJ(this RectTransform CCIAGBPILGF, float HCEGFBMJNLD, float KMKIOCKJAEI, float FLNLOIKLNOP)
	{
		CCIAGBPILGF.localScale = new Vector3(HCEGFBMJNLD, KMKIOCKJAEI, FLNLOIKLNOP);
	}

	// Token: 0x06001E46 RID: 7750 RVA: 0x000DA04B File Offset: 0x000D824B
	public static void OGOFACPLOGO(this RectTransform CCIAGBPILGF, int HEMJMIOJNMG, int JLNDMLIIAOG)
	{
		CCIAGBPILGF.anchoredPosition = new Vector2((float)HEMJMIOJNMG, (float)JLNDMLIIAOG);
	}

	// Token: 0x06001E47 RID: 7751 RVA: 0x000DA05C File Offset: 0x000D825C
	public static void GHHPCIKDJHA(this RectTransform CCIAGBPILGF, float HCAAKKDLLLL)
	{
		Vector2 offsetMax = CCIAGBPILGF.offsetMax;
		offsetMax.x += HCAAKKDLLLL;
		CCIAGBPILGF.offsetMax = offsetMax;
	}

	// Token: 0x06001E48 RID: 7752 RVA: 0x000DA083 File Offset: 0x000D8283
	public static void AHLJBONHHKL(this RectTransform CCIAGBPILGF, float HCEGFBMJNLD, float KMKIOCKJAEI)
	{
		CCIAGBPILGF.anchoredPosition += new Vector2(HCEGFBMJNLD, KMKIOCKJAEI);
	}

	// Token: 0x06001E49 RID: 7753 RVA: 0x000DA0A0 File Offset: 0x000D82A0
	public static void EKGKENJHKLE(this RectTransform CCIAGBPILGF)
	{
		Vector3 localScale = CCIAGBPILGF.localScale;
		localScale.x *= -1f;
		CCIAGBPILGF.localScale = localScale;
	}
}
