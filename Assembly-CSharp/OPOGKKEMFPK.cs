using System;
using System.Collections;
using UnityEngine;

// Token: 0x02000121 RID: 289
public static class OPOGKKEMFPK
{
	// Token: 0x06002652 RID: 9810 RVA: 0x00116046 File Offset: 0x00114246
	public static void ENDAAMFHMCN(this SpriteRenderer AGOALOFOAMK, MonoBehaviour MBIBHJIEIBG, float ABMDCBCHNAD, Action<SpriteRenderer> HLJNJIECKDK = null)
	{
		MBIBHJIEIBG.StartCoroutine(OPOGKKEMFPK.DPFHJACLAAA(AGOALOFOAMK, ABMDCBCHNAD, HLJNJIECKDK));
	}

	// Token: 0x06002653 RID: 9811 RVA: 0x00116057 File Offset: 0x00114257
	private static IEnumerator DPFHJACLAAA(SpriteRenderer AGOALOFOAMK, float ABMDCBCHNAD, Action<SpriteRenderer> HLJNJIECKDK)
	{
		float start = Time.time;
		while (Time.time <= start + ABMDCBCHNAD)
		{
			Color color = AGOALOFOAMK.color;
			color.a = Mathf.Clamp01((Time.time - start) / ABMDCBCHNAD);
			AGOALOFOAMK.color = color;
			yield return new WaitForEndOfFrame();
		}
		if (HLJNJIECKDK != null)
		{
			HLJNJIECKDK(AGOALOFOAMK);
		}
		yield break;
	}
}
