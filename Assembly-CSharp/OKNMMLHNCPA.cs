using System;
using System.Collections;
using UnityEngine;

// Token: 0x02000195 RID: 405
public static class OKNMMLHNCPA
{
	// Token: 0x0600310C RID: 12556 RVA: 0x0014DDED File Offset: 0x0014BFED
	public static IEnumerator JANJEMFAEPK(RectTransform HNDJMKFCMEK)
	{
		float elapsedTemp = 0f;
		while (elapsedTemp < 0.45f)
		{
			if (null == HNDJMKFCMEK)
			{
				yield break;
			}
			elapsedTemp += Mathf.Min(Time.unscaledDeltaTime, 0.033333335f);
			float num = Mathf.Clamp01(elapsedTemp / 0.45f);
			float num2 = 1f + 0.35f * Mathf.Sin(num * 3.1415927f);
			float z = 14f * Mathf.Sin(num * 3.1415927f * 2f) * (1f - num);
			HNDJMKFCMEK.localScale = new Vector3(num2, num2, 1f);
			HNDJMKFCMEK.localRotation = Quaternion.Euler(0f, 0f, z);
			yield return null;
		}
		OKNMMLHNCPA.EPJKDCDOEMM(HNDJMKFCMEK);
		yield break;
	}

	// Token: 0x0600310D RID: 12557 RVA: 0x0014DDFC File Offset: 0x0014BFFC
	public static void EPJKDCDOEMM(RectTransform HNDJMKFCMEK)
	{
		if (null == HNDJMKFCMEK)
		{
			return;
		}
		HNDJMKFCMEK.localScale = Vector3.one;
		HNDJMKFCMEK.localRotation = Quaternion.identity;
	}

	// Token: 0x04000F5F RID: 3935
	public const float LEMKAHBOMLA = 0.45f;

	// Token: 0x04000F60 RID: 3936
	public const float GOFKCIMLODM = 0.35f;

	// Token: 0x04000F61 RID: 3937
	public const float ADLDIMHKDOI = 14f;

	// Token: 0x04000F62 RID: 3938
	public const float BICMAKEGDED = 0.033333335f;
}
