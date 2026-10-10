using System;
using System.Collections;
using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x020004E5 RID: 1253
public static class DPGBGCPCPGL
{
	// Token: 0x0600979F RID: 38815 RVA: 0x00420DC8 File Offset: 0x0041EFC8
	public static void MIANFIGMPLC(this Image IHGCPGOFNCC, float KIGFAHKFKNL, float IDHBPDACMAA, Ease PLFJHEJEHGB, TweenCallback CDFFMKAOAGE = null)
	{
		Color color = IHGCPGOFNCC.color;
		IHGCPGOFNCC.color = color;
		float num = Mathf.Clamp01(Mathf.Abs(color.a - KIGFAHKFKNL));
		IDHBPDACMAA *= num;
		color.a = KIGFAHKFKNL;
		IHGCPGOFNCC.DOKill(false);
		IHGCPGOFNCC.DOColor(color, IDHBPDACMAA).SetEase(PLFJHEJEHGB).OnComplete(CDFFMKAOAGE);
	}

	// Token: 0x060097A0 RID: 38816 RVA: 0x00420E21 File Offset: 0x0041F021
	public static void JEFEEDPENEB(this Image IHGCPGOFNCC, MonoBehaviour KNDEGOJHHAJ, float IDHBPDACMAA, Action<Image> CDFFMKAOAGE = null)
	{
		KNDEGOJHHAJ.StartCoroutine(DPGBGCPCPGL.DPFHJACLAAA(IHGCPGOFNCC, IDHBPDACMAA, CDFFMKAOAGE));
	}

	// Token: 0x060097A1 RID: 38817 RVA: 0x00420E34 File Offset: 0x0041F034
	public static void LJMFCNFLDPG(this Image IHGCPGOFNCC, float BADPLCOLABH, float JJAGLJLGHEI)
	{
		RectTransform component = IHGCPGOFNCC.GetComponent<RectTransform>();
		Vector2 sizeDelta = component.sizeDelta;
		sizeDelta.x *= BADPLCOLABH;
		sizeDelta.y *= JJAGLJLGHEI;
		component.sizeDelta = sizeDelta;
	}

	// Token: 0x060097A2 RID: 38818 RVA: 0x00420E6C File Offset: 0x0041F06C
	public static void NFIPIOOJPEK(this Image IHGCPGOFNCC, float AMCHKLJOJAI, float KIGFAHKFKNL, float IDHBPDACMAA, Ease PLFJHEJEHGB, TweenCallback CDFFMKAOAGE = null)
	{
		Color color = IHGCPGOFNCC.color;
		color.a = AMCHKLJOJAI;
		IHGCPGOFNCC.color = color;
		color.a = KIGFAHKFKNL;
		IHGCPGOFNCC.DOColor(color, IDHBPDACMAA).SetEase(PLFJHEJEHGB).OnComplete(CDFFMKAOAGE);
	}

	// Token: 0x060097A3 RID: 38819 RVA: 0x00420EAE File Offset: 0x0041F0AE
	private static IEnumerator DPFHJACLAAA(Image IHGCPGOFNCC, float IDHBPDACMAA, Action<Image> CDFFMKAOAGE)
	{
		float start = Time.time;
		while (Time.time <= start + IDHBPDACMAA)
		{
			Color color = IHGCPGOFNCC.color;
			color.a = Mathf.Clamp01((Time.time - start) / IDHBPDACMAA);
			IHGCPGOFNCC.color = color;
			yield return new WaitForEndOfFrame();
		}
		if (CDFFMKAOAGE != null)
		{
			CDFFMKAOAGE(IHGCPGOFNCC);
		}
		yield break;
	}
}
