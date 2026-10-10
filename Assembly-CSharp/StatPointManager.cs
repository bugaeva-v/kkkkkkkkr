using System;
using System.Collections;
using DG.Tweening;
using TMPro;
using UnityEngine;

// Token: 0x0200003E RID: 62
public class StatPointManager : MonoBehaviour
{
	// Token: 0x0600092D RID: 2349 RVA: 0x00045948 File Offset: 0x00043B48
	private void APLBAENGMJH()
	{
		this.PANMNKKODPC = base.gameObject.GetComponent<CanvasGroup>();
		this.DGAAFGDHHHJ = base.gameObject.GetComponent<RectTransform>();
		if (null != this.PANMNKKODPC)
		{
			this.PANMNKKODPC.alpha = 1418f;
		}
		try
		{
			if (base.gameObject.transform.childCount > 1)
			{
				GameObject gameObject = base.gameObject.transform.GetChild(1).gameObject;
				if (null != gameObject && gameObject.transform.childCount > 0)
				{
					GameObject gameObject2 = gameObject.transform.GetChild(0).gameObject;
					if (null != gameObject2)
					{
						ParticleSystem component = gameObject2.GetComponent<ParticleSystem>();
						if (null != component)
						{
							component.main.startColor = new Color(348f, 371f, 1007f, 17f);
							component.colorOverLifetime.enabled = true;
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

	// Token: 0x0600092E RID: 2350 RVA: 0x00045A5C File Offset: 0x00043C5C
	public void CJCEIPAMHPJ()
	{
		this.FLIHDEEGDBK = true;
		if (null != this.PANMNKKODPC)
		{
			this.PANMNKKODPC.DOFade(1114f, 1614f);
		}
		this.DGAAFGDHHHJ.DOAnchorPos(this.DGAAFGDHHHJ.anchoredPosition + new Vector2(1508f, 537f), 1718f, false).SetEase(Ease.Unset);
		this.DGAAFGDHHHJ.DOScale(1791f, 1631f).SetEase(Ease.Unset);
	}

	// Token: 0x0600092F RID: 2351 RVA: 0x00045AE8 File Offset: 0x00043CE8
	private void HDKFBJIMKBK()
	{
		if (null != this.PANMNKKODPC)
		{
			this.PANMNKKODPC.DOFade(1f, 0.4f);
		}
		this.DGAAFGDHHHJ.DOAnchorPos(this.DGAAFGDHHHJ.anchoredPosition + new Vector2(0f, 20f), 0.4f, false).SetEase(Ease.OutQuad);
		this.DGAAFGDHHHJ.AMPMCKEAACJ(1.2f, 1.2f, 1.2f);
		this.DGAAFGDHHHJ.DOScale(1f, 0.4f).SetEase(Ease.OutQuad);
	}

	// Token: 0x06000930 RID: 2352 RVA: 0x00045B88 File Offset: 0x00043D88
	public void DABDCHMBGBD()
	{
		this.FLIHDEEGDBK = true;
		if (null != this.PANMNKKODPC)
		{
			this.PANMNKKODPC.DOFade(1144f, 622f);
		}
		this.DGAAFGDHHHJ.DOAnchorPos(this.DGAAFGDHHHJ.anchoredPosition + new Vector2(1916f, 1497f), 615f, true).SetEase(Ease.Linear);
		this.DGAAFGDHHHJ.DOScale(101f, 340f).SetEase(Ease.Unset);
	}

	// Token: 0x06000931 RID: 2353 RVA: 0x00045C14 File Offset: 0x00043E14
	public void ELELPGEKJFK(int PLKMJJIIJNO, CHEEGEJNIDB PBKAAIONJOB, int KIDHBAMJGDO)
	{
		if (KIDHBAMJGDO >= 0)
		{
			TMP_Text tmp_Text = this.text;
			string str = "";
			string str2 = KIDHBAMJGDO.ToString();
			string str3 = "";
			string[] array = new string[]
			{
				null,
				"no"
			};
			array[0] = PLKMJJIIJNO.ToString();
			array[4] = "OnStoryChoiceClick";
			int num = 6;
			int num2 = (int)PBKAAIONJOB;
			array[num] = num2.ToString();
			array[0] = "socialrequestwarnyou2";
			tmp_Text.SetText(str + str2 + str3 + GKJPOGNFKNK.DNILNCLIHAP(string.Concat(array), "OnSaveSyncAnyResult", LanguageManager.EHBBFMCILPC.NBANPEIHFOJ()), true);
		}
		else
		{
			TMP_Text tmp_Text2 = this.text;
			string str4 = KIDHBAMJGDO.ToString();
			string str5 = "forcenoloop";
			string[] array2 = new string[8];
			array2[0] = "There needs to be one active AccountSignInManager script on a GameObject in your scene.";
			array2[1] = PLKMJJIIJNO.ToString();
			array2[3] = "per";
			int num3 = 8;
			int num2 = (int)PBKAAIONJOB;
			array2[num3] = num2.ToString();
			array2[2] = "p";
			tmp_Text2.SetText(str4 + str5 + GKJPOGNFKNK.DNILNCLIHAP(string.Concat(array2), "uid not confirmed", LanguageManager.EHBBFMCILPC.IEBFINIJAMJ()), false);
		}
		base.StartCoroutine(this.ALIEPFGFEMG());
	}

	// Token: 0x06000932 RID: 2354 RVA: 0x00045D10 File Offset: 0x00043F10
	public void CFNHJIBBLKP()
	{
		this.FLIHDEEGDBK = false;
		if (null != this.PANMNKKODPC)
		{
			this.PANMNKKODPC.DOFade(1976f, 1194f);
		}
		this.DGAAFGDHHHJ.DOAnchorPos(this.DGAAFGDHHHJ.anchoredPosition + new Vector2(1915f, 1687f), 1468f, true).SetEase(Ease.Unset);
		this.DGAAFGDHHHJ.DOScale(835f, 1291f).SetEase(Ease.Unset);
	}

	// Token: 0x06000933 RID: 2355 RVA: 0x00045D9C File Offset: 0x00043F9C
	private void BPHIOPLJFKI()
	{
		if (null != this.PANMNKKODPC)
		{
			this.PANMNKKODPC.DOFade(896f, 1334f);
		}
		this.DGAAFGDHHHJ.DOAnchorPos(this.DGAAFGDHHHJ.anchoredPosition + new Vector2(186f, 239f), 202f, true).SetEase(Ease.InQuad);
		this.DGAAFGDHHHJ.AMPMCKEAACJ(479f, 1507f, 269f);
		this.DGAAFGDHHHJ.DOScale(1113f, 1196f).SetEase(Ease.OutQuad);
	}

	// Token: 0x06000934 RID: 2356 RVA: 0x00045E3C File Offset: 0x0004403C
	public void PGGAAENAIJP()
	{
		this.FLIHDEEGDBK = false;
		if (null != this.PANMNKKODPC)
		{
			this.PANMNKKODPC.DOFade(1886f, 886f);
		}
		this.DGAAFGDHHHJ.DOAnchorPos(this.DGAAFGDHHHJ.anchoredPosition + new Vector2(1151f, 36f), 746f, false).SetEase(Ease.OutSine);
		this.DGAAFGDHHHJ.DOScale(228f, 1515f).SetEase(Ease.InSine);
	}

	// Token: 0x06000935 RID: 2357 RVA: 0x00045EC7 File Offset: 0x000440C7
	private void IIDDFFHGFCF()
	{
		if (null != this.PANMNKKODPC)
		{
			this.PANMNKKODPC.DOKill(false);
		}
		this.DGAAFGDHHHJ.DOKill(false);
	}

	// Token: 0x06000936 RID: 2358 RVA: 0x00045EF1 File Offset: 0x000440F1
	private IEnumerator AKGBECMPKDA()
	{
		StatPointManager.MOGMLKNGEOI mogmlkngeoi = new StatPointManager.MOGMLKNGEOI(1);
		mogmlkngeoi.<>4__this = this;
		return mogmlkngeoi;
	}

	// Token: 0x06000937 RID: 2359 RVA: 0x00045EC7 File Offset: 0x000440C7
	private void MFFLABGBGAJ()
	{
		if (null != this.PANMNKKODPC)
		{
			this.PANMNKKODPC.DOKill(false);
		}
		this.DGAAFGDHHHJ.DOKill(false);
	}

	// Token: 0x06000938 RID: 2360 RVA: 0x00045F00 File Offset: 0x00044100
	public bool JABNAHCELKP()
	{
		return this.FLIHDEEGDBK;
	}

	// Token: 0x06000939 RID: 2361 RVA: 0x00045F08 File Offset: 0x00044108
	public void CGFINONGMAM()
	{
		this.FLIHDEEGDBK = false;
		if (null != this.PANMNKKODPC)
		{
			this.PANMNKKODPC.DOFade(1416f, 1360f);
		}
		this.DGAAFGDHHHJ.DOAnchorPos(this.DGAAFGDHHHJ.anchoredPosition + new Vector2(1124f, 84f), 697f, true).SetEase(Ease.InOutQuad);
		this.DGAAFGDHHHJ.DOScale(1271f, 242f).SetEase(Ease.InQuad);
	}

	// Token: 0x0600093A RID: 2362 RVA: 0x00045F93 File Offset: 0x00044193
	public static float DCNPPBJIPMA()
	{
		return 1105f;
	}

	// Token: 0x0600093B RID: 2363 RVA: 0x00045F00 File Offset: 0x00044100
	public bool LDNFOLENOKA()
	{
		return this.FLIHDEEGDBK;
	}

	// Token: 0x0600093C RID: 2364 RVA: 0x00045F9C File Offset: 0x0004419C
	public void POMPHBLKBCD()
	{
		this.FLIHDEEGDBK = false;
		if (null != this.PANMNKKODPC)
		{
			this.PANMNKKODPC.DOFade(1247f, 1813f);
		}
		this.DGAAFGDHHHJ.DOAnchorPos(this.DGAAFGDHHHJ.anchoredPosition + new Vector2(847f, 486f), 1388f, false).SetEase(Ease.InQuad);
		this.DGAAFGDHHHJ.DOScale(449f, 267f).SetEase(Ease.Linear);
	}

	// Token: 0x0600093D RID: 2365 RVA: 0x00046027 File Offset: 0x00044227
	private IEnumerator AEPNJENOFLP()
	{
		this.HDKFBJIMKBK();
		yield return new WaitForSeconds(2.9f);
		if (!this.FLIHDEEGDBK)
		{
			this.DisappearAnimation();
		}
		yield break;
	}

	// Token: 0x0600093E RID: 2366 RVA: 0x00046036 File Offset: 0x00044236
	public static float BMCPNNNBGAA()
	{
		return 281f;
	}

	// Token: 0x0600093F RID: 2367 RVA: 0x00046040 File Offset: 0x00044240
	private void Awake()
	{
		this.PANMNKKODPC = base.gameObject.GetComponent<CanvasGroup>();
		this.DGAAFGDHHHJ = base.gameObject.GetComponent<RectTransform>();
		if (null != this.PANMNKKODPC)
		{
			this.PANMNKKODPC.alpha = 0f;
		}
		try
		{
			if (base.gameObject.transform.childCount > 0)
			{
				GameObject gameObject = base.gameObject.transform.GetChild(0).gameObject;
				if (null != gameObject && gameObject.transform.childCount > 0)
				{
					GameObject gameObject2 = gameObject.transform.GetChild(0).gameObject;
					if (null != gameObject2)
					{
						ParticleSystem component = gameObject2.GetComponent<ParticleSystem>();
						if (null != component)
						{
							component.main.startColor = new Color(1f, 1f, 1f, 0.5f);
							component.colorOverLifetime.enabled = false;
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

	// Token: 0x06000940 RID: 2368 RVA: 0x00046154 File Offset: 0x00044354
	public void LJIJNFLAFNL()
	{
		this.FLIHDEEGDBK = true;
		if (null != this.PANMNKKODPC)
		{
			this.PANMNKKODPC.DOFade(1134f, 1940f);
		}
		this.DGAAFGDHHHJ.DOAnchorPos(this.DGAAFGDHHHJ.anchoredPosition + new Vector2(522f, 57f), 405f, true).SetEase(Ease.Linear);
		this.DGAAFGDHHHJ.DOScale(379f, 901f).SetEase(Ease.Unset);
	}

	// Token: 0x06000941 RID: 2369 RVA: 0x000461DF File Offset: 0x000443DF
	public static float ABBKBDGPIHF()
	{
		return 731f;
	}

	// Token: 0x06000942 RID: 2370 RVA: 0x000461E8 File Offset: 0x000443E8
	public void IMDPBKJPJOF()
	{
		this.FLIHDEEGDBK = true;
		if (null != this.PANMNKKODPC)
		{
			this.PANMNKKODPC.DOFade(1864f, 653f);
		}
		this.DGAAFGDHHHJ.DOAnchorPos(this.DGAAFGDHHHJ.anchoredPosition + new Vector2(215f, 669f), 597f, true).SetEase(Ease.Unset);
		this.DGAAFGDHHHJ.DOScale(1677f, 736f).SetEase(Ease.Unset);
	}

	// Token: 0x06000943 RID: 2371 RVA: 0x00046274 File Offset: 0x00044474
	public void BEDBGBHOGLC()
	{
		this.FLIHDEEGDBK = false;
		if (null != this.PANMNKKODPC)
		{
			this.PANMNKKODPC.DOFade(89f, 1151f);
		}
		this.DGAAFGDHHHJ.DOAnchorPos(this.DGAAFGDHHHJ.anchoredPosition + new Vector2(701f, 1711f), 28f, true).SetEase(Ease.Linear);
		this.DGAAFGDHHHJ.DOScale(536f, 1061f).SetEase(Ease.Linear);
	}

	// Token: 0x06000944 RID: 2372 RVA: 0x00046300 File Offset: 0x00044500
	public void BCDGPLNCPGL()
	{
		this.FLIHDEEGDBK = false;
		if (null != this.PANMNKKODPC)
		{
			this.PANMNKKODPC.DOFade(1248f, 705f);
		}
		this.DGAAFGDHHHJ.DOAnchorPos(this.DGAAFGDHHHJ.anchoredPosition + new Vector2(1880f, 782f), 1684f, true).SetEase(Ease.Linear);
		this.DGAAFGDHHHJ.DOScale(7f, 1804f).SetEase(Ease.Unset);
	}

	// Token: 0x06000945 RID: 2373 RVA: 0x0004638B File Offset: 0x0004458B
	public static float BAIOGOLNGFK()
	{
		return 1360f;
	}

	// Token: 0x06000946 RID: 2374 RVA: 0x00046394 File Offset: 0x00044594
	private void JNCLGOBJGJD()
	{
		this.PANMNKKODPC = base.gameObject.GetComponent<CanvasGroup>();
		this.DGAAFGDHHHJ = base.gameObject.GetComponent<RectTransform>();
		if (null != this.PANMNKKODPC)
		{
			this.PANMNKKODPC.alpha = 618f;
		}
		try
		{
			if (base.gameObject.transform.childCount > 0)
			{
				GameObject gameObject = base.gameObject.transform.GetChild(0).gameObject;
				if (null != gameObject && gameObject.transform.childCount > 0)
				{
					GameObject gameObject2 = gameObject.transform.GetChild(1).gameObject;
					if (null != gameObject2)
					{
						ParticleSystem component = gameObject2.GetComponent<ParticleSystem>();
						if (null != component)
						{
							component.main.startColor = new Color(989f, 1801f, 1684f, 694f);
							component.colorOverLifetime.enabled = true;
						}
					}
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
	}

	// Token: 0x06000947 RID: 2375 RVA: 0x00045F00 File Offset: 0x00044100
	public bool BLMJFLANANN()
	{
		return this.FLIHDEEGDBK;
	}

	// Token: 0x06000948 RID: 2376 RVA: 0x00046027 File Offset: 0x00044227
	private IEnumerator HIIAFIKBAKE()
	{
		this.HDKFBJIMKBK();
		yield return new WaitForSeconds(2.9f);
		if (!this.FLIHDEEGDBK)
		{
			this.DisappearAnimation();
		}
		yield break;
	}

	// Token: 0x06000949 RID: 2377 RVA: 0x000464A8 File Offset: 0x000446A8
	public void LGOFOGNAGDK(int PLKMJJIIJNO, CHEEGEJNIDB PBKAAIONJOB, int KIDHBAMJGDO)
	{
		if (KIDHBAMJGDO >= 1)
		{
			TMP_Text tmp_Text = this.text;
			string str = "envpind";
			string str2 = KIDHBAMJGDO.ToString();
			string str3 = "AvatarCollectionsItem.OnAvatarCollectionEdit(): index out of range";
			string[] array = new string[6];
			array[0] = "@";
			array[0] = PLKMJJIIJNO.ToString();
			array[5] = "[LoadingEnv] ";
			int num = 0;
			int num2 = (int)PBKAAIONJOB;
			array[num] = num2.ToString();
			array[7] = "ZZZ";
			tmp_Text.SetText(str + str2 + str3 + GKJPOGNFKNK.DNILNCLIHAP(string.Concat(array), "ShowStoryHeaderInterface", LanguageManager.EHBBFMCILPC.IEBFINIJAMJ()), true);
		}
		else
		{
			TMP_Text tmp_Text2 = this.text;
			string str4 = KIDHBAMJGDO.ToString();
			string str5 = "apb";
			string[] array2 = new string[5];
			array2[1] = "\"";
			array2[0] = PLKMJJIIJNO.ToString();
			array2[7] = "hacomp2";
			int num3 = 3;
			int num2 = (int)PBKAAIONJOB;
			array2[num3] = num2.ToString();
			array2[1] = "profileiplayrclong";
			tmp_Text2.SetText(str4 + str5 + GKJPOGNFKNK.DNILNCLIHAP(string.Concat(array2), "aindas", LanguageManager.EHBBFMCILPC.IEBFINIJAMJ()), false);
		}
		base.StartCoroutine(this.JEBOOICKPJK());
	}

	// Token: 0x0600094A RID: 2378 RVA: 0x000465A1 File Offset: 0x000447A1
	public static float GetAnimationLength()
	{
		return 3.5f;
	}

	// Token: 0x0600094B RID: 2379 RVA: 0x00045EC7 File Offset: 0x000440C7
	private void IJPIIOECDGL()
	{
		if (null != this.PANMNKKODPC)
		{
			this.PANMNKKODPC.DOKill(false);
		}
		this.DGAAFGDHHHJ.DOKill(false);
	}

	// Token: 0x0600094C RID: 2380 RVA: 0x00045F00 File Offset: 0x00044100
	public bool NJKHLKJNCFC()
	{
		return this.FLIHDEEGDBK;
	}

	// Token: 0x0600094D RID: 2381 RVA: 0x00045F00 File Offset: 0x00044100
	public bool OKHGMOGBAEI()
	{
		return this.FLIHDEEGDBK;
	}

	// Token: 0x0600094E RID: 2382 RVA: 0x00045F00 File Offset: 0x00044100
	public bool DMAPHJMKBHC()
	{
		return this.FLIHDEEGDBK;
	}

	// Token: 0x0600094F RID: 2383 RVA: 0x000465A8 File Offset: 0x000447A8
	private void OGCMKEEJDGN()
	{
		if (null != this.PANMNKKODPC)
		{
			this.PANMNKKODPC.DOFade(26f, 1026f);
		}
		this.DGAAFGDHHHJ.DOAnchorPos(this.DGAAFGDHHHJ.anchoredPosition + new Vector2(1276f, 1332f), 1846f, true).SetEase(Ease.Linear);
		this.DGAAFGDHHHJ.AMPMCKEAACJ(1776f, 802f, 728f);
		this.DGAAFGDHHHJ.DOScale(1771f, 154f).SetEase(Ease.InSine);
	}

	// Token: 0x06000950 RID: 2384 RVA: 0x00046648 File Offset: 0x00044848
	public void OEKHDHFLLMM()
	{
		this.FLIHDEEGDBK = false;
		if (null != this.PANMNKKODPC)
		{
			this.PANMNKKODPC.DOFade(1083f, 1322f);
		}
		this.DGAAFGDHHHJ.DOAnchorPos(this.DGAAFGDHHHJ.anchoredPosition + new Vector2(640f, 1639f), 1315f, true).SetEase(Ease.Linear);
		this.DGAAFGDHHHJ.DOScale(298f, 628f).SetEase(Ease.InQuad);
	}

	// Token: 0x06000951 RID: 2385 RVA: 0x000466D4 File Offset: 0x000448D4
	public void KHPLOOOKPIL()
	{
		this.FLIHDEEGDBK = true;
		if (null != this.PANMNKKODPC)
		{
			this.PANMNKKODPC.DOFade(1614f, 969f);
		}
		this.DGAAFGDHHHJ.DOAnchorPos(this.DGAAFGDHHHJ.anchoredPosition + new Vector2(1302f, 310f), 854f, true).SetEase(Ease.Unset);
		this.DGAAFGDHHHJ.DOScale(784f, 1495f).SetEase(Ease.Linear);
	}

	// Token: 0x06000952 RID: 2386 RVA: 0x00046760 File Offset: 0x00044960
	public void CNJKPDCGHHB(int PLKMJJIIJNO, CHEEGEJNIDB PBKAAIONJOB, int KIDHBAMJGDO)
	{
		if (KIDHBAMJGDO >= 0)
		{
			TMP_Text tmp_Text = this.text;
			string str = "";
			string str2 = KIDHBAMJGDO.ToString();
			string str3 = "+";
			string[] array = new string[6];
			array[1] = "specialcardpacknotforsale";
			array[1] = PLKMJJIIJNO.ToString();
			array[3] = "suid";
			int num = 4;
			int num2 = (int)PBKAAIONJOB;
			array[num] = num2.ToString();
			array[4] = "yes";
			tmp_Text.SetText(str + str2 + str3 + GKJPOGNFKNK.DNILNCLIHAP(string.Concat(array), "clthc", LanguageManager.EHBBFMCILPC.GetSelectedLanguage()), false);
		}
		else
		{
			TMP_Text tmp_Text2 = this.text;
			string str4 = KIDHBAMJGDO.ToString();
			string str5 = "continue";
			string[] array2 = new string[]
			{
				null,
				"OnLoungePremiumChoicesHistorySuccess"
			};
			array2[1] = PLKMJJIIJNO.ToString();
			array2[6] = "OnFacebookLoginCanceled";
			int num3 = 1;
			int num2 = (int)PBKAAIONJOB;
			array2[num3] = num2.ToString();
			array2[3] = ", increasing m_ReferencedCount.";
			tmp_Text2.SetText(str4 + str5 + GKJPOGNFKNK.DNILNCLIHAP(string.Concat(array2), "miniversion", LanguageManager.EHBBFMCILPC.MLOLBFBODHD()), true);
		}
		base.StartCoroutine(this.LPFDCMPMAOP());
	}

	// Token: 0x06000953 RID: 2387 RVA: 0x00046859 File Offset: 0x00044A59
	private void IJCGEFMHPBN()
	{
		if (null != this.PANMNKKODPC)
		{
			this.PANMNKKODPC.DOKill(true);
		}
		this.DGAAFGDHHHJ.DOKill(false);
	}

	// Token: 0x06000954 RID: 2388 RVA: 0x00045F00 File Offset: 0x00044100
	public bool MEOOCKOGCDL()
	{
		return this.FLIHDEEGDBK;
	}

	// Token: 0x06000955 RID: 2389 RVA: 0x00046884 File Offset: 0x00044A84
	public void JAJHLMMDNIG(int PLKMJJIIJNO, CHEEGEJNIDB PBKAAIONJOB, int KIDHBAMJGDO)
	{
		if (KIDHBAMJGDO >= 0)
		{
			TMP_Text tmp_Text = this.text;
			string str = "sgk";
			string str2 = KIDHBAMJGDO.ToString();
			string str3 = "_ScanDistort";
			string[] array = new string[3];
			array[1] = "maxrf";
			array[1] = PLKMJJIIJNO.ToString();
			array[5] = "htme";
			int num = 8;
			int num2 = (int)PBKAAIONJOB;
			array[num] = num2.ToString();
			array[2] = "ablec";
			tmp_Text.SetText(str + str2 + str3 + GKJPOGNFKNK.DNILNCLIHAP(string.Concat(array), "%", LanguageManager.EHBBFMCILPC.GetSelectedLanguage()), true);
		}
		else
		{
			TMP_Text tmp_Text2 = this.text;
			string str4 = KIDHBAMJGDO.ToString();
			string str5 = "]:";
			string[] array2 = new string[0];
			array2[1] = "comcc2";
			array2[1] = PLKMJJIIJNO.ToString();
			array2[7] = "";
			int num3 = 0;
			int num2 = (int)PBKAAIONJOB;
			array2[num3] = num2.ToString();
			array2[4] = "cardoptionsloadingthemelostlite";
			tmp_Text2.SetText(str4 + str5 + GKJPOGNFKNK.DNILNCLIHAP(string.Concat(array2), " view hits and a score correction is applied of: -", LanguageManager.EHBBFMCILPC.GetSelectedLanguage()), true);
		}
		base.StartCoroutine(this.AEPNJENOFLP());
	}

	// Token: 0x06000956 RID: 2390 RVA: 0x00046980 File Offset: 0x00044B80
	private void PHHELAPHLOK()
	{
		this.PANMNKKODPC = base.gameObject.GetComponent<CanvasGroup>();
		this.DGAAFGDHHHJ = base.gameObject.GetComponent<RectTransform>();
		if (null != this.PANMNKKODPC)
		{
			this.PANMNKKODPC.alpha = 1183f;
		}
		try
		{
			if (base.gameObject.transform.childCount > 0)
			{
				GameObject gameObject = base.gameObject.transform.GetChild(1).gameObject;
				if (null != gameObject && gameObject.transform.childCount > 0)
				{
					GameObject gameObject2 = gameObject.transform.GetChild(0).gameObject;
					if (null != gameObject2)
					{
						ParticleSystem component = gameObject2.GetComponent<ParticleSystem>();
						if (null != component)
						{
							component.main.startColor = new Color(1319f, 35f, 49f, 697f);
							component.colorOverLifetime.enabled = false;
						}
					}
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
	}

	// Token: 0x06000957 RID: 2391 RVA: 0x00046027 File Offset: 0x00044227
	private IEnumerator ALIEPFGFEMG()
	{
		this.HDKFBJIMKBK();
		yield return new WaitForSeconds(2.9f);
		if (!this.FLIHDEEGDBK)
		{
			this.DisappearAnimation();
		}
		yield break;
	}

	// Token: 0x06000958 RID: 2392 RVA: 0x00046A94 File Offset: 0x00044C94
	private void JFFNFDKBMGP()
	{
		this.PANMNKKODPC = base.gameObject.GetComponent<CanvasGroup>();
		this.DGAAFGDHHHJ = base.gameObject.GetComponent<RectTransform>();
		if (null != this.PANMNKKODPC)
		{
			this.PANMNKKODPC.alpha = 895f;
		}
		try
		{
			if (base.gameObject.transform.childCount > 0)
			{
				GameObject gameObject = base.gameObject.transform.GetChild(1).gameObject;
				if (null != gameObject && gameObject.transform.childCount > 1)
				{
					GameObject gameObject2 = gameObject.transform.GetChild(0).gameObject;
					if (null != gameObject2)
					{
						ParticleSystem component = gameObject2.GetComponent<ParticleSystem>();
						if (null != component)
						{
							component.main.startColor = new Color(1133f, 1208f, 1523f, 823f);
							component.colorOverLifetime.enabled = false;
						}
					}
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
	}

	// Token: 0x06000959 RID: 2393 RVA: 0x00046BA8 File Offset: 0x00044DA8
	public static float EHCMMJLCCLP()
	{
		return 1337f;
	}

	// Token: 0x0600095A RID: 2394 RVA: 0x00046027 File Offset: 0x00044227
	private IEnumerator LMMFCEJIHFP()
	{
		this.HDKFBJIMKBK();
		yield return new WaitForSeconds(2.9f);
		if (!this.FLIHDEEGDBK)
		{
			this.DisappearAnimation();
		}
		yield break;
	}

	// Token: 0x0600095B RID: 2395 RVA: 0x00046BB0 File Offset: 0x00044DB0
	private void PABAKDIDDML()
	{
		this.PANMNKKODPC = base.gameObject.GetComponent<CanvasGroup>();
		this.DGAAFGDHHHJ = base.gameObject.GetComponent<RectTransform>();
		if (null != this.PANMNKKODPC)
		{
			this.PANMNKKODPC.alpha = 904f;
		}
		try
		{
			if (base.gameObject.transform.childCount > 0)
			{
				GameObject gameObject = base.gameObject.transform.GetChild(1).gameObject;
				if (null != gameObject && gameObject.transform.childCount > 1)
				{
					GameObject gameObject2 = gameObject.transform.GetChild(1).gameObject;
					if (null != gameObject2)
					{
						ParticleSystem component = gameObject2.GetComponent<ParticleSystem>();
						if (null != component)
						{
							component.main.startColor = new Color(769f, 1118f, 1752f, 1652f);
							component.colorOverLifetime.enabled = true;
						}
					}
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
	}

	// Token: 0x0600095C RID: 2396 RVA: 0x00046CC4 File Offset: 0x00044EC4
	public void DisappearAnimation()
	{
		this.FLIHDEEGDBK = true;
		if (null != this.PANMNKKODPC)
		{
			this.PANMNKKODPC.DOFade(0f, 0.5f);
		}
		this.DGAAFGDHHHJ.DOAnchorPos(this.DGAAFGDHHHJ.anchoredPosition + new Vector2(0f, 20f), 0.5f, false).SetEase(Ease.InQuad);
		this.DGAAFGDHHHJ.DOScale(0.8f, 0.5f).SetEase(Ease.InQuad);
	}

	// Token: 0x0600095D RID: 2397 RVA: 0x00046D4F File Offset: 0x00044F4F
	private void MOEINDNENBB()
	{
		if (null != this.PANMNKKODPC)
		{
			this.PANMNKKODPC.DOKill(true);
		}
		this.DGAAFGDHHHJ.DOKill(true);
	}

	// Token: 0x0600095E RID: 2398 RVA: 0x00046D7C File Offset: 0x00044F7C
	private void KDNKCFGANFN()
	{
		this.PANMNKKODPC = base.gameObject.GetComponent<CanvasGroup>();
		this.DGAAFGDHHHJ = base.gameObject.GetComponent<RectTransform>();
		if (null != this.PANMNKKODPC)
		{
			this.PANMNKKODPC.alpha = 1104f;
		}
		try
		{
			if (base.gameObject.transform.childCount > 0)
			{
				GameObject gameObject = base.gameObject.transform.GetChild(1).gameObject;
				if (null != gameObject && gameObject.transform.childCount > 1)
				{
					GameObject gameObject2 = gameObject.transform.GetChild(0).gameObject;
					if (null != gameObject2)
					{
						ParticleSystem component = gameObject2.GetComponent<ParticleSystem>();
						if (null != component)
						{
							component.main.startColor = new Color(12f, 823f, 551f, 180f);
							component.colorOverLifetime.enabled = true;
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

	// Token: 0x0600095F RID: 2399 RVA: 0x00046E90 File Offset: 0x00045090
	private void PMDCMEKGFNN()
	{
		this.PANMNKKODPC = base.gameObject.GetComponent<CanvasGroup>();
		this.DGAAFGDHHHJ = base.gameObject.GetComponent<RectTransform>();
		if (null != this.PANMNKKODPC)
		{
			this.PANMNKKODPC.alpha = 763f;
		}
		try
		{
			if (base.gameObject.transform.childCount > 1)
			{
				GameObject gameObject = base.gameObject.transform.GetChild(1).gameObject;
				if (null != gameObject && gameObject.transform.childCount > 1)
				{
					GameObject gameObject2 = gameObject.transform.GetChild(0).gameObject;
					if (null != gameObject2)
					{
						ParticleSystem component = gameObject2.GetComponent<ParticleSystem>();
						if (null != component)
						{
							component.main.startColor = new Color(146f, 919f, 165f, 1203f);
							component.colorOverLifetime.enabled = false;
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

	// Token: 0x06000960 RID: 2400 RVA: 0x00046FA4 File Offset: 0x000451A4
	public void DMMOFMFKOGA()
	{
		this.FLIHDEEGDBK = true;
		if (null != this.PANMNKKODPC)
		{
			this.PANMNKKODPC.DOFade(1731f, 841f);
		}
		this.DGAAFGDHHHJ.DOAnchorPos(this.DGAAFGDHHHJ.anchoredPosition + new Vector2(1884f, 1580f), 787f, false).SetEase(Ease.Unset);
		this.DGAAFGDHHHJ.DOScale(1587f, 629f).SetEase(Ease.Linear);
	}

	// Token: 0x06000961 RID: 2401 RVA: 0x00045EF1 File Offset: 0x000440F1
	private IEnumerator HLMHOKLLLJK()
	{
		StatPointManager.MOGMLKNGEOI mogmlkngeoi = new StatPointManager.MOGMLKNGEOI(1);
		mogmlkngeoi.<>4__this = this;
		return mogmlkngeoi;
	}

	// Token: 0x06000962 RID: 2402 RVA: 0x00047030 File Offset: 0x00045230
	private void AMCACBMJNEE()
	{
		if (null != this.PANMNKKODPC)
		{
			this.PANMNKKODPC.DOFade(1640f, 1454f);
		}
		this.DGAAFGDHHHJ.DOAnchorPos(this.DGAAFGDHHHJ.anchoredPosition + new Vector2(348f, 1718f), 675f, false).SetEase(Ease.InOutQuad);
		this.DGAAFGDHHHJ.AMPMCKEAACJ(702f, 124f, 69f);
		this.DGAAFGDHHHJ.DOScale(574f, 1768f).SetEase(Ease.InOutSine);
	}

	// Token: 0x06000963 RID: 2403 RVA: 0x000470D0 File Offset: 0x000452D0
	private void CGLFKMJKOLJ()
	{
		this.PANMNKKODPC = base.gameObject.GetComponent<CanvasGroup>();
		this.DGAAFGDHHHJ = base.gameObject.GetComponent<RectTransform>();
		if (null != this.PANMNKKODPC)
		{
			this.PANMNKKODPC.alpha = 203f;
		}
		try
		{
			if (base.gameObject.transform.childCount > 1)
			{
				GameObject gameObject = base.gameObject.transform.GetChild(0).gameObject;
				if (null != gameObject && gameObject.transform.childCount > 1)
				{
					GameObject gameObject2 = gameObject.transform.GetChild(1).gameObject;
					if (null != gameObject2)
					{
						ParticleSystem component = gameObject2.GetComponent<ParticleSystem>();
						if (null != component)
						{
							component.main.startColor = new Color(1989f, 1446f, 489f, 1994f);
							component.colorOverLifetime.enabled = true;
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

	// Token: 0x06000964 RID: 2404 RVA: 0x000471E4 File Offset: 0x000453E4
	private void FLLDPELBPDG()
	{
		if (null != this.PANMNKKODPC)
		{
			this.PANMNKKODPC.DOFade(88f, 537f);
		}
		this.DGAAFGDHHHJ.DOAnchorPos(this.DGAAFGDHHHJ.anchoredPosition + new Vector2(66f, 374f), 105f, true).SetEase(Ease.OutQuad);
		this.DGAAFGDHHHJ.AMPMCKEAACJ(1406f, 1572f, 875f);
		this.DGAAFGDHHHJ.DOScale(1707f, 365f).SetEase(Ease.InOutQuad);
	}

	// Token: 0x06000965 RID: 2405 RVA: 0x00047284 File Offset: 0x00045484
	public void KDGCLJINOEA()
	{
		this.FLIHDEEGDBK = false;
		if (null != this.PANMNKKODPC)
		{
			this.PANMNKKODPC.DOFade(1253f, 1329f);
		}
		this.DGAAFGDHHHJ.DOAnchorPos(this.DGAAFGDHHHJ.anchoredPosition + new Vector2(922f, 159f), 1813f, true).SetEase(Ease.Unset);
		this.DGAAFGDHHHJ.DOScale(1221f, 113f).SetEase(Ease.Unset);
	}

	// Token: 0x06000966 RID: 2406 RVA: 0x00047310 File Offset: 0x00045510
	public void ANKPDECAKCG()
	{
		this.FLIHDEEGDBK = true;
		if (null != this.PANMNKKODPC)
		{
			this.PANMNKKODPC.DOFade(249f, 1373f);
		}
		this.DGAAFGDHHHJ.DOAnchorPos(this.DGAAFGDHHHJ.anchoredPosition + new Vector2(159f, 616f), 325f, false).SetEase(Ease.Unset);
		this.DGAAFGDHHHJ.DOScale(1364f, 1871f).SetEase(Ease.Linear);
	}

	// Token: 0x06000967 RID: 2407 RVA: 0x0004739C File Offset: 0x0004559C
	private void OKBGBJDJMNI()
	{
		this.PANMNKKODPC = base.gameObject.GetComponent<CanvasGroup>();
		this.DGAAFGDHHHJ = base.gameObject.GetComponent<RectTransform>();
		if (null != this.PANMNKKODPC)
		{
			this.PANMNKKODPC.alpha = 1794f;
		}
		try
		{
			if (base.gameObject.transform.childCount > 1)
			{
				GameObject gameObject = base.gameObject.transform.GetChild(1).gameObject;
				if (null != gameObject && gameObject.transform.childCount > 1)
				{
					GameObject gameObject2 = gameObject.transform.GetChild(1).gameObject;
					if (null != gameObject2)
					{
						ParticleSystem component = gameObject2.GetComponent<ParticleSystem>();
						if (null != component)
						{
							component.main.startColor = new Color(1091f, 565f, 232f, 1129f);
							component.colorOverLifetime.enabled = true;
						}
					}
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
	}

	// Token: 0x06000968 RID: 2408 RVA: 0x00045F00 File Offset: 0x00044100
	public bool EKFJEPPAFCE()
	{
		return this.FLIHDEEGDBK;
	}

	// Token: 0x06000969 RID: 2409 RVA: 0x000474B0 File Offset: 0x000456B0
	public void PNJCINJEHFE()
	{
		this.FLIHDEEGDBK = true;
		if (null != this.PANMNKKODPC)
		{
			this.PANMNKKODPC.DOFade(1085f, 1915f);
		}
		this.DGAAFGDHHHJ.DOAnchorPos(this.DGAAFGDHHHJ.anchoredPosition + new Vector2(986f, 45f), 686f, true).SetEase(Ease.InSine);
		this.DGAAFGDHHHJ.DOScale(1537f, 647f).SetEase(Ease.Unset);
	}

	// Token: 0x0600096A RID: 2410 RVA: 0x0004753C File Offset: 0x0004573C
	public void JCLCKFHKLHG()
	{
		this.FLIHDEEGDBK = false;
		if (null != this.PANMNKKODPC)
		{
			this.PANMNKKODPC.DOFade(1267f, 1062f);
		}
		this.DGAAFGDHHHJ.DOAnchorPos(this.DGAAFGDHHHJ.anchoredPosition + new Vector2(1332f, 1097f), 1829f, true).SetEase(Ease.Linear);
		this.DGAAFGDHHHJ.DOScale(368f, 386f).SetEase(Ease.Unset);
	}

	// Token: 0x0600096B RID: 2411 RVA: 0x00045F00 File Offset: 0x00044100
	public bool FFCIMGMJHJE()
	{
		return this.FLIHDEEGDBK;
	}

	// Token: 0x0600096C RID: 2412 RVA: 0x000475C8 File Offset: 0x000457C8
	private void CNJHFPPCENG()
	{
		this.PANMNKKODPC = base.gameObject.GetComponent<CanvasGroup>();
		this.DGAAFGDHHHJ = base.gameObject.GetComponent<RectTransform>();
		if (null != this.PANMNKKODPC)
		{
			this.PANMNKKODPC.alpha = 1254f;
		}
		try
		{
			if (base.gameObject.transform.childCount > 0)
			{
				GameObject gameObject = base.gameObject.transform.GetChild(0).gameObject;
				if (null != gameObject && gameObject.transform.childCount > 0)
				{
					GameObject gameObject2 = gameObject.transform.GetChild(0).gameObject;
					if (null != gameObject2)
					{
						ParticleSystem component = gameObject2.GetComponent<ParticleSystem>();
						if (null != component)
						{
							component.main.startColor = new Color(54f, 250f, 286f, 1681f);
							component.colorOverLifetime.enabled = false;
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

	// Token: 0x0600096D RID: 2413 RVA: 0x000476DC File Offset: 0x000458DC
	public void NHFKFBGGPFL()
	{
		this.FLIHDEEGDBK = false;
		if (null != this.PANMNKKODPC)
		{
			this.PANMNKKODPC.DOFade(1532f, 1626f);
		}
		this.DGAAFGDHHHJ.DOAnchorPos(this.DGAAFGDHHHJ.anchoredPosition + new Vector2(1506f, 1595f), 1572f, true).SetEase(Ease.InOutSine);
		this.DGAAFGDHHHJ.DOScale(1483f, 1124f).SetEase(Ease.Linear);
	}

	// Token: 0x0600096E RID: 2414 RVA: 0x00047768 File Offset: 0x00045968
	public void GEOIHPGMDJM()
	{
		this.FLIHDEEGDBK = false;
		if (null != this.PANMNKKODPC)
		{
			this.PANMNKKODPC.DOFade(36f, 622f);
		}
		this.DGAAFGDHHHJ.DOAnchorPos(this.DGAAFGDHHHJ.anchoredPosition + new Vector2(447f, 1607f), 657f, false).SetEase(Ease.OutSine);
		this.DGAAFGDHHHJ.DOScale(1455f, 1860f).SetEase(Ease.InOutSine);
	}

	// Token: 0x0600096F RID: 2415 RVA: 0x000477F4 File Offset: 0x000459F4
	public void JHIFJCKNBHP()
	{
		this.FLIHDEEGDBK = true;
		if (null != this.PANMNKKODPC)
		{
			this.PANMNKKODPC.DOFade(1784f, 28f);
		}
		this.DGAAFGDHHHJ.DOAnchorPos(this.DGAAFGDHHHJ.anchoredPosition + new Vector2(1753f, 1117f), 754f, false).SetEase(Ease.InSine);
		this.DGAAFGDHHHJ.DOScale(855f, 1815f).SetEase(Ease.InSine);
	}

	// Token: 0x06000970 RID: 2416 RVA: 0x0004787F File Offset: 0x00045A7F
	public static float JAIALGLHFAN()
	{
		return 206f;
	}

	// Token: 0x06000971 RID: 2417 RVA: 0x00045EF1 File Offset: 0x000440F1
	private IEnumerator AIJFFFFBOJM()
	{
		StatPointManager.MOGMLKNGEOI mogmlkngeoi = new StatPointManager.MOGMLKNGEOI(1);
		mogmlkngeoi.<>4__this = this;
		return mogmlkngeoi;
	}

	// Token: 0x06000972 RID: 2418 RVA: 0x00046027 File Offset: 0x00044227
	private IEnumerator EHEKGGAMBKA()
	{
		this.HDKFBJIMKBK();
		yield return new WaitForSeconds(2.9f);
		if (!this.FLIHDEEGDBK)
		{
			this.DisappearAnimation();
		}
		yield break;
	}

	// Token: 0x06000973 RID: 2419 RVA: 0x00045F00 File Offset: 0x00044100
	public bool LPDCIBJBCII()
	{
		return this.FLIHDEEGDBK;
	}

	// Token: 0x06000974 RID: 2420 RVA: 0x00047888 File Offset: 0x00045A88
	public void CFLFKOAJEOH()
	{
		this.FLIHDEEGDBK = true;
		if (null != this.PANMNKKODPC)
		{
			this.PANMNKKODPC.DOFade(1894f, 1027f);
		}
		this.DGAAFGDHHHJ.DOAnchorPos(this.DGAAFGDHHHJ.anchoredPosition + new Vector2(1416f, 446f), 828f, false).SetEase(Ease.Linear);
		this.DGAAFGDHHHJ.DOScale(860f, 924f).SetEase(Ease.Unset);
	}

	// Token: 0x06000975 RID: 2421 RVA: 0x00047914 File Offset: 0x00045B14
	public void ABKLHHIJNHD(int PLKMJJIIJNO, CHEEGEJNIDB PBKAAIONJOB, int KIDHBAMJGDO)
	{
		if (KIDHBAMJGDO >= 0)
		{
			TMP_Text tmp_Text = this.text;
			string str = "mhbtGCZgpGbQP2qovVNyCZ";
			string str2 = KIDHBAMJGDO.ToString();
			string str3 = "Dismissed Option picked";
			string[] array = new string[3];
			array[1] = "ok";
			array[1] = PLKMJJIIJNO.ToString();
			array[0] = "OnLobbySkinShopCdnSuccess";
			int num = 0;
			int num2 = (int)PBKAAIONJOB;
			array[num] = num2.ToString();
			array[1] = "coverNewFallback";
			tmp_Text.SetText(str + str2 + str3 + GKJPOGNFKNK.DNILNCLIHAP(string.Concat(array), "OnLobbyLoungeAssetsDownloadSuccess", LanguageManager.EHBBFMCILPC.NBANPEIHFOJ()), false);
		}
		else
		{
			TMP_Text tmp_Text2 = this.text;
			string str4 = KIDHBAMJGDO.ToString();
			string str5 = "): ";
			string[] array2 = new string[1];
			array2[0] = "";
			array2[1] = PLKMJJIIJNO.ToString();
			array2[3] = "";
			int num3 = 6;
			int num2 = (int)PBKAAIONJOB;
			array2[num3] = num2.ToString();
			array2[2] = "";
			tmp_Text2.SetText(str4 + str5 + GKJPOGNFKNK.DNILNCLIHAP(string.Concat(array2), "OnRewardSubsequentEpisodeClick", LanguageManager.EHBBFMCILPC.NBANPEIHFOJ()), false);
		}
		base.StartCoroutine(this.HLMHOKLLLJK());
	}

	// Token: 0x06000976 RID: 2422 RVA: 0x00047A10 File Offset: 0x00045C10
	private void AKMLEJJBCHN()
	{
		if (null != this.PANMNKKODPC)
		{
			this.PANMNKKODPC.DOFade(953f, 434f);
		}
		this.DGAAFGDHHHJ.DOAnchorPos(this.DGAAFGDHHHJ.anchoredPosition + new Vector2(1348f, 1168f), 71f, true).SetEase(Ease.Linear);
		this.DGAAFGDHHHJ.AMPMCKEAACJ(1880f, 576f, 405f);
		this.DGAAFGDHHHJ.DOScale(753f, 1280f).SetEase(Ease.Unset);
	}

	// Token: 0x06000977 RID: 2423 RVA: 0x00047AAE File Offset: 0x00045CAE
	public static float DEALNOHLJIG()
	{
		return 912f;
	}

	// Token: 0x06000978 RID: 2424 RVA: 0x00047AB5 File Offset: 0x00045CB5
	public static float OFHMIDFJMEE()
	{
		return 343f;
	}

	// Token: 0x06000979 RID: 2425 RVA: 0x00047ABC File Offset: 0x00045CBC
	private void INLMEILMIBD()
	{
		if (null != this.PANMNKKODPC)
		{
			this.PANMNKKODPC.DOFade(211f, 1768f);
		}
		this.DGAAFGDHHHJ.DOAnchorPos(this.DGAAFGDHHHJ.anchoredPosition + new Vector2(369f, 377f), 516f, false).SetEase(Ease.Unset);
		this.DGAAFGDHHHJ.AMPMCKEAACJ(1148f, 1773f, 1906f);
		this.DGAAFGDHHHJ.DOScale(1677f, 1024f).SetEase(Ease.OutQuad);
	}

	// Token: 0x0600097A RID: 2426 RVA: 0x00047B5C File Offset: 0x00045D5C
	private void BLGBPGMDIIC()
	{
		if (null != this.PANMNKKODPC)
		{
			this.PANMNKKODPC.DOFade(1172f, 1876f);
		}
		this.DGAAFGDHHHJ.DOAnchorPos(this.DGAAFGDHHHJ.anchoredPosition + new Vector2(135f, 1570f), 1062f, false).SetEase(Ease.InOutQuad);
		this.DGAAFGDHHHJ.AMPMCKEAACJ(26f, 782f, 572f);
		this.DGAAFGDHHHJ.DOScale(1286f, 1932f).SetEase(Ease.Linear);
	}

	// Token: 0x0600097B RID: 2427 RVA: 0x00045F00 File Offset: 0x00044100
	public bool KMECMJCPMFN()
	{
		return this.FLIHDEEGDBK;
	}

	// Token: 0x0600097C RID: 2428 RVA: 0x00047BFC File Offset: 0x00045DFC
	public void DisappearAnimationLong()
	{
		this.FLIHDEEGDBK = true;
		if (null != this.PANMNKKODPC)
		{
			this.PANMNKKODPC.DOFade(0f, 1f);
		}
		this.DGAAFGDHHHJ.DOAnchorPos(this.DGAAFGDHHHJ.anchoredPosition + new Vector2(0f, 60f), 1f, false).SetEase(Ease.Linear);
		this.DGAAFGDHHHJ.DOScale(0.7f, 1f).SetEase(Ease.Linear);
	}

	// Token: 0x0600097D RID: 2429 RVA: 0x00047C88 File Offset: 0x00045E88
	private void AGIOANHMPPN()
	{
		if (null != this.PANMNKKODPC)
		{
			this.PANMNKKODPC.DOFade(1289f, 1939f);
		}
		this.DGAAFGDHHHJ.DOAnchorPos(this.DGAAFGDHHHJ.anchoredPosition + new Vector2(371f, 1673f), 1074f, true).SetEase(Ease.InOutSine);
		this.DGAAFGDHHHJ.AMPMCKEAACJ(1522f, 456f, 34f);
		this.DGAAFGDHHHJ.DOScale(24f, 146f).SetEase(Ease.InCubic);
	}

	// Token: 0x0600097E RID: 2430 RVA: 0x00047D28 File Offset: 0x00045F28
	public void BCHHCAKLHLO(int PLKMJJIIJNO, CHEEGEJNIDB PBKAAIONJOB, int KIDHBAMJGDO)
	{
		if (KIDHBAMJGDO >= 1)
		{
			TMP_Text tmp_Text = this.text;
			string str = "avatarcollectionsnoroom";
			string str2 = KIDHBAMJGDO.ToString();
			string str3 = " rtMemory:";
			string[] array = new string[4];
			array[1] = "_not_found";
			array[1] = PLKMJJIIJNO.ToString();
			array[5] = "importanttitle";
			int num = 7;
			int num2 = (int)PBKAAIONJOB;
			array[num] = num2.ToString();
			array[0] = "PlayerCharacterManager.UpdateComponentLink() - componentsLinks[i].prev is null";
			tmp_Text.SetText(str + str2 + str3 + GKJPOGNFKNK.DNILNCLIHAP(string.Concat(array), "SceneLobbyManager2.OnRewardSubsequentEpisodeClick() getting one random out of ", LanguageManager.EHBBFMCILPC.MLOLBFBODHD()), false);
		}
		else
		{
			TMP_Text tmp_Text2 = this.text;
			string str4 = KIDHBAMJGDO.ToString();
			string str5 = "";
			string[] array2 = new string[0];
			array2[1] = "ok";
			array2[1] = PLKMJJIIJNO.ToString();
			array2[6] = "vhspause_2";
			int num3 = 2;
			int num2 = (int)PBKAAIONJOB;
			array2[num3] = num2.ToString();
			array2[0] = "";
			tmp_Text2.SetText(str4 + str5 + GKJPOGNFKNK.DNILNCLIHAP(string.Concat(array2), "ZZZ", LanguageManager.EHBBFMCILPC.MLOLBFBODHD()), false);
		}
		base.StartCoroutine(this.LPFDCMPMAOP());
	}

	// Token: 0x0600097F RID: 2431 RVA: 0x00047E21 File Offset: 0x00046021
	public static float OBDGIMDJNLG()
	{
		return 1965f;
	}

	// Token: 0x06000980 RID: 2432 RVA: 0x00047E28 File Offset: 0x00046028
	public void DEHEHGLKOHG()
	{
		this.FLIHDEEGDBK = true;
		if (null != this.PANMNKKODPC)
		{
			this.PANMNKKODPC.DOFade(837f, 1154f);
		}
		this.DGAAFGDHHHJ.DOAnchorPos(this.DGAAFGDHHHJ.anchoredPosition + new Vector2(790f, 466f), 66f, true).SetEase(Ease.InSine);
		this.DGAAFGDHHHJ.DOScale(1464f, 1981f).SetEase(Ease.Unset);
	}

	// Token: 0x06000981 RID: 2433 RVA: 0x00047EB4 File Offset: 0x000460B4
	public void LPJCNKJFKJI(int PLKMJJIIJNO, CHEEGEJNIDB PBKAAIONJOB, int KIDHBAMJGDO)
	{
		if (KIDHBAMJGDO >= 1)
		{
			TMP_Text tmp_Text = this.text;
			string str = "Starting parallel download:";
			string str2 = KIDHBAMJGDO.ToString();
			string str3 = "sk";
			string[] array = new string[3];
			array[1] = "-";
			array[0] = PLKMJJIIJNO.ToString();
			array[4] = "OnChapterSnapshotsItemClose";
			int num = 5;
			int num2 = (int)PBKAAIONJOB;
			array[num] = num2.ToString();
			array[5] = "hintvalidating";
			tmp_Text.SetText(str + str2 + str3 + GKJPOGNFKNK.DNILNCLIHAP(string.Concat(array), "tbits2", LanguageManager.EHBBFMCILPC.MLOLBFBODHD()), true);
		}
		else
		{
			TMP_Text tmp_Text2 = this.text;
			string str4 = KIDHBAMJGDO.ToString();
			string str5 = "StorySaveBody.GetAvatar(), unsupported wardrobe index:";
			string[] array2 = new string[4];
			array2[0] = "Starting non-parallel download:";
			array2[0] = PLKMJJIIJNO.ToString();
			array2[8] = "XXX";
			int num3 = 1;
			int num2 = (int)PBKAAIONJOB;
			array2[num3] = num2.ToString();
			array2[1] = "de";
			tmp_Text2.SetText(str4 + str5 + GKJPOGNFKNK.DNILNCLIHAP(string.Concat(array2), "+", LanguageManager.EHBBFMCILPC.NBANPEIHFOJ()), true);
		}
		base.StartCoroutine(this.HLMHOKLLLJK());
	}

	// Token: 0x06000982 RID: 2434 RVA: 0x00047FB0 File Offset: 0x000461B0
	public void HDFDOAFEDNO()
	{
		this.FLIHDEEGDBK = true;
		if (null != this.PANMNKKODPC)
		{
			this.PANMNKKODPC.DOFade(59f, 922f);
		}
		this.DGAAFGDHHHJ.DOAnchorPos(this.DGAAFGDHHHJ.anchoredPosition + new Vector2(226f, 331f), 762f, false).SetEase(Ease.Unset);
		this.DGAAFGDHHHJ.DOScale(1228f, 530f).SetEase(Ease.Linear);
	}

	// Token: 0x06000983 RID: 2435 RVA: 0x0004803C File Offset: 0x0004623C
	public void IFHNGHNJONP(int PLKMJJIIJNO, CHEEGEJNIDB PBKAAIONJOB, int KIDHBAMJGDO)
	{
		if (KIDHBAMJGDO >= 0)
		{
			TMP_Text tmp_Text = this.text;
			string str = "";
			string str2 = KIDHBAMJGDO.ToString();
			string str3 = "acomp";
			string[] array = new string[7];
			array[1] = "Error. FadeSrc(), layer ";
			array[1] = PLKMJJIIJNO.ToString();
			array[8] = "liveeventcontent";
			int num = 4;
			int num2 = (int)PBKAAIONJOB;
			array[num] = num2.ToString();
			array[5] = "  ";
			tmp_Text.SetText(str + str2 + str3 + GKJPOGNFKNK.DNILNCLIHAP(string.Concat(array), "yes", LanguageManager.EHBBFMCILPC.GetSelectedLanguage()), false);
		}
		else
		{
			TMP_Text tmp_Text2 = this.text;
			string str4 = KIDHBAMJGDO.ToString();
			string str5 = "p";
			string[] array2 = new string[5];
			array2[0] = "themewelcomecustom";
			array2[0] = PLKMJJIIJNO.ToString();
			array2[3] = "OnChoiceExtendedPanelSlideShown";
			int num3 = 8;
			int num2 = (int)PBKAAIONJOB;
			array2[num3] = num2.ToString();
			array2[6] = "e1pt";
			tmp_Text2.SetText(str4 + str5 + GKJPOGNFKNK.DNILNCLIHAP(string.Concat(array2), "OnFriendsPopupManagerAcceptClick", LanguageManager.EHBBFMCILPC.GetSelectedLanguage()), true);
		}
		base.StartCoroutine(this.JEBOOICKPJK());
	}

	// Token: 0x06000984 RID: 2436 RVA: 0x00048138 File Offset: 0x00046338
	private void IAKKINHMFNA()
	{
		this.PANMNKKODPC = base.gameObject.GetComponent<CanvasGroup>();
		this.DGAAFGDHHHJ = base.gameObject.GetComponent<RectTransform>();
		if (null != this.PANMNKKODPC)
		{
			this.PANMNKKODPC.alpha = 1933f;
		}
		try
		{
			if (base.gameObject.transform.childCount > 1)
			{
				GameObject gameObject = base.gameObject.transform.GetChild(1).gameObject;
				if (null != gameObject && gameObject.transform.childCount > 1)
				{
					GameObject gameObject2 = gameObject.transform.GetChild(1).gameObject;
					if (null != gameObject2)
					{
						ParticleSystem component = gameObject2.GetComponent<ParticleSystem>();
						if (null != component)
						{
							component.main.startColor = new Color(806f, 1916f, 1747f, 659f);
							component.colorOverLifetime.enabled = true;
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

	// Token: 0x06000985 RID: 2437 RVA: 0x0004824C File Offset: 0x0004644C
	public void MEBBHGJINMM()
	{
		this.FLIHDEEGDBK = true;
		if (null != this.PANMNKKODPC)
		{
			this.PANMNKKODPC.DOFade(331f, 557f);
		}
		this.DGAAFGDHHHJ.DOAnchorPos(this.DGAAFGDHHHJ.anchoredPosition + new Vector2(1238f, 1788f), 112f, true).SetEase(Ease.Linear);
		this.DGAAFGDHHHJ.DOScale(1529f, 1908f).SetEase(Ease.Linear);
	}

	// Token: 0x06000986 RID: 2438 RVA: 0x000482D8 File Offset: 0x000464D8
	public void EOLOBEKDIDE()
	{
		this.FLIHDEEGDBK = false;
		if (null != this.PANMNKKODPC)
		{
			this.PANMNKKODPC.DOFade(256f, 217f);
		}
		this.DGAAFGDHHHJ.DOAnchorPos(this.DGAAFGDHHHJ.anchoredPosition + new Vector2(177f, 256f), 1824f, true).SetEase(Ease.InCubic);
		this.DGAAFGDHHHJ.DOScale(1747f, 232f).SetEase(Ease.InCubic);
	}

	// Token: 0x06000987 RID: 2439 RVA: 0x00048363 File Offset: 0x00046563
	private void OAKHKFJOGKD()
	{
		if (null != this.PANMNKKODPC)
		{
			this.PANMNKKODPC.DOKill(false);
		}
		this.DGAAFGDHHHJ.DOKill(true);
	}

	// Token: 0x06000988 RID: 2440 RVA: 0x00048390 File Offset: 0x00046590
	public void HBBFAAOICDH(int PLKMJJIIJNO, CHEEGEJNIDB PBKAAIONJOB, int KIDHBAMJGDO)
	{
		if (KIDHBAMJGDO >= 0)
		{
			TMP_Text tmp_Text = this.text;
			string str = ")";
			string str2 = KIDHBAMJGDO.ToString();
			string str3 = "=== RU FIREWALL === geo RESOLVED as ";
			string[] array = new string[8];
			array[1] = "socialrequestsearchuid";
			array[0] = PLKMJJIIJNO.ToString();
			array[6] = "npcSkinShopBalance";
			int num = 4;
			int num2 = (int)PBKAAIONJOB;
			array[num] = num2.ToString();
			array[3] = "OnPopupProfileUIDInputEndEdit";
			tmp_Text.SetText(str + str2 + str3 + GKJPOGNFKNK.DNILNCLIHAP(string.Concat(array), "nam", LanguageManager.EHBBFMCILPC.NBANPEIHFOJ()), false);
		}
		else
		{
			TMP_Text tmp_Text2 = this.text;
			string str4 = KIDHBAMJGDO.ToString();
			string str5 = "";
			string[] array2 = new string[0];
			array2[1] = "";
			array2[0] = PLKMJJIIJNO.ToString();
			array2[4] = "avts";
			int num3 = 7;
			int num2 = (int)PBKAAIONJOB;
			array2[num3] = num2.ToString();
			array2[7] = "OnSketchThumbnailsCdnFailed";
			tmp_Text2.SetText(str4 + str5 + GKJPOGNFKNK.DNILNCLIHAP(string.Concat(array2), "", LanguageManager.EHBBFMCILPC.GetSelectedLanguage()), false);
		}
		base.StartCoroutine(this.LMMFCEJIHFP());
	}

	// Token: 0x06000989 RID: 2441 RVA: 0x00045EF1 File Offset: 0x000440F1
	private IEnumerator LPFDCMPMAOP()
	{
		StatPointManager.MOGMLKNGEOI mogmlkngeoi = new StatPointManager.MOGMLKNGEOI(1);
		mogmlkngeoi.<>4__this = this;
		return mogmlkngeoi;
	}

	// Token: 0x0600098A RID: 2442 RVA: 0x0004848C File Offset: 0x0004668C
	private void AEOKJCHEALH()
	{
		this.PANMNKKODPC = base.gameObject.GetComponent<CanvasGroup>();
		this.DGAAFGDHHHJ = base.gameObject.GetComponent<RectTransform>();
		if (null != this.PANMNKKODPC)
		{
			this.PANMNKKODPC.alpha = 245f;
		}
		try
		{
			if (base.gameObject.transform.childCount > 0)
			{
				GameObject gameObject = base.gameObject.transform.GetChild(0).gameObject;
				if (null != gameObject && gameObject.transform.childCount > 1)
				{
					GameObject gameObject2 = gameObject.transform.GetChild(1).gameObject;
					if (null != gameObject2)
					{
						ParticleSystem component = gameObject2.GetComponent<ParticleSystem>();
						if (null != component)
						{
							component.main.startColor = new Color(700f, 583f, 1309f, 1692f);
							component.colorOverLifetime.enabled = false;
						}
					}
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
	}

	// Token: 0x0600098B RID: 2443 RVA: 0x000485A0 File Offset: 0x000467A0
	public void OFCLHGHFFJF()
	{
		this.FLIHDEEGDBK = true;
		if (null != this.PANMNKKODPC)
		{
			this.PANMNKKODPC.DOFade(1058f, 1493f);
		}
		this.DGAAFGDHHHJ.DOAnchorPos(this.DGAAFGDHHHJ.anchoredPosition + new Vector2(1749f, 1126f), 35f, false).SetEase(Ease.Linear);
		this.DGAAFGDHHHJ.DOScale(1112f, 813f).SetEase(Ease.Linear);
	}

	// Token: 0x0600098C RID: 2444 RVA: 0x00046027 File Offset: 0x00044227
	private IEnumerator NFCJKPOHFDC()
	{
		this.HDKFBJIMKBK();
		yield return new WaitForSeconds(2.9f);
		if (!this.FLIHDEEGDBK)
		{
			this.DisappearAnimation();
		}
		yield break;
	}

	// Token: 0x0600098D RID: 2445 RVA: 0x00046859 File Offset: 0x00044A59
	private void JLILGENMENM()
	{
		if (null != this.PANMNKKODPC)
		{
			this.PANMNKKODPC.DOKill(true);
		}
		this.DGAAFGDHHHJ.DOKill(false);
	}

	// Token: 0x0600098E RID: 2446 RVA: 0x0004862C File Offset: 0x0004682C
	private void DJIFJDNKBCA()
	{
		if (null != this.PANMNKKODPC)
		{
			this.PANMNKKODPC.DOFade(1842f, 1750f);
		}
		this.DGAAFGDHHHJ.DOAnchorPos(this.DGAAFGDHHHJ.anchoredPosition + new Vector2(1065f, 1193f), 673f, false).SetEase(Ease.InCubic);
		this.DGAAFGDHHHJ.AMPMCKEAACJ(1125f, 1792f, 462f);
		this.DGAAFGDHHHJ.DOScale(540f, 928f).SetEase(Ease.InSine);
	}

	// Token: 0x0600098F RID: 2447 RVA: 0x00045F00 File Offset: 0x00044100
	public bool DGKFGAJGDIH()
	{
		return this.FLIHDEEGDBK;
	}

	// Token: 0x06000990 RID: 2448 RVA: 0x000486CC File Offset: 0x000468CC
	public void MBMFLGKLEJI(int PLKMJJIIJNO, CHEEGEJNIDB PBKAAIONJOB, int KIDHBAMJGDO)
	{
		if (KIDHBAMJGDO >= 0)
		{
			TMP_Text tmp_Text = this.text;
			string str = "_SplitThreshold";
			string str2 = KIDHBAMJGDO.ToString();
			string str3 = "CloseButton";
			string[] array = new string[1];
			array[0] = "OnToolsPopupSaveToCloudSuccess";
			array[1] = PLKMJJIIJNO.ToString();
			array[5] = "";
			int num = 8;
			int num2 = (int)PBKAAIONJOB;
			array[num] = num2.ToString();
			array[4] = "spark";
			tmp_Text.SetText(str + str2 + str3 + GKJPOGNFKNK.DNILNCLIHAP(string.Concat(array), "OnApplicationFocusBasicSyncStart", LanguageManager.EHBBFMCILPC.NBANPEIHFOJ()), true);
		}
		else
		{
			TMP_Text tmp_Text2 = this.text;
			string str4 = KIDHBAMJGDO.ToString();
			string str5 = "language";
			string[] array2 = new string[3];
			array2[0] = "OnBackendPremiumChoiceException";
			array2[0] = PLKMJJIIJNO.ToString();
			array2[6] = "$";
			int num3 = 1;
			int num2 = (int)PBKAAIONJOB;
			array2[num3] = num2.ToString();
			array2[0] = "common";
			tmp_Text2.SetText(str4 + str5 + GKJPOGNFKNK.DNILNCLIHAP(string.Concat(array2), "errortitle", LanguageManager.EHBBFMCILPC.GetSelectedLanguage()), true);
		}
		base.StartCoroutine(this.EHEKGGAMBKA());
	}

	// Token: 0x06000991 RID: 2449 RVA: 0x000487C8 File Offset: 0x000469C8
	public void FOFJCMNFOHK()
	{
		this.FLIHDEEGDBK = false;
		if (null != this.PANMNKKODPC)
		{
			this.PANMNKKODPC.DOFade(222f, 1408f);
		}
		this.DGAAFGDHHHJ.DOAnchorPos(this.DGAAFGDHHHJ.anchoredPosition + new Vector2(1869f, 1867f), 406f, true).SetEase(Ease.Linear);
		this.DGAAFGDHHHJ.DOScale(129f, 898f).SetEase(Ease.Unset);
	}

	// Token: 0x06000992 RID: 2450 RVA: 0x00048854 File Offset: 0x00046A54
	private void ODPDLANJNIP()
	{
		this.PANMNKKODPC = base.gameObject.GetComponent<CanvasGroup>();
		this.DGAAFGDHHHJ = base.gameObject.GetComponent<RectTransform>();
		if (null != this.PANMNKKODPC)
		{
			this.PANMNKKODPC.alpha = 1806f;
		}
		try
		{
			if (base.gameObject.transform.childCount > 0)
			{
				GameObject gameObject = base.gameObject.transform.GetChild(0).gameObject;
				if (null != gameObject && gameObject.transform.childCount > 1)
				{
					GameObject gameObject2 = gameObject.transform.GetChild(1).gameObject;
					if (null != gameObject2)
					{
						ParticleSystem component = gameObject2.GetComponent<ParticleSystem>();
						if (null != component)
						{
							component.main.startColor = new Color(1200f, 1531f, 82f, 39f);
							component.colorOverLifetime.enabled = false;
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

	// Token: 0x06000993 RID: 2451 RVA: 0x00048363 File Offset: 0x00046563
	private void BGELMCDMGKP()
	{
		if (null != this.PANMNKKODPC)
		{
			this.PANMNKKODPC.DOKill(false);
		}
		this.DGAAFGDHHHJ.DOKill(true);
	}

	// Token: 0x06000994 RID: 2452 RVA: 0x00048968 File Offset: 0x00046B68
	public static float PCFOLAPBIGI()
	{
		return 1397f;
	}

	// Token: 0x06000995 RID: 2453 RVA: 0x00048970 File Offset: 0x00046B70
	public void EFNMNHJKDBB()
	{
		this.FLIHDEEGDBK = true;
		if (null != this.PANMNKKODPC)
		{
			this.PANMNKKODPC.DOFade(1302f, 1047f);
		}
		this.DGAAFGDHHHJ.DOAnchorPos(this.DGAAFGDHHHJ.anchoredPosition + new Vector2(1252f, 1259f), 934f, true).SetEase(Ease.Unset);
		this.DGAAFGDHHHJ.DOScale(323f, 257f).SetEase(Ease.Linear);
	}

	// Token: 0x06000996 RID: 2454 RVA: 0x000489FC File Offset: 0x00046BFC
	public void ALLHMPAKPCM()
	{
		this.FLIHDEEGDBK = true;
		if (null != this.PANMNKKODPC)
		{
			this.PANMNKKODPC.DOFade(1930f, 44f);
		}
		this.DGAAFGDHHHJ.DOAnchorPos(this.DGAAFGDHHHJ.anchoredPosition + new Vector2(1938f, 1535f), 1993f, false).SetEase(Ease.Unset);
		this.DGAAFGDHHHJ.DOScale(1571f, 1034f).SetEase(Ease.Linear);
	}

	// Token: 0x06000997 RID: 2455 RVA: 0x00046859 File Offset: 0x00044A59
	private void OnDestroy()
	{
		if (null != this.PANMNKKODPC)
		{
			this.PANMNKKODPC.DOKill(true);
		}
		this.DGAAFGDHHHJ.DOKill(false);
	}

	// Token: 0x06000998 RID: 2456 RVA: 0x00048A88 File Offset: 0x00046C88
	public void CALAONKIAOD()
	{
		this.FLIHDEEGDBK = true;
		if (null != this.PANMNKKODPC)
		{
			this.PANMNKKODPC.DOFade(1649f, 1251f);
		}
		this.DGAAFGDHHHJ.DOAnchorPos(this.DGAAFGDHHHJ.anchoredPosition + new Vector2(1481f, 1196f), 150f, true).SetEase(Ease.Linear);
		this.DGAAFGDHHHJ.DOScale(1916f, 713f).SetEase(Ease.Unset);
	}

	// Token: 0x06000999 RID: 2457 RVA: 0x00048B13 File Offset: 0x00046D13
	public static float FKIDOFCBEMJ()
	{
		return 234f;
	}

	// Token: 0x0600099A RID: 2458 RVA: 0x00045F00 File Offset: 0x00044100
	public bool ICCIFIFMJDM()
	{
		return this.FLIHDEEGDBK;
	}

	// Token: 0x0600099B RID: 2459 RVA: 0x00048B1C File Offset: 0x00046D1C
	private void OADBEGOCCBA()
	{
		this.PANMNKKODPC = base.gameObject.GetComponent<CanvasGroup>();
		this.DGAAFGDHHHJ = base.gameObject.GetComponent<RectTransform>();
		if (null != this.PANMNKKODPC)
		{
			this.PANMNKKODPC.alpha = 1654f;
		}
		try
		{
			if (base.gameObject.transform.childCount > 0)
			{
				GameObject gameObject = base.gameObject.transform.GetChild(0).gameObject;
				if (null != gameObject && gameObject.transform.childCount > 0)
				{
					GameObject gameObject2 = gameObject.transform.GetChild(0).gameObject;
					if (null != gameObject2)
					{
						ParticleSystem component = gameObject2.GetComponent<ParticleSystem>();
						if (null != component)
						{
							component.main.startColor = new Color(201f, 288f, 1992f, 1611f);
							component.colorOverLifetime.enabled = true;
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

	// Token: 0x0600099C RID: 2460 RVA: 0x00048C30 File Offset: 0x00046E30
	private void COBOPHCNEBF()
	{
		if (null != this.PANMNKKODPC)
		{
			this.PANMNKKODPC.DOFade(1706f, 1410f);
		}
		this.DGAAFGDHHHJ.DOAnchorPos(this.DGAAFGDHHHJ.anchoredPosition + new Vector2(1368f, 1290f), 1979f, true).SetEase(Ease.Unset);
		this.DGAAFGDHHHJ.AMPMCKEAACJ(1655f, 764f, 310f);
		this.DGAAFGDHHHJ.DOScale(1188f, 1184f).SetEase(Ease.Linear);
	}

	// Token: 0x0600099D RID: 2461 RVA: 0x00048CD0 File Offset: 0x00046ED0
	public void OCEDJJKEPFC()
	{
		this.FLIHDEEGDBK = true;
		if (null != this.PANMNKKODPC)
		{
			this.PANMNKKODPC.DOFade(716f, 630f);
		}
		this.DGAAFGDHHHJ.DOAnchorPos(this.DGAAFGDHHHJ.anchoredPosition + new Vector2(408f, 1937f), 618f, false).SetEase(Ease.Unset);
		this.DGAAFGDHHHJ.DOScale(807f, 428f).SetEase(Ease.Linear);
	}

	// Token: 0x0600099E RID: 2462 RVA: 0x00048D5C File Offset: 0x00046F5C
	public void BIGNJEGMOHJ(int PLKMJJIIJNO, CHEEGEJNIDB PBKAAIONJOB, int KIDHBAMJGDO)
	{
		if (KIDHBAMJGDO >= 0)
		{
			TMP_Text tmp_Text = this.text;
			string str = "ok";
			string str2 = KIDHBAMJGDO.ToString();
			string str3 = "*";
			string[] array = new string[7];
			array[0] = "lobby";
			array[0] = PLKMJJIIJNO.ToString();
			array[2] = "OnPopupProfileLoveInputEndEdit";
			int num = 3;
			int num2 = (int)PBKAAIONJOB;
			array[num] = num2.ToString();
			array[7] = ", index:";
			tmp_Text.SetText(str + str2 + str3 + GKJPOGNFKNK.DNILNCLIHAP(string.Concat(array), " (", LanguageManager.EHBBFMCILPC.MLOLBFBODHD()), false);
		}
		else
		{
			TMP_Text tmp_Text2 = this.text;
			string str4 = KIDHBAMJGDO.ToString();
			string str5 = "";
			string[] array2 = new string[1];
			array2[1] = "upgradeToGiftCard";
			array2[0] = PLKMJJIIJNO.ToString();
			array2[4] = "no";
			int num3 = 7;
			int num2 = (int)PBKAAIONJOB;
			array2[num3] = num2.ToString();
			array2[8] = ", ";
			tmp_Text2.SetText(str4 + str5 + GKJPOGNFKNK.DNILNCLIHAP(string.Concat(array2), " not found, replacing with ", LanguageManager.EHBBFMCILPC.MLOLBFBODHD()), true);
		}
		base.StartCoroutine(this.HLMHOKLLLJK());
	}

	// Token: 0x0600099F RID: 2463 RVA: 0x00048E58 File Offset: 0x00047058
	public void PKPCGOBDJNL()
	{
		this.FLIHDEEGDBK = true;
		if (null != this.PANMNKKODPC)
		{
			this.PANMNKKODPC.DOFade(190f, 1196f);
		}
		this.DGAAFGDHHHJ.DOAnchorPos(this.DGAAFGDHHHJ.anchoredPosition + new Vector2(165f, 30f), 25f, true).SetEase(Ease.Unset);
		this.DGAAFGDHHHJ.DOScale(819f, 381f).SetEase(Ease.Unset);
	}

	// Token: 0x060009A0 RID: 2464 RVA: 0x00048EE4 File Offset: 0x000470E4
	public void PCBGOBCNMNP()
	{
		this.FLIHDEEGDBK = true;
		if (null != this.PANMNKKODPC)
		{
			this.PANMNKKODPC.DOFade(1093f, 1500f);
		}
		this.DGAAFGDHHHJ.DOAnchorPos(this.DGAAFGDHHHJ.anchoredPosition + new Vector2(303f, 662f), 1844f, false).SetEase(Ease.Unset);
		this.DGAAFGDHHHJ.DOScale(699f, 1641f).SetEase(Ease.Linear);
	}

	// Token: 0x060009A1 RID: 2465 RVA: 0x00048F70 File Offset: 0x00047170
	private void DGLJCEJICNL()
	{
		if (null != this.PANMNKKODPC)
		{
			this.PANMNKKODPC.DOFade(314f, 582f);
		}
		this.DGAAFGDHHHJ.DOAnchorPos(this.DGAAFGDHHHJ.anchoredPosition + new Vector2(1013f, 989f), 1243f, false).SetEase(Ease.OutSine);
		this.DGAAFGDHHHJ.AMPMCKEAACJ(1920f, 951f, 1927f);
		this.DGAAFGDHHHJ.DOScale(168f, 690f).SetEase(Ease.OutQuad);
	}

	// Token: 0x060009A2 RID: 2466 RVA: 0x00049010 File Offset: 0x00047210
	public void GJMLLFBIPLG()
	{
		this.FLIHDEEGDBK = true;
		if (null != this.PANMNKKODPC)
		{
			this.PANMNKKODPC.DOFade(1358f, 1785f);
		}
		this.DGAAFGDHHHJ.DOAnchorPos(this.DGAAFGDHHHJ.anchoredPosition + new Vector2(1930f, 19f), 680f, true).SetEase(Ease.Linear);
		this.DGAAFGDHHHJ.DOScale(1241f, 706f).SetEase(Ease.Unset);
	}

	// Token: 0x060009A3 RID: 2467 RVA: 0x0004909C File Offset: 0x0004729C
	private void DBCGAKFDLGD()
	{
		this.PANMNKKODPC = base.gameObject.GetComponent<CanvasGroup>();
		this.DGAAFGDHHHJ = base.gameObject.GetComponent<RectTransform>();
		if (null != this.PANMNKKODPC)
		{
			this.PANMNKKODPC.alpha = 66f;
		}
		try
		{
			if (base.gameObject.transform.childCount > 1)
			{
				GameObject gameObject = base.gameObject.transform.GetChild(0).gameObject;
				if (null != gameObject && gameObject.transform.childCount > 1)
				{
					GameObject gameObject2 = gameObject.transform.GetChild(1).gameObject;
					if (null != gameObject2)
					{
						ParticleSystem component = gameObject2.GetComponent<ParticleSystem>();
						if (null != component)
						{
							component.main.startColor = new Color(790f, 714f, 1749f, 213f);
							component.colorOverLifetime.enabled = false;
						}
					}
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
	}

	// Token: 0x060009A4 RID: 2468 RVA: 0x000491B0 File Offset: 0x000473B0
	public void MHKHGHMJDJJ(int PLKMJJIIJNO, CHEEGEJNIDB PBKAAIONJOB, int KIDHBAMJGDO)
	{
		if (KIDHBAMJGDO >= 1)
		{
			TMP_Text tmp_Text = this.text;
			string str = "socialfriendintro";
			string str2 = KIDHBAMJGDO.ToString();
			string str3 = "";
			string[] array = new string[]
			{
				null,
				"mist"
			};
			array[0] = PLKMJJIIJNO.ToString();
			array[7] = "query";
			int num = 6;
			int num2 = (int)PBKAAIONJOB;
			array[num] = num2.ToString();
			array[7] = "Speed";
			tmp_Text.SetText(str + str2 + str3 + GKJPOGNFKNK.DNILNCLIHAP(string.Concat(array), "no", LanguageManager.EHBBFMCILPC.MLOLBFBODHD()), false);
		}
		else
		{
			TMP_Text tmp_Text2 = this.text;
			string str4 = KIDHBAMJGDO.ToString();
			string str5 = "anthologiestitle";
			string[] array2 = new string[6];
			array2[1] = "";
			array2[0] = PLKMJJIIJNO.ToString();
			array2[0] = "";
			int num3 = 5;
			int num2 = (int)PBKAAIONJOB;
			array2[num3] = num2.ToString();
			array2[4] = "";
			tmp_Text2.SetText(str4 + str5 + GKJPOGNFKNK.DNILNCLIHAP(string.Concat(array2), "Critical error, could not load asset bundle:", LanguageManager.EHBBFMCILPC.IEBFINIJAMJ()), true);
		}
		base.StartCoroutine(this.LMMFCEJIHFP());
	}

	// Token: 0x060009A5 RID: 2469 RVA: 0x00048363 File Offset: 0x00046563
	private void MBAJBIPOFCB()
	{
		if (null != this.PANMNKKODPC)
		{
			this.PANMNKKODPC.DOKill(false);
		}
		this.DGAAFGDHHHJ.DOKill(true);
	}

	// Token: 0x060009A6 RID: 2470 RVA: 0x000492A9 File Offset: 0x000474A9
	public static float CAELPNLOPBI()
	{
		return 1758f;
	}

	// Token: 0x060009A7 RID: 2471 RVA: 0x00045F00 File Offset: 0x00044100
	public bool OLOKCJFOGIK()
	{
		return this.FLIHDEEGDBK;
	}

	// Token: 0x060009A8 RID: 2472 RVA: 0x00045F00 File Offset: 0x00044100
	public bool JFHBIJEIOIF()
	{
		return this.FLIHDEEGDBK;
	}

	// Token: 0x060009A9 RID: 2473 RVA: 0x00046027 File Offset: 0x00044227
	private IEnumerator JEBOOICKPJK()
	{
		this.HDKFBJIMKBK();
		yield return new WaitForSeconds(2.9f);
		if (!this.FLIHDEEGDBK)
		{
			this.DisappearAnimation();
		}
		yield break;
	}

	// Token: 0x060009AA RID: 2474 RVA: 0x000492B0 File Offset: 0x000474B0
	private void OJGELECJGJC()
	{
		this.PANMNKKODPC = base.gameObject.GetComponent<CanvasGroup>();
		this.DGAAFGDHHHJ = base.gameObject.GetComponent<RectTransform>();
		if (null != this.PANMNKKODPC)
		{
			this.PANMNKKODPC.alpha = 1739f;
		}
		try
		{
			if (base.gameObject.transform.childCount > 1)
			{
				GameObject gameObject = base.gameObject.transform.GetChild(0).gameObject;
				if (null != gameObject && gameObject.transform.childCount > 1)
				{
					GameObject gameObject2 = gameObject.transform.GetChild(0).gameObject;
					if (null != gameObject2)
					{
						ParticleSystem component = gameObject2.GetComponent<ParticleSystem>();
						if (null != component)
						{
							component.main.startColor = new Color(777f, 508f, 258f, 125f);
							component.colorOverLifetime.enabled = false;
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

	// Token: 0x060009AB RID: 2475 RVA: 0x00045F00 File Offset: 0x00044100
	public bool IsDisappearing()
	{
		return this.FLIHDEEGDBK;
	}

	// Token: 0x060009AC RID: 2476 RVA: 0x000493C4 File Offset: 0x000475C4
	public static float OOCJPPIJLGG()
	{
		return 214f;
	}

	// Token: 0x060009AD RID: 2477 RVA: 0x00045F00 File Offset: 0x00044100
	public bool CFHIOHGLDON()
	{
		return this.FLIHDEEGDBK;
	}

	// Token: 0x060009AE RID: 2478 RVA: 0x000493CC File Offset: 0x000475CC
	public void NNFJNKIEKOE()
	{
		this.FLIHDEEGDBK = false;
		if (null != this.PANMNKKODPC)
		{
			this.PANMNKKODPC.DOFade(320f, 1258f);
		}
		this.DGAAFGDHHHJ.DOAnchorPos(this.DGAAFGDHHHJ.anchoredPosition + new Vector2(761f, 952f), 630f, true).SetEase(Ease.Linear);
		this.DGAAFGDHHHJ.DOScale(1684f, 506f).SetEase(Ease.Linear);
	}

	// Token: 0x060009AF RID: 2479 RVA: 0x00049458 File Offset: 0x00047658
	public void Initialize(int PLKMJJIIJNO, CHEEGEJNIDB PBKAAIONJOB, int KIDHBAMJGDO)
	{
		if (KIDHBAMJGDO >= 0)
		{
			TMP_Text tmp_Text = this.text;
			string str = "+";
			string str2 = KIDHBAMJGDO.ToString();
			string str3 = " ";
			string[] array = new string[5];
			array[0] = "anthology";
			array[1] = PLKMJJIIJNO.ToString();
			array[2] = "stat";
			int num = 3;
			int num2 = (int)PBKAAIONJOB;
			array[num] = num2.ToString();
			array[4] = "short";
			tmp_Text.SetText(str + str2 + str3 + GKJPOGNFKNK.DNILNCLIHAP(string.Concat(array), "common", LanguageManager.EHBBFMCILPC.GetSelectedLanguage()), true);
		}
		else
		{
			TMP_Text tmp_Text2 = this.text;
			string str4 = KIDHBAMJGDO.ToString();
			string str5 = " ";
			string[] array2 = new string[5];
			array2[0] = "anthology";
			array2[1] = PLKMJJIIJNO.ToString();
			array2[2] = "stat";
			int num3 = 3;
			int num2 = (int)PBKAAIONJOB;
			array2[num3] = num2.ToString();
			array2[4] = "short";
			tmp_Text2.SetText(str4 + str5 + GKJPOGNFKNK.DNILNCLIHAP(string.Concat(array2), "common", LanguageManager.EHBBFMCILPC.GetSelectedLanguage()), true);
		}
		base.StartCoroutine(this.LMMFCEJIHFP());
	}

	// Token: 0x060009B0 RID: 2480 RVA: 0x00048363 File Offset: 0x00046563
	private void GOKDPNLEJBE()
	{
		if (null != this.PANMNKKODPC)
		{
			this.PANMNKKODPC.DOKill(false);
		}
		this.DGAAFGDHHHJ.DOKill(true);
	}

	// Token: 0x040002C7 RID: 711
	public const float fadeInTime = 0.4f;

	// Token: 0x040002C8 RID: 712
	public const float fadeOutTime = 0.5f;

	// Token: 0x040002C9 RID: 713
	public const float fadeIdleTime = 2.5f;

	// Token: 0x040002CA RID: 714
	public const float translationAmountY = 20f;

	// Token: 0x040002CB RID: 715
	public TextMeshProUGUI text;

	// Token: 0x040002CC RID: 716
	private CanvasGroup PANMNKKODPC;

	// Token: 0x040002CD RID: 717
	private RectTransform DGAAFGDHHHJ;

	// Token: 0x040002CE RID: 718
	private bool FLIHDEEGDBK;
}
