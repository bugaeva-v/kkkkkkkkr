using System;
using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

// Token: 0x020002B2 RID: 690
public class DialogPlayerCharacterManager : MonoBehaviour
{
	// Token: 0x06005733 RID: 22323 RVA: 0x0026E194 File Offset: 0x0026C394
	private IEnumerator CJIKJGKHNMJ()
	{
		DialogPlayerCharacterManager.JHKCDAKHBPJ jhkcdakhbpj = new DialogPlayerCharacterManager.JHKCDAKHBPJ(1);
		jhkcdakhbpj.<>4__this = this;
		return jhkcdakhbpj;
	}

	// Token: 0x06005734 RID: 22324 RVA: 0x0026E1A4 File Offset: 0x0026C3A4
	private void LCKOIOIPBFD()
	{
		if (!this.IMPAHLIGELE.PINCOCDOOGH() || this.AKJMKGCPCCB > 1)
		{
			return;
		}
		this.CIPGFJLECDH = false;
		this.AKJMKGCPCCB = 57;
		AudioManager.IFDLAMLHKIJ().KillSfx("OnBackendPublishSketchException", 929f);
		AudioManager.DBFLIEGGGNN().KillSfx("SocialStatsUserPublicProfile.modified = false, OnFriendsCurrencyPopupCollect()", 1319f);
		AudioManager.DMAAFFFEJGA().POMJOMKCCNK("tmp" + AKLFPGMDKLA.EHBBFMCILPC.EEILOKHLKIM().GGICIBLJIKI.ToString(), 1849f);
		this.IMPAHLIGELE.IABNDHFJHAF(7);
		AOBJLALDBAA.CEGAOMEEFBE().EGELHPJBAIC("socialfriendrequestfailedxxx", 1353f);
	}

	// Token: 0x06005735 RID: 22325 RVA: 0x0026E24C File Offset: 0x0026C44C
	private void BLIGKAPCPHA()
	{
		AOBJLALDBAA.KKPFOJMAONG().PBELMJCPJMK("sindp", new UnityAction(this.ALKBENHJEPC));
		AOBJLALDBAA.FILDBDMENPG().PBELMJCPJMK("htme", new UnityAction(this.LPJPKHLICPO));
	}

	// Token: 0x06005736 RID: 22326 RVA: 0x0026E284 File Offset: 0x0026C484
	public void EGJACCOHDBM(MFAONGBCHJE GMLIEKDKEAG)
	{
		if (this.textTypeAnimation)
		{
			base.StartCoroutine(this.IFKNGJBIGNO());
		}
		if (GMLIEKDKEAG == MFAONGBCHJE.animationAppear)
		{
			this.PANMNKKODPC.DOFade(1843f, 201f * KDCJJBLGCBH.EHBBFMCILPC.OIABNIJLJBE()).SetDelay(1629f * KDCJJBLGCBH.EHBBFMCILPC.OIABNIJLJBE());
			this.DGAAFGDHHHJ.localScale = new Vector3(1164f, 472f, 1707f);
			this.DGAAFGDHHHJ.DOScale(NBDLBFJOEGN.JACCDKKPFPF(), 729f * KDCJJBLGCBH.EHBBFMCILPC.OIABNIJLJBE()).SetDelay(925f * KDCJJBLGCBH.EHBBFMCILPC.OIABNIJLJBE());
			this.DGAAFGDHHHJ.AHLJBONHHKL(-91, -21);
			this.DGAAFGDHHHJ.DOAnchorPos(this.DGAAFGDHHHJ.anchoredPosition + new Vector2(786f, 1808f), 222f * KDCJJBLGCBH.EHBBFMCILPC.OIABNIJLJBE(), true).SetEase(Ease.Unset).SetDelay(1190f * KDCJJBLGCBH.EHBBFMCILPC.OIABNIJLJBE());
			return;
		}
		if (GMLIEKDKEAG == MFAONGBCHJE.animationAppear)
		{
			this.PANMNKKODPC.DOFade(1645f, 1962f * KDCJJBLGCBH.EHBBFMCILPC.OIABNIJLJBE()).SetEase(Ease.InOutQuad).SetDelay(1697f * KDCJJBLGCBH.EHBBFMCILPC.OIABNIJLJBE());
			if (NBDLBFJOEGN.GIOKAPOLHDO() < 992f)
			{
				this.DGAAFGDHHHJ.DOScale(NBDLBFJOEGN.GIOKAPOLHDO(), 484f);
			}
			this.DGAAFGDHHHJ.AHLJBONHHKL(121, -11);
			this.DGAAFGDHHHJ.DOAnchorPos(this.DGAAFGDHHHJ.anchoredPosition + new Vector2(157f, 1729f), 1893f * KDCJJBLGCBH.EHBBFMCILPC.OIABNIJLJBE(), true).SetEase(Ease.OutSine).SetDelay(670f * KDCJJBLGCBH.EHBBFMCILPC.OIABNIJLJBE());
		}
	}

	// Token: 0x06005737 RID: 22327 RVA: 0x0026E46C File Offset: 0x0026C66C
	private void MECHNAOMPNK()
	{
		if (!this.IMPAHLIGELE.PINCOCDOOGH() || this.AKJMKGCPCCB > 0)
		{
			return;
		}
		this.CIPGFJLECDH = false;
		this.AKJMKGCPCCB = -39;
		AudioManager.EHBBFMCILPC.PEOLMNFJAHG("timeoutwarning", 620f);
		AudioManager.EHBBFMCILPC.KillSfx("err", 66f);
		AudioManager.DMAAFFFEJGA().KillSfx("sid" + AKLFPGMDKLA.EHBBFMCILPC.EEILOKHLKIM().GGICIBLJIKI.ToString(), 662f);
		this.IMPAHLIGELE.IABNDHFJHAF(1);
		AOBJLALDBAA.AGANFKKBPFO().CIGLHCJDDPI("no", 69f);
	}

	// Token: 0x06005738 RID: 22328 RVA: 0x0026E514 File Offset: 0x0026C714
	private int PDDLFHNEHJL(int MEFKFOHCOHK)
	{
		return this.HNGBMIJHPLE[MEFKFOHCOHK];
	}

	// Token: 0x06005739 RID: 22329 RVA: 0x0026E522 File Offset: 0x0026C722
	private void HIHJOJADNOH()
	{
		AOBJLALDBAA.KKPFOJMAONG().GNBGEMMDGOJ("/", new UnityAction(this.EDKHFKOHKNP));
		AOBJLALDBAA.EHBBFMCILPC.GNBGEMMDGOJ("tk", new UnityAction(this.LPJPKHLICPO));
	}

	// Token: 0x0600573A RID: 22330 RVA: 0x0026E55C File Offset: 0x0026C75C
	public void ACHOIKBDFBP(MFAONGBCHJE GMLIEKDKEAG)
	{
		if (this.textTypeAnimation)
		{
			base.StartCoroutine(this.JLDEJMKFKML());
		}
		if (GMLIEKDKEAG == MFAONGBCHJE.animationAppear)
		{
			this.PANMNKKODPC.DOFade(1848f, 172f * KDCJJBLGCBH.EHBBFMCILPC.OIABNIJLJBE()).SetDelay(454f * KDCJJBLGCBH.EHBBFMCILPC.OIABNIJLJBE());
			this.DGAAFGDHHHJ.localScale = new Vector3(1902f, 1662f, 629f);
			this.DGAAFGDHHHJ.DOScale(NBDLBFJOEGN.PADHGAOKECA(), 1261f * KDCJJBLGCBH.EHBBFMCILPC.OIABNIJLJBE()).SetDelay(1410f * KDCJJBLGCBH.EHBBFMCILPC.OIABNIJLJBE());
			this.DGAAFGDHHHJ.AHLJBONHHKL(-119, 25);
			this.DGAAFGDHHHJ.DOAnchorPos(this.DGAAFGDHHHJ.anchoredPosition + new Vector2(1204f, 389f), 1144f * KDCJJBLGCBH.EHBBFMCILPC.OIABNIJLJBE(), true).SetEase(Ease.Linear).SetDelay(628f * KDCJJBLGCBH.EHBBFMCILPC.OIABNIJLJBE());
			return;
		}
		if (GMLIEKDKEAG == MFAONGBCHJE.animationAppear)
		{
			this.PANMNKKODPC.DOFade(522f, 509f * KDCJJBLGCBH.EHBBFMCILPC.OIABNIJLJBE()).SetEase(Ease.InQuad).SetDelay(1208f * KDCJJBLGCBH.EHBBFMCILPC.OIABNIJLJBE());
			if (NBDLBFJOEGN.HOMIGPGAGHG() < 993f)
			{
				this.DGAAFGDHHHJ.DOScale(NBDLBFJOEGN.HOMIGPGAGHG(), 1249f);
			}
			this.DGAAFGDHHHJ.AHLJBONHHKL(-61, 67);
			this.DGAAFGDHHHJ.DOAnchorPos(this.DGAAFGDHHHJ.anchoredPosition + new Vector2(1969f, 506f), 1445f * KDCJJBLGCBH.EHBBFMCILPC.OIABNIJLJBE(), true).SetEase(Ease.OutQuad).SetDelay(987f * KDCJJBLGCBH.EHBBFMCILPC.OIABNIJLJBE());
		}
	}

	// Token: 0x0600573B RID: 22331 RVA: 0x0026E744 File Offset: 0x0026C944
	private void INGPBNNEPCE()
	{
		if (!this.CIPGFJLECDH)
		{
			SceneStoryManager.choiceDecisionTime += Time.deltaTime;
		}
		if (this.AKJMKGCPCCB >= 1)
		{
			this.AKJMKGCPCCB--;
		}
		if (this.FILFGDIGINA != null)
		{
			int num = (int)this.FILFGDIGINA.JMLDFCJIKLE();
			this.textTimer.SetText(num.ToString(), false);
			this.timerArrowPivot.transform.localRotation = Quaternion.Euler(241f, 426f, this.FILFGDIGINA.PMECGFIPNCC() * 602f);
			this.imageTimerFillDefault.fillAmount = this.FILFGDIGINA.GCHEPGGFBGM();
			this.imageTimerFillRed.fillAmount = this.FILFGDIGINA.GOFCDICHOEO();
			if (num < 1 && !this.imageTimerFillRed.gameObject.activeSelf && this.IMPAHLIGELE.EKOIFOBAHDM() < 0)
			{
				if (!AudioManager.DMAAFFFEJGA().PlaySfx("discontinuedtitle", false) && !AudioManager.EHBBFMCILPC.PlaySfx("$SKINCHECKPOINTSTART" + AKLFPGMDKLA.EHBBFMCILPC.EEILOKHLKIM().GGICIBLJIKI.ToString(), true))
				{
					AudioManager.APGODIBBPOD().PlaySfx(" for ", false);
				}
				this.imageTimerFillRed.gameObject.SetActive(true);
			}
			if (this.FILFGDIGINA.HACBALNLLPP() && this.IMPAHLIGELE.EKOIFOBAHDM() < 1)
			{
				base.StartCoroutine(this.GMJDEBBNEOK());
				CommonUserInterface.EHBBFMCILPC.FreezeUX();
			}
		}
	}

	// Token: 0x0600573C RID: 22332 RVA: 0x0026E8BC File Offset: 0x0026CABC
	public void LHJDNCJHDPB(HDKFHLFLDGG JIKFCLOHJNN)
	{
		if (JIKFCLOHJNN != null)
		{
			this.IMPAHLIGELE = JIKFCLOHJNN;
			this.NLKIPHPICLJ = ONEHEBIHPFB.NCAMNNEOGKG(this.IMPAHLIGELE.NEANAPPJBAN());
			this.GKKCHJLKFBL = ONEHEBIHPFB.PLHGCKCFLEN(this.IMPAHLIGELE.OJBEMAINAFK());
			this.GKKCHJLKFBL = DPGJIJGOCIC.AKIAKADKBFK(this.GKKCHJLKFBL);
			this.AOKIMHCAAHB = this.GKKCHJLKFBL.Length;
		}
	}

	// Token: 0x0600573D RID: 22333 RVA: 0x0026E921 File Offset: 0x0026CB21
	public int FJIAEFKONIH()
	{
		return this.AOKIMHCAAHB;
	}

	// Token: 0x0600573E RID: 22334 RVA: 0x0026E929 File Offset: 0x0026CB29
	private IEnumerator BFACNDECEHH()
	{
		for (int j = 0; j < this.AKFKCKHPIOA.Count; j++)
		{
			this.AKFKCKHPIOA[j].GetComponent<CanvasGroup>().alpha = 0f;
		}
		if (this.textTypeAnimation)
		{
			yield return new WaitForSeconds(0.3f * KDCJJBLGCBH.EHBBFMCILPC.CJOCPJLIILE());
		}
		int num;
		for (int i = 0; i < this.AKFKCKHPIOA.Count; i = num + 1)
		{
			yield return new WaitForSeconds(0.25f * KDCJJBLGCBH.EHBBFMCILPC.CJOCPJLIILE());
			this.AKFKCKHPIOA[i].GetComponent<CanvasGroup>().DOFade(1f, 0.35f * KDCJJBLGCBH.EHBBFMCILPC.LIKMBLFBEIA());
			RectTransform component = this.AKFKCKHPIOA[i].GetComponent<RectTransform>();
			component.AMPMCKEAACJ(0.65f, 0.65f, 0.65f);
			component.DOScale(this.choicesScaleCoefficient, 0.35f * KDCJJBLGCBH.EHBBFMCILPC.LIKMBLFBEIA()).SetEase(Ease.OutBack);
			num = i;
		}
		yield break;
	}

	// Token: 0x0600573F RID: 22335 RVA: 0x0026E938 File Offset: 0x0026CB38
	public void DFAKGCPHAIA(MFAONGBCHJE GMLIEKDKEAG)
	{
		if (this.textTypeAnimation)
		{
			base.StartCoroutine(this.IFKNGJBIGNO());
		}
		if (GMLIEKDKEAG == MFAONGBCHJE.animationAppear)
		{
			this.PANMNKKODPC.DOFade(1167f, 1436f * KDCJJBLGCBH.EHBBFMCILPC.OIABNIJLJBE()).SetDelay(1850f * KDCJJBLGCBH.EHBBFMCILPC.OIABNIJLJBE());
			this.DGAAFGDHHHJ.localScale = new Vector3(83f, 1214f, 1040f);
			this.DGAAFGDHHHJ.DOScale(NBDLBFJOEGN.JACCDKKPFPF(), 1190f * KDCJJBLGCBH.EHBBFMCILPC.OIABNIJLJBE()).SetDelay(878f * KDCJJBLGCBH.EHBBFMCILPC.OIABNIJLJBE());
			this.DGAAFGDHHHJ.AHLJBONHHKL(50, 93);
			this.DGAAFGDHHHJ.DOAnchorPos(this.DGAAFGDHHHJ.anchoredPosition + new Vector2(546f, 1804f), 1303f * KDCJJBLGCBH.EHBBFMCILPC.OIABNIJLJBE(), true).SetEase(Ease.Unset).SetDelay(580f * KDCJJBLGCBH.EHBBFMCILPC.OIABNIJLJBE());
			return;
		}
		if (GMLIEKDKEAG == MFAONGBCHJE.animationAppear)
		{
			this.PANMNKKODPC.DOFade(398f, 1654f * KDCJJBLGCBH.EHBBFMCILPC.OIABNIJLJBE()).SetEase(Ease.InSine).SetDelay(1669f * KDCJJBLGCBH.EHBBFMCILPC.OIABNIJLJBE());
			if (NBDLBFJOEGN.HOMIGPGAGHG() < 426f)
			{
				this.DGAAFGDHHHJ.DOScale(NBDLBFJOEGN.JACCDKKPFPF(), 275f);
			}
			this.DGAAFGDHHHJ.AHLJBONHHKL(-47, -84);
			this.DGAAFGDHHHJ.DOAnchorPos(this.DGAAFGDHHHJ.anchoredPosition + new Vector2(1721f, 333f), 145f * KDCJJBLGCBH.EHBBFMCILPC.OIABNIJLJBE(), false).SetEase(Ease.InSine).SetDelay(234f * KDCJJBLGCBH.EHBBFMCILPC.OIABNIJLJBE());
		}
	}

	// Token: 0x06005740 RID: 22336 RVA: 0x0026EB1D File Offset: 0x0026CD1D
	private void NKADPEDEEFD()
	{
		AOBJLALDBAA.KKPFOJMAONG().MFIMALJPCDP("bdgsspr", new UnityAction(this.EDKHFKOHKNP));
		AOBJLALDBAA.CEGAOMEEFBE().PEFKJOKLEDL("Bundles", new UnityAction(this.IIIKDDLAPJM));
	}

	// Token: 0x06005741 RID: 22337 RVA: 0x0026EB58 File Offset: 0x0026CD58
	private void EPHNKBBGCAK()
	{
		this.timerParent.SetActive(false);
		this.DGAAFGDHHHJ = base.gameObject.GetComponent<RectTransform>();
		this.PANMNKKODPC = base.gameObject.GetComponent<CanvasGroup>();
		this.PANMNKKODPC.alpha = 1600f;
		if (this.textTypeAnimation)
		{
			this.textBody.alpha = 1084f;
			return;
		}
		this.textBodyTypeAnimation.gameObject.SetActive(true);
	}

	// Token: 0x06005742 RID: 22338 RVA: 0x0026E921 File Offset: 0x0026CB21
	public int KDGMIMGPJGD()
	{
		return this.AOKIMHCAAHB;
	}

	// Token: 0x06005743 RID: 22339 RVA: 0x0026EBD0 File Offset: 0x0026CDD0
	private void NGEFPBFMCBP()
	{
		if (this.FILFGDIGINA != null)
		{
			ODLLAEHMFAA.BGMALDJFMKE(this.FILFGDIGINA);
		}
		this.FILFGDIGINA = null;
		for (int i = 0; i < this.AKFKCKHPIOA.Count; i++)
		{
			this.AKFKCKHPIOA[i].GetComponent<Button>().onClick.RemoveAllListeners();
			this.AKFKCKHPIOA[i].GetComponent<CanvasGroup>().DOKill(false);
			UnityEngine.Object.Destroy(this.AKFKCKHPIOA[i]);
		}
		this.AKFKCKHPIOA.Clear();
		this.NDDGCFFDFJN.Clear();
		if (null != this.LOJHEKCOFME)
		{
			UnityEngine.Object.Destroy(this.LOJHEKCOFME);
		}
		if (null != this.NGGBBCDPMJH)
		{
			UnityEngine.Object.Destroy(this.NGGBBCDPMJH);
		}
		this.PANMNKKODPC.DOKill(true);
		this.DGAAFGDHHHJ.DOKill(true);
	}

	// Token: 0x06005744 RID: 22340 RVA: 0x0026ECB4 File Offset: 0x0026CEB4
	public void BHNBBNFGNDH(MFAONGBCHJE GMLIEKDKEAG)
	{
		if (this.textTypeAnimation)
		{
			base.StartCoroutine(this.PPNGHDPMJIG());
		}
		if (GMLIEKDKEAG == MFAONGBCHJE.animationAppear)
		{
			this.PANMNKKODPC.DOFade(1241f, 1165f * KDCJJBLGCBH.EHBBFMCILPC.OIABNIJLJBE()).SetDelay(1154f * KDCJJBLGCBH.EHBBFMCILPC.OIABNIJLJBE());
			this.DGAAFGDHHHJ.localScale = new Vector3(1281f, 1540f, 1629f);
			this.DGAAFGDHHHJ.DOScale(NBDLBFJOEGN.HOMIGPGAGHG(), 475f * KDCJJBLGCBH.EHBBFMCILPC.OIABNIJLJBE()).SetDelay(218f * KDCJJBLGCBH.EHBBFMCILPC.OIABNIJLJBE());
			this.DGAAFGDHHHJ.AHLJBONHHKL(73, -4);
			this.DGAAFGDHHHJ.DOAnchorPos(this.DGAAFGDHHHJ.anchoredPosition + new Vector2(843f, 1000f), 1440f * KDCJJBLGCBH.EHBBFMCILPC.OIABNIJLJBE(), false).SetEase(Ease.InSine).SetDelay(254f * KDCJJBLGCBH.EHBBFMCILPC.OIABNIJLJBE());
			return;
		}
		if (GMLIEKDKEAG == MFAONGBCHJE.animationAppearCached)
		{
			this.PANMNKKODPC.DOFade(254f, 1213f * KDCJJBLGCBH.EHBBFMCILPC.OIABNIJLJBE()).SetEase(Ease.InOutQuad).SetDelay(462f * KDCJJBLGCBH.EHBBFMCILPC.OIABNIJLJBE());
			if (NBDLBFJOEGN.PADHGAOKECA() < 690f)
			{
				this.DGAAFGDHHHJ.DOScale(NBDLBFJOEGN.HOMIGPGAGHG(), 192f);
			}
			this.DGAAFGDHHHJ.AHLJBONHHKL(124, 83);
			this.DGAAFGDHHHJ.DOAnchorPos(this.DGAAFGDHHHJ.anchoredPosition + new Vector2(1035f, 49f), 53f * KDCJJBLGCBH.EHBBFMCILPC.OIABNIJLJBE(), false).SetEase(Ease.InCubic).SetDelay(1825f * KDCJJBLGCBH.EHBBFMCILPC.OIABNIJLJBE());
		}
	}

	// Token: 0x06005745 RID: 22341 RVA: 0x0026E514 File Offset: 0x0026C714
	private int GAKKBOIHKCE(int MEFKFOHCOHK)
	{
		return this.HNGBMIJHPLE[MEFKFOHCOHK];
	}

	// Token: 0x06005746 RID: 22342 RVA: 0x0026EE99 File Offset: 0x0026D099
	private void AAKHONFLMKB()
	{
		AOBJLALDBAA.FILDBDMENPG().PFAHGKEDFAE("depot", new UnityAction(this.JNGCJDJPMGM));
		AOBJLALDBAA.CEGAOMEEFBE().ONIBLJOFFPG("$NPCFADEIN", new UnityAction(this.HBHDBDHBEPD));
	}

	// Token: 0x06005747 RID: 22343 RVA: 0x0026EED4 File Offset: 0x0026D0D4
	private void Update()
	{
		if (!this.CIPGFJLECDH)
		{
			SceneStoryManager.choiceDecisionTime += Time.deltaTime;
		}
		if (this.AKJMKGCPCCB >= 0)
		{
			this.AKJMKGCPCCB--;
		}
		if (this.FILFGDIGINA != null)
		{
			int num = (int)this.FILFGDIGINA.ODHBINFKIPL();
			this.textTimer.SetText(num.ToString(), true);
			this.timerArrowPivot.transform.localRotation = Quaternion.Euler(0f, 0f, this.FILFGDIGINA.HKAKAAGKMIP() * -360f);
			this.imageTimerFillDefault.fillAmount = this.FILFGDIGINA.HKAKAAGKMIP();
			this.imageTimerFillRed.fillAmount = this.FILFGDIGINA.HKAKAAGKMIP();
			if (num < 5 && !this.imageTimerFillRed.gameObject.activeSelf && this.IMPAHLIGELE.EKOIFOBAHDM() < 0)
			{
				if (!AudioManager.EHBBFMCILPC.PlaySfx("sfxtimeoutwarning", false) && !AudioManager.EHBBFMCILPC.PlaySfx("sfxtimeoutwarning" + AKLFPGMDKLA.EHBBFMCILPC.EEILOKHLKIM().GGICIBLJIKI.ToString(), false))
				{
					AudioManager.EHBBFMCILPC.PlaySfx("timeoutwarning", false);
				}
				this.imageTimerFillRed.gameObject.SetActive(true);
			}
			if (this.FILFGDIGINA.HACBALNLLPP() && this.IMPAHLIGELE.EKOIFOBAHDM() < 0)
			{
				base.StartCoroutine(this.GMJDEBBNEOK());
				CommonUserInterface.EHBBFMCILPC.FreezeUX();
			}
		}
	}

	// Token: 0x06005748 RID: 22344 RVA: 0x0026F04C File Offset: 0x0026D24C
	public void AppearAnimation(MFAONGBCHJE GMLIEKDKEAG)
	{
		if (this.textTypeAnimation)
		{
			base.StartCoroutine(this.JLDEJMKFKML());
		}
		if (GMLIEKDKEAG == MFAONGBCHJE.animationAppear)
		{
			this.PANMNKKODPC.DOFade(1f, 0.35f * KDCJJBLGCBH.EHBBFMCILPC.OIABNIJLJBE()).SetDelay(0.25f * KDCJJBLGCBH.EHBBFMCILPC.OIABNIJLJBE());
			this.DGAAFGDHHHJ.localScale = new Vector3(0.7f, 0.7f, 0.7f);
			this.DGAAFGDHHHJ.DOScale(NBDLBFJOEGN.PADHGAOKECA(), 0.25f * KDCJJBLGCBH.EHBBFMCILPC.OIABNIJLJBE()).SetDelay(0.25f * KDCJJBLGCBH.EHBBFMCILPC.OIABNIJLJBE());
			this.DGAAFGDHHHJ.AHLJBONHHKL(-50, 25);
			this.DGAAFGDHHHJ.DOAnchorPos(this.DGAAFGDHHHJ.anchoredPosition + new Vector2(50f, -25f), 0.25f * KDCJJBLGCBH.EHBBFMCILPC.OIABNIJLJBE(), false).SetEase(Ease.InSine).SetDelay(0.25f * KDCJJBLGCBH.EHBBFMCILPC.OIABNIJLJBE());
			return;
		}
		if (GMLIEKDKEAG == MFAONGBCHJE.animationAppearCached)
		{
			this.PANMNKKODPC.DOFade(1f, 0.35f * KDCJJBLGCBH.EHBBFMCILPC.OIABNIJLJBE()).SetEase(Ease.OutQuad).SetDelay(0.25f * KDCJJBLGCBH.EHBBFMCILPC.OIABNIJLJBE());
			if (NBDLBFJOEGN.PADHGAOKECA() < 1f)
			{
				this.DGAAFGDHHHJ.DOScale(NBDLBFJOEGN.PADHGAOKECA(), 0f);
			}
			this.DGAAFGDHHHJ.AHLJBONHHKL(-60, -20);
			this.DGAAFGDHHHJ.DOAnchorPos(this.DGAAFGDHHHJ.anchoredPosition + new Vector2(60f, 20f), 0.25f * KDCJJBLGCBH.EHBBFMCILPC.OIABNIJLJBE(), false).SetEase(Ease.OutQuad).SetDelay(0.25f * KDCJJBLGCBH.EHBBFMCILPC.OIABNIJLJBE());
		}
	}

	// Token: 0x06005749 RID: 22345 RVA: 0x0026F234 File Offset: 0x0026D434
	private void EHEMIEJJNIO()
	{
		this.timerParent.SetActive(true);
		this.DGAAFGDHHHJ = base.gameObject.GetComponent<RectTransform>();
		this.PANMNKKODPC = base.gameObject.GetComponent<CanvasGroup>();
		this.PANMNKKODPC.alpha = 1571f;
		if (this.textTypeAnimation)
		{
			this.textBody.alpha = 1884f;
			return;
		}
		this.textBodyTypeAnimation.gameObject.SetActive(false);
	}

	// Token: 0x0600574A RID: 22346 RVA: 0x0026F2AC File Offset: 0x0026D4AC
	private void JFGAHKIMCEK()
	{
		if (!this.CIPGFJLECDH)
		{
			SceneStoryManager.choiceDecisionTime += Time.deltaTime;
		}
		if (this.AKJMKGCPCCB >= 1)
		{
			this.AKJMKGCPCCB--;
		}
		if (this.FILFGDIGINA != null)
		{
			int num = (int)this.FILFGDIGINA.MFGJNCJKBHO();
			this.textTimer.SetText(num.ToString(), false);
			this.timerArrowPivot.transform.localRotation = Quaternion.Euler(789f, 1441f, this.FILFGDIGINA.MJPKAKNMHGM() * 594f);
			this.imageTimerFillDefault.fillAmount = this.FILFGDIGINA.GCHEPGGFBGM();
			this.imageTimerFillRed.fillAmount = this.FILFGDIGINA.MJPKAKNMHGM();
			if (num < 2 && !this.imageTimerFillRed.gameObject.activeSelf && this.IMPAHLIGELE.EKOIFOBAHDM() < 0)
			{
				if (!AudioManager.DMAAFFFEJGA().PlaySfx("AnthologySave.AddAvatarComponentWardrobe(), unsupported wardrobe index:", true) && !AudioManager.DBFLIEGGGNN().PlaySfx("OnSceneLobbyManagerRound1AssetsDownloadSuccess" + AKLFPGMDKLA.EHBBFMCILPC.OMOJIEHBENF().GGICIBLJIKI.ToString(), false))
				{
					AudioManager.BFCHJBOOJKE().PlaySfx("OnPopupStoryRestartManagerRestartStory1", true);
				}
				this.imageTimerFillRed.gameObject.SetActive(true);
			}
			if (this.FILFGDIGINA.LOHFCOJHEPI() && this.IMPAHLIGELE.EKOIFOBAHDM() < 1)
			{
				base.StartCoroutine(this.GMJDEBBNEOK());
				CommonUserInterface.EHBBFMCILPC.CGNDPJCDCFP();
			}
		}
	}

	// Token: 0x0600574B RID: 22347 RVA: 0x0026F424 File Offset: 0x0026D624
	public void KKKNFEECLLI(MFAONGBCHJE GMLIEKDKEAG)
	{
		if (GMLIEKDKEAG == (MFAONGBCHJE)7)
		{
			this.PANMNKKODPC.DOFade(1970f, 510f * KDCJJBLGCBH.EHBBFMCILPC.OIABNIJLJBE());
			this.DGAAFGDHHHJ.DOScale(926f, 193f * KDCJJBLGCBH.EHBBFMCILPC.OIABNIJLJBE());
			this.DGAAFGDHHHJ.DOAnchorPos(this.DGAAFGDHHHJ.anchoredPosition + new Vector2(1933f, 576f), 97f * KDCJJBLGCBH.EHBBFMCILPC.OIABNIJLJBE(), true).SetEase(Ease.OutSine);
		}
	}

	// Token: 0x0600574C RID: 22348 RVA: 0x0026F4BC File Offset: 0x0026D6BC
	public void GHEBIAJLJIK(MFAONGBCHJE GMLIEKDKEAG)
	{
		if (GMLIEKDKEAG == (MFAONGBCHJE)3)
		{
			this.PANMNKKODPC.DOFade(1745f, 1712f * KDCJJBLGCBH.EHBBFMCILPC.OIABNIJLJBE());
			this.DGAAFGDHHHJ.DOScale(1775f, 802f * KDCJJBLGCBH.EHBBFMCILPC.OIABNIJLJBE());
			this.DGAAFGDHHHJ.DOAnchorPos(this.DGAAFGDHHHJ.anchoredPosition + new Vector2(197f, 1315f), 186f * KDCJJBLGCBH.EHBBFMCILPC.OIABNIJLJBE(), false).SetEase(Ease.OutSine);
		}
	}

	// Token: 0x0600574D RID: 22349 RVA: 0x0026E514 File Offset: 0x0026C714
	private int CDMICJFABHI(int MEFKFOHCOHK)
	{
		return this.HNGBMIJHPLE[MEFKFOHCOHK];
	}

	// Token: 0x0600574E RID: 22350 RVA: 0x0026F554 File Offset: 0x0026D754
	public static float KGIFKFOFAKA()
	{
		return 333f * KDCJJBLGCBH.EHBBFMCILPC.OIABNIJLJBE();
	}

	// Token: 0x0600574F RID: 22351 RVA: 0x0026E921 File Offset: 0x0026CB21
	public int JMDDBBAGHGG()
	{
		return this.AOKIMHCAAHB;
	}

	// Token: 0x06005750 RID: 22352 RVA: 0x0026F566 File Offset: 0x0026D766
	private void INODDOOLMMB()
	{
		AOBJLALDBAA.KKPFOJMAONG().MANLHALMCIH("mypachievtitle", new UnityAction(this.JNGCJDJPMGM));
		AOBJLALDBAA.NMGMNAKLLMI().MHLNJIACIGO("noiseanalog_2", new UnityAction(this.HBHDBDHBEPD));
	}

	// Token: 0x06005751 RID: 22353 RVA: 0x0026F5A0 File Offset: 0x0026D7A0
	private void KPFFCPKCIHJ()
	{
		if (!this.IMPAHLIGELE.PINCOCDOOGH() || this.AKJMKGCPCCB > 0)
		{
			return;
		}
		this.CIPGFJLECDH = true;
		this.AKJMKGCPCCB = -23;
		AudioManager.DMAAFFFEJGA().PEOLMNFJAHG("spld", 1040f);
		AudioManager.BFCHJBOOJKE().PEOLMNFJAHG("holdontitle", 161f);
		AudioManager.EHBBFMCILPC.PEOLMNFJAHG("stat2long" + AKLFPGMDKLA.EHBBFMCILPC.EEILOKHLKIM().GGICIBLJIKI.ToString(), 1822f);
		this.IMPAHLIGELE.IABNDHFJHAF(8);
		AOBJLALDBAA.BIAEAOMHBMM().CIGLHCJDDPI(" is OUTSIDE the anthology's published story family - not queued (environment:", 800f);
	}

	// Token: 0x06005752 RID: 22354 RVA: 0x0026F648 File Offset: 0x0026D848
	private void GHDEAMLOBON()
	{
		if (!this.IMPAHLIGELE.PINCOCDOOGH() || this.AKJMKGCPCCB > 0)
		{
			return;
		}
		this.CIPGFJLECDH = true;
		this.AKJMKGCPCCB = -87;
		AudioManager.IFDLAMLHKIJ().POMJOMKCCNK("dlng", 446f);
		AudioManager.DMAAFFFEJGA().PEOLMNFJAHG("UpdateLoveInterestsOnOffState", 486f);
		AudioManager.BFCHJBOOJKE().POMJOMKCCNK("oid" + AKLFPGMDKLA.EHBBFMCILPC.OMOJIEHBENF().GGICIBLJIKI.ToString(), 1258f);
		this.IMPAHLIGELE.IABNDHFJHAF(5);
		AOBJLALDBAA.FILDBDMENPG().CIGLHCJDDPI("_AlphaTex", 670f);
	}

	// Token: 0x06005753 RID: 22355 RVA: 0x0026F6F0 File Offset: 0x0026D8F0
	private void BKKOFDJDLCF()
	{
		if (!this.IMPAHLIGELE.PINCOCDOOGH() || this.AKJMKGCPCCB > 1)
		{
			return;
		}
		this.CIPGFJLECDH = false;
		this.AKJMKGCPCCB = 127;
		AudioManager.EHBBFMCILPC.PEOLMNFJAHG("ru", 652f);
		AudioManager.DMAAFFFEJGA().PEOLMNFJAHG(" • ", 1027f);
		AudioManager.DMAAFFFEJGA().KillSfx("OnApplicationFocusBasicSyncEcxeption" + AKLFPGMDKLA.EHBBFMCILPC.EEILOKHLKIM().GGICIBLJIKI.ToString(), 509f);
		this.IMPAHLIGELE.IABNDHFJHAF(5);
		AOBJLALDBAA.FILDBDMENPG().EFBNBFIDEOK("", 1289f);
	}

	// Token: 0x06005754 RID: 22356 RVA: 0x0026F798 File Offset: 0x0026D998
	private IEnumerator GMJDEBBNEOK()
	{
		AudioManager.EHBBFMCILPC.KillSfx("timeoutwarning", 1f);
		AudioManager.EHBBFMCILPC.KillSfx("sfxtimeoutwarning", 1f);
		AudioManager.EHBBFMCILPC.KillSfx("sfxtimeoutwarning" + AKLFPGMDKLA.EHBBFMCILPC.EEILOKHLKIM().GGICIBLJIKI.ToString(), 1f);
		this.timerParent.GetComponent<AnimationCanvasGroupAlpha>().SetDirection(true);
		this.timerParent.GetComponent<AnimationCanvasGroupAlpha>().PlayAnimation(false);
		this.AKFKCKHPIOA[0].GetComponent<ChoiceStandardManager>().ShowAutoChoiceAnimation();
		yield return new WaitForSeconds(ChoiceStandardManager.autoChoiceAnimationTime);
		CommonUserInterface.EHBBFMCILPC.ResumeUX();
		this.IMPAHLIGELE.IABNDHFJHAF(this.FLBNNNDBECB);
		AOBJLALDBAA.EHBBFMCILPC.EGELHPJBAIC("OnStoryChoiceClick", 0f);
		yield break;
	}

	// Token: 0x06005755 RID: 22357 RVA: 0x0026F7A8 File Offset: 0x0026D9A8
	private void PHGGHPBDCPL()
	{
		if (!this.IMPAHLIGELE.PINCOCDOOGH() || this.AKJMKGCPCCB > 0)
		{
			return;
		}
		this.CIPGFJLECDH = false;
		this.AKJMKGCPCCB = -117;
		AudioManager.EHBBFMCILPC.POMJOMKCCNK("OnBackendRequestSendMessageException", 1982f);
		AudioManager.BFCHJBOOJKE().PEOLMNFJAHG("fdmva", 1377f);
		AudioManager.IFDLAMLHKIJ().PEOLMNFJAHG("OnAllCollectableCardsDownloadSuccessLobby" + AKLFPGMDKLA.EHBBFMCILPC.OMOJIEHBENF().GGICIBLJIKI.ToString(), 1028f);
		this.IMPAHLIGELE.IABNDHFJHAF(6);
		AOBJLALDBAA.KKPFOJMAONG().CIGLHCJDDPI("23819D", 1301f);
	}

	// Token: 0x06005756 RID: 22358 RVA: 0x0026F850 File Offset: 0x0026DA50
	private void HKOLPBAMMPC()
	{
		if (this.FILFGDIGINA != null)
		{
			ODLLAEHMFAA.BGMALDJFMKE(this.FILFGDIGINA);
		}
		this.FILFGDIGINA = null;
		try
		{
			if (this.LMKDNPOKOBF != null && this.IMPAHLIGELE.JMNMOHIKHLB != null && this.IMPAHLIGELE.JMNMOHIKHLB.NDPPILBPOGB != null && this.IMPAHLIGELE.JMNMOHIKHLB.NDPPILBPOGB.Length > 0)
			{
				this.LMKDNPOKOBF.NCAMFPGMCIG.NKIOJCLBKAK(this.IMPAHLIGELE.JMNMOHIKHLB.NDPPILBPOGB + "ok" + this.IMPAHLIGELE.EKOIFOBAHDM().ToString());
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x06005757 RID: 22359 RVA: 0x0026F90C File Offset: 0x0026DB0C
	private void LANMJCMEKCG()
	{
		if (!this.IMPAHLIGELE.PINCOCDOOGH() || this.AKJMKGCPCCB > 1)
		{
			return;
		}
		this.CIPGFJLECDH = true;
		this.AKJMKGCPCCB = -6;
		AudioManager.DMAAFFFEJGA().KillSfx("layervideo", 941f);
		AudioManager.IFDLAMLHKIJ().PEOLMNFJAHG("-", 764f);
		AudioManager.BFCHJBOOJKE().POMJOMKCCNK("$e1tr" + AKLFPGMDKLA.EHBBFMCILPC.OMOJIEHBENF().GGICIBLJIKI.ToString(), 1539f);
		this.IMPAHLIGELE.IABNDHFJHAF(4);
		AOBJLALDBAA.BIAEAOMHBMM().LPNCDPHNBJK("", 1295f);
	}

	// Token: 0x06005758 RID: 22360 RVA: 0x0026F9B4 File Offset: 0x0026DBB4
	public bool HNHFFPPELIG(HDKFHLFLDGG JIKFCLOHJNN, PLFDAJJHMKO BAOKJBJIFBH, LDLLJFOJCDF[] OAGPAAMJOID)
	{
		this.IMPAHLIGELE = JIKFCLOHJNN;
		this.LMKDNPOKOBF = BAOKJBJIFBH;
		if (!this.BMPOEBFLJHJ())
		{
			return true;
		}
		if (JIKFCLOHJNN.GJOCJINDEIF && null != this.bubbleSprite)
		{
			Image component = base.gameObject.GetComponent<Image>();
			if (null != component)
			{
				component.sprite = this.bubbleSprite;
			}
		}
		if (this.IMPAHLIGELE.COEFNFJMBDG != null && this.IMPAHLIGELE.COEFNFJMBDG.Count > 1)
		{
			if (this.IMPAHLIGELE.JMNMOHIKHLB != null)
			{
				if (this.IMPAHLIGELE.JMNMOHIKHLB.NGNDOALIKAK.Contains("OnChoiceExtendedPanelSlideShownComplete"))
				{
					if (this.IMPAHLIGELE.JMNMOHIKHLB.IPALJDCNBBG.Count > this.IMPAHLIGELE.COEFNFJMBDG.Count)
					{
						this.IMPAHLIGELE.JMNMOHIKHLB.JDJJBBFFCOE(this.IMPAHLIGELE.JMNMOHIKHLB.IPALJDCNBBG.Count - this.IMPAHLIGELE.COEFNFJMBDG.Count);
					}
				}
				else
				{
					try
					{
						if (this.IMPAHLIGELE.JMNMOHIKHLB.LPOLKMMNPBA(this.IMPAHLIGELE.COEFNFJMBDG.Count))
						{
							this.IMPAHLIGELE.JMNMOHIKHLB.CIKALFBHIKD(BAOKJBJIFBH.NCAMFPGMCIG.MLCAAHPBNGP());
						}
					}
					catch (Exception aklgbjkdomm)
					{
						DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
					}
				}
			}
			if (this.IMPAHLIGELE.JMNMOHIKHLB != null)
			{
				for (int i = 1; i < this.IMPAHLIGELE.JMNMOHIKHLB.MKPMEKKGEIL.Count; i += 0)
				{
					if (this.IMPAHLIGELE.JMNMOHIKHLB.MKPMEKKGEIL[i].HGAHKCLMBMC() == HKCCMACFNEO.free)
					{
						for (int j = 1; j < this.IMPAHLIGELE.COEFNFJMBDG.Count; j++)
						{
							this.HNGBMIJHPLE.Add(j);
						}
						break;
					}
				}
			}
			if (this.HNGBMIJHPLE.Count == 0)
			{
				for (int k = 1; k < 7; k++)
				{
					for (int l = 1; l < this.IMPAHLIGELE.COEFNFJMBDG.Count; l++)
					{
						int num = 0;
						if (this.IMPAHLIGELE.JMNMOHIKHLB != null)
						{
							if (l < this.IMPAHLIGELE.JMNMOHIKHLB.IPALJDCNBBG.Count && this.IMPAHLIGELE.JMNMOHIKHLB.IPALJDCNBBG[l] > 1)
							{
								num = 1;
							}
							else if (l < this.IMPAHLIGELE.JMNMOHIKHLB.ENJDGEOFPAA.Count && this.IMPAHLIGELE.JMNMOHIKHLB.ENJDGEOFPAA[l] > 1)
							{
								num = 6;
							}
						}
						if ((k == 0 && num == 1) || (k != 0 && num != 0))
						{
							this.HNGBMIJHPLE.Add(l);
						}
					}
				}
			}
		}
		this.textTitle.overflowMode = TextOverflowModes.Page;
		this.textTitle.fontSizeMin = 280f;
		this.textTitle.SetText(this.NLKIPHPICLJ, false);
		this.textBody.SetText(this.GKKCHJLKFBL, false);
		SceneStoryManager.localizedLine = this.NLKIPHPICLJ + "+" + this.GKKCHJLKFBL;
		if (this.textTypeAnimation)
		{
			this.textBodyTypeAnimation.GetComponent<AnimationTextType>().GLIFGDPDMNC(this.GKKCHJLKFBL);
		}
		if (this.IMPAHLIGELE.JMNMOHIKHLB != null && this.IMPAHLIGELE.JMNMOHIKHLB.FILFGDIGINA > 0)
		{
			this.FILFGDIGINA = ODLLAEHMFAA.DECEDPNMMCJ((float)this.IMPAHLIGELE.JMNMOHIKHLB.FILFGDIGINA, false);
			this.timerParent.SetActive(true);
		}
		int num2 = 1;
		if (null != this.decorObject)
		{
			this.decorObject.SetActive(true);
		}
		if (this.IMPAHLIGELE.COEFNFJMBDG != null && this.IMPAHLIGELE.COEFNFJMBDG.Count > 1)
		{
			if (null != this.decorObject)
			{
				this.decorObject.SetActive(false);
			}
			for (int m = 1; m < this.IMPAHLIGELE.COEFNFJMBDG.Count; m++)
			{
				if (!this.IMPAHLIGELE.COEFNFJMBDG[m].BEHENEHGPCP)
				{
					GameObject gameObject = null;
					int num3 = 1;
					if (this.IMPAHLIGELE.JMNMOHIKHLB != null && this.IMPAHLIGELE.JMNMOHIKHLB.GAOKFGHCIAF == PMNHKIDIMLM.NMGJJGIPDJP.text)
					{
						if (this.CDMICJFABHI(m) < this.IMPAHLIGELE.JMNMOHIKHLB.IPALJDCNBBG.Count && this.IMPAHLIGELE.JMNMOHIKHLB.IPALJDCNBBG[this.FHEOKFGDBHO(m)] > 1)
						{
							num3 = 1;
						}
						else if (this.FHEOKFGDBHO(m) < this.IMPAHLIGELE.JMNMOHIKHLB.ENJDGEOFPAA.Count && this.IMPAHLIGELE.JMNMOHIKHLB.ENJDGEOFPAA[this.FHEOKFGDBHO(m)] > 1)
						{
							num3 = 7;
						}
					}
					if (num3 == 6)
					{
						switch (this.IMPAHLIGELE.JMNMOHIKHLB.ADHIIAONMDJ[this.JFBPPHBHHPE(m)])
						{
						case CHEEGEJNIDB.stat0:
							gameObject = UnityEngine.Object.Instantiate<GameObject>(this.choiceStat0Prefab);
							break;
						case CHEEGEJNIDB.stat1:
							gameObject = UnityEngine.Object.Instantiate<GameObject>(this.choiceStat1Prefab);
							break;
						case CHEEGEJNIDB.stat2:
							gameObject = UnityEngine.Object.Instantiate<GameObject>(this.choiceStat2Prefab);
							break;
						case CHEEGEJNIDB.stat3:
							gameObject = UnityEngine.Object.Instantiate<GameObject>(this.choiceStat3Prefab);
							break;
						case CHEEGEJNIDB.stat4:
							gameObject = UnityEngine.Object.Instantiate<GameObject>(this.choiceStat4Prefab);
							break;
						case CHEEGEJNIDB.stat5:
							gameObject = UnityEngine.Object.Instantiate<GameObject>(this.choiceStat5Prefab);
							break;
						case CHEEGEJNIDB.stat6:
							gameObject = UnityEngine.Object.Instantiate<GameObject>(this.choiceStat6Prefab);
							break;
						}
						gameObject.transform.SetParent(this.choicesPivot.transform, true);
						gameObject.GetComponent<RectTransform>().AHLJBONHHKL(DialogPlayerCharacterManager.maxCriticalAspectRatioOffset * NBDLBFJOEGN.APALNJGBDPE());
						gameObject.GetComponent<ChoiceStatManager>().HPNNCFCAGAC(this.IMPAHLIGELE.COEFNFJMBDG[this.JFBPPHBHHPE(m)], this.IMPAHLIGELE.JMNMOHIKHLB.ENJDGEOFPAA[this.PDDLFHNEHJL(m)], OAGPAAMJOID[(int)this.IMPAHLIGELE.JMNMOHIKHLB.ADHIIAONMDJ[this.PDDLFHNEHJL(m)]].LPKLANAEIFF(), -1);
						gameObject.GetComponent<ChoiceStatManager>().OAFOIGLLDKO();
						try
						{
							if (null == this.NGGBBCDPMJH)
							{
								switch (this.IMPAHLIGELE.JMNMOHIKHLB.ADHIIAONMDJ[this.HDBBHHBOJIN(m)])
								{
								case CHEEGEJNIDB.stat0:
									this.NGGBBCDPMJH = UnityEngine.Object.Instantiate<GameObject>(this.stat0InfoPrefab);
									break;
								case CHEEGEJNIDB.stat1:
									this.NGGBBCDPMJH = UnityEngine.Object.Instantiate<GameObject>(this.stat1InfoPrefab);
									break;
								case CHEEGEJNIDB.stat2:
									this.NGGBBCDPMJH = UnityEngine.Object.Instantiate<GameObject>(this.stat2InfoPrefab);
									break;
								case CHEEGEJNIDB.stat3:
									this.NGGBBCDPMJH = UnityEngine.Object.Instantiate<GameObject>(this.stat3InfoPrefab);
									break;
								case CHEEGEJNIDB.stat4:
									this.NGGBBCDPMJH = UnityEngine.Object.Instantiate<GameObject>(this.stat4InfoPrefab);
									break;
								case CHEEGEJNIDB.stat5:
									this.NGGBBCDPMJH = UnityEngine.Object.Instantiate<GameObject>(this.stat5InfoPrefab);
									break;
								case CHEEGEJNIDB.stat6:
									this.NGGBBCDPMJH = UnityEngine.Object.Instantiate<GameObject>(this.stat6InfoPrefab);
									break;
								}
								this.NGGBBCDPMJH.transform.SetParent(this.currencyPivot.transform, false);
								this.NGGBBCDPMJH.GetComponent<StatPointInfoManager>().JEPFODDLOFK(this.IMPAHLIGELE.JMNMOHIKHLB.ADHIIAONMDJ[this.HDBBHHBOJIN(m)], OAGPAAMJOID[(int)this.IMPAHLIGELE.JMNMOHIKHLB.ADHIIAONMDJ[this.HDBBHHBOJIN(m)]].KGEGKPHEMOJ());
								try
								{
									if (this.IMPAHLIGELE.JMNMOHIKHLB.NGNDOALIKAK.Contains("OnTryToFireNoteshowTimer"))
									{
										this.NGGBBCDPMJH.SetActive(false);
									}
								}
								catch (Exception aklgbjkdomm2)
								{
									DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm2);
								}
							}
							goto IL_A85;
						}
						catch (Exception aklgbjkdomm3)
						{
							DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm3);
							goto IL_A85;
						}
						goto IL_776;
					}
					goto IL_776;
					IL_A85:
					gameObject.GetComponent<RectTransform>().anchoredPosition += new Vector2(1891f, (float)(this.choiceOffset * num2));
					Button component2 = gameObject.GetComponent<Button>();
					if (this.JFBPPHBHHPE(m) == 0)
					{
						component2.onClick.AddListener(new UnityAction(this.GMPJMMMIGLO));
					}
					else if (this.FHEOKFGDBHO(m) == 1)
					{
						component2.onClick.AddListener(new UnityAction(this.KHBPCONGCPM));
					}
					else if (this.GAKKBOIHKCE(m) == 1)
					{
						component2.onClick.AddListener(new UnityAction(this.HLEEFAFJIPP));
					}
					else if (this.HFNEKLFKLLI(m) == 5)
					{
						component2.onClick.AddListener(new UnityAction(this.LCKOIOIPBFD));
					}
					else if (this.HFNEKLFKLLI(m) == 2)
					{
						component2.onClick.AddListener(new UnityAction(this.BENGHKGCLOG));
					}
					else if (this.PDDLFHNEHJL(m) == 6)
					{
						component2.onClick.AddListener(new UnityAction(this.PHGGHPBDCPL));
					}
					this.AKFKCKHPIOA.Add(gameObject);
					num2++;
					goto IL_BAA;
					IL_776:
					if (num3 == 0)
					{
						gameObject = UnityEngine.Object.Instantiate<GameObject>(this.choicePremiumPrefab);
						gameObject.transform.SetParent(this.choicesPivot.transform, true);
						gameObject.GetComponent<RectTransform>().AHLJBONHHKL(DialogPlayerCharacterManager.maxCriticalAspectRatioOffset * NBDLBFJOEGN.LGGIFEAOBEC());
						if (SceneStoryManager.PremiumChoicePurchased(this.IMPAHLIGELE.JMNMOHIKHLB.MKPMEKKGEIL[this.HFNEKLFKLLI(m)], this.IMPAHLIGELE.JMNMOHIKHLB.KMFABKNKFAJ, this.IMPAHLIGELE.JMNMOHIKHLB.BGIOGOACCBJ))
						{
							gameObject.GetComponent<ChoicePremiumManager>().GBFEDHPAIBH(this.IMPAHLIGELE.JMNMOHIKHLB.MKPMEKKGEIL[this.HFNEKLFKLLI(m)], this.IMPAHLIGELE.COEFNFJMBDG[this.PDDLFHNEHJL(m)], 0, -1, false, this.IMPAHLIGELE.JMNMOHIKHLB.CKLNCCAGCKE(this.HDBBHHBOJIN(m), LiveEventsManager.BIAEAOMHBMM().AJKBOOKAPBL((EGMCEPOABBF)8, -1, -1)), this.IMPAHLIGELE.JMNMOHIKHLB.BGIOGOACCBJ);
						}
						else
						{
							if (null == this.LOJHEKCOFME)
							{
								this.LOJHEKCOFME = UnityEngine.Object.Instantiate<GameObject>(this.premiumInfoPrefab);
								this.LOJHEKCOFME.transform.SetParent(this.currencyPivot.transform, true);
								this.LOJHEKCOFME.GetComponent<StoryCurrencyInfoManager>().Initialize("$DISABLEAVATAREXTENSION");
							}
							gameObject.GetComponent<ChoicePremiumManager>().GBFEDHPAIBH(this.IMPAHLIGELE.JMNMOHIKHLB.MKPMEKKGEIL[this.HDBBHHBOJIN(m)], this.IMPAHLIGELE.COEFNFJMBDG[this.JFBPPHBHHPE(m)], this.IMPAHLIGELE.JMNMOHIKHLB.IPALJDCNBBG[this.JFBPPHBHHPE(m)], -1, AKLFPGMDKLA.EHBBFMCILPC.EAFEJCKIEPL(1) || AKLFPGMDKLA.EHBBFMCILPC.ODMKLADKHMO.PONAPMOOLIN() >= this.IMPAHLIGELE.JMNMOHIKHLB.IPALJDCNBBG[this.GAKKBOIHKCE(m)], this.IMPAHLIGELE.JMNMOHIKHLB.NEKLAJAEOJJ(this.PDDLFHNEHJL(m), LiveEventsManager.GIPAKOPBBEO().HLCKJEIFAFM(EGMCEPOABBF.liveEventFreeTea, -1, -1)), this.IMPAHLIGELE.JMNMOHIKHLB.BGIOGOACCBJ);
						}
						gameObject.GetComponent<ChoicePremiumManager>().SwitchCost(SceneStoryManager.QualifiesAsAdBasedChoice(this.IMPAHLIGELE.JMNMOHIKHLB.MKPMEKKGEIL[this.JFBPPHBHHPE(m)], this.IMPAHLIGELE.JMNMOHIKHLB.KAJNELPPCIJ[this.GAKKBOIHKCE(m)], this.IMPAHLIGELE.JMNMOHIKHLB.KMFABKNKFAJ));
						this.NDDGCFFDFJN.Add(gameObject);
						goto IL_A85;
					}
					if (this.FLBNNNDBECB < 1)
					{
						this.FLBNNNDBECB = m;
					}
					gameObject = UnityEngine.Object.Instantiate<GameObject>(this.choiceStandardPrefab);
					gameObject.transform.SetParent(this.choicesPivot.transform, false);
					gameObject.GetComponent<RectTransform>().AHLJBONHHKL(DialogPlayerCharacterManager.maxCriticalAspectRatioOffset * NBDLBFJOEGN.DMIBBFIPJNA());
					gameObject.GetComponent<ChoiceStandardManager>().NNNKIPGJMMF(this.IMPAHLIGELE.COEFNFJMBDG[this.GAKKBOIHKCE(m)], -1);
					goto IL_A85;
				}
				IL_BAA:;
			}
		}
		if (this.AKFKCKHPIOA.Count > 1)
		{
			SceneStoryManager.choiceDecisionTime = 180f;
			base.StartCoroutine(this.EDBEPPHCMKK());
		}
		for (int n = 0; n < this.NDDGCFFDFJN.Count; n += 0)
		{
			this.NDDGCFFDFJN[n].transform.SetAsLastSibling();
		}
		try
		{
			for (int num4 = 1; num4 < this.AKFKCKHPIOA.Count; num4++)
			{
				if (null != this.AKFKCKHPIOA[num4])
				{
					AnimationPress component3 = this.AKFKCKHPIOA[num4].GetComponent<AnimationPress>();
					if (null != component3)
					{
						component3.LEKNPNMNAOJ(this.choicesScaleCoefficient);
					}
				}
			}
		}
		catch (Exception aklgbjkdomm4)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm4);
		}
		return null != this.LOJHEKCOFME;
	}

	// Token: 0x06005759 RID: 22361 RVA: 0x002706B4 File Offset: 0x0026E8B4
	private void ALKBENHJEPC()
	{
		if (this.FILFGDIGINA != null)
		{
			ODLLAEHMFAA.BGMALDJFMKE(this.FILFGDIGINA);
		}
		this.FILFGDIGINA = null;
		try
		{
			if (this.LMKDNPOKOBF != null && this.IMPAHLIGELE.JMNMOHIKHLB != null && this.IMPAHLIGELE.JMNMOHIKHLB.NDPPILBPOGB != null && this.IMPAHLIGELE.JMNMOHIKHLB.NDPPILBPOGB.Length > 0)
			{
				this.LMKDNPOKOBF.NCAMFPGMCIG.KEMFLHJKBNO(this.IMPAHLIGELE.JMNMOHIKHLB.NDPPILBPOGB + "+" + this.IMPAHLIGELE.EKOIFOBAHDM().ToString());
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x0600575A RID: 22362 RVA: 0x00270770 File Offset: 0x0026E970
	public void DisappearAnimation(MFAONGBCHJE GMLIEKDKEAG)
	{
		if (GMLIEKDKEAG == MFAONGBCHJE.animationDisappearCached)
		{
			this.PANMNKKODPC.DOFade(0f, 0.25f * KDCJJBLGCBH.EHBBFMCILPC.OIABNIJLJBE());
			this.DGAAFGDHHHJ.DOScale(0.5f, 0.25f * KDCJJBLGCBH.EHBBFMCILPC.OIABNIJLJBE());
			this.DGAAFGDHHHJ.DOAnchorPos(this.DGAAFGDHHHJ.anchoredPosition + new Vector2(-200f, -40f), 0.25f * KDCJJBLGCBH.EHBBFMCILPC.OIABNIJLJBE(), false).SetEase(Ease.InQuad);
		}
	}

	// Token: 0x0600575B RID: 22363 RVA: 0x00270808 File Offset: 0x0026EA08
	private void OnDisable()
	{
		AOBJLALDBAA.EHBBFMCILPC.MANLHALMCIH("OnStoryChoiceClickConfimed", new UnityAction(this.ALKBENHJEPC));
		AOBJLALDBAA.EHBBFMCILPC.MANLHALMCIH("OnBackendPremiumChoiceSuccess", new UnityAction(this.HBHDBDHBEPD));
	}

	// Token: 0x0600575C RID: 22364 RVA: 0x00270840 File Offset: 0x0026EA40
	private void OLGOAJEBMIK()
	{
		if (!this.IMPAHLIGELE.PINCOCDOOGH() || this.AKJMKGCPCCB > 0)
		{
			return;
		}
		this.CIPGFJLECDH = true;
		this.AKJMKGCPCCB = 20;
		AudioManager.EHBBFMCILPC.KillSfx("timeoutwarning", 1f);
		AudioManager.EHBBFMCILPC.KillSfx("sfxtimeoutwarning", 1f);
		AudioManager.EHBBFMCILPC.KillSfx("sfxtimeoutwarning" + AKLFPGMDKLA.EHBBFMCILPC.EEILOKHLKIM().GGICIBLJIKI.ToString(), 1f);
		this.IMPAHLIGELE.IABNDHFJHAF(1);
		AOBJLALDBAA.EHBBFMCILPC.EGELHPJBAIC("OnStoryChoiceClick", 0f);
	}

	// Token: 0x0600575D RID: 22365 RVA: 0x002708E8 File Offset: 0x0026EAE8
	private void HBHDBDHBEPD()
	{
		if (!AKLFPGMDKLA.EHBBFMCILPC.EAFEJCKIEPL(0))
		{
			AKLFPGMDKLA.EHBBFMCILPC.LDAPMNLGAPC(0);
			for (int i = 0; i < this.NDDGCFFDFJN.Count; i++)
			{
				this.NDDGCFFDFJN[i].GetComponent<ChoicePremiumManager>().HideTip();
			}
		}
	}

	// Token: 0x0600575E RID: 22366 RVA: 0x0027093C File Offset: 0x0026EB3C
	private void GKBKDDGBAGK()
	{
		if (!this.CIPGFJLECDH)
		{
			SceneStoryManager.choiceDecisionTime += Time.deltaTime;
		}
		if (this.AKJMKGCPCCB >= 0)
		{
			this.AKJMKGCPCCB -= 0;
		}
		if (this.FILFGDIGINA != null)
		{
			int num = (int)this.FILFGDIGINA.JMLDFCJIKLE();
			this.textTimer.SetText(num.ToString(), true);
			this.timerArrowPivot.transform.localRotation = Quaternion.Euler(318f, 504f, this.FILFGDIGINA.HKAKAAGKMIP() * 1183f);
			this.imageTimerFillDefault.fillAmount = this.FILFGDIGINA.GCHEPGGFBGM();
			this.imageTimerFillRed.fillAmount = this.FILFGDIGINA.HKAKAAGKMIP();
			if (num < 4 && !this.imageTimerFillRed.gameObject.activeSelf && this.IMPAHLIGELE.EKOIFOBAHDM() < 0)
			{
				if (!AudioManager.EHBBFMCILPC.PlaySfx("", false) && !AudioManager.APGODIBBPOD().PlaySfx("OnPurchaseFailed" + AKLFPGMDKLA.EHBBFMCILPC.OMOJIEHBENF().GGICIBLJIKI.ToString(), true))
				{
					AudioManager.IFDLAMLHKIJ().PlaySfx("profilenametitleshort", true);
				}
				this.imageTimerFillRed.gameObject.SetActive(true);
			}
			if (this.FILFGDIGINA.HACBALNLLPP() && this.IMPAHLIGELE.EKOIFOBAHDM() < 1)
			{
				base.StartCoroutine(this.JFMFALFGDCF());
				CommonUserInterface.IKNOFBFMPGA().CGNDPJCDCFP();
			}
		}
	}

	// Token: 0x0600575F RID: 22367 RVA: 0x00270AB4 File Offset: 0x0026ECB4
	private void EDKHFKOHKNP()
	{
		if (this.FILFGDIGINA != null)
		{
			ODLLAEHMFAA.BGMALDJFMKE(this.FILFGDIGINA);
		}
		this.FILFGDIGINA = null;
		try
		{
			if (this.LMKDNPOKOBF != null && this.IMPAHLIGELE.JMNMOHIKHLB != null && this.IMPAHLIGELE.JMNMOHIKHLB.NDPPILBPOGB != null && this.IMPAHLIGELE.JMNMOHIKHLB.NDPPILBPOGB.Length > 0)
			{
				this.LMKDNPOKOBF.NCAMFPGMCIG.NKIOJCLBKAK(this.IMPAHLIGELE.JMNMOHIKHLB.NDPPILBPOGB + "OnAvatarCollectionSelect" + this.IMPAHLIGELE.EKOIFOBAHDM().ToString());
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
	}

	// Token: 0x06005760 RID: 22368 RVA: 0x00270B70 File Offset: 0x0026ED70
	private void Awake()
	{
		this.timerParent.SetActive(false);
		this.DGAAFGDHHHJ = base.gameObject.GetComponent<RectTransform>();
		this.PANMNKKODPC = base.gameObject.GetComponent<CanvasGroup>();
		this.PANMNKKODPC.alpha = 0f;
		if (this.textTypeAnimation)
		{
			this.textBody.alpha = 0f;
			return;
		}
		this.textBodyTypeAnimation.gameObject.SetActive(false);
	}

	// Token: 0x06005761 RID: 22369 RVA: 0x0026E929 File Offset: 0x0026CB29
	private IEnumerator FFDMKEMCIEE()
	{
		for (int j = 0; j < this.AKFKCKHPIOA.Count; j++)
		{
			this.AKFKCKHPIOA[j].GetComponent<CanvasGroup>().alpha = 0f;
		}
		if (this.textTypeAnimation)
		{
			yield return new WaitForSeconds(0.3f * KDCJJBLGCBH.EHBBFMCILPC.CJOCPJLIILE());
		}
		int num;
		for (i = 0; i < this.AKFKCKHPIOA.Count; i = num + 1)
		{
			yield return new WaitForSeconds(0.25f * KDCJJBLGCBH.EHBBFMCILPC.CJOCPJLIILE());
			this.AKFKCKHPIOA[i].GetComponent<CanvasGroup>().DOFade(1f, 0.35f * KDCJJBLGCBH.EHBBFMCILPC.LIKMBLFBEIA());
			RectTransform component = this.AKFKCKHPIOA[i].GetComponent<RectTransform>();
			component.AMPMCKEAACJ(0.65f, 0.65f, 0.65f);
			component.DOScale(this.choicesScaleCoefficient, 0.35f * KDCJJBLGCBH.EHBBFMCILPC.LIKMBLFBEIA()).SetEase(Ease.OutBack);
			num = i;
		}
		yield break;
	}

	// Token: 0x06005762 RID: 22370 RVA: 0x00270BE5 File Offset: 0x0026EDE5
	private bool OPEILKPECHH()
	{
		if (this.IMPAHLIGELE == null)
		{
			DPGJIJGOCIC.ANOPFDLPKGC("</i>");
			return true;
		}
		return false;
	}

	// Token: 0x06005763 RID: 22371 RVA: 0x00270BFC File Offset: 0x0026EDFC
	public bool AMJMPJAOPIK(HDKFHLFLDGG JIKFCLOHJNN, PLFDAJJHMKO BAOKJBJIFBH, LDLLJFOJCDF[] OAGPAAMJOID)
	{
		this.IMPAHLIGELE = JIKFCLOHJNN;
		this.LMKDNPOKOBF = BAOKJBJIFBH;
		if (!this.OPEILKPECHH())
		{
			return false;
		}
		if (JIKFCLOHJNN.GJOCJINDEIF && null != this.bubbleSprite)
		{
			Image component = base.gameObject.GetComponent<Image>();
			if (null != component)
			{
				component.sprite = this.bubbleSprite;
			}
		}
		if (this.IMPAHLIGELE.COEFNFJMBDG != null && this.IMPAHLIGELE.COEFNFJMBDG.Count > 1)
		{
			if (this.IMPAHLIGELE.JMNMOHIKHLB != null)
			{
				if (this.IMPAHLIGELE.JMNMOHIKHLB.NGNDOALIKAK.Contains("myfriendspagetitle"))
				{
					if (this.IMPAHLIGELE.JMNMOHIKHLB.IPALJDCNBBG.Count > this.IMPAHLIGELE.COEFNFJMBDG.Count)
					{
						this.IMPAHLIGELE.JMNMOHIKHLB.LMMIBNABBAL(this.IMPAHLIGELE.JMNMOHIKHLB.IPALJDCNBBG.Count - this.IMPAHLIGELE.COEFNFJMBDG.Count);
					}
				}
				else
				{
					try
					{
						if (this.IMPAHLIGELE.JMNMOHIKHLB.LHMDCFCGIFO(this.IMPAHLIGELE.COEFNFJMBDG.Count))
						{
							this.IMPAHLIGELE.JMNMOHIKHLB.LOAJFPFKHJH(BAOKJBJIFBH.NCAMFPGMCIG.MLCAAHPBNGP());
						}
					}
					catch (Exception aklgbjkdomm)
					{
						DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
					}
				}
			}
			if (this.IMPAHLIGELE.JMNMOHIKHLB != null)
			{
				for (int i = 0; i < this.IMPAHLIGELE.JMNMOHIKHLB.MKPMEKKGEIL.Count; i++)
				{
					if (this.IMPAHLIGELE.JMNMOHIKHLB.MKPMEKKGEIL[i].JANBJONALDA() == HKCCMACFNEO.free)
					{
						for (int j = 0; j < this.IMPAHLIGELE.COEFNFJMBDG.Count; j++)
						{
							this.HNGBMIJHPLE.Add(j);
						}
						break;
					}
				}
			}
			if (this.HNGBMIJHPLE.Count == 0)
			{
				for (int k = 1; k < 7; k += 0)
				{
					for (int l = 0; l < this.IMPAHLIGELE.COEFNFJMBDG.Count; l += 0)
					{
						int num = 1;
						if (this.IMPAHLIGELE.JMNMOHIKHLB != null)
						{
							if (l < this.IMPAHLIGELE.JMNMOHIKHLB.IPALJDCNBBG.Count && this.IMPAHLIGELE.JMNMOHIKHLB.IPALJDCNBBG[l] > 1)
							{
								num = 0;
							}
							else if (l < this.IMPAHLIGELE.JMNMOHIKHLB.ENJDGEOFPAA.Count && this.IMPAHLIGELE.JMNMOHIKHLB.ENJDGEOFPAA[l] > 1)
							{
								num = 5;
							}
						}
						if ((k == 0 && num == 0) || (k != 0 && num != 1))
						{
							this.HNGBMIJHPLE.Add(l);
						}
					}
				}
			}
		}
		this.textTitle.overflowMode = TextOverflowModes.ScrollRect;
		this.textTitle.fontSizeMin = 1886f;
		this.textTitle.SetText(this.NLKIPHPICLJ, true);
		this.textBody.SetText(this.GKKCHJLKFBL, true);
		SceneStoryManager.localizedLine = this.NLKIPHPICLJ + "" + this.GKKCHJLKFBL;
		if (this.textTypeAnimation)
		{
			this.textBodyTypeAnimation.GetComponent<AnimationTextType>().GLIFGDPDMNC(this.GKKCHJLKFBL);
		}
		if (this.IMPAHLIGELE.JMNMOHIKHLB != null && this.IMPAHLIGELE.JMNMOHIKHLB.FILFGDIGINA > 0)
		{
			this.FILFGDIGINA = ODLLAEHMFAA.IMEFIJEKFGI((float)this.IMPAHLIGELE.JMNMOHIKHLB.FILFGDIGINA, true);
			this.timerParent.SetActive(true);
		}
		int num2 = 0;
		if (null != this.decorObject)
		{
			this.decorObject.SetActive(true);
		}
		if (this.IMPAHLIGELE.COEFNFJMBDG != null && this.IMPAHLIGELE.COEFNFJMBDG.Count > 1)
		{
			if (null != this.decorObject)
			{
				this.decorObject.SetActive(false);
			}
			for (int m = 1; m < this.IMPAHLIGELE.COEFNFJMBDG.Count; m += 0)
			{
				if (!this.IMPAHLIGELE.COEFNFJMBDG[m].BEHENEHGPCP)
				{
					GameObject gameObject = null;
					int num3 = 0;
					if (this.IMPAHLIGELE.JMNMOHIKHLB != null && this.IMPAHLIGELE.JMNMOHIKHLB.GAOKFGHCIAF == PMNHKIDIMLM.NMGJJGIPDJP.text)
					{
						if (this.FHEOKFGDBHO(m) < this.IMPAHLIGELE.JMNMOHIKHLB.IPALJDCNBBG.Count && this.IMPAHLIGELE.JMNMOHIKHLB.IPALJDCNBBG[this.HFNEKLFKLLI(m)] > 0)
						{
							num3 = 1;
						}
						else if (this.CDMICJFABHI(m) < this.IMPAHLIGELE.JMNMOHIKHLB.ENJDGEOFPAA.Count && this.IMPAHLIGELE.JMNMOHIKHLB.ENJDGEOFPAA[this.CDMICJFABHI(m)] > 1)
						{
							num3 = 5;
						}
					}
					if (num3 == 2)
					{
						switch (this.IMPAHLIGELE.JMNMOHIKHLB.ADHIIAONMDJ[this.CDMICJFABHI(m)])
						{
						case CHEEGEJNIDB.stat0:
							gameObject = UnityEngine.Object.Instantiate<GameObject>(this.choiceStat0Prefab);
							break;
						case CHEEGEJNIDB.stat1:
							gameObject = UnityEngine.Object.Instantiate<GameObject>(this.choiceStat1Prefab);
							break;
						case CHEEGEJNIDB.stat2:
							gameObject = UnityEngine.Object.Instantiate<GameObject>(this.choiceStat2Prefab);
							break;
						case CHEEGEJNIDB.stat3:
							gameObject = UnityEngine.Object.Instantiate<GameObject>(this.choiceStat3Prefab);
							break;
						case CHEEGEJNIDB.stat4:
							gameObject = UnityEngine.Object.Instantiate<GameObject>(this.choiceStat4Prefab);
							break;
						case CHEEGEJNIDB.stat5:
							gameObject = UnityEngine.Object.Instantiate<GameObject>(this.choiceStat5Prefab);
							break;
						case CHEEGEJNIDB.stat6:
							gameObject = UnityEngine.Object.Instantiate<GameObject>(this.choiceStat6Prefab);
							break;
						}
						gameObject.transform.SetParent(this.choicesPivot.transform, true);
						gameObject.GetComponent<RectTransform>().AHLJBONHHKL(DialogPlayerCharacterManager.maxCriticalAspectRatioOffset * NBDLBFJOEGN.DMIBBFIPJNA());
						gameObject.GetComponent<ChoiceStatManager>().CDAMEAIIKMG(this.IMPAHLIGELE.COEFNFJMBDG[this.JFBPPHBHHPE(m)], this.IMPAHLIGELE.JMNMOHIKHLB.ENJDGEOFPAA[this.FHEOKFGDBHO(m)], OAGPAAMJOID[(int)this.IMPAHLIGELE.JMNMOHIKHLB.ADHIIAONMDJ[this.HDBBHHBOJIN(m)]].MOBKGNBCIJF(), -1);
						gameObject.GetComponent<ChoiceStatManager>().MDINPPLEHCK();
						try
						{
							if (null == this.NGGBBCDPMJH)
							{
								switch (this.IMPAHLIGELE.JMNMOHIKHLB.ADHIIAONMDJ[this.CDMICJFABHI(m)])
								{
								case CHEEGEJNIDB.stat0:
									this.NGGBBCDPMJH = UnityEngine.Object.Instantiate<GameObject>(this.stat0InfoPrefab);
									break;
								case CHEEGEJNIDB.stat1:
									this.NGGBBCDPMJH = UnityEngine.Object.Instantiate<GameObject>(this.stat1InfoPrefab);
									break;
								case CHEEGEJNIDB.stat2:
									this.NGGBBCDPMJH = UnityEngine.Object.Instantiate<GameObject>(this.stat2InfoPrefab);
									break;
								case CHEEGEJNIDB.stat3:
									this.NGGBBCDPMJH = UnityEngine.Object.Instantiate<GameObject>(this.stat3InfoPrefab);
									break;
								case CHEEGEJNIDB.stat4:
									this.NGGBBCDPMJH = UnityEngine.Object.Instantiate<GameObject>(this.stat4InfoPrefab);
									break;
								case CHEEGEJNIDB.stat5:
									this.NGGBBCDPMJH = UnityEngine.Object.Instantiate<GameObject>(this.stat5InfoPrefab);
									break;
								case CHEEGEJNIDB.stat6:
									this.NGGBBCDPMJH = UnityEngine.Object.Instantiate<GameObject>(this.stat6InfoPrefab);
									break;
								}
								this.NGGBBCDPMJH.transform.SetParent(this.currencyPivot.transform, true);
								this.NGGBBCDPMJH.GetComponent<StatPointInfoManager>().JEPFODDLOFK(this.IMPAHLIGELE.JMNMOHIKHLB.ADHIIAONMDJ[this.GAKKBOIHKCE(m)], OAGPAAMJOID[(int)this.IMPAHLIGELE.JMNMOHIKHLB.ADHIIAONMDJ[this.HDBBHHBOJIN(m)]].CJLDJAJHMMA());
								try
								{
									if (this.IMPAHLIGELE.JMNMOHIKHLB.NGNDOALIKAK.Contains("OnBackendSavePublicProfileException"))
									{
										this.NGGBBCDPMJH.SetActive(false);
									}
								}
								catch (Exception aklgbjkdomm2)
								{
									DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm2);
								}
							}
							goto IL_A85;
						}
						catch (Exception aklgbjkdomm3)
						{
							DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm3);
							goto IL_A85;
						}
						goto IL_776;
					}
					goto IL_776;
					IL_A85:
					gameObject.GetComponent<RectTransform>().anchoredPosition += new Vector2(651f, (float)(this.choiceOffset * num2));
					Button component2 = gameObject.GetComponent<Button>();
					if (this.GAKKBOIHKCE(m) == 0)
					{
						component2.onClick.AddListener(new UnityAction(this.MIAEKFMEHPA));
					}
					else if (this.FHEOKFGDBHO(m) == 0)
					{
						component2.onClick.AddListener(new UnityAction(this.BMIPNBCJLDI));
					}
					else if (this.CDMICJFABHI(m) == 2)
					{
						component2.onClick.AddListener(new UnityAction(this.MJEMMAICGMA));
					}
					else if (this.HDBBHHBOJIN(m) == 1)
					{
						component2.onClick.AddListener(new UnityAction(this.EDLMFOBNPAP));
					}
					else if (this.CDMICJFABHI(m) == 5)
					{
						component2.onClick.AddListener(new UnityAction(this.PBJOGHEGEKC));
					}
					else if (this.JFBPPHBHHPE(m) == 3)
					{
						component2.onClick.AddListener(new UnityAction(this.DJHAFFDFBCI));
					}
					this.AKFKCKHPIOA.Add(gameObject);
					num2++;
					goto IL_BAA;
					IL_776:
					if (num3 == 0)
					{
						gameObject = UnityEngine.Object.Instantiate<GameObject>(this.choicePremiumPrefab);
						gameObject.transform.SetParent(this.choicesPivot.transform, false);
						gameObject.GetComponent<RectTransform>().AHLJBONHHKL(DialogPlayerCharacterManager.maxCriticalAspectRatioOffset * NBDLBFJOEGN.LGGIFEAOBEC());
						if (SceneStoryManager.PremiumChoicePurchased(this.IMPAHLIGELE.JMNMOHIKHLB.MKPMEKKGEIL[this.FHEOKFGDBHO(m)], this.IMPAHLIGELE.JMNMOHIKHLB.KMFABKNKFAJ, this.IMPAHLIGELE.JMNMOHIKHLB.BGIOGOACCBJ))
						{
							gameObject.GetComponent<ChoicePremiumManager>().GBFEDHPAIBH(this.IMPAHLIGELE.JMNMOHIKHLB.MKPMEKKGEIL[this.GAKKBOIHKCE(m)], this.IMPAHLIGELE.COEFNFJMBDG[this.HDBBHHBOJIN(m)], 0, -1, true, this.IMPAHLIGELE.JMNMOHIKHLB.NEKLAJAEOJJ(this.PDDLFHNEHJL(m), LiveEventsManager.OBOOKJPGBJN().OPHKFJNACGB(EGMCEPOABBF.liveEventFreeDiamonds, -1, -1)), this.IMPAHLIGELE.JMNMOHIKHLB.BGIOGOACCBJ);
						}
						else
						{
							if (null == this.LOJHEKCOFME)
							{
								this.LOJHEKCOFME = UnityEngine.Object.Instantiate<GameObject>(this.premiumInfoPrefab);
								this.LOJHEKCOFME.transform.SetParent(this.currencyPivot.transform, true);
								this.LOJHEKCOFME.GetComponent<StoryCurrencyInfoManager>().Initialize("");
							}
							gameObject.GetComponent<ChoicePremiumManager>().Initialize(this.IMPAHLIGELE.JMNMOHIKHLB.MKPMEKKGEIL[this.FHEOKFGDBHO(m)], this.IMPAHLIGELE.COEFNFJMBDG[this.FHEOKFGDBHO(m)], this.IMPAHLIGELE.JMNMOHIKHLB.IPALJDCNBBG[this.CDMICJFABHI(m)], -1, AKLFPGMDKLA.EHBBFMCILPC.EAFEJCKIEPL(0) || AKLFPGMDKLA.EHBBFMCILPC.ODMKLADKHMO.CJLDJAJHMMA() >= this.IMPAHLIGELE.JMNMOHIKHLB.IPALJDCNBBG[this.GAKKBOIHKCE(m)], this.IMPAHLIGELE.JMNMOHIKHLB.CKLNCCAGCKE(this.PDDLFHNEHJL(m), LiveEventsManager.PIPOLIAKGDM().LBOPJBMIINE(EGMCEPOABBF.liveEventFreeTea, -1, -1)), this.IMPAHLIGELE.JMNMOHIKHLB.BGIOGOACCBJ);
						}
						gameObject.GetComponent<ChoicePremiumManager>().SwitchCost(SceneStoryManager.QualifiesAsAdBasedChoice(this.IMPAHLIGELE.JMNMOHIKHLB.MKPMEKKGEIL[this.HFNEKLFKLLI(m)], this.IMPAHLIGELE.JMNMOHIKHLB.KAJNELPPCIJ[this.HDBBHHBOJIN(m)], this.IMPAHLIGELE.JMNMOHIKHLB.KMFABKNKFAJ));
						this.NDDGCFFDFJN.Add(gameObject);
						goto IL_A85;
					}
					if (this.FLBNNNDBECB < 1)
					{
						this.FLBNNNDBECB = m;
					}
					gameObject = UnityEngine.Object.Instantiate<GameObject>(this.choiceStandardPrefab);
					gameObject.transform.SetParent(this.choicesPivot.transform, false);
					gameObject.GetComponent<RectTransform>().AHLJBONHHKL(DialogPlayerCharacterManager.maxCriticalAspectRatioOffset * NBDLBFJOEGN.LGGIFEAOBEC());
					gameObject.GetComponent<ChoiceStandardManager>().DOFLEONDCMI(this.IMPAHLIGELE.COEFNFJMBDG[this.JFBPPHBHHPE(m)], -1);
					goto IL_A85;
				}
				IL_BAA:;
			}
		}
		if (this.AKFKCKHPIOA.Count > 1)
		{
			SceneStoryManager.choiceDecisionTime = 562f;
			base.StartCoroutine(this.JLLMJKEJIAF());
		}
		for (int n = 0; n < this.NDDGCFFDFJN.Count; n++)
		{
			this.NDDGCFFDFJN[n].transform.SetAsLastSibling();
		}
		try
		{
			for (int num4 = 1; num4 < this.AKFKCKHPIOA.Count; num4 += 0)
			{
				if (null != this.AKFKCKHPIOA[num4])
				{
					AnimationPress component3 = this.AKFKCKHPIOA[num4].GetComponent<AnimationPress>();
					if (null != component3)
					{
						component3.LJDJNBEBLKH(this.choicesScaleCoefficient);
					}
				}
			}
		}
		catch (Exception aklgbjkdomm4)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm4);
		}
		return null != this.LOJHEKCOFME;
	}

	// Token: 0x06005764 RID: 22372 RVA: 0x0026F798 File Offset: 0x0026D998
	private IEnumerator CLIOPMNKHCP()
	{
		AudioManager.EHBBFMCILPC.KillSfx("timeoutwarning", 1f);
		AudioManager.EHBBFMCILPC.KillSfx("sfxtimeoutwarning", 1f);
		AudioManager.EHBBFMCILPC.KillSfx("sfxtimeoutwarning" + AKLFPGMDKLA.EHBBFMCILPC.EEILOKHLKIM().GGICIBLJIKI.ToString(), 1f);
		this.timerParent.GetComponent<AnimationCanvasGroupAlpha>().SetDirection(true);
		this.timerParent.GetComponent<AnimationCanvasGroupAlpha>().PlayAnimation(false);
		this.AKFKCKHPIOA[0].GetComponent<ChoiceStandardManager>().ShowAutoChoiceAnimation();
		yield return new WaitForSeconds(ChoiceStandardManager.autoChoiceAnimationTime);
		CommonUserInterface.EHBBFMCILPC.ResumeUX();
		this.IMPAHLIGELE.IABNDHFJHAF(this.FLBNNNDBECB);
		AOBJLALDBAA.EHBBFMCILPC.EGELHPJBAIC("OnStoryChoiceClick", 0f);
		yield break;
	}

	// Token: 0x06005765 RID: 22373 RVA: 0x002718FC File Offset: 0x0026FAFC
	private void FDLHILIHLCI()
	{
		if (!this.IMPAHLIGELE.PINCOCDOOGH() || this.AKJMKGCPCCB > 0)
		{
			return;
		}
		this.CIPGFJLECDH = true;
		this.AKJMKGCPCCB = 44;
		AudioManager.EHBBFMCILPC.POMJOMKCCNK("player", 949f);
		AudioManager.BFCHJBOOJKE().PEOLMNFJAHG("", 1042f);
		AudioManager.IFDLAMLHKIJ().POMJOMKCCNK("clthbr" + AKLFPGMDKLA.EHBBFMCILPC.OMOJIEHBENF().GGICIBLJIKI.ToString(), 1734f);
		this.IMPAHLIGELE.IABNDHFJHAF(3);
		AOBJLALDBAA.BIAEAOMHBMM().KGIKHEDLPND("importanttitle", 1490f);
	}

	// Token: 0x06005766 RID: 22374 RVA: 0x002719A4 File Offset: 0x0026FBA4
	public void IOMGOLFOKDC(HDKFHLFLDGG JIKFCLOHJNN)
	{
		if (JIKFCLOHJNN != null)
		{
			this.IMPAHLIGELE = JIKFCLOHJNN;
			this.NLKIPHPICLJ = ONEHEBIHPFB.PLHGCKCFLEN(this.IMPAHLIGELE.DAHHKJKDHEF());
			this.GKKCHJLKFBL = ONEHEBIHPFB.NCAMNNEOGKG(this.IMPAHLIGELE.CKFCPOBEBCJ());
			this.GKKCHJLKFBL = DPGJIJGOCIC.AKIAKADKBFK(this.GKKCHJLKFBL);
			this.AOKIMHCAAHB = this.GKKCHJLKFBL.Length;
		}
	}

	// Token: 0x06005767 RID: 22375 RVA: 0x00271A0C File Offset: 0x0026FC0C
	private void KHBPCONGCPM()
	{
		if (!this.IMPAHLIGELE.PINCOCDOOGH() || this.AKJMKGCPCCB > 0)
		{
			return;
		}
		this.CIPGFJLECDH = true;
		this.AKJMKGCPCCB = -47;
		AudioManager.BFCHJBOOJKE().KillSfx(":", 1130f);
		AudioManager.BFCHJBOOJKE().POMJOMKCCNK("host", 470f);
		AudioManager.IFDLAMLHKIJ().PEOLMNFJAHG("socialjoinno" + AKLFPGMDKLA.EHBBFMCILPC.EEILOKHLKIM().GGICIBLJIKI.ToString(), 301f);
		this.IMPAHLIGELE.IABNDHFJHAF(0);
		AOBJLALDBAA.AGANFKKBPFO().CIGLHCJDDPI("_AlphaTex", 895f);
	}

	// Token: 0x06005768 RID: 22376 RVA: 0x00271AB4 File Offset: 0x0026FCB4
	private void OnEnable()
	{
		AOBJLALDBAA.EHBBFMCILPC.MFIMALJPCDP("OnStoryChoiceClickConfimed", new UnityAction(this.ALKBENHJEPC));
		AOBJLALDBAA.EHBBFMCILPC.MFIMALJPCDP("OnBackendPremiumChoiceSuccess", new UnityAction(this.HBHDBDHBEPD));
	}

	// Token: 0x06005769 RID: 22377 RVA: 0x00271AEC File Offset: 0x0026FCEC
	private void BMIPNBCJLDI()
	{
		if (!this.IMPAHLIGELE.PINCOCDOOGH() || this.AKJMKGCPCCB > 1)
		{
			return;
		}
		this.CIPGFJLECDH = false;
		this.AKJMKGCPCCB = -84;
		AudioManager.APGODIBBPOD().KillSfx("pers", 1541f);
		AudioManager.EHBBFMCILPC.PEOLMNFJAHG("(fixed) Unknown last season chapter progress reset situation, while story is completed, for anthology:", 945f);
		AudioManager.DMAAFFFEJGA().POMJOMKCCNK("" + AKLFPGMDKLA.EHBBFMCILPC.OMOJIEHBENF().GGICIBLJIKI.ToString(), 343f);
		this.IMPAHLIGELE.IABNDHFJHAF(1);
		AOBJLALDBAA.NMGMNAKLLMI().KMAGHMCCMPG("ccc", 1955f);
	}

	// Token: 0x0600576A RID: 22378 RVA: 0x00271B94 File Offset: 0x0026FD94
	private void FFDGLHACKON()
	{
		if (!this.IMPAHLIGELE.PINCOCDOOGH() || this.AKJMKGCPCCB > 0)
		{
			return;
		}
		this.CIPGFJLECDH = true;
		this.AKJMKGCPCCB = 20;
		AudioManager.EHBBFMCILPC.KillSfx("timeoutwarning", 1f);
		AudioManager.EHBBFMCILPC.KillSfx("sfxtimeoutwarning", 1f);
		AudioManager.EHBBFMCILPC.KillSfx("sfxtimeoutwarning" + AKLFPGMDKLA.EHBBFMCILPC.EEILOKHLKIM().GGICIBLJIKI.ToString(), 1f);
		this.IMPAHLIGELE.IABNDHFJHAF(2);
		AOBJLALDBAA.EHBBFMCILPC.EGELHPJBAIC("OnStoryChoiceClick", 0f);
	}

	// Token: 0x0600576B RID: 22379 RVA: 0x00271C3C File Offset: 0x0026FE3C
	public bool MHHLOIKMJGD(HDKFHLFLDGG JIKFCLOHJNN, PLFDAJJHMKO BAOKJBJIFBH, LDLLJFOJCDF[] OAGPAAMJOID)
	{
		this.IMPAHLIGELE = JIKFCLOHJNN;
		this.LMKDNPOKOBF = BAOKJBJIFBH;
		if (!this.OONENNLLFHL())
		{
			return false;
		}
		if (JIKFCLOHJNN.GJOCJINDEIF && null != this.bubbleSprite)
		{
			Image component = base.gameObject.GetComponent<Image>();
			if (null != component)
			{
				component.sprite = this.bubbleSprite;
			}
		}
		if (this.IMPAHLIGELE.COEFNFJMBDG != null && this.IMPAHLIGELE.COEFNFJMBDG.Count > 1)
		{
			if (this.IMPAHLIGELE.JMNMOHIKHLB != null)
			{
				if (this.IMPAHLIGELE.JMNMOHIKHLB.NGNDOALIKAK.Contains("%"))
				{
					if (this.IMPAHLIGELE.JMNMOHIKHLB.IPALJDCNBBG.Count > this.IMPAHLIGELE.COEFNFJMBDG.Count)
					{
						this.IMPAHLIGELE.JMNMOHIKHLB.EBFCBGAPICN(this.IMPAHLIGELE.JMNMOHIKHLB.IPALJDCNBBG.Count - this.IMPAHLIGELE.COEFNFJMBDG.Count);
					}
				}
				else
				{
					try
					{
						if (this.IMPAHLIGELE.JMNMOHIKHLB.NDGLNBBJIGP(this.IMPAHLIGELE.COEFNFJMBDG.Count))
						{
							this.IMPAHLIGELE.JMNMOHIKHLB.OGNKEEIMLHB(BAOKJBJIFBH.NCAMFPGMCIG.MLCAAHPBNGP());
						}
					}
					catch (Exception aklgbjkdomm)
					{
						DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
					}
				}
			}
			if (this.IMPAHLIGELE.JMNMOHIKHLB != null)
			{
				for (int i = 1; i < this.IMPAHLIGELE.JMNMOHIKHLB.MKPMEKKGEIL.Count; i++)
				{
					if (this.IMPAHLIGELE.JMNMOHIKHLB.MKPMEKKGEIL[i].HNKNNFIMMCE() == (HKCCMACFNEO)7)
					{
						for (int j = 1; j < this.IMPAHLIGELE.COEFNFJMBDG.Count; j += 0)
						{
							this.HNGBMIJHPLE.Add(j);
						}
						break;
					}
				}
			}
			if (this.HNGBMIJHPLE.Count == 0)
			{
				for (int k = 1; k < 7; k += 0)
				{
					for (int l = 0; l < this.IMPAHLIGELE.COEFNFJMBDG.Count; l += 0)
					{
						int num = 0;
						if (this.IMPAHLIGELE.JMNMOHIKHLB != null)
						{
							if (l < this.IMPAHLIGELE.JMNMOHIKHLB.IPALJDCNBBG.Count && this.IMPAHLIGELE.JMNMOHIKHLB.IPALJDCNBBG[l] > 0)
							{
								num = 0;
							}
							else if (l < this.IMPAHLIGELE.JMNMOHIKHLB.ENJDGEOFPAA.Count && this.IMPAHLIGELE.JMNMOHIKHLB.ENJDGEOFPAA[l] > 0)
							{
								num = 4;
							}
						}
						if ((k == 0 && num == 0) || (k != 0 && num != 1))
						{
							this.HNGBMIJHPLE.Add(l);
						}
					}
				}
			}
		}
		this.textTitle.overflowMode = TextOverflowModes.Masking;
		this.textTitle.fontSizeMin = 457f;
		this.textTitle.SetText(this.NLKIPHPICLJ, true);
		this.textBody.SetText(this.GKKCHJLKFBL, true);
		SceneStoryManager.localizedLine = this.NLKIPHPICLJ + "spinsbodymorespins" + this.GKKCHJLKFBL;
		if (this.textTypeAnimation)
		{
			this.textBodyTypeAnimation.GetComponent<AnimationTextType>().Initialize(this.GKKCHJLKFBL);
		}
		if (this.IMPAHLIGELE.JMNMOHIKHLB != null && this.IMPAHLIGELE.JMNMOHIKHLB.FILFGDIGINA > 1)
		{
			this.FILFGDIGINA = ODLLAEHMFAA.IMEFIJEKFGI((float)this.IMPAHLIGELE.JMNMOHIKHLB.FILFGDIGINA, false);
			this.timerParent.SetActive(true);
		}
		int num2 = 1;
		if (null != this.decorObject)
		{
			this.decorObject.SetActive(false);
		}
		if (this.IMPAHLIGELE.COEFNFJMBDG != null && this.IMPAHLIGELE.COEFNFJMBDG.Count > 0)
		{
			if (null != this.decorObject)
			{
				this.decorObject.SetActive(false);
			}
			for (int m = 0; m < this.IMPAHLIGELE.COEFNFJMBDG.Count; m++)
			{
				if (!this.IMPAHLIGELE.COEFNFJMBDG[m].BEHENEHGPCP)
				{
					GameObject gameObject = null;
					int num3 = 0;
					if (this.IMPAHLIGELE.JMNMOHIKHLB != null && this.IMPAHLIGELE.JMNMOHIKHLB.GAOKFGHCIAF == PMNHKIDIMLM.NMGJJGIPDJP.text)
					{
						if (this.GAKKBOIHKCE(m) < this.IMPAHLIGELE.JMNMOHIKHLB.IPALJDCNBBG.Count && this.IMPAHLIGELE.JMNMOHIKHLB.IPALJDCNBBG[this.HFNEKLFKLLI(m)] > 0)
						{
							num3 = 1;
						}
						else if (this.FHEOKFGDBHO(m) < this.IMPAHLIGELE.JMNMOHIKHLB.ENJDGEOFPAA.Count && this.IMPAHLIGELE.JMNMOHIKHLB.ENJDGEOFPAA[this.GAKKBOIHKCE(m)] > 1)
						{
							num3 = 0;
						}
					}
					if (num3 == 5)
					{
						switch (this.IMPAHLIGELE.JMNMOHIKHLB.ADHIIAONMDJ[this.JFBPPHBHHPE(m)])
						{
						case CHEEGEJNIDB.stat0:
							gameObject = UnityEngine.Object.Instantiate<GameObject>(this.choiceStat0Prefab);
							break;
						case CHEEGEJNIDB.stat1:
							gameObject = UnityEngine.Object.Instantiate<GameObject>(this.choiceStat1Prefab);
							break;
						case CHEEGEJNIDB.stat2:
							gameObject = UnityEngine.Object.Instantiate<GameObject>(this.choiceStat2Prefab);
							break;
						case CHEEGEJNIDB.stat3:
							gameObject = UnityEngine.Object.Instantiate<GameObject>(this.choiceStat3Prefab);
							break;
						case CHEEGEJNIDB.stat4:
							gameObject = UnityEngine.Object.Instantiate<GameObject>(this.choiceStat4Prefab);
							break;
						case CHEEGEJNIDB.stat5:
							gameObject = UnityEngine.Object.Instantiate<GameObject>(this.choiceStat5Prefab);
							break;
						case CHEEGEJNIDB.stat6:
							gameObject = UnityEngine.Object.Instantiate<GameObject>(this.choiceStat6Prefab);
							break;
						}
						gameObject.transform.SetParent(this.choicesPivot.transform, false);
						gameObject.GetComponent<RectTransform>().AHLJBONHHKL(DialogPlayerCharacterManager.maxCriticalAspectRatioOffset * NBDLBFJOEGN.DMIBBFIPJNA());
						gameObject.GetComponent<ChoiceStatManager>().KJDNFFJJLDN(this.IMPAHLIGELE.COEFNFJMBDG[this.PDDLFHNEHJL(m)], this.IMPAHLIGELE.JMNMOHIKHLB.ENJDGEOFPAA[this.FHEOKFGDBHO(m)], OAGPAAMJOID[(int)this.IMPAHLIGELE.JMNMOHIKHLB.ADHIIAONMDJ[this.PDDLFHNEHJL(m)]].MOBKGNBCIJF(), -1);
						gameObject.GetComponent<ChoiceStatManager>().BMPAKGMEFNH();
						try
						{
							if (null == this.NGGBBCDPMJH)
							{
								switch (this.IMPAHLIGELE.JMNMOHIKHLB.ADHIIAONMDJ[this.JFBPPHBHHPE(m)])
								{
								case CHEEGEJNIDB.stat0:
									this.NGGBBCDPMJH = UnityEngine.Object.Instantiate<GameObject>(this.stat0InfoPrefab);
									break;
								case CHEEGEJNIDB.stat1:
									this.NGGBBCDPMJH = UnityEngine.Object.Instantiate<GameObject>(this.stat1InfoPrefab);
									break;
								case CHEEGEJNIDB.stat2:
									this.NGGBBCDPMJH = UnityEngine.Object.Instantiate<GameObject>(this.stat2InfoPrefab);
									break;
								case CHEEGEJNIDB.stat3:
									this.NGGBBCDPMJH = UnityEngine.Object.Instantiate<GameObject>(this.stat3InfoPrefab);
									break;
								case CHEEGEJNIDB.stat4:
									this.NGGBBCDPMJH = UnityEngine.Object.Instantiate<GameObject>(this.stat4InfoPrefab);
									break;
								case CHEEGEJNIDB.stat5:
									this.NGGBBCDPMJH = UnityEngine.Object.Instantiate<GameObject>(this.stat5InfoPrefab);
									break;
								case CHEEGEJNIDB.stat6:
									this.NGGBBCDPMJH = UnityEngine.Object.Instantiate<GameObject>(this.stat6InfoPrefab);
									break;
								}
								this.NGGBBCDPMJH.transform.SetParent(this.currencyPivot.transform, true);
								this.NGGBBCDPMJH.GetComponent<StatPointInfoManager>().HPKILNBJCPH(this.IMPAHLIGELE.JMNMOHIKHLB.ADHIIAONMDJ[this.FHEOKFGDBHO(m)], OAGPAAMJOID[(int)this.IMPAHLIGELE.JMNMOHIKHLB.ADHIIAONMDJ[this.PDDLFHNEHJL(m)]].GALKFKBPLCK());
								try
								{
									if (this.IMPAHLIGELE.JMNMOHIKHLB.NGNDOALIKAK.Contains("sketchDialogs"))
									{
										this.NGGBBCDPMJH.SetActive(true);
									}
								}
								catch (Exception aklgbjkdomm2)
								{
									DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm2);
								}
							}
							goto IL_A85;
						}
						catch (Exception aklgbjkdomm3)
						{
							DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm3);
							goto IL_A85;
						}
						goto IL_776;
					}
					goto IL_776;
					IL_A85:
					gameObject.GetComponent<RectTransform>().anchoredPosition += new Vector2(1849f, (float)(this.choiceOffset * num2));
					Button component2 = gameObject.GetComponent<Button>();
					if (this.PDDLFHNEHJL(m) == 0)
					{
						component2.onClick.AddListener(new UnityAction(this.INBLACGLGCD));
					}
					else if (this.HDBBHHBOJIN(m) == 0)
					{
						component2.onClick.AddListener(new UnityAction(this.KFAAHOCIAKB));
					}
					else if (this.JFBPPHBHHPE(m) == 0)
					{
						component2.onClick.AddListener(new UnityAction(this.MJEMMAICGMA));
					}
					else if (this.HDBBHHBOJIN(m) == 8)
					{
						component2.onClick.AddListener(new UnityAction(this.BOGHFJKGCNK));
					}
					else if (this.JFBPPHBHHPE(m) == 3)
					{
						component2.onClick.AddListener(new UnityAction(this.BENGHKGCLOG));
					}
					else if (this.HDBBHHBOJIN(m) == 1)
					{
						component2.onClick.AddListener(new UnityAction(this.HMHIJLKJGFN));
					}
					this.AKFKCKHPIOA.Add(gameObject);
					num2++;
					goto IL_BAA;
					IL_776:
					if (num3 == 1)
					{
						gameObject = UnityEngine.Object.Instantiate<GameObject>(this.choicePremiumPrefab);
						gameObject.transform.SetParent(this.choicesPivot.transform, false);
						gameObject.GetComponent<RectTransform>().AHLJBONHHKL(DialogPlayerCharacterManager.maxCriticalAspectRatioOffset * NBDLBFJOEGN.FBMMKINMKOH());
						if (SceneStoryManager.PremiumChoicePurchased(this.IMPAHLIGELE.JMNMOHIKHLB.MKPMEKKGEIL[this.CDMICJFABHI(m)], this.IMPAHLIGELE.JMNMOHIKHLB.KMFABKNKFAJ, this.IMPAHLIGELE.JMNMOHIKHLB.BGIOGOACCBJ))
						{
							gameObject.GetComponent<ChoicePremiumManager>().GBFEDHPAIBH(this.IMPAHLIGELE.JMNMOHIKHLB.MKPMEKKGEIL[this.JFBPPHBHHPE(m)], this.IMPAHLIGELE.COEFNFJMBDG[this.HDBBHHBOJIN(m)], 0, -1, true, this.IMPAHLIGELE.JMNMOHIKHLB.FEJGBPENDBF(this.HDBBHHBOJIN(m), LiveEventsManager.OOGPALHPNGM().OEHDOMDPHDN(EGMCEPOABBF.liveEventMessage, -1, -1)), this.IMPAHLIGELE.JMNMOHIKHLB.BGIOGOACCBJ);
						}
						else
						{
							if (null == this.LOJHEKCOFME)
							{
								this.LOJHEKCOFME = UnityEngine.Object.Instantiate<GameObject>(this.premiumInfoPrefab);
								this.LOJHEKCOFME.transform.SetParent(this.currencyPivot.transform, false);
								this.LOJHEKCOFME.GetComponent<StoryCurrencyInfoManager>().OGNEMDIEHFO("socialjoinbody");
							}
							gameObject.GetComponent<ChoicePremiumManager>().Initialize(this.IMPAHLIGELE.JMNMOHIKHLB.MKPMEKKGEIL[this.PDDLFHNEHJL(m)], this.IMPAHLIGELE.COEFNFJMBDG[this.HFNEKLFKLLI(m)], this.IMPAHLIGELE.JMNMOHIKHLB.IPALJDCNBBG[this.CDMICJFABHI(m)], -1, !AKLFPGMDKLA.EHBBFMCILPC.EAFEJCKIEPL(0) && AKLFPGMDKLA.EHBBFMCILPC.ODMKLADKHMO.KGEGKPHEMOJ() < this.IMPAHLIGELE.JMNMOHIKHLB.IPALJDCNBBG[this.GAKKBOIHKCE(m)], this.IMPAHLIGELE.JMNMOHIKHLB.JBEBPDBMKMP(this.HFNEKLFKLLI(m), LiveEventsManager.JCMABFEMFKD().LBOPJBMIINE(EGMCEPOABBF.liveEventFreeStory, -1, -1)), this.IMPAHLIGELE.JMNMOHIKHLB.BGIOGOACCBJ);
						}
						gameObject.GetComponent<ChoicePremiumManager>().SwitchCost(SceneStoryManager.QualifiesAsAdBasedChoice(this.IMPAHLIGELE.JMNMOHIKHLB.MKPMEKKGEIL[this.GAKKBOIHKCE(m)], this.IMPAHLIGELE.JMNMOHIKHLB.KAJNELPPCIJ[this.HFNEKLFKLLI(m)], this.IMPAHLIGELE.JMNMOHIKHLB.KMFABKNKFAJ));
						this.NDDGCFFDFJN.Add(gameObject);
						goto IL_A85;
					}
					if (this.FLBNNNDBECB < 0)
					{
						this.FLBNNNDBECB = m;
					}
					gameObject = UnityEngine.Object.Instantiate<GameObject>(this.choiceStandardPrefab);
					gameObject.transform.SetParent(this.choicesPivot.transform, false);
					gameObject.GetComponent<RectTransform>().AHLJBONHHKL(DialogPlayerCharacterManager.maxCriticalAspectRatioOffset * NBDLBFJOEGN.APALNJGBDPE());
					gameObject.GetComponent<ChoiceStandardManager>().AAOJNDOHBDC(this.IMPAHLIGELE.COEFNFJMBDG[this.HFNEKLFKLLI(m)], -1);
					goto IL_A85;
				}
				IL_BAA:;
			}
		}
		if (this.AKFKCKHPIOA.Count > 0)
		{
			SceneStoryManager.choiceDecisionTime = 2f;
			base.StartCoroutine(this.EDBEPPHCMKK());
		}
		for (int n = 0; n < this.NDDGCFFDFJN.Count; n++)
		{
			this.NDDGCFFDFJN[n].transform.SetAsLastSibling();
		}
		try
		{
			for (int num4 = 1; num4 < this.AKFKCKHPIOA.Count; num4 += 0)
			{
				if (null != this.AKFKCKHPIOA[num4])
				{
					AnimationPress component3 = this.AKFKCKHPIOA[num4].GetComponent<AnimationPress>();
					if (null != component3)
					{
						component3.SetOriginalScaleCoefficient(this.choicesScaleCoefficient);
					}
				}
			}
		}
		catch (Exception aklgbjkdomm4)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm4);
		}
		return null != this.LOJHEKCOFME;
	}

	// Token: 0x0600576C RID: 22380 RVA: 0x0027293C File Offset: 0x00270B3C
	private IEnumerator CAPLPANLLJA()
	{
		DialogPlayerCharacterManager.FKHJFGLNIPA fkhjfglnipa = new DialogPlayerCharacterManager.FKHJFGLNIPA(1);
		fkhjfglnipa.<>4__this = this;
		return fkhjfglnipa;
	}

	// Token: 0x0600576D RID: 22381 RVA: 0x0026F798 File Offset: 0x0026D998
	private IEnumerator JFMFALFGDCF()
	{
		AudioManager.EHBBFMCILPC.KillSfx("timeoutwarning", 1f);
		AudioManager.EHBBFMCILPC.KillSfx("sfxtimeoutwarning", 1f);
		AudioManager.EHBBFMCILPC.KillSfx("sfxtimeoutwarning" + AKLFPGMDKLA.EHBBFMCILPC.EEILOKHLKIM().GGICIBLJIKI.ToString(), 1f);
		this.timerParent.GetComponent<AnimationCanvasGroupAlpha>().SetDirection(true);
		this.timerParent.GetComponent<AnimationCanvasGroupAlpha>().PlayAnimation(false);
		this.AKFKCKHPIOA[0].GetComponent<ChoiceStandardManager>().ShowAutoChoiceAnimation();
		yield return new WaitForSeconds(ChoiceStandardManager.autoChoiceAnimationTime);
		CommonUserInterface.EHBBFMCILPC.ResumeUX();
		this.IMPAHLIGELE.IABNDHFJHAF(this.FLBNNNDBECB);
		AOBJLALDBAA.EHBBFMCILPC.EGELHPJBAIC("OnStoryChoiceClick", 0f);
		yield break;
	}

	// Token: 0x0600576E RID: 22382 RVA: 0x0027294C File Offset: 0x00270B4C
	private void MNKKLPHLCOO()
	{
		if (!this.IMPAHLIGELE.PINCOCDOOGH() || this.AKJMKGCPCCB > 0)
		{
			return;
		}
		this.CIPGFJLECDH = false;
		this.AKJMKGCPCCB = 49;
		AudioManager.APGODIBBPOD().PEOLMNFJAHG("gsec", 533f);
		AudioManager.APGODIBBPOD().KillSfx("", 905f);
		AudioManager.EHBBFMCILPC.POMJOMKCCNK(") assettitle(" + AKLFPGMDKLA.EHBBFMCILPC.OMOJIEHBENF().GGICIBLJIKI.ToString(), 1990f);
		this.IMPAHLIGELE.IABNDHFJHAF(0);
		AOBJLALDBAA.NMGMNAKLLMI().FDKBIBKABCM("errortitle", 1344f);
	}

	// Token: 0x0600576F RID: 22383 RVA: 0x002729F4 File Offset: 0x00270BF4
	public void JPMOCIPNBLL(MFAONGBCHJE GMLIEKDKEAG)
	{
		if (GMLIEKDKEAG == (MFAONGBCHJE)8)
		{
			this.PANMNKKODPC.DOFade(1064f, 1467f * KDCJJBLGCBH.EHBBFMCILPC.OIABNIJLJBE());
			this.DGAAFGDHHHJ.DOScale(67f, 36f * KDCJJBLGCBH.EHBBFMCILPC.OIABNIJLJBE());
			this.DGAAFGDHHHJ.DOAnchorPos(this.DGAAFGDHHHJ.anchoredPosition + new Vector2(1121f, 1797f), 420f * KDCJJBLGCBH.EHBBFMCILPC.OIABNIJLJBE(), false).SetEase(Ease.Unset);
		}
	}

	// Token: 0x06005770 RID: 22384 RVA: 0x00272A8C File Offset: 0x00270C8C
	private void DJLCHMAHJLG()
	{
		AOBJLALDBAA.FILDBDMENPG().BADOPKAOCPE("OnSteamLoginFailed", new UnityAction(this.HKOLPBAMMPC));
		AOBJLALDBAA.FILDBDMENPG().FNMOFCMDFJP("$USEDYNAMICMETA", new UnityAction(this.LPJPKHLICPO));
	}

	// Token: 0x06005771 RID: 22385 RVA: 0x0026E929 File Offset: 0x0026CB29
	private IEnumerator NEKBMPGBLCJ()
	{
		for (int j = 0; j < this.AKFKCKHPIOA.Count; j++)
		{
			this.AKFKCKHPIOA[j].GetComponent<CanvasGroup>().alpha = 0f;
		}
		if (this.textTypeAnimation)
		{
			yield return new WaitForSeconds(0.3f * KDCJJBLGCBH.EHBBFMCILPC.CJOCPJLIILE());
		}
		int num;
		for (i = 0; i < this.AKFKCKHPIOA.Count; i = num + 1)
		{
			yield return new WaitForSeconds(0.25f * KDCJJBLGCBH.EHBBFMCILPC.CJOCPJLIILE());
			this.AKFKCKHPIOA[i].GetComponent<CanvasGroup>().DOFade(1f, 0.35f * KDCJJBLGCBH.EHBBFMCILPC.LIKMBLFBEIA());
			RectTransform component = this.AKFKCKHPIOA[i].GetComponent<RectTransform>();
			component.AMPMCKEAACJ(0.65f, 0.65f, 0.65f);
			component.DOScale(this.choicesScaleCoefficient, 0.35f * KDCJJBLGCBH.EHBBFMCILPC.LIKMBLFBEIA()).SetEase(Ease.OutBack);
			num = i;
		}
		yield break;
	}

	// Token: 0x06005772 RID: 22386 RVA: 0x00272AC4 File Offset: 0x00270CC4
	private void PLLIOMMMOED()
	{
		if (!this.CIPGFJLECDH)
		{
			SceneStoryManager.choiceDecisionTime += Time.deltaTime;
		}
		if (this.AKJMKGCPCCB >= 1)
		{
			this.AKJMKGCPCCB -= 0;
		}
		if (this.FILFGDIGINA != null)
		{
			int num = (int)this.FILFGDIGINA.JMLDFCJIKLE();
			this.textTimer.SetText(num.ToString(), false);
			this.timerArrowPivot.transform.localRotation = Quaternion.Euler(1418f, 1783f, this.FILFGDIGINA.GCHEPGGFBGM() * 1111f);
			this.imageTimerFillDefault.fillAmount = this.FILFGDIGINA.PMECGFIPNCC();
			this.imageTimerFillRed.fillAmount = this.FILFGDIGINA.GOFCDICHOEO();
			if (num < 1 && !this.imageTimerFillRed.gameObject.activeSelf && this.IMPAHLIGELE.EKOIFOBAHDM() < 1)
			{
				if (!AudioManager.APGODIBBPOD().PlaySfx("", true) && !AudioManager.APGODIBBPOD().PlaySfx("" + AKLFPGMDKLA.EHBBFMCILPC.OMOJIEHBENF().GGICIBLJIKI.ToString(), false))
				{
					AudioManager.DBFLIEGGGNN().PlaySfx("\n", true);
				}
				this.imageTimerFillRed.gameObject.SetActive(true);
			}
			if (this.FILFGDIGINA.HACBALNLLPP() && this.IMPAHLIGELE.EKOIFOBAHDM() < 0)
			{
				base.StartCoroutine(this.BKOFGAMAJCJ());
				CommonUserInterface.IKNOFBFMPGA().FreezeUX();
			}
		}
	}

	// Token: 0x06005773 RID: 22387 RVA: 0x00272C3C File Offset: 0x00270E3C
	public void DPBIKLHEJGM(MFAONGBCHJE GMLIEKDKEAG)
	{
		if (GMLIEKDKEAG == (MFAONGBCHJE)5)
		{
			this.PANMNKKODPC.DOFade(1157f, 1474f * KDCJJBLGCBH.EHBBFMCILPC.OIABNIJLJBE());
			this.DGAAFGDHHHJ.DOScale(611f, 201f * KDCJJBLGCBH.EHBBFMCILPC.OIABNIJLJBE());
			this.DGAAFGDHHHJ.DOAnchorPos(this.DGAAFGDHHHJ.anchoredPosition + new Vector2(1986f, 1470f), 145f * KDCJJBLGCBH.EHBBFMCILPC.OIABNIJLJBE(), true).SetEase(Ease.Unset);
		}
	}

	// Token: 0x06005774 RID: 22388 RVA: 0x0027293C File Offset: 0x00270B3C
	private IEnumerator BKOFGAMAJCJ()
	{
		DialogPlayerCharacterManager.FKHJFGLNIPA fkhjfglnipa = new DialogPlayerCharacterManager.FKHJFGLNIPA(1);
		fkhjfglnipa.<>4__this = this;
		return fkhjfglnipa;
	}

	// Token: 0x06005775 RID: 22389 RVA: 0x00272CD4 File Offset: 0x00270ED4
	private void MGECIGFEKGI()
	{
		if (this.FILFGDIGINA != null)
		{
			ODLLAEHMFAA.BGMALDJFMKE(this.FILFGDIGINA);
		}
		this.FILFGDIGINA = null;
		for (int i = 1; i < this.AKFKCKHPIOA.Count; i++)
		{
			this.AKFKCKHPIOA[i].GetComponent<Button>().onClick.RemoveAllListeners();
			this.AKFKCKHPIOA[i].GetComponent<CanvasGroup>().DOKill(false);
			UnityEngine.Object.Destroy(this.AKFKCKHPIOA[i]);
		}
		this.AKFKCKHPIOA.Clear();
		this.NDDGCFFDFJN.Clear();
		if (null != this.LOJHEKCOFME)
		{
			UnityEngine.Object.Destroy(this.LOJHEKCOFME);
		}
		if (null != this.NGGBBCDPMJH)
		{
			UnityEngine.Object.Destroy(this.NGGBBCDPMJH);
		}
		this.PANMNKKODPC.DOKill(true);
		this.DGAAFGDHHHJ.DOKill(true);
	}

	// Token: 0x06005776 RID: 22390 RVA: 0x00272DB8 File Offset: 0x00270FB8
	public void OHKFINOHAII(MFAONGBCHJE GMLIEKDKEAG)
	{
		if (GMLIEKDKEAG == (MFAONGBCHJE)4)
		{
			this.PANMNKKODPC.DOFade(1789f, 1637f * KDCJJBLGCBH.EHBBFMCILPC.OIABNIJLJBE());
			this.DGAAFGDHHHJ.DOScale(1115f, 237f * KDCJJBLGCBH.EHBBFMCILPC.OIABNIJLJBE());
			this.DGAAFGDHHHJ.DOAnchorPos(this.DGAAFGDHHHJ.anchoredPosition + new Vector2(1473f, 380f), 799f * KDCJJBLGCBH.EHBBFMCILPC.OIABNIJLJBE(), false).SetEase(Ease.Unset);
		}
	}

	// Token: 0x06005777 RID: 22391 RVA: 0x00272E50 File Offset: 0x00271050
	public void PreInitialize(HDKFHLFLDGG JIKFCLOHJNN)
	{
		if (JIKFCLOHJNN != null)
		{
			this.IMPAHLIGELE = JIKFCLOHJNN;
			this.NLKIPHPICLJ = ONEHEBIHPFB.LMDACNKELEC(this.IMPAHLIGELE.NEANAPPJBAN());
			this.GKKCHJLKFBL = ONEHEBIHPFB.LMDACNKELEC(this.IMPAHLIGELE.DKEOPDAFLNO());
			this.GKKCHJLKFBL = DPGJIJGOCIC.AKIAKADKBFK(this.GKKCHJLKFBL);
			this.AOKIMHCAAHB = this.GKKCHJLKFBL.Length;
		}
	}

	// Token: 0x06005778 RID: 22392 RVA: 0x00272EB5 File Offset: 0x002710B5
	private IEnumerator PPNGHDPMJIG()
	{
		DialogPlayerCharacterManager.AKPAKOFIIEH akpakofiieh = new DialogPlayerCharacterManager.AKPAKOFIIEH(1);
		akpakofiieh.<>4__this = this;
		return akpakofiieh;
	}

	// Token: 0x06005779 RID: 22393 RVA: 0x00272EC4 File Offset: 0x002710C4
	public void OMBCBDHPDJP(MFAONGBCHJE GMLIEKDKEAG)
	{
		if (this.textTypeAnimation)
		{
			base.StartCoroutine(this.IFKNGJBIGNO());
		}
		if (GMLIEKDKEAG == MFAONGBCHJE.animationAppear)
		{
			this.PANMNKKODPC.DOFade(794f, 643f * KDCJJBLGCBH.EHBBFMCILPC.OIABNIJLJBE()).SetDelay(1515f * KDCJJBLGCBH.EHBBFMCILPC.OIABNIJLJBE());
			this.DGAAFGDHHHJ.localScale = new Vector3(1593f, 1122f, 1580f);
			this.DGAAFGDHHHJ.DOScale(NBDLBFJOEGN.JACCDKKPFPF(), 1742f * KDCJJBLGCBH.EHBBFMCILPC.OIABNIJLJBE()).SetDelay(1158f * KDCJJBLGCBH.EHBBFMCILPC.OIABNIJLJBE());
			this.DGAAFGDHHHJ.AHLJBONHHKL(-25, 25);
			this.DGAAFGDHHHJ.DOAnchorPos(this.DGAAFGDHHHJ.anchoredPosition + new Vector2(33f, 697f), 1742f * KDCJJBLGCBH.EHBBFMCILPC.OIABNIJLJBE(), true).SetEase(Ease.InOutSine).SetDelay(480f * KDCJJBLGCBH.EHBBFMCILPC.OIABNIJLJBE());
			return;
		}
		if (GMLIEKDKEAG == MFAONGBCHJE.animationAppearCached)
		{
			this.PANMNKKODPC.DOFade(1506f, 8f * KDCJJBLGCBH.EHBBFMCILPC.OIABNIJLJBE()).SetEase(Ease.InCubic).SetDelay(1427f * KDCJJBLGCBH.EHBBFMCILPC.OIABNIJLJBE());
			if (NBDLBFJOEGN.PADHGAOKECA() < 45f)
			{
				this.DGAAFGDHHHJ.DOScale(NBDLBFJOEGN.HOMIGPGAGHG(), 283f);
			}
			this.DGAAFGDHHHJ.AHLJBONHHKL(67, -37);
			this.DGAAFGDHHHJ.DOAnchorPos(this.DGAAFGDHHHJ.anchoredPosition + new Vector2(1415f, 1148f), 1353f * KDCJJBLGCBH.EHBBFMCILPC.OIABNIJLJBE(), false).SetEase(Ease.OutQuad).SetDelay(739f * KDCJJBLGCBH.EHBBFMCILPC.OIABNIJLJBE());
		}
	}

	// Token: 0x0600577A RID: 22394 RVA: 0x0026E929 File Offset: 0x0026CB29
	private IEnumerator JLLMJKEJIAF()
	{
		for (int j = 0; j < this.AKFKCKHPIOA.Count; j++)
		{
			this.AKFKCKHPIOA[j].GetComponent<CanvasGroup>().alpha = 0f;
		}
		if (this.textTypeAnimation)
		{
			yield return new WaitForSeconds(0.3f * KDCJJBLGCBH.EHBBFMCILPC.CJOCPJLIILE());
		}
		int num;
		for (i = 0; i < this.AKFKCKHPIOA.Count; i = num + 1)
		{
			yield return new WaitForSeconds(0.25f * KDCJJBLGCBH.EHBBFMCILPC.CJOCPJLIILE());
			this.AKFKCKHPIOA[i].GetComponent<CanvasGroup>().DOFade(1f, 0.35f * KDCJJBLGCBH.EHBBFMCILPC.LIKMBLFBEIA());
			RectTransform component = this.AKFKCKHPIOA[i].GetComponent<RectTransform>();
			component.AMPMCKEAACJ(0.65f, 0.65f, 0.65f);
			component.DOScale(this.choicesScaleCoefficient, 0.35f * KDCJJBLGCBH.EHBBFMCILPC.LIKMBLFBEIA()).SetEase(Ease.OutBack);
			num = i;
		}
		yield break;
	}

	// Token: 0x0600577B RID: 22395 RVA: 0x002730AC File Offset: 0x002712AC
	private void PKDBNMKLNBA()
	{
		if (!this.IMPAHLIGELE.PINCOCDOOGH() || this.AKJMKGCPCCB > 0)
		{
			return;
		}
		this.CIPGFJLECDH = true;
		this.AKJMKGCPCCB = 24;
		AudioManager.DBFLIEGGGNN().PEOLMNFJAHG("retry", 682f);
		AudioManager.EHBBFMCILPC.POMJOMKCCNK("Loaded asset bundle:", 896f);
		AudioManager.EHBBFMCILPC.POMJOMKCCNK("" + AKLFPGMDKLA.EHBBFMCILPC.EEILOKHLKIM().GGICIBLJIKI.ToString(), 205f);
		this.IMPAHLIGELE.IABNDHFJHAF(1);
		AOBJLALDBAA.KKPFOJMAONG().KGIKHEDLPND("filter", 752f);
	}

	// Token: 0x0600577C RID: 22396 RVA: 0x00273154 File Offset: 0x00271354
	private void COKALJONCMC()
	{
		this.timerParent.SetActive(true);
		this.DGAAFGDHHHJ = base.gameObject.GetComponent<RectTransform>();
		this.PANMNKKODPC = base.gameObject.GetComponent<CanvasGroup>();
		this.PANMNKKODPC.alpha = 642f;
		if (this.textTypeAnimation)
		{
			this.textBody.alpha = 481f;
			return;
		}
		this.textBodyTypeAnimation.gameObject.SetActive(true);
	}

	// Token: 0x0600577D RID: 22397 RVA: 0x002731CC File Offset: 0x002713CC
	private void GALHNFOLOAK()
	{
		if (this.FILFGDIGINA != null)
		{
			ODLLAEHMFAA.BGMALDJFMKE(this.FILFGDIGINA);
		}
		this.FILFGDIGINA = null;
		for (int i = 0; i < this.AKFKCKHPIOA.Count; i++)
		{
			this.AKFKCKHPIOA[i].GetComponent<Button>().onClick.RemoveAllListeners();
			this.AKFKCKHPIOA[i].GetComponent<CanvasGroup>().DOKill(true);
			UnityEngine.Object.Destroy(this.AKFKCKHPIOA[i]);
		}
		this.AKFKCKHPIOA.Clear();
		this.NDDGCFFDFJN.Clear();
		if (null != this.LOJHEKCOFME)
		{
			UnityEngine.Object.Destroy(this.LOJHEKCOFME);
		}
		if (null != this.NGGBBCDPMJH)
		{
			UnityEngine.Object.Destroy(this.NGGBBCDPMJH);
		}
		this.PANMNKKODPC.DOKill(true);
		this.DGAAFGDHHHJ.DOKill(true);
	}

	// Token: 0x0600577E RID: 22398 RVA: 0x002732AF File Offset: 0x002714AF
	private bool KODEJEKIPPJ()
	{
		if (this.IMPAHLIGELE == null)
		{
			DPGJIJGOCIC.ANOPFDLPKGC("p");
			return false;
		}
		return false;
	}

	// Token: 0x0600577F RID: 22399 RVA: 0x002732C6 File Offset: 0x002714C6
	private void AKCBOPOJJFP()
	{
		AOBJLALDBAA.CEGAOMEEFBE().POLEDPIKODD("cardsvolchancesmsgbody", new UnityAction(this.HKOLPBAMMPC));
		AOBJLALDBAA.AGANFKKBPFO().PBELMJCPJMK("", new UnityAction(this.LPJPKHLICPO));
	}

	// Token: 0x06005780 RID: 22400 RVA: 0x00273300 File Offset: 0x00271500
	private void CEIDMENJBNK()
	{
		if (!this.CIPGFJLECDH)
		{
			SceneStoryManager.choiceDecisionTime += Time.deltaTime;
		}
		if (this.AKJMKGCPCCB >= 1)
		{
			this.AKJMKGCPCCB--;
		}
		if (this.FILFGDIGINA != null)
		{
			int num = (int)this.FILFGDIGINA.MFGJNCJKBHO();
			this.textTimer.SetText(num.ToString(), false);
			this.timerArrowPivot.transform.localRotation = Quaternion.Euler(703f, 594f, this.FILFGDIGINA.GCHEPGGFBGM() * 1451f);
			this.imageTimerFillDefault.fillAmount = this.FILFGDIGINA.MJPKAKNMHGM();
			this.imageTimerFillRed.fillAmount = this.FILFGDIGINA.GCHEPGGFBGM();
			if (num < 0 && !this.imageTimerFillRed.gameObject.activeSelf && this.IMPAHLIGELE.EKOIFOBAHDM() < 1)
			{
				if (!AudioManager.APGODIBBPOD().PlaySfx("OnLoungePremiumChoiceException", false) && !AudioManager.DMAAFFFEJGA().PlaySfx("0" + AKLFPGMDKLA.EHBBFMCILPC.OMOJIEHBENF().GGICIBLJIKI.ToString(), false))
				{
					AudioManager.DBFLIEGGGNN().PlaySfx("OnSceneLobbyManagerRound0aaAssetsDownloadSuccess", false);
				}
				this.imageTimerFillRed.gameObject.SetActive(true);
			}
			if (this.FILFGDIGINA.HACBALNLLPP() && this.IMPAHLIGELE.EKOIFOBAHDM() < 0)
			{
				base.StartCoroutine(this.CLIOPMNKHCP());
				CommonUserInterface.EHBBFMCILPC.FreezeUX();
			}
		}
	}

	// Token: 0x06005781 RID: 22401 RVA: 0x00273478 File Offset: 0x00271678
	private void KHOLJLKNAPJ()
	{
		AOBJLALDBAA.KKPFOJMAONG().EFKNEJFLGED("p", new UnityAction(this.EDKHFKOHKNP));
		AOBJLALDBAA.AGANFKKBPFO().GNBGEMMDGOJ("GeneralBalance.SearchKeyFloat() - could not find key:", new UnityAction(this.HBHDBDHBEPD));
	}

	// Token: 0x06005782 RID: 22402 RVA: 0x002734B0 File Offset: 0x002716B0
	private void INBLACGLGCD()
	{
		if (!this.IMPAHLIGELE.PINCOCDOOGH() || this.AKJMKGCPCCB > 1)
		{
			return;
		}
		this.CIPGFJLECDH = false;
		this.AKJMKGCPCCB = 59;
		AudioManager.DMAAFFFEJGA().KillSfx("CLIENT.SCREEN.REWARD.", 1063f);
		AudioManager.DMAAFFFEJGA().PEOLMNFJAHG("", 204f);
		AudioManager.APGODIBBPOD().POMJOMKCCNK("[<color=yellow>WARNING</color>] " + AKLFPGMDKLA.EHBBFMCILPC.OMOJIEHBENF().GGICIBLJIKI.ToString(), 786f);
		this.IMPAHLIGELE.IABNDHFJHAF(1);
		AOBJLALDBAA.DBLAIDPICIG().KGIKHEDLPND("Starting non-parallel download:", 520f);
	}

	// Token: 0x06005783 RID: 22403 RVA: 0x0026E921 File Offset: 0x0026CB21
	public int HLBIPNHEOLN()
	{
		return this.AOKIMHCAAHB;
	}

	// Token: 0x06005784 RID: 22404 RVA: 0x00273558 File Offset: 0x00271758
	public void NDKFJMHGPMK(HDKFHLFLDGG JIKFCLOHJNN)
	{
		if (JIKFCLOHJNN != null)
		{
			this.IMPAHLIGELE = JIKFCLOHJNN;
			this.NLKIPHPICLJ = ONEHEBIHPFB.LMDACNKELEC(this.IMPAHLIGELE.DNLHIMDGNMC());
			this.GKKCHJLKFBL = ONEHEBIHPFB.PLHGCKCFLEN(this.IMPAHLIGELE.NFKCEODACPH());
			this.GKKCHJLKFBL = DPGJIJGOCIC.AKIAKADKBFK(this.GKKCHJLKFBL);
			this.AOKIMHCAAHB = this.GKKCHJLKFBL.Length;
		}
	}

	// Token: 0x06005785 RID: 22405 RVA: 0x002735C0 File Offset: 0x002717C0
	private void LFPPGGLOOHJ()
	{
		this.timerParent.SetActive(false);
		this.DGAAFGDHHHJ = base.gameObject.GetComponent<RectTransform>();
		this.PANMNKKODPC = base.gameObject.GetComponent<CanvasGroup>();
		this.PANMNKKODPC.alpha = 389f;
		if (this.textTypeAnimation)
		{
			this.textBody.alpha = 447f;
			return;
		}
		this.textBodyTypeAnimation.gameObject.SetActive(false);
	}

	// Token: 0x06005787 RID: 22407 RVA: 0x0027364C File Offset: 0x0027184C
	private void JGGFMGKBCEM()
	{
		if (!this.IMPAHLIGELE.PINCOCDOOGH() || this.AKJMKGCPCCB > 1)
		{
			return;
		}
		this.CIPGFJLECDH = false;
		this.AKJMKGCPCCB = -127;
		AudioManager.APGODIBBPOD().KillSfx(" - chain: ", 602f);
		AudioManager.IFDLAMLHKIJ().KillSfx("sku", 1926f);
		AudioManager.DMAAFFFEJGA().PEOLMNFJAHG("OnAvatarScreenAssetsDownloadSuccess" + AKLFPGMDKLA.EHBBFMCILPC.OMOJIEHBENF().GGICIBLJIKI.ToString(), 1497f);
		this.IMPAHLIGELE.IABNDHFJHAF(1);
		AOBJLALDBAA.CEGAOMEEFBE().KGIKHEDLPND(" ", 573f);
	}

	// Token: 0x06005788 RID: 22408 RVA: 0x002736F4 File Offset: 0x002718F4
	private void DIKFMBJHGNH()
	{
		if (!this.IMPAHLIGELE.PINCOCDOOGH() || this.AKJMKGCPCCB > 0)
		{
			return;
		}
		this.CIPGFJLECDH = false;
		this.AKJMKGCPCCB = -120;
		AudioManager.DBFLIEGGGNN().KillSfx("llosd", 973f);
		AudioManager.IFDLAMLHKIJ().POMJOMKCCNK("KKK", 1584f);
		AudioManager.DMAAFFFEJGA().POMJOMKCCNK(" has " + AKLFPGMDKLA.EHBBFMCILPC.OMOJIEHBENF().GGICIBLJIKI.ToString(), 1727f);
		this.IMPAHLIGELE.IABNDHFJHAF(6);
		AOBJLALDBAA.AGANFKKBPFO().FDKBIBKABCM("loungenotavailable", 824f);
	}

	// Token: 0x06005789 RID: 22409 RVA: 0x0027379C File Offset: 0x0027199C
	private void HNKFJJEPEDC()
	{
		if (!this.IMPAHLIGELE.PINCOCDOOGH() || this.AKJMKGCPCCB > 0)
		{
			return;
		}
		this.CIPGFJLECDH = false;
		this.AKJMKGCPCCB = -30;
		AudioManager.EHBBFMCILPC.POMJOMKCCNK("", 1873f);
		AudioManager.BFCHJBOOJKE().POMJOMKCCNK("hoursshort", 1290f);
		AudioManager.DMAAFFFEJGA().KillSfx(") + is present, creating anthology save for anthology " + AKLFPGMDKLA.EHBBFMCILPC.EEILOKHLKIM().GGICIBLJIKI.ToString(), 371f);
		this.IMPAHLIGELE.IABNDHFJHAF(0);
		AOBJLALDBAA.EHBBFMCILPC.LPNCDPHNBJK("", 998f);
	}

	// Token: 0x0600578A RID: 22410 RVA: 0x00273844 File Offset: 0x00271A44
	private IEnumerator JLDEJMKFKML()
	{
		yield return new WaitForSeconds(0.5f * KDCJJBLGCBH.EHBBFMCILPC.LIKMBLFBEIA());
		this.textBodyTypeAnimation.GetComponent<AnimationTextType>().PlayAnimation();
		yield break;
	}

	// Token: 0x0600578B RID: 22411 RVA: 0x00273854 File Offset: 0x00271A54
	private void CECFDJNGEMF()
	{
		if (!this.IMPAHLIGELE.PINCOCDOOGH() || this.AKJMKGCPCCB > 0)
		{
			return;
		}
		this.CIPGFJLECDH = false;
		this.AKJMKGCPCCB = 26;
		AudioManager.APGODIBBPOD().POMJOMKCCNK("", 1635f);
		AudioManager.DMAAFFFEJGA().POMJOMKCCNK("UpdateSoundOnOffState", 825f);
		AudioManager.BFCHJBOOJKE().PEOLMNFJAHG("OnBackendPremiumChoiceSuccess" + AKLFPGMDKLA.EHBBFMCILPC.EEILOKHLKIM().GGICIBLJIKI.ToString(), 1209f);
		this.IMPAHLIGELE.IABNDHFJHAF(2);
		AOBJLALDBAA.KKPFOJMAONG().EFBNBFIDEOK("rs", 1465f);
	}

	// Token: 0x0600578D RID: 22413 RVA: 0x00273994 File Offset: 0x00271B94
	private void IIIKDDLAPJM()
	{
		if (!AKLFPGMDKLA.EHBBFMCILPC.EAFEJCKIEPL(1))
		{
			AKLFPGMDKLA.EHBBFMCILPC.LDAPMNLGAPC(0);
			for (int i = 1; i < this.NDDGCFFDFJN.Count; i++)
			{
				this.NDDGCFFDFJN[i].GetComponent<ChoicePremiumManager>().HideTip();
			}
		}
	}

	// Token: 0x0600578E RID: 22414 RVA: 0x002739E8 File Offset: 0x00271BE8
	public bool Initialize(HDKFHLFLDGG JIKFCLOHJNN, PLFDAJJHMKO BAOKJBJIFBH, LDLLJFOJCDF[] OAGPAAMJOID)
	{
		this.IMPAHLIGELE = JIKFCLOHJNN;
		this.LMKDNPOKOBF = BAOKJBJIFBH;
		if (!this.OONENNLLFHL())
		{
			return false;
		}
		if (JIKFCLOHJNN.GJOCJINDEIF && null != this.bubbleSprite)
		{
			Image component = base.gameObject.GetComponent<Image>();
			if (null != component)
			{
				component.sprite = this.bubbleSprite;
			}
		}
		if (this.IMPAHLIGELE.COEFNFJMBDG != null && this.IMPAHLIGELE.COEFNFJMBDG.Count > 0)
		{
			if (this.IMPAHLIGELE.JMNMOHIKHLB != null)
			{
				if (this.IMPAHLIGELE.JMNMOHIKHLB.NGNDOALIKAK.Contains("dynamic"))
				{
					if (this.IMPAHLIGELE.JMNMOHIKHLB.IPALJDCNBBG.Count > this.IMPAHLIGELE.COEFNFJMBDG.Count)
					{
						this.IMPAHLIGELE.JMNMOHIKHLB.AEMELJEDNJH(this.IMPAHLIGELE.JMNMOHIKHLB.IPALJDCNBBG.Count - this.IMPAHLIGELE.COEFNFJMBDG.Count);
					}
				}
				else
				{
					try
					{
						if (this.IMPAHLIGELE.JMNMOHIKHLB.JDJCPFDLBKG(this.IMPAHLIGELE.COEFNFJMBDG.Count))
						{
							this.IMPAHLIGELE.JMNMOHIKHLB.LOAJFPFKHJH(BAOKJBJIFBH.NCAMFPGMCIG.MLCAAHPBNGP());
						}
					}
					catch (Exception aklgbjkdomm)
					{
						DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
					}
				}
			}
			if (this.IMPAHLIGELE.JMNMOHIKHLB != null)
			{
				for (int i = 0; i < this.IMPAHLIGELE.JMNMOHIKHLB.MKPMEKKGEIL.Count; i++)
				{
					if (this.IMPAHLIGELE.JMNMOHIKHLB.MKPMEKKGEIL[i].EKDGAODNDOP() == HKCCMACFNEO.bulk)
					{
						for (int j = 0; j < this.IMPAHLIGELE.COEFNFJMBDG.Count; j++)
						{
							this.HNGBMIJHPLE.Add(j);
						}
						break;
					}
				}
			}
			if (this.HNGBMIJHPLE.Count == 0)
			{
				for (int k = 0; k < 2; k++)
				{
					for (int l = 0; l < this.IMPAHLIGELE.COEFNFJMBDG.Count; l++)
					{
						int num = 0;
						if (this.IMPAHLIGELE.JMNMOHIKHLB != null)
						{
							if (l < this.IMPAHLIGELE.JMNMOHIKHLB.IPALJDCNBBG.Count && this.IMPAHLIGELE.JMNMOHIKHLB.IPALJDCNBBG[l] > 0)
							{
								num = 1;
							}
							else if (l < this.IMPAHLIGELE.JMNMOHIKHLB.ENJDGEOFPAA.Count && this.IMPAHLIGELE.JMNMOHIKHLB.ENJDGEOFPAA[l] > 0)
							{
								num = 2;
							}
						}
						if ((k == 0 && num == 1) || (k != 0 && num != 1))
						{
							this.HNGBMIJHPLE.Add(l);
						}
					}
				}
			}
		}
		this.textTitle.overflowMode = TextOverflowModes.Truncate;
		this.textTitle.fontSizeMin = 12f;
		this.textTitle.SetText(this.NLKIPHPICLJ, true);
		this.textBody.SetText(this.GKKCHJLKFBL, true);
		SceneStoryManager.localizedLine = this.NLKIPHPICLJ + ": " + this.GKKCHJLKFBL;
		if (this.textTypeAnimation)
		{
			this.textBodyTypeAnimation.GetComponent<AnimationTextType>().Initialize(this.GKKCHJLKFBL);
		}
		if (this.IMPAHLIGELE.JMNMOHIKHLB != null && this.IMPAHLIGELE.JMNMOHIKHLB.FILFGDIGINA > 0)
		{
			this.FILFGDIGINA = ODLLAEHMFAA.IMEFIJEKFGI((float)this.IMPAHLIGELE.JMNMOHIKHLB.FILFGDIGINA, true);
			this.timerParent.SetActive(true);
		}
		int num2 = 0;
		if (null != this.decorObject)
		{
			this.decorObject.SetActive(false);
		}
		if (this.IMPAHLIGELE.COEFNFJMBDG != null && this.IMPAHLIGELE.COEFNFJMBDG.Count > 0)
		{
			if (null != this.decorObject)
			{
				this.decorObject.SetActive(true);
			}
			for (int m = 0; m < this.IMPAHLIGELE.COEFNFJMBDG.Count; m++)
			{
				if (!this.IMPAHLIGELE.COEFNFJMBDG[m].BEHENEHGPCP)
				{
					GameObject gameObject = null;
					int num3 = 0;
					if (this.IMPAHLIGELE.JMNMOHIKHLB != null && this.IMPAHLIGELE.JMNMOHIKHLB.GAOKFGHCIAF == PMNHKIDIMLM.NMGJJGIPDJP.text)
					{
						if (this.HDBBHHBOJIN(m) < this.IMPAHLIGELE.JMNMOHIKHLB.IPALJDCNBBG.Count && this.IMPAHLIGELE.JMNMOHIKHLB.IPALJDCNBBG[this.HDBBHHBOJIN(m)] > 0)
						{
							num3 = 1;
						}
						else if (this.HDBBHHBOJIN(m) < this.IMPAHLIGELE.JMNMOHIKHLB.ENJDGEOFPAA.Count && this.IMPAHLIGELE.JMNMOHIKHLB.ENJDGEOFPAA[this.HDBBHHBOJIN(m)] > 0)
						{
							num3 = 2;
						}
					}
					if (num3 == 2)
					{
						switch (this.IMPAHLIGELE.JMNMOHIKHLB.ADHIIAONMDJ[this.HDBBHHBOJIN(m)])
						{
						case CHEEGEJNIDB.stat0:
							gameObject = UnityEngine.Object.Instantiate<GameObject>(this.choiceStat0Prefab);
							break;
						case CHEEGEJNIDB.stat1:
							gameObject = UnityEngine.Object.Instantiate<GameObject>(this.choiceStat1Prefab);
							break;
						case CHEEGEJNIDB.stat2:
							gameObject = UnityEngine.Object.Instantiate<GameObject>(this.choiceStat2Prefab);
							break;
						case CHEEGEJNIDB.stat3:
							gameObject = UnityEngine.Object.Instantiate<GameObject>(this.choiceStat3Prefab);
							break;
						case CHEEGEJNIDB.stat4:
							gameObject = UnityEngine.Object.Instantiate<GameObject>(this.choiceStat4Prefab);
							break;
						case CHEEGEJNIDB.stat5:
							gameObject = UnityEngine.Object.Instantiate<GameObject>(this.choiceStat5Prefab);
							break;
						case CHEEGEJNIDB.stat6:
							gameObject = UnityEngine.Object.Instantiate<GameObject>(this.choiceStat6Prefab);
							break;
						}
						gameObject.transform.SetParent(this.choicesPivot.transform, false);
						gameObject.GetComponent<RectTransform>().AHLJBONHHKL(DialogPlayerCharacterManager.maxCriticalAspectRatioOffset * NBDLBFJOEGN.FBMMKINMKOH());
						gameObject.GetComponent<ChoiceStatManager>().Initialize(this.IMPAHLIGELE.COEFNFJMBDG[this.HDBBHHBOJIN(m)], this.IMPAHLIGELE.JMNMOHIKHLB.ENJDGEOFPAA[this.HDBBHHBOJIN(m)], OAGPAAMJOID[(int)this.IMPAHLIGELE.JMNMOHIKHLB.ADHIIAONMDJ[this.HDBBHHBOJIN(m)]].GALKFKBPLCK(), -1);
						gameObject.GetComponent<ChoiceStatManager>().ExtendRightSide();
						try
						{
							if (null == this.NGGBBCDPMJH)
							{
								switch (this.IMPAHLIGELE.JMNMOHIKHLB.ADHIIAONMDJ[this.HDBBHHBOJIN(m)])
								{
								case CHEEGEJNIDB.stat0:
									this.NGGBBCDPMJH = UnityEngine.Object.Instantiate<GameObject>(this.stat0InfoPrefab);
									break;
								case CHEEGEJNIDB.stat1:
									this.NGGBBCDPMJH = UnityEngine.Object.Instantiate<GameObject>(this.stat1InfoPrefab);
									break;
								case CHEEGEJNIDB.stat2:
									this.NGGBBCDPMJH = UnityEngine.Object.Instantiate<GameObject>(this.stat2InfoPrefab);
									break;
								case CHEEGEJNIDB.stat3:
									this.NGGBBCDPMJH = UnityEngine.Object.Instantiate<GameObject>(this.stat3InfoPrefab);
									break;
								case CHEEGEJNIDB.stat4:
									this.NGGBBCDPMJH = UnityEngine.Object.Instantiate<GameObject>(this.stat4InfoPrefab);
									break;
								case CHEEGEJNIDB.stat5:
									this.NGGBBCDPMJH = UnityEngine.Object.Instantiate<GameObject>(this.stat5InfoPrefab);
									break;
								case CHEEGEJNIDB.stat6:
									this.NGGBBCDPMJH = UnityEngine.Object.Instantiate<GameObject>(this.stat6InfoPrefab);
									break;
								}
								this.NGGBBCDPMJH.transform.SetParent(this.currencyPivot.transform, false);
								this.NGGBBCDPMJH.GetComponent<StatPointInfoManager>().Initialize(this.IMPAHLIGELE.JMNMOHIKHLB.ADHIIAONMDJ[this.HDBBHHBOJIN(m)], OAGPAAMJOID[(int)this.IMPAHLIGELE.JMNMOHIKHLB.ADHIIAONMDJ[this.HDBBHHBOJIN(m)]].GALKFKBPLCK());
								try
								{
									if (this.IMPAHLIGELE.JMNMOHIKHLB.NGNDOALIKAK.Contains("hidestatinfo"))
									{
										this.NGGBBCDPMJH.SetActive(false);
									}
								}
								catch (Exception aklgbjkdomm2)
								{
									DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm2);
								}
							}
							goto IL_A85;
						}
						catch (Exception aklgbjkdomm3)
						{
							DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm3);
							goto IL_A85;
						}
						goto IL_776;
					}
					goto IL_776;
					IL_A85:
					gameObject.GetComponent<RectTransform>().anchoredPosition += new Vector2(0f, (float)(this.choiceOffset * num2));
					Button component2 = gameObject.GetComponent<Button>();
					if (this.HDBBHHBOJIN(m) == 0)
					{
						component2.onClick.AddListener(new UnityAction(this.GMPJMMMIGLO));
					}
					else if (this.HDBBHHBOJIN(m) == 1)
					{
						component2.onClick.AddListener(new UnityAction(this.OLGOAJEBMIK));
					}
					else if (this.HDBBHHBOJIN(m) == 2)
					{
						component2.onClick.AddListener(new UnityAction(this.FFDGLHACKON));
					}
					else if (this.HDBBHHBOJIN(m) == 3)
					{
						component2.onClick.AddListener(new UnityAction(this.BOGHFJKGCNK));
					}
					else if (this.HDBBHHBOJIN(m) == 4)
					{
						component2.onClick.AddListener(new UnityAction(this.BENGHKGCLOG));
					}
					else if (this.HDBBHHBOJIN(m) == 5)
					{
						component2.onClick.AddListener(new UnityAction(this.HMHIJLKJGFN));
					}
					this.AKFKCKHPIOA.Add(gameObject);
					num2++;
					goto IL_BAA;
					IL_776:
					if (num3 == 1)
					{
						gameObject = UnityEngine.Object.Instantiate<GameObject>(this.choicePremiumPrefab);
						gameObject.transform.SetParent(this.choicesPivot.transform, false);
						gameObject.GetComponent<RectTransform>().AHLJBONHHKL(DialogPlayerCharacterManager.maxCriticalAspectRatioOffset * NBDLBFJOEGN.FBMMKINMKOH());
						if (SceneStoryManager.PremiumChoicePurchased(this.IMPAHLIGELE.JMNMOHIKHLB.MKPMEKKGEIL[this.HDBBHHBOJIN(m)], this.IMPAHLIGELE.JMNMOHIKHLB.KMFABKNKFAJ, this.IMPAHLIGELE.JMNMOHIKHLB.BGIOGOACCBJ))
						{
							gameObject.GetComponent<ChoicePremiumManager>().Initialize(this.IMPAHLIGELE.JMNMOHIKHLB.MKPMEKKGEIL[this.HDBBHHBOJIN(m)], this.IMPAHLIGELE.COEFNFJMBDG[this.HDBBHHBOJIN(m)], 0, -1, false, this.IMPAHLIGELE.JMNMOHIKHLB.CKLNCCAGCKE(this.HDBBHHBOJIN(m), LiveEventsManager.EHBBFMCILPC.LiveEventActive(EGMCEPOABBF.liveEventFreeAvatar, -1, -1)), this.IMPAHLIGELE.JMNMOHIKHLB.BGIOGOACCBJ);
						}
						else
						{
							if (null == this.LOJHEKCOFME)
							{
								this.LOJHEKCOFME = UnityEngine.Object.Instantiate<GameObject>(this.premiumInfoPrefab);
								this.LOJHEKCOFME.transform.SetParent(this.currencyPivot.transform, false);
								this.LOJHEKCOFME.GetComponent<StoryCurrencyInfoManager>().Initialize("OnStoryCurrencyInfoClick");
							}
							gameObject.GetComponent<ChoicePremiumManager>().Initialize(this.IMPAHLIGELE.JMNMOHIKHLB.MKPMEKKGEIL[this.HDBBHHBOJIN(m)], this.IMPAHLIGELE.COEFNFJMBDG[this.HDBBHHBOJIN(m)], this.IMPAHLIGELE.JMNMOHIKHLB.IPALJDCNBBG[this.HDBBHHBOJIN(m)], -1, !AKLFPGMDKLA.EHBBFMCILPC.EAFEJCKIEPL(0) && AKLFPGMDKLA.EHBBFMCILPC.ODMKLADKHMO.GALKFKBPLCK() >= this.IMPAHLIGELE.JMNMOHIKHLB.IPALJDCNBBG[this.HDBBHHBOJIN(m)], this.IMPAHLIGELE.JMNMOHIKHLB.CKLNCCAGCKE(this.HDBBHHBOJIN(m), LiveEventsManager.EHBBFMCILPC.LiveEventActive(EGMCEPOABBF.liveEventFreeAvatar, -1, -1)), this.IMPAHLIGELE.JMNMOHIKHLB.BGIOGOACCBJ);
						}
						gameObject.GetComponent<ChoicePremiumManager>().SwitchCost(SceneStoryManager.QualifiesAsAdBasedChoice(this.IMPAHLIGELE.JMNMOHIKHLB.MKPMEKKGEIL[this.HDBBHHBOJIN(m)], this.IMPAHLIGELE.JMNMOHIKHLB.KAJNELPPCIJ[this.HDBBHHBOJIN(m)], this.IMPAHLIGELE.JMNMOHIKHLB.KMFABKNKFAJ));
						this.NDDGCFFDFJN.Add(gameObject);
						goto IL_A85;
					}
					if (this.FLBNNNDBECB < 0)
					{
						this.FLBNNNDBECB = m;
					}
					gameObject = UnityEngine.Object.Instantiate<GameObject>(this.choiceStandardPrefab);
					gameObject.transform.SetParent(this.choicesPivot.transform, false);
					gameObject.GetComponent<RectTransform>().AHLJBONHHKL(DialogPlayerCharacterManager.maxCriticalAspectRatioOffset * NBDLBFJOEGN.FBMMKINMKOH());
					gameObject.GetComponent<ChoiceStandardManager>().Initialize(this.IMPAHLIGELE.COEFNFJMBDG[this.HDBBHHBOJIN(m)], -1);
					goto IL_A85;
				}
				IL_BAA:;
			}
		}
		if (this.AKFKCKHPIOA.Count > 0)
		{
			SceneStoryManager.choiceDecisionTime = 0f;
			base.StartCoroutine(this.NEKBMPGBLCJ());
		}
		for (int n = 0; n < this.NDDGCFFDFJN.Count; n++)
		{
			this.NDDGCFFDFJN[n].transform.SetAsLastSibling();
		}
		try
		{
			for (int num4 = 0; num4 < this.AKFKCKHPIOA.Count; num4++)
			{
				if (null != this.AKFKCKHPIOA[num4])
				{
					AnimationPress component3 = this.AKFKCKHPIOA[num4].GetComponent<AnimationPress>();
					if (null != component3)
					{
						component3.SetOriginalScaleCoefficient(this.choicesScaleCoefficient);
					}
				}
			}
		}
		catch (Exception aklgbjkdomm4)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm4);
		}
		return null != this.LOJHEKCOFME;
	}

	// Token: 0x0600578F RID: 22415 RVA: 0x002746E8 File Offset: 0x002728E8
	private void OANOLIAPPMH()
	{
		AOBJLALDBAA.FILDBDMENPG().KDIFKFKMCOH("yes", new UnityAction(this.EDKHFKOHKNP));
		AOBJLALDBAA.EHBBFMCILPC.MHLNJIACIGO("YYY", new UnityAction(this.LPJPKHLICPO));
	}

	// Token: 0x06005790 RID: 22416 RVA: 0x0026E514 File Offset: 0x0026C714
	private int HDBBHHBOJIN(int MEFKFOHCOHK)
	{
		return this.HNGBMIJHPLE[MEFKFOHCOHK];
	}

	// Token: 0x06005791 RID: 22417 RVA: 0x00274720 File Offset: 0x00272920
	private void HLEEFAFJIPP()
	{
		if (!this.IMPAHLIGELE.PINCOCDOOGH() || this.AKJMKGCPCCB > 1)
		{
			return;
		}
		this.CIPGFJLECDH = true;
		this.AKJMKGCPCCB = -4;
		AudioManager.BFCHJBOOJKE().POMJOMKCCNK("ok", 707f);
		AudioManager.EHBBFMCILPC.PEOLMNFJAHG("Error. MoveEnvironmentVertical(), environment ", 91f);
		AudioManager.APGODIBBPOD().KillSfx("OnConsumeEnergyException" + AKLFPGMDKLA.EHBBFMCILPC.EEILOKHLKIM().GGICIBLJIKI.ToString(), 441f);
		this.IMPAHLIGELE.IABNDHFJHAF(3);
		AOBJLALDBAA.CEGAOMEEFBE().DCGCFPHHDDG("OnBackendUndoPremiumChoiceException", 1016f);
	}

	// Token: 0x06005792 RID: 22418 RVA: 0x0026E514 File Offset: 0x0026C714
	private int JFBPPHBHHPE(int MEFKFOHCOHK)
	{
		return this.HNGBMIJHPLE[MEFKFOHCOHK];
	}

	// Token: 0x06005793 RID: 22419 RVA: 0x002747C8 File Offset: 0x002729C8
	private void EDLMFOBNPAP()
	{
		if (!this.IMPAHLIGELE.PINCOCDOOGH() || this.AKJMKGCPCCB > 1)
		{
			return;
		}
		this.CIPGFJLECDH = false;
		this.AKJMKGCPCCB = -96;
		AudioManager.IFDLAMLHKIJ().PEOLMNFJAHG("OnLobbyStopFireworksEffect", 904f);
		AudioManager.BFCHJBOOJKE().POMJOMKCCNK("Error. InstantEnvironmentChange(), _envId is null or length is 0:", 1515f);
		AudioManager.IFDLAMLHKIJ().PEOLMNFJAHG("story" + AKLFPGMDKLA.EHBBFMCILPC.EEILOKHLKIM().GGICIBLJIKI.ToString(), 1517f);
		this.IMPAHLIGELE.IABNDHFJHAF(3);
		AOBJLALDBAA.DBLAIDPICIG().EFBNBFIDEOK("errortitle", 1871f);
	}

	// Token: 0x06005794 RID: 22420 RVA: 0x00274870 File Offset: 0x00272A70
	private void HMHIJLKJGFN()
	{
		if (!this.IMPAHLIGELE.PINCOCDOOGH() || this.AKJMKGCPCCB > 0)
		{
			return;
		}
		this.CIPGFJLECDH = true;
		this.AKJMKGCPCCB = 20;
		AudioManager.EHBBFMCILPC.KillSfx("timeoutwarning", 1f);
		AudioManager.EHBBFMCILPC.KillSfx("sfxtimeoutwarning", 1f);
		AudioManager.EHBBFMCILPC.KillSfx("sfxtimeoutwarning" + AKLFPGMDKLA.EHBBFMCILPC.EEILOKHLKIM().GGICIBLJIKI.ToString(), 1f);
		this.IMPAHLIGELE.IABNDHFJHAF(5);
		AOBJLALDBAA.EHBBFMCILPC.EGELHPJBAIC("OnStoryChoiceClick", 0f);
	}

	// Token: 0x06005795 RID: 22421 RVA: 0x00274918 File Offset: 0x00272B18
	private void IJPIIOECDGL()
	{
		if (this.FILFGDIGINA != null)
		{
			ODLLAEHMFAA.BGMALDJFMKE(this.FILFGDIGINA);
		}
		this.FILFGDIGINA = null;
		for (int i = 0; i < this.AKFKCKHPIOA.Count; i += 0)
		{
			this.AKFKCKHPIOA[i].GetComponent<Button>().onClick.RemoveAllListeners();
			this.AKFKCKHPIOA[i].GetComponent<CanvasGroup>().DOKill(true);
			UnityEngine.Object.Destroy(this.AKFKCKHPIOA[i]);
		}
		this.AKFKCKHPIOA.Clear();
		this.NDDGCFFDFJN.Clear();
		if (null != this.LOJHEKCOFME)
		{
			UnityEngine.Object.Destroy(this.LOJHEKCOFME);
		}
		if (null != this.NGGBBCDPMJH)
		{
			UnityEngine.Object.Destroy(this.NGGBBCDPMJH);
		}
		this.PANMNKKODPC.DOKill(true);
		this.DGAAFGDHHHJ.DOKill(true);
	}

	// Token: 0x06005796 RID: 22422 RVA: 0x00273844 File Offset: 0x00271A44
	private IEnumerator IFKNGJBIGNO()
	{
		yield return new WaitForSeconds(0.5f * KDCJJBLGCBH.EHBBFMCILPC.LIKMBLFBEIA());
		this.textBodyTypeAnimation.GetComponent<AnimationTextType>().PlayAnimation();
		yield break;
	}

	// Token: 0x06005797 RID: 22423 RVA: 0x002749FC File Offset: 0x00272BFC
	private void DJHAFFDFBCI()
	{
		if (!this.IMPAHLIGELE.PINCOCDOOGH() || this.AKJMKGCPCCB > 0)
		{
			return;
		}
		this.CIPGFJLECDH = true;
		this.AKJMKGCPCCB = -2;
		AudioManager.DBFLIEGGGNN().KillSfx("langNeutral", 60f);
		AudioManager.DBFLIEGGGNN().PEOLMNFJAHG("\n\n", 1418f);
		AudioManager.APGODIBBPOD().POMJOMKCCNK("blur" + AKLFPGMDKLA.EHBBFMCILPC.OMOJIEHBENF().GGICIBLJIKI.ToString(), 1449f);
		this.IMPAHLIGELE.IABNDHFJHAF(4);
		AOBJLALDBAA.FILDBDMENPG().FDKBIBKABCM("OnCutsceneViewAssetBundleFolderInitializeSuccess", 500f);
	}

	// Token: 0x06005798 RID: 22424 RVA: 0x00274AA4 File Offset: 0x00272CA4
	private void GMPJMMMIGLO()
	{
		if (!this.IMPAHLIGELE.PINCOCDOOGH() || this.AKJMKGCPCCB > 0)
		{
			return;
		}
		this.CIPGFJLECDH = true;
		this.AKJMKGCPCCB = 20;
		AudioManager.EHBBFMCILPC.KillSfx("timeoutwarning", 1f);
		AudioManager.EHBBFMCILPC.KillSfx("sfxtimeoutwarning", 1f);
		AudioManager.EHBBFMCILPC.KillSfx("sfxtimeoutwarning" + AKLFPGMDKLA.EHBBFMCILPC.EEILOKHLKIM().GGICIBLJIKI.ToString(), 1f);
		this.IMPAHLIGELE.IABNDHFJHAF(0);
		AOBJLALDBAA.EHBBFMCILPC.EGELHPJBAIC("OnStoryChoiceClick", 0f);
	}

	// Token: 0x06005799 RID: 22425 RVA: 0x00274B4C File Offset: 0x00272D4C
	private void JNGCJDJPMGM()
	{
		if (this.FILFGDIGINA != null)
		{
			ODLLAEHMFAA.BGMALDJFMKE(this.FILFGDIGINA);
		}
		this.FILFGDIGINA = null;
		try
		{
			if (this.LMKDNPOKOBF != null && this.IMPAHLIGELE.JMNMOHIKHLB != null && this.IMPAHLIGELE.JMNMOHIKHLB.NDPPILBPOGB != null && this.IMPAHLIGELE.JMNMOHIKHLB.NDPPILBPOGB.Length > 0)
			{
				this.LMKDNPOKOBF.NCAMFPGMCIG.NKIOJCLBKAK(this.IMPAHLIGELE.JMNMOHIKHLB.NDPPILBPOGB + "ink" + this.IMPAHLIGELE.EKOIFOBAHDM().ToString());
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x0600579A RID: 22426 RVA: 0x00274C08 File Offset: 0x00272E08
	private void PBJOGHEGEKC()
	{
		if (!this.IMPAHLIGELE.PINCOCDOOGH() || this.AKJMKGCPCCB > 0)
		{
			return;
		}
		this.CIPGFJLECDH = false;
		this.AKJMKGCPCCB = -90;
		AudioManager.DBFLIEGGGNN().POMJOMKCCNK("[LoadingEnv] cache clean requested by the player, stored theme forgotten", 810f);
		AudioManager.IFDLAMLHKIJ().PEOLMNFJAHG("OnAccountForgetException", 682f);
		AudioManager.IFDLAMLHKIJ().PEOLMNFJAHG("OnApplicationBeforeRestart" + AKLFPGMDKLA.EHBBFMCILPC.EEILOKHLKIM().GGICIBLJIKI.ToString(), 211f);
		this.IMPAHLIGELE.IABNDHFJHAF(0);
		AOBJLALDBAA.BIAEAOMHBMM().KMAGHMCCMPG("F0", 1257f);
	}

	// Token: 0x0600579B RID: 22427 RVA: 0x00274CB0 File Offset: 0x00272EB0
	public bool DFIKJAJIDKD(HDKFHLFLDGG JIKFCLOHJNN, PLFDAJJHMKO BAOKJBJIFBH, LDLLJFOJCDF[] OAGPAAMJOID)
	{
		this.IMPAHLIGELE = JIKFCLOHJNN;
		this.LMKDNPOKOBF = BAOKJBJIFBH;
		if (!this.OPEILKPECHH())
		{
			return false;
		}
		if (JIKFCLOHJNN.GJOCJINDEIF && null != this.bubbleSprite)
		{
			Image component = base.gameObject.GetComponent<Image>();
			if (null != component)
			{
				component.sprite = this.bubbleSprite;
			}
		}
		if (this.IMPAHLIGELE.COEFNFJMBDG != null && this.IMPAHLIGELE.COEFNFJMBDG.Count > 0)
		{
			if (this.IMPAHLIGELE.JMNMOHIKHLB != null)
			{
				if (this.IMPAHLIGELE.JMNMOHIKHLB.NGNDOALIKAK.Contains("cardschar"))
				{
					if (this.IMPAHLIGELE.JMNMOHIKHLB.IPALJDCNBBG.Count > this.IMPAHLIGELE.COEFNFJMBDG.Count)
					{
						this.IMPAHLIGELE.JMNMOHIKHLB.EBFCBGAPICN(this.IMPAHLIGELE.JMNMOHIKHLB.IPALJDCNBBG.Count - this.IMPAHLIGELE.COEFNFJMBDG.Count);
					}
				}
				else
				{
					try
					{
						if (this.IMPAHLIGELE.JMNMOHIKHLB.MAHMALPGHDO(this.IMPAHLIGELE.COEFNFJMBDG.Count))
						{
							this.IMPAHLIGELE.JMNMOHIKHLB.OOMKENDDJEJ(BAOKJBJIFBH.NCAMFPGMCIG.MLCAAHPBNGP());
						}
					}
					catch (Exception aklgbjkdomm)
					{
						DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
					}
				}
			}
			if (this.IMPAHLIGELE.JMNMOHIKHLB != null)
			{
				for (int i = 1; i < this.IMPAHLIGELE.JMNMOHIKHLB.MKPMEKKGEIL.Count; i++)
				{
					if (this.IMPAHLIGELE.JMNMOHIKHLB.MKPMEKKGEIL[i].BFGHEPLHJFI() == (HKCCMACFNEO)4)
					{
						for (int j = 0; j < this.IMPAHLIGELE.COEFNFJMBDG.Count; j += 0)
						{
							this.HNGBMIJHPLE.Add(j);
						}
						break;
					}
				}
			}
			if (this.HNGBMIJHPLE.Count == 0)
			{
				for (int k = 0; k < 8; k += 0)
				{
					for (int l = 0; l < this.IMPAHLIGELE.COEFNFJMBDG.Count; l++)
					{
						int num = 1;
						if (this.IMPAHLIGELE.JMNMOHIKHLB != null)
						{
							if (l < this.IMPAHLIGELE.JMNMOHIKHLB.IPALJDCNBBG.Count && this.IMPAHLIGELE.JMNMOHIKHLB.IPALJDCNBBG[l] > 1)
							{
								num = 1;
							}
							else if (l < this.IMPAHLIGELE.JMNMOHIKHLB.ENJDGEOFPAA.Count && this.IMPAHLIGELE.JMNMOHIKHLB.ENJDGEOFPAA[l] > 1)
							{
								num = 5;
							}
						}
						if ((k == 0 && num == 1) || (k != 0 && num != 1))
						{
							this.HNGBMIJHPLE.Add(l);
						}
					}
				}
			}
		}
		this.textTitle.overflowMode = TextOverflowModes.Truncate;
		this.textTitle.fontSizeMin = 632f;
		this.textTitle.SetText(this.NLKIPHPICLJ, true);
		this.textBody.SetText(this.GKKCHJLKFBL, true);
		SceneStoryManager.localizedLine = this.NLKIPHPICLJ + "CHECKSUM" + this.GKKCHJLKFBL;
		if (this.textTypeAnimation)
		{
			this.textBodyTypeAnimation.GetComponent<AnimationTextType>().HDAHPNAHNJC(this.GKKCHJLKFBL);
		}
		if (this.IMPAHLIGELE.JMNMOHIKHLB != null && this.IMPAHLIGELE.JMNMOHIKHLB.FILFGDIGINA > 1)
		{
			this.FILFGDIGINA = ODLLAEHMFAA.IMEFIJEKFGI((float)this.IMPAHLIGELE.JMNMOHIKHLB.FILFGDIGINA, false);
			this.timerParent.SetActive(false);
		}
		int num2 = 1;
		if (null != this.decorObject)
		{
			this.decorObject.SetActive(true);
		}
		if (this.IMPAHLIGELE.COEFNFJMBDG != null && this.IMPAHLIGELE.COEFNFJMBDG.Count > 1)
		{
			if (null != this.decorObject)
			{
				this.decorObject.SetActive(false);
			}
			for (int m = 0; m < this.IMPAHLIGELE.COEFNFJMBDG.Count; m++)
			{
				if (!this.IMPAHLIGELE.COEFNFJMBDG[m].BEHENEHGPCP)
				{
					GameObject gameObject = null;
					int num3 = 0;
					if (this.IMPAHLIGELE.JMNMOHIKHLB != null && this.IMPAHLIGELE.JMNMOHIKHLB.GAOKFGHCIAF == PMNHKIDIMLM.NMGJJGIPDJP.text)
					{
						if (this.CDMICJFABHI(m) < this.IMPAHLIGELE.JMNMOHIKHLB.IPALJDCNBBG.Count && this.IMPAHLIGELE.JMNMOHIKHLB.IPALJDCNBBG[this.JFBPPHBHHPE(m)] > 1)
						{
							num3 = 0;
						}
						else if (this.JFBPPHBHHPE(m) < this.IMPAHLIGELE.JMNMOHIKHLB.ENJDGEOFPAA.Count && this.IMPAHLIGELE.JMNMOHIKHLB.ENJDGEOFPAA[this.HDBBHHBOJIN(m)] > 0)
						{
							num3 = 2;
						}
					}
					if (num3 == 2)
					{
						switch (this.IMPAHLIGELE.JMNMOHIKHLB.ADHIIAONMDJ[this.FHEOKFGDBHO(m)])
						{
						case CHEEGEJNIDB.stat0:
							gameObject = UnityEngine.Object.Instantiate<GameObject>(this.choiceStat0Prefab);
							break;
						case CHEEGEJNIDB.stat1:
							gameObject = UnityEngine.Object.Instantiate<GameObject>(this.choiceStat1Prefab);
							break;
						case CHEEGEJNIDB.stat2:
							gameObject = UnityEngine.Object.Instantiate<GameObject>(this.choiceStat2Prefab);
							break;
						case CHEEGEJNIDB.stat3:
							gameObject = UnityEngine.Object.Instantiate<GameObject>(this.choiceStat3Prefab);
							break;
						case CHEEGEJNIDB.stat4:
							gameObject = UnityEngine.Object.Instantiate<GameObject>(this.choiceStat4Prefab);
							break;
						case CHEEGEJNIDB.stat5:
							gameObject = UnityEngine.Object.Instantiate<GameObject>(this.choiceStat5Prefab);
							break;
						case CHEEGEJNIDB.stat6:
							gameObject = UnityEngine.Object.Instantiate<GameObject>(this.choiceStat6Prefab);
							break;
						}
						gameObject.transform.SetParent(this.choicesPivot.transform, true);
						gameObject.GetComponent<RectTransform>().AHLJBONHHKL(DialogPlayerCharacterManager.maxCriticalAspectRatioOffset * NBDLBFJOEGN.DMIBBFIPJNA());
						gameObject.GetComponent<ChoiceStatManager>().FNLKGBALACA(this.IMPAHLIGELE.COEFNFJMBDG[this.GAKKBOIHKCE(m)], this.IMPAHLIGELE.JMNMOHIKHLB.ENJDGEOFPAA[this.JFBPPHBHHPE(m)], OAGPAAMJOID[(int)this.IMPAHLIGELE.JMNMOHIKHLB.ADHIIAONMDJ[this.PDDLFHNEHJL(m)]].BFMPOACOBPN(), -1);
						gameObject.GetComponent<ChoiceStatManager>().ECIPAHHEGOF();
						try
						{
							if (null == this.NGGBBCDPMJH)
							{
								switch (this.IMPAHLIGELE.JMNMOHIKHLB.ADHIIAONMDJ[this.PDDLFHNEHJL(m)])
								{
								case CHEEGEJNIDB.stat0:
									this.NGGBBCDPMJH = UnityEngine.Object.Instantiate<GameObject>(this.stat0InfoPrefab);
									break;
								case CHEEGEJNIDB.stat1:
									this.NGGBBCDPMJH = UnityEngine.Object.Instantiate<GameObject>(this.stat1InfoPrefab);
									break;
								case CHEEGEJNIDB.stat2:
									this.NGGBBCDPMJH = UnityEngine.Object.Instantiate<GameObject>(this.stat2InfoPrefab);
									break;
								case CHEEGEJNIDB.stat3:
									this.NGGBBCDPMJH = UnityEngine.Object.Instantiate<GameObject>(this.stat3InfoPrefab);
									break;
								case CHEEGEJNIDB.stat4:
									this.NGGBBCDPMJH = UnityEngine.Object.Instantiate<GameObject>(this.stat4InfoPrefab);
									break;
								case CHEEGEJNIDB.stat5:
									this.NGGBBCDPMJH = UnityEngine.Object.Instantiate<GameObject>(this.stat5InfoPrefab);
									break;
								case CHEEGEJNIDB.stat6:
									this.NGGBBCDPMJH = UnityEngine.Object.Instantiate<GameObject>(this.stat6InfoPrefab);
									break;
								}
								this.NGGBBCDPMJH.transform.SetParent(this.currencyPivot.transform, true);
								this.NGGBBCDPMJH.GetComponent<StatPointInfoManager>().KJDNFFJJLDN(this.IMPAHLIGELE.JMNMOHIKHLB.ADHIIAONMDJ[this.JFBPPHBHHPE(m)], OAGPAAMJOID[(int)this.IMPAHLIGELE.JMNMOHIKHLB.ADHIIAONMDJ[this.HFNEKLFKLLI(m)]].BADNAGEMINF());
								try
								{
									if (this.IMPAHLIGELE.JMNMOHIKHLB.NGNDOALIKAK.Contains("Loading "))
									{
										this.NGGBBCDPMJH.SetActive(false);
									}
								}
								catch (Exception aklgbjkdomm2)
								{
									DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm2);
								}
							}
							goto IL_A85;
						}
						catch (Exception aklgbjkdomm3)
						{
							DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm3);
							goto IL_A85;
						}
						goto IL_776;
					}
					goto IL_776;
					IL_A85:
					gameObject.GetComponent<RectTransform>().anchoredPosition += new Vector2(1780f, (float)(this.choiceOffset * num2));
					Button component2 = gameObject.GetComponent<Button>();
					if (this.HFNEKLFKLLI(m) == 0)
					{
						component2.onClick.AddListener(new UnityAction(this.GMPJMMMIGLO));
					}
					else if (this.HDBBHHBOJIN(m) == 1)
					{
						component2.onClick.AddListener(new UnityAction(this.JGGFMGKBCEM));
					}
					else if (this.PDDLFHNEHJL(m) == 2)
					{
						component2.onClick.AddListener(new UnityAction(this.FFDGLHACKON));
					}
					else if (this.HFNEKLFKLLI(m) == 2)
					{
						component2.onClick.AddListener(new UnityAction(this.LKICBGONHFI));
					}
					else if (this.GAKKBOIHKCE(m) == 0)
					{
						component2.onClick.AddListener(new UnityAction(this.CECFDJNGEMF));
					}
					else if (this.HDBBHHBOJIN(m) == 8)
					{
						component2.onClick.AddListener(new UnityAction(this.DJHAFFDFBCI));
					}
					this.AKFKCKHPIOA.Add(gameObject);
					num2++;
					goto IL_BAA;
					IL_776:
					if (num3 == 0)
					{
						gameObject = UnityEngine.Object.Instantiate<GameObject>(this.choicePremiumPrefab);
						gameObject.transform.SetParent(this.choicesPivot.transform, true);
						gameObject.GetComponent<RectTransform>().AHLJBONHHKL(DialogPlayerCharacterManager.maxCriticalAspectRatioOffset * NBDLBFJOEGN.DMIBBFIPJNA());
						if (SceneStoryManager.PremiumChoicePurchased(this.IMPAHLIGELE.JMNMOHIKHLB.MKPMEKKGEIL[this.JFBPPHBHHPE(m)], this.IMPAHLIGELE.JMNMOHIKHLB.KMFABKNKFAJ, this.IMPAHLIGELE.JMNMOHIKHLB.BGIOGOACCBJ))
						{
							gameObject.GetComponent<ChoicePremiumManager>().Initialize(this.IMPAHLIGELE.JMNMOHIKHLB.MKPMEKKGEIL[this.JFBPPHBHHPE(m)], this.IMPAHLIGELE.COEFNFJMBDG[this.GAKKBOIHKCE(m)], 1, -1, true, this.IMPAHLIGELE.JMNMOHIKHLB.CKLNCCAGCKE(this.GAKKBOIHKCE(m), LiveEventsManager.JCMABFEMFKD().HLCKJEIFAFM((EGMCEPOABBF)8, -1, -1)), this.IMPAHLIGELE.JMNMOHIKHLB.BGIOGOACCBJ);
						}
						else
						{
							if (null == this.LOJHEKCOFME)
							{
								this.LOJHEKCOFME = UnityEngine.Object.Instantiate<GameObject>(this.premiumInfoPrefab);
								this.LOJHEKCOFME.transform.SetParent(this.currencyPivot.transform, true);
								this.LOJHEKCOFME.GetComponent<StoryCurrencyInfoManager>().Initialize("...");
							}
							gameObject.GetComponent<ChoicePremiumManager>().Initialize(this.IMPAHLIGELE.JMNMOHIKHLB.MKPMEKKGEIL[this.HDBBHHBOJIN(m)], this.IMPAHLIGELE.COEFNFJMBDG[this.GAKKBOIHKCE(m)], this.IMPAHLIGELE.JMNMOHIKHLB.IPALJDCNBBG[this.PDDLFHNEHJL(m)], -1, AKLFPGMDKLA.EHBBFMCILPC.EAFEJCKIEPL(0) || AKLFPGMDKLA.EHBBFMCILPC.ODMKLADKHMO.KGEGKPHEMOJ() < this.IMPAHLIGELE.JMNMOHIKHLB.IPALJDCNBBG[this.GAKKBOIHKCE(m)], this.IMPAHLIGELE.JMNMOHIKHLB.JBEBPDBMKMP(this.HDBBHHBOJIN(m), LiveEventsManager.BIAEAOMHBMM().OPHKFJNACGB((EGMCEPOABBF)7, -1, -1)), this.IMPAHLIGELE.JMNMOHIKHLB.BGIOGOACCBJ);
						}
						gameObject.GetComponent<ChoicePremiumManager>().SwitchCost(SceneStoryManager.QualifiesAsAdBasedChoice(this.IMPAHLIGELE.JMNMOHIKHLB.MKPMEKKGEIL[this.FHEOKFGDBHO(m)], this.IMPAHLIGELE.JMNMOHIKHLB.KAJNELPPCIJ[this.FHEOKFGDBHO(m)], this.IMPAHLIGELE.JMNMOHIKHLB.KMFABKNKFAJ));
						this.NDDGCFFDFJN.Add(gameObject);
						goto IL_A85;
					}
					if (this.FLBNNNDBECB < 0)
					{
						this.FLBNNNDBECB = m;
					}
					gameObject = UnityEngine.Object.Instantiate<GameObject>(this.choiceStandardPrefab);
					gameObject.transform.SetParent(this.choicesPivot.transform, false);
					gameObject.GetComponent<RectTransform>().AHLJBONHHKL(DialogPlayerCharacterManager.maxCriticalAspectRatioOffset * NBDLBFJOEGN.DMIBBFIPJNA());
					gameObject.GetComponent<ChoiceStandardManager>().DFFMNJDFNJG(this.IMPAHLIGELE.COEFNFJMBDG[this.HDBBHHBOJIN(m)], -1);
					goto IL_A85;
				}
				IL_BAA:;
			}
		}
		if (this.AKFKCKHPIOA.Count > 1)
		{
			SceneStoryManager.choiceDecisionTime = 1480f;
			base.StartCoroutine(this.EDBEPPHCMKK());
		}
		for (int n = 1; n < this.NDDGCFFDFJN.Count; n++)
		{
			this.NDDGCFFDFJN[n].transform.SetAsLastSibling();
		}
		try
		{
			for (int num4 = 0; num4 < this.AKFKCKHPIOA.Count; num4 += 0)
			{
				if (null != this.AKFKCKHPIOA[num4])
				{
					AnimationPress component3 = this.AKFKCKHPIOA[num4].GetComponent<AnimationPress>();
					if (null != component3)
					{
						component3.LEKNPNMNAOJ(this.choicesScaleCoefficient);
					}
				}
			}
		}
		catch (Exception aklgbjkdomm4)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm4);
		}
		return null != this.LOJHEKCOFME;
	}

	// Token: 0x0600579C RID: 22428 RVA: 0x0026E514 File Offset: 0x0026C714
	private int HFNEKLFKLLI(int MEFKFOHCOHK)
	{
		return this.HNGBMIJHPLE[MEFKFOHCOHK];
	}

	// Token: 0x0600579D RID: 22429 RVA: 0x002759B0 File Offset: 0x00273BB0
	private void MJEMMAICGMA()
	{
		if (!this.IMPAHLIGELE.PINCOCDOOGH() || this.AKJMKGCPCCB > 0)
		{
			return;
		}
		this.CIPGFJLECDH = true;
		this.AKJMKGCPCCB = 11;
		AudioManager.EHBBFMCILPC.PEOLMNFJAHG("energyhinttitle", 1150f);
		AudioManager.IFDLAMLHKIJ().KillSfx("wind", 1927f);
		AudioManager.BFCHJBOOJKE().PEOLMNFJAHG("usyncs" + AKLFPGMDKLA.EHBBFMCILPC.OMOJIEHBENF().GGICIBLJIKI.ToString(), 76f);
		this.IMPAHLIGELE.IABNDHFJHAF(8);
		AOBJLALDBAA.EHBBFMCILPC.EFBNBFIDEOK("ccpoolkeep", 921f);
	}

	// Token: 0x0600579E RID: 22430 RVA: 0x0026E929 File Offset: 0x0026CB29
	private IEnumerator EDBEPPHCMKK()
	{
		for (int j = 0; j < this.AKFKCKHPIOA.Count; j++)
		{
			this.AKFKCKHPIOA[j].GetComponent<CanvasGroup>().alpha = 0f;
		}
		if (this.textTypeAnimation)
		{
			yield return new WaitForSeconds(0.3f * KDCJJBLGCBH.EHBBFMCILPC.CJOCPJLIILE());
		}
		int num;
		for (i = 0; i < this.AKFKCKHPIOA.Count; i = num + 1)
		{
			yield return new WaitForSeconds(0.25f * KDCJJBLGCBH.EHBBFMCILPC.CJOCPJLIILE());
			this.AKFKCKHPIOA[i].GetComponent<CanvasGroup>().DOFade(1f, 0.35f * KDCJJBLGCBH.EHBBFMCILPC.LIKMBLFBEIA());
			RectTransform component = this.AKFKCKHPIOA[i].GetComponent<RectTransform>();
			component.AMPMCKEAACJ(0.65f, 0.65f, 0.65f);
			component.DOScale(this.choicesScaleCoefficient, 0.35f * KDCJJBLGCBH.EHBBFMCILPC.LIKMBLFBEIA()).SetEase(Ease.OutBack);
			num = i;
		}
		yield break;
	}

	// Token: 0x0600579F RID: 22431 RVA: 0x0026E921 File Offset: 0x0026CB21
	public int DKFCJHIKFJM()
	{
		return this.AOKIMHCAAHB;
	}

	// Token: 0x060057A0 RID: 22432 RVA: 0x00275A58 File Offset: 0x00273C58
	private void EFOBIAOGBHP()
	{
		this.timerParent.SetActive(false);
		this.DGAAFGDHHHJ = base.gameObject.GetComponent<RectTransform>();
		this.PANMNKKODPC = base.gameObject.GetComponent<CanvasGroup>();
		this.PANMNKKODPC.alpha = 310f;
		if (this.textTypeAnimation)
		{
			this.textBody.alpha = 464f;
			return;
		}
		this.textBodyTypeAnimation.gameObject.SetActive(false);
	}

	// Token: 0x060057A1 RID: 22433 RVA: 0x00275AD0 File Offset: 0x00273CD0
	private void FIAMLCIPELI()
	{
		if (!this.IMPAHLIGELE.PINCOCDOOGH() || this.AKJMKGCPCCB > 1)
		{
			return;
		}
		this.CIPGFJLECDH = true;
		this.AKJMKGCPCCB = 9;
		AudioManager.APGODIBBPOD().PEOLMNFJAHG("Starting non-parallel download:", 507f);
		AudioManager.DMAAFFFEJGA().POMJOMKCCNK("gpsasst", 1587f);
		AudioManager.IFDLAMLHKIJ().KillSfx("" + AKLFPGMDKLA.EHBBFMCILPC.OMOJIEHBENF().GGICIBLJIKI.ToString(), 790f);
		this.IMPAHLIGELE.IABNDHFJHAF(1);
		AOBJLALDBAA.KKPFOJMAONG().DCGCFPHHDDG("Game Title", 463f);
	}

	// Token: 0x060057A2 RID: 22434 RVA: 0x00275B78 File Offset: 0x00273D78
	private void BENGHKGCLOG()
	{
		if (!this.IMPAHLIGELE.PINCOCDOOGH() || this.AKJMKGCPCCB > 0)
		{
			return;
		}
		this.CIPGFJLECDH = true;
		this.AKJMKGCPCCB = 20;
		AudioManager.EHBBFMCILPC.KillSfx("timeoutwarning", 1f);
		AudioManager.EHBBFMCILPC.KillSfx("sfxtimeoutwarning", 1f);
		AudioManager.EHBBFMCILPC.KillSfx("sfxtimeoutwarning" + AKLFPGMDKLA.EHBBFMCILPC.EEILOKHLKIM().GGICIBLJIKI.ToString(), 1f);
		this.IMPAHLIGELE.IABNDHFJHAF(4);
		AOBJLALDBAA.EHBBFMCILPC.EGELHPJBAIC("OnStoryChoiceClick", 0f);
	}

	// Token: 0x060057A3 RID: 22435 RVA: 0x00275C20 File Offset: 0x00273E20
	private void MIAEKFMEHPA()
	{
		if (!this.IMPAHLIGELE.PINCOCDOOGH() || this.AKJMKGCPCCB > 0)
		{
			return;
		}
		this.CIPGFJLECDH = true;
		this.AKJMKGCPCCB = 51;
		AudioManager.EHBBFMCILPC.PEOLMNFJAHG("cardschar", 225f);
		AudioManager.IFDLAMLHKIJ().PEOLMNFJAHG("assetbundleavatarextensionpack", 650f);
		AudioManager.DBFLIEGGGNN().PEOLMNFJAHG("" + AKLFPGMDKLA.EHBBFMCILPC.EEILOKHLKIM().GGICIBLJIKI.ToString(), 10f);
		this.IMPAHLIGELE.IABNDHFJHAF(0);
		AOBJLALDBAA.AGANFKKBPFO().CIGLHCJDDPI("newFilter", 38f);
	}

	// Token: 0x060057A4 RID: 22436 RVA: 0x00275CC8 File Offset: 0x00273EC8
	private void OABCLPGJLEC()
	{
		if (!this.IMPAHLIGELE.PINCOCDOOGH() || this.AKJMKGCPCCB > 1)
		{
			return;
		}
		this.CIPGFJLECDH = true;
		this.AKJMKGCPCCB = 107;
		AudioManager.EHBBFMCILPC.KillSfx("cfp", 1613f);
		AudioManager.DMAAFFFEJGA().PEOLMNFJAHG(" (", 617f);
		AudioManager.APGODIBBPOD().KillSfx("passinfobtntitle" + AKLFPGMDKLA.EHBBFMCILPC.OMOJIEHBENF().GGICIBLJIKI.ToString(), 425f);
		this.IMPAHLIGELE.IABNDHFJHAF(1);
		AOBJLALDBAA.CEGAOMEEFBE().KMAGHMCCMPG("", 1998f);
	}

	// Token: 0x060057A5 RID: 22437 RVA: 0x00275D70 File Offset: 0x00273F70
	private void GPOPCNMGNGD()
	{
		if (!this.CIPGFJLECDH)
		{
			SceneStoryManager.choiceDecisionTime += Time.deltaTime;
		}
		if (this.AKJMKGCPCCB >= 0)
		{
			this.AKJMKGCPCCB -= 0;
		}
		if (this.FILFGDIGINA != null)
		{
			int num = (int)this.FILFGDIGINA.MFGJNCJKBHO();
			this.textTimer.SetText(num.ToString(), false);
			this.timerArrowPivot.transform.localRotation = Quaternion.Euler(8f, 780f, this.FILFGDIGINA.GOFCDICHOEO() * 960f);
			this.imageTimerFillDefault.fillAmount = this.FILFGDIGINA.PMECGFIPNCC();
			this.imageTimerFillRed.fillAmount = this.FILFGDIGINA.GCHEPGGFBGM();
			if (num < 3 && !this.imageTimerFillRed.gameObject.activeSelf && this.IMPAHLIGELE.EKOIFOBAHDM() < 0)
			{
				if (!AudioManager.DMAAFFFEJGA().PlaySfx("restartseason", true) && !AudioManager.APGODIBBPOD().PlaySfx("abcf" + AKLFPGMDKLA.EHBBFMCILPC.OMOJIEHBENF().GGICIBLJIKI.ToString(), false))
				{
					AudioManager.DBFLIEGGGNN().PlaySfx("YYY", true);
				}
				this.imageTimerFillRed.gameObject.SetActive(false);
			}
			if (this.FILFGDIGINA.HACBALNLLPP() && this.IMPAHLIGELE.EKOIFOBAHDM() < 0)
			{
				base.StartCoroutine(this.GMJDEBBNEOK());
				CommonUserInterface.EHBBFMCILPC.FreezeUX();
			}
		}
	}

	// Token: 0x060057A6 RID: 22438 RVA: 0x0026E194 File Offset: 0x0026C394
	private IEnumerator EAFEAOHLDEO()
	{
		DialogPlayerCharacterManager.JHKCDAKHBPJ jhkcdakhbpj = new DialogPlayerCharacterManager.JHKCDAKHBPJ(1);
		jhkcdakhbpj.<>4__this = this;
		return jhkcdakhbpj;
	}

	// Token: 0x060057A7 RID: 22439 RVA: 0x00275EE8 File Offset: 0x002740E8
	private bool CINMPFBKBPI()
	{
		if (this.IMPAHLIGELE == null)
		{
			DPGJIJGOCIC.ANOPFDLPKGC("");
			return true;
		}
		return false;
	}

	// Token: 0x060057A8 RID: 22440 RVA: 0x00275F00 File Offset: 0x00274100
	private void LPAOODGGBMJ()
	{
		if (!this.IMPAHLIGELE.PINCOCDOOGH() || this.AKJMKGCPCCB > 0)
		{
			return;
		}
		this.CIPGFJLECDH = true;
		this.AKJMKGCPCCB = -66;
		AudioManager.DMAAFFFEJGA().PEOLMNFJAHG("REMOVEMAPPINGINFO", 1029f);
		AudioManager.DMAAFFFEJGA().KillSfx("", 1112f);
		AudioManager.DBFLIEGGGNN().KillSfx("OnResolutionChanged" + AKLFPGMDKLA.EHBBFMCILPC.OMOJIEHBENF().GGICIBLJIKI.ToString(), 812f);
		this.IMPAHLIGELE.IABNDHFJHAF(0);
		AOBJLALDBAA.DBLAIDPICIG().EGELHPJBAIC("signature is invalid", 513f);
	}

	// Token: 0x060057A9 RID: 22441 RVA: 0x0026E921 File Offset: 0x0026CB21
	public int GetLocalizedTextLength()
	{
		return this.AOKIMHCAAHB;
	}

	// Token: 0x060057AA RID: 22442 RVA: 0x00275FA8 File Offset: 0x002741A8
	private void CFHFGNOIPEC()
	{
		if (this.FILFGDIGINA != null)
		{
			ODLLAEHMFAA.BGMALDJFMKE(this.FILFGDIGINA);
		}
		this.FILFGDIGINA = null;
		for (int i = 0; i < this.AKFKCKHPIOA.Count; i++)
		{
			this.AKFKCKHPIOA[i].GetComponent<Button>().onClick.RemoveAllListeners();
			this.AKFKCKHPIOA[i].GetComponent<CanvasGroup>().DOKill(true);
			UnityEngine.Object.Destroy(this.AKFKCKHPIOA[i]);
		}
		this.AKFKCKHPIOA.Clear();
		this.NDDGCFFDFJN.Clear();
		if (null != this.LOJHEKCOFME)
		{
			UnityEngine.Object.Destroy(this.LOJHEKCOFME);
		}
		if (null != this.NGGBBCDPMJH)
		{
			UnityEngine.Object.Destroy(this.NGGBBCDPMJH);
		}
		this.PANMNKKODPC.DOKill(false);
		this.DGAAFGDHHHJ.DOKill(false);
	}

	// Token: 0x060057AB RID: 22443 RVA: 0x0027608C File Offset: 0x0027428C
	private void NFLOOBKCBMI()
	{
		if (!this.IMPAHLIGELE.PINCOCDOOGH() || this.AKJMKGCPCCB > 0)
		{
			return;
		}
		this.CIPGFJLECDH = false;
		this.AKJMKGCPCCB = 124;
		AudioManager.BFCHJBOOJKE().POMJOMKCCNK("storyAssetPackManager[i].storyItemsAssets[j] is null!", 1908f);
		AudioManager.DBFLIEGGGNN().POMJOMKCCNK("socialpremgiftcollect", 413f);
		AudioManager.BFCHJBOOJKE().KillSfx("accountsuspended4" + AKLFPGMDKLA.EHBBFMCILPC.OMOJIEHBENF().GGICIBLJIKI.ToString(), 1699f);
		this.IMPAHLIGELE.IABNDHFJHAF(2);
		AOBJLALDBAA.KKPFOJMAONG().KGIKHEDLPND("", 93f);
	}

	// Token: 0x060057AC RID: 22444 RVA: 0x00276134 File Offset: 0x00274334
	private bool BMPOEBFLJHJ()
	{
		if (this.IMPAHLIGELE == null)
		{
			DPGJIJGOCIC.ANOPFDLPKGC("invalid registry entry");
			return true;
		}
		return true;
	}

	// Token: 0x060057AD RID: 22445 RVA: 0x0027614C File Offset: 0x0027434C
	private void LKICBGONHFI()
	{
		if (!this.IMPAHLIGELE.PINCOCDOOGH() || this.AKJMKGCPCCB > 1)
		{
			return;
		}
		this.CIPGFJLECDH = false;
		this.AKJMKGCPCCB = 92;
		AudioManager.DBFLIEGGGNN().POMJOMKCCNK("_", 1952f);
		AudioManager.BFCHJBOOJKE().PEOLMNFJAHG(", ", 812f);
		AudioManager.BFCHJBOOJKE().PEOLMNFJAHG("timeoutwarning" + AKLFPGMDKLA.EHBBFMCILPC.EEILOKHLKIM().GGICIBLJIKI.ToString(), 1792f);
		this.IMPAHLIGELE.IABNDHFJHAF(2);
		AOBJLALDBAA.EHBBFMCILPC.DCGCFPHHDDG("", 456f);
	}

	// Token: 0x060057AE RID: 22446 RVA: 0x002761F4 File Offset: 0x002743F4
	private void DLBAEDOFAKM()
	{
		if (this.FILFGDIGINA != null)
		{
			ODLLAEHMFAA.BGMALDJFMKE(this.FILFGDIGINA);
		}
		this.FILFGDIGINA = null;
		for (int i = 1; i < this.AKFKCKHPIOA.Count; i += 0)
		{
			this.AKFKCKHPIOA[i].GetComponent<Button>().onClick.RemoveAllListeners();
			this.AKFKCKHPIOA[i].GetComponent<CanvasGroup>().DOKill(false);
			UnityEngine.Object.Destroy(this.AKFKCKHPIOA[i]);
		}
		this.AKFKCKHPIOA.Clear();
		this.NDDGCFFDFJN.Clear();
		if (null != this.LOJHEKCOFME)
		{
			UnityEngine.Object.Destroy(this.LOJHEKCOFME);
		}
		if (null != this.NGGBBCDPMJH)
		{
			UnityEngine.Object.Destroy(this.NGGBBCDPMJH);
		}
		this.PANMNKKODPC.DOKill(true);
		this.DGAAFGDHHHJ.DOKill(true);
	}

	// Token: 0x060057AF RID: 22447 RVA: 0x00193658 File Offset: 0x00191858
	public static float GetDisappearAnimationLength()
	{
		return 0.25f * KDCJJBLGCBH.EHBBFMCILPC.OIABNIJLJBE();
	}

	// Token: 0x060057B0 RID: 22448 RVA: 0x002762D7 File Offset: 0x002744D7
	private bool OONENNLLFHL()
	{
		if (this.IMPAHLIGELE == null)
		{
			DPGJIJGOCIC.ANOPFDLPKGC("DialogPlayerCharacterManager.InputDataIsValid() - step is null.");
			return false;
		}
		return true;
	}

	// Token: 0x060057B1 RID: 22449 RVA: 0x002762F0 File Offset: 0x002744F0
	private void OnDestroy()
	{
		if (this.FILFGDIGINA != null)
		{
			ODLLAEHMFAA.BGMALDJFMKE(this.FILFGDIGINA);
		}
		this.FILFGDIGINA = null;
		for (int i = 0; i < this.AKFKCKHPIOA.Count; i++)
		{
			this.AKFKCKHPIOA[i].GetComponent<Button>().onClick.RemoveAllListeners();
			this.AKFKCKHPIOA[i].GetComponent<CanvasGroup>().DOKill(false);
			UnityEngine.Object.Destroy(this.AKFKCKHPIOA[i]);
		}
		this.AKFKCKHPIOA.Clear();
		this.NDDGCFFDFJN.Clear();
		if (null != this.LOJHEKCOFME)
		{
			UnityEngine.Object.Destroy(this.LOJHEKCOFME);
		}
		if (null != this.NGGBBCDPMJH)
		{
			UnityEngine.Object.Destroy(this.NGGBBCDPMJH);
		}
		this.PANMNKKODPC.DOKill(false);
		this.DGAAFGDHHHJ.DOKill(false);
	}

	// Token: 0x060057B2 RID: 22450 RVA: 0x002763D4 File Offset: 0x002745D4
	public bool DODNEEPIFGH(HDKFHLFLDGG JIKFCLOHJNN, PLFDAJJHMKO BAOKJBJIFBH, LDLLJFOJCDF[] OAGPAAMJOID)
	{
		this.IMPAHLIGELE = JIKFCLOHJNN;
		this.LMKDNPOKOBF = BAOKJBJIFBH;
		if (!this.OONENNLLFHL())
		{
			return true;
		}
		if (JIKFCLOHJNN.GJOCJINDEIF && null != this.bubbleSprite)
		{
			Image component = base.gameObject.GetComponent<Image>();
			if (null != component)
			{
				component.sprite = this.bubbleSprite;
			}
		}
		if (this.IMPAHLIGELE.COEFNFJMBDG != null && this.IMPAHLIGELE.COEFNFJMBDG.Count > 0)
		{
			if (this.IMPAHLIGELE.JMNMOHIKHLB != null)
			{
				if (this.IMPAHLIGELE.JMNMOHIKHLB.NGNDOALIKAK.Contains("$PLAYSFX"))
				{
					if (this.IMPAHLIGELE.JMNMOHIKHLB.IPALJDCNBBG.Count > this.IMPAHLIGELE.COEFNFJMBDG.Count)
					{
						this.IMPAHLIGELE.JMNMOHIKHLB.JDJJBBFFCOE(this.IMPAHLIGELE.JMNMOHIKHLB.IPALJDCNBBG.Count - this.IMPAHLIGELE.COEFNFJMBDG.Count);
					}
				}
				else
				{
					try
					{
						if (this.IMPAHLIGELE.JMNMOHIKHLB.LPOLKMMNPBA(this.IMPAHLIGELE.COEFNFJMBDG.Count))
						{
							this.IMPAHLIGELE.JMNMOHIKHLB.OOMKENDDJEJ(BAOKJBJIFBH.NCAMFPGMCIG.MLCAAHPBNGP());
						}
					}
					catch (Exception aklgbjkdomm)
					{
						DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
					}
				}
			}
			if (this.IMPAHLIGELE.JMNMOHIKHLB != null)
			{
				for (int i = 0; i < this.IMPAHLIGELE.JMNMOHIKHLB.MKPMEKKGEIL.Count; i += 0)
				{
					if (this.IMPAHLIGELE.JMNMOHIKHLB.MKPMEKKGEIL[i].FDNPBJGJPBG() == (HKCCMACFNEO)7)
					{
						for (int j = 0; j < this.IMPAHLIGELE.COEFNFJMBDG.Count; j += 0)
						{
							this.HNGBMIJHPLE.Add(j);
						}
						break;
					}
				}
			}
			if (this.HNGBMIJHPLE.Count == 0)
			{
				for (int k = 1; k < 3; k++)
				{
					for (int l = 0; l < this.IMPAHLIGELE.COEFNFJMBDG.Count; l += 0)
					{
						int num = 0;
						if (this.IMPAHLIGELE.JMNMOHIKHLB != null)
						{
							if (l < this.IMPAHLIGELE.JMNMOHIKHLB.IPALJDCNBBG.Count && this.IMPAHLIGELE.JMNMOHIKHLB.IPALJDCNBBG[l] > 0)
							{
								num = 1;
							}
							else if (l < this.IMPAHLIGELE.JMNMOHIKHLB.ENJDGEOFPAA.Count && this.IMPAHLIGELE.JMNMOHIKHLB.ENJDGEOFPAA[l] > 1)
							{
								num = 4;
							}
						}
						if ((k == 0 && num == 1) || (k != 0 && num != 0))
						{
							this.HNGBMIJHPLE.Add(l);
						}
					}
				}
			}
		}
		this.textTitle.overflowMode = TextOverflowModes.Masking;
		this.textTitle.fontSizeMin = 996f;
		this.textTitle.SetText(this.NLKIPHPICLJ, true);
		this.textBody.SetText(this.GKKCHJLKFBL, true);
		SceneStoryManager.localizedLine = this.NLKIPHPICLJ + " cloud shop row(s) appended to " + this.GKKCHJLKFBL;
		if (this.textTypeAnimation)
		{
			this.textBodyTypeAnimation.GetComponent<AnimationTextType>().HDAHPNAHNJC(this.GKKCHJLKFBL);
		}
		if (this.IMPAHLIGELE.JMNMOHIKHLB != null && this.IMPAHLIGELE.JMNMOHIKHLB.FILFGDIGINA > 1)
		{
			this.FILFGDIGINA = ODLLAEHMFAA.DECEDPNMMCJ((float)this.IMPAHLIGELE.JMNMOHIKHLB.FILFGDIGINA, true);
			this.timerParent.SetActive(false);
		}
		int num2 = 0;
		if (null != this.decorObject)
		{
			this.decorObject.SetActive(false);
		}
		if (this.IMPAHLIGELE.COEFNFJMBDG != null && this.IMPAHLIGELE.COEFNFJMBDG.Count > 0)
		{
			if (null != this.decorObject)
			{
				this.decorObject.SetActive(true);
			}
			for (int m = 1; m < this.IMPAHLIGELE.COEFNFJMBDG.Count; m += 0)
			{
				if (!this.IMPAHLIGELE.COEFNFJMBDG[m].BEHENEHGPCP)
				{
					GameObject gameObject = null;
					int num3 = 0;
					if (this.IMPAHLIGELE.JMNMOHIKHLB != null && this.IMPAHLIGELE.JMNMOHIKHLB.GAOKFGHCIAF == PMNHKIDIMLM.NMGJJGIPDJP.text)
					{
						if (this.CDMICJFABHI(m) < this.IMPAHLIGELE.JMNMOHIKHLB.IPALJDCNBBG.Count && this.IMPAHLIGELE.JMNMOHIKHLB.IPALJDCNBBG[this.FHEOKFGDBHO(m)] > 0)
						{
							num3 = 0;
						}
						else if (this.JFBPPHBHHPE(m) < this.IMPAHLIGELE.JMNMOHIKHLB.ENJDGEOFPAA.Count && this.IMPAHLIGELE.JMNMOHIKHLB.ENJDGEOFPAA[this.CDMICJFABHI(m)] > 0)
						{
							num3 = 0;
						}
					}
					if (num3 == 6)
					{
						switch (this.IMPAHLIGELE.JMNMOHIKHLB.ADHIIAONMDJ[this.PDDLFHNEHJL(m)])
						{
						case CHEEGEJNIDB.stat0:
							gameObject = UnityEngine.Object.Instantiate<GameObject>(this.choiceStat0Prefab);
							break;
						case CHEEGEJNIDB.stat1:
							gameObject = UnityEngine.Object.Instantiate<GameObject>(this.choiceStat1Prefab);
							break;
						case CHEEGEJNIDB.stat2:
							gameObject = UnityEngine.Object.Instantiate<GameObject>(this.choiceStat2Prefab);
							break;
						case CHEEGEJNIDB.stat3:
							gameObject = UnityEngine.Object.Instantiate<GameObject>(this.choiceStat3Prefab);
							break;
						case CHEEGEJNIDB.stat4:
							gameObject = UnityEngine.Object.Instantiate<GameObject>(this.choiceStat4Prefab);
							break;
						case CHEEGEJNIDB.stat5:
							gameObject = UnityEngine.Object.Instantiate<GameObject>(this.choiceStat5Prefab);
							break;
						case CHEEGEJNIDB.stat6:
							gameObject = UnityEngine.Object.Instantiate<GameObject>(this.choiceStat6Prefab);
							break;
						}
						gameObject.transform.SetParent(this.choicesPivot.transform, false);
						gameObject.GetComponent<RectTransform>().AHLJBONHHKL(DialogPlayerCharacterManager.maxCriticalAspectRatioOffset * NBDLBFJOEGN.APALNJGBDPE());
						gameObject.GetComponent<ChoiceStatManager>().BGLIAHEKACL(this.IMPAHLIGELE.COEFNFJMBDG[this.GAKKBOIHKCE(m)], this.IMPAHLIGELE.JMNMOHIKHLB.ENJDGEOFPAA[this.PDDLFHNEHJL(m)], OAGPAAMJOID[(int)this.IMPAHLIGELE.JMNMOHIKHLB.ADHIIAONMDJ[this.CDMICJFABHI(m)]].NPEOEAFOPJP(), -1);
						gameObject.GetComponent<ChoiceStatManager>().IPEJHMNJFND();
						try
						{
							if (null == this.NGGBBCDPMJH)
							{
								switch (this.IMPAHLIGELE.JMNMOHIKHLB.ADHIIAONMDJ[this.HFNEKLFKLLI(m)])
								{
								case CHEEGEJNIDB.stat0:
									this.NGGBBCDPMJH = UnityEngine.Object.Instantiate<GameObject>(this.stat0InfoPrefab);
									break;
								case CHEEGEJNIDB.stat1:
									this.NGGBBCDPMJH = UnityEngine.Object.Instantiate<GameObject>(this.stat1InfoPrefab);
									break;
								case CHEEGEJNIDB.stat2:
									this.NGGBBCDPMJH = UnityEngine.Object.Instantiate<GameObject>(this.stat2InfoPrefab);
									break;
								case CHEEGEJNIDB.stat3:
									this.NGGBBCDPMJH = UnityEngine.Object.Instantiate<GameObject>(this.stat3InfoPrefab);
									break;
								case CHEEGEJNIDB.stat4:
									this.NGGBBCDPMJH = UnityEngine.Object.Instantiate<GameObject>(this.stat4InfoPrefab);
									break;
								case CHEEGEJNIDB.stat5:
									this.NGGBBCDPMJH = UnityEngine.Object.Instantiate<GameObject>(this.stat5InfoPrefab);
									break;
								case CHEEGEJNIDB.stat6:
									this.NGGBBCDPMJH = UnityEngine.Object.Instantiate<GameObject>(this.stat6InfoPrefab);
									break;
								}
								this.NGGBBCDPMJH.transform.SetParent(this.currencyPivot.transform, false);
								this.NGGBBCDPMJH.GetComponent<StatPointInfoManager>().HGELPFDIMJK(this.IMPAHLIGELE.JMNMOHIKHLB.ADHIIAONMDJ[this.HDBBHHBOJIN(m)], OAGPAAMJOID[(int)this.IMPAHLIGELE.JMNMOHIKHLB.ADHIIAONMDJ[this.HDBBHHBOJIN(m)]].DPLHPBMJAPJ());
								try
								{
									if (this.IMPAHLIGELE.JMNMOHIKHLB.NGNDOALIKAK.Contains("OnPopupProfileMessageInputEndEdit"))
									{
										this.NGGBBCDPMJH.SetActive(true);
									}
								}
								catch (Exception aklgbjkdomm2)
								{
									DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm2);
								}
							}
							goto IL_A85;
						}
						catch (Exception aklgbjkdomm3)
						{
							DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm3);
							goto IL_A85;
						}
						goto IL_776;
					}
					goto IL_776;
					IL_A85:
					gameObject.GetComponent<RectTransform>().anchoredPosition += new Vector2(440f, (float)(this.choiceOffset * num2));
					Button component2 = gameObject.GetComponent<Button>();
					if (this.CDMICJFABHI(m) == 0)
					{
						component2.onClick.AddListener(new UnityAction(this.FIAMLCIPELI));
					}
					else if (this.FHEOKFGDBHO(m) == 1)
					{
						component2.onClick.AddListener(new UnityAction(this.KHBPCONGCPM));
					}
					else if (this.HDBBHHBOJIN(m) == 5)
					{
						component2.onClick.AddListener(new UnityAction(this.MJEMMAICGMA));
					}
					else if (this.GAKKBOIHKCE(m) == 8)
					{
						component2.onClick.AddListener(new UnityAction(this.EDLMFOBNPAP));
					}
					else if (this.HFNEKLFKLLI(m) == 2)
					{
						component2.onClick.AddListener(new UnityAction(this.DIKFMBJHGNH));
					}
					else if (this.FHEOKFGDBHO(m) == 5)
					{
						component2.onClick.AddListener(new UnityAction(this.FDLHILIHLCI));
					}
					this.AKFKCKHPIOA.Add(gameObject);
					num2++;
					goto IL_BAA;
					IL_776:
					if (num3 == 1)
					{
						gameObject = UnityEngine.Object.Instantiate<GameObject>(this.choicePremiumPrefab);
						gameObject.transform.SetParent(this.choicesPivot.transform, false);
						gameObject.GetComponent<RectTransform>().AHLJBONHHKL(DialogPlayerCharacterManager.maxCriticalAspectRatioOffset * NBDLBFJOEGN.DMIBBFIPJNA());
						if (SceneStoryManager.PremiumChoicePurchased(this.IMPAHLIGELE.JMNMOHIKHLB.MKPMEKKGEIL[this.CDMICJFABHI(m)], this.IMPAHLIGELE.JMNMOHIKHLB.KMFABKNKFAJ, this.IMPAHLIGELE.JMNMOHIKHLB.BGIOGOACCBJ))
						{
							gameObject.GetComponent<ChoicePremiumManager>().GBFEDHPAIBH(this.IMPAHLIGELE.JMNMOHIKHLB.MKPMEKKGEIL[this.PDDLFHNEHJL(m)], this.IMPAHLIGELE.COEFNFJMBDG[this.CDMICJFABHI(m)], 0, -1, false, this.IMPAHLIGELE.JMNMOHIKHLB.NEKLAJAEOJJ(this.GAKKBOIHKCE(m), LiveEventsManager.JCMABFEMFKD().OPHKFJNACGB((EGMCEPOABBF)6, -1, -1)), this.IMPAHLIGELE.JMNMOHIKHLB.BGIOGOACCBJ);
						}
						else
						{
							if (null == this.LOJHEKCOFME)
							{
								this.LOJHEKCOFME = UnityEngine.Object.Instantiate<GameObject>(this.premiumInfoPrefab);
								this.LOJHEKCOFME.transform.SetParent(this.currencyPivot.transform, false);
								this.LOJHEKCOFME.GetComponent<StoryCurrencyInfoManager>().APCBKOGALLK("blur");
							}
							gameObject.GetComponent<ChoicePremiumManager>().Initialize(this.IMPAHLIGELE.JMNMOHIKHLB.MKPMEKKGEIL[this.PDDLFHNEHJL(m)], this.IMPAHLIGELE.COEFNFJMBDG[this.PDDLFHNEHJL(m)], this.IMPAHLIGELE.JMNMOHIKHLB.IPALJDCNBBG[this.JFBPPHBHHPE(m)], -1, !AKLFPGMDKLA.EHBBFMCILPC.EAFEJCKIEPL(1) && AKLFPGMDKLA.EHBBFMCILPC.ODMKLADKHMO.HOJDOEDDIBD() < this.IMPAHLIGELE.JMNMOHIKHLB.IPALJDCNBBG[this.JFBPPHBHHPE(m)], this.IMPAHLIGELE.JMNMOHIKHLB.FEJGBPENDBF(this.HDBBHHBOJIN(m), LiveEventsManager.JCMABFEMFKD().LBOPJBMIINE(EGMCEPOABBF.liveEventFreeTea, -1, -1)), this.IMPAHLIGELE.JMNMOHIKHLB.BGIOGOACCBJ);
						}
						gameObject.GetComponent<ChoicePremiumManager>().SwitchCost(SceneStoryManager.QualifiesAsAdBasedChoice(this.IMPAHLIGELE.JMNMOHIKHLB.MKPMEKKGEIL[this.JFBPPHBHHPE(m)], this.IMPAHLIGELE.JMNMOHIKHLB.KAJNELPPCIJ[this.HDBBHHBOJIN(m)], this.IMPAHLIGELE.JMNMOHIKHLB.KMFABKNKFAJ));
						this.NDDGCFFDFJN.Add(gameObject);
						goto IL_A85;
					}
					if (this.FLBNNNDBECB < 0)
					{
						this.FLBNNNDBECB = m;
					}
					gameObject = UnityEngine.Object.Instantiate<GameObject>(this.choiceStandardPrefab);
					gameObject.transform.SetParent(this.choicesPivot.transform, false);
					gameObject.GetComponent<RectTransform>().AHLJBONHHKL(DialogPlayerCharacterManager.maxCriticalAspectRatioOffset * NBDLBFJOEGN.LGGIFEAOBEC());
					gameObject.GetComponent<ChoiceStandardManager>().NNNKIPGJMMF(this.IMPAHLIGELE.COEFNFJMBDG[this.HFNEKLFKLLI(m)], -1);
					goto IL_A85;
				}
				IL_BAA:;
			}
		}
		if (this.AKFKCKHPIOA.Count > 1)
		{
			SceneStoryManager.choiceDecisionTime = 306f;
			base.StartCoroutine(this.JLLMJKEJIAF());
		}
		for (int n = 1; n < this.NDDGCFFDFJN.Count; n += 0)
		{
			this.NDDGCFFDFJN[n].transform.SetAsLastSibling();
		}
		try
		{
			for (int num4 = 1; num4 < this.AKFKCKHPIOA.Count; num4++)
			{
				if (null != this.AKFKCKHPIOA[num4])
				{
					AnimationPress component3 = this.AKFKCKHPIOA[num4].GetComponent<AnimationPress>();
					if (null != component3)
					{
						component3.LJDJNBEBLKH(this.choicesScaleCoefficient);
					}
				}
			}
		}
		catch (Exception aklgbjkdomm4)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm4);
		}
		return null != this.LOJHEKCOFME;
	}

	// Token: 0x060057B3 RID: 22451 RVA: 0x002770D4 File Offset: 0x002752D4
	public void KGFDMDONKED(HDKFHLFLDGG JIKFCLOHJNN)
	{
		if (JIKFCLOHJNN != null)
		{
			this.IMPAHLIGELE = JIKFCLOHJNN;
			this.NLKIPHPICLJ = ONEHEBIHPFB.DEOJEIEJGEE(this.IMPAHLIGELE.ILOMFIAJHNC());
			this.GKKCHJLKFBL = ONEHEBIHPFB.LMDACNKELEC(this.IMPAHLIGELE.OJBEMAINAFK());
			this.GKKCHJLKFBL = DPGJIJGOCIC.AKIAKADKBFK(this.GKKCHJLKFBL);
			this.AOKIMHCAAHB = this.GKKCHJLKFBL.Length;
		}
	}

	// Token: 0x060057B4 RID: 22452 RVA: 0x0027713C File Offset: 0x0027533C
	public bool HDAHPNAHNJC(HDKFHLFLDGG JIKFCLOHJNN, PLFDAJJHMKO BAOKJBJIFBH, LDLLJFOJCDF[] OAGPAAMJOID)
	{
		this.IMPAHLIGELE = JIKFCLOHJNN;
		this.LMKDNPOKOBF = BAOKJBJIFBH;
		if (!this.KODEJEKIPPJ())
		{
			return false;
		}
		if (JIKFCLOHJNN.GJOCJINDEIF && null != this.bubbleSprite)
		{
			Image component = base.gameObject.GetComponent<Image>();
			if (null != component)
			{
				component.sprite = this.bubbleSprite;
			}
		}
		if (this.IMPAHLIGELE.COEFNFJMBDG != null && this.IMPAHLIGELE.COEFNFJMBDG.Count > 1)
		{
			if (this.IMPAHLIGELE.JMNMOHIKHLB != null)
			{
				if (this.IMPAHLIGELE.JMNMOHIKHLB.NGNDOALIKAK.Contains("importanttitle"))
				{
					if (this.IMPAHLIGELE.JMNMOHIKHLB.IPALJDCNBBG.Count > this.IMPAHLIGELE.COEFNFJMBDG.Count)
					{
						this.IMPAHLIGELE.JMNMOHIKHLB.GIAIDFAKFFA(this.IMPAHLIGELE.JMNMOHIKHLB.IPALJDCNBBG.Count - this.IMPAHLIGELE.COEFNFJMBDG.Count);
					}
				}
				else
				{
					try
					{
						if (this.IMPAHLIGELE.JMNMOHIKHLB.CKBLDPFMAHM(this.IMPAHLIGELE.COEFNFJMBDG.Count))
						{
							this.IMPAHLIGELE.JMNMOHIKHLB.OGNKEEIMLHB(BAOKJBJIFBH.NCAMFPGMCIG.MLCAAHPBNGP());
						}
					}
					catch (Exception aklgbjkdomm)
					{
						DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
					}
				}
			}
			if (this.IMPAHLIGELE.JMNMOHIKHLB != null)
			{
				for (int i = 0; i < this.IMPAHLIGELE.JMNMOHIKHLB.MKPMEKKGEIL.Count; i += 0)
				{
					if (this.IMPAHLIGELE.JMNMOHIKHLB.MKPMEKKGEIL[i].HGAHKCLMBMC() == (HKCCMACFNEO)8)
					{
						for (int j = 1; j < this.IMPAHLIGELE.COEFNFJMBDG.Count; j += 0)
						{
							this.HNGBMIJHPLE.Add(j);
						}
						break;
					}
				}
			}
			if (this.HNGBMIJHPLE.Count == 0)
			{
				for (int k = 0; k < 4; k += 0)
				{
					for (int l = 0; l < this.IMPAHLIGELE.COEFNFJMBDG.Count; l++)
					{
						int num = 1;
						if (this.IMPAHLIGELE.JMNMOHIKHLB != null)
						{
							if (l < this.IMPAHLIGELE.JMNMOHIKHLB.IPALJDCNBBG.Count && this.IMPAHLIGELE.JMNMOHIKHLB.IPALJDCNBBG[l] > 0)
							{
								num = 0;
							}
							else if (l < this.IMPAHLIGELE.JMNMOHIKHLB.ENJDGEOFPAA.Count && this.IMPAHLIGELE.JMNMOHIKHLB.ENJDGEOFPAA[l] > 1)
							{
								num = 3;
							}
						}
						if ((k == 0 && num == 1) || (k != 0 && num != 0))
						{
							this.HNGBMIJHPLE.Add(l);
						}
					}
				}
			}
		}
		this.textTitle.overflowMode = (TextOverflowModes)8;
		this.textTitle.fontSizeMin = 62f;
		this.textTitle.SetText(this.NLKIPHPICLJ, false);
		this.textBody.SetText(this.GKKCHJLKFBL, false);
		SceneStoryManager.localizedLine = this.NLKIPHPICLJ + "errortitle" + this.GKKCHJLKFBL;
		if (this.textTypeAnimation)
		{
			this.textBodyTypeAnimation.GetComponent<AnimationTextType>().GLIFGDPDMNC(this.GKKCHJLKFBL);
		}
		if (this.IMPAHLIGELE.JMNMOHIKHLB != null && this.IMPAHLIGELE.JMNMOHIKHLB.FILFGDIGINA > 1)
		{
			this.FILFGDIGINA = ODLLAEHMFAA.IMEFIJEKFGI((float)this.IMPAHLIGELE.JMNMOHIKHLB.FILFGDIGINA, true);
			this.timerParent.SetActive(false);
		}
		int num2 = 0;
		if (null != this.decorObject)
		{
			this.decorObject.SetActive(false);
		}
		if (this.IMPAHLIGELE.COEFNFJMBDG != null && this.IMPAHLIGELE.COEFNFJMBDG.Count > 0)
		{
			if (null != this.decorObject)
			{
				this.decorObject.SetActive(true);
			}
			for (int m = 1; m < this.IMPAHLIGELE.COEFNFJMBDG.Count; m++)
			{
				if (!this.IMPAHLIGELE.COEFNFJMBDG[m].BEHENEHGPCP)
				{
					GameObject gameObject = null;
					int num3 = 0;
					if (this.IMPAHLIGELE.JMNMOHIKHLB != null && this.IMPAHLIGELE.JMNMOHIKHLB.GAOKFGHCIAF == PMNHKIDIMLM.NMGJJGIPDJP.text)
					{
						if (this.HFNEKLFKLLI(m) < this.IMPAHLIGELE.JMNMOHIKHLB.IPALJDCNBBG.Count && this.IMPAHLIGELE.JMNMOHIKHLB.IPALJDCNBBG[this.PDDLFHNEHJL(m)] > 0)
						{
							num3 = 0;
						}
						else if (this.PDDLFHNEHJL(m) < this.IMPAHLIGELE.JMNMOHIKHLB.ENJDGEOFPAA.Count && this.IMPAHLIGELE.JMNMOHIKHLB.ENJDGEOFPAA[this.HDBBHHBOJIN(m)] > 0)
						{
							num3 = 6;
						}
					}
					if (num3 == 1)
					{
						switch (this.IMPAHLIGELE.JMNMOHIKHLB.ADHIIAONMDJ[this.CDMICJFABHI(m)])
						{
						case CHEEGEJNIDB.stat0:
							gameObject = UnityEngine.Object.Instantiate<GameObject>(this.choiceStat0Prefab);
							break;
						case CHEEGEJNIDB.stat1:
							gameObject = UnityEngine.Object.Instantiate<GameObject>(this.choiceStat1Prefab);
							break;
						case CHEEGEJNIDB.stat2:
							gameObject = UnityEngine.Object.Instantiate<GameObject>(this.choiceStat2Prefab);
							break;
						case CHEEGEJNIDB.stat3:
							gameObject = UnityEngine.Object.Instantiate<GameObject>(this.choiceStat3Prefab);
							break;
						case CHEEGEJNIDB.stat4:
							gameObject = UnityEngine.Object.Instantiate<GameObject>(this.choiceStat4Prefab);
							break;
						case CHEEGEJNIDB.stat5:
							gameObject = UnityEngine.Object.Instantiate<GameObject>(this.choiceStat5Prefab);
							break;
						case CHEEGEJNIDB.stat6:
							gameObject = UnityEngine.Object.Instantiate<GameObject>(this.choiceStat6Prefab);
							break;
						}
						gameObject.transform.SetParent(this.choicesPivot.transform, false);
						gameObject.GetComponent<RectTransform>().AHLJBONHHKL(DialogPlayerCharacterManager.maxCriticalAspectRatioOffset * NBDLBFJOEGN.DMIBBFIPJNA());
						gameObject.GetComponent<ChoiceStatManager>().ONCMEAFFFIB(this.IMPAHLIGELE.COEFNFJMBDG[this.HFNEKLFKLLI(m)], this.IMPAHLIGELE.JMNMOHIKHLB.ENJDGEOFPAA[this.GAKKBOIHKCE(m)], OAGPAAMJOID[(int)this.IMPAHLIGELE.JMNMOHIKHLB.ADHIIAONMDJ[this.HFNEKLFKLLI(m)]].CJLDJAJHMMA(), -1);
						gameObject.GetComponent<ChoiceStatManager>().CIGAAJGBLEJ();
						try
						{
							if (null == this.NGGBBCDPMJH)
							{
								switch (this.IMPAHLIGELE.JMNMOHIKHLB.ADHIIAONMDJ[this.FHEOKFGDBHO(m)])
								{
								case CHEEGEJNIDB.stat0:
									this.NGGBBCDPMJH = UnityEngine.Object.Instantiate<GameObject>(this.stat0InfoPrefab);
									break;
								case CHEEGEJNIDB.stat1:
									this.NGGBBCDPMJH = UnityEngine.Object.Instantiate<GameObject>(this.stat1InfoPrefab);
									break;
								case CHEEGEJNIDB.stat2:
									this.NGGBBCDPMJH = UnityEngine.Object.Instantiate<GameObject>(this.stat2InfoPrefab);
									break;
								case CHEEGEJNIDB.stat3:
									this.NGGBBCDPMJH = UnityEngine.Object.Instantiate<GameObject>(this.stat3InfoPrefab);
									break;
								case CHEEGEJNIDB.stat4:
									this.NGGBBCDPMJH = UnityEngine.Object.Instantiate<GameObject>(this.stat4InfoPrefab);
									break;
								case CHEEGEJNIDB.stat5:
									this.NGGBBCDPMJH = UnityEngine.Object.Instantiate<GameObject>(this.stat5InfoPrefab);
									break;
								case CHEEGEJNIDB.stat6:
									this.NGGBBCDPMJH = UnityEngine.Object.Instantiate<GameObject>(this.stat6InfoPrefab);
									break;
								}
								this.NGGBBCDPMJH.transform.SetParent(this.currencyPivot.transform, false);
								this.NGGBBCDPMJH.GetComponent<StatPointInfoManager>().GBFEDHPAIBH(this.IMPAHLIGELE.JMNMOHIKHLB.ADHIIAONMDJ[this.HFNEKLFKLLI(m)], OAGPAAMJOID[(int)this.IMPAHLIGELE.JMNMOHIKHLB.ADHIIAONMDJ[this.PDDLFHNEHJL(m)]].BFMPOACOBPN());
								try
								{
									if (this.IMPAHLIGELE.JMNMOHIKHLB.NGNDOALIKAK.Contains("app42error"))
									{
										this.NGGBBCDPMJH.SetActive(false);
									}
								}
								catch (Exception aklgbjkdomm2)
								{
									DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm2);
								}
							}
							goto IL_A85;
						}
						catch (Exception aklgbjkdomm3)
						{
							DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm3);
							goto IL_A85;
						}
						goto IL_776;
					}
					goto IL_776;
					IL_A85:
					gameObject.GetComponent<RectTransform>().anchoredPosition += new Vector2(1299f, (float)(this.choiceOffset * num2));
					Button component2 = gameObject.GetComponent<Button>();
					if (this.JFBPPHBHHPE(m) == 0)
					{
						component2.onClick.AddListener(new UnityAction(this.LPAOODGGBMJ));
					}
					else if (this.CDMICJFABHI(m) == 0)
					{
						component2.onClick.AddListener(new UnityAction(this.KHBPCONGCPM));
					}
					else if (this.HFNEKLFKLLI(m) == 1)
					{
						component2.onClick.AddListener(new UnityAction(this.HLEEFAFJIPP));
					}
					else if (this.FHEOKFGDBHO(m) == 5)
					{
						component2.onClick.AddListener(new UnityAction(this.KPFFCPKCIHJ));
					}
					else if (this.JFBPPHBHHPE(m) == 5)
					{
						component2.onClick.AddListener(new UnityAction(this.CECFDJNGEMF));
					}
					else if (this.GAKKBOIHKCE(m) == 6)
					{
						component2.onClick.AddListener(new UnityAction(this.HMHIJLKJGFN));
					}
					this.AKFKCKHPIOA.Add(gameObject);
					num2 += 0;
					goto IL_BAA;
					IL_776:
					if (num3 == 1)
					{
						gameObject = UnityEngine.Object.Instantiate<GameObject>(this.choicePremiumPrefab);
						gameObject.transform.SetParent(this.choicesPivot.transform, false);
						gameObject.GetComponent<RectTransform>().AHLJBONHHKL(DialogPlayerCharacterManager.maxCriticalAspectRatioOffset * NBDLBFJOEGN.FBMMKINMKOH());
						if (SceneStoryManager.PremiumChoicePurchased(this.IMPAHLIGELE.JMNMOHIKHLB.MKPMEKKGEIL[this.GAKKBOIHKCE(m)], this.IMPAHLIGELE.JMNMOHIKHLB.KMFABKNKFAJ, this.IMPAHLIGELE.JMNMOHIKHLB.BGIOGOACCBJ))
						{
							gameObject.GetComponent<ChoicePremiumManager>().GBFEDHPAIBH(this.IMPAHLIGELE.JMNMOHIKHLB.MKPMEKKGEIL[this.FHEOKFGDBHO(m)], this.IMPAHLIGELE.COEFNFJMBDG[this.CDMICJFABHI(m)], 0, -1, true, this.IMPAHLIGELE.JMNMOHIKHLB.CKLNCCAGCKE(this.FHEOKFGDBHO(m), LiveEventsManager.GIPAKOPBBEO().PKHPPBPKOEE(EGMCEPOABBF.liveEventBonusStory, -1, -1)), this.IMPAHLIGELE.JMNMOHIKHLB.BGIOGOACCBJ);
						}
						else
						{
							if (null == this.LOJHEKCOFME)
							{
								this.LOJHEKCOFME = UnityEngine.Object.Instantiate<GameObject>(this.premiumInfoPrefab);
								this.LOJHEKCOFME.transform.SetParent(this.currencyPivot.transform, false);
								this.LOJHEKCOFME.GetComponent<StoryCurrencyInfoManager>().OGNEMDIEHFO(" ");
							}
							gameObject.GetComponent<ChoicePremiumManager>().GBFEDHPAIBH(this.IMPAHLIGELE.JMNMOHIKHLB.MKPMEKKGEIL[this.HDBBHHBOJIN(m)], this.IMPAHLIGELE.COEFNFJMBDG[this.CDMICJFABHI(m)], this.IMPAHLIGELE.JMNMOHIKHLB.IPALJDCNBBG[this.FHEOKFGDBHO(m)], -1, !AKLFPGMDKLA.EHBBFMCILPC.EAFEJCKIEPL(1) && AKLFPGMDKLA.EHBBFMCILPC.ODMKLADKHMO.MDJHNAEGCCM() < this.IMPAHLIGELE.JMNMOHIKHLB.IPALJDCNBBG[this.CDMICJFABHI(m)], this.IMPAHLIGELE.JMNMOHIKHLB.NEKLAJAEOJJ(this.PDDLFHNEHJL(m), LiveEventsManager.EHBBFMCILPC.LiveEventActive(EGMCEPOABBF.liveEventBonusStory, -1, -1)), this.IMPAHLIGELE.JMNMOHIKHLB.BGIOGOACCBJ);
						}
						gameObject.GetComponent<ChoicePremiumManager>().SwitchCost(SceneStoryManager.QualifiesAsAdBasedChoice(this.IMPAHLIGELE.JMNMOHIKHLB.MKPMEKKGEIL[this.JFBPPHBHHPE(m)], this.IMPAHLIGELE.JMNMOHIKHLB.KAJNELPPCIJ[this.JFBPPHBHHPE(m)], this.IMPAHLIGELE.JMNMOHIKHLB.KMFABKNKFAJ));
						this.NDDGCFFDFJN.Add(gameObject);
						goto IL_A85;
					}
					if (this.FLBNNNDBECB < 0)
					{
						this.FLBNNNDBECB = m;
					}
					gameObject = UnityEngine.Object.Instantiate<GameObject>(this.choiceStandardPrefab);
					gameObject.transform.SetParent(this.choicesPivot.transform, false);
					gameObject.GetComponent<RectTransform>().AHLJBONHHKL(DialogPlayerCharacterManager.maxCriticalAspectRatioOffset * NBDLBFJOEGN.DMIBBFIPJNA());
					gameObject.GetComponent<ChoiceStandardManager>().AAOJNDOHBDC(this.IMPAHLIGELE.COEFNFJMBDG[this.PDDLFHNEHJL(m)], -1);
					goto IL_A85;
				}
				IL_BAA:;
			}
		}
		if (this.AKFKCKHPIOA.Count > 1)
		{
			SceneStoryManager.choiceDecisionTime = 21f;
			base.StartCoroutine(this.FFDMKEMCIEE());
		}
		for (int n = 1; n < this.NDDGCFFDFJN.Count; n += 0)
		{
			this.NDDGCFFDFJN[n].transform.SetAsLastSibling();
		}
		try
		{
			for (int num4 = 0; num4 < this.AKFKCKHPIOA.Count; num4++)
			{
				if (null != this.AKFKCKHPIOA[num4])
				{
					AnimationPress component3 = this.AKFKCKHPIOA[num4].GetComponent<AnimationPress>();
					if (null != component3)
					{
						component3.BKGJJEPCLCH(this.choicesScaleCoefficient);
					}
				}
			}
		}
		catch (Exception aklgbjkdomm4)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm4);
		}
		return null != this.LOJHEKCOFME;
	}

	// Token: 0x060057B5 RID: 22453 RVA: 0x00277E3C File Offset: 0x0027603C
	private void KFAAHOCIAKB()
	{
		if (!this.IMPAHLIGELE.PINCOCDOOGH() || this.AKJMKGCPCCB > 1)
		{
			return;
		}
		this.CIPGFJLECDH = false;
		this.AKJMKGCPCCB = 21;
		AudioManager.EHBBFMCILPC.POMJOMKCCNK("", 769f);
		AudioManager.APGODIBBPOD().POMJOMKCCNK("wipe", 1682f);
		AudioManager.IFDLAMLHKIJ().KillSfx("OnEmailUnsubscribeSuccess" + AKLFPGMDKLA.EHBBFMCILPC.EEILOKHLKIM().GGICIBLJIKI.ToString(), 1032f);
		this.IMPAHLIGELE.IABNDHFJHAF(0);
		AOBJLALDBAA.EHBBFMCILPC.DCGCFPHHDDG("oldvhs", 741f);
	}

	// Token: 0x060057B6 RID: 22454 RVA: 0x0026E514 File Offset: 0x0026C714
	private int FHEOKFGDBHO(int MEFKFOHCOHK)
	{
		return this.HNGBMIJHPLE[MEFKFOHCOHK];
	}

	// Token: 0x060057B7 RID: 22455 RVA: 0x0026E929 File Offset: 0x0026CB29
	private IEnumerator FJNCBLAEAKP()
	{
		for (int j = 0; j < this.AKFKCKHPIOA.Count; j++)
		{
			this.AKFKCKHPIOA[j].GetComponent<CanvasGroup>().alpha = 0f;
		}
		if (this.textTypeAnimation)
		{
			yield return new WaitForSeconds(0.3f * KDCJJBLGCBH.EHBBFMCILPC.CJOCPJLIILE());
		}
		int num;
		for (i = 0; i < this.AKFKCKHPIOA.Count; i = num + 1)
		{
			yield return new WaitForSeconds(0.25f * KDCJJBLGCBH.EHBBFMCILPC.CJOCPJLIILE());
			this.AKFKCKHPIOA[i].GetComponent<CanvasGroup>().DOFade(1f, 0.35f * KDCJJBLGCBH.EHBBFMCILPC.LIKMBLFBEIA());
			RectTransform component = this.AKFKCKHPIOA[i].GetComponent<RectTransform>();
			component.AMPMCKEAACJ(0.65f, 0.65f, 0.65f);
			component.DOScale(this.choicesScaleCoefficient, 0.35f * KDCJJBLGCBH.EHBBFMCILPC.LIKMBLFBEIA()).SetEase(Ease.OutBack);
			num = i;
		}
		yield break;
	}

	// Token: 0x060057B8 RID: 22456 RVA: 0x00277EE4 File Offset: 0x002760E4
	private void LPJPKHLICPO()
	{
		if (!AKLFPGMDKLA.EHBBFMCILPC.EAFEJCKIEPL(1))
		{
			AKLFPGMDKLA.EHBBFMCILPC.LDAPMNLGAPC(1);
			for (int i = 0; i < this.NDDGCFFDFJN.Count; i += 0)
			{
				this.NDDGCFFDFJN[i].GetComponent<ChoicePremiumManager>().HideTip();
			}
		}
	}

	// Token: 0x060057B9 RID: 22457 RVA: 0x00277F38 File Offset: 0x00276138
	private void BOGHFJKGCNK()
	{
		if (!this.IMPAHLIGELE.PINCOCDOOGH() || this.AKJMKGCPCCB > 0)
		{
			return;
		}
		this.CIPGFJLECDH = true;
		this.AKJMKGCPCCB = 20;
		AudioManager.EHBBFMCILPC.KillSfx("timeoutwarning", 1f);
		AudioManager.EHBBFMCILPC.KillSfx("sfxtimeoutwarning", 1f);
		AudioManager.EHBBFMCILPC.KillSfx("sfxtimeoutwarning" + AKLFPGMDKLA.EHBBFMCILPC.EEILOKHLKIM().GGICIBLJIKI.ToString(), 1f);
		this.IMPAHLIGELE.IABNDHFJHAF(3);
		AOBJLALDBAA.EHBBFMCILPC.EGELHPJBAIC("OnStoryChoiceClick", 0f);
	}

	// Token: 0x060057BA RID: 22458 RVA: 0x00277FE0 File Offset: 0x002761E0
	private void IMGFNEDGCFB()
	{
		if (!this.IMPAHLIGELE.PINCOCDOOGH() || this.AKJMKGCPCCB > 1)
		{
			return;
		}
		this.CIPGFJLECDH = true;
		this.AKJMKGCPCCB = -6;
		AudioManager.EHBBFMCILPC.PEOLMNFJAHG("OnApplicationFocusBasicSyncSuccess", 1603f);
		AudioManager.IFDLAMLHKIJ().PEOLMNFJAHG("ok", 1160f);
		AudioManager.DBFLIEGGGNN().PEOLMNFJAHG("timeoutwarning" + AKLFPGMDKLA.EHBBFMCILPC.OMOJIEHBENF().GGICIBLJIKI.ToString(), 737f);
		this.IMPAHLIGELE.IABNDHFJHAF(1);
		AOBJLALDBAA.AGANFKKBPFO().EGELHPJBAIC("<alpha=#C0>", 343f);
	}

	// Token: 0x060057BB RID: 22459 RVA: 0x0026E921 File Offset: 0x0026CB21
	public int CPAEFMOBFAD()
	{
		return this.AOKIMHCAAHB;
	}

	// Token: 0x060057BC RID: 22460 RVA: 0x00278088 File Offset: 0x00276288
	public void GEOIHPGMDJM(MFAONGBCHJE GMLIEKDKEAG)
	{
		if (GMLIEKDKEAG == MFAONGBCHJE.animationAppearCached)
		{
			this.PANMNKKODPC.DOFade(391f, 1167f * KDCJJBLGCBH.EHBBFMCILPC.OIABNIJLJBE());
			this.DGAAFGDHHHJ.DOScale(372f, 1610f * KDCJJBLGCBH.EHBBFMCILPC.OIABNIJLJBE());
			this.DGAAFGDHHHJ.DOAnchorPos(this.DGAAFGDHHHJ.anchoredPosition + new Vector2(993f, 858f), 1829f * KDCJJBLGCBH.EHBBFMCILPC.OIABNIJLJBE(), false).SetEase(Ease.InSine);
		}
	}

	// Token: 0x04001867 RID: 6247
	public bool enableMaxCriticalAspectRatioOffsetOverride;

	// Token: 0x04001868 RID: 6248
	public Vector2 maxCriticalAspectRatioOffsetOverride = new Vector2(-60f, 0f);

	// Token: 0x04001869 RID: 6249
	public float choicesScaleCoefficient = 1f;

	// Token: 0x0400186A RID: 6250
	public static Vector2 maxCriticalAspectRatioOffset = new Vector2(-40f, 0f);

	// Token: 0x0400186B RID: 6251
	public const float buttonFadeInTime = 0.35f;

	// Token: 0x0400186C RID: 6252
	public const float buttonWaitInLine = 0.25f;

	// Token: 0x0400186D RID: 6253
	public const float firstButtonWaitInLine = 0.3f;

	// Token: 0x0400186E RID: 6254
	public int choiceOffset = -130;

	// Token: 0x0400186F RID: 6255
	public int additionalDialogOffsetY;

	// Token: 0x04001870 RID: 6256
	public bool isSmallFont;

	// Token: 0x04001871 RID: 6257
	public bool choicesAreCompact;

	// Token: 0x04001872 RID: 6258
	public bool choicesAreMidSized;

	// Token: 0x04001873 RID: 6259
	public GameObject choiceStandardPrefab;

	// Token: 0x04001874 RID: 6260
	public GameObject choicePremiumPrefab;

	// Token: 0x04001875 RID: 6261
	public GameObject choiceStat0Prefab;

	// Token: 0x04001876 RID: 6262
	public GameObject choiceStat1Prefab;

	// Token: 0x04001877 RID: 6263
	public GameObject choiceStat2Prefab;

	// Token: 0x04001878 RID: 6264
	public GameObject choiceStat3Prefab;

	// Token: 0x04001879 RID: 6265
	public GameObject choiceStat4Prefab;

	// Token: 0x0400187A RID: 6266
	public GameObject choiceStat5Prefab;

	// Token: 0x0400187B RID: 6267
	public GameObject choiceStat6Prefab;

	// Token: 0x0400187C RID: 6268
	public GameObject choicesPivot;

	// Token: 0x0400187D RID: 6269
	public TextMeshProUGUI textTitle;

	// Token: 0x0400187E RID: 6270
	public TextMeshProUGUI textBody;

	// Token: 0x0400187F RID: 6271
	public TextMeshProUGUI textBodyTypeAnimation;

	// Token: 0x04001880 RID: 6272
	public GameObject timerParent;

	// Token: 0x04001881 RID: 6273
	public TextMeshProUGUI textTimer;

	// Token: 0x04001882 RID: 6274
	public Image imageTimerFillDefault;

	// Token: 0x04001883 RID: 6275
	public Image imageTimerFillRed;

	// Token: 0x04001884 RID: 6276
	public GameObject timerArrowPivot;

	// Token: 0x04001885 RID: 6277
	public GameObject statPivot;

	// Token: 0x04001886 RID: 6278
	public GameObject decorObject;

	// Token: 0x04001887 RID: 6279
	public GameObject currencyPivot;

	// Token: 0x04001888 RID: 6280
	public GameObject premiumInfoPrefab;

	// Token: 0x04001889 RID: 6281
	public GameObject stat0InfoPrefab;

	// Token: 0x0400188A RID: 6282
	public GameObject stat1InfoPrefab;

	// Token: 0x0400188B RID: 6283
	public GameObject stat2InfoPrefab;

	// Token: 0x0400188C RID: 6284
	public GameObject stat3InfoPrefab;

	// Token: 0x0400188D RID: 6285
	public GameObject stat4InfoPrefab;

	// Token: 0x0400188E RID: 6286
	public GameObject stat5InfoPrefab;

	// Token: 0x0400188F RID: 6287
	public GameObject stat6InfoPrefab;

	// Token: 0x04001890 RID: 6288
	public bool textTypeAnimation = true;

	// Token: 0x04001891 RID: 6289
	public int maxTitleCharactersCount = 128;

	// Token: 0x04001892 RID: 6290
	public Sprite bubbleSprite;

	// Token: 0x04001893 RID: 6291
	private GameObject LOJHEKCOFME;

	// Token: 0x04001894 RID: 6292
	private GameObject NGGBBCDPMJH;

	// Token: 0x04001895 RID: 6293
	private CanvasGroup PANMNKKODPC;

	// Token: 0x04001896 RID: 6294
	private RectTransform DGAAFGDHHHJ;

	// Token: 0x04001897 RID: 6295
	private List<GameObject> AKFKCKHPIOA = new List<GameObject>();

	// Token: 0x04001898 RID: 6296
	private List<GameObject> NDDGCFFDFJN = new List<GameObject>();

	// Token: 0x04001899 RID: 6297
	private ODLLAEHMFAA FILFGDIGINA;

	// Token: 0x0400189A RID: 6298
	private int FLBNNNDBECB = -1;

	// Token: 0x0400189B RID: 6299
	private HDKFHLFLDGG IMPAHLIGELE;

	// Token: 0x0400189C RID: 6300
	private List<int> HNGBMIJHPLE = new List<int>();

	// Token: 0x0400189D RID: 6301
	private int AKJMKGCPCCB = -1;

	// Token: 0x0400189E RID: 6302
	private int AOKIMHCAAHB;

	// Token: 0x0400189F RID: 6303
	private string NLKIPHPICLJ = "";

	// Token: 0x040018A0 RID: 6304
	private string GKKCHJLKFBL = "";

	// Token: 0x040018A1 RID: 6305
	private bool CIPGFJLECDH;

	// Token: 0x040018A2 RID: 6306
	private PLFDAJJHMKO LMKDNPOKOBF;
}
