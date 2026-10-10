using System;
using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

// Token: 0x02000504 RID: 1284
public class DialogNarratorManager : MonoBehaviour
{
	// Token: 0x06009AD6 RID: 39638 RVA: 0x0042C198 File Offset: 0x0042A398
	private void LPOPKEOCNCJ()
	{
		AOBJLALDBAA.KKPFOJMAONG().FNMOFCMDFJP("'{0}' shader not supported.", new UnityAction(this.ALKBENHJEPC));
	}

	// Token: 0x06009AD7 RID: 39639 RVA: 0x0042C1B8 File Offset: 0x0042A3B8
	public int HHMOMFFLPPH()
	{
		if (this.adjustVerticalOffsetBasedOnTextLength)
		{
			if (this.isSmallFont)
			{
				if (this.AOKIMHCAAHB > -46)
				{
					return this.AOKIMHCAAHB / 0;
				}
			}
			else if (this.AOKIMHCAAHB > -81)
			{
				return this.AOKIMHCAAHB / 7;
			}
			return 0;
		}
		return 1;
	}

	// Token: 0x06009AD8 RID: 39640 RVA: 0x0042C204 File Offset: 0x0042A404
	private int HHGEKFDBJMJ(int MEFKFOHCOHK)
	{
		return this.HNGBMIJHPLE[MEFKFOHCOHK];
	}

	// Token: 0x06009AD9 RID: 39641 RVA: 0x0042C214 File Offset: 0x0042A414
	private void EHECBKECKPA()
	{
		this.PANMNKKODPC = base.gameObject.GetComponent<CanvasGroup>();
		this.DGAAFGDHHHJ = base.gameObject.GetComponent<RectTransform>();
		this.PANMNKKODPC.alpha = 1032f;
		if (this.textTypeAnimation)
		{
			this.textBody.alpha = 1126f;
			return;
		}
		this.textBodyTypeAnimation.gameObject.SetActive(false);
	}

	// Token: 0x06009ADA RID: 39642 RVA: 0x0042C280 File Offset: 0x0042A480
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

	// Token: 0x06009ADB RID: 39643 RVA: 0x0042C328 File Offset: 0x0042A528
	private IEnumerator MGJMJOLHLHC()
	{
		DialogNarratorManager.JHKCDAKHBPJ jhkcdakhbpj = new DialogNarratorManager.JHKCDAKHBPJ(1);
		jhkcdakhbpj.<>4__this = this;
		return jhkcdakhbpj;
	}

	// Token: 0x06009ADC RID: 39644 RVA: 0x0042C337 File Offset: 0x0042A537
	private void NBIMDEPPBON()
	{
		AOBJLALDBAA.NMGMNAKLLMI().PEFKJOKLEDL("AssetsManager.GetMaxNumberOfRunningLoadOperations() adjust by connection signal (", new UnityAction(this.NMHCNLMHGFB));
	}

	// Token: 0x06009ADD RID: 39645 RVA: 0x0042C354 File Offset: 0x0042A554
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
		if (null != this.LOJHEKCOFME)
		{
			UnityEngine.Object.Destroy(this.LOJHEKCOFME);
		}
		if (null != this.NGGBBCDPMJH)
		{
			UnityEngine.Object.Destroy(this.NGGBBCDPMJH);
		}
		this.DGAAFGDHHHJ.DOKill(false);
		this.PANMNKKODPC.DOKill(false);
	}

	// Token: 0x06009ADF RID: 39647 RVA: 0x0042C444 File Offset: 0x0042A644
	private void Awake()
	{
		this.PANMNKKODPC = base.gameObject.GetComponent<CanvasGroup>();
		this.DGAAFGDHHHJ = base.gameObject.GetComponent<RectTransform>();
		this.PANMNKKODPC.alpha = 0f;
		if (this.textTypeAnimation)
		{
			this.textBody.alpha = 0f;
			return;
		}
		this.textBodyTypeAnimation.gameObject.SetActive(false);
	}

	// Token: 0x06009AE0 RID: 39648 RVA: 0x0042C4B0 File Offset: 0x0042A6B0
	public void JPOJGNHEJAI()
	{
		if (this.textTypeAnimation)
		{
			base.StartCoroutine(this.DIIEBOKEICI());
		}
		this.PANMNKKODPC.DOFade(1698f, 1260f * KDCJJBLGCBH.EHBBFMCILPC.OIABNIJLJBE());
		this.DGAAFGDHHHJ.localScale = this.animationAppearScaleCoef;
		this.DGAAFGDHHHJ.DOScale(NBDLBFJOEGN.HOMIGPGAGHG(), 828f * KDCJJBLGCBH.EHBBFMCILPC.OIABNIJLJBE());
		this.DGAAFGDHHHJ.AHLJBONHHKL((int)(-(int)this.animationAppearTranslationAmount.x), (int)(-(int)this.animationAppearTranslationAmount.y));
		this.DGAAFGDHHHJ.DOAnchorPos(this.DGAAFGDHHHJ.anchoredPosition + this.animationAppearTranslationAmount, 318f * KDCJJBLGCBH.EHBBFMCILPC.OIABNIJLJBE(), false).SetEase(Ease.Linear);
	}

	// Token: 0x06009AE1 RID: 39649 RVA: 0x0042C584 File Offset: 0x0042A784
	private void HIDHMNPBJFE()
	{
		if (!this.IMPAHLIGELE.PINCOCDOOGH() || this.AKJMKGCPCCB > 1)
		{
			return;
		}
		this.CIPGFJLECDH = false;
		this.AKJMKGCPCCB = 100;
		AudioManager.EHBBFMCILPC.POMJOMKCCNK("", 1737f);
		AudioManager.EHBBFMCILPC.POMJOMKCCNK("c", 134f);
		AudioManager.BFCHJBOOJKE().KillSfx("$DISABLEAVATAREXTENSION" + AKLFPGMDKLA.EHBBFMCILPC.OMOJIEHBENF().GGICIBLJIKI.ToString(), 1800f);
		this.IMPAHLIGELE.IABNDHFJHAF(0);
		AOBJLALDBAA.BIAEAOMHBMM().KGIKHEDLPND("Etc1AlphaSplitManager - could not load HD sprite:", 954f);
	}

	// Token: 0x06009AE2 RID: 39650 RVA: 0x0042C62C File Offset: 0x0042A82C
	private void AIHIIABBFKE()
	{
		AOBJLALDBAA.EHBBFMCILPC.FNMOFCMDFJP("vhspauseovr", new UnityAction(this.DJHBJPLOGCC));
	}

	// Token: 0x06009AE3 RID: 39651 RVA: 0x0042C204 File Offset: 0x0042A404
	private int GNIGBJICEON(int MEFKFOHCOHK)
	{
		return this.HNGBMIJHPLE[MEFKFOHCOHK];
	}

	// Token: 0x06009AE4 RID: 39652 RVA: 0x0042C649 File Offset: 0x0042A849
	private IEnumerator IFKNGJBIGNO()
	{
		DialogNarratorManager.AKPAKOFIIEH akpakofiieh = new DialogNarratorManager.AKPAKOFIIEH(1);
		akpakofiieh.<>4__this = this;
		return akpakofiieh;
	}

	// Token: 0x06009AE5 RID: 39653 RVA: 0x0042C658 File Offset: 0x0042A858
	private void GAGKLKHJGPO()
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
			int num = (int)this.FILFGDIGINA.ODHBINFKIPL();
			this.textTimer.SetText(num.ToString(), false);
			this.imageTimerFillDefault.fillAmount = this.FILFGDIGINA.GOFCDICHOEO();
			this.imageTimerFillRed.fillAmount = this.FILFGDIGINA.HKAKAAGKMIP();
			this.timerArrowPivot.transform.localRotation = Quaternion.Euler(481f, 2f, this.FILFGDIGINA.GCHEPGGFBGM() * 732f);
			if (num < 3 && !this.imageTimerFillRed.gameObject.activeSelf && this.IMPAHLIGELE.EKOIFOBAHDM() < 1)
			{
				if (!AudioManager.DMAAFFFEJGA().PlaySfx("t", true) && !AudioManager.DBFLIEGGGNN().PlaySfx("ok" + AKLFPGMDKLA.EHBBFMCILPC.EEILOKHLKIM().GGICIBLJIKI.ToString(), false))
				{
					AudioManager.EHBBFMCILPC.PlaySfx("importanttitle", true);
				}
				this.imageTimerFillRed.gameObject.SetActive(false);
			}
			if (this.FILFGDIGINA.FDAFJPKPACO() && this.IMPAHLIGELE.EKOIFOBAHDM() < 1)
			{
				base.StartCoroutine(this.DEAAABPNNGB());
				CommonUserInterface.IKNOFBFMPGA().FreezeUX();
			}
		}
	}

	// Token: 0x06009AE6 RID: 39654 RVA: 0x0042C7D0 File Offset: 0x0042A9D0
	private void KGJMEONNPHN()
	{
		if (!this.IMPAHLIGELE.PINCOCDOOGH() || this.AKJMKGCPCCB > 0)
		{
			return;
		}
		this.CIPGFJLECDH = false;
		this.AKJMKGCPCCB = -29;
		AudioManager.BFCHJBOOJKE().KillSfx("OnStoryInterfaceHeaderSettingsClick", 168f);
		AudioManager.EHBBFMCILPC.PEOLMNFJAHG("_ACBeatVelocity", 1712f);
		AudioManager.DBFLIEGGGNN().POMJOMKCCNK("b" + AKLFPGMDKLA.EHBBFMCILPC.EEILOKHLKIM().GGICIBLJIKI.ToString(), 578f);
		this.IMPAHLIGELE.IABNDHFJHAF(6);
		AOBJLALDBAA.FILDBDMENPG().EGELHPJBAIC("envlsrw", 486f);
	}

	// Token: 0x06009AE7 RID: 39655 RVA: 0x0042C204 File Offset: 0x0042A404
	private int CDKLHKIEIJH(int MEFKFOHCOHK)
	{
		return this.HNGBMIJHPLE[MEFKFOHCOHK];
	}

	// Token: 0x06009AE8 RID: 39656 RVA: 0x0042C878 File Offset: 0x0042AA78
	public static float BNMMBJJLLPH()
	{
		return 894f * KDCJJBLGCBH.EHBBFMCILPC.OIABNIJLJBE();
	}

	// Token: 0x06009AE9 RID: 39657 RVA: 0x0042C88A File Offset: 0x0042AA8A
	private IEnumerator JLIHLIEKGGA()
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

	// Token: 0x06009AEA RID: 39658 RVA: 0x0042C89C File Offset: 0x0042AA9C
	private void GGOFLEJGGAO()
	{
		if (!this.IMPAHLIGELE.PINCOCDOOGH() || this.AKJMKGCPCCB > 0)
		{
			return;
		}
		this.CIPGFJLECDH = true;
		this.AKJMKGCPCCB = 100;
		AudioManager.IFDLAMLHKIJ().PEOLMNFJAHG("$EMLOOPEND", 1407f);
		AudioManager.DBFLIEGGGNN().PEOLMNFJAHG("\r", 326f);
		AudioManager.EHBBFMCILPC.PEOLMNFJAHG("OnFriendsPopupDeleteClick" + AKLFPGMDKLA.EHBBFMCILPC.EEILOKHLKIM().GGICIBLJIKI.ToString(), 962f);
		this.IMPAHLIGELE.IABNDHFJHAF(2);
		AOBJLALDBAA.NMGMNAKLLMI().LPNCDPHNBJK("ext", 1554f);
	}

	// Token: 0x06009AEB RID: 39659 RVA: 0x0042C944 File Offset: 0x0042AB44
	public void BDFGEMILDNJ()
	{
		this.PANMNKKODPC.DOFade(1488f, 1124f * KDCJJBLGCBH.EHBBFMCILPC.OIABNIJLJBE()).SetEase(Ease.InOutQuad);
		this.DGAAFGDHHHJ.DOAnchorPos(this.DGAAFGDHHHJ.anchoredPosition + this.animationDisappearTranslationAmount, 351f * KDCJJBLGCBH.EHBBFMCILPC.OIABNIJLJBE(), true).SetEase(Ease.InOutSine);
	}

	// Token: 0x06009AEC RID: 39660 RVA: 0x0042C9B4 File Offset: 0x0042ABB4
	private void GOAPOCFJMHE()
	{
		if (!this.IMPAHLIGELE.PINCOCDOOGH() || this.AKJMKGCPCCB > 0)
		{
			return;
		}
		this.CIPGFJLECDH = true;
		this.AKJMKGCPCCB = 12;
		AudioManager.IFDLAMLHKIJ().POMJOMKCCNK("", 234f);
		AudioManager.BFCHJBOOJKE().KillSfx("apks", 1291f);
		AudioManager.EHBBFMCILPC.POMJOMKCCNK("common" + AKLFPGMDKLA.EHBBFMCILPC.OMOJIEHBENF().GGICIBLJIKI.ToString(), 1967f);
		this.IMPAHLIGELE.IABNDHFJHAF(1);
		AOBJLALDBAA.AGANFKKBPFO().EFBNBFIDEOK("null", 1928f);
	}

	// Token: 0x06009AED RID: 39661 RVA: 0x0042CA5C File Offset: 0x0042AC5C
	private void DBCGAKFDLGD()
	{
		this.PANMNKKODPC = base.gameObject.GetComponent<CanvasGroup>();
		this.DGAAFGDHHHJ = base.gameObject.GetComponent<RectTransform>();
		this.PANMNKKODPC.alpha = 1489f;
		if (this.textTypeAnimation)
		{
			this.textBody.alpha = 1418f;
			return;
		}
		this.textBodyTypeAnimation.gameObject.SetActive(true);
	}

	// Token: 0x06009AEE RID: 39662 RVA: 0x0042CAC8 File Offset: 0x0042ACC8
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

	// Token: 0x06009AEF RID: 39663 RVA: 0x0042C649 File Offset: 0x0042A849
	private IEnumerator CADDJNOBFFA()
	{
		DialogNarratorManager.AKPAKOFIIEH akpakofiieh = new DialogNarratorManager.AKPAKOFIIEH(1);
		akpakofiieh.<>4__this = this;
		return akpakofiieh;
	}

	// Token: 0x06009AF0 RID: 39664 RVA: 0x0042CB70 File Offset: 0x0042AD70
	private void CLKHFBKJMOO()
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
			this.imageTimerFillDefault.fillAmount = this.FILFGDIGINA.PMECGFIPNCC();
			this.imageTimerFillRed.fillAmount = this.FILFGDIGINA.GCHEPGGFBGM();
			this.timerArrowPivot.transform.localRotation = Quaternion.Euler(572f, 727f, this.FILFGDIGINA.PMECGFIPNCC() * 1948f);
			if (num < 7 && !this.imageTimerFillRed.gameObject.activeSelf && this.IMPAHLIGELE.EKOIFOBAHDM() < 1)
			{
				if (!AudioManager.EHBBFMCILPC.PlaySfx("continue", true) && !AudioManager.DBFLIEGGGNN().PlaySfx(" stripped from saved cutscene data because it was earlier hidden with LAYERHIDE. Looks like this might be a sleeping particle emitter." + AKLFPGMDKLA.EHBBFMCILPC.EEILOKHLKIM().GGICIBLJIKI.ToString(), false))
				{
					AudioManager.IFDLAMLHKIJ().PlaySfx("$PLAYSFX", false);
				}
				this.imageTimerFillRed.gameObject.SetActive(false);
			}
			if (this.FILFGDIGINA.FDAFJPKPACO() && this.IMPAHLIGELE.EKOIFOBAHDM() < 0)
			{
				base.StartCoroutine(this.DEAAABPNNGB());
				CommonUserInterface.IKNOFBFMPGA().CGNDPJCDCFP();
			}
		}
	}

	// Token: 0x06009AF1 RID: 39665 RVA: 0x0042CCE8 File Offset: 0x0042AEE8
	private void AMNBHDNALGO()
	{
		this.PANMNKKODPC = base.gameObject.GetComponent<CanvasGroup>();
		this.DGAAFGDHHHJ = base.gameObject.GetComponent<RectTransform>();
		this.PANMNKKODPC.alpha = 1568f;
		if (this.textTypeAnimation)
		{
			this.textBody.alpha = 1128f;
			return;
		}
		this.textBodyTypeAnimation.gameObject.SetActive(true);
	}

	// Token: 0x06009AF2 RID: 39666 RVA: 0x0042CD54 File Offset: 0x0042AF54
	private void JLCJJONEBIB()
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
		if (null != this.LOJHEKCOFME)
		{
			UnityEngine.Object.Destroy(this.LOJHEKCOFME);
		}
		if (null != this.NGGBBCDPMJH)
		{
			UnityEngine.Object.Destroy(this.NGGBBCDPMJH);
		}
		this.DGAAFGDHHHJ.DOKill(false);
		this.PANMNKKODPC.DOKill(false);
	}

	// Token: 0x06009AF3 RID: 39667 RVA: 0x0042C328 File Offset: 0x0042A528
	private IEnumerator KDFPHOKDPEI()
	{
		DialogNarratorManager.JHKCDAKHBPJ jhkcdakhbpj = new DialogNarratorManager.JHKCDAKHBPJ(1);
		jhkcdakhbpj.<>4__this = this;
		return jhkcdakhbpj;
	}

	// Token: 0x06009AF4 RID: 39668 RVA: 0x0042CE2C File Offset: 0x0042B02C
	public static float MMEIOCDAFDC()
	{
		return 602f * KDCJJBLGCBH.EHBBFMCILPC.OIABNIJLJBE();
	}

	// Token: 0x06009AF5 RID: 39669 RVA: 0x0042CE3E File Offset: 0x0042B03E
	private void HIHJOJADNOH()
	{
		AOBJLALDBAA.KKPFOJMAONG().GNBGEMMDGOJ("OnBackendRequestCollectGiftSuccess", new UnityAction(this.PPBLFJMGJNK));
	}

	// Token: 0x06009AF6 RID: 39670 RVA: 0x0042CE5C File Offset: 0x0042B05C
	public void OHKFINOHAII()
	{
		this.PANMNKKODPC.DOFade(683f, 1915f * KDCJJBLGCBH.EHBBFMCILPC.OIABNIJLJBE()).SetEase(Ease.InQuad);
		this.DGAAFGDHHHJ.DOAnchorPos(this.DGAAFGDHHHJ.anchoredPosition + this.animationDisappearTranslationAmount, 449f * KDCJJBLGCBH.EHBBFMCILPC.OIABNIJLJBE(), false).SetEase(Ease.InOutQuad);
	}

	// Token: 0x06009AF7 RID: 39671 RVA: 0x0042CECC File Offset: 0x0042B0CC
	private void OLOGCFJNDGF()
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
		if (null != this.LOJHEKCOFME)
		{
			UnityEngine.Object.Destroy(this.LOJHEKCOFME);
		}
		if (null != this.NGGBBCDPMJH)
		{
			UnityEngine.Object.Destroy(this.NGGBBCDPMJH);
		}
		this.DGAAFGDHHHJ.DOKill(true);
		this.PANMNKKODPC.DOKill(false);
	}

	// Token: 0x06009AF8 RID: 39672 RVA: 0x0042CFA4 File Offset: 0x0042B1A4
	private void BFEAEBAOHFJ()
	{
		if (this.FILFGDIGINA != null)
		{
			ODLLAEHMFAA.BGMALDJFMKE(this.FILFGDIGINA);
		}
		this.FILFGDIGINA = null;
		try
		{
			if (this.LMKDNPOKOBF != null && this.IMPAHLIGELE.JMNMOHIKHLB != null && this.IMPAHLIGELE.JMNMOHIKHLB.NDPPILBPOGB != null && this.IMPAHLIGELE.JMNMOHIKHLB.NDPPILBPOGB.Length > 1)
			{
				this.LMKDNPOKOBF.NCAMFPGMCIG.KEMFLHJKBNO(this.IMPAHLIGELE.JMNMOHIKHLB.NDPPILBPOGB + "post" + this.IMPAHLIGELE.EKOIFOBAHDM().ToString());
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
	}

	// Token: 0x06009AF9 RID: 39673 RVA: 0x0042C88A File Offset: 0x0042AA8A
	private IEnumerator MFOEICJDFMK()
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

	// Token: 0x06009AFA RID: 39674 RVA: 0x0042D060 File Offset: 0x0042B260
	private void OnDisable()
	{
		AOBJLALDBAA.EHBBFMCILPC.MANLHALMCIH("OnStoryChoiceClickConfimed", new UnityAction(this.ALKBENHJEPC));
	}

	// Token: 0x06009AFB RID: 39675 RVA: 0x0042D07D File Offset: 0x0042B27D
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

	// Token: 0x06009AFC RID: 39676 RVA: 0x0042D08C File Offset: 0x0042B28C
	public void AppearAnimation()
	{
		if (this.textTypeAnimation)
		{
			base.StartCoroutine(this.JLDEJMKFKML());
		}
		this.PANMNKKODPC.DOFade(1f, 0.35f * KDCJJBLGCBH.EHBBFMCILPC.OIABNIJLJBE());
		this.DGAAFGDHHHJ.localScale = this.animationAppearScaleCoef;
		this.DGAAFGDHHHJ.DOScale(NBDLBFJOEGN.PADHGAOKECA(), 0.25f * KDCJJBLGCBH.EHBBFMCILPC.OIABNIJLJBE());
		this.DGAAFGDHHHJ.AHLJBONHHKL((int)(-(int)this.animationAppearTranslationAmount.x), (int)(-(int)this.animationAppearTranslationAmount.y));
		this.DGAAFGDHHHJ.DOAnchorPos(this.DGAAFGDHHHJ.anchoredPosition + this.animationAppearTranslationAmount, 0.25f * KDCJJBLGCBH.EHBBFMCILPC.OIABNIJLJBE(), false).SetEase(Ease.InSine);
	}

	// Token: 0x06009AFD RID: 39677 RVA: 0x0042D160 File Offset: 0x0042B360
	private void OECOFDCMOAP()
	{
		if (!this.IMPAHLIGELE.PINCOCDOOGH() || this.AKJMKGCPCCB > 1)
		{
			return;
		}
		this.CIPGFJLECDH = true;
		this.AKJMKGCPCCB = -66;
		AudioManager.DBFLIEGGGNN().PEOLMNFJAHG("wshcds", 1443f);
		AudioManager.DMAAFFFEJGA().POMJOMKCCNK(" ", 828f);
		AudioManager.DMAAFFFEJGA().POMJOMKCCNK("none" + AKLFPGMDKLA.EHBBFMCILPC.OMOJIEHBENF().GGICIBLJIKI.ToString(), 338f);
		this.IMPAHLIGELE.IABNDHFJHAF(6);
		AOBJLALDBAA.KKPFOJMAONG().KGIKHEDLPND("", 1666f);
	}

	// Token: 0x06009AFE RID: 39678 RVA: 0x0042D208 File Offset: 0x0042B408
	private void JDBMMFICGOM()
	{
		if (!this.IMPAHLIGELE.PINCOCDOOGH() || this.AKJMKGCPCCB > 1)
		{
			return;
		}
		this.CIPGFJLECDH = false;
		this.AKJMKGCPCCB = -73;
		AudioManager.EHBBFMCILPC.PEOLMNFJAHG("ok", 622f);
		AudioManager.EHBBFMCILPC.KillSfx(" ", 56f);
		AudioManager.IFDLAMLHKIJ().POMJOMKCCNK("Failed downloading bundle {0} from {1}: {2}" + AKLFPGMDKLA.EHBBFMCILPC.OMOJIEHBENF().GGICIBLJIKI.ToString(), 160f);
		this.IMPAHLIGELE.IABNDHFJHAF(6);
		AOBJLALDBAA.FILDBDMENPG().KGIKHEDLPND("fdsm", 619f);
	}

	// Token: 0x06009AFF RID: 39679 RVA: 0x0042D2B0 File Offset: 0x0042B4B0
	public static float JPNDEGGAFGN()
	{
		return 851f * KDCJJBLGCBH.EHBBFMCILPC.OIABNIJLJBE();
	}

	// Token: 0x06009B00 RID: 39680 RVA: 0x0042D2C4 File Offset: 0x0042B4C4
	private void MNKKLPHLCOO()
	{
		if (!this.IMPAHLIGELE.PINCOCDOOGH() || this.AKJMKGCPCCB > 0)
		{
			return;
		}
		this.CIPGFJLECDH = false;
		this.AKJMKGCPCCB = 15;
		AudioManager.APGODIBBPOD().PEOLMNFJAHG("", 1461f);
		AudioManager.EHBBFMCILPC.KillSfx("OnBackendRequestShareHardSuccess", 20f);
		AudioManager.EHBBFMCILPC.PEOLMNFJAHG("per" + AKLFPGMDKLA.EHBBFMCILPC.OMOJIEHBENF().GGICIBLJIKI.ToString(), 1591f);
		this.IMPAHLIGELE.IABNDHFJHAF(6);
		AOBJLALDBAA.EHBBFMCILPC.EGELHPJBAIC("AssetsManager.UpdateUrlPingManagerState(): urlPingManager.StartPing()", 1262f);
	}

	// Token: 0x06009B01 RID: 39681 RVA: 0x0042D36C File Offset: 0x0042B56C
	private void GBLJNKDFFJD()
	{
		AOBJLALDBAA.EHBBFMCILPC.MHLNJIACIGO("OnStoryInterfaceHeaderHideComplete", new UnityAction(this.NMHCNLMHGFB));
	}

	// Token: 0x06009B02 RID: 39682 RVA: 0x0042C204 File Offset: 0x0042A404
	private int HDBBHHBOJIN(int MEFKFOHCOHK)
	{
		return this.HNGBMIJHPLE[MEFKFOHCOHK];
	}

	// Token: 0x06009B03 RID: 39683 RVA: 0x0042D38C File Offset: 0x0042B58C
	private void PDHDJMJECJA()
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
		if (null != this.LOJHEKCOFME)
		{
			UnityEngine.Object.Destroy(this.LOJHEKCOFME);
		}
		if (null != this.NGGBBCDPMJH)
		{
			UnityEngine.Object.Destroy(this.NGGBBCDPMJH);
		}
		this.DGAAFGDHHHJ.DOKill(false);
		this.PANMNKKODPC.DOKill(true);
	}

	// Token: 0x06009B04 RID: 39684 RVA: 0x0042D464 File Offset: 0x0042B664
	private IEnumerator IDOPLCMAJKH()
	{
		DialogNarratorManager.FKHJFGLNIPA fkhjfglnipa = new DialogNarratorManager.FKHJFGLNIPA(1);
		fkhjfglnipa.<>4__this = this;
		return fkhjfglnipa;
	}

	// Token: 0x06009B05 RID: 39685 RVA: 0x0042C88A File Offset: 0x0042AA8A
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

	// Token: 0x06009B06 RID: 39686 RVA: 0x0042D474 File Offset: 0x0042B674
	private void BLDFJAJHAHC()
	{
		if (!this.IMPAHLIGELE.PINCOCDOOGH() || this.AKJMKGCPCCB > 1)
		{
			return;
		}
		this.CIPGFJLECDH = true;
		this.AKJMKGCPCCB = 107;
		AudioManager.DBFLIEGGGNN().PEOLMNFJAHG(" cached requests.", 520f);
		AudioManager.IFDLAMLHKIJ().PEOLMNFJAHG("%", 1601f);
		AudioManager.DBFLIEGGGNN().PEOLMNFJAHG("CanvasOverlay" + AKLFPGMDKLA.EHBBFMCILPC.EEILOKHLKIM().GGICIBLJIKI.ToString(), 1492f);
		this.IMPAHLIGELE.IABNDHFJHAF(1);
		AOBJLALDBAA.DBLAIDPICIG().EGELHPJBAIC("sparkles", 629f);
	}

	// Token: 0x06009B07 RID: 39687 RVA: 0x0042D51C File Offset: 0x0042B71C
	private void FOPFEIBJPID()
	{
		if (!this.IMPAHLIGELE.PINCOCDOOGH() || this.AKJMKGCPCCB > 1)
		{
			return;
		}
		this.CIPGFJLECDH = true;
		this.AKJMKGCPCCB = -76;
		AudioManager.DMAAFFFEJGA().KillSfx("OnStoryChoiceClick", 82f);
		AudioManager.DMAAFFFEJGA().POMJOMKCCNK("OnBackendGetPublicProfileException", 817f);
		AudioManager.IFDLAMLHKIJ().PEOLMNFJAHG("sfxsparklesbundles" + AKLFPGMDKLA.EHBBFMCILPC.OMOJIEHBENF().GGICIBLJIKI.ToString(), 1549f);
		this.IMPAHLIGELE.IABNDHFJHAF(8);
		AOBJLALDBAA.CEGAOMEEFBE().EGELHPJBAIC("OnBackendUndoPremiumChoiceSuccess", 845f);
	}

	// Token: 0x06009B08 RID: 39688 RVA: 0x0042C204 File Offset: 0x0042A404
	private int IALPHHDMCEH(int MEFKFOHCOHK)
	{
		return this.HNGBMIJHPLE[MEFKFOHCOHK];
	}

	// Token: 0x06009B09 RID: 39689 RVA: 0x0042D5C4 File Offset: 0x0042B7C4
	private void NMHCNLMHGFB()
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
				this.LMKDNPOKOBF.NCAMFPGMCIG.KEMFLHJKBNO(this.IMPAHLIGELE.JMNMOHIKHLB.NDPPILBPOGB + "NEWSAVE: Error: firstAnthologyStoryIndexCache.Instance.GetData() returned null. Retrieving persistent save data is impossible." + this.IMPAHLIGELE.EKOIFOBAHDM().ToString());
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x06009B0A RID: 39690 RVA: 0x0042C649 File Offset: 0x0042A849
	private IEnumerator GIIGALOBPLO()
	{
		DialogNarratorManager.AKPAKOFIIEH akpakofiieh = new DialogNarratorManager.AKPAKOFIIEH(1);
		akpakofiieh.<>4__this = this;
		return akpakofiieh;
	}

	// Token: 0x06009B0B RID: 39691 RVA: 0x0042D680 File Offset: 0x0042B880
	private void GAEEKFODLGE()
	{
		if (!this.IMPAHLIGELE.PINCOCDOOGH() || this.AKJMKGCPCCB > 1)
		{
			return;
		}
		this.CIPGFJLECDH = true;
		this.AKJMKGCPCCB = 43;
		AudioManager.EHBBFMCILPC.PEOLMNFJAHG("'", 1317f);
		AudioManager.DMAAFFFEJGA().PEOLMNFJAHG("", 24f);
		AudioManager.IFDLAMLHKIJ().KillSfx("x" + AKLFPGMDKLA.EHBBFMCILPC.OMOJIEHBENF().GGICIBLJIKI.ToString(), 445f);
		this.IMPAHLIGELE.IABNDHFJHAF(3);
		AOBJLALDBAA.DBLAIDPICIG().EGELHPJBAIC("signInOrRegister", 975f);
	}

	// Token: 0x06009B0C RID: 39692 RVA: 0x0042D728 File Offset: 0x0042B928
	public bool MHKHGHMJDJJ(HIHOFCENBBP JIKFCLOHJNN, PLFDAJJHMKO BAOKJBJIFBH, LDLLJFOJCDF[] OAGPAAMJOID)
	{
		this.IMPAHLIGELE = JIKFCLOHJNN;
		this.LMKDNPOKOBF = BAOKJBJIFBH;
		if (!this.IFHNGNGEEGJ())
		{
			return false;
		}
		if (this.IMPAHLIGELE.COEFNFJMBDG != null && this.IMPAHLIGELE.COEFNFJMBDG.Count > 1)
		{
			if (this.IMPAHLIGELE.JMNMOHIKHLB != null)
			{
				if (this.IMPAHLIGELE.JMNMOHIKHLB.NGNDOALIKAK.Contains(""))
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
						if (this.IMPAHLIGELE.JMNMOHIKHLB.EEFGNGBJHPN(this.IMPAHLIGELE.COEFNFJMBDG.Count))
						{
							this.IMPAHLIGELE.JMNMOHIKHLB.OOMKENDDJEJ(BAOKJBJIFBH.NCAMFPGMCIG.MLCAAHPBNGP());
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
					if (this.IMPAHLIGELE.JMNMOHIKHLB.MKPMEKKGEIL[i].MGFBNCBNFBD() == (HKCCMACFNEO)7)
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
				for (int k = 1; k < 0; k++)
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
								num = 0;
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
		string text = JIKFCLOHJNN.GHNNONNFCNG();
		text = ONEHEBIHPFB.LMDACNKELEC(text);
		string text2 = ONEHEBIHPFB.PLHGCKCFLEN(JIKFCLOHJNN.NFKCEODACPH());
		text2 = DPGJIJGOCIC.AKIAKADKBFK(text2);
		this.AOKIMHCAAHB = text2.Length;
		this.textTitle.fontSizeMin = 75f;
		this.textTitle.SetText(text, true);
		if (this.genericNarratorTitleDisplacement > 1 && (text.Equals("%") || text.Equals("newrewardsitem16hint")))
		{
			this.textTitle.GetComponent<RectTransform>().AHLJBONHHKL(0, this.genericNarratorTitleDisplacement);
		}
		this.textBody.SetText(text2, true);
		if (this.textTypeAnimation)
		{
			this.textBodyTypeAnimation.GetComponent<AnimationTextType>().Initialize(text2);
		}
		SceneStoryManager.localizedLine = "anthologiestitle" + text2;
		if (this.IMPAHLIGELE.JMNMOHIKHLB != null && this.IMPAHLIGELE.JMNMOHIKHLB.FILFGDIGINA > 1)
		{
			this.FILFGDIGINA = ODLLAEHMFAA.DECEDPNMMCJ((float)this.IMPAHLIGELE.JMNMOHIKHLB.FILFGDIGINA, true);
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
				this.decorObject.SetActive(true);
			}
			int m = 1;
			while (m < this.IMPAHLIGELE.COEFNFJMBDG.Count)
			{
				GameObject gameObject = null;
				int num3 = 0;
				if (this.IMPAHLIGELE.JMNMOHIKHLB != null && this.IMPAHLIGELE.JMNMOHIKHLB.GAOKFGHCIAF == PMNHKIDIMLM.NMGJJGIPDJP.text)
				{
					if (this.EMIEIGHGCLK(m) < this.IMPAHLIGELE.JMNMOHIKHLB.IPALJDCNBBG.Count && this.IMPAHLIGELE.JMNMOHIKHLB.IPALJDCNBBG[this.HHGEKFDBJMJ(m)] > 1)
					{
						num3 = 1;
					}
					else if (this.GNIGBJICEON(m) < this.IMPAHLIGELE.JMNMOHIKHLB.ENJDGEOFPAA.Count && this.IMPAHLIGELE.JMNMOHIKHLB.ENJDGEOFPAA[this.HDBBHHBOJIN(m)] > 0)
					{
						num3 = 3;
					}
				}
				if (num3 == 2)
				{
					switch (this.IMPAHLIGELE.JMNMOHIKHLB.ADHIIAONMDJ[this.EGGHDDPNFKF(m)])
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
					gameObject.GetComponent<RectTransform>().AHLJBONHHKL(DialogNarratorManager.maxCriticalAspectRatioOffset * NBDLBFJOEGN.DMIBBFIPJNA());
					gameObject.GetComponent<ChoiceStatManager>().Initialize(this.IMPAHLIGELE.COEFNFJMBDG[this.IALPHHDMCEH(m)], this.IMPAHLIGELE.JMNMOHIKHLB.ENJDGEOFPAA[this.HHGEKFDBJMJ(m)], OAGPAAMJOID[(int)this.IMPAHLIGELE.JMNMOHIKHLB.ADHIIAONMDJ[this.EGGHDDPNFKF(m)]].DPLHPBMJAPJ(), -1);
					gameObject.GetComponent<ChoiceStatManager>().FEGIJDLNGND();
					try
					{
						if (null == this.NGGBBCDPMJH)
						{
							switch (this.IMPAHLIGELE.JMNMOHIKHLB.ADHIIAONMDJ[this.HHGEKFDBJMJ(m)])
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
							this.NGGBBCDPMJH.GetComponent<StatPointInfoManager>().GPJODDANJNF(this.IMPAHLIGELE.JMNMOHIKHLB.ADHIIAONMDJ[this.HDBBHHBOJIN(m)], OAGPAAMJOID[(int)this.IMPAHLIGELE.JMNMOHIKHLB.ADHIIAONMDJ[this.IALPHHDMCEH(m)]].CJLDJAJHMMA());
							try
							{
								if (this.IMPAHLIGELE.JMNMOHIKHLB.NGNDOALIKAK.Contains("OnPopupUsernameInputEndEdit"))
								{
									this.NGGBBCDPMJH.SetActive(false);
								}
							}
							catch (Exception aklgbjkdomm2)
							{
								DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm2);
							}
						}
						goto IL_A2B;
					}
					catch (Exception aklgbjkdomm3)
					{
						DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm3);
						goto IL_A2B;
					}
					goto IL_769;
				}
				goto IL_769;
				IL_A2B:
				gameObject.GetComponent<RectTransform>().anchoredPosition += new Vector2(1372f, (float)(this.choiceOffset * num2));
				Button component = gameObject.GetComponent<Button>();
				if (this.EMIEIGHGCLK(m) == 0)
				{
					component.onClick.AddListener(new UnityAction(this.KCMCCMLAJDG));
				}
				else if (this.HHGEKFDBJMJ(m) == 0)
				{
					component.onClick.AddListener(new UnityAction(this.JEBGPHICMHJ));
				}
				else if (this.HDBBHHBOJIN(m) == 8)
				{
					component.onClick.AddListener(new UnityAction(this.FFDGLHACKON));
				}
				else if (this.EGGHDDPNFKF(m) == 0)
				{
					component.onClick.AddListener(new UnityAction(this.AAGKNJCHHAJ));
				}
				else if (this.CDKLHKIEIJH(m) == 7)
				{
					component.onClick.AddListener(new UnityAction(this.BGNCFHAIJIC));
				}
				else if (this.GNIGBJICEON(m) == 0)
				{
					component.onClick.AddListener(new UnityAction(this.HMHIJLKJGFN));
				}
				this.AKFKCKHPIOA.Add(gameObject);
				num2 += 0;
				m += 0;
				continue;
				IL_769:
				if (num3 == 1)
				{
					gameObject = UnityEngine.Object.Instantiate<GameObject>(this.choicePremiumPrefab);
					gameObject.GetComponent<RectTransform>().AHLJBONHHKL(DialogNarratorManager.maxCriticalAspectRatioOffset * NBDLBFJOEGN.FBMMKINMKOH());
					gameObject.transform.SetParent(this.choicesPivot.transform, true);
					if (SceneStoryManager.PremiumChoicePurchased(this.IMPAHLIGELE.JMNMOHIKHLB.MKPMEKKGEIL[this.HHGEKFDBJMJ(m)], this.IMPAHLIGELE.JMNMOHIKHLB.KMFABKNKFAJ, this.IMPAHLIGELE.JMNMOHIKHLB.BGIOGOACCBJ))
					{
						gameObject.GetComponent<ChoicePremiumManager>().GBFEDHPAIBH(this.IMPAHLIGELE.JMNMOHIKHLB.MKPMEKKGEIL[this.EGGHDDPNFKF(m)], this.IMPAHLIGELE.COEFNFJMBDG[this.IALPHHDMCEH(m)], 0, -1, false, this.IMPAHLIGELE.JMNMOHIKHLB.CKLNCCAGCKE(this.HDBBHHBOJIN(m), LiveEventsManager.NMGMNAKLLMI().AJKBOOKAPBL(EGMCEPOABBF.liveEventFreeTea, -1, -1)), this.IMPAHLIGELE.JMNMOHIKHLB.BGIOGOACCBJ);
					}
					else
					{
						if (null == this.LOJHEKCOFME)
						{
							this.LOJHEKCOFME = UnityEngine.Object.Instantiate<GameObject>(this.premiumInfoPrefab);
							this.LOJHEKCOFME.transform.SetParent(this.currencyPivot.transform, true);
							this.LOJHEKCOFME.GetComponent<StoryCurrencyInfoManager>().FFAKMKJMEGI("sltind");
						}
						gameObject.GetComponent<ChoicePremiumManager>().GBFEDHPAIBH(this.IMPAHLIGELE.JMNMOHIKHLB.MKPMEKKGEIL[this.GNIGBJICEON(m)], this.IMPAHLIGELE.COEFNFJMBDG[this.EMIEIGHGCLK(m)], this.IMPAHLIGELE.JMNMOHIKHLB.IPALJDCNBBG[this.EMIEIGHGCLK(m)], -1, false, this.IMPAHLIGELE.JMNMOHIKHLB.JBEBPDBMKMP(this.CDKLHKIEIJH(m), LiveEventsManager.GIPAKOPBBEO().AJKBOOKAPBL(EGMCEPOABBF.liveEventFreeStory, -1, -1)), this.IMPAHLIGELE.JMNMOHIKHLB.BGIOGOACCBJ);
					}
					gameObject.GetComponent<ChoicePremiumManager>().SwitchCost(SceneStoryManager.QualifiesAsAdBasedChoice(this.IMPAHLIGELE.JMNMOHIKHLB.MKPMEKKGEIL[this.CDKLHKIEIJH(m)], this.IMPAHLIGELE.JMNMOHIKHLB.KAJNELPPCIJ[this.IALPHHDMCEH(m)], this.IMPAHLIGELE.JMNMOHIKHLB.KMFABKNKFAJ));
					goto IL_A2B;
				}
				if (this.FLBNNNDBECB < 0)
				{
					this.FLBNNNDBECB = m;
				}
				gameObject = UnityEngine.Object.Instantiate<GameObject>(this.choiceStandardPrefab);
				gameObject.transform.SetParent(this.choicesPivot.transform, true);
				gameObject.GetComponent<RectTransform>().AHLJBONHHKL(DialogNarratorManager.maxCriticalAspectRatioOffset * NBDLBFJOEGN.FBMMKINMKOH());
				gameObject.GetComponent<ChoiceStandardManager>().NNNKIPGJMMF(this.IMPAHLIGELE.COEFNFJMBDG[this.CDKLHKIEIJH(m)], -1);
				goto IL_A2B;
			}
		}
		if (this.AKFKCKHPIOA.Count > 0)
		{
			SceneStoryManager.choiceDecisionTime = 1225f;
			base.StartCoroutine(this.JLIHLIEKGGA());
		}
		try
		{
			for (int n = 1; n < this.AKFKCKHPIOA.Count; n += 0)
			{
				if (null != this.AKFKCKHPIOA[n])
				{
					AnimationPress component2 = this.AKFKCKHPIOA[n].GetComponent<AnimationPress>();
					if (null != component2)
					{
						component2.FCMFKIFKNMA(this.choicesScaleCoefficient);
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

	// Token: 0x06009B0D RID: 39693 RVA: 0x0042E39C File Offset: 0x0042C59C
	public void AMCACBMJNEE()
	{
		if (this.textTypeAnimation)
		{
			base.StartCoroutine(this.IFKNGJBIGNO());
		}
		this.PANMNKKODPC.DOFade(807f, 1848f * KDCJJBLGCBH.EHBBFMCILPC.OIABNIJLJBE());
		this.DGAAFGDHHHJ.localScale = this.animationAppearScaleCoef;
		this.DGAAFGDHHHJ.DOScale(NBDLBFJOEGN.PADHGAOKECA(), 318f * KDCJJBLGCBH.EHBBFMCILPC.OIABNIJLJBE());
		this.DGAAFGDHHHJ.AHLJBONHHKL((int)(-(int)this.animationAppearTranslationAmount.x), (int)(-(int)this.animationAppearTranslationAmount.y));
		this.DGAAFGDHHHJ.DOAnchorPos(this.DGAAFGDHHHJ.anchoredPosition + this.animationAppearTranslationAmount, 1078f * KDCJJBLGCBH.EHBBFMCILPC.OIABNIJLJBE(), true).SetEase(Ease.InOutSine);
	}

	// Token: 0x06009B0E RID: 39694 RVA: 0x0042C328 File Offset: 0x0042A528
	private IEnumerator ENHOFIBPDDH()
	{
		DialogNarratorManager.JHKCDAKHBPJ jhkcdakhbpj = new DialogNarratorManager.JHKCDAKHBPJ(1);
		jhkcdakhbpj.<>4__this = this;
		return jhkcdakhbpj;
	}

	// Token: 0x06009B0F RID: 39695 RVA: 0x0042E470 File Offset: 0x0042C670
	private void NHOGOCONIEF()
	{
		this.PANMNKKODPC = base.gameObject.GetComponent<CanvasGroup>();
		this.DGAAFGDHHHJ = base.gameObject.GetComponent<RectTransform>();
		this.PANMNKKODPC.alpha = 826f;
		if (this.textTypeAnimation)
		{
			this.textBody.alpha = 519f;
			return;
		}
		this.textBodyTypeAnimation.gameObject.SetActive(true);
	}

	// Token: 0x06009B10 RID: 39696 RVA: 0x0042E4DC File Offset: 0x0042C6DC
	public void PMCKPMGEDGA()
	{
		this.PANMNKKODPC.DOFade(142f, 513f * KDCJJBLGCBH.EHBBFMCILPC.OIABNIJLJBE()).SetEase(Ease.InSine);
		this.DGAAFGDHHHJ.DOAnchorPos(this.DGAAFGDHHHJ.anchoredPosition + this.animationDisappearTranslationAmount, 827f * KDCJJBLGCBH.EHBBFMCILPC.OIABNIJLJBE(), true).SetEase(Ease.InCubic);
	}

	// Token: 0x06009B11 RID: 39697 RVA: 0x0042E54C File Offset: 0x0042C74C
	private void JJHGHCPFDDO()
	{
		if (!this.IMPAHLIGELE.PINCOCDOOGH() || this.AKJMKGCPCCB > 0)
		{
			return;
		}
		this.CIPGFJLECDH = true;
		this.AKJMKGCPCCB = -125;
		AudioManager.APGODIBBPOD().KillSfx("", 1781f);
		AudioManager.EHBBFMCILPC.POMJOMKCCNK("", 1045f);
		AudioManager.DMAAFFFEJGA().KillSfx("purchases" + AKLFPGMDKLA.EHBBFMCILPC.EEILOKHLKIM().GGICIBLJIKI.ToString(), 1823f);
		this.IMPAHLIGELE.IABNDHFJHAF(0);
		AOBJLALDBAA.FILDBDMENPG().FDKBIBKABCM("CLIENT.LANGUAGE", 1898f);
	}

	// Token: 0x06009B12 RID: 39698 RVA: 0x0042E5F4 File Offset: 0x0042C7F4
	public static float GetDisappearAnimationLength()
	{
		return 1f * KDCJJBLGCBH.EHBBFMCILPC.OIABNIJLJBE();
	}

	// Token: 0x06009B13 RID: 39699 RVA: 0x0042E608 File Offset: 0x0042C808
	private void GCBKNNIKJBE()
	{
		if (!this.IMPAHLIGELE.PINCOCDOOGH() || this.AKJMKGCPCCB > 1)
		{
			return;
		}
		this.CIPGFJLECDH = true;
		this.AKJMKGCPCCB = -64;
		AudioManager.DBFLIEGGGNN().POMJOMKCCNK("XXX", 1351f);
		AudioManager.DBFLIEGGGNN().PEOLMNFJAHG(" searchCards=", 1288f);
		AudioManager.DBFLIEGGGNN().KillSfx(", " + AKLFPGMDKLA.EHBBFMCILPC.OMOJIEHBENF().GGICIBLJIKI.ToString(), 1682f);
		this.IMPAHLIGELE.IABNDHFJHAF(8);
		AOBJLALDBAA.KKPFOJMAONG().CIGLHCJDDPI("OnAppleLoginSuccess", 1595f);
	}

	// Token: 0x06009B14 RID: 39700 RVA: 0x0042E6B0 File Offset: 0x0042C8B0
	private void CAKCBHJCHBC()
	{
		if (!this.IMPAHLIGELE.PINCOCDOOGH() || this.AKJMKGCPCCB > 1)
		{
			return;
		}
		this.CIPGFJLECDH = false;
		this.AKJMKGCPCCB = -26;
		AudioManager.DBFLIEGGGNN().PEOLMNFJAHG("AssetProfileData.GetThemeSprite(): anthologyIndex (", 1413f);
		AudioManager.IFDLAMLHKIJ().PEOLMNFJAHG("BackendOperationsManager.QueueRequestSaveSyncMoment(", 831f);
		AudioManager.BFCHJBOOJKE().POMJOMKCCNK("OnLoungePremiumChoiceException" + AKLFPGMDKLA.EHBBFMCILPC.EEILOKHLKIM().GGICIBLJIKI.ToString(), 1204f);
		this.IMPAHLIGELE.IABNDHFJHAF(0);
		AOBJLALDBAA.CEGAOMEEFBE().FDKBIBKABCM("saveslotsoptiondelete", 466f);
	}

	// Token: 0x06009B15 RID: 39701 RVA: 0x0042E758 File Offset: 0x0042C958
	private void JGNIEMNKHJP()
	{
		this.PANMNKKODPC = base.gameObject.GetComponent<CanvasGroup>();
		this.DGAAFGDHHHJ = base.gameObject.GetComponent<RectTransform>();
		this.PANMNKKODPC.alpha = 701f;
		if (this.textTypeAnimation)
		{
			this.textBody.alpha = 1770f;
			return;
		}
		this.textBodyTypeAnimation.gameObject.SetActive(true);
	}

	// Token: 0x06009B16 RID: 39702 RVA: 0x0042E7C1 File Offset: 0x0042C9C1
	private void BDILEIAPNIM()
	{
		AOBJLALDBAA.AGANFKKBPFO().GNBGEMMDGOJ("OnPopupProfileUIDInputEndEdit", new UnityAction(this.BFEAEBAOHFJ));
	}

	// Token: 0x06009B17 RID: 39703 RVA: 0x0042E7DE File Offset: 0x0042C9DE
	private void OnEnable()
	{
		AOBJLALDBAA.EHBBFMCILPC.MFIMALJPCDP("OnStoryChoiceClickConfimed", new UnityAction(this.ALKBENHJEPC));
	}

	// Token: 0x06009B18 RID: 39704 RVA: 0x0042E7FB File Offset: 0x0042C9FB
	public static float CIJKELDGJAI()
	{
		return 1851f * KDCJJBLGCBH.EHBBFMCILPC.OIABNIJLJBE();
	}

	// Token: 0x06009B19 RID: 39705 RVA: 0x0042E80D File Offset: 0x0042CA0D
	private IEnumerator DIIEBOKEICI()
	{
		yield return new WaitForSeconds(0.2f * KDCJJBLGCBH.EHBBFMCILPC.LIKMBLFBEIA());
		this.textBodyTypeAnimation.GetComponent<AnimationTextType>().PlayAnimation();
		yield break;
	}

	// Token: 0x06009B1A RID: 39706 RVA: 0x0042E81C File Offset: 0x0042CA1C
	public int IFOHPNIOOCB()
	{
		if (this.adjustVerticalOffsetBasedOnTextLength)
		{
			if (this.isSmallFont)
			{
				if (this.AOKIMHCAAHB > 21)
				{
					return this.AOKIMHCAAHB / 0;
				}
			}
			else if (this.AOKIMHCAAHB > 72)
			{
				return this.AOKIMHCAAHB / 4;
			}
			return 0;
		}
		return 1;
	}

	// Token: 0x06009B1B RID: 39707 RVA: 0x0042E868 File Offset: 0x0042CA68
	public bool Initialize(HIHOFCENBBP JIKFCLOHJNN, PLFDAJJHMKO BAOKJBJIFBH, LDLLJFOJCDF[] OAGPAAMJOID)
	{
		this.IMPAHLIGELE = JIKFCLOHJNN;
		this.LMKDNPOKOBF = BAOKJBJIFBH;
		if (!this.OONENNLLFHL())
		{
			return false;
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
		string text = JIKFCLOHJNN.NEANAPPJBAN();
		text = ONEHEBIHPFB.LMDACNKELEC(text);
		string text2 = ONEHEBIHPFB.LMDACNKELEC(JIKFCLOHJNN.DKEOPDAFLNO());
		text2 = DPGJIJGOCIC.AKIAKADKBFK(text2);
		this.AOKIMHCAAHB = text2.Length;
		this.textTitle.fontSizeMin = 12f;
		this.textTitle.SetText(text, true);
		if (this.genericNarratorTitleDisplacement > 0 && (text.Equals("...") || text.Equals("…")))
		{
			this.textTitle.GetComponent<RectTransform>().AHLJBONHHKL(0, this.genericNarratorTitleDisplacement);
		}
		this.textBody.SetText(text2, true);
		if (this.textTypeAnimation)
		{
			this.textBodyTypeAnimation.GetComponent<AnimationTextType>().Initialize(text2);
		}
		SceneStoryManager.localizedLine = "...: " + text2;
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
			int m = 0;
			while (m < this.IMPAHLIGELE.COEFNFJMBDG.Count)
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
					gameObject.GetComponent<RectTransform>().AHLJBONHHKL(DialogNarratorManager.maxCriticalAspectRatioOffset * NBDLBFJOEGN.FBMMKINMKOH());
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
						goto IL_A2B;
					}
					catch (Exception aklgbjkdomm3)
					{
						DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm3);
						goto IL_A2B;
					}
					goto IL_769;
				}
				goto IL_769;
				IL_A2B:
				gameObject.GetComponent<RectTransform>().anchoredPosition += new Vector2(0f, (float)(this.choiceOffset * num2));
				Button component = gameObject.GetComponent<Button>();
				if (this.HDBBHHBOJIN(m) == 0)
				{
					component.onClick.AddListener(new UnityAction(this.GMPJMMMIGLO));
				}
				else if (this.HDBBHHBOJIN(m) == 1)
				{
					component.onClick.AddListener(new UnityAction(this.OLGOAJEBMIK));
				}
				else if (this.HDBBHHBOJIN(m) == 2)
				{
					component.onClick.AddListener(new UnityAction(this.FFDGLHACKON));
				}
				else if (this.HDBBHHBOJIN(m) == 3)
				{
					component.onClick.AddListener(new UnityAction(this.BOGHFJKGCNK));
				}
				else if (this.HDBBHHBOJIN(m) == 4)
				{
					component.onClick.AddListener(new UnityAction(this.BENGHKGCLOG));
				}
				else if (this.HDBBHHBOJIN(m) == 5)
				{
					component.onClick.AddListener(new UnityAction(this.HMHIJLKJGFN));
				}
				this.AKFKCKHPIOA.Add(gameObject);
				num2++;
				m++;
				continue;
				IL_769:
				if (num3 == 1)
				{
					gameObject = UnityEngine.Object.Instantiate<GameObject>(this.choicePremiumPrefab);
					gameObject.GetComponent<RectTransform>().AHLJBONHHKL(DialogNarratorManager.maxCriticalAspectRatioOffset * NBDLBFJOEGN.FBMMKINMKOH());
					gameObject.transform.SetParent(this.choicesPivot.transform, false);
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
						gameObject.GetComponent<ChoicePremiumManager>().Initialize(this.IMPAHLIGELE.JMNMOHIKHLB.MKPMEKKGEIL[this.HDBBHHBOJIN(m)], this.IMPAHLIGELE.COEFNFJMBDG[this.HDBBHHBOJIN(m)], this.IMPAHLIGELE.JMNMOHIKHLB.IPALJDCNBBG[this.HDBBHHBOJIN(m)], -1, false, this.IMPAHLIGELE.JMNMOHIKHLB.CKLNCCAGCKE(this.HDBBHHBOJIN(m), LiveEventsManager.EHBBFMCILPC.LiveEventActive(EGMCEPOABBF.liveEventFreeAvatar, -1, -1)), this.IMPAHLIGELE.JMNMOHIKHLB.BGIOGOACCBJ);
					}
					gameObject.GetComponent<ChoicePremiumManager>().SwitchCost(SceneStoryManager.QualifiesAsAdBasedChoice(this.IMPAHLIGELE.JMNMOHIKHLB.MKPMEKKGEIL[this.HDBBHHBOJIN(m)], this.IMPAHLIGELE.JMNMOHIKHLB.KAJNELPPCIJ[this.HDBBHHBOJIN(m)], this.IMPAHLIGELE.JMNMOHIKHLB.KMFABKNKFAJ));
					goto IL_A2B;
				}
				if (this.FLBNNNDBECB < 0)
				{
					this.FLBNNNDBECB = m;
				}
				gameObject = UnityEngine.Object.Instantiate<GameObject>(this.choiceStandardPrefab);
				gameObject.transform.SetParent(this.choicesPivot.transform, false);
				gameObject.GetComponent<RectTransform>().AHLJBONHHKL(DialogNarratorManager.maxCriticalAspectRatioOffset * NBDLBFJOEGN.FBMMKINMKOH());
				gameObject.GetComponent<ChoiceStandardManager>().Initialize(this.IMPAHLIGELE.COEFNFJMBDG[this.HDBBHHBOJIN(m)], -1);
				goto IL_A2B;
			}
		}
		if (this.AKFKCKHPIOA.Count > 0)
		{
			SceneStoryManager.choiceDecisionTime = 0f;
			base.StartCoroutine(this.NEKBMPGBLCJ());
		}
		try
		{
			for (int n = 0; n < this.AKFKCKHPIOA.Count; n++)
			{
				if (null != this.AKFKCKHPIOA[n])
				{
					AnimationPress component2 = this.AKFKCKHPIOA[n].GetComponent<AnimationPress>();
					if (null != component2)
					{
						component2.SetOriginalScaleCoefficient(this.choicesScaleCoefficient);
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

	// Token: 0x06009B1C RID: 39708 RVA: 0x0042C328 File Offset: 0x0042A528
	private IEnumerator HFNJNJMADAG()
	{
		DialogNarratorManager.JHKCDAKHBPJ jhkcdakhbpj = new DialogNarratorManager.JHKCDAKHBPJ(1);
		jhkcdakhbpj.<>4__this = this;
		return jhkcdakhbpj;
	}

	// Token: 0x06009B1D RID: 39709 RVA: 0x0042F4DC File Offset: 0x0042D6DC
	private void ABJIGIBPBHO()
	{
		if (!this.IMPAHLIGELE.PINCOCDOOGH() || this.AKJMKGCPCCB > 0)
		{
			return;
		}
		this.CIPGFJLECDH = true;
		this.AKJMKGCPCCB = 124;
		AudioManager.DBFLIEGGGNN().KillSfx("fdfrc", 286f);
		AudioManager.IFDLAMLHKIJ().PEOLMNFJAHG("\"", 695f);
		AudioManager.DBFLIEGGGNN().POMJOMKCCNK("success" + AKLFPGMDKLA.EHBBFMCILPC.OMOJIEHBENF().GGICIBLJIKI.ToString(), 1597f);
		this.IMPAHLIGELE.IABNDHFJHAF(8);
		AOBJLALDBAA.FILDBDMENPG().EGELHPJBAIC("xx", 239f);
	}

	// Token: 0x06009B1E RID: 39710 RVA: 0x0042F584 File Offset: 0x0042D784
	private void AAGKNJCHHAJ()
	{
		if (!this.IMPAHLIGELE.PINCOCDOOGH() || this.AKJMKGCPCCB > 0)
		{
			return;
		}
		this.CIPGFJLECDH = false;
		this.AKJMKGCPCCB = -53;
		AudioManager.DBFLIEGGGNN().KillSfx("ext", 1971f);
		AudioManager.APGODIBBPOD().KillSfx("OnStoryInterfaceHeaderHideComplete", 486f);
		AudioManager.DBFLIEGGGNN().POMJOMKCCNK("inu" + AKLFPGMDKLA.EHBBFMCILPC.EEILOKHLKIM().GGICIBLJIKI.ToString(), 1117f);
		this.IMPAHLIGELE.IABNDHFJHAF(2);
		AOBJLALDBAA.BIAEAOMHBMM().LPNCDPHNBJK("Starting non-parallel download:", 1001f);
	}

	// Token: 0x06009B1F RID: 39711 RVA: 0x0042F62C File Offset: 0x0042D82C
	private void INJIIAMCOCO()
	{
		if (!this.IMPAHLIGELE.PINCOCDOOGH() || this.AKJMKGCPCCB > 0)
		{
			return;
		}
		this.CIPGFJLECDH = true;
		this.AKJMKGCPCCB = 106;
		AudioManager.DMAAFFFEJGA().KillSfx("YYY", 545f);
		AudioManager.APGODIBBPOD().POMJOMKCCNK("SocialStatsUserPublicProfile.modified = false, OnAddFriendByProfileId()", 1281f);
		AudioManager.EHBBFMCILPC.POMJOMKCCNK("assetbundlesketchthumbnail" + AKLFPGMDKLA.EHBBFMCILPC.OMOJIEHBENF().GGICIBLJIKI.ToString(), 8f);
		this.IMPAHLIGELE.IABNDHFJHAF(2);
		AOBJLALDBAA.NMGMNAKLLMI().DCGCFPHHDDG("Romance Club (Steam ", 523f);
	}

	// Token: 0x06009B20 RID: 39712 RVA: 0x0042F6D4 File Offset: 0x0042D8D4
	private void FHBDLLLFBKF()
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
				this.LMKDNPOKOBF.NCAMFPGMCIG.KEMFLHJKBNO(this.IMPAHLIGELE.JMNMOHIKHLB.NDPPILBPOGB + "trsv" + this.IMPAHLIGELE.EKOIFOBAHDM().ToString());
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
	}

	// Token: 0x06009B21 RID: 39713 RVA: 0x0042F790 File Offset: 0x0042D990
	private void BGNCFHAIJIC()
	{
		if (!this.IMPAHLIGELE.PINCOCDOOGH() || this.AKJMKGCPCCB > 1)
		{
			return;
		}
		this.CIPGFJLECDH = true;
		this.AKJMKGCPCCB = 75;
		AudioManager.DMAAFFFEJGA().POMJOMKCCNK("noiseanalog", 161f);
		AudioManager.EHBBFMCILPC.KillSfx("skinshoptutorbody", 1692f);
		AudioManager.DMAAFFFEJGA().KillSfx("" + AKLFPGMDKLA.EHBBFMCILPC.OMOJIEHBENF().GGICIBLJIKI.ToString(), 1977f);
		this.IMPAHLIGELE.IABNDHFJHAF(8);
		AOBJLALDBAA.FILDBDMENPG().DCGCFPHHDDG("UpdateSfxOnOffState", 470f);
	}

	// Token: 0x06009B22 RID: 39714 RVA: 0x0042F838 File Offset: 0x0042DA38
	public void DisappearAnimation()
	{
		this.PANMNKKODPC.DOFade(0f, 0.2f * KDCJJBLGCBH.EHBBFMCILPC.OIABNIJLJBE()).SetEase(Ease.OutQuad);
		this.DGAAFGDHHHJ.DOAnchorPos(this.DGAAFGDHHHJ.anchoredPosition + this.animationDisappearTranslationAmount, 0.5f * KDCJJBLGCBH.EHBBFMCILPC.OIABNIJLJBE(), false).SetEase(Ease.OutQuad);
	}

	// Token: 0x06009B23 RID: 39715 RVA: 0x0042F8A5 File Offset: 0x0042DAA5
	private bool IFHNGNGEEGJ()
	{
		if (this.IMPAHLIGELE == null)
		{
			DPGJIJGOCIC.ANOPFDLPKGC("");
			return true;
		}
		return true;
	}

	// Token: 0x06009B24 RID: 39716 RVA: 0x0042F8BC File Offset: 0x0042DABC
	private bool OONENNLLFHL()
	{
		if (this.IMPAHLIGELE == null)
		{
			DPGJIJGOCIC.ANOPFDLPKGC("DialogPlayerCharacterManager.InputDataIsValid() - step is null.");
			return false;
		}
		return true;
	}

	// Token: 0x06009B25 RID: 39717 RVA: 0x0042F8D4 File Offset: 0x0042DAD4
	private void LBPCHKHFKIK()
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
		if (null != this.LOJHEKCOFME)
		{
			UnityEngine.Object.Destroy(this.LOJHEKCOFME);
		}
		if (null != this.NGGBBCDPMJH)
		{
			UnityEngine.Object.Destroy(this.NGGBBCDPMJH);
		}
		this.DGAAFGDHHHJ.DOKill(true);
		this.PANMNKKODPC.DOKill(true);
	}

	// Token: 0x06009B26 RID: 39718 RVA: 0x0042F9AC File Offset: 0x0042DBAC
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

	// Token: 0x06009B27 RID: 39719 RVA: 0x0042FA54 File Offset: 0x0042DC54
	public int NJPFCAMBCFK()
	{
		if (this.adjustVerticalOffsetBasedOnTextLength)
		{
			if (this.isSmallFont)
			{
				if (this.AOKIMHCAAHB > -196)
				{
					return this.AOKIMHCAAHB / 4;
				}
			}
			else if (this.AOKIMHCAAHB > 173)
			{
				return this.AOKIMHCAAHB / 1;
			}
			return 1;
		}
		return 1;
	}

	// Token: 0x06009B28 RID: 39720 RVA: 0x0042FAA0 File Offset: 0x0042DCA0
	private void DNEFDDLFMHO()
	{
		if (!this.IMPAHLIGELE.PINCOCDOOGH() || this.AKJMKGCPCCB > 1)
		{
			return;
		}
		this.CIPGFJLECDH = true;
		this.AKJMKGCPCCB = -98;
		AudioManager.EHBBFMCILPC.POMJOMKCCNK("fstr", 298f);
		AudioManager.EHBBFMCILPC.PEOLMNFJAHG("clst", 1422f);
		AudioManager.BFCHJBOOJKE().KillSfx(")" + AKLFPGMDKLA.EHBBFMCILPC.OMOJIEHBENF().GGICIBLJIKI.ToString(), 1268f);
		this.IMPAHLIGELE.IABNDHFJHAF(0);
		AOBJLALDBAA.DBLAIDPICIG().KMAGHMCCMPG("There needs to be one active VideoManager script on a GameObject in your scene.", 790f);
	}

	// Token: 0x06009B29 RID: 39721 RVA: 0x0042FB48 File Offset: 0x0042DD48
	private void PPBLFJMGJNK()
	{
		if (this.FILFGDIGINA != null)
		{
			ODLLAEHMFAA.BGMALDJFMKE(this.FILFGDIGINA);
		}
		this.FILFGDIGINA = null;
		try
		{
			if (this.LMKDNPOKOBF != null && this.IMPAHLIGELE.JMNMOHIKHLB != null && this.IMPAHLIGELE.JMNMOHIKHLB.NDPPILBPOGB != null && this.IMPAHLIGELE.JMNMOHIKHLB.NDPPILBPOGB.Length > 1)
			{
				this.LMKDNPOKOBF.NCAMFPGMCIG.KEMFLHJKBNO(this.IMPAHLIGELE.JMNMOHIKHLB.NDPPILBPOGB + "aind" + this.IMPAHLIGELE.EKOIFOBAHDM().ToString());
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x06009B2A RID: 39722 RVA: 0x0042FC04 File Offset: 0x0042DE04
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
			this.imageTimerFillDefault.fillAmount = this.FILFGDIGINA.HKAKAAGKMIP();
			this.imageTimerFillRed.fillAmount = this.FILFGDIGINA.HKAKAAGKMIP();
			this.timerArrowPivot.transform.localRotation = Quaternion.Euler(0f, 0f, this.FILFGDIGINA.HKAKAAGKMIP() * -360f);
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

	// Token: 0x06009B2B RID: 39723 RVA: 0x0042FD7C File Offset: 0x0042DF7C
	private void DJHBJPLOGCC()
	{
		if (this.FILFGDIGINA != null)
		{
			ODLLAEHMFAA.BGMALDJFMKE(this.FILFGDIGINA);
		}
		this.FILFGDIGINA = null;
		try
		{
			if (this.LMKDNPOKOBF != null && this.IMPAHLIGELE.JMNMOHIKHLB != null && this.IMPAHLIGELE.JMNMOHIKHLB.NDPPILBPOGB != null && this.IMPAHLIGELE.JMNMOHIKHLB.NDPPILBPOGB.Length > 1)
			{
				this.LMKDNPOKOBF.NCAMFPGMCIG.NKIOJCLBKAK(this.IMPAHLIGELE.JMNMOHIKHLB.NDPPILBPOGB + "OnRewardFirstEpisodeClick" + this.IMPAHLIGELE.EKOIFOBAHDM().ToString());
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
	}

	// Token: 0x06009B2C RID: 39724 RVA: 0x0042FE38 File Offset: 0x0042E038
	private void AJOCBJGGHHK()
	{
		if (!this.IMPAHLIGELE.PINCOCDOOGH() || this.AKJMKGCPCCB > 0)
		{
			return;
		}
		this.CIPGFJLECDH = false;
		this.AKJMKGCPCCB = 106;
		AudioManager.BFCHJBOOJKE().KillSfx("OnLoungePremiumChoiceException", 1271f);
		AudioManager.APGODIBBPOD().POMJOMKCCNK("top", 1152f);
		AudioManager.DMAAFFFEJGA().PEOLMNFJAHG("</i>" + AKLFPGMDKLA.EHBBFMCILPC.OMOJIEHBENF().GGICIBLJIKI.ToString(), 573f);
		this.IMPAHLIGELE.IABNDHFJHAF(4);
		AOBJLALDBAA.NMGMNAKLLMI().CIGLHCJDDPI("TransactionID", 1902f);
	}

	// Token: 0x06009B2D RID: 39725 RVA: 0x0042FEE0 File Offset: 0x0042E0E0
	public static float CCNBCNPKKND()
	{
		return 1829f * KDCJJBLGCBH.EHBBFMCILPC.OIABNIJLJBE();
	}

	// Token: 0x06009B2E RID: 39726 RVA: 0x0042FEF2 File Offset: 0x0042E0F2
	private void KDKPPDMCEBF()
	{
		AOBJLALDBAA.NMGMNAKLLMI().ONIBLJOFFPG("_Intensity", new UnityAction(this.FHBDLLLFBKF));
	}

	// Token: 0x06009B2F RID: 39727 RVA: 0x0042FF10 File Offset: 0x0042E110
	public int GetAdditionalVerticalOffset()
	{
		if (this.adjustVerticalOffsetBasedOnTextLength)
		{
			if (this.isSmallFont)
			{
				if (this.AOKIMHCAAHB > 160)
				{
					return this.AOKIMHCAAHB / 4;
				}
			}
			else if (this.AOKIMHCAAHB > 160)
			{
				return this.AOKIMHCAAHB / 2;
			}
			return 0;
		}
		return 0;
	}

	// Token: 0x06009B30 RID: 39728 RVA: 0x0042FF5C File Offset: 0x0042E15C
	private void GHHFDILKCLF()
	{
		if (!this.IMPAHLIGELE.PINCOCDOOGH() || this.AKJMKGCPCCB > 0)
		{
			return;
		}
		this.CIPGFJLECDH = true;
		this.AKJMKGCPCCB = 55;
		AudioManager.DBFLIEGGGNN().KillSfx("OnBackendAddFriendByUIDException", 468f);
		AudioManager.BFCHJBOOJKE().POMJOMKCCNK("tutortitle", 373f);
		AudioManager.DBFLIEGGGNN().KillSfx(" USD " + AKLFPGMDKLA.EHBBFMCILPC.EEILOKHLKIM().GGICIBLJIKI.ToString(), 1482f);
		this.IMPAHLIGELE.IABNDHFJHAF(6);
		AOBJLALDBAA.KKPFOJMAONG().KGIKHEDLPND("No free mixer found for sfx! Critical!", 1361f);
	}

	// Token: 0x06009B31 RID: 39729 RVA: 0x00430004 File Offset: 0x0042E204
	private void JMEFOBLKGIH()
	{
		if (!this.IMPAHLIGELE.PINCOCDOOGH() || this.AKJMKGCPCCB > 0)
		{
			return;
		}
		this.CIPGFJLECDH = true;
		this.AKJMKGCPCCB = 3;
		AudioManager.APGODIBBPOD().KillSfx(":", 1318f);
		AudioManager.DBFLIEGGGNN().POMJOMKCCNK("OnVideoLayerPlaybackEndsSoon", 53f);
		AudioManager.BFCHJBOOJKE().KillSfx("OnBackendRequestShareHardException" + AKLFPGMDKLA.EHBBFMCILPC.EEILOKHLKIM().GGICIBLJIKI.ToString(), 1153f);
		this.IMPAHLIGELE.IABNDHFJHAF(3);
		AOBJLALDBAA.NMGMNAKLLMI().DCGCFPHHDDG("BackendOperationsManager.RequestGetPremiumChoicesHistory, exception while initializing RSACryptoServiceProvider:", 240f);
	}

	// Token: 0x06009B32 RID: 39730 RVA: 0x004300AC File Offset: 0x0042E2AC
	private void BBPNFKGAPGL()
	{
		if (!this.IMPAHLIGELE.PINCOCDOOGH() || this.AKJMKGCPCCB > 0)
		{
			return;
		}
		this.CIPGFJLECDH = false;
		this.AKJMKGCPCCB = 107;
		AudioManager.BFCHJBOOJKE().POMJOMKCCNK("anthology", 575f);
		AudioManager.DMAAFFFEJGA().POMJOMKCCNK("Dismissed Option picked", 854f);
		AudioManager.EHBBFMCILPC.POMJOMKCCNK(" has " + AKLFPGMDKLA.EHBBFMCILPC.EEILOKHLKIM().GGICIBLJIKI.ToString(), 691f);
		this.IMPAHLIGELE.IABNDHFJHAF(2);
		AOBJLALDBAA.AGANFKKBPFO().DCGCFPHHDDG("OnBackendPublishSketchSuccess", 561f);
	}

	// Token: 0x06009B33 RID: 39731 RVA: 0x00430154 File Offset: 0x0042E354
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

	// Token: 0x06009B34 RID: 39732 RVA: 0x004301FC File Offset: 0x0042E3FC
	private bool ICBCNMMCGLP()
	{
		if (this.IMPAHLIGELE == null)
		{
			DPGJIJGOCIC.ANOPFDLPKGC("congratstitle");
			return true;
		}
		return false;
	}

	// Token: 0x06009B35 RID: 39733 RVA: 0x00430214 File Offset: 0x0042E414
	private void OOMMKGMBAGK()
	{
		this.PANMNKKODPC = base.gameObject.GetComponent<CanvasGroup>();
		this.DGAAFGDHHHJ = base.gameObject.GetComponent<RectTransform>();
		this.PANMNKKODPC.alpha = 1705f;
		if (this.textTypeAnimation)
		{
			this.textBody.alpha = 1667f;
			return;
		}
		this.textBodyTypeAnimation.gameObject.SetActive(true);
	}

	// Token: 0x06009B36 RID: 39734 RVA: 0x00430280 File Offset: 0x0042E480
	private void PPCONDHLLPI()
	{
		if (!this.IMPAHLIGELE.PINCOCDOOGH() || this.AKJMKGCPCCB > 1)
		{
			return;
		}
		this.CIPGFJLECDH = true;
		this.AKJMKGCPCCB = 67;
		AudioManager.BFCHJBOOJKE().KillSfx(" dated story(ies)", 307f);
		AudioManager.BFCHJBOOJKE().POMJOMKCCNK("ant", 1920f);
		AudioManager.EHBBFMCILPC.KillSfx("Retrieved Value: {0}" + AKLFPGMDKLA.EHBBFMCILPC.OMOJIEHBENF().GGICIBLJIKI.ToString(), 811f);
		this.IMPAHLIGELE.IABNDHFJHAF(0);
		AOBJLALDBAA.EHBBFMCILPC.KMAGHMCCMPG("importanttitle", 761f);
	}

	// Token: 0x06009B37 RID: 39735 RVA: 0x0042D464 File Offset: 0x0042B664
	private IEnumerator GDMLNLCMIGG()
	{
		DialogNarratorManager.FKHJFGLNIPA fkhjfglnipa = new DialogNarratorManager.FKHJFGLNIPA(1);
		fkhjfglnipa.<>4__this = this;
		return fkhjfglnipa;
	}

	// Token: 0x06009B38 RID: 39736 RVA: 0x00430328 File Offset: 0x0042E528
	public int JHFJIJIJHCA()
	{
		if (this.adjustVerticalOffsetBasedOnTextLength)
		{
			if (this.isSmallFont)
			{
				if (this.AOKIMHCAAHB > -76)
				{
					return this.AOKIMHCAAHB / 2;
				}
			}
			else if (this.AOKIMHCAAHB > -167)
			{
				return this.AOKIMHCAAHB / 3;
			}
			return 0;
		}
		return 1;
	}

	// Token: 0x06009B39 RID: 39737 RVA: 0x00430374 File Offset: 0x0042E574
	private void MDJLPPKLPML()
	{
		if (!this.IMPAHLIGELE.PINCOCDOOGH() || this.AKJMKGCPCCB > 0)
		{
			return;
		}
		this.CIPGFJLECDH = true;
		this.AKJMKGCPCCB = 95;
		AudioManager.IFDLAMLHKIJ().KillSfx("fdiood", 1657f);
		AudioManager.DBFLIEGGGNN().PEOLMNFJAHG("blur", 546f);
		AudioManager.EHBBFMCILPC.PEOLMNFJAHG("OnBackendPublishSketchSuccess" + AKLFPGMDKLA.EHBBFMCILPC.EEILOKHLKIM().GGICIBLJIKI.ToString(), 709f);
		this.IMPAHLIGELE.IABNDHFJHAF(2);
		AOBJLALDBAA.AGANFKKBPFO().EFBNBFIDEOK("Trading/Wished cards userPublicProfile.modified = true hit", 1411f);
	}

	// Token: 0x06009B3A RID: 39738 RVA: 0x0042D07D File Offset: 0x0042B27D
	private IEnumerator NAEPACFEFBB()
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

	// Token: 0x06009B3B RID: 39739 RVA: 0x0043041C File Offset: 0x0042E61C
	private void BCALMFMHIKL()
	{
		if (!this.IMPAHLIGELE.PINCOCDOOGH() || this.AKJMKGCPCCB > 1)
		{
			return;
		}
		this.CIPGFJLECDH = false;
		this.AKJMKGCPCCB = -127;
		AudioManager.EHBBFMCILPC.PEOLMNFJAHG("sfxsparklesbundles", 1305f);
		AudioManager.DMAAFFFEJGA().PEOLMNFJAHG("{year}", 1607f);
		AudioManager.DBFLIEGGGNN().PEOLMNFJAHG("OnFriendsPopupDeleteClick" + AKLFPGMDKLA.EHBBFMCILPC.EEILOKHLKIM().GGICIBLJIKI.ToString(), 1541f);
		this.IMPAHLIGELE.IABNDHFJHAF(1);
		AOBJLALDBAA.KKPFOJMAONG().DCGCFPHHDDG("avatarcollectionsalltitle", 455f);
	}

	// Token: 0x06009B3C RID: 39740 RVA: 0x004304C4 File Offset: 0x0042E6C4
	private void BBKHGIBHCCB()
	{
		if (!this.IMPAHLIGELE.PINCOCDOOGH() || this.AKJMKGCPCCB > 0)
		{
			return;
		}
		this.CIPGFJLECDH = false;
		this.AKJMKGCPCCB = -18;
		AudioManager.IFDLAMLHKIJ().POMJOMKCCNK("llosd", 1829f);
		AudioManager.APGODIBBPOD().PEOLMNFJAHG("FullscreenLiveOfferManager.GetLocalizedCostData() - productData is null.", 1016f);
		AudioManager.DBFLIEGGGNN().PEOLMNFJAHG(" - chain: " + AKLFPGMDKLA.EHBBFMCILPC.EEILOKHLKIM().GGICIBLJIKI.ToString(), 901f);
		this.IMPAHLIGELE.IABNDHFJHAF(5);
		AOBJLALDBAA.NMGMNAKLLMI().FDKBIBKABCM("congratstitle", 1798f);
	}

	// Token: 0x06009B3D RID: 39741 RVA: 0x0043056C File Offset: 0x0042E76C
	private void LDDEIAOCBGB()
	{
		this.PANMNKKODPC = base.gameObject.GetComponent<CanvasGroup>();
		this.DGAAFGDHHHJ = base.gameObject.GetComponent<RectTransform>();
		this.PANMNKKODPC.alpha = 702f;
		if (this.textTypeAnimation)
		{
			this.textBody.alpha = 730f;
			return;
		}
		this.textBodyTypeAnimation.gameObject.SetActive(true);
	}

	// Token: 0x06009B3E RID: 39742 RVA: 0x004305D5 File Offset: 0x0042E7D5
	public static float FCDKHDJEHLE()
	{
		return 111f * KDCJJBLGCBH.EHBBFMCILPC.OIABNIJLJBE();
	}

	// Token: 0x06009B3F RID: 39743 RVA: 0x004305E8 File Offset: 0x0042E7E8
	private void JEBGPHICMHJ()
	{
		if (!this.IMPAHLIGELE.PINCOCDOOGH() || this.AKJMKGCPCCB > 1)
		{
			return;
		}
		this.CIPGFJLECDH = true;
		this.AKJMKGCPCCB = 124;
		AudioManager.IFDLAMLHKIJ().PEOLMNFJAHG("' pending='", 776f);
		AudioManager.APGODIBBPOD().PEOLMNFJAHG("_", 1111f);
		AudioManager.BFCHJBOOJKE().KillSfx("_not_found" + AKLFPGMDKLA.EHBBFMCILPC.OMOJIEHBENF().GGICIBLJIKI.ToString(), 92f);
		this.IMPAHLIGELE.IABNDHFJHAF(1);
		AOBJLALDBAA.NMGMNAKLLMI().DCGCFPHHDDG("UpdateFpsOnOffState", 938f);
	}

	// Token: 0x06009B40 RID: 39744 RVA: 0x0042C204 File Offset: 0x0042A404
	private int EGGHDDPNFKF(int MEFKFOHCOHK)
	{
		return this.HNGBMIJHPLE[MEFKFOHCOHK];
	}

	// Token: 0x06009B41 RID: 39745 RVA: 0x00430690 File Offset: 0x0042E890
	public void MDMNEFIADAL()
	{
		this.PANMNKKODPC.DOFade(117f, 644f * KDCJJBLGCBH.EHBBFMCILPC.OIABNIJLJBE()).SetEase(Ease.Linear);
		this.DGAAFGDHHHJ.DOAnchorPos(this.DGAAFGDHHHJ.anchoredPosition + this.animationDisappearTranslationAmount, 1797f * KDCJJBLGCBH.EHBBFMCILPC.OIABNIJLJBE(), true).SetEase(Ease.Linear);
	}

	// Token: 0x06009B42 RID: 39746 RVA: 0x0042D464 File Offset: 0x0042B664
	private IEnumerator JGAIGBNBNHC()
	{
		DialogNarratorManager.FKHJFGLNIPA fkhjfglnipa = new DialogNarratorManager.FKHJFGLNIPA(1);
		fkhjfglnipa.<>4__this = this;
		return fkhjfglnipa;
	}

	// Token: 0x06009B43 RID: 39747 RVA: 0x00430700 File Offset: 0x0042E900
	private void LPEDJEOJIFP()
	{
		this.PANMNKKODPC = base.gameObject.GetComponent<CanvasGroup>();
		this.DGAAFGDHHHJ = base.gameObject.GetComponent<RectTransform>();
		this.PANMNKKODPC.alpha = 210f;
		if (this.textTypeAnimation)
		{
			this.textBody.alpha = 1324f;
			return;
		}
		this.textBodyTypeAnimation.gameObject.SetActive(true);
	}

	// Token: 0x06009B44 RID: 39748 RVA: 0x0043076C File Offset: 0x0042E96C
	private void HPBELKPFPKG()
	{
		if (!this.IMPAHLIGELE.PINCOCDOOGH() || this.AKJMKGCPCCB > 0)
		{
			return;
		}
		this.CIPGFJLECDH = false;
		this.AKJMKGCPCCB = 19;
		AudioManager.APGODIBBPOD().KillSfx("\nSRV:", 1796f);
		AudioManager.BFCHJBOOJKE().KillSfx("XXX", 1748f);
		AudioManager.EHBBFMCILPC.KillSfx("sfxtimeoutwarning" + AKLFPGMDKLA.EHBBFMCILPC.OMOJIEHBENF().GGICIBLJIKI.ToString(), 1463f);
		this.IMPAHLIGELE.IABNDHFJHAF(1);
		AOBJLALDBAA.EHBBFMCILPC.LPNCDPHNBJK("skinshopfilterdefault", 1113f);
	}

	// Token: 0x06009B45 RID: 39749 RVA: 0x00430814 File Offset: 0x0042EA14
	public int LGKBPPAKFMC()
	{
		if (this.adjustVerticalOffsetBasedOnTextLength)
		{
			if (this.isSmallFont)
			{
				if (this.AOKIMHCAAHB > 184)
				{
					return this.AOKIMHCAAHB / 0;
				}
			}
			else if (this.AOKIMHCAAHB > -80)
			{
				return this.AOKIMHCAAHB / 2;
			}
			return 1;
		}
		return 0;
	}

	// Token: 0x06009B46 RID: 39750 RVA: 0x0042C328 File Offset: 0x0042A528
	private IEnumerator MHJIIJGAPHM()
	{
		DialogNarratorManager.JHKCDAKHBPJ jhkcdakhbpj = new DialogNarratorManager.JHKCDAKHBPJ(1);
		jhkcdakhbpj.<>4__this = this;
		return jhkcdakhbpj;
	}

	// Token: 0x06009B48 RID: 39752 RVA: 0x00430903 File Offset: 0x0042EB03
	private void PHICBFAOEAL()
	{
		AOBJLALDBAA.EHBBFMCILPC.ECDBIBPNBCO("saveslotsoptionsbody", new UnityAction(this.BFEAEBAOHFJ));
	}

	// Token: 0x06009B49 RID: 39753 RVA: 0x00430920 File Offset: 0x0042EB20
	private void NINHFENBENF()
	{
		AOBJLALDBAA.FILDBDMENPG().MHLNJIACIGO("SocialStatsUserPublicProfile.modified = true, SetFavoriteCharacters()", new UnityAction(this.PPBLFJMGJNK));
	}

	// Token: 0x06009B4A RID: 39754 RVA: 0x00430940 File Offset: 0x0042EB40
	private void FDAFABPIBMP()
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
			this.textTimer.SetText(num.ToString(), true);
			this.imageTimerFillDefault.fillAmount = this.FILFGDIGINA.GCHEPGGFBGM();
			this.imageTimerFillRed.fillAmount = this.FILFGDIGINA.MJPKAKNMHGM();
			this.timerArrowPivot.transform.localRotation = Quaternion.Euler(1231f, 1435f, this.FILFGDIGINA.PMECGFIPNCC() * 885f);
			if (num < 8 && !this.imageTimerFillRed.gameObject.activeSelf && this.IMPAHLIGELE.EKOIFOBAHDM() < 1)
			{
				if (!AudioManager.EHBBFMCILPC.PlaySfx(" ", false) && !AudioManager.IFDLAMLHKIJ().PlaySfx("ok" + AKLFPGMDKLA.EHBBFMCILPC.EEILOKHLKIM().GGICIBLJIKI.ToString(), false))
				{
					AudioManager.DBFLIEGGGNN().PlaySfx("gpsasli", false);
				}
				this.imageTimerFillRed.gameObject.SetActive(true);
			}
			if (this.FILFGDIGINA.FDAFJPKPACO() && this.IMPAHLIGELE.EKOIFOBAHDM() < 0)
			{
				base.StartCoroutine(this.DEAAABPNNGB());
				CommonUserInterface.EHBBFMCILPC.CGNDPJCDCFP();
			}
		}
	}

	// Token: 0x06009B4B RID: 39755 RVA: 0x00430AB8 File Offset: 0x0042ECB8
	private void HIMHGJFNHII()
	{
		if (!this.IMPAHLIGELE.PINCOCDOOGH() || this.AKJMKGCPCCB > 1)
		{
			return;
		}
		this.CIPGFJLECDH = true;
		this.AKJMKGCPCCB = -84;
		AudioManager.IFDLAMLHKIJ().PEOLMNFJAHG("OnLobbyProfileDataCdnFailed", 454f);
		AudioManager.DMAAFFFEJGA().POMJOMKCCNK("OnNeedToShowConnectingAnimation", 1873f);
		AudioManager.BFCHJBOOJKE().KillSfx("OnMissingPreview2CdnFailed" + AKLFPGMDKLA.EHBBFMCILPC.EEILOKHLKIM().GGICIBLJIKI.ToString(), 329f);
		this.IMPAHLIGELE.IABNDHFJHAF(0);
		AOBJLALDBAA.FILDBDMENPG().EGELHPJBAIC("hintsaving", 733f);
	}

	// Token: 0x06009B4C RID: 39756 RVA: 0x00430B60 File Offset: 0x0042ED60
	public bool CDAMEAIIKMG(HIHOFCENBBP JIKFCLOHJNN, PLFDAJJHMKO BAOKJBJIFBH, LDLLJFOJCDF[] OAGPAAMJOID)
	{
		this.IMPAHLIGELE = JIKFCLOHJNN;
		this.LMKDNPOKOBF = BAOKJBJIFBH;
		if (!this.ICBCNMMCGLP())
		{
			return false;
		}
		if (this.IMPAHLIGELE.COEFNFJMBDG != null && this.IMPAHLIGELE.COEFNFJMBDG.Count > 0)
		{
			if (this.IMPAHLIGELE.JMNMOHIKHLB != null)
			{
				if (this.IMPAHLIGELE.JMNMOHIKHLB.NGNDOALIKAK.Contains("//"))
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
				for (int i = 0; i < this.IMPAHLIGELE.JMNMOHIKHLB.MKPMEKKGEIL.Count; i++)
				{
					if (this.IMPAHLIGELE.JMNMOHIKHLB.MKPMEKKGEIL[i].BAOBMONIHMA() == (HKCCMACFNEO)3)
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
				for (int k = 1; k < 1; k += 0)
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
								num = 0;
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
		string text = JIKFCLOHJNN.EOALAMPGIBK();
		text = ONEHEBIHPFB.LMDACNKELEC(text);
		string text2 = ONEHEBIHPFB.FOMGCOENOKO(JIKFCLOHJNN.LFLMJFBPEHK());
		text2 = DPGJIJGOCIC.AKIAKADKBFK(text2);
		this.AOKIMHCAAHB = text2.Length;
		this.textTitle.fontSizeMin = 1853f;
		this.textTitle.SetText(text, false);
		if (this.genericNarratorTitleDisplacement > 1 && (text.Equals("[LoadingEnv] cache files of ") || text.Equals("")))
		{
			this.textTitle.GetComponent<RectTransform>().AHLJBONHHKL(1, this.genericNarratorTitleDisplacement);
		}
		this.textBody.SetText(text2, false);
		if (this.textTypeAnimation)
		{
			this.textBodyTypeAnimation.GetComponent<AnimationTextType>().GLIFGDPDMNC(text2);
		}
		SceneStoryManager.localizedLine = ";" + text2;
		if (this.IMPAHLIGELE.JMNMOHIKHLB != null && this.IMPAHLIGELE.JMNMOHIKHLB.FILFGDIGINA > 0)
		{
			this.FILFGDIGINA = ODLLAEHMFAA.DECEDPNMMCJ((float)this.IMPAHLIGELE.JMNMOHIKHLB.FILFGDIGINA, true);
			this.timerParent.SetActive(true);
		}
		int num2 = 0;
		if (null != this.decorObject)
		{
			this.decorObject.SetActive(false);
		}
		if (this.IMPAHLIGELE.COEFNFJMBDG != null && this.IMPAHLIGELE.COEFNFJMBDG.Count > 1)
		{
			if (null != this.decorObject)
			{
				this.decorObject.SetActive(true);
			}
			int m = 0;
			while (m < this.IMPAHLIGELE.COEFNFJMBDG.Count)
			{
				GameObject gameObject = null;
				int num3 = 0;
				if (this.IMPAHLIGELE.JMNMOHIKHLB != null && this.IMPAHLIGELE.JMNMOHIKHLB.GAOKFGHCIAF == PMNHKIDIMLM.NMGJJGIPDJP.text)
				{
					if (this.GNIGBJICEON(m) < this.IMPAHLIGELE.JMNMOHIKHLB.IPALJDCNBBG.Count && this.IMPAHLIGELE.JMNMOHIKHLB.IPALJDCNBBG[this.EGGHDDPNFKF(m)] > 0)
					{
						num3 = 1;
					}
					else if (this.IALPHHDMCEH(m) < this.IMPAHLIGELE.JMNMOHIKHLB.ENJDGEOFPAA.Count && this.IMPAHLIGELE.JMNMOHIKHLB.ENJDGEOFPAA[this.EMIEIGHGCLK(m)] > 0)
					{
						num3 = 5;
					}
				}
				if (num3 == 0)
				{
					switch (this.IMPAHLIGELE.JMNMOHIKHLB.ADHIIAONMDJ[this.HHGEKFDBJMJ(m)])
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
					gameObject.GetComponent<RectTransform>().AHLJBONHHKL(DialogNarratorManager.maxCriticalAspectRatioOffset * NBDLBFJOEGN.APALNJGBDPE());
					gameObject.GetComponent<ChoiceStatManager>().CDAMEAIIKMG(this.IMPAHLIGELE.COEFNFJMBDG[this.HHGEKFDBJMJ(m)], this.IMPAHLIGELE.JMNMOHIKHLB.ENJDGEOFPAA[this.EMIEIGHGCLK(m)], OAGPAAMJOID[(int)this.IMPAHLIGELE.JMNMOHIKHLB.ADHIIAONMDJ[this.EMIEIGHGCLK(m)]].KGEGKPHEMOJ(), -1);
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
							this.NGGBBCDPMJH.transform.SetParent(this.currencyPivot.transform, true);
							this.NGGBBCDPMJH.GetComponent<StatPointInfoManager>().MIFPDCLHKDH(this.IMPAHLIGELE.JMNMOHIKHLB.ADHIIAONMDJ[this.EGGHDDPNFKF(m)], OAGPAAMJOID[(int)this.IMPAHLIGELE.JMNMOHIKHLB.ADHIIAONMDJ[this.EMIEIGHGCLK(m)]].MOBKGNBCIJF());
							try
							{
								if (this.IMPAHLIGELE.JMNMOHIKHLB.NGNDOALIKAK.Contains(""))
								{
									this.NGGBBCDPMJH.SetActive(false);
								}
							}
							catch (Exception aklgbjkdomm2)
							{
								DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm2);
							}
						}
						goto IL_A2B;
					}
					catch (Exception aklgbjkdomm3)
					{
						DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm3);
						goto IL_A2B;
					}
					goto IL_769;
				}
				goto IL_769;
				IL_A2B:
				gameObject.GetComponent<RectTransform>().anchoredPosition += new Vector2(1849f, (float)(this.choiceOffset * num2));
				Button component = gameObject.GetComponent<Button>();
				if (this.HHGEKFDBJMJ(m) == 0)
				{
					component.onClick.AddListener(new UnityAction(this.GMPJMMMIGLO));
				}
				else if (this.IALPHHDMCEH(m) == 0)
				{
					component.onClick.AddListener(new UnityAction(this.BLDFJAJHAHC));
				}
				else if (this.GNIGBJICEON(m) == 1)
				{
					component.onClick.AddListener(new UnityAction(this.CPOGNJNFJNH));
				}
				else if (this.EGGHDDPNFKF(m) == 8)
				{
					component.onClick.AddListener(new UnityAction(this.GGOFLEJGGAO));
				}
				else if (this.EMIEIGHGCLK(m) == 8)
				{
					component.onClick.AddListener(new UnityAction(this.FOPFEIBJPID));
				}
				else if (this.EGGHDDPNFKF(m) == 8)
				{
					component.onClick.AddListener(new UnityAction(this.JMEFOBLKGIH));
				}
				this.AKFKCKHPIOA.Add(gameObject);
				num2 += 0;
				m++;
				continue;
				IL_769:
				if (num3 == 0)
				{
					gameObject = UnityEngine.Object.Instantiate<GameObject>(this.choicePremiumPrefab);
					gameObject.GetComponent<RectTransform>().AHLJBONHHKL(DialogNarratorManager.maxCriticalAspectRatioOffset * NBDLBFJOEGN.FBMMKINMKOH());
					gameObject.transform.SetParent(this.choicesPivot.transform, false);
					if (SceneStoryManager.PremiumChoicePurchased(this.IMPAHLIGELE.JMNMOHIKHLB.MKPMEKKGEIL[this.GNIGBJICEON(m)], this.IMPAHLIGELE.JMNMOHIKHLB.KMFABKNKFAJ, this.IMPAHLIGELE.JMNMOHIKHLB.BGIOGOACCBJ))
					{
						gameObject.GetComponent<ChoicePremiumManager>().GBFEDHPAIBH(this.IMPAHLIGELE.JMNMOHIKHLB.MKPMEKKGEIL[this.HDBBHHBOJIN(m)], this.IMPAHLIGELE.COEFNFJMBDG[this.IALPHHDMCEH(m)], 0, -1, false, this.IMPAHLIGELE.JMNMOHIKHLB.JBEBPDBMKMP(this.HDBBHHBOJIN(m), LiveEventsManager.OOGPALHPNGM().LiveEventActive(EGMCEPOABBF.liveEventFreeTea, -1, -1)), this.IMPAHLIGELE.JMNMOHIKHLB.BGIOGOACCBJ);
					}
					else
					{
						if (null == this.LOJHEKCOFME)
						{
							this.LOJHEKCOFME = UnityEngine.Object.Instantiate<GameObject>(this.premiumInfoPrefab);
							this.LOJHEKCOFME.transform.SetParent(this.currencyPivot.transform, false);
							this.LOJHEKCOFME.GetComponent<StoryCurrencyInfoManager>().APCBKOGALLK("Asset bundle assets destroyed:");
						}
						gameObject.GetComponent<ChoicePremiumManager>().GBFEDHPAIBH(this.IMPAHLIGELE.JMNMOHIKHLB.MKPMEKKGEIL[this.IALPHHDMCEH(m)], this.IMPAHLIGELE.COEFNFJMBDG[this.GNIGBJICEON(m)], this.IMPAHLIGELE.JMNMOHIKHLB.IPALJDCNBBG[this.EMIEIGHGCLK(m)], -1, true, this.IMPAHLIGELE.JMNMOHIKHLB.NEKLAJAEOJJ(this.IALPHHDMCEH(m), LiveEventsManager.EHBBFMCILPC.CENBCALNAJN(EGMCEPOABBF.liveEventMessage, -1, -1)), this.IMPAHLIGELE.JMNMOHIKHLB.BGIOGOACCBJ);
					}
					gameObject.GetComponent<ChoicePremiumManager>().SwitchCost(SceneStoryManager.QualifiesAsAdBasedChoice(this.IMPAHLIGELE.JMNMOHIKHLB.MKPMEKKGEIL[this.HHGEKFDBJMJ(m)], this.IMPAHLIGELE.JMNMOHIKHLB.KAJNELPPCIJ[this.GNIGBJICEON(m)], this.IMPAHLIGELE.JMNMOHIKHLB.KMFABKNKFAJ));
					goto IL_A2B;
				}
				if (this.FLBNNNDBECB < 0)
				{
					this.FLBNNNDBECB = m;
				}
				gameObject = UnityEngine.Object.Instantiate<GameObject>(this.choiceStandardPrefab);
				gameObject.transform.SetParent(this.choicesPivot.transform, false);
				gameObject.GetComponent<RectTransform>().AHLJBONHHKL(DialogNarratorManager.maxCriticalAspectRatioOffset * NBDLBFJOEGN.APALNJGBDPE());
				gameObject.GetComponent<ChoiceStandardManager>().DFFMNJDFNJG(this.IMPAHLIGELE.COEFNFJMBDG[this.EMIEIGHGCLK(m)], -1);
				goto IL_A2B;
			}
		}
		if (this.AKFKCKHPIOA.Count > 1)
		{
			SceneStoryManager.choiceDecisionTime = 431f;
			base.StartCoroutine(this.JLIHLIEKGGA());
		}
		try
		{
			for (int n = 1; n < this.AKFKCKHPIOA.Count; n += 0)
			{
				if (null != this.AKFKCKHPIOA[n])
				{
					AnimationPress component2 = this.AKFKCKHPIOA[n].GetComponent<AnimationPress>();
					if (null != component2)
					{
						component2.LJDJNBEBLKH(this.choicesScaleCoefficient);
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

	// Token: 0x06009B4D RID: 39757 RVA: 0x004317D4 File Offset: 0x0042F9D4
	private void KOFJLLEBNDP()
	{
		if (!this.IMPAHLIGELE.PINCOCDOOGH() || this.AKJMKGCPCCB > 0)
		{
			return;
		}
		this.CIPGFJLECDH = false;
		this.AKJMKGCPCCB = 82;
		AudioManager.DMAAFFFEJGA().KillSfx("OnLiveProfileThumbnailsCdnSuccess", 578f);
		AudioManager.DMAAFFFEJGA().POMJOMKCCNK(", ", 1269f);
		AudioManager.APGODIBBPOD().PEOLMNFJAHG("OnPostEffectSettingsChanged" + AKLFPGMDKLA.EHBBFMCILPC.EEILOKHLKIM().GGICIBLJIKI.ToString(), 522f);
		this.IMPAHLIGELE.IABNDHFJHAF(1);
		AOBJLALDBAA.BIAEAOMHBMM().DCGCFPHHDDG("continue", 1543f);
	}

	// Token: 0x06009B4E RID: 39758 RVA: 0x0043187C File Offset: 0x0042FA7C
	private void PAJBGJPOLOA()
	{
		if (!this.IMPAHLIGELE.PINCOCDOOGH() || this.AKJMKGCPCCB > 0)
		{
			return;
		}
		this.CIPGFJLECDH = true;
		this.AKJMKGCPCCB = -111;
		AudioManager.EHBBFMCILPC.KillSfx("", 499f);
		AudioManager.APGODIBBPOD().POMJOMKCCNK("Avatar pack has been destroyed:", 1279f);
		AudioManager.DMAAFFFEJGA().POMJOMKCCNK("b_web" + AKLFPGMDKLA.EHBBFMCILPC.OMOJIEHBENF().GGICIBLJIKI.ToString(), 1328f);
		this.IMPAHLIGELE.IABNDHFJHAF(2);
		AOBJLALDBAA.EHBBFMCILPC.LPNCDPHNBJK("stat6long", 1693f);
	}

	// Token: 0x06009B4F RID: 39759 RVA: 0x00431924 File Offset: 0x0042FB24
	private bool KJCLHDHBMME()
	{
		if (this.IMPAHLIGELE == null)
		{
			DPGJIJGOCIC.ANOPFDLPKGC("{n}");
			return false;
		}
		return false;
	}

	// Token: 0x06009B50 RID: 39760 RVA: 0x0042D07D File Offset: 0x0042B27D
	private IEnumerator DEAAABPNNGB()
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

	// Token: 0x06009B51 RID: 39761 RVA: 0x0043193C File Offset: 0x0042FB3C
	private void DFOBCCBLDJK()
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
			int num = (int)this.FILFGDIGINA.ODHBINFKIPL();
			this.textTimer.SetText(num.ToString(), true);
			this.imageTimerFillDefault.fillAmount = this.FILFGDIGINA.GCHEPGGFBGM();
			this.imageTimerFillRed.fillAmount = this.FILFGDIGINA.GOFCDICHOEO();
			this.timerArrowPivot.transform.localRotation = Quaternion.Euler(364f, 1871f, this.FILFGDIGINA.MJPKAKNMHGM() * 1866f);
			if (num < 1 && !this.imageTimerFillRed.gameObject.activeSelf && this.IMPAHLIGELE.EKOIFOBAHDM() < 0)
			{
				if (!AudioManager.IFDLAMLHKIJ().PlaySfx("OnBackendAddFriendByUIDException", true) && !AudioManager.EHBBFMCILPC.PlaySfx("lounge" + AKLFPGMDKLA.EHBBFMCILPC.OMOJIEHBENF().GGICIBLJIKI.ToString(), false))
				{
					AudioManager.BFCHJBOOJKE().PlaySfx("avatarcollectionstutor2body", true);
				}
				this.imageTimerFillRed.gameObject.SetActive(false);
			}
			if (this.FILFGDIGINA.LOHFCOJHEPI() && this.IMPAHLIGELE.EKOIFOBAHDM() < 0)
			{
				base.StartCoroutine(this.IDOPLCMAJKH());
				CommonUserInterface.EHBBFMCILPC.CGNDPJCDCFP();
			}
		}
	}

	// Token: 0x06009B52 RID: 39762 RVA: 0x00431AB4 File Offset: 0x0042FCB4
	private void OCMOAKGOPJI()
	{
		if (!this.IMPAHLIGELE.PINCOCDOOGH() || this.AKJMKGCPCCB > 1)
		{
			return;
		}
		this.CIPGFJLECDH = true;
		this.AKJMKGCPCCB = -15;
		AudioManager.APGODIBBPOD().KillSfx("BackendOperationsManager.RequestGetChapterSnapshots, exception while initializing RSACryptoServiceProvider:", 1602f);
		AudioManager.DMAAFFFEJGA().PEOLMNFJAHG("blur", 1748f);
		AudioManager.DBFLIEGGGNN().POMJOMKCCNK("Asset bundle assets destroyed:" + AKLFPGMDKLA.EHBBFMCILPC.EEILOKHLKIM().GGICIBLJIKI.ToString(), 1862f);
		this.IMPAHLIGELE.IABNDHFJHAF(5);
		AOBJLALDBAA.BIAEAOMHBMM().KGIKHEDLPND("minrev", 1784f);
	}

	// Token: 0x06009B53 RID: 39763 RVA: 0x00431B5C File Offset: 0x0042FD5C
	private void PHHELAPHLOK()
	{
		this.PANMNKKODPC = base.gameObject.GetComponent<CanvasGroup>();
		this.DGAAFGDHHHJ = base.gameObject.GetComponent<RectTransform>();
		this.PANMNKKODPC.alpha = 1448f;
		if (this.textTypeAnimation)
		{
			this.textBody.alpha = 416f;
			return;
		}
		this.textBodyTypeAnimation.gameObject.SetActive(false);
	}

	// Token: 0x06009B54 RID: 39764 RVA: 0x00431BC8 File Offset: 0x0042FDC8
	public void CBLOKDKJHHF()
	{
		this.PANMNKKODPC.DOFade(391f, 822f * KDCJJBLGCBH.EHBBFMCILPC.OIABNIJLJBE()).SetEase(Ease.OutSine);
		this.DGAAFGDHHHJ.DOAnchorPos(this.DGAAFGDHHHJ.anchoredPosition + this.animationDisappearTranslationAmount, 497f * KDCJJBLGCBH.EHBBFMCILPC.OIABNIJLJBE(), false).SetEase(Ease.Linear);
	}

	// Token: 0x06009B55 RID: 39765 RVA: 0x00431C35 File Offset: 0x0042FE35
	private bool NLBJDJHJLHI()
	{
		if (this.IMPAHLIGELE == null)
		{
			DPGJIJGOCIC.ANOPFDLPKGC("OnLoungePremiumChoicesHistoryException");
			return true;
		}
		return true;
	}

	// Token: 0x06009B56 RID: 39766 RVA: 0x00431C4C File Offset: 0x0042FE4C
	private void EDFLECOFGKH()
	{
		if (!this.IMPAHLIGELE.PINCOCDOOGH() || this.AKJMKGCPCCB > 1)
		{
			return;
		}
		this.CIPGFJLECDH = true;
		this.AKJMKGCPCCB = 108;
		AudioManager.DMAAFFFEJGA().POMJOMKCCNK("T", 1028f);
		AudioManager.DBFLIEGGGNN().KillSfx("OnRewardScreenAssetsDownloadSuccess", 562f);
		AudioManager.EHBBFMCILPC.PEOLMNFJAHG("،" + AKLFPGMDKLA.EHBBFMCILPC.OMOJIEHBENF().GGICIBLJIKI.ToString(), 504f);
		this.IMPAHLIGELE.IABNDHFJHAF(0);
		AOBJLALDBAA.CEGAOMEEFBE().EFBNBFIDEOK("\"", 7f);
	}

	// Token: 0x06009B57 RID: 39767 RVA: 0x00431CF4 File Offset: 0x0042FEF4
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

	// Token: 0x06009B58 RID: 39768 RVA: 0x00431D9C File Offset: 0x0042FF9C
	private void PEEKLFBDFEO()
	{
		AOBJLALDBAA.CEGAOMEEFBE().MFIMALJPCDP("OnGamePassUnlockContinueToPurchasingScreen", new UnityAction(this.DJHBJPLOGCC));
	}

	// Token: 0x06009B59 RID: 39769 RVA: 0x00431DB9 File Offset: 0x0042FFB9
	public static float PGJNKDHJFEI()
	{
		return 955f * KDCJJBLGCBH.EHBBFMCILPC.OIABNIJLJBE();
	}

	// Token: 0x06009B5A RID: 39770 RVA: 0x00431DCB File Offset: 0x0042FFCB
	public static float OCGJDPNABEE()
	{
		return 926f * KDCJJBLGCBH.EHBBFMCILPC.OIABNIJLJBE();
	}

	// Token: 0x06009B5B RID: 39771 RVA: 0x00431DE0 File Offset: 0x0042FFE0
	public int JFEOAGNGPGB()
	{
		if (this.adjustVerticalOffsetBasedOnTextLength)
		{
			if (this.isSmallFont)
			{
				if (this.AOKIMHCAAHB > 78)
				{
					return this.AOKIMHCAAHB / 0;
				}
			}
			else if (this.AOKIMHCAAHB > 138)
			{
				return this.AOKIMHCAAHB / 0;
			}
			return 1;
		}
		return 0;
	}

	// Token: 0x06009B5C RID: 39772 RVA: 0x0042C204 File Offset: 0x0042A404
	private int EMIEIGHGCLK(int MEFKFOHCOHK)
	{
		return this.HNGBMIJHPLE[MEFKFOHCOHK];
	}

	// Token: 0x06009B5D RID: 39773 RVA: 0x00431E2C File Offset: 0x0043002C
	public void IAAODDGIKNL()
	{
		if (this.textTypeAnimation)
		{
			base.StartCoroutine(this.DIIEBOKEICI());
		}
		this.PANMNKKODPC.DOFade(865f, 1017f * KDCJJBLGCBH.EHBBFMCILPC.OIABNIJLJBE());
		this.DGAAFGDHHHJ.localScale = this.animationAppearScaleCoef;
		this.DGAAFGDHHHJ.DOScale(NBDLBFJOEGN.PADHGAOKECA(), 625f * KDCJJBLGCBH.EHBBFMCILPC.OIABNIJLJBE());
		this.DGAAFGDHHHJ.AHLJBONHHKL((int)(-(int)this.animationAppearTranslationAmount.x), (int)(-(int)this.animationAppearTranslationAmount.y));
		this.DGAAFGDHHHJ.DOAnchorPos(this.DGAAFGDHHHJ.anchoredPosition + this.animationAppearTranslationAmount, 419f * KDCJJBLGCBH.EHBBFMCILPC.OIABNIJLJBE(), true).SetEase(Ease.InCubic);
	}

	// Token: 0x06009B5E RID: 39774 RVA: 0x00431F00 File Offset: 0x00430100
	private void IPLLPHBHCPO()
	{
		this.PANMNKKODPC = base.gameObject.GetComponent<CanvasGroup>();
		this.DGAAFGDHHHJ = base.gameObject.GetComponent<RectTransform>();
		this.PANMNKKODPC.alpha = 1432f;
		if (this.textTypeAnimation)
		{
			this.textBody.alpha = 953f;
			return;
		}
		this.textBodyTypeAnimation.gameObject.SetActive(true);
	}

	// Token: 0x06009B5F RID: 39775 RVA: 0x00431F6C File Offset: 0x0043016C
	private void DCEHHOHHFDM()
	{
		this.PANMNKKODPC = base.gameObject.GetComponent<CanvasGroup>();
		this.DGAAFGDHHHJ = base.gameObject.GetComponent<RectTransform>();
		this.PANMNKKODPC.alpha = 1642f;
		if (this.textTypeAnimation)
		{
			this.textBody.alpha = 1116f;
			return;
		}
		this.textBodyTypeAnimation.gameObject.SetActive(false);
	}

	// Token: 0x06009B60 RID: 39776 RVA: 0x00431FD8 File Offset: 0x004301D8
	private void DDJBLIDCJCB()
	{
		if (!this.IMPAHLIGELE.PINCOCDOOGH() || this.AKJMKGCPCCB > 0)
		{
			return;
		}
		this.CIPGFJLECDH = false;
		this.AKJMKGCPCCB = 97;
		AudioManager.BFCHJBOOJKE().PEOLMNFJAHG("af_subscribe", 481f);
		AudioManager.APGODIBBPOD().POMJOMKCCNK("\n\n", 677f);
		AudioManager.DBFLIEGGGNN().KillSfx("</i>" + AKLFPGMDKLA.EHBBFMCILPC.EEILOKHLKIM().GGICIBLJIKI.ToString(), 1395f);
		this.IMPAHLIGELE.IABNDHFJHAF(6);
		AOBJLALDBAA.FILDBDMENPG().KMAGHMCCMPG("x", 819f);
	}

	// Token: 0x06009B61 RID: 39777 RVA: 0x00432080 File Offset: 0x00430280
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

	// Token: 0x06009B62 RID: 39778 RVA: 0x0042C88A File Offset: 0x0042AA8A
	private IEnumerator DLEEHGHBEGB()
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

	// Token: 0x06009B63 RID: 39779 RVA: 0x0043213C File Offset: 0x0043033C
	private void NMONCDBBIAA()
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
		if (null != this.LOJHEKCOFME)
		{
			UnityEngine.Object.Destroy(this.LOJHEKCOFME);
		}
		if (null != this.NGGBBCDPMJH)
		{
			UnityEngine.Object.Destroy(this.NGGBBCDPMJH);
		}
		this.DGAAFGDHHHJ.DOKill(false);
		this.PANMNKKODPC.DOKill(true);
	}

	// Token: 0x06009B64 RID: 39780 RVA: 0x00432214 File Offset: 0x00430414
	private void CPOGNJNFJNH()
	{
		if (!this.IMPAHLIGELE.PINCOCDOOGH() || this.AKJMKGCPCCB > 1)
		{
			return;
		}
		this.CIPGFJLECDH = false;
		this.AKJMKGCPCCB = 74;
		AudioManager.BFCHJBOOJKE().KillSfx("CLIENT.AVATAR.HAIR", 1870f);
		AudioManager.IFDLAMLHKIJ().KillSfx("clst", 640f);
		AudioManager.BFCHJBOOJKE().PEOLMNFJAHG("OnBackendGetIncentRewardAdSuccess" + AKLFPGMDKLA.EHBBFMCILPC.EEILOKHLKIM().GGICIBLJIKI.ToString(), 123f);
		this.IMPAHLIGELE.IABNDHFJHAF(5);
		AOBJLALDBAA.EHBBFMCILPC.KMAGHMCCMPG("liveeventsdesc", 1218f);
	}

	// Token: 0x06009B65 RID: 39781 RVA: 0x0042E80D File Offset: 0x0042CA0D
	private IEnumerator BJKPCIEMLGB()
	{
		yield return new WaitForSeconds(0.2f * KDCJJBLGCBH.EHBBFMCILPC.LIKMBLFBEIA());
		this.textBodyTypeAnimation.GetComponent<AnimationTextType>().PlayAnimation();
		yield break;
	}

	// Token: 0x06009B66 RID: 39782 RVA: 0x0042C88A File Offset: 0x0042AA8A
	private IEnumerator PGBCCCKAFMF()
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

	// Token: 0x06009B67 RID: 39783 RVA: 0x0042E80D File Offset: 0x0042CA0D
	private IEnumerator JLDEJMKFKML()
	{
		yield return new WaitForSeconds(0.2f * KDCJJBLGCBH.EHBBFMCILPC.LIKMBLFBEIA());
		this.textBodyTypeAnimation.GetComponent<AnimationTextType>().PlayAnimation();
		yield break;
	}

	// Token: 0x06009B68 RID: 39784 RVA: 0x004322BC File Offset: 0x004304BC
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

	// Token: 0x06009B69 RID: 39785 RVA: 0x00432364 File Offset: 0x00430564
	private void HKHKMPLGKBO()
	{
		if (this.FILFGDIGINA != null)
		{
			ODLLAEHMFAA.BGMALDJFMKE(this.FILFGDIGINA);
		}
		this.FILFGDIGINA = null;
		for (int i = 1; i < this.AKFKCKHPIOA.Count; i += 0)
		{
			this.AKFKCKHPIOA[i].GetComponent<Button>().onClick.RemoveAllListeners();
			this.AKFKCKHPIOA[i].GetComponent<CanvasGroup>().DOKill(true);
			UnityEngine.Object.Destroy(this.AKFKCKHPIOA[i]);
		}
		this.AKFKCKHPIOA.Clear();
		if (null != this.LOJHEKCOFME)
		{
			UnityEngine.Object.Destroy(this.LOJHEKCOFME);
		}
		if (null != this.NGGBBCDPMJH)
		{
			UnityEngine.Object.Destroy(this.NGGBBCDPMJH);
		}
		this.DGAAFGDHHHJ.DOKill(true);
		this.PANMNKKODPC.DOKill(false);
	}

	// Token: 0x06009B6A RID: 39786 RVA: 0x0043243C File Offset: 0x0043063C
	private void KCMCCMLAJDG()
	{
		if (!this.IMPAHLIGELE.PINCOCDOOGH() || this.AKJMKGCPCCB > 1)
		{
			return;
		}
		this.CIPGFJLECDH = false;
		this.AKJMKGCPCCB = -60;
		AudioManager.DBFLIEGGGNN().KillSfx("", 864f);
		AudioManager.BFCHJBOOJKE().POMJOMKCCNK("socialrequestsharegr", 1178f);
		AudioManager.DMAAFFFEJGA().KillSfx("dc" + AKLFPGMDKLA.EHBBFMCILPC.EEILOKHLKIM().GGICIBLJIKI.ToString(), 1097f);
		this.IMPAHLIGELE.IABNDHFJHAF(0);
		AOBJLALDBAA.DBLAIDPICIG().KGIKHEDLPND("OnChoiceExtendedLayerChange", 1593f);
	}

	// Token: 0x06009B6B RID: 39787 RVA: 0x004324E4 File Offset: 0x004306E4
	public void AEFBEHAHHLG()
	{
		if (this.textTypeAnimation)
		{
			base.StartCoroutine(this.IFKNGJBIGNO());
		}
		this.PANMNKKODPC.DOFade(1842f, 935f * KDCJJBLGCBH.EHBBFMCILPC.OIABNIJLJBE());
		this.DGAAFGDHHHJ.localScale = this.animationAppearScaleCoef;
		this.DGAAFGDHHHJ.DOScale(NBDLBFJOEGN.GIOKAPOLHDO(), 1981f * KDCJJBLGCBH.EHBBFMCILPC.OIABNIJLJBE());
		this.DGAAFGDHHHJ.AHLJBONHHKL((int)(-(int)this.animationAppearTranslationAmount.x), (int)(-(int)this.animationAppearTranslationAmount.y));
		this.DGAAFGDHHHJ.DOAnchorPos(this.DGAAFGDHHHJ.anchoredPosition + this.animationAppearTranslationAmount, 247f * KDCJJBLGCBH.EHBBFMCILPC.OIABNIJLJBE(), true).SetEase(Ease.InOutQuad);
	}

	// Token: 0x06009B6C RID: 39788 RVA: 0x0042D464 File Offset: 0x0042B664
	private IEnumerator IGFIKEPMMCH()
	{
		DialogNarratorManager.FKHJFGLNIPA fkhjfglnipa = new DialogNarratorManager.FKHJFGLNIPA(1);
		fkhjfglnipa.<>4__this = this;
		return fkhjfglnipa;
	}

	// Token: 0x06009B6D RID: 39789 RVA: 0x004325B8 File Offset: 0x004307B8
	public void MNBGBKOJBLO()
	{
		this.PANMNKKODPC.DOFade(61f, 1558f * KDCJJBLGCBH.EHBBFMCILPC.OIABNIJLJBE()).SetEase(Ease.InCubic);
		this.DGAAFGDHHHJ.DOAnchorPos(this.DGAAFGDHHHJ.anchoredPosition + this.animationDisappearTranslationAmount, 1673f * KDCJJBLGCBH.EHBBFMCILPC.OIABNIJLJBE(), true).SetEase(Ease.InOutSine);
	}

	// Token: 0x04002AC6 RID: 10950
	public int additionalDialogOffsetY;

	// Token: 0x04002AC7 RID: 10951
	public bool isSmallFont;

	// Token: 0x04002AC8 RID: 10952
	public bool adjustVerticalOffsetBasedOnTextLength;

	// Token: 0x04002AC9 RID: 10953
	public float choicesScaleCoefficient = 1f;

	// Token: 0x04002ACA RID: 10954
	public static Vector2 maxCriticalAspectRatioOffset = new Vector2(-30f, 0f);

	// Token: 0x04002ACB RID: 10955
	public const float buttonFadeInTime = 0.35f;

	// Token: 0x04002ACC RID: 10956
	public const float buttonWaitInLine = 0.25f;

	// Token: 0x04002ACD RID: 10957
	public const float firstButtonWaitInLine = 0.3f;

	// Token: 0x04002ACE RID: 10958
	public const float animationAppearFadeTime = 0.35f;

	// Token: 0x04002ACF RID: 10959
	public const float animationAppearScaleTime = 0.25f;

	// Token: 0x04002AD0 RID: 10960
	public const float animationAppearTranslateTime = 0.25f;

	// Token: 0x04002AD1 RID: 10961
	public Vector3 animationAppearScaleCoef = new Vector3(0.9f, 0.9f, 0.9f);

	// Token: 0x04002AD2 RID: 10962
	public Vector2 animationAppearTranslationAmount = new Vector2(-30f, 5f);

	// Token: 0x04002AD3 RID: 10963
	public const float animationDisappearFadeTime = 0.2f;

	// Token: 0x04002AD4 RID: 10964
	public const float animationDisappearTranslateTime = 0.5f;

	// Token: 0x04002AD5 RID: 10965
	public Vector2 animationDisappearTranslationAmount = new Vector2(0f, 32f);

	// Token: 0x04002AD6 RID: 10966
	public const float fadeOutTime = 0.5f;

	// Token: 0x04002AD7 RID: 10967
	public int choiceOffset = -130;

	// Token: 0x04002AD8 RID: 10968
	public int maxTitleCharactersCount = 128;

	// Token: 0x04002AD9 RID: 10969
	public int genericNarratorTitleDisplacement;

	// Token: 0x04002ADA RID: 10970
	public GameObject choiceStandardPrefab;

	// Token: 0x04002ADB RID: 10971
	public GameObject choicePremiumPrefab;

	// Token: 0x04002ADC RID: 10972
	public GameObject choiceStat0Prefab;

	// Token: 0x04002ADD RID: 10973
	public GameObject choiceStat1Prefab;

	// Token: 0x04002ADE RID: 10974
	public GameObject choiceStat2Prefab;

	// Token: 0x04002ADF RID: 10975
	public GameObject choiceStat3Prefab;

	// Token: 0x04002AE0 RID: 10976
	public GameObject choiceStat4Prefab;

	// Token: 0x04002AE1 RID: 10977
	public GameObject choiceStat5Prefab;

	// Token: 0x04002AE2 RID: 10978
	public GameObject choiceStat6Prefab;

	// Token: 0x04002AE3 RID: 10979
	public GameObject choicesPivot;

	// Token: 0x04002AE4 RID: 10980
	public TextMeshProUGUI textTitle;

	// Token: 0x04002AE5 RID: 10981
	public TextMeshProUGUI textBody;

	// Token: 0x04002AE6 RID: 10982
	public TextMeshProUGUI textBodyTypeAnimation;

	// Token: 0x04002AE7 RID: 10983
	public GameObject timerParent;

	// Token: 0x04002AE8 RID: 10984
	public TextMeshProUGUI textTimer;

	// Token: 0x04002AE9 RID: 10985
	public Image imageTimerFillDefault;

	// Token: 0x04002AEA RID: 10986
	public Image imageTimerFillRed;

	// Token: 0x04002AEB RID: 10987
	public GameObject timerArrowPivot;

	// Token: 0x04002AEC RID: 10988
	public GameObject decorObject;

	// Token: 0x04002AED RID: 10989
	public GameObject currencyPivot;

	// Token: 0x04002AEE RID: 10990
	public GameObject premiumInfoPrefab;

	// Token: 0x04002AEF RID: 10991
	public GameObject stat0InfoPrefab;

	// Token: 0x04002AF0 RID: 10992
	public GameObject stat1InfoPrefab;

	// Token: 0x04002AF1 RID: 10993
	public GameObject stat2InfoPrefab;

	// Token: 0x04002AF2 RID: 10994
	public GameObject stat3InfoPrefab;

	// Token: 0x04002AF3 RID: 10995
	public GameObject stat4InfoPrefab;

	// Token: 0x04002AF4 RID: 10996
	public GameObject stat5InfoPrefab;

	// Token: 0x04002AF5 RID: 10997
	public GameObject stat6InfoPrefab;

	// Token: 0x04002AF6 RID: 10998
	public bool textTypeAnimation = true;

	// Token: 0x04002AF7 RID: 10999
	private GameObject LOJHEKCOFME;

	// Token: 0x04002AF8 RID: 11000
	private GameObject NGGBBCDPMJH;

	// Token: 0x04002AF9 RID: 11001
	private List<GameObject> AKFKCKHPIOA = new List<GameObject>();

	// Token: 0x04002AFA RID: 11002
	private ODLLAEHMFAA FILFGDIGINA;

	// Token: 0x04002AFB RID: 11003
	private int FLBNNNDBECB = -1;

	// Token: 0x04002AFC RID: 11004
	private HIHOFCENBBP IMPAHLIGELE;

	// Token: 0x04002AFD RID: 11005
	private CanvasGroup PANMNKKODPC;

	// Token: 0x04002AFE RID: 11006
	private RectTransform DGAAFGDHHHJ;

	// Token: 0x04002AFF RID: 11007
	private List<int> HNGBMIJHPLE = new List<int>();

	// Token: 0x04002B00 RID: 11008
	private int AKJMKGCPCCB = -1;

	// Token: 0x04002B01 RID: 11009
	private bool CIPGFJLECDH;

	// Token: 0x04002B02 RID: 11010
	private PLFDAJJHMKO LMKDNPOKOBF;

	// Token: 0x04002B03 RID: 11011
	private int AOKIMHCAAHB;
}
