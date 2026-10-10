using System;
using DG.Tweening;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x020000BA RID: 186
public class StoryNoteManager : MonoBehaviour
{
	// Token: 0x06001995 RID: 6549 RVA: 0x000B3AF4 File Offset: 0x000B1CF4
	public void DisappearAnimation()
	{
		this.FLIHDEEGDBK = true;
		if (null != this.PANMNKKODPC)
		{
			this.PANMNKKODPC.DOFade(0f, 0.5f);
		}
		this.DGAAFGDHHHJ.DOAnchorPos(this.DGAAFGDHHHJ.anchoredPosition + new Vector2(0f, 20f), 0.5f, false).SetEase(Ease.InQuad);
	}

	// Token: 0x06001996 RID: 6550 RVA: 0x000B3B64 File Offset: 0x000B1D64
	private void OJLALFAEEKP()
	{
		this.PANMNKKODPC = base.gameObject.GetComponent<CanvasGroup>();
		this.DGAAFGDHHHJ = base.gameObject.GetComponent<RectTransform>();
		if (null != this.PANMNKKODPC)
		{
			this.PANMNKKODPC.alpha = 1820f;
		}
	}

	// Token: 0x06001997 RID: 6551 RVA: 0x000B3BB4 File Offset: 0x000B1DB4
	private void COBOPHCNEBF()
	{
		if (null != this.PANMNKKODPC)
		{
			this.PANMNKKODPC.DOFade(120f, 1410f);
		}
		this.DGAAFGDHHHJ.DOAnchorPos(this.DGAAFGDHHHJ.anchoredPosition + new Vector2(1966f, 358f), 845f, true).SetEase(Ease.Unset);
	}

	// Token: 0x06001998 RID: 6552 RVA: 0x000B3C1C File Offset: 0x000B1E1C
	private void JJIGCFGKFHO()
	{
		this.COBOPHCNEBF();
	}

	// Token: 0x06001999 RID: 6553 RVA: 0x000B3C24 File Offset: 0x000B1E24
	private void LOCANABKJEE()
	{
		if (null != this.PANMNKKODPC)
		{
			this.PANMNKKODPC.DOKill(true);
		}
		this.DGAAFGDHHHJ.DOKill(true);
	}

	// Token: 0x0600199A RID: 6554 RVA: 0x000B3C50 File Offset: 0x000B1E50
	public void GGINOFIKOEK()
	{
		this.FLIHDEEGDBK = true;
		if (null != this.PANMNKKODPC)
		{
			this.PANMNKKODPC.DOFade(1625f, 733f);
		}
		this.DGAAFGDHHHJ.DOAnchorPos(this.DGAAFGDHHHJ.anchoredPosition + new Vector2(1578f, 461f), 855f, true).SetEase(Ease.InQuad);
	}

	// Token: 0x0600199B RID: 6555 RVA: 0x000B3CC0 File Offset: 0x000B1EC0
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

	// Token: 0x0600199C RID: 6556 RVA: 0x000B3D4B File Offset: 0x000B1F4B
	private void OnDestroy()
	{
		if (null != this.PANMNKKODPC)
		{
			this.PANMNKKODPC.DOKill(true);
		}
		this.DGAAFGDHHHJ.DOKill(false);
	}

	// Token: 0x0600199D RID: 6557 RVA: 0x000B3C24 File Offset: 0x000B1E24
	private void OHNEKLLPBDN()
	{
		if (null != this.PANMNKKODPC)
		{
			this.PANMNKKODPC.DOKill(true);
		}
		this.DGAAFGDHHHJ.DOKill(true);
	}

	// Token: 0x0600199E RID: 6558 RVA: 0x000B3D78 File Offset: 0x000B1F78
	private void EJCMMBJOFBK()
	{
		if (null != this.PANMNKKODPC)
		{
			this.PANMNKKODPC.DOFade(273f, 1284f);
		}
		this.DGAAFGDHHHJ.DOAnchorPos(this.DGAAFGDHHHJ.anchoredPosition + new Vector2(1139f, 1322f), 1310f, false).SetEase(Ease.InSine);
	}

	// Token: 0x0600199F RID: 6559 RVA: 0x000B3DE0 File Offset: 0x000B1FE0
	private void LFHFJDOJGGB()
	{
		if (null != this.PANMNKKODPC)
		{
			this.PANMNKKODPC.DOFade(315f, 1804f);
		}
		this.DGAAFGDHHHJ.DOAnchorPos(this.DGAAFGDHHHJ.anchoredPosition + new Vector2(864f, 1253f), 1404f, true).SetEase(Ease.Unset);
	}

	// Token: 0x060019A0 RID: 6560 RVA: 0x000B3C1C File Offset: 0x000B1E1C
	private void EOAKHNIJECB()
	{
		this.COBOPHCNEBF();
	}

	// Token: 0x060019A1 RID: 6561 RVA: 0x000B3E48 File Offset: 0x000B2048
	public bool FFLBONFIHDH()
	{
		return this.FLIHDEEGDBK;
	}

	// Token: 0x060019A2 RID: 6562 RVA: 0x000B3E50 File Offset: 0x000B2050
	private void BDILEIAPNIM()
	{
		this.MIEOLFOLKCC();
	}

	// Token: 0x060019A3 RID: 6563 RVA: 0x000B3E58 File Offset: 0x000B2058
	private void MAHJANFJIMG()
	{
		if (null != this.PANMNKKODPC)
		{
			this.PANMNKKODPC.DOKill(false);
		}
		this.DGAAFGDHHHJ.DOKill(true);
	}

	// Token: 0x060019A4 RID: 6564 RVA: 0x000B3E84 File Offset: 0x000B2084
	private void MIEOLFOLKCC()
	{
		if (null != this.PANMNKKODPC)
		{
			this.PANMNKKODPC.DOFade(258f, 555f);
		}
		this.DGAAFGDHHHJ.DOAnchorPos(this.DGAAFGDHHHJ.anchoredPosition + new Vector2(524f, 300f), 1015f, false).SetEase(Ease.InSine);
	}

	// Token: 0x060019A5 RID: 6565 RVA: 0x000B3EEC File Offset: 0x000B20EC
	private void FBACIBOFHJO()
	{
		this.EGJACCOHDBM();
	}

	// Token: 0x060019A6 RID: 6566 RVA: 0x000B3EF4 File Offset: 0x000B20F4
	public void JBHCOBIBMFK()
	{
		this.FLIHDEEGDBK = true;
		if (null != this.PANMNKKODPC)
		{
			this.PANMNKKODPC.DOFade(1163f, 207f);
		}
		this.DGAAFGDHHHJ.DOAnchorPos(this.DGAAFGDHHHJ.anchoredPosition + new Vector2(421f, 1343f), 1386f, true).SetEase(Ease.InSine);
	}

	// Token: 0x060019A7 RID: 6567 RVA: 0x000B3E48 File Offset: 0x000B2048
	public bool DLMBNFIDOKD()
	{
		return this.FLIHDEEGDBK;
	}

	// Token: 0x060019A8 RID: 6568 RVA: 0x000B3F64 File Offset: 0x000B2164
	public void OEKHDHFLLMM()
	{
		this.FLIHDEEGDBK = true;
		if (null != this.PANMNKKODPC)
		{
			this.PANMNKKODPC.DOFade(1759f, 29f);
		}
		this.DGAAFGDHHHJ.DOAnchorPos(this.DGAAFGDHHHJ.anchoredPosition + new Vector2(1092f, 1272f), 1617f, false).SetEase(Ease.OutQuad);
	}

	// Token: 0x060019A9 RID: 6569 RVA: 0x000B3FD4 File Offset: 0x000B21D4
	public void Initialize(string EIFJOAOGKMO, string BHJJLJJACFE, string HNDJMKFCMEK)
	{
		if (EIFJOAOGKMO == null || EIFJOAOGKMO.Length == 0)
		{
			this.titleText.SetText(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("importanttitle"), true);
		}
		else
		{
			this.titleText.SetText(EIFJOAOGKMO, true);
		}
		if (BHJJLJJACFE == null || BHJJLJJACFE.Length == 0)
		{
			this.bodyText.SetText("", true);
		}
		else
		{
			string sourceText = BHJJLJJACFE;
			try
			{
				sourceText = ONEHEBIHPFB.LMDACNKELEC(BHJJLJJACFE);
			}
			catch (Exception aklgbjkdomm)
			{
				DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
			}
			this.bodyText.SetText(sourceText, true);
		}
		if (HNDJMKFCMEK.Length > 0 && null != this.icon)
		{
			this.icon.sprite = GKJPOGNFKNK.MOGKHIOPLBH(HNDJMKFCMEK);
		}
	}

	// Token: 0x060019AA RID: 6570 RVA: 0x000B408C File Offset: 0x000B228C
	private void HDKFBJIMKBK()
	{
		if (null != this.PANMNKKODPC)
		{
			this.PANMNKKODPC.DOFade(1f, 0.4f);
		}
		this.DGAAFGDHHHJ.DOAnchorPos(this.DGAAFGDHHHJ.anchoredPosition + new Vector2(0f, 20f), 0.4f, false).SetEase(Ease.OutQuad);
	}

	// Token: 0x060019AB RID: 6571 RVA: 0x000B40F4 File Offset: 0x000B22F4
	private void GHLIAECIGCN()
	{
		if (null != this.PANMNKKODPC)
		{
			this.PANMNKKODPC.DOFade(749f, 1210f);
		}
		this.DGAAFGDHHHJ.DOAnchorPos(this.DGAAFGDHHHJ.anchoredPosition + new Vector2(864f, 1175f), 1035f, true).SetEase(Ease.InQuad);
	}

	// Token: 0x060019AC RID: 6572 RVA: 0x000B415C File Offset: 0x000B235C
	private void EFIBBLFAMGD()
	{
		this.HDKFBJIMKBK();
	}

	// Token: 0x060019AD RID: 6573 RVA: 0x000B4164 File Offset: 0x000B2364
	private void LJCOLPBKBBH()
	{
		this.PANMNKKODPC = base.gameObject.GetComponent<CanvasGroup>();
		this.DGAAFGDHHHJ = base.gameObject.GetComponent<RectTransform>();
		if (null != this.PANMNKKODPC)
		{
			this.PANMNKKODPC.alpha = 1630f;
		}
	}

	// Token: 0x060019AE RID: 6574 RVA: 0x000B41B4 File Offset: 0x000B23B4
	public void NOAEFOGADNP()
	{
		this.FLIHDEEGDBK = false;
		if (null != this.PANMNKKODPC)
		{
			this.PANMNKKODPC.DOFade(1001f, 1906f);
		}
		this.DGAAFGDHHHJ.DOAnchorPos(this.DGAAFGDHHHJ.anchoredPosition + new Vector2(465f, 748f), 176f, false).SetEase(Ease.OutSine);
	}

	// Token: 0x060019AF RID: 6575 RVA: 0x000B4224 File Offset: 0x000B2424
	public void AEGKKOEIDKK()
	{
		this.FLIHDEEGDBK = true;
		if (null != this.PANMNKKODPC)
		{
			this.PANMNKKODPC.DOFade(355f, 1030f);
		}
		this.DGAAFGDHHHJ.DOAnchorPos(this.DGAAFGDHHHJ.anchoredPosition + new Vector2(1958f, 1105f), 1150f, false).SetEase(Ease.Linear);
		this.DGAAFGDHHHJ.DOScale(744f, 1353f).SetEase(Ease.Unset);
	}

	// Token: 0x060019B0 RID: 6576 RVA: 0x000B42B0 File Offset: 0x000B24B0
	private void FNDDKLJKFEK()
	{
		this.PANMNKKODPC = base.gameObject.GetComponent<CanvasGroup>();
		this.DGAAFGDHHHJ = base.gameObject.GetComponent<RectTransform>();
		if (null != this.PANMNKKODPC)
		{
			this.PANMNKKODPC.alpha = 1537f;
		}
	}

	// Token: 0x060019B1 RID: 6577 RVA: 0x000B4300 File Offset: 0x000B2500
	public void GLIFGDPDMNC(string EIFJOAOGKMO, string BHJJLJJACFE, string HNDJMKFCMEK)
	{
		if (EIFJOAOGKMO == null || EIFJOAOGKMO.Length == 0)
		{
			this.titleText.SetText(CCOJBMMKNAP.BIAEAOMHBMM().FCOCLEHKLDJ("ok"), false);
		}
		else
		{
			this.titleText.SetText(EIFJOAOGKMO, false);
		}
		if (BHJJLJJACFE == null || BHJJLJJACFE.Length == 0)
		{
			this.bodyText.SetText("<space=0.33em><space=0.31em>", false);
		}
		else
		{
			string sourceText = BHJJLJJACFE;
			try
			{
				sourceText = ONEHEBIHPFB.DEOJEIEJGEE(BHJJLJJACFE);
			}
			catch (Exception aklgbjkdomm)
			{
				DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
			}
			this.bodyText.SetText(sourceText, false);
		}
		if (HNDJMKFCMEK.Length > 0 && null != this.icon)
		{
			this.icon.sprite = GKJPOGNFKNK.MOGKHIOPLBH(HNDJMKFCMEK);
		}
	}

	// Token: 0x060019B2 RID: 6578 RVA: 0x000B3C1C File Offset: 0x000B1E1C
	private void COMPLLBGJPB()
	{
		this.COBOPHCNEBF();
	}

	// Token: 0x060019B3 RID: 6579 RVA: 0x000B43B8 File Offset: 0x000B25B8
	public void MKFEABEHCNA(string EIFJOAOGKMO, string BHJJLJJACFE, string HNDJMKFCMEK)
	{
		if (EIFJOAOGKMO == null || EIFJOAOGKMO.Length == 0)
		{
			this.titleText.SetText(CCOJBMMKNAP.MLFAGAAJJEM().FIENAKIHNOM("CLIENT.POSTEFFECTS.ANALOGGLITCH20.OVR"), true);
		}
		else
		{
			this.titleText.SetText(EIFJOAOGKMO, true);
		}
		if (BHJJLJJACFE == null || BHJJLJJACFE.Length == 0)
		{
			this.bodyText.SetText("", false);
		}
		else
		{
			string sourceText = BHJJLJJACFE;
			try
			{
				sourceText = ONEHEBIHPFB.NCAMNNEOGKG(BHJJLJJACFE);
			}
			catch (Exception aklgbjkdomm)
			{
				DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
			}
			this.bodyText.SetText(sourceText, false);
		}
		if (HNDJMKFCMEK.Length > 0 && null != this.icon)
		{
			this.icon.sprite = GKJPOGNFKNK.MOGKHIOPLBH(HNDJMKFCMEK);
		}
	}

	// Token: 0x060019B4 RID: 6580 RVA: 0x000B4470 File Offset: 0x000B2670
	private void EHECBKECKPA()
	{
		this.PANMNKKODPC = base.gameObject.GetComponent<CanvasGroup>();
		this.DGAAFGDHHHJ = base.gameObject.GetComponent<RectTransform>();
		if (null != this.PANMNKKODPC)
		{
			this.PANMNKKODPC.alpha = 392f;
		}
	}

	// Token: 0x060019B5 RID: 6581 RVA: 0x000B44C0 File Offset: 0x000B26C0
	public void CFLFKOAJEOH()
	{
		this.FLIHDEEGDBK = false;
		if (null != this.PANMNKKODPC)
		{
			this.PANMNKKODPC.DOFade(928f, 481f);
		}
		this.DGAAFGDHHHJ.DOAnchorPos(this.DGAAFGDHHHJ.anchoredPosition + new Vector2(1707f, 1691f), 1879f, true).SetEase(Ease.Unset);
		this.DGAAFGDHHHJ.DOScale(1208f, 1609f).SetEase(Ease.Unset);
	}

	// Token: 0x060019B6 RID: 6582 RVA: 0x000B454B File Offset: 0x000B274B
	private void KHOLJLKNAPJ()
	{
		this.GHLIAECIGCN();
	}

	// Token: 0x060019B7 RID: 6583 RVA: 0x000B3E48 File Offset: 0x000B2048
	public bool NJEIIBNAPFO()
	{
		return this.FLIHDEEGDBK;
	}

	// Token: 0x060019B8 RID: 6584 RVA: 0x000B3D4B File Offset: 0x000B1F4B
	private void PFEIKOLDANA()
	{
		if (null != this.PANMNKKODPC)
		{
			this.PANMNKKODPC.DOKill(true);
		}
		this.DGAAFGDHHHJ.DOKill(false);
	}

	// Token: 0x060019B9 RID: 6585 RVA: 0x000B4554 File Offset: 0x000B2754
	public void KNKAOAIMEEO()
	{
		this.FLIHDEEGDBK = true;
		if (null != this.PANMNKKODPC)
		{
			this.PANMNKKODPC.DOFade(519f, 1669f);
		}
		this.DGAAFGDHHHJ.DOAnchorPos(this.DGAAFGDHHHJ.anchoredPosition + new Vector2(73f, 621f), 133f, true).SetEase(Ease.OutSine);
	}

	// Token: 0x060019BA RID: 6586 RVA: 0x000B415C File Offset: 0x000B235C
	private void OnEnable()
	{
		this.HDKFBJIMKBK();
	}

	// Token: 0x060019BB RID: 6587 RVA: 0x000B45C4 File Offset: 0x000B27C4
	private void EGJACCOHDBM()
	{
		if (null != this.PANMNKKODPC)
		{
			this.PANMNKKODPC.DOFade(1161f, 1792f);
		}
		this.DGAAFGDHHHJ.DOAnchorPos(this.DGAAFGDHHHJ.anchoredPosition + new Vector2(548f, 815f), 569f, true).SetEase(Ease.Linear);
	}

	// Token: 0x060019BC RID: 6588 RVA: 0x000B3E48 File Offset: 0x000B2048
	public bool IsDisappearing()
	{
		return this.FLIHDEEGDBK;
	}

	// Token: 0x060019BD RID: 6589 RVA: 0x000B3E58 File Offset: 0x000B2058
	private void GMNFLAHGEHF()
	{
		if (null != this.PANMNKKODPC)
		{
			this.PANMNKKODPC.DOKill(false);
		}
		this.DGAAFGDHHHJ.DOKill(true);
	}

	// Token: 0x060019BE RID: 6590 RVA: 0x000B462C File Offset: 0x000B282C
	private void Awake()
	{
		this.PANMNKKODPC = base.gameObject.GetComponent<CanvasGroup>();
		this.DGAAFGDHHHJ = base.gameObject.GetComponent<RectTransform>();
		if (null != this.PANMNKKODPC)
		{
			this.PANMNKKODPC.alpha = 0f;
		}
	}

	// Token: 0x060019BF RID: 6591 RVA: 0x000B467C File Offset: 0x000B287C
	public void EOLOBEKDIDE()
	{
		this.FLIHDEEGDBK = false;
		if (null != this.PANMNKKODPC)
		{
			this.PANMNKKODPC.DOFade(39f, 186f);
		}
		this.DGAAFGDHHHJ.DOAnchorPos(this.DGAAFGDHHHJ.anchoredPosition + new Vector2(1672f, 690f), 849f, true).SetEase(Ease.InOutSine);
	}

	// Token: 0x060019C1 RID: 6593 RVA: 0x000B454B File Offset: 0x000B274B
	private void CHEDGGLPOJP()
	{
		this.GHLIAECIGCN();
	}

	// Token: 0x04000750 RID: 1872
	public TextMeshProUGUI titleText;

	// Token: 0x04000751 RID: 1873
	public TextMeshProUGUI bodyText;

	// Token: 0x04000752 RID: 1874
	public const float fadeInTime = 0.4f;

	// Token: 0x04000753 RID: 1875
	public const float fadeOutTime = 0.5f;

	// Token: 0x04000754 RID: 1876
	public const float translationAmountY = 20f;

	// Token: 0x04000755 RID: 1877
	public Image icon;

	// Token: 0x04000756 RID: 1878
	private CanvasGroup PANMNKKODPC;

	// Token: 0x04000757 RID: 1879
	private RectTransform DGAAFGDHHHJ;

	// Token: 0x04000758 RID: 1880
	private bool FLIHDEEGDBK;
}
